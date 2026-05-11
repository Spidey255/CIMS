// Innovace Intech Solution Pvt Ltd
import React, { useCallback, useEffect, useRef, useState } from "react";

import type { IInlineMultiFile, UIElement } from "@/constants/types";
import { useGeneralStore } from "@/store/useStore";
import {
  downloadFile,
  extractDocumentSettings,
  getExtensionFromBase64,
} from "@/helpers/utils";
import { getBase64StringFromUrl } from "@/services/documentService";
import { DocumentViewerModal } from "@/components/DocumentViewer";
import {
  resusableDeleteDocument,
  resusableOnFileChange,
} from "@/components/Events/onFileChange";
import { useUserStore } from "@/store/useUserStore";

const UploadAndView: React.FC<{
  element: UIElement;
  isGrid?: boolean;
}> = ({ element, isGrid }) => {
  const state = useGeneralStore(
    (store) => store.state[element.ElementName]?.["value"] as string
  );
  const setState = useGeneralStore((store) => store.setState);
  const slotId = useUserStore((store) => store.slotId);
  const fileInputRef = useRef<HTMLInputElement>(null);
  const [files, setFiles] = useState<IInlineMultiFile[]>([]);
  const [isModalOpen, setIsModalOpen] = useState(false);

  const { Size, AllowedTypes } = extractDocumentSettings(
    element.DocumentSettings || ""
  );

  const handleLoadData = useCallback(async () => {
    if (!state || !state?.toString().includes("#")) return;

    try {
      const data = await getBase64StringFromUrl(
        slotId || "",
        state.toString().split("#")[0],
        1
      );

      if (data.length) {
        const extension = getExtensionFromBase64(data[0].value.split(",")[0]);
        if (extension) {
          setFiles(() => [
            {
              base64Data: data[0].value,
              documentId: data[1].key,
              documentNo: data[1].value,
              fileName: state.toString().split("#")[1],
              fileType: extension,
            },
          ]); // Overwrite existing files with the new one
        }
      }
    } catch (error) {
      console.log(error);
    }
  }, [state, slotId]);

  useEffect(() => {
    handleLoadData();
  }, [handleLoadData]);



  const handleDeleteFile = async (fileInfo: IInlineMultiFile) => {
    try {
      const result = await resusableDeleteDocument({
        isGrid: Boolean(isGrid),
        documentId: fileInfo.documentId,
        documentNo: fileInfo.documentNo,
        elementName: element.ElementName,
      });
      if (result) {
        setFiles((f) => f.filter((f) => f.documentId !== fileInfo.documentId));

      }
    } catch (error) {
      console.log(error);
    }
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
        // Replace existing file with the new one
        setFiles([result]); // Ensuring only the new file is in the state
        setState(element.ElementName, result.documentId);
      }
    } catch (error) {
      console.log(error);
    }
  };


  const handleDownloadFile = (fileInfo: IInlineMultiFile) => {
    downloadFile(fileInfo.fileName, fileInfo.base64Data);
  };

  const triggerFileInputClick = () => {
    if (fileInputRef.current) {
      fileInputRef.current.click();
    }
  };

  const fileName = !files.length ? "" : files[0].fileName;

  return (
    <>
      <div
        className={element.ColumnCss}
        id={element.ElementId}
        onClick={(e) => e.stopPropagation()}
      >
        <div className="form-group">
          {!isGrid && Boolean(element["ShowCaption"]) ? (
            <label className="form-label">{element["DCaption"]}</label>
          ) : null}
          <span className="text-danger"></span>
          <div className="controls">
            <div
              className="input-group input-group-xs form-control p-0 "
              data-toggle="popover"
              data-placement="top"
            >
              <span
                className="form-control border-end border-0"
                style={{ textOverflow: "ellipsis", overflow: "hidden" }}
                title={fileName}
              >
                {!fileName
                  ? "No file selected"
                  : fileName.includes("#")
                    ? fileName.split("#")[1]
                    : fileName}
              </span>
              <div className="input-group-btn bg-light rounded-3">
                <a
                  className="btn btn-default btn-icon"
                  title="Upload"
                  onClick={triggerFileInputClick}
                >
                  <i className="ph ph-upload"></i>
                </a>

                <>
                  <a
                    className="btn btn-default btn-icon"
                    title="Download"
                    onClick={() => files.length && handleDownloadFile(files[0])}
                    style={{
                      pointerEvents: fileName ? "auto" : "none",
                      opacity: fileName ? 1 : 0.5
                    }}
                  >
                    <i className="ph ph-download"></i>
                  </a>
                  <a
                    className="btn btn-default btn-icon"
                    title="View"
                    onClick={() => setIsModalOpen(true)}
                    style={{
                      pointerEvents: fileName ? "auto" : "none",
                      opacity: fileName ? 1 : 0.5
                    }}
                  >
                    <i className="ph ph-arrow-square-out"></i>
                  </a>
                  <a
                    className="btn btn-default btn-icon"
                    title="Clear"
                    onClick={() => files.length && handleDeleteFile(files[0])}
                    style={{
                      pointerEvents: fileName ? "auto" : "none",
                      opacity: fileName ? 1 : 0.5
                    }}
                  >
                    <i className="ph ph-trash"></i>
                  </a>
                </>



                <div style={{ display: "none" }}>
                  <input
                    ref={fileInputRef}
                    type="file"
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
          base64Data={files.length ? files[0].base64Data : ""}
        />
      </div>
    </>
  );
};

export default UploadAndView;
