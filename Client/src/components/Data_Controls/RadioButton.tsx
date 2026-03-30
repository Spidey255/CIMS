// Innovace Intech Solution Pvt Ltd
import React from "react";
import type { UIElement } from "../../constants/types";
import { resusableOnChange } from "../Events/onChange";
import { useGeneralStore } from "../../store/useStore";
import { accessMandatory } from "../../helpers/utils";

type TRadioItem = {
  key: string;
  value: string;
  disabled?: boolean;
  tooltip?: string;
};

const normalizeRadioItems = (element: UIElement): TRadioItem[] => {
  const rawItems =
    (element["DictionaryItems"] ||
      element["Items"] ||
      element["List"] ||
      element["Options"] ||
      []) as Array<Record<string, unknown> | string | number>;

  const mapped = rawItems
    .map((item, index) => {
      if (item === null || item === undefined) return null;

      if (typeof item === "string" || typeof item === "number") {
        const normalized = String(item);
        return { key: normalized, value: normalized };
      }

      if (typeof item === "object") {
        const key =
          item["ItemKey"] ??
          item["key"] ??
          item["Key"] ??
          item["id"] ??
          item["ID"] ??
          item["value"] ??
          item["Value"] ??
          index;
        const value =
          item["ItemValue"] ??
          item["value"] ??
          item["Value"] ??
          item["VerticalName"] ??
          item["DisplayName"] ??
          item["name"] ??
          "";

        return {
          key: String(key),
          value: String(value),
          disabled: Boolean(
            item["Disabled"] ?? item["disable"] ?? item["IsDisabled"] ?? false
          ),
          tooltip: (item["ToolTip"] ??
            item["tooltip"] ??
            item["DToolTip"] ??
            "") as string,
        };
      }

      return null;
    })
    .filter(Boolean) as TRadioItem[];

  if (mapped.length) return mapped;

  return [
    { key: "Yes", value: "Yes" },
    { key: "No", value: "No" },
  ];
};

const RadioButton: React.FC<{
  element: UIElement;
  isGrid?: boolean;
}> = ({ element, isGrid }) => {
  const state = useGeneralStore(
    (store) => store.state[element.ElementName]?.["value"]
  );
  const setState = useGeneralStore((store) => store.setState);

  const controlId = element.ElementId || element.UIElementid || element.ElementName;
  const columnCss = !Boolean(isGrid) ? element.ColumnCss : undefined;

  const isMandatory =
    element.ElementControlProperty?.some((prop) => accessMandatory(prop)) ?? false;
  const isDisabled = element.ElementControlProperty?.some(
    (prop) => "Enable" in prop && prop.Enable === false
  );

  const formGroupClasses = ["form-group", element.Css, element.AlignmentClass]
    .filter(Boolean)
    .join(" ")
    .trim();

  const radioItems = React.useMemo(() => normalizeRadioItems(element), [element]);

  const selectedValue =
    state !== undefined && state !== null
      ? String(state)
      : element.CurrValue !== undefined && element.CurrValue !== null
      ? String(element.CurrValue)
      : "";

  const handleChange = (event: React.ChangeEvent<HTMLInputElement>) => {
    setState(element.ElementName, event.target.value);
    resusableOnChange(element);
  };

  const dangerClass = element["DangerClass"] || "";
  const labelDisabledClass = element["LabelDisabledClass"] || "";

  return (
    <div
      className={columnCss}
      data-root={`root_${controlId}`}
      // root={`root_${controlId}`}
    >
      <div id={controlId} className={formGroupClasses || "form-group"}>
        {!Boolean(isGrid) && Boolean(element.ShowCaption) ? (
          <label
            id={`lbl_${controlId}`}
            className="form-label mb-1 fw-semibold"
            htmlFor={element.ElementName}
          >
            {element?.DCaption}
          </label>
        ) : null}

        <span id={`man_${controlId}`} className="text-danger">
          {isMandatory ? "*" : ""}
        </span>

        <div
          className="controls mt-2"
          id={element.ElementName}
          tabIndex={element.TabIndex ?? 0}
        >
          {radioItems.map((item) => {
            const radioId = `${element.ElementName}${item.key}`;
            const isItemDisabled = Boolean(isDisabled || item.disabled);

            return (
              <div className="form-check form-check-inline" key={radioId}>
                <input
                  className={`form-check-input ${dangerClass}`.trim()}
                  id={radioId}
                  name={element.ElementName}
                  type="radio"
                  value={item.key}
                  checked={selectedValue === item.key}
                  disabled={isItemDisabled}
                  onChange={handleChange}
                  onClick={(e) => e.stopPropagation()}
                  data-toggle="popover"
                  data-trigger="hover"
                  data-content={item.tooltip || element.DToolTip || ""}
                />
                <label
                  className={`form-check-label ${labelDisabledClass}`.trim()}
                  htmlFor={radioId}
                >
                  {item.value}
                </label>
              </div>
            );
          })}
        </div>
      </div>
    </div>
  );
};

export default RadioButton;
