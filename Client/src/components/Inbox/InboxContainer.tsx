// Innovace Intech Solution Pvt Ltd
import React, {
    useEffect,
    useState,
    useCallback,
    useRef,
    useMemo,
    Suspense
} from "react";
import { fetchSubModules, fetchInboxTaskList } from "@/helpers/inboxHelper";
import { usePageStore } from "@/store/usePageStore";

import nodataimg from "./nodata.png";

interface InboxContainerProps {
    selectedModuleId: string | null;
    selectedModuleName: string | null;
}

interface SubModule {
    PackageProcessMapId: string;
    ProcessName: string;
    AFMPModuleId: string;
}

interface InstanceItem {
    InstanceId: string;
    PackageProcessMapId: string;
    ActivityMapId: string;
    ProcessPath: string;
    Version: string;
    MasterFormElementId: string;
    FormVersionId: string;
    Description?: string;
    TaskName?: string;
    DefaultProcessedOn?: string;
    ["Initiated By"]?: string;
    ["Initiated On"]?: string;
}

const InboxShimmer: React.FC = () => {
    return (
        <ul className="inb-inbox-list-group">
            {Array.from({ length: 4 }).map((_, i) => (
                <li key={i} className="inb-inbox-list inb-shimmer-card">
                    <div className="inb-shimmer-line title"></div>
                </li>
            ))}
        </ul>
    );
};

const InboxContainer: React.FC<InboxContainerProps> = ({
    selectedModuleId,
    selectedModuleName,
}) => {
    const [subModules, setSubModules] = useState<SubModule[]>([]);
    const [instanceData, setInstanceData] = useState<InstanceItem[]>([]);
    const [selectedSubModule, setSelectedSubModule] = useState<string>("");
    const [selectedSubModuleName, setSelectedSubModuleName] = useState<string>("");
    const [selectedInstance, setSelectedInstance] = useState<InstanceItem | null>(null);

    const [loading, setLoading] = useState<boolean>(true);
    const [searchTerm, setSearchTerm] = useState<string>("");
    const [filterField, setFilterField] = useState<string>("all");
    const [visibleItems, setVisibleItems] = useState<number>(20);

    const scrollRef = useRef<HTMLDivElement | null>(null);

    /* ---------------------------------------------------- */
    /* Dynamic Page Loader */
    /* ---------------------------------------------------- */
    const pageModules = import.meta.glob("/src/pages/**/index.{tsx,jsx}");

    const DynamicInstanceComponent: React.FC<{ processPath: string; instanceId: string }> = ({
        processPath,
        instanceId
    }) => {
        usePageStore.getState().setFormInstanceId(instanceId || null);
        const LazyComponent = useMemo(() => {
            const tsxPath = `/src/pages/${processPath}/index.tsx`;
            const jsxPath = `/src/pages/${processPath}/index.jsx`;
            const importer = pageModules[tsxPath] || pageModules[jsxPath];
            if (!importer) return null;
            return React.lazy(importer as any);
        }, [processPath]);

        if (!LazyComponent) return null;

        return (
            <Suspense fallback={<div className="d-flex justify-content-center align-items-center h-100" style={{ padding: 20 }}>Loading form...</div>}>
                <div className="ibx-frm"><LazyComponent /></div>
            </Suspense>
        );
    };

    const resetState = () => {
        setSubModules([]);
        setSelectedSubModule("");
        setSelectedSubModuleName("");
        setInstanceData([]);
        setSelectedInstance(null);
        setSearchTerm("");
        setFilterField("all");
        setVisibleItems(20);
    };

    const fetchInstanceList = async (subModuleId: string, AFMPModuleId: string) => {
        if (!subModuleId || !AFMPModuleId) return;
        setLoading(true);
        try {
            const response = await fetchInboxTaskList(subModuleId, AFMPModuleId);
            const instances: InstanceItem[] = response?.InstanceData || [];
            setInstanceData(instances);
            setVisibleItems(20);
        } catch (error) {
            console.error("Error fetching instance data:", error);
        } finally {
            setLoading(false);
        }
    };

    useEffect(() => {
        let mounted = true;
        const loadSubModules = async () => {
            if (!selectedModuleId) {
                resetState();
                return;
            }
            resetState();
            setLoading(true);
            try {
                const data = await fetchSubModules(selectedModuleId);
                if (!mounted) return;

                const modules: SubModule[] = data?.InstanceData || [];
                resetState();
                setSubModules(modules);

                let initial = modules[0]; // default first submodule
                if (initial) {
                    setSelectedSubModule(initial.PackageProcessMapId);
                    setSelectedSubModuleName(initial.ProcessName);
                    fetchInstanceList(initial.PackageProcessMapId, initial.AFMPModuleId);
                }

            } catch (error) {
                console.error("Error fetching submodules:", error);
            } finally {
                if (mounted) setLoading(false);
            }
        };

        loadSubModules();
        return () => { mounted = false; };
    }, [selectedModuleId]);

    const handleSubModuleChange = useCallback(
        (e: React.ChangeEvent<HTMLSelectElement>) => {
            const subModuleId = e.target.value;
            const subModule = subModules.find(
                (m) => String(m.PackageProcessMapId) === String(subModuleId)
            );

            setSelectedSubModule(subModuleId);
            setSelectedSubModuleName(subModule?.ProcessName || "");
            setSelectedInstance(null);
            setSearchTerm("");
            setFilterField("all");

            if (subModule) {
                fetchInstanceList(subModuleId, subModule.AFMPModuleId);
            }
        },
        [subModules]
    );

    const handleInstanceClick = useCallback((instance: InstanceItem) => {
        setSelectedInstance(instance);
    }, []);

    // ---------- FILTERED DATA WITH FILTER FIELD ----------
    const filteredInstanceData = useMemo(() => {
        if (!selectedSubModule) return [];
        const term = searchTerm.toLowerCase();

        if (!term) return instanceData;

        return instanceData.filter((item) => {
            switch (filterField) {
                case "initiatedBy":
                    return item["Initiated By"]?.toLowerCase().includes(term);
                case "initiatedOn":
                    return item["Initiated On"]?.toLowerCase().includes(term);
                case "dueDate":
                    return item.DefaultProcessedOn?.toLowerCase().includes(term);
                case "descriptionOrTask":
                    return item.Description?.toLowerCase().includes(term) || item.TaskName?.toLowerCase().includes(term);
                case "all":
                default:
                    return (
                        item["Initiated By"]?.toLowerCase().includes(term) ||
                        item["Initiated On"]?.toLowerCase().includes(term) ||
                        item.DefaultProcessedOn?.toLowerCase().includes(term) ||
                        item.Description?.toLowerCase().includes(term) ||
                        item.TaskName?.toLowerCase().includes(term)
                    );
            }
        });
    }, [instanceData, searchTerm, filterField, selectedSubModule]);

    const handleScroll = () => {
        const ref = scrollRef.current;
        if (!ref) return;
        const { scrollTop, scrollHeight, clientHeight } = ref;
        if (scrollTop + clientHeight >= scrollHeight - 50) {
            setVisibleItems((prev) => prev + 20);
        }
    };

    useEffect(() => {
        const ref = scrollRef.current;
        if (!ref) return;
        ref.addEventListener("scroll", handleScroll);
        return () => ref.removeEventListener("scroll", handleScroll);
    }, []);



    return (
        <div className="inb-main-content">
            <div className="inb-left-section" ref={scrollRef} style={{ maxHeight: "100vh" }}>

                {/* SubModule Dropdown */}
                <select
                    className="form-select"
                    disabled={!selectedModuleId || loading}
                    value={selectedSubModule}
                    onChange={handleSubModuleChange}
                >
                    <option value="">
                        {selectedModuleId ? "Select a submodule" : "Select a module first"}
                    </option>
                    {subModules.map(({ PackageProcessMapId, ProcessName }) => (
                        <option key={PackageProcessMapId} value={PackageProcessMapId}>
                            {ProcessName}
                        </option>
                    ))}
                </select>

                {/* ---- CUSTOM FILTER + SEARCH UI ---- */}
                <div className="inb-filter_search" style={{ margin: "10px 0" }}>
                    <div className="custom-filter-wrapper" style={{ position: "relative", display: "inline-block" }}>
                        <select
                            className="lt_filter"
                            value={filterField}
                            onChange={(e) => setFilterField(e.target.value)}
                            style={{
                                fontSize: "12px",
                                opacity: 0,
                                position: "absolute",
                                top: 0,
                                left: 0,
                                width: "100%",
                                height: "100%",
                                zIndex: 2,
                                cursor: "pointer"
                            }}
                        >
                            <option value="all">All</option>
                            <option value="initiatedBy">Initiated By</option>
                            <option value="initiatedOn">Initiated On</option>
                            <option value="dueDate">Due Date</option>
                            <option value="descriptionOrTask">Task Name / Description</option>
                        </select>
                        <div style={{
                            fontSize: "16px",
                            padding: "5px 10px",
                            border: "1px solid #ccc",
                            borderRadius: "4px",
                            backgroundColor: "#fff",
                            pointerEvents: "none",
                            display: "flex",
                            alignItems: "center",
                            gap: "5px",
                            height: "37px"
                        }}>
                            {/* <BiFilterAlt /> */}
                            <span style={{ fontSize: "12px", color: "#555" }}>
                                {{
                                    initiatedBy: "By",
                                    initiatedOn: "On",
                                    dueDate: "Due",
                                    descriptionOrTask: "Task",
                                    all: "All"
                                }[filterField]}
                            </span>
                        </div>
                    </div>

                    <div className="lt_search" style={{ display: "inline-block", flex: 1, position: "relative" }}>
                        <input
                            type="text"
                            className="form-control border-0 shadow-none inb-srch"
                            placeholder="Search"
                            value={searchTerm}
                            onChange={(e) => setSearchTerm(e.target.value)}
                        />
                        <i style={{ position: "absolute", right: "10px", top: "50%", transform: "translateY(-50%)" }}>
                            {/* <FiSearch /> */}
                        </i>
                    </div>
                </div>

                {loading ? (
                    <InboxShimmer />
                ) : filteredInstanceData.length > 0 ? (
                    <ul className="inb-inbox-list-group">
                        {filteredInstanceData.slice(0, visibleItems).map((item) => (
                            <li
                                key={`${item.InstanceId}-${item.ActivityMapId}`}
                                className={`inb-inbox-list ${selectedInstance?.InstanceId === item.InstanceId ? "active" : ""}`}
                                onClick={() => handleInstanceClick(item)}
                            >
                                <div className="inb-inbox-content">
                                    <h3>{item?.Description || item?.TaskName}</h3>
                                </div>
                                <div className="inb-inbox-content">
                                    <label>Initiated By</label>
                                    <span> {item["Initiated By"]}</span>
                                </div>
                                <div className="task-progress">

                                    <div className="timeline-point completed">
                                        <div className="dot"></div>
                                        <div className="timeline-text">
                                            <label>Started</label>
                                            <span>{item["Initiated On"]?.split(" ")[0]}</span>
                                        </div>
                                    </div>

                                    <div className="timeline-line"></div>

                                    <div className="timeline-point pending">
                                        <div className="dot"></div>
                                        <div className="timeline-text">
                                            <label>Due</label>
                                            <span>{item.DefaultProcessedOn}</span>
                                        </div>
                                    </div>

                                </div>
                            </li>
                        ))}
                    </ul>
                ) : (
                    <p>No Instance found.</p>
                )}
            </div>

            <div className="inb-right-section">
                {selectedInstance && selectedModuleId ? (
                    <>
                        <div className="inb-header-section">
                            <h5>
                                {selectedModuleName || "None"} / {selectedSubModuleName || "None"} - {selectedInstance?.Description || selectedInstance?.TaskName || "None"}
                            </h5>
                        </div>
                        <DynamicInstanceComponent
                            processPath={selectedInstance.ProcessPath}
                            instanceId={selectedInstance.InstanceId}
                        />
                    </>
                ) : (
                    <div className="inb-nodata">
                        <div style={{ width: "100%", display: "flex", flexDirection: "column", justifyContent: "center", alignItems: "center" }}>
                            {/* <div className="bck-img">
                                </div> */}
                            <img height={450} src={nodataimg} />
                            <p style={{ marginTop: "-80px" }}>Select an instance to view details.</p>
                        </div>
                    </div>

                )}
            </div>
        </div>
    );
};

export default InboxContainer;