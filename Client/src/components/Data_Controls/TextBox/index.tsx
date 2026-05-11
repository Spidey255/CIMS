// Innovace Intech Solution Pvt Ltd
import React from "react";
import type{ UIElement
 } from "../../../constants/types";
import DefaultTextBox from "./DefaultTextBox";
import LabelTextBox from "./LabelTextBox";
import RichTextBox from "./RichTextBox";
import MultiLineTextBox from "./MultiLineTextBox";
import MaskEnabledTextBox from "./MaskEnabledTextBox";

const TextBox: React.FC<{
  element: UIElement;
  isGrid?: boolean;
}> = ({ element, isGrid }) => {
  switch (element.RenderType) {
    case 1:
      if (element.IsMultiline) {
        return <MultiLineTextBox element={element} isGrid={isGrid} />;
      } else if (element.IsEnableMask) {
        return <MaskEnabledTextBox element={element} isGrid={isGrid} />;
      } else {
        return <DefaultTextBox element={element} isGrid={isGrid} />;
      }
    case 2:
      return <LabelTextBox element={element} isGrid={isGrid} />;
    case 3:
      return <RichTextBox element={element} isGrid={isGrid} />;

    default:
      return <DefaultTextBox element={element} isGrid={isGrid} />;
  }
};

export default TextBox;
