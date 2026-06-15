  







namespace CPS.Proof.DFSExtension
{
	using System;
    using System.Collections.Generic;     
	using System.Linq;
	
	
	public partial class ProjectsExplorerProcessMetadata : ExtensionProcessBase
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
            get { return "B219A0EA-0254-4F69-B989-B681DD475183"; }
        }

        public override string ProcessName
        {
            get { return "ProjectsExplorer"; }
        }

		public override string ProcessDescription
        {
            get { return "Projects Explorer old Smart UI"; }
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
            get {return "B219A0EA-0254-4F69-B989-B681DD475183";}
        }

		public override byte ProcessInstanceMode
        {
            get {return 3;}
        }		

		public override string MasterFormId
        {
            get {  
				   return "7816392B-A9EF-486D-88F9-AC7C972D679B";	}
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
	

	public partial class ProjectsExplorerObjectFactory  : ExtObjectFactoryBase
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
        //    return (IExtBaseMetaData)new ProjectsExplorerProcessMetadata();
        //}
	


		private List<Triplet<string, string, string>> queryExpressionData = new List<Triplet<string, string, string>>
		{
	  			
			     new Triplet<string, string, string>("B83852E3-6E4B-4A3A-8E3F-2F8AA8E3419F","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"062C4298-5FB2-4C83-877D-A1D5795686CF"),
			
						
			     new Triplet<string, string, string>("DE7234F0-9899-46C5-8758-427FAF6AEB5A","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("BA80C2CD-020D-491F-8055-BD63F5ADE3A5","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("4A8693DC-3F25-4BCE-9F85-A49D2A429EE1","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"062C4298-5FB2-4C83-877D-A1D5795686CF"),
			
						
			     new Triplet<string, string, string>("DE7234F0-9899-46C5-8758-427FAF6AEB5A","Grid Binding",
												     @"BDF7896C-4676-4008-BC64-2C45896293B5"),
			
			
			
		};

		
		private List<Triplet<string, string, string>> ComboDataSource = new List<Triplet<string, string, string>>
		{

		
	  			
			     new Triplet<string, string, string>("MF_ProjectListActiveProjectspr_GridRows","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMAvOzkFMmxHUuxhHgktDkfvWfwBNgoOezuIQDeIjZtCKIIrSN+GjapRg==",
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
		
	  			
			     new Tuple<string, int>("ProjectListActiveProjectspr",1000),
			
						
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
											case "34CF8FAF-7574-478F-9C4A-A65F98E4D18A":
							virtualInstance=new ISpace34CF8FAF7574478F9C4AA65F98E4D18A();
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
	

	public partial class ProjectsExplorerDataElementFactory  : ExtElementBase
    {

     /// <summary>
        /// A <see cref="log4net.ILog"/> that contains the logger instance for 
        /// logging
        /// </summary>
        private readonly ILog _sysLog;

        public ProjectsExplorerDataElementFactory()
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

               
                
                                      case "7816392B-A9EF-486D-88F9-AC7C972D679B":
                    {
                     
                                     fInsertQuery=@"IF NOT EXISTS(SELECT 1 FROM [7816392B-A9EF-486D-88F9-AC7C972D679B] WHERE InstanceId='{0}' AND
							 FormId='{2}') BEGIN INSERT INTO [7816392B-A9EF-486D-88F9-AC7C972D679B](InstanceId,ProcessActivityMapId,MF_V1_SanctionedValue,F_ProjectDetailsId,MF_ActiveCount,MF_ProposalCount,MF_CompletedCount,MF_SanctionedCount,MF_ActiveAmount,MF_ProjectListActiveProjectspr_PageIndex,MF_ProjectListActiveProjectspr_TotalPages,MF_V1_ProjectDetailsID,MF_V1_ProjectTitle,MF_V1_ProjectNo,MF_V1_Department,MF_V1_PI,MF_V1_CoPI,MF_V1_ProjectType,MF_V1_Agency,MF_V1_StartDate,MF_V1_EndDate,MF_V1_Duration,MF_V1_FinancialYear,MF_Option,Subject,ExecutionStatus,ExecutionMessage,SetDestinationTo,SLATime,MF_ProjectListActiveProjectspr_GridRows,MF_ProjectListActiveProjectspr_RecordsRange,MF_CompletedAmount,MF_ProposalAmount,MF_SanctionedAmount,RedirectUrl,MF_URL,FormId,MF_ProposalPendingCount,MF_ProposalPendingAmount,MF_ProjectPendingCount,MF_ProjectPendingAmount)
							VALUES( {3}) END ELSE BEGIN UPDATE [7816392B-A9EF-486D-88F9-AC7C972D679B]SET {4}WHERE InstanceId='{0}'END ";

                                     colList=@"InstanceId,ProcessActivityMapId,MF_V1_SanctionedValue,F_ProjectDetailsId,MF_ActiveCount,MF_ProposalCount,MF_CompletedCount,MF_SanctionedCount,MF_ActiveAmount,MF_ProjectListActiveProjectspr_PageIndex,MF_ProjectListActiveProjectspr_TotalPages,MF_V1_ProjectDetailsID,MF_V1_ProjectTitle,MF_V1_ProjectNo,MF_V1_Department,MF_V1_PI,MF_V1_CoPI,MF_V1_ProjectType,MF_V1_Agency,MF_V1_StartDate,MF_V1_EndDate,MF_V1_Duration,MF_V1_FinancialYear,MF_Option,Subject,ExecutionStatus,ExecutionMessage,SetDestinationTo,SLATime,MF_ProjectListActiveProjectspr_GridRows,MF_ProjectListActiveProjectspr_RecordsRange,MF_CompletedAmount,MF_ProposalAmount,MF_SanctionedAmount,RedirectUrl,MF_URL,FormId,MF_ProposalPendingCount,MF_ProposalPendingAmount,MF_ProjectPendingCount,MF_ProjectPendingAmount";
                                    
                     
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

                
                 
                                      case "BDF7896C-4676-4008-BC64-2C45896293B5":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_BDF7896C46764008BC642C45896293B5 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MGG_V1_ProjectDetailsID] VARCHAR(MAX)	, [MGG_V1_ProjectNo] VARCHAR(MAX)	, [MGG_V1_Department] VARCHAR(MAX)	, [MGG_V1_PI] VARCHAR(MAX)	, [MGG_V1_CoPI] VARCHAR(MAX)	, [MGG_V1_ProjectType] VARCHAR(MAX)	, [MGG_V1_Agency] VARCHAR(MAX)	, [MGG_V1_StartDate] DATETIME	, [MGG_V1_EndDate] DATETIME	, [MGG_V1_Duration] VARCHAR(MAX)	, [MGG_V1_FinancialYear] VARCHAR(MAX)	, [MGG_V1_SanctionedValue] DECIMAL(18,2)	, [MGG_V1_Type] VARCHAR(MAX)){0}INSERT INTO [BDF7896C-4676-4008-BC64-2C45896293B5](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MGG_V1_ProjectDetailsID,MGG_V1_ProjectNo,MGG_V1_Department,MGG_V1_PI,MGG_V1_CoPI,MGG_V1_ProjectType,MGG_V1_Agency,MGG_V1_StartDate,MGG_V1_EndDate,MGG_V1_Duration,MGG_V1_FinancialYear,MGG_V1_SanctionedValue,MGG_V1_Type)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MGG_V1_ProjectDetailsID,TDT.MGG_V1_ProjectNo,TDT.MGG_V1_Department,TDT.MGG_V1_PI,TDT.MGG_V1_CoPI,TDT.MGG_V1_ProjectType,TDT.MGG_V1_Agency,TDT.MGG_V1_StartDate,TDT.MGG_V1_EndDate,TDT.MGG_V1_Duration,TDT.MGG_V1_FinancialYear,TDT.MGG_V1_SanctionedValue,TDT.MGG_V1_Type FROM @TBL_BDF7896C46764008BC642C45896293B5 TDT
							LEFT JOIN [BDF7896C-4676-4008-BC64-2C45896293B5] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MGG_V1_ProjectDetailsID=TDT.MGG_V1_ProjectDetailsID,MGG_V1_ProjectNo=TDT.MGG_V1_ProjectNo,MGG_V1_Department=TDT.MGG_V1_Department,MGG_V1_PI=TDT.MGG_V1_PI,MGG_V1_CoPI=TDT.MGG_V1_CoPI,MGG_V1_ProjectType=TDT.MGG_V1_ProjectType,MGG_V1_Agency=TDT.MGG_V1_Agency,MGG_V1_StartDate=TDT.MGG_V1_StartDate,MGG_V1_EndDate=TDT.MGG_V1_EndDate,MGG_V1_Duration=TDT.MGG_V1_Duration,MGG_V1_FinancialYear=TDT.MGG_V1_FinancialYear,MGG_V1_SanctionedValue=TDT.MGG_V1_SanctionedValue,MGG_V1_Type=TDT.MGG_V1_Type FROM @TBL_BDF7896C46764008BC642C45896293B5 TDT
							JOIN [BDF7896C-4676-4008-BC64-2C45896293B5] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MGG_V1_ProjectDetailsID,MGG_V1_ProjectNo,MGG_V1_Department,MGG_V1_PI,MGG_V1_CoPI,MGG_V1_ProjectType,MGG_V1_Agency,MGG_V1_StartDate,MGG_V1_EndDate,MGG_V1_Duration,MGG_V1_FinancialYear,MGG_V1_SanctionedValue,MGG_V1_Type";

                                     tempInsertQuery=@"INSERT INTO @TBL_BDF7896C46764008BC642C45896293B5(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MGG_V1_ProjectDetailsID,MGG_V1_ProjectNo,MGG_V1_Department,MGG_V1_PI,MGG_V1_CoPI,MGG_V1_ProjectType,MGG_V1_Agency,MGG_V1_StartDate,MGG_V1_EndDate,MGG_V1_Duration,MGG_V1_FinancialYear,MGG_V1_SanctionedValue,MGG_V1_Type)VALUES({0});";
                                     

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
                     

                                         case "BDF7896C-4676-4008-BC64-2C45896293B5":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_BDF7896C46764008BC642C45896293B5 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MGG_V1_ProjectDetailsID] VARCHAR(MAX)	, [MGG_V1_ProjectNo] VARCHAR(MAX)	, [MGG_V1_Department] VARCHAR(MAX)	, [MGG_V1_PI] VARCHAR(MAX)	, [MGG_V1_CoPI] VARCHAR(MAX)	, [MGG_V1_ProjectType] VARCHAR(MAX)	, [MGG_V1_Agency] VARCHAR(MAX)	, [MGG_V1_StartDate] DATETIME	, [MGG_V1_EndDate] DATETIME	, [MGG_V1_Duration] VARCHAR(MAX)	, [MGG_V1_FinancialYear] VARCHAR(MAX)	, [MGG_V1_SanctionedValue] DECIMAL(18,2)	, [MGG_V1_Type] VARCHAR(MAX)){0}INSERT INTO [BDF7896C-4676-4008-BC64-2C45896293B5](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MGG_V1_ProjectDetailsID,MGG_V1_ProjectNo,MGG_V1_Department,MGG_V1_PI,MGG_V1_CoPI,MGG_V1_ProjectType,MGG_V1_Agency,MGG_V1_StartDate,MGG_V1_EndDate,MGG_V1_Duration,MGG_V1_FinancialYear,MGG_V1_SanctionedValue,MGG_V1_Type)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MGG_V1_ProjectDetailsID,TDT.MGG_V1_ProjectNo,TDT.MGG_V1_Department,TDT.MGG_V1_PI,TDT.MGG_V1_CoPI,TDT.MGG_V1_ProjectType,TDT.MGG_V1_Agency,TDT.MGG_V1_StartDate,TDT.MGG_V1_EndDate,TDT.MGG_V1_Duration,TDT.MGG_V1_FinancialYear,TDT.MGG_V1_SanctionedValue,TDT.MGG_V1_Type FROM @TBL_BDF7896C46764008BC642C45896293B5 TDT
							LEFT JOIN [BDF7896C-4676-4008-BC64-2C45896293B5] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MGG_V1_ProjectDetailsID=TDT.MGG_V1_ProjectDetailsID,MGG_V1_ProjectNo=TDT.MGG_V1_ProjectNo,MGG_V1_Department=TDT.MGG_V1_Department,MGG_V1_PI=TDT.MGG_V1_PI,MGG_V1_CoPI=TDT.MGG_V1_CoPI,MGG_V1_ProjectType=TDT.MGG_V1_ProjectType,MGG_V1_Agency=TDT.MGG_V1_Agency,MGG_V1_StartDate=TDT.MGG_V1_StartDate,MGG_V1_EndDate=TDT.MGG_V1_EndDate,MGG_V1_Duration=TDT.MGG_V1_Duration,MGG_V1_FinancialYear=TDT.MGG_V1_FinancialYear,MGG_V1_SanctionedValue=TDT.MGG_V1_SanctionedValue,MGG_V1_Type=TDT.MGG_V1_Type FROM @TBL_BDF7896C46764008BC642C45896293B5 TDT
							JOIN [BDF7896C-4676-4008-BC64-2C45896293B5] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MGG_V1_ProjectDetailsID,MGG_V1_ProjectNo,MGG_V1_Department,MGG_V1_PI,MGG_V1_CoPI,MGG_V1_ProjectType,MGG_V1_Agency,MGG_V1_StartDate,MGG_V1_EndDate,MGG_V1_Duration,MGG_V1_FinancialYear,MGG_V1_SanctionedValue,MGG_V1_Type";

                            tempInsertQuery=@"INSERT INTO @TBL_BDF7896C46764008BC642C45896293B5(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MGG_V1_ProjectDetailsID,MGG_V1_ProjectNo,MGG_V1_Department,MGG_V1_PI,MGG_V1_CoPI,MGG_V1_ProjectType,MGG_V1_Agency,MGG_V1_StartDate,MGG_V1_EndDate,MGG_V1_Duration,MGG_V1_FinancialYear,MGG_V1_SanctionedValue,MGG_V1_Type)VALUES({0});";

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
public class ISpace34CF8FAF7574478F9C4AA65F98E4D18A : VirtualForm
{
IISpace iSpace = new ISpace();
AcDataISpace34CF8FAF7574478F9C4AA65F98E4D18A acdataIspace34CF8FAF7574478F9C4AA65F98E4D18A=new AcDataISpace34CF8FAF7574478F9C4AA65F98E4D18A();
private void SubscribeFormEvents_root(ref Dictionary<string, ServiceElementData> ISpace)
{
try
{
base.WriteDebugInfo(@"Root-OnAfterFormLoad");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySourceDE7234F0989946C58758427FAF6AEB5A =GetQueryExpressionDataSource("DE7234F0-9899-46C5-8758-427FAF6AEB5A");

DataTable resultDE7234F0989946C58758427FAF6AEB5A=iSpace.SetGridDataSource(querySourceDE7234F0989946C58758427FAF6AEB5A, _objectFactory.GetGridRPP("ProjectListActiveProjectspr"),@"EXEC dbo.[GetProjectExplorerDetails] 1,'" + ISpace["F_ProjectDetailsId"].Value + @"',''," + ISpace["MF_ProjectListActiveProjectspr_PageIndex"].Value + @",'" + ISpace["MF_ProjectListActiveProjectspr_GridRows"].Value + @"','" + ISpace["gv_username"].Value + @"'");

iSpace.InsertGridBindDetails("ProjectListActiveProjectspr","11",querySourceDE7234F0989946C58758427FAF6AEB5A,"EXEC dbo.[GetProjectExplorerDetails] 1,'" + ISpace["F_ProjectDetailsId"].Value + @"',''," + ISpace["MF_ProjectListActiveProjectspr_PageIndex"].Value + @",'" + ISpace["MF_ProjectListActiveProjectspr_GridRows"].Value + @"','" + ISpace["gv_username"].Value + @"'",_objectFactory.GetGridRPP("ProjectListActiveProjectspr"));

base.WriteDebugInfo(@"var querySourceDE7234F0989946C58758427FAF6AEB5A =GetQueryExpressionDataSource(""DE7234F0-9899-46C5-8758-427FAF6AEB5A"");DataTable resultDE7234F0989946C58758427FAF6AEB5A=iSpace.SetGridDataSource(querySourceDE7234F0989946C58758427FAF6AEB5A, _objectFactory.GetGridRPP(""ProjectListActiveProjectspr""),@""EXEC dbo.[GetProjectExplorerDetails] 1,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',"" + ISpace[""MF_ProjectListActiveProjectspr_PageIndex""].Value + @"",'"" + ISpace[""MF_ProjectListActiveProjectspr_GridRows""].Value + @""','"" + ISpace[""gv_username""].Value + @""'"");iSpace.InsertGridBindDetails(""ProjectListActiveProjectspr"",""11"",querySourceDE7234F0989946C58758427FAF6AEB5A,""EXEC dbo.[GetProjectExplorerDetails] 1,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',"" + ISpace[""MF_ProjectListActiveProjectspr_PageIndex""].Value + @"",'"" + ISpace[""MF_ProjectListActiveProjectspr_GridRows""].Value + @""','"" + ISpace[""gv_username""].Value + @""'"",_objectFactory.GetGridRPP(""ProjectListActiveProjectspr""));");
base.WriteDebugInfo(@"EXEC dbo.[Get_bccb6bb6-39f0-4863-8a17-2efdffe2a45b_FilterData] 1,'#F_ProjectDetailsId','',#MF_ProjectListActiveProjectspr_PageIndex,'#MF_ProjectListActiveProjectspr_GridRows'");


List<Triplet<string, short, short?>> result28E58773E71A46B18591A5E00111B3CB=acdataIspace34CF8FAF7574478F9C4AA65F98E4D18A.GetQueryExpressionBindings("28E58773-E71A-46B1-8591-A5E00111B3CB");
iSpace.SetGridData(resultDE7234F0989946C58758427FAF6AEB5A,result28E58773E71A46B18591A5E00111B3CB,"ProjectListActiveProjectspr",ref ISpace);
iSpace.UpdateGridBindDetails("ProjectListActiveProjectspr",result28E58773E71A46B18591A5E00111B3CB);
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"Exec GetProjectStatistics '@@gv_UserName'");

var querySourceBA80C2CD020D491F8055BD63F5ADE3A5 =GetQueryExpressionDataSource("BA80C2CD-020D-491F-8055-BD63F5ADE3A5");
Dictionary<short,object> resultBA80C2CD020D491F8055BD63F5ADE3A5=iSpace.ExecuteQuery(querySourceBA80C2CD020D491F8055BD63F5ADE3A5,@"Exec GetProjectStatistics '" + ISpace["gv_username"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceBA80C2CD020D491F8055BD63F5ADE3A5 =GetQueryExpressionDataSource(""BA80C2CD-020D-491F-8055-BD63F5ADE3A5"");Dictionary<short,object> resultBA80C2CD020D491F8055BD63F5ADE3A5=iSpace.ExecuteQuery(querySourceBA80C2CD020D491F8055BD63F5ADE3A5,@""Exec GetProjectStatistics '"" + ISpace[""gv_username""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultBA80C2CD020D491F8055BD63F5ADE3A5!=null) && (resultBA80C2CD020D491F8055BD63F5ADE3A5.Count!=0))
{
if(resultBA80C2CD020D491F8055BD63F5ADE3A5.ContainsKey(11))
ISpace["MF_SanctionedAmount"].Value = resultBA80C2CD020D491F8055BD63F5ADE3A5[11];
if(resultBA80C2CD020D491F8055BD63F5ADE3A5.ContainsKey(5))
ISpace["MF_ProjectPendingAmount"].Value = resultBA80C2CD020D491F8055BD63F5ADE3A5[5];
if(resultBA80C2CD020D491F8055BD63F5ADE3A5.ContainsKey(10))
ISpace["MF_SanctionedCount"].Value = resultBA80C2CD020D491F8055BD63F5ADE3A5[10];
if(resultBA80C2CD020D491F8055BD63F5ADE3A5.ContainsKey(7))
ISpace["MF_ProposalAmount"].Value = resultBA80C2CD020D491F8055BD63F5ADE3A5[7];
if(resultBA80C2CD020D491F8055BD63F5ADE3A5.ContainsKey(0))
ISpace["MF_ActiveCount"].Value = resultBA80C2CD020D491F8055BD63F5ADE3A5[0];
if(resultBA80C2CD020D491F8055BD63F5ADE3A5.ContainsKey(3))
ISpace["MF_CompletedAmount"].Value = resultBA80C2CD020D491F8055BD63F5ADE3A5[3];
if(resultBA80C2CD020D491F8055BD63F5ADE3A5.ContainsKey(9))
ISpace["MF_ProposalPendingAmount"].Value = resultBA80C2CD020D491F8055BD63F5ADE3A5[9];
if(resultBA80C2CD020D491F8055BD63F5ADE3A5.ContainsKey(8))
ISpace["MF_ProposalPendingCount"].Value = resultBA80C2CD020D491F8055BD63F5ADE3A5[8];
if(resultBA80C2CD020D491F8055BD63F5ADE3A5.ContainsKey(1))
ISpace["MF_ActiveAmount"].Value = resultBA80C2CD020D491F8055BD63F5ADE3A5[1];
if(resultBA80C2CD020D491F8055BD63F5ADE3A5.ContainsKey(4))
ISpace["MF_ProjectPendingCount"].Value = resultBA80C2CD020D491F8055BD63F5ADE3A5[4];
if(resultBA80C2CD020D491F8055BD63F5ADE3A5.ContainsKey(2))
ISpace["MF_CompletedCount"].Value = resultBA80C2CD020D491F8055BD63F5ADE3A5[2];
if(resultBA80C2CD020D491F8055BD63F5ADE3A5.ContainsKey(6))
ISpace["MF_ProposalCount"].Value = resultBA80C2CD020D491F8055BD63F5ADE3A5[6];
}
else{
ISpace["MF_SanctionedAmount"].Value = null;ISpace["MF_ProjectPendingAmount"].Value = null;ISpace["MF_SanctionedCount"].Value = null;ISpace["MF_ProposalAmount"].Value = null;ISpace["MF_ActiveCount"].Value = null;ISpace["MF_CompletedAmount"].Value = null;ISpace["MF_ProposalPendingAmount"].Value = null;ISpace["MF_ProposalPendingCount"].Value = null;ISpace["MF_ActiveAmount"].Value = null;ISpace["MF_ProjectPendingCount"].Value = null;ISpace["MF_CompletedCount"].Value = null;ISpace["MF_ProposalCount"].Value = null;
}
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

ISpace["MF_V1_ProjectDetailsID"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_V1_ProjectDetailsID""].Value=null;");
ISpace["MF_V1_ProjectTitle"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_V1_ProjectTitle""].Value=null;");
ISpace["MF_V1_ProjectNo"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_V1_ProjectNo""].Value=null;");
ISpace["MF_V1_Department"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_V1_Department""].Value=null;");
ISpace["MF_V1_PI"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_V1_PI""].Value=null;");
ISpace["MF_V1_CoPI"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_V1_CoPI""].Value=null;");
ISpace["MF_V1_ProjectType"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_V1_ProjectType""].Value=null;");
ISpace["MF_V1_Agency"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_V1_Agency""].Value=null;");
ISpace["MF_V1_StartDate"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_V1_StartDate""].Value=null;");
ISpace["MF_V1_EndDate"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_V1_EndDate""].Value=null;");
ISpace["MF_V1_Duration"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_V1_Duration""].Value=null;");
ISpace["MF_V1_FinancialYear"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_V1_FinancialYear""].Value=null;");
ISpace["MF_V1_SanctionedValue"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_V1_SanctionedValue""].Value=null;");
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mf_projectlistactiveprojectspr_pageindex (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MF_ProjectListActiveProjectspr_PageIndex-OnChange");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySourceDE7234F0989946C58758427FAF6AEB5A =GetQueryExpressionDataSource("DE7234F0-9899-46C5-8758-427FAF6AEB5A");

DataTable resultDE7234F0989946C58758427FAF6AEB5A=iSpace.SetGridDataSource(querySourceDE7234F0989946C58758427FAF6AEB5A, _objectFactory.GetGridRPP("ProjectListActiveProjectspr"),@"EXEC dbo.[GetProjectExplorerDetails] 1,'" + ISpace["F_ProjectDetailsId"].Value + @"',''," + ISpace["MF_ProjectListActiveProjectspr_PageIndex"].Value + @",'" + ISpace["MF_ProjectListActiveProjectspr_GridRows"].Value + @"','" + ISpace["gv_username"].Value + @"'");

iSpace.InsertGridBindDetails("ProjectListActiveProjectspr","11",querySourceDE7234F0989946C58758427FAF6AEB5A,"EXEC dbo.[GetProjectExplorerDetails] 1,'" + ISpace["F_ProjectDetailsId"].Value + @"',''," + ISpace["MF_ProjectListActiveProjectspr_PageIndex"].Value + @",'" + ISpace["MF_ProjectListActiveProjectspr_GridRows"].Value + @"','" + ISpace["gv_username"].Value + @"'",_objectFactory.GetGridRPP("ProjectListActiveProjectspr"));

base.WriteDebugInfo(@"var querySourceDE7234F0989946C58758427FAF6AEB5A =GetQueryExpressionDataSource(""DE7234F0-9899-46C5-8758-427FAF6AEB5A"");DataTable resultDE7234F0989946C58758427FAF6AEB5A=iSpace.SetGridDataSource(querySourceDE7234F0989946C58758427FAF6AEB5A, _objectFactory.GetGridRPP(""ProjectListActiveProjectspr""),@""EXEC dbo.[GetProjectExplorerDetails] 1,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',"" + ISpace[""MF_ProjectListActiveProjectspr_PageIndex""].Value + @"",'"" + ISpace[""MF_ProjectListActiveProjectspr_GridRows""].Value + @""','"" + ISpace[""gv_username""].Value + @""'"");iSpace.InsertGridBindDetails(""ProjectListActiveProjectspr"",""11"",querySourceDE7234F0989946C58758427FAF6AEB5A,""EXEC dbo.[GetProjectExplorerDetails] 1,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',"" + ISpace[""MF_ProjectListActiveProjectspr_PageIndex""].Value + @"",'"" + ISpace[""MF_ProjectListActiveProjectspr_GridRows""].Value + @""','"" + ISpace[""gv_username""].Value + @""'"",_objectFactory.GetGridRPP(""ProjectListActiveProjectspr""));");
base.WriteDebugInfo(@"EXEC dbo.[Get_bccb6bb6-39f0-4863-8a17-2efdffe2a45b_FilterData] 1,'#F_ProjectDetailsId','',#MF_ProjectListActiveProjectspr_PageIndex,'#MF_ProjectListActiveProjectspr_GridRows'");


List<Triplet<string, short, short?>> result28E58773E71A46B18591A5E00111B3CB=acdataIspace34CF8FAF7574478F9C4AA65F98E4D18A.GetQueryExpressionBindings("28E58773-E71A-46B1-8591-A5E00111B3CB");
iSpace.SetGridData(resultDE7234F0989946C58758427FAF6AEB5A,result28E58773E71A46B18591A5E00111B3CB,"ProjectListActiveProjectspr",ref ISpace);
iSpace.UpdateGridBindDetails("ProjectListActiveProjectspr",result28E58773E71A46B18591A5E00111B3CB);
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mf_asset (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MF_Asset-OnClick");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

ISpace["RedirectUrl"].RedirectType="R";
ISpace["RedirectUrl"].Value="?PkActMId=6B5E748F-516A-4136-8016-3464FB30137D&frmElementId=97FE9653-E760-4DDE-B22E-5247CBB725F3&PkPrMId=B0EDBC7F-E6F9-4F68-92D1-C2D70DA0933A&formVersionId=770944B9-E280-449C-AE7E-B27EB1909CF1&Ver=0.0000";
base.WriteDebugInfo(@"
ISpace[""RedirectUrl""].RedirectType=""R"";
ISpace[""RedirectUrl""].Value=""?PkActMId=6B5E748F-516A-4136-8016-3464FB30137D&frmElementId=97FE9653-E760-4DDE-B22E-5247CBB725F3&PkPrMId=B0EDBC7F-E6F9-4F68-92D1-C2D70DA0933A&formVersionId=770944B9-E280-449C-AE7E-B27EB1909CF1&Ver=0.0000"";");
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_m_createproposal (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"M_CreateProposal-OnClick");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

ISpace["RedirectUrl"].RedirectType="R";
ISpace["RedirectUrl"].Value="?PkActMId=B3A49337-4C4B-42EC-9F9B-1C4C8B4E2E13&frmElementId=E0AC6667-6D92-49AA-8F4D-01F473F2E426&PkPrMId=026e321e-9bb7-4c74-8615-3bbd7cc1b241&formVersionId=FA963D46-2D52-4A3E-8550-E878A2504252&Ver=0.0000";
base.WriteDebugInfo(@"
ISpace[""RedirectUrl""].RedirectType=""R"";
ISpace[""RedirectUrl""].Value=""?PkActMId=B3A49337-4C4B-42EC-9F9B-1C4C8B4E2E13&frmElementId=E0AC6667-6D92-49AA-8F4D-01F473F2E426&PkPrMId=026e321e-9bb7-4c74-8615-3bbd7cc1b241&formVersionId=FA963D46-2D52-4A3E-8550-E878A2504252&Ver=0.0000"";");
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mf_projectlistactiveprojectspr_gridrows (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MF_ProjectListActiveProjectspr_GridRows-OnChange");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySourceDE7234F0989946C58758427FAF6AEB5A =GetQueryExpressionDataSource("DE7234F0-9899-46C5-8758-427FAF6AEB5A");

DataTable resultDE7234F0989946C58758427FAF6AEB5A=iSpace.SetGridDataSource(querySourceDE7234F0989946C58758427FAF6AEB5A, _objectFactory.GetGridRPP("ProjectListActiveProjectspr"),@"EXEC dbo.[GetProjectExplorerDetails] 1,'" + ISpace["F_ProjectDetailsId"].Value + @"',''," + ISpace["MF_ProjectListActiveProjectspr_PageIndex"].Value + @",'" + ISpace["MF_ProjectListActiveProjectspr_GridRows"].Value + @"','" + ISpace["gv_username"].Value + @"'");

iSpace.InsertGridBindDetails("ProjectListActiveProjectspr","11",querySourceDE7234F0989946C58758427FAF6AEB5A,"EXEC dbo.[GetProjectExplorerDetails] 1,'" + ISpace["F_ProjectDetailsId"].Value + @"',''," + ISpace["MF_ProjectListActiveProjectspr_PageIndex"].Value + @",'" + ISpace["MF_ProjectListActiveProjectspr_GridRows"].Value + @"','" + ISpace["gv_username"].Value + @"'",_objectFactory.GetGridRPP("ProjectListActiveProjectspr"));

base.WriteDebugInfo(@"var querySourceDE7234F0989946C58758427FAF6AEB5A =GetQueryExpressionDataSource(""DE7234F0-9899-46C5-8758-427FAF6AEB5A"");DataTable resultDE7234F0989946C58758427FAF6AEB5A=iSpace.SetGridDataSource(querySourceDE7234F0989946C58758427FAF6AEB5A, _objectFactory.GetGridRPP(""ProjectListActiveProjectspr""),@""EXEC dbo.[GetProjectExplorerDetails] 1,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',"" + ISpace[""MF_ProjectListActiveProjectspr_PageIndex""].Value + @"",'"" + ISpace[""MF_ProjectListActiveProjectspr_GridRows""].Value + @""','"" + ISpace[""gv_username""].Value + @""'"");iSpace.InsertGridBindDetails(""ProjectListActiveProjectspr"",""11"",querySourceDE7234F0989946C58758427FAF6AEB5A,""EXEC dbo.[GetProjectExplorerDetails] 1,'"" + ISpace[""F_ProjectDetailsId""].Value + @""','',"" + ISpace[""MF_ProjectListActiveProjectspr_PageIndex""].Value + @"",'"" + ISpace[""MF_ProjectListActiveProjectspr_GridRows""].Value + @""','"" + ISpace[""gv_username""].Value + @""'"",_objectFactory.GetGridRPP(""ProjectListActiveProjectspr""));");
base.WriteDebugInfo(@"EXEC dbo.[Get_bccb6bb6-39f0-4863-8a17-2efdffe2a45b_FilterData] 1,'#F_ProjectDetailsId','',#MF_ProjectListActiveProjectspr_PageIndex,'#MF_ProjectListActiveProjectspr_GridRows'");


List<Triplet<string, short, short?>> result28E58773E71A46B18591A5E00111B3CB=acdataIspace34CF8FAF7574478F9C4AA65F98E4D18A.GetQueryExpressionBindings("28E58773-E71A-46B1-8591-A5E00111B3CB");
iSpace.SetGridData(resultDE7234F0989946C58758427FAF6AEB5A,result28E58773E71A46B18591A5E00111B3CB,"ProjectListActiveProjectspr",ref ISpace);
iSpace.UpdateGridBindDetails("ProjectListActiveProjectspr",result28E58773E71A46B18591A5E00111B3CB);
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
		if(elementName.ToLower().Equals("mf_projectlistactiveprojectspr_pageindex"))
    {
    			SubscribeElementEvents_mf_projectlistactiveprojectspr_pageindex(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mf_projectlistactiveprojectspr_gridrows"))
    {
    			SubscribeElementEvents_mf_projectlistactiveprojectspr_gridrows(ref dfsParam);
    }
}
	if(methodName.ToLower().Equals("onclick"))
{
		if(elementName.ToLower().Equals("add"))
{
			SubscribeElementEvents_add(ref dfsParam);
}
		if(elementName.ToLower().Equals("mf_asset"))
{
			SubscribeElementEvents_mf_asset(ref dfsParam);
}
		if(elementName.ToLower().Equals("m_createproposal"))
{
			SubscribeElementEvents_m_createproposal(ref dfsParam);
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


	public partial class AcDataISpace34CF8FAF7574478F9C4AA65F98E4D18A  : ExtensionActivityBase
	{		
		
		
		private Dictionary<string,  List<Triplet<string, short, short?>>> queryExpressionBindings = 
											new Dictionary<string,  List<Triplet<string, short, short?>>>
		{
							{"28E58773-E71A-46B1-8591-A5E00111B3CB", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MGG_V1_Agency",7,
														   -1),
								   new Triplet<string, short, short?>("MGG_V1_CoPI",5,
														   -1),
								   new Triplet<string, short, short?>("MGG_V1_Department",3,
														   -1),
								   new Triplet<string, short, short?>("MGG_V1_Duration",10,
														   -1),
								   new Triplet<string, short, short?>("MGG_V1_EndDate",9,
														   -1),
								   new Triplet<string, short, short?>("MGG_V1_FinancialYear",11,
														   -1),
								   new Triplet<string, short, short?>("MGG_V1_PI",4,
														   -1),
								   new Triplet<string, short, short?>("MGG_V1_ProjectDetailsID",0,
														   -1),
								   new Triplet<string, short, short?>("MGG_V1_ProjectNo",2,
														   -1),
								   new Triplet<string, short, short?>("MGG_V1_ProjectTitle",1,
														   -1),
								   new Triplet<string, short, short?>("MGG_V1_ProjectType",6,
														   -1),
								   new Triplet<string, short, short?>("MGG_V1_SanctionedValue",12,
														   -1),
								   new Triplet<string, short, short?>("MGG_V1_StartDate",8,
														   -1),
								   new Triplet<string, short, short?>("MGG_V1_Type",14,
														   -1),
								}
			},
					};	

	

		private Dictionary<string,string> formVersionList =new Dictionary<string,string> 
		{
							{"02A1FE25-AE94-461D-9B6F-A7AC8493B6F6", "Medium"},
					};	

		
		private Dictionary<string,string> formVersionLayoutList =new Dictionary<string,string> 
		{
							{"4BEC0590-061E-4553-B58B-2D7108C79085", ""},
							{"B7189E15-4C06-428C-859F-AA2E9297C20F", ""},
							{"02A1FE25-AE94-461D-9B6F-A7AC8493B6F6", ""},
							{"8671B05B-41A1-496B-8BAB-015A75C43A23", ""},
							{"B25A31B0-E585-4BB5-9555-126CB0502E1F", ""},
							{"A2108E21-BD18-4432-AE25-F2F1E294AC4E", ""},
							{"ECB2F7D4-C658-45DF-9C5E-A71D786AF743", ""},
							{"28380647-2267-49C9-95D9-AE4F9DA5CFAD", ""},
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
		


