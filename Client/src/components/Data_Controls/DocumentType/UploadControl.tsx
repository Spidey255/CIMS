// Innovace Intech Solution Pvt Ltd
import React, { useEffect, useRef, useState } from "react";

import type { UIElement } from "@/constants/types";
import { useGeneralStore } from "@/store/useStore";
import { extractDocumentSettings } from "@/helpers/utils";
import { DocumentViewerModal } from "@/components/DocumentViewer";
import { resusableOnFileChange } from "@/components/Events/onFileChange";

const UploadControl: React.FC<{
  element: UIElement;
  isGrid?: boolean;
}> = ({ element, isGrid }) => {
  const state = useGeneralStore(
    (store) => store.state[element.ElementName]?.["value"] as string
  );

  const setState = useGeneralStore((store) => store.setState);
  const [fileName, setFileName] = useState(state);
  const [base64Data, setBase64Data] = useState<string>();
  const fileInputRef = useRef<HTMLInputElement>(null);
  const [isModalOpen, setIsModalOpen] = useState(false);
  const { Size, AllowedTypes } = extractDocumentSettings(
    element.DocumentSettings || ""
  );

  useEffect(() => {
    if (state && fileName == undefined || fileName == null) {
      // const extractedFileName = state.split("#")[1] || "No file selected";
      setFileName(state);
    }
  }, [state]);



  const handleFileChange = async (
  event: React.ChangeEvent<HTMLInputElement>
) => {
  try {
    const files = event.target.files;

    if (!files || files.length === 0) return;

    const result = await resusableOnFileChange(files, {
      maxSize: Size,
      ElementName: element.ElementName,
      isGrid: Boolean(isGrid),
    });

    if (result) {
      setFileName(result.fileName);
      setBase64Data(result.base64Data);
      setState(element.ElementName, result.documentId);
    }

    // ✅ IMPORTANT FIX: reset input so same file can be selected again
    event.target.value = "";

  } catch (error) {
    console.log(error);
  }
};

 const triggerFileInputClick = () => {
  if (fileInputRef.current) {
    fileInputRef.current.value = ""; // ✅ reset before click
    fileInputRef.current.click();
  }
};

  return (
    <div
      className={element.ColumnCss}
      id={element.ElementName}
      onClick={(e) => e.stopPropagation()}
    >
      <div className="form-group">
        {!isGrid && Boolean(element["ShowCaption"]) ? (
          <label className="form-label">{element["DCaption"]}</label>
        ) : null}
        <span className="text-danger"></span>
        <div className="controls">
          <div
            className="input-group input-group-xs form-control p-0"
            data-toggle="popover"
            data-placement="top"
          >
            <span
              className="form-control input-xs border-end border-0"
              style={{ textOverflow: "ellipsis", overflow: "hidden" }}
            >
              {!fileName
                ? "No file selected"
                : fileName?.toString().includes("#")
                  ? fileName?.toString().split("#")[1]
                  : fileName?.toString()}
            </span>
            <div className="input-group-btn bg-light rounded-3">
              {/* Upload Button */}
              <a
                className="btn btn-default e btn-icon"
                title="Upload"
                onClick={triggerFileInputClick}
              >
                <i className="ph ph-upload"></i>
              </a>
              <a
                className="btn btn-default  btn-icon"
                title="View"
                onClick={() => setIsModalOpen(true)}
              >
                <i className="ph ph-arrow-square-out"></i>
              </a>
              {/* Hidden File Input */}
              <div style={{ display: "none" }}>
                <input
                  ref={fileInputRef}
                  type="file"
                  id={`inp_${element.ElementName}`}
                  accept={AllowedTypes}
                  data-maxfilesize={Size}
                  onChange={handleFileChange}
                />
              </div>
            </div>
          </div>
        </div>
      </div>
      <DocumentViewerModal
        isOpen={isModalOpen}
        onClose={() => setIsModalOpen(false)}
        base64Data={base64Data || ""}
      />
    </div>
  );
};

export default UploadControl;
