// Innovace Intech Solution Pvt Ltd
import React from "react";
import type { UIElement } from "../../constants/types";

const BindableRadioButton: React.FC<{
  element: UIElement;
  children?: React.ReactNode;
}> = ({ element:_element, children:_children }) => {
  // Mock function to replace your inline onclick
  // const LayoutControlSelected = (event: React.MouseEvent, id: string) => {
  //   console.log("LayoutControlSelected triggered with id:", id);
  // };

  const LayoutControlSelected = (event: React.MouseEvent, id: string) => {
  event.preventDefault();
  console.log("LayoutControlSelected triggered with id:", id);
};


  return (
    <div className="col-lg-4" data-root="root_e06dc931-38b1-bc65-e974-2761f39c843b">
      <div
        id="e06dc931-38b1-bc65-e974-2761f39c843b"
        onClick={(e) =>
          LayoutControlSelected(e, "e06dc931-38b1-bc65-e974-2761f39c843b")
        }
        className="form-group "
      >
        <label
          id="lbl_e06dc931-38b1-bc65-e974-2761f39c843b"
          className="form-label"
          htmlFor="bar_e06dc931-38b1-bc65-e974-2761f39c843b"
        >
          MF_BindableRadioButton
        </label>
        <span
          id="man_e06dc931-38b1-bc65-e974-2761f39c843b"
          className="text-danger"
        ></span>

        <div
          className="controls"
          id="bar_e06dc931-38b1-bc65-e974-2761f39c843b"
          tabIndex={0}
          style={{}}
        >
          <label
            className="radio-inline"
            htmlFor="MF_BindableRadioButton26D03AAF-824C-4562-9F6D-2DDF67F33379"
          >
            <div
              className="choice"
              id="uniform-MF_BindableRadioButton26D03AAF-824C-4562-9F6D-2DDF67F33379"
            >
              <span>
                <input
                  className="styled"
                  id="MF_BindableRadioButton26D03AAF-824C-4562-9F6D-2DDF67F33379"
                  name="MF_BindableRadioButton"
                  type="radio"
                  value="26D03AAF-824C-4562-9F6D-2DDF67F33379"
                  data-toggle="popover"
                  data-trigger="hover"
                  data-content=""
                />
              </span>
            </div>
            Education
          </label>

          <label
            className="radio-inline"
            htmlFor="MF_BindableRadioButton94800F84-074A-4FCE-8888-906814450DBF"
          >
            <div
              className="choice"
              id="uniform-MF_BindableRadioButton94800F84-074A-4FCE-8888-906814450DBF"
            >
              <span>
                <input
                  className="styled"
                  id="MF_BindableRadioButton94800F84-074A-4FCE-8888-906814450DBF"
                  name="MF_BindableRadioButton"
                  type="radio"
                  value="94800F84-074A-4FCE-8888-906814450DBF"
                  data-toggle="popover"
                  data-trigger="hover"
                  data-content=""
                />
              </span>
            </div>
            Banking
          </label>

          <label
            className="radio-inline"
            htmlFor="MF_BindableRadioButton9060D0D8-5215-4250-92D5-85FF1B082026"
          >
            <div
              className="choice"
              id="uniform-MF_BindableRadioButton9060D0D8-5215-4250-92D5-85FF1B082026"
            >
              <span>
                <input
                  className="styled"
                  id="MF_BindableRadioButton9060D0D8-5215-4250-92D5-85FF1B082026"
                  name="MF_BindableRadioButton"
                  type="radio"
                  value="9060D0D8-5215-4250-92D5-85FF1B082026"
                  data-toggle="popover"
                  data-trigger="hover"
                  data-content=""
                />
              </span>
            </div>
            Manufacturing
          </label>
        </div>
      </div>
    </div>
  );
};

export default BindableRadioButton;
