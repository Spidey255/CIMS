// Innovace Intech Solution Pvt Ltd
// import React from "react";
// import type {
//   UIElement,
// } from "../../../constants/types";
// import { useGeneralStore } from "../../../store/useStore";

// const LabelComboBox: React.FC<{
//   element: UIElement;
//   isGrid?: boolean;
// }> = ({ element, isGrid }) => {
//   const state = useGeneralStore(
//     (store) => store.state[element.ElementName]?.["value"]
//   );

//   const visible = element.ElementControlProperty?.find(p => "Visible" in p)?.Visible ?? "true";
//   const isVisible = useGeneralStore(
//     (store) => store.state[element.ElementName]?.isVisible
//   ) || visible;



//   if (isVisible == false || isVisible == "false") return null;
//   return (
//     <div className={!Boolean(isGrid) ? element.ColumnCss + ` col-md-${element.Wrap}` : undefined}>
//       <div
//         id={element.ElementName}
//       >
//         <div className="form-group">
//           {!Boolean(isGrid) && Boolean(element["ShowCaption"]) ? (
//             <label id="" className="form-label" htmlFor={element.ElementName}>
//               {element?.DCaption}
//             </label>
//           ) : null}
//           <span
//             id={`man_${element.ElementName}`}
//             className="text-danger"
//           ></span>

//           <div className="controls" onClick={(e) => e.stopPropagation()}>
//             <span id={`spn_${element.ElementName}`}>{state}</span>
//           </div>
//         </div>
//       </div>
//     </div>
//   );
// };

// export default LabelComboBox;
// ``;



// Innovace Intech Solution Pvt Ltd
import React, { useCallback, useEffect, useState } from "react";
import type { IList, UIElement } from "@/constants/types";
import { useGeneralStore } from "@/store/useStore";
import { useUserStore } from "@/store/useUserStore";
import { usePageStore } from "@/store/usePageStore";
import { onLoad } from "@/components/Events/onLoad";
import { accessMandatory } from "@/helpers/utils";

const LabelComboBox: React.FC<{
  element: UIElement;
  isGrid?: boolean;
}> = ({ element, isGrid }) => {
  const state = useGeneralStore(
    (store) => store.state[element.ElementName]?.["value"]
  );
  const visible = element.ElementControlProperty?.find(p => "Visible" in p)?.Visible ?? "true";
  const storeState = useGeneralStore((store) => store.state[element.ElementName]);

  const isVisible = storeState !== undefined ? storeState.isVisible : visible;


  const relement = useGeneralStore(
    (store) => store.state[element.ElementName]?.["rElemData"]
  );

  const slotId = useUserStore((store) => store.slotId);
  const activePage = usePageStore((store) => store.activePage);
  const controlId = element.ElementId || element.UIElementid || element.ElementName;

  const [comboBoxValues, setComboBoxValues] = useState<IList[]>([]);

  const comboReady = useGeneralStore(
    (store) => store.comboReady
  );
  // console.log("comboBoxValues",comboBoxValues);
  const fetchData = useCallback(async () => {
    try {


      // ? WAIT UNTIL COMBO READY
      if (!comboReady) return;

      if (!element || !slotId || !activePage) return;

      const data = await onLoad(element, slotId);

      setComboBoxValues(Array.isArray(data) ? data : []);
    } catch (error) {
      console.log("ComboBox onLoad Error:", error);
      setComboBoxValues([]);
    }
  }, [element, slotId, activePage, comboReady]);
  useEffect(() => {
    fetchData();
  }, [fetchData, comboReady]);


  useEffect(() => {
    if (Array.isArray(relement) && relement.length > 0) {
      setComboBoxValues(relement);
    }
  }, [relement]); // Only run when `relement` changes

  const isMandatory =
    element.ElementControlProperty?.some((prop) => accessMandatory(prop)) ?? false;

  if (isVisible == false || isVisible == "false") return null;

  return (
    <div className={
      !isGrid
        ? [element?.ColumnCss, element?.Wrap && `col-md-${element.Wrap}`]
          .filter(Boolean)
          .join(" ")
        : ""
    }>
      <div id={element.ElementName}>
        <div className="mb-3">

          {/* Label */}
          {!isGrid && element.ShowCaption ? (
            <>
              <label
                className="form-label "
                htmlFor={element.ElementName}
              >
                {element?.DCaption}
              </label>
              <span
                id={`man_${controlId}`}
                className="mandatory-symbol"
                aria-hidden="true"
              >
                {isMandatory && <span className="mandatory-icon">*</span>}
              </span>
            </>
          ) : null}

          <span
            id={`man_${element.ElementName}`}
            className="text-danger d-block"
          ></span>

          {/* Bootstrap Select */}
          <div className="controls position-relative">
            <label className={`${element.Css || "form-control"} pe-5`}

            >
              {
                comboBoxValues?.find(
                  (d) => String(d.key) === String(state)
                )?.value || ""
              }
            </label>
          </div>

        </div>
      </div>
    </div>
  );
};

export default LabelComboBox;
