// Innovace Intech Solution Pvt Ltd
// Innovace Intech Solution Pvt Ltd
import React from "react";
import type { UIElement } from "../../../constants/types";
import { useGeneralStore } from "../../../store/useStore";
import { resusableOnChange } from "../../Events/onChange";
import { accessMandatory } from "@/helpers/utils";

const DefaultTextBox: React.FC<{ element: UIElement; isGrid?: boolean }> = ({
  element,
  isGrid,
}) => {
  const state = useGeneralStore(
    (store) => store.state[element.ElementName]?.["value"]
  );


  const setState = useGeneralStore((store) => store.setState);

  function onChange(e: any) {
    setState(element.ElementName, e.target.value);
    resusableOnChange(element);
  }

  const controlId = element.ElementName || element.UIElementid;

  const storeVisible = useGeneralStore(
    (store) => store.state[element.ElementName]?.isVisible
  );

  const isMandatory =
    element.ElementControlProperty?.some((prop) => accessMandatory(prop)) ?? false;

  const isVisible =
    storeVisible !== undefined && storeVisible !== null
      ? storeVisible
      : true;

  if (isVisible == false || isVisible == "false") return null

  return (
    <div className={!Boolean(isGrid) ? `${element.ColumnCss} col-md-${element.Wrap}` : element.ColumnCss}>
      <div className="form-group">
        {!Boolean(isGrid) && Boolean(element["ShowCaption"]) ? (
          <label id={element.ElementName} className="form-label">
            {element?.DCaption}
          </label>
        ) : null}


        <span
          id={`man_${element.ElementName}`}
          className="mandatory-symbol"
          aria-hidden="true"
        >
          {isMandatory && <span className="mandatory-icon">*</span>}
        </span>

        <div id={`mc_${element.ElementName}`} className="controls">
          {element.IsMultiline ? (
            <textarea
              id={controlId}
              name={element.ElementName}
              cols={25}
              rows={5}
              className="form-control input-lg"
              placeholder={element?.DHelpText}
              value={state !== undefined && state !== null ? String(state) : ""}              // ? controlled value
              onChange={onChange}               // ? update store
              onClick={(e) => e.stopPropagation()}
            />
          ) : (
            <input
              type="text"
              id={controlId}
              name={element.ElementName}
              className="form-control input-lg"
              placeholder={element?.DHelpText}
              value={state !== undefined && state !== null ? String(state) : ""}              // ? controlled value
              onChange={onChange}
              onClick={(e) => e.stopPropagation()}
            />
          )}
        </div>
      </div>
    </div>
  );
};

export default DefaultTextBox;
