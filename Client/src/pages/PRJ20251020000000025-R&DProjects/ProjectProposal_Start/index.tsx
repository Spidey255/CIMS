// Innovace Intech Solution Pvt Ltd

import { useEffect, useMemo } from "react";
import { useSearchParams } from "react-router-dom";
import { usePageStore } from "@/store/usePageStore";
import { DataElementsData } from "./ProjectProposal_Start";
import Store from "@/components/Store";



// Dynamically imported components
import Column from "@/components/UI_Controls/Column.tsx";
import Div from "@/components/UI_Controls/Div.tsx";
import PageHeader from "@/components/UI_Controls/PageHeader.tsx";
import Row from "@/components/UI_Controls/Row.tsx";
import Panel from "@/components/UI_Controls/Panel.tsx";
import PanelBody from "@/components/UI_Controls/PanelBody.tsx";
import TextBox from "@/components/Data_Controls/TextBox";
import NumericTextBox from "@/components/Data_Controls/NumericTextBox";


const ProjectProposal_Start = ({
  ProcessName = "ProjectProposal",
  PackageProcessMapId = "026e321e-9bb7-4c74-8615-3bbd7cc1b241",
  FormVersionId = "FA963D46-2D52-4A3E-8550-E878A2504252",
  ProcessActivityMapId = "B3A49337-4C4B-42EC-9F9B-1C4C8B4E2E13"
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
      
      <Column key="349381ae-7c2c-17f4-6aba-54c5138548e4_1_0" element={{"VersionName":"Medium","Id":1,"WidgetId":"E0AC6667-6D92-49AA-8F4D-01F473F2E426","uielementid":"349381ae-7c2c-17f4-6aba-54c5138548e4","WidgetName":"ProjectProposal_Root_Start.Json","ShowCaption":false,"Fontbold":false,"FontItalic":false,"FontOverline":false,"FontStrikeout":false,"FontUnderline":false,"Depth":1,"IsBadge":false,"ElementId":"","UIElementid":"349381ae-7c2c-17f4-6aba-54c5138548e4","Sequence":1,"ElementName":"UI_MainContainer","ControlType":"Column","uielementtypeid":5,"Wrap":12,"EnableDFS":false,"ClearFix":false,"OnDemandLoad":false,"IsLastStep":false,"EnableValidation":false,"Buttons":false,"Legend":false,"NavigationNumbers":false,"ControlId":18,"Searchable":false,"Bindable":false,"Action":"FormOnLoad","IsSaveWidget":0,"BindingDetail":"[{\"Endpoint\":\"~\\/iProofServicesHub\\/ExecuteFormLoad\",\"HttpVerb\":\"Post\",\"Port\":\"5009\",\"Params\":[{\"ElementName\":\"MF_d1_FinancialYearID\",\"Value\":null,\"EDT\":5},{\"ElementName\":\"MG_d2_ExternalDesignation\",\"Value\":\"\",\"EDT\":9},{\"ElementName\":\"RequiredDocuments_RowId\",\"Value\":\"\",\"EDT\":9},{\"ElementName\":\"MF_d1_IsSubmitted\",\"Value\":null,\"EDT\":5},{\"ElementName\":\"MG_d2_AdditionalType\",\"Value\":null,\"EDT\":5},{\"ElementName\":\"MF_d1_UpdatedBy\",\"Value\":null,\"EDT\":5},{\"ElementName\":\"MG_d4_Document\",\"Value\":null,\"EDT\":5},{\"ElementName\":\"MG_d4_UpdatedOn\",\"Value\":\"\",\"EDT\":8},{\"ElementName\":\"MG_d3_UploadDocument\",\"Value\":null,\"EDT\":5},{\"ElementName\":\"MG_d2_ExternalContactNo\",\"Value\":\"\",\"EDT\":9},{\"ElementName\":\"MF_d1_ProjectType\",\"Value\":\"\",\"EDT\":9},{\"ElementName\":\"MF_d1_Remarks\",\"Value\":\"\",\"EDT\":9},{\"ElementName\":\"MF_d1_ProposalCode\",\"Value\":\"\",\"EDT\":9},{\"ElementName\":\"MF_d1_Designation\",\"Value\":\"\",\"EDT\":9},{\"ElementName\":\"MF_d1_ProjectProposalID\",\"Value\":\"\",\"EDT\":9},{\"ElementName\":\"MG_d3_UpdatedOn\",\"Value\":\"\",\"EDT\":8},{\"ElementName\":\"MG_d2_UpdatedBy\",\"Value\":null,\"EDT\":5},{\"ElementName\":\"MG_d2_DesignationID\",\"Value\":\"\",\"EDT\":9},{\"ElementName\":\"MF_d1_ProjectCategoryID\",\"Value\":null,\"EDT\":5},{\"ElementName\":\"MG_d2_UpdatedOn\",\"Value\":\"\",\"EDT\":8},{\"ElementName\":\"MF_d1_ProjectBudget\",\"Value\":null,\"EDT\":3},{\"ElementName\":\"MF_d1_UpdatedOn\",\"Value\":\"\",\"EDT\":8},{\"ElementName\":\"MG_d2_AdditionalName\",\"Value\":\"\",\"EDT\":9},{\"ElementName\":\"MG_d3_DocumentProposalID\",\"Value\":\"\",\"EDT\":9},{\"ElementName\":\"MG_d4_DocumentName\",\"Value\":\"\",\"EDT\":9},{\"ElementName\":\"MF_d1_EndorsementFileType\",\"Value\":null,\"EDT\":5},{\"ElementName\":\"MG_d2_ProjectDetailsID\",\"Value\":\"\",\"EDT\":9},{\"ElementName\":\"MF_d1_ProjectStatus\",\"Value\":\"\",\"EDT\":9},{\"ElementName\":\"MF_d1_OverHead\",\"Value\":null,\"EDT\":5},{\"ElementName\":\"MG_d2_ExternalInstituteName\",\"Value\":\"\",\"EDT\":9},{\"ElementName\":\"MF_d1_PrincipalInvestigator\",\"Value\":\"\",\"EDT\":9},{\"ElementName\":\"ProposalDocuments_RowId\",\"Value\":\"\",\"EDT\":9},{\"ElementName\":\"MG_d3_UpdatedBy\",\"Value\":null,\"EDT\":5},{\"ElementName\":\"CopiDetails_RowId\",\"Value\":\"\",\"EDT\":9},{\"ElementName\":\"MG_d4_ProjectproposalID\",\"Value\":\"\",\"EDT\":9},{\"ElementName\":\"MG_d3_MandatoryCheck\",\"Value\":null,\"EDT\":5},{\"ElementName\":\"MG_d2_Departmentid\",\"Value\":\"\",\"EDT\":9},{\"ElementName\":\"MF_d1_EmployeeBasicInfoId\",\"Value\":\"\",\"EDT\":9},{\"ElementName\":\"MF_d1_ProjectRefNo\",\"Value\":\"\",\"EDT\":9},{\"ElementName\":\"MG_d2_ExternalFacultyName\",\"Value\":\"\",\"EDT\":9},{\"ElementName\":\"MG_d4_DocumentId\",\"Value\":\"\",\"EDT\":9},{\"ElementName\":\"MF_d1_IfExternalInstitute\",\"Value\":\"\",\"EDT\":0},{\"ElementName\":\"MG_d2_ExternalEmailId\",\"Value\":\"\",\"EDT\":9},{\"ElementName\":\"MF_d1_DepartmentID\",\"Value\":\"\",\"EDT\":9},{\"ElementName\":\"MG_d4_UpdatedBy\",\"Value\":null,\"EDT\":5},{\"ElementName\":\"MF_d1_FundingAgency\",\"Value\":null,\"EDT\":5},{\"ElementName\":\"MG_d3_ProposalDocumentID\",\"Value\":\"\",\"EDT\":9},{\"ElementName\":\"MG_d4_Categorymapid\",\"Value\":\"\",\"EDT\":9},{\"ElementName\":\"MG_d2_AdditionalID\",\"Value\":\"\",\"EDT\":9},{\"ElementName\":\"MG_d3_ProjectproposalID\",\"Value\":\"\",\"EDT\":9},{\"ElementName\":\"MF_d1_SectorID\",\"Value\":null,\"EDT\":5},{\"ElementName\":\"MG_d3_DocumentName\",\"Value\":\"\",\"EDT\":9},{\"ElementName\":\"MF_d1_ProjectName\",\"Value\":\"\",\"EDT\":9}]}]","DCaption":"","__idx":0,"_id":"349381ae-7c2c-17f4-6aba-54c5138548e4_1_0"}}  >
        <Div key="ec790691-6224-8eb7-77a7-ee916d0db152_2_1" element={{"VersionName":"Medium","Id":2,"uielementid":"ec790691-6224-8eb7-77a7-ee916d0db152","ShowCaption":true,"Fontbold":false,"FontItalic":false,"FontOverline":false,"FontStrikeout":false,"FontUnderline":false,"Depth":2,"Css":"content grid_view hlCmpt","IsBadge":false,"ElementId":"","UIElementid":"ec790691-6224-8eb7-77a7-ee916d0db152","Sequence":1,"ElementName":"UI_Div","ParentElementId":"349381ae-7c2c-17f4-6aba-54c5138548e4","ControlType":"Div","uielementtypeid":44,"Wrap":12,"EnableDFS":false,"ClearFix":false,"OnDemandLoad":false,"IsLastStep":false,"EnableValidation":false,"Buttons":false,"Legend":false,"NavigationNumbers":false,"ControlId":51,"Searchable":false,"Bindable":false,"IsSaveWidget":0,"BindingDetail":"","__idx":1,"_id":"ec790691-6224-8eb7-77a7-ee916d0db152_2_1"}}  >
          <PageHeader key="feb1ad53-da55-5368-2eb1-e0903958b5b4_3_2" element={{"VersionName":"Medium","Id":3,"uielementid":"feb1ad53-da55-5368-2eb1-e0903958b5b4","ShowCaption":true,"Fontbold":false,"FontItalic":false,"FontOverline":false,"FontStrikeout":false,"FontUnderline":false,"Depth":3,"Css":"page-header page-header-light shadow mb-3","IsBadge":false,"ElementId":"","UIElementid":"feb1ad53-da55-5368-2eb1-e0903958b5b4","Sequence":1,"ElementName":"UI_Page Header","ParentElementId":"ec790691-6224-8eb7-77a7-ee916d0db152","ControlType":"Page Header","uielementtypeid":21,"Wrap":12,"EnableDFS":false,"ClearFix":false,"OnDemandLoad":false,"IsLastStep":false,"EnableValidation":false,"Buttons":false,"Legend":false,"NavigationNumbers":false,"ControlId":30,"Searchable":false,"Bindable":false,"IsSaveWidget":0,"BindingDetail":"","__idx":2,"_id":"feb1ad53-da55-5368-2eb1-e0903958b5b4_3_2"}}  />
          <Row key="aaf5d927-7cdd-157a-fa0b-11bc89bca71c_4_3" element={{"VersionName":"Medium","Id":4,"uielementid":"aaf5d927-7cdd-157a-fa0b-11bc89bca71c","ShowCaption":true,"Fontbold":false,"FontItalic":false,"FontOverline":false,"FontStrikeout":false,"FontUnderline":false,"Depth":3,"Css":"row grid_view","IsBadge":false,"ElementId":"","UIElementid":"aaf5d927-7cdd-157a-fa0b-11bc89bca71c","Sequence":2,"ElementName":"UI_Row","ParentElementId":"ec790691-6224-8eb7-77a7-ee916d0db152","ControlType":"Row","uielementtypeid":11,"Wrap":12,"EnableDFS":false,"ClearFix":false,"OnDemandLoad":false,"IsLastStep":false,"EnableValidation":false,"Buttons":false,"Legend":false,"NavigationNumbers":false,"ControlId":23,"Searchable":false,"Bindable":false,"IsSaveWidget":0,"BindingDetail":"","__idx":3,"_id":"aaf5d927-7cdd-157a-fa0b-11bc89bca71c_4_3"}}  >
            <Column key="89bcc003-50d7-c472-7fe6-13243216583c_5_4" element={{"VersionName":"Medium","Id":5,"uielementid":"89bcc003-50d7-c472-7fe6-13243216583c","ShowCaption":true,"Fontbold":false,"FontItalic":false,"FontOverline":false,"FontStrikeout":false,"FontUnderline":false,"Depth":4,"Css":"grid_view  hlCmpt","IsBadge":false,"ElementId":"","UIElementid":"89bcc003-50d7-c472-7fe6-13243216583c","Sequence":1,"ElementName":"UI_Column","ParentElementId":"aaf5d927-7cdd-157a-fa0b-11bc89bca71c","ControlType":"Column","uielementtypeid":5,"Wrap":12,"EnableDFS":false,"ClearFix":false,"OnDemandLoad":false,"IsLastStep":false,"EnableValidation":false,"Buttons":false,"Legend":false,"NavigationNumbers":false,"ControlId":18,"Searchable":false,"Bindable":false,"IsSaveWidget":0,"BindingDetail":"","__idx":4,"_id":"89bcc003-50d7-c472-7fe6-13243216583c_5_4"}}  >
              <Panel key="6d54809e-d8d6-2b94-4b05-4adb7b3e4f40_6_5" element={{"VersionName":"Medium","Id":6,"uielementid":"6d54809e-d8d6-2b94-4b05-4adb7b3e4f40","ShowCaption":true,"Fontbold":false,"FontItalic":false,"FontOverline":false,"FontStrikeout":false,"FontUnderline":false,"Depth":5,"Css":"card grid_view","IsBadge":false,"ElementId":"","UIElementid":"6d54809e-d8d6-2b94-4b05-4adb7b3e4f40","Sequence":1,"ElementName":"UI_Panel","ParentElementId":"89bcc003-50d7-c472-7fe6-13243216583c","ControlType":"Panel","uielementtypeid":1,"Wrap":12,"EnableDFS":false,"ClearFix":false,"OnDemandLoad":false,"IsLastStep":false,"EnableValidation":false,"Buttons":false,"Legend":false,"NavigationNumbers":false,"ControlId":15,"Searchable":false,"Bindable":false,"IsSaveWidget":0,"BindingDetail":"","__idx":5,"_id":"6d54809e-d8d6-2b94-4b05-4adb7b3e4f40_6_5"}}  >
                <PanelBody key="559f0cd7-13fe-4883-e521-01817f4ec0b6_7_6" element={{"VersionName":"Medium","Id":7,"uielementid":"559f0cd7-13fe-4883-e521-01817f4ec0b6","ShowCaption":true,"Fontbold":false,"FontItalic":false,"FontOverline":false,"FontStrikeout":false,"FontUnderline":false,"Depth":6,"Css":"card-body","IsBadge":false,"ElementId":"","UIElementid":"559f0cd7-13fe-4883-e521-01817f4ec0b6","Sequence":1,"ElementName":"UI_Panel Body","ParentElementId":"6d54809e-d8d6-2b94-4b05-4adb7b3e4f40","ControlType":"Panel Body","uielementtypeid":28,"Wrap":12,"EnableDFS":false,"ClearFix":false,"OnDemandLoad":false,"IsLastStep":false,"EnableValidation":false,"Buttons":false,"Legend":false,"NavigationNumbers":false,"ControlId":35,"Searchable":false,"Bindable":false,"IsSaveWidget":0,"BindingDetail":"","__idx":6,"_id":"559f0cd7-13fe-4883-e521-01817f4ec0b6_7_6"}}  >
                  <Row key="538a471e-1251-2faa-c529-43b56cf7ac97_8_7" element={{"VersionName":"Medium","Id":8,"uielementid":"538a471e-1251-2faa-c529-43b56cf7ac97","ShowCaption":true,"Fontbold":false,"FontItalic":false,"FontOverline":false,"FontStrikeout":false,"FontUnderline":false,"Depth":7,"IsBadge":false,"ElementId":"","UIElementid":"538a471e-1251-2faa-c529-43b56cf7ac97","Sequence":1,"ElementName":"UI_Row","ParentElementId":"559f0cd7-13fe-4883-e521-01817f4ec0b6","ControlType":"Row","uielementtypeid":11,"Wrap":12,"EnableDFS":false,"ClearFix":false,"OnDemandLoad":false,"IsLastStep":false,"EnableValidation":false,"Buttons":false,"Legend":false,"NavigationNumbers":false,"ControlId":23,"Searchable":false,"Bindable":false,"IsSaveWidget":0,"BindingDetail":"","__idx":7,"_id":"538a471e-1251-2faa-c529-43b56cf7ac97_8_7"}}  >
                    <TextBox key="538a471e-1251-2faa-c529-43b56cf7ac97_9_8" element={{"VersionName":"Medium","Id":9,"uielementid":"538a471e-1251-2faa-c529-43b56cf7ac97","ShowCaption":true,"Fontbold":false,"FontItalic":false,"FontOverline":false,"FontStrikeout":false,"FontUnderline":false,"Depth":8,"ElementId":"D92326E8-1A88-45B0-B877-8C4DA80F7378","UIElementid":"538a471e-1251-2faa-c529-43b56cf7ac97","Sequence":1,"ElementName":"MF_d1_ProjectProposalID","ParentElementId":"E0AC6667-6D92-49AA-8F4D-01F473F2E426","ControlType":"TextBox","Wrap":4,"IsMultiline":false,"ClearFix":false,"RenderType":1,"OnDemandLoad":false,"ControlId":1,"DisplayName":"MF_d1_ProjectProposalID","Searchable":false,"Bindable":false,"HeaderTemplate":"","MergeRow":"","IsSaveWidget":0,"BindingDetail":"","EDT":9,"DCaption":"ProjectProposalID","DHelpText":"","DToolTip":"","__idx":8,"_id":"538a471e-1251-2faa-c529-43b56cf7ac97_9_8"}}  />
                    <NumericTextBox key="538a471e-1251-2faa-c529-43b56cf7ac97_10_9" element={{"VersionName":"Medium","Id":10,"uielementid":"538a471e-1251-2faa-c529-43b56cf7ac97","ShowCaption":true,"Fontbold":false,"FontItalic":false,"FontOverline":false,"FontStrikeout":false,"FontUnderline":false,"Depth":8,"ElementId":"4295EDEA-9713-4E74-87D5-FBD75A36B73A","UIElementid":"538a471e-1251-2faa-c529-43b56cf7ac97","Sequence":2,"ElementName":"MF_d1_ProjectCategoryID","ParentElementId":"E0AC6667-6D92-49AA-8F4D-01F473F2E426","ControlType":"NumericTextBox","Wrap":4,"ClearFix":false,"RenderType":15,"OnDemandLoad":false,"ControlId":2,"DisplayName":"MF_d1_ProjectCategoryID","Searchable":false,"Bindable":false,"HeaderTemplate":"","MergeRow":"","IsSaveWidget":0,"BindingDetail":"","EDT":5,"DCaption":"ProjectCategoryID","DHelpText":"","DToolTip":"","__idx":9,"_id":"538a471e-1251-2faa-c529-43b56cf7ac97_10_9"}}  />
                  </Row>
                </PanelBody>
              </Panel>
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

export default ProjectProposal_Start;
