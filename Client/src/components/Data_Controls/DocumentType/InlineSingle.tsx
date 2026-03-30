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

const InlineSingle: React.FC<{
  element: UIElement;
  isGrid?: boolean;
}> = ({ element, isGrid }) => {
  const state = useGeneralStore(
    (store) => store.state[element.ElementName]?.["value"] as string
  );
  const slotId = useUserStore((store) => store.slotId);
  const { Size, AllowedTypes } = extractDocumentSettings(
    element.DocumentSettings || ""
  );
  const [loading, setLoading] = useState(false);

  const src =
    typeof state === "string" && state.split("#").length > 1
      ? `http://210.18.135.72/iProofService/api/RemoteGateway/ExplorerDocuments?docId=${state.split("#")[0]
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

  const handleReset = () => {
    setBase64Data(undefined);
    setDocumentData(undefined);
    setFileName("");
    setFileType("");
    if (fileInputRef.current) {
      fileInputRef.current.value = ""; // <-- reset the file input itself
    }
  };

  const handleLoadData = useCallback(async () => {
    if (!state || !state?.toString().includes("#")) return;

    try {
      setLoading(true); // ✅ ADD

      const data = await getBase64StringFromUrl(
        slotId || "",
        state.toString().split("#")[0],
        1
      );

      if (data.length) {
        const extension = getExtensionFromBase64(data[0].value.split(",")[0]);
        if (extension) {
          setFileType(extension);
          setBase64Data(data[0].value);
        }

        setDocumentData({ documentId: data[1].key, documentNo: data[1].value });
      }
    } catch (error) {
      console.log(error);
    } finally {
      setLoading(false); // ✅ ADD
    }
  }, [state, slotId]);
  useEffect(() => {
    handleLoadData();
  }, [handleLoadData]);

  const processFiles = async (files: FileList | null) => {
    try {
      setLoading(true); // ✅ ADD

      const result = await resusableOnFileChange(files, {
        maxSize: Size,
        ElementName: element.ElementName,
        isGrid: Boolean(isGrid),
      });

      if (result) {
        setDocumentData({
          documentId: result.documentId,
          documentNo: result.documentNo,
        });
        setFileType(result.fileType);
        setFileName(result.fileName);
        setBase64Data(result.base64Data);
      }
    } catch (error) {
      console.log(error);
    } finally {
      setLoading(false); // ✅ ADD
    }
  };

  const handleFileChange = async (
    event: React.ChangeEvent<HTMLInputElement>
  ) => {
    await processFiles(event.target.files);
    event.target.value = "";
    // resusableOnChange(element);
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

      if (result) {
        handleReset();
      }
    } catch (error) {
      console.log(error);
    }
  };

  const triggerFileInputClick = () => {
    if (fileInputRef.current) {
      fileInputRef.current.click();
    }
  };

  const handleDragOver = (e: React.DragEvent<HTMLDivElement>) => {
    e.preventDefault();
    e.stopPropagation();
    setIsDragging(true);
  };

  const handleDragLeave = (e: React.DragEvent<HTMLDivElement>) => {
    e.preventDefault();
    e.stopPropagation();
    setIsDragging(false);
  };

  const handleDrop = async (e: React.DragEvent<HTMLDivElement>) => {
    e.preventDefault();
    e.stopPropagation();
    setIsDragging(false);

    const files = e.dataTransfer.files;
    await processFiles(files);
  };

  return (
    <>
      <div
        id={element.ElementName}
        className={`p-2 border rounded-3 shadow-sm bg-white ${element?.Css}`}
        onClick={(e) => e.stopPropagation()}
      >
        <div className="form-group">
          <div className="controls">
            <div className="InlineSingle" data-toggle="popover">
              <div className="d-flex justify-content-between align-items-center mb-1 w-100">
                <input
                  ref={fileInputRef}
                  type="file"
                  style={{ display: "none" }}
                  accept={AllowedTypes}
                  onChange={handleFileChange}
                />
                {element.DCaption}
                <div className="d-flex justify-content-end w-100 doc-action-Container">
                  <button
                    className="btn border me-2 bg-light"
                    title="Upload .jpg, .jpeg, .png, .mp4 (Max: 10MB)"
                    onClick={triggerFileInputClick}
                  >
                    <i className="ph ph-upload"></i>
                  </button>
                  <button
                    className="btn btn-primary me-2"
                    style={{ display: "none" }}
                  >
                    <i className="bi bi-camera"></i> Capture
                  </button>
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

                    border: isDragging ? "2px dashed #0d6efd" : "2px dashed transparent",
                    borderRadius: "12px",
                    background: isDragging ? "#f8fbff" : "transparent",
                    transition: "all 0.2s ease",
                  }}
                  onDragOver={handleDragOver}
                  onDragEnter={handleDragOver}
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
                            onClick={triggerFileInputClick}
                            style={{
                              cursor: "pointer",
                              width: "100%",       // use container width
                              height: "auto",      // keep aspect ratio
                              imageRendering: "crisp-edges" // default, can try "crisp-edges" or "pixelated"
                            }}
                          />
                        </div>

                      )}

                      {/* PDF */}
                      {fileType?.match(/pdf/i) && (
                        <iframe
                          src={base64Data || src}
                          width="100%"
                          height="100%"
                          style={{ border: "none" }}
                        />
                      )}

                      {/* VIDEO */}
                      {fileType?.match(/mp4/i) && (
                        <video controls className="w-100">
                          <source src={base64Data || src} type="video/mp4" />
                        </video>
                      )}
                    </>
                  )}

                  {!src && !base64Data && (
                    <div className="d-flex justify-content-center h-100">
                      <div className="align-items-center text-align-center d-flex justify-content-center flex-column gap-1">
                        <i className="ph ph-cloud-arrow-up display-6"></i>
                        <div className="align-items-center text-align-center d-flex justify-content-center flex-column gap-0">
                          Select a file drag and drop here
                          <div className="text-muted">
                            JPG, PNG or PDF, file size no more than 10MB
                          </div>
                        </div>
                      </div>
                    </div>
                  )}

                  {isDragging && (
                    <div
                      className="position-absolute top-50 start-50 translate-middle text-primary fw-semibold"
                      style={{ pointerEvents: "none" }}
                    >
                      Drop file here
                    </div>
                  )}

                  {loading && (
                    <div
                      className="position-absolute top-0 start-0 w-100 h-100 d-flex align-items-center justify-content-center"
                      style={{
                        background: "rgba(255,255,255,0.65)",
                        backdropFilter: "blur(3px)",
                        zIndex: 20,
                        borderRadius: "12px",
                      }}
                    >
                      <div className="text-center">
                        <div className="spinner-border text-primary" role="status" />
                        <div className="mt-2 small fw-semibold text-primary">
                          Uploading...
                        </div>
                      </div>
                    </div>
                  )}
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </>
  );
};

export default InlineSingle;