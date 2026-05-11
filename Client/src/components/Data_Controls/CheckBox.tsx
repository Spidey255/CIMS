// Innovace Intech Solution Pvt Ltd
import React from "react"; // ;
import type { UIElement } from "../../constants/types";
import { useGeneralStore } from "../../store/useStore";
import { resusableOnChange } from "../Events/onChange";

const CheckBox: React.FC<{
  element: UIElement;
  isGrid?: boolean;
}> = ({ element, isGrid }) => {
  function onchange(e: any) {
    console.log("e.target.checked",e.target.checked);
    setState(element.ElementName, e.target.checked);
    resusableOnChange(element);
  }

  const state = useGeneralStore(
    (store) => store.state[element.ElementName]?.["value"]
  );
  const setState = useGeneralStore((store) => store.setState);

  const controlId = element.ElementName || element.UIElementid;

  return (
    <div  className={!Boolean(isGrid) ? `${element.ColumnCss} col-md-${element.Wrap}` : element.ColumnCss }>
      <div id={controlId} className="form-check form-check-inline">
        <input
          type="checkbox"
          id={element.ElementName}
          name={element.ElementName}
          className="form-check-input"
          data-bs-toggle="popover"
          data-bs-placement="top"
          data-bs-trigger="hover"
          data-bs-content={element?.DToolTip}
          onChange={(e) => onchange(e)}
          onClick={(e) => e.stopPropagation()}
          checked={Boolean(state)}
        />
        <label htmlFor={element.ElementName} className="form-check-label">
          {element?.DCaption}{" "}
        </label>
        <span id={`man_${element.ElementName}`} className="text-danger ms-1"></span>
      </div>
    </div>
  );
};

export default CheckBox;
