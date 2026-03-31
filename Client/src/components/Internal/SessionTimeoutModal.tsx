// Innovace Intech Solution Pvt Ltd
import React, { useEffect, useRef } from "react";

interface Props {
  isOpen: boolean;
  onConfirm: () => void;
}

const SessionTimeoutModal: React.FC<Props> = ({ isOpen, onConfirm }) => {
  const modalRef = useRef<HTMLDivElement | null>(null);
  const bsModal = useRef<any>(null);

  useEffect(() => {
    if (modalRef.current) {
      bsModal.current = new (window as any).bootstrap.Modal(modalRef.current, {
        backdrop: "static",
        keyboard: false,
      });
    }
  }, []);

  useEffect(() => {
    if (!bsModal.current) return;

    if (isOpen) {
      bsModal.current.show();
    } else {
      bsModal.current.hide();
    }
  }, [isOpen]);

  return (
    <div
      className="modal fade"
      tabIndex={-1}
      ref={modalRef}
      aria-hidden="true"
    >
      <div className="modal-dialog modal-dialog-centered">
        <div className="modal-content border-0 shadow-lg rounded-4">

          <div className="modal-body text-center p-5">

            {/* Icon */}
            <div className="mb-4">
              <div className="session-icon">
                <i className="fa fa-clock"></i>
              </div>
            </div>

            {/* Title */}
            <h4 className="fw-bold mb-2">Session Expired</h4>

            {/* Message */}
            <p className="text-muted mb-4">
              Your session has expired. Please login again to continue.
            </p>

            {/* Button */}
            <button
              className="btn btn-primary px-4 rounded-pill"
              onClick={onConfirm}
            >
              OK
            </button>

          </div>

        </div>
      </div>
    </div>
  );
};

export default SessionTimeoutModal;