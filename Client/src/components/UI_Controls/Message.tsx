// Innovace Intech Solution Pvt Ltd
import React from "react";
import type { UIElement } from "../../constants/types";

const Message: React.FC<{
    element: UIElement;
    children?: React.ReactNode;
}> = ({ element: _element, children }) => {
    return (
        <div
            id="e50a5c68-8bd7-bc0d-67eb-24bd439e9e73"
            data-root="root_e50a5c68-8bd7-bc0d-67eb-24bd439e9e73"
            onClick={(event) =>
                (window as any).LayoutControlSelected?.(event, "e50a5c68-8bd7-bc0d-67eb-24bd439e9e73")
            }
            className="col-lg-12"
        >
            <div
                id="msg_e50a5c68-8bd7-bc0d-67eb-24bd439e9e73"
                data-name="msg_e50a5c68-8bd7-bc0d-67eb-24bd439e9e73"
                data-container="container_e50a5c68-8bd7-bc0d-67eb-24bd439e9e73"
                className="alert alert-primary alert-styled-left"
                style={{
                    fontWeight: "normal",
                    fontStyle: "normal",
                    textDecoration: "none",
                }}
            >
                {children ?? "Message"} </div> </div>
    );
};

export default Message;
