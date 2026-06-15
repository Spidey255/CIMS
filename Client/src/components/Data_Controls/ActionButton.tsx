// Innovace Intech Solution Pvt Ltd
import React, { useState } from "react";
import { useNavigate, useLocation } from "react-router-dom";

import {
  type IActionParams,
  type IBindingData,
  type IGlobalStateValues,
  type IAppResponse,
  type TValue,
  type UIElement,
  RedirectType,
} from "../../constants/types";
import { config } from "@/constants/config";
import { useGeneralStore } from "../../store/useStore";
import axiosHelper from "../../helpers/axiosHelper";
import { useUserStore } from "../../store/useUserStore";
import { useGridStore } from "../../store/useGridStore";
import { usePageStore } from "@/store/usePageStore";
import { useRedirectStore } from "@/store/useRedirectStore";
import { pages } from "@/constants/pages";
import { useLoaderStore } from "@/store/useLoaderStore";
import { saveGrid } from "@/helpers/saveGridHelper";
import { saveForm } from "@/helpers/saveGridHelper";
import toast from "react-hot-toast";

interface ActionButtonProps {
  element: UIElement;
  gridElements: UIElement[]; // replace any with correct type
}

const ActionButton: React.FC<ActionButtonProps> = ({
  element,
  gridElements,
}) => {
  const navigate = useNavigate();
  const location = useLocation();
  const slotId = useUserStore((store) => store.slotId);
  const setPagination = useGridStore((store) => store.setPagination);
  const setGridDynamicState = useGridStore(
    (store) => store.setGridDynamicState
  );
  const updateUIElementState = useGeneralStore(
    (store) => store.updateUIElementState
  );

  const state = useGeneralStore(
    (store) => store.state[element.ElementName]?.value
  );

  const Css = useGeneralStore(
    (store) => store.state[element.ElementName]?.Css
  ) || "";
  const setRedirectParams = useRedirectStore.getState().setParams;

  const activePage = usePageStore((store) => store.activePage);
  const formInstanceId = usePageStore((store) => store.formInstanceId);

  const showLoader = useLoaderStore((s) => s.show);
  const hideLoader = useLoaderStore((s) => s.hide);


  const [loading, setLoading] = useState(false);

  const handleOnClick = async () => {
    try {
      setLoading(true);
      showLoader();




      // Loop over query parameters and add them to the params object



      const getUrlParams = (url: string | null) => {
        if (!url) return null;

        const params: Record<string, string> = {};
        const urlParams = new URLSearchParams(url);

        urlParams.forEach((value, key) => {
          params[key] = value;
        });

        return params;
      };

      const redirectParams = useRedirectStore.getState().params; // This will now persist even after reload
      const redirectUrlParams = getUrlParams(redirectParams?.RedirectUrl || location?.search);





      // Get all grid elements
      const gridElementsToSave = gridElements.filter(g => g.ControlType === "Grid");

      // Get all form elements except grid elements
      const formElementsToSave = gridElements.filter(
        g => g.ControlType !== "Grid"
      );

      if (formElementsToSave.length && element.ElementName == "SubmitForm") {
        const savedInstanceId = await saveForm({ elements: formElementsToSave, formInstanceId });
        console.log("Grids saved successfully — IDs:", savedInstanceId);
      }

      if (gridElementsToSave.length) {
        const savedInstanceId = await saveGrid({ elements: gridElementsToSave, formInstanceId });
        console.log("Grids saved successfully — IDs:", savedInstanceId);
      }

      if (!element.BindingDetail) {
        console.log("No BindingDetail Found");
        return;
      }

      const bindingDetails = JSON.parse(
        element.BindingDetail
      ) as IBindingData[];

      if (!bindingDetails.length) {
        console.log("No Content in BindingDetail");
        return;
      }

      const details = bindingDetails[0];
      const url = details.Endpoint.replace(/^~(?=\/)/, config.BASE_URL);
      const method = details.HttpVerb;

      // ==============================
      // PARAM COLLECTION (UNCHANGED)
      // ==============================
      const params = details.Params
        ? (JSON.parse(details.Params) as IActionParams[])
        : [];

      let elementIds = params.map((p) => p.ElementName);

      if (element.ElementName.includes("+")) {
        const [id, rwId] = element.ElementName.split("+");
        const rowId = `${id}+${rwId}`;
        elementIds = params.map((p) => `${rowId}+${p.ElementName}`);
      }

      const edtMap = params.reduce((acc, p) => {
        acc[p.ElementName] = p.EDT;
        return acc;
      }, {} as Record<string, number | null>);

      const storeState = useGeneralStore.getState().state;

      const getActualElementName = (name: string) =>
        name.includes("+") ? name.split("+").pop()! : name;

      const actualNameMap: Record<string, IGlobalStateValues> = {};

      Object.keys(storeState).forEach((key) => {
        const actual = getActualElementName(key);
        actualNameMap[actual] = storeState[key];
      });

      const fetchedStateValues = elementIds.reduce((acc, id) => {
        // Full key when clicked from grid row
        if (element.ElementName.includes("+")) {
          const fullKey = id; // TaskStep+UUID+TaskStep_RowId

          acc[id.split("+")[2]] =
            storeState[fullKey]?.value ??
            "";
        } else {
          // Non-grid normal flow (UNCHANGED)
          const elementId = id;
          acc[elementId] =
            actualNameMap[elementId]?.value ??
            "";
        }

        return acc;
      }, {} as Record<string, TValue | undefined>);


      const stateParams = Object.entries(fetchedStateValues).map(
        ([id, value]) => ({
          ElementName: id,
          Value: edtMap[id] === 1 && typeof value === "string"
        ? value.split("#")[0]
        : value,
          EDT: edtMap[id] ?? null,
        })
      );

      const MF_d2_DocId = sessionStorage.getItem('MF_d2_DocId') || '';

      // Update the element in stateParams
      const updatedStateParams = stateParams.map(item => {
        if (item.ElementName === 'MF_d1_invoice_id') {
          return { ...item, Value: MF_d2_DocId }; // replace Value
        }
        return item;
      })

      // ==============================
      // API CALL
      // ==============================
      const postData = {
        SlotId: slotId,
        ControlId: element.ElementName.includes("+")
          ? element.ElementName.split("+")[2]
          : element.ElementName,
        PackageProcessMapId: activePage?.PackageProcessMapId,
        ProcessActivityMapId: activePage?.ProcessActivityMapId,
        FormVersionId: activePage?.FormVersionId,
        ViewPort: 4,
        Action: element.Action,
        FormInstanceId: redirectUrlParams?.instanceId ?? formInstanceId ?? null,
        JsxFileName: "",
        JsxFileVersion: "",
        Params: updatedStateParams || stateParams,
      };

      const data = await axiosHelper<IAppResponse>(url, method, postData);

      if (!data.Rows) {
        console.log("No rows in response");
        return;
      }

      if (data.Message) {
        if (data.Message.split(":")[0].toLowerCase() === "success") {
          toast.success(data.Message.split(":")[1]);
        } else if (data.Message.split(":")[0].toLowerCase() === "warning") {
          toast.error(data.Message.split(":")[1]);
        } else if (data.Message.split(":")[0].toLowerCase() === "error") {
          toast.error(data.Message.split(":")[1]);
        } else {
          toast.error(data.Message.split(":")[1]);
        }
        // toast.error(data.Message);

      }

      // =====================================================
      // ✅ NEW: UPDATE GENERAL STORE FROM API RESPONSE
      // =====================================================
      const generalStateUpdate: Record<string, IGlobalStateValues> = {};
      const currentState = useGeneralStore.getState().state;
      const redirectPayload: Record<string, any> = {};


      data.Rows.forEach((row) => {
        if (row.ElementName && row.Value !== undefined && row.Value !== null) {
          redirectPayload[row.ElementName] = row.Value;
        }
      });
      setRedirectParams(redirectPayload);

      // data.Rows
      //   .filter((row) => row.ElementName)
      //   .forEach((row) => {
      //     generalStateUpdate[row.ElementName!] = {
      //       ...currentState[row.ElementName!], // keep existing behavior
      //       value: row.Value ?? "",

      //       // ✅ ADD (does NOT affect existing logic)
      //       ShowDialog: row.ShowDialog ?? false,
      //       HideDialog: row.HideDialog ?? false,
      //       ShowModal: row.ShowModal ?? false,
      //       isVisible: row.Visible,
      //       visible: row.Visible,
      //       Css: row.CSS || "",
      //     };
      //   });

      data.Rows
        .filter((row) => row.ElementName)
        .forEach((row) => {
          const updatedState: any = {
            ...currentState[row.ElementName!],
            value: row.Value ?? "",

            // existing
            ShowDialog: row.ShowDialog ?? false,
            HideDialog: row.HideDialog ?? false,
            ShowModal: row.ShowModal ?? false,
            Css: row.CSS || "",
          };

          // ✅ only add if not null/undefined
          if (row.Visible !== null && row.Visible !== undefined) {
            updatedState.isVisible = row.Visible;
            updatedState.visible = row.Visible;
          }

          generalStateUpdate[row.ElementName!] = updatedState;
        });


      useGeneralStore.getState().updateInitialState(generalStateUpdate);
      // =====================================================

      // ==============================
      // REDIRECTION LOGIC (UNCHANGED)
      // ==============================
      const redirectionInfo = data.Rows.filter((row) =>
        Boolean(row.RedirectType)
      );

      if (redirectionInfo.length) {
        const redirect = redirectionInfo[0];

        if (redirect.RedirectType === RedirectType.INTERNAL_REDIRECT) {
          const url = redirect.Value.toString().trim();
          const queryString = url.split("?")[1];
          usePageStore.getState().setFormInstanceId( null); 
          if (url.includes("Inbox")) {
            navigate("/Inbox?refresh=true");
          }
          if (!queryString) return;

          const params = Object.fromEntries(
            new URLSearchParams(queryString)
          );

          const page = pages.find(
            (p) => p.ProcessActivityMapId === params.PkActMId
          );

          if (page) navigate(`/${page.RoutPath}`);
        }

        if (redirect.RedirectType === RedirectType.EXTERNAL_REDIRECT) {
          window.open(redirect.Value as string, "_blank");
        }
      }

      // ==============================
      // UI ELEMENT UPDATE (UNCHANGED)
      // ==============================
      data.Rows
        .filter((f) => f.Child === null)
        .forEach((m) => {
          if (m.ElementName) updateUIElementState(m.ElementName, m);
        });

      // ==============================
      // GRID STATE UPDATE (UNCHANGED)
      // ==============================
      data.Rows
        .filter((f) => f.Child && f.Child.length)
        .forEach((m) => {
          if (!m.ElementName) return;

          const elementMapper =
            useGridStore.getState().gridElementMapper[m.ElementName];

          m.Child?.forEach((row) => {
            row.Child?.forEach((rowData) => {
              useGeneralStore.getState().updateInitialState({
                [`${elementMapper.elementName}+${row.RwId}+${rowData.ElementName}`]:
                {
                  value:
                    typeof rowData.Value !== "object"
                      ? rowData.Value ?? ""
                      : "",
                },
              });
            });
          });

          setGridDynamicState(elementMapper.uiElementId, m.Child!);
          setPagination(elementMapper.uiElementId, {
            currentPage: 1,
            pageSize: m.Child?.length || 5,
            totalItems: m.Child?.length || 0,
            fromRowIndex: m.RecordsFrom || 0,
            toRowIndex: m.RecordsTo || 0,
          });
        });
    } catch (error) {
      console.log(error);

      // alert("something went wrong");
      toast.error("something went wrong");
    } finally {
      setLoading(false);
      hideLoader();
    }
  };

  //  const visible = element.ElementControlProperty?.find(p => "Visible" in p)?.Visible ?? "true";
  const storeVisible = useGeneralStore(
    (store) => store.state[element.ElementName]?.isVisible
  );

  const isVisible =
    storeVisible !== undefined && storeVisible !== null
      ? storeVisible
      : true;

  if (isVisible == false || isVisible == "false") return null


  return (
    <div
      id={element.ElementId || element.UIElementid}
      onClick={(e) => {
        e.stopPropagation();
        if (!loading) handleOnClick();
      }}
      className={`${element.ColumnCss} col-md-${element.Wrap}`}
    >
      <div className="form-group">
        <div className="controls">
          <span title={element.ElementName}>
            <a
              id={`btn_${element.ElementId}`}
              className={Css || element.Css}
              title={element.DCaption}
            >
              {state || element.DCaption}
            </a>
          </span>
        </div>
      </div>
    </div>
  );
};

export default ActionButton;
