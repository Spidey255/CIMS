// Innovace Intech Solution Pvt Ltd
// import { create } from "zustand";
// import { devtools } from "zustand/middleware";
// import { v4 as uuidv4 } from "uuid";
// import type {
//     IPageStateValue
// } from "./../constants/types";

// type State = {
//   activePage: IPageStateValue | null;
//   formInstanceId: string | null;

// };

// type Action = {
//   setActivePage: (value: IPageStateValue) => void;
//   resetActivePage: () => void;
// };

// export const usePageStore = create<State & Action>()(
//   devtools(
//     (set) => ({
//         activePage: null,
//         formInstanceId: null,
//         setActivePage: (value) => set(() => ({ activePage: value, formInstanceId: uuidv4(), })),
//         resetActivePage: () => set(() => ({ activePage: null, formInstanceId: null, })),
//     }),
//     { name: "PageStore" }
//   )
// );


import { create } from "zustand";
import { devtools } from "zustand/middleware";
import type { IPageStateValue } from "./../constants/types";

type State = {
  activePage: IPageStateValue | null;
  formInstanceId: string | null;
};

type Action = {
  setActivePage: (value: IPageStateValue) => void;
  resetActivePage: () => void;
  setFormInstanceId: (id: string | null) => void;
};

export const usePageStore = create<State & Action>()(
  devtools(
    (set) => ({
      activePage: null,
      formInstanceId: null,
      setActivePage: (value) => set(() => ({ activePage: value })),
      resetActivePage: () => set(() => ({ activePage: null, formInstanceId: null })),
      setFormInstanceId: (id) => set(() => ({ formInstanceId: id })),  // New action to set formInstanceId
    }),
    { name: "PageStore" }
  )
);