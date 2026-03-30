// Innovace Intech Solution Pvt Ltd
import { create } from "zustand";

interface RedirectState {
  params: Record<string, any>;
  setParams: (payload: Record<string, any>) => void;
  clearParams: () => void;
}

export const useRedirectStore = create<RedirectState>((set) => {
  // Retrieve stored params from sessionStorage (or localStorage if needed)
  const storedParams = sessionStorage.getItem("redirectParams");
  const initialParams = storedParams ? JSON.parse(storedParams) : {};

  return {
    params: initialParams,

    setParams: (payload) => {
      set(() => ({
        params: payload,
      }));

      // Store the params in sessionStorage for next reload
      sessionStorage.setItem("redirectParams", JSON.stringify(payload));
    },

    clearParams: () =>
      set(() => {
        sessionStorage.removeItem("redirectParams"); // Clear storage as well
        return { params: {} };
      }),
  };
});
