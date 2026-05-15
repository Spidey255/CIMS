// Innovace Intech Solution Pvt Ltd
import { create } from "zustand";

interface MenuState {
  menuReady: boolean;
  setMenuReady: (val: boolean) => void;
}

export const useMenuStore = create<MenuState>((set) => ({
  menuReady: true, // ✅ IMPORTANT (prevents blank screen)
  setMenuReady: (val) => set({ menuReady: val }),
}));