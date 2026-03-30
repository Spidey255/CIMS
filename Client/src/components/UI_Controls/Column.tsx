// Innovace Intech Solution Pvt Ltd
import React from "react";
import type { UIElement } from "../../constants/types";

const Column: React.FC<{
  element: UIElement;
  children?: React.ReactNode;
}> = ({ element, children }) => {
  if (element.ElementName === "UI_GridColumns") return null;


    
  return (
    <div className={`${element?.ColumnCss ? element?.ColumnCss : ''} ${element?.Css ? element?.Css : ''} col-md-${element.Wrap} ${element.ElementName.includes("Header")  ? "card p-0" : '' }`}>{children}</div>
  );
};

export default Column;
