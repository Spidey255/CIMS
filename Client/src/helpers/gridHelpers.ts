// Innovace Intech Solution Pvt Ltd
import { v4 as uuidV4 } from "uuid";

import type {
  ServiceElementData,
  UIElement,
} from "../constants/types";
import { config } from "@/constants/config";
import axiosHelper from "./axiosHelper";
import { useUserStore } from "@/store/useUserStore";
import { usePageStore } from "@/store/usePageStore";
import { useGridStore } from "@/store/useGridStore";

export const getValidColumns = (gridInfo?: UIElement[]) => {
  return !gridInfo
    ? []
    : gridInfo?.filter(
        (f) =>
          f["Width"] === undefined &&
          !f.ElementName.includes("_Sequence") &&
          !f.ElementName.includes("_RowId")
      );
};

export const addRow = (
  tableHeaders: UIElement[]
): ServiceElementData => {
  const child = tableHeaders.map((head) => ({
    ElementId: head.ElementId,
    ElementName: head.ElementName,
    Value: "",
    Ect: undefined,
    EDT:head.EDT,
    Seq: 1,
    Chk: false,
    Visible: "true",
    BaCol: "",
    FCol: "",
    DCss: "",
    Dvl: undefined,
    RwId: uuidV4(),
    PeId: "",
    Child: undefined,
    PUrl: undefined,
    Man: false,
    RedirectType: undefined,
    ComboSelectedValue: undefined,
    RType: 0,
    BrCl: undefined,
  }));

  return {
    ElementId: "",
    ElementName: "",
    Value: "",
    Ect: undefined,
    Seq: 1,
    Chk: false,
    Visible: "true",
    BaCol: "",
    FCol: "",
    DCss: "",
    Dvl: undefined,
    RwId: uuidV4(),
    PeId: "",
    Child: child,
    PUrl: undefined,
    Man: false,
    RedirectType: undefined,
    ComboSelectedValue: undefined,
    RType: 0,
    BrCl: undefined,
    EDT:0,
  };
};

export const deleteGridInstanceData = async ({
  widgetId,
  controlId,
  selectedRowIds,
}: {
  widgetId: string;
  controlId: string;
  selectedRowIds: string[];
}) => {
  const slotId = useUserStore.getState().slotId || sessionStorage.getItem("accessToken");
  const activePage = usePageStore.getState().activePage;

  const data = await axiosHelper(
    `${config.DELETE_GRID_INSTANCE_DATA_URL}`,
    "POST",
    {
      "SlotId": slotId,
      "ControlId": controlId,
      "PackageProcessMapId": activePage?.PackageProcessMapId,
      "ProcessActivityMapId": activePage?.ProcessActivityMapId,
      "ViewPort": 4,    
      "FormInstanceId": activePage?.FormVersionId,
      "WidgetId": widgetId,
      "SelectedRowIds": selectedRowIds.join(",")
    },
  );

  return data;
};



export const getGridContextFromElement = (elementName: string) => {
  // NOT INSIDE GRID
  if (!elementName.includes("+")) {
    return null;
  }

  const [gridElementName, rowId, controlName] =
    elementName.split("+");

  const gridStore = useGridStore.getState();

  // mapper info
  const mapper =
    gridStore.gridElementMapper[gridElementName];

  if (!mapper) {
    return null;
  }

  // full grid data
  const gridData =
    gridStore.gridDynamicState[mapper.uiElementId];

  // grid configuration
  const gridInfo =
    gridStore.gridInfo[mapper.uiElementId];

  // current row
  const currentRow =
    gridData?.find((r) => r.RwId === rowId);

  return {
    gridElementName,
    rowId,
    controlName,

    uiElementId: mapper.uiElementId,

    mapper,
    gridInfo,
    gridData,
    currentRow,
  };
};