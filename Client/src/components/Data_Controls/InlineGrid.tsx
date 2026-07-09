// Innovace Intech Solution Pvt Ltd
// import React, { useMemo } from "react";
// import _ from "lodash";

// import { useGridStore } from "@/store/useGridStore";
// import { getColumnClassName } from "@/helpers/utils";
// import { useDeviceStore } from "@/store/useDeviceStore";
// import { getValidColumns } from "@/helpers/gridHelpers";
// import type { ServiceElementData, UIElement } from "@/constants/types";
// import { useGeneralStore } from "@/store/useStore";
// import { componentsMap } from "@/components/Data_Controls";

// const InlineGrid: React.FC<{ element: UIElement; components: UIElement[] }> = ({
//   element,
//   components,
// }) => {
//   const gridData = useGridStore(
//     (store) => store.gridDynamicState?.[element?.UIElementid]
//   );
//   const gridLoadingState = useGridStore(
//     (store) => store.gridLoadingState?.[element?.UIElementid]
//   );
//   const pagination = useGridStore(
//     (store) => store.pagination?.[String(element?.UIElementid)]
//   );
//   const gridSearchText = useGridStore(
//     (store) => store.gridSearchText?.[element?.UIElementid]
//   );
//   // const uiState = useGeneralStore(
//   //   (store) => store.uiElementState?.[element.ElementId]
//   // );

//   const tableHeaders = getValidColumns(components);

//   // Filter data based on search text
// const filteredData = useMemo(() => {
//   if (!gridData || !gridData.length) return [];

//   if (!gridSearchText) return gridData;

//   const values = useGeneralStore.getState().state;

//   const filteredCurrenttGridValues = Object.entries(values).filter(([key]) =>
//     key.includes(element.ElementName.toString() + "+")
//   );

//   const filteredValues = filteredCurrenttGridValues.filter((f) =>
//     f[1].value?.toString()?.toLowerCase()?.includes(gridSearchText.toLowerCase())
//   );

//   const rowIds = _.uniq(filteredValues.map((s) => s[0].split("+")[1]));

//   return gridData.filter((f) => rowIds.includes(String(f.RwId)));
// }, [gridData, element.UIElementid, gridSearchText]);


//   // // Paginate the filtered data
//   // const paginatedData = useMemo(() => {
//   //   // const startIndex = (pagination?.currentPage - 1) * pagination?.pageSize;
//   //   // const endIndex = startIndex + pagination?.pageSize;
//   //   // return filteredData?.slice(startIndex, endIndex) || [];
//   //   return filteredData ?? [];
//   // }, [filteredData, pagination]);


//   const paginatedData = useMemo(() => {
//   if (!filteredData?.length) return [];

//   const pageSize = pagination?.pageSize || 5;
//   const totalPages = Math.max(
//     1,
//     Math.ceil(filteredData.length / pageSize)
//   );

//   let currentPage = pagination?.currentPage || 1;

//   if (currentPage > totalPages) {
//     currentPage = totalPages;
//   }

//   const startIndex = (currentPage - 1) * pageSize;
//   const endIndex = startIndex + pageSize;

//   return filteredData.slice(startIndex, endIndex);
// }, [filteredData, pagination]);

  

//   // if (uiState?.["Visible"] === "false"|| !Boolean(uiState?.["Visible"])) return null;

//   const renderNoSearchFound = (
//     <tr className="odd">
//       <td
//         valign="top"
//         colSpan={tableHeaders.length}
//         className="dataTables_empty"
//       >
//         No search found
//       </td>
//     </tr>
//   );

//   const renderNoDataFound = (
//     <tr className="odd">
//       <td
//         valign="top"
//         colSpan={tableHeaders.length}
//         className="dataTables_empty"
//       >
//         No data available in table
//       </td>
//     </tr>
//   );

//   const renderLoadingState = (
//     <tr>
//       <td colSpan={tableHeaders.length}>Loading...</td>
//     </tr>
//   );

//   return (
//     <div className="table-widget">
//       <div className="table-widget-content">
//         <div id="conatiner" className="rounded">
//           <div className="dataTables_wrapper">
//             <table className="table dataTable">
//               <thead>
//                 <tr role="row">
//                   {tableHeaders?.map((head, index) => (
//                     <th
//                       key={index.toString()}
//                       className="sorting bg-light text-black"
//                       tabIndex={0}
//                       rowSpan={1}
//                       colSpan={1}
//                       style={{ cursor: "pointer" }}
//                     >
//                       {head?.DCaption}
//                     </th>
//                   ))}
//                 </tr>
//               </thead>
//               <tbody>
//                 {gridLoadingState === undefined || gridLoadingState !== false
//                   ? renderLoadingState
//                   : gridSearchText && !paginatedData.length
//                   ? renderNoSearchFound
//                   : !paginatedData?.length
//                   ? renderNoDataFound
//                   : paginatedData?.map((m, index) => (
//                       <GridRow
//                         key={m.RwId}
//                         index={index}
//                         headers={tableHeaders}
//                         data={m}
//                         gridUIElementId={element?.UIElementid}
//                         ElementName={element.ElementName}
//                       />
//                     ))}
//               </tbody>
//             </table>
//           </div>
//         </div>
//       </div>
//     </div>
//   );
// };

// const GridRow = ({
//   headers,
//   index,
//   data,
//   gridUIElementId,
//   ElementName,
// }: {
//   headers: UIElement[];
//   index: number;
//   data: ServiceElementData;
//   gridUIElementId: string;
//   ElementName: string;
// }) => {
//   const setSelectedRow = useGridStore((store) => store.setSelectedRow);
//   const gridData = useGridStore(
//     (store) => store.selectedRow?.[gridUIElementId]
//   );

//   return (
//     <tr
//   role="row"
//   className={`
//     ${index % 2 === 0 ? "even" : "odd"}
//     ${gridData?.includes(data.RwId!) ? "selected-row" : ""}
//   `}
//   onClick={(e) => {
//     // SHIFT + CLICK => multi select
//     if (e.shiftKey) {
//       setSelectedRow(gridUIElementId, data.RwId!);
//       return;
//     }

//     // NORMAL CLICK => single select
//     useGridStore.setState((state) => ({
//       selectedRow: {
//         ...state.selectedRow,
//         [gridUIElementId]: [data.RwId!],
//       },
//     }));
//   }}
// >
//       {headers?.map((head, index) => (
//         <td key={index.toString()}>
//           <RenderCell
//             element={{
//               ...head,
//               ElementName: `${ElementName}+${data.RwId}+${head.ElementName}`,
//             }}
//           />
//         </td>
//       ))}
//     </tr>
//   );
// };

// const RenderCell = ({ element }: { element: UIElement }) => {
//   const deviceViewport = useDeviceStore((store) => store.deviceViewport);

//   const Component = componentsMap[element.ControlId] || (() => <div />);

//   return (
//     <Component
//       key={element.ElementName}
//       element={{
//         ...element,
//         ColumnCss: getColumnClassName(deviceViewport, element.Wrap),
//       }}
//       isGrid
//     />
//   );
// };

// export default InlineGrid;



// Innovace Intech Solution Pvt Ltd
import React, { useMemo } from "react";
import _ from "lodash";

import { useGridStore } from "@/store/useGridStore";
import { getColumnClassName } from "@/helpers/utils";
import { useDeviceStore } from "@/store/useDeviceStore";
import { getValidColumns } from "@/helpers/gridHelpers";
import type { ServiceElementData, UIElement } from "@/constants/types";
import { useGeneralStore } from "@/store/useStore";
import { componentsMap } from "@/components/Data_Controls";

const InlineGrid: React.FC<{ element: UIElement; components: UIElement[] }> = ({
  element,
  components,
}) => {
  const gridData = useGridStore(
    (store) => store.gridDynamicState?.[element?.UIElementid]
  );
  const gridLoadingState = useGridStore(
    (store) => store.gridLoadingState?.[element?.UIElementid]
  );
  const pagination = useGridStore(
    (store) => store.pagination?.[String(element?.UIElementid)]
  );
  const gridSearchText = useGridStore(
    (store) => store.gridSearchText?.[element?.UIElementid]
  );
  // const uiState = useGeneralStore(
  //   (store) => store.uiElementState?.[element.ElementId]
  // );
  console.log("gridData", components);
  const tableHeaders = getValidColumns(components);

  // Filter data based on search text
  const filteredData = useMemo(() => {
    if (!gridData || !gridData.length) return [];

    if (!gridSearchText) return gridData;

    const values = useGeneralStore.getState().state;

    const filteredCurrenttGridValues = Object.entries(values).filter(([key]) =>
      key.includes(element.ElementName.toString() + "+")
    );

    const filteredValues = filteredCurrenttGridValues.filter((f) =>
      f[1].value?.toString()?.toLowerCase()?.includes(gridSearchText.toLowerCase())
    );

    const rowIds = _.uniq(filteredValues.map((s) => s[0].split("+")[1]));

    return gridData.filter((f) => rowIds.includes(String(f.RwId)));
  }, [gridData, element.UIElementid, gridSearchText]);


  // // Paginate the filtered data
  // const paginatedData = useMemo(() => {
  //   // const startIndex = (pagination?.currentPage - 1) * pagination?.pageSize;
  //   // const endIndex = startIndex + pagination?.pageSize;
  //   // return filteredData?.slice(startIndex, endIndex) || [];
  //   return filteredData ?? [];
  // }, [filteredData, pagination]);


  const paginatedData = useMemo(() => {
    if (!filteredData?.length) return [];

    const pageSize = pagination?.pageSize || 5;
    const totalPages = Math.max(
      1,
      Math.ceil(filteredData.length / pageSize)
    );

    let currentPage = pagination?.currentPage || 1;

    if (currentPage > totalPages) {
      currentPage = totalPages;
    }

    const startIndex = (currentPage - 1) * pageSize;
    const endIndex = startIndex + pageSize;

    return filteredData.slice(startIndex, endIndex);
  }, [filteredData, pagination]);



  // if (uiState?.["Visible"] === "false"|| !Boolean(uiState?.["Visible"])) return null;

  const renderNoSearchFound = (
    <tr className="odd">
      <td
        valign="top"
        colSpan={tableHeaders.length}
        className="dataTables_empty"
      >
        No search found
      </td>
    </tr>
  );

  const renderNoDataFound = (
    <tr className="odd">
      <td
        valign="top"
        colSpan={tableHeaders.length}
        className="dataTables_empty"
      >
        No data available in table
      </td>
    </tr>
  );

  const renderLoadingState = (
    <tr>
      <td colSpan={tableHeaders.length}>Loading...</td>
    </tr>
  );

  return (
    <div className="table-widget">
      <div className="table-widget-content">
        <div id="conatiner" className="rounded">
          <div className="dataTables_wrapper">
            <table className="table dataTable">
              <thead>
                <tr role="row">
                  {tableHeaders.map((head, index) => {
                    const isMandatory =
                      (head.ElementControlProperty?.[0] as { Mandatory?: boolean })?.Mandatory;

                    return (
                      <th
                        key={index}
                        className="sorting bg-light text-black"
                      >
                        <span className="d-inline-flex align-items-center gap-1">
                          {head.DCaption}

                          {isMandatory && (
                            <span className="text-danger fw-bold">*</span>
                          )}
                        </span>
                      </th>
                    );
                  })}
                </tr>
              </thead>
              <tbody>
                {gridLoadingState === undefined || gridLoadingState !== false
                  ? renderLoadingState
                  : gridSearchText && !paginatedData.length
                    ? renderNoSearchFound
                    : !paginatedData?.length
                      ? renderNoDataFound
                      : paginatedData?.map((m, index) => (
                        <GridRow
                          key={m.RwId}
                          index={index}
                          headers={tableHeaders}
                          data={m}
                          gridUIElementId={element?.UIElementid}
                          ElementName={element.ElementName}
                        />
                      ))}
              </tbody>
            </table>
          </div>
        </div>
      </div>
    </div>
  );
};

const GridRow = ({
  headers,
  index,
  data,
  gridUIElementId,
  ElementName,
}: {
  headers: UIElement[];
  index: number;
  data: ServiceElementData;
  gridUIElementId: string;
  ElementName: string;
}) => {
  const setSelectedRow = useGridStore((store) => store.setSelectedRow);
  const gridData = useGridStore(
    (store) => store.selectedRow?.[gridUIElementId]
  );

  return (
    <tr
      role="row"
      className={`
    ${index % 2 === 0 ? "even" : "odd"}
    ${gridData?.includes(data.RwId!) ? "selected-row" : ""}
  `}
      onClick={(e) => {
        // SHIFT + CLICK => multi select
        if (e.shiftKey) {
          setSelectedRow(gridUIElementId, data.RwId!);
          return;
        }

        // NORMAL CLICK => single select
        useGridStore.setState((state) => ({
          selectedRow: {
            ...state.selectedRow,
            [gridUIElementId]: [data.RwId!],
          },
        }));
      }}
    >
      {headers?.map((head, index) => (
        <td key={index.toString()}>
          <RenderCell
            element={{
              ...head,
              ElementName: `${ElementName}+${data.RwId}+${head.ElementName}`,
            }}
          />
        </td>
      ))}
    </tr>
  );
};

const RenderCell = ({ element }: { element: UIElement }) => {
  const deviceViewport = useDeviceStore((store) => store.deviceViewport);

  const Component = componentsMap[element.ControlId] || (() => <div />);

  return (
    <Component
      key={element.ElementName}
      element={{
        ...element,
        ColumnCss: getColumnClassName(deviceViewport, element.Wrap),
      }}
      isGrid
    />
  );
};

export default InlineGrid;
