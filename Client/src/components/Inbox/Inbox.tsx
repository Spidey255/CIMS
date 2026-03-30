// Innovace Intech Solution Pvt Ltd
import { useState } from "react";
import Sidebar from "@/components/Inbox/Sidebar";
import InboxContainer from "@/components/Inbox/InboxContainer";
import "./inbox.css";

const Inbox: React.FC = () => {
    const [selectedModuleId, setSelectedModuleId] = useState<string | null>(
        localStorage.getItem("selectedModuleId")
    );

    const [selectedModuleName, setSelectedModuleName] = useState<string | null>(
        localStorage.getItem("selectedModuleName")
    );

    return (
        <div className="inb-main-container">
            <div className="inb-header">My Queue</div>
            <div className="inb-bottom-container">
                <Sidebar
                    onModuleSelect={setSelectedModuleId}
                    onModuleSelectName={setSelectedModuleName}
                    selectedModuleId={selectedModuleId}
                />

                <InboxContainer
                    selectedModuleId={selectedModuleId}
                    selectedModuleName={selectedModuleName}
                />
            </div>
        </div>
    );
};

export default Inbox;