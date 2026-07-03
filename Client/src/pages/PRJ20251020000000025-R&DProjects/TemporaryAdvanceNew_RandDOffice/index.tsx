// Innovace Intech Solution Pvt Ltd

import { useEffect, useMemo } from "react";
import { useSearchParams } from "react-router-dom";
import { usePageStore } from "@/store/usePageStore";
import { DataElementsData } from "./TemporaryAdvanceNew_RandDOffice";
import Store from "@/components/Store";



// Dynamically imported components
import Column from "@/components/UI_Controls/Column.tsx";


const TemporaryAdvanceNew_RandDOffice = ({
  ProcessName = "TemporaryAdvanceNew",
  PackageProcessMapId = "85014d12-a85b-4330-8d7f-29776cbda319",
  FormVersionId = "228701A8-2089-4481-B018-4BE30083D0D9",
  ProcessActivityMapId = "B7191F83-99C7-433E-8CAC-B4D23CA6AB2E"
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
      
      <Column key="07b6c36e-a3f2-f6b2-fe6e-a1c524974b27_1_0" element={{"VersionName":"Medium","Id":1,"WidgetId":"744F780C-12D2-41D3-9084-6E903A527934","uielementid":"07b6c36e-a3f2-f6b2-fe6e-a1c524974b27","WidgetName":"TemporaryAdvanceNew_Root_RandDOffice.Json","ElementId":"","UIElementid":"07b6c36e-a3f2-f6b2-fe6e-a1c524974b27","Sequence":1,"ElementName":"UI_MainContainer","ControlType":"Column","uielementtypeid":5,"EnableDFS":false,"ControlId":18,"Searchable":false,"Bindable":false,"Action":"FormOnLoad","IsSaveWidget":0,"BindingDetail":"[{\"Endpoint\":\"~\\/iProofServicesHub\\/ExecuteFormLoad\",\"HttpVerb\":\"Post\",\"Port\":\"5009\"}]","DCaption":"","__idx":0,"_id":"07b6c36e-a3f2-f6b2-fe6e-a1c524974b27_1_0"}}  />
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

export default TemporaryAdvanceNew_RandDOffice;
