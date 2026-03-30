// Innovace Intech Solution Pvt Ltd
import React from "react";
import type{ UIElement } from "../../constants/types";

const Label: React.FC<{
  element: UIElement;
  children?: React.ReactNode;
}> = ({ element }) => {
  return <label className={`${element.Css}`}>{element.ElementName.startsWith('UI_')?element.ElementName.split("_")[1]:element.ElementName}</label>;
};

export default Label;
