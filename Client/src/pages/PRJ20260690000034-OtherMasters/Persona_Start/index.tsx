// Innovace Intech Solution Pvt Ltd

import { useEffect, useMemo } from "react";
import { useSearchParams } from "react-router-dom";
import { usePageStore } from "@/store/usePageStore";
import { DataElementsData } from "./Persona_Start";
import Store from "@/components/Store";



// Dynamically imported components
import Column from "@/components/UI_Controls/Column.tsx";
import Row from "@/components/UI_Controls/Row.tsx";
import PlaceHolder from "@/components/Data_Controls/PlaceHolder.tsx";


const Persona_Start = ({
  ProcessName = "Persona",
  PackageProcessMapId = "aab35940-f893-4c0d-993e-0b2214b828ab",
  FormVersionId = "98782486-361B-4B93-BE36-66BB25568D2C",
  ProcessActivityMapId = "9E2E217E-576F-4C9C-B360-19521C9EE00C"
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
      
      <Column key="31122770-5011-ed7a-83b9-17ef17b6c124_1_0" element={{"VersionName":"Medium","Id":1,"WidgetId":"358587C6-69FB-41DC-B05A-3EF0CC7D5D98","uielementid":"31122770-5011-ed7a-83b9-17ef17b6c124","WidgetName":"Persona_Root_Start.Json","ShowCaption":false,"Fontbold":false,"FontItalic":false,"FontOverline":false,"FontStrikeout":false,"FontUnderline":false,"Depth":1,"IsBadge":false,"ElementId":"","UIElementid":"31122770-5011-ed7a-83b9-17ef17b6c124","Sequence":1,"ElementName":"UI_MainContainer","ControlType":"Column","uielementtypeid":5,"Wrap":12,"EnableDFS":false,"ClearFix":false,"OnDemandLoad":false,"IsLastStep":false,"EnableValidation":false,"Buttons":false,"Legend":false,"NavigationNumbers":false,"ControlId":18,"Searchable":false,"Bindable":false,"Action":"FormOnLoad","IsSaveWidget":0,"BindingDetail":"[{\"Endpoint\":\"~\\/iProofServicesHub\\/ExecuteFormLoad\",\"HttpVerb\":\"Post\",\"Port\":\"5009\",\"Params\":[{\"ElementName\":\"M_PersonaUrl\",\"Value\":\"\",\"EDT\":10}]}]","DCaption":"","__idx":0,"_id":"31122770-5011-ed7a-83b9-17ef17b6c124_1_0"}}  >
        <Row key="007c1f21-4da7-1237-9295-3b6cb1ad5516_2_1" element={{"VersionName":"Medium","Id":2,"uielementid":"007c1f21-4da7-1237-9295-3b6cb1ad5516","ShowCaption":true,"Fontbold":false,"FontItalic":false,"FontOverline":false,"FontStrikeout":false,"FontUnderline":false,"Depth":2,"Css":"row grid_view","IsBadge":false,"MaxValue":100,"CurrValue":10,"ElementId":"","UIElementid":"007c1f21-4da7-1237-9295-3b6cb1ad5516","Sequence":1,"ElementName":"UI_Row","ParentElementId":"31122770-5011-ed7a-83b9-17ef17b6c124","ControlType":"Row","uielementtypeid":11,"Wrap":12,"EnableDFS":false,"ClearFix":false,"OnDemandLoad":false,"IsLastStep":false,"EnableValidation":false,"Buttons":false,"Legend":false,"NavigationNumbers":false,"ControlId":23,"Searchable":false,"Bindable":false,"IsSaveWidget":0,"BindingDetail":"","__idx":1,"_id":"007c1f21-4da7-1237-9295-3b6cb1ad5516_2_1"}}  >
          <PlaceHolder key="007c1f21-4da7-1237-9295-3b6cb1ad5516_3_2" element={{"VersionName":"Medium","Id":3,"uielementid":"007c1f21-4da7-1237-9295-3b6cb1ad5516","ShowCaption":true,"Fontbold":false,"FontItalic":false,"FontOverline":false,"FontStrikeout":false,"FontUnderline":false,"Depth":3,"Css":"form-group","height":800,"ElementId":"babb34b5-9439-30d3-bf82-424e5464a87a","UIElementid":"007c1f21-4da7-1237-9295-3b6cb1ad5516","Sequence":1,"ElementName":"M_PersonaUrl","ParentElementId":"358587C6-69FB-41DC-B05A-3EF0CC7D5D98","ControlType":"PlaceHolder","Wrap":12,"ClearFix":false,"OnDemandLoad":false,"ControlId":14,"DisplayName":"M_PersonaUrl","Searchable":false,"Bindable":false,"HeaderTemplate":"","MergeRow":"","IsSaveWidget":0,"BindingDetail":"","EDT":10,"DCaption":"M_PersonaUrl","__idx":2,"_id":"007c1f21-4da7-1237-9295-3b6cb1ad5516_3_2"}}  />
        </Row>
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

export default Persona_Start;
