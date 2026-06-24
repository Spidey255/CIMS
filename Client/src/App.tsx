import React, { useEffect, useState } from "react";
import { BrowserRouter as Router, Routes, Route, Navigate, Outlet, useLocation } from "react-router-dom";
import { Toaster } from "react-hot-toast";
import NotFound from "@/pages/NotFound";
import GlobalLoader from "@/components/Loader/GlobalLoader";
import Inbox from "@/components/Inbox/Inbox";
import SessionTimeoutModal from "@/components/Internal/SessionTimeoutModal";

import LoginPage from "@/components/Auth/Default/Login";


import MainLayout from "@/layout/SideBar/MainLayout";
import { SidebarProvider } from "@/layout/SideBar/SidebarContext";

import { useUserStore } from "@/store/useUserStore";

import ProjectReimbursement_RDoffice from "@/pages/PRJ20251020000000025-R&DProjects/ProjectReimbursement_RDoffice";
import TravelRequest_Registrar from "@/pages/PRJ20251020000000025-R&DProjects/TravelRequest_Registrar";
import ProjectFundInstallment_AdditionalDetails from "@/pages/PRJ20251020000000025-R&DProjects/ProjectFundInstallment_AdditionalDetails";
import ProjectCreation_AdditionalDetails from "@/pages/PRJ20251020000000025-R&DProjects/ProjectCreation_AdditionalDetails";
import ProjectsExplorer_Start from "@/pages/PRJ20251020000000025-R&DProjects/ProjectsExplorer_Start";
import TravelRequest_ARRD from "@/pages/PRJ20251020000000025-R&DProjects/TravelRequest_ARRD";
import TempAdvance_RDoffice from "@/pages/PRJ20251020000000025-R&DProjects/TempAdvance_RDoffice";
import ProjectReimbursement_Registrar from "@/pages/PRJ20251020000000025-R&DProjects/ProjectReimbursement_Registrar";
import TempAdvance_PIInitiation from "@/pages/PRJ20251020000000025-R&DProjects/TempAdvance_PIInitiation";
import ProjectProposal_Start from "@/pages/PRJ20251020000000025-R&DProjects/ProjectProposal_Start";
import TravelSettlement_PIInitiation from "@/pages/PRJ20251020000000025-R&DProjects/TravelSettlement_PIInitiation";
import ProjectCreation_Initiation from "@/pages/PRJ20251020000000025-R&DProjects/ProjectCreation_Initiation";
import TempAdvance_RDofficepayment from "@/pages/PRJ20251020000000025-R&DProjects/TempAdvance_RDofficepayment";
import ProjectCreation_HOD from "@/pages/PRJ20251020000000025-R&DProjects/ProjectCreation_HOD";
import TempAdvance_AdditionalDetails from "@/pages/PRJ20251020000000025-R&DProjects/TempAdvance_AdditionalDetails";
import TravelRequest_PIInitiation from "@/pages/PRJ20251020000000025-R&DProjects/TravelRequest_PIInitiation";
import TempAdvance_Registrar from "@/pages/PRJ20251020000000025-R&DProjects/TempAdvance_Registrar";
import TravelRequest_RDOfficeverification from "@/pages/PRJ20251020000000025-R&DProjects/TravelRequest_RDOfficeverification";
import TravelSettlement_RDOfficeverification from "@/pages/PRJ20251020000000025-R&DProjects/TravelSettlement_RDOfficeverification";
import TravelSettlement_ARRD from "@/pages/PRJ20251020000000025-R&DProjects/TravelSettlement_ARRD";
import ProjectProposal_ReadOnly from "@/pages/PRJ20251020000000025-R&DProjects/ProjectProposal_ReadOnly";
import ProjectCreation_View from "@/pages/PRJ20251020000000025-R&DProjects/ProjectCreation_View";
import FundConfigurations_Start from "@/pages/PRJ20251020000000025-R&DProjects/FundConfigurations_Start";
import ProjectCreation_RANDDOFFICE from "@/pages/PRJ20251020000000025-R&DProjects/ProjectCreation_RANDDOFFICE";
import ProjectFundInstallment_HOD from "@/pages/PRJ20251020000000025-R&DProjects/ProjectFundInstallment_HOD";
import TempAdvance_DeanRD from "@/pages/PRJ20251020000000025-R&DProjects/TempAdvance_DeanRD";
import ProjectReimbursement_PIInitiation from "@/pages/PRJ20251020000000025-R&DProjects/ProjectReimbursement_PIInitiation";
import CommitmentSpentDetails_Start from "@/pages/PRJ20251020000000025-R&DProjects/CommitmentSpentDetails_Start";
import ProjectProposal_View from "@/pages/PRJ20251020000000025-R&DProjects/ProjectProposal_View";
import TravelRequest_RDOfficePayments from "@/pages/PRJ20251020000000025-R&DProjects/TravelRequest_RDOfficePayments";
import TravelRequest_AdditionalDetails from "@/pages/PRJ20251020000000025-R&DProjects/TravelRequest_AdditionalDetails";
import ProjectFundInstallment_RDOffice from "@/pages/PRJ20251020000000025-R&DProjects/ProjectFundInstallment_RDOffice";
import ProjectProposal_Additional from "@/pages/PRJ20251020000000025-R&DProjects/ProjectProposal_Additional";
import TaskSummaryWithFilters_Start from "@/pages/PRJ20251020000000025-R&DProjects/TaskSummaryWithFilters_Start";
import TravelRequest_RDDean from "@/pages/PRJ20251020000000025-R&DProjects/TravelRequest_RDDean";
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

/* ?? NEW: Dynamic Layout ONLY for public pages */


const App: React.FC = () => {
  const [sessionExpired, setSessionExpired] = useState(false);

  (window as any).triggerSessionTimeout = () => {
    setSessionExpired(true);
  };

  const handleLogout = () => {
    sessionStorage.clear();
    window.location.href = "/CIMS/login";
  };

  return (
    <>
      <GlobalLoader />
      <Router basename="/CIMS">
        <Routes>

          {/* ? PROTECTED ROUTES (UNCHANGED) */}
          <Route element={<ProtectedRoute />}>
            <Route element={
              <SidebarProvider>
                <MainLayout />
              </SidebarProvider>
            }>
              <Route path="/PRJ20251020000000025-R&DProjects/ProjectReimbursement_RDoffice" element={<ProjectReimbursement_RDoffice />} />
              <Route path="/PRJ20251020000000025-R&DProjects/TravelRequest_Registrar" element={<TravelRequest_Registrar />} />
              <Route path="/PRJ20251020000000025-R&DProjects/ProjectFundInstallment_AdditionalDetails" element={<ProjectFundInstallment_AdditionalDetails />} />
              <Route path="/PRJ20251020000000025-R&DProjects/ProjectCreation_AdditionalDetails" element={<ProjectCreation_AdditionalDetails />} />
              <Route path="/PRJ20251020000000025-R&DProjects/ProjectsExplorer_Start" element={<ProjectsExplorer_Start />} />
              <Route path="/PRJ20251020000000025-R&DProjects/TravelRequest_ARRD" element={<TravelRequest_ARRD />} />
              <Route path="/PRJ20251020000000025-R&DProjects/TempAdvance_RDoffice" element={<TempAdvance_RDoffice />} />
              <Route path="/PRJ20251020000000025-R&DProjects/ProjectReimbursement_Registrar" element={<ProjectReimbursement_Registrar />} />
              <Route path="/PRJ20251020000000025-R&DProjects/TempAdvance_PIInitiation" element={<TempAdvance_PIInitiation />} />
              <Route path="/PRJ20251020000000025-R&DProjects/ProjectProposal_Start" element={<ProjectProposal_Start />} />
              <Route path="/PRJ20251020000000025-R&DProjects/TravelSettlement_PIInitiation" element={<TravelSettlement_PIInitiation />} />
              <Route path="/PRJ20251020000000025-R&DProjects/ProjectCreation_Initiation" element={<ProjectCreation_Initiation />} />
              <Route path="/PRJ20251020000000025-R&DProjects/TempAdvance_RDofficepayment" element={<TempAdvance_RDofficepayment />} />
              <Route path="/PRJ20251020000000025-R&DProjects/ProjectCreation_HOD" element={<ProjectCreation_HOD />} />
              <Route path="/PRJ20251020000000025-R&DProjects/TempAdvance_AdditionalDetails" element={<TempAdvance_AdditionalDetails />} />
              <Route path="/PRJ20251020000000025-R&DProjects/TravelRequest_PIInitiation" element={<TravelRequest_PIInitiation />} />
              <Route path="/PRJ20251020000000025-R&DProjects/TempAdvance_Registrar" element={<TempAdvance_Registrar />} />
              <Route path="/PRJ20251020000000025-R&DProjects/TravelRequest_RDOfficeverification" element={<TravelRequest_RDOfficeverification />} />
              <Route path="/PRJ20251020000000025-R&DProjects/TravelSettlement_RDOfficeverification" element={<TravelSettlement_RDOfficeverification />} />
              <Route path="/PRJ20251020000000025-R&DProjects/TravelSettlement_ARRD" element={<TravelSettlement_ARRD />} />
              <Route path="/PRJ20251020000000025-R&DProjects/ProjectProposal_ReadOnly" element={<ProjectProposal_ReadOnly />} />
              <Route path="/PRJ20251020000000025-R&DProjects/ProjectCreation_View" element={<ProjectCreation_View />} />
              <Route path="/PRJ20251020000000025-R&DProjects/FundConfigurations_Start" element={<FundConfigurations_Start />} />
              <Route path="/PRJ20251020000000025-R&DProjects/ProjectCreation_RANDDOFFICE" element={<ProjectCreation_RANDDOFFICE />} />
              <Route path="/PRJ20251020000000025-R&DProjects/ProjectFundInstallment_HOD" element={<ProjectFundInstallment_HOD />} />
              <Route path="/PRJ20251020000000025-R&DProjects/TempAdvance_DeanRD" element={<TempAdvance_DeanRD />} />
              <Route path="/PRJ20251020000000025-R&DProjects/ProjectReimbursement_PIInitiation" element={<ProjectReimbursement_PIInitiation />} />
              <Route path="/PRJ20251020000000025-R&DProjects/CommitmentSpentDetails_Start" element={<CommitmentSpentDetails_Start />} />
              <Route path="/PRJ20251020000000025-R&DProjects/ProjectProposal_View" element={<ProjectProposal_View />} />
              <Route path="/PRJ20251020000000025-R&DProjects/TravelRequest_RDOfficePayments" element={<TravelRequest_RDOfficePayments />} />
              <Route path="/PRJ20251020000000025-R&DProjects/TravelRequest_AdditionalDetails" element={<TravelRequest_AdditionalDetails />} />
              <Route path="/PRJ20251020000000025-R&DProjects/ProjectFundInstallment_RDOffice" element={<ProjectFundInstallment_RDOffice />} />
              <Route path="/PRJ20251020000000025-R&DProjects/ProjectProposal_Additional" element={<ProjectProposal_Additional />} />
              <Route path="/PRJ20251020000000025-R&DProjects/TaskSummaryWithFilters_Start" element={<TaskSummaryWithFilters_Start />} />
              <Route path="/PRJ20251020000000025-R&DProjects/TravelRequest_RDDean" element={<TravelRequest_RDDean />} />
              <Route path="/PRJ20251020000000025-R&DProjects/ProjectFundInstallment_PIInitiation" element={<ProjectFundInstallment_PIInitiation />} />
              <Route path="/PRJ20251020000000025-R&DProjects/ProjectReimbursement_AdditionalDetails" element={<ProjectReimbursement_AdditionalDetails />} />
              <Route path="/PRJ20251020000000025-R&DProjects/ProjectReimbursement_DeanRD" element={<ProjectReimbursement_DeanRD />} />
              <Route path="/PRJ20251020000000025-R&DProjects/TempAdvance_ARRD" element={<TempAdvance_ARRD />} />
              <Route path="/PRJ20251020000000025-R&DProjects/ProjectReimbursement_ARRD" element={<ProjectReimbursement_ARRD />} />
              <Route path="/Inbox" element={<Inbox />} />
              <Route path="*" element={<NotFound />} />
            </Route>
          </Route>

          {/* ? AUTH ROUTES (UNCHANGED) */}
          <Route element={<PublicRoute />}>
            <Route path="/login" element={<LoginPage />} />
            
          </Route>

          {/* ?? PUBLIC PAGES WITH DYNAMIC SIDEBAR */}
            

          <Route path="*" element={<NotFound />} />
        </Routes>
      </Router>

      <Toaster />
      <SessionTimeoutModal
        isOpen={sessionExpired}
        onConfirm={handleLogout}
      />
    </>
  );
};

export default App;