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

const TravelSettlementNew_DeanRandD = React.lazy(() =>
    import("@/pages/PRJ20251020000000025-R&DProjects/TravelSettlementNew_DeanRandD")
  );
const TravelRequestNew_View = React.lazy(() =>
    import("@/pages/PRJ20251020000000025-R&DProjects/TravelRequestNew_View")
  );
const ReimbursementExplorer_Start = React.lazy(() =>
    import("@/pages/PRJ20251020000000025-R&DProjects/ReimbursementExplorer_Start")
  );
const TravelRequestNew_Start = React.lazy(() =>
    import("@/pages/PRJ20251020000000025-R&DProjects/TravelRequestNew_Start")
  );
const ProjectReimbursementNew_DeanRandD = React.lazy(() =>
    import("@/pages/PRJ20251020000000025-R&DProjects/ProjectReimbursementNew_DeanRandD")
  );
const ProjectFundInstallment_AdditionalDetails = React.lazy(() =>
    import("@/pages/PRJ20251020000000025-R&DProjects/ProjectFundInstallment_AdditionalDetails")
  );
const ProjectCreation_AdditionalDetails = React.lazy(() =>
    import("@/pages/PRJ20251020000000025-R&DProjects/ProjectCreation_AdditionalDetails")
  );
const TravelRequestNew_DeanRandD = React.lazy(() =>
    import("@/pages/PRJ20251020000000025-R&DProjects/TravelRequestNew_DeanRandD")
  );
const ProjectsExplorer_Start = React.lazy(() =>
    import("@/pages/PRJ20251020000000025-R&DProjects/ProjectsExplorer_Start")
  );
const TemporaryAdvanceNew_View = React.lazy(() =>
    import("@/pages/PRJ20251020000000025-R&DProjects/TemporaryAdvanceNew_View")
  );
const TravelRequestNew_ARRandD = React.lazy(() =>
    import("@/pages/PRJ20251020000000025-R&DProjects/TravelRequestNew_ARRandD")
  );
const TravelSettlementNew_Start = React.lazy(() =>
    import("@/pages/PRJ20251020000000025-R&DProjects/TravelSettlementNew_Start")
  );
const ProjectFundInstallment_View = React.lazy(() =>
    import("@/pages/PRJ20251020000000025-R&DProjects/ProjectFundInstallment_View")
  );
const TemporaryAdvanceNew_ARRandD = React.lazy(() =>
    import("@/pages/PRJ20251020000000025-R&DProjects/TemporaryAdvanceNew_ARRandD")
  );
const ProjectReimbursementNew_ARRandD = React.lazy(() =>
    import("@/pages/PRJ20251020000000025-R&DProjects/ProjectReimbursementNew_ARRandD")
  );
const ProjectReimbursementNew_AdditionalDetails = React.lazy(() =>
    import("@/pages/PRJ20251020000000025-R&DProjects/ProjectReimbursementNew_AdditionalDetails")
  );
const TravelSettlementNew_Registrar = React.lazy(() =>
    import("@/pages/PRJ20251020000000025-R&DProjects/TravelSettlementNew_Registrar")
  );
const ProjectProposal_Start = React.lazy(() =>
    import("@/pages/PRJ20251020000000025-R&DProjects/ProjectProposal_Start")
  );
const TemporaryAdvanceNew_DeanRandD = React.lazy(() =>
    import("@/pages/PRJ20251020000000025-R&DProjects/TemporaryAdvanceNew_DeanRandD")
  );
const ProjectFundExplorer_Start = React.lazy(() =>
    import("@/pages/PRJ20251020000000025-R&DProjects/ProjectFundExplorer_Start")
  );
const TravelSettlementNew_AdiditionalDetails = React.lazy(() =>
    import("@/pages/PRJ20251020000000025-R&DProjects/TravelSettlementNew_AdiditionalDetails")
  );
const ProjectCreation_Initiation = React.lazy(() =>
    import("@/pages/PRJ20251020000000025-R&DProjects/ProjectCreation_Initiation")
  );
const ProjectCreation_HOD = React.lazy(() =>
    import("@/pages/PRJ20251020000000025-R&DProjects/ProjectCreation_HOD")
  );
const TemporaryAdvanceNew_AdditionalDetails = React.lazy(() =>
    import("@/pages/PRJ20251020000000025-R&DProjects/TemporaryAdvanceNew_AdditionalDetails")
  );
const ProjectReimbursementNew_Start = React.lazy(() =>
    import("@/pages/PRJ20251020000000025-R&DProjects/ProjectReimbursementNew_Start")
  );
const ProjectProposal_ReadOnly = React.lazy(() =>
    import("@/pages/PRJ20251020000000025-R&DProjects/ProjectProposal_ReadOnly")
  );
const ProjectReimbursementNew_Registrar = React.lazy(() =>
    import("@/pages/PRJ20251020000000025-R&DProjects/ProjectReimbursementNew_Registrar")
  );
const ProjectCreation_View = React.lazy(() =>
    import("@/pages/PRJ20251020000000025-R&DProjects/ProjectCreation_View")
  );
const FundConfigurations_Start = React.lazy(() =>
    import("@/pages/PRJ20251020000000025-R&DProjects/FundConfigurations_Start")
  );
const TravelSettlementNew_RandDOffice = React.lazy(() =>
    import("@/pages/PRJ20251020000000025-R&DProjects/TravelSettlementNew_RandDOffice")
  );
const ProjectCreation_RANDDOFFICE = React.lazy(() =>
    import("@/pages/PRJ20251020000000025-R&DProjects/ProjectCreation_RANDDOFFICE")
  );
const TemporaryAdvanceNew_RandDOffice = React.lazy(() =>
    import("@/pages/PRJ20251020000000025-R&DProjects/TemporaryAdvanceNew_RandDOffice")
  );
const ProjectFundInstallment_HOD = React.lazy(() =>
    import("@/pages/PRJ20251020000000025-R&DProjects/ProjectFundInstallment_HOD")
  );
const TravelRequestNew_AdditionaDetails = React.lazy(() =>
    import("@/pages/PRJ20251020000000025-R&DProjects/TravelRequestNew_AdditionaDetails")
  );
const TemporaryAdvanceNew_Registrar = React.lazy(() =>
    import("@/pages/PRJ20251020000000025-R&DProjects/TemporaryAdvanceNew_Registrar")
  );
const TravelRequestNew_RDOfficePayment = React.lazy(() =>
    import("@/pages/PRJ20251020000000025-R&DProjects/TravelRequestNew_RDOfficePayment")
  );
const CommitmentSpentDetails_Start = React.lazy(() =>
    import("@/pages/PRJ20251020000000025-R&DProjects/CommitmentSpentDetails_Start")
  );
const ProjectProposal_View = React.lazy(() =>
    import("@/pages/PRJ20251020000000025-R&DProjects/ProjectProposal_View")
  );
const TemporaryAdvanceNew_Start = React.lazy(() =>
    import("@/pages/PRJ20251020000000025-R&DProjects/TemporaryAdvanceNew_Start")
  );
const ProjectReimbursementNew_View = React.lazy(() =>
    import("@/pages/PRJ20251020000000025-R&DProjects/ProjectReimbursementNew_View")
  );
const TravelRequestNew_RandDOffice = React.lazy(() =>
    import("@/pages/PRJ20251020000000025-R&DProjects/TravelRequestNew_RandDOffice")
  );
const TravelSettlementNew_ARRandD = React.lazy(() =>
    import("@/pages/PRJ20251020000000025-R&DProjects/TravelSettlementNew_ARRandD")
  );
const ProjectFundInstallment_RDOffice = React.lazy(() =>
    import("@/pages/PRJ20251020000000025-R&DProjects/ProjectFundInstallment_RDOffice")
  );
const ProjectProposal_Additional = React.lazy(() =>
    import("@/pages/PRJ20251020000000025-R&DProjects/ProjectProposal_Additional")
  );
const TravelRequestNew_Registrar = React.lazy(() =>
    import("@/pages/PRJ20251020000000025-R&DProjects/TravelRequestNew_Registrar")
  );
const ProjectFundInstallment_PIInitiation = React.lazy(() =>
    import("@/pages/PRJ20251020000000025-R&DProjects/ProjectFundInstallment_PIInitiation")
  );
const TempAdvanceExplorer_Start = React.lazy(() =>
    import("@/pages/PRJ20251020000000025-R&DProjects/PRJ20251020000000025-ProjectScreensNew/TempAdvanceExplorer_Start")
  );
const TemporaryAdvanceNew_RDOfficePayment = React.lazy(() =>
    import("@/pages/PRJ20251020000000025-R&DProjects/TemporaryAdvanceNew_RDOfficePayment")
  );
const TravelSettlementNew_RDOfficePayment = React.lazy(() =>
    import("@/pages/PRJ20251020000000025-R&DProjects/TravelSettlementNew_RDOfficePayment")
  );
const ProjectReimbursementNew_RandDOffice = React.lazy(() =>
    import("@/pages/PRJ20251020000000025-R&DProjects/ProjectReimbursementNew_RandDOffice")
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
              <Route path="/PRJ20251020000000025-R&DProjects/TravelSettlementNew_DeanRandD" element={<TravelSettlementNew_DeanRandD />} />
              <Route path="/PRJ20251020000000025-R&DProjects/TravelRequestNew_View" element={<TravelRequestNew_View />} />
              <Route path="/PRJ20251020000000025-R&DProjects/ReimbursementExplorer_Start" element={<ReimbursementExplorer_Start />} />
              <Route path="/PRJ20251020000000025-R&DProjects/TravelRequestNew_Start" element={<TravelRequestNew_Start />} />
              <Route path="/PRJ20251020000000025-R&DProjects/ProjectReimbursementNew_DeanRandD" element={<ProjectReimbursementNew_DeanRandD />} />
              <Route path="/PRJ20251020000000025-R&DProjects/ProjectFundInstallment_AdditionalDetails" element={<ProjectFundInstallment_AdditionalDetails />} />
              <Route path="/PRJ20251020000000025-R&DProjects/ProjectCreation_AdditionalDetails" element={<ProjectCreation_AdditionalDetails />} />
              <Route path="/PRJ20251020000000025-R&DProjects/TravelRequestNew_DeanRandD" element={<TravelRequestNew_DeanRandD />} />
              <Route path="/PRJ20251020000000025-R&DProjects/ProjectsExplorer_Start" element={<ProjectsExplorer_Start />} />
              <Route path="/PRJ20251020000000025-R&DProjects/TemporaryAdvanceNew_View" element={<TemporaryAdvanceNew_View />} />
              <Route path="/PRJ20251020000000025-R&DProjects/TravelRequestNew_ARRandD" element={<TravelRequestNew_ARRandD />} />
              <Route path="/PRJ20251020000000025-R&DProjects/TravelSettlementNew_Start" element={<TravelSettlementNew_Start />} />
              <Route path="/PRJ20251020000000025-R&DProjects/ProjectFundInstallment_View" element={<ProjectFundInstallment_View />} />
              <Route path="/PRJ20251020000000025-R&DProjects/TemporaryAdvanceNew_ARRandD" element={<TemporaryAdvanceNew_ARRandD />} />
              <Route path="/PRJ20251020000000025-R&DProjects/ProjectReimbursementNew_ARRandD" element={<ProjectReimbursementNew_ARRandD />} />
              <Route path="/PRJ20251020000000025-R&DProjects/ProjectReimbursementNew_AdditionalDetails" element={<ProjectReimbursementNew_AdditionalDetails />} />
              <Route path="/PRJ20251020000000025-R&DProjects/TravelSettlementNew_Registrar" element={<TravelSettlementNew_Registrar />} />
              <Route path="/PRJ20251020000000025-R&DProjects/ProjectProposal_Start" element={<ProjectProposal_Start />} />
              <Route path="/PRJ20251020000000025-R&DProjects/TemporaryAdvanceNew_DeanRandD" element={<TemporaryAdvanceNew_DeanRandD />} />
              <Route path="/PRJ20251020000000025-R&DProjects/ProjectFundExplorer_Start" element={<ProjectFundExplorer_Start />} />
              <Route path="/PRJ20251020000000025-R&DProjects/TravelSettlementNew_AdiditionalDetails" element={<TravelSettlementNew_AdiditionalDetails />} />
              <Route path="/PRJ20251020000000025-R&DProjects/ProjectCreation_Initiation" element={<ProjectCreation_Initiation />} />
              <Route path="/PRJ20251020000000025-R&DProjects/ProjectCreation_HOD" element={<ProjectCreation_HOD />} />
              <Route path="/PRJ20251020000000025-R&DProjects/TemporaryAdvanceNew_AdditionalDetails" element={<TemporaryAdvanceNew_AdditionalDetails />} />
              <Route path="/PRJ20251020000000025-R&DProjects/ProjectReimbursementNew_Start" element={<ProjectReimbursementNew_Start />} />
              <Route path="/PRJ20251020000000025-R&DProjects/ProjectProposal_ReadOnly" element={<ProjectProposal_ReadOnly />} />
              <Route path="/PRJ20251020000000025-R&DProjects/ProjectReimbursementNew_Registrar" element={<ProjectReimbursementNew_Registrar />} />
              <Route path="/PRJ20251020000000025-R&DProjects/ProjectCreation_View" element={<ProjectCreation_View />} />
              <Route path="/PRJ20251020000000025-R&DProjects/FundConfigurations_Start" element={<FundConfigurations_Start />} />
              <Route path="/PRJ20251020000000025-R&DProjects/TravelSettlementNew_RandDOffice" element={<TravelSettlementNew_RandDOffice />} />
              <Route path="/PRJ20251020000000025-R&DProjects/ProjectCreation_RANDDOFFICE" element={<ProjectCreation_RANDDOFFICE />} />
              <Route path="/PRJ20251020000000025-R&DProjects/TemporaryAdvanceNew_RandDOffice" element={<TemporaryAdvanceNew_RandDOffice />} />
              <Route path="/PRJ20251020000000025-R&DProjects/ProjectFundInstallment_HOD" element={<ProjectFundInstallment_HOD />} />
              <Route path="/PRJ20251020000000025-R&DProjects/TravelRequestNew_AdditionaDetails" element={<TravelRequestNew_AdditionaDetails />} />
              <Route path="/PRJ20251020000000025-R&DProjects/TemporaryAdvanceNew_Registrar" element={<TemporaryAdvanceNew_Registrar />} />
              <Route path="/PRJ20251020000000025-R&DProjects/TravelRequestNew_RDOfficePayment" element={<TravelRequestNew_RDOfficePayment />} />
              <Route path="/PRJ20251020000000025-R&DProjects/CommitmentSpentDetails_Start" element={<CommitmentSpentDetails_Start />} />
              <Route path="/PRJ20251020000000025-R&DProjects/ProjectProposal_View" element={<ProjectProposal_View />} />
              <Route path="/PRJ20251020000000025-R&DProjects/TemporaryAdvanceNew_Start" element={<TemporaryAdvanceNew_Start />} />
              <Route path="/PRJ20251020000000025-R&DProjects/ProjectReimbursementNew_View" element={<ProjectReimbursementNew_View />} />
              <Route path="/PRJ20251020000000025-R&DProjects/TravelRequestNew_RandDOffice" element={<TravelRequestNew_RandDOffice />} />
              <Route path="/PRJ20251020000000025-R&DProjects/TravelSettlementNew_ARRandD" element={<TravelSettlementNew_ARRandD />} />
              <Route path="/PRJ20251020000000025-R&DProjects/ProjectFundInstallment_RDOffice" element={<ProjectFundInstallment_RDOffice />} />
              <Route path="/PRJ20251020000000025-R&DProjects/ProjectProposal_Additional" element={<ProjectProposal_Additional />} />
              <Route path="/PRJ20251020000000025-R&DProjects/TravelRequestNew_Registrar" element={<TravelRequestNew_Registrar />} />
              <Route path="/PRJ20251020000000025-R&DProjects/ProjectFundInstallment_PIInitiation" element={<ProjectFundInstallment_PIInitiation />} />
              <Route path="/PRJ20251020000000025-R&DProjects/PRJ20251020000000025-ProjectScreensNew/TempAdvanceExplorer_Start" element={<TempAdvanceExplorer_Start />} />
              <Route path="/PRJ20251020000000025-R&DProjects/TemporaryAdvanceNew_RDOfficePayment" element={<TemporaryAdvanceNew_RDOfficePayment />} />
              <Route path="/PRJ20251020000000025-R&DProjects/TravelSettlementNew_RDOfficePayment" element={<TravelSettlementNew_RDOfficePayment />} />
              <Route path="/PRJ20251020000000025-R&DProjects/ProjectReimbursementNew_RandDOffice" element={<ProjectReimbursementNew_RandDOffice />} />
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