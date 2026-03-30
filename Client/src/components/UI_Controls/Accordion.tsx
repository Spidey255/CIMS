// Innovace Intech Solution Pvt Ltd
import React, { useId } from "react";
import type { UIElement } from "../../constants/types";

type AccordionPaneInjectedProps = {
  parentAccordionId?: string;
};

const Accordion: React.FC<{
  element: UIElement;
  children?: React.ReactNode;
}> = ({ element: _element, children }) => {
  const accordionId = useId();

  return (
    <div id={accordionId} className={`accordion p-0`}>
      {React.Children.map(children, (child) => {
        if (!React.isValidElement(child)) return child;

        return React.cloneElement(
          child as React.ReactElement<AccordionPaneInjectedProps>,
          {
            parentAccordionId: accordionId,
          }
        );
      })}
    </div>
  );
};

export default Accordion;