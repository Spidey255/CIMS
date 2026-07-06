  







namespace CPS.Proof.DFSExtension
{
	using System;
    using System.Collections.Generic;     
	using System.Linq;
	
	
	public partial class TravelSettlementNewProcessMetadata : ExtensionProcessBase
	{		

        public override long PackageId
        {
            get { return 30303; }
        }

        public override string PackageName
        {
            get { return "PRJ20251020000000025-R&D Projects"; }
        }

		public override string PackageDescription
        {
            get { return "The Research & Consultancy (R&C) Projects Module is designed to manage the complete lifecycle of institutional research and consultancy projects, from proposal submission to project closure. It enables faculty, research scholars, and departments to create, submit, and track project proposals, budgets, approvals, funding sources, and progress reports within a structured digital workflow. The module supports collaboration across departments, monitors financial utilization against sanctioned budgets, and ensures compliance with institutional and external funding guidelines."; }
        }

        public override string ProcessId
        {
            get { return "d4b10079-b7a6-40d1-94ec-eb886005f33a"; }
        }

        public override string ProcessName
        {
            get { return "TravelSettlementNew"; }
        }

		public override string ProcessDescription
        {
            get { return "Travel Settlement New"; }
        }

        public override ProcessType ProcessType
        {
            get { return ProcessType.RuleBased; }
        }

      

		public override string FileGroupId
        {
            get { return "C8BA2E2C-CB74-4616-9139-B32125B1C0A1"; }
        } 

		public override string FileGroup
        {
            get { return "Default"; }
        } 
		
        public override string PackageProcessMapId
        {
            get {return "d4b10079-b7a6-40d1-94ec-eb886005f33a";}
        }

		public override byte ProcessInstanceMode
        {
            get {return 3;}
        }		

		public override string MasterFormId
        {
            get {  
				   return "8EC3FC2B-F5B6-4077-8C73-B83F5D859FC4";	}
        }
			
        public override string Comments => throw new NotImplementedException();
		
		
	}
}
 





namespace CPS.Proof.DFSExtension
{
	using System;
	using System.Collections.Concurrent;
    using System.Collections.Generic;    	
	using CPS.Proof.DFSExtension;
	

	public partial class TravelSettlementNewObjectFactory  : ExtObjectFactoryBase
    {		
       	
		
		
	
		public override Dictionary<string, string> GetQueryExpressionDataSource(string expressionId)
		{
			if(string.IsNullOrWhiteSpace(expressionId))
            {
			 return null;
			}

			Dictionary<string, string> data;

            data = new Dictionary<string, string>();
            foreach (Triplet<string, string, string> exp in queryExpressionData)
            {
                if (exp.FirstValue == expressionId)
                {
                    var unknown = new
                    {
                        name = exp.SecondValue, constring = exp.ThirdValue
                    };
                    data.Add(unknown.name, unknown.constring);
                }
            }

			return data;

		}

		//public override IExtBaseMetaData GetProcessInstance(string packageProcessMapId)
       // {
        //    return (IExtBaseMetaData)new TravelSettlementNewProcessMetadata();
        //}
	


		private List<Triplet<string, string, string>> queryExpressionData = new List<Triplet<string, string, string>>
		{
	  			
			     new Triplet<string, string, string>("632D2764-BF87-49D0-8258-386D3AF9081A","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("3BE59B80-4D73-4B38-95BC-19A4B6DABBE8","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("9E8F1576-9AC1-45E1-A0AC-D79DD7D684BC","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("BF7DF060-B806-48CD-84DA-4602D42A2BCE","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("18A56ACF-6583-427B-A2E8-7FC0D063DF59","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("8F645A2C-5DD3-46B3-8E42-9A195AF59EF4","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("DDFA0B40-26ED-46C9-A4C1-A8ECC2CAAA49","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("BBB0DE05-81D3-467B-B16F-B045502F9D29","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("1ECA577C-1B99-4640-9E48-93B3CA7B355F","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"24F5D845-D560-4FC1-B284-00FB19DFB96F"),
			
						
			     new Triplet<string, string, string>("9DE0ADA2-B501-4551-A0BE-56A4D7F08F5F","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("E66769EA-D7F2-4E8E-AEE5-A3238B58DB25","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"24F5D845-D560-4FC1-B284-00FB19DFB96F"),
			
						
			     new Triplet<string, string, string>("435CD4B5-CC1D-46F0-9646-DC152C46DC8B","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"24F5D845-D560-4FC1-B284-00FB19DFB96F"),
			
						
			     new Triplet<string, string, string>("C19B89A6-EE8E-4242-8B3C-B80EB38918A3","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"24F5D845-D560-4FC1-B284-00FB19DFB96F"),
			
						
			     new Triplet<string, string, string>("DA439285-F85F-4AA6-815E-CCAD8ADBC5EB","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("9B9A263E-C6A3-4D51-B6C8-18D8E59AC1BF","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("A12A0256-E91B-49BC-B475-C85CE71A07B6","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("AF669D29-F63D-48B3-97FF-02224E901479","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"24F5D845-D560-4FC1-B284-00FB19DFB96F"),
			
						
			     new Triplet<string, string, string>("EA415B1C-D6D7-4FD7-9BB9-2DB5E0B45A53","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"24F5D845-D560-4FC1-B284-00FB19DFB96F"),
			
						
			     new Triplet<string, string, string>("A28413FF-40F7-411E-B510-D6B851A56F92","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"24F5D845-D560-4FC1-B284-00FB19DFB96F"),
			
						
			     new Triplet<string, string, string>("9057B26B-5880-4FC0-B20E-1099AFBF96BA","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"24F5D845-D560-4FC1-B284-00FB19DFB96F"),
			
						
			     new Triplet<string, string, string>("18A56ACF-6583-427B-A2E8-7FC0D063DF59","Load Commitments",
												     @"4435EA72-034D-4A84-8791-1F4DC99EADC1"),
			
						
			     new Triplet<string, string, string>("BBB0DE05-81D3-467B-B16F-B045502F9D29","Load Fund Details",
												     @"57484F68-026D-4FF5-A5E1-E4E0BDDD76E0"),
			
						
			     new Triplet<string, string, string>("435CD4B5-CC1D-46F0-9646-DC152C46DC8B","Load Comments",
												     @"EF8F97B1-41F1-43F5-91EF-FE1E3EBBE2AC"),
			
						
			     new Triplet<string, string, string>("DA439285-F85F-4AA6-815E-CCAD8ADBC5EB","Load Grid By IdActualExpenseDetails",
												     @"7DC7A3E8-9FDF-4C75-9F83-FEC89BA524E4"),
			
						
			     new Triplet<string, string, string>("9B9A263E-C6A3-4D51-B6C8-18D8E59AC1BF","Load Grid By IdActualAdvanceDetails",
												     @"CDCED39A-D76C-4204-9A70-C637DD092E54"),
			
						
			     new Triplet<string, string, string>("AF669D29-F63D-48B3-97FF-02224E901479","Grid BindingF",
												     @"7DC7A3E8-9FDF-4C75-9F83-FEC89BA524E4"),
			
						
			     new Triplet<string, string, string>("EA415B1C-D6D7-4FD7-9BB9-2DB5E0B45A53","Grid Binding9",
												     @"7DC7A3E8-9FDF-4C75-9F83-FEC89BA524E4"),
			
						
			     new Triplet<string, string, string>("A28413FF-40F7-411E-B510-D6B851A56F92","Grid Binding9",
												     @"CDCED39A-D76C-4204-9A70-C637DD092E54"),
			
						
			     new Triplet<string, string, string>("9057B26B-5880-4FC0-B20E-1099AFBF96BA","Grid Binding6",
												     @"CDCED39A-D76C-4204-9A70-C637DD092E54"),
			
			
			
		};

		
		private List<Triplet<string, string, string>> ComboDataSource = new List<Triplet<string, string, string>>
		{

		
	  			
			     new Triplet<string, string, string>("FWFM_BudgetHead","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMA18yFT7KruzVDa0TqsqpOM+grujzoqor1KqRIderPPsozBAr7TiIaPx7MYO2zQclV",
												     @"Exec SP_GetDistrubitionDetails 5,'@PFMF_PackageProcessMapId','@FWFM_FundType','','','','','@FWFM_ProjectNo'"),
			
						
			     new Triplet<string, string, string>("FWFM_FundType","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMA18yFT7KruzVDa0TqsqpOM+grujzoqor1KqRIderPPsozBAr7TiIaPx7MYO2zQclV",
												     @"exec SP_GetDistrubitionDetails 4,'@PFMF_PackageProcessMapId','',''"),
			
						
			     new Triplet<string, string, string>("FWFM_ProjectNo","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMAqCwOWy+D7Ogje1I4jfjiAZNrjEazgaNyfBj9pr2u90lOsHzRNfKnSybWqRxrZGqV",
												     @"EXEC GetProjectExtensionDetails 1,'@PFMF_UserId'"),
			
						
			     new Triplet<string, string, string>("WMF_MoveTo","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMAX4svK5cDYCPw2sEhYNSLVUgHvT8EwteQ6Cu6POiqivUqpEh16s8+yjMECvtOIho/Hsxg7bNByVU=",
												     @"EXEC GetNextStep '@WMF_InstanceId','@WMF_FlowType'"),
			
						
			     new Triplet<string, string, string>("FWAB_ProjectNo","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMAqCwOWy+D7Ogje1I4jfjiAZNrjEazgaNyfBj9pr2u90lOsHzRNfKnSybWqRxrZGqV",
												     @"EXEC GetProjectExtensionDetails 1,'@PFMF_UserId'"),
			
						
		};
		
		public override Tuple<string, string> GetComboDataSource(string ElementName)
		{
			foreach (Triplet<string, string, string> cmbDS in ComboDataSource)
            {
				if(cmbDS.FirstValue==ElementName)
				{
					return new Tuple<string,string>(
							cmbDS.SecondValue,
							cmbDS.ThirdValue
						);
				}
			}
			return null;
		}

	
		private List<Tuple<string, int>> GridRowsPerPage = new List<Tuple< string, int>>
		{
		
	  			
			     new Tuple<string, int>("ActualAdvanceDetails",5),
			
						
			     new Tuple<string, int>("ActualExpenseDetails",5),
			
						
			     new Tuple<string, int>("TRMG_TravelDetails",5),
			
						
			     new Tuple<string, int>("TRMG_Expenses",5),
			
						
			     new Tuple<string, int>("TRMG_FundDetails",5),
			
						
			     new Tuple<string, int>("MG_AvailableBudget",5),
			
						
			     new Tuple<string, int>("MG_RequiredDocuments",5),
			
						
			     new Tuple<string, int>("MG_FundAllocation",5),
			
						
			     new Tuple<string, int>("WMG_CommentsHistory",100),
			
						
		};

	   public override int GetGridRPP(string ElementName)
		{
			foreach (Tuple<string, int> grids in GridRowsPerPage)
            {
				if(grids.Item1==ElementName)
				{
					return Convert.ToInt32(grids.Item2);
				}
			}
			return 5;
		}



		public override IVirtualPage GetDfsVirtualInstance(string processActivityMapId)   
		{
			IVirtualPage virtualInstnace = GetVirtualInstnace(processActivityMapId);				

			return virtualInstnace;
		} 

	


		private IVirtualPage GetVirtualInstnace(string processActivityMapId)
		{
				

			
			
			IVirtualPage virtualInstance = null;
			

			switch(processActivityMapId)	
				{
											case "AF9613E1-08AC-4C90-B5AD-8A0678BD0D92":
							virtualInstance=new ISpaceAF9613E108AC4C90B5AD8A0678BD0D92();
							break;
					
					
					default:
						break;
				}
			
			
						

			return virtualInstance;	
		}

		 public override ForkedProcess GetForkProcessSettings(string forkId)
        {
            ForkedProcess forkedProcess=null;

			

			switch(forkId)	
			{
			
			
				default:
						break;
			}


            return forkedProcess;
        }

	}
}	
  











namespace CPS.Proof.DFSExtension
{
	using System;	
    using System.Collections.Generic;      		
	using System.Transactions;
    using log4net;
    using Newtonsoft.Json.Linq;
	

	public partial class TravelSettlementNewDataElementFactory  : ExtElementBase
    {

     /// <summary>
        /// A <see cref="log4net.ILog"/> that contains the logger instance for 
        /// logging
        /// </summary>
        private readonly ILog _sysLog;

        public TravelSettlementNewDataElementFactory()
        {
            _sysLog = LogManager.GetLogger(GetType());
        }			

		

          public override string GetInsertFormDataQuery(string instanceId, string packageProcessMapId, string processActivityMapId,
          string formId, long usermapid, string formJsonData)
        {
            _sysLog.Debug("Entering  GetInsertFormDataQuery");

            try
            {


                string colValues = string.Empty;

                string UpdatecolValues = string.Empty;

                string[] splitcols = null;

                string colList = string.Empty;

                string fInsertQuery = string.Empty;            

                switch(formId)
                {

               
                
                                      case "8EC3FC2B-F5B6-4077-8C73-B83F5D859FC4":
                    {
                     
                                     fInsertQuery=@"IF NOT EXISTS(SELECT 1 FROM [8EC3FC2B-F5B6-4077-8C73-B83F5D859FC4] WHERE InstanceId='{0}') BEGIN INSERT INTO [8EC3FC2B-F5B6-4077-8C73-B83F5D859FC4](ProcessActivityMapId,FormId,AssignToRole,AssignToUser,IN_Priority,IN_InstanceName,IN_SLA,IN_Status,IN_Category,ExecuteCommand,RedirectUrl,Thumbnail,CancelRedirectUrl,KeyContext,DisplayContext,growid,MF_d1_AdvanceAmount,MF_d1_TravelStatus,MF_d1_TSAmount,MF_d1_TSStatus,MF_d1_PITransactionNo,MF_d1_PITransactionDate,MF_d1_TSTransactionNo,MF_d1_TSTransactionDate,MF_d1_CreatedBy,MF_d1_CreatedOn,Subject,ExecutionStatus,ExecutionMessage,SetDestinationTo,SLATime,MF_TotalRequested,MF_AdvanceCollected,MF_TransactionNo,MF_TransactionDate,R_ReferenceNo,FWFM_Amount,PFMF_PackageProcessMapId,FWAB_ProjectNo,PFMF_UserId,PFM_ErrId,PFM_ErrMsg,PFM_FundDetailsId,MF_d1_TravelAdvanceID,MF_d1_EmployeeBasicInfoId,MF_d1_ReferenceNo,MF_d1_JourneyPurpose,MF_d1_TravelType,MF_d1_TravelPlace,MF_d1_IsAdvanceRequired,MF_d1_PaymentRemittenceTo,MF_d1_BeneficiaryName,MF_d1_AccountNo,MF_d1_BankName,MF_d1_IFSCCode,MF_d1_BankDocument,MF_d1_TransactionNo,MF_d1_TransactionDate,MF_d1_TotalAmount,UC_EmployeeId,UC_Name,UC_Designation,UC_Department,MF_ActualTravelExpense,MF_ActualOtherExpense,MF_SettlementAmount,UC_EmailID,UC_PhoneNumber,UC_DOB,UC_DOJ,UC_DOR,UC_Paylevel,UC_Grade,FWFM_FundDetailsId,FWFM_FundType,FWFM_ProjectNo,FWFM_BudgetHead,WMF_IsInFlow,WMF_MoveTo,Comments,FlowType,WMF_InstanceId,InstanceId)
							VALUES( {3}) END ELSE BEGIN UPDATE [8EC3FC2B-F5B6-4077-8C73-B83F5D859FC4]SET {4}WHERE InstanceId='{0}'END ";

                                     colList=@"ProcessActivityMapId,FormId,AssignToRole,AssignToUser,IN_Priority,IN_InstanceName,IN_SLA,IN_Status,IN_Category,ExecuteCommand,RedirectUrl,Thumbnail,CancelRedirectUrl,KeyContext,DisplayContext,growid,MF_d1_AdvanceAmount,MF_d1_TravelStatus,MF_d1_TSAmount,MF_d1_TSStatus,MF_d1_PITransactionNo,MF_d1_PITransactionDate,MF_d1_TSTransactionNo,MF_d1_TSTransactionDate,MF_d1_CreatedBy,MF_d1_CreatedOn,Subject,ExecutionStatus,ExecutionMessage,SetDestinationTo,SLATime,MF_TotalRequested,MF_AdvanceCollected,MF_TransactionNo,MF_TransactionDate,R_ReferenceNo,FWFM_Amount,PFMF_PackageProcessMapId,FWAB_ProjectNo,PFMF_UserId,PFM_ErrId,PFM_ErrMsg,PFM_FundDetailsId,MF_d1_TravelAdvanceID,MF_d1_EmployeeBasicInfoId,MF_d1_ReferenceNo,MF_d1_JourneyPurpose,MF_d1_TravelType,MF_d1_TravelPlace,MF_d1_IsAdvanceRequired,MF_d1_PaymentRemittenceTo,MF_d1_BeneficiaryName,MF_d1_AccountNo,MF_d1_BankName,MF_d1_IFSCCode,MF_d1_BankDocument,MF_d1_TransactionNo,MF_d1_TransactionDate,MF_d1_TotalAmount,UC_EmployeeId,UC_Name,UC_Designation,UC_Department,MF_ActualTravelExpense,MF_ActualOtherExpense,MF_SettlementAmount,UC_EmailID,UC_PhoneNumber,UC_DOB,UC_DOJ,UC_DOR,UC_Paylevel,UC_Grade,FWFM_FundDetailsId,FWFM_FundType,FWFM_ProjectNo,FWFM_BudgetHead,WMF_IsInFlow,WMF_MoveTo,Comments,FlowType,WMF_InstanceId,InstanceId";
                                    
                     
                            splitcols = colList.Split(',');

                            if (splitcols.Length <= 0)
                                return null;

                            var parentObject = JObject.Parse(formJsonData);


                            foreach (var fcol in splitcols)
                            {
                                if (fcol == "InstanceId")
                                {
                                    colValues += "'" + instanceId + "',";

                                    continue;

                                }

                                else if (fcol == "ProcessActivityMapId")
                                {
                                    colValues += "'" + processActivityMapId + "',";
                                    continue;
                                }

                                else if (fcol == "FormId")
                                {
                                    colValues += "'" + formId + "',";
                                    continue;
                                }

                                bool isFound = false;

                                foreach(var childObject in (JArray)parentObject["Child"])
                                {

                                    if (childObject["ElementName"].ToString() == fcol)
                                    {
                                        isFound = true;

                                         if (childObject["Value"] == null)
                                        {
                                          
                                            colValues += "null,";
                                            UpdatecolValues += fcol + "=" + "null,";
                                            break;
                                        }

                                        switch (Convert.ToInt32(childObject["EDT"]))
                                        {
                                            case 0:
                                                colValues += (Convert.ToBoolean(childObject["Value"]) ? "1" : "0") + ",";
												break;
                                            case 8:
                                             if (childObject["Value"] != null)
                                                {
                                                    if (childObject["Value"].ToString() == "")
                                                    {
                                                        colValues += "null,";
                                                        UpdatecolValues += fcol + "=" + "null,";
                                                    }
                                                    else
                                                    {
                                                        colValues += "'"+childObject["Value"].ToString() + "',";
                                                        UpdatecolValues += fcol+ "=" + "'" + childObject["Value"].ToString() + "',";
                                                    }
                                                }
                                                else
                                                {
                                                    colValues += "null,";
                                                    UpdatecolValues += fcol + "=" + "null,";
                                                }
                                                break;

                                            case 9:
                                                colValues += "'" + childObject["Value"].ToString() + "',";
                                                UpdatecolValues+=fcol+"="+"'" + childObject["Value"].ToString() + "',";
                                                break;
                                            case 3:
                                                if (childObject["Value"] != null)
                                                {
                                                    if (childObject["Value"].ToString() == "")
                                                    {
                                                        colValues += "null,";
                                                        UpdatecolValues += fcol + "=" + "null,";
                                                    }
                                                    else
                                                    {
                                                        colValues += childObject["Value"].ToString() + ",";
                                                        UpdatecolValues += fcol + "=" + childObject["Value"].ToString() + ",";
                                                    }
                                                }
                                                else
                                                {
                                                    colValues += "null,";
                                                    UpdatecolValues += fcol + "=" + "null,";
                                                }
                                                break;

                                            default:
                                                 if (childObject["Value"] != null)
                                                {
                                                    colValues += "'" + childObject["Value"].ToString() + "',";
                                                    UpdatecolValues += fcol + "=" + "'" + childObject["Value"].ToString() + "',";
                                                }
                                                else
                                                {
                                                    colValues += "null,";
                                                    UpdatecolValues += fcol + "=" + "null,";
                                                }
                                                 break;
                                        }

                                       
                                    }
                                }

                                 if(!isFound)
                                {
                                    colValues += "null,";
                                    UpdatecolValues += fcol + "=" + "null,";
                                }

                            }
                            colValues = colValues.Remove(colValues.Length - 1);
                            UpdatecolValues = UpdatecolValues.Remove(UpdatecolValues.Length - 1);

                            fInsertQuery =  string.Format(fInsertQuery,instanceId,processActivityMapId,formId, colValues,UpdatecolValues);

                            colValues = string.Empty;

                            break;
                        }
                
                       
                               

                 }
                return fInsertQuery;

            }
            catch (Exception ex)
            {
                _sysLog.Error("Error in  GetInsertFormDataQuery", ex);

                return null;
            }
            _sysLog.Debug("Exiting GetInsertFormDataQuery");
        }

           public override string GetInsertGridDataQuery(string instanceId,string packageProcessMapId,string processActivityMapId,
            string gridId,long usermapid,string formJsonData)
      {
        _sysLog.Debug("Entering  InsertGridData");
        
        try
        {                
                  

                     string colValues = string.Empty;

                     string[] splitcols=null;

                     string colList=string.Empty;

                     string gInsertQuery=string.Empty;

                     string tempInsertQuery=string.Empty;

                     string bulkInsertQuery = string.Empty;

                      switch(gridId)
                {

                
                 
                                      case "f4c435ef-658d-ea4b-3047-12782c9508ca":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_f4c435ef658dea4b304712782c9508ca AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [TD_ModeofJourney] VARCHAR(MAX)	, [TD_Departure] VARCHAR(MAX)	, [TD_DepartureDate] DATETIME	, [TD_Arrival] VARCHAR(MAX)	, [TD_ArrivalDate] DATETIME	, [TD_JourneyClass] VARCHAR(MAX)	, [TD_RoadKms] DECIMAL(18,2)	, [TD_Amount] DECIMAL(18,2)){0}INSERT INTO [f4c435ef-658d-ea4b-3047-12782c9508ca](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,TD_ModeofJourney,TD_Departure,TD_DepartureDate,TD_Arrival,TD_ArrivalDate,TD_JourneyClass,TD_RoadKms,TD_Amount)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.TD_ModeofJourney,TDT.TD_Departure,TDT.TD_DepartureDate,TDT.TD_Arrival,TDT.TD_ArrivalDate,TDT.TD_JourneyClass,TDT.TD_RoadKms,TDT.TD_Amount FROM @TBL_f4c435ef658dea4b304712782c9508ca TDT
							LEFT JOIN [f4c435ef-658d-ea4b-3047-12782c9508ca] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,TD_ModeofJourney=TDT.TD_ModeofJourney,TD_Departure=TDT.TD_Departure,TD_DepartureDate=TDT.TD_DepartureDate,TD_Arrival=TDT.TD_Arrival,TD_ArrivalDate=TDT.TD_ArrivalDate,TD_JourneyClass=TDT.TD_JourneyClass,TD_RoadKms=TDT.TD_RoadKms,TD_Amount=TDT.TD_Amount FROM @TBL_f4c435ef658dea4b304712782c9508ca TDT
							JOIN [f4c435ef-658d-ea4b-3047-12782c9508ca] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,TD_ModeofJourney,TD_Departure,TD_DepartureDate,TD_Arrival,TD_ArrivalDate,TD_JourneyClass,TD_RoadKms,TD_Amount";

                                     tempInsertQuery=@"INSERT INTO @TBL_f4c435ef658dea4b304712782c9508ca(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,TD_ModeofJourney,TD_Departure,TD_DepartureDate,TD_Arrival,TD_ArrivalDate,TD_JourneyClass,TD_RoadKms,TD_Amount)VALUES({0});";
                                     

                            splitcols = colList.Split(',');

                            if(splitcols.Length<=0)
                                return null;

                            var parentObject = JObject.Parse(formJsonData)["Child"];

                            for (int i = 0; i < ((JArray)parentObject).Count; i++)
                            {

                            JObject childObject = (JObject)parentObject[i];

                            var gridRow = childObject["Child"];


                        
                            foreach (var gcol in splitcols)
                            {
                                if (gcol == "InstanceId")
                                {
                                    colValues += "'" + instanceId + "',";

                                    continue;

                                }

                                else if (gcol == "ProcessActivityMapId")
                                {
                                    colValues += "'" + processActivityMapId + "',";
                                    continue;
                            }

                            else if (gcol == "GridId")
                            {
                                    colValues += "'" + gridId + "',";
                                continue;
                            }                               
                            else if(gcol=="Sequence")
                            {
                                colValues += childObject["SEQ"]+",";
                                continue;
                            }
                             else if(gcol=="RowId")
                            {
                                colValues +="'" + childObject["RwId"]+"',";
                                continue;
                            }

                            bool isFound = false;

                            foreach (var gitem in gridRow)
                            {                               

                                if (gitem["ElementName"].ToString() == gcol)
                                {
                                    isFound = true;

                                    if (gitem["Value"] == null)
                                    {
                                        colValues += "null,";
                                        break;
                                    }

                                    switch(Convert.ToInt32(gitem["EDT"]))
                                    {
                                        case 0:
                                            colValues += (Convert.ToBoolean(gitem["Value"]) ? "1" : "0") + ",";
												break; 
                                        case 8:
                                        case 9:
                                            colValues +="'"+ gitem["Value"].ToString() + "',";
                                                break;

                                        default:
                                                    if(gitem["Value"].ToString()=="")

                                                        colValues +=  "NULL,";
                                                    else
                                                    colValues += gitem["Value"].ToString() + ",";
                                            break;
                                    }                                    
                                }                                 
                            }

                                    if (!isFound)
                                    {
                                        colValues += "null,";
                                        
                                    }
                            
                        }
                                 colValues=colValues.Remove(colValues.Length - 1);

                                 bulkInsertQuery=bulkInsertQuery+ string.Format(tempInsertQuery, colValues);

                                 colValues=string.Empty;
                        }
                        }
                        break;
                     
                                    case "5cd6b407-a9ef-5a80-b97f-443d95733731":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_5cd6b407a9ef5a80b97f443d95733731 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [ED_ExpentitureType] VARCHAR(MAX)	, [ED_FromDate] DATETIME	, [ED_ToDate] DATETIME	, [ED_Amount] DECIMAL(18,2)){0}INSERT INTO [5cd6b407-a9ef-5a80-b97f-443d95733731](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,ED_ExpentitureType,ED_FromDate,ED_ToDate,ED_Amount)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.ED_ExpentitureType,TDT.ED_FromDate,TDT.ED_ToDate,TDT.ED_Amount FROM @TBL_5cd6b407a9ef5a80b97f443d95733731 TDT
							LEFT JOIN [5cd6b407-a9ef-5a80-b97f-443d95733731] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,ED_ExpentitureType=TDT.ED_ExpentitureType,ED_FromDate=TDT.ED_FromDate,ED_ToDate=TDT.ED_ToDate,ED_Amount=TDT.ED_Amount FROM @TBL_5cd6b407a9ef5a80b97f443d95733731 TDT
							JOIN [5cd6b407-a9ef-5a80-b97f-443d95733731] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,ED_ExpentitureType,ED_FromDate,ED_ToDate,ED_Amount";

                                     tempInsertQuery=@"INSERT INTO @TBL_5cd6b407a9ef5a80b97f443d95733731(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,ED_ExpentitureType,ED_FromDate,ED_ToDate,ED_Amount)VALUES({0});";
                                     

                            splitcols = colList.Split(',');

                            if(splitcols.Length<=0)
                                return null;

                            var parentObject = JObject.Parse(formJsonData)["Child"];

                            for (int i = 0; i < ((JArray)parentObject).Count; i++)
                            {

                            JObject childObject = (JObject)parentObject[i];

                            var gridRow = childObject["Child"];


                        
                            foreach (var gcol in splitcols)
                            {
                                if (gcol == "InstanceId")
                                {
                                    colValues += "'" + instanceId + "',";

                                    continue;

                                }

                                else if (gcol == "ProcessActivityMapId")
                                {
                                    colValues += "'" + processActivityMapId + "',";
                                    continue;
                            }

                            else if (gcol == "GridId")
                            {
                                    colValues += "'" + gridId + "',";
                                continue;
                            }                               
                            else if(gcol=="Sequence")
                            {
                                colValues += childObject["SEQ"]+",";
                                continue;
                            }
                             else if(gcol=="RowId")
                            {
                                colValues +="'" + childObject["RwId"]+"',";
                                continue;
                            }

                            bool isFound = false;

                            foreach (var gitem in gridRow)
                            {                               

                                if (gitem["ElementName"].ToString() == gcol)
                                {
                                    isFound = true;

                                    if (gitem["Value"] == null)
                                    {
                                        colValues += "null,";
                                        break;
                                    }

                                    switch(Convert.ToInt32(gitem["EDT"]))
                                    {
                                        case 0:
                                            colValues += (Convert.ToBoolean(gitem["Value"]) ? "1" : "0") + ",";
												break; 
                                        case 8:
                                        case 9:
                                            colValues +="'"+ gitem["Value"].ToString() + "',";
                                                break;

                                        default:
                                                    if(gitem["Value"].ToString()=="")

                                                        colValues +=  "NULL,";
                                                    else
                                                    colValues += gitem["Value"].ToString() + ",";
                                            break;
                                    }                                    
                                }                                 
                            }

                                    if (!isFound)
                                    {
                                        colValues += "null,";
                                        
                                    }
                            
                        }
                                 colValues=colValues.Remove(colValues.Length - 1);

                                 bulkInsertQuery=bulkInsertQuery+ string.Format(tempInsertQuery, colValues);

                                 colValues=string.Empty;
                        }
                        }
                        break;
                     
                                    case "c018d17a-c198-7da2-f9a8-6701c434c1c3":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_c018d17ac1987da2f9a86701c434c1c3 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [FD_Description] VARCHAR(MAX)	, [FD_FundType] VARCHAR(MAX)	, [FD_Amount] DECIMAL(18,2)){0}INSERT INTO [c018d17a-c198-7da2-f9a8-6701c434c1c3](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,FD_Description,FD_FundType,FD_Amount)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.FD_Description,TDT.FD_FundType,TDT.FD_Amount FROM @TBL_c018d17ac1987da2f9a86701c434c1c3 TDT
							LEFT JOIN [c018d17a-c198-7da2-f9a8-6701c434c1c3] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,FD_Description=TDT.FD_Description,FD_FundType=TDT.FD_FundType,FD_Amount=TDT.FD_Amount FROM @TBL_c018d17ac1987da2f9a86701c434c1c3 TDT
							JOIN [c018d17a-c198-7da2-f9a8-6701c434c1c3] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,FD_Description,FD_FundType,FD_Amount";

                                     tempInsertQuery=@"INSERT INTO @TBL_c018d17ac1987da2f9a86701c434c1c3(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,FD_Description,FD_FundType,FD_Amount)VALUES({0});";
                                     

                            splitcols = colList.Split(',');

                            if(splitcols.Length<=0)
                                return null;

                            var parentObject = JObject.Parse(formJsonData)["Child"];

                            for (int i = 0; i < ((JArray)parentObject).Count; i++)
                            {

                            JObject childObject = (JObject)parentObject[i];

                            var gridRow = childObject["Child"];


                        
                            foreach (var gcol in splitcols)
                            {
                                if (gcol == "InstanceId")
                                {
                                    colValues += "'" + instanceId + "',";

                                    continue;

                                }

                                else if (gcol == "ProcessActivityMapId")
                                {
                                    colValues += "'" + processActivityMapId + "',";
                                    continue;
                            }

                            else if (gcol == "GridId")
                            {
                                    colValues += "'" + gridId + "',";
                                continue;
                            }                               
                            else if(gcol=="Sequence")
                            {
                                colValues += childObject["SEQ"]+",";
                                continue;
                            }
                             else if(gcol=="RowId")
                            {
                                colValues +="'" + childObject["RwId"]+"',";
                                continue;
                            }

                            bool isFound = false;

                            foreach (var gitem in gridRow)
                            {                               

                                if (gitem["ElementName"].ToString() == gcol)
                                {
                                    isFound = true;

                                    if (gitem["Value"] == null)
                                    {
                                        colValues += "null,";
                                        break;
                                    }

                                    switch(Convert.ToInt32(gitem["EDT"]))
                                    {
                                        case 0:
                                            colValues += (Convert.ToBoolean(gitem["Value"]) ? "1" : "0") + ",";
												break; 
                                        case 8:
                                        case 9:
                                            colValues +="'"+ gitem["Value"].ToString() + "',";
                                                break;

                                        default:
                                                    if(gitem["Value"].ToString()=="")

                                                        colValues +=  "NULL,";
                                                    else
                                                    colValues += gitem["Value"].ToString() + ",";
                                            break;
                                    }                                    
                                }                                 
                            }

                                    if (!isFound)
                                    {
                                        colValues += "null,";
                                        
                                    }
                            
                        }
                                 colValues=colValues.Remove(colValues.Length - 1);

                                 bulkInsertQuery=bulkInsertQuery+ string.Format(tempInsertQuery, colValues);

                                 colValues=string.Empty;
                        }
                        }
                        break;
                     
                                    case "CDCED39A-D76C-4204-9A70-C637DD092E54":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_CDCED39AD76C42049A70C637DD092E54 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_d2_TADetailsID] VARCHAR(MAX)	, [MG_d2_TravelAdvanceID] VARCHAR(MAX)	, [MG_d2_Departure] VARCHAR(MAX)	, [MG_d2_DepartureDate] DATETIME	, [MG_d2_DepartureTime] VARCHAR(MAX)	, [MG_d2_Arrival] VARCHAR(MAX)	, [MG_d2_ArrivalDate] DATETIME	, [MG_d2_ArrivalTime] VARCHAR(MAX)	, [MG_d2_ModeofJourney] VARCHAR(MAX)	, [MG_d2_JourneyClass] VARCHAR(MAX)	, [MG_d2_Road] INT	, [MG_d2_PNRNo] VARCHAR(MAX)	, [MG_d2_Amount] DECIMAL(18,2)	, [MG_d2_IsTravelRequest] INT	, [MG_d2_UpdatedBy] INT	, [MG_d2_UpdatedOn] DATETIME){0}INSERT INTO [CDCED39A-D76C-4204-9A70-C637DD092E54](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d2_TADetailsID,MG_d2_TravelAdvanceID,MG_d2_Departure,MG_d2_DepartureDate,MG_d2_DepartureTime,MG_d2_Arrival,MG_d2_ArrivalDate,MG_d2_ArrivalTime,MG_d2_ModeofJourney,MG_d2_JourneyClass,MG_d2_Road,MG_d2_PNRNo,MG_d2_Amount,MG_d2_IsTravelRequest,MG_d2_UpdatedBy,MG_d2_UpdatedOn)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_d2_TADetailsID,TDT.MG_d2_TravelAdvanceID,TDT.MG_d2_Departure,TDT.MG_d2_DepartureDate,TDT.MG_d2_DepartureTime,TDT.MG_d2_Arrival,TDT.MG_d2_ArrivalDate,TDT.MG_d2_ArrivalTime,TDT.MG_d2_ModeofJourney,TDT.MG_d2_JourneyClass,TDT.MG_d2_Road,TDT.MG_d2_PNRNo,TDT.MG_d2_Amount,TDT.MG_d2_IsTravelRequest,TDT.MG_d2_UpdatedBy,TDT.MG_d2_UpdatedOn FROM @TBL_CDCED39AD76C42049A70C637DD092E54 TDT
							LEFT JOIN [CDCED39A-D76C-4204-9A70-C637DD092E54] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MG_d2_TADetailsID=TDT.MG_d2_TADetailsID,MG_d2_TravelAdvanceID=TDT.MG_d2_TravelAdvanceID,MG_d2_Departure=TDT.MG_d2_Departure,MG_d2_DepartureDate=TDT.MG_d2_DepartureDate,MG_d2_DepartureTime=TDT.MG_d2_DepartureTime,MG_d2_Arrival=TDT.MG_d2_Arrival,MG_d2_ArrivalDate=TDT.MG_d2_ArrivalDate,MG_d2_ArrivalTime=TDT.MG_d2_ArrivalTime,MG_d2_ModeofJourney=TDT.MG_d2_ModeofJourney,MG_d2_JourneyClass=TDT.MG_d2_JourneyClass,MG_d2_Road=TDT.MG_d2_Road,MG_d2_PNRNo=TDT.MG_d2_PNRNo,MG_d2_Amount=TDT.MG_d2_Amount,MG_d2_IsTravelRequest=TDT.MG_d2_IsTravelRequest,MG_d2_UpdatedBy=TDT.MG_d2_UpdatedBy,MG_d2_UpdatedOn=TDT.MG_d2_UpdatedOn FROM @TBL_CDCED39AD76C42049A70C637DD092E54 TDT
							JOIN [CDCED39A-D76C-4204-9A70-C637DD092E54] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d2_TADetailsID,MG_d2_TravelAdvanceID,MG_d2_Departure,MG_d2_DepartureDate,MG_d2_DepartureTime,MG_d2_Arrival,MG_d2_ArrivalDate,MG_d2_ArrivalTime,MG_d2_ModeofJourney,MG_d2_JourneyClass,MG_d2_Road,MG_d2_PNRNo,MG_d2_Amount,MG_d2_IsTravelRequest,MG_d2_UpdatedBy,MG_d2_UpdatedOn";

                                     tempInsertQuery=@"INSERT INTO @TBL_CDCED39AD76C42049A70C637DD092E54(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d2_TADetailsID,MG_d2_TravelAdvanceID,MG_d2_Departure,MG_d2_DepartureDate,MG_d2_DepartureTime,MG_d2_Arrival,MG_d2_ArrivalDate,MG_d2_ArrivalTime,MG_d2_ModeofJourney,MG_d2_JourneyClass,MG_d2_Road,MG_d2_PNRNo,MG_d2_Amount,MG_d2_IsTravelRequest,MG_d2_UpdatedBy,MG_d2_UpdatedOn)VALUES({0});";
                                     

                            splitcols = colList.Split(',');

                            if(splitcols.Length<=0)
                                return null;

                            var parentObject = JObject.Parse(formJsonData)["Child"];

                            for (int i = 0; i < ((JArray)parentObject).Count; i++)
                            {

                            JObject childObject = (JObject)parentObject[i];

                            var gridRow = childObject["Child"];


                        
                            foreach (var gcol in splitcols)
                            {
                                if (gcol == "InstanceId")
                                {
                                    colValues += "'" + instanceId + "',";

                                    continue;

                                }

                                else if (gcol == "ProcessActivityMapId")
                                {
                                    colValues += "'" + processActivityMapId + "',";
                                    continue;
                            }

                            else if (gcol == "GridId")
                            {
                                    colValues += "'" + gridId + "',";
                                continue;
                            }                               
                            else if(gcol=="Sequence")
                            {
                                colValues += childObject["SEQ"]+",";
                                continue;
                            }
                             else if(gcol=="RowId")
                            {
                                colValues +="'" + childObject["RwId"]+"',";
                                continue;
                            }

                            bool isFound = false;

                            foreach (var gitem in gridRow)
                            {                               

                                if (gitem["ElementName"].ToString() == gcol)
                                {
                                    isFound = true;

                                    if (gitem["Value"] == null)
                                    {
                                        colValues += "null,";
                                        break;
                                    }

                                    switch(Convert.ToInt32(gitem["EDT"]))
                                    {
                                        case 0:
                                            colValues += (Convert.ToBoolean(gitem["Value"]) ? "1" : "0") + ",";
												break; 
                                        case 8:
                                        case 9:
                                            colValues +="'"+ gitem["Value"].ToString() + "',";
                                                break;

                                        default:
                                                    if(gitem["Value"].ToString()=="")

                                                        colValues +=  "NULL,";
                                                    else
                                                    colValues += gitem["Value"].ToString() + ",";
                                            break;
                                    }                                    
                                }                                 
                            }

                                    if (!isFound)
                                    {
                                        colValues += "null,";
                                        
                                    }
                            
                        }
                                 colValues=colValues.Remove(colValues.Length - 1);

                                 bulkInsertQuery=bulkInsertQuery+ string.Format(tempInsertQuery, colValues);

                                 colValues=string.Empty;
                        }
                        }
                        break;
                     
                                    case "7DC7A3E8-9FDF-4C75-9F83-FEC89BA524E4":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_7DC7A3E89FDF4C759F83FEC89BA524E4 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_d3_ExpenditureTypeID] VARCHAR(MAX)	, [MG_d3_TravelAdvanceID] VARCHAR(MAX)	, [MG_d3_FromDate] DATETIME	, [MG_d3_ToDate] DATETIME	, [MG_d3_Amount] DECIMAL(18,2)	, [MG_d3_UpdatedBy] INT	, [MG_d3_UpdatedOn] DATETIME	, [MG_d3_ExpenditureType] INT	, [MG_d3_OtherExpenditureType] VARCHAR(MAX)	, [MG_d3_IsTravelRequest] INT){0}INSERT INTO [7DC7A3E8-9FDF-4C75-9F83-FEC89BA524E4](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d3_ExpenditureTypeID,MG_d3_TravelAdvanceID,MG_d3_FromDate,MG_d3_ToDate,MG_d3_Amount,MG_d3_UpdatedBy,MG_d3_UpdatedOn,MG_d3_ExpenditureType,MG_d3_OtherExpenditureType,MG_d3_IsTravelRequest)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_d3_ExpenditureTypeID,TDT.MG_d3_TravelAdvanceID,TDT.MG_d3_FromDate,TDT.MG_d3_ToDate,TDT.MG_d3_Amount,TDT.MG_d3_UpdatedBy,TDT.MG_d3_UpdatedOn,TDT.MG_d3_ExpenditureType,TDT.MG_d3_OtherExpenditureType,TDT.MG_d3_IsTravelRequest FROM @TBL_7DC7A3E89FDF4C759F83FEC89BA524E4 TDT
							LEFT JOIN [7DC7A3E8-9FDF-4C75-9F83-FEC89BA524E4] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MG_d3_ExpenditureTypeID=TDT.MG_d3_ExpenditureTypeID,MG_d3_TravelAdvanceID=TDT.MG_d3_TravelAdvanceID,MG_d3_FromDate=TDT.MG_d3_FromDate,MG_d3_ToDate=TDT.MG_d3_ToDate,MG_d3_Amount=TDT.MG_d3_Amount,MG_d3_UpdatedBy=TDT.MG_d3_UpdatedBy,MG_d3_UpdatedOn=TDT.MG_d3_UpdatedOn,MG_d3_ExpenditureType=TDT.MG_d3_ExpenditureType,MG_d3_OtherExpenditureType=TDT.MG_d3_OtherExpenditureType,MG_d3_IsTravelRequest=TDT.MG_d3_IsTravelRequest FROM @TBL_7DC7A3E89FDF4C759F83FEC89BA524E4 TDT
							JOIN [7DC7A3E8-9FDF-4C75-9F83-FEC89BA524E4] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d3_ExpenditureTypeID,MG_d3_TravelAdvanceID,MG_d3_FromDate,MG_d3_ToDate,MG_d3_Amount,MG_d3_UpdatedBy,MG_d3_UpdatedOn,MG_d3_ExpenditureType,MG_d3_OtherExpenditureType,MG_d3_IsTravelRequest";

                                     tempInsertQuery=@"INSERT INTO @TBL_7DC7A3E89FDF4C759F83FEC89BA524E4(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d3_ExpenditureTypeID,MG_d3_TravelAdvanceID,MG_d3_FromDate,MG_d3_ToDate,MG_d3_Amount,MG_d3_UpdatedBy,MG_d3_UpdatedOn,MG_d3_ExpenditureType,MG_d3_OtherExpenditureType,MG_d3_IsTravelRequest)VALUES({0});";
                                     

                            splitcols = colList.Split(',');

                            if(splitcols.Length<=0)
                                return null;

                            var parentObject = JObject.Parse(formJsonData)["Child"];

                            for (int i = 0; i < ((JArray)parentObject).Count; i++)
                            {

                            JObject childObject = (JObject)parentObject[i];

                            var gridRow = childObject["Child"];


                        
                            foreach (var gcol in splitcols)
                            {
                                if (gcol == "InstanceId")
                                {
                                    colValues += "'" + instanceId + "',";

                                    continue;

                                }

                                else if (gcol == "ProcessActivityMapId")
                                {
                                    colValues += "'" + processActivityMapId + "',";
                                    continue;
                            }

                            else if (gcol == "GridId")
                            {
                                    colValues += "'" + gridId + "',";
                                continue;
                            }                               
                            else if(gcol=="Sequence")
                            {
                                colValues += childObject["SEQ"]+",";
                                continue;
                            }
                             else if(gcol=="RowId")
                            {
                                colValues +="'" + childObject["RwId"]+"',";
                                continue;
                            }

                            bool isFound = false;

                            foreach (var gitem in gridRow)
                            {                               

                                if (gitem["ElementName"].ToString() == gcol)
                                {
                                    isFound = true;

                                    if (gitem["Value"] == null)
                                    {
                                        colValues += "null,";
                                        break;
                                    }

                                    switch(Convert.ToInt32(gitem["EDT"]))
                                    {
                                        case 0:
                                            colValues += (Convert.ToBoolean(gitem["Value"]) ? "1" : "0") + ",";
												break; 
                                        case 8:
                                        case 9:
                                            colValues +="'"+ gitem["Value"].ToString() + "',";
                                                break;

                                        default:
                                                    if(gitem["Value"].ToString()=="")

                                                        colValues +=  "NULL,";
                                                    else
                                                    colValues += gitem["Value"].ToString() + ",";
                                            break;
                                    }                                    
                                }                                 
                            }

                                    if (!isFound)
                                    {
                                        colValues += "null,";
                                        
                                    }
                            
                        }
                                 colValues=colValues.Remove(colValues.Length - 1);

                                 bulkInsertQuery=bulkInsertQuery+ string.Format(tempInsertQuery, colValues);

                                 colValues=string.Empty;
                        }
                        }
                        break;
                     
                                    case "57484F68-026D-4FF5-A5E1-E4E0BDDD76E0":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_57484F68026D4FF5A5E1E4E0BDDD76E0 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [PFA_FundType] VARCHAR(MAX)	, [PFA_FundTypeValue] VARCHAR(MAX)	, [PFA_ProjectNo] VARCHAR(MAX)	, [PFA_ProjectNoValue] VARCHAR(MAX)	, [PFA_BudgetHead] VARCHAR(MAX)	, [PFA_BudgetHeadValue] VARCHAR(MAX)	, [PFA_Amount] DECIMAL(18,2)	, [PFA_FundDetailsId] VARCHAR(MAX)){0}INSERT INTO [57484F68-026D-4FF5-A5E1-E4E0BDDD76E0](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PFA_FundType,PFA_FundTypeValue,PFA_ProjectNo,PFA_ProjectNoValue,PFA_BudgetHead,PFA_BudgetHeadValue,PFA_Amount,PFA_FundDetailsId)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.PFA_FundType,TDT.PFA_FundTypeValue,TDT.PFA_ProjectNo,TDT.PFA_ProjectNoValue,TDT.PFA_BudgetHead,TDT.PFA_BudgetHeadValue,TDT.PFA_Amount,TDT.PFA_FundDetailsId FROM @TBL_57484F68026D4FF5A5E1E4E0BDDD76E0 TDT
							LEFT JOIN [57484F68-026D-4FF5-A5E1-E4E0BDDD76E0] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,PFA_FundType=TDT.PFA_FundType,PFA_FundTypeValue=TDT.PFA_FundTypeValue,PFA_ProjectNo=TDT.PFA_ProjectNo,PFA_ProjectNoValue=TDT.PFA_ProjectNoValue,PFA_BudgetHead=TDT.PFA_BudgetHead,PFA_BudgetHeadValue=TDT.PFA_BudgetHeadValue,PFA_Amount=TDT.PFA_Amount,PFA_FundDetailsId=TDT.PFA_FundDetailsId FROM @TBL_57484F68026D4FF5A5E1E4E0BDDD76E0 TDT
							JOIN [57484F68-026D-4FF5-A5E1-E4E0BDDD76E0] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PFA_FundType,PFA_FundTypeValue,PFA_ProjectNo,PFA_ProjectNoValue,PFA_BudgetHead,PFA_BudgetHeadValue,PFA_Amount,PFA_FundDetailsId";

                                     tempInsertQuery=@"INSERT INTO @TBL_57484F68026D4FF5A5E1E4E0BDDD76E0(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PFA_FundType,PFA_FundTypeValue,PFA_ProjectNo,PFA_ProjectNoValue,PFA_BudgetHead,PFA_BudgetHeadValue,PFA_Amount,PFA_FundDetailsId)VALUES({0});";
                                     

                            splitcols = colList.Split(',');

                            if(splitcols.Length<=0)
                                return null;

                            var parentObject = JObject.Parse(formJsonData)["Child"];

                            for (int i = 0; i < ((JArray)parentObject).Count; i++)
                            {

                            JObject childObject = (JObject)parentObject[i];

                            var gridRow = childObject["Child"];


                        
                            foreach (var gcol in splitcols)
                            {
                                if (gcol == "InstanceId")
                                {
                                    colValues += "'" + instanceId + "',";

                                    continue;

                                }

                                else if (gcol == "ProcessActivityMapId")
                                {
                                    colValues += "'" + processActivityMapId + "',";
                                    continue;
                            }

                            else if (gcol == "GridId")
                            {
                                    colValues += "'" + gridId + "',";
                                continue;
                            }                               
                            else if(gcol=="Sequence")
                            {
                                colValues += childObject["SEQ"]+",";
                                continue;
                            }
                             else if(gcol=="RowId")
                            {
                                colValues +="'" + childObject["RwId"]+"',";
                                continue;
                            }

                            bool isFound = false;

                            foreach (var gitem in gridRow)
                            {                               

                                if (gitem["ElementName"].ToString() == gcol)
                                {
                                    isFound = true;

                                    if (gitem["Value"] == null)
                                    {
                                        colValues += "null,";
                                        break;
                                    }

                                    switch(Convert.ToInt32(gitem["EDT"]))
                                    {
                                        case 0:
                                            colValues += (Convert.ToBoolean(gitem["Value"]) ? "1" : "0") + ",";
												break; 
                                        case 8:
                                        case 9:
                                            colValues +="'"+ gitem["Value"].ToString() + "',";
                                                break;

                                        default:
                                                    if(gitem["Value"].ToString()=="")

                                                        colValues +=  "NULL,";
                                                    else
                                                    colValues += gitem["Value"].ToString() + ",";
                                            break;
                                    }                                    
                                }                                 
                            }

                                    if (!isFound)
                                    {
                                        colValues += "null,";
                                        
                                    }
                            
                        }
                                 colValues=colValues.Remove(colValues.Length - 1);

                                 bulkInsertQuery=bulkInsertQuery+ string.Format(tempInsertQuery, colValues);

                                 colValues=string.Empty;
                        }
                        }
                        break;
                     
                                    case "4435EA72-034D-4A84-8791-1F4DC99EADC1":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_4435EA72034D4A8487911F4DC99EADC1 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [PAB_BudgetName] VARCHAR(MAX)	, [PAB_SanctionedAmount] DECIMAL(18,2)	, [PAB_YetToRecieve] DECIMAL(18,2)	, [PAB_RecievedAmount] DECIMAL(18,2)	, [PAB_Commitment] DECIMAL(18,2)	, [PAB_Spent] DECIMAL(18,2)	, [PAB_Balance] DECIMAL(18,2)){0}INSERT INTO [4435EA72-034D-4A84-8791-1F4DC99EADC1](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PAB_BudgetName,PAB_SanctionedAmount,PAB_YetToRecieve,PAB_RecievedAmount,PAB_Commitment,PAB_Spent,PAB_Balance)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.PAB_BudgetName,TDT.PAB_SanctionedAmount,TDT.PAB_YetToRecieve,TDT.PAB_RecievedAmount,TDT.PAB_Commitment,TDT.PAB_Spent,TDT.PAB_Balance FROM @TBL_4435EA72034D4A8487911F4DC99EADC1 TDT
							LEFT JOIN [4435EA72-034D-4A84-8791-1F4DC99EADC1] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,PAB_BudgetName=TDT.PAB_BudgetName,PAB_SanctionedAmount=TDT.PAB_SanctionedAmount,PAB_YetToRecieve=TDT.PAB_YetToRecieve,PAB_RecievedAmount=TDT.PAB_RecievedAmount,PAB_Commitment=TDT.PAB_Commitment,PAB_Spent=TDT.PAB_Spent,PAB_Balance=TDT.PAB_Balance FROM @TBL_4435EA72034D4A8487911F4DC99EADC1 TDT
							JOIN [4435EA72-034D-4A84-8791-1F4DC99EADC1] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PAB_BudgetName,PAB_SanctionedAmount,PAB_YetToRecieve,PAB_RecievedAmount,PAB_Commitment,PAB_Spent,PAB_Balance";

                                     tempInsertQuery=@"INSERT INTO @TBL_4435EA72034D4A8487911F4DC99EADC1(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PAB_BudgetName,PAB_SanctionedAmount,PAB_YetToRecieve,PAB_RecievedAmount,PAB_Commitment,PAB_Spent,PAB_Balance)VALUES({0});";
                                     

                            splitcols = colList.Split(',');

                            if(splitcols.Length<=0)
                                return null;

                            var parentObject = JObject.Parse(formJsonData)["Child"];

                            for (int i = 0; i < ((JArray)parentObject).Count; i++)
                            {

                            JObject childObject = (JObject)parentObject[i];

                            var gridRow = childObject["Child"];


                        
                            foreach (var gcol in splitcols)
                            {
                                if (gcol == "InstanceId")
                                {
                                    colValues += "'" + instanceId + "',";

                                    continue;

                                }

                                else if (gcol == "ProcessActivityMapId")
                                {
                                    colValues += "'" + processActivityMapId + "',";
                                    continue;
                            }

                            else if (gcol == "GridId")
                            {
                                    colValues += "'" + gridId + "',";
                                continue;
                            }                               
                            else if(gcol=="Sequence")
                            {
                                colValues += childObject["SEQ"]+",";
                                continue;
                            }
                             else if(gcol=="RowId")
                            {
                                colValues +="'" + childObject["RwId"]+"',";
                                continue;
                            }

                            bool isFound = false;

                            foreach (var gitem in gridRow)
                            {                               

                                if (gitem["ElementName"].ToString() == gcol)
                                {
                                    isFound = true;

                                    if (gitem["Value"] == null)
                                    {
                                        colValues += "null,";
                                        break;
                                    }

                                    switch(Convert.ToInt32(gitem["EDT"]))
                                    {
                                        case 0:
                                            colValues += (Convert.ToBoolean(gitem["Value"]) ? "1" : "0") + ",";
												break; 
                                        case 8:
                                        case 9:
                                            colValues +="'"+ gitem["Value"].ToString() + "',";
                                                break;

                                        default:
                                                    if(gitem["Value"].ToString()=="")

                                                        colValues +=  "NULL,";
                                                    else
                                                    colValues += gitem["Value"].ToString() + ",";
                                            break;
                                    }                                    
                                }                                 
                            }

                                    if (!isFound)
                                    {
                                        colValues += "null,";
                                        
                                    }
                            
                        }
                                 colValues=colValues.Remove(colValues.Length - 1);

                                 bulkInsertQuery=bulkInsertQuery+ string.Format(tempInsertQuery, colValues);

                                 colValues=string.Empty;
                        }
                        }
                        break;
                     
                                    case "4BBC0C1F-5883-4AAD-A2A7-BF4551B3555E":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_4BBC0C1F58834AADA2A7BF4551B3555E AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [PADD_DocumentName] VARCHAR(MAX)	, [PADD_Document] VARCHAR(MAX)){0}INSERT INTO [4BBC0C1F-5883-4AAD-A2A7-BF4551B3555E](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PADD_DocumentName,PADD_Document)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.PADD_DocumentName,TDT.PADD_Document FROM @TBL_4BBC0C1F58834AADA2A7BF4551B3555E TDT
							LEFT JOIN [4BBC0C1F-5883-4AAD-A2A7-BF4551B3555E] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,PADD_DocumentName=TDT.PADD_DocumentName,PADD_Document=TDT.PADD_Document FROM @TBL_4BBC0C1F58834AADA2A7BF4551B3555E TDT
							JOIN [4BBC0C1F-5883-4AAD-A2A7-BF4551B3555E] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PADD_DocumentName,PADD_Document";

                                     tempInsertQuery=@"INSERT INTO @TBL_4BBC0C1F58834AADA2A7BF4551B3555E(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PADD_DocumentName,PADD_Document)VALUES({0});";
                                     

                            splitcols = colList.Split(',');

                            if(splitcols.Length<=0)
                                return null;

                            var parentObject = JObject.Parse(formJsonData)["Child"];

                            for (int i = 0; i < ((JArray)parentObject).Count; i++)
                            {

                            JObject childObject = (JObject)parentObject[i];

                            var gridRow = childObject["Child"];


                        
                            foreach (var gcol in splitcols)
                            {
                                if (gcol == "InstanceId")
                                {
                                    colValues += "'" + instanceId + "',";

                                    continue;

                                }

                                else if (gcol == "ProcessActivityMapId")
                                {
                                    colValues += "'" + processActivityMapId + "',";
                                    continue;
                            }

                            else if (gcol == "GridId")
                            {
                                    colValues += "'" + gridId + "',";
                                continue;
                            }                               
                            else if(gcol=="Sequence")
                            {
                                colValues += childObject["SEQ"]+",";
                                continue;
                            }
                             else if(gcol=="RowId")
                            {
                                colValues +="'" + childObject["RwId"]+"',";
                                continue;
                            }

                            bool isFound = false;

                            foreach (var gitem in gridRow)
                            {                               

                                if (gitem["ElementName"].ToString() == gcol)
                                {
                                    isFound = true;

                                    if (gitem["Value"] == null)
                                    {
                                        colValues += "null,";
                                        break;
                                    }

                                    switch(Convert.ToInt32(gitem["EDT"]))
                                    {
                                        case 0:
                                            colValues += (Convert.ToBoolean(gitem["Value"]) ? "1" : "0") + ",";
												break; 
                                        case 8:
                                        case 9:
                                            colValues +="'"+ gitem["Value"].ToString() + "',";
                                                break;

                                        default:
                                                    if(gitem["Value"].ToString()=="")

                                                        colValues +=  "NULL,";
                                                    else
                                                    colValues += gitem["Value"].ToString() + ",";
                                            break;
                                    }                                    
                                }                                 
                            }

                                    if (!isFound)
                                    {
                                        colValues += "null,";
                                        
                                    }
                            
                        }
                                 colValues=colValues.Remove(colValues.Length - 1);

                                 bulkInsertQuery=bulkInsertQuery+ string.Format(tempInsertQuery, colValues);

                                 colValues=string.Empty;
                        }
                        }
                        break;
                     
                                    case "EF8F97B1-41F1-43F5-91EF-FE1E3EBBE2AC":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_EF8F97B141F143F591EFFE1E3EBBE2AC AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [WMC_StepFrom] VARCHAR(MAX)	, [WMC_StepTo] VARCHAR(MAX)	, [WMC_Comments] VARCHAR(MAX)	, [WMC_User] VARCHAR(MAX)	, [WMC_DateofComments] DATETIME){0}INSERT INTO [EF8F97B1-41F1-43F5-91EF-FE1E3EBBE2AC](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,WMC_StepFrom,WMC_StepTo,WMC_Comments,WMC_User,WMC_DateofComments)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.WMC_StepFrom,TDT.WMC_StepTo,TDT.WMC_Comments,TDT.WMC_User,TDT.WMC_DateofComments FROM @TBL_EF8F97B141F143F591EFFE1E3EBBE2AC TDT
							LEFT JOIN [EF8F97B1-41F1-43F5-91EF-FE1E3EBBE2AC] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,WMC_StepFrom=TDT.WMC_StepFrom,WMC_StepTo=TDT.WMC_StepTo,WMC_Comments=TDT.WMC_Comments,WMC_User=TDT.WMC_User,WMC_DateofComments=TDT.WMC_DateofComments FROM @TBL_EF8F97B141F143F591EFFE1E3EBBE2AC TDT
							JOIN [EF8F97B1-41F1-43F5-91EF-FE1E3EBBE2AC] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,WMC_StepFrom,WMC_StepTo,WMC_Comments,WMC_User,WMC_DateofComments";

                                     tempInsertQuery=@"INSERT INTO @TBL_EF8F97B141F143F591EFFE1E3EBBE2AC(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,WMC_StepFrom,WMC_StepTo,WMC_Comments,WMC_User,WMC_DateofComments)VALUES({0});";
                                     

                            splitcols = colList.Split(',');

                            if(splitcols.Length<=0)
                                return null;

                            var parentObject = JObject.Parse(formJsonData)["Child"];

                            for (int i = 0; i < ((JArray)parentObject).Count; i++)
                            {

                            JObject childObject = (JObject)parentObject[i];

                            var gridRow = childObject["Child"];


                        
                            foreach (var gcol in splitcols)
                            {
                                if (gcol == "InstanceId")
                                {
                                    colValues += "'" + instanceId + "',";

                                    continue;

                                }

                                else if (gcol == "ProcessActivityMapId")
                                {
                                    colValues += "'" + processActivityMapId + "',";
                                    continue;
                            }

                            else if (gcol == "GridId")
                            {
                                    colValues += "'" + gridId + "',";
                                continue;
                            }                               
                            else if(gcol=="Sequence")
                            {
                                colValues += childObject["SEQ"]+",";
                                continue;
                            }
                             else if(gcol=="RowId")
                            {
                                colValues +="'" + childObject["RwId"]+"',";
                                continue;
                            }

                            bool isFound = false;

                            foreach (var gitem in gridRow)
                            {                               

                                if (gitem["ElementName"].ToString() == gcol)
                                {
                                    isFound = true;

                                    if (gitem["Value"] == null)
                                    {
                                        colValues += "null,";
                                        break;
                                    }

                                    switch(Convert.ToInt32(gitem["EDT"]))
                                    {
                                        case 0:
                                            colValues += (Convert.ToBoolean(gitem["Value"]) ? "1" : "0") + ",";
												break; 
                                        case 8:
                                        case 9:
                                            colValues +="'"+ gitem["Value"].ToString() + "',";
                                                break;

                                        default:
                                                    if(gitem["Value"].ToString()=="")

                                                        colValues +=  "NULL,";
                                                    else
                                                    colValues += gitem["Value"].ToString() + ",";
                                            break;
                                    }                                    
                                }                                 
                            }

                                    if (!isFound)
                                    {
                                        colValues += "null,";
                                        
                                    }
                            
                        }
                                 colValues=colValues.Remove(colValues.Length - 1);

                                 bulkInsertQuery=bulkInsertQuery+ string.Format(tempInsertQuery, colValues);

                                 colValues=string.Empty;
                        }
                        }
                        break;
                     
                                 
                 }       
                

                 return string.Format(gInsertQuery, bulkInsertQuery);

        }
        catch(Exception ex)
        {
            _sysLog.Error("Error in  InsertGridData",ex);

            return null;
        }
        _sysLog.Debug("Exiting InsertGridData");
      }


      public override string GetGridLoopQuery(string gridId,string gridName,Dictionary<string,ServiceElementData> gridData)
        {
            _sysLog.Debug("Entering GetGridLoopQuery");

            try
            {

                string colValues = string.Empty;

                string[] splitcols = null;

                string colList = string.Empty;

                string gInsertQuery = string.Empty;

                string tempInsertQuery = string.Empty;

                string bulkInsertQuery = string.Empty;

                string instanceId = gridData["InstanceId"].Value;

                string processActivityMapId = gridData["gv_activitymapid"].Value;

             
                switch (gridId)
                {
                     

                                         case "f4c435ef-658d-ea4b-3047-12782c9508ca":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_f4c435ef658dea4b304712782c9508ca AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [TD_ModeofJourney] VARCHAR(MAX)	, [TD_Departure] VARCHAR(MAX)	, [TD_DepartureDate] DATETIME	, [TD_Arrival] VARCHAR(MAX)	, [TD_ArrivalDate] DATETIME	, [TD_JourneyClass] VARCHAR(MAX)	, [TD_RoadKms] DECIMAL(18,2)	, [TD_Amount] DECIMAL(18,2)){0}INSERT INTO [f4c435ef-658d-ea4b-3047-12782c9508ca](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,TD_ModeofJourney,TD_Departure,TD_DepartureDate,TD_Arrival,TD_ArrivalDate,TD_JourneyClass,TD_RoadKms,TD_Amount)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.TD_ModeofJourney,TDT.TD_Departure,TDT.TD_DepartureDate,TDT.TD_Arrival,TDT.TD_ArrivalDate,TDT.TD_JourneyClass,TDT.TD_RoadKms,TDT.TD_Amount FROM @TBL_f4c435ef658dea4b304712782c9508ca TDT
							LEFT JOIN [f4c435ef-658d-ea4b-3047-12782c9508ca] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,TD_ModeofJourney=TDT.TD_ModeofJourney,TD_Departure=TDT.TD_Departure,TD_DepartureDate=TDT.TD_DepartureDate,TD_Arrival=TDT.TD_Arrival,TD_ArrivalDate=TDT.TD_ArrivalDate,TD_JourneyClass=TDT.TD_JourneyClass,TD_RoadKms=TDT.TD_RoadKms,TD_Amount=TDT.TD_Amount FROM @TBL_f4c435ef658dea4b304712782c9508ca TDT
							JOIN [f4c435ef-658d-ea4b-3047-12782c9508ca] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,TD_ModeofJourney,TD_Departure,TD_DepartureDate,TD_Arrival,TD_ArrivalDate,TD_JourneyClass,TD_RoadKms,TD_Amount";

                            tempInsertQuery=@"INSERT INTO @TBL_f4c435ef658dea4b304712782c9508ca(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,TD_ModeofJourney,TD_Departure,TD_DepartureDate,TD_Arrival,TD_ArrivalDate,TD_JourneyClass,TD_RoadKms,TD_Amount)VALUES({0});";

                            splitcols = colList.Split(',');

                            if (splitcols.Length <= 0)
                                return null;

                            foreach (var gridChild in gridData[gridName].Child)
                            {                            
                                                                                         


                                foreach (var gcol in splitcols)
                                {
                                    if (gcol == "InstanceId")
                                    {
                                        colValues += "'" + instanceId + "',";

                                        continue;

                                    }

                                    else if (gcol == "ProcessActivityMapId")
                                    {
                                        colValues += "'" + processActivityMapId + "',";
                                        continue;
                                    }

                                    else if (gcol == "GridId")
                                    {
                                        colValues += "'" + gridId + "',";
                                        continue;
                                    }
                                    else if (gcol == "Sequence")
                                    {
                                        colValues += gridChild.SEQ + ",";
                                        continue;
                                    }
                                    else if (gcol == "RowId")
                                    {
                                        colValues += "'" + gridChild.RwId + "',";
                                        continue;
                                    }

                                    bool isFound = false;

                                    foreach (var gridrow in gridChild.Child)
                                    {

                                        if (gridrow.ElementName == gcol)
                                        {
                                            isFound = true;

                                            if (gridrow.Value == null)
                                            {
                                                colValues += "null,";
                                                break;
                                            }

                                            switch (Convert.ToInt32(gridrow.EDT))
                                            {
                                                case 8:
                                                case 9:
                                                    colValues += "'" + gridrow.Value.ToString() + "',";
                                                    break;

                                                default:
                                                    colValues += gridrow.Value.ToString() + ",";
                                                    break;
                                            }
                                        }
                                    }

                                    if (!isFound)
                                    {
                                        colValues += "null,";

                                    }

                                }
                                colValues = colValues.Remove(colValues.Length - 1);

                                bulkInsertQuery = bulkInsertQuery + string.Format(tempInsertQuery, colValues);
                            }
                        }
                        break;

                                              case "5cd6b407-a9ef-5a80-b97f-443d95733731":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_5cd6b407a9ef5a80b97f443d95733731 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [ED_ExpentitureType] VARCHAR(MAX)	, [ED_FromDate] DATETIME	, [ED_ToDate] DATETIME	, [ED_Amount] DECIMAL(18,2)){0}INSERT INTO [5cd6b407-a9ef-5a80-b97f-443d95733731](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,ED_ExpentitureType,ED_FromDate,ED_ToDate,ED_Amount)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.ED_ExpentitureType,TDT.ED_FromDate,TDT.ED_ToDate,TDT.ED_Amount FROM @TBL_5cd6b407a9ef5a80b97f443d95733731 TDT
							LEFT JOIN [5cd6b407-a9ef-5a80-b97f-443d95733731] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,ED_ExpentitureType=TDT.ED_ExpentitureType,ED_FromDate=TDT.ED_FromDate,ED_ToDate=TDT.ED_ToDate,ED_Amount=TDT.ED_Amount FROM @TBL_5cd6b407a9ef5a80b97f443d95733731 TDT
							JOIN [5cd6b407-a9ef-5a80-b97f-443d95733731] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,ED_ExpentitureType,ED_FromDate,ED_ToDate,ED_Amount";

                            tempInsertQuery=@"INSERT INTO @TBL_5cd6b407a9ef5a80b97f443d95733731(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,ED_ExpentitureType,ED_FromDate,ED_ToDate,ED_Amount)VALUES({0});";

                            splitcols = colList.Split(',');

                            if (splitcols.Length <= 0)
                                return null;

                            foreach (var gridChild in gridData[gridName].Child)
                            {                            
                                                                                         


                                foreach (var gcol in splitcols)
                                {
                                    if (gcol == "InstanceId")
                                    {
                                        colValues += "'" + instanceId + "',";

                                        continue;

                                    }

                                    else if (gcol == "ProcessActivityMapId")
                                    {
                                        colValues += "'" + processActivityMapId + "',";
                                        continue;
                                    }

                                    else if (gcol == "GridId")
                                    {
                                        colValues += "'" + gridId + "',";
                                        continue;
                                    }
                                    else if (gcol == "Sequence")
                                    {
                                        colValues += gridChild.SEQ + ",";
                                        continue;
                                    }
                                    else if (gcol == "RowId")
                                    {
                                        colValues += "'" + gridChild.RwId + "',";
                                        continue;
                                    }

                                    bool isFound = false;

                                    foreach (var gridrow in gridChild.Child)
                                    {

                                        if (gridrow.ElementName == gcol)
                                        {
                                            isFound = true;

                                            if (gridrow.Value == null)
                                            {
                                                colValues += "null,";
                                                break;
                                            }

                                            switch (Convert.ToInt32(gridrow.EDT))
                                            {
                                                case 8:
                                                case 9:
                                                    colValues += "'" + gridrow.Value.ToString() + "',";
                                                    break;

                                                default:
                                                    colValues += gridrow.Value.ToString() + ",";
                                                    break;
                                            }
                                        }
                                    }

                                    if (!isFound)
                                    {
                                        colValues += "null,";

                                    }

                                }
                                colValues = colValues.Remove(colValues.Length - 1);

                                bulkInsertQuery = bulkInsertQuery + string.Format(tempInsertQuery, colValues);
                            }
                        }
                        break;

                                              case "c018d17a-c198-7da2-f9a8-6701c434c1c3":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_c018d17ac1987da2f9a86701c434c1c3 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [FD_Description] VARCHAR(MAX)	, [FD_FundType] VARCHAR(MAX)	, [FD_Amount] DECIMAL(18,2)){0}INSERT INTO [c018d17a-c198-7da2-f9a8-6701c434c1c3](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,FD_Description,FD_FundType,FD_Amount)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.FD_Description,TDT.FD_FundType,TDT.FD_Amount FROM @TBL_c018d17ac1987da2f9a86701c434c1c3 TDT
							LEFT JOIN [c018d17a-c198-7da2-f9a8-6701c434c1c3] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,FD_Description=TDT.FD_Description,FD_FundType=TDT.FD_FundType,FD_Amount=TDT.FD_Amount FROM @TBL_c018d17ac1987da2f9a86701c434c1c3 TDT
							JOIN [c018d17a-c198-7da2-f9a8-6701c434c1c3] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,FD_Description,FD_FundType,FD_Amount";

                            tempInsertQuery=@"INSERT INTO @TBL_c018d17ac1987da2f9a86701c434c1c3(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,FD_Description,FD_FundType,FD_Amount)VALUES({0});";

                            splitcols = colList.Split(',');

                            if (splitcols.Length <= 0)
                                return null;

                            foreach (var gridChild in gridData[gridName].Child)
                            {                            
                                                                                         


                                foreach (var gcol in splitcols)
                                {
                                    if (gcol == "InstanceId")
                                    {
                                        colValues += "'" + instanceId + "',";

                                        continue;

                                    }

                                    else if (gcol == "ProcessActivityMapId")
                                    {
                                        colValues += "'" + processActivityMapId + "',";
                                        continue;
                                    }

                                    else if (gcol == "GridId")
                                    {
                                        colValues += "'" + gridId + "',";
                                        continue;
                                    }
                                    else if (gcol == "Sequence")
                                    {
                                        colValues += gridChild.SEQ + ",";
                                        continue;
                                    }
                                    else if (gcol == "RowId")
                                    {
                                        colValues += "'" + gridChild.RwId + "',";
                                        continue;
                                    }

                                    bool isFound = false;

                                    foreach (var gridrow in gridChild.Child)
                                    {

                                        if (gridrow.ElementName == gcol)
                                        {
                                            isFound = true;

                                            if (gridrow.Value == null)
                                            {
                                                colValues += "null,";
                                                break;
                                            }

                                            switch (Convert.ToInt32(gridrow.EDT))
                                            {
                                                case 8:
                                                case 9:
                                                    colValues += "'" + gridrow.Value.ToString() + "',";
                                                    break;

                                                default:
                                                    colValues += gridrow.Value.ToString() + ",";
                                                    break;
                                            }
                                        }
                                    }

                                    if (!isFound)
                                    {
                                        colValues += "null,";

                                    }

                                }
                                colValues = colValues.Remove(colValues.Length - 1);

                                bulkInsertQuery = bulkInsertQuery + string.Format(tempInsertQuery, colValues);
                            }
                        }
                        break;

                                              case "CDCED39A-D76C-4204-9A70-C637DD092E54":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_CDCED39AD76C42049A70C637DD092E54 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_d2_TADetailsID] VARCHAR(MAX)	, [MG_d2_TravelAdvanceID] VARCHAR(MAX)	, [MG_d2_Departure] VARCHAR(MAX)	, [MG_d2_DepartureDate] DATETIME	, [MG_d2_DepartureTime] VARCHAR(MAX)	, [MG_d2_Arrival] VARCHAR(MAX)	, [MG_d2_ArrivalDate] DATETIME	, [MG_d2_ArrivalTime] VARCHAR(MAX)	, [MG_d2_ModeofJourney] VARCHAR(MAX)	, [MG_d2_JourneyClass] VARCHAR(MAX)	, [MG_d2_Road] INT	, [MG_d2_PNRNo] VARCHAR(MAX)	, [MG_d2_Amount] DECIMAL(18,2)	, [MG_d2_IsTravelRequest] INT	, [MG_d2_UpdatedBy] INT	, [MG_d2_UpdatedOn] DATETIME){0}INSERT INTO [CDCED39A-D76C-4204-9A70-C637DD092E54](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d2_TADetailsID,MG_d2_TravelAdvanceID,MG_d2_Departure,MG_d2_DepartureDate,MG_d2_DepartureTime,MG_d2_Arrival,MG_d2_ArrivalDate,MG_d2_ArrivalTime,MG_d2_ModeofJourney,MG_d2_JourneyClass,MG_d2_Road,MG_d2_PNRNo,MG_d2_Amount,MG_d2_IsTravelRequest,MG_d2_UpdatedBy,MG_d2_UpdatedOn)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_d2_TADetailsID,TDT.MG_d2_TravelAdvanceID,TDT.MG_d2_Departure,TDT.MG_d2_DepartureDate,TDT.MG_d2_DepartureTime,TDT.MG_d2_Arrival,TDT.MG_d2_ArrivalDate,TDT.MG_d2_ArrivalTime,TDT.MG_d2_ModeofJourney,TDT.MG_d2_JourneyClass,TDT.MG_d2_Road,TDT.MG_d2_PNRNo,TDT.MG_d2_Amount,TDT.MG_d2_IsTravelRequest,TDT.MG_d2_UpdatedBy,TDT.MG_d2_UpdatedOn FROM @TBL_CDCED39AD76C42049A70C637DD092E54 TDT
							LEFT JOIN [CDCED39A-D76C-4204-9A70-C637DD092E54] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MG_d2_TADetailsID=TDT.MG_d2_TADetailsID,MG_d2_TravelAdvanceID=TDT.MG_d2_TravelAdvanceID,MG_d2_Departure=TDT.MG_d2_Departure,MG_d2_DepartureDate=TDT.MG_d2_DepartureDate,MG_d2_DepartureTime=TDT.MG_d2_DepartureTime,MG_d2_Arrival=TDT.MG_d2_Arrival,MG_d2_ArrivalDate=TDT.MG_d2_ArrivalDate,MG_d2_ArrivalTime=TDT.MG_d2_ArrivalTime,MG_d2_ModeofJourney=TDT.MG_d2_ModeofJourney,MG_d2_JourneyClass=TDT.MG_d2_JourneyClass,MG_d2_Road=TDT.MG_d2_Road,MG_d2_PNRNo=TDT.MG_d2_PNRNo,MG_d2_Amount=TDT.MG_d2_Amount,MG_d2_IsTravelRequest=TDT.MG_d2_IsTravelRequest,MG_d2_UpdatedBy=TDT.MG_d2_UpdatedBy,MG_d2_UpdatedOn=TDT.MG_d2_UpdatedOn FROM @TBL_CDCED39AD76C42049A70C637DD092E54 TDT
							JOIN [CDCED39A-D76C-4204-9A70-C637DD092E54] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d2_TADetailsID,MG_d2_TravelAdvanceID,MG_d2_Departure,MG_d2_DepartureDate,MG_d2_DepartureTime,MG_d2_Arrival,MG_d2_ArrivalDate,MG_d2_ArrivalTime,MG_d2_ModeofJourney,MG_d2_JourneyClass,MG_d2_Road,MG_d2_PNRNo,MG_d2_Amount,MG_d2_IsTravelRequest,MG_d2_UpdatedBy,MG_d2_UpdatedOn";

                            tempInsertQuery=@"INSERT INTO @TBL_CDCED39AD76C42049A70C637DD092E54(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d2_TADetailsID,MG_d2_TravelAdvanceID,MG_d2_Departure,MG_d2_DepartureDate,MG_d2_DepartureTime,MG_d2_Arrival,MG_d2_ArrivalDate,MG_d2_ArrivalTime,MG_d2_ModeofJourney,MG_d2_JourneyClass,MG_d2_Road,MG_d2_PNRNo,MG_d2_Amount,MG_d2_IsTravelRequest,MG_d2_UpdatedBy,MG_d2_UpdatedOn)VALUES({0});";

                            splitcols = colList.Split(',');

                            if (splitcols.Length <= 0)
                                return null;

                            foreach (var gridChild in gridData[gridName].Child)
                            {                            
                                                                                         


                                foreach (var gcol in splitcols)
                                {
                                    if (gcol == "InstanceId")
                                    {
                                        colValues += "'" + instanceId + "',";

                                        continue;

                                    }

                                    else if (gcol == "ProcessActivityMapId")
                                    {
                                        colValues += "'" + processActivityMapId + "',";
                                        continue;
                                    }

                                    else if (gcol == "GridId")
                                    {
                                        colValues += "'" + gridId + "',";
                                        continue;
                                    }
                                    else if (gcol == "Sequence")
                                    {
                                        colValues += gridChild.SEQ + ",";
                                        continue;
                                    }
                                    else if (gcol == "RowId")
                                    {
                                        colValues += "'" + gridChild.RwId + "',";
                                        continue;
                                    }

                                    bool isFound = false;

                                    foreach (var gridrow in gridChild.Child)
                                    {

                                        if (gridrow.ElementName == gcol)
                                        {
                                            isFound = true;

                                            if (gridrow.Value == null)
                                            {
                                                colValues += "null,";
                                                break;
                                            }

                                            switch (Convert.ToInt32(gridrow.EDT))
                                            {
                                                case 8:
                                                case 9:
                                                    colValues += "'" + gridrow.Value.ToString() + "',";
                                                    break;

                                                default:
                                                    colValues += gridrow.Value.ToString() + ",";
                                                    break;
                                            }
                                        }
                                    }

                                    if (!isFound)
                                    {
                                        colValues += "null,";

                                    }

                                }
                                colValues = colValues.Remove(colValues.Length - 1);

                                bulkInsertQuery = bulkInsertQuery + string.Format(tempInsertQuery, colValues);
                            }
                        }
                        break;

                                              case "7DC7A3E8-9FDF-4C75-9F83-FEC89BA524E4":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_7DC7A3E89FDF4C759F83FEC89BA524E4 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_d3_ExpenditureTypeID] VARCHAR(MAX)	, [MG_d3_TravelAdvanceID] VARCHAR(MAX)	, [MG_d3_FromDate] DATETIME	, [MG_d3_ToDate] DATETIME	, [MG_d3_Amount] DECIMAL(18,2)	, [MG_d3_UpdatedBy] INT	, [MG_d3_UpdatedOn] DATETIME	, [MG_d3_ExpenditureType] INT	, [MG_d3_OtherExpenditureType] VARCHAR(MAX)	, [MG_d3_IsTravelRequest] INT){0}INSERT INTO [7DC7A3E8-9FDF-4C75-9F83-FEC89BA524E4](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d3_ExpenditureTypeID,MG_d3_TravelAdvanceID,MG_d3_FromDate,MG_d3_ToDate,MG_d3_Amount,MG_d3_UpdatedBy,MG_d3_UpdatedOn,MG_d3_ExpenditureType,MG_d3_OtherExpenditureType,MG_d3_IsTravelRequest)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_d3_ExpenditureTypeID,TDT.MG_d3_TravelAdvanceID,TDT.MG_d3_FromDate,TDT.MG_d3_ToDate,TDT.MG_d3_Amount,TDT.MG_d3_UpdatedBy,TDT.MG_d3_UpdatedOn,TDT.MG_d3_ExpenditureType,TDT.MG_d3_OtherExpenditureType,TDT.MG_d3_IsTravelRequest FROM @TBL_7DC7A3E89FDF4C759F83FEC89BA524E4 TDT
							LEFT JOIN [7DC7A3E8-9FDF-4C75-9F83-FEC89BA524E4] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MG_d3_ExpenditureTypeID=TDT.MG_d3_ExpenditureTypeID,MG_d3_TravelAdvanceID=TDT.MG_d3_TravelAdvanceID,MG_d3_FromDate=TDT.MG_d3_FromDate,MG_d3_ToDate=TDT.MG_d3_ToDate,MG_d3_Amount=TDT.MG_d3_Amount,MG_d3_UpdatedBy=TDT.MG_d3_UpdatedBy,MG_d3_UpdatedOn=TDT.MG_d3_UpdatedOn,MG_d3_ExpenditureType=TDT.MG_d3_ExpenditureType,MG_d3_OtherExpenditureType=TDT.MG_d3_OtherExpenditureType,MG_d3_IsTravelRequest=TDT.MG_d3_IsTravelRequest FROM @TBL_7DC7A3E89FDF4C759F83FEC89BA524E4 TDT
							JOIN [7DC7A3E8-9FDF-4C75-9F83-FEC89BA524E4] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d3_ExpenditureTypeID,MG_d3_TravelAdvanceID,MG_d3_FromDate,MG_d3_ToDate,MG_d3_Amount,MG_d3_UpdatedBy,MG_d3_UpdatedOn,MG_d3_ExpenditureType,MG_d3_OtherExpenditureType,MG_d3_IsTravelRequest";

                            tempInsertQuery=@"INSERT INTO @TBL_7DC7A3E89FDF4C759F83FEC89BA524E4(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d3_ExpenditureTypeID,MG_d3_TravelAdvanceID,MG_d3_FromDate,MG_d3_ToDate,MG_d3_Amount,MG_d3_UpdatedBy,MG_d3_UpdatedOn,MG_d3_ExpenditureType,MG_d3_OtherExpenditureType,MG_d3_IsTravelRequest)VALUES({0});";

                            splitcols = colList.Split(',');

                            if (splitcols.Length <= 0)
                                return null;

                            foreach (var gridChild in gridData[gridName].Child)
                            {                            
                                                                                         


                                foreach (var gcol in splitcols)
                                {
                                    if (gcol == "InstanceId")
                                    {
                                        colValues += "'" + instanceId + "',";

                                        continue;

                                    }

                                    else if (gcol == "ProcessActivityMapId")
                                    {
                                        colValues += "'" + processActivityMapId + "',";
                                        continue;
                                    }

                                    else if (gcol == "GridId")
                                    {
                                        colValues += "'" + gridId + "',";
                                        continue;
                                    }
                                    else if (gcol == "Sequence")
                                    {
                                        colValues += gridChild.SEQ + ",";
                                        continue;
                                    }
                                    else if (gcol == "RowId")
                                    {
                                        colValues += "'" + gridChild.RwId + "',";
                                        continue;
                                    }

                                    bool isFound = false;

                                    foreach (var gridrow in gridChild.Child)
                                    {

                                        if (gridrow.ElementName == gcol)
                                        {
                                            isFound = true;

                                            if (gridrow.Value == null)
                                            {
                                                colValues += "null,";
                                                break;
                                            }

                                            switch (Convert.ToInt32(gridrow.EDT))
                                            {
                                                case 8:
                                                case 9:
                                                    colValues += "'" + gridrow.Value.ToString() + "',";
                                                    break;

                                                default:
                                                    colValues += gridrow.Value.ToString() + ",";
                                                    break;
                                            }
                                        }
                                    }

                                    if (!isFound)
                                    {
                                        colValues += "null,";

                                    }

                                }
                                colValues = colValues.Remove(colValues.Length - 1);

                                bulkInsertQuery = bulkInsertQuery + string.Format(tempInsertQuery, colValues);
                            }
                        }
                        break;

                                              case "57484F68-026D-4FF5-A5E1-E4E0BDDD76E0":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_57484F68026D4FF5A5E1E4E0BDDD76E0 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [PFA_FundType] VARCHAR(MAX)	, [PFA_FundTypeValue] VARCHAR(MAX)	, [PFA_ProjectNo] VARCHAR(MAX)	, [PFA_ProjectNoValue] VARCHAR(MAX)	, [PFA_BudgetHead] VARCHAR(MAX)	, [PFA_BudgetHeadValue] VARCHAR(MAX)	, [PFA_Amount] DECIMAL(18,2)	, [PFA_FundDetailsId] VARCHAR(MAX)){0}INSERT INTO [57484F68-026D-4FF5-A5E1-E4E0BDDD76E0](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PFA_FundType,PFA_FundTypeValue,PFA_ProjectNo,PFA_ProjectNoValue,PFA_BudgetHead,PFA_BudgetHeadValue,PFA_Amount,PFA_FundDetailsId)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.PFA_FundType,TDT.PFA_FundTypeValue,TDT.PFA_ProjectNo,TDT.PFA_ProjectNoValue,TDT.PFA_BudgetHead,TDT.PFA_BudgetHeadValue,TDT.PFA_Amount,TDT.PFA_FundDetailsId FROM @TBL_57484F68026D4FF5A5E1E4E0BDDD76E0 TDT
							LEFT JOIN [57484F68-026D-4FF5-A5E1-E4E0BDDD76E0] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,PFA_FundType=TDT.PFA_FundType,PFA_FundTypeValue=TDT.PFA_FundTypeValue,PFA_ProjectNo=TDT.PFA_ProjectNo,PFA_ProjectNoValue=TDT.PFA_ProjectNoValue,PFA_BudgetHead=TDT.PFA_BudgetHead,PFA_BudgetHeadValue=TDT.PFA_BudgetHeadValue,PFA_Amount=TDT.PFA_Amount,PFA_FundDetailsId=TDT.PFA_FundDetailsId FROM @TBL_57484F68026D4FF5A5E1E4E0BDDD76E0 TDT
							JOIN [57484F68-026D-4FF5-A5E1-E4E0BDDD76E0] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PFA_FundType,PFA_FundTypeValue,PFA_ProjectNo,PFA_ProjectNoValue,PFA_BudgetHead,PFA_BudgetHeadValue,PFA_Amount,PFA_FundDetailsId";

                            tempInsertQuery=@"INSERT INTO @TBL_57484F68026D4FF5A5E1E4E0BDDD76E0(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PFA_FundType,PFA_FundTypeValue,PFA_ProjectNo,PFA_ProjectNoValue,PFA_BudgetHead,PFA_BudgetHeadValue,PFA_Amount,PFA_FundDetailsId)VALUES({0});";

                            splitcols = colList.Split(',');

                            if (splitcols.Length <= 0)
                                return null;

                            foreach (var gridChild in gridData[gridName].Child)
                            {                            
                                                                                         


                                foreach (var gcol in splitcols)
                                {
                                    if (gcol == "InstanceId")
                                    {
                                        colValues += "'" + instanceId + "',";

                                        continue;

                                    }

                                    else if (gcol == "ProcessActivityMapId")
                                    {
                                        colValues += "'" + processActivityMapId + "',";
                                        continue;
                                    }

                                    else if (gcol == "GridId")
                                    {
                                        colValues += "'" + gridId + "',";
                                        continue;
                                    }
                                    else if (gcol == "Sequence")
                                    {
                                        colValues += gridChild.SEQ + ",";
                                        continue;
                                    }
                                    else if (gcol == "RowId")
                                    {
                                        colValues += "'" + gridChild.RwId + "',";
                                        continue;
                                    }

                                    bool isFound = false;

                                    foreach (var gridrow in gridChild.Child)
                                    {

                                        if (gridrow.ElementName == gcol)
                                        {
                                            isFound = true;

                                            if (gridrow.Value == null)
                                            {
                                                colValues += "null,";
                                                break;
                                            }

                                            switch (Convert.ToInt32(gridrow.EDT))
                                            {
                                                case 8:
                                                case 9:
                                                    colValues += "'" + gridrow.Value.ToString() + "',";
                                                    break;

                                                default:
                                                    colValues += gridrow.Value.ToString() + ",";
                                                    break;
                                            }
                                        }
                                    }

                                    if (!isFound)
                                    {
                                        colValues += "null,";

                                    }

                                }
                                colValues = colValues.Remove(colValues.Length - 1);

                                bulkInsertQuery = bulkInsertQuery + string.Format(tempInsertQuery, colValues);
                            }
                        }
                        break;

                                              case "4435EA72-034D-4A84-8791-1F4DC99EADC1":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_4435EA72034D4A8487911F4DC99EADC1 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [PAB_BudgetName] VARCHAR(MAX)	, [PAB_SanctionedAmount] DECIMAL(18,2)	, [PAB_YetToRecieve] DECIMAL(18,2)	, [PAB_RecievedAmount] DECIMAL(18,2)	, [PAB_Commitment] DECIMAL(18,2)	, [PAB_Spent] DECIMAL(18,2)	, [PAB_Balance] DECIMAL(18,2)){0}INSERT INTO [4435EA72-034D-4A84-8791-1F4DC99EADC1](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PAB_BudgetName,PAB_SanctionedAmount,PAB_YetToRecieve,PAB_RecievedAmount,PAB_Commitment,PAB_Spent,PAB_Balance)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.PAB_BudgetName,TDT.PAB_SanctionedAmount,TDT.PAB_YetToRecieve,TDT.PAB_RecievedAmount,TDT.PAB_Commitment,TDT.PAB_Spent,TDT.PAB_Balance FROM @TBL_4435EA72034D4A8487911F4DC99EADC1 TDT
							LEFT JOIN [4435EA72-034D-4A84-8791-1F4DC99EADC1] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,PAB_BudgetName=TDT.PAB_BudgetName,PAB_SanctionedAmount=TDT.PAB_SanctionedAmount,PAB_YetToRecieve=TDT.PAB_YetToRecieve,PAB_RecievedAmount=TDT.PAB_RecievedAmount,PAB_Commitment=TDT.PAB_Commitment,PAB_Spent=TDT.PAB_Spent,PAB_Balance=TDT.PAB_Balance FROM @TBL_4435EA72034D4A8487911F4DC99EADC1 TDT
							JOIN [4435EA72-034D-4A84-8791-1F4DC99EADC1] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PAB_BudgetName,PAB_SanctionedAmount,PAB_YetToRecieve,PAB_RecievedAmount,PAB_Commitment,PAB_Spent,PAB_Balance";

                            tempInsertQuery=@"INSERT INTO @TBL_4435EA72034D4A8487911F4DC99EADC1(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PAB_BudgetName,PAB_SanctionedAmount,PAB_YetToRecieve,PAB_RecievedAmount,PAB_Commitment,PAB_Spent,PAB_Balance)VALUES({0});";

                            splitcols = colList.Split(',');

                            if (splitcols.Length <= 0)
                                return null;

                            foreach (var gridChild in gridData[gridName].Child)
                            {                            
                                                                                         


                                foreach (var gcol in splitcols)
                                {
                                    if (gcol == "InstanceId")
                                    {
                                        colValues += "'" + instanceId + "',";

                                        continue;

                                    }

                                    else if (gcol == "ProcessActivityMapId")
                                    {
                                        colValues += "'" + processActivityMapId + "',";
                                        continue;
                                    }

                                    else if (gcol == "GridId")
                                    {
                                        colValues += "'" + gridId + "',";
                                        continue;
                                    }
                                    else if (gcol == "Sequence")
                                    {
                                        colValues += gridChild.SEQ + ",";
                                        continue;
                                    }
                                    else if (gcol == "RowId")
                                    {
                                        colValues += "'" + gridChild.RwId + "',";
                                        continue;
                                    }

                                    bool isFound = false;

                                    foreach (var gridrow in gridChild.Child)
                                    {

                                        if (gridrow.ElementName == gcol)
                                        {
                                            isFound = true;

                                            if (gridrow.Value == null)
                                            {
                                                colValues += "null,";
                                                break;
                                            }

                                            switch (Convert.ToInt32(gridrow.EDT))
                                            {
                                                case 8:
                                                case 9:
                                                    colValues += "'" + gridrow.Value.ToString() + "',";
                                                    break;

                                                default:
                                                    colValues += gridrow.Value.ToString() + ",";
                                                    break;
                                            }
                                        }
                                    }

                                    if (!isFound)
                                    {
                                        colValues += "null,";

                                    }

                                }
                                colValues = colValues.Remove(colValues.Length - 1);

                                bulkInsertQuery = bulkInsertQuery + string.Format(tempInsertQuery, colValues);
                            }
                        }
                        break;

                                              case "4BBC0C1F-5883-4AAD-A2A7-BF4551B3555E":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_4BBC0C1F58834AADA2A7BF4551B3555E AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [PADD_DocumentName] VARCHAR(MAX)	, [PADD_Document] VARCHAR(MAX)){0}INSERT INTO [4BBC0C1F-5883-4AAD-A2A7-BF4551B3555E](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PADD_DocumentName,PADD_Document)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.PADD_DocumentName,TDT.PADD_Document FROM @TBL_4BBC0C1F58834AADA2A7BF4551B3555E TDT
							LEFT JOIN [4BBC0C1F-5883-4AAD-A2A7-BF4551B3555E] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,PADD_DocumentName=TDT.PADD_DocumentName,PADD_Document=TDT.PADD_Document FROM @TBL_4BBC0C1F58834AADA2A7BF4551B3555E TDT
							JOIN [4BBC0C1F-5883-4AAD-A2A7-BF4551B3555E] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PADD_DocumentName,PADD_Document";

                            tempInsertQuery=@"INSERT INTO @TBL_4BBC0C1F58834AADA2A7BF4551B3555E(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PADD_DocumentName,PADD_Document)VALUES({0});";

                            splitcols = colList.Split(',');

                            if (splitcols.Length <= 0)
                                return null;

                            foreach (var gridChild in gridData[gridName].Child)
                            {                            
                                                                                         


                                foreach (var gcol in splitcols)
                                {
                                    if (gcol == "InstanceId")
                                    {
                                        colValues += "'" + instanceId + "',";

                                        continue;

                                    }

                                    else if (gcol == "ProcessActivityMapId")
                                    {
                                        colValues += "'" + processActivityMapId + "',";
                                        continue;
                                    }

                                    else if (gcol == "GridId")
                                    {
                                        colValues += "'" + gridId + "',";
                                        continue;
                                    }
                                    else if (gcol == "Sequence")
                                    {
                                        colValues += gridChild.SEQ + ",";
                                        continue;
                                    }
                                    else if (gcol == "RowId")
                                    {
                                        colValues += "'" + gridChild.RwId + "',";
                                        continue;
                                    }

                                    bool isFound = false;

                                    foreach (var gridrow in gridChild.Child)
                                    {

                                        if (gridrow.ElementName == gcol)
                                        {
                                            isFound = true;

                                            if (gridrow.Value == null)
                                            {
                                                colValues += "null,";
                                                break;
                                            }

                                            switch (Convert.ToInt32(gridrow.EDT))
                                            {
                                                case 8:
                                                case 9:
                                                    colValues += "'" + gridrow.Value.ToString() + "',";
                                                    break;

                                                default:
                                                    colValues += gridrow.Value.ToString() + ",";
                                                    break;
                                            }
                                        }
                                    }

                                    if (!isFound)
                                    {
                                        colValues += "null,";

                                    }

                                }
                                colValues = colValues.Remove(colValues.Length - 1);

                                bulkInsertQuery = bulkInsertQuery + string.Format(tempInsertQuery, colValues);
                            }
                        }
                        break;

                                              case "EF8F97B1-41F1-43F5-91EF-FE1E3EBBE2AC":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_EF8F97B141F143F591EFFE1E3EBBE2AC AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [WMC_StepFrom] VARCHAR(MAX)	, [WMC_StepTo] VARCHAR(MAX)	, [WMC_Comments] VARCHAR(MAX)	, [WMC_User] VARCHAR(MAX)	, [WMC_DateofComments] DATETIME){0}INSERT INTO [EF8F97B1-41F1-43F5-91EF-FE1E3EBBE2AC](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,WMC_StepFrom,WMC_StepTo,WMC_Comments,WMC_User,WMC_DateofComments)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.WMC_StepFrom,TDT.WMC_StepTo,TDT.WMC_Comments,TDT.WMC_User,TDT.WMC_DateofComments FROM @TBL_EF8F97B141F143F591EFFE1E3EBBE2AC TDT
							LEFT JOIN [EF8F97B1-41F1-43F5-91EF-FE1E3EBBE2AC] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,WMC_StepFrom=TDT.WMC_StepFrom,WMC_StepTo=TDT.WMC_StepTo,WMC_Comments=TDT.WMC_Comments,WMC_User=TDT.WMC_User,WMC_DateofComments=TDT.WMC_DateofComments FROM @TBL_EF8F97B141F143F591EFFE1E3EBBE2AC TDT
							JOIN [EF8F97B1-41F1-43F5-91EF-FE1E3EBBE2AC] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,WMC_StepFrom,WMC_StepTo,WMC_Comments,WMC_User,WMC_DateofComments";

                            tempInsertQuery=@"INSERT INTO @TBL_EF8F97B141F143F591EFFE1E3EBBE2AC(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,WMC_StepFrom,WMC_StepTo,WMC_Comments,WMC_User,WMC_DateofComments)VALUES({0});";

                            splitcols = colList.Split(',');

                            if (splitcols.Length <= 0)
                                return null;

                            foreach (var gridChild in gridData[gridName].Child)
                            {                            
                                                                                         


                                foreach (var gcol in splitcols)
                                {
                                    if (gcol == "InstanceId")
                                    {
                                        colValues += "'" + instanceId + "',";

                                        continue;

                                    }

                                    else if (gcol == "ProcessActivityMapId")
                                    {
                                        colValues += "'" + processActivityMapId + "',";
                                        continue;
                                    }

                                    else if (gcol == "GridId")
                                    {
                                        colValues += "'" + gridId + "',";
                                        continue;
                                    }
                                    else if (gcol == "Sequence")
                                    {
                                        colValues += gridChild.SEQ + ",";
                                        continue;
                                    }
                                    else if (gcol == "RowId")
                                    {
                                        colValues += "'" + gridChild.RwId + "',";
                                        continue;
                                    }

                                    bool isFound = false;

                                    foreach (var gridrow in gridChild.Child)
                                    {

                                        if (gridrow.ElementName == gcol)
                                        {
                                            isFound = true;

                                            if (gridrow.Value == null)
                                            {
                                                colValues += "null,";
                                                break;
                                            }

                                            switch (Convert.ToInt32(gridrow.EDT))
                                            {
                                                case 8:
                                                case 9:
                                                    colValues += "'" + gridrow.Value.ToString() + "',";
                                                    break;

                                                default:
                                                    colValues += gridrow.Value.ToString() + ",";
                                                    break;
                                            }
                                        }
                                    }

                                    if (!isFound)
                                    {
                                        colValues += "null,";

                                    }

                                }
                                colValues = colValues.Remove(colValues.Length - 1);

                                bulkInsertQuery = bulkInsertQuery + string.Format(tempInsertQuery, colValues);
                            }
                        }
                        break;

                                          }

                         

                return bulkInsertQuery;

            }
            catch (Exception ex)
            {
                _sysLog.Error("Error in  GetGridLoopQuery", ex);

                return null;
            }
           
        }


	}
}

namespace CPS.Proof.DFSExtension
{

using System.Collections.Generic;
using System;
using CPS.Proof.DFSExtension;
using System.Linq;using System.Data;
using System.Runtime.CompilerServices;
public class ISpaceAF9613E108AC4C90B5AD8A0678BD0D92 : VirtualForm
{
IISpace iSpace = new ISpace();
AcDataISpaceAF9613E108AC4C90B5AD8A0678BD0D92 acdataIspaceAF9613E108AC4C90B5AD8A0678BD0D92=new AcDataISpaceAF9613E108AC4C90B5AD8A0678BD0D92();
private void SubscribeFormEvents_root(ref Dictionary<string, ServiceElementData> ISpace)
{
try
{
base.WriteDebugInfo(@"Root-OnAfterFormLoad");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["WMF_InstanceId"].Value=ISpace["gv_instanceid"].Value;
base.WriteDebugInfo(@"ISpace[""WMF_InstanceId""].Value=ISpace[""gv_instanceid""].Value;");
if(ISpace["FormVersionId"].Value=="5EC1F0DF-8850-4210-ADF0-87EF9BDCB734")
{
ISpace["UI_ApprovalHideRow"].Visible="false";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""5EC1F0DF-8850-4210-ADF0-87EF9BDCB734"")
{
ISpace[""UI_ApprovalHideRow""].Visible=""false"";
}");
}
if(ISpace["FlowType"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""FlowType""].Value=="""")");
ISpace["WMF_IsInFlow"].Value=0;
base.WriteDebugInfo(@"ISpace[""WMF_IsInFlow""].Value=0;");
base.WriteDebugInfo(@"EXEC [GetInstanceInFlow] '@@gv_InstanceId'");

var querySourceC19B89A6EE8E42428B3CB80EB38918A3 =GetQueryExpressionDataSource("C19B89A6-EE8E-4242-8B3C-B80EB38918A3");
Dictionary<short,object> resultC19B89A6EE8E42428B3CB80EB38918A3=iSpace.ExecuteQuery(querySourceC19B89A6EE8E42428B3CB80EB38918A3,@"EXEC [GetInstanceInFlow] '" + ISpace["gv_instanceid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceC19B89A6EE8E42428B3CB80EB38918A3 =GetQueryExpressionDataSource(""C19B89A6-EE8E-4242-8B3C-B80EB38918A3"");Dictionary<short,object> resultC19B89A6EE8E42428B3CB80EB38918A3=iSpace.ExecuteQuery(querySourceC19B89A6EE8E42428B3CB80EB38918A3,@""EXEC [GetInstanceInFlow] '"" + ISpace[""gv_instanceid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultC19B89A6EE8E42428B3CB80EB38918A3!=null) && (resultC19B89A6EE8E42428B3CB80EB38918A3.Count!=0))
{
if(resultC19B89A6EE8E42428B3CB80EB38918A3.ContainsKey(0))
ISpace["WMF_IsInFlow"].Value = resultC19B89A6EE8E42428B3CB80EB38918A3[0];
}
else{
ISpace["WMF_IsInFlow"].Value = null;
}
if(ISpace["WMF_IsInFlow"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""WMF_IsInFlow""].Value==1)");
ISpace["WMF_FlowType"].Value="APPROVE";
base.WriteDebugInfo(@"ISpace[""WMF_FlowType""].Value=""APPROVE"";");
ISpace["WMF_MoveTo"].Visible="true";ISpace["WMF_History"].Visible="true";
base.WriteDebugInfo(@"ISpace[""WMF_MoveTo""].Visible=""true"";ISpace[""WMF_History""].Visible=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["WMF_MoveTo"].Visible="false";ISpace["WMF_History"].Visible="false";
base.WriteDebugInfo(@"ISpace[""WMF_MoveTo""].Visible=""false"";ISpace[""WMF_History""].Visible=""false"";");
}
}
ISpace["WMF_MoveTo"].Man=true;
base.WriteDebugInfo(@"ISpace[""WMF_MoveTo""].Man=true;");
if(ISpace["FWFM_FundType"].Value=="2")
{
base.WriteDebugInfo(@"if(ISpace[""FWFM_FundType""].Value==""2"")");
ISpace["FWFM_BudgetHead"].Visible="false";ISpace["FWFM_ProjectNo"].Visible="false";
base.WriteDebugInfo(@"ISpace[""FWFM_BudgetHead""].Visible=""false"";ISpace[""FWFM_ProjectNo""].Visible=""false"";");
ISpace["FWFM_BudgetHead"].Value="";
base.WriteDebugInfo(@"ISpace[""FWFM_BudgetHead""].Value="""";");
ISpace["FWFM_ProjectNo"].Value="";
base.WriteDebugInfo(@"ISpace[""FWFM_ProjectNo""].Value="""";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["FWFM_BudgetHead"].Visible="true";ISpace["FWFM_ProjectNo"].Visible="true";
base.WriteDebugInfo(@"ISpace[""FWFM_BudgetHead""].Visible=""true"";ISpace[""FWFM_ProjectNo""].Visible=""true"";");
}
if(ISpace["FWFM_FundType"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""FWFM_FundType""].Value=="""")");
ISpace["FWFM_BudgetHead"].Visible="false";ISpace["FWFM_ProjectNo"].Visible="false";ISpace["FWFM_Amount"].Visible="false";
base.WriteDebugInfo(@"ISpace[""FWFM_BudgetHead""].Visible=""false"";ISpace[""FWFM_ProjectNo""].Visible=""false"";ISpace[""FWFM_Amount""].Visible=""false"";");
}

var querySource435CD4B5CC1D46F09646DC152C46DC8B =GetQueryExpressionDataSource("435CD4B5-CC1D-46F0-9646-DC152C46DC8B");

DataTable result435CD4B5CC1D46F09646DC152C46DC8B=iSpace.SetGridDataSource(querySource435CD4B5CC1D46F09646DC152C46DC8B, _objectFactory.GetGridRPP("WMG_CommentsHistory"),@"EXEC [GetInstanceFlowDetais] '" + ISpace["gv_instanceid"].Value + @"'");

iSpace.InsertGridBindDetails("WMG_CommentsHistory","11",querySource435CD4B5CC1D46F09646DC152C46DC8B,"EXEC [GetInstanceFlowDetais] '" + ISpace["gv_instanceid"].Value + @"'",_objectFactory.GetGridRPP("WMG_CommentsHistory"));

base.WriteDebugInfo(@"var querySource435CD4B5CC1D46F09646DC152C46DC8B =GetQueryExpressionDataSource(""435CD4B5-CC1D-46F0-9646-DC152C46DC8B"");DataTable result435CD4B5CC1D46F09646DC152C46DC8B=iSpace.SetGridDataSource(querySource435CD4B5CC1D46F09646DC152C46DC8B, _objectFactory.GetGridRPP(""WMG_CommentsHistory""),@""EXEC [GetInstanceFlowDetais] '"" + ISpace[""gv_instanceid""].Value + @""'"");iSpace.InsertGridBindDetails(""WMG_CommentsHistory"",""11"",querySource435CD4B5CC1D46F09646DC152C46DC8B,""EXEC [GetInstanceFlowDetais] '"" + ISpace[""gv_instanceid""].Value + @""'"",_objectFactory.GetGridRPP(""WMG_CommentsHistory""));");
ISpace["PFMF_PackageProcessMapId"].Value=ISpace["gv_processmapid"].Value;
base.WriteDebugInfo(@"ISpace[""PFMF_PackageProcessMapId""].Value=ISpace[""gv_processmapid""].Value;");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> resultB30057A69D7342DA99B8FDC3205833DE=acdataIspaceAF9613E108AC4C90B5AD8A0678BD0D92.GetQueryExpressionBindings("B30057A6-9D73-42DA-99B8-FDC3205833DE");
iSpace.SetGridData(result435CD4B5CC1D46F09646DC152C46DC8B,resultB30057A69D7342DA99B8FDC3205833DE,"WMG_CommentsHistory",ref ISpace);
iSpace.UpdateGridBindDetails("WMG_CommentsHistory",resultB30057A69D7342DA99B8FDC3205833DE);
ISpace["PFMF_UserId"].Value=ISpace["gv_userid"].Value;
base.WriteDebugInfo(@"ISpace[""PFMF_UserId""].Value=ISpace[""gv_userid""].Value;");
if(ISpace["MF_d1_TravelAdvanceID"].Value!="0")
{
base.WriteDebugInfo(@"if(ISpace[""MF_d1_TravelAdvanceID""].Value!=""0"")");
base.WriteDebugInfo(@"EXEC InnovaceNoCode..[FormLoadById_8EC3FC2B-F5B6-4077-8C73-B83F5D859FC4]  '#MF_d1_TravelAdvanceID'");

var querySourceA12A0256E91B49BCB475C85CE71A07B6 =GetQueryExpressionDataSource("A12A0256-E91B-49BC-B475-C85CE71A07B6");
Dictionary<short,object> resultA12A0256E91B49BCB475C85CE71A07B6=iSpace.ExecuteQuery(querySourceA12A0256E91B49BCB475C85CE71A07B6,@"EXEC InnovaceNoCode..[FormLoadById_8EC3FC2B-F5B6-4077-8C73-B83F5D859FC4]  '" + ISpace["MF_d1_TravelAdvanceID"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceA12A0256E91B49BCB475C85CE71A07B6 =GetQueryExpressionDataSource(""A12A0256-E91B-49BC-B475-C85CE71A07B6"");Dictionary<short,object> resultA12A0256E91B49BCB475C85CE71A07B6=iSpace.ExecuteQuery(querySourceA12A0256E91B49BCB475C85CE71A07B6,@""EXEC InnovaceNoCode..[FormLoadById_8EC3FC2B-F5B6-4077-8C73-B83F5D859FC4]  '"" + ISpace[""MF_d1_TravelAdvanceID""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultA12A0256E91B49BCB475C85CE71A07B6!=null) && (resultA12A0256E91B49BCB475C85CE71A07B6.Count!=0))
{
if(resultA12A0256E91B49BCB475C85CE71A07B6.ContainsKey(21))
ISpace["MF_d1_PITransactionDate"].Value = resultA12A0256E91B49BCB475C85CE71A07B6[21];
if(resultA12A0256E91B49BCB475C85CE71A07B6.ContainsKey(25))
ISpace["MF_d1_CreatedOn"].Value = resultA12A0256E91B49BCB475C85CE71A07B6[25];
if(resultA12A0256E91B49BCB475C85CE71A07B6.ContainsKey(23))
ISpace["MF_d1_TSTransactionDate"].Value = resultA12A0256E91B49BCB475C85CE71A07B6[23];
if(resultA12A0256E91B49BCB475C85CE71A07B6.ContainsKey(14))
ISpace["MF_d1_TransactionDate"].Value = resultA12A0256E91B49BCB475C85CE71A07B6[14];
if(resultA12A0256E91B49BCB475C85CE71A07B6.ContainsKey(12))
ISpace["MF_d1_BankDocument"].Value = resultA12A0256E91B49BCB475C85CE71A07B6[12];
if(resultA12A0256E91B49BCB475C85CE71A07B6.ContainsKey(24))
ISpace["MF_d1_CreatedBy"].Value = resultA12A0256E91B49BCB475C85CE71A07B6[24];
if(resultA12A0256E91B49BCB475C85CE71A07B6.ContainsKey(16))
ISpace["MF_d1_AdvanceAmount"].Value = resultA12A0256E91B49BCB475C85CE71A07B6[16];
if(resultA12A0256E91B49BCB475C85CE71A07B6.ContainsKey(18))
ISpace["MF_d1_TSAmount"].Value = resultA12A0256E91B49BCB475C85CE71A07B6[18];
if(resultA12A0256E91B49BCB475C85CE71A07B6.ContainsKey(15))
ISpace["MF_d1_TotalAmount"].Value = resultA12A0256E91B49BCB475C85CE71A07B6[15];
if(resultA12A0256E91B49BCB475C85CE71A07B6.ContainsKey(13))
ISpace["MF_d1_TransactionNo"].Value = resultA12A0256E91B49BCB475C85CE71A07B6[13];
if(resultA12A0256E91B49BCB475C85CE71A07B6.ContainsKey(4))
ISpace["MF_d1_TravelType"].Value = resultA12A0256E91B49BCB475C85CE71A07B6[4];
if(resultA12A0256E91B49BCB475C85CE71A07B6.ContainsKey(10))
ISpace["MF_d1_BankName"].Value = resultA12A0256E91B49BCB475C85CE71A07B6[10];
if(resultA12A0256E91B49BCB475C85CE71A07B6.ContainsKey(2))
ISpace["MF_d1_ReferenceNo"].Value = resultA12A0256E91B49BCB475C85CE71A07B6[2];
if(resultA12A0256E91B49BCB475C85CE71A07B6.ContainsKey(22))
ISpace["MF_d1_TSTransactionNo"].Value = resultA12A0256E91B49BCB475C85CE71A07B6[22];
if(resultA12A0256E91B49BCB475C85CE71A07B6.ContainsKey(3))
ISpace["MF_d1_JourneyPurpose"].Value = resultA12A0256E91B49BCB475C85CE71A07B6[3];
if(resultA12A0256E91B49BCB475C85CE71A07B6.ContainsKey(6))
ISpace["MF_d1_IsAdvanceRequired"].Value = resultA12A0256E91B49BCB475C85CE71A07B6[6];
if(resultA12A0256E91B49BCB475C85CE71A07B6.ContainsKey(9))
ISpace["MF_d1_AccountNo"].Value = resultA12A0256E91B49BCB475C85CE71A07B6[9];
if(resultA12A0256E91B49BCB475C85CE71A07B6.ContainsKey(11))
ISpace["MF_d1_IFSCCode"].Value = resultA12A0256E91B49BCB475C85CE71A07B6[11];
if(resultA12A0256E91B49BCB475C85CE71A07B6.ContainsKey(1))
ISpace["MF_d1_EmployeeBasicInfoId"].Value = resultA12A0256E91B49BCB475C85CE71A07B6[1];
if(resultA12A0256E91B49BCB475C85CE71A07B6.ContainsKey(7))
ISpace["MF_d1_PaymentRemittenceTo"].Value = resultA12A0256E91B49BCB475C85CE71A07B6[7];
if(resultA12A0256E91B49BCB475C85CE71A07B6.ContainsKey(20))
ISpace["MF_d1_PITransactionNo"].Value = resultA12A0256E91B49BCB475C85CE71A07B6[20];
if(resultA12A0256E91B49BCB475C85CE71A07B6.ContainsKey(8))
ISpace["MF_d1_BeneficiaryName"].Value = resultA12A0256E91B49BCB475C85CE71A07B6[8];
if(resultA12A0256E91B49BCB475C85CE71A07B6.ContainsKey(17))
ISpace["MF_d1_TravelStatus"].Value = resultA12A0256E91B49BCB475C85CE71A07B6[17];
if(resultA12A0256E91B49BCB475C85CE71A07B6.ContainsKey(5))
ISpace["MF_d1_TravelPlace"].Value = resultA12A0256E91B49BCB475C85CE71A07B6[5];
if(resultA12A0256E91B49BCB475C85CE71A07B6.ContainsKey(19))
ISpace["MF_d1_TSStatus"].Value = resultA12A0256E91B49BCB475C85CE71A07B6[19];
if(resultA12A0256E91B49BCB475C85CE71A07B6.ContainsKey(0))
ISpace["MF_d1_TravelAdvanceID"].Value = resultA12A0256E91B49BCB475C85CE71A07B6[0];
}
else{
ISpace["MF_d1_PITransactionDate"].Value = null;ISpace["MF_d1_CreatedOn"].Value = null;ISpace["MF_d1_TSTransactionDate"].Value = null;ISpace["MF_d1_TransactionDate"].Value = null;ISpace["MF_d1_BankDocument"].Value = null;ISpace["MF_d1_CreatedBy"].Value = null;ISpace["MF_d1_AdvanceAmount"].Value = null;ISpace["MF_d1_TSAmount"].Value = null;ISpace["MF_d1_TotalAmount"].Value = null;ISpace["MF_d1_TransactionNo"].Value = null;ISpace["MF_d1_TravelType"].Value = null;ISpace["MF_d1_BankName"].Value = null;ISpace["MF_d1_ReferenceNo"].Value = null;ISpace["MF_d1_TSTransactionNo"].Value = null;ISpace["MF_d1_JourneyPurpose"].Value = null;ISpace["MF_d1_IsAdvanceRequired"].Value = null;ISpace["MF_d1_AccountNo"].Value = null;ISpace["MF_d1_IFSCCode"].Value = null;ISpace["MF_d1_EmployeeBasicInfoId"].Value = null;ISpace["MF_d1_PaymentRemittenceTo"].Value = null;ISpace["MF_d1_PITransactionNo"].Value = null;ISpace["MF_d1_BeneficiaryName"].Value = null;ISpace["MF_d1_TravelStatus"].Value = null;ISpace["MF_d1_TravelPlace"].Value = null;ISpace["MF_d1_TSStatus"].Value = null;ISpace["MF_d1_TravelAdvanceID"].Value = null;
}

var querySourceDA439285F85F4AA6815ECCAD8ADBC5EB =GetQueryExpressionDataSource("DA439285-F85F-4AA6-815E-CCAD8ADBC5EB");

DataTable resultDA439285F85F4AA6815ECCAD8ADBC5EB=iSpace.SetGridDataSource(querySourceDA439285F85F4AA6815ECCAD8ADBC5EB, _objectFactory.GetGridRPP("ActualExpenseDetails"),@"EXEC InnovaceNoCode..[GridLoadById_7DC7A3E8-9FDF-4C75-9F83-FEC89BA524E4]  '" + ISpace["MF_d1_TravelAdvanceID"].Value + @"'");

iSpace.InsertGridBindDetails("ActualExpenseDetails","11",querySourceDA439285F85F4AA6815ECCAD8ADBC5EB,"EXEC InnovaceNoCode..[GridLoadById_7DC7A3E8-9FDF-4C75-9F83-FEC89BA524E4]  '" + ISpace["MF_d1_TravelAdvanceID"].Value + @"'",_objectFactory.GetGridRPP("ActualExpenseDetails"));

base.WriteDebugInfo(@"var querySourceDA439285F85F4AA6815ECCAD8ADBC5EB =GetQueryExpressionDataSource(""DA439285-F85F-4AA6-815E-CCAD8ADBC5EB"");DataTable resultDA439285F85F4AA6815ECCAD8ADBC5EB=iSpace.SetGridDataSource(querySourceDA439285F85F4AA6815ECCAD8ADBC5EB, _objectFactory.GetGridRPP(""ActualExpenseDetails""),@""EXEC InnovaceNoCode..[GridLoadById_7DC7A3E8-9FDF-4C75-9F83-FEC89BA524E4]  '"" + ISpace[""MF_d1_TravelAdvanceID""].Value + @""'"");iSpace.InsertGridBindDetails(""ActualExpenseDetails"",""11"",querySourceDA439285F85F4AA6815ECCAD8ADBC5EB,""EXEC InnovaceNoCode..[GridLoadById_7DC7A3E8-9FDF-4C75-9F83-FEC89BA524E4]  '"" + ISpace[""MF_d1_TravelAdvanceID""].Value + @""'"",_objectFactory.GetGridRPP(""ActualExpenseDetails""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result57CC29FA86C9482780CFA0D013218FC6=acdataIspaceAF9613E108AC4C90B5AD8A0678BD0D92.GetQueryExpressionBindings("57CC29FA-86C9-4827-80CF-A0D013218FC6");
iSpace.SetGridData(resultDA439285F85F4AA6815ECCAD8ADBC5EB,result57CC29FA86C9482780CFA0D013218FC6,"ActualExpenseDetails",ref ISpace);
iSpace.UpdateGridBindDetails("ActualExpenseDetails",result57CC29FA86C9482780CFA0D013218FC6);

var querySource9B9A263EC6A34D51B6C818D8E59AC1BF =GetQueryExpressionDataSource("9B9A263E-C6A3-4D51-B6C8-18D8E59AC1BF");

DataTable result9B9A263EC6A34D51B6C818D8E59AC1BF=iSpace.SetGridDataSource(querySource9B9A263EC6A34D51B6C818D8E59AC1BF, _objectFactory.GetGridRPP("ActualAdvanceDetails"),@"EXEC InnovaceNoCode..[GridLoadById_CDCED39A-D76C-4204-9A70-C637DD092E54]  '" + ISpace["MF_d1_TravelAdvanceID"].Value + @"'");

iSpace.InsertGridBindDetails("ActualAdvanceDetails","11",querySource9B9A263EC6A34D51B6C818D8E59AC1BF,"EXEC InnovaceNoCode..[GridLoadById_CDCED39A-D76C-4204-9A70-C637DD092E54]  '" + ISpace["MF_d1_TravelAdvanceID"].Value + @"'",_objectFactory.GetGridRPP("ActualAdvanceDetails"));

base.WriteDebugInfo(@"var querySource9B9A263EC6A34D51B6C818D8E59AC1BF =GetQueryExpressionDataSource(""9B9A263E-C6A3-4D51-B6C8-18D8E59AC1BF"");DataTable result9B9A263EC6A34D51B6C818D8E59AC1BF=iSpace.SetGridDataSource(querySource9B9A263EC6A34D51B6C818D8E59AC1BF, _objectFactory.GetGridRPP(""ActualAdvanceDetails""),@""EXEC InnovaceNoCode..[GridLoadById_CDCED39A-D76C-4204-9A70-C637DD092E54]  '"" + ISpace[""MF_d1_TravelAdvanceID""].Value + @""'"");iSpace.InsertGridBindDetails(""ActualAdvanceDetails"",""11"",querySource9B9A263EC6A34D51B6C818D8E59AC1BF,""EXEC InnovaceNoCode..[GridLoadById_CDCED39A-D76C-4204-9A70-C637DD092E54]  '"" + ISpace[""MF_d1_TravelAdvanceID""].Value + @""'"",_objectFactory.GetGridRPP(""ActualAdvanceDetails""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result66C9935619C846F3AA3EE02BDAE5E174=acdataIspaceAF9613E108AC4C90B5AD8A0678BD0D92.GetQueryExpressionBindings("66C99356-19C8-46F3-AA3E-E02BDAE5E174");
iSpace.SetGridData(result9B9A263EC6A34D51B6C818D8E59AC1BF,result66C9935619C846F3AA3EE02BDAE5E174,"ActualAdvanceDetails",ref ISpace);
iSpace.UpdateGridBindDetails("ActualAdvanceDetails",result66C9935619C846F3AA3EE02BDAE5E174);
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_pfm_no (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"PFM_No-OnClick");
ISpace["PFM_FundDetailsId"].Value="";
base.WriteDebugInfo(@"ISpace[""PFM_FundDetailsId""].Value="""";");
ISpace["UI_DeleteDialog"].HideDialog=true;;
base.WriteDebugInfo(@"ISpace[""UI_DeleteDialog""].HideDialog=true;;");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_fwfm_fundtype (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"FWFM_FundType-OnChange");
if(ISpace["FWFM_FundType"].Value=="2")
{
base.WriteDebugInfo(@"if(ISpace[""FWFM_FundType""].Value==""2"")");
ISpace["FWFM_BudgetHead"].Visible="false";ISpace["FWFM_ProjectNo"].Visible="false";
base.WriteDebugInfo(@"ISpace[""FWFM_BudgetHead""].Visible=""false"";ISpace[""FWFM_ProjectNo""].Visible=""false"";");
ISpace["FWFM_BudgetHead"].Value="";
base.WriteDebugInfo(@"ISpace[""FWFM_BudgetHead""].Value="""";");
ISpace["FWFM_ProjectNo"].Value="";
base.WriteDebugInfo(@"ISpace[""FWFM_ProjectNo""].Value="""";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["FWFM_BudgetHead"].Visible="true";ISpace["FWFM_ProjectNo"].Visible="true";
base.WriteDebugInfo(@"ISpace[""FWFM_BudgetHead""].Visible=""true"";ISpace[""FWFM_ProjectNo""].Visible=""true"";");
}
if(ISpace["FWFM_FundType"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""FWFM_FundType""].Value=="""")");
ISpace["FWFM_BudgetHead"].Visible="false";ISpace["FWFM_ProjectNo"].Visible="false";ISpace["FWFM_Amount"].Visible="false";
base.WriteDebugInfo(@"ISpace[""FWFM_BudgetHead""].Visible=""false"";ISpace[""FWFM_ProjectNo""].Visible=""false"";ISpace[""FWFM_Amount""].Visible=""false"";");
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_save_actualexpensedetails (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Save_ActualExpenseDetails-OnClick");
if(ISpace["growid"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""growid""].Value=="""")");

var querySourceEA415B1CD6D74FD79BB92DB5E0B45A53 =GetQueryExpressionDataSource("EA415B1C-D6D7-4FD7-9BB9-2DB5E0B45A53");

DataTable resultEA415B1CD6D74FD79BB92DB5E0B45A53=iSpace.SetGridDataSource(querySourceEA415B1CD6D74FD79BB92DB5E0B45A53, _objectFactory.GetGridRPP("ActualExpenseDetails"),@"EXEC [AddFormGridData7DC7A3E8-9FDF-4C75-9F83-FEC89BA524E4] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','7DC7A3E8-9FDF-4C75-9F83-FEC89BA524E4','" + ISpace["growid"].Value + @"'," + ISpace["ActualExpenseDetails_Sequence"].Value + @",'" + ISpace["MFG_d3_ExpenditureTypeID"].Value + @"','" + ISpace["MFG_d3_TravelAdvanceID"].Value + @"','" + ISpace["MFG_d3_FromDate"].Value + @"','" + ISpace["MFG_d3_ToDate"].Value + @"'," + ISpace["MFG_d3_Amount"].Value + @"," + ISpace["MFG_d3_UpdatedBy"].Value + @",'" + ISpace["MFG_d3_UpdatedOn"].Value + @"'," + ISpace["MFG_d3_ExpenditureType"].Value + @",'" + ISpace["MFG_d3_OtherExpenditureType"].Value + @"'," + ISpace["MFG_d3_IsTravelRequest"].Value + @"");

iSpace.InsertGridBindDetails("ActualExpenseDetails","11",querySourceEA415B1CD6D74FD79BB92DB5E0B45A53,"EXEC [AddFormGridData7DC7A3E8-9FDF-4C75-9F83-FEC89BA524E4] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','7DC7A3E8-9FDF-4C75-9F83-FEC89BA524E4','" + ISpace["growid"].Value + @"'," + ISpace["ActualExpenseDetails_Sequence"].Value + @",'" + ISpace["MFG_d3_ExpenditureTypeID"].Value + @"','" + ISpace["MFG_d3_TravelAdvanceID"].Value + @"','" + ISpace["MFG_d3_FromDate"].Value + @"','" + ISpace["MFG_d3_ToDate"].Value + @"'," + ISpace["MFG_d3_Amount"].Value + @"," + ISpace["MFG_d3_UpdatedBy"].Value + @",'" + ISpace["MFG_d3_UpdatedOn"].Value + @"'," + ISpace["MFG_d3_ExpenditureType"].Value + @",'" + ISpace["MFG_d3_OtherExpenditureType"].Value + @"'," + ISpace["MFG_d3_IsTravelRequest"].Value + @"",_objectFactory.GetGridRPP("ActualExpenseDetails"));

base.WriteDebugInfo(@"var querySourceEA415B1CD6D74FD79BB92DB5E0B45A53 =GetQueryExpressionDataSource(""EA415B1C-D6D7-4FD7-9BB9-2DB5E0B45A53"");DataTable resultEA415B1CD6D74FD79BB92DB5E0B45A53=iSpace.SetGridDataSource(querySourceEA415B1CD6D74FD79BB92DB5E0B45A53, _objectFactory.GetGridRPP(""ActualExpenseDetails""),@""EXEC [AddFormGridData7DC7A3E8-9FDF-4C75-9F83-FEC89BA524E4] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','7DC7A3E8-9FDF-4C75-9F83-FEC89BA524E4','"" + ISpace[""growid""].Value + @""',"" + ISpace[""ActualExpenseDetails_Sequence""].Value + @"",'"" + ISpace[""MFG_d3_ExpenditureTypeID""].Value + @""','"" + ISpace[""MFG_d3_TravelAdvanceID""].Value + @""','"" + ISpace[""MFG_d3_FromDate""].Value + @""','"" + ISpace[""MFG_d3_ToDate""].Value + @""',"" + ISpace[""MFG_d3_Amount""].Value + @"","" + ISpace[""MFG_d3_UpdatedBy""].Value + @"",'"" + ISpace[""MFG_d3_UpdatedOn""].Value + @""',"" + ISpace[""MFG_d3_ExpenditureType""].Value + @"",'"" + ISpace[""MFG_d3_OtherExpenditureType""].Value + @""',"" + ISpace[""MFG_d3_IsTravelRequest""].Value + @"""");iSpace.InsertGridBindDetails(""ActualExpenseDetails"",""11"",querySourceEA415B1CD6D74FD79BB92DB5E0B45A53,""EXEC [AddFormGridData7DC7A3E8-9FDF-4C75-9F83-FEC89BA524E4] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','7DC7A3E8-9FDF-4C75-9F83-FEC89BA524E4','"" + ISpace[""growid""].Value + @""',"" + ISpace[""ActualExpenseDetails_Sequence""].Value + @"",'"" + ISpace[""MFG_d3_ExpenditureTypeID""].Value + @""','"" + ISpace[""MFG_d3_TravelAdvanceID""].Value + @""','"" + ISpace[""MFG_d3_FromDate""].Value + @""','"" + ISpace[""MFG_d3_ToDate""].Value + @""',"" + ISpace[""MFG_d3_Amount""].Value + @"","" + ISpace[""MFG_d3_UpdatedBy""].Value + @"",'"" + ISpace[""MFG_d3_UpdatedOn""].Value + @""',"" + ISpace[""MFG_d3_ExpenditureType""].Value + @"",'"" + ISpace[""MFG_d3_OtherExpenditureType""].Value + @""',"" + ISpace[""MFG_d3_IsTravelRequest""].Value + @"""",_objectFactory.GetGridRPP(""ActualExpenseDetails""));");
base.WriteDebugInfo(@"EXEC [AddFormGridData7DC7A3E8-9FDF-4C75-9F83-FEC89BA524E4] '@@gv_InstanceId','@@gv_ActivityMapId','7DC7A3E8-9FDF-4C75-9F83-FEC89BA524E4','#growid',#ActualExpenseDetails_Sequence,'#MFG_d3_ExpenditureTypeID','#MFG_d3_TravelAdvanceID','#MFG_d3_FromDate','#MFG_d3_ToDate',#MFG_d3_Amount,#MFG_d3_UpdatedBy,'#MFG_d3_UpdatedOn',#MFG_d3_ExpenditureType,'#MFG_d3_OtherExpenditureType',#MFG_d3_IsTravelRequest");


List<Triplet<string, short, short?>> resultACF88E572890475BBBB9B9C97EFE1F7B=acdataIspaceAF9613E108AC4C90B5AD8A0678BD0D92.GetQueryExpressionBindings("ACF88E57-2890-475B-BBB9-B9C97EFE1F7B");
iSpace.SetGridData(resultEA415B1CD6D74FD79BB92DB5E0B45A53,resultACF88E572890475BBBB9B9C97EFE1F7B,"ActualExpenseDetails",ref ISpace);
iSpace.UpdateGridBindDetails("ActualExpenseDetails",resultACF88E572890475BBBB9B9C97EFE1F7B);
}
else
{
base.WriteDebugInfo(@"else");

var querySourceAF669D29F63D48B397FF02224E901479 =GetQueryExpressionDataSource("AF669D29-F63D-48B3-97FF-02224E901479");

DataTable resultAF669D29F63D48B397FF02224E901479=iSpace.SetGridDataSource(querySourceAF669D29F63D48B397FF02224E901479, _objectFactory.GetGridRPP("ActualExpenseDetails"),@"EXEC [UpdateFormGridData7DC7A3E8-9FDF-4C75-9F83-FEC89BA524E4] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','7DC7A3E8-9FDF-4C75-9F83-FEC89BA524E4','" + ISpace["growid"].Value + @"'," + ISpace["ActualExpenseDetails_Sequence"].Value + @",'" + ISpace["MFG_d3_ExpenditureTypeID"].Value + @"','" + ISpace["MFG_d3_TravelAdvanceID"].Value + @"','" + ISpace["MFG_d3_FromDate"].Value + @"','" + ISpace["MFG_d3_ToDate"].Value + @"'," + ISpace["MFG_d3_Amount"].Value + @"," + ISpace["MFG_d3_UpdatedBy"].Value + @",'" + ISpace["MFG_d3_UpdatedOn"].Value + @"'," + ISpace["MFG_d3_ExpenditureType"].Value + @",'" + ISpace["MFG_d3_OtherExpenditureType"].Value + @"'," + ISpace["MFG_d3_IsTravelRequest"].Value + @"");

iSpace.InsertGridBindDetails("ActualExpenseDetails","11",querySourceAF669D29F63D48B397FF02224E901479,"EXEC [UpdateFormGridData7DC7A3E8-9FDF-4C75-9F83-FEC89BA524E4] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','7DC7A3E8-9FDF-4C75-9F83-FEC89BA524E4','" + ISpace["growid"].Value + @"'," + ISpace["ActualExpenseDetails_Sequence"].Value + @",'" + ISpace["MFG_d3_ExpenditureTypeID"].Value + @"','" + ISpace["MFG_d3_TravelAdvanceID"].Value + @"','" + ISpace["MFG_d3_FromDate"].Value + @"','" + ISpace["MFG_d3_ToDate"].Value + @"'," + ISpace["MFG_d3_Amount"].Value + @"," + ISpace["MFG_d3_UpdatedBy"].Value + @",'" + ISpace["MFG_d3_UpdatedOn"].Value + @"'," + ISpace["MFG_d3_ExpenditureType"].Value + @",'" + ISpace["MFG_d3_OtherExpenditureType"].Value + @"'," + ISpace["MFG_d3_IsTravelRequest"].Value + @"",_objectFactory.GetGridRPP("ActualExpenseDetails"));

base.WriteDebugInfo(@"var querySourceAF669D29F63D48B397FF02224E901479 =GetQueryExpressionDataSource(""AF669D29-F63D-48B3-97FF-02224E901479"");DataTable resultAF669D29F63D48B397FF02224E901479=iSpace.SetGridDataSource(querySourceAF669D29F63D48B397FF02224E901479, _objectFactory.GetGridRPP(""ActualExpenseDetails""),@""EXEC [UpdateFormGridData7DC7A3E8-9FDF-4C75-9F83-FEC89BA524E4] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','7DC7A3E8-9FDF-4C75-9F83-FEC89BA524E4','"" + ISpace[""growid""].Value + @""',"" + ISpace[""ActualExpenseDetails_Sequence""].Value + @"",'"" + ISpace[""MFG_d3_ExpenditureTypeID""].Value + @""','"" + ISpace[""MFG_d3_TravelAdvanceID""].Value + @""','"" + ISpace[""MFG_d3_FromDate""].Value + @""','"" + ISpace[""MFG_d3_ToDate""].Value + @""',"" + ISpace[""MFG_d3_Amount""].Value + @"","" + ISpace[""MFG_d3_UpdatedBy""].Value + @"",'"" + ISpace[""MFG_d3_UpdatedOn""].Value + @""',"" + ISpace[""MFG_d3_ExpenditureType""].Value + @"",'"" + ISpace[""MFG_d3_OtherExpenditureType""].Value + @""',"" + ISpace[""MFG_d3_IsTravelRequest""].Value + @"""");iSpace.InsertGridBindDetails(""ActualExpenseDetails"",""11"",querySourceAF669D29F63D48B397FF02224E901479,""EXEC [UpdateFormGridData7DC7A3E8-9FDF-4C75-9F83-FEC89BA524E4] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','7DC7A3E8-9FDF-4C75-9F83-FEC89BA524E4','"" + ISpace[""growid""].Value + @""',"" + ISpace[""ActualExpenseDetails_Sequence""].Value + @"",'"" + ISpace[""MFG_d3_ExpenditureTypeID""].Value + @""','"" + ISpace[""MFG_d3_TravelAdvanceID""].Value + @""','"" + ISpace[""MFG_d3_FromDate""].Value + @""','"" + ISpace[""MFG_d3_ToDate""].Value + @""',"" + ISpace[""MFG_d3_Amount""].Value + @"","" + ISpace[""MFG_d3_UpdatedBy""].Value + @"",'"" + ISpace[""MFG_d3_UpdatedOn""].Value + @""',"" + ISpace[""MFG_d3_ExpenditureType""].Value + @"",'"" + ISpace[""MFG_d3_OtherExpenditureType""].Value + @""',"" + ISpace[""MFG_d3_IsTravelRequest""].Value + @"""",_objectFactory.GetGridRPP(""ActualExpenseDetails""));");
base.WriteDebugInfo(@"EXEC [UpdateFormGridData7DC7A3E8-9FDF-4C75-9F83-FEC89BA524E4] '@@gv_InstanceId','@@gv_ActivityMapId','7DC7A3E8-9FDF-4C75-9F83-FEC89BA524E4','#growid',#ActualExpenseDetails_Sequence,'#MFG_d3_ExpenditureTypeID','#MFG_d3_TravelAdvanceID','#MFG_d3_FromDate','#MFG_d3_ToDate',#MFG_d3_Amount,#MFG_d3_UpdatedBy,'#MFG_d3_UpdatedOn',#MFG_d3_ExpenditureType,'#MFG_d3_OtherExpenditureType',#MFG_d3_IsTravelRequest");


List<Triplet<string, short, short?>> result7C43A884FC3143E2A4ADE41C918D2F43=acdataIspaceAF9613E108AC4C90B5AD8A0678BD0D92.GetQueryExpressionBindings("7C43A884-FC31-43E2-A4AD-E41C918D2F43");
iSpace.SetGridData(resultAF669D29F63D48B397FF02224E901479,result7C43A884FC3143E2A4ADE41C918D2F43,"ActualExpenseDetails",ref ISpace);
iSpace.UpdateGridBindDetails("ActualExpenseDetails",result7C43A884FC3143E2A4ADE41C918D2F43);
}
ISpace["growid"].Value="";
base.WriteDebugInfo(@"ISpace[""growid""].Value="""";");
ISpace["MFG_d3_ExpenditureTypeID"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d3_ExpenditureTypeID""].Value="""";");
ISpace["MFG_d3_TravelAdvanceID"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d3_TravelAdvanceID""].Value="""";");
ISpace["MFG_d3_FromDate"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d3_FromDate""].Value="""";");
ISpace["MFG_d3_ToDate"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d3_ToDate""].Value="""";");
ISpace["MFG_d3_Amount"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d3_Amount""].Value="""";");
ISpace["MFG_d3_UpdatedBy"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d3_UpdatedBy""].Value="""";");
ISpace["MFG_d3_UpdatedOn"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d3_UpdatedOn""].Value="""";");
ISpace["MFG_d3_ExpenditureType"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d3_ExpenditureType""].Value="""";");
ISpace["MFG_d3_OtherExpenditureType"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d3_OtherExpenditureType""].Value="""";");
ISpace["MFG_d3_IsTravelRequest"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d3_IsTravelRequest""].Value="""";");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_wmf_moveto (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"WMF_MoveTo-OnChange");
if(ISpace["WMF_MoveTo"].Value=="APPROVE")
{
base.WriteDebugInfo(@"if(ISpace[""WMF_MoveTo""].Value==""APPROVE"")");
ISpace["FlowType"].Value="APPROVE";
base.WriteDebugInfo(@"ISpace[""FlowType""].Value=""APPROVE"";");
ISpace["Comments"].Man=false;
base.WriteDebugInfo(@"ISpace[""Comments""].Man=false;");
}
if(ISpace["WMF_MoveTo"].Value=="RETURN")
{
base.WriteDebugInfo(@"if(ISpace[""WMF_MoveTo""].Value==""RETURN"")");
ISpace["FlowType"].Value="RETURN";
base.WriteDebugInfo(@"ISpace[""FlowType""].Value=""RETURN"";");
ISpace["Comments"].Man=true;
base.WriteDebugInfo(@"ISpace[""Comments""].Man=true;");
}
if(ISpace["WMF_MoveTo"].Value=="REJECT")
{
base.WriteDebugInfo(@"if(ISpace[""WMF_MoveTo""].Value==""REJECT"")");
ISpace["FlowType"].Value="REJECT";
base.WriteDebugInfo(@"ISpace[""FlowType""].Value=""REJECT"";");
ISpace["Comments"].Man=true;
base.WriteDebugInfo(@"ISpace[""Comments""].Man=true;");
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_edit_actualexpensedetails (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Edit_ActualExpenseDetails-OnClick");
ISpace["growid"].Value=ISpace["ActualExpenseDetails_RowId"].Value;
base.WriteDebugInfo(@"ISpace[""growid""].Value=ISpace[""ActualExpenseDetails_RowId""].Value;");
base.WriteDebugInfo(@"EXEC [LoadFormGridData7DC7A3E8-9FDF-4C75-9F83-FEC89BA524E4] '@@gv_InstanceId','@@gv_ActivityMapId','7DC7A3E8-9FDF-4C75-9F83-FEC89BA524E4','#growid',#ActualExpenseDetails_Sequence");

var querySourceE66769EAD7F24E8EAEE5A3238B58DB25 =GetQueryExpressionDataSource("E66769EA-D7F2-4E8E-AEE5-A3238B58DB25");
Dictionary<short,object> resultE66769EAD7F24E8EAEE5A3238B58DB25=iSpace.ExecuteQuery(querySourceE66769EAD7F24E8EAEE5A3238B58DB25,@"EXEC [LoadFormGridData7DC7A3E8-9FDF-4C75-9F83-FEC89BA524E4] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','7DC7A3E8-9FDF-4C75-9F83-FEC89BA524E4','" + ISpace["growid"].Value + @"'," + ISpace["ActualExpenseDetails_Sequence"].Value + @"",false);

base.WriteDebugInfo(@"var querySourceE66769EAD7F24E8EAEE5A3238B58DB25 =GetQueryExpressionDataSource(""E66769EA-D7F2-4E8E-AEE5-A3238B58DB25"");Dictionary<short,object> resultE66769EAD7F24E8EAEE5A3238B58DB25=iSpace.ExecuteQuery(querySourceE66769EAD7F24E8EAEE5A3238B58DB25,@""EXEC [LoadFormGridData7DC7A3E8-9FDF-4C75-9F83-FEC89BA524E4] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','7DC7A3E8-9FDF-4C75-9F83-FEC89BA524E4','"" + ISpace[""growid""].Value + @""',"" + ISpace[""ActualExpenseDetails_Sequence""].Value + @"""",false);");
base.WriteDebugInfo(@"EXEC [LoadFormGridData7DC7A3E8-9FDF-4C75-9F83-FEC89BA524E4] '@@gv_InstanceId','@@gv_ActivityMapId','7DC7A3E8-9FDF-4C75-9F83-FEC89BA524E4','#growid',#ActualExpenseDetails_Sequence");

if((resultE66769EAD7F24E8EAEE5A3238B58DB25!=null) && (resultE66769EAD7F24E8EAEE5A3238B58DB25.Count!=0))
{
if(resultE66769EAD7F24E8EAEE5A3238B58DB25.ContainsKey(6))
ISpace["MFG_d3_UpdatedOn"].Value = resultE66769EAD7F24E8EAEE5A3238B58DB25[6];
if(resultE66769EAD7F24E8EAEE5A3238B58DB25.ContainsKey(3))
ISpace["MFG_d3_ToDate"].Value = resultE66769EAD7F24E8EAEE5A3238B58DB25[3];
if(resultE66769EAD7F24E8EAEE5A3238B58DB25.ContainsKey(2))
ISpace["MFG_d3_FromDate"].Value = resultE66769EAD7F24E8EAEE5A3238B58DB25[2];
if(resultE66769EAD7F24E8EAEE5A3238B58DB25.ContainsKey(4))
ISpace["MFG_d3_Amount"].Value = resultE66769EAD7F24E8EAEE5A3238B58DB25[4];
if(resultE66769EAD7F24E8EAEE5A3238B58DB25.ContainsKey(5))
ISpace["MFG_d3_UpdatedBy"].Value = resultE66769EAD7F24E8EAEE5A3238B58DB25[5];
if(resultE66769EAD7F24E8EAEE5A3238B58DB25.ContainsKey(9))
ISpace["MFG_d3_IsTravelRequest"].Value = resultE66769EAD7F24E8EAEE5A3238B58DB25[9];
if(resultE66769EAD7F24E8EAEE5A3238B58DB25.ContainsKey(7))
ISpace["MFG_d3_ExpenditureType"].Value = resultE66769EAD7F24E8EAEE5A3238B58DB25[7];
if(resultE66769EAD7F24E8EAEE5A3238B58DB25.ContainsKey(0))
ISpace["MFG_d3_ExpenditureTypeID"].Value = resultE66769EAD7F24E8EAEE5A3238B58DB25[0];
if(resultE66769EAD7F24E8EAEE5A3238B58DB25.ContainsKey(1))
ISpace["MFG_d3_TravelAdvanceID"].Value = resultE66769EAD7F24E8EAEE5A3238B58DB25[1];
if(resultE66769EAD7F24E8EAEE5A3238B58DB25.ContainsKey(8))
ISpace["MFG_d3_OtherExpenditureType"].Value = resultE66769EAD7F24E8EAEE5A3238B58DB25[8];
}
else{
ISpace["MFG_d3_UpdatedOn"].Value = null;ISpace["MFG_d3_ToDate"].Value = null;ISpace["MFG_d3_FromDate"].Value = null;ISpace["MFG_d3_Amount"].Value = null;ISpace["MFG_d3_UpdatedBy"].Value = null;ISpace["MFG_d3_IsTravelRequest"].Value = null;ISpace["MFG_d3_ExpenditureType"].Value = null;ISpace["MFG_d3_ExpenditureTypeID"].Value = null;ISpace["MFG_d3_TravelAdvanceID"].Value = null;ISpace["MFG_d3_OtherExpenditureType"].Value = null;
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_pfa_edit (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"PFA_Edit-OnClick");
base.WriteDebugInfo(@"Exec [Get60e821d0-153e-94bb-1fef-2594b78625bd] '@@gv_InstanceId','#PFA_FundDetailsId'");

var querySource8F645A2C5DD346B38E429A195AF59EF4 =GetQueryExpressionDataSource("8F645A2C-5DD3-46B3-8E42-9A195AF59EF4");
Dictionary<short,object> result8F645A2C5DD346B38E429A195AF59EF4=iSpace.ExecuteQuery(querySource8F645A2C5DD346B38E429A195AF59EF4,@"Exec [Get60e821d0-153e-94bb-1fef-2594b78625bd] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["PFA_FundDetailsId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource8F645A2C5DD346B38E429A195AF59EF4 =GetQueryExpressionDataSource(""8F645A2C-5DD3-46B3-8E42-9A195AF59EF4"");Dictionary<short,object> result8F645A2C5DD346B38E429A195AF59EF4=iSpace.ExecuteQuery(querySource8F645A2C5DD346B38E429A195AF59EF4,@""Exec [Get60e821d0-153e-94bb-1fef-2594b78625bd] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""PFA_FundDetailsId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result8F645A2C5DD346B38E429A195AF59EF4!=null) && (result8F645A2C5DD346B38E429A195AF59EF4.Count!=0))
{
if(result8F645A2C5DD346B38E429A195AF59EF4.ContainsKey(9))
ISpace["FWFM_BudgetHead"].Value = result8F645A2C5DD346B38E429A195AF59EF4[9];
if(result8F645A2C5DD346B38E429A195AF59EF4.ContainsKey(5))
ISpace["FWFM_FundType"].Value = result8F645A2C5DD346B38E429A195AF59EF4[5];
if(result8F645A2C5DD346B38E429A195AF59EF4.ContainsKey(7))
ISpace["FWFM_ProjectNo"].Value = result8F645A2C5DD346B38E429A195AF59EF4[7];
if(result8F645A2C5DD346B38E429A195AF59EF4.ContainsKey(11))
ISpace["FWFM_Amount"].Value = result8F645A2C5DD346B38E429A195AF59EF4[11];
if(result8F645A2C5DD346B38E429A195AF59EF4.ContainsKey(3))
ISpace["FWFM_FundDetailsId"].Value = result8F645A2C5DD346B38E429A195AF59EF4[3];
}
else{
ISpace["FWFM_BudgetHead"].Value = null;ISpace["FWFM_FundType"].Value = null;ISpace["FWFM_ProjectNo"].Value = null;ISpace["FWFM_Amount"].Value = null;ISpace["FWFM_FundDetailsId"].Value = null;
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_save_actualadvancedetails (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Save_ActualAdvanceDetails-OnClick");
if(ISpace["growid"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""growid""].Value=="""")");

var querySourceA28413FF40F7411EB510D6B851A56F92 =GetQueryExpressionDataSource("A28413FF-40F7-411E-B510-D6B851A56F92");

DataTable resultA28413FF40F7411EB510D6B851A56F92=iSpace.SetGridDataSource(querySourceA28413FF40F7411EB510D6B851A56F92, _objectFactory.GetGridRPP("ActualAdvanceDetails"),@"EXEC [AddFormGridDataCDCED39A-D76C-4204-9A70-C637DD092E54] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','CDCED39A-D76C-4204-9A70-C637DD092E54','" + ISpace["growid"].Value + @"'," + ISpace["ActualAdvanceDetails_Sequence"].Value + @",'" + ISpace["MFG_d2_TADetailsID"].Value + @"','" + ISpace["MFG_d2_TravelAdvanceID"].Value + @"','" + ISpace["MFG_d2_Departure"].Value + @"','" + ISpace["MFG_d2_DepartureDate"].Value + @"','" + ISpace["MFG_d2_DepartureTime"].Value + @"','" + ISpace["MFG_d2_Arrival"].Value + @"','" + ISpace["MFG_d2_ArrivalDate"].Value + @"','" + ISpace["MFG_d2_ArrivalTime"].Value + @"','" + ISpace["MFG_d2_ModeofJourney"].Value + @"','" + ISpace["MFG_d2_JourneyClass"].Value + @"'," + ISpace["MFG_d2_Road"].Value + @",'" + ISpace["MFG_d2_PNRNo"].Value + @"'," + ISpace["MFG_d2_Amount"].Value + @"," + ISpace["MFG_d2_IsTravelRequest"].Value + @"," + ISpace["MFG_d2_UpdatedBy"].Value + @",'" + ISpace["MFG_d2_Up"].Value + @"");

iSpace.InsertGridBindDetails("ActualAdvanceDetails","11",querySourceA28413FF40F7411EB510D6B851A56F92,"EXEC [AddFormGridDataCDCED39A-D76C-4204-9A70-C637DD092E54] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','CDCED39A-D76C-4204-9A70-C637DD092E54','" + ISpace["growid"].Value + @"'," + ISpace["ActualAdvanceDetails_Sequence"].Value + @",'" + ISpace["MFG_d2_TADetailsID"].Value + @"','" + ISpace["MFG_d2_TravelAdvanceID"].Value + @"','" + ISpace["MFG_d2_Departure"].Value + @"','" + ISpace["MFG_d2_DepartureDate"].Value + @"','" + ISpace["MFG_d2_DepartureTime"].Value + @"','" + ISpace["MFG_d2_Arrival"].Value + @"','" + ISpace["MFG_d2_ArrivalDate"].Value + @"','" + ISpace["MFG_d2_ArrivalTime"].Value + @"','" + ISpace["MFG_d2_ModeofJourney"].Value + @"','" + ISpace["MFG_d2_JourneyClass"].Value + @"'," + ISpace["MFG_d2_Road"].Value + @",'" + ISpace["MFG_d2_PNRNo"].Value + @"'," + ISpace["MFG_d2_Amount"].Value + @"," + ISpace["MFG_d2_IsTravelRequest"].Value + @"," + ISpace["MFG_d2_UpdatedBy"].Value + @",'" + ISpace["MFG_d2_Up"].Value + @"",_objectFactory.GetGridRPP("ActualAdvanceDetails"));

base.WriteDebugInfo(@"var querySourceA28413FF40F7411EB510D6B851A56F92 =GetQueryExpressionDataSource(""A28413FF-40F7-411E-B510-D6B851A56F92"");DataTable resultA28413FF40F7411EB510D6B851A56F92=iSpace.SetGridDataSource(querySourceA28413FF40F7411EB510D6B851A56F92, _objectFactory.GetGridRPP(""ActualAdvanceDetails""),@""EXEC [AddFormGridDataCDCED39A-D76C-4204-9A70-C637DD092E54] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','CDCED39A-D76C-4204-9A70-C637DD092E54','"" + ISpace[""growid""].Value + @""',"" + ISpace[""ActualAdvanceDetails_Sequence""].Value + @"",'"" + ISpace[""MFG_d2_TADetailsID""].Value + @""','"" + ISpace[""MFG_d2_TravelAdvanceID""].Value + @""','"" + ISpace[""MFG_d2_Departure""].Value + @""','"" + ISpace[""MFG_d2_DepartureDate""].Value + @""','"" + ISpace[""MFG_d2_DepartureTime""].Value + @""','"" + ISpace[""MFG_d2_Arrival""].Value + @""','"" + ISpace[""MFG_d2_ArrivalDate""].Value + @""','"" + ISpace[""MFG_d2_ArrivalTime""].Value + @""','"" + ISpace[""MFG_d2_ModeofJourney""].Value + @""','"" + ISpace[""MFG_d2_JourneyClass""].Value + @""',"" + ISpace[""MFG_d2_Road""].Value + @"",'"" + ISpace[""MFG_d2_PNRNo""].Value + @""',"" + ISpace[""MFG_d2_Amount""].Value + @"","" + ISpace[""MFG_d2_IsTravelRequest""].Value + @"","" + ISpace[""MFG_d2_UpdatedBy""].Value + @"",'"" + ISpace[""MFG_d2_Up""].Value + @"""");iSpace.InsertGridBindDetails(""ActualAdvanceDetails"",""11"",querySourceA28413FF40F7411EB510D6B851A56F92,""EXEC [AddFormGridDataCDCED39A-D76C-4204-9A70-C637DD092E54] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','CDCED39A-D76C-4204-9A70-C637DD092E54','"" + ISpace[""growid""].Value + @""',"" + ISpace[""ActualAdvanceDetails_Sequence""].Value + @"",'"" + ISpace[""MFG_d2_TADetailsID""].Value + @""','"" + ISpace[""MFG_d2_TravelAdvanceID""].Value + @""','"" + ISpace[""MFG_d2_Departure""].Value + @""','"" + ISpace[""MFG_d2_DepartureDate""].Value + @""','"" + ISpace[""MFG_d2_DepartureTime""].Value + @""','"" + ISpace[""MFG_d2_Arrival""].Value + @""','"" + ISpace[""MFG_d2_ArrivalDate""].Value + @""','"" + ISpace[""MFG_d2_ArrivalTime""].Value + @""','"" + ISpace[""MFG_d2_ModeofJourney""].Value + @""','"" + ISpace[""MFG_d2_JourneyClass""].Value + @""',"" + ISpace[""MFG_d2_Road""].Value + @"",'"" + ISpace[""MFG_d2_PNRNo""].Value + @""',"" + ISpace[""MFG_d2_Amount""].Value + @"","" + ISpace[""MFG_d2_IsTravelRequest""].Value + @"","" + ISpace[""MFG_d2_UpdatedBy""].Value + @"",'"" + ISpace[""MFG_d2_Up""].Value + @"""",_objectFactory.GetGridRPP(""ActualAdvanceDetails""));");
base.WriteDebugInfo(@"EXEC [AddFormGridDataCDCED39A-D76C-4204-9A70-C637DD092E54] '@@gv_InstanceId','@@gv_ActivityMapId','CDCED39A-D76C-4204-9A70-C637DD092E54','#growid',#ActualAdvanceDetails_Sequence,'#MFG_d2_TADetailsID','#MFG_d2_TravelAdvanceID','#MFG_d2_Departure','#MFG_d2_DepartureDate','#MFG_d2_DepartureTime','#MFG_d2_Arrival','#MFG_d2_ArrivalDate','#MFG_d2_ArrivalTime','#MFG_d2_ModeofJourney','#MFG_d2_JourneyClass',#MFG_d2_Road,'#MFG_d2_PNRNo',#MFG_d2_Amount,#MFG_d2_IsTravelRequest,#MFG_d2_UpdatedBy,'#MFG_d2_Up");


List<Triplet<string, short, short?>> result634802632BCB4FF0B3EB6CDE92E05563=acdataIspaceAF9613E108AC4C90B5AD8A0678BD0D92.GetQueryExpressionBindings("63480263-2BCB-4FF0-B3EB-6CDE92E05563");
iSpace.SetGridData(resultA28413FF40F7411EB510D6B851A56F92,result634802632BCB4FF0B3EB6CDE92E05563,"ActualAdvanceDetails",ref ISpace);
iSpace.UpdateGridBindDetails("ActualAdvanceDetails",result634802632BCB4FF0B3EB6CDE92E05563);
}
else
{
base.WriteDebugInfo(@"else");

var querySource9057B26B58804FC0B20E1099AFBF96BA =GetQueryExpressionDataSource("9057B26B-5880-4FC0-B20E-1099AFBF96BA");

DataTable result9057B26B58804FC0B20E1099AFBF96BA=iSpace.SetGridDataSource(querySource9057B26B58804FC0B20E1099AFBF96BA, _objectFactory.GetGridRPP("ActualAdvanceDetails"),@"EXEC [UpdateFormGridDataCDCED39A-D76C-4204-9A70-C637DD092E54] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','CDCED39A-D76C-4204-9A70-C637DD092E54','" + ISpace["growid"].Value + @"'," + ISpace["ActualAdvanceDetails_Sequence"].Value + @",'" + ISpace["MFG_d2_TADetailsID"].Value + @"','" + ISpace["MFG_d2_TravelAdvanceID"].Value + @"','" + ISpace["MFG_d2_Departure"].Value + @"','" + ISpace["MFG_d2_DepartureDate"].Value + @"','" + ISpace["MFG_d2_DepartureTime"].Value + @"','" + ISpace["MFG_d2_Arrival"].Value + @"','" + ISpace["MFG_d2_ArrivalDate"].Value + @"','" + ISpace["MFG_d2_ArrivalTime"].Value + @"','" + ISpace["MFG_d2_ModeofJourney"].Value + @"','" + ISpace["MFG_d2_JourneyClass"].Value + @"'," + ISpace["MFG_d2_Road"].Value + @",'" + ISpace["MFG_d2_PNRNo"].Value + @"'," + ISpace["MFG_d2_Amount"].Value + @"," + ISpace["MFG_d2_IsTravelRequest"].Value + @"," + ISpace["MFG_d2_UpdatedBy"].Value + @",'" + ISpace["MFG_d2"].Value + @"");

iSpace.InsertGridBindDetails("ActualAdvanceDetails","11",querySource9057B26B58804FC0B20E1099AFBF96BA,"EXEC [UpdateFormGridDataCDCED39A-D76C-4204-9A70-C637DD092E54] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','CDCED39A-D76C-4204-9A70-C637DD092E54','" + ISpace["growid"].Value + @"'," + ISpace["ActualAdvanceDetails_Sequence"].Value + @",'" + ISpace["MFG_d2_TADetailsID"].Value + @"','" + ISpace["MFG_d2_TravelAdvanceID"].Value + @"','" + ISpace["MFG_d2_Departure"].Value + @"','" + ISpace["MFG_d2_DepartureDate"].Value + @"','" + ISpace["MFG_d2_DepartureTime"].Value + @"','" + ISpace["MFG_d2_Arrival"].Value + @"','" + ISpace["MFG_d2_ArrivalDate"].Value + @"','" + ISpace["MFG_d2_ArrivalTime"].Value + @"','" + ISpace["MFG_d2_ModeofJourney"].Value + @"','" + ISpace["MFG_d2_JourneyClass"].Value + @"'," + ISpace["MFG_d2_Road"].Value + @",'" + ISpace["MFG_d2_PNRNo"].Value + @"'," + ISpace["MFG_d2_Amount"].Value + @"," + ISpace["MFG_d2_IsTravelRequest"].Value + @"," + ISpace["MFG_d2_UpdatedBy"].Value + @",'" + ISpace["MFG_d2"].Value + @"",_objectFactory.GetGridRPP("ActualAdvanceDetails"));

base.WriteDebugInfo(@"var querySource9057B26B58804FC0B20E1099AFBF96BA =GetQueryExpressionDataSource(""9057B26B-5880-4FC0-B20E-1099AFBF96BA"");DataTable result9057B26B58804FC0B20E1099AFBF96BA=iSpace.SetGridDataSource(querySource9057B26B58804FC0B20E1099AFBF96BA, _objectFactory.GetGridRPP(""ActualAdvanceDetails""),@""EXEC [UpdateFormGridDataCDCED39A-D76C-4204-9A70-C637DD092E54] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','CDCED39A-D76C-4204-9A70-C637DD092E54','"" + ISpace[""growid""].Value + @""',"" + ISpace[""ActualAdvanceDetails_Sequence""].Value + @"",'"" + ISpace[""MFG_d2_TADetailsID""].Value + @""','"" + ISpace[""MFG_d2_TravelAdvanceID""].Value + @""','"" + ISpace[""MFG_d2_Departure""].Value + @""','"" + ISpace[""MFG_d2_DepartureDate""].Value + @""','"" + ISpace[""MFG_d2_DepartureTime""].Value + @""','"" + ISpace[""MFG_d2_Arrival""].Value + @""','"" + ISpace[""MFG_d2_ArrivalDate""].Value + @""','"" + ISpace[""MFG_d2_ArrivalTime""].Value + @""','"" + ISpace[""MFG_d2_ModeofJourney""].Value + @""','"" + ISpace[""MFG_d2_JourneyClass""].Value + @""',"" + ISpace[""MFG_d2_Road""].Value + @"",'"" + ISpace[""MFG_d2_PNRNo""].Value + @""',"" + ISpace[""MFG_d2_Amount""].Value + @"","" + ISpace[""MFG_d2_IsTravelRequest""].Value + @"","" + ISpace[""MFG_d2_UpdatedBy""].Value + @"",'"" + ISpace[""MFG_d2""].Value + @"""");iSpace.InsertGridBindDetails(""ActualAdvanceDetails"",""11"",querySource9057B26B58804FC0B20E1099AFBF96BA,""EXEC [UpdateFormGridDataCDCED39A-D76C-4204-9A70-C637DD092E54] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','CDCED39A-D76C-4204-9A70-C637DD092E54','"" + ISpace[""growid""].Value + @""',"" + ISpace[""ActualAdvanceDetails_Sequence""].Value + @"",'"" + ISpace[""MFG_d2_TADetailsID""].Value + @""','"" + ISpace[""MFG_d2_TravelAdvanceID""].Value + @""','"" + ISpace[""MFG_d2_Departure""].Value + @""','"" + ISpace[""MFG_d2_DepartureDate""].Value + @""','"" + ISpace[""MFG_d2_DepartureTime""].Value + @""','"" + ISpace[""MFG_d2_Arrival""].Value + @""','"" + ISpace[""MFG_d2_ArrivalDate""].Value + @""','"" + ISpace[""MFG_d2_ArrivalTime""].Value + @""','"" + ISpace[""MFG_d2_ModeofJourney""].Value + @""','"" + ISpace[""MFG_d2_JourneyClass""].Value + @""',"" + ISpace[""MFG_d2_Road""].Value + @"",'"" + ISpace[""MFG_d2_PNRNo""].Value + @""',"" + ISpace[""MFG_d2_Amount""].Value + @"","" + ISpace[""MFG_d2_IsTravelRequest""].Value + @"","" + ISpace[""MFG_d2_UpdatedBy""].Value + @"",'"" + ISpace[""MFG_d2""].Value + @"""",_objectFactory.GetGridRPP(""ActualAdvanceDetails""));");
base.WriteDebugInfo(@"EXEC [UpdateFormGridDataCDCED39A-D76C-4204-9A70-C637DD092E54] '@@gv_InstanceId','@@gv_ActivityMapId','CDCED39A-D76C-4204-9A70-C637DD092E54','#growid',#ActualAdvanceDetails_Sequence,'#MFG_d2_TADetailsID','#MFG_d2_TravelAdvanceID','#MFG_d2_Departure','#MFG_d2_DepartureDate','#MFG_d2_DepartureTime','#MFG_d2_Arrival','#MFG_d2_ArrivalDate','#MFG_d2_ArrivalTime','#MFG_d2_ModeofJourney','#MFG_d2_JourneyClass',#MFG_d2_Road,'#MFG_d2_PNRNo',#MFG_d2_Amount,#MFG_d2_IsTravelRequest,#MFG_d2_UpdatedBy,'#MFG_d2");


List<Triplet<string, short, short?>> result4271EF3857134A9AB23998C593F3257F=acdataIspaceAF9613E108AC4C90B5AD8A0678BD0D92.GetQueryExpressionBindings("4271EF38-5713-4A9A-B239-98C593F3257F");
iSpace.SetGridData(result9057B26B58804FC0B20E1099AFBF96BA,result4271EF3857134A9AB23998C593F3257F,"ActualAdvanceDetails",ref ISpace);
iSpace.UpdateGridBindDetails("ActualAdvanceDetails",result4271EF3857134A9AB23998C593F3257F);
}
ISpace["growid"].Value="";
base.WriteDebugInfo(@"ISpace[""growid""].Value="""";");
ISpace["MFG_d2_TADetailsID"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d2_TADetailsID""].Value="""";");
ISpace["MFG_d2_TravelAdvanceID"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d2_TravelAdvanceID""].Value="""";");
ISpace["MFG_d2_Departure"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d2_Departure""].Value="""";");
ISpace["MFG_d2_DepartureDate"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d2_DepartureDate""].Value="""";");
ISpace["MFG_d2_DepartureTime"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d2_DepartureTime""].Value="""";");
ISpace["MFG_d2_Arrival"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d2_Arrival""].Value="""";");
ISpace["MFG_d2_ArrivalDate"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d2_ArrivalDate""].Value="""";");
ISpace["MFG_d2_ArrivalTime"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d2_ArrivalTime""].Value="""";");
ISpace["MFG_d2_ModeofJourney"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d2_ModeofJourney""].Value="""";");
ISpace["MFG_d2_JourneyClass"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d2_JourneyClass""].Value="""";");
ISpace["MFG_d2_Road"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d2_Road""].Value="""";");
ISpace["MFG_d2_PNRNo"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d2_PNRNo""].Value="""";");
ISpace["MFG_d2_Amount"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d2_Amount""].Value="""";");
ISpace["MFG_d2_IsTravelRequest"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d2_IsTravelRequest""].Value="""";");
ISpace["MFG_d2_UpdatedBy"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d2_UpdatedBy""].Value="""";");
ISpace["MFG_d2_UpdatedOn"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d2_UpdatedOn""].Value="""";");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_pfm_yes (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"PFM_Yes-OnClick");
base.WriteDebugInfo(@"EXEC [Delete60e821d0-153e_94bb-1fef-2594b78625bd] '@@gv_InstanceId','#PFM_FundDetailsId'");

var querySourceDDFA0B4026ED46C9A4C1A8ECC2CAAA49 =GetQueryExpressionDataSource("DDFA0B40-26ED-46C9-A4C1-A8ECC2CAAA49");
Dictionary<short,object> resultDDFA0B4026ED46C9A4C1A8ECC2CAAA49=iSpace.ExecuteQuery(querySourceDDFA0B4026ED46C9A4C1A8ECC2CAAA49,@"EXEC[Delete60e821d0-153e_94bb-1fef-2594b78625bd] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["PFM_FundDetailsId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceDDFA0B4026ED46C9A4C1A8ECC2CAAA49 =GetQueryExpressionDataSource(""DDFA0B40-26ED-46C9-A4C1-A8ECC2CAAA49"");Dictionary<short,object> resultDDFA0B4026ED46C9A4C1A8ECC2CAAA49=iSpace.ExecuteQuery(querySourceDDFA0B4026ED46C9A4C1A8ECC2CAAA49,@""EXEC[Delete60e821d0-153e_94bb-1fef-2594b78625bd] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""PFM_FundDetailsId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultDDFA0B4026ED46C9A4C1A8ECC2CAAA49!=null) && (resultDDFA0B4026ED46C9A4C1A8ECC2CAAA49.Count!=0))
{
if(resultDDFA0B4026ED46C9A4C1A8ECC2CAAA49.ContainsKey(0))
ISpace["PFM_ErrId"].Value = resultDDFA0B4026ED46C9A4C1A8ECC2CAAA49[0];
if(resultDDFA0B4026ED46C9A4C1A8ECC2CAAA49.ContainsKey(1))
ISpace["PFM_ErrMsg"].Value = resultDDFA0B4026ED46C9A4C1A8ECC2CAAA49[1];
}
else{
ISpace["PFM_ErrId"].Value = null;ISpace["PFM_ErrMsg"].Value = null;
}
ISpace["Message"].Value=String.Format(@"{0}",ISpace["PFM_ErrMsg"].Value);
base.WriteDebugInfo(@"ISpace[""Message""].Value=String.Format(@""{0}"",ISpace[""PFM_ErrMsg""].Value);");

var querySourceBBB0DE0581D3467BB16FB045502F9D29 =GetQueryExpressionDataSource("BBB0DE05-81D3-467B-B16F-B045502F9D29");

DataTable resultBBB0DE0581D3467BB16FB045502F9D29=iSpace.SetGridDataSource(querySourceBBB0DE0581D3467BB16FB045502F9D29, _objectFactory.GetGridRPP("MG_FundAllocation"),@"Exec [Get60e821d0-153e-94bb-1fef-2594b78625bd] '" + ISpace["gv_instanceid"].Value + @"'");

iSpace.InsertGridBindDetails("MG_FundAllocation","11",querySourceBBB0DE0581D3467BB16FB045502F9D29,"Exec [Get60e821d0-153e-94bb-1fef-2594b78625bd] '" + ISpace["gv_instanceid"].Value + @"'",_objectFactory.GetGridRPP("MG_FundAllocation"));

base.WriteDebugInfo(@"var querySourceBBB0DE0581D3467BB16FB045502F9D29 =GetQueryExpressionDataSource(""BBB0DE05-81D3-467B-B16F-B045502F9D29"");DataTable resultBBB0DE0581D3467BB16FB045502F9D29=iSpace.SetGridDataSource(querySourceBBB0DE0581D3467BB16FB045502F9D29, _objectFactory.GetGridRPP(""MG_FundAllocation""),@""Exec [Get60e821d0-153e-94bb-1fef-2594b78625bd] '"" + ISpace[""gv_instanceid""].Value + @""'"");iSpace.InsertGridBindDetails(""MG_FundAllocation"",""11"",querySourceBBB0DE0581D3467BB16FB045502F9D29,""Exec [Get60e821d0-153e-94bb-1fef-2594b78625bd] '"" + ISpace[""gv_instanceid""].Value + @""'"",_objectFactory.GetGridRPP(""MG_FundAllocation""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result58EFF32DD0CA44648DB768C9010FA8B0=acdataIspaceAF9613E108AC4C90B5AD8A0678BD0D92.GetQueryExpressionBindings("58EFF32D-D0CA-4464-8DB7-68C9010FA8B0");
iSpace.SetGridData(resultBBB0DE0581D3467BB16FB045502F9D29,result58EFF32DD0CA44648DB768C9010FA8B0,"MG_FundAllocation",ref ISpace);
iSpace.UpdateGridBindDetails("MG_FundAllocation",result58EFF32DD0CA44648DB768C9010FA8B0);
ISpace["PFM_FundDetailsId"].Value="";
base.WriteDebugInfo(@"ISpace[""PFM_FundDetailsId""].Value="""";");
ISpace["UI_DeleteDialog"].HideDialog=true;;
base.WriteDebugInfo(@"ISpace[""UI_DeleteDialog""].HideDialog=true;;");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_fwmf_availablebudget (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"FWMF_AvailableBudget-OnClick");
ISpace["FWAB_ProjectNo"].Value="";
base.WriteDebugInfo(@"ISpace[""FWAB_ProjectNo""].Value="""";");
ISpace["UI_WAvailableBudgetDialog"].ShowDialog=true;;
base.WriteDebugInfo(@"ISpace[""UI_WAvailableBudgetDialog""].ShowDialog=true;;");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_submitform (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"SubmitForm-OnClick");
base.WriteDebugInfo(@"EXEC InnovaceNoCode..[FormSave_8EC3FC2B-F5B6-4077-8C73-B83F5D859FC4]   '@@gv_InstanceId','@@gv_ActivityMapId','d4b10079-b7a6-40d1-94ec-eb886005f33a','#MF_d1_TravelAdvanceID','#MF_d1_EmployeeBasicInfoId','#MF_d1_ReferenceNo','#MF_d1_JourneyPurpose','#MF_d1_TravelType','#MF_d1_TravelPlace','#MF_d1_IsAdvanceRequired','#MF_d1_PaymentRemittenceTo','#MF_d1_BeneficiaryName','#MF_d1_AccountNo','#MF_d1_BankName','#MF_d1_IFSCCode',#MF_d1_BankDocument,'#MF_d1_TransactionNo','#MF_d1_TransactionDate',#MF_d1_TotalAmount,#MF_d1_AdvanceAmount,'#MF_d1_TravelStatus',#MF_d1_TSAmount,'#MF_d1_TSStatus','#MF_d1_PITransactionNo','#MF_d1_PITransactionDate','#MF_d1_TSTransactionNo','#MF_d1_TSTransactionDate',#MF_d1_CreatedBy,'#MF_d1_CreatedOn'");

var querySource9E8F15769AC145E1A0ACD79DD7D684BC =GetQueryExpressionDataSource("9E8F1576-9AC1-45E1-A0AC-D79DD7D684BC");
Dictionary<short,object> result9E8F15769AC145E1A0ACD79DD7D684BC=iSpace.ExecuteQuery(querySource9E8F15769AC145E1A0ACD79DD7D684BC,@"EXEC InnovaceNoCode..[FormSave_8EC3FC2B-F5B6-4077-8C73-B83F5D859FC4]   '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','d4b10079-b7a6-40d1-94ec-eb886005f33a','" + ISpace["MF_d1_TravelAdvanceID"].Value + @"','" + ISpace["MF_d1_EmployeeBasicInfoId"].Value + @"','" + ISpace["MF_d1_ReferenceNo"].Value + @"','" + ISpace["MF_d1_JourneyPurpose"].Value + @"','" + ISpace["MF_d1_TravelType"].Value + @"','" + ISpace["MF_d1_TravelPlace"].Value + @"','" + ISpace["MF_d1_IsAdvanceRequired"].Value + @"','" + ISpace["MF_d1_PaymentRemittenceTo"].Value + @"','" + ISpace["MF_d1_BeneficiaryName"].Value + @"','" + ISpace["MF_d1_AccountNo"].Value + @"','" + ISpace["MF_d1_BankName"].Value + @"','" + ISpace["MF_d1_IFSCCode"].Value + @"'," + ISpace["MF_d1_BankDocument"].Value + @",'" + ISpace["MF_d1_TransactionNo"].Value + @"','" + ISpace["MF_d1_TransactionDate"].Value + @"'," + ISpace["MF_d1_TotalAmount"].Value + @"," + ISpace["MF_d1_AdvanceAmount"].Value + @",'" + ISpace["MF_d1_TravelStatus"].Value + @"'," + ISpace["MF_d1_TSAmount"].Value + @",'" + ISpace["MF_d1_TSStatus"].Value + @"','" + ISpace["MF_d1_PITransactionNo"].Value + @"','" + ISpace["MF_d1_PITransactionDate"].Value + @"','" + ISpace["MF_d1_TSTransactionNo"].Value + @"','" + ISpace["MF_d1_TSTransactionDate"].Value + @"'," + ISpace["MF_d1_CreatedBy"].Value + @",'" + ISpace["MF_d1_CreatedOn"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource9E8F15769AC145E1A0ACD79DD7D684BC =GetQueryExpressionDataSource(""9E8F1576-9AC1-45E1-A0AC-D79DD7D684BC"");Dictionary<short,object> result9E8F15769AC145E1A0ACD79DD7D684BC=iSpace.ExecuteQuery(querySource9E8F15769AC145E1A0ACD79DD7D684BC,@""EXEC InnovaceNoCode..[FormSave_8EC3FC2B-F5B6-4077-8C73-B83F5D859FC4]   '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','d4b10079-b7a6-40d1-94ec-eb886005f33a','"" + ISpace[""MF_d1_TravelAdvanceID""].Value + @""','"" + ISpace[""MF_d1_EmployeeBasicInfoId""].Value + @""','"" + ISpace[""MF_d1_ReferenceNo""].Value + @""','"" + ISpace[""MF_d1_JourneyPurpose""].Value + @""','"" + ISpace[""MF_d1_TravelType""].Value + @""','"" + ISpace[""MF_d1_TravelPlace""].Value + @""','"" + ISpace[""MF_d1_IsAdvanceRequired""].Value + @""','"" + ISpace[""MF_d1_PaymentRemittenceTo""].Value + @""','"" + ISpace[""MF_d1_BeneficiaryName""].Value + @""','"" + ISpace[""MF_d1_AccountNo""].Value + @""','"" + ISpace[""MF_d1_BankName""].Value + @""','"" + ISpace[""MF_d1_IFSCCode""].Value + @""',"" + ISpace[""MF_d1_BankDocument""].Value + @"",'"" + ISpace[""MF_d1_TransactionNo""].Value + @""','"" + ISpace[""MF_d1_TransactionDate""].Value + @""',"" + ISpace[""MF_d1_TotalAmount""].Value + @"","" + ISpace[""MF_d1_AdvanceAmount""].Value + @"",'"" + ISpace[""MF_d1_TravelStatus""].Value + @""',"" + ISpace[""MF_d1_TSAmount""].Value + @"",'"" + ISpace[""MF_d1_TSStatus""].Value + @""','"" + ISpace[""MF_d1_PITransactionNo""].Value + @""','"" + ISpace[""MF_d1_PITransactionDate""].Value + @""','"" + ISpace[""MF_d1_TSTransactionNo""].Value + @""','"" + ISpace[""MF_d1_TSTransactionDate""].Value + @""',"" + ISpace[""MF_d1_CreatedBy""].Value + @"",'"" + ISpace[""MF_d1_CreatedOn""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result9E8F15769AC145E1A0ACD79DD7D684BC!=null) && (result9E8F15769AC145E1A0ACD79DD7D684BC.Count!=0))
{
if(result9E8F15769AC145E1A0ACD79DD7D684BC.ContainsKey(0))
ISpace["ExecutionMessage"].Value = result9E8F15769AC145E1A0ACD79DD7D684BC[0];
}
else{
ISpace["ExecutionMessage"].Value = null;
}
base.WriteDebugInfo(@"EXEC InnovaceNoCode..[GridSave_7DC7A3E8-9FDF-4C75-9F83-FEC89BA524E4]   '@@gv_InstanceId','@@gv_ActivityMapId','7DC7A3E8-9FDF-4C75-9F83-FEC89BA524E4'");

var querySourceBF7DF060B80648CD84DA4602D42A2BCE =GetQueryExpressionDataSource("BF7DF060-B806-48CD-84DA-4602D42A2BCE");
Dictionary<short,object> resultBF7DF060B80648CD84DA4602D42A2BCE=iSpace.ExecuteQuery(querySourceBF7DF060B80648CD84DA4602D42A2BCE,@"EXEC InnovaceNoCode..[GridSave_7DC7A3E8-9FDF-4C75-9F83-FEC89BA524E4]   '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','7DC7A3E8-9FDF-4C75-9F83-FEC89BA524E4'",false);

base.WriteDebugInfo(@"var querySourceBF7DF060B80648CD84DA4602D42A2BCE =GetQueryExpressionDataSource(""BF7DF060-B806-48CD-84DA-4602D42A2BCE"");Dictionary<short,object> resultBF7DF060B80648CD84DA4602D42A2BCE=iSpace.ExecuteQuery(querySourceBF7DF060B80648CD84DA4602D42A2BCE,@""EXEC InnovaceNoCode..[GridSave_7DC7A3E8-9FDF-4C75-9F83-FEC89BA524E4]   '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','7DC7A3E8-9FDF-4C75-9F83-FEC89BA524E4'"",false);");
base.WriteDebugInfo(@"");

if((resultBF7DF060B80648CD84DA4602D42A2BCE!=null) && (resultBF7DF060B80648CD84DA4602D42A2BCE.Count!=0))
{
if(resultBF7DF060B80648CD84DA4602D42A2BCE.ContainsKey(0))
ISpace["ExecutionMessage"].Value = resultBF7DF060B80648CD84DA4602D42A2BCE[0];
}
else{
ISpace["ExecutionMessage"].Value = null;
}
base.WriteDebugInfo(@"EXEC InnovaceNoCode..[GridSave_CDCED39A-D76C-4204-9A70-C637DD092E54]   '@@gv_InstanceId','@@gv_ActivityMapId','CDCED39A-D76C-4204-9A70-C637DD092E54'");

var querySource3BE59B804D734B3895BC19A4B6DABBE8 =GetQueryExpressionDataSource("3BE59B80-4D73-4B38-95BC-19A4B6DABBE8");
Dictionary<short,object> result3BE59B804D734B3895BC19A4B6DABBE8=iSpace.ExecuteQuery(querySource3BE59B804D734B3895BC19A4B6DABBE8,@"EXEC InnovaceNoCode..[GridSave_CDCED39A-D76C-4204-9A70-C637DD092E54]   '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','CDCED39A-D76C-4204-9A70-C637DD092E54'",false);

base.WriteDebugInfo(@"var querySource3BE59B804D734B3895BC19A4B6DABBE8 =GetQueryExpressionDataSource(""3BE59B80-4D73-4B38-95BC-19A4B6DABBE8"");Dictionary<short,object> result3BE59B804D734B3895BC19A4B6DABBE8=iSpace.ExecuteQuery(querySource3BE59B804D734B3895BC19A4B6DABBE8,@""EXEC InnovaceNoCode..[GridSave_CDCED39A-D76C-4204-9A70-C637DD092E54]   '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','CDCED39A-D76C-4204-9A70-C637DD092E54'"",false);");
base.WriteDebugInfo(@"");

if((result3BE59B804D734B3895BC19A4B6DABBE8!=null) && (result3BE59B804D734B3895BC19A4B6DABBE8.Count!=0))
{
if(result3BE59B804D734B3895BC19A4B6DABBE8.ContainsKey(0))
ISpace["ExecutionMessage"].Value = result3BE59B804D734B3895BC19A4B6DABBE8[0];
}
else{
ISpace["ExecutionMessage"].Value = null;
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_pfa_delete (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"PFA_Delete-OnClick");
ISpace["PFM_FundDetailsId"].Value=ISpace["PFA_FundDetailsId"].Value;
base.WriteDebugInfo(@"ISpace[""PFM_FundDetailsId""].Value=ISpace[""PFA_FundDetailsId""].Value;");
ISpace["UI_DeleteDialog"].ShowDialog=true;;
base.WriteDebugInfo(@"ISpace[""UI_DeleteDialog""].ShowDialog=true;;");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_pfa_widgetsubmit (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"PFA_WidgetSubmit-OnClick");
base.WriteDebugInfo(@"EXEC [UpsertProjectFundAllocation] '@@gv_InstanceId','@@gv_ProcessMapId','@@gv_UserId'");

var querySource9DE0ADA2B5014551A0BE56A4D7F08F5F =GetQueryExpressionDataSource("9DE0ADA2-B501-4551-A0BE-56A4D7F08F5F");
Dictionary<short,object> result9DE0ADA2B5014551A0BE56A4D7F08F5F=iSpace.ExecuteQuery(querySource9DE0ADA2B5014551A0BE56A4D7F08F5F,@"EXEC [UpsertProjectFundAllocation] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','" + ISpace["gv_userid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource9DE0ADA2B5014551A0BE56A4D7F08F5F =GetQueryExpressionDataSource(""9DE0ADA2-B501-4551-A0BE-56A4D7F08F5F"");Dictionary<short,object> result9DE0ADA2B5014551A0BE56A4D7F08F5F=iSpace.ExecuteQuery(querySource9DE0ADA2B5014551A0BE56A4D7F08F5F,@""EXEC [UpsertProjectFundAllocation] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','"" + ISpace[""gv_userid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result9DE0ADA2B5014551A0BE56A4D7F08F5F!=null) && (result9DE0ADA2B5014551A0BE56A4D7F08F5F.Count!=0))
{
if(result9DE0ADA2B5014551A0BE56A4D7F08F5F.ContainsKey(0))
ISpace["PFM_ErrId"].Value = result9DE0ADA2B5014551A0BE56A4D7F08F5F[0];
}
else{
ISpace["PFM_ErrId"].Value = null;
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_fwfm_save (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"FWFM_Save-OnClick");
base.WriteDebugInfo(@"EXEC [Upsert60e821d0-153e-94bb-1fef-2594b78625bd] '@@gv_InstanceId','@@gv_ProcessMapId','#FWFM_FundDetailsId','#FWFM_FundType','#FWFM_ProjectNo','#FWFM_BudgetHead','#FWFM_Amount'");

var querySource632D2764BF8749D08258386D3AF9081A =GetQueryExpressionDataSource("632D2764-BF87-49D0-8258-386D3AF9081A");
Dictionary<short,object> result632D2764BF8749D08258386D3AF9081A=iSpace.ExecuteQuery(querySource632D2764BF8749D08258386D3AF9081A,@"EXEC [Upsert60e821d0-153e-94bb-1fef-2594b78625bd] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','" + ISpace["FWFM_FundDetailsId"].Value + @"','" + ISpace["FWFM_FundType"].Value + @"','" + ISpace["FWFM_ProjectNo"].Value + @"','" + ISpace["FWFM_BudgetHead"].Value + @"','" + ISpace["FWFM_Amount"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource632D2764BF8749D08258386D3AF9081A =GetQueryExpressionDataSource(""632D2764-BF87-49D0-8258-386D3AF9081A"");Dictionary<short,object> result632D2764BF8749D08258386D3AF9081A=iSpace.ExecuteQuery(querySource632D2764BF8749D08258386D3AF9081A,@""EXEC [Upsert60e821d0-153e-94bb-1fef-2594b78625bd] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','"" + ISpace[""FWFM_FundDetailsId""].Value + @""','"" + ISpace[""FWFM_FundType""].Value + @""','"" + ISpace[""FWFM_ProjectNo""].Value + @""','"" + ISpace[""FWFM_BudgetHead""].Value + @""','"" + ISpace[""FWFM_Amount""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result632D2764BF8749D08258386D3AF9081A!=null) && (result632D2764BF8749D08258386D3AF9081A.Count!=0))
{
if(result632D2764BF8749D08258386D3AF9081A.ContainsKey(0))
ISpace["PFM_ErrId"].Value = result632D2764BF8749D08258386D3AF9081A[0];
if(result632D2764BF8749D08258386D3AF9081A.ContainsKey(1))
ISpace["PFM_ErrMsg"].Value = result632D2764BF8749D08258386D3AF9081A[1];
}
else{
ISpace["PFM_ErrId"].Value = null;ISpace["PFM_ErrMsg"].Value = null;
}
ISpace["Message"].Value=String.Format(@"{0}",ISpace["PFM_ErrMsg"].Value);
base.WriteDebugInfo(@"ISpace[""Message""].Value=String.Format(@""{0}"",ISpace[""PFM_ErrMsg""].Value);");
if(ISpace["PFM_ErrId"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""PFM_ErrId""].Value==1)");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["FWFM_FundDetailsId"].Value="";
base.WriteDebugInfo(@"ISpace[""FWFM_FundDetailsId""].Value="""";");
ISpace["FWFM_FundType"].Value="";
base.WriteDebugInfo(@"ISpace[""FWFM_FundType""].Value="""";");
ISpace["FWFM_ProjectNo"].Value="";
base.WriteDebugInfo(@"ISpace[""FWFM_ProjectNo""].Value="""";");
ISpace["FWFM_BudgetHead"].Value="";
base.WriteDebugInfo(@"ISpace[""FWFM_BudgetHead""].Value="""";");
ISpace["FWFM_Amount"].Value=0;
base.WriteDebugInfo(@"ISpace[""FWFM_Amount""].Value=0;");
}

var querySourceBBB0DE0581D3467BB16FB045502F9D29 =GetQueryExpressionDataSource("BBB0DE05-81D3-467B-B16F-B045502F9D29");

DataTable resultBBB0DE0581D3467BB16FB045502F9D29=iSpace.SetGridDataSource(querySourceBBB0DE0581D3467BB16FB045502F9D29, _objectFactory.GetGridRPP("MG_FundAllocation"),@"Exec [Get60e821d0-153e-94bb-1fef-2594b78625bd] '" + ISpace["gv_instanceid"].Value + @"'");

iSpace.InsertGridBindDetails("MG_FundAllocation","11",querySourceBBB0DE0581D3467BB16FB045502F9D29,"Exec [Get60e821d0-153e-94bb-1fef-2594b78625bd] '" + ISpace["gv_instanceid"].Value + @"'",_objectFactory.GetGridRPP("MG_FundAllocation"));

base.WriteDebugInfo(@"var querySourceBBB0DE0581D3467BB16FB045502F9D29 =GetQueryExpressionDataSource(""BBB0DE05-81D3-467B-B16F-B045502F9D29"");DataTable resultBBB0DE0581D3467BB16FB045502F9D29=iSpace.SetGridDataSource(querySourceBBB0DE0581D3467BB16FB045502F9D29, _objectFactory.GetGridRPP(""MG_FundAllocation""),@""Exec [Get60e821d0-153e-94bb-1fef-2594b78625bd] '"" + ISpace[""gv_instanceid""].Value + @""'"");iSpace.InsertGridBindDetails(""MG_FundAllocation"",""11"",querySourceBBB0DE0581D3467BB16FB045502F9D29,""Exec [Get60e821d0-153e-94bb-1fef-2594b78625bd] '"" + ISpace[""gv_instanceid""].Value + @""'"",_objectFactory.GetGridRPP(""MG_FundAllocation""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result58EFF32DD0CA44648DB768C9010FA8B0=acdataIspaceAF9613E108AC4C90B5AD8A0678BD0D92.GetQueryExpressionBindings("58EFF32D-D0CA-4464-8DB7-68C9010FA8B0");
iSpace.SetGridData(resultBBB0DE0581D3467BB16FB045502F9D29,result58EFF32DD0CA44648DB768C9010FA8B0,"MG_FundAllocation",ref ISpace);
iSpace.UpdateGridBindDetails("MG_FundAllocation",result58EFF32DD0CA44648DB768C9010FA8B0);
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_edit_actualadvancedetails (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Edit_ActualAdvanceDetails-OnClick");
ISpace["growid"].Value=ISpace["ActualAdvanceDetails_RowId"].Value;
base.WriteDebugInfo(@"ISpace[""growid""].Value=ISpace[""ActualAdvanceDetails_RowId""].Value;");
base.WriteDebugInfo(@"EXEC [LoadFormGridDataCDCED39A-D76C-4204-9A70-C637DD092E54] '@@gv_InstanceId','@@gv_ActivityMapId','CDCED39A-D76C-4204-9A70-C637DD092E54','#growid',#ActualAdvanceDetails_Sequence");

var querySource1ECA577C1B9946409E4893B3CA7B355F =GetQueryExpressionDataSource("1ECA577C-1B99-4640-9E48-93B3CA7B355F");
Dictionary<short,object> result1ECA577C1B9946409E4893B3CA7B355F=iSpace.ExecuteQuery(querySource1ECA577C1B9946409E4893B3CA7B355F,@"EXEC [LoadFormGridDataCDCED39A-D76C-4204-9A70-C637DD092E54] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','CDCED39A-D76C-4204-9A70-C637DD092E54','" + ISpace["growid"].Value + @"'," + ISpace["ActualAdvanceDetails_Sequence"].Value + @"",false);

base.WriteDebugInfo(@"var querySource1ECA577C1B9946409E4893B3CA7B355F =GetQueryExpressionDataSource(""1ECA577C-1B99-4640-9E48-93B3CA7B355F"");Dictionary<short,object> result1ECA577C1B9946409E4893B3CA7B355F=iSpace.ExecuteQuery(querySource1ECA577C1B9946409E4893B3CA7B355F,@""EXEC [LoadFormGridDataCDCED39A-D76C-4204-9A70-C637DD092E54] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','CDCED39A-D76C-4204-9A70-C637DD092E54','"" + ISpace[""growid""].Value + @""',"" + ISpace[""ActualAdvanceDetails_Sequence""].Value + @"""",false);");
base.WriteDebugInfo(@"EXEC [LoadFormGridDataCDCED39A-D76C-4204-9A70-C637DD092E54] '@@gv_InstanceId','@@gv_ActivityMapId','CDCED39A-D76C-4204-9A70-C637DD092E54','#growid',#ActualAdvanceDetails_Sequence");

if((result1ECA577C1B9946409E4893B3CA7B355F!=null) && (result1ECA577C1B9946409E4893B3CA7B355F.Count!=0))
{
if(result1ECA577C1B9946409E4893B3CA7B355F.ContainsKey(3))
ISpace["MFG_d2_DepartureDate"].Value = result1ECA577C1B9946409E4893B3CA7B355F[3];
if(result1ECA577C1B9946409E4893B3CA7B355F.ContainsKey(15))
ISpace["MFG_d2_UpdatedOn"].Value = result1ECA577C1B9946409E4893B3CA7B355F[15];
if(result1ECA577C1B9946409E4893B3CA7B355F.ContainsKey(6))
ISpace["MFG_d2_ArrivalDate"].Value = result1ECA577C1B9946409E4893B3CA7B355F[6];
if(result1ECA577C1B9946409E4893B3CA7B355F.ContainsKey(14))
ISpace["MFG_d2_UpdatedBy"].Value = result1ECA577C1B9946409E4893B3CA7B355F[14];
if(result1ECA577C1B9946409E4893B3CA7B355F.ContainsKey(10))
ISpace["MFG_d2_Road"].Value = result1ECA577C1B9946409E4893B3CA7B355F[10];
if(result1ECA577C1B9946409E4893B3CA7B355F.ContainsKey(13))
ISpace["MFG_d2_IsTravelRequest"].Value = result1ECA577C1B9946409E4893B3CA7B355F[13];
if(result1ECA577C1B9946409E4893B3CA7B355F.ContainsKey(12))
ISpace["MFG_d2_Amount"].Value = result1ECA577C1B9946409E4893B3CA7B355F[12];
if(result1ECA577C1B9946409E4893B3CA7B355F.ContainsKey(2))
ISpace["MFG_d2_Departure"].Value = result1ECA577C1B9946409E4893B3CA7B355F[2];
if(result1ECA577C1B9946409E4893B3CA7B355F.ContainsKey(4))
ISpace["MFG_d2_DepartureTime"].Value = result1ECA577C1B9946409E4893B3CA7B355F[4];
if(result1ECA577C1B9946409E4893B3CA7B355F.ContainsKey(7))
ISpace["MFG_d2_ArrivalTime"].Value = result1ECA577C1B9946409E4893B3CA7B355F[7];
if(result1ECA577C1B9946409E4893B3CA7B355F.ContainsKey(8))
ISpace["MFG_d2_ModeofJourney"].Value = result1ECA577C1B9946409E4893B3CA7B355F[8];
if(result1ECA577C1B9946409E4893B3CA7B355F.ContainsKey(0))
ISpace["MFG_d2_TADetailsID"].Value = result1ECA577C1B9946409E4893B3CA7B355F[0];
if(result1ECA577C1B9946409E4893B3CA7B355F.ContainsKey(11))
ISpace["MFG_d2_PNRNo"].Value = result1ECA577C1B9946409E4893B3CA7B355F[11];
if(result1ECA577C1B9946409E4893B3CA7B355F.ContainsKey(9))
ISpace["MFG_d2_JourneyClass"].Value = result1ECA577C1B9946409E4893B3CA7B355F[9];
if(result1ECA577C1B9946409E4893B3CA7B355F.ContainsKey(5))
ISpace["MFG_d2_Arrival"].Value = result1ECA577C1B9946409E4893B3CA7B355F[5];
if(result1ECA577C1B9946409E4893B3CA7B355F.ContainsKey(1))
ISpace["MFG_d2_TravelAdvanceID"].Value = result1ECA577C1B9946409E4893B3CA7B355F[1];
}
else{
ISpace["MFG_d2_DepartureDate"].Value = null;ISpace["MFG_d2_UpdatedOn"].Value = null;ISpace["MFG_d2_ArrivalDate"].Value = null;ISpace["MFG_d2_UpdatedBy"].Value = null;ISpace["MFG_d2_Road"].Value = null;ISpace["MFG_d2_IsTravelRequest"].Value = null;ISpace["MFG_d2_Amount"].Value = null;ISpace["MFG_d2_Departure"].Value = null;ISpace["MFG_d2_DepartureTime"].Value = null;ISpace["MFG_d2_ArrivalTime"].Value = null;ISpace["MFG_d2_ModeofJourney"].Value = null;ISpace["MFG_d2_TADetailsID"].Value = null;ISpace["MFG_d2_PNRNo"].Value = null;ISpace["MFG_d2_JourneyClass"].Value = null;ISpace["MFG_d2_Arrival"].Value = null;ISpace["MFG_d2_TravelAdvanceID"].Value = null;
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
public override void ExecuteMethod
	(string methodName, string elementName,
		ref Dictionary<string, ServiceElementData> dfsParam)
{
	if(methodName.ToLower().Equals("formonload"))
{
			SubscribeFormEvents_root(ref dfsParam);
}
	if(methodName.ToLower().Equals("onchange"))
{
		if(elementName.ToLower().Equals("fwfm_fundtype"))
    {
    			SubscribeElementEvents_fwfm_fundtype(ref dfsParam);
    }
		if(elementName.ToLower().Equals("wmf_moveto"))
    {
    			SubscribeElementEvents_wmf_moveto(ref dfsParam);
    }
}
	if(methodName.ToLower().Equals("onclick"))
{
		if(elementName.ToLower().Equals("pfm_no"))
{
			SubscribeElementEvents_pfm_no(ref dfsParam);
}
		if(elementName.ToLower().Equals("save_actualexpensedetails"))
{
			SubscribeElementEvents_save_actualexpensedetails(ref dfsParam);
}
		if(elementName.ToLower().Equals("edit_actualexpensedetails"))
{
			SubscribeElementEvents_edit_actualexpensedetails(ref dfsParam);
}
		if(elementName.ToLower().Equals("pfa_edit"))
{
			SubscribeElementEvents_pfa_edit(ref dfsParam);
}
		if(elementName.ToLower().Equals("save_actualadvancedetails"))
{
			SubscribeElementEvents_save_actualadvancedetails(ref dfsParam);
}
		if(elementName.ToLower().Equals("pfm_yes"))
{
			SubscribeElementEvents_pfm_yes(ref dfsParam);
}
		if(elementName.ToLower().Equals("fwmf_availablebudget"))
{
			SubscribeElementEvents_fwmf_availablebudget(ref dfsParam);
}
		if(elementName.ToLower().Equals("submitform"))
{
			SubscribeElementEvents_submitform(ref dfsParam);
}
		if(elementName.ToLower().Equals("pfa_delete"))
{
			SubscribeElementEvents_pfa_delete(ref dfsParam);
}
		if(elementName.ToLower().Equals("pfa_widgetsubmit"))
{
			SubscribeElementEvents_pfa_widgetsubmit(ref dfsParam);
}
		if(elementName.ToLower().Equals("fwfm_save"))
{
			SubscribeElementEvents_fwfm_save(ref dfsParam);
}
		if(elementName.ToLower().Equals("edit_actualadvancedetails"))
{
			SubscribeElementEvents_edit_actualadvancedetails(ref dfsParam);
}
}
}
}
}
namespace CPS.Proof.DFSExtension
{
}
namespace CPS.Proof.DFSExtension
{
}
namespace CPS.Proof.DFSExtension
{
}
namespace CPS.Proof.DFSExtension
{
}
namespace CPS.Proof.DFSExtension
{
}
namespace CPS.Proof.DFSExtension
{
}

  







namespace CPS.Proof.DFSExtension
{
	
using System;
    using System.Collections.Generic;    
    using System.Text;	
    using System.Linq;	


	public partial class AcDataISpaceAF9613E108AC4C90B5AD8A0678BD0D92  : ExtensionActivityBase
	{		
		
		
		private Dictionary<string,  List<Triplet<string, short, short?>>> queryExpressionBindings = 
											new Dictionary<string,  List<Triplet<string, short, short?>>>
		{
							{"4271EF38-5713-4A9A-B239-98C593F3257F", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("ActualAdvanceDetails_RowId",16,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_Amount",12,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_Arrival",5,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_ArrivalDate",6,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_ArrivalTime",7,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_Departure",2,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_DepartureDate",3,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_DepartureTime",4,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_IsTravelRequest",13,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_JourneyClass",9,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_ModeofJourney",8,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_PNRNo",11,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_Road",10,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_TADetailsID",0,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_TravelAdvanceID",1,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_UpdatedBy",14,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_UpdatedOn",15,
														   -1),
								}
			},
							{"57CC29FA-86C9-4827-80CF-A0D013218FC6", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("ActualExpenseDetails_RowId",10,
														   -1),
								   new Triplet<string, short, short?>("MG_d3_Amount",4,
														   -1),
								   new Triplet<string, short, short?>("MG_d3_ExpenditureType",7,
														   -1),
								   new Triplet<string, short, short?>("MG_d3_ExpenditureTypeID",0,
														   -1),
								   new Triplet<string, short, short?>("MG_d3_FromDate",2,
														   -1),
								   new Triplet<string, short, short?>("MG_d3_IsTravelRequest",9,
														   -1),
								   new Triplet<string, short, short?>("MG_d3_OtherExpenditureType",8,
														   -1),
								   new Triplet<string, short, short?>("MG_d3_ToDate",3,
														   -1),
								   new Triplet<string, short, short?>("MG_d3_TravelAdvanceID",1,
														   -1),
								   new Triplet<string, short, short?>("MG_d3_UpdatedBy",5,
														   -1),
								   new Triplet<string, short, short?>("MG_d3_UpdatedOn",6,
														   -1),
								}
			},
							{"58EFF32D-D0CA-4464-8DB7-68C9010FA8B0", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_FundAllocation_RowId",3,
														   -1),
								   new Triplet<string, short, short?>("PFA_Amount",11,
														   -1),
								   new Triplet<string, short, short?>("PFA_BudgetHead",9,
														   -1),
								   new Triplet<string, short, short?>("PFA_BudgetHeadValue",10,
														   -1),
								   new Triplet<string, short, short?>("PFA_FundDetailsId",12,
														   -1),
								   new Triplet<string, short, short?>("PFA_FundType",5,
														   -1),
								   new Triplet<string, short, short?>("PFA_FundTypeValue",6,
														   -1),
								   new Triplet<string, short, short?>("PFA_ProjectNo",7,
														   -1),
								   new Triplet<string, short, short?>("PFA_ProjectNoValue",8,
														   -1),
								}
			},
							{"63480263-2BCB-4FF0-B3EB-6CDE92E05563", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("ActualAdvanceDetails_RowId",16,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_Amount",12,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_Arrival",5,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_ArrivalDate",6,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_ArrivalTime",7,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_Departure",2,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_DepartureDate",3,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_DepartureTime",4,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_IsTravelRequest",13,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_JourneyClass",9,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_ModeofJourney",8,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_PNRNo",11,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_Road",10,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_TADetailsID",0,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_TravelAdvanceID",1,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_UpdatedBy",14,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_UpdatedOn",15,
														   -1),
								}
			},
							{"66C99356-19C8-46F3-AA3E-E02BDAE5E174", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("ActualAdvanceDetails_RowId",16,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_Amount",12,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_Arrival",5,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_ArrivalDate",6,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_ArrivalTime",7,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_Departure",2,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_DepartureDate",3,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_DepartureTime",4,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_IsTravelRequest",13,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_JourneyClass",9,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_ModeofJourney",8,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_PNRNo",11,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_Road",10,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_TADetailsID",0,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_TravelAdvanceID",1,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_UpdatedBy",14,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_UpdatedOn",15,
														   -1),
								}
			},
							{"7C43A884-FC31-43E2-A4AD-E41C918D2F43", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("ActualExpenseDetails_RowId",10,
														   -1),
								   new Triplet<string, short, short?>("MG_d3_Amount",4,
														   -1),
								   new Triplet<string, short, short?>("MG_d3_ExpenditureType",7,
														   -1),
								   new Triplet<string, short, short?>("MG_d3_ExpenditureTypeID",0,
														   -1),
								   new Triplet<string, short, short?>("MG_d3_FromDate",2,
														   -1),
								   new Triplet<string, short, short?>("MG_d3_IsTravelRequest",9,
														   -1),
								   new Triplet<string, short, short?>("MG_d3_OtherExpenditureType",8,
														   -1),
								   new Triplet<string, short, short?>("MG_d3_ToDate",3,
														   -1),
								   new Triplet<string, short, short?>("MG_d3_TravelAdvanceID",1,
														   -1),
								   new Triplet<string, short, short?>("MG_d3_UpdatedBy",5,
														   -1),
								   new Triplet<string, short, short?>("MG_d3_UpdatedOn",6,
														   -1),
								}
			},
							{"ACF88E57-2890-475B-BBB9-B9C97EFE1F7B", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("ActualExpenseDetails_RowId",10,
														   -1),
								   new Triplet<string, short, short?>("MG_d3_Amount",4,
														   -1),
								   new Triplet<string, short, short?>("MG_d3_ExpenditureType",7,
														   -1),
								   new Triplet<string, short, short?>("MG_d3_ExpenditureTypeID",0,
														   -1),
								   new Triplet<string, short, short?>("MG_d3_FromDate",2,
														   -1),
								   new Triplet<string, short, short?>("MG_d3_IsTravelRequest",9,
														   -1),
								   new Triplet<string, short, short?>("MG_d3_OtherExpenditureType",8,
														   -1),
								   new Triplet<string, short, short?>("MG_d3_ToDate",3,
														   -1),
								   new Triplet<string, short, short?>("MG_d3_TravelAdvanceID",1,
														   -1),
								   new Triplet<string, short, short?>("MG_d3_UpdatedBy",5,
														   -1),
								   new Triplet<string, short, short?>("MG_d3_UpdatedOn",6,
														   -1),
								}
			},
							{"B30057A6-9D73-42DA-99B8-FDC3205833DE", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("WMC_Comments",5,
														   -1),
								   new Triplet<string, short, short?>("WMC_DateofComments",4,
														   -1),
								   new Triplet<string, short, short?>("WMC_StepFrom",1,
														   -1),
								   new Triplet<string, short, short?>("WMC_StepTo",2,
														   -1),
								   new Triplet<string, short, short?>("WMC_User",3,
														   -1),
								}
			},
							{"CE2E8B0B-AC9E-4593-9832-8D67B5873077", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("PAB_Balance",6,
														   -1),
								   new Triplet<string, short, short?>("PAB_BudgetName",0,
														   -1),
								   new Triplet<string, short, short?>("PAB_Commitment",4,
														   -1),
								   new Triplet<string, short, short?>("PAB_RecievedAmount",3,
														   -1),
								   new Triplet<string, short, short?>("PAB_SanctionedAmount",1,
														   -1),
								   new Triplet<string, short, short?>("PAB_Spent",5,
														   -1),
								   new Triplet<string, short, short?>("PAB_YetToRecieve",2,
														   -1),
								}
			},
					};	

	

		private Dictionary<string,string> formVersionList =new Dictionary<string,string> 
		{
							{"5EC1F0DF-8850-4210-ADF0-87EF9BDCB734", "Medium"},
					};	

		
		private Dictionary<string,string> formVersionLayoutList =new Dictionary<string,string> 
		{
							{"6B8F7AC6-2945-472D-918B-7EE8EFEC9CFF", ""},
							{"E7CF988F-10DB-4E76-88DA-5380DC2D0B3C", ""},
							{"5EC1F0DF-8850-4210-ADF0-87EF9BDCB734", ""},
							{"67086EFC-9346-4452-9DEE-650784BB4279", ""},
							{"D79C1C00-199A-4018-99D5-F84A6EF2AD0D", ""},
							{"069F7E3F-8CBA-4933-93FC-F120509129D5", ""},
							{"95E81058-EB69-47A0-9308-7A1575999EF2", ""},
							{"5F920B82-7B74-4EE9-A3AF-B493DC082876", ""},
					};	

		

	
	
		
		
		public override  List<Triplet<string, short, short?>> GetQueryExpressionBindings(string expressionId)
		{
			if(string.IsNullOrWhiteSpace(expressionId))
            {
			  return null;				
            }


			if(queryExpressionBindings == null || queryExpressionBindings.Count <= 0)
				return null;

			return queryExpressionBindings[expressionId];
		}

		public override string GetValidFormVersionId(string formVersionId,ViewportTypes viewPort)
		{	
					
			 if(formVersionList == null || formVersionList.Count <= 0)
				return formVersionId;

			if (formVersionList.Count == 1)
                return formVersionList.FirstOrDefault().Key;  

			

			if ( !string.IsNullOrEmpty(formVersionId) &&  formVersionList.ContainsKey(formVersionId))
            {
                if (formVersionList.Any(x => x.Key == formVersionId && x.Value == viewPort.ToString()))
                    return formVersionId;
            }

			var fallback= new List<string>{"Mobile","Tab","Medium","Large"};

           switch (viewPort)
            {
                case ViewportTypes.Tab:
                    fallback = new List<string> { "Tab", "Mobile", "Medium", "Large" };
                    break;

                case ViewportTypes.Medium:
                    fallback = new List<string> { "Medium", "Tab", "Large", "Mobile" };
                    break;

                case ViewportTypes.Large:
                    fallback = new List<string> { "Large", "Medium", "Tab", "Mobile" };
                    break;
            }

           for (int i = 0; i < fallback.Count; i++)
           {
               if (formVersionList.Any(x => x.Value == fallback[i]))
                   return formVersionList.Where(x => x.Value == fallback[i]).Select(y => y.Key).FirstOrDefault();
           }

		   return formVersionId;
		}

	

		
		
		
		
		


	}

}
		
  







namespace CPS.Proof.DFSExtension
{
	
using System;
    using System.Collections.Generic;    
    using System.Text;	
    using System.Linq;	


	public partial class AcDataISpaceE3C608D9B66D466ABFC382B2D55B1808  : ExtensionActivityBase
	{		
		
		
		private Dictionary<string,  List<Triplet<string, short, short?>>> queryExpressionBindings = 
											new Dictionary<string,  List<Triplet<string, short, short?>>>
		{
							{"58EFF32D-D0CA-4464-8DB7-68C9010FA8B0", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_FundAllocation_RowId",3,
														   -1),
								   new Triplet<string, short, short?>("PFA_Amount",11,
														   -1),
								   new Triplet<string, short, short?>("PFA_BudgetHead",9,
														   -1),
								   new Triplet<string, short, short?>("PFA_BudgetHeadValue",10,
														   -1),
								   new Triplet<string, short, short?>("PFA_FundDetailsId",12,
														   -1),
								   new Triplet<string, short, short?>("PFA_FundType",5,
														   -1),
								   new Triplet<string, short, short?>("PFA_FundTypeValue",6,
														   -1),
								   new Triplet<string, short, short?>("PFA_ProjectNo",7,
														   -1),
								   new Triplet<string, short, short?>("PFA_ProjectNoValue",8,
														   -1),
								}
			},
							{"B30057A6-9D73-42DA-99B8-FDC3205833DE", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("WMC_Comments",5,
														   -1),
								   new Triplet<string, short, short?>("WMC_DateofComments",4,
														   -1),
								   new Triplet<string, short, short?>("WMC_StepFrom",1,
														   -1),
								   new Triplet<string, short, short?>("WMC_StepTo",2,
														   -1),
								   new Triplet<string, short, short?>("WMC_User",3,
														   -1),
								}
			},
							{"CE2E8B0B-AC9E-4593-9832-8D67B5873077", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("PAB_Balance",6,
														   -1),
								   new Triplet<string, short, short?>("PAB_BudgetName",0,
														   -1),
								   new Triplet<string, short, short?>("PAB_Commitment",4,
														   -1),
								   new Triplet<string, short, short?>("PAB_RecievedAmount",3,
														   -1),
								   new Triplet<string, short, short?>("PAB_SanctionedAmount",1,
														   -1),
								   new Triplet<string, short, short?>("PAB_Spent",5,
														   -1),
								   new Triplet<string, short, short?>("PAB_YetToRecieve",2,
														   -1),
								}
			},
					};	

	

		private Dictionary<string,string> formVersionList =new Dictionary<string,string> 
		{
							{"5EC1F0DF-8850-4210-ADF0-87EF9BDCB734", "Medium"},
					};	

		
		private Dictionary<string,string> formVersionLayoutList =new Dictionary<string,string> 
		{
							{"6B8F7AC6-2945-472D-918B-7EE8EFEC9CFF", ""},
							{"E7CF988F-10DB-4E76-88DA-5380DC2D0B3C", ""},
							{"5EC1F0DF-8850-4210-ADF0-87EF9BDCB734", ""},
							{"67086EFC-9346-4452-9DEE-650784BB4279", ""},
							{"D79C1C00-199A-4018-99D5-F84A6EF2AD0D", ""},
							{"069F7E3F-8CBA-4933-93FC-F120509129D5", ""},
							{"95E81058-EB69-47A0-9308-7A1575999EF2", ""},
							{"5F920B82-7B74-4EE9-A3AF-B493DC082876", ""},
					};	

		

	
	
		
		
		public override  List<Triplet<string, short, short?>> GetQueryExpressionBindings(string expressionId)
		{
			if(string.IsNullOrWhiteSpace(expressionId))
            {
			  return null;				
            }


			if(queryExpressionBindings == null || queryExpressionBindings.Count <= 0)
				return null;

			return queryExpressionBindings[expressionId];
		}

		public override string GetValidFormVersionId(string formVersionId,ViewportTypes viewPort)
		{	
					
			 if(formVersionList == null || formVersionList.Count <= 0)
				return formVersionId;

			if (formVersionList.Count == 1)
                return formVersionList.FirstOrDefault().Key;  

			

			if ( !string.IsNullOrEmpty(formVersionId) &&  formVersionList.ContainsKey(formVersionId))
            {
                if (formVersionList.Any(x => x.Key == formVersionId && x.Value == viewPort.ToString()))
                    return formVersionId;
            }

			var fallback= new List<string>{"Mobile","Tab","Medium","Large"};

           switch (viewPort)
            {
                case ViewportTypes.Tab:
                    fallback = new List<string> { "Tab", "Mobile", "Medium", "Large" };
                    break;

                case ViewportTypes.Medium:
                    fallback = new List<string> { "Medium", "Tab", "Large", "Mobile" };
                    break;

                case ViewportTypes.Large:
                    fallback = new List<string> { "Large", "Medium", "Tab", "Mobile" };
                    break;
            }

           for (int i = 0; i < fallback.Count; i++)
           {
               if (formVersionList.Any(x => x.Value == fallback[i]))
                   return formVersionList.Where(x => x.Value == fallback[i]).Select(y => y.Key).FirstOrDefault();
           }

		   return formVersionId;
		}

	

		
		
		
		
		


	}

}
		
  







namespace CPS.Proof.DFSExtension
{
	
using System;
    using System.Collections.Generic;    
    using System.Text;	
    using System.Linq;	


	public partial class AcDataISpaceD17A8A483A494A9F93C09E53E542D74A  : ExtensionActivityBase
	{		
		
		
		private Dictionary<string,  List<Triplet<string, short, short?>>> queryExpressionBindings = 
											new Dictionary<string,  List<Triplet<string, short, short?>>>
		{
							{"58EFF32D-D0CA-4464-8DB7-68C9010FA8B0", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_FundAllocation_RowId",3,
														   -1),
								   new Triplet<string, short, short?>("PFA_Amount",11,
														   -1),
								   new Triplet<string, short, short?>("PFA_BudgetHead",9,
														   -1),
								   new Triplet<string, short, short?>("PFA_BudgetHeadValue",10,
														   -1),
								   new Triplet<string, short, short?>("PFA_FundDetailsId",12,
														   -1),
								   new Triplet<string, short, short?>("PFA_FundType",5,
														   -1),
								   new Triplet<string, short, short?>("PFA_FundTypeValue",6,
														   -1),
								   new Triplet<string, short, short?>("PFA_ProjectNo",7,
														   -1),
								   new Triplet<string, short, short?>("PFA_ProjectNoValue",8,
														   -1),
								}
			},
							{"B30057A6-9D73-42DA-99B8-FDC3205833DE", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("WMC_Comments",5,
														   -1),
								   new Triplet<string, short, short?>("WMC_DateofComments",4,
														   -1),
								   new Triplet<string, short, short?>("WMC_StepFrom",1,
														   -1),
								   new Triplet<string, short, short?>("WMC_StepTo",2,
														   -1),
								   new Triplet<string, short, short?>("WMC_User",3,
														   -1),
								}
			},
							{"CE2E8B0B-AC9E-4593-9832-8D67B5873077", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("PAB_Balance",6,
														   -1),
								   new Triplet<string, short, short?>("PAB_BudgetName",0,
														   -1),
								   new Triplet<string, short, short?>("PAB_Commitment",4,
														   -1),
								   new Triplet<string, short, short?>("PAB_RecievedAmount",3,
														   -1),
								   new Triplet<string, short, short?>("PAB_SanctionedAmount",1,
														   -1),
								   new Triplet<string, short, short?>("PAB_Spent",5,
														   -1),
								   new Triplet<string, short, short?>("PAB_YetToRecieve",2,
														   -1),
								}
			},
					};	

	

		private Dictionary<string,string> formVersionList =new Dictionary<string,string> 
		{
							{"5EC1F0DF-8850-4210-ADF0-87EF9BDCB734", "Medium"},
					};	

		
		private Dictionary<string,string> formVersionLayoutList =new Dictionary<string,string> 
		{
							{"6B8F7AC6-2945-472D-918B-7EE8EFEC9CFF", ""},
							{"E7CF988F-10DB-4E76-88DA-5380DC2D0B3C", ""},
							{"5EC1F0DF-8850-4210-ADF0-87EF9BDCB734", ""},
							{"67086EFC-9346-4452-9DEE-650784BB4279", ""},
							{"D79C1C00-199A-4018-99D5-F84A6EF2AD0D", ""},
							{"069F7E3F-8CBA-4933-93FC-F120509129D5", ""},
							{"95E81058-EB69-47A0-9308-7A1575999EF2", ""},
							{"5F920B82-7B74-4EE9-A3AF-B493DC082876", ""},
					};	

		

	
	
		
		
		public override  List<Triplet<string, short, short?>> GetQueryExpressionBindings(string expressionId)
		{
			if(string.IsNullOrWhiteSpace(expressionId))
            {
			  return null;				
            }


			if(queryExpressionBindings == null || queryExpressionBindings.Count <= 0)
				return null;

			return queryExpressionBindings[expressionId];
		}

		public override string GetValidFormVersionId(string formVersionId,ViewportTypes viewPort)
		{	
					
			 if(formVersionList == null || formVersionList.Count <= 0)
				return formVersionId;

			if (formVersionList.Count == 1)
                return formVersionList.FirstOrDefault().Key;  

			

			if ( !string.IsNullOrEmpty(formVersionId) &&  formVersionList.ContainsKey(formVersionId))
            {
                if (formVersionList.Any(x => x.Key == formVersionId && x.Value == viewPort.ToString()))
                    return formVersionId;
            }

			var fallback= new List<string>{"Mobile","Tab","Medium","Large"};

           switch (viewPort)
            {
                case ViewportTypes.Tab:
                    fallback = new List<string> { "Tab", "Mobile", "Medium", "Large" };
                    break;

                case ViewportTypes.Medium:
                    fallback = new List<string> { "Medium", "Tab", "Large", "Mobile" };
                    break;

                case ViewportTypes.Large:
                    fallback = new List<string> { "Large", "Medium", "Tab", "Mobile" };
                    break;
            }

           for (int i = 0; i < fallback.Count; i++)
           {
               if (formVersionList.Any(x => x.Value == fallback[i]))
                   return formVersionList.Where(x => x.Value == fallback[i]).Select(y => y.Key).FirstOrDefault();
           }

		   return formVersionId;
		}

	

		
		
		
		
		


	}

}
		
  







namespace CPS.Proof.DFSExtension
{
	
using System;
    using System.Collections.Generic;    
    using System.Text;	
    using System.Linq;	


	public partial class AcDataISpace009B2351D971439B95627308C30437A5  : ExtensionActivityBase
	{		
		
		
		private Dictionary<string,  List<Triplet<string, short, short?>>> queryExpressionBindings = 
											new Dictionary<string,  List<Triplet<string, short, short?>>>
		{
							{"58EFF32D-D0CA-4464-8DB7-68C9010FA8B0", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_FundAllocation_RowId",3,
														   -1),
								   new Triplet<string, short, short?>("PFA_Amount",11,
														   -1),
								   new Triplet<string, short, short?>("PFA_BudgetHead",9,
														   -1),
								   new Triplet<string, short, short?>("PFA_BudgetHeadValue",10,
														   -1),
								   new Triplet<string, short, short?>("PFA_FundDetailsId",12,
														   -1),
								   new Triplet<string, short, short?>("PFA_FundType",5,
														   -1),
								   new Triplet<string, short, short?>("PFA_FundTypeValue",6,
														   -1),
								   new Triplet<string, short, short?>("PFA_ProjectNo",7,
														   -1),
								   new Triplet<string, short, short?>("PFA_ProjectNoValue",8,
														   -1),
								}
			},
							{"B30057A6-9D73-42DA-99B8-FDC3205833DE", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("WMC_Comments",5,
														   -1),
								   new Triplet<string, short, short?>("WMC_DateofComments",4,
														   -1),
								   new Triplet<string, short, short?>("WMC_StepFrom",1,
														   -1),
								   new Triplet<string, short, short?>("WMC_StepTo",2,
														   -1),
								   new Triplet<string, short, short?>("WMC_User",3,
														   -1),
								}
			},
							{"CE2E8B0B-AC9E-4593-9832-8D67B5873077", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("PAB_Balance",6,
														   -1),
								   new Triplet<string, short, short?>("PAB_BudgetName",0,
														   -1),
								   new Triplet<string, short, short?>("PAB_Commitment",4,
														   -1),
								   new Triplet<string, short, short?>("PAB_RecievedAmount",3,
														   -1),
								   new Triplet<string, short, short?>("PAB_SanctionedAmount",1,
														   -1),
								   new Triplet<string, short, short?>("PAB_Spent",5,
														   -1),
								   new Triplet<string, short, short?>("PAB_YetToRecieve",2,
														   -1),
								}
			},
					};	

	

		private Dictionary<string,string> formVersionList =new Dictionary<string,string> 
		{
							{"5EC1F0DF-8850-4210-ADF0-87EF9BDCB734", "Medium"},
					};	

		
		private Dictionary<string,string> formVersionLayoutList =new Dictionary<string,string> 
		{
							{"6B8F7AC6-2945-472D-918B-7EE8EFEC9CFF", ""},
							{"E7CF988F-10DB-4E76-88DA-5380DC2D0B3C", ""},
							{"5EC1F0DF-8850-4210-ADF0-87EF9BDCB734", ""},
							{"67086EFC-9346-4452-9DEE-650784BB4279", ""},
							{"D79C1C00-199A-4018-99D5-F84A6EF2AD0D", ""},
							{"069F7E3F-8CBA-4933-93FC-F120509129D5", ""},
							{"95E81058-EB69-47A0-9308-7A1575999EF2", ""},
							{"5F920B82-7B74-4EE9-A3AF-B493DC082876", ""},
					};	

		

	
	
		
		
		public override  List<Triplet<string, short, short?>> GetQueryExpressionBindings(string expressionId)
		{
			if(string.IsNullOrWhiteSpace(expressionId))
            {
			  return null;				
            }


			if(queryExpressionBindings == null || queryExpressionBindings.Count <= 0)
				return null;

			return queryExpressionBindings[expressionId];
		}

		public override string GetValidFormVersionId(string formVersionId,ViewportTypes viewPort)
		{	
					
			 if(formVersionList == null || formVersionList.Count <= 0)
				return formVersionId;

			if (formVersionList.Count == 1)
                return formVersionList.FirstOrDefault().Key;  

			

			if ( !string.IsNullOrEmpty(formVersionId) &&  formVersionList.ContainsKey(formVersionId))
            {
                if (formVersionList.Any(x => x.Key == formVersionId && x.Value == viewPort.ToString()))
                    return formVersionId;
            }

			var fallback= new List<string>{"Mobile","Tab","Medium","Large"};

           switch (viewPort)
            {
                case ViewportTypes.Tab:
                    fallback = new List<string> { "Tab", "Mobile", "Medium", "Large" };
                    break;

                case ViewportTypes.Medium:
                    fallback = new List<string> { "Medium", "Tab", "Large", "Mobile" };
                    break;

                case ViewportTypes.Large:
                    fallback = new List<string> { "Large", "Medium", "Tab", "Mobile" };
                    break;
            }

           for (int i = 0; i < fallback.Count; i++)
           {
               if (formVersionList.Any(x => x.Value == fallback[i]))
                   return formVersionList.Where(x => x.Value == fallback[i]).Select(y => y.Key).FirstOrDefault();
           }

		   return formVersionId;
		}

	

		
		
		
		
		


	}

}
		
  







namespace CPS.Proof.DFSExtension
{
	
using System;
    using System.Collections.Generic;    
    using System.Text;	
    using System.Linq;	


	public partial class AcDataISpaceE8A1BB2D0BB9439B8967B3E1AB42CBDB  : ExtensionActivityBase
	{		
		
		
		private Dictionary<string,  List<Triplet<string, short, short?>>> queryExpressionBindings = 
											new Dictionary<string,  List<Triplet<string, short, short?>>>
		{
							{"58EFF32D-D0CA-4464-8DB7-68C9010FA8B0", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_FundAllocation_RowId",3,
														   -1),
								   new Triplet<string, short, short?>("PFA_Amount",11,
														   -1),
								   new Triplet<string, short, short?>("PFA_BudgetHead",9,
														   -1),
								   new Triplet<string, short, short?>("PFA_BudgetHeadValue",10,
														   -1),
								   new Triplet<string, short, short?>("PFA_FundDetailsId",12,
														   -1),
								   new Triplet<string, short, short?>("PFA_FundType",5,
														   -1),
								   new Triplet<string, short, short?>("PFA_FundTypeValue",6,
														   -1),
								   new Triplet<string, short, short?>("PFA_ProjectNo",7,
														   -1),
								   new Triplet<string, short, short?>("PFA_ProjectNoValue",8,
														   -1),
								}
			},
							{"B30057A6-9D73-42DA-99B8-FDC3205833DE", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("WMC_Comments",5,
														   -1),
								   new Triplet<string, short, short?>("WMC_DateofComments",4,
														   -1),
								   new Triplet<string, short, short?>("WMC_StepFrom",1,
														   -1),
								   new Triplet<string, short, short?>("WMC_StepTo",2,
														   -1),
								   new Triplet<string, short, short?>("WMC_User",3,
														   -1),
								}
			},
							{"CE2E8B0B-AC9E-4593-9832-8D67B5873077", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("PAB_Balance",6,
														   -1),
								   new Triplet<string, short, short?>("PAB_BudgetName",0,
														   -1),
								   new Triplet<string, short, short?>("PAB_Commitment",4,
														   -1),
								   new Triplet<string, short, short?>("PAB_RecievedAmount",3,
														   -1),
								   new Triplet<string, short, short?>("PAB_SanctionedAmount",1,
														   -1),
								   new Triplet<string, short, short?>("PAB_Spent",5,
														   -1),
								   new Triplet<string, short, short?>("PAB_YetToRecieve",2,
														   -1),
								}
			},
					};	

	

		private Dictionary<string,string> formVersionList =new Dictionary<string,string> 
		{
							{"5EC1F0DF-8850-4210-ADF0-87EF9BDCB734", "Medium"},
					};	

		
		private Dictionary<string,string> formVersionLayoutList =new Dictionary<string,string> 
		{
							{"6B8F7AC6-2945-472D-918B-7EE8EFEC9CFF", ""},
							{"E7CF988F-10DB-4E76-88DA-5380DC2D0B3C", ""},
							{"5EC1F0DF-8850-4210-ADF0-87EF9BDCB734", ""},
							{"67086EFC-9346-4452-9DEE-650784BB4279", ""},
							{"D79C1C00-199A-4018-99D5-F84A6EF2AD0D", ""},
							{"069F7E3F-8CBA-4933-93FC-F120509129D5", ""},
							{"95E81058-EB69-47A0-9308-7A1575999EF2", ""},
							{"5F920B82-7B74-4EE9-A3AF-B493DC082876", ""},
					};	

		

	
	
		
		
		public override  List<Triplet<string, short, short?>> GetQueryExpressionBindings(string expressionId)
		{
			if(string.IsNullOrWhiteSpace(expressionId))
            {
			  return null;				
            }


			if(queryExpressionBindings == null || queryExpressionBindings.Count <= 0)
				return null;

			return queryExpressionBindings[expressionId];
		}

		public override string GetValidFormVersionId(string formVersionId,ViewportTypes viewPort)
		{	
					
			 if(formVersionList == null || formVersionList.Count <= 0)
				return formVersionId;

			if (formVersionList.Count == 1)
                return formVersionList.FirstOrDefault().Key;  

			

			if ( !string.IsNullOrEmpty(formVersionId) &&  formVersionList.ContainsKey(formVersionId))
            {
                if (formVersionList.Any(x => x.Key == formVersionId && x.Value == viewPort.ToString()))
                    return formVersionId;
            }

			var fallback= new List<string>{"Mobile","Tab","Medium","Large"};

           switch (viewPort)
            {
                case ViewportTypes.Tab:
                    fallback = new List<string> { "Tab", "Mobile", "Medium", "Large" };
                    break;

                case ViewportTypes.Medium:
                    fallback = new List<string> { "Medium", "Tab", "Large", "Mobile" };
                    break;

                case ViewportTypes.Large:
                    fallback = new List<string> { "Large", "Medium", "Tab", "Mobile" };
                    break;
            }

           for (int i = 0; i < fallback.Count; i++)
           {
               if (formVersionList.Any(x => x.Value == fallback[i]))
                   return formVersionList.Where(x => x.Value == fallback[i]).Select(y => y.Key).FirstOrDefault();
           }

		   return formVersionId;
		}

	

		
		
		
		
		


	}

}
		
  







namespace CPS.Proof.DFSExtension
{
	
using System;
    using System.Collections.Generic;    
    using System.Text;	
    using System.Linq;	


	public partial class AcDataISpacef75a82b65c5f91578e147521dd2a01f1  : ExtensionActivityBase
	{		
		
		
		private Dictionary<string,  List<Triplet<string, short, short?>>> queryExpressionBindings = 
											new Dictionary<string,  List<Triplet<string, short, short?>>>
		{
							{"58EFF32D-D0CA-4464-8DB7-68C9010FA8B0", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_FundAllocation_RowId",3,
														   -1),
								   new Triplet<string, short, short?>("PFA_Amount",11,
														   -1),
								   new Triplet<string, short, short?>("PFA_BudgetHead",9,
														   -1),
								   new Triplet<string, short, short?>("PFA_BudgetHeadValue",10,
														   -1),
								   new Triplet<string, short, short?>("PFA_FundDetailsId",12,
														   -1),
								   new Triplet<string, short, short?>("PFA_FundType",5,
														   -1),
								   new Triplet<string, short, short?>("PFA_FundTypeValue",6,
														   -1),
								   new Triplet<string, short, short?>("PFA_ProjectNo",7,
														   -1),
								   new Triplet<string, short, short?>("PFA_ProjectNoValue",8,
														   -1),
								}
			},
							{"B30057A6-9D73-42DA-99B8-FDC3205833DE", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("WMC_Comments",5,
														   -1),
								   new Triplet<string, short, short?>("WMC_DateofComments",4,
														   -1),
								   new Triplet<string, short, short?>("WMC_StepFrom",1,
														   -1),
								   new Triplet<string, short, short?>("WMC_StepTo",2,
														   -1),
								   new Triplet<string, short, short?>("WMC_User",3,
														   -1),
								}
			},
							{"CE2E8B0B-AC9E-4593-9832-8D67B5873077", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("PAB_Balance",6,
														   -1),
								   new Triplet<string, short, short?>("PAB_BudgetName",0,
														   -1),
								   new Triplet<string, short, short?>("PAB_Commitment",4,
														   -1),
								   new Triplet<string, short, short?>("PAB_RecievedAmount",3,
														   -1),
								   new Triplet<string, short, short?>("PAB_SanctionedAmount",1,
														   -1),
								   new Triplet<string, short, short?>("PAB_Spent",5,
														   -1),
								   new Triplet<string, short, short?>("PAB_YetToRecieve",2,
														   -1),
								}
			},
					};	

	

		private Dictionary<string,string> formVersionList =new Dictionary<string,string> 
		{
					};	

		
		private Dictionary<string,string> formVersionLayoutList =new Dictionary<string,string> 
		{
							{"6B8F7AC6-2945-472D-918B-7EE8EFEC9CFF", ""},
							{"E7CF988F-10DB-4E76-88DA-5380DC2D0B3C", ""},
							{"5EC1F0DF-8850-4210-ADF0-87EF9BDCB734", ""},
							{"67086EFC-9346-4452-9DEE-650784BB4279", ""},
							{"D79C1C00-199A-4018-99D5-F84A6EF2AD0D", ""},
							{"069F7E3F-8CBA-4933-93FC-F120509129D5", ""},
							{"95E81058-EB69-47A0-9308-7A1575999EF2", ""},
							{"5F920B82-7B74-4EE9-A3AF-B493DC082876", ""},
					};	

		

	
	
		
		
		public override  List<Triplet<string, short, short?>> GetQueryExpressionBindings(string expressionId)
		{
			if(string.IsNullOrWhiteSpace(expressionId))
            {
			  return null;				
            }


			if(queryExpressionBindings == null || queryExpressionBindings.Count <= 0)
				return null;

			return queryExpressionBindings[expressionId];
		}

		public override string GetValidFormVersionId(string formVersionId,ViewportTypes viewPort)
		{	
					
			 if(formVersionList == null || formVersionList.Count <= 0)
				return formVersionId;

			if (formVersionList.Count == 1)
                return formVersionList.FirstOrDefault().Key;  

			

			if ( !string.IsNullOrEmpty(formVersionId) &&  formVersionList.ContainsKey(formVersionId))
            {
                if (formVersionList.Any(x => x.Key == formVersionId && x.Value == viewPort.ToString()))
                    return formVersionId;
            }

			var fallback= new List<string>{"Mobile","Tab","Medium","Large"};

           switch (viewPort)
            {
                case ViewportTypes.Tab:
                    fallback = new List<string> { "Tab", "Mobile", "Medium", "Large" };
                    break;

                case ViewportTypes.Medium:
                    fallback = new List<string> { "Medium", "Tab", "Large", "Mobile" };
                    break;

                case ViewportTypes.Large:
                    fallback = new List<string> { "Large", "Medium", "Tab", "Mobile" };
                    break;
            }

           for (int i = 0; i < fallback.Count; i++)
           {
               if (formVersionList.Any(x => x.Value == fallback[i]))
                   return formVersionList.Where(x => x.Value == fallback[i]).Select(y => y.Key).FirstOrDefault();
           }

		   return formVersionId;
		}

	

		
		
		
		
		


	}

}
		
  







namespace CPS.Proof.DFSExtension
{
	
using System;
    using System.Collections.Generic;    
    using System.Text;	
    using System.Linq;	


	public partial class AcDataISpaceef50e1fb78ab345bf630ec77222127ca  : ExtensionActivityBase
	{		
		
		
		private Dictionary<string,  List<Triplet<string, short, short?>>> queryExpressionBindings = 
											new Dictionary<string,  List<Triplet<string, short, short?>>>
		{
							{"58EFF32D-D0CA-4464-8DB7-68C9010FA8B0", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_FundAllocation_RowId",3,
														   -1),
								   new Triplet<string, short, short?>("PFA_Amount",11,
														   -1),
								   new Triplet<string, short, short?>("PFA_BudgetHead",9,
														   -1),
								   new Triplet<string, short, short?>("PFA_BudgetHeadValue",10,
														   -1),
								   new Triplet<string, short, short?>("PFA_FundDetailsId",12,
														   -1),
								   new Triplet<string, short, short?>("PFA_FundType",5,
														   -1),
								   new Triplet<string, short, short?>("PFA_FundTypeValue",6,
														   -1),
								   new Triplet<string, short, short?>("PFA_ProjectNo",7,
														   -1),
								   new Triplet<string, short, short?>("PFA_ProjectNoValue",8,
														   -1),
								}
			},
							{"B30057A6-9D73-42DA-99B8-FDC3205833DE", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("WMC_Comments",5,
														   -1),
								   new Triplet<string, short, short?>("WMC_DateofComments",4,
														   -1),
								   new Triplet<string, short, short?>("WMC_StepFrom",1,
														   -1),
								   new Triplet<string, short, short?>("WMC_StepTo",2,
														   -1),
								   new Triplet<string, short, short?>("WMC_User",3,
														   -1),
								}
			},
							{"CE2E8B0B-AC9E-4593-9832-8D67B5873077", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("PAB_Balance",6,
														   -1),
								   new Triplet<string, short, short?>("PAB_BudgetName",0,
														   -1),
								   new Triplet<string, short, short?>("PAB_Commitment",4,
														   -1),
								   new Triplet<string, short, short?>("PAB_RecievedAmount",3,
														   -1),
								   new Triplet<string, short, short?>("PAB_SanctionedAmount",1,
														   -1),
								   new Triplet<string, short, short?>("PAB_Spent",5,
														   -1),
								   new Triplet<string, short, short?>("PAB_YetToRecieve",2,
														   -1),
								}
			},
					};	

	

		private Dictionary<string,string> formVersionList =new Dictionary<string,string> 
		{
					};	

		
		private Dictionary<string,string> formVersionLayoutList =new Dictionary<string,string> 
		{
							{"6B8F7AC6-2945-472D-918B-7EE8EFEC9CFF", ""},
							{"E7CF988F-10DB-4E76-88DA-5380DC2D0B3C", ""},
							{"5EC1F0DF-8850-4210-ADF0-87EF9BDCB734", ""},
							{"67086EFC-9346-4452-9DEE-650784BB4279", ""},
							{"D79C1C00-199A-4018-99D5-F84A6EF2AD0D", ""},
							{"069F7E3F-8CBA-4933-93FC-F120509129D5", ""},
							{"95E81058-EB69-47A0-9308-7A1575999EF2", ""},
							{"5F920B82-7B74-4EE9-A3AF-B493DC082876", ""},
					};	

		

	
	
		
		
		public override  List<Triplet<string, short, short?>> GetQueryExpressionBindings(string expressionId)
		{
			if(string.IsNullOrWhiteSpace(expressionId))
            {
			  return null;				
            }


			if(queryExpressionBindings == null || queryExpressionBindings.Count <= 0)
				return null;

			return queryExpressionBindings[expressionId];
		}

		public override string GetValidFormVersionId(string formVersionId,ViewportTypes viewPort)
		{	
					
			 if(formVersionList == null || formVersionList.Count <= 0)
				return formVersionId;

			if (formVersionList.Count == 1)
                return formVersionList.FirstOrDefault().Key;  

			

			if ( !string.IsNullOrEmpty(formVersionId) &&  formVersionList.ContainsKey(formVersionId))
            {
                if (formVersionList.Any(x => x.Key == formVersionId && x.Value == viewPort.ToString()))
                    return formVersionId;
            }

			var fallback= new List<string>{"Mobile","Tab","Medium","Large"};

           switch (viewPort)
            {
                case ViewportTypes.Tab:
                    fallback = new List<string> { "Tab", "Mobile", "Medium", "Large" };
                    break;

                case ViewportTypes.Medium:
                    fallback = new List<string> { "Medium", "Tab", "Large", "Mobile" };
                    break;

                case ViewportTypes.Large:
                    fallback = new List<string> { "Large", "Medium", "Tab", "Mobile" };
                    break;
            }

           for (int i = 0; i < fallback.Count; i++)
           {
               if (formVersionList.Any(x => x.Value == fallback[i]))
                   return formVersionList.Where(x => x.Value == fallback[i]).Select(y => y.Key).FirstOrDefault();
           }

		   return formVersionId;
		}

	

		
		
		
		
		


	}

}
		


