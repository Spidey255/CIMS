// Innovace Intech Solution Pvt Ltd
import { useEffect, useMemo, useState } from "react";
import { fetchModules } from "@/helpers/inboxHelper";

interface Module {
    moduleId: string;
    moduleName: string;
}

interface SidebarProps {
    onModuleSelect: (moduleId: string) => void;
    onModuleSelectName: (moduleName: string) => void;
    selectedModuleId: string | null;
}

const SidebarShimmer: React.FC = () => {
    return (
        <div className="inb-sidebar">
            {Array.from({ length: 10 }).map((_, i) => (
                <div key={i} className="inb-sidebar-item inb-shimmer-sidebar">
                    <div className="inb-shimmer-text"></div>
                </div>
            ))}
        </div>
    );
};

const Sidebar: React.FC<SidebarProps> = ({
    onModuleSelect,
    onModuleSelectName,
    selectedModuleId,
}) => {
    const [loading, setLoading] = useState<boolean>(true);
    const [modules, setModules] = useState<Module[]>([]);
    const [showOtherPopup, setShowOtherPopup] = useState<boolean>(false);

    const activeId = selectedModuleId;

    useEffect(() => {
     

        const loadModules = async () => {
            try {
                setLoading(true);
                const data: Module[] = await fetchModules();

               

                setModules(data);

                const storedId = localStorage.getItem("selectedModuleId");
                const storedName = localStorage.getItem("selectedModuleName");

                if (storedId && storedName) {
                    onModuleSelect(storedId);
                    onModuleSelectName(storedName);
                } else if (data.length > 0) {
                    const first = data[0];

                    onModuleSelect(first.moduleId);
                    onModuleSelectName(first.moduleName);

                    localStorage.setItem("selectedModuleId", first.moduleId);
                    localStorage.setItem("selectedModuleName", first.moduleName);
                }
                setLoading(false);
            } catch (error) {
                console.error("Failed to load modules", error);
                setLoading(false);
            } finally {
                 setLoading(false);
            }
        };

        loadModules();
    }, [onModuleSelect, onModuleSelectName]);

    const handleModuleClick = (moduleId: string, moduleName: string) => {
        onModuleSelect(moduleId);
        onModuleSelectName(moduleName);

        localStorage.setItem("selectedModuleId", moduleId);
        localStorage.setItem("selectedModuleName", moduleName);

        localStorage.removeItem("activeMenuUrl");

        setShowOtherPopup(false);
    };

    const visibleModules = useMemo(() => modules.slice(0, 10), [modules]);
    const otherModules = useMemo(() => modules.slice(9), [modules]);

    if (loading) return <SidebarShimmer />;

    return (
        <div className="inb-sidebar">
            {visibleModules.map(({ moduleId, moduleName }) => (
                <div
                    key={moduleId}
                    className={`inb-sidebar-item ${String(activeId) === String(moduleId) ? "active" : ""
                        }`}
                    onClick={() => handleModuleClick(moduleId, moduleName)}
                >
                    <i className="icon ph ph-stack"></i>
                    <span>{moduleName}</span>
                </div>
            ))}

            {otherModules.length > 0 && (
                <div
                    className={`inb-sidebar-item ${showOtherPopup ? "active" : ""}`}
                    onClick={() => setShowOtherPopup((prev) => !prev)}
                >
                    <i className="icon bi bi-three-dots"></i>
                    <span>More</span>
                </div>
            )}

            {showOtherPopup && (
                <div className="inb-other-popup">
                    <div className="inb-content-pop">
                        {otherModules.map(({ moduleId, moduleName }) => (
                            <div
                                key={moduleId}
                                className={`inb-popup-item ${String(activeId) === String(moduleId) ? "active" : ""
                                    }`}
                                onClick={() => handleModuleClick(moduleId, moduleName)}
                            >
                                {moduleName}
                            </div>
                        ))}
                    </div>
                </div>
            )}
        </div>
    );
};

export default Sidebar;