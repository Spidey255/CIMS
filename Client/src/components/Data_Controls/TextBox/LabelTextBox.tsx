// Innovace Intech Solution Pvt Ltd
import React from "react";
import type { UIElement } from "../../../constants/types";
import { useGeneralStore } from "../../../store/useStore";

const LabelTextBox: React.FC<{ element: UIElement; isGrid?: boolean }> = ({
  element,
  isGrid,
}) => {
  const state = useGeneralStore(
    (store) => store.state[element.ElementName]?.["value"]
  ) || "-----";





  // Check if value contains HTML
  const isHTML = (value: unknown): value is string => {
    if (typeof value !== "string") return false;

    const parser = new DOMParser();
    const doc = parser.parseFromString(value, "text/html");

    return Array.from(doc.body.childNodes).some(
      (node) => node.nodeType === Node.ELEMENT_NODE
    );
  };

  const formattedState =
    state !== null && state !== undefined
      ? state.toString().toUpperCase()
      : "";


  // Tooltip text (title must be string)
  const titleText =
    typeof state === "string"
      ? isHTML(state)
        ? "Empty"
        : formattedState
      : "";

  const visible = element.ElementControlProperty?.find(p => "Visible" in p)?.Visible ?? "true";
  const isVisible = useGeneralStore(
    (store) => store.state[element.ElementName]?.isVisible
  ) || visible;


  if (isVisible == false || isVisible == "false") return null

  // if (!isVisible) return null;
  return (
    <div
      className={
        !isGrid
          ? `${element.ColumnCss} ${element.Css} col-md-${element.Wrap}`
          : undefined
      }
      data-root={`root_${element.ElementName}`}

    >
      <div id={element.ElementName}>
        <div className="form-group">
          {!isGrid && element.ShowCaption && (
            <label
              className="form-label"
              htmlFor={element.ElementName}
            >
              {element.DCaption}
            </label>
          )}

          <span className="text-danger"></span>

          <div className="controls">
            <span title={titleText}
              {...(isHTML(state)
                ? { dangerouslySetInnerHTML: { __html: state } }
                : { children: state })}
            />
          </div>
        </div>
      </div>
    </div>
  );
};

export default LabelTextBox;
