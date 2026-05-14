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


import ProjectFundInstallment_AdditionalDetails from "@/pages/PRJ20251020000000025-RandC/PRJ20251020000000025-Projects/ProjectFundInstallment_AdditionalDetails";
import ProjectFundInstallment_View0 from "@/pages/PRJ20251020000000025-RandC/PRJ20251020000000025-Projects/ProjectFundInstallment_View0";
import FundConfigurations_Start from "@/pages/PRJ20251020000000025-RandC/PRJ20251020000000025-Projects/FundConfigurations_Start";
import ProjectFundInstallment_HOD from "@/pages/PRJ20251020000000025-RandC/PRJ20251020000000025-Projects/ProjectFundInstallment_HOD";
import CommitmentSpentDetails_Start from "@/pages/PRJ20251020000000025-RandC/PRJ20251020000000025-Projects/CommitmentSpentDetails_Start";
import ProjectFundInstallment_RDOffice from "@/pages/PRJ20251020000000025-RandC/PRJ20251020000000025-Projects/ProjectFundInstallment_RDOffice";
import ProjectFundInstallment_PIInitiation from "@/pages/PRJ20251020000000025-RandC/PRJ20251020000000025-Projects/ProjectFundInstallment_PIInitiation";

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
    <Router basename="/CIMSIITDH">
  <Routes>
    {/* Routes that require Sidebar */}
    <Route element={<ProtectedRoute />}>
      <Route element={
        <SidebarProvider>
          <MainLayout />
        </SidebarProvider>
      }>
        <Route path="/PRJ20251020000000025-RandC/PRJ20251020000000025-Projects/ProjectFundInstallment_AdditionalDetails" element={<ProjectFundInstallment_AdditionalDetails />} />
        <Route path="/PRJ20251020000000025-RandC/PRJ20251020000000025-Projects/ProjectFundInstallment_View0" element={<ProjectFundInstallment_View0 />} />
        <Route path="/PRJ20251020000000025-RandC/PRJ20251020000000025-Projects/FundConfigurations_Start" element={<FundConfigurations_Start />} />
        <Route path="/PRJ20251020000000025-RandC/PRJ20251020000000025-Projects/ProjectFundInstallment_HOD" element={<ProjectFundInstallment_HOD />} />
        <Route path="/PRJ20251020000000025-RandC/PRJ20251020000000025-Projects/CommitmentSpentDetails_Start" element={<CommitmentSpentDetails_Start />} />
        <Route path="/PRJ20251020000000025-RandC/PRJ20251020000000025-Projects/ProjectFundInstallment_RDOffice" element={<ProjectFundInstallment_RDOffice />} />
        <Route path="/PRJ20251020000000025-RandC/PRJ20251020000000025-Projects/ProjectFundInstallment_PIInitiation" element={<ProjectFundInstallment_PIInitiation />} />
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