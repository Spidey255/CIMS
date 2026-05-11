// Innovace Intech Solution Pvt Ltd

import { useEffect, useMemo } from "react";
import { useSearchParams } from "react-router-dom";
import { usePageStore } from "@/store/usePageStore";
import { DataElementsData } from "./O2CPaymentAdvice_Dossier";
import Store from "@/components/Store";



// Dynamically imported components
import Column from "@/components/UI_Controls/Column.tsx";
import Div from "@/components/UI_Controls/Div.tsx";
import Header from "@/components/UI_Controls/Header.tsx";
import Row from "@/components/UI_Controls/Row.tsx";
import DocumentType from "@/components/Data_Controls/DocumentType";


const O2CPaymentAdvice_Dossier = ({
  ProcessName = "O2CPaymentAdvice",
  PackageProcessMapId = "51E28814-3222-471B-9ECE-EC67C6A9A0F6",
  FormVersionId = "53484763-654D-428A-A859-D69FA3E8F6DD",
  ProcessActivityMapId = "d20e761a-4c34-8943-e56b-b54987611ec5"
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
      
      <Column key="9476F800-E948-4903-8B3E-89DC98929FD0_1_0" element={{"VersionName":"Medium","Id":1,"WidgetId":"762AD486-D0B7-4322-8C81-642588B904A5","uielementid":"9476F800-E948-4903-8B3E-89DC98929FD0","WidgetName":"O2CPaymentAdvice_Root_Dossier.Json","ShowCaption":false,"Fontbold":false,"FontItalic":false,"FontOverline":false,"FontStrikeout":false,"FontUnderline":false,"Depth":1,"IsBadge":false,"ElementId":"","UIElementid":"9476F800-E948-4903-8B3E-89DC98929FD0","Sequence":1,"ElementName":"UI_MainContainer","ControlType":"Column","uielementtypeid":5,"Wrap":12,"EnableDFS":false,"ClearFix":false,"OnDemandLoad":false,"IsLastStep":false,"EnableValidation":false,"Buttons":false,"Legend":false,"NavigationNumbers":false,"ControlId":18,"Searchable":false,"Bindable":false,"Action":"FormOnLoad","IsSaveWidget":0,"BindingDetail":"[{\"Endpoint\":\"~\\/iProofServicesHub\\/ExecuteFormLoad\",\"HttpVerb\":\"Post\",\"Port\":\"5009\"}]","DCaption":"","__idx":0,"_id":"9476F800-E948-4903-8B3E-89DC98929FD0_1_0"}}  >
        <Div key="802957F1-041C-49AE-BB9A-EF7E8410CCAA_2_1" element={{"VersionName":"Medium","Id":2,"uielementid":"802957F1-041C-49AE-BB9A-EF7E8410CCAA","ShowCaption":true,"Fontbold":false,"FontItalic":false,"FontOverline":false,"FontStrikeout":false,"FontUnderline":false,"Depth":2,"Css":"content grid_view","IsBadge":false,"MaxValue":100,"CurrValue":10,"ElementId":"","UIElementid":"802957F1-041C-49AE-BB9A-EF7E8410CCAA","Sequence":1,"ElementName":"UI_Div","ParentElementId":"9476F800-E948-4903-8B3E-89DC98929FD0","ControlType":"Div","uielementtypeid":44,"Wrap":12,"EnableDFS":false,"ClearFix":false,"OnDemandLoad":false,"IsLastStep":false,"EnableValidation":false,"Buttons":false,"Legend":false,"NavigationNumbers":false,"ControlId":51,"Searchable":false,"Bindable":false,"IsSaveWidget":0,"BindingDetail":"","__idx":1,"_id":"802957F1-041C-49AE-BB9A-EF7E8410CCAA_2_1"}}  >
          <Header key="F8931C5A-8788-410E-ACC9-62FA90EC7F93_4_3" element={{"VersionName":"Medium","Id":4,"uielementid":"F8931C5A-8788-410E-ACC9-62FA90EC7F93","ShowCaption":true,"Fontbold":false,"FontItalic":false,"FontOverline":false,"FontStrikeout":false,"FontUnderline":false,"Depth":3,"Css":"mb-0 heading-caption","IsBadge":false,"MaxValue":100,"CurrValue":10,"HeadingType":"h5","ElementId":"","UIElementid":"F8931C5A-8788-410E-ACC9-62FA90EC7F93","Sequence":1,"ElementName":"UI_Payment Advice","ParentElementId":"802957F1-041C-49AE-BB9A-EF7E8410CCAA","ControlType":"Header","uielementtypeid":16,"Wrap":12,"EnableDFS":false,"ClearFix":false,"OnDemandLoad":false,"IsLastStep":false,"EnableValidation":false,"Buttons":false,"Legend":false,"NavigationNumbers":false,"ControlId":26,"Searchable":false,"Bindable":false,"IsSaveWidget":0,"BindingDetail":"","UCaption":"Payment Advice","__idx":3,"_id":"F8931C5A-8788-410E-ACC9-62FA90EC7F93_4_3"}}  />
          <Row key="F8301267-3A46-4BE6-98F2-E3B5C0B331B0_5_4" element={{"VersionName":"Medium","Id":5,"uielementid":"F8301267-3A46-4BE6-98F2-E3B5C0B331B0","ShowCaption":true,"Fontbold":false,"FontItalic":false,"FontOverline":false,"FontStrikeout":false,"FontUnderline":false,"Depth":3,"Css":"d-flex grid_view justify-content-between fg0","IsBadge":false,"MaxValue":100,"CurrValue":10,"ElementId":"","UIElementid":"F8301267-3A46-4BE6-98F2-E3B5C0B331B0","Sequence":2,"ElementName":"UI_Row","ParentElementId":"802957F1-041C-49AE-BB9A-EF7E8410CCAA","ControlType":"Row","uielementtypeid":11,"Wrap":12,"EnableDFS":false,"ClearFix":false,"OnDemandLoad":false,"IsLastStep":false,"EnableValidation":false,"Buttons":false,"Legend":false,"NavigationNumbers":false,"ControlId":23,"Searchable":false,"Bindable":false,"IsSaveWidget":0,"BindingDetail":"","__idx":4,"_id":"F8301267-3A46-4BE6-98F2-E3B5C0B331B0_5_4"}}  >
            <Column key="D81601D3-34D4-49FA-ABD7-78415C145DA7_7_6" element={{"VersionName":"Medium","Id":7,"uielementid":"D81601D3-34D4-49FA-ABD7-78415C145DA7","ShowCaption":true,"Fontbold":false,"FontItalic":false,"FontOverline":false,"FontStrikeout":false,"FontUnderline":false,"Depth":4,"Css":"grid_view d-flex gap-2 align-items-center","IsBadge":false,"MaxValue":100,"CurrValue":10,"ElementId":"","UIElementid":"D81601D3-34D4-49FA-ABD7-78415C145DA7","Sequence":1,"ElementName":"UI_Column","ParentElementId":"F8301267-3A46-4BE6-98F2-E3B5C0B331B0","ControlType":"Column","uielementtypeid":5,"Wrap":0,"EnableDFS":false,"ClearFix":false,"OnDemandLoad":false,"IsLastStep":false,"EnableValidation":false,"Buttons":false,"Legend":false,"NavigationNumbers":false,"ControlId":18,"Searchable":false,"Bindable":false,"IsSaveWidget":0,"BindingDetail":"","__idx":6,"_id":"D81601D3-34D4-49FA-ABD7-78415C145DA7_7_6"}}  />
            <Column key="B4D11EF9-276A-4D5E-AF8F-B31D2BCE5AAB_8_7" element={{"VersionName":"Medium","Id":8,"uielementid":"B4D11EF9-276A-4D5E-AF8F-B31D2BCE5AAB","ShowCaption":true,"Fontbold":false,"FontItalic":false,"FontOverline":false,"FontStrikeout":false,"FontUnderline":false,"Depth":4,"Css":"grid_view flex-end gap-2","IsBadge":false,"MaxValue":100,"CurrValue":10,"ElementId":"","UIElementid":"B4D11EF9-276A-4D5E-AF8F-B31D2BCE5AAB","Sequence":2,"ElementName":"UI_Column","ParentElementId":"F8301267-3A46-4BE6-98F2-E3B5C0B331B0","ControlType":"Column","uielementtypeid":5,"Wrap":0,"EnableDFS":false,"ClearFix":false,"OnDemandLoad":false,"IsLastStep":false,"EnableValidation":false,"Buttons":false,"Legend":false,"NavigationNumbers":false,"ControlId":18,"Searchable":false,"Bindable":false,"IsSaveWidget":0,"BindingDetail":"","__idx":7,"_id":"B4D11EF9-276A-4D5E-AF8F-B31D2BCE5AAB_8_7"}}  />
          </Row>
        </Div>
        <Div key="48079332-117E-4C65-96D3-FB7AABF96CD6_3_2" element={{"VersionName":"Medium","Id":3,"uielementid":"48079332-117E-4C65-96D3-FB7AABF96CD6","ShowCaption":true,"Fontbold":false,"FontItalic":false,"FontOverline":false,"FontStrikeout":false,"FontUnderline":false,"Depth":2,"Css":"content grid_view hlCmpt","IsBadge":false,"MaxValue":100,"CurrValue":10,"ElementId":"","UIElementid":"48079332-117E-4C65-96D3-FB7AABF96CD6","Sequence":2,"ElementName":"UI_Div","ParentElementId":"9476F800-E948-4903-8B3E-89DC98929FD0","ControlType":"Div","uielementtypeid":44,"Wrap":12,"EnableDFS":false,"ClearFix":false,"OnDemandLoad":false,"IsLastStep":false,"EnableValidation":false,"Buttons":false,"Legend":false,"NavigationNumbers":false,"ControlId":51,"Searchable":false,"Bindable":false,"IsSaveWidget":0,"BindingDetail":"","__idx":2,"_id":"48079332-117E-4C65-96D3-FB7AABF96CD6_3_2"}}  >
          <Row key="B79C41E6-75F5-4EA5-B9A9-680E5150024A_6_5" element={{"VersionName":"Medium","Id":6,"uielementid":"B79C41E6-75F5-4EA5-B9A9-680E5150024A","ShowCaption":true,"Fontbold":false,"FontItalic":false,"FontOverline":false,"FontStrikeout":false,"FontUnderline":false,"Depth":3,"Css":"row grid_view","IsBadge":false,"MaxValue":100,"CurrValue":10,"ElementId":"","UIElementid":"B79C41E6-75F5-4EA5-B9A9-680E5150024A","Sequence":3,"ElementName":"UI_Row","ParentElementId":"48079332-117E-4C65-96D3-FB7AABF96CD6","ControlType":"Row","uielementtypeid":11,"Wrap":12,"EnableDFS":false,"ClearFix":false,"OnDemandLoad":false,"IsLastStep":false,"EnableValidation":false,"Buttons":false,"Legend":false,"NavigationNumbers":false,"ControlId":23,"Searchable":false,"Bindable":false,"IsSaveWidget":0,"BindingDetail":"","__idx":5,"_id":"B79C41E6-75F5-4EA5-B9A9-680E5150024A_6_5"}}  >
            <Column key="07B0326D-94A1-4506-84F7-41AD4A4B69D4_9_8" element={{"VersionName":"Medium","Id":9,"uielementid":"07B0326D-94A1-4506-84F7-41AD4A4B69D4","ShowCaption":true,"Fontbold":false,"FontItalic":false,"FontOverline":false,"FontStrikeout":false,"FontUnderline":false,"Depth":4,"Css":"grid_view docview_img","IsBadge":false,"MaxValue":100,"CurrValue":10,"ElementId":"","UIElementid":"07B0326D-94A1-4506-84F7-41AD4A4B69D4","Sequence":3,"ElementName":"UI_Column","ParentElementId":"B79C41E6-75F5-4EA5-B9A9-680E5150024A","ControlType":"Column","uielementtypeid":5,"Wrap":12,"EnableDFS":false,"ClearFix":false,"OnDemandLoad":false,"IsLastStep":false,"EnableValidation":false,"Buttons":false,"Legend":false,"NavigationNumbers":false,"ControlId":18,"Searchable":false,"Bindable":false,"IsSaveWidget":0,"BindingDetail":"","__idx":8,"_id":"07B0326D-94A1-4506-84F7-41AD4A4B69D4_9_8"}}  >
              <DocumentType key="07B0326D-94A1-4506-84F7-41AD4A4B69D4_10_9" element={{"VersionName":"Medium","Id":10,"uielementid":"07B0326D-94A1-4506-84F7-41AD4A4B69D4","ShowCaption":true,"Fontbold":false,"FontItalic":false,"FontOverline":false,"FontStrikeout":false,"FontUnderline":false,"Depth":5,"Css":"form-control input-xs","ElementId":"3212DB99-EEA2-4CD3-B63E-3BBA5C6ECE0D","UIElementid":"07B0326D-94A1-4506-84F7-41AD4A4B69D4","Sequence":1,"ElementName":"M_DocId","ParentElementId":"762AD486-D0B7-4322-8C81-642588B904A5","ControlType":"DocumentType","Wrap":12,"DocumentSettings":"[{\"Size\":null,\"AllowedTypes\":null}]","ClearFix":false,"RenderType":4,"OnDemandLoad":false,"ControlId":8,"DisplayName":"M_DocId","Searchable":false,"Bindable":false,"HeaderTemplate":"","MergeRow":"","IsSaveWidget":0,"BindingDetail":"","EDT":1,"DCaption":"M_DocId","__idx":9,"_id":"07B0326D-94A1-4506-84F7-41AD4A4B69D4_10_9"}}  />
            </Column>
          </Row>
        </Div>
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

export default O2CPaymentAdvice_Dossier;
