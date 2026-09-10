// Innovace Intech Solution Pvt Ltd
"use client";

import React, { useCallback, useEffect } from "react";
import { useLocation } from "react-router-dom";

import { config } from "@/constants/config";
import type {
  IAppResponse,
  IGlobalStateValues,
  ServiceElementData,
  UIElement,
} from "@/constants/types";
import { accessMandatory } from "@/helpers/utils";
import { useGridStore } from "@/store/useGridStore";
import { useGeneralStore } from "@/store/useStore";
import { usePageStore } from "@/store/usePageStore";
import { useUserStore } from "@/store/useUserStore";
import { useRedirectStore } from "@/store/useRedirectStore";
import { getFormOnLoadData, getGridInstanceData } from "@/helpers/axiosHelper";
import { useLoaderStore } from "@/store/useLoaderStore";

interface IStoreProps {
  data: UIElement[];
  queryParams: Record<string, string>;
  ProcessName: string;
  PackageProcessMapId: string;
  FormVersionId: string;
  ProcessActivityMapId: string;
}

const Store: React.FC<IStoreProps> = ({ data, queryParams: storeQueryParams, PackageProcessMapId, FormVersionId, ProcessActivityMapId }) => {
  const setInitialState = useGeneralStore((store) => store.setInitialState);
  const setUIElementState = useGeneralStore((store) => store.setUIElementState);
  const setGridHeader = useGridStore((store) => store.setGridHeader);
  const setPagination = useGridStore((store) => store.setPagination);
  const setGridInfo = useGridStore((store) => store.setGridInfo);
  const setGridLoadingState = useGridStore((store) => store.setGridLoadingState);
  const setGridDynamicState = useGridStore((store) => store.setGridDynamicState);
  const setGridElementMapper = useGridStore((store) => store.setGridElementMapper);
  const setComboReady = useGeneralStore(
    (store) => store.setComboReady
  );
  const formInstanceId = usePageStore((store) => store.formInstanceId);
  const showLoader = useLoaderStore((s) => s.show);
  const hideLoader = useLoaderStore((s) => s.hide);
  const setSlotId = useUserStore((store) => store.setSlotId);

  if (storeQueryParams?.token) {
    sessionStorage.setItem("accessToken", storeQueryParams?.token);
    setSlotId(storeQueryParams?.token);
  }

  if(storeQueryParams?.instanceId) {
     usePageStore.getState().setFormInstanceId(storeQueryParams?.instanceId || null);
  }

  const slotId = useUserStore((store) => store.slotId) || sessionStorage.getItem("accessToken");

  const location = useLocation();


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
 const finalUrlParams = {
  ...storeQueryParams,
  ...redirectUrlParams,
}



  const handleGetFormLoadData = useCallback(async () => {
    if (!data.length || !slotId) return;

    try {
      // -------------------------------
      // 1?? LOAD GRID INSTANCE DATA FIRST
      // -------------------------------
      const gridData = data.filter((f) => f.ControlId === 11);

     // store grid api response
const gridInstanceMap: Record<string, any> = {};

await Promise.all(
  gridData.map(async (m) => {
    const response = await getGridInstanceData<IAppResponse>({
      slotId,
      widgetId: m.WidgetId || "",
      controlId: m.ElementName,
      packageProcessMapId: PackageProcessMapId,
      processActivityMapId: ProcessActivityMapId,
      formInstanceId: formInstanceId || null || "",
      pageDirection: 1,
      pageSize: m["RowsPerPage"] || 5,
      currentRowIndex: 0,
      searchFilter: "",
    });

    const rows = response?.Rows || [];

    const matchedRow = rows.find(
      (r) =>
        r.ElementName?.toLowerCase() ===
        m.ElementName?.toLowerCase()
    );

    // save grid data
    if (matchedRow?.Child?.length) {
      gridInstanceMap[m.ElementName] = matchedRow;
    }

    // pagination
    if (matchedRow) {
      setPagination(m["UIElementid"], {
        currentPage: 1,
        pageSize: m["RowsPerPage"] || 5,
        totalItems: matchedRow["TotalRecords"] || 0,
        fromRowIndex: matchedRow["RecordsFrom"] || 0,
        toRowIndex: matchedRow["RecordsTo"] || 0,
      });
    }

    setGridLoadingState(m["UIElementid"], false);
  })
);




      // -------------------------------
      // 2?? FORM ON LOAD API CALL
      // -------------------------------
      const formLoadDataApi = data.filter((f) => f["Action"]?.toLowerCase() === "formonload");
      if (!formLoadDataApi.length) return;


      if (formLoadDataApi[0].BindingDetail && finalUrlParams) {
        const bindingDetails = JSON.parse(formLoadDataApi[0].BindingDetail);

        bindingDetails.forEach((binding: any) => {
          if (Array.isArray(binding.Params)) {
            binding.Params = binding.Params.map((param: any) => {
              // Check if ElementName exists in redirectUrlParams
              if (finalUrlParams[param.ElementName]) {
                return {
                  ...param,
                  Value: finalUrlParams[param.ElementName],  // Set Value from URL params
                };
              }
              return param;  // Keep existing Value if no match
            });
          }
        });

        // Overwrite BindingDetail with updated values
        formLoadDataApi[0].BindingDetail = JSON.stringify(bindingDetails);
      }

      const { Rows: formLoadData } = await getFormOnLoadData<IAppResponse>(
        slotId,
        formLoadDataApi[0],
        PackageProcessMapId,
        ProcessActivityMapId,
        FormVersionId
      );

      // -------------------------------
      // 3?? INITIALIZE GLOBAL STATE FIELDS
      // -------------------------------
      const inputs: Record<string, IGlobalStateValues> = data
        .filter((f) => config.DataControlIds.includes(f.ControlId))
        .reduce((acc, curr) => {
          const existData = formLoadData?.find(
            (f) => f.ElementName?.toLowerCase() === curr["ElementName"]?.toLowerCase()
          );

          return {
            ...acc,
            [curr.ElementName]: {
              value: existData ? existData.Value : String(curr["CurrValue"] || ""),
              type: curr.ControlType,
              required: curr?.ElementControlProperty?.some((s) => accessMandatory(s)),
              // isVisible: (existData?.Visible ?? "true") !== "false",
              isVisible:
                existData?.Visible == null
                  ? true
                  : existData.Visible !== "false",
              EDT: existData?.EDT ?? curr["EDT"] ?? "",
	      Enbl:
                      existData?.Enbl == null
                        ? true
                        : existData.Enbl !== "false",

            },
          };
        }, {});

      // -------------------------------
      // 4?? INITIALIZE UI CONTROLS STATE
      // -------------------------------
      const uiControls: Record<string, ServiceElementData> = data
        .filter((f) => !config.DataControlIds.includes(f.ControlId))
        .reduce((acc, curr) => {
          const existData = formLoadData?.find(
            (f) => f.ElementName?.toLowerCase() === curr["ElementName"]?.toLowerCase()
          );
          const visibility = existData?.Visible ?? curr["Visible"] ?? "true";

          return {
            ...acc,
            [curr.ElementName]: {
              // Visible: visibility === "true" || visibility === true,
              Visible:
                visibility == null
                  ? true
                  : visibility === "true" ||
                  visibility === true,
              ElementName: curr.ElementName,
              ElementId: curr.ElementId,
              EDT: existData?.EDT ?? curr["EDT"] ?? "",
              ShowModal: existData?.ShowModal === true,
              ShowDialog: existData?.ShowDialog === true,
              HideDialog: existData?.HideDialog === true,
                    Enbl:
                      existData?.Enbl == null
                        ? true
                        : existData.Enbl !== "false",
            },
          };
        }, {});

      // -------------------------------
      // 5?? GRID HEADER BUILDING
      // -------------------------------
      const gridColumns = data.filter((f) => f.ElementName === "UI_GridColumns");

      const gridColumnsValue: Record<string, UIElement[]> = {};

      gridColumns.forEach((f) => {
        const matchedGridUIColumns = data.filter((d) => d.UIElementid === f.UIElementid);

        gridColumnsValue[f.ParentElementId || ""] = matchedGridUIColumns.filter(
          (f) => f["ElementName"] !== "UI_GridColumns"
        );
      });

      setGridHeader(gridColumnsValue);

      // -------------------------------
      // 6?? GRID DYNAMIC MAPPER + CHILD ROW DATA
      // -------------------------------
      const gridElementMapper: Record<string, { uiElementId: string; elementName: string }> = {};

      gridData.forEach((m) => {
        // const existData = formLoadData?.find(
        //   (f) => f?.ElementName?.toLowerCase() === m.ElementName?.toLowerCase()
        // );

//         const gridInstanceData = gridInstanceMap[m.ElementName];

// const existData =
//   gridInstanceData ||
//   formLoadData?.find(
//     (f) =>
//       f?.ElementName?.toLowerCase() ===
//       m.ElementName?.toLowerCase()
//   );


 const gridInstanceData = gridInstanceMap[m.ElementName];

const formLoadGridData = formLoadData?.find(
  (f) =>
    f?.ElementName?.toLowerCase() ===
    m.ElementName?.toLowerCase()
);

// Prefer FormLoadData only when it actually contains child rows.
// Otherwise fall back to GridInstanceData.
const existData =
  formLoadGridData?.Child?.length
    ? formLoadGridData
    : gridInstanceData;


        setGridInfo(m["UIElementid"], m);

        // ? NEW: set footer pagination from formLoadData
        if (existData) {
          setPagination(m["UIElementid"], {
            currentPage: 1,
            pageSize: m["RowsPerPage"] || 5,
            totalItems: existData.TotalRecords || 0,
            fromRowIndex: 1,
            toRowIndex: Math.min(
              m["RowsPerPage"] || 5,
              existData.TotalRecords || 0
            ),
          });
        }

        // existing logic stays untouched
        if (existData?.Child) {
          setGridDynamicState(m["UIElementid"], existData.Child);

          existData.Child.forEach((row: any) => {
            row.Child?.forEach((rowData: any) => {
              const elementData = data.find(
                (d) => d.ElementName === rowData.ElementName
              );

              inputs[`${m.ElementName}+${row.RwId}+${rowData.ElementName}`] = {
                value:
                  typeof rowData.Value !== "object"
                    ? rowData.Value ?? ""
                    : "",
                EDT: rowData.EDT || elementData?.EDT,
              };
            });
          });
        }

        gridElementMapper[m.ElementName] = {
          elementName: m.ElementName,
          uiElementId: m.UIElementid,
        };
      });


      // -------------------------------
      // 7?? APPLY FINAL STATES
      // -------------------------------
      setInitialState(inputs);
      setUIElementState(uiControls);
      setGridElementMapper(gridElementMapper);
      setComboReady(true);
    } catch (error) {
      console.log(error);
    }
  }, [data, slotId, setGridHeader, setInitialState, setUIElementState, setGridElementMapper, setGridLoadingState, setPagination, setGridDynamicState]);

  // useEffect(() => {
  //   showLoader();
  //   setComboReady(false);
  //   handleGetFormLoadData().then(() => hideLoader());
  //   // handleGetFormLoadData();
  // }, [handleGetFormLoadData]);

  const hasLoaded = React.useRef(false);

useEffect(() => {
  if (hasLoaded.current) return;
  hasLoaded.current = true;

  showLoader();
  setComboReady(false);
  handleGetFormLoadData().then(() => hideLoader());
}, [handleGetFormLoadData]);

  return null;
};

export default Store;