// Innovace Intech Solution Pvt Ltd

import React from "react";
import type { UIElement } from "../../../constants/types";

const RichMaskEdit: React.FC<{
  element: UIElement;
  children?: React.ReactNode;
}> = ({ element:_element, children:_children }) => {
  return (
    <div
    id="365cced7-a699-67f0-1407-41d8021ca60c"
    // onClick={handleClick}
  >
    <div className="form-group">
      <label
        id="lbl_365cced7-a699-67f0-1407-41d8021ca60c"
        className="form-label"
        htmlFor="txt_365cced7-a699-67f0-1407-41d8021ca60c"
      >
        MF_MaskEdit
      </label>
      <span
        id="man_365cced7-a699-67f0-1407-41d8021ca60c"
        className="text-danger"
      ></span>
      <div
        id="mc_365cced7-a699-67f0-1407-41d8021ca60c"
        className="controls"
        data-container="container_365cced7-a699-67f0-1407-41d8021ca60c"
      >
        <input
          type="password"
          placeholder=""
          autoComplete="off"
          id="txt_365cced7-a699-67f0-1407-41d8021ca60c"
          name="txt_365cced7-a699-67f0-1407-41d8021ca60c"
          className="form-control input-xs"
          maxLength={50}
          tabIndex={0}
          data-toggle="popover"
          data-trigger="hover"
          data-content=""
          style={{ borderRadius: "3px" }}
        />
      </div>
    </div>
  </div>
  );
};

export default RichMaskEdit;
