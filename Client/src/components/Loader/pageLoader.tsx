// Innovace Intech Solution Pvt Ltd
import "./pageLoader.css";
import { useLoaderStore } from "@/store/useLoaderStore";

const GlobalLoader = () => {
  const loading = useLoaderStore((s) => s.loading);

  if (!loading) return null;

  return (
    <div className="global-loader-overlay">
      <div className="global-loader">
        <div className="loader-animation">
          <span></span>
          <span></span>
          <span></span>
        </div>
        <p className="loader-text">Loading, please wait...</p>
      </div>
    </div>
  );
};

export default GlobalLoader;