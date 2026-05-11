// Innovace Intech Solution Pvt Ltd

import { useEffect, useMemo } from "react";
import { useSearchParams } from "react-router-dom";
import { usePageStore } from "@/store/usePageStore";
import { DataElementsData } from "./O2CGRN_Dossier";
import Store from "@/components/Store";



// Dynamically imported components
import Column from "@/components/UI_Controls/Column.tsx";
import Div from "@/components/UI_Controls/Div.tsx";
import Header from "@/components/UI_Controls/Header.tsx";
import Row from "@/components/UI_Controls/Row.tsx";
import TextBox from "@/components/Data_Controls/TextBox";
import DocumentType from "@/components/Data_Controls/DocumentType";


const O2CGRN_Dossier = ({
  ProcessName = "O2CGRN",
  PackageProcessMapId = "F278FCF2-8098-4431-84DC-D67AC39FC9CE",
  FormVersionId = "76CB935C-9AAA-4EEC-861D-9DF1B6EF5AAB",
  ProcessActivityMapId = "B541FA02-DBBD-427D-9C22-DA2BF47777A4"
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
      
      <Column key="AA828EFC-E2D1-454A-A972-49BF6E0AFBD9_1_0" element={{"VersionName":"Medium","Id":1,"WidgetId":"3E117C5C-BA4C-4907-AA01-CAD046BED1E7","uielementid":"AA828EFC-E2D1-454A-A972-49BF6E0AFBD9","WidgetName":"O2CGRN_Root_Dossier.Json","ShowCaption":false,"Fontbold":false,"FontItalic":false,"FontOverline":false,"FontStrikeout":false,"FontUnderline":false,"Depth":1,"IsBadge":false,"ElementId":"","UIElementid":"AA828EFC-E2D1-454A-A972-49BF6E0AFBD9","Sequence":1,"ElementName":"UI_MainContainer","ControlType":"Column","uielementtypeid":5,"Wrap":12,"EnableDFS":false,"ClearFix":false,"OnDemandLoad":false,"IsLastStep":false,"EnableValidation":false,"Buttons":false,"Legend":false,"NavigationNumbers":false,"ControlId":18,"Searchable":false,"Bindable":false,"Action":"FormOnLoad","IsSaveWidget":0,"BindingDetail":"[{\"Endpoint\":\"~\\/iProofServicesHub\\/ExecuteFormLoad\",\"HttpVerb\":\"Post\",\"Port\":\"5009\"}]","DCaption":"","__idx":0,"_id":"AA828EFC-E2D1-454A-A972-49BF6E0AFBD9_1_0"}}  >
        <Div key="5098D5E4-2B70-4CA3-A0FB-DA92230E5BA5_2_1" element={{"VersionName":"Medium","Id":2,"uielementid":"5098D5E4-2B70-4CA3-A0FB-DA92230E5BA5","ShowCaption":true,"Fontbold":false,"FontItalic":false,"FontOverline":false,"FontStrikeout":false,"FontUnderline":false,"Depth":2,"Css":"page-header page-header-light shadow p-2 position-sticky top-0 px-3","IsBadge":false,"MaxValue":100,"CurrValue":10,"ElementId":"","UIElementid":"5098D5E4-2B70-4CA3-A0FB-DA92230E5BA5","Sequence":1,"ElementName":"UI_Div","ParentElementId":"AA828EFC-E2D1-454A-A972-49BF6E0AFBD9","ControlType":"Div","uielementtypeid":44,"Wrap":12,"EnableDFS":false,"ClearFix":false,"OnDemandLoad":false,"IsLastStep":false,"EnableValidation":false,"Buttons":false,"Legend":false,"NavigationNumbers":false,"ControlId":51,"Searchable":false,"Bindable":false,"IsSaveWidget":0,"BindingDetail":"","__idx":1,"_id":"5098D5E4-2B70-4CA3-A0FB-DA92230E5BA5_2_1"}}  >
          <Header key="B25B5EA2-5A25-44B0-A276-1E68C4A8026D_4_3" element={{"VersionName":"Medium","Id":4,"uielementid":"B25B5EA2-5A25-44B0-A276-1E68C4A8026D","ShowCaption":true,"Fontbold":false,"FontItalic":false,"FontOverline":false,"FontStrikeout":false,"FontUnderline":false,"Depth":3,"Css":"mb-0 heading-caption","IsBadge":false,"MaxValue":100,"CurrValue":10,"HeadingType":"h5","ElementId":"","UIElementid":"B25B5EA2-5A25-44B0-A276-1E68C4A8026D","Sequence":1,"ElementName":"UI_Goods Receipt Note","ParentElementId":"5098D5E4-2B70-4CA3-A0FB-DA92230E5BA5","ControlType":"Header","uielementtypeid":16,"Wrap":12,"EnableDFS":false,"ClearFix":false,"OnDemandLoad":false,"IsLastStep":false,"EnableValidation":false,"Buttons":false,"Legend":false,"NavigationNumbers":false,"ControlId":26,"Searchable":false,"Bindable":false,"IsSaveWidget":0,"BindingDetail":"","UCaption":"Goods Receipt Note","__idx":3,"_id":"B25B5EA2-5A25-44B0-A276-1E68C4A8026D_4_3"}}  />
          <Row key="C29C132C-2CB6-40FE-AEE8-0F933F41414B_5_4" element={{"VersionName":"Medium","Id":5,"uielementid":"C29C132C-2CB6-40FE-AEE8-0F933F41414B","ShowCaption":true,"Fontbold":false,"FontItalic":false,"FontOverline":false,"FontStrikeout":false,"FontUnderline":false,"Depth":3,"Css":"d-flex grid_view justify-content-between fg0","IsBadge":false,"MaxValue":100,"CurrValue":10,"ElementId":"","UIElementid":"C29C132C-2CB6-40FE-AEE8-0F933F41414B","Sequence":2,"ElementName":"UI_Row","ParentElementId":"5098D5E4-2B70-4CA3-A0FB-DA92230E5BA5","ControlType":"Row","uielementtypeid":11,"Wrap":12,"EnableDFS":false,"ClearFix":false,"OnDemandLoad":false,"IsLastStep":false,"EnableValidation":false,"Buttons":false,"Legend":false,"NavigationNumbers":false,"ControlId":23,"Searchable":false,"Bindable":false,"IsSaveWidget":0,"BindingDetail":"","__idx":4,"_id":"C29C132C-2CB6-40FE-AEE8-0F933F41414B_5_4"}}  >
            <Column key="739C85D0-83DE-4B3E-B526-FC3251325ABB_7_6" element={{"VersionName":"Medium","Id":7,"uielementid":"739C85D0-83DE-4B3E-B526-FC3251325ABB","ShowCaption":true,"Fontbold":false,"FontItalic":false,"FontOverline":false,"FontStrikeout":false,"FontUnderline":false,"Depth":4,"Css":"grid_view d-flex gap-2 align-items-center","IsBadge":false,"MaxValue":100,"CurrValue":10,"ElementId":"","UIElementid":"739C85D0-83DE-4B3E-B526-FC3251325ABB","Sequence":1,"ElementName":"UI_Column","ParentElementId":"C29C132C-2CB6-40FE-AEE8-0F933F41414B","ControlType":"Column","uielementtypeid":5,"Wrap":0,"EnableDFS":false,"ClearFix":false,"OnDemandLoad":false,"IsLastStep":false,"EnableValidation":false,"Buttons":false,"Legend":false,"NavigationNumbers":false,"ControlId":18,"Searchable":false,"Bindable":false,"IsSaveWidget":0,"BindingDetail":"","__idx":6,"_id":"739C85D0-83DE-4B3E-B526-FC3251325ABB_7_6"}}  >
              <TextBox key="739C85D0-83DE-4B3E-B526-FC3251325ABB_9_8" element={{"VersionName":"Medium","Id":9,"uielementid":"739C85D0-83DE-4B3E-B526-FC3251325ABB","ShowCaption":true,"Fontbold":false,"FontItalic":false,"FontOverline":false,"FontStrikeout":false,"FontUnderline":false,"Depth":5,"Css":"bg_magenta","ElementId":"36ABF598-C1E4-4A43-AEE9-A218A5FE021F","UIElementid":"739C85D0-83DE-4B3E-B526-FC3251325ABB","Sequence":1,"ElementName":"MF_d1_po_number","ParentElementId":"3E117C5C-BA4C-4907-AA01-CAD046BED1E7","ControlType":"TextBox","Wrap":0,"IsMultiline":false,"ClearFix":false,"RenderType":2,"OnDemandLoad":false,"ControlId":1,"HeaderTemplate":"","MergeRow":"","IsSaveWidget":0,"BindingDetail":"","EDT":9,"DCaption":"PO Number","DHelpText":"","DToolTip":"","__idx":8,"_id":"739C85D0-83DE-4B3E-B526-FC3251325ABB_9_8"}}  />
            </Column>
          </Row>
        </Div>
        <Div key="B08A1D13-008C-4274-B2C8-27F4E4ED03F6_3_2" element={{"VersionName":"Medium","Id":3,"uielementid":"B08A1D13-008C-4274-B2C8-27F4E4ED03F6","ShowCaption":true,"Fontbold":false,"FontItalic":false,"FontOverline":false,"FontStrikeout":false,"FontUnderline":false,"Depth":2,"Css":"content grid_view","IsBadge":false,"MaxValue":100,"CurrValue":10,"ElementId":"","UIElementid":"B08A1D13-008C-4274-B2C8-27F4E4ED03F6","Sequence":2,"ElementName":"UI_Div","ParentElementId":"AA828EFC-E2D1-454A-A972-49BF6E0AFBD9","ControlType":"Div","uielementtypeid":44,"Wrap":12,"EnableDFS":false,"ClearFix":false,"OnDemandLoad":false,"IsLastStep":false,"EnableValidation":false,"Buttons":false,"Legend":false,"NavigationNumbers":false,"ControlId":51,"Searchable":false,"Bindable":false,"IsSaveWidget":0,"BindingDetail":"","__idx":2,"_id":"B08A1D13-008C-4274-B2C8-27F4E4ED03F6_3_2"}}  >
          <Row key="ECA73E96-9AC5-4046-97B8-620770717A26_6_5" element={{"VersionName":"Medium","Id":6,"uielementid":"ECA73E96-9AC5-4046-97B8-620770717A26","ShowCaption":true,"Fontbold":false,"FontItalic":false,"FontOverline":false,"FontStrikeout":false,"FontUnderline":false,"Depth":3,"Css":"row grid_view","IsBadge":false,"MaxValue":100,"CurrValue":10,"ElementId":"","UIElementid":"ECA73E96-9AC5-4046-97B8-620770717A26","Sequence":3,"ElementName":"UI_Row","ParentElementId":"B08A1D13-008C-4274-B2C8-27F4E4ED03F6","ControlType":"Row","uielementtypeid":11,"Wrap":12,"EnableDFS":false,"ClearFix":false,"OnDemandLoad":false,"IsLastStep":false,"EnableValidation":false,"Buttons":false,"Legend":false,"NavigationNumbers":false,"ControlId":23,"Searchable":false,"Bindable":false,"IsSaveWidget":0,"BindingDetail":"","__idx":5,"_id":"ECA73E96-9AC5-4046-97B8-620770717A26_6_5"}}  >
            <Column key="23C6CC6F-97A0-4A4F-BF70-CEE059320B8D_8_7" element={{"VersionName":"Medium","Id":8,"uielementid":"23C6CC6F-97A0-4A4F-BF70-CEE059320B8D","ShowCaption":true,"Fontbold":false,"FontItalic":false,"FontOverline":false,"FontStrikeout":false,"FontUnderline":false,"Depth":4,"Css":"grid_view docview_img","IsBadge":false,"MaxValue":100,"CurrValue":10,"ElementId":"","UIElementid":"23C6CC6F-97A0-4A4F-BF70-CEE059320B8D","Sequence":2,"ElementName":"UI_Column","ParentElementId":"ECA73E96-9AC5-4046-97B8-620770717A26","ControlType":"Column","uielementtypeid":5,"Wrap":12,"EnableDFS":false,"ClearFix":false,"OnDemandLoad":false,"IsLastStep":false,"EnableValidation":false,"Buttons":false,"Legend":false,"NavigationNumbers":false,"ControlId":18,"Searchable":false,"Bindable":false,"IsSaveWidget":0,"BindingDetail":"","__idx":7,"_id":"23C6CC6F-97A0-4A4F-BF70-CEE059320B8D_8_7"}}  >
              <DocumentType key="23C6CC6F-97A0-4A4F-BF70-CEE059320B8D_10_9" element={{"VersionName":"Medium","Id":10,"uielementid":"23C6CC6F-97A0-4A4F-BF70-CEE059320B8D","ShowCaption":true,"Fontbold":false,"FontItalic":false,"FontOverline":false,"FontStrikeout":false,"FontUnderline":false,"Depth":5,"Css":"form-control input-xs","ElementId":"9C93046B-0C6A-40B8-BBC1-57A6EE082501","UIElementid":"23C6CC6F-97A0-4A4F-BF70-CEE059320B8D","Sequence":2,"ElementName":"M_DocId","ParentElementId":"3E117C5C-BA4C-4907-AA01-CAD046BED1E7","ControlType":"DocumentType","Wrap":12,"DocumentSettings":"[{\"Size\":null,\"AllowedTypes\":null}]","ClearFix":false,"RenderType":4,"OnDemandLoad":false,"ControlId":8,"HeaderTemplate":"","MergeRow":"","IsSaveWidget":0,"BindingDetail":"","EDT":1,"DCaption":"GRN Document","DHelpText":"","DToolTip":"","__idx":9,"_id":"23C6CC6F-97A0-4A4F-BF70-CEE059320B8D_10_9"}}  />
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

export default O2CGRN_Dossier;
