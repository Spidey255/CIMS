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

const TravelRequestNew_View = React.lazy(() =>
    import("@/pages/PRJ20251020000000025-R&DProjects/TravelRequestNew_View")
  );
const TravelRequestNew_Start = React.lazy(() =>
    import("@/pages/PRJ20251020000000025-R&DProjects/TravelRequestNew_Start")
  );
const TravelRequestNew_DeanRandD = React.lazy(() =>
    import("@/pages/PRJ20251020000000025-R&DProjects/TravelRequestNew_DeanRandD")
  );
const TravelRequestNew_ARRandD = React.lazy(() =>
    import("@/pages/PRJ20251020000000025-R&DProjects/TravelRequestNew_ARRandD")
  );
const TravelRequestNew_AdditionaDetails = React.lazy(() =>
    import("@/pages/PRJ20251020000000025-R&DProjects/TravelRequestNew_AdditionaDetails")
  );
const TravelRequestNew_RDOfficePayment = React.lazy(() =>
    import("@/pages/PRJ20251020000000025-R&DProjects/TravelRequestNew_RDOfficePayment")
  );
const TravelRequestNew_RandDOffice = React.lazy(() =>
    import("@/pages/PRJ20251020000000025-R&DProjects/TravelRequestNew_RandDOffice")
  );
const TravelRequestNew_Registrar = React.lazy(() =>
    import("@/pages/PRJ20251020000000025-R&DProjects/TravelRequestNew_Registrar")
  );
const TravelRequestNew_AdvanceNo = React.lazy(() =>
    import("@/pages/PRJ20251020000000025-R&DProjects/TravelRequestNew_AdvanceNo")
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
              <Route path="/PRJ20251020000000025-R&DProjects/TravelRequestNew_View" element={<TravelRequestNew_View />} />
              <Route path="/PRJ20251020000000025-R&DProjects/TravelRequestNew_Start" element={<TravelRequestNew_Start />} />
              <Route path="/PRJ20251020000000025-R&DProjects/TravelRequestNew_DeanRandD" element={<TravelRequestNew_DeanRandD />} />
              <Route path="/PRJ20251020000000025-R&DProjects/TravelRequestNew_ARRandD" element={<TravelRequestNew_ARRandD />} />
              <Route path="/PRJ20251020000000025-R&DProjects/TravelRequestNew_AdditionaDetails" element={<TravelRequestNew_AdditionaDetails />} />
              <Route path="/PRJ20251020000000025-R&DProjects/TravelRequestNew_RDOfficePayment" element={<TravelRequestNew_RDOfficePayment />} />
              <Route path="/PRJ20251020000000025-R&DProjects/TravelRequestNew_RandDOffice" element={<TravelRequestNew_RandDOffice />} />
              <Route path="/PRJ20251020000000025-R&DProjects/TravelRequestNew_Registrar" element={<TravelRequestNew_Registrar />} />
              <Route path="/PRJ20251020000000025-R&DProjects/TravelRequestNew_AdvanceNo" element={<TravelRequestNew_AdvanceNo />} />
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