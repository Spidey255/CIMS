// Innovace Intech Solution Pvt Ltd

import { useEffect, useMemo } from "react";
import { useSearchParams } from "react-router-dom";
import { usePageStore } from "@/store/usePageStore";
import { DataElementsData } from "./DigivistaDocumentManagementSystem";
import Store from "@/components/Store";



// Dynamically imported components
import Column from "@/components/UI_Controls/Column.tsx";
import Div from "@/components/UI_Controls/Div.tsx";
import Row from "@/components/UI_Controls/Row.tsx";
import Panel from "@/components/UI_Controls/Panel.tsx";
import Accordion from "@/components/UI_Controls/Accordion";
import PanelBody from "@/components/UI_Controls/PanelBody.tsx";
import AccordionPane from "@/components/UI_Controls/AccordionPane";
import Barcode from "@/components/Data_Controls/Barcode/Deafult";
import Header from "@/components/UI_Controls/Header.tsx";
import TextBox from "@/components/Data_Controls/TextBox";


const DigivistaDocumentManagementSystem = ({
  ProcessName = "DocuemntGrid",
  PackageProcessMapId = "F803A994-9682-477C-82AA-2B964D0D3002",
  FormVersionId = "1A6C3AEF-FBDE-41F9-84E7-210F2A4D22EA",
  ProcessActivityMapId = "C9E6AE39-B1AC-449E-B18B-15BF5D4209E1"
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
      
      <Column key="dfd0c546-af4f-1aee-d912-7a004817a417_1_0" element={{"VersionName":"Medium","Id":1,"WidgetId":"DFA43166-31F4-4258-AD3D-871FCF6038D4","uielementid":"dfd0c546-af4f-1aee-d912-7a004817a417","WidgetName":"DocuemntGrid_Root_Start.Json","ShowCaption":false,"Fontbold":false,"FontItalic":false,"FontOverline":false,"FontStrikeout":false,"FontUnderline":false,"Depth":1,"IsBadge":false,"ElementId":"","UIElementid":"dfd0c546-af4f-1aee-d912-7a004817a417","Sequence":1,"ElementName":"UI_MainContainer","ControlType":"Column","uielementtypeid":5,"Wrap":12,"EnableDFS":false,"ClearFix":false,"OnDemandLoad":false,"IsLastStep":false,"EnableValidation":false,"Buttons":false,"Legend":false,"NavigationNumbers":false,"ControlId":18,"Searchable":false,"Bindable":false,"Action":"FormOnLoad","IsSaveWidget":0,"BindingDetail":"[{\"Endpoint\":\"~\\/iProofServicesHub\\/ExecuteFormLoad\",\"HttpVerb\":\"Post\",\"Port\":\"5009\",\"Params\":[{\"ElementName\":\"M_QRCode\",\"Value\":\"\",\"EDT\":9}]}]","DCaption":"","__idx":0,"_id":"dfd0c546-af4f-1aee-d912-7a004817a417_1_0"}}  >
        <Div key="03d2eb17-8df1-23cc-fdb6-310ef1d103b4_2_1" element={{"VersionName":"Medium","Id":2,"uielementid":"03d2eb17-8df1-23cc-fdb6-310ef1d103b4","ShowCaption":true,"Fontbold":false,"FontItalic":false,"FontOverline":false,"FontStrikeout":false,"FontUnderline":false,"Depth":2,"Css":"content grid_view","IsBadge":false,"ElementId":"","UIElementid":"03d2eb17-8df1-23cc-fdb6-310ef1d103b4","Sequence":1,"ElementName":"UI_Div","ParentElementId":"dfd0c546-af4f-1aee-d912-7a004817a417","ControlType":"Div","uielementtypeid":44,"Wrap":12,"EnableDFS":false,"ClearFix":false,"OnDemandLoad":false,"IsLastStep":false,"EnableValidation":false,"Buttons":false,"Legend":false,"NavigationNumbers":false,"ControlId":51,"Searchable":false,"Bindable":false,"IsSaveWidget":0,"BindingDetail":"","__idx":1,"_id":"03d2eb17-8df1-23cc-fdb6-310ef1d103b4_2_1"}}  >
          <Row key="fa72789e-b2a7-2e66-66f8-6a1d79031375_3_2" element={{"VersionName":"Medium","Id":3,"uielementid":"fa72789e-b2a7-2e66-66f8-6a1d79031375","ShowCaption":true,"Fontbold":false,"FontItalic":false,"FontOverline":false,"FontStrikeout":false,"FontUnderline":false,"Depth":3,"Css":"row grid_view","IsBadge":false,"ElementId":"","UIElementid":"fa72789e-b2a7-2e66-66f8-6a1d79031375","Sequence":1,"ElementName":"UI_Row","ParentElementId":"03d2eb17-8df1-23cc-fdb6-310ef1d103b4","ControlType":"Row","uielementtypeid":11,"Wrap":12,"EnableDFS":false,"ClearFix":false,"OnDemandLoad":false,"IsLastStep":false,"EnableValidation":false,"Buttons":false,"Legend":false,"NavigationNumbers":false,"ControlId":23,"Searchable":false,"Bindable":false,"IsSaveWidget":0,"BindingDetail":"","__idx":2,"_id":"fa72789e-b2a7-2e66-66f8-6a1d79031375_3_2"}}  >
            <Panel key="775ba8e4-b4ff-fe48-0b31-2510cbe8a97e_4_3" element={{"VersionName":"Medium","Id":4,"uielementid":"775ba8e4-b4ff-fe48-0b31-2510cbe8a97e","ShowCaption":true,"Fontbold":false,"FontItalic":false,"FontOverline":false,"FontStrikeout":false,"FontUnderline":false,"Depth":4,"Css":"card grid_view","IsBadge":false,"ElementId":"","UIElementid":"775ba8e4-b4ff-fe48-0b31-2510cbe8a97e","Sequence":1,"ElementName":"UI_Panel","ParentElementId":"fa72789e-b2a7-2e66-66f8-6a1d79031375","ControlType":"Panel","uielementtypeid":1,"Wrap":12,"EnableDFS":false,"ClearFix":false,"OnDemandLoad":false,"IsLastStep":false,"EnableValidation":false,"Buttons":false,"Legend":false,"NavigationNumbers":false,"ControlId":15,"Searchable":false,"Bindable":false,"IsSaveWidget":0,"BindingDetail":"","__idx":3,"_id":"775ba8e4-b4ff-fe48-0b31-2510cbe8a97e_4_3"}}  >
              <PanelBody key="a167df96-bb68-119d-310e-cf1b4ccbae1e_6_5" element={{"VersionName":"Medium","Id":6,"uielementid":"a167df96-bb68-119d-310e-cf1b4ccbae1e","ShowCaption":true,"Fontbold":false,"FontItalic":false,"FontOverline":false,"FontStrikeout":false,"FontUnderline":false,"Depth":5,"Css":"card-body","IsBadge":false,"ElementId":"","UIElementid":"a167df96-bb68-119d-310e-cf1b4ccbae1e","Sequence":1,"ElementName":"UI_Panel Body","ParentElementId":"775ba8e4-b4ff-fe48-0b31-2510cbe8a97e","ControlType":"Panel Body","uielementtypeid":28,"Wrap":12,"EnableDFS":false,"ClearFix":false,"OnDemandLoad":false,"IsLastStep":false,"EnableValidation":false,"Buttons":false,"Legend":false,"NavigationNumbers":false,"ControlId":35,"Searchable":false,"Bindable":false,"IsSaveWidget":0,"BindingDetail":"","__idx":5,"_id":"a167df96-bb68-119d-310e-cf1b4ccbae1e_6_5"}}  >
                <Barcode key="a167df96-bb68-119d-310e-cf1b4ccbae1e_10_9" element={{"VersionName":"Medium","Id":10,"uielementid":"a167df96-bb68-119d-310e-cf1b4ccbae1e","ShowCaption":true,"Fontbold":false,"FontItalic":false,"FontOverline":false,"FontStrikeout":false,"FontUnderline":false,"Depth":6,"ElementId":"c1ee5e93-4797-0993-4fa9-b026da239a8f","UIElementid":"a167df96-bb68-119d-310e-cf1b4ccbae1e","Sequence":1,"ElementName":"M_QRCode","ParentElementId":"DFA43166-31F4-4258-AD3D-871FCF6038D4","ControlType":"Barcode","Wrap":4,"IsMultiline":false,"ClearFix":false,"RenderType":24,"OnDemandLoad":false,"ControlId":81,"DisplayName":"M_QRCode","Searchable":false,"Bindable":false,"HeaderTemplate":"","MergeRow":"","IsSaveWidget":0,"BindingDetail":"","EDT":9,"DCaption":"M_QRCode","__idx":9,"_id":"a167df96-bb68-119d-310e-cf1b4ccbae1e_10_9"}}  />
              </PanelBody>
            </Panel>
            <Accordion key="6a3a7300-7a16-5f8b-19bc-22113ef71e2f_5_4" element={{"VersionName":"Medium","Id":5,"uielementid":"6a3a7300-7a16-5f8b-19bc-22113ef71e2f","ShowCaption":true,"Fontbold":false,"FontItalic":false,"FontOverline":false,"FontStrikeout":false,"FontUnderline":false,"Depth":4,"Css":"panel-group accordion-sortable content-group-lg ui-sortable","IsBadge":false,"ElementId":"","UIElementid":"6a3a7300-7a16-5f8b-19bc-22113ef71e2f","Sequence":2,"ElementName":"UI_Accordion","ParentElementId":"fa72789e-b2a7-2e66-66f8-6a1d79031375","ControlType":"Accordion","uielementtypeid":8,"Wrap":12,"EnableDFS":false,"ClearFix":false,"OnDemandLoad":false,"IsLastStep":false,"EnableValidation":false,"Buttons":false,"Legend":false,"NavigationNumbers":false,"ControlId":21,"Searchable":false,"Bindable":false,"IsSaveWidget":0,"BindingDetail":"","__idx":4,"_id":"6a3a7300-7a16-5f8b-19bc-22113ef71e2f_5_4"}}  >
              <AccordionPane key="f159f039-d550-3dbc-83a6-67c2e61873fe_7_6" element={{"VersionName":"Medium","Id":7,"uielementid":"f159f039-d550-3dbc-83a6-67c2e61873fe","ShowCaption":true,"Fontbold":false,"FontItalic":false,"FontOverline":false,"FontStrikeout":false,"FontUnderline":false,"Depth":5,"Css":"panel-heading bg-slate","IsBadge":false,"ElementId":"","UIElementid":"f159f039-d550-3dbc-83a6-67c2e61873fe","Sequence":2,"ElementName":"UI_AccordionPane","ParentElementId":"6a3a7300-7a16-5f8b-19bc-22113ef71e2f","ControlType":"AccordionPane","uielementtypeid":9,"Wrap":12,"EnableDFS":false,"ClearFix":false,"OnDemandLoad":false,"IsLastStep":false,"EnableValidation":false,"Buttons":false,"Legend":false,"NavigationNumbers":false,"ControlId":22,"Searchable":false,"Bindable":false,"IsSaveWidget":0,"BindingDetail":"","__idx":6,"_id":"f159f039-d550-3dbc-83a6-67c2e61873fe_7_6"}}  >
                <Header key="d7a97baa-4fb9-0fa3-88b7-9f2eabc04089_11_10" element={{"VersionName":"Medium","Id":11,"uielementid":"d7a97baa-4fb9-0fa3-88b7-9f2eabc04089","ShowCaption":true,"Fontbold":false,"FontItalic":false,"FontOverline":false,"FontStrikeout":false,"FontUnderline":false,"Depth":6,"IsBadge":false,"HeadingType":"h1","ElementId":"","UIElementid":"d7a97baa-4fb9-0fa3-88b7-9f2eabc04089","Sequence":2,"ElementName":"UI_Header","ParentElementId":"f159f039-d550-3dbc-83a6-67c2e61873fe","ControlType":"Header","uielementtypeid":16,"Wrap":12,"EnableDFS":false,"ClearFix":false,"OnDemandLoad":false,"IsLastStep":false,"EnableValidation":false,"Buttons":false,"Legend":false,"NavigationNumbers":false,"ControlId":26,"Searchable":false,"Bindable":false,"IsSaveWidget":0,"BindingDetail":"","UCaption":"Header","__idx":10,"_id":"d7a97baa-4fb9-0fa3-88b7-9f2eabc04089_11_10"}}  />
              </AccordionPane>
              <AccordionPane key="63befe96-dca3-c9da-b590-ae1a9945241b_8_7" element={{"VersionName":"Medium","Id":8,"uielementid":"63befe96-dca3-c9da-b590-ae1a9945241b","ShowCaption":true,"Fontbold":false,"FontItalic":false,"FontOverline":false,"FontStrikeout":false,"FontUnderline":false,"Depth":5,"Css":"panel-heading bg-slate","IsBadge":false,"ElementId":"","UIElementid":"63befe96-dca3-c9da-b590-ae1a9945241b","Sequence":3,"ElementName":"UI_AccordionPane","ParentElementId":"6a3a7300-7a16-5f8b-19bc-22113ef71e2f","ControlType":"AccordionPane","uielementtypeid":9,"Wrap":12,"EnableDFS":false,"ClearFix":false,"OnDemandLoad":false,"IsLastStep":false,"EnableValidation":false,"Buttons":false,"Legend":false,"NavigationNumbers":false,"ControlId":22,"Searchable":false,"Bindable":false,"IsSaveWidget":0,"BindingDetail":"","__idx":7,"_id":"63befe96-dca3-c9da-b590-ae1a9945241b_8_7"}}  >
                <Header key="d3b32f4d-27c3-0c0a-64ab-ee227a8a31dd_12_11" element={{"VersionName":"Medium","Id":12,"uielementid":"d3b32f4d-27c3-0c0a-64ab-ee227a8a31dd","ShowCaption":true,"Fontbold":false,"FontItalic":false,"FontOverline":false,"FontStrikeout":false,"FontUnderline":false,"Depth":6,"IsBadge":false,"HeadingType":"h1","ElementId":"","UIElementid":"d3b32f4d-27c3-0c0a-64ab-ee227a8a31dd","Sequence":3,"ElementName":"UI_Header","ParentElementId":"63befe96-dca3-c9da-b590-ae1a9945241b","ControlType":"Header","uielementtypeid":16,"Wrap":12,"EnableDFS":false,"ClearFix":false,"OnDemandLoad":false,"IsLastStep":false,"EnableValidation":false,"Buttons":false,"Legend":false,"NavigationNumbers":false,"ControlId":26,"Searchable":false,"Bindable":false,"IsSaveWidget":0,"BindingDetail":"","UCaption":"Header","__idx":11,"_id":"d3b32f4d-27c3-0c0a-64ab-ee227a8a31dd_12_11"}}  />
              </AccordionPane>
              <AccordionPane key="3e3b76de-5a56-2c60-0ecc-e86899d6fc54_9_8" element={{"VersionName":"Medium","Id":9,"uielementid":"3e3b76de-5a56-2c60-0ecc-e86899d6fc54","ShowCaption":true,"Fontbold":false,"FontItalic":false,"FontOverline":false,"FontStrikeout":false,"FontUnderline":false,"Depth":5,"Css":"panel-heading bg-slate","IsBadge":false,"ElementId":"","UIElementid":"3e3b76de-5a56-2c60-0ecc-e86899d6fc54","Sequence":4,"ElementName":"UI_AccordionPane","ParentElementId":"6a3a7300-7a16-5f8b-19bc-22113ef71e2f","ControlType":"AccordionPane","uielementtypeid":9,"Wrap":12,"EnableDFS":false,"ClearFix":false,"OnDemandLoad":false,"IsLastStep":false,"EnableValidation":false,"Buttons":false,"Legend":false,"NavigationNumbers":false,"ControlId":22,"Searchable":false,"Bindable":false,"IsSaveWidget":0,"BindingDetail":"","__idx":8,"_id":"3e3b76de-5a56-2c60-0ecc-e86899d6fc54_9_8"}}  >
                <TextBox key="3e3b76de-5a56-2c60-0ecc-e86899d6fc54_13_12" element={{"VersionName":"Medium","Id":13,"uielementid":"3e3b76de-5a56-2c60-0ecc-e86899d6fc54","ShowCaption":true,"Fontbold":false,"FontItalic":false,"FontOverline":false,"FontStrikeout":false,"FontUnderline":false,"Depth":6,"ElementId":"2263987C-4568-429E-9498-6C4FBEB73456","UIElementid":"3e3b76de-5a56-2c60-0ecc-e86899d6fc54","Sequence":4,"ElementName":"Subject","ParentElementId":"DFA43166-31F4-4258-AD3D-871FCF6038D4","ControlType":"TextBox","Wrap":4,"IsMultiline":true,"ClearFix":false,"RenderType":1,"OnDemandLoad":false,"ControlId":1,"DisplayName":"Subject","Searchable":false,"Bindable":false,"HeaderTemplate":"","MergeRow":"","IsSaveWidget":0,"BindingDetail":"","EDT":9,"DCaption":"Subject","__idx":12,"_id":"3e3b76de-5a56-2c60-0ecc-e86899d6fc54_13_12"}}  />
              </AccordionPane>
            </Accordion>
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

export default DigivistaDocumentManagementSystem;
