// Innovace Intech Solution Pvt Ltd
import React from "react";
import type { UIElement } from "../../constants/types";

const PanelFooter: React.FC<{
  element: UIElement;
  children?: React.ReactNode;
}> = ({ element, children }) => {
  console
  return (
    <div className={[element.Css, element.ColumnCss]
      .filter(Boolean)
      .join(' ')}>

      {/* <div className="card-footer">{children}</div> */}
      {children}
    </div>

  );
};

export default PanelFooter;
