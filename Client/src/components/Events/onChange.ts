// Innovace Intech Solution Pvt Ltd
// import { useGridStore } from "../../store/useGridStore";
// import { useGeneralStore } from "../../store/useStore";
// import { useUserStore } from "../../store/useUserStore";
// import { config } from "@/constants/config";
// import axiosHelper from "../../helpers/axiosHelper";
// import type {
//   IBindingData,
//   IActionParams,
//   IAppResponse,
//   IGlobalStateValues,
//   UIElement,
//   TValue,
// } from "../../constants/types";
// import { usePageStore } from "../../store/usePageStore";

// export async function resusableOnChange(element: UIElement) {
//   if (element.Action == "OnChange" && element.BindingDetail) {
//     try {
//       const slotId = useUserStore.getState().slotId || sessionStorage.getItem("accessToken");
//       const activePage = usePageStore.getState().activePage;

//       if (!element["BindingDetail"]) return console.log("No BindingDetail Found");

//       const bindingDetails = JSON.parse(element["BindingDetail"]) as IBindingData[];

//       if (!bindingDetails.length) return console.log("No Content in BindingDetail");

//       const details =
//         bindingDetails.length === 1
//           ? bindingDetails[0]
//           : bindingDetails.find((f) => f["Action"] === "OnChange");

//       if (!details) return [];

//       const url = details.Endpoint.replace(/^~(?=\/)/, config.BASE_URL);
//       const method = details.HttpVerb;

//       const params = JSON.parse(details["Params"]) as IActionParams[];
//       let elementIds = params.map((p) => p.ElementName);

//       if (element.ElementName.includes("+")) {
//         const [id, rwId] = element.ElementName.split("+");
//         const rowId = `${id}+${rwId}`;
//         elementIds = params.map((p) => `${rowId}+${p.ElementName}`);
//       }

//       const fetchedStateValues = elementIds.reduce((acc, id) => {
//         const ElementName = element.ElementName.includes("+")
//           ? id.split("+")[2]
//           : id;
//         acc[ElementName] = useGeneralStore.getState().state[id]?.["value"] || "";
//         return acc;
//       }, {} as Record<string, TValue | undefined>);

//       // Adding EDT to each stateParam
//       const stateParams = params.map(({ ElementName, Value, EDT }) => ({
//         ElementName,
//         Value: fetchedStateValues[ElementName] || Value, // Use the fetched value if available, else fallback to the default Value
//         EDT: EDT ?? undefined, // Ensure EDT is either a number or undefined
//       }));

//       const postData = {
//         SlotId: slotId,
//         ControlId: element["ElementName"].includes("+")
//           ? element["ElementName"].split("+")[2]
//           : element["ElementName"],
//         PackageProcessMapId: activePage?.PackageProcessMapId,
//         ProcessActivityMapId: activePage?.ProcessActivityMapId,
//         FormVersionId: activePage?.FormVersionId,
//         ViewPort: 4,
//         Action: element?.Action,
//         JsxFileName: "",
//         JsxFileVersion: "",
//         Params: stateParams, // This will now include EDT
//       };


//       const data = await axiosHelper<IAppResponse>(url, method, postData);

//       if (!data["Rows"])
//         return console.log(
//           "No rows in response in ACTION BUTTON " + element.Id
//         );

//       // REDIRECTION LOGICS
//       const redirectionInfo = data.Rows.filter((row) => Boolean(row["RType"]));

//       if (redirectionInfo.length) {
//         if (redirectionInfo[0].RType === 1) {
//           return; // Handle redirection logic here
//         }
//         // Handle other types of redirection if needed
//       }

//       // Update UI CONTROLS
//       const updateDataInfo = data.Rows.filter((row) => !Boolean(row["RType"]));

//       const updateState: { [key: string]: IGlobalStateValues } = {};

//       // updateDataInfo
//       //   .filter((f) => f["Child"] === null)
//       //   .forEach((row) => {
//       //     if (row["ElementName"]) {
//       //       // Dynamically update state with value and relement
//       //       updateState[row.ElementName] = { value: row.Value!, rElemData: row.rElemData };
//       //     }
//       //   });

//       updateDataInfo
//         .forEach((row) => {
//           if (row["ElementName"]) {
//             // Dynamically update state with value and relement
//             updateState[row.ElementName] = { value: row.Value!, rElemData: row.rElemData };
//           }
//         });


//       // GRID STATE UPDATE
//       data.Rows.filter((f) => f["Child"] && f["Child"].length).forEach((m) => {
//         if (m["ElementName"]) {
//           const elementMapper =
//             useGridStore.getState().gridElementMapper[m.ElementName];

//           m.Child?.map((row) => {
//             row.Child?.forEach((rowData) => {
//               // Dynamically update grid state based on element structure
//               updateState[
//                 `${elementMapper.elementName}+${row.RwId}+${rowData.ElementName}`
//               ] = {
//                 value: (typeof rowData["Value"] !== "object"
//                   ? rowData["Value"]
//                   : "") as string,
//               };
//             });
//           });

//           const { setGridDynamicState, setPagination } =
//             useGridStore.getState();
//           // Call dynamic grid state update
//           setGridDynamicState(elementMapper.uiElementId, m?.Child!);
//           setPagination(elementMapper.uiElementId, {
//             currentPage: 1,
//             pageSize: element["RowsPerPage"] || 5,
//             totalItems: m["TotalRecords"] || 0,
//             fromRowIndex: m["RecordsFrom"] || 0,
//             toRowIndex: m["RecordsTo"] || 0,
//           });
//         }
//       });

//       // Update the general store dynamically
//       useGeneralStore.getState().updateInitialState(updateState);
//     } catch (error) {
//       console.log(error);
//       alert("Something went wrong");
//     }
//   }
// }




import { useGridStore } from "../../store/useGridStore";
import { useGeneralStore } from "../../store/useStore";
import { useUserStore } from "../../store/useUserStore";
import { config } from "@/constants/config";
import axiosHelper from "../../helpers/axiosHelper";
import type {
  IBindingData,
  IActionParams,
  IAppResponse,
  IGlobalStateValues,
  UIElement,
  TValue,
} from "../../constants/types";
import { usePageStore } from "../../store/usePageStore";
import toast from "react-hot-toast";
import { saveGridRow } from "@/helpers/saveGridHelper";

export async function resusableOnChange(element: UIElement) {
  if (element.Action == "OnChange" && element.BindingDetail) {
    try {
      const slotId =
  useUserStore.getState().slotId ||
  sessionStorage.getItem("accessToken");

const activePage = usePageStore.getState().activePage;

const formInstanceId =
  usePageStore.getState().formInstanceId;

      if (!element["BindingDetail"]) return console.log("No BindingDetail Found");

      const bindingDetails = JSON.parse(element["BindingDetail"]) as IBindingData[];

      if (!bindingDetails.length) return console.log("No Content in BindingDetail");

     
      const savedFormInstanceId = await saveGridRow({
        element,
        formInstanceId,
      });
      console.log("Saved form instance id from onChange:", savedFormInstanceId);
      const details =
        bindingDetails.length === 1
          ? bindingDetails[0]
          : bindingDetails.find((f) => f["Action"] === "OnChange");

      if (!details) return [];

      const url = details.Endpoint.replace(/^~(?=\/)/, config.BASE_URL);
      const method = details.HttpVerb;

      const params = JSON.parse(details["Params"]) as IActionParams[];
      let elementIds = params.map((p) => p.ElementName);

      if (element.ElementName.includes("+")) {
        const [id, rwId] = element.ElementName.split("+");
        const rowId = `${id}+${rwId}`;
        elementIds = params.map((p) => `${rowId}+${p.ElementName}`);
      }

      const fetchedStateValues = elementIds.reduce((acc, id) => {
        const ElementName = element.ElementName.includes("+")
          ? id.split("+")[2]
          : id;
        acc[ElementName] = useGeneralStore.getState().state[id]?.["value"] || "";
        return acc;
      }, {} as Record<string, TValue | undefined>);

      // Adding EDT to each stateParam
      const stateParams = params.map(({ ElementName, Value, EDT }) => ({
        ElementName,
        Value: fetchedStateValues[ElementName] || Value, // Use the fetched value if available, else fallback to the default Value
        EDT: EDT ?? undefined, // Ensure EDT is either a number or undefined
      }));

      const postData = {
        SlotId: slotId,
        ControlId: element["ElementName"].includes("+")
          ? element["ElementName"].split("+")[2]
          : element["ElementName"],
        PackageProcessMapId: activePage?.PackageProcessMapId,
        ProcessActivityMapId: activePage?.ProcessActivityMapId,
        FormInstanceId: formInstanceId,
        FormVersionId: activePage?.FormVersionId,
        ViewPort: 4,
        Action: element?.Action,
        JsxFileName: "",
        JsxFileVersion: "",
        Params: stateParams, // This will now include EDT
      };


      const data = await axiosHelper<IAppResponse>(url, method, postData);

      if (!data["Rows"])
        return console.log(
          "No rows in response in ACTION BUTTON " + element.Id
        );

      if (data.Message) {
        if (data.Message.split(":")[0].toLowerCase() === "success") {
          toast.success(data.Message);
        } else if (data.Message.split(":")[0].toLowerCase() === "warning") {
          toast.error(data.Message.split(":")[1]);
        } else if (data.Message.split(":")[0].toLowerCase() === "error") {
          toast.error(data.Message.split(":")[1]);
        } else {
          toast.error(data.Message.split(":")[1]);
        }
        // toast.error(data.Message);

      }


      // REDIRECTION LOGICS
      const redirectionInfo = data.Rows.filter((row) => Boolean(row["RType"]));

      if (redirectionInfo.length) {
        if (redirectionInfo[0].RType === 1) {
          return; // Handle redirection logic here
        }
        // Handle other types of redirection if needed
      }

      // Update UI CONTROLS
      const updateDataInfo = data.Rows.filter((row) => !Boolean(row["RType"]));

      const updateState: { [key: string]: IGlobalStateValues } = {};

      // updateDataInfo
      //   .filter((f) => f["Child"] === null)
      //   .forEach((row) => {
      //     if (row["ElementName"]) {
      //       // Dynamically update state with value and relement
      //       updateState[row.ElementName] = { value: row.Value!, rElemData: row.rElemData };
      //     }
      //   });

      const currentState = useGeneralStore.getState().state;

      updateDataInfo.forEach((row) => {
        if (row["ElementName"]) {
          updateState[row.ElementName] = {
            ...currentState[row.ElementName], // ✅ keep existing state

            value: row.Value ?? "",

            // ✅ ADD THIS (VISIBLE PART FIX)
            isVisible: row.Visible,
            visible: row.Visible,

            // ✅ OPTIONAL (if backend sends these)
            ShowDialog: row.ShowDialog ?? false,
            HideDialog: row.HideDialog ?? false,
            ShowModal: row.ShowModal ?? false,

            rElemData: row.rElemData,
          };
        }
      });

      // GRID STATE UPDATE
      data.Rows.filter((f) => f["Child"] && f["Child"].length).forEach((m) => {
        if (m["ElementName"]) {
          const elementMapper =
            useGridStore.getState().gridElementMapper[m.ElementName];

          m.Child?.map((row) => {
            row.Child?.forEach((rowData) => {
              // Dynamically update grid state based on element structure
              updateState[
                `${elementMapper.elementName}+${row.RwId}+${rowData.ElementName}`
              ] = {
                value: (typeof rowData["Value"] !== "object"
                  ? rowData["Value"]
                  : "") as string,
              };
            });
          });

          const { setGridDynamicState, setPagination } =
            useGridStore.getState();
          // Call dynamic grid state update
          // setGridDynamicState(elementMapper.uiElementId, m?.Child!);
          // setPagination(elementMapper.uiElementId, {
          //   currentPage: 1,
          //   pageSize: element["RowsPerPage"] || 5,
          //   totalItems: m["TotalRecords"] || 0,
          //   fromRowIndex: m["RecordsFrom"] || 0,
          //   toRowIndex: m["RecordsTo"] || 0,
          // });

          setGridDynamicState(elementMapper.uiElementId, m.Child!);
          setPagination(elementMapper.uiElementId, {
            currentPage: 1,
            pageSize: m?.PageCount || 5,
            totalItems: m.Child?.length || 0,
            fromRowIndex: m.RecordsFrom || 0,
            toRowIndex: m.RecordsTo || 0,
          });
        }
      });

      // Update the general store dynamically
      useGeneralStore.getState().updateInitialState(updateState);
    } catch (error) {
      console.log(error);
      alert("Something went wrong");
    }
  }
}
