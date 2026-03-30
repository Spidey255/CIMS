// Innovace Intech Solution Pvt Ltd
import { useMemo } from "react";
import { useSidebar } from "./SidebarContext";
import Sidebar from "./Sidebar";
// import Navbar from "../NavBar/Navbar";
import { Outlet, useSearchParams } from "react-router-dom";


const MainLayout = () => {
  const { collapsed } = useSidebar();
  const [searchParams] = useSearchParams();

  // ✅ URL → object
  const storeQueryParams = useMemo<Record<string, string>>(() => {
    const obj: Record<string, string> = {};

    for (const [key, value] of searchParams.entries()) {
      obj[key] = value;
    }

    return obj;
  }, [searchParams]);

 

  return (
    <>
      {(storeQueryParams?.isSideBar == "false") ? <div className="content-wrapper">
        <Outlet />
      </div> : <> <Sidebar />
        <div className="content-wrapper" style={{
          marginLeft: collapsed ? "80px" : "260px",
          transition: "all .35s ease"
        }}>
          <Outlet />
        </div></>}

      {/* <div className="content-wrapper">
        <Navbar />
        <Outlet />
      </div> */}

    </>
  );
};

export default MainLayout;
