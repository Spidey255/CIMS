  







namespace CPS.Proof.DFSExtension
{
	using System;
    using System.Collections.Generic;     
	using System.Linq;
	
	
	public partial class TemporaryAdvanceNewProcessMetadata : ExtensionProcessBase
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
            get { return "85014d12-a85b-4330-8d7f-29776cbda319"; }
        }

        public override string ProcessName
        {
            get { return "TemporaryAdvanceNew"; }
        }

		public override string ProcessDescription
        {
            get { return "Temporary Advance New"; }
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
            get {return "85014d12-a85b-4330-8d7f-29776cbda319";}
        }

		public override byte ProcessInstanceMode
        {
            get {return 3;}
        }		

		public override string MasterFormId
        {
            get {  
				   return "744F780C-12D2-41D3-9084-6E903A527934";	}
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
	

	public partial class TemporaryAdvanceNewObjectFactory  : ExtObjectFactoryBase
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
        //    return (IExtBaseMetaData)new TemporaryAdvanceNewProcessMetadata();
        //}
	


		private List<Triplet<string, string, string>> queryExpressionData = new List<Triplet<string, string, string>>
		{
	  			
			     new Triplet<string, string, string>("8ac4323c-e2ed-a641-43dc-a0a21b55f2e5","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("cd3fb793-f256-4854-1919-6ff9147e285e","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"028B1EFF-34A8-4D44-BF39-06CE99DF7C67"),
			
						
			     new Triplet<string, string, string>("EB161B00-391D-4550-B14F-AE0BBFEDB121","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("a336918c-9118-7c39-9978-85844c207f84","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("1B348057-4037-4195-AEB7-2D251B781A4E","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("1AA578C6-3957-4727-8F2A-6B46297860EA","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("72ABBA10-1D3E-4391-BDBD-EBBE0E2E0237","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"24F5D845-D560-4FC1-B284-00FB19DFB96F"),
			
						
			     new Triplet<string, string, string>("8C55982F-EE83-4AF1-A356-390DE5D2877F","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("0A6D4BD3-999E-458E-B930-6B42970476DD","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"24F5D845-D560-4FC1-B284-00FB19DFB96F"),
			
						
			     new Triplet<string, string, string>("29CE51BC-9310-456E-84FA-C3692433C21E","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("76cdd0d4-98cf-6555-04d2-066565596182","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("B6975CE7-CE56-4E4D-B7CC-2B1863890CE7","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("7454D2C4-EC31-45E4-9820-D4FE4FB7EDC9","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("705F1E2B-4705-4D8E-8B65-12AD847DCF29","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("cee2ac3b-0dc3-9e95-9e1e-e293da8d4c69","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("7BF46FF1-D824-4E8D-9C42-5614C20F2357","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("60809728-D8A9-4589-B22D-48DE6409B547","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("4CA3178A-7212-4B35-B354-A6CC18BA475A","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"24F5D845-D560-4FC1-B284-00FB19DFB96F"),
			
						
			     new Triplet<string, string, string>("457DF483-4660-42DA-82EB-1BA15638CB37","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"24F5D845-D560-4FC1-B284-00FB19DFB96F"),
			
						
			     new Triplet<string, string, string>("28B5F25A-B9D7-45C8-AB83-AB07D5048EAD","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"24F5D845-D560-4FC1-B284-00FB19DFB96F"),
			
						
			     new Triplet<string, string, string>("4fc913b4-39b3-49cf-b675-a463ca4816fc","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("EB161B00-391D-4550-B14F-AE0BBFEDB121","Load Commitments",
												     @"F02A7F6F-1659-4623-8B7E-1C2330D6485E"),
			
						
			     new Triplet<string, string, string>("72ABBA10-1D3E-4391-BDBD-EBBE0E2E0237","Load Comments",
												     @"1478D76F-6E75-4C46-A32B-BB50FE153540"),
			
						
			     new Triplet<string, string, string>("705F1E2B-4705-4D8E-8B65-12AD847DCF29","Load Fund Details",
												     @"331FE6C6-9B84-4AE8-9DD4-AD780298EEAE"),
			
						
			     new Triplet<string, string, string>("60809728-D8A9-4589-B22D-48DE6409B547","Load Grid By IdAdvanceRequestDetails",
												     @"0337B98B-59FA-46DC-87A0-89AA288D41AC"),
			
						
			     new Triplet<string, string, string>("4CA3178A-7212-4B35-B354-A6CC18BA475A","Grid Binding3",
												     @"0337B98B-59FA-46DC-87A0-89AA288D41AC"),
			
						
			     new Triplet<string, string, string>("457DF483-4660-42DA-82EB-1BA15638CB37","Grid Binding4",
												     @"0337B98B-59FA-46DC-87A0-89AA288D41AC"),
			
			
			
		};

		
		private List<Triplet<string, string, string>> ComboDataSource = new List<Triplet<string, string, string>>
		{

		
	  			
			     new Triplet<string, string, string>("FWFM_FundType","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMA18yFT7KruzVDa0TqsqpOM+grujzoqor1KqRIderPPsozBAr7TiIaPx7MYO2zQclV",
												     @"exec SP_GetDistrubitionDetails 4,'@PFMF_PackageProcessMapId','',''"),
			
						
			     new Triplet<string, string, string>("FWAB_ProjectNo","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMAqCwOWy+D7Ogje1I4jfjiAZNrjEazgaNyfBj9pr2u90lOsHzRNfKnSybWqRxrZGqV",
												     @"EXEC GetProjectExtensionDetails 1,'@PFMF_UserId'"),
			
						
			     new Triplet<string, string, string>("WMF_MoveTo","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMAX4svK5cDYCPw2sEhYNSLVUgHvT8EwteQ6Cu6POiqivUqpEh16s8+yjMECvtOIho/Hsxg7bNByVU=",
												     @"EXEC GetNextStep '@WMF_InstanceId','@WF_FlowType'"),
			
						
			     new Triplet<string, string, string>("FWFM_BudgetHead","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMA18yFT7KruzVDa0TqsqpOM+grujzoqor1KqRIderPPsozBAr7TiIaPx7MYO2zQclV",
												     @"Exec SP_GetDistrubitionDetails 5,'@PFMF_PackageProcessMapId','@FWFM_FundType','','','','','@FWFM_ProjectNo'"),
			
						
			     new Triplet<string, string, string>("FWFM_ProjectNo","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMAqCwOWy+D7Ogje1I4jfjiAZNrjEazgaNyfBj9pr2u90lOsHzRNfKnSybWqRxrZGqV",
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
		
	  			
			     new Tuple<string, int>("AdvanceRequestDetails",5),
			
						
			     new Tuple<string, int>("MG_AvailableBudget",5),
			
						
			     new Tuple<string, int>("MG_FundAllocation",5),
			
						
			     new Tuple<string, int>("MG_RequiredDocuments",5),
			
						
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
											case "A8D5026A-49FD-44A0-BEBE-AA595B40C453":
							virtualInstance=new ISpaceA8D5026A49FD44A0BEBEAA595B40C453();
							break;
					
											case "B7191F83-99C7-433E-8CAC-B4D23CA6AB2E":
							virtualInstance=new ISpaceB7191F8399C7433E8CACB4D23CA6AB2E();
							break;
					
											case "1D9F2FB8-7229-4AF1-A535-338A23491654":
							virtualInstance=new ISpace1D9F2FB872294AF1A535338A23491654();
							break;
					
											case "B4D82C89-3C76-4D0A-AE78-7B32FD572B8F":
							virtualInstance=new ISpaceB4D82C893C764D0AAE787B32FD572B8F();
							break;
					
											case "560A61B0-D0D9-4566-B1E9-4190F008BC9E":
							virtualInstance=new ISpace560A61B0D0D94566B1E94190F008BC9E();
							break;
					
											case "9e2f9201-3447-7964-98b2-a3bb336da186":
							virtualInstance=new ISpace9e2f92013447796498b2a3bb336da186();
							break;
					
											case "a07dd434-8e7d-1a40-f53e-b3d229e4f878":
							virtualInstance=new ISpacea07dd4348e7d1a40f53eb3d229e4f878();
							break;
					
											case "03b36fe2-406e-40c3-e807-49a3e2937922":
							virtualInstance=new ISpace03b36fe2406e40c3e80749a3e2937922();
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
	

	public partial class TemporaryAdvanceNewDataElementFactory  : ExtElementBase
    {

     /// <summary>
        /// A <see cref="log4net.ILog"/> that contains the logger instance for 
        /// logging
        /// </summary>
        private readonly ILog _sysLog;

        public TemporaryAdvanceNewDataElementFactory()
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

               
                
                                      case "744F780C-12D2-41D3-9084-6E903A527934":
                    {
                     
                                     fInsertQuery=@"IF NOT EXISTS(SELECT 1 FROM [744F780C-12D2-41D3-9084-6E903A527934] WHERE InstanceId='{0}') BEGIN INSERT INTO [744F780C-12D2-41D3-9084-6E903A527934](ProcessActivityMapId,FormId,FWFM_FundDetailsId,FWFM_FundType,FWFM_ProjectNo,FWFM_BudgetHead,FWFM_Amount,PFMF_PackageProcessMapId,FWAB_ProjectNo,PFMF_UserId,PFM_ErrId,PFM_ErrMsg,PFM_FundDetailsId,Subject,ExecutionStatus,ExecutionMessage,SetDestinationTo,SLATime,MF_d2_AdvanceFormId,MF_d2_EmployeeBasicInfoId,MF_d2_TotalAmount,MF_d2_Initiatedon,MF_d2_InitatedBy,MF_d2_ApplicationStatus,MF_d2_UpdatedBy,MF_d2_UpdatedOn,AssignToRole,AssignToUser,IN_Priority,IN_InstanceName,IN_SLA,IN_Status,IN_Category,ExecuteCommand,RedirectUrl,Thumbnail,CancelRedirectUrl,KeyContext,DisplayContext,growid,InstanceId,WMF_IsInFlow,WMF_MoveTo,Comments,WMF_InstanceId,UC_EmployeeId,UC_EmployeeName,UC_Designation,UC_Department,MF_FundTotal,TA_refNo,UC_DOB,UC_PhoneNumber,UC_DOJ,UC_EmailId,UC_Name,UC_Paylevel,UC_Grade,UC_DOR,UC_EmployeeBasicInfoId,MF_ErrId,MF_ErrMsg,MF_IsAdvance,WF_FlowType)
							VALUES( {3}) END ELSE BEGIN UPDATE [744F780C-12D2-41D3-9084-6E903A527934]SET {4}WHERE InstanceId='{0}'END ";

                                     colList=@"ProcessActivityMapId,FormId,FWFM_FundDetailsId,FWFM_FundType,FWFM_ProjectNo,FWFM_BudgetHead,FWFM_Amount,PFMF_PackageProcessMapId,FWAB_ProjectNo,PFMF_UserId,PFM_ErrId,PFM_ErrMsg,PFM_FundDetailsId,Subject,ExecutionStatus,ExecutionMessage,SetDestinationTo,SLATime,MF_d2_AdvanceFormId,MF_d2_EmployeeBasicInfoId,MF_d2_TotalAmount,MF_d2_Initiatedon,MF_d2_InitatedBy,MF_d2_ApplicationStatus,MF_d2_UpdatedBy,MF_d2_UpdatedOn,AssignToRole,AssignToUser,IN_Priority,IN_InstanceName,IN_SLA,IN_Status,IN_Category,ExecuteCommand,RedirectUrl,Thumbnail,CancelRedirectUrl,KeyContext,DisplayContext,growid,InstanceId,WMF_IsInFlow,WMF_MoveTo,Comments,WMF_InstanceId,UC_EmployeeId,UC_EmployeeName,UC_Designation,UC_Department,MF_FundTotal,TA_refNo,UC_DOB,UC_PhoneNumber,UC_DOJ,UC_EmailId,UC_Name,UC_Paylevel,UC_Grade,UC_DOR,UC_EmployeeBasicInfoId,MF_ErrId,MF_ErrMsg,MF_IsAdvance,WF_FlowType";
                                    
                     
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

                
                 
                                      case "1478D76F-6E75-4C46-A32B-BB50FE153540":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_1478D76F6E754C46A32BBB50FE153540 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [WMC_StepFrom] VARCHAR(MAX)	, [WMC_StepTo] VARCHAR(MAX)	, [WMC_Comments] VARCHAR(MAX)	, [WMC_User] VARCHAR(MAX)	, [WMC_DateofComments] DATETIME){0}INSERT INTO [1478D76F-6E75-4C46-A32B-BB50FE153540](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,WMC_StepFrom,WMC_StepTo,WMC_Comments,WMC_User,WMC_DateofComments)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.WMC_StepFrom,TDT.WMC_StepTo,TDT.WMC_Comments,TDT.WMC_User,TDT.WMC_DateofComments FROM @TBL_1478D76F6E754C46A32BBB50FE153540 TDT
							LEFT JOIN [1478D76F-6E75-4C46-A32B-BB50FE153540] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,WMC_StepFrom=TDT.WMC_StepFrom,WMC_StepTo=TDT.WMC_StepTo,WMC_Comments=TDT.WMC_Comments,WMC_User=TDT.WMC_User,WMC_DateofComments=TDT.WMC_DateofComments FROM @TBL_1478D76F6E754C46A32BBB50FE153540 TDT
							JOIN [1478D76F-6E75-4C46-A32B-BB50FE153540] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,WMC_StepFrom,WMC_StepTo,WMC_Comments,WMC_User,WMC_DateofComments";

                                     tempInsertQuery=@"INSERT INTO @TBL_1478D76F6E754C46A32BBB50FE153540(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,WMC_StepFrom,WMC_StepTo,WMC_Comments,WMC_User,WMC_DateofComments)VALUES({0});";
                                     

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
                     
                                    case "0337B98B-59FA-46DC-87A0-89AA288D41AC":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_0337B98B59FA46DC87A089AA288D41AC AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_d1_RequestDetailsId] VARCHAR(MAX)	, [MG_d1_AdvanceFormId] VARCHAR(MAX)	, [MG_d1_ExpenseDetails] VARCHAR(MAX)	, [MG_d1_ItemDescription] VARCHAR(MAX)	, [MG_d1_Amount] DECIMAL(18,2)){0}INSERT INTO [0337B98B-59FA-46DC-87A0-89AA288D41AC](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d1_RequestDetailsId,MG_d1_AdvanceFormId,MG_d1_ExpenseDetails,MG_d1_ItemDescription,MG_d1_Amount)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_d1_RequestDetailsId,TDT.MG_d1_AdvanceFormId,TDT.MG_d1_ExpenseDetails,TDT.MG_d1_ItemDescription,TDT.MG_d1_Amount FROM @TBL_0337B98B59FA46DC87A089AA288D41AC TDT
							LEFT JOIN [0337B98B-59FA-46DC-87A0-89AA288D41AC] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MG_d1_RequestDetailsId=TDT.MG_d1_RequestDetailsId,MG_d1_AdvanceFormId=TDT.MG_d1_AdvanceFormId,MG_d1_ExpenseDetails=TDT.MG_d1_ExpenseDetails,MG_d1_ItemDescription=TDT.MG_d1_ItemDescription,MG_d1_Amount=TDT.MG_d1_Amount FROM @TBL_0337B98B59FA46DC87A089AA288D41AC TDT
							JOIN [0337B98B-59FA-46DC-87A0-89AA288D41AC] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d1_RequestDetailsId,MG_d1_AdvanceFormId,MG_d1_ExpenseDetails,MG_d1_ItemDescription,MG_d1_Amount";

                                     tempInsertQuery=@"INSERT INTO @TBL_0337B98B59FA46DC87A089AA288D41AC(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d1_RequestDetailsId,MG_d1_AdvanceFormId,MG_d1_ExpenseDetails,MG_d1_ItemDescription,MG_d1_Amount)VALUES({0});";
                                     

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
                     
                                    case "F02A7F6F-1659-4623-8B7E-1C2330D6485E":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_F02A7F6F165946238B7E1C2330D6485E AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [PAB_BudgetName] VARCHAR(MAX)	, [PAB_SanctionedAmount] DECIMAL(18,2)	, [PAB_YetToRecieve] DECIMAL(18,2)	, [PAB_RecievedAmount] DECIMAL(18,2)	, [PAB_Commitment] DECIMAL(18,2)	, [PAB_Spent] DECIMAL(18,2)	, [PAB_Balance] DECIMAL(18,2)){0}INSERT INTO [F02A7F6F-1659-4623-8B7E-1C2330D6485E](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PAB_BudgetName,PAB_SanctionedAmount,PAB_YetToRecieve,PAB_RecievedAmount,PAB_Commitment,PAB_Spent,PAB_Balance)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.PAB_BudgetName,TDT.PAB_SanctionedAmount,TDT.PAB_YetToRecieve,TDT.PAB_RecievedAmount,TDT.PAB_Commitment,TDT.PAB_Spent,TDT.PAB_Balance FROM @TBL_F02A7F6F165946238B7E1C2330D6485E TDT
							LEFT JOIN [F02A7F6F-1659-4623-8B7E-1C2330D6485E] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,PAB_BudgetName=TDT.PAB_BudgetName,PAB_SanctionedAmount=TDT.PAB_SanctionedAmount,PAB_YetToRecieve=TDT.PAB_YetToRecieve,PAB_RecievedAmount=TDT.PAB_RecievedAmount,PAB_Commitment=TDT.PAB_Commitment,PAB_Spent=TDT.PAB_Spent,PAB_Balance=TDT.PAB_Balance FROM @TBL_F02A7F6F165946238B7E1C2330D6485E TDT
							JOIN [F02A7F6F-1659-4623-8B7E-1C2330D6485E] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PAB_BudgetName,PAB_SanctionedAmount,PAB_YetToRecieve,PAB_RecievedAmount,PAB_Commitment,PAB_Spent,PAB_Balance";

                                     tempInsertQuery=@"INSERT INTO @TBL_F02A7F6F165946238B7E1C2330D6485E(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PAB_BudgetName,PAB_SanctionedAmount,PAB_YetToRecieve,PAB_RecievedAmount,PAB_Commitment,PAB_Spent,PAB_Balance)VALUES({0});";
                                     

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
                     
                                    case "331FE6C6-9B84-4AE8-9DD4-AD780298EEAE":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_331FE6C69B844AE89DD4AD780298EEAE AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [PFA_FundType] VARCHAR(MAX)	, [PFA_FundTypeValue] VARCHAR(MAX)	, [PFA_ProjectNo] VARCHAR(MAX)	, [PFA_ProjectNoValue] VARCHAR(MAX)	, [PFA_BudgetHead] VARCHAR(MAX)	, [PFA_BudgetHeadValue] VARCHAR(MAX)	, [PFA_Amount] DECIMAL(18,2)	, [PFA_FundDetailsId] VARCHAR(MAX)){0}INSERT INTO [331FE6C6-9B84-4AE8-9DD4-AD780298EEAE](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PFA_FundType,PFA_FundTypeValue,PFA_ProjectNo,PFA_ProjectNoValue,PFA_BudgetHead,PFA_BudgetHeadValue,PFA_Amount,PFA_FundDetailsId)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.PFA_FundType,TDT.PFA_FundTypeValue,TDT.PFA_ProjectNo,TDT.PFA_ProjectNoValue,TDT.PFA_BudgetHead,TDT.PFA_BudgetHeadValue,TDT.PFA_Amount,TDT.PFA_FundDetailsId FROM @TBL_331FE6C69B844AE89DD4AD780298EEAE TDT
							LEFT JOIN [331FE6C6-9B84-4AE8-9DD4-AD780298EEAE] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,PFA_FundType=TDT.PFA_FundType,PFA_FundTypeValue=TDT.PFA_FundTypeValue,PFA_ProjectNo=TDT.PFA_ProjectNo,PFA_ProjectNoValue=TDT.PFA_ProjectNoValue,PFA_BudgetHead=TDT.PFA_BudgetHead,PFA_BudgetHeadValue=TDT.PFA_BudgetHeadValue,PFA_Amount=TDT.PFA_Amount,PFA_FundDetailsId=TDT.PFA_FundDetailsId FROM @TBL_331FE6C69B844AE89DD4AD780298EEAE TDT
							JOIN [331FE6C6-9B84-4AE8-9DD4-AD780298EEAE] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PFA_FundType,PFA_FundTypeValue,PFA_ProjectNo,PFA_ProjectNoValue,PFA_BudgetHead,PFA_BudgetHeadValue,PFA_Amount,PFA_FundDetailsId";

                                     tempInsertQuery=@"INSERT INTO @TBL_331FE6C69B844AE89DD4AD780298EEAE(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PFA_FundType,PFA_FundTypeValue,PFA_ProjectNo,PFA_ProjectNoValue,PFA_BudgetHead,PFA_BudgetHeadValue,PFA_Amount,PFA_FundDetailsId)VALUES({0});";
                                     

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
                     
                                    case "36296F3B-23C7-4F14-BC64-C4E49DB8C854":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_36296F3B23C74F14BC64C4E49DB8C854 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [PADD_DocumentName] VARCHAR(MAX)	, [PADD_Document] VARCHAR(MAX)){0}INSERT INTO [36296F3B-23C7-4F14-BC64-C4E49DB8C854](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PADD_DocumentName,PADD_Document)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.PADD_DocumentName,TDT.PADD_Document FROM @TBL_36296F3B23C74F14BC64C4E49DB8C854 TDT
							LEFT JOIN [36296F3B-23C7-4F14-BC64-C4E49DB8C854] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,PADD_DocumentName=TDT.PADD_DocumentName,PADD_Document=TDT.PADD_Document FROM @TBL_36296F3B23C74F14BC64C4E49DB8C854 TDT
							JOIN [36296F3B-23C7-4F14-BC64-C4E49DB8C854] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PADD_DocumentName,PADD_Document";

                                     tempInsertQuery=@"INSERT INTO @TBL_36296F3B23C74F14BC64C4E49DB8C854(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PADD_DocumentName,PADD_Document)VALUES({0});";
                                     

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
                     

                                         case "1478D76F-6E75-4C46-A32B-BB50FE153540":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_1478D76F6E754C46A32BBB50FE153540 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [WMC_StepFrom] VARCHAR(MAX)	, [WMC_StepTo] VARCHAR(MAX)	, [WMC_Comments] VARCHAR(MAX)	, [WMC_User] VARCHAR(MAX)	, [WMC_DateofComments] DATETIME){0}INSERT INTO [1478D76F-6E75-4C46-A32B-BB50FE153540](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,WMC_StepFrom,WMC_StepTo,WMC_Comments,WMC_User,WMC_DateofComments)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.WMC_StepFrom,TDT.WMC_StepTo,TDT.WMC_Comments,TDT.WMC_User,TDT.WMC_DateofComments FROM @TBL_1478D76F6E754C46A32BBB50FE153540 TDT
							LEFT JOIN [1478D76F-6E75-4C46-A32B-BB50FE153540] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,WMC_StepFrom=TDT.WMC_StepFrom,WMC_StepTo=TDT.WMC_StepTo,WMC_Comments=TDT.WMC_Comments,WMC_User=TDT.WMC_User,WMC_DateofComments=TDT.WMC_DateofComments FROM @TBL_1478D76F6E754C46A32BBB50FE153540 TDT
							JOIN [1478D76F-6E75-4C46-A32B-BB50FE153540] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,WMC_StepFrom,WMC_StepTo,WMC_Comments,WMC_User,WMC_DateofComments";

                            tempInsertQuery=@"INSERT INTO @TBL_1478D76F6E754C46A32BBB50FE153540(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,WMC_StepFrom,WMC_StepTo,WMC_Comments,WMC_User,WMC_DateofComments)VALUES({0});";

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

                                              case "0337B98B-59FA-46DC-87A0-89AA288D41AC":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_0337B98B59FA46DC87A089AA288D41AC AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_d1_RequestDetailsId] VARCHAR(MAX)	, [MG_d1_AdvanceFormId] VARCHAR(MAX)	, [MG_d1_ExpenseDetails] VARCHAR(MAX)	, [MG_d1_ItemDescription] VARCHAR(MAX)	, [MG_d1_Amount] DECIMAL(18,2)){0}INSERT INTO [0337B98B-59FA-46DC-87A0-89AA288D41AC](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d1_RequestDetailsId,MG_d1_AdvanceFormId,MG_d1_ExpenseDetails,MG_d1_ItemDescription,MG_d1_Amount)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_d1_RequestDetailsId,TDT.MG_d1_AdvanceFormId,TDT.MG_d1_ExpenseDetails,TDT.MG_d1_ItemDescription,TDT.MG_d1_Amount FROM @TBL_0337B98B59FA46DC87A089AA288D41AC TDT
							LEFT JOIN [0337B98B-59FA-46DC-87A0-89AA288D41AC] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MG_d1_RequestDetailsId=TDT.MG_d1_RequestDetailsId,MG_d1_AdvanceFormId=TDT.MG_d1_AdvanceFormId,MG_d1_ExpenseDetails=TDT.MG_d1_ExpenseDetails,MG_d1_ItemDescription=TDT.MG_d1_ItemDescription,MG_d1_Amount=TDT.MG_d1_Amount FROM @TBL_0337B98B59FA46DC87A089AA288D41AC TDT
							JOIN [0337B98B-59FA-46DC-87A0-89AA288D41AC] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d1_RequestDetailsId,MG_d1_AdvanceFormId,MG_d1_ExpenseDetails,MG_d1_ItemDescription,MG_d1_Amount";

                            tempInsertQuery=@"INSERT INTO @TBL_0337B98B59FA46DC87A089AA288D41AC(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d1_RequestDetailsId,MG_d1_AdvanceFormId,MG_d1_ExpenseDetails,MG_d1_ItemDescription,MG_d1_Amount)VALUES({0});";

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

                                              case "F02A7F6F-1659-4623-8B7E-1C2330D6485E":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_F02A7F6F165946238B7E1C2330D6485E AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [PAB_BudgetName] VARCHAR(MAX)	, [PAB_SanctionedAmount] DECIMAL(18,2)	, [PAB_YetToRecieve] DECIMAL(18,2)	, [PAB_RecievedAmount] DECIMAL(18,2)	, [PAB_Commitment] DECIMAL(18,2)	, [PAB_Spent] DECIMAL(18,2)	, [PAB_Balance] DECIMAL(18,2)){0}INSERT INTO [F02A7F6F-1659-4623-8B7E-1C2330D6485E](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PAB_BudgetName,PAB_SanctionedAmount,PAB_YetToRecieve,PAB_RecievedAmount,PAB_Commitment,PAB_Spent,PAB_Balance)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.PAB_BudgetName,TDT.PAB_SanctionedAmount,TDT.PAB_YetToRecieve,TDT.PAB_RecievedAmount,TDT.PAB_Commitment,TDT.PAB_Spent,TDT.PAB_Balance FROM @TBL_F02A7F6F165946238B7E1C2330D6485E TDT
							LEFT JOIN [F02A7F6F-1659-4623-8B7E-1C2330D6485E] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,PAB_BudgetName=TDT.PAB_BudgetName,PAB_SanctionedAmount=TDT.PAB_SanctionedAmount,PAB_YetToRecieve=TDT.PAB_YetToRecieve,PAB_RecievedAmount=TDT.PAB_RecievedAmount,PAB_Commitment=TDT.PAB_Commitment,PAB_Spent=TDT.PAB_Spent,PAB_Balance=TDT.PAB_Balance FROM @TBL_F02A7F6F165946238B7E1C2330D6485E TDT
							JOIN [F02A7F6F-1659-4623-8B7E-1C2330D6485E] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PAB_BudgetName,PAB_SanctionedAmount,PAB_YetToRecieve,PAB_RecievedAmount,PAB_Commitment,PAB_Spent,PAB_Balance";

                            tempInsertQuery=@"INSERT INTO @TBL_F02A7F6F165946238B7E1C2330D6485E(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PAB_BudgetName,PAB_SanctionedAmount,PAB_YetToRecieve,PAB_RecievedAmount,PAB_Commitment,PAB_Spent,PAB_Balance)VALUES({0});";

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

                                              case "331FE6C6-9B84-4AE8-9DD4-AD780298EEAE":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_331FE6C69B844AE89DD4AD780298EEAE AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [PFA_FundType] VARCHAR(MAX)	, [PFA_FundTypeValue] VARCHAR(MAX)	, [PFA_ProjectNo] VARCHAR(MAX)	, [PFA_ProjectNoValue] VARCHAR(MAX)	, [PFA_BudgetHead] VARCHAR(MAX)	, [PFA_BudgetHeadValue] VARCHAR(MAX)	, [PFA_Amount] DECIMAL(18,2)	, [PFA_FundDetailsId] VARCHAR(MAX)){0}INSERT INTO [331FE6C6-9B84-4AE8-9DD4-AD780298EEAE](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PFA_FundType,PFA_FundTypeValue,PFA_ProjectNo,PFA_ProjectNoValue,PFA_BudgetHead,PFA_BudgetHeadValue,PFA_Amount,PFA_FundDetailsId)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.PFA_FundType,TDT.PFA_FundTypeValue,TDT.PFA_ProjectNo,TDT.PFA_ProjectNoValue,TDT.PFA_BudgetHead,TDT.PFA_BudgetHeadValue,TDT.PFA_Amount,TDT.PFA_FundDetailsId FROM @TBL_331FE6C69B844AE89DD4AD780298EEAE TDT
							LEFT JOIN [331FE6C6-9B84-4AE8-9DD4-AD780298EEAE] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,PFA_FundType=TDT.PFA_FundType,PFA_FundTypeValue=TDT.PFA_FundTypeValue,PFA_ProjectNo=TDT.PFA_ProjectNo,PFA_ProjectNoValue=TDT.PFA_ProjectNoValue,PFA_BudgetHead=TDT.PFA_BudgetHead,PFA_BudgetHeadValue=TDT.PFA_BudgetHeadValue,PFA_Amount=TDT.PFA_Amount,PFA_FundDetailsId=TDT.PFA_FundDetailsId FROM @TBL_331FE6C69B844AE89DD4AD780298EEAE TDT
							JOIN [331FE6C6-9B84-4AE8-9DD4-AD780298EEAE] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PFA_FundType,PFA_FundTypeValue,PFA_ProjectNo,PFA_ProjectNoValue,PFA_BudgetHead,PFA_BudgetHeadValue,PFA_Amount,PFA_FundDetailsId";

                            tempInsertQuery=@"INSERT INTO @TBL_331FE6C69B844AE89DD4AD780298EEAE(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PFA_FundType,PFA_FundTypeValue,PFA_ProjectNo,PFA_ProjectNoValue,PFA_BudgetHead,PFA_BudgetHeadValue,PFA_Amount,PFA_FundDetailsId)VALUES({0});";

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

                                              case "36296F3B-23C7-4F14-BC64-C4E49DB8C854":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_36296F3B23C74F14BC64C4E49DB8C854 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [PADD_DocumentName] VARCHAR(MAX)	, [PADD_Document] VARCHAR(MAX)){0}INSERT INTO [36296F3B-23C7-4F14-BC64-C4E49DB8C854](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PADD_DocumentName,PADD_Document)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.PADD_DocumentName,TDT.PADD_Document FROM @TBL_36296F3B23C74F14BC64C4E49DB8C854 TDT
							LEFT JOIN [36296F3B-23C7-4F14-BC64-C4E49DB8C854] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,PADD_DocumentName=TDT.PADD_DocumentName,PADD_Document=TDT.PADD_Document FROM @TBL_36296F3B23C74F14BC64C4E49DB8C854 TDT
							JOIN [36296F3B-23C7-4F14-BC64-C4E49DB8C854] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PADD_DocumentName,PADD_Document";

                            tempInsertQuery=@"INSERT INTO @TBL_36296F3B23C74F14BC64C4E49DB8C854(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PADD_DocumentName,PADD_Document)VALUES({0});";

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
public class ISpaceA8D5026A49FD44A0BEBEAA595B40C453 : VirtualForm
{
IISpace iSpace = new ISpace();
AcDataISpaceA8D5026A49FD44A0BEBEAA595B40C453 acdataIspaceA8D5026A49FD44A0BEBEAA595B40C453=new AcDataISpaceA8D5026A49FD44A0BEBEAA595B40C453();
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
if(ISpace["FormVersionId"].Value=="228701A8-2089-4481-B018-4BE30083D0D9")
{
ISpace["UI_ApprovalHideRow"].Visible="false";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""228701A8-2089-4481-B018-4BE30083D0D9"")
{
ISpace[""UI_ApprovalHideRow""].Visible=""false"";
}");
}
if(ISpace["WF_FlowType"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""WF_FlowType""].Value=="""")");
ISpace["WMF_IsInFlow"].Value=0;
base.WriteDebugInfo(@"ISpace[""WMF_IsInFlow""].Value=0;");
base.WriteDebugInfo(@"EXEC [GetInstanceInFlow] '@@gv_InstanceId'");

var querySource28B5F25AB9D745C8AB83AB07D5048EAD =GetQueryExpressionDataSource("28B5F25A-B9D7-45C8-AB83-AB07D5048EAD");
Dictionary<short,object> result28B5F25AB9D745C8AB83AB07D5048EAD=iSpace.ExecuteQuery(querySource28B5F25AB9D745C8AB83AB07D5048EAD,@"EXEC [GetInstanceInFlow] '" + ISpace["gv_instanceid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource28B5F25AB9D745C8AB83AB07D5048EAD =GetQueryExpressionDataSource(""28B5F25A-B9D7-45C8-AB83-AB07D5048EAD"");Dictionary<short,object> result28B5F25AB9D745C8AB83AB07D5048EAD=iSpace.ExecuteQuery(querySource28B5F25AB9D745C8AB83AB07D5048EAD,@""EXEC [GetInstanceInFlow] '"" + ISpace[""gv_instanceid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result28B5F25AB9D745C8AB83AB07D5048EAD!=null) && (result28B5F25AB9D745C8AB83AB07D5048EAD.Count!=0))
{
if(result28B5F25AB9D745C8AB83AB07D5048EAD.ContainsKey(0))
ISpace["WMF_IsInFlow"].Value = result28B5F25AB9D745C8AB83AB07D5048EAD[0];
}
else{
ISpace["WMF_IsInFlow"].Value = null;
}
if(ISpace["WMF_IsInFlow"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""WMF_IsInFlow""].Value==1)");
ISpace["WF_FlowType"].Value="APPROVE";
base.WriteDebugInfo(@"ISpace[""WF_FlowType""].Value=""APPROVE"";");
ISpace["WMF_History"].Visible="true";ISpace["WMF_MoveTo"].Visible="true";
base.WriteDebugInfo(@"ISpace[""WMF_History""].Visible=""true"";ISpace[""WMF_MoveTo""].Visible=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["WMF_History"].Visible="false";ISpace["WMF_MoveTo"].Visible="false";
base.WriteDebugInfo(@"ISpace[""WMF_History""].Visible=""false"";ISpace[""WMF_MoveTo""].Visible=""false"";");
}
}
ISpace["WMF_MoveTo"].Man=true;
base.WriteDebugInfo(@"ISpace[""WMF_MoveTo""].Man=true;");
ISpace["WMF_MoveTo"].Value="";
base.WriteDebugInfo(@"ISpace[""WMF_MoveTo""].Value="""";");
ISpace["Comments"].Value="";
base.WriteDebugInfo(@"ISpace[""Comments""].Value="""";");
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

var querySource72ABBA101D3E4391BDBDEBBE0E2E0237 =GetQueryExpressionDataSource("72ABBA10-1D3E-4391-BDBD-EBBE0E2E0237");

DataTable result72ABBA101D3E4391BDBDEBBE0E2E0237=iSpace.SetGridDataSource(querySource72ABBA101D3E4391BDBDEBBE0E2E0237, _objectFactory.GetGridRPP("WMG_CommentsHistory"),@"EXEC [GetInstanceFlowDetais] '" + ISpace["gv_instanceid"].Value + @"'");

iSpace.InsertGridBindDetails("WMG_CommentsHistory","11",querySource72ABBA101D3E4391BDBDEBBE0E2E0237,"EXEC [GetInstanceFlowDetais] '" + ISpace["gv_instanceid"].Value + @"'",_objectFactory.GetGridRPP("WMG_CommentsHistory"));

base.WriteDebugInfo(@"var querySource72ABBA101D3E4391BDBDEBBE0E2E0237 =GetQueryExpressionDataSource(""72ABBA10-1D3E-4391-BDBD-EBBE0E2E0237"");DataTable result72ABBA101D3E4391BDBDEBBE0E2E0237=iSpace.SetGridDataSource(querySource72ABBA101D3E4391BDBDEBBE0E2E0237, _objectFactory.GetGridRPP(""WMG_CommentsHistory""),@""EXEC [GetInstanceFlowDetais] '"" + ISpace[""gv_instanceid""].Value + @""'"");iSpace.InsertGridBindDetails(""WMG_CommentsHistory"",""11"",querySource72ABBA101D3E4391BDBDEBBE0E2E0237,""EXEC [GetInstanceFlowDetais] '"" + ISpace[""gv_instanceid""].Value + @""'"",_objectFactory.GetGridRPP(""WMG_CommentsHistory""));");
ISpace["PFMF_PackageProcessMapId"].Value=ISpace["gv_processmapid"].Value;
base.WriteDebugInfo(@"ISpace[""PFMF_PackageProcessMapId""].Value=ISpace[""gv_processmapid""].Value;");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result6DA5E7991709406E85D09DC6581E03C3=acdataIspaceA8D5026A49FD44A0BEBEAA595B40C453.GetQueryExpressionBindings("6DA5E799-1709-406E-85D0-9DC6581E03C3");
iSpace.SetGridData(result72ABBA101D3E4391BDBDEBBE0E2E0237,result6DA5E7991709406E85D09DC6581E03C3,"WMG_CommentsHistory",ref ISpace);
iSpace.UpdateGridBindDetails("WMG_CommentsHistory",result6DA5E7991709406E85D09DC6581E03C3);
ISpace["PFMF_UserId"].Value=ISpace["gv_userid"].Value;
base.WriteDebugInfo(@"ISpace[""PFMF_UserId""].Value=ISpace[""gv_userid""].Value;");
if(ISpace["MF_d2_AdvanceFormId"].Value!="0")
{
base.WriteDebugInfo(@"if(ISpace[""MF_d2_AdvanceFormId""].Value!=""0"")");
base.WriteDebugInfo(@"EXEC InnovaceNoCode..[FormLoadById_744F780C-12D2-41D3-9084-6E903A527934]  '#MF_d2_AdvanceFormId'");

var querySource7BF46FF1D8244E8D9C425614C20F2357 =GetQueryExpressionDataSource("7BF46FF1-D824-4E8D-9C42-5614C20F2357");
Dictionary<short,object> result7BF46FF1D8244E8D9C425614C20F2357=iSpace.ExecuteQuery(querySource7BF46FF1D8244E8D9C425614C20F2357,@"EXEC InnovaceNoCode..[FormLoadById_744F780C-12D2-41D3-9084-6E903A527934]  '" + ISpace["MF_d2_AdvanceFormId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource7BF46FF1D8244E8D9C425614C20F2357 =GetQueryExpressionDataSource(""7BF46FF1-D824-4E8D-9C42-5614C20F2357"");Dictionary<short,object> result7BF46FF1D8244E8D9C425614C20F2357=iSpace.ExecuteQuery(querySource7BF46FF1D8244E8D9C425614C20F2357,@""EXEC InnovaceNoCode..[FormLoadById_744F780C-12D2-41D3-9084-6E903A527934]  '"" + ISpace[""MF_d2_AdvanceFormId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result7BF46FF1D8244E8D9C425614C20F2357!=null) && (result7BF46FF1D8244E8D9C425614C20F2357.Count!=0))
{
if(result7BF46FF1D8244E8D9C425614C20F2357.ContainsKey(7))
ISpace["MF_d2_UpdatedOn"].Value = result7BF46FF1D8244E8D9C425614C20F2357[7];
if(result7BF46FF1D8244E8D9C425614C20F2357.ContainsKey(3))
ISpace["MF_d2_Initiatedon"].Value = result7BF46FF1D8244E8D9C425614C20F2357[3];
if(result7BF46FF1D8244E8D9C425614C20F2357.ContainsKey(2))
ISpace["MF_d2_TotalAmount"].Value = result7BF46FF1D8244E8D9C425614C20F2357[2];
if(result7BF46FF1D8244E8D9C425614C20F2357.ContainsKey(0))
ISpace["MF_d2_AdvanceFormId"].Value = result7BF46FF1D8244E8D9C425614C20F2357[0];
if(result7BF46FF1D8244E8D9C425614C20F2357.ContainsKey(6))
ISpace["MF_d2_UpdatedBy"].Value = result7BF46FF1D8244E8D9C425614C20F2357[6];
if(result7BF46FF1D8244E8D9C425614C20F2357.ContainsKey(4))
ISpace["MF_d2_InitatedBy"].Value = result7BF46FF1D8244E8D9C425614C20F2357[4];
if(result7BF46FF1D8244E8D9C425614C20F2357.ContainsKey(1))
ISpace["MF_d2_EmployeeBasicInfoId"].Value = result7BF46FF1D8244E8D9C425614C20F2357[1];
if(result7BF46FF1D8244E8D9C425614C20F2357.ContainsKey(5))
ISpace["MF_d2_ApplicationStatus"].Value = result7BF46FF1D8244E8D9C425614C20F2357[5];
}
else{
ISpace["MF_d2_UpdatedOn"].Value = null;ISpace["MF_d2_Initiatedon"].Value = null;ISpace["MF_d2_TotalAmount"].Value = null;ISpace["MF_d2_AdvanceFormId"].Value = null;ISpace["MF_d2_UpdatedBy"].Value = null;ISpace["MF_d2_InitatedBy"].Value = null;ISpace["MF_d2_EmployeeBasicInfoId"].Value = null;ISpace["MF_d2_ApplicationStatus"].Value = null;
}

var querySource60809728D8A94589B22D48DE6409B547 =GetQueryExpressionDataSource("60809728-D8A9-4589-B22D-48DE6409B547");

DataTable result60809728D8A94589B22D48DE6409B547=iSpace.SetGridDataSource(querySource60809728D8A94589B22D48DE6409B547, _objectFactory.GetGridRPP("AdvanceRequestDetails"),@"EXEC InnovaceNoCode..[GridLoadById_0337B98B-59FA-46DC-87A0-89AA288D41AC]  '" + ISpace["MF_d2_AdvanceFormId"].Value + @"'");

iSpace.InsertGridBindDetails("AdvanceRequestDetails","11",querySource60809728D8A94589B22D48DE6409B547,"EXEC InnovaceNoCode..[GridLoadById_0337B98B-59FA-46DC-87A0-89AA288D41AC]  '" + ISpace["MF_d2_AdvanceFormId"].Value + @"'",_objectFactory.GetGridRPP("AdvanceRequestDetails"));

base.WriteDebugInfo(@"var querySource60809728D8A94589B22D48DE6409B547 =GetQueryExpressionDataSource(""60809728-D8A9-4589-B22D-48DE6409B547"");DataTable result60809728D8A94589B22D48DE6409B547=iSpace.SetGridDataSource(querySource60809728D8A94589B22D48DE6409B547, _objectFactory.GetGridRPP(""AdvanceRequestDetails""),@""EXEC InnovaceNoCode..[GridLoadById_0337B98B-59FA-46DC-87A0-89AA288D41AC]  '"" + ISpace[""MF_d2_AdvanceFormId""].Value + @""'"");iSpace.InsertGridBindDetails(""AdvanceRequestDetails"",""11"",querySource60809728D8A94589B22D48DE6409B547,""EXEC InnovaceNoCode..[GridLoadById_0337B98B-59FA-46DC-87A0-89AA288D41AC]  '"" + ISpace[""MF_d2_AdvanceFormId""].Value + @""'"",_objectFactory.GetGridRPP(""AdvanceRequestDetails""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result3C6C0407FD5F467BA72788C4152BA19E=acdataIspaceA8D5026A49FD44A0BEBEAA595B40C453.GetQueryExpressionBindings("3C6C0407-FD5F-467B-A727-88C4152BA19E");
iSpace.SetGridData(result60809728D8A94589B22D48DE6409B547,result3C6C0407FD5F467BA72788C4152BA19E,"AdvanceRequestDetails",ref ISpace);
iSpace.UpdateGridBindDetails("AdvanceRequestDetails",result3C6C0407FD5F467BA72788C4152BA19E);
}
base.WriteDebugInfo(@"EXEC [GetEmployeeUserContextDetails] '@@gv_UserId'");

var querySourcecd3fb793f256485419196ff9147e285e =GetQueryExpressionDataSource("cd3fb793-f256-4854-1919-6ff9147e285e");
Dictionary<short,object> resultcd3fb793f256485419196ff9147e285e=iSpace.ExecuteQuery(querySourcecd3fb793f256485419196ff9147e285e,@"EXEC [GetEmployeeUserContextDetails] '" + ISpace["gv_userid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourcecd3fb793f256485419196ff9147e285e =GetQueryExpressionDataSource(""cd3fb793-f256-4854-1919-6ff9147e285e"");Dictionary<short,object> resultcd3fb793f256485419196ff9147e285e=iSpace.ExecuteQuery(querySourcecd3fb793f256485419196ff9147e285e,@""EXEC [GetEmployeeUserContextDetails] '"" + ISpace[""gv_userid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultcd3fb793f256485419196ff9147e285e!=null) && (resultcd3fb793f256485419196ff9147e285e.Count!=0))
{
if(resultcd3fb793f256485419196ff9147e285e.ContainsKey(1))
ISpace["UC_EmployeeId"].Value = resultcd3fb793f256485419196ff9147e285e[1];
if(resultcd3fb793f256485419196ff9147e285e.ContainsKey(10))
ISpace["UC_DOR"].Value = resultcd3fb793f256485419196ff9147e285e[10];
if(resultcd3fb793f256485419196ff9147e285e.ContainsKey(12))
ISpace["UC_Grade"].Value = resultcd3fb793f256485419196ff9147e285e[12];
if(resultcd3fb793f256485419196ff9147e285e.ContainsKey(7))
ISpace["UC_Designation"].Value = resultcd3fb793f256485419196ff9147e285e[7];
if(resultcd3fb793f256485419196ff9147e285e.ContainsKey(9))
ISpace["UC_DOB"].Value = resultcd3fb793f256485419196ff9147e285e[9];
if(resultcd3fb793f256485419196ff9147e285e.ContainsKey(3))
ISpace["UC_EmailId"].Value = resultcd3fb793f256485419196ff9147e285e[3];
if(resultcd3fb793f256485419196ff9147e285e.ContainsKey(4))
ISpace["UC_DOJ"].Value = resultcd3fb793f256485419196ff9147e285e[4];
if(resultcd3fb793f256485419196ff9147e285e.ContainsKey(0))
ISpace["UC_EmployeeBasicInfoId"].Value = resultcd3fb793f256485419196ff9147e285e[0];
if(resultcd3fb793f256485419196ff9147e285e.ContainsKey(6))
ISpace["UC_Department"].Value = resultcd3fb793f256485419196ff9147e285e[6];
if(resultcd3fb793f256485419196ff9147e285e.ContainsKey(2))
ISpace["UC_Name"].Value = resultcd3fb793f256485419196ff9147e285e[2];
if(resultcd3fb793f256485419196ff9147e285e.ContainsKey(11))
ISpace["UC_EmployeeName"].Value = resultcd3fb793f256485419196ff9147e285e[11];
}
else{
ISpace["UC_EmployeeId"].Value = null;ISpace["UC_DOR"].Value = null;ISpace["UC_Grade"].Value = null;ISpace["UC_Designation"].Value = null;ISpace["UC_DOB"].Value = null;ISpace["UC_EmailId"].Value = null;ISpace["UC_DOJ"].Value = null;ISpace["UC_EmployeeBasicInfoId"].Value = null;ISpace["UC_Department"].Value = null;ISpace["UC_Name"].Value = null;ISpace["UC_EmployeeName"].Value = null;
}
ISpace["MF_IsAdvance"].Value=false;
base.WriteDebugInfo(@"ISpace[""MF_IsAdvance""].Value=false;");
ISpace["MG_d1_Amount"].Man=true;ISpace["MG_d1_ItemDescription"].Man=true;ISpace["MG_d1_ExpenseDetails"].Man=true;
base.WriteDebugInfo(@"ISpace[""MG_d1_Amount""].Man=true;ISpace[""MG_d1_ItemDescription""].Man=true;ISpace[""MG_d1_ExpenseDetails""].Man=true;");
base.WriteDebugInfo(@"EXEC GenerateRef 1");

var querySource8ac4323ce2eda64143dca0a21b55f2e5 =GetQueryExpressionDataSource("8ac4323c-e2ed-a641-43dc-a0a21b55f2e5");
Dictionary<short,object> result8ac4323ce2eda64143dca0a21b55f2e5=iSpace.ExecuteQuery(querySource8ac4323ce2eda64143dca0a21b55f2e5,@"EXECGenerateRef 1",false);

base.WriteDebugInfo(@"var querySource8ac4323ce2eda64143dca0a21b55f2e5 =GetQueryExpressionDataSource(""8ac4323c-e2ed-a641-43dc-a0a21b55f2e5"");Dictionary<short,object> result8ac4323ce2eda64143dca0a21b55f2e5=iSpace.ExecuteQuery(querySource8ac4323ce2eda64143dca0a21b55f2e5,@""EXECGenerateRef 1"",false);");
base.WriteDebugInfo(@"");

if((result8ac4323ce2eda64143dca0a21b55f2e5!=null) && (result8ac4323ce2eda64143dca0a21b55f2e5.Count!=0))
{
if(result8ac4323ce2eda64143dca0a21b55f2e5.ContainsKey(0))
ISpace["Subject"].Value = result8ac4323ce2eda64143dca0a21b55f2e5[0];
if(result8ac4323ce2eda64143dca0a21b55f2e5.ContainsKey(0))
ISpace["TA_refNo"].Value = result8ac4323ce2eda64143dca0a21b55f2e5[0];
}
else{
ISpace["Subject"].Value = null;ISpace["TA_refNo"].Value = null;
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
private void SubscribeElementEvents_save_advancerequestdetails (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Save_AdvanceRequestDetails-OnClick");
if(ISpace["growid"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""growid""].Value=="""")");

var querySource4CA3178A72124B35B354A6CC18BA475A =GetQueryExpressionDataSource("4CA3178A-7212-4B35-B354-A6CC18BA475A");

DataTable result4CA3178A72124B35B354A6CC18BA475A=iSpace.SetGridDataSource(querySource4CA3178A72124B35B354A6CC18BA475A, _objectFactory.GetGridRPP("AdvanceRequestDetails"),@"EXEC [AddFormGridData0337B98B-59FA-46DC-87A0-89AA288D41AC] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','0337B98B-59FA-46DC-87A0-89AA288D41AC','" + ISpace["growid"].Value + @"'," + ISpace["AdvanceRequestDetails_Sequence"].Value + @",'" + ISpace["MFG_d1_RequestDetailsId"].Value + @"','" + ISpace["MFG_d1_AdvanceFormId"].Value + @"','" + ISpace["MFG_d1_ExpenseDetails"].Value + @"','" + ISpace["MFG_d1_ItemDescription"].Value + @"'," + ISpace["MFG_d1_Amount"].Value + @"");

iSpace.InsertGridBindDetails("AdvanceRequestDetails","11",querySource4CA3178A72124B35B354A6CC18BA475A,"EXEC [AddFormGridData0337B98B-59FA-46DC-87A0-89AA288D41AC] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','0337B98B-59FA-46DC-87A0-89AA288D41AC','" + ISpace["growid"].Value + @"'," + ISpace["AdvanceRequestDetails_Sequence"].Value + @",'" + ISpace["MFG_d1_RequestDetailsId"].Value + @"','" + ISpace["MFG_d1_AdvanceFormId"].Value + @"','" + ISpace["MFG_d1_ExpenseDetails"].Value + @"','" + ISpace["MFG_d1_ItemDescription"].Value + @"'," + ISpace["MFG_d1_Amount"].Value + @"",_objectFactory.GetGridRPP("AdvanceRequestDetails"));

base.WriteDebugInfo(@"var querySource4CA3178A72124B35B354A6CC18BA475A =GetQueryExpressionDataSource(""4CA3178A-7212-4B35-B354-A6CC18BA475A"");DataTable result4CA3178A72124B35B354A6CC18BA475A=iSpace.SetGridDataSource(querySource4CA3178A72124B35B354A6CC18BA475A, _objectFactory.GetGridRPP(""AdvanceRequestDetails""),@""EXEC [AddFormGridData0337B98B-59FA-46DC-87A0-89AA288D41AC] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','0337B98B-59FA-46DC-87A0-89AA288D41AC','"" + ISpace[""growid""].Value + @""',"" + ISpace[""AdvanceRequestDetails_Sequence""].Value + @"",'"" + ISpace[""MFG_d1_RequestDetailsId""].Value + @""','"" + ISpace[""MFG_d1_AdvanceFormId""].Value + @""','"" + ISpace[""MFG_d1_ExpenseDetails""].Value + @""','"" + ISpace[""MFG_d1_ItemDescription""].Value + @""',"" + ISpace[""MFG_d1_Amount""].Value + @"""");iSpace.InsertGridBindDetails(""AdvanceRequestDetails"",""11"",querySource4CA3178A72124B35B354A6CC18BA475A,""EXEC [AddFormGridData0337B98B-59FA-46DC-87A0-89AA288D41AC] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','0337B98B-59FA-46DC-87A0-89AA288D41AC','"" + ISpace[""growid""].Value + @""',"" + ISpace[""AdvanceRequestDetails_Sequence""].Value + @"",'"" + ISpace[""MFG_d1_RequestDetailsId""].Value + @""','"" + ISpace[""MFG_d1_AdvanceFormId""].Value + @""','"" + ISpace[""MFG_d1_ExpenseDetails""].Value + @""','"" + ISpace[""MFG_d1_ItemDescription""].Value + @""',"" + ISpace[""MFG_d1_Amount""].Value + @"""",_objectFactory.GetGridRPP(""AdvanceRequestDetails""));");
base.WriteDebugInfo(@"EXEC [AddFormGridData0337B98B-59FA-46DC-87A0-89AA288D41AC] '@@gv_InstanceId','@@gv_ActivityMapId','0337B98B-59FA-46DC-87A0-89AA288D41AC','#growid',#AdvanceRequestDetails_Sequence,'#MFG_d1_RequestDetailsId','#MFG_d1_AdvanceFormId','#MFG_d1_ExpenseDetails','#MFG_d1_ItemDescription',#MFG_d1_Amount");


List<Triplet<string, short, short?>> result2979992289B54073A7806510276859B5=acdataIspaceA8D5026A49FD44A0BEBEAA595B40C453.GetQueryExpressionBindings("29799922-89B5-4073-A780-6510276859B5");
iSpace.SetGridData(result4CA3178A72124B35B354A6CC18BA475A,result2979992289B54073A7806510276859B5,"AdvanceRequestDetails",ref ISpace);
iSpace.UpdateGridBindDetails("AdvanceRequestDetails",result2979992289B54073A7806510276859B5);
}
else
{
base.WriteDebugInfo(@"else");

var querySource457DF483466042DA82EB1BA15638CB37 =GetQueryExpressionDataSource("457DF483-4660-42DA-82EB-1BA15638CB37");

DataTable result457DF483466042DA82EB1BA15638CB37=iSpace.SetGridDataSource(querySource457DF483466042DA82EB1BA15638CB37, _objectFactory.GetGridRPP("AdvanceRequestDetails"),@"EXEC [UpdateFormGridData0337B98B-59FA-46DC-87A0-89AA288D41AC] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','0337B98B-59FA-46DC-87A0-89AA288D41AC','" + ISpace["growid"].Value + @"'," + ISpace["AdvanceRequestDetails_Sequence"].Value + @",'" + ISpace["MFG_d1_RequestDetailsId"].Value + @"','" + ISpace["MFG_d1_AdvanceFormId"].Value + @"','" + ISpace["MFG_d1_ExpenseDetails"].Value + @"','" + ISpace["MFG_d1_ItemDescription"].Value + @"'," + ISpace["MFG_d1_Amount"].Value + @"");

iSpace.InsertGridBindDetails("AdvanceRequestDetails","11",querySource457DF483466042DA82EB1BA15638CB37,"EXEC [UpdateFormGridData0337B98B-59FA-46DC-87A0-89AA288D41AC] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','0337B98B-59FA-46DC-87A0-89AA288D41AC','" + ISpace["growid"].Value + @"'," + ISpace["AdvanceRequestDetails_Sequence"].Value + @",'" + ISpace["MFG_d1_RequestDetailsId"].Value + @"','" + ISpace["MFG_d1_AdvanceFormId"].Value + @"','" + ISpace["MFG_d1_ExpenseDetails"].Value + @"','" + ISpace["MFG_d1_ItemDescription"].Value + @"'," + ISpace["MFG_d1_Amount"].Value + @"",_objectFactory.GetGridRPP("AdvanceRequestDetails"));

base.WriteDebugInfo(@"var querySource457DF483466042DA82EB1BA15638CB37 =GetQueryExpressionDataSource(""457DF483-4660-42DA-82EB-1BA15638CB37"");DataTable result457DF483466042DA82EB1BA15638CB37=iSpace.SetGridDataSource(querySource457DF483466042DA82EB1BA15638CB37, _objectFactory.GetGridRPP(""AdvanceRequestDetails""),@""EXEC [UpdateFormGridData0337B98B-59FA-46DC-87A0-89AA288D41AC] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','0337B98B-59FA-46DC-87A0-89AA288D41AC','"" + ISpace[""growid""].Value + @""',"" + ISpace[""AdvanceRequestDetails_Sequence""].Value + @"",'"" + ISpace[""MFG_d1_RequestDetailsId""].Value + @""','"" + ISpace[""MFG_d1_AdvanceFormId""].Value + @""','"" + ISpace[""MFG_d1_ExpenseDetails""].Value + @""','"" + ISpace[""MFG_d1_ItemDescription""].Value + @""',"" + ISpace[""MFG_d1_Amount""].Value + @"""");iSpace.InsertGridBindDetails(""AdvanceRequestDetails"",""11"",querySource457DF483466042DA82EB1BA15638CB37,""EXEC [UpdateFormGridData0337B98B-59FA-46DC-87A0-89AA288D41AC] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','0337B98B-59FA-46DC-87A0-89AA288D41AC','"" + ISpace[""growid""].Value + @""',"" + ISpace[""AdvanceRequestDetails_Sequence""].Value + @"",'"" + ISpace[""MFG_d1_RequestDetailsId""].Value + @""','"" + ISpace[""MFG_d1_AdvanceFormId""].Value + @""','"" + ISpace[""MFG_d1_ExpenseDetails""].Value + @""','"" + ISpace[""MFG_d1_ItemDescription""].Value + @""',"" + ISpace[""MFG_d1_Amount""].Value + @"""",_objectFactory.GetGridRPP(""AdvanceRequestDetails""));");
base.WriteDebugInfo(@"EXEC [UpdateFormGridData0337B98B-59FA-46DC-87A0-89AA288D41AC] '@@gv_InstanceId','@@gv_ActivityMapId','0337B98B-59FA-46DC-87A0-89AA288D41AC','#growid',#AdvanceRequestDetails_Sequence,'#MFG_d1_RequestDetailsId','#MFG_d1_AdvanceFormId','#MFG_d1_ExpenseDetails','#MFG_d1_ItemDescription',#MFG_d1_Amount");


List<Triplet<string, short, short?>> result67DEF8CBD0314FD48DC943298D811794=acdataIspaceA8D5026A49FD44A0BEBEAA595B40C453.GetQueryExpressionBindings("67DEF8CB-D031-4FD4-8DC9-43298D811794");
iSpace.SetGridData(result457DF483466042DA82EB1BA15638CB37,result67DEF8CBD0314FD48DC943298D811794,"AdvanceRequestDetails",ref ISpace);
iSpace.UpdateGridBindDetails("AdvanceRequestDetails",result67DEF8CBD0314FD48DC943298D811794);
}
ISpace["growid"].Value="";
base.WriteDebugInfo(@"ISpace[""growid""].Value="""";");
ISpace["MFG_d1_RequestDetailsId"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d1_RequestDetailsId""].Value="""";");
ISpace["MFG_d1_AdvanceFormId"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d1_AdvanceFormId""].Value="""";");
ISpace["MFG_d1_ExpenseDetails"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d1_ExpenseDetails""].Value="""";");
ISpace["MFG_d1_ItemDescription"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d1_ItemDescription""].Value="""";");
ISpace["MFG_d1_Amount"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d1_Amount""].Value="""";");
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
if(ISpace["WF_FlowType"].Value=="APPROVE")
{
base.WriteDebugInfo(@"if(ISpace[""WF_FlowType""].Value==""APPROVE"")");
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
if(ISpace["WF_FlowType"].Value=="RETURN" || ISpace["WF_FlowType"].Value=="REJECT")
{
base.WriteDebugInfo(@"if(ISpace[""WF_FlowType""].Value==""RETURN"" || ISpace[""WF_FlowType""].Value==""REJECT"")");
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
if(ISpace["MF_FundTotal"].Value!=ISpace["MF_d2_TotalAmount"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_FundTotal""].Value!=ISpace[""MF_d2_TotalAmount""].Value)");
ISpace["Message"].Value=@"Error:Total Amount And Overall Fund Total must be equal";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Error:Total Amount And Overall Fund Total must be equal"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
base.WriteDebugInfo(@"EXEC InnovaceNoCode..[FormSave_744F780C-12D2-41D3-9084-6E903A527934]   '@@gv_InstanceId','@@gv_ActivityMapId','85014d12-a85b-4330-8d7f-29776cbda319','#MF_d2_AdvanceFormId','#MF_d2_EmployeeBasicInfoId',#MF_d2_TotalAmount,'#MF_d2_Initiatedon','#MF_d2_InitatedBy','#MF_d2_ApplicationStatus','#MF_d2_UpdatedBy','#MF_d2_UpdatedOn','#TA_refNo','#MF_IsAdvance'");

var querySource29CE51BC9310456E84FAC3692433C21E =GetQueryExpressionDataSource("29CE51BC-9310-456E-84FA-C3692433C21E");
Dictionary<short,object> result29CE51BC9310456E84FAC3692433C21E=iSpace.ExecuteQuery(querySource29CE51BC9310456E84FAC3692433C21E,@"EXEC InnovaceNoCode..[FormSave_744F780C-12D2-41D3-9084-6E903A527934]   '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','85014d12-a85b-4330-8d7f-29776cbda319','" + ISpace["MF_d2_AdvanceFormId"].Value + @"','" + ISpace["MF_d2_EmployeeBasicInfoId"].Value + @"'," + ISpace["MF_d2_TotalAmount"].Value + @",'" + ISpace["MF_d2_Initiatedon"].Value + @"','" + ISpace["MF_d2_InitatedBy"].Value + @"','" + ISpace["MF_d2_ApplicationStatus"].Value + @"','" + ISpace["MF_d2_UpdatedBy"].Value + @"','" + ISpace["MF_d2_UpdatedOn"].Value + @"','" + ISpace["TA_refNo"].Value + @"','" + ISpace["MF_IsAdvance"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource29CE51BC9310456E84FAC3692433C21E =GetQueryExpressionDataSource(""29CE51BC-9310-456E-84FA-C3692433C21E"");Dictionary<short,object> result29CE51BC9310456E84FAC3692433C21E=iSpace.ExecuteQuery(querySource29CE51BC9310456E84FAC3692433C21E,@""EXEC InnovaceNoCode..[FormSave_744F780C-12D2-41D3-9084-6E903A527934]   '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','85014d12-a85b-4330-8d7f-29776cbda319','"" + ISpace[""MF_d2_AdvanceFormId""].Value + @""','"" + ISpace[""MF_d2_EmployeeBasicInfoId""].Value + @""',"" + ISpace[""MF_d2_TotalAmount""].Value + @"",'"" + ISpace[""MF_d2_Initiatedon""].Value + @""','"" + ISpace[""MF_d2_InitatedBy""].Value + @""','"" + ISpace[""MF_d2_ApplicationStatus""].Value + @""','"" + ISpace[""MF_d2_UpdatedBy""].Value + @""','"" + ISpace[""MF_d2_UpdatedOn""].Value + @""','"" + ISpace[""TA_refNo""].Value + @""','"" + ISpace[""MF_IsAdvance""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result29CE51BC9310456E84FAC3692433C21E!=null) && (result29CE51BC9310456E84FAC3692433C21E.Count!=0))
{
if(result29CE51BC9310456E84FAC3692433C21E.ContainsKey(0))
ISpace["ExecutionMessage"].Value = result29CE51BC9310456E84FAC3692433C21E[0];
}
else{
ISpace["ExecutionMessage"].Value = null;
}
base.WriteDebugInfo(@"EXEC InnovaceNoCode..[GridSave_0337B98B-59FA-46DC-87A0-89AA288D41AC]   '@@gv_InstanceId','@@gv_ActivityMapId','0337B98B-59FA-46DC-87A0-89AA288D41AC'");

var querySourceB6975CE7CE564E4DB7CC2B1863890CE7 =GetQueryExpressionDataSource("B6975CE7-CE56-4E4D-B7CC-2B1863890CE7");
Dictionary<short,object> resultB6975CE7CE564E4DB7CC2B1863890CE7=iSpace.ExecuteQuery(querySourceB6975CE7CE564E4DB7CC2B1863890CE7,@"EXEC InnovaceNoCode..[GridSave_0337B98B-59FA-46DC-87A0-89AA288D41AC]   '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','0337B98B-59FA-46DC-87A0-89AA288D41AC'",false);

base.WriteDebugInfo(@"var querySourceB6975CE7CE564E4DB7CC2B1863890CE7 =GetQueryExpressionDataSource(""B6975CE7-CE56-4E4D-B7CC-2B1863890CE7"");Dictionary<short,object> resultB6975CE7CE564E4DB7CC2B1863890CE7=iSpace.ExecuteQuery(querySourceB6975CE7CE564E4DB7CC2B1863890CE7,@""EXEC InnovaceNoCode..[GridSave_0337B98B-59FA-46DC-87A0-89AA288D41AC]   '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','0337B98B-59FA-46DC-87A0-89AA288D41AC'"",false);");
base.WriteDebugInfo(@"");

if((resultB6975CE7CE564E4DB7CC2B1863890CE7!=null) && (resultB6975CE7CE564E4DB7CC2B1863890CE7.Count!=0))
{
if(resultB6975CE7CE564E4DB7CC2B1863890CE7.ContainsKey(0))
ISpace["ExecutionMessage"].Value = resultB6975CE7CE564E4DB7CC2B1863890CE7[0];
}
else{
ISpace["ExecutionMessage"].Value = null;
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
base.WriteDebugInfo(@"EXEC [SaveTempAdvanceDocuments] '@@gv_InstanceId','@@gv_ProcessMapId','@@gv_UserId'");

var querySource76cdd0d498cf655504d2066565596182 =GetQueryExpressionDataSource("76cdd0d4-98cf-6555-04d2-066565596182");
Dictionary<short,object> result76cdd0d498cf655504d2066565596182=iSpace.ExecuteQuery(querySource76cdd0d498cf655504d2066565596182,@"EXEC [SaveTempAdvanceDocuments] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','" + ISpace["gv_userid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource76cdd0d498cf655504d2066565596182 =GetQueryExpressionDataSource(""76cdd0d4-98cf-6555-04d2-066565596182"");Dictionary<short,object> result76cdd0d498cf655504d2066565596182=iSpace.ExecuteQuery(querySource76cdd0d498cf655504d2066565596182,@""EXEC [SaveTempAdvanceDocuments] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','"" + ISpace[""gv_userid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result76cdd0d498cf655504d2066565596182!=null) && (result76cdd0d498cf655504d2066565596182.Count!=0))
{
if(result76cdd0d498cf655504d2066565596182.ContainsKey(0))
ISpace["MF_ErrId"].Value = result76cdd0d498cf655504d2066565596182[0];
if(result76cdd0d498cf655504d2066565596182.ContainsKey(1))
ISpace["MF_ErrMsg"].Value = result76cdd0d498cf655504d2066565596182[1];
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

var querySource8C55982FEE834AF1A356390DE5D2877F =GetQueryExpressionDataSource("8C55982F-EE83-4AF1-A356-390DE5D2877F");
Dictionary<short,object> result8C55982FEE834AF1A356390DE5D2877F=iSpace.ExecuteQuery(querySource8C55982FEE834AF1A356390DE5D2877F,@"EXEC [UpsertProjectFundAllocation] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','" + ISpace["gv_userid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource8C55982FEE834AF1A356390DE5D2877F =GetQueryExpressionDataSource(""8C55982F-EE83-4AF1-A356-390DE5D2877F"");Dictionary<short,object> result8C55982FEE834AF1A356390DE5D2877F=iSpace.ExecuteQuery(querySource8C55982FEE834AF1A356390DE5D2877F,@""EXEC [UpsertProjectFundAllocation] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','"" + ISpace[""gv_userid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result8C55982FEE834AF1A356390DE5D2877F!=null) && (result8C55982FEE834AF1A356390DE5D2877F.Count!=0))
{
if(result8C55982FEE834AF1A356390DE5D2877F.ContainsKey(0))
ISpace["PFM_ErrId"].Value = result8C55982FEE834AF1A356390DE5D2877F[0];
}
else{
ISpace["PFM_ErrId"].Value = null;
}
ISpace["Message"].Value=@"Success: Submitted Successfully";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Success: Submitted Successfully"";");

ISpace["RedirectUrl"].RedirectType="R";
ISpace["RedirectUrl"].Value="?PkActMId=0325353E-7E13-4762-AFC9-88434C58F52C&frmElementId=49A96C7C-D729-40AB-BA35-E48EC2181E2D&PkPrMId=0CC7EA0F-1DD0-4053-9D0E-E7EF819021D7&formVersionId=C935B56C-79C4-4F7E-89BD-5FADD98FC65E&Ver=0.0000";
base.WriteDebugInfo(@"
ISpace[""RedirectUrl""].RedirectType=""R"";
ISpace[""RedirectUrl""].Value=""?PkActMId=0325353E-7E13-4762-AFC9-88434C58F52C&frmElementId=49A96C7C-D729-40AB-BA35-E48EC2181E2D&PkPrMId=0CC7EA0F-1DD0-4053-9D0E-E7EF819021D7&formVersionId=C935B56C-79C4-4F7E-89BD-5FADD98FC65E&Ver=0.0000"";");
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

var querySource7454D2C4EC3145E49820D4FE4FB7EDC9 =GetQueryExpressionDataSource("7454D2C4-EC31-45E4-9820-D4FE4FB7EDC9");
Dictionary<short,object> result7454D2C4EC3145E49820D4FE4FB7EDC9=iSpace.ExecuteQuery(querySource7454D2C4EC3145E49820D4FE4FB7EDC9,@"EXEC[Delete60e821d0-153e_94bb-1fef-2594b78625bd] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["PFM_FundDetailsId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource7454D2C4EC3145E49820D4FE4FB7EDC9 =GetQueryExpressionDataSource(""7454D2C4-EC31-45E4-9820-D4FE4FB7EDC9"");Dictionary<short,object> result7454D2C4EC3145E49820D4FE4FB7EDC9=iSpace.ExecuteQuery(querySource7454D2C4EC3145E49820D4FE4FB7EDC9,@""EXEC[Delete60e821d0-153e_94bb-1fef-2594b78625bd] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""PFM_FundDetailsId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result7454D2C4EC3145E49820D4FE4FB7EDC9!=null) && (result7454D2C4EC3145E49820D4FE4FB7EDC9.Count!=0))
{
if(result7454D2C4EC3145E49820D4FE4FB7EDC9.ContainsKey(0))
ISpace["PFM_ErrId"].Value = result7454D2C4EC3145E49820D4FE4FB7EDC9[0];
if(result7454D2C4EC3145E49820D4FE4FB7EDC9.ContainsKey(1))
ISpace["PFM_ErrMsg"].Value = result7454D2C4EC3145E49820D4FE4FB7EDC9[1];
}
else{
ISpace["PFM_ErrId"].Value = null;ISpace["PFM_ErrMsg"].Value = null;
}
ISpace["Message"].Value=String.Format(@"{0}",ISpace["PFM_ErrMsg"].Value);
base.WriteDebugInfo(@"ISpace[""Message""].Value=String.Format(@""{0}"",ISpace[""PFM_ErrMsg""].Value);");

var querySource705F1E2B47054D8E8B6512AD847DCF29 =GetQueryExpressionDataSource("705F1E2B-4705-4D8E-8B65-12AD847DCF29");

DataTable result705F1E2B47054D8E8B6512AD847DCF29=iSpace.SetGridDataSource(querySource705F1E2B47054D8E8B6512AD847DCF29, _objectFactory.GetGridRPP("MG_FundAllocation"),@"Exec [Get60e821d0-153e-94bb-1fef-2594b78625bd] '" + ISpace["gv_instanceid"].Value + @"'");

iSpace.InsertGridBindDetails("MG_FundAllocation","11",querySource705F1E2B47054D8E8B6512AD847DCF29,"Exec [Get60e821d0-153e-94bb-1fef-2594b78625bd] '" + ISpace["gv_instanceid"].Value + @"'",_objectFactory.GetGridRPP("MG_FundAllocation"));

base.WriteDebugInfo(@"var querySource705F1E2B47054D8E8B6512AD847DCF29 =GetQueryExpressionDataSource(""705F1E2B-4705-4D8E-8B65-12AD847DCF29"");DataTable result705F1E2B47054D8E8B6512AD847DCF29=iSpace.SetGridDataSource(querySource705F1E2B47054D8E8B6512AD847DCF29, _objectFactory.GetGridRPP(""MG_FundAllocation""),@""Exec [Get60e821d0-153e-94bb-1fef-2594b78625bd] '"" + ISpace[""gv_instanceid""].Value + @""'"");iSpace.InsertGridBindDetails(""MG_FundAllocation"",""11"",querySource705F1E2B47054D8E8B6512AD847DCF29,""Exec [Get60e821d0-153e-94bb-1fef-2594b78625bd] '"" + ISpace[""gv_instanceid""].Value + @""'"",_objectFactory.GetGridRPP(""MG_FundAllocation""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result1724FDC9047B45B8BCFEDD14A7738AD2=acdataIspaceA8D5026A49FD44A0BEBEAA595B40C453.GetQueryExpressionBindings("1724FDC9-047B-45B8-BCFE-DD14A7738AD2");
iSpace.SetGridData(result705F1E2B47054D8E8B6512AD847DCF29,result1724FDC9047B45B8BCFEDD14A7738AD2,"MG_FundAllocation",ref ISpace);
iSpace.UpdateGridBindDetails("MG_FundAllocation",result1724FDC9047B45B8BCFEDD14A7738AD2);
ISpace["PFM_FundDetailsId"].Value="";
base.WriteDebugInfo(@"ISpace[""PFM_FundDetailsId""].Value="""";");
ISpace["UI_DeleteDialog"].HideDialog=true;;
base.WriteDebugInfo(@"ISpace[""UI_DeleteDialog""].HideDialog=true;;");
base.WriteDebugInfo(@"EXEC [GetFundSum] '@@gv_InstanceId'");

var querySourcea336918c91187c39997885844c207f84 =GetQueryExpressionDataSource("a336918c-9118-7c39-9978-85844c207f84");
Dictionary<short,object> resulta336918c91187c39997885844c207f84=iSpace.ExecuteQuery(querySourcea336918c91187c39997885844c207f84,@"EXEC [GetFundSum] '" + ISpace["gv_instanceid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourcea336918c91187c39997885844c207f84 =GetQueryExpressionDataSource(""a336918c-9118-7c39-9978-85844c207f84"");Dictionary<short,object> resulta336918c91187c39997885844c207f84=iSpace.ExecuteQuery(querySourcea336918c91187c39997885844c207f84,@""EXEC [GetFundSum] '"" + ISpace[""gv_instanceid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resulta336918c91187c39997885844c207f84!=null) && (resulta336918c91187c39997885844c207f84.Count!=0))
{
if(resulta336918c91187c39997885844c207f84.ContainsKey(0))
ISpace["MF_FundTotal"].Value = resulta336918c91187c39997885844c207f84[0];
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
private void SubscribeElementEvents_mg_d1_amount (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MG_d1_Amount-OnChange");
object MG_d1_Amount=iSpace.Sum("[0337B98B-59FA-46DC-87A0-89AA288D41AC]","MG_d1_Amount","",ISpace["gv_instanceid"].Value);
ISpace["MF_d2_TotalAmount"].Value=Convert.ChangeType(MG_d1_Amount, MG_d1_Amount.GetType());;
base.WriteDebugInfo(@"object MG_d1_Amount=iSpace.Sum(""[0337B98B-59FA-46DC-87A0-89AA288D41AC]"",""MG_d1_Amount"","""",ISpace[""gv_instanceid""].Value);
ISpace[""MF_d2_TotalAmount""].Value=Convert.ChangeType(MG_d1_Amount, MG_d1_Amount.GetType());;");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_edit_advancerequestdetails (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Edit_AdvanceRequestDetails-OnClick");
ISpace["growid"].Value=ISpace["AdvanceRequestDetails_RowId"].Value;
base.WriteDebugInfo(@"ISpace[""growid""].Value=ISpace[""AdvanceRequestDetails_RowId""].Value;");
base.WriteDebugInfo(@"EXEC [LoadFormGridData0337B98B-59FA-46DC-87A0-89AA288D41AC] '@@gv_InstanceId','@@gv_ActivityMapId','0337B98B-59FA-46DC-87A0-89AA288D41AC','#growid',#AdvanceRequestDetails_Sequence");

var querySource0A6D4BD3999E458EB9306B42970476DD =GetQueryExpressionDataSource("0A6D4BD3-999E-458E-B930-6B42970476DD");
Dictionary<short,object> result0A6D4BD3999E458EB9306B42970476DD=iSpace.ExecuteQuery(querySource0A6D4BD3999E458EB9306B42970476DD,@"EXEC [LoadFormGridData0337B98B-59FA-46DC-87A0-89AA288D41AC] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','0337B98B-59FA-46DC-87A0-89AA288D41AC','" + ISpace["growid"].Value + @"'," + ISpace["AdvanceRequestDetails_Sequence"].Value + @"",false);

base.WriteDebugInfo(@"var querySource0A6D4BD3999E458EB9306B42970476DD =GetQueryExpressionDataSource(""0A6D4BD3-999E-458E-B930-6B42970476DD"");Dictionary<short,object> result0A6D4BD3999E458EB9306B42970476DD=iSpace.ExecuteQuery(querySource0A6D4BD3999E458EB9306B42970476DD,@""EXEC [LoadFormGridData0337B98B-59FA-46DC-87A0-89AA288D41AC] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','0337B98B-59FA-46DC-87A0-89AA288D41AC','"" + ISpace[""growid""].Value + @""',"" + ISpace[""AdvanceRequestDetails_Sequence""].Value + @"""",false);");
base.WriteDebugInfo(@"EXEC [LoadFormGridData0337B98B-59FA-46DC-87A0-89AA288D41AC] '@@gv_InstanceId','@@gv_ActivityMapId','0337B98B-59FA-46DC-87A0-89AA288D41AC','#growid',#AdvanceRequestDetails_Sequence");

if((result0A6D4BD3999E458EB9306B42970476DD!=null) && (result0A6D4BD3999E458EB9306B42970476DD.Count!=0))
{
if(result0A6D4BD3999E458EB9306B42970476DD.ContainsKey(4))
ISpace["MFG_d1_Amount"].Value = result0A6D4BD3999E458EB9306B42970476DD[4];
if(result0A6D4BD3999E458EB9306B42970476DD.ContainsKey(1))
ISpace["MFG_d1_AdvanceFormId"].Value = result0A6D4BD3999E458EB9306B42970476DD[1];
if(result0A6D4BD3999E458EB9306B42970476DD.ContainsKey(0))
ISpace["MFG_d1_RequestDetailsId"].Value = result0A6D4BD3999E458EB9306B42970476DD[0];
if(result0A6D4BD3999E458EB9306B42970476DD.ContainsKey(3))
ISpace["MFG_d1_ItemDescription"].Value = result0A6D4BD3999E458EB9306B42970476DD[3];
if(result0A6D4BD3999E458EB9306B42970476DD.ContainsKey(2))
ISpace["MFG_d1_ExpenseDetails"].Value = result0A6D4BD3999E458EB9306B42970476DD[2];
}
else{
ISpace["MFG_d1_Amount"].Value = null;ISpace["MFG_d1_AdvanceFormId"].Value = null;ISpace["MFG_d1_RequestDetailsId"].Value = null;ISpace["MFG_d1_ItemDescription"].Value = null;ISpace["MFG_d1_ExpenseDetails"].Value = null;
}
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
ISpace["WF_FlowType"].Value="APPROVE";
base.WriteDebugInfo(@"ISpace[""WF_FlowType""].Value=""APPROVE"";");
ISpace["Comments"].Man=false;
base.WriteDebugInfo(@"ISpace[""Comments""].Man=false;");
}
if(ISpace["WMF_MoveTo"].Value=="RETURN")
{
base.WriteDebugInfo(@"if(ISpace[""WMF_MoveTo""].Value==""RETURN"")");
ISpace["WF_FlowType"].Value="RETURN";
base.WriteDebugInfo(@"ISpace[""WF_FlowType""].Value=""RETURN"";");
ISpace["Comments"].Man=true;
base.WriteDebugInfo(@"ISpace[""Comments""].Man=true;");
}
if(ISpace["WMF_MoveTo"].Value=="REJECT")
{
base.WriteDebugInfo(@"if(ISpace[""WMF_MoveTo""].Value==""REJECT"")");
ISpace["WF_FlowType"].Value="REJECT";
base.WriteDebugInfo(@"ISpace[""WF_FlowType""].Value=""REJECT"";");
ISpace["Comments"].Man=true;
base.WriteDebugInfo(@"ISpace[""Comments""].Man=true;");
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
private void SubscribeElementEvents_pfa_edit (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"PFA_Edit-OnClick");
base.WriteDebugInfo(@"Exec [Get60e821d0-153e-94bb-1fef-2594b78625bd] '@@gv_InstanceId','#PFA_FundDetailsId'");

var querySource1AA578C6395747278F2A6B46297860EA =GetQueryExpressionDataSource("1AA578C6-3957-4727-8F2A-6B46297860EA");
Dictionary<short,object> result1AA578C6395747278F2A6B46297860EA=iSpace.ExecuteQuery(querySource1AA578C6395747278F2A6B46297860EA,@"Exec [Get60e821d0-153e-94bb-1fef-2594b78625bd] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["PFA_FundDetailsId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource1AA578C6395747278F2A6B46297860EA =GetQueryExpressionDataSource(""1AA578C6-3957-4727-8F2A-6B46297860EA"");Dictionary<short,object> result1AA578C6395747278F2A6B46297860EA=iSpace.ExecuteQuery(querySource1AA578C6395747278F2A6B46297860EA,@""Exec [Get60e821d0-153e-94bb-1fef-2594b78625bd] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""PFA_FundDetailsId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result1AA578C6395747278F2A6B46297860EA!=null) && (result1AA578C6395747278F2A6B46297860EA.Count!=0))
{
if(result1AA578C6395747278F2A6B46297860EA.ContainsKey(5))
ISpace["FWFM_FundType"].Value = result1AA578C6395747278F2A6B46297860EA[5];
if(result1AA578C6395747278F2A6B46297860EA.ContainsKey(9))
ISpace["FWFM_BudgetHead"].Value = result1AA578C6395747278F2A6B46297860EA[9];
if(result1AA578C6395747278F2A6B46297860EA.ContainsKey(7))
ISpace["FWFM_ProjectNo"].Value = result1AA578C6395747278F2A6B46297860EA[7];
if(result1AA578C6395747278F2A6B46297860EA.ContainsKey(11))
ISpace["FWFM_Amount"].Value = result1AA578C6395747278F2A6B46297860EA[11];
if(result1AA578C6395747278F2A6B46297860EA.ContainsKey(3))
ISpace["FWFM_FundDetailsId"].Value = result1AA578C6395747278F2A6B46297860EA[3];
}
else{
ISpace["FWFM_FundType"].Value = null;ISpace["FWFM_BudgetHead"].Value = null;ISpace["FWFM_ProjectNo"].Value = null;ISpace["FWFM_Amount"].Value = null;ISpace["FWFM_FundDetailsId"].Value = null;
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

var querySource1B34805740374195AEB72D251B781A4E =GetQueryExpressionDataSource("1B348057-4037-4195-AEB7-2D251B781A4E");
Dictionary<short,object> result1B34805740374195AEB72D251B781A4E=iSpace.ExecuteQuery(querySource1B34805740374195AEB72D251B781A4E,@"EXEC [Upsert60e821d0-153e-94bb-1fef-2594b78625bd] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','" + ISpace["FWFM_FundDetailsId"].Value + @"','" + ISpace["FWFM_FundType"].Value + @"','" + ISpace["FWFM_ProjectNo"].Value + @"','" + ISpace["FWFM_BudgetHead"].Value + @"','" + ISpace["FWFM_Amount"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource1B34805740374195AEB72D251B781A4E =GetQueryExpressionDataSource(""1B348057-4037-4195-AEB7-2D251B781A4E"");Dictionary<short,object> result1B34805740374195AEB72D251B781A4E=iSpace.ExecuteQuery(querySource1B34805740374195AEB72D251B781A4E,@""EXEC [Upsert60e821d0-153e-94bb-1fef-2594b78625bd] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','"" + ISpace[""FWFM_FundDetailsId""].Value + @""','"" + ISpace[""FWFM_FundType""].Value + @""','"" + ISpace[""FWFM_ProjectNo""].Value + @""','"" + ISpace[""FWFM_BudgetHead""].Value + @""','"" + ISpace[""FWFM_Amount""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result1B34805740374195AEB72D251B781A4E!=null) && (result1B34805740374195AEB72D251B781A4E.Count!=0))
{
if(result1B34805740374195AEB72D251B781A4E.ContainsKey(0))
ISpace["PFM_ErrId"].Value = result1B34805740374195AEB72D251B781A4E[0];
if(result1B34805740374195AEB72D251B781A4E.ContainsKey(1))
ISpace["PFM_ErrMsg"].Value = result1B34805740374195AEB72D251B781A4E[1];
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

var querySource705F1E2B47054D8E8B6512AD847DCF29 =GetQueryExpressionDataSource("705F1E2B-4705-4D8E-8B65-12AD847DCF29");

DataTable result705F1E2B47054D8E8B6512AD847DCF29=iSpace.SetGridDataSource(querySource705F1E2B47054D8E8B6512AD847DCF29, _objectFactory.GetGridRPP("MG_FundAllocation"),@"Exec [Get60e821d0-153e-94bb-1fef-2594b78625bd] '" + ISpace["gv_instanceid"].Value + @"'");

iSpace.InsertGridBindDetails("MG_FundAllocation","11",querySource705F1E2B47054D8E8B6512AD847DCF29,"Exec [Get60e821d0-153e-94bb-1fef-2594b78625bd] '" + ISpace["gv_instanceid"].Value + @"'",_objectFactory.GetGridRPP("MG_FundAllocation"));

base.WriteDebugInfo(@"var querySource705F1E2B47054D8E8B6512AD847DCF29 =GetQueryExpressionDataSource(""705F1E2B-4705-4D8E-8B65-12AD847DCF29"");DataTable result705F1E2B47054D8E8B6512AD847DCF29=iSpace.SetGridDataSource(querySource705F1E2B47054D8E8B6512AD847DCF29, _objectFactory.GetGridRPP(""MG_FundAllocation""),@""Exec [Get60e821d0-153e-94bb-1fef-2594b78625bd] '"" + ISpace[""gv_instanceid""].Value + @""'"");iSpace.InsertGridBindDetails(""MG_FundAllocation"",""11"",querySource705F1E2B47054D8E8B6512AD847DCF29,""Exec [Get60e821d0-153e-94bb-1fef-2594b78625bd] '"" + ISpace[""gv_instanceid""].Value + @""'"",_objectFactory.GetGridRPP(""MG_FundAllocation""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result1724FDC9047B45B8BCFEDD14A7738AD2=acdataIspaceA8D5026A49FD44A0BEBEAA595B40C453.GetQueryExpressionBindings("1724FDC9-047B-45B8-BCFE-DD14A7738AD2");
iSpace.SetGridData(result705F1E2B47054D8E8B6512AD847DCF29,result1724FDC9047B45B8BCFEDD14A7738AD2,"MG_FundAllocation",ref ISpace);
iSpace.UpdateGridBindDetails("MG_FundAllocation",result1724FDC9047B45B8BCFEDD14A7738AD2);
base.WriteDebugInfo(@"EXEC [GetFundSum] '@@gv_InstanceId'");

var querySourcea336918c91187c39997885844c207f84 =GetQueryExpressionDataSource("a336918c-9118-7c39-9978-85844c207f84");
Dictionary<short,object> resulta336918c91187c39997885844c207f84=iSpace.ExecuteQuery(querySourcea336918c91187c39997885844c207f84,@"EXEC [GetFundSum] '" + ISpace["gv_instanceid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourcea336918c91187c39997885844c207f84 =GetQueryExpressionDataSource(""a336918c-9118-7c39-9978-85844c207f84"");Dictionary<short,object> resulta336918c91187c39997885844c207f84=iSpace.ExecuteQuery(querySourcea336918c91187c39997885844c207f84,@""EXEC [GetFundSum] '"" + ISpace[""gv_instanceid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resulta336918c91187c39997885844c207f84!=null) && (resulta336918c91187c39997885844c207f84.Count!=0))
{
if(resulta336918c91187c39997885844c207f84.ContainsKey(0))
ISpace["MF_FundTotal"].Value = resulta336918c91187c39997885844c207f84[0];
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
private void SubscribeElementEvents_pfa_widgetsubmit (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"PFA_WidgetSubmit-OnClick");
base.WriteDebugInfo(@"EXEC [UpsertProjectFundAllocation] '@@gv_InstanceId','@@gv_ProcessMapId','@@gv_UserId'");

var querySource8C55982FEE834AF1A356390DE5D2877F =GetQueryExpressionDataSource("8C55982F-EE83-4AF1-A356-390DE5D2877F");
Dictionary<short,object> result8C55982FEE834AF1A356390DE5D2877F=iSpace.ExecuteQuery(querySource8C55982FEE834AF1A356390DE5D2877F,@"EXEC [UpsertProjectFundAllocation] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','" + ISpace["gv_userid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource8C55982FEE834AF1A356390DE5D2877F =GetQueryExpressionDataSource(""8C55982F-EE83-4AF1-A356-390DE5D2877F"");Dictionary<short,object> result8C55982FEE834AF1A356390DE5D2877F=iSpace.ExecuteQuery(querySource8C55982FEE834AF1A356390DE5D2877F,@""EXEC [UpsertProjectFundAllocation] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','"" + ISpace[""gv_userid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result8C55982FEE834AF1A356390DE5D2877F!=null) && (result8C55982FEE834AF1A356390DE5D2877F.Count!=0))
{
if(result8C55982FEE834AF1A356390DE5D2877F.ContainsKey(0))
ISpace["PFM_ErrId"].Value = result8C55982FEE834AF1A356390DE5D2877F[0];
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
		if(elementName.ToLower().Equals("mg_d1_amount"))
    {
    			SubscribeElementEvents_mg_d1_amount(ref dfsParam);
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
		if(elementName.ToLower().Equals("fwmf_availablebudget"))
{
			SubscribeElementEvents_fwmf_availablebudget(ref dfsParam);
}
		if(elementName.ToLower().Equals("save_advancerequestdetails"))
{
			SubscribeElementEvents_save_advancerequestdetails(ref dfsParam);
}
		if(elementName.ToLower().Equals("submitform"))
{
			SubscribeElementEvents_submitform(ref dfsParam);
}
		if(elementName.ToLower().Equals("pfm_yes"))
{
			SubscribeElementEvents_pfm_yes(ref dfsParam);
}
		if(elementName.ToLower().Equals("edit_advancerequestdetails"))
{
			SubscribeElementEvents_edit_advancerequestdetails(ref dfsParam);
}
		if(elementName.ToLower().Equals("pfa_delete"))
{
			SubscribeElementEvents_pfa_delete(ref dfsParam);
}
		if(elementName.ToLower().Equals("pfa_edit"))
{
			SubscribeElementEvents_pfa_edit(ref dfsParam);
}
		if(elementName.ToLower().Equals("fwfm_save"))
{
			SubscribeElementEvents_fwfm_save(ref dfsParam);
}
		if(elementName.ToLower().Equals("pfa_widgetsubmit"))
{
			SubscribeElementEvents_pfa_widgetsubmit(ref dfsParam);
}
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
public class ISpaceB7191F8399C7433E8CACB4D23CA6AB2E : VirtualForm
{
IISpace iSpace = new ISpace();
AcDataISpaceB7191F8399C7433E8CACB4D23CA6AB2E acdataIspaceB7191F8399C7433E8CACB4D23CA6AB2E=new AcDataISpaceB7191F8399C7433E8CACB4D23CA6AB2E();
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
if(ISpace["FormVersionId"].Value=="228701A8-2089-4481-B018-4BE30083D0D9")
{
ISpace["UI_ApprovalHideRow"].Visible="false";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""228701A8-2089-4481-B018-4BE30083D0D9"")
{
ISpace[""UI_ApprovalHideRow""].Visible=""false"";
}");
}
if(ISpace["WF_FlowType"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""WF_FlowType""].Value=="""")");
ISpace["WMF_IsInFlow"].Value=0;
base.WriteDebugInfo(@"ISpace[""WMF_IsInFlow""].Value=0;");
base.WriteDebugInfo(@"EXEC [GetInstanceInFlow] '@@gv_InstanceId'");

var querySource28B5F25AB9D745C8AB83AB07D5048EAD =GetQueryExpressionDataSource("28B5F25A-B9D7-45C8-AB83-AB07D5048EAD");
Dictionary<short,object> result28B5F25AB9D745C8AB83AB07D5048EAD=iSpace.ExecuteQuery(querySource28B5F25AB9D745C8AB83AB07D5048EAD,@"EXEC [GetInstanceInFlow] '" + ISpace["gv_instanceid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource28B5F25AB9D745C8AB83AB07D5048EAD =GetQueryExpressionDataSource(""28B5F25A-B9D7-45C8-AB83-AB07D5048EAD"");Dictionary<short,object> result28B5F25AB9D745C8AB83AB07D5048EAD=iSpace.ExecuteQuery(querySource28B5F25AB9D745C8AB83AB07D5048EAD,@""EXEC [GetInstanceInFlow] '"" + ISpace[""gv_instanceid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result28B5F25AB9D745C8AB83AB07D5048EAD!=null) && (result28B5F25AB9D745C8AB83AB07D5048EAD.Count!=0))
{
if(result28B5F25AB9D745C8AB83AB07D5048EAD.ContainsKey(0))
ISpace["WMF_IsInFlow"].Value = result28B5F25AB9D745C8AB83AB07D5048EAD[0];
}
else{
ISpace["WMF_IsInFlow"].Value = null;
}
if(ISpace["WMF_IsInFlow"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""WMF_IsInFlow""].Value==1)");
ISpace["WF_FlowType"].Value="APPROVE";
base.WriteDebugInfo(@"ISpace[""WF_FlowType""].Value=""APPROVE"";");
ISpace["WMF_History"].Visible="true";ISpace["WMF_MoveTo"].Visible="true";
base.WriteDebugInfo(@"ISpace[""WMF_History""].Visible=""true"";ISpace[""WMF_MoveTo""].Visible=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["WMF_History"].Visible="false";ISpace["WMF_MoveTo"].Visible="false";
base.WriteDebugInfo(@"ISpace[""WMF_History""].Visible=""false"";ISpace[""WMF_MoveTo""].Visible=""false"";");
}
}
ISpace["WMF_MoveTo"].Man=true;
base.WriteDebugInfo(@"ISpace[""WMF_MoveTo""].Man=true;");
ISpace["WMF_MoveTo"].Value="";
base.WriteDebugInfo(@"ISpace[""WMF_MoveTo""].Value="""";");
ISpace["Comments"].Value="";
base.WriteDebugInfo(@"ISpace[""Comments""].Value="""";");

var querySource72ABBA101D3E4391BDBDEBBE0E2E0237 =GetQueryExpressionDataSource("72ABBA10-1D3E-4391-BDBD-EBBE0E2E0237");

DataTable result72ABBA101D3E4391BDBDEBBE0E2E0237=iSpace.SetGridDataSource(querySource72ABBA101D3E4391BDBDEBBE0E2E0237, _objectFactory.GetGridRPP("WMG_CommentsHistory"),@"EXEC [GetInstanceFlowDetais] '" + ISpace["gv_instanceid"].Value + @"'");

iSpace.InsertGridBindDetails("WMG_CommentsHistory","11",querySource72ABBA101D3E4391BDBDEBBE0E2E0237,"EXEC [GetInstanceFlowDetais] '" + ISpace["gv_instanceid"].Value + @"'",_objectFactory.GetGridRPP("WMG_CommentsHistory"));

base.WriteDebugInfo(@"var querySource72ABBA101D3E4391BDBDEBBE0E2E0237 =GetQueryExpressionDataSource(""72ABBA10-1D3E-4391-BDBD-EBBE0E2E0237"");DataTable result72ABBA101D3E4391BDBDEBBE0E2E0237=iSpace.SetGridDataSource(querySource72ABBA101D3E4391BDBDEBBE0E2E0237, _objectFactory.GetGridRPP(""WMG_CommentsHistory""),@""EXEC [GetInstanceFlowDetais] '"" + ISpace[""gv_instanceid""].Value + @""'"");iSpace.InsertGridBindDetails(""WMG_CommentsHistory"",""11"",querySource72ABBA101D3E4391BDBDEBBE0E2E0237,""EXEC [GetInstanceFlowDetais] '"" + ISpace[""gv_instanceid""].Value + @""'"",_objectFactory.GetGridRPP(""WMG_CommentsHistory""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result6DA5E7991709406E85D09DC6581E03C3=acdataIspaceB7191F8399C7433E8CACB4D23CA6AB2E.GetQueryExpressionBindings("6DA5E799-1709-406E-85D0-9DC6581E03C3");
iSpace.SetGridData(result72ABBA101D3E4391BDBDEBBE0E2E0237,result6DA5E7991709406E85D09DC6581E03C3,"WMG_CommentsHistory",ref ISpace);
iSpace.UpdateGridBindDetails("WMG_CommentsHistory",result6DA5E7991709406E85D09DC6581E03C3);
ISpace["MF_IsAdvance"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MF_IsAdvance""].Enbl=""false"";");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_wmf_history (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"WMF_History-OnClick");

var querySource72ABBA101D3E4391BDBDEBBE0E2E0237 =GetQueryExpressionDataSource("72ABBA10-1D3E-4391-BDBD-EBBE0E2E0237");

DataTable result72ABBA101D3E4391BDBDEBBE0E2E0237=iSpace.SetGridDataSource(querySource72ABBA101D3E4391BDBDEBBE0E2E0237, _objectFactory.GetGridRPP("WMG_CommentsHistory"),@"EXEC [GetInstanceFlowDetais] '" + ISpace["gv_instanceid"].Value + @"'");

iSpace.InsertGridBindDetails("WMG_CommentsHistory","11",querySource72ABBA101D3E4391BDBDEBBE0E2E0237,"EXEC [GetInstanceFlowDetais] '" + ISpace["gv_instanceid"].Value + @"'",_objectFactory.GetGridRPP("WMG_CommentsHistory"));

base.WriteDebugInfo(@"var querySource72ABBA101D3E4391BDBDEBBE0E2E0237 =GetQueryExpressionDataSource(""72ABBA10-1D3E-4391-BDBD-EBBE0E2E0237"");DataTable result72ABBA101D3E4391BDBDEBBE0E2E0237=iSpace.SetGridDataSource(querySource72ABBA101D3E4391BDBDEBBE0E2E0237, _objectFactory.GetGridRPP(""WMG_CommentsHistory""),@""EXEC [GetInstanceFlowDetais] '"" + ISpace[""gv_instanceid""].Value + @""'"");iSpace.InsertGridBindDetails(""WMG_CommentsHistory"",""11"",querySource72ABBA101D3E4391BDBDEBBE0E2E0237,""EXEC [GetInstanceFlowDetais] '"" + ISpace[""gv_instanceid""].Value + @""'"",_objectFactory.GetGridRPP(""WMG_CommentsHistory""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result6DA5E7991709406E85D09DC6581E03C3=acdataIspaceB7191F8399C7433E8CACB4D23CA6AB2E.GetQueryExpressionBindings("6DA5E799-1709-406E-85D0-9DC6581E03C3");
iSpace.SetGridData(result72ABBA101D3E4391BDBDEBBE0E2E0237,result6DA5E7991709406E85D09DC6581E03C3,"WMG_CommentsHistory",ref ISpace);
iSpace.UpdateGridBindDetails("WMG_CommentsHistory",result6DA5E7991709406E85D09DC6581E03C3);
ISpace["UI_History"].ShowDialog=true;;
base.WriteDebugInfo(@"ISpace[""UI_History""].ShowDialog=true;;");
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
if(ISpace["WF_FlowType"].Value=="APPROVE")
{
base.WriteDebugInfo(@"if(ISpace[""WF_FlowType""].Value==""APPROVE"")");
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
if(ISpace["WF_FlowType"].Value=="RETURN" || ISpace["WF_FlowType"].Value=="REJECT")
{
base.WriteDebugInfo(@"if(ISpace[""WF_FlowType""].Value==""RETURN"" || ISpace[""WF_FlowType""].Value==""REJECT"")");
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
ISpace["Message"].Value=@"Success: Submitted Successfully";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Success: Submitted Successfully"";");

ISpace["RedirectUrl"].RedirectType="R";
ISpace["RedirectUrl"].Value="/Inbox";
base.WriteDebugInfo(@"
ISpace[""RedirectUrl""].RedirectType=""R"";
ISpace[""RedirectUrl""].Value=""/Inbox"";");
if(ISpace["WF_FlowType"].Value=="REJECT"||ISpace["WF_FlowType"].Value=="RETURN")
{
base.WriteDebugInfo(@"if(ISpace[""WF_FlowType""].Value==""REJECT""||ISpace[""WF_FlowType""].Value==""RETURN"")");
base.WriteDebugInfo(@"EXEC [UpdateTemporaryAdvanceStatus] '@@gv_InstanceId','#WF_FlowType','@@gv_UserId'");

var querySource4fc913b439b349cfb675a463ca4816fc =GetQueryExpressionDataSource("4fc913b4-39b3-49cf-b675-a463ca4816fc");
Dictionary<short,object> result4fc913b439b349cfb675a463ca4816fc=iSpace.ExecuteQuery(querySource4fc913b439b349cfb675a463ca4816fc,@"EXEC [UpdateTemporaryAdvanceStatus] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["WF_FlowType"].Value + @"','" + ISpace["gv_userid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource4fc913b439b349cfb675a463ca4816fc =GetQueryExpressionDataSource(""4fc913b4-39b3-49cf-b675-a463ca4816fc"");Dictionary<short,object> result4fc913b439b349cfb675a463ca4816fc=iSpace.ExecuteQuery(querySource4fc913b439b349cfb675a463ca4816fc,@""EXEC [UpdateTemporaryAdvanceStatus] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""WF_FlowType""].Value + @""','"" + ISpace[""gv_userid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result4fc913b439b349cfb675a463ca4816fc!=null) && (result4fc913b439b349cfb675a463ca4816fc.Count!=0))
{
if(result4fc913b439b349cfb675a463ca4816fc.ContainsKey(0))
ISpace["MF_ErrId"].Value = result4fc913b439b349cfb675a463ca4816fc[0];
}
else{
ISpace["MF_ErrId"].Value = null;
}
}
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
ISpace["WF_FlowType"].Value="APPROVE";
base.WriteDebugInfo(@"ISpace[""WF_FlowType""].Value=""APPROVE"";");
ISpace["Comments"].Man=false;
base.WriteDebugInfo(@"ISpace[""Comments""].Man=false;");
}
if(ISpace["WMF_MoveTo"].Value=="RETURN")
{
base.WriteDebugInfo(@"if(ISpace[""WMF_MoveTo""].Value==""RETURN"")");
ISpace["WF_FlowType"].Value="RETURN";
base.WriteDebugInfo(@"ISpace[""WF_FlowType""].Value=""RETURN"";");
ISpace["Comments"].Man=true;
base.WriteDebugInfo(@"ISpace[""Comments""].Man=true;");
}
if(ISpace["WMF_MoveTo"].Value=="REJECT")
{
base.WriteDebugInfo(@"if(ISpace[""WMF_MoveTo""].Value==""REJECT"")");
ISpace["WF_FlowType"].Value="REJECT";
base.WriteDebugInfo(@"ISpace[""WF_FlowType""].Value=""REJECT"";");
ISpace["Comments"].Man=true;
base.WriteDebugInfo(@"ISpace[""Comments""].Man=true;");
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
		if(elementName.ToLower().Equals("wmf_moveto"))
    {
    			SubscribeElementEvents_wmf_moveto(ref dfsParam);
    }
}
	if(methodName.ToLower().Equals("onclick"))
{
		if(elementName.ToLower().Equals("wmf_history"))
{
			SubscribeElementEvents_wmf_history(ref dfsParam);
}
		if(elementName.ToLower().Equals("submitform"))
{
			SubscribeElementEvents_submitform(ref dfsParam);
}
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
public class ISpace1D9F2FB872294AF1A535338A23491654 : VirtualForm
{
IISpace iSpace = new ISpace();
AcDataISpace1D9F2FB872294AF1A535338A23491654 acdataIspace1D9F2FB872294AF1A535338A23491654=new AcDataISpace1D9F2FB872294AF1A535338A23491654();
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
if(ISpace["FormVersionId"].Value=="228701A8-2089-4481-B018-4BE30083D0D9")
{
ISpace["UI_ApprovalHideRow"].Visible="false";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""228701A8-2089-4481-B018-4BE30083D0D9"")
{
ISpace[""UI_ApprovalHideRow""].Visible=""false"";
}");
}
if(ISpace["WF_FlowType"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""WF_FlowType""].Value=="""")");
ISpace["WMF_IsInFlow"].Value=0;
base.WriteDebugInfo(@"ISpace[""WMF_IsInFlow""].Value=0;");
base.WriteDebugInfo(@"EXEC [GetInstanceInFlow] '@@gv_InstanceId'");

var querySource28B5F25AB9D745C8AB83AB07D5048EAD =GetQueryExpressionDataSource("28B5F25A-B9D7-45C8-AB83-AB07D5048EAD");
Dictionary<short,object> result28B5F25AB9D745C8AB83AB07D5048EAD=iSpace.ExecuteQuery(querySource28B5F25AB9D745C8AB83AB07D5048EAD,@"EXEC [GetInstanceInFlow] '" + ISpace["gv_instanceid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource28B5F25AB9D745C8AB83AB07D5048EAD =GetQueryExpressionDataSource(""28B5F25A-B9D7-45C8-AB83-AB07D5048EAD"");Dictionary<short,object> result28B5F25AB9D745C8AB83AB07D5048EAD=iSpace.ExecuteQuery(querySource28B5F25AB9D745C8AB83AB07D5048EAD,@""EXEC [GetInstanceInFlow] '"" + ISpace[""gv_instanceid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result28B5F25AB9D745C8AB83AB07D5048EAD!=null) && (result28B5F25AB9D745C8AB83AB07D5048EAD.Count!=0))
{
if(result28B5F25AB9D745C8AB83AB07D5048EAD.ContainsKey(0))
ISpace["WMF_IsInFlow"].Value = result28B5F25AB9D745C8AB83AB07D5048EAD[0];
}
else{
ISpace["WMF_IsInFlow"].Value = null;
}
if(ISpace["WMF_IsInFlow"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""WMF_IsInFlow""].Value==1)");
ISpace["WF_FlowType"].Value="APPROVE";
base.WriteDebugInfo(@"ISpace[""WF_FlowType""].Value=""APPROVE"";");
ISpace["WMF_History"].Visible="true";ISpace["WMF_MoveTo"].Visible="true";
base.WriteDebugInfo(@"ISpace[""WMF_History""].Visible=""true"";ISpace[""WMF_MoveTo""].Visible=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["WMF_History"].Visible="false";ISpace["WMF_MoveTo"].Visible="false";
base.WriteDebugInfo(@"ISpace[""WMF_History""].Visible=""false"";ISpace[""WMF_MoveTo""].Visible=""false"";");
}
}
ISpace["WMF_MoveTo"].Man=true;
base.WriteDebugInfo(@"ISpace[""WMF_MoveTo""].Man=true;");
ISpace["WMF_MoveTo"].Value="";
base.WriteDebugInfo(@"ISpace[""WMF_MoveTo""].Value="""";");
ISpace["Comments"].Value="";
base.WriteDebugInfo(@"ISpace[""Comments""].Value="""";");

var querySource72ABBA101D3E4391BDBDEBBE0E2E0237 =GetQueryExpressionDataSource("72ABBA10-1D3E-4391-BDBD-EBBE0E2E0237");

DataTable result72ABBA101D3E4391BDBDEBBE0E2E0237=iSpace.SetGridDataSource(querySource72ABBA101D3E4391BDBDEBBE0E2E0237, _objectFactory.GetGridRPP("WMG_CommentsHistory"),@"EXEC [GetInstanceFlowDetais] '" + ISpace["gv_instanceid"].Value + @"'");

iSpace.InsertGridBindDetails("WMG_CommentsHistory","11",querySource72ABBA101D3E4391BDBDEBBE0E2E0237,"EXEC [GetInstanceFlowDetais] '" + ISpace["gv_instanceid"].Value + @"'",_objectFactory.GetGridRPP("WMG_CommentsHistory"));

base.WriteDebugInfo(@"var querySource72ABBA101D3E4391BDBDEBBE0E2E0237 =GetQueryExpressionDataSource(""72ABBA10-1D3E-4391-BDBD-EBBE0E2E0237"");DataTable result72ABBA101D3E4391BDBDEBBE0E2E0237=iSpace.SetGridDataSource(querySource72ABBA101D3E4391BDBDEBBE0E2E0237, _objectFactory.GetGridRPP(""WMG_CommentsHistory""),@""EXEC [GetInstanceFlowDetais] '"" + ISpace[""gv_instanceid""].Value + @""'"");iSpace.InsertGridBindDetails(""WMG_CommentsHistory"",""11"",querySource72ABBA101D3E4391BDBDEBBE0E2E0237,""EXEC [GetInstanceFlowDetais] '"" + ISpace[""gv_instanceid""].Value + @""'"",_objectFactory.GetGridRPP(""WMG_CommentsHistory""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result6DA5E7991709406E85D09DC6581E03C3=acdataIspace1D9F2FB872294AF1A535338A23491654.GetQueryExpressionBindings("6DA5E799-1709-406E-85D0-9DC6581E03C3");
iSpace.SetGridData(result72ABBA101D3E4391BDBDEBBE0E2E0237,result6DA5E7991709406E85D09DC6581E03C3,"WMG_CommentsHistory",ref ISpace);
iSpace.UpdateGridBindDetails("WMG_CommentsHistory",result6DA5E7991709406E85D09DC6581E03C3);
ISpace["MF_IsAdvance"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MF_IsAdvance""].Enbl=""false"";");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_wmf_history (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"WMF_History-OnClick");

var querySource72ABBA101D3E4391BDBDEBBE0E2E0237 =GetQueryExpressionDataSource("72ABBA10-1D3E-4391-BDBD-EBBE0E2E0237");

DataTable result72ABBA101D3E4391BDBDEBBE0E2E0237=iSpace.SetGridDataSource(querySource72ABBA101D3E4391BDBDEBBE0E2E0237, _objectFactory.GetGridRPP("WMG_CommentsHistory"),@"EXEC [GetInstanceFlowDetais] '" + ISpace["gv_instanceid"].Value + @"'");

iSpace.InsertGridBindDetails("WMG_CommentsHistory","11",querySource72ABBA101D3E4391BDBDEBBE0E2E0237,"EXEC [GetInstanceFlowDetais] '" + ISpace["gv_instanceid"].Value + @"'",_objectFactory.GetGridRPP("WMG_CommentsHistory"));

base.WriteDebugInfo(@"var querySource72ABBA101D3E4391BDBDEBBE0E2E0237 =GetQueryExpressionDataSource(""72ABBA10-1D3E-4391-BDBD-EBBE0E2E0237"");DataTable result72ABBA101D3E4391BDBDEBBE0E2E0237=iSpace.SetGridDataSource(querySource72ABBA101D3E4391BDBDEBBE0E2E0237, _objectFactory.GetGridRPP(""WMG_CommentsHistory""),@""EXEC [GetInstanceFlowDetais] '"" + ISpace[""gv_instanceid""].Value + @""'"");iSpace.InsertGridBindDetails(""WMG_CommentsHistory"",""11"",querySource72ABBA101D3E4391BDBDEBBE0E2E0237,""EXEC [GetInstanceFlowDetais] '"" + ISpace[""gv_instanceid""].Value + @""'"",_objectFactory.GetGridRPP(""WMG_CommentsHistory""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result6DA5E7991709406E85D09DC6581E03C3=acdataIspace1D9F2FB872294AF1A535338A23491654.GetQueryExpressionBindings("6DA5E799-1709-406E-85D0-9DC6581E03C3");
iSpace.SetGridData(result72ABBA101D3E4391BDBDEBBE0E2E0237,result6DA5E7991709406E85D09DC6581E03C3,"WMG_CommentsHistory",ref ISpace);
iSpace.UpdateGridBindDetails("WMG_CommentsHistory",result6DA5E7991709406E85D09DC6581E03C3);
ISpace["UI_History"].ShowDialog=true;;
base.WriteDebugInfo(@"ISpace[""UI_History""].ShowDialog=true;;");
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
if(ISpace["WF_FlowType"].Value=="APPROVE")
{
base.WriteDebugInfo(@"if(ISpace[""WF_FlowType""].Value==""APPROVE"")");
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
if(ISpace["WF_FlowType"].Value=="RETURN" || ISpace["WF_FlowType"].Value=="REJECT")
{
base.WriteDebugInfo(@"if(ISpace[""WF_FlowType""].Value==""RETURN"" || ISpace[""WF_FlowType""].Value==""REJECT"")");
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
ISpace["Message"].Value=@"Success: Submitted Successfully";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Success: Submitted Successfully"";");

ISpace["RedirectUrl"].RedirectType="R";
ISpace["RedirectUrl"].Value="/Inbox";
base.WriteDebugInfo(@"
ISpace[""RedirectUrl""].RedirectType=""R"";
ISpace[""RedirectUrl""].Value=""/Inbox"";");
if(ISpace["WF_FlowType"].Value=="REJECT"||ISpace["WF_FlowType"].Value=="RETURN")
{
base.WriteDebugInfo(@"if(ISpace[""WF_FlowType""].Value==""REJECT""||ISpace[""WF_FlowType""].Value==""RETURN"")");
base.WriteDebugInfo(@"EXEC [UpdateTemporaryAdvanceStatus] '@@gv_InstanceId','#WF_FlowType','@@gv_UserId'");

var querySource4fc913b439b349cfb675a463ca4816fc =GetQueryExpressionDataSource("4fc913b4-39b3-49cf-b675-a463ca4816fc");
Dictionary<short,object> result4fc913b439b349cfb675a463ca4816fc=iSpace.ExecuteQuery(querySource4fc913b439b349cfb675a463ca4816fc,@"EXEC [UpdateTemporaryAdvanceStatus] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["WF_FlowType"].Value + @"','" + ISpace["gv_userid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource4fc913b439b349cfb675a463ca4816fc =GetQueryExpressionDataSource(""4fc913b4-39b3-49cf-b675-a463ca4816fc"");Dictionary<short,object> result4fc913b439b349cfb675a463ca4816fc=iSpace.ExecuteQuery(querySource4fc913b439b349cfb675a463ca4816fc,@""EXEC [UpdateTemporaryAdvanceStatus] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""WF_FlowType""].Value + @""','"" + ISpace[""gv_userid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result4fc913b439b349cfb675a463ca4816fc!=null) && (result4fc913b439b349cfb675a463ca4816fc.Count!=0))
{
if(result4fc913b439b349cfb675a463ca4816fc.ContainsKey(0))
ISpace["MF_ErrId"].Value = result4fc913b439b349cfb675a463ca4816fc[0];
}
else{
ISpace["MF_ErrId"].Value = null;
}
}
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
ISpace["WF_FlowType"].Value="APPROVE";
base.WriteDebugInfo(@"ISpace[""WF_FlowType""].Value=""APPROVE"";");
ISpace["Comments"].Man=false;
base.WriteDebugInfo(@"ISpace[""Comments""].Man=false;");
}
if(ISpace["WMF_MoveTo"].Value=="RETURN")
{
base.WriteDebugInfo(@"if(ISpace[""WMF_MoveTo""].Value==""RETURN"")");
ISpace["WF_FlowType"].Value="RETURN";
base.WriteDebugInfo(@"ISpace[""WF_FlowType""].Value=""RETURN"";");
ISpace["Comments"].Man=true;
base.WriteDebugInfo(@"ISpace[""Comments""].Man=true;");
}
if(ISpace["WMF_MoveTo"].Value=="REJECT")
{
base.WriteDebugInfo(@"if(ISpace[""WMF_MoveTo""].Value==""REJECT"")");
ISpace["WF_FlowType"].Value="REJECT";
base.WriteDebugInfo(@"ISpace[""WF_FlowType""].Value=""REJECT"";");
ISpace["Comments"].Man=true;
base.WriteDebugInfo(@"ISpace[""Comments""].Man=true;");
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
		if(elementName.ToLower().Equals("wmf_moveto"))
    {
    			SubscribeElementEvents_wmf_moveto(ref dfsParam);
    }
}
	if(methodName.ToLower().Equals("onclick"))
{
		if(elementName.ToLower().Equals("wmf_history"))
{
			SubscribeElementEvents_wmf_history(ref dfsParam);
}
		if(elementName.ToLower().Equals("submitform"))
{
			SubscribeElementEvents_submitform(ref dfsParam);
}
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
public class ISpaceB4D82C893C764D0AAE787B32FD572B8F : VirtualForm
{
IISpace iSpace = new ISpace();
AcDataISpaceB4D82C893C764D0AAE787B32FD572B8F acdataIspaceB4D82C893C764D0AAE787B32FD572B8F=new AcDataISpaceB4D82C893C764D0AAE787B32FD572B8F();
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
if(ISpace["FormVersionId"].Value=="228701A8-2089-4481-B018-4BE30083D0D9")
{
ISpace["UI_ApprovalHideRow"].Visible="false";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""228701A8-2089-4481-B018-4BE30083D0D9"")
{
ISpace[""UI_ApprovalHideRow""].Visible=""false"";
}");
}
if(ISpace["WF_FlowType"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""WF_FlowType""].Value=="""")");
ISpace["WMF_IsInFlow"].Value=0;
base.WriteDebugInfo(@"ISpace[""WMF_IsInFlow""].Value=0;");
base.WriteDebugInfo(@"EXEC [GetInstanceInFlow] '@@gv_InstanceId'");

var querySource28B5F25AB9D745C8AB83AB07D5048EAD =GetQueryExpressionDataSource("28B5F25A-B9D7-45C8-AB83-AB07D5048EAD");
Dictionary<short,object> result28B5F25AB9D745C8AB83AB07D5048EAD=iSpace.ExecuteQuery(querySource28B5F25AB9D745C8AB83AB07D5048EAD,@"EXEC [GetInstanceInFlow] '" + ISpace["gv_instanceid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource28B5F25AB9D745C8AB83AB07D5048EAD =GetQueryExpressionDataSource(""28B5F25A-B9D7-45C8-AB83-AB07D5048EAD"");Dictionary<short,object> result28B5F25AB9D745C8AB83AB07D5048EAD=iSpace.ExecuteQuery(querySource28B5F25AB9D745C8AB83AB07D5048EAD,@""EXEC [GetInstanceInFlow] '"" + ISpace[""gv_instanceid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result28B5F25AB9D745C8AB83AB07D5048EAD!=null) && (result28B5F25AB9D745C8AB83AB07D5048EAD.Count!=0))
{
if(result28B5F25AB9D745C8AB83AB07D5048EAD.ContainsKey(0))
ISpace["WMF_IsInFlow"].Value = result28B5F25AB9D745C8AB83AB07D5048EAD[0];
}
else{
ISpace["WMF_IsInFlow"].Value = null;
}
if(ISpace["WMF_IsInFlow"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""WMF_IsInFlow""].Value==1)");
ISpace["WF_FlowType"].Value="APPROVE";
base.WriteDebugInfo(@"ISpace[""WF_FlowType""].Value=""APPROVE"";");
ISpace["WMF_History"].Visible="true";ISpace["WMF_MoveTo"].Visible="true";
base.WriteDebugInfo(@"ISpace[""WMF_History""].Visible=""true"";ISpace[""WMF_MoveTo""].Visible=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["WMF_History"].Visible="false";ISpace["WMF_MoveTo"].Visible="false";
base.WriteDebugInfo(@"ISpace[""WMF_History""].Visible=""false"";ISpace[""WMF_MoveTo""].Visible=""false"";");
}
}
ISpace["WMF_MoveTo"].Man=true;
base.WriteDebugInfo(@"ISpace[""WMF_MoveTo""].Man=true;");
ISpace["WMF_MoveTo"].Value="";
base.WriteDebugInfo(@"ISpace[""WMF_MoveTo""].Value="""";");
ISpace["Comments"].Value="";
base.WriteDebugInfo(@"ISpace[""Comments""].Value="""";");

var querySource72ABBA101D3E4391BDBDEBBE0E2E0237 =GetQueryExpressionDataSource("72ABBA10-1D3E-4391-BDBD-EBBE0E2E0237");

DataTable result72ABBA101D3E4391BDBDEBBE0E2E0237=iSpace.SetGridDataSource(querySource72ABBA101D3E4391BDBDEBBE0E2E0237, _objectFactory.GetGridRPP("WMG_CommentsHistory"),@"EXEC [GetInstanceFlowDetais] '" + ISpace["gv_instanceid"].Value + @"'");

iSpace.InsertGridBindDetails("WMG_CommentsHistory","11",querySource72ABBA101D3E4391BDBDEBBE0E2E0237,"EXEC [GetInstanceFlowDetais] '" + ISpace["gv_instanceid"].Value + @"'",_objectFactory.GetGridRPP("WMG_CommentsHistory"));

base.WriteDebugInfo(@"var querySource72ABBA101D3E4391BDBDEBBE0E2E0237 =GetQueryExpressionDataSource(""72ABBA10-1D3E-4391-BDBD-EBBE0E2E0237"");DataTable result72ABBA101D3E4391BDBDEBBE0E2E0237=iSpace.SetGridDataSource(querySource72ABBA101D3E4391BDBDEBBE0E2E0237, _objectFactory.GetGridRPP(""WMG_CommentsHistory""),@""EXEC [GetInstanceFlowDetais] '"" + ISpace[""gv_instanceid""].Value + @""'"");iSpace.InsertGridBindDetails(""WMG_CommentsHistory"",""11"",querySource72ABBA101D3E4391BDBDEBBE0E2E0237,""EXEC [GetInstanceFlowDetais] '"" + ISpace[""gv_instanceid""].Value + @""'"",_objectFactory.GetGridRPP(""WMG_CommentsHistory""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result6DA5E7991709406E85D09DC6581E03C3=acdataIspaceB4D82C893C764D0AAE787B32FD572B8F.GetQueryExpressionBindings("6DA5E799-1709-406E-85D0-9DC6581E03C3");
iSpace.SetGridData(result72ABBA101D3E4391BDBDEBBE0E2E0237,result6DA5E7991709406E85D09DC6581E03C3,"WMG_CommentsHistory",ref ISpace);
iSpace.UpdateGridBindDetails("WMG_CommentsHistory",result6DA5E7991709406E85D09DC6581E03C3);
ISpace["MF_IsAdvance"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MF_IsAdvance""].Enbl=""false"";");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_wmf_history (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"WMF_History-OnClick");

var querySource72ABBA101D3E4391BDBDEBBE0E2E0237 =GetQueryExpressionDataSource("72ABBA10-1D3E-4391-BDBD-EBBE0E2E0237");

DataTable result72ABBA101D3E4391BDBDEBBE0E2E0237=iSpace.SetGridDataSource(querySource72ABBA101D3E4391BDBDEBBE0E2E0237, _objectFactory.GetGridRPP("WMG_CommentsHistory"),@"EXEC [GetInstanceFlowDetais] '" + ISpace["gv_instanceid"].Value + @"'");

iSpace.InsertGridBindDetails("WMG_CommentsHistory","11",querySource72ABBA101D3E4391BDBDEBBE0E2E0237,"EXEC [GetInstanceFlowDetais] '" + ISpace["gv_instanceid"].Value + @"'",_objectFactory.GetGridRPP("WMG_CommentsHistory"));

base.WriteDebugInfo(@"var querySource72ABBA101D3E4391BDBDEBBE0E2E0237 =GetQueryExpressionDataSource(""72ABBA10-1D3E-4391-BDBD-EBBE0E2E0237"");DataTable result72ABBA101D3E4391BDBDEBBE0E2E0237=iSpace.SetGridDataSource(querySource72ABBA101D3E4391BDBDEBBE0E2E0237, _objectFactory.GetGridRPP(""WMG_CommentsHistory""),@""EXEC [GetInstanceFlowDetais] '"" + ISpace[""gv_instanceid""].Value + @""'"");iSpace.InsertGridBindDetails(""WMG_CommentsHistory"",""11"",querySource72ABBA101D3E4391BDBDEBBE0E2E0237,""EXEC [GetInstanceFlowDetais] '"" + ISpace[""gv_instanceid""].Value + @""'"",_objectFactory.GetGridRPP(""WMG_CommentsHistory""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result6DA5E7991709406E85D09DC6581E03C3=acdataIspaceB4D82C893C764D0AAE787B32FD572B8F.GetQueryExpressionBindings("6DA5E799-1709-406E-85D0-9DC6581E03C3");
iSpace.SetGridData(result72ABBA101D3E4391BDBDEBBE0E2E0237,result6DA5E7991709406E85D09DC6581E03C3,"WMG_CommentsHistory",ref ISpace);
iSpace.UpdateGridBindDetails("WMG_CommentsHistory",result6DA5E7991709406E85D09DC6581E03C3);
ISpace["UI_History"].ShowDialog=true;;
base.WriteDebugInfo(@"ISpace[""UI_History""].ShowDialog=true;;");
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
if(ISpace["WF_FlowType"].Value=="APPROVE")
{
base.WriteDebugInfo(@"if(ISpace[""WF_FlowType""].Value==""APPROVE"")");
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
if(ISpace["WF_FlowType"].Value=="RETURN" || ISpace["WF_FlowType"].Value=="REJECT")
{
base.WriteDebugInfo(@"if(ISpace[""WF_FlowType""].Value==""RETURN"" || ISpace[""WF_FlowType""].Value==""REJECT"")");
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
ISpace["Message"].Value=@"Success: Submitted Successfully";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Success: Submitted Successfully"";");

ISpace["RedirectUrl"].RedirectType="R";
ISpace["RedirectUrl"].Value="/Inbox";
base.WriteDebugInfo(@"
ISpace[""RedirectUrl""].RedirectType=""R"";
ISpace[""RedirectUrl""].Value=""/Inbox"";");
if(ISpace["WF_FlowType"].Value=="REJECT"||ISpace["WF_FlowType"].Value=="RETURN")
{
base.WriteDebugInfo(@"if(ISpace[""WF_FlowType""].Value==""REJECT""||ISpace[""WF_FlowType""].Value==""RETURN"")");
base.WriteDebugInfo(@"EXEC [UpdateTemporaryAdvanceStatus] '@@gv_InstanceId','#WF_FlowType','@@gv_UserId'");

var querySource4fc913b439b349cfb675a463ca4816fc =GetQueryExpressionDataSource("4fc913b4-39b3-49cf-b675-a463ca4816fc");
Dictionary<short,object> result4fc913b439b349cfb675a463ca4816fc=iSpace.ExecuteQuery(querySource4fc913b439b349cfb675a463ca4816fc,@"EXEC [UpdateTemporaryAdvanceStatus] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["WF_FlowType"].Value + @"','" + ISpace["gv_userid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource4fc913b439b349cfb675a463ca4816fc =GetQueryExpressionDataSource(""4fc913b4-39b3-49cf-b675-a463ca4816fc"");Dictionary<short,object> result4fc913b439b349cfb675a463ca4816fc=iSpace.ExecuteQuery(querySource4fc913b439b349cfb675a463ca4816fc,@""EXEC [UpdateTemporaryAdvanceStatus] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""WF_FlowType""].Value + @""','"" + ISpace[""gv_userid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result4fc913b439b349cfb675a463ca4816fc!=null) && (result4fc913b439b349cfb675a463ca4816fc.Count!=0))
{
if(result4fc913b439b349cfb675a463ca4816fc.ContainsKey(0))
ISpace["MF_ErrId"].Value = result4fc913b439b349cfb675a463ca4816fc[0];
}
else{
ISpace["MF_ErrId"].Value = null;
}
}
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
ISpace["WF_FlowType"].Value="APPROVE";
base.WriteDebugInfo(@"ISpace[""WF_FlowType""].Value=""APPROVE"";");
ISpace["Comments"].Man=false;
base.WriteDebugInfo(@"ISpace[""Comments""].Man=false;");
}
if(ISpace["WMF_MoveTo"].Value=="RETURN")
{
base.WriteDebugInfo(@"if(ISpace[""WMF_MoveTo""].Value==""RETURN"")");
ISpace["WF_FlowType"].Value="RETURN";
base.WriteDebugInfo(@"ISpace[""WF_FlowType""].Value=""RETURN"";");
ISpace["Comments"].Man=true;
base.WriteDebugInfo(@"ISpace[""Comments""].Man=true;");
}
if(ISpace["WMF_MoveTo"].Value=="REJECT")
{
base.WriteDebugInfo(@"if(ISpace[""WMF_MoveTo""].Value==""REJECT"")");
ISpace["WF_FlowType"].Value="REJECT";
base.WriteDebugInfo(@"ISpace[""WF_FlowType""].Value=""REJECT"";");
ISpace["Comments"].Man=true;
base.WriteDebugInfo(@"ISpace[""Comments""].Man=true;");
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
		if(elementName.ToLower().Equals("wmf_moveto"))
    {
    			SubscribeElementEvents_wmf_moveto(ref dfsParam);
    }
}
	if(methodName.ToLower().Equals("onclick"))
{
		if(elementName.ToLower().Equals("wmf_history"))
{
			SubscribeElementEvents_wmf_history(ref dfsParam);
}
		if(elementName.ToLower().Equals("submitform"))
{
			SubscribeElementEvents_submitform(ref dfsParam);
}
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
public class ISpace560A61B0D0D94566B1E94190F008BC9E : VirtualForm
{
IISpace iSpace = new ISpace();
AcDataISpace560A61B0D0D94566B1E94190F008BC9E acdataIspace560A61B0D0D94566B1E94190F008BC9E=new AcDataISpace560A61B0D0D94566B1E94190F008BC9E();
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
if(ISpace["FormVersionId"].Value=="228701A8-2089-4481-B018-4BE30083D0D9")
{
ISpace["UI_ApprovalHideRow"].Visible="false";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""228701A8-2089-4481-B018-4BE30083D0D9"")
{
ISpace[""UI_ApprovalHideRow""].Visible=""false"";
}");
}
if(ISpace["WF_FlowType"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""WF_FlowType""].Value=="""")");
ISpace["WMF_IsInFlow"].Value=0;
base.WriteDebugInfo(@"ISpace[""WMF_IsInFlow""].Value=0;");
base.WriteDebugInfo(@"EXEC [GetInstanceInFlow] '@@gv_InstanceId'");

var querySource28B5F25AB9D745C8AB83AB07D5048EAD =GetQueryExpressionDataSource("28B5F25A-B9D7-45C8-AB83-AB07D5048EAD");
Dictionary<short,object> result28B5F25AB9D745C8AB83AB07D5048EAD=iSpace.ExecuteQuery(querySource28B5F25AB9D745C8AB83AB07D5048EAD,@"EXEC [GetInstanceInFlow] '" + ISpace["gv_instanceid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource28B5F25AB9D745C8AB83AB07D5048EAD =GetQueryExpressionDataSource(""28B5F25A-B9D7-45C8-AB83-AB07D5048EAD"");Dictionary<short,object> result28B5F25AB9D745C8AB83AB07D5048EAD=iSpace.ExecuteQuery(querySource28B5F25AB9D745C8AB83AB07D5048EAD,@""EXEC [GetInstanceInFlow] '"" + ISpace[""gv_instanceid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result28B5F25AB9D745C8AB83AB07D5048EAD!=null) && (result28B5F25AB9D745C8AB83AB07D5048EAD.Count!=0))
{
if(result28B5F25AB9D745C8AB83AB07D5048EAD.ContainsKey(0))
ISpace["WMF_IsInFlow"].Value = result28B5F25AB9D745C8AB83AB07D5048EAD[0];
}
else{
ISpace["WMF_IsInFlow"].Value = null;
}
if(ISpace["WMF_IsInFlow"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""WMF_IsInFlow""].Value==1)");
ISpace["WF_FlowType"].Value="APPROVE";
base.WriteDebugInfo(@"ISpace[""WF_FlowType""].Value=""APPROVE"";");
ISpace["WMF_History"].Visible="true";ISpace["WMF_MoveTo"].Visible="true";
base.WriteDebugInfo(@"ISpace[""WMF_History""].Visible=""true"";ISpace[""WMF_MoveTo""].Visible=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["WMF_History"].Visible="false";ISpace["WMF_MoveTo"].Visible="false";
base.WriteDebugInfo(@"ISpace[""WMF_History""].Visible=""false"";ISpace[""WMF_MoveTo""].Visible=""false"";");
}
}
ISpace["WMF_MoveTo"].Man=true;
base.WriteDebugInfo(@"ISpace[""WMF_MoveTo""].Man=true;");
ISpace["WMF_MoveTo"].Value="";
base.WriteDebugInfo(@"ISpace[""WMF_MoveTo""].Value="""";");
ISpace["Comments"].Value="";
base.WriteDebugInfo(@"ISpace[""Comments""].Value="""";");

var querySource72ABBA101D3E4391BDBDEBBE0E2E0237 =GetQueryExpressionDataSource("72ABBA10-1D3E-4391-BDBD-EBBE0E2E0237");

DataTable result72ABBA101D3E4391BDBDEBBE0E2E0237=iSpace.SetGridDataSource(querySource72ABBA101D3E4391BDBDEBBE0E2E0237, _objectFactory.GetGridRPP("WMG_CommentsHistory"),@"EXEC [GetInstanceFlowDetais] '" + ISpace["gv_instanceid"].Value + @"'");

iSpace.InsertGridBindDetails("WMG_CommentsHistory","11",querySource72ABBA101D3E4391BDBDEBBE0E2E0237,"EXEC [GetInstanceFlowDetais] '" + ISpace["gv_instanceid"].Value + @"'",_objectFactory.GetGridRPP("WMG_CommentsHistory"));

base.WriteDebugInfo(@"var querySource72ABBA101D3E4391BDBDEBBE0E2E0237 =GetQueryExpressionDataSource(""72ABBA10-1D3E-4391-BDBD-EBBE0E2E0237"");DataTable result72ABBA101D3E4391BDBDEBBE0E2E0237=iSpace.SetGridDataSource(querySource72ABBA101D3E4391BDBDEBBE0E2E0237, _objectFactory.GetGridRPP(""WMG_CommentsHistory""),@""EXEC [GetInstanceFlowDetais] '"" + ISpace[""gv_instanceid""].Value + @""'"");iSpace.InsertGridBindDetails(""WMG_CommentsHistory"",""11"",querySource72ABBA101D3E4391BDBDEBBE0E2E0237,""EXEC [GetInstanceFlowDetais] '"" + ISpace[""gv_instanceid""].Value + @""'"",_objectFactory.GetGridRPP(""WMG_CommentsHistory""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result6DA5E7991709406E85D09DC6581E03C3=acdataIspace560A61B0D0D94566B1E94190F008BC9E.GetQueryExpressionBindings("6DA5E799-1709-406E-85D0-9DC6581E03C3");
iSpace.SetGridData(result72ABBA101D3E4391BDBDEBBE0E2E0237,result6DA5E7991709406E85D09DC6581E03C3,"WMG_CommentsHistory",ref ISpace);
iSpace.UpdateGridBindDetails("WMG_CommentsHistory",result6DA5E7991709406E85D09DC6581E03C3);
ISpace["MF_IsAdvance"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MF_IsAdvance""].Enbl=""false"";");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_wmf_history (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"WMF_History-OnClick");

var querySource72ABBA101D3E4391BDBDEBBE0E2E0237 =GetQueryExpressionDataSource("72ABBA10-1D3E-4391-BDBD-EBBE0E2E0237");

DataTable result72ABBA101D3E4391BDBDEBBE0E2E0237=iSpace.SetGridDataSource(querySource72ABBA101D3E4391BDBDEBBE0E2E0237, _objectFactory.GetGridRPP("WMG_CommentsHistory"),@"EXEC [GetInstanceFlowDetais] '" + ISpace["gv_instanceid"].Value + @"'");

iSpace.InsertGridBindDetails("WMG_CommentsHistory","11",querySource72ABBA101D3E4391BDBDEBBE0E2E0237,"EXEC [GetInstanceFlowDetais] '" + ISpace["gv_instanceid"].Value + @"'",_objectFactory.GetGridRPP("WMG_CommentsHistory"));

base.WriteDebugInfo(@"var querySource72ABBA101D3E4391BDBDEBBE0E2E0237 =GetQueryExpressionDataSource(""72ABBA10-1D3E-4391-BDBD-EBBE0E2E0237"");DataTable result72ABBA101D3E4391BDBDEBBE0E2E0237=iSpace.SetGridDataSource(querySource72ABBA101D3E4391BDBDEBBE0E2E0237, _objectFactory.GetGridRPP(""WMG_CommentsHistory""),@""EXEC [GetInstanceFlowDetais] '"" + ISpace[""gv_instanceid""].Value + @""'"");iSpace.InsertGridBindDetails(""WMG_CommentsHistory"",""11"",querySource72ABBA101D3E4391BDBDEBBE0E2E0237,""EXEC [GetInstanceFlowDetais] '"" + ISpace[""gv_instanceid""].Value + @""'"",_objectFactory.GetGridRPP(""WMG_CommentsHistory""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result6DA5E7991709406E85D09DC6581E03C3=acdataIspace560A61B0D0D94566B1E94190F008BC9E.GetQueryExpressionBindings("6DA5E799-1709-406E-85D0-9DC6581E03C3");
iSpace.SetGridData(result72ABBA101D3E4391BDBDEBBE0E2E0237,result6DA5E7991709406E85D09DC6581E03C3,"WMG_CommentsHistory",ref ISpace);
iSpace.UpdateGridBindDetails("WMG_CommentsHistory",result6DA5E7991709406E85D09DC6581E03C3);
ISpace["UI_History"].ShowDialog=true;;
base.WriteDebugInfo(@"ISpace[""UI_History""].ShowDialog=true;;");
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
if(ISpace["WF_FlowType"].Value=="APPROVE")
{
base.WriteDebugInfo(@"if(ISpace[""WF_FlowType""].Value==""APPROVE"")");
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
if(ISpace["WF_FlowType"].Value=="RETURN" || ISpace["WF_FlowType"].Value=="REJECT")
{
base.WriteDebugInfo(@"if(ISpace[""WF_FlowType""].Value==""RETURN"" || ISpace[""WF_FlowType""].Value==""REJECT"")");
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
ISpace["Message"].Value=@"Success: Submitted Successfully";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Success: Submitted Successfully"";");

ISpace["RedirectUrl"].RedirectType="R";
ISpace["RedirectUrl"].Value="/Inbox";
base.WriteDebugInfo(@"
ISpace[""RedirectUrl""].RedirectType=""R"";
ISpace[""RedirectUrl""].Value=""/Inbox"";");
if(ISpace["WF_FlowType"].Value=="REJECT"||ISpace["WF_FlowType"].Value=="RETURN")
{
base.WriteDebugInfo(@"if(ISpace[""WF_FlowType""].Value==""REJECT""||ISpace[""WF_FlowType""].Value==""RETURN"")");
base.WriteDebugInfo(@"EXEC [UpdateTemporaryAdvanceStatus] '@@gv_InstanceId','#WF_FlowType','@@gv_UserId'");

var querySource4fc913b439b349cfb675a463ca4816fc =GetQueryExpressionDataSource("4fc913b4-39b3-49cf-b675-a463ca4816fc");
Dictionary<short,object> result4fc913b439b349cfb675a463ca4816fc=iSpace.ExecuteQuery(querySource4fc913b439b349cfb675a463ca4816fc,@"EXEC [UpdateTemporaryAdvanceStatus] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["WF_FlowType"].Value + @"','" + ISpace["gv_userid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource4fc913b439b349cfb675a463ca4816fc =GetQueryExpressionDataSource(""4fc913b4-39b3-49cf-b675-a463ca4816fc"");Dictionary<short,object> result4fc913b439b349cfb675a463ca4816fc=iSpace.ExecuteQuery(querySource4fc913b439b349cfb675a463ca4816fc,@""EXEC [UpdateTemporaryAdvanceStatus] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""WF_FlowType""].Value + @""','"" + ISpace[""gv_userid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result4fc913b439b349cfb675a463ca4816fc!=null) && (result4fc913b439b349cfb675a463ca4816fc.Count!=0))
{
if(result4fc913b439b349cfb675a463ca4816fc.ContainsKey(0))
ISpace["MF_ErrId"].Value = result4fc913b439b349cfb675a463ca4816fc[0];
}
else{
ISpace["MF_ErrId"].Value = null;
}
}
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
ISpace["WF_FlowType"].Value="APPROVE";
base.WriteDebugInfo(@"ISpace[""WF_FlowType""].Value=""APPROVE"";");
ISpace["Comments"].Man=false;
base.WriteDebugInfo(@"ISpace[""Comments""].Man=false;");
}
if(ISpace["WMF_MoveTo"].Value=="RETURN")
{
base.WriteDebugInfo(@"if(ISpace[""WMF_MoveTo""].Value==""RETURN"")");
ISpace["WF_FlowType"].Value="RETURN";
base.WriteDebugInfo(@"ISpace[""WF_FlowType""].Value=""RETURN"";");
ISpace["Comments"].Man=true;
base.WriteDebugInfo(@"ISpace[""Comments""].Man=true;");
}
if(ISpace["WMF_MoveTo"].Value=="REJECT")
{
base.WriteDebugInfo(@"if(ISpace[""WMF_MoveTo""].Value==""REJECT"")");
ISpace["WF_FlowType"].Value="REJECT";
base.WriteDebugInfo(@"ISpace[""WF_FlowType""].Value=""REJECT"";");
ISpace["Comments"].Man=true;
base.WriteDebugInfo(@"ISpace[""Comments""].Man=true;");
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
		if(elementName.ToLower().Equals("wmf_moveto"))
    {
    			SubscribeElementEvents_wmf_moveto(ref dfsParam);
    }
}
	if(methodName.ToLower().Equals("onclick"))
{
		if(elementName.ToLower().Equals("wmf_history"))
{
			SubscribeElementEvents_wmf_history(ref dfsParam);
}
		if(elementName.ToLower().Equals("submitform"))
{
			SubscribeElementEvents_submitform(ref dfsParam);
}
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
public class ISpace9e2f92013447796498b2a3bb336da186 : VirtualForm
{
IISpace iSpace = new ISpace();
AcDataISpace9e2f92013447796498b2a3bb336da186 acdataIspace9e2f92013447796498b2a3bb336da186=new AcDataISpace9e2f92013447796498b2a3bb336da186();
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
if(ISpace["FormVersionId"].Value=="228701A8-2089-4481-B018-4BE30083D0D9")
{
ISpace["UI_ApprovalHideRow"].Visible="false";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""228701A8-2089-4481-B018-4BE30083D0D9"")
{
ISpace[""UI_ApprovalHideRow""].Visible=""false"";
}");
}
if(ISpace["WF_FlowType"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""WF_FlowType""].Value=="""")");
ISpace["WMF_IsInFlow"].Value=0;
base.WriteDebugInfo(@"ISpace[""WMF_IsInFlow""].Value=0;");
base.WriteDebugInfo(@"EXEC [GetInstanceInFlow] '@@gv_InstanceId'");

var querySource28B5F25AB9D745C8AB83AB07D5048EAD =GetQueryExpressionDataSource("28B5F25A-B9D7-45C8-AB83-AB07D5048EAD");
Dictionary<short,object> result28B5F25AB9D745C8AB83AB07D5048EAD=iSpace.ExecuteQuery(querySource28B5F25AB9D745C8AB83AB07D5048EAD,@"EXEC [GetInstanceInFlow] '" + ISpace["gv_instanceid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource28B5F25AB9D745C8AB83AB07D5048EAD =GetQueryExpressionDataSource(""28B5F25A-B9D7-45C8-AB83-AB07D5048EAD"");Dictionary<short,object> result28B5F25AB9D745C8AB83AB07D5048EAD=iSpace.ExecuteQuery(querySource28B5F25AB9D745C8AB83AB07D5048EAD,@""EXEC [GetInstanceInFlow] '"" + ISpace[""gv_instanceid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result28B5F25AB9D745C8AB83AB07D5048EAD!=null) && (result28B5F25AB9D745C8AB83AB07D5048EAD.Count!=0))
{
if(result28B5F25AB9D745C8AB83AB07D5048EAD.ContainsKey(0))
ISpace["WMF_IsInFlow"].Value = result28B5F25AB9D745C8AB83AB07D5048EAD[0];
}
else{
ISpace["WMF_IsInFlow"].Value = null;
}
if(ISpace["WMF_IsInFlow"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""WMF_IsInFlow""].Value==1)");
ISpace["WF_FlowType"].Value="APPROVE";
base.WriteDebugInfo(@"ISpace[""WF_FlowType""].Value=""APPROVE"";");
ISpace["WMF_History"].Visible="true";ISpace["WMF_MoveTo"].Visible="true";
base.WriteDebugInfo(@"ISpace[""WMF_History""].Visible=""true"";ISpace[""WMF_MoveTo""].Visible=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["WMF_History"].Visible="false";ISpace["WMF_MoveTo"].Visible="false";
base.WriteDebugInfo(@"ISpace[""WMF_History""].Visible=""false"";ISpace[""WMF_MoveTo""].Visible=""false"";");
}
}
ISpace["WMF_MoveTo"].Man=true;
base.WriteDebugInfo(@"ISpace[""WMF_MoveTo""].Man=true;");
ISpace["WMF_MoveTo"].Value="";
base.WriteDebugInfo(@"ISpace[""WMF_MoveTo""].Value="""";");
ISpace["Comments"].Value="";
base.WriteDebugInfo(@"ISpace[""Comments""].Value="""";");
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

var querySource72ABBA101D3E4391BDBDEBBE0E2E0237 =GetQueryExpressionDataSource("72ABBA10-1D3E-4391-BDBD-EBBE0E2E0237");

DataTable result72ABBA101D3E4391BDBDEBBE0E2E0237=iSpace.SetGridDataSource(querySource72ABBA101D3E4391BDBDEBBE0E2E0237, _objectFactory.GetGridRPP("WMG_CommentsHistory"),@"EXEC [GetInstanceFlowDetais] '" + ISpace["gv_instanceid"].Value + @"'");

iSpace.InsertGridBindDetails("WMG_CommentsHistory","11",querySource72ABBA101D3E4391BDBDEBBE0E2E0237,"EXEC [GetInstanceFlowDetais] '" + ISpace["gv_instanceid"].Value + @"'",_objectFactory.GetGridRPP("WMG_CommentsHistory"));

base.WriteDebugInfo(@"var querySource72ABBA101D3E4391BDBDEBBE0E2E0237 =GetQueryExpressionDataSource(""72ABBA10-1D3E-4391-BDBD-EBBE0E2E0237"");DataTable result72ABBA101D3E4391BDBDEBBE0E2E0237=iSpace.SetGridDataSource(querySource72ABBA101D3E4391BDBDEBBE0E2E0237, _objectFactory.GetGridRPP(""WMG_CommentsHistory""),@""EXEC [GetInstanceFlowDetais] '"" + ISpace[""gv_instanceid""].Value + @""'"");iSpace.InsertGridBindDetails(""WMG_CommentsHistory"",""11"",querySource72ABBA101D3E4391BDBDEBBE0E2E0237,""EXEC [GetInstanceFlowDetais] '"" + ISpace[""gv_instanceid""].Value + @""'"",_objectFactory.GetGridRPP(""WMG_CommentsHistory""));");
ISpace["PFMF_PackageProcessMapId"].Value=ISpace["gv_processmapid"].Value;
base.WriteDebugInfo(@"ISpace[""PFMF_PackageProcessMapId""].Value=ISpace[""gv_processmapid""].Value;");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result6DA5E7991709406E85D09DC6581E03C3=acdataIspace9e2f92013447796498b2a3bb336da186.GetQueryExpressionBindings("6DA5E799-1709-406E-85D0-9DC6581E03C3");
iSpace.SetGridData(result72ABBA101D3E4391BDBDEBBE0E2E0237,result6DA5E7991709406E85D09DC6581E03C3,"WMG_CommentsHistory",ref ISpace);
iSpace.UpdateGridBindDetails("WMG_CommentsHistory",result6DA5E7991709406E85D09DC6581E03C3);
ISpace["PFMF_UserId"].Value=ISpace["gv_userid"].Value;
base.WriteDebugInfo(@"ISpace[""PFMF_UserId""].Value=ISpace[""gv_userid""].Value;");
if(ISpace["MF_d2_AdvanceFormId"].Value!="0")
{
base.WriteDebugInfo(@"if(ISpace[""MF_d2_AdvanceFormId""].Value!=""0"")");
base.WriteDebugInfo(@"EXEC InnovaceNoCode..[FormLoadById_744F780C-12D2-41D3-9084-6E903A527934]  '#MF_d2_AdvanceFormId'");

var querySource7BF46FF1D8244E8D9C425614C20F2357 =GetQueryExpressionDataSource("7BF46FF1-D824-4E8D-9C42-5614C20F2357");
Dictionary<short,object> result7BF46FF1D8244E8D9C425614C20F2357=iSpace.ExecuteQuery(querySource7BF46FF1D8244E8D9C425614C20F2357,@"EXEC InnovaceNoCode..[FormLoadById_744F780C-12D2-41D3-9084-6E903A527934]  '" + ISpace["MF_d2_AdvanceFormId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource7BF46FF1D8244E8D9C425614C20F2357 =GetQueryExpressionDataSource(""7BF46FF1-D824-4E8D-9C42-5614C20F2357"");Dictionary<short,object> result7BF46FF1D8244E8D9C425614C20F2357=iSpace.ExecuteQuery(querySource7BF46FF1D8244E8D9C425614C20F2357,@""EXEC InnovaceNoCode..[FormLoadById_744F780C-12D2-41D3-9084-6E903A527934]  '"" + ISpace[""MF_d2_AdvanceFormId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result7BF46FF1D8244E8D9C425614C20F2357!=null) && (result7BF46FF1D8244E8D9C425614C20F2357.Count!=0))
{
if(result7BF46FF1D8244E8D9C425614C20F2357.ContainsKey(7))
ISpace["MF_d2_UpdatedOn"].Value = result7BF46FF1D8244E8D9C425614C20F2357[7];
if(result7BF46FF1D8244E8D9C425614C20F2357.ContainsKey(3))
ISpace["MF_d2_Initiatedon"].Value = result7BF46FF1D8244E8D9C425614C20F2357[3];
if(result7BF46FF1D8244E8D9C425614C20F2357.ContainsKey(2))
ISpace["MF_d2_TotalAmount"].Value = result7BF46FF1D8244E8D9C425614C20F2357[2];
if(result7BF46FF1D8244E8D9C425614C20F2357.ContainsKey(0))
ISpace["MF_d2_AdvanceFormId"].Value = result7BF46FF1D8244E8D9C425614C20F2357[0];
if(result7BF46FF1D8244E8D9C425614C20F2357.ContainsKey(6))
ISpace["MF_d2_UpdatedBy"].Value = result7BF46FF1D8244E8D9C425614C20F2357[6];
if(result7BF46FF1D8244E8D9C425614C20F2357.ContainsKey(4))
ISpace["MF_d2_InitatedBy"].Value = result7BF46FF1D8244E8D9C425614C20F2357[4];
if(result7BF46FF1D8244E8D9C425614C20F2357.ContainsKey(1))
ISpace["MF_d2_EmployeeBasicInfoId"].Value = result7BF46FF1D8244E8D9C425614C20F2357[1];
if(result7BF46FF1D8244E8D9C425614C20F2357.ContainsKey(5))
ISpace["MF_d2_ApplicationStatus"].Value = result7BF46FF1D8244E8D9C425614C20F2357[5];
}
else{
ISpace["MF_d2_UpdatedOn"].Value = null;ISpace["MF_d2_Initiatedon"].Value = null;ISpace["MF_d2_TotalAmount"].Value = null;ISpace["MF_d2_AdvanceFormId"].Value = null;ISpace["MF_d2_UpdatedBy"].Value = null;ISpace["MF_d2_InitatedBy"].Value = null;ISpace["MF_d2_EmployeeBasicInfoId"].Value = null;ISpace["MF_d2_ApplicationStatus"].Value = null;
}

var querySource60809728D8A94589B22D48DE6409B547 =GetQueryExpressionDataSource("60809728-D8A9-4589-B22D-48DE6409B547");

DataTable result60809728D8A94589B22D48DE6409B547=iSpace.SetGridDataSource(querySource60809728D8A94589B22D48DE6409B547, _objectFactory.GetGridRPP("AdvanceRequestDetails"),@"EXEC InnovaceNoCode..[GridLoadById_0337B98B-59FA-46DC-87A0-89AA288D41AC]  '" + ISpace["MF_d2_AdvanceFormId"].Value + @"'");

iSpace.InsertGridBindDetails("AdvanceRequestDetails","11",querySource60809728D8A94589B22D48DE6409B547,"EXEC InnovaceNoCode..[GridLoadById_0337B98B-59FA-46DC-87A0-89AA288D41AC]  '" + ISpace["MF_d2_AdvanceFormId"].Value + @"'",_objectFactory.GetGridRPP("AdvanceRequestDetails"));

base.WriteDebugInfo(@"var querySource60809728D8A94589B22D48DE6409B547 =GetQueryExpressionDataSource(""60809728-D8A9-4589-B22D-48DE6409B547"");DataTable result60809728D8A94589B22D48DE6409B547=iSpace.SetGridDataSource(querySource60809728D8A94589B22D48DE6409B547, _objectFactory.GetGridRPP(""AdvanceRequestDetails""),@""EXEC InnovaceNoCode..[GridLoadById_0337B98B-59FA-46DC-87A0-89AA288D41AC]  '"" + ISpace[""MF_d2_AdvanceFormId""].Value + @""'"");iSpace.InsertGridBindDetails(""AdvanceRequestDetails"",""11"",querySource60809728D8A94589B22D48DE6409B547,""EXEC InnovaceNoCode..[GridLoadById_0337B98B-59FA-46DC-87A0-89AA288D41AC]  '"" + ISpace[""MF_d2_AdvanceFormId""].Value + @""'"",_objectFactory.GetGridRPP(""AdvanceRequestDetails""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result3C6C0407FD5F467BA72788C4152BA19E=acdataIspace9e2f92013447796498b2a3bb336da186.GetQueryExpressionBindings("3C6C0407-FD5F-467B-A727-88C4152BA19E");
iSpace.SetGridData(result60809728D8A94589B22D48DE6409B547,result3C6C0407FD5F467BA72788C4152BA19E,"AdvanceRequestDetails",ref ISpace);
iSpace.UpdateGridBindDetails("AdvanceRequestDetails",result3C6C0407FD5F467BA72788C4152BA19E);
}
base.WriteDebugInfo(@"EXEC [GetEmployeeUserContextDetails] '@@gv_UserId'");

var querySourcecd3fb793f256485419196ff9147e285e =GetQueryExpressionDataSource("cd3fb793-f256-4854-1919-6ff9147e285e");
Dictionary<short,object> resultcd3fb793f256485419196ff9147e285e=iSpace.ExecuteQuery(querySourcecd3fb793f256485419196ff9147e285e,@"EXEC [GetEmployeeUserContextDetails] '" + ISpace["gv_userid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourcecd3fb793f256485419196ff9147e285e =GetQueryExpressionDataSource(""cd3fb793-f256-4854-1919-6ff9147e285e"");Dictionary<short,object> resultcd3fb793f256485419196ff9147e285e=iSpace.ExecuteQuery(querySourcecd3fb793f256485419196ff9147e285e,@""EXEC [GetEmployeeUserContextDetails] '"" + ISpace[""gv_userid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultcd3fb793f256485419196ff9147e285e!=null) && (resultcd3fb793f256485419196ff9147e285e.Count!=0))
{
if(resultcd3fb793f256485419196ff9147e285e.ContainsKey(1))
ISpace["UC_EmployeeId"].Value = resultcd3fb793f256485419196ff9147e285e[1];
if(resultcd3fb793f256485419196ff9147e285e.ContainsKey(10))
ISpace["UC_DOR"].Value = resultcd3fb793f256485419196ff9147e285e[10];
if(resultcd3fb793f256485419196ff9147e285e.ContainsKey(12))
ISpace["UC_Grade"].Value = resultcd3fb793f256485419196ff9147e285e[12];
if(resultcd3fb793f256485419196ff9147e285e.ContainsKey(7))
ISpace["UC_Designation"].Value = resultcd3fb793f256485419196ff9147e285e[7];
if(resultcd3fb793f256485419196ff9147e285e.ContainsKey(9))
ISpace["UC_DOB"].Value = resultcd3fb793f256485419196ff9147e285e[9];
if(resultcd3fb793f256485419196ff9147e285e.ContainsKey(3))
ISpace["UC_EmailId"].Value = resultcd3fb793f256485419196ff9147e285e[3];
if(resultcd3fb793f256485419196ff9147e285e.ContainsKey(4))
ISpace["UC_DOJ"].Value = resultcd3fb793f256485419196ff9147e285e[4];
if(resultcd3fb793f256485419196ff9147e285e.ContainsKey(0))
ISpace["UC_EmployeeBasicInfoId"].Value = resultcd3fb793f256485419196ff9147e285e[0];
if(resultcd3fb793f256485419196ff9147e285e.ContainsKey(6))
ISpace["UC_Department"].Value = resultcd3fb793f256485419196ff9147e285e[6];
if(resultcd3fb793f256485419196ff9147e285e.ContainsKey(2))
ISpace["UC_Name"].Value = resultcd3fb793f256485419196ff9147e285e[2];
if(resultcd3fb793f256485419196ff9147e285e.ContainsKey(11))
ISpace["UC_EmployeeName"].Value = resultcd3fb793f256485419196ff9147e285e[11];
}
else{
ISpace["UC_EmployeeId"].Value = null;ISpace["UC_DOR"].Value = null;ISpace["UC_Grade"].Value = null;ISpace["UC_Designation"].Value = null;ISpace["UC_DOB"].Value = null;ISpace["UC_EmailId"].Value = null;ISpace["UC_DOJ"].Value = null;ISpace["UC_EmployeeBasicInfoId"].Value = null;ISpace["UC_Department"].Value = null;ISpace["UC_Name"].Value = null;ISpace["UC_EmployeeName"].Value = null;
}
ISpace["MF_IsAdvance"].Value=false;
base.WriteDebugInfo(@"ISpace[""MF_IsAdvance""].Value=false;");
ISpace["MG_d1_Amount"].Man=true;ISpace["MG_d1_ItemDescription"].Man=true;ISpace["MG_d1_ExpenseDetails"].Man=true;
base.WriteDebugInfo(@"ISpace[""MG_d1_Amount""].Man=true;ISpace[""MG_d1_ItemDescription""].Man=true;ISpace[""MG_d1_ExpenseDetails""].Man=true;");
base.WriteDebugInfo(@"EXEC GenerateRef 1");

var querySource8ac4323ce2eda64143dca0a21b55f2e5 =GetQueryExpressionDataSource("8ac4323c-e2ed-a641-43dc-a0a21b55f2e5");
Dictionary<short,object> result8ac4323ce2eda64143dca0a21b55f2e5=iSpace.ExecuteQuery(querySource8ac4323ce2eda64143dca0a21b55f2e5,@"EXECGenerateRef 1",false);

base.WriteDebugInfo(@"var querySource8ac4323ce2eda64143dca0a21b55f2e5 =GetQueryExpressionDataSource(""8ac4323c-e2ed-a641-43dc-a0a21b55f2e5"");Dictionary<short,object> result8ac4323ce2eda64143dca0a21b55f2e5=iSpace.ExecuteQuery(querySource8ac4323ce2eda64143dca0a21b55f2e5,@""EXECGenerateRef 1"",false);");
base.WriteDebugInfo(@"");

if((result8ac4323ce2eda64143dca0a21b55f2e5!=null) && (result8ac4323ce2eda64143dca0a21b55f2e5.Count!=0))
{
if(result8ac4323ce2eda64143dca0a21b55f2e5.ContainsKey(0))
ISpace["Subject"].Value = result8ac4323ce2eda64143dca0a21b55f2e5[0];
if(result8ac4323ce2eda64143dca0a21b55f2e5.ContainsKey(0))
ISpace["TA_refNo"].Value = result8ac4323ce2eda64143dca0a21b55f2e5[0];
}
else{
ISpace["Subject"].Value = null;ISpace["TA_refNo"].Value = null;
}
ISpace["MF_IsAdvance"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MF_IsAdvance""].Enbl=""false"";");
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
private void SubscribeElementEvents_save_advancerequestdetails (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Save_AdvanceRequestDetails-OnClick");
if(ISpace["growid"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""growid""].Value=="""")");

var querySource4CA3178A72124B35B354A6CC18BA475A =GetQueryExpressionDataSource("4CA3178A-7212-4B35-B354-A6CC18BA475A");

DataTable result4CA3178A72124B35B354A6CC18BA475A=iSpace.SetGridDataSource(querySource4CA3178A72124B35B354A6CC18BA475A, _objectFactory.GetGridRPP("AdvanceRequestDetails"),@"EXEC [AddFormGridData0337B98B-59FA-46DC-87A0-89AA288D41AC] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','0337B98B-59FA-46DC-87A0-89AA288D41AC','" + ISpace["growid"].Value + @"'," + ISpace["AdvanceRequestDetails_Sequence"].Value + @",'" + ISpace["MFG_d1_RequestDetailsId"].Value + @"','" + ISpace["MFG_d1_AdvanceFormId"].Value + @"','" + ISpace["MFG_d1_ExpenseDetails"].Value + @"','" + ISpace["MFG_d1_ItemDescription"].Value + @"'," + ISpace["MFG_d1_Amount"].Value + @"");

iSpace.InsertGridBindDetails("AdvanceRequestDetails","11",querySource4CA3178A72124B35B354A6CC18BA475A,"EXEC [AddFormGridData0337B98B-59FA-46DC-87A0-89AA288D41AC] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','0337B98B-59FA-46DC-87A0-89AA288D41AC','" + ISpace["growid"].Value + @"'," + ISpace["AdvanceRequestDetails_Sequence"].Value + @",'" + ISpace["MFG_d1_RequestDetailsId"].Value + @"','" + ISpace["MFG_d1_AdvanceFormId"].Value + @"','" + ISpace["MFG_d1_ExpenseDetails"].Value + @"','" + ISpace["MFG_d1_ItemDescription"].Value + @"'," + ISpace["MFG_d1_Amount"].Value + @"",_objectFactory.GetGridRPP("AdvanceRequestDetails"));

base.WriteDebugInfo(@"var querySource4CA3178A72124B35B354A6CC18BA475A =GetQueryExpressionDataSource(""4CA3178A-7212-4B35-B354-A6CC18BA475A"");DataTable result4CA3178A72124B35B354A6CC18BA475A=iSpace.SetGridDataSource(querySource4CA3178A72124B35B354A6CC18BA475A, _objectFactory.GetGridRPP(""AdvanceRequestDetails""),@""EXEC [AddFormGridData0337B98B-59FA-46DC-87A0-89AA288D41AC] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','0337B98B-59FA-46DC-87A0-89AA288D41AC','"" + ISpace[""growid""].Value + @""',"" + ISpace[""AdvanceRequestDetails_Sequence""].Value + @"",'"" + ISpace[""MFG_d1_RequestDetailsId""].Value + @""','"" + ISpace[""MFG_d1_AdvanceFormId""].Value + @""','"" + ISpace[""MFG_d1_ExpenseDetails""].Value + @""','"" + ISpace[""MFG_d1_ItemDescription""].Value + @""',"" + ISpace[""MFG_d1_Amount""].Value + @"""");iSpace.InsertGridBindDetails(""AdvanceRequestDetails"",""11"",querySource4CA3178A72124B35B354A6CC18BA475A,""EXEC [AddFormGridData0337B98B-59FA-46DC-87A0-89AA288D41AC] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','0337B98B-59FA-46DC-87A0-89AA288D41AC','"" + ISpace[""growid""].Value + @""',"" + ISpace[""AdvanceRequestDetails_Sequence""].Value + @"",'"" + ISpace[""MFG_d1_RequestDetailsId""].Value + @""','"" + ISpace[""MFG_d1_AdvanceFormId""].Value + @""','"" + ISpace[""MFG_d1_ExpenseDetails""].Value + @""','"" + ISpace[""MFG_d1_ItemDescription""].Value + @""',"" + ISpace[""MFG_d1_Amount""].Value + @"""",_objectFactory.GetGridRPP(""AdvanceRequestDetails""));");
base.WriteDebugInfo(@"EXEC [AddFormGridData0337B98B-59FA-46DC-87A0-89AA288D41AC] '@@gv_InstanceId','@@gv_ActivityMapId','0337B98B-59FA-46DC-87A0-89AA288D41AC','#growid',#AdvanceRequestDetails_Sequence,'#MFG_d1_RequestDetailsId','#MFG_d1_AdvanceFormId','#MFG_d1_ExpenseDetails','#MFG_d1_ItemDescription',#MFG_d1_Amount");


List<Triplet<string, short, short?>> result2979992289B54073A7806510276859B5=acdataIspace9e2f92013447796498b2a3bb336da186.GetQueryExpressionBindings("29799922-89B5-4073-A780-6510276859B5");
iSpace.SetGridData(result4CA3178A72124B35B354A6CC18BA475A,result2979992289B54073A7806510276859B5,"AdvanceRequestDetails",ref ISpace);
iSpace.UpdateGridBindDetails("AdvanceRequestDetails",result2979992289B54073A7806510276859B5);
}
else
{
base.WriteDebugInfo(@"else");

var querySource457DF483466042DA82EB1BA15638CB37 =GetQueryExpressionDataSource("457DF483-4660-42DA-82EB-1BA15638CB37");

DataTable result457DF483466042DA82EB1BA15638CB37=iSpace.SetGridDataSource(querySource457DF483466042DA82EB1BA15638CB37, _objectFactory.GetGridRPP("AdvanceRequestDetails"),@"EXEC [UpdateFormGridData0337B98B-59FA-46DC-87A0-89AA288D41AC] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','0337B98B-59FA-46DC-87A0-89AA288D41AC','" + ISpace["growid"].Value + @"'," + ISpace["AdvanceRequestDetails_Sequence"].Value + @",'" + ISpace["MFG_d1_RequestDetailsId"].Value + @"','" + ISpace["MFG_d1_AdvanceFormId"].Value + @"','" + ISpace["MFG_d1_ExpenseDetails"].Value + @"','" + ISpace["MFG_d1_ItemDescription"].Value + @"'," + ISpace["MFG_d1_Amount"].Value + @"");

iSpace.InsertGridBindDetails("AdvanceRequestDetails","11",querySource457DF483466042DA82EB1BA15638CB37,"EXEC [UpdateFormGridData0337B98B-59FA-46DC-87A0-89AA288D41AC] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','0337B98B-59FA-46DC-87A0-89AA288D41AC','" + ISpace["growid"].Value + @"'," + ISpace["AdvanceRequestDetails_Sequence"].Value + @",'" + ISpace["MFG_d1_RequestDetailsId"].Value + @"','" + ISpace["MFG_d1_AdvanceFormId"].Value + @"','" + ISpace["MFG_d1_ExpenseDetails"].Value + @"','" + ISpace["MFG_d1_ItemDescription"].Value + @"'," + ISpace["MFG_d1_Amount"].Value + @"",_objectFactory.GetGridRPP("AdvanceRequestDetails"));

base.WriteDebugInfo(@"var querySource457DF483466042DA82EB1BA15638CB37 =GetQueryExpressionDataSource(""457DF483-4660-42DA-82EB-1BA15638CB37"");DataTable result457DF483466042DA82EB1BA15638CB37=iSpace.SetGridDataSource(querySource457DF483466042DA82EB1BA15638CB37, _objectFactory.GetGridRPP(""AdvanceRequestDetails""),@""EXEC [UpdateFormGridData0337B98B-59FA-46DC-87A0-89AA288D41AC] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','0337B98B-59FA-46DC-87A0-89AA288D41AC','"" + ISpace[""growid""].Value + @""',"" + ISpace[""AdvanceRequestDetails_Sequence""].Value + @"",'"" + ISpace[""MFG_d1_RequestDetailsId""].Value + @""','"" + ISpace[""MFG_d1_AdvanceFormId""].Value + @""','"" + ISpace[""MFG_d1_ExpenseDetails""].Value + @""','"" + ISpace[""MFG_d1_ItemDescription""].Value + @""',"" + ISpace[""MFG_d1_Amount""].Value + @"""");iSpace.InsertGridBindDetails(""AdvanceRequestDetails"",""11"",querySource457DF483466042DA82EB1BA15638CB37,""EXEC [UpdateFormGridData0337B98B-59FA-46DC-87A0-89AA288D41AC] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','0337B98B-59FA-46DC-87A0-89AA288D41AC','"" + ISpace[""growid""].Value + @""',"" + ISpace[""AdvanceRequestDetails_Sequence""].Value + @"",'"" + ISpace[""MFG_d1_RequestDetailsId""].Value + @""','"" + ISpace[""MFG_d1_AdvanceFormId""].Value + @""','"" + ISpace[""MFG_d1_ExpenseDetails""].Value + @""','"" + ISpace[""MFG_d1_ItemDescription""].Value + @""',"" + ISpace[""MFG_d1_Amount""].Value + @"""",_objectFactory.GetGridRPP(""AdvanceRequestDetails""));");
base.WriteDebugInfo(@"EXEC [UpdateFormGridData0337B98B-59FA-46DC-87A0-89AA288D41AC] '@@gv_InstanceId','@@gv_ActivityMapId','0337B98B-59FA-46DC-87A0-89AA288D41AC','#growid',#AdvanceRequestDetails_Sequence,'#MFG_d1_RequestDetailsId','#MFG_d1_AdvanceFormId','#MFG_d1_ExpenseDetails','#MFG_d1_ItemDescription',#MFG_d1_Amount");


List<Triplet<string, short, short?>> result67DEF8CBD0314FD48DC943298D811794=acdataIspace9e2f92013447796498b2a3bb336da186.GetQueryExpressionBindings("67DEF8CB-D031-4FD4-8DC9-43298D811794");
iSpace.SetGridData(result457DF483466042DA82EB1BA15638CB37,result67DEF8CBD0314FD48DC943298D811794,"AdvanceRequestDetails",ref ISpace);
iSpace.UpdateGridBindDetails("AdvanceRequestDetails",result67DEF8CBD0314FD48DC943298D811794);
}
ISpace["growid"].Value="";
base.WriteDebugInfo(@"ISpace[""growid""].Value="""";");
ISpace["MFG_d1_RequestDetailsId"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d1_RequestDetailsId""].Value="""";");
ISpace["MFG_d1_AdvanceFormId"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d1_AdvanceFormId""].Value="""";");
ISpace["MFG_d1_ExpenseDetails"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d1_ExpenseDetails""].Value="""";");
ISpace["MFG_d1_ItemDescription"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d1_ItemDescription""].Value="""";");
ISpace["MFG_d1_Amount"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d1_Amount""].Value="""";");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_wmf_history (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"WMF_History-OnClick");

var querySource72ABBA101D3E4391BDBDEBBE0E2E0237 =GetQueryExpressionDataSource("72ABBA10-1D3E-4391-BDBD-EBBE0E2E0237");

DataTable result72ABBA101D3E4391BDBDEBBE0E2E0237=iSpace.SetGridDataSource(querySource72ABBA101D3E4391BDBDEBBE0E2E0237, _objectFactory.GetGridRPP("WMG_CommentsHistory"),@"EXEC [GetInstanceFlowDetais] '" + ISpace["gv_instanceid"].Value + @"'");

iSpace.InsertGridBindDetails("WMG_CommentsHistory","11",querySource72ABBA101D3E4391BDBDEBBE0E2E0237,"EXEC [GetInstanceFlowDetais] '" + ISpace["gv_instanceid"].Value + @"'",_objectFactory.GetGridRPP("WMG_CommentsHistory"));

base.WriteDebugInfo(@"var querySource72ABBA101D3E4391BDBDEBBE0E2E0237 =GetQueryExpressionDataSource(""72ABBA10-1D3E-4391-BDBD-EBBE0E2E0237"");DataTable result72ABBA101D3E4391BDBDEBBE0E2E0237=iSpace.SetGridDataSource(querySource72ABBA101D3E4391BDBDEBBE0E2E0237, _objectFactory.GetGridRPP(""WMG_CommentsHistory""),@""EXEC [GetInstanceFlowDetais] '"" + ISpace[""gv_instanceid""].Value + @""'"");iSpace.InsertGridBindDetails(""WMG_CommentsHistory"",""11"",querySource72ABBA101D3E4391BDBDEBBE0E2E0237,""EXEC [GetInstanceFlowDetais] '"" + ISpace[""gv_instanceid""].Value + @""'"",_objectFactory.GetGridRPP(""WMG_CommentsHistory""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result6DA5E7991709406E85D09DC6581E03C3=acdataIspace9e2f92013447796498b2a3bb336da186.GetQueryExpressionBindings("6DA5E799-1709-406E-85D0-9DC6581E03C3");
iSpace.SetGridData(result72ABBA101D3E4391BDBDEBBE0E2E0237,result6DA5E7991709406E85D09DC6581E03C3,"WMG_CommentsHistory",ref ISpace);
iSpace.UpdateGridBindDetails("WMG_CommentsHistory",result6DA5E7991709406E85D09DC6581E03C3);
ISpace["UI_History"].ShowDialog=true;;
base.WriteDebugInfo(@"ISpace[""UI_History""].ShowDialog=true;;");
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
if(ISpace["WF_FlowType"].Value=="APPROVE")
{
base.WriteDebugInfo(@"if(ISpace[""WF_FlowType""].Value==""APPROVE"")");
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
if(ISpace["WF_FlowType"].Value=="RETURN" || ISpace["WF_FlowType"].Value=="REJECT")
{
base.WriteDebugInfo(@"if(ISpace[""WF_FlowType""].Value==""RETURN"" || ISpace[""WF_FlowType""].Value==""REJECT"")");
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
if(ISpace["MF_FundTotal"].Value!=ISpace["MF_d2_TotalAmount"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_FundTotal""].Value!=ISpace[""MF_d2_TotalAmount""].Value)");
ISpace["Message"].Value=@"Error:Total Amount And Overall Fund Total must be equal";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Error:Total Amount And Overall Fund Total must be equal"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
base.WriteDebugInfo(@"EXEC InnovaceNoCode..[FormSave_744F780C-12D2-41D3-9084-6E903A527934]   '@@gv_InstanceId','@@gv_ActivityMapId','85014d12-a85b-4330-8d7f-29776cbda319','#MF_d2_AdvanceFormId','#MF_d2_EmployeeBasicInfoId',#MF_d2_TotalAmount,'#MF_d2_Initiatedon','#MF_d2_InitatedBy','#MF_d2_ApplicationStatus','#MF_d2_UpdatedBy','#MF_d2_UpdatedOn','#TA_refNo','#MF_IsAdvance'");

var querySource29CE51BC9310456E84FAC3692433C21E =GetQueryExpressionDataSource("29CE51BC-9310-456E-84FA-C3692433C21E");
Dictionary<short,object> result29CE51BC9310456E84FAC3692433C21E=iSpace.ExecuteQuery(querySource29CE51BC9310456E84FAC3692433C21E,@"EXEC InnovaceNoCode..[FormSave_744F780C-12D2-41D3-9084-6E903A527934]   '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','85014d12-a85b-4330-8d7f-29776cbda319','" + ISpace["MF_d2_AdvanceFormId"].Value + @"','" + ISpace["MF_d2_EmployeeBasicInfoId"].Value + @"'," + ISpace["MF_d2_TotalAmount"].Value + @",'" + ISpace["MF_d2_Initiatedon"].Value + @"','" + ISpace["MF_d2_InitatedBy"].Value + @"','" + ISpace["MF_d2_ApplicationStatus"].Value + @"','" + ISpace["MF_d2_UpdatedBy"].Value + @"','" + ISpace["MF_d2_UpdatedOn"].Value + @"','" + ISpace["TA_refNo"].Value + @"','" + ISpace["MF_IsAdvance"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource29CE51BC9310456E84FAC3692433C21E =GetQueryExpressionDataSource(""29CE51BC-9310-456E-84FA-C3692433C21E"");Dictionary<short,object> result29CE51BC9310456E84FAC3692433C21E=iSpace.ExecuteQuery(querySource29CE51BC9310456E84FAC3692433C21E,@""EXEC InnovaceNoCode..[FormSave_744F780C-12D2-41D3-9084-6E903A527934]   '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','85014d12-a85b-4330-8d7f-29776cbda319','"" + ISpace[""MF_d2_AdvanceFormId""].Value + @""','"" + ISpace[""MF_d2_EmployeeBasicInfoId""].Value + @""',"" + ISpace[""MF_d2_TotalAmount""].Value + @"",'"" + ISpace[""MF_d2_Initiatedon""].Value + @""','"" + ISpace[""MF_d2_InitatedBy""].Value + @""','"" + ISpace[""MF_d2_ApplicationStatus""].Value + @""','"" + ISpace[""MF_d2_UpdatedBy""].Value + @""','"" + ISpace[""MF_d2_UpdatedOn""].Value + @""','"" + ISpace[""TA_refNo""].Value + @""','"" + ISpace[""MF_IsAdvance""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result29CE51BC9310456E84FAC3692433C21E!=null) && (result29CE51BC9310456E84FAC3692433C21E.Count!=0))
{
if(result29CE51BC9310456E84FAC3692433C21E.ContainsKey(0))
ISpace["ExecutionMessage"].Value = result29CE51BC9310456E84FAC3692433C21E[0];
}
else{
ISpace["ExecutionMessage"].Value = null;
}
base.WriteDebugInfo(@"EXEC InnovaceNoCode..[GridSave_0337B98B-59FA-46DC-87A0-89AA288D41AC]   '@@gv_InstanceId','@@gv_ActivityMapId','0337B98B-59FA-46DC-87A0-89AA288D41AC'");

var querySourceB6975CE7CE564E4DB7CC2B1863890CE7 =GetQueryExpressionDataSource("B6975CE7-CE56-4E4D-B7CC-2B1863890CE7");
Dictionary<short,object> resultB6975CE7CE564E4DB7CC2B1863890CE7=iSpace.ExecuteQuery(querySourceB6975CE7CE564E4DB7CC2B1863890CE7,@"EXEC InnovaceNoCode..[GridSave_0337B98B-59FA-46DC-87A0-89AA288D41AC]   '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','0337B98B-59FA-46DC-87A0-89AA288D41AC'",false);

base.WriteDebugInfo(@"var querySourceB6975CE7CE564E4DB7CC2B1863890CE7 =GetQueryExpressionDataSource(""B6975CE7-CE56-4E4D-B7CC-2B1863890CE7"");Dictionary<short,object> resultB6975CE7CE564E4DB7CC2B1863890CE7=iSpace.ExecuteQuery(querySourceB6975CE7CE564E4DB7CC2B1863890CE7,@""EXEC InnovaceNoCode..[GridSave_0337B98B-59FA-46DC-87A0-89AA288D41AC]   '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','0337B98B-59FA-46DC-87A0-89AA288D41AC'"",false);");
base.WriteDebugInfo(@"");

if((resultB6975CE7CE564E4DB7CC2B1863890CE7!=null) && (resultB6975CE7CE564E4DB7CC2B1863890CE7.Count!=0))
{
if(resultB6975CE7CE564E4DB7CC2B1863890CE7.ContainsKey(0))
ISpace["ExecutionMessage"].Value = resultB6975CE7CE564E4DB7CC2B1863890CE7[0];
}
else{
ISpace["ExecutionMessage"].Value = null;
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
base.WriteDebugInfo(@"EXEC [SaveTempAdvanceDocuments] '@@gv_InstanceId','@@gv_ProcessMapId','@@gv_UserId'");

var querySource76cdd0d498cf655504d2066565596182 =GetQueryExpressionDataSource("76cdd0d4-98cf-6555-04d2-066565596182");
Dictionary<short,object> result76cdd0d498cf655504d2066565596182=iSpace.ExecuteQuery(querySource76cdd0d498cf655504d2066565596182,@"EXEC [SaveTempAdvanceDocuments] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','" + ISpace["gv_userid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource76cdd0d498cf655504d2066565596182 =GetQueryExpressionDataSource(""76cdd0d4-98cf-6555-04d2-066565596182"");Dictionary<short,object> result76cdd0d498cf655504d2066565596182=iSpace.ExecuteQuery(querySource76cdd0d498cf655504d2066565596182,@""EXEC [SaveTempAdvanceDocuments] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','"" + ISpace[""gv_userid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result76cdd0d498cf655504d2066565596182!=null) && (result76cdd0d498cf655504d2066565596182.Count!=0))
{
if(result76cdd0d498cf655504d2066565596182.ContainsKey(0))
ISpace["MF_ErrId"].Value = result76cdd0d498cf655504d2066565596182[0];
if(result76cdd0d498cf655504d2066565596182.ContainsKey(1))
ISpace["MF_ErrMsg"].Value = result76cdd0d498cf655504d2066565596182[1];
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

var querySource8C55982FEE834AF1A356390DE5D2877F =GetQueryExpressionDataSource("8C55982F-EE83-4AF1-A356-390DE5D2877F");
Dictionary<short,object> result8C55982FEE834AF1A356390DE5D2877F=iSpace.ExecuteQuery(querySource8C55982FEE834AF1A356390DE5D2877F,@"EXEC [UpsertProjectFundAllocation] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','" + ISpace["gv_userid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource8C55982FEE834AF1A356390DE5D2877F =GetQueryExpressionDataSource(""8C55982F-EE83-4AF1-A356-390DE5D2877F"");Dictionary<short,object> result8C55982FEE834AF1A356390DE5D2877F=iSpace.ExecuteQuery(querySource8C55982FEE834AF1A356390DE5D2877F,@""EXEC [UpsertProjectFundAllocation] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','"" + ISpace[""gv_userid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result8C55982FEE834AF1A356390DE5D2877F!=null) && (result8C55982FEE834AF1A356390DE5D2877F.Count!=0))
{
if(result8C55982FEE834AF1A356390DE5D2877F.ContainsKey(0))
ISpace["PFM_ErrId"].Value = result8C55982FEE834AF1A356390DE5D2877F[0];
}
else{
ISpace["PFM_ErrId"].Value = null;
}
ISpace["Message"].Value=@"Success: Submitted Successfully";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Success: Submitted Successfully"";");

ISpace["RedirectUrl"].RedirectType="R";
ISpace["RedirectUrl"].Value="?PkActMId=0325353E-7E13-4762-AFC9-88434C58F52C&frmElementId=49A96C7C-D729-40AB-BA35-E48EC2181E2D&PkPrMId=0CC7EA0F-1DD0-4053-9D0E-E7EF819021D7&formVersionId=C935B56C-79C4-4F7E-89BD-5FADD98FC65E&Ver=0.0000";
base.WriteDebugInfo(@"
ISpace[""RedirectUrl""].RedirectType=""R"";
ISpace[""RedirectUrl""].Value=""?PkActMId=0325353E-7E13-4762-AFC9-88434C58F52C&frmElementId=49A96C7C-D729-40AB-BA35-E48EC2181E2D&PkPrMId=0CC7EA0F-1DD0-4053-9D0E-E7EF819021D7&formVersionId=C935B56C-79C4-4F7E-89BD-5FADD98FC65E&Ver=0.0000"";");

ISpace["RedirectUrl"].RedirectType="R";
ISpace["RedirectUrl"].Value="/Inbox";
base.WriteDebugInfo(@"
ISpace[""RedirectUrl""].RedirectType=""R"";
ISpace[""RedirectUrl""].Value=""/Inbox"";");
if(ISpace["WF_FlowType"].Value=="REJECT"||ISpace["WF_FlowType"].Value=="RETURN")
{
base.WriteDebugInfo(@"if(ISpace[""WF_FlowType""].Value==""REJECT""||ISpace[""WF_FlowType""].Value==""RETURN"")");
base.WriteDebugInfo(@"EXEC [UpdateTemporaryAdvanceStatus] '@@gv_InstanceId','#WF_FlowType','@@gv_UserId'");

var querySource4fc913b439b349cfb675a463ca4816fc =GetQueryExpressionDataSource("4fc913b4-39b3-49cf-b675-a463ca4816fc");
Dictionary<short,object> result4fc913b439b349cfb675a463ca4816fc=iSpace.ExecuteQuery(querySource4fc913b439b349cfb675a463ca4816fc,@"EXEC [UpdateTemporaryAdvanceStatus] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["WF_FlowType"].Value + @"','" + ISpace["gv_userid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource4fc913b439b349cfb675a463ca4816fc =GetQueryExpressionDataSource(""4fc913b4-39b3-49cf-b675-a463ca4816fc"");Dictionary<short,object> result4fc913b439b349cfb675a463ca4816fc=iSpace.ExecuteQuery(querySource4fc913b439b349cfb675a463ca4816fc,@""EXEC [UpdateTemporaryAdvanceStatus] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""WF_FlowType""].Value + @""','"" + ISpace[""gv_userid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result4fc913b439b349cfb675a463ca4816fc!=null) && (result4fc913b439b349cfb675a463ca4816fc.Count!=0))
{
if(result4fc913b439b349cfb675a463ca4816fc.ContainsKey(0))
ISpace["MF_ErrId"].Value = result4fc913b439b349cfb675a463ca4816fc[0];
}
else{
ISpace["MF_ErrId"].Value = null;
}
}
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

var querySource7454D2C4EC3145E49820D4FE4FB7EDC9 =GetQueryExpressionDataSource("7454D2C4-EC31-45E4-9820-D4FE4FB7EDC9");
Dictionary<short,object> result7454D2C4EC3145E49820D4FE4FB7EDC9=iSpace.ExecuteQuery(querySource7454D2C4EC3145E49820D4FE4FB7EDC9,@"EXEC[Delete60e821d0-153e_94bb-1fef-2594b78625bd] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["PFM_FundDetailsId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource7454D2C4EC3145E49820D4FE4FB7EDC9 =GetQueryExpressionDataSource(""7454D2C4-EC31-45E4-9820-D4FE4FB7EDC9"");Dictionary<short,object> result7454D2C4EC3145E49820D4FE4FB7EDC9=iSpace.ExecuteQuery(querySource7454D2C4EC3145E49820D4FE4FB7EDC9,@""EXEC[Delete60e821d0-153e_94bb-1fef-2594b78625bd] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""PFM_FundDetailsId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result7454D2C4EC3145E49820D4FE4FB7EDC9!=null) && (result7454D2C4EC3145E49820D4FE4FB7EDC9.Count!=0))
{
if(result7454D2C4EC3145E49820D4FE4FB7EDC9.ContainsKey(0))
ISpace["PFM_ErrId"].Value = result7454D2C4EC3145E49820D4FE4FB7EDC9[0];
if(result7454D2C4EC3145E49820D4FE4FB7EDC9.ContainsKey(1))
ISpace["PFM_ErrMsg"].Value = result7454D2C4EC3145E49820D4FE4FB7EDC9[1];
}
else{
ISpace["PFM_ErrId"].Value = null;ISpace["PFM_ErrMsg"].Value = null;
}
ISpace["Message"].Value=String.Format(@"{0}",ISpace["PFM_ErrMsg"].Value);
base.WriteDebugInfo(@"ISpace[""Message""].Value=String.Format(@""{0}"",ISpace[""PFM_ErrMsg""].Value);");

var querySource705F1E2B47054D8E8B6512AD847DCF29 =GetQueryExpressionDataSource("705F1E2B-4705-4D8E-8B65-12AD847DCF29");

DataTable result705F1E2B47054D8E8B6512AD847DCF29=iSpace.SetGridDataSource(querySource705F1E2B47054D8E8B6512AD847DCF29, _objectFactory.GetGridRPP("MG_FundAllocation"),@"Exec [Get60e821d0-153e-94bb-1fef-2594b78625bd] '" + ISpace["gv_instanceid"].Value + @"'");

iSpace.InsertGridBindDetails("MG_FundAllocation","11",querySource705F1E2B47054D8E8B6512AD847DCF29,"Exec [Get60e821d0-153e-94bb-1fef-2594b78625bd] '" + ISpace["gv_instanceid"].Value + @"'",_objectFactory.GetGridRPP("MG_FundAllocation"));

base.WriteDebugInfo(@"var querySource705F1E2B47054D8E8B6512AD847DCF29 =GetQueryExpressionDataSource(""705F1E2B-4705-4D8E-8B65-12AD847DCF29"");DataTable result705F1E2B47054D8E8B6512AD847DCF29=iSpace.SetGridDataSource(querySource705F1E2B47054D8E8B6512AD847DCF29, _objectFactory.GetGridRPP(""MG_FundAllocation""),@""Exec [Get60e821d0-153e-94bb-1fef-2594b78625bd] '"" + ISpace[""gv_instanceid""].Value + @""'"");iSpace.InsertGridBindDetails(""MG_FundAllocation"",""11"",querySource705F1E2B47054D8E8B6512AD847DCF29,""Exec [Get60e821d0-153e-94bb-1fef-2594b78625bd] '"" + ISpace[""gv_instanceid""].Value + @""'"",_objectFactory.GetGridRPP(""MG_FundAllocation""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result1724FDC9047B45B8BCFEDD14A7738AD2=acdataIspace9e2f92013447796498b2a3bb336da186.GetQueryExpressionBindings("1724FDC9-047B-45B8-BCFE-DD14A7738AD2");
iSpace.SetGridData(result705F1E2B47054D8E8B6512AD847DCF29,result1724FDC9047B45B8BCFEDD14A7738AD2,"MG_FundAllocation",ref ISpace);
iSpace.UpdateGridBindDetails("MG_FundAllocation",result1724FDC9047B45B8BCFEDD14A7738AD2);
ISpace["PFM_FundDetailsId"].Value="";
base.WriteDebugInfo(@"ISpace[""PFM_FundDetailsId""].Value="""";");
ISpace["UI_DeleteDialog"].HideDialog=true;;
base.WriteDebugInfo(@"ISpace[""UI_DeleteDialog""].HideDialog=true;;");
base.WriteDebugInfo(@"EXEC [GetFundSum] '@@gv_InstanceId'");

var querySourcea336918c91187c39997885844c207f84 =GetQueryExpressionDataSource("a336918c-9118-7c39-9978-85844c207f84");
Dictionary<short,object> resulta336918c91187c39997885844c207f84=iSpace.ExecuteQuery(querySourcea336918c91187c39997885844c207f84,@"EXEC [GetFundSum] '" + ISpace["gv_instanceid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourcea336918c91187c39997885844c207f84 =GetQueryExpressionDataSource(""a336918c-9118-7c39-9978-85844c207f84"");Dictionary<short,object> resulta336918c91187c39997885844c207f84=iSpace.ExecuteQuery(querySourcea336918c91187c39997885844c207f84,@""EXEC [GetFundSum] '"" + ISpace[""gv_instanceid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resulta336918c91187c39997885844c207f84!=null) && (resulta336918c91187c39997885844c207f84.Count!=0))
{
if(resulta336918c91187c39997885844c207f84.ContainsKey(0))
ISpace["MF_FundTotal"].Value = resulta336918c91187c39997885844c207f84[0];
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
private void SubscribeElementEvents_mg_d1_amount (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MG_d1_Amount-OnChange");
object MG_d1_Amount=iSpace.Sum("[0337B98B-59FA-46DC-87A0-89AA288D41AC]","MG_d1_Amount","",ISpace["gv_instanceid"].Value);
ISpace["MF_d2_TotalAmount"].Value=Convert.ChangeType(MG_d1_Amount, MG_d1_Amount.GetType());;
base.WriteDebugInfo(@"object MG_d1_Amount=iSpace.Sum(""[0337B98B-59FA-46DC-87A0-89AA288D41AC]"",""MG_d1_Amount"","""",ISpace[""gv_instanceid""].Value);
ISpace[""MF_d2_TotalAmount""].Value=Convert.ChangeType(MG_d1_Amount, MG_d1_Amount.GetType());;");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_edit_advancerequestdetails (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Edit_AdvanceRequestDetails-OnClick");
ISpace["growid"].Value=ISpace["AdvanceRequestDetails_RowId"].Value;
base.WriteDebugInfo(@"ISpace[""growid""].Value=ISpace[""AdvanceRequestDetails_RowId""].Value;");
base.WriteDebugInfo(@"EXEC [LoadFormGridData0337B98B-59FA-46DC-87A0-89AA288D41AC] '@@gv_InstanceId','@@gv_ActivityMapId','0337B98B-59FA-46DC-87A0-89AA288D41AC','#growid',#AdvanceRequestDetails_Sequence");

var querySource0A6D4BD3999E458EB9306B42970476DD =GetQueryExpressionDataSource("0A6D4BD3-999E-458E-B930-6B42970476DD");
Dictionary<short,object> result0A6D4BD3999E458EB9306B42970476DD=iSpace.ExecuteQuery(querySource0A6D4BD3999E458EB9306B42970476DD,@"EXEC [LoadFormGridData0337B98B-59FA-46DC-87A0-89AA288D41AC] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','0337B98B-59FA-46DC-87A0-89AA288D41AC','" + ISpace["growid"].Value + @"'," + ISpace["AdvanceRequestDetails_Sequence"].Value + @"",false);

base.WriteDebugInfo(@"var querySource0A6D4BD3999E458EB9306B42970476DD =GetQueryExpressionDataSource(""0A6D4BD3-999E-458E-B930-6B42970476DD"");Dictionary<short,object> result0A6D4BD3999E458EB9306B42970476DD=iSpace.ExecuteQuery(querySource0A6D4BD3999E458EB9306B42970476DD,@""EXEC [LoadFormGridData0337B98B-59FA-46DC-87A0-89AA288D41AC] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','0337B98B-59FA-46DC-87A0-89AA288D41AC','"" + ISpace[""growid""].Value + @""',"" + ISpace[""AdvanceRequestDetails_Sequence""].Value + @"""",false);");
base.WriteDebugInfo(@"EXEC [LoadFormGridData0337B98B-59FA-46DC-87A0-89AA288D41AC] '@@gv_InstanceId','@@gv_ActivityMapId','0337B98B-59FA-46DC-87A0-89AA288D41AC','#growid',#AdvanceRequestDetails_Sequence");

if((result0A6D4BD3999E458EB9306B42970476DD!=null) && (result0A6D4BD3999E458EB9306B42970476DD.Count!=0))
{
if(result0A6D4BD3999E458EB9306B42970476DD.ContainsKey(4))
ISpace["MFG_d1_Amount"].Value = result0A6D4BD3999E458EB9306B42970476DD[4];
if(result0A6D4BD3999E458EB9306B42970476DD.ContainsKey(1))
ISpace["MFG_d1_AdvanceFormId"].Value = result0A6D4BD3999E458EB9306B42970476DD[1];
if(result0A6D4BD3999E458EB9306B42970476DD.ContainsKey(0))
ISpace["MFG_d1_RequestDetailsId"].Value = result0A6D4BD3999E458EB9306B42970476DD[0];
if(result0A6D4BD3999E458EB9306B42970476DD.ContainsKey(3))
ISpace["MFG_d1_ItemDescription"].Value = result0A6D4BD3999E458EB9306B42970476DD[3];
if(result0A6D4BD3999E458EB9306B42970476DD.ContainsKey(2))
ISpace["MFG_d1_ExpenseDetails"].Value = result0A6D4BD3999E458EB9306B42970476DD[2];
}
else{
ISpace["MFG_d1_Amount"].Value = null;ISpace["MFG_d1_AdvanceFormId"].Value = null;ISpace["MFG_d1_RequestDetailsId"].Value = null;ISpace["MFG_d1_ItemDescription"].Value = null;ISpace["MFG_d1_ExpenseDetails"].Value = null;
}
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
ISpace["WF_FlowType"].Value="APPROVE";
base.WriteDebugInfo(@"ISpace[""WF_FlowType""].Value=""APPROVE"";");
ISpace["Comments"].Man=false;
base.WriteDebugInfo(@"ISpace[""Comments""].Man=false;");
}
if(ISpace["WMF_MoveTo"].Value=="RETURN")
{
base.WriteDebugInfo(@"if(ISpace[""WMF_MoveTo""].Value==""RETURN"")");
ISpace["WF_FlowType"].Value="RETURN";
base.WriteDebugInfo(@"ISpace[""WF_FlowType""].Value=""RETURN"";");
ISpace["Comments"].Man=true;
base.WriteDebugInfo(@"ISpace[""Comments""].Man=true;");
}
if(ISpace["WMF_MoveTo"].Value=="REJECT")
{
base.WriteDebugInfo(@"if(ISpace[""WMF_MoveTo""].Value==""REJECT"")");
ISpace["WF_FlowType"].Value="REJECT";
base.WriteDebugInfo(@"ISpace[""WF_FlowType""].Value=""REJECT"";");
ISpace["Comments"].Man=true;
base.WriteDebugInfo(@"ISpace[""Comments""].Man=true;");
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
private void SubscribeElementEvents_pfa_edit (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"PFA_Edit-OnClick");
base.WriteDebugInfo(@"Exec [Get60e821d0-153e-94bb-1fef-2594b78625bd] '@@gv_InstanceId','#PFA_FundDetailsId'");

var querySource1AA578C6395747278F2A6B46297860EA =GetQueryExpressionDataSource("1AA578C6-3957-4727-8F2A-6B46297860EA");
Dictionary<short,object> result1AA578C6395747278F2A6B46297860EA=iSpace.ExecuteQuery(querySource1AA578C6395747278F2A6B46297860EA,@"Exec [Get60e821d0-153e-94bb-1fef-2594b78625bd] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["PFA_FundDetailsId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource1AA578C6395747278F2A6B46297860EA =GetQueryExpressionDataSource(""1AA578C6-3957-4727-8F2A-6B46297860EA"");Dictionary<short,object> result1AA578C6395747278F2A6B46297860EA=iSpace.ExecuteQuery(querySource1AA578C6395747278F2A6B46297860EA,@""Exec [Get60e821d0-153e-94bb-1fef-2594b78625bd] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""PFA_FundDetailsId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result1AA578C6395747278F2A6B46297860EA!=null) && (result1AA578C6395747278F2A6B46297860EA.Count!=0))
{
if(result1AA578C6395747278F2A6B46297860EA.ContainsKey(5))
ISpace["FWFM_FundType"].Value = result1AA578C6395747278F2A6B46297860EA[5];
if(result1AA578C6395747278F2A6B46297860EA.ContainsKey(9))
ISpace["FWFM_BudgetHead"].Value = result1AA578C6395747278F2A6B46297860EA[9];
if(result1AA578C6395747278F2A6B46297860EA.ContainsKey(7))
ISpace["FWFM_ProjectNo"].Value = result1AA578C6395747278F2A6B46297860EA[7];
if(result1AA578C6395747278F2A6B46297860EA.ContainsKey(11))
ISpace["FWFM_Amount"].Value = result1AA578C6395747278F2A6B46297860EA[11];
if(result1AA578C6395747278F2A6B46297860EA.ContainsKey(3))
ISpace["FWFM_FundDetailsId"].Value = result1AA578C6395747278F2A6B46297860EA[3];
}
else{
ISpace["FWFM_FundType"].Value = null;ISpace["FWFM_BudgetHead"].Value = null;ISpace["FWFM_ProjectNo"].Value = null;ISpace["FWFM_Amount"].Value = null;ISpace["FWFM_FundDetailsId"].Value = null;
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

var querySource1B34805740374195AEB72D251B781A4E =GetQueryExpressionDataSource("1B348057-4037-4195-AEB7-2D251B781A4E");
Dictionary<short,object> result1B34805740374195AEB72D251B781A4E=iSpace.ExecuteQuery(querySource1B34805740374195AEB72D251B781A4E,@"EXEC [Upsert60e821d0-153e-94bb-1fef-2594b78625bd] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','" + ISpace["FWFM_FundDetailsId"].Value + @"','" + ISpace["FWFM_FundType"].Value + @"','" + ISpace["FWFM_ProjectNo"].Value + @"','" + ISpace["FWFM_BudgetHead"].Value + @"','" + ISpace["FWFM_Amount"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource1B34805740374195AEB72D251B781A4E =GetQueryExpressionDataSource(""1B348057-4037-4195-AEB7-2D251B781A4E"");Dictionary<short,object> result1B34805740374195AEB72D251B781A4E=iSpace.ExecuteQuery(querySource1B34805740374195AEB72D251B781A4E,@""EXEC [Upsert60e821d0-153e-94bb-1fef-2594b78625bd] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','"" + ISpace[""FWFM_FundDetailsId""].Value + @""','"" + ISpace[""FWFM_FundType""].Value + @""','"" + ISpace[""FWFM_ProjectNo""].Value + @""','"" + ISpace[""FWFM_BudgetHead""].Value + @""','"" + ISpace[""FWFM_Amount""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result1B34805740374195AEB72D251B781A4E!=null) && (result1B34805740374195AEB72D251B781A4E.Count!=0))
{
if(result1B34805740374195AEB72D251B781A4E.ContainsKey(0))
ISpace["PFM_ErrId"].Value = result1B34805740374195AEB72D251B781A4E[0];
if(result1B34805740374195AEB72D251B781A4E.ContainsKey(1))
ISpace["PFM_ErrMsg"].Value = result1B34805740374195AEB72D251B781A4E[1];
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

var querySource705F1E2B47054D8E8B6512AD847DCF29 =GetQueryExpressionDataSource("705F1E2B-4705-4D8E-8B65-12AD847DCF29");

DataTable result705F1E2B47054D8E8B6512AD847DCF29=iSpace.SetGridDataSource(querySource705F1E2B47054D8E8B6512AD847DCF29, _objectFactory.GetGridRPP("MG_FundAllocation"),@"Exec [Get60e821d0-153e-94bb-1fef-2594b78625bd] '" + ISpace["gv_instanceid"].Value + @"'");

iSpace.InsertGridBindDetails("MG_FundAllocation","11",querySource705F1E2B47054D8E8B6512AD847DCF29,"Exec [Get60e821d0-153e-94bb-1fef-2594b78625bd] '" + ISpace["gv_instanceid"].Value + @"'",_objectFactory.GetGridRPP("MG_FundAllocation"));

base.WriteDebugInfo(@"var querySource705F1E2B47054D8E8B6512AD847DCF29 =GetQueryExpressionDataSource(""705F1E2B-4705-4D8E-8B65-12AD847DCF29"");DataTable result705F1E2B47054D8E8B6512AD847DCF29=iSpace.SetGridDataSource(querySource705F1E2B47054D8E8B6512AD847DCF29, _objectFactory.GetGridRPP(""MG_FundAllocation""),@""Exec [Get60e821d0-153e-94bb-1fef-2594b78625bd] '"" + ISpace[""gv_instanceid""].Value + @""'"");iSpace.InsertGridBindDetails(""MG_FundAllocation"",""11"",querySource705F1E2B47054D8E8B6512AD847DCF29,""Exec [Get60e821d0-153e-94bb-1fef-2594b78625bd] '"" + ISpace[""gv_instanceid""].Value + @""'"",_objectFactory.GetGridRPP(""MG_FundAllocation""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result1724FDC9047B45B8BCFEDD14A7738AD2=acdataIspace9e2f92013447796498b2a3bb336da186.GetQueryExpressionBindings("1724FDC9-047B-45B8-BCFE-DD14A7738AD2");
iSpace.SetGridData(result705F1E2B47054D8E8B6512AD847DCF29,result1724FDC9047B45B8BCFEDD14A7738AD2,"MG_FundAllocation",ref ISpace);
iSpace.UpdateGridBindDetails("MG_FundAllocation",result1724FDC9047B45B8BCFEDD14A7738AD2);
base.WriteDebugInfo(@"EXEC [GetFundSum] '@@gv_InstanceId'");

var querySourcea336918c91187c39997885844c207f84 =GetQueryExpressionDataSource("a336918c-9118-7c39-9978-85844c207f84");
Dictionary<short,object> resulta336918c91187c39997885844c207f84=iSpace.ExecuteQuery(querySourcea336918c91187c39997885844c207f84,@"EXEC [GetFundSum] '" + ISpace["gv_instanceid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourcea336918c91187c39997885844c207f84 =GetQueryExpressionDataSource(""a336918c-9118-7c39-9978-85844c207f84"");Dictionary<short,object> resulta336918c91187c39997885844c207f84=iSpace.ExecuteQuery(querySourcea336918c91187c39997885844c207f84,@""EXEC [GetFundSum] '"" + ISpace[""gv_instanceid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resulta336918c91187c39997885844c207f84!=null) && (resulta336918c91187c39997885844c207f84.Count!=0))
{
if(resulta336918c91187c39997885844c207f84.ContainsKey(0))
ISpace["MF_FundTotal"].Value = resulta336918c91187c39997885844c207f84[0];
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
private void SubscribeElementEvents_pfa_widgetsubmit (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"PFA_WidgetSubmit-OnClick");
base.WriteDebugInfo(@"EXEC [UpsertProjectFundAllocation] '@@gv_InstanceId','@@gv_ProcessMapId','@@gv_UserId'");

var querySource8C55982FEE834AF1A356390DE5D2877F =GetQueryExpressionDataSource("8C55982F-EE83-4AF1-A356-390DE5D2877F");
Dictionary<short,object> result8C55982FEE834AF1A356390DE5D2877F=iSpace.ExecuteQuery(querySource8C55982FEE834AF1A356390DE5D2877F,@"EXEC [UpsertProjectFundAllocation] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','" + ISpace["gv_userid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource8C55982FEE834AF1A356390DE5D2877F =GetQueryExpressionDataSource(""8C55982F-EE83-4AF1-A356-390DE5D2877F"");Dictionary<short,object> result8C55982FEE834AF1A356390DE5D2877F=iSpace.ExecuteQuery(querySource8C55982FEE834AF1A356390DE5D2877F,@""EXEC [UpsertProjectFundAllocation] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','"" + ISpace[""gv_userid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result8C55982FEE834AF1A356390DE5D2877F!=null) && (result8C55982FEE834AF1A356390DE5D2877F.Count!=0))
{
if(result8C55982FEE834AF1A356390DE5D2877F.ContainsKey(0))
ISpace["PFM_ErrId"].Value = result8C55982FEE834AF1A356390DE5D2877F[0];
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
		if(elementName.ToLower().Equals("mg_d1_amount"))
    {
    			SubscribeElementEvents_mg_d1_amount(ref dfsParam);
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
		if(elementName.ToLower().Equals("fwmf_availablebudget"))
{
			SubscribeElementEvents_fwmf_availablebudget(ref dfsParam);
}
		if(elementName.ToLower().Equals("save_advancerequestdetails"))
{
			SubscribeElementEvents_save_advancerequestdetails(ref dfsParam);
}
		if(elementName.ToLower().Equals("wmf_history"))
{
			SubscribeElementEvents_wmf_history(ref dfsParam);
}
		if(elementName.ToLower().Equals("submitform"))
{
			SubscribeElementEvents_submitform(ref dfsParam);
}
		if(elementName.ToLower().Equals("pfm_yes"))
{
			SubscribeElementEvents_pfm_yes(ref dfsParam);
}
		if(elementName.ToLower().Equals("edit_advancerequestdetails"))
{
			SubscribeElementEvents_edit_advancerequestdetails(ref dfsParam);
}
		if(elementName.ToLower().Equals("pfa_delete"))
{
			SubscribeElementEvents_pfa_delete(ref dfsParam);
}
		if(elementName.ToLower().Equals("pfa_edit"))
{
			SubscribeElementEvents_pfa_edit(ref dfsParam);
}
		if(elementName.ToLower().Equals("fwfm_save"))
{
			SubscribeElementEvents_fwfm_save(ref dfsParam);
}
		if(elementName.ToLower().Equals("pfa_widgetsubmit"))
{
			SubscribeElementEvents_pfa_widgetsubmit(ref dfsParam);
}
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
public class ISpacea07dd4348e7d1a40f53eb3d229e4f878 : VirtualForm
{
IISpace iSpace = new ISpace();
AcDataISpacea07dd4348e7d1a40f53eb3d229e4f878 acdataIspacea07dd4348e7d1a40f53eb3d229e4f878=new AcDataISpacea07dd4348e7d1a40f53eb3d229e4f878();
private void SubscribeFormEvents_root(ref Dictionary<string, ServiceElementData> ISpace)
{
try
{
base.WriteDebugInfo(@"Root-OnAfterFormLoad");

var querySource72ABBA101D3E4391BDBDEBBE0E2E0237 =GetQueryExpressionDataSource("72ABBA10-1D3E-4391-BDBD-EBBE0E2E0237");

DataTable result72ABBA101D3E4391BDBDEBBE0E2E0237=iSpace.SetGridDataSource(querySource72ABBA101D3E4391BDBDEBBE0E2E0237, _objectFactory.GetGridRPP("WMG_CommentsHistory"),@"EXEC [GetInstanceFlowDetais] '" + ISpace["gv_instanceid"].Value + @"'");

iSpace.InsertGridBindDetails("WMG_CommentsHistory","11",querySource72ABBA101D3E4391BDBDEBBE0E2E0237,"EXEC [GetInstanceFlowDetais] '" + ISpace["gv_instanceid"].Value + @"'",_objectFactory.GetGridRPP("WMG_CommentsHistory"));

base.WriteDebugInfo(@"var querySource72ABBA101D3E4391BDBDEBBE0E2E0237 =GetQueryExpressionDataSource(""72ABBA10-1D3E-4391-BDBD-EBBE0E2E0237"");DataTable result72ABBA101D3E4391BDBDEBBE0E2E0237=iSpace.SetGridDataSource(querySource72ABBA101D3E4391BDBDEBBE0E2E0237, _objectFactory.GetGridRPP(""WMG_CommentsHistory""),@""EXEC [GetInstanceFlowDetais] '"" + ISpace[""gv_instanceid""].Value + @""'"");iSpace.InsertGridBindDetails(""WMG_CommentsHistory"",""11"",querySource72ABBA101D3E4391BDBDEBBE0E2E0237,""EXEC [GetInstanceFlowDetais] '"" + ISpace[""gv_instanceid""].Value + @""'"",_objectFactory.GetGridRPP(""WMG_CommentsHistory""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result6DA5E7991709406E85D09DC6581E03C3=acdataIspacea07dd4348e7d1a40f53eb3d229e4f878.GetQueryExpressionBindings("6DA5E799-1709-406E-85D0-9DC6581E03C3");
iSpace.SetGridData(result72ABBA101D3E4391BDBDEBBE0E2E0237,result6DA5E7991709406E85D09DC6581E03C3,"WMG_CommentsHistory",ref ISpace);
iSpace.UpdateGridBindDetails("WMG_CommentsHistory",result6DA5E7991709406E85D09DC6581E03C3);
ISpace["MF_IsAdvance"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MF_IsAdvance""].Enbl=""false"";");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mf_back (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MF_Back-OnClick");

var querySource72ABBA101D3E4391BDBDEBBE0E2E0237 =GetQueryExpressionDataSource("72ABBA10-1D3E-4391-BDBD-EBBE0E2E0237");

DataTable result72ABBA101D3E4391BDBDEBBE0E2E0237=iSpace.SetGridDataSource(querySource72ABBA101D3E4391BDBDEBBE0E2E0237, _objectFactory.GetGridRPP("WMG_CommentsHistory"),@"EXEC [GetInstanceFlowDetais] '" + ISpace["gv_instanceid"].Value + @"'");

iSpace.InsertGridBindDetails("WMG_CommentsHistory","11",querySource72ABBA101D3E4391BDBDEBBE0E2E0237,"EXEC [GetInstanceFlowDetais] '" + ISpace["gv_instanceid"].Value + @"'",_objectFactory.GetGridRPP("WMG_CommentsHistory"));

base.WriteDebugInfo(@"var querySource72ABBA101D3E4391BDBDEBBE0E2E0237 =GetQueryExpressionDataSource(""72ABBA10-1D3E-4391-BDBD-EBBE0E2E0237"");DataTable result72ABBA101D3E4391BDBDEBBE0E2E0237=iSpace.SetGridDataSource(querySource72ABBA101D3E4391BDBDEBBE0E2E0237, _objectFactory.GetGridRPP(""WMG_CommentsHistory""),@""EXEC [GetInstanceFlowDetais] '"" + ISpace[""gv_instanceid""].Value + @""'"");iSpace.InsertGridBindDetails(""WMG_CommentsHistory"",""11"",querySource72ABBA101D3E4391BDBDEBBE0E2E0237,""EXEC [GetInstanceFlowDetais] '"" + ISpace[""gv_instanceid""].Value + @""'"",_objectFactory.GetGridRPP(""WMG_CommentsHistory""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result6DA5E7991709406E85D09DC6581E03C3=acdataIspacea07dd4348e7d1a40f53eb3d229e4f878.GetQueryExpressionBindings("6DA5E799-1709-406E-85D0-9DC6581E03C3");
iSpace.SetGridData(result72ABBA101D3E4391BDBDEBBE0E2E0237,result6DA5E7991709406E85D09DC6581E03C3,"WMG_CommentsHistory",ref ISpace);
iSpace.UpdateGridBindDetails("WMG_CommentsHistory",result6DA5E7991709406E85D09DC6581E03C3);

ISpace["RedirectUrl"].RedirectType="R";
ISpace["RedirectUrl"].Value="?PkActMId=0325353E-7E13-4762-AFC9-88434C58F52C&frmElementId=49A96C7C-D729-40AB-BA35-E48EC2181E2D&PkPrMId=0CC7EA0F-1DD0-4053-9D0E-E7EF819021D7&formVersionId=C935B56C-79C4-4F7E-89BD-5FADD98FC65E&Ver=0.0000";
base.WriteDebugInfo(@"
ISpace[""RedirectUrl""].RedirectType=""R"";
ISpace[""RedirectUrl""].Value=""?PkActMId=0325353E-7E13-4762-AFC9-88434C58F52C&frmElementId=49A96C7C-D729-40AB-BA35-E48EC2181E2D&PkPrMId=0CC7EA0F-1DD0-4053-9D0E-E7EF819021D7&formVersionId=C935B56C-79C4-4F7E-89BD-5FADD98FC65E&Ver=0.0000"";");
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
}
	if(methodName.ToLower().Equals("onclick"))
{
		if(elementName.ToLower().Equals("mf_back"))
{
			SubscribeElementEvents_mf_back(ref dfsParam);
}
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
public class ISpace03b36fe2406e40c3e80749a3e2937922 : VirtualForm
{
IISpace iSpace = new ISpace();
AcDataISpace03b36fe2406e40c3e80749a3e2937922 acdataIspace03b36fe2406e40c3e80749a3e2937922=new AcDataISpace03b36fe2406e40c3e80749a3e2937922();
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
if(ISpace["FormVersionId"].Value=="228701A8-2089-4481-B018-4BE30083D0D9")
{
ISpace["UI_ApprovalHideRow"].Visible="false";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""228701A8-2089-4481-B018-4BE30083D0D9"")
{
ISpace[""UI_ApprovalHideRow""].Visible=""false"";
}");
}
if(ISpace["WF_FlowType"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""WF_FlowType""].Value=="""")");
ISpace["WMF_IsInFlow"].Value=0;
base.WriteDebugInfo(@"ISpace[""WMF_IsInFlow""].Value=0;");
base.WriteDebugInfo(@"EXEC [GetInstanceInFlow] '@@gv_InstanceId'");

var querySource28B5F25AB9D745C8AB83AB07D5048EAD =GetQueryExpressionDataSource("28B5F25A-B9D7-45C8-AB83-AB07D5048EAD");
Dictionary<short,object> result28B5F25AB9D745C8AB83AB07D5048EAD=iSpace.ExecuteQuery(querySource28B5F25AB9D745C8AB83AB07D5048EAD,@"EXEC [GetInstanceInFlow] '" + ISpace["gv_instanceid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource28B5F25AB9D745C8AB83AB07D5048EAD =GetQueryExpressionDataSource(""28B5F25A-B9D7-45C8-AB83-AB07D5048EAD"");Dictionary<short,object> result28B5F25AB9D745C8AB83AB07D5048EAD=iSpace.ExecuteQuery(querySource28B5F25AB9D745C8AB83AB07D5048EAD,@""EXEC [GetInstanceInFlow] '"" + ISpace[""gv_instanceid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result28B5F25AB9D745C8AB83AB07D5048EAD!=null) && (result28B5F25AB9D745C8AB83AB07D5048EAD.Count!=0))
{
if(result28B5F25AB9D745C8AB83AB07D5048EAD.ContainsKey(0))
ISpace["WMF_IsInFlow"].Value = result28B5F25AB9D745C8AB83AB07D5048EAD[0];
}
else{
ISpace["WMF_IsInFlow"].Value = null;
}
if(ISpace["WMF_IsInFlow"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""WMF_IsInFlow""].Value==1)");
ISpace["WF_FlowType"].Value="APPROVE";
base.WriteDebugInfo(@"ISpace[""WF_FlowType""].Value=""APPROVE"";");
ISpace["WMF_History"].Visible="true";ISpace["WMF_MoveTo"].Visible="true";
base.WriteDebugInfo(@"ISpace[""WMF_History""].Visible=""true"";ISpace[""WMF_MoveTo""].Visible=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["WMF_History"].Visible="false";ISpace["WMF_MoveTo"].Visible="false";
base.WriteDebugInfo(@"ISpace[""WMF_History""].Visible=""false"";ISpace[""WMF_MoveTo""].Visible=""false"";");
}
}
ISpace["WMF_MoveTo"].Man=true;
base.WriteDebugInfo(@"ISpace[""WMF_MoveTo""].Man=true;");
ISpace["WMF_MoveTo"].Value="";
base.WriteDebugInfo(@"ISpace[""WMF_MoveTo""].Value="""";");
ISpace["Comments"].Value="";
base.WriteDebugInfo(@"ISpace[""Comments""].Value="""";");

var querySource72ABBA101D3E4391BDBDEBBE0E2E0237 =GetQueryExpressionDataSource("72ABBA10-1D3E-4391-BDBD-EBBE0E2E0237");

DataTable result72ABBA101D3E4391BDBDEBBE0E2E0237=iSpace.SetGridDataSource(querySource72ABBA101D3E4391BDBDEBBE0E2E0237, _objectFactory.GetGridRPP("WMG_CommentsHistory"),@"EXEC [GetInstanceFlowDetais] '" + ISpace["gv_instanceid"].Value + @"'");

iSpace.InsertGridBindDetails("WMG_CommentsHistory","11",querySource72ABBA101D3E4391BDBDEBBE0E2E0237,"EXEC [GetInstanceFlowDetais] '" + ISpace["gv_instanceid"].Value + @"'",_objectFactory.GetGridRPP("WMG_CommentsHistory"));

base.WriteDebugInfo(@"var querySource72ABBA101D3E4391BDBDEBBE0E2E0237 =GetQueryExpressionDataSource(""72ABBA10-1D3E-4391-BDBD-EBBE0E2E0237"");DataTable result72ABBA101D3E4391BDBDEBBE0E2E0237=iSpace.SetGridDataSource(querySource72ABBA101D3E4391BDBDEBBE0E2E0237, _objectFactory.GetGridRPP(""WMG_CommentsHistory""),@""EXEC [GetInstanceFlowDetais] '"" + ISpace[""gv_instanceid""].Value + @""'"");iSpace.InsertGridBindDetails(""WMG_CommentsHistory"",""11"",querySource72ABBA101D3E4391BDBDEBBE0E2E0237,""EXEC [GetInstanceFlowDetais] '"" + ISpace[""gv_instanceid""].Value + @""'"",_objectFactory.GetGridRPP(""WMG_CommentsHistory""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result6DA5E7991709406E85D09DC6581E03C3=acdataIspace03b36fe2406e40c3e80749a3e2937922.GetQueryExpressionBindings("6DA5E799-1709-406E-85D0-9DC6581E03C3");
iSpace.SetGridData(result72ABBA101D3E4391BDBDEBBE0E2E0237,result6DA5E7991709406E85D09DC6581E03C3,"WMG_CommentsHistory",ref ISpace);
iSpace.UpdateGridBindDetails("WMG_CommentsHistory",result6DA5E7991709406E85D09DC6581E03C3);
ISpace["MF_IsAdvance"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MF_IsAdvance""].Enbl=""false"";");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_wmf_history (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"WMF_History-OnClick");

var querySource72ABBA101D3E4391BDBDEBBE0E2E0237 =GetQueryExpressionDataSource("72ABBA10-1D3E-4391-BDBD-EBBE0E2E0237");

DataTable result72ABBA101D3E4391BDBDEBBE0E2E0237=iSpace.SetGridDataSource(querySource72ABBA101D3E4391BDBDEBBE0E2E0237, _objectFactory.GetGridRPP("WMG_CommentsHistory"),@"EXEC [GetInstanceFlowDetais] '" + ISpace["gv_instanceid"].Value + @"'");

iSpace.InsertGridBindDetails("WMG_CommentsHistory","11",querySource72ABBA101D3E4391BDBDEBBE0E2E0237,"EXEC [GetInstanceFlowDetais] '" + ISpace["gv_instanceid"].Value + @"'",_objectFactory.GetGridRPP("WMG_CommentsHistory"));

base.WriteDebugInfo(@"var querySource72ABBA101D3E4391BDBDEBBE0E2E0237 =GetQueryExpressionDataSource(""72ABBA10-1D3E-4391-BDBD-EBBE0E2E0237"");DataTable result72ABBA101D3E4391BDBDEBBE0E2E0237=iSpace.SetGridDataSource(querySource72ABBA101D3E4391BDBDEBBE0E2E0237, _objectFactory.GetGridRPP(""WMG_CommentsHistory""),@""EXEC [GetInstanceFlowDetais] '"" + ISpace[""gv_instanceid""].Value + @""'"");iSpace.InsertGridBindDetails(""WMG_CommentsHistory"",""11"",querySource72ABBA101D3E4391BDBDEBBE0E2E0237,""EXEC [GetInstanceFlowDetais] '"" + ISpace[""gv_instanceid""].Value + @""'"",_objectFactory.GetGridRPP(""WMG_CommentsHistory""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result6DA5E7991709406E85D09DC6581E03C3=acdataIspace03b36fe2406e40c3e80749a3e2937922.GetQueryExpressionBindings("6DA5E799-1709-406E-85D0-9DC6581E03C3");
iSpace.SetGridData(result72ABBA101D3E4391BDBDEBBE0E2E0237,result6DA5E7991709406E85D09DC6581E03C3,"WMG_CommentsHistory",ref ISpace);
iSpace.UpdateGridBindDetails("WMG_CommentsHistory",result6DA5E7991709406E85D09DC6581E03C3);
ISpace["UI_History"].ShowDialog=true;;
base.WriteDebugInfo(@"ISpace[""UI_History""].ShowDialog=true;;");
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
if(ISpace["WF_FlowType"].Value=="APPROVE")
{
base.WriteDebugInfo(@"if(ISpace[""WF_FlowType""].Value==""APPROVE"")");
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
if(ISpace["WF_FlowType"].Value=="RETURN" || ISpace["WF_FlowType"].Value=="REJECT")
{
base.WriteDebugInfo(@"if(ISpace[""WF_FlowType""].Value==""RETURN"" || ISpace[""WF_FlowType""].Value==""REJECT"")");
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
ISpace["Message"].Value=@"Success: Submitted Successfully";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Success: Submitted Successfully"";");

ISpace["RedirectUrl"].RedirectType="R";
ISpace["RedirectUrl"].Value="/Inbox";
base.WriteDebugInfo(@"
ISpace[""RedirectUrl""].RedirectType=""R"";
ISpace[""RedirectUrl""].Value=""/Inbox"";");
if(ISpace["WF_FlowType"].Value=="REJECT"||ISpace["WF_FlowType"].Value=="RETURN")
{
base.WriteDebugInfo(@"if(ISpace[""WF_FlowType""].Value==""REJECT""||ISpace[""WF_FlowType""].Value==""RETURN"")");
base.WriteDebugInfo(@"EXEC [UpdateTemporaryAdvanceStatus] '@@gv_InstanceId','#WF_FlowType','@@gv_UserId'");

var querySource4fc913b439b349cfb675a463ca4816fc =GetQueryExpressionDataSource("4fc913b4-39b3-49cf-b675-a463ca4816fc");
Dictionary<short,object> result4fc913b439b349cfb675a463ca4816fc=iSpace.ExecuteQuery(querySource4fc913b439b349cfb675a463ca4816fc,@"EXEC [UpdateTemporaryAdvanceStatus] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["WF_FlowType"].Value + @"','" + ISpace["gv_userid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource4fc913b439b349cfb675a463ca4816fc =GetQueryExpressionDataSource(""4fc913b4-39b3-49cf-b675-a463ca4816fc"");Dictionary<short,object> result4fc913b439b349cfb675a463ca4816fc=iSpace.ExecuteQuery(querySource4fc913b439b349cfb675a463ca4816fc,@""EXEC [UpdateTemporaryAdvanceStatus] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""WF_FlowType""].Value + @""','"" + ISpace[""gv_userid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result4fc913b439b349cfb675a463ca4816fc!=null) && (result4fc913b439b349cfb675a463ca4816fc.Count!=0))
{
if(result4fc913b439b349cfb675a463ca4816fc.ContainsKey(0))
ISpace["MF_ErrId"].Value = result4fc913b439b349cfb675a463ca4816fc[0];
}
else{
ISpace["MF_ErrId"].Value = null;
}
}
if(ISpace["WF_FlowType"].Value=="APPROVE")
{
base.WriteDebugInfo(@"if(ISpace[""WF_FlowType""].Value==""APPROVE"")");
base.WriteDebugInfo(@"EXEC [UpdateTemporaryAdvanceStatus] '@@gv_InstanceId','#WF_FlowType','@@gv_UserId'");

var querySourcecee2ac3b0dc39e959e1ee293da8d4c69 =GetQueryExpressionDataSource("cee2ac3b-0dc3-9e95-9e1e-e293da8d4c69");
Dictionary<short,object> resultcee2ac3b0dc39e959e1ee293da8d4c69=iSpace.ExecuteQuery(querySourcecee2ac3b0dc39e959e1ee293da8d4c69,@"EXEC [UpdateTemporaryAdvanceStatus] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["WF_FlowType"].Value + @"','" + ISpace["gv_userid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourcecee2ac3b0dc39e959e1ee293da8d4c69 =GetQueryExpressionDataSource(""cee2ac3b-0dc3-9e95-9e1e-e293da8d4c69"");Dictionary<short,object> resultcee2ac3b0dc39e959e1ee293da8d4c69=iSpace.ExecuteQuery(querySourcecee2ac3b0dc39e959e1ee293da8d4c69,@""EXEC [UpdateTemporaryAdvanceStatus] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""WF_FlowType""].Value + @""','"" + ISpace[""gv_userid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultcee2ac3b0dc39e959e1ee293da8d4c69!=null) && (resultcee2ac3b0dc39e959e1ee293da8d4c69.Count!=0))
{
if(resultcee2ac3b0dc39e959e1ee293da8d4c69.ContainsKey(0))
ISpace["MF_ErrId"].Value = resultcee2ac3b0dc39e959e1ee293da8d4c69[0];
}
else{
ISpace["MF_ErrId"].Value = null;
}
}
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
ISpace["WF_FlowType"].Value="APPROVE";
base.WriteDebugInfo(@"ISpace[""WF_FlowType""].Value=""APPROVE"";");
ISpace["Comments"].Man=false;
base.WriteDebugInfo(@"ISpace[""Comments""].Man=false;");
}
if(ISpace["WMF_MoveTo"].Value=="RETURN")
{
base.WriteDebugInfo(@"if(ISpace[""WMF_MoveTo""].Value==""RETURN"")");
ISpace["WF_FlowType"].Value="RETURN";
base.WriteDebugInfo(@"ISpace[""WF_FlowType""].Value=""RETURN"";");
ISpace["Comments"].Man=true;
base.WriteDebugInfo(@"ISpace[""Comments""].Man=true;");
}
if(ISpace["WMF_MoveTo"].Value=="REJECT")
{
base.WriteDebugInfo(@"if(ISpace[""WMF_MoveTo""].Value==""REJECT"")");
ISpace["WF_FlowType"].Value="REJECT";
base.WriteDebugInfo(@"ISpace[""WF_FlowType""].Value=""REJECT"";");
ISpace["Comments"].Man=true;
base.WriteDebugInfo(@"ISpace[""Comments""].Man=true;");
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
		if(elementName.ToLower().Equals("wmf_moveto"))
    {
    			SubscribeElementEvents_wmf_moveto(ref dfsParam);
    }
}
	if(methodName.ToLower().Equals("onclick"))
{
		if(elementName.ToLower().Equals("wmf_history"))
{
			SubscribeElementEvents_wmf_history(ref dfsParam);
}
		if(elementName.ToLower().Equals("submitform"))
{
			SubscribeElementEvents_submitform(ref dfsParam);
}
}
}
}
}

  







namespace CPS.Proof.DFSExtension
{
	
using System;
    using System.Collections.Generic;    
    using System.Text;	
    using System.Linq;	


	public partial class AcDataISpaceA8D5026A49FD44A0BEBEAA595B40C453  : ExtensionActivityBase
	{		
		
		
		private Dictionary<string,  List<Triplet<string, short, short?>>> queryExpressionBindings = 
											new Dictionary<string,  List<Triplet<string, short, short?>>>
		{
							{"E68499CC-18EA-4A0D-A7CA-6DCAB40CD25C", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("PAB_BudgetName",0,
														   -1),
								   new Triplet<string, short, short?>("PAB_RecievedAmount",3,
														   -1),
								   new Triplet<string, short, short?>("PAB_Commitment",4,
														   -1),
								   new Triplet<string, short, short?>("PAB_YetToRecieve",2,
														   -1),
								   new Triplet<string, short, short?>("PAB_Balance",6,
														   -1),
								   new Triplet<string, short, short?>("PAB_SanctionedAmount",1,
														   -1),
								   new Triplet<string, short, short?>("PAB_Spent",5,
														   -1),
								}
			},
							{"1724FDC9-047B-45B8-BCFE-DD14A7738AD2", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("PFA_BudgetHeadValue",10,
														   -1),
								   new Triplet<string, short, short?>("MG_FundAllocation_RowId",3,
														   -1),
								   new Triplet<string, short, short?>("PFA_FundDetailsId",12,
														   -1),
								   new Triplet<string, short, short?>("PFA_Amount",11,
														   -1),
								   new Triplet<string, short, short?>("PFA_ProjectNo",7,
														   -1),
								   new Triplet<string, short, short?>("PFA_BudgetHead",9,
														   -1),
								   new Triplet<string, short, short?>("PFA_FundType",5,
														   -1),
								   new Triplet<string, short, short?>("PFA_ProjectNoValue",8,
														   -1),
								   new Triplet<string, short, short?>("PFA_FundTypeValue",6,
														   -1),
								}
			},
							{"67DEF8CB-D031-4FD4-8DC9-43298D811794", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_d1_Amount",4,
														   -1),
								   new Triplet<string, short, short?>("MG_d1_ItemDescription",3,
														   -1),
								   new Triplet<string, short, short?>("MG_d1_AdvanceFormId",1,
														   -1),
								   new Triplet<string, short, short?>("MG_d1_ExpenseDetails",2,
														   -1),
								   new Triplet<string, short, short?>("MG_d1_RequestDetailsId",0,
														   -1),
								   new Triplet<string, short, short?>("AdvanceRequestDetails_RowId",5,
														   -1),
								}
			},
							{"3C6C0407-FD5F-467B-A727-88C4152BA19E", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_d1_RequestDetailsId",0,
														   -1),
								   new Triplet<string, short, short?>("AdvanceRequestDetails_RowId",5,
														   -1),
								   new Triplet<string, short, short?>("MG_d1_Amount",4,
														   -1),
								   new Triplet<string, short, short?>("MG_d1_AdvanceFormId",1,
														   -1),
								   new Triplet<string, short, short?>("MG_d1_ItemDescription",3,
														   -1),
								   new Triplet<string, short, short?>("MG_d1_ExpenseDetails",2,
														   -1),
								}
			},
							{"29799922-89B5-4073-A780-6510276859B5", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_d1_ExpenseDetails",2,
														   -1),
								   new Triplet<string, short, short?>("AdvanceRequestDetails_RowId",5,
														   -1),
								   new Triplet<string, short, short?>("MG_d1_AdvanceFormId",1,
														   -1),
								   new Triplet<string, short, short?>("MG_d1_ItemDescription",3,
														   -1),
								   new Triplet<string, short, short?>("MG_d1_Amount",4,
														   -1),
								   new Triplet<string, short, short?>("MG_d1_RequestDetailsId",0,
														   -1),
								}
			},
							{"6DA5E799-1709-406E-85D0-9DC6581E03C3", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("WMC_StepFrom",1,
														   -1),
								   new Triplet<string, short, short?>("WMC_Comments",5,
														   -1),
								   new Triplet<string, short, short?>("WMC_User",3,
														   -1),
								   new Triplet<string, short, short?>("WMC_DateofComments",4,
														   -1),
								   new Triplet<string, short, short?>("WMC_StepTo",2,
														   -1),
								}
			},
					};	

	

		private Dictionary<string,string> formVersionList =new Dictionary<string,string> 
		{
							{"228701A8-2089-4481-B018-4BE30083D0D9", "Medium"},
					};	

		
		private Dictionary<string,string> formVersionLayoutList =new Dictionary<string,string> 
		{
							{"B7E068EE-2463-488C-B7BC-C3BBFC09B186", ""},
							{"0BE40B2A-B940-4C15-9C4B-E4601D03D550", ""},
							{"228701A8-2089-4481-B018-4BE30083D0D9", ""},
							{"4DF1F6E4-026B-4FD6-9D7C-F333D11A03F1", ""},
							{"1542763D-3220-4A1F-9722-096E22FE41E7", ""},
							{"827211D5-FBC5-4F7B-8428-8185241C3202", ""},
							{"7E070B18-F1B6-4A50-9292-A61EFE6597BE", ""},
							{"0F5E7699-3AF1-4BD5-8E96-6025BA8386BD", ""},
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


	public partial class AcDataISpaceB7191F8399C7433E8CACB4D23CA6AB2E  : ExtensionActivityBase
	{		
		
		
		private Dictionary<string,  List<Triplet<string, short, short?>>> queryExpressionBindings = 
											new Dictionary<string,  List<Triplet<string, short, short?>>>
		{
							{"E68499CC-18EA-4A0D-A7CA-6DCAB40CD25C", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("PAB_BudgetName",0,
														   -1),
								   new Triplet<string, short, short?>("PAB_RecievedAmount",3,
														   -1),
								   new Triplet<string, short, short?>("PAB_Commitment",4,
														   -1),
								   new Triplet<string, short, short?>("PAB_YetToRecieve",2,
														   -1),
								   new Triplet<string, short, short?>("PAB_Balance",6,
														   -1),
								   new Triplet<string, short, short?>("PAB_SanctionedAmount",1,
														   -1),
								   new Triplet<string, short, short?>("PAB_Spent",5,
														   -1),
								}
			},
							{"1724FDC9-047B-45B8-BCFE-DD14A7738AD2", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("PFA_BudgetHeadValue",10,
														   -1),
								   new Triplet<string, short, short?>("MG_FundAllocation_RowId",3,
														   -1),
								   new Triplet<string, short, short?>("PFA_FundDetailsId",12,
														   -1),
								   new Triplet<string, short, short?>("PFA_Amount",11,
														   -1),
								   new Triplet<string, short, short?>("PFA_ProjectNo",7,
														   -1),
								   new Triplet<string, short, short?>("PFA_BudgetHead",9,
														   -1),
								   new Triplet<string, short, short?>("PFA_FundType",5,
														   -1),
								   new Triplet<string, short, short?>("PFA_ProjectNoValue",8,
														   -1),
								   new Triplet<string, short, short?>("PFA_FundTypeValue",6,
														   -1),
								}
			},
							{"6DA5E799-1709-406E-85D0-9DC6581E03C3", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("WMC_StepFrom",1,
														   -1),
								   new Triplet<string, short, short?>("WMC_Comments",5,
														   -1),
								   new Triplet<string, short, short?>("WMC_User",3,
														   -1),
								   new Triplet<string, short, short?>("WMC_DateofComments",4,
														   -1),
								   new Triplet<string, short, short?>("WMC_StepTo",2,
														   -1),
								}
			},
					};	

	

		private Dictionary<string,string> formVersionList =new Dictionary<string,string> 
		{
							{"228701A8-2089-4481-B018-4BE30083D0D9", "Medium"},
					};	

		
		private Dictionary<string,string> formVersionLayoutList =new Dictionary<string,string> 
		{
							{"B7E068EE-2463-488C-B7BC-C3BBFC09B186", ""},
							{"0BE40B2A-B940-4C15-9C4B-E4601D03D550", ""},
							{"228701A8-2089-4481-B018-4BE30083D0D9", ""},
							{"4DF1F6E4-026B-4FD6-9D7C-F333D11A03F1", ""},
							{"1542763D-3220-4A1F-9722-096E22FE41E7", ""},
							{"827211D5-FBC5-4F7B-8428-8185241C3202", ""},
							{"7E070B18-F1B6-4A50-9292-A61EFE6597BE", ""},
							{"0F5E7699-3AF1-4BD5-8E96-6025BA8386BD", ""},
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


	public partial class AcDataISpace1D9F2FB872294AF1A535338A23491654  : ExtensionActivityBase
	{		
		
		
		private Dictionary<string,  List<Triplet<string, short, short?>>> queryExpressionBindings = 
											new Dictionary<string,  List<Triplet<string, short, short?>>>
		{
							{"E68499CC-18EA-4A0D-A7CA-6DCAB40CD25C", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("PAB_BudgetName",0,
														   -1),
								   new Triplet<string, short, short?>("PAB_RecievedAmount",3,
														   -1),
								   new Triplet<string, short, short?>("PAB_Commitment",4,
														   -1),
								   new Triplet<string, short, short?>("PAB_YetToRecieve",2,
														   -1),
								   new Triplet<string, short, short?>("PAB_Balance",6,
														   -1),
								   new Triplet<string, short, short?>("PAB_SanctionedAmount",1,
														   -1),
								   new Triplet<string, short, short?>("PAB_Spent",5,
														   -1),
								}
			},
							{"1724FDC9-047B-45B8-BCFE-DD14A7738AD2", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("PFA_BudgetHeadValue",10,
														   -1),
								   new Triplet<string, short, short?>("MG_FundAllocation_RowId",3,
														   -1),
								   new Triplet<string, short, short?>("PFA_FundDetailsId",12,
														   -1),
								   new Triplet<string, short, short?>("PFA_Amount",11,
														   -1),
								   new Triplet<string, short, short?>("PFA_ProjectNo",7,
														   -1),
								   new Triplet<string, short, short?>("PFA_BudgetHead",9,
														   -1),
								   new Triplet<string, short, short?>("PFA_FundType",5,
														   -1),
								   new Triplet<string, short, short?>("PFA_ProjectNoValue",8,
														   -1),
								   new Triplet<string, short, short?>("PFA_FundTypeValue",6,
														   -1),
								}
			},
							{"6DA5E799-1709-406E-85D0-9DC6581E03C3", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("WMC_StepFrom",1,
														   -1),
								   new Triplet<string, short, short?>("WMC_Comments",5,
														   -1),
								   new Triplet<string, short, short?>("WMC_User",3,
														   -1),
								   new Triplet<string, short, short?>("WMC_DateofComments",4,
														   -1),
								   new Triplet<string, short, short?>("WMC_StepTo",2,
														   -1),
								}
			},
					};	

	

		private Dictionary<string,string> formVersionList =new Dictionary<string,string> 
		{
							{"228701A8-2089-4481-B018-4BE30083D0D9", "Medium"},
					};	

		
		private Dictionary<string,string> formVersionLayoutList =new Dictionary<string,string> 
		{
							{"B7E068EE-2463-488C-B7BC-C3BBFC09B186", ""},
							{"0BE40B2A-B940-4C15-9C4B-E4601D03D550", ""},
							{"228701A8-2089-4481-B018-4BE30083D0D9", ""},
							{"4DF1F6E4-026B-4FD6-9D7C-F333D11A03F1", ""},
							{"1542763D-3220-4A1F-9722-096E22FE41E7", ""},
							{"827211D5-FBC5-4F7B-8428-8185241C3202", ""},
							{"7E070B18-F1B6-4A50-9292-A61EFE6597BE", ""},
							{"0F5E7699-3AF1-4BD5-8E96-6025BA8386BD", ""},
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


	public partial class AcDataISpaceB4D82C893C764D0AAE787B32FD572B8F  : ExtensionActivityBase
	{		
		
		
		private Dictionary<string,  List<Triplet<string, short, short?>>> queryExpressionBindings = 
											new Dictionary<string,  List<Triplet<string, short, short?>>>
		{
							{"E68499CC-18EA-4A0D-A7CA-6DCAB40CD25C", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("PAB_BudgetName",0,
														   -1),
								   new Triplet<string, short, short?>("PAB_RecievedAmount",3,
														   -1),
								   new Triplet<string, short, short?>("PAB_Commitment",4,
														   -1),
								   new Triplet<string, short, short?>("PAB_YetToRecieve",2,
														   -1),
								   new Triplet<string, short, short?>("PAB_Balance",6,
														   -1),
								   new Triplet<string, short, short?>("PAB_SanctionedAmount",1,
														   -1),
								   new Triplet<string, short, short?>("PAB_Spent",5,
														   -1),
								}
			},
							{"1724FDC9-047B-45B8-BCFE-DD14A7738AD2", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("PFA_BudgetHeadValue",10,
														   -1),
								   new Triplet<string, short, short?>("MG_FundAllocation_RowId",3,
														   -1),
								   new Triplet<string, short, short?>("PFA_FundDetailsId",12,
														   -1),
								   new Triplet<string, short, short?>("PFA_Amount",11,
														   -1),
								   new Triplet<string, short, short?>("PFA_ProjectNo",7,
														   -1),
								   new Triplet<string, short, short?>("PFA_BudgetHead",9,
														   -1),
								   new Triplet<string, short, short?>("PFA_FundType",5,
														   -1),
								   new Triplet<string, short, short?>("PFA_ProjectNoValue",8,
														   -1),
								   new Triplet<string, short, short?>("PFA_FundTypeValue",6,
														   -1),
								}
			},
							{"6DA5E799-1709-406E-85D0-9DC6581E03C3", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("WMC_StepFrom",1,
														   -1),
								   new Triplet<string, short, short?>("WMC_Comments",5,
														   -1),
								   new Triplet<string, short, short?>("WMC_User",3,
														   -1),
								   new Triplet<string, short, short?>("WMC_DateofComments",4,
														   -1),
								   new Triplet<string, short, short?>("WMC_StepTo",2,
														   -1),
								}
			},
					};	

	

		private Dictionary<string,string> formVersionList =new Dictionary<string,string> 
		{
							{"228701A8-2089-4481-B018-4BE30083D0D9", "Medium"},
					};	

		
		private Dictionary<string,string> formVersionLayoutList =new Dictionary<string,string> 
		{
							{"B7E068EE-2463-488C-B7BC-C3BBFC09B186", ""},
							{"0BE40B2A-B940-4C15-9C4B-E4601D03D550", ""},
							{"228701A8-2089-4481-B018-4BE30083D0D9", ""},
							{"4DF1F6E4-026B-4FD6-9D7C-F333D11A03F1", ""},
							{"1542763D-3220-4A1F-9722-096E22FE41E7", ""},
							{"827211D5-FBC5-4F7B-8428-8185241C3202", ""},
							{"7E070B18-F1B6-4A50-9292-A61EFE6597BE", ""},
							{"0F5E7699-3AF1-4BD5-8E96-6025BA8386BD", ""},
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


	public partial class AcDataISpace560A61B0D0D94566B1E94190F008BC9E  : ExtensionActivityBase
	{		
		
		
		private Dictionary<string,  List<Triplet<string, short, short?>>> queryExpressionBindings = 
											new Dictionary<string,  List<Triplet<string, short, short?>>>
		{
							{"E68499CC-18EA-4A0D-A7CA-6DCAB40CD25C", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("PAB_BudgetName",0,
														   -1),
								   new Triplet<string, short, short?>("PAB_RecievedAmount",3,
														   -1),
								   new Triplet<string, short, short?>("PAB_Commitment",4,
														   -1),
								   new Triplet<string, short, short?>("PAB_YetToRecieve",2,
														   -1),
								   new Triplet<string, short, short?>("PAB_Balance",6,
														   -1),
								   new Triplet<string, short, short?>("PAB_SanctionedAmount",1,
														   -1),
								   new Triplet<string, short, short?>("PAB_Spent",5,
														   -1),
								}
			},
							{"1724FDC9-047B-45B8-BCFE-DD14A7738AD2", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("PFA_BudgetHeadValue",10,
														   -1),
								   new Triplet<string, short, short?>("MG_FundAllocation_RowId",3,
														   -1),
								   new Triplet<string, short, short?>("PFA_FundDetailsId",12,
														   -1),
								   new Triplet<string, short, short?>("PFA_Amount",11,
														   -1),
								   new Triplet<string, short, short?>("PFA_ProjectNo",7,
														   -1),
								   new Triplet<string, short, short?>("PFA_BudgetHead",9,
														   -1),
								   new Triplet<string, short, short?>("PFA_FundType",5,
														   -1),
								   new Triplet<string, short, short?>("PFA_ProjectNoValue",8,
														   -1),
								   new Triplet<string, short, short?>("PFA_FundTypeValue",6,
														   -1),
								}
			},
							{"6DA5E799-1709-406E-85D0-9DC6581E03C3", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("WMC_StepFrom",1,
														   -1),
								   new Triplet<string, short, short?>("WMC_Comments",5,
														   -1),
								   new Triplet<string, short, short?>("WMC_User",3,
														   -1),
								   new Triplet<string, short, short?>("WMC_DateofComments",4,
														   -1),
								   new Triplet<string, short, short?>("WMC_StepTo",2,
														   -1),
								}
			},
					};	

	

		private Dictionary<string,string> formVersionList =new Dictionary<string,string> 
		{
							{"228701A8-2089-4481-B018-4BE30083D0D9", "Medium"},
					};	

		
		private Dictionary<string,string> formVersionLayoutList =new Dictionary<string,string> 
		{
							{"B7E068EE-2463-488C-B7BC-C3BBFC09B186", ""},
							{"0BE40B2A-B940-4C15-9C4B-E4601D03D550", ""},
							{"228701A8-2089-4481-B018-4BE30083D0D9", ""},
							{"4DF1F6E4-026B-4FD6-9D7C-F333D11A03F1", ""},
							{"1542763D-3220-4A1F-9722-096E22FE41E7", ""},
							{"827211D5-FBC5-4F7B-8428-8185241C3202", ""},
							{"7E070B18-F1B6-4A50-9292-A61EFE6597BE", ""},
							{"0F5E7699-3AF1-4BD5-8E96-6025BA8386BD", ""},
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


	public partial class AcDataISpace9e2f92013447796498b2a3bb336da186  : ExtensionActivityBase
	{		
		
		
		private Dictionary<string,  List<Triplet<string, short, short?>>> queryExpressionBindings = 
											new Dictionary<string,  List<Triplet<string, short, short?>>>
		{
							{"E68499CC-18EA-4A0D-A7CA-6DCAB40CD25C", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("PAB_BudgetName",0,
														   -1),
								   new Triplet<string, short, short?>("PAB_RecievedAmount",3,
														   -1),
								   new Triplet<string, short, short?>("PAB_Commitment",4,
														   -1),
								   new Triplet<string, short, short?>("PAB_YetToRecieve",2,
														   -1),
								   new Triplet<string, short, short?>("PAB_Balance",6,
														   -1),
								   new Triplet<string, short, short?>("PAB_SanctionedAmount",1,
														   -1),
								   new Triplet<string, short, short?>("PAB_Spent",5,
														   -1),
								}
			},
							{"1724FDC9-047B-45B8-BCFE-DD14A7738AD2", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("PFA_BudgetHeadValue",10,
														   -1),
								   new Triplet<string, short, short?>("MG_FundAllocation_RowId",3,
														   -1),
								   new Triplet<string, short, short?>("PFA_FundDetailsId",12,
														   -1),
								   new Triplet<string, short, short?>("PFA_Amount",11,
														   -1),
								   new Triplet<string, short, short?>("PFA_ProjectNo",7,
														   -1),
								   new Triplet<string, short, short?>("PFA_BudgetHead",9,
														   -1),
								   new Triplet<string, short, short?>("PFA_FundType",5,
														   -1),
								   new Triplet<string, short, short?>("PFA_ProjectNoValue",8,
														   -1),
								   new Triplet<string, short, short?>("PFA_FundTypeValue",6,
														   -1),
								}
			},
							{"67DEF8CB-D031-4FD4-8DC9-43298D811794", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_d1_Amount",4,
														   -1),
								   new Triplet<string, short, short?>("MG_d1_ItemDescription",3,
														   -1),
								   new Triplet<string, short, short?>("MG_d1_AdvanceFormId",1,
														   -1),
								   new Triplet<string, short, short?>("MG_d1_ExpenseDetails",2,
														   -1),
								   new Triplet<string, short, short?>("MG_d1_RequestDetailsId",0,
														   -1),
								   new Triplet<string, short, short?>("AdvanceRequestDetails_RowId",5,
														   -1),
								}
			},
							{"3C6C0407-FD5F-467B-A727-88C4152BA19E", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_d1_RequestDetailsId",0,
														   -1),
								   new Triplet<string, short, short?>("AdvanceRequestDetails_RowId",5,
														   -1),
								   new Triplet<string, short, short?>("MG_d1_Amount",4,
														   -1),
								   new Triplet<string, short, short?>("MG_d1_AdvanceFormId",1,
														   -1),
								   new Triplet<string, short, short?>("MG_d1_ItemDescription",3,
														   -1),
								   new Triplet<string, short, short?>("MG_d1_ExpenseDetails",2,
														   -1),
								}
			},
							{"29799922-89B5-4073-A780-6510276859B5", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_d1_ExpenseDetails",2,
														   -1),
								   new Triplet<string, short, short?>("AdvanceRequestDetails_RowId",5,
														   -1),
								   new Triplet<string, short, short?>("MG_d1_AdvanceFormId",1,
														   -1),
								   new Triplet<string, short, short?>("MG_d1_ItemDescription",3,
														   -1),
								   new Triplet<string, short, short?>("MG_d1_Amount",4,
														   -1),
								   new Triplet<string, short, short?>("MG_d1_RequestDetailsId",0,
														   -1),
								}
			},
							{"6DA5E799-1709-406E-85D0-9DC6581E03C3", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("WMC_StepFrom",1,
														   -1),
								   new Triplet<string, short, short?>("WMC_Comments",5,
														   -1),
								   new Triplet<string, short, short?>("WMC_User",3,
														   -1),
								   new Triplet<string, short, short?>("WMC_DateofComments",4,
														   -1),
								   new Triplet<string, short, short?>("WMC_StepTo",2,
														   -1),
								}
			},
					};	

	

		private Dictionary<string,string> formVersionList =new Dictionary<string,string> 
		{
							{"228701A8-2089-4481-B018-4BE30083D0D9", "Medium"},
					};	

		
		private Dictionary<string,string> formVersionLayoutList =new Dictionary<string,string> 
		{
							{"B7E068EE-2463-488C-B7BC-C3BBFC09B186", ""},
							{"0BE40B2A-B940-4C15-9C4B-E4601D03D550", ""},
							{"228701A8-2089-4481-B018-4BE30083D0D9", ""},
							{"4DF1F6E4-026B-4FD6-9D7C-F333D11A03F1", ""},
							{"1542763D-3220-4A1F-9722-096E22FE41E7", ""},
							{"827211D5-FBC5-4F7B-8428-8185241C3202", ""},
							{"7E070B18-F1B6-4A50-9292-A61EFE6597BE", ""},
							{"0F5E7699-3AF1-4BD5-8E96-6025BA8386BD", ""},
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


	public partial class AcDataISpacea07dd4348e7d1a40f53eb3d229e4f878  : ExtensionActivityBase
	{		
		
		
		private Dictionary<string,  List<Triplet<string, short, short?>>> queryExpressionBindings = 
											new Dictionary<string,  List<Triplet<string, short, short?>>>
		{
							{"E68499CC-18EA-4A0D-A7CA-6DCAB40CD25C", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("PAB_BudgetName",0,
														   -1),
								   new Triplet<string, short, short?>("PAB_RecievedAmount",3,
														   -1),
								   new Triplet<string, short, short?>("PAB_Commitment",4,
														   -1),
								   new Triplet<string, short, short?>("PAB_YetToRecieve",2,
														   -1),
								   new Triplet<string, short, short?>("PAB_Balance",6,
														   -1),
								   new Triplet<string, short, short?>("PAB_SanctionedAmount",1,
														   -1),
								   new Triplet<string, short, short?>("PAB_Spent",5,
														   -1),
								}
			},
							{"1724FDC9-047B-45B8-BCFE-DD14A7738AD2", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("PFA_BudgetHeadValue",10,
														   -1),
								   new Triplet<string, short, short?>("MG_FundAllocation_RowId",3,
														   -1),
								   new Triplet<string, short, short?>("PFA_FundDetailsId",12,
														   -1),
								   new Triplet<string, short, short?>("PFA_Amount",11,
														   -1),
								   new Triplet<string, short, short?>("PFA_ProjectNo",7,
														   -1),
								   new Triplet<string, short, short?>("PFA_BudgetHead",9,
														   -1),
								   new Triplet<string, short, short?>("PFA_FundType",5,
														   -1),
								   new Triplet<string, short, short?>("PFA_ProjectNoValue",8,
														   -1),
								   new Triplet<string, short, short?>("PFA_FundTypeValue",6,
														   -1),
								}
			},
							{"6DA5E799-1709-406E-85D0-9DC6581E03C3", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("WMC_StepFrom",1,
														   -1),
								   new Triplet<string, short, short?>("WMC_Comments",5,
														   -1),
								   new Triplet<string, short, short?>("WMC_User",3,
														   -1),
								   new Triplet<string, short, short?>("WMC_DateofComments",4,
														   -1),
								   new Triplet<string, short, short?>("WMC_StepTo",2,
														   -1),
								}
			},
					};	

	

		private Dictionary<string,string> formVersionList =new Dictionary<string,string> 
		{
							{"228701A8-2089-4481-B018-4BE30083D0D9", "Medium"},
					};	

		
		private Dictionary<string,string> formVersionLayoutList =new Dictionary<string,string> 
		{
							{"B7E068EE-2463-488C-B7BC-C3BBFC09B186", ""},
							{"0BE40B2A-B940-4C15-9C4B-E4601D03D550", ""},
							{"228701A8-2089-4481-B018-4BE30083D0D9", ""},
							{"4DF1F6E4-026B-4FD6-9D7C-F333D11A03F1", ""},
							{"1542763D-3220-4A1F-9722-096E22FE41E7", ""},
							{"827211D5-FBC5-4F7B-8428-8185241C3202", ""},
							{"7E070B18-F1B6-4A50-9292-A61EFE6597BE", ""},
							{"0F5E7699-3AF1-4BD5-8E96-6025BA8386BD", ""},
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


	public partial class AcDataISpace03b36fe2406e40c3e80749a3e2937922  : ExtensionActivityBase
	{		
		
		
		private Dictionary<string,  List<Triplet<string, short, short?>>> queryExpressionBindings = 
											new Dictionary<string,  List<Triplet<string, short, short?>>>
		{
							{"E68499CC-18EA-4A0D-A7CA-6DCAB40CD25C", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("PAB_BudgetName",0,
														   -1),
								   new Triplet<string, short, short?>("PAB_RecievedAmount",3,
														   -1),
								   new Triplet<string, short, short?>("PAB_Commitment",4,
														   -1),
								   new Triplet<string, short, short?>("PAB_YetToRecieve",2,
														   -1),
								   new Triplet<string, short, short?>("PAB_Balance",6,
														   -1),
								   new Triplet<string, short, short?>("PAB_SanctionedAmount",1,
														   -1),
								   new Triplet<string, short, short?>("PAB_Spent",5,
														   -1),
								}
			},
							{"1724FDC9-047B-45B8-BCFE-DD14A7738AD2", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("PFA_BudgetHeadValue",10,
														   -1),
								   new Triplet<string, short, short?>("MG_FundAllocation_RowId",3,
														   -1),
								   new Triplet<string, short, short?>("PFA_FundDetailsId",12,
														   -1),
								   new Triplet<string, short, short?>("PFA_Amount",11,
														   -1),
								   new Triplet<string, short, short?>("PFA_ProjectNo",7,
														   -1),
								   new Triplet<string, short, short?>("PFA_BudgetHead",9,
														   -1),
								   new Triplet<string, short, short?>("PFA_FundType",5,
														   -1),
								   new Triplet<string, short, short?>("PFA_ProjectNoValue",8,
														   -1),
								   new Triplet<string, short, short?>("PFA_FundTypeValue",6,
														   -1),
								}
			},
							{"6DA5E799-1709-406E-85D0-9DC6581E03C3", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("WMC_StepFrom",1,
														   -1),
								   new Triplet<string, short, short?>("WMC_Comments",5,
														   -1),
								   new Triplet<string, short, short?>("WMC_User",3,
														   -1),
								   new Triplet<string, short, short?>("WMC_DateofComments",4,
														   -1),
								   new Triplet<string, short, short?>("WMC_StepTo",2,
														   -1),
								}
			},
					};	

	

		private Dictionary<string,string> formVersionList =new Dictionary<string,string> 
		{
							{"228701A8-2089-4481-B018-4BE30083D0D9", "Medium"},
					};	

		
		private Dictionary<string,string> formVersionLayoutList =new Dictionary<string,string> 
		{
							{"B7E068EE-2463-488C-B7BC-C3BBFC09B186", ""},
							{"0BE40B2A-B940-4C15-9C4B-E4601D03D550", ""},
							{"228701A8-2089-4481-B018-4BE30083D0D9", ""},
							{"4DF1F6E4-026B-4FD6-9D7C-F333D11A03F1", ""},
							{"1542763D-3220-4A1F-9722-096E22FE41E7", ""},
							{"827211D5-FBC5-4F7B-8428-8185241C3202", ""},
							{"7E070B18-F1B6-4A50-9292-A61EFE6597BE", ""},
							{"0F5E7699-3AF1-4BD5-8E96-6025BA8386BD", ""},
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
		


