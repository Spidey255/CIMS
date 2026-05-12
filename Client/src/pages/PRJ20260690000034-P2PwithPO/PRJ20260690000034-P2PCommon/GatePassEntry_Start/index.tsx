// Innovace Intech Solution Pvt Ltd

import { useEffect, useMemo } from "react";
import { useSearchParams } from "react-router-dom";
import { usePageStore } from "@/store/usePageStore";
import { DataElementsData } from "./GatePassEntry_Start";
import Store from "@/components/Store";



// Dynamically imported components
import Column from "@/components/UI_Controls/Column.tsx";
import PageHeader from "@/components/UI_Controls/PageHeader.tsx";


const GatePassEntry_Start = ({
  ProcessName = "GatePassEntry",
  PackageProcessMapId = "576c1d6f-0c90-4eda-9b5e-2f7cd819c778",
  FormVersionId = "2167FC44-1C44-448B-A226-92240EB6E36C",
  ProcessActivityMapId = "D8F8D850-67BD-45B4-9FCA-27F1E1045021"
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
      
      <Column key="5ef2c804-acc1-d292-a8d7-d02088f1580d_1_0" element={{"VersionName":"Medium","Id":1,"WidgetId":"9B6A2DAF-D2B3-44F8-9EF3-67BE6F93D8E9","uielementid":"5ef2c804-acc1-d292-a8d7-d02088f1580d","WidgetName":"GatePassEntry_Root_Start.Json","ShowCaption":false,"Fontbold":false,"FontItalic":false,"FontOverline":false,"FontStrikeout":false,"FontUnderline":false,"Depth":1,"IsBadge":false,"ElementId":"","UIElementid":"5ef2c804-acc1-d292-a8d7-d02088f1580d","Sequence":1,"ElementName":"UI_MainContainer","ControlType":"Column","uielementtypeid":5,"Wrap":12,"EnableDFS":false,"ClearFix":false,"OnDemandLoad":false,"IsLastStep":false,"EnableValidation":false,"Buttons":false,"Legend":false,"NavigationNumbers":false,"ControlId":18,"Searchable":false,"Bindable":false,"Action":"FormOnLoad","IsSaveWidget":0,"BindingDetail":"[{\"Endpoint\":\"~\\/iProofServicesHub\\/ExecuteFormLoad\",\"HttpVerb\":\"Post\",\"Port\":\"5009\",\"Params\":[{\"ElementName\":\"MF_d2_DocId\",\"Value\":null,\"EDT\":1},{\"ElementName\":\"MF_d1_InvoiceId\",\"Value\":\"\",\"EDT\":9},{\"ElementName\":\"MF_d4_InvoiceId\",\"Value\":\"\",\"EDT\":9},{\"ElementName\":\"MF_d1_DocId\",\"Value\":null,\"EDT\":1},{\"ElementName\":\"MG_d3_DocumentName\",\"Value\":\"\",\"EDT\":9},{\"ElementName\":\"MG_d3_invoicedocument\",\"Value\":null,\"EDT\":1}]}]","DCaption":"","__idx":0,"_id":"5ef2c804-acc1-d292-a8d7-d02088f1580d_1_0"}}  >
        <PageHeader key="ae2cbc59-a9db-c77b-46a1-adfef5d7ab3c_2_1" element={{"VersionName":"Medium","Id":2,"uielementid":"ae2cbc59-a9db-c77b-46a1-adfef5d7ab3c","ShowCaption":true,"Fontbold":false,"FontItalic":false,"FontOverline":false,"FontStrikeout":false,"FontUnderline":false,"Depth":2,"Css":"page-header page-header-light shadow mb-3","IsBadge":false,"ElementId":"","UIElementid":"ae2cbc59-a9db-c77b-46a1-adfef5d7ab3c","Sequence":1,"ElementName":"UI_Medium Header","ParentElementId":"5ef2c804-acc1-d292-a8d7-d02088f1580d","ControlType":"Page Header","uielementtypeid":21,"Wrap":12,"EnableDFS":false,"ClearFix":false,"OnDemandLoad":false,"IsLastStep":false,"EnableValidation":false,"Buttons":false,"Legend":false,"NavigationNumbers":false,"ControlId":30,"Searchable":false,"Bindable":false,"IsSaveWidget":0,"BindingDetail":"","__idx":1,"_id":"ae2cbc59-a9db-c77b-46a1-adfef5d7ab3c_2_1"}}  />
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

export default GatePassEntry_Start;
