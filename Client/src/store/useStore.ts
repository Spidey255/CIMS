// Innovace Intech Solution Pvt Ltd
import { create } from "zustand";
import type {
  ServiceElementData,
  IGlobalStateValues,
} from "../constants/types";
import { devtools } from "zustand/middleware";

type TState = Record<string, IGlobalStateValues>;

type State = {
  state: TState;
  uiElementState: Record<string, Partial<ServiceElementData>>;
  comboReady: boolean;
};

type Action = {
  setInitialState: (initialState: TState) => void;
  updateInitialState: (state: TState) => void;
  setState: (key: string, value: string | boolean) => void;
   setComboReady: (value: boolean) => void;

  // setState: (key: string, value: string | number, edt: number | null) => void;


  setUIElementState: (
    uiElementState: Record<string, Partial<ServiceElementData>>
  ) => void;
  updateUIElementState: (
    key: string,
    value: Partial<ServiceElementData>
  ) => void;

  resetState: () => void;
  resetUIElementState: () => void;
};

export const useGeneralStore = create<State & Action>()(
  devtools(
    (set) => ({
      state: {},
      setInitialState: (initialState) => set(() => ({ state: initialState })),
      updateInitialState: (updateState) =>
        set((store) => ({ state: { ...store.state, ...updateState } })),

      setState: (key: string, value: string | number, edt: number | null) =>
        set((state) => ({
          state: {
            ...state.state,
            [key]: {
              ...state.state[key],
              value,
              EDT: edt,
            },
          },
        })),


      uiElementState: {},
      comboReady: false,

      setComboReady: (value) =>
  set(() => ({ comboReady: value })),
      setUIElementState: (uiElementState) => set(() => ({ uiElementState })),
      updateUIElementState: (key, value) =>
        set((state) => ({
          uiElementState: {
            ...state.uiElementState,
            [key]: { ...(state.uiElementState[key] || {}), ...value },
          },
        })),

      resetState: () => set(() => ({ state: {} })),
      resetUIElementState: () => set(() => ({ uiElementState: {} })),
    }),
    { name: "GeneralStore" }
  )
);
