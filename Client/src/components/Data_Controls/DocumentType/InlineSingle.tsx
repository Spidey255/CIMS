// Innovace Intech Solution Pvt Ltd
// import React, { useCallback, useEffect, useRef, useState } from "react";
// import type { UIElement } from "@/constants/types";
// import { useGeneralStore } from "@/store/useStore";
// import { useUserStore } from "@/store/useUserStore";
// import { getBase64StringFromUrl } from "@/services/documentService";
// import {
//   extractDocumentSettings,
//   getExtensionFromBase64,
// } from "@/helpers/utils";
// import {
//   resusableDeleteDocument,
//   resusableOnFileChange,
// } from "@/components/Events/onFileChange";
// import { config } from "@/constants/config";

// const InlineSingle: React.FC<{
//   element: UIElement;
//   isGrid?: boolean;
// }> = ({ element, isGrid }) => {
//   const state = useGeneralStore(
//     (store) => store.state[element.ElementName]?.["value"] as string
//   );

//   const setState = useGeneralStore((store) => store.setState);
//   const slotId = useUserStore((store) => store.slotId);

//   const { Size, AllowedTypes } = extractDocumentSettings(
//     element.DocumentSettings || ""
//   );

//   const [loading, setLoading] = useState(false);

//   const src =
//     typeof state === "string" && state.split("#").length > 1
//       ? `${config.URL}/iProofService/api/RemoteGateway/ExplorerDocuments?docId=${state.split("#")[0]
//       }&verNo=0&requestFrom=DE&Rand=0.8229241063356949&slotId=${slotId}`
//       : "";

//   const [isVideoVisible] = useState(false);
//   const [isDragging, setIsDragging] = useState(false);

//   const [fileType, setFileType] = useState("");
//   const [, setFileName] = useState(state);
//   const [base64Data, setBase64Data] = useState<string>();
//   const [documentData, setDocumentData] = useState<{
//     documentNo: string;
//     documentId: string;
//   }>();

//   const fileInputRef = useRef<HTMLInputElement>(null);

//   // ✅ NEW CAMERA REF (ADDED ONLY)
//   const cameraInputRef = useRef<HTMLInputElement>(null);

//   const isMobile =
//     typeof navigator !== "undefined" &&
//     /Android|iPhone|iPad|iPod/i.test(navigator.userAgent);

//   const handleReset = () => {
//     setBase64Data(undefined);
//     setDocumentData(undefined);
//     setFileName("");
//     setFileType("");

//     if (fileInputRef.current) fileInputRef.current.value = "";
//     if (cameraInputRef.current) cameraInputRef.current.value = "";
//   };

//   const handleLoadData = useCallback(async () => {
//     if (!state || !state?.toString().includes("#")) return;

//     try {
//       setLoading(true);

//       const data = await getBase64StringFromUrl(
//         slotId || "",
//         state.toString().split("#")[0],
//         1
//       );

//       if (data.length) {
//         const extension = getExtensionFromBase64(
//           data[0].value.split(",")[0]
//         );

//         if (extension) {
//           setFileType(extension);
//           setBase64Data(data[0].value);
//         }

//         setDocumentData({
//           documentId: data[1].key,
//           documentNo: data[1].value,
//         });
//       }
//     } catch (error) {
//       console.log(error);
//     } finally {
//       setLoading(false);
//     }
//   }, [state, slotId]);

//   useEffect(() => {
//     handleLoadData();
//   }, [handleLoadData]);

//   const processFiles = async (files: FileList | null) => {
//     try {
//       setLoading(true);

//       const result = await resusableOnFileChange(files, {
//         maxSize: Size,
//         ElementName: element.ElementName,
//         isGrid: Boolean(isGrid),
//       });

//       if (result) {
//         setDocumentData({
//           documentId: result.documentId,
//           documentNo: result.documentNo,
//         });

//         setState(element.ElementName, result.documentId);
//         setFileType(result.fileType);
//         setFileName(result.fileName);
//         setBase64Data(result.base64Data);
//       }
//     } catch (error) {
//       console.log(error);
//     } finally {
//       setLoading(false);
//     }
//   };

//   const handleFileChange = async (
//     event: React.ChangeEvent<HTMLInputElement>
//   ) => {
//     await processFiles(event.target.files);
//     event.target.value = "";
//   };

//   const handleDeleteFile = async () => {
//     try {
//       if (!documentData) return;

//       const result = await resusableDeleteDocument({
//         isGrid: Boolean(isGrid),
//         documentId: documentData.documentId,
//         documentNo: documentData.documentNo,
//         elementName: element.ElementName,
//       });

//       if (result) handleReset();
//       if (result) setState(element.ElementName, "");
      
//     } catch (error) {
//       console.log(error);
//     }
//   };

//   const triggerFileInputClick = () => {
//     fileInputRef.current?.click();
//   };

//   // ✅ NEW: camera trigger
//   const triggerCameraClick = () => {
//     cameraInputRef.current?.click();
//   };

//   const handleDragOver = (e: React.DragEvent<HTMLDivElement>) => {
//     e.preventDefault();
//     setIsDragging(true);
//   };

//   const handleDragLeave = (e: React.DragEvent<HTMLDivElement>) => {
//     e.preventDefault();
//     setIsDragging(false);
//   };

//   const handleDrop = async (e: React.DragEvent<HTMLDivElement>) => {
//     e.preventDefault();
//     setIsDragging(false);
//     await processFiles(e.dataTransfer.files);
//   };


//   const handlePreviewOpen = async () => {
//     if (!base64Data) return;

//     // React Native WebView
//     if ((window as any).ReactNativeWebView) {
//       (window as any).ReactNativeWebView.postMessage(
//         JSON.stringify({
//           type: "OPEN_DOCUMENT",
//           payload: {
//             base64Data,
//             fileType,
//             fileName: state,
//           },
//         })
//       );

//       return;
//     }
//   };

//   return (
//     <div
//       id={element.ElementName}
//       className={`p-2 border rounded-3 shadow-sm bg-white ${element?.Css}`}
//       onClick={(e) => e.stopPropagation()}
//     >
//       <div className="form-group">
//         <div className="InlineSingle">

//           {/* hidden inputs */}
//           <input
//             ref={fileInputRef}
//             type="file"
//             style={{ display: "none" }}
//             accept={AllowedTypes}
//             onChange={handleFileChange}
//           />

//           {/* ✅ NEW CAMERA INPUT (SAFE) */}
//           <input
//             ref={cameraInputRef}
//             type="file"
//             accept="image/*"
//             capture="environment"
//             style={{ display: "none" }}
//             onChange={handleFileChange}
//           />

//           <div className="d-flex justify-content-between align-items-center mb-1 w-100">
//             {element.DCaption}

//             <div className="d-flex justify-content-end w-100 doc-action-Container">

//               <button
//                 className="btn border me-2 bg-light"
//                 onClick={triggerFileInputClick}
//               >
//                 <i className="ph ph-upload"></i>
//               </button>

//               {/* ✅ CAMERA BUTTON (ONLY MOBILE) */}
//               {isMobile && (
//                 <button
//                   className="btn border me-2 bg-light"
//                   onClick={triggerCameraClick}
//                 >
//                   <i className="ph ph-camera"></i>
//                 </button>
//               )}

//               <button
//                 className="btn bg-light border"
//                 onClick={handleDeleteFile}
//               >
//                 <i className="ph ph-trash"></i>
//               </button>
//             </div>
//           </div>

//           <div className="card-body" style={{ overflow: "hidden" }}>
//             <div
//               className="position-relative"
//               style={{
//                 border: isDragging
//                   ? "2px dashed #0d6efd"
//                   : "2px dashed transparent",
//                 borderRadius: "12px",
//               }}
//               onDragOver={handleDragOver}
//               onDragLeave={handleDragLeave}
//               onDrop={handleDrop}
//             >
//               {isVideoVisible ? (
//                 <video controls className="w-100" style={{ height: "auto" }}>
//                   <source src="https://example.com/video.mp4" type="video/mp4" />
//                 </video>
//               ) : (src || base64Data) && (
//                 <>
//                   {/* IMAGE */}
//                   {fileType?.match(/jpg|jpeg|png/i) && (
//                     <div className="img-container" style={{ overflow: "auto" }}>
//                       <img
//                         src={base64Data || src}
//                         alt="Document preview"
//                         onClick={handlePreviewOpen}
//                         style={{
//                           cursor: "pointer",
//                           width: "100%",
//                           height: "auto",
//                           imageRendering: "crisp-edges",
//                         }}
//                       />
//                     </div>
//                   )}

//                   {/* PDF */}
//                   {fileType?.match(/pdf/i) && (
//                     <>
//                       {(window as any).ReactNativeWebView ? (
//                         <div
//                           className="text-center p-4"
//                           onClick={handlePreviewOpen}
//                           style={{
//                             cursor: "pointer",
//                           }}
//                         >
//                           <i
//                             className="ph ph-file-pdf"
//                             style={{ fontSize: "60px" }}
//                           />

//                           <div className="mt-2">
//                             Open PDF
//                           </div>
//                         </div>
//                       ) : (
//                         <iframe
//                           src={base64Data || src}
//                           width="100%"
//                           height="500px"
//                           style={{ border: "none" }}
//                         />
//                       )}
//                     </>
//                   )}

//                   {/* VIDEO */}
//                   {fileType?.match(/mp4/i) && (
//                     <>
//                       {(window as any).ReactNativeWebView ? (
//                         <div
//                           className="text-center p-4"
//                           onClick={handlePreviewOpen}
//                           style={{
//                             cursor: "pointer",
//                           }}
//                         >
//                           <i
//                             className="ph ph-video"
//                             style={{ fontSize: "60px" }}
//                           />

//                           <div className="mt-2">
//                             Open Video
//                           </div>
//                         </div>
//                       ) : (
//                         <video controls className="w-100">
//                           <source src={base64Data || src} type="video/mp4" />
//                         </video>
//                       )}
//                     </>
//                   )}
//                 </>
//               )}

//               {!src && !base64Data && (
//                 <div className="text-center p-3">
//                   Select or capture file
//                 </div>
//               )}

//               {loading && (
//                 <div className="position-absolute top-0 start-0 w-100 h-100 d-flex align-items-center justify-content-center bg-light">
//                   <div className="spinner-border text-primary" />
//                 </div>
//               )}
//             </div>
//           </div>

//         </div>
//       </div>
//     </div>
//   );
// };

// export default InlineSingle;


// Innovace Intech Solution Pvt Ltd
// import React, { useCallback, useEffect, useRef, useState } from "react";
// import type { UIElement } from "@/constants/types";
// import { useGeneralStore } from "@/store/useStore";
// import { useUserStore } from "@/store/useUserStore";
// import { getBase64StringFromUrl } from "@/services/documentService";
// import {
//   extractDocumentSettings,
//   getExtensionFromBase64,
// } from "@/helpers/utils";
// import {
//   resusableDeleteDocument,
//   resusableOnFileChange,
// } from "@/components/Events/onFileChange";
// import { config } from "@/constants/config";

// const InlineSingle: React.FC<{
//   element: UIElement;
//   isGrid?: boolean;
// }> = ({ element, isGrid }) => {
//   const state = useGeneralStore(
//     (store) => store.state[element.ElementName]?.["value"] as string
//   );

//   const setState = useGeneralStore((store) => store.setState);
//   const slotId = useUserStore((store) => store.slotId);

//   const { Size, AllowedTypes } = extractDocumentSettings(
//     element.DocumentSettings || ""
//   );

//   const [loading, setLoading] = useState(false);

//   const src =
//     typeof state === "string" && state.split("#").length > 1
//       ? `${config.URL}/iProofService/api/RemoteGateway/ExplorerDocuments?docId=${state.split("#")[0]
//       }&verNo=0&requestFrom=DE&Rand=0.8229241063356949&slotId=${slotId}`
//       : "";

//   const [isVideoVisible] = useState(false);
//   const [isDragging, setIsDragging] = useState(false);

//   const [fileType, setFileType] = useState("");
//   const [, setFileName] = useState(state);
//   const [base64Data, setBase64Data] = useState<string>();
//   const [documentData, setDocumentData] = useState<{
//     documentNo: string;
//     documentId: string;
//   }>();

//   const fileInputRef = useRef<HTMLInputElement>(null);

//   // ✅ NEW CAMERA REF (ADDED ONLY)
//   const cameraInputRef = useRef<HTMLInputElement>(null);

//   const isMobile =
//     typeof navigator !== "undefined" &&
//     /Android|iPhone|iPad|iPod/i.test(navigator.userAgent);

//   const handleReset = () => {
//     setBase64Data(undefined);
//     setDocumentData(undefined);
//     setFileName("");
//     setFileType("");

//     if (fileInputRef.current) fileInputRef.current.value = "";
//     if (cameraInputRef.current) cameraInputRef.current.value = "";
//   };

//   const handleLoadData = useCallback(async () => {
//     if (!state || !state?.toString().includes("#")) return;

//     try {
//       setLoading(true);

//       const data = await getBase64StringFromUrl(
//         slotId || "",
//         state.toString().split("#")[0],
//         1
//       );

//       if (data.length) {
//         const extension = getExtensionFromBase64(
//           data[0].value.split(",")[0]
//         );

//         if (extension) {
//           setFileType(extension);
//           setBase64Data(data[0].value);
//         }

//         setDocumentData({
//           documentId: data[1].key,
//           documentNo: data[1].value,
//         });
//       }
//     } catch (error) {
//       console.log(error);
//     } finally {
//       setLoading(false);
//     }
//   }, [state, slotId]);

//   useEffect(() => {
//     handleLoadData();
//   }, [handleLoadData]);

//   const processFiles = async (files: FileList | null) => {
//     try {
//       setLoading(true);

//       const result = await resusableOnFileChange(files, {
//         maxSize: Size,
//         ElementName: element.ElementName,
//         isGrid: Boolean(isGrid),
//       });

//       if (result) {
//         setDocumentData({
//           documentId: result.documentId,
//           documentNo: result.documentNo,
//         });

//         setState(element.ElementName, result.documentId);
//         setFileType(result.fileType);
//         setFileName(result.fileName);
//         setBase64Data(result.base64Data);
//       }
//     } catch (error) {
//       console.log(error);
//     } finally {
//       setLoading(false);
//     }
//   };

//   const handleFileChange = async (
//     event: React.ChangeEvent<HTMLInputElement>
//   ) => {
//     await processFiles(event.target.files);
//     event.target.value = "";
//   };

//   const handleDeleteFile = async () => {
//     try {
//       if (!documentData) return;

//       const result = await resusableDeleteDocument({
//         isGrid: Boolean(isGrid),
//         documentId: documentData.documentId,
//         documentNo: documentData.documentNo,
//         elementName: element.ElementName,
//       });

//       if (result) handleReset();
//       if (result) setState(element.ElementName, "");

//     } catch (error) {
//       console.log(error);
//     }
//   };

//   const triggerFileInputClick = () => {
//     fileInputRef.current?.click();
//   };

//   // ✅ NEW: camera trigger
//   const triggerCameraClick = () => {
//     cameraInputRef.current?.click();
//   };

//   const handleDragOver = (e: React.DragEvent<HTMLDivElement>) => {
//     e.preventDefault();
//     setIsDragging(true);
//   };

//   const handleDragLeave = (e: React.DragEvent<HTMLDivElement>) => {
//     e.preventDefault();
//     setIsDragging(false);
//   };

//   const handleDrop = async (e: React.DragEvent<HTMLDivElement>) => {
//     e.preventDefault();
//     setIsDragging(false);
//     await processFiles(e.dataTransfer.files);
//   };


//   const handlePreviewOpen = async () => {
//     if (!base64Data) return;

//     // React Native WebView
//     if ((window as any).ReactNativeWebView) {
//       (window as any).ReactNativeWebView.postMessage(
//         JSON.stringify({
//           type: "OPEN_DOCUMENT",
//           payload: {
//             base64Data,
//             fileType,
//             fileName: state,
//           },
//         })
//       );

//       return;
//     }
//   };

//   return (
//     <div
//       id={element.ElementName}
//       className={`p-2 border rounded-3 shadow-sm bg-white ${element?.Css}`}
//       onClick={(e) => e.stopPropagation()}
//     >
//       <div className="form-group">
//         <div className="InlineSingle">

//           {/* hidden inputs */}
//           <input
//             ref={fileInputRef}
//             type="file"
//             style={{ display: "none" }}
//             accept={AllowedTypes}
//             onChange={handleFileChange}
//           />

//           {/* ✅ NEW CAMERA INPUT (SAFE) */}
//           <input
//             ref={cameraInputRef}
//             type="file"
//             accept="image/*"
//             capture="environment"
//             style={{ display: "none" }}
//             onChange={handleFileChange}
//           />

//           <div className="d-flex justify-content-between align-items-center mb-1 w-100">
//             {element.DCaption}

//             <div className="d-flex justify-content-end w-100 doc-action-Container">

//               <button
//                 className="btn border me-2 bg-light"
//                 onClick={triggerFileInputClick}
//               >
//                 <i className="ph ph-upload"></i>
//               </button>

//               {/* ✅ CAMERA BUTTON (ONLY MOBILE) */}
//               {isMobile && (
//                 <button
//                   className="btn border me-2 bg-light"
//                   onClick={triggerCameraClick}
//                 >
//                   <i className="ph ph-camera"></i>
//                 </button>
//               )}

//               <button
//                 className="btn bg-light border"
//                 onClick={handleDeleteFile}
//               >
//                 <i className="ph ph-trash"></i>
//               </button>
//             </div>
//           </div>

//           <div className="card-body" style={{ overflow: "hidden" }}>
//             <div
//               className="position-relative"
//               style={{
//                 border: isDragging
//                   ? "2px dashed #0d6efd"
//                   : "2px dashed transparent",
//                 borderRadius: "12px",
//               }}
//               onDragOver={handleDragOver}
//               onDragLeave={handleDragLeave}
//               onDrop={handleDrop}
//             >
//               {isVideoVisible ? (
//                 <video controls className="w-100" style={{ height: "auto" }}>
//                   <source src="https://example.com/video.mp4" type="video/mp4" />
//                 </video>
//               ) : (src || base64Data) && (
//                 <>
//                   {/* IMAGE */}
//                   {fileType?.match(/jpg|jpeg|png/i) && (
//                     <div className="img-container" style={{ overflow: "auto" }}>
//                       <img
//                         src={base64Data || src}
//                         alt="Document preview"
//                         onClick={handlePreviewOpen}
//                         style={{
//                           cursor: "pointer",
//                           width: "100%",
//                           height: "auto",
//                           imageRendering: "crisp-edges",
//                         }}
//                       />
//                     </div>
//                   )}

//                   {/* PDF */}
//                   {fileType?.match(/pdf/i) && (
//                     <>
//                       {(window as any).ReactNativeWebView ? (
//                         <div
//                           className="text-center p-4"
//                           onClick={handlePreviewOpen}
//                           style={{
//                             cursor: "pointer",
//                           }}
//                         >
//                           <i
//                             className="ph ph-file-pdf"
//                             style={{ fontSize: "60px" }}
//                           />

//                           <div className="mt-2">
//                             Open PDF
//                           </div>
//                         </div>
//                       ) : (
//                         <iframe
//                           src={base64Data || src}
//                           width="100%"
//                           height="500px"
//                           style={{ border: "none" }}
//                         />
//                       )}
//                     </>
//                   )}

//                   {/* VIDEO */}
//                   {fileType?.match(/mp4/i) && (
//                     <>
//                       {(window as any).ReactNativeWebView ? (
//                         <div
//                           className="text-center p-4"
//                           onClick={handlePreviewOpen}
//                           style={{
//                             cursor: "pointer",
//                           }}
//                         >
//                           <i
//                             className="ph ph-video"
//                             style={{ fontSize: "60px" }}
//                           />

//                           <div className="mt-2">
//                             Open Video
//                           </div>
//                         </div>
//                       ) : (
//                         <video controls className="w-100">
//                           <source src={base64Data || src} type="video/mp4" />
//                         </video>
//                       )}
//                     </>
//                   )}
//                 </>
//               )}

//               {!src && !base64Data && (
//                 <div className="text-center p-3">
//                   Select or capture file
//                 </div>
//               )}

//               {loading && (
//                 <div className="position-absolute top-0 start-0 w-100 h-100 d-flex align-items-center justify-content-center bg-light">
//                   <div className="spinner-border text-primary" />
//                 </div>
//               )}
//             </div>
//           </div>

//         </div>
//       </div>
//     </div>
//   );
// };

// export default InlineSingle;



// Innovace Intech Solution Pvt Ltd
import React, { useCallback, useEffect, useRef, useState } from "react";
import type { UIElement } from "@/constants/types";
import { useGeneralStore } from "@/store/useStore";
import { useUserStore } from "@/store/useUserStore";
import { getBase64StringFromUrl } from "@/services/documentService";
import {
  extractDocumentSettings,
  getExtensionFromBase64,
} from "@/helpers/utils";
import {
  resusableDeleteDocument,
  resusableOnFileChange,
} from "@/components/Events/onFileChange";
import { config } from "@/constants/config";
import UploadGif from "@/assets/gif/upload-file_11677416.gif";
import { resusableOnChange } from "@/components/Events/onChange";

const InlineSingle: React.FC<{
  element: UIElement;
  isGrid?: boolean;
}> = ({ element, isGrid }) => {
  const state = useGeneralStore(
    (store) => store.state[element.ElementName]?.["value"] as string
  );
  

  const setState = useGeneralStore((store) => store.setState);
  const slotId = useUserStore((store) => store.slotId);


  const [progress, setProgress] = useState(0);
  const [loadingMessage, setLoadingMessage] = useState("");

  const { Size, AllowedTypes } = extractDocumentSettings(
    element.DocumentSettings || ""
  );

  const [loading, setLoading] = useState(false);

  const src =
    typeof state === "string" && state.split("#").length > 1
      ? `${config.URL}/iProofService/api/RemoteGateway/ExplorerDocuments?docId=${state.split("#")[0]
      }&verNo=0&requestFrom=DE&Rand=0.8229241063356949&slotId=${slotId}`
      : "";

  const [isVideoVisible] = useState(false);
  const [isDragging, setIsDragging] = useState(false);

  const [fileType, setFileType] = useState("");
  const [, setFileName] = useState(state);
  const [base64Data, setBase64Data] = useState<string>();
  const [documentData, setDocumentData] = useState<{
    documentNo: string;
    documentId: string;
  }>();

  const fileInputRef = useRef<HTMLInputElement>(null);

  // ✅ NEW CAMERA REF (ADDED ONLY)
  const cameraInputRef = useRef<HTMLInputElement>(null);

  const isMobile =
    typeof navigator !== "undefined" &&
    /Android|iPhone|iPad|iPod/i.test(navigator.userAgent);

  const handleReset = () => {
    setBase64Data(undefined);
    setDocumentData(undefined);
    setFileName("");
    setFileType("");

    if (fileInputRef.current) fileInputRef.current.value = "";
    if (cameraInputRef.current) cameraInputRef.current.value = "";
  };

  const handleLoadData = useCallback(async () => {
    if (!state || !state?.toString().includes("#")) return;

   

    try {
      setLoading(true);

      const data = await getBase64StringFromUrl(
        slotId || "",
        state.toString().split("#")[0],
        1
      );

      if (data.length) {
        const extension = getExtensionFromBase64(
          data[0].value.split(",")[0]
        );

        if (extension) {
          setFileType(extension);
          setBase64Data(data[0].value);
        }

        setDocumentData({
          documentId: data[1].key,
          documentNo: data[1].value,
        });
      }
    } catch (error) {
      console.log(error);
    } finally {
      setLoading(false);
    }
  }, [state, slotId]);

  useEffect(() => {
    handleLoadData();
  }, [handleLoadData]);


  const startLoader = () => {
    setLoading(true);

    setProgress(0);
    setLoadingMessage("Preparing document...");

    const interval = setInterval(() => {
      setProgress((prev) => {
        if (prev < 20) {
          setLoadingMessage("Uploading document...");
          return prev + 5;
        }

        if (prev < 60) {
          setLoadingMessage("Extracting content...");
          return prev + 3;
        }

        if (prev < 90) {
          setLoadingMessage("Analyzing document...");
          return prev + 2;
        }

        return prev;
      });
    }, 650);

    return interval;
  };


  const finishLoader = (
    interval: ReturnType<typeof setInterval>
  ) => {
    clearInterval(interval);

    setLoadingMessage("Finalizing...");

    setProgress(100);

    setTimeout(() => {
      setLoading(false);
      setProgress(0);
    }, 600);
  };




  const processFiles = async (files: FileList | null) => {
    try {
      const loader = startLoader();

      const result = await resusableOnFileChange(files, {
        maxSize: Size,
        ElementName: element.ElementName,
        isGrid: Boolean(isGrid),
      });
      if (!result || result == null) {
        finishLoader(loader);
        return;
      }
      if (result) {
        setDocumentData({
          documentId: result.documentId,
          documentNo: result.documentNo,
        });

        setState(element.ElementName, result.documentId);
        setFileType(result.fileType);
        setFileName(result.fileName);
        setBase64Data(result.base64Data);
      }

      finishLoader(loader);
      return result;
    } catch (error) {
      console.log(error);
    } finally {
      setLoading(false);
    }
  };

  const handleFileChange = async (
    event: React.ChangeEvent<HTMLInputElement>
  ) => {
    const file = await processFiles(event.target.files);
    if(file != null) {
      resusableOnChange(element);
    }
    event.target.value = "";
  };

  const handleDeleteFile = async () => {
    try {
      if (!documentData) return;

      const result = await resusableDeleteDocument({
        isGrid: Boolean(isGrid),
        documentId: documentData.documentId,
        documentNo: documentData.documentNo,
        elementName: element.ElementName,
      });

      if (result) handleReset();
      if (result) setState(element.ElementName, "");

    } catch (error) {
      console.log(error);
    }
  };

  const triggerFileInputClick = () => {
    fileInputRef.current?.click();
  };

  // ✅ NEW: camera trigger
  const triggerCameraClick = () => {
    cameraInputRef.current?.click();
  };

  const handleDragOver = (e: React.DragEvent<HTMLDivElement>) => {
    e.preventDefault();
    setIsDragging(true);
  };

  const handleDragLeave = (e: React.DragEvent<HTMLDivElement>) => {
    e.preventDefault();
    setIsDragging(false);
  };

  const handleDrop = async (e: React.DragEvent<HTMLDivElement>) => {
    e.preventDefault();
    setIsDragging(false);
    await processFiles(e.dataTransfer.files);
  };


  const handlePreviewOpen = async () => {
    if (!base64Data) return;

    // React Native WebView
    if ((window as any).ReactNativeWebView) {
      (window as any).ReactNativeWebView.postMessage(
        JSON.stringify({
          type: "OPEN_DOCUMENT",
          payload: {
            base64Data,
            fileType,
            fileName: state,
          },
        })
      );

      return;
    }
  };

  return (
    <div
      id={element.ElementName}
      className={`p-2 border rounded-3 shadow-sm bg-white ${element?.Css}`}
      onClick={(e) => e.stopPropagation()}
    >
      <div className="form-group">
        <div className="InlineSingle">

          {/* hidden inputs */}
          <input
            ref={fileInputRef}
            type="file"
            style={{ display: "none" }}
            accept={AllowedTypes}
            onChange={handleFileChange}
          />

          {/* ✅ NEW CAMERA INPUT (SAFE) */}
          <input
            ref={cameraInputRef}
            type="file"
            accept="image/*"
            capture="environment"
            style={{ display: "none" }}
            onChange={handleFileChange}
          />

          <div className="d-flex justify-content-between align-items-center mb-1 w-100">
            {element.DCaption}

            <div className="d-flex justify-content-end w-100 doc-action-Container">

              <button
                className="btn border me-2 bg-light"
                onClick={triggerFileInputClick}
              >
                <i className="ph ph-upload"></i>
              </button>

              {/* ✅ CAMERA BUTTON (ONLY MOBILE) */}
              {isMobile && (
                <button
                  className="btn border me-2 bg-light"
                  onClick={triggerCameraClick}
                >
                  <i className="ph ph-camera"></i>
                </button>
              )}

              <button
                className="btn bg-light border"
                onClick={handleDeleteFile}
              >
                <i className="ph ph-trash"></i>
              </button>
            </div>
          </div>

          <div className="card-body" style={{ overflow: "hidden" }}>
            <div
              className="position-relative"
              style={{
                border: isDragging
                  ? "2px dashed #0d6efd"
                  : "2px dashed transparent",
                borderRadius: "12px",
              }}
              onDragOver={handleDragOver}
              onDragLeave={handleDragLeave}
              onDrop={handleDrop}
            >
              {isVideoVisible ? (
                <video controls className="w-100" style={{ height: "auto" }}>
                  <source src="https://example.com/video.mp4" type="video/mp4" />
                </video>
              ) : (src || base64Data) && (
                <>
                  {/* IMAGE */}
                  {fileType?.match(/jpg|jpeg|png/i) && (
                    <div className="img-container" style={{ overflow: "auto" }}>
                      <img
                        src={base64Data || src}
                        alt="Document preview"
                        onClick={handlePreviewOpen}
                        style={{
                          cursor: "pointer",
                          width: "100%",
                          height: "auto",
                          imageRendering: "crisp-edges",
                        }}
                      />
                    </div>
                  )}

                  {/* PDF */}
                  {fileType?.match(/pdf/i) && (
                    <>
                      {(window as any).ReactNativeWebView ? (
                        <div
                          className="text-center p-4"
                          onClick={handlePreviewOpen}
                          style={{
                            cursor: "pointer",
                          }}
                        >
                          <i
                            className="ph ph-file-pdf"
                            style={{ fontSize: "60px" }}
                          />

                          <div className="mt-2">
                            Open PDF
                          </div>
                        </div>
                      ) : (
                        <iframe
                          src={base64Data || src}
                          width="100%"
                          height="500px"
                          style={{ border: "none" }}
                        />
                      )}
                    </>
                  )}

                  {/* VIDEO */}
                  {fileType?.match(/mp4/i) && (
                    <>
                      {(window as any).ReactNativeWebView ? (
                        <div
                          className="text-center p-4"
                          onClick={handlePreviewOpen}
                          style={{
                            cursor: "pointer",
                          }}
                        >
                          <i
                            className="ph ph-video"
                            style={{ fontSize: "60px" }}
                          />

                          <div className="mt-2">
                            Open Video
                          </div>
                        </div>
                      ) : (
                        <video controls className="w-100">
                          <source src={base64Data || src} type="video/mp4" />
                        </video>
                      )}
                    </>
                  )}
                </>
              )}

              {!src && !base64Data && (
                <div className="text-center p-3">
                  Select or capture file
                </div>
              )}

              {loading && (
                <div className="doc-loader-overlay">
                  <div className="doc-loader-card">

                    <div className="doc-icon-wrapper">

                      <div className="pulse-ring"></div>

                      <div className="doc-icon">
                        <img
                          src={UploadGif}
                          alt="Uploading"
                          className="doc-loader-gif"
                        />
                      </div>

                    </div>

                    <div className="loader-title">
                      {loadingMessage}
                    </div>

                    <div className="loader-progress-wrapper">

                      <div className="progress modern-progress">
                        <div
                          className="progress-bar"
                          style={{
                            width: `${progress}%`
                          }}
                        />
                      </div>

                      <span className="loader-progress-text">
                        {progress}%
                      </span>

                    </div>

                  </div>
                </div>
              )}
            </div>
          </div>

        </div>
      </div>
    </div>
  );
};

export default InlineSingle;