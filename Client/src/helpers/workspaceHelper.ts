// Innovace Intech Solution Pvt Ltd
import axios from "axios";

const BASE_URL = import.meta.env.VITE_BASE_EXECUTION_URL as string;

export interface Workspace {
  portalGroupId: string;
  portalName: string;
}

export interface MenuItem {
  key?: string;
  label: string;
  icon?: string;
  path?: string;
  children?: MenuItem[];
}

const api = axios.create({
  baseURL: BASE_URL,
  headers: {
    "Content-Type": "application/json",
  },
  timeout: 15000,
});

/* ---------------- CACHE ---------------- */

let workspaceCache: Workspace[] | null = null;
const menuCache: Record<string, MenuItem[]> = {};

/**
 * Get Workspace List
 */
export const getWorkSpaces = async (
  slotId: string
): Promise<Workspace[]> => {
  if (workspaceCache) return workspaceCache;

  try {
    const { data } = await api.post<Workspace[]>(
      "/RemoteGateway/GetWorkSpaceConfig",
      null,
      { params: { slotId } }
    );

    workspaceCache = data;

    return data;
  } catch (error) {
    console.error("Workspace API Failed:", error);
    return [];
  }
};

/**
 * Get Workspace Menu
 */
export const getWorkspaceMenu = async (
  slotId: string,
  portalGroupId: string
): Promise<MenuItem[]> => {
  const cacheKey = `${slotId}_${portalGroupId}`;

  if (menuCache[cacheKey]) return menuCache[cacheKey];

  try {
    const { data } = await api.post(
      "/RemoteGateway/GetWorkspaceMenuConfig",
      null,
      {
        params: { slotId, portalGroupId },
      }
    );

    if (!data?.portalMenuJson) return [];

    const parsedMenu = JSON.parse(data.portalMenuJson);

    menuCache[cacheKey] = parsedMenu;

    return parsedMenu;
  } catch (error) {
    console.error("Workspace Menu API Failed:", error);
    return [];
  }
};


export const clearWorkspaceCache = () => {
  workspaceCache = null;

  Object.keys(menuCache).forEach((key) => {
    delete menuCache[key];
  });
};