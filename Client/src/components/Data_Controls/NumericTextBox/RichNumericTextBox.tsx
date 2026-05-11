// Innovace Intech Solution Pvt Ltd
import React from "react";
import type{ UIElement } from "../../../constants/types";
import { useGeneralStore } from "../../../store/useStore";


const RichNumericTextBox: React.FC<{
  element: UIElement;
  isGrid?: boolean;
}> = ({ element, isGrid }) => {
  const controlId = element.ElementName || element.UIElementid;
  const state = useGeneralStore(
    (store) => store.state[element.ElementName]?.["value"]
  );

  return (
    <div className={!Boolean(isGrid) ? element.ColumnCss : undefined}>
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
            <div id={`dv_${element.ElementName}`}>{state}</div>
          </div>
        </div>
      </div>
    </div>
  );
};

export default RichNumericTextBox;
