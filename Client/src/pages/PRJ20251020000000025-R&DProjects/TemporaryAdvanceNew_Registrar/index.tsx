// Innovace Intech Solution Pvt Ltd

import { useEffect, useMemo } from "react";
import { useSearchParams } from "react-router-dom";
import { usePageStore } from "@/store/usePageStore";
import { DataElementsData } from "./TemporaryAdvanceNew_Registrar";
import Store from "@/components/Store";



// Dynamically imported components
import Column from "@/components/UI_Controls/Column.tsx";


const TemporaryAdvanceNew_Registrar = ({
  ProcessName = "TemporaryAdvanceNew",
  PackageProcessMapId = "85014d12-a85b-4330-8d7f-29776cbda319",
  FormVersionId = "228701A8-2089-4481-B018-4BE30083D0D9",
  ProcessActivityMapId = "560A61B0-D0D9-4566-B1E9-4190F008BC9E"
}) => {
  const setActivePage = usePageStore((state) => state.setActivePage);
  const resetActivePage = usePageStore((state) => state.resetActivePage);

   const [searchParams] = useSearchParams();

  // ✅ URL → object
  const storeQueryParams = useMemo<Record<string, string>>(() => {
    const obj: Record<string, string> = {};

    for (const [key, value] of searchParams.entries()) {
      obj[key] = value;
    }

    return obj;
  }, [searchParams]);

  useEffect(() => {
    setActivePage({ ProcessName, PackageProcessMapId, FormVersionId, ProcessActivityMapId });
    return () => resetActivePage();
  }, []);

  return (
    <main>
      
      <Column key="3791c59a-732d-db3b-a48e-0c523b780a1e_1_0" element={{"VersionName":"Medium","Id":1,"WidgetId":"744F780C-12D2-41D3-9084-6E903A527934","uielementid":"3791c59a-732d-db3b-a48e-0c523b780a1e","WidgetName":"TemporaryAdvanceNew_Root_Registrar.Json","ElementId":"","UIElementid":"3791c59a-732d-db3b-a48e-0c523b780a1e","Sequence":1,"ElementName":"UI_MainContainer","ControlType":"Column","uielementtypeid":5,"EnableDFS":false,"ControlId":18,"Searchable":false,"Bindable":false,"Action":"FormOnLoad","IsSaveWidget":0,"BindingDetail":"[{\"Endpoint\":\"~\\/iProofServicesHub\\/ExecuteFormLoad\",\"HttpVerb\":\"Post\",\"Port\":\"5009\"}]","DCaption":"","__idx":0,"_id":"3791c59a-732d-db3b-a48e-0c523b780a1e_1_0"}}  />
      <Store
        data={DataElementsData}
        queryParams={storeQueryParams}
        ProcessName={ProcessName}
        FormVersionId={FormVersionId}
        ProcessActivityMapId={ProcessActivityMapId}
        PackageProcessMapId={PackageProcessMapId}
      />
            
    </main>
  );
};

export default TemporaryAdvanceNew_Registrar;
