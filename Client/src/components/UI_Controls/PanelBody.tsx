// Innovace Intech Solution Pvt Ltd
import React from "react";
import type{ UIElement } from "../../constants/types";

const PanelBody: React.FC<{
  element: UIElement;
  children?: React.ReactNode;
}> = ({ element, children }) => {
  let css = "card-body";
  if(element.Css){
    css = `${element.Css}`;
  }
  return <div className={`${css}`}>{children}</div>;
};

export default PanelBody;
