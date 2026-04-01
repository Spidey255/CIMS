// Innovace Intech Solution Pvt Ltd
import React, { useCallback, useEffect, useState } from "react";
import type { IList, UIElement } from "@/constants/types";
import { useGeneralStore } from "@/store/useStore";
import { useUserStore } from "@/store/useUserStore";
import { usePageStore } from "@/store/usePageStore";
import { onLoad } from "@/components/Events/onLoad";
import { resusableOnChange } from "../../Events/onChange";
import { accessMandatory } from "@/helpers/utils";

const DefaultComboBox: React.FC<{
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
  const setState = useGeneralStore((store) => store.setState);
  const activePage = usePageStore((store) => store.activePage);
  const controlId = element.ElementId || element.UIElementid || element.ElementName;

  const [comboBoxValues, setComboBoxValues] = useState<IList[]>([]);
  // console.log("comboBoxValues",comboBoxValues);
  const fetchData = useCallback(async () => {
    try {
      if (!element || !slotId || !activePage) return;

      const data = await onLoad(element, slotId);

      setComboBoxValues(data);
    } catch (error) {
      console.log("ComboBox onLoad Error:", error);
    }
  }, [element, slotId, activePage]);

  useEffect(() => {
    fetchData();
  }, [fetchData]);


  const handleChange = async (event: any) => {
    // setState(element.ElementName, event.target.value);
    setState(element.ElementName, event.target.value);
    resusableOnChange(element);
  };
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
          <div className="controls" onClick={(e) => e.stopPropagation()}>
            <select
              className={element.Css || "form-select"}
              value={typeof state === "boolean" ? "" : state ?? ""}
              onChange={handleChange}
            >
              <option value="">{element.DHelpText || "Choose From Below"}</option>
              {comboBoxValues?.map((d) => (

                <option key={d?.key} value={d?.key}>
                  {d?.value}
                </option>
              ))}
            </select>
          </div>

        </div>
      </div>
    </div>
  );
};

export default DefaultComboBox;
