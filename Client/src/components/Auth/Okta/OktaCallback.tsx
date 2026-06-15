// Innovace Intech Solution Pvt Ltd
// import { useEffect } from "react";
// import { useNavigate } from "react-router-dom";
// import { useUserStore } from "@/store/useUserStore";
// import { getWorkSpaces, getWorkspaceMenu } from "@/helpers/workspaceHelper";

// interface IOktaResponse {
//     Token?: string;
//     Message?: string;
//     TokenDetail?: {
//         displayName?: string;
//         roleNames?: string;
//     };
// }

// const OktaCallback = () => {
//     const navigate = useNavigate();

//     const setSlotId = useUserStore((store) => store.setSlotId);
//     const setIsAuthenticated = useUserStore(
//         (store) => store.setIsAuthenticated
//     );

//     useEffect(() => {
//         const processLogin = async () => {
//             try {
//                 const params = new URLSearchParams(window.location.search);
//                 const payload = params.get("payload");

//                 if (!payload) {
//                     throw new Error("No authentication payload received.");
//                 }

//                 const data: IOktaResponse = JSON.parse(
//                     decodeURIComponent(payload)
//                 );

//                 console.log("Decoded Okta Payload:", data);

//                 const slotToken = data?.Token;

//                 if (!slotToken) {
//                     throw new Error(
//                         data?.Message || "Authentication failed."
//                     );
//                 }

//                 // Store token
//                 sessionStorage.setItem("accessToken", slotToken);
//                 localStorage.setItem("token", slotToken);
//                 localStorage.setItem(
//                     "displayName",
//                     data?.TokenDetail?.displayName || ""
//                 );
//                 localStorage.setItem(
//                     "roleNames",
//                     data?.TokenDetail?.roleNames || ""
//                 );

//                 setSlotId(slotToken);
//                 setIsAuthenticated(true);

//                 // Load workspaces
//                 const workspaces = await getWorkSpaces(slotToken);

//                 if (!workspaces || workspaces.length === 0) {
//                     navigate("/");
//                     return;
//                 }

//                 const firstWorkspace = workspaces[0];

//                 const menu = await getWorkspaceMenu(
//                     slotToken,
//                     firstWorkspace.portalGroupId
//                 );

//                 if (menu?.length > 0 && menu[0]?.path) {
//                     navigate(`/${menu[0].path}`);
//                 } else {
//                     navigate("/");
//                 }
//             } catch (error: any) {
//                 console.error("Okta Login Error:", error);

//                 localStorage.removeItem("token");
//                 localStorage.removeItem("displayName");
//                 localStorage.removeItem("roleNames");
//                 sessionStorage.removeItem("accessToken");

//                 alert(
//                     error?.message ||
//                         "Authentication failed. Please try again."
//                 );

//                 navigate("/login");
//             }
//         };

//         processLogin();
//     }, [navigate, setSlotId, setIsAuthenticated]);

//     return (
//         <div
//             className="d-flex justify-content-center align-items-center vh-100"
//             style={{
//                 background: "#f8f9fa",
//             }}
//         >
//             <div className="text-center">
//                 <div
//                     className="spinner-border text-warning mb-3"
//                     role="status"
//                 >
//                     <span className="visually-hidden">Loading...</span>
//                 </div>

//                 <h5 className="mb-2">Signing in with Okta...</h5>
//                 <p className="text-muted mb-0">
//                     Please wait while we authenticate your account.
//                 </p>
//             </div>
//         </div>
//     );
// };

// export default OktaCallback;


import { useEffect } from "react";
import { useNavigate } from "react-router-dom";
import { useUserStore } from "@/store/useUserStore";
import { getWorkSpaces, getWorkspaceMenu } from "@/helpers/workspaceHelper";

interface IOktaResponse {
    Token?: string;
    Message?: string;
    TokenDetail?: {
        displayName?: string;
        roleNames?: string;
    };
}

const OktaCallback = () => {
    const navigate = useNavigate();

    const setSlotId = useUserStore((store) => store.setSlotId);
    const setIsAuthenticated = useUserStore(
        (store) => store.setIsAuthenticated
    );

    useEffect(() => {
        const processLogin = async () => {
            try {
                const params = new URLSearchParams(window.location.search);
                const payload = params.get("payload");

                if (!payload) {
                    throw new Error("No authentication payload received.");
                }

                const data: IOktaResponse = JSON.parse(
                    decodeURIComponent(payload)
                );

                console.log("Decoded Okta Payload:", data);

                const slotToken = data?.Token;

                if ((window as any).ReactNativeWebView) {
                    (window as any).ReactNativeWebView.postMessage(
                        JSON.stringify({
                            type: "LOGIN_SUCCESS",
                            token: slotToken,
                            displayName: data?.TokenDetail?.displayName,
                            roleNames: data?.TokenDetail?.roleNames,
                        })
                    );

                    return; // Exit early for mobile webview

                }

                if (!slotToken) {
                    throw new Error(
                        data?.Message || "Authentication failed."
                    );
                }

                // Store token
                sessionStorage.setItem("accessToken", slotToken);
                localStorage.setItem("token", slotToken);
                localStorage.setItem(
                    "displayName",
                    data?.TokenDetail?.displayName || ""
                );
                localStorage.setItem(
                    "roleNames",
                    data?.TokenDetail?.roleNames || ""
                );

                setSlotId(slotToken);
                setIsAuthenticated(true);

                // Load workspaces
                const workspaces = await getWorkSpaces(slotToken);

                if (!workspaces || workspaces.length === 0) {
                    navigate("/");
                    return;
                }

                const firstWorkspace = workspaces[0];

                const menu = await getWorkspaceMenu(
                    slotToken,
                    firstWorkspace.portalGroupId
                );

                if (menu?.length > 0 && menu[0]?.path) {
                    navigate(`/${menu[0].path}`);
                } else {
                    navigate("/");
                }
            } catch (error: any) {
                console.error("Okta Login Error:", error);

                localStorage.removeItem("token");
                localStorage.removeItem("displayName");
                localStorage.removeItem("roleNames");
                sessionStorage.removeItem("accessToken");

                alert(
                    error?.message ||
                        "Authentication failed. Please try again."
                );

                navigate("/login");
            }
        };

        processLogin();
    }, [navigate, setSlotId, setIsAuthenticated]);

    return (
        <div
            className="d-flex justify-content-center align-items-center vh-100"
            style={{
                background: "#f8f9fa",
            }}
        >
            <div className="text-center">
                <div
                    className="spinner-border text-warning mb-3"
                    role="status"
                >
                    <span className="visually-hidden">Loading...</span>
                </div>

                <h5 className="mb-2">Signing in with Okta...</h5>
                <p className="text-muted mb-0">
                    Please wait while we authenticate your account.
                </p>
            </div>
        </div>
    );
};

export default OktaCallback;