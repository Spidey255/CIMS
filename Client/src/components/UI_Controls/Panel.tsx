// Innovace Intech Solution Pvt Ltd
import React from "react";
import type { UIElement } from "../../constants/types";
import { useGeneralStore } from "../../store/useStore";

const Panel: React.FC<{
  element: UIElement;
  children?: React.ReactNode;
}> = ({ element, children }) => {
    const isVisible = useGeneralStore(
      (store) => store.state[element.ElementName]?.["isVisible"]
    ) || false;
  
  
    if (isVisible) {
      return;
    }

  return (
    <div
      className={`${element.Css}`}
    >
      {children}
    </div>
  );
};

export default Panel;
