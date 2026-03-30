// Innovace Intech Solution Pvt Ltd
import React from "react";

import type { UIElement } from "../../constants/types";
import { useGridStore } from "../../store/useGridStore";
import { useGeneralStore } from "../../store/useStore";

const InlineGridSearchBar: React.FC<{ element: UIElement }> = ({
  element,
}) => {
  const gridSearchText = useGridStore(
    (store) => store.gridSearchText?.[element.ParentElementId!]
  );
  const setGridSearchText = useGridStore((store) => store.setGridSearchText);
  const clearGridSearchText = useGridStore(
    (store) => store.clearGridSearchText
  );
  const uiState = useGeneralStore(
    (store) => store.uiElementState?.[String(element?.TempElementId)]
  );

  if (uiState?.["Visible"] === "false" || !element?.Css?.includes("in")) {
    return null;
  }

  return (
    <div className="search_part collapse card-body bg-light show">
      <div className="row g-2 align-items-center">
        <div className="col-md-6 col-sm-6 col-12">
          <div className="input-group">
            <input
              type="search"
              placeholder="Search..."
              className="form-control"
              value={gridSearchText || ""}
              onChange={(e) =>
                setGridSearchText(element["ParentElementId"]!, e.target.value)
              }
            />

            <button className="btn btn-light" type="button">
              <i className="ph ph-magnifying-glass"></i>
            </button>
          </div>
        </div>

        <div className="col-md-1 col-sm-12 text-center">
          <button
            className="btn btn-light"
            type="button"
            onClick={() => clearGridSearchText(element["ParentElementId"]!)}
          >
            <i className="ph ph-arrows-clockwise"></i>
          </button>
        </div>
      </div>
    </div>
  );
};

export default InlineGridSearchBar;
