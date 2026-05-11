// Innovace Intech Solution Pvt Ltd
import React from "react";
import type {
  UIElement,
} from "../../../constants/types";
import { useGeneralStore } from "../../../store/useStore";

const LabelComboBox: React.FC<{
  element: UIElement;
  isGrid?: boolean;
}> = ({ element, isGrid }) => {
  const state = useGeneralStore(
    (store) => store.state[element.ElementName]?.["value"]
  );

  const visible = element.ElementControlProperty?.find(p => "Visible" in p)?.Visible ?? "true";
  const isVisible = useGeneralStore(
    (store) => store.state[element.ElementName]?.isVisible
  ) || visible;



  if (isVisible == false || isVisible == "false") return null;
  return (
    <div className={!Boolean(isGrid) ? element.ColumnCss + ` col-md-${element.Wrap}` : undefined}>
      <div
        id={element.ElementName}
      >
        <div className="form-group">
          {!Boolean(isGrid) && Boolean(element["ShowCaption"]) ? (
            <label id="" className="form-label" htmlFor={element.ElementName}>
              {element?.DCaption}
            </label>
          ) : null}
          <span
            id={`man_${element.ElementName}`}
            className="text-danger"
          ></span>

          <div className="controls" onClick={(e) => e.stopPropagation()}>
            <span id={`spn_${element.ElementName}`}>{state}</span>
          </div>
        </div>
      </div>
    </div>
  );
};

export default LabelComboBox;
``;
