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

  const visible = element.ElementControlProperty?.find(p => "Visible" in p)?.Visible ?? "true";
  const isVisible = useGeneralStore(
    (store) => store.state[element.ElementName]?.isVisible
  ) || visible;
  console.log("LabelNumericTextBox state for", element.ElementName, ":", element);

  if (isVisible == false || isVisible == "false") return null

  return (
    <div className={!Boolean(isGrid) ? `${element.ColumnCss} ${element.Css} col-md-${element.Wrap}` : ""}>
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
              {/* {state || 0} */}
              {element.EDT === 3 || element.EDT === 4
                ? Number(state || 0).toLocaleString("en-IN")
                : state || 0}
            </span>
          </div>
        </div>
      </div>
    </div>
  );
};

export default LabelNumericTextBox;
