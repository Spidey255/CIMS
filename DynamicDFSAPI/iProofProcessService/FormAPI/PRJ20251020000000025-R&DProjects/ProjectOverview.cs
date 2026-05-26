  







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
	  			
			     new Triplet<string, string, string>("F9205722-C6DB-489B-AEA1-E0149EDF9677","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("AC65A516-ABD0-4F7D-9F94-52DC9A70822E","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"062C4298-5FB2-4C83-877D-A1D5795686CF"),
			
						
			     new Triplet<string, string, string>("53C69462-3F16-443A-A733-0EB098A777E7","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"062C4298-5FB2-4C83-877D-A1D5795686CF"),
			
						
			     new Triplet<string, string, string>("EA0673C5-4AB7-4D86-93D5-A45EB0B4CF09","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"062C4298-5FB2-4C83-877D-A1D5795686CF"),
			
						
			     new Triplet<string, string, string>("7A5B1068-C020-4191-8012-E4CB48BFAB15","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"062C4298-5FB2-4C83-877D-A1D5795686CF"),
			
						
			     new Triplet<string, string, string>("29E43B7F-E0D5-4F10-A6DA-CE70CD7B30B4","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"062C4298-5FB2-4C83-877D-A1D5795686CF"),
			
						
			     new Triplet<string, string, string>("108B5BFD-045B-42D7-A031-893FCF404252","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"24F5D845-D560-4FC1-B284-00FB19DFB96F"),
			
						
			     new Triplet<string, string, string>("FC2A5065-A4C2-4EC0-B017-375CE0B0B812","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"24F5D845-D560-4FC1-B284-00FB19DFB96F"),
			
						
			     new Triplet<string, string, string>("108B5BFD-045B-42D7-A031-893FCF404252","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"24F5D845-D560-4FC1-B284-00FB19DFB96F"),
			
						
			     new Triplet<string, string, string>("CA82683B-CA01-4525-A93F-68B518D9FCFA","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"24F5D845-D560-4FC1-B284-00FB19DFB96F"),
			
						
			     new Triplet<string, string, string>("108B5BFD-045B-42D7-A031-893FCF404252","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"24F5D845-D560-4FC1-B284-00FB19DFB96F"),
			
						
			     new Triplet<string, string, string>("A30F7872-734E-4D34-AFDD-D8F49130791A","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"24F5D845-D560-4FC1-B284-00FB19DFB96F"),
			
						
			     new Triplet<string, string, string>("75BF6F61-33D7-4992-9F84-58EC277B2A91","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"062C4298-5FB2-4C83-877D-A1D5795686CF"),
			
						
			     new Triplet<string, string, string>("18598C9A-A3AF-420F-98F1-6A86A67AA8C2","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"062C4298-5FB2-4C83-877D-A1D5795686CF"),
			
						
			     new Triplet<string, string, string>("108B5BFD-045B-42D7-A031-893FCF404252","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"24F5D845-D560-4FC1-B284-00FB19DFB96F"),
			
						
			     new Triplet<string, string, string>("94B9568E-6AA6-4610-9AB9-71682A69C231","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"24F5D845-D560-4FC1-B284-00FB19DFB96F"),
			
						
			     new Triplet<string, string, string>("B1EC4C5B-5119-4C30-B93F-9964463D7C8D","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"062C4298-5FB2-4C83-877D-A1D5795686CF"),
			
						
			     new Triplet<string, string, string>("FC2A5065-A4C2-4EC0-B017-375CE0B0B812","Grid Binding",
												     @"D56A52C8-2D23-4F88-A6D2-148D57FAD218"),
			
						
			     new Triplet<string, string, string>("CA82683B-CA01-4525-A93F-68B518D9FCFA","Grid Binding",
												     @"D8F430EF-D0A1-4887-B0CC-DB94A0BF0D93"),
			
						
			     new Triplet<string, string, string>("A30F7872-734E-4D34-AFDD-D8F49130791A","Grid Binding",
												     @"D20793F2-23FB-4CCE-AB6D-5D14FE42B1B2"),
			
						
			     new Triplet<string, string, string>("94B9568E-6AA6-4610-9AB9-71682A69C231","Grid Binding",
												     @"C5B61F31-1A40-4640-939A-14D8636A8493"),
			
			
			
		};

		
		private List<Triplet<string, string, string>> ComboDataSource = new List<Triplet<string, string, string>>
		{

		
	  			
			     new Triplet<string, string, string>("MF_ExpenseDetails_GridRows","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMAvOzkFMmxHUuxhHgktDkfvWfwBNgoOezuIQDeIjZtCKIIrSN+GjapRg==",
												     @"EXEC [dbo].[SP_GetAutoFormGridRows]"),
			
						
			     new Triplet<string, string, string>("MF_Budgetdetails_GridRows","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMAvOzkFMmxHUuxhHgktDkfvWfwBNgoOezuIQDeIjZtCKIIrSN+GjapRg==",
												     @"EXEC [dbo].[SP_GetAutoFormGridRows]"),
			
						
			     new Triplet<string, string, string>("MF_ReceiptsView_GridRows","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMAvOzkFMmxHUuxhHgktDkfvWfwBNgoOezuIQDeIjZtCKIIrSN+GjapRg==",
												     @"EXEC [dbo].[SP_GetAutoFormGridRows]"),
			
						
			     new Triplet<string, string, string>("MF_ProjectCommitments_GridRows","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMAvOzkFMmxHUuxhHgktDkfvWfwBNgoOezuIQDeIjZtCKIIrSN+GjapRg==",
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
		
	  			
			     new Tuple<string, int>("Budgetdetails",1000),
			
						
			     new Tuple<string, int>("ProjectCommitments",1000),
			
						
			     new Tuple<string, int>("ReceiptsView",1000),
			
						
			     new Tuple<string, int>("ExpenseDetails",1000),
			
						
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

                
                 
                                      case "D56A52C8-2D23-4F88-A6D2-148D57FAD218":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_D56A52C82D234F88A6D2148D57FAD218 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT){0}INSERT INTO [D56A52C8-2D23-4F88-A6D2-148D57FAD218](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence FROM @TBL_D56A52C82D234F88A6D2148D57FAD218 TDT
							LEFT JOIN [D56A52C8-2D23-4F88-A6D2-148D57FAD218] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence FROM @TBL_D56A52C82D234F88A6D2148D57FAD218 TDT
							JOIN [D56A52C8-2D23-4F88-A6D2-148D57FAD218] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence";

                                     tempInsertQuery=@"INSERT INTO @TBL_D56A52C82D234F88A6D2148D57FAD218(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)VALUES({0});";
                                     

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
                     
                                    case "D8F430EF-D0A1-4887-B0CC-DB94A0BF0D93":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_D8F430EFD0A14887B0CCDB94A0BF0D93 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MGG_V1_ExpenseID] VARCHAR(MAX)	, [MGG_V1_PackageProcessMapID] VARCHAR(MAX)	, [MGG_V1_ExpenseDate] DATETIME	, [MGG_V1_AmountSpent] DECIMAL(18,2)	, [MGG_V1_ExpenseDescription] VARCHAR(MAX)){0}INSERT INTO [D8F430EF-D0A1-4887-B0CC-DB94A0BF0D93](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MGG_V1_ExpenseID,MGG_V1_PackageProcessMapID,MGG_V1_ExpenseDate,MGG_V1_AmountSpent,MGG_V1_ExpenseDescription)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MGG_V1_ExpenseID,TDT.MGG_V1_PackageProcessMapID,TDT.MGG_V1_ExpenseDate,TDT.MGG_V1_AmountSpent,TDT.MGG_V1_ExpenseDescription FROM @TBL_D8F430EFD0A14887B0CCDB94A0BF0D93 TDT
							LEFT JOIN [D8F430EF-D0A1-4887-B0CC-DB94A0BF0D93] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MGG_V1_ExpenseID=TDT.MGG_V1_ExpenseID,MGG_V1_PackageProcessMapID=TDT.MGG_V1_PackageProcessMapID,MGG_V1_ExpenseDate=TDT.MGG_V1_ExpenseDate,MGG_V1_AmountSpent=TDT.MGG_V1_AmountSpent,MGG_V1_ExpenseDescription=TDT.MGG_V1_ExpenseDescription FROM @TBL_D8F430EFD0A14887B0CCDB94A0BF0D93 TDT
							JOIN [D8F430EF-D0A1-4887-B0CC-DB94A0BF0D93] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MGG_V1_ExpenseID,MGG_V1_PackageProcessMapID,MGG_V1_ExpenseDate,MGG_V1_AmountSpent,MGG_V1_ExpenseDescription";

                                     tempInsertQuery=@"INSERT INTO @TBL_D8F430EFD0A14887B0CCDB94A0BF0D93(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MGG_V1_ExpenseID,MGG_V1_PackageProcessMapID,MGG_V1_ExpenseDate,MGG_V1_AmountSpent,MGG_V1_ExpenseDescription)VALUES({0});";
                                     

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
                     
                                    case "D20793F2-23FB-4CCE-AB6D-5D14FE42B1B2":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_D20793F223FB4CCEAB6D5D14FE42B1B2 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MGG_V1_BudgetHeadID] VARCHAR(MAX)	, [MGG_V1_ProjectDetailsID] VARCHAR(MAX)	, [MGG_V1_BudgetHead] VARCHAR(MAX)	, [MGG_V1_SanctionedAmount] DECIMAL(18,2)	, [MGG_V1_ReceivedAmount] DECIMAL(18,2)	, [MGG_V1_YettoReceive] DECIMAL(18,2)	, [MGG_V1_Spent] DECIMAL(18,2)	, [MGG_V1_Committment] DECIMAL(18,2)	, [MGG_V1_Balance] DECIMAL(18,2)){0}INSERT INTO [D20793F2-23FB-4CCE-AB6D-5D14FE42B1B2](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MGG_V1_BudgetHeadID,MGG_V1_ProjectDetailsID,MGG_V1_BudgetHead,MGG_V1_SanctionedAmount,MGG_V1_ReceivedAmount,MGG_V1_YettoReceive,MGG_V1_Spent,MGG_V1_Committment,MGG_V1_Balance)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MGG_V1_BudgetHeadID,TDT.MGG_V1_ProjectDetailsID,TDT.MGG_V1_BudgetHead,TDT.MGG_V1_SanctionedAmount,TDT.MGG_V1_ReceivedAmount,TDT.MGG_V1_YettoReceive,TDT.MGG_V1_Spent,TDT.MGG_V1_Committment,TDT.MGG_V1_Balance FROM @TBL_D20793F223FB4CCEAB6D5D14FE42B1B2 TDT
							LEFT JOIN [D20793F2-23FB-4CCE-AB6D-5D14FE42B1B2] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MGG_V1_BudgetHeadID=TDT.MGG_V1_BudgetHeadID,MGG_V1_ProjectDetailsID=TDT.MGG_V1_ProjectDetailsID,MGG_V1_BudgetHead=TDT.MGG_V1_BudgetHead,MGG_V1_SanctionedAmount=TDT.MGG_V1_SanctionedAmount,MGG_V1_ReceivedAmount=TDT.MGG_V1_ReceivedAmount,MGG_V1_YettoReceive=TDT.MGG_V1_YettoReceive,MGG_V1_Spent=TDT.MGG_V1_Spent,MGG_V1_Committment=TDT.MGG_V1_Committment,MGG_V1_Balance=TDT.MGG_V1_Balance FROM @TBL_D20793F223FB4CCEAB6D5D14FE42B1B2 TDT
							JOIN [D20793F2-23FB-4CCE-AB6D-5D14FE42B1B2] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MGG_V1_BudgetHeadID,MGG_V1_ProjectDetailsID,MGG_V1_BudgetHead,MGG_V1_SanctionedAmount,MGG_V1_ReceivedAmount,MGG_V1_YettoReceive,MGG_V1_Spent,MGG_V1_Committment,MGG_V1_Balance";

                                     tempInsertQuery=@"INSERT INTO @TBL_D20793F223FB4CCEAB6D5D14FE42B1B2(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MGG_V1_BudgetHeadID,MGG_V1_ProjectDetailsID,MGG_V1_BudgetHead,MGG_V1_SanctionedAmount,MGG_V1_ReceivedAmount,MGG_V1_YettoReceive,MGG_V1_Spent,MGG_V1_Committment,MGG_V1_Balance)VALUES({0});";
                                     

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
                     
                                    case "C5B61F31-1A40-4640-939A-14D8636A8493":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_C5B61F311A404640939A14D8636A8493 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MGG_P1_ReceiptsId] VARCHAR(MAX)	, [MGG_P1_ProjectDetailsId] VARCHAR(MAX)	, [MGG_P1_ReceiptAmount] DECIMAL(18,2)	, [MGG_P1_ReceiptDate] DATETIME	, [MGG_P1_TransferType] VARCHAR(MAX)	, [MGG_P1_TransferReferenceNumber] VARCHAR(MAX)	, [MGG_P1_TransferReferenceDate] DATETIME	, [MGG_P1_TransferReferenceBankId] VARCHAR(MAX)	, [MGG_P1_TransferReferenceBranch] VARCHAR(MAX)	, [MGG_P1_ReceiptNo] VARCHAR(MAX)){0}INSERT INTO [C5B61F31-1A40-4640-939A-14D8636A8493](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MGG_P1_ReceiptsId,MGG_P1_ProjectDetailsId,MGG_P1_ReceiptAmount,MGG_P1_ReceiptDate,MGG_P1_TransferType,MGG_P1_TransferReferenceNumber,MGG_P1_TransferReferenceDate,MGG_P1_TransferReferenceBankId,MGG_P1_TransferReferenceBranch,MGG_P1_ReceiptNo)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MGG_P1_ReceiptsId,TDT.MGG_P1_ProjectDetailsId,TDT.MGG_P1_ReceiptAmount,TDT.MGG_P1_ReceiptDate,TDT.MGG_P1_TransferType,TDT.MGG_P1_TransferReferenceNumber,TDT.MGG_P1_TransferReferenceDate,TDT.MGG_P1_TransferReferenceBankId,TDT.MGG_P1_TransferReferenceBranch,TDT.MGG_P1_ReceiptNo FROM @TBL_C5B61F311A404640939A14D8636A8493 TDT
							LEFT JOIN [C5B61F31-1A40-4640-939A-14D8636A8493] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MGG_P1_ReceiptsId=TDT.MGG_P1_ReceiptsId,MGG_P1_ProjectDetailsId=TDT.MGG_P1_ProjectDetailsId,MGG_P1_ReceiptAmount=TDT.MGG_P1_ReceiptAmount,MGG_P1_ReceiptDate=TDT.MGG_P1_ReceiptDate,MGG_P1_TransferType=TDT.MGG_P1_TransferType,MGG_P1_TransferReferenceNumber=TDT.MGG_P1_TransferReferenceNumber,MGG_P1_TransferReferenceDate=TDT.MGG_P1_TransferReferenceDate,MGG_P1_TransferReferenceBankId=TDT.MGG_P1_TransferReferenceBankId,MGG_P1_TransferReferenceBranch=TDT.MGG_P1_TransferReferenceBranch,MGG_P1_ReceiptNo=TDT.MGG_P1_ReceiptNo FROM @TBL_C5B61F311A404640939A14D8636A8493 TDT
							JOIN [C5B61F31-1A40-4640-939A-14D8636A8493] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MGG_P1_ReceiptsId,MGG_P1_ProjectDetailsId,MGG_P1_ReceiptAmount,MGG_P1_ReceiptDate,MGG_P1_TransferType,MGG_P1_TransferReferenceNumber,MGG_P1_TransferReferenceDate,MGG_P1_TransferReferenceBankId,MGG_P1_TransferReferenceBranch,MGG_P1_ReceiptNo";

                                     tempInsertQuery=@"INSERT INTO @TBL_C5B61F311A404640939A14D8636A8493(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MGG_P1_ReceiptsId,MGG_P1_ProjectDetailsId,MGG_P1_ReceiptAmount,MGG_P1_ReceiptDate,MGG_P1_TransferType,MGG_P1_TransferReferenceNumber,MGG_P1_TransferReferenceDate,MGG_P1_TransferReferenceBankId,MGG_P1_TransferReferenceBranch,MGG_P1_ReceiptNo)VALUES({0});";
                                     

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
                     

                                         case "D56A52C8-2D23-4F88-A6D2-148D57FAD218":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_D56A52C82D234F88A6D2148D57FAD218 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT){0}INSERT INTO [D56A52C8-2D23-4F88-A6D2-148D57FAD218](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence FROM @TBL_D56A52C82D234F88A6D2148D57FAD218 TDT
							LEFT JOIN [D56A52C8-2D23-4F88-A6D2-148D57FAD218] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence FROM @TBL_D56A52C82D234F88A6D2148D57FAD218 TDT
							JOIN [D56A52C8-2D23-4F88-A6D2-148D57FAD218] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence";

                            tempInsertQuery=@"INSERT INTO @TBL_D56A52C82D234F88A6D2148D57FAD218(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)VALUES({0});";

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

                                              case "D8F430EF-D0A1-4887-B0CC-DB94A0BF0D93":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_D8F430EFD0A14887B0CCDB94A0BF0D93 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MGG_V1_ExpenseID] VARCHAR(MAX)	, [MGG_V1_PackageProcessMapID] VARCHAR(MAX)	, [MGG_V1_ExpenseDate] DATETIME	, [MGG_V1_AmountSpent] DECIMAL(18,2)	, [MGG_V1_ExpenseDescription] VARCHAR(MAX)){0}INSERT INTO [D8F430EF-D0A1-4887-B0CC-DB94A0BF0D93](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MGG_V1_ExpenseID,MGG_V1_PackageProcessMapID,MGG_V1_ExpenseDate,MGG_V1_AmountSpent,MGG_V1_ExpenseDescription)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MGG_V1_ExpenseID,TDT.MGG_V1_PackageProcessMapID,TDT.MGG_V1_ExpenseDate,TDT.MGG_V1_AmountSpent,TDT.MGG_V1_ExpenseDescription FROM @TBL_D8F430EFD0A14887B0CCDB94A0BF0D93 TDT
							LEFT JOIN [D8F430EF-D0A1-4887-B0CC-DB94A0BF0D93] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MGG_V1_ExpenseID=TDT.MGG_V1_ExpenseID,MGG_V1_PackageProcessMapID=TDT.MGG_V1_PackageProcessMapID,MGG_V1_ExpenseDate=TDT.MGG_V1_ExpenseDate,MGG_V1_AmountSpent=TDT.MGG_V1_AmountSpent,MGG_V1_ExpenseDescription=TDT.MGG_V1_ExpenseDescription FROM @TBL_D8F430EFD0A14887B0CCDB94A0BF0D93 TDT
							JOIN [D8F430EF-D0A1-4887-B0CC-DB94A0BF0D93] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MGG_V1_ExpenseID,MGG_V1_PackageProcessMapID,MGG_V1_ExpenseDate,MGG_V1_AmountSpent,MGG_V1_ExpenseDescription";

                            tempInsertQuery=@"INSERT INTO @TBL_D8F430EFD0A14887B0CCDB94A0BF0D93(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MGG_V1_ExpenseID,MGG_V1_PackageProcessMapID,MGG_V1_ExpenseDate,MGG_V1_AmountSpent,MGG_V1_ExpenseDescription)VALUES({0});";

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

                                              case "D20793F2-23FB-4CCE-AB6D-5D14FE42B1B2":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_D20793F223FB4CCEAB6D5D14FE42B1B2 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MGG_V1_BudgetHeadID] VARCHAR(MAX)	, [MGG_V1_ProjectDetailsID] VARCHAR(MAX)	, [MGG_V1_BudgetHead] VARCHAR(MAX)	, [MGG_V1_SanctionedAmount] DECIMAL(18,2)	, [MGG_V1_ReceivedAmount] DECIMAL(18,2)	, [MGG_V1_YettoReceive] DECIMAL(18,2)	, [MGG_V1_Spent] DECIMAL(18,2)	, [MGG_V1_Committment] DECIMAL(18,2)	, [MGG_V1_Balance] DECIMAL(18,2)){0}INSERT INTO [D20793F2-23FB-4CCE-AB6D-5D14FE42B1B2](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MGG_V1_BudgetHeadID,MGG_V1_ProjectDetailsID,MGG_V1_BudgetHead,MGG_V1_SanctionedAmount,MGG_V1_ReceivedAmount,MGG_V1_YettoReceive,MGG_V1_Spent,MGG_V1_Committment,MGG_V1_Balance)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MGG_V1_BudgetHeadID,TDT.MGG_V1_ProjectDetailsID,TDT.MGG_V1_BudgetHead,TDT.MGG_V1_SanctionedAmount,TDT.MGG_V1_ReceivedAmount,TDT.MGG_V1_YettoReceive,TDT.MGG_V1_Spent,TDT.MGG_V1_Committment,TDT.MGG_V1_Balance FROM @TBL_D20793F223FB4CCEAB6D5D14FE42B1B2 TDT
							LEFT JOIN [D20793F2-23FB-4CCE-AB6D-5D14FE42B1B2] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MGG_V1_BudgetHeadID=TDT.MGG_V1_BudgetHeadID,MGG_V1_ProjectDetailsID=TDT.MGG_V1_ProjectDetailsID,MGG_V1_BudgetHead=TDT.MGG_V1_BudgetHead,MGG_V1_SanctionedAmount=TDT.MGG_V1_SanctionedAmount,MGG_V1_ReceivedAmount=TDT.MGG_V1_ReceivedAmount,MGG_V1_YettoReceive=TDT.MGG_V1_YettoReceive,MGG_V1_Spent=TDT.MGG_V1_Spent,MGG_V1_Committment=TDT.MGG_V1_Committment,MGG_V1_Balance=TDT.MGG_V1_Balance FROM @TBL_D20793F223FB4CCEAB6D5D14FE42B1B2 TDT
							JOIN [D20793F2-23FB-4CCE-AB6D-5D14FE42B1B2] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MGG_V1_BudgetHeadID,MGG_V1_ProjectDetailsID,MGG_V1_BudgetHead,MGG_V1_SanctionedAmount,MGG_V1_ReceivedAmount,MGG_V1_YettoReceive,MGG_V1_Spent,MGG_V1_Committment,MGG_V1_Balance";

                            tempInsertQuery=@"INSERT INTO @TBL_D20793F223FB4CCEAB6D5D14FE42B1B2(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MGG_V1_BudgetHeadID,MGG_V1_ProjectDetailsID,MGG_V1_BudgetHead,MGG_V1_SanctionedAmount,MGG_V1_ReceivedAmount,MGG_V1_YettoReceive,MGG_V1_Spent,MGG_V1_Committment,MGG_V1_Balance)VALUES({0});";

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

                                              case "C5B61F31-1A40-4640-939A-14D8636A8493":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_C5B61F311A404640939A14D8636A8493 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MGG_P1_ReceiptsId] VARCHAR(MAX)	, [MGG_P1_ProjectDetailsId] VARCHAR(MAX)	, [MGG_P1_ReceiptAmount] DECIMAL(18,2)	, [MGG_P1_ReceiptDate] DATETIME	, [MGG_P1_TransferType] VARCHAR(MAX)	, [MGG_P1_TransferReferenceNumber] VARCHAR(MAX)	, [MGG_P1_TransferReferenceDate] DATETIME	, [MGG_P1_TransferReferenceBankId] VARCHAR(MAX)	, [MGG_P1_TransferReferenceBranch] VARCHAR(MAX)	, [MGG_P1_ReceiptNo] VARCHAR(MAX)){0}INSERT INTO [C5B61F31-1A40-4640-939A-14D8636A8493](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MGG_P1_ReceiptsId,MGG_P1_ProjectDetailsId,MGG_P1_ReceiptAmount,MGG_P1_ReceiptDate,MGG_P1_TransferType,MGG_P1_TransferReferenceNumber,MGG_P1_TransferReferenceDate,MGG_P1_TransferReferenceBankId,MGG_P1_TransferReferenceBranch,MGG_P1_ReceiptNo)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MGG_P1_ReceiptsId,TDT.MGG_P1_ProjectDetailsId,TDT.MGG_P1_ReceiptAmount,TDT.MGG_P1_ReceiptDate,TDT.MGG_P1_TransferType,TDT.MGG_P1_TransferReferenceNumber,TDT.MGG_P1_TransferReferenceDate,TDT.MGG_P1_TransferReferenceBankId,TDT.MGG_P1_TransferReferenceBranch,TDT.MGG_P1_ReceiptNo FROM @TBL_C5B61F311A404640939A14D8636A8493 TDT
							LEFT JOIN [C5B61F31-1A40-4640-939A-14D8636A8493] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MGG_P1_ReceiptsId=TDT.MGG_P1_ReceiptsId,MGG_P1_ProjectDetailsId=TDT.MGG_P1_ProjectDetailsId,MGG_P1_ReceiptAmount=TDT.MGG_P1_ReceiptAmount,MGG_P1_ReceiptDate=TDT.MGG_P1_ReceiptDate,MGG_P1_TransferType=TDT.MGG_P1_TransferType,MGG_P1_TransferReferenceNumber=TDT.MGG_P1_TransferReferenceNumber,MGG_P1_TransferReferenceDate=TDT.MGG_P1_TransferReferenceDate,MGG_P1_TransferReferenceBankId=TDT.MGG_P1_TransferReferenceBankId,MGG_P1_TransferReferenceBranch=TDT.MGG_P1_TransferReferenceBranch,MGG_P1_ReceiptNo=TDT.MGG_P1_ReceiptNo FROM @TBL_C5B61F311A404640939A14D8636A8493 TDT
							JOIN [C5B61F31-1A40-4640-939A-14D8636A8493] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MGG_P1_ReceiptsId,MGG_P1_ProjectDetailsId,MGG_P1_ReceiptAmount,MGG_P1_ReceiptDate,MGG_P1_TransferType,MGG_P1_TransferReferenceNumber,MGG_P1_TransferReferenceDate,MGG_P1_TransferReferenceBankId,MGG_P1_TransferReferenceBranch,MGG_P1_ReceiptNo";

                            tempInsertQuery=@"INSERT INTO @TBL_C5B61F311A404640939A14D8636A8493(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MGG_P1_ReceiptsId,MGG_P1_ProjectDetailsId,MGG_P1_ReceiptAmount,MGG_P1_ReceiptDate,MGG_P1_TransferType,MGG_P1_TransferReferenceNumber,MGG_P1_TransferReferenceDate,MGG_P1_TransferReferenceBankId,MGG_P1_TransferReferenceBranch,MGG_P1_ReceiptNo)VALUES({0});";

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

var querySourceF9205722C6DB489BAEA1E0149EDF9677 =GetQueryExpressionDataSource("F9205722-C6DB-489B-AEA1-E0149EDF9677");
Dictionary<short,object> resultF9205722C6DB489BAEA1E0149EDF9677=iSpace.ExecuteQuery(querySourceF9205722C6DB489BAEA1E0149EDF9677,@"EXEC GetSponsoredProjectDetails '" + ISpace["F_ProjectDetailsId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceF9205722C6DB489BAEA1E0149EDF9677 =GetQueryExpressionDataSource(""F9205722-C6DB-489B-AEA1-E0149EDF9677"");Dictionary<short,object> resultF9205722C6DB489BAEA1E0149EDF9677=iSpace.ExecuteQuery(querySourceF9205722C6DB489BAEA1E0149EDF9677,@""EXEC GetSponsoredProjectDetails '"" + ISpace[""F_ProjectDetailsId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultF9205722C6DB489BAEA1E0149EDF9677!=null) && (resultF9205722C6DB489BAEA1E0149EDF9677.Count!=0))
{
if(resultF9205722C6DB489BAEA1E0149EDF9677.ContainsKey(4))
ISpace["FC_StartDate"].Value = resultF9205722C6DB489BAEA1E0149EDF9677[4];
if(resultF9205722C6DB489BAEA1E0149EDF9677.ContainsKey(5))
ISpace["FC_EndDate"].Value = resultF9205722C6DB489BAEA1E0149EDF9677[5];
if(resultF9205722C6DB489BAEA1E0149EDF9677.ContainsKey(8))
ISpace["FC_SanctionedDate"].Value = resultF9205722C6DB489BAEA1E0149EDF9677[8];
if(resultF9205722C6DB489BAEA1E0149EDF9677.ContainsKey(3))
ISpace["FC_ProjectName"].Value = resultF9205722C6DB489BAEA1E0149EDF9677[3];
if(resultF9205722C6DB489BAEA1E0149EDF9677.ContainsKey(2))
ISpace["FC_AgencyCode"].Value = resultF9205722C6DB489BAEA1E0149EDF9677[2];
if(resultF9205722C6DB489BAEA1E0149EDF9677.ContainsKey(10))
ISpace["FC_SanctionedValue"].Value = resultF9205722C6DB489BAEA1E0149EDF9677[10];
if(resultF9205722C6DB489BAEA1E0149EDF9677.ContainsKey(7))
ISpace["FC_SanctionNo"].Value = resultF9205722C6DB489BAEA1E0149EDF9677[7];
if(resultF9205722C6DB489BAEA1E0149EDF9677.ContainsKey(14))
ISpace["FC_Category"].Value = resultF9205722C6DB489BAEA1E0149EDF9677[14];
if(resultF9205722C6DB489BAEA1E0149EDF9677.ContainsKey(1))
ISpace["FC_ProjectNo"].Value = resultF9205722C6DB489BAEA1E0149EDF9677[1];
}
else{
ISpace["FC_StartDate"].Value = null;ISpace["FC_EndDate"].Value = null;ISpace["FC_SanctionedDate"].Value = null;ISpace["FC_ProjectName"].Value = null;ISpace["FC_AgencyCode"].Value = null;ISpace["FC_SanctionedValue"].Value = null;ISpace["FC_SanctionNo"].Value = null;ISpace["FC_Category"].Value = null;ISpace["FC_ProjectNo"].Value = null;
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
ISpace["UI_GridPanelthree"].Visible="true";ISpace["UI_GridPanelthree"].Enbl="true";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""F7DA2CD7-1723-45E3-94F5-6380EB2F0989"")
{
ISpace[""UI_GridPanelthree""].Visible=""true"";ISpace[""UI_GridPanelthree""].Enbl=""true"";
}");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["FormVersionId"].Value=="F7DA2CD7-1723-45E3-94F5-6380EB2F0989")
{
ISpace["UI_SearchPanel"].Visible="true";ISpace["UI_SearchPanel"].Enbl="true";
}if(ISpace["FormVersionId"].Value=="F7DA2CD7-1723-45E3-94F5-6380EB2F0989")
{
ISpace["UI_GridPanelTwo"].Visible="true";ISpace["UI_GridPanelTwo"].Enbl="true";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""F7DA2CD7-1723-45E3-94F5-6380EB2F0989"")
{
ISpace[""UI_SearchPanel""].Visible=""true"";ISpace[""UI_SearchPanel""].Enbl=""true"";
}if(ISpace[""FormVersionId""].Value==""F7DA2CD7-1723-45E3-94F5-6380EB2F0989"")
{
ISpace[""UI_GridPanelTwo""].Visible=""true"";ISpace[""UI_GridPanelTwo""].Enbl=""true"";
}");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["FormVersionId"].Value=="F7DA2CD7-1723-45E3-94F5-6380EB2F0989")
{
ISpace["UI_GridPanelOne"].Visible="true";ISpace["UI_GridPanelOne"].Enbl="true";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""F7DA2CD7-1723-45E3-94F5-6380EB2F0989"")
{
ISpace[""UI_GridPanelOne""].Visible=""true"";ISpace[""UI_GridPanelOne""].Enbl=""true"";
}");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["FormVersionId"].Value=="F7DA2CD7-1723-45E3-94F5-6380EB2F0989")
{
ISpace["UI_GridPanel"].Visible="true";ISpace["UI_GridPanel"].Enbl="true";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""F7DA2CD7-1723-45E3-94F5-6380EB2F0989"")
{
ISpace[""UI_GridPanel""].Visible=""true"";ISpace[""UI_GridPanel""].Enbl=""true"";
}");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySourceFC2A5065A4C24EC0B017375CE0B0B812 =GetQueryExpressionDataSource("FC2A5065-A4C2-4EC0-B017-375CE0B0B812");

DataTable resultFC2A5065A4C24EC0B017375CE0B0B812=iSpace.SetGridDataSource(querySourceFC2A5065A4C24EC0B017375CE0B0B812, _objectFactory.GetGridRPP("ExpenseDetails"),@"EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 1,'" + ISpace["F_ProjectDetailsId"].Value + @"',''," + ISpace["MF_ExpenseDetails_PageIndex"].Value + @",'" + ISpace["MF_ExpenseDetails_GridRows"].Value + @"'");

iSpace.InsertGridBindDetails("ExpenseDetails","11",querySourceFC2A5065A4C24EC0B017375CE0B0B812,"EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 1,'" + ISpace["F_ProjectDetailsId"].Value + @"',''," + ISpace["MF_ExpenseDetails_PageIndex"].Value + @",'" + ISpace["MF_ExpenseDetails_GridRows"].Value + @"'",_objectFactory.GetGridRPP("ExpenseDetails"));

base.WriteDebugInfo(@"var querySourceFC2A5065A4C24EC0B017375CE0B0B812 =GetQueryExpressionDataSource(""FC2A5065-A4C2-4EC0-B017-375CE0B0B812"");DataTable resultFC2A5065A4C24EC0B017375CE0B0B812=iSpace.SetGridDataSource(querySourceFC2A5065A4C24EC0B017375CE0B0B812, _objectFactory.GetGridRPP(""ExpenseDetails""),@""EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 1,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',"" + ISpace[""MF_ExpenseDetails_PageIndex""].Value + @"",'"" + ISpace[""MF_ExpenseDetails_GridRows""].Value + @""'"");iSpace.InsertGridBindDetails(""ExpenseDetails"",""11"",querySourceFC2A5065A4C24EC0B017375CE0B0B812,""EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 1,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',"" + ISpace[""MF_ExpenseDetails_PageIndex""].Value + @"",'"" + ISpace[""MF_ExpenseDetails_GridRows""].Value + @""'"",_objectFactory.GetGridRPP(""ExpenseDetails""));");
base.WriteDebugInfo(@"EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 1,'#F_ExpenseId','',#MF_ExpenseDetails_PageIndex,'#MF_ExpenseDetails_GridRows'");


List<Triplet<string, short, short?>> resultF156A8611F4D43F2884E90DD3F9E66E3=acdataIspace585BA2B83E754DABB50B10D8320CE414.GetQueryExpressionBindings("F156A861-1F4D-43F2-884E-90DD3F9E66E3");
iSpace.SetGridData(resultFC2A5065A4C24EC0B017375CE0B0B812,resultF156A8611F4D43F2884E90DD3F9E66E3,"ExpenseDetails",ref ISpace);
iSpace.UpdateGridBindDetails("ExpenseDetails",resultF156A8611F4D43F2884E90DD3F9E66E3);
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySource94B9568E6AA646109AB971682A69C231 =GetQueryExpressionDataSource("94B9568E-6AA6-4610-9AB9-71682A69C231");

DataTable result94B9568E6AA646109AB971682A69C231=iSpace.SetGridDataSource(querySource94B9568E6AA646109AB971682A69C231, _objectFactory.GetGridRPP("ReceiptsView"),@"EXEC dbo.[Get_bd3abae8-b5a2-4b71-b3e2-e46732479592_FilterData] 1,'" + ISpace["F_ReceiptNo"].Value + @"',''," + ISpace["MF_ReceiptsView_PageIndex"].Value + @",'" + ISpace["MF_ReceiptsView_GridRows"].Value + @"','" + ISpace["F_ProjectDetailsID"].Value + @"'");

iSpace.InsertGridBindDetails("ReceiptsView","11",querySource94B9568E6AA646109AB971682A69C231,"EXEC dbo.[Get_bd3abae8-b5a2-4b71-b3e2-e46732479592_FilterData] 1,'" + ISpace["F_ReceiptNo"].Value + @"',''," + ISpace["MF_ReceiptsView_PageIndex"].Value + @",'" + ISpace["MF_ReceiptsView_GridRows"].Value + @"','" + ISpace["F_ProjectDetailsID"].Value + @"'",_objectFactory.GetGridRPP("ReceiptsView"));

base.WriteDebugInfo(@"var querySource94B9568E6AA646109AB971682A69C231 =GetQueryExpressionDataSource(""94B9568E-6AA6-4610-9AB9-71682A69C231"");DataTable result94B9568E6AA646109AB971682A69C231=iSpace.SetGridDataSource(querySource94B9568E6AA646109AB971682A69C231, _objectFactory.GetGridRPP(""ReceiptsView""),@""EXEC dbo.[Get_bd3abae8-b5a2-4b71-b3e2-e46732479592_FilterData] 1,'"" + ISpace[""F_ReceiptNo""].Value + @""','',"" + ISpace[""MF_ReceiptsView_PageIndex""].Value + @"",'"" + ISpace[""MF_ReceiptsView_GridRows""].Value + @""','"" + ISpace[""F_ProjectDetailsID""].Value + @""'"");iSpace.InsertGridBindDetails(""ReceiptsView"",""11"",querySource94B9568E6AA646109AB971682A69C231,""EXEC dbo.[Get_bd3abae8-b5a2-4b71-b3e2-e46732479592_FilterData] 1,'"" + ISpace[""F_ReceiptNo""].Value + @""','',"" + ISpace[""MF_ReceiptsView_PageIndex""].Value + @"",'"" + ISpace[""MF_ReceiptsView_GridRows""].Value + @""','"" + ISpace[""F_ProjectDetailsID""].Value + @""'"",_objectFactory.GetGridRPP(""ReceiptsView""));");
base.WriteDebugInfo(@"EXEC dbo.[Get_bd3abae8-b5a2-4b71-b3e2-e46732479592_FilterData] 1,'#F_ReceiptNo','',#MF_ReceiptsView_PageIndex,'#MF_ReceiptsView_GridRows'");


List<Triplet<string, short, short?>> result6C0E534F5B5649E8BDBDB1A399E4F9C5=acdataIspace585BA2B83E754DABB50B10D8320CE414.GetQueryExpressionBindings("6C0E534F-5B56-49E8-BDBD-B1A399E4F9C5");
iSpace.SetGridData(result94B9568E6AA646109AB971682A69C231,result6C0E534F5B5649E8BDBDB1A399E4F9C5,"ReceiptsView",ref ISpace);
iSpace.UpdateGridBindDetails("ReceiptsView",result6C0E534F5B5649E8BDBDB1A399E4F9C5);
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySourceCA82683BCA014525A93F68B518D9FCFA =GetQueryExpressionDataSource("CA82683B-CA01-4525-A93F-68B518D9FCFA");

DataTable resultCA82683BCA014525A93F68B518D9FCFA=iSpace.SetGridDataSource(querySourceCA82683BCA014525A93F68B518D9FCFA, _objectFactory.GetGridRPP("ProjectCommitments"),@"EXEC dbo.[Get_e046fb44-e1f1-4f2a-a07e-231e72f92166_FilterData] 1,'" + ISpace["F_ProjectDetailsId"].Value + @"',''," + ISpace["MF_ProjectCommitments_PageIndex"].Value + @",'" + ISpace["MF_ProjectCommitments_GridRows"].Value + @"'");

iSpace.InsertGridBindDetails("ProjectCommitments","11",querySourceCA82683BCA014525A93F68B518D9FCFA,"EXEC dbo.[Get_e046fb44-e1f1-4f2a-a07e-231e72f92166_FilterData] 1,'" + ISpace["F_ProjectDetailsId"].Value + @"',''," + ISpace["MF_ProjectCommitments_PageIndex"].Value + @",'" + ISpace["MF_ProjectCommitments_GridRows"].Value + @"'",_objectFactory.GetGridRPP("ProjectCommitments"));

base.WriteDebugInfo(@"var querySourceCA82683BCA014525A93F68B518D9FCFA =GetQueryExpressionDataSource(""CA82683B-CA01-4525-A93F-68B518D9FCFA"");DataTable resultCA82683BCA014525A93F68B518D9FCFA=iSpace.SetGridDataSource(querySourceCA82683BCA014525A93F68B518D9FCFA, _objectFactory.GetGridRPP(""ProjectCommitments""),@""EXEC dbo.[Get_e046fb44-e1f1-4f2a-a07e-231e72f92166_FilterData] 1,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',"" + ISpace[""MF_ProjectCommitments_PageIndex""].Value + @"",'"" + ISpace[""MF_ProjectCommitments_GridRows""].Value + @""'"");iSpace.InsertGridBindDetails(""ProjectCommitments"",""11"",querySourceCA82683BCA014525A93F68B518D9FCFA,""EXEC dbo.[Get_e046fb44-e1f1-4f2a-a07e-231e72f92166_FilterData] 1,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',"" + ISpace[""MF_ProjectCommitments_PageIndex""].Value + @"",'"" + ISpace[""MF_ProjectCommitments_GridRows""].Value + @""'"",_objectFactory.GetGridRPP(""ProjectCommitments""));");
base.WriteDebugInfo(@"EXEC dbo.[Get_e046fb44-e1f1-4f2a-a07e-231e72f92166_FilterData] 1,'#F_ProjectDetailsId','',#MF_ProjectCommitments_PageIndex,'#MF_ProjectCommitments_GridRows'");


List<Triplet<string, short, short?>> resultF24D61150F9946679299168E58B151A1=acdataIspace585BA2B83E754DABB50B10D8320CE414.GetQueryExpressionBindings("F24D6115-0F99-4667-9299-168E58B151A1");
iSpace.SetGridData(resultCA82683BCA014525A93F68B518D9FCFA,resultF24D61150F9946679299168E58B151A1,"ProjectCommitments",ref ISpace);
iSpace.UpdateGridBindDetails("ProjectCommitments",resultF24D61150F9946679299168E58B151A1);
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'#F_ProjectDetailsId','',#MF_ExpenseDetails_PageIndex,'#MF_ExpenseDetails_GridRows'");

var querySource108B5BFD045B42D7A031893FCF404252 =GetQueryExpressionDataSource("108B5BFD-045B-42D7-A031-893FCF404252");
Dictionary<short,object> result108B5BFD045B42D7A031893FCF404252=iSpace.ExecuteQuery(querySource108B5BFD045B42D7A031893FCF404252,@"EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'" + ISpace["F_ProjectDetailsId"].Value + @"',''," + ISpace["MF_ExpenseDetails_PageIndex"].Value + @",'" + ISpace["MF_ExpenseDetails_GridRows"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource108B5BFD045B42D7A031893FCF404252 =GetQueryExpressionDataSource(""108B5BFD-045B-42D7-A031-893FCF404252"");Dictionary<short,object> result108B5BFD045B42D7A031893FCF404252=iSpace.ExecuteQuery(querySource108B5BFD045B42D7A031893FCF404252,@""EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',"" + ISpace[""MF_ExpenseDetails_PageIndex""].Value + @"",'"" + ISpace[""MF_ExpenseDetails_GridRows""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result108B5BFD045B42D7A031893FCF404252!=null) && (result108B5BFD045B42D7A031893FCF404252.Count!=0))
{
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(0))
ISpace["MF_Budgetdetails_GridRows"].Value = result108B5BFD045B42D7A031893FCF404252[0];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(3))
ISpace["MF_Budgetdetails_TotalPages"].Value = result108B5BFD045B42D7A031893FCF404252[3];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(2))
ISpace["MF_Budgetdetails_PageIndex"].Value = result108B5BFD045B42D7A031893FCF404252[2];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(1))
ISpace["MF_Budgetdetails_RecordsRange"].Value = result108B5BFD045B42D7A031893FCF404252[1];
}
else{
ISpace["MF_Budgetdetails_GridRows"].Value = null;ISpace["MF_Budgetdetails_TotalPages"].Value = null;ISpace["MF_Budgetdetails_PageIndex"].Value = null;ISpace["MF_Budgetdetails_RecordsRange"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'#F_ProjectDetailsId','',#MF_ExpenseDetails_PageIndex,'#MF_ExpenseDetails_GridRows'");

var querySource108B5BFD045B42D7A031893FCF404252 =GetQueryExpressionDataSource("108B5BFD-045B-42D7-A031-893FCF404252");
Dictionary<short,object> result108B5BFD045B42D7A031893FCF404252=iSpace.ExecuteQuery(querySource108B5BFD045B42D7A031893FCF404252,@"EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'" + ISpace["F_ProjectDetailsId"].Value + @"',''," + ISpace["MF_ExpenseDetails_PageIndex"].Value + @",'" + ISpace["MF_ExpenseDetails_GridRows"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource108B5BFD045B42D7A031893FCF404252 =GetQueryExpressionDataSource(""108B5BFD-045B-42D7-A031-893FCF404252"");Dictionary<short,object> result108B5BFD045B42D7A031893FCF404252=iSpace.ExecuteQuery(querySource108B5BFD045B42D7A031893FCF404252,@""EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',"" + ISpace[""MF_ExpenseDetails_PageIndex""].Value + @"",'"" + ISpace[""MF_ExpenseDetails_GridRows""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result108B5BFD045B42D7A031893FCF404252!=null) && (result108B5BFD045B42D7A031893FCF404252.Count!=0))
{
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(0))
ISpace["MF_Budgetdetails_GridRows"].Value = result108B5BFD045B42D7A031893FCF404252[0];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(3))
ISpace["MF_Budgetdetails_TotalPages"].Value = result108B5BFD045B42D7A031893FCF404252[3];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(2))
ISpace["MF_Budgetdetails_PageIndex"].Value = result108B5BFD045B42D7A031893FCF404252[2];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(1))
ISpace["MF_Budgetdetails_RecordsRange"].Value = result108B5BFD045B42D7A031893FCF404252[1];
}
else{
ISpace["MF_Budgetdetails_GridRows"].Value = null;ISpace["MF_Budgetdetails_TotalPages"].Value = null;ISpace["MF_Budgetdetails_PageIndex"].Value = null;ISpace["MF_Budgetdetails_RecordsRange"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'#F_ProjectDetailsId','',#MF_ExpenseDetails_PageIndex,'#MF_ExpenseDetails_GridRows'");

var querySource108B5BFD045B42D7A031893FCF404252 =GetQueryExpressionDataSource("108B5BFD-045B-42D7-A031-893FCF404252");
Dictionary<short,object> result108B5BFD045B42D7A031893FCF404252=iSpace.ExecuteQuery(querySource108B5BFD045B42D7A031893FCF404252,@"EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'" + ISpace["F_ProjectDetailsId"].Value + @"',''," + ISpace["MF_ExpenseDetails_PageIndex"].Value + @",'" + ISpace["MF_ExpenseDetails_GridRows"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource108B5BFD045B42D7A031893FCF404252 =GetQueryExpressionDataSource(""108B5BFD-045B-42D7-A031-893FCF404252"");Dictionary<short,object> result108B5BFD045B42D7A031893FCF404252=iSpace.ExecuteQuery(querySource108B5BFD045B42D7A031893FCF404252,@""EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',"" + ISpace[""MF_ExpenseDetails_PageIndex""].Value + @"",'"" + ISpace[""MF_ExpenseDetails_GridRows""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result108B5BFD045B42D7A031893FCF404252!=null) && (result108B5BFD045B42D7A031893FCF404252.Count!=0))
{
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(0))
ISpace["MF_Budgetdetails_GridRows"].Value = result108B5BFD045B42D7A031893FCF404252[0];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(3))
ISpace["MF_Budgetdetails_TotalPages"].Value = result108B5BFD045B42D7A031893FCF404252[3];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(2))
ISpace["MF_Budgetdetails_PageIndex"].Value = result108B5BFD045B42D7A031893FCF404252[2];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(1))
ISpace["MF_Budgetdetails_RecordsRange"].Value = result108B5BFD045B42D7A031893FCF404252[1];
}
else{
ISpace["MF_Budgetdetails_GridRows"].Value = null;ISpace["MF_Budgetdetails_TotalPages"].Value = null;ISpace["MF_Budgetdetails_PageIndex"].Value = null;ISpace["MF_Budgetdetails_RecordsRange"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'#F_ProjectDetailsId','',#MF_ExpenseDetails_PageIndex,'#MF_ExpenseDetails_GridRows'");

var querySource108B5BFD045B42D7A031893FCF404252 =GetQueryExpressionDataSource("108B5BFD-045B-42D7-A031-893FCF404252");
Dictionary<short,object> result108B5BFD045B42D7A031893FCF404252=iSpace.ExecuteQuery(querySource108B5BFD045B42D7A031893FCF404252,@"EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'" + ISpace["F_ProjectDetailsId"].Value + @"',''," + ISpace["MF_ExpenseDetails_PageIndex"].Value + @",'" + ISpace["MF_ExpenseDetails_GridRows"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource108B5BFD045B42D7A031893FCF404252 =GetQueryExpressionDataSource(""108B5BFD-045B-42D7-A031-893FCF404252"");Dictionary<short,object> result108B5BFD045B42D7A031893FCF404252=iSpace.ExecuteQuery(querySource108B5BFD045B42D7A031893FCF404252,@""EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',"" + ISpace[""MF_ExpenseDetails_PageIndex""].Value + @"",'"" + ISpace[""MF_ExpenseDetails_GridRows""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result108B5BFD045B42D7A031893FCF404252!=null) && (result108B5BFD045B42D7A031893FCF404252.Count!=0))
{
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(0))
ISpace["MF_Budgetdetails_GridRows"].Value = result108B5BFD045B42D7A031893FCF404252[0];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(3))
ISpace["MF_Budgetdetails_TotalPages"].Value = result108B5BFD045B42D7A031893FCF404252[3];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(2))
ISpace["MF_Budgetdetails_PageIndex"].Value = result108B5BFD045B42D7A031893FCF404252[2];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(1))
ISpace["MF_Budgetdetails_RecordsRange"].Value = result108B5BFD045B42D7A031893FCF404252[1];
}
else{
ISpace["MF_Budgetdetails_GridRows"].Value = null;ISpace["MF_Budgetdetails_TotalPages"].Value = null;ISpace["MF_Budgetdetails_PageIndex"].Value = null;ISpace["MF_Budgetdetails_RecordsRange"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==1)");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==ISpace["MF_ExpenseDetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==ISpace[""MF_ExpenseDetails_TotalPages""].Value)");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="false";ISpace["MF_Budgetdetails_LastButton"].Enbl="false";ISpace["MF_Budgetdetails_NextButton"].Enbl="false";ISpace["MF_Budgetdetails_FirstButton"].Enbl="false";ISpace["MF_Budgetdetails_PageIndex"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""false"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="false";ISpace["MF_Budgetdetails_LastButton"].Enbl="true";ISpace["MF_Budgetdetails_NextButton"].Enbl="true";ISpace["MF_Budgetdetails_FirstButton"].Enbl="false";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
}
else
{
base.WriteDebugInfo(@"else");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==ISpace["MF_ExpenseDetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==ISpace[""MF_ExpenseDetails_TotalPages""].Value)");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="true";ISpace["MF_Budgetdetails_LastButton"].Enbl="false";ISpace["MF_Budgetdetails_NextButton"].Enbl="false";ISpace["MF_Budgetdetails_FirstButton"].Enbl="true";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="true";ISpace["MF_Budgetdetails_LastButton"].Enbl="true";ISpace["MF_Budgetdetails_NextButton"].Enbl="true";ISpace["MF_Budgetdetails_FirstButton"].Enbl="true";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==1)");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==ISpace["MF_ExpenseDetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==ISpace[""MF_ExpenseDetails_TotalPages""].Value)");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="false";ISpace["MF_Budgetdetails_LastButton"].Enbl="false";ISpace["MF_Budgetdetails_NextButton"].Enbl="false";ISpace["MF_Budgetdetails_FirstButton"].Enbl="false";ISpace["MF_Budgetdetails_PageIndex"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""false"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="false";ISpace["MF_Budgetdetails_LastButton"].Enbl="true";ISpace["MF_Budgetdetails_NextButton"].Enbl="true";ISpace["MF_Budgetdetails_FirstButton"].Enbl="false";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
}
else
{
base.WriteDebugInfo(@"else");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==ISpace["MF_ExpenseDetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==ISpace[""MF_ExpenseDetails_TotalPages""].Value)");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="true";ISpace["MF_Budgetdetails_LastButton"].Enbl="false";ISpace["MF_Budgetdetails_NextButton"].Enbl="false";ISpace["MF_Budgetdetails_FirstButton"].Enbl="true";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="true";ISpace["MF_Budgetdetails_LastButton"].Enbl="true";ISpace["MF_Budgetdetails_NextButton"].Enbl="true";ISpace["MF_Budgetdetails_FirstButton"].Enbl="true";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==1)");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==ISpace["MF_ExpenseDetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==ISpace[""MF_ExpenseDetails_TotalPages""].Value)");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="false";ISpace["MF_Budgetdetails_LastButton"].Enbl="false";ISpace["MF_Budgetdetails_NextButton"].Enbl="false";ISpace["MF_Budgetdetails_FirstButton"].Enbl="false";ISpace["MF_Budgetdetails_PageIndex"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""false"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="false";ISpace["MF_Budgetdetails_LastButton"].Enbl="true";ISpace["MF_Budgetdetails_NextButton"].Enbl="true";ISpace["MF_Budgetdetails_FirstButton"].Enbl="false";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
}
else
{
base.WriteDebugInfo(@"else");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==ISpace["MF_ExpenseDetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==ISpace[""MF_ExpenseDetails_TotalPages""].Value)");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="true";ISpace["MF_Budgetdetails_LastButton"].Enbl="false";ISpace["MF_Budgetdetails_NextButton"].Enbl="false";ISpace["MF_Budgetdetails_FirstButton"].Enbl="true";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="true";ISpace["MF_Budgetdetails_LastButton"].Enbl="true";ISpace["MF_Budgetdetails_NextButton"].Enbl="true";ISpace["MF_Budgetdetails_FirstButton"].Enbl="true";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==1)");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==ISpace["MF_ExpenseDetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==ISpace[""MF_ExpenseDetails_TotalPages""].Value)");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="false";ISpace["MF_Budgetdetails_LastButton"].Enbl="false";ISpace["MF_Budgetdetails_NextButton"].Enbl="false";ISpace["MF_Budgetdetails_FirstButton"].Enbl="false";ISpace["MF_Budgetdetails_PageIndex"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""false"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="false";ISpace["MF_Budgetdetails_LastButton"].Enbl="true";ISpace["MF_Budgetdetails_NextButton"].Enbl="true";ISpace["MF_Budgetdetails_FirstButton"].Enbl="false";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
}
else
{
base.WriteDebugInfo(@"else");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==ISpace["MF_ExpenseDetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==ISpace[""MF_ExpenseDetails_TotalPages""].Value)");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="true";ISpace["MF_Budgetdetails_LastButton"].Enbl="false";ISpace["MF_Budgetdetails_NextButton"].Enbl="false";ISpace["MF_Budgetdetails_FirstButton"].Enbl="true";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="true";ISpace["MF_Budgetdetails_LastButton"].Enbl="true";ISpace["MF_Budgetdetails_NextButton"].Enbl="true";ISpace["MF_Budgetdetails_FirstButton"].Enbl="true";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySourceA30F7872734E4D34AFDDD8F49130791A =GetQueryExpressionDataSource("A30F7872-734E-4D34-AFDD-D8F49130791A");

DataTable resultA30F7872734E4D34AFDDD8F49130791A=iSpace.SetGridDataSource(querySourceA30F7872734E4D34AFDDD8F49130791A, _objectFactory.GetGridRPP("Budgetdetails"),@"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 1,'" + ISpace["F_BudgetHeadId"].Value + @"',''," + ISpace["MF_Budgetdetails_PageIndex"].Value + @",'" + ISpace["MF_Budgetdetails_GridRows"].Value + @"','" + ISpace["F_ProjectDetailsId"].Value + @"'");

iSpace.InsertGridBindDetails("Budgetdetails","11",querySourceA30F7872734E4D34AFDDD8F49130791A,"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 1,'" + ISpace["F_BudgetHeadId"].Value + @"',''," + ISpace["MF_Budgetdetails_PageIndex"].Value + @",'" + ISpace["MF_Budgetdetails_GridRows"].Value + @"','" + ISpace["F_ProjectDetailsId"].Value + @"'",_objectFactory.GetGridRPP("Budgetdetails"));

base.WriteDebugInfo(@"var querySourceA30F7872734E4D34AFDDD8F49130791A =GetQueryExpressionDataSource(""A30F7872-734E-4D34-AFDD-D8F49130791A"");DataTable resultA30F7872734E4D34AFDDD8F49130791A=iSpace.SetGridDataSource(querySourceA30F7872734E4D34AFDDD8F49130791A, _objectFactory.GetGridRPP(""Budgetdetails""),@""EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 1,'"" + ISpace[""F_BudgetHeadId""].Value + @""','',"" + ISpace[""MF_Budgetdetails_PageIndex""].Value + @"",'"" + ISpace[""MF_Budgetdetails_GridRows""].Value + @""','"" + ISpace[""F_ProjectDetailsId""].Value + @""'"");iSpace.InsertGridBindDetails(""Budgetdetails"",""11"",querySourceA30F7872734E4D34AFDDD8F49130791A,""EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 1,'"" + ISpace[""F_BudgetHeadId""].Value + @""','',"" + ISpace[""MF_Budgetdetails_PageIndex""].Value + @"",'"" + ISpace[""MF_Budgetdetails_GridRows""].Value + @""','"" + ISpace[""F_ProjectDetailsId""].Value + @""'"",_objectFactory.GetGridRPP(""Budgetdetails""));");
base.WriteDebugInfo(@"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 1,'#F_BudgetHeadId','',#MF_Budgetdetails_PageIndex,'#MF_Budgetdetails_GridRows'");


List<Triplet<string, short, short?>> result387A33C1D74545BDA9129E364AE2D589=acdataIspace585BA2B83E754DABB50B10D8320CE414.GetQueryExpressionBindings("387A33C1-D745-45BD-A912-9E364AE2D589");
iSpace.SetGridData(resultA30F7872734E4D34AFDDD8F49130791A,result387A33C1D74545BDA9129E364AE2D589,"Budgetdetails",ref ISpace);
iSpace.UpdateGridBindDetails("Budgetdetails",result387A33C1D74545BDA9129E364AE2D589);
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
if(ISpace["MF_ExpenseDetails_PageIndex"].Value>0)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value>0)");
ISpace["MF_ExpenseDetails_PageIndex"].Value=ISpace["MF_ExpenseDetails_PageIndex"].Value+1;
base.WriteDebugInfo(@"ISpace[""MF_ExpenseDetails_PageIndex""].Value=ISpace[""MF_ExpenseDetails_PageIndex""].Value+1;");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_ExpenseDetails_PageIndex"].Value=1;
base.WriteDebugInfo(@"ISpace[""MF_ExpenseDetails_PageIndex""].Value=1;");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySourceCA82683BCA014525A93F68B518D9FCFA =GetQueryExpressionDataSource("CA82683B-CA01-4525-A93F-68B518D9FCFA");

DataTable resultCA82683BCA014525A93F68B518D9FCFA=iSpace.SetGridDataSource(querySourceCA82683BCA014525A93F68B518D9FCFA, _objectFactory.GetGridRPP("ProjectCommitments"),@"EXEC dbo.[Get_e046fb44-e1f1-4f2a-a07e-231e72f92166_FilterData] 1,'" + ISpace["F_ProjectDetailsId"].Value + @"',''," + ISpace["MF_ProjectCommitments_PageIndex"].Value + @",'" + ISpace["MF_ProjectCommitments_GridRows"].Value + @"'");

iSpace.InsertGridBindDetails("ProjectCommitments","11",querySourceCA82683BCA014525A93F68B518D9FCFA,"EXEC dbo.[Get_e046fb44-e1f1-4f2a-a07e-231e72f92166_FilterData] 1,'" + ISpace["F_ProjectDetailsId"].Value + @"',''," + ISpace["MF_ProjectCommitments_PageIndex"].Value + @",'" + ISpace["MF_ProjectCommitments_GridRows"].Value + @"'",_objectFactory.GetGridRPP("ProjectCommitments"));

base.WriteDebugInfo(@"var querySourceCA82683BCA014525A93F68B518D9FCFA =GetQueryExpressionDataSource(""CA82683B-CA01-4525-A93F-68B518D9FCFA"");DataTable resultCA82683BCA014525A93F68B518D9FCFA=iSpace.SetGridDataSource(querySourceCA82683BCA014525A93F68B518D9FCFA, _objectFactory.GetGridRPP(""ProjectCommitments""),@""EXEC dbo.[Get_e046fb44-e1f1-4f2a-a07e-231e72f92166_FilterData] 1,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',"" + ISpace[""MF_ProjectCommitments_PageIndex""].Value + @"",'"" + ISpace[""MF_ProjectCommitments_GridRows""].Value + @""'"");iSpace.InsertGridBindDetails(""ProjectCommitments"",""11"",querySourceCA82683BCA014525A93F68B518D9FCFA,""EXEC dbo.[Get_e046fb44-e1f1-4f2a-a07e-231e72f92166_FilterData] 1,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',"" + ISpace[""MF_ProjectCommitments_PageIndex""].Value + @"",'"" + ISpace[""MF_ProjectCommitments_GridRows""].Value + @""'"",_objectFactory.GetGridRPP(""ProjectCommitments""));");
base.WriteDebugInfo(@"EXEC dbo.[Get_e046fb44-e1f1-4f2a-a07e-231e72f92166_FilterData] 1,'#F_ProjectDetailsId','',#MF_ProjectCommitments_PageIndex,'#MF_ProjectCommitments_GridRows'");


List<Triplet<string, short, short?>> resultF24D61150F9946679299168E58B151A1=acdataIspace585BA2B83E754DABB50B10D8320CE414.GetQueryExpressionBindings("F24D6115-0F99-4667-9299-168E58B151A1");
iSpace.SetGridData(resultCA82683BCA014525A93F68B518D9FCFA,resultF24D61150F9946679299168E58B151A1,"ProjectCommitments",ref ISpace);
iSpace.UpdateGridBindDetails("ProjectCommitments",resultF24D61150F9946679299168E58B151A1);
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'#F_ProjectDetailsId','',#MF_ExpenseDetails_PageIndex,'#MF_ExpenseDetails_GridRows'");

var querySource108B5BFD045B42D7A031893FCF404252 =GetQueryExpressionDataSource("108B5BFD-045B-42D7-A031-893FCF404252");
Dictionary<short,object> result108B5BFD045B42D7A031893FCF404252=iSpace.ExecuteQuery(querySource108B5BFD045B42D7A031893FCF404252,@"EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'" + ISpace["F_ProjectDetailsId"].Value + @"',''," + ISpace["MF_ExpenseDetails_PageIndex"].Value + @",'" + ISpace["MF_ExpenseDetails_GridRows"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource108B5BFD045B42D7A031893FCF404252 =GetQueryExpressionDataSource(""108B5BFD-045B-42D7-A031-893FCF404252"");Dictionary<short,object> result108B5BFD045B42D7A031893FCF404252=iSpace.ExecuteQuery(querySource108B5BFD045B42D7A031893FCF404252,@""EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',"" + ISpace[""MF_ExpenseDetails_PageIndex""].Value + @"",'"" + ISpace[""MF_ExpenseDetails_GridRows""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result108B5BFD045B42D7A031893FCF404252!=null) && (result108B5BFD045B42D7A031893FCF404252.Count!=0))
{
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(0))
ISpace["MF_Budgetdetails_GridRows"].Value = result108B5BFD045B42D7A031893FCF404252[0];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(3))
ISpace["MF_Budgetdetails_TotalPages"].Value = result108B5BFD045B42D7A031893FCF404252[3];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(2))
ISpace["MF_Budgetdetails_PageIndex"].Value = result108B5BFD045B42D7A031893FCF404252[2];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(1))
ISpace["MF_Budgetdetails_RecordsRange"].Value = result108B5BFD045B42D7A031893FCF404252[1];
}
else{
ISpace["MF_Budgetdetails_GridRows"].Value = null;ISpace["MF_Budgetdetails_TotalPages"].Value = null;ISpace["MF_Budgetdetails_PageIndex"].Value = null;ISpace["MF_Budgetdetails_RecordsRange"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==1)");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==ISpace["MF_ExpenseDetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==ISpace[""MF_ExpenseDetails_TotalPages""].Value)");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="false";ISpace["MF_Budgetdetails_LastButton"].Enbl="false";ISpace["MF_Budgetdetails_NextButton"].Enbl="false";ISpace["MF_Budgetdetails_FirstButton"].Enbl="false";ISpace["MF_Budgetdetails_PageIndex"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""false"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="false";ISpace["MF_Budgetdetails_LastButton"].Enbl="true";ISpace["MF_Budgetdetails_NextButton"].Enbl="true";ISpace["MF_Budgetdetails_FirstButton"].Enbl="false";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
}
else
{
base.WriteDebugInfo(@"else");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==ISpace["MF_ExpenseDetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==ISpace[""MF_ExpenseDetails_TotalPages""].Value)");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="true";ISpace["MF_Budgetdetails_LastButton"].Enbl="false";ISpace["MF_Budgetdetails_NextButton"].Enbl="false";ISpace["MF_Budgetdetails_FirstButton"].Enbl="true";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="true";ISpace["MF_Budgetdetails_LastButton"].Enbl="true";ISpace["MF_Budgetdetails_NextButton"].Enbl="true";ISpace["MF_Budgetdetails_FirstButton"].Enbl="true";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
}
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mf_expensedetails_gridrows (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MF_ExpenseDetails_GridRows-OnChange");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySourceFC2A5065A4C24EC0B017375CE0B0B812 =GetQueryExpressionDataSource("FC2A5065-A4C2-4EC0-B017-375CE0B0B812");

DataTable resultFC2A5065A4C24EC0B017375CE0B0B812=iSpace.SetGridDataSource(querySourceFC2A5065A4C24EC0B017375CE0B0B812, _objectFactory.GetGridRPP("ExpenseDetails"),@"EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 1,'" + ISpace["F_ProjectDetailsId"].Value + @"',''," + ISpace["MF_ExpenseDetails_PageIndex"].Value + @",'" + ISpace["MF_ExpenseDetails_GridRows"].Value + @"'");

iSpace.InsertGridBindDetails("ExpenseDetails","11",querySourceFC2A5065A4C24EC0B017375CE0B0B812,"EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 1,'" + ISpace["F_ProjectDetailsId"].Value + @"',''," + ISpace["MF_ExpenseDetails_PageIndex"].Value + @",'" + ISpace["MF_ExpenseDetails_GridRows"].Value + @"'",_objectFactory.GetGridRPP("ExpenseDetails"));

base.WriteDebugInfo(@"var querySourceFC2A5065A4C24EC0B017375CE0B0B812 =GetQueryExpressionDataSource(""FC2A5065-A4C2-4EC0-B017-375CE0B0B812"");DataTable resultFC2A5065A4C24EC0B017375CE0B0B812=iSpace.SetGridDataSource(querySourceFC2A5065A4C24EC0B017375CE0B0B812, _objectFactory.GetGridRPP(""ExpenseDetails""),@""EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 1,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',"" + ISpace[""MF_ExpenseDetails_PageIndex""].Value + @"",'"" + ISpace[""MF_ExpenseDetails_GridRows""].Value + @""'"");iSpace.InsertGridBindDetails(""ExpenseDetails"",""11"",querySourceFC2A5065A4C24EC0B017375CE0B0B812,""EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 1,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',"" + ISpace[""MF_ExpenseDetails_PageIndex""].Value + @"",'"" + ISpace[""MF_ExpenseDetails_GridRows""].Value + @""'"",_objectFactory.GetGridRPP(""ExpenseDetails""));");
base.WriteDebugInfo(@"EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 1,'#F_ExpenseId','',#MF_ExpenseDetails_PageIndex,'#MF_ExpenseDetails_GridRows'");


List<Triplet<string, short, short?>> resultF156A8611F4D43F2884E90DD3F9E66E3=acdataIspace585BA2B83E754DABB50B10D8320CE414.GetQueryExpressionBindings("F156A861-1F4D-43F2-884E-90DD3F9E66E3");
iSpace.SetGridData(resultFC2A5065A4C24EC0B017375CE0B0B812,resultF156A8611F4D43F2884E90DD3F9E66E3,"ExpenseDetails",ref ISpace);
iSpace.UpdateGridBindDetails("ExpenseDetails",resultF156A8611F4D43F2884E90DD3F9E66E3);
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'#F_ProjectDetailsId','',#MF_ExpenseDetails_PageIndex,'#MF_ExpenseDetails_GridRows'");

var querySource108B5BFD045B42D7A031893FCF404252 =GetQueryExpressionDataSource("108B5BFD-045B-42D7-A031-893FCF404252");
Dictionary<short,object> result108B5BFD045B42D7A031893FCF404252=iSpace.ExecuteQuery(querySource108B5BFD045B42D7A031893FCF404252,@"EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'" + ISpace["F_ProjectDetailsId"].Value + @"',''," + ISpace["MF_ExpenseDetails_PageIndex"].Value + @",'" + ISpace["MF_ExpenseDetails_GridRows"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource108B5BFD045B42D7A031893FCF404252 =GetQueryExpressionDataSource(""108B5BFD-045B-42D7-A031-893FCF404252"");Dictionary<short,object> result108B5BFD045B42D7A031893FCF404252=iSpace.ExecuteQuery(querySource108B5BFD045B42D7A031893FCF404252,@""EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',"" + ISpace[""MF_ExpenseDetails_PageIndex""].Value + @"",'"" + ISpace[""MF_ExpenseDetails_GridRows""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result108B5BFD045B42D7A031893FCF404252!=null) && (result108B5BFD045B42D7A031893FCF404252.Count!=0))
{
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(0))
ISpace["MF_Budgetdetails_GridRows"].Value = result108B5BFD045B42D7A031893FCF404252[0];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(3))
ISpace["MF_Budgetdetails_TotalPages"].Value = result108B5BFD045B42D7A031893FCF404252[3];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(2))
ISpace["MF_Budgetdetails_PageIndex"].Value = result108B5BFD045B42D7A031893FCF404252[2];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(1))
ISpace["MF_Budgetdetails_RecordsRange"].Value = result108B5BFD045B42D7A031893FCF404252[1];
}
else{
ISpace["MF_Budgetdetails_GridRows"].Value = null;ISpace["MF_Budgetdetails_TotalPages"].Value = null;ISpace["MF_Budgetdetails_PageIndex"].Value = null;ISpace["MF_Budgetdetails_RecordsRange"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==1)");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==ISpace["MF_ExpenseDetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==ISpace[""MF_ExpenseDetails_TotalPages""].Value)");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="false";ISpace["MF_Budgetdetails_LastButton"].Enbl="false";ISpace["MF_Budgetdetails_NextButton"].Enbl="false";ISpace["MF_Budgetdetails_FirstButton"].Enbl="false";ISpace["MF_Budgetdetails_PageIndex"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""false"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="false";ISpace["MF_Budgetdetails_LastButton"].Enbl="true";ISpace["MF_Budgetdetails_NextButton"].Enbl="true";ISpace["MF_Budgetdetails_FirstButton"].Enbl="false";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
}
else
{
base.WriteDebugInfo(@"else");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==ISpace["MF_ExpenseDetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==ISpace[""MF_ExpenseDetails_TotalPages""].Value)");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="true";ISpace["MF_Budgetdetails_LastButton"].Enbl="false";ISpace["MF_Budgetdetails_NextButton"].Enbl="false";ISpace["MF_Budgetdetails_FirstButton"].Enbl="true";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="true";ISpace["MF_Budgetdetails_LastButton"].Enbl="true";ISpace["MF_Budgetdetails_NextButton"].Enbl="true";ISpace["MF_Budgetdetails_FirstButton"].Enbl="true";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
}
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mf_expensedetails_pageindex (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MF_ExpenseDetails_PageIndex-OnChange");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySourceFC2A5065A4C24EC0B017375CE0B0B812 =GetQueryExpressionDataSource("FC2A5065-A4C2-4EC0-B017-375CE0B0B812");

DataTable resultFC2A5065A4C24EC0B017375CE0B0B812=iSpace.SetGridDataSource(querySourceFC2A5065A4C24EC0B017375CE0B0B812, _objectFactory.GetGridRPP("ExpenseDetails"),@"EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 1,'" + ISpace["F_ProjectDetailsId"].Value + @"',''," + ISpace["MF_ExpenseDetails_PageIndex"].Value + @",'" + ISpace["MF_ExpenseDetails_GridRows"].Value + @"'");

iSpace.InsertGridBindDetails("ExpenseDetails","11",querySourceFC2A5065A4C24EC0B017375CE0B0B812,"EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 1,'" + ISpace["F_ProjectDetailsId"].Value + @"',''," + ISpace["MF_ExpenseDetails_PageIndex"].Value + @",'" + ISpace["MF_ExpenseDetails_GridRows"].Value + @"'",_objectFactory.GetGridRPP("ExpenseDetails"));

base.WriteDebugInfo(@"var querySourceFC2A5065A4C24EC0B017375CE0B0B812 =GetQueryExpressionDataSource(""FC2A5065-A4C2-4EC0-B017-375CE0B0B812"");DataTable resultFC2A5065A4C24EC0B017375CE0B0B812=iSpace.SetGridDataSource(querySourceFC2A5065A4C24EC0B017375CE0B0B812, _objectFactory.GetGridRPP(""ExpenseDetails""),@""EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 1,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',"" + ISpace[""MF_ExpenseDetails_PageIndex""].Value + @"",'"" + ISpace[""MF_ExpenseDetails_GridRows""].Value + @""'"");iSpace.InsertGridBindDetails(""ExpenseDetails"",""11"",querySourceFC2A5065A4C24EC0B017375CE0B0B812,""EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 1,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',"" + ISpace[""MF_ExpenseDetails_PageIndex""].Value + @"",'"" + ISpace[""MF_ExpenseDetails_GridRows""].Value + @""'"",_objectFactory.GetGridRPP(""ExpenseDetails""));");
base.WriteDebugInfo(@"EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 1,'#F_ExpenseId','',#MF_ExpenseDetails_PageIndex,'#MF_ExpenseDetails_GridRows'");


List<Triplet<string, short, short?>> resultF156A8611F4D43F2884E90DD3F9E66E3=acdataIspace585BA2B83E754DABB50B10D8320CE414.GetQueryExpressionBindings("F156A861-1F4D-43F2-884E-90DD3F9E66E3");
iSpace.SetGridData(resultFC2A5065A4C24EC0B017375CE0B0B812,resultF156A8611F4D43F2884E90DD3F9E66E3,"ExpenseDetails",ref ISpace);
iSpace.UpdateGridBindDetails("ExpenseDetails",resultF156A8611F4D43F2884E90DD3F9E66E3);
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'#F_ProjectDetailsId','',#MF_ExpenseDetails_PageIndex,'#MF_ExpenseDetails_GridRows'");

var querySource108B5BFD045B42D7A031893FCF404252 =GetQueryExpressionDataSource("108B5BFD-045B-42D7-A031-893FCF404252");
Dictionary<short,object> result108B5BFD045B42D7A031893FCF404252=iSpace.ExecuteQuery(querySource108B5BFD045B42D7A031893FCF404252,@"EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'" + ISpace["F_ProjectDetailsId"].Value + @"',''," + ISpace["MF_ExpenseDetails_PageIndex"].Value + @",'" + ISpace["MF_ExpenseDetails_GridRows"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource108B5BFD045B42D7A031893FCF404252 =GetQueryExpressionDataSource(""108B5BFD-045B-42D7-A031-893FCF404252"");Dictionary<short,object> result108B5BFD045B42D7A031893FCF404252=iSpace.ExecuteQuery(querySource108B5BFD045B42D7A031893FCF404252,@""EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',"" + ISpace[""MF_ExpenseDetails_PageIndex""].Value + @"",'"" + ISpace[""MF_ExpenseDetails_GridRows""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result108B5BFD045B42D7A031893FCF404252!=null) && (result108B5BFD045B42D7A031893FCF404252.Count!=0))
{
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(0))
ISpace["MF_Budgetdetails_GridRows"].Value = result108B5BFD045B42D7A031893FCF404252[0];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(3))
ISpace["MF_Budgetdetails_TotalPages"].Value = result108B5BFD045B42D7A031893FCF404252[3];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(2))
ISpace["MF_Budgetdetails_PageIndex"].Value = result108B5BFD045B42D7A031893FCF404252[2];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(1))
ISpace["MF_Budgetdetails_RecordsRange"].Value = result108B5BFD045B42D7A031893FCF404252[1];
}
else{
ISpace["MF_Budgetdetails_GridRows"].Value = null;ISpace["MF_Budgetdetails_TotalPages"].Value = null;ISpace["MF_Budgetdetails_PageIndex"].Value = null;ISpace["MF_Budgetdetails_RecordsRange"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==1)");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==ISpace["MF_ExpenseDetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==ISpace[""MF_ExpenseDetails_TotalPages""].Value)");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="false";ISpace["MF_Budgetdetails_LastButton"].Enbl="false";ISpace["MF_Budgetdetails_NextButton"].Enbl="false";ISpace["MF_Budgetdetails_FirstButton"].Enbl="false";ISpace["MF_Budgetdetails_PageIndex"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""false"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="false";ISpace["MF_Budgetdetails_LastButton"].Enbl="true";ISpace["MF_Budgetdetails_NextButton"].Enbl="true";ISpace["MF_Budgetdetails_FirstButton"].Enbl="false";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
}
else
{
base.WriteDebugInfo(@"else");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==ISpace["MF_ExpenseDetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==ISpace[""MF_ExpenseDetails_TotalPages""].Value)");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="true";ISpace["MF_Budgetdetails_LastButton"].Enbl="false";ISpace["MF_Budgetdetails_NextButton"].Enbl="false";ISpace["MF_Budgetdetails_FirstButton"].Enbl="true";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="true";ISpace["MF_Budgetdetails_LastButton"].Enbl="true";ISpace["MF_Budgetdetails_NextButton"].Enbl="true";ISpace["MF_Budgetdetails_FirstButton"].Enbl="true";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
}
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
ISpace["MF_ExpenseDetails_PageIndex"].Value=1;
base.WriteDebugInfo(@"ISpace[""MF_ExpenseDetails_PageIndex""].Value=1;");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySourceCA82683BCA014525A93F68B518D9FCFA =GetQueryExpressionDataSource("CA82683B-CA01-4525-A93F-68B518D9FCFA");

DataTable resultCA82683BCA014525A93F68B518D9FCFA=iSpace.SetGridDataSource(querySourceCA82683BCA014525A93F68B518D9FCFA, _objectFactory.GetGridRPP("ProjectCommitments"),@"EXEC dbo.[Get_e046fb44-e1f1-4f2a-a07e-231e72f92166_FilterData] 1,'" + ISpace["F_ProjectDetailsId"].Value + @"',''," + ISpace["MF_ProjectCommitments_PageIndex"].Value + @",'" + ISpace["MF_ProjectCommitments_GridRows"].Value + @"'");

iSpace.InsertGridBindDetails("ProjectCommitments","11",querySourceCA82683BCA014525A93F68B518D9FCFA,"EXEC dbo.[Get_e046fb44-e1f1-4f2a-a07e-231e72f92166_FilterData] 1,'" + ISpace["F_ProjectDetailsId"].Value + @"',''," + ISpace["MF_ProjectCommitments_PageIndex"].Value + @",'" + ISpace["MF_ProjectCommitments_GridRows"].Value + @"'",_objectFactory.GetGridRPP("ProjectCommitments"));

base.WriteDebugInfo(@"var querySourceCA82683BCA014525A93F68B518D9FCFA =GetQueryExpressionDataSource(""CA82683B-CA01-4525-A93F-68B518D9FCFA"");DataTable resultCA82683BCA014525A93F68B518D9FCFA=iSpace.SetGridDataSource(querySourceCA82683BCA014525A93F68B518D9FCFA, _objectFactory.GetGridRPP(""ProjectCommitments""),@""EXEC dbo.[Get_e046fb44-e1f1-4f2a-a07e-231e72f92166_FilterData] 1,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',"" + ISpace[""MF_ProjectCommitments_PageIndex""].Value + @"",'"" + ISpace[""MF_ProjectCommitments_GridRows""].Value + @""'"");iSpace.InsertGridBindDetails(""ProjectCommitments"",""11"",querySourceCA82683BCA014525A93F68B518D9FCFA,""EXEC dbo.[Get_e046fb44-e1f1-4f2a-a07e-231e72f92166_FilterData] 1,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',"" + ISpace[""MF_ProjectCommitments_PageIndex""].Value + @"",'"" + ISpace[""MF_ProjectCommitments_GridRows""].Value + @""'"",_objectFactory.GetGridRPP(""ProjectCommitments""));");
base.WriteDebugInfo(@"EXEC dbo.[Get_e046fb44-e1f1-4f2a-a07e-231e72f92166_FilterData] 1,'#F_ProjectDetailsId','',#MF_ProjectCommitments_PageIndex,'#MF_ProjectCommitments_GridRows'");


List<Triplet<string, short, short?>> resultF24D61150F9946679299168E58B151A1=acdataIspace585BA2B83E754DABB50B10D8320CE414.GetQueryExpressionBindings("F24D6115-0F99-4667-9299-168E58B151A1");
iSpace.SetGridData(resultCA82683BCA014525A93F68B518D9FCFA,resultF24D61150F9946679299168E58B151A1,"ProjectCommitments",ref ISpace);
iSpace.UpdateGridBindDetails("ProjectCommitments",resultF24D61150F9946679299168E58B151A1);
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'#F_ProjectDetailsId','',#MF_ExpenseDetails_PageIndex,'#MF_ExpenseDetails_GridRows'");

var querySource108B5BFD045B42D7A031893FCF404252 =GetQueryExpressionDataSource("108B5BFD-045B-42D7-A031-893FCF404252");
Dictionary<short,object> result108B5BFD045B42D7A031893FCF404252=iSpace.ExecuteQuery(querySource108B5BFD045B42D7A031893FCF404252,@"EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'" + ISpace["F_ProjectDetailsId"].Value + @"',''," + ISpace["MF_ExpenseDetails_PageIndex"].Value + @",'" + ISpace["MF_ExpenseDetails_GridRows"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource108B5BFD045B42D7A031893FCF404252 =GetQueryExpressionDataSource(""108B5BFD-045B-42D7-A031-893FCF404252"");Dictionary<short,object> result108B5BFD045B42D7A031893FCF404252=iSpace.ExecuteQuery(querySource108B5BFD045B42D7A031893FCF404252,@""EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',"" + ISpace[""MF_ExpenseDetails_PageIndex""].Value + @"",'"" + ISpace[""MF_ExpenseDetails_GridRows""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result108B5BFD045B42D7A031893FCF404252!=null) && (result108B5BFD045B42D7A031893FCF404252.Count!=0))
{
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(0))
ISpace["MF_Budgetdetails_GridRows"].Value = result108B5BFD045B42D7A031893FCF404252[0];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(3))
ISpace["MF_Budgetdetails_TotalPages"].Value = result108B5BFD045B42D7A031893FCF404252[3];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(2))
ISpace["MF_Budgetdetails_PageIndex"].Value = result108B5BFD045B42D7A031893FCF404252[2];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(1))
ISpace["MF_Budgetdetails_RecordsRange"].Value = result108B5BFD045B42D7A031893FCF404252[1];
}
else{
ISpace["MF_Budgetdetails_GridRows"].Value = null;ISpace["MF_Budgetdetails_TotalPages"].Value = null;ISpace["MF_Budgetdetails_PageIndex"].Value = null;ISpace["MF_Budgetdetails_RecordsRange"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==1)");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==ISpace["MF_ExpenseDetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==ISpace[""MF_ExpenseDetails_TotalPages""].Value)");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="false";ISpace["MF_Budgetdetails_LastButton"].Enbl="false";ISpace["MF_Budgetdetails_NextButton"].Enbl="false";ISpace["MF_Budgetdetails_FirstButton"].Enbl="false";ISpace["MF_Budgetdetails_PageIndex"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""false"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="false";ISpace["MF_Budgetdetails_LastButton"].Enbl="true";ISpace["MF_Budgetdetails_NextButton"].Enbl="true";ISpace["MF_Budgetdetails_FirstButton"].Enbl="false";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
}
else
{
base.WriteDebugInfo(@"else");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==ISpace["MF_ExpenseDetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==ISpace[""MF_ExpenseDetails_TotalPages""].Value)");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="true";ISpace["MF_Budgetdetails_LastButton"].Enbl="false";ISpace["MF_Budgetdetails_NextButton"].Enbl="false";ISpace["MF_Budgetdetails_FirstButton"].Enbl="true";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="true";ISpace["MF_Budgetdetails_LastButton"].Enbl="true";ISpace["MF_Budgetdetails_NextButton"].Enbl="true";ISpace["MF_Budgetdetails_FirstButton"].Enbl="true";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
}
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
if(ISpace["MF_ExpenseDetails_PageIndex"].Value>2)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value>2)");
ISpace["MF_ExpenseDetails_PageIndex"].Value=ISpace["MF_ExpenseDetails_PageIndex"].Value-1;
base.WriteDebugInfo(@"ISpace[""MF_ExpenseDetails_PageIndex""].Value=ISpace[""MF_ExpenseDetails_PageIndex""].Value-1;");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_ExpenseDetails_PageIndex"].Value=1;
base.WriteDebugInfo(@"ISpace[""MF_ExpenseDetails_PageIndex""].Value=1;");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySource94B9568E6AA646109AB971682A69C231 =GetQueryExpressionDataSource("94B9568E-6AA6-4610-9AB9-71682A69C231");

DataTable result94B9568E6AA646109AB971682A69C231=iSpace.SetGridDataSource(querySource94B9568E6AA646109AB971682A69C231, _objectFactory.GetGridRPP("ReceiptsView"),@"EXEC dbo.[Get_bd3abae8-b5a2-4b71-b3e2-e46732479592_FilterData] 1,'" + ISpace["F_ReceiptNo"].Value + @"',''," + ISpace["MF_ReceiptsView_PageIndex"].Value + @",'" + ISpace["MF_ReceiptsView_GridRows"].Value + @"','" + ISpace["F_ProjectDetailsID"].Value + @"'");

iSpace.InsertGridBindDetails("ReceiptsView","11",querySource94B9568E6AA646109AB971682A69C231,"EXEC dbo.[Get_bd3abae8-b5a2-4b71-b3e2-e46732479592_FilterData] 1,'" + ISpace["F_ReceiptNo"].Value + @"',''," + ISpace["MF_ReceiptsView_PageIndex"].Value + @",'" + ISpace["MF_ReceiptsView_GridRows"].Value + @"','" + ISpace["F_ProjectDetailsID"].Value + @"'",_objectFactory.GetGridRPP("ReceiptsView"));

base.WriteDebugInfo(@"var querySource94B9568E6AA646109AB971682A69C231 =GetQueryExpressionDataSource(""94B9568E-6AA6-4610-9AB9-71682A69C231"");DataTable result94B9568E6AA646109AB971682A69C231=iSpace.SetGridDataSource(querySource94B9568E6AA646109AB971682A69C231, _objectFactory.GetGridRPP(""ReceiptsView""),@""EXEC dbo.[Get_bd3abae8-b5a2-4b71-b3e2-e46732479592_FilterData] 1,'"" + ISpace[""F_ReceiptNo""].Value + @""','',"" + ISpace[""MF_ReceiptsView_PageIndex""].Value + @"",'"" + ISpace[""MF_ReceiptsView_GridRows""].Value + @""','"" + ISpace[""F_ProjectDetailsID""].Value + @""'"");iSpace.InsertGridBindDetails(""ReceiptsView"",""11"",querySource94B9568E6AA646109AB971682A69C231,""EXEC dbo.[Get_bd3abae8-b5a2-4b71-b3e2-e46732479592_FilterData] 1,'"" + ISpace[""F_ReceiptNo""].Value + @""','',"" + ISpace[""MF_ReceiptsView_PageIndex""].Value + @"",'"" + ISpace[""MF_ReceiptsView_GridRows""].Value + @""','"" + ISpace[""F_ProjectDetailsID""].Value + @""'"",_objectFactory.GetGridRPP(""ReceiptsView""));");
base.WriteDebugInfo(@"EXEC dbo.[Get_bd3abae8-b5a2-4b71-b3e2-e46732479592_FilterData] 1,'#F_ReceiptNo','',#MF_ReceiptsView_PageIndex,'#MF_ReceiptsView_GridRows'");


List<Triplet<string, short, short?>> result6C0E534F5B5649E8BDBDB1A399E4F9C5=acdataIspace585BA2B83E754DABB50B10D8320CE414.GetQueryExpressionBindings("6C0E534F-5B56-49E8-BDBD-B1A399E4F9C5");
iSpace.SetGridData(result94B9568E6AA646109AB971682A69C231,result6C0E534F5B5649E8BDBDB1A399E4F9C5,"ReceiptsView",ref ISpace);
iSpace.UpdateGridBindDetails("ReceiptsView",result6C0E534F5B5649E8BDBDB1A399E4F9C5);
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'#F_ProjectDetailsId','',#MF_ExpenseDetails_PageIndex,'#MF_ExpenseDetails_GridRows'");

var querySource108B5BFD045B42D7A031893FCF404252 =GetQueryExpressionDataSource("108B5BFD-045B-42D7-A031-893FCF404252");
Dictionary<short,object> result108B5BFD045B42D7A031893FCF404252=iSpace.ExecuteQuery(querySource108B5BFD045B42D7A031893FCF404252,@"EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'" + ISpace["F_ProjectDetailsId"].Value + @"',''," + ISpace["MF_ExpenseDetails_PageIndex"].Value + @",'" + ISpace["MF_ExpenseDetails_GridRows"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource108B5BFD045B42D7A031893FCF404252 =GetQueryExpressionDataSource(""108B5BFD-045B-42D7-A031-893FCF404252"");Dictionary<short,object> result108B5BFD045B42D7A031893FCF404252=iSpace.ExecuteQuery(querySource108B5BFD045B42D7A031893FCF404252,@""EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',"" + ISpace[""MF_ExpenseDetails_PageIndex""].Value + @"",'"" + ISpace[""MF_ExpenseDetails_GridRows""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result108B5BFD045B42D7A031893FCF404252!=null) && (result108B5BFD045B42D7A031893FCF404252.Count!=0))
{
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(0))
ISpace["MF_Budgetdetails_GridRows"].Value = result108B5BFD045B42D7A031893FCF404252[0];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(3))
ISpace["MF_Budgetdetails_TotalPages"].Value = result108B5BFD045B42D7A031893FCF404252[3];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(2))
ISpace["MF_Budgetdetails_PageIndex"].Value = result108B5BFD045B42D7A031893FCF404252[2];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(1))
ISpace["MF_Budgetdetails_RecordsRange"].Value = result108B5BFD045B42D7A031893FCF404252[1];
}
else{
ISpace["MF_Budgetdetails_GridRows"].Value = null;ISpace["MF_Budgetdetails_TotalPages"].Value = null;ISpace["MF_Budgetdetails_PageIndex"].Value = null;ISpace["MF_Budgetdetails_RecordsRange"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==1)");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==ISpace["MF_ExpenseDetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==ISpace[""MF_ExpenseDetails_TotalPages""].Value)");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="false";ISpace["MF_Budgetdetails_LastButton"].Enbl="false";ISpace["MF_Budgetdetails_NextButton"].Enbl="false";ISpace["MF_Budgetdetails_FirstButton"].Enbl="false";ISpace["MF_Budgetdetails_PageIndex"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""false"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="false";ISpace["MF_Budgetdetails_LastButton"].Enbl="true";ISpace["MF_Budgetdetails_NextButton"].Enbl="true";ISpace["MF_Budgetdetails_FirstButton"].Enbl="false";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
}
else
{
base.WriteDebugInfo(@"else");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==ISpace["MF_ExpenseDetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==ISpace[""MF_ExpenseDetails_TotalPages""].Value)");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="true";ISpace["MF_Budgetdetails_LastButton"].Enbl="false";ISpace["MF_Budgetdetails_NextButton"].Enbl="false";ISpace["MF_Budgetdetails_FirstButton"].Enbl="true";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="true";ISpace["MF_Budgetdetails_LastButton"].Enbl="true";ISpace["MF_Budgetdetails_NextButton"].Enbl="true";ISpace["MF_Budgetdetails_FirstButton"].Enbl="true";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
}
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mf_expensedetails_prevbutton (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MF_ExpenseDetails_PrevButton-OnClick");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value>2)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value>2)");
ISpace["MF_ExpenseDetails_PageIndex"].Value=ISpace["MF_ExpenseDetails_PageIndex"].Value-1;
base.WriteDebugInfo(@"ISpace[""MF_ExpenseDetails_PageIndex""].Value=ISpace[""MF_ExpenseDetails_PageIndex""].Value-1;");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_ExpenseDetails_PageIndex"].Value=1;
base.WriteDebugInfo(@"ISpace[""MF_ExpenseDetails_PageIndex""].Value=1;");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySourceFC2A5065A4C24EC0B017375CE0B0B812 =GetQueryExpressionDataSource("FC2A5065-A4C2-4EC0-B017-375CE0B0B812");

DataTable resultFC2A5065A4C24EC0B017375CE0B0B812=iSpace.SetGridDataSource(querySourceFC2A5065A4C24EC0B017375CE0B0B812, _objectFactory.GetGridRPP("ExpenseDetails"),@"EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 1,'" + ISpace["F_ProjectDetailsId"].Value + @"',''," + ISpace["MF_ExpenseDetails_PageIndex"].Value + @",'" + ISpace["MF_ExpenseDetails_GridRows"].Value + @"'");

iSpace.InsertGridBindDetails("ExpenseDetails","11",querySourceFC2A5065A4C24EC0B017375CE0B0B812,"EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 1,'" + ISpace["F_ProjectDetailsId"].Value + @"',''," + ISpace["MF_ExpenseDetails_PageIndex"].Value + @",'" + ISpace["MF_ExpenseDetails_GridRows"].Value + @"'",_objectFactory.GetGridRPP("ExpenseDetails"));

base.WriteDebugInfo(@"var querySourceFC2A5065A4C24EC0B017375CE0B0B812 =GetQueryExpressionDataSource(""FC2A5065-A4C2-4EC0-B017-375CE0B0B812"");DataTable resultFC2A5065A4C24EC0B017375CE0B0B812=iSpace.SetGridDataSource(querySourceFC2A5065A4C24EC0B017375CE0B0B812, _objectFactory.GetGridRPP(""ExpenseDetails""),@""EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 1,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',"" + ISpace[""MF_ExpenseDetails_PageIndex""].Value + @"",'"" + ISpace[""MF_ExpenseDetails_GridRows""].Value + @""'"");iSpace.InsertGridBindDetails(""ExpenseDetails"",""11"",querySourceFC2A5065A4C24EC0B017375CE0B0B812,""EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 1,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',"" + ISpace[""MF_ExpenseDetails_PageIndex""].Value + @"",'"" + ISpace[""MF_ExpenseDetails_GridRows""].Value + @""'"",_objectFactory.GetGridRPP(""ExpenseDetails""));");
base.WriteDebugInfo(@"EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 1,'#F_ExpenseId','',#MF_ExpenseDetails_PageIndex,'#MF_ExpenseDetails_GridRows'");


List<Triplet<string, short, short?>> resultF156A8611F4D43F2884E90DD3F9E66E3=acdataIspace585BA2B83E754DABB50B10D8320CE414.GetQueryExpressionBindings("F156A861-1F4D-43F2-884E-90DD3F9E66E3");
iSpace.SetGridData(resultFC2A5065A4C24EC0B017375CE0B0B812,resultF156A8611F4D43F2884E90DD3F9E66E3,"ExpenseDetails",ref ISpace);
iSpace.UpdateGridBindDetails("ExpenseDetails",resultF156A8611F4D43F2884E90DD3F9E66E3);
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'#F_ProjectDetailsId','',#MF_ExpenseDetails_PageIndex,'#MF_ExpenseDetails_GridRows'");

var querySource108B5BFD045B42D7A031893FCF404252 =GetQueryExpressionDataSource("108B5BFD-045B-42D7-A031-893FCF404252");
Dictionary<short,object> result108B5BFD045B42D7A031893FCF404252=iSpace.ExecuteQuery(querySource108B5BFD045B42D7A031893FCF404252,@"EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'" + ISpace["F_ProjectDetailsId"].Value + @"',''," + ISpace["MF_ExpenseDetails_PageIndex"].Value + @",'" + ISpace["MF_ExpenseDetails_GridRows"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource108B5BFD045B42D7A031893FCF404252 =GetQueryExpressionDataSource(""108B5BFD-045B-42D7-A031-893FCF404252"");Dictionary<short,object> result108B5BFD045B42D7A031893FCF404252=iSpace.ExecuteQuery(querySource108B5BFD045B42D7A031893FCF404252,@""EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',"" + ISpace[""MF_ExpenseDetails_PageIndex""].Value + @"",'"" + ISpace[""MF_ExpenseDetails_GridRows""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result108B5BFD045B42D7A031893FCF404252!=null) && (result108B5BFD045B42D7A031893FCF404252.Count!=0))
{
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(0))
ISpace["MF_Budgetdetails_GridRows"].Value = result108B5BFD045B42D7A031893FCF404252[0];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(3))
ISpace["MF_Budgetdetails_TotalPages"].Value = result108B5BFD045B42D7A031893FCF404252[3];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(2))
ISpace["MF_Budgetdetails_PageIndex"].Value = result108B5BFD045B42D7A031893FCF404252[2];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(1))
ISpace["MF_Budgetdetails_RecordsRange"].Value = result108B5BFD045B42D7A031893FCF404252[1];
}
else{
ISpace["MF_Budgetdetails_GridRows"].Value = null;ISpace["MF_Budgetdetails_TotalPages"].Value = null;ISpace["MF_Budgetdetails_PageIndex"].Value = null;ISpace["MF_Budgetdetails_RecordsRange"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==1)");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==ISpace["MF_ExpenseDetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==ISpace[""MF_ExpenseDetails_TotalPages""].Value)");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="false";ISpace["MF_Budgetdetails_LastButton"].Enbl="false";ISpace["MF_Budgetdetails_NextButton"].Enbl="false";ISpace["MF_Budgetdetails_FirstButton"].Enbl="false";ISpace["MF_Budgetdetails_PageIndex"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""false"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="false";ISpace["MF_Budgetdetails_LastButton"].Enbl="true";ISpace["MF_Budgetdetails_NextButton"].Enbl="true";ISpace["MF_Budgetdetails_FirstButton"].Enbl="false";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
}
else
{
base.WriteDebugInfo(@"else");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==ISpace["MF_ExpenseDetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==ISpace[""MF_ExpenseDetails_TotalPages""].Value)");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="true";ISpace["MF_Budgetdetails_LastButton"].Enbl="false";ISpace["MF_Budgetdetails_NextButton"].Enbl="false";ISpace["MF_Budgetdetails_FirstButton"].Enbl="true";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="true";ISpace["MF_Budgetdetails_LastButton"].Enbl="true";ISpace["MF_Budgetdetails_NextButton"].Enbl="true";ISpace["MF_Budgetdetails_FirstButton"].Enbl="true";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
}
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mf_expensedetails_firstbutton (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MF_ExpenseDetails_FirstButton-OnClick");
ISpace["MF_ExpenseDetails_PageIndex"].Value=1;
base.WriteDebugInfo(@"ISpace[""MF_ExpenseDetails_PageIndex""].Value=1;");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySourceFC2A5065A4C24EC0B017375CE0B0B812 =GetQueryExpressionDataSource("FC2A5065-A4C2-4EC0-B017-375CE0B0B812");

DataTable resultFC2A5065A4C24EC0B017375CE0B0B812=iSpace.SetGridDataSource(querySourceFC2A5065A4C24EC0B017375CE0B0B812, _objectFactory.GetGridRPP("ExpenseDetails"),@"EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 1,'" + ISpace["F_ProjectDetailsId"].Value + @"',''," + ISpace["MF_ExpenseDetails_PageIndex"].Value + @",'" + ISpace["MF_ExpenseDetails_GridRows"].Value + @"'");

iSpace.InsertGridBindDetails("ExpenseDetails","11",querySourceFC2A5065A4C24EC0B017375CE0B0B812,"EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 1,'" + ISpace["F_ProjectDetailsId"].Value + @"',''," + ISpace["MF_ExpenseDetails_PageIndex"].Value + @",'" + ISpace["MF_ExpenseDetails_GridRows"].Value + @"'",_objectFactory.GetGridRPP("ExpenseDetails"));

base.WriteDebugInfo(@"var querySourceFC2A5065A4C24EC0B017375CE0B0B812 =GetQueryExpressionDataSource(""FC2A5065-A4C2-4EC0-B017-375CE0B0B812"");DataTable resultFC2A5065A4C24EC0B017375CE0B0B812=iSpace.SetGridDataSource(querySourceFC2A5065A4C24EC0B017375CE0B0B812, _objectFactory.GetGridRPP(""ExpenseDetails""),@""EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 1,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',"" + ISpace[""MF_ExpenseDetails_PageIndex""].Value + @"",'"" + ISpace[""MF_ExpenseDetails_GridRows""].Value + @""'"");iSpace.InsertGridBindDetails(""ExpenseDetails"",""11"",querySourceFC2A5065A4C24EC0B017375CE0B0B812,""EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 1,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',"" + ISpace[""MF_ExpenseDetails_PageIndex""].Value + @"",'"" + ISpace[""MF_ExpenseDetails_GridRows""].Value + @""'"",_objectFactory.GetGridRPP(""ExpenseDetails""));");
base.WriteDebugInfo(@"EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 1,'#F_ExpenseId','',#MF_ExpenseDetails_PageIndex,'#MF_ExpenseDetails_GridRows'");


List<Triplet<string, short, short?>> resultF156A8611F4D43F2884E90DD3F9E66E3=acdataIspace585BA2B83E754DABB50B10D8320CE414.GetQueryExpressionBindings("F156A861-1F4D-43F2-884E-90DD3F9E66E3");
iSpace.SetGridData(resultFC2A5065A4C24EC0B017375CE0B0B812,resultF156A8611F4D43F2884E90DD3F9E66E3,"ExpenseDetails",ref ISpace);
iSpace.UpdateGridBindDetails("ExpenseDetails",resultF156A8611F4D43F2884E90DD3F9E66E3);
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'#F_ProjectDetailsId','',#MF_ExpenseDetails_PageIndex,'#MF_ExpenseDetails_GridRows'");

var querySource108B5BFD045B42D7A031893FCF404252 =GetQueryExpressionDataSource("108B5BFD-045B-42D7-A031-893FCF404252");
Dictionary<short,object> result108B5BFD045B42D7A031893FCF404252=iSpace.ExecuteQuery(querySource108B5BFD045B42D7A031893FCF404252,@"EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'" + ISpace["F_ProjectDetailsId"].Value + @"',''," + ISpace["MF_ExpenseDetails_PageIndex"].Value + @",'" + ISpace["MF_ExpenseDetails_GridRows"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource108B5BFD045B42D7A031893FCF404252 =GetQueryExpressionDataSource(""108B5BFD-045B-42D7-A031-893FCF404252"");Dictionary<short,object> result108B5BFD045B42D7A031893FCF404252=iSpace.ExecuteQuery(querySource108B5BFD045B42D7A031893FCF404252,@""EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',"" + ISpace[""MF_ExpenseDetails_PageIndex""].Value + @"",'"" + ISpace[""MF_ExpenseDetails_GridRows""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result108B5BFD045B42D7A031893FCF404252!=null) && (result108B5BFD045B42D7A031893FCF404252.Count!=0))
{
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(0))
ISpace["MF_Budgetdetails_GridRows"].Value = result108B5BFD045B42D7A031893FCF404252[0];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(3))
ISpace["MF_Budgetdetails_TotalPages"].Value = result108B5BFD045B42D7A031893FCF404252[3];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(2))
ISpace["MF_Budgetdetails_PageIndex"].Value = result108B5BFD045B42D7A031893FCF404252[2];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(1))
ISpace["MF_Budgetdetails_RecordsRange"].Value = result108B5BFD045B42D7A031893FCF404252[1];
}
else{
ISpace["MF_Budgetdetails_GridRows"].Value = null;ISpace["MF_Budgetdetails_TotalPages"].Value = null;ISpace["MF_Budgetdetails_PageIndex"].Value = null;ISpace["MF_Budgetdetails_RecordsRange"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==1)");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==ISpace["MF_ExpenseDetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==ISpace[""MF_ExpenseDetails_TotalPages""].Value)");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="false";ISpace["MF_Budgetdetails_LastButton"].Enbl="false";ISpace["MF_Budgetdetails_NextButton"].Enbl="false";ISpace["MF_Budgetdetails_FirstButton"].Enbl="false";ISpace["MF_Budgetdetails_PageIndex"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""false"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="false";ISpace["MF_Budgetdetails_LastButton"].Enbl="true";ISpace["MF_Budgetdetails_NextButton"].Enbl="true";ISpace["MF_Budgetdetails_FirstButton"].Enbl="false";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
}
else
{
base.WriteDebugInfo(@"else");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==ISpace["MF_ExpenseDetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==ISpace[""MF_ExpenseDetails_TotalPages""].Value)");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="true";ISpace["MF_Budgetdetails_LastButton"].Enbl="false";ISpace["MF_Budgetdetails_NextButton"].Enbl="false";ISpace["MF_Budgetdetails_FirstButton"].Enbl="true";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="true";ISpace["MF_Budgetdetails_LastButton"].Enbl="true";ISpace["MF_Budgetdetails_NextButton"].Enbl="true";ISpace["MF_Budgetdetails_FirstButton"].Enbl="true";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
}
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

var querySourceCA82683BCA014525A93F68B518D9FCFA =GetQueryExpressionDataSource("CA82683B-CA01-4525-A93F-68B518D9FCFA");

DataTable resultCA82683BCA014525A93F68B518D9FCFA=iSpace.SetGridDataSource(querySourceCA82683BCA014525A93F68B518D9FCFA, _objectFactory.GetGridRPP("ProjectCommitments"),@"EXEC dbo.[Get_e046fb44-e1f1-4f2a-a07e-231e72f92166_FilterData] 1,'" + ISpace["F_ProjectDetailsId"].Value + @"',''," + ISpace["MF_ProjectCommitments_PageIndex"].Value + @",'" + ISpace["MF_ProjectCommitments_GridRows"].Value + @"'");

iSpace.InsertGridBindDetails("ProjectCommitments","11",querySourceCA82683BCA014525A93F68B518D9FCFA,"EXEC dbo.[Get_e046fb44-e1f1-4f2a-a07e-231e72f92166_FilterData] 1,'" + ISpace["F_ProjectDetailsId"].Value + @"',''," + ISpace["MF_ProjectCommitments_PageIndex"].Value + @",'" + ISpace["MF_ProjectCommitments_GridRows"].Value + @"'",_objectFactory.GetGridRPP("ProjectCommitments"));

base.WriteDebugInfo(@"var querySourceCA82683BCA014525A93F68B518D9FCFA =GetQueryExpressionDataSource(""CA82683B-CA01-4525-A93F-68B518D9FCFA"");DataTable resultCA82683BCA014525A93F68B518D9FCFA=iSpace.SetGridDataSource(querySourceCA82683BCA014525A93F68B518D9FCFA, _objectFactory.GetGridRPP(""ProjectCommitments""),@""EXEC dbo.[Get_e046fb44-e1f1-4f2a-a07e-231e72f92166_FilterData] 1,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',"" + ISpace[""MF_ProjectCommitments_PageIndex""].Value + @"",'"" + ISpace[""MF_ProjectCommitments_GridRows""].Value + @""'"");iSpace.InsertGridBindDetails(""ProjectCommitments"",""11"",querySourceCA82683BCA014525A93F68B518D9FCFA,""EXEC dbo.[Get_e046fb44-e1f1-4f2a-a07e-231e72f92166_FilterData] 1,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',"" + ISpace[""MF_ProjectCommitments_PageIndex""].Value + @"",'"" + ISpace[""MF_ProjectCommitments_GridRows""].Value + @""'"",_objectFactory.GetGridRPP(""ProjectCommitments""));");
base.WriteDebugInfo(@"EXEC dbo.[Get_e046fb44-e1f1-4f2a-a07e-231e72f92166_FilterData] 1,'#F_ProjectDetailsId','',#MF_ProjectCommitments_PageIndex,'#MF_ProjectCommitments_GridRows'");


List<Triplet<string, short, short?>> resultF24D61150F9946679299168E58B151A1=acdataIspace585BA2B83E754DABB50B10D8320CE414.GetQueryExpressionBindings("F24D6115-0F99-4667-9299-168E58B151A1");
iSpace.SetGridData(resultCA82683BCA014525A93F68B518D9FCFA,resultF24D61150F9946679299168E58B151A1,"ProjectCommitments",ref ISpace);
iSpace.UpdateGridBindDetails("ProjectCommitments",resultF24D61150F9946679299168E58B151A1);
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'#F_ProjectDetailsId','',#MF_ExpenseDetails_PageIndex,'#MF_ExpenseDetails_GridRows'");

var querySource108B5BFD045B42D7A031893FCF404252 =GetQueryExpressionDataSource("108B5BFD-045B-42D7-A031-893FCF404252");
Dictionary<short,object> result108B5BFD045B42D7A031893FCF404252=iSpace.ExecuteQuery(querySource108B5BFD045B42D7A031893FCF404252,@"EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'" + ISpace["F_ProjectDetailsId"].Value + @"',''," + ISpace["MF_ExpenseDetails_PageIndex"].Value + @",'" + ISpace["MF_ExpenseDetails_GridRows"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource108B5BFD045B42D7A031893FCF404252 =GetQueryExpressionDataSource(""108B5BFD-045B-42D7-A031-893FCF404252"");Dictionary<short,object> result108B5BFD045B42D7A031893FCF404252=iSpace.ExecuteQuery(querySource108B5BFD045B42D7A031893FCF404252,@""EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',"" + ISpace[""MF_ExpenseDetails_PageIndex""].Value + @"",'"" + ISpace[""MF_ExpenseDetails_GridRows""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result108B5BFD045B42D7A031893FCF404252!=null) && (result108B5BFD045B42D7A031893FCF404252.Count!=0))
{
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(0))
ISpace["MF_Budgetdetails_GridRows"].Value = result108B5BFD045B42D7A031893FCF404252[0];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(3))
ISpace["MF_Budgetdetails_TotalPages"].Value = result108B5BFD045B42D7A031893FCF404252[3];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(2))
ISpace["MF_Budgetdetails_PageIndex"].Value = result108B5BFD045B42D7A031893FCF404252[2];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(1))
ISpace["MF_Budgetdetails_RecordsRange"].Value = result108B5BFD045B42D7A031893FCF404252[1];
}
else{
ISpace["MF_Budgetdetails_GridRows"].Value = null;ISpace["MF_Budgetdetails_TotalPages"].Value = null;ISpace["MF_Budgetdetails_PageIndex"].Value = null;ISpace["MF_Budgetdetails_RecordsRange"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==1)");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==ISpace["MF_ExpenseDetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==ISpace[""MF_ExpenseDetails_TotalPages""].Value)");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="false";ISpace["MF_Budgetdetails_LastButton"].Enbl="false";ISpace["MF_Budgetdetails_NextButton"].Enbl="false";ISpace["MF_Budgetdetails_FirstButton"].Enbl="false";ISpace["MF_Budgetdetails_PageIndex"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""false"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="false";ISpace["MF_Budgetdetails_LastButton"].Enbl="true";ISpace["MF_Budgetdetails_NextButton"].Enbl="true";ISpace["MF_Budgetdetails_FirstButton"].Enbl="false";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
}
else
{
base.WriteDebugInfo(@"else");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==ISpace["MF_ExpenseDetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==ISpace[""MF_ExpenseDetails_TotalPages""].Value)");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="true";ISpace["MF_Budgetdetails_LastButton"].Enbl="false";ISpace["MF_Budgetdetails_NextButton"].Enbl="false";ISpace["MF_Budgetdetails_FirstButton"].Enbl="true";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="true";ISpace["MF_Budgetdetails_LastButton"].Enbl="true";ISpace["MF_Budgetdetails_NextButton"].Enbl="true";ISpace["MF_Budgetdetails_FirstButton"].Enbl="true";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
}
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
ISpace["MF_ExpenseDetails_PageIndex"].Value=1;
base.WriteDebugInfo(@"ISpace[""MF_ExpenseDetails_PageIndex""].Value=1;");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySource94B9568E6AA646109AB971682A69C231 =GetQueryExpressionDataSource("94B9568E-6AA6-4610-9AB9-71682A69C231");

DataTable result94B9568E6AA646109AB971682A69C231=iSpace.SetGridDataSource(querySource94B9568E6AA646109AB971682A69C231, _objectFactory.GetGridRPP("ReceiptsView"),@"EXEC dbo.[Get_bd3abae8-b5a2-4b71-b3e2-e46732479592_FilterData] 1,'" + ISpace["F_ReceiptNo"].Value + @"',''," + ISpace["MF_ReceiptsView_PageIndex"].Value + @",'" + ISpace["MF_ReceiptsView_GridRows"].Value + @"','" + ISpace["F_ProjectDetailsID"].Value + @"'");

iSpace.InsertGridBindDetails("ReceiptsView","11",querySource94B9568E6AA646109AB971682A69C231,"EXEC dbo.[Get_bd3abae8-b5a2-4b71-b3e2-e46732479592_FilterData] 1,'" + ISpace["F_ReceiptNo"].Value + @"',''," + ISpace["MF_ReceiptsView_PageIndex"].Value + @",'" + ISpace["MF_ReceiptsView_GridRows"].Value + @"','" + ISpace["F_ProjectDetailsID"].Value + @"'",_objectFactory.GetGridRPP("ReceiptsView"));

base.WriteDebugInfo(@"var querySource94B9568E6AA646109AB971682A69C231 =GetQueryExpressionDataSource(""94B9568E-6AA6-4610-9AB9-71682A69C231"");DataTable result94B9568E6AA646109AB971682A69C231=iSpace.SetGridDataSource(querySource94B9568E6AA646109AB971682A69C231, _objectFactory.GetGridRPP(""ReceiptsView""),@""EXEC dbo.[Get_bd3abae8-b5a2-4b71-b3e2-e46732479592_FilterData] 1,'"" + ISpace[""F_ReceiptNo""].Value + @""','',"" + ISpace[""MF_ReceiptsView_PageIndex""].Value + @"",'"" + ISpace[""MF_ReceiptsView_GridRows""].Value + @""','"" + ISpace[""F_ProjectDetailsID""].Value + @""'"");iSpace.InsertGridBindDetails(""ReceiptsView"",""11"",querySource94B9568E6AA646109AB971682A69C231,""EXEC dbo.[Get_bd3abae8-b5a2-4b71-b3e2-e46732479592_FilterData] 1,'"" + ISpace[""F_ReceiptNo""].Value + @""','',"" + ISpace[""MF_ReceiptsView_PageIndex""].Value + @"",'"" + ISpace[""MF_ReceiptsView_GridRows""].Value + @""','"" + ISpace[""F_ProjectDetailsID""].Value + @""'"",_objectFactory.GetGridRPP(""ReceiptsView""));");
base.WriteDebugInfo(@"EXEC dbo.[Get_bd3abae8-b5a2-4b71-b3e2-e46732479592_FilterData] 1,'#F_ReceiptNo','',#MF_ReceiptsView_PageIndex,'#MF_ReceiptsView_GridRows'");


List<Triplet<string, short, short?>> result6C0E534F5B5649E8BDBDB1A399E4F9C5=acdataIspace585BA2B83E754DABB50B10D8320CE414.GetQueryExpressionBindings("6C0E534F-5B56-49E8-BDBD-B1A399E4F9C5");
iSpace.SetGridData(result94B9568E6AA646109AB971682A69C231,result6C0E534F5B5649E8BDBDB1A399E4F9C5,"ReceiptsView",ref ISpace);
iSpace.UpdateGridBindDetails("ReceiptsView",result6C0E534F5B5649E8BDBDB1A399E4F9C5);
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'#F_ProjectDetailsId','',#MF_ExpenseDetails_PageIndex,'#MF_ExpenseDetails_GridRows'");

var querySource108B5BFD045B42D7A031893FCF404252 =GetQueryExpressionDataSource("108B5BFD-045B-42D7-A031-893FCF404252");
Dictionary<short,object> result108B5BFD045B42D7A031893FCF404252=iSpace.ExecuteQuery(querySource108B5BFD045B42D7A031893FCF404252,@"EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'" + ISpace["F_ProjectDetailsId"].Value + @"',''," + ISpace["MF_ExpenseDetails_PageIndex"].Value + @",'" + ISpace["MF_ExpenseDetails_GridRows"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource108B5BFD045B42D7A031893FCF404252 =GetQueryExpressionDataSource(""108B5BFD-045B-42D7-A031-893FCF404252"");Dictionary<short,object> result108B5BFD045B42D7A031893FCF404252=iSpace.ExecuteQuery(querySource108B5BFD045B42D7A031893FCF404252,@""EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',"" + ISpace[""MF_ExpenseDetails_PageIndex""].Value + @"",'"" + ISpace[""MF_ExpenseDetails_GridRows""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result108B5BFD045B42D7A031893FCF404252!=null) && (result108B5BFD045B42D7A031893FCF404252.Count!=0))
{
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(0))
ISpace["MF_Budgetdetails_GridRows"].Value = result108B5BFD045B42D7A031893FCF404252[0];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(3))
ISpace["MF_Budgetdetails_TotalPages"].Value = result108B5BFD045B42D7A031893FCF404252[3];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(2))
ISpace["MF_Budgetdetails_PageIndex"].Value = result108B5BFD045B42D7A031893FCF404252[2];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(1))
ISpace["MF_Budgetdetails_RecordsRange"].Value = result108B5BFD045B42D7A031893FCF404252[1];
}
else{
ISpace["MF_Budgetdetails_GridRows"].Value = null;ISpace["MF_Budgetdetails_TotalPages"].Value = null;ISpace["MF_Budgetdetails_PageIndex"].Value = null;ISpace["MF_Budgetdetails_RecordsRange"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==1)");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==ISpace["MF_ExpenseDetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==ISpace[""MF_ExpenseDetails_TotalPages""].Value)");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="false";ISpace["MF_Budgetdetails_LastButton"].Enbl="false";ISpace["MF_Budgetdetails_NextButton"].Enbl="false";ISpace["MF_Budgetdetails_FirstButton"].Enbl="false";ISpace["MF_Budgetdetails_PageIndex"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""false"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="false";ISpace["MF_Budgetdetails_LastButton"].Enbl="true";ISpace["MF_Budgetdetails_NextButton"].Enbl="true";ISpace["MF_Budgetdetails_FirstButton"].Enbl="false";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
}
else
{
base.WriteDebugInfo(@"else");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==ISpace["MF_ExpenseDetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==ISpace[""MF_ExpenseDetails_TotalPages""].Value)");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="true";ISpace["MF_Budgetdetails_LastButton"].Enbl="false";ISpace["MF_Budgetdetails_NextButton"].Enbl="false";ISpace["MF_Budgetdetails_FirstButton"].Enbl="true";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="true";ISpace["MF_Budgetdetails_LastButton"].Enbl="true";ISpace["MF_Budgetdetails_NextButton"].Enbl="true";ISpace["MF_Budgetdetails_FirstButton"].Enbl="true";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
}
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
if(ISpace["MF_ExpenseDetails_PageIndex"].Value>2)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value>2)");
ISpace["MF_ExpenseDetails_PageIndex"].Value=ISpace["MF_ExpenseDetails_PageIndex"].Value-1;
base.WriteDebugInfo(@"ISpace[""MF_ExpenseDetails_PageIndex""].Value=ISpace[""MF_ExpenseDetails_PageIndex""].Value-1;");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_ExpenseDetails_PageIndex"].Value=1;
base.WriteDebugInfo(@"ISpace[""MF_ExpenseDetails_PageIndex""].Value=1;");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'#F_ProjectDetailsId','',#MF_ExpenseDetails_PageIndex,'#MF_ExpenseDetails_GridRows'");

var querySource108B5BFD045B42D7A031893FCF404252 =GetQueryExpressionDataSource("108B5BFD-045B-42D7-A031-893FCF404252");
Dictionary<short,object> result108B5BFD045B42D7A031893FCF404252=iSpace.ExecuteQuery(querySource108B5BFD045B42D7A031893FCF404252,@"EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'" + ISpace["F_ProjectDetailsId"].Value + @"',''," + ISpace["MF_ExpenseDetails_PageIndex"].Value + @",'" + ISpace["MF_ExpenseDetails_GridRows"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource108B5BFD045B42D7A031893FCF404252 =GetQueryExpressionDataSource(""108B5BFD-045B-42D7-A031-893FCF404252"");Dictionary<short,object> result108B5BFD045B42D7A031893FCF404252=iSpace.ExecuteQuery(querySource108B5BFD045B42D7A031893FCF404252,@""EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',"" + ISpace[""MF_ExpenseDetails_PageIndex""].Value + @"",'"" + ISpace[""MF_ExpenseDetails_GridRows""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result108B5BFD045B42D7A031893FCF404252!=null) && (result108B5BFD045B42D7A031893FCF404252.Count!=0))
{
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(0))
ISpace["MF_Budgetdetails_GridRows"].Value = result108B5BFD045B42D7A031893FCF404252[0];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(3))
ISpace["MF_Budgetdetails_TotalPages"].Value = result108B5BFD045B42D7A031893FCF404252[3];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(2))
ISpace["MF_Budgetdetails_PageIndex"].Value = result108B5BFD045B42D7A031893FCF404252[2];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(1))
ISpace["MF_Budgetdetails_RecordsRange"].Value = result108B5BFD045B42D7A031893FCF404252[1];
}
else{
ISpace["MF_Budgetdetails_GridRows"].Value = null;ISpace["MF_Budgetdetails_TotalPages"].Value = null;ISpace["MF_Budgetdetails_PageIndex"].Value = null;ISpace["MF_Budgetdetails_RecordsRange"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==1)");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==ISpace["MF_ExpenseDetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==ISpace[""MF_ExpenseDetails_TotalPages""].Value)");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="false";ISpace["MF_Budgetdetails_LastButton"].Enbl="false";ISpace["MF_Budgetdetails_NextButton"].Enbl="false";ISpace["MF_Budgetdetails_FirstButton"].Enbl="false";ISpace["MF_Budgetdetails_PageIndex"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""false"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="false";ISpace["MF_Budgetdetails_LastButton"].Enbl="true";ISpace["MF_Budgetdetails_NextButton"].Enbl="true";ISpace["MF_Budgetdetails_FirstButton"].Enbl="false";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
}
else
{
base.WriteDebugInfo(@"else");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==ISpace["MF_ExpenseDetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==ISpace[""MF_ExpenseDetails_TotalPages""].Value)");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="true";ISpace["MF_Budgetdetails_LastButton"].Enbl="false";ISpace["MF_Budgetdetails_NextButton"].Enbl="false";ISpace["MF_Budgetdetails_FirstButton"].Enbl="true";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="true";ISpace["MF_Budgetdetails_LastButton"].Enbl="true";ISpace["MF_Budgetdetails_NextButton"].Enbl="true";ISpace["MF_Budgetdetails_FirstButton"].Enbl="true";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySourceA30F7872734E4D34AFDDD8F49130791A =GetQueryExpressionDataSource("A30F7872-734E-4D34-AFDD-D8F49130791A");

DataTable resultA30F7872734E4D34AFDDD8F49130791A=iSpace.SetGridDataSource(querySourceA30F7872734E4D34AFDDD8F49130791A, _objectFactory.GetGridRPP("Budgetdetails"),@"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 1,'" + ISpace["F_BudgetHeadId"].Value + @"',''," + ISpace["MF_Budgetdetails_PageIndex"].Value + @",'" + ISpace["MF_Budgetdetails_GridRows"].Value + @"','" + ISpace["F_ProjectDetailsId"].Value + @"'");

iSpace.InsertGridBindDetails("Budgetdetails","11",querySourceA30F7872734E4D34AFDDD8F49130791A,"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 1,'" + ISpace["F_BudgetHeadId"].Value + @"',''," + ISpace["MF_Budgetdetails_PageIndex"].Value + @",'" + ISpace["MF_Budgetdetails_GridRows"].Value + @"','" + ISpace["F_ProjectDetailsId"].Value + @"'",_objectFactory.GetGridRPP("Budgetdetails"));

base.WriteDebugInfo(@"var querySourceA30F7872734E4D34AFDDD8F49130791A =GetQueryExpressionDataSource(""A30F7872-734E-4D34-AFDD-D8F49130791A"");DataTable resultA30F7872734E4D34AFDDD8F49130791A=iSpace.SetGridDataSource(querySourceA30F7872734E4D34AFDDD8F49130791A, _objectFactory.GetGridRPP(""Budgetdetails""),@""EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 1,'"" + ISpace[""F_BudgetHeadId""].Value + @""','',"" + ISpace[""MF_Budgetdetails_PageIndex""].Value + @"",'"" + ISpace[""MF_Budgetdetails_GridRows""].Value + @""','"" + ISpace[""F_ProjectDetailsId""].Value + @""'"");iSpace.InsertGridBindDetails(""Budgetdetails"",""11"",querySourceA30F7872734E4D34AFDDD8F49130791A,""EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 1,'"" + ISpace[""F_BudgetHeadId""].Value + @""','',"" + ISpace[""MF_Budgetdetails_PageIndex""].Value + @"",'"" + ISpace[""MF_Budgetdetails_GridRows""].Value + @""','"" + ISpace[""F_ProjectDetailsId""].Value + @""'"",_objectFactory.GetGridRPP(""Budgetdetails""));");
base.WriteDebugInfo(@"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 1,'#F_BudgetHeadId','',#MF_Budgetdetails_PageIndex,'#MF_Budgetdetails_GridRows'");


List<Triplet<string, short, short?>> result387A33C1D74545BDA9129E364AE2D589=acdataIspace585BA2B83E754DABB50B10D8320CE414.GetQueryExpressionBindings("387A33C1-D745-45BD-A912-9E364AE2D589");
iSpace.SetGridData(resultA30F7872734E4D34AFDDD8F49130791A,result387A33C1D74545BDA9129E364AE2D589,"Budgetdetails",ref ISpace);
iSpace.UpdateGridBindDetails("Budgetdetails",result387A33C1D74545BDA9129E364AE2D589);
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
if(ISpace["MF_ExpenseDetails_PageIndex"].Value>2)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value>2)");
ISpace["MF_ExpenseDetails_PageIndex"].Value=ISpace["MF_ExpenseDetails_PageIndex"].Value-1;
base.WriteDebugInfo(@"ISpace[""MF_ExpenseDetails_PageIndex""].Value=ISpace[""MF_ExpenseDetails_PageIndex""].Value-1;");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_ExpenseDetails_PageIndex"].Value=1;
base.WriteDebugInfo(@"ISpace[""MF_ExpenseDetails_PageIndex""].Value=1;");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySourceCA82683BCA014525A93F68B518D9FCFA =GetQueryExpressionDataSource("CA82683B-CA01-4525-A93F-68B518D9FCFA");

DataTable resultCA82683BCA014525A93F68B518D9FCFA=iSpace.SetGridDataSource(querySourceCA82683BCA014525A93F68B518D9FCFA, _objectFactory.GetGridRPP("ProjectCommitments"),@"EXEC dbo.[Get_e046fb44-e1f1-4f2a-a07e-231e72f92166_FilterData] 1,'" + ISpace["F_ProjectDetailsId"].Value + @"',''," + ISpace["MF_ProjectCommitments_PageIndex"].Value + @",'" + ISpace["MF_ProjectCommitments_GridRows"].Value + @"'");

iSpace.InsertGridBindDetails("ProjectCommitments","11",querySourceCA82683BCA014525A93F68B518D9FCFA,"EXEC dbo.[Get_e046fb44-e1f1-4f2a-a07e-231e72f92166_FilterData] 1,'" + ISpace["F_ProjectDetailsId"].Value + @"',''," + ISpace["MF_ProjectCommitments_PageIndex"].Value + @",'" + ISpace["MF_ProjectCommitments_GridRows"].Value + @"'",_objectFactory.GetGridRPP("ProjectCommitments"));

base.WriteDebugInfo(@"var querySourceCA82683BCA014525A93F68B518D9FCFA =GetQueryExpressionDataSource(""CA82683B-CA01-4525-A93F-68B518D9FCFA"");DataTable resultCA82683BCA014525A93F68B518D9FCFA=iSpace.SetGridDataSource(querySourceCA82683BCA014525A93F68B518D9FCFA, _objectFactory.GetGridRPP(""ProjectCommitments""),@""EXEC dbo.[Get_e046fb44-e1f1-4f2a-a07e-231e72f92166_FilterData] 1,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',"" + ISpace[""MF_ProjectCommitments_PageIndex""].Value + @"",'"" + ISpace[""MF_ProjectCommitments_GridRows""].Value + @""'"");iSpace.InsertGridBindDetails(""ProjectCommitments"",""11"",querySourceCA82683BCA014525A93F68B518D9FCFA,""EXEC dbo.[Get_e046fb44-e1f1-4f2a-a07e-231e72f92166_FilterData] 1,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',"" + ISpace[""MF_ProjectCommitments_PageIndex""].Value + @"",'"" + ISpace[""MF_ProjectCommitments_GridRows""].Value + @""'"",_objectFactory.GetGridRPP(""ProjectCommitments""));");
base.WriteDebugInfo(@"EXEC dbo.[Get_e046fb44-e1f1-4f2a-a07e-231e72f92166_FilterData] 1,'#F_ProjectDetailsId','',#MF_ProjectCommitments_PageIndex,'#MF_ProjectCommitments_GridRows'");


List<Triplet<string, short, short?>> resultF24D61150F9946679299168E58B151A1=acdataIspace585BA2B83E754DABB50B10D8320CE414.GetQueryExpressionBindings("F24D6115-0F99-4667-9299-168E58B151A1");
iSpace.SetGridData(resultCA82683BCA014525A93F68B518D9FCFA,resultF24D61150F9946679299168E58B151A1,"ProjectCommitments",ref ISpace);
iSpace.UpdateGridBindDetails("ProjectCommitments",resultF24D61150F9946679299168E58B151A1);
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'#F_ProjectDetailsId','',#MF_ExpenseDetails_PageIndex,'#MF_ExpenseDetails_GridRows'");

var querySource108B5BFD045B42D7A031893FCF404252 =GetQueryExpressionDataSource("108B5BFD-045B-42D7-A031-893FCF404252");
Dictionary<short,object> result108B5BFD045B42D7A031893FCF404252=iSpace.ExecuteQuery(querySource108B5BFD045B42D7A031893FCF404252,@"EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'" + ISpace["F_ProjectDetailsId"].Value + @"',''," + ISpace["MF_ExpenseDetails_PageIndex"].Value + @",'" + ISpace["MF_ExpenseDetails_GridRows"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource108B5BFD045B42D7A031893FCF404252 =GetQueryExpressionDataSource(""108B5BFD-045B-42D7-A031-893FCF404252"");Dictionary<short,object> result108B5BFD045B42D7A031893FCF404252=iSpace.ExecuteQuery(querySource108B5BFD045B42D7A031893FCF404252,@""EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',"" + ISpace[""MF_ExpenseDetails_PageIndex""].Value + @"",'"" + ISpace[""MF_ExpenseDetails_GridRows""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result108B5BFD045B42D7A031893FCF404252!=null) && (result108B5BFD045B42D7A031893FCF404252.Count!=0))
{
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(0))
ISpace["MF_Budgetdetails_GridRows"].Value = result108B5BFD045B42D7A031893FCF404252[0];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(3))
ISpace["MF_Budgetdetails_TotalPages"].Value = result108B5BFD045B42D7A031893FCF404252[3];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(2))
ISpace["MF_Budgetdetails_PageIndex"].Value = result108B5BFD045B42D7A031893FCF404252[2];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(1))
ISpace["MF_Budgetdetails_RecordsRange"].Value = result108B5BFD045B42D7A031893FCF404252[1];
}
else{
ISpace["MF_Budgetdetails_GridRows"].Value = null;ISpace["MF_Budgetdetails_TotalPages"].Value = null;ISpace["MF_Budgetdetails_PageIndex"].Value = null;ISpace["MF_Budgetdetails_RecordsRange"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==1)");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==ISpace["MF_ExpenseDetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==ISpace[""MF_ExpenseDetails_TotalPages""].Value)");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="false";ISpace["MF_Budgetdetails_LastButton"].Enbl="false";ISpace["MF_Budgetdetails_NextButton"].Enbl="false";ISpace["MF_Budgetdetails_FirstButton"].Enbl="false";ISpace["MF_Budgetdetails_PageIndex"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""false"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="false";ISpace["MF_Budgetdetails_LastButton"].Enbl="true";ISpace["MF_Budgetdetails_NextButton"].Enbl="true";ISpace["MF_Budgetdetails_FirstButton"].Enbl="false";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
}
else
{
base.WriteDebugInfo(@"else");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==ISpace["MF_ExpenseDetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==ISpace[""MF_ExpenseDetails_TotalPages""].Value)");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="true";ISpace["MF_Budgetdetails_LastButton"].Enbl="false";ISpace["MF_Budgetdetails_NextButton"].Enbl="false";ISpace["MF_Budgetdetails_FirstButton"].Enbl="true";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="true";ISpace["MF_Budgetdetails_LastButton"].Enbl="true";ISpace["MF_Budgetdetails_NextButton"].Enbl="true";ISpace["MF_Budgetdetails_FirstButton"].Enbl="true";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
}
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mf_expensedetails_lastbutton (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MF_ExpenseDetails_LastButton-OnClick");
ISpace["MF_ExpenseDetails_PageIndex"].Value=0;
base.WriteDebugInfo(@"ISpace[""MF_ExpenseDetails_PageIndex""].Value=0;");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySourceFC2A5065A4C24EC0B017375CE0B0B812 =GetQueryExpressionDataSource("FC2A5065-A4C2-4EC0-B017-375CE0B0B812");

DataTable resultFC2A5065A4C24EC0B017375CE0B0B812=iSpace.SetGridDataSource(querySourceFC2A5065A4C24EC0B017375CE0B0B812, _objectFactory.GetGridRPP("ExpenseDetails"),@"EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 1,'" + ISpace["F_ProjectDetailsId"].Value + @"',''," + ISpace["MF_ExpenseDetails_PageIndex"].Value + @",'" + ISpace["MF_ExpenseDetails_GridRows"].Value + @"'");

iSpace.InsertGridBindDetails("ExpenseDetails","11",querySourceFC2A5065A4C24EC0B017375CE0B0B812,"EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 1,'" + ISpace["F_ProjectDetailsId"].Value + @"',''," + ISpace["MF_ExpenseDetails_PageIndex"].Value + @",'" + ISpace["MF_ExpenseDetails_GridRows"].Value + @"'",_objectFactory.GetGridRPP("ExpenseDetails"));

base.WriteDebugInfo(@"var querySourceFC2A5065A4C24EC0B017375CE0B0B812 =GetQueryExpressionDataSource(""FC2A5065-A4C2-4EC0-B017-375CE0B0B812"");DataTable resultFC2A5065A4C24EC0B017375CE0B0B812=iSpace.SetGridDataSource(querySourceFC2A5065A4C24EC0B017375CE0B0B812, _objectFactory.GetGridRPP(""ExpenseDetails""),@""EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 1,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',"" + ISpace[""MF_ExpenseDetails_PageIndex""].Value + @"",'"" + ISpace[""MF_ExpenseDetails_GridRows""].Value + @""'"");iSpace.InsertGridBindDetails(""ExpenseDetails"",""11"",querySourceFC2A5065A4C24EC0B017375CE0B0B812,""EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 1,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',"" + ISpace[""MF_ExpenseDetails_PageIndex""].Value + @"",'"" + ISpace[""MF_ExpenseDetails_GridRows""].Value + @""'"",_objectFactory.GetGridRPP(""ExpenseDetails""));");
base.WriteDebugInfo(@"EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 1,'#F_ExpenseId','',#MF_ExpenseDetails_PageIndex,'#MF_ExpenseDetails_GridRows'");


List<Triplet<string, short, short?>> resultF156A8611F4D43F2884E90DD3F9E66E3=acdataIspace585BA2B83E754DABB50B10D8320CE414.GetQueryExpressionBindings("F156A861-1F4D-43F2-884E-90DD3F9E66E3");
iSpace.SetGridData(resultFC2A5065A4C24EC0B017375CE0B0B812,resultF156A8611F4D43F2884E90DD3F9E66E3,"ExpenseDetails",ref ISpace);
iSpace.UpdateGridBindDetails("ExpenseDetails",resultF156A8611F4D43F2884E90DD3F9E66E3);
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'#F_ProjectDetailsId','',#MF_ExpenseDetails_PageIndex,'#MF_ExpenseDetails_GridRows'");

var querySource108B5BFD045B42D7A031893FCF404252 =GetQueryExpressionDataSource("108B5BFD-045B-42D7-A031-893FCF404252");
Dictionary<short,object> result108B5BFD045B42D7A031893FCF404252=iSpace.ExecuteQuery(querySource108B5BFD045B42D7A031893FCF404252,@"EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'" + ISpace["F_ProjectDetailsId"].Value + @"',''," + ISpace["MF_ExpenseDetails_PageIndex"].Value + @",'" + ISpace["MF_ExpenseDetails_GridRows"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource108B5BFD045B42D7A031893FCF404252 =GetQueryExpressionDataSource(""108B5BFD-045B-42D7-A031-893FCF404252"");Dictionary<short,object> result108B5BFD045B42D7A031893FCF404252=iSpace.ExecuteQuery(querySource108B5BFD045B42D7A031893FCF404252,@""EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',"" + ISpace[""MF_ExpenseDetails_PageIndex""].Value + @"",'"" + ISpace[""MF_ExpenseDetails_GridRows""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result108B5BFD045B42D7A031893FCF404252!=null) && (result108B5BFD045B42D7A031893FCF404252.Count!=0))
{
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(0))
ISpace["MF_Budgetdetails_GridRows"].Value = result108B5BFD045B42D7A031893FCF404252[0];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(3))
ISpace["MF_Budgetdetails_TotalPages"].Value = result108B5BFD045B42D7A031893FCF404252[3];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(2))
ISpace["MF_Budgetdetails_PageIndex"].Value = result108B5BFD045B42D7A031893FCF404252[2];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(1))
ISpace["MF_Budgetdetails_RecordsRange"].Value = result108B5BFD045B42D7A031893FCF404252[1];
}
else{
ISpace["MF_Budgetdetails_GridRows"].Value = null;ISpace["MF_Budgetdetails_TotalPages"].Value = null;ISpace["MF_Budgetdetails_PageIndex"].Value = null;ISpace["MF_Budgetdetails_RecordsRange"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==1)");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==ISpace["MF_ExpenseDetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==ISpace[""MF_ExpenseDetails_TotalPages""].Value)");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="false";ISpace["MF_Budgetdetails_LastButton"].Enbl="false";ISpace["MF_Budgetdetails_NextButton"].Enbl="false";ISpace["MF_Budgetdetails_FirstButton"].Enbl="false";ISpace["MF_Budgetdetails_PageIndex"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""false"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="false";ISpace["MF_Budgetdetails_LastButton"].Enbl="true";ISpace["MF_Budgetdetails_NextButton"].Enbl="true";ISpace["MF_Budgetdetails_FirstButton"].Enbl="false";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
}
else
{
base.WriteDebugInfo(@"else");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==ISpace["MF_ExpenseDetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==ISpace[""MF_ExpenseDetails_TotalPages""].Value)");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="true";ISpace["MF_Budgetdetails_LastButton"].Enbl="false";ISpace["MF_Budgetdetails_NextButton"].Enbl="false";ISpace["MF_Budgetdetails_FirstButton"].Enbl="true";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="true";ISpace["MF_Budgetdetails_LastButton"].Enbl="true";ISpace["MF_Budgetdetails_NextButton"].Enbl="true";ISpace["MF_Budgetdetails_FirstButton"].Enbl="true";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
}
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
base.WriteDebugInfo(@"EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'#F_ProjectDetailsId','',#MF_ExpenseDetails_PageIndex,'#MF_ExpenseDetails_GridRows'");

var querySource108B5BFD045B42D7A031893FCF404252 =GetQueryExpressionDataSource("108B5BFD-045B-42D7-A031-893FCF404252");
Dictionary<short,object> result108B5BFD045B42D7A031893FCF404252=iSpace.ExecuteQuery(querySource108B5BFD045B42D7A031893FCF404252,@"EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'" + ISpace["F_ProjectDetailsId"].Value + @"',''," + ISpace["MF_ExpenseDetails_PageIndex"].Value + @",'" + ISpace["MF_ExpenseDetails_GridRows"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource108B5BFD045B42D7A031893FCF404252 =GetQueryExpressionDataSource(""108B5BFD-045B-42D7-A031-893FCF404252"");Dictionary<short,object> result108B5BFD045B42D7A031893FCF404252=iSpace.ExecuteQuery(querySource108B5BFD045B42D7A031893FCF404252,@""EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',"" + ISpace[""MF_ExpenseDetails_PageIndex""].Value + @"",'"" + ISpace[""MF_ExpenseDetails_GridRows""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result108B5BFD045B42D7A031893FCF404252!=null) && (result108B5BFD045B42D7A031893FCF404252.Count!=0))
{
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(0))
ISpace["MF_Budgetdetails_GridRows"].Value = result108B5BFD045B42D7A031893FCF404252[0];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(3))
ISpace["MF_Budgetdetails_TotalPages"].Value = result108B5BFD045B42D7A031893FCF404252[3];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(2))
ISpace["MF_Budgetdetails_PageIndex"].Value = result108B5BFD045B42D7A031893FCF404252[2];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(1))
ISpace["MF_Budgetdetails_RecordsRange"].Value = result108B5BFD045B42D7A031893FCF404252[1];
}
else{
ISpace["MF_Budgetdetails_GridRows"].Value = null;ISpace["MF_Budgetdetails_TotalPages"].Value = null;ISpace["MF_Budgetdetails_PageIndex"].Value = null;ISpace["MF_Budgetdetails_RecordsRange"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==1)");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==ISpace["MF_ExpenseDetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==ISpace[""MF_ExpenseDetails_TotalPages""].Value)");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="false";ISpace["MF_Budgetdetails_LastButton"].Enbl="false";ISpace["MF_Budgetdetails_NextButton"].Enbl="false";ISpace["MF_Budgetdetails_FirstButton"].Enbl="false";ISpace["MF_Budgetdetails_PageIndex"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""false"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="false";ISpace["MF_Budgetdetails_LastButton"].Enbl="true";ISpace["MF_Budgetdetails_NextButton"].Enbl="true";ISpace["MF_Budgetdetails_FirstButton"].Enbl="false";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
}
else
{
base.WriteDebugInfo(@"else");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==ISpace["MF_ExpenseDetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==ISpace[""MF_ExpenseDetails_TotalPages""].Value)");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="true";ISpace["MF_Budgetdetails_LastButton"].Enbl="false";ISpace["MF_Budgetdetails_NextButton"].Enbl="false";ISpace["MF_Budgetdetails_FirstButton"].Enbl="true";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="true";ISpace["MF_Budgetdetails_LastButton"].Enbl="true";ISpace["MF_Budgetdetails_NextButton"].Enbl="true";ISpace["MF_Budgetdetails_FirstButton"].Enbl="true";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySourceA30F7872734E4D34AFDDD8F49130791A =GetQueryExpressionDataSource("A30F7872-734E-4D34-AFDD-D8F49130791A");

DataTable resultA30F7872734E4D34AFDDD8F49130791A=iSpace.SetGridDataSource(querySourceA30F7872734E4D34AFDDD8F49130791A, _objectFactory.GetGridRPP("Budgetdetails"),@"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 1,'" + ISpace["F_BudgetHeadId"].Value + @"',''," + ISpace["MF_Budgetdetails_PageIndex"].Value + @",'" + ISpace["MF_Budgetdetails_GridRows"].Value + @"','" + ISpace["F_ProjectDetailsId"].Value + @"'");

iSpace.InsertGridBindDetails("Budgetdetails","11",querySourceA30F7872734E4D34AFDDD8F49130791A,"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 1,'" + ISpace["F_BudgetHeadId"].Value + @"',''," + ISpace["MF_Budgetdetails_PageIndex"].Value + @",'" + ISpace["MF_Budgetdetails_GridRows"].Value + @"','" + ISpace["F_ProjectDetailsId"].Value + @"'",_objectFactory.GetGridRPP("Budgetdetails"));

base.WriteDebugInfo(@"var querySourceA30F7872734E4D34AFDDD8F49130791A =GetQueryExpressionDataSource(""A30F7872-734E-4D34-AFDD-D8F49130791A"");DataTable resultA30F7872734E4D34AFDDD8F49130791A=iSpace.SetGridDataSource(querySourceA30F7872734E4D34AFDDD8F49130791A, _objectFactory.GetGridRPP(""Budgetdetails""),@""EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 1,'"" + ISpace[""F_BudgetHeadId""].Value + @""','',"" + ISpace[""MF_Budgetdetails_PageIndex""].Value + @"",'"" + ISpace[""MF_Budgetdetails_GridRows""].Value + @""','"" + ISpace[""F_ProjectDetailsId""].Value + @""'"");iSpace.InsertGridBindDetails(""Budgetdetails"",""11"",querySourceA30F7872734E4D34AFDDD8F49130791A,""EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 1,'"" + ISpace[""F_BudgetHeadId""].Value + @""','',"" + ISpace[""MF_Budgetdetails_PageIndex""].Value + @"",'"" + ISpace[""MF_Budgetdetails_GridRows""].Value + @""','"" + ISpace[""F_ProjectDetailsId""].Value + @""'"",_objectFactory.GetGridRPP(""Budgetdetails""));");
base.WriteDebugInfo(@"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 1,'#F_BudgetHeadId','',#MF_Budgetdetails_PageIndex,'#MF_Budgetdetails_GridRows'");


List<Triplet<string, short, short?>> result387A33C1D74545BDA9129E364AE2D589=acdataIspace585BA2B83E754DABB50B10D8320CE414.GetQueryExpressionBindings("387A33C1-D745-45BD-A912-9E364AE2D589");
iSpace.SetGridData(resultA30F7872734E4D34AFDDD8F49130791A,result387A33C1D74545BDA9129E364AE2D589,"Budgetdetails",ref ISpace);
iSpace.UpdateGridBindDetails("Budgetdetails",result387A33C1D74545BDA9129E364AE2D589);
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
ISpace["UI_GridPanel"].Visible="false";ISpace["UI_GridPanel"].Enbl="true";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""F7DA2CD7-1723-45E3-94F5-6380EB2F0989"")
{
ISpace[""UI_GridPanel""].Visible=""false"";ISpace[""UI_GridPanel""].Enbl=""true"";
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
ISpace["UI_GridPanelthree"].Visible="false";ISpace["UI_GridPanelthree"].Enbl="true";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""F7DA2CD7-1723-45E3-94F5-6380EB2F0989"")
{
ISpace[""UI_GridPanelthree""].Visible=""false"";ISpace[""UI_GridPanelthree""].Enbl=""true"";
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
ISpace["UI_GridPanelOne"].Visible="false";ISpace["UI_GridPanelOne"].Enbl="true";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""F7DA2CD7-1723-45E3-94F5-6380EB2F0989"")
{
ISpace[""UI_GridPanelOne""].Visible=""false"";ISpace[""UI_GridPanelOne""].Enbl=""true"";
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
ISpace["UI_SearchPanel"].Visible="false";ISpace["UI_SearchPanel"].Enbl="true";
}if(ISpace["FormVersionId"].Value=="F7DA2CD7-1723-45E3-94F5-6380EB2F0989")
{
ISpace["UI_GridPanelTwo"].Visible="false";ISpace["UI_GridPanelTwo"].Enbl="true";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""F7DA2CD7-1723-45E3-94F5-6380EB2F0989"")
{
ISpace[""UI_SearchPanel""].Visible=""false"";ISpace[""UI_SearchPanel""].Enbl=""true"";
}if(ISpace[""FormVersionId""].Value==""F7DA2CD7-1723-45E3-94F5-6380EB2F0989"")
{
ISpace[""UI_GridPanelTwo""].Visible=""false"";ISpace[""UI_GridPanelTwo""].Enbl=""true"";
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
private void SubscribeElementEvents_mf_receiptsview_nextbutton (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MF_ReceiptsView_NextButton-OnClick");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value>0)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value>0)");
ISpace["MF_ExpenseDetails_PageIndex"].Value=ISpace["MF_ExpenseDetails_PageIndex"].Value+1;
base.WriteDebugInfo(@"ISpace[""MF_ExpenseDetails_PageIndex""].Value=ISpace[""MF_ExpenseDetails_PageIndex""].Value+1;");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_ExpenseDetails_PageIndex"].Value=1;
base.WriteDebugInfo(@"ISpace[""MF_ExpenseDetails_PageIndex""].Value=1;");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySource94B9568E6AA646109AB971682A69C231 =GetQueryExpressionDataSource("94B9568E-6AA6-4610-9AB9-71682A69C231");

DataTable result94B9568E6AA646109AB971682A69C231=iSpace.SetGridDataSource(querySource94B9568E6AA646109AB971682A69C231, _objectFactory.GetGridRPP("ReceiptsView"),@"EXEC dbo.[Get_bd3abae8-b5a2-4b71-b3e2-e46732479592_FilterData] 1,'" + ISpace["F_ReceiptNo"].Value + @"',''," + ISpace["MF_ReceiptsView_PageIndex"].Value + @",'" + ISpace["MF_ReceiptsView_GridRows"].Value + @"','" + ISpace["F_ProjectDetailsID"].Value + @"'");

iSpace.InsertGridBindDetails("ReceiptsView","11",querySource94B9568E6AA646109AB971682A69C231,"EXEC dbo.[Get_bd3abae8-b5a2-4b71-b3e2-e46732479592_FilterData] 1,'" + ISpace["F_ReceiptNo"].Value + @"',''," + ISpace["MF_ReceiptsView_PageIndex"].Value + @",'" + ISpace["MF_ReceiptsView_GridRows"].Value + @"','" + ISpace["F_ProjectDetailsID"].Value + @"'",_objectFactory.GetGridRPP("ReceiptsView"));

base.WriteDebugInfo(@"var querySource94B9568E6AA646109AB971682A69C231 =GetQueryExpressionDataSource(""94B9568E-6AA6-4610-9AB9-71682A69C231"");DataTable result94B9568E6AA646109AB971682A69C231=iSpace.SetGridDataSource(querySource94B9568E6AA646109AB971682A69C231, _objectFactory.GetGridRPP(""ReceiptsView""),@""EXEC dbo.[Get_bd3abae8-b5a2-4b71-b3e2-e46732479592_FilterData] 1,'"" + ISpace[""F_ReceiptNo""].Value + @""','',"" + ISpace[""MF_ReceiptsView_PageIndex""].Value + @"",'"" + ISpace[""MF_ReceiptsView_GridRows""].Value + @""','"" + ISpace[""F_ProjectDetailsID""].Value + @""'"");iSpace.InsertGridBindDetails(""ReceiptsView"",""11"",querySource94B9568E6AA646109AB971682A69C231,""EXEC dbo.[Get_bd3abae8-b5a2-4b71-b3e2-e46732479592_FilterData] 1,'"" + ISpace[""F_ReceiptNo""].Value + @""','',"" + ISpace[""MF_ReceiptsView_PageIndex""].Value + @"",'"" + ISpace[""MF_ReceiptsView_GridRows""].Value + @""','"" + ISpace[""F_ProjectDetailsID""].Value + @""'"",_objectFactory.GetGridRPP(""ReceiptsView""));");
base.WriteDebugInfo(@"EXEC dbo.[Get_bd3abae8-b5a2-4b71-b3e2-e46732479592_FilterData] 1,'#F_ReceiptNo','',#MF_ReceiptsView_PageIndex,'#MF_ReceiptsView_GridRows'");


List<Triplet<string, short, short?>> result6C0E534F5B5649E8BDBDB1A399E4F9C5=acdataIspace585BA2B83E754DABB50B10D8320CE414.GetQueryExpressionBindings("6C0E534F-5B56-49E8-BDBD-B1A399E4F9C5");
iSpace.SetGridData(result94B9568E6AA646109AB971682A69C231,result6C0E534F5B5649E8BDBDB1A399E4F9C5,"ReceiptsView",ref ISpace);
iSpace.UpdateGridBindDetails("ReceiptsView",result6C0E534F5B5649E8BDBDB1A399E4F9C5);
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'#F_ProjectDetailsId','',#MF_ExpenseDetails_PageIndex,'#MF_ExpenseDetails_GridRows'");

var querySource108B5BFD045B42D7A031893FCF404252 =GetQueryExpressionDataSource("108B5BFD-045B-42D7-A031-893FCF404252");
Dictionary<short,object> result108B5BFD045B42D7A031893FCF404252=iSpace.ExecuteQuery(querySource108B5BFD045B42D7A031893FCF404252,@"EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'" + ISpace["F_ProjectDetailsId"].Value + @"',''," + ISpace["MF_ExpenseDetails_PageIndex"].Value + @",'" + ISpace["MF_ExpenseDetails_GridRows"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource108B5BFD045B42D7A031893FCF404252 =GetQueryExpressionDataSource(""108B5BFD-045B-42D7-A031-893FCF404252"");Dictionary<short,object> result108B5BFD045B42D7A031893FCF404252=iSpace.ExecuteQuery(querySource108B5BFD045B42D7A031893FCF404252,@""EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',"" + ISpace[""MF_ExpenseDetails_PageIndex""].Value + @"",'"" + ISpace[""MF_ExpenseDetails_GridRows""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result108B5BFD045B42D7A031893FCF404252!=null) && (result108B5BFD045B42D7A031893FCF404252.Count!=0))
{
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(0))
ISpace["MF_Budgetdetails_GridRows"].Value = result108B5BFD045B42D7A031893FCF404252[0];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(3))
ISpace["MF_Budgetdetails_TotalPages"].Value = result108B5BFD045B42D7A031893FCF404252[3];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(2))
ISpace["MF_Budgetdetails_PageIndex"].Value = result108B5BFD045B42D7A031893FCF404252[2];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(1))
ISpace["MF_Budgetdetails_RecordsRange"].Value = result108B5BFD045B42D7A031893FCF404252[1];
}
else{
ISpace["MF_Budgetdetails_GridRows"].Value = null;ISpace["MF_Budgetdetails_TotalPages"].Value = null;ISpace["MF_Budgetdetails_PageIndex"].Value = null;ISpace["MF_Budgetdetails_RecordsRange"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==1)");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==ISpace["MF_ExpenseDetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==ISpace[""MF_ExpenseDetails_TotalPages""].Value)");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="false";ISpace["MF_Budgetdetails_LastButton"].Enbl="false";ISpace["MF_Budgetdetails_NextButton"].Enbl="false";ISpace["MF_Budgetdetails_FirstButton"].Enbl="false";ISpace["MF_Budgetdetails_PageIndex"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""false"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="false";ISpace["MF_Budgetdetails_LastButton"].Enbl="true";ISpace["MF_Budgetdetails_NextButton"].Enbl="true";ISpace["MF_Budgetdetails_FirstButton"].Enbl="false";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
}
else
{
base.WriteDebugInfo(@"else");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==ISpace["MF_ExpenseDetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==ISpace[""MF_ExpenseDetails_TotalPages""].Value)");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="true";ISpace["MF_Budgetdetails_LastButton"].Enbl="false";ISpace["MF_Budgetdetails_NextButton"].Enbl="false";ISpace["MF_Budgetdetails_FirstButton"].Enbl="true";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="true";ISpace["MF_Budgetdetails_LastButton"].Enbl="true";ISpace["MF_Budgetdetails_NextButton"].Enbl="true";ISpace["MF_Budgetdetails_FirstButton"].Enbl="true";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
}
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
ISpace["MF_ExpenseDetails_PageIndex"].Value=0;
base.WriteDebugInfo(@"ISpace[""MF_ExpenseDetails_PageIndex""].Value=0;");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'#F_ProjectDetailsId','',#MF_ExpenseDetails_PageIndex,'#MF_ExpenseDetails_GridRows'");

var querySource108B5BFD045B42D7A031893FCF404252 =GetQueryExpressionDataSource("108B5BFD-045B-42D7-A031-893FCF404252");
Dictionary<short,object> result108B5BFD045B42D7A031893FCF404252=iSpace.ExecuteQuery(querySource108B5BFD045B42D7A031893FCF404252,@"EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'" + ISpace["F_ProjectDetailsId"].Value + @"',''," + ISpace["MF_ExpenseDetails_PageIndex"].Value + @",'" + ISpace["MF_ExpenseDetails_GridRows"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource108B5BFD045B42D7A031893FCF404252 =GetQueryExpressionDataSource(""108B5BFD-045B-42D7-A031-893FCF404252"");Dictionary<short,object> result108B5BFD045B42D7A031893FCF404252=iSpace.ExecuteQuery(querySource108B5BFD045B42D7A031893FCF404252,@""EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',"" + ISpace[""MF_ExpenseDetails_PageIndex""].Value + @"",'"" + ISpace[""MF_ExpenseDetails_GridRows""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result108B5BFD045B42D7A031893FCF404252!=null) && (result108B5BFD045B42D7A031893FCF404252.Count!=0))
{
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(0))
ISpace["MF_Budgetdetails_GridRows"].Value = result108B5BFD045B42D7A031893FCF404252[0];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(3))
ISpace["MF_Budgetdetails_TotalPages"].Value = result108B5BFD045B42D7A031893FCF404252[3];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(2))
ISpace["MF_Budgetdetails_PageIndex"].Value = result108B5BFD045B42D7A031893FCF404252[2];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(1))
ISpace["MF_Budgetdetails_RecordsRange"].Value = result108B5BFD045B42D7A031893FCF404252[1];
}
else{
ISpace["MF_Budgetdetails_GridRows"].Value = null;ISpace["MF_Budgetdetails_TotalPages"].Value = null;ISpace["MF_Budgetdetails_PageIndex"].Value = null;ISpace["MF_Budgetdetails_RecordsRange"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==1)");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==ISpace["MF_ExpenseDetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==ISpace[""MF_ExpenseDetails_TotalPages""].Value)");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="false";ISpace["MF_Budgetdetails_LastButton"].Enbl="false";ISpace["MF_Budgetdetails_NextButton"].Enbl="false";ISpace["MF_Budgetdetails_FirstButton"].Enbl="false";ISpace["MF_Budgetdetails_PageIndex"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""false"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="false";ISpace["MF_Budgetdetails_LastButton"].Enbl="true";ISpace["MF_Budgetdetails_NextButton"].Enbl="true";ISpace["MF_Budgetdetails_FirstButton"].Enbl="false";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
}
else
{
base.WriteDebugInfo(@"else");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==ISpace["MF_ExpenseDetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==ISpace[""MF_ExpenseDetails_TotalPages""].Value)");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="true";ISpace["MF_Budgetdetails_LastButton"].Enbl="false";ISpace["MF_Budgetdetails_NextButton"].Enbl="false";ISpace["MF_Budgetdetails_FirstButton"].Enbl="true";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="true";ISpace["MF_Budgetdetails_LastButton"].Enbl="true";ISpace["MF_Budgetdetails_NextButton"].Enbl="true";ISpace["MF_Budgetdetails_FirstButton"].Enbl="true";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySourceA30F7872734E4D34AFDDD8F49130791A =GetQueryExpressionDataSource("A30F7872-734E-4D34-AFDD-D8F49130791A");

DataTable resultA30F7872734E4D34AFDDD8F49130791A=iSpace.SetGridDataSource(querySourceA30F7872734E4D34AFDDD8F49130791A, _objectFactory.GetGridRPP("Budgetdetails"),@"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 1,'" + ISpace["F_BudgetHeadId"].Value + @"',''," + ISpace["MF_Budgetdetails_PageIndex"].Value + @",'" + ISpace["MF_Budgetdetails_GridRows"].Value + @"','" + ISpace["F_ProjectDetailsId"].Value + @"'");

iSpace.InsertGridBindDetails("Budgetdetails","11",querySourceA30F7872734E4D34AFDDD8F49130791A,"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 1,'" + ISpace["F_BudgetHeadId"].Value + @"',''," + ISpace["MF_Budgetdetails_PageIndex"].Value + @",'" + ISpace["MF_Budgetdetails_GridRows"].Value + @"','" + ISpace["F_ProjectDetailsId"].Value + @"'",_objectFactory.GetGridRPP("Budgetdetails"));

base.WriteDebugInfo(@"var querySourceA30F7872734E4D34AFDDD8F49130791A =GetQueryExpressionDataSource(""A30F7872-734E-4D34-AFDD-D8F49130791A"");DataTable resultA30F7872734E4D34AFDDD8F49130791A=iSpace.SetGridDataSource(querySourceA30F7872734E4D34AFDDD8F49130791A, _objectFactory.GetGridRPP(""Budgetdetails""),@""EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 1,'"" + ISpace[""F_BudgetHeadId""].Value + @""','',"" + ISpace[""MF_Budgetdetails_PageIndex""].Value + @"",'"" + ISpace[""MF_Budgetdetails_GridRows""].Value + @""','"" + ISpace[""F_ProjectDetailsId""].Value + @""'"");iSpace.InsertGridBindDetails(""Budgetdetails"",""11"",querySourceA30F7872734E4D34AFDDD8F49130791A,""EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 1,'"" + ISpace[""F_BudgetHeadId""].Value + @""','',"" + ISpace[""MF_Budgetdetails_PageIndex""].Value + @"",'"" + ISpace[""MF_Budgetdetails_GridRows""].Value + @""','"" + ISpace[""F_ProjectDetailsId""].Value + @""'"",_objectFactory.GetGridRPP(""Budgetdetails""));");
base.WriteDebugInfo(@"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 1,'#F_BudgetHeadId','',#MF_Budgetdetails_PageIndex,'#MF_Budgetdetails_GridRows'");


List<Triplet<string, short, short?>> result387A33C1D74545BDA9129E364AE2D589=acdataIspace585BA2B83E754DABB50B10D8320CE414.GetQueryExpressionBindings("387A33C1-D745-45BD-A912-9E364AE2D589");
iSpace.SetGridData(resultA30F7872734E4D34AFDDD8F49130791A,result387A33C1D74545BDA9129E364AE2D589,"Budgetdetails",ref ISpace);
iSpace.UpdateGridBindDetails("Budgetdetails",result387A33C1D74545BDA9129E364AE2D589);
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

var querySourceCA82683BCA014525A93F68B518D9FCFA =GetQueryExpressionDataSource("CA82683B-CA01-4525-A93F-68B518D9FCFA");

DataTable resultCA82683BCA014525A93F68B518D9FCFA=iSpace.SetGridDataSource(querySourceCA82683BCA014525A93F68B518D9FCFA, _objectFactory.GetGridRPP("ProjectCommitments"),@"EXEC dbo.[Get_e046fb44-e1f1-4f2a-a07e-231e72f92166_FilterData] 1,'" + ISpace["F_ProjectDetailsId"].Value + @"',''," + ISpace["MF_ProjectCommitments_PageIndex"].Value + @",'" + ISpace["MF_ProjectCommitments_GridRows"].Value + @"'");

iSpace.InsertGridBindDetails("ProjectCommitments","11",querySourceCA82683BCA014525A93F68B518D9FCFA,"EXEC dbo.[Get_e046fb44-e1f1-4f2a-a07e-231e72f92166_FilterData] 1,'" + ISpace["F_ProjectDetailsId"].Value + @"',''," + ISpace["MF_ProjectCommitments_PageIndex"].Value + @",'" + ISpace["MF_ProjectCommitments_GridRows"].Value + @"'",_objectFactory.GetGridRPP("ProjectCommitments"));

base.WriteDebugInfo(@"var querySourceCA82683BCA014525A93F68B518D9FCFA =GetQueryExpressionDataSource(""CA82683B-CA01-4525-A93F-68B518D9FCFA"");DataTable resultCA82683BCA014525A93F68B518D9FCFA=iSpace.SetGridDataSource(querySourceCA82683BCA014525A93F68B518D9FCFA, _objectFactory.GetGridRPP(""ProjectCommitments""),@""EXEC dbo.[Get_e046fb44-e1f1-4f2a-a07e-231e72f92166_FilterData] 1,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',"" + ISpace[""MF_ProjectCommitments_PageIndex""].Value + @"",'"" + ISpace[""MF_ProjectCommitments_GridRows""].Value + @""'"");iSpace.InsertGridBindDetails(""ProjectCommitments"",""11"",querySourceCA82683BCA014525A93F68B518D9FCFA,""EXEC dbo.[Get_e046fb44-e1f1-4f2a-a07e-231e72f92166_FilterData] 1,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',"" + ISpace[""MF_ProjectCommitments_PageIndex""].Value + @"",'"" + ISpace[""MF_ProjectCommitments_GridRows""].Value + @""'"",_objectFactory.GetGridRPP(""ProjectCommitments""));");
base.WriteDebugInfo(@"EXEC dbo.[Get_e046fb44-e1f1-4f2a-a07e-231e72f92166_FilterData] 1,'#F_ProjectDetailsId','',#MF_ProjectCommitments_PageIndex,'#MF_ProjectCommitments_GridRows'");


List<Triplet<string, short, short?>> resultF24D61150F9946679299168E58B151A1=acdataIspace585BA2B83E754DABB50B10D8320CE414.GetQueryExpressionBindings("F24D6115-0F99-4667-9299-168E58B151A1");
iSpace.SetGridData(resultCA82683BCA014525A93F68B518D9FCFA,resultF24D61150F9946679299168E58B151A1,"ProjectCommitments",ref ISpace);
iSpace.UpdateGridBindDetails("ProjectCommitments",resultF24D61150F9946679299168E58B151A1);
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySource94B9568E6AA646109AB971682A69C231 =GetQueryExpressionDataSource("94B9568E-6AA6-4610-9AB9-71682A69C231");

DataTable result94B9568E6AA646109AB971682A69C231=iSpace.SetGridDataSource(querySource94B9568E6AA646109AB971682A69C231, _objectFactory.GetGridRPP("ReceiptsView"),@"EXEC dbo.[Get_bd3abae8-b5a2-4b71-b3e2-e46732479592_FilterData] 1,'" + ISpace["F_ReceiptNo"].Value + @"',''," + ISpace["MF_ReceiptsView_PageIndex"].Value + @",'" + ISpace["MF_ReceiptsView_GridRows"].Value + @"','" + ISpace["F_ProjectDetailsID"].Value + @"'");

iSpace.InsertGridBindDetails("ReceiptsView","11",querySource94B9568E6AA646109AB971682A69C231,"EXEC dbo.[Get_bd3abae8-b5a2-4b71-b3e2-e46732479592_FilterData] 1,'" + ISpace["F_ReceiptNo"].Value + @"',''," + ISpace["MF_ReceiptsView_PageIndex"].Value + @",'" + ISpace["MF_ReceiptsView_GridRows"].Value + @"','" + ISpace["F_ProjectDetailsID"].Value + @"'",_objectFactory.GetGridRPP("ReceiptsView"));

base.WriteDebugInfo(@"var querySource94B9568E6AA646109AB971682A69C231 =GetQueryExpressionDataSource(""94B9568E-6AA6-4610-9AB9-71682A69C231"");DataTable result94B9568E6AA646109AB971682A69C231=iSpace.SetGridDataSource(querySource94B9568E6AA646109AB971682A69C231, _objectFactory.GetGridRPP(""ReceiptsView""),@""EXEC dbo.[Get_bd3abae8-b5a2-4b71-b3e2-e46732479592_FilterData] 1,'"" + ISpace[""F_ReceiptNo""].Value + @""','',"" + ISpace[""MF_ReceiptsView_PageIndex""].Value + @"",'"" + ISpace[""MF_ReceiptsView_GridRows""].Value + @""','"" + ISpace[""F_ProjectDetailsID""].Value + @""'"");iSpace.InsertGridBindDetails(""ReceiptsView"",""11"",querySource94B9568E6AA646109AB971682A69C231,""EXEC dbo.[Get_bd3abae8-b5a2-4b71-b3e2-e46732479592_FilterData] 1,'"" + ISpace[""F_ReceiptNo""].Value + @""','',"" + ISpace[""MF_ReceiptsView_PageIndex""].Value + @"",'"" + ISpace[""MF_ReceiptsView_GridRows""].Value + @""','"" + ISpace[""F_ProjectDetailsID""].Value + @""'"",_objectFactory.GetGridRPP(""ReceiptsView""));");
base.WriteDebugInfo(@"EXEC dbo.[Get_bd3abae8-b5a2-4b71-b3e2-e46732479592_FilterData] 1,'#F_ReceiptNo','',#MF_ReceiptsView_PageIndex,'#MF_ReceiptsView_GridRows'");


List<Triplet<string, short, short?>> result6C0E534F5B5649E8BDBDB1A399E4F9C5=acdataIspace585BA2B83E754DABB50B10D8320CE414.GetQueryExpressionBindings("6C0E534F-5B56-49E8-BDBD-B1A399E4F9C5");
iSpace.SetGridData(result94B9568E6AA646109AB971682A69C231,result6C0E534F5B5649E8BDBDB1A399E4F9C5,"ReceiptsView",ref ISpace);
iSpace.UpdateGridBindDetails("ReceiptsView",result6C0E534F5B5649E8BDBDB1A399E4F9C5);
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySourceFC2A5065A4C24EC0B017375CE0B0B812 =GetQueryExpressionDataSource("FC2A5065-A4C2-4EC0-B017-375CE0B0B812");

DataTable resultFC2A5065A4C24EC0B017375CE0B0B812=iSpace.SetGridDataSource(querySourceFC2A5065A4C24EC0B017375CE0B0B812, _objectFactory.GetGridRPP("ExpenseDetails"),@"EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 1,'" + ISpace["F_ProjectDetailsId"].Value + @"',''," + ISpace["MF_ExpenseDetails_PageIndex"].Value + @",'" + ISpace["MF_ExpenseDetails_GridRows"].Value + @"'");

iSpace.InsertGridBindDetails("ExpenseDetails","11",querySourceFC2A5065A4C24EC0B017375CE0B0B812,"EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 1,'" + ISpace["F_ProjectDetailsId"].Value + @"',''," + ISpace["MF_ExpenseDetails_PageIndex"].Value + @",'" + ISpace["MF_ExpenseDetails_GridRows"].Value + @"'",_objectFactory.GetGridRPP("ExpenseDetails"));

base.WriteDebugInfo(@"var querySourceFC2A5065A4C24EC0B017375CE0B0B812 =GetQueryExpressionDataSource(""FC2A5065-A4C2-4EC0-B017-375CE0B0B812"");DataTable resultFC2A5065A4C24EC0B017375CE0B0B812=iSpace.SetGridDataSource(querySourceFC2A5065A4C24EC0B017375CE0B0B812, _objectFactory.GetGridRPP(""ExpenseDetails""),@""EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 1,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',"" + ISpace[""MF_ExpenseDetails_PageIndex""].Value + @"",'"" + ISpace[""MF_ExpenseDetails_GridRows""].Value + @""'"");iSpace.InsertGridBindDetails(""ExpenseDetails"",""11"",querySourceFC2A5065A4C24EC0B017375CE0B0B812,""EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 1,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',"" + ISpace[""MF_ExpenseDetails_PageIndex""].Value + @"",'"" + ISpace[""MF_ExpenseDetails_GridRows""].Value + @""'"",_objectFactory.GetGridRPP(""ExpenseDetails""));");
base.WriteDebugInfo(@"EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 1,'#F_ExpenseId','',#MF_ExpenseDetails_PageIndex,'#MF_ExpenseDetails_GridRows'");


List<Triplet<string, short, short?>> resultF156A8611F4D43F2884E90DD3F9E66E3=acdataIspace585BA2B83E754DABB50B10D8320CE414.GetQueryExpressionBindings("F156A861-1F4D-43F2-884E-90DD3F9E66E3");
iSpace.SetGridData(resultFC2A5065A4C24EC0B017375CE0B0B812,resultF156A8611F4D43F2884E90DD3F9E66E3,"ExpenseDetails",ref ISpace);
iSpace.UpdateGridBindDetails("ExpenseDetails",resultF156A8611F4D43F2884E90DD3F9E66E3);
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'#F_ProjectDetailsId','',#MF_ExpenseDetails_PageIndex,'#MF_ExpenseDetails_GridRows'");

var querySource108B5BFD045B42D7A031893FCF404252 =GetQueryExpressionDataSource("108B5BFD-045B-42D7-A031-893FCF404252");
Dictionary<short,object> result108B5BFD045B42D7A031893FCF404252=iSpace.ExecuteQuery(querySource108B5BFD045B42D7A031893FCF404252,@"EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'" + ISpace["F_ProjectDetailsId"].Value + @"',''," + ISpace["MF_ExpenseDetails_PageIndex"].Value + @",'" + ISpace["MF_ExpenseDetails_GridRows"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource108B5BFD045B42D7A031893FCF404252 =GetQueryExpressionDataSource(""108B5BFD-045B-42D7-A031-893FCF404252"");Dictionary<short,object> result108B5BFD045B42D7A031893FCF404252=iSpace.ExecuteQuery(querySource108B5BFD045B42D7A031893FCF404252,@""EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',"" + ISpace[""MF_ExpenseDetails_PageIndex""].Value + @"",'"" + ISpace[""MF_ExpenseDetails_GridRows""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result108B5BFD045B42D7A031893FCF404252!=null) && (result108B5BFD045B42D7A031893FCF404252.Count!=0))
{
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(0))
ISpace["MF_Budgetdetails_GridRows"].Value = result108B5BFD045B42D7A031893FCF404252[0];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(3))
ISpace["MF_Budgetdetails_TotalPages"].Value = result108B5BFD045B42D7A031893FCF404252[3];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(2))
ISpace["MF_Budgetdetails_PageIndex"].Value = result108B5BFD045B42D7A031893FCF404252[2];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(1))
ISpace["MF_Budgetdetails_RecordsRange"].Value = result108B5BFD045B42D7A031893FCF404252[1];
}
else{
ISpace["MF_Budgetdetails_GridRows"].Value = null;ISpace["MF_Budgetdetails_TotalPages"].Value = null;ISpace["MF_Budgetdetails_PageIndex"].Value = null;ISpace["MF_Budgetdetails_RecordsRange"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'#F_ProjectDetailsId','',#MF_ExpenseDetails_PageIndex,'#MF_ExpenseDetails_GridRows'");

var querySource108B5BFD045B42D7A031893FCF404252 =GetQueryExpressionDataSource("108B5BFD-045B-42D7-A031-893FCF404252");
Dictionary<short,object> result108B5BFD045B42D7A031893FCF404252=iSpace.ExecuteQuery(querySource108B5BFD045B42D7A031893FCF404252,@"EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'" + ISpace["F_ProjectDetailsId"].Value + @"',''," + ISpace["MF_ExpenseDetails_PageIndex"].Value + @",'" + ISpace["MF_ExpenseDetails_GridRows"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource108B5BFD045B42D7A031893FCF404252 =GetQueryExpressionDataSource(""108B5BFD-045B-42D7-A031-893FCF404252"");Dictionary<short,object> result108B5BFD045B42D7A031893FCF404252=iSpace.ExecuteQuery(querySource108B5BFD045B42D7A031893FCF404252,@""EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',"" + ISpace[""MF_ExpenseDetails_PageIndex""].Value + @"",'"" + ISpace[""MF_ExpenseDetails_GridRows""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result108B5BFD045B42D7A031893FCF404252!=null) && (result108B5BFD045B42D7A031893FCF404252.Count!=0))
{
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(0))
ISpace["MF_Budgetdetails_GridRows"].Value = result108B5BFD045B42D7A031893FCF404252[0];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(3))
ISpace["MF_Budgetdetails_TotalPages"].Value = result108B5BFD045B42D7A031893FCF404252[3];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(2))
ISpace["MF_Budgetdetails_PageIndex"].Value = result108B5BFD045B42D7A031893FCF404252[2];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(1))
ISpace["MF_Budgetdetails_RecordsRange"].Value = result108B5BFD045B42D7A031893FCF404252[1];
}
else{
ISpace["MF_Budgetdetails_GridRows"].Value = null;ISpace["MF_Budgetdetails_TotalPages"].Value = null;ISpace["MF_Budgetdetails_PageIndex"].Value = null;ISpace["MF_Budgetdetails_RecordsRange"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'#F_ProjectDetailsId','',#MF_ExpenseDetails_PageIndex,'#MF_ExpenseDetails_GridRows'");

var querySource108B5BFD045B42D7A031893FCF404252 =GetQueryExpressionDataSource("108B5BFD-045B-42D7-A031-893FCF404252");
Dictionary<short,object> result108B5BFD045B42D7A031893FCF404252=iSpace.ExecuteQuery(querySource108B5BFD045B42D7A031893FCF404252,@"EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'" + ISpace["F_ProjectDetailsId"].Value + @"',''," + ISpace["MF_ExpenseDetails_PageIndex"].Value + @",'" + ISpace["MF_ExpenseDetails_GridRows"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource108B5BFD045B42D7A031893FCF404252 =GetQueryExpressionDataSource(""108B5BFD-045B-42D7-A031-893FCF404252"");Dictionary<short,object> result108B5BFD045B42D7A031893FCF404252=iSpace.ExecuteQuery(querySource108B5BFD045B42D7A031893FCF404252,@""EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',"" + ISpace[""MF_ExpenseDetails_PageIndex""].Value + @"",'"" + ISpace[""MF_ExpenseDetails_GridRows""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result108B5BFD045B42D7A031893FCF404252!=null) && (result108B5BFD045B42D7A031893FCF404252.Count!=0))
{
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(0))
ISpace["MF_Budgetdetails_GridRows"].Value = result108B5BFD045B42D7A031893FCF404252[0];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(3))
ISpace["MF_Budgetdetails_TotalPages"].Value = result108B5BFD045B42D7A031893FCF404252[3];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(2))
ISpace["MF_Budgetdetails_PageIndex"].Value = result108B5BFD045B42D7A031893FCF404252[2];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(1))
ISpace["MF_Budgetdetails_RecordsRange"].Value = result108B5BFD045B42D7A031893FCF404252[1];
}
else{
ISpace["MF_Budgetdetails_GridRows"].Value = null;ISpace["MF_Budgetdetails_TotalPages"].Value = null;ISpace["MF_Budgetdetails_PageIndex"].Value = null;ISpace["MF_Budgetdetails_RecordsRange"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'#F_ProjectDetailsId','',#MF_ExpenseDetails_PageIndex,'#MF_ExpenseDetails_GridRows'");

var querySource108B5BFD045B42D7A031893FCF404252 =GetQueryExpressionDataSource("108B5BFD-045B-42D7-A031-893FCF404252");
Dictionary<short,object> result108B5BFD045B42D7A031893FCF404252=iSpace.ExecuteQuery(querySource108B5BFD045B42D7A031893FCF404252,@"EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'" + ISpace["F_ProjectDetailsId"].Value + @"',''," + ISpace["MF_ExpenseDetails_PageIndex"].Value + @",'" + ISpace["MF_ExpenseDetails_GridRows"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource108B5BFD045B42D7A031893FCF404252 =GetQueryExpressionDataSource(""108B5BFD-045B-42D7-A031-893FCF404252"");Dictionary<short,object> result108B5BFD045B42D7A031893FCF404252=iSpace.ExecuteQuery(querySource108B5BFD045B42D7A031893FCF404252,@""EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',"" + ISpace[""MF_ExpenseDetails_PageIndex""].Value + @"",'"" + ISpace[""MF_ExpenseDetails_GridRows""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result108B5BFD045B42D7A031893FCF404252!=null) && (result108B5BFD045B42D7A031893FCF404252.Count!=0))
{
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(0))
ISpace["MF_Budgetdetails_GridRows"].Value = result108B5BFD045B42D7A031893FCF404252[0];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(3))
ISpace["MF_Budgetdetails_TotalPages"].Value = result108B5BFD045B42D7A031893FCF404252[3];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(2))
ISpace["MF_Budgetdetails_PageIndex"].Value = result108B5BFD045B42D7A031893FCF404252[2];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(1))
ISpace["MF_Budgetdetails_RecordsRange"].Value = result108B5BFD045B42D7A031893FCF404252[1];
}
else{
ISpace["MF_Budgetdetails_GridRows"].Value = null;ISpace["MF_Budgetdetails_TotalPages"].Value = null;ISpace["MF_Budgetdetails_PageIndex"].Value = null;ISpace["MF_Budgetdetails_RecordsRange"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==1)");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==ISpace["MF_ExpenseDetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==ISpace[""MF_ExpenseDetails_TotalPages""].Value)");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="false";ISpace["MF_Budgetdetails_LastButton"].Enbl="false";ISpace["MF_Budgetdetails_NextButton"].Enbl="false";ISpace["MF_Budgetdetails_FirstButton"].Enbl="false";ISpace["MF_Budgetdetails_PageIndex"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""false"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="false";ISpace["MF_Budgetdetails_LastButton"].Enbl="true";ISpace["MF_Budgetdetails_NextButton"].Enbl="true";ISpace["MF_Budgetdetails_FirstButton"].Enbl="false";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
}
else
{
base.WriteDebugInfo(@"else");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==ISpace["MF_ExpenseDetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==ISpace[""MF_ExpenseDetails_TotalPages""].Value)");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="true";ISpace["MF_Budgetdetails_LastButton"].Enbl="false";ISpace["MF_Budgetdetails_NextButton"].Enbl="false";ISpace["MF_Budgetdetails_FirstButton"].Enbl="true";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="true";ISpace["MF_Budgetdetails_LastButton"].Enbl="true";ISpace["MF_Budgetdetails_NextButton"].Enbl="true";ISpace["MF_Budgetdetails_FirstButton"].Enbl="true";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==1)");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==ISpace["MF_ExpenseDetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==ISpace[""MF_ExpenseDetails_TotalPages""].Value)");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="false";ISpace["MF_Budgetdetails_LastButton"].Enbl="false";ISpace["MF_Budgetdetails_NextButton"].Enbl="false";ISpace["MF_Budgetdetails_FirstButton"].Enbl="false";ISpace["MF_Budgetdetails_PageIndex"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""false"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="false";ISpace["MF_Budgetdetails_LastButton"].Enbl="true";ISpace["MF_Budgetdetails_NextButton"].Enbl="true";ISpace["MF_Budgetdetails_FirstButton"].Enbl="false";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
}
else
{
base.WriteDebugInfo(@"else");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==ISpace["MF_ExpenseDetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==ISpace[""MF_ExpenseDetails_TotalPages""].Value)");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="true";ISpace["MF_Budgetdetails_LastButton"].Enbl="false";ISpace["MF_Budgetdetails_NextButton"].Enbl="false";ISpace["MF_Budgetdetails_FirstButton"].Enbl="true";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="true";ISpace["MF_Budgetdetails_LastButton"].Enbl="true";ISpace["MF_Budgetdetails_NextButton"].Enbl="true";ISpace["MF_Budgetdetails_FirstButton"].Enbl="true";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==1)");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==ISpace["MF_ExpenseDetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==ISpace[""MF_ExpenseDetails_TotalPages""].Value)");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="false";ISpace["MF_Budgetdetails_LastButton"].Enbl="false";ISpace["MF_Budgetdetails_NextButton"].Enbl="false";ISpace["MF_Budgetdetails_FirstButton"].Enbl="false";ISpace["MF_Budgetdetails_PageIndex"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""false"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="false";ISpace["MF_Budgetdetails_LastButton"].Enbl="true";ISpace["MF_Budgetdetails_NextButton"].Enbl="true";ISpace["MF_Budgetdetails_FirstButton"].Enbl="false";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
}
else
{
base.WriteDebugInfo(@"else");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==ISpace["MF_ExpenseDetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==ISpace[""MF_ExpenseDetails_TotalPages""].Value)");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="true";ISpace["MF_Budgetdetails_LastButton"].Enbl="false";ISpace["MF_Budgetdetails_NextButton"].Enbl="false";ISpace["MF_Budgetdetails_FirstButton"].Enbl="true";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="true";ISpace["MF_Budgetdetails_LastButton"].Enbl="true";ISpace["MF_Budgetdetails_NextButton"].Enbl="true";ISpace["MF_Budgetdetails_FirstButton"].Enbl="true";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==1)");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==ISpace["MF_ExpenseDetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==ISpace[""MF_ExpenseDetails_TotalPages""].Value)");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="false";ISpace["MF_Budgetdetails_LastButton"].Enbl="false";ISpace["MF_Budgetdetails_NextButton"].Enbl="false";ISpace["MF_Budgetdetails_FirstButton"].Enbl="false";ISpace["MF_Budgetdetails_PageIndex"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""false"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="false";ISpace["MF_Budgetdetails_LastButton"].Enbl="true";ISpace["MF_Budgetdetails_NextButton"].Enbl="true";ISpace["MF_Budgetdetails_FirstButton"].Enbl="false";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
}
else
{
base.WriteDebugInfo(@"else");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==ISpace["MF_ExpenseDetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==ISpace[""MF_ExpenseDetails_TotalPages""].Value)");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="true";ISpace["MF_Budgetdetails_LastButton"].Enbl="false";ISpace["MF_Budgetdetails_NextButton"].Enbl="false";ISpace["MF_Budgetdetails_FirstButton"].Enbl="true";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="true";ISpace["MF_Budgetdetails_LastButton"].Enbl="true";ISpace["MF_Budgetdetails_NextButton"].Enbl="true";ISpace["MF_Budgetdetails_FirstButton"].Enbl="true";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySourceA30F7872734E4D34AFDDD8F49130791A =GetQueryExpressionDataSource("A30F7872-734E-4D34-AFDD-D8F49130791A");

DataTable resultA30F7872734E4D34AFDDD8F49130791A=iSpace.SetGridDataSource(querySourceA30F7872734E4D34AFDDD8F49130791A, _objectFactory.GetGridRPP("Budgetdetails"),@"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 1,'" + ISpace["F_BudgetHeadId"].Value + @"',''," + ISpace["MF_Budgetdetails_PageIndex"].Value + @",'" + ISpace["MF_Budgetdetails_GridRows"].Value + @"','" + ISpace["F_ProjectDetailsId"].Value + @"'");

iSpace.InsertGridBindDetails("Budgetdetails","11",querySourceA30F7872734E4D34AFDDD8F49130791A,"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 1,'" + ISpace["F_BudgetHeadId"].Value + @"',''," + ISpace["MF_Budgetdetails_PageIndex"].Value + @",'" + ISpace["MF_Budgetdetails_GridRows"].Value + @"','" + ISpace["F_ProjectDetailsId"].Value + @"'",_objectFactory.GetGridRPP("Budgetdetails"));

base.WriteDebugInfo(@"var querySourceA30F7872734E4D34AFDDD8F49130791A =GetQueryExpressionDataSource(""A30F7872-734E-4D34-AFDD-D8F49130791A"");DataTable resultA30F7872734E4D34AFDDD8F49130791A=iSpace.SetGridDataSource(querySourceA30F7872734E4D34AFDDD8F49130791A, _objectFactory.GetGridRPP(""Budgetdetails""),@""EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 1,'"" + ISpace[""F_BudgetHeadId""].Value + @""','',"" + ISpace[""MF_Budgetdetails_PageIndex""].Value + @"",'"" + ISpace[""MF_Budgetdetails_GridRows""].Value + @""','"" + ISpace[""F_ProjectDetailsId""].Value + @""'"");iSpace.InsertGridBindDetails(""Budgetdetails"",""11"",querySourceA30F7872734E4D34AFDDD8F49130791A,""EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 1,'"" + ISpace[""F_BudgetHeadId""].Value + @""','',"" + ISpace[""MF_Budgetdetails_PageIndex""].Value + @"",'"" + ISpace[""MF_Budgetdetails_GridRows""].Value + @""','"" + ISpace[""F_ProjectDetailsId""].Value + @""'"",_objectFactory.GetGridRPP(""Budgetdetails""));");
base.WriteDebugInfo(@"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 1,'#F_BudgetHeadId','',#MF_Budgetdetails_PageIndex,'#MF_Budgetdetails_GridRows'");


List<Triplet<string, short, short?>> result387A33C1D74545BDA9129E364AE2D589=acdataIspace585BA2B83E754DABB50B10D8320CE414.GetQueryExpressionBindings("387A33C1-D745-45BD-A912-9E364AE2D589");
iSpace.SetGridData(resultA30F7872734E4D34AFDDD8F49130791A,result387A33C1D74545BDA9129E364AE2D589,"Budgetdetails",ref ISpace);
iSpace.UpdateGridBindDetails("Budgetdetails",result387A33C1D74545BDA9129E364AE2D589);
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
ISpace["MF_ExpenseDetails_PageIndex"].Value=0;
base.WriteDebugInfo(@"ISpace[""MF_ExpenseDetails_PageIndex""].Value=0;");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySourceCA82683BCA014525A93F68B518D9FCFA =GetQueryExpressionDataSource("CA82683B-CA01-4525-A93F-68B518D9FCFA");

DataTable resultCA82683BCA014525A93F68B518D9FCFA=iSpace.SetGridDataSource(querySourceCA82683BCA014525A93F68B518D9FCFA, _objectFactory.GetGridRPP("ProjectCommitments"),@"EXEC dbo.[Get_e046fb44-e1f1-4f2a-a07e-231e72f92166_FilterData] 1,'" + ISpace["F_ProjectDetailsId"].Value + @"',''," + ISpace["MF_ProjectCommitments_PageIndex"].Value + @",'" + ISpace["MF_ProjectCommitments_GridRows"].Value + @"'");

iSpace.InsertGridBindDetails("ProjectCommitments","11",querySourceCA82683BCA014525A93F68B518D9FCFA,"EXEC dbo.[Get_e046fb44-e1f1-4f2a-a07e-231e72f92166_FilterData] 1,'" + ISpace["F_ProjectDetailsId"].Value + @"',''," + ISpace["MF_ProjectCommitments_PageIndex"].Value + @",'" + ISpace["MF_ProjectCommitments_GridRows"].Value + @"'",_objectFactory.GetGridRPP("ProjectCommitments"));

base.WriteDebugInfo(@"var querySourceCA82683BCA014525A93F68B518D9FCFA =GetQueryExpressionDataSource(""CA82683B-CA01-4525-A93F-68B518D9FCFA"");DataTable resultCA82683BCA014525A93F68B518D9FCFA=iSpace.SetGridDataSource(querySourceCA82683BCA014525A93F68B518D9FCFA, _objectFactory.GetGridRPP(""ProjectCommitments""),@""EXEC dbo.[Get_e046fb44-e1f1-4f2a-a07e-231e72f92166_FilterData] 1,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',"" + ISpace[""MF_ProjectCommitments_PageIndex""].Value + @"",'"" + ISpace[""MF_ProjectCommitments_GridRows""].Value + @""'"");iSpace.InsertGridBindDetails(""ProjectCommitments"",""11"",querySourceCA82683BCA014525A93F68B518D9FCFA,""EXEC dbo.[Get_e046fb44-e1f1-4f2a-a07e-231e72f92166_FilterData] 1,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',"" + ISpace[""MF_ProjectCommitments_PageIndex""].Value + @"",'"" + ISpace[""MF_ProjectCommitments_GridRows""].Value + @""'"",_objectFactory.GetGridRPP(""ProjectCommitments""));");
base.WriteDebugInfo(@"EXEC dbo.[Get_e046fb44-e1f1-4f2a-a07e-231e72f92166_FilterData] 1,'#F_ProjectDetailsId','',#MF_ProjectCommitments_PageIndex,'#MF_ProjectCommitments_GridRows'");


List<Triplet<string, short, short?>> resultF24D61150F9946679299168E58B151A1=acdataIspace585BA2B83E754DABB50B10D8320CE414.GetQueryExpressionBindings("F24D6115-0F99-4667-9299-168E58B151A1");
iSpace.SetGridData(resultCA82683BCA014525A93F68B518D9FCFA,resultF24D61150F9946679299168E58B151A1,"ProjectCommitments",ref ISpace);
iSpace.UpdateGridBindDetails("ProjectCommitments",resultF24D61150F9946679299168E58B151A1);
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'#F_ProjectDetailsId','',#MF_ExpenseDetails_PageIndex,'#MF_ExpenseDetails_GridRows'");

var querySource108B5BFD045B42D7A031893FCF404252 =GetQueryExpressionDataSource("108B5BFD-045B-42D7-A031-893FCF404252");
Dictionary<short,object> result108B5BFD045B42D7A031893FCF404252=iSpace.ExecuteQuery(querySource108B5BFD045B42D7A031893FCF404252,@"EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'" + ISpace["F_ProjectDetailsId"].Value + @"',''," + ISpace["MF_ExpenseDetails_PageIndex"].Value + @",'" + ISpace["MF_ExpenseDetails_GridRows"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource108B5BFD045B42D7A031893FCF404252 =GetQueryExpressionDataSource(""108B5BFD-045B-42D7-A031-893FCF404252"");Dictionary<short,object> result108B5BFD045B42D7A031893FCF404252=iSpace.ExecuteQuery(querySource108B5BFD045B42D7A031893FCF404252,@""EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',"" + ISpace[""MF_ExpenseDetails_PageIndex""].Value + @"",'"" + ISpace[""MF_ExpenseDetails_GridRows""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result108B5BFD045B42D7A031893FCF404252!=null) && (result108B5BFD045B42D7A031893FCF404252.Count!=0))
{
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(0))
ISpace["MF_Budgetdetails_GridRows"].Value = result108B5BFD045B42D7A031893FCF404252[0];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(3))
ISpace["MF_Budgetdetails_TotalPages"].Value = result108B5BFD045B42D7A031893FCF404252[3];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(2))
ISpace["MF_Budgetdetails_PageIndex"].Value = result108B5BFD045B42D7A031893FCF404252[2];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(1))
ISpace["MF_Budgetdetails_RecordsRange"].Value = result108B5BFD045B42D7A031893FCF404252[1];
}
else{
ISpace["MF_Budgetdetails_GridRows"].Value = null;ISpace["MF_Budgetdetails_TotalPages"].Value = null;ISpace["MF_Budgetdetails_PageIndex"].Value = null;ISpace["MF_Budgetdetails_RecordsRange"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==1)");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==ISpace["MF_ExpenseDetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==ISpace[""MF_ExpenseDetails_TotalPages""].Value)");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="false";ISpace["MF_Budgetdetails_LastButton"].Enbl="false";ISpace["MF_Budgetdetails_NextButton"].Enbl="false";ISpace["MF_Budgetdetails_FirstButton"].Enbl="false";ISpace["MF_Budgetdetails_PageIndex"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""false"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="false";ISpace["MF_Budgetdetails_LastButton"].Enbl="true";ISpace["MF_Budgetdetails_NextButton"].Enbl="true";ISpace["MF_Budgetdetails_FirstButton"].Enbl="false";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
}
else
{
base.WriteDebugInfo(@"else");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==ISpace["MF_ExpenseDetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==ISpace[""MF_ExpenseDetails_TotalPages""].Value)");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="true";ISpace["MF_Budgetdetails_LastButton"].Enbl="false";ISpace["MF_Budgetdetails_NextButton"].Enbl="false";ISpace["MF_Budgetdetails_FirstButton"].Enbl="true";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="true";ISpace["MF_Budgetdetails_LastButton"].Enbl="true";ISpace["MF_Budgetdetails_NextButton"].Enbl="true";ISpace["MF_Budgetdetails_FirstButton"].Enbl="true";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
}
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
if(ISpace["MF_ExpenseDetails_PageIndex"].Value>0)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value>0)");
ISpace["MF_ExpenseDetails_PageIndex"].Value=ISpace["MF_ExpenseDetails_PageIndex"].Value+1;
base.WriteDebugInfo(@"ISpace[""MF_ExpenseDetails_PageIndex""].Value=ISpace[""MF_ExpenseDetails_PageIndex""].Value+1;");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_ExpenseDetails_PageIndex"].Value=1;
base.WriteDebugInfo(@"ISpace[""MF_ExpenseDetails_PageIndex""].Value=1;");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'#F_ProjectDetailsId','',#MF_ExpenseDetails_PageIndex,'#MF_ExpenseDetails_GridRows'");

var querySource108B5BFD045B42D7A031893FCF404252 =GetQueryExpressionDataSource("108B5BFD-045B-42D7-A031-893FCF404252");
Dictionary<short,object> result108B5BFD045B42D7A031893FCF404252=iSpace.ExecuteQuery(querySource108B5BFD045B42D7A031893FCF404252,@"EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'" + ISpace["F_ProjectDetailsId"].Value + @"',''," + ISpace["MF_ExpenseDetails_PageIndex"].Value + @",'" + ISpace["MF_ExpenseDetails_GridRows"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource108B5BFD045B42D7A031893FCF404252 =GetQueryExpressionDataSource(""108B5BFD-045B-42D7-A031-893FCF404252"");Dictionary<short,object> result108B5BFD045B42D7A031893FCF404252=iSpace.ExecuteQuery(querySource108B5BFD045B42D7A031893FCF404252,@""EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',"" + ISpace[""MF_ExpenseDetails_PageIndex""].Value + @"",'"" + ISpace[""MF_ExpenseDetails_GridRows""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result108B5BFD045B42D7A031893FCF404252!=null) && (result108B5BFD045B42D7A031893FCF404252.Count!=0))
{
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(0))
ISpace["MF_Budgetdetails_GridRows"].Value = result108B5BFD045B42D7A031893FCF404252[0];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(3))
ISpace["MF_Budgetdetails_TotalPages"].Value = result108B5BFD045B42D7A031893FCF404252[3];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(2))
ISpace["MF_Budgetdetails_PageIndex"].Value = result108B5BFD045B42D7A031893FCF404252[2];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(1))
ISpace["MF_Budgetdetails_RecordsRange"].Value = result108B5BFD045B42D7A031893FCF404252[1];
}
else{
ISpace["MF_Budgetdetails_GridRows"].Value = null;ISpace["MF_Budgetdetails_TotalPages"].Value = null;ISpace["MF_Budgetdetails_PageIndex"].Value = null;ISpace["MF_Budgetdetails_RecordsRange"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==1)");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==ISpace["MF_ExpenseDetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==ISpace[""MF_ExpenseDetails_TotalPages""].Value)");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="false";ISpace["MF_Budgetdetails_LastButton"].Enbl="false";ISpace["MF_Budgetdetails_NextButton"].Enbl="false";ISpace["MF_Budgetdetails_FirstButton"].Enbl="false";ISpace["MF_Budgetdetails_PageIndex"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""false"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="false";ISpace["MF_Budgetdetails_LastButton"].Enbl="true";ISpace["MF_Budgetdetails_NextButton"].Enbl="true";ISpace["MF_Budgetdetails_FirstButton"].Enbl="false";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
}
else
{
base.WriteDebugInfo(@"else");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==ISpace["MF_ExpenseDetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==ISpace[""MF_ExpenseDetails_TotalPages""].Value)");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="true";ISpace["MF_Budgetdetails_LastButton"].Enbl="false";ISpace["MF_Budgetdetails_NextButton"].Enbl="false";ISpace["MF_Budgetdetails_FirstButton"].Enbl="true";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="true";ISpace["MF_Budgetdetails_LastButton"].Enbl="true";ISpace["MF_Budgetdetails_NextButton"].Enbl="true";ISpace["MF_Budgetdetails_FirstButton"].Enbl="true";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySourceA30F7872734E4D34AFDDD8F49130791A =GetQueryExpressionDataSource("A30F7872-734E-4D34-AFDD-D8F49130791A");

DataTable resultA30F7872734E4D34AFDDD8F49130791A=iSpace.SetGridDataSource(querySourceA30F7872734E4D34AFDDD8F49130791A, _objectFactory.GetGridRPP("Budgetdetails"),@"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 1,'" + ISpace["F_BudgetHeadId"].Value + @"',''," + ISpace["MF_Budgetdetails_PageIndex"].Value + @",'" + ISpace["MF_Budgetdetails_GridRows"].Value + @"','" + ISpace["F_ProjectDetailsId"].Value + @"'");

iSpace.InsertGridBindDetails("Budgetdetails","11",querySourceA30F7872734E4D34AFDDD8F49130791A,"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 1,'" + ISpace["F_BudgetHeadId"].Value + @"',''," + ISpace["MF_Budgetdetails_PageIndex"].Value + @",'" + ISpace["MF_Budgetdetails_GridRows"].Value + @"','" + ISpace["F_ProjectDetailsId"].Value + @"'",_objectFactory.GetGridRPP("Budgetdetails"));

base.WriteDebugInfo(@"var querySourceA30F7872734E4D34AFDDD8F49130791A =GetQueryExpressionDataSource(""A30F7872-734E-4D34-AFDD-D8F49130791A"");DataTable resultA30F7872734E4D34AFDDD8F49130791A=iSpace.SetGridDataSource(querySourceA30F7872734E4D34AFDDD8F49130791A, _objectFactory.GetGridRPP(""Budgetdetails""),@""EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 1,'"" + ISpace[""F_BudgetHeadId""].Value + @""','',"" + ISpace[""MF_Budgetdetails_PageIndex""].Value + @"",'"" + ISpace[""MF_Budgetdetails_GridRows""].Value + @""','"" + ISpace[""F_ProjectDetailsId""].Value + @""'"");iSpace.InsertGridBindDetails(""Budgetdetails"",""11"",querySourceA30F7872734E4D34AFDDD8F49130791A,""EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 1,'"" + ISpace[""F_BudgetHeadId""].Value + @""','',"" + ISpace[""MF_Budgetdetails_PageIndex""].Value + @"",'"" + ISpace[""MF_Budgetdetails_GridRows""].Value + @""','"" + ISpace[""F_ProjectDetailsId""].Value + @""'"",_objectFactory.GetGridRPP(""Budgetdetails""));");
base.WriteDebugInfo(@"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 1,'#F_BudgetHeadId','',#MF_Budgetdetails_PageIndex,'#MF_Budgetdetails_GridRows'");


List<Triplet<string, short, short?>> result387A33C1D74545BDA9129E364AE2D589=acdataIspace585BA2B83E754DABB50B10D8320CE414.GetQueryExpressionBindings("387A33C1-D745-45BD-A912-9E364AE2D589");
iSpace.SetGridData(resultA30F7872734E4D34AFDDD8F49130791A,result387A33C1D74545BDA9129E364AE2D589,"Budgetdetails",ref ISpace);
iSpace.UpdateGridBindDetails("Budgetdetails",result387A33C1D74545BDA9129E364AE2D589);
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mf_expensedetails_nextbutton (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MF_ExpenseDetails_NextButton-OnClick");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value>0)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value>0)");
ISpace["MF_ExpenseDetails_PageIndex"].Value=ISpace["MF_ExpenseDetails_PageIndex"].Value+1;
base.WriteDebugInfo(@"ISpace[""MF_ExpenseDetails_PageIndex""].Value=ISpace[""MF_ExpenseDetails_PageIndex""].Value+1;");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_ExpenseDetails_PageIndex"].Value=1;
base.WriteDebugInfo(@"ISpace[""MF_ExpenseDetails_PageIndex""].Value=1;");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySourceFC2A5065A4C24EC0B017375CE0B0B812 =GetQueryExpressionDataSource("FC2A5065-A4C2-4EC0-B017-375CE0B0B812");

DataTable resultFC2A5065A4C24EC0B017375CE0B0B812=iSpace.SetGridDataSource(querySourceFC2A5065A4C24EC0B017375CE0B0B812, _objectFactory.GetGridRPP("ExpenseDetails"),@"EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 1,'" + ISpace["F_ProjectDetailsId"].Value + @"',''," + ISpace["MF_ExpenseDetails_PageIndex"].Value + @",'" + ISpace["MF_ExpenseDetails_GridRows"].Value + @"'");

iSpace.InsertGridBindDetails("ExpenseDetails","11",querySourceFC2A5065A4C24EC0B017375CE0B0B812,"EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 1,'" + ISpace["F_ProjectDetailsId"].Value + @"',''," + ISpace["MF_ExpenseDetails_PageIndex"].Value + @",'" + ISpace["MF_ExpenseDetails_GridRows"].Value + @"'",_objectFactory.GetGridRPP("ExpenseDetails"));

base.WriteDebugInfo(@"var querySourceFC2A5065A4C24EC0B017375CE0B0B812 =GetQueryExpressionDataSource(""FC2A5065-A4C2-4EC0-B017-375CE0B0B812"");DataTable resultFC2A5065A4C24EC0B017375CE0B0B812=iSpace.SetGridDataSource(querySourceFC2A5065A4C24EC0B017375CE0B0B812, _objectFactory.GetGridRPP(""ExpenseDetails""),@""EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 1,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',"" + ISpace[""MF_ExpenseDetails_PageIndex""].Value + @"",'"" + ISpace[""MF_ExpenseDetails_GridRows""].Value + @""'"");iSpace.InsertGridBindDetails(""ExpenseDetails"",""11"",querySourceFC2A5065A4C24EC0B017375CE0B0B812,""EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 1,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',"" + ISpace[""MF_ExpenseDetails_PageIndex""].Value + @"",'"" + ISpace[""MF_ExpenseDetails_GridRows""].Value + @""'"",_objectFactory.GetGridRPP(""ExpenseDetails""));");
base.WriteDebugInfo(@"EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 1,'#F_ExpenseId','',#MF_ExpenseDetails_PageIndex,'#MF_ExpenseDetails_GridRows'");


List<Triplet<string, short, short?>> resultF156A8611F4D43F2884E90DD3F9E66E3=acdataIspace585BA2B83E754DABB50B10D8320CE414.GetQueryExpressionBindings("F156A861-1F4D-43F2-884E-90DD3F9E66E3");
iSpace.SetGridData(resultFC2A5065A4C24EC0B017375CE0B0B812,resultF156A8611F4D43F2884E90DD3F9E66E3,"ExpenseDetails",ref ISpace);
iSpace.UpdateGridBindDetails("ExpenseDetails",resultF156A8611F4D43F2884E90DD3F9E66E3);
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'#F_ProjectDetailsId','',#MF_ExpenseDetails_PageIndex,'#MF_ExpenseDetails_GridRows'");

var querySource108B5BFD045B42D7A031893FCF404252 =GetQueryExpressionDataSource("108B5BFD-045B-42D7-A031-893FCF404252");
Dictionary<short,object> result108B5BFD045B42D7A031893FCF404252=iSpace.ExecuteQuery(querySource108B5BFD045B42D7A031893FCF404252,@"EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'" + ISpace["F_ProjectDetailsId"].Value + @"',''," + ISpace["MF_ExpenseDetails_PageIndex"].Value + @",'" + ISpace["MF_ExpenseDetails_GridRows"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource108B5BFD045B42D7A031893FCF404252 =GetQueryExpressionDataSource(""108B5BFD-045B-42D7-A031-893FCF404252"");Dictionary<short,object> result108B5BFD045B42D7A031893FCF404252=iSpace.ExecuteQuery(querySource108B5BFD045B42D7A031893FCF404252,@""EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',"" + ISpace[""MF_ExpenseDetails_PageIndex""].Value + @"",'"" + ISpace[""MF_ExpenseDetails_GridRows""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result108B5BFD045B42D7A031893FCF404252!=null) && (result108B5BFD045B42D7A031893FCF404252.Count!=0))
{
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(0))
ISpace["MF_Budgetdetails_GridRows"].Value = result108B5BFD045B42D7A031893FCF404252[0];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(3))
ISpace["MF_Budgetdetails_TotalPages"].Value = result108B5BFD045B42D7A031893FCF404252[3];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(2))
ISpace["MF_Budgetdetails_PageIndex"].Value = result108B5BFD045B42D7A031893FCF404252[2];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(1))
ISpace["MF_Budgetdetails_RecordsRange"].Value = result108B5BFD045B42D7A031893FCF404252[1];
}
else{
ISpace["MF_Budgetdetails_GridRows"].Value = null;ISpace["MF_Budgetdetails_TotalPages"].Value = null;ISpace["MF_Budgetdetails_PageIndex"].Value = null;ISpace["MF_Budgetdetails_RecordsRange"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==1)");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==ISpace["MF_ExpenseDetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==ISpace[""MF_ExpenseDetails_TotalPages""].Value)");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="false";ISpace["MF_Budgetdetails_LastButton"].Enbl="false";ISpace["MF_Budgetdetails_NextButton"].Enbl="false";ISpace["MF_Budgetdetails_FirstButton"].Enbl="false";ISpace["MF_Budgetdetails_PageIndex"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""false"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="false";ISpace["MF_Budgetdetails_LastButton"].Enbl="true";ISpace["MF_Budgetdetails_NextButton"].Enbl="true";ISpace["MF_Budgetdetails_FirstButton"].Enbl="false";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
}
else
{
base.WriteDebugInfo(@"else");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==ISpace["MF_ExpenseDetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==ISpace[""MF_ExpenseDetails_TotalPages""].Value)");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="true";ISpace["MF_Budgetdetails_LastButton"].Enbl="false";ISpace["MF_Budgetdetails_NextButton"].Enbl="false";ISpace["MF_Budgetdetails_FirstButton"].Enbl="true";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="true";ISpace["MF_Budgetdetails_LastButton"].Enbl="true";ISpace["MF_Budgetdetails_NextButton"].Enbl="true";ISpace["MF_Budgetdetails_FirstButton"].Enbl="true";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
}
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

var querySource94B9568E6AA646109AB971682A69C231 =GetQueryExpressionDataSource("94B9568E-6AA6-4610-9AB9-71682A69C231");

DataTable result94B9568E6AA646109AB971682A69C231=iSpace.SetGridDataSource(querySource94B9568E6AA646109AB971682A69C231, _objectFactory.GetGridRPP("ReceiptsView"),@"EXEC dbo.[Get_bd3abae8-b5a2-4b71-b3e2-e46732479592_FilterData] 1,'" + ISpace["F_ReceiptNo"].Value + @"',''," + ISpace["MF_ReceiptsView_PageIndex"].Value + @",'" + ISpace["MF_ReceiptsView_GridRows"].Value + @"','" + ISpace["F_ProjectDetailsID"].Value + @"'");

iSpace.InsertGridBindDetails("ReceiptsView","11",querySource94B9568E6AA646109AB971682A69C231,"EXEC dbo.[Get_bd3abae8-b5a2-4b71-b3e2-e46732479592_FilterData] 1,'" + ISpace["F_ReceiptNo"].Value + @"',''," + ISpace["MF_ReceiptsView_PageIndex"].Value + @",'" + ISpace["MF_ReceiptsView_GridRows"].Value + @"','" + ISpace["F_ProjectDetailsID"].Value + @"'",_objectFactory.GetGridRPP("ReceiptsView"));

base.WriteDebugInfo(@"var querySource94B9568E6AA646109AB971682A69C231 =GetQueryExpressionDataSource(""94B9568E-6AA6-4610-9AB9-71682A69C231"");DataTable result94B9568E6AA646109AB971682A69C231=iSpace.SetGridDataSource(querySource94B9568E6AA646109AB971682A69C231, _objectFactory.GetGridRPP(""ReceiptsView""),@""EXEC dbo.[Get_bd3abae8-b5a2-4b71-b3e2-e46732479592_FilterData] 1,'"" + ISpace[""F_ReceiptNo""].Value + @""','',"" + ISpace[""MF_ReceiptsView_PageIndex""].Value + @"",'"" + ISpace[""MF_ReceiptsView_GridRows""].Value + @""','"" + ISpace[""F_ProjectDetailsID""].Value + @""'"");iSpace.InsertGridBindDetails(""ReceiptsView"",""11"",querySource94B9568E6AA646109AB971682A69C231,""EXEC dbo.[Get_bd3abae8-b5a2-4b71-b3e2-e46732479592_FilterData] 1,'"" + ISpace[""F_ReceiptNo""].Value + @""','',"" + ISpace[""MF_ReceiptsView_PageIndex""].Value + @"",'"" + ISpace[""MF_ReceiptsView_GridRows""].Value + @""','"" + ISpace[""F_ProjectDetailsID""].Value + @""'"",_objectFactory.GetGridRPP(""ReceiptsView""));");
base.WriteDebugInfo(@"EXEC dbo.[Get_bd3abae8-b5a2-4b71-b3e2-e46732479592_FilterData] 1,'#F_ReceiptNo','',#MF_ReceiptsView_PageIndex,'#MF_ReceiptsView_GridRows'");


List<Triplet<string, short, short?>> result6C0E534F5B5649E8BDBDB1A399E4F9C5=acdataIspace585BA2B83E754DABB50B10D8320CE414.GetQueryExpressionBindings("6C0E534F-5B56-49E8-BDBD-B1A399E4F9C5");
iSpace.SetGridData(result94B9568E6AA646109AB971682A69C231,result6C0E534F5B5649E8BDBDB1A399E4F9C5,"ReceiptsView",ref ISpace);
iSpace.UpdateGridBindDetails("ReceiptsView",result6C0E534F5B5649E8BDBDB1A399E4F9C5);
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'#F_ProjectDetailsId','',#MF_ExpenseDetails_PageIndex,'#MF_ExpenseDetails_GridRows'");

var querySource108B5BFD045B42D7A031893FCF404252 =GetQueryExpressionDataSource("108B5BFD-045B-42D7-A031-893FCF404252");
Dictionary<short,object> result108B5BFD045B42D7A031893FCF404252=iSpace.ExecuteQuery(querySource108B5BFD045B42D7A031893FCF404252,@"EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'" + ISpace["F_ProjectDetailsId"].Value + @"',''," + ISpace["MF_ExpenseDetails_PageIndex"].Value + @",'" + ISpace["MF_ExpenseDetails_GridRows"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource108B5BFD045B42D7A031893FCF404252 =GetQueryExpressionDataSource(""108B5BFD-045B-42D7-A031-893FCF404252"");Dictionary<short,object> result108B5BFD045B42D7A031893FCF404252=iSpace.ExecuteQuery(querySource108B5BFD045B42D7A031893FCF404252,@""EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',"" + ISpace[""MF_ExpenseDetails_PageIndex""].Value + @"",'"" + ISpace[""MF_ExpenseDetails_GridRows""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result108B5BFD045B42D7A031893FCF404252!=null) && (result108B5BFD045B42D7A031893FCF404252.Count!=0))
{
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(0))
ISpace["MF_Budgetdetails_GridRows"].Value = result108B5BFD045B42D7A031893FCF404252[0];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(3))
ISpace["MF_Budgetdetails_TotalPages"].Value = result108B5BFD045B42D7A031893FCF404252[3];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(2))
ISpace["MF_Budgetdetails_PageIndex"].Value = result108B5BFD045B42D7A031893FCF404252[2];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(1))
ISpace["MF_Budgetdetails_RecordsRange"].Value = result108B5BFD045B42D7A031893FCF404252[1];
}
else{
ISpace["MF_Budgetdetails_GridRows"].Value = null;ISpace["MF_Budgetdetails_TotalPages"].Value = null;ISpace["MF_Budgetdetails_PageIndex"].Value = null;ISpace["MF_Budgetdetails_RecordsRange"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==1)");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==ISpace["MF_ExpenseDetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==ISpace[""MF_ExpenseDetails_TotalPages""].Value)");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="false";ISpace["MF_Budgetdetails_LastButton"].Enbl="false";ISpace["MF_Budgetdetails_NextButton"].Enbl="false";ISpace["MF_Budgetdetails_FirstButton"].Enbl="false";ISpace["MF_Budgetdetails_PageIndex"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""false"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="false";ISpace["MF_Budgetdetails_LastButton"].Enbl="true";ISpace["MF_Budgetdetails_NextButton"].Enbl="true";ISpace["MF_Budgetdetails_FirstButton"].Enbl="false";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
}
else
{
base.WriteDebugInfo(@"else");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==ISpace["MF_ExpenseDetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==ISpace[""MF_ExpenseDetails_TotalPages""].Value)");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="true";ISpace["MF_Budgetdetails_LastButton"].Enbl="false";ISpace["MF_Budgetdetails_NextButton"].Enbl="false";ISpace["MF_Budgetdetails_FirstButton"].Enbl="true";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="true";ISpace["MF_Budgetdetails_LastButton"].Enbl="true";ISpace["MF_Budgetdetails_NextButton"].Enbl="true";ISpace["MF_Budgetdetails_FirstButton"].Enbl="true";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
}
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

var querySource94B9568E6AA646109AB971682A69C231 =GetQueryExpressionDataSource("94B9568E-6AA6-4610-9AB9-71682A69C231");

DataTable result94B9568E6AA646109AB971682A69C231=iSpace.SetGridDataSource(querySource94B9568E6AA646109AB971682A69C231, _objectFactory.GetGridRPP("ReceiptsView"),@"EXEC dbo.[Get_bd3abae8-b5a2-4b71-b3e2-e46732479592_FilterData] 1,'" + ISpace["F_ReceiptNo"].Value + @"',''," + ISpace["MF_ReceiptsView_PageIndex"].Value + @",'" + ISpace["MF_ReceiptsView_GridRows"].Value + @"','" + ISpace["F_ProjectDetailsID"].Value + @"'");

iSpace.InsertGridBindDetails("ReceiptsView","11",querySource94B9568E6AA646109AB971682A69C231,"EXEC dbo.[Get_bd3abae8-b5a2-4b71-b3e2-e46732479592_FilterData] 1,'" + ISpace["F_ReceiptNo"].Value + @"',''," + ISpace["MF_ReceiptsView_PageIndex"].Value + @",'" + ISpace["MF_ReceiptsView_GridRows"].Value + @"','" + ISpace["F_ProjectDetailsID"].Value + @"'",_objectFactory.GetGridRPP("ReceiptsView"));

base.WriteDebugInfo(@"var querySource94B9568E6AA646109AB971682A69C231 =GetQueryExpressionDataSource(""94B9568E-6AA6-4610-9AB9-71682A69C231"");DataTable result94B9568E6AA646109AB971682A69C231=iSpace.SetGridDataSource(querySource94B9568E6AA646109AB971682A69C231, _objectFactory.GetGridRPP(""ReceiptsView""),@""EXEC dbo.[Get_bd3abae8-b5a2-4b71-b3e2-e46732479592_FilterData] 1,'"" + ISpace[""F_ReceiptNo""].Value + @""','',"" + ISpace[""MF_ReceiptsView_PageIndex""].Value + @"",'"" + ISpace[""MF_ReceiptsView_GridRows""].Value + @""','"" + ISpace[""F_ProjectDetailsID""].Value + @""'"");iSpace.InsertGridBindDetails(""ReceiptsView"",""11"",querySource94B9568E6AA646109AB971682A69C231,""EXEC dbo.[Get_bd3abae8-b5a2-4b71-b3e2-e46732479592_FilterData] 1,'"" + ISpace[""F_ReceiptNo""].Value + @""','',"" + ISpace[""MF_ReceiptsView_PageIndex""].Value + @"",'"" + ISpace[""MF_ReceiptsView_GridRows""].Value + @""','"" + ISpace[""F_ProjectDetailsID""].Value + @""'"",_objectFactory.GetGridRPP(""ReceiptsView""));");
base.WriteDebugInfo(@"EXEC dbo.[Get_bd3abae8-b5a2-4b71-b3e2-e46732479592_FilterData] 1,'#F_ReceiptNo','',#MF_ReceiptsView_PageIndex,'#MF_ReceiptsView_GridRows'");


List<Triplet<string, short, short?>> result6C0E534F5B5649E8BDBDB1A399E4F9C5=acdataIspace585BA2B83E754DABB50B10D8320CE414.GetQueryExpressionBindings("6C0E534F-5B56-49E8-BDBD-B1A399E4F9C5");
iSpace.SetGridData(result94B9568E6AA646109AB971682A69C231,result6C0E534F5B5649E8BDBDB1A399E4F9C5,"ReceiptsView",ref ISpace);
iSpace.UpdateGridBindDetails("ReceiptsView",result6C0E534F5B5649E8BDBDB1A399E4F9C5);
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'#F_ProjectDetailsId','',#MF_ExpenseDetails_PageIndex,'#MF_ExpenseDetails_GridRows'");

var querySource108B5BFD045B42D7A031893FCF404252 =GetQueryExpressionDataSource("108B5BFD-045B-42D7-A031-893FCF404252");
Dictionary<short,object> result108B5BFD045B42D7A031893FCF404252=iSpace.ExecuteQuery(querySource108B5BFD045B42D7A031893FCF404252,@"EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'" + ISpace["F_ProjectDetailsId"].Value + @"',''," + ISpace["MF_ExpenseDetails_PageIndex"].Value + @",'" + ISpace["MF_ExpenseDetails_GridRows"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource108B5BFD045B42D7A031893FCF404252 =GetQueryExpressionDataSource(""108B5BFD-045B-42D7-A031-893FCF404252"");Dictionary<short,object> result108B5BFD045B42D7A031893FCF404252=iSpace.ExecuteQuery(querySource108B5BFD045B42D7A031893FCF404252,@""EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',"" + ISpace[""MF_ExpenseDetails_PageIndex""].Value + @"",'"" + ISpace[""MF_ExpenseDetails_GridRows""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result108B5BFD045B42D7A031893FCF404252!=null) && (result108B5BFD045B42D7A031893FCF404252.Count!=0))
{
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(0))
ISpace["MF_Budgetdetails_GridRows"].Value = result108B5BFD045B42D7A031893FCF404252[0];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(3))
ISpace["MF_Budgetdetails_TotalPages"].Value = result108B5BFD045B42D7A031893FCF404252[3];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(2))
ISpace["MF_Budgetdetails_PageIndex"].Value = result108B5BFD045B42D7A031893FCF404252[2];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(1))
ISpace["MF_Budgetdetails_RecordsRange"].Value = result108B5BFD045B42D7A031893FCF404252[1];
}
else{
ISpace["MF_Budgetdetails_GridRows"].Value = null;ISpace["MF_Budgetdetails_TotalPages"].Value = null;ISpace["MF_Budgetdetails_PageIndex"].Value = null;ISpace["MF_Budgetdetails_RecordsRange"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==1)");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==ISpace["MF_ExpenseDetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==ISpace[""MF_ExpenseDetails_TotalPages""].Value)");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="false";ISpace["MF_Budgetdetails_LastButton"].Enbl="false";ISpace["MF_Budgetdetails_NextButton"].Enbl="false";ISpace["MF_Budgetdetails_FirstButton"].Enbl="false";ISpace["MF_Budgetdetails_PageIndex"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""false"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="false";ISpace["MF_Budgetdetails_LastButton"].Enbl="true";ISpace["MF_Budgetdetails_NextButton"].Enbl="true";ISpace["MF_Budgetdetails_FirstButton"].Enbl="false";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
}
else
{
base.WriteDebugInfo(@"else");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==ISpace["MF_ExpenseDetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==ISpace[""MF_ExpenseDetails_TotalPages""].Value)");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="true";ISpace["MF_Budgetdetails_LastButton"].Enbl="false";ISpace["MF_Budgetdetails_NextButton"].Enbl="false";ISpace["MF_Budgetdetails_FirstButton"].Enbl="true";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="true";ISpace["MF_Budgetdetails_LastButton"].Enbl="true";ISpace["MF_Budgetdetails_NextButton"].Enbl="true";ISpace["MF_Budgetdetails_FirstButton"].Enbl="true";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
}
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

var querySourceCA82683BCA014525A93F68B518D9FCFA =GetQueryExpressionDataSource("CA82683B-CA01-4525-A93F-68B518D9FCFA");

DataTable resultCA82683BCA014525A93F68B518D9FCFA=iSpace.SetGridDataSource(querySourceCA82683BCA014525A93F68B518D9FCFA, _objectFactory.GetGridRPP("ProjectCommitments"),@"EXEC dbo.[Get_e046fb44-e1f1-4f2a-a07e-231e72f92166_FilterData] 1,'" + ISpace["F_ProjectDetailsId"].Value + @"',''," + ISpace["MF_ProjectCommitments_PageIndex"].Value + @",'" + ISpace["MF_ProjectCommitments_GridRows"].Value + @"'");

iSpace.InsertGridBindDetails("ProjectCommitments","11",querySourceCA82683BCA014525A93F68B518D9FCFA,"EXEC dbo.[Get_e046fb44-e1f1-4f2a-a07e-231e72f92166_FilterData] 1,'" + ISpace["F_ProjectDetailsId"].Value + @"',''," + ISpace["MF_ProjectCommitments_PageIndex"].Value + @",'" + ISpace["MF_ProjectCommitments_GridRows"].Value + @"'",_objectFactory.GetGridRPP("ProjectCommitments"));

base.WriteDebugInfo(@"var querySourceCA82683BCA014525A93F68B518D9FCFA =GetQueryExpressionDataSource(""CA82683B-CA01-4525-A93F-68B518D9FCFA"");DataTable resultCA82683BCA014525A93F68B518D9FCFA=iSpace.SetGridDataSource(querySourceCA82683BCA014525A93F68B518D9FCFA, _objectFactory.GetGridRPP(""ProjectCommitments""),@""EXEC dbo.[Get_e046fb44-e1f1-4f2a-a07e-231e72f92166_FilterData] 1,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',"" + ISpace[""MF_ProjectCommitments_PageIndex""].Value + @"",'"" + ISpace[""MF_ProjectCommitments_GridRows""].Value + @""'"");iSpace.InsertGridBindDetails(""ProjectCommitments"",""11"",querySourceCA82683BCA014525A93F68B518D9FCFA,""EXEC dbo.[Get_e046fb44-e1f1-4f2a-a07e-231e72f92166_FilterData] 1,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',"" + ISpace[""MF_ProjectCommitments_PageIndex""].Value + @"",'"" + ISpace[""MF_ProjectCommitments_GridRows""].Value + @""'"",_objectFactory.GetGridRPP(""ProjectCommitments""));");
base.WriteDebugInfo(@"EXEC dbo.[Get_e046fb44-e1f1-4f2a-a07e-231e72f92166_FilterData] 1,'#F_ProjectDetailsId','',#MF_ProjectCommitments_PageIndex,'#MF_ProjectCommitments_GridRows'");


List<Triplet<string, short, short?>> resultF24D61150F9946679299168E58B151A1=acdataIspace585BA2B83E754DABB50B10D8320CE414.GetQueryExpressionBindings("F24D6115-0F99-4667-9299-168E58B151A1");
iSpace.SetGridData(resultCA82683BCA014525A93F68B518D9FCFA,resultF24D61150F9946679299168E58B151A1,"ProjectCommitments",ref ISpace);
iSpace.UpdateGridBindDetails("ProjectCommitments",resultF24D61150F9946679299168E58B151A1);
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'#F_ProjectDetailsId','',#MF_ExpenseDetails_PageIndex,'#MF_ExpenseDetails_GridRows'");

var querySource108B5BFD045B42D7A031893FCF404252 =GetQueryExpressionDataSource("108B5BFD-045B-42D7-A031-893FCF404252");
Dictionary<short,object> result108B5BFD045B42D7A031893FCF404252=iSpace.ExecuteQuery(querySource108B5BFD045B42D7A031893FCF404252,@"EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'" + ISpace["F_ProjectDetailsId"].Value + @"',''," + ISpace["MF_ExpenseDetails_PageIndex"].Value + @",'" + ISpace["MF_ExpenseDetails_GridRows"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource108B5BFD045B42D7A031893FCF404252 =GetQueryExpressionDataSource(""108B5BFD-045B-42D7-A031-893FCF404252"");Dictionary<short,object> result108B5BFD045B42D7A031893FCF404252=iSpace.ExecuteQuery(querySource108B5BFD045B42D7A031893FCF404252,@""EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',"" + ISpace[""MF_ExpenseDetails_PageIndex""].Value + @"",'"" + ISpace[""MF_ExpenseDetails_GridRows""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result108B5BFD045B42D7A031893FCF404252!=null) && (result108B5BFD045B42D7A031893FCF404252.Count!=0))
{
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(0))
ISpace["MF_Budgetdetails_GridRows"].Value = result108B5BFD045B42D7A031893FCF404252[0];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(3))
ISpace["MF_Budgetdetails_TotalPages"].Value = result108B5BFD045B42D7A031893FCF404252[3];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(2))
ISpace["MF_Budgetdetails_PageIndex"].Value = result108B5BFD045B42D7A031893FCF404252[2];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(1))
ISpace["MF_Budgetdetails_RecordsRange"].Value = result108B5BFD045B42D7A031893FCF404252[1];
}
else{
ISpace["MF_Budgetdetails_GridRows"].Value = null;ISpace["MF_Budgetdetails_TotalPages"].Value = null;ISpace["MF_Budgetdetails_PageIndex"].Value = null;ISpace["MF_Budgetdetails_RecordsRange"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==1)");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==ISpace["MF_ExpenseDetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==ISpace[""MF_ExpenseDetails_TotalPages""].Value)");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="false";ISpace["MF_Budgetdetails_LastButton"].Enbl="false";ISpace["MF_Budgetdetails_NextButton"].Enbl="false";ISpace["MF_Budgetdetails_FirstButton"].Enbl="false";ISpace["MF_Budgetdetails_PageIndex"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""false"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="false";ISpace["MF_Budgetdetails_LastButton"].Enbl="true";ISpace["MF_Budgetdetails_NextButton"].Enbl="true";ISpace["MF_Budgetdetails_FirstButton"].Enbl="false";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
}
else
{
base.WriteDebugInfo(@"else");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==ISpace["MF_ExpenseDetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==ISpace[""MF_ExpenseDetails_TotalPages""].Value)");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="true";ISpace["MF_Budgetdetails_LastButton"].Enbl="false";ISpace["MF_Budgetdetails_NextButton"].Enbl="false";ISpace["MF_Budgetdetails_FirstButton"].Enbl="true";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="true";ISpace["MF_Budgetdetails_LastButton"].Enbl="true";ISpace["MF_Budgetdetails_NextButton"].Enbl="true";ISpace["MF_Budgetdetails_FirstButton"].Enbl="true";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
}
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
ISpace["UI_GridPanel"].Visible="false";ISpace["UI_GridPanel"].Enbl="true";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""F7DA2CD7-1723-45E3-94F5-6380EB2F0989"")
{
ISpace[""UI_GridPanel""].Visible=""false"";ISpace[""UI_GridPanel""].Enbl=""true"";
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
ISpace["UI_GridPanelthree"].Visible="false";ISpace["UI_GridPanelthree"].Enbl="true";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""F7DA2CD7-1723-45E3-94F5-6380EB2F0989"")
{
ISpace[""UI_GridPanelthree""].Visible=""false"";ISpace[""UI_GridPanelthree""].Enbl=""true"";
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
ISpace["UI_GridPanelOne"].Visible="false";ISpace["UI_GridPanelOne"].Enbl="true";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""F7DA2CD7-1723-45E3-94F5-6380EB2F0989"")
{
ISpace[""UI_GridPanelOne""].Visible=""false"";ISpace[""UI_GridPanelOne""].Enbl=""true"";
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
ISpace["UI_SearchPanel"].Visible="false";ISpace["UI_SearchPanel"].Enbl="true";
}if(ISpace["FormVersionId"].Value=="F7DA2CD7-1723-45E3-94F5-6380EB2F0989")
{
ISpace["UI_GridPanelTwo"].Visible="false";ISpace["UI_GridPanelTwo"].Enbl="true";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""F7DA2CD7-1723-45E3-94F5-6380EB2F0989"")
{
ISpace[""UI_SearchPanel""].Visible=""false"";ISpace[""UI_SearchPanel""].Enbl=""true"";
}if(ISpace[""FormVersionId""].Value==""F7DA2CD7-1723-45E3-94F5-6380EB2F0989"")
{
ISpace[""UI_GridPanelTwo""].Visible=""false"";ISpace[""UI_GridPanelTwo""].Enbl=""true"";
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
base.WriteDebugInfo(@"SELECT VW_ExpenseDetails_1.[ExpenseID], VW_ExpenseDetails_1.[BudgetHead], VW_ExpenseDetails_1.[ProjectDetailsID], VW_ExpenseDetails_1.[PackageProcessMapID], VW_ExpenseDetails_1.[ExpenseDate], VW_ExpenseDetails_1.[AmountSpent], VW_ExpenseDetails_1.[ExpenseDescription] FROM  Projects..VW_ExpenseDetails_1  WHERE VW_ExpenseDetails_1.ExpenseID= '#MGG_V1_ExpenseID'");

var querySourceEA0673C54AB74D8693D5A45EB0B4CF09 =GetQueryExpressionDataSource("EA0673C5-4AB7-4D86-93D5-A45EB0B4CF09");
Dictionary<short,object> resultEA0673C54AB74D8693D5A45EB0B4CF09=iSpace.ExecuteQuery(querySourceEA0673C54AB74D8693D5A45EB0B4CF09,@"SELECT VW_ExpenseDetails_1.[ExpenseID], VW_ExpenseDetails_1.[BudgetHead], VW_ExpenseDetails_1.[ProjectDetailsID], VW_ExpenseDetails_1.[PackageProcessMapID], VW_ExpenseDetails_1.[ExpenseDate], VW_ExpenseDetails_1.[AmountSpent], VW_ExpenseDetails_1.[ExpenseDescription] FROM  Projects..VW_ExpenseDetails_1  WHERE VW_ExpenseDetails_1.ExpenseID= '" + ISpace["MGG_V1_ExpenseID"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceEA0673C54AB74D8693D5A45EB0B4CF09 =GetQueryExpressionDataSource(""EA0673C5-4AB7-4D86-93D5-A45EB0B4CF09"");Dictionary<short,object> resultEA0673C54AB74D8693D5A45EB0B4CF09=iSpace.ExecuteQuery(querySourceEA0673C54AB74D8693D5A45EB0B4CF09,@""SELECT VW_ExpenseDetails_1.[ExpenseID], VW_ExpenseDetails_1.[BudgetHead], VW_ExpenseDetails_1.[ProjectDetailsID], VW_ExpenseDetails_1.[PackageProcessMapID], VW_ExpenseDetails_1.[ExpenseDate], VW_ExpenseDetails_1.[AmountSpent], VW_ExpenseDetails_1.[ExpenseDescription] FROM  Projects..VW_ExpenseDetails_1  WHERE VW_ExpenseDetails_1.ExpenseID= '"" + ISpace[""MGG_V1_ExpenseID""].Value + @""'"",false);");
base.WriteDebugInfo(@"SELECT VW_ExpenseDetails_1.[ExpenseID], VW_ExpenseDetails_1.[BudgetHead], VW_ExpenseDetails_1.[ProjectDetailsID], VW_ExpenseDetails_1.[PackageProcessMapID], VW_ExpenseDetails_1.[ExpenseDate], VW_ExpenseDetails_1.[AmountSpent], VW_ExpenseDetails_1.[ExpenseDescription] FROM  Projects..VW_ExpenseDetails_1  WHERE VW_ExpenseDetails_1.ExpenseID= '#MGG_V1_ExpenseID'");

if((resultEA0673C54AB74D8693D5A45EB0B4CF09!=null) && (resultEA0673C54AB74D8693D5A45EB0B4CF09.Count!=0))
{
if(resultEA0673C54AB74D8693D5A45EB0B4CF09.ContainsKey(4))
ISpace["MF_V1_ExpenseDate"].Value = resultEA0673C54AB74D8693D5A45EB0B4CF09[4];
if(resultEA0673C54AB74D8693D5A45EB0B4CF09.ContainsKey(5))
ISpace["MF_V1_AmountSpent"].Value = resultEA0673C54AB74D8693D5A45EB0B4CF09[5];
if(resultEA0673C54AB74D8693D5A45EB0B4CF09.ContainsKey(0))
ISpace["MF_V1_ExpenseID"].Value = resultEA0673C54AB74D8693D5A45EB0B4CF09[0];
if(resultEA0673C54AB74D8693D5A45EB0B4CF09.ContainsKey(1))
ISpace["MF_V1_BudgetHead"].Value = resultEA0673C54AB74D8693D5A45EB0B4CF09[1];
if(resultEA0673C54AB74D8693D5A45EB0B4CF09.ContainsKey(2))
ISpace["MF_V1_ProjectDetailsID"].Value = resultEA0673C54AB74D8693D5A45EB0B4CF09[2];
if(resultEA0673C54AB74D8693D5A45EB0B4CF09.ContainsKey(3))
ISpace["MF_V1_PackageProcessMapID"].Value = resultEA0673C54AB74D8693D5A45EB0B4CF09[3];
if(resultEA0673C54AB74D8693D5A45EB0B4CF09.ContainsKey(6))
ISpace["MF_V1_ExpenseDescription"].Value = resultEA0673C54AB74D8693D5A45EB0B4CF09[6];
}
else{
ISpace["MF_V1_ExpenseDate"].Value = null;ISpace["MF_V1_AmountSpent"].Value = null;ISpace["MF_V1_ExpenseID"].Value = null;ISpace["MF_V1_BudgetHead"].Value = null;ISpace["MF_V1_ProjectDetailsID"].Value = null;ISpace["MF_V1_PackageProcessMapID"].Value = null;ISpace["MF_V1_ExpenseDescription"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"SELECT VW_Commitments_1.[ExpenseID], VW_Commitments_1.[BudgetHead], VW_Commitments_1.[ProjectDetailsID], VW_Commitments_1.[PackageProcessMapID], VW_Commitments_1.[ExpenseDate], VW_Commitments_1.[AmountSpent], VW_Commitments_1.[ExpenseDescription] FROM  Projects..VW_Commitments_1  WHERE VW_Commitments_1.ExpenseID= '#MGG_V1_ExpenseID'");

var querySource53C694623F16443AA7330EB098A777E7 =GetQueryExpressionDataSource("53C69462-3F16-443A-A733-0EB098A777E7");
Dictionary<short,object> result53C694623F16443AA7330EB098A777E7=iSpace.ExecuteQuery(querySource53C694623F16443AA7330EB098A777E7,@"SELECT VW_Commitments_1.[ExpenseID], VW_Commitments_1.[BudgetHead], VW_Commitments_1.[ProjectDetailsID], VW_Commitments_1.[PackageProcessMapID], VW_Commitments_1.[ExpenseDate], VW_Commitments_1.[AmountSpent], VW_Commitments_1.[ExpenseDescription] FROM  Projects..VW_Commitments_1  WHERE VW_Commitments_1.ExpenseID= '" + ISpace["MGG_V1_ExpenseID"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource53C694623F16443AA7330EB098A777E7 =GetQueryExpressionDataSource(""53C69462-3F16-443A-A733-0EB098A777E7"");Dictionary<short,object> result53C694623F16443AA7330EB098A777E7=iSpace.ExecuteQuery(querySource53C694623F16443AA7330EB098A777E7,@""SELECT VW_Commitments_1.[ExpenseID], VW_Commitments_1.[BudgetHead], VW_Commitments_1.[ProjectDetailsID], VW_Commitments_1.[PackageProcessMapID], VW_Commitments_1.[ExpenseDate], VW_Commitments_1.[AmountSpent], VW_Commitments_1.[ExpenseDescription] FROM  Projects..VW_Commitments_1  WHERE VW_Commitments_1.ExpenseID= '"" + ISpace[""MGG_V1_ExpenseID""].Value + @""'"",false);");
base.WriteDebugInfo(@"SELECT VW_Commitments_1.[ExpenseID], VW_Commitments_1.[BudgetHead], VW_Commitments_1.[ProjectDetailsID], VW_Commitments_1.[PackageProcessMapID], VW_Commitments_1.[ExpenseDate], VW_Commitments_1.[AmountSpent], VW_Commitments_1.[ExpenseDescription] FROM  Projects..VW_Commitments_1  WHERE VW_Commitments_1.ExpenseID= '#MGG_V1_ExpenseID'");

if((result53C694623F16443AA7330EB098A777E7!=null) && (result53C694623F16443AA7330EB098A777E7.Count!=0))
{
if(result53C694623F16443AA7330EB098A777E7.ContainsKey(4))
ISpace["MF_V1_ExpenseDate"].Value = result53C694623F16443AA7330EB098A777E7[4];
if(result53C694623F16443AA7330EB098A777E7.ContainsKey(5))
ISpace["MF_V1_AmountSpent"].Value = result53C694623F16443AA7330EB098A777E7[5];
if(result53C694623F16443AA7330EB098A777E7.ContainsKey(0))
ISpace["MF_V1_ExpenseID"].Value = result53C694623F16443AA7330EB098A777E7[0];
if(result53C694623F16443AA7330EB098A777E7.ContainsKey(1))
ISpace["MF_V1_BudgetHead"].Value = result53C694623F16443AA7330EB098A777E7[1];
if(result53C694623F16443AA7330EB098A777E7.ContainsKey(2))
ISpace["MF_V1_ProjectDetailsID"].Value = result53C694623F16443AA7330EB098A777E7[2];
if(result53C694623F16443AA7330EB098A777E7.ContainsKey(3))
ISpace["MF_V1_PackageProcessMapID"].Value = result53C694623F16443AA7330EB098A777E7[3];
if(result53C694623F16443AA7330EB098A777E7.ContainsKey(6))
ISpace["MF_V1_ExpenseDescription"].Value = result53C694623F16443AA7330EB098A777E7[6];
}
else{
ISpace["MF_V1_ExpenseDate"].Value = null;ISpace["MF_V1_AmountSpent"].Value = null;ISpace["MF_V1_ExpenseID"].Value = null;ISpace["MF_V1_BudgetHead"].Value = null;ISpace["MF_V1_ProjectDetailsID"].Value = null;ISpace["MF_V1_PackageProcessMapID"].Value = null;ISpace["MF_V1_ExpenseDescription"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"SELECT ProjectReceipts.[ReceiptsId], ProjectReceipts.[ProjectDetailsId], ProjectReceipts.[ReceiptAmount], ProjectReceipts.[ReceiptDate], ProjectReceipts.[TransferType], ProjectReceipts.[TransferReferenceNumber], ProjectReceipts.[TransferReferenceDate], ProjectReceipts.[TransferReferenceBankId], ProjectReceipts.[TransferReferenceBranch], ProjectReceipts.[ReceiptNo] FROM  Projects..ProjectReceipts  WHERE ProjectReceipts.ReceiptsId= '#MGG_P1_ReceiptsId'");

var querySource7A5B1068C02041918012E4CB48BFAB15 =GetQueryExpressionDataSource("7A5B1068-C020-4191-8012-E4CB48BFAB15");
Dictionary<short,object> result7A5B1068C02041918012E4CB48BFAB15=iSpace.ExecuteQuery(querySource7A5B1068C02041918012E4CB48BFAB15,@"SELECT ProjectReceipts.[ReceiptsId], ProjectReceipts.[ProjectDetailsId], ProjectReceipts.[ReceiptAmount], ProjectReceipts.[ReceiptDate], ProjectReceipts.[TransferType], ProjectReceipts.[TransferReferenceNumber], ProjectReceipts.[TransferReferenceDate], ProjectReceipts.[TransferReferenceBankId], ProjectReceipts.[TransferReferenceBranch], ProjectReceipts.[ReceiptNo] FROM  Projects..ProjectReceipts  WHERE ProjectReceipts.ReceiptsId= '" + ISpace["MGG_P1_ReceiptsId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource7A5B1068C02041918012E4CB48BFAB15 =GetQueryExpressionDataSource(""7A5B1068-C020-4191-8012-E4CB48BFAB15"");Dictionary<short,object> result7A5B1068C02041918012E4CB48BFAB15=iSpace.ExecuteQuery(querySource7A5B1068C02041918012E4CB48BFAB15,@""SELECT ProjectReceipts.[ReceiptsId], ProjectReceipts.[ProjectDetailsId], ProjectReceipts.[ReceiptAmount], ProjectReceipts.[ReceiptDate], ProjectReceipts.[TransferType], ProjectReceipts.[TransferReferenceNumber], ProjectReceipts.[TransferReferenceDate], ProjectReceipts.[TransferReferenceBankId], ProjectReceipts.[TransferReferenceBranch], ProjectReceipts.[ReceiptNo] FROM  Projects..ProjectReceipts  WHERE ProjectReceipts.ReceiptsId= '"" + ISpace[""MGG_P1_ReceiptsId""].Value + @""'"",false);");
base.WriteDebugInfo(@"SELECT ProjectReceipts.[ReceiptsId], ProjectReceipts.[ProjectDetailsId], ProjectReceipts.[ReceiptAmount], ProjectReceipts.[ReceiptDate], ProjectReceipts.[TransferType], ProjectReceipts.[TransferReferenceNumber], ProjectReceipts.[TransferReferenceDate], ProjectReceipts.[TransferReferenceBankId], ProjectReceipts.[TransferReferenceBranch], ProjectReceipts.[ReceiptNo] FROM  Projects..ProjectReceipts  WHERE ProjectReceipts.ReceiptsId= '#MGG_P1_ReceiptsId'");

if((result7A5B1068C02041918012E4CB48BFAB15!=null) && (result7A5B1068C02041918012E4CB48BFAB15.Count!=0))
{
if(result7A5B1068C02041918012E4CB48BFAB15.ContainsKey(6))
ISpace["MF_P1_TransferReferenceDate"].Value = result7A5B1068C02041918012E4CB48BFAB15[6];
if(result7A5B1068C02041918012E4CB48BFAB15.ContainsKey(3))
ISpace["MF_P1_ReceiptDate"].Value = result7A5B1068C02041918012E4CB48BFAB15[3];
if(result7A5B1068C02041918012E4CB48BFAB15.ContainsKey(2))
ISpace["MF_P1_ReceiptAmount"].Value = result7A5B1068C02041918012E4CB48BFAB15[2];
if(result7A5B1068C02041918012E4CB48BFAB15.ContainsKey(4))
ISpace["MF_P1_TransferType"].Value = result7A5B1068C02041918012E4CB48BFAB15[4];
if(result7A5B1068C02041918012E4CB48BFAB15.ContainsKey(5))
ISpace["MF_P1_TransferReferenceNumber"].Value = result7A5B1068C02041918012E4CB48BFAB15[5];
if(result7A5B1068C02041918012E4CB48BFAB15.ContainsKey(7))
ISpace["MF_P1_TransferReferenceBankId"].Value = result7A5B1068C02041918012E4CB48BFAB15[7];
if(result7A5B1068C02041918012E4CB48BFAB15.ContainsKey(1))
ISpace["MF_P1_ProjectDetailsId"].Value = result7A5B1068C02041918012E4CB48BFAB15[1];
if(result7A5B1068C02041918012E4CB48BFAB15.ContainsKey(9))
ISpace["MF_P1_ReceiptNo"].Value = result7A5B1068C02041918012E4CB48BFAB15[9];
if(result7A5B1068C02041918012E4CB48BFAB15.ContainsKey(8))
ISpace["MF_P1_TransferReferenceBranch"].Value = result7A5B1068C02041918012E4CB48BFAB15[8];
if(result7A5B1068C02041918012E4CB48BFAB15.ContainsKey(0))
ISpace["MF_P1_ReceiptsId"].Value = result7A5B1068C02041918012E4CB48BFAB15[0];
}
else{
ISpace["MF_P1_TransferReferenceDate"].Value = null;ISpace["MF_P1_ReceiptDate"].Value = null;ISpace["MF_P1_ReceiptAmount"].Value = null;ISpace["MF_P1_TransferType"].Value = null;ISpace["MF_P1_TransferReferenceNumber"].Value = null;ISpace["MF_P1_TransferReferenceBankId"].Value = null;ISpace["MF_P1_ProjectDetailsId"].Value = null;ISpace["MF_P1_ReceiptNo"].Value = null;ISpace["MF_P1_TransferReferenceBranch"].Value = null;ISpace["MF_P1_ReceiptsId"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"SELECT VW_BudgetDetails_1.[BudgetHeadID], VW_BudgetDetails_1.[ProjectDetailsID], VW_BudgetDetails_1.[BudgetHead], VW_BudgetDetails_1.[SanctionedAmount], VW_BudgetDetails_1.[ReceivedAmount], VW_BudgetDetails_1.[YettoReceive], VW_BudgetDetails_1.[Spent], VW_BudgetDetails_1.[Committment], VW_BudgetDetails_1.[Balance] FROM  Projects..VW_BudgetDetails_1  WHERE VW_BudgetDetails_1.BudgetHeadID= '#MGG_V1_BudgetHeadID'");

var querySource18598C9AA3AF420F98F16A86A67AA8C2 =GetQueryExpressionDataSource("18598C9A-A3AF-420F-98F1-6A86A67AA8C2");
Dictionary<short,object> result18598C9AA3AF420F98F16A86A67AA8C2=iSpace.ExecuteQuery(querySource18598C9AA3AF420F98F16A86A67AA8C2,@"SELECT VW_BudgetDetails_1.[BudgetHeadID], VW_BudgetDetails_1.[ProjectDetailsID], VW_BudgetDetails_1.[BudgetHead], VW_BudgetDetails_1.[SanctionedAmount], VW_BudgetDetails_1.[ReceivedAmount], VW_BudgetDetails_1.[YettoReceive], VW_BudgetDetails_1.[Spent], VW_BudgetDetails_1.[Committment], VW_BudgetDetails_1.[Balance] FROM  Projects..VW_BudgetDetails_1  WHERE VW_BudgetDetails_1.BudgetHeadID= '" + ISpace["MGG_V1_BudgetHeadID"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource18598C9AA3AF420F98F16A86A67AA8C2 =GetQueryExpressionDataSource(""18598C9A-A3AF-420F-98F1-6A86A67AA8C2"");Dictionary<short,object> result18598C9AA3AF420F98F16A86A67AA8C2=iSpace.ExecuteQuery(querySource18598C9AA3AF420F98F16A86A67AA8C2,@""SELECT VW_BudgetDetails_1.[BudgetHeadID], VW_BudgetDetails_1.[ProjectDetailsID], VW_BudgetDetails_1.[BudgetHead], VW_BudgetDetails_1.[SanctionedAmount], VW_BudgetDetails_1.[ReceivedAmount], VW_BudgetDetails_1.[YettoReceive], VW_BudgetDetails_1.[Spent], VW_BudgetDetails_1.[Committment], VW_BudgetDetails_1.[Balance] FROM  Projects..VW_BudgetDetails_1  WHERE VW_BudgetDetails_1.BudgetHeadID= '"" + ISpace[""MGG_V1_BudgetHeadID""].Value + @""'"",false);");
base.WriteDebugInfo(@"SELECT VW_BudgetDetails_1.[BudgetHeadID], VW_BudgetDetails_1.[ProjectDetailsID], VW_BudgetDetails_1.[BudgetHead], VW_BudgetDetails_1.[SanctionedAmount], VW_BudgetDetails_1.[ReceivedAmount], VW_BudgetDetails_1.[YettoReceive], VW_BudgetDetails_1.[Spent], VW_BudgetDetails_1.[Committment], VW_BudgetDetails_1.[Balance] FROM  Projects..VW_BudgetDetails_1  WHERE VW_BudgetDetails_1.BudgetHeadID= '#MGG_V1_BudgetHeadID'");

if((result18598C9AA3AF420F98F16A86A67AA8C2!=null) && (result18598C9AA3AF420F98F16A86A67AA8C2.Count!=0))
{
if(result18598C9AA3AF420F98F16A86A67AA8C2.ContainsKey(5))
ISpace["MF_V1_YettoReceive"].Value = result18598C9AA3AF420F98F16A86A67AA8C2[5];
if(result18598C9AA3AF420F98F16A86A67AA8C2.ContainsKey(8))
ISpace["MF_V1_Balance"].Value = result18598C9AA3AF420F98F16A86A67AA8C2[8];
if(result18598C9AA3AF420F98F16A86A67AA8C2.ContainsKey(3))
ISpace["MF_V1_SanctionedAmount"].Value = result18598C9AA3AF420F98F16A86A67AA8C2[3];
if(result18598C9AA3AF420F98F16A86A67AA8C2.ContainsKey(6))
ISpace["MF_V1_Spent"].Value = result18598C9AA3AF420F98F16A86A67AA8C2[6];
if(result18598C9AA3AF420F98F16A86A67AA8C2.ContainsKey(4))
ISpace["MF_V1_ReceivedAmount"].Value = result18598C9AA3AF420F98F16A86A67AA8C2[4];
if(result18598C9AA3AF420F98F16A86A67AA8C2.ContainsKey(7))
ISpace["MF_V1_Committment"].Value = result18598C9AA3AF420F98F16A86A67AA8C2[7];
if(result18598C9AA3AF420F98F16A86A67AA8C2.ContainsKey(0))
ISpace["MF_V1_BudgetHeadID"].Value = result18598C9AA3AF420F98F16A86A67AA8C2[0];
if(result18598C9AA3AF420F98F16A86A67AA8C2.ContainsKey(1))
ISpace["MF_V1_ProjectDetailsID"].Value = result18598C9AA3AF420F98F16A86A67AA8C2[1];
if(result18598C9AA3AF420F98F16A86A67AA8C2.ContainsKey(2))
ISpace["MF_V1_BudgetHead"].Value = result18598C9AA3AF420F98F16A86A67AA8C2[2];
}
else{
ISpace["MF_V1_YettoReceive"].Value = null;ISpace["MF_V1_Balance"].Value = null;ISpace["MF_V1_SanctionedAmount"].Value = null;ISpace["MF_V1_Spent"].Value = null;ISpace["MF_V1_ReceivedAmount"].Value = null;ISpace["MF_V1_Committment"].Value = null;ISpace["MF_V1_BudgetHeadID"].Value = null;ISpace["MF_V1_ProjectDetailsID"].Value = null;ISpace["MF_V1_BudgetHead"].Value = null;
}
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
ISpace["UI_GridPanelthree"].Visible="true";ISpace["UI_GridPanelthree"].Enbl="true";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""F7DA2CD7-1723-45E3-94F5-6380EB2F0989"")
{
ISpace[""UI_GridPanelthree""].Visible=""true"";ISpace[""UI_GridPanelthree""].Enbl=""true"";
}");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["FormVersionId"].Value=="F7DA2CD7-1723-45E3-94F5-6380EB2F0989")
{
ISpace["UI_SearchPanel"].Visible="true";ISpace["UI_SearchPanel"].Enbl="true";
}if(ISpace["FormVersionId"].Value=="F7DA2CD7-1723-45E3-94F5-6380EB2F0989")
{
ISpace["UI_GridPanelTwo"].Visible="true";ISpace["UI_GridPanelTwo"].Enbl="true";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""F7DA2CD7-1723-45E3-94F5-6380EB2F0989"")
{
ISpace[""UI_SearchPanel""].Visible=""true"";ISpace[""UI_SearchPanel""].Enbl=""true"";
}if(ISpace[""FormVersionId""].Value==""F7DA2CD7-1723-45E3-94F5-6380EB2F0989"")
{
ISpace[""UI_GridPanelTwo""].Visible=""true"";ISpace[""UI_GridPanelTwo""].Enbl=""true"";
}");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["FormVersionId"].Value=="F7DA2CD7-1723-45E3-94F5-6380EB2F0989")
{
ISpace["UI_GridPanelOne"].Visible="true";ISpace["UI_GridPanelOne"].Enbl="true";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""F7DA2CD7-1723-45E3-94F5-6380EB2F0989"")
{
ISpace[""UI_GridPanelOne""].Visible=""true"";ISpace[""UI_GridPanelOne""].Enbl=""true"";
}");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["FormVersionId"].Value=="F7DA2CD7-1723-45E3-94F5-6380EB2F0989")
{
ISpace["UI_GridPanel"].Visible="true";ISpace["UI_GridPanel"].Enbl="true";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""F7DA2CD7-1723-45E3-94F5-6380EB2F0989"")
{
ISpace[""UI_GridPanel""].Visible=""true"";ISpace[""UI_GridPanel""].Enbl=""true"";
}");
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
ISpace["MF_ExpenseDetails_PageIndex"].Value=1;
base.WriteDebugInfo(@"ISpace[""MF_ExpenseDetails_PageIndex""].Value=1;");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'#F_ProjectDetailsId','',#MF_ExpenseDetails_PageIndex,'#MF_ExpenseDetails_GridRows'");

var querySource108B5BFD045B42D7A031893FCF404252 =GetQueryExpressionDataSource("108B5BFD-045B-42D7-A031-893FCF404252");
Dictionary<short,object> result108B5BFD045B42D7A031893FCF404252=iSpace.ExecuteQuery(querySource108B5BFD045B42D7A031893FCF404252,@"EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'" + ISpace["F_ProjectDetailsId"].Value + @"',''," + ISpace["MF_ExpenseDetails_PageIndex"].Value + @",'" + ISpace["MF_ExpenseDetails_GridRows"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource108B5BFD045B42D7A031893FCF404252 =GetQueryExpressionDataSource(""108B5BFD-045B-42D7-A031-893FCF404252"");Dictionary<short,object> result108B5BFD045B42D7A031893FCF404252=iSpace.ExecuteQuery(querySource108B5BFD045B42D7A031893FCF404252,@""EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',"" + ISpace[""MF_ExpenseDetails_PageIndex""].Value + @"",'"" + ISpace[""MF_ExpenseDetails_GridRows""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result108B5BFD045B42D7A031893FCF404252!=null) && (result108B5BFD045B42D7A031893FCF404252.Count!=0))
{
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(0))
ISpace["MF_Budgetdetails_GridRows"].Value = result108B5BFD045B42D7A031893FCF404252[0];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(3))
ISpace["MF_Budgetdetails_TotalPages"].Value = result108B5BFD045B42D7A031893FCF404252[3];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(2))
ISpace["MF_Budgetdetails_PageIndex"].Value = result108B5BFD045B42D7A031893FCF404252[2];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(1))
ISpace["MF_Budgetdetails_RecordsRange"].Value = result108B5BFD045B42D7A031893FCF404252[1];
}
else{
ISpace["MF_Budgetdetails_GridRows"].Value = null;ISpace["MF_Budgetdetails_TotalPages"].Value = null;ISpace["MF_Budgetdetails_PageIndex"].Value = null;ISpace["MF_Budgetdetails_RecordsRange"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==1)");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==ISpace["MF_ExpenseDetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==ISpace[""MF_ExpenseDetails_TotalPages""].Value)");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="false";ISpace["MF_Budgetdetails_LastButton"].Enbl="false";ISpace["MF_Budgetdetails_NextButton"].Enbl="false";ISpace["MF_Budgetdetails_FirstButton"].Enbl="false";ISpace["MF_Budgetdetails_PageIndex"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""false"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="false";ISpace["MF_Budgetdetails_LastButton"].Enbl="true";ISpace["MF_Budgetdetails_NextButton"].Enbl="true";ISpace["MF_Budgetdetails_FirstButton"].Enbl="false";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
}
else
{
base.WriteDebugInfo(@"else");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==ISpace["MF_ExpenseDetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==ISpace[""MF_ExpenseDetails_TotalPages""].Value)");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="true";ISpace["MF_Budgetdetails_LastButton"].Enbl="false";ISpace["MF_Budgetdetails_NextButton"].Enbl="false";ISpace["MF_Budgetdetails_FirstButton"].Enbl="true";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="true";ISpace["MF_Budgetdetails_LastButton"].Enbl="true";ISpace["MF_Budgetdetails_NextButton"].Enbl="true";ISpace["MF_Budgetdetails_FirstButton"].Enbl="true";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySourceA30F7872734E4D34AFDDD8F49130791A =GetQueryExpressionDataSource("A30F7872-734E-4D34-AFDD-D8F49130791A");

DataTable resultA30F7872734E4D34AFDDD8F49130791A=iSpace.SetGridDataSource(querySourceA30F7872734E4D34AFDDD8F49130791A, _objectFactory.GetGridRPP("Budgetdetails"),@"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 1,'" + ISpace["F_BudgetHeadId"].Value + @"',''," + ISpace["MF_Budgetdetails_PageIndex"].Value + @",'" + ISpace["MF_Budgetdetails_GridRows"].Value + @"','" + ISpace["F_ProjectDetailsId"].Value + @"'");

iSpace.InsertGridBindDetails("Budgetdetails","11",querySourceA30F7872734E4D34AFDDD8F49130791A,"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 1,'" + ISpace["F_BudgetHeadId"].Value + @"',''," + ISpace["MF_Budgetdetails_PageIndex"].Value + @",'" + ISpace["MF_Budgetdetails_GridRows"].Value + @"','" + ISpace["F_ProjectDetailsId"].Value + @"'",_objectFactory.GetGridRPP("Budgetdetails"));

base.WriteDebugInfo(@"var querySourceA30F7872734E4D34AFDDD8F49130791A =GetQueryExpressionDataSource(""A30F7872-734E-4D34-AFDD-D8F49130791A"");DataTable resultA30F7872734E4D34AFDDD8F49130791A=iSpace.SetGridDataSource(querySourceA30F7872734E4D34AFDDD8F49130791A, _objectFactory.GetGridRPP(""Budgetdetails""),@""EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 1,'"" + ISpace[""F_BudgetHeadId""].Value + @""','',"" + ISpace[""MF_Budgetdetails_PageIndex""].Value + @"",'"" + ISpace[""MF_Budgetdetails_GridRows""].Value + @""','"" + ISpace[""F_ProjectDetailsId""].Value + @""'"");iSpace.InsertGridBindDetails(""Budgetdetails"",""11"",querySourceA30F7872734E4D34AFDDD8F49130791A,""EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 1,'"" + ISpace[""F_BudgetHeadId""].Value + @""','',"" + ISpace[""MF_Budgetdetails_PageIndex""].Value + @"",'"" + ISpace[""MF_Budgetdetails_GridRows""].Value + @""','"" + ISpace[""F_ProjectDetailsId""].Value + @""'"",_objectFactory.GetGridRPP(""Budgetdetails""));");
base.WriteDebugInfo(@"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 1,'#F_BudgetHeadId','',#MF_Budgetdetails_PageIndex,'#MF_Budgetdetails_GridRows'");


List<Triplet<string, short, short?>> result387A33C1D74545BDA9129E364AE2D589=acdataIspace585BA2B83E754DABB50B10D8320CE414.GetQueryExpressionBindings("387A33C1-D745-45BD-A912-9E364AE2D589");
iSpace.SetGridData(resultA30F7872734E4D34AFDDD8F49130791A,result387A33C1D74545BDA9129E364AE2D589,"Budgetdetails",ref ISpace);
iSpace.UpdateGridBindDetails("Budgetdetails",result387A33C1D74545BDA9129E364AE2D589);
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
base.WriteDebugInfo(@"EXEC dbo.[Dsp_A9A79FF2-946A-41FD-BF38-40BDFB6F6955_Save] '#MF_V1_ExpenseID', '#MF_V1_BudgetHead', '#MF_V1_ProjectDetailsID', '#MF_V1_PackageProcessMapID', '#MF_V1_ExpenseDate', '#MF_V1_AmountSpent', '#MF_V1_ExpenseDescription'");

var querySource75BF6F6133D749929F8458EC277B2A91 =GetQueryExpressionDataSource("75BF6F61-33D7-4992-9F84-58EC277B2A91");
Dictionary<short,object> result75BF6F6133D749929F8458EC277B2A91=iSpace.ExecuteQuery(querySource75BF6F6133D749929F8458EC277B2A91,@"EXEC dbo.[Dsp_A9A79FF2-946A-41FD-BF38-40BDFB6F6955_Save] '" + ISpace["MF_V1_ExpenseID"].Value + @"', '" + ISpace["MF_V1_BudgetHead"].Value + @"', '" + ISpace["MF_V1_ProjectDetailsID"].Value + @"', '" + ISpace["MF_V1_PackageProcessMapID"].Value + @"', '" + ISpace["MF_V1_ExpenseDate"].Value + @"', '" + ISpace["MF_V1_AmountSpent"].Value + @"', '" + ISpace["MF_V1_ExpenseDescription"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource75BF6F6133D749929F8458EC277B2A91 =GetQueryExpressionDataSource(""75BF6F61-33D7-4992-9F84-58EC277B2A91"");Dictionary<short,object> result75BF6F6133D749929F8458EC277B2A91=iSpace.ExecuteQuery(querySource75BF6F6133D749929F8458EC277B2A91,@""EXEC dbo.[Dsp_A9A79FF2-946A-41FD-BF38-40BDFB6F6955_Save] '"" + ISpace[""MF_V1_ExpenseID""].Value + @""', '"" + ISpace[""MF_V1_BudgetHead""].Value + @""', '"" + ISpace[""MF_V1_ProjectDetailsID""].Value + @""', '"" + ISpace[""MF_V1_PackageProcessMapID""].Value + @""', '"" + ISpace[""MF_V1_ExpenseDate""].Value + @""', '"" + ISpace[""MF_V1_AmountSpent""].Value + @""', '"" + ISpace[""MF_V1_ExpenseDescription""].Value + @""'"",false);");
base.WriteDebugInfo(@"EXEC dbo.[Dsp_A9A79FF2-946A-41FD-BF38-40BDFB6F6955_Save] '#MF_V1_ExpenseID', '#MF_V1_BudgetHead', '#MF_V1_ProjectDetailsID', '#MF_V1_PackageProcessMapID', '#MF_V1_ExpenseDate', '#MF_V1_AmountSpent', '#MF_V1_ExpenseDescription'");

if((result75BF6F6133D749929F8458EC277B2A91!=null) && (result75BF6F6133D749929F8458EC277B2A91.Count!=0))
{
if(result75BF6F6133D749929F8458EC277B2A91.ContainsKey(0))
ISpace["Subject"].Value = result75BF6F6133D749929F8458EC277B2A91[0];
}
else{
ISpace["Subject"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC dbo.[Dsp_44CFF822-A4D3-4972-8997-2724F28FE04E_Save] '#MF_V1_ExpenseID', '#MF_V1_BudgetHead', '#MF_V1_ProjectDetailsID', '#MF_V1_PackageProcessMapID', '#MF_V1_ExpenseDate', '#MF_V1_AmountSpent', '#MF_V1_ExpenseDescription'");

var querySourceB1EC4C5B51194C30B93F9964463D7C8D =GetQueryExpressionDataSource("B1EC4C5B-5119-4C30-B93F-9964463D7C8D");
Dictionary<short,object> resultB1EC4C5B51194C30B93F9964463D7C8D=iSpace.ExecuteQuery(querySourceB1EC4C5B51194C30B93F9964463D7C8D,@"EXEC dbo.[Dsp_44CFF822-A4D3-4972-8997-2724F28FE04E_Save] '" + ISpace["MF_V1_ExpenseID"].Value + @"', '" + ISpace["MF_V1_BudgetHead"].Value + @"', '" + ISpace["MF_V1_ProjectDetailsID"].Value + @"', '" + ISpace["MF_V1_PackageProcessMapID"].Value + @"', '" + ISpace["MF_V1_ExpenseDate"].Value + @"', '" + ISpace["MF_V1_AmountSpent"].Value + @"', '" + ISpace["MF_V1_ExpenseDescription"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceB1EC4C5B51194C30B93F9964463D7C8D =GetQueryExpressionDataSource(""B1EC4C5B-5119-4C30-B93F-9964463D7C8D"");Dictionary<short,object> resultB1EC4C5B51194C30B93F9964463D7C8D=iSpace.ExecuteQuery(querySourceB1EC4C5B51194C30B93F9964463D7C8D,@""EXEC dbo.[Dsp_44CFF822-A4D3-4972-8997-2724F28FE04E_Save] '"" + ISpace[""MF_V1_ExpenseID""].Value + @""', '"" + ISpace[""MF_V1_BudgetHead""].Value + @""', '"" + ISpace[""MF_V1_ProjectDetailsID""].Value + @""', '"" + ISpace[""MF_V1_PackageProcessMapID""].Value + @""', '"" + ISpace[""MF_V1_ExpenseDate""].Value + @""', '"" + ISpace[""MF_V1_AmountSpent""].Value + @""', '"" + ISpace[""MF_V1_ExpenseDescription""].Value + @""'"",false);");
base.WriteDebugInfo(@"EXEC dbo.[Dsp_44CFF822-A4D3-4972-8997-2724F28FE04E_Save] '#MF_V1_ExpenseID', '#MF_V1_BudgetHead', '#MF_V1_ProjectDetailsID', '#MF_V1_PackageProcessMapID', '#MF_V1_ExpenseDate', '#MF_V1_AmountSpent', '#MF_V1_ExpenseDescription'");

if((resultB1EC4C5B51194C30B93F9964463D7C8D!=null) && (resultB1EC4C5B51194C30B93F9964463D7C8D.Count!=0))
{
if(resultB1EC4C5B51194C30B93F9964463D7C8D.ContainsKey(0))
ISpace["Subject"].Value = resultB1EC4C5B51194C30B93F9964463D7C8D[0];
}
else{
ISpace["Subject"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC dbo.[Dsp_812C39F9-F85B-42D5-BF27-D08554C67349_Save] '#MF_P1_ReceiptsId', '#MF_P1_ProjectDetailsId', '#MF_P1_ReceiptAmount', '#MF_P1_ReceiptDate', '#MF_P1_TransferType', '#MF_P1_TransferReferenceNumber', '#MF_P1_TransferReferenceDate', '#MF_P1_TransferReferenceBankId', '#MF_P1_TransferReferenceBranch', '#MF_P1_ReceiptNo'");

var querySource29E43B7FE0D54F10A6DACE70CD7B30B4 =GetQueryExpressionDataSource("29E43B7F-E0D5-4F10-A6DA-CE70CD7B30B4");
Dictionary<short,object> result29E43B7FE0D54F10A6DACE70CD7B30B4=iSpace.ExecuteQuery(querySource29E43B7FE0D54F10A6DACE70CD7B30B4,@"EXEC dbo.[Dsp_812C39F9-F85B-42D5-BF27-D08554C67349_Save] '" + ISpace["MF_P1_ReceiptsId"].Value + @"', '" + ISpace["MF_P1_ProjectDetailsId"].Value + @"', '" + ISpace["MF_P1_ReceiptAmount"].Value + @"', '" + ISpace["MF_P1_ReceiptDate"].Value + @"', '" + ISpace["MF_P1_TransferType"].Value + @"', '" + ISpace["MF_P1_TransferReferenceNumber"].Value + @"', '" + ISpace["MF_P1_TransferReferenceDate"].Value + @"', '" + ISpace["MF_P1_TransferReferenceBankId"].Value + @"', '" + ISpace["MF_P1_TransferReferenceBranch"].Value + @"', '" + ISpace["MF_P1_ReceiptNo"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource29E43B7FE0D54F10A6DACE70CD7B30B4 =GetQueryExpressionDataSource(""29E43B7F-E0D5-4F10-A6DA-CE70CD7B30B4"");Dictionary<short,object> result29E43B7FE0D54F10A6DACE70CD7B30B4=iSpace.ExecuteQuery(querySource29E43B7FE0D54F10A6DACE70CD7B30B4,@""EXEC dbo.[Dsp_812C39F9-F85B-42D5-BF27-D08554C67349_Save] '"" + ISpace[""MF_P1_ReceiptsId""].Value + @""', '"" + ISpace[""MF_P1_ProjectDetailsId""].Value + @""', '"" + ISpace[""MF_P1_ReceiptAmount""].Value + @""', '"" + ISpace[""MF_P1_ReceiptDate""].Value + @""', '"" + ISpace[""MF_P1_TransferType""].Value + @""', '"" + ISpace[""MF_P1_TransferReferenceNumber""].Value + @""', '"" + ISpace[""MF_P1_TransferReferenceDate""].Value + @""', '"" + ISpace[""MF_P1_TransferReferenceBankId""].Value + @""', '"" + ISpace[""MF_P1_TransferReferenceBranch""].Value + @""', '"" + ISpace[""MF_P1_ReceiptNo""].Value + @""'"",false);");
base.WriteDebugInfo(@"EXEC dbo.[Dsp_812C39F9-F85B-42D5-BF27-D08554C67349_Save] '#MF_P1_ReceiptsId', '#MF_P1_ProjectDetailsId', '#MF_P1_ReceiptAmount', '#MF_P1_ReceiptDate', '#MF_P1_TransferType', '#MF_P1_TransferReferenceNumber', '#MF_P1_TransferReferenceDate', '#MF_P1_TransferReferenceBankId', '#MF_P1_TransferReferenceBranch', '#MF_P1_ReceiptNo'");

if((result29E43B7FE0D54F10A6DACE70CD7B30B4!=null) && (result29E43B7FE0D54F10A6DACE70CD7B30B4.Count!=0))
{
if(result29E43B7FE0D54F10A6DACE70CD7B30B4.ContainsKey(0))
ISpace["Subject"].Value = result29E43B7FE0D54F10A6DACE70CD7B30B4[0];
}
else{
ISpace["Subject"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC dbo.[Dsp_36DF80B9-922D-4320-8CCE-6E4485341172_Save] '#MF_V1_BudgetHeadID', '#MF_V1_ProjectDetailsID', '#MF_V1_BudgetHead', '#MF_V1_SanctionedAmount', '#MF_V1_ReceivedAmount', '#MF_V1_YettoReceive', '#MF_V1_Spent', '#MF_V1_Committment', '#MF_V1_Balance'");

var querySourceAC65A516ABD04F7D9F9452DC9A70822E =GetQueryExpressionDataSource("AC65A516-ABD0-4F7D-9F94-52DC9A70822E");
Dictionary<short,object> resultAC65A516ABD04F7D9F9452DC9A70822E=iSpace.ExecuteQuery(querySourceAC65A516ABD04F7D9F9452DC9A70822E,@"EXEC dbo.[Dsp_36DF80B9-922D-4320-8CCE-6E4485341172_Save] '" + ISpace["MF_V1_BudgetHeadID"].Value + @"', '" + ISpace["MF_V1_ProjectDetailsID"].Value + @"', '" + ISpace["MF_V1_BudgetHead"].Value + @"', '" + ISpace["MF_V1_SanctionedAmount"].Value + @"', '" + ISpace["MF_V1_ReceivedAmount"].Value + @"', '" + ISpace["MF_V1_YettoReceive"].Value + @"', '" + ISpace["MF_V1_Spent"].Value + @"', '" + ISpace["MF_V1_Committment"].Value + @"', '" + ISpace["MF_V1_Balance"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceAC65A516ABD04F7D9F9452DC9A70822E =GetQueryExpressionDataSource(""AC65A516-ABD0-4F7D-9F94-52DC9A70822E"");Dictionary<short,object> resultAC65A516ABD04F7D9F9452DC9A70822E=iSpace.ExecuteQuery(querySourceAC65A516ABD04F7D9F9452DC9A70822E,@""EXEC dbo.[Dsp_36DF80B9-922D-4320-8CCE-6E4485341172_Save] '"" + ISpace[""MF_V1_BudgetHeadID""].Value + @""', '"" + ISpace[""MF_V1_ProjectDetailsID""].Value + @""', '"" + ISpace[""MF_V1_BudgetHead""].Value + @""', '"" + ISpace[""MF_V1_SanctionedAmount""].Value + @""', '"" + ISpace[""MF_V1_ReceivedAmount""].Value + @""', '"" + ISpace[""MF_V1_YettoReceive""].Value + @""', '"" + ISpace[""MF_V1_Spent""].Value + @""', '"" + ISpace[""MF_V1_Committment""].Value + @""', '"" + ISpace[""MF_V1_Balance""].Value + @""'"",false);");
base.WriteDebugInfo(@"EXEC dbo.[Dsp_36DF80B9-922D-4320-8CCE-6E4485341172_Save] '#MF_V1_BudgetHeadID', '#MF_V1_ProjectDetailsID', '#MF_V1_BudgetHead', '#MF_V1_SanctionedAmount', '#MF_V1_ReceivedAmount', '#MF_V1_YettoReceive', '#MF_V1_Spent', '#MF_V1_Committment', '#MF_V1_Balance'");

if((resultAC65A516ABD04F7D9F9452DC9A70822E!=null) && (resultAC65A516ABD04F7D9F9452DC9A70822E.Count!=0))
{
if(resultAC65A516ABD04F7D9F9452DC9A70822E.ContainsKey(0))
ISpace["Subject"].Value = resultAC65A516ABD04F7D9F9452DC9A70822E[0];
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
ISpace["UI_GridPanelOne"].Visible="true";ISpace["UI_GridPanelOne"].Enbl="true";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""F7DA2CD7-1723-45E3-94F5-6380EB2F0989"")
{
ISpace[""UI_GridPanelOne""].Visible=""true"";ISpace[""UI_GridPanelOne""].Enbl=""true"";
}");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["FormVersionId"].Value=="F7DA2CD7-1723-45E3-94F5-6380EB2F0989")
{
ISpace["UI_GridPanelthree"].Visible="true";ISpace["UI_GridPanelthree"].Enbl="true";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""F7DA2CD7-1723-45E3-94F5-6380EB2F0989"")
{
ISpace[""UI_GridPanelthree""].Visible=""true"";ISpace[""UI_GridPanelthree""].Enbl=""true"";
}");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["FormVersionId"].Value=="F7DA2CD7-1723-45E3-94F5-6380EB2F0989")
{
ISpace["UI_SearchPanel"].Visible="true";ISpace["UI_SearchPanel"].Enbl="true";
}if(ISpace["FormVersionId"].Value=="F7DA2CD7-1723-45E3-94F5-6380EB2F0989")
{
ISpace["UI_GridPanelTwo"].Visible="true";ISpace["UI_GridPanelTwo"].Enbl="true";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""F7DA2CD7-1723-45E3-94F5-6380EB2F0989"")
{
ISpace[""UI_SearchPanel""].Visible=""true"";ISpace[""UI_SearchPanel""].Enbl=""true"";
}if(ISpace[""FormVersionId""].Value==""F7DA2CD7-1723-45E3-94F5-6380EB2F0989"")
{
ISpace[""UI_GridPanelTwo""].Visible=""true"";ISpace[""UI_GridPanelTwo""].Enbl=""true"";
}");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["FormVersionId"].Value=="F7DA2CD7-1723-45E3-94F5-6380EB2F0989")
{
ISpace["UI_GridPanel"].Visible="true";ISpace["UI_GridPanel"].Enbl="true";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""F7DA2CD7-1723-45E3-94F5-6380EB2F0989"")
{
ISpace[""UI_GridPanel""].Visible=""true"";ISpace[""UI_GridPanel""].Enbl=""true"";
}");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySourceFC2A5065A4C24EC0B017375CE0B0B812 =GetQueryExpressionDataSource("FC2A5065-A4C2-4EC0-B017-375CE0B0B812");

DataTable resultFC2A5065A4C24EC0B017375CE0B0B812=iSpace.SetGridDataSource(querySourceFC2A5065A4C24EC0B017375CE0B0B812, _objectFactory.GetGridRPP("ExpenseDetails"),@"EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 1,'" + ISpace["F_ProjectDetailsId"].Value + @"',''," + ISpace["MF_ExpenseDetails_PageIndex"].Value + @",'" + ISpace["MF_ExpenseDetails_GridRows"].Value + @"'");

iSpace.InsertGridBindDetails("ExpenseDetails","11",querySourceFC2A5065A4C24EC0B017375CE0B0B812,"EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 1,'" + ISpace["F_ProjectDetailsId"].Value + @"',''," + ISpace["MF_ExpenseDetails_PageIndex"].Value + @",'" + ISpace["MF_ExpenseDetails_GridRows"].Value + @"'",_objectFactory.GetGridRPP("ExpenseDetails"));

base.WriteDebugInfo(@"var querySourceFC2A5065A4C24EC0B017375CE0B0B812 =GetQueryExpressionDataSource(""FC2A5065-A4C2-4EC0-B017-375CE0B0B812"");DataTable resultFC2A5065A4C24EC0B017375CE0B0B812=iSpace.SetGridDataSource(querySourceFC2A5065A4C24EC0B017375CE0B0B812, _objectFactory.GetGridRPP(""ExpenseDetails""),@""EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 1,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',"" + ISpace[""MF_ExpenseDetails_PageIndex""].Value + @"",'"" + ISpace[""MF_ExpenseDetails_GridRows""].Value + @""'"");iSpace.InsertGridBindDetails(""ExpenseDetails"",""11"",querySourceFC2A5065A4C24EC0B017375CE0B0B812,""EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 1,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',"" + ISpace[""MF_ExpenseDetails_PageIndex""].Value + @"",'"" + ISpace[""MF_ExpenseDetails_GridRows""].Value + @""'"",_objectFactory.GetGridRPP(""ExpenseDetails""));");
base.WriteDebugInfo(@"EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 1,'#F_ExpenseId','',#MF_ExpenseDetails_PageIndex,'#MF_ExpenseDetails_GridRows'");


List<Triplet<string, short, short?>> resultF156A8611F4D43F2884E90DD3F9E66E3=acdataIspace585BA2B83E754DABB50B10D8320CE414.GetQueryExpressionBindings("F156A861-1F4D-43F2-884E-90DD3F9E66E3");
iSpace.SetGridData(resultFC2A5065A4C24EC0B017375CE0B0B812,resultF156A8611F4D43F2884E90DD3F9E66E3,"ExpenseDetails",ref ISpace);
iSpace.UpdateGridBindDetails("ExpenseDetails",resultF156A8611F4D43F2884E90DD3F9E66E3);
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySourceCA82683BCA014525A93F68B518D9FCFA =GetQueryExpressionDataSource("CA82683B-CA01-4525-A93F-68B518D9FCFA");

DataTable resultCA82683BCA014525A93F68B518D9FCFA=iSpace.SetGridDataSource(querySourceCA82683BCA014525A93F68B518D9FCFA, _objectFactory.GetGridRPP("ProjectCommitments"),@"EXEC dbo.[Get_e046fb44-e1f1-4f2a-a07e-231e72f92166_FilterData] 1,'" + ISpace["F_ProjectDetailsId"].Value + @"',''," + ISpace["MF_ProjectCommitments_PageIndex"].Value + @",'" + ISpace["MF_ProjectCommitments_GridRows"].Value + @"'");

iSpace.InsertGridBindDetails("ProjectCommitments","11",querySourceCA82683BCA014525A93F68B518D9FCFA,"EXEC dbo.[Get_e046fb44-e1f1-4f2a-a07e-231e72f92166_FilterData] 1,'" + ISpace["F_ProjectDetailsId"].Value + @"',''," + ISpace["MF_ProjectCommitments_PageIndex"].Value + @",'" + ISpace["MF_ProjectCommitments_GridRows"].Value + @"'",_objectFactory.GetGridRPP("ProjectCommitments"));

base.WriteDebugInfo(@"var querySourceCA82683BCA014525A93F68B518D9FCFA =GetQueryExpressionDataSource(""CA82683B-CA01-4525-A93F-68B518D9FCFA"");DataTable resultCA82683BCA014525A93F68B518D9FCFA=iSpace.SetGridDataSource(querySourceCA82683BCA014525A93F68B518D9FCFA, _objectFactory.GetGridRPP(""ProjectCommitments""),@""EXEC dbo.[Get_e046fb44-e1f1-4f2a-a07e-231e72f92166_FilterData] 1,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',"" + ISpace[""MF_ProjectCommitments_PageIndex""].Value + @"",'"" + ISpace[""MF_ProjectCommitments_GridRows""].Value + @""'"");iSpace.InsertGridBindDetails(""ProjectCommitments"",""11"",querySourceCA82683BCA014525A93F68B518D9FCFA,""EXEC dbo.[Get_e046fb44-e1f1-4f2a-a07e-231e72f92166_FilterData] 1,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',"" + ISpace[""MF_ProjectCommitments_PageIndex""].Value + @"",'"" + ISpace[""MF_ProjectCommitments_GridRows""].Value + @""'"",_objectFactory.GetGridRPP(""ProjectCommitments""));");
base.WriteDebugInfo(@"EXEC dbo.[Get_e046fb44-e1f1-4f2a-a07e-231e72f92166_FilterData] 1,'#F_ProjectDetailsId','',#MF_ProjectCommitments_PageIndex,'#MF_ProjectCommitments_GridRows'");


List<Triplet<string, short, short?>> resultF24D61150F9946679299168E58B151A1=acdataIspace585BA2B83E754DABB50B10D8320CE414.GetQueryExpressionBindings("F24D6115-0F99-4667-9299-168E58B151A1");
iSpace.SetGridData(resultCA82683BCA014525A93F68B518D9FCFA,resultF24D61150F9946679299168E58B151A1,"ProjectCommitments",ref ISpace);
iSpace.UpdateGridBindDetails("ProjectCommitments",resultF24D61150F9946679299168E58B151A1);
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySource94B9568E6AA646109AB971682A69C231 =GetQueryExpressionDataSource("94B9568E-6AA6-4610-9AB9-71682A69C231");

DataTable result94B9568E6AA646109AB971682A69C231=iSpace.SetGridDataSource(querySource94B9568E6AA646109AB971682A69C231, _objectFactory.GetGridRPP("ReceiptsView"),@"EXEC dbo.[Get_bd3abae8-b5a2-4b71-b3e2-e46732479592_FilterData] 1,'" + ISpace["F_ReceiptNo"].Value + @"',''," + ISpace["MF_ReceiptsView_PageIndex"].Value + @",'" + ISpace["MF_ReceiptsView_GridRows"].Value + @"','" + ISpace["F_ProjectDetailsID"].Value + @"'");

iSpace.InsertGridBindDetails("ReceiptsView","11",querySource94B9568E6AA646109AB971682A69C231,"EXEC dbo.[Get_bd3abae8-b5a2-4b71-b3e2-e46732479592_FilterData] 1,'" + ISpace["F_ReceiptNo"].Value + @"',''," + ISpace["MF_ReceiptsView_PageIndex"].Value + @",'" + ISpace["MF_ReceiptsView_GridRows"].Value + @"','" + ISpace["F_ProjectDetailsID"].Value + @"'",_objectFactory.GetGridRPP("ReceiptsView"));

base.WriteDebugInfo(@"var querySource94B9568E6AA646109AB971682A69C231 =GetQueryExpressionDataSource(""94B9568E-6AA6-4610-9AB9-71682A69C231"");DataTable result94B9568E6AA646109AB971682A69C231=iSpace.SetGridDataSource(querySource94B9568E6AA646109AB971682A69C231, _objectFactory.GetGridRPP(""ReceiptsView""),@""EXEC dbo.[Get_bd3abae8-b5a2-4b71-b3e2-e46732479592_FilterData] 1,'"" + ISpace[""F_ReceiptNo""].Value + @""','',"" + ISpace[""MF_ReceiptsView_PageIndex""].Value + @"",'"" + ISpace[""MF_ReceiptsView_GridRows""].Value + @""','"" + ISpace[""F_ProjectDetailsID""].Value + @""'"");iSpace.InsertGridBindDetails(""ReceiptsView"",""11"",querySource94B9568E6AA646109AB971682A69C231,""EXEC dbo.[Get_bd3abae8-b5a2-4b71-b3e2-e46732479592_FilterData] 1,'"" + ISpace[""F_ReceiptNo""].Value + @""','',"" + ISpace[""MF_ReceiptsView_PageIndex""].Value + @"",'"" + ISpace[""MF_ReceiptsView_GridRows""].Value + @""','"" + ISpace[""F_ProjectDetailsID""].Value + @""'"",_objectFactory.GetGridRPP(""ReceiptsView""));");
base.WriteDebugInfo(@"EXEC dbo.[Get_bd3abae8-b5a2-4b71-b3e2-e46732479592_FilterData] 1,'#F_ReceiptNo','',#MF_ReceiptsView_PageIndex,'#MF_ReceiptsView_GridRows'");


List<Triplet<string, short, short?>> result6C0E534F5B5649E8BDBDB1A399E4F9C5=acdataIspace585BA2B83E754DABB50B10D8320CE414.GetQueryExpressionBindings("6C0E534F-5B56-49E8-BDBD-B1A399E4F9C5");
iSpace.SetGridData(result94B9568E6AA646109AB971682A69C231,result6C0E534F5B5649E8BDBDB1A399E4F9C5,"ReceiptsView",ref ISpace);
iSpace.UpdateGridBindDetails("ReceiptsView",result6C0E534F5B5649E8BDBDB1A399E4F9C5);
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'#F_ProjectDetailsId','',#MF_ExpenseDetails_PageIndex,'#MF_ExpenseDetails_GridRows'");

var querySource108B5BFD045B42D7A031893FCF404252 =GetQueryExpressionDataSource("108B5BFD-045B-42D7-A031-893FCF404252");
Dictionary<short,object> result108B5BFD045B42D7A031893FCF404252=iSpace.ExecuteQuery(querySource108B5BFD045B42D7A031893FCF404252,@"EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'" + ISpace["F_ProjectDetailsId"].Value + @"',''," + ISpace["MF_ExpenseDetails_PageIndex"].Value + @",'" + ISpace["MF_ExpenseDetails_GridRows"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource108B5BFD045B42D7A031893FCF404252 =GetQueryExpressionDataSource(""108B5BFD-045B-42D7-A031-893FCF404252"");Dictionary<short,object> result108B5BFD045B42D7A031893FCF404252=iSpace.ExecuteQuery(querySource108B5BFD045B42D7A031893FCF404252,@""EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',"" + ISpace[""MF_ExpenseDetails_PageIndex""].Value + @"",'"" + ISpace[""MF_ExpenseDetails_GridRows""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result108B5BFD045B42D7A031893FCF404252!=null) && (result108B5BFD045B42D7A031893FCF404252.Count!=0))
{
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(0))
ISpace["MF_Budgetdetails_GridRows"].Value = result108B5BFD045B42D7A031893FCF404252[0];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(3))
ISpace["MF_Budgetdetails_TotalPages"].Value = result108B5BFD045B42D7A031893FCF404252[3];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(2))
ISpace["MF_Budgetdetails_PageIndex"].Value = result108B5BFD045B42D7A031893FCF404252[2];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(1))
ISpace["MF_Budgetdetails_RecordsRange"].Value = result108B5BFD045B42D7A031893FCF404252[1];
}
else{
ISpace["MF_Budgetdetails_GridRows"].Value = null;ISpace["MF_Budgetdetails_TotalPages"].Value = null;ISpace["MF_Budgetdetails_PageIndex"].Value = null;ISpace["MF_Budgetdetails_RecordsRange"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'#F_ProjectDetailsId','',#MF_ExpenseDetails_PageIndex,'#MF_ExpenseDetails_GridRows'");

var querySource108B5BFD045B42D7A031893FCF404252 =GetQueryExpressionDataSource("108B5BFD-045B-42D7-A031-893FCF404252");
Dictionary<short,object> result108B5BFD045B42D7A031893FCF404252=iSpace.ExecuteQuery(querySource108B5BFD045B42D7A031893FCF404252,@"EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'" + ISpace["F_ProjectDetailsId"].Value + @"',''," + ISpace["MF_ExpenseDetails_PageIndex"].Value + @",'" + ISpace["MF_ExpenseDetails_GridRows"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource108B5BFD045B42D7A031893FCF404252 =GetQueryExpressionDataSource(""108B5BFD-045B-42D7-A031-893FCF404252"");Dictionary<short,object> result108B5BFD045B42D7A031893FCF404252=iSpace.ExecuteQuery(querySource108B5BFD045B42D7A031893FCF404252,@""EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',"" + ISpace[""MF_ExpenseDetails_PageIndex""].Value + @"",'"" + ISpace[""MF_ExpenseDetails_GridRows""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result108B5BFD045B42D7A031893FCF404252!=null) && (result108B5BFD045B42D7A031893FCF404252.Count!=0))
{
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(0))
ISpace["MF_Budgetdetails_GridRows"].Value = result108B5BFD045B42D7A031893FCF404252[0];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(3))
ISpace["MF_Budgetdetails_TotalPages"].Value = result108B5BFD045B42D7A031893FCF404252[3];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(2))
ISpace["MF_Budgetdetails_PageIndex"].Value = result108B5BFD045B42D7A031893FCF404252[2];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(1))
ISpace["MF_Budgetdetails_RecordsRange"].Value = result108B5BFD045B42D7A031893FCF404252[1];
}
else{
ISpace["MF_Budgetdetails_GridRows"].Value = null;ISpace["MF_Budgetdetails_TotalPages"].Value = null;ISpace["MF_Budgetdetails_PageIndex"].Value = null;ISpace["MF_Budgetdetails_RecordsRange"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'#F_ProjectDetailsId','',#MF_ExpenseDetails_PageIndex,'#MF_ExpenseDetails_GridRows'");

var querySource108B5BFD045B42D7A031893FCF404252 =GetQueryExpressionDataSource("108B5BFD-045B-42D7-A031-893FCF404252");
Dictionary<short,object> result108B5BFD045B42D7A031893FCF404252=iSpace.ExecuteQuery(querySource108B5BFD045B42D7A031893FCF404252,@"EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'" + ISpace["F_ProjectDetailsId"].Value + @"',''," + ISpace["MF_ExpenseDetails_PageIndex"].Value + @",'" + ISpace["MF_ExpenseDetails_GridRows"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource108B5BFD045B42D7A031893FCF404252 =GetQueryExpressionDataSource(""108B5BFD-045B-42D7-A031-893FCF404252"");Dictionary<short,object> result108B5BFD045B42D7A031893FCF404252=iSpace.ExecuteQuery(querySource108B5BFD045B42D7A031893FCF404252,@""EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',"" + ISpace[""MF_ExpenseDetails_PageIndex""].Value + @"",'"" + ISpace[""MF_ExpenseDetails_GridRows""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result108B5BFD045B42D7A031893FCF404252!=null) && (result108B5BFD045B42D7A031893FCF404252.Count!=0))
{
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(0))
ISpace["MF_Budgetdetails_GridRows"].Value = result108B5BFD045B42D7A031893FCF404252[0];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(3))
ISpace["MF_Budgetdetails_TotalPages"].Value = result108B5BFD045B42D7A031893FCF404252[3];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(2))
ISpace["MF_Budgetdetails_PageIndex"].Value = result108B5BFD045B42D7A031893FCF404252[2];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(1))
ISpace["MF_Budgetdetails_RecordsRange"].Value = result108B5BFD045B42D7A031893FCF404252[1];
}
else{
ISpace["MF_Budgetdetails_GridRows"].Value = null;ISpace["MF_Budgetdetails_TotalPages"].Value = null;ISpace["MF_Budgetdetails_PageIndex"].Value = null;ISpace["MF_Budgetdetails_RecordsRange"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'#F_ProjectDetailsId','',#MF_ExpenseDetails_PageIndex,'#MF_ExpenseDetails_GridRows'");

var querySource108B5BFD045B42D7A031893FCF404252 =GetQueryExpressionDataSource("108B5BFD-045B-42D7-A031-893FCF404252");
Dictionary<short,object> result108B5BFD045B42D7A031893FCF404252=iSpace.ExecuteQuery(querySource108B5BFD045B42D7A031893FCF404252,@"EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'" + ISpace["F_ProjectDetailsId"].Value + @"',''," + ISpace["MF_ExpenseDetails_PageIndex"].Value + @",'" + ISpace["MF_ExpenseDetails_GridRows"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource108B5BFD045B42D7A031893FCF404252 =GetQueryExpressionDataSource(""108B5BFD-045B-42D7-A031-893FCF404252"");Dictionary<short,object> result108B5BFD045B42D7A031893FCF404252=iSpace.ExecuteQuery(querySource108B5BFD045B42D7A031893FCF404252,@""EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',"" + ISpace[""MF_ExpenseDetails_PageIndex""].Value + @"",'"" + ISpace[""MF_ExpenseDetails_GridRows""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result108B5BFD045B42D7A031893FCF404252!=null) && (result108B5BFD045B42D7A031893FCF404252.Count!=0))
{
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(0))
ISpace["MF_Budgetdetails_GridRows"].Value = result108B5BFD045B42D7A031893FCF404252[0];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(3))
ISpace["MF_Budgetdetails_TotalPages"].Value = result108B5BFD045B42D7A031893FCF404252[3];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(2))
ISpace["MF_Budgetdetails_PageIndex"].Value = result108B5BFD045B42D7A031893FCF404252[2];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(1))
ISpace["MF_Budgetdetails_RecordsRange"].Value = result108B5BFD045B42D7A031893FCF404252[1];
}
else{
ISpace["MF_Budgetdetails_GridRows"].Value = null;ISpace["MF_Budgetdetails_TotalPages"].Value = null;ISpace["MF_Budgetdetails_PageIndex"].Value = null;ISpace["MF_Budgetdetails_RecordsRange"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==1)");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==ISpace["MF_ExpenseDetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==ISpace[""MF_ExpenseDetails_TotalPages""].Value)");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="false";ISpace["MF_Budgetdetails_LastButton"].Enbl="false";ISpace["MF_Budgetdetails_NextButton"].Enbl="false";ISpace["MF_Budgetdetails_FirstButton"].Enbl="false";ISpace["MF_Budgetdetails_PageIndex"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""false"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="false";ISpace["MF_Budgetdetails_LastButton"].Enbl="true";ISpace["MF_Budgetdetails_NextButton"].Enbl="true";ISpace["MF_Budgetdetails_FirstButton"].Enbl="false";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
}
else
{
base.WriteDebugInfo(@"else");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==ISpace["MF_ExpenseDetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==ISpace[""MF_ExpenseDetails_TotalPages""].Value)");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="true";ISpace["MF_Budgetdetails_LastButton"].Enbl="false";ISpace["MF_Budgetdetails_NextButton"].Enbl="false";ISpace["MF_Budgetdetails_FirstButton"].Enbl="true";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="true";ISpace["MF_Budgetdetails_LastButton"].Enbl="true";ISpace["MF_Budgetdetails_NextButton"].Enbl="true";ISpace["MF_Budgetdetails_FirstButton"].Enbl="true";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==1)");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==ISpace["MF_ExpenseDetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==ISpace[""MF_ExpenseDetails_TotalPages""].Value)");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="false";ISpace["MF_Budgetdetails_LastButton"].Enbl="false";ISpace["MF_Budgetdetails_NextButton"].Enbl="false";ISpace["MF_Budgetdetails_FirstButton"].Enbl="false";ISpace["MF_Budgetdetails_PageIndex"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""false"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="false";ISpace["MF_Budgetdetails_LastButton"].Enbl="true";ISpace["MF_Budgetdetails_NextButton"].Enbl="true";ISpace["MF_Budgetdetails_FirstButton"].Enbl="false";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
}
else
{
base.WriteDebugInfo(@"else");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==ISpace["MF_ExpenseDetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==ISpace[""MF_ExpenseDetails_TotalPages""].Value)");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="true";ISpace["MF_Budgetdetails_LastButton"].Enbl="false";ISpace["MF_Budgetdetails_NextButton"].Enbl="false";ISpace["MF_Budgetdetails_FirstButton"].Enbl="true";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="true";ISpace["MF_Budgetdetails_LastButton"].Enbl="true";ISpace["MF_Budgetdetails_NextButton"].Enbl="true";ISpace["MF_Budgetdetails_FirstButton"].Enbl="true";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==1)");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==ISpace["MF_ExpenseDetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==ISpace[""MF_ExpenseDetails_TotalPages""].Value)");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="false";ISpace["MF_Budgetdetails_LastButton"].Enbl="false";ISpace["MF_Budgetdetails_NextButton"].Enbl="false";ISpace["MF_Budgetdetails_FirstButton"].Enbl="false";ISpace["MF_Budgetdetails_PageIndex"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""false"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="false";ISpace["MF_Budgetdetails_LastButton"].Enbl="true";ISpace["MF_Budgetdetails_NextButton"].Enbl="true";ISpace["MF_Budgetdetails_FirstButton"].Enbl="false";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
}
else
{
base.WriteDebugInfo(@"else");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==ISpace["MF_ExpenseDetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==ISpace[""MF_ExpenseDetails_TotalPages""].Value)");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="true";ISpace["MF_Budgetdetails_LastButton"].Enbl="false";ISpace["MF_Budgetdetails_NextButton"].Enbl="false";ISpace["MF_Budgetdetails_FirstButton"].Enbl="true";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="true";ISpace["MF_Budgetdetails_LastButton"].Enbl="true";ISpace["MF_Budgetdetails_NextButton"].Enbl="true";ISpace["MF_Budgetdetails_FirstButton"].Enbl="true";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==1)");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==ISpace["MF_ExpenseDetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==ISpace[""MF_ExpenseDetails_TotalPages""].Value)");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="false";ISpace["MF_Budgetdetails_LastButton"].Enbl="false";ISpace["MF_Budgetdetails_NextButton"].Enbl="false";ISpace["MF_Budgetdetails_FirstButton"].Enbl="false";ISpace["MF_Budgetdetails_PageIndex"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""false"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="false";ISpace["MF_Budgetdetails_LastButton"].Enbl="true";ISpace["MF_Budgetdetails_NextButton"].Enbl="true";ISpace["MF_Budgetdetails_FirstButton"].Enbl="false";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
}
else
{
base.WriteDebugInfo(@"else");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==ISpace["MF_ExpenseDetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==ISpace[""MF_ExpenseDetails_TotalPages""].Value)");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="true";ISpace["MF_Budgetdetails_LastButton"].Enbl="false";ISpace["MF_Budgetdetails_NextButton"].Enbl="false";ISpace["MF_Budgetdetails_FirstButton"].Enbl="true";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="true";ISpace["MF_Budgetdetails_LastButton"].Enbl="true";ISpace["MF_Budgetdetails_NextButton"].Enbl="true";ISpace["MF_Budgetdetails_FirstButton"].Enbl="true";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySourceA30F7872734E4D34AFDDD8F49130791A =GetQueryExpressionDataSource("A30F7872-734E-4D34-AFDD-D8F49130791A");

DataTable resultA30F7872734E4D34AFDDD8F49130791A=iSpace.SetGridDataSource(querySourceA30F7872734E4D34AFDDD8F49130791A, _objectFactory.GetGridRPP("Budgetdetails"),@"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 1,'" + ISpace["F_BudgetHeadId"].Value + @"',''," + ISpace["MF_Budgetdetails_PageIndex"].Value + @",'" + ISpace["MF_Budgetdetails_GridRows"].Value + @"','" + ISpace["F_ProjectDetailsId"].Value + @"'");

iSpace.InsertGridBindDetails("Budgetdetails","11",querySourceA30F7872734E4D34AFDDD8F49130791A,"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 1,'" + ISpace["F_BudgetHeadId"].Value + @"',''," + ISpace["MF_Budgetdetails_PageIndex"].Value + @",'" + ISpace["MF_Budgetdetails_GridRows"].Value + @"','" + ISpace["F_ProjectDetailsId"].Value + @"'",_objectFactory.GetGridRPP("Budgetdetails"));

base.WriteDebugInfo(@"var querySourceA30F7872734E4D34AFDDD8F49130791A =GetQueryExpressionDataSource(""A30F7872-734E-4D34-AFDD-D8F49130791A"");DataTable resultA30F7872734E4D34AFDDD8F49130791A=iSpace.SetGridDataSource(querySourceA30F7872734E4D34AFDDD8F49130791A, _objectFactory.GetGridRPP(""Budgetdetails""),@""EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 1,'"" + ISpace[""F_BudgetHeadId""].Value + @""','',"" + ISpace[""MF_Budgetdetails_PageIndex""].Value + @"",'"" + ISpace[""MF_Budgetdetails_GridRows""].Value + @""','"" + ISpace[""F_ProjectDetailsId""].Value + @""'"");iSpace.InsertGridBindDetails(""Budgetdetails"",""11"",querySourceA30F7872734E4D34AFDDD8F49130791A,""EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 1,'"" + ISpace[""F_BudgetHeadId""].Value + @""','',"" + ISpace[""MF_Budgetdetails_PageIndex""].Value + @"",'"" + ISpace[""MF_Budgetdetails_GridRows""].Value + @""','"" + ISpace[""F_ProjectDetailsId""].Value + @""'"",_objectFactory.GetGridRPP(""Budgetdetails""));");
base.WriteDebugInfo(@"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 1,'#F_BudgetHeadId','',#MF_Budgetdetails_PageIndex,'#MF_Budgetdetails_GridRows'");


List<Triplet<string, short, short?>> result387A33C1D74545BDA9129E364AE2D589=acdataIspace585BA2B83E754DABB50B10D8320CE414.GetQueryExpressionBindings("387A33C1-D745-45BD-A912-9E364AE2D589");
iSpace.SetGridData(resultA30F7872734E4D34AFDDD8F49130791A,result387A33C1D74545BDA9129E364AE2D589,"Budgetdetails",ref ISpace);
iSpace.UpdateGridBindDetails("Budgetdetails",result387A33C1D74545BDA9129E364AE2D589);
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
base.WriteDebugInfo(@"EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'#F_ProjectDetailsId','',#MF_ExpenseDetails_PageIndex,'#MF_ExpenseDetails_GridRows'");

var querySource108B5BFD045B42D7A031893FCF404252 =GetQueryExpressionDataSource("108B5BFD-045B-42D7-A031-893FCF404252");
Dictionary<short,object> result108B5BFD045B42D7A031893FCF404252=iSpace.ExecuteQuery(querySource108B5BFD045B42D7A031893FCF404252,@"EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'" + ISpace["F_ProjectDetailsId"].Value + @"',''," + ISpace["MF_ExpenseDetails_PageIndex"].Value + @",'" + ISpace["MF_ExpenseDetails_GridRows"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource108B5BFD045B42D7A031893FCF404252 =GetQueryExpressionDataSource(""108B5BFD-045B-42D7-A031-893FCF404252"");Dictionary<short,object> result108B5BFD045B42D7A031893FCF404252=iSpace.ExecuteQuery(querySource108B5BFD045B42D7A031893FCF404252,@""EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',"" + ISpace[""MF_ExpenseDetails_PageIndex""].Value + @"",'"" + ISpace[""MF_ExpenseDetails_GridRows""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result108B5BFD045B42D7A031893FCF404252!=null) && (result108B5BFD045B42D7A031893FCF404252.Count!=0))
{
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(0))
ISpace["MF_Budgetdetails_GridRows"].Value = result108B5BFD045B42D7A031893FCF404252[0];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(3))
ISpace["MF_Budgetdetails_TotalPages"].Value = result108B5BFD045B42D7A031893FCF404252[3];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(2))
ISpace["MF_Budgetdetails_PageIndex"].Value = result108B5BFD045B42D7A031893FCF404252[2];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(1))
ISpace["MF_Budgetdetails_RecordsRange"].Value = result108B5BFD045B42D7A031893FCF404252[1];
}
else{
ISpace["MF_Budgetdetails_GridRows"].Value = null;ISpace["MF_Budgetdetails_TotalPages"].Value = null;ISpace["MF_Budgetdetails_PageIndex"].Value = null;ISpace["MF_Budgetdetails_RecordsRange"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==1)");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==ISpace["MF_ExpenseDetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==ISpace[""MF_ExpenseDetails_TotalPages""].Value)");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="false";ISpace["MF_Budgetdetails_LastButton"].Enbl="false";ISpace["MF_Budgetdetails_NextButton"].Enbl="false";ISpace["MF_Budgetdetails_FirstButton"].Enbl="false";ISpace["MF_Budgetdetails_PageIndex"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""false"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="false";ISpace["MF_Budgetdetails_LastButton"].Enbl="true";ISpace["MF_Budgetdetails_NextButton"].Enbl="true";ISpace["MF_Budgetdetails_FirstButton"].Enbl="false";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
}
else
{
base.WriteDebugInfo(@"else");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==ISpace["MF_ExpenseDetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==ISpace[""MF_ExpenseDetails_TotalPages""].Value)");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="true";ISpace["MF_Budgetdetails_LastButton"].Enbl="false";ISpace["MF_Budgetdetails_NextButton"].Enbl="false";ISpace["MF_Budgetdetails_FirstButton"].Enbl="true";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="true";ISpace["MF_Budgetdetails_LastButton"].Enbl="true";ISpace["MF_Budgetdetails_NextButton"].Enbl="true";ISpace["MF_Budgetdetails_FirstButton"].Enbl="true";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySourceA30F7872734E4D34AFDDD8F49130791A =GetQueryExpressionDataSource("A30F7872-734E-4D34-AFDD-D8F49130791A");

DataTable resultA30F7872734E4D34AFDDD8F49130791A=iSpace.SetGridDataSource(querySourceA30F7872734E4D34AFDDD8F49130791A, _objectFactory.GetGridRPP("Budgetdetails"),@"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 1,'" + ISpace["F_BudgetHeadId"].Value + @"',''," + ISpace["MF_Budgetdetails_PageIndex"].Value + @",'" + ISpace["MF_Budgetdetails_GridRows"].Value + @"','" + ISpace["F_ProjectDetailsId"].Value + @"'");

iSpace.InsertGridBindDetails("Budgetdetails","11",querySourceA30F7872734E4D34AFDDD8F49130791A,"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 1,'" + ISpace["F_BudgetHeadId"].Value + @"',''," + ISpace["MF_Budgetdetails_PageIndex"].Value + @",'" + ISpace["MF_Budgetdetails_GridRows"].Value + @"','" + ISpace["F_ProjectDetailsId"].Value + @"'",_objectFactory.GetGridRPP("Budgetdetails"));

base.WriteDebugInfo(@"var querySourceA30F7872734E4D34AFDDD8F49130791A =GetQueryExpressionDataSource(""A30F7872-734E-4D34-AFDD-D8F49130791A"");DataTable resultA30F7872734E4D34AFDDD8F49130791A=iSpace.SetGridDataSource(querySourceA30F7872734E4D34AFDDD8F49130791A, _objectFactory.GetGridRPP(""Budgetdetails""),@""EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 1,'"" + ISpace[""F_BudgetHeadId""].Value + @""','',"" + ISpace[""MF_Budgetdetails_PageIndex""].Value + @"",'"" + ISpace[""MF_Budgetdetails_GridRows""].Value + @""','"" + ISpace[""F_ProjectDetailsId""].Value + @""'"");iSpace.InsertGridBindDetails(""Budgetdetails"",""11"",querySourceA30F7872734E4D34AFDDD8F49130791A,""EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 1,'"" + ISpace[""F_BudgetHeadId""].Value + @""','',"" + ISpace[""MF_Budgetdetails_PageIndex""].Value + @"",'"" + ISpace[""MF_Budgetdetails_GridRows""].Value + @""','"" + ISpace[""F_ProjectDetailsId""].Value + @""'"",_objectFactory.GetGridRPP(""Budgetdetails""));");
base.WriteDebugInfo(@"EXEC dbo.[Get_8086b585-51b2-4d95-8869-cfae8b5f9f72_FilterData] 1,'#F_BudgetHeadId','',#MF_Budgetdetails_PageIndex,'#MF_Budgetdetails_GridRows'");


List<Triplet<string, short, short?>> result387A33C1D74545BDA9129E364AE2D589=acdataIspace585BA2B83E754DABB50B10D8320CE414.GetQueryExpressionBindings("387A33C1-D745-45BD-A912-9E364AE2D589");
iSpace.SetGridData(resultA30F7872734E4D34AFDDD8F49130791A,result387A33C1D74545BDA9129E364AE2D589,"Budgetdetails",ref ISpace);
iSpace.UpdateGridBindDetails("Budgetdetails",result387A33C1D74545BDA9129E364AE2D589);
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
ISpace["MF_ExpenseDetails_PageIndex"].Value=0;
base.WriteDebugInfo(@"ISpace[""MF_ExpenseDetails_PageIndex""].Value=0;");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySource94B9568E6AA646109AB971682A69C231 =GetQueryExpressionDataSource("94B9568E-6AA6-4610-9AB9-71682A69C231");

DataTable result94B9568E6AA646109AB971682A69C231=iSpace.SetGridDataSource(querySource94B9568E6AA646109AB971682A69C231, _objectFactory.GetGridRPP("ReceiptsView"),@"EXEC dbo.[Get_bd3abae8-b5a2-4b71-b3e2-e46732479592_FilterData] 1,'" + ISpace["F_ReceiptNo"].Value + @"',''," + ISpace["MF_ReceiptsView_PageIndex"].Value + @",'" + ISpace["MF_ReceiptsView_GridRows"].Value + @"','" + ISpace["F_ProjectDetailsID"].Value + @"'");

iSpace.InsertGridBindDetails("ReceiptsView","11",querySource94B9568E6AA646109AB971682A69C231,"EXEC dbo.[Get_bd3abae8-b5a2-4b71-b3e2-e46732479592_FilterData] 1,'" + ISpace["F_ReceiptNo"].Value + @"',''," + ISpace["MF_ReceiptsView_PageIndex"].Value + @",'" + ISpace["MF_ReceiptsView_GridRows"].Value + @"','" + ISpace["F_ProjectDetailsID"].Value + @"'",_objectFactory.GetGridRPP("ReceiptsView"));

base.WriteDebugInfo(@"var querySource94B9568E6AA646109AB971682A69C231 =GetQueryExpressionDataSource(""94B9568E-6AA6-4610-9AB9-71682A69C231"");DataTable result94B9568E6AA646109AB971682A69C231=iSpace.SetGridDataSource(querySource94B9568E6AA646109AB971682A69C231, _objectFactory.GetGridRPP(""ReceiptsView""),@""EXEC dbo.[Get_bd3abae8-b5a2-4b71-b3e2-e46732479592_FilterData] 1,'"" + ISpace[""F_ReceiptNo""].Value + @""','',"" + ISpace[""MF_ReceiptsView_PageIndex""].Value + @"",'"" + ISpace[""MF_ReceiptsView_GridRows""].Value + @""','"" + ISpace[""F_ProjectDetailsID""].Value + @""'"");iSpace.InsertGridBindDetails(""ReceiptsView"",""11"",querySource94B9568E6AA646109AB971682A69C231,""EXEC dbo.[Get_bd3abae8-b5a2-4b71-b3e2-e46732479592_FilterData] 1,'"" + ISpace[""F_ReceiptNo""].Value + @""','',"" + ISpace[""MF_ReceiptsView_PageIndex""].Value + @"",'"" + ISpace[""MF_ReceiptsView_GridRows""].Value + @""','"" + ISpace[""F_ProjectDetailsID""].Value + @""'"",_objectFactory.GetGridRPP(""ReceiptsView""));");
base.WriteDebugInfo(@"EXEC dbo.[Get_bd3abae8-b5a2-4b71-b3e2-e46732479592_FilterData] 1,'#F_ReceiptNo','',#MF_ReceiptsView_PageIndex,'#MF_ReceiptsView_GridRows'");


List<Triplet<string, short, short?>> result6C0E534F5B5649E8BDBDB1A399E4F9C5=acdataIspace585BA2B83E754DABB50B10D8320CE414.GetQueryExpressionBindings("6C0E534F-5B56-49E8-BDBD-B1A399E4F9C5");
iSpace.SetGridData(result94B9568E6AA646109AB971682A69C231,result6C0E534F5B5649E8BDBDB1A399E4F9C5,"ReceiptsView",ref ISpace);
iSpace.UpdateGridBindDetails("ReceiptsView",result6C0E534F5B5649E8BDBDB1A399E4F9C5);
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'#F_ProjectDetailsId','',#MF_ExpenseDetails_PageIndex,'#MF_ExpenseDetails_GridRows'");

var querySource108B5BFD045B42D7A031893FCF404252 =GetQueryExpressionDataSource("108B5BFD-045B-42D7-A031-893FCF404252");
Dictionary<short,object> result108B5BFD045B42D7A031893FCF404252=iSpace.ExecuteQuery(querySource108B5BFD045B42D7A031893FCF404252,@"EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'" + ISpace["F_ProjectDetailsId"].Value + @"',''," + ISpace["MF_ExpenseDetails_PageIndex"].Value + @",'" + ISpace["MF_ExpenseDetails_GridRows"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource108B5BFD045B42D7A031893FCF404252 =GetQueryExpressionDataSource(""108B5BFD-045B-42D7-A031-893FCF404252"");Dictionary<short,object> result108B5BFD045B42D7A031893FCF404252=iSpace.ExecuteQuery(querySource108B5BFD045B42D7A031893FCF404252,@""EXEC dbo.[Get_bcf70c54-b296-4c4d-a4de-084ee98f154f_FilterData] 0,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',"" + ISpace[""MF_ExpenseDetails_PageIndex""].Value + @"",'"" + ISpace[""MF_ExpenseDetails_GridRows""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result108B5BFD045B42D7A031893FCF404252!=null) && (result108B5BFD045B42D7A031893FCF404252.Count!=0))
{
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(0))
ISpace["MF_Budgetdetails_GridRows"].Value = result108B5BFD045B42D7A031893FCF404252[0];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(3))
ISpace["MF_Budgetdetails_TotalPages"].Value = result108B5BFD045B42D7A031893FCF404252[3];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(2))
ISpace["MF_Budgetdetails_PageIndex"].Value = result108B5BFD045B42D7A031893FCF404252[2];
if(result108B5BFD045B42D7A031893FCF404252.ContainsKey(1))
ISpace["MF_Budgetdetails_RecordsRange"].Value = result108B5BFD045B42D7A031893FCF404252[1];
}
else{
ISpace["MF_Budgetdetails_GridRows"].Value = null;ISpace["MF_Budgetdetails_TotalPages"].Value = null;ISpace["MF_Budgetdetails_PageIndex"].Value = null;ISpace["MF_Budgetdetails_RecordsRange"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==1)");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==ISpace["MF_ExpenseDetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==ISpace[""MF_ExpenseDetails_TotalPages""].Value)");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="false";ISpace["MF_Budgetdetails_LastButton"].Enbl="false";ISpace["MF_Budgetdetails_NextButton"].Enbl="false";ISpace["MF_Budgetdetails_FirstButton"].Enbl="false";ISpace["MF_Budgetdetails_PageIndex"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""false"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="false";ISpace["MF_Budgetdetails_LastButton"].Enbl="true";ISpace["MF_Budgetdetails_NextButton"].Enbl="true";ISpace["MF_Budgetdetails_FirstButton"].Enbl="false";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
}
else
{
base.WriteDebugInfo(@"else");
if(ISpace["MF_ExpenseDetails_PageIndex"].Value==ISpace["MF_ExpenseDetails_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ExpenseDetails_PageIndex""].Value==ISpace[""MF_ExpenseDetails_TotalPages""].Value)");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="true";ISpace["MF_Budgetdetails_LastButton"].Enbl="false";ISpace["MF_Budgetdetails_NextButton"].Enbl="false";ISpace["MF_Budgetdetails_FirstButton"].Enbl="true";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""false"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_Budgetdetails_PrevButton"].Enbl="true";ISpace["MF_Budgetdetails_LastButton"].Enbl="true";ISpace["MF_Budgetdetails_NextButton"].Enbl="true";ISpace["MF_Budgetdetails_FirstButton"].Enbl="true";ISpace["MF_Budgetdetails_PageIndex"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_Budgetdetails_PrevButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_LastButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_NextButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_FirstButton""].Enbl=""true"";ISpace[""MF_Budgetdetails_PageIndex""].Enbl=""true"";");
}
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
		if(elementName.ToLower().Equals("mf_expensedetails_gridrows"))
    {
    			SubscribeElementEvents_mf_expensedetails_gridrows(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mf_expensedetails_pageindex"))
    {
    			SubscribeElementEvents_mf_expensedetails_pageindex(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mf_projectcommitments_pageindex"))
    {
    			SubscribeElementEvents_mf_projectcommitments_pageindex(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mf_budgetdetails_gridrows"))
    {
    			SubscribeElementEvents_mf_budgetdetails_gridrows(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mf_receiptsview_gridrows"))
    {
    			SubscribeElementEvents_mf_receiptsview_gridrows(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mf_receiptsview_pageindex"))
    {
    			SubscribeElementEvents_mf_receiptsview_pageindex(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mf_projectcommitments_gridrows"))
    {
    			SubscribeElementEvents_mf_projectcommitments_gridrows(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mf_budgetdetails_pageindex"))
    {
    			SubscribeElementEvents_mf_budgetdetails_pageindex(ref dfsParam);
    }
}
	if(methodName.ToLower().Equals("onclick"))
{
		if(elementName.ToLower().Equals("mf_projectcommitments_nextbutton"))
{
			SubscribeElementEvents_mf_projectcommitments_nextbutton(ref dfsParam);
}
		if(elementName.ToLower().Equals("mf_projectcommitments_firstbutton"))
{
			SubscribeElementEvents_mf_projectcommitments_firstbutton(ref dfsParam);
}
		if(elementName.ToLower().Equals("mf_receiptsview_prevbutton"))
{
			SubscribeElementEvents_mf_receiptsview_prevbutton(ref dfsParam);
}
		if(elementName.ToLower().Equals("mf_expensedetails_prevbutton"))
{
			SubscribeElementEvents_mf_expensedetails_prevbutton(ref dfsParam);
}
		if(elementName.ToLower().Equals("mf_expensedetails_firstbutton"))
{
			SubscribeElementEvents_mf_expensedetails_firstbutton(ref dfsParam);
}
		if(elementName.ToLower().Equals("mf_receiptsview_firstbutton"))
{
			SubscribeElementEvents_mf_receiptsview_firstbutton(ref dfsParam);
}
		if(elementName.ToLower().Equals("mf_budgetdetails_prevbutton"))
{
			SubscribeElementEvents_mf_budgetdetails_prevbutton(ref dfsParam);
}
		if(elementName.ToLower().Equals("mf_projectcommitments_prevbutton"))
{
			SubscribeElementEvents_mf_projectcommitments_prevbutton(ref dfsParam);
}
		if(elementName.ToLower().Equals("mf_expensedetails_lastbutton"))
{
			SubscribeElementEvents_mf_expensedetails_lastbutton(ref dfsParam);
}
		if(elementName.ToLower().Equals("add"))
{
			SubscribeElementEvents_add(ref dfsParam);
}
		if(elementName.ToLower().Equals("mf_receiptsview_nextbutton"))
{
			SubscribeElementEvents_mf_receiptsview_nextbutton(ref dfsParam);
}
		if(elementName.ToLower().Equals("mf_budgetdetails_lastbutton"))
{
			SubscribeElementEvents_mf_budgetdetails_lastbutton(ref dfsParam);
}
		if(elementName.ToLower().Equals("apply"))
{
			SubscribeElementEvents_apply(ref dfsParam);
}
		if(elementName.ToLower().Equals("mf_projectcommitments_lastbutton"))
{
			SubscribeElementEvents_mf_projectcommitments_lastbutton(ref dfsParam);
}
		if(elementName.ToLower().Equals("mf_budgetdetails_nextbutton"))
{
			SubscribeElementEvents_mf_budgetdetails_nextbutton(ref dfsParam);
}
		if(elementName.ToLower().Equals("mf_expensedetails_nextbutton"))
{
			SubscribeElementEvents_mf_expensedetails_nextbutton(ref dfsParam);
}
		if(elementName.ToLower().Equals("edit"))
{
			SubscribeElementEvents_edit(ref dfsParam);
}
		if(elementName.ToLower().Equals("cancel"))
{
			SubscribeElementEvents_cancel(ref dfsParam);
}
		if(elementName.ToLower().Equals("mf_budgetdetails_firstbutton"))
{
			SubscribeElementEvents_mf_budgetdetails_firstbutton(ref dfsParam);
}
		if(elementName.ToLower().Equals("save"))
{
			SubscribeElementEvents_save(ref dfsParam);
}
		if(elementName.ToLower().Equals("mf_receiptsview_lastbutton"))
{
			SubscribeElementEvents_mf_receiptsview_lastbutton(ref dfsParam);
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
							{"387A33C1-D745-45BD-A912-9E364AE2D589", 
				
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
							{"6C0E534F-5B56-49E8-BDBD-B1A399E4F9C5", 
				
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
							{"F156A861-1F4D-43F2-884E-90DD3F9E66E3", 
				
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
							{"F24D6115-0F99-4667-9299-168E58B151A1", 
				
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
		


