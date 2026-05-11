// Innovace Intech Solution Pvt Ltd
// import React, { useId } from "react";
// import type { UIElement } from "../../constants/types";

// type AccordionPaneInjectedProps = {
//   parentAccordionId?: string;
// };

// const Accordion: React.FC<{
//   element: UIElement;
//   children?: React.ReactNode;
// }> = ({ element: _element, children }) => {
//   const accordionId = useId();

//   return (
//     <div id={accordionId} className={`accordion p-0`}>
//       {React.Children.map(children, (child) => {
//         if (!React.isValidElement(child)) return child;

//         return React.cloneElement(
//           child as React.ReactElement<AccordionPaneInjectedProps>,
//           {
//             parentAccordionId: accordionId,
//           }
//         );
//       })}
//     </div>
//   );
// };

// export default Accordion;


import React, { useId } from "react";
import type { UIElement } from "@/constants/types";

type AccordionProps = {
  element: UIElement;
  children?: React.ReactNode;
};

const Accordion: React.FC<AccordionProps> = ({ element: _element, children }) => {
  const accordionId = useId();

  return (
    <div id={accordionId} className={`accordion p-0`}>
      {React.Children.map(children, (child, index) => {
        if (!React.isValidElement(child)) return child;

        // Set the first accordion to open automatically
        const isFirstAccordion = index === 0;
        
        return React.cloneElement(child as React.ReactElement<any>, {
          parentAccordionId: accordionId,
          defaultOpen: isFirstAccordion, // Automatically open the first accordion
        });
      })}
    </div>
  );
};

export default Accordion;