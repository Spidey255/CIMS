// Innovace Intech Solution Pvt Ltd
// import React from "react";
// import type{ UIElement } from "../../constants/types";

// const Span: React.FC<{
//   element: UIElement;
// }> = ({ element }) => {
//   return (
//     <span
//       id={element.ElementId || element.UIElementid}
//       className={`${element.Css}`}
//     >
//       {element["Content"]}
//     </span>
//   );
// };

// export default Span;



import React from "react";
import type { UIElement } from "../../constants/types";

const Span: React.FC<{
  element: UIElement;
  children?: React.ReactNode;  // Allow children prop
}> = ({ element, children }) => {
  return (
    <span
      id={element.ElementId || element.UIElementid}
      className={`${element.Css}`}
    >
      {element["Content"]} {children}  {/* Render content and children if passed */}
    </span>
  );
};

export default Span;
