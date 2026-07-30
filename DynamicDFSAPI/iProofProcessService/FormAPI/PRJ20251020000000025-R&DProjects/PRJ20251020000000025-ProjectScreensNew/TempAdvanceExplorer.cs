  







namespace CPS.Proof.DFSExtension
{
	using System;
    using System.Collections.Generic;     
	using System.Linq;
	
	
	public partial class TempAdvanceExplorerProcessMetadata : ExtensionProcessBase
	{		

        public override long PackageId
        {
            get { return 30305; }
        }

        public override string PackageName
        {
            get { return "PRJ20251020000000025-ProjectScreensNew"; }
        }

		public override string PackageDescription
        {
            get { return "ProjectScreensNew"; }
        }

        public override string ProcessId
        {
            get { return "0CC7EA0F-1DD0-4053-9D0E-E7EF819021D7"; }
        }

        public override string ProcessName
        {
            get { return "TempAdvanceExplorer"; }
        }

		public override string ProcessDescription
        {
            get { return "Temp Advance Explorer"; }
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
            get {return "0CC7EA0F-1DD0-4053-9D0E-E7EF819021D7";}
        }

		public override byte ProcessInstanceMode
        {
            get {return 3;}
        }		

		public override string MasterFormId
        {
            get {  
				   return "49A96C7C-D729-40AB-BA35-E48EC2181E2D";	}
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
	

	public partial class TempAdvanceExplorerObjectFactory  : ExtObjectFactoryBase
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
        //    return (IExtBaseMetaData)new TempAdvanceExplorerProcessMetadata();
        //}
	


		private List<Triplet<string, string, string>> queryExpressionData = new List<Triplet<string, string, string>>
		{
	  			
			     new Triplet<string, string, string>("2DCE3283-256D-4120-9380-65242E6EC71E","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("B95305A4-4472-4471-905E-13C95BEAB7CE","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("2DCE3283-256D-4120-9380-65242E6EC71E","Load Explorer Details",
												     @"98F402C4-A592-451F-B29E-2F28BE67530B"),
			
			
			
		};


		
		private List<Triplet<string, string, string>> ComboDataSource = new List<Triplet<string, string, string>>
		{

		
	  			
			
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
											case "0325353E-7E13-4762-AFC9-88434C58F52C":
							virtualInstance=new ISpace0325353E7E134762AFC988434C58F52C();
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
	

	public partial class TempAdvanceExplorerDataElementFactory  : ExtElementBase
    {

     /// <summary>
        /// A <see cref="log4net.ILog"/> that contains the logger instance for 
        /// logging
        /// </summary>
        private readonly ILog _sysLog;

        public TempAdvanceExplorerDataElementFactory()
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

               
                
                                      case "49A96C7C-D729-40AB-BA35-E48EC2181E2D":
                    {
                     
                                     fInsertQuery=@"IF NOT EXISTS(SELECT 1 FROM [49A96C7C-D729-40AB-BA35-E48EC2181E2D] WHERE InstanceId='{0}') BEGIN INSERT INTO [49A96C7C-D729-40AB-BA35-E48EC2181E2D](ProcessActivityMapId,FormId,SLATime,MF_ProjectRefNo,MF_Status,MF_PendingCount,MF_CompletedCount,Subject,ExecutionStatus,ExecutionMessage,SetDestinationTo,RedirectUrl,InstanceId)
							VALUES( {3}) END ELSE BEGIN UPDATE [49A96C7C-D729-40AB-BA35-E48EC2181E2D]SET {4}WHERE InstanceId='{0}'END ";

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

                
                 
                                      case "98F402C4-A592-451F-B29E-2F28BE67530B":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_98F402C4A592451FB29E2F28BE67530B AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [RD_RefNo] VARCHAR(MAX)	, [RD_ReceiptDate] DATETIME	, [RD_ReceiptAmount] DECIMAL(18,2)	, [RD_RefId] VARCHAR(MAX)	, [RD_Status] VARCHAR(MAX)){0}INSERT INTO [98F402C4-A592-451F-B29E-2F28BE67530B](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,RD_RefNo,RD_ReceiptDate,RD_ReceiptAmount,RD_RefId,RD_Status)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.RD_RefNo,TDT.RD_ReceiptDate,TDT.RD_ReceiptAmount,TDT.RD_RefId,TDT.RD_Status FROM @TBL_98F402C4A592451FB29E2F28BE67530B TDT
							LEFT JOIN [98F402C4-A592-451F-B29E-2F28BE67530B] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,RD_RefNo=TDT.RD_RefNo,RD_ReceiptDate=TDT.RD_ReceiptDate,RD_ReceiptAmount=TDT.RD_ReceiptAmount,RD_RefId=TDT.RD_RefId,RD_Status=TDT.RD_Status FROM @TBL_98F402C4A592451FB29E2F28BE67530B TDT
							JOIN [98F402C4-A592-451F-B29E-2F28BE67530B] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,RD_RefNo,RD_ReceiptDate,RD_ReceiptAmount,RD_RefId,RD_Status";

                                     tempInsertQuery=@"INSERT INTO @TBL_98F402C4A592451FB29E2F28BE67530B(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,RD_RefNo,RD_ReceiptDate,RD_ReceiptAmount,RD_RefId,RD_Status)VALUES({0});";
                                     

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
                     

                                         case "98F402C4-A592-451F-B29E-2F28BE67530B":
                    {
                     
                                //Delete Existing Records of InstanceId
                                deleteQuery="Delete FROM [98F402C4-A592-451F-B29E-2F28BE67530B] WHERE InstanceId='{0}';";

                           

                            gInsertQuery=@"
		
		DECLARE  @TBL_98F402C4A592451FB29E2F28BE67530B AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [RD_RefNo] VARCHAR(MAX)	, [RD_ReceiptDate] DATETIME	, [RD_ReceiptAmount] DECIMAL(18,2)	, [RD_RefId] VARCHAR(MAX)	, [RD_Status] VARCHAR(MAX)){0}INSERT INTO [98F402C4-A592-451F-B29E-2F28BE67530B](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,RD_RefNo,RD_ReceiptDate,RD_ReceiptAmount,RD_RefId,RD_Status)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.RD_RefNo,TDT.RD_ReceiptDate,TDT.RD_ReceiptAmount,TDT.RD_RefId,TDT.RD_Status FROM @TBL_98F402C4A592451FB29E2F28BE67530B TDT
							LEFT JOIN [98F402C4-A592-451F-B29E-2F28BE67530B] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,RD_RefNo=TDT.RD_RefNo,RD_ReceiptDate=TDT.RD_ReceiptDate,RD_ReceiptAmount=TDT.RD_ReceiptAmount,RD_RefId=TDT.RD_RefId,RD_Status=TDT.RD_Status FROM @TBL_98F402C4A592451FB29E2F28BE67530B TDT
							JOIN [98F402C4-A592-451F-B29E-2F28BE67530B] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,RD_RefNo,RD_ReceiptDate,RD_ReceiptAmount,RD_RefId,RD_Status";

                            colListwithEDT=@"InstanceId#0,ProcessActivityMapId#0,GridId#0,RowId#0,Sequence#0,RD_RefNo#9,RD_ReceiptDate#8,RD_ReceiptAmount#3,RD_RefId#9,RD_Status#9";

                            tempInsertQuery=@"INSERT INTO @TBL_98F402C4A592451FB29E2F28BE67530B(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,RD_RefNo,RD_ReceiptDate,RD_ReceiptAmount,RD_RefId,RD_Status)VALUES({0});";

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
public class ISpace0325353E7E134762AFC988434C58F52C : VirtualForm
{
IISpace iSpace = new ISpace();
AcDataISpace0325353E7E134762AFC988434C58F52C acdataIspace0325353E7E134762AFC988434C58F52C=new AcDataISpace0325353E7E134762AFC988434C58F52C();
private void SubscribeFormEvents_root(ref Dictionary<string, ServiceElementData> ISpace)
{
try
{
base.WriteDebugInfo(@"Root-OnAfterFormLoad");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC [GetTempAdvanceExplorerDetails] 1,'#MF_ProjectRefNo','#MF_Status','@@gv_UserId'");

var querySourceB95305A444724471905E13C95BEAB7CE =GetQueryExpressionDataSource("B95305A4-4472-4471-905E-13C95BEAB7CE");
Dictionary<short,object> resultB95305A444724471905E13C95BEAB7CE=iSpace.ExecuteQuery(querySourceB95305A444724471905E13C95BEAB7CE,@"EXEC [GetTempAdvanceExplorerDetails] 1,'" + ISpace["MF_ProjectRefNo"].Value + @"','" + ISpace["MF_Status"].Value + @"','" + ISpace["gv_userid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceB95305A444724471905E13C95BEAB7CE =GetQueryExpressionDataSource(""B95305A4-4472-4471-905E-13C95BEAB7CE"");Dictionary<short,object> resultB95305A444724471905E13C95BEAB7CE=iSpace.ExecuteQuery(querySourceB95305A444724471905E13C95BEAB7CE,@""EXEC [GetTempAdvanceExplorerDetails] 1,'"" + ISpace[""MF_ProjectRefNo""].Value + @""','"" + ISpace[""MF_Status""].Value + @""','"" + ISpace[""gv_userid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultB95305A444724471905E13C95BEAB7CE!=null) && (resultB95305A444724471905E13C95BEAB7CE.Count!=0))
{
if(resultB95305A444724471905E13C95BEAB7CE.ContainsKey(0))
ISpace["MF_PendingCount"].Value = resultB95305A444724471905E13C95BEAB7CE[0];
if(resultB95305A444724471905E13C95BEAB7CE.ContainsKey(1))
ISpace["MF_CompletedCount"].Value = resultB95305A444724471905E13C95BEAB7CE[1];
}
else{
ISpace["MF_PendingCount"].Value = null;ISpace["MF_CompletedCount"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySource2DCE3283256D4120938065242E6EC71E =GetQueryExpressionDataSource("2DCE3283-256D-4120-9380-65242E6EC71E");

DataTable result2DCE3283256D4120938065242E6EC71E=iSpace.SetGridDataSource(querySource2DCE3283256D4120938065242E6EC71E, _objectFactory.GetGridRPP("MG_ReceiptDetails"),@"EXEC [GetTempAdvanceExplorerDetails] 2,'" + ISpace["MF_ProjectRefNo"].Value + @"','" + ISpace["MF_Status"].Value + @"','" + ISpace["gv_userid"].Value + @"'");


base.WriteDebugInfo(@"var querySource2DCE3283256D4120938065242E6EC71E =GetQueryExpressionDataSource(""2DCE3283-256D-4120-9380-65242E6EC71E"");DataTable result2DCE3283256D4120938065242E6EC71E=iSpace.SetGridDataSource(querySource2DCE3283256D4120938065242E6EC71E, _objectFactory.GetGridRPP(""MG_ReceiptDetails""),@""EXEC [GetTempAdvanceExplorerDetails] 2,'"" + ISpace[""MF_ProjectRefNo""].Value + @""','"" + ISpace[""MF_Status""].Value + @""','"" + ISpace[""gv_userid""].Value + @""'"");");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result72B5DE26E0BD4445B660905F5AA1FD90=acdataIspace0325353E7E134762AFC988434C58F52C.GetQueryExpressionBindings("72B5DE26-E0BD-4445-B660-905F5AA1FD90");
iSpace.SetGridData(result2DCE3283256D4120938065242E6EC71E,result72B5DE26E0BD4445B660905F5AA1FD90,"MG_ReceiptDetails",ref ISpace);
if (_elementBase != null)  iSpace.SetLoopExpressionData("MG_ReceiptDetails","98F402C4-A592-451F-B29E-2F28BE67530B",_objectFactory.GetGridRPP("MG_ReceiptDetails"),_elementBase.GetGridLoopQuery("98F402C4-A592-451F-B29E-2F28BE67530B","MG_ReceiptDetails",true,ref ISpace), ref ISpace);

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
base.WriteDebugInfo(@"EXEC [GetTempAdvanceExplorerDetails] 1,'#MF_ProjectRefNo','#MF_Status','@@gv_UserId'");

var querySourceB95305A444724471905E13C95BEAB7CE =GetQueryExpressionDataSource("B95305A4-4472-4471-905E-13C95BEAB7CE");
Dictionary<short,object> resultB95305A444724471905E13C95BEAB7CE=iSpace.ExecuteQuery(querySourceB95305A444724471905E13C95BEAB7CE,@"EXEC [GetTempAdvanceExplorerDetails] 1,'" + ISpace["MF_ProjectRefNo"].Value + @"','" + ISpace["MF_Status"].Value + @"','" + ISpace["gv_userid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceB95305A444724471905E13C95BEAB7CE =GetQueryExpressionDataSource(""B95305A4-4472-4471-905E-13C95BEAB7CE"");Dictionary<short,object> resultB95305A444724471905E13C95BEAB7CE=iSpace.ExecuteQuery(querySourceB95305A444724471905E13C95BEAB7CE,@""EXEC [GetTempAdvanceExplorerDetails] 1,'"" + ISpace[""MF_ProjectRefNo""].Value + @""','"" + ISpace[""MF_Status""].Value + @""','"" + ISpace[""gv_userid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultB95305A444724471905E13C95BEAB7CE!=null) && (resultB95305A444724471905E13C95BEAB7CE.Count!=0))
{
if(resultB95305A444724471905E13C95BEAB7CE.ContainsKey(0))
ISpace["MF_PendingCount"].Value = resultB95305A444724471905E13C95BEAB7CE[0];
if(resultB95305A444724471905E13C95BEAB7CE.ContainsKey(1))
ISpace["MF_CompletedCount"].Value = resultB95305A444724471905E13C95BEAB7CE[1];
}
else{
ISpace["MF_PendingCount"].Value = null;ISpace["MF_CompletedCount"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySource2DCE3283256D4120938065242E6EC71E =GetQueryExpressionDataSource("2DCE3283-256D-4120-9380-65242E6EC71E");

DataTable result2DCE3283256D4120938065242E6EC71E=iSpace.SetGridDataSource(querySource2DCE3283256D4120938065242E6EC71E, _objectFactory.GetGridRPP("MG_ReceiptDetails"),@"EXEC [GetTempAdvanceExplorerDetails] 2,'" + ISpace["MF_ProjectRefNo"].Value + @"','" + ISpace["MF_Status"].Value + @"','" + ISpace["gv_userid"].Value + @"'");


base.WriteDebugInfo(@"var querySource2DCE3283256D4120938065242E6EC71E =GetQueryExpressionDataSource(""2DCE3283-256D-4120-9380-65242E6EC71E"");DataTable result2DCE3283256D4120938065242E6EC71E=iSpace.SetGridDataSource(querySource2DCE3283256D4120938065242E6EC71E, _objectFactory.GetGridRPP(""MG_ReceiptDetails""),@""EXEC [GetTempAdvanceExplorerDetails] 2,'"" + ISpace[""MF_ProjectRefNo""].Value + @""','"" + ISpace[""MF_Status""].Value + @""','"" + ISpace[""gv_userid""].Value + @""'"");");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result72B5DE26E0BD4445B660905F5AA1FD90=acdataIspace0325353E7E134762AFC988434C58F52C.GetQueryExpressionBindings("72B5DE26-E0BD-4445-B660-905F5AA1FD90");
iSpace.SetGridData(result2DCE3283256D4120938065242E6EC71E,result72B5DE26E0BD4445B660905F5AA1FD90,"MG_ReceiptDetails",ref ISpace);
if (_elementBase != null)  iSpace.SetLoopExpressionData("MG_ReceiptDetails","98F402C4-A592-451F-B29E-2F28BE67530B",_objectFactory.GetGridRPP("MG_ReceiptDetails"),_elementBase.GetGridLoopQuery("98F402C4-A592-451F-B29E-2F28BE67530B","MG_ReceiptDetails",true,ref ISpace), ref ISpace);

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
ISpace["RedirectUrl"].Value="?PkActMId=a07dd434-8e7d-1a40-f53e-b3d229e4f878&frmElementId=744F780C-12D2-41D3-9084-6E903A527934&PkPrMId=85014d12-a85b-4330-8d7f-29776cbda319&formVersionId=228701A8-2089-4481-B018-4BE30083D0D9&Ver=0.0000&FormInstanceId="+ISpace["RD_RefId"].Value;
base.WriteDebugInfo(@"
ISpace[""RedirectUrl""].RedirectType=""R"";
ISpace[""RedirectUrl""].Value=""?PkActMId=a07dd434-8e7d-1a40-f53e-b3d229e4f878&frmElementId=744F780C-12D2-41D3-9084-6E903A527934&PkPrMId=85014d12-a85b-4330-8d7f-29776cbda319&formVersionId=228701A8-2089-4481-B018-4BE30083D0D9&Ver=0.0000&FormInstanceId=""+ISpace[""RD_RefId""].Value;");
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
base.WriteDebugInfo(@"EXEC [GetTempAdvanceExplorerDetails] 1,'#MF_ProjectRefNo','#MF_Status','@@gv_UserId'");

var querySourceB95305A444724471905E13C95BEAB7CE =GetQueryExpressionDataSource("B95305A4-4472-4471-905E-13C95BEAB7CE");
Dictionary<short,object> resultB95305A444724471905E13C95BEAB7CE=iSpace.ExecuteQuery(querySourceB95305A444724471905E13C95BEAB7CE,@"EXEC [GetTempAdvanceExplorerDetails] 1,'" + ISpace["MF_ProjectRefNo"].Value + @"','" + ISpace["MF_Status"].Value + @"','" + ISpace["gv_userid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceB95305A444724471905E13C95BEAB7CE =GetQueryExpressionDataSource(""B95305A4-4472-4471-905E-13C95BEAB7CE"");Dictionary<short,object> resultB95305A444724471905E13C95BEAB7CE=iSpace.ExecuteQuery(querySourceB95305A444724471905E13C95BEAB7CE,@""EXEC [GetTempAdvanceExplorerDetails] 1,'"" + ISpace[""MF_ProjectRefNo""].Value + @""','"" + ISpace[""MF_Status""].Value + @""','"" + ISpace[""gv_userid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultB95305A444724471905E13C95BEAB7CE!=null) && (resultB95305A444724471905E13C95BEAB7CE.Count!=0))
{
if(resultB95305A444724471905E13C95BEAB7CE.ContainsKey(0))
ISpace["MF_PendingCount"].Value = resultB95305A444724471905E13C95BEAB7CE[0];
if(resultB95305A444724471905E13C95BEAB7CE.ContainsKey(1))
ISpace["MF_CompletedCount"].Value = resultB95305A444724471905E13C95BEAB7CE[1];
}
else{
ISpace["MF_PendingCount"].Value = null;ISpace["MF_CompletedCount"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySource2DCE3283256D4120938065242E6EC71E =GetQueryExpressionDataSource("2DCE3283-256D-4120-9380-65242E6EC71E");

DataTable result2DCE3283256D4120938065242E6EC71E=iSpace.SetGridDataSource(querySource2DCE3283256D4120938065242E6EC71E, _objectFactory.GetGridRPP("MG_ReceiptDetails"),@"EXEC [GetTempAdvanceExplorerDetails] 2,'" + ISpace["MF_ProjectRefNo"].Value + @"','" + ISpace["MF_Status"].Value + @"','" + ISpace["gv_userid"].Value + @"'");


base.WriteDebugInfo(@"var querySource2DCE3283256D4120938065242E6EC71E =GetQueryExpressionDataSource(""2DCE3283-256D-4120-9380-65242E6EC71E"");DataTable result2DCE3283256D4120938065242E6EC71E=iSpace.SetGridDataSource(querySource2DCE3283256D4120938065242E6EC71E, _objectFactory.GetGridRPP(""MG_ReceiptDetails""),@""EXEC [GetTempAdvanceExplorerDetails] 2,'"" + ISpace[""MF_ProjectRefNo""].Value + @""','"" + ISpace[""MF_Status""].Value + @""','"" + ISpace[""gv_userid""].Value + @""'"");");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result72B5DE26E0BD4445B660905F5AA1FD90=acdataIspace0325353E7E134762AFC988434C58F52C.GetQueryExpressionBindings("72B5DE26-E0BD-4445-B660-905F5AA1FD90");
iSpace.SetGridData(result2DCE3283256D4120938065242E6EC71E,result72B5DE26E0BD4445B660905F5AA1FD90,"MG_ReceiptDetails",ref ISpace);
if (_elementBase != null)  iSpace.SetLoopExpressionData("MG_ReceiptDetails","98F402C4-A592-451F-B29E-2F28BE67530B",_objectFactory.GetGridRPP("MG_ReceiptDetails"),_elementBase.GetGridLoopQuery("98F402C4-A592-451F-B29E-2F28BE67530B","MG_ReceiptDetails",true,ref ISpace), ref ISpace);

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
ISpace["RedirectUrl"].Value="Temp Advance Explorer?PkActMId=A8D5026A-49FD-44A0-BEBE-AA595B40C453&frmElementId=744F780C-12D2-41D3-9084-6E903A527934&PkPrMId=85014d12-a85b-4330-8d7f-29776cbda319&formVersionId=228701A8-2089-4481-B018-4BE30083D0D9&Ver=0.0000";
base.WriteDebugInfo(@"
ISpace[""RedirectUrl""].RedirectType=""R"";
ISpace[""RedirectUrl""].Value=""Temp Advance Explorer?PkActMId=A8D5026A-49FD-44A0-BEBE-AA595B40C453&frmElementId=744F780C-12D2-41D3-9084-6E903A527934&PkPrMId=85014d12-a85b-4330-8d7f-29776cbda319&formVersionId=228701A8-2089-4481-B018-4BE30083D0D9&Ver=0.0000"";");
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


	public partial class AcDataISpace0325353E7E134762AFC988434C58F52C  : ExtensionActivityBase
	{		
		
		
		private Dictionary<string,  List<Triplet<string, short, short?>>> queryExpressionBindings = 
											new Dictionary<string,  List<Triplet<string, short, short?>>>
		{
							{"72B5DE26-E0BD-4445-B660-905F5AA1FD90", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("RD_RefId",0,
														   -1),
								   new Triplet<string, short, short?>("RD_RefNo",1,
														   -1),
								   new Triplet<string, short, short?>("RD_ReceiptDate",2,
														   -1),
								   new Triplet<string, short, short?>("RD_Status",4,
														   -1),
								   new Triplet<string, short, short?>("RD_ReceiptAmount",3,
														   -1),
								}
			},
					};	

	

		private Dictionary<string,string> formVersionList =new Dictionary<string,string> 
		{
							{"C935B56C-79C4-4F7E-89BD-5FADD98FC65E", "Medium"},
					};	

		
		private Dictionary<string,string> formVersionLayoutList =new Dictionary<string,string> 
		{
							{"109E84C3-B455-4EB7-A44B-F49989E66B57", ""},
							{"A4D9DD1E-F928-4DA0-BDA0-BAD85439F96B", ""},
							{"C935B56C-79C4-4F7E-89BD-5FADD98FC65E", ""},
							{"846A6752-68BA-44FB-A32A-AE1EEC523D34", ""},
							{"41650C3B-708A-435F-A694-76FABA024262", ""},
							{"0CBDE0DC-5816-4DCF-8C0E-56196B4B6177", ""},
							{"AFAAEA58-0500-402E-9877-BD84F9C4D9D8", ""},
							{"FF394E82-BCEF-4E21-B774-4C4AC3D3C1E1", ""},
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
		


