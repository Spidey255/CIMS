// Innovace Intech Solution Pvt Ltd
// Innovace Intech Solution Pvt Ltd
import React from "react";
import type { UIElement } from "../../../constants/types";
import { useGeneralStore } from "../../../store/useStore";
import { accessMandatory } from "@/helpers/utils";

const MultiLineTextBox: React.FC<{ element: UIElement; isGrid?: boolean }> = ({
  element,
  isGrid,
}) => {
  const state = useGeneralStore(
    (store) => store.state[element.ElementName]?.["value"]
  );
  const setState = useGeneralStore((store) => store.setState);

  const isMandatory =
      element.ElementControlProperty?.some((prop) => accessMandatory(prop)) ?? false;

  return (
    <div className={[
  element?.ColumnCss,
  !isGrid && element?.Wrap && `col-md-${element.Wrap} mb-2`,
]
  .filter(Boolean)
  .join(" ")}>
      <div id={`${element.ElementName}`}>
        <div className="form-group">
          {!Boolean(isGrid) && Boolean(element["ShowCaption"]) ? (
            <label className="form-label" htmlFor={element.ElementName}>
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

          <div className="controls">
            <textarea
              className="form-control input-lg"
              data-type="textarea"
              cols={25}
              rows={5}
              placeholder={element?.DHelpText}
              autoComplete="off"
              data-toggle="popover"
              data-trigger="hover"
              value={typeof state === "string" ? state : ""}
              onChange={(e) => setState(element.ElementName, e.target.value)}
              onClick={(e) => e.stopPropagation()}
              id={element.ElementName}
            ></textarea>
          </div>
        </div>
      </div>
    </div>
  );
};

export default MultiLineTextBox;
