// Innovace Intech Solution Pvt Ltd
import React from "react";
import type { UIElement } from "../../constants/types";
import { useGeneralStore } from "../../store/useStore";

const Panel: React.FC<{
  element: UIElement;
  children?: React.ReactNode;
}> = ({ element, children }) => {
   const uiControls = useGeneralStore((store) => store.uiElementState);
         const dialogState = useGeneralStore(
         (store) => store.state[element.ElementName]
       );
     const visible = dialogState?.visible || uiControls[element.ElementName]?.Visible;

     

     
      //  if (dialogState?.visible === "false") return null;
   
     if (visible === "false" || visible === false) return null;
     
  return (
    <div
      className={`${element.Css}`}
    >
      {children}
    </div>
  );
};

export default Panel;
