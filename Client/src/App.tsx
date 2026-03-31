import React, { useEffect } from "react";
import { BrowserRouter as Router, Routes, Route, Navigate, Outlet, useLocation } from "react-router-dom";
import { Toaster } from "react-hot-toast";
import NotFound from "@/pages/NotFound";
import GlobalLoader from "@/components/Loader/GlobalLoader";
import Inbox from "@/components/Inbox/Inbox";

import LoginPage from "@/components/Auth/Okta/Login";
    import CreateAccount from "@/components/Auth/Okta/CreateAccount";
    import ForgotPassword from "@/components/Auth/Okta/ForgotPassword";


import MainLayout from "@/layout/SideBar/MainLayout";
import { SidebarProvider } from "@/layout/SideBar/SidebarContext";

import { useUserStore } from "@/store/useUserStore";


import ProjectsExplorer_Start from "@/pages/PRJ20251020000000025-R&DProjects/ProjectsExplorer_Start";
import ProjectProposal_Start from "@/pages/PRJ20251020000000025-R&DProjects/ProjectProposal_Start";
import ProjectProposal_ReadOnlyView-ReadOnly from "@/pages/PRJ20251020000000025-R&DProjects/ProjectProposal_ReadOnlyView-ReadOnly";

const hasAccessToken = (): boolean => {
  if (typeof window === "undefined") {
    return false;
  }

  return Boolean(sessionStorage.getItem("accessToken"));
};

const ProtectedRoute: React.FC = () => {
  const location = useLocation();
  const setSlotId = useUserStore((store) => store.setSlotId);

  useEffect(() => {
    if (hasAccessToken()) {
      setSlotId(sessionStorage.getItem("accessToken") as string);
    }
  }, [setSlotId]);

  if (!hasAccessToken()) {
    return <Navigate to="/login" replace state={{ from: location }} />;
  }

  return <Outlet />;
};

const PublicRoute: React.FC = () => {
  if (hasAccessToken()) {
    return <Navigate to="/" replace />;
  }

  return <Outlet />;
};

const App: React.FC = () => {


  return (
    <>
    <GlobalLoader />
    <Router basename="/CIMS">
  <Routes>
    {/* Routes that require Sidebar */}
    <Route element={<ProtectedRoute />}>
      <Route element={
        <SidebarProvider>
          <MainLayout />
        </SidebarProvider>
      }>
        <Route path="/PRJ20251020000000025-R&DProjects/ProjectsExplorer_Start" element={<ProjectsExplorer_Start />} />
        <Route path="/PRJ20251020000000025-R&DProjects/ProjectProposal_Start" element={<ProjectProposal_Start />} />
        <Route path="/PRJ20251020000000025-R&DProjects/ProjectProposal_ReadOnlyView-ReadOnly" element={<ProjectProposal_ReadOnlyView-ReadOnly />} />
        <Route path="/Inbox" element={<Inbox />} />
        <Route path="*" element={<NotFound />} />
      </Route>
    </Route>

    {/* Public Routes */}
    <Route element={<PublicRoute />}>
      <Route path="/login" element={<LoginPage />} />
       <Route path="/create-account" element={<CreateAccount />} />
                <Route path="/forgot-password" element={<ForgotPassword />} />
    </Route>
    

   

    <Route path="*" element={<NotFound />} />
  </Routes>
</Router>
      <Toaster />
    </>
  );
};

export default App;