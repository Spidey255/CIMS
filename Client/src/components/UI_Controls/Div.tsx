// Innovace Intech Solution Pvt Ltd
import React from "react";
import type { UIElement } from "../../constants/types";

const Div: React.FC<{ element: UIElement; children?: React.ReactNode }> = ({
  element,
  children,
}) => {
  return (
    <div  className={[element.Css, element.ColumnCss]
    .filter(Boolean)
    .join(' ')}>
      {element.Content && <span>{element.Content}</span>}
      {children}
    </div>
  );
};


export default Div;
