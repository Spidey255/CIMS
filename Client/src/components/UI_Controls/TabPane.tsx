// Innovace Intech Solution Pvt Ltd
import React from "react";
import type { UIElement } from "../../constants/types";
import { useTabStore } from "../../store/useTabStore";

const TabPane: React.FC<{ element: UIElement; children?: React.ReactNode }> = ({
  element,
  children,
}) => {
  // Get the activeTab based on the uniqueKey for the ParentElementId
  const activeTab = useTabStore(
    (store) => store.activeTab?.[String(element?.ParentElementId)]
  );

  // Ensure the active state is based on uniqueKey
  const uniqueKey = `${element.ElementName}_${element.UIElementid}`;


  return (
    <div
      className={`tab-pane fade ${activeTab === uniqueKey ? "show active" : ""}`}
    >
      {children}
    </div>
  );
};

export default TabPane;
