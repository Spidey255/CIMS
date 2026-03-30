// Innovace Intech Solution Pvt Ltd
import React, { useState } from "react";

interface ExcelViewerProps {
  base64Data: string;
}

const ExcelViewer: React.FC<ExcelViewerProps> = ({ base64Data }) => {
  const [isLoading] = useState(true);

  const downloadExcel = () => {
    const link = document.createElement("a");
    link.href = base64Data;
    link.download = "spreadsheet.xlsx";
    link.click();
  };

  const openInOffice365 = () => {
    // Convert base64 to blob and create object URL
    const byteCharacters = atob(base64Data.split(",")[1]);
    const byteNumbers = new Array(byteCharacters.length);
    for (let i = 0; i < byteCharacters.length; i++) {
      byteNumbers[i] = byteCharacters.charCodeAt(i);
    }
    const byteArray = new Uint8Array(byteNumbers);
    const blob = new Blob([byteArray], {
      type: "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
    });

    const url = URL.createObjectURL(blob);
    window.open(
      `https://view.officeapps.live.com/op/embed.aspx?src=${encodeURIComponent(
        url
      )}`,
      "_blank"
    );
  };

  return (
    <div
      style={{
        display: "flex",
        flexDirection: "column",
        height: "70vh",
        backgroundColor: "#f8f9fa",
      }}
    >
      {/* Excel Controls */}
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
            <i
              className="fa fa-file-excel-o"
              style={{ marginRight: "5px" }}
            ></i>
            Excel Spreadsheet
          </span>
        </div>
        <div>
          <button
            className="btn btn-sm btn-primary"
            onClick={openInOffice365}
            style={{ marginRight: "5px" }}
          >
            <i className="fa fa-external-link"></i> Open in Office 365
          </button>
          <button className="btn btn-sm btn-default" onClick={downloadExcel}>
            <i className="fa fa-download"></i> Download
          </button>
        </div>
      </div>

      {/* Excel Content */}
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
            <p style={{ marginTop: "10px", color: "#666" }}>
              Loading Excel spreadsheet...
            </p>
          </div>
        )}

        <div
          style={{
            padding: "20px",
            textAlign: "center",
            height: "100%",
            display: "flex",
            flexDirection: "column",
            justifyContent: "center",
            alignItems: "center",
          }}
        >
          <i
            className="fa fa-file-excel-o"
            style={{
              fontSize: "64px",
              color: "#28a745",
              marginBottom: "20px",
            }}
          ></i>
          <h4>Excel Spreadsheet Preview</h4>
          <p style={{ color: "#666", marginBottom: "20px" }}>
            Excel spreadsheets cannot be previewed directly in the browser.
            Please use the buttons above to open in Office 365 or download the
            file.
          </p>
          <div>
            <button
              className="btn btn-primary"
              onClick={openInOffice365}
              style={{ marginRight: "10px" }}
            >
              <i className="fa fa-external-link"></i> Open in Office 365
            </button>
            <button className="btn btn-default" onClick={downloadExcel}>
              <i className="fa fa-download"></i> Download Spreadsheet
            </button>
          </div>
        </div>
      </div>
    </div>
  );
};

export default ExcelViewer;
