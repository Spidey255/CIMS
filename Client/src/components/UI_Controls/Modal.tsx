// Innovace Intech Solution Pvt Ltd
import React, { useEffect, useRef } from "react";
import { createPortal } from "react-dom";
import type { UIElement } from "../../constants/types";
import { useGeneralStore } from "../../store/useStore";

declare const bootstrap: any;

const Modal: React.FC<{
  element: UIElement;
  children?: React.ReactNode;
}> = ({ element, children }) => {
  const modalRef = useRef<HTMLDivElement>(null);

  const state = useGeneralStore(
    (store) => store.uiElementState?.[element.ElementName]
  );
  console.log("element", element);

  const modalId = `modal-${element.ElementId || element.UIElementid}`;

  useEffect(() => {
    if (!modalRef.current) return;

    const modalInstance =
      bootstrap.Modal.getOrCreateInstance(modalRef.current);

    if (state?.ShowModal) {
      modalInstance.show();
    } else {
      modalInstance.hide();
    }
  }, [state?.ShowModal]);

  // ✅ Render modal directly into BODY
  return createPortal(
    <div
      ref={modalRef}
      className={`modal fade ${element.Css}`}
      id={modalId}
      tabIndex={-1}
      aria-hidden="true"
    >
      <div className="modal-dialog modal-lg modal-dialog-centered modal-dialog-scrollable">
        <div className="modal-content border-0 rounded-2 shadow-lg">

          {/* Header */}
          <div className="modal-header bg-primary text-white">
            <h5 className="modal-title">
              {element.ElementName || "Details"}
            </h5>

            <button
              type="button"
              className="btn-close btn-close-white"
              data-bs-dismiss="modal"
            />
          </div>

          {/* Body */}
          <div className="modal-body p-4">
            {children}
          </div>

        </div>
      </div>
    </div>,
    document.body
  );
};

export default Modal;