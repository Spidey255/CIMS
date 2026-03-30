// Innovace Intech Solution Pvt Ltd
import React from "react";
import type { UIElement } from "../../constants/types";

const PanelWithFooter: React.FC<{
  element: UIElement;
  children?: React.ReactNode;
}> = ({ element, children }) => {
  return <div className={`${element.Css}`}>{children}</div>;
};

export default PanelWithFooter;
