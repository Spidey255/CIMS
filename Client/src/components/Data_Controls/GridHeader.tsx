// Innovace Intech Solution Pvt Ltd
import React from "react";

import type { UIElement } from "../../constants/types";
import { useGridStore } from "../../store/useGridStore";
import { addRow, getValidColumns } from "../../helpers/gridHelpers";

const InlineGridHeader: React.FC<{ element: UIElement }> = ({ element }) => {
  const updateGridState = useGridStore((store) => store.updateGridState);
  const downloadGridDataAsExcel = useGridStore(
    (store) => store.downloadGridDataAsExcel
  );
  const downloadGridDataAsPDF = useGridStore(
    (store) => store.downloadGridDataAsPDF
  );
  const deleteGridRow = useGridStore((store) => store.deleteGridRow);
  const gridHeader = useGridStore(
    (store) => store.gridHeader?.[String(element.ParentElementId)]
  );

  const tableHeaders = getValidColumns(gridHeader);
  const parentElementId = element.ParentElementId;

  const handleAddRow = (): void => {
    if (!parentElementId) {
      alert("parent id is missing");
      return;
    }

    updateGridState(parentElementId, [addRow(tableHeaders)]);
  };

  const handleDeleteRow = (): void => {
    if (!parentElementId) {
      return;
    }

    deleteGridRow(parentElementId);
  };

  const handleDownloadExcel = (): void => {
    if (!parentElementId) {
      return;
    }

    downloadGridDataAsExcel(parentElementId);
  };

  const handleDownloadPDF = (): void => {
    if (!parentElementId) {
      return;
    }

    downloadGridDataAsPDF(parentElementId);
  };

  return (
    // <div
    //   id={element.ElementId || element.UIElementid}
    //   className={`BgGrid card${element.ColumnCss ?? ""} ${
    //     element.Css ?? ""
    //   }`.trim()}
    //   style={{ fontStyle: "normal", textDecoration: "none" }}
    // 
      <div className={`${element.ColumnCss ?? ""} ${element.Css ?? "" }`}>
        <div className="d-flex align-items-center gap-2 mb-2 mb-md-0">
          <h6 className="fw-semibold  mb-0">
            {element.DisplayName || element.ElementName.split("_")[1]}
          </h6>
          <span className="text-danger" style={{ display: "none" }}></span>
        </div>

        <div className="d-flex flex-wrap align-items-center gap-2 grid-heading-elements">
          <button
            type="button"
            className="btn btn-sm bg-light d-flex align-items-center gap-1"
            onClick={handleAddRow}
          >
            <i className="ph ph-plus" aria-hidden="true"></i>
            Add
          </button>

          <button
            type="button"
            className="btn btn-sm bg-light d-flex align-items-center gap-1"
            onClick={handleDeleteRow}
          >
            <i className="ph ph-trash" aria-hidden="true"></i>
            Delete
          </button>

          <button type="button" className="btn btn-sm bg-light">
            <i className="ph ph-funnel" aria-hidden="true"></i>
          </button>

          <div className="dropdown">
            <button
              type="button"
              className="btn btn-sm bg-light dropdown-toggle"
              data-bs-toggle="dropdown"
            >
              <i className="ph ph-list" aria-hidden="true"></i>
            </button>
            <div className="dropdown-menu dropdown-menu-end shadow-sm rounded-3">
              <button className="dropdown-item" type="button">
                <i className="ph ph-copy me-2" aria-hidden="true"></i>
                Copy Row
              </button>
              <button className="dropdown-item" type="button">
                <i className="ph ph-clipboard-text me-2" aria-hidden="true"></i>
                Insert At
              </button>
              <button className="dropdown-item" type="button">
                <i className="ph ph-arrow-up me-2" aria-hidden="true"></i>
                Move Up
              </button>
              <button className="dropdown-item" type="button">
                <i className="ph ph-arrow-down me-2" aria-hidden="true"></i>
                Move Down
              </button>

              <div className="dropdown-divider"></div>

              <button className="dropdown-item" type="button">
                <i
                  className="ph ph-arrows-clockwise me-2"
                  aria-hidden="true"
                ></i>
                Refresh
              </button>

              <div className="dropdown-divider"></div>

              <button
                className="dropdown-item"
                type="button"
                onClick={handleDownloadPDF}
              >
                <i className="ph ph-file-pdf me-2" aria-hidden="true"></i>
                Download PDF
              </button>
              <button className="dropdown-item" type="button" disabled>
                <i className="ph ph-file-pdf me-2" aria-hidden="true"></i>
                Download PDF (All rows)
              </button>
              <button
                className="dropdown-item"
                type="button"
                onClick={handleDownloadExcel}
              >
                <i className="ph ph-file-xls me-2" aria-hidden="true"></i>
                Download Excel
              </button>
              <button className="dropdown-item" type="button" disabled>
                <i className="ph ph-file-xls me-2" aria-hidden="true"></i>
                Download Excel (All rows)
              </button>
            </div>
          </div>
        </div>
      </div>
    // </div>
  );
};

export default InlineGridHeader;
