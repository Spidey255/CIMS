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

const ProjectReimbursement_RDoffice = React.lazy(() =>
    import("@/pages/PRJ20251020000000025-R&DProjects/ProjectReimbursement_RDoffice")
  );
const TravelRequest_Registrar = React.lazy(() =>
    import("@/pages/PRJ20251020000000025-R&DProjects/TravelRequest_Registrar")
  );
const ProjectFundInstallment_AdditionalDetails = React.lazy(() =>
    import("@/pages/PRJ20251020000000025-R&DProjects/ProjectFundInstallment_AdditionalDetails")
  );
const ProjectCreation_AdditionalDetails = React.lazy(() =>
    import("@/pages/PRJ20251020000000025-R&DProjects/ProjectCreation_AdditionalDetails")
  );
const ProjectsExplorer_Start = React.lazy(() =>
    import("@/pages/PRJ20251020000000025-R&DProjects/ProjectsExplorer_Start")
  );
const TravelRequest_ARRD = React.lazy(() =>
    import("@/pages/PRJ20251020000000025-R&DProjects/TravelRequest_ARRD")
  );
const TempAdvance_RDoffice = React.lazy(() =>
    import("@/pages/PRJ20251020000000025-R&DProjects/TempAdvance_RDoffice")
  );
const ProjectReimbursement_Registrar = React.lazy(() =>
    import("@/pages/PRJ20251020000000025-R&DProjects/ProjectReimbursement_Registrar")
  );
const TempAdvance_PIInitiation = React.lazy(() =>
    import("@/pages/PRJ20251020000000025-R&DProjects/TempAdvance_PIInitiation")
  );
const ProjectProposal_Start = React.lazy(() =>
    import("@/pages/PRJ20251020000000025-R&DProjects/ProjectProposal_Start")
  );
const TravelSettlement_PIInitiation = React.lazy(() =>
    import("@/pages/PRJ20251020000000025-R&DProjects/TravelSettlement_PIInitiation")
  );
const ProjectCreation_Initiation = React.lazy(() =>
    import("@/pages/PRJ20251020000000025-R&DProjects/ProjectCreation_Initiation")
  );
const TempAdvance_RDofficepayment = React.lazy(() =>
    import("@/pages/PRJ20251020000000025-R&DProjects/TempAdvance_RDofficepayment")
  );
const ProjectCreation_HOD = React.lazy(() =>
    import("@/pages/PRJ20251020000000025-R&DProjects/ProjectCreation_HOD")
  );
const TempAdvance_AdditionalDetails = React.lazy(() =>
    import("@/pages/PRJ20251020000000025-R&DProjects/TempAdvance_AdditionalDetails")
  );
const TravelRequest_PIInitiation = React.lazy(() =>
    import("@/pages/PRJ20251020000000025-R&DProjects/TravelRequest_PIInitiation")
  );
const TempAdvance_Registrar = React.lazy(() =>
    import("@/pages/PRJ20251020000000025-R&DProjects/TempAdvance_Registrar")
  );
const TravelRequest_RDOfficeverification = React.lazy(() =>
    import("@/pages/PRJ20251020000000025-R&DProjects/TravelRequest_RDOfficeverification")
  );
const Reimbursement_Start = React.lazy(() =>
    import("@/pages/PRJ20251020000000025-R&DProjects/Reimbursement_Start")
  );
const TravelSettlement_RDOfficeverification = React.lazy(() =>
    import("@/pages/PRJ20251020000000025-R&DProjects/TravelSettlement_RDOfficeverification")
  );
const TravelSettlement_ARRD = React.lazy(() =>
    import("@/pages/PRJ20251020000000025-R&DProjects/TravelSettlement_ARRD")
  );
const ProjectProposal_ReadOnly = React.lazy(() =>
    import("@/pages/PRJ20251020000000025-R&DProjects/ProjectProposal_ReadOnly")
  );
const ProjectCreation_View = React.lazy(() =>
    import("@/pages/PRJ20251020000000025-R&DProjects/ProjectCreation_View")
  );
const FundConfigurations_Start = React.lazy(() =>
    import("@/pages/PRJ20251020000000025-R&DProjects/FundConfigurations_Start")
  );
const ProjectCreation_RANDDOFFICE = React.lazy(() =>
    import("@/pages/PRJ20251020000000025-R&DProjects/ProjectCreation_RANDDOFFICE")
  );
const ProjectFundInstallment_HOD = React.lazy(() =>
    import("@/pages/PRJ20251020000000025-R&DProjects/ProjectFundInstallment_HOD")
  );
const TempAdvance_DeanRD = React.lazy(() =>
    import("@/pages/PRJ20251020000000025-R&DProjects/TempAdvance_DeanRD")
  );
const ProjectReimbursement_PIInitiation = React.lazy(() =>
    import("@/pages/PRJ20251020000000025-R&DProjects/ProjectReimbursement_PIInitiation")
  );
const CommitmentSpentDetails_Start = React.lazy(() =>
    import("@/pages/PRJ20251020000000025-R&DProjects/CommitmentSpentDetails_Start")
  );
const ProjectProposal_View = React.lazy(() =>
    import("@/pages/PRJ20251020000000025-R&DProjects/ProjectProposal_View")
  );
const TravelRequest_RDOfficePayments = React.lazy(() =>
    import("@/pages/PRJ20251020000000025-R&DProjects/TravelRequest_RDOfficePayments")
  );
const TravelRequest_AdditionalDetails = React.lazy(() =>
    import("@/pages/PRJ20251020000000025-R&DProjects/TravelRequest_AdditionalDetails")
  );
const ProjectFundInstallment_RDOffice = React.lazy(() =>
    import("@/pages/PRJ20251020000000025-R&DProjects/ProjectFundInstallment_RDOffice")
  );
const ProjectProposal_Additional = React.lazy(() =>
    import("@/pages/PRJ20251020000000025-R&DProjects/ProjectProposal_Additional")
  );
const TaskSummaryWithFilters_Start = React.lazy(() =>
    import("@/pages/PRJ20251020000000025-R&DProjects/TaskSummaryWithFilters_Start")
  );
const TravelRequest_RDDean = React.lazy(() =>
    import("@/pages/PRJ20251020000000025-R&DProjects/TravelRequest_RDDean")
  );
const ProjectFundInstallment_PIInitiation = React.lazy(() =>
    import("@/pages/PRJ20251020000000025-R&DProjects/ProjectFundInstallment_PIInitiation")
  );
const ProjectReimbursement_AdditionalDetails = React.lazy(() =>
    import("@/pages/PRJ20251020000000025-R&DProjects/ProjectReimbursement_AdditionalDetails")
  );
const ProjectReimbursement_DeanRD = React.lazy(() =>
    import("@/pages/PRJ20251020000000025-R&DProjects/ProjectReimbursement_DeanRD")
  );
const TempAdvance_ARRD = React.lazy(() =>
    import("@/pages/PRJ20251020000000025-R&DProjects/TempAdvance_ARRD")
  );
const ProjectReimbursement_ARRD = React.lazy(() =>
    import("@/pages/PRJ20251020000000025-R&DProjects/ProjectReimbursement_ARRD")
  );


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

/* 🔥 NEW: Dynamic Layout ONLY for public pages */


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

          {/* ✅ PROTECTED ROUTES (UNCHANGED) */}
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
              <Route path="/PRJ20251020000000025-R&DProjects/Reimbursement_Start" element={<Reimbursement_Start />} />
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

          {/* ✅ AUTH ROUTES (UNCHANGED) */}
          <Route element={<PublicRoute />}>
            <Route path="/login" element={<LoginPage />} />
            
          </Route>

          {/* 🔥 PUBLIC PAGES WITH DYNAMIC SIDEBAR */}
            

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