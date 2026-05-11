// Innovace Intech Solution Pvt Ltd
import React, { useState } from "react";
import { v4 } from "uuid";
import _ from "lodash";
import { useGeneralStore } from "@/store/useStore";
import type { IAppResponse, UIElement } from "@/constants/types";
import axiosHelper from "@/helpers/axiosHelper";
import { useUserStore } from "@/store/useUserStore";
import { config } from "@/constants/config";
import { usePageStore } from "@/store/usePageStore";

interface IGlobalSaveProps {
  onSave?: (formInstanceId?: string) => void;
  elements?: UIElement[];
}

const GlobalSave: React.FC<IGlobalSaveProps> = ({ elements, onSave }) => {
  const slotId = useUserStore((store) => store.slotId);
  const activePage = usePageStore((state) => state.activePage);

  const [loading, setLoading] = useState(false);
  const [_success, setSuccess] = useState<string | null>(null);
  const [_error, setError] = useState<string | null>(null);


  const handleSave = async () => {
    try {
      if (!elements?.length) return;

      setLoading(true);
      setSuccess(null);
      setError(null);

      const state = useGeneralStore.getState().state;
      const formInstanceId = v4();

      const saveAllPromises = elements.map(async (element) => {
        let FormData: object[] = [];
        let Action = "FormSave";

        if (element.ControlType === "Grid") {
          Action = "GridSave";

          const gridElements = Object.entries(state).filter(
            ([key]) =>
              key.includes("+") && key.startsWith(`${element.ElementName}+`)
          );

          const groupedElements = _.groupBy(
            gridElements,
            ([key]) => key.split("+")[1]
          );

          const gridFormattedData = Object.entries(groupedElements).map(
            ([RwId, rowData], index) => ({
              RwId,
              Seq: index + 1,
              Child: rowData.map(([key, { value }]: any) => {
                const elementName = key.split("+")[2];

                return {
                  ElementName: elementName,
                  Value: value ?? null,
                  // ✅ Take EDT from base element definition
                  EDT: state[elementName]?.EDT ?? null,
                };
              }),
            })
          );


          FormData = [
            {
              ElementId: element.ElementId,
              ElementName: element.ElementName,
              Child: gridFormattedData,
            },
          ];
        } else {
          const formattedData = Object.entries(state)
            .filter(([key]) => !key.includes("+"))
            .map(([ElementName, value]: any) => ({
              ElementName,
              Value: value?.value ?? null,
              EDT: value?.EDT,
            }));

          FormData = [
            {
              ElementId: element.ElementId,
              ElementName: element.ElementName,
              Child: formattedData,
            },
          ];
        }

        const postData = {
          SlotId: slotId,
          ControlId: element["ElementName"],
          PackageProcessMapId: activePage?.["PackageProcessMapId"],
          ProcessActivityMapId: activePage?.["ProcessActivityMapId"],
          ViewPort: 4,
          Action,
          FormInstanceId: formInstanceId,
          WidgetId: element["WidgetId"],
          JsxFileName: "",
          JsxFileVersion: "",
          Params: [],
          FormData,
        };

        return axiosHelper<IAppResponse>(config.SAVE_WIDGET_URL, "POST", postData);
      });

      await Promise.all(saveAllPromises);

      setSuccess(`Form saved successfully — ID: ${formInstanceId}`);
      setLoading(false);
      if (onSave) onSave(formInstanceId);
    } catch (err) {
      console.error(err);
      setError("Unable to save form. Try again.");
      setLoading(false);
    }
  };

  const handleCancel = () => {
    setSuccess(null);
    setError(null);
  };

  return (
    <div
      className="bg-white p-2 shadow rounded-2 d-flex  justify-content-end border"
      style={{
        // position: "fixed",
        bottom: 20,
        right: 10,
        minWidth: 260,
        margin: "0px 10px",
        zIndex: 1080,
      }}
    >
      {/* <div className="fw-bold mb-1">Form Actions</div>
      <div className="text-muted small mb-3">Save or cancel changes</div> */}

      <div className="d-flex gap-2 justify-content-end">



        {/* Cancel Button */}
        <button
          className="btn btn-outline-secondary d-flex align-items-center w-50"
          onClick={handleCancel}
          disabled={loading}
        >
          <i className="ph-x-circle me-2 fs-5"></i>
          Cancel
        </button>
        {/* Save Button */}
        <button
          className="btn btn-primary d-flex align-items-center w-50"
          onClick={handleSave}
          disabled={loading}
        >
          {loading ? (
            <>
              <span className="spinner-border spinner-border-sm me-2"></span>
              Saving...
            </>
          ) : (
            <>
              <i className="ph-floppy-disk me-2 fs-5"></i>
              Save
            </>
          )}
        </button>
      </div>

      {/* Alerts */}

      {/* <div className="mt-3">
        {success && <div className="alert alert-success py-2 small">{success}</div>}
        {error && <div className="alert alert-danger py-2 small">{error}</div>}
      </div> */}
    </div>
  );
};

export default GlobalSave;
