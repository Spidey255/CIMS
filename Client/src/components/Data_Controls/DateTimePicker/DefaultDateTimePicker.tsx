// Innovace Intech Solution Pvt Ltd
// Innovace Intech Solution Pvt Ltd
import React from "react";
import dayjs from "dayjs";
import type { UIElement } from "@/constants/types";
import { useGeneralStore } from "@/store/useStore";
import { resusableOnChange } from "../../Events/onChange";
import { accessMandatory } from "@/helpers/utils";

const DefaultDateTimePicker: React.FC<{
  element: UIElement;
  isGrid?: boolean;
}> = ({ element, isGrid }) => {
  function onchange(e: any) {
    setState(element.ElementName, e.target.value);
    resusableOnChange(element);
  }

  const state = useGeneralStore(
    (store) => store.state[element.ElementName]?.["value"]
  );
  
  const setState = useGeneralStore((store) => store.setState);

  const controlId = element.ElementName || element.UIElementid;
  const isMandatory =
      element.ElementControlProperty?.some((prop) => accessMandatory(prop)) ?? false;
  // const visible = element.ElementControlProperty?.find(p => "Visible" in p)?.Visible ?? "";
   const storeVisible = useGeneralStore(
        (store) => store.state[element.ElementName]?.isVisible
      );
    
      const isVisible =
        storeVisible !== undefined && storeVisible !== null
          ? storeVisible
          : true;
    
      if (isVisible == false || isVisible == "false") return null


  return (
    <div className={!Boolean(isGrid) ? `${element.ColumnCss} col-md-${element?.Wrap}` : undefined}>
      <div
        id={`${element.ElementName}`}
        onClick={() => "LayoutControlSelected(event,this.id)"}
      >
        <div className="form-group">
          {!Boolean(isGrid) && Boolean(element["ShowCaption"]) ? (
            <label className="form-label" htmlFor={controlId}>
              {element.DCaption}
            </label>
          ) : null}

         <span
                   id={`man_${controlId}`}
                   className="mandatory-symbol"
                   aria-hidden="true"
                 >
                   {isMandatory && <span className="mandatory-icon">*</span>}
                 </span>

          <div
            className="input-xs"
            id={`dtp_${controlId} `}
            data-toggle="popover"
            data-placement="auto"
            data-trigger="hover"
            data-content={`${element.DToolTip}`}
          >
            <input
              className="form-control input-xs"
              id={controlId}
              type="date"
              value={state ? dayjs(state.toString()).format("YYYY-MM-DD") : ""}
              onChange={(e) => onchange(e)}
              onClick={(e) => e.stopPropagation()}
            />
          </div>
        </div>
      </div>
    </div>
  );
};

export default DefaultDateTimePicker;
