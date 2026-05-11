// Innovace Intech Solution Pvt Ltd

import { useEffect, useMemo } from "react";
import { useSearchParams } from "react-router-dom";
import { usePageStore } from "@/store/usePageStore";
import { DataElementsData } from "./BuyerDashboard_Start";
import Store from "@/components/Store";



// Dynamically imported components
import Column from "@/components/UI_Controls/Column.tsx";
import PlaceHolder from "@/components/Data_Controls/PlaceHolder.tsx";


const BuyerDashboard_Start = ({
  ProcessName = "BuyerDashboard",
  PackageProcessMapId = "7895a027-a14a-439c-9c57-52d77467fd91",
  FormVersionId = "827E8271-12B9-4519-A357-76D1D13D0207",
  ProcessActivityMapId = "6755F89C-6FF9-49A4-B66C-90F3CEED40A5"
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
      
      <Column key="1cc8d4e5-3da0-2af1-c701-b60dbe8f873a_1_0" element={{"VersionName":"Medium","Id":1,"WidgetId":"41C3FA77-EDBC-4A83-8963-5E528A6AD9BE","uielementid":"1cc8d4e5-3da0-2af1-c701-b60dbe8f873a","WidgetName":"BuyerDashboard_Root_Start.Json","ShowCaption":false,"Fontbold":false,"FontItalic":false,"FontOverline":false,"FontStrikeout":false,"FontUnderline":false,"Depth":1,"IsBadge":false,"ElementId":"","UIElementid":"1cc8d4e5-3da0-2af1-c701-b60dbe8f873a","Sequence":1,"ElementName":"UI_MainContainer","ControlType":"Column","uielementtypeid":5,"Wrap":12,"EnableDFS":false,"ClearFix":false,"OnDemandLoad":false,"IsLastStep":false,"EnableValidation":false,"Buttons":false,"Legend":false,"NavigationNumbers":false,"ControlId":18,"Searchable":false,"Bindable":false,"Action":"FormOnLoad","IsSaveWidget":0,"BindingDetail":"[{\"Endpoint\":\"~\\/iProofServicesHub\\/ExecuteFormLoad\",\"HttpVerb\":\"Post\",\"Port\":\"5009\",\"Params\":[{\"ElementName\":\"BuyerName\",\"Value\":\"\",\"EDT\":9},{\"ElementName\":\"M_BuyerUrl\",\"Value\":\"\",\"EDT\":10},{\"ElementName\":\"OrganizationName\",\"Value\":\"\",\"EDT\":9}]}]","DCaption":"","__idx":0,"_id":"1cc8d4e5-3da0-2af1-c701-b60dbe8f873a_1_0"}}  >
        <PlaceHolder key="1cc8d4e5-3da0-2af1-c701-b60dbe8f873a_2_1" element={{"VersionName":"Medium","Id":2,"uielementid":"1cc8d4e5-3da0-2af1-c701-b60dbe8f873a","ShowCaption":false,"Fontbold":false,"FontItalic":false,"FontOverline":false,"FontStrikeout":false,"FontUnderline":false,"Depth":2,"Css":"form-group","height":800,"ElementId":"eac36701-5329-0049-209b-437aca9fa8c5","UIElementid":"1cc8d4e5-3da0-2af1-c701-b60dbe8f873a","Sequence":1,"ElementName":"M_BuyerUrl","ParentElementId":"41C3FA77-EDBC-4A83-8963-5E528A6AD9BE","ControlType":"PlaceHolder","Wrap":12,"ClearFix":false,"OnDemandLoad":false,"ControlId":14,"DisplayName":"M_BuyerUrl","Searchable":false,"Bindable":false,"HeaderTemplate":"","MergeRow":"","IsSaveWidget":0,"BindingDetail":"","EDT":10,"DCaption":"M_BuyerUrl","__idx":1,"_id":"1cc8d4e5-3da0-2af1-c701-b60dbe8f873a_2_1"}}  />
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

export default BuyerDashboard_Start;
