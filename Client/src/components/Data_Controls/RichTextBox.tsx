// Innovace Intech Solution Pvt Ltd
import React from "react";
import type { UIElement } from "../../constants/types";

const RichTextBox: React.FC<{
  element: UIElement;
  children?: React.ReactNode;
}> = ({ element }) => { // Destructure the 'element' prop
  console.log("element", element); // Now 'element' will be logged correctly

  return (
    <div className="mb-3">
      <label htmlFor="richTextBox" className="form-label">
        {element?.DCaption}
      </label>
      <textarea
        id="richTextBox"
        className="form-control"
        rows={5}
        placeholder="Enter your text here..."
      ></textarea>
    </div>
  );
};

export default RichTextBox;
