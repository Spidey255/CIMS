// Innovace Intech Solution Pvt Ltd
// // import React from "react";
// // import type { UIElement } from "../../constants/types";

// // const Placeholder: React.FC<{
// //   element: UIElement;
// //   children?: React.ReactNode;
// // }> = ({ element: _element, children }) => {
// //   // Example handler - replace with your own logic
// //   const handleLayoutSelect = (id: string) => {
// //     console.log("LayoutControlSelected", id);
// //   };

// //   return (
// //     <div
// //       className="col-lg-4"
// //       data-root="root_9a70cd73-d1f1-44b0-fd7b-b7d2a1c0aa74"
// //     >
// //       <div
// //         id="9a70cd73-d1f1-44b0-fd7b-b7d2a1c0aa74"
// //         className="form-group"
// //         onClick={() =>
// //           handleLayoutSelect("9a70cd73-d1f1-44b0-fd7b-b7d2a1c0aa74")
// //         }
// //       >
// //         <label
// //           id="lbl_9a70cd73-d1f1-44b0-fd7b-b7d2a1c0aa74"
// //           className="form-label"
// //           htmlFor="plh_9a70cd73-d1f1-44b0-fd7b-b7d2a1c0aa74"
// //         >
// //           Place Holder
// //         </label>
// //         <div className="controls">
// //           <iframe
// //             className="Modal_iFrame"
// //             id="plh_9a70cd73-d1f1-44b0-fd7b-b7d2a1c0aa74"
// //             name="plh_9a70cd73-d1f1-44b0-fd7b-b7d2a1c0aa74"
// //             frameBorder={0}
// //             src="../DynamicPage/PageNotFound.html"
// //           ></iframe>
// //         </div>
// //       </div>
// //       {children}
// //     </div>
// //   );
// // };

// // export default Placeholder;




// import React from "react";
// import type { UIElement } from "../../constants/types";
// import { useGeneralStore } from "@/store/useStore";

// const Placeholder: React.FC<{
//   element: UIElement;
//   children?: React.ReactNode;
// }> = ({ element: element, children: _children }) => {

//   const state = useGeneralStore(
//     (store) => store.state[element.ElementName]?.["value"]
//   );
//   console.log("element PLaceHolder", element);

//   return (
//     <div className={`control plh_${element.ElementName}`} >
//       <iframe
//         className={`Modal_iFrame`}
//         id={`plh_${element.UIElementid}`}
//         name={`plh_${element.ElementName}`}
//         frameBorder={0}
//         src={state ? String(state) : undefined} // Convert state to string, if defined
//       ></iframe>
//     </div>
//   );
// };

// export default Placeholder;








































// import React, { Suspense, useMemo } from "react";
// import type { UIElement } from "../../constants/types";
// import { useGeneralStore } from "@/store/useStore";
// import { pages } from "@/constants/pages";

// const Placeholder: React.FC<{ element: UIElement }> = ({ element }) => {
//   const state = useGeneralStore(
//     (store) => store.state[element.ElementName]?.["value"]
//   );

//   const url = String(state || "");

//   const params = useMemo(() => {
//     const queryString = url.split("?")[1];
//     if (!queryString) return null;
//     return Object.fromEntries(new URLSearchParams(queryString));
//   }, [url]);

//   const pageConfig = useMemo(() => {
//     if (!params?.PkActMId) return null;
//     return pages.find((p) => p.ProcessActivityMapId === params.PkActMId);
//   }, [params]);

//   /** ---------------- DYNAMIC PAGE LOADER ---------------- */
//   const DynamicPage = useMemo(() => {
//     if (!pageConfig?.ProcessName) return null;

//     // Import all pages under src/pages dynamically
//     const modules = import.meta.glob("../pages/*.tsx");

//     const importFunc = modules[`../pages/${pageConfig.ProcessName}.tsx`] as () => Promise<{ default: React.ComponentType<any> }>;

//     if (!importFunc) return null;

//     return React.lazy(importFunc);
//   }, [pageConfig]);

//   if (!DynamicPage) return null;

//   return (
//     <div className={`control plh_${element.ElementName}`}>
//       <Suspense fallback={<div>Loading page...</div>}>
//         <DynamicPage />
//       </Suspense>
//     </div>
//   );
// };

// export default Placeholder;








import React from "react";
import type { UIElement } from "../../constants/types";
import { useGeneralStore } from "@/store/useStore";
import { pages } from "@/constants/pages";

const Placeholder: React.FC<{
  element: UIElement;
  children?: React.ReactNode;
}> = ({ element: element, children: _children }) => {

  const state = useGeneralStore(
    (store) => store.state[element.ElementName]?.["value"]
  );
  const url = String(state);
  console.log("url", url);
  const queryString = url.split("?")[1];
  let val = "";
  if (!queryString) {
    // val = `http://192.168.0.109:3000/reactframeportal?token=${sessionStorage.getItem("accessToken")}`;
    val = url || "";
  };

  const params = Object.fromEntries(
    new URLSearchParams(queryString)
  );

  const page = pages.find(
    (p) => p.ProcessActivityMapId === params.PkActMId
  );


  return (
    <div className={`control plh_${element.ElementName}`} >
      <iframe
      style={{width:"100%", height:"100%"}}
        className={`Modal_iFrame`}
        id={`plh_${element.UIElementid}`}
        name={`plh_${element.ElementName}`}
        frameBorder={0}
        src={page?.ProcessName || val || url} // Convert state to string, if defined
      ></iframe>
    </div>
  );
};

export default Placeholder;