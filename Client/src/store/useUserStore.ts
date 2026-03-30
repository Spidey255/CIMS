// Innovace Intech Solution Pvt Ltd
import { create } from "zustand";

type State = {
  slotId: string | null;
  isAuthenticating: boolean;
  error: string | null;
};

type Action = {
  setSlotId: (slotId: string) => void;
  setIsAuthenticated: (value: boolean) => void;
  setError: (error: string | null) => void;
  logout: () => void;
};

export const useUserStore = create<State & Action>((set) => ({
  slotId: null,
  isAuthenticating: true,
  error: null,

  setSlotId: (slotId) => set({ slotId }),
  setIsAuthenticated: (value) => set({ isAuthenticating: value }),
  setError: (error) => set({ error }),
  logout: () => {
    sessionStorage.removeItem("accessToken");
    set({ slotId: null, isAuthenticating: false, error: null });
  },
}));
