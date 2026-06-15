// Innovace Intech Solution Pvt Ltd
import React, { useRef } from "react";
import type { UIElement } from "@/constants/types";
import { useGeneralStore } from "@/store/useStore";
import { resusableOnChange } from "../../Events/onChange";

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
    // Remove commas
    const rawValue = e.target.value.replace(/,/g, "");

    // Allow only numbers
    if (!/^\d*$/.test(rawValue)) return;

    const numericValue: number | "" =
      rawValue === "" ? "" : Number(rawValue);

    // Update store immediately
    setState(element.ElementName, numericValue as any);

    // Debounce API/event calls
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

  const isVisible =
    storeVisible !== undefined && storeVisible !== null
      ? storeVisible
      : true;

  if (isVisible === false || isVisible === "false") return null;

  // Format number for display
  const formattedValue =
    element.EDT === 3 || element.EDT === 4
      ? value !== "" && value !== null && value !== undefined
        ? Number(value).toLocaleString("en-IN")
        : ""
      : value;

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
            className="text-danger"
          ></span>

          <span className="help">{element.DHelpText}</span>

          <div className="controls" id={`dtx_${element.ElementName}`}>
            <input
              id={controlId}
              name={element.ElementName}
              type="text"
              inputMode="numeric"
              className="form-control input-lg"
              tabIndex={element.TabIndex}
              value={formattedValue}
              onChange={onChange}
              onClick={(e) => e.stopPropagation()}
              autoComplete="off"
            />
          </div>
        </div>
      </div>
    </div>
  );
};

export default DefaultNumericTextBox;