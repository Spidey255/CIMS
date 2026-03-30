// Innovace Intech Solution Pvt Ltd
import React from "react";
import type { UIElement } from "../../../constants/types";

const TextBox: React.FC<{
  element: UIElement;
  children?: React.ReactNode;
}> = ({ element, children }) => {
  const handleClick = (e: React.MouseEvent<HTMLDivElement>) => {
    // call your layout control handler
    if (typeof window !== "undefined") {
      // @ts-ignore
      if (window.LayoutControlSelected) {
        // @ts-ignore
        window.LayoutControlSelected(e, element.id);
      }
    }
  };

  return (
    <div
      className="col-lg-4"
      data-root={`root_${element.id}`}
    >
      <div id={element.id} onClick={handleClick}>
        <div className="form-group">
          <label
            id={`lbl_${element.id}`}
            className="form-label"
            htmlFor={`bar_${element.id}`}
          >
            Barcode
          </label>
          <span
            id={`man_${element.id}`}
            className="text-danger"
          ></span>

          <div
            id={`mc_${element.id}`}
            className="controls"
            data-container={`container_${element.id}`}
          >
            <div
              id={`bar_${element.id}`}
              className="barcodeStyle controls e-control e-qrcodegenerator e-lib e-qrcode"
              style={{ height: "200px", width: "549px" }}
            >
              {/* Your SVG Barcode */}
              <svg
                id={`bar_${element.id}content`}
                height="200"
                width="549"
                style={{ background: "white" }}
              >
                <rect
                  x="204.05"
                  y="22.80"
                  width="6.40"
                  height="6.40"
                  fill="black"
                  style={{ shapeRendering: "crispEdges" }}
                />
                {/* ⚠️ You can continue adding the rest of <rect> elements here */}
              </svg>
            </div>
          </div>
        </div>
      </div>
      {children}
    </div>
  );
};

export default TextBox;
