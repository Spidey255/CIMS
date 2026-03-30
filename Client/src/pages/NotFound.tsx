// Innovace Intech Solution Pvt Ltd
// src/pages/NotFound.tsx
import React from "react";
import { useNavigate } from "react-router-dom";

const NotFound: React.FC = () => {
  const navigate = useNavigate();

  return (
    <div
      style={{
        minHeight: "100vh",
        display: "flex",
        alignItems: "center",
        justifyContent: "center",
        background:
          "linear-gradient(135deg, #e9f2ff 0%, #f8f9fa 60%, #ffffff 100%)",
        fontFamily: "system-ui, -apple-system, BlinkMacSystemFont",
      }}
    >
      <div
        style={{
          background: "#ffffff",
          padding: "48px 40px",
          borderRadius: "16px",
          boxShadow: "0 20px 50px rgba(0,0,0,0.08)",
          textAlign: "center",
          maxWidth: "420px",
          width: "100%",
        }}
      >
        {/* 404 */}
        <div
          style={{
            fontSize: "96px",
            fontWeight: 800,
            lineHeight: 1,
            color: "#0d6efd",
            letterSpacing: "-4px",
          }}
        >
          404
        </div>

        {/* Title */}
        <h2
          style={{
            marginTop: "12px",
            marginBottom: "8px",
            fontWeight: 600,
          }}
        >
          Page Not Found
        </h2>

        {/* Description */}
        <p
          style={{
            color: "#6c757d",
            fontSize: "15px",
            marginBottom: "28px",
          }}
        >
          Sorry, the page you’re looking for doesn’t exist or has been moved.
        </p>

        {/* Actions */}
        <div
          style={{
            display: "flex",
            gap: "12px",
            justifyContent: "center",
            flexWrap: "wrap",
          }}
        >
          <button
            onClick={() => navigate(-1)}
            style={{
              padding: "10px 20px",
              background: "#f1f3f5",
              color: "#212529",
              border: "1px solid #dee2e6",
              borderRadius: "8px",
              cursor: "pointer",
              fontWeight: 500,
            }}
          >
            Go Back
          </button>

          {/* <button
            onClick={() => navigate("/")}
            style={{
              padding: "10px 24px",
              background: "#0d6efd",
              color: "#fff",
              border: "none",
              borderRadius: "8px",
              cursor: "pointer",
              fontWeight: 500,
              boxShadow: "0 8px 20px rgba(13,110,253,0.35)",
            }}
          >
            Go to Home
          </button> */}
        </div>

        {/* Footer hint */}
        <div
          style={{
            marginTop: "32px",
            fontSize: "12px",
            color: "#adb5bd",
          }}
        >
          If you believe this is an error, please contact support.
        </div>
      </div>
    </div>
  );
};

export default NotFound;
