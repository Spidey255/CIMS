import React, { useEffect, useState } from "react";
import { BrowserRouter as Router, Routes, Route, Navigate, Outlet, useLocation } from "react-router-dom";
import { Toaster } from "react-hot-toast";
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


import ProjectReimbursement_R&Doffice from "@/pages/PRJ20251020000000025-RandC/PRJ20251020000000025-Projects/ProjectReimbursement_R&Doffice";
import ProjectReimbursement_ViewActivity from "@/pages/PRJ20251020000000025-RandC/PRJ20251020000000025-Projects/ProjectReimbursement_ViewActivity";
import TravelRequest_Registrar from "@/pages/PRJ20251020000000025-RandC/PRJ20251020000000025-Projects/TravelRequest_Registrar";
import ProjectFundInstallment_AdditionalDetails from "@/pages/PRJ20251020000000025-RandC/PRJ20251020000000025-Projects/ProjectFundInstallment_AdditionalDetails";
import TravelRequest_ARR&D from "@/pages/PRJ20251020000000025-RandC/PRJ20251020000000025-Projects/TravelRequest_ARR&D";
import TempAdvance_R&Doffice from "@/pages/PRJ20251020000000025-RandC/PRJ20251020000000025-Projects/TempAdvance_R&Doffice";
import ProjectReimbursement_Registrar from "@/pages/PRJ20251020000000025-RandC/PRJ20251020000000025-Projects/ProjectReimbursement_Registrar";
import TempAdvance_PIInitiation from "@/pages/PRJ20251020000000025-RandC/PRJ20251020000000025-Projects/TempAdvance_PIInitiation";
import TravelSettlement_AdditionalDetails from "@/pages/PRJ20251020000000025-RandC/PRJ20251020000000025-Projects/TravelSettlement_AdditionalDetails";
import TravelSettlement_PIInitiation from "@/pages/PRJ20251020000000025-RandC/PRJ20251020000000025-Projects/TravelSettlement_PIInitiation";
import TempAdvance_View0 from "@/pages/PRJ20251020000000025-RandC/PRJ20251020000000025-Projects/TempAdvance_View0";
import TempAdvance_R&Dofficepayment from "@/pages/PRJ20251020000000025-RandC/PRJ20251020000000025-Projects/TempAdvance_R&Dofficepayment";
import TempAdvance_AdditionalDetails from "@/pages/PRJ20251020000000025-RandC/PRJ20251020000000025-Projects/TempAdvance_AdditionalDetails";
import ProjectFundInstallment_View0 from "@/pages/PRJ20251020000000025-RandC/PRJ20251020000000025-Projects/ProjectFundInstallment_View0";
import TravelSettlement_R&DOfficePayments from "@/pages/PRJ20251020000000025-RandC/PRJ20251020000000025-Projects/TravelSettlement_R&DOfficePayments";
import TravelRequest_PIInitiation from "@/pages/PRJ20251020000000025-RandC/PRJ20251020000000025-Projects/TravelRequest_PIInitiation";
import TravelRequest_R&DOfficeverification from "@/pages/PRJ20251020000000025-RandC/PRJ20251020000000025-Projects/TravelRequest_R&DOfficeverification";
import TravelSettlement_R&DOfficeverification from "@/pages/PRJ20251020000000025-RandC/PRJ20251020000000025-Projects/TravelSettlement_R&DOfficeverification";
import TravelSettlement_ARR&D from "@/pages/PRJ20251020000000025-RandC/PRJ20251020000000025-Projects/TravelSettlement_ARR&D";
import TempAdvance_ARR&D from "@/pages/PRJ20251020000000025-RandC/PRJ20251020000000025-Projects/TempAdvance_ARR&D";
import ProjectReimbursement_ARR&D from "@/pages/PRJ20251020000000025-RandC/PRJ20251020000000025-Projects/ProjectReimbursement_ARR&D";
import FundConfigurations_Start from "@/pages/PRJ20251020000000025-RandC/PRJ20251020000000025-Projects/FundConfigurations_Start";
import ProjectFundInstallment_HOD from "@/pages/PRJ20251020000000025-RandC/PRJ20251020000000025-Projects/ProjectFundInstallment_HOD";
import TempAdvance_DeanR&D from "@/pages/PRJ20251020000000025-RandC/PRJ20251020000000025-Projects/TempAdvance_DeanR&D";
import ProjectReimbursement_PIInitiation from "@/pages/PRJ20251020000000025-RandC/PRJ20251020000000025-Projects/ProjectReimbursement_PIInitiation";
import CommitmentSpentDetails_Start from "@/pages/PRJ20251020000000025-RandC/PRJ20251020000000025-Projects/CommitmentSpentDetails_Start";
import TravelSettlement_R&DDean from "@/pages/PRJ20251020000000025-RandC/PRJ20251020000000025-Projects/TravelSettlement_R&DDean";
import TravelSettlement_Registrar from "@/pages/PRJ20251020000000025-RandC/PRJ20251020000000025-Projects/TravelSettlement_Registrar";
import TravelRequest_R&DOfficePayments from "@/pages/PRJ20251020000000025-RandC/PRJ20251020000000025-Projects/TravelRequest_R&DOfficePayments";
import ProjectReimbursement_DeanR&D from "@/pages/PRJ20251020000000025-RandC/PRJ20251020000000025-Projects/ProjectReimbursement_DeanR&D";
import TravelRequest_AdditionalDetails from "@/pages/PRJ20251020000000025-RandC/PRJ20251020000000025-Projects/TravelRequest_AdditionalDetails";
import ProjectFundInstallment_RDOffice from "@/pages/PRJ20251020000000025-RandC/PRJ20251020000000025-Projects/ProjectFundInstallment_RDOffice";
import TravelSettlement_ViewActivity from "@/pages/PRJ20251020000000025-RandC/PRJ20251020000000025-Projects/TravelSettlement_ViewActivity";
import TempAdvance_Registrar from "@/pages/PRJ20251020000000025-RandC/PRJ20251020000000025-Projects/TempAdvance_Registrar";
import TravelRequest_R&DDean from "@/pages/PRJ20251020000000025-RandC/PRJ20251020000000025-Projects/TravelRequest_R&DDean";
import ProjectFundInstallment_PIInitiation from "@/pages/PRJ20251020000000025-RandC/PRJ20251020000000025-Projects/ProjectFundInstallment_PIInitiation";
import ProjectReimbursement_AdditionalDetails from "@/pages/PRJ20251020000000025-RandC/PRJ20251020000000025-Projects/ProjectReimbursement_AdditionalDetails";
import TravelRequest_ViewActivity from "@/pages/PRJ20251020000000025-RandC/PRJ20251020000000025-Projects/TravelRequest_ViewActivity";

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
        <Route path="/PRJ20251020000000025-RandC/PRJ20251020000000025-Projects/ProjectReimbursement_R&Doffice" element={<ProjectReimbursement_R&Doffice />} />
        <Route path="/PRJ20251020000000025-RandC/PRJ20251020000000025-Projects/ProjectReimbursement_ViewActivity" element={<ProjectReimbursement_ViewActivity />} />
        <Route path="/PRJ20251020000000025-RandC/PRJ20251020000000025-Projects/TravelRequest_Registrar" element={<TravelRequest_Registrar />} />
        <Route path="/PRJ20251020000000025-RandC/PRJ20251020000000025-Projects/ProjectFundInstallment_AdditionalDetails" element={<ProjectFundInstallment_AdditionalDetails />} />
        <Route path="/PRJ20251020000000025-RandC/PRJ20251020000000025-Projects/TravelRequest_ARR&D" element={<TravelRequest_ARR&D />} />
        <Route path="/PRJ20251020000000025-RandC/PRJ20251020000000025-Projects/TempAdvance_R&Doffice" element={<TempAdvance_R&Doffice />} />
        <Route path="/PRJ20251020000000025-RandC/PRJ20251020000000025-Projects/ProjectReimbursement_Registrar" element={<ProjectReimbursement_Registrar />} />
        <Route path="/PRJ20251020000000025-RandC/PRJ20251020000000025-Projects/TempAdvance_PIInitiation" element={<TempAdvance_PIInitiation />} />
        <Route path="/PRJ20251020000000025-RandC/PRJ20251020000000025-Projects/TravelSettlement_AdditionalDetails" element={<TravelSettlement_AdditionalDetails />} />
        <Route path="/PRJ20251020000000025-RandC/PRJ20251020000000025-Projects/TravelSettlement_PIInitiation" element={<TravelSettlement_PIInitiation />} />
        <Route path="/PRJ20251020000000025-RandC/PRJ20251020000000025-Projects/TempAdvance_View0" element={<TempAdvance_View0 />} />
        <Route path="/PRJ20251020000000025-RandC/PRJ20251020000000025-Projects/TempAdvance_R&Dofficepayment" element={<TempAdvance_R&Dofficepayment />} />
        <Route path="/PRJ20251020000000025-RandC/PRJ20251020000000025-Projects/TempAdvance_AdditionalDetails" element={<TempAdvance_AdditionalDetails />} />
        <Route path="/PRJ20251020000000025-RandC/PRJ20251020000000025-Projects/ProjectFundInstallment_View0" element={<ProjectFundInstallment_View0 />} />
        <Route path="/PRJ20251020000000025-RandC/PRJ20251020000000025-Projects/TravelSettlement_R&DOfficePayments" element={<TravelSettlement_R&DOfficePayments />} />
        <Route path="/PRJ20251020000000025-RandC/PRJ20251020000000025-Projects/TravelRequest_PIInitiation" element={<TravelRequest_PIInitiation />} />
        <Route path="/PRJ20251020000000025-RandC/PRJ20251020000000025-Projects/TravelRequest_R&DOfficeverification" element={<TravelRequest_R&DOfficeverification />} />
        <Route path="/PRJ20251020000000025-RandC/PRJ20251020000000025-Projects/TravelSettlement_R&DOfficeverification" element={<TravelSettlement_R&DOfficeverification />} />
        <Route path="/PRJ20251020000000025-RandC/PRJ20251020000000025-Projects/TravelSettlement_ARR&D" element={<TravelSettlement_ARR&D />} />
        <Route path="/PRJ20251020000000025-RandC/PRJ20251020000000025-Projects/TempAdvance_ARR&D" element={<TempAdvance_ARR&D />} />
        <Route path="/PRJ20251020000000025-RandC/PRJ20251020000000025-Projects/ProjectReimbursement_ARR&D" element={<ProjectReimbursement_ARR&D />} />
        <Route path="/PRJ20251020000000025-RandC/PRJ20251020000000025-Projects/FundConfigurations_Start" element={<FundConfigurations_Start />} />
        <Route path="/PRJ20251020000000025-RandC/PRJ20251020000000025-Projects/ProjectFundInstallment_HOD" element={<ProjectFundInstallment_HOD />} />
        <Route path="/PRJ20251020000000025-RandC/PRJ20251020000000025-Projects/TempAdvance_DeanR&D" element={<TempAdvance_DeanR&D />} />
        <Route path="/PRJ20251020000000025-RandC/PRJ20251020000000025-Projects/ProjectReimbursement_PIInitiation" element={<ProjectReimbursement_PIInitiation />} />
        <Route path="/PRJ20251020000000025-RandC/PRJ20251020000000025-Projects/CommitmentSpentDetails_Start" element={<CommitmentSpentDetails_Start />} />
        <Route path="/PRJ20251020000000025-RandC/PRJ20251020000000025-Projects/TravelSettlement_R&DDean" element={<TravelSettlement_R&DDean />} />
        <Route path="/PRJ20251020000000025-RandC/PRJ20251020000000025-Projects/TravelSettlement_Registrar" element={<TravelSettlement_Registrar />} />
        <Route path="/PRJ20251020000000025-RandC/PRJ20251020000000025-Projects/TravelRequest_R&DOfficePayments" element={<TravelRequest_R&DOfficePayments />} />
        <Route path="/PRJ20251020000000025-RandC/PRJ20251020000000025-Projects/ProjectReimbursement_DeanR&D" element={<ProjectReimbursement_DeanR&D />} />
        <Route path="/PRJ20251020000000025-RandC/PRJ20251020000000025-Projects/TravelRequest_AdditionalDetails" element={<TravelRequest_AdditionalDetails />} />
        <Route path="/PRJ20251020000000025-RandC/PRJ20251020000000025-Projects/ProjectFundInstallment_RDOffice" element={<ProjectFundInstallment_RDOffice />} />
        <Route path="/PRJ20251020000000025-RandC/PRJ20251020000000025-Projects/TravelSettlement_ViewActivity" element={<TravelSettlement_ViewActivity />} />
        <Route path="/PRJ20251020000000025-RandC/PRJ20251020000000025-Projects/TempAdvance_Registrar" element={<TempAdvance_Registrar />} />
        <Route path="/PRJ20251020000000025-RandC/PRJ20251020000000025-Projects/TravelRequest_R&DDean" element={<TravelRequest_R&DDean />} />
        <Route path="/PRJ20251020000000025-RandC/PRJ20251020000000025-Projects/ProjectFundInstallment_PIInitiation" element={<ProjectFundInstallment_PIInitiation />} />
        <Route path="/PRJ20251020000000025-RandC/PRJ20251020000000025-Projects/ProjectReimbursement_AdditionalDetails" element={<ProjectReimbursement_AdditionalDetails />} />
        <Route path="/PRJ20251020000000025-RandC/PRJ20251020000000025-Projects/TravelRequest_ViewActivity" element={<TravelRequest_ViewActivity />} />
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
      <SessionTimeoutModal
        isOpen={sessionExpired}
        onConfirm={handleLogout}
      />
    </>
  );
};

export default App;