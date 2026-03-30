// Innovace Intech Solution Pvt Ltd
import React from "react";
import type{  UIElement } from "../../constants/types";

const Row: React.FC<{
  element: UIElement;
  children?: React.ReactNode;
}> = ({ element, children }) => {
  return <div className={`${element.Css || "row"}`}>{children}</div>;
};

export default Row;
