// Innovace Intech Solution Pvt Ltd

import { useEffect, useMemo } from "react";
import { useSearchParams } from "react-router-dom";
import { usePageStore } from "@/store/usePageStore";
import { DataElementsData } from "./TravelRequestNew_RandDOffice";
import Store from "@/components/Store";



// Dynamically imported components
import Column from "@/components/UI_Controls/Column.tsx";


const TravelRequestNew_RandDOffice = ({
  ProcessName = "TravelRequestNew",
  PackageProcessMapId = "bfcdccb2-7467-4308-a53d-7cab7b883529",
  FormVersionId = "48D9155C-42D2-4414-AF53-3D00D9908DD4",
  ProcessActivityMapId = "34A8F37F-24BF-4316-826B-DF78EE6E8579"
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
      
      <Column key="0ff8a7b1-8950-568d-5cf2-dba227ccc461_1_0" element={{"VersionName":"Medium","Id":1,"WidgetId":"5D394C98-9AAB-4228-B011-FC8008C3247C","uielementid":"0ff8a7b1-8950-568d-5cf2-dba227ccc461","WidgetName":"TravelRequestNew_Root_RandDOffice.Json","ElementId":"","UIElementid":"0ff8a7b1-8950-568d-5cf2-dba227ccc461","Sequence":1,"ElementName":"UI_MainContainer","ControlType":"Column","uielementtypeid":5,"EnableDFS":false,"ControlId":18,"Searchable":false,"Bindable":false,"Action":"FormOnLoad","IsSaveWidget":0,"BindingDetail":"[{\"Endpoint\":\"~\\/iProofServicesHub\\/ExecuteFormLoad\",\"HttpVerb\":\"Post\",\"Port\":\"5009\"}]","DCaption":"","__idx":0,"_id":"0ff8a7b1-8950-568d-5cf2-dba227ccc461_1_0"}}  />
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

export default TravelRequestNew_RandDOffice;
