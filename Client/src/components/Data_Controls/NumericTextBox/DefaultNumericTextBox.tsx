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

  // Debounce timer ref
  const debounceRef = useRef<ReturnType<typeof setTimeout> | null>(null);

  const onChange = (e: React.ChangeEvent<HTMLInputElement>) => {
    const inputValue = e.target.value;

    const numericValue: number | "" =
      inputValue === "" ? "" : Number(inputValue);

    // Immediate store update
    setState(element.ElementName, numericValue as any);

    // Clear previous timeout
    if (debounceRef.current) {
      clearTimeout(debounceRef.current);
    }

    // Debounced API/event call
    debounceRef.current = setTimeout(() => {
      if (element.Action === "OnChange" && element.BindingDetail) {
        resusableOnChange(element);
      }
    }, 800); // wait 800ms after typing stops
  };

  const storeVisible = useGeneralStore(
    (store) => store.state[element.ElementName]?.isVisible
  );

  const isVisible =
    storeVisible !== undefined && storeVisible !== null
      ? storeVisible
      : true;

  if (isVisible === false || isVisible === "false") return null;

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
              type="number"
              className="form-control input-lg"
             
              value={
                element.EDT === 3 || element.EDT === 4
                  ? value !== "" && value !== null && value !== undefined
                    ? Number(value).toLocaleString("en-IN")
                    : ""
                  : value
              }
              onChange={onChange}
              onClick={(e) => e.stopPropagation()}
            />
          </div>
        </div>
      </div>
    </div>
  );
};

export default DefaultNumericTextBox;