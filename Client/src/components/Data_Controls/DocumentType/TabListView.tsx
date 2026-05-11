// Innovace Intech Solution Pvt Ltd
import React, { Fragment, useRef, useState } from "react";
import type { UIElement, IInlineMultiFile } from "@/constants/types";
import { extractDocumentSettings } from "@/helpers/utils";
import { DocumentViewerModal } from "@/components/DocumentViewer";
import {
  resusableDeleteDocument,
  resusableOnFileChange,
} from "@/components/Events/onFileChange";

const TabListView: React.FC<{
  element: UIElement;
  isGrid?: boolean;
}> = ({ element, isGrid }) => {
  const fileInputRef = useRef<HTMLInputElement>(null);
  const [files, setFiles] = useState<IInlineMultiFile[]>([]);
  const { Size, AllowedTypes } = extractDocumentSettings(
    element.DocumentSettings || ""
  );

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
        setFiles((f) => [...f, result]);
      }
    } catch (error) {
      console.log(error);
    }
  };

  const handleDeleteFile = async (fileInfo: IInlineMultiFile) => {
    try {
      const result = await resusableDeleteDocument({
        isGrid: Boolean(isGrid),
        documentId: fileInfo.documentId,
        documentNo: fileInfo.documentNo,
        elementName: element.ElementName,
      });
      if (result) {
        setFiles((f) => f.filter((f) => f.documentNo !== fileInfo.documentNo));
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
            className="TabListView"
            data-toggle="popodata-ver"
            data-placement="top"
          >
            <div className="form-group">
              <div className="content">
                <div className="tabbable tab-content-bordered gobalTab">
                  <ul className="nav nav-tabs">
                    <li className="active">
                      <a
                        className="dms"
                        data-toggle="tab"
                        href={`#dvDoctbCnt${element.ElementName}`}
                      >
                        <span>Process Documents</span>
                      </a>
                    </li>
                  </ul>
                  <div className="tab-content InboxCustomTable">
                    <div className="tab-pane has-padding fade active in">
                      <div className="datatable-scroll TabListViewTab">
                        <div className="MultiLeftDoc">
                          <input
                            ref={fileInputRef}
                            type="file"
                            id={`inp_${element.ElementName}`}
                            accept={AllowedTypes}
                            data-maxfilesize={Size}
                            onChange={handleFileChange}
                            style={{ display: "none" }}
                          />
                          <a
                            className="btn btn-success dropdown-toggle btn-icon"
                            onClick={triggerFileInputClick}
                          >
                            <i className="fa fa-plus position-left"></i>
                          </a>
                        </div>
                        <div className="MultiRightDoc">
                          <div
                            className="slick-initialized slick-slider"
                            style={{
                              height: "160px",
                              width: "100%",
                              textIndent: "12px",
                            }}
                          >
                            <div
                              aria-live="polite"
                              className="slick-list draggable"
                            >
                              <div
                                className="slick-track"
                                style={{
                                  opacity: 1,
                                  width: "374px",
                                  left: "0px",
                                }}
                                role="listbox"
                              >
                                {files.map((currentFile) => (
                                  <FileItem
                                    key={currentFile.documentNo}
                                    currentFile={currentFile}
                                    handleDeleteFile={handleDeleteFile}
                                  />
                                ))}
                              </div>
                            </div>
                          </div>
                        </div>
                      </div>
                    </div>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  );
};

const FileItem = ({
  currentFile,
  handleDeleteFile,
}: {
  currentFile: IInlineMultiFile;
  handleDeleteFile: (fileInfo: IInlineMultiFile) => void;
}) => {
  const [isOpen, setIsOpen] = useState(false);
  return (
    <Fragment>
      <div
        className="slick-slide slick-current slick-active"
        data-slick-index="0"
        aria-hidden="false"
        tabIndex={-1}
        aria-describedby="slick-slide10"
        style={{ width: "177px" }}
      >
        <div className="MultiSlideBtn">
          <button
            title="View Document"
            className="btn btn-success picviewer"
            type="button"
            tabIndex={0}
            onClick={() => setIsOpen(true)}
          >
            <i className="icon-touch-zoom"></i>
          </button>
          <button
            className="btn btn-danger imgdel"
            title="Delete Document"
            type="button"
            tabIndex={0}
            onClick={() => handleDeleteFile(currentFile)}
          >
            <i className="icon-cross"></i>
          </button>
        </div>
        <i>
          <svg
            xmlns="http://www.w3.org/2000/svg"
            width="128"
            height="128"
            style={{
              shapeRendering: "geometricPrecision",
              textRendering: "geometricPrecision",
              imageRendering: "auto",
              fillRule: "evenodd",
              clipRule: "evenodd",
            }}
          >
            <path
              style={{ opacity: 0.996 }}
              fill="#e0e5e9"
              d="M9.5-.5h62v13h13a1393.255 1393.255 0 0 1-53 1.5 119.035 119.035 0 0 0-1 21.5h-13v4h13v8h-13v4h13v8h-13v5h13v8h-13v4h13v8h-13v4h13v8h-13v4h13v14a108.41 108.41 0 0 1-20.5-1c-.5-37.999-.667-75.999-.5-114z"
            />
            <path
              style={{ opacity: 0.987 }}
              fill="#d7d8dd"
              d="M71.5-.5h1c4.306 3.64 8.306 7.64 12 12v1h-13v-13z"
            />
            <path
              style={{ opacity: 0.997 }}
              fill="#eaeff2"
              d="M84.5 11.5c2.555.888 5.221 1.221 8 1-.166 8.007 0 16.007.5 24a153.913 153.913 0 0 0 24.5 1v90h-87v-92c-.313-7.255.02-14.421 1-21.5 17.838-.168 35.505-.668 53-1.5v-1z"
            />
            <path
              style={{ opacity: 1 }}
              fill="#d6d7dc"
              d="M92.5 12.5c8.667 8 17 16.333 25 25a153.913 153.913 0 0 1-24.5-1c-.5-7.993-.666-15.993-.5-24z"
            />
          </svg>
        </i>
        <a tabIndex={0}>{currentFile.fileName}</a>
      </div>
      <DocumentViewerModal
        isOpen={isOpen}
        onClose={() => setIsOpen(false)}
        base64Data={currentFile.base64Data}
      />
    </Fragment>
  );
};

export default TabListView;
