  







namespace CPS.Proof.DFSExtension
{
	using System;
    using System.Collections.Generic;     
	using System.Linq;
	
	
	public partial class ReimbursementExplorerProcessMetadata : ExtensionProcessBase
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
            get { return "3A048090-0538-48F9-8870-AE1A37E0EDB9"; }
        }

        public override string ProcessName
        {
            get { return "ReimbursementExplorer"; }
        }

		public override string ProcessDescription
        {
            get { return "Reimbursement Explorer"; }
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
            get {return "3A048090-0538-48F9-8870-AE1A37E0EDB9";}
        }

		public override byte ProcessInstanceMode
        {
            get {return 3;}
        }		

		public override string MasterFormId
        {
            get {  
				   return "A2D043F8-4C87-4C0C-BB8B-FB2C64B24C44";	}
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
	

	public partial class ReimbursementExplorerObjectFactory  : ExtObjectFactoryBase
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
        //    return (IExtBaseMetaData)new ReimbursementExplorerProcessMetadata();
        //}
	


		private List<Triplet<string, string, string>> queryExpressionData = new List<Triplet<string, string, string>>
		{
	  			
			     new Triplet<string, string, string>("3BA29252-F21E-4E55-85E1-24000496D7B1","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("34638954-72C9-460C-9AC4-4A85F138BD24","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("34638954-72C9-460C-9AC4-4A85F138BD24","Load Explorer Details",
												     @"10AA6840-065A-4E6E-95CC-29609326A113"),
			
			
			
		};

		
		private List<Triplet<string, string, string>> ComboDataSource = new List<Triplet<string, string, string>>
		{

		
	  			
			     new Triplet<string, string, string>("MF_ProjectRefNo","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMAqCwOWy+D7Ogje1I4jfjiAZNrjEazgaNyfBj9pr2u90lOsHzRNfKnSybWqRxrZGqV",
												     @"EXEC GetProjectNoCombo 1,'@@gv_UserId'"),
			
						
			     new Triplet<string, string, string>("MF_Status","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMAqCwOWy+D7Ogje1I4jfjiAZNrjEazgaNyfBj9pr2u90lOsHzRNfKnSybWqRxrZGqV",
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
											case "3F131441-D0E5-4A35-BADE-BBDC8C5190A1":
							virtualInstance=new ISpace3F131441D0E54A35BADEBBDC8C5190A1();
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
	

	public partial class ReimbursementExplorerDataElementFactory  : ExtElementBase
    {

     /// <summary>
        /// A <see cref="log4net.ILog"/> that contains the logger instance for 
        /// logging
        /// </summary>
        private readonly ILog _sysLog;

        public ReimbursementExplorerDataElementFactory()
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

               
                
                                      case "A2D043F8-4C87-4C0C-BB8B-FB2C64B24C44":
                    {
                     
                                     fInsertQuery=@"IF NOT EXISTS(SELECT 1 FROM [A2D043F8-4C87-4C0C-BB8B-FB2C64B24C44] WHERE InstanceId='{0}') BEGIN INSERT INTO [A2D043F8-4C87-4C0C-BB8B-FB2C64B24C44](ProcessActivityMapId,FormId,SLATime,MF_ProjectRefNo,MF_Status,MF_PendingCount,MF_CompletedCount,Subject,ExecutionStatus,ExecutionMessage,SetDestinationTo,RedirectUrl,InstanceId)
							VALUES( {3}) END ELSE BEGIN UPDATE [A2D043F8-4C87-4C0C-BB8B-FB2C64B24C44]SET {4}WHERE InstanceId='{0}'END ";

                                     colList=@"ProcessActivityMapId,FormId,SLATime,MF_ProjectRefNo,MF_Status,MF_PendingCount,MF_CompletedCount,Subject,ExecutionStatus,ExecutionMessage,SetDestinationTo,RedirectUrl,InstanceId";
                                    
                     
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

                
                 
                                      case "10AA6840-065A-4E6E-95CC-29609326A113":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_10AA6840065A4E6E95CC29609326A113 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [RD_RefNo] VARCHAR(MAX)	, [RD_ReceiptDate] DATETIME	, [RD_ReceiptAmount] DECIMAL(18,2)	, [RD_RefId] VARCHAR(MAX)	, [RD_Status] VARCHAR(MAX)){0}INSERT INTO [10AA6840-065A-4E6E-95CC-29609326A113](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,RD_RefNo,RD_ReceiptDate,RD_ReceiptAmount,RD_RefId,RD_Status)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.RD_RefNo,TDT.RD_ReceiptDate,TDT.RD_ReceiptAmount,TDT.RD_RefId,TDT.RD_Status FROM @TBL_10AA6840065A4E6E95CC29609326A113 TDT
							LEFT JOIN [10AA6840-065A-4E6E-95CC-29609326A113] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,RD_RefNo=TDT.RD_RefNo,RD_ReceiptDate=TDT.RD_ReceiptDate,RD_ReceiptAmount=TDT.RD_ReceiptAmount,RD_RefId=TDT.RD_RefId,RD_Status=TDT.RD_Status FROM @TBL_10AA6840065A4E6E95CC29609326A113 TDT
							JOIN [10AA6840-065A-4E6E-95CC-29609326A113] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,RD_RefNo,RD_ReceiptDate,RD_ReceiptAmount,RD_RefId,RD_Status";

                                     tempInsertQuery=@"INSERT INTO @TBL_10AA6840065A4E6E95CC29609326A113(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,RD_RefNo,RD_ReceiptDate,RD_ReceiptAmount,RD_RefId,RD_Status)VALUES({0});";
                                     

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
                     

                                         case "10AA6840-065A-4E6E-95CC-29609326A113":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_10AA6840065A4E6E95CC29609326A113 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [RD_RefNo] VARCHAR(MAX)	, [RD_ReceiptDate] DATETIME	, [RD_ReceiptAmount] DECIMAL(18,2)	, [RD_RefId] VARCHAR(MAX)	, [RD_Status] VARCHAR(MAX)){0}INSERT INTO [10AA6840-065A-4E6E-95CC-29609326A113](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,RD_RefNo,RD_ReceiptDate,RD_ReceiptAmount,RD_RefId,RD_Status)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.RD_RefNo,TDT.RD_ReceiptDate,TDT.RD_ReceiptAmount,TDT.RD_RefId,TDT.RD_Status FROM @TBL_10AA6840065A4E6E95CC29609326A113 TDT
							LEFT JOIN [10AA6840-065A-4E6E-95CC-29609326A113] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,RD_RefNo=TDT.RD_RefNo,RD_ReceiptDate=TDT.RD_ReceiptDate,RD_ReceiptAmount=TDT.RD_ReceiptAmount,RD_RefId=TDT.RD_RefId,RD_Status=TDT.RD_Status FROM @TBL_10AA6840065A4E6E95CC29609326A113 TDT
							JOIN [10AA6840-065A-4E6E-95CC-29609326A113] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,RD_RefNo,RD_ReceiptDate,RD_ReceiptAmount,RD_RefId,RD_Status";

                            tempInsertQuery=@"INSERT INTO @TBL_10AA6840065A4E6E95CC29609326A113(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,RD_RefNo,RD_ReceiptDate,RD_ReceiptAmount,RD_RefId,RD_Status)VALUES({0});";

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
public class ISpace3F131441D0E54A35BADEBBDC8C5190A1 : VirtualForm
{
IISpace iSpace = new ISpace();
AcDataISpace3F131441D0E54A35BADEBBDC8C5190A1 acdataIspace3F131441D0E54A35BADEBBDC8C5190A1=new AcDataISpace3F131441D0E54A35BADEBBDC8C5190A1();
private void SubscribeFormEvents_root(ref Dictionary<string, ServiceElementData> ISpace)
{
try
{
base.WriteDebugInfo(@"Root-OnAfterFormLoad");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC [GetReimbursementExplorerDetails] 1,'#MF_ProjectRefNo','#MF_Status','@@gv_UserId'");

var querySource3BA29252F21E4E5585E124000496D7B1 =GetQueryExpressionDataSource("3BA29252-F21E-4E55-85E1-24000496D7B1");
Dictionary<short,object> result3BA29252F21E4E5585E124000496D7B1=iSpace.ExecuteQuery(querySource3BA29252F21E4E5585E124000496D7B1,@"EXEC [GetReimbursementExplorerDetails] 1,'" + ISpace["MF_ProjectRefNo"].Value + @"','" + ISpace["MF_Status"].Value + @"','" + ISpace["gv_userid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource3BA29252F21E4E5585E124000496D7B1 =GetQueryExpressionDataSource(""3BA29252-F21E-4E55-85E1-24000496D7B1"");Dictionary<short,object> result3BA29252F21E4E5585E124000496D7B1=iSpace.ExecuteQuery(querySource3BA29252F21E4E5585E124000496D7B1,@""EXEC [GetReimbursementExplorerDetails] 1,'"" + ISpace[""MF_ProjectRefNo""].Value + @""','"" + ISpace[""MF_Status""].Value + @""','"" + ISpace[""gv_userid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result3BA29252F21E4E5585E124000496D7B1!=null) && (result3BA29252F21E4E5585E124000496D7B1.Count!=0))
{
if(result3BA29252F21E4E5585E124000496D7B1.ContainsKey(1))
ISpace["MF_CompletedCount"].Value = result3BA29252F21E4E5585E124000496D7B1[1];
if(result3BA29252F21E4E5585E124000496D7B1.ContainsKey(0))
ISpace["MF_PendingCount"].Value = result3BA29252F21E4E5585E124000496D7B1[0];
}
else{
ISpace["MF_CompletedCount"].Value = null;ISpace["MF_PendingCount"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySource3463895472C9460C9AC44A85F138BD24 =GetQueryExpressionDataSource("34638954-72C9-460C-9AC4-4A85F138BD24");

DataTable result3463895472C9460C9AC44A85F138BD24=iSpace.SetGridDataSource(querySource3463895472C9460C9AC44A85F138BD24, _objectFactory.GetGridRPP("MG_ReceiptDetails"),@"EXEC [GetReimbursementExplorerDetails] 2,'" + ISpace["MF_ProjectRefNo"].Value + @"','" + ISpace["MF_Status"].Value + @"','" + ISpace["gv_userid"].Value + @"'");

iSpace.InsertGridBindDetails("MG_ReceiptDetails","11",querySource3463895472C9460C9AC44A85F138BD24,"EXEC [GetReimbursementExplorerDetails] 2,'" + ISpace["MF_ProjectRefNo"].Value + @"','" + ISpace["MF_Status"].Value + @"','" + ISpace["gv_userid"].Value + @"'",_objectFactory.GetGridRPP("MG_ReceiptDetails"));

base.WriteDebugInfo(@"var querySource3463895472C9460C9AC44A85F138BD24 =GetQueryExpressionDataSource(""34638954-72C9-460C-9AC4-4A85F138BD24"");DataTable result3463895472C9460C9AC44A85F138BD24=iSpace.SetGridDataSource(querySource3463895472C9460C9AC44A85F138BD24, _objectFactory.GetGridRPP(""MG_ReceiptDetails""),@""EXEC [GetReimbursementExplorerDetails] 2,'"" + ISpace[""MF_ProjectRefNo""].Value + @""','"" + ISpace[""MF_Status""].Value + @""','"" + ISpace[""gv_userid""].Value + @""'"");iSpace.InsertGridBindDetails(""MG_ReceiptDetails"",""11"",querySource3463895472C9460C9AC44A85F138BD24,""EXEC [GetReimbursementExplorerDetails] 2,'"" + ISpace[""MF_ProjectRefNo""].Value + @""','"" + ISpace[""MF_Status""].Value + @""','"" + ISpace[""gv_userid""].Value + @""'"",_objectFactory.GetGridRPP(""MG_ReceiptDetails""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result1823B4FB948D44C18658156343FE32CC=acdataIspace3F131441D0E54A35BADEBBDC8C5190A1.GetQueryExpressionBindings("1823B4FB-948D-44C1-8658-156343FE32CC");
iSpace.SetGridData(result3463895472C9460C9AC44A85F138BD24,result1823B4FB948D44C18658156343FE32CC,"MG_ReceiptDetails",ref ISpace);
iSpace.UpdateGridBindDetails("MG_ReceiptDetails",result1823B4FB948D44C18658156343FE32CC);
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
ISpace["RedirectUrl"].Value="?PkActMId=db7cf7d3-9283-9221-9512-156e470919b5&frmElementId=7580ABE2-1059-4AB0-AC76-04DE981561BA&PkPrMId=36447555-6c49-45cd-8563-426f536ebf74&formVersionId=73B8AA02-9DDD-4205-8CCE-3A640B657727&Ver=0.0000&FormInstanceId="+ISpace["RD_RefId"].Value;
base.WriteDebugInfo(@"
ISpace[""RedirectUrl""].RedirectType=""R"";
ISpace[""RedirectUrl""].Value=""?PkActMId=db7cf7d3-9283-9221-9512-156e470919b5&frmElementId=7580ABE2-1059-4AB0-AC76-04DE981561BA&PkPrMId=36447555-6c49-45cd-8563-426f536ebf74&formVersionId=73B8AA02-9DDD-4205-8CCE-3A640B657727&Ver=0.0000&FormInstanceId=""+ISpace[""RD_RefId""].Value;");
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
base.WriteDebugInfo(@"EXEC [GetReimbursementExplorerDetails] 1,'#MF_ProjectRefNo','#MF_Status','@@gv_UserId'");

var querySource3BA29252F21E4E5585E124000496D7B1 =GetQueryExpressionDataSource("3BA29252-F21E-4E55-85E1-24000496D7B1");
Dictionary<short,object> result3BA29252F21E4E5585E124000496D7B1=iSpace.ExecuteQuery(querySource3BA29252F21E4E5585E124000496D7B1,@"EXEC [GetReimbursementExplorerDetails] 1,'" + ISpace["MF_ProjectRefNo"].Value + @"','" + ISpace["MF_Status"].Value + @"','" + ISpace["gv_userid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource3BA29252F21E4E5585E124000496D7B1 =GetQueryExpressionDataSource(""3BA29252-F21E-4E55-85E1-24000496D7B1"");Dictionary<short,object> result3BA29252F21E4E5585E124000496D7B1=iSpace.ExecuteQuery(querySource3BA29252F21E4E5585E124000496D7B1,@""EXEC [GetReimbursementExplorerDetails] 1,'"" + ISpace[""MF_ProjectRefNo""].Value + @""','"" + ISpace[""MF_Status""].Value + @""','"" + ISpace[""gv_userid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result3BA29252F21E4E5585E124000496D7B1!=null) && (result3BA29252F21E4E5585E124000496D7B1.Count!=0))
{
if(result3BA29252F21E4E5585E124000496D7B1.ContainsKey(1))
ISpace["MF_CompletedCount"].Value = result3BA29252F21E4E5585E124000496D7B1[1];
if(result3BA29252F21E4E5585E124000496D7B1.ContainsKey(0))
ISpace["MF_PendingCount"].Value = result3BA29252F21E4E5585E124000496D7B1[0];
}
else{
ISpace["MF_CompletedCount"].Value = null;ISpace["MF_PendingCount"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySource3463895472C9460C9AC44A85F138BD24 =GetQueryExpressionDataSource("34638954-72C9-460C-9AC4-4A85F138BD24");

DataTable result3463895472C9460C9AC44A85F138BD24=iSpace.SetGridDataSource(querySource3463895472C9460C9AC44A85F138BD24, _objectFactory.GetGridRPP("MG_ReceiptDetails"),@"EXEC [GetReimbursementExplorerDetails] 2,'" + ISpace["MF_ProjectRefNo"].Value + @"','" + ISpace["MF_Status"].Value + @"','" + ISpace["gv_userid"].Value + @"'");

iSpace.InsertGridBindDetails("MG_ReceiptDetails","11",querySource3463895472C9460C9AC44A85F138BD24,"EXEC [GetReimbursementExplorerDetails] 2,'" + ISpace["MF_ProjectRefNo"].Value + @"','" + ISpace["MF_Status"].Value + @"','" + ISpace["gv_userid"].Value + @"'",_objectFactory.GetGridRPP("MG_ReceiptDetails"));

base.WriteDebugInfo(@"var querySource3463895472C9460C9AC44A85F138BD24 =GetQueryExpressionDataSource(""34638954-72C9-460C-9AC4-4A85F138BD24"");DataTable result3463895472C9460C9AC44A85F138BD24=iSpace.SetGridDataSource(querySource3463895472C9460C9AC44A85F138BD24, _objectFactory.GetGridRPP(""MG_ReceiptDetails""),@""EXEC [GetReimbursementExplorerDetails] 2,'"" + ISpace[""MF_ProjectRefNo""].Value + @""','"" + ISpace[""MF_Status""].Value + @""','"" + ISpace[""gv_userid""].Value + @""'"");iSpace.InsertGridBindDetails(""MG_ReceiptDetails"",""11"",querySource3463895472C9460C9AC44A85F138BD24,""EXEC [GetReimbursementExplorerDetails] 2,'"" + ISpace[""MF_ProjectRefNo""].Value + @""','"" + ISpace[""MF_Status""].Value + @""','"" + ISpace[""gv_userid""].Value + @""'"",_objectFactory.GetGridRPP(""MG_ReceiptDetails""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result1823B4FB948D44C18658156343FE32CC=acdataIspace3F131441D0E54A35BADEBBDC8C5190A1.GetQueryExpressionBindings("1823B4FB-948D-44C1-8658-156343FE32CC");
iSpace.SetGridData(result3463895472C9460C9AC44A85F138BD24,result1823B4FB948D44C18658156343FE32CC,"MG_ReceiptDetails",ref ISpace);
iSpace.UpdateGridBindDetails("MG_ReceiptDetails",result1823B4FB948D44C18658156343FE32CC);
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
ISpace["RedirectUrl"].Value="?PkActMId=F66E6A92-393A-4A49-8F44-78FD095E0597&frmElementId=7580ABE2-1059-4AB0-AC76-04DE981561BA&PkPrMId=36447555-6c49-45cd-8563-426f536ebf74&formVersionId=73B8AA02-9DDD-4205-8CCE-3A640B657727&Ver=0.0000";
base.WriteDebugInfo(@"
ISpace[""RedirectUrl""].RedirectType=""R"";
ISpace[""RedirectUrl""].Value=""?PkActMId=F66E6A92-393A-4A49-8F44-78FD095E0597&frmElementId=7580ABE2-1059-4AB0-AC76-04DE981561BA&PkPrMId=36447555-6c49-45cd-8563-426f536ebf74&formVersionId=73B8AA02-9DDD-4205-8CCE-3A640B657727&Ver=0.0000"";");
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
base.WriteDebugInfo(@"EXEC [GetReimbursementExplorerDetails] 1,'#MF_ProjectRefNo','#MF_Status','@@gv_UserId'");

var querySource3BA29252F21E4E5585E124000496D7B1 =GetQueryExpressionDataSource("3BA29252-F21E-4E55-85E1-24000496D7B1");
Dictionary<short,object> result3BA29252F21E4E5585E124000496D7B1=iSpace.ExecuteQuery(querySource3BA29252F21E4E5585E124000496D7B1,@"EXEC [GetReimbursementExplorerDetails] 1,'" + ISpace["MF_ProjectRefNo"].Value + @"','" + ISpace["MF_Status"].Value + @"','" + ISpace["gv_userid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource3BA29252F21E4E5585E124000496D7B1 =GetQueryExpressionDataSource(""3BA29252-F21E-4E55-85E1-24000496D7B1"");Dictionary<short,object> result3BA29252F21E4E5585E124000496D7B1=iSpace.ExecuteQuery(querySource3BA29252F21E4E5585E124000496D7B1,@""EXEC [GetReimbursementExplorerDetails] 1,'"" + ISpace[""MF_ProjectRefNo""].Value + @""','"" + ISpace[""MF_Status""].Value + @""','"" + ISpace[""gv_userid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result3BA29252F21E4E5585E124000496D7B1!=null) && (result3BA29252F21E4E5585E124000496D7B1.Count!=0))
{
if(result3BA29252F21E4E5585E124000496D7B1.ContainsKey(1))
ISpace["MF_CompletedCount"].Value = result3BA29252F21E4E5585E124000496D7B1[1];
if(result3BA29252F21E4E5585E124000496D7B1.ContainsKey(0))
ISpace["MF_PendingCount"].Value = result3BA29252F21E4E5585E124000496D7B1[0];
}
else{
ISpace["MF_CompletedCount"].Value = null;ISpace["MF_PendingCount"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySource3463895472C9460C9AC44A85F138BD24 =GetQueryExpressionDataSource("34638954-72C9-460C-9AC4-4A85F138BD24");

DataTable result3463895472C9460C9AC44A85F138BD24=iSpace.SetGridDataSource(querySource3463895472C9460C9AC44A85F138BD24, _objectFactory.GetGridRPP("MG_ReceiptDetails"),@"EXEC [GetReimbursementExplorerDetails] 2,'" + ISpace["MF_ProjectRefNo"].Value + @"','" + ISpace["MF_Status"].Value + @"','" + ISpace["gv_userid"].Value + @"'");

iSpace.InsertGridBindDetails("MG_ReceiptDetails","11",querySource3463895472C9460C9AC44A85F138BD24,"EXEC [GetReimbursementExplorerDetails] 2,'" + ISpace["MF_ProjectRefNo"].Value + @"','" + ISpace["MF_Status"].Value + @"','" + ISpace["gv_userid"].Value + @"'",_objectFactory.GetGridRPP("MG_ReceiptDetails"));

base.WriteDebugInfo(@"var querySource3463895472C9460C9AC44A85F138BD24 =GetQueryExpressionDataSource(""34638954-72C9-460C-9AC4-4A85F138BD24"");DataTable result3463895472C9460C9AC44A85F138BD24=iSpace.SetGridDataSource(querySource3463895472C9460C9AC44A85F138BD24, _objectFactory.GetGridRPP(""MG_ReceiptDetails""),@""EXEC [GetReimbursementExplorerDetails] 2,'"" + ISpace[""MF_ProjectRefNo""].Value + @""','"" + ISpace[""MF_Status""].Value + @""','"" + ISpace[""gv_userid""].Value + @""'"");iSpace.InsertGridBindDetails(""MG_ReceiptDetails"",""11"",querySource3463895472C9460C9AC44A85F138BD24,""EXEC [GetReimbursementExplorerDetails] 2,'"" + ISpace[""MF_ProjectRefNo""].Value + @""','"" + ISpace[""MF_Status""].Value + @""','"" + ISpace[""gv_userid""].Value + @""'"",_objectFactory.GetGridRPP(""MG_ReceiptDetails""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result1823B4FB948D44C18658156343FE32CC=acdataIspace3F131441D0E54A35BADEBBDC8C5190A1.GetQueryExpressionBindings("1823B4FB-948D-44C1-8658-156343FE32CC");
iSpace.SetGridData(result3463895472C9460C9AC44A85F138BD24,result1823B4FB948D44C18658156343FE32CC,"MG_ReceiptDetails",ref ISpace);
iSpace.UpdateGridBindDetails("MG_ReceiptDetails",result1823B4FB948D44C18658156343FE32CC);
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


	public partial class AcDataISpace3F131441D0E54A35BADEBBDC8C5190A1  : ExtensionActivityBase
	{		
		
		
		private Dictionary<string,  List<Triplet<string, short, short?>>> queryExpressionBindings = 
											new Dictionary<string,  List<Triplet<string, short, short?>>>
		{
							{"1823B4FB-948D-44C1-8658-156343FE32CC", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("RD_ReceiptAmount",3,
														   -1),
								   new Triplet<string, short, short?>("RD_RefNo",1,
														   -1),
								   new Triplet<string, short, short?>("RD_ReceiptDate",2,
														   -1),
								   new Triplet<string, short, short?>("RD_RefId",0,
														   -1),
								   new Triplet<string, short, short?>("RD_Status",4,
														   -1),
								}
			},
					};	

	

		private Dictionary<string,string> formVersionList =new Dictionary<string,string> 
		{
							{"EBFF27E0-9875-4D44-9674-9F00EBD7ABAD", "Medium"},
					};	

		
		private Dictionary<string,string> formVersionLayoutList =new Dictionary<string,string> 
		{
							{"DBFBFC2F-0389-40E9-BCCA-267498DFF16D", ""},
							{"DBE956C1-953F-43C6-9493-38130E7BF1C9", ""},
							{"EBFF27E0-9875-4D44-9674-9F00EBD7ABAD", ""},
							{"43F6406F-D21C-4ABA-9C2C-25571B70162A", ""},
							{"A940D55E-496D-406D-AE57-98D90BE51A5B", ""},
							{"AC953A31-E10E-4BDC-956B-EF179CA44CF5", ""},
							{"85259837-73F5-4F5D-976F-24450989222F", ""},
							{"CAC43D98-8177-48CB-9005-6D423C0D6097", ""},
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
		


