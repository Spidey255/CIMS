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

  const closeDialog = () => {
    useGeneralStore.setState({
      state: {
        ...useGeneralStore.getState().state,
        [element.ElementName]: {
          ...useGeneralStore.getState().state[element.ElementName],
          HideDialog: true,
        },
      },
    });
  };

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
        className={`modal fade show d-block ${element?.Css || ""}`}
        tabIndex={-1}
        role="dialog"
      >
        <div className="modal-dialog modal-dialog-centered">

          {/* ✅ FIXED: modal-content is parent */}
          <div
            className="modal-content border-0"
            style={{
              borderRadius: "10px",
              background: "rgba(255, 255, 255, 0.75)",
              backdropFilter: "blur(12px) saturate(180%)",
              boxShadow: "0 25px 60px rgba(0,0,0,0.25)",
              border: "3px solid rgba(255,255,255,0.3)",
              animation: "glossyZoom 0.25s ease",
            }}
          >

            {/* ✅ HEADER moved inside */}
            <div className="modal-header position-relative">
              <div className="modal-title">{element?.ElementName}</div>

              {/* keep your custom close button */}
              <button
                className="close"
                style={{
                  position: "absolute",
                  top: "10px",
                  right: "10px",
                  border: "none",
                  background: "transparent",
                  fontSize: "1.5rem",
                  color: "#333",
                }}
                onClick={closeDialog}
              >
                &times;
              </button>
            </div>

            {/* ✅ BODY added (important for BS5) */}
            <div className="modal-body p-3">
              {children}
            </div>

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