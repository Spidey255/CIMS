// Innovace Intech Solution Pvt Ltd
import React, { useEffect, useState } from "react";
import "../styles/network.css";

const NetworkStatus: React.FC = () => {
  const [online, setOnline] = useState(navigator.onLine);
  const [showRestore, setShowRestore] = useState(false);

  useEffect(() => {
    const handleOnline = () => {
      setOnline(true);
      setShowRestore(true);
      setTimeout(() => setShowRestore(false), 2500);
    };

    const handleOffline = () => {
      setOnline(false);
      setShowRestore(false);
    };

    window.addEventListener("online", handleOnline);
    window.addEventListener("offline", handleOffline);

    return () => {
      window.removeEventListener("online", handleOnline);
      window.removeEventListener("offline", handleOffline);
    };
  }, []);

  return (
    <>
      {!online && (
        <div className="modern-toast-container">
          <div className="modern-toast network-lost">
            <i className="bi bi-wifi-off fs-4"></i>
            <div>
              <strong>Network Lost</strong>
              <div className="small">Trying to reconnect…</div>
            </div>
          </div>
        </div>
      )}

      {showRestore && (
        <div className="modern-toast-container">
          <div className="modern-toast network-restored">
            <i className="bi bi-wifi fs-4"></i>
            <div>
              <strong>Connection Restored</strong>
              <div className="small">You're back online</div>
            </div>
          </div>
        </div>
      )}
    </>
  );
};

export default NetworkStatus;
