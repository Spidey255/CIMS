  







namespace CPS.Proof.DFSExtension
{
	using System;
    using System.Collections.Generic;     
	using System.Linq;
	
	
	public partial class ProjectOverviewProcessMetadata : ExtensionProcessBase
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
            get { return "08c9de00-05b0-4b62-aa5e-1dbada1b9158"; }
        }

        public override string ProcessName
        {
            get { return "ProjectOverview"; }
        }

		public override string ProcessDescription
        {
            get { return "Project Overview"; }
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
            get {return "08c9de00-05b0-4b62-aa5e-1dbada1b9158";}
        }

		public override byte ProcessInstanceMode
        {
            get {return 3;}
        }		

		public override string MasterFormId
        {
            get {  
				   return "30511266-0219-45B2-9647-28B8A4C85D86";	}
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
	

	public partial class ProjectOverviewObjectFactory  : ExtObjectFactoryBase
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
        //    return (IExtBaseMetaData)new ProjectOverviewProcessMetadata();
        //}
	


		private List<Triplet<string, string, string>> queryExpressionData = new List<Triplet<string, string, string>>
		{
	  			
			     new Triplet<string, string, string>("5F810DBE-6E52-4B47-8189-38E6D482CBB2","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("E3916D31-3C3D-4DC7-9C0A-7458E6D8BC0C","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"062C4298-5FB2-4C83-877D-A1D5795686CF"),
			
						
			     new Triplet<string, string, string>("05309A85-D55C-43B8-A687-C2A189F723E7","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"24F5D845-D560-4FC1-B284-00FB19DFB96F"),
			
						
			     new Triplet<string, string, string>("01000C9C-F4F7-4DAA-8E0E-4E2ACF3299FF","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"24F5D845-D560-4FC1-B284-00FB19DFB96F"),
			
						
			     new Triplet<string, string, string>("694B5E20-22B7-4684-B760-95809D295E97","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"062C4298-5FB2-4C83-877D-A1D5795686CF"),
			
						
			     new Triplet<string, string, string>("05309A85-D55C-43B8-A687-C2A189F723E7","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"24F5D845-D560-4FC1-B284-00FB19DFB96F"),
			
						
			     new Triplet<string, string, string>("24686D70-1FFF-4F4F-81D7-EE238FD68AC3","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"24F5D845-D560-4FC1-B284-00FB19DFB96F"),
			
						
			     new Triplet<string, string, string>("1A383FFC-832C-4917-9E68-F2D85A320241","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"062C4298-5FB2-4C83-877D-A1D5795686CF"),
			
						
			     new Triplet<string, string, string>("79D912FA-A379-47AA-85C0-BFA4CB4D1E46","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"062C4298-5FB2-4C83-877D-A1D5795686CF"),
			
						
			     new Triplet<string, string, string>("D840F8CC-4076-4F70-BB27-6BC03624E86F","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"24F5D845-D560-4FC1-B284-00FB19DFB96F"),
			
						
			     new Triplet<string, string, string>("05309A85-D55C-43B8-A687-C2A189F723E7","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"24F5D845-D560-4FC1-B284-00FB19DFB96F"),
			
						
			     new Triplet<string, string, string>("22C222E3-5648-4786-897E-70EBD8BF9872","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"062C4298-5FB2-4C83-877D-A1D5795686CF"),
			
						
			     new Triplet<string, string, string>("480BF671-BF49-4DAA-8AC2-0673FCA12E10","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"062C4298-5FB2-4C83-877D-A1D5795686CF"),
			
						
			     new Triplet<string, string, string>("01000C9C-F4F7-4DAA-8E0E-4E2ACF3299FF","Grid Binding",
												     @"6D81F5D4-0044-4EEC-8869-E22464BC04F3"),
			
						
			     new Triplet<string, string, string>("24686D70-1FFF-4F4F-81D7-EE238FD68AC3","Grid Binding",
												     @"4610BDD7-5FC0-4CA5-8EA2-5F96FD5C198A"),
			
						
			     new Triplet<string, string, string>("D840F8CC-4076-4F70-BB27-6BC03624E86F","Grid Binding",
												     @"A5CB07C2-D023-40F7-AF8D-FFF3CE6738DA"),
			
			
			
		};

		
		private List<Triplet<string, string, string>> ComboDataSource = new List<Triplet<string, string, string>>
		{

		
	  			
			     new Triplet<string, string, string>("MF_ReceiptsView_GridRows","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMAvOzkFMmxHUuxhHgktDkfvWfwBNgoOezuIQDeIjZtCKIIrSN+GjapRg==",
												     @"EXEC [dbo].[SP_GetAutoFormGridRows]"),
			
						
			     new Triplet<string, string, string>("MF_ProjectCommitments_GridRows","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMAvOzkFMmxHUuxhHgktDkfvWfwBNgoOezuIQDeIjZtCKIIrSN+GjapRg==",
												     @"EXEC [dbo].[SP_GetAutoFormGridRows]"),
			
						
			     new Triplet<string, string, string>("MF_Budgetdetails_GridRows","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMAvOzkFMmxHUuxhHgktDkfvWfwBNgoOezuIQDeIjZtCKIIrSN+GjapRg==",
												     @"EXEC [dbo].[SP_GetAutoFormGridRows]"),
			
						
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
		
	  			
			     new Tuple<string, int>("ProjectCommitments",1000),
			
						
			     new Tuple<string, int>("ReceiptsView",1000),
			
						
			     new Tuple<string, int>("Budgetdetails",1000),
			
						
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
											case "585BA2B8-3E75-4DAB-B50B-10D8320CE414":
							virtualInstance=new ISpace585BA2B83E754DABB50B10D8320CE414();
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
	

	public partial class ProjectOverviewDataElementFactory  : ExtElementBase
    {

     /// <summary>
        /// A <see cref="log4net.ILog"/> that contains the logger instance for 
        /// logging
        /// </summary>
        private readonly ILog _sysLog;

        public ProjectOverviewDataElementFactory()
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

               
                
                                      case "30511266-0219-45B2-9647-28B8A4C85D86":
                    {
                     
                                     fInsertQuery=@"IF NOT EXISTS(SELECT 1 FROM [30511266-0219-45B2-9647-28B8A4C85D86] WHERE InstanceId='{0}' AND
							ProcessActivityMapId='{1}' AND FormId='{2}') BEGIN INSERT INTO [30511266-0219-45B2-9647-28B8A4C85D86](ProcessActivityMapId,FormId,MF_ProjectCommitments_GridRows,MF_ProjectCommitments_RecordsRange,MF_ProjectCommitments_PageIndex,MF_ProjectCommitments_TotalPages,MF_V1_ExpenseID,MF_V1_BudgetHead,MF_V1_ProjectDetailsID,MF_V1_PackageProcessMapID,MF_V1_ExpenseDate,MF_V1_AmountSpent,MF_V1_ExpenseDescription,MF_Option,MF_ReceiptsView_GridRows,MF_ReceiptsView_RecordsRange,MF_ReceiptsView_PageIndex,MF_ReceiptsView_TotalPages,MF_P1_ReceiptsId,MF_P1_ProjectDetailsId,MF_P1_ReceiptAmount,MF_P1_ReceiptDate,MF_P1_TransferType,MF_P1_TransferReferenceNumber,MF_P1_TransferReferenceDate,MF_P1_TransferReferenceBankId,MF_P1_TransferReferenceBranch,MF_P1_ReceiptNo,F_ReceiptNo,MF_Budgetdetails_GridRows,MF_Budgetdetails_RecordsRange,MF_Budgetdetails_PageIndex,MF_Budgetdetails_TotalPages,MF_V1_BudgetHeadID,MF_V1_SanctionedAmount,MF_V1_ReceivedAmount,MF_V1_YettoReceive,MF_V1_Spent,MF_V1_Committment,MF_V1_Balance,F_BudgetHeadId,Subject,ExecutionStatus,ExecutionMessage,SetDestinationTo,SLATime,RefId,F_ProjectDetailsId,MF_PI,MF_COPI,FC_StartDate,FC_EndDate,FC_ProjectNo,FC_ProjectName,FC_AgencyCode,FC_Category,FC_SanctionNo,FC_SanctionedDate,FC_SanctionedValue,InstanceId)
							VALUES( {3}) END ELSE BEGIN UPDATE [30511266-0219-45B2-9647-28B8A4C85D86]SET {4}WHERE InstanceId='{0}'END ";

                                     colList=@"ProcessActivityMapId,FormId,MF_ProjectCommitments_GridRows,MF_ProjectCommitments_RecordsRange,MF_ProjectCommitments_PageIndex,MF_ProjectCommitments_TotalPages,MF_V1_ExpenseID,MF_V1_BudgetHead,MF_V1_ProjectDetailsID,MF_V1_PackageProcessMapID,MF_V1_ExpenseDate,MF_V1_AmountSpent,MF_V1_ExpenseDescription,MF_Option,MF_ReceiptsView_GridRows,MF_ReceiptsView_RecordsRange,MF_ReceiptsView_PageIndex,MF_ReceiptsView_TotalPages,MF_P1_ReceiptsId,MF_P1_ProjectDetailsId,MF_P1_ReceiptAmount,MF_P1_ReceiptDate,MF_P1_TransferType,MF_P1_TransferReferenceNumber,MF_P1_TransferReferenceDate,MF_P1_TransferReferenceBankId,MF_P1_TransferReferenceBranch,MF_P1_ReceiptNo,F_ReceiptNo,MF_Budgetdetails_GridRows,MF_Budgetdetails_RecordsRange,MF_Budgetdetails_PageIndex,MF_Budgetdetails_TotalPages,MF_V1_BudgetHeadID,MF_V1_SanctionedAmount,MF_V1_ReceivedAmount,MF_V1_YettoReceive,MF_V1_Spent,MF_V1_Committment,MF_V1_Balance,F_BudgetHeadId,Subject,ExecutionStatus,ExecutionMessage,SetDestinationTo,SLATime,RefId,F_ProjectDetailsId,MF_PI,MF_COPI,FC_StartDate,FC_EndDate,FC_ProjectNo,FC_ProjectName,FC_AgencyCode,FC_Category,FC_SanctionNo,FC_SanctionedDate,FC_SanctionedValue,InstanceId";
                                    
                     
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
                                            case 8:
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

                
                 
                                      case "4610BDD7-5FC0-4CA5-8EA2-5F96FD5C198A":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_4610BDD75FC04CA58EA25F96FD5C198A AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MGG_P1_ReceiptsId] VARCHAR(MAX)	, [MGG_P1_ProjectDetailsId] VARCHAR(MAX)	, [MGG_P1_ReceiptAmount] DECIMAL(18,2)	, [MGG_P1_ReceiptDate] DATETIME	, [MGG_P1_TransferType] VARCHAR(MAX)	, [MGG_P1_TransferReferenceNumber] VARCHAR(MAX)	, [MGG_P1_TransferReferenceDate] DATETIME	, [MGG_P1_TransferReferenceBankId] VARCHAR(MAX)	, [MGG_P1_TransferReferenceBranch] VARCHAR(MAX)	, [MGG_P1_ReceiptNo] VARCHAR(MAX)){0}INSERT INTO [4610BDD7-5FC0-4CA5-8EA2-5F96FD5C198A](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MGG_P1_ReceiptsId,MGG_P1_ProjectDetailsId,MGG_P1_ReceiptAmount,MGG_P1_ReceiptDate,MGG_P1_TransferType,MGG_P1_TransferReferenceNumber,MGG_P1_TransferReferenceDate,MGG_P1_TransferReferenceBankId,MGG_P1_TransferReferenceBranch,MGG_P1_ReceiptNo)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MGG_P1_ReceiptsId,TDT.MGG_P1_ProjectDetailsId,TDT.MGG_P1_ReceiptAmount,TDT.MGG_P1_ReceiptDate,TDT.MGG_P1_TransferType,TDT.MGG_P1_TransferReferenceNumber,TDT.MGG_P1_TransferReferenceDate,TDT.MGG_P1_TransferReferenceBankId,TDT.MGG_P1_TransferReferenceBranch,TDT.MGG_P1_ReceiptNo FROM @TBL_4610BDD75FC04CA58EA25F96FD5C198A TDT
							LEFT JOIN [4610BDD7-5FC0-4CA5-8EA2-5F96FD5C198A] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MGG_P1_ReceiptsId=TDT.MGG_P1_ReceiptsId,MGG_P1_ProjectDetailsId=TDT.MGG_P1_ProjectDetailsId,MGG_P1_ReceiptAmount=TDT.MGG_P1_ReceiptAmount,MGG_P1_ReceiptDate=TDT.MGG_P1_ReceiptDate,MGG_P1_TransferType=TDT.MGG_P1_TransferType,MGG_P1_TransferReferenceNumber=TDT.MGG_P1_TransferReferenceNumber,MGG_P1_TransferReferenceDate=TDT.MGG_P1_TransferReferenceDate,MGG_P1_TransferReferenceBankId=TDT.MGG_P1_TransferReferenceBankId,MGG_P1_TransferReferenceBranch=TDT.MGG_P1_TransferReferenceBranch,MGG_P1_ReceiptNo=TDT.MGG_P1_ReceiptNo FROM @TBL_4610BDD75FC04CA58EA25F96FD5C198A TDT
							JOIN [4610BDD7-5FC0-4CA5-8EA2-5F96FD5C198A] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MGG_P1_ReceiptsId,MGG_P1_ProjectDetailsId,MGG_P1_ReceiptAmount,MGG_P1_ReceiptDate,MGG_P1_TransferType,MGG_P1_TransferReferenceNumber,MGG_P1_TransferReferenceDate,MGG_P1_TransferReferenceBankId,MGG_P1_TransferReferenceBranch,MGG_P1_ReceiptNo";

                                     tempInsertQuery=@"INSERT INTO @TBL_4610BDD75FC04CA58EA25F96FD5C198A(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MGG_P1_ReceiptsId,MGG_P1_ProjectDetailsId,MGG_P1_ReceiptAmount,MGG_P1_ReceiptDate,MGG_P1_TransferType,MGG_P1_TransferReferenceNumber,MGG_P1_TransferReferenceDate,MGG_P1_TransferReferenceBankId,MGG_P1_TransferReferenceBranch,MGG_P1_ReceiptNo)VALUES({0});";
                                     

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
                     
                                    case "A5CB07C2-D023-40F7-AF8D-FFF3CE6738DA":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_A5CB07C2D02340F7AF8DFFF3CE6738DA AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MGG_V1_BudgetHeadID] VARCHAR(MAX)	, [MGG_V1_SanctionedAmount] DECIMAL(18,2)	, [MGG_V1_ReceivedAmount] DECIMAL(18,2)	, [MGG_V1_YettoReceive] DECIMAL(18,2)	, [MGG_V1_Spent] DECIMAL(18,2)	, [MGG_V1_Committment] DECIMAL(18,2)	, [MGG_V1_Balance] DECIMAL(18,2)){0}INSERT INTO [A5CB07C2-D023-40F7-AF8D-FFF3CE6738DA](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MGG_V1_BudgetHeadID,MGG_V1_SanctionedAmount,MGG_V1_ReceivedAmount,MGG_V1_YettoReceive,MGG_V1_Spent,MGG_V1_Committment,MGG_V1_Balance)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MGG_V1_BudgetHeadID,TDT.MGG_V1_SanctionedAmount,TDT.MGG_V1_ReceivedAmount,TDT.MGG_V1_YettoReceive,TDT.MGG_V1_Spent,TDT.MGG_V1_Committment,TDT.MGG_V1_Balance FROM @TBL_A5CB07C2D02340F7AF8DFFF3CE6738DA TDT
							LEFT JOIN [A5CB07C2-D023-40F7-AF8D-FFF3CE6738DA] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MGG_V1_BudgetHeadID=TDT.MGG_V1_BudgetHeadID,MGG_V1_SanctionedAmount=TDT.MGG_V1_SanctionedAmount,MGG_V1_ReceivedAmount=TDT.MGG_V1_ReceivedAmount,MGG_V1_YettoReceive=TDT.MGG_V1_YettoReceive,MGG_V1_Spent=TDT.MGG_V1_Spent,MGG_V1_Committment=TDT.MGG_V1_Committment,MGG_V1_Balance=TDT.MGG_V1_Balance FROM @TBL_A5CB07C2D02340F7AF8DFFF3CE6738DA TDT
							JOIN [A5CB07C2-D023-40F7-AF8D-FFF3CE6738DA] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MGG_V1_BudgetHeadID,MGG_V1_SanctionedAmount,MGG_V1_ReceivedAmount,MGG_V1_YettoReceive,MGG_V1_Spent,MGG_V1_Committment,MGG_V1_Balance";

                                     tempInsertQuery=@"INSERT INTO @TBL_A5CB07C2D02340F7AF8DFFF3CE6738DA(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MGG_V1_BudgetHeadID,MGG_V1_SanctionedAmount,MGG_V1_ReceivedAmount,MGG_V1_YettoReceive,MGG_V1_Spent,MGG_V1_Committment,MGG_V1_Balance)VALUES({0});";
                                     

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
                     
                                    case "6D81F5D4-0044-4EEC-8869-E22464BC04F3":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_6D81F5D400444EEC8869E22464BC04F3 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MGG_V1_ExpenseID] VARCHAR(MAX)	, [MGG_V1_BudgetHead] VARCHAR(MAX)	, [MGG_V1_ProjectDetailsID] VARCHAR(MAX)	, [MGG_V1_PackageProcessMapID] VARCHAR(MAX)	, [MGG_V1_ExpenseDate] DATETIME	, [MGG_V1_AmountSpent] DECIMAL(18,2)	, [MGG_V1_ExpenseDescription] VARCHAR(MAX)){0}INSERT INTO [6D81F5D4-0044-4EEC-8869-E22464BC04F3](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MGG_V1_ExpenseID,MGG_V1_BudgetHead,MGG_V1_ProjectDetailsID,MGG_V1_PackageProcessMapID,MGG_V1_ExpenseDate,MGG_V1_AmountSpent,MGG_V1_ExpenseDescription)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MGG_V1_ExpenseID,TDT.MGG_V1_BudgetHead,TDT.MGG_V1_ProjectDetailsID,TDT.MGG_V1_PackageProcessMapID,TDT.MGG_V1_ExpenseDate,TDT.MGG_V1_AmountSpent,TDT.MGG_V1_ExpenseDescription FROM @TBL_6D81F5D400444EEC8869E22464BC04F3 TDT
							LEFT JOIN [6D81F5D4-0044-4EEC-8869-E22464BC04F3] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MGG_V1_ExpenseID=TDT.MGG_V1_ExpenseID,MGG_V1_BudgetHead=TDT.MGG_V1_BudgetHead,MGG_V1_ProjectDetailsID=TDT.MGG_V1_ProjectDetailsID,MGG_V1_PackageProcessMapID=TDT.MGG_V1_PackageProcessMapID,MGG_V1_ExpenseDate=TDT.MGG_V1_ExpenseDate,MGG_V1_AmountSpent=TDT.MGG_V1_AmountSpent,MGG_V1_ExpenseDescription=TDT.MGG_V1_ExpenseDescription FROM @TBL_6D81F5D400444EEC8869E22464BC04F3 TDT
							JOIN [6D81F5D4-0044-4EEC-8869-E22464BC04F3] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MGG_V1_ExpenseID,MGG_V1_BudgetHead,MGG_V1_ProjectDetailsID,MGG_V1_PackageProcessMapID,MGG_V1_ExpenseDate,MGG_V1_AmountSpent,MGG_V1_ExpenseDescription";

                                     tempInsertQuery=@"INSERT INTO @TBL_6D81F5D400444EEC8869E22464BC04F3(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MGG_V1_ExpenseID,MGG_V1_BudgetHead,MGG_V1_ProjectDetailsID,MGG_V1_PackageProcessMapID,MGG_V1_ExpenseDate,MGG_V1_AmountSpent,MGG_V1_ExpenseDescription)VALUES({0});";
                                     

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
                     

                                         case "4610BDD7-5FC0-4CA5-8EA2-5F96FD5C198A":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_4610BDD75FC04CA58EA25F96FD5C198A AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MGG_P1_ReceiptsId] VARCHAR(MAX)	, [MGG_P1_ProjectDetailsId] VARCHAR(MAX)	, [MGG_P1_ReceiptAmount] DECIMAL(18,2)	, [MGG_P1_ReceiptDate] DATETIME	, [MGG_P1_TransferType] VARCHAR(MAX)	, [MGG_P1_TransferReferenceNumber] VARCHAR(MAX)	, [MGG_P1_TransferReferenceDate] DATETIME	, [MGG_P1_TransferReferenceBankId] VARCHAR(MAX)	, [MGG_P1_TransferReferenceBranch] VARCHAR(MAX)	, [MGG_P1_ReceiptNo] VARCHAR(MAX)){0}INSERT INTO [4610BDD7-5FC0-4CA5-8EA2-5F96FD5C198A](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MGG_P1_ReceiptsId,MGG_P1_ProjectDetailsId,MGG_P1_ReceiptAmount,MGG_P1_ReceiptDate,MGG_P1_TransferType,MGG_P1_TransferReferenceNumber,MGG_P1_TransferReferenceDate,MGG_P1_TransferReferenceBankId,MGG_P1_TransferReferenceBranch,MGG_P1_ReceiptNo)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MGG_P1_ReceiptsId,TDT.MGG_P1_ProjectDetailsId,TDT.MGG_P1_ReceiptAmount,TDT.MGG_P1_ReceiptDate,TDT.MGG_P1_TransferType,TDT.MGG_P1_TransferReferenceNumber,TDT.MGG_P1_TransferReferenceDate,TDT.MGG_P1_TransferReferenceBankId,TDT.MGG_P1_TransferReferenceBranch,TDT.MGG_P1_ReceiptNo FROM @TBL_4610BDD75FC04CA58EA25F96FD5C198A TDT
							LEFT JOIN [4610BDD7-5FC0-4CA5-8EA2-5F96FD5C198A] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MGG_P1_ReceiptsId=TDT.MGG_P1_ReceiptsId,MGG_P1_ProjectDetailsId=TDT.MGG_P1_ProjectDetailsId,MGG_P1_ReceiptAmount=TDT.MGG_P1_ReceiptAmount,MGG_P1_ReceiptDate=TDT.MGG_P1_ReceiptDate,MGG_P1_TransferType=TDT.MGG_P1_TransferType,MGG_P1_TransferReferenceNumber=TDT.MGG_P1_TransferReferenceNumber,MGG_P1_TransferReferenceDate=TDT.MGG_P1_TransferReferenceDate,MGG_P1_TransferReferenceBankId=TDT.MGG_P1_TransferReferenceBankId,MGG_P1_TransferReferenceBranch=TDT.MGG_P1_TransferReferenceBranch,MGG_P1_ReceiptNo=TDT.MGG_P1_ReceiptNo FROM @TBL_4610BDD75FC04CA58EA25F96FD5C198A TDT
							JOIN [4610BDD7-5FC0-4CA5-8EA2-5F96FD5C198A] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MGG_P1_ReceiptsId,MGG_P1_ProjectDetailsId,MGG_P1_ReceiptAmount,MGG_P1_ReceiptDate,MGG_P1_TransferType,MGG_P1_TransferReferenceNumber,MGG_P1_TransferReferenceDate,MGG_P1_TransferReferenceBankId,MGG_P1_TransferReferenceBranch,MGG_P1_ReceiptNo";

                            tempInsertQuery=@"INSERT INTO @TBL_4610BDD75FC04CA58EA25F96FD5C198A(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MGG_P1_ReceiptsId,MGG_P1_ProjectDetailsId,MGG_P1_ReceiptAmount,MGG_P1_ReceiptDate,MGG_P1_TransferType,MGG_P1_TransferReferenceNumber,MGG_P1_TransferReferenceDate,MGG_P1_TransferReferenceBankId,MGG_P1_TransferReferenceBranch,MGG_P1_ReceiptNo)VALUES({0});";

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

                                              case "A5CB07C2-D023-40F7-AF8D-FFF3CE6738DA":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_A5CB07C2D02340F7AF8DFFF3CE6738DA AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MGG_V1_BudgetHeadID] VARCHAR(MAX)	, [MGG_V1_SanctionedAmount] DECIMAL(18,2)	, [MGG_V1_ReceivedAmount] DECIMAL(18,2)	, [MGG_V1_YettoReceive] DECIMAL(18,2)	, [MGG_V1_Spent] DECIMAL(18,2)	, [MGG_V1_Committment] DECIMAL(18,2)	, [MGG_V1_Balance] DECIMAL(18,2)){0}INSERT INTO [A5CB07C2-D023-40F7-AF8D-FFF3CE6738DA](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MGG_V1_BudgetHeadID,MGG_V1_SanctionedAmount,MGG_V1_ReceivedAmount,MGG_V1_YettoReceive,MGG_V1_Spent,MGG_V1_Committment,MGG_V1_Balance)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MGG_V1_BudgetHeadID,TDT.MGG_V1_SanctionedAmount,TDT.MGG_V1_ReceivedAmount,TDT.MGG_V1_YettoReceive,TDT.MGG_V1_Spent,TDT.MGG_V1_Committment,TDT.MGG_V1_Balance FROM @TBL_A5CB07C2D02340F7AF8DFFF3CE6738DA TDT
							LEFT JOIN [A5CB07C2-D023-40F7-AF8D-FFF3CE6738DA] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MGG_V1_BudgetHeadID=TDT.MGG_V1_BudgetHeadID,MGG_V1_SanctionedAmount=TDT.MGG_V1_SanctionedAmount,MGG_V1_ReceivedAmount=TDT.MGG_V1_ReceivedAmount,MGG_V1_YettoReceive=TDT.MGG_V1_YettoReceive,MGG_V1_Spent=TDT.MGG_V1_Spent,MGG_V1_Committment=TDT.MGG_V1_Committment,MGG_V1_Balance=TDT.MGG_V1_Balance FROM @TBL_A5CB07C2D02340F7AF8DFFF3CE6738DA TDT
							JOIN [A5CB07C2-D023-40F7-AF8D-FFF3CE6738DA] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MGG_V1_BudgetHeadID,MGG_V1_SanctionedAmount,MGG_V1_ReceivedAmount,MGG_V1_YettoReceive,MGG_V1_Spent,MGG_V1_Committment,MGG_V1_Balance";

                            tempInsertQuery=@"INSERT INTO @TBL_A5CB07C2D02340F7AF8DFFF3CE6738DA(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MGG_V1_BudgetHeadID,MGG_V1_SanctionedAmount,MGG_V1_ReceivedAmount,MGG_V1_YettoReceive,MGG_V1_Spent,MGG_V1_Committment,MGG_V1_Balance)VALUES({0});";

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

                                              case "6D81F5D4-0044-4EEC-8869-E22464BC04F3":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_6D81F5D400444EEC8869E22464BC04F3 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MGG_V1_ExpenseID] VARCHAR(MAX)	, [MGG_V1_BudgetHead] VARCHAR(MAX)	, [MGG_V1_ProjectDetailsID] VARCHAR(MAX)	, [MGG_V1_PackageProcessMapID] VARCHAR(MAX)	, [MGG_V1_ExpenseDate] DATETIME	, [MGG_V1_AmountSpent] DECIMAL(18,2)	, [MGG_V1_ExpenseDescription] VARCHAR(MAX)){0}INSERT INTO [6D81F5D4-0044-4EEC-8869-E22464BC04F3](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MGG_V1_ExpenseID,MGG_V1_BudgetHead,MGG_V1_ProjectDetailsID,MGG_V1_PackageProcessMapID,MGG_V1_ExpenseDate,MGG_V1_AmountSpent,MGG_V1_ExpenseDescription)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MGG_V1_ExpenseID,TDT.MGG_V1_BudgetHead,TDT.MGG_V1_ProjectDetailsID,TDT.MGG_V1_PackageProcessMapID,TDT.MGG_V1_ExpenseDate,TDT.MGG_V1_AmountSpent,TDT.MGG_V1_ExpenseDescription FROM @TBL_6D81F5D400444EEC8869E22464BC04F3 TDT
							LEFT JOIN [6D81F5D4-0044-4EEC-8869-E22464BC04F3] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MGG_V1_ExpenseID=TDT.MGG_V1_ExpenseID,MGG_V1_BudgetHead=TDT.MGG_V1_BudgetHead,MGG_V1_ProjectDetailsID=TDT.MGG_V1_ProjectDetailsID,MGG_V1_PackageProcessMapID=TDT.MGG_V1_PackageProcessMapID,MGG_V1_ExpenseDate=TDT.MGG_V1_ExpenseDate,MGG_V1_AmountSpent=TDT.MGG_V1_AmountSpent,MGG_V1_ExpenseDescription=TDT.MGG_V1_ExpenseDescription FROM @TBL_6D81F5D400444EEC8869E22464BC04F3 TDT
							JOIN [6D81F5D4-0044-4EEC-8869-E22464BC04F3] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MGG_V1_ExpenseID,MGG_V1_BudgetHead,MGG_V1_ProjectDetailsID,MGG_V1_PackageProcessMapID,MGG_V1_ExpenseDate,MGG_V1_AmountSpent,MGG_V1_ExpenseDescription";

                            tempInsertQuery=@"INSERT INTO @TBL_6D81F5D400444EEC8869E22464BC04F3(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MGG_V1_ExpenseID,MGG_V1_BudgetHead,MGG_V1_ProjectDetailsID,MGG_V1_PackageProcessMapID,MGG_V1_ExpenseDate,MGG_V1_AmountSpent,MGG_V1_ExpenseDescription)VALUES({0});";

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
public class ISpace585BA2B83E754DABB50B10D8320CE414 : VirtualForm
{
IISpace iSpace = new ISpace();
AcDataISpace585BA2B83E754DABB50B10D8320CE414 acdataIspace585BA2B83E754DABB50B10D8320CE414=new AcDataISpace585BA2B83E754DABB50B10D8320CE414();
private void SubscribeFormEvents_root(ref Dictionary<string, ServiceElementData> ISpace)
{
try
{
base.WriteDebugInfo(@"Root-OnAfterFormLoad");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["F_ProjectDetailsId"].Value=ISpace["RefId"].Value;
base.WriteDebugInfo(@"ISpace[""F_ProjectDetailsId""].Value=ISpace[""RefId""].Value;");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["F_ProjectDetailsId"].Value=ISpace["RefId"].Value;
base.WriteDebugInfo(@"ISpace[""F_ProjectDetailsId""].Value=ISpace[""RefId""].Value;");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["F_ProjectDetailsId"].Value=ISpace["RefId"].Value;
base.WriteDebugInfo(@"ISpace[""F_ProjectDetailsId""].Value=ISpace[""RefId""].Value;");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["RefId"].Value=ISpace["F_ProjectDetailsID"].Value;
base.WriteDebugInfo(@"ISpace[""RefId""].Value=ISpace[""F_ProjectDetailsID""].Value;");
}
base.WriteDebugInfo(@"EXEC GetSponsoredProjectDetails '#F_ProjectDetailsId'");

var querySource5F810DBE6E524B47818938E6D482CBB2 =GetQueryExpressionDataSource("5F810DBE-6E52-4B47-8189-38E6D482CBB2");
Dictionary<short,object> result5F810DBE6E524B47818938E6D482CBB2=iSpace.ExecuteQuery(querySource5F810DBE6E524B47818938E6D482CBB2,@"EXEC GetSponsoredProjectDetails '" + ISpace["F_ProjectDetailsId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource5F810DBE6E524B47818938E6D482CBB2 =GetQueryExpressionDataSource(""5F810DBE-6E52-4B47-8189-38E6D482CBB2"");Dictionary<short,object> result5F810DBE6E524B47818938E6D482CBB2=iSpace.ExecuteQuery(querySource5F810DBE6E524B47818938E6D482CBB2,@""EXEC GetSponsoredProjectDetails '"" + ISpace[""F_ProjectDetailsId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result5F810DBE6E524B47818938E6D482CBB2!=null) && (result5F810DBE6E524B47818938E6D482CBB2.Count!=0))
{
if(result5F810DBE6E524B47818938E6D482CBB2.ContainsKey(8))
ISpace["FC_SanctionedDate"].Value = result5F810DBE6E524B47818938E6D482CBB2[8];
if(result5F810DBE6E524B47818938E6D482CBB2.ContainsKey(4))
ISpace["FC_StartDate"].Value = result5F810DBE6E524B47818938E6D482CBB2[4];
if(result5F810DBE6E524B47818938E6D482CBB2.ContainsKey(5))
ISpace["FC_EndDate"].Value = result5F810DBE6E524B47818938E6D482CBB2[5];
if(result5F810DBE6E524B47818938E6D482CBB2.ContainsKey(2))
ISpace["FC_AgencyCode"].Value = result5F810DBE6E524B47818938E6D482CBB2[2];
if(result5F810DBE6E524B47818938E6D482CBB2.ContainsKey(3))
ISpace["FC_ProjectName"].Value = result5F810DBE6E524B47818938E6D482CBB2[3];
if(result5F810DBE6E524B47818938E6D482CBB2.ContainsKey(1))
ISpace["FC_ProjectNo"].Value = result5F810DBE6E524B47818938E6D482CBB2[1];
if(result5F810DBE6E524B47818938E6D482CBB2.ContainsKey(7))
ISpace["FC_SanctionNo"].Value = result5F810DBE6E524B47818938E6D482CBB2[7];
if(result5F810DBE6E524B47818938E6D482CBB2.ContainsKey(10))
ISpace["FC_SanctionedValue"].Value = result5F810DBE6E524B47818938E6D482CBB2[10];
if(result5F810DBE6E524B47818938E6D482CBB2.ContainsKey(14))
ISpace["FC_Category"].Value = result5F810DBE6E524B47818938E6D482CBB2[14];
}
else{
ISpace["FC_SanctionedDate"].Value = null;ISpace["FC_StartDate"].Value = null;ISpace["FC_EndDate"].Value = null;ISpace["FC_AgencyCode"].Value = null;ISpace["FC_ProjectName"].Value = null;ISpace["FC_ProjectNo"].Value = null;ISpace["FC_SanctionNo"].Value = null;ISpace["FC_SanctionedValue"].Value = null;ISpace["FC_Category"].Value = null;
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["MF_V1_Balance"].Visible="true";ISpace["MF_V1_Balance"].Man=true;ISpace["MF_V1_Balance"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_V1_Balance""].Visible=""true"";ISpace[""MF_V1_Balance""].Man=true;ISpace[""MF_V1_Balance""].Enbl=""true"";");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["FormVersionId"].Value=="F7DA2CD7-1723-45E3-94F5-6380EB2F0989")
{
ISpace["UI_Panel"].Visible="true";ISpace["UI_Panel"].Enbl="true";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""F7DA2CD7-1723-45E3-94F5-6380EB2F0989"")
{
ISpace[""UI_Panel""].Visible=""true"";ISpace[""UI_Panel""].Enbl=""true"";
}");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["FormVersionId"].Value=="F7DA2CD7-1723-45E3-94F5-6380EB2F0989")
{
ISpace["UI_Panel"].Visible="true";ISpace["UI_Panel"].Enbl="true";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""F7DA2CD7-1723-45E3-94F5-6380EB2F0989"")
{
ISpace[""UI_Panel""].Visible=""true"";ISpace[""UI_Panel""].Enbl=""true"";
}");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["FormVersionId"].Value=="F7DA2CD7-1723-45E3-94F5-6380EB2F0989")
{
ISpace["UI_Panel"].Visible="true";ISpace["UI_Panel"].Enbl="true";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""F7DA2CD7-1723-45E3-94F5-6380EB2F0989"")
{
ISpace[""UI_Panel""].Visible=""true"";ISpace[""UI_Panel""].Enbl=""true"";
}");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 0,'#F_BudgetHeadId','',#MF_Budgetdetails_PageIndex,'#MF_Budgetdetails_GridRows','#F_ProjectDetailsId'");

var querySource05309A85D55C43B8A687C2A189F723E7 =GetQueryExpressionDataSource("05309A85-D55C-43B8-A687-C2A189F723E7");
Dictionary<short,object> result05309A85D55C43B8A687C2A189F723E7=iSpace.ExecuteQuery(querySource05309A85D55C43B8A687C2A189F723E7,@"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 0,'" + ISpace["F_BudgetHeadId"].Value + @"',''," + ISpace["MF_Budgetdetails_PageIndex"].Value + @",'" + ISpace["MF_Budgetdetails_GridRows"].Value + @"','" + ISpace["F_ProjectDetailsId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource05309A85D55C43B8A687C2A189F723E7 =GetQueryExpressionDataSource(""05309A85-D55C-43B8-A687-C2A189F723E7"");Dictionary<short,object> result05309A85D55C43B8A687C2A189F723E7=iSpace.ExecuteQuery(querySource05309A85D55C43B8A687C2A189F723E7,@""EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 0,'"" + ISpace[""F_BudgetHeadId""].Value + @""','',"" + ISpace[""MF_Budgetdetails_PageIndex""].Value + @"",'"" + ISpace[""MF_Budgetdetails_GridRows""].Value + @""','"" + ISpace[""F_ProjectDetailsId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result05309A85D55C43B8A687C2A189F723E7!=null) && (result05309A85D55C43B8A687C2A189F723E7.Count!=0))
{
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(0))
ISpace["MF_ProjectCommitments_GridRows"].Value = result05309A85D55C43B8A687C2A189F723E7[0];
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(3))
ISpace["MF_ProjectCommitments_TotalPages"].Value = result05309A85D55C43B8A687C2A189F723E7[3];
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(2))
ISpace["MF_ProjectCommitments_PageIndex"].Value = result05309A85D55C43B8A687C2A189F723E7[2];
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(1))
ISpace["MF_ProjectCommitments_RecordsRange"].Value = result05309A85D55C43B8A687C2A189F723E7[1];
}
else{
ISpace["MF_ProjectCommitments_GridRows"].Value = null;ISpace["MF_ProjectCommitments_TotalPages"].Value = null;ISpace["MF_ProjectCommitments_PageIndex"].Value = null;ISpace["MF_ProjectCommitments_RecordsRange"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 0,'#F_BudgetHeadId','',#MF_Budgetdetails_PageIndex,'#MF_Budgetdetails_GridRows','#F_ProjectDetailsId'");

var querySource05309A85D55C43B8A687C2A189F723E7 =GetQueryExpressionDataSource("05309A85-D55C-43B8-A687-C2A189F723E7");
Dictionary<short,object> result05309A85D55C43B8A687C2A189F723E7=iSpace.ExecuteQuery(querySource05309A85D55C43B8A687C2A189F723E7,@"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 0,'" + ISpace["F_BudgetHeadId"].Value + @"',''," + ISpace["MF_Budgetdetails_PageIndex"].Value + @",'" + ISpace["MF_Budgetdetails_GridRows"].Value + @"','" + ISpace["F_ProjectDetailsId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource05309A85D55C43B8A687C2A189F723E7 =GetQueryExpressionDataSource(""05309A85-D55C-43B8-A687-C2A189F723E7"");Dictionary<short,object> result05309A85D55C43B8A687C2A189F723E7=iSpace.ExecuteQuery(querySource05309A85D55C43B8A687C2A189F723E7,@""EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 0,'"" + ISpace[""F_BudgetHeadId""].Value + @""','',"" + ISpace[""MF_Budgetdetails_PageIndex""].Value + @"",'"" + ISpace[""MF_Budgetdetails_GridRows""].Value + @""','"" + ISpace[""F_ProjectDetailsId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result05309A85D55C43B8A687C2A189F723E7!=null) && (result05309A85D55C43B8A687C2A189F723E7.Count!=0))
{
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(0))
ISpace["MF_ProjectCommitments_GridRows"].Value = result05309A85D55C43B8A687C2A189F723E7[0];
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(3))
ISpace["MF_ProjectCommitments_TotalPages"].Value = result05309A85D55C43B8A687C2A189F723E7[3];
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(2))
ISpace["MF_ProjectCommitments_PageIndex"].Value = result05309A85D55C43B8A687C2A189F723E7[2];
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(1))
ISpace["MF_ProjectCommitments_RecordsRange"].Value = result05309A85D55C43B8A687C2A189F723E7[1];
}
else{
ISpace["MF_ProjectCommitments_GridRows"].Value = null;ISpace["MF_ProjectCommitments_TotalPages"].Value = null;ISpace["MF_ProjectCommitments_PageIndex"].Value = null;ISpace["MF_ProjectCommitments_RecordsRange"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 0,'#F_BudgetHeadId','',#MF_Budgetdetails_PageIndex,'#MF_Budgetdetails_GridRows','#F_ProjectDetailsId'");

var querySource05309A85D55C43B8A687C2A189F723E7 =GetQueryExpressionDataSource("05309A85-D55C-43B8-A687-C2A189F723E7");
Dictionary<short,object> result05309A85D55C43B8A687C2A189F723E7=iSpace.ExecuteQuery(querySource05309A85D55C43B8A687C2A189F723E7,@"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 0,'" + ISpace["F_BudgetHeadId"].Value + @"',''," + ISpace["MF_Budgetdetails_PageIndex"].Value + @",'" + ISpace["MF_Budgetdetails_GridRows"].Value + @"','" + ISpace["F_ProjectDetailsId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource05309A85D55C43B8A687C2A189F723E7 =GetQueryExpressionDataSource(""05309A85-D55C-43B8-A687-C2A189F723E7"");Dictionary<short,object> result05309A85D55C43B8A687C2A189F723E7=iSpace.ExecuteQuery(querySource05309A85D55C43B8A687C2A189F723E7,@""EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 0,'"" + ISpace[""F_BudgetHeadId""].Value + @""','',"" + ISpace[""MF_Budgetdetails_PageIndex""].Value + @"",'"" + ISpace[""MF_Budgetdetails_GridRows""].Value + @""','"" + ISpace[""F_ProjectDetailsId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result05309A85D55C43B8A687C2A189F723E7!=null) && (result05309A85D55C43B8A687C2A189F723E7.Count!=0))
{
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(0))
ISpace["MF_ProjectCommitments_GridRows"].Value = result05309A85D55C43B8A687C2A189F723E7[0];
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(3))
ISpace["MF_ProjectCommitments_TotalPages"].Value = result05309A85D55C43B8A687C2A189F723E7[3];
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(2))
ISpace["MF_ProjectCommitments_PageIndex"].Value = result05309A85D55C43B8A687C2A189F723E7[2];
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(1))
ISpace["MF_ProjectCommitments_RecordsRange"].Value = result05309A85D55C43B8A687C2A189F723E7[1];
}
else{
ISpace["MF_ProjectCommitments_GridRows"].Value = null;ISpace["MF_ProjectCommitments_TotalPages"].Value = null;ISpace["MF_ProjectCommitments_PageIndex"].Value = null;ISpace["MF_ProjectCommitments_RecordsRange"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_Budgetdetails_PageIndex"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""MF_Budgetdetails_PageIndex""].Value==1)");
if(ISpace["MF_Budgetdetails_PageIndex"].Value==ISpace["MF_Budgetdetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_Budgetdetails_PageIndex""].Value==ISpace[""MF_Budgetdetails_TotalPages""].Value)");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="false";ISpace["MF_ProjectCommitments_LastButton"].Enbl="false";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="false";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="false";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""false"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="true";ISpace["MF_ProjectCommitments_LastButton"].Enbl="true";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="false";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="false";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""true"";");
}
}
else
{
base.WriteDebugInfo(@"else");
if(ISpace["MF_Budgetdetails_PageIndex"].Value==ISpace["MF_Budgetdetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_Budgetdetails_PageIndex""].Value==ISpace[""MF_Budgetdetails_TotalPages""].Value)");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="false";ISpace["MF_ProjectCommitments_LastButton"].Enbl="false";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="true";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="true";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="true";ISpace["MF_ProjectCommitments_LastButton"].Enbl="true";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="true";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="true";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""true"";");
}
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_Budgetdetails_PageIndex"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""MF_Budgetdetails_PageIndex""].Value==1)");
if(ISpace["MF_Budgetdetails_PageIndex"].Value==ISpace["MF_Budgetdetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_Budgetdetails_PageIndex""].Value==ISpace[""MF_Budgetdetails_TotalPages""].Value)");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="false";ISpace["MF_ProjectCommitments_LastButton"].Enbl="false";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="false";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="false";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""false"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="true";ISpace["MF_ProjectCommitments_LastButton"].Enbl="true";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="false";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="false";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""true"";");
}
}
else
{
base.WriteDebugInfo(@"else");
if(ISpace["MF_Budgetdetails_PageIndex"].Value==ISpace["MF_Budgetdetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_Budgetdetails_PageIndex""].Value==ISpace[""MF_Budgetdetails_TotalPages""].Value)");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="false";ISpace["MF_ProjectCommitments_LastButton"].Enbl="false";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="true";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="true";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="true";ISpace["MF_ProjectCommitments_LastButton"].Enbl="true";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="true";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="true";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""true"";");
}
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_Budgetdetails_PageIndex"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""MF_Budgetdetails_PageIndex""].Value==1)");
if(ISpace["MF_Budgetdetails_PageIndex"].Value==ISpace["MF_Budgetdetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_Budgetdetails_PageIndex""].Value==ISpace[""MF_Budgetdetails_TotalPages""].Value)");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="false";ISpace["MF_ProjectCommitments_LastButton"].Enbl="false";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="false";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="false";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""false"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="true";ISpace["MF_ProjectCommitments_LastButton"].Enbl="true";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="false";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="false";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""true"";");
}
}
else
{
base.WriteDebugInfo(@"else");
if(ISpace["MF_Budgetdetails_PageIndex"].Value==ISpace["MF_Budgetdetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_Budgetdetails_PageIndex""].Value==ISpace[""MF_Budgetdetails_TotalPages""].Value)");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="false";ISpace["MF_ProjectCommitments_LastButton"].Enbl="false";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="true";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="true";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="true";ISpace["MF_ProjectCommitments_LastButton"].Enbl="true";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="true";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="true";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""true"";");
}
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySource01000C9CF4F74DAA8E0E4E2ACF3299FF =GetQueryExpressionDataSource("01000C9C-F4F7-4DAA-8E0E-4E2ACF3299FF");

DataTable result01000C9CF4F74DAA8E0E4E2ACF3299FF=iSpace.SetGridDataSource(querySource01000C9CF4F74DAA8E0E4E2ACF3299FF, _objectFactory.GetGridRPP("ProjectCommitments"),@"EXEC dbo.[Get_e046fb44-e1f1-4f2a-a07e-231e72f92166_FilterData] 1,'" + ISpace["F_ProjectDetailsId"].Value + @"',''," + ISpace["MF_ProjectCommitments_PageIndex"].Value + @",'" + ISpace["MF_ProjectCommitments_GridRows"].Value + @"'");

iSpace.InsertGridBindDetails("ProjectCommitments","11",querySource01000C9CF4F74DAA8E0E4E2ACF3299FF,"EXEC dbo.[Get_e046fb44-e1f1-4f2a-a07e-231e72f92166_FilterData] 1,'" + ISpace["F_ProjectDetailsId"].Value + @"',''," + ISpace["MF_ProjectCommitments_PageIndex"].Value + @",'" + ISpace["MF_ProjectCommitments_GridRows"].Value + @"'",_objectFactory.GetGridRPP("ProjectCommitments"));

base.WriteDebugInfo(@"var querySource01000C9CF4F74DAA8E0E4E2ACF3299FF =GetQueryExpressionDataSource(""01000C9C-F4F7-4DAA-8E0E-4E2ACF3299FF"");DataTable result01000C9CF4F74DAA8E0E4E2ACF3299FF=iSpace.SetGridDataSource(querySource01000C9CF4F74DAA8E0E4E2ACF3299FF, _objectFactory.GetGridRPP(""ProjectCommitments""),@""EXEC dbo.[Get_e046fb44-e1f1-4f2a-a07e-231e72f92166_FilterData] 1,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',"" + ISpace[""MF_ProjectCommitments_PageIndex""].Value + @"",'"" + ISpace[""MF_ProjectCommitments_GridRows""].Value + @""'"");iSpace.InsertGridBindDetails(""ProjectCommitments"",""11"",querySource01000C9CF4F74DAA8E0E4E2ACF3299FF,""EXEC dbo.[Get_e046fb44-e1f1-4f2a-a07e-231e72f92166_FilterData] 1,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',"" + ISpace[""MF_ProjectCommitments_PageIndex""].Value + @"",'"" + ISpace[""MF_ProjectCommitments_GridRows""].Value + @""'"",_objectFactory.GetGridRPP(""ProjectCommitments""));");
base.WriteDebugInfo(@"EXEC dbo.[Get_e046fb44-e1f1-4f2a-a07e-231e72f92166_FilterData] 1,'#F_ProjectDetailsId','',#MF_ProjectCommitments_PageIndex,'#MF_ProjectCommitments_GridRows'");


List<Triplet<string, short, short?>> result34DD54DC0E5B46EAA0BBD99E022B7345=acdataIspace585BA2B83E754DABB50B10D8320CE414.GetQueryExpressionBindings("34DD54DC-0E5B-46EA-A0BB-D99E022B7345");
iSpace.SetGridData(result01000C9CF4F74DAA8E0E4E2ACF3299FF,result34DD54DC0E5B46EAA0BBD99E022B7345,"ProjectCommitments",ref ISpace);
iSpace.UpdateGridBindDetails("ProjectCommitments",result34DD54DC0E5B46EAA0BBD99E022B7345);
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySource24686D701FFF4F4F81D7EE238FD68AC3 =GetQueryExpressionDataSource("24686D70-1FFF-4F4F-81D7-EE238FD68AC3");

DataTable result24686D701FFF4F4F81D7EE238FD68AC3=iSpace.SetGridDataSource(querySource24686D701FFF4F4F81D7EE238FD68AC3, _objectFactory.GetGridRPP("ReceiptsView"),@"EXEC dbo.[Get_bd3abae8-b5a2-4b71-b3e2-e46732479592_FilterData] 1,'" + ISpace["F_ReceiptNo"].Value + @"',''," + ISpace["MF_ReceiptsView_PageIndex"].Value + @",'" + ISpace["MF_ReceiptsView_GridRows"].Value + @"','" + ISpace["F_ProjectDetailsID"].Value + @"'");

iSpace.InsertGridBindDetails("ReceiptsView","11",querySource24686D701FFF4F4F81D7EE238FD68AC3,"EXEC dbo.[Get_bd3abae8-b5a2-4b71-b3e2-e46732479592_FilterData] 1,'" + ISpace["F_ReceiptNo"].Value + @"',''," + ISpace["MF_ReceiptsView_PageIndex"].Value + @",'" + ISpace["MF_ReceiptsView_GridRows"].Value + @"','" + ISpace["F_ProjectDetailsID"].Value + @"'",_objectFactory.GetGridRPP("ReceiptsView"));

base.WriteDebugInfo(@"var querySource24686D701FFF4F4F81D7EE238FD68AC3 =GetQueryExpressionDataSource(""24686D70-1FFF-4F4F-81D7-EE238FD68AC3"");DataTable result24686D701FFF4F4F81D7EE238FD68AC3=iSpace.SetGridDataSource(querySource24686D701FFF4F4F81D7EE238FD68AC3, _objectFactory.GetGridRPP(""ReceiptsView""),@""EXEC dbo.[Get_bd3abae8-b5a2-4b71-b3e2-e46732479592_FilterData] 1,'"" + ISpace[""F_ReceiptNo""].Value + @""','',"" + ISpace[""MF_ReceiptsView_PageIndex""].Value + @"",'"" + ISpace[""MF_ReceiptsView_GridRows""].Value + @""','"" + ISpace[""F_ProjectDetailsID""].Value + @""'"");iSpace.InsertGridBindDetails(""ReceiptsView"",""11"",querySource24686D701FFF4F4F81D7EE238FD68AC3,""EXEC dbo.[Get_bd3abae8-b5a2-4b71-b3e2-e46732479592_FilterData] 1,'"" + ISpace[""F_ReceiptNo""].Value + @""','',"" + ISpace[""MF_ReceiptsView_PageIndex""].Value + @"",'"" + ISpace[""MF_ReceiptsView_GridRows""].Value + @""','"" + ISpace[""F_ProjectDetailsID""].Value + @""'"",_objectFactory.GetGridRPP(""ReceiptsView""));");
base.WriteDebugInfo(@"EXEC dbo.[Get_bd3abae8-b5a2-4b71-b3e2-e46732479592_FilterData] 1,'#F_ReceiptNo','',#MF_ReceiptsView_PageIndex,'#MF_ReceiptsView_GridRows'");


List<Triplet<string, short, short?>> result3E6384212EC24473A32F5167327104C5=acdataIspace585BA2B83E754DABB50B10D8320CE414.GetQueryExpressionBindings("3E638421-2EC2-4473-A32F-5167327104C5");
iSpace.SetGridData(result24686D701FFF4F4F81D7EE238FD68AC3,result3E6384212EC24473A32F5167327104C5,"ReceiptsView",ref ISpace);
iSpace.UpdateGridBindDetails("ReceiptsView",result3E6384212EC24473A32F5167327104C5);
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySourceD840F8CC40764F70BB276BC03624E86F =GetQueryExpressionDataSource("D840F8CC-4076-4F70-BB27-6BC03624E86F");

DataTable resultD840F8CC40764F70BB276BC03624E86F=iSpace.SetGridDataSource(querySourceD840F8CC40764F70BB276BC03624E86F, _objectFactory.GetGridRPP("Budgetdetails"),@"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 1,'" + ISpace["F_BudgetHeadId"].Value + @"',''," + ISpace["MF_Budgetdetails_PageIndex"].Value + @",'" + ISpace["MF_Budgetdetails_GridRows"].Value + @"','" + ISpace["F_ProjectDetailsId"].Value + @"'");

iSpace.InsertGridBindDetails("Budgetdetails","11",querySourceD840F8CC40764F70BB276BC03624E86F,"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 1,'" + ISpace["F_BudgetHeadId"].Value + @"',''," + ISpace["MF_Budgetdetails_PageIndex"].Value + @",'" + ISpace["MF_Budgetdetails_GridRows"].Value + @"','" + ISpace["F_ProjectDetailsId"].Value + @"'",_objectFactory.GetGridRPP("Budgetdetails"));

base.WriteDebugInfo(@"var querySourceD840F8CC40764F70BB276BC03624E86F =GetQueryExpressionDataSource(""D840F8CC-4076-4F70-BB27-6BC03624E86F"");DataTable resultD840F8CC40764F70BB276BC03624E86F=iSpace.SetGridDataSource(querySourceD840F8CC40764F70BB276BC03624E86F, _objectFactory.GetGridRPP(""Budgetdetails""),@""EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 1,'"" + ISpace[""F_BudgetHeadId""].Value + @""','',"" + ISpace[""MF_Budgetdetails_PageIndex""].Value + @"",'"" + ISpace[""MF_Budgetdetails_GridRows""].Value + @""','"" + ISpace[""F_ProjectDetailsId""].Value + @""'"");iSpace.InsertGridBindDetails(""Budgetdetails"",""11"",querySourceD840F8CC40764F70BB276BC03624E86F,""EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 1,'"" + ISpace[""F_BudgetHeadId""].Value + @""','',"" + ISpace[""MF_Budgetdetails_PageIndex""].Value + @"",'"" + ISpace[""MF_Budgetdetails_GridRows""].Value + @""','"" + ISpace[""F_ProjectDetailsId""].Value + @""'"",_objectFactory.GetGridRPP(""Budgetdetails""));");
base.WriteDebugInfo(@"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 1,'#F_BudgetHeadId','',#MF_Budgetdetails_PageIndex,'#MF_Budgetdetails_GridRows'");


List<Triplet<string, short, short?>> resultF197120EAAA7488594BFCD708A09CE9F=acdataIspace585BA2B83E754DABB50B10D8320CE414.GetQueryExpressionBindings("F197120E-AAA7-4885-94BF-CD708A09CE9F");
iSpace.SetGridData(resultD840F8CC40764F70BB276BC03624E86F,resultF197120EAAA7488594BFCD708A09CE9F,"Budgetdetails",ref ISpace);
iSpace.UpdateGridBindDetails("Budgetdetails",resultF197120EAAA7488594BFCD708A09CE9F);
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_add (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Add-OnClick");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["FormVersionId"].Value=="F7DA2CD7-1723-45E3-94F5-6380EB2F0989")
{
ISpace["UI_Panel"].Visible="false";ISpace["UI_Panel"].Enbl="true";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""F7DA2CD7-1723-45E3-94F5-6380EB2F0989"")
{
ISpace[""UI_Panel""].Visible=""false"";ISpace[""UI_Panel""].Enbl=""true"";
}");
ISpace["MF_V1_BudgetHeadID"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_V1_BudgetHeadID""].Value=null;");
ISpace["MF_V1_ProjectDetailsID"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_V1_ProjectDetailsID""].Value=null;");
ISpace["MF_V1_BudgetHead"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_V1_BudgetHead""].Value=null;");
ISpace["MF_V1_SanctionedAmount"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_V1_SanctionedAmount""].Value=null;");
ISpace["MF_V1_ReceivedAmount"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_V1_ReceivedAmount""].Value=null;");
ISpace["MF_V1_YettoReceive"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_V1_YettoReceive""].Value=null;");
ISpace["MF_V1_Spent"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_V1_Spent""].Value=null;");
ISpace["MF_V1_Committment"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_V1_Committment""].Value=null;");
ISpace["MF_V1_Balance"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_V1_Balance""].Value=null;");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["FormVersionId"].Value=="F7DA2CD7-1723-45E3-94F5-6380EB2F0989")
{
ISpace["UI_Panel"].Visible="false";ISpace["UI_Panel"].Enbl="true";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""F7DA2CD7-1723-45E3-94F5-6380EB2F0989"")
{
ISpace[""UI_Panel""].Visible=""false"";ISpace[""UI_Panel""].Enbl=""true"";
}");
ISpace["MF_V1_ExpenseID"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_V1_ExpenseID""].Value=null;");
ISpace["MF_V1_BudgetHead"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_V1_BudgetHead""].Value=null;");
ISpace["MF_V1_ProjectDetailsID"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_V1_ProjectDetailsID""].Value=null;");
ISpace["MF_V1_PackageProcessMapID"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_V1_PackageProcessMapID""].Value=null;");
ISpace["MF_V1_ExpenseDate"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_V1_ExpenseDate""].Value=null;");
ISpace["MF_V1_AmountSpent"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_V1_AmountSpent""].Value=null;");
ISpace["MF_V1_ExpenseDescription"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_V1_ExpenseDescription""].Value=null;");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["FormVersionId"].Value=="F7DA2CD7-1723-45E3-94F5-6380EB2F0989")
{
ISpace["UI_Panel"].Visible="false";ISpace["UI_Panel"].Enbl="true";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""F7DA2CD7-1723-45E3-94F5-6380EB2F0989"")
{
ISpace[""UI_Panel""].Visible=""false"";ISpace[""UI_Panel""].Enbl=""true"";
}");
ISpace["MF_P1_ReceiptsId"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_P1_ReceiptsId""].Value=null;");
ISpace["MF_P1_ProjectDetailsId"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_P1_ProjectDetailsId""].Value=null;");
ISpace["MF_P1_ReceiptAmount"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_P1_ReceiptAmount""].Value=null;");
ISpace["MF_P1_ReceiptDate"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_P1_ReceiptDate""].Value=null;");
ISpace["MF_P1_TransferType"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_P1_TransferType""].Value=null;");
ISpace["MF_P1_TransferReferenceNumber"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_P1_TransferReferenceNumber""].Value=null;");
ISpace["MF_P1_TransferReferenceDate"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_P1_TransferReferenceDate""].Value=null;");
ISpace["MF_P1_TransferReferenceBankId"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_P1_TransferReferenceBankId""].Value=null;");
ISpace["MF_P1_TransferReferenceBranch"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_P1_TransferReferenceBranch""].Value=null;");
ISpace["MF_P1_ReceiptNo"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_P1_ReceiptNo""].Value=null;");
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_save (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Save-OnClick");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_V1_Balance"].Value==0)
{
base.WriteDebugInfo(@"if(ISpace[""MF_V1_Balance""].Value==0)");
ISpace["Message"].Value=@"Please Enter the Balance";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please Enter the Balance"";");
return;
base.WriteDebugInfo(@"return;");
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC dbo.[Dsp_812C39F9-F85B-42D5-BF27-D08554C67349_Save] '#MF_P1_ReceiptsId', '#MF_P1_ProjectDetailsId', '#MF_P1_ReceiptAmount', '#MF_P1_ReceiptDate', '#MF_P1_TransferType', '#MF_P1_TransferReferenceNumber', '#MF_P1_TransferReferenceDate', '#MF_P1_TransferReferenceBankId', '#MF_P1_TransferReferenceBranch', '#MF_P1_ReceiptNo'");

var querySourceE3916D313C3D4DC79C0A7458E6D8BC0C =GetQueryExpressionDataSource("E3916D31-3C3D-4DC7-9C0A-7458E6D8BC0C");
Dictionary<short,object> resultE3916D313C3D4DC79C0A7458E6D8BC0C=iSpace.ExecuteQuery(querySourceE3916D313C3D4DC79C0A7458E6D8BC0C,@"EXEC dbo.[Dsp_812C39F9-F85B-42D5-BF27-D08554C67349_Save] '" + ISpace["MF_P1_ReceiptsId"].Value + @"', '" + ISpace["MF_P1_ProjectDetailsId"].Value + @"', '" + ISpace["MF_P1_ReceiptAmount"].Value + @"', '" + ISpace["MF_P1_ReceiptDate"].Value + @"', '" + ISpace["MF_P1_TransferType"].Value + @"', '" + ISpace["MF_P1_TransferReferenceNumber"].Value + @"', '" + ISpace["MF_P1_TransferReferenceDate"].Value + @"', '" + ISpace["MF_P1_TransferReferenceBankId"].Value + @"', '" + ISpace["MF_P1_TransferReferenceBranch"].Value + @"', '" + ISpace["MF_P1_ReceiptNo"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceE3916D313C3D4DC79C0A7458E6D8BC0C =GetQueryExpressionDataSource(""E3916D31-3C3D-4DC7-9C0A-7458E6D8BC0C"");Dictionary<short,object> resultE3916D313C3D4DC79C0A7458E6D8BC0C=iSpace.ExecuteQuery(querySourceE3916D313C3D4DC79C0A7458E6D8BC0C,@""EXEC dbo.[Dsp_812C39F9-F85B-42D5-BF27-D08554C67349_Save] '"" + ISpace[""MF_P1_ReceiptsId""].Value + @""', '"" + ISpace[""MF_P1_ProjectDetailsId""].Value + @""', '"" + ISpace[""MF_P1_ReceiptAmount""].Value + @""', '"" + ISpace[""MF_P1_ReceiptDate""].Value + @""', '"" + ISpace[""MF_P1_TransferType""].Value + @""', '"" + ISpace[""MF_P1_TransferReferenceNumber""].Value + @""', '"" + ISpace[""MF_P1_TransferReferenceDate""].Value + @""', '"" + ISpace[""MF_P1_TransferReferenceBankId""].Value + @""', '"" + ISpace[""MF_P1_TransferReferenceBranch""].Value + @""', '"" + ISpace[""MF_P1_ReceiptNo""].Value + @""'"",false);");
base.WriteDebugInfo(@"EXEC dbo.[Dsp_812C39F9-F85B-42D5-BF27-D08554C67349_Save] '#MF_P1_ReceiptsId', '#MF_P1_ProjectDetailsId', '#MF_P1_ReceiptAmount', '#MF_P1_ReceiptDate', '#MF_P1_TransferType', '#MF_P1_TransferReferenceNumber', '#MF_P1_TransferReferenceDate', '#MF_P1_TransferReferenceBankId', '#MF_P1_TransferReferenceBranch', '#MF_P1_ReceiptNo'");

if((resultE3916D313C3D4DC79C0A7458E6D8BC0C!=null) && (resultE3916D313C3D4DC79C0A7458E6D8BC0C.Count!=0))
{
if(resultE3916D313C3D4DC79C0A7458E6D8BC0C.ContainsKey(0))
ISpace["Subject"].Value = resultE3916D313C3D4DC79C0A7458E6D8BC0C[0];
}
else{
ISpace["Subject"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC dbo.[Dsp_44CFF822-A4D3-4972-8997-2724F28FE04E_Save] '#MF_V1_ExpenseID', '#MF_V1_BudgetHead', '#MF_V1_ProjectDetailsID', '#MF_V1_PackageProcessMapID', '#MF_V1_ExpenseDate', '#MF_V1_AmountSpent', '#MF_V1_ExpenseDescription'");

var querySource79D912FAA37947AA85C0BFA4CB4D1E46 =GetQueryExpressionDataSource("79D912FA-A379-47AA-85C0-BFA4CB4D1E46");
Dictionary<short,object> result79D912FAA37947AA85C0BFA4CB4D1E46=iSpace.ExecuteQuery(querySource79D912FAA37947AA85C0BFA4CB4D1E46,@"EXEC dbo.[Dsp_44CFF822-A4D3-4972-8997-2724F28FE04E_Save] '" + ISpace["MF_V1_ExpenseID"].Value + @"', '" + ISpace["MF_V1_BudgetHead"].Value + @"', '" + ISpace["MF_V1_ProjectDetailsID"].Value + @"', '" + ISpace["MF_V1_PackageProcessMapID"].Value + @"', '" + ISpace["MF_V1_ExpenseDate"].Value + @"', '" + ISpace["MF_V1_AmountSpent"].Value + @"', '" + ISpace["MF_V1_ExpenseDescription"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource79D912FAA37947AA85C0BFA4CB4D1E46 =GetQueryExpressionDataSource(""79D912FA-A379-47AA-85C0-BFA4CB4D1E46"");Dictionary<short,object> result79D912FAA37947AA85C0BFA4CB4D1E46=iSpace.ExecuteQuery(querySource79D912FAA37947AA85C0BFA4CB4D1E46,@""EXEC dbo.[Dsp_44CFF822-A4D3-4972-8997-2724F28FE04E_Save] '"" + ISpace[""MF_V1_ExpenseID""].Value + @""', '"" + ISpace[""MF_V1_BudgetHead""].Value + @""', '"" + ISpace[""MF_V1_ProjectDetailsID""].Value + @""', '"" + ISpace[""MF_V1_PackageProcessMapID""].Value + @""', '"" + ISpace[""MF_V1_ExpenseDate""].Value + @""', '"" + ISpace[""MF_V1_AmountSpent""].Value + @""', '"" + ISpace[""MF_V1_ExpenseDescription""].Value + @""'"",false);");
base.WriteDebugInfo(@"EXEC dbo.[Dsp_44CFF822-A4D3-4972-8997-2724F28FE04E_Save] '#MF_V1_ExpenseID', '#MF_V1_BudgetHead', '#MF_V1_ProjectDetailsID', '#MF_V1_PackageProcessMapID', '#MF_V1_ExpenseDate', '#MF_V1_AmountSpent', '#MF_V1_ExpenseDescription'");

if((result79D912FAA37947AA85C0BFA4CB4D1E46!=null) && (result79D912FAA37947AA85C0BFA4CB4D1E46.Count!=0))
{
if(result79D912FAA37947AA85C0BFA4CB4D1E46.ContainsKey(0))
ISpace["Subject"].Value = result79D912FAA37947AA85C0BFA4CB4D1E46[0];
}
else{
ISpace["Subject"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC dbo.[Dsp_36DF80B9-922D-4320-8CCE-6E4485341172_Save] '#MF_V1_BudgetHeadID', '#MF_V1_ProjectDetailsID', '#MF_V1_BudgetHead', '#MF_V1_SanctionedAmount', '#MF_V1_ReceivedAmount', '#MF_V1_YettoReceive', '#MF_V1_Spent', '#MF_V1_Committment', '#MF_V1_Balance'");

var querySource694B5E2022B74684B76095809D295E97 =GetQueryExpressionDataSource("694B5E20-22B7-4684-B760-95809D295E97");
Dictionary<short,object> result694B5E2022B74684B76095809D295E97=iSpace.ExecuteQuery(querySource694B5E2022B74684B76095809D295E97,@"EXEC dbo.[Dsp_36DF80B9-922D-4320-8CCE-6E4485341172_Save] '" + ISpace["MF_V1_BudgetHeadID"].Value + @"', '" + ISpace["MF_V1_ProjectDetailsID"].Value + @"', '" + ISpace["MF_V1_BudgetHead"].Value + @"', '" + ISpace["MF_V1_SanctionedAmount"].Value + @"', '" + ISpace["MF_V1_ReceivedAmount"].Value + @"', '" + ISpace["MF_V1_YettoReceive"].Value + @"', '" + ISpace["MF_V1_Spent"].Value + @"', '" + ISpace["MF_V1_Committment"].Value + @"', '" + ISpace["MF_V1_Balance"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource694B5E2022B74684B76095809D295E97 =GetQueryExpressionDataSource(""694B5E20-22B7-4684-B760-95809D295E97"");Dictionary<short,object> result694B5E2022B74684B76095809D295E97=iSpace.ExecuteQuery(querySource694B5E2022B74684B76095809D295E97,@""EXEC dbo.[Dsp_36DF80B9-922D-4320-8CCE-6E4485341172_Save] '"" + ISpace[""MF_V1_BudgetHeadID""].Value + @""', '"" + ISpace[""MF_V1_ProjectDetailsID""].Value + @""', '"" + ISpace[""MF_V1_BudgetHead""].Value + @""', '"" + ISpace[""MF_V1_SanctionedAmount""].Value + @""', '"" + ISpace[""MF_V1_ReceivedAmount""].Value + @""', '"" + ISpace[""MF_V1_YettoReceive""].Value + @""', '"" + ISpace[""MF_V1_Spent""].Value + @""', '"" + ISpace[""MF_V1_Committment""].Value + @""', '"" + ISpace[""MF_V1_Balance""].Value + @""'"",false);");
base.WriteDebugInfo(@"EXEC dbo.[Dsp_36DF80B9-922D-4320-8CCE-6E4485341172_Save] '#MF_V1_BudgetHeadID', '#MF_V1_ProjectDetailsID', '#MF_V1_BudgetHead', '#MF_V1_SanctionedAmount', '#MF_V1_ReceivedAmount', '#MF_V1_YettoReceive', '#MF_V1_Spent', '#MF_V1_Committment', '#MF_V1_Balance'");

if((result694B5E2022B74684B76095809D295E97!=null) && (result694B5E2022B74684B76095809D295E97.Count!=0))
{
if(result694B5E2022B74684B76095809D295E97.ContainsKey(0))
ISpace["Subject"].Value = result694B5E2022B74684B76095809D295E97[0];
}
else{
ISpace["Subject"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["FormVersionId"].Value=="F7DA2CD7-1723-45E3-94F5-6380EB2F0989")
{
ISpace["UI_Panel"].Visible="true";ISpace["UI_Panel"].Enbl="true";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""F7DA2CD7-1723-45E3-94F5-6380EB2F0989"")
{
ISpace[""UI_Panel""].Visible=""true"";ISpace[""UI_Panel""].Enbl=""true"";
}");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["FormVersionId"].Value=="F7DA2CD7-1723-45E3-94F5-6380EB2F0989")
{
ISpace["UI_Panel"].Visible="true";ISpace["UI_Panel"].Enbl="true";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""F7DA2CD7-1723-45E3-94F5-6380EB2F0989"")
{
ISpace[""UI_Panel""].Visible=""true"";ISpace[""UI_Panel""].Enbl=""true"";
}");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["FormVersionId"].Value=="F7DA2CD7-1723-45E3-94F5-6380EB2F0989")
{
ISpace["UI_Panel"].Visible="true";ISpace["UI_Panel"].Enbl="true";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""F7DA2CD7-1723-45E3-94F5-6380EB2F0989"")
{
ISpace[""UI_Panel""].Visible=""true"";ISpace[""UI_Panel""].Enbl=""true"";
}");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 0,'#F_BudgetHeadId','',#MF_Budgetdetails_PageIndex,'#MF_Budgetdetails_GridRows','#F_ProjectDetailsId'");

var querySource05309A85D55C43B8A687C2A189F723E7 =GetQueryExpressionDataSource("05309A85-D55C-43B8-A687-C2A189F723E7");
Dictionary<short,object> result05309A85D55C43B8A687C2A189F723E7=iSpace.ExecuteQuery(querySource05309A85D55C43B8A687C2A189F723E7,@"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 0,'" + ISpace["F_BudgetHeadId"].Value + @"',''," + ISpace["MF_Budgetdetails_PageIndex"].Value + @",'" + ISpace["MF_Budgetdetails_GridRows"].Value + @"','" + ISpace["F_ProjectDetailsId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource05309A85D55C43B8A687C2A189F723E7 =GetQueryExpressionDataSource(""05309A85-D55C-43B8-A687-C2A189F723E7"");Dictionary<short,object> result05309A85D55C43B8A687C2A189F723E7=iSpace.ExecuteQuery(querySource05309A85D55C43B8A687C2A189F723E7,@""EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 0,'"" + ISpace[""F_BudgetHeadId""].Value + @""','',"" + ISpace[""MF_Budgetdetails_PageIndex""].Value + @"",'"" + ISpace[""MF_Budgetdetails_GridRows""].Value + @""','"" + ISpace[""F_ProjectDetailsId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result05309A85D55C43B8A687C2A189F723E7!=null) && (result05309A85D55C43B8A687C2A189F723E7.Count!=0))
{
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(0))
ISpace["MF_ProjectCommitments_GridRows"].Value = result05309A85D55C43B8A687C2A189F723E7[0];
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(3))
ISpace["MF_ProjectCommitments_TotalPages"].Value = result05309A85D55C43B8A687C2A189F723E7[3];
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(2))
ISpace["MF_ProjectCommitments_PageIndex"].Value = result05309A85D55C43B8A687C2A189F723E7[2];
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(1))
ISpace["MF_ProjectCommitments_RecordsRange"].Value = result05309A85D55C43B8A687C2A189F723E7[1];
}
else{
ISpace["MF_ProjectCommitments_GridRows"].Value = null;ISpace["MF_ProjectCommitments_TotalPages"].Value = null;ISpace["MF_ProjectCommitments_PageIndex"].Value = null;ISpace["MF_ProjectCommitments_RecordsRange"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 0,'#F_BudgetHeadId','',#MF_Budgetdetails_PageIndex,'#MF_Budgetdetails_GridRows','#F_ProjectDetailsId'");

var querySource05309A85D55C43B8A687C2A189F723E7 =GetQueryExpressionDataSource("05309A85-D55C-43B8-A687-C2A189F723E7");
Dictionary<short,object> result05309A85D55C43B8A687C2A189F723E7=iSpace.ExecuteQuery(querySource05309A85D55C43B8A687C2A189F723E7,@"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 0,'" + ISpace["F_BudgetHeadId"].Value + @"',''," + ISpace["MF_Budgetdetails_PageIndex"].Value + @",'" + ISpace["MF_Budgetdetails_GridRows"].Value + @"','" + ISpace["F_ProjectDetailsId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource05309A85D55C43B8A687C2A189F723E7 =GetQueryExpressionDataSource(""05309A85-D55C-43B8-A687-C2A189F723E7"");Dictionary<short,object> result05309A85D55C43B8A687C2A189F723E7=iSpace.ExecuteQuery(querySource05309A85D55C43B8A687C2A189F723E7,@""EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 0,'"" + ISpace[""F_BudgetHeadId""].Value + @""','',"" + ISpace[""MF_Budgetdetails_PageIndex""].Value + @"",'"" + ISpace[""MF_Budgetdetails_GridRows""].Value + @""','"" + ISpace[""F_ProjectDetailsId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result05309A85D55C43B8A687C2A189F723E7!=null) && (result05309A85D55C43B8A687C2A189F723E7.Count!=0))
{
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(0))
ISpace["MF_ProjectCommitments_GridRows"].Value = result05309A85D55C43B8A687C2A189F723E7[0];
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(3))
ISpace["MF_ProjectCommitments_TotalPages"].Value = result05309A85D55C43B8A687C2A189F723E7[3];
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(2))
ISpace["MF_ProjectCommitments_PageIndex"].Value = result05309A85D55C43B8A687C2A189F723E7[2];
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(1))
ISpace["MF_ProjectCommitments_RecordsRange"].Value = result05309A85D55C43B8A687C2A189F723E7[1];
}
else{
ISpace["MF_ProjectCommitments_GridRows"].Value = null;ISpace["MF_ProjectCommitments_TotalPages"].Value = null;ISpace["MF_ProjectCommitments_PageIndex"].Value = null;ISpace["MF_ProjectCommitments_RecordsRange"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 0,'#F_BudgetHeadId','',#MF_Budgetdetails_PageIndex,'#MF_Budgetdetails_GridRows','#F_ProjectDetailsId'");

var querySource05309A85D55C43B8A687C2A189F723E7 =GetQueryExpressionDataSource("05309A85-D55C-43B8-A687-C2A189F723E7");
Dictionary<short,object> result05309A85D55C43B8A687C2A189F723E7=iSpace.ExecuteQuery(querySource05309A85D55C43B8A687C2A189F723E7,@"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 0,'" + ISpace["F_BudgetHeadId"].Value + @"',''," + ISpace["MF_Budgetdetails_PageIndex"].Value + @",'" + ISpace["MF_Budgetdetails_GridRows"].Value + @"','" + ISpace["F_ProjectDetailsId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource05309A85D55C43B8A687C2A189F723E7 =GetQueryExpressionDataSource(""05309A85-D55C-43B8-A687-C2A189F723E7"");Dictionary<short,object> result05309A85D55C43B8A687C2A189F723E7=iSpace.ExecuteQuery(querySource05309A85D55C43B8A687C2A189F723E7,@""EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 0,'"" + ISpace[""F_BudgetHeadId""].Value + @""','',"" + ISpace[""MF_Budgetdetails_PageIndex""].Value + @"",'"" + ISpace[""MF_Budgetdetails_GridRows""].Value + @""','"" + ISpace[""F_ProjectDetailsId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result05309A85D55C43B8A687C2A189F723E7!=null) && (result05309A85D55C43B8A687C2A189F723E7.Count!=0))
{
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(0))
ISpace["MF_ProjectCommitments_GridRows"].Value = result05309A85D55C43B8A687C2A189F723E7[0];
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(3))
ISpace["MF_ProjectCommitments_TotalPages"].Value = result05309A85D55C43B8A687C2A189F723E7[3];
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(2))
ISpace["MF_ProjectCommitments_PageIndex"].Value = result05309A85D55C43B8A687C2A189F723E7[2];
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(1))
ISpace["MF_ProjectCommitments_RecordsRange"].Value = result05309A85D55C43B8A687C2A189F723E7[1];
}
else{
ISpace["MF_ProjectCommitments_GridRows"].Value = null;ISpace["MF_ProjectCommitments_TotalPages"].Value = null;ISpace["MF_ProjectCommitments_PageIndex"].Value = null;ISpace["MF_ProjectCommitments_RecordsRange"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_Budgetdetails_PageIndex"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""MF_Budgetdetails_PageIndex""].Value==1)");
if(ISpace["MF_Budgetdetails_PageIndex"].Value==ISpace["MF_Budgetdetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_Budgetdetails_PageIndex""].Value==ISpace[""MF_Budgetdetails_TotalPages""].Value)");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="false";ISpace["MF_ProjectCommitments_LastButton"].Enbl="false";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="false";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="false";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""false"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="true";ISpace["MF_ProjectCommitments_LastButton"].Enbl="true";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="false";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="false";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""true"";");
}
}
else
{
base.WriteDebugInfo(@"else");
if(ISpace["MF_Budgetdetails_PageIndex"].Value==ISpace["MF_Budgetdetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_Budgetdetails_PageIndex""].Value==ISpace[""MF_Budgetdetails_TotalPages""].Value)");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="false";ISpace["MF_ProjectCommitments_LastButton"].Enbl="false";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="true";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="true";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="true";ISpace["MF_ProjectCommitments_LastButton"].Enbl="true";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="true";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="true";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""true"";");
}
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_Budgetdetails_PageIndex"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""MF_Budgetdetails_PageIndex""].Value==1)");
if(ISpace["MF_Budgetdetails_PageIndex"].Value==ISpace["MF_Budgetdetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_Budgetdetails_PageIndex""].Value==ISpace[""MF_Budgetdetails_TotalPages""].Value)");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="false";ISpace["MF_ProjectCommitments_LastButton"].Enbl="false";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="false";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="false";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""false"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="true";ISpace["MF_ProjectCommitments_LastButton"].Enbl="true";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="false";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="false";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""true"";");
}
}
else
{
base.WriteDebugInfo(@"else");
if(ISpace["MF_Budgetdetails_PageIndex"].Value==ISpace["MF_Budgetdetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_Budgetdetails_PageIndex""].Value==ISpace[""MF_Budgetdetails_TotalPages""].Value)");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="false";ISpace["MF_ProjectCommitments_LastButton"].Enbl="false";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="true";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="true";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="true";ISpace["MF_ProjectCommitments_LastButton"].Enbl="true";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="true";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="true";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""true"";");
}
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_Budgetdetails_PageIndex"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""MF_Budgetdetails_PageIndex""].Value==1)");
if(ISpace["MF_Budgetdetails_PageIndex"].Value==ISpace["MF_Budgetdetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_Budgetdetails_PageIndex""].Value==ISpace[""MF_Budgetdetails_TotalPages""].Value)");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="false";ISpace["MF_ProjectCommitments_LastButton"].Enbl="false";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="false";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="false";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""false"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="true";ISpace["MF_ProjectCommitments_LastButton"].Enbl="true";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="false";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="false";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""true"";");
}
}
else
{
base.WriteDebugInfo(@"else");
if(ISpace["MF_Budgetdetails_PageIndex"].Value==ISpace["MF_Budgetdetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_Budgetdetails_PageIndex""].Value==ISpace[""MF_Budgetdetails_TotalPages""].Value)");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="false";ISpace["MF_ProjectCommitments_LastButton"].Enbl="false";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="true";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="true";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="true";ISpace["MF_ProjectCommitments_LastButton"].Enbl="true";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="true";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="true";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""true"";");
}
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySource01000C9CF4F74DAA8E0E4E2ACF3299FF =GetQueryExpressionDataSource("01000C9C-F4F7-4DAA-8E0E-4E2ACF3299FF");

DataTable result01000C9CF4F74DAA8E0E4E2ACF3299FF=iSpace.SetGridDataSource(querySource01000C9CF4F74DAA8E0E4E2ACF3299FF, _objectFactory.GetGridRPP("ProjectCommitments"),@"EXEC dbo.[Get_e046fb44-e1f1-4f2a-a07e-231e72f92166_FilterData] 1,'" + ISpace["F_ProjectDetailsId"].Value + @"',''," + ISpace["MF_ProjectCommitments_PageIndex"].Value + @",'" + ISpace["MF_ProjectCommitments_GridRows"].Value + @"'");

iSpace.InsertGridBindDetails("ProjectCommitments","11",querySource01000C9CF4F74DAA8E0E4E2ACF3299FF,"EXEC dbo.[Get_e046fb44-e1f1-4f2a-a07e-231e72f92166_FilterData] 1,'" + ISpace["F_ProjectDetailsId"].Value + @"',''," + ISpace["MF_ProjectCommitments_PageIndex"].Value + @",'" + ISpace["MF_ProjectCommitments_GridRows"].Value + @"'",_objectFactory.GetGridRPP("ProjectCommitments"));

base.WriteDebugInfo(@"var querySource01000C9CF4F74DAA8E0E4E2ACF3299FF =GetQueryExpressionDataSource(""01000C9C-F4F7-4DAA-8E0E-4E2ACF3299FF"");DataTable result01000C9CF4F74DAA8E0E4E2ACF3299FF=iSpace.SetGridDataSource(querySource01000C9CF4F74DAA8E0E4E2ACF3299FF, _objectFactory.GetGridRPP(""ProjectCommitments""),@""EXEC dbo.[Get_e046fb44-e1f1-4f2a-a07e-231e72f92166_FilterData] 1,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',"" + ISpace[""MF_ProjectCommitments_PageIndex""].Value + @"",'"" + ISpace[""MF_ProjectCommitments_GridRows""].Value + @""'"");iSpace.InsertGridBindDetails(""ProjectCommitments"",""11"",querySource01000C9CF4F74DAA8E0E4E2ACF3299FF,""EXEC dbo.[Get_e046fb44-e1f1-4f2a-a07e-231e72f92166_FilterData] 1,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',"" + ISpace[""MF_ProjectCommitments_PageIndex""].Value + @"",'"" + ISpace[""MF_ProjectCommitments_GridRows""].Value + @""'"",_objectFactory.GetGridRPP(""ProjectCommitments""));");
base.WriteDebugInfo(@"EXEC dbo.[Get_e046fb44-e1f1-4f2a-a07e-231e72f92166_FilterData] 1,'#F_ProjectDetailsId','',#MF_ProjectCommitments_PageIndex,'#MF_ProjectCommitments_GridRows'");


List<Triplet<string, short, short?>> result34DD54DC0E5B46EAA0BBD99E022B7345=acdataIspace585BA2B83E754DABB50B10D8320CE414.GetQueryExpressionBindings("34DD54DC-0E5B-46EA-A0BB-D99E022B7345");
iSpace.SetGridData(result01000C9CF4F74DAA8E0E4E2ACF3299FF,result34DD54DC0E5B46EAA0BBD99E022B7345,"ProjectCommitments",ref ISpace);
iSpace.UpdateGridBindDetails("ProjectCommitments",result34DD54DC0E5B46EAA0BBD99E022B7345);
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySource24686D701FFF4F4F81D7EE238FD68AC3 =GetQueryExpressionDataSource("24686D70-1FFF-4F4F-81D7-EE238FD68AC3");

DataTable result24686D701FFF4F4F81D7EE238FD68AC3=iSpace.SetGridDataSource(querySource24686D701FFF4F4F81D7EE238FD68AC3, _objectFactory.GetGridRPP("ReceiptsView"),@"EXEC dbo.[Get_bd3abae8-b5a2-4b71-b3e2-e46732479592_FilterData] 1,'" + ISpace["F_ReceiptNo"].Value + @"',''," + ISpace["MF_ReceiptsView_PageIndex"].Value + @",'" + ISpace["MF_ReceiptsView_GridRows"].Value + @"','" + ISpace["F_ProjectDetailsID"].Value + @"'");

iSpace.InsertGridBindDetails("ReceiptsView","11",querySource24686D701FFF4F4F81D7EE238FD68AC3,"EXEC dbo.[Get_bd3abae8-b5a2-4b71-b3e2-e46732479592_FilterData] 1,'" + ISpace["F_ReceiptNo"].Value + @"',''," + ISpace["MF_ReceiptsView_PageIndex"].Value + @",'" + ISpace["MF_ReceiptsView_GridRows"].Value + @"','" + ISpace["F_ProjectDetailsID"].Value + @"'",_objectFactory.GetGridRPP("ReceiptsView"));

base.WriteDebugInfo(@"var querySource24686D701FFF4F4F81D7EE238FD68AC3 =GetQueryExpressionDataSource(""24686D70-1FFF-4F4F-81D7-EE238FD68AC3"");DataTable result24686D701FFF4F4F81D7EE238FD68AC3=iSpace.SetGridDataSource(querySource24686D701FFF4F4F81D7EE238FD68AC3, _objectFactory.GetGridRPP(""ReceiptsView""),@""EXEC dbo.[Get_bd3abae8-b5a2-4b71-b3e2-e46732479592_FilterData] 1,'"" + ISpace[""F_ReceiptNo""].Value + @""','',"" + ISpace[""MF_ReceiptsView_PageIndex""].Value + @"",'"" + ISpace[""MF_ReceiptsView_GridRows""].Value + @""','"" + ISpace[""F_ProjectDetailsID""].Value + @""'"");iSpace.InsertGridBindDetails(""ReceiptsView"",""11"",querySource24686D701FFF4F4F81D7EE238FD68AC3,""EXEC dbo.[Get_bd3abae8-b5a2-4b71-b3e2-e46732479592_FilterData] 1,'"" + ISpace[""F_ReceiptNo""].Value + @""','',"" + ISpace[""MF_ReceiptsView_PageIndex""].Value + @"",'"" + ISpace[""MF_ReceiptsView_GridRows""].Value + @""','"" + ISpace[""F_ProjectDetailsID""].Value + @""'"",_objectFactory.GetGridRPP(""ReceiptsView""));");
base.WriteDebugInfo(@"EXEC dbo.[Get_bd3abae8-b5a2-4b71-b3e2-e46732479592_FilterData] 1,'#F_ReceiptNo','',#MF_ReceiptsView_PageIndex,'#MF_ReceiptsView_GridRows'");


List<Triplet<string, short, short?>> result3E6384212EC24473A32F5167327104C5=acdataIspace585BA2B83E754DABB50B10D8320CE414.GetQueryExpressionBindings("3E638421-2EC2-4473-A32F-5167327104C5");
iSpace.SetGridData(result24686D701FFF4F4F81D7EE238FD68AC3,result3E6384212EC24473A32F5167327104C5,"ReceiptsView",ref ISpace);
iSpace.UpdateGridBindDetails("ReceiptsView",result3E6384212EC24473A32F5167327104C5);
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySourceD840F8CC40764F70BB276BC03624E86F =GetQueryExpressionDataSource("D840F8CC-4076-4F70-BB27-6BC03624E86F");

DataTable resultD840F8CC40764F70BB276BC03624E86F=iSpace.SetGridDataSource(querySourceD840F8CC40764F70BB276BC03624E86F, _objectFactory.GetGridRPP("Budgetdetails"),@"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 1,'" + ISpace["F_BudgetHeadId"].Value + @"',''," + ISpace["MF_Budgetdetails_PageIndex"].Value + @",'" + ISpace["MF_Budgetdetails_GridRows"].Value + @"','" + ISpace["F_ProjectDetailsId"].Value + @"'");

iSpace.InsertGridBindDetails("Budgetdetails","11",querySourceD840F8CC40764F70BB276BC03624E86F,"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 1,'" + ISpace["F_BudgetHeadId"].Value + @"',''," + ISpace["MF_Budgetdetails_PageIndex"].Value + @",'" + ISpace["MF_Budgetdetails_GridRows"].Value + @"','" + ISpace["F_ProjectDetailsId"].Value + @"'",_objectFactory.GetGridRPP("Budgetdetails"));

base.WriteDebugInfo(@"var querySourceD840F8CC40764F70BB276BC03624E86F =GetQueryExpressionDataSource(""D840F8CC-4076-4F70-BB27-6BC03624E86F"");DataTable resultD840F8CC40764F70BB276BC03624E86F=iSpace.SetGridDataSource(querySourceD840F8CC40764F70BB276BC03624E86F, _objectFactory.GetGridRPP(""Budgetdetails""),@""EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 1,'"" + ISpace[""F_BudgetHeadId""].Value + @""','',"" + ISpace[""MF_Budgetdetails_PageIndex""].Value + @"",'"" + ISpace[""MF_Budgetdetails_GridRows""].Value + @""','"" + ISpace[""F_ProjectDetailsId""].Value + @""'"");iSpace.InsertGridBindDetails(""Budgetdetails"",""11"",querySourceD840F8CC40764F70BB276BC03624E86F,""EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 1,'"" + ISpace[""F_BudgetHeadId""].Value + @""','',"" + ISpace[""MF_Budgetdetails_PageIndex""].Value + @"",'"" + ISpace[""MF_Budgetdetails_GridRows""].Value + @""','"" + ISpace[""F_ProjectDetailsId""].Value + @""'"",_objectFactory.GetGridRPP(""Budgetdetails""));");
base.WriteDebugInfo(@"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 1,'#F_BudgetHeadId','',#MF_Budgetdetails_PageIndex,'#MF_Budgetdetails_GridRows'");


List<Triplet<string, short, short?>> resultF197120EAAA7488594BFCD708A09CE9F=acdataIspace585BA2B83E754DABB50B10D8320CE414.GetQueryExpressionBindings("F197120E-AAA7-4885-94BF-CD708A09CE9F");
iSpace.SetGridData(resultD840F8CC40764F70BB276BC03624E86F,resultF197120EAAA7488594BFCD708A09CE9F,"Budgetdetails",ref ISpace);
iSpace.UpdateGridBindDetails("Budgetdetails",resultF197120EAAA7488594BFCD708A09CE9F);
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mf_budgetdetails_firstbutton (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MF_Budgetdetails_FirstButton-OnClick");
ISpace["MF_Budgetdetails_PageIndex"].Value=1;
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PageIndex""].Value=1;");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 0,'#F_BudgetHeadId','',#MF_Budgetdetails_PageIndex,'#MF_Budgetdetails_GridRows','#F_ProjectDetailsId'");

var querySource05309A85D55C43B8A687C2A189F723E7 =GetQueryExpressionDataSource("05309A85-D55C-43B8-A687-C2A189F723E7");
Dictionary<short,object> result05309A85D55C43B8A687C2A189F723E7=iSpace.ExecuteQuery(querySource05309A85D55C43B8A687C2A189F723E7,@"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 0,'" + ISpace["F_BudgetHeadId"].Value + @"',''," + ISpace["MF_Budgetdetails_PageIndex"].Value + @",'" + ISpace["MF_Budgetdetails_GridRows"].Value + @"','" + ISpace["F_ProjectDetailsId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource05309A85D55C43B8A687C2A189F723E7 =GetQueryExpressionDataSource(""05309A85-D55C-43B8-A687-C2A189F723E7"");Dictionary<short,object> result05309A85D55C43B8A687C2A189F723E7=iSpace.ExecuteQuery(querySource05309A85D55C43B8A687C2A189F723E7,@""EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 0,'"" + ISpace[""F_BudgetHeadId""].Value + @""','',"" + ISpace[""MF_Budgetdetails_PageIndex""].Value + @"",'"" + ISpace[""MF_Budgetdetails_GridRows""].Value + @""','"" + ISpace[""F_ProjectDetailsId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result05309A85D55C43B8A687C2A189F723E7!=null) && (result05309A85D55C43B8A687C2A189F723E7.Count!=0))
{
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(0))
ISpace["MF_ProjectCommitments_GridRows"].Value = result05309A85D55C43B8A687C2A189F723E7[0];
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(3))
ISpace["MF_ProjectCommitments_TotalPages"].Value = result05309A85D55C43B8A687C2A189F723E7[3];
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(2))
ISpace["MF_ProjectCommitments_PageIndex"].Value = result05309A85D55C43B8A687C2A189F723E7[2];
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(1))
ISpace["MF_ProjectCommitments_RecordsRange"].Value = result05309A85D55C43B8A687C2A189F723E7[1];
}
else{
ISpace["MF_ProjectCommitments_GridRows"].Value = null;ISpace["MF_ProjectCommitments_TotalPages"].Value = null;ISpace["MF_ProjectCommitments_PageIndex"].Value = null;ISpace["MF_ProjectCommitments_RecordsRange"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_Budgetdetails_PageIndex"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""MF_Budgetdetails_PageIndex""].Value==1)");
if(ISpace["MF_Budgetdetails_PageIndex"].Value==ISpace["MF_Budgetdetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_Budgetdetails_PageIndex""].Value==ISpace[""MF_Budgetdetails_TotalPages""].Value)");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="false";ISpace["MF_ProjectCommitments_LastButton"].Enbl="false";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="false";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="false";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""false"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="true";ISpace["MF_ProjectCommitments_LastButton"].Enbl="true";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="false";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="false";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""true"";");
}
}
else
{
base.WriteDebugInfo(@"else");
if(ISpace["MF_Budgetdetails_PageIndex"].Value==ISpace["MF_Budgetdetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_Budgetdetails_PageIndex""].Value==ISpace[""MF_Budgetdetails_TotalPages""].Value)");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="false";ISpace["MF_ProjectCommitments_LastButton"].Enbl="false";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="true";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="true";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="true";ISpace["MF_ProjectCommitments_LastButton"].Enbl="true";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="true";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="true";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""true"";");
}
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySourceD840F8CC40764F70BB276BC03624E86F =GetQueryExpressionDataSource("D840F8CC-4076-4F70-BB27-6BC03624E86F");

DataTable resultD840F8CC40764F70BB276BC03624E86F=iSpace.SetGridDataSource(querySourceD840F8CC40764F70BB276BC03624E86F, _objectFactory.GetGridRPP("Budgetdetails"),@"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 1,'" + ISpace["F_BudgetHeadId"].Value + @"',''," + ISpace["MF_Budgetdetails_PageIndex"].Value + @",'" + ISpace["MF_Budgetdetails_GridRows"].Value + @"','" + ISpace["F_ProjectDetailsId"].Value + @"'");

iSpace.InsertGridBindDetails("Budgetdetails","11",querySourceD840F8CC40764F70BB276BC03624E86F,"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 1,'" + ISpace["F_BudgetHeadId"].Value + @"',''," + ISpace["MF_Budgetdetails_PageIndex"].Value + @",'" + ISpace["MF_Budgetdetails_GridRows"].Value + @"','" + ISpace["F_ProjectDetailsId"].Value + @"'",_objectFactory.GetGridRPP("Budgetdetails"));

base.WriteDebugInfo(@"var querySourceD840F8CC40764F70BB276BC03624E86F =GetQueryExpressionDataSource(""D840F8CC-4076-4F70-BB27-6BC03624E86F"");DataTable resultD840F8CC40764F70BB276BC03624E86F=iSpace.SetGridDataSource(querySourceD840F8CC40764F70BB276BC03624E86F, _objectFactory.GetGridRPP(""Budgetdetails""),@""EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 1,'"" + ISpace[""F_BudgetHeadId""].Value + @""','',"" + ISpace[""MF_Budgetdetails_PageIndex""].Value + @"",'"" + ISpace[""MF_Budgetdetails_GridRows""].Value + @""','"" + ISpace[""F_ProjectDetailsId""].Value + @""'"");iSpace.InsertGridBindDetails(""Budgetdetails"",""11"",querySourceD840F8CC40764F70BB276BC03624E86F,""EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 1,'"" + ISpace[""F_BudgetHeadId""].Value + @""','',"" + ISpace[""MF_Budgetdetails_PageIndex""].Value + @"",'"" + ISpace[""MF_Budgetdetails_GridRows""].Value + @""','"" + ISpace[""F_ProjectDetailsId""].Value + @""'"",_objectFactory.GetGridRPP(""Budgetdetails""));");
base.WriteDebugInfo(@"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 1,'#F_BudgetHeadId','',#MF_Budgetdetails_PageIndex,'#MF_Budgetdetails_GridRows'");


List<Triplet<string, short, short?>> resultF197120EAAA7488594BFCD708A09CE9F=acdataIspace585BA2B83E754DABB50B10D8320CE414.GetQueryExpressionBindings("F197120E-AAA7-4885-94BF-CD708A09CE9F");
iSpace.SetGridData(resultD840F8CC40764F70BB276BC03624E86F,resultF197120EAAA7488594BFCD708A09CE9F,"Budgetdetails",ref ISpace);
iSpace.UpdateGridBindDetails("Budgetdetails",resultF197120EAAA7488594BFCD708A09CE9F);
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mf_receiptsview_prevbutton (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MF_ReceiptsView_PrevButton-OnClick");
if(ISpace["MF_Budgetdetails_PageIndex"].Value>2)
{
base.WriteDebugInfo(@"if(ISpace[""MF_Budgetdetails_PageIndex""].Value>2)");
ISpace["MF_Budgetdetails_PageIndex"].Value=ISpace["MF_Budgetdetails_PageIndex"].Value-1;
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PageIndex""].Value=ISpace[""MF_Budgetdetails_PageIndex""].Value-1;");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_Budgetdetails_PageIndex"].Value=1;
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PageIndex""].Value=1;");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 0,'#F_BudgetHeadId','',#MF_Budgetdetails_PageIndex,'#MF_Budgetdetails_GridRows','#F_ProjectDetailsId'");

var querySource05309A85D55C43B8A687C2A189F723E7 =GetQueryExpressionDataSource("05309A85-D55C-43B8-A687-C2A189F723E7");
Dictionary<short,object> result05309A85D55C43B8A687C2A189F723E7=iSpace.ExecuteQuery(querySource05309A85D55C43B8A687C2A189F723E7,@"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 0,'" + ISpace["F_BudgetHeadId"].Value + @"',''," + ISpace["MF_Budgetdetails_PageIndex"].Value + @",'" + ISpace["MF_Budgetdetails_GridRows"].Value + @"','" + ISpace["F_ProjectDetailsId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource05309A85D55C43B8A687C2A189F723E7 =GetQueryExpressionDataSource(""05309A85-D55C-43B8-A687-C2A189F723E7"");Dictionary<short,object> result05309A85D55C43B8A687C2A189F723E7=iSpace.ExecuteQuery(querySource05309A85D55C43B8A687C2A189F723E7,@""EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 0,'"" + ISpace[""F_BudgetHeadId""].Value + @""','',"" + ISpace[""MF_Budgetdetails_PageIndex""].Value + @"",'"" + ISpace[""MF_Budgetdetails_GridRows""].Value + @""','"" + ISpace[""F_ProjectDetailsId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result05309A85D55C43B8A687C2A189F723E7!=null) && (result05309A85D55C43B8A687C2A189F723E7.Count!=0))
{
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(0))
ISpace["MF_ProjectCommitments_GridRows"].Value = result05309A85D55C43B8A687C2A189F723E7[0];
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(3))
ISpace["MF_ProjectCommitments_TotalPages"].Value = result05309A85D55C43B8A687C2A189F723E7[3];
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(2))
ISpace["MF_ProjectCommitments_PageIndex"].Value = result05309A85D55C43B8A687C2A189F723E7[2];
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(1))
ISpace["MF_ProjectCommitments_RecordsRange"].Value = result05309A85D55C43B8A687C2A189F723E7[1];
}
else{
ISpace["MF_ProjectCommitments_GridRows"].Value = null;ISpace["MF_ProjectCommitments_TotalPages"].Value = null;ISpace["MF_ProjectCommitments_PageIndex"].Value = null;ISpace["MF_ProjectCommitments_RecordsRange"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_Budgetdetails_PageIndex"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""MF_Budgetdetails_PageIndex""].Value==1)");
if(ISpace["MF_Budgetdetails_PageIndex"].Value==ISpace["MF_Budgetdetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_Budgetdetails_PageIndex""].Value==ISpace[""MF_Budgetdetails_TotalPages""].Value)");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="false";ISpace["MF_ProjectCommitments_LastButton"].Enbl="false";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="false";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="false";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""false"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="true";ISpace["MF_ProjectCommitments_LastButton"].Enbl="true";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="false";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="false";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""true"";");
}
}
else
{
base.WriteDebugInfo(@"else");
if(ISpace["MF_Budgetdetails_PageIndex"].Value==ISpace["MF_Budgetdetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_Budgetdetails_PageIndex""].Value==ISpace[""MF_Budgetdetails_TotalPages""].Value)");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="false";ISpace["MF_ProjectCommitments_LastButton"].Enbl="false";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="true";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="true";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="true";ISpace["MF_ProjectCommitments_LastButton"].Enbl="true";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="true";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="true";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""true"";");
}
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySource24686D701FFF4F4F81D7EE238FD68AC3 =GetQueryExpressionDataSource("24686D70-1FFF-4F4F-81D7-EE238FD68AC3");

DataTable result24686D701FFF4F4F81D7EE238FD68AC3=iSpace.SetGridDataSource(querySource24686D701FFF4F4F81D7EE238FD68AC3, _objectFactory.GetGridRPP("ReceiptsView"),@"EXEC dbo.[Get_bd3abae8-b5a2-4b71-b3e2-e46732479592_FilterData] 1,'" + ISpace["F_ReceiptNo"].Value + @"',''," + ISpace["MF_ReceiptsView_PageIndex"].Value + @",'" + ISpace["MF_ReceiptsView_GridRows"].Value + @"','" + ISpace["F_ProjectDetailsID"].Value + @"'");

iSpace.InsertGridBindDetails("ReceiptsView","11",querySource24686D701FFF4F4F81D7EE238FD68AC3,"EXEC dbo.[Get_bd3abae8-b5a2-4b71-b3e2-e46732479592_FilterData] 1,'" + ISpace["F_ReceiptNo"].Value + @"',''," + ISpace["MF_ReceiptsView_PageIndex"].Value + @",'" + ISpace["MF_ReceiptsView_GridRows"].Value + @"','" + ISpace["F_ProjectDetailsID"].Value + @"'",_objectFactory.GetGridRPP("ReceiptsView"));

base.WriteDebugInfo(@"var querySource24686D701FFF4F4F81D7EE238FD68AC3 =GetQueryExpressionDataSource(""24686D70-1FFF-4F4F-81D7-EE238FD68AC3"");DataTable result24686D701FFF4F4F81D7EE238FD68AC3=iSpace.SetGridDataSource(querySource24686D701FFF4F4F81D7EE238FD68AC3, _objectFactory.GetGridRPP(""ReceiptsView""),@""EXEC dbo.[Get_bd3abae8-b5a2-4b71-b3e2-e46732479592_FilterData] 1,'"" + ISpace[""F_ReceiptNo""].Value + @""','',"" + ISpace[""MF_ReceiptsView_PageIndex""].Value + @"",'"" + ISpace[""MF_ReceiptsView_GridRows""].Value + @""','"" + ISpace[""F_ProjectDetailsID""].Value + @""'"");iSpace.InsertGridBindDetails(""ReceiptsView"",""11"",querySource24686D701FFF4F4F81D7EE238FD68AC3,""EXEC dbo.[Get_bd3abae8-b5a2-4b71-b3e2-e46732479592_FilterData] 1,'"" + ISpace[""F_ReceiptNo""].Value + @""','',"" + ISpace[""MF_ReceiptsView_PageIndex""].Value + @"",'"" + ISpace[""MF_ReceiptsView_GridRows""].Value + @""','"" + ISpace[""F_ProjectDetailsID""].Value + @""'"",_objectFactory.GetGridRPP(""ReceiptsView""));");
base.WriteDebugInfo(@"EXEC dbo.[Get_bd3abae8-b5a2-4b71-b3e2-e46732479592_FilterData] 1,'#F_ReceiptNo','',#MF_ReceiptsView_PageIndex,'#MF_ReceiptsView_GridRows'");


List<Triplet<string, short, short?>> result3E6384212EC24473A32F5167327104C5=acdataIspace585BA2B83E754DABB50B10D8320CE414.GetQueryExpressionBindings("3E638421-2EC2-4473-A32F-5167327104C5");
iSpace.SetGridData(result24686D701FFF4F4F81D7EE238FD68AC3,result3E6384212EC24473A32F5167327104C5,"ReceiptsView",ref ISpace);
iSpace.UpdateGridBindDetails("ReceiptsView",result3E6384212EC24473A32F5167327104C5);
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mf_budgetdetails_lastbutton (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MF_Budgetdetails_LastButton-OnClick");
ISpace["MF_Budgetdetails_PageIndex"].Value=0;
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PageIndex""].Value=0;");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 0,'#F_BudgetHeadId','',#MF_Budgetdetails_PageIndex,'#MF_Budgetdetails_GridRows','#F_ProjectDetailsId'");

var querySource05309A85D55C43B8A687C2A189F723E7 =GetQueryExpressionDataSource("05309A85-D55C-43B8-A687-C2A189F723E7");
Dictionary<short,object> result05309A85D55C43B8A687C2A189F723E7=iSpace.ExecuteQuery(querySource05309A85D55C43B8A687C2A189F723E7,@"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 0,'" + ISpace["F_BudgetHeadId"].Value + @"',''," + ISpace["MF_Budgetdetails_PageIndex"].Value + @",'" + ISpace["MF_Budgetdetails_GridRows"].Value + @"','" + ISpace["F_ProjectDetailsId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource05309A85D55C43B8A687C2A189F723E7 =GetQueryExpressionDataSource(""05309A85-D55C-43B8-A687-C2A189F723E7"");Dictionary<short,object> result05309A85D55C43B8A687C2A189F723E7=iSpace.ExecuteQuery(querySource05309A85D55C43B8A687C2A189F723E7,@""EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 0,'"" + ISpace[""F_BudgetHeadId""].Value + @""','',"" + ISpace[""MF_Budgetdetails_PageIndex""].Value + @"",'"" + ISpace[""MF_Budgetdetails_GridRows""].Value + @""','"" + ISpace[""F_ProjectDetailsId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result05309A85D55C43B8A687C2A189F723E7!=null) && (result05309A85D55C43B8A687C2A189F723E7.Count!=0))
{
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(0))
ISpace["MF_ProjectCommitments_GridRows"].Value = result05309A85D55C43B8A687C2A189F723E7[0];
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(3))
ISpace["MF_ProjectCommitments_TotalPages"].Value = result05309A85D55C43B8A687C2A189F723E7[3];
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(2))
ISpace["MF_ProjectCommitments_PageIndex"].Value = result05309A85D55C43B8A687C2A189F723E7[2];
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(1))
ISpace["MF_ProjectCommitments_RecordsRange"].Value = result05309A85D55C43B8A687C2A189F723E7[1];
}
else{
ISpace["MF_ProjectCommitments_GridRows"].Value = null;ISpace["MF_ProjectCommitments_TotalPages"].Value = null;ISpace["MF_ProjectCommitments_PageIndex"].Value = null;ISpace["MF_ProjectCommitments_RecordsRange"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_Budgetdetails_PageIndex"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""MF_Budgetdetails_PageIndex""].Value==1)");
if(ISpace["MF_Budgetdetails_PageIndex"].Value==ISpace["MF_Budgetdetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_Budgetdetails_PageIndex""].Value==ISpace[""MF_Budgetdetails_TotalPages""].Value)");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="false";ISpace["MF_ProjectCommitments_LastButton"].Enbl="false";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="false";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="false";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""false"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="true";ISpace["MF_ProjectCommitments_LastButton"].Enbl="true";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="false";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="false";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""true"";");
}
}
else
{
base.WriteDebugInfo(@"else");
if(ISpace["MF_Budgetdetails_PageIndex"].Value==ISpace["MF_Budgetdetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_Budgetdetails_PageIndex""].Value==ISpace[""MF_Budgetdetails_TotalPages""].Value)");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="false";ISpace["MF_ProjectCommitments_LastButton"].Enbl="false";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="true";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="true";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="true";ISpace["MF_ProjectCommitments_LastButton"].Enbl="true";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="true";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="true";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""true"";");
}
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySourceD840F8CC40764F70BB276BC03624E86F =GetQueryExpressionDataSource("D840F8CC-4076-4F70-BB27-6BC03624E86F");

DataTable resultD840F8CC40764F70BB276BC03624E86F=iSpace.SetGridDataSource(querySourceD840F8CC40764F70BB276BC03624E86F, _objectFactory.GetGridRPP("Budgetdetails"),@"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 1,'" + ISpace["F_BudgetHeadId"].Value + @"',''," + ISpace["MF_Budgetdetails_PageIndex"].Value + @",'" + ISpace["MF_Budgetdetails_GridRows"].Value + @"','" + ISpace["F_ProjectDetailsId"].Value + @"'");

iSpace.InsertGridBindDetails("Budgetdetails","11",querySourceD840F8CC40764F70BB276BC03624E86F,"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 1,'" + ISpace["F_BudgetHeadId"].Value + @"',''," + ISpace["MF_Budgetdetails_PageIndex"].Value + @",'" + ISpace["MF_Budgetdetails_GridRows"].Value + @"','" + ISpace["F_ProjectDetailsId"].Value + @"'",_objectFactory.GetGridRPP("Budgetdetails"));

base.WriteDebugInfo(@"var querySourceD840F8CC40764F70BB276BC03624E86F =GetQueryExpressionDataSource(""D840F8CC-4076-4F70-BB27-6BC03624E86F"");DataTable resultD840F8CC40764F70BB276BC03624E86F=iSpace.SetGridDataSource(querySourceD840F8CC40764F70BB276BC03624E86F, _objectFactory.GetGridRPP(""Budgetdetails""),@""EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 1,'"" + ISpace[""F_BudgetHeadId""].Value + @""','',"" + ISpace[""MF_Budgetdetails_PageIndex""].Value + @"",'"" + ISpace[""MF_Budgetdetails_GridRows""].Value + @""','"" + ISpace[""F_ProjectDetailsId""].Value + @""'"");iSpace.InsertGridBindDetails(""Budgetdetails"",""11"",querySourceD840F8CC40764F70BB276BC03624E86F,""EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 1,'"" + ISpace[""F_BudgetHeadId""].Value + @""','',"" + ISpace[""MF_Budgetdetails_PageIndex""].Value + @"",'"" + ISpace[""MF_Budgetdetails_GridRows""].Value + @""','"" + ISpace[""F_ProjectDetailsId""].Value + @""'"",_objectFactory.GetGridRPP(""Budgetdetails""));");
base.WriteDebugInfo(@"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 1,'#F_BudgetHeadId','',#MF_Budgetdetails_PageIndex,'#MF_Budgetdetails_GridRows'");


List<Triplet<string, short, short?>> resultF197120EAAA7488594BFCD708A09CE9F=acdataIspace585BA2B83E754DABB50B10D8320CE414.GetQueryExpressionBindings("F197120E-AAA7-4885-94BF-CD708A09CE9F");
iSpace.SetGridData(resultD840F8CC40764F70BB276BC03624E86F,resultF197120EAAA7488594BFCD708A09CE9F,"Budgetdetails",ref ISpace);
iSpace.UpdateGridBindDetails("Budgetdetails",resultF197120EAAA7488594BFCD708A09CE9F);
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mf_budgetdetails_pageindex (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MF_Budgetdetails_PageIndex-OnChange");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 0,'#F_BudgetHeadId','',#MF_Budgetdetails_PageIndex,'#MF_Budgetdetails_GridRows','#F_ProjectDetailsId'");

var querySource05309A85D55C43B8A687C2A189F723E7 =GetQueryExpressionDataSource("05309A85-D55C-43B8-A687-C2A189F723E7");
Dictionary<short,object> result05309A85D55C43B8A687C2A189F723E7=iSpace.ExecuteQuery(querySource05309A85D55C43B8A687C2A189F723E7,@"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 0,'" + ISpace["F_BudgetHeadId"].Value + @"',''," + ISpace["MF_Budgetdetails_PageIndex"].Value + @",'" + ISpace["MF_Budgetdetails_GridRows"].Value + @"','" + ISpace["F_ProjectDetailsId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource05309A85D55C43B8A687C2A189F723E7 =GetQueryExpressionDataSource(""05309A85-D55C-43B8-A687-C2A189F723E7"");Dictionary<short,object> result05309A85D55C43B8A687C2A189F723E7=iSpace.ExecuteQuery(querySource05309A85D55C43B8A687C2A189F723E7,@""EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 0,'"" + ISpace[""F_BudgetHeadId""].Value + @""','',"" + ISpace[""MF_Budgetdetails_PageIndex""].Value + @"",'"" + ISpace[""MF_Budgetdetails_GridRows""].Value + @""','"" + ISpace[""F_ProjectDetailsId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result05309A85D55C43B8A687C2A189F723E7!=null) && (result05309A85D55C43B8A687C2A189F723E7.Count!=0))
{
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(0))
ISpace["MF_ProjectCommitments_GridRows"].Value = result05309A85D55C43B8A687C2A189F723E7[0];
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(3))
ISpace["MF_ProjectCommitments_TotalPages"].Value = result05309A85D55C43B8A687C2A189F723E7[3];
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(2))
ISpace["MF_ProjectCommitments_PageIndex"].Value = result05309A85D55C43B8A687C2A189F723E7[2];
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(1))
ISpace["MF_ProjectCommitments_RecordsRange"].Value = result05309A85D55C43B8A687C2A189F723E7[1];
}
else{
ISpace["MF_ProjectCommitments_GridRows"].Value = null;ISpace["MF_ProjectCommitments_TotalPages"].Value = null;ISpace["MF_ProjectCommitments_PageIndex"].Value = null;ISpace["MF_ProjectCommitments_RecordsRange"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_Budgetdetails_PageIndex"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""MF_Budgetdetails_PageIndex""].Value==1)");
if(ISpace["MF_Budgetdetails_PageIndex"].Value==ISpace["MF_Budgetdetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_Budgetdetails_PageIndex""].Value==ISpace[""MF_Budgetdetails_TotalPages""].Value)");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="false";ISpace["MF_ProjectCommitments_LastButton"].Enbl="false";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="false";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="false";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""false"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="true";ISpace["MF_ProjectCommitments_LastButton"].Enbl="true";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="false";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="false";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""true"";");
}
}
else
{
base.WriteDebugInfo(@"else");
if(ISpace["MF_Budgetdetails_PageIndex"].Value==ISpace["MF_Budgetdetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_Budgetdetails_PageIndex""].Value==ISpace[""MF_Budgetdetails_TotalPages""].Value)");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="false";ISpace["MF_ProjectCommitments_LastButton"].Enbl="false";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="true";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="true";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="true";ISpace["MF_ProjectCommitments_LastButton"].Enbl="true";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="true";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="true";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""true"";");
}
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySourceD840F8CC40764F70BB276BC03624E86F =GetQueryExpressionDataSource("D840F8CC-4076-4F70-BB27-6BC03624E86F");

DataTable resultD840F8CC40764F70BB276BC03624E86F=iSpace.SetGridDataSource(querySourceD840F8CC40764F70BB276BC03624E86F, _objectFactory.GetGridRPP("Budgetdetails"),@"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 1,'" + ISpace["F_BudgetHeadId"].Value + @"',''," + ISpace["MF_Budgetdetails_PageIndex"].Value + @",'" + ISpace["MF_Budgetdetails_GridRows"].Value + @"','" + ISpace["F_ProjectDetailsId"].Value + @"'");

iSpace.InsertGridBindDetails("Budgetdetails","11",querySourceD840F8CC40764F70BB276BC03624E86F,"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 1,'" + ISpace["F_BudgetHeadId"].Value + @"',''," + ISpace["MF_Budgetdetails_PageIndex"].Value + @",'" + ISpace["MF_Budgetdetails_GridRows"].Value + @"','" + ISpace["F_ProjectDetailsId"].Value + @"'",_objectFactory.GetGridRPP("Budgetdetails"));

base.WriteDebugInfo(@"var querySourceD840F8CC40764F70BB276BC03624E86F =GetQueryExpressionDataSource(""D840F8CC-4076-4F70-BB27-6BC03624E86F"");DataTable resultD840F8CC40764F70BB276BC03624E86F=iSpace.SetGridDataSource(querySourceD840F8CC40764F70BB276BC03624E86F, _objectFactory.GetGridRPP(""Budgetdetails""),@""EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 1,'"" + ISpace[""F_BudgetHeadId""].Value + @""','',"" + ISpace[""MF_Budgetdetails_PageIndex""].Value + @"",'"" + ISpace[""MF_Budgetdetails_GridRows""].Value + @""','"" + ISpace[""F_ProjectDetailsId""].Value + @""'"");iSpace.InsertGridBindDetails(""Budgetdetails"",""11"",querySourceD840F8CC40764F70BB276BC03624E86F,""EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 1,'"" + ISpace[""F_BudgetHeadId""].Value + @""','',"" + ISpace[""MF_Budgetdetails_PageIndex""].Value + @"",'"" + ISpace[""MF_Budgetdetails_GridRows""].Value + @""','"" + ISpace[""F_ProjectDetailsId""].Value + @""'"",_objectFactory.GetGridRPP(""Budgetdetails""));");
base.WriteDebugInfo(@"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 1,'#F_BudgetHeadId','',#MF_Budgetdetails_PageIndex,'#MF_Budgetdetails_GridRows'");


List<Triplet<string, short, short?>> resultF197120EAAA7488594BFCD708A09CE9F=acdataIspace585BA2B83E754DABB50B10D8320CE414.GetQueryExpressionBindings("F197120E-AAA7-4885-94BF-CD708A09CE9F");
iSpace.SetGridData(resultD840F8CC40764F70BB276BC03624E86F,resultF197120EAAA7488594BFCD708A09CE9F,"Budgetdetails",ref ISpace);
iSpace.UpdateGridBindDetails("Budgetdetails",resultF197120EAAA7488594BFCD708A09CE9F);
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mf_receiptsview_gridrows (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MF_ReceiptsView_GridRows-OnChange");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 0,'#F_BudgetHeadId','',#MF_Budgetdetails_PageIndex,'#MF_Budgetdetails_GridRows','#F_ProjectDetailsId'");

var querySource05309A85D55C43B8A687C2A189F723E7 =GetQueryExpressionDataSource("05309A85-D55C-43B8-A687-C2A189F723E7");
Dictionary<short,object> result05309A85D55C43B8A687C2A189F723E7=iSpace.ExecuteQuery(querySource05309A85D55C43B8A687C2A189F723E7,@"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 0,'" + ISpace["F_BudgetHeadId"].Value + @"',''," + ISpace["MF_Budgetdetails_PageIndex"].Value + @",'" + ISpace["MF_Budgetdetails_GridRows"].Value + @"','" + ISpace["F_ProjectDetailsId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource05309A85D55C43B8A687C2A189F723E7 =GetQueryExpressionDataSource(""05309A85-D55C-43B8-A687-C2A189F723E7"");Dictionary<short,object> result05309A85D55C43B8A687C2A189F723E7=iSpace.ExecuteQuery(querySource05309A85D55C43B8A687C2A189F723E7,@""EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 0,'"" + ISpace[""F_BudgetHeadId""].Value + @""','',"" + ISpace[""MF_Budgetdetails_PageIndex""].Value + @"",'"" + ISpace[""MF_Budgetdetails_GridRows""].Value + @""','"" + ISpace[""F_ProjectDetailsId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result05309A85D55C43B8A687C2A189F723E7!=null) && (result05309A85D55C43B8A687C2A189F723E7.Count!=0))
{
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(0))
ISpace["MF_ProjectCommitments_GridRows"].Value = result05309A85D55C43B8A687C2A189F723E7[0];
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(3))
ISpace["MF_ProjectCommitments_TotalPages"].Value = result05309A85D55C43B8A687C2A189F723E7[3];
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(2))
ISpace["MF_ProjectCommitments_PageIndex"].Value = result05309A85D55C43B8A687C2A189F723E7[2];
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(1))
ISpace["MF_ProjectCommitments_RecordsRange"].Value = result05309A85D55C43B8A687C2A189F723E7[1];
}
else{
ISpace["MF_ProjectCommitments_GridRows"].Value = null;ISpace["MF_ProjectCommitments_TotalPages"].Value = null;ISpace["MF_ProjectCommitments_PageIndex"].Value = null;ISpace["MF_ProjectCommitments_RecordsRange"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_Budgetdetails_PageIndex"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""MF_Budgetdetails_PageIndex""].Value==1)");
if(ISpace["MF_Budgetdetails_PageIndex"].Value==ISpace["MF_Budgetdetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_Budgetdetails_PageIndex""].Value==ISpace[""MF_Budgetdetails_TotalPages""].Value)");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="false";ISpace["MF_ProjectCommitments_LastButton"].Enbl="false";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="false";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="false";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""false"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="true";ISpace["MF_ProjectCommitments_LastButton"].Enbl="true";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="false";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="false";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""true"";");
}
}
else
{
base.WriteDebugInfo(@"else");
if(ISpace["MF_Budgetdetails_PageIndex"].Value==ISpace["MF_Budgetdetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_Budgetdetails_PageIndex""].Value==ISpace[""MF_Budgetdetails_TotalPages""].Value)");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="false";ISpace["MF_ProjectCommitments_LastButton"].Enbl="false";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="true";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="true";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="true";ISpace["MF_ProjectCommitments_LastButton"].Enbl="true";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="true";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="true";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""true"";");
}
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySource24686D701FFF4F4F81D7EE238FD68AC3 =GetQueryExpressionDataSource("24686D70-1FFF-4F4F-81D7-EE238FD68AC3");

DataTable result24686D701FFF4F4F81D7EE238FD68AC3=iSpace.SetGridDataSource(querySource24686D701FFF4F4F81D7EE238FD68AC3, _objectFactory.GetGridRPP("ReceiptsView"),@"EXEC dbo.[Get_bd3abae8-b5a2-4b71-b3e2-e46732479592_FilterData] 1,'" + ISpace["F_ReceiptNo"].Value + @"',''," + ISpace["MF_ReceiptsView_PageIndex"].Value + @",'" + ISpace["MF_ReceiptsView_GridRows"].Value + @"','" + ISpace["F_ProjectDetailsID"].Value + @"'");

iSpace.InsertGridBindDetails("ReceiptsView","11",querySource24686D701FFF4F4F81D7EE238FD68AC3,"EXEC dbo.[Get_bd3abae8-b5a2-4b71-b3e2-e46732479592_FilterData] 1,'" + ISpace["F_ReceiptNo"].Value + @"',''," + ISpace["MF_ReceiptsView_PageIndex"].Value + @",'" + ISpace["MF_ReceiptsView_GridRows"].Value + @"','" + ISpace["F_ProjectDetailsID"].Value + @"'",_objectFactory.GetGridRPP("ReceiptsView"));

base.WriteDebugInfo(@"var querySource24686D701FFF4F4F81D7EE238FD68AC3 =GetQueryExpressionDataSource(""24686D70-1FFF-4F4F-81D7-EE238FD68AC3"");DataTable result24686D701FFF4F4F81D7EE238FD68AC3=iSpace.SetGridDataSource(querySource24686D701FFF4F4F81D7EE238FD68AC3, _objectFactory.GetGridRPP(""ReceiptsView""),@""EXEC dbo.[Get_bd3abae8-b5a2-4b71-b3e2-e46732479592_FilterData] 1,'"" + ISpace[""F_ReceiptNo""].Value + @""','',"" + ISpace[""MF_ReceiptsView_PageIndex""].Value + @"",'"" + ISpace[""MF_ReceiptsView_GridRows""].Value + @""','"" + ISpace[""F_ProjectDetailsID""].Value + @""'"");iSpace.InsertGridBindDetails(""ReceiptsView"",""11"",querySource24686D701FFF4F4F81D7EE238FD68AC3,""EXEC dbo.[Get_bd3abae8-b5a2-4b71-b3e2-e46732479592_FilterData] 1,'"" + ISpace[""F_ReceiptNo""].Value + @""','',"" + ISpace[""MF_ReceiptsView_PageIndex""].Value + @"",'"" + ISpace[""MF_ReceiptsView_GridRows""].Value + @""','"" + ISpace[""F_ProjectDetailsID""].Value + @""'"",_objectFactory.GetGridRPP(""ReceiptsView""));");
base.WriteDebugInfo(@"EXEC dbo.[Get_bd3abae8-b5a2-4b71-b3e2-e46732479592_FilterData] 1,'#F_ReceiptNo','',#MF_ReceiptsView_PageIndex,'#MF_ReceiptsView_GridRows'");


List<Triplet<string, short, short?>> result3E6384212EC24473A32F5167327104C5=acdataIspace585BA2B83E754DABB50B10D8320CE414.GetQueryExpressionBindings("3E638421-2EC2-4473-A32F-5167327104C5");
iSpace.SetGridData(result24686D701FFF4F4F81D7EE238FD68AC3,result3E6384212EC24473A32F5167327104C5,"ReceiptsView",ref ISpace);
iSpace.UpdateGridBindDetails("ReceiptsView",result3E6384212EC24473A32F5167327104C5);
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mf_budgetdetails_nextbutton (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MF_Budgetdetails_NextButton-OnClick");
if(ISpace["MF_Budgetdetails_PageIndex"].Value>0)
{
base.WriteDebugInfo(@"if(ISpace[""MF_Budgetdetails_PageIndex""].Value>0)");
ISpace["MF_Budgetdetails_PageIndex"].Value=ISpace["MF_Budgetdetails_PageIndex"].Value+1;
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PageIndex""].Value=ISpace[""MF_Budgetdetails_PageIndex""].Value+1;");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_Budgetdetails_PageIndex"].Value=1;
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PageIndex""].Value=1;");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 0,'#F_BudgetHeadId','',#MF_Budgetdetails_PageIndex,'#MF_Budgetdetails_GridRows','#F_ProjectDetailsId'");

var querySource05309A85D55C43B8A687C2A189F723E7 =GetQueryExpressionDataSource("05309A85-D55C-43B8-A687-C2A189F723E7");
Dictionary<short,object> result05309A85D55C43B8A687C2A189F723E7=iSpace.ExecuteQuery(querySource05309A85D55C43B8A687C2A189F723E7,@"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 0,'" + ISpace["F_BudgetHeadId"].Value + @"',''," + ISpace["MF_Budgetdetails_PageIndex"].Value + @",'" + ISpace["MF_Budgetdetails_GridRows"].Value + @"','" + ISpace["F_ProjectDetailsId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource05309A85D55C43B8A687C2A189F723E7 =GetQueryExpressionDataSource(""05309A85-D55C-43B8-A687-C2A189F723E7"");Dictionary<short,object> result05309A85D55C43B8A687C2A189F723E7=iSpace.ExecuteQuery(querySource05309A85D55C43B8A687C2A189F723E7,@""EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 0,'"" + ISpace[""F_BudgetHeadId""].Value + @""','',"" + ISpace[""MF_Budgetdetails_PageIndex""].Value + @"",'"" + ISpace[""MF_Budgetdetails_GridRows""].Value + @""','"" + ISpace[""F_ProjectDetailsId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result05309A85D55C43B8A687C2A189F723E7!=null) && (result05309A85D55C43B8A687C2A189F723E7.Count!=0))
{
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(0))
ISpace["MF_ProjectCommitments_GridRows"].Value = result05309A85D55C43B8A687C2A189F723E7[0];
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(3))
ISpace["MF_ProjectCommitments_TotalPages"].Value = result05309A85D55C43B8A687C2A189F723E7[3];
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(2))
ISpace["MF_ProjectCommitments_PageIndex"].Value = result05309A85D55C43B8A687C2A189F723E7[2];
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(1))
ISpace["MF_ProjectCommitments_RecordsRange"].Value = result05309A85D55C43B8A687C2A189F723E7[1];
}
else{
ISpace["MF_ProjectCommitments_GridRows"].Value = null;ISpace["MF_ProjectCommitments_TotalPages"].Value = null;ISpace["MF_ProjectCommitments_PageIndex"].Value = null;ISpace["MF_ProjectCommitments_RecordsRange"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_Budgetdetails_PageIndex"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""MF_Budgetdetails_PageIndex""].Value==1)");
if(ISpace["MF_Budgetdetails_PageIndex"].Value==ISpace["MF_Budgetdetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_Budgetdetails_PageIndex""].Value==ISpace[""MF_Budgetdetails_TotalPages""].Value)");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="false";ISpace["MF_ProjectCommitments_LastButton"].Enbl="false";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="false";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="false";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""false"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="true";ISpace["MF_ProjectCommitments_LastButton"].Enbl="true";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="false";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="false";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""true"";");
}
}
else
{
base.WriteDebugInfo(@"else");
if(ISpace["MF_Budgetdetails_PageIndex"].Value==ISpace["MF_Budgetdetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_Budgetdetails_PageIndex""].Value==ISpace[""MF_Budgetdetails_TotalPages""].Value)");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="false";ISpace["MF_ProjectCommitments_LastButton"].Enbl="false";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="true";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="true";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="true";ISpace["MF_ProjectCommitments_LastButton"].Enbl="true";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="true";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="true";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""true"";");
}
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySourceD840F8CC40764F70BB276BC03624E86F =GetQueryExpressionDataSource("D840F8CC-4076-4F70-BB27-6BC03624E86F");

DataTable resultD840F8CC40764F70BB276BC03624E86F=iSpace.SetGridDataSource(querySourceD840F8CC40764F70BB276BC03624E86F, _objectFactory.GetGridRPP("Budgetdetails"),@"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 1,'" + ISpace["F_BudgetHeadId"].Value + @"',''," + ISpace["MF_Budgetdetails_PageIndex"].Value + @",'" + ISpace["MF_Budgetdetails_GridRows"].Value + @"','" + ISpace["F_ProjectDetailsId"].Value + @"'");

iSpace.InsertGridBindDetails("Budgetdetails","11",querySourceD840F8CC40764F70BB276BC03624E86F,"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 1,'" + ISpace["F_BudgetHeadId"].Value + @"',''," + ISpace["MF_Budgetdetails_PageIndex"].Value + @",'" + ISpace["MF_Budgetdetails_GridRows"].Value + @"','" + ISpace["F_ProjectDetailsId"].Value + @"'",_objectFactory.GetGridRPP("Budgetdetails"));

base.WriteDebugInfo(@"var querySourceD840F8CC40764F70BB276BC03624E86F =GetQueryExpressionDataSource(""D840F8CC-4076-4F70-BB27-6BC03624E86F"");DataTable resultD840F8CC40764F70BB276BC03624E86F=iSpace.SetGridDataSource(querySourceD840F8CC40764F70BB276BC03624E86F, _objectFactory.GetGridRPP(""Budgetdetails""),@""EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 1,'"" + ISpace[""F_BudgetHeadId""].Value + @""','',"" + ISpace[""MF_Budgetdetails_PageIndex""].Value + @"",'"" + ISpace[""MF_Budgetdetails_GridRows""].Value + @""','"" + ISpace[""F_ProjectDetailsId""].Value + @""'"");iSpace.InsertGridBindDetails(""Budgetdetails"",""11"",querySourceD840F8CC40764F70BB276BC03624E86F,""EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 1,'"" + ISpace[""F_BudgetHeadId""].Value + @""','',"" + ISpace[""MF_Budgetdetails_PageIndex""].Value + @"",'"" + ISpace[""MF_Budgetdetails_GridRows""].Value + @""','"" + ISpace[""F_ProjectDetailsId""].Value + @""'"",_objectFactory.GetGridRPP(""Budgetdetails""));");
base.WriteDebugInfo(@"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 1,'#F_BudgetHeadId','',#MF_Budgetdetails_PageIndex,'#MF_Budgetdetails_GridRows'");


List<Triplet<string, short, short?>> resultF197120EAAA7488594BFCD708A09CE9F=acdataIspace585BA2B83E754DABB50B10D8320CE414.GetQueryExpressionBindings("F197120E-AAA7-4885-94BF-CD708A09CE9F");
iSpace.SetGridData(resultD840F8CC40764F70BB276BC03624E86F,resultF197120EAAA7488594BFCD708A09CE9F,"Budgetdetails",ref ISpace);
iSpace.UpdateGridBindDetails("Budgetdetails",resultF197120EAAA7488594BFCD708A09CE9F);
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mf_projectcommitments_nextbutton (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MF_ProjectCommitments_NextButton-OnClick");
if(ISpace["MF_Budgetdetails_PageIndex"].Value>0)
{
base.WriteDebugInfo(@"if(ISpace[""MF_Budgetdetails_PageIndex""].Value>0)");
ISpace["MF_Budgetdetails_PageIndex"].Value=ISpace["MF_Budgetdetails_PageIndex"].Value+1;
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PageIndex""].Value=ISpace[""MF_Budgetdetails_PageIndex""].Value+1;");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_Budgetdetails_PageIndex"].Value=1;
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PageIndex""].Value=1;");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 0,'#F_BudgetHeadId','',#MF_Budgetdetails_PageIndex,'#MF_Budgetdetails_GridRows','#F_ProjectDetailsId'");

var querySource05309A85D55C43B8A687C2A189F723E7 =GetQueryExpressionDataSource("05309A85-D55C-43B8-A687-C2A189F723E7");
Dictionary<short,object> result05309A85D55C43B8A687C2A189F723E7=iSpace.ExecuteQuery(querySource05309A85D55C43B8A687C2A189F723E7,@"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 0,'" + ISpace["F_BudgetHeadId"].Value + @"',''," + ISpace["MF_Budgetdetails_PageIndex"].Value + @",'" + ISpace["MF_Budgetdetails_GridRows"].Value + @"','" + ISpace["F_ProjectDetailsId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource05309A85D55C43B8A687C2A189F723E7 =GetQueryExpressionDataSource(""05309A85-D55C-43B8-A687-C2A189F723E7"");Dictionary<short,object> result05309A85D55C43B8A687C2A189F723E7=iSpace.ExecuteQuery(querySource05309A85D55C43B8A687C2A189F723E7,@""EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 0,'"" + ISpace[""F_BudgetHeadId""].Value + @""','',"" + ISpace[""MF_Budgetdetails_PageIndex""].Value + @"",'"" + ISpace[""MF_Budgetdetails_GridRows""].Value + @""','"" + ISpace[""F_ProjectDetailsId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result05309A85D55C43B8A687C2A189F723E7!=null) && (result05309A85D55C43B8A687C2A189F723E7.Count!=0))
{
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(0))
ISpace["MF_ProjectCommitments_GridRows"].Value = result05309A85D55C43B8A687C2A189F723E7[0];
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(3))
ISpace["MF_ProjectCommitments_TotalPages"].Value = result05309A85D55C43B8A687C2A189F723E7[3];
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(2))
ISpace["MF_ProjectCommitments_PageIndex"].Value = result05309A85D55C43B8A687C2A189F723E7[2];
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(1))
ISpace["MF_ProjectCommitments_RecordsRange"].Value = result05309A85D55C43B8A687C2A189F723E7[1];
}
else{
ISpace["MF_ProjectCommitments_GridRows"].Value = null;ISpace["MF_ProjectCommitments_TotalPages"].Value = null;ISpace["MF_ProjectCommitments_PageIndex"].Value = null;ISpace["MF_ProjectCommitments_RecordsRange"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_Budgetdetails_PageIndex"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""MF_Budgetdetails_PageIndex""].Value==1)");
if(ISpace["MF_Budgetdetails_PageIndex"].Value==ISpace["MF_Budgetdetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_Budgetdetails_PageIndex""].Value==ISpace[""MF_Budgetdetails_TotalPages""].Value)");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="false";ISpace["MF_ProjectCommitments_LastButton"].Enbl="false";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="false";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="false";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""false"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="true";ISpace["MF_ProjectCommitments_LastButton"].Enbl="true";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="false";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="false";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""true"";");
}
}
else
{
base.WriteDebugInfo(@"else");
if(ISpace["MF_Budgetdetails_PageIndex"].Value==ISpace["MF_Budgetdetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_Budgetdetails_PageIndex""].Value==ISpace[""MF_Budgetdetails_TotalPages""].Value)");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="false";ISpace["MF_ProjectCommitments_LastButton"].Enbl="false";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="true";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="true";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="true";ISpace["MF_ProjectCommitments_LastButton"].Enbl="true";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="true";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="true";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""true"";");
}
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySource01000C9CF4F74DAA8E0E4E2ACF3299FF =GetQueryExpressionDataSource("01000C9C-F4F7-4DAA-8E0E-4E2ACF3299FF");

DataTable result01000C9CF4F74DAA8E0E4E2ACF3299FF=iSpace.SetGridDataSource(querySource01000C9CF4F74DAA8E0E4E2ACF3299FF, _objectFactory.GetGridRPP("ProjectCommitments"),@"EXEC dbo.[Get_e046fb44-e1f1-4f2a-a07e-231e72f92166_FilterData] 1,'" + ISpace["F_ProjectDetailsId"].Value + @"',''," + ISpace["MF_ProjectCommitments_PageIndex"].Value + @",'" + ISpace["MF_ProjectCommitments_GridRows"].Value + @"'");

iSpace.InsertGridBindDetails("ProjectCommitments","11",querySource01000C9CF4F74DAA8E0E4E2ACF3299FF,"EXEC dbo.[Get_e046fb44-e1f1-4f2a-a07e-231e72f92166_FilterData] 1,'" + ISpace["F_ProjectDetailsId"].Value + @"',''," + ISpace["MF_ProjectCommitments_PageIndex"].Value + @",'" + ISpace["MF_ProjectCommitments_GridRows"].Value + @"'",_objectFactory.GetGridRPP("ProjectCommitments"));

base.WriteDebugInfo(@"var querySource01000C9CF4F74DAA8E0E4E2ACF3299FF =GetQueryExpressionDataSource(""01000C9C-F4F7-4DAA-8E0E-4E2ACF3299FF"");DataTable result01000C9CF4F74DAA8E0E4E2ACF3299FF=iSpace.SetGridDataSource(querySource01000C9CF4F74DAA8E0E4E2ACF3299FF, _objectFactory.GetGridRPP(""ProjectCommitments""),@""EXEC dbo.[Get_e046fb44-e1f1-4f2a-a07e-231e72f92166_FilterData] 1,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',"" + ISpace[""MF_ProjectCommitments_PageIndex""].Value + @"",'"" + ISpace[""MF_ProjectCommitments_GridRows""].Value + @""'"");iSpace.InsertGridBindDetails(""ProjectCommitments"",""11"",querySource01000C9CF4F74DAA8E0E4E2ACF3299FF,""EXEC dbo.[Get_e046fb44-e1f1-4f2a-a07e-231e72f92166_FilterData] 1,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',"" + ISpace[""MF_ProjectCommitments_PageIndex""].Value + @"",'"" + ISpace[""MF_ProjectCommitments_GridRows""].Value + @""'"",_objectFactory.GetGridRPP(""ProjectCommitments""));");
base.WriteDebugInfo(@"EXEC dbo.[Get_e046fb44-e1f1-4f2a-a07e-231e72f92166_FilterData] 1,'#F_ProjectDetailsId','',#MF_ProjectCommitments_PageIndex,'#MF_ProjectCommitments_GridRows'");


List<Triplet<string, short, short?>> result34DD54DC0E5B46EAA0BBD99E022B7345=acdataIspace585BA2B83E754DABB50B10D8320CE414.GetQueryExpressionBindings("34DD54DC-0E5B-46EA-A0BB-D99E022B7345");
iSpace.SetGridData(result01000C9CF4F74DAA8E0E4E2ACF3299FF,result34DD54DC0E5B46EAA0BBD99E022B7345,"ProjectCommitments",ref ISpace);
iSpace.UpdateGridBindDetails("ProjectCommitments",result34DD54DC0E5B46EAA0BBD99E022B7345);
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_apply (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Apply-OnClick");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 0,'#F_BudgetHeadId','',#MF_Budgetdetails_PageIndex,'#MF_Budgetdetails_GridRows','#F_ProjectDetailsId'");

var querySource05309A85D55C43B8A687C2A189F723E7 =GetQueryExpressionDataSource("05309A85-D55C-43B8-A687-C2A189F723E7");
Dictionary<short,object> result05309A85D55C43B8A687C2A189F723E7=iSpace.ExecuteQuery(querySource05309A85D55C43B8A687C2A189F723E7,@"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 0,'" + ISpace["F_BudgetHeadId"].Value + @"',''," + ISpace["MF_Budgetdetails_PageIndex"].Value + @",'" + ISpace["MF_Budgetdetails_GridRows"].Value + @"','" + ISpace["F_ProjectDetailsId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource05309A85D55C43B8A687C2A189F723E7 =GetQueryExpressionDataSource(""05309A85-D55C-43B8-A687-C2A189F723E7"");Dictionary<short,object> result05309A85D55C43B8A687C2A189F723E7=iSpace.ExecuteQuery(querySource05309A85D55C43B8A687C2A189F723E7,@""EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 0,'"" + ISpace[""F_BudgetHeadId""].Value + @""','',"" + ISpace[""MF_Budgetdetails_PageIndex""].Value + @"",'"" + ISpace[""MF_Budgetdetails_GridRows""].Value + @""','"" + ISpace[""F_ProjectDetailsId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result05309A85D55C43B8A687C2A189F723E7!=null) && (result05309A85D55C43B8A687C2A189F723E7.Count!=0))
{
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(0))
ISpace["MF_ProjectCommitments_GridRows"].Value = result05309A85D55C43B8A687C2A189F723E7[0];
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(3))
ISpace["MF_ProjectCommitments_TotalPages"].Value = result05309A85D55C43B8A687C2A189F723E7[3];
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(2))
ISpace["MF_ProjectCommitments_PageIndex"].Value = result05309A85D55C43B8A687C2A189F723E7[2];
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(1))
ISpace["MF_ProjectCommitments_RecordsRange"].Value = result05309A85D55C43B8A687C2A189F723E7[1];
}
else{
ISpace["MF_ProjectCommitments_GridRows"].Value = null;ISpace["MF_ProjectCommitments_TotalPages"].Value = null;ISpace["MF_ProjectCommitments_PageIndex"].Value = null;ISpace["MF_ProjectCommitments_RecordsRange"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 0,'#F_BudgetHeadId','',#MF_Budgetdetails_PageIndex,'#MF_Budgetdetails_GridRows','#F_ProjectDetailsId'");

var querySource05309A85D55C43B8A687C2A189F723E7 =GetQueryExpressionDataSource("05309A85-D55C-43B8-A687-C2A189F723E7");
Dictionary<short,object> result05309A85D55C43B8A687C2A189F723E7=iSpace.ExecuteQuery(querySource05309A85D55C43B8A687C2A189F723E7,@"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 0,'" + ISpace["F_BudgetHeadId"].Value + @"',''," + ISpace["MF_Budgetdetails_PageIndex"].Value + @",'" + ISpace["MF_Budgetdetails_GridRows"].Value + @"','" + ISpace["F_ProjectDetailsId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource05309A85D55C43B8A687C2A189F723E7 =GetQueryExpressionDataSource(""05309A85-D55C-43B8-A687-C2A189F723E7"");Dictionary<short,object> result05309A85D55C43B8A687C2A189F723E7=iSpace.ExecuteQuery(querySource05309A85D55C43B8A687C2A189F723E7,@""EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 0,'"" + ISpace[""F_BudgetHeadId""].Value + @""','',"" + ISpace[""MF_Budgetdetails_PageIndex""].Value + @"",'"" + ISpace[""MF_Budgetdetails_GridRows""].Value + @""','"" + ISpace[""F_ProjectDetailsId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result05309A85D55C43B8A687C2A189F723E7!=null) && (result05309A85D55C43B8A687C2A189F723E7.Count!=0))
{
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(0))
ISpace["MF_ProjectCommitments_GridRows"].Value = result05309A85D55C43B8A687C2A189F723E7[0];
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(3))
ISpace["MF_ProjectCommitments_TotalPages"].Value = result05309A85D55C43B8A687C2A189F723E7[3];
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(2))
ISpace["MF_ProjectCommitments_PageIndex"].Value = result05309A85D55C43B8A687C2A189F723E7[2];
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(1))
ISpace["MF_ProjectCommitments_RecordsRange"].Value = result05309A85D55C43B8A687C2A189F723E7[1];
}
else{
ISpace["MF_ProjectCommitments_GridRows"].Value = null;ISpace["MF_ProjectCommitments_TotalPages"].Value = null;ISpace["MF_ProjectCommitments_PageIndex"].Value = null;ISpace["MF_ProjectCommitments_RecordsRange"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 0,'#F_BudgetHeadId','',#MF_Budgetdetails_PageIndex,'#MF_Budgetdetails_GridRows','#F_ProjectDetailsId'");

var querySource05309A85D55C43B8A687C2A189F723E7 =GetQueryExpressionDataSource("05309A85-D55C-43B8-A687-C2A189F723E7");
Dictionary<short,object> result05309A85D55C43B8A687C2A189F723E7=iSpace.ExecuteQuery(querySource05309A85D55C43B8A687C2A189F723E7,@"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 0,'" + ISpace["F_BudgetHeadId"].Value + @"',''," + ISpace["MF_Budgetdetails_PageIndex"].Value + @",'" + ISpace["MF_Budgetdetails_GridRows"].Value + @"','" + ISpace["F_ProjectDetailsId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource05309A85D55C43B8A687C2A189F723E7 =GetQueryExpressionDataSource(""05309A85-D55C-43B8-A687-C2A189F723E7"");Dictionary<short,object> result05309A85D55C43B8A687C2A189F723E7=iSpace.ExecuteQuery(querySource05309A85D55C43B8A687C2A189F723E7,@""EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 0,'"" + ISpace[""F_BudgetHeadId""].Value + @""','',"" + ISpace[""MF_Budgetdetails_PageIndex""].Value + @"",'"" + ISpace[""MF_Budgetdetails_GridRows""].Value + @""','"" + ISpace[""F_ProjectDetailsId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result05309A85D55C43B8A687C2A189F723E7!=null) && (result05309A85D55C43B8A687C2A189F723E7.Count!=0))
{
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(0))
ISpace["MF_ProjectCommitments_GridRows"].Value = result05309A85D55C43B8A687C2A189F723E7[0];
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(3))
ISpace["MF_ProjectCommitments_TotalPages"].Value = result05309A85D55C43B8A687C2A189F723E7[3];
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(2))
ISpace["MF_ProjectCommitments_PageIndex"].Value = result05309A85D55C43B8A687C2A189F723E7[2];
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(1))
ISpace["MF_ProjectCommitments_RecordsRange"].Value = result05309A85D55C43B8A687C2A189F723E7[1];
}
else{
ISpace["MF_ProjectCommitments_GridRows"].Value = null;ISpace["MF_ProjectCommitments_TotalPages"].Value = null;ISpace["MF_ProjectCommitments_PageIndex"].Value = null;ISpace["MF_ProjectCommitments_RecordsRange"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_Budgetdetails_PageIndex"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""MF_Budgetdetails_PageIndex""].Value==1)");
if(ISpace["MF_Budgetdetails_PageIndex"].Value==ISpace["MF_Budgetdetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_Budgetdetails_PageIndex""].Value==ISpace[""MF_Budgetdetails_TotalPages""].Value)");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="false";ISpace["MF_ProjectCommitments_LastButton"].Enbl="false";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="false";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="false";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""false"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="true";ISpace["MF_ProjectCommitments_LastButton"].Enbl="true";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="false";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="false";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""true"";");
}
}
else
{
base.WriteDebugInfo(@"else");
if(ISpace["MF_Budgetdetails_PageIndex"].Value==ISpace["MF_Budgetdetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_Budgetdetails_PageIndex""].Value==ISpace[""MF_Budgetdetails_TotalPages""].Value)");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="false";ISpace["MF_ProjectCommitments_LastButton"].Enbl="false";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="true";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="true";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="true";ISpace["MF_ProjectCommitments_LastButton"].Enbl="true";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="true";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="true";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""true"";");
}
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_Budgetdetails_PageIndex"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""MF_Budgetdetails_PageIndex""].Value==1)");
if(ISpace["MF_Budgetdetails_PageIndex"].Value==ISpace["MF_Budgetdetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_Budgetdetails_PageIndex""].Value==ISpace[""MF_Budgetdetails_TotalPages""].Value)");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="false";ISpace["MF_ProjectCommitments_LastButton"].Enbl="false";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="false";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="false";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""false"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="true";ISpace["MF_ProjectCommitments_LastButton"].Enbl="true";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="false";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="false";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""true"";");
}
}
else
{
base.WriteDebugInfo(@"else");
if(ISpace["MF_Budgetdetails_PageIndex"].Value==ISpace["MF_Budgetdetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_Budgetdetails_PageIndex""].Value==ISpace[""MF_Budgetdetails_TotalPages""].Value)");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="false";ISpace["MF_ProjectCommitments_LastButton"].Enbl="false";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="true";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="true";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="true";ISpace["MF_ProjectCommitments_LastButton"].Enbl="true";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="true";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="true";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""true"";");
}
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_Budgetdetails_PageIndex"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""MF_Budgetdetails_PageIndex""].Value==1)");
if(ISpace["MF_Budgetdetails_PageIndex"].Value==ISpace["MF_Budgetdetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_Budgetdetails_PageIndex""].Value==ISpace[""MF_Budgetdetails_TotalPages""].Value)");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="false";ISpace["MF_ProjectCommitments_LastButton"].Enbl="false";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="false";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="false";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""false"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="true";ISpace["MF_ProjectCommitments_LastButton"].Enbl="true";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="false";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="false";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""true"";");
}
}
else
{
base.WriteDebugInfo(@"else");
if(ISpace["MF_Budgetdetails_PageIndex"].Value==ISpace["MF_Budgetdetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_Budgetdetails_PageIndex""].Value==ISpace[""MF_Budgetdetails_TotalPages""].Value)");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="false";ISpace["MF_ProjectCommitments_LastButton"].Enbl="false";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="true";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="true";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="true";ISpace["MF_ProjectCommitments_LastButton"].Enbl="true";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="true";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="true";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""true"";");
}
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySource24686D701FFF4F4F81D7EE238FD68AC3 =GetQueryExpressionDataSource("24686D70-1FFF-4F4F-81D7-EE238FD68AC3");

DataTable result24686D701FFF4F4F81D7EE238FD68AC3=iSpace.SetGridDataSource(querySource24686D701FFF4F4F81D7EE238FD68AC3, _objectFactory.GetGridRPP("ReceiptsView"),@"EXEC dbo.[Get_bd3abae8-b5a2-4b71-b3e2-e46732479592_FilterData] 1,'" + ISpace["F_ReceiptNo"].Value + @"',''," + ISpace["MF_ReceiptsView_PageIndex"].Value + @",'" + ISpace["MF_ReceiptsView_GridRows"].Value + @"','" + ISpace["F_ProjectDetailsID"].Value + @"'");

iSpace.InsertGridBindDetails("ReceiptsView","11",querySource24686D701FFF4F4F81D7EE238FD68AC3,"EXEC dbo.[Get_bd3abae8-b5a2-4b71-b3e2-e46732479592_FilterData] 1,'" + ISpace["F_ReceiptNo"].Value + @"',''," + ISpace["MF_ReceiptsView_PageIndex"].Value + @",'" + ISpace["MF_ReceiptsView_GridRows"].Value + @"','" + ISpace["F_ProjectDetailsID"].Value + @"'",_objectFactory.GetGridRPP("ReceiptsView"));

base.WriteDebugInfo(@"var querySource24686D701FFF4F4F81D7EE238FD68AC3 =GetQueryExpressionDataSource(""24686D70-1FFF-4F4F-81D7-EE238FD68AC3"");DataTable result24686D701FFF4F4F81D7EE238FD68AC3=iSpace.SetGridDataSource(querySource24686D701FFF4F4F81D7EE238FD68AC3, _objectFactory.GetGridRPP(""ReceiptsView""),@""EXEC dbo.[Get_bd3abae8-b5a2-4b71-b3e2-e46732479592_FilterData] 1,'"" + ISpace[""F_ReceiptNo""].Value + @""','',"" + ISpace[""MF_ReceiptsView_PageIndex""].Value + @"",'"" + ISpace[""MF_ReceiptsView_GridRows""].Value + @""','"" + ISpace[""F_ProjectDetailsID""].Value + @""'"");iSpace.InsertGridBindDetails(""ReceiptsView"",""11"",querySource24686D701FFF4F4F81D7EE238FD68AC3,""EXEC dbo.[Get_bd3abae8-b5a2-4b71-b3e2-e46732479592_FilterData] 1,'"" + ISpace[""F_ReceiptNo""].Value + @""','',"" + ISpace[""MF_ReceiptsView_PageIndex""].Value + @"",'"" + ISpace[""MF_ReceiptsView_GridRows""].Value + @""','"" + ISpace[""F_ProjectDetailsID""].Value + @""'"",_objectFactory.GetGridRPP(""ReceiptsView""));");
base.WriteDebugInfo(@"EXEC dbo.[Get_bd3abae8-b5a2-4b71-b3e2-e46732479592_FilterData] 1,'#F_ReceiptNo','',#MF_ReceiptsView_PageIndex,'#MF_ReceiptsView_GridRows'");


List<Triplet<string, short, short?>> result3E6384212EC24473A32F5167327104C5=acdataIspace585BA2B83E754DABB50B10D8320CE414.GetQueryExpressionBindings("3E638421-2EC2-4473-A32F-5167327104C5");
iSpace.SetGridData(result24686D701FFF4F4F81D7EE238FD68AC3,result3E6384212EC24473A32F5167327104C5,"ReceiptsView",ref ISpace);
iSpace.UpdateGridBindDetails("ReceiptsView",result3E6384212EC24473A32F5167327104C5);
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySource01000C9CF4F74DAA8E0E4E2ACF3299FF =GetQueryExpressionDataSource("01000C9C-F4F7-4DAA-8E0E-4E2ACF3299FF");

DataTable result01000C9CF4F74DAA8E0E4E2ACF3299FF=iSpace.SetGridDataSource(querySource01000C9CF4F74DAA8E0E4E2ACF3299FF, _objectFactory.GetGridRPP("ProjectCommitments"),@"EXEC dbo.[Get_e046fb44-e1f1-4f2a-a07e-231e72f92166_FilterData] 1,'" + ISpace["F_ProjectDetailsId"].Value + @"',''," + ISpace["MF_ProjectCommitments_PageIndex"].Value + @",'" + ISpace["MF_ProjectCommitments_GridRows"].Value + @"'");

iSpace.InsertGridBindDetails("ProjectCommitments","11",querySource01000C9CF4F74DAA8E0E4E2ACF3299FF,"EXEC dbo.[Get_e046fb44-e1f1-4f2a-a07e-231e72f92166_FilterData] 1,'" + ISpace["F_ProjectDetailsId"].Value + @"',''," + ISpace["MF_ProjectCommitments_PageIndex"].Value + @",'" + ISpace["MF_ProjectCommitments_GridRows"].Value + @"'",_objectFactory.GetGridRPP("ProjectCommitments"));

base.WriteDebugInfo(@"var querySource01000C9CF4F74DAA8E0E4E2ACF3299FF =GetQueryExpressionDataSource(""01000C9C-F4F7-4DAA-8E0E-4E2ACF3299FF"");DataTable result01000C9CF4F74DAA8E0E4E2ACF3299FF=iSpace.SetGridDataSource(querySource01000C9CF4F74DAA8E0E4E2ACF3299FF, _objectFactory.GetGridRPP(""ProjectCommitments""),@""EXEC dbo.[Get_e046fb44-e1f1-4f2a-a07e-231e72f92166_FilterData] 1,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',"" + ISpace[""MF_ProjectCommitments_PageIndex""].Value + @"",'"" + ISpace[""MF_ProjectCommitments_GridRows""].Value + @""'"");iSpace.InsertGridBindDetails(""ProjectCommitments"",""11"",querySource01000C9CF4F74DAA8E0E4E2ACF3299FF,""EXEC dbo.[Get_e046fb44-e1f1-4f2a-a07e-231e72f92166_FilterData] 1,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',"" + ISpace[""MF_ProjectCommitments_PageIndex""].Value + @"",'"" + ISpace[""MF_ProjectCommitments_GridRows""].Value + @""'"",_objectFactory.GetGridRPP(""ProjectCommitments""));");
base.WriteDebugInfo(@"EXEC dbo.[Get_e046fb44-e1f1-4f2a-a07e-231e72f92166_FilterData] 1,'#F_ProjectDetailsId','',#MF_ProjectCommitments_PageIndex,'#MF_ProjectCommitments_GridRows'");


List<Triplet<string, short, short?>> result34DD54DC0E5B46EAA0BBD99E022B7345=acdataIspace585BA2B83E754DABB50B10D8320CE414.GetQueryExpressionBindings("34DD54DC-0E5B-46EA-A0BB-D99E022B7345");
iSpace.SetGridData(result01000C9CF4F74DAA8E0E4E2ACF3299FF,result34DD54DC0E5B46EAA0BBD99E022B7345,"ProjectCommitments",ref ISpace);
iSpace.UpdateGridBindDetails("ProjectCommitments",result34DD54DC0E5B46EAA0BBD99E022B7345);
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySourceD840F8CC40764F70BB276BC03624E86F =GetQueryExpressionDataSource("D840F8CC-4076-4F70-BB27-6BC03624E86F");

DataTable resultD840F8CC40764F70BB276BC03624E86F=iSpace.SetGridDataSource(querySourceD840F8CC40764F70BB276BC03624E86F, _objectFactory.GetGridRPP("Budgetdetails"),@"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 1,'" + ISpace["F_BudgetHeadId"].Value + @"',''," + ISpace["MF_Budgetdetails_PageIndex"].Value + @",'" + ISpace["MF_Budgetdetails_GridRows"].Value + @"','" + ISpace["F_ProjectDetailsId"].Value + @"'");

iSpace.InsertGridBindDetails("Budgetdetails","11",querySourceD840F8CC40764F70BB276BC03624E86F,"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 1,'" + ISpace["F_BudgetHeadId"].Value + @"',''," + ISpace["MF_Budgetdetails_PageIndex"].Value + @",'" + ISpace["MF_Budgetdetails_GridRows"].Value + @"','" + ISpace["F_ProjectDetailsId"].Value + @"'",_objectFactory.GetGridRPP("Budgetdetails"));

base.WriteDebugInfo(@"var querySourceD840F8CC40764F70BB276BC03624E86F =GetQueryExpressionDataSource(""D840F8CC-4076-4F70-BB27-6BC03624E86F"");DataTable resultD840F8CC40764F70BB276BC03624E86F=iSpace.SetGridDataSource(querySourceD840F8CC40764F70BB276BC03624E86F, _objectFactory.GetGridRPP(""Budgetdetails""),@""EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 1,'"" + ISpace[""F_BudgetHeadId""].Value + @""','',"" + ISpace[""MF_Budgetdetails_PageIndex""].Value + @"",'"" + ISpace[""MF_Budgetdetails_GridRows""].Value + @""','"" + ISpace[""F_ProjectDetailsId""].Value + @""'"");iSpace.InsertGridBindDetails(""Budgetdetails"",""11"",querySourceD840F8CC40764F70BB276BC03624E86F,""EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 1,'"" + ISpace[""F_BudgetHeadId""].Value + @""','',"" + ISpace[""MF_Budgetdetails_PageIndex""].Value + @"",'"" + ISpace[""MF_Budgetdetails_GridRows""].Value + @""','"" + ISpace[""F_ProjectDetailsId""].Value + @""'"",_objectFactory.GetGridRPP(""Budgetdetails""));");
base.WriteDebugInfo(@"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 1,'#F_BudgetHeadId','',#MF_Budgetdetails_PageIndex,'#MF_Budgetdetails_GridRows'");


List<Triplet<string, short, short?>> resultF197120EAAA7488594BFCD708A09CE9F=acdataIspace585BA2B83E754DABB50B10D8320CE414.GetQueryExpressionBindings("F197120E-AAA7-4885-94BF-CD708A09CE9F");
iSpace.SetGridData(resultD840F8CC40764F70BB276BC03624E86F,resultF197120EAAA7488594BFCD708A09CE9F,"Budgetdetails",ref ISpace);
iSpace.UpdateGridBindDetails("Budgetdetails",resultF197120EAAA7488594BFCD708A09CE9F);
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mf_projectcommitments_lastbutton (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MF_ProjectCommitments_LastButton-OnClick");
ISpace["MF_Budgetdetails_PageIndex"].Value=0;
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PageIndex""].Value=0;");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 0,'#F_BudgetHeadId','',#MF_Budgetdetails_PageIndex,'#MF_Budgetdetails_GridRows','#F_ProjectDetailsId'");

var querySource05309A85D55C43B8A687C2A189F723E7 =GetQueryExpressionDataSource("05309A85-D55C-43B8-A687-C2A189F723E7");
Dictionary<short,object> result05309A85D55C43B8A687C2A189F723E7=iSpace.ExecuteQuery(querySource05309A85D55C43B8A687C2A189F723E7,@"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 0,'" + ISpace["F_BudgetHeadId"].Value + @"',''," + ISpace["MF_Budgetdetails_PageIndex"].Value + @",'" + ISpace["MF_Budgetdetails_GridRows"].Value + @"','" + ISpace["F_ProjectDetailsId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource05309A85D55C43B8A687C2A189F723E7 =GetQueryExpressionDataSource(""05309A85-D55C-43B8-A687-C2A189F723E7"");Dictionary<short,object> result05309A85D55C43B8A687C2A189F723E7=iSpace.ExecuteQuery(querySource05309A85D55C43B8A687C2A189F723E7,@""EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 0,'"" + ISpace[""F_BudgetHeadId""].Value + @""','',"" + ISpace[""MF_Budgetdetails_PageIndex""].Value + @"",'"" + ISpace[""MF_Budgetdetails_GridRows""].Value + @""','"" + ISpace[""F_ProjectDetailsId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result05309A85D55C43B8A687C2A189F723E7!=null) && (result05309A85D55C43B8A687C2A189F723E7.Count!=0))
{
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(0))
ISpace["MF_ProjectCommitments_GridRows"].Value = result05309A85D55C43B8A687C2A189F723E7[0];
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(3))
ISpace["MF_ProjectCommitments_TotalPages"].Value = result05309A85D55C43B8A687C2A189F723E7[3];
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(2))
ISpace["MF_ProjectCommitments_PageIndex"].Value = result05309A85D55C43B8A687C2A189F723E7[2];
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(1))
ISpace["MF_ProjectCommitments_RecordsRange"].Value = result05309A85D55C43B8A687C2A189F723E7[1];
}
else{
ISpace["MF_ProjectCommitments_GridRows"].Value = null;ISpace["MF_ProjectCommitments_TotalPages"].Value = null;ISpace["MF_ProjectCommitments_PageIndex"].Value = null;ISpace["MF_ProjectCommitments_RecordsRange"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_Budgetdetails_PageIndex"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""MF_Budgetdetails_PageIndex""].Value==1)");
if(ISpace["MF_Budgetdetails_PageIndex"].Value==ISpace["MF_Budgetdetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_Budgetdetails_PageIndex""].Value==ISpace[""MF_Budgetdetails_TotalPages""].Value)");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="false";ISpace["MF_ProjectCommitments_LastButton"].Enbl="false";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="false";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="false";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""false"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="true";ISpace["MF_ProjectCommitments_LastButton"].Enbl="true";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="false";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="false";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""true"";");
}
}
else
{
base.WriteDebugInfo(@"else");
if(ISpace["MF_Budgetdetails_PageIndex"].Value==ISpace["MF_Budgetdetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_Budgetdetails_PageIndex""].Value==ISpace[""MF_Budgetdetails_TotalPages""].Value)");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="false";ISpace["MF_ProjectCommitments_LastButton"].Enbl="false";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="true";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="true";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="true";ISpace["MF_ProjectCommitments_LastButton"].Enbl="true";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="true";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="true";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""true"";");
}
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySource01000C9CF4F74DAA8E0E4E2ACF3299FF =GetQueryExpressionDataSource("01000C9C-F4F7-4DAA-8E0E-4E2ACF3299FF");

DataTable result01000C9CF4F74DAA8E0E4E2ACF3299FF=iSpace.SetGridDataSource(querySource01000C9CF4F74DAA8E0E4E2ACF3299FF, _objectFactory.GetGridRPP("ProjectCommitments"),@"EXEC dbo.[Get_e046fb44-e1f1-4f2a-a07e-231e72f92166_FilterData] 1,'" + ISpace["F_ProjectDetailsId"].Value + @"',''," + ISpace["MF_ProjectCommitments_PageIndex"].Value + @",'" + ISpace["MF_ProjectCommitments_GridRows"].Value + @"'");

iSpace.InsertGridBindDetails("ProjectCommitments","11",querySource01000C9CF4F74DAA8E0E4E2ACF3299FF,"EXEC dbo.[Get_e046fb44-e1f1-4f2a-a07e-231e72f92166_FilterData] 1,'" + ISpace["F_ProjectDetailsId"].Value + @"',''," + ISpace["MF_ProjectCommitments_PageIndex"].Value + @",'" + ISpace["MF_ProjectCommitments_GridRows"].Value + @"'",_objectFactory.GetGridRPP("ProjectCommitments"));

base.WriteDebugInfo(@"var querySource01000C9CF4F74DAA8E0E4E2ACF3299FF =GetQueryExpressionDataSource(""01000C9C-F4F7-4DAA-8E0E-4E2ACF3299FF"");DataTable result01000C9CF4F74DAA8E0E4E2ACF3299FF=iSpace.SetGridDataSource(querySource01000C9CF4F74DAA8E0E4E2ACF3299FF, _objectFactory.GetGridRPP(""ProjectCommitments""),@""EXEC dbo.[Get_e046fb44-e1f1-4f2a-a07e-231e72f92166_FilterData] 1,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',"" + ISpace[""MF_ProjectCommitments_PageIndex""].Value + @"",'"" + ISpace[""MF_ProjectCommitments_GridRows""].Value + @""'"");iSpace.InsertGridBindDetails(""ProjectCommitments"",""11"",querySource01000C9CF4F74DAA8E0E4E2ACF3299FF,""EXEC dbo.[Get_e046fb44-e1f1-4f2a-a07e-231e72f92166_FilterData] 1,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',"" + ISpace[""MF_ProjectCommitments_PageIndex""].Value + @"",'"" + ISpace[""MF_ProjectCommitments_GridRows""].Value + @""'"",_objectFactory.GetGridRPP(""ProjectCommitments""));");
base.WriteDebugInfo(@"EXEC dbo.[Get_e046fb44-e1f1-4f2a-a07e-231e72f92166_FilterData] 1,'#F_ProjectDetailsId','',#MF_ProjectCommitments_PageIndex,'#MF_ProjectCommitments_GridRows'");


List<Triplet<string, short, short?>> result34DD54DC0E5B46EAA0BBD99E022B7345=acdataIspace585BA2B83E754DABB50B10D8320CE414.GetQueryExpressionBindings("34DD54DC-0E5B-46EA-A0BB-D99E022B7345");
iSpace.SetGridData(result01000C9CF4F74DAA8E0E4E2ACF3299FF,result34DD54DC0E5B46EAA0BBD99E022B7345,"ProjectCommitments",ref ISpace);
iSpace.UpdateGridBindDetails("ProjectCommitments",result34DD54DC0E5B46EAA0BBD99E022B7345);
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_cancel (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Cancel-OnClick");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["FormVersionId"].Value=="F7DA2CD7-1723-45E3-94F5-6380EB2F0989")
{
ISpace["UI_Panel"].Visible="true";ISpace["UI_Panel"].Enbl="true";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""F7DA2CD7-1723-45E3-94F5-6380EB2F0989"")
{
ISpace[""UI_Panel""].Visible=""true"";ISpace[""UI_Panel""].Enbl=""true"";
}");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["FormVersionId"].Value=="F7DA2CD7-1723-45E3-94F5-6380EB2F0989")
{
ISpace["UI_Panel"].Visible="true";ISpace["UI_Panel"].Enbl="true";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""F7DA2CD7-1723-45E3-94F5-6380EB2F0989"")
{
ISpace[""UI_Panel""].Visible=""true"";ISpace[""UI_Panel""].Enbl=""true"";
}");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["FormVersionId"].Value=="F7DA2CD7-1723-45E3-94F5-6380EB2F0989")
{
ISpace["UI_Panel"].Visible="true";ISpace["UI_Panel"].Enbl="true";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""F7DA2CD7-1723-45E3-94F5-6380EB2F0989"")
{
ISpace[""UI_Panel""].Visible=""true"";ISpace[""UI_Panel""].Enbl=""true"";
}");
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mf_projectcommitments_gridrows (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MF_ProjectCommitments_GridRows-OnChange");
ISpace["MF_Option"].Value=1;
base.WriteDebugInfo(@"ISpace[""MF_Option""].Value=1;");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 0,'#F_BudgetHeadId','',#MF_Budgetdetails_PageIndex,'#MF_Budgetdetails_GridRows','#F_ProjectDetailsId'");

var querySource05309A85D55C43B8A687C2A189F723E7 =GetQueryExpressionDataSource("05309A85-D55C-43B8-A687-C2A189F723E7");
Dictionary<short,object> result05309A85D55C43B8A687C2A189F723E7=iSpace.ExecuteQuery(querySource05309A85D55C43B8A687C2A189F723E7,@"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 0,'" + ISpace["F_BudgetHeadId"].Value + @"',''," + ISpace["MF_Budgetdetails_PageIndex"].Value + @",'" + ISpace["MF_Budgetdetails_GridRows"].Value + @"','" + ISpace["F_ProjectDetailsId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource05309A85D55C43B8A687C2A189F723E7 =GetQueryExpressionDataSource(""05309A85-D55C-43B8-A687-C2A189F723E7"");Dictionary<short,object> result05309A85D55C43B8A687C2A189F723E7=iSpace.ExecuteQuery(querySource05309A85D55C43B8A687C2A189F723E7,@""EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 0,'"" + ISpace[""F_BudgetHeadId""].Value + @""','',"" + ISpace[""MF_Budgetdetails_PageIndex""].Value + @"",'"" + ISpace[""MF_Budgetdetails_GridRows""].Value + @""','"" + ISpace[""F_ProjectDetailsId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result05309A85D55C43B8A687C2A189F723E7!=null) && (result05309A85D55C43B8A687C2A189F723E7.Count!=0))
{
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(0))
ISpace["MF_ProjectCommitments_GridRows"].Value = result05309A85D55C43B8A687C2A189F723E7[0];
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(3))
ISpace["MF_ProjectCommitments_TotalPages"].Value = result05309A85D55C43B8A687C2A189F723E7[3];
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(2))
ISpace["MF_ProjectCommitments_PageIndex"].Value = result05309A85D55C43B8A687C2A189F723E7[2];
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(1))
ISpace["MF_ProjectCommitments_RecordsRange"].Value = result05309A85D55C43B8A687C2A189F723E7[1];
}
else{
ISpace["MF_ProjectCommitments_GridRows"].Value = null;ISpace["MF_ProjectCommitments_TotalPages"].Value = null;ISpace["MF_ProjectCommitments_PageIndex"].Value = null;ISpace["MF_ProjectCommitments_RecordsRange"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_Budgetdetails_PageIndex"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""MF_Budgetdetails_PageIndex""].Value==1)");
if(ISpace["MF_Budgetdetails_PageIndex"].Value==ISpace["MF_Budgetdetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_Budgetdetails_PageIndex""].Value==ISpace[""MF_Budgetdetails_TotalPages""].Value)");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="false";ISpace["MF_ProjectCommitments_LastButton"].Enbl="false";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="false";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="false";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""false"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="true";ISpace["MF_ProjectCommitments_LastButton"].Enbl="true";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="false";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="false";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""true"";");
}
}
else
{
base.WriteDebugInfo(@"else");
if(ISpace["MF_Budgetdetails_PageIndex"].Value==ISpace["MF_Budgetdetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_Budgetdetails_PageIndex""].Value==ISpace[""MF_Budgetdetails_TotalPages""].Value)");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="false";ISpace["MF_ProjectCommitments_LastButton"].Enbl="false";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="true";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="true";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="true";ISpace["MF_ProjectCommitments_LastButton"].Enbl="true";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="true";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="true";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""true"";");
}
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySource01000C9CF4F74DAA8E0E4E2ACF3299FF =GetQueryExpressionDataSource("01000C9C-F4F7-4DAA-8E0E-4E2ACF3299FF");

DataTable result01000C9CF4F74DAA8E0E4E2ACF3299FF=iSpace.SetGridDataSource(querySource01000C9CF4F74DAA8E0E4E2ACF3299FF, _objectFactory.GetGridRPP("ProjectCommitments"),@"EXEC dbo.[Get_e046fb44-e1f1-4f2a-a07e-231e72f92166_FilterData] 1,'" + ISpace["F_ProjectDetailsId"].Value + @"',''," + ISpace["MF_ProjectCommitments_PageIndex"].Value + @",'" + ISpace["MF_ProjectCommitments_GridRows"].Value + @"'");

iSpace.InsertGridBindDetails("ProjectCommitments","11",querySource01000C9CF4F74DAA8E0E4E2ACF3299FF,"EXEC dbo.[Get_e046fb44-e1f1-4f2a-a07e-231e72f92166_FilterData] 1,'" + ISpace["F_ProjectDetailsId"].Value + @"',''," + ISpace["MF_ProjectCommitments_PageIndex"].Value + @",'" + ISpace["MF_ProjectCommitments_GridRows"].Value + @"'",_objectFactory.GetGridRPP("ProjectCommitments"));

base.WriteDebugInfo(@"var querySource01000C9CF4F74DAA8E0E4E2ACF3299FF =GetQueryExpressionDataSource(""01000C9C-F4F7-4DAA-8E0E-4E2ACF3299FF"");DataTable result01000C9CF4F74DAA8E0E4E2ACF3299FF=iSpace.SetGridDataSource(querySource01000C9CF4F74DAA8E0E4E2ACF3299FF, _objectFactory.GetGridRPP(""ProjectCommitments""),@""EXEC dbo.[Get_e046fb44-e1f1-4f2a-a07e-231e72f92166_FilterData] 1,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',"" + ISpace[""MF_ProjectCommitments_PageIndex""].Value + @"",'"" + ISpace[""MF_ProjectCommitments_GridRows""].Value + @""'"");iSpace.InsertGridBindDetails(""ProjectCommitments"",""11"",querySource01000C9CF4F74DAA8E0E4E2ACF3299FF,""EXEC dbo.[Get_e046fb44-e1f1-4f2a-a07e-231e72f92166_FilterData] 1,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',"" + ISpace[""MF_ProjectCommitments_PageIndex""].Value + @"",'"" + ISpace[""MF_ProjectCommitments_GridRows""].Value + @""'"",_objectFactory.GetGridRPP(""ProjectCommitments""));");
base.WriteDebugInfo(@"EXEC dbo.[Get_e046fb44-e1f1-4f2a-a07e-231e72f92166_FilterData] 1,'#F_ProjectDetailsId','',#MF_ProjectCommitments_PageIndex,'#MF_ProjectCommitments_GridRows'");


List<Triplet<string, short, short?>> result34DD54DC0E5B46EAA0BBD99E022B7345=acdataIspace585BA2B83E754DABB50B10D8320CE414.GetQueryExpressionBindings("34DD54DC-0E5B-46EA-A0BB-D99E022B7345");
iSpace.SetGridData(result01000C9CF4F74DAA8E0E4E2ACF3299FF,result34DD54DC0E5B46EAA0BBD99E022B7345,"ProjectCommitments",ref ISpace);
iSpace.UpdateGridBindDetails("ProjectCommitments",result34DD54DC0E5B46EAA0BBD99E022B7345);
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mf_receiptsview_nextbutton (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MF_ReceiptsView_NextButton-OnClick");
if(ISpace["MF_Budgetdetails_PageIndex"].Value>0)
{
base.WriteDebugInfo(@"if(ISpace[""MF_Budgetdetails_PageIndex""].Value>0)");
ISpace["MF_Budgetdetails_PageIndex"].Value=ISpace["MF_Budgetdetails_PageIndex"].Value+1;
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PageIndex""].Value=ISpace[""MF_Budgetdetails_PageIndex""].Value+1;");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_Budgetdetails_PageIndex"].Value=1;
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PageIndex""].Value=1;");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 0,'#F_BudgetHeadId','',#MF_Budgetdetails_PageIndex,'#MF_Budgetdetails_GridRows','#F_ProjectDetailsId'");

var querySource05309A85D55C43B8A687C2A189F723E7 =GetQueryExpressionDataSource("05309A85-D55C-43B8-A687-C2A189F723E7");
Dictionary<short,object> result05309A85D55C43B8A687C2A189F723E7=iSpace.ExecuteQuery(querySource05309A85D55C43B8A687C2A189F723E7,@"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 0,'" + ISpace["F_BudgetHeadId"].Value + @"',''," + ISpace["MF_Budgetdetails_PageIndex"].Value + @",'" + ISpace["MF_Budgetdetails_GridRows"].Value + @"','" + ISpace["F_ProjectDetailsId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource05309A85D55C43B8A687C2A189F723E7 =GetQueryExpressionDataSource(""05309A85-D55C-43B8-A687-C2A189F723E7"");Dictionary<short,object> result05309A85D55C43B8A687C2A189F723E7=iSpace.ExecuteQuery(querySource05309A85D55C43B8A687C2A189F723E7,@""EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 0,'"" + ISpace[""F_BudgetHeadId""].Value + @""','',"" + ISpace[""MF_Budgetdetails_PageIndex""].Value + @"",'"" + ISpace[""MF_Budgetdetails_GridRows""].Value + @""','"" + ISpace[""F_ProjectDetailsId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result05309A85D55C43B8A687C2A189F723E7!=null) && (result05309A85D55C43B8A687C2A189F723E7.Count!=0))
{
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(0))
ISpace["MF_ProjectCommitments_GridRows"].Value = result05309A85D55C43B8A687C2A189F723E7[0];
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(3))
ISpace["MF_ProjectCommitments_TotalPages"].Value = result05309A85D55C43B8A687C2A189F723E7[3];
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(2))
ISpace["MF_ProjectCommitments_PageIndex"].Value = result05309A85D55C43B8A687C2A189F723E7[2];
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(1))
ISpace["MF_ProjectCommitments_RecordsRange"].Value = result05309A85D55C43B8A687C2A189F723E7[1];
}
else{
ISpace["MF_ProjectCommitments_GridRows"].Value = null;ISpace["MF_ProjectCommitments_TotalPages"].Value = null;ISpace["MF_ProjectCommitments_PageIndex"].Value = null;ISpace["MF_ProjectCommitments_RecordsRange"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_Budgetdetails_PageIndex"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""MF_Budgetdetails_PageIndex""].Value==1)");
if(ISpace["MF_Budgetdetails_PageIndex"].Value==ISpace["MF_Budgetdetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_Budgetdetails_PageIndex""].Value==ISpace[""MF_Budgetdetails_TotalPages""].Value)");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="false";ISpace["MF_ProjectCommitments_LastButton"].Enbl="false";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="false";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="false";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""false"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="true";ISpace["MF_ProjectCommitments_LastButton"].Enbl="true";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="false";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="false";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""true"";");
}
}
else
{
base.WriteDebugInfo(@"else");
if(ISpace["MF_Budgetdetails_PageIndex"].Value==ISpace["MF_Budgetdetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_Budgetdetails_PageIndex""].Value==ISpace[""MF_Budgetdetails_TotalPages""].Value)");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="false";ISpace["MF_ProjectCommitments_LastButton"].Enbl="false";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="true";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="true";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="true";ISpace["MF_ProjectCommitments_LastButton"].Enbl="true";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="true";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="true";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""true"";");
}
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySource24686D701FFF4F4F81D7EE238FD68AC3 =GetQueryExpressionDataSource("24686D70-1FFF-4F4F-81D7-EE238FD68AC3");

DataTable result24686D701FFF4F4F81D7EE238FD68AC3=iSpace.SetGridDataSource(querySource24686D701FFF4F4F81D7EE238FD68AC3, _objectFactory.GetGridRPP("ReceiptsView"),@"EXEC dbo.[Get_bd3abae8-b5a2-4b71-b3e2-e46732479592_FilterData] 1,'" + ISpace["F_ReceiptNo"].Value + @"',''," + ISpace["MF_ReceiptsView_PageIndex"].Value + @",'" + ISpace["MF_ReceiptsView_GridRows"].Value + @"','" + ISpace["F_ProjectDetailsID"].Value + @"'");

iSpace.InsertGridBindDetails("ReceiptsView","11",querySource24686D701FFF4F4F81D7EE238FD68AC3,"EXEC dbo.[Get_bd3abae8-b5a2-4b71-b3e2-e46732479592_FilterData] 1,'" + ISpace["F_ReceiptNo"].Value + @"',''," + ISpace["MF_ReceiptsView_PageIndex"].Value + @",'" + ISpace["MF_ReceiptsView_GridRows"].Value + @"','" + ISpace["F_ProjectDetailsID"].Value + @"'",_objectFactory.GetGridRPP("ReceiptsView"));

base.WriteDebugInfo(@"var querySource24686D701FFF4F4F81D7EE238FD68AC3 =GetQueryExpressionDataSource(""24686D70-1FFF-4F4F-81D7-EE238FD68AC3"");DataTable result24686D701FFF4F4F81D7EE238FD68AC3=iSpace.SetGridDataSource(querySource24686D701FFF4F4F81D7EE238FD68AC3, _objectFactory.GetGridRPP(""ReceiptsView""),@""EXEC dbo.[Get_bd3abae8-b5a2-4b71-b3e2-e46732479592_FilterData] 1,'"" + ISpace[""F_ReceiptNo""].Value + @""','',"" + ISpace[""MF_ReceiptsView_PageIndex""].Value + @"",'"" + ISpace[""MF_ReceiptsView_GridRows""].Value + @""','"" + ISpace[""F_ProjectDetailsID""].Value + @""'"");iSpace.InsertGridBindDetails(""ReceiptsView"",""11"",querySource24686D701FFF4F4F81D7EE238FD68AC3,""EXEC dbo.[Get_bd3abae8-b5a2-4b71-b3e2-e46732479592_FilterData] 1,'"" + ISpace[""F_ReceiptNo""].Value + @""','',"" + ISpace[""MF_ReceiptsView_PageIndex""].Value + @"",'"" + ISpace[""MF_ReceiptsView_GridRows""].Value + @""','"" + ISpace[""F_ProjectDetailsID""].Value + @""'"",_objectFactory.GetGridRPP(""ReceiptsView""));");
base.WriteDebugInfo(@"EXEC dbo.[Get_bd3abae8-b5a2-4b71-b3e2-e46732479592_FilterData] 1,'#F_ReceiptNo','',#MF_ReceiptsView_PageIndex,'#MF_ReceiptsView_GridRows'");


List<Triplet<string, short, short?>> result3E6384212EC24473A32F5167327104C5=acdataIspace585BA2B83E754DABB50B10D8320CE414.GetQueryExpressionBindings("3E638421-2EC2-4473-A32F-5167327104C5");
iSpace.SetGridData(result24686D701FFF4F4F81D7EE238FD68AC3,result3E6384212EC24473A32F5167327104C5,"ReceiptsView",ref ISpace);
iSpace.UpdateGridBindDetails("ReceiptsView",result3E6384212EC24473A32F5167327104C5);
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mf_receiptsview_lastbutton (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MF_ReceiptsView_LastButton-OnClick");
ISpace["MF_Budgetdetails_PageIndex"].Value=0;
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PageIndex""].Value=0;");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 0,'#F_BudgetHeadId','',#MF_Budgetdetails_PageIndex,'#MF_Budgetdetails_GridRows','#F_ProjectDetailsId'");

var querySource05309A85D55C43B8A687C2A189F723E7 =GetQueryExpressionDataSource("05309A85-D55C-43B8-A687-C2A189F723E7");
Dictionary<short,object> result05309A85D55C43B8A687C2A189F723E7=iSpace.ExecuteQuery(querySource05309A85D55C43B8A687C2A189F723E7,@"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 0,'" + ISpace["F_BudgetHeadId"].Value + @"',''," + ISpace["MF_Budgetdetails_PageIndex"].Value + @",'" + ISpace["MF_Budgetdetails_GridRows"].Value + @"','" + ISpace["F_ProjectDetailsId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource05309A85D55C43B8A687C2A189F723E7 =GetQueryExpressionDataSource(""05309A85-D55C-43B8-A687-C2A189F723E7"");Dictionary<short,object> result05309A85D55C43B8A687C2A189F723E7=iSpace.ExecuteQuery(querySource05309A85D55C43B8A687C2A189F723E7,@""EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 0,'"" + ISpace[""F_BudgetHeadId""].Value + @""','',"" + ISpace[""MF_Budgetdetails_PageIndex""].Value + @"",'"" + ISpace[""MF_Budgetdetails_GridRows""].Value + @""','"" + ISpace[""F_ProjectDetailsId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result05309A85D55C43B8A687C2A189F723E7!=null) && (result05309A85D55C43B8A687C2A189F723E7.Count!=0))
{
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(0))
ISpace["MF_ProjectCommitments_GridRows"].Value = result05309A85D55C43B8A687C2A189F723E7[0];
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(3))
ISpace["MF_ProjectCommitments_TotalPages"].Value = result05309A85D55C43B8A687C2A189F723E7[3];
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(2))
ISpace["MF_ProjectCommitments_PageIndex"].Value = result05309A85D55C43B8A687C2A189F723E7[2];
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(1))
ISpace["MF_ProjectCommitments_RecordsRange"].Value = result05309A85D55C43B8A687C2A189F723E7[1];
}
else{
ISpace["MF_ProjectCommitments_GridRows"].Value = null;ISpace["MF_ProjectCommitments_TotalPages"].Value = null;ISpace["MF_ProjectCommitments_PageIndex"].Value = null;ISpace["MF_ProjectCommitments_RecordsRange"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_Budgetdetails_PageIndex"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""MF_Budgetdetails_PageIndex""].Value==1)");
if(ISpace["MF_Budgetdetails_PageIndex"].Value==ISpace["MF_Budgetdetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_Budgetdetails_PageIndex""].Value==ISpace[""MF_Budgetdetails_TotalPages""].Value)");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="false";ISpace["MF_ProjectCommitments_LastButton"].Enbl="false";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="false";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="false";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""false"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="true";ISpace["MF_ProjectCommitments_LastButton"].Enbl="true";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="false";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="false";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""true"";");
}
}
else
{
base.WriteDebugInfo(@"else");
if(ISpace["MF_Budgetdetails_PageIndex"].Value==ISpace["MF_Budgetdetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_Budgetdetails_PageIndex""].Value==ISpace[""MF_Budgetdetails_TotalPages""].Value)");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="false";ISpace["MF_ProjectCommitments_LastButton"].Enbl="false";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="true";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="true";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="true";ISpace["MF_ProjectCommitments_LastButton"].Enbl="true";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="true";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="true";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""true"";");
}
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySource24686D701FFF4F4F81D7EE238FD68AC3 =GetQueryExpressionDataSource("24686D70-1FFF-4F4F-81D7-EE238FD68AC3");

DataTable result24686D701FFF4F4F81D7EE238FD68AC3=iSpace.SetGridDataSource(querySource24686D701FFF4F4F81D7EE238FD68AC3, _objectFactory.GetGridRPP("ReceiptsView"),@"EXEC dbo.[Get_bd3abae8-b5a2-4b71-b3e2-e46732479592_FilterData] 1,'" + ISpace["F_ReceiptNo"].Value + @"',''," + ISpace["MF_ReceiptsView_PageIndex"].Value + @",'" + ISpace["MF_ReceiptsView_GridRows"].Value + @"','" + ISpace["F_ProjectDetailsID"].Value + @"'");

iSpace.InsertGridBindDetails("ReceiptsView","11",querySource24686D701FFF4F4F81D7EE238FD68AC3,"EXEC dbo.[Get_bd3abae8-b5a2-4b71-b3e2-e46732479592_FilterData] 1,'" + ISpace["F_ReceiptNo"].Value + @"',''," + ISpace["MF_ReceiptsView_PageIndex"].Value + @",'" + ISpace["MF_ReceiptsView_GridRows"].Value + @"','" + ISpace["F_ProjectDetailsID"].Value + @"'",_objectFactory.GetGridRPP("ReceiptsView"));

base.WriteDebugInfo(@"var querySource24686D701FFF4F4F81D7EE238FD68AC3 =GetQueryExpressionDataSource(""24686D70-1FFF-4F4F-81D7-EE238FD68AC3"");DataTable result24686D701FFF4F4F81D7EE238FD68AC3=iSpace.SetGridDataSource(querySource24686D701FFF4F4F81D7EE238FD68AC3, _objectFactory.GetGridRPP(""ReceiptsView""),@""EXEC dbo.[Get_bd3abae8-b5a2-4b71-b3e2-e46732479592_FilterData] 1,'"" + ISpace[""F_ReceiptNo""].Value + @""','',"" + ISpace[""MF_ReceiptsView_PageIndex""].Value + @"",'"" + ISpace[""MF_ReceiptsView_GridRows""].Value + @""','"" + ISpace[""F_ProjectDetailsID""].Value + @""'"");iSpace.InsertGridBindDetails(""ReceiptsView"",""11"",querySource24686D701FFF4F4F81D7EE238FD68AC3,""EXEC dbo.[Get_bd3abae8-b5a2-4b71-b3e2-e46732479592_FilterData] 1,'"" + ISpace[""F_ReceiptNo""].Value + @""','',"" + ISpace[""MF_ReceiptsView_PageIndex""].Value + @"",'"" + ISpace[""MF_ReceiptsView_GridRows""].Value + @""','"" + ISpace[""F_ProjectDetailsID""].Value + @""'"",_objectFactory.GetGridRPP(""ReceiptsView""));");
base.WriteDebugInfo(@"EXEC dbo.[Get_bd3abae8-b5a2-4b71-b3e2-e46732479592_FilterData] 1,'#F_ReceiptNo','',#MF_ReceiptsView_PageIndex,'#MF_ReceiptsView_GridRows'");


List<Triplet<string, short, short?>> result3E6384212EC24473A32F5167327104C5=acdataIspace585BA2B83E754DABB50B10D8320CE414.GetQueryExpressionBindings("3E638421-2EC2-4473-A32F-5167327104C5");
iSpace.SetGridData(result24686D701FFF4F4F81D7EE238FD68AC3,result3E6384212EC24473A32F5167327104C5,"ReceiptsView",ref ISpace);
iSpace.UpdateGridBindDetails("ReceiptsView",result3E6384212EC24473A32F5167327104C5);
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mf_budgetdetails_prevbutton (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MF_Budgetdetails_PrevButton-OnClick");
if(ISpace["MF_Budgetdetails_PageIndex"].Value>2)
{
base.WriteDebugInfo(@"if(ISpace[""MF_Budgetdetails_PageIndex""].Value>2)");
ISpace["MF_Budgetdetails_PageIndex"].Value=ISpace["MF_Budgetdetails_PageIndex"].Value-1;
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PageIndex""].Value=ISpace[""MF_Budgetdetails_PageIndex""].Value-1;");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_Budgetdetails_PageIndex"].Value=1;
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PageIndex""].Value=1;");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 0,'#F_BudgetHeadId','',#MF_Budgetdetails_PageIndex,'#MF_Budgetdetails_GridRows','#F_ProjectDetailsId'");

var querySource05309A85D55C43B8A687C2A189F723E7 =GetQueryExpressionDataSource("05309A85-D55C-43B8-A687-C2A189F723E7");
Dictionary<short,object> result05309A85D55C43B8A687C2A189F723E7=iSpace.ExecuteQuery(querySource05309A85D55C43B8A687C2A189F723E7,@"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 0,'" + ISpace["F_BudgetHeadId"].Value + @"',''," + ISpace["MF_Budgetdetails_PageIndex"].Value + @",'" + ISpace["MF_Budgetdetails_GridRows"].Value + @"','" + ISpace["F_ProjectDetailsId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource05309A85D55C43B8A687C2A189F723E7 =GetQueryExpressionDataSource(""05309A85-D55C-43B8-A687-C2A189F723E7"");Dictionary<short,object> result05309A85D55C43B8A687C2A189F723E7=iSpace.ExecuteQuery(querySource05309A85D55C43B8A687C2A189F723E7,@""EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 0,'"" + ISpace[""F_BudgetHeadId""].Value + @""','',"" + ISpace[""MF_Budgetdetails_PageIndex""].Value + @"",'"" + ISpace[""MF_Budgetdetails_GridRows""].Value + @""','"" + ISpace[""F_ProjectDetailsId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result05309A85D55C43B8A687C2A189F723E7!=null) && (result05309A85D55C43B8A687C2A189F723E7.Count!=0))
{
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(0))
ISpace["MF_ProjectCommitments_GridRows"].Value = result05309A85D55C43B8A687C2A189F723E7[0];
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(3))
ISpace["MF_ProjectCommitments_TotalPages"].Value = result05309A85D55C43B8A687C2A189F723E7[3];
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(2))
ISpace["MF_ProjectCommitments_PageIndex"].Value = result05309A85D55C43B8A687C2A189F723E7[2];
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(1))
ISpace["MF_ProjectCommitments_RecordsRange"].Value = result05309A85D55C43B8A687C2A189F723E7[1];
}
else{
ISpace["MF_ProjectCommitments_GridRows"].Value = null;ISpace["MF_ProjectCommitments_TotalPages"].Value = null;ISpace["MF_ProjectCommitments_PageIndex"].Value = null;ISpace["MF_ProjectCommitments_RecordsRange"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_Budgetdetails_PageIndex"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""MF_Budgetdetails_PageIndex""].Value==1)");
if(ISpace["MF_Budgetdetails_PageIndex"].Value==ISpace["MF_Budgetdetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_Budgetdetails_PageIndex""].Value==ISpace[""MF_Budgetdetails_TotalPages""].Value)");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="false";ISpace["MF_ProjectCommitments_LastButton"].Enbl="false";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="false";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="false";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""false"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="true";ISpace["MF_ProjectCommitments_LastButton"].Enbl="true";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="false";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="false";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""true"";");
}
}
else
{
base.WriteDebugInfo(@"else");
if(ISpace["MF_Budgetdetails_PageIndex"].Value==ISpace["MF_Budgetdetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_Budgetdetails_PageIndex""].Value==ISpace[""MF_Budgetdetails_TotalPages""].Value)");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="false";ISpace["MF_ProjectCommitments_LastButton"].Enbl="false";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="true";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="true";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="true";ISpace["MF_ProjectCommitments_LastButton"].Enbl="true";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="true";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="true";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""true"";");
}
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySourceD840F8CC40764F70BB276BC03624E86F =GetQueryExpressionDataSource("D840F8CC-4076-4F70-BB27-6BC03624E86F");

DataTable resultD840F8CC40764F70BB276BC03624E86F=iSpace.SetGridDataSource(querySourceD840F8CC40764F70BB276BC03624E86F, _objectFactory.GetGridRPP("Budgetdetails"),@"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 1,'" + ISpace["F_BudgetHeadId"].Value + @"',''," + ISpace["MF_Budgetdetails_PageIndex"].Value + @",'" + ISpace["MF_Budgetdetails_GridRows"].Value + @"','" + ISpace["F_ProjectDetailsId"].Value + @"'");

iSpace.InsertGridBindDetails("Budgetdetails","11",querySourceD840F8CC40764F70BB276BC03624E86F,"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 1,'" + ISpace["F_BudgetHeadId"].Value + @"',''," + ISpace["MF_Budgetdetails_PageIndex"].Value + @",'" + ISpace["MF_Budgetdetails_GridRows"].Value + @"','" + ISpace["F_ProjectDetailsId"].Value + @"'",_objectFactory.GetGridRPP("Budgetdetails"));

base.WriteDebugInfo(@"var querySourceD840F8CC40764F70BB276BC03624E86F =GetQueryExpressionDataSource(""D840F8CC-4076-4F70-BB27-6BC03624E86F"");DataTable resultD840F8CC40764F70BB276BC03624E86F=iSpace.SetGridDataSource(querySourceD840F8CC40764F70BB276BC03624E86F, _objectFactory.GetGridRPP(""Budgetdetails""),@""EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 1,'"" + ISpace[""F_BudgetHeadId""].Value + @""','',"" + ISpace[""MF_Budgetdetails_PageIndex""].Value + @"",'"" + ISpace[""MF_Budgetdetails_GridRows""].Value + @""','"" + ISpace[""F_ProjectDetailsId""].Value + @""'"");iSpace.InsertGridBindDetails(""Budgetdetails"",""11"",querySourceD840F8CC40764F70BB276BC03624E86F,""EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 1,'"" + ISpace[""F_BudgetHeadId""].Value + @""','',"" + ISpace[""MF_Budgetdetails_PageIndex""].Value + @"",'"" + ISpace[""MF_Budgetdetails_GridRows""].Value + @""','"" + ISpace[""F_ProjectDetailsId""].Value + @""'"",_objectFactory.GetGridRPP(""Budgetdetails""));");
base.WriteDebugInfo(@"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 1,'#F_BudgetHeadId','',#MF_Budgetdetails_PageIndex,'#MF_Budgetdetails_GridRows'");


List<Triplet<string, short, short?>> resultF197120EAAA7488594BFCD708A09CE9F=acdataIspace585BA2B83E754DABB50B10D8320CE414.GetQueryExpressionBindings("F197120E-AAA7-4885-94BF-CD708A09CE9F");
iSpace.SetGridData(resultD840F8CC40764F70BB276BC03624E86F,resultF197120EAAA7488594BFCD708A09CE9F,"Budgetdetails",ref ISpace);
iSpace.UpdateGridBindDetails("Budgetdetails",resultF197120EAAA7488594BFCD708A09CE9F);
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mf_budgetdetails_gridrows (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MF_Budgetdetails_GridRows-OnChange");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 0,'#F_BudgetHeadId','',#MF_Budgetdetails_PageIndex,'#MF_Budgetdetails_GridRows','#F_ProjectDetailsId'");

var querySource05309A85D55C43B8A687C2A189F723E7 =GetQueryExpressionDataSource("05309A85-D55C-43B8-A687-C2A189F723E7");
Dictionary<short,object> result05309A85D55C43B8A687C2A189F723E7=iSpace.ExecuteQuery(querySource05309A85D55C43B8A687C2A189F723E7,@"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 0,'" + ISpace["F_BudgetHeadId"].Value + @"',''," + ISpace["MF_Budgetdetails_PageIndex"].Value + @",'" + ISpace["MF_Budgetdetails_GridRows"].Value + @"','" + ISpace["F_ProjectDetailsId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource05309A85D55C43B8A687C2A189F723E7 =GetQueryExpressionDataSource(""05309A85-D55C-43B8-A687-C2A189F723E7"");Dictionary<short,object> result05309A85D55C43B8A687C2A189F723E7=iSpace.ExecuteQuery(querySource05309A85D55C43B8A687C2A189F723E7,@""EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 0,'"" + ISpace[""F_BudgetHeadId""].Value + @""','',"" + ISpace[""MF_Budgetdetails_PageIndex""].Value + @"",'"" + ISpace[""MF_Budgetdetails_GridRows""].Value + @""','"" + ISpace[""F_ProjectDetailsId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result05309A85D55C43B8A687C2A189F723E7!=null) && (result05309A85D55C43B8A687C2A189F723E7.Count!=0))
{
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(0))
ISpace["MF_ProjectCommitments_GridRows"].Value = result05309A85D55C43B8A687C2A189F723E7[0];
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(3))
ISpace["MF_ProjectCommitments_TotalPages"].Value = result05309A85D55C43B8A687C2A189F723E7[3];
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(2))
ISpace["MF_ProjectCommitments_PageIndex"].Value = result05309A85D55C43B8A687C2A189F723E7[2];
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(1))
ISpace["MF_ProjectCommitments_RecordsRange"].Value = result05309A85D55C43B8A687C2A189F723E7[1];
}
else{
ISpace["MF_ProjectCommitments_GridRows"].Value = null;ISpace["MF_ProjectCommitments_TotalPages"].Value = null;ISpace["MF_ProjectCommitments_PageIndex"].Value = null;ISpace["MF_ProjectCommitments_RecordsRange"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_Budgetdetails_PageIndex"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""MF_Budgetdetails_PageIndex""].Value==1)");
if(ISpace["MF_Budgetdetails_PageIndex"].Value==ISpace["MF_Budgetdetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_Budgetdetails_PageIndex""].Value==ISpace[""MF_Budgetdetails_TotalPages""].Value)");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="false";ISpace["MF_ProjectCommitments_LastButton"].Enbl="false";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="false";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="false";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""false"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="true";ISpace["MF_ProjectCommitments_LastButton"].Enbl="true";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="false";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="false";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""true"";");
}
}
else
{
base.WriteDebugInfo(@"else");
if(ISpace["MF_Budgetdetails_PageIndex"].Value==ISpace["MF_Budgetdetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_Budgetdetails_PageIndex""].Value==ISpace[""MF_Budgetdetails_TotalPages""].Value)");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="false";ISpace["MF_ProjectCommitments_LastButton"].Enbl="false";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="true";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="true";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="true";ISpace["MF_ProjectCommitments_LastButton"].Enbl="true";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="true";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="true";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""true"";");
}
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySourceD840F8CC40764F70BB276BC03624E86F =GetQueryExpressionDataSource("D840F8CC-4076-4F70-BB27-6BC03624E86F");

DataTable resultD840F8CC40764F70BB276BC03624E86F=iSpace.SetGridDataSource(querySourceD840F8CC40764F70BB276BC03624E86F, _objectFactory.GetGridRPP("Budgetdetails"),@"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 1,'" + ISpace["F_BudgetHeadId"].Value + @"',''," + ISpace["MF_Budgetdetails_PageIndex"].Value + @",'" + ISpace["MF_Budgetdetails_GridRows"].Value + @"','" + ISpace["F_ProjectDetailsId"].Value + @"'");

iSpace.InsertGridBindDetails("Budgetdetails","11",querySourceD840F8CC40764F70BB276BC03624E86F,"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 1,'" + ISpace["F_BudgetHeadId"].Value + @"',''," + ISpace["MF_Budgetdetails_PageIndex"].Value + @",'" + ISpace["MF_Budgetdetails_GridRows"].Value + @"','" + ISpace["F_ProjectDetailsId"].Value + @"'",_objectFactory.GetGridRPP("Budgetdetails"));

base.WriteDebugInfo(@"var querySourceD840F8CC40764F70BB276BC03624E86F =GetQueryExpressionDataSource(""D840F8CC-4076-4F70-BB27-6BC03624E86F"");DataTable resultD840F8CC40764F70BB276BC03624E86F=iSpace.SetGridDataSource(querySourceD840F8CC40764F70BB276BC03624E86F, _objectFactory.GetGridRPP(""Budgetdetails""),@""EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 1,'"" + ISpace[""F_BudgetHeadId""].Value + @""','',"" + ISpace[""MF_Budgetdetails_PageIndex""].Value + @"",'"" + ISpace[""MF_Budgetdetails_GridRows""].Value + @""','"" + ISpace[""F_ProjectDetailsId""].Value + @""'"");iSpace.InsertGridBindDetails(""Budgetdetails"",""11"",querySourceD840F8CC40764F70BB276BC03624E86F,""EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 1,'"" + ISpace[""F_BudgetHeadId""].Value + @""','',"" + ISpace[""MF_Budgetdetails_PageIndex""].Value + @"",'"" + ISpace[""MF_Budgetdetails_GridRows""].Value + @""','"" + ISpace[""F_ProjectDetailsId""].Value + @""'"",_objectFactory.GetGridRPP(""Budgetdetails""));");
base.WriteDebugInfo(@"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 1,'#F_BudgetHeadId','',#MF_Budgetdetails_PageIndex,'#MF_Budgetdetails_GridRows'");


List<Triplet<string, short, short?>> resultF197120EAAA7488594BFCD708A09CE9F=acdataIspace585BA2B83E754DABB50B10D8320CE414.GetQueryExpressionBindings("F197120E-AAA7-4885-94BF-CD708A09CE9F");
iSpace.SetGridData(resultD840F8CC40764F70BB276BC03624E86F,resultF197120EAAA7488594BFCD708A09CE9F,"Budgetdetails",ref ISpace);
iSpace.UpdateGridBindDetails("Budgetdetails",resultF197120EAAA7488594BFCD708A09CE9F);
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mf_projectcommitments_firstbutton (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MF_ProjectCommitments_FirstButton-OnClick");
ISpace["MF_Budgetdetails_PageIndex"].Value=1;
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PageIndex""].Value=1;");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 0,'#F_BudgetHeadId','',#MF_Budgetdetails_PageIndex,'#MF_Budgetdetails_GridRows','#F_ProjectDetailsId'");

var querySource05309A85D55C43B8A687C2A189F723E7 =GetQueryExpressionDataSource("05309A85-D55C-43B8-A687-C2A189F723E7");
Dictionary<short,object> result05309A85D55C43B8A687C2A189F723E7=iSpace.ExecuteQuery(querySource05309A85D55C43B8A687C2A189F723E7,@"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 0,'" + ISpace["F_BudgetHeadId"].Value + @"',''," + ISpace["MF_Budgetdetails_PageIndex"].Value + @",'" + ISpace["MF_Budgetdetails_GridRows"].Value + @"','" + ISpace["F_ProjectDetailsId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource05309A85D55C43B8A687C2A189F723E7 =GetQueryExpressionDataSource(""05309A85-D55C-43B8-A687-C2A189F723E7"");Dictionary<short,object> result05309A85D55C43B8A687C2A189F723E7=iSpace.ExecuteQuery(querySource05309A85D55C43B8A687C2A189F723E7,@""EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 0,'"" + ISpace[""F_BudgetHeadId""].Value + @""','',"" + ISpace[""MF_Budgetdetails_PageIndex""].Value + @"",'"" + ISpace[""MF_Budgetdetails_GridRows""].Value + @""','"" + ISpace[""F_ProjectDetailsId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result05309A85D55C43B8A687C2A189F723E7!=null) && (result05309A85D55C43B8A687C2A189F723E7.Count!=0))
{
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(0))
ISpace["MF_ProjectCommitments_GridRows"].Value = result05309A85D55C43B8A687C2A189F723E7[0];
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(3))
ISpace["MF_ProjectCommitments_TotalPages"].Value = result05309A85D55C43B8A687C2A189F723E7[3];
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(2))
ISpace["MF_ProjectCommitments_PageIndex"].Value = result05309A85D55C43B8A687C2A189F723E7[2];
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(1))
ISpace["MF_ProjectCommitments_RecordsRange"].Value = result05309A85D55C43B8A687C2A189F723E7[1];
}
else{
ISpace["MF_ProjectCommitments_GridRows"].Value = null;ISpace["MF_ProjectCommitments_TotalPages"].Value = null;ISpace["MF_ProjectCommitments_PageIndex"].Value = null;ISpace["MF_ProjectCommitments_RecordsRange"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_Budgetdetails_PageIndex"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""MF_Budgetdetails_PageIndex""].Value==1)");
if(ISpace["MF_Budgetdetails_PageIndex"].Value==ISpace["MF_Budgetdetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_Budgetdetails_PageIndex""].Value==ISpace[""MF_Budgetdetails_TotalPages""].Value)");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="false";ISpace["MF_ProjectCommitments_LastButton"].Enbl="false";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="false";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="false";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""false"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="true";ISpace["MF_ProjectCommitments_LastButton"].Enbl="true";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="false";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="false";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""true"";");
}
}
else
{
base.WriteDebugInfo(@"else");
if(ISpace["MF_Budgetdetails_PageIndex"].Value==ISpace["MF_Budgetdetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_Budgetdetails_PageIndex""].Value==ISpace[""MF_Budgetdetails_TotalPages""].Value)");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="false";ISpace["MF_ProjectCommitments_LastButton"].Enbl="false";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="true";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="true";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="true";ISpace["MF_ProjectCommitments_LastButton"].Enbl="true";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="true";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="true";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""true"";");
}
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySource01000C9CF4F74DAA8E0E4E2ACF3299FF =GetQueryExpressionDataSource("01000C9C-F4F7-4DAA-8E0E-4E2ACF3299FF");

DataTable result01000C9CF4F74DAA8E0E4E2ACF3299FF=iSpace.SetGridDataSource(querySource01000C9CF4F74DAA8E0E4E2ACF3299FF, _objectFactory.GetGridRPP("ProjectCommitments"),@"EXEC dbo.[Get_e046fb44-e1f1-4f2a-a07e-231e72f92166_FilterData] 1,'" + ISpace["F_ProjectDetailsId"].Value + @"',''," + ISpace["MF_ProjectCommitments_PageIndex"].Value + @",'" + ISpace["MF_ProjectCommitments_GridRows"].Value + @"'");

iSpace.InsertGridBindDetails("ProjectCommitments","11",querySource01000C9CF4F74DAA8E0E4E2ACF3299FF,"EXEC dbo.[Get_e046fb44-e1f1-4f2a-a07e-231e72f92166_FilterData] 1,'" + ISpace["F_ProjectDetailsId"].Value + @"',''," + ISpace["MF_ProjectCommitments_PageIndex"].Value + @",'" + ISpace["MF_ProjectCommitments_GridRows"].Value + @"'",_objectFactory.GetGridRPP("ProjectCommitments"));

base.WriteDebugInfo(@"var querySource01000C9CF4F74DAA8E0E4E2ACF3299FF =GetQueryExpressionDataSource(""01000C9C-F4F7-4DAA-8E0E-4E2ACF3299FF"");DataTable result01000C9CF4F74DAA8E0E4E2ACF3299FF=iSpace.SetGridDataSource(querySource01000C9CF4F74DAA8E0E4E2ACF3299FF, _objectFactory.GetGridRPP(""ProjectCommitments""),@""EXEC dbo.[Get_e046fb44-e1f1-4f2a-a07e-231e72f92166_FilterData] 1,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',"" + ISpace[""MF_ProjectCommitments_PageIndex""].Value + @"",'"" + ISpace[""MF_ProjectCommitments_GridRows""].Value + @""'"");iSpace.InsertGridBindDetails(""ProjectCommitments"",""11"",querySource01000C9CF4F74DAA8E0E4E2ACF3299FF,""EXEC dbo.[Get_e046fb44-e1f1-4f2a-a07e-231e72f92166_FilterData] 1,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',"" + ISpace[""MF_ProjectCommitments_PageIndex""].Value + @"",'"" + ISpace[""MF_ProjectCommitments_GridRows""].Value + @""'"",_objectFactory.GetGridRPP(""ProjectCommitments""));");
base.WriteDebugInfo(@"EXEC dbo.[Get_e046fb44-e1f1-4f2a-a07e-231e72f92166_FilterData] 1,'#F_ProjectDetailsId','',#MF_ProjectCommitments_PageIndex,'#MF_ProjectCommitments_GridRows'");


List<Triplet<string, short, short?>> result34DD54DC0E5B46EAA0BBD99E022B7345=acdataIspace585BA2B83E754DABB50B10D8320CE414.GetQueryExpressionBindings("34DD54DC-0E5B-46EA-A0BB-D99E022B7345");
iSpace.SetGridData(result01000C9CF4F74DAA8E0E4E2ACF3299FF,result34DD54DC0E5B46EAA0BBD99E022B7345,"ProjectCommitments",ref ISpace);
iSpace.UpdateGridBindDetails("ProjectCommitments",result34DD54DC0E5B46EAA0BBD99E022B7345);
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mf_projectcommitments_prevbutton (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MF_ProjectCommitments_PrevButton-OnClick");
if(ISpace["MF_Budgetdetails_PageIndex"].Value>2)
{
base.WriteDebugInfo(@"if(ISpace[""MF_Budgetdetails_PageIndex""].Value>2)");
ISpace["MF_Budgetdetails_PageIndex"].Value=ISpace["MF_Budgetdetails_PageIndex"].Value-1;
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PageIndex""].Value=ISpace[""MF_Budgetdetails_PageIndex""].Value-1;");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_Budgetdetails_PageIndex"].Value=1;
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PageIndex""].Value=1;");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 0,'#F_BudgetHeadId','',#MF_Budgetdetails_PageIndex,'#MF_Budgetdetails_GridRows','#F_ProjectDetailsId'");

var querySource05309A85D55C43B8A687C2A189F723E7 =GetQueryExpressionDataSource("05309A85-D55C-43B8-A687-C2A189F723E7");
Dictionary<short,object> result05309A85D55C43B8A687C2A189F723E7=iSpace.ExecuteQuery(querySource05309A85D55C43B8A687C2A189F723E7,@"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 0,'" + ISpace["F_BudgetHeadId"].Value + @"',''," + ISpace["MF_Budgetdetails_PageIndex"].Value + @",'" + ISpace["MF_Budgetdetails_GridRows"].Value + @"','" + ISpace["F_ProjectDetailsId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource05309A85D55C43B8A687C2A189F723E7 =GetQueryExpressionDataSource(""05309A85-D55C-43B8-A687-C2A189F723E7"");Dictionary<short,object> result05309A85D55C43B8A687C2A189F723E7=iSpace.ExecuteQuery(querySource05309A85D55C43B8A687C2A189F723E7,@""EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 0,'"" + ISpace[""F_BudgetHeadId""].Value + @""','',"" + ISpace[""MF_Budgetdetails_PageIndex""].Value + @"",'"" + ISpace[""MF_Budgetdetails_GridRows""].Value + @""','"" + ISpace[""F_ProjectDetailsId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result05309A85D55C43B8A687C2A189F723E7!=null) && (result05309A85D55C43B8A687C2A189F723E7.Count!=0))
{
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(0))
ISpace["MF_ProjectCommitments_GridRows"].Value = result05309A85D55C43B8A687C2A189F723E7[0];
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(3))
ISpace["MF_ProjectCommitments_TotalPages"].Value = result05309A85D55C43B8A687C2A189F723E7[3];
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(2))
ISpace["MF_ProjectCommitments_PageIndex"].Value = result05309A85D55C43B8A687C2A189F723E7[2];
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(1))
ISpace["MF_ProjectCommitments_RecordsRange"].Value = result05309A85D55C43B8A687C2A189F723E7[1];
}
else{
ISpace["MF_ProjectCommitments_GridRows"].Value = null;ISpace["MF_ProjectCommitments_TotalPages"].Value = null;ISpace["MF_ProjectCommitments_PageIndex"].Value = null;ISpace["MF_ProjectCommitments_RecordsRange"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_Budgetdetails_PageIndex"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""MF_Budgetdetails_PageIndex""].Value==1)");
if(ISpace["MF_Budgetdetails_PageIndex"].Value==ISpace["MF_Budgetdetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_Budgetdetails_PageIndex""].Value==ISpace[""MF_Budgetdetails_TotalPages""].Value)");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="false";ISpace["MF_ProjectCommitments_LastButton"].Enbl="false";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="false";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="false";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""false"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="true";ISpace["MF_ProjectCommitments_LastButton"].Enbl="true";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="false";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="false";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""true"";");
}
}
else
{
base.WriteDebugInfo(@"else");
if(ISpace["MF_Budgetdetails_PageIndex"].Value==ISpace["MF_Budgetdetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_Budgetdetails_PageIndex""].Value==ISpace[""MF_Budgetdetails_TotalPages""].Value)");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="false";ISpace["MF_ProjectCommitments_LastButton"].Enbl="false";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="true";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="true";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="true";ISpace["MF_ProjectCommitments_LastButton"].Enbl="true";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="true";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="true";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""true"";");
}
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySource01000C9CF4F74DAA8E0E4E2ACF3299FF =GetQueryExpressionDataSource("01000C9C-F4F7-4DAA-8E0E-4E2ACF3299FF");

DataTable result01000C9CF4F74DAA8E0E4E2ACF3299FF=iSpace.SetGridDataSource(querySource01000C9CF4F74DAA8E0E4E2ACF3299FF, _objectFactory.GetGridRPP("ProjectCommitments"),@"EXEC dbo.[Get_e046fb44-e1f1-4f2a-a07e-231e72f92166_FilterData] 1,'" + ISpace["F_ProjectDetailsId"].Value + @"',''," + ISpace["MF_ProjectCommitments_PageIndex"].Value + @",'" + ISpace["MF_ProjectCommitments_GridRows"].Value + @"'");

iSpace.InsertGridBindDetails("ProjectCommitments","11",querySource01000C9CF4F74DAA8E0E4E2ACF3299FF,"EXEC dbo.[Get_e046fb44-e1f1-4f2a-a07e-231e72f92166_FilterData] 1,'" + ISpace["F_ProjectDetailsId"].Value + @"',''," + ISpace["MF_ProjectCommitments_PageIndex"].Value + @",'" + ISpace["MF_ProjectCommitments_GridRows"].Value + @"'",_objectFactory.GetGridRPP("ProjectCommitments"));

base.WriteDebugInfo(@"var querySource01000C9CF4F74DAA8E0E4E2ACF3299FF =GetQueryExpressionDataSource(""01000C9C-F4F7-4DAA-8E0E-4E2ACF3299FF"");DataTable result01000C9CF4F74DAA8E0E4E2ACF3299FF=iSpace.SetGridDataSource(querySource01000C9CF4F74DAA8E0E4E2ACF3299FF, _objectFactory.GetGridRPP(""ProjectCommitments""),@""EXEC dbo.[Get_e046fb44-e1f1-4f2a-a07e-231e72f92166_FilterData] 1,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',"" + ISpace[""MF_ProjectCommitments_PageIndex""].Value + @"",'"" + ISpace[""MF_ProjectCommitments_GridRows""].Value + @""'"");iSpace.InsertGridBindDetails(""ProjectCommitments"",""11"",querySource01000C9CF4F74DAA8E0E4E2ACF3299FF,""EXEC dbo.[Get_e046fb44-e1f1-4f2a-a07e-231e72f92166_FilterData] 1,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',"" + ISpace[""MF_ProjectCommitments_PageIndex""].Value + @"",'"" + ISpace[""MF_ProjectCommitments_GridRows""].Value + @""'"",_objectFactory.GetGridRPP(""ProjectCommitments""));");
base.WriteDebugInfo(@"EXEC dbo.[Get_e046fb44-e1f1-4f2a-a07e-231e72f92166_FilterData] 1,'#F_ProjectDetailsId','',#MF_ProjectCommitments_PageIndex,'#MF_ProjectCommitments_GridRows'");


List<Triplet<string, short, short?>> result34DD54DC0E5B46EAA0BBD99E022B7345=acdataIspace585BA2B83E754DABB50B10D8320CE414.GetQueryExpressionBindings("34DD54DC-0E5B-46EA-A0BB-D99E022B7345");
iSpace.SetGridData(result01000C9CF4F74DAA8E0E4E2ACF3299FF,result34DD54DC0E5B46EAA0BBD99E022B7345,"ProjectCommitments",ref ISpace);
iSpace.UpdateGridBindDetails("ProjectCommitments",result34DD54DC0E5B46EAA0BBD99E022B7345);
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mf_receiptsview_firstbutton (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MF_ReceiptsView_FirstButton-OnClick");
ISpace["MF_Budgetdetails_PageIndex"].Value=1;
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PageIndex""].Value=1;");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 0,'#F_BudgetHeadId','',#MF_Budgetdetails_PageIndex,'#MF_Budgetdetails_GridRows','#F_ProjectDetailsId'");

var querySource05309A85D55C43B8A687C2A189F723E7 =GetQueryExpressionDataSource("05309A85-D55C-43B8-A687-C2A189F723E7");
Dictionary<short,object> result05309A85D55C43B8A687C2A189F723E7=iSpace.ExecuteQuery(querySource05309A85D55C43B8A687C2A189F723E7,@"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 0,'" + ISpace["F_BudgetHeadId"].Value + @"',''," + ISpace["MF_Budgetdetails_PageIndex"].Value + @",'" + ISpace["MF_Budgetdetails_GridRows"].Value + @"','" + ISpace["F_ProjectDetailsId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource05309A85D55C43B8A687C2A189F723E7 =GetQueryExpressionDataSource(""05309A85-D55C-43B8-A687-C2A189F723E7"");Dictionary<short,object> result05309A85D55C43B8A687C2A189F723E7=iSpace.ExecuteQuery(querySource05309A85D55C43B8A687C2A189F723E7,@""EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 0,'"" + ISpace[""F_BudgetHeadId""].Value + @""','',"" + ISpace[""MF_Budgetdetails_PageIndex""].Value + @"",'"" + ISpace[""MF_Budgetdetails_GridRows""].Value + @""','"" + ISpace[""F_ProjectDetailsId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result05309A85D55C43B8A687C2A189F723E7!=null) && (result05309A85D55C43B8A687C2A189F723E7.Count!=0))
{
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(0))
ISpace["MF_ProjectCommitments_GridRows"].Value = result05309A85D55C43B8A687C2A189F723E7[0];
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(3))
ISpace["MF_ProjectCommitments_TotalPages"].Value = result05309A85D55C43B8A687C2A189F723E7[3];
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(2))
ISpace["MF_ProjectCommitments_PageIndex"].Value = result05309A85D55C43B8A687C2A189F723E7[2];
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(1))
ISpace["MF_ProjectCommitments_RecordsRange"].Value = result05309A85D55C43B8A687C2A189F723E7[1];
}
else{
ISpace["MF_ProjectCommitments_GridRows"].Value = null;ISpace["MF_ProjectCommitments_TotalPages"].Value = null;ISpace["MF_ProjectCommitments_PageIndex"].Value = null;ISpace["MF_ProjectCommitments_RecordsRange"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_Budgetdetails_PageIndex"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""MF_Budgetdetails_PageIndex""].Value==1)");
if(ISpace["MF_Budgetdetails_PageIndex"].Value==ISpace["MF_Budgetdetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_Budgetdetails_PageIndex""].Value==ISpace[""MF_Budgetdetails_TotalPages""].Value)");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="false";ISpace["MF_ProjectCommitments_LastButton"].Enbl="false";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="false";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="false";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""false"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="true";ISpace["MF_ProjectCommitments_LastButton"].Enbl="true";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="false";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="false";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""true"";");
}
}
else
{
base.WriteDebugInfo(@"else");
if(ISpace["MF_Budgetdetails_PageIndex"].Value==ISpace["MF_Budgetdetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_Budgetdetails_PageIndex""].Value==ISpace[""MF_Budgetdetails_TotalPages""].Value)");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="false";ISpace["MF_ProjectCommitments_LastButton"].Enbl="false";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="true";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="true";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="true";ISpace["MF_ProjectCommitments_LastButton"].Enbl="true";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="true";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="true";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""true"";");
}
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySource24686D701FFF4F4F81D7EE238FD68AC3 =GetQueryExpressionDataSource("24686D70-1FFF-4F4F-81D7-EE238FD68AC3");

DataTable result24686D701FFF4F4F81D7EE238FD68AC3=iSpace.SetGridDataSource(querySource24686D701FFF4F4F81D7EE238FD68AC3, _objectFactory.GetGridRPP("ReceiptsView"),@"EXEC dbo.[Get_bd3abae8-b5a2-4b71-b3e2-e46732479592_FilterData] 1,'" + ISpace["F_ReceiptNo"].Value + @"',''," + ISpace["MF_ReceiptsView_PageIndex"].Value + @",'" + ISpace["MF_ReceiptsView_GridRows"].Value + @"','" + ISpace["F_ProjectDetailsID"].Value + @"'");

iSpace.InsertGridBindDetails("ReceiptsView","11",querySource24686D701FFF4F4F81D7EE238FD68AC3,"EXEC dbo.[Get_bd3abae8-b5a2-4b71-b3e2-e46732479592_FilterData] 1,'" + ISpace["F_ReceiptNo"].Value + @"',''," + ISpace["MF_ReceiptsView_PageIndex"].Value + @",'" + ISpace["MF_ReceiptsView_GridRows"].Value + @"','" + ISpace["F_ProjectDetailsID"].Value + @"'",_objectFactory.GetGridRPP("ReceiptsView"));

base.WriteDebugInfo(@"var querySource24686D701FFF4F4F81D7EE238FD68AC3 =GetQueryExpressionDataSource(""24686D70-1FFF-4F4F-81D7-EE238FD68AC3"");DataTable result24686D701FFF4F4F81D7EE238FD68AC3=iSpace.SetGridDataSource(querySource24686D701FFF4F4F81D7EE238FD68AC3, _objectFactory.GetGridRPP(""ReceiptsView""),@""EXEC dbo.[Get_bd3abae8-b5a2-4b71-b3e2-e46732479592_FilterData] 1,'"" + ISpace[""F_ReceiptNo""].Value + @""','',"" + ISpace[""MF_ReceiptsView_PageIndex""].Value + @"",'"" + ISpace[""MF_ReceiptsView_GridRows""].Value + @""','"" + ISpace[""F_ProjectDetailsID""].Value + @""'"");iSpace.InsertGridBindDetails(""ReceiptsView"",""11"",querySource24686D701FFF4F4F81D7EE238FD68AC3,""EXEC dbo.[Get_bd3abae8-b5a2-4b71-b3e2-e46732479592_FilterData] 1,'"" + ISpace[""F_ReceiptNo""].Value + @""','',"" + ISpace[""MF_ReceiptsView_PageIndex""].Value + @"",'"" + ISpace[""MF_ReceiptsView_GridRows""].Value + @""','"" + ISpace[""F_ProjectDetailsID""].Value + @""'"",_objectFactory.GetGridRPP(""ReceiptsView""));");
base.WriteDebugInfo(@"EXEC dbo.[Get_bd3abae8-b5a2-4b71-b3e2-e46732479592_FilterData] 1,'#F_ReceiptNo','',#MF_ReceiptsView_PageIndex,'#MF_ReceiptsView_GridRows'");


List<Triplet<string, short, short?>> result3E6384212EC24473A32F5167327104C5=acdataIspace585BA2B83E754DABB50B10D8320CE414.GetQueryExpressionBindings("3E638421-2EC2-4473-A32F-5167327104C5");
iSpace.SetGridData(result24686D701FFF4F4F81D7EE238FD68AC3,result3E6384212EC24473A32F5167327104C5,"ReceiptsView",ref ISpace);
iSpace.UpdateGridBindDetails("ReceiptsView",result3E6384212EC24473A32F5167327104C5);
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mf_projectcommitments_pageindex (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MF_ProjectCommitments_PageIndex-OnChange");
ISpace["MF_Option"].Value=1;
base.WriteDebugInfo(@"ISpace[""MF_Option""].Value=1;");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 0,'#F_BudgetHeadId','',#MF_Budgetdetails_PageIndex,'#MF_Budgetdetails_GridRows','#F_ProjectDetailsId'");

var querySource05309A85D55C43B8A687C2A189F723E7 =GetQueryExpressionDataSource("05309A85-D55C-43B8-A687-C2A189F723E7");
Dictionary<short,object> result05309A85D55C43B8A687C2A189F723E7=iSpace.ExecuteQuery(querySource05309A85D55C43B8A687C2A189F723E7,@"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 0,'" + ISpace["F_BudgetHeadId"].Value + @"',''," + ISpace["MF_Budgetdetails_PageIndex"].Value + @",'" + ISpace["MF_Budgetdetails_GridRows"].Value + @"','" + ISpace["F_ProjectDetailsId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource05309A85D55C43B8A687C2A189F723E7 =GetQueryExpressionDataSource(""05309A85-D55C-43B8-A687-C2A189F723E7"");Dictionary<short,object> result05309A85D55C43B8A687C2A189F723E7=iSpace.ExecuteQuery(querySource05309A85D55C43B8A687C2A189F723E7,@""EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 0,'"" + ISpace[""F_BudgetHeadId""].Value + @""','',"" + ISpace[""MF_Budgetdetails_PageIndex""].Value + @"",'"" + ISpace[""MF_Budgetdetails_GridRows""].Value + @""','"" + ISpace[""F_ProjectDetailsId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result05309A85D55C43B8A687C2A189F723E7!=null) && (result05309A85D55C43B8A687C2A189F723E7.Count!=0))
{
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(0))
ISpace["MF_ProjectCommitments_GridRows"].Value = result05309A85D55C43B8A687C2A189F723E7[0];
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(3))
ISpace["MF_ProjectCommitments_TotalPages"].Value = result05309A85D55C43B8A687C2A189F723E7[3];
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(2))
ISpace["MF_ProjectCommitments_PageIndex"].Value = result05309A85D55C43B8A687C2A189F723E7[2];
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(1))
ISpace["MF_ProjectCommitments_RecordsRange"].Value = result05309A85D55C43B8A687C2A189F723E7[1];
}
else{
ISpace["MF_ProjectCommitments_GridRows"].Value = null;ISpace["MF_ProjectCommitments_TotalPages"].Value = null;ISpace["MF_ProjectCommitments_PageIndex"].Value = null;ISpace["MF_ProjectCommitments_RecordsRange"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_Budgetdetails_PageIndex"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""MF_Budgetdetails_PageIndex""].Value==1)");
if(ISpace["MF_Budgetdetails_PageIndex"].Value==ISpace["MF_Budgetdetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_Budgetdetails_PageIndex""].Value==ISpace[""MF_Budgetdetails_TotalPages""].Value)");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="false";ISpace["MF_ProjectCommitments_LastButton"].Enbl="false";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="false";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="false";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""false"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="true";ISpace["MF_ProjectCommitments_LastButton"].Enbl="true";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="false";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="false";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""true"";");
}
}
else
{
base.WriteDebugInfo(@"else");
if(ISpace["MF_Budgetdetails_PageIndex"].Value==ISpace["MF_Budgetdetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_Budgetdetails_PageIndex""].Value==ISpace[""MF_Budgetdetails_TotalPages""].Value)");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="false";ISpace["MF_ProjectCommitments_LastButton"].Enbl="false";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="true";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="true";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="true";ISpace["MF_ProjectCommitments_LastButton"].Enbl="true";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="true";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="true";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""true"";");
}
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySource01000C9CF4F74DAA8E0E4E2ACF3299FF =GetQueryExpressionDataSource("01000C9C-F4F7-4DAA-8E0E-4E2ACF3299FF");

DataTable result01000C9CF4F74DAA8E0E4E2ACF3299FF=iSpace.SetGridDataSource(querySource01000C9CF4F74DAA8E0E4E2ACF3299FF, _objectFactory.GetGridRPP("ProjectCommitments"),@"EXEC dbo.[Get_e046fb44-e1f1-4f2a-a07e-231e72f92166_FilterData] 1,'" + ISpace["F_ProjectDetailsId"].Value + @"',''," + ISpace["MF_ProjectCommitments_PageIndex"].Value + @",'" + ISpace["MF_ProjectCommitments_GridRows"].Value + @"'");

iSpace.InsertGridBindDetails("ProjectCommitments","11",querySource01000C9CF4F74DAA8E0E4E2ACF3299FF,"EXEC dbo.[Get_e046fb44-e1f1-4f2a-a07e-231e72f92166_FilterData] 1,'" + ISpace["F_ProjectDetailsId"].Value + @"',''," + ISpace["MF_ProjectCommitments_PageIndex"].Value + @",'" + ISpace["MF_ProjectCommitments_GridRows"].Value + @"'",_objectFactory.GetGridRPP("ProjectCommitments"));

base.WriteDebugInfo(@"var querySource01000C9CF4F74DAA8E0E4E2ACF3299FF =GetQueryExpressionDataSource(""01000C9C-F4F7-4DAA-8E0E-4E2ACF3299FF"");DataTable result01000C9CF4F74DAA8E0E4E2ACF3299FF=iSpace.SetGridDataSource(querySource01000C9CF4F74DAA8E0E4E2ACF3299FF, _objectFactory.GetGridRPP(""ProjectCommitments""),@""EXEC dbo.[Get_e046fb44-e1f1-4f2a-a07e-231e72f92166_FilterData] 1,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',"" + ISpace[""MF_ProjectCommitments_PageIndex""].Value + @"",'"" + ISpace[""MF_ProjectCommitments_GridRows""].Value + @""'"");iSpace.InsertGridBindDetails(""ProjectCommitments"",""11"",querySource01000C9CF4F74DAA8E0E4E2ACF3299FF,""EXEC dbo.[Get_e046fb44-e1f1-4f2a-a07e-231e72f92166_FilterData] 1,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',"" + ISpace[""MF_ProjectCommitments_PageIndex""].Value + @"",'"" + ISpace[""MF_ProjectCommitments_GridRows""].Value + @""'"",_objectFactory.GetGridRPP(""ProjectCommitments""));");
base.WriteDebugInfo(@"EXEC dbo.[Get_e046fb44-e1f1-4f2a-a07e-231e72f92166_FilterData] 1,'#F_ProjectDetailsId','',#MF_ProjectCommitments_PageIndex,'#MF_ProjectCommitments_GridRows'");


List<Triplet<string, short, short?>> result34DD54DC0E5B46EAA0BBD99E022B7345=acdataIspace585BA2B83E754DABB50B10D8320CE414.GetQueryExpressionBindings("34DD54DC-0E5B-46EA-A0BB-D99E022B7345");
iSpace.SetGridData(result01000C9CF4F74DAA8E0E4E2ACF3299FF,result34DD54DC0E5B46EAA0BBD99E022B7345,"ProjectCommitments",ref ISpace);
iSpace.UpdateGridBindDetails("ProjectCommitments",result34DD54DC0E5B46EAA0BBD99E022B7345);
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mf_receiptsview_pageindex (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MF_ReceiptsView_PageIndex-OnChange");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 0,'#F_BudgetHeadId','',#MF_Budgetdetails_PageIndex,'#MF_Budgetdetails_GridRows','#F_ProjectDetailsId'");

var querySource05309A85D55C43B8A687C2A189F723E7 =GetQueryExpressionDataSource("05309A85-D55C-43B8-A687-C2A189F723E7");
Dictionary<short,object> result05309A85D55C43B8A687C2A189F723E7=iSpace.ExecuteQuery(querySource05309A85D55C43B8A687C2A189F723E7,@"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 0,'" + ISpace["F_BudgetHeadId"].Value + @"',''," + ISpace["MF_Budgetdetails_PageIndex"].Value + @",'" + ISpace["MF_Budgetdetails_GridRows"].Value + @"','" + ISpace["F_ProjectDetailsId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource05309A85D55C43B8A687C2A189F723E7 =GetQueryExpressionDataSource(""05309A85-D55C-43B8-A687-C2A189F723E7"");Dictionary<short,object> result05309A85D55C43B8A687C2A189F723E7=iSpace.ExecuteQuery(querySource05309A85D55C43B8A687C2A189F723E7,@""EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 0,'"" + ISpace[""F_BudgetHeadId""].Value + @""','',"" + ISpace[""MF_Budgetdetails_PageIndex""].Value + @"",'"" + ISpace[""MF_Budgetdetails_GridRows""].Value + @""','"" + ISpace[""F_ProjectDetailsId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result05309A85D55C43B8A687C2A189F723E7!=null) && (result05309A85D55C43B8A687C2A189F723E7.Count!=0))
{
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(0))
ISpace["MF_ProjectCommitments_GridRows"].Value = result05309A85D55C43B8A687C2A189F723E7[0];
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(3))
ISpace["MF_ProjectCommitments_TotalPages"].Value = result05309A85D55C43B8A687C2A189F723E7[3];
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(2))
ISpace["MF_ProjectCommitments_PageIndex"].Value = result05309A85D55C43B8A687C2A189F723E7[2];
if(result05309A85D55C43B8A687C2A189F723E7.ContainsKey(1))
ISpace["MF_ProjectCommitments_RecordsRange"].Value = result05309A85D55C43B8A687C2A189F723E7[1];
}
else{
ISpace["MF_ProjectCommitments_GridRows"].Value = null;ISpace["MF_ProjectCommitments_TotalPages"].Value = null;ISpace["MF_ProjectCommitments_PageIndex"].Value = null;ISpace["MF_ProjectCommitments_RecordsRange"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_Budgetdetails_PageIndex"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""MF_Budgetdetails_PageIndex""].Value==1)");
if(ISpace["MF_Budgetdetails_PageIndex"].Value==ISpace["MF_Budgetdetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_Budgetdetails_PageIndex""].Value==ISpace[""MF_Budgetdetails_TotalPages""].Value)");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="false";ISpace["MF_ProjectCommitments_LastButton"].Enbl="false";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="false";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="false";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""false"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="true";ISpace["MF_ProjectCommitments_LastButton"].Enbl="true";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="false";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="false";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""true"";");
}
}
else
{
base.WriteDebugInfo(@"else");
if(ISpace["MF_Budgetdetails_PageIndex"].Value==ISpace["MF_Budgetdetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_Budgetdetails_PageIndex""].Value==ISpace[""MF_Budgetdetails_TotalPages""].Value)");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="false";ISpace["MF_ProjectCommitments_LastButton"].Enbl="false";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="true";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="true";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""false"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_ProjectCommitments_NextButton"].Enbl="true";ISpace["MF_ProjectCommitments_LastButton"].Enbl="true";ISpace["MF_ProjectCommitments_FirstButton"].Enbl="true";ISpace["MF_ProjectCommitments_PrevButton"].Enbl="true";ISpace["MF_ProjectCommitments_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_ProjectCommitments_NextButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_LastButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_FirstButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PrevButton""].Enbl=""true"";ISpace[""MF_ProjectCommitments_PageIndex""].Enbl=""true"";");
}
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySource24686D701FFF4F4F81D7EE238FD68AC3 =GetQueryExpressionDataSource("24686D70-1FFF-4F4F-81D7-EE238FD68AC3");

DataTable result24686D701FFF4F4F81D7EE238FD68AC3=iSpace.SetGridDataSource(querySource24686D701FFF4F4F81D7EE238FD68AC3, _objectFactory.GetGridRPP("ReceiptsView"),@"EXEC dbo.[Get_bd3abae8-b5a2-4b71-b3e2-e46732479592_FilterData] 1,'" + ISpace["F_ReceiptNo"].Value + @"',''," + ISpace["MF_ReceiptsView_PageIndex"].Value + @",'" + ISpace["MF_ReceiptsView_GridRows"].Value + @"','" + ISpace["F_ProjectDetailsID"].Value + @"'");

iSpace.InsertGridBindDetails("ReceiptsView","11",querySource24686D701FFF4F4F81D7EE238FD68AC3,"EXEC dbo.[Get_bd3abae8-b5a2-4b71-b3e2-e46732479592_FilterData] 1,'" + ISpace["F_ReceiptNo"].Value + @"',''," + ISpace["MF_ReceiptsView_PageIndex"].Value + @",'" + ISpace["MF_ReceiptsView_GridRows"].Value + @"','" + ISpace["F_ProjectDetailsID"].Value + @"'",_objectFactory.GetGridRPP("ReceiptsView"));

base.WriteDebugInfo(@"var querySource24686D701FFF4F4F81D7EE238FD68AC3 =GetQueryExpressionDataSource(""24686D70-1FFF-4F4F-81D7-EE238FD68AC3"");DataTable result24686D701FFF4F4F81D7EE238FD68AC3=iSpace.SetGridDataSource(querySource24686D701FFF4F4F81D7EE238FD68AC3, _objectFactory.GetGridRPP(""ReceiptsView""),@""EXEC dbo.[Get_bd3abae8-b5a2-4b71-b3e2-e46732479592_FilterData] 1,'"" + ISpace[""F_ReceiptNo""].Value + @""','',"" + ISpace[""MF_ReceiptsView_PageIndex""].Value + @"",'"" + ISpace[""MF_ReceiptsView_GridRows""].Value + @""','"" + ISpace[""F_ProjectDetailsID""].Value + @""'"");iSpace.InsertGridBindDetails(""ReceiptsView"",""11"",querySource24686D701FFF4F4F81D7EE238FD68AC3,""EXEC dbo.[Get_bd3abae8-b5a2-4b71-b3e2-e46732479592_FilterData] 1,'"" + ISpace[""F_ReceiptNo""].Value + @""','',"" + ISpace[""MF_ReceiptsView_PageIndex""].Value + @"",'"" + ISpace[""MF_ReceiptsView_GridRows""].Value + @""','"" + ISpace[""F_ProjectDetailsID""].Value + @""'"",_objectFactory.GetGridRPP(""ReceiptsView""));");
base.WriteDebugInfo(@"EXEC dbo.[Get_bd3abae8-b5a2-4b71-b3e2-e46732479592_FilterData] 1,'#F_ReceiptNo','',#MF_ReceiptsView_PageIndex,'#MF_ReceiptsView_GridRows'");


List<Triplet<string, short, short?>> result3E6384212EC24473A32F5167327104C5=acdataIspace585BA2B83E754DABB50B10D8320CE414.GetQueryExpressionBindings("3E638421-2EC2-4473-A32F-5167327104C5");
iSpace.SetGridData(result24686D701FFF4F4F81D7EE238FD68AC3,result3E6384212EC24473A32F5167327104C5,"ReceiptsView",ref ISpace);
iSpace.UpdateGridBindDetails("ReceiptsView",result3E6384212EC24473A32F5167327104C5);
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_edit (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Edit-OnClick");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["FormVersionId"].Value=="F7DA2CD7-1723-45E3-94F5-6380EB2F0989")
{
ISpace["UI_Panel"].Visible="false";ISpace["UI_Panel"].Enbl="true";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""F7DA2CD7-1723-45E3-94F5-6380EB2F0989"")
{
ISpace[""UI_Panel""].Visible=""false"";ISpace[""UI_Panel""].Enbl=""true"";
}");
ISpace["MF_V1_BudgetHeadID"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_V1_BudgetHeadID""].Value=null;");
ISpace["MF_V1_ProjectDetailsID"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_V1_ProjectDetailsID""].Value=null;");
ISpace["MF_V1_BudgetHead"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_V1_BudgetHead""].Value=null;");
ISpace["MF_V1_SanctionedAmount"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_V1_SanctionedAmount""].Value=null;");
ISpace["MF_V1_ReceivedAmount"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_V1_ReceivedAmount""].Value=null;");
ISpace["MF_V1_YettoReceive"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_V1_YettoReceive""].Value=null;");
ISpace["MF_V1_Spent"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_V1_Spent""].Value=null;");
ISpace["MF_V1_Committment"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_V1_Committment""].Value=null;");
ISpace["MF_V1_Balance"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_V1_Balance""].Value=null;");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["FormVersionId"].Value=="F7DA2CD7-1723-45E3-94F5-6380EB2F0989")
{
ISpace["UI_Panel"].Visible="false";ISpace["UI_Panel"].Enbl="true";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""F7DA2CD7-1723-45E3-94F5-6380EB2F0989"")
{
ISpace[""UI_Panel""].Visible=""false"";ISpace[""UI_Panel""].Enbl=""true"";
}");
ISpace["MF_P1_ReceiptsId"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_P1_ReceiptsId""].Value=null;");
ISpace["MF_P1_ProjectDetailsId"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_P1_ProjectDetailsId""].Value=null;");
ISpace["MF_P1_ReceiptAmount"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_P1_ReceiptAmount""].Value=null;");
ISpace["MF_P1_ReceiptDate"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_P1_ReceiptDate""].Value=null;");
ISpace["MF_P1_TransferType"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_P1_TransferType""].Value=null;");
ISpace["MF_P1_TransferReferenceNumber"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_P1_TransferReferenceNumber""].Value=null;");
ISpace["MF_P1_TransferReferenceDate"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_P1_TransferReferenceDate""].Value=null;");
ISpace["MF_P1_TransferReferenceBankId"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_P1_TransferReferenceBankId""].Value=null;");
ISpace["MF_P1_TransferReferenceBranch"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_P1_TransferReferenceBranch""].Value=null;");
ISpace["MF_P1_ReceiptNo"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_P1_ReceiptNo""].Value=null;");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["FormVersionId"].Value=="F7DA2CD7-1723-45E3-94F5-6380EB2F0989")
{
ISpace["UI_Panel"].Visible="false";ISpace["UI_Panel"].Enbl="true";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""F7DA2CD7-1723-45E3-94F5-6380EB2F0989"")
{
ISpace[""UI_Panel""].Visible=""false"";ISpace[""UI_Panel""].Enbl=""true"";
}");
ISpace["MF_V1_ExpenseID"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_V1_ExpenseID""].Value=null;");
ISpace["MF_V1_BudgetHead"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_V1_BudgetHead""].Value=null;");
ISpace["MF_V1_ProjectDetailsID"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_V1_ProjectDetailsID""].Value=null;");
ISpace["MF_V1_PackageProcessMapID"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_V1_PackageProcessMapID""].Value=null;");
ISpace["MF_V1_ExpenseDate"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_V1_ExpenseDate""].Value=null;");
ISpace["MF_V1_AmountSpent"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_V1_AmountSpent""].Value=null;");
ISpace["MF_V1_ExpenseDescription"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_V1_ExpenseDescription""].Value=null;");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"SELECT VW_Commitments_1.[ExpenseID], VW_Commitments_1.[BudgetHead], VW_Commitments_1.[ProjectDetailsID], VW_Commitments_1.[PackageProcessMapID], VW_Commitments_1.[ExpenseDate], VW_Commitments_1.[AmountSpent], VW_Commitments_1.[ExpenseDescription] FROM  Projects..VW_Commitments_1  WHERE VW_Commitments_1.ExpenseID= '#MGG_V1_ExpenseID'");

var querySource480BF671BF494DAA8AC20673FCA12E10 =GetQueryExpressionDataSource("480BF671-BF49-4DAA-8AC2-0673FCA12E10");
Dictionary<short,object> result480BF671BF494DAA8AC20673FCA12E10=iSpace.ExecuteQuery(querySource480BF671BF494DAA8AC20673FCA12E10,@"SELECT VW_Commitments_1.[ExpenseID], VW_Commitments_1.[BudgetHead], VW_Commitments_1.[ProjectDetailsID], VW_Commitments_1.[PackageProcessMapID], VW_Commitments_1.[ExpenseDate], VW_Commitments_1.[AmountSpent], VW_Commitments_1.[ExpenseDescription] FROM  Projects..VW_Commitments_1  WHERE VW_Commitments_1.ExpenseID= '" + ISpace["MGG_V1_ExpenseID"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource480BF671BF494DAA8AC20673FCA12E10 =GetQueryExpressionDataSource(""480BF671-BF49-4DAA-8AC2-0673FCA12E10"");Dictionary<short,object> result480BF671BF494DAA8AC20673FCA12E10=iSpace.ExecuteQuery(querySource480BF671BF494DAA8AC20673FCA12E10,@""SELECT VW_Commitments_1.[ExpenseID], VW_Commitments_1.[BudgetHead], VW_Commitments_1.[ProjectDetailsID], VW_Commitments_1.[PackageProcessMapID], VW_Commitments_1.[ExpenseDate], VW_Commitments_1.[AmountSpent], VW_Commitments_1.[ExpenseDescription] FROM  Projects..VW_Commitments_1  WHERE VW_Commitments_1.ExpenseID= '"" + ISpace[""MGG_V1_ExpenseID""].Value + @""'"",false);");
base.WriteDebugInfo(@"SELECT VW_Commitments_1.[ExpenseID], VW_Commitments_1.[BudgetHead], VW_Commitments_1.[ProjectDetailsID], VW_Commitments_1.[PackageProcessMapID], VW_Commitments_1.[ExpenseDate], VW_Commitments_1.[AmountSpent], VW_Commitments_1.[ExpenseDescription] FROM  Projects..VW_Commitments_1  WHERE VW_Commitments_1.ExpenseID= '#MGG_V1_ExpenseID'");

if((result480BF671BF494DAA8AC20673FCA12E10!=null) && (result480BF671BF494DAA8AC20673FCA12E10.Count!=0))
{
if(result480BF671BF494DAA8AC20673FCA12E10.ContainsKey(4))
ISpace["MF_V1_ExpenseDate"].Value = result480BF671BF494DAA8AC20673FCA12E10[4];
if(result480BF671BF494DAA8AC20673FCA12E10.ContainsKey(5))
ISpace["MF_V1_AmountSpent"].Value = result480BF671BF494DAA8AC20673FCA12E10[5];
if(result480BF671BF494DAA8AC20673FCA12E10.ContainsKey(2))
ISpace["MF_V1_ProjectDetailsID"].Value = result480BF671BF494DAA8AC20673FCA12E10[2];
if(result480BF671BF494DAA8AC20673FCA12E10.ContainsKey(3))
ISpace["MF_V1_PackageProcessMapID"].Value = result480BF671BF494DAA8AC20673FCA12E10[3];
if(result480BF671BF494DAA8AC20673FCA12E10.ContainsKey(6))
ISpace["MF_V1_ExpenseDescription"].Value = result480BF671BF494DAA8AC20673FCA12E10[6];
if(result480BF671BF494DAA8AC20673FCA12E10.ContainsKey(1))
ISpace["MF_V1_BudgetHead"].Value = result480BF671BF494DAA8AC20673FCA12E10[1];
if(result480BF671BF494DAA8AC20673FCA12E10.ContainsKey(0))
ISpace["MF_V1_ExpenseID"].Value = result480BF671BF494DAA8AC20673FCA12E10[0];
}
else{
ISpace["MF_V1_ExpenseDate"].Value = null;ISpace["MF_V1_AmountSpent"].Value = null;ISpace["MF_V1_ProjectDetailsID"].Value = null;ISpace["MF_V1_PackageProcessMapID"].Value = null;ISpace["MF_V1_ExpenseDescription"].Value = null;ISpace["MF_V1_BudgetHead"].Value = null;ISpace["MF_V1_ExpenseID"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"SELECT ProjectReceipts.[ReceiptsId], ProjectReceipts.[ProjectDetailsId], ProjectReceipts.[ReceiptAmount], ProjectReceipts.[ReceiptDate], ProjectReceipts.[TransferType], ProjectReceipts.[TransferReferenceNumber], ProjectReceipts.[TransferReferenceDate], ProjectReceipts.[TransferReferenceBankId], ProjectReceipts.[TransferReferenceBranch], ProjectReceipts.[ReceiptNo] FROM  Projects..ProjectReceipts  WHERE ProjectReceipts.ReceiptsId= '#MGG_P1_ReceiptsId'");

var querySource1A383FFC832C49179E68F2D85A320241 =GetQueryExpressionDataSource("1A383FFC-832C-4917-9E68-F2D85A320241");
Dictionary<short,object> result1A383FFC832C49179E68F2D85A320241=iSpace.ExecuteQuery(querySource1A383FFC832C49179E68F2D85A320241,@"SELECT ProjectReceipts.[ReceiptsId], ProjectReceipts.[ProjectDetailsId], ProjectReceipts.[ReceiptAmount], ProjectReceipts.[ReceiptDate], ProjectReceipts.[TransferType], ProjectReceipts.[TransferReferenceNumber], ProjectReceipts.[TransferReferenceDate], ProjectReceipts.[TransferReferenceBankId], ProjectReceipts.[TransferReferenceBranch], ProjectReceipts.[ReceiptNo] FROM  Projects..ProjectReceipts  WHERE ProjectReceipts.ReceiptsId= '" + ISpace["MGG_P1_ReceiptsId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource1A383FFC832C49179E68F2D85A320241 =GetQueryExpressionDataSource(""1A383FFC-832C-4917-9E68-F2D85A320241"");Dictionary<short,object> result1A383FFC832C49179E68F2D85A320241=iSpace.ExecuteQuery(querySource1A383FFC832C49179E68F2D85A320241,@""SELECT ProjectReceipts.[ReceiptsId], ProjectReceipts.[ProjectDetailsId], ProjectReceipts.[ReceiptAmount], ProjectReceipts.[ReceiptDate], ProjectReceipts.[TransferType], ProjectReceipts.[TransferReferenceNumber], ProjectReceipts.[TransferReferenceDate], ProjectReceipts.[TransferReferenceBankId], ProjectReceipts.[TransferReferenceBranch], ProjectReceipts.[ReceiptNo] FROM  Projects..ProjectReceipts  WHERE ProjectReceipts.ReceiptsId= '"" + ISpace[""MGG_P1_ReceiptsId""].Value + @""'"",false);");
base.WriteDebugInfo(@"SELECT ProjectReceipts.[ReceiptsId], ProjectReceipts.[ProjectDetailsId], ProjectReceipts.[ReceiptAmount], ProjectReceipts.[ReceiptDate], ProjectReceipts.[TransferType], ProjectReceipts.[TransferReferenceNumber], ProjectReceipts.[TransferReferenceDate], ProjectReceipts.[TransferReferenceBankId], ProjectReceipts.[TransferReferenceBranch], ProjectReceipts.[ReceiptNo] FROM  Projects..ProjectReceipts  WHERE ProjectReceipts.ReceiptsId= '#MGG_P1_ReceiptsId'");

if((result1A383FFC832C49179E68F2D85A320241!=null) && (result1A383FFC832C49179E68F2D85A320241.Count!=0))
{
if(result1A383FFC832C49179E68F2D85A320241.ContainsKey(3))
ISpace["MF_P1_ReceiptDate"].Value = result1A383FFC832C49179E68F2D85A320241[3];
if(result1A383FFC832C49179E68F2D85A320241.ContainsKey(6))
ISpace["MF_P1_TransferReferenceDate"].Value = result1A383FFC832C49179E68F2D85A320241[6];
if(result1A383FFC832C49179E68F2D85A320241.ContainsKey(2))
ISpace["MF_P1_ReceiptAmount"].Value = result1A383FFC832C49179E68F2D85A320241[2];
if(result1A383FFC832C49179E68F2D85A320241.ContainsKey(4))
ISpace["MF_P1_TransferType"].Value = result1A383FFC832C49179E68F2D85A320241[4];
if(result1A383FFC832C49179E68F2D85A320241.ContainsKey(7))
ISpace["MF_P1_TransferReferenceBankId"].Value = result1A383FFC832C49179E68F2D85A320241[7];
if(result1A383FFC832C49179E68F2D85A320241.ContainsKey(1))
ISpace["MF_P1_ProjectDetailsId"].Value = result1A383FFC832C49179E68F2D85A320241[1];
if(result1A383FFC832C49179E68F2D85A320241.ContainsKey(0))
ISpace["MF_P1_ReceiptsId"].Value = result1A383FFC832C49179E68F2D85A320241[0];
if(result1A383FFC832C49179E68F2D85A320241.ContainsKey(5))
ISpace["MF_P1_TransferReferenceNumber"].Value = result1A383FFC832C49179E68F2D85A320241[5];
if(result1A383FFC832C49179E68F2D85A320241.ContainsKey(8))
ISpace["MF_P1_TransferReferenceBranch"].Value = result1A383FFC832C49179E68F2D85A320241[8];
if(result1A383FFC832C49179E68F2D85A320241.ContainsKey(9))
ISpace["MF_P1_ReceiptNo"].Value = result1A383FFC832C49179E68F2D85A320241[9];
}
else{
ISpace["MF_P1_ReceiptDate"].Value = null;ISpace["MF_P1_TransferReferenceDate"].Value = null;ISpace["MF_P1_ReceiptAmount"].Value = null;ISpace["MF_P1_TransferType"].Value = null;ISpace["MF_P1_TransferReferenceBankId"].Value = null;ISpace["MF_P1_ProjectDetailsId"].Value = null;ISpace["MF_P1_ReceiptsId"].Value = null;ISpace["MF_P1_TransferReferenceNumber"].Value = null;ISpace["MF_P1_TransferReferenceBranch"].Value = null;ISpace["MF_P1_ReceiptNo"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"SELECT VW_BudgetDetails_1.[BudgetHeadID], VW_BudgetDetails_1.[ProjectDetailsID], VW_BudgetDetails_1.[BudgetHead], VW_BudgetDetails_1.[SanctionedAmount], VW_BudgetDetails_1.[ReceivedAmount], VW_BudgetDetails_1.[YettoReceive], VW_BudgetDetails_1.[Spent], VW_BudgetDetails_1.[Committment], VW_BudgetDetails_1.[Balance] FROM  Projects..VW_BudgetDetails_1  WHERE VW_BudgetDetails_1.BudgetHeadID= '#MGG_V1_BudgetHeadID'");

var querySource22C222E356484786897E70EBD8BF9872 =GetQueryExpressionDataSource("22C222E3-5648-4786-897E-70EBD8BF9872");
Dictionary<short,object> result22C222E356484786897E70EBD8BF9872=iSpace.ExecuteQuery(querySource22C222E356484786897E70EBD8BF9872,@"SELECT VW_BudgetDetails_1.[BudgetHeadID], VW_BudgetDetails_1.[ProjectDetailsID], VW_BudgetDetails_1.[BudgetHead], VW_BudgetDetails_1.[SanctionedAmount], VW_BudgetDetails_1.[ReceivedAmount], VW_BudgetDetails_1.[YettoReceive], VW_BudgetDetails_1.[Spent], VW_BudgetDetails_1.[Committment], VW_BudgetDetails_1.[Balance] FROM  Projects..VW_BudgetDetails_1  WHERE VW_BudgetDetails_1.BudgetHeadID= '" + ISpace["MGG_V1_BudgetHeadID"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource22C222E356484786897E70EBD8BF9872 =GetQueryExpressionDataSource(""22C222E3-5648-4786-897E-70EBD8BF9872"");Dictionary<short,object> result22C222E356484786897E70EBD8BF9872=iSpace.ExecuteQuery(querySource22C222E356484786897E70EBD8BF9872,@""SELECT VW_BudgetDetails_1.[BudgetHeadID], VW_BudgetDetails_1.[ProjectDetailsID], VW_BudgetDetails_1.[BudgetHead], VW_BudgetDetails_1.[SanctionedAmount], VW_BudgetDetails_1.[ReceivedAmount], VW_BudgetDetails_1.[YettoReceive], VW_BudgetDetails_1.[Spent], VW_BudgetDetails_1.[Committment], VW_BudgetDetails_1.[Balance] FROM  Projects..VW_BudgetDetails_1  WHERE VW_BudgetDetails_1.BudgetHeadID= '"" + ISpace[""MGG_V1_BudgetHeadID""].Value + @""'"",false);");
base.WriteDebugInfo(@"SELECT VW_BudgetDetails_1.[BudgetHeadID], VW_BudgetDetails_1.[ProjectDetailsID], VW_BudgetDetails_1.[BudgetHead], VW_BudgetDetails_1.[SanctionedAmount], VW_BudgetDetails_1.[ReceivedAmount], VW_BudgetDetails_1.[YettoReceive], VW_BudgetDetails_1.[Spent], VW_BudgetDetails_1.[Committment], VW_BudgetDetails_1.[Balance] FROM  Projects..VW_BudgetDetails_1  WHERE VW_BudgetDetails_1.BudgetHeadID= '#MGG_V1_BudgetHeadID'");

if((result22C222E356484786897E70EBD8BF9872!=null) && (result22C222E356484786897E70EBD8BF9872.Count!=0))
{
if(result22C222E356484786897E70EBD8BF9872.ContainsKey(7))
ISpace["MF_V1_Committment"].Value = result22C222E356484786897E70EBD8BF9872[7];
if(result22C222E356484786897E70EBD8BF9872.ContainsKey(4))
ISpace["MF_V1_ReceivedAmount"].Value = result22C222E356484786897E70EBD8BF9872[4];
if(result22C222E356484786897E70EBD8BF9872.ContainsKey(5))
ISpace["MF_V1_YettoReceive"].Value = result22C222E356484786897E70EBD8BF9872[5];
if(result22C222E356484786897E70EBD8BF9872.ContainsKey(8))
ISpace["MF_V1_Balance"].Value = result22C222E356484786897E70EBD8BF9872[8];
if(result22C222E356484786897E70EBD8BF9872.ContainsKey(3))
ISpace["MF_V1_SanctionedAmount"].Value = result22C222E356484786897E70EBD8BF9872[3];
if(result22C222E356484786897E70EBD8BF9872.ContainsKey(6))
ISpace["MF_V1_Spent"].Value = result22C222E356484786897E70EBD8BF9872[6];
if(result22C222E356484786897E70EBD8BF9872.ContainsKey(2))
ISpace["MF_V1_BudgetHead"].Value = result22C222E356484786897E70EBD8BF9872[2];
if(result22C222E356484786897E70EBD8BF9872.ContainsKey(1))
ISpace["MF_V1_ProjectDetailsID"].Value = result22C222E356484786897E70EBD8BF9872[1];
if(result22C222E356484786897E70EBD8BF9872.ContainsKey(0))
ISpace["MF_V1_BudgetHeadID"].Value = result22C222E356484786897E70EBD8BF9872[0];
}
else{
ISpace["MF_V1_Committment"].Value = null;ISpace["MF_V1_ReceivedAmount"].Value = null;ISpace["MF_V1_YettoReceive"].Value = null;ISpace["MF_V1_Balance"].Value = null;ISpace["MF_V1_SanctionedAmount"].Value = null;ISpace["MF_V1_Spent"].Value = null;ISpace["MF_V1_BudgetHead"].Value = null;ISpace["MF_V1_ProjectDetailsID"].Value = null;ISpace["MF_V1_BudgetHeadID"].Value = null;
}
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
		if(elementName.ToLower().Equals("mf_budgetdetails_pageindex"))
    {
    			SubscribeElementEvents_mf_budgetdetails_pageindex(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mf_receiptsview_gridrows"))
    {
    			SubscribeElementEvents_mf_receiptsview_gridrows(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mf_projectcommitments_gridrows"))
    {
    			SubscribeElementEvents_mf_projectcommitments_gridrows(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mf_budgetdetails_gridrows"))
    {
    			SubscribeElementEvents_mf_budgetdetails_gridrows(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mf_projectcommitments_pageindex"))
    {
    			SubscribeElementEvents_mf_projectcommitments_pageindex(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mf_receiptsview_pageindex"))
    {
    			SubscribeElementEvents_mf_receiptsview_pageindex(ref dfsParam);
    }
}
	if(methodName.ToLower().Equals("onclick"))
{
		if(elementName.ToLower().Equals("add"))
{
			SubscribeElementEvents_add(ref dfsParam);
}
		if(elementName.ToLower().Equals("save"))
{
			SubscribeElementEvents_save(ref dfsParam);
}
		if(elementName.ToLower().Equals("mf_budgetdetails_firstbutton"))
{
			SubscribeElementEvents_mf_budgetdetails_firstbutton(ref dfsParam);
}
		if(elementName.ToLower().Equals("mf_receiptsview_prevbutton"))
{
			SubscribeElementEvents_mf_receiptsview_prevbutton(ref dfsParam);
}
		if(elementName.ToLower().Equals("mf_budgetdetails_lastbutton"))
{
			SubscribeElementEvents_mf_budgetdetails_lastbutton(ref dfsParam);
}
		if(elementName.ToLower().Equals("mf_budgetdetails_nextbutton"))
{
			SubscribeElementEvents_mf_budgetdetails_nextbutton(ref dfsParam);
}
		if(elementName.ToLower().Equals("mf_projectcommitments_nextbutton"))
{
			SubscribeElementEvents_mf_projectcommitments_nextbutton(ref dfsParam);
}
		if(elementName.ToLower().Equals("apply"))
{
			SubscribeElementEvents_apply(ref dfsParam);
}
		if(elementName.ToLower().Equals("mf_projectcommitments_lastbutton"))
{
			SubscribeElementEvents_mf_projectcommitments_lastbutton(ref dfsParam);
}
		if(elementName.ToLower().Equals("cancel"))
{
			SubscribeElementEvents_cancel(ref dfsParam);
}
		if(elementName.ToLower().Equals("mf_receiptsview_nextbutton"))
{
			SubscribeElementEvents_mf_receiptsview_nextbutton(ref dfsParam);
}
		if(elementName.ToLower().Equals("mf_receiptsview_lastbutton"))
{
			SubscribeElementEvents_mf_receiptsview_lastbutton(ref dfsParam);
}
		if(elementName.ToLower().Equals("mf_budgetdetails_prevbutton"))
{
			SubscribeElementEvents_mf_budgetdetails_prevbutton(ref dfsParam);
}
		if(elementName.ToLower().Equals("mf_projectcommitments_firstbutton"))
{
			SubscribeElementEvents_mf_projectcommitments_firstbutton(ref dfsParam);
}
		if(elementName.ToLower().Equals("mf_projectcommitments_prevbutton"))
{
			SubscribeElementEvents_mf_projectcommitments_prevbutton(ref dfsParam);
}
		if(elementName.ToLower().Equals("mf_receiptsview_firstbutton"))
{
			SubscribeElementEvents_mf_receiptsview_firstbutton(ref dfsParam);
}
		if(elementName.ToLower().Equals("edit"))
{
			SubscribeElementEvents_edit(ref dfsParam);
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


	public partial class AcDataISpace585BA2B83E754DABB50B10D8320CE414  : ExtensionActivityBase
	{		
		
		
		private Dictionary<string,  List<Triplet<string, short, short?>>> queryExpressionBindings = 
											new Dictionary<string,  List<Triplet<string, short, short?>>>
		{
							{"34DD54DC-0E5B-46EA-A0BB-D99E022B7345", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MGG_V1_AmountSpent",5,
														   -1),
								   new Triplet<string, short, short?>("MGG_V1_BudgetHead",1,
														   -1),
								   new Triplet<string, short, short?>("MGG_V1_ExpenseDate",4,
														   -1),
								   new Triplet<string, short, short?>("MGG_V1_ExpenseDescription",6,
														   -1),
								   new Triplet<string, short, short?>("MGG_V1_ExpenseID",0,
														   -1),
								   new Triplet<string, short, short?>("MGG_V1_PackageProcessMapID",3,
														   -1),
								   new Triplet<string, short, short?>("MGG_V1_ProjectDetailsID",2,
														   -1),
								}
			},
							{"3E638421-2EC2-4473-A32F-5167327104C5", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MGG_P1_ProjectDetailsId",1,
														   -1),
								   new Triplet<string, short, short?>("MGG_P1_ReceiptAmount",2,
														   -1),
								   new Triplet<string, short, short?>("MGG_P1_ReceiptDate",3,
														   -1),
								   new Triplet<string, short, short?>("MGG_P1_ReceiptNo",9,
														   -1),
								   new Triplet<string, short, short?>("MGG_P1_ReceiptsId",0,
														   -1),
								   new Triplet<string, short, short?>("MGG_P1_TransferReferenceBankId",7,
														   -1),
								   new Triplet<string, short, short?>("MGG_P1_TransferReferenceBranch",8,
														   -1),
								   new Triplet<string, short, short?>("MGG_P1_TransferReferenceDate",6,
														   -1),
								   new Triplet<string, short, short?>("MGG_P1_TransferReferenceNumber",5,
														   -1),
								   new Triplet<string, short, short?>("MGG_P1_TransferType",4,
														   -1),
								}
			},
							{"F197120E-AAA7-4885-94BF-CD708A09CE9F", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MGG_V1_Balance",8,
														   -1),
								   new Triplet<string, short, short?>("MGG_V1_BudgetHead",2,
														   -1),
								   new Triplet<string, short, short?>("MGG_V1_BudgetHeadID",0,
														   -1),
								   new Triplet<string, short, short?>("MGG_V1_Committment",7,
														   -1),
								   new Triplet<string, short, short?>("MGG_V1_ProjectDetailsID",1,
														   -1),
								   new Triplet<string, short, short?>("MGG_V1_ReceivedAmount",4,
														   -1),
								   new Triplet<string, short, short?>("MGG_V1_SanctionedAmount",3,
														   -1),
								   new Triplet<string, short, short?>("MGG_V1_Spent",6,
														   -1),
								   new Triplet<string, short, short?>("MGG_V1_YettoReceive",5,
														   -1),
								}
			},
					};	

	

		private Dictionary<string,string> formVersionList =new Dictionary<string,string> 
		{
							{"F7DA2CD7-1723-45E3-94F5-6380EB2F0989", "Medium"},
					};	

		
		private Dictionary<string,string> formVersionLayoutList =new Dictionary<string,string> 
		{
							{"4667EB0E-6B27-4C31-9203-39E625324776", ""},
							{"407523DF-99D3-47D9-A224-4C069C77186D", ""},
							{"F7DA2CD7-1723-45E3-94F5-6380EB2F0989", ""},
							{"1DCFEF6F-457D-4DBD-946F-0FCC24B7CFF2", ""},
							{"D34EED7E-B29F-4092-94B3-D05400283DB9", ""},
							{"BFA9683D-A1D5-486F-A87B-C07E284D0388", ""},
							{"2FD2CC77-9CF7-4EB8-A8F4-9CC29920D63F", ""},
							{"B53BF61F-CCFA-46A8-B11B-62A963F19AFF", ""},
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
		


