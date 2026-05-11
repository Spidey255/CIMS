// Innovace Intech Solution Pvt Ltd
import React from "react";
import type{ UIElement } from "../../../constants/types";
import DefaultNumericTextBox from "./DefaultNumericTextBox";
import LabelNumericTextBox from "./LabelNumericTextBox";
import RichNumericTextBox from "./RichNumericTextBox";

const NumericTextBox: React.FC<{
  element: UIElement;
  isGrid?: boolean;
}> = ({ element, isGrid }) => {
  switch (element.RenderType) {
    case 15:
      return <DefaultNumericTextBox element={element} isGrid={isGrid} />;
    case 16:
      return <LabelNumericTextBox element={element} isGrid={isGrid} />;
    case 17:
      return <RichNumericTextBox element={element} isGrid={isGrid} />;
    default:
      return <DefaultNumericTextBox element={element} isGrid={isGrid} />;
  }
};

export default NumericTextBox;
