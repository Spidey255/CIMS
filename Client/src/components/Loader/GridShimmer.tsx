// Innovace Intech Solution Pvt Ltd
import React from "react";
import "./gridShimmer.css";

const GridShimmer: React.FC<{ rows?: number }> = ({ rows = 5 }) => {
  return (
    <div className="grid-shimmer-container">
      {Array.from({ length: rows }).map((_, i) => (
        <div key={i} className="grid-shimmer-row">
          <div className="grid-shimmer-cell sm"></div>
          <div className="grid-shimmer-cell md"></div>
          <div className="grid-shimmer-cell lg"></div>
          <div className="grid-shimmer-cell xl"></div>
          <div className="grid-shimmer-cell md"></div>
        </div>
      ))}
    </div>
  );
};

export default GridShimmer;
