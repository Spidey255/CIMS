  







namespace CPS.Proof.DFSExtension
{
	using System;
    using System.Collections.Generic;     
	using System.Linq;
	
	
	public partial class ProjectFundExplorerProcessMetadata : ExtensionProcessBase
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
            get { return "1C5D271E-9D4D-47A4-8622-C1DBD65C0B6A"; }
        }

        public override string ProcessName
        {
            get { return "ProjectFundExplorer"; }
        }

		public override string ProcessDescription
        {
            get { return "Project Fund Explorer"; }
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
            get {return "1C5D271E-9D4D-47A4-8622-C1DBD65C0B6A";}
        }

		public override byte ProcessInstanceMode
        {
            get {return 3;}
        }		

		public override string MasterFormId
        {
            get {  
				   return "CB38069E-44DE-463F-BAA6-6EA818E0CA3F";	}
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
	

	public partial class ProjectFundExplorerObjectFactory  : ExtObjectFactoryBase
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
        //    return (IExtBaseMetaData)new ProjectFundExplorerProcessMetadata();
        //}
	


		private List<Triplet<string, string, string>> queryExpressionData = new List<Triplet<string, string, string>>
		{
	  			
			     new Triplet<string, string, string>("99d3e3ef-818d-b2c5-430f-3c6fd63ed12c","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("4a9a698c-b476-3eef-f4f2-7fd4b9f8164b","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("99d3e3ef-818d-b2c5-430f-3c6fd63ed12c","Load Explorer Details",
												     @"c4df7365-678c-f65a-2f9a-d05b5d20bab7"),
			
			
			
		};


		
		private List<Triplet<string, string, string>> ComboDataSource = new List<Triplet<string, string, string>>
		{

		
	  			
			
			     new Triplet<string, string, string>("MF_ProjectRefNo","3A103712-5244-4427-B2B6-1C4E046FD337",
												     @"EXEC GetProjectNoCombo 1,'@M_UserId'"),
			
						
			
			     new Triplet<string, string, string>("MF_Status","3A103712-5244-4427-B2B6-1C4E046FD337",
												     @"EXEC GetStatusCombo"),
			
						
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
		
	  			
			     new Tuple<string, int>("MG_ReceiptDetails",100),
			
						
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
											case "391EB18F-A1B6-490F-B60C-D4572FE018AB":
							virtualInstance=new ISpace391EB18FA1B6490FB60CD4572FE018AB();
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
	

	public partial class ProjectFundExplorerDataElementFactory  : ExtElementBase
    {

     /// <summary>
        /// A <see cref="log4net.ILog"/> that contains the logger instance for 
        /// logging
        /// </summary>
        private readonly ILog _sysLog;

        public ProjectFundExplorerDataElementFactory()
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

               
                
                                      case "CB38069E-44DE-463F-BAA6-6EA818E0CA3F":
                    {
                     
                                     fInsertQuery=@"IF NOT EXISTS(SELECT 1 FROM [CB38069E-44DE-463F-BAA6-6EA818E0CA3F] WHERE InstanceId='{0}') BEGIN INSERT INTO [CB38069E-44DE-463F-BAA6-6EA818E0CA3F](ProcessActivityMapId,FormId,SLATime,MF_ProjectRefNo,MF_Status,MF_PendingCount,MF_CompletedCount,Subject,ExecutionStatus,ExecutionMessage,SetDestinationTo,RedirectUrl,InstanceId,M_UserId)
							VALUES( {3}) END ELSE BEGIN UPDATE [CB38069E-44DE-463F-BAA6-6EA818E0CA3F]SET {4}WHERE InstanceId='{0}'END ";

                                     colList=@"ProcessActivityMapId,FormId,SLATime,MF_ProjectRefNo,MF_Status,MF_PendingCount,MF_CompletedCount,Subject,ExecutionStatus,ExecutionMessage,SetDestinationTo,RedirectUrl,InstanceId,M_UserId";
                                    
                     
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

                
                 
                                      case "c4df7365-678c-f65a-2f9a-d05b5d20bab7":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_c4df7365678cf65a2f9ad05b5d20bab7 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [RD_RefNo] VARCHAR(MAX)	, [RD_ReceiptDate] DATETIME	, [RD_ReceiptAmount] DECIMAL(18,2)	, [RD_RefId] VARCHAR(MAX)	, [RD_Status] VARCHAR(MAX)){0}INSERT INTO [c4df7365-678c-f65a-2f9a-d05b5d20bab7](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,RD_RefNo,RD_ReceiptDate,RD_ReceiptAmount,RD_RefId,RD_Status)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.RD_RefNo,TDT.RD_ReceiptDate,TDT.RD_ReceiptAmount,TDT.RD_RefId,TDT.RD_Status FROM @TBL_c4df7365678cf65a2f9ad05b5d20bab7 TDT
							LEFT JOIN [c4df7365-678c-f65a-2f9a-d05b5d20bab7] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,RD_RefNo=TDT.RD_RefNo,RD_ReceiptDate=TDT.RD_ReceiptDate,RD_ReceiptAmount=TDT.RD_ReceiptAmount,RD_RefId=TDT.RD_RefId,RD_Status=TDT.RD_Status FROM @TBL_c4df7365678cf65a2f9ad05b5d20bab7 TDT
							JOIN [c4df7365-678c-f65a-2f9a-d05b5d20bab7] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,RD_RefNo,RD_ReceiptDate,RD_ReceiptAmount,RD_RefId,RD_Status";

                                     tempInsertQuery=@"INSERT INTO @TBL_c4df7365678cf65a2f9ad05b5d20bab7(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,RD_RefNo,RD_ReceiptDate,RD_ReceiptAmount,RD_RefId,RD_Status)VALUES({0});";
                                     

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
                     

                                         case "c4df7365-678c-f65a-2f9a-d05b5d20bab7":
                    {
                     
                                //Delete Existing Records of InstanceId
                                deleteQuery="Delete FROM [c4df7365-678c-f65a-2f9a-d05b5d20bab7] WHERE InstanceId='{0}';";

                           

                            gInsertQuery=@"
		
		DECLARE  @TBL_c4df7365678cf65a2f9ad05b5d20bab7 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [RD_RefNo] VARCHAR(MAX)	, [RD_ReceiptDate] DATETIME	, [RD_ReceiptAmount] DECIMAL(18,2)	, [RD_RefId] VARCHAR(MAX)	, [RD_Status] VARCHAR(MAX)){0}INSERT INTO [c4df7365-678c-f65a-2f9a-d05b5d20bab7](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,RD_RefNo,RD_ReceiptDate,RD_ReceiptAmount,RD_RefId,RD_Status)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.RD_RefNo,TDT.RD_ReceiptDate,TDT.RD_ReceiptAmount,TDT.RD_RefId,TDT.RD_Status FROM @TBL_c4df7365678cf65a2f9ad05b5d20bab7 TDT
							LEFT JOIN [c4df7365-678c-f65a-2f9a-d05b5d20bab7] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,RD_RefNo=TDT.RD_RefNo,RD_ReceiptDate=TDT.RD_ReceiptDate,RD_ReceiptAmount=TDT.RD_ReceiptAmount,RD_RefId=TDT.RD_RefId,RD_Status=TDT.RD_Status FROM @TBL_c4df7365678cf65a2f9ad05b5d20bab7 TDT
							JOIN [c4df7365-678c-f65a-2f9a-d05b5d20bab7] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,RD_RefNo,RD_ReceiptDate,RD_ReceiptAmount,RD_RefId,RD_Status";

                            colListwithEDT=@"InstanceId#0,ProcessActivityMapId#0,GridId#0,RowId#0,Sequence#0,RD_RefNo#9,RD_ReceiptDate#8,RD_ReceiptAmount#3,RD_RefId#9,RD_Status#9";

                            tempInsertQuery=@"INSERT INTO @TBL_c4df7365678cf65a2f9ad05b5d20bab7(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,RD_RefNo,RD_ReceiptDate,RD_ReceiptAmount,RD_RefId,RD_Status)VALUES({0});";

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
public class ISpace391EB18FA1B6490FB60CD4572FE018AB : VirtualForm
{
IISpace iSpace = new ISpace();
AcDataISpace391EB18FA1B6490FB60CD4572FE018AB acdataIspace391EB18FA1B6490FB60CD4572FE018AB=new AcDataISpace391EB18FA1B6490FB60CD4572FE018AB();
private void SubscribeFormEvents_root(ref Dictionary<string, ServiceElementData> ISpace)
{
try
{
base.WriteDebugInfo(@"Root-OnAfterFormLoad");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC [GetReceiptExplorerDetails] 1,'#MF_ProjectRefNo','#MF_Status','@@gv_UserId'");

var querySource4a9a698cb4763eeff4f27fd4b9f8164b =GetQueryExpressionDataSource("4a9a698c-b476-3eef-f4f2-7fd4b9f8164b");
Dictionary<short,object> result4a9a698cb4763eeff4f27fd4b9f8164b=iSpace.ExecuteQuery(querySource4a9a698cb4763eeff4f27fd4b9f8164b,@"EXEC [GetReceiptExplorerDetails] 1,'" + ISpace["MF_ProjectRefNo"].Value + @"','" + ISpace["MF_Status"].Value + @"','" + ISpace["gv_userid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource4a9a698cb4763eeff4f27fd4b9f8164b =GetQueryExpressionDataSource(""4a9a698c-b476-3eef-f4f2-7fd4b9f8164b"");Dictionary<short,object> result4a9a698cb4763eeff4f27fd4b9f8164b=iSpace.ExecuteQuery(querySource4a9a698cb4763eeff4f27fd4b9f8164b,@""EXEC [GetReceiptExplorerDetails] 1,'"" + ISpace[""MF_ProjectRefNo""].Value + @""','"" + ISpace[""MF_Status""].Value + @""','"" + ISpace[""gv_userid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result4a9a698cb4763eeff4f27fd4b9f8164b!=null) && (result4a9a698cb4763eeff4f27fd4b9f8164b.Count!=0))
{
if(result4a9a698cb4763eeff4f27fd4b9f8164b.ContainsKey(0))
ISpace["MF_PendingCount"].Value = result4a9a698cb4763eeff4f27fd4b9f8164b[0];
if(result4a9a698cb4763eeff4f27fd4b9f8164b.ContainsKey(1))
ISpace["MF_CompletedCount"].Value = result4a9a698cb4763eeff4f27fd4b9f8164b[1];
}
else{
ISpace["MF_PendingCount"].Value = null;ISpace["MF_CompletedCount"].Value = null;
}
ISpace["M_UserId"].Value=ISpace["gv_userid"].Value;
base.WriteDebugInfo(@"ISpace[""M_UserId""].Value=ISpace[""gv_userid""].Value;");
ISpace["M_UserId"].Visible="false";
base.WriteDebugInfo(@"ISpace[""M_UserId""].Visible=""false"";");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySource99d3e3ef818db2c5430f3c6fd63ed12c =GetQueryExpressionDataSource("99d3e3ef-818d-b2c5-430f-3c6fd63ed12c");

DataTable result99d3e3ef818db2c5430f3c6fd63ed12c=iSpace.SetGridDataSource(querySource99d3e3ef818db2c5430f3c6fd63ed12c, _objectFactory.GetGridRPP("MG_ReceiptDetails"),@"EXEC [GetReceiptExplorerDetails] 2,'" + ISpace["MF_ProjectRefNo"].Value + @"','" + ISpace["MF_Status"].Value + @"','" + ISpace["gv_userid"].Value + @"'");


base.WriteDebugInfo(@"var querySource99d3e3ef818db2c5430f3c6fd63ed12c =GetQueryExpressionDataSource(""99d3e3ef-818d-b2c5-430f-3c6fd63ed12c"");DataTable result99d3e3ef818db2c5430f3c6fd63ed12c=iSpace.SetGridDataSource(querySource99d3e3ef818db2c5430f3c6fd63ed12c, _objectFactory.GetGridRPP(""MG_ReceiptDetails""),@""EXEC [GetReceiptExplorerDetails] 2,'"" + ISpace[""MF_ProjectRefNo""].Value + @""','"" + ISpace[""MF_Status""].Value + @""','"" + ISpace[""gv_userid""].Value + @""'"");");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result18a694d4a66ab49beac600a4043f47e8=acdataIspace391EB18FA1B6490FB60CD4572FE018AB.GetQueryExpressionBindings("18a694d4-a66a-b49b-eac6-00a4043f47e8");
iSpace.SetGridData(result99d3e3ef818db2c5430f3c6fd63ed12c,result18a694d4a66ab49beac600a4043f47e8,"MG_ReceiptDetails",ref ISpace);
if (_elementBase != null)  iSpace.SetLoopExpressionData("MG_ReceiptDetails","c4df7365-678c-f65a-2f9a-d05b5d20bab7",_objectFactory.GetGridRPP("MG_ReceiptDetails"),_elementBase.GetGridLoopQuery("c4df7365-678c-f65a-2f9a-d05b5d20bab7","MG_ReceiptDetails",true,ref ISpace), ref ISpace);

}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mf_projectrefno (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MF_ProjectRefNo-OnChange");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC [GetReceiptExplorerDetails] 1,'#MF_ProjectRefNo','#MF_Status','@@gv_UserId'");

var querySource4a9a698cb4763eeff4f27fd4b9f8164b =GetQueryExpressionDataSource("4a9a698c-b476-3eef-f4f2-7fd4b9f8164b");
Dictionary<short,object> result4a9a698cb4763eeff4f27fd4b9f8164b=iSpace.ExecuteQuery(querySource4a9a698cb4763eeff4f27fd4b9f8164b,@"EXEC [GetReceiptExplorerDetails] 1,'" + ISpace["MF_ProjectRefNo"].Value + @"','" + ISpace["MF_Status"].Value + @"','" + ISpace["gv_userid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource4a9a698cb4763eeff4f27fd4b9f8164b =GetQueryExpressionDataSource(""4a9a698c-b476-3eef-f4f2-7fd4b9f8164b"");Dictionary<short,object> result4a9a698cb4763eeff4f27fd4b9f8164b=iSpace.ExecuteQuery(querySource4a9a698cb4763eeff4f27fd4b9f8164b,@""EXEC [GetReceiptExplorerDetails] 1,'"" + ISpace[""MF_ProjectRefNo""].Value + @""','"" + ISpace[""MF_Status""].Value + @""','"" + ISpace[""gv_userid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result4a9a698cb4763eeff4f27fd4b9f8164b!=null) && (result4a9a698cb4763eeff4f27fd4b9f8164b.Count!=0))
{
if(result4a9a698cb4763eeff4f27fd4b9f8164b.ContainsKey(0))
ISpace["MF_PendingCount"].Value = result4a9a698cb4763eeff4f27fd4b9f8164b[0];
if(result4a9a698cb4763eeff4f27fd4b9f8164b.ContainsKey(1))
ISpace["MF_CompletedCount"].Value = result4a9a698cb4763eeff4f27fd4b9f8164b[1];
}
else{
ISpace["MF_PendingCount"].Value = null;ISpace["MF_CompletedCount"].Value = null;
}
ISpace["M_UserId"].Value=ISpace["gv_userid"].Value;
base.WriteDebugInfo(@"ISpace[""M_UserId""].Value=ISpace[""gv_userid""].Value;");
ISpace["M_UserId"].Visible="false";
base.WriteDebugInfo(@"ISpace[""M_UserId""].Visible=""false"";");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySource99d3e3ef818db2c5430f3c6fd63ed12c =GetQueryExpressionDataSource("99d3e3ef-818d-b2c5-430f-3c6fd63ed12c");

DataTable result99d3e3ef818db2c5430f3c6fd63ed12c=iSpace.SetGridDataSource(querySource99d3e3ef818db2c5430f3c6fd63ed12c, _objectFactory.GetGridRPP("MG_ReceiptDetails"),@"EXEC [GetReceiptExplorerDetails] 2,'" + ISpace["MF_ProjectRefNo"].Value + @"','" + ISpace["MF_Status"].Value + @"','" + ISpace["gv_userid"].Value + @"'");


base.WriteDebugInfo(@"var querySource99d3e3ef818db2c5430f3c6fd63ed12c =GetQueryExpressionDataSource(""99d3e3ef-818d-b2c5-430f-3c6fd63ed12c"");DataTable result99d3e3ef818db2c5430f3c6fd63ed12c=iSpace.SetGridDataSource(querySource99d3e3ef818db2c5430f3c6fd63ed12c, _objectFactory.GetGridRPP(""MG_ReceiptDetails""),@""EXEC [GetReceiptExplorerDetails] 2,'"" + ISpace[""MF_ProjectRefNo""].Value + @""','"" + ISpace[""MF_Status""].Value + @""','"" + ISpace[""gv_userid""].Value + @""'"");");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result18a694d4a66ab49beac600a4043f47e8=acdataIspace391EB18FA1B6490FB60CD4572FE018AB.GetQueryExpressionBindings("18a694d4-a66a-b49b-eac6-00a4043f47e8");
iSpace.SetGridData(result99d3e3ef818db2c5430f3c6fd63ed12c,result18a694d4a66ab49beac600a4043f47e8,"MG_ReceiptDetails",ref ISpace);
if (_elementBase != null)  iSpace.SetLoopExpressionData("MG_ReceiptDetails","c4df7365-678c-f65a-2f9a-d05b5d20bab7",_objectFactory.GetGridRPP("MG_ReceiptDetails"),_elementBase.GetGridLoopQuery("c4df7365-678c-f65a-2f9a-d05b5d20bab7","MG_ReceiptDetails",true,ref ISpace), ref ISpace);

}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_rd_view (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"RD_View-OnClick");

ISpace["RedirectUrl"].RedirectType="R";
ISpace["RedirectUrl"].Value="?PkActMId=1d2a9754-f9d8-747f-9a21-6341b89095ab&frmElementId=8A7A4CC4-0187-401F-BAF6-2AC1394A9245&PkPrMId=64C42232-67DB-43B8-8B68-4468FE0DD17F&formVersionId=B1CB93DB-7B9C-4661-BE11-02ED3BFD5725&Ver=0.0000&FormInstanceId="+ISpace["RD_RefId"].Value;
base.WriteDebugInfo(@"
ISpace[""RedirectUrl""].RedirectType=""R"";
ISpace[""RedirectUrl""].Value=""?PkActMId=1d2a9754-f9d8-747f-9a21-6341b89095ab&frmElementId=8A7A4CC4-0187-401F-BAF6-2AC1394A9245&PkPrMId=64C42232-67DB-43B8-8B68-4468FE0DD17F&formVersionId=B1CB93DB-7B9C-4661-BE11-02ED3BFD5725&Ver=0.0000&FormInstanceId=""+ISpace[""RD_RefId""].Value;");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mf_status (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MF_Status-OnChange");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC [GetReceiptExplorerDetails] 1,'#MF_ProjectRefNo','#MF_Status','@@gv_UserId'");

var querySource4a9a698cb4763eeff4f27fd4b9f8164b =GetQueryExpressionDataSource("4a9a698c-b476-3eef-f4f2-7fd4b9f8164b");
Dictionary<short,object> result4a9a698cb4763eeff4f27fd4b9f8164b=iSpace.ExecuteQuery(querySource4a9a698cb4763eeff4f27fd4b9f8164b,@"EXEC [GetReceiptExplorerDetails] 1,'" + ISpace["MF_ProjectRefNo"].Value + @"','" + ISpace["MF_Status"].Value + @"','" + ISpace["gv_userid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource4a9a698cb4763eeff4f27fd4b9f8164b =GetQueryExpressionDataSource(""4a9a698c-b476-3eef-f4f2-7fd4b9f8164b"");Dictionary<short,object> result4a9a698cb4763eeff4f27fd4b9f8164b=iSpace.ExecuteQuery(querySource4a9a698cb4763eeff4f27fd4b9f8164b,@""EXEC [GetReceiptExplorerDetails] 1,'"" + ISpace[""MF_ProjectRefNo""].Value + @""','"" + ISpace[""MF_Status""].Value + @""','"" + ISpace[""gv_userid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result4a9a698cb4763eeff4f27fd4b9f8164b!=null) && (result4a9a698cb4763eeff4f27fd4b9f8164b.Count!=0))
{
if(result4a9a698cb4763eeff4f27fd4b9f8164b.ContainsKey(0))
ISpace["MF_PendingCount"].Value = result4a9a698cb4763eeff4f27fd4b9f8164b[0];
if(result4a9a698cb4763eeff4f27fd4b9f8164b.ContainsKey(1))
ISpace["MF_CompletedCount"].Value = result4a9a698cb4763eeff4f27fd4b9f8164b[1];
}
else{
ISpace["MF_PendingCount"].Value = null;ISpace["MF_CompletedCount"].Value = null;
}
ISpace["M_UserId"].Value=ISpace["gv_userid"].Value;
base.WriteDebugInfo(@"ISpace[""M_UserId""].Value=ISpace[""gv_userid""].Value;");
ISpace["M_UserId"].Visible="false";
base.WriteDebugInfo(@"ISpace[""M_UserId""].Visible=""false"";");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySource99d3e3ef818db2c5430f3c6fd63ed12c =GetQueryExpressionDataSource("99d3e3ef-818d-b2c5-430f-3c6fd63ed12c");

DataTable result99d3e3ef818db2c5430f3c6fd63ed12c=iSpace.SetGridDataSource(querySource99d3e3ef818db2c5430f3c6fd63ed12c, _objectFactory.GetGridRPP("MG_ReceiptDetails"),@"EXEC [GetReceiptExplorerDetails] 2,'" + ISpace["MF_ProjectRefNo"].Value + @"','" + ISpace["MF_Status"].Value + @"','" + ISpace["gv_userid"].Value + @"'");


base.WriteDebugInfo(@"var querySource99d3e3ef818db2c5430f3c6fd63ed12c =GetQueryExpressionDataSource(""99d3e3ef-818d-b2c5-430f-3c6fd63ed12c"");DataTable result99d3e3ef818db2c5430f3c6fd63ed12c=iSpace.SetGridDataSource(querySource99d3e3ef818db2c5430f3c6fd63ed12c, _objectFactory.GetGridRPP(""MG_ReceiptDetails""),@""EXEC [GetReceiptExplorerDetails] 2,'"" + ISpace[""MF_ProjectRefNo""].Value + @""','"" + ISpace[""MF_Status""].Value + @""','"" + ISpace[""gv_userid""].Value + @""'"");");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result18a694d4a66ab49beac600a4043f47e8=acdataIspace391EB18FA1B6490FB60CD4572FE018AB.GetQueryExpressionBindings("18a694d4-a66a-b49b-eac6-00a4043f47e8");
iSpace.SetGridData(result99d3e3ef818db2c5430f3c6fd63ed12c,result18a694d4a66ab49beac600a4043f47e8,"MG_ReceiptDetails",ref ISpace);
if (_elementBase != null)  iSpace.SetLoopExpressionData("MG_ReceiptDetails","c4df7365-678c-f65a-2f9a-d05b5d20bab7",_objectFactory.GetGridRPP("MG_ReceiptDetails"),_elementBase.GetGridLoopQuery("c4df7365-678c-f65a-2f9a-d05b5d20bab7","MG_ReceiptDetails",true,ref ISpace), ref ISpace);

}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mf_createnew (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MF_CreateNew-OnClick");

ISpace["RedirectUrl"].RedirectType="R";
ISpace["RedirectUrl"].Value="?PkActMId=DDBF5292-6EF4-4C37-B72A-E6DCFFBF7B02&frmElementId=8A7A4CC4-0187-401F-BAF6-2AC1394A9245&PkPrMId=64C42232-67DB-43B8-8B68-4468FE0DD17F&formVersionId=B1CB93DB-7B9C-4661-BE11-02ED3BFD5725&Ver=0.0000";
base.WriteDebugInfo(@"
ISpace[""RedirectUrl""].RedirectType=""R"";
ISpace[""RedirectUrl""].Value=""?PkActMId=DDBF5292-6EF4-4C37-B72A-E6DCFFBF7B02&frmElementId=8A7A4CC4-0187-401F-BAF6-2AC1394A9245&PkPrMId=64C42232-67DB-43B8-8B68-4468FE0DD17F&formVersionId=B1CB93DB-7B9C-4661-BE11-02ED3BFD5725&Ver=0.0000"";");
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
		if(elementName.ToLower().Equals("mf_projectrefno"))
    {
    			SubscribeElementEvents_mf_projectrefno(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mf_status"))
    {
    			SubscribeElementEvents_mf_status(ref dfsParam);
    }
}
	if(methodName.ToLower().Equals("onclick"))
{
		if(elementName.ToLower().Equals("rd_view"))
{
			SubscribeElementEvents_rd_view(ref dfsParam);
}
		if(elementName.ToLower().Equals("mf_createnew"))
{
			SubscribeElementEvents_mf_createnew(ref dfsParam);
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


	public partial class AcDataISpace391EB18FA1B6490FB60CD4572FE018AB  : ExtensionActivityBase
	{		
		
		
		private Dictionary<string,  List<Triplet<string, short, short?>>> queryExpressionBindings = 
											new Dictionary<string,  List<Triplet<string, short, short?>>>
		{
							{"18a694d4-a66a-b49b-eac6-00a4043f47e8", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("RD_ReceiptAmount",3,
														   -1),
								   new Triplet<string, short, short?>("RD_ReceiptDate",2,
														   -1),
								   new Triplet<string, short, short?>("RD_Status",4,
														   -1),
								   new Triplet<string, short, short?>("RD_RefNo",1,
														   -1),
								   new Triplet<string, short, short?>("RD_RefId",0,
														   -1),
								}
			},
					};	

	

		private Dictionary<string,string> formVersionList =new Dictionary<string,string> 
		{
							{"F663CD0F-3CCA-46BE-86C9-2DA22AE05E9F", "Medium"},
					};	

		
		private Dictionary<string,string> formVersionLayoutList =new Dictionary<string,string> 
		{
							{"BA6D5394-215B-4679-A4C0-D74178EE0F9F", ""},
							{"B7884546-777F-491C-8666-05EFD8EC22D9", ""},
							{"F663CD0F-3CCA-46BE-86C9-2DA22AE05E9F", ""},
							{"766CD7F4-9C55-4DFE-B864-57C8AD57E8E9", ""},
							{"ECE6267F-3922-40A8-946B-9EF78A07D78F", ""},
							{"AC91B3E3-E0B7-4362-B3F1-B507ACADE75B", ""},
							{"57BC52DF-65C0-4EF9-AF02-94843F51DB6E", ""},
							{"E27E6A4E-5958-464A-B09D-B584D340083F", ""},
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
		


