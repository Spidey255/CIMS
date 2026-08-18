  







namespace CPS.Proof.DFSExtension
{
	using System;
    using System.Collections.Generic;     
	using System.Linq;
	
	
	public partial class CommitmentSpentDetailsProcessMetadata : ExtensionProcessBase
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
            get { return "C12B87A0-C375-4057-B0BA-64B4C80E77F9"; }
        }

        public override string ProcessName
        {
            get { return "CommitmentSpentDetails"; }
        }

		public override string ProcessDescription
        {
            get { return "Commitment Spent Details"; }
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
            get {return "C12B87A0-C375-4057-B0BA-64B4C80E77F9";}
        }

		public override byte ProcessInstanceMode
        {
            get {return 3;}
        }		

		public override string MasterFormId
        {
            get {  
				   return "DA3904EF-0E60-44D0-943E-2E97494B15C8";	}
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
	

	public partial class CommitmentSpentDetailsObjectFactory  : ExtObjectFactoryBase
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
        //    return (IExtBaseMetaData)new CommitmentSpentDetailsProcessMetadata();
        //}
	


		private List<Triplet<string, string, string>> queryExpressionData = new List<Triplet<string, string, string>>
		{
	  			
			     new Triplet<string, string, string>("D81D3EDF-DDF6-4F81-A44C-3C2187BB3EBA","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("D81D3EDF-DDF6-4F81-A44C-3C2187BB3EBA","Load ProjectCommitmentSpentDetails",
												     @"9CC97541-CC4E-4D16-A92F-2FA4A6460E7B"),
			
			
			
		};


		
		private List<Triplet<string, string, string>> ComboDataSource = new List<Triplet<string, string, string>>
		{

		
	  			
			
			     new Triplet<string, string, string>("MF_ProjectNo","3A103712-5244-4427-B2B6-1C4E046FD337",
												     @"EXEC GetProjectExtensionDetails 1,'@MF_UserName'"),
			
						
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
		
	  			
			     new Tuple<string, int>("MG_CommitmentDetails",50),
			
						
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
											case "C74E1FE0-A9E3-4B09-A184-6D1DC9CE7B0F":
							virtualInstance=new ISpaceC74E1FE0A9E34B09A1846D1DC9CE7B0F();
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
	

	public partial class CommitmentSpentDetailsDataElementFactory  : ExtElementBase
    {

     /// <summary>
        /// A <see cref="log4net.ILog"/> that contains the logger instance for 
        /// logging
        /// </summary>
        private readonly ILog _sysLog;

        public CommitmentSpentDetailsDataElementFactory()
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

               
                
                                      case "DA3904EF-0E60-44D0-943E-2E97494B15C8":
                    {
                     
                                     fInsertQuery=@"IF NOT EXISTS(SELECT 1 FROM [DA3904EF-0E60-44D0-943E-2E97494B15C8] WHERE InstanceId='{0}') BEGIN INSERT INTO [DA3904EF-0E60-44D0-943E-2E97494B15C8](ProcessActivityMapId,FormId,ExecutionMessage,ExecutionStatus,Subject,SetDestinationTo,MF_ProjectDetailsId,SLATime,MF_ProjectNo,MF_UserName,InstanceId)
							VALUES( {3}) END ELSE BEGIN UPDATE [DA3904EF-0E60-44D0-943E-2E97494B15C8]SET {4}WHERE InstanceId='{0}'END ";

                                     colList=@"ProcessActivityMapId,FormId,ExecutionMessage,ExecutionStatus,Subject,SetDestinationTo,MF_ProjectDetailsId,SLATime,MF_ProjectNo,MF_UserName,InstanceId";
                                    
                     
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
                                                UpdatecolValues += fcol + "=" + (Convert.ToBoolean(childObject["Value"]) ? "1" : "0") + ",";
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

                
                 
                                      case "9CC97541-CC4E-4D16-A92F-2FA4A6460E7B":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_9CC97541CC4E4D16A92F2FA4A6460E7B AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_BudgetName] VARCHAR(MAX)	, [MG_Balance] DECIMAL(18,2)	, [MG_ReceivedAmount] DECIMAL(18,2)	, [MG_Commitment] DECIMAL(18,2)	, [MG_Spent] DECIMAL(18,2)	, [MG_YetToReceive] DECIMAL(18,2)	, [MG_SanctionedAmount] DECIMAL(18,2)){0}INSERT INTO [9CC97541-CC4E-4D16-A92F-2FA4A6460E7B](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_BudgetName,MG_Balance,MG_ReceivedAmount,MG_Commitment,MG_Spent,MG_YetToReceive,MG_SanctionedAmount)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_BudgetName,TDT.MG_Balance,TDT.MG_ReceivedAmount,TDT.MG_Commitment,TDT.MG_Spent,TDT.MG_YetToReceive,TDT.MG_SanctionedAmount FROM @TBL_9CC97541CC4E4D16A92F2FA4A6460E7B TDT
							LEFT JOIN [9CC97541-CC4E-4D16-A92F-2FA4A6460E7B] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MG_BudgetName=TDT.MG_BudgetName,MG_Balance=TDT.MG_Balance,MG_ReceivedAmount=TDT.MG_ReceivedAmount,MG_Commitment=TDT.MG_Commitment,MG_Spent=TDT.MG_Spent,MG_YetToReceive=TDT.MG_YetToReceive,MG_SanctionedAmount=TDT.MG_SanctionedAmount FROM @TBL_9CC97541CC4E4D16A92F2FA4A6460E7B TDT
							JOIN [9CC97541-CC4E-4D16-A92F-2FA4A6460E7B] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_BudgetName,MG_Balance,MG_ReceivedAmount,MG_Commitment,MG_Spent,MG_YetToReceive,MG_SanctionedAmount";

                                     tempInsertQuery=@"INSERT INTO @TBL_9CC97541CC4E4D16A92F2FA4A6460E7B(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_BudgetName,MG_Balance,MG_ReceivedAmount,MG_Commitment,MG_Spent,MG_YetToReceive,MG_SanctionedAmount)VALUES({0});";
                                     

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
                                            colValues +="'"+ gitem["Value"].ToString().Replace("'","''") + "',";
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


      public override string GetGridLoopQuery(string gridId,string gridName,bool IsGridReset,ref Dictionary<string,ServiceElementData> gridData)
        {
            _sysLog.Debug("Entering GetGridLoopQuery");

            try
            {

                string colValues = string.Empty;

                string[] splitcols = null;

                string colList = string.Empty;
                string colListwithEDT = string.Empty;

                string gInsertQuery = string.Empty;

                string tempInsertQuery = string.Empty;

                string bulkInsertQuery = string.Empty;

                string deleteQuery=string.Empty;

                string instanceId = gridData["InstanceId"].Value;

                 if (string.IsNullOrEmpty(instanceId))
                {
                    gridData["InstanceId"].Value=Guid.NewGuid().ToString();

                    instanceId = gridData["InstanceId"].Value;
                }

                string processActivityMapId = gridData["gv_activitymapid"].Value;

             

             
                switch (gridId)
                {
                     

                                         case "9CC97541-CC4E-4D16-A92F-2FA4A6460E7B":
                    {
                     
                                //Delete Existing Records of InstanceId
                                deleteQuery="Delete FROM [9CC97541-CC4E-4D16-A92F-2FA4A6460E7B] WHERE InstanceId='{0}';";

                           

                            gInsertQuery=@"
		
		DECLARE  @TBL_9CC97541CC4E4D16A92F2FA4A6460E7B AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_BudgetName] VARCHAR(MAX)	, [MG_Balance] DECIMAL(18,2)	, [MG_ReceivedAmount] DECIMAL(18,2)	, [MG_Commitment] DECIMAL(18,2)	, [MG_Spent] DECIMAL(18,2)	, [MG_YetToReceive] DECIMAL(18,2)	, [MG_SanctionedAmount] DECIMAL(18,2)){0}INSERT INTO [9CC97541-CC4E-4D16-A92F-2FA4A6460E7B](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_BudgetName,MG_Balance,MG_ReceivedAmount,MG_Commitment,MG_Spent,MG_YetToReceive,MG_SanctionedAmount)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_BudgetName,TDT.MG_Balance,TDT.MG_ReceivedAmount,TDT.MG_Commitment,TDT.MG_Spent,TDT.MG_YetToReceive,TDT.MG_SanctionedAmount FROM @TBL_9CC97541CC4E4D16A92F2FA4A6460E7B TDT
							LEFT JOIN [9CC97541-CC4E-4D16-A92F-2FA4A6460E7B] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MG_BudgetName=TDT.MG_BudgetName,MG_Balance=TDT.MG_Balance,MG_ReceivedAmount=TDT.MG_ReceivedAmount,MG_Commitment=TDT.MG_Commitment,MG_Spent=TDT.MG_Spent,MG_YetToReceive=TDT.MG_YetToReceive,MG_SanctionedAmount=TDT.MG_SanctionedAmount FROM @TBL_9CC97541CC4E4D16A92F2FA4A6460E7B TDT
							JOIN [9CC97541-CC4E-4D16-A92F-2FA4A6460E7B] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_BudgetName,MG_Balance,MG_ReceivedAmount,MG_Commitment,MG_Spent,MG_YetToReceive,MG_SanctionedAmount";

                            colListwithEDT=@"InstanceId#0,ProcessActivityMapId#0,GridId#0,RowId#0,Sequence#0,MG_BudgetName#9,MG_Balance#3,MG_ReceivedAmount#3,MG_Commitment#3,MG_Spent#3,MG_YetToReceive#3,MG_SanctionedAmount#3";

                            tempInsertQuery=@"INSERT INTO @TBL_9CC97541CC4E4D16A92F2FA4A6460E7B(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_BudgetName,MG_Balance,MG_ReceivedAmount,MG_Commitment,MG_Spent,MG_YetToReceive,MG_SanctionedAmount)VALUES({0});";

                            splitcols = colListwithEDT.Split(',');

                            if (splitcols.Length <= 0)
                                return null;

                            foreach (var gridChild in gridData[gridName].Child)
                            {                            
                                                                                         
                                colValues = string.Empty;

                                foreach (var sgcol in splitcols)
                                {
                                    var gcol = sgcol.Split("#")[0];

                                    var edt=Convert.ToInt16(sgcol.Split("#")[1]);

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

                                            switch (edt)
                                            {
                                                case 0:
                                                    colValues += (Convert.ToBoolean(gridrow.Value) ? "1" : "0") + ",";
                                                    break;
                                                case 8:
                                                case 9:
                                                    colValues += "'" + gridrow.Value.ToString() + "',";
                                                    break;

                                                default:
                                                    if (gridrow.Value.ToString() == "")

                                                        colValues += "NULL,";
                                                    else
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

                                bulkInsertQuery = bulkInsertQuery+ string.Format(tempInsertQuery, colValues);
                            }
                        }
                        break;

                                          }
                       
                bulkInsertQuery = string.Format(gInsertQuery, bulkInsertQuery);

                if(IsGridReset)
                {
                    //Delete Existing Records of InstanceId
                    deleteQuery=string.Format(deleteQuery, instanceId); 

                    bulkInsertQuery=deleteQuery+"\n\n"+bulkInsertQuery;
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
public class ISpaceC74E1FE0A9E34B09A1846D1DC9CE7B0F : VirtualForm
{
IISpace iSpace = new ISpace();
AcDataISpaceC74E1FE0A9E34B09A1846D1DC9CE7B0F acdataIspaceC74E1FE0A9E34B09A1846D1DC9CE7B0F=new AcDataISpaceC74E1FE0A9E34B09A1846D1DC9CE7B0F();
private void SubscribeFormEvents_root(ref Dictionary<string, ServiceElementData> ISpace)
{
try
{
base.WriteDebugInfo(@"Root-OnAfterFormLoad");
if(ISpace["MF_ProjectNo"].Value!="")
{
base.WriteDebugInfo(@"if(ISpace[""MF_ProjectNo""].Value!="""")");
ISpace["MF_ProjectDetailsId"].Visible="false";ISpace["MF_ProjectDetailsId"].Enbl="false";ISpace["MF_ProjectNo"].Visible="false";ISpace["MF_ProjectNo"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MF_ProjectDetailsId""].Visible=""false"";ISpace[""MF_ProjectDetailsId""].Enbl=""false"";ISpace[""MF_ProjectNo""].Visible=""false"";ISpace[""MF_ProjectNo""].Enbl=""false"";");
}
ISpace["MG_BudgetName"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MG_BudgetName""].Enbl=""false"";");
ISpace["MF_UserName"].Value=ISpace["gv_username"].Value;
base.WriteDebugInfo(@"ISpace[""MF_UserName""].Value=ISpace[""gv_username""].Value;");
ISpace["MF_ProjectNo"].rElemData=iSpace.Reload(ISpace["MF_ProjectNo"].Value,@"EXEC GetProjectExtensionDetails 1,'" + ISpace["MF_UserName"].Value + @"'","3A103712-5244-4427-B2B6-1C4E046FD337");
base.WriteDebugInfo(@"ISpace[""MF_ProjectNo""].rElemData=iSpace.Reload(ISpace[""MF_ProjectNo""].Value,@""EXEC GetProjectExtensionDetails 1,'"" + ISpace[""MF_UserName""].Value + @""'"",""3A103712-5244-4427-B2B6-1C4E046FD337"");");
ISpace["MF_UserName"].Visible="false";
base.WriteDebugInfo(@"ISpace[""MF_UserName""].Visible=""false"";");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySourceD81D3EDFDDF64F81A44C3C2187BB3EBA =GetQueryExpressionDataSource("D81D3EDF-DDF6-4F81-A44C-3C2187BB3EBA");

DataTable resultD81D3EDFDDF64F81A44C3C2187BB3EBA=iSpace.SetGridDataSource(querySourceD81D3EDFDDF64F81A44C3C2187BB3EBA, _objectFactory.GetGridRPP("MG_CommitmentDetails"),@"EXEC GetProjectBudgetInformation '" + ISpace["MF_ProjectNo"].Value + @"'");


base.WriteDebugInfo(@"var querySourceD81D3EDFDDF64F81A44C3C2187BB3EBA =GetQueryExpressionDataSource(""D81D3EDF-DDF6-4F81-A44C-3C2187BB3EBA"");DataTable resultD81D3EDFDDF64F81A44C3C2187BB3EBA=iSpace.SetGridDataSource(querySourceD81D3EDFDDF64F81A44C3C2187BB3EBA, _objectFactory.GetGridRPP(""MG_CommitmentDetails""),@""EXEC GetProjectBudgetInformation '"" + ISpace[""MF_ProjectNo""].Value + @""'"");");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> resultDA94EEF131BE409C9029B9039A450EB2=acdataIspaceC74E1FE0A9E34B09A1846D1DC9CE7B0F.GetQueryExpressionBindings("DA94EEF1-31BE-409C-9029-B9039A450EB2");
iSpace.SetGridData(resultD81D3EDFDDF64F81A44C3C2187BB3EBA,resultDA94EEF131BE409C9029B9039A450EB2,"MG_CommitmentDetails",ref ISpace);
if (_elementBase != null)  iSpace.SetLoopExpressionData("MG_CommitmentDetails","9CC97541-CC4E-4D16-A92F-2FA4A6460E7B",_objectFactory.GetGridRPP("MG_CommitmentDetails"),_elementBase.GetGridLoopQuery("9CC97541-CC4E-4D16-A92F-2FA4A6460E7B","MG_CommitmentDetails",true,ref ISpace), ref ISpace);

}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mf_projectno (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MF_ProjectNo-OnChange");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySourceD81D3EDFDDF64F81A44C3C2187BB3EBA =GetQueryExpressionDataSource("D81D3EDF-DDF6-4F81-A44C-3C2187BB3EBA");

DataTable resultD81D3EDFDDF64F81A44C3C2187BB3EBA=iSpace.SetGridDataSource(querySourceD81D3EDFDDF64F81A44C3C2187BB3EBA, _objectFactory.GetGridRPP("MG_CommitmentDetails"),@"EXEC GetProjectBudgetInformation '" + ISpace["MF_ProjectNo"].Value + @"'");


base.WriteDebugInfo(@"var querySourceD81D3EDFDDF64F81A44C3C2187BB3EBA =GetQueryExpressionDataSource(""D81D3EDF-DDF6-4F81-A44C-3C2187BB3EBA"");DataTable resultD81D3EDFDDF64F81A44C3C2187BB3EBA=iSpace.SetGridDataSource(querySourceD81D3EDFDDF64F81A44C3C2187BB3EBA, _objectFactory.GetGridRPP(""MG_CommitmentDetails""),@""EXEC GetProjectBudgetInformation '"" + ISpace[""MF_ProjectNo""].Value + @""'"");");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> resultDA94EEF131BE409C9029B9039A450EB2=acdataIspaceC74E1FE0A9E34B09A1846D1DC9CE7B0F.GetQueryExpressionBindings("DA94EEF1-31BE-409C-9029-B9039A450EB2");
iSpace.SetGridData(resultD81D3EDFDDF64F81A44C3C2187BB3EBA,resultDA94EEF131BE409C9029B9039A450EB2,"MG_CommitmentDetails",ref ISpace);
if (_elementBase != null)  iSpace.SetLoopExpressionData("MG_CommitmentDetails","9CC97541-CC4E-4D16-A92F-2FA4A6460E7B",_objectFactory.GetGridRPP("MG_CommitmentDetails"),_elementBase.GetGridLoopQuery("9CC97541-CC4E-4D16-A92F-2FA4A6460E7B","MG_CommitmentDetails",true,ref ISpace), ref ISpace);

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
		if(elementName.ToLower().Equals("mf_projectno"))
    {
    			SubscribeElementEvents_mf_projectno(ref dfsParam);
    }
}
	if(methodName.ToLower().Equals("onclick"))
{
}
	if(methodName.ToLower().Equals("onafterrowdeleting"))
{
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


	public partial class AcDataISpaceC74E1FE0A9E34B09A1846D1DC9CE7B0F  : ExtensionActivityBase
	{		
		
		
		private Dictionary<string,  List<Triplet<string, short, short?>>> queryExpressionBindings = 
											new Dictionary<string,  List<Triplet<string, short, short?>>>
		{
							{"DA94EEF1-31BE-409C-9029-B9039A450EB2", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_Balance",6,
														   -1),
								   new Triplet<string, short, short?>("MG_YetToReceive",2,
														   -1),
								   new Triplet<string, short, short?>("MG_ReceivedAmount",3,
														   -1),
								   new Triplet<string, short, short?>("MG_Spent",5,
														   -1),
								   new Triplet<string, short, short?>("MG_Commitment",4,
														   -1),
								   new Triplet<string, short, short?>("MG_SanctionedAmount",1,
														   -1),
								   new Triplet<string, short, short?>("MG_BudgetName",0,
														   -1),
								}
			},
					};	

	

		private Dictionary<string,string> formVersionList =new Dictionary<string,string> 
		{
							{"09EF60AC-9E86-4DAB-96AE-E730E741C7BC", "Medium"},
					};	

		
		private Dictionary<string,string> formVersionLayoutList =new Dictionary<string,string> 
		{
							{"C9E33DFF-159B-4DF1-925A-F087599E4287", ""},
							{"8AC2DA6A-8E76-4368-AB5C-3CD95AF50814", ""},
							{"09EF60AC-9E86-4DAB-96AE-E730E741C7BC", ""},
							{"B08E7170-7E08-4AE2-9FA6-4C8D42A8FC82", ""},
							{"0C802C28-C6DF-4614-BF12-D867D7BD0840", ""},
							{"C399C82D-9A27-4843-BFFD-4FC3CBC35031", ""},
							{"FF5844A0-8538-4EFA-B394-509AFA7C0BF4", ""},
							{"04E9CEBB-27D3-42EB-B287-6BB898A2654C", ""},
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
		


