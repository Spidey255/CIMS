// Innovace Intech Solution Pvt Ltd
import React, { useState, useEffect, useRef } from "react";
import { NavLink, useNavigate } from "react-router-dom";
import { getWorkSpaces, getWorkspaceMenu, clearWorkspaceCache, type Workspace } from "@/helpers/workspaceHelper";
import { useSidebar } from "./SidebarContext";
import { useLoaderStore } from "@/store/useLoaderStore";
import "./sidebar.css";
import Profiler from "../../assets/images/profile.jpg";


/* ✅ MENU TYPE (local to this file only) */
interface MenuItem {
    key?: string;
    label: string;
    icon?: string;
    path?: string | undefined;
    children?: MenuItem[];
}

const Sidebar: React.FC = () => {
    const { collapsed, toggle } = useSidebar();
    const navigate = useNavigate();

    const startLoading = useLoaderStore((s) => s.show);
    const stopLoading = useLoaderStore((s) => s.hide);

    const [workspaces, setWorkspaces] = useState<Workspace[]>([]);
    const [selectedWorkspace, setSelectedWorkspace] =
        useState<string>("Loading...");

    const [selectedWorkspaceId, setSelectedWorkspaceId] =
        useState<string | null>(null);

    const [dynamicMenu, setDynamicMenu] = useState<MenuItem[]>([]);




    const [userName, setUserName] = useState<string | null>(null);
    const [roleNames, setRoleNames] = useState<string | null>(null);

    const [openMenu, setOpenMenu] = useState<string | null>(null);
    const [openSubMenu, setOpenSubMenu] = useState<string | null>(null);

    const [showLogoutModal, setShowLogoutModal] = useState(false);
    const [closing, setClosing] = useState(false);

    const toggleMain = (key: string) => {
        if (collapsed) return;
        setOpenMenu(openMenu === key ? null : key);
    };

    const toggleChild = (key: string) => {
        if (collapsed) return;
        setOpenSubMenu(openSubMenu === key ? null : key);
    };

    const handleConfirmLogout = () => {
        sessionStorage.clear();
        localStorage.removeItem("displayName");
        localStorage.removeItem("roleNames");
        clearWorkspaceCache();

        setWorkspaces([]);
        setSelectedWorkspace("Loading...");
        setSelectedWorkspaceId(null);
        setDynamicMenu([]);
        setUserName(null);
        setRoleNames(null);

        navigate("/login", { replace: true });
    };

    const closeModal = () => {
        setClosing(true);
        setTimeout(() => {
            setShowLogoutModal(false);
            setClosing(false);
        }, 300);
    };
    const [showRolePopup, setShowRolePopup] = useState(false);
    const roleRef = useRef<HTMLDivElement | null>(null);

    const rolesArray = roleNames ? roleNames.split(",") : [];
    const firstRole = rolesArray[0];
    const extraRoles = rolesArray.slice(1);



    useEffect(() => {

        const loadWorkspaces = async () => {
            startLoading();

            try {
                const slotId = sessionStorage.getItem("accessToken") || "";
                const data = await getWorkSpaces(slotId);

                setWorkspaces(data);

                if (data.length > 0) {
                    setSelectedWorkspace(data[0].portalName);
                    setSelectedWorkspaceId(data[0].portalGroupId);
                }
            } finally {
                // stopLoading();
            }
        };
        loadWorkspaces();
    }, []);



    useEffect(() => {
        if (!selectedWorkspaceId) return;



        const loadWorkspaceMenu = async () => {
            startLoading();

            try {
                const slotId = sessionStorage.getItem("accessToken") || "";



                const parsedMenu = await getWorkspaceMenu(
                    slotId,
                    selectedWorkspaceId
                );



                if (!parsedMenu || parsedMenu.length === 0) {
                    console.warn("Menu API returned empty");
                    return;
                }

                setDynamicMenu(parsedMenu);

                if (parsedMenu[0]?.path) {
                    navigate(parsedMenu[0].path, { replace: true });
                }

            } catch (err) {
                console.error("Workspace menu load failed", err);
            } finally {
                stopLoading();
            }
        };

        loadWorkspaceMenu();

    }, [selectedWorkspaceId]);
    useEffect(() => {
        if (collapsed) {
            setOpenMenu(null);
            setOpenSubMenu(null);
        }
    }, [collapsed]);




    /* 🔹 TOOLTIP HANDLING */
    useEffect(() => {
        const bootstrap = (window as any).bootstrap;
        if (!bootstrap?.Tooltip) return;

        const elements = Array.from(
            document.querySelectorAll<HTMLElement>('[data-bs-toggle="tooltip"]')
        );

        elements.forEach((el) => {
            if (!el) return; // Add safeguard against null elements

            let instance = bootstrap.Tooltip.getInstance(el);

            // Dispose the tooltip if not collapsed
            if (!collapsed) {
                if (instance) {
                    instance.dispose();
                }
            }

            // Only initialize the tooltip if it's collapsed
            if (collapsed && !instance) {
                new bootstrap.Tooltip(el, {
                    placement: "right",
                    trigger: "hover",
                    boundary: "window",
                    animation: true,
                    offset: [0, 10],
                });
            }
        });

        // Cleanup on component unmount or when `collapsed` changes
        return () => {
            elements.forEach((el) => {
                if (!el) return;
                const instance = bootstrap.Tooltip.getInstance(el);
                if (instance) instance.dispose();
            });
        };
    }, [collapsed]);

    useEffect(() => {
        // Retrieve data from localStorage when the component mounts
        const storedUserName = localStorage.getItem("displayName");
        const storedRoleNames = localStorage.getItem("roleNames");

        if (storedUserName) {
            setUserName(storedUserName);
        }

        if (storedRoleNames) {
            setRoleNames(storedRoleNames);
        }
    }, []);


    useEffect(() => {
        const handleClickOutside = (event: MouseEvent) => {
            if (roleRef.current && !roleRef.current.contains(event.target as Node)) {
                setShowRolePopup(false);
            }
        };

        document.addEventListener("mousedown", handleClickOutside);
        return () => document.removeEventListener("mousedown", handleClickOutside);
    }, []);

    useEffect(() => {
        if (collapsed) {
            setShowRolePopup(false);
        }
    }, [collapsed]);

    return (
        <>
            <div className={`sidebar-content ${collapsed ? "collapsed" : ""}`}>

                {/* HEADER */}
                <div className="sidebar-top px-3 d-flex align-items-center justify-content-between sidebar-padding-fix">
                    <button className="btn btn-light btn-sm bg-light border-1" onClick={toggle}>
                       {collapsed ?   <i className="ph ph-text-indent"></i> :<i className="ph ph-text-outdent"></i> }
                    </button>
                    {!collapsed && (
                        // <div className="d-flex align-items-center">
                        //     {/* <i className="ph ph-stack sidebar-logo"></i>
                        //     <span className="sidebar-title ms-2">Innovace</span> */}
                        //     <div className="sidebar-logo"></div>
                        // </div>
                        <div className="sidebar-logo"></div>
                    )}


                </div>

                {/* WORKSPACE */}
                {!collapsed && (
                    <div className="sidebar-section sidebar-resize-hide dropdown mx-2">
                        <a
                            href="#"
                            className="btn btn-link text-body text-start lh-1 dropdown-toggle p-2 my-1 w-100"
                            data-bs-toggle="dropdown"
                            onClick={(e) => e.preventDefault()}
                        >
                            <div className="hstack gap-2 flex-grow-1 my-1">
                                <div className="me-auto">
                                    <div className="fs-sm opacity-75 mb-1">Work spaces</div>

                                    {/* ✅ Dynamic Workspace Name */}
                                    <div className="fw-semibold">
                                        {selectedWorkspace || "Loading..."}
                                    </div>
                                </div>
                            </div>
                        </a>

                        {/* ✅ Dropdown List */}
                        <ul className="dropdown-menu w-100">
                            {workspaces.map((ws) => (
                                <li key={ws.portalGroupId}>
                                    <button
                                        className="dropdown-item"
                                        onClick={() => {

                                            setSelectedWorkspace(ws.portalName);
                                            setSelectedWorkspaceId(ws.portalGroupId);
                                        }}
                                    >
                                        {ws.portalName}
                                    </button>
                                </li>
                            ))}
                        </ul>
                    </div>
                )}

                {/* MENU */}
                <div className="sidebar-menu mt-4">
                    <ul className="list-unstyled">



                        {/* JSON MENU */}
                        {dynamicMenu.map(menu => (
                            <li
                                key={menu.label}
                                className={`has-submenu level-0 ${openMenu === menu.key ? "open" : ""}`}
                            >
                                {menu.children ? (
                                    <div
                                        className="sidebar-link submenu-toggle"
                                        onClick={() => toggleMain(menu.key!)}
                                        data-bs-toggle={collapsed ? "tooltip" : undefined}
                                        data-bs-placement="right"
                                        title={menu.label}
                                    >
                                        <div className="d-flex gap-2 align-items-center">
                                            <i className={`lfticn ph ${menu.icon}`}></i>
                                            {!collapsed && <span>{menu.label}</span>}
                                        </div>

                                        {!collapsed && (
                                            <i className={`ph ${openMenu === menu.key ? "ph-caret-down" : "ph-caret-right"} right`} />
                                        )}
                                    </div>
                                ) : (
                                    <NavLink
                                        to={menu.path ?? "#"}
                                        className="sidebar-link"
                                        data-bs-toggle={collapsed ? "tooltip" : undefined}
                                        data-bs-placement="right"
                                        title={menu.label}
                                    >
                                        <i className={`lfticn ph ${menu.icon}`}></i>
                                        {!collapsed && <span>{menu.label}</span>}
                                    </NavLink>
                                )}

                                {/* SUBMENU */}
                                {menu.children && (
                                    <ul className="submenu">
                                        {menu.children.map(child => (
                                            <li
                                                key={child.label}
                                                className={`has-submenu level-1 ${openSubMenu === child.key ? "open" : ""}`}
                                            >
                                                {child.children ? (
                                                    <div
                                                        className="sidebar-sublink submenu-toggle"
                                                        onClick={() => toggleChild(child.key!)}
                                                        data-bs-toggle={collapsed ? "tooltip" : undefined}
                                                        data-bs-placement="right"
                                                        title={child.label}
                                                    >
                                                        {!collapsed && <span>{child.label}</span>}
                                                        {!collapsed && (
                                                            <i className={`ph ${openSubMenu === child.key ? "ph-caret-down" : "ph-caret-right"} right small`} />
                                                        )}
                                                    </div>
                                                ) : (
                                                    <NavLink
                                                        to={child.path ?? "#"}
                                                        className="sidebar-sublink"
                                                        data-bs-toggle={collapsed ? "tooltip" : undefined}
                                                        data-bs-placement="right"
                                                        title={child.label}
                                                    >
                                                        {!collapsed && <span>{child.label}</span>}
                                                    </NavLink>
                                                )}

                                                {/* SUB-SUBMENU */}
                                                {child.children && openSubMenu === child.key && (
                                                    <ul className="sub-submenu">
                                                        {child.children.map(sub => (
                                                            <li key={sub.label} className="level-2">
                                                                <NavLink
                                                                    to={sub.path ?? "#"}
                                                                    className="sidebar-sub-sublink"
                                                                    data-bs-toggle={collapsed ? "tooltip" : undefined}
                                                                    data-bs-placement="right"
                                                                    title={sub.label}
                                                                >
                                                                    {!collapsed && <span>{sub.label}</span>}
                                                                </NavLink>
                                                            </li>
                                                        ))}
                                                    </ul>
                                                )}
                                            </li>
                                        ))}
                                    </ul>
                                )}
                            </li>
                        ))}
                    </ul>
                </div>

                {/* FOOTER */}
                <div className="sidebar-footer">
    <hr className="sidebar-divider" />

    <div
        className="log-btn"
        onClick={() => setShowLogoutModal(true)}
        data-bs-toggle={collapsed ? "tooltip" : undefined}
        data-bs-placement="right"
        title="Logout"
    >
        <i className="lfticn ph ph-sign-out"></i>

        {/* ✅ ALWAYS RENDER */}
        <span className="sidebar-text">Logout</span>
    </div>

    <div className="d-flex sidebar-profile px-3 mt-auto">
        <img
            src={Profiler}
            className="rounded-circle"
            width="42"
            height="42"
            alt="profile"
        />

        {/* ✅ ALWAYS RENDER */}
        <div className="ms-2 sidebar-profile-info">
            {userName && <div className="fw-semibold">{userName}</div>}

            <div ref={roleRef} className="role-wrapper">
                {firstRole && (
                    <span className="role-pill">{firstRole}</span>
                )}

                {extraRoles.length > 0 && (
                    <span
                        className="role-more"
                        onClick={() => setShowRolePopup((prev) => !prev)}
                    >
                        +{extraRoles.length}
                    </span>
                )}

                {showRolePopup && (
                    <div className="role-popup">
                        <div className="role-popup-title">Other Roles</div>

                        {extraRoles.map((role, index) => (
                            <div key={index} className="role-item">
                                <span className="role-dot"></span>
                                {role}
                            </div>
                        ))}
                    </div>
                )}
            </div>
        </div>
    </div>
</div>
            </div>

            {/* LOGOUT MODAL */}
            {showLogoutModal && (
                <div className={`logout-overlay ${closing ? "fadeOut" : "fadeIn"}`}>
                    <div className={`logout-modal ${closing ? "slideDown" : "slideUp"}`}>
                        <i className="ph ph-warning-circle text-danger" style={{ fontSize: 60 }}></i>

                        <h5 className="mt-3 mb-2">Are you sure?</h5>
                        <p className="text-muted mb-4">Do you want to logout?</p>

                        <div className="d-flex justify-content-center gap-3">
                            <button className="btn btn-light px-4" onClick={closeModal}>
                                Cancel
                            </button>
                            <button className="btn btn-danger px-4" onClick={handleConfirmLogout}>
                                Logout
                            </button>
                        </div>
                    </div>
                </div>
            )}
        </>
    );
};

export default Sidebar;
