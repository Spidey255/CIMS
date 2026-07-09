  







namespace CPS.Proof.DFSExtension
{
	using System;
    using System.Collections.Generic;     
	using System.Linq;
	
	
	public partial class WorkflowProcessMetadata : ExtensionProcessBase
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
            get { return "625B1F37-DEE5-40D3-9361-5E014866245C"; }
        }

        public override string ProcessName
        {
            get { return "Workflow"; }
        }

		public override string ProcessDescription
        {
            get { return "Workflow"; }
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
            get {return "625B1F37-DEE5-40D3-9361-5E014866245C";}
        }

		public override byte ProcessInstanceMode
        {
            get {return 3;}
        }		

		public override string MasterFormId
        {
            get {  
				   return "D4D4D705-F820-486F-A99B-8E9EAAACF080";	}
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
	

	public partial class WorkflowObjectFactory  : ExtObjectFactoryBase
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
        //    return (IExtBaseMetaData)new WorkflowProcessMetadata();
        //}
	


		private List<Triplet<string, string, string>> queryExpressionData = new List<Triplet<string, string, string>>
		{
	  			
			     new Triplet<string, string, string>("6de18807-eac7-2fe0-13b2-6280fe1e5657","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"24F5D845-D560-4FC1-B284-00FB19DFB96F"),
			
						
			     new Triplet<string, string, string>("b2cc58cd-f143-4865-d06a-b3f668910216","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"24F5D845-D560-4FC1-B284-00FB19DFB96F"),
			
						
			     new Triplet<string, string, string>("6de18807-eac7-2fe0-13b2-6280fe1e5657","Load Comments",
												     @"51e1dee3-de7b-e2ef-823a-43252ad068f0"),
			
			
			
		};

		
		private List<Triplet<string, string, string>> ComboDataSource = new List<Triplet<string, string, string>>
		{

		
	  			
			     new Triplet<string, string, string>("WMF_MoveTo","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMAX4svK5cDYCPw2sEhYNSLVUgHvT8EwteQ6Cu6POiqivUqpEh16s8+yjMECvtOIho/Hsxg7bNByVU=",
												     @"EXEC GetNextStep '@WMF_InstanceId','@WMF_FlowType'"),
			
						
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
		
	  			
			     new Tuple<string, int>("WMG_CommentsHistory",100),
			
						
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
											case "728FC96D-3626-4EDB-A4B6-3BD68D14069E":
							virtualInstance=new ISpace728FC96D36264EDBA4B63BD68D14069E();
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
	

	public partial class WorkflowDataElementFactory  : ExtElementBase
    {

     /// <summary>
        /// A <see cref="log4net.ILog"/> that contains the logger instance for 
        /// logging
        /// </summary>
        private readonly ILog _sysLog;

        public WorkflowDataElementFactory()
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

               
                
                                      case "D4D4D705-F820-486F-A99B-8E9EAAACF080":
                    {
                     
                                     fInsertQuery=@"IF NOT EXISTS(SELECT 1 FROM [D4D4D705-F820-486F-A99B-8E9EAAACF080] WHERE InstanceId='{0}') BEGIN INSERT INTO [D4D4D705-F820-486F-A99B-8E9EAAACF080](ProcessActivityMapId,FormId,WMF_IsInFlow,Subject,ExecutionStatus,ExecutionMessage,SetDestinationTo,SLATime,WMF_MoveTo,Comments,FlowType,WMF_InstanceId,InstanceId)
							VALUES( {3}) END ELSE BEGIN UPDATE [D4D4D705-F820-486F-A99B-8E9EAAACF080]SET {4}WHERE InstanceId='{0}'END ";

                                     colList=@"ProcessActivityMapId,FormId,WMF_IsInFlow,Subject,ExecutionStatus,ExecutionMessage,SetDestinationTo,SLATime,WMF_MoveTo,Comments,FlowType,WMF_InstanceId,InstanceId";
                                    
                     
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

                
                 
                                      case "51e1dee3-de7b-e2ef-823a-43252ad068f0":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_51e1dee3de7be2ef823a43252ad068f0 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [WMC_StepFrom] VARCHAR(MAX)	, [WMC_StepTo] VARCHAR(MAX)	, [WMC_Comments] VARCHAR(MAX)	, [WMC_User] VARCHAR(MAX)	, [WMC_DateofComments] DATETIME){0}INSERT INTO [51e1dee3-de7b-e2ef-823a-43252ad068f0](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,WMC_StepFrom,WMC_StepTo,WMC_Comments,WMC_User,WMC_DateofComments)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.WMC_StepFrom,TDT.WMC_StepTo,TDT.WMC_Comments,TDT.WMC_User,TDT.WMC_DateofComments FROM @TBL_51e1dee3de7be2ef823a43252ad068f0 TDT
							LEFT JOIN [51e1dee3-de7b-e2ef-823a-43252ad068f0] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,WMC_StepFrom=TDT.WMC_StepFrom,WMC_StepTo=TDT.WMC_StepTo,WMC_Comments=TDT.WMC_Comments,WMC_User=TDT.WMC_User,WMC_DateofComments=TDT.WMC_DateofComments FROM @TBL_51e1dee3de7be2ef823a43252ad068f0 TDT
							JOIN [51e1dee3-de7b-e2ef-823a-43252ad068f0] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,WMC_StepFrom,WMC_StepTo,WMC_Comments,WMC_User,WMC_DateofComments";

                                     tempInsertQuery=@"INSERT INTO @TBL_51e1dee3de7be2ef823a43252ad068f0(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,WMC_StepFrom,WMC_StepTo,WMC_Comments,WMC_User,WMC_DateofComments)VALUES({0});";
                                     

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
                     

                                         case "51e1dee3-de7b-e2ef-823a-43252ad068f0":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_51e1dee3de7be2ef823a43252ad068f0 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [WMC_StepFrom] VARCHAR(MAX)	, [WMC_StepTo] VARCHAR(MAX)	, [WMC_Comments] VARCHAR(MAX)	, [WMC_User] VARCHAR(MAX)	, [WMC_DateofComments] DATETIME){0}INSERT INTO [51e1dee3-de7b-e2ef-823a-43252ad068f0](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,WMC_StepFrom,WMC_StepTo,WMC_Comments,WMC_User,WMC_DateofComments)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.WMC_StepFrom,TDT.WMC_StepTo,TDT.WMC_Comments,TDT.WMC_User,TDT.WMC_DateofComments FROM @TBL_51e1dee3de7be2ef823a43252ad068f0 TDT
							LEFT JOIN [51e1dee3-de7b-e2ef-823a-43252ad068f0] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,WMC_StepFrom=TDT.WMC_StepFrom,WMC_StepTo=TDT.WMC_StepTo,WMC_Comments=TDT.WMC_Comments,WMC_User=TDT.WMC_User,WMC_DateofComments=TDT.WMC_DateofComments FROM @TBL_51e1dee3de7be2ef823a43252ad068f0 TDT
							JOIN [51e1dee3-de7b-e2ef-823a-43252ad068f0] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,WMC_StepFrom,WMC_StepTo,WMC_Comments,WMC_User,WMC_DateofComments";

                            tempInsertQuery=@"INSERT INTO @TBL_51e1dee3de7be2ef823a43252ad068f0(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,WMC_StepFrom,WMC_StepTo,WMC_Comments,WMC_User,WMC_DateofComments)VALUES({0});";

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
public class ISpace728FC96D36264EDBA4B63BD68D14069E : VirtualForm
{
IISpace iSpace = new ISpace();
AcDataISpace728FC96D36264EDBA4B63BD68D14069E acdataIspace728FC96D36264EDBA4B63BD68D14069E=new AcDataISpace728FC96D36264EDBA4B63BD68D14069E();
private void SubscribeFormEvents_root(ref Dictionary<string, ServiceElementData> ISpace)
{
try
{
base.WriteDebugInfo(@"Root-OnAfterFormLoad");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["WMF_InstanceId"].Value=ISpace["gv_instanceid"].Value;
base.WriteDebugInfo(@"ISpace[""WMF_InstanceId""].Value=ISpace[""gv_instanceid""].Value;");
if(ISpace["FormVersionId"].Value=="D2CEABD5-3181-469E-AECE-B2E0F2399816")
{
ISpace["UI_ApprovalHideRow"].Visible="false";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""D2CEABD5-3181-469E-AECE-B2E0F2399816"")
{
ISpace[""UI_ApprovalHideRow""].Visible=""false"";
}");
}
if(ISpace["FlowType"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""FlowType""].Value=="""")");
ISpace["WMF_IsInFlow"].Value=0;
base.WriteDebugInfo(@"ISpace[""WMF_IsInFlow""].Value=0;");
base.WriteDebugInfo(@"EXEC [GetInstanceInFlow] '@@gv_InstanceId'");

var querySourceb2cc58cdf1434865d06ab3f668910216 =GetQueryExpressionDataSource("b2cc58cd-f143-4865-d06a-b3f668910216");
Dictionary<short,object> resultb2cc58cdf1434865d06ab3f668910216=iSpace.ExecuteQuery(querySourceb2cc58cdf1434865d06ab3f668910216,@"EXEC [GetInstanceInFlow] '" + ISpace["gv_instanceid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceb2cc58cdf1434865d06ab3f668910216 =GetQueryExpressionDataSource(""b2cc58cd-f143-4865-d06a-b3f668910216"");Dictionary<short,object> resultb2cc58cdf1434865d06ab3f668910216=iSpace.ExecuteQuery(querySourceb2cc58cdf1434865d06ab3f668910216,@""EXEC [GetInstanceInFlow] '"" + ISpace[""gv_instanceid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultb2cc58cdf1434865d06ab3f668910216!=null) && (resultb2cc58cdf1434865d06ab3f668910216.Count!=0))
{
if(resultb2cc58cdf1434865d06ab3f668910216.ContainsKey(0))
ISpace["WMF_IsInFlow"].Value = resultb2cc58cdf1434865d06ab3f668910216[0];
}
else{
ISpace["WMF_IsInFlow"].Value = null;
}
if(ISpace["WMF_IsInFlow"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""WMF_IsInFlow""].Value==1)");
ISpace["WMF_FlowType"].Value="APPROVE";
base.WriteDebugInfo(@"ISpace[""WMF_FlowType""].Value=""APPROVE"";");
ISpace["WMF_MoveTo"].Visible="true";ISpace["WMF_History"].Visible="true";
base.WriteDebugInfo(@"ISpace[""WMF_MoveTo""].Visible=""true"";ISpace[""WMF_History""].Visible=""true"";");
}
if(ISpace["WMF_IsInFlow"].Value!=1)
{
base.WriteDebugInfo(@"if(ISpace[""WMF_IsInFlow""].Value!=1)");
ISpace["WMF_MoveTo"].Visible="false";ISpace["WMF_History"].Visible="false";
base.WriteDebugInfo(@"ISpace[""WMF_MoveTo""].Visible=""false"";ISpace[""WMF_History""].Visible=""false"";");
}
}
ISpace["WMF_MoveTo"].Man=true;
base.WriteDebugInfo(@"ISpace[""WMF_MoveTo""].Man=true;");

var querySource6de18807eac72fe013b26280fe1e5657 =GetQueryExpressionDataSource("6de18807-eac7-2fe0-13b2-6280fe1e5657");

DataTable result6de18807eac72fe013b26280fe1e5657=iSpace.SetGridDataSource(querySource6de18807eac72fe013b26280fe1e5657, _objectFactory.GetGridRPP("WMG_CommentsHistory"),@"EXEC [GetInstanceFlowDetais] '" + ISpace["gv_instanceid"].Value + @"'");

iSpace.InsertGridBindDetails("WMG_CommentsHistory","11",querySource6de18807eac72fe013b26280fe1e5657,"EXEC [GetInstanceFlowDetais] '" + ISpace["gv_instanceid"].Value + @"'",_objectFactory.GetGridRPP("WMG_CommentsHistory"));

base.WriteDebugInfo(@"var querySource6de18807eac72fe013b26280fe1e5657 =GetQueryExpressionDataSource(""6de18807-eac7-2fe0-13b2-6280fe1e5657"");DataTable result6de18807eac72fe013b26280fe1e5657=iSpace.SetGridDataSource(querySource6de18807eac72fe013b26280fe1e5657, _objectFactory.GetGridRPP(""WMG_CommentsHistory""),@""EXEC [GetInstanceFlowDetais] '"" + ISpace[""gv_instanceid""].Value + @""'"");iSpace.InsertGridBindDetails(""WMG_CommentsHistory"",""11"",querySource6de18807eac72fe013b26280fe1e5657,""EXEC [GetInstanceFlowDetais] '"" + ISpace[""gv_instanceid""].Value + @""'"",_objectFactory.GetGridRPP(""WMG_CommentsHistory""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result18ed625df6e21cabb92353bbe89589f8=acdataIspace728FC96D36264EDBA4B63BD68D14069E.GetQueryExpressionBindings("18ed625d-f6e2-1cab-b923-53bbe89589f8");
iSpace.SetGridData(result6de18807eac72fe013b26280fe1e5657,result18ed625df6e21cabb92353bbe89589f8,"WMG_CommentsHistory",ref ISpace);
iSpace.UpdateGridBindDetails("WMG_CommentsHistory",result18ed625df6e21cabb92353bbe89589f8);
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_wmf_moveto (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"WMF_MoveTo-OnChange");
if(ISpace["WMF_MoveTo"].Value=="APPROVE")
{
base.WriteDebugInfo(@"if(ISpace[""WMF_MoveTo""].Value==""APPROVE"")");
ISpace["FlowType"].Value="APPROVE";
base.WriteDebugInfo(@"ISpace[""FlowType""].Value=""APPROVE"";");
ISpace["Comments"].Man=false;
base.WriteDebugInfo(@"ISpace[""Comments""].Man=false;");
}
if(ISpace["WMF_MoveTo"].Value=="RETURN")
{
base.WriteDebugInfo(@"if(ISpace[""WMF_MoveTo""].Value==""RETURN"")");
ISpace["FlowType"].Value="RETURN";
base.WriteDebugInfo(@"ISpace[""FlowType""].Value=""RETURN"";");
ISpace["Comments"].Man=true;
base.WriteDebugInfo(@"ISpace[""Comments""].Man=true;");
}
if(ISpace["WMF_MoveTo"].Value=="REJECT")
{
base.WriteDebugInfo(@"if(ISpace[""WMF_MoveTo""].Value==""REJECT"")");
ISpace["FlowType"].Value="REJECT";
base.WriteDebugInfo(@"ISpace[""FlowType""].Value=""REJECT"";");
ISpace["Comments"].Man=true;
base.WriteDebugInfo(@"ISpace[""Comments""].Man=true;");
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
		if(elementName.ToLower().Equals("wmf_moveto"))
    {
    			SubscribeElementEvents_wmf_moveto(ref dfsParam);
    }
}
	if(methodName.ToLower().Equals("onclick"))
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


	public partial class AcDataISpace728FC96D36264EDBA4B63BD68D14069E  : ExtensionActivityBase
	{		
		
		
		private Dictionary<string,  List<Triplet<string, short, short?>>> queryExpressionBindings = 
											new Dictionary<string,  List<Triplet<string, short, short?>>>
		{
							{"18ed625d-f6e2-1cab-b923-53bbe89589f8", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("WMC_StepTo",2,
														   -1),
								   new Triplet<string, short, short?>("WMC_StepFrom",1,
														   -1),
								   new Triplet<string, short, short?>("WMC_User",3,
														   -1),
								   new Triplet<string, short, short?>("WMC_DateofComments",4,
														   -1),
								   new Triplet<string, short, short?>("WMC_Comments",5,
														   -1),
								}
			},
					};	

	

		private Dictionary<string,string> formVersionList =new Dictionary<string,string> 
		{
							{"D2CEABD5-3181-469E-AECE-B2E0F2399816", "Medium"},
					};	

		
		private Dictionary<string,string> formVersionLayoutList =new Dictionary<string,string> 
		{
							{"3026E65B-71E1-4B5F-8FF5-C458F2870DE8", ""},
							{"223E1A0A-6E22-4DD1-BBE9-619E20FB113C", ""},
							{"D2CEABD5-3181-469E-AECE-B2E0F2399816", ""},
							{"7E61638B-AF87-4340-A657-716362702CD3", ""},
							{"872272FC-4E2F-4813-9685-D0E96ACB3E81", ""},
							{"A879F208-A727-4564-8973-B6DBAE66075A", ""},
							{"3F182157-7E52-415A-8FCE-48F3CC1FDCE2", ""},
							{"0CE3AE52-5EA8-4EF0-8A94-C024B5B5F26E", ""},
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
		


