// Innovace Intech Solution Pvt Ltd

import { useEffect, useMemo } from "react";
import { useSearchParams } from "react-router-dom";
import { usePageStore } from "@/store/usePageStore";
import { DataElementsData } from "./O2CGRN_Start";
import Store from "@/components/Store";



// Dynamically imported components
import Column from "@/components/UI_Controls/Column.tsx";
import Div from "@/components/UI_Controls/Div.tsx";
import Header from "@/components/UI_Controls/Header.tsx";
import Row from "@/components/UI_Controls/Row.tsx";
import TextBox from "@/components/Data_Controls/TextBox";
import ActionButton from "@/components/Data_Controls/ActionButton.tsx";
import DocumentType from "@/components/Data_Controls/DocumentType";


const O2CGRN_Start = ({
  ProcessName = "O2CGRN",
  PackageProcessMapId = "F278FCF2-8098-4431-84DC-D67AC39FC9CE",
  FormVersionId = "76CB935C-9AAA-4EEC-861D-9DF1B6EF5AAB",
  ProcessActivityMapId = "3D6AA75A-9184-4A5C-A2EF-EDB07A202D35"
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
      
      <Column key="5334D888-EA29-4A99-8309-A1E2B95BE03A_1_0" element={{"VersionName":"Medium","Id":1,"WidgetId":"3E117C5C-BA4C-4907-AA01-CAD046BED1E7","uielementid":"5334D888-EA29-4A99-8309-A1E2B95BE03A","WidgetName":"O2CGRN_Root_Start.Json","ShowCaption":false,"Fontbold":false,"FontItalic":false,"FontOverline":false,"FontStrikeout":false,"FontUnderline":false,"Depth":1,"IsBadge":false,"ElementId":"","UIElementid":"5334D888-EA29-4A99-8309-A1E2B95BE03A","Sequence":1,"ElementName":"UI_MainContainer","ControlType":"Column","uielementtypeid":5,"Wrap":12,"EnableDFS":false,"ClearFix":false,"OnDemandLoad":false,"IsLastStep":false,"EnableValidation":false,"Buttons":false,"Legend":false,"NavigationNumbers":false,"ControlId":18,"Searchable":false,"Bindable":false,"Action":"FormOnLoad","IsSaveWidget":0,"BindingDetail":"[{\"Endpoint\":\"~\\/iProofServicesHub\\/ExecuteFormLoad\",\"HttpVerb\":\"Post\",\"Port\":\"5009\"}]","DCaption":"","__idx":0,"_id":"5334D888-EA29-4A99-8309-A1E2B95BE03A_1_0"}}  >
        <Div key="5CCE7936-6952-4080-834C-E04EA53A93CB_2_1" element={{"VersionName":"Medium","Id":2,"uielementid":"5CCE7936-6952-4080-834C-E04EA53A93CB","ShowCaption":true,"Fontbold":false,"FontItalic":false,"FontOverline":false,"FontStrikeout":false,"FontUnderline":false,"Depth":2,"Css":"page-header page-header-light shadow p-2 position-sticky top-0 px-3","IsBadge":false,"MaxValue":100,"CurrValue":10,"ElementId":"","UIElementid":"5CCE7936-6952-4080-834C-E04EA53A93CB","Sequence":1,"ElementName":"UI_Div","ParentElementId":"5334D888-EA29-4A99-8309-A1E2B95BE03A","ControlType":"Div","uielementtypeid":44,"Wrap":12,"EnableDFS":false,"ClearFix":false,"OnDemandLoad":false,"IsLastStep":false,"EnableValidation":false,"Buttons":false,"Legend":false,"NavigationNumbers":false,"ControlId":51,"Searchable":false,"Bindable":false,"IsSaveWidget":0,"BindingDetail":"","__idx":1,"_id":"5CCE7936-6952-4080-834C-E04EA53A93CB_2_1"}}  >
          <Header key="5E818CEE-0F58-4D2C-A3DB-453C6CE8C691_4_3" element={{"VersionName":"Medium","Id":4,"uielementid":"5E818CEE-0F58-4D2C-A3DB-453C6CE8C691","ShowCaption":true,"Fontbold":false,"FontItalic":false,"FontOverline":false,"FontStrikeout":false,"FontUnderline":false,"Depth":3,"Css":"mb-0 heading-caption","IsBadge":false,"MaxValue":100,"CurrValue":10,"HeadingType":"h5","ElementId":"","UIElementid":"5E818CEE-0F58-4D2C-A3DB-453C6CE8C691","Sequence":1,"ElementName":"UI_Goods Receipt Note","ParentElementId":"5CCE7936-6952-4080-834C-E04EA53A93CB","ControlType":"Header","uielementtypeid":16,"Wrap":12,"EnableDFS":false,"ClearFix":false,"OnDemandLoad":false,"IsLastStep":false,"EnableValidation":false,"Buttons":false,"Legend":false,"NavigationNumbers":false,"ControlId":26,"Searchable":false,"Bindable":false,"IsSaveWidget":0,"BindingDetail":"","UCaption":"Goods Receipt Note","__idx":3,"_id":"5E818CEE-0F58-4D2C-A3DB-453C6CE8C691_4_3"}}  />
          <Row key="B87CBED0-0445-4AAC-98B5-813272FE1FDE_5_4" element={{"VersionName":"Medium","Id":5,"uielementid":"B87CBED0-0445-4AAC-98B5-813272FE1FDE","ShowCaption":true,"Fontbold":false,"FontItalic":false,"FontOverline":false,"FontStrikeout":false,"FontUnderline":false,"Depth":3,"Css":"d-flex grid_view justify-content-between fg0","IsBadge":false,"MaxValue":100,"CurrValue":10,"ElementId":"","UIElementid":"B87CBED0-0445-4AAC-98B5-813272FE1FDE","Sequence":2,"ElementName":"UI_Row","ParentElementId":"5CCE7936-6952-4080-834C-E04EA53A93CB","ControlType":"Row","uielementtypeid":11,"Wrap":12,"EnableDFS":false,"ClearFix":false,"OnDemandLoad":false,"IsLastStep":false,"EnableValidation":false,"Buttons":false,"Legend":false,"NavigationNumbers":false,"ControlId":23,"Searchable":false,"Bindable":false,"IsSaveWidget":0,"BindingDetail":"","__idx":4,"_id":"B87CBED0-0445-4AAC-98B5-813272FE1FDE_5_4"}}  >
            <Column key="0E483790-4A88-4D12-A263-876F28509329_7_6" element={{"VersionName":"Medium","Id":7,"uielementid":"0E483790-4A88-4D12-A263-876F28509329","ShowCaption":true,"Fontbold":false,"FontItalic":false,"FontOverline":false,"FontStrikeout":false,"FontUnderline":false,"Depth":4,"Css":"grid_view d-flex gap-2 align-items-center","IsBadge":false,"MaxValue":100,"CurrValue":10,"ElementId":"","UIElementid":"0E483790-4A88-4D12-A263-876F28509329","Sequence":1,"ElementName":"UI_Column","ParentElementId":"B87CBED0-0445-4AAC-98B5-813272FE1FDE","ControlType":"Column","uielementtypeid":5,"Wrap":0,"EnableDFS":false,"ClearFix":false,"OnDemandLoad":false,"IsLastStep":false,"EnableValidation":false,"Buttons":false,"Legend":false,"NavigationNumbers":false,"ControlId":18,"Searchable":false,"Bindable":false,"IsSaveWidget":0,"BindingDetail":"","__idx":6,"_id":"0E483790-4A88-4D12-A263-876F28509329_7_6"}}  >
              <TextBox key="0E483790-4A88-4D12-A263-876F28509329_10_9" element={{"VersionName":"Medium","Id":10,"uielementid":"0E483790-4A88-4D12-A263-876F28509329","ShowCaption":true,"Fontbold":false,"FontItalic":false,"FontOverline":false,"FontStrikeout":false,"FontUnderline":false,"Depth":5,"Css":"bg_magenta","ElementId":"36ABF598-C1E4-4A43-AEE9-A218A5FE021F","UIElementid":"0E483790-4A88-4D12-A263-876F28509329","Sequence":1,"ElementName":"MF_d1_po_number","ParentElementId":"3E117C5C-BA4C-4907-AA01-CAD046BED1E7","ControlType":"TextBox","Wrap":0,"IsMultiline":false,"ClearFix":false,"RenderType":2,"OnDemandLoad":false,"ControlId":1,"HeaderTemplate":"","MergeRow":"","IsSaveWidget":0,"BindingDetail":"","EDT":9,"DCaption":"PO Number","DHelpText":"","DToolTip":"","__idx":9,"_id":"0E483790-4A88-4D12-A263-876F28509329_10_9"}}  />
            </Column>
            <Column key="F879C466-E8DF-480A-8995-599A4F88B23F_8_7" element={{"VersionName":"Medium","Id":8,"uielementid":"F879C466-E8DF-480A-8995-599A4F88B23F","ShowCaption":true,"Fontbold":false,"FontItalic":false,"FontOverline":false,"FontStrikeout":false,"FontUnderline":false,"Depth":4,"Css":"grid_view flex-end gap-2","IsBadge":false,"MaxValue":100,"CurrValue":10,"ElementId":"","UIElementid":"F879C466-E8DF-480A-8995-599A4F88B23F","Sequence":2,"ElementName":"UI_Column","ParentElementId":"B87CBED0-0445-4AAC-98B5-813272FE1FDE","ControlType":"Column","uielementtypeid":5,"Wrap":0,"EnableDFS":false,"ClearFix":false,"OnDemandLoad":false,"IsLastStep":false,"EnableValidation":false,"Buttons":false,"Legend":false,"NavigationNumbers":false,"ControlId":18,"Searchable":false,"Bindable":false,"IsSaveWidget":0,"BindingDetail":"","__idx":7,"_id":"F879C466-E8DF-480A-8995-599A4F88B23F_8_7"}}  >
              <ActionButton key="F879C466-E8DF-480A-8995-599A4F88B23F_11_10" element={{"VersionName":"Medium","Id":11,"uielementid":"F879C466-E8DF-480A-8995-599A4F88B23F","ShowCaption":true,"Fontbold":false,"FontItalic":false,"FontOverline":false,"FontStrikeout":false,"FontUnderline":false,"Depth":5,"Css":"btn btn-primary btn-xs","ElementId":"E5F1FA0C-9E2B-4528-9659-720CF0D77F30","UIElementid":"F879C466-E8DF-480A-8995-599A4F88B23F","Sequence":2,"ElementName":"SubmitForm","ParentElementId":"3E117C5C-BA4C-4907-AA01-CAD046BED1E7","ControlType":"ActionButton","Wrap":0,"ClearFix":false,"OnDemandLoad":false,"ControlId":9,"HeaderTemplate":"","MergeRow":"","IsSaveWidget":0,"BindingDetail":"","EDT":10,"DCaption":"Submit","DHelpText":"","DToolTip":"","__idx":10,"_id":"F879C466-E8DF-480A-8995-599A4F88B23F_11_10"}} gridElements={DataElementsData.filter((f) => f["WidgetId"])} />
            </Column>
          </Row>
        </Div>
        <Div key="C6F85529-35EF-40CE-8E32-DDA2AA0F1411_3_2" element={{"VersionName":"Medium","Id":3,"uielementid":"C6F85529-35EF-40CE-8E32-DDA2AA0F1411","ShowCaption":true,"Fontbold":false,"FontItalic":false,"FontOverline":false,"FontStrikeout":false,"FontUnderline":false,"Depth":2,"Css":"content grid_view","IsBadge":false,"MaxValue":100,"CurrValue":10,"ElementId":"","UIElementid":"C6F85529-35EF-40CE-8E32-DDA2AA0F1411","Sequence":2,"ElementName":"UI_Div","ParentElementId":"5334D888-EA29-4A99-8309-A1E2B95BE03A","ControlType":"Div","uielementtypeid":44,"Wrap":12,"EnableDFS":false,"ClearFix":false,"OnDemandLoad":false,"IsLastStep":false,"EnableValidation":false,"Buttons":false,"Legend":false,"NavigationNumbers":false,"ControlId":51,"Searchable":false,"Bindable":false,"IsSaveWidget":0,"BindingDetail":"","__idx":2,"_id":"C6F85529-35EF-40CE-8E32-DDA2AA0F1411_3_2"}}  >
          <Row key="79D35558-DB85-485F-AA15-A736798E0A96_6_5" element={{"VersionName":"Medium","Id":6,"uielementid":"79D35558-DB85-485F-AA15-A736798E0A96","ShowCaption":true,"Fontbold":false,"FontItalic":false,"FontOverline":false,"FontStrikeout":false,"FontUnderline":false,"Depth":3,"Css":"row grid_view","IsBadge":false,"MaxValue":100,"CurrValue":10,"ElementId":"","UIElementid":"79D35558-DB85-485F-AA15-A736798E0A96","Sequence":3,"ElementName":"UI_Row","ParentElementId":"C6F85529-35EF-40CE-8E32-DDA2AA0F1411","ControlType":"Row","uielementtypeid":11,"Wrap":12,"EnableDFS":false,"ClearFix":false,"OnDemandLoad":false,"IsLastStep":false,"EnableValidation":false,"Buttons":false,"Legend":false,"NavigationNumbers":false,"ControlId":23,"Searchable":false,"Bindable":false,"IsSaveWidget":0,"BindingDetail":"","__idx":5,"_id":"79D35558-DB85-485F-AA15-A736798E0A96_6_5"}}  >
            <Column key="5453869D-A76A-413C-B438-999D3E4A798D_9_8" element={{"VersionName":"Medium","Id":9,"uielementid":"5453869D-A76A-413C-B438-999D3E4A798D","ShowCaption":true,"Fontbold":false,"FontItalic":false,"FontOverline":false,"FontStrikeout":false,"FontUnderline":false,"Depth":4,"Css":"grid_view docview_img","IsBadge":false,"MaxValue":100,"CurrValue":10,"ElementId":"","UIElementid":"5453869D-A76A-413C-B438-999D3E4A798D","Sequence":3,"ElementName":"UI_Column","ParentElementId":"79D35558-DB85-485F-AA15-A736798E0A96","ControlType":"Column","uielementtypeid":5,"Wrap":12,"EnableDFS":false,"ClearFix":false,"OnDemandLoad":false,"IsLastStep":false,"EnableValidation":false,"Buttons":false,"Legend":false,"NavigationNumbers":false,"ControlId":18,"Searchable":false,"Bindable":false,"IsSaveWidget":0,"BindingDetail":"","__idx":8,"_id":"5453869D-A76A-413C-B438-999D3E4A798D_9_8"}}  >
              <DocumentType key="5453869D-A76A-413C-B438-999D3E4A798D_12_11" element={{"VersionName":"Medium","Id":12,"uielementid":"5453869D-A76A-413C-B438-999D3E4A798D","ShowCaption":true,"Fontbold":false,"FontItalic":false,"FontOverline":false,"FontStrikeout":false,"FontUnderline":false,"Depth":5,"Css":"form-control input-xs","ElementId":"9C93046B-0C6A-40B8-BBC1-57A6EE082501","UIElementid":"5453869D-A76A-413C-B438-999D3E4A798D","Sequence":3,"ElementName":"M_DocId","ParentElementId":"3E117C5C-BA4C-4907-AA01-CAD046BED1E7","ControlType":"DocumentType","Wrap":12,"DocumentSettings":"[{\"Size\":null,\"AllowedTypes\":null}]","ClearFix":false,"RenderType":4,"OnDemandLoad":false,"ControlId":8,"HeaderTemplate":"","MergeRow":"","IsSaveWidget":0,"BindingDetail":"","EDT":1,"DCaption":"GRN Document","DHelpText":"","DToolTip":"","__idx":11,"_id":"5453869D-A76A-413C-B438-999D3E4A798D_12_11"}}  />
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

export default O2CGRN_Start;
