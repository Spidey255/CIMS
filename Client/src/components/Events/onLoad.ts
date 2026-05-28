// Innovace Intech Solution Pvt Ltd
import type {
  IBindingData,
  UIElement,
  IDropdownValues,
  IGlobalStateValues,
  TValue,
  IActionParams
} from "../../constants/types";
import axiosHelper from "../../helpers/axiosHelper";
import { usePageStore } from "../../store/usePageStore";
import { config } from "@/constants/config";
import { useGeneralStore } from "../../store/useStore";


export async function onLoad(
  element: UIElement,
  slotId: string | null,
): Promise<IDropdownValues[]> {
  try {
    if (element["BindingDetail"]) {
      const bindingData = JSON.parse(
        element["BindingDetail"]
      ) as IBindingData[];

      if (!bindingData.length) return [];

      const details = bindingData.find((f) => f["Action"] === "OnLoad");

      if (!details) return [];

      const url = details.Endpoint.replace(/^~(?=\/)/, config.BASE_URL);
      const method = details.HttpVerb;

      const activePage = usePageStore.getState().activePage;


      const params = details.Params
              ? (JSON.parse(details.Params) as IActionParams[])
              : [];
      
            let elementIds = params.map((p) => p.ElementName);
      
            if (element.ElementName.includes("+")) {
              const [id, rwId] = element.ElementName.split("+");
              const rowId = `${id}+${rwId}`;
              elementIds = params.map((p) => `${rowId}+${p.ElementName}`);
            }
      
            const edtMap = params.reduce((acc, p) => {
              acc[p.ElementName] = p.EDT;
              return acc;
            }, {} as Record<string, number | null>);
      
            const storeState = useGeneralStore.getState().state;
      
            const getActualElementName = (name: string) =>
              name.includes("+") ? name.split("+").pop()! : name;
      
            const actualNameMap: Record<string, IGlobalStateValues> = {};
      
            Object.keys(storeState).forEach((key) => {
              const actual = getActualElementName(key);
              actualNameMap[actual] = storeState[key];
            });
      
            const fetchedStateValues = elementIds.reduce((acc, id) => {
              // Full key when clicked from grid row
              if (element.ElementName.includes("+")) {
                const fullKey = id; // TaskStep+UUID+TaskStep_RowId
      
                acc[id.split("+")[2]] =
                  storeState[fullKey]?.value ??
                  "";
              } else {
                // Non-grid normal flow (UNCHANGED)
                const elementId = id;
                acc[elementId] =
                  actualNameMap[elementId]?.value ??
                  "";
              }
      
              return acc;
            }, {} as Record<string, TValue | undefined>);
      
      
            const stateParams = Object.entries(fetchedStateValues).map(
              ([id, value]) => ({
                ElementName: id,
                Value: value,
                EDT: edtMap[id] ?? null,
              })
            );
      
            const MF_d2_DocId = sessionStorage.getItem('MF_d2_DocId') || '';
      
            // Update the element in stateParams
            const updatedStateParams = stateParams.map(item => {
              if (item.ElementName === 'MF_d1_invoice_id') {
                return { ...item, Value: MF_d2_DocId }; // replace Value
              }
              return item;
            })

      if (!activePage) {
        // console.warn("ActivePage not ready yet");
        return [];
      }

      const postData = {
        SlotId: slotId,
        FormVersionId: activePage?.["FormVersionId"],
        PackageProcessMapId: activePage?.PackageProcessMapId,
        ProcessActivityMapId: activePage?.ProcessActivityMapId,
        ViewPort: 4,
        Action: details.Action,
        FormInstanceId: "",
        JsxFileName: "",
        JsxFileVersion: "",
        Params: updatedStateParams || stateParams,
      };
      const data = await axiosHelper<IDropdownValues[]>(url, method, postData);
      return data || [];
    }

    return [];
  } catch (error) {
    console.log(error);
    return [];
  }
}
