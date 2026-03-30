// Innovace Intech Solution Pvt Ltd
import React from "react";
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
  // Get the current value from the store
  const value = useGeneralStore((store) => {
    const val = store.state[element.ElementName]?.value;
    // Only allow number or string, fallback to empty string
    return typeof val === "number" || typeof val === "string" ? val : "";
  });

    const isVisible = useGeneralStore(
      (store) => store.state[element.ElementName]?.["isVisible"]
    ) || false;
  
  
    if (!isVisible) {
      return;
    }

  const setState = useGeneralStore((store) => store.setState);
  const controlId = element.ElementName || element.UIElementid;

  // Handle change
  const onChange = (e: React.ChangeEvent<HTMLInputElement>) => {
    const inputValue = e.target.value;

    // Convert to number if not empty, otherwise keep empty string
    const numericValue: number | "" =
      inputValue === "" ? "" : Number(inputValue);

    // Cast to any to match store typing (string | boolean)
    setState(element.ElementName, numericValue as any);

    // Trigger reusable OnChange if defined
    if (element.Action === "OnChange" && element.BindingDetail) {
      resusableOnChange(element);
    }
  };

  return (
    <div className={!isGrid ? element.ColumnCss : undefined}>
      <div id={controlId}>
        <div className="form-group">
          {/* Caption */}
          {!isGrid && element.ShowCaption && (
            <label className="form-label" htmlFor={controlId}>
              {element.DCaption}
            </label>
          )}

          {/* Error span */}
          <span id={`man_${element.ElementName}`} className="text-danger"></span>

          {/* Help text */}
          <span className="help">{element.DHelpText}</span>

          <div className="controls" id={`dtx_${element.ElementName}`}>
            <input
              id={controlId}
              name={element.ElementName}
              type="number"
              className="form-control input-lg"
              tabIndex={element.TabIndex}
              data-toggle="popover"
              data-trigger="hover"
              data-content="{ToolTip}"
              value={value}
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
