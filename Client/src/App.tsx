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


import ProjectReimbursement_RDoffice from "@/pages/PRJ20251020000000025-R&DProjects/ProjectReimbursement_RDoffice";
import ProjectFundInstallment_AdditionalDetails from "@/pages/PRJ20251020000000025-R&DProjects/ProjectFundInstallment_AdditionalDetails";
import ProjectsExplorer_Start from "@/pages/PRJ20251020000000025-R&DProjects/ProjectsExplorer_Start";
import TempAdvance_RDoffice from "@/pages/PRJ20251020000000025-R&DProjects/TempAdvance_RDoffice";
import ProjectReimbursement_Registrar from "@/pages/PRJ20251020000000025-R&DProjects/ProjectReimbursement_Registrar";
import TempAdvance_PIInitiation from "@/pages/PRJ20251020000000025-R&DProjects/TempAdvance_PIInitiation";
import ProjectProposal_Start from "@/pages/PRJ20251020000000025-R&DProjects/ProjectProposal_Start";
import ProjectCreationfromAutomation_VIEW1 from "@/pages/PRJ20251020000000025-R&DProjects/ProjectCreationfromAutomation_VIEW1";
import TempAdvance_RDofficepayment from "@/pages/PRJ20251020000000025-R&DProjects/TempAdvance_RDofficepayment";
import ProjectCreationfromAutomation_VIEW2 from "@/pages/PRJ20251020000000025-R&DProjects/ProjectCreationfromAutomation_VIEW2";
import TempAdvance_AdditionalDetails from "@/pages/PRJ20251020000000025-R&DProjects/TempAdvance_AdditionalDetails";
import TempAdvance_Registrar from "@/pages/PRJ20251020000000025-R&DProjects/TempAdvance_Registrar";
import ProjectProposal_ReadOnly from "@/pages/PRJ20251020000000025-R&DProjects/ProjectProposal_ReadOnly";
import ProjectCreationfromAutomation_VIEW4 from "@/pages/PRJ20251020000000025-R&DProjects/ProjectCreationfromAutomation_VIEW4";
import FundConfigurations_Start from "@/pages/PRJ20251020000000025-R&DProjects/FundConfigurations_Start";
import ProjectCreationfromAutomation_VIEW3 from "@/pages/PRJ20251020000000025-R&DProjects/ProjectCreationfromAutomation_VIEW3";
import ProjectFundInstallment_HOD from "@/pages/PRJ20251020000000025-R&DProjects/ProjectFundInstallment_HOD";
import TempAdvance_DeanRD from "@/pages/PRJ20251020000000025-R&DProjects/TempAdvance_DeanRD";
import ProjectReimbursement_PIInitiation from "@/pages/PRJ20251020000000025-R&DProjects/ProjectReimbursement_PIInitiation";
import CommitmentSpentDetails_Start from "@/pages/PRJ20251020000000025-R&DProjects/CommitmentSpentDetails_Start";
import ProjectFundInstallment_RDOffice from "@/pages/PRJ20251020000000025-R&DProjects/ProjectFundInstallment_RDOffice";
import ProjectFundInstallment_PIInitiation from "@/pages/PRJ20251020000000025-R&DProjects/ProjectFundInstallment_PIInitiation";
import ProjectReimbursement_AdditionalDetails from "@/pages/PRJ20251020000000025-R&DProjects/ProjectReimbursement_AdditionalDetails";
import ProjectReimbursement_DeanRD from "@/pages/PRJ20251020000000025-R&DProjects/ProjectReimbursement_DeanRD";
import TempAdvance_ARRD from "@/pages/PRJ20251020000000025-R&DProjects/TempAdvance_ARRD";
import ProjectReimbursement_ARRD from "@/pages/PRJ20251020000000025-R&DProjects/ProjectReimbursement_ARRD";

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
        <Route path="/PRJ20251020000000025-R&DProjects/ProjectReimbursement_RDoffice" element={<ProjectReimbursement_RDoffice />} />
        <Route path="/PRJ20251020000000025-R&DProjects/ProjectFundInstallment_AdditionalDetails" element={<ProjectFundInstallment_AdditionalDetails />} />
        <Route path="/PRJ20251020000000025-R&DProjects/ProjectsExplorer_Start" element={<ProjectsExplorer_Start />} />
        <Route path="/PRJ20251020000000025-R&DProjects/TempAdvance_RDoffice" element={<TempAdvance_RDoffice />} />
        <Route path="/PRJ20251020000000025-R&DProjects/ProjectReimbursement_Registrar" element={<ProjectReimbursement_Registrar />} />
        <Route path="/PRJ20251020000000025-R&DProjects/TempAdvance_PIInitiation" element={<TempAdvance_PIInitiation />} />
        <Route path="/PRJ20251020000000025-R&DProjects/ProjectProposal_Start" element={<ProjectProposal_Start />} />
        <Route path="/PRJ20251020000000025-R&DProjects/ProjectCreationfromAutomation_VIEW1" element={<ProjectCreationfromAutomation_VIEW1 />} />
        <Route path="/PRJ20251020000000025-R&DProjects/TempAdvance_RDofficepayment" element={<TempAdvance_RDofficepayment />} />
        <Route path="/PRJ20251020000000025-R&DProjects/ProjectCreationfromAutomation_VIEW2" element={<ProjectCreationfromAutomation_VIEW2 />} />
        <Route path="/PRJ20251020000000025-R&DProjects/TempAdvance_AdditionalDetails" element={<TempAdvance_AdditionalDetails />} />
        <Route path="/PRJ20251020000000025-R&DProjects/TempAdvance_Registrar" element={<TempAdvance_Registrar />} />
        <Route path="/PRJ20251020000000025-R&DProjects/ProjectProposal_ReadOnly" element={<ProjectProposal_ReadOnly />} />
        <Route path="/PRJ20251020000000025-R&DProjects/ProjectCreationfromAutomation_VIEW4" element={<ProjectCreationfromAutomation_VIEW4 />} />
        <Route path="/PRJ20251020000000025-R&DProjects/FundConfigurations_Start" element={<FundConfigurations_Start />} />
        <Route path="/PRJ20251020000000025-R&DProjects/ProjectCreationfromAutomation_VIEW3" element={<ProjectCreationfromAutomation_VIEW3 />} />
        <Route path="/PRJ20251020000000025-R&DProjects/ProjectFundInstallment_HOD" element={<ProjectFundInstallment_HOD />} />
        <Route path="/PRJ20251020000000025-R&DProjects/TempAdvance_DeanRD" element={<TempAdvance_DeanRD />} />
        <Route path="/PRJ20251020000000025-R&DProjects/ProjectReimbursement_PIInitiation" element={<ProjectReimbursement_PIInitiation />} />
        <Route path="/PRJ20251020000000025-R&DProjects/CommitmentSpentDetails_Start" element={<CommitmentSpentDetails_Start />} />
        <Route path="/PRJ20251020000000025-R&DProjects/ProjectFundInstallment_RDOffice" element={<ProjectFundInstallment_RDOffice />} />
        <Route path="/PRJ20251020000000025-R&DProjects/ProjectFundInstallment_PIInitiation" element={<ProjectFundInstallment_PIInitiation />} />
        <Route path="/PRJ20251020000000025-R&DProjects/ProjectReimbursement_AdditionalDetails" element={<ProjectReimbursement_AdditionalDetails />} />
        <Route path="/PRJ20251020000000025-R&DProjects/ProjectReimbursement_DeanRD" element={<ProjectReimbursement_DeanRD />} />
        <Route path="/PRJ20251020000000025-R&DProjects/TempAdvance_ARRD" element={<TempAdvance_ARRD />} />
        <Route path="/PRJ20251020000000025-R&DProjects/ProjectReimbursement_ARRD" element={<ProjectReimbursement_ARRD />} />
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