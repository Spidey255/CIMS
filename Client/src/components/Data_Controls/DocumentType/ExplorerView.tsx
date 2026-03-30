// Innovace Intech Solution Pvt Ltd
import React, { useRef, useState } from "react";
import type { UIElement, IInlineMultiFile } from "@/constants/types";
import { extractDocumentSettings } from "@/helpers/utils";
import {
  resusableOnFileChange,
  resusableDeleteDocument,
} from "@/components/Events/onFileChange";
import { DocumentViewerModal } from "@/components/DocumentViewer";

const ExploreView: React.FC<{
  element: UIElement;
  isGrid?: boolean;
}> = ({ element, isGrid }) => {
  const [view, setView] = useState<"List" | "Tiles">("List");
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
    } catch (err) {
      console.log(err);
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
        setFiles((f) =>
          f.filter((f) => f.documentNo !== fileInfo.documentNo)
        );
      }
    } catch (err) {
      console.log(err);
    }
  };

  return (
    <div className={element.ColumnCss} id={element.ElementName}>
      {/* <label className="form-label fw-semibold mb-2">
        {element.ElementName}
      </label> */}

      <div className="ev-card border rounded-3">
        {/* HEADER */}
        <div className="ev-header border-0 border-bottom border-2 bg-light">
          <div>
            <h6 className="mb-0">{element.ElementName}</h6>
            <small className="text-muted">
              Upload & manage files securely
            </small>
          </div>

          <div className="d-flex gap-2">
            <button
              className="btn border"
              onClick={() => fileInputRef.current?.click()}
            >
              <i className="ph ph-upload"></i>
            </button>

            <button
              className={`btn border ${
                view === "List" ? "bg-primary" : " "
              }`}
              onClick={() => setView("List")}
            >
              <i  className={`ph ph-list-plus ${
                view === "List" ? "text-white" : ""
              }`} ></i>
            </button>

            <button
              className={`btn border ${
                view === "Tiles" ? "bg-primary" : ""
              }`}
              onClick={() => setView("Tiles")}
            >
              <i  className={`ph ph-squares-four ${
                view === "Tiles" ? "text-white" : ""
              }`} ></i>
            </button>
          </div>

          <input
            ref={fileInputRef}
            type="file"
            hidden
            multiple
            onChange={handleFileChange}
            accept={AllowedTypes}
          />
        </div>

        {/* BODY */}
        <div className="ev-body">
          {files.length === 0 && (
            <div className="ev-empty">
              <i className="fa fa-cloud-upload fa-3x mb-3"></i>
              <h6>No documents yet</h6>
              <p className="text-muted">
                Click upload to add your first document
              </p>
            </div>
          )}

          {/* LIST VIEW */}
          {view === "List" && files.length > 0 && (
            <ul className="list-group list-group-flush">
              {files.map((doc) => (
                <ListItem
                  key={doc.documentNo}
                  doc={doc}
                  handleDeleteFile={handleDeleteFile}
                />
              ))}
            </ul>
          )}

          {/* TILE VIEW */}
          {view === "Tiles" && files.length > 0 && (
            <div className="row g-3">
              {files.map((doc) => (
                <TileItem
                  key={doc.documentNo}
                  doc={doc}
                  handleDeleteFile={handleDeleteFile}
                />
              ))}
            </div>
          )}
        </div>
      </div>
    </div>
  );
};

const ListItem = ({
  doc,
  handleDeleteFile,
}: {
  doc: IInlineMultiFile;
  handleDeleteFile: (fileInfo: IInlineMultiFile) => void;
}) => {
  const [isOpen, setIsOpen] = useState(false);

  return (
    <li className="list-group-item ev-list-item">
      <div onClick={() => setIsOpen(true)} className="ev-file">
        <i className="fa fa-file-pdf-o text-danger me-2"></i>
        <span className="text-truncate">{doc.fileName}</span>
      </div>

      <button
        className="btn btn-sm btn-outline-danger"
        onClick={() => handleDeleteFile(doc)}
      >
        <i className="fa fa-trash"></i>
      </button>

      <DocumentViewerModal
        isOpen={isOpen}
        onClose={() => setIsOpen(false)}
        base64Data={doc.base64Data}
      />
    </li>
  );
};

const TileItem = ({
  doc,
  handleDeleteFile,
}: {
  doc: IInlineMultiFile;
  handleDeleteFile: (fileInfo: IInlineMultiFile) => void;
}) => {
  const [isOpen, setIsOpen] = useState(false);

  return (
    <div className="col-xl-3 col-lg-4 col-md-6">
      <div className="ev-tile">
        <div
          className="ev-tile-icon"
          onClick={() => setIsOpen(true)}
        >
          <i className="fa fa-file-pdf-o"></i>
        </div>

        <div className="ev-tile-name" title={doc.fileName}>
          {doc.fileName}
        </div>

        <button
          className="btn btn-sm btn-outline-danger"
          onClick={() => handleDeleteFile(doc)}
        >
          <i className="fa fa-trash"></i>
        </button>

        <DocumentViewerModal
          isOpen={isOpen}
          onClose={() => setIsOpen(false)}
          base64Data={doc.base64Data}
        />
      </div>
    </div>
  );
};

export default ExploreView;
