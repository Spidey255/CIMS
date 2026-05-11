// Innovace Intech Solution Pvt Ltd
import { createContext, useContext, useState } from "react";

interface SidebarCtx {
  collapsed: boolean;
  toggle: () => void;
}

const SidebarContext = createContext<SidebarCtx>({
  collapsed: true,
  toggle: () => {},
});

export const SidebarProvider = ({ children }: any) => {
  const [collapsed, setCollapsed] = useState(true);

  return (
    <SidebarContext.Provider
      value={{
        collapsed,
        toggle: () => setCollapsed(!collapsed),
      }}
    >
      {children}
    </SidebarContext.Provider>
  );
};

export const useSidebar = () => useContext(SidebarContext);
