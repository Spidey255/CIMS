// Innovace Intech Solution Pvt Ltd
import React from "react";
import type { UIElement } from "../../constants/types";
import { useGeneralStore } from "../../store/useStore";

const Column: React.FC<{
  element: UIElement;
  children?: React.ReactNode;
}> = ({ element, children }) => {
  if (element.ElementName === "UI_GridColumns") return null;
  const uiControls = useGeneralStore((store) => store.uiElementState);
   const dialogState = useGeneralStore(
           (store) => store.state[element.ElementName]
         );
  
  const visible = dialogState?.visible || uiControls[element.ElementName]?.Visible;

  
  if (visible === "false" || visible === false) return null;


  return (
    <div
      className={[
        element?.ColumnCss,
        element?.Css,
        element?.Wrap ? `col-xl-${element.Wrap} col-lg-${element.Wrap} col-md-${element.Wrap} col-sm-${element.Wrap} col-${element.Wrap}` : null,
        element?.ElementName?.includes("Header") ? "card p-0" : null,
      ]
        .filter(Boolean)
        .join(" ")}
    >
      {children}
    </div>
  );
};

export default Column;
