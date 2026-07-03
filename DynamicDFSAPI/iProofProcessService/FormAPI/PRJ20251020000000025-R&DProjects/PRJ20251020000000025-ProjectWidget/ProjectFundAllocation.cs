  







namespace CPS.Proof.DFSExtension
{
	using System;
    using System.Collections.Generic;     
	using System.Linq;
	
	
	public partial class ProjectFundAllocationProcessMetadata : ExtensionProcessBase
	{		

        public override long PackageId
        {
            get { return 30304; }
        }

        public override string PackageName
        {
            get { return "PRJ20251020000000025-Project Widget"; }
        }

		public override string PackageDescription
        {
            get { return "Project Widget"; }
        }

        public override string ProcessId
        {
            get { return "95E82D60-2A2C-4609-BAA9-AE9B403CA935"; }
        }

        public override string ProcessName
        {
            get { return "ProjectFundAllocation"; }
        }

		public override string ProcessDescription
        {
            get { return "Project Fund Allocation"; }
        }

        public override ProcessType ProcessType
        {
            get { return ProcessType.Widget; }
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
            get {return "95E82D60-2A2C-4609-BAA9-AE9B403CA935";}
        }

		public override byte ProcessInstanceMode
        {
            get {return 3;}
        }		

		public override string MasterFormId
        {
            get {  
				   return "3F6BC539-9EC3-4DCC-82C2-D43D0C930168";	}
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
	

	public partial class ProjectFundAllocationObjectFactory  : ExtObjectFactoryBase
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
        //    return (IExtBaseMetaData)new ProjectFundAllocationProcessMetadata();
        //}
	


		private List<Triplet<string, string, string>> queryExpressionData = new List<Triplet<string, string, string>>
		{
	  			
			     new Triplet<string, string, string>("a09f9b56-5807-3cfc-fe52-0f2899e0c9d1","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("40adf34b-757b-6f77-a804-4916cda30376","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("614362e7-08f5-2188-4dc5-6e8236893bf1","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("86ebde4f-b226-ac88-1748-8e19ff327b35","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("9c11640e-22ae-345b-705e-ad923d4670c1","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("f910f874-9b1b-56b5-3129-2309ffe1dc82","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("a65434f2-5d45-84b0-a7c3-0a9349fb4d36","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("78cf9b13-e8cc-46b5-5dff-b9a4f2aa8931","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("614362e7-08f5-2188-4dc5-6e8236893bf1","Load Commitments",
												     @"98793391-b3e6-ed00-71ca-93700e921f3c"),
			
						
			     new Triplet<string, string, string>("86ebde4f-b226-ac88-1748-8e19ff327b35","Load Fund Details",
												     @"60e821d0-153e-94bb-1fef-2594b78625bd"),
			
			
			
		};

		
		private List<Triplet<string, string, string>> ComboDataSource = new List<Triplet<string, string, string>>
		{

		
	  			
			     new Triplet<string, string, string>("FWFM_BudgetHead","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMA18yFT7KruzVDa0TqsqpOM+grujzoqor1KqRIderPPsozBAr7TiIaPx7MYO2zQclV",
												     @"Exec SP_GetDistrubitionDetails 5,'@PFMF_PackageProcessMapId','@FWFM_FundType','','','','','@FWFM_ProjectNo'"),
			
						
			     new Triplet<string, string, string>("FWFM_ProjectNo","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMAqCwOWy+D7Ogje1I4jfjiAZNrjEazgaNyfBj9pr2u90lOsHzRNfKnSybWqRxrZGqV",
												     @"EXEC GetProjectNoCombo 1,'@PFMF_UserId'"),
			
						
			     new Triplet<string, string, string>("FWFM_FundType","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMA18yFT7KruzVDa0TqsqpOM+grujzoqor1KqRIderPPsozBAr7TiIaPx7MYO2zQclV",
												     @"exec SP_GetDistrubitionDetails 4,'@PFMF_PackageProcessMapId','',''"),
			
						
			     new Triplet<string, string, string>("FWAB_ProjectNo","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMAqCwOWy+D7Ogje1I4jfjiAZNrjEazgaNyfBj9pr2u90lOsHzRNfKnSybWqRxrZGqV",
												     @"EXEC GetProjectNoCombo 1,'@PFMF_UserId'"),
			
						
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
			
						
			     new Tuple<string, int>("MG_RequiredDocuments",5),
			
						
			     new Tuple<string, int>("MG_AvailableBudget",25),
			
						
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
											case "94D43E66-DFA9-4FBA-BE54-B8CF4CDDF4E7":
							virtualInstance=new ISpace94D43E66DFA94FBABE54B8CF4CDDF4E7();
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
	

	public partial class ProjectFundAllocationDataElementFactory  : ExtElementBase
    {

     /// <summary>
        /// A <see cref="log4net.ILog"/> that contains the logger instance for 
        /// logging
        /// </summary>
        private readonly ILog _sysLog;

        public ProjectFundAllocationDataElementFactory()
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

               
                
                                      case "3F6BC539-9EC3-4DCC-82C2-D43D0C930168":
                    {
                     
                                     fInsertQuery=@"IF NOT EXISTS(SELECT 1 FROM [3F6BC539-9EC3-4DCC-82C2-D43D0C930168] WHERE InstanceId='{0}') BEGIN INSERT INTO [3F6BC539-9EC3-4DCC-82C2-D43D0C930168](ProcessActivityMapId,FormId,Subject,ExecutionStatus,ExecutionMessage,SetDestinationTo,SLATime,FWFM_FundDetailsId,FWFM_FundType,FWFM_ProjectNo,FWFM_BudgetHead,FWFM_Amount,FWAB_ProjectNo,InstanceId,PFMF_FundTotal,PFMF_PackageProcessMapId,PFMF_UserId,PFM_ErrId,PFM_ErrMsg,PFM_FundDetailsId)
							VALUES( {3}) END ELSE BEGIN UPDATE [3F6BC539-9EC3-4DCC-82C2-D43D0C930168]SET {4}WHERE InstanceId='{0}'END ";

                                     colList=@"ProcessActivityMapId,FormId,Subject,ExecutionStatus,ExecutionMessage,SetDestinationTo,SLATime,FWFM_FundDetailsId,FWFM_FundType,FWFM_ProjectNo,FWFM_BudgetHead,FWFM_Amount,FWAB_ProjectNo,InstanceId,PFMF_FundTotal,PFMF_PackageProcessMapId,PFMF_UserId,PFM_ErrId,PFM_ErrMsg,PFM_FundDetailsId";
                                    
                     
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

                
                 
                                      case "60e821d0-153e-94bb-1fef-2594b78625bd":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_60e821d0153e94bb1fef2594b78625bd AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [PFA_FundType] VARCHAR(MAX)	, [PFA_FundTypeValue] VARCHAR(MAX)	, [PFA_ProjectNo] VARCHAR(MAX)	, [PFA_ProjectNoValue] VARCHAR(MAX)	, [PFA_BudgetHead] VARCHAR(MAX)	, [PFA_BudgetHeadValue] VARCHAR(MAX)	, [PFA_Amount] DECIMAL(18,2)	, [PFA_FundDetailsId] VARCHAR(MAX)){0}INSERT INTO [60e821d0-153e-94bb-1fef-2594b78625bd](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PFA_FundType,PFA_FundTypeValue,PFA_ProjectNo,PFA_ProjectNoValue,PFA_BudgetHead,PFA_BudgetHeadValue,PFA_Amount,PFA_FundDetailsId)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.PFA_FundType,TDT.PFA_FundTypeValue,TDT.PFA_ProjectNo,TDT.PFA_ProjectNoValue,TDT.PFA_BudgetHead,TDT.PFA_BudgetHeadValue,TDT.PFA_Amount,TDT.PFA_FundDetailsId FROM @TBL_60e821d0153e94bb1fef2594b78625bd TDT
							LEFT JOIN [60e821d0-153e-94bb-1fef-2594b78625bd] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,PFA_FundType=TDT.PFA_FundType,PFA_FundTypeValue=TDT.PFA_FundTypeValue,PFA_ProjectNo=TDT.PFA_ProjectNo,PFA_ProjectNoValue=TDT.PFA_ProjectNoValue,PFA_BudgetHead=TDT.PFA_BudgetHead,PFA_BudgetHeadValue=TDT.PFA_BudgetHeadValue,PFA_Amount=TDT.PFA_Amount,PFA_FundDetailsId=TDT.PFA_FundDetailsId FROM @TBL_60e821d0153e94bb1fef2594b78625bd TDT
							JOIN [60e821d0-153e-94bb-1fef-2594b78625bd] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PFA_FundType,PFA_FundTypeValue,PFA_ProjectNo,PFA_ProjectNoValue,PFA_BudgetHead,PFA_BudgetHeadValue,PFA_Amount,PFA_FundDetailsId";

                                     tempInsertQuery=@"INSERT INTO @TBL_60e821d0153e94bb1fef2594b78625bd(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PFA_FundType,PFA_FundTypeValue,PFA_ProjectNo,PFA_ProjectNoValue,PFA_BudgetHead,PFA_BudgetHeadValue,PFA_Amount,PFA_FundDetailsId)VALUES({0});";
                                     

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
                     
                                    case "98793391-b3e6-ed00-71ca-93700e921f3c":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_98793391b3e6ed0071ca93700e921f3c AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [PAB_BudgetName] VARCHAR(MAX)	, [PAB_SanctionedAmount] DECIMAL(18,2)	, [PAB_YetToRecieve] DECIMAL(18,2)	, [PAB_RecievedAmount] DECIMAL(18,2)	, [PAB_Commitment] DECIMAL(18,2)	, [PAB_Spent] DECIMAL(18,2)	, [PAB_Balance] DECIMAL(18,2)){0}INSERT INTO [98793391-b3e6-ed00-71ca-93700e921f3c](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PAB_BudgetName,PAB_SanctionedAmount,PAB_YetToRecieve,PAB_RecievedAmount,PAB_Commitment,PAB_Spent,PAB_Balance)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.PAB_BudgetName,TDT.PAB_SanctionedAmount,TDT.PAB_YetToRecieve,TDT.PAB_RecievedAmount,TDT.PAB_Commitment,TDT.PAB_Spent,TDT.PAB_Balance FROM @TBL_98793391b3e6ed0071ca93700e921f3c TDT
							LEFT JOIN [98793391-b3e6-ed00-71ca-93700e921f3c] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,PAB_BudgetName=TDT.PAB_BudgetName,PAB_SanctionedAmount=TDT.PAB_SanctionedAmount,PAB_YetToRecieve=TDT.PAB_YetToRecieve,PAB_RecievedAmount=TDT.PAB_RecievedAmount,PAB_Commitment=TDT.PAB_Commitment,PAB_Spent=TDT.PAB_Spent,PAB_Balance=TDT.PAB_Balance FROM @TBL_98793391b3e6ed0071ca93700e921f3c TDT
							JOIN [98793391-b3e6-ed00-71ca-93700e921f3c] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PAB_BudgetName,PAB_SanctionedAmount,PAB_YetToRecieve,PAB_RecievedAmount,PAB_Commitment,PAB_Spent,PAB_Balance";

                                     tempInsertQuery=@"INSERT INTO @TBL_98793391b3e6ed0071ca93700e921f3c(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PAB_BudgetName,PAB_SanctionedAmount,PAB_YetToRecieve,PAB_RecievedAmount,PAB_Commitment,PAB_Spent,PAB_Balance)VALUES({0});";
                                     

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
                     
                                    case "1a062a3a-4a95-6ea7-0db7-28e87b7fa536":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_1a062a3a4a956ea70db728e87b7fa536 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [PADD_DocumentName] VARCHAR(MAX)	, [PADD_Document] VARCHAR(MAX)){0}INSERT INTO [1a062a3a-4a95-6ea7-0db7-28e87b7fa536](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PADD_DocumentName,PADD_Document)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.PADD_DocumentName,TDT.PADD_Document FROM @TBL_1a062a3a4a956ea70db728e87b7fa536 TDT
							LEFT JOIN [1a062a3a-4a95-6ea7-0db7-28e87b7fa536] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,PADD_DocumentName=TDT.PADD_DocumentName,PADD_Document=TDT.PADD_Document FROM @TBL_1a062a3a4a956ea70db728e87b7fa536 TDT
							JOIN [1a062a3a-4a95-6ea7-0db7-28e87b7fa536] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PADD_DocumentName,PADD_Document";

                                     tempInsertQuery=@"INSERT INTO @TBL_1a062a3a4a956ea70db728e87b7fa536(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PADD_DocumentName,PADD_Document)VALUES({0});";
                                     

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
                     

                                         case "60e821d0-153e-94bb-1fef-2594b78625bd":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_60e821d0153e94bb1fef2594b78625bd AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [PFA_FundType] VARCHAR(MAX)	, [PFA_FundTypeValue] VARCHAR(MAX)	, [PFA_ProjectNo] VARCHAR(MAX)	, [PFA_ProjectNoValue] VARCHAR(MAX)	, [PFA_BudgetHead] VARCHAR(MAX)	, [PFA_BudgetHeadValue] VARCHAR(MAX)	, [PFA_Amount] DECIMAL(18,2)	, [PFA_FundDetailsId] VARCHAR(MAX)){0}INSERT INTO [60e821d0-153e-94bb-1fef-2594b78625bd](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PFA_FundType,PFA_FundTypeValue,PFA_ProjectNo,PFA_ProjectNoValue,PFA_BudgetHead,PFA_BudgetHeadValue,PFA_Amount,PFA_FundDetailsId)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.PFA_FundType,TDT.PFA_FundTypeValue,TDT.PFA_ProjectNo,TDT.PFA_ProjectNoValue,TDT.PFA_BudgetHead,TDT.PFA_BudgetHeadValue,TDT.PFA_Amount,TDT.PFA_FundDetailsId FROM @TBL_60e821d0153e94bb1fef2594b78625bd TDT
							LEFT JOIN [60e821d0-153e-94bb-1fef-2594b78625bd] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,PFA_FundType=TDT.PFA_FundType,PFA_FundTypeValue=TDT.PFA_FundTypeValue,PFA_ProjectNo=TDT.PFA_ProjectNo,PFA_ProjectNoValue=TDT.PFA_ProjectNoValue,PFA_BudgetHead=TDT.PFA_BudgetHead,PFA_BudgetHeadValue=TDT.PFA_BudgetHeadValue,PFA_Amount=TDT.PFA_Amount,PFA_FundDetailsId=TDT.PFA_FundDetailsId FROM @TBL_60e821d0153e94bb1fef2594b78625bd TDT
							JOIN [60e821d0-153e-94bb-1fef-2594b78625bd] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PFA_FundType,PFA_FundTypeValue,PFA_ProjectNo,PFA_ProjectNoValue,PFA_BudgetHead,PFA_BudgetHeadValue,PFA_Amount,PFA_FundDetailsId";

                            tempInsertQuery=@"INSERT INTO @TBL_60e821d0153e94bb1fef2594b78625bd(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PFA_FundType,PFA_FundTypeValue,PFA_ProjectNo,PFA_ProjectNoValue,PFA_BudgetHead,PFA_BudgetHeadValue,PFA_Amount,PFA_FundDetailsId)VALUES({0});";

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

                                              case "98793391-b3e6-ed00-71ca-93700e921f3c":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_98793391b3e6ed0071ca93700e921f3c AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [PAB_BudgetName] VARCHAR(MAX)	, [PAB_SanctionedAmount] DECIMAL(18,2)	, [PAB_YetToRecieve] DECIMAL(18,2)	, [PAB_RecievedAmount] DECIMAL(18,2)	, [PAB_Commitment] DECIMAL(18,2)	, [PAB_Spent] DECIMAL(18,2)	, [PAB_Balance] DECIMAL(18,2)){0}INSERT INTO [98793391-b3e6-ed00-71ca-93700e921f3c](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PAB_BudgetName,PAB_SanctionedAmount,PAB_YetToRecieve,PAB_RecievedAmount,PAB_Commitment,PAB_Spent,PAB_Balance)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.PAB_BudgetName,TDT.PAB_SanctionedAmount,TDT.PAB_YetToRecieve,TDT.PAB_RecievedAmount,TDT.PAB_Commitment,TDT.PAB_Spent,TDT.PAB_Balance FROM @TBL_98793391b3e6ed0071ca93700e921f3c TDT
							LEFT JOIN [98793391-b3e6-ed00-71ca-93700e921f3c] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,PAB_BudgetName=TDT.PAB_BudgetName,PAB_SanctionedAmount=TDT.PAB_SanctionedAmount,PAB_YetToRecieve=TDT.PAB_YetToRecieve,PAB_RecievedAmount=TDT.PAB_RecievedAmount,PAB_Commitment=TDT.PAB_Commitment,PAB_Spent=TDT.PAB_Spent,PAB_Balance=TDT.PAB_Balance FROM @TBL_98793391b3e6ed0071ca93700e921f3c TDT
							JOIN [98793391-b3e6-ed00-71ca-93700e921f3c] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PAB_BudgetName,PAB_SanctionedAmount,PAB_YetToRecieve,PAB_RecievedAmount,PAB_Commitment,PAB_Spent,PAB_Balance";

                            tempInsertQuery=@"INSERT INTO @TBL_98793391b3e6ed0071ca93700e921f3c(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PAB_BudgetName,PAB_SanctionedAmount,PAB_YetToRecieve,PAB_RecievedAmount,PAB_Commitment,PAB_Spent,PAB_Balance)VALUES({0});";

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

                                              case "1a062a3a-4a95-6ea7-0db7-28e87b7fa536":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_1a062a3a4a956ea70db728e87b7fa536 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [PADD_DocumentName] VARCHAR(MAX)	, [PADD_Document] VARCHAR(MAX)){0}INSERT INTO [1a062a3a-4a95-6ea7-0db7-28e87b7fa536](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PADD_DocumentName,PADD_Document)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.PADD_DocumentName,TDT.PADD_Document FROM @TBL_1a062a3a4a956ea70db728e87b7fa536 TDT
							LEFT JOIN [1a062a3a-4a95-6ea7-0db7-28e87b7fa536] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,PADD_DocumentName=TDT.PADD_DocumentName,PADD_Document=TDT.PADD_Document FROM @TBL_1a062a3a4a956ea70db728e87b7fa536 TDT
							JOIN [1a062a3a-4a95-6ea7-0db7-28e87b7fa536] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PADD_DocumentName,PADD_Document";

                            tempInsertQuery=@"INSERT INTO @TBL_1a062a3a4a956ea70db728e87b7fa536(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PADD_DocumentName,PADD_Document)VALUES({0});";

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
public class ISpace94D43E66DFA94FBABE54B8CF4CDDF4E7 : VirtualForm
{
IISpace iSpace = new ISpace();
AcDataISpace94D43E66DFA94FBABE54B8CF4CDDF4E7 acdataIspace94D43E66DFA94FBABE54B8CF4CDDF4E7=new AcDataISpace94D43E66DFA94FBABE54B8CF4CDDF4E7();
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
if(ISpace["FWFM_FundType"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""FWFM_FundType""].Value=="""")");
ISpace["FWFM_BudgetHead"].Visible="false";ISpace["FWFM_ProjectNo"].Visible="false";ISpace["FWFM_Amount"].Visible="false";
base.WriteDebugInfo(@"ISpace[""FWFM_BudgetHead""].Visible=""false"";ISpace[""FWFM_ProjectNo""].Visible=""false"";ISpace[""FWFM_Amount""].Visible=""false"";");
}
if(ISpace["FWFM_FundType"].Value=="1" || ISpace["FWFM_FundType"].Value=="3")
{
base.WriteDebugInfo(@"if(ISpace[""FWFM_FundType""].Value==""1"" || ISpace[""FWFM_FundType""].Value==""3"")");
}
ISpace["FWFM_BudgetHead"].Visible="true";ISpace["FWFM_ProjectNo"].Visible="true";
base.WriteDebugInfo(@"ISpace[""FWFM_BudgetHead""].Visible=""true"";ISpace[""FWFM_ProjectNo""].Visible=""true"";");
ISpace["PFMF_PackageProcessMapId"].Value=ISpace["gv_processmapid"].Value;
base.WriteDebugInfo(@"ISpace[""PFMF_PackageProcessMapId""].Value=ISpace[""gv_processmapid""].Value;");
ISpace["PFMF_UserId"].Value=ISpace["gv_userid"].Value;
base.WriteDebugInfo(@"ISpace[""PFMF_UserId""].Value=ISpace[""gv_userid""].Value;");
ISpace["FWFM_BudgetHead"].Man=true;ISpace["FWFM_ProjectNo"].Man=true;ISpace["FWFM_FundType"].Man=true;ISpace["FWFM_Amount"].Man=true;
base.WriteDebugInfo(@"ISpace[""FWFM_BudgetHead""].Man=true;ISpace[""FWFM_ProjectNo""].Man=true;ISpace[""FWFM_FundType""].Man=true;ISpace[""FWFM_Amount""].Man=true;");
ISpace["PADD_DocumentName"].Man=true;ISpace["PADD_Document"].Man=true;
base.WriteDebugInfo(@"ISpace[""PADD_DocumentName""].Man=true;ISpace[""PADD_Document""].Man=true;");
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

var querySourcea09f9b5658073cfcfe520f2899e0c9d1 =GetQueryExpressionDataSource("a09f9b56-5807-3cfc-fe52-0f2899e0c9d1");
Dictionary<short,object> resulta09f9b5658073cfcfe520f2899e0c9d1=iSpace.ExecuteQuery(querySourcea09f9b5658073cfcfe520f2899e0c9d1,@"Exec [Get60e821d0-153e-94bb-1fef-2594b78625bd] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["PFA_FundDetailsId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourcea09f9b5658073cfcfe520f2899e0c9d1 =GetQueryExpressionDataSource(""a09f9b56-5807-3cfc-fe52-0f2899e0c9d1"");Dictionary<short,object> resulta09f9b5658073cfcfe520f2899e0c9d1=iSpace.ExecuteQuery(querySourcea09f9b5658073cfcfe520f2899e0c9d1,@""Exec [Get60e821d0-153e-94bb-1fef-2594b78625bd] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""PFA_FundDetailsId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resulta09f9b5658073cfcfe520f2899e0c9d1!=null) && (resulta09f9b5658073cfcfe520f2899e0c9d1.Count!=0))
{
if(resulta09f9b5658073cfcfe520f2899e0c9d1.ContainsKey(9))
ISpace["FWFM_BudgetHead"].Value = resulta09f9b5658073cfcfe520f2899e0c9d1[9];
if(resulta09f9b5658073cfcfe520f2899e0c9d1.ContainsKey(7))
ISpace["FWFM_ProjectNo"].Value = resulta09f9b5658073cfcfe520f2899e0c9d1[7];
if(resulta09f9b5658073cfcfe520f2899e0c9d1.ContainsKey(5))
ISpace["FWFM_FundType"].Value = resulta09f9b5658073cfcfe520f2899e0c9d1[5];
if(resulta09f9b5658073cfcfe520f2899e0c9d1.ContainsKey(11))
ISpace["FWFM_Amount"].Value = resulta09f9b5658073cfcfe520f2899e0c9d1[11];
if(resulta09f9b5658073cfcfe520f2899e0c9d1.ContainsKey(3))
ISpace["FWFM_FundDetailsId"].Value = resulta09f9b5658073cfcfe520f2899e0c9d1[3];
}
else{
ISpace["FWFM_BudgetHead"].Value = null;ISpace["FWFM_ProjectNo"].Value = null;ISpace["FWFM_FundType"].Value = null;ISpace["FWFM_Amount"].Value = null;ISpace["FWFM_FundDetailsId"].Value = null;
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

var querySourcea65434f25d4584b0a7c30a9349fb4d36 =GetQueryExpressionDataSource("a65434f2-5d45-84b0-a7c3-0a9349fb4d36");
Dictionary<short,object> resulta65434f25d4584b0a7c30a9349fb4d36=iSpace.ExecuteQuery(querySourcea65434f25d4584b0a7c30a9349fb4d36,@"EXEC [UpsertProjectFundAllocation] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','" + ISpace["gv_userid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourcea65434f25d4584b0a7c30a9349fb4d36 =GetQueryExpressionDataSource(""a65434f2-5d45-84b0-a7c3-0a9349fb4d36"");Dictionary<short,object> resulta65434f25d4584b0a7c30a9349fb4d36=iSpace.ExecuteQuery(querySourcea65434f25d4584b0a7c30a9349fb4d36,@""EXEC [UpsertProjectFundAllocation] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','"" + ISpace[""gv_userid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resulta65434f25d4584b0a7c30a9349fb4d36!=null) && (resulta65434f25d4584b0a7c30a9349fb4d36.Count!=0))
{
if(resulta65434f25d4584b0a7c30a9349fb4d36.ContainsKey(0))
ISpace["PFM_ErrId"].Value = resulta65434f25d4584b0a7c30a9349fb4d36[0];
if(resulta65434f25d4584b0a7c30a9349fb4d36.ContainsKey(1))
ISpace["PFM_ErrMsg"].Value = resulta65434f25d4584b0a7c30a9349fb4d36[1];
}
else{
ISpace["PFM_ErrId"].Value = null;ISpace["PFM_ErrMsg"].Value = null;
}
if(ISpace["PFM_ErrId"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""PFM_ErrId""].Value==1)");
ISpace["Message"].Value=String.Format(@"{0}",ISpace["PFM_ErrMsg"].Value);
base.WriteDebugInfo(@"ISpace[""Message""].Value=String.Format(@""{0}"",ISpace[""PFM_ErrMsg""].Value);");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC [SaveReimbursementDocuments] '@@gv_InstanceId','@@gv_ProcessMapId','@@gv_UserId'");

var querySource78cf9b13e8cc46b55dffb9a4f2aa8931 =GetQueryExpressionDataSource("78cf9b13-e8cc-46b5-5dff-b9a4f2aa8931");
Dictionary<short,object> result78cf9b13e8cc46b55dffb9a4f2aa8931=iSpace.ExecuteQuery(querySource78cf9b13e8cc46b55dffb9a4f2aa8931,@"EXEC [SaveReimbursementDocuments] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','" + ISpace["gv_userid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource78cf9b13e8cc46b55dffb9a4f2aa8931 =GetQueryExpressionDataSource(""78cf9b13-e8cc-46b5-5dff-b9a4f2aa8931"");Dictionary<short,object> result78cf9b13e8cc46b55dffb9a4f2aa8931=iSpace.ExecuteQuery(querySource78cf9b13e8cc46b55dffb9a4f2aa8931,@""EXEC [SaveReimbursementDocuments] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','"" + ISpace[""gv_userid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result78cf9b13e8cc46b55dffb9a4f2aa8931!=null) && (result78cf9b13e8cc46b55dffb9a4f2aa8931.Count!=0))
{
if(result78cf9b13e8cc46b55dffb9a4f2aa8931.ContainsKey(0))
ISpace["PFM_ErrId"].Value = result78cf9b13e8cc46b55dffb9a4f2aa8931[0];
if(result78cf9b13e8cc46b55dffb9a4f2aa8931.ContainsKey(1))
ISpace["PFM_ErrMsg"].Value = result78cf9b13e8cc46b55dffb9a4f2aa8931[1];
}
else{
ISpace["PFM_ErrId"].Value = null;ISpace["PFM_ErrMsg"].Value = null;
}
if(ISpace["PFM_ErrId"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""PFM_ErrId""].Value==1)");
ISpace["Message"].Value=String.Format(@"{0}",ISpace["PFM_ErrMsg"].Value);
base.WriteDebugInfo(@"ISpace[""Message""].Value=String.Format(@""{0}"",ISpace[""PFM_ErrMsg""].Value);");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
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

var querySource40adf34b757b6f77a8044916cda30376 =GetQueryExpressionDataSource("40adf34b-757b-6f77-a804-4916cda30376");
Dictionary<short,object> result40adf34b757b6f77a8044916cda30376=iSpace.ExecuteQuery(querySource40adf34b757b6f77a8044916cda30376,@"EXEC [Upsert60e821d0-153e-94bb-1fef-2594b78625bd] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','" + ISpace["FWFM_FundDetailsId"].Value + @"','" + ISpace["FWFM_FundType"].Value + @"','" + ISpace["FWFM_ProjectNo"].Value + @"','" + ISpace["FWFM_BudgetHead"].Value + @"','" + ISpace["FWFM_Amount"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource40adf34b757b6f77a8044916cda30376 =GetQueryExpressionDataSource(""40adf34b-757b-6f77-a804-4916cda30376"");Dictionary<short,object> result40adf34b757b6f77a8044916cda30376=iSpace.ExecuteQuery(querySource40adf34b757b6f77a8044916cda30376,@""EXEC [Upsert60e821d0-153e-94bb-1fef-2594b78625bd] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','"" + ISpace[""FWFM_FundDetailsId""].Value + @""','"" + ISpace[""FWFM_FundType""].Value + @""','"" + ISpace[""FWFM_ProjectNo""].Value + @""','"" + ISpace[""FWFM_BudgetHead""].Value + @""','"" + ISpace[""FWFM_Amount""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result40adf34b757b6f77a8044916cda30376!=null) && (result40adf34b757b6f77a8044916cda30376.Count!=0))
{
if(result40adf34b757b6f77a8044916cda30376.ContainsKey(0))
ISpace["PFM_ErrId"].Value = result40adf34b757b6f77a8044916cda30376[0];
if(result40adf34b757b6f77a8044916cda30376.ContainsKey(1))
ISpace["PFM_ErrMsg"].Value = result40adf34b757b6f77a8044916cda30376[1];
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

var querySource86ebde4fb226ac8817488e19ff327b35 =GetQueryExpressionDataSource("86ebde4f-b226-ac88-1748-8e19ff327b35");

DataTable result86ebde4fb226ac8817488e19ff327b35=iSpace.SetGridDataSource(querySource86ebde4fb226ac8817488e19ff327b35, _objectFactory.GetGridRPP("MG_FundAllocation"),@"Exec [Get60e821d0-153e-94bb-1fef-2594b78625bd] '" + ISpace["gv_instanceid"].Value + @"'");

iSpace.InsertGridBindDetails("MG_FundAllocation","11",querySource86ebde4fb226ac8817488e19ff327b35,"Exec [Get60e821d0-153e-94bb-1fef-2594b78625bd] '" + ISpace["gv_instanceid"].Value + @"'",_objectFactory.GetGridRPP("MG_FundAllocation"));

base.WriteDebugInfo(@"var querySource86ebde4fb226ac8817488e19ff327b35 =GetQueryExpressionDataSource(""86ebde4f-b226-ac88-1748-8e19ff327b35"");DataTable result86ebde4fb226ac8817488e19ff327b35=iSpace.SetGridDataSource(querySource86ebde4fb226ac8817488e19ff327b35, _objectFactory.GetGridRPP(""MG_FundAllocation""),@""Exec [Get60e821d0-153e-94bb-1fef-2594b78625bd] '"" + ISpace[""gv_instanceid""].Value + @""'"");iSpace.InsertGridBindDetails(""MG_FundAllocation"",""11"",querySource86ebde4fb226ac8817488e19ff327b35,""Exec [Get60e821d0-153e-94bb-1fef-2594b78625bd] '"" + ISpace[""gv_instanceid""].Value + @""'"",_objectFactory.GetGridRPP(""MG_FundAllocation""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result7723a61cecbb1093d9269eb94cd5ad4d=acdataIspace94D43E66DFA94FBABE54B8CF4CDDF4E7.GetQueryExpressionBindings("7723a61c-ecbb-1093-d926-9eb94cd5ad4d");
iSpace.SetGridData(result86ebde4fb226ac8817488e19ff327b35,result7723a61cecbb1093d9269eb94cd5ad4d,"MG_FundAllocation",ref ISpace);
iSpace.UpdateGridBindDetails("MG_FundAllocation",result7723a61cecbb1093d9269eb94cd5ad4d);
base.WriteDebugInfo(@"EXEC [GetFundSum] '@@gv_InstanceId'");

var querySource9c11640e22ae345b705ead923d4670c1 =GetQueryExpressionDataSource("9c11640e-22ae-345b-705e-ad923d4670c1");
Dictionary<short,object> result9c11640e22ae345b705ead923d4670c1=iSpace.ExecuteQuery(querySource9c11640e22ae345b705ead923d4670c1,@"EXEC [GetFundSum] '" + ISpace["gv_instanceid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource9c11640e22ae345b705ead923d4670c1 =GetQueryExpressionDataSource(""9c11640e-22ae-345b-705e-ad923d4670c1"");Dictionary<short,object> result9c11640e22ae345b705ead923d4670c1=iSpace.ExecuteQuery(querySource9c11640e22ae345b705ead923d4670c1,@""EXEC [GetFundSum] '"" + ISpace[""gv_instanceid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result9c11640e22ae345b705ead923d4670c1!=null) && (result9c11640e22ae345b705ead923d4670c1.Count!=0))
{
if(result9c11640e22ae345b705ead923d4670c1.ContainsKey(0))
ISpace["PFMF_FundTotal"].Value = result9c11640e22ae345b705ead923d4670c1[0];
}
else{
ISpace["PFMF_FundTotal"].Value = null;
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
}
ISpace["FWFM_BudgetHead"].Visible="true";ISpace["FWFM_ProjectNo"].Visible="true";
base.WriteDebugInfo(@"ISpace[""FWFM_BudgetHead""].Visible=""true"";ISpace[""FWFM_ProjectNo""].Visible=""true"";");
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

var querySourcef910f8749b1b56b531292309ffe1dc82 =GetQueryExpressionDataSource("f910f874-9b1b-56b5-3129-2309ffe1dc82");
Dictionary<short,object> resultf910f8749b1b56b531292309ffe1dc82=iSpace.ExecuteQuery(querySourcef910f8749b1b56b531292309ffe1dc82,@"EXEC[Delete60e821d0-153e_94bb-1fef-2594b78625bd] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["PFM_FundDetailsId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourcef910f8749b1b56b531292309ffe1dc82 =GetQueryExpressionDataSource(""f910f874-9b1b-56b5-3129-2309ffe1dc82"");Dictionary<short,object> resultf910f8749b1b56b531292309ffe1dc82=iSpace.ExecuteQuery(querySourcef910f8749b1b56b531292309ffe1dc82,@""EXEC[Delete60e821d0-153e_94bb-1fef-2594b78625bd] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""PFM_FundDetailsId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultf910f8749b1b56b531292309ffe1dc82!=null) && (resultf910f8749b1b56b531292309ffe1dc82.Count!=0))
{
if(resultf910f8749b1b56b531292309ffe1dc82.ContainsKey(0))
ISpace["PFM_ErrId"].Value = resultf910f8749b1b56b531292309ffe1dc82[0];
if(resultf910f8749b1b56b531292309ffe1dc82.ContainsKey(1))
ISpace["PFM_ErrMsg"].Value = resultf910f8749b1b56b531292309ffe1dc82[1];
}
else{
ISpace["PFM_ErrId"].Value = null;ISpace["PFM_ErrMsg"].Value = null;
}
ISpace["Message"].Value=String.Format(@"{0}",ISpace["PFM_ErrMsg"].Value);
base.WriteDebugInfo(@"ISpace[""Message""].Value=String.Format(@""{0}"",ISpace[""PFM_ErrMsg""].Value);");

var querySource86ebde4fb226ac8817488e19ff327b35 =GetQueryExpressionDataSource("86ebde4f-b226-ac88-1748-8e19ff327b35");

DataTable result86ebde4fb226ac8817488e19ff327b35=iSpace.SetGridDataSource(querySource86ebde4fb226ac8817488e19ff327b35, _objectFactory.GetGridRPP("MG_FundAllocation"),@"Exec [Get60e821d0-153e-94bb-1fef-2594b78625bd] '" + ISpace["gv_instanceid"].Value + @"'");

iSpace.InsertGridBindDetails("MG_FundAllocation","11",querySource86ebde4fb226ac8817488e19ff327b35,"Exec [Get60e821d0-153e-94bb-1fef-2594b78625bd] '" + ISpace["gv_instanceid"].Value + @"'",_objectFactory.GetGridRPP("MG_FundAllocation"));

base.WriteDebugInfo(@"var querySource86ebde4fb226ac8817488e19ff327b35 =GetQueryExpressionDataSource(""86ebde4f-b226-ac88-1748-8e19ff327b35"");DataTable result86ebde4fb226ac8817488e19ff327b35=iSpace.SetGridDataSource(querySource86ebde4fb226ac8817488e19ff327b35, _objectFactory.GetGridRPP(""MG_FundAllocation""),@""Exec [Get60e821d0-153e-94bb-1fef-2594b78625bd] '"" + ISpace[""gv_instanceid""].Value + @""'"");iSpace.InsertGridBindDetails(""MG_FundAllocation"",""11"",querySource86ebde4fb226ac8817488e19ff327b35,""Exec [Get60e821d0-153e-94bb-1fef-2594b78625bd] '"" + ISpace[""gv_instanceid""].Value + @""'"",_objectFactory.GetGridRPP(""MG_FundAllocation""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result7723a61cecbb1093d9269eb94cd5ad4d=acdataIspace94D43E66DFA94FBABE54B8CF4CDDF4E7.GetQueryExpressionBindings("7723a61c-ecbb-1093-d926-9eb94cd5ad4d");
iSpace.SetGridData(result86ebde4fb226ac8817488e19ff327b35,result7723a61cecbb1093d9269eb94cd5ad4d,"MG_FundAllocation",ref ISpace);
iSpace.UpdateGridBindDetails("MG_FundAllocation",result7723a61cecbb1093d9269eb94cd5ad4d);
ISpace["PFM_FundDetailsId"].Value="";
base.WriteDebugInfo(@"ISpace[""PFM_FundDetailsId""].Value="""";");
ISpace["UI_DeleteDialog"].HideDialog=true;;
base.WriteDebugInfo(@"ISpace[""UI_DeleteDialog""].HideDialog=true;;");
base.WriteDebugInfo(@"EXEC [GetFundSum] '@@gv_InstanceId'");

var querySource9c11640e22ae345b705ead923d4670c1 =GetQueryExpressionDataSource("9c11640e-22ae-345b-705e-ad923d4670c1");
Dictionary<short,object> result9c11640e22ae345b705ead923d4670c1=iSpace.ExecuteQuery(querySource9c11640e22ae345b705ead923d4670c1,@"EXEC [GetFundSum] '" + ISpace["gv_instanceid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource9c11640e22ae345b705ead923d4670c1 =GetQueryExpressionDataSource(""9c11640e-22ae-345b-705e-ad923d4670c1"");Dictionary<short,object> result9c11640e22ae345b705ead923d4670c1=iSpace.ExecuteQuery(querySource9c11640e22ae345b705ead923d4670c1,@""EXEC [GetFundSum] '"" + ISpace[""gv_instanceid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result9c11640e22ae345b705ead923d4670c1!=null) && (result9c11640e22ae345b705ead923d4670c1.Count!=0))
{
if(result9c11640e22ae345b705ead923d4670c1.ContainsKey(0))
ISpace["PFMF_FundTotal"].Value = result9c11640e22ae345b705ead923d4670c1[0];
}
else{
ISpace["PFMF_FundTotal"].Value = null;
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
private void SubscribeElementEvents_fwab_projectno (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"FWAB_ProjectNo-OnChange");

var querySource614362e708f521884dc56e8236893bf1 =GetQueryExpressionDataSource("614362e7-08f5-2188-4dc5-6e8236893bf1");

DataTable result614362e708f521884dc56e8236893bf1=iSpace.SetGridDataSource(querySource614362e708f521884dc56e8236893bf1, _objectFactory.GetGridRPP("MG_AvailableBudget"),@"EXEC [GetProjectBudgetInformation] '" + ISpace["FWAB_ProjectNo"].Value + @"'");

iSpace.InsertGridBindDetails("MG_AvailableBudget","11",querySource614362e708f521884dc56e8236893bf1,"EXEC [GetProjectBudgetInformation] '" + ISpace["FWAB_ProjectNo"].Value + @"'",_objectFactory.GetGridRPP("MG_AvailableBudget"));

base.WriteDebugInfo(@"var querySource614362e708f521884dc56e8236893bf1 =GetQueryExpressionDataSource(""614362e7-08f5-2188-4dc5-6e8236893bf1"");DataTable result614362e708f521884dc56e8236893bf1=iSpace.SetGridDataSource(querySource614362e708f521884dc56e8236893bf1, _objectFactory.GetGridRPP(""MG_AvailableBudget""),@""EXEC [GetProjectBudgetInformation] '"" + ISpace[""FWAB_ProjectNo""].Value + @""'"");iSpace.InsertGridBindDetails(""MG_AvailableBudget"",""11"",querySource614362e708f521884dc56e8236893bf1,""EXEC [GetProjectBudgetInformation] '"" + ISpace[""FWAB_ProjectNo""].Value + @""'"",_objectFactory.GetGridRPP(""MG_AvailableBudget""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> resulta2842489fdd08948e346997ea4530fd2=acdataIspace94D43E66DFA94FBABE54B8CF4CDDF4E7.GetQueryExpressionBindings("a2842489-fdd0-8948-e346-997ea4530fd2");
iSpace.SetGridData(result614362e708f521884dc56e8236893bf1,resulta2842489fdd08948e346997ea4530fd2,"MG_AvailableBudget",ref ISpace);
iSpace.UpdateGridBindDetails("MG_AvailableBudget",resulta2842489fdd08948e346997ea4530fd2);
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
		if(elementName.ToLower().Equals("fwfm_projectno"))
    {
    			SubscribeElementEvents_fwfm_projectno(ref dfsParam);
    }
		if(elementName.ToLower().Equals("fwfm_fundtype"))
    {
    			SubscribeElementEvents_fwfm_fundtype(ref dfsParam);
    }
		if(elementName.ToLower().Equals("fwab_projectno"))
    {
    			SubscribeElementEvents_fwab_projectno(ref dfsParam);
    }
}
	if(methodName.ToLower().Equals("onclick"))
{
		if(elementName.ToLower().Equals("fwmf_availablebudget"))
{
			SubscribeElementEvents_fwmf_availablebudget(ref dfsParam);
}
		if(elementName.ToLower().Equals("pfm_no"))
{
			SubscribeElementEvents_pfm_no(ref dfsParam);
}
		if(elementName.ToLower().Equals("pfa_edit"))
{
			SubscribeElementEvents_pfa_edit(ref dfsParam);
}
		if(elementName.ToLower().Equals("pfa_widgetsubmit"))
{
			SubscribeElementEvents_pfa_widgetsubmit(ref dfsParam);
}
		if(elementName.ToLower().Equals("fwfm_save"))
{
			SubscribeElementEvents_fwfm_save(ref dfsParam);
}
		if(elementName.ToLower().Equals("pfm_yes"))
{
			SubscribeElementEvents_pfm_yes(ref dfsParam);
}
		if(elementName.ToLower().Equals("pfa_delete"))
{
			SubscribeElementEvents_pfa_delete(ref dfsParam);
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


	public partial class AcDataISpace94D43E66DFA94FBABE54B8CF4CDDF4E7  : ExtensionActivityBase
	{		
		
		
		private Dictionary<string,  List<Triplet<string, short, short?>>> queryExpressionBindings = 
											new Dictionary<string,  List<Triplet<string, short, short?>>>
		{
							{"7723a61c-ecbb-1093-d926-9eb94cd5ad4d", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_FundAllocation_RowId",3,
														   -1),
								   new Triplet<string, short, short?>("PFA_BudgetHead",9,
														   -1),
								   new Triplet<string, short, short?>("PFA_FundType",5,
														   -1),
								   new Triplet<string, short, short?>("PFA_Amount",11,
														   -1),
								   new Triplet<string, short, short?>("PFA_FundTypeValue",6,
														   -1),
								   new Triplet<string, short, short?>("PFA_ProjectNoValue",8,
														   -1),
								   new Triplet<string, short, short?>("PFA_ProjectNo",7,
														   -1),
								   new Triplet<string, short, short?>("PFA_FundDetailsId",12,
														   -1),
								   new Triplet<string, short, short?>("PFA_BudgetHeadValue",10,
														   -1),
								}
			},
							{"a2842489-fdd0-8948-e346-997ea4530fd2", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("PAB_Balance",6,
														   -1),
								   new Triplet<string, short, short?>("PAB_RecievedAmount",3,
														   -1),
								   new Triplet<string, short, short?>("PAB_Spent",5,
														   -1),
								   new Triplet<string, short, short?>("PAB_YetToRecieve",2,
														   -1),
								   new Triplet<string, short, short?>("PAB_SanctionedAmount",1,
														   -1),
								   new Triplet<string, short, short?>("PAB_Commitment",4,
														   -1),
								   new Triplet<string, short, short?>("PAB_BudgetName",0,
														   -1),
								}
			},
					};	

	

		private Dictionary<string,string> formVersionList =new Dictionary<string,string> 
		{
							{"14BDEA75-226F-483A-A930-DF5C58993C79", "Medium"},
					};	

		
		private Dictionary<string,string> formVersionLayoutList =new Dictionary<string,string> 
		{
							{"0AF8F682-1B76-490D-AC51-16CE4E60FD48", ""},
							{"2025977C-DADB-46F8-8B75-07A0443067CB", ""},
							{"14BDEA75-226F-483A-A930-DF5C58993C79", ""},
							{"41EAF3E1-E467-435F-86B8-60BF3CDE2D1D", ""},
							{"0246FF2A-0FD2-43E1-A17C-314172C9315C", ""},
							{"9E823A95-7AA6-4216-B876-EF0ED3F2C8FA", ""},
							{"F561E3EC-60DA-4FDF-8415-3D4490F44712", ""},
							{"C8E69F47-A3E0-4101-A1AA-22D1A293C7D9", ""},
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
		


