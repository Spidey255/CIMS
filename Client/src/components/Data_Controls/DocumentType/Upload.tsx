// Innovace Intech Solution Pvt Ltd
import React, { useRef, useState } from "react";

import type { UIElement } from "@/constants/types";
import { downloadFile } from "@/helpers/utils";
import { useGeneralStore } from "@/store/useStore";
import { extractDocumentSettings } from "@/helpers/utils";
import {
  resusableDeleteDocument,
  resusableOnFileChange,
} from "@/components/Events/onFileChange";

const Upload: React.FC<{
  element: UIElement;
  isGrid?: boolean;
}> = ({ element, isGrid }) => {
  const state = useGeneralStore(
    (store) => store.state[element.ElementName]?.["value"] as string
  );
  const setState = useGeneralStore((store) => store.setState);
  const [, setFileType] = useState("");
  const [fileName, setFileName] = useState(state);
  const [base64Data, setBase64Data] = useState<string>();
  const [documentData, setDocumentData] = useState<{
    documentNo: string;
    documentId: string;
  }>();
  const fileInputRef = useRef<HTMLInputElement>(null);

  const { Size, AllowedTypes } = extractDocumentSettings(
    element.DocumentSettings || ""
  );

  const handleReset = () => {
    setBase64Data(undefined);
    setDocumentData(undefined);
    setFileName("");
    setFileType("");
  };

  const handleDownloadFile = () => {
    if (base64Data) downloadFile(fileName, base64Data);
  };

  const handleFileChange = async (
    event: React.ChangeEvent<HTMLInputElement>
  ) => {
    try {
      const result = await resusableOnFileChange(event.target.files, {
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
    }
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
        setState(element.ElementName, "");
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
                className="btn btn-default  btn-icon"
                title="Upload"
                onClick={triggerFileInputClick}
              >
                <i className="ph ph-upload"></i>
              </a>
              {/* Download Button */}
              <a
                className="btn btn-default  btn-icon"
                title="Download"
                onClick={handleDownloadFile}
              >
                <i className="ph ph-download"></i>
              </a>
              {/* Clear Button */}
              <a
                className="btn btn-default  btn-icon"
                title="Clear"
                onClick={handleDeleteFile}
              >
                <i className="ph ph-trash"></i>
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
    </div>
  );
};

export default Upload;
