// Innovace Intech Solution Pvt Ltd
import type {
  IBindingData,
  UIElement,
  IDropdownValues,
} from "../../constants/types";
import axiosHelper from "../../helpers/axiosHelper";
import { usePageStore } from "../../store/usePageStore";
import { config } from "@/constants/config";

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

      if (!activePage) {
        console.warn("ActivePage not ready yet");
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
        Params: JSON.parse(details.Params),
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
