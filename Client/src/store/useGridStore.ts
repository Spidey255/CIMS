// Innovace Intech Solution Pvt Ltd
// import { create } from "zustand";
// import { devtools } from "zustand/middleware";
// import type {
//   IAppResponse,
//   IGlobalStateValues,
//   ServiceElementData,
//   UIElement,
// } from "./../constants/types";
// import { getGridInstanceData } from "@/helpers/axiosHelper";
// import { useUserStore } from "./useUserStore";
// import { useGeneralStore } from "./useStore";
// import { usePageStore } from "./usePageStore";
// import { deleteGridInstanceData } from "@/helpers/gridHelpers";

// type RecordState<T> = Record<string, T>;

// type Pagination = {
//   currentPage: number;
//   pageSize: number;
//   totalItems: number;
//   fromRowIndex?: number;
//   toRowIndex?: number;
// };

// type State = {
//   gridHeader: Record<string, UIElement[]>;
//   gridDynamicState: Record<string, ServiceElementData[]>;
//   gridSearchText: RecordState<string>;
//   gridLoadingState: RecordState<boolean>;
//   pagination: Record<string, Pagination>;
//   selectedRow: RecordState<string[]>;
//   gridElementMapper: RecordState<{ uiElementId: string; elementName: string }>;
//   gridInfo: RecordState<UIElement>;
// };

// type Action = {
//   setGridHeader: (gridHeader: Record<string, UIElement[]>) => void;
//   setGridDynamicState: (key: string, value: ServiceElementData[]) => void;
//   updateGridState: (key: string, value: ServiceElementData[]) => void;
//   deleteGridRow: (key: string) => void;
//   setGridSearchText: (key: string, value: string) => Promise<void>;
//   clearGridSearchText: (key: string) => Promise<void>;
//   setGridLoadingState: (key: string, value: boolean) => void;

//   setPagination: (key: string, value: Pagination) => void;
//   setCurrentPage: (key: string, page: number) => void;
//   nextPage: (key: string) => void;
//   prevPage: (key: string) => void;
//   setPageSize: (key: string, count: number) => void;
//   setTotalItems: (key: string, totalItems: number) => void;

//   firstPage: (key: string) => void;
//   lastPage: (key: string) => void;

//   setSelectedRow: (key: string, rowId: string) => void;

//   setGridElementMapper: (
//     value: RecordState<{ uiElementId: string; elementName: string }>
//   ) => void;

//   resetAllGridState: () => void;
//   setGridInfo: (key: string, value: UIElement) => void;
//   downloadGridDataAsExcel: (key: string) => Promise<void>;
//   downloadGridDataAsPDF: (key: string) => Promise<void>;
// };

// type ThrottledFunction<T extends (...args: any[]) => void> = ((
//   ...args: Parameters<T>
// ) => void) & { cancel: () => void };

// const createThrottle = <T extends (...args: any[]) => void>(
//   fn: T,
//   wait: number
// ): ThrottledFunction<T> => {
//   let timeoutId: ReturnType<typeof setTimeout> | null = null;
//   let lastCallTime = 0;
//   let lastArgs: Parameters<T> | null = null;

//   const invoke = () => {
//     if (lastArgs) {
//       fn(...lastArgs);
//       lastCallTime = Date.now();
//       lastArgs = null;
//       timeoutId = null;
//     }
//   };

//   const throttled = (...args: Parameters<T>) => {
//     lastArgs = args;
//     const now = Date.now();
//     if (!lastCallTime || now - lastCallTime >= wait) {
//       invoke();
//     } else if (!timeoutId) {
//       const remaining = wait - (now - lastCallTime);
//       timeoutId = setTimeout(invoke, remaining);
//     }
//   };

//   throttled.cancel = () => {
//     if (timeoutId) {
//       clearTimeout(timeoutId);
//       timeoutId = null;
//     }
//     lastArgs = null;
//   };

//   return throttled;
// };

// const searchThrottleMap: Record<string, ThrottledFunction<() => void>> = {};

// const getThrottledSearchHandler = (
//   key: string,
//   set: (fn: (state: State) => Partial<State>) => void
// ) => {
//   if (!searchThrottleMap[key]) {
//     searchThrottleMap[key] = createThrottle(() => {
//       handlePaginationRequest(key, 1, 0, set);
//     }, 1000);
//   }
//   return searchThrottleMap[key];
// };

// // Common pagination logic
// const handlePaginationRequest = async (
//   key: string,
//   pageDirection: number,
//   currentRowIndex: number,
//   set: (fn: (state: State) => Partial<State>) => void
// ) => {
//   try {
//     set((state) => ({
//       gridLoadingState: {
//         ...state.gridLoadingState,
//         [key]: true,
//       },
//     }));

//     const slotId = useUserStore.getState().slotId || sessionStorage.getItem("accessToken");
//     const currentState = useGridStore.getState();
//     const activePage = usePageStore.getState().activePage;
//     const gridInfo = currentState.gridInfo[key];
//     const formInstanceId = usePageStore((store) => store.formInstanceId);

//     const response = await getGridInstanceData<IAppResponse>({
//       slotId: slotId!,
//       widgetId: gridInfo.WidgetId || "",
//       controlId: gridInfo.ElementName,
//       packageProcessMapId: activePage?.PackageProcessMapId || "",
//       processActivityMapId: activePage?.ProcessActivityMapId || "",
//       formInstanceId: formInstanceId || null || activePage?.FormVersionId || "",
//       pageDirection: pageDirection === 2 ? 3 : pageDirection,
//       pageSize: currentState.pagination[key]?.pageSize || 5,
//       currentRowIndex: currentRowIndex,
//       searchFilter: currentState.gridSearchText[key] || "",
//     });

//     const responseData = response.Rows || [];

//     if (responseData.length > 0) {
//       responseData.forEach((item) => {
//         if (item.ElementName === gridInfo["ElementName"]) {
//           const newGridState = {
//             ...currentState.gridDynamicState,
//             [key]: item.Child!,
//           };

//           const totalItems = item["TotalRecords"] || 0;
//           const inputs: Record<string, IGlobalStateValues> = {};

//           if (item && item["Child"]) {
//             item.Child?.map((row) => {
//               row.Child?.forEach((rowData) => {
//                 inputs[
//                   `${gridInfo.ElementName}+${row.RwId}+${rowData.ElementName}`
//                 ] = {
//                   value: (typeof rowData["Value"] !== "object"
//                     ? rowData["Value"]
//                       ? rowData["Value"]
//                       : ""
//                     : "") as string,
//                   EDT: Number(rowData?.EDT),
//                 };
//               });
//             });
//           }

//           useGeneralStore.getState().updateInitialState(inputs);

//           set((state) => ({
//             pagination: {
//               ...state.pagination,
//               [key]: {
//                 ...state.pagination[key],
//                 fromRowIndex: item["RecordsFrom"],
//                 toRowIndex: item["RecordsTo"],
//                 totalItems: totalItems,
//                 currentPage: calculateCurrentPage(
//                   pageDirection,
//                   state.pagination[key],
//                   totalItems
//                 ),
//               },
//             },
//             gridDynamicState: newGridState,
//             gridLoadingState: {
//               ...state.gridLoadingState,
//               [key]: false,
//             },
//           }));
//         }
//       });
//     }
//   } catch (error) {
//     console.log(error);
//   } finally {
//     set((state) => ({
//       gridLoadingState: {
//         ...state.gridLoadingState,
//         [key]: false,
//       },
//     }))
//   }
// };

// const calculateCurrentPage = (
//   pageDirection: number,
//   currentPagination: Pagination | undefined,
//   totalItems: number
// ): number => {
//   const pageSize = currentPagination?.pageSize || 5;

//   switch (pageDirection) {
//     case 1: // First page
//       return 1;
//     case 3: // Next page
//       return Math.min(
//         (currentPagination?.currentPage || 1) + 1,
//         Math.ceil(totalItems / pageSize) || 1
//       );
//     case 2: // Previous page
//       return Math.max(1, (currentPagination?.currentPage || 1) - 1);
//     case 4: // Last page
//       return Math.ceil(totalItems / pageSize) || 1;
//     default:
//       return currentPagination?.currentPage || 1;
//   }
// };

// export const useGridStore = create<State & Action>()(
//   devtools(
//     (set) => ({
//       gridHeader: {},
//       setGridHeader: (gridHeader) => set(() => ({ gridHeader })),

//       gridDynamicState: {},
//       setGridDynamicState: (key, value) =>
//         set((state) => ({
//           gridDynamicState: { ...state.gridDynamicState, [key]: value },
//         })),

//       gridInfo: {},
//       setGridInfo: (key, value) =>
//         set((state) => ({
//           gridInfo: {
//             ...state.gridInfo,
//             [key]: value,
//           },
//         })),

//       updateGridState: (key, value) =>
//         set((state) => {
//           const newGridState = {
//             ...state.gridDynamicState,
//             [key]: state.gridDynamicState[key]
//               ? [...state.gridDynamicState[key], ...value] // Append to existing array
//               : value, // Set value if key doesn't exist
//           };
//           const totalItems = newGridState[key]?.length || 0; // Calculate total items for the updated grid
//           const currentPage = Math.ceil(
//             totalItems / state.pagination[key]?.pageSize
//           );
//           return {
//             gridDynamicState: newGridState,
//             pagination: {
//               ...state.pagination,
//               [key]: {
//                 ...state.pagination[key],
//                 totalItems,
//                 currentPage,
//               },
//             },
//           };
//         }),

//       deleteGridRow: async (key) => {
//         const currentState = useGridStore.getState().selectedRow[key];
//         const gridData = useGridStore.getState().gridDynamicState[key];
//         const gridInfo = useGridStore.getState().gridInfo[key];
//         console.log("gridInfo", gridInfo);

//         if (currentState && currentState.length > 0) {
//           const selectedApiRows = currentState.filter(rowId => {
//             const row = gridData.find((row) => row.RwId === rowId && (row.Temp === undefined || row.Temp === false));
//             if (row) return true;
//             return false;
//           })

//           if (selectedApiRows.length > 0) {
//             await deleteGridInstanceData({
//               widgetId: gridInfo.WidgetId || "",
//               controlId: gridInfo.ElementName,
//               selectedRowIds: selectedApiRows,
//             });
//           }

//           currentState.forEach((rowId) => {
//             set((state) => ({
//               gridDynamicState: { ...state.gridDynamicState, [key]: state.gridDynamicState[key].filter((row) => row.RwId !== rowId) },
//             }));
//           });
//         }
//       },

//       gridLoadingState: {},
//       setGridLoadingState: (key, value) =>
//         set((state) => ({
//           gridLoadingState: { ...state.gridLoadingState, [key]: value },
//         })),

//       gridSearchText: {},
//       setGridSearchText: async (key, value) => {
//         const currentState = useGridStore.getState();
//         const previousSearchText = currentState.gridSearchText[key];

//         set((state) => ({
//           gridSearchText: { ...state.gridSearchText, [key]: value },
//         }));

//         // If this is the first time setting search text or search text changed, reset to page 1
//         const isFirstSearch = !previousSearchText && value;
//         const isSearchChanged = previousSearchText !== value;

//         if (isFirstSearch || isSearchChanged) {
//           // Reset to first page for new/changed search
//           set((state) => ({
//             pagination: {
//               ...state.pagination,
//               [key]: {
//                 ...state.pagination[key],
//                 currentPage: 1,
//               },
//             },
//           }));

//           const triggerSearch = getThrottledSearchHandler(key, set);
//           triggerSearch();
//         }
//       },
//       clearGridSearchText: async (key) => {
//         // Clear search text
//         set((state) => ({
//           gridSearchText: { ...state.gridSearchText, [key]: "" },
//         }));

//         if (searchThrottleMap[key]) {
//           searchThrottleMap[key].cancel();
//         }

//         // Reset to first page and reload data without search filter
//         set((state) => ({
//           pagination: {
//             ...state.pagination,
//             [key]: {
//               ...state.pagination[key],
//               currentPage: 1,
//             },
//           },
//         }));

//         // Trigger pagination request without search filter
//         handlePaginationRequest(key, 1, 0, set);
//       },
//       pagination: {}, // Initialize empty pagination object
//       setPagination: (key, value) =>
//         set((state) => ({
//           pagination: {
//             ...state.pagination,
//             [key]: { ...state.pagination[key], ...value },
//           },
//         })),
//       setCurrentPage: (key, page) =>
//         set((state) => ({
//           pagination: {
//             ...state.pagination,
//             [key]: {
//               ...state.pagination[key],
//               currentPage: page,
//             },
//           },
//         })),
//       nextPage: async (key) => {
//         const currentState = useGridStore.getState();
//         const currentRowIndex =
//           (currentState.pagination[key]?.toRowIndex || 0) /
//           currentState.pagination[key]?.pageSize;

//         const hasNextPage =
//           currentState.pagination[key]?.currentPage <
//           Math.ceil(
//             currentState.pagination[key]?.totalItems /
//             currentState.pagination[key]?.pageSize
//           );

//         if (hasNextPage) {
//           handlePaginationRequest(key, 3, currentRowIndex, set);
//         }
//       },

//       prevPage: async (key) => {
//         const currentState = useGridStore.getState();
//         const currentRowIndex = currentState.pagination[key]?.currentPage - 2;

//         const hasPrevPage = currentState.pagination[key]?.currentPage > 1;

//         if (hasPrevPage) {
//           handlePaginationRequest(key, 2, currentRowIndex, set);
//         }
//       },

//       setPageSize: (key, count) => {
//         set((state) => ({
//           pagination: {
//             ...state.pagination,
//             [key]: {
//               ...state.pagination[key],
//               pageSize: count,
//               currentPage: 1,
//             },
//           },
//         }));
//         handlePaginationRequest(key, 1, 0, set);
//       },
//       setTotalItems: (key, totalItems) =>
//         set((state) => ({
//           pagination: {
//             ...state.pagination,
//             [key]: {
//               ...state.pagination[key],
//               totalItems,
//             },
//           },
//         })),
//       firstPage: async (key) => {
//         const currentState = useGridStore.getState();
//         const hasFirstPage = currentState.pagination[key]?.currentPage > 1;

//         if (hasFirstPage) {
//           handlePaginationRequest(key, 1, 0, set);
//         }
//       },

//       lastPage: async (key) => {
//         const currentState = useGridStore.getState();
//         const hasLastPage =
//           currentState.pagination[key]?.currentPage <
//           Math.ceil(
//             currentState.pagination[key]?.totalItems /
//             currentState.pagination[key]?.pageSize
//           );

//         if (hasLastPage) {
//           handlePaginationRequest(key, 4, 0, set);
//         }
//       },

//       selectedRow: {},
//       // setSelectedRow: (key: string, rowId: string) =>
//       //   set((state) => ({
//       //     selectedRow: {
//       //       [key]: state.selectedRow[key]
//       //         ? state.selectedRow[key].includes(rowId)
//       //           ? state.selectedRow[key].filter((id) => id !== rowId)
//       //           : [...state.selectedRow[key], rowId]
//       //         : [rowId],
//       //     },
//       //   })),
//       setSelectedRow: (key: string, rowId: string) =>
//         set((state) => ({
//           selectedRow: {
//             ...state.selectedRow, // Preserve other selected rows
//             [key]: state.selectedRow[key]
//               ? state.selectedRow[key].includes(rowId)
//                 ? state.selectedRow[key].filter((id) => id !== rowId) // Remove if already selected
//                 : [...state.selectedRow[key], rowId] // Add rowId to the list
//               : [rowId], // Initialize with an array containing rowId if it doesn't exist
//           },
//         })),

//       gridElementMapper: {},
//       setGridElementMapper: (value) =>
//         set(() => ({
//           gridElementMapper: value,
//         })),

//       resetAllGridState: () =>
//         set(() => {
//           Object.keys(searchThrottleMap).forEach((throttleKey) => {
//             searchThrottleMap[throttleKey].cancel();
//             delete searchThrottleMap[throttleKey];
//           });
//           return {
//             gridHeader: {},
//             gridDynamicState: {},
//             gridLoadingState: {},
//             gridSearchText: {},
//             pagination: {},
//             selectedRow: {},
//             gridElementMapper: {},
//           };
//         }),

//       downloadGridDataAsExcel: async (key) => {
//         const currentState = useGridStore.getState();
//         const gridData = currentState.gridDynamicState[key];
//         const gridInfo = currentState.gridInfo[key];
//         const parentId = gridInfo?.UIElementid || "";
//         const gridHeaders = currentState.gridHeader[parentId];

//         if (gridData && gridData.length > 0 && gridInfo) {
//           import("@/utils/downloadUtils").then(({ downloadAsExcel }) => {
//             downloadAsExcel(gridData, gridInfo, gridHeaders);
//           });
//         }
//       },

//       downloadGridDataAsPDF: async (key) => {
//         const currentState = useGridStore.getState();
//         const gridData = currentState.gridDynamicState[key];
//         const gridInfo = currentState.gridInfo[key];
//         const parentId = gridInfo?.UIElementid || "";
//         const gridHeaders = currentState.gridHeader[parentId];

//         if (gridData && gridData.length > 0 && gridInfo) {
//           import("@/utils/downloadUtils").then(({ downloadAsPDF }) => {
//             downloadAsPDF(gridData, gridInfo, gridHeaders);
//           });
//         }
//       },
//     }),
//     { name: "GridStore" }
//   )
// );




import { create } from "zustand";
import { devtools } from "zustand/middleware";
import type {
  IAppResponse,
  IGlobalStateValues,
  ServiceElementData,
  UIElement,
} from "./../constants/types";
import { getGridInstanceData } from "@/helpers/axiosHelper";
import { useUserStore } from "./useUserStore";
import { useGeneralStore } from "./useStore";
import { usePageStore } from "./usePageStore";
import { deleteGridInstanceData } from "@/helpers/gridHelpers";

type RecordState<T> = Record<string, T>;

type Pagination = {
  currentPage: number;
  pageSize: number;
  totalItems: number;
  fromRowIndex?: number;
  toRowIndex?: number;
};

type State = {
  gridHeader: Record<string, UIElement[]>;
  gridDynamicState: Record<string, ServiceElementData[]>;
  gridSearchText: RecordState<string>;
  gridLoadingState: RecordState<boolean>;
  pagination: Record<string, Pagination>;
  selectedRow: RecordState<string[]>;
  gridElementMapper: RecordState<{ uiElementId: string; elementName: string }>;
  gridInfo: RecordState<UIElement>;
};

type Action = {
  setGridHeader: (gridHeader: Record<string, UIElement[]>) => void;
  setGridDynamicState: (key: string, value: ServiceElementData[]) => void;
  updateGridState: (key: string, value: ServiceElementData[]) => void;
  deleteGridRow: (key: string) => void;
  setGridSearchText: (key: string, value: string) => Promise<void>;
  clearGridSearchText: (key: string) => Promise<void>;
  setGridLoadingState: (key: string, value: boolean) => void;

  setPagination: (key: string, value: Pagination) => void;
  setCurrentPage: (key: string, page: number) => void;
  nextPage: (key: string) => void;
  prevPage: (key: string) => void;
  setPageSize: (key: string, count: number) => void;
  setTotalItems: (key: string, totalItems: number) => void;

  firstPage: (key: string) => void;
  lastPage: (key: string) => void;

  setSelectedRow: (key: string, rowId: string) => void;

  setGridElementMapper: (
    value: RecordState<{ uiElementId: string; elementName: string }>
  ) => void;

  resetAllGridState: () => void;
  setGridInfo: (key: string, value: UIElement) => void;
  downloadGridDataAsExcel: (key: string) => Promise<void>;
  downloadGridDataAsPDF: (key: string) => Promise<void>;
};

type ThrottledFunction<T extends (...args: any[]) => void> = ((
  ...args: Parameters<T>
) => void) & { cancel: () => void };

const createThrottle = <T extends (...args: any[]) => void>(
  fn: T,
  wait: number
): ThrottledFunction<T> => {
  let timeoutId: ReturnType<typeof setTimeout> | null = null;
  let lastCallTime = 0;
  let lastArgs: Parameters<T> | null = null;

  const invoke = () => {
    if (lastArgs) {
      fn(...lastArgs);
      lastCallTime = Date.now();
      lastArgs = null;
      timeoutId = null;
    }
  };

  const throttled = (...args: Parameters<T>) => {
    lastArgs = args;
    const now = Date.now();
    if (!lastCallTime || now - lastCallTime >= wait) {
      invoke();
    } else if (!timeoutId) {
      const remaining = wait - (now - lastCallTime);
      timeoutId = setTimeout(invoke, remaining);
    }
  };

  throttled.cancel = () => {
    if (timeoutId) {
      clearTimeout(timeoutId);
      timeoutId = null;
    }
    lastArgs = null;
  };

  return throttled;
};

const searchThrottleMap: Record<string, ThrottledFunction<() => void>> = {};

const getThrottledSearchHandler = (
  key: string,
  set: (fn: (state: State) => Partial<State>) => void
) => {
  if (!searchThrottleMap[key]) {
    searchThrottleMap[key] = createThrottle(() => {
      handlePaginationRequest(key, 1, 0, set);
    }, 1000);
  }
  return searchThrottleMap[key];
};

// Common pagination logic
const handlePaginationRequest = async (
  key: string,
  pageDirection: number,
  currentRowIndex: number,
  set: (fn: (state: State) => Partial<State>) => void
) => {
  try {
    set((state) => ({
      gridLoadingState: {
        ...state.gridLoadingState,
        [key]: true,
      },
    }));

    const slotId = useUserStore.getState().slotId || sessionStorage.getItem("accessToken");
    const currentState = useGridStore.getState();
    const activePage = usePageStore.getState().activePage;
    const gridInfo = currentState.gridInfo[key];
    const formInstanceId = usePageStore((store) => store.formInstanceId);

    const response = await getGridInstanceData<IAppResponse>({
      slotId: slotId!,
      widgetId: gridInfo.WidgetId || "",
      controlId: gridInfo.ElementName,
      packageProcessMapId: activePage?.PackageProcessMapId || "",
      processActivityMapId: activePage?.ProcessActivityMapId || "",
      formInstanceId: formInstanceId || null || activePage?.FormVersionId || "",
      pageDirection: pageDirection === 2 ? 3 : pageDirection,
      pageSize: currentState.pagination[key]?.pageSize || 5,
      currentRowIndex: currentRowIndex,
      searchFilter: currentState.gridSearchText[key] || "",
    });

    const responseData = response.Rows || [];

    if (responseData.length > 0) {
      responseData.forEach((item) => {
        if (item.ElementName === gridInfo["ElementName"]) {
          const newGridState = {
            ...currentState.gridDynamicState,
            [key]: item.Child!,
          };

          const totalItems = item["TotalRecords"] || 0;
          const inputs: Record<string, IGlobalStateValues> = {};

          if (item && item["Child"]) {
            item.Child?.map((row) => {
              row.Child?.forEach((rowData) => {
                inputs[
                  `${gridInfo.ElementName}+${row.RwId}+${rowData.ElementName}`
                ] = {
                  value: (typeof rowData["Value"] !== "object"
                    ? rowData["Value"]
                      ? rowData["Value"]
                      : ""
                    : "") as string,
                  EDT: Number(rowData?.EDT),
                };
              });
            });
          }

          useGeneralStore.getState().updateInitialState(inputs);

          set((state) => ({
            pagination: {
              ...state.pagination,
              [key]: {
                ...state.pagination[key],
                fromRowIndex: item["RecordsFrom"],
                toRowIndex: item["RecordsTo"],
                totalItems: totalItems,
                currentPage: calculateCurrentPage(
                  pageDirection,
                  state.pagination[key],
                  totalItems
                ),
              },
            },
            gridDynamicState: newGridState,
            gridLoadingState: {
              ...state.gridLoadingState,
              [key]: false,
            },
          }));
        }
      });
    }
  } catch (error) {
    console.log(error);
  } finally {
    set((state) => ({
      gridLoadingState: {
        ...state.gridLoadingState,
        [key]: false,
      },
    }))
  }
};

const calculateCurrentPage = (
  pageDirection: number,
  currentPagination: Pagination | undefined,
  totalItems: number
): number => {
  const pageSize = currentPagination?.pageSize || 5;

  switch (pageDirection) {
    case 1: // First page
      return 1;
    case 3: // Next page
      return Math.min(
        (currentPagination?.currentPage || 1) + 1,
        Math.ceil(totalItems / pageSize) || 1
      );
    case 2: // Previous page
      return Math.max(1, (currentPagination?.currentPage || 1) - 1);
    case 4: // Last page
      return Math.ceil(totalItems / pageSize) || 1;
    default:
      return currentPagination?.currentPage || 1;
  }
};

export const useGridStore = create<State & Action>()(
  devtools(
    (set) => ({
      gridHeader: {},
      setGridHeader: (gridHeader) => set(() => ({ gridHeader })),

      gridDynamicState: {},
      setGridDynamicState: (key, value) =>
        set((state) => ({
          gridDynamicState: { ...state.gridDynamicState, [key]: value },
        })),

      gridInfo: {},
      setGridInfo: (key, value) =>
        set((state) => ({
          gridInfo: {
            ...state.gridInfo,
            [key]: value,
          },
        })),

      updateGridState: (key, value) =>
        set((state) => {
          const newGridState = {
            ...state.gridDynamicState,
            [key]: state.gridDynamicState[key]
              ? [...state.gridDynamicState[key], ...value] // Append to existing array
              : value, // Set value if key doesn't exist
          };
          const totalItems = newGridState[key]?.length || 0; // Calculate total items for the updated grid
          const currentPage = Math.ceil(
            totalItems / state.pagination[key]?.pageSize
          );
          return {
            gridDynamicState: newGridState,
            pagination: {
              ...state.pagination,
              [key]: {
                ...state.pagination[key],
                totalItems,
                currentPage,
              },
            },
          };
        }),

      deleteGridRow: async (key) => {
        const currentState = useGridStore.getState().selectedRow[key];
        const gridData = useGridStore.getState().gridDynamicState[key];
        const gridInfo = useGridStore.getState().gridInfo[key];
        console.log("gridInfo", gridInfo);

        if (currentState && currentState.length > 0) {
          const selectedApiRows = currentState.filter(rowId => {
            const row = gridData.find((row) => row.RwId === rowId && (row.Temp === undefined || row.Temp === false));
            if (row) return true;
            return false;
          })

          if (selectedApiRows.length > 0) {
            await deleteGridInstanceData({
              widgetId: gridInfo.WidgetId || "",
              controlId: gridInfo.ElementName,
              selectedRowIds: selectedApiRows,
            });
          }

          currentState.forEach((rowId) => {
            set((state) => ({
              gridDynamicState: { ...state.gridDynamicState, [key]: state.gridDynamicState[key].filter((row) => row.RwId !== rowId) },
            }));
          });
        }
      },

      gridLoadingState: {},
      setGridLoadingState: (key, value) =>
        set((state) => ({
          gridLoadingState: { ...state.gridLoadingState, [key]: value },
        })),

      gridSearchText: {},
      setGridSearchText: async (key, value) => {
        const currentState = useGridStore.getState();
        const previousSearchText = currentState.gridSearchText[key];

        set((state) => ({
          gridSearchText: { ...state.gridSearchText, [key]: value },
        }));

        // If this is the first time setting search text or search text changed, reset to page 1
        const isFirstSearch = !previousSearchText && value;
        const isSearchChanged = previousSearchText !== value;

        if (isFirstSearch || isSearchChanged) {
          // Reset to first page for new/changed search
          set((state) => ({
            pagination: {
              ...state.pagination,
              [key]: {
                ...state.pagination[key],
                currentPage: 1,
              },
            },
          }));

          const triggerSearch = getThrottledSearchHandler(key, set);
          triggerSearch();
        }
      },
      clearGridSearchText: async (key) => {
        // Clear search text
        set((state) => ({
          gridSearchText: { ...state.gridSearchText, [key]: "" },
        }));

        if (searchThrottleMap[key]) {
          searchThrottleMap[key].cancel();
        }

        // Reset to first page and reload data without search filter
        set((state) => ({
          pagination: {
            ...state.pagination,
            [key]: {
              ...state.pagination[key],
              currentPage: 1,
            },
          },
        }));

        // Trigger pagination request without search filter
        handlePaginationRequest(key, 1, 0, set);
      },
      pagination: {}, // Initialize empty pagination object
      setPagination: (key, value) =>
        set((state) => ({
          pagination: {
            ...state.pagination,
            [key]: { ...state.pagination[key], ...value },
          },
        })),
      setCurrentPage: (key, page) =>
        set((state) => ({
          pagination: {
            ...state.pagination,
            [key]: {
              ...state.pagination[key],
              currentPage: page,
            },
          },
        })),
      nextPage: async (key) => {
  const state = useGridStore.getState();
  const pagination = state.pagination[key];
  if (!pagination) return;

  const totalPages = Math.ceil(pagination.totalItems / pagination.pageSize);
  if (pagination.currentPage < totalPages) {
    const next = pagination.currentPage + 1;
    state.setCurrentPage(key, next); // Update current page
    handlePaginationRequest(key, next, 0, set); // Call with correct page
  }
},

      prevPage: async (key) => {
  const state = useGridStore.getState();
  const pagination = state.pagination[key];
  if (!pagination) return;

  if (pagination.currentPage > 1) {
    const prev = pagination.currentPage - 1;
    state.setCurrentPage(key, prev);
    handlePaginationRequest(key, prev, 0, set);
  }
},
      setPageSize: (key, count) => {
        set((state) => ({
          pagination: {
            ...state.pagination,
            [key]: {
              ...state.pagination[key],
              pageSize: count,
              currentPage: 1,
            },
          },
        }));
        handlePaginationRequest(key, 1, 0, set);
      },
      setTotalItems: (key, totalItems) =>
        set((state) => ({
          pagination: {
            ...state.pagination,
            [key]: {
              ...state.pagination[key],
              totalItems,
            },
          },
        })),
     firstPage: async (key) => {
  const state = useGridStore.getState();
  const pagination = state.pagination[key];
  if (!pagination) return;

  if (pagination.currentPage > 1) {
    state.setCurrentPage(key, 1);
    handlePaginationRequest(key, 1, 0, set);
  }
},

      lastPage: async (key) => {
  const state = useGridStore.getState();
  const pagination = state.pagination[key];
  if (!pagination) return;

  const totalPages = Math.ceil(pagination.totalItems / pagination.pageSize);
  if (pagination.currentPage < totalPages) {
    state.setCurrentPage(key, totalPages);
    handlePaginationRequest(key, totalPages, 0, set);
  }
},

      selectedRow: {},
      // setSelectedRow: (key: string, rowId: string) =>
      //   set((state) => ({
      //     selectedRow: {
      //       [key]: state.selectedRow[key]
      //         ? state.selectedRow[key].includes(rowId)
      //           ? state.selectedRow[key].filter((id) => id !== rowId)
      //           : [...state.selectedRow[key], rowId]
      //         : [rowId],
      //     },
      //   })),
      setSelectedRow: (key: string, rowId: string) =>
        set((state) => ({
          selectedRow: {
            ...state.selectedRow, // Preserve other selected rows
            [key]: state.selectedRow[key]
              ? state.selectedRow[key].includes(rowId)
                ? state.selectedRow[key].filter((id) => id !== rowId) // Remove if already selected
                : [...state.selectedRow[key], rowId] // Add rowId to the list
              : [rowId], // Initialize with an array containing rowId if it doesn't exist
          },
        })),

      gridElementMapper: {},
      setGridElementMapper: (value) =>
        set(() => ({
          gridElementMapper: value,
        })),

      resetAllGridState: () =>
        set(() => {
          Object.keys(searchThrottleMap).forEach((throttleKey) => {
            searchThrottleMap[throttleKey].cancel();
            delete searchThrottleMap[throttleKey];
          });
          return {
            gridHeader: {},
            gridDynamicState: {},
            gridLoadingState: {},
            gridSearchText: {},
            pagination: {},
            selectedRow: {},
            gridElementMapper: {},
          };
        }),

      downloadGridDataAsExcel: async (key) => {
        const currentState = useGridStore.getState();
        const gridData = currentState.gridDynamicState[key];
        const gridInfo = currentState.gridInfo[key];
        const parentId = gridInfo?.UIElementid || "";
        const gridHeaders = currentState.gridHeader[parentId];

        if (gridData && gridData.length > 0 && gridInfo) {
          import("@/utils/downloadUtils").then(({ downloadAsExcel }) => {
            downloadAsExcel(gridData, gridInfo, gridHeaders);
          });
        }
      },

      downloadGridDataAsPDF: async (key) => {
        const currentState = useGridStore.getState();
        const gridData = currentState.gridDynamicState[key];
        const gridInfo = currentState.gridInfo[key];
        const parentId = gridInfo?.UIElementid || "";
        const gridHeaders = currentState.gridHeader[parentId];

        if (gridData && gridData.length > 0 && gridInfo) {
          import("@/utils/downloadUtils").then(({ downloadAsPDF }) => {
            downloadAsPDF(gridData, gridInfo, gridHeaders);
          });
        }
      },
    }),
    { name: "GridStore" }
  )
);
