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

  const showLoader = useLoaderStore((s) => s.show);
    const hideLoader = useLoaderStore((s) => s.hide);


  if (storeQueryParams?.token) {
    sessionStorage.setItem("accessToken", storeQueryParams?.token);
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



  const handleGetFormLoadData = useCallback(async () => {
    if (!data.length || !slotId) return;

    try {
      // -------------------------------
      // 1️⃣ LOAD GRID INSTANCE DATA FIRST
      // -------------------------------
      const gridData = data.filter((f) => f.ControlId === 11);

      await Promise.all(
        gridData.map(async (m) => {
          const { Rows } = await getGridInstanceData<IAppResponse>({
            slotId,
            widgetId: m.WidgetId || "",
            controlId: m.ElementName,
            packageProcessMapId: PackageProcessMapId,
            processActivityMapId: ProcessActivityMapId,
            formInstanceId: FormVersionId,
            pageDirection: 1,
            pageSize: m["RowsPerPage"] || 5,
            currentRowIndex: 0,
            searchFilter: "",
          });

          Rows?.forEach((row) => {
            if (row.ElementName === m.ElementName) {
              setPagination(m["UIElementid"], {
                currentPage: 1,
                pageSize: m["RowsPerPage"] || 5,
                totalItems: row["TotalRecords"] || 0,
                fromRowIndex: row["RecordsFrom"] || 0,
                toRowIndex: row["RecordsTo"] || 0,
              });
            }
          });

          setGridLoadingState(m["UIElementid"], false);
        })
      );




      // -------------------------------
      // 2️⃣ FORM ON LOAD API CALL
      // -------------------------------
      const formLoadDataApi = data.filter((f) => f["Action"]?.toLowerCase() === "formonload");
      if (!formLoadDataApi.length) return;


      if (formLoadDataApi[0].BindingDetail && redirectUrlParams) {
        const bindingDetails = JSON.parse(formLoadDataApi[0].BindingDetail);

        bindingDetails.forEach((binding: any) => {
          if (Array.isArray(binding.Params)) {
            binding.Params = binding.Params.map((param: any) => {
              // Check if ElementName exists in redirectUrlParams
              if (redirectUrlParams[param.ElementName]) {
                return {
                  ...param,
                  Value: redirectUrlParams[param.ElementName],  // Set Value from URL params
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
      // 3️⃣ INITIALIZE GLOBAL STATE FIELDS
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
              isVisible: (existData?.Visible ?? "true") !== "false",
              EDT: existData?.EDT ?? curr["EDT"] ?? "",
            },
          };
        }, {});

      // -------------------------------
      // 4️⃣ INITIALIZE UI CONTROLS STATE
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
              Visible: visibility === "true" || visibility === true,
              ElementName: curr.ElementName,
              ElementId: curr.ElementId,
              EDT: existData?.EDT ?? curr["EDT"] ?? "",
              ShowModal: existData?.ShowModal === true,
              ShowDialog: existData?.ShowDialog === true,
              HideDialog: existData?.HideDialog === true,
            },
          };
        }, {});

      // -------------------------------
      // 5️⃣ GRID HEADER BUILDING
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
      // 6️⃣ GRID DYNAMIC MAPPER + CHILD ROW DATA
      // -------------------------------
      const gridElementMapper: Record<string, { uiElementId: string; elementName: string }> = {};

      gridData.forEach((m) => {
        const existData = formLoadData?.find(
          (f) => f?.ElementName?.toLowerCase() === m.ElementName?.toLowerCase()
        );

        setGridInfo(m["UIElementid"], m);

        // ✅ NEW: set footer pagination from formLoadData
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

          existData.Child.forEach((row) => {
            row.Child?.forEach((rowData) => {
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
      // 7️⃣ APPLY FINAL STATES
      // -------------------------------
      setInitialState(inputs);
      setUIElementState(uiControls);
      setGridElementMapper(gridElementMapper);
      setComboReady(true);
    } catch (error) {
      console.log(error);
    }
  }, [data, slotId, setGridHeader, setInitialState, setUIElementState, setGridElementMapper, setGridLoadingState, setPagination, setGridDynamicState]);

  useEffect(() => {
    showLoader();
    handleGetFormLoadData().then(() => hideLoader());
    // handleGetFormLoadData();
  }, [handleGetFormLoadData]);

  return null;
};

export default Store;