// Innovace Intech Solution Pvt Ltd

import { useEffect, useMemo } from "react";
import { useSearchParams } from "react-router-dom";
import { usePageStore } from "@/store/usePageStore";
import { DataElementsData } from "./SupplierDashboard_Start";
import Store from "@/components/Store";



// Dynamically imported components
import Column from "@/components/UI_Controls/Column.tsx";
import PlaceHolder from "@/components/Data_Controls/PlaceHolder.tsx";


const SupplierDashboard_Start = ({
  ProcessName = "SupplierDashboard",
  PackageProcessMapId = "70d5e6f9-c109-4941-baf7-699af2b3bc9a",
  FormVersionId = "5A858703-4109-4C29-A08F-5B3F7BFAC543",
  ProcessActivityMapId = "7F2BD51D-65AA-4537-8239-B800C0B48B87"
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
      
      <Column key="0e795253-96b0-0dfc-0b11-0e2a8835a77c_1_0" element={{"VersionName":"Medium","Id":1,"WidgetId":"2F198AEC-0B89-44E9-929B-5FB2099322DC","uielementid":"0e795253-96b0-0dfc-0b11-0e2a8835a77c","WidgetName":"SupplierDashboard_Root_Start.Json","ShowCaption":false,"Fontbold":false,"FontItalic":false,"FontOverline":false,"FontStrikeout":false,"FontUnderline":false,"Depth":1,"IsBadge":false,"ElementId":"","UIElementid":"0e795253-96b0-0dfc-0b11-0e2a8835a77c","Sequence":1,"ElementName":"UI_MainContainer","ControlType":"Column","uielementtypeid":5,"Wrap":12,"EnableDFS":false,"ClearFix":false,"OnDemandLoad":false,"IsLastStep":false,"EnableValidation":false,"Buttons":false,"Legend":false,"NavigationNumbers":false,"ControlId":18,"Searchable":false,"Bindable":false,"Action":"FormOnLoad","IsSaveWidget":0,"BindingDetail":"[{\"Endpoint\":\"~\\/iProofServicesHub\\/ExecuteFormLoad\",\"HttpVerb\":\"Post\",\"Port\":\"5009\",\"Params\":[{\"ElementName\":\"SupplierName\",\"Value\":\"\",\"EDT\":9},{\"ElementName\":\"OrganizationName\",\"Value\":\"\",\"EDT\":9},{\"ElementName\":\"M_SupplierUrl\",\"Value\":\"\",\"EDT\":10}]}]","DCaption":"","__idx":0,"_id":"0e795253-96b0-0dfc-0b11-0e2a8835a77c_1_0"}}  >
        <PlaceHolder key="0e795253-96b0-0dfc-0b11-0e2a8835a77c_2_1" element={{"VersionName":"Medium","Id":2,"uielementid":"0e795253-96b0-0dfc-0b11-0e2a8835a77c","ShowCaption":false,"Fontbold":false,"FontItalic":false,"FontOverline":false,"FontStrikeout":false,"FontUnderline":false,"Depth":2,"Css":"form-group","height":800,"ElementId":"b283ce99-1ede-11d0-5de3-93d458850e54","UIElementid":"0e795253-96b0-0dfc-0b11-0e2a8835a77c","Sequence":1,"ElementName":"M_SupplierUrl","ParentElementId":"2F198AEC-0B89-44E9-929B-5FB2099322DC","ControlType":"PlaceHolder","Wrap":12,"ClearFix":false,"OnDemandLoad":false,"ControlId":14,"DisplayName":"M_SupplierUrl","Searchable":false,"Bindable":false,"HeaderTemplate":"","MergeRow":"","IsSaveWidget":0,"BindingDetail":"","EDT":10,"DCaption":"M_SupplierUrl","__idx":1,"_id":"0e795253-96b0-0dfc-0b11-0e2a8835a77c_2_1"}}  />
      </Column>
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

export default SupplierDashboard_Start;
