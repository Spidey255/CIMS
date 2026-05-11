// Innovace Intech Solution Pvt Ltd
import React, { useEffect, useRef, useCallback } from "react";
import { createPortal } from "react-dom";
import { getExtensionFromBase64 } from "../../helpers/utils";
import { config } from "../../constants/config";
import ImageViewer from "./ImageViewer";
import VideoViewer from "./VideoViewer";
import PDFViewer from "./PDFViewer";
import WordViewer from "./WordViewer";
import ExcelViewer from "./ExcelViewer";

interface DocumentViewerModalProps {
  isOpen: boolean;
  onClose: () => void;
  base64Data: string;
  // optional override width in vw (default 70)
  widthVW?: number;
}

const DocumentViewerModal: React.FC<DocumentViewerModalProps> = ({
  isOpen,
  onClose,
  base64Data,
  widthVW = 70,
}) => {
  const drawerRef = useRef<HTMLDivElement | null>(null);
  const previouslyFocused = useRef<Element | null>(null);

  // determine extension (same logic you used)
  const fileExtension =
    getExtensionFromBase64((base64Data || "").split(",")[0]) || "";

  // preserve original viewer selection logic
  const renderViewer = useCallback(() => {
    if (config.SUPPORTED_IMAGE_FORMAT.includes(fileExtension)) {
      return <ImageViewer base64Data={base64Data} />;
    }
    if (config.SUPPORTED_VIDEO_FORMAT.includes(fileExtension)) {
      return <VideoViewer base64Data={base64Data} />;
    }
    if (config.SUPPORTED_PDF_FORMAT.includes(fileExtension)) {
      return <PDFViewer base64Data={base64Data} />;
    }
    if (config.SUPPORTED_DOCUMENT_FORMAT.includes(fileExtension)) {
      return <WordViewer base64Data={base64Data} />;
    }
    if (config.SUPPORTED_SPREADSHEET_FORMAT.includes(fileExtension)) {
      return <ExcelViewer base64Data={base64Data} />;
    }

    return (
      <div className="text-center" style={{ padding: 50 }}>
        <i
          className="fa fa-file-o"
          style={{ fontSize: 48, color: "#ccc", marginBottom: 20 }}
        />
        <h4>Unsupported File Type</h4>
        <p>The file type "{fileExtension}" is not supported for viewing.</p>
        <button className="btn btn-primary" onClick={onClose}>
          Close
        </button>
      </div>
    );
  }, [base64Data, fileExtension, onClose]);

  // Lock body scroll and save/restore focus
  useEffect(() => {
    if (isOpen) {
      previouslyFocused.current = document.activeElement;
      document.body.style.overflow = "hidden";
      // focus drawer after open
      setTimeout(() => drawerRef.current?.focus(), 0);
    } else {
      document.body.style.overflow = "";
      (previouslyFocused.current as HTMLElement | null)?.focus?.();
    }
    return () => {
      document.body.style.overflow = "";
    };
  }, [isOpen]);

  // Close on Escape and manage Tab focus trap
  useEffect(() => {
    if (!isOpen) return;

    const handleKeyDown = (e: KeyboardEvent) => {
      if (e.key === "Escape") {
        e.preventDefault();
        onClose();
        return;
      }
      if (e.key === "Tab") {
        // basic focus trap
        const root = drawerRef.current;
        if (!root) return;
        const focusable = root.querySelectorAll<HTMLElement>(
          'a[href], button, textarea, input, select, [tabindex]:not([tabindex="-1"])'
        );
        if (!focusable || focusable.length === 0) {
          e.preventDefault();
          return;
        }
        const first = focusable[0];
        const last = focusable[focusable.length - 1];
        if (e.shiftKey) {
          if (document.activeElement === first) {
            e.preventDefault();
            last.focus();
          }
        } else {
          if (document.activeElement === last) {
            e.preventDefault();
            first.focus();
          }
        }
      }
    };

    document.addEventListener("keydown", handleKeyDown, true);
    return () => document.removeEventListener("keydown", handleKeyDown, true);
  }, [isOpen, onClose]);

  if (!isOpen) return null;

  // inline width clamp & styles: clamp between 40vw and 90vw
  const clampedWidth = Math.max(40, Math.min(90, widthVW));

  return createPortal(
    <div
      className="dv-overlay"
      onClick={onClose} /* backdrop click closes */
      role="dialog"
      aria-modal="true"
      aria-label="Document viewer"
    >
      <aside
        className="dv-drawer"
        style={{ width: `${clampedWidth}vw`, maxWidth: "1100px" }}
        onClick={(e) => e.stopPropagation()}
        ref={drawerRef}
        tabIndex={-1}
      >
        {/* <header className="dv-header" aria-hidden={false}>
          <div style={{ display: "flex", alignItems: "center", gap: 12 }}>
            <i className="fa fa-file-text-o" aria-hidden />
            <h4 style={{ margin: 0, fontSize: 18, fontWeight: 600 }}>
              Document Viewer
            </h4>
          </div>
 
          <div style={{ display: "flex", gap: 8, alignItems: "center" }}>
            <button
              type="button"
              aria-label="Close"
              className="dv-close-btn"
              onClick={onClose}
            >
              &times;
            </button>
          </div>
        </header> */}

        <div className="dv-body">{renderViewer()}</div>

        <footer className="dv-footer">
          <button type="button" className="btn btn-default" onClick={onClose}>
            Close
          </button>
        </footer>
      </aside>
    </div>,
    document.body
  );
};

export default DocumentViewerModal;
