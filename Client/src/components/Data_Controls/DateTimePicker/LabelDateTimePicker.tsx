// Innovace Intech Solution Pvt Ltd
import React, { useEffect } from "react";
import dayjs from "dayjs";
import type { UIElement } from "@/constants/types";
import { useGeneralStore } from "@/store/useStore";

declare global {
  interface Window {
    bootstrap: any;
  }
}

const LabelDateTimePicker: React.FC<{
  element: UIElement;
  isGrid?: boolean;
}> = ({ element, isGrid }) => {
  const state = useGeneralStore(
    (store) => store.state[element.ElementName]?.["value"]
  );

  // Initialize Bootstrap 5 Popover (via CDN)
  useEffect(() => {
    const el = document.getElementById(`dtp_${element.ElementName}`);
    if (el && window.bootstrap) {
      new window.bootstrap.Popover(el);
    }
  }, [element.ElementName]);

  const visible = element.ElementControlProperty?.find(p => "Visible" in p)?.Visible ?? "";

  const storeState = useGeneralStore((store) => store.state[element.ElementName]);

  const isVisible = storeState !== undefined ? storeState.isVisible : visible;

  if (isVisible == false || isVisible == "false") return null

  return (
    <div className={!Boolean(isGrid) ? `${element?.ColumnCss} ${element?.Css} col-md-${element?.Wrap}` : ""}>
      <div id={element.ElementName}>
        <div className="form-group">

          {/* Label */}
          {!isGrid && element.ShowCaption && (
            <label
              id={`lbl_${element.ElementName}`}
              className="form-label"
            >
              {element.DCaption}
            </label>
          )}

          {/* Mandatory Mark */}
          <span
            id={`man_${element.ElementName}`}
            className="text-danger ms-1"
          ></span>

          {/* Date Display */}
          <div
            id={`dtp_${element.ElementName}`}
            className="form-control-sm"
            role="button"
            tabIndex={0}
            data-bs-toggle="popover"
            data-bs-placement="auto"
            data-bs-trigger="hover focus"
            data-bs-content={element.DToolTip}
          >
            <span
              id={`spn_${element.ElementName}`}
              className={`${element.Css} ${!state ? "text-muted fst-italic" : ""}`}
            >
              {/* If there's a state (date), show formatted date. If not, show placeholder. */}
              {state
                ? dayjs(state.toString()).format("YYYY-MM-DD")
                : "YYYY-MM-DD"}
            </span>
          </div>

        </div>
      </div>
    </div>
  );
};

export default LabelDateTimePicker;
