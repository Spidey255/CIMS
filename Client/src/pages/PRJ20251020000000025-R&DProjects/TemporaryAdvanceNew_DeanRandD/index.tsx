// Innovace Intech Solution Pvt Ltd

import { useEffect, useMemo } from "react";
import { useSearchParams } from "react-router-dom";
import { usePageStore } from "@/store/usePageStore";
import { DataElementsData } from "./TemporaryAdvanceNew_DeanRandD";
import Store from "@/components/Store";



// Dynamically imported components
import Column from "@/components/UI_Controls/Column.tsx";


const TemporaryAdvanceNew_DeanRandD = ({
  ProcessName = "TemporaryAdvanceNew",
  PackageProcessMapId = "85014d12-a85b-4330-8d7f-29776cbda319",
  FormVersionId = "228701A8-2089-4481-B018-4BE30083D0D9",
  ProcessActivityMapId = "B4D82C89-3C76-4D0A-AE78-7B32FD572B8F"
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
      
      <Column key="4b13a0f0-7deb-3dc4-28a9-9654bbc4220c_1_0" element={{"VersionName":"Medium","Id":1,"WidgetId":"744F780C-12D2-41D3-9084-6E903A527934","uielementid":"4b13a0f0-7deb-3dc4-28a9-9654bbc4220c","WidgetName":"TemporaryAdvanceNew_Root_DeanRandD.Json","ElementId":"","UIElementid":"4b13a0f0-7deb-3dc4-28a9-9654bbc4220c","Sequence":1,"ElementName":"UI_MainContainer","ControlType":"Column","uielementtypeid":5,"EnableDFS":false,"ControlId":18,"Searchable":false,"Bindable":false,"Action":"FormOnLoad","IsSaveWidget":0,"BindingDetail":"[{\"Endpoint\":\"~\\/iProofServicesHub\\/ExecuteFormLoad\",\"HttpVerb\":\"Post\",\"Port\":\"5009\"}]","DCaption":"","__idx":0,"_id":"4b13a0f0-7deb-3dc4-28a9-9654bbc4220c_1_0"}}  />
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

export default TemporaryAdvanceNew_DeanRandD;
