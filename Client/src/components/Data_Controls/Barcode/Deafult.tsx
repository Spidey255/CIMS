// Innovace Intech Solution Pvt Ltd
// import React, { useRef, useCallback } from "react";
// import { QRCodeSVG } from "qrcode.react";
// import type { UIElement } from "../../../constants/types";
// import { useGeneralStore } from "../../../store/useStore";
// import qrimg from "../../../assets/images/Vertiv-Logo1.svg";

// import {
//   downloadQRAsPDF,
//   shareQR,
// } from "../../../utils/qrExport";

// const Default: React.FC<{
//   element: UIElement;
//   children?: React.ReactNode;
// }> = ({ element, children: _children }) => {
//   const qrRef = useRef<HTMLDivElement>(null);


//   const state = useGeneralStore(
//     (store) => store.state[element.ElementName]?.["value"]
//   );

//   // ✅ safer value handling
//   const qrValue =
//     typeof state === "string" || typeof state === "number"
//       ? String(state)
//       : " ";

//   // ✅ memoized handlers (perf)
//   const handleDownload = useCallback(async () => {
//     if (!qrRef.current) return;
//     try {
//       await downloadQRAsPDF(qrRef.current);
//     } catch (err) {
//       console.error("PDF export failed", err);
//     }
//   }, []);

//   const handleShareClick = useCallback(async () => {
//     if (!qrRef.current) return;
//     try {
//       await shareQR(qrRef.current);
//     } catch (err) {
//       console.error("Share failed", err);
//     }
//   }, []);

//   return (

//     <div className="w-max" data-root={`root_${element.id}`} id={element.id}>
//       <div className="form-group">
//         <div className="d-flex justify-content-between align-items-center px-2 pt-2 w-100">
//           <label className="form-label mb-0">{element.ElementName}</label>
//           <div className=" d-flex gap-2 justify-content-end w-100">
//             <a
//               className="bg-light btn border"
//               title="Download"
//               onClick={handleDownload}
//             >
//               <i className="ph ph-download"></i>
//             </a>

//             <a
//               className="bg-light btn border d-none"
//               title="share"
//               onClick={handleShareClick}
//             >
//               <i className="ph ph-share-network"></i>
//             </a>
//           </div>
//         </div>


//         <div className="controls">
//           {/* ✅ EXPORT TARGET */}
//           <div
//             ref={qrRef}
//             className="barcodeStyle"
//             style={{
//               width: "fit-content",
//             }}
//           >
//             <QRCodeSVG
//               value={qrValue}
//               size={260}
//               level="H"
//               includeMargin
//               imageSettings={{
//                 src: qrimg,
//                 height: 42,
//                 width: 42,
//                 excavate: true,
//               }}
//             />
//           </div>
//         </div>
//       </div>
//     </div>


//   );
// };

// export default Default;

import React, { useRef, useCallback } from "react";
import { QRCodeSVG } from "qrcode.react";
import type { UIElement } from "../../../constants/types";
import { useGeneralStore } from "../../../store/useStore";
import qrimg from "../../../assets/images/Vertiv-Logo1.svg";

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
  const allElements = useGeneralStore((store) => store.state);
  console.log("allElements", allElements)
  const getValue = (key: string) => {
    const val = allElements?.[key]?.value;
    return typeof val === "string" || typeof val === "number"
      ? String(val)
      : "N/A";
  };
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
          <label className="form-label mb-0 w-100">{element.DCaption}</label>
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


        <div className="controls mt-1">
          {/* ✅ EXPORT TARGET */}
          <div
            ref={qrRef}
            className="barcodeStyle p-3 bg-white rounded shadow-sm"
            style={{
              width: "300px",
              textAlign: "center",
              border: "1px solid #e5e7eb",
            }}
          >
            {getValue("M_QR_Shipment_Info") &&
              <>
                {/* 🔷 Title */}
                <div className="mb-2">
                  <h6 className="fw-bold mb-0">{element.DCaption}</h6>
                  <small className="text-muted">Scan for details</small>
                </div>
              </>
            }
            {/* 🔷 QR Code */}
            <div className="d-flex justify-content-center my-2">
              <QRCodeSVG
                value={qrValue}
                size={220}
                level="H"
                includeMargin
                imageSettings={{
                  src: qrimg,
                  height: 40,
                  width: 40,
                  excavate: true,
                }}
              />
            </div>
            {getValue("M_QR_Shipment_Info") &&
              <>

                <div className="text-start mt-2" style={{ fontSize: "12px" }}>
                  <div><strong>Ship To Location : </strong><br></br>{getValue("M_QR_Shipment_Info")}</div>

                </div>


                <div className="mt-2 pt-2 border-top" style={{ fontSize: "10px", color: "#6b7280" }}>
                  Powered by Vertiv
                </div>
              </>
            }

          </div>
        </div>
      </div>
    </div>


  );
};

export default Default;