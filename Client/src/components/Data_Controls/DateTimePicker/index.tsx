// Innovace Intech Solution Pvt Ltd
import React from "react";
// import type{ UIElement } from "@/constants/types";
import type { UIElement } from "../../../constants/types";
import DefaultDateTimePicker from "./DefaultDateTimePicker";
import LabelDateTimePicker from "./LabelDateTimePicker";
import RichTextDateTimePicker from "./RichTextDateTimePicker";

const NumericTextBox: React.FC<{
  element: UIElement;
  isGrid?: boolean;
}> = ({ element, isGrid }) => {
 
  switch (element.RenderType) {
    case 9:
      return <DefaultDateTimePicker element={element} isGrid={isGrid} />;
    case 10:
      return <LabelDateTimePicker element={element} isGrid={isGrid} />;
    case 11:
      return <RichTextDateTimePicker element={element} isGrid={isGrid} />;
    default:
      return <DefaultDateTimePicker element={element} isGrid={isGrid} />;
  }
};

export default NumericTextBox;
