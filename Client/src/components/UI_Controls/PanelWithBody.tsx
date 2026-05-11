// Innovace Intech Solution Pvt Ltd
import React from "react";
import type { UIElement } from "../../constants/types";

const PanelWithBody: React.FC<{
  element: UIElement;
  children?: React.ReactNode;
}> = ({ element, children }) => {
  // const handleClick = (event: React.MouseEvent<HTMLDivElement, MouseEvent>) => {
  //   event.stopPropagation();
  //   console.log(
  //     "Navigate to ISpace.html with parameters: PkActMId=6DE78E66-3168-45E3-90D6-28204923366E"
  //   );
  //   // Replace with your actual navigation logic
  // };

  // const handleSelect = (
  //   event: React.MouseEvent<HTMLDivElement, MouseEvent>,
  //   id: string
  // ) => {
  //   event.stopPropagation();
  //   console.log("LayoutControlSelected:", id);
  //   // Replace with selection logic
  // };

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
        <div
          style={{
            fontWeight: "normal",
            fontStyle: "normal",
            textDecoration: "none",
          }}
        >
          <div className="panel-body">{children}</div>
        </div>
      </div>
    </div>
  );
};

export default PanelWithBody;
