// Innovace Intech Solution Pvt Ltd
import React, { useEffect } from "react";

interface Props {
  isOpen: boolean;
  onConfirm: () => void;
}

const SessionTimeoutModal: React.FC<Props> = ({ isOpen, onConfirm }) => {

  // Prevent background scroll
  useEffect(() => {
    document.body.style.overflow = isOpen ? "hidden" : "auto";
  }, [isOpen]);

  if (!isOpen) return null;

  return (
    <div style={styles.overlay}>
      <div style={styles.modal}>

        {/* Icon */}
        <div style={styles.iconWrapper}>
          ⏳
        </div>

        {/* Title */}
        <h2 style={styles.title}>Session Expired</h2>

        {/* Message */}
        <p style={styles.message}>
          Your session has expired. Please login again to continue.
        </p>

        {/* Button */}
        <button style={styles.button} onClick={onConfirm}>
          Continue to Login
        </button>

      </div>
    </div>
  );
};

export default SessionTimeoutModal;


const styles: Record<string, React.CSSProperties> = {
  overlay: {
    position: "fixed",
    inset: 0,
    background: "#fff",
    backdropFilter: "blur(6px)",
    display: "flex",
    alignItems: "center",
    justifyContent: "center",
    zIndex: 99999,
    animation: "fadeIn 0.3s ease",
  },

  modal: {
    width: "360px",
    background: "#fff",
    borderRadius: "20px",
    padding: "30px 25px",
    textAlign: "center",
    // boxShadow: "0 20px 60px rgba(0,0,0,0.2)",
    animation: "scaleIn 0.3s ease",
  },

  iconWrapper: {
    fontSize: "40px",
    marginBottom: "15px",
  },

  title: {
    fontSize: "20px",
    fontWeight: 700,
    marginBottom: "10px",
  },

  message: {
    fontSize: "14px",
    color: "#666",
    marginBottom: "25px",
  },

  button: {
    width: "100%",
    padding: "12px",
    borderRadius: "10px",
    border: "none",
    backgroundColor: "var(--bg-primary)",
    color: "#fff",
    fontWeight: 600,
    cursor: "pointer",
    transition: "0.2s",
  },
};