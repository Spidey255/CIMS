// Innovace Intech Solution Pvt Ltd
// import React from "react";
// import { QRCodeSVG } from "qrcode.react";
// import type { UIElement } from "../../../constants/types";
// import { useGeneralStore } from "../../../store/useStore";
// import qrimg from "../../../assets/Vertiv-Logo1.svg";

// const Default: React.FC<{
//   element: UIElement;
//   children?: React.ReactNode;
// }> = ({ element, children }) => {
//   const handleClick = (e: React.MouseEvent<HTMLDivElement>) => {
//     if (typeof window !== "undefined") {
//       // @ts-ignore
//       window.LayoutControlSelected?.(e, element.id);
//     }
//   };

//   const state = useGeneralStore(
//     (store) => store.state[element.ElementName]?.["value"]
//   );

//   const qrValue = String(state) || " ";

//   return (
//     <div className="col-lg-4" data-root={`root_${element.id}`}>
//       <div id={element.id} onClick={handleClick}>
//         <div className="form-group">
//           <label
//             id={`lbl_${element.id}`}
//             className="form-label"
//             htmlFor={`bar_${element.id}`}
//           >
//             QR Code
//           </label>

//           <span id={`man_${element.id}`} className="text-danger" />

//           <div
//             id={`mc_${element.id}`}
//             className="controls"
//             data-container={`container_${element.id}`}
//           >
//             <div
//               id={`bar_${element.id}`}
//               className="barcodeStyle"
//               style={{
//                 width: "max-content",
//                 background: "white",
//                 display: "flex",
//                 alignItems: "center",
//                 justifyContent: "center",
//                 padding: 10,
//               }}
//             >
//               <QRCodeSVG
//                 value={qrValue}
//                 size={280}
//                 bgColor="#ffffff"
//                 fgColor="#000000"
//                 level="H" // important for logo (high error correction)
//                 includeMargin={true}
//                 imageSettings={{
//                   src: qrimg, // 👈 your company logo path
//                   x: undefined,
//                   y: undefined,
//                   height: 40,
//                   width: 40,
//                   excavate: true, // 👈 clears QR behind logo
//                 }}
//               />
//             </div>
//           </div>
//         </div>
//       </div>

//       {children}
//     </div>
//   );
// };

// export default Default;




import React, { useRef, useCallback } from "react";
import { QRCodeSVG } from "qrcode.react";
import type { UIElement } from "../../../constants/types";
import { useGeneralStore } from "../../../store/useStore";
import qrimg from "../../../assets/Vertiv-Logo1.svg";

import {
  downloadQRAsPDF,
  shareQR,
} from "../../../utils/qrExport";

const Default: React.FC<{
  element: UIElement;
  children?: React.ReactNode;
}> = ({ element, children: _children }) => {
  const qrRef = useRef<HTMLDivElement>(null);


  const state = useGeneralStore(
    (store) => store.state[element.ElementName]?.["value"]
  );

  // ✅ safer value handling
  const qrValue =
    typeof state === "string" || typeof state === "number"
      ? String(state)
      : " ";

  // ✅ memoized handlers (perf)
  const handleDownload = useCallback(async () => {
    if (!qrRef.current) return;
    try {
      await downloadQRAsPDF(qrRef.current);
    } catch (err) {
      console.error("PDF export failed", err);
    }
  }, []);

  const handleShareClick = useCallback(async () => {
    if (!qrRef.current) return;
    try {
      await shareQR(qrRef.current);
    } catch (err) {
      console.error("Share failed", err);
    }
  }, []);

  return (

    <div className="w-max" data-root={`root_${element.id}`} id={element.id}>
      <div className="form-group">
        <div className="d-flex justify-content-between align-items-center px-2 pt-2 w-100">
          <label className="form-label mb-0">{element.ElementName}</label>
          <div className=" d-flex gap-2 justify-content-end w-100">
            <a
              className="bg-light btn border"
              title="Download"
              onClick={handleDownload}
            >
              <i className="ph ph-download"></i>
            </a>

            <a
              className="bg-light btn border d-none"
              title="share"
              onClick={handleShareClick}
            >
              <i className="ph ph-share-network"></i>
            </a>
          </div>
        </div>


        <div className="controls">
          {/* ✅ EXPORT TARGET */}
          <div
            ref={qrRef}
            className="barcodeStyle"
            style={{
              width: "fit-content",
            }}
          >
            <QRCodeSVG
              value={qrValue}
              size={260}
              level="H"
              includeMargin
              imageSettings={{
                src: qrimg,
                height: 42,
                width: 42,
                excavate: true,
              }}
            />
          </div>
        </div>
      </div>
    </div>


  );
};

export default Default;