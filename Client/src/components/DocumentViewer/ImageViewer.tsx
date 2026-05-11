// Innovace Intech Solution Pvt Ltd
import React, { useState } from "react";

interface ImageViewerProps {
  base64Data: string;
}

const ImageViewer: React.FC<ImageViewerProps> = ({ base64Data }) => {
  const [imageError, setImageError] = useState(false);
  const [isLoading, setIsLoading] = useState(true);

  const handleImageLoad = () => {
    setIsLoading(false);
  };

  const handleImageError = () => {
    setImageError(true);
    setIsLoading(false);
  };

  if (imageError) {
    return (
      <div className="text-center" style={{ padding: "50px" }}>
        <i
          className="fa fa-image"
          style={{ fontSize: "48px", color: "#ccc", marginBottom: "20px" }}
        ></i>
        <h4>Image Load Error</h4>
        <p>
          Unable to load the image. The file may be corrupted or in an
          unsupported format.
        </p>
      </div>
    );
  }

  return (
    <div
      style={{
        display: "flex",
        justifyContent: "center",
        alignItems: "center",
        minHeight: "400px",
        backgroundColor: "#f8f9fa",
        position: "relative",
      }}
    >
      {isLoading && (
        <div
          className="text-center"
          style={{ position: "absolute", zIndex: 1 }}
        >
          <i
            className="fa fa-spinner fa-spin"
            style={{ fontSize: "24px", color: "#007bff" }}
          ></i>
          <p style={{ marginTop: "10px", color: "#666" }}>Loading image...</p>
        </div>
      )}

      <img
        src={base64Data}
        alt="Document Image"
        onLoad={handleImageLoad}
        onError={handleImageError}
        style={{
          width: "100%",
          height: "100%",
          maxWidth: "100%",
          maxHeight: "70vh",
          objectFit: "contain",
          borderRadius: "4px",
          boxShadow: "0 2px 8px rgba(0,0,0,0.1)",
          opacity: isLoading ? 0 : 1,
          transition: "opacity 0.3s ease",
        }}
      />
    </div>
  );
};

export default ImageViewer;
