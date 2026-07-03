  







namespace CPS.Proof.DFSExtension
{
	using System;
    using System.Collections.Generic;     
	using System.Linq;
	
	
	public partial class ProjectReimbursementNewProcessMetadata : ExtensionProcessBase
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
            get { return "36447555-6c49-45cd-8563-426f536ebf74"; }
        }

        public override string ProcessName
        {
            get { return "ProjectReimbursementNew"; }
        }

		public override string ProcessDescription
        {
            get { return "Project Reimbursement New using Multi panel form"; }
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
            get {return "36447555-6c49-45cd-8563-426f536ebf74";}
        }

		public override byte ProcessInstanceMode
        {
            get {return 3;}
        }		

		public override string MasterFormId
        {
            get {  
				   return "7580ABE2-1059-4AB0-AC76-04DE981561BA";	}
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
	

	public partial class ProjectReimbursementNewObjectFactory  : ExtObjectFactoryBase
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
        //    return (IExtBaseMetaData)new ProjectReimbursementNewProcessMetadata();
        //}
	


		private List<Triplet<string, string, string>> queryExpressionData = new List<Triplet<string, string, string>>
		{
	  			
			     new Triplet<string, string, string>("E8CDF359-9A11-4739-A997-9B7F3B8E3BA0","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("2AA88C52-FB41-4021-AC04-4916C93C6BCA","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("CD756DFD-7F97-4690-BF36-75DE5682E2E2","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"24F5D845-D560-4FC1-B284-00FB19DFB96F"),
			
						
			     new Triplet<string, string, string>("d9de38a8-a2b6-53f7-abf0-0232ba5e196e","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"028B1EFF-34A8-4D44-BF39-06CE99DF7C67"),
			
						
			     new Triplet<string, string, string>("F5733333-6311-4CC6-8A33-1CD0C39945BB","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("1BB628AB-53BD-42CE-9149-4F869D7536C8","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"24F5D845-D560-4FC1-B284-00FB19DFB96F"),
			
						
			     new Triplet<string, string, string>("bb2eb397-3d64-67dc-83f2-82b7f1189e7f","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"24F5D845-D560-4FC1-B284-00FB19DFB96F"),
			
						
			     new Triplet<string, string, string>("4729BCA0-8B6D-4424-A3D9-4EB16A532C2B","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("5C837D60-C28D-4224-BAEC-AFC4E77AECAD","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("7965F232-BCCC-495B-A03A-BBB242CA1F4D","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("fdd0ae43-5080-91a4-d34f-1d5bc5cb4888","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("7BA23C85-C8A6-4F22-BBF5-E91460186E30","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("A28FD172-AE9F-490A-9303-9F51D5E01251","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("67ee0211-d510-d00c-ff9f-de4c659b15ff","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("651A51BA-44D1-4B8D-AD5E-62A4219CC13A","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"24F5D845-D560-4FC1-B284-00FB19DFB96F"),
			
						
			     new Triplet<string, string, string>("40BDB104-36A9-47C7-B282-34AD458E8107","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"24F5D845-D560-4FC1-B284-00FB19DFB96F"),
			
						
			     new Triplet<string, string, string>("96448A8E-05CD-4B92-A281-D967231AC747","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"24F5D845-D560-4FC1-B284-00FB19DFB96F"),
			
						
			     new Triplet<string, string, string>("DA5E2384-62F5-48B9-90DF-56C48FA62392","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("0E725B17-ADFE-430B-9899-F601BC212A72","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("E8CDF359-9A11-4739-A997-9B7F3B8E3BA0","Load Commitments",
												     @"6B7A35BC-59EB-4CFB-8FBF-ADB3E8BC39C6"),
			
						
			     new Triplet<string, string, string>("1BB628AB-53BD-42CE-9149-4F869D7536C8","Load Comments",
												     @"8F47B89A-AF4A-4A73-BE87-44CF1EBCC456"),
			
						
			     new Triplet<string, string, string>("bb2eb397-3d64-67dc-83f2-82b7f1189e7f","Delete Bill Details",
												     @"98357E55-B276-4E6E-9A45-2588BF6CE0E4"),
			
						
			     new Triplet<string, string, string>("A28FD172-AE9F-490A-9303-9F51D5E01251","Load Fund Details",
												     @"825B4680-DEA2-4E2E-861A-965DE912D14B"),
			
						
			     new Triplet<string, string, string>("40BDB104-36A9-47C7-B282-34AD458E8107","Grid Binding9",
												     @"98357E55-B276-4E6E-9A45-2588BF6CE0E4"),
			
						
			     new Triplet<string, string, string>("96448A8E-05CD-4B92-A281-D967231AC747","Grid Binding8",
												     @"98357E55-B276-4E6E-9A45-2588BF6CE0E4"),
			
						
			     new Triplet<string, string, string>("DA5E2384-62F5-48B9-90DF-56C48FA62392","Load Grid By IdBillDetails",
												     @"98357E55-B276-4E6E-9A45-2588BF6CE0E4"),
			
			
			
		};

		
		private List<Triplet<string, string, string>> ComboDataSource = new List<Triplet<string, string, string>>
		{

		
	  			
			     new Triplet<string, string, string>("FWFM_BudgetHead","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMA18yFT7KruzVDa0TqsqpOM+grujzoqor1KqRIderPPsozBAr7TiIaPx7MYO2zQclV",
												     @"Exec SP_GetDistrubitionDetails 5,'@PFMF_PackageProcessMapId','@FWFM_FundType','','','','','@FWFM_ProjectNo'"),
			
						
			     new Triplet<string, string, string>("MF_d1_ReimbursementType","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMAqCwOWy+D7Ogje1I4jfjiAZNrjEazgaNyfBj9pr2u90lOsHzRNfKnSybWqRxrZGqV",
												     @"EXEC GetReimbursementType"),
			
						
			     new Triplet<string, string, string>("FWFM_FundType","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMA18yFT7KruzVDa0TqsqpOM+grujzoqor1KqRIderPPsozBAr7TiIaPx7MYO2zQclV",
												     @"exec SP_GetDistrubitionDetails 4,'@PFMF_PackageProcessMapId','',''"),
			
						
			     new Triplet<string, string, string>("MF_d1_Classification","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMAqCwOWy+D7Ogje1I4jfjiAZNrjEazgaNyfBj9pr2u90lOsHzRNfKnSybWqRxrZGqV",
												     @"Exec LoadPurchaseItemCombo"),
			
						
			     new Triplet<string, string, string>("MF_d1_SubClassification","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMAqCwOWy+D7Ogje1I4jfjiAZNrjEazgaNyfBj9pr2u90lOsHzRNfKnSybWqRxrZGqV",
												     @"Exec LoadItemSubCombo '@MF_d1_Classification'"),
			
						
			     new Triplet<string, string, string>("FWFM_ProjectNo","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMAqCwOWy+D7Ogje1I4jfjiAZNrjEazgaNyfBj9pr2u90lOsHzRNfKnSybWqRxrZGqV",
												     @"EXEC GetProjectNoCombo 1,'@PFMF_UserId'"),
			
						
			     new Triplet<string, string, string>("FWAB_ProjectNo","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMAqCwOWy+D7Ogje1I4jfjiAZNrjEazgaNyfBj9pr2u90lOsHzRNfKnSybWqRxrZGqV",
												     @"EXEC GetProjectNoCombo 1,'@PFMF_UserId'"),
			
						
			     new Triplet<string, string, string>("WMF_MoveTo","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMAX4svK5cDYCPw2sEhYNSLVUgHvT8EwteQ6Cu6POiqivUqpEh16s8+yjMECvtOIho/Hsxg7bNByVU=",
												     @"EXEC GetNextStep '@WMF_InstanceId','@WMF_FlowType'"),
			
						
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
		
	  			
			     new Tuple<string, int>("MG_FundAllocation",5),
			
						
			     new Tuple<string, int>("MG_AvailableBudget",5),
			
						
			     new Tuple<string, int>("MG_RequiredDocuments",5),
			
						
			     new Tuple<string, int>("BillDetails",5),
			
						
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
											case "F66E6A92-393A-4A49-8F44-78FD095E0597":
							virtualInstance=new ISpaceF66E6A92393A4A498F4478FD095E0597();
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
	

	public partial class ProjectReimbursementNewDataElementFactory  : ExtElementBase
    {

     /// <summary>
        /// A <see cref="log4net.ILog"/> that contains the logger instance for 
        /// logging
        /// </summary>
        private readonly ILog _sysLog;

        public ProjectReimbursementNewDataElementFactory()
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

               
                
                                      case "7580ABE2-1059-4AB0-AC76-04DE981561BA":
                    {
                     
                                     fInsertQuery=@"IF NOT EXISTS(SELECT 1 FROM [7580ABE2-1059-4AB0-AC76-04DE981561BA] WHERE InstanceId='{0}') BEGIN INSERT INTO [7580ABE2-1059-4AB0-AC76-04DE981561BA](ProcessActivityMapId,FormId,MF_d1_ReimbursementId,MF_d1_EmployeeBasicInfoId,MF_d1_TotalAmount,MF_d1_Initiatedon,MF_d1_InitatedBy,MF_d1_ApplicationStatus,MF_d1_ReimbursementType,MF_d1_Classification,MF_d1_SubClassification,MF_d1_UpdatedBy,MF_d1_UpdatedOn,Subject,ExecutionStatus,ExecutionMessage,SetDestinationTo,SLATime,AssignToRole,AssignToUser,IN_Priority,IN_InstanceName,IN_SLA,IN_Status,IN_Category,ExecuteCommand,RedirectUrl,Thumbnail,CancelRedirectUrl,KeyContext,DisplayContext,growid,InstanceId,UC_EmployeeId,UC_EmployeeName,UC_Designation,UC_Department,MF_ErrId,MF_DeleteRowId,MF_ErrMsg,UC_DOB,UC_PhoneNumber,UC_DOJ,UC_EmailId,UC_Name,UC_PayLevel,UC_Grade,UC_DOR,UC_EmployeeBasicInfoId,FWFM_FundDetailsId,FWFM_FundType,FWFM_ProjectNo,FWFM_BudgetHead,FWFM_Amount,PFMF_PackageProcessMapId,FWAB_ProjectNo,PFMF_UserId,PFM_ErrId,PFM_ErrMsg,PFM_FundDetailsId,WMF_InstanceId,WMF_IsInFlow,WMF_MoveTo,Comments,FlowType,MF_BillTotal,MF_FundTotal)
							VALUES( {3}) END ELSE BEGIN UPDATE [7580ABE2-1059-4AB0-AC76-04DE981561BA]SET {4}WHERE InstanceId='{0}'END ";

                                     colList=@"ProcessActivityMapId,FormId,MF_d1_ReimbursementId,MF_d1_EmployeeBasicInfoId,MF_d1_TotalAmount,MF_d1_Initiatedon,MF_d1_InitatedBy,MF_d1_ApplicationStatus,MF_d1_ReimbursementType,MF_d1_Classification,MF_d1_SubClassification,MF_d1_UpdatedBy,MF_d1_UpdatedOn,Subject,ExecutionStatus,ExecutionMessage,SetDestinationTo,SLATime,AssignToRole,AssignToUser,IN_Priority,IN_InstanceName,IN_SLA,IN_Status,IN_Category,ExecuteCommand,RedirectUrl,Thumbnail,CancelRedirectUrl,KeyContext,DisplayContext,growid,InstanceId,UC_EmployeeId,UC_EmployeeName,UC_Designation,UC_Department,MF_ErrId,MF_DeleteRowId,MF_ErrMsg,UC_DOB,UC_PhoneNumber,UC_DOJ,UC_EmailId,UC_Name,UC_PayLevel,UC_Grade,UC_DOR,UC_EmployeeBasicInfoId,FWFM_FundDetailsId,FWFM_FundType,FWFM_ProjectNo,FWFM_BudgetHead,FWFM_Amount,PFMF_PackageProcessMapId,FWAB_ProjectNo,PFMF_UserId,PFM_ErrId,PFM_ErrMsg,PFM_FundDetailsId,WMF_InstanceId,WMF_IsInFlow,WMF_MoveTo,Comments,FlowType,MF_BillTotal,MF_FundTotal";
                                    
                     
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

                
                 
                                      case "98357E55-B276-4E6E-9A45-2588BF6CE0E4":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_98357E55B2764E6E9A452588BF6CE0E4 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_d2_ReimbursementDetailsId] VARCHAR(MAX)	, [MG_d2_ReimbursementId] VARCHAR(MAX)	, [MG_d2_BillNo] VARCHAR(MAX)	, [MG_d2_BillDate] DATETIME	, [MG_d2_BillDocument] INT	, [MG_d2_ItemDescription] VARCHAR(MAX)	, [MG_d2_Amount] DECIMAL(18,2)){0}INSERT INTO [98357E55-B276-4E6E-9A45-2588BF6CE0E4](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d2_ReimbursementDetailsId,MG_d2_ReimbursementId,MG_d2_BillNo,MG_d2_BillDate,MG_d2_BillDocument,MG_d2_ItemDescription,MG_d2_Amount)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_d2_ReimbursementDetailsId,TDT.MG_d2_ReimbursementId,TDT.MG_d2_BillNo,TDT.MG_d2_BillDate,TDT.MG_d2_BillDocument,TDT.MG_d2_ItemDescription,TDT.MG_d2_Amount FROM @TBL_98357E55B2764E6E9A452588BF6CE0E4 TDT
							LEFT JOIN [98357E55-B276-4E6E-9A45-2588BF6CE0E4] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MG_d2_ReimbursementDetailsId=TDT.MG_d2_ReimbursementDetailsId,MG_d2_ReimbursementId=TDT.MG_d2_ReimbursementId,MG_d2_BillNo=TDT.MG_d2_BillNo,MG_d2_BillDate=TDT.MG_d2_BillDate,MG_d2_BillDocument=TDT.MG_d2_BillDocument,MG_d2_ItemDescription=TDT.MG_d2_ItemDescription,MG_d2_Amount=TDT.MG_d2_Amount FROM @TBL_98357E55B2764E6E9A452588BF6CE0E4 TDT
							JOIN [98357E55-B276-4E6E-9A45-2588BF6CE0E4] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d2_ReimbursementDetailsId,MG_d2_ReimbursementId,MG_d2_BillNo,MG_d2_BillDate,MG_d2_BillDocument,MG_d2_ItemDescription,MG_d2_Amount";

                                     tempInsertQuery=@"INSERT INTO @TBL_98357E55B2764E6E9A452588BF6CE0E4(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d2_ReimbursementDetailsId,MG_d2_ReimbursementId,MG_d2_BillNo,MG_d2_BillDate,MG_d2_BillDocument,MG_d2_ItemDescription,MG_d2_Amount)VALUES({0});";
                                     

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
                     
                                    case "825B4680-DEA2-4E2E-861A-965DE912D14B":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_825B4680DEA24E2E861A965DE912D14B AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [PFA_FundType] VARCHAR(MAX)	, [PFA_FundTypeValue] VARCHAR(MAX)	, [PFA_ProjectNo] VARCHAR(MAX)	, [PFA_ProjectNoValue] VARCHAR(MAX)	, [PFA_BudgetHead] VARCHAR(MAX)	, [PFA_BudgetHeadValue] VARCHAR(MAX)	, [PFA_Amount] DECIMAL(18,2)	, [PFA_FundDetailsId] VARCHAR(MAX)){0}INSERT INTO [825B4680-DEA2-4E2E-861A-965DE912D14B](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PFA_FundType,PFA_FundTypeValue,PFA_ProjectNo,PFA_ProjectNoValue,PFA_BudgetHead,PFA_BudgetHeadValue,PFA_Amount,PFA_FundDetailsId)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.PFA_FundType,TDT.PFA_FundTypeValue,TDT.PFA_ProjectNo,TDT.PFA_ProjectNoValue,TDT.PFA_BudgetHead,TDT.PFA_BudgetHeadValue,TDT.PFA_Amount,TDT.PFA_FundDetailsId FROM @TBL_825B4680DEA24E2E861A965DE912D14B TDT
							LEFT JOIN [825B4680-DEA2-4E2E-861A-965DE912D14B] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,PFA_FundType=TDT.PFA_FundType,PFA_FundTypeValue=TDT.PFA_FundTypeValue,PFA_ProjectNo=TDT.PFA_ProjectNo,PFA_ProjectNoValue=TDT.PFA_ProjectNoValue,PFA_BudgetHead=TDT.PFA_BudgetHead,PFA_BudgetHeadValue=TDT.PFA_BudgetHeadValue,PFA_Amount=TDT.PFA_Amount,PFA_FundDetailsId=TDT.PFA_FundDetailsId FROM @TBL_825B4680DEA24E2E861A965DE912D14B TDT
							JOIN [825B4680-DEA2-4E2E-861A-965DE912D14B] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PFA_FundType,PFA_FundTypeValue,PFA_ProjectNo,PFA_ProjectNoValue,PFA_BudgetHead,PFA_BudgetHeadValue,PFA_Amount,PFA_FundDetailsId";

                                     tempInsertQuery=@"INSERT INTO @TBL_825B4680DEA24E2E861A965DE912D14B(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PFA_FundType,PFA_FundTypeValue,PFA_ProjectNo,PFA_ProjectNoValue,PFA_BudgetHead,PFA_BudgetHeadValue,PFA_Amount,PFA_FundDetailsId)VALUES({0});";
                                     

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
                     
                                    case "6B7A35BC-59EB-4CFB-8FBF-ADB3E8BC39C6":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_6B7A35BC59EB4CFB8FBFADB3E8BC39C6 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [PAB_BudgetName] VARCHAR(MAX)	, [PAB_SanctionedAmount] DECIMAL(18,2)	, [PAB_YetToRecieve] DECIMAL(18,2)	, [PAB_RecievedAmount] DECIMAL(18,2)	, [PAB_Commitment] DECIMAL(18,2)	, [PAB_Spent] DECIMAL(18,2)	, [PAB_Balance] DECIMAL(18,2)){0}INSERT INTO [6B7A35BC-59EB-4CFB-8FBF-ADB3E8BC39C6](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PAB_BudgetName,PAB_SanctionedAmount,PAB_YetToRecieve,PAB_RecievedAmount,PAB_Commitment,PAB_Spent,PAB_Balance)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.PAB_BudgetName,TDT.PAB_SanctionedAmount,TDT.PAB_YetToRecieve,TDT.PAB_RecievedAmount,TDT.PAB_Commitment,TDT.PAB_Spent,TDT.PAB_Balance FROM @TBL_6B7A35BC59EB4CFB8FBFADB3E8BC39C6 TDT
							LEFT JOIN [6B7A35BC-59EB-4CFB-8FBF-ADB3E8BC39C6] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,PAB_BudgetName=TDT.PAB_BudgetName,PAB_SanctionedAmount=TDT.PAB_SanctionedAmount,PAB_YetToRecieve=TDT.PAB_YetToRecieve,PAB_RecievedAmount=TDT.PAB_RecievedAmount,PAB_Commitment=TDT.PAB_Commitment,PAB_Spent=TDT.PAB_Spent,PAB_Balance=TDT.PAB_Balance FROM @TBL_6B7A35BC59EB4CFB8FBFADB3E8BC39C6 TDT
							JOIN [6B7A35BC-59EB-4CFB-8FBF-ADB3E8BC39C6] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PAB_BudgetName,PAB_SanctionedAmount,PAB_YetToRecieve,PAB_RecievedAmount,PAB_Commitment,PAB_Spent,PAB_Balance";

                                     tempInsertQuery=@"INSERT INTO @TBL_6B7A35BC59EB4CFB8FBFADB3E8BC39C6(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PAB_BudgetName,PAB_SanctionedAmount,PAB_YetToRecieve,PAB_RecievedAmount,PAB_Commitment,PAB_Spent,PAB_Balance)VALUES({0});";
                                     

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
                     
                                    case "95D6FCFD-4B36-4E23-B424-43AB84B1680B":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_95D6FCFD4B364E23B42443AB84B1680B AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [PADD_DocumentName] VARCHAR(MAX)	, [PADD_Document] VARCHAR(MAX)){0}INSERT INTO [95D6FCFD-4B36-4E23-B424-43AB84B1680B](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PADD_DocumentName,PADD_Document)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.PADD_DocumentName,TDT.PADD_Document FROM @TBL_95D6FCFD4B364E23B42443AB84B1680B TDT
							LEFT JOIN [95D6FCFD-4B36-4E23-B424-43AB84B1680B] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,PADD_DocumentName=TDT.PADD_DocumentName,PADD_Document=TDT.PADD_Document FROM @TBL_95D6FCFD4B364E23B42443AB84B1680B TDT
							JOIN [95D6FCFD-4B36-4E23-B424-43AB84B1680B] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PADD_DocumentName,PADD_Document";

                                     tempInsertQuery=@"INSERT INTO @TBL_95D6FCFD4B364E23B42443AB84B1680B(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PADD_DocumentName,PADD_Document)VALUES({0});";
                                     

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
                     
                                    case "8F47B89A-AF4A-4A73-BE87-44CF1EBCC456":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_8F47B89AAF4A4A73BE8744CF1EBCC456 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [WMC_StepFrom] VARCHAR(MAX)	, [WMC_StepTo] VARCHAR(MAX)	, [WMC_Comments] VARCHAR(MAX)	, [WMC_User] VARCHAR(MAX)	, [WMC_DateofComments] DATETIME){0}INSERT INTO [8F47B89A-AF4A-4A73-BE87-44CF1EBCC456](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,WMC_StepFrom,WMC_StepTo,WMC_Comments,WMC_User,WMC_DateofComments)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.WMC_StepFrom,TDT.WMC_StepTo,TDT.WMC_Comments,TDT.WMC_User,TDT.WMC_DateofComments FROM @TBL_8F47B89AAF4A4A73BE8744CF1EBCC456 TDT
							LEFT JOIN [8F47B89A-AF4A-4A73-BE87-44CF1EBCC456] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,WMC_StepFrom=TDT.WMC_StepFrom,WMC_StepTo=TDT.WMC_StepTo,WMC_Comments=TDT.WMC_Comments,WMC_User=TDT.WMC_User,WMC_DateofComments=TDT.WMC_DateofComments FROM @TBL_8F47B89AAF4A4A73BE8744CF1EBCC456 TDT
							JOIN [8F47B89A-AF4A-4A73-BE87-44CF1EBCC456] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,WMC_StepFrom,WMC_StepTo,WMC_Comments,WMC_User,WMC_DateofComments";

                                     tempInsertQuery=@"INSERT INTO @TBL_8F47B89AAF4A4A73BE8744CF1EBCC456(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,WMC_StepFrom,WMC_StepTo,WMC_Comments,WMC_User,WMC_DateofComments)VALUES({0});";
                                     

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
                     

                                         case "98357E55-B276-4E6E-9A45-2588BF6CE0E4":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_98357E55B2764E6E9A452588BF6CE0E4 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_d2_ReimbursementDetailsId] VARCHAR(MAX)	, [MG_d2_ReimbursementId] VARCHAR(MAX)	, [MG_d2_BillNo] VARCHAR(MAX)	, [MG_d2_BillDate] DATETIME	, [MG_d2_BillDocument] INT	, [MG_d2_ItemDescription] VARCHAR(MAX)	, [MG_d2_Amount] DECIMAL(18,2)){0}INSERT INTO [98357E55-B276-4E6E-9A45-2588BF6CE0E4](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d2_ReimbursementDetailsId,MG_d2_ReimbursementId,MG_d2_BillNo,MG_d2_BillDate,MG_d2_BillDocument,MG_d2_ItemDescription,MG_d2_Amount)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_d2_ReimbursementDetailsId,TDT.MG_d2_ReimbursementId,TDT.MG_d2_BillNo,TDT.MG_d2_BillDate,TDT.MG_d2_BillDocument,TDT.MG_d2_ItemDescription,TDT.MG_d2_Amount FROM @TBL_98357E55B2764E6E9A452588BF6CE0E4 TDT
							LEFT JOIN [98357E55-B276-4E6E-9A45-2588BF6CE0E4] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MG_d2_ReimbursementDetailsId=TDT.MG_d2_ReimbursementDetailsId,MG_d2_ReimbursementId=TDT.MG_d2_ReimbursementId,MG_d2_BillNo=TDT.MG_d2_BillNo,MG_d2_BillDate=TDT.MG_d2_BillDate,MG_d2_BillDocument=TDT.MG_d2_BillDocument,MG_d2_ItemDescription=TDT.MG_d2_ItemDescription,MG_d2_Amount=TDT.MG_d2_Amount FROM @TBL_98357E55B2764E6E9A452588BF6CE0E4 TDT
							JOIN [98357E55-B276-4E6E-9A45-2588BF6CE0E4] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d2_ReimbursementDetailsId,MG_d2_ReimbursementId,MG_d2_BillNo,MG_d2_BillDate,MG_d2_BillDocument,MG_d2_ItemDescription,MG_d2_Amount";

                            tempInsertQuery=@"INSERT INTO @TBL_98357E55B2764E6E9A452588BF6CE0E4(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d2_ReimbursementDetailsId,MG_d2_ReimbursementId,MG_d2_BillNo,MG_d2_BillDate,MG_d2_BillDocument,MG_d2_ItemDescription,MG_d2_Amount)VALUES({0});";

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

                                              case "825B4680-DEA2-4E2E-861A-965DE912D14B":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_825B4680DEA24E2E861A965DE912D14B AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [PFA_FundType] VARCHAR(MAX)	, [PFA_FundTypeValue] VARCHAR(MAX)	, [PFA_ProjectNo] VARCHAR(MAX)	, [PFA_ProjectNoValue] VARCHAR(MAX)	, [PFA_BudgetHead] VARCHAR(MAX)	, [PFA_BudgetHeadValue] VARCHAR(MAX)	, [PFA_Amount] DECIMAL(18,2)	, [PFA_FundDetailsId] VARCHAR(MAX)){0}INSERT INTO [825B4680-DEA2-4E2E-861A-965DE912D14B](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PFA_FundType,PFA_FundTypeValue,PFA_ProjectNo,PFA_ProjectNoValue,PFA_BudgetHead,PFA_BudgetHeadValue,PFA_Amount,PFA_FundDetailsId)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.PFA_FundType,TDT.PFA_FundTypeValue,TDT.PFA_ProjectNo,TDT.PFA_ProjectNoValue,TDT.PFA_BudgetHead,TDT.PFA_BudgetHeadValue,TDT.PFA_Amount,TDT.PFA_FundDetailsId FROM @TBL_825B4680DEA24E2E861A965DE912D14B TDT
							LEFT JOIN [825B4680-DEA2-4E2E-861A-965DE912D14B] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,PFA_FundType=TDT.PFA_FundType,PFA_FundTypeValue=TDT.PFA_FundTypeValue,PFA_ProjectNo=TDT.PFA_ProjectNo,PFA_ProjectNoValue=TDT.PFA_ProjectNoValue,PFA_BudgetHead=TDT.PFA_BudgetHead,PFA_BudgetHeadValue=TDT.PFA_BudgetHeadValue,PFA_Amount=TDT.PFA_Amount,PFA_FundDetailsId=TDT.PFA_FundDetailsId FROM @TBL_825B4680DEA24E2E861A965DE912D14B TDT
							JOIN [825B4680-DEA2-4E2E-861A-965DE912D14B] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PFA_FundType,PFA_FundTypeValue,PFA_ProjectNo,PFA_ProjectNoValue,PFA_BudgetHead,PFA_BudgetHeadValue,PFA_Amount,PFA_FundDetailsId";

                            tempInsertQuery=@"INSERT INTO @TBL_825B4680DEA24E2E861A965DE912D14B(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PFA_FundType,PFA_FundTypeValue,PFA_ProjectNo,PFA_ProjectNoValue,PFA_BudgetHead,PFA_BudgetHeadValue,PFA_Amount,PFA_FundDetailsId)VALUES({0});";

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

                                              case "6B7A35BC-59EB-4CFB-8FBF-ADB3E8BC39C6":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_6B7A35BC59EB4CFB8FBFADB3E8BC39C6 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [PAB_BudgetName] VARCHAR(MAX)	, [PAB_SanctionedAmount] DECIMAL(18,2)	, [PAB_YetToRecieve] DECIMAL(18,2)	, [PAB_RecievedAmount] DECIMAL(18,2)	, [PAB_Commitment] DECIMAL(18,2)	, [PAB_Spent] DECIMAL(18,2)	, [PAB_Balance] DECIMAL(18,2)){0}INSERT INTO [6B7A35BC-59EB-4CFB-8FBF-ADB3E8BC39C6](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PAB_BudgetName,PAB_SanctionedAmount,PAB_YetToRecieve,PAB_RecievedAmount,PAB_Commitment,PAB_Spent,PAB_Balance)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.PAB_BudgetName,TDT.PAB_SanctionedAmount,TDT.PAB_YetToRecieve,TDT.PAB_RecievedAmount,TDT.PAB_Commitment,TDT.PAB_Spent,TDT.PAB_Balance FROM @TBL_6B7A35BC59EB4CFB8FBFADB3E8BC39C6 TDT
							LEFT JOIN [6B7A35BC-59EB-4CFB-8FBF-ADB3E8BC39C6] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,PAB_BudgetName=TDT.PAB_BudgetName,PAB_SanctionedAmount=TDT.PAB_SanctionedAmount,PAB_YetToRecieve=TDT.PAB_YetToRecieve,PAB_RecievedAmount=TDT.PAB_RecievedAmount,PAB_Commitment=TDT.PAB_Commitment,PAB_Spent=TDT.PAB_Spent,PAB_Balance=TDT.PAB_Balance FROM @TBL_6B7A35BC59EB4CFB8FBFADB3E8BC39C6 TDT
							JOIN [6B7A35BC-59EB-4CFB-8FBF-ADB3E8BC39C6] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PAB_BudgetName,PAB_SanctionedAmount,PAB_YetToRecieve,PAB_RecievedAmount,PAB_Commitment,PAB_Spent,PAB_Balance";

                            tempInsertQuery=@"INSERT INTO @TBL_6B7A35BC59EB4CFB8FBFADB3E8BC39C6(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PAB_BudgetName,PAB_SanctionedAmount,PAB_YetToRecieve,PAB_RecievedAmount,PAB_Commitment,PAB_Spent,PAB_Balance)VALUES({0});";

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

                                              case "95D6FCFD-4B36-4E23-B424-43AB84B1680B":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_95D6FCFD4B364E23B42443AB84B1680B AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [PADD_DocumentName] VARCHAR(MAX)	, [PADD_Document] VARCHAR(MAX)){0}INSERT INTO [95D6FCFD-4B36-4E23-B424-43AB84B1680B](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PADD_DocumentName,PADD_Document)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.PADD_DocumentName,TDT.PADD_Document FROM @TBL_95D6FCFD4B364E23B42443AB84B1680B TDT
							LEFT JOIN [95D6FCFD-4B36-4E23-B424-43AB84B1680B] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,PADD_DocumentName=TDT.PADD_DocumentName,PADD_Document=TDT.PADD_Document FROM @TBL_95D6FCFD4B364E23B42443AB84B1680B TDT
							JOIN [95D6FCFD-4B36-4E23-B424-43AB84B1680B] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PADD_DocumentName,PADD_Document";

                            tempInsertQuery=@"INSERT INTO @TBL_95D6FCFD4B364E23B42443AB84B1680B(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PADD_DocumentName,PADD_Document)VALUES({0});";

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

                                              case "8F47B89A-AF4A-4A73-BE87-44CF1EBCC456":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_8F47B89AAF4A4A73BE8744CF1EBCC456 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [WMC_StepFrom] VARCHAR(MAX)	, [WMC_StepTo] VARCHAR(MAX)	, [WMC_Comments] VARCHAR(MAX)	, [WMC_User] VARCHAR(MAX)	, [WMC_DateofComments] DATETIME){0}INSERT INTO [8F47B89A-AF4A-4A73-BE87-44CF1EBCC456](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,WMC_StepFrom,WMC_StepTo,WMC_Comments,WMC_User,WMC_DateofComments)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.WMC_StepFrom,TDT.WMC_StepTo,TDT.WMC_Comments,TDT.WMC_User,TDT.WMC_DateofComments FROM @TBL_8F47B89AAF4A4A73BE8744CF1EBCC456 TDT
							LEFT JOIN [8F47B89A-AF4A-4A73-BE87-44CF1EBCC456] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,WMC_StepFrom=TDT.WMC_StepFrom,WMC_StepTo=TDT.WMC_StepTo,WMC_Comments=TDT.WMC_Comments,WMC_User=TDT.WMC_User,WMC_DateofComments=TDT.WMC_DateofComments FROM @TBL_8F47B89AAF4A4A73BE8744CF1EBCC456 TDT
							JOIN [8F47B89A-AF4A-4A73-BE87-44CF1EBCC456] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,WMC_StepFrom,WMC_StepTo,WMC_Comments,WMC_User,WMC_DateofComments";

                            tempInsertQuery=@"INSERT INTO @TBL_8F47B89AAF4A4A73BE8744CF1EBCC456(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,WMC_StepFrom,WMC_StepTo,WMC_Comments,WMC_User,WMC_DateofComments)VALUES({0});";

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
public class ISpaceF66E6A92393A4A498F4478FD095E0597 : VirtualForm
{
IISpace iSpace = new ISpace();
AcDataISpaceF66E6A92393A4A498F4478FD095E0597 acdataIspaceF66E6A92393A4A498F4478FD095E0597=new AcDataISpaceF66E6A92393A4A498F4478FD095E0597();
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
if(ISpace["FormVersionId"].Value=="73B8AA02-9DDD-4205-8CCE-3A640B657727")
{
ISpace["UI_ApprovalHideRow"].Visible="false";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""73B8AA02-9DDD-4205-8CCE-3A640B657727"")
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

var querySource651A51BA44D14B8DAD5E62A4219CC13A =GetQueryExpressionDataSource("651A51BA-44D1-4B8D-AD5E-62A4219CC13A");
Dictionary<short,object> result651A51BA44D14B8DAD5E62A4219CC13A=iSpace.ExecuteQuery(querySource651A51BA44D14B8DAD5E62A4219CC13A,@"EXEC [GetInstanceInFlow] '" + ISpace["gv_instanceid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource651A51BA44D14B8DAD5E62A4219CC13A =GetQueryExpressionDataSource(""651A51BA-44D1-4B8D-AD5E-62A4219CC13A"");Dictionary<short,object> result651A51BA44D14B8DAD5E62A4219CC13A=iSpace.ExecuteQuery(querySource651A51BA44D14B8DAD5E62A4219CC13A,@""EXEC [GetInstanceInFlow] '"" + ISpace[""gv_instanceid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result651A51BA44D14B8DAD5E62A4219CC13A!=null) && (result651A51BA44D14B8DAD5E62A4219CC13A.Count!=0))
{
if(result651A51BA44D14B8DAD5E62A4219CC13A.ContainsKey(0))
ISpace["WMF_IsInFlow"].Value = result651A51BA44D14B8DAD5E62A4219CC13A[0];
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
if(ISpace["WMF_IsInFlow"].Value!=1)
{
base.WriteDebugInfo(@"if(ISpace[""WMF_IsInFlow""].Value!=1)");
ISpace["WMF_MoveTo"].Visible="false";ISpace["WMF_History"].Visible="false";
base.WriteDebugInfo(@"ISpace[""WMF_MoveTo""].Visible=""false"";ISpace[""WMF_History""].Visible=""false"";");
}
}
ISpace["WMF_MoveTo"].Man=true;
base.WriteDebugInfo(@"ISpace[""WMF_MoveTo""].Man=true;");

var querySource1BB628AB53BD42CE91494F869D7536C8 =GetQueryExpressionDataSource("1BB628AB-53BD-42CE-9149-4F869D7536C8");

DataTable result1BB628AB53BD42CE91494F869D7536C8=iSpace.SetGridDataSource(querySource1BB628AB53BD42CE91494F869D7536C8, _objectFactory.GetGridRPP("WMG_CommentsHistory"),@"EXEC [GetInstanceFlowDetais] '" + ISpace["gv_instanceid"].Value + @"'");

iSpace.InsertGridBindDetails("WMG_CommentsHistory","11",querySource1BB628AB53BD42CE91494F869D7536C8,"EXEC [GetInstanceFlowDetais] '" + ISpace["gv_instanceid"].Value + @"'",_objectFactory.GetGridRPP("WMG_CommentsHistory"));

base.WriteDebugInfo(@"var querySource1BB628AB53BD42CE91494F869D7536C8 =GetQueryExpressionDataSource(""1BB628AB-53BD-42CE-9149-4F869D7536C8"");DataTable result1BB628AB53BD42CE91494F869D7536C8=iSpace.SetGridDataSource(querySource1BB628AB53BD42CE91494F869D7536C8, _objectFactory.GetGridRPP(""WMG_CommentsHistory""),@""EXEC [GetInstanceFlowDetais] '"" + ISpace[""gv_instanceid""].Value + @""'"");iSpace.InsertGridBindDetails(""WMG_CommentsHistory"",""11"",querySource1BB628AB53BD42CE91494F869D7536C8,""EXEC [GetInstanceFlowDetais] '"" + ISpace[""gv_instanceid""].Value + @""'"",_objectFactory.GetGridRPP(""WMG_CommentsHistory""));");
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
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result8CFBA89A2F5D41AA8049CA173EA990A8=acdataIspaceF66E6A92393A4A498F4478FD095E0597.GetQueryExpressionBindings("8CFBA89A-2F5D-41AA-8049-CA173EA990A8");
iSpace.SetGridData(result1BB628AB53BD42CE91494F869D7536C8,result8CFBA89A2F5D41AA8049CA173EA990A8,"WMG_CommentsHistory",ref ISpace);
iSpace.UpdateGridBindDetails("WMG_CommentsHistory",result8CFBA89A2F5D41AA8049CA173EA990A8);
if(ISpace["FWFM_FundType"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""FWFM_FundType""].Value=="""")");
ISpace["FWFM_BudgetHead"].Visible="false";ISpace["FWFM_ProjectNo"].Visible="false";ISpace["FWFM_Amount"].Visible="false";
base.WriteDebugInfo(@"ISpace[""FWFM_BudgetHead""].Visible=""false"";ISpace[""FWFM_ProjectNo""].Visible=""false"";ISpace[""FWFM_Amount""].Visible=""false"";");
}
if(ISpace["FWFM_FundType"].Value=="1" || ISpace["FWFM_FundType"].Value=="3")
{
base.WriteDebugInfo(@"if(ISpace[""FWFM_FundType""].Value==""1"" || ISpace[""FWFM_FundType""].Value==""3"")");
ISpace["FWFM_BudgetHead"].Visible="true";ISpace["FWFM_ProjectNo"].Visible="true";
base.WriteDebugInfo(@"ISpace[""FWFM_BudgetHead""].Visible=""true"";ISpace[""FWFM_ProjectNo""].Visible=""true"";");
}
ISpace["PFMF_PackageProcessMapId"].Value=ISpace["gv_processmapid"].Value;
base.WriteDebugInfo(@"ISpace[""PFMF_PackageProcessMapId""].Value=ISpace[""gv_processmapid""].Value;");
ISpace["PFMF_UserId"].Value=ISpace["gv_userid"].Value;
base.WriteDebugInfo(@"ISpace[""PFMF_UserId""].Value=ISpace[""gv_userid""].Value;");
if(ISpace["FormVersionId"].Value=="73B8AA02-9DDD-4205-8CCE-3A640B657727")
{
ISpace["UI_PFHideRow"].Visible="false";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""73B8AA02-9DDD-4205-8CCE-3A640B657727"")
{
ISpace[""UI_PFHideRow""].Visible=""false"";
}");
if(ISpace["MF_d1_ReimbursementId"].Value!="0")
{
base.WriteDebugInfo(@"if(ISpace[""MF_d1_ReimbursementId""].Value!=""0"")");
base.WriteDebugInfo(@"EXEC InnovaceNoCode..[FormLoadById_7580ABE2-1059-4AB0-AC76-04DE981561BA]  '#MF_d1_ReimbursementId'");

var querySource0E725B17ADFE430B9899F601BC212A72 =GetQueryExpressionDataSource("0E725B17-ADFE-430B-9899-F601BC212A72");
Dictionary<short,object> result0E725B17ADFE430B9899F601BC212A72=iSpace.ExecuteQuery(querySource0E725B17ADFE430B9899F601BC212A72,@"EXEC InnovaceNoCode..[FormLoadById_7580ABE2-1059-4AB0-AC76-04DE981561BA]  '" + ISpace["MF_d1_ReimbursementId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource0E725B17ADFE430B9899F601BC212A72 =GetQueryExpressionDataSource(""0E725B17-ADFE-430B-9899-F601BC212A72"");Dictionary<short,object> result0E725B17ADFE430B9899F601BC212A72=iSpace.ExecuteQuery(querySource0E725B17ADFE430B9899F601BC212A72,@""EXEC InnovaceNoCode..[FormLoadById_7580ABE2-1059-4AB0-AC76-04DE981561BA]  '"" + ISpace[""MF_d1_ReimbursementId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result0E725B17ADFE430B9899F601BC212A72!=null) && (result0E725B17ADFE430B9899F601BC212A72.Count!=0))
{
if(result0E725B17ADFE430B9899F601BC212A72.ContainsKey(3))
ISpace["MF_d1_Initiatedon"].Value = result0E725B17ADFE430B9899F601BC212A72[3];
if(result0E725B17ADFE430B9899F601BC212A72.ContainsKey(10))
ISpace["MF_d1_UpdatedOn"].Value = result0E725B17ADFE430B9899F601BC212A72[10];
if(result0E725B17ADFE430B9899F601BC212A72.ContainsKey(6))
ISpace["MF_d1_ReimbursementType"].Value = result0E725B17ADFE430B9899F601BC212A72[6];
if(result0E725B17ADFE430B9899F601BC212A72.ContainsKey(7))
ISpace["MF_d1_Classification"].Value = result0E725B17ADFE430B9899F601BC212A72[7];
if(result0E725B17ADFE430B9899F601BC212A72.ContainsKey(8))
ISpace["MF_d1_SubClassification"].Value = result0E725B17ADFE430B9899F601BC212A72[8];
if(result0E725B17ADFE430B9899F601BC212A72.ContainsKey(2))
ISpace["MF_d1_TotalAmount"].Value = result0E725B17ADFE430B9899F601BC212A72[2];
if(result0E725B17ADFE430B9899F601BC212A72.ContainsKey(1))
ISpace["MF_d1_EmployeeBasicInfoId"].Value = result0E725B17ADFE430B9899F601BC212A72[1];
if(result0E725B17ADFE430B9899F601BC212A72.ContainsKey(0))
ISpace["MF_d1_ReimbursementId"].Value = result0E725B17ADFE430B9899F601BC212A72[0];
if(result0E725B17ADFE430B9899F601BC212A72.ContainsKey(5))
ISpace["MF_d1_ApplicationStatus"].Value = result0E725B17ADFE430B9899F601BC212A72[5];
if(result0E725B17ADFE430B9899F601BC212A72.ContainsKey(4))
ISpace["MF_d1_InitatedBy"].Value = result0E725B17ADFE430B9899F601BC212A72[4];
if(result0E725B17ADFE430B9899F601BC212A72.ContainsKey(9))
ISpace["MF_d1_UpdatedBy"].Value = result0E725B17ADFE430B9899F601BC212A72[9];
}
else{
ISpace["MF_d1_Initiatedon"].Value = null;ISpace["MF_d1_UpdatedOn"].Value = null;ISpace["MF_d1_ReimbursementType"].Value = null;ISpace["MF_d1_Classification"].Value = null;ISpace["MF_d1_SubClassification"].Value = null;ISpace["MF_d1_TotalAmount"].Value = null;ISpace["MF_d1_EmployeeBasicInfoId"].Value = null;ISpace["MF_d1_ReimbursementId"].Value = null;ISpace["MF_d1_ApplicationStatus"].Value = null;ISpace["MF_d1_InitatedBy"].Value = null;ISpace["MF_d1_UpdatedBy"].Value = null;
}

var querySourceDA5E238462F548B990DF56C48FA62392 =GetQueryExpressionDataSource("DA5E2384-62F5-48B9-90DF-56C48FA62392");

DataTable resultDA5E238462F548B990DF56C48FA62392=iSpace.SetGridDataSource(querySourceDA5E238462F548B990DF56C48FA62392, _objectFactory.GetGridRPP("BillDetails"),@"EXEC InnovaceNoCode..[GridLoadById_98357E55-B276-4E6E-9A45-2588BF6CE0E4]  '" + ISpace["MF_d1_ReimbursementId"].Value + @"'");

iSpace.InsertGridBindDetails("BillDetails","11",querySourceDA5E238462F548B990DF56C48FA62392,"EXEC InnovaceNoCode..[GridLoadById_98357E55-B276-4E6E-9A45-2588BF6CE0E4]  '" + ISpace["MF_d1_ReimbursementId"].Value + @"'",_objectFactory.GetGridRPP("BillDetails"));

base.WriteDebugInfo(@"var querySourceDA5E238462F548B990DF56C48FA62392 =GetQueryExpressionDataSource(""DA5E2384-62F5-48B9-90DF-56C48FA62392"");DataTable resultDA5E238462F548B990DF56C48FA62392=iSpace.SetGridDataSource(querySourceDA5E238462F548B990DF56C48FA62392, _objectFactory.GetGridRPP(""BillDetails""),@""EXEC InnovaceNoCode..[GridLoadById_98357E55-B276-4E6E-9A45-2588BF6CE0E4]  '"" + ISpace[""MF_d1_ReimbursementId""].Value + @""'"");iSpace.InsertGridBindDetails(""BillDetails"",""11"",querySourceDA5E238462F548B990DF56C48FA62392,""EXEC InnovaceNoCode..[GridLoadById_98357E55-B276-4E6E-9A45-2588BF6CE0E4]  '"" + ISpace[""MF_d1_ReimbursementId""].Value + @""'"",_objectFactory.GetGridRPP(""BillDetails""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> resultE038516D011F466BB4D0511D8D50C501=acdataIspaceF66E6A92393A4A498F4478FD095E0597.GetQueryExpressionBindings("E038516D-011F-466B-B4D0-511D8D50C501");
iSpace.SetGridData(resultDA5E238462F548B990DF56C48FA62392,resultE038516D011F466BB4D0511D8D50C501,"BillDetails",ref ISpace);
iSpace.UpdateGridBindDetails("BillDetails",resultE038516D011F466BB4D0511D8D50C501);
}
base.WriteDebugInfo(@"EXEC [GetEmployeeUserContextDetails] '@@gv_UserId'");

var querySourced9de38a8a2b653f7abf00232ba5e196e =GetQueryExpressionDataSource("d9de38a8-a2b6-53f7-abf0-0232ba5e196e");
Dictionary<short,object> resultd9de38a8a2b653f7abf00232ba5e196e=iSpace.ExecuteQuery(querySourced9de38a8a2b653f7abf00232ba5e196e,@"EXEC [GetEmployeeUserContextDetails] '" + ISpace["gv_userid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourced9de38a8a2b653f7abf00232ba5e196e =GetQueryExpressionDataSource(""d9de38a8-a2b6-53f7-abf0-0232ba5e196e"");Dictionary<short,object> resultd9de38a8a2b653f7abf00232ba5e196e=iSpace.ExecuteQuery(querySourced9de38a8a2b653f7abf00232ba5e196e,@""EXEC [GetEmployeeUserContextDetails] '"" + ISpace[""gv_userid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultd9de38a8a2b653f7abf00232ba5e196e!=null) && (resultd9de38a8a2b653f7abf00232ba5e196e.Count!=0))
{
if(resultd9de38a8a2b653f7abf00232ba5e196e.ContainsKey(12))
ISpace["UC_Name"].Value = resultd9de38a8a2b653f7abf00232ba5e196e[12];
if(resultd9de38a8a2b653f7abf00232ba5e196e.ContainsKey(6))
ISpace["UC_Department"].Value = resultd9de38a8a2b653f7abf00232ba5e196e[6];
if(resultd9de38a8a2b653f7abf00232ba5e196e.ContainsKey(7))
ISpace["UC_Designation"].Value = resultd9de38a8a2b653f7abf00232ba5e196e[7];
if(resultd9de38a8a2b653f7abf00232ba5e196e.ContainsKey(4))
ISpace["UC_DOJ"].Value = resultd9de38a8a2b653f7abf00232ba5e196e[4];
if(resultd9de38a8a2b653f7abf00232ba5e196e.ContainsKey(1))
ISpace["UC_EmployeeId"].Value = resultd9de38a8a2b653f7abf00232ba5e196e[1];
if(resultd9de38a8a2b653f7abf00232ba5e196e.ContainsKey(3))
ISpace["UC_EmailId"].Value = resultd9de38a8a2b653f7abf00232ba5e196e[3];
if(resultd9de38a8a2b653f7abf00232ba5e196e.ContainsKey(10))
ISpace["UC_DOR"].Value = resultd9de38a8a2b653f7abf00232ba5e196e[10];
if(resultd9de38a8a2b653f7abf00232ba5e196e.ContainsKey(9))
ISpace["UC_DOB"].Value = resultd9de38a8a2b653f7abf00232ba5e196e[9];
if(resultd9de38a8a2b653f7abf00232ba5e196e.ContainsKey(0))
ISpace["UC_EmployeeBasicInfoId"].Value = resultd9de38a8a2b653f7abf00232ba5e196e[0];
if(resultd9de38a8a2b653f7abf00232ba5e196e.ContainsKey(11))
ISpace["UC_EmployeeName"].Value = resultd9de38a8a2b653f7abf00232ba5e196e[11];
if(resultd9de38a8a2b653f7abf00232ba5e196e.ContainsKey(2))
ISpace["UC_Grade"].Value = resultd9de38a8a2b653f7abf00232ba5e196e[2];
}
else{
ISpace["UC_Name"].Value = null;ISpace["UC_Department"].Value = null;ISpace["UC_Designation"].Value = null;ISpace["UC_DOJ"].Value = null;ISpace["UC_EmployeeId"].Value = null;ISpace["UC_EmailId"].Value = null;ISpace["UC_DOR"].Value = null;ISpace["UC_DOB"].Value = null;ISpace["UC_EmployeeBasicInfoId"].Value = null;ISpace["UC_EmployeeName"].Value = null;ISpace["UC_Grade"].Value = null;
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["MF_d1_ApplicationStatus"].Value="S";
base.WriteDebugInfo(@"ISpace[""MF_d1_ApplicationStatus""].Value=""S"";");
}
if(ISpace["MF_d1_ReimbursementType"].Value=="2")
{
base.WriteDebugInfo(@"if(ISpace[""MF_d1_ReimbursementType""].Value==""2"")");
if(ISpace["FormVersionId"].Value=="73B8AA02-9DDD-4205-8CCE-3A640B657727")
{
ISpace["UI_PurchaseRow"].Visible="true";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""73B8AA02-9DDD-4205-8CCE-3A640B657727"")
{
ISpace[""UI_PurchaseRow""].Visible=""true"";
}");
}
else
{
base.WriteDebugInfo(@"else");
if(ISpace["FormVersionId"].Value=="73B8AA02-9DDD-4205-8CCE-3A640B657727")
{
ISpace["UI_PurchaseRow"].Visible="false";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""73B8AA02-9DDD-4205-8CCE-3A640B657727"")
{
ISpace[""UI_PurchaseRow""].Visible=""false"";
}");
ISpace["MF_d1_Classification"].Value="";
base.WriteDebugInfo(@"ISpace[""MF_d1_Classification""].Value="""";");
ISpace["MF_d1_SubClassification"].Value="";
base.WriteDebugInfo(@"ISpace[""MF_d1_SubClassification""].Value="""";");
}
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

var querySource7965F232BCCC495BA03ABBB242CA1F4D =GetQueryExpressionDataSource("7965F232-BCCC-495B-A03A-BBB242CA1F4D");
Dictionary<short,object> result7965F232BCCC495BA03ABBB242CA1F4D=iSpace.ExecuteQuery(querySource7965F232BCCC495BA03ABBB242CA1F4D,@"EXEC [UpsertProjectFundAllocation] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','" + ISpace["gv_userid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource7965F232BCCC495BA03ABBB242CA1F4D =GetQueryExpressionDataSource(""7965F232-BCCC-495B-A03A-BBB242CA1F4D"");Dictionary<short,object> result7965F232BCCC495BA03ABBB242CA1F4D=iSpace.ExecuteQuery(querySource7965F232BCCC495BA03ABBB242CA1F4D,@""EXEC [UpsertProjectFundAllocation] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','"" + ISpace[""gv_userid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result7965F232BCCC495BA03ABBB242CA1F4D!=null) && (result7965F232BCCC495BA03ABBB242CA1F4D.Count!=0))
{
if(result7965F232BCCC495BA03ABBB242CA1F4D.ContainsKey(0))
ISpace["PFM_ErrId"].Value = result7965F232BCCC495BA03ABBB242CA1F4D[0];
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

var querySource2AA88C52FB414021AC044916C93C6BCA =GetQueryExpressionDataSource("2AA88C52-FB41-4021-AC04-4916C93C6BCA");
Dictionary<short,object> result2AA88C52FB414021AC044916C93C6BCA=iSpace.ExecuteQuery(querySource2AA88C52FB414021AC044916C93C6BCA,@"EXEC [Upsert60e821d0-153e-94bb-1fef-2594b78625bd] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','" + ISpace["FWFM_FundDetailsId"].Value + @"','" + ISpace["FWFM_FundType"].Value + @"','" + ISpace["FWFM_ProjectNo"].Value + @"','" + ISpace["FWFM_BudgetHead"].Value + @"','" + ISpace["FWFM_Amount"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource2AA88C52FB414021AC044916C93C6BCA =GetQueryExpressionDataSource(""2AA88C52-FB41-4021-AC04-4916C93C6BCA"");Dictionary<short,object> result2AA88C52FB414021AC044916C93C6BCA=iSpace.ExecuteQuery(querySource2AA88C52FB414021AC044916C93C6BCA,@""EXEC [Upsert60e821d0-153e-94bb-1fef-2594b78625bd] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','"" + ISpace[""FWFM_FundDetailsId""].Value + @""','"" + ISpace[""FWFM_FundType""].Value + @""','"" + ISpace[""FWFM_ProjectNo""].Value + @""','"" + ISpace[""FWFM_BudgetHead""].Value + @""','"" + ISpace[""FWFM_Amount""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result2AA88C52FB414021AC044916C93C6BCA!=null) && (result2AA88C52FB414021AC044916C93C6BCA.Count!=0))
{
if(result2AA88C52FB414021AC044916C93C6BCA.ContainsKey(0))
ISpace["PFM_ErrId"].Value = result2AA88C52FB414021AC044916C93C6BCA[0];
if(result2AA88C52FB414021AC044916C93C6BCA.ContainsKey(1))
ISpace["PFM_ErrMsg"].Value = result2AA88C52FB414021AC044916C93C6BCA[1];
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

var querySourceA28FD172AE9F490A93039F51D5E01251 =GetQueryExpressionDataSource("A28FD172-AE9F-490A-9303-9F51D5E01251");

DataTable resultA28FD172AE9F490A93039F51D5E01251=iSpace.SetGridDataSource(querySourceA28FD172AE9F490A93039F51D5E01251, _objectFactory.GetGridRPP("MG_FundAllocation"),@"Exec [Get60e821d0-153e-94bb-1fef-2594b78625bd] '" + ISpace["gv_instanceid"].Value + @"'");

iSpace.InsertGridBindDetails("MG_FundAllocation","11",querySourceA28FD172AE9F490A93039F51D5E01251,"Exec [Get60e821d0-153e-94bb-1fef-2594b78625bd] '" + ISpace["gv_instanceid"].Value + @"'",_objectFactory.GetGridRPP("MG_FundAllocation"));

base.WriteDebugInfo(@"var querySourceA28FD172AE9F490A93039F51D5E01251 =GetQueryExpressionDataSource(""A28FD172-AE9F-490A-9303-9F51D5E01251"");DataTable resultA28FD172AE9F490A93039F51D5E01251=iSpace.SetGridDataSource(querySourceA28FD172AE9F490A93039F51D5E01251, _objectFactory.GetGridRPP(""MG_FundAllocation""),@""Exec [Get60e821d0-153e-94bb-1fef-2594b78625bd] '"" + ISpace[""gv_instanceid""].Value + @""'"");iSpace.InsertGridBindDetails(""MG_FundAllocation"",""11"",querySourceA28FD172AE9F490A93039F51D5E01251,""Exec [Get60e821d0-153e-94bb-1fef-2594b78625bd] '"" + ISpace[""gv_instanceid""].Value + @""'"",_objectFactory.GetGridRPP(""MG_FundAllocation""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result252EED7D497E4759952F2CCD48C6E715=acdataIspaceF66E6A92393A4A498F4478FD095E0597.GetQueryExpressionBindings("252EED7D-497E-4759-952F-2CCD48C6E715");
iSpace.SetGridData(resultA28FD172AE9F490A93039F51D5E01251,result252EED7D497E4759952F2CCD48C6E715,"MG_FundAllocation",ref ISpace);
iSpace.UpdateGridBindDetails("MG_FundAllocation",result252EED7D497E4759952F2CCD48C6E715);
base.WriteDebugInfo(@"EXEC [GetFundSum] '@@gv_InstanceId'");

var querySource67ee0211d510d00cff9fde4c659b15ff =GetQueryExpressionDataSource("67ee0211-d510-d00c-ff9f-de4c659b15ff");
Dictionary<short,object> result67ee0211d510d00cff9fde4c659b15ff=iSpace.ExecuteQuery(querySource67ee0211d510d00cff9fde4c659b15ff,@"EXEC [GetFundSum] '" + ISpace["gv_instanceid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource67ee0211d510d00cff9fde4c659b15ff =GetQueryExpressionDataSource(""67ee0211-d510-d00c-ff9f-de4c659b15ff"");Dictionary<short,object> result67ee0211d510d00cff9fde4c659b15ff=iSpace.ExecuteQuery(querySource67ee0211d510d00cff9fde4c659b15ff,@""EXEC [GetFundSum] '"" + ISpace[""gv_instanceid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result67ee0211d510d00cff9fde4c659b15ff!=null) && (result67ee0211d510d00cff9fde4c659b15ff.Count!=0))
{
if(result67ee0211d510d00cff9fde4c659b15ff.ContainsKey(0))
ISpace["MF_FundTotal"].Value = result67ee0211d510d00cff9fde4c659b15ff[0];
}
else{
ISpace["MF_FundTotal"].Value = null;
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_delete_billdetails (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Delete_BillDetails-OnClick");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["MF_DeleteRowId"].Value=ISpace["MG_d2_ReimbursementDetailsId"].Value;
base.WriteDebugInfo(@"ISpace[""MF_DeleteRowId""].Value=ISpace[""MG_d2_ReimbursementDetailsId""].Value;");
ISpace["UI_BillDeleteDialog"].ShowDialog=true;;
base.WriteDebugInfo(@"ISpace[""UI_BillDeleteDialog""].ShowDialog=true;;");
}
object MG_d2_Amount=iSpace.Sum("[98357E55-B276-4E6E-9A45-2588BF6CE0E4]","MG_d2_Amount","",ISpace["gv_instanceid"].Value);
ISpace["MF_d1_TotalAmount"].Value=Convert.ChangeType(MG_d2_Amount, MG_d2_Amount.GetType());;
base.WriteDebugInfo(@"object MG_d2_Amount=iSpace.Sum(""[98357E55-B276-4E6E-9A45-2588BF6CE0E4]"",""MG_d2_Amount"","""",ISpace[""gv_instanceid""].Value);
ISpace[""MF_d1_TotalAmount""].Value=Convert.ChangeType(MG_d2_Amount, MG_d2_Amount.GetType());;");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_edit_billdetails (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Edit_BillDetails-OnClick");
ISpace["growid"].Value=ISpace["BillDetails_RowId"].Value;
base.WriteDebugInfo(@"ISpace[""growid""].Value=ISpace[""BillDetails_RowId""].Value;");
base.WriteDebugInfo(@"EXEC [LoadFormGridData98357E55-B276-4E6E-9A45-2588BF6CE0E4] '@@gv_InstanceId','@@gv_ActivityMapId','98357E55-B276-4E6E-9A45-2588BF6CE0E4','#growid',#BillDetails_Sequence");

var querySourceCD756DFD7F974690BF3675DE5682E2E2 =GetQueryExpressionDataSource("CD756DFD-7F97-4690-BF36-75DE5682E2E2");
Dictionary<short,object> resultCD756DFD7F974690BF3675DE5682E2E2=iSpace.ExecuteQuery(querySourceCD756DFD7F974690BF3675DE5682E2E2,@"EXEC [LoadFormGridData98357E55-B276-4E6E-9A45-2588BF6CE0E4] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','98357E55-B276-4E6E-9A45-2588BF6CE0E4','" + ISpace["growid"].Value + @"'," + ISpace["BillDetails_Sequence"].Value + @"",false);

base.WriteDebugInfo(@"var querySourceCD756DFD7F974690BF3675DE5682E2E2 =GetQueryExpressionDataSource(""CD756DFD-7F97-4690-BF36-75DE5682E2E2"");Dictionary<short,object> resultCD756DFD7F974690BF3675DE5682E2E2=iSpace.ExecuteQuery(querySourceCD756DFD7F974690BF3675DE5682E2E2,@""EXEC [LoadFormGridData98357E55-B276-4E6E-9A45-2588BF6CE0E4] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','98357E55-B276-4E6E-9A45-2588BF6CE0E4','"" + ISpace[""growid""].Value + @""',"" + ISpace[""BillDetails_Sequence""].Value + @"""",false);");
base.WriteDebugInfo(@"EXEC [LoadFormGridData98357E55-B276-4E6E-9A45-2588BF6CE0E4] '@@gv_InstanceId','@@gv_ActivityMapId','98357E55-B276-4E6E-9A45-2588BF6CE0E4','#growid',#BillDetails_Sequence");

if((resultCD756DFD7F974690BF3675DE5682E2E2!=null) && (resultCD756DFD7F974690BF3675DE5682E2E2.Count!=0))
{
if(resultCD756DFD7F974690BF3675DE5682E2E2.ContainsKey(3))
ISpace["MFG_d2_BillDate"].Value = resultCD756DFD7F974690BF3675DE5682E2E2[3];
if(resultCD756DFD7F974690BF3675DE5682E2E2.ContainsKey(6))
ISpace["MFG_d2_Amount"].Value = resultCD756DFD7F974690BF3675DE5682E2E2[6];
if(resultCD756DFD7F974690BF3675DE5682E2E2.ContainsKey(4))
ISpace["MFG_d2_BillDocument"].Value = resultCD756DFD7F974690BF3675DE5682E2E2[4];
if(resultCD756DFD7F974690BF3675DE5682E2E2.ContainsKey(1))
ISpace["MFG_d2_ReimbursementId"].Value = resultCD756DFD7F974690BF3675DE5682E2E2[1];
if(resultCD756DFD7F974690BF3675DE5682E2E2.ContainsKey(0))
ISpace["MFG_d2_ReimbursementDetailsId"].Value = resultCD756DFD7F974690BF3675DE5682E2E2[0];
if(resultCD756DFD7F974690BF3675DE5682E2E2.ContainsKey(5))
ISpace["MFG_d2_ItemDescription"].Value = resultCD756DFD7F974690BF3675DE5682E2E2[5];
if(resultCD756DFD7F974690BF3675DE5682E2E2.ContainsKey(2))
ISpace["MFG_d2_BillNo"].Value = resultCD756DFD7F974690BF3675DE5682E2E2[2];
}
else{
ISpace["MFG_d2_BillDate"].Value = null;ISpace["MFG_d2_Amount"].Value = null;ISpace["MFG_d2_BillDocument"].Value = null;ISpace["MFG_d2_ReimbursementId"].Value = null;ISpace["MFG_d2_ReimbursementDetailsId"].Value = null;ISpace["MFG_d2_ItemDescription"].Value = null;ISpace["MFG_d2_BillNo"].Value = null;
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mf_d1_reimbursementtype (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MF_d1_ReimbursementType-OnChange");
if(ISpace["MF_d1_ReimbursementType"].Value=="2")
{
base.WriteDebugInfo(@"if(ISpace[""MF_d1_ReimbursementType""].Value==""2"")");
if(ISpace["FormVersionId"].Value=="73B8AA02-9DDD-4205-8CCE-3A640B657727")
{
ISpace["UI_PurchaseRow"].Visible="true";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""73B8AA02-9DDD-4205-8CCE-3A640B657727"")
{
ISpace[""UI_PurchaseRow""].Visible=""true"";
}");
}
else
{
base.WriteDebugInfo(@"else");
if(ISpace["FormVersionId"].Value=="73B8AA02-9DDD-4205-8CCE-3A640B657727")
{
ISpace["UI_PurchaseRow"].Visible="false";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""73B8AA02-9DDD-4205-8CCE-3A640B657727"")
{
ISpace[""UI_PurchaseRow""].Visible=""false"";
}");
ISpace["MF_d1_Classification"].Value="";
base.WriteDebugInfo(@"ISpace[""MF_d1_Classification""].Value="""";");
ISpace["MF_d1_SubClassification"].Value="";
base.WriteDebugInfo(@"ISpace[""MF_d1_SubClassification""].Value="""";");
}
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
if(ISpace["FWFM_FundType"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""FWFM_FundType""].Value=="""")");
ISpace["FWFM_BudgetHead"].Visible="false";ISpace["FWFM_ProjectNo"].Visible="false";ISpace["FWFM_Amount"].Visible="false";
base.WriteDebugInfo(@"ISpace[""FWFM_BudgetHead""].Visible=""false"";ISpace[""FWFM_ProjectNo""].Visible=""false"";ISpace[""FWFM_Amount""].Visible=""false"";");
}
if(ISpace["FWFM_FundType"].Value=="1" || ISpace["FWFM_FundType"].Value=="3")
{
base.WriteDebugInfo(@"if(ISpace[""FWFM_FundType""].Value==""1"" || ISpace[""FWFM_FundType""].Value==""3"")");
ISpace["FWFM_BudgetHead"].Visible="true";ISpace["FWFM_ProjectNo"].Visible="true";
base.WriteDebugInfo(@"ISpace[""FWFM_BudgetHead""].Visible=""true"";ISpace[""FWFM_ProjectNo""].Visible=""true"";");
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

var querySourceF573333363114CC68A331CD0C39945BB =GetQueryExpressionDataSource("F5733333-6311-4CC6-8A33-1CD0C39945BB");
Dictionary<short,object> resultF573333363114CC68A331CD0C39945BB=iSpace.ExecuteQuery(querySourceF573333363114CC68A331CD0C39945BB,@"Exec [Get60e821d0-153e-94bb-1fef-2594b78625bd] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["PFA_FundDetailsId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceF573333363114CC68A331CD0C39945BB =GetQueryExpressionDataSource(""F5733333-6311-4CC6-8A33-1CD0C39945BB"");Dictionary<short,object> resultF573333363114CC68A331CD0C39945BB=iSpace.ExecuteQuery(querySourceF573333363114CC68A331CD0C39945BB,@""Exec [Get60e821d0-153e-94bb-1fef-2594b78625bd] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""PFA_FundDetailsId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultF573333363114CC68A331CD0C39945BB!=null) && (resultF573333363114CC68A331CD0C39945BB.Count!=0))
{
if(resultF573333363114CC68A331CD0C39945BB.ContainsKey(9))
ISpace["FWFM_BudgetHead"].Value = resultF573333363114CC68A331CD0C39945BB[9];
if(resultF573333363114CC68A331CD0C39945BB.ContainsKey(5))
ISpace["FWFM_FundType"].Value = resultF573333363114CC68A331CD0C39945BB[5];
if(resultF573333363114CC68A331CD0C39945BB.ContainsKey(7))
ISpace["FWFM_ProjectNo"].Value = resultF573333363114CC68A331CD0C39945BB[7];
if(resultF573333363114CC68A331CD0C39945BB.ContainsKey(11))
ISpace["FWFM_Amount"].Value = resultF573333363114CC68A331CD0C39945BB[11];
if(resultF573333363114CC68A331CD0C39945BB.ContainsKey(3))
ISpace["FWFM_FundDetailsId"].Value = resultF573333363114CC68A331CD0C39945BB[3];
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
base.WriteDebugInfo(@"EXEC [GetFundSum] '@@gv_InstanceId'");

var querySource67ee0211d510d00cff9fde4c659b15ff =GetQueryExpressionDataSource("67ee0211-d510-d00c-ff9f-de4c659b15ff");
Dictionary<short,object> result67ee0211d510d00cff9fde4c659b15ff=iSpace.ExecuteQuery(querySource67ee0211d510d00cff9fde4c659b15ff,@"EXEC [GetFundSum] '" + ISpace["gv_instanceid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource67ee0211d510d00cff9fde4c659b15ff =GetQueryExpressionDataSource(""67ee0211-d510-d00c-ff9f-de4c659b15ff"");Dictionary<short,object> result67ee0211d510d00cff9fde4c659b15ff=iSpace.ExecuteQuery(querySource67ee0211d510d00cff9fde4c659b15ff,@""EXEC [GetFundSum] '"" + ISpace[""gv_instanceid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result67ee0211d510d00cff9fde4c659b15ff!=null) && (result67ee0211d510d00cff9fde4c659b15ff.Count!=0))
{
if(result67ee0211d510d00cff9fde4c659b15ff.ContainsKey(0))
ISpace["MF_FundTotal"].Value = result67ee0211d510d00cff9fde4c659b15ff[0];
}
else{
ISpace["MF_FundTotal"].Value = null;
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_fwfm_projectno (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"FWFM_ProjectNo-OnChange");
ISpace["FWFM_BudgetHead"].rElemData=iSpace.Reload(ISpace["FWFM_BudgetHead"].Value,@"Exec SP_GetDistrubitionDetails 5,'" + ISpace["PFMF_PackageProcessMapId"].Value + @"','" + ISpace["FWFM_FundType"].Value + @"','','','','','" + ISpace["FWFM_ProjectNo"].Value + @"'","9ADED37B-CD11-426B-AF16-DEAC75685EF5");
base.WriteDebugInfo(@"ISpace[""FWFM_BudgetHead""].rElemData=iSpace.Reload(ISpace[""FWFM_BudgetHead""].Value,@""Exec SP_GetDistrubitionDetails 5,'"" + ISpace[""PFMF_PackageProcessMapId""].Value + @""','"" + ISpace[""FWFM_FundType""].Value + @""','','','','','"" + ISpace[""FWFM_ProjectNo""].Value + @""'"",""9ADED37B-CD11-426B-AF16-DEAC75685EF5"");");
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

var querySource7BA23C85C8A64F22BBF5E91460186E30 =GetQueryExpressionDataSource("7BA23C85-C8A6-4F22-BBF5-E91460186E30");
Dictionary<short,object> result7BA23C85C8A64F22BBF5E91460186E30=iSpace.ExecuteQuery(querySource7BA23C85C8A64F22BBF5E91460186E30,@"EXEC[Delete60e821d0-153e_94bb-1fef-2594b78625bd] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["PFM_FundDetailsId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource7BA23C85C8A64F22BBF5E91460186E30 =GetQueryExpressionDataSource(""7BA23C85-C8A6-4F22-BBF5-E91460186E30"");Dictionary<short,object> result7BA23C85C8A64F22BBF5E91460186E30=iSpace.ExecuteQuery(querySource7BA23C85C8A64F22BBF5E91460186E30,@""EXEC[Delete60e821d0-153e_94bb-1fef-2594b78625bd] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""PFM_FundDetailsId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result7BA23C85C8A64F22BBF5E91460186E30!=null) && (result7BA23C85C8A64F22BBF5E91460186E30.Count!=0))
{
if(result7BA23C85C8A64F22BBF5E91460186E30.ContainsKey(0))
ISpace["PFM_ErrId"].Value = result7BA23C85C8A64F22BBF5E91460186E30[0];
if(result7BA23C85C8A64F22BBF5E91460186E30.ContainsKey(1))
ISpace["PFM_ErrMsg"].Value = result7BA23C85C8A64F22BBF5E91460186E30[1];
}
else{
ISpace["PFM_ErrId"].Value = null;ISpace["PFM_ErrMsg"].Value = null;
}
ISpace["Message"].Value=String.Format(@"{0}",ISpace["PFM_ErrMsg"].Value);
base.WriteDebugInfo(@"ISpace[""Message""].Value=String.Format(@""{0}"",ISpace[""PFM_ErrMsg""].Value);");

var querySourceA28FD172AE9F490A93039F51D5E01251 =GetQueryExpressionDataSource("A28FD172-AE9F-490A-9303-9F51D5E01251");

DataTable resultA28FD172AE9F490A93039F51D5E01251=iSpace.SetGridDataSource(querySourceA28FD172AE9F490A93039F51D5E01251, _objectFactory.GetGridRPP("MG_FundAllocation"),@"Exec [Get60e821d0-153e-94bb-1fef-2594b78625bd] '" + ISpace["gv_instanceid"].Value + @"'");

iSpace.InsertGridBindDetails("MG_FundAllocation","11",querySourceA28FD172AE9F490A93039F51D5E01251,"Exec [Get60e821d0-153e-94bb-1fef-2594b78625bd] '" + ISpace["gv_instanceid"].Value + @"'",_objectFactory.GetGridRPP("MG_FundAllocation"));

base.WriteDebugInfo(@"var querySourceA28FD172AE9F490A93039F51D5E01251 =GetQueryExpressionDataSource(""A28FD172-AE9F-490A-9303-9F51D5E01251"");DataTable resultA28FD172AE9F490A93039F51D5E01251=iSpace.SetGridDataSource(querySourceA28FD172AE9F490A93039F51D5E01251, _objectFactory.GetGridRPP(""MG_FundAllocation""),@""Exec [Get60e821d0-153e-94bb-1fef-2594b78625bd] '"" + ISpace[""gv_instanceid""].Value + @""'"");iSpace.InsertGridBindDetails(""MG_FundAllocation"",""11"",querySourceA28FD172AE9F490A93039F51D5E01251,""Exec [Get60e821d0-153e-94bb-1fef-2594b78625bd] '"" + ISpace[""gv_instanceid""].Value + @""'"",_objectFactory.GetGridRPP(""MG_FundAllocation""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result252EED7D497E4759952F2CCD48C6E715=acdataIspaceF66E6A92393A4A498F4478FD095E0597.GetQueryExpressionBindings("252EED7D-497E-4759-952F-2CCD48C6E715");
iSpace.SetGridData(resultA28FD172AE9F490A93039F51D5E01251,result252EED7D497E4759952F2CCD48C6E715,"MG_FundAllocation",ref ISpace);
iSpace.UpdateGridBindDetails("MG_FundAllocation",result252EED7D497E4759952F2CCD48C6E715);
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
private void SubscribeElementEvents_fwab_projectno (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"FWAB_ProjectNo-OnChange");

var querySourceE8CDF3599A114739A9979B7F3B8E3BA0 =GetQueryExpressionDataSource("E8CDF359-9A11-4739-A997-9B7F3B8E3BA0");

DataTable resultE8CDF3599A114739A9979B7F3B8E3BA0=iSpace.SetGridDataSource(querySourceE8CDF3599A114739A9979B7F3B8E3BA0, _objectFactory.GetGridRPP("MG_AvailableBudget"),@"EXEC [GetProjectBudgetInformation] '" + ISpace["FWAB_ProjectNo"].Value + @"'");

iSpace.InsertGridBindDetails("MG_AvailableBudget","11",querySourceE8CDF3599A114739A9979B7F3B8E3BA0,"EXEC [GetProjectBudgetInformation] '" + ISpace["FWAB_ProjectNo"].Value + @"'",_objectFactory.GetGridRPP("MG_AvailableBudget"));

base.WriteDebugInfo(@"var querySourceE8CDF3599A114739A9979B7F3B8E3BA0 =GetQueryExpressionDataSource(""E8CDF359-9A11-4739-A997-9B7F3B8E3BA0"");DataTable resultE8CDF3599A114739A9979B7F3B8E3BA0=iSpace.SetGridDataSource(querySourceE8CDF3599A114739A9979B7F3B8E3BA0, _objectFactory.GetGridRPP(""MG_AvailableBudget""),@""EXEC [GetProjectBudgetInformation] '"" + ISpace[""FWAB_ProjectNo""].Value + @""'"");iSpace.InsertGridBindDetails(""MG_AvailableBudget"",""11"",querySourceE8CDF3599A114739A9979B7F3B8E3BA0,""EXEC [GetProjectBudgetInformation] '"" + ISpace[""FWAB_ProjectNo""].Value + @""'"",_objectFactory.GetGridRPP(""MG_AvailableBudget""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result17166BB134FE401CA6BE6657FD12BA43=acdataIspaceF66E6A92393A4A498F4478FD095E0597.GetQueryExpressionBindings("17166BB1-34FE-401C-A6BE-6657FD12BA43");
iSpace.SetGridData(resultE8CDF3599A114739A9979B7F3B8E3BA0,result17166BB134FE401CA6BE6657FD12BA43,"MG_AvailableBudget",ref ISpace);
iSpace.UpdateGridBindDetails("MG_AvailableBudget",result17166BB134FE401CA6BE6657FD12BA43);
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
if(ISpace["MF_d1_ReimbursementType"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""MF_d1_ReimbursementType""].Value=="""")");
ISpace["Message"].Value=@"Error: Please select Reimbursement Type";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Error: Please select Reimbursement Type"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if(ISpace["MF_d1_ReimbursementType"].Value=="2"&&ISpace["MF_d1_Classification"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""MF_d1_ReimbursementType""].Value==""2""&&ISpace[""MF_d1_Classification""].Value=="""")");
ISpace["Message"].Value=@"Error: Please Select Classification";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Error: Please Select Classification"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if(ISpace["MF_d1_ReimbursementType"].Value=="2"&&ISpace["MF_d1_SubClassification"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""MF_d1_ReimbursementType""].Value==""2""&&ISpace[""MF_d1_SubClassification""].Value=="""")");
ISpace["Message"].Value=@"Error:Please Select Sub Classification";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Error:Please Select Sub Classification"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if(ISpace["MF_d1_TotalAmount"].Value!=ISpace["MF_FundTotal"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_d1_TotalAmount""].Value!=ISpace[""MF_FundTotal""].Value)");
ISpace["Message"].Value=@"Error: Overall Bill Amount and Overall Fund Amount must be Equal";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Error: Overall Bill Amount and Overall Fund Amount must be Equal"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if(ISpace["FlowType"].Value=="APPROVE")
{
base.WriteDebugInfo(@"if(ISpace[""FlowType""].Value==""APPROVE"")");
if(ISpace["WMF_MoveTo"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""WMF_MoveTo""].Value=="""")");
ISpace["Message"].Value=@"Error:Please Select Next Action";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Error:Please Select Next Action"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
}
if(ISpace["FlowType"].Value=="RETURN" || ISpace["FlowType"].Value=="REJECT")
{
base.WriteDebugInfo(@"if(ISpace[""FlowType""].Value==""RETURN"" || ISpace[""FlowType""].Value==""REJECT"")");
if(ISpace["WMF_MoveTo"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""WMF_MoveTo""].Value=="""")");
ISpace["Message"].Value=@"Error:Please Select Next Action";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Error:Please Select Next Action"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if(ISpace["Comments"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""Comments""].Value=="""")");
ISpace["Message"].Value=@"Error: Please Enter Comments";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Error: Please Enter Comments"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
}
base.WriteDebugInfo(@"Exec [SaveReimbursementDocuments] '@@gv_InstanceId','@@gv_ProcessMapId','@@gv_UserId'");

var querySourcefdd0ae43508091a4d34f1d5bc5cb4888 =GetQueryExpressionDataSource("fdd0ae43-5080-91a4-d34f-1d5bc5cb4888");
Dictionary<short,object> resultfdd0ae43508091a4d34f1d5bc5cb4888=iSpace.ExecuteQuery(querySourcefdd0ae43508091a4d34f1d5bc5cb4888,@"Exec [SaveReimbursementDocuments] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','" + ISpace["gv_userid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourcefdd0ae43508091a4d34f1d5bc5cb4888 =GetQueryExpressionDataSource(""fdd0ae43-5080-91a4-d34f-1d5bc5cb4888"");Dictionary<short,object> resultfdd0ae43508091a4d34f1d5bc5cb4888=iSpace.ExecuteQuery(querySourcefdd0ae43508091a4d34f1d5bc5cb4888,@""Exec [SaveReimbursementDocuments] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','"" + ISpace[""gv_userid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultfdd0ae43508091a4d34f1d5bc5cb4888!=null) && (resultfdd0ae43508091a4d34f1d5bc5cb4888.Count!=0))
{
if(resultfdd0ae43508091a4d34f1d5bc5cb4888.ContainsKey(0))
ISpace["MF_ErrId"].Value = resultfdd0ae43508091a4d34f1d5bc5cb4888[0];
if(resultfdd0ae43508091a4d34f1d5bc5cb4888.ContainsKey(1))
ISpace["MF_ErrMsg"].Value = resultfdd0ae43508091a4d34f1d5bc5cb4888[1];
}
else{
ISpace["MF_ErrId"].Value = null;ISpace["MF_ErrMsg"].Value = null;
}
if(ISpace["MF_ErrId"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ErrId""].Value==1)");
ISpace["Message"].Value=String.Format(@"{0}",ISpace["MF_ErrMsg"].Value);
base.WriteDebugInfo(@"ISpace[""Message""].Value=String.Format(@""{0}"",ISpace[""MF_ErrMsg""].Value);");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
base.WriteDebugInfo(@"EXEC InnovaceNoCode..[FormSave_7580ABE2-1059-4AB0-AC76-04DE981561BA]   '@@gv_InstanceId','@@gv_ActivityMapId','36447555-6c49-45cd-8563-426f536ebf74','@@gv_InstanceId','#MF_d1_EmployeeBasicInfoId',#MF_d1_TotalAmount,'#MF_d1_Initiatedon','#MF_d1_InitatedBy','#MF_d1_ApplicationStatus','#MF_d1_ReimbursementType','#MF_d1_Classification','#MF_d1_SubClassification','@@gv_UserId','#MF_d1_UpdatedOn'");

var querySource5C837D60C28D4224BAECAFC4E77AECAD =GetQueryExpressionDataSource("5C837D60-C28D-4224-BAEC-AFC4E77AECAD");
Dictionary<short,object> result5C837D60C28D4224BAECAFC4E77AECAD=iSpace.ExecuteQuery(querySource5C837D60C28D4224BAECAFC4E77AECAD,@"EXEC InnovaceNoCode..[FormSave_7580ABE2-1059-4AB0-AC76-04DE981561BA]   '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','36447555-6c49-45cd-8563-426f536ebf74','" + ISpace["gv_instanceid"].Value + @"','" + ISpace["MF_d1_EmployeeBasicInfoId"].Value + @"'," + ISpace["MF_d1_TotalAmount"].Value + @",'" + ISpace["MF_d1_Initiatedon"].Value + @"','" + ISpace["MF_d1_InitatedBy"].Value + @"','" + ISpace["MF_d1_ApplicationStatus"].Value + @"','" + ISpace["MF_d1_ReimbursementType"].Value + @"','" + ISpace["MF_d1_Classification"].Value + @"','" + ISpace["MF_d1_SubClassification"].Value + @"','" + ISpace["gv_userid"].Value + @"','" + ISpace["MF_d1_UpdatedOn"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource5C837D60C28D4224BAECAFC4E77AECAD =GetQueryExpressionDataSource(""5C837D60-C28D-4224-BAEC-AFC4E77AECAD"");Dictionary<short,object> result5C837D60C28D4224BAECAFC4E77AECAD=iSpace.ExecuteQuery(querySource5C837D60C28D4224BAECAFC4E77AECAD,@""EXEC InnovaceNoCode..[FormSave_7580ABE2-1059-4AB0-AC76-04DE981561BA]   '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','36447555-6c49-45cd-8563-426f536ebf74','"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""MF_d1_EmployeeBasicInfoId""].Value + @""',"" + ISpace[""MF_d1_TotalAmount""].Value + @"",'"" + ISpace[""MF_d1_Initiatedon""].Value + @""','"" + ISpace[""MF_d1_InitatedBy""].Value + @""','"" + ISpace[""MF_d1_ApplicationStatus""].Value + @""','"" + ISpace[""MF_d1_ReimbursementType""].Value + @""','"" + ISpace[""MF_d1_Classification""].Value + @""','"" + ISpace[""MF_d1_SubClassification""].Value + @""','"" + ISpace[""gv_userid""].Value + @""','"" + ISpace[""MF_d1_UpdatedOn""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result5C837D60C28D4224BAECAFC4E77AECAD!=null) && (result5C837D60C28D4224BAECAFC4E77AECAD.Count!=0))
{
if(result5C837D60C28D4224BAECAFC4E77AECAD.ContainsKey(0))
ISpace["ExecutionMessage"].Value = result5C837D60C28D4224BAECAFC4E77AECAD[0];
}
else{
ISpace["ExecutionMessage"].Value = null;
}
base.WriteDebugInfo(@"EXEC InnovaceNoCode..[GridSave_98357E55-B276-4E6E-9A45-2588BF6CE0E4]   '@@gv_InstanceId','@@gv_ActivityMapId','98357E55-B276-4E6E-9A45-2588BF6CE0E4'");

var querySource4729BCA08B6D4424A3D94EB16A532C2B =GetQueryExpressionDataSource("4729BCA0-8B6D-4424-A3D9-4EB16A532C2B");
Dictionary<short,object> result4729BCA08B6D4424A3D94EB16A532C2B=iSpace.ExecuteQuery(querySource4729BCA08B6D4424A3D94EB16A532C2B,@"EXEC InnovaceNoCode..[GridSave_98357E55-B276-4E6E-9A45-2588BF6CE0E4]   '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','98357E55-B276-4E6E-9A45-2588BF6CE0E4'",false);

base.WriteDebugInfo(@"var querySource4729BCA08B6D4424A3D94EB16A532C2B =GetQueryExpressionDataSource(""4729BCA0-8B6D-4424-A3D9-4EB16A532C2B"");Dictionary<short,object> result4729BCA08B6D4424A3D94EB16A532C2B=iSpace.ExecuteQuery(querySource4729BCA08B6D4424A3D94EB16A532C2B,@""EXEC InnovaceNoCode..[GridSave_98357E55-B276-4E6E-9A45-2588BF6CE0E4]   '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','98357E55-B276-4E6E-9A45-2588BF6CE0E4'"",false);");
base.WriteDebugInfo(@"");

if((result4729BCA08B6D4424A3D94EB16A532C2B!=null) && (result4729BCA08B6D4424A3D94EB16A532C2B.Count!=0))
{
if(result4729BCA08B6D4424A3D94EB16A532C2B.ContainsKey(0))
ISpace["MF_ErrId"].Value = result4729BCA08B6D4424A3D94EB16A532C2B[0];
if(result4729BCA08B6D4424A3D94EB16A532C2B.ContainsKey(1))
ISpace["MF_ErrMsg"].Value = result4729BCA08B6D4424A3D94EB16A532C2B[1];
}
else{
ISpace["MF_ErrId"].Value = null;ISpace["MF_ErrMsg"].Value = null;
}
if(ISpace["MF_ErrId"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ErrId""].Value==1)");
ISpace["Message"].Value=String.Format(@"{0}",ISpace["MF_ErrMsg"].Value);
base.WriteDebugInfo(@"ISpace[""Message""].Value=String.Format(@""{0}"",ISpace[""MF_ErrMsg""].Value);");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
base.WriteDebugInfo(@"EXEC [UpsertProjectFundAllocation] '@@gv_InstanceId','@@gv_ProcessMapId','@@gv_UserId'");

var querySource7965F232BCCC495BA03ABBB242CA1F4D =GetQueryExpressionDataSource("7965F232-BCCC-495B-A03A-BBB242CA1F4D");
Dictionary<short,object> result7965F232BCCC495BA03ABBB242CA1F4D=iSpace.ExecuteQuery(querySource7965F232BCCC495BA03ABBB242CA1F4D,@"EXEC [UpsertProjectFundAllocation] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','" + ISpace["gv_userid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource7965F232BCCC495BA03ABBB242CA1F4D =GetQueryExpressionDataSource(""7965F232-BCCC-495B-A03A-BBB242CA1F4D"");Dictionary<short,object> result7965F232BCCC495BA03ABBB242CA1F4D=iSpace.ExecuteQuery(querySource7965F232BCCC495BA03ABBB242CA1F4D,@""EXEC [UpsertProjectFundAllocation] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','"" + ISpace[""gv_userid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result7965F232BCCC495BA03ABBB242CA1F4D!=null) && (result7965F232BCCC495BA03ABBB242CA1F4D.Count!=0))
{
if(result7965F232BCCC495BA03ABBB242CA1F4D.ContainsKey(0))
ISpace["PFM_ErrId"].Value = result7965F232BCCC495BA03ABBB242CA1F4D[0];
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
private void SubscribeElementEvents_bill_no (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Bill_No-OnClick");
ISpace["UI_BillDeleteDialog"].HideDialog=true;;
base.WriteDebugInfo(@"ISpace[""UI_BillDeleteDialog""].HideDialog=true;;");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_bill_yes (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Bill_Yes-OnClick");

var querySourcebb2eb3973d6467dc83f282b7f1189e7f =GetQueryExpressionDataSource("bb2eb397-3d64-67dc-83f2-82b7f1189e7f");

DataTable resultbb2eb3973d6467dc83f282b7f1189e7f=iSpace.SetGridDataSource(querySourcebb2eb3973d6467dc83f282b7f1189e7f, _objectFactory.GetGridRPP("BillDetails"),@"EXEC [Delete98357E55-B276-4E6E-9A45-2588BF6CE0E4] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["MF_DeleteRowId"].Value + @"'");

iSpace.InsertGridBindDetails("BillDetails","11",querySourcebb2eb3973d6467dc83f282b7f1189e7f,"EXEC [Delete98357E55-B276-4E6E-9A45-2588BF6CE0E4] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["MF_DeleteRowId"].Value + @"'",_objectFactory.GetGridRPP("BillDetails"));

base.WriteDebugInfo(@"var querySourcebb2eb3973d6467dc83f282b7f1189e7f =GetQueryExpressionDataSource(""bb2eb397-3d64-67dc-83f2-82b7f1189e7f"");DataTable resultbb2eb3973d6467dc83f282b7f1189e7f=iSpace.SetGridDataSource(querySourcebb2eb3973d6467dc83f282b7f1189e7f, _objectFactory.GetGridRPP(""BillDetails""),@""EXEC [Delete98357E55-B276-4E6E-9A45-2588BF6CE0E4] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""MF_DeleteRowId""].Value + @""'"");iSpace.InsertGridBindDetails(""BillDetails"",""11"",querySourcebb2eb3973d6467dc83f282b7f1189e7f,""EXEC [Delete98357E55-B276-4E6E-9A45-2588BF6CE0E4] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""MF_DeleteRowId""].Value + @""'"",_objectFactory.GetGridRPP(""BillDetails""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result0760b579ea7520467d7136abfbdd10d7=acdataIspaceF66E6A92393A4A498F4478FD095E0597.GetQueryExpressionBindings("0760b579-ea75-2046-7d71-36abfbdd10d7");
iSpace.SetGridData(resultbb2eb3973d6467dc83f282b7f1189e7f,result0760b579ea7520467d7136abfbdd10d7,"BillDetails",ref ISpace);
iSpace.UpdateGridBindDetails("BillDetails",result0760b579ea7520467d7136abfbdd10d7);
ISpace["UI_BillDeleteDialog"].HideDialog=true;;
base.WriteDebugInfo(@"ISpace[""UI_BillDeleteDialog""].HideDialog=true;;");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_save_billdetails (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Save_BillDetails-OnClick");
if(ISpace["MFG_d2_BillNo"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""MFG_d2_BillNo""].Value=="""")");
ISpace["Message"].Value=@"Error: Please Enter the Bill No";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Error: Please Enter the Bill No"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if((ISpace["MFG_d2_BillDate"].Value == null))
{
base.WriteDebugInfo(@"if((ISpace[""MFG_d2_BillDate""].Value == null))");
ISpace["Message"].Value=@"Error: Please Select Bill Date";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Error: Please Select Bill Date"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if(ISpace["MFG_d2_Amount"].Value==0)
{
base.WriteDebugInfo(@"if(ISpace[""MFG_d2_Amount""].Value==0)");
ISpace["Message"].Value=@"Error: Please Enter the Amount";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Error: Please Enter the Amount"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if(ISpace["MFG_d2_ItemDescription"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""MFG_d2_ItemDescription""].Value=="""")");
ISpace["Message"].Value=@"Error: Please Enter the Item Description";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Error: Please Enter the Item Description"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if(ISpace["MFG_d2_BillDate"].Value>CurrentDate())
{
base.WriteDebugInfo(@"if(ISpace[""MFG_d2_BillDate""].Value>CurrentDate())");
ISpace["Message"].Value=@"Error: Bill Date Should be Less than the current Date";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Error: Bill Date Should be Less than the current Date"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if(ISpace["growid"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""growid""].Value=="""")");

var querySource96448A8E05CD4B92A281D967231AC747 =GetQueryExpressionDataSource("96448A8E-05CD-4B92-A281-D967231AC747");

DataTable result96448A8E05CD4B92A281D967231AC747=iSpace.SetGridDataSource(querySource96448A8E05CD4B92A281D967231AC747, _objectFactory.GetGridRPP("BillDetails"),@"EXEC [AddFormGridData98357E55-B276-4E6E-9A45-2588BF6CE0E4] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','98357E55-B276-4E6E-9A45-2588BF6CE0E4','" + ISpace["growid"].Value + @"'," + ISpace["BillDetails_Sequence"].Value + @",'" + ISpace["MFG_d2_ReimbursementDetailsId"].Value + @"','" + ISpace["MFG_d2_ReimbursementId"].Value + @"','" + ISpace["MFG_d2_BillNo"].Value + @"','" + ISpace["MFG_d2_BillDate"].Value + @"'," + ISpace["MFG_d2_BillDocument"].Value + @",'" + ISpace["MFG_d2_ItemDescription"].Value + @"'," + ISpace["MFG_d2_Amount"].Value + @"");

iSpace.InsertGridBindDetails("BillDetails","11",querySource96448A8E05CD4B92A281D967231AC747,"EXEC [AddFormGridData98357E55-B276-4E6E-9A45-2588BF6CE0E4] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','98357E55-B276-4E6E-9A45-2588BF6CE0E4','" + ISpace["growid"].Value + @"'," + ISpace["BillDetails_Sequence"].Value + @",'" + ISpace["MFG_d2_ReimbursementDetailsId"].Value + @"','" + ISpace["MFG_d2_ReimbursementId"].Value + @"','" + ISpace["MFG_d2_BillNo"].Value + @"','" + ISpace["MFG_d2_BillDate"].Value + @"'," + ISpace["MFG_d2_BillDocument"].Value + @",'" + ISpace["MFG_d2_ItemDescription"].Value + @"'," + ISpace["MFG_d2_Amount"].Value + @"",_objectFactory.GetGridRPP("BillDetails"));

base.WriteDebugInfo(@"var querySource96448A8E05CD4B92A281D967231AC747 =GetQueryExpressionDataSource(""96448A8E-05CD-4B92-A281-D967231AC747"");DataTable result96448A8E05CD4B92A281D967231AC747=iSpace.SetGridDataSource(querySource96448A8E05CD4B92A281D967231AC747, _objectFactory.GetGridRPP(""BillDetails""),@""EXEC [AddFormGridData98357E55-B276-4E6E-9A45-2588BF6CE0E4] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','98357E55-B276-4E6E-9A45-2588BF6CE0E4','"" + ISpace[""growid""].Value + @""',"" + ISpace[""BillDetails_Sequence""].Value + @"",'"" + ISpace[""MFG_d2_ReimbursementDetailsId""].Value + @""','"" + ISpace[""MFG_d2_ReimbursementId""].Value + @""','"" + ISpace[""MFG_d2_BillNo""].Value + @""','"" + ISpace[""MFG_d2_BillDate""].Value + @""',"" + ISpace[""MFG_d2_BillDocument""].Value + @"",'"" + ISpace[""MFG_d2_ItemDescription""].Value + @""',"" + ISpace[""MFG_d2_Amount""].Value + @"""");iSpace.InsertGridBindDetails(""BillDetails"",""11"",querySource96448A8E05CD4B92A281D967231AC747,""EXEC [AddFormGridData98357E55-B276-4E6E-9A45-2588BF6CE0E4] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','98357E55-B276-4E6E-9A45-2588BF6CE0E4','"" + ISpace[""growid""].Value + @""',"" + ISpace[""BillDetails_Sequence""].Value + @"",'"" + ISpace[""MFG_d2_ReimbursementDetailsId""].Value + @""','"" + ISpace[""MFG_d2_ReimbursementId""].Value + @""','"" + ISpace[""MFG_d2_BillNo""].Value + @""','"" + ISpace[""MFG_d2_BillDate""].Value + @""',"" + ISpace[""MFG_d2_BillDocument""].Value + @"",'"" + ISpace[""MFG_d2_ItemDescription""].Value + @""',"" + ISpace[""MFG_d2_Amount""].Value + @"""",_objectFactory.GetGridRPP(""BillDetails""));");
base.WriteDebugInfo(@"EXEC [AddFormGridData98357E55-B276-4E6E-9A45-2588BF6CE0E4] '@@gv_InstanceId','@@gv_ActivityMapId','98357E55-B276-4E6E-9A45-2588BF6CE0E4','#growid',#BillDetails_Sequence,'#MFG_d2_ReimbursementDetailsId','#MFG_d2_ReimbursementId','#MFG_d2_BillNo','#MFG_d2_BillDate',#MFG_d2_BillDocument,'#MFG_d2_ItemDescription',#MFG_d2_Amount");


List<Triplet<string, short, short?>> result748D8E74B4E34E40B6B7B00770E23B22=acdataIspaceF66E6A92393A4A498F4478FD095E0597.GetQueryExpressionBindings("748D8E74-B4E3-4E40-B6B7-B00770E23B22");
iSpace.SetGridData(result96448A8E05CD4B92A281D967231AC747,result748D8E74B4E34E40B6B7B00770E23B22,"BillDetails",ref ISpace);
iSpace.UpdateGridBindDetails("BillDetails",result748D8E74B4E34E40B6B7B00770E23B22);
}
else
{
base.WriteDebugInfo(@"else");

var querySource40BDB10436A947C7B28234AD458E8107 =GetQueryExpressionDataSource("40BDB104-36A9-47C7-B282-34AD458E8107");

DataTable result40BDB10436A947C7B28234AD458E8107=iSpace.SetGridDataSource(querySource40BDB10436A947C7B28234AD458E8107, _objectFactory.GetGridRPP("BillDetails"),@"EXEC [UpdateFormGridData98357E55-B276-4E6E-9A45-2588BF6CE0E4] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','98357E55-B276-4E6E-9A45-2588BF6CE0E4','" + ISpace["growid"].Value + @"'," + ISpace["BillDetails_Sequence"].Value + @",'" + ISpace["MFG_d2_ReimbursementDetailsId"].Value + @"','" + ISpace["MFG_d2_ReimbursementId"].Value + @"','" + ISpace["MFG_d2_BillNo"].Value + @"','" + ISpace["MFG_d2_BillDate"].Value + @"'," + ISpace["MFG_d2_BillDocument"].Value + @",'" + ISpace["MFG_d2_ItemDescription"].Value + @"'," + ISpace["MFG_d2_Amount"].Value + @"");

iSpace.InsertGridBindDetails("BillDetails","11",querySource40BDB10436A947C7B28234AD458E8107,"EXEC [UpdateFormGridData98357E55-B276-4E6E-9A45-2588BF6CE0E4] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','98357E55-B276-4E6E-9A45-2588BF6CE0E4','" + ISpace["growid"].Value + @"'," + ISpace["BillDetails_Sequence"].Value + @",'" + ISpace["MFG_d2_ReimbursementDetailsId"].Value + @"','" + ISpace["MFG_d2_ReimbursementId"].Value + @"','" + ISpace["MFG_d2_BillNo"].Value + @"','" + ISpace["MFG_d2_BillDate"].Value + @"'," + ISpace["MFG_d2_BillDocument"].Value + @",'" + ISpace["MFG_d2_ItemDescription"].Value + @"'," + ISpace["MFG_d2_Amount"].Value + @"",_objectFactory.GetGridRPP("BillDetails"));

base.WriteDebugInfo(@"var querySource40BDB10436A947C7B28234AD458E8107 =GetQueryExpressionDataSource(""40BDB104-36A9-47C7-B282-34AD458E8107"");DataTable result40BDB10436A947C7B28234AD458E8107=iSpace.SetGridDataSource(querySource40BDB10436A947C7B28234AD458E8107, _objectFactory.GetGridRPP(""BillDetails""),@""EXEC [UpdateFormGridData98357E55-B276-4E6E-9A45-2588BF6CE0E4] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','98357E55-B276-4E6E-9A45-2588BF6CE0E4','"" + ISpace[""growid""].Value + @""',"" + ISpace[""BillDetails_Sequence""].Value + @"",'"" + ISpace[""MFG_d2_ReimbursementDetailsId""].Value + @""','"" + ISpace[""MFG_d2_ReimbursementId""].Value + @""','"" + ISpace[""MFG_d2_BillNo""].Value + @""','"" + ISpace[""MFG_d2_BillDate""].Value + @""',"" + ISpace[""MFG_d2_BillDocument""].Value + @"",'"" + ISpace[""MFG_d2_ItemDescription""].Value + @""',"" + ISpace[""MFG_d2_Amount""].Value + @"""");iSpace.InsertGridBindDetails(""BillDetails"",""11"",querySource40BDB10436A947C7B28234AD458E8107,""EXEC [UpdateFormGridData98357E55-B276-4E6E-9A45-2588BF6CE0E4] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','98357E55-B276-4E6E-9A45-2588BF6CE0E4','"" + ISpace[""growid""].Value + @""',"" + ISpace[""BillDetails_Sequence""].Value + @"",'"" + ISpace[""MFG_d2_ReimbursementDetailsId""].Value + @""','"" + ISpace[""MFG_d2_ReimbursementId""].Value + @""','"" + ISpace[""MFG_d2_BillNo""].Value + @""','"" + ISpace[""MFG_d2_BillDate""].Value + @""',"" + ISpace[""MFG_d2_BillDocument""].Value + @"",'"" + ISpace[""MFG_d2_ItemDescription""].Value + @""',"" + ISpace[""MFG_d2_Amount""].Value + @"""",_objectFactory.GetGridRPP(""BillDetails""));");
base.WriteDebugInfo(@"EXEC [UpdateFormGridData98357E55-B276-4E6E-9A45-2588BF6CE0E4] '@@gv_InstanceId','@@gv_ActivityMapId','98357E55-B276-4E6E-9A45-2588BF6CE0E4','#growid',#BillDetails_Sequence,'#MFG_d2_ReimbursementDetailsId','#MFG_d2_ReimbursementId','#MFG_d2_BillNo','#MFG_d2_BillDate',#MFG_d2_BillDocument,'#MFG_d2_ItemDescription',#MFG_d2_Amount");


List<Triplet<string, short, short?>> result9B93C8729D0F48BD88681C5AB13C7976=acdataIspaceF66E6A92393A4A498F4478FD095E0597.GetQueryExpressionBindings("9B93C872-9D0F-48BD-8868-1C5AB13C7976");
iSpace.SetGridData(result40BDB10436A947C7B28234AD458E8107,result9B93C8729D0F48BD88681C5AB13C7976,"BillDetails",ref ISpace);
iSpace.UpdateGridBindDetails("BillDetails",result9B93C8729D0F48BD88681C5AB13C7976);
}
ISpace["growid"].Value="";
base.WriteDebugInfo(@"ISpace[""growid""].Value="""";");
ISpace["MFG_d2_ReimbursementDetailsId"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d2_ReimbursementDetailsId""].Value="""";");
ISpace["MFG_d2_ReimbursementId"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d2_ReimbursementId""].Value="""";");
ISpace["MFG_d2_BillNo"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d2_BillNo""].Value="""";");
ISpace["MFG_d2_BillDate"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d2_BillDate""].Value="""";");
ISpace["MFG_d2_BillDocument"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d2_BillDocument""].Value="""";");
ISpace["MFG_d2_ItemDescription"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d2_ItemDescription""].Value="""";");
ISpace["MFG_d2_Amount"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d2_Amount""].Value="""";");
object MG_d2_Amount=iSpace.Sum("[98357E55-B276-4E6E-9A45-2588BF6CE0E4]","MG_d2_Amount","",ISpace["gv_instanceid"].Value);
ISpace["MF_d1_TotalAmount"].Value=Convert.ChangeType(MG_d2_Amount, MG_d2_Amount.GetType());;
base.WriteDebugInfo(@"object MG_d2_Amount=iSpace.Sum(""[98357E55-B276-4E6E-9A45-2588BF6CE0E4]"",""MG_d2_Amount"","""",ISpace[""gv_instanceid""].Value);
ISpace[""MF_d1_TotalAmount""].Value=Convert.ChangeType(MG_d2_Amount, MG_d2_Amount.GetType());;");
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
		if(elementName.ToLower().Equals("mf_d1_reimbursementtype"))
    {
    			SubscribeElementEvents_mf_d1_reimbursementtype(ref dfsParam);
    }
		if(elementName.ToLower().Equals("fwfm_fundtype"))
    {
    			SubscribeElementEvents_fwfm_fundtype(ref dfsParam);
    }
		if(elementName.ToLower().Equals("fwfm_projectno"))
    {
    			SubscribeElementEvents_fwfm_projectno(ref dfsParam);
    }
		if(elementName.ToLower().Equals("fwab_projectno"))
    {
    			SubscribeElementEvents_fwab_projectno(ref dfsParam);
    }
		if(elementName.ToLower().Equals("wmf_moveto"))
    {
    			SubscribeElementEvents_wmf_moveto(ref dfsParam);
    }
}
	if(methodName.ToLower().Equals("onclick"))
{
		if(elementName.ToLower().Equals("pfa_widgetsubmit"))
{
			SubscribeElementEvents_pfa_widgetsubmit(ref dfsParam);
}
		if(elementName.ToLower().Equals("fwfm_save"))
{
			SubscribeElementEvents_fwfm_save(ref dfsParam);
}
		if(elementName.ToLower().Equals("delete_billdetails"))
{
			SubscribeElementEvents_delete_billdetails(ref dfsParam);
}
		if(elementName.ToLower().Equals("edit_billdetails"))
{
			SubscribeElementEvents_edit_billdetails(ref dfsParam);
}
		if(elementName.ToLower().Equals("pfa_edit"))
{
			SubscribeElementEvents_pfa_edit(ref dfsParam);
}
		if(elementName.ToLower().Equals("pfa_delete"))
{
			SubscribeElementEvents_pfa_delete(ref dfsParam);
}
		if(elementName.ToLower().Equals("pfm_yes"))
{
			SubscribeElementEvents_pfm_yes(ref dfsParam);
}
		if(elementName.ToLower().Equals("pfm_no"))
{
			SubscribeElementEvents_pfm_no(ref dfsParam);
}
		if(elementName.ToLower().Equals("fwmf_availablebudget"))
{
			SubscribeElementEvents_fwmf_availablebudget(ref dfsParam);
}
		if(elementName.ToLower().Equals("submitform"))
{
			SubscribeElementEvents_submitform(ref dfsParam);
}
		if(elementName.ToLower().Equals("bill_no"))
{
			SubscribeElementEvents_bill_no(ref dfsParam);
}
		if(elementName.ToLower().Equals("bill_yes"))
{
			SubscribeElementEvents_bill_yes(ref dfsParam);
}
		if(elementName.ToLower().Equals("save_billdetails"))
{
			SubscribeElementEvents_save_billdetails(ref dfsParam);
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
	
using System;
    using System.Collections.Generic;    
    using System.Text;	
    using System.Linq;	


	public partial class AcDataISpaceF66E6A92393A4A498F4478FD095E0597  : ExtensionActivityBase
	{		
		
		
		private Dictionary<string,  List<Triplet<string, short, short?>>> queryExpressionBindings = 
											new Dictionary<string,  List<Triplet<string, short, short?>>>
		{
							{"17166BB1-34FE-401C-A6BE-6657FD12BA43", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("PAB_RecievedAmount",3,
														   -1),
								   new Triplet<string, short, short?>("PAB_BudgetName",0,
														   -1),
								   new Triplet<string, short, short?>("PAB_Balance",6,
														   -1),
								   new Triplet<string, short, short?>("PAB_YetToRecieve",2,
														   -1),
								   new Triplet<string, short, short?>("PAB_SanctionedAmount",1,
														   -1),
								   new Triplet<string, short, short?>("PAB_Commitment",4,
														   -1),
								   new Triplet<string, short, short?>("PAB_Spent",5,
														   -1),
								}
			},
							{"0760b579-ea75-2046-7d71-36abfbdd10d7", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("BillDetails_RowId",0,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_ReimbursementId",3,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_BillDocument",6,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_ItemDescription",7,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_BillDate",5,
														   -1),
								   new Triplet<string, short, short?>("BillDetails_Sequence",1,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_ReimbursementDetailsId",2,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_Amount",8,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_BillNo",4,
														   -1),
								}
			},
							{"9B93C872-9D0F-48BD-8868-1C5AB13C7976", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_d2_ReimbursementDetailsId",0,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_ReimbursementId",1,
														   -1),
								   new Triplet<string, short, short?>("BillDetails_RowId",7,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_BillDate",3,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_Amount",6,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_ItemDescription",5,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_BillNo",2,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_BillDocument",4,
														   -1),
								}
			},
							{"E038516D-011F-466B-B4D0-511D8D50C501", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_d2_BillDocument",4,
														   -1),
								   new Triplet<string, short, short?>("BillDetails_RowId",7,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_BillDate",3,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_ItemDescription",5,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_ReimbursementDetailsId",0,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_ReimbursementId",1,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_Amount",6,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_BillNo",2,
														   -1),
								}
			},
							{"252EED7D-497E-4759-952F-2CCD48C6E715", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("PFA_BudgetHeadValue",10,
														   -1),
								   new Triplet<string, short, short?>("PFA_FundTypeValue",6,
														   -1),
								   new Triplet<string, short, short?>("PFA_ProjectNo",7,
														   -1),
								   new Triplet<string, short, short?>("PFA_ProjectNoValue",8,
														   -1),
								   new Triplet<string, short, short?>("MG_FundAllocation_RowId",3,
														   -1),
								   new Triplet<string, short, short?>("PFA_BudgetHead",9,
														   -1),
								   new Triplet<string, short, short?>("PFA_FundType",5,
														   -1),
								   new Triplet<string, short, short?>("PFA_FundDetailsId",12,
														   -1),
								   new Triplet<string, short, short?>("PFA_Amount",11,
														   -1),
								}
			},
							{"748D8E74-B4E3-4E40-B6B7-B00770E23B22", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("BillDetails_RowId",7,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_BillDocument",4,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_ReimbursementDetailsId",0,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_Amount",6,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_ReimbursementId",1,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_ItemDescription",5,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_BillNo",2,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_BillDate",3,
														   -1),
								}
			},
							{"8CFBA89A-2F5D-41AA-8049-CA173EA990A8", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("WMC_User",3,
														   -1),
								   new Triplet<string, short, short?>("WMC_Comments",5,
														   -1),
								   new Triplet<string, short, short?>("WMC_DateofComments",4,
														   -1),
								   new Triplet<string, short, short?>("WMC_StepFrom",1,
														   -1),
								   new Triplet<string, short, short?>("WMC_StepTo",2,
														   -1),
								}
			},
					};	

	

		private Dictionary<string,string> formVersionList =new Dictionary<string,string> 
		{
							{"73B8AA02-9DDD-4205-8CCE-3A640B657727", "Medium"},
					};	

		
		private Dictionary<string,string> formVersionLayoutList =new Dictionary<string,string> 
		{
							{"E57D3627-26BE-4A33-B1E0-99341AE0D03A", ""},
							{"843813D0-5CB7-4730-8B12-4C3EFBD80380", ""},
							{"73B8AA02-9DDD-4205-8CCE-3A640B657727", ""},
							{"3839BDC4-60B0-4053-A5C3-1F9044637C21", ""},
							{"48F336D4-D46E-46C6-89E5-3728A0698475", ""},
							{"AD64BD49-1BE0-4471-BFE5-D22968F47EA1", ""},
							{"C8024318-53D4-4B82-B111-36F3D5C6401B", ""},
							{"E9F47753-F37D-482C-9AE4-EEACE88BCBFF", ""},
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


	public partial class AcDataISpaceAD7FAB31860C4A919BE80D0CF56E7583  : ExtensionActivityBase
	{		
		
		
		private Dictionary<string,  List<Triplet<string, short, short?>>> queryExpressionBindings = 
											new Dictionary<string,  List<Triplet<string, short, short?>>>
		{
							{"17166BB1-34FE-401C-A6BE-6657FD12BA43", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("PAB_RecievedAmount",3,
														   -1),
								   new Triplet<string, short, short?>("PAB_BudgetName",0,
														   -1),
								   new Triplet<string, short, short?>("PAB_Balance",6,
														   -1),
								   new Triplet<string, short, short?>("PAB_YetToRecieve",2,
														   -1),
								   new Triplet<string, short, short?>("PAB_SanctionedAmount",1,
														   -1),
								   new Triplet<string, short, short?>("PAB_Commitment",4,
														   -1),
								   new Triplet<string, short, short?>("PAB_Spent",5,
														   -1),
								}
			},
							{"0760b579-ea75-2046-7d71-36abfbdd10d7", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("BillDetails_RowId",0,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_ReimbursementId",3,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_BillDocument",6,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_ItemDescription",7,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_BillDate",5,
														   -1),
								   new Triplet<string, short, short?>("BillDetails_Sequence",1,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_ReimbursementDetailsId",2,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_Amount",8,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_BillNo",4,
														   -1),
								}
			},
							{"252EED7D-497E-4759-952F-2CCD48C6E715", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("PFA_BudgetHeadValue",10,
														   -1),
								   new Triplet<string, short, short?>("PFA_FundTypeValue",6,
														   -1),
								   new Triplet<string, short, short?>("PFA_ProjectNo",7,
														   -1),
								   new Triplet<string, short, short?>("PFA_ProjectNoValue",8,
														   -1),
								   new Triplet<string, short, short?>("MG_FundAllocation_RowId",3,
														   -1),
								   new Triplet<string, short, short?>("PFA_BudgetHead",9,
														   -1),
								   new Triplet<string, short, short?>("PFA_FundType",5,
														   -1),
								   new Triplet<string, short, short?>("PFA_FundDetailsId",12,
														   -1),
								   new Triplet<string, short, short?>("PFA_Amount",11,
														   -1),
								}
			},
							{"8CFBA89A-2F5D-41AA-8049-CA173EA990A8", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("WMC_User",3,
														   -1),
								   new Triplet<string, short, short?>("WMC_Comments",5,
														   -1),
								   new Triplet<string, short, short?>("WMC_DateofComments",4,
														   -1),
								   new Triplet<string, short, short?>("WMC_StepFrom",1,
														   -1),
								   new Triplet<string, short, short?>("WMC_StepTo",2,
														   -1),
								}
			},
					};	

	

		private Dictionary<string,string> formVersionList =new Dictionary<string,string> 
		{
							{"73B8AA02-9DDD-4205-8CCE-3A640B657727", "Medium"},
					};	

		
		private Dictionary<string,string> formVersionLayoutList =new Dictionary<string,string> 
		{
							{"E57D3627-26BE-4A33-B1E0-99341AE0D03A", ""},
							{"843813D0-5CB7-4730-8B12-4C3EFBD80380", ""},
							{"73B8AA02-9DDD-4205-8CCE-3A640B657727", ""},
							{"3839BDC4-60B0-4053-A5C3-1F9044637C21", ""},
							{"48F336D4-D46E-46C6-89E5-3728A0698475", ""},
							{"AD64BD49-1BE0-4471-BFE5-D22968F47EA1", ""},
							{"C8024318-53D4-4B82-B111-36F3D5C6401B", ""},
							{"E9F47753-F37D-482C-9AE4-EEACE88BCBFF", ""},
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


	public partial class AcDataISpaceE60C4911F4B54E9188F8124B76418F88  : ExtensionActivityBase
	{		
		
		
		private Dictionary<string,  List<Triplet<string, short, short?>>> queryExpressionBindings = 
											new Dictionary<string,  List<Triplet<string, short, short?>>>
		{
							{"17166BB1-34FE-401C-A6BE-6657FD12BA43", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("PAB_RecievedAmount",3,
														   -1),
								   new Triplet<string, short, short?>("PAB_BudgetName",0,
														   -1),
								   new Triplet<string, short, short?>("PAB_Balance",6,
														   -1),
								   new Triplet<string, short, short?>("PAB_YetToRecieve",2,
														   -1),
								   new Triplet<string, short, short?>("PAB_SanctionedAmount",1,
														   -1),
								   new Triplet<string, short, short?>("PAB_Commitment",4,
														   -1),
								   new Triplet<string, short, short?>("PAB_Spent",5,
														   -1),
								}
			},
							{"0760b579-ea75-2046-7d71-36abfbdd10d7", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("BillDetails_RowId",0,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_ReimbursementId",3,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_BillDocument",6,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_ItemDescription",7,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_BillDate",5,
														   -1),
								   new Triplet<string, short, short?>("BillDetails_Sequence",1,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_ReimbursementDetailsId",2,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_Amount",8,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_BillNo",4,
														   -1),
								}
			},
							{"252EED7D-497E-4759-952F-2CCD48C6E715", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("PFA_BudgetHeadValue",10,
														   -1),
								   new Triplet<string, short, short?>("PFA_FundTypeValue",6,
														   -1),
								   new Triplet<string, short, short?>("PFA_ProjectNo",7,
														   -1),
								   new Triplet<string, short, short?>("PFA_ProjectNoValue",8,
														   -1),
								   new Triplet<string, short, short?>("MG_FundAllocation_RowId",3,
														   -1),
								   new Triplet<string, short, short?>("PFA_BudgetHead",9,
														   -1),
								   new Triplet<string, short, short?>("PFA_FundType",5,
														   -1),
								   new Triplet<string, short, short?>("PFA_FundDetailsId",12,
														   -1),
								   new Triplet<string, short, short?>("PFA_Amount",11,
														   -1),
								}
			},
							{"8CFBA89A-2F5D-41AA-8049-CA173EA990A8", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("WMC_User",3,
														   -1),
								   new Triplet<string, short, short?>("WMC_Comments",5,
														   -1),
								   new Triplet<string, short, short?>("WMC_DateofComments",4,
														   -1),
								   new Triplet<string, short, short?>("WMC_StepFrom",1,
														   -1),
								   new Triplet<string, short, short?>("WMC_StepTo",2,
														   -1),
								}
			},
					};	

	

		private Dictionary<string,string> formVersionList =new Dictionary<string,string> 
		{
							{"73B8AA02-9DDD-4205-8CCE-3A640B657727", "Medium"},
					};	

		
		private Dictionary<string,string> formVersionLayoutList =new Dictionary<string,string> 
		{
							{"E57D3627-26BE-4A33-B1E0-99341AE0D03A", ""},
							{"843813D0-5CB7-4730-8B12-4C3EFBD80380", ""},
							{"73B8AA02-9DDD-4205-8CCE-3A640B657727", ""},
							{"3839BDC4-60B0-4053-A5C3-1F9044637C21", ""},
							{"48F336D4-D46E-46C6-89E5-3728A0698475", ""},
							{"AD64BD49-1BE0-4471-BFE5-D22968F47EA1", ""},
							{"C8024318-53D4-4B82-B111-36F3D5C6401B", ""},
							{"E9F47753-F37D-482C-9AE4-EEACE88BCBFF", ""},
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


	public partial class AcDataISpace8BE8AAA637F34E7FA3C36E343F95D288  : ExtensionActivityBase
	{		
		
		
		private Dictionary<string,  List<Triplet<string, short, short?>>> queryExpressionBindings = 
											new Dictionary<string,  List<Triplet<string, short, short?>>>
		{
							{"17166BB1-34FE-401C-A6BE-6657FD12BA43", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("PAB_RecievedAmount",3,
														   -1),
								   new Triplet<string, short, short?>("PAB_BudgetName",0,
														   -1),
								   new Triplet<string, short, short?>("PAB_Balance",6,
														   -1),
								   new Triplet<string, short, short?>("PAB_YetToRecieve",2,
														   -1),
								   new Triplet<string, short, short?>("PAB_SanctionedAmount",1,
														   -1),
								   new Triplet<string, short, short?>("PAB_Commitment",4,
														   -1),
								   new Triplet<string, short, short?>("PAB_Spent",5,
														   -1),
								}
			},
							{"0760b579-ea75-2046-7d71-36abfbdd10d7", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("BillDetails_RowId",0,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_ReimbursementId",3,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_BillDocument",6,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_ItemDescription",7,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_BillDate",5,
														   -1),
								   new Triplet<string, short, short?>("BillDetails_Sequence",1,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_ReimbursementDetailsId",2,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_Amount",8,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_BillNo",4,
														   -1),
								}
			},
							{"252EED7D-497E-4759-952F-2CCD48C6E715", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("PFA_BudgetHeadValue",10,
														   -1),
								   new Triplet<string, short, short?>("PFA_FundTypeValue",6,
														   -1),
								   new Triplet<string, short, short?>("PFA_ProjectNo",7,
														   -1),
								   new Triplet<string, short, short?>("PFA_ProjectNoValue",8,
														   -1),
								   new Triplet<string, short, short?>("MG_FundAllocation_RowId",3,
														   -1),
								   new Triplet<string, short, short?>("PFA_BudgetHead",9,
														   -1),
								   new Triplet<string, short, short?>("PFA_FundType",5,
														   -1),
								   new Triplet<string, short, short?>("PFA_FundDetailsId",12,
														   -1),
								   new Triplet<string, short, short?>("PFA_Amount",11,
														   -1),
								}
			},
							{"8CFBA89A-2F5D-41AA-8049-CA173EA990A8", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("WMC_User",3,
														   -1),
								   new Triplet<string, short, short?>("WMC_Comments",5,
														   -1),
								   new Triplet<string, short, short?>("WMC_DateofComments",4,
														   -1),
								   new Triplet<string, short, short?>("WMC_StepFrom",1,
														   -1),
								   new Triplet<string, short, short?>("WMC_StepTo",2,
														   -1),
								}
			},
					};	

	

		private Dictionary<string,string> formVersionList =new Dictionary<string,string> 
		{
							{"73B8AA02-9DDD-4205-8CCE-3A640B657727", "Medium"},
					};	

		
		private Dictionary<string,string> formVersionLayoutList =new Dictionary<string,string> 
		{
							{"E57D3627-26BE-4A33-B1E0-99341AE0D03A", ""},
							{"843813D0-5CB7-4730-8B12-4C3EFBD80380", ""},
							{"73B8AA02-9DDD-4205-8CCE-3A640B657727", ""},
							{"3839BDC4-60B0-4053-A5C3-1F9044637C21", ""},
							{"48F336D4-D46E-46C6-89E5-3728A0698475", ""},
							{"AD64BD49-1BE0-4471-BFE5-D22968F47EA1", ""},
							{"C8024318-53D4-4B82-B111-36F3D5C6401B", ""},
							{"E9F47753-F37D-482C-9AE4-EEACE88BCBFF", ""},
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


	public partial class AcDataISpace62F4B948F79A433BA563CF964E1B1774  : ExtensionActivityBase
	{		
		
		
		private Dictionary<string,  List<Triplet<string, short, short?>>> queryExpressionBindings = 
											new Dictionary<string,  List<Triplet<string, short, short?>>>
		{
							{"17166BB1-34FE-401C-A6BE-6657FD12BA43", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("PAB_RecievedAmount",3,
														   -1),
								   new Triplet<string, short, short?>("PAB_BudgetName",0,
														   -1),
								   new Triplet<string, short, short?>("PAB_Balance",6,
														   -1),
								   new Triplet<string, short, short?>("PAB_YetToRecieve",2,
														   -1),
								   new Triplet<string, short, short?>("PAB_SanctionedAmount",1,
														   -1),
								   new Triplet<string, short, short?>("PAB_Commitment",4,
														   -1),
								   new Triplet<string, short, short?>("PAB_Spent",5,
														   -1),
								}
			},
							{"0760b579-ea75-2046-7d71-36abfbdd10d7", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("BillDetails_RowId",0,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_ReimbursementId",3,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_BillDocument",6,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_ItemDescription",7,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_BillDate",5,
														   -1),
								   new Triplet<string, short, short?>("BillDetails_Sequence",1,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_ReimbursementDetailsId",2,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_Amount",8,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_BillNo",4,
														   -1),
								}
			},
							{"252EED7D-497E-4759-952F-2CCD48C6E715", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("PFA_BudgetHeadValue",10,
														   -1),
								   new Triplet<string, short, short?>("PFA_FundTypeValue",6,
														   -1),
								   new Triplet<string, short, short?>("PFA_ProjectNo",7,
														   -1),
								   new Triplet<string, short, short?>("PFA_ProjectNoValue",8,
														   -1),
								   new Triplet<string, short, short?>("MG_FundAllocation_RowId",3,
														   -1),
								   new Triplet<string, short, short?>("PFA_BudgetHead",9,
														   -1),
								   new Triplet<string, short, short?>("PFA_FundType",5,
														   -1),
								   new Triplet<string, short, short?>("PFA_FundDetailsId",12,
														   -1),
								   new Triplet<string, short, short?>("PFA_Amount",11,
														   -1),
								}
			},
							{"8CFBA89A-2F5D-41AA-8049-CA173EA990A8", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("WMC_User",3,
														   -1),
								   new Triplet<string, short, short?>("WMC_Comments",5,
														   -1),
								   new Triplet<string, short, short?>("WMC_DateofComments",4,
														   -1),
								   new Triplet<string, short, short?>("WMC_StepFrom",1,
														   -1),
								   new Triplet<string, short, short?>("WMC_StepTo",2,
														   -1),
								}
			},
					};	

	

		private Dictionary<string,string> formVersionList =new Dictionary<string,string> 
		{
							{"73B8AA02-9DDD-4205-8CCE-3A640B657727", "Medium"},
					};	

		
		private Dictionary<string,string> formVersionLayoutList =new Dictionary<string,string> 
		{
							{"E57D3627-26BE-4A33-B1E0-99341AE0D03A", ""},
							{"843813D0-5CB7-4730-8B12-4C3EFBD80380", ""},
							{"73B8AA02-9DDD-4205-8CCE-3A640B657727", ""},
							{"3839BDC4-60B0-4053-A5C3-1F9044637C21", ""},
							{"48F336D4-D46E-46C6-89E5-3728A0698475", ""},
							{"AD64BD49-1BE0-4471-BFE5-D22968F47EA1", ""},
							{"C8024318-53D4-4B82-B111-36F3D5C6401B", ""},
							{"E9F47753-F37D-482C-9AE4-EEACE88BCBFF", ""},
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
		


