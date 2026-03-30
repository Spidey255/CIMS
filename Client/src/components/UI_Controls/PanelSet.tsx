// Innovace Intech Solution Pvt Ltd
import React from "react";
import type { UIElement } from "../../constants/types";

const PanelSet: React.FC<{
  element: UIElement;
  children?: React.ReactNode;
}> = ({ element, children }) => {
  const handleSelect = (
    event: React.MouseEvent<HTMLDivElement, MouseEvent>,
    id: string
  ) => {
    event.stopPropagation();
    console.log("LayoutControlSelected:", id);
    // Replace this with your actual selection logic
  };

  return (
    <div
      className={`${element.ColumnCss} ${element.Css}`}
      style={{
        fontWeight: "normal",
        fontStyle: "normal",
        textDecoration: "none",
      }}
    >
      <div
        className="panel"
        style={{
          fontWeight: "normal",
          fontStyle: "normal",
          textDecoration: "none",
        }}
      >
        {/* Panel Heading */}
        <div
          className="panel-heading"
          style={{
            fontWeight: "normal",
            fontStyle: "normal",
            textDecoration: "none",
          }}
        >
          <div style={{ backgroundColor: "inherit" }}>
            <h6
              className="no-margin"
              style={{
                fontWeight: "normal",
                fontStyle: "normal",
                textDecoration: "none",
              }}
            >
              Header
            </h6>
            <ul className="icons-list">
              <li>
                <a data-action="collapse" className="collapse2"></a>
              </li>
            </ul>
          </div>
        </div>

        {/* Panel Body */}
        <div
          className="panel-body"
          style={{
            fontWeight: "normal",
            fontStyle: "normal",
            textDecoration: "none",
          }}
        >
          {children}
        </div>

        {/* Panel Footer */}
        <div
          id="7b7c6abe-53c5-d1a2-d35d-063d5a88da50"
          className="panel-footer"
          style={{
            fontWeight: "normal",
            fontStyle: "normal",
            textDecoration: "none",
          }}
          onClick={(e) =>
            handleSelect(e, "7b7c6abe-53c5-d1a2-d35d-063d5a88da50")
          }
        ></div>
      </div>
    </div>
  );
};

export default PanelSet;
