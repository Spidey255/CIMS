import React, { useEffect, useState } from "react";
import { BrowserRouter as Router, Routes, Route, Navigate, Outlet, useLocation } from "react-router-dom";
import { AppToaster } from "@/components/Internal/AppToaster";
import NotFound from "@/pages/NotFound";
import GlobalLoader from "@/components/Loader/GlobalLoader";
import Inbox from "@/components/Inbox/Inbox";
import SessionTimeoutModal from "@/components/Internal/SessionTimeoutModal";

import LoginPage from "@/components/Auth/Okta/Login";
    import CreateAccount from "@/components/Auth/Okta/CreateAccount";
    import ForgotPassword from "@/components/Auth/Okta/ForgotPassword";


import MainLayout from "@/layout/SideBar/MainLayout";
import { SidebarProvider } from "@/layout/SideBar/SidebarContext";

import { useUserStore } from "@/store/useUserStore";


import ProjectsExplorer_Start from "@/pages/PRJ20251020000000025-R&DProjects/ProjectsExplorer_Start";
import ProjectProposal_Start from "@/pages/PRJ20251020000000025-R&DProjects/ProjectProposal_Start";
import ProjectCreationfromAutomation_VIEW1 from "@/pages/PRJ20251020000000025-R&DProjects/ProjectCreationfromAutomation_VIEW1";
import ProjectCreationfromAutomation_VIEW2 from "@/pages/PRJ20251020000000025-R&DProjects/ProjectCreationfromAutomation_VIEW2";
import ProjectProposal_ReadOnly from "@/pages/PRJ20251020000000025-R&DProjects/ProjectProposal_ReadOnly";
import ProjectCreationfromAutomation_VIEW4 from "@/pages/PRJ20251020000000025-R&DProjects/ProjectCreationfromAutomation_VIEW4";
import FundConfigurations_Start from "@/pages/PRJ20251020000000025-R&DProjects/FundConfigurations_Start";
import ProjectCreationfromAutomation_VIEW3 from "@/pages/PRJ20251020000000025-R&DProjects/ProjectCreationfromAutomation_VIEW3";
import CommitmentSpentDetails_Start from "@/pages/PRJ20251020000000025-R&DProjects/CommitmentSpentDetails_Start";

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
 const [sessionExpired, setSessionExpired] = useState(false);

  // global trigger for axios
  (window as any).triggerSessionTimeout = () => {
    setSessionExpired(true);
  };

  const handleLogout = () => {
    sessionStorage.clear();
    window.location.href = "/login";
  };


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
        <Route path="/PRJ20251020000000025-R&DProjects/ProjectCreationfromAutomation_VIEW1" element={<ProjectCreationfromAutomation_VIEW1 />} />
        <Route path="/PRJ20251020000000025-R&DProjects/ProjectCreationfromAutomation_VIEW2" element={<ProjectCreationfromAutomation_VIEW2 />} />
        <Route path="/PRJ20251020000000025-R&DProjects/ProjectProposal_ReadOnly" element={<ProjectProposal_ReadOnly />} />
        <Route path="/PRJ20251020000000025-R&DProjects/ProjectCreationfromAutomation_VIEW4" element={<ProjectCreationfromAutomation_VIEW4 />} />
        <Route path="/PRJ20251020000000025-R&DProjects/FundConfigurations_Start" element={<FundConfigurations_Start />} />
        <Route path="/PRJ20251020000000025-R&DProjects/ProjectCreationfromAutomation_VIEW3" element={<ProjectCreationfromAutomation_VIEW3 />} />
        <Route path="/PRJ20251020000000025-R&DProjects/CommitmentSpentDetails_Start" element={<CommitmentSpentDetails_Start />} />
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
      <AppToaster />
      <SessionTimeoutModal
        isOpen={sessionExpired}
        onConfirm={handleLogout}
      />
    </>
  );
};

export default App;