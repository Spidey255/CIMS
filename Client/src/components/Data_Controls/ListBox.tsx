// Innovace Intech Solution Pvt Ltd
import React, { useState } from "react";

interface ListItem {
  id: string;
  text: string;
}

const ListBox: React.FC = () => {
  const data: ListItem[] = [
    { id: "1", text: "Education" },
    { id: "2", text: "Banking" },
    { id: "3", text: "Manufacturing" },
  ];

  const [selectedIds, setSelectedIds] = useState<string[]>([]);

  const handleChange = (id: string) => {
    setSelectedIds((prev) =>
      prev.includes(id)
        ? prev.filter((x) => x !== id)
        : [...prev, id]
    );
  };

  return (
    <div className="col-lg-4">
      <div className="mb-3">
        <label className="form-label fw-semibold">
          MF_ListBox
        </label>

        <div
          className="border rounded p-2"
          style={{ height: "200px", overflowY: "auto" }}
        >
          {data.map((item) => (
            <div
              key={item.id}
              className="form-check d-flex align-items-center py-1"
            >
              <input
                className="form-check-input me-2"
                type="checkbox"
                id={`chk-${item.id}`}
                checked={selectedIds.includes(item.id)}
                onChange={() => handleChange(item.id)}
              />
              <label
                className="form-check-label"
                htmlFor={`chk-${item.id}`}
              >
                {item.text}
              </label>
            </div>
          ))}
        </div>
      </div>
    </div>
  );
};

export default ListBox;
