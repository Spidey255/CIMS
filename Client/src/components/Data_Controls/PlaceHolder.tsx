// Innovace Intech Solution Pvt Ltd
// import React from "react";
// import type { UIElement } from "../../constants/types";
// import { useGeneralStore } from "@/store/useStore";
// import { pages } from "@/constants/pages";

// const Placeholder: React.FC<{
//   element: UIElement;
//   children?: React.ReactNode;
// }> = ({ element: element, children: _children }) => {

//   const state = useGeneralStore(
//     (store) => store.state[element.ElementName]?.["value"]
//   );
//   const url = String(state);
//   console.log("url", url);
//   const queryString = url.split("?")[1];
//   let val = "";
//   if (!queryString) {
//     val = url || "";
//   };

//   const params = Object.fromEntries(
//     new URLSearchParams(queryString)
//   );

//   const page = pages.find(
//     (p) => p.ProcessActivityMapId === params.PkActMId
//   );


//   return (
//     <div className={`control plh_${element.ElementName}`} >
//       <iframe
//       style={{width:"100%", height:"100%"}}
//         className={`Modal_iFrame`}
//         id={`plh_${element.UIElementid}`}
//         name={`plh_${element.ElementName}`}
//         frameBorder={0}
//         src={page?.ProcessName || val || url} // Convert state to string, if defined
//       ></iframe>
//     </div>
//   );
// };

// export default Placeholder;


import React, { useMemo, useState } from "react";
import type { UIElement } from "../../constants/types";
import { useGeneralStore } from "@/store/useStore";
import { pages } from "@/constants/pages";

const Placeholder: React.FC<{
  element: UIElement;
}> = ({ element }) => {

  const state = useGeneralStore(
    (store) => store.state[element.ElementName]?.["value"]
  );

  const url = String(state);

  // ✅ Memoize parsing
  const { finalSrc } = useMemo(() => {
    if (!url) return { finalSrc: "" };

    const queryString = url.split("?")[1];

    let val = "";
    if (!queryString) {
      val = url;
    }

    const params = queryString
      ? Object.fromEntries(new URLSearchParams(queryString))
      : {};

    const page = pages.find(
      (p) => p.ProcessActivityMapId === params?.PkActMId
    );

    return {
      finalSrc: page?.ProcessName || val || url
    };
  }, [url]);

  // ✅ Prevent infinite reload on failure
  const [isError, setIsError] = useState(false);

  if (!finalSrc || isError) {
    return (
      <div className="control">
        <div style={{ padding: 20 }}>
          ⚠️ Page not available
        </div>
      </div>
    );
  }

  return (
    <div className={`control plh_${element.ElementName}`}>
      <iframe
        key={finalSrc} // ✅ important: only reload when URL changes
        style={{ width: "100%", height: "100%" }}
        className="Modal_iFrame"
        id={`plh_${element.UIElementid}`}
        name={`plh_${element.ElementName}`}
        frameBorder={0}
        src={finalSrc}
        onError={() => setIsError(true)} // ✅ stop retry loop
      />
    </div>
  );
};

export default Placeholder;