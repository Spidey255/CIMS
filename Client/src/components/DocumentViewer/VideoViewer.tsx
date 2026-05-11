// Innovace Intech Solution Pvt Ltd
import React, { useState } from "react";

interface VideoViewerProps {
  base64Data: string;
}

const VideoViewer: React.FC<VideoViewerProps> = ({ base64Data }) => {
  const [videoError, setVideoError] = useState(false);
  const [isLoading, setIsLoading] = useState(true);

  const handleVideoLoad = () => {
    setIsLoading(false);
  };

  const handleVideoError = () => {
    setVideoError(true);
    setIsLoading(false);
  };

  const getVideoType = (base64Data: string): string => {
    const mimeMatch = base64Data.match(/data:(.*?);base64/);
    if (mimeMatch && mimeMatch[1]) {
      return mimeMatch[1];
    }
    return "video/mp4"; // default
  };

  if (videoError) {
    return (
      <div className="text-center" style={{ padding: "50px" }}>
        <i className="fa fa-video-camera" style={{ fontSize: "48px", color: "#ccc", marginBottom: "20px" }}></i>
        <h4>Video Load Error</h4>
        <p>Unable to load the video. The file may be corrupted or in an unsupported format.</p>
      </div>
    );
  }

  return (
    <div style={{ 
      display: "flex", 
      justifyContent: "center", 
      alignItems: "center", 
      minHeight: "400px",
      backgroundColor: "#000",
      position: "relative"
    }}>
      {isLoading && (
        <div className="text-center" style={{ position: "absolute", zIndex: 1, color: "#fff" }}>
          <i className="fa fa-spinner fa-spin" style={{ fontSize: "24px", color: "#007bff" }}></i>
          <p style={{ marginTop: "10px" }}>Loading video...</p>
        </div>
      )}
      
      <video
        controls
        onLoadedData={handleVideoLoad}
        onError={handleVideoError}
        style={{
          maxWidth: "100%",
          maxHeight: "70vh",
          borderRadius: "4px",
          opacity: isLoading ? 0 : 1,
          transition: "opacity 0.3s ease"
        }}
        preload="metadata"
      >
        <source src={base64Data} type={getVideoType(base64Data)} />
        <source src={base64Data} type="video/mp4" />
        <source src={base64Data} type="video/webm" />
        <source src={base64Data} type="video/ogg" />
        Your browser does not support the video tag.
      </video>
    </div>
  );
};

export default VideoViewer;
