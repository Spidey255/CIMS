// Innovace Intech Solution Pvt Ltd

import { useEffect, useMemo } from "react";
import { useSearchParams } from "react-router-dom";
import { usePageStore } from "@/store/usePageStore";
import { DataElementsData } from "./P2PDossier360_Start";
import Store from "@/components/Store";



// Dynamically imported components
import Column from "@/components/UI_Controls/Column.tsx";
import Div from "@/components/UI_Controls/Div.tsx";
import Header from "@/components/UI_Controls/Header.tsx";
import Row from "@/components/UI_Controls/Row.tsx";
import PlaceHolder from "@/components/Data_Controls/PlaceHolder.tsx";
import TextBox from "@/components/Data_Controls/TextBox";
import DateTimePicker from "@/components/Data_Controls/DateTimePicker";


const P2PDossier360_Start = ({
  ProcessName = "P2PDossier360",
  PackageProcessMapId = "F746B915-AB63-48B8-9BD3-2A9AB55E9493",
  FormVersionId = "CA332CB5-D7FC-40DE-A654-08A209CAD8E3",
  ProcessActivityMapId = "FB4B6A6E-1E0C-442A-AA1E-610EA5A9942C"
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
      
      <Column key="e6709ebe-0ad8-c51f-c750-55cd4170ca9b_1_0" element={{"VersionName":"Medium","Id":1,"WidgetId":"FCEE4E04-E697-4277-B7C2-882A6FF9D1E7","uielementid":"e6709ebe-0ad8-c51f-c750-55cd4170ca9b","WidgetName":"P2PDossier360_Root_Start.Json","ShowCaption":false,"Fontbold":false,"FontItalic":false,"FontOverline":false,"FontStrikeout":false,"FontUnderline":false,"Depth":1,"IsBadge":false,"ElementId":"","UIElementid":"e6709ebe-0ad8-c51f-c750-55cd4170ca9b","Sequence":1,"ElementName":"UI_MainContainer","ControlType":"Column","uielementtypeid":5,"Wrap":12,"EnableDFS":false,"ClearFix":false,"OnDemandLoad":false,"IsLastStep":false,"EnableValidation":false,"Buttons":false,"Legend":false,"NavigationNumbers":false,"ControlId":18,"Searchable":false,"Bindable":false,"Action":"FormOnLoad","IsSaveWidget":0,"BindingDetail":"[{\"Endpoint\":\"~\\/iProofServicesHub\\/ExecuteFormLoad\",\"HttpVerb\":\"Post\",\"Port\":\"5009\",\"Params\":[{\"ElementName\":\"M_DossierName\",\"Value\":\"\",\"EDT\":9},{\"ElementName\":\"M_PoSubType\",\"Value\":\"\",\"EDT\":9},{\"ElementName\":\"M_PoType\",\"Value\":\"\",\"EDT\":9},{\"ElementName\":\"M_TreePlaceHolder\",\"Value\":\"\",\"EDT\":10},{\"ElementName\":\"M_PoNumber\",\"Value\":\"\",\"EDT\":9},{\"ElementName\":\"M_PODate\",\"Value\":\"\",\"EDT\":8}]}]","DCaption":"","__idx":0,"_id":"e6709ebe-0ad8-c51f-c750-55cd4170ca9b_1_0"}}  >
        <Div key="0e742772-6f20-d175-040b-141981600315_2_1" element={{"VersionName":"Medium","Id":2,"uielementid":"0e742772-6f20-d175-040b-141981600315","ShowCaption":true,"Fontbold":false,"FontItalic":false,"FontOverline":false,"FontStrikeout":false,"FontUnderline":false,"Depth":2,"Css":"page-header page-header-light shadow p-2 position-sticky top-0 px-3","IsBadge":false,"ElementId":"","UIElementid":"0e742772-6f20-d175-040b-141981600315","Sequence":1,"ElementName":"UI_Div","ParentElementId":"e6709ebe-0ad8-c51f-c750-55cd4170ca9b","ControlType":"Div","uielementtypeid":44,"Wrap":12,"EnableDFS":false,"ClearFix":false,"OnDemandLoad":false,"IsLastStep":false,"EnableValidation":false,"Buttons":false,"Legend":false,"NavigationNumbers":false,"ControlId":51,"Searchable":false,"Bindable":false,"IsSaveWidget":0,"BindingDetail":"","__idx":1,"_id":"0e742772-6f20-d175-040b-141981600315_2_1"}}  >
          <Header key="2178841c-8d5a-0938-e392-22e267acf896_4_3" element={{"VersionName":"Medium","Id":4,"uielementid":"2178841c-8d5a-0938-e392-22e267acf896","ShowCaption":true,"Fontbold":false,"FontItalic":false,"FontOverline":false,"FontStrikeout":false,"FontUnderline":false,"Depth":3,"Css":"mb-0 heading-caption","IsBadge":false,"HeadingType":"h5","ElementId":"","UIElementid":"2178841c-8d5a-0938-e392-22e267acf896","Sequence":1,"ElementName":"UI_P2P Dossier 360","ParentElementId":"0e742772-6f20-d175-040b-141981600315","ControlType":"Header","uielementtypeid":16,"Wrap":12,"EnableDFS":false,"ClearFix":false,"OnDemandLoad":false,"IsLastStep":false,"EnableValidation":false,"Buttons":false,"Legend":false,"NavigationNumbers":false,"ControlId":26,"Searchable":false,"Bindable":false,"IsSaveWidget":0,"BindingDetail":"","UCaption":"P2P Dossier 360","__idx":3,"_id":"2178841c-8d5a-0938-e392-22e267acf896_4_3"}}  />
          <Row key="1483aced-ac0e-c666-87f6-3e141dab4ca7_5_4" element={{"VersionName":"Medium","Id":5,"uielementid":"1483aced-ac0e-c666-87f6-3e141dab4ca7","ShowCaption":true,"Fontbold":false,"FontItalic":false,"FontOverline":false,"FontStrikeout":false,"FontUnderline":false,"Depth":3,"Css":"d-flex grid_view justify-content-between fg0","IsBadge":false,"ElementId":"","UIElementid":"1483aced-ac0e-c666-87f6-3e141dab4ca7","Sequence":2,"ElementName":"UI_Row","ParentElementId":"0e742772-6f20-d175-040b-141981600315","ControlType":"Row","uielementtypeid":11,"Wrap":12,"EnableDFS":false,"ClearFix":false,"OnDemandLoad":false,"IsLastStep":false,"EnableValidation":false,"Buttons":false,"Legend":false,"NavigationNumbers":false,"ControlId":23,"Searchable":false,"Bindable":false,"IsSaveWidget":0,"BindingDetail":"","__idx":4,"_id":"1483aced-ac0e-c666-87f6-3e141dab4ca7_5_4"}}  >
            <Column key="f7ed4b17-af67-3b63-a015-5a5296a4e9cb_7_6" element={{"VersionName":"Medium","Id":7,"uielementid":"f7ed4b17-af67-3b63-a015-5a5296a4e9cb","ShowCaption":true,"Fontbold":false,"FontItalic":false,"FontOverline":false,"FontStrikeout":false,"FontUnderline":false,"Depth":4,"Css":"grid_view d-flex gap-2 align-items-center","IsBadge":false,"ElementId":"","UIElementid":"f7ed4b17-af67-3b63-a015-5a5296a4e9cb","Sequence":1,"ElementName":"UI_Column","ParentElementId":"1483aced-ac0e-c666-87f6-3e141dab4ca7","ControlType":"Column","uielementtypeid":5,"Wrap":0,"EnableDFS":false,"ClearFix":false,"OnDemandLoad":false,"IsLastStep":false,"EnableValidation":false,"Buttons":false,"Legend":false,"NavigationNumbers":false,"ControlId":18,"Searchable":false,"Bindable":false,"IsSaveWidget":0,"BindingDetail":"","__idx":6,"_id":"f7ed4b17-af67-3b63-a015-5a5296a4e9cb_7_6"}}  >
              <TextBox key="f7ed4b17-af67-3b63-a015-5a5296a4e9cb_10_9" element={{"VersionName":"Medium","Id":10,"uielementid":"f7ed4b17-af67-3b63-a015-5a5296a4e9cb","ShowCaption":true,"Fontbold":false,"FontItalic":false,"FontOverline":false,"FontStrikeout":false,"FontUnderline":false,"Depth":5,"Css":"bg_violet_02","ElementId":"8582f351-1718-39a1-d6cd-fa44017fa305","UIElementid":"f7ed4b17-af67-3b63-a015-5a5296a4e9cb","Sequence":1,"ElementName":"M_DossierName","ParentElementId":"FCEE4E04-E697-4277-B7C2-882A6FF9D1E7","ControlType":"TextBox","Wrap":0,"IsMultiline":false,"ClearFix":false,"RenderType":2,"OnDemandLoad":false,"ControlId":1,"DisplayName":"M_DossierName","Searchable":false,"Bindable":false,"HeaderTemplate":"","MergeRow":"","IsSaveWidget":0,"BindingDetail":"","EDT":9,"DCaption":"Dossier Name","DHelpText":"","DToolTip":"","__idx":9,"_id":"f7ed4b17-af67-3b63-a015-5a5296a4e9cb_10_9"}}  />
              <TextBox key="f7ed4b17-af67-3b63-a015-5a5296a4e9cb_11_10" element={{"VersionName":"Medium","Id":11,"uielementid":"f7ed4b17-af67-3b63-a015-5a5296a4e9cb","ShowCaption":true,"Fontbold":false,"FontItalic":false,"FontOverline":false,"FontStrikeout":false,"FontUnderline":false,"Depth":5,"Css":"bg_magenta","ElementId":"5b243aab-4798-d430-de1e-f27c51823081","UIElementid":"f7ed4b17-af67-3b63-a015-5a5296a4e9cb","Sequence":2,"ElementName":"M_PoType","ParentElementId":"FCEE4E04-E697-4277-B7C2-882A6FF9D1E7","ControlType":"TextBox","Wrap":0,"IsMultiline":false,"ClearFix":false,"RenderType":2,"OnDemandLoad":false,"ControlId":1,"DisplayName":"M_PoType","Searchable":false,"Bindable":false,"HeaderTemplate":"","MergeRow":"","IsSaveWidget":0,"BindingDetail":"","EDT":9,"DCaption":"PO Type","DHelpText":"","DToolTip":"","__idx":10,"_id":"f7ed4b17-af67-3b63-a015-5a5296a4e9cb_11_10"}}  />
              <TextBox key="f7ed4b17-af67-3b63-a015-5a5296a4e9cb_12_11" element={{"VersionName":"Medium","Id":12,"uielementid":"f7ed4b17-af67-3b63-a015-5a5296a4e9cb","ShowCaption":true,"Fontbold":false,"FontItalic":false,"FontOverline":false,"FontStrikeout":false,"FontUnderline":false,"Depth":5,"Css":"bg_grey","ElementId":"0c384eae-5262-616f-92e7-c21428b79721","UIElementid":"f7ed4b17-af67-3b63-a015-5a5296a4e9cb","Sequence":3,"ElementName":"M_PoSubType","ParentElementId":"FCEE4E04-E697-4277-B7C2-882A6FF9D1E7","ControlType":"TextBox","Wrap":0,"IsMultiline":false,"ClearFix":false,"RenderType":2,"OnDemandLoad":false,"ControlId":1,"DisplayName":"M_PoSubType","Searchable":false,"Bindable":false,"HeaderTemplate":"","MergeRow":"","IsSaveWidget":0,"BindingDetail":"","EDT":9,"DCaption":"PO Sub Type","DHelpText":"","DToolTip":"","__idx":11,"_id":"f7ed4b17-af67-3b63-a015-5a5296a4e9cb_12_11"}}  />
              <TextBox key="f7ed4b17-af67-3b63-a015-5a5296a4e9cb_13_12" element={{"VersionName":"Medium","Id":13,"uielementid":"f7ed4b17-af67-3b63-a015-5a5296a4e9cb","ShowCaption":true,"Fontbold":false,"FontItalic":false,"FontOverline":false,"FontStrikeout":false,"FontUnderline":false,"Depth":5,"Css":"frm_ltr","ElementId":"6ff18d16-db27-25e5-ad17-b06d4b3eb0df","UIElementid":"f7ed4b17-af67-3b63-a015-5a5296a4e9cb","Sequence":4,"ElementName":"M_PoNumber","ParentElementId":"FCEE4E04-E697-4277-B7C2-882A6FF9D1E7","ControlType":"TextBox","Wrap":0,"IsMultiline":false,"ClearFix":false,"RenderType":2,"OnDemandLoad":false,"ControlId":1,"DisplayName":"M_PoNumber","Searchable":false,"Bindable":false,"HeaderTemplate":"","MergeRow":"","IsSaveWidget":0,"BindingDetail":"","EDT":9,"DCaption":"PO Number","DHelpText":"","DToolTip":"","__idx":12,"_id":"f7ed4b17-af67-3b63-a015-5a5296a4e9cb_13_12"}}  />
              <DateTimePicker key="f7ed4b17-af67-3b63-a015-5a5296a4e9cb_14_13" element={{"VersionName":"Medium","Id":14,"uielementid":"f7ed4b17-af67-3b63-a015-5a5296a4e9cb","ShowCaption":false,"Fontbold":false,"FontItalic":false,"FontOverline":false,"FontStrikeout":false,"FontUnderline":false,"Depth":5,"Css":"initiatedon","ElementId":"d687b3f2-8bbe-dbb7-75fb-a78fb7dc2ecc","UIElementid":"f7ed4b17-af67-3b63-a015-5a5296a4e9cb","Sequence":5,"ElementName":"M_PODate","ParentElementId":"FCEE4E04-E697-4277-B7C2-882A6FF9D1E7","ControlType":"DateTimePicker","Wrap":0,"ClearFix":false,"RenderType":10,"OnDemandLoad":false,"ControlId":7,"DisplayName":"M_PODate","Searchable":false,"Bindable":false,"HeaderTemplate":"","MergeRow":"","IsSaveWidget":0,"BindingDetail":"","EDT":8,"DCaption":"","DHelpText":"","DToolTip":"","__idx":13,"_id":"f7ed4b17-af67-3b63-a015-5a5296a4e9cb_14_13"}}  />
            </Column>
            <Column key="3569619b-b898-7d8f-203b-2307241c09f3_8_7" element={{"VersionName":"Medium","Id":8,"uielementid":"3569619b-b898-7d8f-203b-2307241c09f3","ShowCaption":true,"Fontbold":false,"FontItalic":false,"FontOverline":false,"FontStrikeout":false,"FontUnderline":false,"Depth":4,"Css":"grid_view flex-end gap-2","IsBadge":false,"ElementId":"","UIElementid":"3569619b-b898-7d8f-203b-2307241c09f3","Sequence":2,"ElementName":"UI_Column","ParentElementId":"1483aced-ac0e-c666-87f6-3e141dab4ca7","ControlType":"Column","uielementtypeid":5,"Wrap":0,"EnableDFS":false,"ClearFix":false,"OnDemandLoad":false,"IsLastStep":false,"EnableValidation":false,"Buttons":false,"Legend":false,"NavigationNumbers":false,"ControlId":18,"Searchable":false,"Bindable":false,"IsSaveWidget":0,"BindingDetail":"","__idx":7,"_id":"3569619b-b898-7d8f-203b-2307241c09f3_8_7"}}  />
          </Row>
        </Div>
        <Div key="71bb908b-658c-373c-84ea-58019c79acdd_3_2" element={{"VersionName":"Medium","Id":3,"uielementid":"71bb908b-658c-373c-84ea-58019c79acdd","ShowCaption":true,"Fontbold":false,"FontItalic":false,"FontOverline":false,"FontStrikeout":false,"FontUnderline":false,"Depth":2,"Css":"content grid_view","IsBadge":false,"MaxValue":100,"CurrValue":10,"ElementId":"","UIElementid":"71bb908b-658c-373c-84ea-58019c79acdd","Sequence":2,"ElementName":"UI_Div","ParentElementId":"e6709ebe-0ad8-c51f-c750-55cd4170ca9b","ControlType":"Div","uielementtypeid":44,"Wrap":12,"EnableDFS":false,"ClearFix":false,"OnDemandLoad":false,"IsLastStep":false,"EnableValidation":false,"Buttons":false,"Legend":false,"NavigationNumbers":false,"ControlId":51,"Searchable":false,"Bindable":false,"IsSaveWidget":0,"BindingDetail":"","__idx":2,"_id":"71bb908b-658c-373c-84ea-58019c79acdd_3_2"}}  >
          <Row key="0add887d-19cc-dd68-f19a-1d9a3b60dca9_6_5" element={{"VersionName":"Medium","Id":6,"uielementid":"0add887d-19cc-dd68-f19a-1d9a3b60dca9","ShowCaption":true,"Fontbold":false,"FontItalic":false,"FontOverline":false,"FontStrikeout":false,"FontUnderline":false,"Depth":3,"Css":"row grid_view","IsBadge":false,"MaxValue":100,"CurrValue":10,"ElementId":"","UIElementid":"0add887d-19cc-dd68-f19a-1d9a3b60dca9","Sequence":3,"ElementName":"UI_Row","ParentElementId":"71bb908b-658c-373c-84ea-58019c79acdd","ControlType":"Row","uielementtypeid":11,"Wrap":12,"EnableDFS":false,"ClearFix":false,"OnDemandLoad":false,"IsLastStep":false,"EnableValidation":false,"Buttons":false,"Legend":false,"NavigationNumbers":false,"ControlId":23,"Searchable":false,"Bindable":false,"IsSaveWidget":0,"BindingDetail":"","__idx":5,"_id":"0add887d-19cc-dd68-f19a-1d9a3b60dca9_6_5"}}  >
            <PlaceHolder key="0add887d-19cc-dd68-f19a-1d9a3b60dca9_9_8" element={{"VersionName":"Medium","Id":9,"uielementid":"0add887d-19cc-dd68-f19a-1d9a3b60dca9","ShowCaption":false,"Fontbold":false,"FontItalic":false,"FontOverline":false,"FontStrikeout":false,"FontUnderline":false,"Depth":4,"Css":"form-group","height":800,"ElementId":"55892721-fb43-705e-ccc4-ece6d5f74c6a","UIElementid":"0add887d-19cc-dd68-f19a-1d9a3b60dca9","Sequence":3,"ElementName":"M_TreePlaceHolder","ParentElementId":"FCEE4E04-E697-4277-B7C2-882A6FF9D1E7","ControlType":"PlaceHolder","Wrap":12,"ClearFix":false,"OnDemandLoad":false,"ControlId":14,"DisplayName":"M_TreePlaceHolder","Searchable":false,"Bindable":false,"HeaderTemplate":"","MergeRow":"","IsSaveWidget":0,"BindingDetail":"","EDT":10,"DCaption":"","DHelpText":"","DToolTip":"","__idx":8,"_id":"0add887d-19cc-dd68-f19a-1d9a3b60dca9_9_8"}}  />
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

export default P2PDossier360_Start;
