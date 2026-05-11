// Innovace Intech Solution Pvt Ltd
import React from "react";
import type { UIElement } from "../../../constants/types";
import { useGeneralStore } from "../../../store/useStore";

const RichTextBox: React.FC<{ element: UIElement; isGrid?: boolean }> = ({
  element,
  isGrid,
}) => {
  const state = useGeneralStore(
    (store) => store.state[element.ElementName]?.["value"]
  );

  return (
    <div
      className={!Boolean(isGrid) ? element.ColumnCss : undefined}
      data-root={`root_${element.ElementName}`}
    >
      <div id={`${element.ElementName}`}>
        <div className="form-group">
          {!Boolean(isGrid) && Boolean(element["ShowCaption"]) ? (
            <label className="form-label" htmlFor={element.ElementName}>
              {element?.DCaption}
            </label>
          ) : null}

          <span className="text-danger"></span>

          <div className="controls">
            <div
              id={`dv_${element.ElementName}`}
              className={element["Css"] || undefined}
            >
              {state}
            </div>
          </div>
        </div>
      </div>
    </div>
  );
};

export default RichTextBox;
