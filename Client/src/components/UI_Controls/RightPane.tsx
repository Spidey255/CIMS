// Innovace Intech Solution Pvt Ltd
import React from "react";
import type { UIElement } from "../../constants/types";

const RightPane: React.FC<{
  element: UIElement;
  children?: React.ReactNode;
}> = ({ element, children }) => {
  return (
    <>
      <div
        id={element.Id.toString()}
        className={`d-inline-flex ms-auto ${element.ColumnCss} ${element.Css}`}
      >
       
        {children}
      </div>
     
    </>
  );
};

export default RightPane;
