// Innovace Intech Solution Pvt Ltd
import React, { useState } from "react";

interface PDFViewerProps {
  base64Data: string;
}

const PDFViewer: React.FC<PDFViewerProps> = ({ base64Data }) => {
  const [pdfError, setPdfError] = useState(false);
  const [isLoading, setIsLoading] = useState(true);

  const handlePDFLoad = () => {
    setIsLoading(false);
  };

  const handlePDFError = () => {
    setPdfError(true);
    setIsLoading(false);
  };

  const downloadPDF = () => {
    const link = document.createElement("a");
    link.href = base64Data;
    link.download = "document.pdf";
    link.click();
  };

  if (pdfError) {
    return (
      <div className="text-center" style={{ padding: "50px" }}>
        <i
          className="fa fa-file-pdf-o"
          style={{ fontSize: "48px", color: "#ccc", marginBottom: "20px" }}
        ></i>
        <h4>PDF Load Error</h4>
        <p>
          Unable to load the PDF. The file may be corrupted or password
          protected.
        </p>
        <button
          className="btn btn-primary"
          onClick={downloadPDF}
          style={{ marginTop: "10px" }}
        >
          <i className="fa fa-download"></i> Download PDF
        </button>
      </div>
    );
  }

  return (
    <div
      style={{
        display: "flex",
        flexDirection: "column",
        height: "calc(100vh - 70px)",
        backgroundColor: "#f8f9fa",
      }}
    >
      {/* PDF Controls */}
      <div
        style={{
          padding: "10px 15px",
          backgroundColor: "#e9ecef",
          borderBottom: "1px solid #dee2e6",
          display: "flex",
          justifyContent: "space-between",
          alignItems: "center",
        }}
      >
        <div>
          <span style={{ fontSize: "14px", color: "#666" }}>
            <i className="fa fa-file-pdf-o" style={{ marginRight: "5px" }}></i>
            PDF Document
          </span>
        </div>
        <div>
          <button
            className="btn btn-sm btn-default"
            onClick={downloadPDF}
            style={{ marginRight: "5px" }}
          >
            <i className="fa fa-download"></i> Download
          </button>
        </div>
      </div>

      {/* PDF Content */}
      <div style={{ flex: 1, position: "relative" }}>
        {isLoading && (
          <div
            className="text-center"
            style={{
              position: "absolute",
              top: "50%",
              left: "50%",
              transform: "translate(-50%, -50%)",
              zIndex: 1,
            }}
          >
            <i
              className="fa fa-spinner fa-spin"
              style={{ fontSize: "24px", color: "#007bff" }}
            ></i>
            <p style={{ marginTop: "10px", color: "#666" }}>Loading PDF...</p>
          </div>
        )}

        <iframe
          src={base64Data}
          onLoad={handlePDFLoad}
          onError={handlePDFError}
          style={{
            width: "100%",
            height: "100%",
            border: "none",
            opacity: isLoading ? 0 : 1,
            transition: "opacity 0.3s ease",
          }}
          title="PDF Document"
        />
      </div>
    </div>
  );
};

export default PDFViewer;
