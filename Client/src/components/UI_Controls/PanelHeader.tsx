// Innovace Intech Solution Pvt Ltd
import React from "react";
import type { UIElement } from "../../constants/types";

const PanelHeader: React.FC<{
  element: UIElement;
  children?: React.ReactNode;
}> = ({ element, children }) => {
  return (
    <div
      id={element.ElementId}
      className={[element.Css, element.ColumnCss]
        .filter(Boolean)
        .join(' ')}
    >
      {children}
    </div>
  );
};

export default PanelHeader;
