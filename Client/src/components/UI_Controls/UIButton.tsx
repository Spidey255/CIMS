import React from "react";

import type {
  IActionParams,
  IBindingData,
  IGlobalStateValues,
  IOnActionResponse,
  TValue,
  UIElement,
  ServiceElementData,
} from "@/constants/types";

import { useGeneralStore } from "@/store/useStore";
import axiosHelper from "@/helpers/axiosHelper";
import { useUserStore } from "@/store/useUserStore";
import { useGridStore } from "@/store/useGridStore";
import { getISpaceAbsoluteUrl } from "@/helpers/utils";

const UIButton: React.FC<{ element: UIElement }> = ({ element }) => {
  const slotId = useUserStore((store) => store.slotId);

  const {
    setGridDynamicState,
    setCurrentPage,
    setPageSize,
    setTotalItems,
  } = useGridStore();

  const handleOnClick = async () => {
    try {
      if (!element.BindingDetail) return;

      const bindingDetails = JSON.parse(
        element.BindingDetail
      ) as IBindingData[];

      if (!bindingDetails.length) return;

      const details = bindingDetails[0];
      const params = JSON.parse(details.Params) as IActionParams[];

      /* ---------------- FETCH STATE VALUES ---------------- */
      const elementNames = params.map((p) => p.ElementName);

      const fetchedStateValues = elementNames.reduce(
        (acc, name) => {
          acc[name] =
            useGeneralStore.getState().state[name]?.value ?? "";
          return acc;
        },
        {} as Record<string, TValue | undefined>
      );

      const stateParams = Object.entries(fetchedStateValues).map(
        ([key, value]) => ({
          ElementId: key,
          Value: value,
        })
      );

      const postData = {
        SlotId: slotId,
        ControlId: element.ElementId.includes("+")
          ? element.ElementId.split("+")[2]
          : element.ElementId,
        PackageProcessMapId: element.PackageProcessMapId,
        ProcessActivityMapId: element.ProcessActivityMapId,
        ViewPort: 4,
        Action: element.Action,
        JsxFileName: "",
        JsxFileVersion: "",
        Params: stateParams,
      };

      const response = (await axiosHelper<IOnActionResponse>(
        details.Endpoint,
        details.HttpVerb,
        postData
      )) as IOnActionResponse;

      const rows = (response.rows ?? []) as ServiceElementData[];

      if (!rows.length) return;

      /* ---------------- REDIRECTION ---------------- */
      const redirect = rows.find((r) => r.redirectType);

      if (redirect) {
        if (redirect.redirectType === 1 && redirect.value) {
          window.location.href = getISpaceAbsoluteUrl(
            element.VersionName,
            redirect.value
          );
          return;
        }

        if (redirect.redirectType === 2) {
          window.location.href = "/";
          return;
        }
      }

      /* ---------------- NORMAL CONTROL UPDATE ---------------- */
      const updateState: Record<string, IGlobalStateValues> = {};

      rows
        .filter((r) => !r.redirectType && !r.child)
        .forEach((r) => {
          if (r.elementId) {
            updateState[r.elementId] = { value: r.value };
          }
        });

      /* ---------------- GRID UPDATE ---------------- */
      rows
        .filter((r) => r.child && r.child.length)
        .forEach((row) => {
          if (!row.elementId) return;

          const elementMapper =
            useGridStore.getState().gridElementMapper[row.elementId];

          if (!elementMapper) return;

          row.child?.forEach((gridRow: ServiceElementData) => {
            gridRow.child?.forEach((cell: ServiceElementData) => {
              updateState[
                `${elementMapper.uiElementId}+${gridRow.rwId}+${cell.elementId}`
              ] = {
                value:
                  typeof cell.value === "object"
                    ? ""
                    : cell.value ?? "",
              };
            });
          });

          const gridKey = elementMapper.uiElementId;

          setGridDynamicState(gridKey, row.child);

          setCurrentPage(gridKey, 1);
          setPageSize(gridKey, 5);
          setTotalItems(gridKey, row.child?.length ?? 0);
        });

      useGeneralStore.getState().updateInitialState(updateState);
    } catch (error) {
      console.error(error);
      alert("Something went wrong");
    }
  };

  return (
    <div
      id={element.ElementId || element.UIElementid}
      className={element.ColumnCss}
      onClick={(e) => {
        e.stopPropagation();
        handleOnClick();
      }}
    >
      <div className="form-group">
        <div className="controls">
          <span title={element.ElementName}>
            <a
              id={`btn_${element.ElementId}`}
              className={element.Css}
              title={element.DCaption}
            >
              {element.DCaption}
            </a>
          </span>
        </div>
      </div>
    </div>
  );
};

export default UIButton;
