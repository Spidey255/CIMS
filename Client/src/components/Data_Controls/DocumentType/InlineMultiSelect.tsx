// Innovace Intech Solution Pvt Ltd
import { useRef, useState, useCallback } from "react";
import toast from "react-hot-toast";
import { useUserStore } from "@/store/useUserStore";
import type { UIElement, IInlineMultiFile } from "@/constants/types";
import { deleteDocument } from "@/services/documentService";
import { extractDocumentSettings } from "@/helpers/utils";
import { config } from "@/constants/config";
import DocumentViewerModal from "@/components/DocumentViewer/DocumentViewerModal";
import { resusableOnFileChange } from "@/components/Events/onFileChange";

const InlineMultiSelect: React.FC<{
  element: UIElement;
  isGrid?: boolean;
}> = ({ element, isGrid }) => {
  const slotId = useUserStore((store) => store.slotId);
  const fileInputRef = useRef<HTMLInputElement>(null);
  const [files, setFiles] = useState<IInlineMultiFile[]>([]);

  const { Size } = extractDocumentSettings(element.DocumentSettings || "");

  const getFileIcon = useCallback((fileType: string) => {
    fileType = fileType.toLowerCase();

    if (config.SUPPORTED_SPREADSHEET_FORMAT.includes(fileType)) {
      return <i className="fa fa-file-excel text-success "></i>;
    }
    if (config.SUPPORTED_DOCUMENT_FORMAT.includes(fileType)) {
      return <i className="fa fa-file-word text-primary display-5"></i>;
    }
    if (config.SUPPORTED_PDF_FORMAT.includes(fileType)) {
      return <i className="fa fa-file-pdf text-danger display-5"></i>;
    }
    if (config.SUPPORTED_VIDEO_FORMAT.includes(fileType)) {
      return <i className="fa fa-file-video text-warning display-5"></i>;
    }
    return <i className="fa fa-file fs-1 text-secondary display-5"></i>;
  }, []);

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
      const controlId = isGrid
        ? element["ElementName"].split("+")[2]
        : element["ElementName"];

      const data = await deleteDocument({
        slotId: slotId || "",
        documentId: fileInfo.documentId,
        documentNo: fileInfo.documentNo,
        documentTypeId: controlId,
      });

      if (data === 1) {
        toast.error("File delete failed");
      } else {
        toast.success("File deleted successfully");
        setFiles((f) => f.filter((f) => f.documentNo !== fileInfo.documentNo));
      }
    } catch (error) {
      console.log(error);
    }
  };

  const triggerFileInputClick = () => {
    fileInputRef.current?.click();
  };

  return (
    <div className={element.ColumnCss} id={element.ElementName}>
      <div className="mb-2">
        {!isGrid && Boolean(element["ShowCaption"]) && (
          <label className="form-label fw-semibold">
            {element["DCaption"]}
          </label>
        )}

        <div className=" shadow-sm border rounded-2">
          <div className=" p-2">
            <div className="d-flex align-items-start gap-2">
              {/* Upload */}
              <div>
                <input
                  ref={fileInputRef}
                  multiple
                  type="file"
                  style={{ display: "none" }}
                  onChange={handleFileChange}
                />
                <a
                  type="button"
                  className="bg-light btn border"
                  onClick={triggerFileInputClick}
                >
                  <i className="ph ph-upload"></i> 
                </a>
              </div>

              {/* Files */}
              <div className="flex-grow-1">
                {files.length === 0 ? (
                  <div className="text-muted small fst-italic">
                    No documents uploaded
                  </div>
                ) : (
                  <div className="row g-2">
                    {files.map((currentFile) => (
                      <FileGridItem
                        key={currentFile.documentNo}
                        currentFile={currentFile}
                        handleDeleteFile={handleDeleteFile}
                        getFileIcon={getFileIcon}
                      />
                    ))}
                  </div>
                )}
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  );
};

const FileGridItem = ({
  currentFile,
  handleDeleteFile,
  getFileIcon,
}: {
  currentFile: IInlineMultiFile;
  handleDeleteFile: (fileInfo: IInlineMultiFile) => void;
  getFileIcon: (fileType: string) => React.ReactNode;
}) => {
  const [isOpen, setIsOpen] = useState(false);

  return (
    <div className="col-6 col-sm-4 col-md-3 col-lg-2">
      <div className="border rounded p-2 h-100 bg-light text-center">
        <div className="mb-1 d-flex justify-content-center align-content-center" style={{ height: 70 }}>
          {config.SUPPORTED_IMAGE_FORMAT.includes(currentFile.fileType) ? (
            <img
              src={currentFile.base64Data}
              alt={currentFile.fileName}
              className="img-fluid h-100"
              style={{ objectFit: "contain" }}
            />
          ) : (
            getFileIcon(currentFile.fileType)
          )}
        </div>

        <div
          className="small text-truncate"
          title={currentFile.fileName}
        >
          {currentFile.fileName}
        </div>

        <div className="d-flex justify-content-center gap-1 mt-2">
          <button
            className="bg-light btn border "
            onClick={() => setIsOpen(true)}
          >
            <i className="ph ph-arrow-square-out"></i>
          </button>
          <button
            className="bg-light btn border "
            onClick={() => handleDeleteFile(currentFile)}
          >
            <i className="ph ph-trash"></i>
          </button>
        </div>

        <DocumentViewerModal
          isOpen={isOpen}
          onClose={() => setIsOpen(false)}
          base64Data={currentFile.base64Data}
        />
      </div>
    </div>
  );
};

export default InlineMultiSelect;
