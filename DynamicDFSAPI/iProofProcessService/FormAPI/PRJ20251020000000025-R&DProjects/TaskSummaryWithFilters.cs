  







namespace CPS.Proof.DFSExtension
{
	using System;
    using System.Collections.Generic;     
	using System.Linq;
	
	
	public partial class TaskSummaryWithFiltersProcessMetadata : ExtensionProcessBase
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
            get { return "29765AAA-A994-40D8-A9EB-93EB92E6EFAB"; }
        }

        public override string ProcessName
        {
            get { return "TaskSummaryWithFilters"; }
        }

		public override string ProcessDescription
        {
            get { return "Task Summary With Filters"; }
        }

        public override ProcessType ProcessType
        {
            get { return ProcessType.RuleBased; }
        }

      

		public override string FileGroupId
        {
            get { return "7EADC0EB-F718-4236-831D-51ED9DD6B47E"; }
        } 

		public override string FileGroup
        {
            get { return "Default"; }
        } 
		
        public override string PackageProcessMapId
        {
            get {return "29765AAA-A994-40D8-A9EB-93EB92E6EFAB";}
        }

		public override byte ProcessInstanceMode
        {
            get {return 3;}
        }		

		public override string MasterFormId
        {
            get {  
				   return "DCC08446-90C8-4F53-B0D8-89293314DBCD";	}
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
	

	public partial class TaskSummaryWithFiltersObjectFactory  : ExtObjectFactoryBase
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
        //    return (IExtBaseMetaData)new TaskSummaryWithFiltersProcessMetadata();
        //}
	


		private List<Triplet<string, string, string>> queryExpressionData = new List<Triplet<string, string, string>>
		{
	  			
			     new Triplet<string, string, string>("58D674A7-74A5-4DE1-A9A8-DFE425CA69B1","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"9ADED37B-CD11-426B-AF16-DEAC75685EF5"),
			
						
			     new Triplet<string, string, string>("F1A1836C-A83A-4FAB-9F41-BB56E85274EE","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"9ADED37B-CD11-426B-AF16-DEAC75685EF5"),
			
						
			     new Triplet<string, string, string>("B7B82949-1EE0-475F-95DE-BBD6269FEDBF","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"9ADED37B-CD11-426B-AF16-DEAC75685EF5"),
			
						
			     new Triplet<string, string, string>("E55DE8B6-5604-401D-9FA5-0372DE5D3A21","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"9ADED37B-CD11-426B-AF16-DEAC75685EF5"),
			
						
			     new Triplet<string, string, string>("6A417071-941C-4F7B-A9BB-3267F3ED0C08","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"9ADED37B-CD11-426B-AF16-DEAC75685EF5"),
			
						
			     new Triplet<string, string, string>("58D674A7-74A5-4DE1-A9A8-DFE425CA69B1","Load Remarks Details",
												     @"1BD3EDC5-B71F-42EF-B925-48DB3CADDB95"),
			
						
			     new Triplet<string, string, string>("B7B82949-1EE0-475F-95DE-BBD6269FEDBF","Load Task Summary details",
												     @"0F04F6CE-7F9F-48EC-A59F-8816E2E94E4B"),
			
			
			
		};

		
		private List<Triplet<string, string, string>> ComboDataSource = new List<Triplet<string, string, string>>
		{

		
	  			
			     new Triplet<string, string, string>("F_CurrentStatus","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMA18yFT7KruzVDa0TqsqpOM+grujzoqor1KqRIderPPsozBAr7TiIaPx7MYO2zQclV",
												     @"EXEC GetTaskStatusValues"),
			
						
			     new Triplet<string, string, string>("MF_TaskSummary_GridRows","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMAvOzkFMmxHUuxhHgktDkfvWfwBNgoOezuIQDeIjZtCKIIrSN+GjapRg==",
												     @"EXEC [dbo].[SP_GetAutoFormGridRows]"),
			
						
			     new Triplet<string, string, string>("F_ProcessName","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMA18yFT7KruzVDa0TqsqpOM+grujzoqor1KqRIderPPsozBAr7TiIaPx7MYO2zQclV",
												     @"EXEC [GetProcessListByModuleId] 0"),
			
						
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
		
	  			
			     new Tuple<string, int>("MG_TaskSummary",600),
			
						
			     new Tuple<string, int>("MG_RemarksDetails",500),
			
						
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
											case "2EC40310-88B9-4E21-AD43-FA1B94EBF785":
							virtualInstance=new ISpace2EC4031088B94E21AD43FA1B94EBF785();
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
	

	public partial class TaskSummaryWithFiltersDataElementFactory  : ExtElementBase
    {

     /// <summary>
        /// A <see cref="log4net.ILog"/> that contains the logger instance for 
        /// logging
        /// </summary>
        private readonly ILog _sysLog;

        public TaskSummaryWithFiltersDataElementFactory()
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

               
                
                                      case "DCC08446-90C8-4F53-B0D8-89293314DBCD":
                    {
                     
                                     fInsertQuery=@"IF NOT EXISTS(SELECT 1 FROM [DCC08446-90C8-4F53-B0D8-89293314DBCD] WHERE InstanceId='{0}') BEGIN INSERT INTO [DCC08446-90C8-4F53-B0D8-89293314DBCD](ProcessActivityMapId,FormId,SetDestinationTo,M_ViewUrl,F_TaskName,ExecutionMessage,Subject,M_CurrentStatus,SubFilter,F_InitiatedBy,ExecutionStatus,MF_TaskSummary_RecordsRange,M_ModuleId,RedirectUrl,M_PackageProcessMapId,F_Level,M_InitiatedInprogress,M_InitiatedCompleted,MF_TaskSummary_TotalPages,SLATime,MF_TaskSummary_PageIndex,M_ParticipatedInProgress,M_ParticipatedCompleted,MF_Option,F_ProcessName,F_CurrentStatus,MF_TaskSummary_GridRows,F_InitiatedStartDate,F_InitiatedEndDate,InstanceId)
							VALUES( {3}) END ELSE BEGIN UPDATE [DCC08446-90C8-4F53-B0D8-89293314DBCD]SET {4}WHERE InstanceId='{0}'END ";

                                     colList=@"ProcessActivityMapId,FormId,SetDestinationTo,M_ViewUrl,F_TaskName,ExecutionMessage,Subject,M_CurrentStatus,SubFilter,F_InitiatedBy,ExecutionStatus,MF_TaskSummary_RecordsRange,M_ModuleId,RedirectUrl,M_PackageProcessMapId,F_Level,M_InitiatedInprogress,M_InitiatedCompleted,MF_TaskSummary_TotalPages,SLATime,MF_TaskSummary_PageIndex,M_ParticipatedInProgress,M_ParticipatedCompleted,MF_Option,F_ProcessName,F_CurrentStatus,MF_TaskSummary_GridRows,F_InitiatedStartDate,F_InitiatedEndDate,InstanceId";
                                    
                     
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

                
                 
                                      case "0F04F6CE-7F9F-48EC-A59F-8816E2E94E4B":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_0F04F6CE7F9F48ECA59F8816E2E94E4B AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [TS_InitiatedDate] VARCHAR(MAX)	, [TS_ViewUrl] VARCHAR(MAX)	, [TS_Status] VARCHAR(MAX)	, [TS_ActivityName] VARCHAR(MAX)	, [TS_ModifiedDate] VARCHAR(MAX)	, [TS_Level] VARCHAR(MAX)	, [TS_InitiatedBy] VARCHAR(MAX)	, [TS_ID] VARCHAR(MAX)){0}INSERT INTO [0F04F6CE-7F9F-48EC-A59F-8816E2E94E4B](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,TS_InitiatedDate,TS_ViewUrl,TS_Status,TS_ActivityName,TS_ModifiedDate,TS_Level,TS_InitiatedBy,TS_ID)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.TS_InitiatedDate,TDT.TS_ViewUrl,TDT.TS_Status,TDT.TS_ActivityName,TDT.TS_ModifiedDate,TDT.TS_Level,TDT.TS_InitiatedBy,TDT.TS_ID FROM @TBL_0F04F6CE7F9F48ECA59F8816E2E94E4B TDT
							LEFT JOIN [0F04F6CE-7F9F-48EC-A59F-8816E2E94E4B] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,TS_InitiatedDate=TDT.TS_InitiatedDate,TS_ViewUrl=TDT.TS_ViewUrl,TS_Status=TDT.TS_Status,TS_ActivityName=TDT.TS_ActivityName,TS_ModifiedDate=TDT.TS_ModifiedDate,TS_Level=TDT.TS_Level,TS_InitiatedBy=TDT.TS_InitiatedBy,TS_ID=TDT.TS_ID FROM @TBL_0F04F6CE7F9F48ECA59F8816E2E94E4B TDT
							JOIN [0F04F6CE-7F9F-48EC-A59F-8816E2E94E4B] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,TS_InitiatedDate,TS_ViewUrl,TS_Status,TS_ActivityName,TS_ModifiedDate,TS_Level,TS_InitiatedBy,TS_ID";

                                     tempInsertQuery=@"INSERT INTO @TBL_0F04F6CE7F9F48ECA59F8816E2E94E4B(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,TS_InitiatedDate,TS_ViewUrl,TS_Status,TS_ActivityName,TS_ModifiedDate,TS_Level,TS_InitiatedBy,TS_ID)VALUES({0});";
                                     

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
                     
                                    case "1BD3EDC5-B71F-42EF-B925-48DB3CADDB95":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_1BD3EDC5B71F42EFB92548DB3CADDB95 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [Remarks] VARCHAR(MAX)	, [ActivityName] VARCHAR(MAX)	, [UserName] VARCHAR(MAX)	, [RemarksId] VARCHAR(MAX)	, [DateOfRemarks] DATETIME){0}INSERT INTO [1BD3EDC5-B71F-42EF-B925-48DB3CADDB95](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,Remarks,ActivityName,UserName,RemarksId,DateOfRemarks)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.Remarks,TDT.ActivityName,TDT.UserName,TDT.RemarksId,TDT.DateOfRemarks FROM @TBL_1BD3EDC5B71F42EFB92548DB3CADDB95 TDT
							LEFT JOIN [1BD3EDC5-B71F-42EF-B925-48DB3CADDB95] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,Remarks=TDT.Remarks,ActivityName=TDT.ActivityName,UserName=TDT.UserName,RemarksId=TDT.RemarksId,DateOfRemarks=TDT.DateOfRemarks FROM @TBL_1BD3EDC5B71F42EFB92548DB3CADDB95 TDT
							JOIN [1BD3EDC5-B71F-42EF-B925-48DB3CADDB95] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,Remarks,ActivityName,UserName,RemarksId,DateOfRemarks";

                                     tempInsertQuery=@"INSERT INTO @TBL_1BD3EDC5B71F42EFB92548DB3CADDB95(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,Remarks,ActivityName,UserName,RemarksId,DateOfRemarks)VALUES({0});";
                                     

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
                     

                                         case "0F04F6CE-7F9F-48EC-A59F-8816E2E94E4B":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_0F04F6CE7F9F48ECA59F8816E2E94E4B AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [TS_InitiatedDate] VARCHAR(MAX)	, [TS_ViewUrl] VARCHAR(MAX)	, [TS_Status] VARCHAR(MAX)	, [TS_ActivityName] VARCHAR(MAX)	, [TS_ModifiedDate] VARCHAR(MAX)	, [TS_Level] VARCHAR(MAX)	, [TS_InitiatedBy] VARCHAR(MAX)	, [TS_ID] VARCHAR(MAX)){0}INSERT INTO [0F04F6CE-7F9F-48EC-A59F-8816E2E94E4B](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,TS_InitiatedDate,TS_ViewUrl,TS_Status,TS_ActivityName,TS_ModifiedDate,TS_Level,TS_InitiatedBy,TS_ID)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.TS_InitiatedDate,TDT.TS_ViewUrl,TDT.TS_Status,TDT.TS_ActivityName,TDT.TS_ModifiedDate,TDT.TS_Level,TDT.TS_InitiatedBy,TDT.TS_ID FROM @TBL_0F04F6CE7F9F48ECA59F8816E2E94E4B TDT
							LEFT JOIN [0F04F6CE-7F9F-48EC-A59F-8816E2E94E4B] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,TS_InitiatedDate=TDT.TS_InitiatedDate,TS_ViewUrl=TDT.TS_ViewUrl,TS_Status=TDT.TS_Status,TS_ActivityName=TDT.TS_ActivityName,TS_ModifiedDate=TDT.TS_ModifiedDate,TS_Level=TDT.TS_Level,TS_InitiatedBy=TDT.TS_InitiatedBy,TS_ID=TDT.TS_ID FROM @TBL_0F04F6CE7F9F48ECA59F8816E2E94E4B TDT
							JOIN [0F04F6CE-7F9F-48EC-A59F-8816E2E94E4B] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,TS_InitiatedDate,TS_ViewUrl,TS_Status,TS_ActivityName,TS_ModifiedDate,TS_Level,TS_InitiatedBy,TS_ID";

                            tempInsertQuery=@"INSERT INTO @TBL_0F04F6CE7F9F48ECA59F8816E2E94E4B(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,TS_InitiatedDate,TS_ViewUrl,TS_Status,TS_ActivityName,TS_ModifiedDate,TS_Level,TS_InitiatedBy,TS_ID)VALUES({0});";

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

                                              case "1BD3EDC5-B71F-42EF-B925-48DB3CADDB95":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_1BD3EDC5B71F42EFB92548DB3CADDB95 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [Remarks] VARCHAR(MAX)	, [ActivityName] VARCHAR(MAX)	, [UserName] VARCHAR(MAX)	, [RemarksId] VARCHAR(MAX)	, [DateOfRemarks] DATETIME){0}INSERT INTO [1BD3EDC5-B71F-42EF-B925-48DB3CADDB95](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,Remarks,ActivityName,UserName,RemarksId,DateOfRemarks)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.Remarks,TDT.ActivityName,TDT.UserName,TDT.RemarksId,TDT.DateOfRemarks FROM @TBL_1BD3EDC5B71F42EFB92548DB3CADDB95 TDT
							LEFT JOIN [1BD3EDC5-B71F-42EF-B925-48DB3CADDB95] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,Remarks=TDT.Remarks,ActivityName=TDT.ActivityName,UserName=TDT.UserName,RemarksId=TDT.RemarksId,DateOfRemarks=TDT.DateOfRemarks FROM @TBL_1BD3EDC5B71F42EFB92548DB3CADDB95 TDT
							JOIN [1BD3EDC5-B71F-42EF-B925-48DB3CADDB95] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,Remarks,ActivityName,UserName,RemarksId,DateOfRemarks";

                            tempInsertQuery=@"INSERT INTO @TBL_1BD3EDC5B71F42EFB92548DB3CADDB95(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,Remarks,ActivityName,UserName,RemarksId,DateOfRemarks)VALUES({0});";

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
public class ISpace2EC4031088B94E21AD43FA1B94EBF785 : VirtualForm
{
IISpace iSpace = new ISpace();
AcDataISpace2EC4031088B94E21AD43FA1B94EBF785 acdataIspace2EC4031088B94E21AD43FA1B94EBF785=new AcDataISpace2EC4031088B94E21AD43FA1B94EBF785();
private void SubscribeFormEvents_root(ref Dictionary<string, ServiceElementData> ISpace)
{
try
{
base.WriteDebugInfo(@"Root-OnAfterFormLoad");
if(IsNullOrEmpty(ISpace["M_CurrentStatus"].Value))
{
base.WriteDebugInfo(@"if(IsNullOrEmpty(ISpace[""M_CurrentStatus""].Value))");
ISpace["M_CurrentStatus"].Value="Initiated-Pending";
base.WriteDebugInfo(@"ISpace[""M_CurrentStatus""].Value=""Initiated-Pending"";");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC [dbo].usp_BuildDynamicTaskFilter '#F_TaskName','#F_InitiatedBy','#F_InitiatedStartDate','#F_InitiatedEndDate','#F_Level','#F_CurrentStatus','#F_ProcessName'");

var querySourceF1A1836CA83A4FAB9F41BB56E85274EE =GetQueryExpressionDataSource("F1A1836C-A83A-4FAB-9F41-BB56E85274EE");
Dictionary<short,object> resultF1A1836CA83A4FAB9F41BB56E85274EE=iSpace.ExecuteQuery(querySourceF1A1836CA83A4FAB9F41BB56E85274EE,@"EXEC [dbo].usp_BuildDynamicTaskFilter '" + ISpace["F_TaskName"].Value + @"','" + ISpace["F_InitiatedBy"].Value + @"','" + ISpace["F_InitiatedStartDate"].Value + @"','" + ISpace["F_InitiatedEndDate"].Value + @"','" + ISpace["F_Level"].Value + @"','" + ISpace["F_CurrentStatus"].Value + @"','" + ISpace["F_ProcessName"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceF1A1836CA83A4FAB9F41BB56E85274EE =GetQueryExpressionDataSource(""F1A1836C-A83A-4FAB-9F41-BB56E85274EE"");Dictionary<short,object> resultF1A1836CA83A4FAB9F41BB56E85274EE=iSpace.ExecuteQuery(querySourceF1A1836CA83A4FAB9F41BB56E85274EE,@""EXEC [dbo].usp_BuildDynamicTaskFilter '"" + ISpace[""F_TaskName""].Value + @""','"" + ISpace[""F_InitiatedBy""].Value + @""','"" + ISpace[""F_InitiatedStartDate""].Value + @""','"" + ISpace[""F_InitiatedEndDate""].Value + @""','"" + ISpace[""F_Level""].Value + @""','"" + ISpace[""F_CurrentStatus""].Value + @""','"" + ISpace[""F_ProcessName""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultF1A1836CA83A4FAB9F41BB56E85274EE!=null) && (resultF1A1836CA83A4FAB9F41BB56E85274EE.Count!=0))
{
if(resultF1A1836CA83A4FAB9F41BB56E85274EE.ContainsKey(0))
ISpace["SubFilter"].Value = resultF1A1836CA83A4FAB9F41BB56E85274EE[0];
}
else{
ISpace["SubFilter"].Value = null;
}
ISpace["SubFilter"].Value=Replace(ISpace["SubFIlter"].Value,"'","''");
base.WriteDebugInfo(@"ISpace[""SubFilter""].Value=Replace(ISpace[""SubFIlter""].Value,""'"",""''"");");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC dbo.[GetUserRequestSummaryWithFilters] 0,@@gv_UserId,'#M_ModuleId','#M_CurrentStatus','#SubFilter','',#MF_TaskSummary_PageIndex,'#MF_TaskSummary_GridRows'");

var querySourceE55DE8B65604401D9FA50372DE5D3A21 =GetQueryExpressionDataSource("E55DE8B6-5604-401D-9FA5-0372DE5D3A21");
Dictionary<short,object> resultE55DE8B65604401D9FA50372DE5D3A21=iSpace.ExecuteQuery(querySourceE55DE8B65604401D9FA50372DE5D3A21,@"EXEC dbo.[GetUserRequestSummaryWithFilters] 0," + ISpace["gv_userid"].Value + @",'" + ISpace["M_ModuleId"].Value + @"','" + ISpace["M_CurrentStatus"].Value + @"','" + ISpace["SubFilter"].Value + @"',''," + ISpace["MF_TaskSummary_PageIndex"].Value + @",'" + ISpace["MF_TaskSummary_GridRows"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceE55DE8B65604401D9FA50372DE5D3A21 =GetQueryExpressionDataSource(""E55DE8B6-5604-401D-9FA5-0372DE5D3A21"");Dictionary<short,object> resultE55DE8B65604401D9FA50372DE5D3A21=iSpace.ExecuteQuery(querySourceE55DE8B65604401D9FA50372DE5D3A21,@""EXEC dbo.[GetUserRequestSummaryWithFilters] 0,"" + ISpace[""gv_userid""].Value + @"",'"" + ISpace[""M_ModuleId""].Value + @""','"" + ISpace[""M_CurrentStatus""].Value + @""','"" + ISpace[""SubFilter""].Value + @""','',"" + ISpace[""MF_TaskSummary_PageIndex""].Value + @"",'"" + ISpace[""MF_TaskSummary_GridRows""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultE55DE8B65604401D9FA50372DE5D3A21!=null) && (resultE55DE8B65604401D9FA50372DE5D3A21.Count!=0))
{
if(resultE55DE8B65604401D9FA50372DE5D3A21.ContainsKey(0))
ISpace["MF_TaskSummary_GridRows"].Value = resultE55DE8B65604401D9FA50372DE5D3A21[0];
if(resultE55DE8B65604401D9FA50372DE5D3A21.ContainsKey(3))
ISpace["MF_TaskSummary_TotalPages"].Value = resultE55DE8B65604401D9FA50372DE5D3A21[3];
if(resultE55DE8B65604401D9FA50372DE5D3A21.ContainsKey(2))
ISpace["MF_TaskSummary_PageIndex"].Value = resultE55DE8B65604401D9FA50372DE5D3A21[2];
if(resultE55DE8B65604401D9FA50372DE5D3A21.ContainsKey(1))
ISpace["MF_TaskSummary_RecordsRange"].Value = resultE55DE8B65604401D9FA50372DE5D3A21[1];
}
else{
ISpace["MF_TaskSummary_GridRows"].Value = null;ISpace["MF_TaskSummary_TotalPages"].Value = null;ISpace["MF_TaskSummary_PageIndex"].Value = null;ISpace["MF_TaskSummary_RecordsRange"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_TaskSummary_PageIndex"].Value==1||ISpace["MF_TaskSummary_PageIndex"].Value==0)
{
base.WriteDebugInfo(@"if(ISpace[""MF_TaskSummary_PageIndex""].Value==1||ISpace[""MF_TaskSummary_PageIndex""].Value==0)");
if(ISpace["MF_TaskSummary_PageIndex"].Value==ISpace["MF_TaskSummary_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_TaskSummary_PageIndex""].Value==ISpace[""MF_TaskSummary_TotalPages""].Value)");
ISpace["MF_TaskSummary_FirstButton"].Enbl="false";ISpace["MF_TaskSummary_LastButton"].Enbl="false";ISpace["MF_TaskSummary_PageIndex"].Enbl="false";ISpace["MF_TaskSummary_NextButton"].Enbl="false";ISpace["MF_TaskSummary_PrevButton"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MF_TaskSummary_FirstButton""].Enbl=""false"";ISpace[""MF_TaskSummary_LastButton""].Enbl=""false"";ISpace[""MF_TaskSummary_PageIndex""].Enbl=""false"";ISpace[""MF_TaskSummary_NextButton""].Enbl=""false"";ISpace[""MF_TaskSummary_PrevButton""].Enbl=""false"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_TaskSummary_FirstButton"].Enbl="false";ISpace["MF_TaskSummary_LastButton"].Enbl="true";ISpace["MF_TaskSummary_PageIndex"].Enbl="true";ISpace["MF_TaskSummary_NextButton"].Enbl="true";ISpace["MF_TaskSummary_PrevButton"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MF_TaskSummary_FirstButton""].Enbl=""false"";ISpace[""MF_TaskSummary_LastButton""].Enbl=""true"";ISpace[""MF_TaskSummary_PageIndex""].Enbl=""true"";ISpace[""MF_TaskSummary_NextButton""].Enbl=""true"";ISpace[""MF_TaskSummary_PrevButton""].Enbl=""false"";");
}
}
else
{
base.WriteDebugInfo(@"else");
if(ISpace["MF_TaskSummary_PageIndex"].Value==ISpace["MF_TaskSummary_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_TaskSummary_PageIndex""].Value==ISpace[""MF_TaskSummary_TotalPages""].Value)");
ISpace["MF_TaskSummary_FirstButton"].Enbl="true";ISpace["MF_TaskSummary_LastButton"].Enbl="false";ISpace["MF_TaskSummary_PageIndex"].Enbl="true";ISpace["MF_TaskSummary_NextButton"].Enbl="false";ISpace["MF_TaskSummary_PrevButton"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_TaskSummary_FirstButton""].Enbl=""true"";ISpace[""MF_TaskSummary_LastButton""].Enbl=""false"";ISpace[""MF_TaskSummary_PageIndex""].Enbl=""true"";ISpace[""MF_TaskSummary_NextButton""].Enbl=""false"";ISpace[""MF_TaskSummary_PrevButton""].Enbl=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_TaskSummary_FirstButton"].Enbl="true";ISpace["MF_TaskSummary_LastButton"].Enbl="true";ISpace["MF_TaskSummary_PageIndex"].Enbl="true";ISpace["MF_TaskSummary_NextButton"].Enbl="true";ISpace["MF_TaskSummary_PrevButton"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_TaskSummary_FirstButton""].Enbl=""true"";ISpace[""MF_TaskSummary_LastButton""].Enbl=""true"";ISpace[""MF_TaskSummary_PageIndex""].Enbl=""true"";ISpace[""MF_TaskSummary_NextButton""].Enbl=""true"";ISpace[""MF_TaskSummary_PrevButton""].Enbl=""true"";");
}
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySourceB7B829491EE0475F95DEBBD6269FEDBF =GetQueryExpressionDataSource("B7B82949-1EE0-475F-95DE-BBD6269FEDBF");

DataTable resultB7B829491EE0475F95DEBBD6269FEDBF=iSpace.SetGridDataSource(querySourceB7B829491EE0475F95DEBBD6269FEDBF, _objectFactory.GetGridRPP("MG_TaskSummary"),@"EXEC dbo.[GetUserRequestSummaryWithFilters] 1," + ISpace["gv_userid"].Value + @",'" + ISpace["M_ModuleId"].Value + @"','" + ISpace["M_CurrentStatus"].Value + @"','" + ISpace["SubFilter"].Value + @"',''," + ISpace["MF_TaskSummary_PageIndex"].Value + @",'" + ISpace["MF_TaskSummary_GridRows"].Value + @"'");

iSpace.InsertGridBindDetails("MG_TaskSummary","11",querySourceB7B829491EE0475F95DEBBD6269FEDBF,"EXEC dbo.[GetUserRequestSummaryWithFilters] 1," + ISpace["gv_userid"].Value + @",'" + ISpace["M_ModuleId"].Value + @"','" + ISpace["M_CurrentStatus"].Value + @"','" + ISpace["SubFilter"].Value + @"',''," + ISpace["MF_TaskSummary_PageIndex"].Value + @",'" + ISpace["MF_TaskSummary_GridRows"].Value + @"'",_objectFactory.GetGridRPP("MG_TaskSummary"));

base.WriteDebugInfo(@"var querySourceB7B829491EE0475F95DEBBD6269FEDBF =GetQueryExpressionDataSource(""B7B82949-1EE0-475F-95DE-BBD6269FEDBF"");DataTable resultB7B829491EE0475F95DEBBD6269FEDBF=iSpace.SetGridDataSource(querySourceB7B829491EE0475F95DEBBD6269FEDBF, _objectFactory.GetGridRPP(""MG_TaskSummary""),@""EXEC dbo.[GetUserRequestSummaryWithFilters] 1,"" + ISpace[""gv_userid""].Value + @"",'"" + ISpace[""M_ModuleId""].Value + @""','"" + ISpace[""M_CurrentStatus""].Value + @""','"" + ISpace[""SubFilter""].Value + @""','',"" + ISpace[""MF_TaskSummary_PageIndex""].Value + @"",'"" + ISpace[""MF_TaskSummary_GridRows""].Value + @""'"");iSpace.InsertGridBindDetails(""MG_TaskSummary"",""11"",querySourceB7B829491EE0475F95DEBBD6269FEDBF,""EXEC dbo.[GetUserRequestSummaryWithFilters] 1,"" + ISpace[""gv_userid""].Value + @"",'"" + ISpace[""M_ModuleId""].Value + @""','"" + ISpace[""M_CurrentStatus""].Value + @""','"" + ISpace[""SubFilter""].Value + @""','',"" + ISpace[""MF_TaskSummary_PageIndex""].Value + @"",'"" + ISpace[""MF_TaskSummary_GridRows""].Value + @""'"",_objectFactory.GetGridRPP(""MG_TaskSummary""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result67C3863389CE42879063086A3A6BA3EB=acdataIspace2EC4031088B94E21AD43FA1B94EBF785.GetQueryExpressionBindings("67C38633-89CE-4287-9063-086A3A6BA3EB");
iSpace.SetGridData(resultB7B829491EE0475F95DEBBD6269FEDBF,result67C3863389CE42879063086A3A6BA3EB,"MG_TaskSummary",ref ISpace);
iSpace.UpdateGridBindDetails("MG_TaskSummary",result67C3863389CE42879063086A3A6BA3EB);
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC GetUserRequestStatisticsWithFilters 1,'@@gv_UserId','#M_ModuleId','#SubFilter'");

var querySource6A417071941C4F7BA9BB3267F3ED0C08 =GetQueryExpressionDataSource("6A417071-941C-4F7B-A9BB-3267F3ED0C08");
Dictionary<short,object> result6A417071941C4F7BA9BB3267F3ED0C08=iSpace.ExecuteQuery(querySource6A417071941C4F7BA9BB3267F3ED0C08,@"EXEC GetUserRequestStatisticsWithFilters 1,'" + ISpace["gv_userid"].Value + @"','" + ISpace["M_ModuleId"].Value + @"','" + ISpace["SubFilter"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource6A417071941C4F7BA9BB3267F3ED0C08 =GetQueryExpressionDataSource(""6A417071-941C-4F7B-A9BB-3267F3ED0C08"");Dictionary<short,object> result6A417071941C4F7BA9BB3267F3ED0C08=iSpace.ExecuteQuery(querySource6A417071941C4F7BA9BB3267F3ED0C08,@""EXEC GetUserRequestStatisticsWithFilters 1,'"" + ISpace[""gv_userid""].Value + @""','"" + ISpace[""M_ModuleId""].Value + @""','"" + ISpace[""SubFilter""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result6A417071941C4F7BA9BB3267F3ED0C08!=null) && (result6A417071941C4F7BA9BB3267F3ED0C08.Count!=0))
{
if(result6A417071941C4F7BA9BB3267F3ED0C08.ContainsKey(0))
ISpace["M_InitiatedInprogress"].Value = result6A417071941C4F7BA9BB3267F3ED0C08[0];
if(result6A417071941C4F7BA9BB3267F3ED0C08.ContainsKey(1))
ISpace["M_InitiatedCompleted"].Value = result6A417071941C4F7BA9BB3267F3ED0C08[1];
if(result6A417071941C4F7BA9BB3267F3ED0C08.ContainsKey(2))
ISpace["M_ParticipatedInProgress"].Value = result6A417071941C4F7BA9BB3267F3ED0C08[2];
if(result6A417071941C4F7BA9BB3267F3ED0C08.ContainsKey(3))
ISpace["M_ParticipatedCompleted"].Value = result6A417071941C4F7BA9BB3267F3ED0C08[3];
}
else{
ISpace["M_InitiatedInprogress"].Value = null;ISpace["M_InitiatedCompleted"].Value = null;ISpace["M_ParticipatedInProgress"].Value = null;ISpace["M_ParticipatedCompleted"].Value = null;
}
}
if(ISpace["FormVersionId"].Value=="1AA5B3E2-9DA8-490E-B860-328F504DFF0D")
{
ISpace["UI_ViewHistory"].Visible="false";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""1AA5B3E2-9DA8-490E-B860-328F504DFF0D"")
{
ISpace[""UI_ViewHistory""].Visible=""false"";
}");
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
if(IsNullOrEmpty(ISpace["M_CurrentStatus"].Value))
{
base.WriteDebugInfo(@"if(IsNullOrEmpty(ISpace[""M_CurrentStatus""].Value))");
ISpace["M_CurrentStatus"].Value="Initiated-Pending";
base.WriteDebugInfo(@"ISpace[""M_CurrentStatus""].Value=""Initiated-Pending"";");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC [dbo].usp_BuildDynamicTaskFilter '#F_TaskName','#F_InitiatedBy','#F_InitiatedStartDate','#F_InitiatedEndDate','#F_Level','#F_CurrentStatus','#F_ProcessName'");

var querySourceF1A1836CA83A4FAB9F41BB56E85274EE =GetQueryExpressionDataSource("F1A1836C-A83A-4FAB-9F41-BB56E85274EE");
Dictionary<short,object> resultF1A1836CA83A4FAB9F41BB56E85274EE=iSpace.ExecuteQuery(querySourceF1A1836CA83A4FAB9F41BB56E85274EE,@"EXEC [dbo].usp_BuildDynamicTaskFilter '" + ISpace["F_TaskName"].Value + @"','" + ISpace["F_InitiatedBy"].Value + @"','" + ISpace["F_InitiatedStartDate"].Value + @"','" + ISpace["F_InitiatedEndDate"].Value + @"','" + ISpace["F_Level"].Value + @"','" + ISpace["F_CurrentStatus"].Value + @"','" + ISpace["F_ProcessName"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceF1A1836CA83A4FAB9F41BB56E85274EE =GetQueryExpressionDataSource(""F1A1836C-A83A-4FAB-9F41-BB56E85274EE"");Dictionary<short,object> resultF1A1836CA83A4FAB9F41BB56E85274EE=iSpace.ExecuteQuery(querySourceF1A1836CA83A4FAB9F41BB56E85274EE,@""EXEC [dbo].usp_BuildDynamicTaskFilter '"" + ISpace[""F_TaskName""].Value + @""','"" + ISpace[""F_InitiatedBy""].Value + @""','"" + ISpace[""F_InitiatedStartDate""].Value + @""','"" + ISpace[""F_InitiatedEndDate""].Value + @""','"" + ISpace[""F_Level""].Value + @""','"" + ISpace[""F_CurrentStatus""].Value + @""','"" + ISpace[""F_ProcessName""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultF1A1836CA83A4FAB9F41BB56E85274EE!=null) && (resultF1A1836CA83A4FAB9F41BB56E85274EE.Count!=0))
{
if(resultF1A1836CA83A4FAB9F41BB56E85274EE.ContainsKey(0))
ISpace["SubFilter"].Value = resultF1A1836CA83A4FAB9F41BB56E85274EE[0];
}
else{
ISpace["SubFilter"].Value = null;
}
ISpace["SubFilter"].Value=Replace(ISpace["SubFIlter"].Value,"'","''");
base.WriteDebugInfo(@"ISpace[""SubFilter""].Value=Replace(ISpace[""SubFIlter""].Value,""'"",""''"");");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC dbo.[GetUserRequestSummaryWithFilters] 0,@@gv_UserId,'#M_ModuleId','#M_CurrentStatus','#SubFilter','',#MF_TaskSummary_PageIndex,'#MF_TaskSummary_GridRows'");

var querySourceE55DE8B65604401D9FA50372DE5D3A21 =GetQueryExpressionDataSource("E55DE8B6-5604-401D-9FA5-0372DE5D3A21");
Dictionary<short,object> resultE55DE8B65604401D9FA50372DE5D3A21=iSpace.ExecuteQuery(querySourceE55DE8B65604401D9FA50372DE5D3A21,@"EXEC dbo.[GetUserRequestSummaryWithFilters] 0," + ISpace["gv_userid"].Value + @",'" + ISpace["M_ModuleId"].Value + @"','" + ISpace["M_CurrentStatus"].Value + @"','" + ISpace["SubFilter"].Value + @"',''," + ISpace["MF_TaskSummary_PageIndex"].Value + @",'" + ISpace["MF_TaskSummary_GridRows"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceE55DE8B65604401D9FA50372DE5D3A21 =GetQueryExpressionDataSource(""E55DE8B6-5604-401D-9FA5-0372DE5D3A21"");Dictionary<short,object> resultE55DE8B65604401D9FA50372DE5D3A21=iSpace.ExecuteQuery(querySourceE55DE8B65604401D9FA50372DE5D3A21,@""EXEC dbo.[GetUserRequestSummaryWithFilters] 0,"" + ISpace[""gv_userid""].Value + @"",'"" + ISpace[""M_ModuleId""].Value + @""','"" + ISpace[""M_CurrentStatus""].Value + @""','"" + ISpace[""SubFilter""].Value + @""','',"" + ISpace[""MF_TaskSummary_PageIndex""].Value + @"",'"" + ISpace[""MF_TaskSummary_GridRows""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultE55DE8B65604401D9FA50372DE5D3A21!=null) && (resultE55DE8B65604401D9FA50372DE5D3A21.Count!=0))
{
if(resultE55DE8B65604401D9FA50372DE5D3A21.ContainsKey(0))
ISpace["MF_TaskSummary_GridRows"].Value = resultE55DE8B65604401D9FA50372DE5D3A21[0];
if(resultE55DE8B65604401D9FA50372DE5D3A21.ContainsKey(3))
ISpace["MF_TaskSummary_TotalPages"].Value = resultE55DE8B65604401D9FA50372DE5D3A21[3];
if(resultE55DE8B65604401D9FA50372DE5D3A21.ContainsKey(2))
ISpace["MF_TaskSummary_PageIndex"].Value = resultE55DE8B65604401D9FA50372DE5D3A21[2];
if(resultE55DE8B65604401D9FA50372DE5D3A21.ContainsKey(1))
ISpace["MF_TaskSummary_RecordsRange"].Value = resultE55DE8B65604401D9FA50372DE5D3A21[1];
}
else{
ISpace["MF_TaskSummary_GridRows"].Value = null;ISpace["MF_TaskSummary_TotalPages"].Value = null;ISpace["MF_TaskSummary_PageIndex"].Value = null;ISpace["MF_TaskSummary_RecordsRange"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_TaskSummary_PageIndex"].Value==1||ISpace["MF_TaskSummary_PageIndex"].Value==0)
{
base.WriteDebugInfo(@"if(ISpace[""MF_TaskSummary_PageIndex""].Value==1||ISpace[""MF_TaskSummary_PageIndex""].Value==0)");
if(ISpace["MF_TaskSummary_PageIndex"].Value==ISpace["MF_TaskSummary_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_TaskSummary_PageIndex""].Value==ISpace[""MF_TaskSummary_TotalPages""].Value)");
ISpace["MF_TaskSummary_FirstButton"].Enbl="false";ISpace["MF_TaskSummary_LastButton"].Enbl="false";ISpace["MF_TaskSummary_PageIndex"].Enbl="false";ISpace["MF_TaskSummary_NextButton"].Enbl="false";ISpace["MF_TaskSummary_PrevButton"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MF_TaskSummary_FirstButton""].Enbl=""false"";ISpace[""MF_TaskSummary_LastButton""].Enbl=""false"";ISpace[""MF_TaskSummary_PageIndex""].Enbl=""false"";ISpace[""MF_TaskSummary_NextButton""].Enbl=""false"";ISpace[""MF_TaskSummary_PrevButton""].Enbl=""false"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_TaskSummary_FirstButton"].Enbl="false";ISpace["MF_TaskSummary_LastButton"].Enbl="true";ISpace["MF_TaskSummary_PageIndex"].Enbl="true";ISpace["MF_TaskSummary_NextButton"].Enbl="true";ISpace["MF_TaskSummary_PrevButton"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MF_TaskSummary_FirstButton""].Enbl=""false"";ISpace[""MF_TaskSummary_LastButton""].Enbl=""true"";ISpace[""MF_TaskSummary_PageIndex""].Enbl=""true"";ISpace[""MF_TaskSummary_NextButton""].Enbl=""true"";ISpace[""MF_TaskSummary_PrevButton""].Enbl=""false"";");
}
}
else
{
base.WriteDebugInfo(@"else");
if(ISpace["MF_TaskSummary_PageIndex"].Value==ISpace["MF_TaskSummary_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_TaskSummary_PageIndex""].Value==ISpace[""MF_TaskSummary_TotalPages""].Value)");
ISpace["MF_TaskSummary_FirstButton"].Enbl="true";ISpace["MF_TaskSummary_LastButton"].Enbl="false";ISpace["MF_TaskSummary_PageIndex"].Enbl="true";ISpace["MF_TaskSummary_NextButton"].Enbl="false";ISpace["MF_TaskSummary_PrevButton"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_TaskSummary_FirstButton""].Enbl=""true"";ISpace[""MF_TaskSummary_LastButton""].Enbl=""false"";ISpace[""MF_TaskSummary_PageIndex""].Enbl=""true"";ISpace[""MF_TaskSummary_NextButton""].Enbl=""false"";ISpace[""MF_TaskSummary_PrevButton""].Enbl=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_TaskSummary_FirstButton"].Enbl="true";ISpace["MF_TaskSummary_LastButton"].Enbl="true";ISpace["MF_TaskSummary_PageIndex"].Enbl="true";ISpace["MF_TaskSummary_NextButton"].Enbl="true";ISpace["MF_TaskSummary_PrevButton"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_TaskSummary_FirstButton""].Enbl=""true"";ISpace[""MF_TaskSummary_LastButton""].Enbl=""true"";ISpace[""MF_TaskSummary_PageIndex""].Enbl=""true"";ISpace[""MF_TaskSummary_NextButton""].Enbl=""true"";ISpace[""MF_TaskSummary_PrevButton""].Enbl=""true"";");
}
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySourceB7B829491EE0475F95DEBBD6269FEDBF =GetQueryExpressionDataSource("B7B82949-1EE0-475F-95DE-BBD6269FEDBF");

DataTable resultB7B829491EE0475F95DEBBD6269FEDBF=iSpace.SetGridDataSource(querySourceB7B829491EE0475F95DEBBD6269FEDBF, _objectFactory.GetGridRPP("MG_TaskSummary"),@"EXEC dbo.[GetUserRequestSummaryWithFilters] 1," + ISpace["gv_userid"].Value + @",'" + ISpace["M_ModuleId"].Value + @"','" + ISpace["M_CurrentStatus"].Value + @"','" + ISpace["SubFilter"].Value + @"',''," + ISpace["MF_TaskSummary_PageIndex"].Value + @",'" + ISpace["MF_TaskSummary_GridRows"].Value + @"'");

iSpace.InsertGridBindDetails("MG_TaskSummary","11",querySourceB7B829491EE0475F95DEBBD6269FEDBF,"EXEC dbo.[GetUserRequestSummaryWithFilters] 1," + ISpace["gv_userid"].Value + @",'" + ISpace["M_ModuleId"].Value + @"','" + ISpace["M_CurrentStatus"].Value + @"','" + ISpace["SubFilter"].Value + @"',''," + ISpace["MF_TaskSummary_PageIndex"].Value + @",'" + ISpace["MF_TaskSummary_GridRows"].Value + @"'",_objectFactory.GetGridRPP("MG_TaskSummary"));

base.WriteDebugInfo(@"var querySourceB7B829491EE0475F95DEBBD6269FEDBF =GetQueryExpressionDataSource(""B7B82949-1EE0-475F-95DE-BBD6269FEDBF"");DataTable resultB7B829491EE0475F95DEBBD6269FEDBF=iSpace.SetGridDataSource(querySourceB7B829491EE0475F95DEBBD6269FEDBF, _objectFactory.GetGridRPP(""MG_TaskSummary""),@""EXEC dbo.[GetUserRequestSummaryWithFilters] 1,"" + ISpace[""gv_userid""].Value + @"",'"" + ISpace[""M_ModuleId""].Value + @""','"" + ISpace[""M_CurrentStatus""].Value + @""','"" + ISpace[""SubFilter""].Value + @""','',"" + ISpace[""MF_TaskSummary_PageIndex""].Value + @"",'"" + ISpace[""MF_TaskSummary_GridRows""].Value + @""'"");iSpace.InsertGridBindDetails(""MG_TaskSummary"",""11"",querySourceB7B829491EE0475F95DEBBD6269FEDBF,""EXEC dbo.[GetUserRequestSummaryWithFilters] 1,"" + ISpace[""gv_userid""].Value + @"",'"" + ISpace[""M_ModuleId""].Value + @""','"" + ISpace[""M_CurrentStatus""].Value + @""','"" + ISpace[""SubFilter""].Value + @""','',"" + ISpace[""MF_TaskSummary_PageIndex""].Value + @"",'"" + ISpace[""MF_TaskSummary_GridRows""].Value + @""'"",_objectFactory.GetGridRPP(""MG_TaskSummary""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result67C3863389CE42879063086A3A6BA3EB=acdataIspace2EC4031088B94E21AD43FA1B94EBF785.GetQueryExpressionBindings("67C38633-89CE-4287-9063-086A3A6BA3EB");
iSpace.SetGridData(resultB7B829491EE0475F95DEBBD6269FEDBF,result67C3863389CE42879063086A3A6BA3EB,"MG_TaskSummary",ref ISpace);
iSpace.UpdateGridBindDetails("MG_TaskSummary",result67C3863389CE42879063086A3A6BA3EB);
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC GetUserRequestStatisticsWithFilters 1,'@@gv_UserId','#M_ModuleId','#SubFilter'");

var querySource6A417071941C4F7BA9BB3267F3ED0C08 =GetQueryExpressionDataSource("6A417071-941C-4F7B-A9BB-3267F3ED0C08");
Dictionary<short,object> result6A417071941C4F7BA9BB3267F3ED0C08=iSpace.ExecuteQuery(querySource6A417071941C4F7BA9BB3267F3ED0C08,@"EXEC GetUserRequestStatisticsWithFilters 1,'" + ISpace["gv_userid"].Value + @"','" + ISpace["M_ModuleId"].Value + @"','" + ISpace["SubFilter"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource6A417071941C4F7BA9BB3267F3ED0C08 =GetQueryExpressionDataSource(""6A417071-941C-4F7B-A9BB-3267F3ED0C08"");Dictionary<short,object> result6A417071941C4F7BA9BB3267F3ED0C08=iSpace.ExecuteQuery(querySource6A417071941C4F7BA9BB3267F3ED0C08,@""EXEC GetUserRequestStatisticsWithFilters 1,'"" + ISpace[""gv_userid""].Value + @""','"" + ISpace[""M_ModuleId""].Value + @""','"" + ISpace[""SubFilter""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result6A417071941C4F7BA9BB3267F3ED0C08!=null) && (result6A417071941C4F7BA9BB3267F3ED0C08.Count!=0))
{
if(result6A417071941C4F7BA9BB3267F3ED0C08.ContainsKey(0))
ISpace["M_InitiatedInprogress"].Value = result6A417071941C4F7BA9BB3267F3ED0C08[0];
if(result6A417071941C4F7BA9BB3267F3ED0C08.ContainsKey(1))
ISpace["M_InitiatedCompleted"].Value = result6A417071941C4F7BA9BB3267F3ED0C08[1];
if(result6A417071941C4F7BA9BB3267F3ED0C08.ContainsKey(2))
ISpace["M_ParticipatedInProgress"].Value = result6A417071941C4F7BA9BB3267F3ED0C08[2];
if(result6A417071941C4F7BA9BB3267F3ED0C08.ContainsKey(3))
ISpace["M_ParticipatedCompleted"].Value = result6A417071941C4F7BA9BB3267F3ED0C08[3];
}
else{
ISpace["M_InitiatedInprogress"].Value = null;ISpace["M_InitiatedCompleted"].Value = null;ISpace["M_ParticipatedInProgress"].Value = null;ISpace["M_ParticipatedCompleted"].Value = null;
}
}
if(ISpace["FormVersionId"].Value=="1AA5B3E2-9DA8-490E-B860-328F504DFF0D")
{
ISpace["UI_ViewHistory"].Visible="false";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""1AA5B3E2-9DA8-490E-B860-328F504DFF0D"")
{
ISpace[""UI_ViewHistory""].Visible=""false"";
}");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_m_participatedinprogressbtn (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"M_ParticipatedInProgressBtn-OnClick");
ISpace["M_CurrentStatus"].Value="Participated-Pending";
base.WriteDebugInfo(@"ISpace[""M_CurrentStatus""].Value=""Participated-Pending"";");
if(IsNullOrEmpty(ISpace["M_CurrentStatus"].Value))
{
base.WriteDebugInfo(@"if(IsNullOrEmpty(ISpace[""M_CurrentStatus""].Value))");
ISpace["M_CurrentStatus"].Value="Initiated-Pending";
base.WriteDebugInfo(@"ISpace[""M_CurrentStatus""].Value=""Initiated-Pending"";");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC [dbo].usp_BuildDynamicTaskFilter '#F_TaskName','#F_InitiatedBy','#F_InitiatedStartDate','#F_InitiatedEndDate','#F_Level','#F_CurrentStatus','#F_ProcessName'");

var querySourceF1A1836CA83A4FAB9F41BB56E85274EE =GetQueryExpressionDataSource("F1A1836C-A83A-4FAB-9F41-BB56E85274EE");
Dictionary<short,object> resultF1A1836CA83A4FAB9F41BB56E85274EE=iSpace.ExecuteQuery(querySourceF1A1836CA83A4FAB9F41BB56E85274EE,@"EXEC [dbo].usp_BuildDynamicTaskFilter '" + ISpace["F_TaskName"].Value + @"','" + ISpace["F_InitiatedBy"].Value + @"','" + ISpace["F_InitiatedStartDate"].Value + @"','" + ISpace["F_InitiatedEndDate"].Value + @"','" + ISpace["F_Level"].Value + @"','" + ISpace["F_CurrentStatus"].Value + @"','" + ISpace["F_ProcessName"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceF1A1836CA83A4FAB9F41BB56E85274EE =GetQueryExpressionDataSource(""F1A1836C-A83A-4FAB-9F41-BB56E85274EE"");Dictionary<short,object> resultF1A1836CA83A4FAB9F41BB56E85274EE=iSpace.ExecuteQuery(querySourceF1A1836CA83A4FAB9F41BB56E85274EE,@""EXEC [dbo].usp_BuildDynamicTaskFilter '"" + ISpace[""F_TaskName""].Value + @""','"" + ISpace[""F_InitiatedBy""].Value + @""','"" + ISpace[""F_InitiatedStartDate""].Value + @""','"" + ISpace[""F_InitiatedEndDate""].Value + @""','"" + ISpace[""F_Level""].Value + @""','"" + ISpace[""F_CurrentStatus""].Value + @""','"" + ISpace[""F_ProcessName""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultF1A1836CA83A4FAB9F41BB56E85274EE!=null) && (resultF1A1836CA83A4FAB9F41BB56E85274EE.Count!=0))
{
if(resultF1A1836CA83A4FAB9F41BB56E85274EE.ContainsKey(0))
ISpace["SubFilter"].Value = resultF1A1836CA83A4FAB9F41BB56E85274EE[0];
}
else{
ISpace["SubFilter"].Value = null;
}
ISpace["SubFilter"].Value=Replace(ISpace["SubFIlter"].Value,"'","''");
base.WriteDebugInfo(@"ISpace[""SubFilter""].Value=Replace(ISpace[""SubFIlter""].Value,""'"",""''"");");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC dbo.[GetUserRequestSummaryWithFilters] 0,@@gv_UserId,'#M_ModuleId','#M_CurrentStatus','#SubFilter','',#MF_TaskSummary_PageIndex,'#MF_TaskSummary_GridRows'");

var querySourceE55DE8B65604401D9FA50372DE5D3A21 =GetQueryExpressionDataSource("E55DE8B6-5604-401D-9FA5-0372DE5D3A21");
Dictionary<short,object> resultE55DE8B65604401D9FA50372DE5D3A21=iSpace.ExecuteQuery(querySourceE55DE8B65604401D9FA50372DE5D3A21,@"EXEC dbo.[GetUserRequestSummaryWithFilters] 0," + ISpace["gv_userid"].Value + @",'" + ISpace["M_ModuleId"].Value + @"','" + ISpace["M_CurrentStatus"].Value + @"','" + ISpace["SubFilter"].Value + @"',''," + ISpace["MF_TaskSummary_PageIndex"].Value + @",'" + ISpace["MF_TaskSummary_GridRows"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceE55DE8B65604401D9FA50372DE5D3A21 =GetQueryExpressionDataSource(""E55DE8B6-5604-401D-9FA5-0372DE5D3A21"");Dictionary<short,object> resultE55DE8B65604401D9FA50372DE5D3A21=iSpace.ExecuteQuery(querySourceE55DE8B65604401D9FA50372DE5D3A21,@""EXEC dbo.[GetUserRequestSummaryWithFilters] 0,"" + ISpace[""gv_userid""].Value + @"",'"" + ISpace[""M_ModuleId""].Value + @""','"" + ISpace[""M_CurrentStatus""].Value + @""','"" + ISpace[""SubFilter""].Value + @""','',"" + ISpace[""MF_TaskSummary_PageIndex""].Value + @"",'"" + ISpace[""MF_TaskSummary_GridRows""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultE55DE8B65604401D9FA50372DE5D3A21!=null) && (resultE55DE8B65604401D9FA50372DE5D3A21.Count!=0))
{
if(resultE55DE8B65604401D9FA50372DE5D3A21.ContainsKey(0))
ISpace["MF_TaskSummary_GridRows"].Value = resultE55DE8B65604401D9FA50372DE5D3A21[0];
if(resultE55DE8B65604401D9FA50372DE5D3A21.ContainsKey(3))
ISpace["MF_TaskSummary_TotalPages"].Value = resultE55DE8B65604401D9FA50372DE5D3A21[3];
if(resultE55DE8B65604401D9FA50372DE5D3A21.ContainsKey(2))
ISpace["MF_TaskSummary_PageIndex"].Value = resultE55DE8B65604401D9FA50372DE5D3A21[2];
if(resultE55DE8B65604401D9FA50372DE5D3A21.ContainsKey(1))
ISpace["MF_TaskSummary_RecordsRange"].Value = resultE55DE8B65604401D9FA50372DE5D3A21[1];
}
else{
ISpace["MF_TaskSummary_GridRows"].Value = null;ISpace["MF_TaskSummary_TotalPages"].Value = null;ISpace["MF_TaskSummary_PageIndex"].Value = null;ISpace["MF_TaskSummary_RecordsRange"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_TaskSummary_PageIndex"].Value==1||ISpace["MF_TaskSummary_PageIndex"].Value==0)
{
base.WriteDebugInfo(@"if(ISpace[""MF_TaskSummary_PageIndex""].Value==1||ISpace[""MF_TaskSummary_PageIndex""].Value==0)");
if(ISpace["MF_TaskSummary_PageIndex"].Value==ISpace["MF_TaskSummary_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_TaskSummary_PageIndex""].Value==ISpace[""MF_TaskSummary_TotalPages""].Value)");
ISpace["MF_TaskSummary_FirstButton"].Enbl="false";ISpace["MF_TaskSummary_LastButton"].Enbl="false";ISpace["MF_TaskSummary_PageIndex"].Enbl="false";ISpace["MF_TaskSummary_NextButton"].Enbl="false";ISpace["MF_TaskSummary_PrevButton"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MF_TaskSummary_FirstButton""].Enbl=""false"";ISpace[""MF_TaskSummary_LastButton""].Enbl=""false"";ISpace[""MF_TaskSummary_PageIndex""].Enbl=""false"";ISpace[""MF_TaskSummary_NextButton""].Enbl=""false"";ISpace[""MF_TaskSummary_PrevButton""].Enbl=""false"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_TaskSummary_FirstButton"].Enbl="false";ISpace["MF_TaskSummary_LastButton"].Enbl="true";ISpace["MF_TaskSummary_PageIndex"].Enbl="true";ISpace["MF_TaskSummary_NextButton"].Enbl="true";ISpace["MF_TaskSummary_PrevButton"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MF_TaskSummary_FirstButton""].Enbl=""false"";ISpace[""MF_TaskSummary_LastButton""].Enbl=""true"";ISpace[""MF_TaskSummary_PageIndex""].Enbl=""true"";ISpace[""MF_TaskSummary_NextButton""].Enbl=""true"";ISpace[""MF_TaskSummary_PrevButton""].Enbl=""false"";");
}
}
else
{
base.WriteDebugInfo(@"else");
if(ISpace["MF_TaskSummary_PageIndex"].Value==ISpace["MF_TaskSummary_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_TaskSummary_PageIndex""].Value==ISpace[""MF_TaskSummary_TotalPages""].Value)");
ISpace["MF_TaskSummary_FirstButton"].Enbl="true";ISpace["MF_TaskSummary_LastButton"].Enbl="false";ISpace["MF_TaskSummary_PageIndex"].Enbl="true";ISpace["MF_TaskSummary_NextButton"].Enbl="false";ISpace["MF_TaskSummary_PrevButton"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_TaskSummary_FirstButton""].Enbl=""true"";ISpace[""MF_TaskSummary_LastButton""].Enbl=""false"";ISpace[""MF_TaskSummary_PageIndex""].Enbl=""true"";ISpace[""MF_TaskSummary_NextButton""].Enbl=""false"";ISpace[""MF_TaskSummary_PrevButton""].Enbl=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_TaskSummary_FirstButton"].Enbl="true";ISpace["MF_TaskSummary_LastButton"].Enbl="true";ISpace["MF_TaskSummary_PageIndex"].Enbl="true";ISpace["MF_TaskSummary_NextButton"].Enbl="true";ISpace["MF_TaskSummary_PrevButton"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_TaskSummary_FirstButton""].Enbl=""true"";ISpace[""MF_TaskSummary_LastButton""].Enbl=""true"";ISpace[""MF_TaskSummary_PageIndex""].Enbl=""true"";ISpace[""MF_TaskSummary_NextButton""].Enbl=""true"";ISpace[""MF_TaskSummary_PrevButton""].Enbl=""true"";");
}
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySourceB7B829491EE0475F95DEBBD6269FEDBF =GetQueryExpressionDataSource("B7B82949-1EE0-475F-95DE-BBD6269FEDBF");

DataTable resultB7B829491EE0475F95DEBBD6269FEDBF=iSpace.SetGridDataSource(querySourceB7B829491EE0475F95DEBBD6269FEDBF, _objectFactory.GetGridRPP("MG_TaskSummary"),@"EXEC dbo.[GetUserRequestSummaryWithFilters] 1," + ISpace["gv_userid"].Value + @",'" + ISpace["M_ModuleId"].Value + @"','" + ISpace["M_CurrentStatus"].Value + @"','" + ISpace["SubFilter"].Value + @"',''," + ISpace["MF_TaskSummary_PageIndex"].Value + @",'" + ISpace["MF_TaskSummary_GridRows"].Value + @"'");

iSpace.InsertGridBindDetails("MG_TaskSummary","11",querySourceB7B829491EE0475F95DEBBD6269FEDBF,"EXEC dbo.[GetUserRequestSummaryWithFilters] 1," + ISpace["gv_userid"].Value + @",'" + ISpace["M_ModuleId"].Value + @"','" + ISpace["M_CurrentStatus"].Value + @"','" + ISpace["SubFilter"].Value + @"',''," + ISpace["MF_TaskSummary_PageIndex"].Value + @",'" + ISpace["MF_TaskSummary_GridRows"].Value + @"'",_objectFactory.GetGridRPP("MG_TaskSummary"));

base.WriteDebugInfo(@"var querySourceB7B829491EE0475F95DEBBD6269FEDBF =GetQueryExpressionDataSource(""B7B82949-1EE0-475F-95DE-BBD6269FEDBF"");DataTable resultB7B829491EE0475F95DEBBD6269FEDBF=iSpace.SetGridDataSource(querySourceB7B829491EE0475F95DEBBD6269FEDBF, _objectFactory.GetGridRPP(""MG_TaskSummary""),@""EXEC dbo.[GetUserRequestSummaryWithFilters] 1,"" + ISpace[""gv_userid""].Value + @"",'"" + ISpace[""M_ModuleId""].Value + @""','"" + ISpace[""M_CurrentStatus""].Value + @""','"" + ISpace[""SubFilter""].Value + @""','',"" + ISpace[""MF_TaskSummary_PageIndex""].Value + @"",'"" + ISpace[""MF_TaskSummary_GridRows""].Value + @""'"");iSpace.InsertGridBindDetails(""MG_TaskSummary"",""11"",querySourceB7B829491EE0475F95DEBBD6269FEDBF,""EXEC dbo.[GetUserRequestSummaryWithFilters] 1,"" + ISpace[""gv_userid""].Value + @"",'"" + ISpace[""M_ModuleId""].Value + @""','"" + ISpace[""M_CurrentStatus""].Value + @""','"" + ISpace[""SubFilter""].Value + @""','',"" + ISpace[""MF_TaskSummary_PageIndex""].Value + @"",'"" + ISpace[""MF_TaskSummary_GridRows""].Value + @""'"",_objectFactory.GetGridRPP(""MG_TaskSummary""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result67C3863389CE42879063086A3A6BA3EB=acdataIspace2EC4031088B94E21AD43FA1B94EBF785.GetQueryExpressionBindings("67C38633-89CE-4287-9063-086A3A6BA3EB");
iSpace.SetGridData(resultB7B829491EE0475F95DEBBD6269FEDBF,result67C3863389CE42879063086A3A6BA3EB,"MG_TaskSummary",ref ISpace);
iSpace.UpdateGridBindDetails("MG_TaskSummary",result67C3863389CE42879063086A3A6BA3EB);
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_m_icbutton (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"M_ICButton-OnClick");
ISpace["M_CurrentStatus"].Value="Initiated-Completed";
base.WriteDebugInfo(@"ISpace[""M_CurrentStatus""].Value=""Initiated-Completed"";");
if(IsNullOrEmpty(ISpace["M_CurrentStatus"].Value))
{
base.WriteDebugInfo(@"if(IsNullOrEmpty(ISpace[""M_CurrentStatus""].Value))");
ISpace["M_CurrentStatus"].Value="Initiated-Pending";
base.WriteDebugInfo(@"ISpace[""M_CurrentStatus""].Value=""Initiated-Pending"";");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC [dbo].usp_BuildDynamicTaskFilter '#F_TaskName','#F_InitiatedBy','#F_InitiatedStartDate','#F_InitiatedEndDate','#F_Level','#F_CurrentStatus','#F_ProcessName'");

var querySourceF1A1836CA83A4FAB9F41BB56E85274EE =GetQueryExpressionDataSource("F1A1836C-A83A-4FAB-9F41-BB56E85274EE");
Dictionary<short,object> resultF1A1836CA83A4FAB9F41BB56E85274EE=iSpace.ExecuteQuery(querySourceF1A1836CA83A4FAB9F41BB56E85274EE,@"EXEC [dbo].usp_BuildDynamicTaskFilter '" + ISpace["F_TaskName"].Value + @"','" + ISpace["F_InitiatedBy"].Value + @"','" + ISpace["F_InitiatedStartDate"].Value + @"','" + ISpace["F_InitiatedEndDate"].Value + @"','" + ISpace["F_Level"].Value + @"','" + ISpace["F_CurrentStatus"].Value + @"','" + ISpace["F_ProcessName"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceF1A1836CA83A4FAB9F41BB56E85274EE =GetQueryExpressionDataSource(""F1A1836C-A83A-4FAB-9F41-BB56E85274EE"");Dictionary<short,object> resultF1A1836CA83A4FAB9F41BB56E85274EE=iSpace.ExecuteQuery(querySourceF1A1836CA83A4FAB9F41BB56E85274EE,@""EXEC [dbo].usp_BuildDynamicTaskFilter '"" + ISpace[""F_TaskName""].Value + @""','"" + ISpace[""F_InitiatedBy""].Value + @""','"" + ISpace[""F_InitiatedStartDate""].Value + @""','"" + ISpace[""F_InitiatedEndDate""].Value + @""','"" + ISpace[""F_Level""].Value + @""','"" + ISpace[""F_CurrentStatus""].Value + @""','"" + ISpace[""F_ProcessName""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultF1A1836CA83A4FAB9F41BB56E85274EE!=null) && (resultF1A1836CA83A4FAB9F41BB56E85274EE.Count!=0))
{
if(resultF1A1836CA83A4FAB9F41BB56E85274EE.ContainsKey(0))
ISpace["SubFilter"].Value = resultF1A1836CA83A4FAB9F41BB56E85274EE[0];
}
else{
ISpace["SubFilter"].Value = null;
}
ISpace["SubFilter"].Value=Replace(ISpace["SubFIlter"].Value,"'","''");
base.WriteDebugInfo(@"ISpace[""SubFilter""].Value=Replace(ISpace[""SubFIlter""].Value,""'"",""''"");");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC dbo.[GetUserRequestSummaryWithFilters] 0,@@gv_UserId,'#M_ModuleId','#M_CurrentStatus','#SubFilter','',#MF_TaskSummary_PageIndex,'#MF_TaskSummary_GridRows'");

var querySourceE55DE8B65604401D9FA50372DE5D3A21 =GetQueryExpressionDataSource("E55DE8B6-5604-401D-9FA5-0372DE5D3A21");
Dictionary<short,object> resultE55DE8B65604401D9FA50372DE5D3A21=iSpace.ExecuteQuery(querySourceE55DE8B65604401D9FA50372DE5D3A21,@"EXEC dbo.[GetUserRequestSummaryWithFilters] 0," + ISpace["gv_userid"].Value + @",'" + ISpace["M_ModuleId"].Value + @"','" + ISpace["M_CurrentStatus"].Value + @"','" + ISpace["SubFilter"].Value + @"',''," + ISpace["MF_TaskSummary_PageIndex"].Value + @",'" + ISpace["MF_TaskSummary_GridRows"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceE55DE8B65604401D9FA50372DE5D3A21 =GetQueryExpressionDataSource(""E55DE8B6-5604-401D-9FA5-0372DE5D3A21"");Dictionary<short,object> resultE55DE8B65604401D9FA50372DE5D3A21=iSpace.ExecuteQuery(querySourceE55DE8B65604401D9FA50372DE5D3A21,@""EXEC dbo.[GetUserRequestSummaryWithFilters] 0,"" + ISpace[""gv_userid""].Value + @"",'"" + ISpace[""M_ModuleId""].Value + @""','"" + ISpace[""M_CurrentStatus""].Value + @""','"" + ISpace[""SubFilter""].Value + @""','',"" + ISpace[""MF_TaskSummary_PageIndex""].Value + @"",'"" + ISpace[""MF_TaskSummary_GridRows""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultE55DE8B65604401D9FA50372DE5D3A21!=null) && (resultE55DE8B65604401D9FA50372DE5D3A21.Count!=0))
{
if(resultE55DE8B65604401D9FA50372DE5D3A21.ContainsKey(0))
ISpace["MF_TaskSummary_GridRows"].Value = resultE55DE8B65604401D9FA50372DE5D3A21[0];
if(resultE55DE8B65604401D9FA50372DE5D3A21.ContainsKey(3))
ISpace["MF_TaskSummary_TotalPages"].Value = resultE55DE8B65604401D9FA50372DE5D3A21[3];
if(resultE55DE8B65604401D9FA50372DE5D3A21.ContainsKey(2))
ISpace["MF_TaskSummary_PageIndex"].Value = resultE55DE8B65604401D9FA50372DE5D3A21[2];
if(resultE55DE8B65604401D9FA50372DE5D3A21.ContainsKey(1))
ISpace["MF_TaskSummary_RecordsRange"].Value = resultE55DE8B65604401D9FA50372DE5D3A21[1];
}
else{
ISpace["MF_TaskSummary_GridRows"].Value = null;ISpace["MF_TaskSummary_TotalPages"].Value = null;ISpace["MF_TaskSummary_PageIndex"].Value = null;ISpace["MF_TaskSummary_RecordsRange"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_TaskSummary_PageIndex"].Value==1||ISpace["MF_TaskSummary_PageIndex"].Value==0)
{
base.WriteDebugInfo(@"if(ISpace[""MF_TaskSummary_PageIndex""].Value==1||ISpace[""MF_TaskSummary_PageIndex""].Value==0)");
if(ISpace["MF_TaskSummary_PageIndex"].Value==ISpace["MF_TaskSummary_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_TaskSummary_PageIndex""].Value==ISpace[""MF_TaskSummary_TotalPages""].Value)");
ISpace["MF_TaskSummary_FirstButton"].Enbl="false";ISpace["MF_TaskSummary_LastButton"].Enbl="false";ISpace["MF_TaskSummary_PageIndex"].Enbl="false";ISpace["MF_TaskSummary_NextButton"].Enbl="false";ISpace["MF_TaskSummary_PrevButton"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MF_TaskSummary_FirstButton""].Enbl=""false"";ISpace[""MF_TaskSummary_LastButton""].Enbl=""false"";ISpace[""MF_TaskSummary_PageIndex""].Enbl=""false"";ISpace[""MF_TaskSummary_NextButton""].Enbl=""false"";ISpace[""MF_TaskSummary_PrevButton""].Enbl=""false"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_TaskSummary_FirstButton"].Enbl="false";ISpace["MF_TaskSummary_LastButton"].Enbl="true";ISpace["MF_TaskSummary_PageIndex"].Enbl="true";ISpace["MF_TaskSummary_NextButton"].Enbl="true";ISpace["MF_TaskSummary_PrevButton"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MF_TaskSummary_FirstButton""].Enbl=""false"";ISpace[""MF_TaskSummary_LastButton""].Enbl=""true"";ISpace[""MF_TaskSummary_PageIndex""].Enbl=""true"";ISpace[""MF_TaskSummary_NextButton""].Enbl=""true"";ISpace[""MF_TaskSummary_PrevButton""].Enbl=""false"";");
}
}
else
{
base.WriteDebugInfo(@"else");
if(ISpace["MF_TaskSummary_PageIndex"].Value==ISpace["MF_TaskSummary_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_TaskSummary_PageIndex""].Value==ISpace[""MF_TaskSummary_TotalPages""].Value)");
ISpace["MF_TaskSummary_FirstButton"].Enbl="true";ISpace["MF_TaskSummary_LastButton"].Enbl="false";ISpace["MF_TaskSummary_PageIndex"].Enbl="true";ISpace["MF_TaskSummary_NextButton"].Enbl="false";ISpace["MF_TaskSummary_PrevButton"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_TaskSummary_FirstButton""].Enbl=""true"";ISpace[""MF_TaskSummary_LastButton""].Enbl=""false"";ISpace[""MF_TaskSummary_PageIndex""].Enbl=""true"";ISpace[""MF_TaskSummary_NextButton""].Enbl=""false"";ISpace[""MF_TaskSummary_PrevButton""].Enbl=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_TaskSummary_FirstButton"].Enbl="true";ISpace["MF_TaskSummary_LastButton"].Enbl="true";ISpace["MF_TaskSummary_PageIndex"].Enbl="true";ISpace["MF_TaskSummary_NextButton"].Enbl="true";ISpace["MF_TaskSummary_PrevButton"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_TaskSummary_FirstButton""].Enbl=""true"";ISpace[""MF_TaskSummary_LastButton""].Enbl=""true"";ISpace[""MF_TaskSummary_PageIndex""].Enbl=""true"";ISpace[""MF_TaskSummary_NextButton""].Enbl=""true"";ISpace[""MF_TaskSummary_PrevButton""].Enbl=""true"";");
}
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySourceB7B829491EE0475F95DEBBD6269FEDBF =GetQueryExpressionDataSource("B7B82949-1EE0-475F-95DE-BBD6269FEDBF");

DataTable resultB7B829491EE0475F95DEBBD6269FEDBF=iSpace.SetGridDataSource(querySourceB7B829491EE0475F95DEBBD6269FEDBF, _objectFactory.GetGridRPP("MG_TaskSummary"),@"EXEC dbo.[GetUserRequestSummaryWithFilters] 1," + ISpace["gv_userid"].Value + @",'" + ISpace["M_ModuleId"].Value + @"','" + ISpace["M_CurrentStatus"].Value + @"','" + ISpace["SubFilter"].Value + @"',''," + ISpace["MF_TaskSummary_PageIndex"].Value + @",'" + ISpace["MF_TaskSummary_GridRows"].Value + @"'");

iSpace.InsertGridBindDetails("MG_TaskSummary","11",querySourceB7B829491EE0475F95DEBBD6269FEDBF,"EXEC dbo.[GetUserRequestSummaryWithFilters] 1," + ISpace["gv_userid"].Value + @",'" + ISpace["M_ModuleId"].Value + @"','" + ISpace["M_CurrentStatus"].Value + @"','" + ISpace["SubFilter"].Value + @"',''," + ISpace["MF_TaskSummary_PageIndex"].Value + @",'" + ISpace["MF_TaskSummary_GridRows"].Value + @"'",_objectFactory.GetGridRPP("MG_TaskSummary"));

base.WriteDebugInfo(@"var querySourceB7B829491EE0475F95DEBBD6269FEDBF =GetQueryExpressionDataSource(""B7B82949-1EE0-475F-95DE-BBD6269FEDBF"");DataTable resultB7B829491EE0475F95DEBBD6269FEDBF=iSpace.SetGridDataSource(querySourceB7B829491EE0475F95DEBBD6269FEDBF, _objectFactory.GetGridRPP(""MG_TaskSummary""),@""EXEC dbo.[GetUserRequestSummaryWithFilters] 1,"" + ISpace[""gv_userid""].Value + @"",'"" + ISpace[""M_ModuleId""].Value + @""','"" + ISpace[""M_CurrentStatus""].Value + @""','"" + ISpace[""SubFilter""].Value + @""','',"" + ISpace[""MF_TaskSummary_PageIndex""].Value + @"",'"" + ISpace[""MF_TaskSummary_GridRows""].Value + @""'"");iSpace.InsertGridBindDetails(""MG_TaskSummary"",""11"",querySourceB7B829491EE0475F95DEBBD6269FEDBF,""EXEC dbo.[GetUserRequestSummaryWithFilters] 1,"" + ISpace[""gv_userid""].Value + @"",'"" + ISpace[""M_ModuleId""].Value + @""','"" + ISpace[""M_CurrentStatus""].Value + @""','"" + ISpace[""SubFilter""].Value + @""','',"" + ISpace[""MF_TaskSummary_PageIndex""].Value + @"",'"" + ISpace[""MF_TaskSummary_GridRows""].Value + @""'"",_objectFactory.GetGridRPP(""MG_TaskSummary""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result67C3863389CE42879063086A3A6BA3EB=acdataIspace2EC4031088B94E21AD43FA1B94EBF785.GetQueryExpressionBindings("67C38633-89CE-4287-9063-086A3A6BA3EB");
iSpace.SetGridData(resultB7B829491EE0475F95DEBBD6269FEDBF,result67C3863389CE42879063086A3A6BA3EB,"MG_TaskSummary",ref ISpace);
iSpace.UpdateGridBindDetails("MG_TaskSummary",result67C3863389CE42879063086A3A6BA3EB);
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mf_tasksummary_firstbutton (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MF_TaskSummary_FirstButton-OnClick");
ISpace["MF_TaskSummary_PageIndex"].Value=1;
base.WriteDebugInfo(@"ISpace[""MF_TaskSummary_PageIndex""].Value=1;");
if(IsNullOrEmpty(ISpace["M_CurrentStatus"].Value))
{
base.WriteDebugInfo(@"if(IsNullOrEmpty(ISpace[""M_CurrentStatus""].Value))");
ISpace["M_CurrentStatus"].Value="Initiated-Pending";
base.WriteDebugInfo(@"ISpace[""M_CurrentStatus""].Value=""Initiated-Pending"";");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC [dbo].usp_BuildDynamicTaskFilter '#F_TaskName','#F_InitiatedBy','#F_InitiatedStartDate','#F_InitiatedEndDate','#F_Level','#F_CurrentStatus','#F_ProcessName'");

var querySourceF1A1836CA83A4FAB9F41BB56E85274EE =GetQueryExpressionDataSource("F1A1836C-A83A-4FAB-9F41-BB56E85274EE");
Dictionary<short,object> resultF1A1836CA83A4FAB9F41BB56E85274EE=iSpace.ExecuteQuery(querySourceF1A1836CA83A4FAB9F41BB56E85274EE,@"EXEC [dbo].usp_BuildDynamicTaskFilter '" + ISpace["F_TaskName"].Value + @"','" + ISpace["F_InitiatedBy"].Value + @"','" + ISpace["F_InitiatedStartDate"].Value + @"','" + ISpace["F_InitiatedEndDate"].Value + @"','" + ISpace["F_Level"].Value + @"','" + ISpace["F_CurrentStatus"].Value + @"','" + ISpace["F_ProcessName"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceF1A1836CA83A4FAB9F41BB56E85274EE =GetQueryExpressionDataSource(""F1A1836C-A83A-4FAB-9F41-BB56E85274EE"");Dictionary<short,object> resultF1A1836CA83A4FAB9F41BB56E85274EE=iSpace.ExecuteQuery(querySourceF1A1836CA83A4FAB9F41BB56E85274EE,@""EXEC [dbo].usp_BuildDynamicTaskFilter '"" + ISpace[""F_TaskName""].Value + @""','"" + ISpace[""F_InitiatedBy""].Value + @""','"" + ISpace[""F_InitiatedStartDate""].Value + @""','"" + ISpace[""F_InitiatedEndDate""].Value + @""','"" + ISpace[""F_Level""].Value + @""','"" + ISpace[""F_CurrentStatus""].Value + @""','"" + ISpace[""F_ProcessName""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultF1A1836CA83A4FAB9F41BB56E85274EE!=null) && (resultF1A1836CA83A4FAB9F41BB56E85274EE.Count!=0))
{
if(resultF1A1836CA83A4FAB9F41BB56E85274EE.ContainsKey(0))
ISpace["SubFilter"].Value = resultF1A1836CA83A4FAB9F41BB56E85274EE[0];
}
else{
ISpace["SubFilter"].Value = null;
}
ISpace["SubFilter"].Value=Replace(ISpace["SubFIlter"].Value,"'","''");
base.WriteDebugInfo(@"ISpace[""SubFilter""].Value=Replace(ISpace[""SubFIlter""].Value,""'"",""''"");");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC dbo.[GetUserRequestSummaryWithFilters] 0,@@gv_UserId,'#M_ModuleId','#M_CurrentStatus','#SubFilter','',#MF_TaskSummary_PageIndex,'#MF_TaskSummary_GridRows'");

var querySourceE55DE8B65604401D9FA50372DE5D3A21 =GetQueryExpressionDataSource("E55DE8B6-5604-401D-9FA5-0372DE5D3A21");
Dictionary<short,object> resultE55DE8B65604401D9FA50372DE5D3A21=iSpace.ExecuteQuery(querySourceE55DE8B65604401D9FA50372DE5D3A21,@"EXEC dbo.[GetUserRequestSummaryWithFilters] 0," + ISpace["gv_userid"].Value + @",'" + ISpace["M_ModuleId"].Value + @"','" + ISpace["M_CurrentStatus"].Value + @"','" + ISpace["SubFilter"].Value + @"',''," + ISpace["MF_TaskSummary_PageIndex"].Value + @",'" + ISpace["MF_TaskSummary_GridRows"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceE55DE8B65604401D9FA50372DE5D3A21 =GetQueryExpressionDataSource(""E55DE8B6-5604-401D-9FA5-0372DE5D3A21"");Dictionary<short,object> resultE55DE8B65604401D9FA50372DE5D3A21=iSpace.ExecuteQuery(querySourceE55DE8B65604401D9FA50372DE5D3A21,@""EXEC dbo.[GetUserRequestSummaryWithFilters] 0,"" + ISpace[""gv_userid""].Value + @"",'"" + ISpace[""M_ModuleId""].Value + @""','"" + ISpace[""M_CurrentStatus""].Value + @""','"" + ISpace[""SubFilter""].Value + @""','',"" + ISpace[""MF_TaskSummary_PageIndex""].Value + @"",'"" + ISpace[""MF_TaskSummary_GridRows""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultE55DE8B65604401D9FA50372DE5D3A21!=null) && (resultE55DE8B65604401D9FA50372DE5D3A21.Count!=0))
{
if(resultE55DE8B65604401D9FA50372DE5D3A21.ContainsKey(0))
ISpace["MF_TaskSummary_GridRows"].Value = resultE55DE8B65604401D9FA50372DE5D3A21[0];
if(resultE55DE8B65604401D9FA50372DE5D3A21.ContainsKey(3))
ISpace["MF_TaskSummary_TotalPages"].Value = resultE55DE8B65604401D9FA50372DE5D3A21[3];
if(resultE55DE8B65604401D9FA50372DE5D3A21.ContainsKey(2))
ISpace["MF_TaskSummary_PageIndex"].Value = resultE55DE8B65604401D9FA50372DE5D3A21[2];
if(resultE55DE8B65604401D9FA50372DE5D3A21.ContainsKey(1))
ISpace["MF_TaskSummary_RecordsRange"].Value = resultE55DE8B65604401D9FA50372DE5D3A21[1];
}
else{
ISpace["MF_TaskSummary_GridRows"].Value = null;ISpace["MF_TaskSummary_TotalPages"].Value = null;ISpace["MF_TaskSummary_PageIndex"].Value = null;ISpace["MF_TaskSummary_RecordsRange"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_TaskSummary_PageIndex"].Value==1||ISpace["MF_TaskSummary_PageIndex"].Value==0)
{
base.WriteDebugInfo(@"if(ISpace[""MF_TaskSummary_PageIndex""].Value==1||ISpace[""MF_TaskSummary_PageIndex""].Value==0)");
if(ISpace["MF_TaskSummary_PageIndex"].Value==ISpace["MF_TaskSummary_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_TaskSummary_PageIndex""].Value==ISpace[""MF_TaskSummary_TotalPages""].Value)");
ISpace["MF_TaskSummary_FirstButton"].Enbl="false";ISpace["MF_TaskSummary_LastButton"].Enbl="false";ISpace["MF_TaskSummary_PageIndex"].Enbl="false";ISpace["MF_TaskSummary_NextButton"].Enbl="false";ISpace["MF_TaskSummary_PrevButton"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MF_TaskSummary_FirstButton""].Enbl=""false"";ISpace[""MF_TaskSummary_LastButton""].Enbl=""false"";ISpace[""MF_TaskSummary_PageIndex""].Enbl=""false"";ISpace[""MF_TaskSummary_NextButton""].Enbl=""false"";ISpace[""MF_TaskSummary_PrevButton""].Enbl=""false"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_TaskSummary_FirstButton"].Enbl="false";ISpace["MF_TaskSummary_LastButton"].Enbl="true";ISpace["MF_TaskSummary_PageIndex"].Enbl="true";ISpace["MF_TaskSummary_NextButton"].Enbl="true";ISpace["MF_TaskSummary_PrevButton"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MF_TaskSummary_FirstButton""].Enbl=""false"";ISpace[""MF_TaskSummary_LastButton""].Enbl=""true"";ISpace[""MF_TaskSummary_PageIndex""].Enbl=""true"";ISpace[""MF_TaskSummary_NextButton""].Enbl=""true"";ISpace[""MF_TaskSummary_PrevButton""].Enbl=""false"";");
}
}
else
{
base.WriteDebugInfo(@"else");
if(ISpace["MF_TaskSummary_PageIndex"].Value==ISpace["MF_TaskSummary_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_TaskSummary_PageIndex""].Value==ISpace[""MF_TaskSummary_TotalPages""].Value)");
ISpace["MF_TaskSummary_FirstButton"].Enbl="true";ISpace["MF_TaskSummary_LastButton"].Enbl="false";ISpace["MF_TaskSummary_PageIndex"].Enbl="true";ISpace["MF_TaskSummary_NextButton"].Enbl="false";ISpace["MF_TaskSummary_PrevButton"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_TaskSummary_FirstButton""].Enbl=""true"";ISpace[""MF_TaskSummary_LastButton""].Enbl=""false"";ISpace[""MF_TaskSummary_PageIndex""].Enbl=""true"";ISpace[""MF_TaskSummary_NextButton""].Enbl=""false"";ISpace[""MF_TaskSummary_PrevButton""].Enbl=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_TaskSummary_FirstButton"].Enbl="true";ISpace["MF_TaskSummary_LastButton"].Enbl="true";ISpace["MF_TaskSummary_PageIndex"].Enbl="true";ISpace["MF_TaskSummary_NextButton"].Enbl="true";ISpace["MF_TaskSummary_PrevButton"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_TaskSummary_FirstButton""].Enbl=""true"";ISpace[""MF_TaskSummary_LastButton""].Enbl=""true"";ISpace[""MF_TaskSummary_PageIndex""].Enbl=""true"";ISpace[""MF_TaskSummary_NextButton""].Enbl=""true"";ISpace[""MF_TaskSummary_PrevButton""].Enbl=""true"";");
}
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySourceB7B829491EE0475F95DEBBD6269FEDBF =GetQueryExpressionDataSource("B7B82949-1EE0-475F-95DE-BBD6269FEDBF");

DataTable resultB7B829491EE0475F95DEBBD6269FEDBF=iSpace.SetGridDataSource(querySourceB7B829491EE0475F95DEBBD6269FEDBF, _objectFactory.GetGridRPP("MG_TaskSummary"),@"EXEC dbo.[GetUserRequestSummaryWithFilters] 1," + ISpace["gv_userid"].Value + @",'" + ISpace["M_ModuleId"].Value + @"','" + ISpace["M_CurrentStatus"].Value + @"','" + ISpace["SubFilter"].Value + @"',''," + ISpace["MF_TaskSummary_PageIndex"].Value + @",'" + ISpace["MF_TaskSummary_GridRows"].Value + @"'");

iSpace.InsertGridBindDetails("MG_TaskSummary","11",querySourceB7B829491EE0475F95DEBBD6269FEDBF,"EXEC dbo.[GetUserRequestSummaryWithFilters] 1," + ISpace["gv_userid"].Value + @",'" + ISpace["M_ModuleId"].Value + @"','" + ISpace["M_CurrentStatus"].Value + @"','" + ISpace["SubFilter"].Value + @"',''," + ISpace["MF_TaskSummary_PageIndex"].Value + @",'" + ISpace["MF_TaskSummary_GridRows"].Value + @"'",_objectFactory.GetGridRPP("MG_TaskSummary"));

base.WriteDebugInfo(@"var querySourceB7B829491EE0475F95DEBBD6269FEDBF =GetQueryExpressionDataSource(""B7B82949-1EE0-475F-95DE-BBD6269FEDBF"");DataTable resultB7B829491EE0475F95DEBBD6269FEDBF=iSpace.SetGridDataSource(querySourceB7B829491EE0475F95DEBBD6269FEDBF, _objectFactory.GetGridRPP(""MG_TaskSummary""),@""EXEC dbo.[GetUserRequestSummaryWithFilters] 1,"" + ISpace[""gv_userid""].Value + @"",'"" + ISpace[""M_ModuleId""].Value + @""','"" + ISpace[""M_CurrentStatus""].Value + @""','"" + ISpace[""SubFilter""].Value + @""','',"" + ISpace[""MF_TaskSummary_PageIndex""].Value + @"",'"" + ISpace[""MF_TaskSummary_GridRows""].Value + @""'"");iSpace.InsertGridBindDetails(""MG_TaskSummary"",""11"",querySourceB7B829491EE0475F95DEBBD6269FEDBF,""EXEC dbo.[GetUserRequestSummaryWithFilters] 1,"" + ISpace[""gv_userid""].Value + @"",'"" + ISpace[""M_ModuleId""].Value + @""','"" + ISpace[""M_CurrentStatus""].Value + @""','"" + ISpace[""SubFilter""].Value + @""','',"" + ISpace[""MF_TaskSummary_PageIndex""].Value + @"",'"" + ISpace[""MF_TaskSummary_GridRows""].Value + @""'"",_objectFactory.GetGridRPP(""MG_TaskSummary""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result67C3863389CE42879063086A3A6BA3EB=acdataIspace2EC4031088B94E21AD43FA1B94EBF785.GetQueryExpressionBindings("67C38633-89CE-4287-9063-086A3A6BA3EB");
iSpace.SetGridData(resultB7B829491EE0475F95DEBBD6269FEDBF,result67C3863389CE42879063086A3A6BA3EB,"MG_TaskSummary",ref ISpace);
iSpace.UpdateGridBindDetails("MG_TaskSummary",result67C3863389CE42879063086A3A6BA3EB);
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_ui_viewhistory (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"UI_ViewHistory-OnClick");

if(ISpace["FormVersionId"].Value=="1AA5B3E2-9DA8-490E-B860-328F504DFF0D")
{
iSpace.SetUIControlProperty("UI_ViewHistory","ShowModal","true",ref  ISpace);;
}

base.WriteDebugInfo(@"
if(ISpace[""FormVersionId""].Value==""1AA5B3E2-9DA8-490E-B860-328F504DFF0D"")
{
iSpace.SetUIControlProperty(""UI_ViewHistory"",""ShowModal"",""true"",ref  ISpace);;
}
");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_ts_view (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"TS_View-OnClick");

if(ISpace["FormVersionId"].Value=="1AA5B3E2-9DA8-490E-B860-328F504DFF0D")
{
iSpace.SetUIControlProperty("UI_ViewHistory","ShowModal","true",ref  ISpace);;
}

base.WriteDebugInfo(@"
if(ISpace[""FormVersionId""].Value==""1AA5B3E2-9DA8-490E-B860-328F504DFF0D"")
{
iSpace.SetUIControlProperty(""UI_ViewHistory"",""ShowModal"",""true"",ref  ISpace);;
}
");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySource58D674A774A54DE1A9A8DFE425CA69B1 =GetQueryExpressionDataSource("58D674A7-74A5-4DE1-A9A8-DFE425CA69B1");

DataTable result58D674A774A54DE1A9A8DFE425CA69B1=iSpace.SetGridDataSource(querySource58D674A774A54DE1A9A8DFE425CA69B1, _objectFactory.GetGridRPP("MG_RemarksDetails"),@"EXEC GetRemarks '" + ISpace["TS_ID"].Value + @"'");

iSpace.InsertGridBindDetails("MG_RemarksDetails","11",querySource58D674A774A54DE1A9A8DFE425CA69B1,"EXEC GetRemarks '" + ISpace["TS_ID"].Value + @"'",_objectFactory.GetGridRPP("MG_RemarksDetails"));

base.WriteDebugInfo(@"var querySource58D674A774A54DE1A9A8DFE425CA69B1 =GetQueryExpressionDataSource(""58D674A7-74A5-4DE1-A9A8-DFE425CA69B1"");DataTable result58D674A774A54DE1A9A8DFE425CA69B1=iSpace.SetGridDataSource(querySource58D674A774A54DE1A9A8DFE425CA69B1, _objectFactory.GetGridRPP(""MG_RemarksDetails""),@""EXEC GetRemarks '"" + ISpace[""TS_ID""].Value + @""'"");iSpace.InsertGridBindDetails(""MG_RemarksDetails"",""11"",querySource58D674A774A54DE1A9A8DFE425CA69B1,""EXEC GetRemarks '"" + ISpace[""TS_ID""].Value + @""'"",_objectFactory.GetGridRPP(""MG_RemarksDetails""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result5C847AC568864D30BD57B524DFF277CD=acdataIspace2EC4031088B94E21AD43FA1B94EBF785.GetQueryExpressionBindings("5C847AC5-6886-4D30-BD57-B524DFF277CD");
iSpace.SetGridData(result58D674A774A54DE1A9A8DFE425CA69B1,result5C847AC568864D30BD57B524DFF277CD,"MG_RemarksDetails",ref ISpace);
iSpace.UpdateGridBindDetails("MG_RemarksDetails",result5C847AC568864D30BD57B524DFF277CD);
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mf_tasksummary_gridrows (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MF_TaskSummary_GridRows-OnChange");
ISpace["MF_Option"].Value=1;
base.WriteDebugInfo(@"ISpace[""MF_Option""].Value=1;");
if(IsNullOrEmpty(ISpace["M_CurrentStatus"].Value))
{
base.WriteDebugInfo(@"if(IsNullOrEmpty(ISpace[""M_CurrentStatus""].Value))");
ISpace["M_CurrentStatus"].Value="Initiated-Pending";
base.WriteDebugInfo(@"ISpace[""M_CurrentStatus""].Value=""Initiated-Pending"";");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC [dbo].usp_BuildDynamicTaskFilter '#F_TaskName','#F_InitiatedBy','#F_InitiatedStartDate','#F_InitiatedEndDate','#F_Level','#F_CurrentStatus','#F_ProcessName'");

var querySourceF1A1836CA83A4FAB9F41BB56E85274EE =GetQueryExpressionDataSource("F1A1836C-A83A-4FAB-9F41-BB56E85274EE");
Dictionary<short,object> resultF1A1836CA83A4FAB9F41BB56E85274EE=iSpace.ExecuteQuery(querySourceF1A1836CA83A4FAB9F41BB56E85274EE,@"EXEC [dbo].usp_BuildDynamicTaskFilter '" + ISpace["F_TaskName"].Value + @"','" + ISpace["F_InitiatedBy"].Value + @"','" + ISpace["F_InitiatedStartDate"].Value + @"','" + ISpace["F_InitiatedEndDate"].Value + @"','" + ISpace["F_Level"].Value + @"','" + ISpace["F_CurrentStatus"].Value + @"','" + ISpace["F_ProcessName"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceF1A1836CA83A4FAB9F41BB56E85274EE =GetQueryExpressionDataSource(""F1A1836C-A83A-4FAB-9F41-BB56E85274EE"");Dictionary<short,object> resultF1A1836CA83A4FAB9F41BB56E85274EE=iSpace.ExecuteQuery(querySourceF1A1836CA83A4FAB9F41BB56E85274EE,@""EXEC [dbo].usp_BuildDynamicTaskFilter '"" + ISpace[""F_TaskName""].Value + @""','"" + ISpace[""F_InitiatedBy""].Value + @""','"" + ISpace[""F_InitiatedStartDate""].Value + @""','"" + ISpace[""F_InitiatedEndDate""].Value + @""','"" + ISpace[""F_Level""].Value + @""','"" + ISpace[""F_CurrentStatus""].Value + @""','"" + ISpace[""F_ProcessName""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultF1A1836CA83A4FAB9F41BB56E85274EE!=null) && (resultF1A1836CA83A4FAB9F41BB56E85274EE.Count!=0))
{
if(resultF1A1836CA83A4FAB9F41BB56E85274EE.ContainsKey(0))
ISpace["SubFilter"].Value = resultF1A1836CA83A4FAB9F41BB56E85274EE[0];
}
else{
ISpace["SubFilter"].Value = null;
}
ISpace["SubFilter"].Value=Replace(ISpace["SubFIlter"].Value,"'","''");
base.WriteDebugInfo(@"ISpace[""SubFilter""].Value=Replace(ISpace[""SubFIlter""].Value,""'"",""''"");");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC dbo.[GetUserRequestSummaryWithFilters] 0,@@gv_UserId,'#M_ModuleId','#M_CurrentStatus','#SubFilter','',#MF_TaskSummary_PageIndex,'#MF_TaskSummary_GridRows'");

var querySourceE55DE8B65604401D9FA50372DE5D3A21 =GetQueryExpressionDataSource("E55DE8B6-5604-401D-9FA5-0372DE5D3A21");
Dictionary<short,object> resultE55DE8B65604401D9FA50372DE5D3A21=iSpace.ExecuteQuery(querySourceE55DE8B65604401D9FA50372DE5D3A21,@"EXEC dbo.[GetUserRequestSummaryWithFilters] 0," + ISpace["gv_userid"].Value + @",'" + ISpace["M_ModuleId"].Value + @"','" + ISpace["M_CurrentStatus"].Value + @"','" + ISpace["SubFilter"].Value + @"',''," + ISpace["MF_TaskSummary_PageIndex"].Value + @",'" + ISpace["MF_TaskSummary_GridRows"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceE55DE8B65604401D9FA50372DE5D3A21 =GetQueryExpressionDataSource(""E55DE8B6-5604-401D-9FA5-0372DE5D3A21"");Dictionary<short,object> resultE55DE8B65604401D9FA50372DE5D3A21=iSpace.ExecuteQuery(querySourceE55DE8B65604401D9FA50372DE5D3A21,@""EXEC dbo.[GetUserRequestSummaryWithFilters] 0,"" + ISpace[""gv_userid""].Value + @"",'"" + ISpace[""M_ModuleId""].Value + @""','"" + ISpace[""M_CurrentStatus""].Value + @""','"" + ISpace[""SubFilter""].Value + @""','',"" + ISpace[""MF_TaskSummary_PageIndex""].Value + @"",'"" + ISpace[""MF_TaskSummary_GridRows""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultE55DE8B65604401D9FA50372DE5D3A21!=null) && (resultE55DE8B65604401D9FA50372DE5D3A21.Count!=0))
{
if(resultE55DE8B65604401D9FA50372DE5D3A21.ContainsKey(0))
ISpace["MF_TaskSummary_GridRows"].Value = resultE55DE8B65604401D9FA50372DE5D3A21[0];
if(resultE55DE8B65604401D9FA50372DE5D3A21.ContainsKey(3))
ISpace["MF_TaskSummary_TotalPages"].Value = resultE55DE8B65604401D9FA50372DE5D3A21[3];
if(resultE55DE8B65604401D9FA50372DE5D3A21.ContainsKey(2))
ISpace["MF_TaskSummary_PageIndex"].Value = resultE55DE8B65604401D9FA50372DE5D3A21[2];
if(resultE55DE8B65604401D9FA50372DE5D3A21.ContainsKey(1))
ISpace["MF_TaskSummary_RecordsRange"].Value = resultE55DE8B65604401D9FA50372DE5D3A21[1];
}
else{
ISpace["MF_TaskSummary_GridRows"].Value = null;ISpace["MF_TaskSummary_TotalPages"].Value = null;ISpace["MF_TaskSummary_PageIndex"].Value = null;ISpace["MF_TaskSummary_RecordsRange"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_TaskSummary_PageIndex"].Value==1||ISpace["MF_TaskSummary_PageIndex"].Value==0)
{
base.WriteDebugInfo(@"if(ISpace[""MF_TaskSummary_PageIndex""].Value==1||ISpace[""MF_TaskSummary_PageIndex""].Value==0)");
if(ISpace["MF_TaskSummary_PageIndex"].Value==ISpace["MF_TaskSummary_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_TaskSummary_PageIndex""].Value==ISpace[""MF_TaskSummary_TotalPages""].Value)");
ISpace["MF_TaskSummary_FirstButton"].Enbl="false";ISpace["MF_TaskSummary_LastButton"].Enbl="false";ISpace["MF_TaskSummary_PageIndex"].Enbl="false";ISpace["MF_TaskSummary_NextButton"].Enbl="false";ISpace["MF_TaskSummary_PrevButton"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MF_TaskSummary_FirstButton""].Enbl=""false"";ISpace[""MF_TaskSummary_LastButton""].Enbl=""false"";ISpace[""MF_TaskSummary_PageIndex""].Enbl=""false"";ISpace[""MF_TaskSummary_NextButton""].Enbl=""false"";ISpace[""MF_TaskSummary_PrevButton""].Enbl=""false"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_TaskSummary_FirstButton"].Enbl="false";ISpace["MF_TaskSummary_LastButton"].Enbl="true";ISpace["MF_TaskSummary_PageIndex"].Enbl="true";ISpace["MF_TaskSummary_NextButton"].Enbl="true";ISpace["MF_TaskSummary_PrevButton"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MF_TaskSummary_FirstButton""].Enbl=""false"";ISpace[""MF_TaskSummary_LastButton""].Enbl=""true"";ISpace[""MF_TaskSummary_PageIndex""].Enbl=""true"";ISpace[""MF_TaskSummary_NextButton""].Enbl=""true"";ISpace[""MF_TaskSummary_PrevButton""].Enbl=""false"";");
}
}
else
{
base.WriteDebugInfo(@"else");
if(ISpace["MF_TaskSummary_PageIndex"].Value==ISpace["MF_TaskSummary_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_TaskSummary_PageIndex""].Value==ISpace[""MF_TaskSummary_TotalPages""].Value)");
ISpace["MF_TaskSummary_FirstButton"].Enbl="true";ISpace["MF_TaskSummary_LastButton"].Enbl="false";ISpace["MF_TaskSummary_PageIndex"].Enbl="true";ISpace["MF_TaskSummary_NextButton"].Enbl="false";ISpace["MF_TaskSummary_PrevButton"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_TaskSummary_FirstButton""].Enbl=""true"";ISpace[""MF_TaskSummary_LastButton""].Enbl=""false"";ISpace[""MF_TaskSummary_PageIndex""].Enbl=""true"";ISpace[""MF_TaskSummary_NextButton""].Enbl=""false"";ISpace[""MF_TaskSummary_PrevButton""].Enbl=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_TaskSummary_FirstButton"].Enbl="true";ISpace["MF_TaskSummary_LastButton"].Enbl="true";ISpace["MF_TaskSummary_PageIndex"].Enbl="true";ISpace["MF_TaskSummary_NextButton"].Enbl="true";ISpace["MF_TaskSummary_PrevButton"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_TaskSummary_FirstButton""].Enbl=""true"";ISpace[""MF_TaskSummary_LastButton""].Enbl=""true"";ISpace[""MF_TaskSummary_PageIndex""].Enbl=""true"";ISpace[""MF_TaskSummary_NextButton""].Enbl=""true"";ISpace[""MF_TaskSummary_PrevButton""].Enbl=""true"";");
}
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySourceB7B829491EE0475F95DEBBD6269FEDBF =GetQueryExpressionDataSource("B7B82949-1EE0-475F-95DE-BBD6269FEDBF");

DataTable resultB7B829491EE0475F95DEBBD6269FEDBF=iSpace.SetGridDataSource(querySourceB7B829491EE0475F95DEBBD6269FEDBF, _objectFactory.GetGridRPP("MG_TaskSummary"),@"EXEC dbo.[GetUserRequestSummaryWithFilters] 1," + ISpace["gv_userid"].Value + @",'" + ISpace["M_ModuleId"].Value + @"','" + ISpace["M_CurrentStatus"].Value + @"','" + ISpace["SubFilter"].Value + @"',''," + ISpace["MF_TaskSummary_PageIndex"].Value + @",'" + ISpace["MF_TaskSummary_GridRows"].Value + @"'");

iSpace.InsertGridBindDetails("MG_TaskSummary","11",querySourceB7B829491EE0475F95DEBBD6269FEDBF,"EXEC dbo.[GetUserRequestSummaryWithFilters] 1," + ISpace["gv_userid"].Value + @",'" + ISpace["M_ModuleId"].Value + @"','" + ISpace["M_CurrentStatus"].Value + @"','" + ISpace["SubFilter"].Value + @"',''," + ISpace["MF_TaskSummary_PageIndex"].Value + @",'" + ISpace["MF_TaskSummary_GridRows"].Value + @"'",_objectFactory.GetGridRPP("MG_TaskSummary"));

base.WriteDebugInfo(@"var querySourceB7B829491EE0475F95DEBBD6269FEDBF =GetQueryExpressionDataSource(""B7B82949-1EE0-475F-95DE-BBD6269FEDBF"");DataTable resultB7B829491EE0475F95DEBBD6269FEDBF=iSpace.SetGridDataSource(querySourceB7B829491EE0475F95DEBBD6269FEDBF, _objectFactory.GetGridRPP(""MG_TaskSummary""),@""EXEC dbo.[GetUserRequestSummaryWithFilters] 1,"" + ISpace[""gv_userid""].Value + @"",'"" + ISpace[""M_ModuleId""].Value + @""','"" + ISpace[""M_CurrentStatus""].Value + @""','"" + ISpace[""SubFilter""].Value + @""','',"" + ISpace[""MF_TaskSummary_PageIndex""].Value + @"",'"" + ISpace[""MF_TaskSummary_GridRows""].Value + @""'"");iSpace.InsertGridBindDetails(""MG_TaskSummary"",""11"",querySourceB7B829491EE0475F95DEBBD6269FEDBF,""EXEC dbo.[GetUserRequestSummaryWithFilters] 1,"" + ISpace[""gv_userid""].Value + @"",'"" + ISpace[""M_ModuleId""].Value + @""','"" + ISpace[""M_CurrentStatus""].Value + @""','"" + ISpace[""SubFilter""].Value + @""','',"" + ISpace[""MF_TaskSummary_PageIndex""].Value + @"",'"" + ISpace[""MF_TaskSummary_GridRows""].Value + @""'"",_objectFactory.GetGridRPP(""MG_TaskSummary""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result67C3863389CE42879063086A3A6BA3EB=acdataIspace2EC4031088B94E21AD43FA1B94EBF785.GetQueryExpressionBindings("67C38633-89CE-4287-9063-086A3A6BA3EB");
iSpace.SetGridData(resultB7B829491EE0475F95DEBBD6269FEDBF,result67C3863389CE42879063086A3A6BA3EB,"MG_TaskSummary",ref ISpace);
iSpace.UpdateGridBindDetails("MG_TaskSummary",result67C3863389CE42879063086A3A6BA3EB);
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_m_participatedcompletedbtn (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"M_ParticipatedCompletedBtn-OnClick");
ISpace["M_CurrentStatus"].Value="Participated-Completed";
base.WriteDebugInfo(@"ISpace[""M_CurrentStatus""].Value=""Participated-Completed"";");
if(IsNullOrEmpty(ISpace["M_CurrentStatus"].Value))
{
base.WriteDebugInfo(@"if(IsNullOrEmpty(ISpace[""M_CurrentStatus""].Value))");
ISpace["M_CurrentStatus"].Value="Initiated-Pending";
base.WriteDebugInfo(@"ISpace[""M_CurrentStatus""].Value=""Initiated-Pending"";");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC [dbo].usp_BuildDynamicTaskFilter '#F_TaskName','#F_InitiatedBy','#F_InitiatedStartDate','#F_InitiatedEndDate','#F_Level','#F_CurrentStatus','#F_ProcessName'");

var querySourceF1A1836CA83A4FAB9F41BB56E85274EE =GetQueryExpressionDataSource("F1A1836C-A83A-4FAB-9F41-BB56E85274EE");
Dictionary<short,object> resultF1A1836CA83A4FAB9F41BB56E85274EE=iSpace.ExecuteQuery(querySourceF1A1836CA83A4FAB9F41BB56E85274EE,@"EXEC [dbo].usp_BuildDynamicTaskFilter '" + ISpace["F_TaskName"].Value + @"','" + ISpace["F_InitiatedBy"].Value + @"','" + ISpace["F_InitiatedStartDate"].Value + @"','" + ISpace["F_InitiatedEndDate"].Value + @"','" + ISpace["F_Level"].Value + @"','" + ISpace["F_CurrentStatus"].Value + @"','" + ISpace["F_ProcessName"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceF1A1836CA83A4FAB9F41BB56E85274EE =GetQueryExpressionDataSource(""F1A1836C-A83A-4FAB-9F41-BB56E85274EE"");Dictionary<short,object> resultF1A1836CA83A4FAB9F41BB56E85274EE=iSpace.ExecuteQuery(querySourceF1A1836CA83A4FAB9F41BB56E85274EE,@""EXEC [dbo].usp_BuildDynamicTaskFilter '"" + ISpace[""F_TaskName""].Value + @""','"" + ISpace[""F_InitiatedBy""].Value + @""','"" + ISpace[""F_InitiatedStartDate""].Value + @""','"" + ISpace[""F_InitiatedEndDate""].Value + @""','"" + ISpace[""F_Level""].Value + @""','"" + ISpace[""F_CurrentStatus""].Value + @""','"" + ISpace[""F_ProcessName""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultF1A1836CA83A4FAB9F41BB56E85274EE!=null) && (resultF1A1836CA83A4FAB9F41BB56E85274EE.Count!=0))
{
if(resultF1A1836CA83A4FAB9F41BB56E85274EE.ContainsKey(0))
ISpace["SubFilter"].Value = resultF1A1836CA83A4FAB9F41BB56E85274EE[0];
}
else{
ISpace["SubFilter"].Value = null;
}
ISpace["SubFilter"].Value=Replace(ISpace["SubFIlter"].Value,"'","''");
base.WriteDebugInfo(@"ISpace[""SubFilter""].Value=Replace(ISpace[""SubFIlter""].Value,""'"",""''"");");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC dbo.[GetUserRequestSummaryWithFilters] 0,@@gv_UserId,'#M_ModuleId','#M_CurrentStatus','#SubFilter','',#MF_TaskSummary_PageIndex,'#MF_TaskSummary_GridRows'");

var querySourceE55DE8B65604401D9FA50372DE5D3A21 =GetQueryExpressionDataSource("E55DE8B6-5604-401D-9FA5-0372DE5D3A21");
Dictionary<short,object> resultE55DE8B65604401D9FA50372DE5D3A21=iSpace.ExecuteQuery(querySourceE55DE8B65604401D9FA50372DE5D3A21,@"EXEC dbo.[GetUserRequestSummaryWithFilters] 0," + ISpace["gv_userid"].Value + @",'" + ISpace["M_ModuleId"].Value + @"','" + ISpace["M_CurrentStatus"].Value + @"','" + ISpace["SubFilter"].Value + @"',''," + ISpace["MF_TaskSummary_PageIndex"].Value + @",'" + ISpace["MF_TaskSummary_GridRows"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceE55DE8B65604401D9FA50372DE5D3A21 =GetQueryExpressionDataSource(""E55DE8B6-5604-401D-9FA5-0372DE5D3A21"");Dictionary<short,object> resultE55DE8B65604401D9FA50372DE5D3A21=iSpace.ExecuteQuery(querySourceE55DE8B65604401D9FA50372DE5D3A21,@""EXEC dbo.[GetUserRequestSummaryWithFilters] 0,"" + ISpace[""gv_userid""].Value + @"",'"" + ISpace[""M_ModuleId""].Value + @""','"" + ISpace[""M_CurrentStatus""].Value + @""','"" + ISpace[""SubFilter""].Value + @""','',"" + ISpace[""MF_TaskSummary_PageIndex""].Value + @"",'"" + ISpace[""MF_TaskSummary_GridRows""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultE55DE8B65604401D9FA50372DE5D3A21!=null) && (resultE55DE8B65604401D9FA50372DE5D3A21.Count!=0))
{
if(resultE55DE8B65604401D9FA50372DE5D3A21.ContainsKey(0))
ISpace["MF_TaskSummary_GridRows"].Value = resultE55DE8B65604401D9FA50372DE5D3A21[0];
if(resultE55DE8B65604401D9FA50372DE5D3A21.ContainsKey(3))
ISpace["MF_TaskSummary_TotalPages"].Value = resultE55DE8B65604401D9FA50372DE5D3A21[3];
if(resultE55DE8B65604401D9FA50372DE5D3A21.ContainsKey(2))
ISpace["MF_TaskSummary_PageIndex"].Value = resultE55DE8B65604401D9FA50372DE5D3A21[2];
if(resultE55DE8B65604401D9FA50372DE5D3A21.ContainsKey(1))
ISpace["MF_TaskSummary_RecordsRange"].Value = resultE55DE8B65604401D9FA50372DE5D3A21[1];
}
else{
ISpace["MF_TaskSummary_GridRows"].Value = null;ISpace["MF_TaskSummary_TotalPages"].Value = null;ISpace["MF_TaskSummary_PageIndex"].Value = null;ISpace["MF_TaskSummary_RecordsRange"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_TaskSummary_PageIndex"].Value==1||ISpace["MF_TaskSummary_PageIndex"].Value==0)
{
base.WriteDebugInfo(@"if(ISpace[""MF_TaskSummary_PageIndex""].Value==1||ISpace[""MF_TaskSummary_PageIndex""].Value==0)");
if(ISpace["MF_TaskSummary_PageIndex"].Value==ISpace["MF_TaskSummary_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_TaskSummary_PageIndex""].Value==ISpace[""MF_TaskSummary_TotalPages""].Value)");
ISpace["MF_TaskSummary_FirstButton"].Enbl="false";ISpace["MF_TaskSummary_LastButton"].Enbl="false";ISpace["MF_TaskSummary_PageIndex"].Enbl="false";ISpace["MF_TaskSummary_NextButton"].Enbl="false";ISpace["MF_TaskSummary_PrevButton"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MF_TaskSummary_FirstButton""].Enbl=""false"";ISpace[""MF_TaskSummary_LastButton""].Enbl=""false"";ISpace[""MF_TaskSummary_PageIndex""].Enbl=""false"";ISpace[""MF_TaskSummary_NextButton""].Enbl=""false"";ISpace[""MF_TaskSummary_PrevButton""].Enbl=""false"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_TaskSummary_FirstButton"].Enbl="false";ISpace["MF_TaskSummary_LastButton"].Enbl="true";ISpace["MF_TaskSummary_PageIndex"].Enbl="true";ISpace["MF_TaskSummary_NextButton"].Enbl="true";ISpace["MF_TaskSummary_PrevButton"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MF_TaskSummary_FirstButton""].Enbl=""false"";ISpace[""MF_TaskSummary_LastButton""].Enbl=""true"";ISpace[""MF_TaskSummary_PageIndex""].Enbl=""true"";ISpace[""MF_TaskSummary_NextButton""].Enbl=""true"";ISpace[""MF_TaskSummary_PrevButton""].Enbl=""false"";");
}
}
else
{
base.WriteDebugInfo(@"else");
if(ISpace["MF_TaskSummary_PageIndex"].Value==ISpace["MF_TaskSummary_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_TaskSummary_PageIndex""].Value==ISpace[""MF_TaskSummary_TotalPages""].Value)");
ISpace["MF_TaskSummary_FirstButton"].Enbl="true";ISpace["MF_TaskSummary_LastButton"].Enbl="false";ISpace["MF_TaskSummary_PageIndex"].Enbl="true";ISpace["MF_TaskSummary_NextButton"].Enbl="false";ISpace["MF_TaskSummary_PrevButton"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_TaskSummary_FirstButton""].Enbl=""true"";ISpace[""MF_TaskSummary_LastButton""].Enbl=""false"";ISpace[""MF_TaskSummary_PageIndex""].Enbl=""true"";ISpace[""MF_TaskSummary_NextButton""].Enbl=""false"";ISpace[""MF_TaskSummary_PrevButton""].Enbl=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_TaskSummary_FirstButton"].Enbl="true";ISpace["MF_TaskSummary_LastButton"].Enbl="true";ISpace["MF_TaskSummary_PageIndex"].Enbl="true";ISpace["MF_TaskSummary_NextButton"].Enbl="true";ISpace["MF_TaskSummary_PrevButton"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_TaskSummary_FirstButton""].Enbl=""true"";ISpace[""MF_TaskSummary_LastButton""].Enbl=""true"";ISpace[""MF_TaskSummary_PageIndex""].Enbl=""true"";ISpace[""MF_TaskSummary_NextButton""].Enbl=""true"";ISpace[""MF_TaskSummary_PrevButton""].Enbl=""true"";");
}
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySourceB7B829491EE0475F95DEBBD6269FEDBF =GetQueryExpressionDataSource("B7B82949-1EE0-475F-95DE-BBD6269FEDBF");

DataTable resultB7B829491EE0475F95DEBBD6269FEDBF=iSpace.SetGridDataSource(querySourceB7B829491EE0475F95DEBBD6269FEDBF, _objectFactory.GetGridRPP("MG_TaskSummary"),@"EXEC dbo.[GetUserRequestSummaryWithFilters] 1," + ISpace["gv_userid"].Value + @",'" + ISpace["M_ModuleId"].Value + @"','" + ISpace["M_CurrentStatus"].Value + @"','" + ISpace["SubFilter"].Value + @"',''," + ISpace["MF_TaskSummary_PageIndex"].Value + @",'" + ISpace["MF_TaskSummary_GridRows"].Value + @"'");

iSpace.InsertGridBindDetails("MG_TaskSummary","11",querySourceB7B829491EE0475F95DEBBD6269FEDBF,"EXEC dbo.[GetUserRequestSummaryWithFilters] 1," + ISpace["gv_userid"].Value + @",'" + ISpace["M_ModuleId"].Value + @"','" + ISpace["M_CurrentStatus"].Value + @"','" + ISpace["SubFilter"].Value + @"',''," + ISpace["MF_TaskSummary_PageIndex"].Value + @",'" + ISpace["MF_TaskSummary_GridRows"].Value + @"'",_objectFactory.GetGridRPP("MG_TaskSummary"));

base.WriteDebugInfo(@"var querySourceB7B829491EE0475F95DEBBD6269FEDBF =GetQueryExpressionDataSource(""B7B82949-1EE0-475F-95DE-BBD6269FEDBF"");DataTable resultB7B829491EE0475F95DEBBD6269FEDBF=iSpace.SetGridDataSource(querySourceB7B829491EE0475F95DEBBD6269FEDBF, _objectFactory.GetGridRPP(""MG_TaskSummary""),@""EXEC dbo.[GetUserRequestSummaryWithFilters] 1,"" + ISpace[""gv_userid""].Value + @"",'"" + ISpace[""M_ModuleId""].Value + @""','"" + ISpace[""M_CurrentStatus""].Value + @""','"" + ISpace[""SubFilter""].Value + @""','',"" + ISpace[""MF_TaskSummary_PageIndex""].Value + @"",'"" + ISpace[""MF_TaskSummary_GridRows""].Value + @""'"");iSpace.InsertGridBindDetails(""MG_TaskSummary"",""11"",querySourceB7B829491EE0475F95DEBBD6269FEDBF,""EXEC dbo.[GetUserRequestSummaryWithFilters] 1,"" + ISpace[""gv_userid""].Value + @"",'"" + ISpace[""M_ModuleId""].Value + @""','"" + ISpace[""M_CurrentStatus""].Value + @""','"" + ISpace[""SubFilter""].Value + @""','',"" + ISpace[""MF_TaskSummary_PageIndex""].Value + @"",'"" + ISpace[""MF_TaskSummary_GridRows""].Value + @""'"",_objectFactory.GetGridRPP(""MG_TaskSummary""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result67C3863389CE42879063086A3A6BA3EB=acdataIspace2EC4031088B94E21AD43FA1B94EBF785.GetQueryExpressionBindings("67C38633-89CE-4287-9063-086A3A6BA3EB");
iSpace.SetGridData(resultB7B829491EE0475F95DEBBD6269FEDBF,result67C3863389CE42879063086A3A6BA3EB,"MG_TaskSummary",ref ISpace);
iSpace.UpdateGridBindDetails("MG_TaskSummary",result67C3863389CE42879063086A3A6BA3EB);
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_m_ipbutton (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"M_IPButton-OnClick");
ISpace["M_CurrentStatus"].Value="Initiated-Pending";
base.WriteDebugInfo(@"ISpace[""M_CurrentStatus""].Value=""Initiated-Pending"";");
if(IsNullOrEmpty(ISpace["M_CurrentStatus"].Value))
{
base.WriteDebugInfo(@"if(IsNullOrEmpty(ISpace[""M_CurrentStatus""].Value))");
ISpace["M_CurrentStatus"].Value="Initiated-Pending";
base.WriteDebugInfo(@"ISpace[""M_CurrentStatus""].Value=""Initiated-Pending"";");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC [dbo].usp_BuildDynamicTaskFilter '#F_TaskName','#F_InitiatedBy','#F_InitiatedStartDate','#F_InitiatedEndDate','#F_Level','#F_CurrentStatus','#F_ProcessName'");

var querySourceF1A1836CA83A4FAB9F41BB56E85274EE =GetQueryExpressionDataSource("F1A1836C-A83A-4FAB-9F41-BB56E85274EE");
Dictionary<short,object> resultF1A1836CA83A4FAB9F41BB56E85274EE=iSpace.ExecuteQuery(querySourceF1A1836CA83A4FAB9F41BB56E85274EE,@"EXEC [dbo].usp_BuildDynamicTaskFilter '" + ISpace["F_TaskName"].Value + @"','" + ISpace["F_InitiatedBy"].Value + @"','" + ISpace["F_InitiatedStartDate"].Value + @"','" + ISpace["F_InitiatedEndDate"].Value + @"','" + ISpace["F_Level"].Value + @"','" + ISpace["F_CurrentStatus"].Value + @"','" + ISpace["F_ProcessName"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceF1A1836CA83A4FAB9F41BB56E85274EE =GetQueryExpressionDataSource(""F1A1836C-A83A-4FAB-9F41-BB56E85274EE"");Dictionary<short,object> resultF1A1836CA83A4FAB9F41BB56E85274EE=iSpace.ExecuteQuery(querySourceF1A1836CA83A4FAB9F41BB56E85274EE,@""EXEC [dbo].usp_BuildDynamicTaskFilter '"" + ISpace[""F_TaskName""].Value + @""','"" + ISpace[""F_InitiatedBy""].Value + @""','"" + ISpace[""F_InitiatedStartDate""].Value + @""','"" + ISpace[""F_InitiatedEndDate""].Value + @""','"" + ISpace[""F_Level""].Value + @""','"" + ISpace[""F_CurrentStatus""].Value + @""','"" + ISpace[""F_ProcessName""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultF1A1836CA83A4FAB9F41BB56E85274EE!=null) && (resultF1A1836CA83A4FAB9F41BB56E85274EE.Count!=0))
{
if(resultF1A1836CA83A4FAB9F41BB56E85274EE.ContainsKey(0))
ISpace["SubFilter"].Value = resultF1A1836CA83A4FAB9F41BB56E85274EE[0];
}
else{
ISpace["SubFilter"].Value = null;
}
ISpace["SubFilter"].Value=Replace(ISpace["SubFIlter"].Value,"'","''");
base.WriteDebugInfo(@"ISpace[""SubFilter""].Value=Replace(ISpace[""SubFIlter""].Value,""'"",""''"");");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC dbo.[GetUserRequestSummaryWithFilters] 0,@@gv_UserId,'#M_ModuleId','#M_CurrentStatus','#SubFilter','',#MF_TaskSummary_PageIndex,'#MF_TaskSummary_GridRows'");

var querySourceE55DE8B65604401D9FA50372DE5D3A21 =GetQueryExpressionDataSource("E55DE8B6-5604-401D-9FA5-0372DE5D3A21");
Dictionary<short,object> resultE55DE8B65604401D9FA50372DE5D3A21=iSpace.ExecuteQuery(querySourceE55DE8B65604401D9FA50372DE5D3A21,@"EXEC dbo.[GetUserRequestSummaryWithFilters] 0," + ISpace["gv_userid"].Value + @",'" + ISpace["M_ModuleId"].Value + @"','" + ISpace["M_CurrentStatus"].Value + @"','" + ISpace["SubFilter"].Value + @"',''," + ISpace["MF_TaskSummary_PageIndex"].Value + @",'" + ISpace["MF_TaskSummary_GridRows"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceE55DE8B65604401D9FA50372DE5D3A21 =GetQueryExpressionDataSource(""E55DE8B6-5604-401D-9FA5-0372DE5D3A21"");Dictionary<short,object> resultE55DE8B65604401D9FA50372DE5D3A21=iSpace.ExecuteQuery(querySourceE55DE8B65604401D9FA50372DE5D3A21,@""EXEC dbo.[GetUserRequestSummaryWithFilters] 0,"" + ISpace[""gv_userid""].Value + @"",'"" + ISpace[""M_ModuleId""].Value + @""','"" + ISpace[""M_CurrentStatus""].Value + @""','"" + ISpace[""SubFilter""].Value + @""','',"" + ISpace[""MF_TaskSummary_PageIndex""].Value + @"",'"" + ISpace[""MF_TaskSummary_GridRows""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultE55DE8B65604401D9FA50372DE5D3A21!=null) && (resultE55DE8B65604401D9FA50372DE5D3A21.Count!=0))
{
if(resultE55DE8B65604401D9FA50372DE5D3A21.ContainsKey(0))
ISpace["MF_TaskSummary_GridRows"].Value = resultE55DE8B65604401D9FA50372DE5D3A21[0];
if(resultE55DE8B65604401D9FA50372DE5D3A21.ContainsKey(3))
ISpace["MF_TaskSummary_TotalPages"].Value = resultE55DE8B65604401D9FA50372DE5D3A21[3];
if(resultE55DE8B65604401D9FA50372DE5D3A21.ContainsKey(2))
ISpace["MF_TaskSummary_PageIndex"].Value = resultE55DE8B65604401D9FA50372DE5D3A21[2];
if(resultE55DE8B65604401D9FA50372DE5D3A21.ContainsKey(1))
ISpace["MF_TaskSummary_RecordsRange"].Value = resultE55DE8B65604401D9FA50372DE5D3A21[1];
}
else{
ISpace["MF_TaskSummary_GridRows"].Value = null;ISpace["MF_TaskSummary_TotalPages"].Value = null;ISpace["MF_TaskSummary_PageIndex"].Value = null;ISpace["MF_TaskSummary_RecordsRange"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_TaskSummary_PageIndex"].Value==1||ISpace["MF_TaskSummary_PageIndex"].Value==0)
{
base.WriteDebugInfo(@"if(ISpace[""MF_TaskSummary_PageIndex""].Value==1||ISpace[""MF_TaskSummary_PageIndex""].Value==0)");
if(ISpace["MF_TaskSummary_PageIndex"].Value==ISpace["MF_TaskSummary_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_TaskSummary_PageIndex""].Value==ISpace[""MF_TaskSummary_TotalPages""].Value)");
ISpace["MF_TaskSummary_FirstButton"].Enbl="false";ISpace["MF_TaskSummary_LastButton"].Enbl="false";ISpace["MF_TaskSummary_PageIndex"].Enbl="false";ISpace["MF_TaskSummary_NextButton"].Enbl="false";ISpace["MF_TaskSummary_PrevButton"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MF_TaskSummary_FirstButton""].Enbl=""false"";ISpace[""MF_TaskSummary_LastButton""].Enbl=""false"";ISpace[""MF_TaskSummary_PageIndex""].Enbl=""false"";ISpace[""MF_TaskSummary_NextButton""].Enbl=""false"";ISpace[""MF_TaskSummary_PrevButton""].Enbl=""false"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_TaskSummary_FirstButton"].Enbl="false";ISpace["MF_TaskSummary_LastButton"].Enbl="true";ISpace["MF_TaskSummary_PageIndex"].Enbl="true";ISpace["MF_TaskSummary_NextButton"].Enbl="true";ISpace["MF_TaskSummary_PrevButton"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MF_TaskSummary_FirstButton""].Enbl=""false"";ISpace[""MF_TaskSummary_LastButton""].Enbl=""true"";ISpace[""MF_TaskSummary_PageIndex""].Enbl=""true"";ISpace[""MF_TaskSummary_NextButton""].Enbl=""true"";ISpace[""MF_TaskSummary_PrevButton""].Enbl=""false"";");
}
}
else
{
base.WriteDebugInfo(@"else");
if(ISpace["MF_TaskSummary_PageIndex"].Value==ISpace["MF_TaskSummary_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_TaskSummary_PageIndex""].Value==ISpace[""MF_TaskSummary_TotalPages""].Value)");
ISpace["MF_TaskSummary_FirstButton"].Enbl="true";ISpace["MF_TaskSummary_LastButton"].Enbl="false";ISpace["MF_TaskSummary_PageIndex"].Enbl="true";ISpace["MF_TaskSummary_NextButton"].Enbl="false";ISpace["MF_TaskSummary_PrevButton"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_TaskSummary_FirstButton""].Enbl=""true"";ISpace[""MF_TaskSummary_LastButton""].Enbl=""false"";ISpace[""MF_TaskSummary_PageIndex""].Enbl=""true"";ISpace[""MF_TaskSummary_NextButton""].Enbl=""false"";ISpace[""MF_TaskSummary_PrevButton""].Enbl=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_TaskSummary_FirstButton"].Enbl="true";ISpace["MF_TaskSummary_LastButton"].Enbl="true";ISpace["MF_TaskSummary_PageIndex"].Enbl="true";ISpace["MF_TaskSummary_NextButton"].Enbl="true";ISpace["MF_TaskSummary_PrevButton"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_TaskSummary_FirstButton""].Enbl=""true"";ISpace[""MF_TaskSummary_LastButton""].Enbl=""true"";ISpace[""MF_TaskSummary_PageIndex""].Enbl=""true"";ISpace[""MF_TaskSummary_NextButton""].Enbl=""true"";ISpace[""MF_TaskSummary_PrevButton""].Enbl=""true"";");
}
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySourceB7B829491EE0475F95DEBBD6269FEDBF =GetQueryExpressionDataSource("B7B82949-1EE0-475F-95DE-BBD6269FEDBF");

DataTable resultB7B829491EE0475F95DEBBD6269FEDBF=iSpace.SetGridDataSource(querySourceB7B829491EE0475F95DEBBD6269FEDBF, _objectFactory.GetGridRPP("MG_TaskSummary"),@"EXEC dbo.[GetUserRequestSummaryWithFilters] 1," + ISpace["gv_userid"].Value + @",'" + ISpace["M_ModuleId"].Value + @"','" + ISpace["M_CurrentStatus"].Value + @"','" + ISpace["SubFilter"].Value + @"',''," + ISpace["MF_TaskSummary_PageIndex"].Value + @",'" + ISpace["MF_TaskSummary_GridRows"].Value + @"'");

iSpace.InsertGridBindDetails("MG_TaskSummary","11",querySourceB7B829491EE0475F95DEBBD6269FEDBF,"EXEC dbo.[GetUserRequestSummaryWithFilters] 1," + ISpace["gv_userid"].Value + @",'" + ISpace["M_ModuleId"].Value + @"','" + ISpace["M_CurrentStatus"].Value + @"','" + ISpace["SubFilter"].Value + @"',''," + ISpace["MF_TaskSummary_PageIndex"].Value + @",'" + ISpace["MF_TaskSummary_GridRows"].Value + @"'",_objectFactory.GetGridRPP("MG_TaskSummary"));

base.WriteDebugInfo(@"var querySourceB7B829491EE0475F95DEBBD6269FEDBF =GetQueryExpressionDataSource(""B7B82949-1EE0-475F-95DE-BBD6269FEDBF"");DataTable resultB7B829491EE0475F95DEBBD6269FEDBF=iSpace.SetGridDataSource(querySourceB7B829491EE0475F95DEBBD6269FEDBF, _objectFactory.GetGridRPP(""MG_TaskSummary""),@""EXEC dbo.[GetUserRequestSummaryWithFilters] 1,"" + ISpace[""gv_userid""].Value + @"",'"" + ISpace[""M_ModuleId""].Value + @""','"" + ISpace[""M_CurrentStatus""].Value + @""','"" + ISpace[""SubFilter""].Value + @""','',"" + ISpace[""MF_TaskSummary_PageIndex""].Value + @"",'"" + ISpace[""MF_TaskSummary_GridRows""].Value + @""'"");iSpace.InsertGridBindDetails(""MG_TaskSummary"",""11"",querySourceB7B829491EE0475F95DEBBD6269FEDBF,""EXEC dbo.[GetUserRequestSummaryWithFilters] 1,"" + ISpace[""gv_userid""].Value + @"",'"" + ISpace[""M_ModuleId""].Value + @""','"" + ISpace[""M_CurrentStatus""].Value + @""','"" + ISpace[""SubFilter""].Value + @""','',"" + ISpace[""MF_TaskSummary_PageIndex""].Value + @"",'"" + ISpace[""MF_TaskSummary_GridRows""].Value + @""'"",_objectFactory.GetGridRPP(""MG_TaskSummary""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result67C3863389CE42879063086A3A6BA3EB=acdataIspace2EC4031088B94E21AD43FA1B94EBF785.GetQueryExpressionBindings("67C38633-89CE-4287-9063-086A3A6BA3EB");
iSpace.SetGridData(resultB7B829491EE0475F95DEBBD6269FEDBF,result67C3863389CE42879063086A3A6BA3EB,"MG_TaskSummary",ref ISpace);
iSpace.UpdateGridBindDetails("MG_TaskSummary",result67C3863389CE42879063086A3A6BA3EB);
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_clearall (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"ClearAll-OnClick");
ISpace["F_ProcessName"].Value=null;
base.WriteDebugInfo(@"ISpace[""F_ProcessName""].Value=null;");
ISpace["F_TaskName"].Value=null;
base.WriteDebugInfo(@"ISpace[""F_TaskName""].Value=null;");
ISpace["F_InitiatedBy"].Value=null;
base.WriteDebugInfo(@"ISpace[""F_InitiatedBy""].Value=null;");
ISpace["F_Level"].Value=null;
base.WriteDebugInfo(@"ISpace[""F_Level""].Value=null;");
ISpace["F_InitiatedStartDate"].Value=null;
base.WriteDebugInfo(@"ISpace[""F_InitiatedStartDate""].Value=null;");
ISpace["F_InitiatedEndDate"].Value=null;
base.WriteDebugInfo(@"ISpace[""F_InitiatedEndDate""].Value=null;");
ISpace["F_CurrentStatus"].Value=null;
base.WriteDebugInfo(@"ISpace[""F_CurrentStatus""].Value=null;");
ISpace["M_CurrentStatus"].Value=null;
base.WriteDebugInfo(@"ISpace[""M_CurrentStatus""].Value=null;");
if(IsNullOrEmpty(ISpace["M_CurrentStatus"].Value))
{
base.WriteDebugInfo(@"if(IsNullOrEmpty(ISpace[""M_CurrentStatus""].Value))");
ISpace["M_CurrentStatus"].Value="Initiated-Pending";
base.WriteDebugInfo(@"ISpace[""M_CurrentStatus""].Value=""Initiated-Pending"";");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC [dbo].usp_BuildDynamicTaskFilter '#F_TaskName','#F_InitiatedBy','#F_InitiatedStartDate','#F_InitiatedEndDate','#F_Level','#F_CurrentStatus','#F_ProcessName'");

var querySourceF1A1836CA83A4FAB9F41BB56E85274EE =GetQueryExpressionDataSource("F1A1836C-A83A-4FAB-9F41-BB56E85274EE");
Dictionary<short,object> resultF1A1836CA83A4FAB9F41BB56E85274EE=iSpace.ExecuteQuery(querySourceF1A1836CA83A4FAB9F41BB56E85274EE,@"EXEC [dbo].usp_BuildDynamicTaskFilter '" + ISpace["F_TaskName"].Value + @"','" + ISpace["F_InitiatedBy"].Value + @"','" + ISpace["F_InitiatedStartDate"].Value + @"','" + ISpace["F_InitiatedEndDate"].Value + @"','" + ISpace["F_Level"].Value + @"','" + ISpace["F_CurrentStatus"].Value + @"','" + ISpace["F_ProcessName"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceF1A1836CA83A4FAB9F41BB56E85274EE =GetQueryExpressionDataSource(""F1A1836C-A83A-4FAB-9F41-BB56E85274EE"");Dictionary<short,object> resultF1A1836CA83A4FAB9F41BB56E85274EE=iSpace.ExecuteQuery(querySourceF1A1836CA83A4FAB9F41BB56E85274EE,@""EXEC [dbo].usp_BuildDynamicTaskFilter '"" + ISpace[""F_TaskName""].Value + @""','"" + ISpace[""F_InitiatedBy""].Value + @""','"" + ISpace[""F_InitiatedStartDate""].Value + @""','"" + ISpace[""F_InitiatedEndDate""].Value + @""','"" + ISpace[""F_Level""].Value + @""','"" + ISpace[""F_CurrentStatus""].Value + @""','"" + ISpace[""F_ProcessName""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultF1A1836CA83A4FAB9F41BB56E85274EE!=null) && (resultF1A1836CA83A4FAB9F41BB56E85274EE.Count!=0))
{
if(resultF1A1836CA83A4FAB9F41BB56E85274EE.ContainsKey(0))
ISpace["SubFilter"].Value = resultF1A1836CA83A4FAB9F41BB56E85274EE[0];
}
else{
ISpace["SubFilter"].Value = null;
}
ISpace["SubFilter"].Value=Replace(ISpace["SubFIlter"].Value,"'","''");
base.WriteDebugInfo(@"ISpace[""SubFilter""].Value=Replace(ISpace[""SubFIlter""].Value,""'"",""''"");");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC dbo.[GetUserRequestSummaryWithFilters] 0,@@gv_UserId,'#M_ModuleId','#M_CurrentStatus','#SubFilter','',#MF_TaskSummary_PageIndex,'#MF_TaskSummary_GridRows'");

var querySourceE55DE8B65604401D9FA50372DE5D3A21 =GetQueryExpressionDataSource("E55DE8B6-5604-401D-9FA5-0372DE5D3A21");
Dictionary<short,object> resultE55DE8B65604401D9FA50372DE5D3A21=iSpace.ExecuteQuery(querySourceE55DE8B65604401D9FA50372DE5D3A21,@"EXEC dbo.[GetUserRequestSummaryWithFilters] 0," + ISpace["gv_userid"].Value + @",'" + ISpace["M_ModuleId"].Value + @"','" + ISpace["M_CurrentStatus"].Value + @"','" + ISpace["SubFilter"].Value + @"',''," + ISpace["MF_TaskSummary_PageIndex"].Value + @",'" + ISpace["MF_TaskSummary_GridRows"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceE55DE8B65604401D9FA50372DE5D3A21 =GetQueryExpressionDataSource(""E55DE8B6-5604-401D-9FA5-0372DE5D3A21"");Dictionary<short,object> resultE55DE8B65604401D9FA50372DE5D3A21=iSpace.ExecuteQuery(querySourceE55DE8B65604401D9FA50372DE5D3A21,@""EXEC dbo.[GetUserRequestSummaryWithFilters] 0,"" + ISpace[""gv_userid""].Value + @"",'"" + ISpace[""M_ModuleId""].Value + @""','"" + ISpace[""M_CurrentStatus""].Value + @""','"" + ISpace[""SubFilter""].Value + @""','',"" + ISpace[""MF_TaskSummary_PageIndex""].Value + @"",'"" + ISpace[""MF_TaskSummary_GridRows""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultE55DE8B65604401D9FA50372DE5D3A21!=null) && (resultE55DE8B65604401D9FA50372DE5D3A21.Count!=0))
{
if(resultE55DE8B65604401D9FA50372DE5D3A21.ContainsKey(0))
ISpace["MF_TaskSummary_GridRows"].Value = resultE55DE8B65604401D9FA50372DE5D3A21[0];
if(resultE55DE8B65604401D9FA50372DE5D3A21.ContainsKey(3))
ISpace["MF_TaskSummary_TotalPages"].Value = resultE55DE8B65604401D9FA50372DE5D3A21[3];
if(resultE55DE8B65604401D9FA50372DE5D3A21.ContainsKey(2))
ISpace["MF_TaskSummary_PageIndex"].Value = resultE55DE8B65604401D9FA50372DE5D3A21[2];
if(resultE55DE8B65604401D9FA50372DE5D3A21.ContainsKey(1))
ISpace["MF_TaskSummary_RecordsRange"].Value = resultE55DE8B65604401D9FA50372DE5D3A21[1];
}
else{
ISpace["MF_TaskSummary_GridRows"].Value = null;ISpace["MF_TaskSummary_TotalPages"].Value = null;ISpace["MF_TaskSummary_PageIndex"].Value = null;ISpace["MF_TaskSummary_RecordsRange"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_TaskSummary_PageIndex"].Value==1||ISpace["MF_TaskSummary_PageIndex"].Value==0)
{
base.WriteDebugInfo(@"if(ISpace[""MF_TaskSummary_PageIndex""].Value==1||ISpace[""MF_TaskSummary_PageIndex""].Value==0)");
if(ISpace["MF_TaskSummary_PageIndex"].Value==ISpace["MF_TaskSummary_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_TaskSummary_PageIndex""].Value==ISpace[""MF_TaskSummary_TotalPages""].Value)");
ISpace["MF_TaskSummary_FirstButton"].Enbl="false";ISpace["MF_TaskSummary_LastButton"].Enbl="false";ISpace["MF_TaskSummary_PageIndex"].Enbl="false";ISpace["MF_TaskSummary_NextButton"].Enbl="false";ISpace["MF_TaskSummary_PrevButton"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MF_TaskSummary_FirstButton""].Enbl=""false"";ISpace[""MF_TaskSummary_LastButton""].Enbl=""false"";ISpace[""MF_TaskSummary_PageIndex""].Enbl=""false"";ISpace[""MF_TaskSummary_NextButton""].Enbl=""false"";ISpace[""MF_TaskSummary_PrevButton""].Enbl=""false"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_TaskSummary_FirstButton"].Enbl="false";ISpace["MF_TaskSummary_LastButton"].Enbl="true";ISpace["MF_TaskSummary_PageIndex"].Enbl="true";ISpace["MF_TaskSummary_NextButton"].Enbl="true";ISpace["MF_TaskSummary_PrevButton"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MF_TaskSummary_FirstButton""].Enbl=""false"";ISpace[""MF_TaskSummary_LastButton""].Enbl=""true"";ISpace[""MF_TaskSummary_PageIndex""].Enbl=""true"";ISpace[""MF_TaskSummary_NextButton""].Enbl=""true"";ISpace[""MF_TaskSummary_PrevButton""].Enbl=""false"";");
}
}
else
{
base.WriteDebugInfo(@"else");
if(ISpace["MF_TaskSummary_PageIndex"].Value==ISpace["MF_TaskSummary_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_TaskSummary_PageIndex""].Value==ISpace[""MF_TaskSummary_TotalPages""].Value)");
ISpace["MF_TaskSummary_FirstButton"].Enbl="true";ISpace["MF_TaskSummary_LastButton"].Enbl="false";ISpace["MF_TaskSummary_PageIndex"].Enbl="true";ISpace["MF_TaskSummary_NextButton"].Enbl="false";ISpace["MF_TaskSummary_PrevButton"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_TaskSummary_FirstButton""].Enbl=""true"";ISpace[""MF_TaskSummary_LastButton""].Enbl=""false"";ISpace[""MF_TaskSummary_PageIndex""].Enbl=""true"";ISpace[""MF_TaskSummary_NextButton""].Enbl=""false"";ISpace[""MF_TaskSummary_PrevButton""].Enbl=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_TaskSummary_FirstButton"].Enbl="true";ISpace["MF_TaskSummary_LastButton"].Enbl="true";ISpace["MF_TaskSummary_PageIndex"].Enbl="true";ISpace["MF_TaskSummary_NextButton"].Enbl="true";ISpace["MF_TaskSummary_PrevButton"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_TaskSummary_FirstButton""].Enbl=""true"";ISpace[""MF_TaskSummary_LastButton""].Enbl=""true"";ISpace[""MF_TaskSummary_PageIndex""].Enbl=""true"";ISpace[""MF_TaskSummary_NextButton""].Enbl=""true"";ISpace[""MF_TaskSummary_PrevButton""].Enbl=""true"";");
}
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySourceB7B829491EE0475F95DEBBD6269FEDBF =GetQueryExpressionDataSource("B7B82949-1EE0-475F-95DE-BBD6269FEDBF");

DataTable resultB7B829491EE0475F95DEBBD6269FEDBF=iSpace.SetGridDataSource(querySourceB7B829491EE0475F95DEBBD6269FEDBF, _objectFactory.GetGridRPP("MG_TaskSummary"),@"EXEC dbo.[GetUserRequestSummaryWithFilters] 1," + ISpace["gv_userid"].Value + @",'" + ISpace["M_ModuleId"].Value + @"','" + ISpace["M_CurrentStatus"].Value + @"','" + ISpace["SubFilter"].Value + @"',''," + ISpace["MF_TaskSummary_PageIndex"].Value + @",'" + ISpace["MF_TaskSummary_GridRows"].Value + @"'");

iSpace.InsertGridBindDetails("MG_TaskSummary","11",querySourceB7B829491EE0475F95DEBBD6269FEDBF,"EXEC dbo.[GetUserRequestSummaryWithFilters] 1," + ISpace["gv_userid"].Value + @",'" + ISpace["M_ModuleId"].Value + @"','" + ISpace["M_CurrentStatus"].Value + @"','" + ISpace["SubFilter"].Value + @"',''," + ISpace["MF_TaskSummary_PageIndex"].Value + @",'" + ISpace["MF_TaskSummary_GridRows"].Value + @"'",_objectFactory.GetGridRPP("MG_TaskSummary"));

base.WriteDebugInfo(@"var querySourceB7B829491EE0475F95DEBBD6269FEDBF =GetQueryExpressionDataSource(""B7B82949-1EE0-475F-95DE-BBD6269FEDBF"");DataTable resultB7B829491EE0475F95DEBBD6269FEDBF=iSpace.SetGridDataSource(querySourceB7B829491EE0475F95DEBBD6269FEDBF, _objectFactory.GetGridRPP(""MG_TaskSummary""),@""EXEC dbo.[GetUserRequestSummaryWithFilters] 1,"" + ISpace[""gv_userid""].Value + @"",'"" + ISpace[""M_ModuleId""].Value + @""','"" + ISpace[""M_CurrentStatus""].Value + @""','"" + ISpace[""SubFilter""].Value + @""','',"" + ISpace[""MF_TaskSummary_PageIndex""].Value + @"",'"" + ISpace[""MF_TaskSummary_GridRows""].Value + @""'"");iSpace.InsertGridBindDetails(""MG_TaskSummary"",""11"",querySourceB7B829491EE0475F95DEBBD6269FEDBF,""EXEC dbo.[GetUserRequestSummaryWithFilters] 1,"" + ISpace[""gv_userid""].Value + @"",'"" + ISpace[""M_ModuleId""].Value + @""','"" + ISpace[""M_CurrentStatus""].Value + @""','"" + ISpace[""SubFilter""].Value + @""','',"" + ISpace[""MF_TaskSummary_PageIndex""].Value + @"",'"" + ISpace[""MF_TaskSummary_GridRows""].Value + @""'"",_objectFactory.GetGridRPP(""MG_TaskSummary""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result67C3863389CE42879063086A3A6BA3EB=acdataIspace2EC4031088B94E21AD43FA1B94EBF785.GetQueryExpressionBindings("67C38633-89CE-4287-9063-086A3A6BA3EB");
iSpace.SetGridData(resultB7B829491EE0475F95DEBBD6269FEDBF,result67C3863389CE42879063086A3A6BA3EB,"MG_TaskSummary",ref ISpace);
iSpace.UpdateGridBindDetails("MG_TaskSummary",result67C3863389CE42879063086A3A6BA3EB);
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC GetUserRequestStatisticsWithFilters 1,'@@gv_UserId','#M_ModuleId','#SubFilter'");

var querySource6A417071941C4F7BA9BB3267F3ED0C08 =GetQueryExpressionDataSource("6A417071-941C-4F7B-A9BB-3267F3ED0C08");
Dictionary<short,object> result6A417071941C4F7BA9BB3267F3ED0C08=iSpace.ExecuteQuery(querySource6A417071941C4F7BA9BB3267F3ED0C08,@"EXEC GetUserRequestStatisticsWithFilters 1,'" + ISpace["gv_userid"].Value + @"','" + ISpace["M_ModuleId"].Value + @"','" + ISpace["SubFilter"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource6A417071941C4F7BA9BB3267F3ED0C08 =GetQueryExpressionDataSource(""6A417071-941C-4F7B-A9BB-3267F3ED0C08"");Dictionary<short,object> result6A417071941C4F7BA9BB3267F3ED0C08=iSpace.ExecuteQuery(querySource6A417071941C4F7BA9BB3267F3ED0C08,@""EXEC GetUserRequestStatisticsWithFilters 1,'"" + ISpace[""gv_userid""].Value + @""','"" + ISpace[""M_ModuleId""].Value + @""','"" + ISpace[""SubFilter""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result6A417071941C4F7BA9BB3267F3ED0C08!=null) && (result6A417071941C4F7BA9BB3267F3ED0C08.Count!=0))
{
if(result6A417071941C4F7BA9BB3267F3ED0C08.ContainsKey(0))
ISpace["M_InitiatedInprogress"].Value = result6A417071941C4F7BA9BB3267F3ED0C08[0];
if(result6A417071941C4F7BA9BB3267F3ED0C08.ContainsKey(1))
ISpace["M_InitiatedCompleted"].Value = result6A417071941C4F7BA9BB3267F3ED0C08[1];
if(result6A417071941C4F7BA9BB3267F3ED0C08.ContainsKey(2))
ISpace["M_ParticipatedInProgress"].Value = result6A417071941C4F7BA9BB3267F3ED0C08[2];
if(result6A417071941C4F7BA9BB3267F3ED0C08.ContainsKey(3))
ISpace["M_ParticipatedCompleted"].Value = result6A417071941C4F7BA9BB3267F3ED0C08[3];
}
else{
ISpace["M_InitiatedInprogress"].Value = null;ISpace["M_InitiatedCompleted"].Value = null;ISpace["M_ParticipatedInProgress"].Value = null;ISpace["M_ParticipatedCompleted"].Value = null;
}
}
if(ISpace["FormVersionId"].Value=="1AA5B3E2-9DA8-490E-B860-328F504DFF0D")
{
ISpace["UI_ViewHistory"].Visible="false";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""1AA5B3E2-9DA8-490E-B860-328F504DFF0D"")
{
ISpace[""UI_ViewHistory""].Visible=""false"";
}");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mf_tasksummary_lastbutton (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MF_TaskSummary_LastButton-OnClick");
ISpace["MF_TaskSummary_PageIndex"].Value=0;
base.WriteDebugInfo(@"ISpace[""MF_TaskSummary_PageIndex""].Value=0;");
if(IsNullOrEmpty(ISpace["M_CurrentStatus"].Value))
{
base.WriteDebugInfo(@"if(IsNullOrEmpty(ISpace[""M_CurrentStatus""].Value))");
ISpace["M_CurrentStatus"].Value="Initiated-Pending";
base.WriteDebugInfo(@"ISpace[""M_CurrentStatus""].Value=""Initiated-Pending"";");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC [dbo].usp_BuildDynamicTaskFilter '#F_TaskName','#F_InitiatedBy','#F_InitiatedStartDate','#F_InitiatedEndDate','#F_Level','#F_CurrentStatus','#F_ProcessName'");

var querySourceF1A1836CA83A4FAB9F41BB56E85274EE =GetQueryExpressionDataSource("F1A1836C-A83A-4FAB-9F41-BB56E85274EE");
Dictionary<short,object> resultF1A1836CA83A4FAB9F41BB56E85274EE=iSpace.ExecuteQuery(querySourceF1A1836CA83A4FAB9F41BB56E85274EE,@"EXEC [dbo].usp_BuildDynamicTaskFilter '" + ISpace["F_TaskName"].Value + @"','" + ISpace["F_InitiatedBy"].Value + @"','" + ISpace["F_InitiatedStartDate"].Value + @"','" + ISpace["F_InitiatedEndDate"].Value + @"','" + ISpace["F_Level"].Value + @"','" + ISpace["F_CurrentStatus"].Value + @"','" + ISpace["F_ProcessName"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceF1A1836CA83A4FAB9F41BB56E85274EE =GetQueryExpressionDataSource(""F1A1836C-A83A-4FAB-9F41-BB56E85274EE"");Dictionary<short,object> resultF1A1836CA83A4FAB9F41BB56E85274EE=iSpace.ExecuteQuery(querySourceF1A1836CA83A4FAB9F41BB56E85274EE,@""EXEC [dbo].usp_BuildDynamicTaskFilter '"" + ISpace[""F_TaskName""].Value + @""','"" + ISpace[""F_InitiatedBy""].Value + @""','"" + ISpace[""F_InitiatedStartDate""].Value + @""','"" + ISpace[""F_InitiatedEndDate""].Value + @""','"" + ISpace[""F_Level""].Value + @""','"" + ISpace[""F_CurrentStatus""].Value + @""','"" + ISpace[""F_ProcessName""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultF1A1836CA83A4FAB9F41BB56E85274EE!=null) && (resultF1A1836CA83A4FAB9F41BB56E85274EE.Count!=0))
{
if(resultF1A1836CA83A4FAB9F41BB56E85274EE.ContainsKey(0))
ISpace["SubFilter"].Value = resultF1A1836CA83A4FAB9F41BB56E85274EE[0];
}
else{
ISpace["SubFilter"].Value = null;
}
ISpace["SubFilter"].Value=Replace(ISpace["SubFIlter"].Value,"'","''");
base.WriteDebugInfo(@"ISpace[""SubFilter""].Value=Replace(ISpace[""SubFIlter""].Value,""'"",""''"");");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC dbo.[GetUserRequestSummaryWithFilters] 0,@@gv_UserId,'#M_ModuleId','#M_CurrentStatus','#SubFilter','',#MF_TaskSummary_PageIndex,'#MF_TaskSummary_GridRows'");

var querySourceE55DE8B65604401D9FA50372DE5D3A21 =GetQueryExpressionDataSource("E55DE8B6-5604-401D-9FA5-0372DE5D3A21");
Dictionary<short,object> resultE55DE8B65604401D9FA50372DE5D3A21=iSpace.ExecuteQuery(querySourceE55DE8B65604401D9FA50372DE5D3A21,@"EXEC dbo.[GetUserRequestSummaryWithFilters] 0," + ISpace["gv_userid"].Value + @",'" + ISpace["M_ModuleId"].Value + @"','" + ISpace["M_CurrentStatus"].Value + @"','" + ISpace["SubFilter"].Value + @"',''," + ISpace["MF_TaskSummary_PageIndex"].Value + @",'" + ISpace["MF_TaskSummary_GridRows"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceE55DE8B65604401D9FA50372DE5D3A21 =GetQueryExpressionDataSource(""E55DE8B6-5604-401D-9FA5-0372DE5D3A21"");Dictionary<short,object> resultE55DE8B65604401D9FA50372DE5D3A21=iSpace.ExecuteQuery(querySourceE55DE8B65604401D9FA50372DE5D3A21,@""EXEC dbo.[GetUserRequestSummaryWithFilters] 0,"" + ISpace[""gv_userid""].Value + @"",'"" + ISpace[""M_ModuleId""].Value + @""','"" + ISpace[""M_CurrentStatus""].Value + @""','"" + ISpace[""SubFilter""].Value + @""','',"" + ISpace[""MF_TaskSummary_PageIndex""].Value + @"",'"" + ISpace[""MF_TaskSummary_GridRows""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultE55DE8B65604401D9FA50372DE5D3A21!=null) && (resultE55DE8B65604401D9FA50372DE5D3A21.Count!=0))
{
if(resultE55DE8B65604401D9FA50372DE5D3A21.ContainsKey(0))
ISpace["MF_TaskSummary_GridRows"].Value = resultE55DE8B65604401D9FA50372DE5D3A21[0];
if(resultE55DE8B65604401D9FA50372DE5D3A21.ContainsKey(3))
ISpace["MF_TaskSummary_TotalPages"].Value = resultE55DE8B65604401D9FA50372DE5D3A21[3];
if(resultE55DE8B65604401D9FA50372DE5D3A21.ContainsKey(2))
ISpace["MF_TaskSummary_PageIndex"].Value = resultE55DE8B65604401D9FA50372DE5D3A21[2];
if(resultE55DE8B65604401D9FA50372DE5D3A21.ContainsKey(1))
ISpace["MF_TaskSummary_RecordsRange"].Value = resultE55DE8B65604401D9FA50372DE5D3A21[1];
}
else{
ISpace["MF_TaskSummary_GridRows"].Value = null;ISpace["MF_TaskSummary_TotalPages"].Value = null;ISpace["MF_TaskSummary_PageIndex"].Value = null;ISpace["MF_TaskSummary_RecordsRange"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_TaskSummary_PageIndex"].Value==1||ISpace["MF_TaskSummary_PageIndex"].Value==0)
{
base.WriteDebugInfo(@"if(ISpace[""MF_TaskSummary_PageIndex""].Value==1||ISpace[""MF_TaskSummary_PageIndex""].Value==0)");
if(ISpace["MF_TaskSummary_PageIndex"].Value==ISpace["MF_TaskSummary_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_TaskSummary_PageIndex""].Value==ISpace[""MF_TaskSummary_TotalPages""].Value)");
ISpace["MF_TaskSummary_FirstButton"].Enbl="false";ISpace["MF_TaskSummary_LastButton"].Enbl="false";ISpace["MF_TaskSummary_PageIndex"].Enbl="false";ISpace["MF_TaskSummary_NextButton"].Enbl="false";ISpace["MF_TaskSummary_PrevButton"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MF_TaskSummary_FirstButton""].Enbl=""false"";ISpace[""MF_TaskSummary_LastButton""].Enbl=""false"";ISpace[""MF_TaskSummary_PageIndex""].Enbl=""false"";ISpace[""MF_TaskSummary_NextButton""].Enbl=""false"";ISpace[""MF_TaskSummary_PrevButton""].Enbl=""false"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_TaskSummary_FirstButton"].Enbl="false";ISpace["MF_TaskSummary_LastButton"].Enbl="true";ISpace["MF_TaskSummary_PageIndex"].Enbl="true";ISpace["MF_TaskSummary_NextButton"].Enbl="true";ISpace["MF_TaskSummary_PrevButton"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MF_TaskSummary_FirstButton""].Enbl=""false"";ISpace[""MF_TaskSummary_LastButton""].Enbl=""true"";ISpace[""MF_TaskSummary_PageIndex""].Enbl=""true"";ISpace[""MF_TaskSummary_NextButton""].Enbl=""true"";ISpace[""MF_TaskSummary_PrevButton""].Enbl=""false"";");
}
}
else
{
base.WriteDebugInfo(@"else");
if(ISpace["MF_TaskSummary_PageIndex"].Value==ISpace["MF_TaskSummary_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_TaskSummary_PageIndex""].Value==ISpace[""MF_TaskSummary_TotalPages""].Value)");
ISpace["MF_TaskSummary_FirstButton"].Enbl="true";ISpace["MF_TaskSummary_LastButton"].Enbl="false";ISpace["MF_TaskSummary_PageIndex"].Enbl="true";ISpace["MF_TaskSummary_NextButton"].Enbl="false";ISpace["MF_TaskSummary_PrevButton"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_TaskSummary_FirstButton""].Enbl=""true"";ISpace[""MF_TaskSummary_LastButton""].Enbl=""false"";ISpace[""MF_TaskSummary_PageIndex""].Enbl=""true"";ISpace[""MF_TaskSummary_NextButton""].Enbl=""false"";ISpace[""MF_TaskSummary_PrevButton""].Enbl=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_TaskSummary_FirstButton"].Enbl="true";ISpace["MF_TaskSummary_LastButton"].Enbl="true";ISpace["MF_TaskSummary_PageIndex"].Enbl="true";ISpace["MF_TaskSummary_NextButton"].Enbl="true";ISpace["MF_TaskSummary_PrevButton"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_TaskSummary_FirstButton""].Enbl=""true"";ISpace[""MF_TaskSummary_LastButton""].Enbl=""true"";ISpace[""MF_TaskSummary_PageIndex""].Enbl=""true"";ISpace[""MF_TaskSummary_NextButton""].Enbl=""true"";ISpace[""MF_TaskSummary_PrevButton""].Enbl=""true"";");
}
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySourceB7B829491EE0475F95DEBBD6269FEDBF =GetQueryExpressionDataSource("B7B82949-1EE0-475F-95DE-BBD6269FEDBF");

DataTable resultB7B829491EE0475F95DEBBD6269FEDBF=iSpace.SetGridDataSource(querySourceB7B829491EE0475F95DEBBD6269FEDBF, _objectFactory.GetGridRPP("MG_TaskSummary"),@"EXEC dbo.[GetUserRequestSummaryWithFilters] 1," + ISpace["gv_userid"].Value + @",'" + ISpace["M_ModuleId"].Value + @"','" + ISpace["M_CurrentStatus"].Value + @"','" + ISpace["SubFilter"].Value + @"',''," + ISpace["MF_TaskSummary_PageIndex"].Value + @",'" + ISpace["MF_TaskSummary_GridRows"].Value + @"'");

iSpace.InsertGridBindDetails("MG_TaskSummary","11",querySourceB7B829491EE0475F95DEBBD6269FEDBF,"EXEC dbo.[GetUserRequestSummaryWithFilters] 1," + ISpace["gv_userid"].Value + @",'" + ISpace["M_ModuleId"].Value + @"','" + ISpace["M_CurrentStatus"].Value + @"','" + ISpace["SubFilter"].Value + @"',''," + ISpace["MF_TaskSummary_PageIndex"].Value + @",'" + ISpace["MF_TaskSummary_GridRows"].Value + @"'",_objectFactory.GetGridRPP("MG_TaskSummary"));

base.WriteDebugInfo(@"var querySourceB7B829491EE0475F95DEBBD6269FEDBF =GetQueryExpressionDataSource(""B7B82949-1EE0-475F-95DE-BBD6269FEDBF"");DataTable resultB7B829491EE0475F95DEBBD6269FEDBF=iSpace.SetGridDataSource(querySourceB7B829491EE0475F95DEBBD6269FEDBF, _objectFactory.GetGridRPP(""MG_TaskSummary""),@""EXEC dbo.[GetUserRequestSummaryWithFilters] 1,"" + ISpace[""gv_userid""].Value + @"",'"" + ISpace[""M_ModuleId""].Value + @""','"" + ISpace[""M_CurrentStatus""].Value + @""','"" + ISpace[""SubFilter""].Value + @""','',"" + ISpace[""MF_TaskSummary_PageIndex""].Value + @"",'"" + ISpace[""MF_TaskSummary_GridRows""].Value + @""'"");iSpace.InsertGridBindDetails(""MG_TaskSummary"",""11"",querySourceB7B829491EE0475F95DEBBD6269FEDBF,""EXEC dbo.[GetUserRequestSummaryWithFilters] 1,"" + ISpace[""gv_userid""].Value + @"",'"" + ISpace[""M_ModuleId""].Value + @""','"" + ISpace[""M_CurrentStatus""].Value + @""','"" + ISpace[""SubFilter""].Value + @""','',"" + ISpace[""MF_TaskSummary_PageIndex""].Value + @"",'"" + ISpace[""MF_TaskSummary_GridRows""].Value + @""'"",_objectFactory.GetGridRPP(""MG_TaskSummary""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result67C3863389CE42879063086A3A6BA3EB=acdataIspace2EC4031088B94E21AD43FA1B94EBF785.GetQueryExpressionBindings("67C38633-89CE-4287-9063-086A3A6BA3EB");
iSpace.SetGridData(resultB7B829491EE0475F95DEBBD6269FEDBF,result67C3863389CE42879063086A3A6BA3EB,"MG_TaskSummary",ref ISpace);
iSpace.UpdateGridBindDetails("MG_TaskSummary",result67C3863389CE42879063086A3A6BA3EB);
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_ts_processname (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"TS_ProcessName-OnClick");
ISpace["M_ViewUrl"].Value=ISpace["TS_ViewUrl"].Value;
base.WriteDebugInfo(@"ISpace[""M_ViewUrl""].Value=ISpace[""TS_ViewUrl""].Value;");
iSpace.RedirectNewWindow(ref ISpace,ISpace["M_ViewUrl"].Value);
base.WriteDebugInfo(@"iSpace.RedirectNewWindow(ref ISpace,ISpace[""M_ViewUrl""].Value);");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mf_tasksummary_pageindex (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MF_TaskSummary_PageIndex-OnChange");
ISpace["MF_Option"].Value=1;
base.WriteDebugInfo(@"ISpace[""MF_Option""].Value=1;");
if(IsNullOrEmpty(ISpace["M_CurrentStatus"].Value))
{
base.WriteDebugInfo(@"if(IsNullOrEmpty(ISpace[""M_CurrentStatus""].Value))");
ISpace["M_CurrentStatus"].Value="Initiated-Pending";
base.WriteDebugInfo(@"ISpace[""M_CurrentStatus""].Value=""Initiated-Pending"";");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC [dbo].usp_BuildDynamicTaskFilter '#F_TaskName','#F_InitiatedBy','#F_InitiatedStartDate','#F_InitiatedEndDate','#F_Level','#F_CurrentStatus','#F_ProcessName'");

var querySourceF1A1836CA83A4FAB9F41BB56E85274EE =GetQueryExpressionDataSource("F1A1836C-A83A-4FAB-9F41-BB56E85274EE");
Dictionary<short,object> resultF1A1836CA83A4FAB9F41BB56E85274EE=iSpace.ExecuteQuery(querySourceF1A1836CA83A4FAB9F41BB56E85274EE,@"EXEC [dbo].usp_BuildDynamicTaskFilter '" + ISpace["F_TaskName"].Value + @"','" + ISpace["F_InitiatedBy"].Value + @"','" + ISpace["F_InitiatedStartDate"].Value + @"','" + ISpace["F_InitiatedEndDate"].Value + @"','" + ISpace["F_Level"].Value + @"','" + ISpace["F_CurrentStatus"].Value + @"','" + ISpace["F_ProcessName"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceF1A1836CA83A4FAB9F41BB56E85274EE =GetQueryExpressionDataSource(""F1A1836C-A83A-4FAB-9F41-BB56E85274EE"");Dictionary<short,object> resultF1A1836CA83A4FAB9F41BB56E85274EE=iSpace.ExecuteQuery(querySourceF1A1836CA83A4FAB9F41BB56E85274EE,@""EXEC [dbo].usp_BuildDynamicTaskFilter '"" + ISpace[""F_TaskName""].Value + @""','"" + ISpace[""F_InitiatedBy""].Value + @""','"" + ISpace[""F_InitiatedStartDate""].Value + @""','"" + ISpace[""F_InitiatedEndDate""].Value + @""','"" + ISpace[""F_Level""].Value + @""','"" + ISpace[""F_CurrentStatus""].Value + @""','"" + ISpace[""F_ProcessName""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultF1A1836CA83A4FAB9F41BB56E85274EE!=null) && (resultF1A1836CA83A4FAB9F41BB56E85274EE.Count!=0))
{
if(resultF1A1836CA83A4FAB9F41BB56E85274EE.ContainsKey(0))
ISpace["SubFilter"].Value = resultF1A1836CA83A4FAB9F41BB56E85274EE[0];
}
else{
ISpace["SubFilter"].Value = null;
}
ISpace["SubFilter"].Value=Replace(ISpace["SubFIlter"].Value,"'","''");
base.WriteDebugInfo(@"ISpace[""SubFilter""].Value=Replace(ISpace[""SubFIlter""].Value,""'"",""''"");");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC dbo.[GetUserRequestSummaryWithFilters] 0,@@gv_UserId,'#M_ModuleId','#M_CurrentStatus','#SubFilter','',#MF_TaskSummary_PageIndex,'#MF_TaskSummary_GridRows'");

var querySourceE55DE8B65604401D9FA50372DE5D3A21 =GetQueryExpressionDataSource("E55DE8B6-5604-401D-9FA5-0372DE5D3A21");
Dictionary<short,object> resultE55DE8B65604401D9FA50372DE5D3A21=iSpace.ExecuteQuery(querySourceE55DE8B65604401D9FA50372DE5D3A21,@"EXEC dbo.[GetUserRequestSummaryWithFilters] 0," + ISpace["gv_userid"].Value + @",'" + ISpace["M_ModuleId"].Value + @"','" + ISpace["M_CurrentStatus"].Value + @"','" + ISpace["SubFilter"].Value + @"',''," + ISpace["MF_TaskSummary_PageIndex"].Value + @",'" + ISpace["MF_TaskSummary_GridRows"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceE55DE8B65604401D9FA50372DE5D3A21 =GetQueryExpressionDataSource(""E55DE8B6-5604-401D-9FA5-0372DE5D3A21"");Dictionary<short,object> resultE55DE8B65604401D9FA50372DE5D3A21=iSpace.ExecuteQuery(querySourceE55DE8B65604401D9FA50372DE5D3A21,@""EXEC dbo.[GetUserRequestSummaryWithFilters] 0,"" + ISpace[""gv_userid""].Value + @"",'"" + ISpace[""M_ModuleId""].Value + @""','"" + ISpace[""M_CurrentStatus""].Value + @""','"" + ISpace[""SubFilter""].Value + @""','',"" + ISpace[""MF_TaskSummary_PageIndex""].Value + @"",'"" + ISpace[""MF_TaskSummary_GridRows""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultE55DE8B65604401D9FA50372DE5D3A21!=null) && (resultE55DE8B65604401D9FA50372DE5D3A21.Count!=0))
{
if(resultE55DE8B65604401D9FA50372DE5D3A21.ContainsKey(0))
ISpace["MF_TaskSummary_GridRows"].Value = resultE55DE8B65604401D9FA50372DE5D3A21[0];
if(resultE55DE8B65604401D9FA50372DE5D3A21.ContainsKey(3))
ISpace["MF_TaskSummary_TotalPages"].Value = resultE55DE8B65604401D9FA50372DE5D3A21[3];
if(resultE55DE8B65604401D9FA50372DE5D3A21.ContainsKey(2))
ISpace["MF_TaskSummary_PageIndex"].Value = resultE55DE8B65604401D9FA50372DE5D3A21[2];
if(resultE55DE8B65604401D9FA50372DE5D3A21.ContainsKey(1))
ISpace["MF_TaskSummary_RecordsRange"].Value = resultE55DE8B65604401D9FA50372DE5D3A21[1];
}
else{
ISpace["MF_TaskSummary_GridRows"].Value = null;ISpace["MF_TaskSummary_TotalPages"].Value = null;ISpace["MF_TaskSummary_PageIndex"].Value = null;ISpace["MF_TaskSummary_RecordsRange"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_TaskSummary_PageIndex"].Value==1||ISpace["MF_TaskSummary_PageIndex"].Value==0)
{
base.WriteDebugInfo(@"if(ISpace[""MF_TaskSummary_PageIndex""].Value==1||ISpace[""MF_TaskSummary_PageIndex""].Value==0)");
if(ISpace["MF_TaskSummary_PageIndex"].Value==ISpace["MF_TaskSummary_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_TaskSummary_PageIndex""].Value==ISpace[""MF_TaskSummary_TotalPages""].Value)");
ISpace["MF_TaskSummary_FirstButton"].Enbl="false";ISpace["MF_TaskSummary_LastButton"].Enbl="false";ISpace["MF_TaskSummary_PageIndex"].Enbl="false";ISpace["MF_TaskSummary_NextButton"].Enbl="false";ISpace["MF_TaskSummary_PrevButton"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MF_TaskSummary_FirstButton""].Enbl=""false"";ISpace[""MF_TaskSummary_LastButton""].Enbl=""false"";ISpace[""MF_TaskSummary_PageIndex""].Enbl=""false"";ISpace[""MF_TaskSummary_NextButton""].Enbl=""false"";ISpace[""MF_TaskSummary_PrevButton""].Enbl=""false"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_TaskSummary_FirstButton"].Enbl="false";ISpace["MF_TaskSummary_LastButton"].Enbl="true";ISpace["MF_TaskSummary_PageIndex"].Enbl="true";ISpace["MF_TaskSummary_NextButton"].Enbl="true";ISpace["MF_TaskSummary_PrevButton"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MF_TaskSummary_FirstButton""].Enbl=""false"";ISpace[""MF_TaskSummary_LastButton""].Enbl=""true"";ISpace[""MF_TaskSummary_PageIndex""].Enbl=""true"";ISpace[""MF_TaskSummary_NextButton""].Enbl=""true"";ISpace[""MF_TaskSummary_PrevButton""].Enbl=""false"";");
}
}
else
{
base.WriteDebugInfo(@"else");
if(ISpace["MF_TaskSummary_PageIndex"].Value==ISpace["MF_TaskSummary_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_TaskSummary_PageIndex""].Value==ISpace[""MF_TaskSummary_TotalPages""].Value)");
ISpace["MF_TaskSummary_FirstButton"].Enbl="true";ISpace["MF_TaskSummary_LastButton"].Enbl="false";ISpace["MF_TaskSummary_PageIndex"].Enbl="true";ISpace["MF_TaskSummary_NextButton"].Enbl="false";ISpace["MF_TaskSummary_PrevButton"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_TaskSummary_FirstButton""].Enbl=""true"";ISpace[""MF_TaskSummary_LastButton""].Enbl=""false"";ISpace[""MF_TaskSummary_PageIndex""].Enbl=""true"";ISpace[""MF_TaskSummary_NextButton""].Enbl=""false"";ISpace[""MF_TaskSummary_PrevButton""].Enbl=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_TaskSummary_FirstButton"].Enbl="true";ISpace["MF_TaskSummary_LastButton"].Enbl="true";ISpace["MF_TaskSummary_PageIndex"].Enbl="true";ISpace["MF_TaskSummary_NextButton"].Enbl="true";ISpace["MF_TaskSummary_PrevButton"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_TaskSummary_FirstButton""].Enbl=""true"";ISpace[""MF_TaskSummary_LastButton""].Enbl=""true"";ISpace[""MF_TaskSummary_PageIndex""].Enbl=""true"";ISpace[""MF_TaskSummary_NextButton""].Enbl=""true"";ISpace[""MF_TaskSummary_PrevButton""].Enbl=""true"";");
}
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySourceB7B829491EE0475F95DEBBD6269FEDBF =GetQueryExpressionDataSource("B7B82949-1EE0-475F-95DE-BBD6269FEDBF");

DataTable resultB7B829491EE0475F95DEBBD6269FEDBF=iSpace.SetGridDataSource(querySourceB7B829491EE0475F95DEBBD6269FEDBF, _objectFactory.GetGridRPP("MG_TaskSummary"),@"EXEC dbo.[GetUserRequestSummaryWithFilters] 1," + ISpace["gv_userid"].Value + @",'" + ISpace["M_ModuleId"].Value + @"','" + ISpace["M_CurrentStatus"].Value + @"','" + ISpace["SubFilter"].Value + @"',''," + ISpace["MF_TaskSummary_PageIndex"].Value + @",'" + ISpace["MF_TaskSummary_GridRows"].Value + @"'");

iSpace.InsertGridBindDetails("MG_TaskSummary","11",querySourceB7B829491EE0475F95DEBBD6269FEDBF,"EXEC dbo.[GetUserRequestSummaryWithFilters] 1," + ISpace["gv_userid"].Value + @",'" + ISpace["M_ModuleId"].Value + @"','" + ISpace["M_CurrentStatus"].Value + @"','" + ISpace["SubFilter"].Value + @"',''," + ISpace["MF_TaskSummary_PageIndex"].Value + @",'" + ISpace["MF_TaskSummary_GridRows"].Value + @"'",_objectFactory.GetGridRPP("MG_TaskSummary"));

base.WriteDebugInfo(@"var querySourceB7B829491EE0475F95DEBBD6269FEDBF =GetQueryExpressionDataSource(""B7B82949-1EE0-475F-95DE-BBD6269FEDBF"");DataTable resultB7B829491EE0475F95DEBBD6269FEDBF=iSpace.SetGridDataSource(querySourceB7B829491EE0475F95DEBBD6269FEDBF, _objectFactory.GetGridRPP(""MG_TaskSummary""),@""EXEC dbo.[GetUserRequestSummaryWithFilters] 1,"" + ISpace[""gv_userid""].Value + @"",'"" + ISpace[""M_ModuleId""].Value + @""','"" + ISpace[""M_CurrentStatus""].Value + @""','"" + ISpace[""SubFilter""].Value + @""','',"" + ISpace[""MF_TaskSummary_PageIndex""].Value + @"",'"" + ISpace[""MF_TaskSummary_GridRows""].Value + @""'"");iSpace.InsertGridBindDetails(""MG_TaskSummary"",""11"",querySourceB7B829491EE0475F95DEBBD6269FEDBF,""EXEC dbo.[GetUserRequestSummaryWithFilters] 1,"" + ISpace[""gv_userid""].Value + @"",'"" + ISpace[""M_ModuleId""].Value + @""','"" + ISpace[""M_CurrentStatus""].Value + @""','"" + ISpace[""SubFilter""].Value + @""','',"" + ISpace[""MF_TaskSummary_PageIndex""].Value + @"",'"" + ISpace[""MF_TaskSummary_GridRows""].Value + @""'"",_objectFactory.GetGridRPP(""MG_TaskSummary""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result67C3863389CE42879063086A3A6BA3EB=acdataIspace2EC4031088B94E21AD43FA1B94EBF785.GetQueryExpressionBindings("67C38633-89CE-4287-9063-086A3A6BA3EB");
iSpace.SetGridData(resultB7B829491EE0475F95DEBBD6269FEDBF,result67C3863389CE42879063086A3A6BA3EB,"MG_TaskSummary",ref ISpace);
iSpace.UpdateGridBindDetails("MG_TaskSummary",result67C3863389CE42879063086A3A6BA3EB);
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mf_tasksummary_nextbutton (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MF_TaskSummary_NextButton-OnClick");
if(ISpace["MF_TaskSummary_PageIndex"].Value>0)
{
base.WriteDebugInfo(@"if(ISpace[""MF_TaskSummary_PageIndex""].Value>0)");
ISpace["MF_TaskSummary_PageIndex"].Value=ISpace["MF_TaskSummary_PageIndex"].Value+1;
base.WriteDebugInfo(@"ISpace[""MF_TaskSummary_PageIndex""].Value=ISpace[""MF_TaskSummary_PageIndex""].Value+1;");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_TaskSummary_PageIndex"].Value=1;
base.WriteDebugInfo(@"ISpace[""MF_TaskSummary_PageIndex""].Value=1;");
}
if(IsNullOrEmpty(ISpace["M_CurrentStatus"].Value))
{
base.WriteDebugInfo(@"if(IsNullOrEmpty(ISpace[""M_CurrentStatus""].Value))");
ISpace["M_CurrentStatus"].Value="Initiated-Pending";
base.WriteDebugInfo(@"ISpace[""M_CurrentStatus""].Value=""Initiated-Pending"";");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC [dbo].usp_BuildDynamicTaskFilter '#F_TaskName','#F_InitiatedBy','#F_InitiatedStartDate','#F_InitiatedEndDate','#F_Level','#F_CurrentStatus','#F_ProcessName'");

var querySourceF1A1836CA83A4FAB9F41BB56E85274EE =GetQueryExpressionDataSource("F1A1836C-A83A-4FAB-9F41-BB56E85274EE");
Dictionary<short,object> resultF1A1836CA83A4FAB9F41BB56E85274EE=iSpace.ExecuteQuery(querySourceF1A1836CA83A4FAB9F41BB56E85274EE,@"EXEC [dbo].usp_BuildDynamicTaskFilter '" + ISpace["F_TaskName"].Value + @"','" + ISpace["F_InitiatedBy"].Value + @"','" + ISpace["F_InitiatedStartDate"].Value + @"','" + ISpace["F_InitiatedEndDate"].Value + @"','" + ISpace["F_Level"].Value + @"','" + ISpace["F_CurrentStatus"].Value + @"','" + ISpace["F_ProcessName"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceF1A1836CA83A4FAB9F41BB56E85274EE =GetQueryExpressionDataSource(""F1A1836C-A83A-4FAB-9F41-BB56E85274EE"");Dictionary<short,object> resultF1A1836CA83A4FAB9F41BB56E85274EE=iSpace.ExecuteQuery(querySourceF1A1836CA83A4FAB9F41BB56E85274EE,@""EXEC [dbo].usp_BuildDynamicTaskFilter '"" + ISpace[""F_TaskName""].Value + @""','"" + ISpace[""F_InitiatedBy""].Value + @""','"" + ISpace[""F_InitiatedStartDate""].Value + @""','"" + ISpace[""F_InitiatedEndDate""].Value + @""','"" + ISpace[""F_Level""].Value + @""','"" + ISpace[""F_CurrentStatus""].Value + @""','"" + ISpace[""F_ProcessName""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultF1A1836CA83A4FAB9F41BB56E85274EE!=null) && (resultF1A1836CA83A4FAB9F41BB56E85274EE.Count!=0))
{
if(resultF1A1836CA83A4FAB9F41BB56E85274EE.ContainsKey(0))
ISpace["SubFilter"].Value = resultF1A1836CA83A4FAB9F41BB56E85274EE[0];
}
else{
ISpace["SubFilter"].Value = null;
}
ISpace["SubFilter"].Value=Replace(ISpace["SubFIlter"].Value,"'","''");
base.WriteDebugInfo(@"ISpace[""SubFilter""].Value=Replace(ISpace[""SubFIlter""].Value,""'"",""''"");");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC dbo.[GetUserRequestSummaryWithFilters] 0,@@gv_UserId,'#M_ModuleId','#M_CurrentStatus','#SubFilter','',#MF_TaskSummary_PageIndex,'#MF_TaskSummary_GridRows'");

var querySourceE55DE8B65604401D9FA50372DE5D3A21 =GetQueryExpressionDataSource("E55DE8B6-5604-401D-9FA5-0372DE5D3A21");
Dictionary<short,object> resultE55DE8B65604401D9FA50372DE5D3A21=iSpace.ExecuteQuery(querySourceE55DE8B65604401D9FA50372DE5D3A21,@"EXEC dbo.[GetUserRequestSummaryWithFilters] 0," + ISpace["gv_userid"].Value + @",'" + ISpace["M_ModuleId"].Value + @"','" + ISpace["M_CurrentStatus"].Value + @"','" + ISpace["SubFilter"].Value + @"',''," + ISpace["MF_TaskSummary_PageIndex"].Value + @",'" + ISpace["MF_TaskSummary_GridRows"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceE55DE8B65604401D9FA50372DE5D3A21 =GetQueryExpressionDataSource(""E55DE8B6-5604-401D-9FA5-0372DE5D3A21"");Dictionary<short,object> resultE55DE8B65604401D9FA50372DE5D3A21=iSpace.ExecuteQuery(querySourceE55DE8B65604401D9FA50372DE5D3A21,@""EXEC dbo.[GetUserRequestSummaryWithFilters] 0,"" + ISpace[""gv_userid""].Value + @"",'"" + ISpace[""M_ModuleId""].Value + @""','"" + ISpace[""M_CurrentStatus""].Value + @""','"" + ISpace[""SubFilter""].Value + @""','',"" + ISpace[""MF_TaskSummary_PageIndex""].Value + @"",'"" + ISpace[""MF_TaskSummary_GridRows""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultE55DE8B65604401D9FA50372DE5D3A21!=null) && (resultE55DE8B65604401D9FA50372DE5D3A21.Count!=0))
{
if(resultE55DE8B65604401D9FA50372DE5D3A21.ContainsKey(0))
ISpace["MF_TaskSummary_GridRows"].Value = resultE55DE8B65604401D9FA50372DE5D3A21[0];
if(resultE55DE8B65604401D9FA50372DE5D3A21.ContainsKey(3))
ISpace["MF_TaskSummary_TotalPages"].Value = resultE55DE8B65604401D9FA50372DE5D3A21[3];
if(resultE55DE8B65604401D9FA50372DE5D3A21.ContainsKey(2))
ISpace["MF_TaskSummary_PageIndex"].Value = resultE55DE8B65604401D9FA50372DE5D3A21[2];
if(resultE55DE8B65604401D9FA50372DE5D3A21.ContainsKey(1))
ISpace["MF_TaskSummary_RecordsRange"].Value = resultE55DE8B65604401D9FA50372DE5D3A21[1];
}
else{
ISpace["MF_TaskSummary_GridRows"].Value = null;ISpace["MF_TaskSummary_TotalPages"].Value = null;ISpace["MF_TaskSummary_PageIndex"].Value = null;ISpace["MF_TaskSummary_RecordsRange"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_TaskSummary_PageIndex"].Value==1||ISpace["MF_TaskSummary_PageIndex"].Value==0)
{
base.WriteDebugInfo(@"if(ISpace[""MF_TaskSummary_PageIndex""].Value==1||ISpace[""MF_TaskSummary_PageIndex""].Value==0)");
if(ISpace["MF_TaskSummary_PageIndex"].Value==ISpace["MF_TaskSummary_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_TaskSummary_PageIndex""].Value==ISpace[""MF_TaskSummary_TotalPages""].Value)");
ISpace["MF_TaskSummary_FirstButton"].Enbl="false";ISpace["MF_TaskSummary_LastButton"].Enbl="false";ISpace["MF_TaskSummary_PageIndex"].Enbl="false";ISpace["MF_TaskSummary_NextButton"].Enbl="false";ISpace["MF_TaskSummary_PrevButton"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MF_TaskSummary_FirstButton""].Enbl=""false"";ISpace[""MF_TaskSummary_LastButton""].Enbl=""false"";ISpace[""MF_TaskSummary_PageIndex""].Enbl=""false"";ISpace[""MF_TaskSummary_NextButton""].Enbl=""false"";ISpace[""MF_TaskSummary_PrevButton""].Enbl=""false"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_TaskSummary_FirstButton"].Enbl="false";ISpace["MF_TaskSummary_LastButton"].Enbl="true";ISpace["MF_TaskSummary_PageIndex"].Enbl="true";ISpace["MF_TaskSummary_NextButton"].Enbl="true";ISpace["MF_TaskSummary_PrevButton"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MF_TaskSummary_FirstButton""].Enbl=""false"";ISpace[""MF_TaskSummary_LastButton""].Enbl=""true"";ISpace[""MF_TaskSummary_PageIndex""].Enbl=""true"";ISpace[""MF_TaskSummary_NextButton""].Enbl=""true"";ISpace[""MF_TaskSummary_PrevButton""].Enbl=""false"";");
}
}
else
{
base.WriteDebugInfo(@"else");
if(ISpace["MF_TaskSummary_PageIndex"].Value==ISpace["MF_TaskSummary_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_TaskSummary_PageIndex""].Value==ISpace[""MF_TaskSummary_TotalPages""].Value)");
ISpace["MF_TaskSummary_FirstButton"].Enbl="true";ISpace["MF_TaskSummary_LastButton"].Enbl="false";ISpace["MF_TaskSummary_PageIndex"].Enbl="true";ISpace["MF_TaskSummary_NextButton"].Enbl="false";ISpace["MF_TaskSummary_PrevButton"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_TaskSummary_FirstButton""].Enbl=""true"";ISpace[""MF_TaskSummary_LastButton""].Enbl=""false"";ISpace[""MF_TaskSummary_PageIndex""].Enbl=""true"";ISpace[""MF_TaskSummary_NextButton""].Enbl=""false"";ISpace[""MF_TaskSummary_PrevButton""].Enbl=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_TaskSummary_FirstButton"].Enbl="true";ISpace["MF_TaskSummary_LastButton"].Enbl="true";ISpace["MF_TaskSummary_PageIndex"].Enbl="true";ISpace["MF_TaskSummary_NextButton"].Enbl="true";ISpace["MF_TaskSummary_PrevButton"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_TaskSummary_FirstButton""].Enbl=""true"";ISpace[""MF_TaskSummary_LastButton""].Enbl=""true"";ISpace[""MF_TaskSummary_PageIndex""].Enbl=""true"";ISpace[""MF_TaskSummary_NextButton""].Enbl=""true"";ISpace[""MF_TaskSummary_PrevButton""].Enbl=""true"";");
}
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySourceB7B829491EE0475F95DEBBD6269FEDBF =GetQueryExpressionDataSource("B7B82949-1EE0-475F-95DE-BBD6269FEDBF");

DataTable resultB7B829491EE0475F95DEBBD6269FEDBF=iSpace.SetGridDataSource(querySourceB7B829491EE0475F95DEBBD6269FEDBF, _objectFactory.GetGridRPP("MG_TaskSummary"),@"EXEC dbo.[GetUserRequestSummaryWithFilters] 1," + ISpace["gv_userid"].Value + @",'" + ISpace["M_ModuleId"].Value + @"','" + ISpace["M_CurrentStatus"].Value + @"','" + ISpace["SubFilter"].Value + @"',''," + ISpace["MF_TaskSummary_PageIndex"].Value + @",'" + ISpace["MF_TaskSummary_GridRows"].Value + @"'");

iSpace.InsertGridBindDetails("MG_TaskSummary","11",querySourceB7B829491EE0475F95DEBBD6269FEDBF,"EXEC dbo.[GetUserRequestSummaryWithFilters] 1," + ISpace["gv_userid"].Value + @",'" + ISpace["M_ModuleId"].Value + @"','" + ISpace["M_CurrentStatus"].Value + @"','" + ISpace["SubFilter"].Value + @"',''," + ISpace["MF_TaskSummary_PageIndex"].Value + @",'" + ISpace["MF_TaskSummary_GridRows"].Value + @"'",_objectFactory.GetGridRPP("MG_TaskSummary"));

base.WriteDebugInfo(@"var querySourceB7B829491EE0475F95DEBBD6269FEDBF =GetQueryExpressionDataSource(""B7B82949-1EE0-475F-95DE-BBD6269FEDBF"");DataTable resultB7B829491EE0475F95DEBBD6269FEDBF=iSpace.SetGridDataSource(querySourceB7B829491EE0475F95DEBBD6269FEDBF, _objectFactory.GetGridRPP(""MG_TaskSummary""),@""EXEC dbo.[GetUserRequestSummaryWithFilters] 1,"" + ISpace[""gv_userid""].Value + @"",'"" + ISpace[""M_ModuleId""].Value + @""','"" + ISpace[""M_CurrentStatus""].Value + @""','"" + ISpace[""SubFilter""].Value + @""','',"" + ISpace[""MF_TaskSummary_PageIndex""].Value + @"",'"" + ISpace[""MF_TaskSummary_GridRows""].Value + @""'"");iSpace.InsertGridBindDetails(""MG_TaskSummary"",""11"",querySourceB7B829491EE0475F95DEBBD6269FEDBF,""EXEC dbo.[GetUserRequestSummaryWithFilters] 1,"" + ISpace[""gv_userid""].Value + @"",'"" + ISpace[""M_ModuleId""].Value + @""','"" + ISpace[""M_CurrentStatus""].Value + @""','"" + ISpace[""SubFilter""].Value + @""','',"" + ISpace[""MF_TaskSummary_PageIndex""].Value + @"",'"" + ISpace[""MF_TaskSummary_GridRows""].Value + @""'"",_objectFactory.GetGridRPP(""MG_TaskSummary""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result67C3863389CE42879063086A3A6BA3EB=acdataIspace2EC4031088B94E21AD43FA1B94EBF785.GetQueryExpressionBindings("67C38633-89CE-4287-9063-086A3A6BA3EB");
iSpace.SetGridData(resultB7B829491EE0475F95DEBBD6269FEDBF,result67C3863389CE42879063086A3A6BA3EB,"MG_TaskSummary",ref ISpace);
iSpace.UpdateGridBindDetails("MG_TaskSummary",result67C3863389CE42879063086A3A6BA3EB);
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mf_tasksummary_prevbutton (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MF_TaskSummary_PrevButton-OnClick");
if(ISpace["MF_TaskSummary_PageIndex"].Value>2)
{
base.WriteDebugInfo(@"if(ISpace[""MF_TaskSummary_PageIndex""].Value>2)");
ISpace["MF_TaskSummary_PageIndex"].Value=ISpace["MF_TaskSummary_PageIndex"].Value-1;
base.WriteDebugInfo(@"ISpace[""MF_TaskSummary_PageIndex""].Value=ISpace[""MF_TaskSummary_PageIndex""].Value-1;");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_TaskSummary_PageIndex"].Value=1;
base.WriteDebugInfo(@"ISpace[""MF_TaskSummary_PageIndex""].Value=1;");
}
if(IsNullOrEmpty(ISpace["M_CurrentStatus"].Value))
{
base.WriteDebugInfo(@"if(IsNullOrEmpty(ISpace[""M_CurrentStatus""].Value))");
ISpace["M_CurrentStatus"].Value="Initiated-Pending";
base.WriteDebugInfo(@"ISpace[""M_CurrentStatus""].Value=""Initiated-Pending"";");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC [dbo].usp_BuildDynamicTaskFilter '#F_TaskName','#F_InitiatedBy','#F_InitiatedStartDate','#F_InitiatedEndDate','#F_Level','#F_CurrentStatus','#F_ProcessName'");

var querySourceF1A1836CA83A4FAB9F41BB56E85274EE =GetQueryExpressionDataSource("F1A1836C-A83A-4FAB-9F41-BB56E85274EE");
Dictionary<short,object> resultF1A1836CA83A4FAB9F41BB56E85274EE=iSpace.ExecuteQuery(querySourceF1A1836CA83A4FAB9F41BB56E85274EE,@"EXEC [dbo].usp_BuildDynamicTaskFilter '" + ISpace["F_TaskName"].Value + @"','" + ISpace["F_InitiatedBy"].Value + @"','" + ISpace["F_InitiatedStartDate"].Value + @"','" + ISpace["F_InitiatedEndDate"].Value + @"','" + ISpace["F_Level"].Value + @"','" + ISpace["F_CurrentStatus"].Value + @"','" + ISpace["F_ProcessName"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceF1A1836CA83A4FAB9F41BB56E85274EE =GetQueryExpressionDataSource(""F1A1836C-A83A-4FAB-9F41-BB56E85274EE"");Dictionary<short,object> resultF1A1836CA83A4FAB9F41BB56E85274EE=iSpace.ExecuteQuery(querySourceF1A1836CA83A4FAB9F41BB56E85274EE,@""EXEC [dbo].usp_BuildDynamicTaskFilter '"" + ISpace[""F_TaskName""].Value + @""','"" + ISpace[""F_InitiatedBy""].Value + @""','"" + ISpace[""F_InitiatedStartDate""].Value + @""','"" + ISpace[""F_InitiatedEndDate""].Value + @""','"" + ISpace[""F_Level""].Value + @""','"" + ISpace[""F_CurrentStatus""].Value + @""','"" + ISpace[""F_ProcessName""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultF1A1836CA83A4FAB9F41BB56E85274EE!=null) && (resultF1A1836CA83A4FAB9F41BB56E85274EE.Count!=0))
{
if(resultF1A1836CA83A4FAB9F41BB56E85274EE.ContainsKey(0))
ISpace["SubFilter"].Value = resultF1A1836CA83A4FAB9F41BB56E85274EE[0];
}
else{
ISpace["SubFilter"].Value = null;
}
ISpace["SubFilter"].Value=Replace(ISpace["SubFIlter"].Value,"'","''");
base.WriteDebugInfo(@"ISpace[""SubFilter""].Value=Replace(ISpace[""SubFIlter""].Value,""'"",""''"");");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC dbo.[GetUserRequestSummaryWithFilters] 0,@@gv_UserId,'#M_ModuleId','#M_CurrentStatus','#SubFilter','',#MF_TaskSummary_PageIndex,'#MF_TaskSummary_GridRows'");

var querySourceE55DE8B65604401D9FA50372DE5D3A21 =GetQueryExpressionDataSource("E55DE8B6-5604-401D-9FA5-0372DE5D3A21");
Dictionary<short,object> resultE55DE8B65604401D9FA50372DE5D3A21=iSpace.ExecuteQuery(querySourceE55DE8B65604401D9FA50372DE5D3A21,@"EXEC dbo.[GetUserRequestSummaryWithFilters] 0," + ISpace["gv_userid"].Value + @",'" + ISpace["M_ModuleId"].Value + @"','" + ISpace["M_CurrentStatus"].Value + @"','" + ISpace["SubFilter"].Value + @"',''," + ISpace["MF_TaskSummary_PageIndex"].Value + @",'" + ISpace["MF_TaskSummary_GridRows"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceE55DE8B65604401D9FA50372DE5D3A21 =GetQueryExpressionDataSource(""E55DE8B6-5604-401D-9FA5-0372DE5D3A21"");Dictionary<short,object> resultE55DE8B65604401D9FA50372DE5D3A21=iSpace.ExecuteQuery(querySourceE55DE8B65604401D9FA50372DE5D3A21,@""EXEC dbo.[GetUserRequestSummaryWithFilters] 0,"" + ISpace[""gv_userid""].Value + @"",'"" + ISpace[""M_ModuleId""].Value + @""','"" + ISpace[""M_CurrentStatus""].Value + @""','"" + ISpace[""SubFilter""].Value + @""','',"" + ISpace[""MF_TaskSummary_PageIndex""].Value + @"",'"" + ISpace[""MF_TaskSummary_GridRows""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultE55DE8B65604401D9FA50372DE5D3A21!=null) && (resultE55DE8B65604401D9FA50372DE5D3A21.Count!=0))
{
if(resultE55DE8B65604401D9FA50372DE5D3A21.ContainsKey(0))
ISpace["MF_TaskSummary_GridRows"].Value = resultE55DE8B65604401D9FA50372DE5D3A21[0];
if(resultE55DE8B65604401D9FA50372DE5D3A21.ContainsKey(3))
ISpace["MF_TaskSummary_TotalPages"].Value = resultE55DE8B65604401D9FA50372DE5D3A21[3];
if(resultE55DE8B65604401D9FA50372DE5D3A21.ContainsKey(2))
ISpace["MF_TaskSummary_PageIndex"].Value = resultE55DE8B65604401D9FA50372DE5D3A21[2];
if(resultE55DE8B65604401D9FA50372DE5D3A21.ContainsKey(1))
ISpace["MF_TaskSummary_RecordsRange"].Value = resultE55DE8B65604401D9FA50372DE5D3A21[1];
}
else{
ISpace["MF_TaskSummary_GridRows"].Value = null;ISpace["MF_TaskSummary_TotalPages"].Value = null;ISpace["MF_TaskSummary_PageIndex"].Value = null;ISpace["MF_TaskSummary_RecordsRange"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_TaskSummary_PageIndex"].Value==1||ISpace["MF_TaskSummary_PageIndex"].Value==0)
{
base.WriteDebugInfo(@"if(ISpace[""MF_TaskSummary_PageIndex""].Value==1||ISpace[""MF_TaskSummary_PageIndex""].Value==0)");
if(ISpace["MF_TaskSummary_PageIndex"].Value==ISpace["MF_TaskSummary_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_TaskSummary_PageIndex""].Value==ISpace[""MF_TaskSummary_TotalPages""].Value)");
ISpace["MF_TaskSummary_FirstButton"].Enbl="false";ISpace["MF_TaskSummary_LastButton"].Enbl="false";ISpace["MF_TaskSummary_PageIndex"].Enbl="false";ISpace["MF_TaskSummary_NextButton"].Enbl="false";ISpace["MF_TaskSummary_PrevButton"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MF_TaskSummary_FirstButton""].Enbl=""false"";ISpace[""MF_TaskSummary_LastButton""].Enbl=""false"";ISpace[""MF_TaskSummary_PageIndex""].Enbl=""false"";ISpace[""MF_TaskSummary_NextButton""].Enbl=""false"";ISpace[""MF_TaskSummary_PrevButton""].Enbl=""false"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_TaskSummary_FirstButton"].Enbl="false";ISpace["MF_TaskSummary_LastButton"].Enbl="true";ISpace["MF_TaskSummary_PageIndex"].Enbl="true";ISpace["MF_TaskSummary_NextButton"].Enbl="true";ISpace["MF_TaskSummary_PrevButton"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MF_TaskSummary_FirstButton""].Enbl=""false"";ISpace[""MF_TaskSummary_LastButton""].Enbl=""true"";ISpace[""MF_TaskSummary_PageIndex""].Enbl=""true"";ISpace[""MF_TaskSummary_NextButton""].Enbl=""true"";ISpace[""MF_TaskSummary_PrevButton""].Enbl=""false"";");
}
}
else
{
base.WriteDebugInfo(@"else");
if(ISpace["MF_TaskSummary_PageIndex"].Value==ISpace["MF_TaskSummary_TotalPages"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_TaskSummary_PageIndex""].Value==ISpace[""MF_TaskSummary_TotalPages""].Value)");
ISpace["MF_TaskSummary_FirstButton"].Enbl="true";ISpace["MF_TaskSummary_LastButton"].Enbl="false";ISpace["MF_TaskSummary_PageIndex"].Enbl="true";ISpace["MF_TaskSummary_NextButton"].Enbl="false";ISpace["MF_TaskSummary_PrevButton"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_TaskSummary_FirstButton""].Enbl=""true"";ISpace[""MF_TaskSummary_LastButton""].Enbl=""false"";ISpace[""MF_TaskSummary_PageIndex""].Enbl=""true"";ISpace[""MF_TaskSummary_NextButton""].Enbl=""false"";ISpace[""MF_TaskSummary_PrevButton""].Enbl=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_TaskSummary_FirstButton"].Enbl="true";ISpace["MF_TaskSummary_LastButton"].Enbl="true";ISpace["MF_TaskSummary_PageIndex"].Enbl="true";ISpace["MF_TaskSummary_NextButton"].Enbl="true";ISpace["MF_TaskSummary_PrevButton"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_TaskSummary_FirstButton""].Enbl=""true"";ISpace[""MF_TaskSummary_LastButton""].Enbl=""true"";ISpace[""MF_TaskSummary_PageIndex""].Enbl=""true"";ISpace[""MF_TaskSummary_NextButton""].Enbl=""true"";ISpace[""MF_TaskSummary_PrevButton""].Enbl=""true"";");
}
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySourceB7B829491EE0475F95DEBBD6269FEDBF =GetQueryExpressionDataSource("B7B82949-1EE0-475F-95DE-BBD6269FEDBF");

DataTable resultB7B829491EE0475F95DEBBD6269FEDBF=iSpace.SetGridDataSource(querySourceB7B829491EE0475F95DEBBD6269FEDBF, _objectFactory.GetGridRPP("MG_TaskSummary"),@"EXEC dbo.[GetUserRequestSummaryWithFilters] 1," + ISpace["gv_userid"].Value + @",'" + ISpace["M_ModuleId"].Value + @"','" + ISpace["M_CurrentStatus"].Value + @"','" + ISpace["SubFilter"].Value + @"',''," + ISpace["MF_TaskSummary_PageIndex"].Value + @",'" + ISpace["MF_TaskSummary_GridRows"].Value + @"'");

iSpace.InsertGridBindDetails("MG_TaskSummary","11",querySourceB7B829491EE0475F95DEBBD6269FEDBF,"EXEC dbo.[GetUserRequestSummaryWithFilters] 1," + ISpace["gv_userid"].Value + @",'" + ISpace["M_ModuleId"].Value + @"','" + ISpace["M_CurrentStatus"].Value + @"','" + ISpace["SubFilter"].Value + @"',''," + ISpace["MF_TaskSummary_PageIndex"].Value + @",'" + ISpace["MF_TaskSummary_GridRows"].Value + @"'",_objectFactory.GetGridRPP("MG_TaskSummary"));

base.WriteDebugInfo(@"var querySourceB7B829491EE0475F95DEBBD6269FEDBF =GetQueryExpressionDataSource(""B7B82949-1EE0-475F-95DE-BBD6269FEDBF"");DataTable resultB7B829491EE0475F95DEBBD6269FEDBF=iSpace.SetGridDataSource(querySourceB7B829491EE0475F95DEBBD6269FEDBF, _objectFactory.GetGridRPP(""MG_TaskSummary""),@""EXEC dbo.[GetUserRequestSummaryWithFilters] 1,"" + ISpace[""gv_userid""].Value + @"",'"" + ISpace[""M_ModuleId""].Value + @""','"" + ISpace[""M_CurrentStatus""].Value + @""','"" + ISpace[""SubFilter""].Value + @""','',"" + ISpace[""MF_TaskSummary_PageIndex""].Value + @"",'"" + ISpace[""MF_TaskSummary_GridRows""].Value + @""'"");iSpace.InsertGridBindDetails(""MG_TaskSummary"",""11"",querySourceB7B829491EE0475F95DEBBD6269FEDBF,""EXEC dbo.[GetUserRequestSummaryWithFilters] 1,"" + ISpace[""gv_userid""].Value + @"",'"" + ISpace[""M_ModuleId""].Value + @""','"" + ISpace[""M_CurrentStatus""].Value + @""','"" + ISpace[""SubFilter""].Value + @""','',"" + ISpace[""MF_TaskSummary_PageIndex""].Value + @"",'"" + ISpace[""MF_TaskSummary_GridRows""].Value + @""'"",_objectFactory.GetGridRPP(""MG_TaskSummary""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result67C3863389CE42879063086A3A6BA3EB=acdataIspace2EC4031088B94E21AD43FA1B94EBF785.GetQueryExpressionBindings("67C38633-89CE-4287-9063-086A3A6BA3EB");
iSpace.SetGridData(resultB7B829491EE0475F95DEBBD6269FEDBF,result67C3863389CE42879063086A3A6BA3EB,"MG_TaskSummary",ref ISpace);
iSpace.UpdateGridBindDetails("MG_TaskSummary",result67C3863389CE42879063086A3A6BA3EB);
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
		if(elementName.ToLower().Equals("mf_tasksummary_gridrows"))
    {
    			SubscribeElementEvents_mf_tasksummary_gridrows(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mf_tasksummary_pageindex"))
    {
    			SubscribeElementEvents_mf_tasksummary_pageindex(ref dfsParam);
    }
}
	if(methodName.ToLower().Equals("onclick"))
{
		if(elementName.ToLower().Equals("apply"))
{
			SubscribeElementEvents_apply(ref dfsParam);
}
		if(elementName.ToLower().Equals("m_participatedinprogressbtn"))
{
			SubscribeElementEvents_m_participatedinprogressbtn(ref dfsParam);
}
		if(elementName.ToLower().Equals("m_icbutton"))
{
			SubscribeElementEvents_m_icbutton(ref dfsParam);
}
		if(elementName.ToLower().Equals("mf_tasksummary_firstbutton"))
{
			SubscribeElementEvents_mf_tasksummary_firstbutton(ref dfsParam);
}
		if(elementName.ToLower().Equals("ts_view"))
{
			SubscribeElementEvents_ts_view(ref dfsParam);
}
		if(elementName.ToLower().Equals("m_participatedcompletedbtn"))
{
			SubscribeElementEvents_m_participatedcompletedbtn(ref dfsParam);
}
		if(elementName.ToLower().Equals("m_ipbutton"))
{
			SubscribeElementEvents_m_ipbutton(ref dfsParam);
}
		if(elementName.ToLower().Equals("clearall"))
{
			SubscribeElementEvents_clearall(ref dfsParam);
}
		if(elementName.ToLower().Equals("mf_tasksummary_lastbutton"))
{
			SubscribeElementEvents_mf_tasksummary_lastbutton(ref dfsParam);
}
		if(elementName.ToLower().Equals("ts_processname"))
{
			SubscribeElementEvents_ts_processname(ref dfsParam);
}
		if(elementName.ToLower().Equals("mf_tasksummary_nextbutton"))
{
			SubscribeElementEvents_mf_tasksummary_nextbutton(ref dfsParam);
}
		if(elementName.ToLower().Equals("mf_tasksummary_prevbutton"))
{
			SubscribeElementEvents_mf_tasksummary_prevbutton(ref dfsParam);
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


	public partial class AcDataISpace2EC4031088B94E21AD43FA1B94EBF785  : ExtensionActivityBase
	{		
		
		
		private Dictionary<string,  List<Triplet<string, short, short?>>> queryExpressionBindings = 
											new Dictionary<string,  List<Triplet<string, short, short?>>>
		{
							{"5C847AC5-6886-4D30-BD57-B524DFF277CD", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("ActivityName",1,
														   -1),
								   new Triplet<string, short, short?>("DateOfRemarks",3,
														   -1),
								   new Triplet<string, short, short?>("Remarks",4,
														   -1),
								   new Triplet<string, short, short?>("RemarksId",0,
														   -1),
								   new Triplet<string, short, short?>("UserName",2,
														   -1),
								}
			},
							{"67C38633-89CE-4287-9063-086A3A6BA3EB", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("TS_ID",0,
														   -1),
								   new Triplet<string, short, short?>("TS_InitiatedBy",5,
														   -1),
								   new Triplet<string, short, short?>("TS_InitiatedDate",6,
														   -1),
								   new Triplet<string, short, short?>("TS_Level",8,
														   -1),
								   new Triplet<string, short, short?>("TS_ModifiedDate",11,
														   -1),
								   new Triplet<string, short, short?>("TS_ProcessName",4,
														   -1),
								   new Triplet<string, short, short?>("TS_Status",9,
														   -1),
								   new Triplet<string, short, short?>("TS_ViewUrl",12,
														   -1),
								}
			},
					};	

	

		private Dictionary<string,string> formVersionList =new Dictionary<string,string> 
		{
							{"1AA5B3E2-9DA8-490E-B860-328F504DFF0D", "Medium"},
					};	

		
		private Dictionary<string,string> formVersionLayoutList =new Dictionary<string,string> 
		{
							{"A499A17D-56E7-418B-9EF2-042AF1FC9479", ""},
							{"DBC5760B-F100-4D73-B052-A9CFCCC1A919", ""},
							{"1AA5B3E2-9DA8-490E-B860-328F504DFF0D", ""},
							{"3FFF9053-9EFC-4191-9117-E4BBA500F910", ""},
							{"C3497879-B1AA-4DF5-8B78-C5D50F9DBC4F", ""},
							{"F15F3C6A-835F-4FAD-A0F4-7F90069A9E2C", ""},
							{"46E2761F-A320-4626-82FB-D56073812B27", ""},
							{"0B06C66A-30BD-4503-B3A7-04137D928860", ""},
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
		


