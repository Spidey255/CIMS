// Innovace Intech Solution Pvt Ltd
// import { v4 } from "uuid";
import _ from "lodash";
import { useGeneralStore } from "@/store/useStore";
import { useUserStore } from "@/store/useUserStore";
import { usePageStore } from "@/store/usePageStore";
import axiosHelper from "@/helpers/axiosHelper";
import { config } from "@/constants/config";
import type { UIElement, IAppResponse } from "@/constants/types";

interface ISaveGridParams {
  elements: UIElement[];
  formInstanceId: string | null;
}

export const saveGrid = async ({ elements, formInstanceId }: ISaveGridParams): Promise<string> => {
  if (!elements?.length) return "";

  const slotId = useUserStore.getState().slotId || sessionStorage.getItem("accessToken");
  const activePage = usePageStore.getState().activePage;
  const state = useGeneralStore.getState().state;

  // const formInstanceId = v4();

  try {
    // Only Grid elements
    const gridElements = elements.filter((el) => el.ControlType === "Grid");

    const savePromises = gridElements.map(async (element) => {
      const gridDataEntries = Object.entries(state).filter(
        ([key]) =>
          key.includes("+") && key.startsWith(`${element.ElementName}+`)
      );

      const grouped = _.groupBy(gridDataEntries, ([key]) => key.split("+")[1]);

      const formattedGridData = Object.entries(grouped).map(
        ([RwId, rowData], index) => ({
          RwId,
          Seq: index + 1,
          Child: rowData.map(([key, { value }]: any) => {
            const elementName = key.split("+")[2];
            return {
              ElementName: elementName,
              Value: value ?? null,
              EDT: state[elementName]?.EDT ?? 9,
            };
          }),
        })
      );

      const FormData = [
        {
          ElementId: element.ElementId,
          ElementName: element.ElementName,
          Child: formattedGridData,
        },
      ];

      const postData = {
        SlotId: slotId,
        ControlId: element.ElementName,
        PackageProcessMapId: activePage?.PackageProcessMapId,
        ProcessActivityMapId: activePage?.ProcessActivityMapId,
        ViewPort: 4,
        Action: "FormSave",
        FormInstanceId: formInstanceId,
        WidgetId: element.WidgetId,
        JsxFileName: "",
        JsxFileVersion: "",
        Params: [],
        FormData,
      };

      return axiosHelper<IAppResponse>(config.SAVE_WIDGET_URL, "POST", postData);
    });

    await Promise.all(savePromises);

    return formInstanceId || ""; // return saved instance id
  } catch (err) {
    console.error("Unable to save grid:", err);
    throw new Error("Unable to save grid. Try again.");
  }
};
