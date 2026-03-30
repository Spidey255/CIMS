// Innovace Intech Solution Pvt Ltd
import React from "react";
import { useGeneralStore } from "../../store/useStore";
import type { UIElement } from "../../constants/types";

const ConfirmDialog: React.FC<{
  element: UIElement;
  children?: React.ReactNode;
}> = ({ element, children }) => {
  const dialogState = useGeneralStore(
    (store) => store.state[element.ElementName]
  );

  const isOpen =
    dialogState?.ShowDialog === true &&
    dialogState?.HideDialog !== true;

  if (!isOpen) return null;

  return (
    <>
      {/* Backdrop with blur */}
      <div
        className="modal-backdrop fade show"
        style={{
          backdropFilter: "blur(10px) saturate(150%)",
          backgroundColor: "rgba(0,0,0,0.35)",
        }}
      />

      {/* Modal */}
      <div
        className="modal fade show d-block"
        tabIndex={-1}
        role="dialog"
      >
        <div className="modal-dialog modal-dialog-centered">
          <div
            className="modal-content border-0"
            style={{
              borderRadius: "10px",
              background:
                "rgba(255, 255, 255, 0.75)", // semi-transparent glossy
              backdropFilter: "blur(12px) saturate(180%)",
              boxShadow: "0 25px 60px rgba(0,0,0,0.25)",
              border: "3px solid rgba(255,255,255,0.3) !important",
              animation: "glossyZoom 0.25s ease",
              padding:"15px",
            }}
          >
            {children}
          </div>
        </div>
      </div>

      {/* Animation */}
      <style>
        {`
          @keyframes glossyZoom {
            from {
              opacity: 0;
              transform: scale(0.92);
            }
            to {
              opacity: 1;
              transform: scale(1);
            }
          }
        `}
      </style>
    </>
  );
};

export default ConfirmDialog;
