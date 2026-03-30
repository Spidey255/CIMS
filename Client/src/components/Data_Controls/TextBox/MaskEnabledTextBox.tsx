// Innovace Intech Solution Pvt Ltd
import React from "react";
import type { UIElement } from "../../../constants/types";
import { useGeneralStore } from "../../../store/useStore";

const MaskEnabledTextBox: React.FC<{
  element: UIElement;
  isGrid?: boolean;
}> = ({ element, isGrid }) => {
  const state = useGeneralStore(
    (store) => store.state[element.ElementName]?.["value"]
  );
  const setState = useGeneralStore((store) => store.setState);

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
            <input
              className="form-control input-xs"
              type="password"
              autoComplete="off"
              data-toggle="popover"
              data-trigger="hover"
              maxLength={33}
              placeholder={`Enter ${element.DCaption}`}
              value={typeof state === "string" ? state : ""}
              onChange={(e) => setState(element.ElementName, e.target.value)}
              onClick={(e) => e.stopPropagation()}
              id={element.ElementName}
            />
          </div>
        </div>
      </div>
    </div>
  );
};

export default MaskEnabledTextBox;
