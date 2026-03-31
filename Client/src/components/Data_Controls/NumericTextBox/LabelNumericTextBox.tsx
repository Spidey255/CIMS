// Innovace Intech Solution Pvt Ltd
import React from "react";
import type { UIElement } from "../../../constants/types";
import { useGeneralStore } from "../../../store/useStore";

const LabelNumericTextBox: React.FC<{
  element: UIElement;
  isGrid?: boolean;
}> = ({ element, isGrid }) => {
  const controlId = element.ElementName || element.UIElementid;
  const state = useGeneralStore((store) => store.state[controlId]?.["value"]);

  const isVisible = useGeneralStore(
    (store) => store.state[element.ElementName]?.isVisible
  ) ?? true;

  if (!isVisible) return null;

  return (
    <div className={
      !isGrid
        ? [element?.ColumnCss, element?.Wrap && `col-md-${element.Wrap}`]
          .filter(Boolean)
          .join(" ")
        : ""
    }>
      <div id={controlId}>
        <div className="form-group">
          {!Boolean(isGrid) && Boolean(element["ShowCaption"]) ? (
            <label
              id={`lbl_${controlId}`}
              className="form-label"
              htmlFor={element.ElementName}
            >
              {element?.DCaption}
            </label>
          ) : null}

          <span id={`man_${element.ElementName}`} className="text-danger"></span>

          <span className="help">{element?.DHelpText}</span>

          <div className="controls" id={`dtx_${element.ElementName}`}>
            <span id={`spn_${element.ElementId}`} className={element.Css}>
              {state || 0}
            </span>
          </div>
        </div>
      </div>
    </div>
  );
};

export default LabelNumericTextBox;
