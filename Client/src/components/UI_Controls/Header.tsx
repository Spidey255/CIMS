// Innovace Intech Solution Pvt Ltd
import React, { type JSX } from "react";
import type { UIElement } from "../../constants/types";

const Header: React.FC<{ element: UIElement }> = ({ element }) => {
  const Tag = (element?.HeadingType || "h1") as keyof JSX.IntrinsicElements;

  return (
    <Tag
      id={element.ElementId || element.UIElementid || ""}
      className={`mb-0 ${element?.ColumnCss || ""} ${element?.Css || ""}`}
    >
      {element?.UCaption || ""}
    </Tag>
  );
};

export default Header;
