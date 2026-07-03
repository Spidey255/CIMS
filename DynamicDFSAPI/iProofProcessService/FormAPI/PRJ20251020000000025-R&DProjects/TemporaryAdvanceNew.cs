  







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
	  			
			     new Triplet<string, string, string>("36863A00-4BD9-41A9-A0FB-C2F47F868AA0","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("98506AC4-84B7-49E6-9157-FB6544F32BA6","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("64EF1109-C651-4A09-989F-96AEFA3742A3","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("01A75073-8590-4D43-9FD9-85E2AEE26529","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("657786C0-1E4B-4AEF-BBFF-7FFD347947CD","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("0A6D4BD3-999E-458E-B930-6B42970476DD","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"24F5D845-D560-4FC1-B284-00FB19DFB96F"),
			
						
			     new Triplet<string, string, string>("29CE51BC-9310-456E-84FA-C3692433C21E","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("B6975CE7-CE56-4E4D-B7CC-2B1863890CE7","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("12B66D35-A053-438B-9110-0B443123FA0C","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("7BF46FF1-D824-4E8D-9C42-5614C20F2357","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("60809728-D8A9-4589-B22D-48DE6409B547","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("4CA3178A-7212-4B35-B354-A6CC18BA475A","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"24F5D845-D560-4FC1-B284-00FB19DFB96F"),
			
						
			     new Triplet<string, string, string>("457DF483-4660-42DA-82EB-1BA15638CB37","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"24F5D845-D560-4FC1-B284-00FB19DFB96F"),
			
						
			     new Triplet<string, string, string>("98506AC4-84B7-49E6-9157-FB6544F32BA6","Load Commitments",
												     @"BD505890-FDA1-4D13-9B3D-D0E4D803631E"),
			
						
			     new Triplet<string, string, string>("64EF1109-C651-4A09-989F-96AEFA3742A3","Load Fund Details",
												     @"5375CB33-D51A-4835-AF22-FE5987729892"),
			
						
			     new Triplet<string, string, string>("60809728-D8A9-4589-B22D-48DE6409B547","Load Grid By IdAdvanceRequestDetails",
												     @"0337B98B-59FA-46DC-87A0-89AA288D41AC"),
			
						
			     new Triplet<string, string, string>("4CA3178A-7212-4B35-B354-A6CC18BA475A","Grid Binding3",
												     @"0337B98B-59FA-46DC-87A0-89AA288D41AC"),
			
						
			     new Triplet<string, string, string>("457DF483-4660-42DA-82EB-1BA15638CB37","Grid Binding4",
												     @"0337B98B-59FA-46DC-87A0-89AA288D41AC"),
			
			
			
		};

		
		private List<Triplet<string, string, string>> ComboDataSource = new List<Triplet<string, string, string>>
		{

		
	  			
			     new Triplet<string, string, string>("FWAB_ProjectNo","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMAqCwOWy+D7Ogje1I4jfjiAZNrjEazgaNyfBj9pr2u90lOsHzRNfKnSybWqRxrZGqV",
												     @"EXEC GetProjectExtensionDetails 1,'@PFMF_UserId'"),
			
						
			     new Triplet<string, string, string>("FWFM_FundType","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMA18yFT7KruzVDa0TqsqpOM+grujzoqor1KqRIderPPsozBAr7TiIaPx7MYO2zQclV",
												     @"exec SP_GetDistrubitionDetails 4,'@PFMF_PackageProcessMapId','',''"),
			
						
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
		
	  			
			     new Tuple<string, int>("MG_AvailableBudget",5),
			
						
			     new Tuple<string, int>("MG_FundAllocation",5),
			
						
			     new Tuple<string, int>("MG_RequiredDocuments",5),
			
						
			     new Tuple<string, int>("AdvanceRequestDetails",5),
			
						
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
                     
                                     fInsertQuery=@"IF NOT EXISTS(SELECT 1 FROM [744F780C-12D2-41D3-9084-6E903A527934] WHERE InstanceId='{0}') BEGIN INSERT INTO [744F780C-12D2-41D3-9084-6E903A527934](ProcessActivityMapId,FormId,FWFM_FundDetailsId,FWFM_FundType,FWFM_ProjectNo,FWFM_BudgetHead,FWFM_Amount,PFMF_PackageProcessMapId,FWAB_ProjectNo,PFMF_UserId,PFM_ErrId,PFM_ErrMsg,PFM_FundDetailsId,MF_EmployeeId,MF_EmployeeName,MF_Designation,MF_Department,Subject,ExecutionStatus,ExecutionMessage,SetDestinationTo,SLATime,MF_d2_AdvanceFormId,MF_d2_EmployeeBasicInfoId,MF_d2_TotalAmount,MF_d2_Initiatedon,MF_d2_InitatedBy,MF_d2_ApplicationStatus,MF_d2_UpdatedBy,MF_d2_UpdatedOn,AssignToRole,AssignToUser,IN_Priority,IN_InstanceName,IN_SLA,IN_Status,IN_Category,ExecuteCommand,RedirectUrl,Thumbnail,CancelRedirectUrl,KeyContext,DisplayContext,growid,InstanceId)
							VALUES( {3}) END ELSE BEGIN UPDATE [744F780C-12D2-41D3-9084-6E903A527934]SET {4}WHERE InstanceId='{0}'END ";

                                     colList=@"ProcessActivityMapId,FormId,FWFM_FundDetailsId,FWFM_FundType,FWFM_ProjectNo,FWFM_BudgetHead,FWFM_Amount,PFMF_PackageProcessMapId,FWAB_ProjectNo,PFMF_UserId,PFM_ErrId,PFM_ErrMsg,PFM_FundDetailsId,MF_EmployeeId,MF_EmployeeName,MF_Designation,MF_Department,Subject,ExecutionStatus,ExecutionMessage,SetDestinationTo,SLATime,MF_d2_AdvanceFormId,MF_d2_EmployeeBasicInfoId,MF_d2_TotalAmount,MF_d2_Initiatedon,MF_d2_InitatedBy,MF_d2_ApplicationStatus,MF_d2_UpdatedBy,MF_d2_UpdatedOn,AssignToRole,AssignToUser,IN_Priority,IN_InstanceName,IN_SLA,IN_Status,IN_Category,ExecuteCommand,RedirectUrl,Thumbnail,CancelRedirectUrl,KeyContext,DisplayContext,growid,InstanceId";
                                    
                     
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

                
                 
                                      case "5375CB33-D51A-4835-AF22-FE5987729892":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_5375CB33D51A4835AF22FE5987729892 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [PFA_FundType] VARCHAR(MAX)	, [PFA_FundTypeValue] VARCHAR(MAX)	, [PFA_ProjectNo] VARCHAR(MAX)	, [PFA_ProjectNoValue] VARCHAR(MAX)	, [PFA_BudgetHead] VARCHAR(MAX)	, [PFA_BudgetHeadValue] VARCHAR(MAX)	, [PFA_Amount] DECIMAL(18,2)	, [PFA_FundDetailsId] VARCHAR(MAX)){0}INSERT INTO [5375CB33-D51A-4835-AF22-FE5987729892](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PFA_FundType,PFA_FundTypeValue,PFA_ProjectNo,PFA_ProjectNoValue,PFA_BudgetHead,PFA_BudgetHeadValue,PFA_Amount,PFA_FundDetailsId)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.PFA_FundType,TDT.PFA_FundTypeValue,TDT.PFA_ProjectNo,TDT.PFA_ProjectNoValue,TDT.PFA_BudgetHead,TDT.PFA_BudgetHeadValue,TDT.PFA_Amount,TDT.PFA_FundDetailsId FROM @TBL_5375CB33D51A4835AF22FE5987729892 TDT
							LEFT JOIN [5375CB33-D51A-4835-AF22-FE5987729892] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,PFA_FundType=TDT.PFA_FundType,PFA_FundTypeValue=TDT.PFA_FundTypeValue,PFA_ProjectNo=TDT.PFA_ProjectNo,PFA_ProjectNoValue=TDT.PFA_ProjectNoValue,PFA_BudgetHead=TDT.PFA_BudgetHead,PFA_BudgetHeadValue=TDT.PFA_BudgetHeadValue,PFA_Amount=TDT.PFA_Amount,PFA_FundDetailsId=TDT.PFA_FundDetailsId FROM @TBL_5375CB33D51A4835AF22FE5987729892 TDT
							JOIN [5375CB33-D51A-4835-AF22-FE5987729892] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PFA_FundType,PFA_FundTypeValue,PFA_ProjectNo,PFA_ProjectNoValue,PFA_BudgetHead,PFA_BudgetHeadValue,PFA_Amount,PFA_FundDetailsId";

                                     tempInsertQuery=@"INSERT INTO @TBL_5375CB33D51A4835AF22FE5987729892(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PFA_FundType,PFA_FundTypeValue,PFA_ProjectNo,PFA_ProjectNoValue,PFA_BudgetHead,PFA_BudgetHeadValue,PFA_Amount,PFA_FundDetailsId)VALUES({0});";
                                     

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
                     
                                    case "BD505890-FDA1-4D13-9B3D-D0E4D803631E":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_BD505890FDA14D139B3DD0E4D803631E AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [PAB_BudgetName] VARCHAR(MAX)	, [PAB_SanctionedAmount] DECIMAL(18,2)	, [PAB_YetToRecieve] DECIMAL(18,2)	, [PAB_RecievedAmount] DECIMAL(18,2)	, [PAB_Commitment] DECIMAL(18,2)	, [PAB_Spent] DECIMAL(18,2)	, [PAB_Balance] DECIMAL(18,2)){0}INSERT INTO [BD505890-FDA1-4D13-9B3D-D0E4D803631E](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PAB_BudgetName,PAB_SanctionedAmount,PAB_YetToRecieve,PAB_RecievedAmount,PAB_Commitment,PAB_Spent,PAB_Balance)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.PAB_BudgetName,TDT.PAB_SanctionedAmount,TDT.PAB_YetToRecieve,TDT.PAB_RecievedAmount,TDT.PAB_Commitment,TDT.PAB_Spent,TDT.PAB_Balance FROM @TBL_BD505890FDA14D139B3DD0E4D803631E TDT
							LEFT JOIN [BD505890-FDA1-4D13-9B3D-D0E4D803631E] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,PAB_BudgetName=TDT.PAB_BudgetName,PAB_SanctionedAmount=TDT.PAB_SanctionedAmount,PAB_YetToRecieve=TDT.PAB_YetToRecieve,PAB_RecievedAmount=TDT.PAB_RecievedAmount,PAB_Commitment=TDT.PAB_Commitment,PAB_Spent=TDT.PAB_Spent,PAB_Balance=TDT.PAB_Balance FROM @TBL_BD505890FDA14D139B3DD0E4D803631E TDT
							JOIN [BD505890-FDA1-4D13-9B3D-D0E4D803631E] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PAB_BudgetName,PAB_SanctionedAmount,PAB_YetToRecieve,PAB_RecievedAmount,PAB_Commitment,PAB_Spent,PAB_Balance";

                                     tempInsertQuery=@"INSERT INTO @TBL_BD505890FDA14D139B3DD0E4D803631E(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PAB_BudgetName,PAB_SanctionedAmount,PAB_YetToRecieve,PAB_RecievedAmount,PAB_Commitment,PAB_Spent,PAB_Balance)VALUES({0});";
                                     

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
                     
                                    case "35DD025B-28BD-4CD9-A172-A9495D0CE96C":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_35DD025B28BD4CD9A172A9495D0CE96C AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [PADD_DocumentName] VARCHAR(MAX)	, [PADD_Document] VARCHAR(MAX)){0}INSERT INTO [35DD025B-28BD-4CD9-A172-A9495D0CE96C](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PADD_DocumentName,PADD_Document)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.PADD_DocumentName,TDT.PADD_Document FROM @TBL_35DD025B28BD4CD9A172A9495D0CE96C TDT
							LEFT JOIN [35DD025B-28BD-4CD9-A172-A9495D0CE96C] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,PADD_DocumentName=TDT.PADD_DocumentName,PADD_Document=TDT.PADD_Document FROM @TBL_35DD025B28BD4CD9A172A9495D0CE96C TDT
							JOIN [35DD025B-28BD-4CD9-A172-A9495D0CE96C] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PADD_DocumentName,PADD_Document";

                                     tempInsertQuery=@"INSERT INTO @TBL_35DD025B28BD4CD9A172A9495D0CE96C(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PADD_DocumentName,PADD_Document)VALUES({0});";
                                     

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
                     

                                         case "5375CB33-D51A-4835-AF22-FE5987729892":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_5375CB33D51A4835AF22FE5987729892 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [PFA_FundType] VARCHAR(MAX)	, [PFA_FundTypeValue] VARCHAR(MAX)	, [PFA_ProjectNo] VARCHAR(MAX)	, [PFA_ProjectNoValue] VARCHAR(MAX)	, [PFA_BudgetHead] VARCHAR(MAX)	, [PFA_BudgetHeadValue] VARCHAR(MAX)	, [PFA_Amount] DECIMAL(18,2)	, [PFA_FundDetailsId] VARCHAR(MAX)){0}INSERT INTO [5375CB33-D51A-4835-AF22-FE5987729892](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PFA_FundType,PFA_FundTypeValue,PFA_ProjectNo,PFA_ProjectNoValue,PFA_BudgetHead,PFA_BudgetHeadValue,PFA_Amount,PFA_FundDetailsId)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.PFA_FundType,TDT.PFA_FundTypeValue,TDT.PFA_ProjectNo,TDT.PFA_ProjectNoValue,TDT.PFA_BudgetHead,TDT.PFA_BudgetHeadValue,TDT.PFA_Amount,TDT.PFA_FundDetailsId FROM @TBL_5375CB33D51A4835AF22FE5987729892 TDT
							LEFT JOIN [5375CB33-D51A-4835-AF22-FE5987729892] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,PFA_FundType=TDT.PFA_FundType,PFA_FundTypeValue=TDT.PFA_FundTypeValue,PFA_ProjectNo=TDT.PFA_ProjectNo,PFA_ProjectNoValue=TDT.PFA_ProjectNoValue,PFA_BudgetHead=TDT.PFA_BudgetHead,PFA_BudgetHeadValue=TDT.PFA_BudgetHeadValue,PFA_Amount=TDT.PFA_Amount,PFA_FundDetailsId=TDT.PFA_FundDetailsId FROM @TBL_5375CB33D51A4835AF22FE5987729892 TDT
							JOIN [5375CB33-D51A-4835-AF22-FE5987729892] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PFA_FundType,PFA_FundTypeValue,PFA_ProjectNo,PFA_ProjectNoValue,PFA_BudgetHead,PFA_BudgetHeadValue,PFA_Amount,PFA_FundDetailsId";

                            tempInsertQuery=@"INSERT INTO @TBL_5375CB33D51A4835AF22FE5987729892(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PFA_FundType,PFA_FundTypeValue,PFA_ProjectNo,PFA_ProjectNoValue,PFA_BudgetHead,PFA_BudgetHeadValue,PFA_Amount,PFA_FundDetailsId)VALUES({0});";

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

                                              case "BD505890-FDA1-4D13-9B3D-D0E4D803631E":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_BD505890FDA14D139B3DD0E4D803631E AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [PAB_BudgetName] VARCHAR(MAX)	, [PAB_SanctionedAmount] DECIMAL(18,2)	, [PAB_YetToRecieve] DECIMAL(18,2)	, [PAB_RecievedAmount] DECIMAL(18,2)	, [PAB_Commitment] DECIMAL(18,2)	, [PAB_Spent] DECIMAL(18,2)	, [PAB_Balance] DECIMAL(18,2)){0}INSERT INTO [BD505890-FDA1-4D13-9B3D-D0E4D803631E](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PAB_BudgetName,PAB_SanctionedAmount,PAB_YetToRecieve,PAB_RecievedAmount,PAB_Commitment,PAB_Spent,PAB_Balance)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.PAB_BudgetName,TDT.PAB_SanctionedAmount,TDT.PAB_YetToRecieve,TDT.PAB_RecievedAmount,TDT.PAB_Commitment,TDT.PAB_Spent,TDT.PAB_Balance FROM @TBL_BD505890FDA14D139B3DD0E4D803631E TDT
							LEFT JOIN [BD505890-FDA1-4D13-9B3D-D0E4D803631E] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,PAB_BudgetName=TDT.PAB_BudgetName,PAB_SanctionedAmount=TDT.PAB_SanctionedAmount,PAB_YetToRecieve=TDT.PAB_YetToRecieve,PAB_RecievedAmount=TDT.PAB_RecievedAmount,PAB_Commitment=TDT.PAB_Commitment,PAB_Spent=TDT.PAB_Spent,PAB_Balance=TDT.PAB_Balance FROM @TBL_BD505890FDA14D139B3DD0E4D803631E TDT
							JOIN [BD505890-FDA1-4D13-9B3D-D0E4D803631E] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PAB_BudgetName,PAB_SanctionedAmount,PAB_YetToRecieve,PAB_RecievedAmount,PAB_Commitment,PAB_Spent,PAB_Balance";

                            tempInsertQuery=@"INSERT INTO @TBL_BD505890FDA14D139B3DD0E4D803631E(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PAB_BudgetName,PAB_SanctionedAmount,PAB_YetToRecieve,PAB_RecievedAmount,PAB_Commitment,PAB_Spent,PAB_Balance)VALUES({0});";

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

                                              case "35DD025B-28BD-4CD9-A172-A9495D0CE96C":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_35DD025B28BD4CD9A172A9495D0CE96C AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [PADD_DocumentName] VARCHAR(MAX)	, [PADD_Document] VARCHAR(MAX)){0}INSERT INTO [35DD025B-28BD-4CD9-A172-A9495D0CE96C](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PADD_DocumentName,PADD_Document)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.PADD_DocumentName,TDT.PADD_Document FROM @TBL_35DD025B28BD4CD9A172A9495D0CE96C TDT
							LEFT JOIN [35DD025B-28BD-4CD9-A172-A9495D0CE96C] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,PADD_DocumentName=TDT.PADD_DocumentName,PADD_Document=TDT.PADD_Document FROM @TBL_35DD025B28BD4CD9A172A9495D0CE96C TDT
							JOIN [35DD025B-28BD-4CD9-A172-A9495D0CE96C] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PADD_DocumentName,PADD_Document";

                            tempInsertQuery=@"INSERT INTO @TBL_35DD025B28BD4CD9A172A9495D0CE96C(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PADD_DocumentName,PADD_Document)VALUES({0});";

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
ISpace["FWFM_Amount"].Visible="false";ISpace["FWFM_BudgetHead"].Visible="false";ISpace["FWFM_ProjectNo"].Visible="false";
base.WriteDebugInfo(@"ISpace[""FWFM_Amount""].Visible=""false"";ISpace[""FWFM_BudgetHead""].Visible=""false"";ISpace[""FWFM_ProjectNo""].Visible=""false"";");
}
ISpace["PFMF_PackageProcessMapId"].Value=ISpace["gv_processmapid"].Value;
base.WriteDebugInfo(@"ISpace[""PFMF_PackageProcessMapId""].Value=ISpace[""gv_processmapid""].Value;");
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
private void SubscribeElementEvents_pfm_yes (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"PFM_Yes-OnClick");
base.WriteDebugInfo(@"EXEC [Delete60e821d0-153e_94bb-1fef-2594b78625bd] '@@gv_InstanceId','#PFM_FundDetailsId'");

var querySource01A7507385904D439FD985E2AEE26529 =GetQueryExpressionDataSource("01A75073-8590-4D43-9FD9-85E2AEE26529");
Dictionary<short,object> result01A7507385904D439FD985E2AEE26529=iSpace.ExecuteQuery(querySource01A7507385904D439FD985E2AEE26529,@"EXEC[Delete60e821d0-153e_94bb-1fef-2594b78625bd] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["PFM_FundDetailsId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource01A7507385904D439FD985E2AEE26529 =GetQueryExpressionDataSource(""01A75073-8590-4D43-9FD9-85E2AEE26529"");Dictionary<short,object> result01A7507385904D439FD985E2AEE26529=iSpace.ExecuteQuery(querySource01A7507385904D439FD985E2AEE26529,@""EXEC[Delete60e821d0-153e_94bb-1fef-2594b78625bd] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""PFM_FundDetailsId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result01A7507385904D439FD985E2AEE26529!=null) && (result01A7507385904D439FD985E2AEE26529.Count!=0))
{
if(result01A7507385904D439FD985E2AEE26529.ContainsKey(0))
ISpace["PFM_ErrId"].Value = result01A7507385904D439FD985E2AEE26529[0];
if(result01A7507385904D439FD985E2AEE26529.ContainsKey(1))
ISpace["PFM_ErrMsg"].Value = result01A7507385904D439FD985E2AEE26529[1];
}
else{
ISpace["PFM_ErrId"].Value = null;ISpace["PFM_ErrMsg"].Value = null;
}
ISpace["Message"].Value=String.Format(@"{0}",ISpace["PFM_ErrMsg"].Value);
base.WriteDebugInfo(@"ISpace[""Message""].Value=String.Format(@""{0}"",ISpace[""PFM_ErrMsg""].Value);");

var querySource64EF1109C6514A09989F96AEFA3742A3 =GetQueryExpressionDataSource("64EF1109-C651-4A09-989F-96AEFA3742A3");

DataTable result64EF1109C6514A09989F96AEFA3742A3=iSpace.SetGridDataSource(querySource64EF1109C6514A09989F96AEFA3742A3, _objectFactory.GetGridRPP("MG_FundAllocation"),@"Exec [Get60e821d0-153e-94bb-1fef-2594b78625bd] '" + ISpace["gv_instanceid"].Value + @"'");

iSpace.InsertGridBindDetails("MG_FundAllocation","11",querySource64EF1109C6514A09989F96AEFA3742A3,"Exec [Get60e821d0-153e-94bb-1fef-2594b78625bd] '" + ISpace["gv_instanceid"].Value + @"'",_objectFactory.GetGridRPP("MG_FundAllocation"));

base.WriteDebugInfo(@"var querySource64EF1109C6514A09989F96AEFA3742A3 =GetQueryExpressionDataSource(""64EF1109-C651-4A09-989F-96AEFA3742A3"");DataTable result64EF1109C6514A09989F96AEFA3742A3=iSpace.SetGridDataSource(querySource64EF1109C6514A09989F96AEFA3742A3, _objectFactory.GetGridRPP(""MG_FundAllocation""),@""Exec [Get60e821d0-153e-94bb-1fef-2594b78625bd] '"" + ISpace[""gv_instanceid""].Value + @""'"");iSpace.InsertGridBindDetails(""MG_FundAllocation"",""11"",querySource64EF1109C6514A09989F96AEFA3742A3,""Exec [Get60e821d0-153e-94bb-1fef-2594b78625bd] '"" + ISpace[""gv_instanceid""].Value + @""'"",_objectFactory.GetGridRPP(""MG_FundAllocation""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result176DDF3C96244F1A88E3A914A805752C=acdataIspaceA8D5026A49FD44A0BEBEAA595B40C453.GetQueryExpressionBindings("176DDF3C-9624-4F1A-88E3-A914A805752C");
iSpace.SetGridData(result64EF1109C6514A09989F96AEFA3742A3,result176DDF3C96244F1A88E3A914A805752C,"MG_FundAllocation",ref ISpace);
iSpace.UpdateGridBindDetails("MG_FundAllocation",result176DDF3C96244F1A88E3A914A805752C);
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
private void SubscribeElementEvents_submitform (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"SubmitForm-OnClick");
base.WriteDebugInfo(@"EXEC InnovaceNoCode..[FormSave_744F780C-12D2-41D3-9084-6E903A527934]   '@@gv_InstanceId','@@gv_ActivityMapId','85014d12-a85b-4330-8d7f-29776cbda319','#MF_d2_AdvanceFormId','#MF_d2_EmployeeBasicInfoId',#MF_d2_TotalAmount,'#MF_d2_Initiatedon','#MF_d2_InitatedBy','#MF_d2_ApplicationStatus','#MF_d2_UpdatedBy','#MF_d2_UpdatedOn'");

var querySource29CE51BC9310456E84FAC3692433C21E =GetQueryExpressionDataSource("29CE51BC-9310-456E-84FA-C3692433C21E");
Dictionary<short,object> result29CE51BC9310456E84FAC3692433C21E=iSpace.ExecuteQuery(querySource29CE51BC9310456E84FAC3692433C21E,@"EXEC InnovaceNoCode..[FormSave_744F780C-12D2-41D3-9084-6E903A527934]   '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','85014d12-a85b-4330-8d7f-29776cbda319','" + ISpace["MF_d2_AdvanceFormId"].Value + @"','" + ISpace["MF_d2_EmployeeBasicInfoId"].Value + @"'," + ISpace["MF_d2_TotalAmount"].Value + @",'" + ISpace["MF_d2_Initiatedon"].Value + @"','" + ISpace["MF_d2_InitatedBy"].Value + @"','" + ISpace["MF_d2_ApplicationStatus"].Value + @"','" + ISpace["MF_d2_UpdatedBy"].Value + @"','" + ISpace["MF_d2_UpdatedOn"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource29CE51BC9310456E84FAC3692433C21E =GetQueryExpressionDataSource(""29CE51BC-9310-456E-84FA-C3692433C21E"");Dictionary<short,object> result29CE51BC9310456E84FAC3692433C21E=iSpace.ExecuteQuery(querySource29CE51BC9310456E84FAC3692433C21E,@""EXEC InnovaceNoCode..[FormSave_744F780C-12D2-41D3-9084-6E903A527934]   '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','85014d12-a85b-4330-8d7f-29776cbda319','"" + ISpace[""MF_d2_AdvanceFormId""].Value + @""','"" + ISpace[""MF_d2_EmployeeBasicInfoId""].Value + @""',"" + ISpace[""MF_d2_TotalAmount""].Value + @"",'"" + ISpace[""MF_d2_Initiatedon""].Value + @""','"" + ISpace[""MF_d2_InitatedBy""].Value + @""','"" + ISpace[""MF_d2_ApplicationStatus""].Value + @""','"" + ISpace[""MF_d2_UpdatedBy""].Value + @""','"" + ISpace[""MF_d2_UpdatedOn""].Value + @""'"",false);");
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
ISpace["FWFM_Amount"].Visible="false";ISpace["FWFM_BudgetHead"].Visible="false";ISpace["FWFM_ProjectNo"].Visible="false";
base.WriteDebugInfo(@"ISpace[""FWFM_Amount""].Visible=""false"";ISpace[""FWFM_BudgetHead""].Visible=""false"";ISpace[""FWFM_ProjectNo""].Visible=""false"";");
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

var querySource657786C01E4B4AEFBBFF7FFD347947CD =GetQueryExpressionDataSource("657786C0-1E4B-4AEF-BBFF-7FFD347947CD");
Dictionary<short,object> result657786C01E4B4AEFBBFF7FFD347947CD=iSpace.ExecuteQuery(querySource657786C01E4B4AEFBBFF7FFD347947CD,@"EXEC [Upsert60e821d0-153e-94bb-1fef-2594b78625bd] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','" + ISpace["FWFM_FundDetailsId"].Value + @"','" + ISpace["FWFM_FundType"].Value + @"','" + ISpace["FWFM_ProjectNo"].Value + @"','" + ISpace["FWFM_BudgetHead"].Value + @"','" + ISpace["FWFM_Amount"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource657786C01E4B4AEFBBFF7FFD347947CD =GetQueryExpressionDataSource(""657786C0-1E4B-4AEF-BBFF-7FFD347947CD"");Dictionary<short,object> result657786C01E4B4AEFBBFF7FFD347947CD=iSpace.ExecuteQuery(querySource657786C01E4B4AEFBBFF7FFD347947CD,@""EXEC [Upsert60e821d0-153e-94bb-1fef-2594b78625bd] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','"" + ISpace[""FWFM_FundDetailsId""].Value + @""','"" + ISpace[""FWFM_FundType""].Value + @""','"" + ISpace[""FWFM_ProjectNo""].Value + @""','"" + ISpace[""FWFM_BudgetHead""].Value + @""','"" + ISpace[""FWFM_Amount""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result657786C01E4B4AEFBBFF7FFD347947CD!=null) && (result657786C01E4B4AEFBBFF7FFD347947CD.Count!=0))
{
if(result657786C01E4B4AEFBBFF7FFD347947CD.ContainsKey(0))
ISpace["PFM_ErrId"].Value = result657786C01E4B4AEFBBFF7FFD347947CD[0];
if(result657786C01E4B4AEFBBFF7FFD347947CD.ContainsKey(1))
ISpace["PFM_ErrMsg"].Value = result657786C01E4B4AEFBBFF7FFD347947CD[1];
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

var querySource64EF1109C6514A09989F96AEFA3742A3 =GetQueryExpressionDataSource("64EF1109-C651-4A09-989F-96AEFA3742A3");

DataTable result64EF1109C6514A09989F96AEFA3742A3=iSpace.SetGridDataSource(querySource64EF1109C6514A09989F96AEFA3742A3, _objectFactory.GetGridRPP("MG_FundAllocation"),@"Exec [Get60e821d0-153e-94bb-1fef-2594b78625bd] '" + ISpace["gv_instanceid"].Value + @"'");

iSpace.InsertGridBindDetails("MG_FundAllocation","11",querySource64EF1109C6514A09989F96AEFA3742A3,"Exec [Get60e821d0-153e-94bb-1fef-2594b78625bd] '" + ISpace["gv_instanceid"].Value + @"'",_objectFactory.GetGridRPP("MG_FundAllocation"));

base.WriteDebugInfo(@"var querySource64EF1109C6514A09989F96AEFA3742A3 =GetQueryExpressionDataSource(""64EF1109-C651-4A09-989F-96AEFA3742A3"");DataTable result64EF1109C6514A09989F96AEFA3742A3=iSpace.SetGridDataSource(querySource64EF1109C6514A09989F96AEFA3742A3, _objectFactory.GetGridRPP(""MG_FundAllocation""),@""Exec [Get60e821d0-153e-94bb-1fef-2594b78625bd] '"" + ISpace[""gv_instanceid""].Value + @""'"");iSpace.InsertGridBindDetails(""MG_FundAllocation"",""11"",querySource64EF1109C6514A09989F96AEFA3742A3,""Exec [Get60e821d0-153e-94bb-1fef-2594b78625bd] '"" + ISpace[""gv_instanceid""].Value + @""'"",_objectFactory.GetGridRPP(""MG_FundAllocation""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result176DDF3C96244F1A88E3A914A805752C=acdataIspaceA8D5026A49FD44A0BEBEAA595B40C453.GetQueryExpressionBindings("176DDF3C-9624-4F1A-88E3-A914A805752C");
iSpace.SetGridData(result64EF1109C6514A09989F96AEFA3742A3,result176DDF3C96244F1A88E3A914A805752C,"MG_FundAllocation",ref ISpace);
iSpace.UpdateGridBindDetails("MG_FundAllocation",result176DDF3C96244F1A88E3A914A805752C);
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
private void SubscribeElementEvents_pfa_edit (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"PFA_Edit-OnClick");
base.WriteDebugInfo(@"Exec [Get60e821d0-153e-94bb-1fef-2594b78625bd] '@@gv_InstanceId','#PFA_FundDetailsId'");

var querySource12B66D35A053438B91100B443123FA0C =GetQueryExpressionDataSource("12B66D35-A053-438B-9110-0B443123FA0C");
Dictionary<short,object> result12B66D35A053438B91100B443123FA0C=iSpace.ExecuteQuery(querySource12B66D35A053438B91100B443123FA0C,@"Exec [Get60e821d0-153e-94bb-1fef-2594b78625bd] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["PFA_FundDetailsId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource12B66D35A053438B91100B443123FA0C =GetQueryExpressionDataSource(""12B66D35-A053-438B-9110-0B443123FA0C"");Dictionary<short,object> result12B66D35A053438B91100B443123FA0C=iSpace.ExecuteQuery(querySource12B66D35A053438B91100B443123FA0C,@""Exec [Get60e821d0-153e-94bb-1fef-2594b78625bd] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""PFA_FundDetailsId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result12B66D35A053438B91100B443123FA0C!=null) && (result12B66D35A053438B91100B443123FA0C.Count!=0))
{
if(result12B66D35A053438B91100B443123FA0C.ContainsKey(5))
ISpace["FWFM_FundType"].Value = result12B66D35A053438B91100B443123FA0C[5];
if(result12B66D35A053438B91100B443123FA0C.ContainsKey(9))
ISpace["FWFM_BudgetHead"].Value = result12B66D35A053438B91100B443123FA0C[9];
if(result12B66D35A053438B91100B443123FA0C.ContainsKey(7))
ISpace["FWFM_ProjectNo"].Value = result12B66D35A053438B91100B443123FA0C[7];
if(result12B66D35A053438B91100B443123FA0C.ContainsKey(11))
ISpace["FWFM_Amount"].Value = result12B66D35A053438B91100B443123FA0C[11];
if(result12B66D35A053438B91100B443123FA0C.ContainsKey(3))
ISpace["FWFM_FundDetailsId"].Value = result12B66D35A053438B91100B443123FA0C[3];
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
private void SubscribeElementEvents_pfa_widgetsubmit (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"PFA_WidgetSubmit-OnClick");
base.WriteDebugInfo(@"EXEC [UpsertProjectFundAllocation] '@@gv_InstanceId','@@gv_ProcessMapId','@@gv_UserId'");

var querySource36863A004BD941A9A0FBC2F47F868AA0 =GetQueryExpressionDataSource("36863A00-4BD9-41A9-A0FB-C2F47F868AA0");
Dictionary<short,object> result36863A004BD941A9A0FBC2F47F868AA0=iSpace.ExecuteQuery(querySource36863A004BD941A9A0FBC2F47F868AA0,@"EXEC [UpsertProjectFundAllocation] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','" + ISpace["gv_userid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource36863A004BD941A9A0FBC2F47F868AA0 =GetQueryExpressionDataSource(""36863A00-4BD9-41A9-A0FB-C2F47F868AA0"");Dictionary<short,object> result36863A004BD941A9A0FBC2F47F868AA0=iSpace.ExecuteQuery(querySource36863A004BD941A9A0FBC2F47F868AA0,@""EXEC [UpsertProjectFundAllocation] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','"" + ISpace[""gv_userid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result36863A004BD941A9A0FBC2F47F868AA0!=null) && (result36863A004BD941A9A0FBC2F47F868AA0.Count!=0))
{
if(result36863A004BD941A9A0FBC2F47F868AA0.ContainsKey(0))
ISpace["PFM_ErrId"].Value = result36863A004BD941A9A0FBC2F47F868AA0[0];
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
}
	if(methodName.ToLower().Equals("onclick"))
{
		if(elementName.ToLower().Equals("save_advancerequestdetails"))
{
			SubscribeElementEvents_save_advancerequestdetails(ref dfsParam);
}
		if(elementName.ToLower().Equals("pfm_yes"))
{
			SubscribeElementEvents_pfm_yes(ref dfsParam);
}
		if(elementName.ToLower().Equals("submitform"))
{
			SubscribeElementEvents_submitform(ref dfsParam);
}
		if(elementName.ToLower().Equals("pfa_delete"))
{
			SubscribeElementEvents_pfa_delete(ref dfsParam);
}
		if(elementName.ToLower().Equals("fwfm_save"))
{
			SubscribeElementEvents_fwfm_save(ref dfsParam);
}
		if(elementName.ToLower().Equals("edit_advancerequestdetails"))
{
			SubscribeElementEvents_edit_advancerequestdetails(ref dfsParam);
}
		if(elementName.ToLower().Equals("pfm_no"))
{
			SubscribeElementEvents_pfm_no(ref dfsParam);
}
		if(elementName.ToLower().Equals("pfa_edit"))
{
			SubscribeElementEvents_pfa_edit(ref dfsParam);
}
		if(elementName.ToLower().Equals("fwmf_availablebudget"))
{
			SubscribeElementEvents_fwmf_availablebudget(ref dfsParam);
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


	public partial class AcDataISpaceA8D5026A49FD44A0BEBEAA595B40C453  : ExtensionActivityBase
	{		
		
		
		private Dictionary<string,  List<Triplet<string, short, short?>>> queryExpressionBindings = 
											new Dictionary<string,  List<Triplet<string, short, short?>>>
		{
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
							{"176DDF3C-9624-4F1A-88E3-A914A805752C", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("PFA_Amount",11,
														   -1),
								   new Triplet<string, short, short?>("PFA_FundType",5,
														   -1),
								   new Triplet<string, short, short?>("PFA_BudgetHeadValue",10,
														   -1),
								   new Triplet<string, short, short?>("PFA_ProjectNo",7,
														   -1),
								   new Triplet<string, short, short?>("MG_FundAllocation_RowId",3,
														   -1),
								   new Triplet<string, short, short?>("PFA_FundTypeValue",6,
														   -1),
								   new Triplet<string, short, short?>("PFA_BudgetHead",9,
														   -1),
								   new Triplet<string, short, short?>("PFA_ProjectNoValue",8,
														   -1),
								   new Triplet<string, short, short?>("PFA_FundDetailsId",12,
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
							{"D028F944-C1D4-4620-B778-DB80060ED624", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("PAB_Balance",6,
														   -1),
								   new Triplet<string, short, short?>("PAB_YetToRecieve",2,
														   -1),
								   new Triplet<string, short, short?>("PAB_Commitment",4,
														   -1),
								   new Triplet<string, short, short?>("PAB_Spent",5,
														   -1),
								   new Triplet<string, short, short?>("PAB_RecievedAmount",3,
														   -1),
								   new Triplet<string, short, short?>("PAB_BudgetName",0,
														   -1),
								   new Triplet<string, short, short?>("PAB_SanctionedAmount",1,
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
							{"176DDF3C-9624-4F1A-88E3-A914A805752C", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("PFA_Amount",11,
														   -1),
								   new Triplet<string, short, short?>("PFA_FundType",5,
														   -1),
								   new Triplet<string, short, short?>("PFA_BudgetHeadValue",10,
														   -1),
								   new Triplet<string, short, short?>("PFA_ProjectNo",7,
														   -1),
								   new Triplet<string, short, short?>("MG_FundAllocation_RowId",3,
														   -1),
								   new Triplet<string, short, short?>("PFA_FundTypeValue",6,
														   -1),
								   new Triplet<string, short, short?>("PFA_BudgetHead",9,
														   -1),
								   new Triplet<string, short, short?>("PFA_ProjectNoValue",8,
														   -1),
								   new Triplet<string, short, short?>("PFA_FundDetailsId",12,
														   -1),
								}
			},
							{"D028F944-C1D4-4620-B778-DB80060ED624", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("PAB_Balance",6,
														   -1),
								   new Triplet<string, short, short?>("PAB_YetToRecieve",2,
														   -1),
								   new Triplet<string, short, short?>("PAB_Commitment",4,
														   -1),
								   new Triplet<string, short, short?>("PAB_Spent",5,
														   -1),
								   new Triplet<string, short, short?>("PAB_RecievedAmount",3,
														   -1),
								   new Triplet<string, short, short?>("PAB_BudgetName",0,
														   -1),
								   new Triplet<string, short, short?>("PAB_SanctionedAmount",1,
														   -1),
								}
			},
					};	

	

		private Dictionary<string,string> formVersionList =new Dictionary<string,string> 
		{
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
							{"176DDF3C-9624-4F1A-88E3-A914A805752C", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("PFA_Amount",11,
														   -1),
								   new Triplet<string, short, short?>("PFA_FundType",5,
														   -1),
								   new Triplet<string, short, short?>("PFA_BudgetHeadValue",10,
														   -1),
								   new Triplet<string, short, short?>("PFA_ProjectNo",7,
														   -1),
								   new Triplet<string, short, short?>("MG_FundAllocation_RowId",3,
														   -1),
								   new Triplet<string, short, short?>("PFA_FundTypeValue",6,
														   -1),
								   new Triplet<string, short, short?>("PFA_BudgetHead",9,
														   -1),
								   new Triplet<string, short, short?>("PFA_ProjectNoValue",8,
														   -1),
								   new Triplet<string, short, short?>("PFA_FundDetailsId",12,
														   -1),
								}
			},
							{"D028F944-C1D4-4620-B778-DB80060ED624", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("PAB_Balance",6,
														   -1),
								   new Triplet<string, short, short?>("PAB_YetToRecieve",2,
														   -1),
								   new Triplet<string, short, short?>("PAB_Commitment",4,
														   -1),
								   new Triplet<string, short, short?>("PAB_Spent",5,
														   -1),
								   new Triplet<string, short, short?>("PAB_RecievedAmount",3,
														   -1),
								   new Triplet<string, short, short?>("PAB_BudgetName",0,
														   -1),
								   new Triplet<string, short, short?>("PAB_SanctionedAmount",1,
														   -1),
								}
			},
					};	

	

		private Dictionary<string,string> formVersionList =new Dictionary<string,string> 
		{
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
							{"176DDF3C-9624-4F1A-88E3-A914A805752C", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("PFA_Amount",11,
														   -1),
								   new Triplet<string, short, short?>("PFA_FundType",5,
														   -1),
								   new Triplet<string, short, short?>("PFA_BudgetHeadValue",10,
														   -1),
								   new Triplet<string, short, short?>("PFA_ProjectNo",7,
														   -1),
								   new Triplet<string, short, short?>("MG_FundAllocation_RowId",3,
														   -1),
								   new Triplet<string, short, short?>("PFA_FundTypeValue",6,
														   -1),
								   new Triplet<string, short, short?>("PFA_BudgetHead",9,
														   -1),
								   new Triplet<string, short, short?>("PFA_ProjectNoValue",8,
														   -1),
								   new Triplet<string, short, short?>("PFA_FundDetailsId",12,
														   -1),
								}
			},
							{"D028F944-C1D4-4620-B778-DB80060ED624", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("PAB_Balance",6,
														   -1),
								   new Triplet<string, short, short?>("PAB_YetToRecieve",2,
														   -1),
								   new Triplet<string, short, short?>("PAB_Commitment",4,
														   -1),
								   new Triplet<string, short, short?>("PAB_Spent",5,
														   -1),
								   new Triplet<string, short, short?>("PAB_RecievedAmount",3,
														   -1),
								   new Triplet<string, short, short?>("PAB_BudgetName",0,
														   -1),
								   new Triplet<string, short, short?>("PAB_SanctionedAmount",1,
														   -1),
								}
			},
					};	

	

		private Dictionary<string,string> formVersionList =new Dictionary<string,string> 
		{
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
							{"176DDF3C-9624-4F1A-88E3-A914A805752C", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("PFA_Amount",11,
														   -1),
								   new Triplet<string, short, short?>("PFA_FundType",5,
														   -1),
								   new Triplet<string, short, short?>("PFA_BudgetHeadValue",10,
														   -1),
								   new Triplet<string, short, short?>("PFA_ProjectNo",7,
														   -1),
								   new Triplet<string, short, short?>("MG_FundAllocation_RowId",3,
														   -1),
								   new Triplet<string, short, short?>("PFA_FundTypeValue",6,
														   -1),
								   new Triplet<string, short, short?>("PFA_BudgetHead",9,
														   -1),
								   new Triplet<string, short, short?>("PFA_ProjectNoValue",8,
														   -1),
								   new Triplet<string, short, short?>("PFA_FundDetailsId",12,
														   -1),
								}
			},
							{"D028F944-C1D4-4620-B778-DB80060ED624", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("PAB_Balance",6,
														   -1),
								   new Triplet<string, short, short?>("PAB_YetToRecieve",2,
														   -1),
								   new Triplet<string, short, short?>("PAB_Commitment",4,
														   -1),
								   new Triplet<string, short, short?>("PAB_Spent",5,
														   -1),
								   new Triplet<string, short, short?>("PAB_RecievedAmount",3,
														   -1),
								   new Triplet<string, short, short?>("PAB_BudgetName",0,
														   -1),
								   new Triplet<string, short, short?>("PAB_SanctionedAmount",1,
														   -1),
								}
			},
					};	

	

		private Dictionary<string,string> formVersionList =new Dictionary<string,string> 
		{
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
		


