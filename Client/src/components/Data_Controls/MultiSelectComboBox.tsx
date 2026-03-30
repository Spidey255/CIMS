// Innovace Intech Solution Pvt Ltd
import React from "react";
import type { UIElement } from "../../constants/types";
import { useGeneralStore } from "../../store/useStore";
import { resusableOnChange } from "../Events/onChange";
import { accessMandatory } from "../../helpers/utils";

type TMultiSelectItem = {
  key: string;
  value: string;
  disabled?: boolean;
};

const getOptions = (element: UIElement): TMultiSelectItem[] => {
  const source =
    (element["DictionaryItems"] ||
      element["Items"] ||
      element["List"] ||
      element["Options"] ||
      []) as Array<Record<string, unknown> | string | number>;

  const mapped = source
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
        };
      }

      return null;
    })
    .filter(Boolean) as TMultiSelectItem[];

  return mapped.length ? mapped : [];
};

const parseSelectedValues = (value?: string | number | boolean | null) => {
  if (Array.isArray(value)) return value.map(String);
  if (typeof value === "string") {
    return value
      .split(",")
      .map((item) => item.trim())
      .filter(Boolean);
  }
  if (typeof value === "number" || typeof value === "boolean") {
    return [String(value)];
  }
  return [];
};

const MultiSelectCombo: React.FC<{
  element: UIElement;
  isGrid?: boolean;
}> = ({ element, isGrid }) => {
  const state = useGeneralStore(
    (store) => store.state[element.ElementName]?.["value"]
  );
  const setState = useGeneralStore((store) => store.setState);

  const controlId = element.ElementId || element.UIElementid || element.ElementName;
  const columnCss = !Boolean(isGrid) ? element.ColumnCss : undefined;

  const [searchTerm, setSearchTerm] = React.useState("");

  const options = React.useMemo(() => getOptions(element), [element]);
  const selectedValues = React.useMemo(
    () => {
      const existing = state ?? element.CurrValue ?? "";
      return parseSelectedValues(existing);
    },
    [state, element.CurrValue]
  );

  const filteredOptions = React.useMemo(() => {
    if (!searchTerm) return options;
    return options.filter((opt) =>
      opt.value.toLowerCase().includes(searchTerm.toLowerCase())
    );
  }, [options, searchTerm]);

  const selectedLabels = React.useMemo(
    () =>
      options
        .filter((opt) => selectedValues.includes(opt.key))
        .map((opt) => opt.value),
    [options, selectedValues]
  );

  const placeholderText =
    selectedLabels.length > 0
      ? selectedLabels.join(", ")
      : element.DCaption || element.DHelpText || "Select";

  const updateSelection = (values: string[], triggerOnChange = true) => {
    setState(element.ElementName, values.join(","));
    if (triggerOnChange) {
      resusableOnChange(element);
    }
  };

  const handleToggleValue = (value: string) => {
    const exists = selectedValues.includes(value);
    const nextValues = exists
      ? selectedValues.filter((v) => v !== value)
      : [...selectedValues, value];
    updateSelection(nextValues);
  };

  const handleClear = () => {
    updateSelection([]);
  };

  const handleSelectAll = () => {
    updateSelection(options.map((opt) => opt.key));
  };

  const handleApply = () => {
    resusableOnChange(element);
  };

  const isMandatory =
    element.ElementControlProperty?.some((prop) => accessMandatory(prop)) ?? false;

  const invokeLayoutControlSelected = (
    event: React.MouseEvent<HTMLDivElement, MouseEvent>
  ) => {
    if (typeof window !== "undefined") {
      const layoutControlSelected = (window as never as {
        LayoutControlSelected?: (event: MouseEvent, id: string) => void;
      }).LayoutControlSelected;
      if (typeof layoutControlSelected === "function") {
        layoutControlSelected(event.nativeEvent, controlId);
      }
    }
  };

  return (
    <div
      className={columnCss}
      data-root={`root_${controlId}`}
    >
      <div id={controlId} onClick={invokeLayoutControlSelected}>
        <div className="form-group">
          {!Boolean(isGrid) && Boolean(element.ShowCaption) ? (
            <label
              id={`lbl_${controlId}`}
              className="form-label"
              htmlFor={`msb_${controlId}`}
            >
              {element?.DCaption}
            </label>
          ) : null}
          <span id={`man_${controlId}`} className="text-danger">
            {isMandatory ? "*" : ""}
          </span>
          <div className="controls">
            <div id={`msb_${controlId}`} className="msb-dropdown">
              <input
                type="hidden"
                id={`sel_${controlId}`}
                value={selectedValues.join(",")}
                readOnly
              />
              <div className="dropdown w-100">
                <button
                  className="btn btn-white border dropdown-toggle w-100 d-flex justify-content-between align-items-center"
                  type="button"
                  id={`msb_btn_${controlId}`}
                  data-bs-toggle="dropdown"
                  aria-expanded="false"
                >
                  <span className="msb-placeholder text-start">
                    {placeholderText}
                  </span>
                  <div className="msb-tags ms-2">
                    {selectedLabels.map((label) => (
                      <span key={label} className="badge bg-light text-dark me-1">
                        {label}
                      </span>
                    ))}
                  </div>
                </button>
                <ul
                  className="dropdown-menu p-2 w-100"
                  aria-labelledby={`msb_btn_${controlId}`}
                  style={{ maxHeight: "280px", overflow: "auto" }}
                >
                  <li>
                    <input
                      type="search"
                      className="form-control form-control-sm mb-2 msb-search"
                      placeholder="Search..."
                      value={searchTerm}
                      onChange={(event) => setSearchTerm(event.target.value)}
                    />
                  </li>
                  <li>
                    <div className="msb-list">
                      {filteredOptions.length ? (
                        filteredOptions.map((option, index) => {
                          const checkboxId = `chk_${controlId}_${index}`;
                          const isChecked = selectedValues.includes(option.key);
                          return (
                            <div
                              key={option.key}
                              className="form-check msb-item"
                              data-id={option.key}
                              data-text={option.value}
                            >
                              <input
                                className="form-check-input msb-checkbox"
                                type="checkbox"
                                id={checkboxId}
                                checked={isChecked}
                                disabled={option.disabled}
                                onChange={() => handleToggleValue(option.key)}
                              />
                              <label
                                className="form-check-label"
                                htmlFor={checkboxId}
                              >
                                {option.value}
                              </label>
                            </div>
                          );
                        })
                      ) : (
                        <div className="text-muted small px-2 py-1">
                          No results found
                        </div>
                      )}
                    </div>
                  </li>
                  <li>
                    <div className="dropdown-divider"></div>
                  </li>
                  <li className="d-flex justify-content-between px-2">
                    <button
                      type="button"
                      className="btn btn-sm btn-outline-secondary msb-clear"
                      onClick={handleClear}
                    >
                      Clear
                    </button>
                    <div>
                      <button
                        type="button"
                        className="btn btn-light btn-sm btn-secondary msb-select-all me-1"
                        onClick={handleSelectAll}
                      >
                        All
                      </button>
                      <button
                        type="button"
                        className="btn btn-sm btn-primary msb-apply"
                        onClick={handleApply}
                      >
                        Apply
                      </button>
                    </div>
                  </li>
                </ul>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  );
};

export default MultiSelectCombo;
