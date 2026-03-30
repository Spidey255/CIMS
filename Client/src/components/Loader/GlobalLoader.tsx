// Innovace Intech Solution Pvt Ltd
import "./globalLoader.css";
import { useLoaderStore } from "@/store/useLoaderStore";

const GlobalLoader = () => {
  const loading = useLoaderStore((s) => s.loading);

  if (!loading) return null;

  return (
    <div className="global-loader-overlay">
      <div className="global-loader">
        <div className="spinner"></div>
        <p>Please wait...</p>
      </div>
    </div>
  );
};

export default GlobalLoader;
