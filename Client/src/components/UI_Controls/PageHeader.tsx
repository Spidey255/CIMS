// Innovace Intech Solution Pvt Ltd
import React from "react";
import type { UIElement } from "../../constants/types";

const PageHeader: React.FC<{
  element: UIElement;
  children?: React.ReactNode;
}> = ({ element, children:_children }) => {
  return (
    <div
      id={element.ElementId}
      // className="page-header page-header-light shadow mb-3"
      className={element.Css}
    >
      <div
        className="page-header-content d-flex"
        
      >
        <div className="page-title">
          <h5 className="mb-0">{element.UCaption || element.ElementName?.split("_")[1]}</h5>
        </div>

        <div className="btn-group my-auto ms-auto"></div>
      </div>
    </div>
  );
};

export default PageHeader;
