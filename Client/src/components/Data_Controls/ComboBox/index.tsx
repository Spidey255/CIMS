// Innovace Intech Solution Pvt Ltd
import React from "react";
// import type{ UIElement } from "@/constants/types";
import type{ UIElement } from "../../../constants/types";
import DefaultComboBox from "./DefaultComboBox";
import LabelComboBox from "./LabelComboBox";
import RichTextComboBox from "./RichTextComboBox";
// 
const ComboBox: React.FC<{
  element: UIElement;
  isGrid?: boolean;
}> = ({ element, isGrid }) => {
  switch (element.RenderType) {
    case 12:
      return <DefaultComboBox element={element} isGrid={isGrid} />;
    case 13:
      return <LabelComboBox element={element} isGrid={isGrid} />;
    case 14:
      return <RichTextComboBox element={element} isGrid={isGrid} />;
    default:
      return <DefaultComboBox element={element} isGrid={isGrid} />;
  }
};

export default ComboBox;
