// Innovace Intech Solution Pvt Ltd
import React, { useEffect, useRef } from "react";
import type { UIElement } from "../../constants/types";
import { useTabStore } from "../../store/useTabStore";

interface ITabHeader {
  ElementName: string;
  ActiveTab?: boolean;
  uielementid: string;
  uniqueKey: string;
}

const Tab: React.FC<{ element: UIElement; children?: React.ReactNode }> = ({
  element,
  children,
}) => {
  // Use the uniqueKey to track the active tab
  const activeTab = useTabStore((store) => store.activeTab?.[element.UIElementid]);
  const setActiveTab = useTabStore((store) => store.setActiveTab);

  // Ensure children is an array and not null or undefined
  const safeChildren = React.Children.toArray(children);

  // Extracting the TabHeaders from the children and adding a unique key
  const tabHeaders = safeChildren.map((child: any) => {
    const element = child?.props?.element; // Safe access
    if (element && element.ElementName) {
      return {
        ElementName: element.ElementName,
        uielementid: element.UIElementid,
        uniqueKey: `${element.ElementName}_${element.UIElementid}`, // Add index to make it unique
      };
    }
    return null;
  }).filter(Boolean) as ITabHeader[]; // Type assertion to ITabHeader[]

  // Set the initial active tab when the component mounts
  const isInitialized = useRef(false);

  useEffect(() => {
    if (!isInitialized.current && tabHeaders.length > 0) {
      setActiveTab(element.UIElementid, tabHeaders[0].uniqueKey);
      isInitialized.current = true;
    }
  }, [tabHeaders, setActiveTab, element.UIElementid]);

  useEffect(() => {
    if (tabHeaders.length > 0 && !activeTab) {
      setActiveTab(element.UIElementid, tabHeaders[0].uniqueKey);
    }
  }, [activeTab]); // 👈 reduce dependencies

  // Check if a tab is active based on the uniqueKey
  const isActive = (header: ITabHeader) => {
    return activeTab === header.uniqueKey;
  };

  return (
    <div className="tabbable tab-content-bordered mb-20">
      <ul className="nav nav-pills d-inline-flex border rounded-3 p-1">
        {tabHeaders?.map((header) => (
          <li
            key={header.uniqueKey}
            className={`nav-item ${isActive(header) ? "active" : ""}`}
          >
            <a
              className={`nav-link  ${isActive(header) ? "active" : ""}`}
                onClick={(e) => {
    e.preventDefault();
    setActiveTab(element.UIElementid, header.uniqueKey);
  }}
              role="tab"
              href="#"
            >
              {header.ElementName.includes("_")
                ? header.ElementName.split("_")[1]
                : header.ElementName}
            </a>
          </li>
        ))}
      </ul>

      <div className="tab-content mt-2 card card-body">
        {children}
      </div>
    </div>
  );
};

export default Tab;
