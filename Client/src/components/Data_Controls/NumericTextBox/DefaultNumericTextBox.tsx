// Innovace Intech Solution Pvt Ltd
// Innovace Intech Solution Pvt Ltd
import React, { useRef } from "react";
import type { UIElement } from "@/constants/types";
import { useGeneralStore } from "@/store/useStore";
import { resusableOnChange } from "../../Events/onChange";
import { accessMandatory } from "@/helpers/utils";

interface DefaultNumericTextBoxProps {
  element: UIElement;
  isGrid?: boolean;
}

const DefaultNumericTextBox: React.FC<DefaultNumericTextBoxProps> = ({
  element,
  isGrid,
}) => {
  const value = useGeneralStore((store) => {
    const val = store.state[element.ElementName]?.value;

    return typeof val === "number" || typeof val === "string"
      ? val
      : "";
  });

  const setState = useGeneralStore((store) => store.setState);

  const controlId = element.ElementName || element.UIElementid;

  // Debounce timer
  const debounceRef = useRef<ReturnType<typeof setTimeout> | null>(null);

  const onChange = (e: React.ChangeEvent<HTMLInputElement>) => {
    // allow commas + decimal
    let rawValue = e.target.value.replace(/,/g, "");

    // allow only valid number format (including decimal)
    if (!/^\d*\.?\d*$/.test(rawValue)) return;

    // store STRING (important fix)
    setState(element.ElementName, rawValue);

    if (debounceRef.current) {
      clearTimeout(debounceRef.current);
    }

    debounceRef.current = setTimeout(() => {
      if (element.Action === "OnChange" && element.BindingDetail) {
        resusableOnChange(element);
      }
    }, 800);
  };

  const storeVisible = useGeneralStore(
    (store) => store.state[element.ElementName]?.isVisible
  );

const disable = useGeneralStore(
    (store) => store.state[element.ElementName]?.Enbl
  );


  const isVisible =
    storeVisible !== undefined && storeVisible !== null
      ? storeVisible
      : true;

  if (isVisible === false || isVisible === "false") return null;


  const formatNumber = (val: any) => {
    if (val === "" || val === null || val === undefined) return "";

    const str = String(val);

    // split integer + decimal
    const [intPart, decimalPart] = str.split(".");

    const formattedInt = intPart.replace(/\B(?=(\d{3})+(?!\d))/g, ",");

    return decimalPart !== undefined
      ? `${formattedInt}.${decimalPart}`
      : formattedInt;
  };

  // Format number for display
  const formattedValue =
    element.EDT === 3 || element.EDT === 4
      ? value !== "" && value !== null && value !== undefined
        ? formatNumber(value)
        : ""
      : value;

      const isMandatory =
          element.ElementControlProperty?.some((prop) => accessMandatory(prop)) ?? false;

  return (
    <div
      className={
        !isGrid
          ? [element?.ColumnCss, element?.Wrap && `col-md-${element.Wrap}`]
            .filter(Boolean)
            .join(" ")
          : ""
      }
    >
      <div id={controlId}>
        <div className="form-group">
          {!isGrid && element.ShowCaption && (
            <label className="form-label" htmlFor={controlId}>
              {element.DCaption}
            </label>
          )}

           <span
                    id={`man_${element.ElementName}`}
                    className="mandatory-symbol"
                    aria-hidden="true"
                  >
                    {isMandatory &&  !isGrid && (<span className="mandatory-icon">*</span>)}
                  </span> 

          <span className="help">{element.DHelpText}</span>

          <div className="controls" id={`dtx_${element.ElementName}`}>
            <input
              id={controlId}
              name={element.ElementName}
              type="text"
              inputMode="decimal"
              className="form-control input-lg"
              tabIndex={element.TabIndex}
              value={formattedValue}
              onChange={onChange}
              onClick={(e) => e.stopPropagation()}
              autoComplete="off"
	      disabled={disable === false || disable === "false" ? true : false}

            />
          </div>
        </div>
      </div>
    </div>
  );
};

export default DefaultNumericTextBox;
