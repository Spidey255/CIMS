// Innovace Intech Solution Pvt Ltd
// import { v4 } from "uuid";
import _ from "lodash";
import { useGeneralStore } from "@/store/useStore";
import { useUserStore } from "@/store/useUserStore";
import { usePageStore } from "@/store/usePageStore";
import axiosHelper from "@/helpers/axiosHelper";
import { config } from "@/constants/config";
import type { UIElement, IAppResponse, IBindingData, IActionParams } from "@/constants/types";

interface ISaveGridParams {
  elements: UIElement[];
  formInstanceId: string | null;
}
interface ISaveFormParams {
  elements: UIElement[];
  formInstanceId: string | null;
}

interface ISaveGridRowParams {
  element: UIElement;
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
              Value:  state[elementName]?.EDT && typeof value === "string"
        ? value.split("#")[0]
        : value,
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
        Action: "GridSave",
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


export const saveForm = async ({
  elements,
  formInstanceId,
}: ISaveFormParams): Promise<string> => {
  try {
    if (!elements?.length) return "";

    const slotId = useUserStore.getState().slotId;
    const activePage = usePageStore.getState().activePage;
    const state = useGeneralStore.getState().state;
    const uiElementState = useGeneralStore.getState().uiElementState;

    const saveAllPromises = elements.map(async (element) => {
      const bindingDetails =
        typeof element.BindingDetail === "string"
          ? (JSON.parse(element.BindingDetail) as IBindingData[])
          : (element.BindingDetail as IBindingData[]);

      if (!bindingDetails?.length) {
        console.log("No Content in BindingDetail");
        return;
      }

      const details = bindingDetails[0];

      const params = details.Params
        ? typeof details.Params === "string"
          ? (JSON.parse(details.Params) as IActionParams[])
          : (details.Params as IActionParams[])
        : [];

      const edtMap = params.reduce((acc, p) => {
        acc[p.ElementName] = p.EDT;
        return acc;
      }, {} as Record<string, number | null>);

      const Action = "FormSave";

        const formattedData = Object.entries(state)
  .filter(([key]) => !key.includes("+"))
  .map(([key, field]: any) => ({
    ElementName: key,
    Value:
      state[key]?.EDT === 0 && field?.value === ""
        ? false
        : state[key]?.EDT === 1 && typeof field?.value === "string"
        ? field?.value.split("#")[0]
        : field?.value,
    EDT:
      state[key]?.EDT ??
      edtMap[key] ??
      uiElementState[key]?.EDT ??
      9,
  }));

      const FormData = [
        {
          ElementId: element.ElementId,
          ElementName: element.ElementName,
          EDT: state[element.ElementName]?.EDT ?? null,
          Child: formattedData,
        },
      ];

      const postData = {
        SlotId: slotId,
        ControlId: element.ElementName,
        PackageProcessMapId: activePage?.PackageProcessMapId,
        ProcessActivityMapId: activePage?.ProcessActivityMapId,
        ViewPort: 4,
        Action,
        FormInstanceId: formInstanceId,
        WidgetId: element.WidgetId,
        JsxFileName: "",
        JsxFileVersion: "",
        Params: [],
        FormData,
      };

      return axiosHelper<IAppResponse>(
        config.SAVE_WIDGET_URL,
        "POST",
        postData
      );
    });

    await Promise.all(saveAllPromises);

    return formInstanceId || "";
  } catch (error) {
    console.error("Save Form Error:", error);
    throw error;
  }
};



export const saveGridRow = async ({
  element,
  formInstanceId,
}: ISaveGridRowParams): Promise<void> => {
  if (!element.ElementName.includes("+")) {
    return;
  }

  const slotId =
    useUserStore.getState().slotId ||
    sessionStorage.getItem("accessToken");

  const activePage =
    usePageStore.getState().activePage;

  const state =
    useGeneralStore.getState().state;

  try {
    // EmployeeGrid+12+Salary
    const [gridName, rowId] =
      element.ElementName.split("+");

    // ONLY CURRENT ROW
    const rowEntries = Object.entries(state).filter(
      ([key]) =>
        key.startsWith(`${gridName}+${rowId}+`)
    );

    const formattedRow = {
      RwId: rowId,
      Seq: 1,

      Child: rowEntries.map(([key, valueObj]: any) => {
        const elementName =
          key.split("+")[2];

        return {
          ElementName: elementName,
          Value: valueObj?.value ?? null,
          EDT: state[elementName]?.EDT ?? valueObj?.EDT ?? 9,
        };
      }),
    };

    const FormData = [
      {
        ElementName: gridName,
        Child: [formattedRow],
      },
    ];

    const postData = {
      SlotId: slotId,

      ControlId: gridName,

      PackageProcessMapId:
        activePage?.PackageProcessMapId,

      ProcessActivityMapId:
        activePage?.ProcessActivityMapId,

      ViewPort: 4,

      Action: "GridSave",

      FormInstanceId: formInstanceId,
      WidgetId: element.ParentElementId,

      JsxFileName: "",
      JsxFileVersion: "",

      Params: [],

      FormData,
    };

    await axiosHelper<IAppResponse>(
      config.SAVE_WIDGET_URL,
      "POST",
      postData
    );
  } catch (error) {
    console.error("SAVE GRID ROW ERROR", error);
    throw error;
  }
};