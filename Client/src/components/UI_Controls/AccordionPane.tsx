// Innovace Intech Solution Pvt Ltd
import React, { useId } from "react";
import type { UIElement } from "../../constants/types";

const AccordionPane: React.FC<{
  element: UIElement;
  children?: React.ReactNode;
  parentAccordionId?: string; // 👈 added (safe, optional)
}> = ({ element, children, parentAccordionId }) => {
  const uid = useId();

  const headingId = `heading-${uid}`;
  const collapseId = `collapse-${uid}`;

  const handleSelect = (
    event: React.MouseEvent<HTMLDivElement, MouseEvent>,
    id: string
  ) => {
    event.stopPropagation();
    console.log("LayoutControlSelected:", id);
  };

  return (
    <div
      className={`accordion-item card bg-white `}
      onClick={(e) => handleSelect(e, `${element?.Id}`)}
    >
      {/* Header */}
      <h2 className="accordion-header" id={headingId}>
        <button
          className="accordion-button collapsed fw-semibold fs-6"
          type="button"
          data-bs-toggle="collapse"
          data-bs-target={`#${collapseId}`}
          aria-expanded="false"
          aria-controls={collapseId}
        >
          {element.ElementName}
        </button>
      </h2>

      {/* Body */}
      <div
        id={collapseId}
        className="accordion-collapse collapse"
        aria-labelledby={headingId}
        data-bs-parent={parentAccordionId ? `#${parentAccordionId}` : undefined}
      >
        <div className="accordion-body">{children}</div>
      </div>
    </div>
  );
};

export default AccordionPane;