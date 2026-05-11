  







namespace CPS.Proof.DFSExtension
{
	using System;
    using System.Collections.Generic;     
	using System.Linq;
	
	
	public partial class FundConfigurationsProcessMetadata : ExtensionProcessBase
	{		

        public override long PackageId
        {
            get { return 30312; }
        }

        public override string PackageName
        {
            get { return "PRJ20251020000000025-Projects"; }
        }

		public override string PackageDescription
        {
            get { return "Projects"; }
        }

        public override string ProcessId
        {
            get { return "84777088-B51C-45AA-8BBA-D24FBDEF26E9"; }
        }

        public override string ProcessName
        {
            get { return "FundConfigurations"; }
        }

		public override string ProcessDescription
        {
            get { return "Fund Configurations"; }
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
            get {return "84777088-B51C-45AA-8BBA-D24FBDEF26E9";}
        }

		public override byte ProcessInstanceMode
        {
            get {return 3;}
        }		

		public override string MasterFormId
        {
            get {  
				   return "781F63B4-048D-4578-AF08-83C4E8FC0483";	}
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
	

	public partial class FundConfigurationsObjectFactory  : ExtObjectFactoryBase
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
        //    return (IExtBaseMetaData)new FundConfigurationsProcessMetadata();
        //}
	


		private List<Triplet<string, string, string>> queryExpressionData = new List<Triplet<string, string, string>>
		{
	  			
			     new Triplet<string, string, string>("0845D724-E0EA-4F3C-A769-47186EED23FB","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"9ADED37B-CD11-426B-AF16-DEAC75685EF5"),
			
						
			     new Triplet<string, string, string>("DAC9F044-5935-4FA0-923E-7A3EAB9A2F96","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"9ADED37B-CD11-426B-AF16-DEAC75685EF5"),
			
						
			     new Triplet<string, string, string>("291629D8-6EDC-4ED2-8796-8C3E5F8981AB","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"9ADED37B-CD11-426B-AF16-DEAC75685EF5"),
			
						
			     new Triplet<string, string, string>("AA271A94-D1BE-4932-BBD4-D7C3E0DEBE2E","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"9ADED37B-CD11-426B-AF16-DEAC75685EF5"),
			
						
			     new Triplet<string, string, string>("14EA6443-0FBE-4A68-8533-5FD1536A28E7","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"9ADED37B-CD11-426B-AF16-DEAC75685EF5"),
			
						
			     new Triplet<string, string, string>("0845D724-E0EA-4F3C-A769-47186EED23FB","Load Fund types",
												     @"04FCD160-1EC6-471F-97B0-1C6738875C87"),
			
			
			
		};

		
		private List<Triplet<string, string, string>> ComboDataSource = new List<Triplet<string, string, string>>
		{

		
	  			
			     new Triplet<string, string, string>("MF_PackageProcessMapId","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw1z/z9sf1712IST2TisZRbDL01cRO080NYHWsKvkYJS77cc4eTVUER6yxhHgktDkfvWfwBNgoOezuhR3VTahYodgYs1XIsswI0A==",
												     @"EXEC GetFundDistributionCombos 2"),
			
						
			     new Triplet<string, string, string>("MG_BudgetHeadId","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw1z/z9sf1712IST2TisZRbDL01cRO080NYHWsKvkYJS77cc4eTVUER6yxhHgktDkfvWfwBNgoOezuhR3VTahYodgYs1XIsswI0A==",
												     @"EXEC GetFundDistributionCombos 3"),
			
						
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
		
	  			
			     new Tuple<string, int>("MF_FundType",25),
			
						
			     new Tuple<string, int>("MF_DistrubitionDetails",25),
			
						
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
											case "4E51124D-BF83-46EC-BA9A-B746693F716F":
							virtualInstance=new ISpace4E51124DBF8346ECBA9AB746693F716F();
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
	

	public partial class FundConfigurationsDataElementFactory  : ExtElementBase
    {

     /// <summary>
        /// A <see cref="log4net.ILog"/> that contains the logger instance for 
        /// logging
        /// </summary>
        private readonly ILog _sysLog;

        public FundConfigurationsDataElementFactory()
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

               
                
                                      case "781F63B4-048D-4578-AF08-83C4E8FC0483":
                    {
                     
                                     fInsertQuery=@"IF NOT EXISTS(SELECT 1 FROM [781F63B4-048D-4578-AF08-83C4E8FC0483] WHERE InstanceId='{0}' AND
							ProcessActivityMapId='{1}' AND FormId='{2}') BEGIN INSERT INTO [781F63B4-048D-4578-AF08-83C4E8FC0483](InstanceId,ProcessActivityMapId,FormId,ExecutionStatus,MF_DistributionId,ExecutionMessage,SetDestinationTo,MF_Description,Subject,RedirectUrl,MF_Fundname,SLATime,MF_OtherDistributionId,MF_FundTypeId,MF_MaxPercentageUsage,MF_MaxAmount,MF_SameFundingAgency,MF_MultipleProjectsAllowed,MF_PackageProcessMapId)
							VALUES( {3}) END ELSE BEGIN UPDATE [781F63B4-048D-4578-AF08-83C4E8FC0483]SET {4}WHERE InstanceId='{0}'AND ProcessActivityMapId='{1}'AND FormId='{2}'END ";

                                     colList=@"InstanceId,ProcessActivityMapId,FormId,ExecutionStatus,MF_DistributionId,ExecutionMessage,SetDestinationTo,MF_Description,Subject,RedirectUrl,MF_Fundname,SLATime,MF_OtherDistributionId,MF_FundTypeId,MF_MaxPercentageUsage,MF_MaxAmount,MF_SameFundingAgency,MF_MultipleProjectsAllowed,MF_PackageProcessMapId";
                                    
                     
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

                
                 
                                      case "04FCD160-1EC6-471F-97B0-1C6738875C87":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_04FCD1601EC6471F97B01C6738875C87 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT){0}INSERT INTO [04FCD160-1EC6-471F-97B0-1C6738875C87](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence FROM @TBL_04FCD1601EC6471F97B01C6738875C87 TDT
							LEFT JOIN [04FCD160-1EC6-471F-97B0-1C6738875C87] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence";

                                     tempInsertQuery=@"INSERT INTO @TBL_04FCD1601EC6471F97B01C6738875C87(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)VALUES({0});";
                                     

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
                     
                                    case "DD0086FF-AEF5-45C9-A3B5-6CFE3A7C352F":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_DD0086FFAEF545C9A3B56CFE3A7C352F AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT){0}INSERT INTO [DD0086FF-AEF5-45C9-A3B5-6CFE3A7C352F](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence FROM @TBL_DD0086FFAEF545C9A3B56CFE3A7C352F TDT
							LEFT JOIN [DD0086FF-AEF5-45C9-A3B5-6CFE3A7C352F] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence";

                                     tempInsertQuery=@"INSERT INTO @TBL_DD0086FFAEF545C9A3B56CFE3A7C352F(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)VALUES({0});";
                                     

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
                     

                                         case "04FCD160-1EC6-471F-97B0-1C6738875C87":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_04FCD1601EC6471F97B01C6738875C87 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT){0}INSERT INTO [04FCD160-1EC6-471F-97B0-1C6738875C87](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence FROM @TBL_04FCD1601EC6471F97B01C6738875C87 TDT
							LEFT JOIN [04FCD160-1EC6-471F-97B0-1C6738875C87] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence";

                            tempInsertQuery=@"INSERT INTO @TBL_04FCD1601EC6471F97B01C6738875C87(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)VALUES({0});";

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

                                              case "DD0086FF-AEF5-45C9-A3B5-6CFE3A7C352F":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_DD0086FFAEF545C9A3B56CFE3A7C352F AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT){0}INSERT INTO [DD0086FF-AEF5-45C9-A3B5-6CFE3A7C352F](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence FROM @TBL_DD0086FFAEF545C9A3B56CFE3A7C352F TDT
							LEFT JOIN [DD0086FF-AEF5-45C9-A3B5-6CFE3A7C352F] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence";

                            tempInsertQuery=@"INSERT INTO @TBL_DD0086FFAEF545C9A3B56CFE3A7C352F(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)VALUES({0});";

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
public class ISpace4E51124DBF8346ECBA9AB746693F716F : VirtualForm
{
IISpace iSpace = new ISpace();
AcDataISpace4E51124DBF8346ECBA9AB746693F716F acdataIspace4E51124DBF8346ECBA9AB746693F716F=new AcDataISpace4E51124DBF8346ECBA9AB746693F716F();
private void SubscribeFormEvents_root(ref Dictionary<string, ServiceElementData> ISpace)
{
try
{
base.WriteDebugInfo(@"Root-OnAfterFormLoad");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySource0845D724E0EA4F3CA76947186EED23FB =GetQueryExpressionDataSource("0845D724-E0EA-4F3C-A769-47186EED23FB");

DataTable result0845D724E0EA4F3CA76947186EED23FB=iSpace.SetGridDataSource(querySource0845D724E0EA4F3CA76947186EED23FB, _objectFactory.GetGridRPP("MF_FundType"),@"EXEC GetFundDistributionCombos 1");

iSpace.InsertGridBindDetails("MF_FundType","11",querySource0845D724E0EA4F3CA76947186EED23FB,"EXEC GetFundDistributionCombos 1",_objectFactory.GetGridRPP("MF_FundType"));

base.WriteDebugInfo(@"var querySource0845D724E0EA4F3CA76947186EED23FB =GetQueryExpressionDataSource(""0845D724-E0EA-4F3C-A769-47186EED23FB"");DataTable result0845D724E0EA4F3CA76947186EED23FB=iSpace.SetGridDataSource(querySource0845D724E0EA4F3CA76947186EED23FB, _objectFactory.GetGridRPP(""MF_FundType""),@""EXEC GetFundDistributionCombos 1"");iSpace.InsertGridBindDetails(""MF_FundType"",""11"",querySource0845D724E0EA4F3CA76947186EED23FB,""EXEC GetFundDistributionCombos 1"",_objectFactory.GetGridRPP(""MF_FundType""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> resultA1ECD9F97CCB425C9711457074501B49=acdataIspace4E51124DBF8346ECBA9AB746693F716F.GetQueryExpressionBindings("A1ECD9F9-7CCB-425C-9711-457074501B49");
iSpace.SetGridData(result0845D724E0EA4F3CA76947186EED23FB,resultA1ECD9F97CCB425C9711457074501B49,"MF_FundType",ref ISpace);
iSpace.UpdateGridBindDetails("MF_FundType",resultA1ECD9F97CCB425C9711457074501B49);
if(ISpace["FormVersionId"].Value=="FE4DDBCD-890E-4679-BDD8-D94D3D9C5BC3")
{
ISpace["UI_Panelhide"].Visible="false";
}if(ISpace["FormVersionId"].Value=="FE4DDBCD-890E-4679-BDD8-D94D3D9C5BC3")
{
ISpace["UI_Columnhide"].Visible="true";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""FE4DDBCD-890E-4679-BDD8-D94D3D9C5BC3"")
{
ISpace[""UI_Panelhide""].Visible=""false"";
}if(ISpace[""FormVersionId""].Value==""FE4DDBCD-890E-4679-BDD8-D94D3D9C5BC3"")
{
ISpace[""UI_Columnhide""].Visible=""true"";
}");
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mf_packageprocessmapid (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MF_PackageProcessMapId-OnChange");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"exec SP_GetDistrubitionDetails 1,'#MF_PackageProcessMapId','',''");

var querySource14EA64430FBE4A6885335FD1536A28E7 =GetQueryExpressionDataSource("14EA6443-0FBE-4A68-8533-5FD1536A28E7");
Dictionary<short,object> result14EA64430FBE4A6885335FD1536A28E7=iSpace.ExecuteQuery(querySource14EA64430FBE4A6885335FD1536A28E7,@"exec SP_GetDistrubitionDetails 1,'" + ISpace["MF_PackageProcessMapId"].Value + @"','',''",false);

base.WriteDebugInfo(@"var querySource14EA64430FBE4A6885335FD1536A28E7 =GetQueryExpressionDataSource(""14EA6443-0FBE-4A68-8533-5FD1536A28E7"");Dictionary<short,object> result14EA64430FBE4A6885335FD1536A28E7=iSpace.ExecuteQuery(querySource14EA64430FBE4A6885335FD1536A28E7,@""exec SP_GetDistrubitionDetails 1,'"" + ISpace[""MF_PackageProcessMapId""].Value + @""','',''"",false);");
base.WriteDebugInfo(@"");

if((result14EA64430FBE4A6885335FD1536A28E7!=null) && (result14EA64430FBE4A6885335FD1536A28E7.Count!=0))
{
if(result14EA64430FBE4A6885335FD1536A28E7.ContainsKey(1))
ISpace["MF_MultipleProjectsAllowed"].Value = result14EA64430FBE4A6885335FD1536A28E7[1];
if(result14EA64430FBE4A6885335FD1536A28E7.ContainsKey(2))
ISpace["MF_SameFundingAgency"].Value = result14EA64430FBE4A6885335FD1536A28E7[2];
if(result14EA64430FBE4A6885335FD1536A28E7.ContainsKey(0))
ISpace["MF_DistributionId"].Value = result14EA64430FBE4A6885335FD1536A28E7[0];
}
else{
ISpace["MF_MultipleProjectsAllowed"].Value = null;ISpace["MF_SameFundingAgency"].Value = null;ISpace["MF_DistributionId"].Value = null;
}
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mg_selectbtn (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MG_SelectBtn-OnClick");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["MF_Fundname"].Value=ISpace["MG_FundTypeName"].Value;
base.WriteDebugInfo(@"ISpace[""MF_Fundname""].Value=ISpace[""MG_FundTypeName""].Value;");
ISpace["MF_FundTypeId"].Value=ISpace["MG_FundTypeId"].Value;
base.WriteDebugInfo(@"ISpace[""MF_FundTypeId""].Value=ISpace[""MG_FundTypeId""].Value;");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["MF_MultipleProjectsAllowed"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_MultipleProjectsAllowed""].Value=null;");
ISpace["MF_SameFundingAgency"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_SameFundingAgency""].Value=null;");
ISpace["MF_MaxPercentageUsage"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_MaxPercentageUsage""].Value=null;");
ISpace["MF_MaxAmount"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_MaxAmount""].Value=null;");
ISpace["MF_Description"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_Description""].Value=null;");
ISpace["MF_DistrubitionDetails"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_DistrubitionDetails""].Value=null;");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"exec SP_GetDistrubitionDetails 1,'#MF_PackageProcessMapId','',''");

var querySourceDAC9F04459354FA0923E7A3EAB9A2F96 =GetQueryExpressionDataSource("DAC9F044-5935-4FA0-923E-7A3EAB9A2F96");
Dictionary<short,object> resultDAC9F04459354FA0923E7A3EAB9A2F96=iSpace.ExecuteQuery(querySourceDAC9F04459354FA0923E7A3EAB9A2F96,@"exec SP_GetDistrubitionDetails 1,'" + ISpace["MF_PackageProcessMapId"].Value + @"','',''",false);

base.WriteDebugInfo(@"var querySourceDAC9F04459354FA0923E7A3EAB9A2F96 =GetQueryExpressionDataSource(""DAC9F044-5935-4FA0-923E-7A3EAB9A2F96"");Dictionary<short,object> resultDAC9F04459354FA0923E7A3EAB9A2F96=iSpace.ExecuteQuery(querySourceDAC9F04459354FA0923E7A3EAB9A2F96,@""exec SP_GetDistrubitionDetails 1,'"" + ISpace[""MF_PackageProcessMapId""].Value + @""','',''"",false);");
base.WriteDebugInfo(@"");

if((resultDAC9F04459354FA0923E7A3EAB9A2F96!=null) && (resultDAC9F04459354FA0923E7A3EAB9A2F96.Count!=0))
{
if(resultDAC9F04459354FA0923E7A3EAB9A2F96.ContainsKey(1))
ISpace["MF_MultipleProjectsAllowed"].Value = resultDAC9F04459354FA0923E7A3EAB9A2F96[1];
if(resultDAC9F04459354FA0923E7A3EAB9A2F96.ContainsKey(2))
ISpace["MF_SameFundingAgency"].Value = resultDAC9F04459354FA0923E7A3EAB9A2F96[2];
if(resultDAC9F04459354FA0923E7A3EAB9A2F96.ContainsKey(0))
ISpace["MF_DistributionId"].Value = resultDAC9F04459354FA0923E7A3EAB9A2F96[0];
}
else{
ISpace["MF_MultipleProjectsAllowed"].Value = null;ISpace["MF_SameFundingAgency"].Value = null;ISpace["MF_DistributionId"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_DistributionId"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""MF_DistributionId""].Value=="""")");
ISpace["MF_DistributionId"].Value=Guid.NewGuid().ToString();
base.WriteDebugInfo(@"ISpace[""MF_DistributionId""].Value=Guid.NewGuid().ToString();");
}
}
if(ISpace["MF_FundTypeId"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""MF_FundTypeId""].Value==1)");

var querySource291629D86EDC4ED287968C3E5F8981AB =GetQueryExpressionDataSource("291629D8-6EDC-4ED2-8796-8C3E5F8981AB");

DataTable result291629D86EDC4ED287968C3E5F8981AB=iSpace.SetGridDataSource(querySource291629D86EDC4ED287968C3E5F8981AB, _objectFactory.GetGridRPP("MF_DistrubitionDetails"),@"exec SP_GetDistrubitionDetails 2,'','" + ISpace["MF_FundTypeId"].Value + @"','" + ISpace["MF_DistributionId"].Value + @"'");

iSpace.InsertGridBindDetails("MF_DistrubitionDetails","11",querySource291629D86EDC4ED287968C3E5F8981AB,"exec SP_GetDistrubitionDetails 2,'','" + ISpace["MF_FundTypeId"].Value + @"','" + ISpace["MF_DistributionId"].Value + @"'",_objectFactory.GetGridRPP("MF_DistrubitionDetails"));

base.WriteDebugInfo(@"var querySource291629D86EDC4ED287968C3E5F8981AB =GetQueryExpressionDataSource(""291629D8-6EDC-4ED2-8796-8C3E5F8981AB"");DataTable result291629D86EDC4ED287968C3E5F8981AB=iSpace.SetGridDataSource(querySource291629D86EDC4ED287968C3E5F8981AB, _objectFactory.GetGridRPP(""MF_DistrubitionDetails""),@""exec SP_GetDistrubitionDetails 2,'','"" + ISpace[""MF_FundTypeId""].Value + @""','"" + ISpace[""MF_DistributionId""].Value + @""'"");iSpace.InsertGridBindDetails(""MF_DistrubitionDetails"",""11"",querySource291629D86EDC4ED287968C3E5F8981AB,""exec SP_GetDistrubitionDetails 2,'','"" + ISpace[""MF_FundTypeId""].Value + @""','"" + ISpace[""MF_DistributionId""].Value + @""'"",_objectFactory.GetGridRPP(""MF_DistrubitionDetails""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result080778C9A8D34B048CFA39FBC2646244=acdataIspace4E51124DBF8346ECBA9AB746693F716F.GetQueryExpressionBindings("080778C9-A8D3-4B04-8CFA-39FBC2646244");
iSpace.SetGridData(result291629D86EDC4ED287968C3E5F8981AB,result080778C9A8D34B048CFA39FBC2646244,"MF_DistrubitionDetails",ref ISpace);
iSpace.UpdateGridBindDetails("MF_DistrubitionDetails",result080778C9A8D34B048CFA39FBC2646244);
if(ISpace["FormVersionId"].Value=="FE4DDBCD-890E-4679-BDD8-D94D3D9C5BC3")
{
ISpace["UI_Panelhide"].Visible="false";
}if(ISpace["FormVersionId"].Value=="FE4DDBCD-890E-4679-BDD8-D94D3D9C5BC3")
{
ISpace["UI_Columnhide"].Visible="true";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""FE4DDBCD-890E-4679-BDD8-D94D3D9C5BC3"")
{
ISpace[""UI_Panelhide""].Visible=""false"";
}if(ISpace[""FormVersionId""].Value==""FE4DDBCD-890E-4679-BDD8-D94D3D9C5BC3"")
{
ISpace[""UI_Columnhide""].Visible=""true"";
}");
}
else
{
base.WriteDebugInfo(@"else");
base.WriteDebugInfo(@"exec SP_GetDistrubitionDetails 3,'','#MF_FundTypeId','#MF_DistributionId'");

var querySourceAA271A94D1BE4932BBD4D7C3E0DEBE2E =GetQueryExpressionDataSource("AA271A94-D1BE-4932-BBD4-D7C3E0DEBE2E");
Dictionary<short,object> resultAA271A94D1BE4932BBD4D7C3E0DEBE2E=iSpace.ExecuteQuery(querySourceAA271A94D1BE4932BBD4D7C3E0DEBE2E,@"exec SP_GetDistrubitionDetails 3,'','" + ISpace["MF_FundTypeId"].Value + @"','" + ISpace["MF_DistributionId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceAA271A94D1BE4932BBD4D7C3E0DEBE2E =GetQueryExpressionDataSource(""AA271A94-D1BE-4932-BBD4-D7C3E0DEBE2E"");Dictionary<short,object> resultAA271A94D1BE4932BBD4D7C3E0DEBE2E=iSpace.ExecuteQuery(querySourceAA271A94D1BE4932BBD4D7C3E0DEBE2E,@""exec SP_GetDistrubitionDetails 3,'','"" + ISpace[""MF_FundTypeId""].Value + @""','"" + ISpace[""MF_DistributionId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultAA271A94D1BE4932BBD4D7C3E0DEBE2E!=null) && (resultAA271A94D1BE4932BBD4D7C3E0DEBE2E.Count!=0))
{
if(resultAA271A94D1BE4932BBD4D7C3E0DEBE2E.ContainsKey(0))
ISpace["MF_OtherDistributionId"].Value = resultAA271A94D1BE4932BBD4D7C3E0DEBE2E[0];
if(resultAA271A94D1BE4932BBD4D7C3E0DEBE2E.ContainsKey(4))
ISpace["MF_MaxAmount"].Value = resultAA271A94D1BE4932BBD4D7C3E0DEBE2E[4];
if(resultAA271A94D1BE4932BBD4D7C3E0DEBE2E.ContainsKey(3))
ISpace["MF_MaxPercentageUsage"].Value = resultAA271A94D1BE4932BBD4D7C3E0DEBE2E[3];
if(resultAA271A94D1BE4932BBD4D7C3E0DEBE2E.ContainsKey(5))
ISpace["MF_Description"].Value = resultAA271A94D1BE4932BBD4D7C3E0DEBE2E[5];
}
else{
ISpace["MF_OtherDistributionId"].Value = null;ISpace["MF_MaxAmount"].Value = null;ISpace["MF_MaxPercentageUsage"].Value = null;ISpace["MF_Description"].Value = null;
}
if(ISpace["FormVersionId"].Value=="FE4DDBCD-890E-4679-BDD8-D94D3D9C5BC3")
{
ISpace["UI_Panelhide"].Visible="true";
}if(ISpace["FormVersionId"].Value=="FE4DDBCD-890E-4679-BDD8-D94D3D9C5BC3")
{
ISpace["UI_Columnhide"].Visible="false";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""FE4DDBCD-890E-4679-BDD8-D94D3D9C5BC3"")
{
ISpace[""UI_Panelhide""].Visible=""true"";
}if(ISpace[""FormVersionId""].Value==""FE4DDBCD-890E-4679-BDD8-D94D3D9C5BC3"")
{
ISpace[""UI_Columnhide""].Visible=""false"";
}");
}
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mf_add (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MF_Add-OnClick");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"Entering DomainDataMap for Fund Configurations");
var FundConfigurations_repoObj = new RepositoryMapper(DbTypes.SQLServer);


var FundDistributionMasterFundConfigurationstableObj = new RepositoryTable("FundDistributionMaster");
  FundDistributionMasterFundConfigurationstableObj.AppConnectionSettingsId  ="9ADED37B-CD11-426B-AF16-DEAC75685EF5";FundDistributionMasterFundConfigurationstableObj.ProofConnectionId = "C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0)";
var FundConfigurations_FundDistributionMaster_rows = GetElementClientData(ISpace["InstanceId"].Value,"781F63B4-048D-4578-AF08-83C4E8FC0483");

if(FundConfigurations_FundDistributionMaster_rows!=null && FundConfigurations_FundDistributionMaster_rows.Count>0){
var FundConfigurations_FundDistributionMaster_rowsObj = new List<RepositoryRow>();
foreach(var rows in FundConfigurations_FundDistributionMaster_rows){RepositoryRow repositoryRowObj = null;string elementData = null;RepositoryColumn repositoryColumnObj = null;if(rows !=null){ var FundDistributionMaster_colObj = new List<RepositoryColumn>();repositoryRowObj= new RepositoryRow();//var myByte = (byte)rowData.Value.RwSt;//repositoryRowObj.RowState=(RepositoryRowState)myByte;

if(rows.ContainsKey("C3C56D3A-493C-4FC0-9174-CE53BCB50995"))     elementData = rows["C3C56D3A-493C-4FC0-9174-CE53BCB50995"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"DistributionId",true,false,9);
if(repositoryColumnObj!=null)FundDistributionMaster_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MF_DistributionId not found");}

elementData = ISpace["gv_UserId"].Value != null? Convert.ToString(ISpace["gv_UserId"].Value):null ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"UpdatedBy",false,false,5);
if(repositoryColumnObj!=null)FundDistributionMaster_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-gv_UserId not found");}

if(rows.ContainsKey("4CDCB08E-DCEB-4063-90C2-374A5013BB1B"))     elementData = rows["4CDCB08E-DCEB-4063-90C2-374A5013BB1B"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"SameFundingAgency",false,false,0);
if(repositoryColumnObj!=null)FundDistributionMaster_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MF_SameFundingAgency not found");}

if(rows.ContainsKey("40E3794E-390D-49A6-8D12-A1B07CE6B41B"))     elementData = rows["40E3794E-390D-49A6-8D12-A1B07CE6B41B"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"MultipleProjectsAllowed",false,false,0);
if(repositoryColumnObj!=null)FundDistributionMaster_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MF_MultipleProjectsAllowed not found");}

if(rows.ContainsKey("1B6915C8-6C3A-4669-8F57-FF2797EA96AE"))     elementData = rows["1B6915C8-6C3A-4669-8F57-FF2797EA96AE"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"PackageProcessMapId",false,false,9);
if(repositoryColumnObj!=null)FundDistributionMaster_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MF_PackageProcessMapId not found");}

elementData = CurrentDate().ToString() ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"UpdatedOn",false,false,8);
if(repositoryColumnObj!=null)FundDistributionMaster_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-CurrentDate not found");}
repositoryRowObj.Columns=FundDistributionMaster_colObj;
FundConfigurations_FundDistributionMaster_rowsObj.Add(repositoryRowObj);
}}

FundDistributionMasterFundConfigurationstableObj.Rows=FundConfigurations_FundDistributionMaster_rowsObj;
var FundConfigurations_repoObj_status_FundDistributionMaster = FundConfigurations_repoObj.Execute(DomainOperationTypes.CreateOrUpdate,ref FundDistributionMasterFundConfigurationstableObj);if(!FundConfigurations_repoObj_status_FundDistributionMaster) throw new Exception("Error in Execute Domain Data Map");}
base.WriteDebugInfo(@"Exiting DomainDataMap for Fund Configurations");
if(ISpace["MF_FundTypeId"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""MF_FundTypeId""].Value==1)");
base.WriteDebugInfo(@"Entering DomainDataMap for ProjectDistrubitionDetails");
var ProjectDistrubitionDetails_repoObj = new RepositoryMapper(DbTypes.SQLServer);


var ProjectDistrubitionDetailsProjectDistrubitionDetailstableObj = new RepositoryTable("ProjectDistrubitionDetails");
  ProjectDistrubitionDetailsProjectDistrubitionDetailstableObj.AppConnectionSettingsId  ="9ADED37B-CD11-426B-AF16-DEAC75685EF5";ProjectDistrubitionDetailsProjectDistrubitionDetailstableObj.ProofConnectionId = "C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0)";
var ProjectDistrubitionDetails_ProjectDistrubitionDetails_rows = GetElementClientData(ISpace["InstanceId"].Value,"DD0086FF-AEF5-45C9-A3B5-6CFE3A7C352F");

if(ProjectDistrubitionDetails_ProjectDistrubitionDetails_rows!=null && ProjectDistrubitionDetails_ProjectDistrubitionDetails_rows.Count>0){
var ProjectDistrubitionDetails_ProjectDistrubitionDetails_rowsObj = new List<RepositoryRow>();
foreach(var rows in ProjectDistrubitionDetails_ProjectDistrubitionDetails_rows){RepositoryRow repositoryRowObj = null;string elementData = null;RepositoryColumn repositoryColumnObj = null;if(rows !=null){ var ProjectDistrubitionDetails_colObj = new List<RepositoryColumn>();repositoryRowObj= new RepositoryRow();//var myByte = (byte)rowData.Value.RwSt;//repositoryRowObj.RowState=(RepositoryRowState)myByte;

if(rows.ContainsKey("6204D68F-FF10-4F21-B878-2607159C5180"))     elementData = rows["6204D68F-FF10-4F21-B878-2607159C5180"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Description",false,false,9);
if(repositoryColumnObj!=null)ProjectDistrubitionDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MG_Description not found");}

if(rows.ContainsKey("5852B2EE-9B02-44E2-9FB4-9DACE339D8BD"))     elementData = rows["5852B2EE-9B02-44E2-9FB4-9DACE339D8BD"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"FundTypeId",false,false,5);
if(repositoryColumnObj!=null)ProjectDistrubitionDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MF_FundTypeId not found");}

if(rows.ContainsKey("2C4EF5CA-D390-4960-9476-E8F6580DEEC9"))     elementData = rows["2C4EF5CA-D390-4960-9476-E8F6580DEEC9"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ProjectDistributionId",true,true,5);
if(repositoryColumnObj!=null)ProjectDistrubitionDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MG_ProjectOrOtherId not found");}

if(rows.ContainsKey("F24AD8C1-E439-49A2-86FC-9A0E9CFC516C"))     elementData = rows["F24AD8C1-E439-49A2-86FC-9A0E9CFC516C"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"MaxAmount",false,false,3);
if(repositoryColumnObj!=null)ProjectDistrubitionDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MG_MaxAmount not found");}

if(rows.ContainsKey("32E470CA-58C4-4FFE-9D02-0494D54BD69E"))     elementData = rows["32E470CA-58C4-4FFE-9D02-0494D54BD69E"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"BudgetHeadId",false,false,9);
if(repositoryColumnObj!=null)ProjectDistrubitionDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MG_BudgetHeadId not found");}

if(rows.ContainsKey("BB0126FB-58D6-4D67-81A0-CBCFD5B634C3"))     elementData = rows["BB0126FB-58D6-4D67-81A0-CBCFD5B634C3"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"MaxPercentageUsage",false,false,3);
if(repositoryColumnObj!=null)ProjectDistrubitionDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MG_MaxPercentageUsage not found");}

if(rows.ContainsKey("C3C56D3A-493C-4FC0-9174-CE53BCB50995"))     elementData = rows["C3C56D3A-493C-4FC0-9174-CE53BCB50995"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"DistributionId",false,false,9);
if(repositoryColumnObj!=null)ProjectDistrubitionDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MF_DistributionId not found");}
repositoryRowObj.Columns=ProjectDistrubitionDetails_colObj;
ProjectDistrubitionDetails_ProjectDistrubitionDetails_rowsObj.Add(repositoryRowObj);
}}

ProjectDistrubitionDetailsProjectDistrubitionDetailstableObj.Rows=ProjectDistrubitionDetails_ProjectDistrubitionDetails_rowsObj;
var ProjectDistrubitionDetails_repoObj_status_ProjectDistrubitionDetails = ProjectDistrubitionDetails_repoObj.Execute(DomainOperationTypes.CreateOrUpdate,ref ProjectDistrubitionDetailsProjectDistrubitionDetailstableObj);if(!ProjectDistrubitionDetails_repoObj_status_ProjectDistrubitionDetails) throw new Exception("Error in Execute Domain Data Map");}
base.WriteDebugInfo(@"Exiting DomainDataMap for ProjectDistrubitionDetails");
}
else
{
base.WriteDebugInfo(@"else");
base.WriteDebugInfo(@"Entering DomainDataMap for OtherDistributionDetails");
var OtherDistributionDetails_repoObj = new RepositoryMapper(DbTypes.SQLServer);


var OtherDistributionDetailsOtherDistributionDetailstableObj = new RepositoryTable("OtherDistributionDetails");
  OtherDistributionDetailsOtherDistributionDetailstableObj.AppConnectionSettingsId  ="9ADED37B-CD11-426B-AF16-DEAC75685EF5";OtherDistributionDetailsOtherDistributionDetailstableObj.ProofConnectionId = "C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0)";
var OtherDistributionDetails_OtherDistributionDetails_rows = GetElementClientData(ISpace["InstanceId"].Value,"781F63B4-048D-4578-AF08-83C4E8FC0483");

if(OtherDistributionDetails_OtherDistributionDetails_rows!=null && OtherDistributionDetails_OtherDistributionDetails_rows.Count>0){
var OtherDistributionDetails_OtherDistributionDetails_rowsObj = new List<RepositoryRow>();
foreach(var rows in OtherDistributionDetails_OtherDistributionDetails_rows){RepositoryRow repositoryRowObj = null;string elementData = null;RepositoryColumn repositoryColumnObj = null;if(rows !=null){ var OtherDistributionDetails_colObj = new List<RepositoryColumn>();repositoryRowObj= new RepositoryRow();//var myByte = (byte)rowData.Value.RwSt;//repositoryRowObj.RowState=(RepositoryRowState)myByte;

if(rows.ContainsKey("ABAF769F-7D04-4C52-AEA4-E8791812D9D2"))     elementData = rows["ABAF769F-7D04-4C52-AEA4-E8791812D9D2"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"MaxAmount",false,false,3);
if(repositoryColumnObj!=null)OtherDistributionDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MF_MaxAmount not found");}

if(rows.ContainsKey("5519D63F-4F89-421F-9993-3556DE012FE3"))     elementData = rows["5519D63F-4F89-421F-9993-3556DE012FE3"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Description",false,false,9);
if(repositoryColumnObj!=null)OtherDistributionDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MF_Description not found");}

if(rows.ContainsKey("C2BF1BE7-9A89-45AF-ACA5-62946C323850"))     elementData = rows["C2BF1BE7-9A89-45AF-ACA5-62946C323850"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"MaxPercentageOfUsage",false,false,3);
if(repositoryColumnObj!=null)OtherDistributionDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MF_MaxPercentageUsage not found");}

if(rows.ContainsKey("5852B2EE-9B02-44E2-9FB4-9DACE339D8BD"))     elementData = rows["5852B2EE-9B02-44E2-9FB4-9DACE339D8BD"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"FundTypeId",false,false,5);
if(repositoryColumnObj!=null)OtherDistributionDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MF_FundTypeId not found");}

if(rows.ContainsKey("0BCB3EC1-E3A9-4D0F-8E5B-9465E9494B39"))     elementData = rows["0BCB3EC1-E3A9-4D0F-8E5B-9465E9494B39"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"OtherDistributionId",true,true,5);
if(repositoryColumnObj!=null)OtherDistributionDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MF_OtherDistributionId not found");}

if(rows.ContainsKey("C3C56D3A-493C-4FC0-9174-CE53BCB50995"))     elementData = rows["C3C56D3A-493C-4FC0-9174-CE53BCB50995"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"DistributionId",false,false,9);
if(repositoryColumnObj!=null)OtherDistributionDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MF_DistributionId not found");}
repositoryRowObj.Columns=OtherDistributionDetails_colObj;
OtherDistributionDetails_OtherDistributionDetails_rowsObj.Add(repositoryRowObj);
}}

OtherDistributionDetailsOtherDistributionDetailstableObj.Rows=OtherDistributionDetails_OtherDistributionDetails_rowsObj;
var OtherDistributionDetails_repoObj_status_OtherDistributionDetails = OtherDistributionDetails_repoObj.Execute(DomainOperationTypes.CreateOrUpdate,ref OtherDistributionDetailsOtherDistributionDetailstableObj);if(!OtherDistributionDetails_repoObj_status_OtherDistributionDetails) throw new Exception("Error in Execute Domain Data Map");}
base.WriteDebugInfo(@"Exiting DomainDataMap for OtherDistributionDetails");
}
ISpace["Message"].Value=@"Added Successfully";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Added Successfully"";");

ISpace["RedirectUrl"].RedirectType="R";
ISpace["RedirectUrl"].Value="?PkActMId=BCAB23B3-8861-4E20-96CF-C2B44F91F006&frmElementId=057E6822-8FF7-47E9-82ED-17D7DA49AD84&PkPrMId=472EFC64-BFFD-4B5C-B49E-EC4A0F36DFC1&formVersionId=CC864E49-746E-4A26-A9BB-AF4747EF976B&Ver=0.0000";
base.WriteDebugInfo(@"
ISpace[""RedirectUrl""].RedirectType=""R"";
ISpace[""RedirectUrl""].Value=""?PkActMId=BCAB23B3-8861-4E20-96CF-C2B44F91F006&frmElementId=057E6822-8FF7-47E9-82ED-17D7DA49AD84&PkPrMId=472EFC64-BFFD-4B5C-B49E-EC4A0F36DFC1&formVersionId=CC864E49-746E-4A26-A9BB-AF4747EF976B&Ver=0.0000"";");
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
		if(elementName.ToLower().Equals("mf_packageprocessmapid"))
    {
    			SubscribeElementEvents_mf_packageprocessmapid(ref dfsParam);
    }
}
	if(methodName.ToLower().Equals("onclick"))
{
		if(elementName.ToLower().Equals("mg_selectbtn"))
{
			SubscribeElementEvents_mg_selectbtn(ref dfsParam);
}
		if(elementName.ToLower().Equals("mf_add"))
{
			SubscribeElementEvents_mf_add(ref dfsParam);
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


	public partial class AcDataISpace4E51124DBF8346ECBA9AB746693F716F  : ExtensionActivityBase
	{		
		
		
		private Dictionary<string,  List<Triplet<string, short, short?>>> queryExpressionBindings = 
											new Dictionary<string,  List<Triplet<string, short, short?>>>
		{
							{"080778C9-A8D3-4B04-8CFA-39FBC2646244", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_BudgetHeadId",3,
														   -1),
								   new Triplet<string, short, short?>("MG_Description",6,
														   -1),
								   new Triplet<string, short, short?>("MG_MaxAmount",5,
														   -1),
								   new Triplet<string, short, short?>("MG_MaxPercentageUsage",4,
														   -1),
								   new Triplet<string, short, short?>("MG_ProjectOrOtherId",0,
														   -1),
								}
			},
							{"A1ECD9F9-7CCB-425C-9711-457074501B49", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_FundTypeId",0,
														   -1),
								   new Triplet<string, short, short?>("MG_SelectBtn",1,
														   -1),
								}
			},
					};	

	

		private Dictionary<string,string> formVersionList =new Dictionary<string,string> 
		{
							{"FE4DDBCD-890E-4679-BDD8-D94D3D9C5BC3", "Medium"},
					};	

		
		private Dictionary<string,string> formVersionLayoutList =new Dictionary<string,string> 
		{
							{"F172C35D-F618-4ACD-96F1-0FF23BA5D25A", ""},
							{"B3C10381-05C0-4046-8E31-BE1D4337FC7F", ""},
							{"FE4DDBCD-890E-4679-BDD8-D94D3D9C5BC3", ""},
							{"B46293DC-1627-4876-A25F-FABCA74BED72", ""},
							{"AC0C1F92-617B-4AFB-ADD9-B97388AEBAAD", ""},
							{"FFF57AB3-9BDA-4D8E-A747-6D4D3B5E8788", ""},
							{"2EC9C950-3625-4F00-AB8E-E1BBC47AC217", ""},
							{"B45F0D80-EB90-4652-8519-29C1EE4AB4D2", ""},
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
		


