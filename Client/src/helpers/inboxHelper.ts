// Innovace Intech Solution Pvt Ltd
// import { INBOX_SETTING_ID, API_TOKEN } from "../constant/config";

// const getTokenFromQuery = (): string | null => {
//     const params = new URLSearchParams(window.location.search);
//     return params.get("token"); // null if not found
// };

const BASE_URL: string = "http://210.18.135.72/iProofServicesHub/iProofServicesHub";
// const TOKEN: string | null = getTokenFromQuery();

interface FetchOptions extends RequestInit {}

interface InboxTaskResponse {
    InstanceData: any[];
}

const fetchData = async <T = any>(url: string, options: FetchOptions = {}): Promise<T> => {
    try {
        const response = await fetch(url, options);

        if (!response.ok) {
            throw new Error(`HTTP error! Status: ${response.status}`);
        }

        return await response.json();
    } catch (error) {
        console.error(`Error fetching data from ${url}:`, error);
        return [] as unknown as T;
    }
};

export const fetchModules = async (): Promise<any[]> => {
    const url = `${BASE_URL}/GetModuleList?token=${sessionStorage.getItem("accessToken")}`;
    return await fetchData<any[]>(url, { method: "POST" });
};

export const fetchSubModules = async (moduleId: number | string): Promise<InboxTaskResponse> => {
    if (!moduleId) return { InstanceData: [] };

    const url = `${BASE_URL}/GetReactInboxTaskList`;

    const requestBody = {
        InboxSettingsId: "F5F024F4-F02E-4126-974C-F97A71FD6EA5" + "#1",
        Direction: 1,
        FirstRowIndex: -1,
        PageSize: 10,
        SlotId: sessionStorage.getItem("accessToken"),
        Filter: `AFMPModuleId = ${moduleId}`,
    };

    const result = await fetchData<InboxTaskResponse>(url, {
        method: "POST",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify(requestBody),
    });

    return result || { InstanceData: [] };
};

export const fetchInboxTaskList = async (
    subModuleId: string | number,
    AFMPModuleId: string | number
): Promise<InboxTaskResponse> => {

    if (!subModuleId && !AFMPModuleId) return { InstanceData: [] };

    const url = `${BASE_URL}/GetReactInboxTaskList`;

    const requestBody = {
        InboxSettingsId: "F5F024F4-F02E-4126-974C-F97A71FD6EA5",
        Direction: 1,
        FirstRowIndex: -1,
        PageSize: 10,
        SlotId: sessionStorage.getItem("accessToken"),
        Filter: `AFMPModuleId = ${AFMPModuleId} AND packageprocessmapid = '${subModuleId}'`,
    };

    const result = await fetchData<InboxTaskResponse>(url, {
        method: "POST",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify(requestBody),
    });

    return result || { InstanceData: [] };
};