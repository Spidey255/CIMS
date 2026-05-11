// Innovace Intech Solution Pvt Ltd
import React, { useState, useEffect } from "react";
import type { UIElement } from "../../constants/types";

interface TreeNode {
  id: string;
  name: string;
  status?: string;
  owner?: string;
  priority?: string;
  dueDate?: string;
  children?: TreeNode[];
}

const TreeGrid: React.FC<{ element: UIElement }> = () => {
  const [data, setData] = useState<TreeNode[]>([
    {
      id: "1",
      name: "Project Alpha",
      status: "Active",
      owner: "John",
      priority: "High",
      dueDate: "2026-04-10",
      children: [
        {
          id: "1-1",
          name: "Planning",
          status: "Completed",
          owner: "Mike",
          priority: "Medium",
          dueDate: "2026-03-20",
          children: [
            {
              id: "1-1-1",
              name: "Requirement Gathering",
              status: "Done",
              owner: "Sara",
              priority: "High",
              dueDate: "2026-03-10",
            },
          ],
        },
        {
          id: "1-2",
          name: "Development",
          status: "In Progress",
          owner: "David",
          priority: "High",
          dueDate: "2026-05-01",
        },
      ],
    },
    {
      id: "2",
      name: "Project Beta",
      status: "Pending",
      owner: "Anna",
      priority: "Low",
      dueDate: "2026-06-15",
    },
  ]);

  const [expanded, setExpanded] = useState<Record<string, boolean>>({});

  const toggle = (id: string) => {
    setExpanded((prev) => ({ ...prev, [id]: !prev[id] }));
  };

  const addChild = (parentId: string) => {
    const newNode: TreeNode = {
      id: Date.now().toString(),
      name: "New Item",
      status: "New",
      owner: "User",
      priority: "Low",
      dueDate: "-",
    };

    const update = (nodes: TreeNode[]): TreeNode[] =>
      nodes.map((n) =>
        n.id === parentId
          ? { ...n, children: [...(n.children || []), newNode] }
          : {
              ...n,
              children: n.children ? update(n.children) : undefined,
            }
      );

    setData(update(data));
    setExpanded((prev) => ({ ...prev, [parentId]: true }));
  };

  const deleteNode = (id: string) => {
    const remove = (nodes: TreeNode[]): TreeNode[] =>
      nodes
        .filter((n) => n.id !== id)
        .map((n) => ({
          ...n,
          children: n.children ? remove(n.children) : undefined,
        }));

    setData(remove(data));
  };

  useEffect(() => {
    const init: Record<string, boolean> = {};
    data.forEach((d) => (init[d.id] = true));
    setExpanded(init);
  }, []);

  const getPriorityClass = (priority?: string) => {
    switch (priority) {
      case "High":
        return "badge bg-danger";
      case "Medium":
        return "badge bg-warning text-dark";
      case "Low":
        return "badge bg-secondary";
      default:
        return "badge bg-light text-dark";
    }
  };

  const renderRows = (nodes: TreeNode[], level = 0) =>
    nodes.map((node) => (
      <React.Fragment key={node.id}>
        <tr className="tree-row">
          <td>
            <div
              className="d-flex align-items-center"
              style={{ paddingLeft: level * 24 }}
            >
              {node.children && (
                <span
                  className="toggle-icon me-2"
                  onClick={() => toggle(node.id)}
                >
                  {expanded[node.id] ? (
                    <i className="ph ph-caret-down"></i>
                  ) : (
                    <i className="ph ph-caret-right"></i>
                  )}
                </span>
              )}

              <span className="node-text">{node.name}</span>
            </div>
          </td>

          {/* ✅ NEW COLUMNS */}
          <td>{node.status || "-"}</td>
          <td>{node.owner || "-"}</td>
          <td>
            <span className={getPriorityClass(node.priority)}>
              {node.priority || "-"}
            </span>
          </td>
          <td>{node.dueDate || "-"}</td>

          <td className="text-end">
            <a
              className=" bg-light border p-1 rounded-2"
              onClick={() => addChild(node.id)}
            >
             <i className="ph ph-plus"></i>
            </a>

            
            <button
              className=" bg-light border p-1 rounded-2 ms-1"
              onClick={() => deleteNode(node.id)}
            >
             <i className="ph ph-trash"></i>
            </button>
          </td>
        </tr>

        {expanded[node.id] &&
          node.children &&
          renderRows(node.children, level + 1)}
      </React.Fragment>
    ));

  return (
    <div className="treegrid-card card">
      <div className="treegrid-header">
        <h6>Tree Grid</h6>
      </div>

      <div className="table-responsive">
        <table className="table align-middle mb-0">
          <thead>
            <tr>
              <th>Item</th>
              <th>Status</th>
              <th>Owner</th>
              <th>Priority</th>
              <th>Due Date</th>
              <th className="text-end">Actions</th>
            </tr>
          </thead>

          <tbody>
            {data.length ? (
              renderRows(data)
            ) : (
              <tr>
                <td colSpan={6} className="text-center py-4">
                  No Data Available
                </td>
              </tr>
            )}
          </tbody>
        </table>
      </div>

      {/* ✅ small UI polish */}
      <style>{`
        .tree-row:hover {
          background: #f8fafc;
        }

        .toggle-icon {
          cursor: pointer;
        }

        .node-text {
          font-weight: 500;
        }
      `}</style>
    </div>
  );
};

export default TreeGrid;