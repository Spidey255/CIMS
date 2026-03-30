// Innovace Intech Solution Pvt Ltd
import React from "react";
import type { UIElement } from "../../constants/types";

const PanelFooter: React.FC<{
  element: UIElement;
  children?: React.ReactNode;
}> = ({ element, children }) => {
  console
  return (
    <div className={`${element.ColumnCss} ${element.Css}`}>
      
          {/* <div className="card-footer">{children}</div> */}
          {children}
        </div>
    
  );
};

export default PanelFooter;
