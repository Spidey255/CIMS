// Innovace Intech Solution Pvt Ltd
import axios, { type AxiosRequestConfig, type AxiosResponse } from "axios";

import type { UIElement } from "../constants/types";
import { config } from "../constants/config";
import { usePageStore } from "@/store/usePageStore";
/**
 * Axios Helper method for making HTTP requests
 * @param url - The endpoint URL
 * @param method - The HTTP method (GET, POST, PUT, DELETE, etc.)
 * @param data - The request body (optional, for methods like POST, PUT)
 * @param headers - Additional headers (optional)
 * @param params - Additional headers (optional)
 * @returns Promise resolving to the response data or rejecting with an error object
 */
const axiosHelper = async <T>(
  url: string,
  method: "GET" | "POST" | "PUT" | "DELETE" | "PATCH" | string,
  data?: unknown,
  headers: Record<string, string> = {},
  params: Record<string, unknown> = {}
): Promise<T> => {
  try {
    const config: AxiosRequestConfig = {
      url,
      method,
      data,
      headers,
      params,
    };

    const response: AxiosResponse<T> = await axios(config);
    return response.data;
  } catch (error: unknown) {
    if (axios.isAxiosError(error)) {
      // Handle Axios-specific errors
      throw {
        message: error.message,
        status: error.response?.status,
        data: error.response?.data || null,
      };
    } else if (error instanceof Error) {
      // Handle generic JavaScript errors
      throw {
        message: error.message,
      };
    } else {
      // Fallback for unexpected errors
      throw {
        message: "An unknown error occurred",
      };
    }
  }
};

export const getFormOnLoadData = async <T>(
  slotId: string,
  element: UIElement,
  packageProcessMapId: string,
  processActivityMapId: string,
  formVersionId: string,
): Promise<T> => {
  const jsonBindingData = JSON.parse(element.BindingDetail || "");
  if (!jsonBindingData.length) throw new Error("No Binding Details Found");

  const url = jsonBindingData[0]?.Endpoint?.replace(/^~(?=\/)/, config.BASE_URL);
  const params = jsonBindingData[0]?.Params;
  const formInstanceId = usePageStore.getState().formInstanceId;

  const data = await axiosHelper<T>(
    url,
    "POST",
    JSON.stringify({
      SlotId: slotId,
      WidgetId: element.WidgetId,
      ControlId: element.WidgetId,
      PackageProcessMapId: packageProcessMapId,
      ProcessActivityMapId: processActivityMapId,
      FormVersionId: formVersionId,
      ViewPort: 4,
      FormInstanceId: formInstanceId || null,
      Action: element.Action,
      Params: params || [],
      FormData: [],
    }),
    {
      "Content-Type": "application/json",
    }
  );
  usePageStore.getState().setFormInstanceId((data as any).FormInstanceId || null);
  return data;
};

export const getWidgetInstanceData = async <T>(
  slotId: string,
  element: UIElement,
  packageProcessMapId: string,
  processActivityMapId: string,
  formVersionId: string,
): Promise<T> => {
  const data = await axiosHelper<T>(
    `${config.URL}:5009/api/iProofServicesHub/GetWidgetInstanceData`,
    "POST",
    JSON.stringify({
      SlotId: slotId,
      WidgetId: element["WidgetId"],
      ControlId: element["WidgetId"],
      PackageProcessMapId: packageProcessMapId,
      ProcessActivityMapId: processActivityMapId,
      FormVersionId: formVersionId,
      ViewPort: 4,
      Action: element["Action"],
      Params: [],
      FormData: [],
    }),
    {
      "Content-Type": "application/json",
    }
  );

  return data;
};

export const getGridInstanceData = async <T>({
  slotId,
  widgetId,
  controlId,
  pageDirection,
  pageSize,
  currentRowIndex,
  searchFilter,
  packageProcessMapId,
  processActivityMapId,
  formInstanceId,
}: {
  slotId: string;
  widgetId: string;
  controlId: string;
  pageDirection: number;
  pageSize: number;
  currentRowIndex: number;
  searchFilter: string;
  packageProcessMapId: string;
  processActivityMapId: string;
  formInstanceId: string;
}): Promise<T> => {
  const data = await axiosHelper<T>(
    config.GET_GRID_INSTANCE_URL,
    "POST",
    JSON.stringify({
      SlotId: slotId,
      WidgetId: widgetId,
      ControlId: controlId,
      PackageProcessMapId: packageProcessMapId,
      ProcessActivityMapId: processActivityMapId,
      FormInstanceId: formInstanceId,
      ViewPort: 4,
      Action: "GridLoad",
      PageDirection: pageDirection,
      PageSize: pageSize,
      CurrentRowIndex: currentRowIndex,
      SearchFilter: searchFilter,
    }),
    {
      "Content-Type": "application/json",
    }
  );

  return data;
};

axios.interceptors.response.use(
  (res) => {
    if (res.data?.Message == "Invalid Slot") {
      (window as any).triggerSessionTimeout?.();
    }
    return res;
  },
  (error) => {
    if (error.response?.status === 401) {
      (window as any).triggerSessionTimeout?.();
    }
    return Promise.reject(error);
  }
);

export default axiosHelper;
