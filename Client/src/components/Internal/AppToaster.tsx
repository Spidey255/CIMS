// Innovace Intech Solution Pvt Ltd
// AppToaster.tsx

import { Toaster } from "react-hot-toast";

export const AppToaster = () => {
  return (
    <Toaster
      position="top-center"
      reverseOrder={false}
      gutter={12}
      toastOptions={{
        duration: 4000,

        style: {
          borderRadius: "18px",
          padding: "14px 18px",
          color: "#fff",
          fontSize: "14px",
          fontWeight: "600",
          boxShadow: "0 10px 30px rgba(0,0,0,0.25)",
        },

        // SUCCESS
        success: {
          style: {
            background: "#16a34a",
          },
          iconTheme: {
            primary: "#fff",
            secondary: "#16a34a",
          },
        },

        // ERROR
        error: {
          style: {
            background: "#dc2626",
          },
          iconTheme: {
            primary: "#fff",
            secondary: "#dc2626",
          },
        },

        // WARNING
        blank: {
          style: {
            background: "#ffa200",
          },
          iconTheme: {
            primary: "#fff",
            secondary: "#f59e0b",
          },
        },

        // LOADING
        loading: {
          style: {
            background: "#2563eb",
          },
        },
      }}
    />
  );
};