// Innovace Intech Solution Pvt Ltd
import React, { Fragment, useMemo, type ReactNode } from "react";
import _ from "lodash";
import type { ServiceElementData, UIElement } from "../../constants/types";
import { useGridStore } from "../../store/useGridStore";
import { useGeneralStore } from "../../store/useStore";
import GridShimmer from "../Loader/GridShimmer";


const RepeaterGrid: React.FC<{ element: UIElement; children?: ReactNode }> = ({
  element,
  children,
}) => {
  // Resolve the id/key used across the app (be tolerant of casing)
  const elementKey =
    String(
      element?.UIElementId ??
      (element as any)?.UIElementid ??
      (element as any)?.UIElementID ??
      element?.ElementName // fallback
    ) || "";

  // read UI visibility
  const uiState = useGeneralStore(
    (store) => store.uiElementState?.[element.ElementId]
  );

  // Use the normalized elementKey to query grid store
  const gridData = useGridStore((store) => store.gridDynamicState?.[elementKey]);
  const gridSearchText = useGridStore(
    (store) => store.gridSearchText?.[elementKey]
  );
  const gridLoadingState = useGridStore(
    (store) => store.gridLoadingState?.[elementKey]
  );
  const pagination = useGridStore((store) => store.pagination?.[elementKey]);

  // Defensive defaults
  const currentPage = (pagination?.currentPage && pagination.currentPage > 0)
    ? pagination.currentPage
    : 1;
  const pageSize = pagination?.pageSize || 5;

  // ensure `data` is an array
  const data = useMemo<ServiceElementData[] | undefined>(() => {
    if (!Array.isArray(gridData)) return undefined;
    return gridData;
  }, [gridData]);

  // Filter data based on search text (keeps your existing logic but safe-guards)
  const filteredData = useMemo(() => {
    if (!data || !data.length) return data || [];
    if (!gridSearchText) return data;

    const values = useGeneralStore.getState().state || {};

    // Filter keys containing `element.ElementName+`
    const prefix = String(element.ElementName ?? "");
    const filteredCurrenttGridValues = Object.entries(values).filter(([key]) =>
      key.startsWith(prefix + "+")
    );

    const filteredValues = filteredCurrenttGridValues.filter((f) => {
      const v = f[1]?.value;
      return String(v ?? "")
        .toLowerCase()
        .includes(String(gridSearchText ?? "").toLowerCase());
    });

    const rowIds = _.uniq(filteredValues.map((s) => s[0].split("+")[1]));

    // if no matching rowIds, return empty array
    if (!rowIds.length) return [];

    return data.filter((f) => rowIds.includes(String(f.RwId)));
  }, [data, element.ElementName, gridSearchText]);

  // Paginate the filtered data (safe numeric indices)
  const paginatedData = useMemo(() => {
    const startIndex = (currentPage - 1) * pageSize;
    const endIndex = startIndex + pageSize;
    return (filteredData || []).slice(startIndex, endIndex);
  }, [filteredData, currentPage, pageSize]);

  // loading boolean: explicitly true/false only

  // const isLoading =
  //   gridLoadingState === true;

     const isLoading =
    gridLoadingState === true ||
    gridData === undefined ||
    gridData === null;





  if (uiState?.["Visible"] === "false") return null;

  // Recursively clone children and inject props (keeps your logic)
  const cloneChildrenWithProps = (
    children: ReactNode,
    rowData: ServiceElementData
  ): ReactNode => {
    return React.Children.map(children, (child) => {
      if (!React.isValidElement(child)) {
        return child;
      }

      const props = {
        rowId: rowData.RwId,
        gridName: element.ElementName,
      };

      const childProps = child.props as {
        children?: ReactNode;
        element?: { ElementName?: string };
      };

      let updatedProps: Record<string, any> = { ...props };
      if (childProps.element?.ElementName) {
        updatedProps = {
          ...props,
          element: {
            ...childProps.element,
            ElementName: `${element.ElementName}+${rowData.RwId}+${childProps.element.ElementName}`,
          },
        };
      }

      if (childProps.children) {
        return React.cloneElement(child, {
          ...updatedProps,
          children: cloneChildrenWithProps(childProps.children, rowData),
        } as any);
      }

      return React.cloneElement(child, updatedProps as any);
    });
  };

  return (
    <div className={`card-body rep-body ${element?.Css}`}>
      {isLoading ? (
        // <div className="text-center py-5">
        //   <div className="spinner-border text-primary mb-3" role="status"></div>
        //   <div className="fw-semibold text-muted">Loading data...</div>
        // </div>
        <GridShimmer />
      ) : gridSearchText && (!paginatedData || !paginatedData.length) ? (
        <div className="d-flex justify-content-center w-100">
          <div className="text-center py-5">
            <i className="bi bi-search text-muted" style={{ fontSize: "3rem" }}></i>
            <div className="mt-3 fw-bold text-dark">No results found</div>
            <div className="text-muted small">Try adjusting your search keywords.</div>
          </div>
        </div>
      ) : !paginatedData || !paginatedData.length ? (
        <div className="d-flex justify-content-center w-100">
          <div className="text-center py-5">
            <i className="ph ph-package  text-muted" style={{ fontSize: "3.5rem" }}></i>
            <div className="mt-1 fw-bold text-dark">No data available</div>
            <div className="text-muted small">It seems this dataset doesn’t have any items at the moment.</div>
          </div>
        </div>
      ) :
        (
          paginatedData.map((rowData) => (
            <Fragment key={rowData.RwId}>
              <div className={`row Rep-Row `}>
                {cloneChildrenWithProps(children, rowData)}
              </div>
            </Fragment>
          ))
        )}
    </div>
  );
};

export default RepeaterGrid;
