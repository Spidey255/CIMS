// Innovace Intech Solution Pvt Ltd
import React from "react";
import type { UIElement } from "../../constants/types";

const PanelWithHeader: React.FC<{
  element: UIElement;
  children?: React.ReactNode;
}> = ({ element, children }) => {
  // const handleClick = (event: React.MouseEvent<HTMLDivElement, MouseEvent>) => {
  //   event.stopPropagation();
  //   console.log(
  //     "Navigate to ISpace.html with parameters: PkActMId=DFA8D2B5-1B04-40A9-A924-58C40ADA25FA"
  //   );
  //   // Replace with actual navigation logic
  // };

  const handleSelect = (
    event: React.MouseEvent<HTMLDivElement, MouseEvent>,
    id: string
  ) => {
    event.stopPropagation();
    console.log("LayoutControlSelected:", id);
    // Replace with selection logic
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
        id="915509a6-6bb2-7c32-f34a-bdb43990e1d4"
        className="panel"
        style={{
          fontWeight: "normal",
          fontStyle: "normal",
          textDecoration: "none",
        }}
      >
        <div
          id="61ff51ae-94a4-c1a6-5196-13e6b76e513c"
          className="panel-heading"
          style={{
            borderStyle: "solid",
            fontWeight: "normal",
            fontStyle: "normal",
            textDecoration: "none",
          }}
          onClick={(e) =>
            handleSelect(e, "61ff51ae-94a4-c1a6-5196-13e6b76e513c")
          }
        >
          <div
            id="phd_61ff51ae-94a4-c1a6-5196-13e6b76e513c"
            className=""
            style={{ backgroundColor: "inherit" }}
          >
            {children}
          </div>
        </div>
      </div>
    </div>
  );
};

export default PanelWithHeader;
