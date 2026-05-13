  







namespace CPS.Proof.DFSExtension
{
	using System;
    using System.Collections.Generic;     
	using System.Linq;
	
	
	public partial class TempAdvanceProcessMetadata : ExtensionProcessBase
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
            get { return "9A6DB1E6-872F-4A0C-B21C-6BE13EC6E295"; }
        }

        public override string ProcessName
        {
            get { return "TempAdvance"; }
        }

		public override string ProcessDescription
        {
            get { return "Temp Advance"; }
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
            get {return "9A6DB1E6-872F-4A0C-B21C-6BE13EC6E295";}
        }

		public override byte ProcessInstanceMode
        {
            get {return 3;}
        }		

		public override string MasterFormId
        {
            get {  
				   return "6B463D69-64AB-468E-B2E3-DB12E6B90014";	}
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
	

	public partial class TempAdvanceObjectFactory  : ExtObjectFactoryBase
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
        //    return (IExtBaseMetaData)new TempAdvanceProcessMetadata();
        //}
	


		private List<Triplet<string, string, string>> queryExpressionData = new List<Triplet<string, string, string>>
		{
	  			
			     new Triplet<string, string, string>("770E6D04-0AD0-41D6-92DE-50A2A8E84E7D","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"9ADED37B-CD11-426B-AF16-DEAC75685EF5"),
			
						
			     new Triplet<string, string, string>("E12571F8-1F59-45ED-9BC6-BAF0AA62F4F0","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"2F28A839-0875-4C17-8ADF-2FC7F8F8847C"),
			
						
			     new Triplet<string, string, string>("8BBB2BE7-1E85-40E5-9B13-CC03C350EAB8","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"9ADED37B-CD11-426B-AF16-DEAC75685EF5"),
			
						
			     new Triplet<string, string, string>("549686A1-3897-4AFC-A19E-C95972C37210","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"9ADED37B-CD11-426B-AF16-DEAC75685EF5"),
			
						
			     new Triplet<string, string, string>("457B75FD-B3F3-4EB7-87EB-96D92F86F9EB","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"2F28A839-0875-4C17-8ADF-2FC7F8F8847C"),
			
						
			     new Triplet<string, string, string>("C5471BC3-8ECA-4216-A66F-923825C32508","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"2F28A839-0875-4C17-8ADF-2FC7F8F8847C"),
			
						
			     new Triplet<string, string, string>("A8D19C29-F512-4468-83DE-4C86EF7F0E8F","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"2F28A839-0875-4C17-8ADF-2FC7F8F8847C"),
			
						
			     new Triplet<string, string, string>("27ED5457-FD38-4124-AB17-A6225151D7BE","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("EE0DA86F-C274-4B2F-8038-8A33B103F110","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("07D02D1F-066F-4E9B-8819-A44E473F22C2","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("F3514DB4-690A-4BE6-A6A7-7FA3D37E5B7C","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"2F28A839-0875-4C17-8ADF-2FC7F8F8847C"),
			
						
			     new Triplet<string, string, string>("588878D7-B782-4F24-BAF7-A4FE902E4A93","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"2F28A839-0875-4C17-8ADF-2FC7F8F8847C"),
			
						
			     new Triplet<string, string, string>("21822FB8-6E0C-4D8C-9EE5-38233317BB5C","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"2F28A839-0875-4C17-8ADF-2FC7F8F8847C"),
			
						
			     new Triplet<string, string, string>("B460B189-F975-46FA-AA0E-C134AA7CDECC","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("10ACD400-F600-43A6-B4F2-44863C61AA73","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"028B1EFF-34A8-4D44-BF39-06CE99DF7C67"),
			
						
			     new Triplet<string, string, string>("A58A83FE-0FF7-4A0C-8C89-9744967E99A5","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("DF30243A-9324-4865-9FFF-478698865C85","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("318EAB61-FF35-4EB2-A293-264135B2F298","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("75E44CDA-6428-4B8E-8757-9CF0529D0DC9","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("8BBB2BE7-1E85-40E5-9B13-CC03C350EAB8","Load Remarks Details",
												     @"A65EED98-D95D-45DF-9765-1BDBF01908AD"),
			
						
			     new Triplet<string, string, string>("C5471BC3-8ECA-4216-A66F-923825C32508","Grid BindingC",
												     @"00D69CC2-E6EC-4412-B2A9-14E57A96FB5C"),
			
						
			     new Triplet<string, string, string>("A8D19C29-F512-4468-83DE-4C86EF7F0E8F","Grid BindingU",
												     @"00D69CC2-E6EC-4412-B2A9-14E57A96FB5C"),
			
						
			     new Triplet<string, string, string>("F3514DB4-690A-4BE6-A6A7-7FA3D37E5B7C","Grid BindingC",
												     @"D74F91B1-1C1A-47A6-BF5F-B731EB2F53FB"),
			
						
			     new Triplet<string, string, string>("588878D7-B782-4F24-BAF7-A4FE902E4A93","Grid BindingB",
												     @"D74F91B1-1C1A-47A6-BF5F-B731EB2F53FB"),
			
						
			     new Triplet<string, string, string>("21822FB8-6E0C-4D8C-9EE5-38233317BB5C","Delete Records",
												     @"00D69CC2-E6EC-4412-B2A9-14E57A96FB5C"),
			
						
			     new Triplet<string, string, string>("DF30243A-9324-4865-9FFF-478698865C85","Load Commitments",
												     @"1064BC8E-93B2-409C-BD15-01E2EBC35B41"),
			
			
			
		};

		
		private List<Triplet<string, string, string>> ComboDataSource = new List<Triplet<string, string, string>>
		{

		
	  			
			     new Triplet<string, string, string>("MG_P3_ProjectDetailsId","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw1z/z9sf1712IST2TisZRbDL01cRO080NYHWsKvkYJS77cc4eTVUER6yxhHgktDkfvWfwBNgoOezuhR3VTahYodgYs1XIsswI0A==",
												     @"EXEC Projects..GetProjectExtensionDetails 1,"@MG_P3_Employeebasicinfoid""),
			
						
			     new Triplet<string, string, string>("MF_ProjectNo","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw1z/z9sf1712IST2TisZRbDL01cRO080NYHWsKvkYJS77XPhhEPANfatU8lJP0mJJjSopgrwrPOlAa7ekRdWJpCoSneyUlDBd6d1RrcOybG3s",
												     @"EXEC GetProjectExtensionDetails 1,"@UC_EmployeeBaicInfoId""),
			
						
			     new Triplet<string, string, string>("MG_P3_BudgetHeadId","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw1z/z9sf1712IST2TisZRbDL01cRO080NYHWsKvkYJS77cc4eTVUER6yxhHgktDkfvWfwBNgoOezuhR3VTahYodgYs1XIsswI0A==",
												     @"exec SP_GetDistrubitionDetails 5,"@MG_P3_Packageprocessmapid","@MG_P3_FundTypeId","""),
			
						
			     new Triplet<string, string, string>("M_MoveTo","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw1z/z9sf1712IST2TisZRbDL01cRO080NYHWsKvkYJS77cc4eTVUER6yxhHgktDkfvWfwBNgoOezuhR3VTahYodgYs1XIsswI0A==",
												     @"EXEC GetMovetoValues "@M_SourceActivityMapId","@M_PackageProcessMapId""),
			
						
			     new Triplet<string, string, string>("MG_P3_FundTypeId","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw1z/z9sf1712IST2TisZRbDL01cRO080NYHWsKvkYJS77cc4eTVUER6yxhHgktDkfvWfwBNgoOezuhR3VTahYodgYs1XIsswI0A==",
												     @"exec SP_GetDistrubitionDetails 4,"@MG_P3_Packageprocessmapid","","""),
			
						
			     new Triplet<string, string, string>("MFG_P3_FundTypeId","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw1z/z9sf1712IST2TisZRbDL01cRO080NYHWsKvkYJS77cc4eTVUER6yxhHgktDkfvWfwBNgoOezuhR3VTahYodgYs1XIsswI0A==",
												     @"exec SP_GetDistrubitionDetails 4,"@M_PackageProcessMapId","","""),
			
						
			     new Triplet<string, string, string>("MFG_P3_ProjectDetailsId","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw1z/z9sf1712IST2TisZRbDL01cRO080NYHWsKvkYJS77XPhhEPANfatU8lJP0mJJjSopgrwrPOlAa7ekRdWJpCoSneyUlDBd6d1RrcOybG3s",
												     @"EXEC Projects..GetProjectExtensionDetails 1,"@UC_EmployeeBaicInfoId""),
			
						
			     new Triplet<string, string, string>("MFG_P3_BudgetHeadId","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw1z/z9sf1712IST2TisZRbDL01cRO080NYHWsKvkYJS77cc4eTVUER6yxhHgktDkfvWfwBNgoOezuhR3VTahYodgYs1XIsswI0A==",
												     @"exec SP_GetDistrubitionDetails 5,"@M_PackageProcessMapId","@MFG_P3_FundTypeId","","","","","@MFG_P3_ProjectDetailsId""),
			
						
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
		
	  			
			     new Tuple<string, int>("MG_DcoumentDetails",5),
			
						
			     new Tuple<string, int>("MG_CommitmentDetails",5),
			
						
			     new Tuple<string, int>("MG_Advancedetails",5),
			
						
			     new Tuple<string, int>("ReimbursementFundDetails",25),
			
						
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
											case "B2EE67FA-41C1-4A1B-AB23-466B572ACE72":
							virtualInstance=new ISpaceB2EE67FA41C14A1BAB23466B572ACE72();
							break;
					
											case "1E274DA6-1515-4B96-B922-4B5CC5F2D423":
							virtualInstance=new ISpace1E274DA615154B96B9224B5CC5F2D423();
							break;
					
											case "893AB0C8-8E48-4E9C-8DCD-EF160F9C9A43":
							virtualInstance=new ISpace893AB0C88E484E9C8DCDEF160F9C9A43();
							break;
					
											case "99884CE2-50CB-494D-B49B-5828617FE860":
							virtualInstance=new ISpace99884CE250CB494DB49B5828617FE860();
							break;
					
											case "9FE779D2-129C-47A2-B87D-173C6AFE51CB":
							virtualInstance=new ISpace9FE779D2129C47A2B87D173C6AFE51CB();
							break;
					
											case "69B6AE86-D2BA-4048-9EE6-B4627B21F951":
							virtualInstance=new ISpace69B6AE86D2BA40489EE6B4627B21F951();
							break;
					
											case "BD4B416F-E184-4A6F-B8DE-4D2B42649FF4":
							virtualInstance=new ISpaceBD4B416FE1844A6FB8DE4D2B42649FF4();
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
	

	public partial class TempAdvanceDataElementFactory  : ExtElementBase
    {

     /// <summary>
        /// A <see cref="log4net.ILog"/> that contains the logger instance for 
        /// logging
        /// </summary>
        private readonly ILog _sysLog;

        public TempAdvanceDataElementFactory()
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

               
                
                                      case "6B463D69-64AB-468E-B2E3-DB12E6B90014":
                    {
                     
                                     fInsertQuery=@"IF NOT EXISTS(SELECT 1 FROM [6B463D69-64AB-468E-B2E3-DB12E6B90014] WHERE InstanceId='{0}' AND
							ProcessActivityMapId='{1}' AND FormId='{2}') BEGIN INSERT INTO [6B463D69-64AB-468E-B2E3-DB12E6B90014](ProcessActivityMapId,FormId,M_MoveTo,MF_ProjectNo,MF_P1_Initiatedon,MF_P1_UpdatedOn,Thumbnail,MF_P1_ReimbursementId,UC_EmailId,DisplayContext,ExecuteCommand,UC_Department,IN_SLA,CancelRedirectUrl,MF_P1_Remarks,RedirectUrl,M_NextStage,AssignToRole,KeyContext,UC_EmployeeId,UC_Paylevel,M_ErrMsg,MF_P1_ApplicationStatus,M_Status,growid,M_MoveToValue,M_DestinationActivityId,SetDestinationTo,Subject,M_InstanceId,ExecutionStatus,M_PackageProcessMapId,MF_P1_InitatedBy,UC_Grade,UC_DOJ,M_ReferenceNo,MF_P1_UpdatedBy,M_SourceActivityMapId,UC_EmployeeBaicInfoId,M_InitiatorUserMapId,UC_Designation,UC_PhoneNumber,M_Advanceformid,AssignToUser,MF_P1_EmployeeBasicInfoId,UC_Name,ExecutionMessage,MF_E1_EmployeeBasicInfoId,UC_DOB,IN_InstanceName,UC_DOR,M_IsSourceStep,Test,M_IsflowReturned,IN_Category,M_UpdateCount,SLATime,IN_Priority,MF_P1_TotalAmount,M_RemarksMandatory,M_FieldMandatory,M_ErrId,IN_Status,M_SaveDomainData,M_RequestId,M_IsCancelReject,Declaration,InstanceId)
							VALUES( {3}) END ELSE BEGIN UPDATE [6B463D69-64AB-468E-B2E3-DB12E6B90014]SET {4}WHERE InstanceId='{0}'AND ProcessActivityMapId='{1}'AND FormId='{2}'END ";

                                     colList=@"ProcessActivityMapId,FormId,M_MoveTo,MF_ProjectNo,MF_P1_Initiatedon,MF_P1_UpdatedOn,Thumbnail,MF_P1_ReimbursementId,UC_EmailId,DisplayContext,ExecuteCommand,UC_Department,IN_SLA,CancelRedirectUrl,MF_P1_Remarks,RedirectUrl,M_NextStage,AssignToRole,KeyContext,UC_EmployeeId,UC_Paylevel,M_ErrMsg,MF_P1_ApplicationStatus,M_Status,growid,M_MoveToValue,M_DestinationActivityId,SetDestinationTo,Subject,M_InstanceId,ExecutionStatus,M_PackageProcessMapId,MF_P1_InitatedBy,UC_Grade,UC_DOJ,M_ReferenceNo,MF_P1_UpdatedBy,M_SourceActivityMapId,UC_EmployeeBaicInfoId,M_InitiatorUserMapId,UC_Designation,UC_PhoneNumber,M_Advanceformid,AssignToUser,MF_P1_EmployeeBasicInfoId,UC_Name,ExecutionMessage,MF_E1_EmployeeBasicInfoId,UC_DOB,IN_InstanceName,UC_DOR,M_IsSourceStep,Test,M_IsflowReturned,IN_Category,M_UpdateCount,SLATime,IN_Priority,MF_P1_TotalAmount,M_RemarksMandatory,M_FieldMandatory,M_ErrId,IN_Status,M_SaveDomainData,M_RequestId,M_IsCancelReject,Declaration,InstanceId";
                                    
                     
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

                
                 
                                      case "00D69CC2-E6EC-4412-B2A9-14E57A96FB5C":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_00D69CC2E6EC4412B2A914E57A96FB5C AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT){0}INSERT INTO [00D69CC2-E6EC-4412-B2A9-14E57A96FB5C](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence FROM @TBL_00D69CC2E6EC4412B2A914E57A96FB5C TDT
							LEFT JOIN [00D69CC2-E6EC-4412-B2A9-14E57A96FB5C] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence";

                                     tempInsertQuery=@"INSERT INTO @TBL_00D69CC2E6EC4412B2A914E57A96FB5C(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)VALUES({0});";
                                     

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
                     
                                    case "744177F0-C5DD-4666-BE31-646818F67196":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_744177F0C5DD4666BE31646818F67196 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT){0}INSERT INTO [744177F0-C5DD-4666-BE31-646818F67196](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence FROM @TBL_744177F0C5DD4666BE31646818F67196 TDT
							LEFT JOIN [744177F0-C5DD-4666-BE31-646818F67196] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence";

                                     tempInsertQuery=@"INSERT INTO @TBL_744177F0C5DD4666BE31646818F67196(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)VALUES({0});";
                                     

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
                     
                                    case "1064BC8E-93B2-409C-BD15-01E2EBC35B41":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_1064BC8E93B2409CBD1501E2EBC35B41 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT){0}INSERT INTO [1064BC8E-93B2-409C-BD15-01E2EBC35B41](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence FROM @TBL_1064BC8E93B2409CBD1501E2EBC35B41 TDT
							LEFT JOIN [1064BC8E-93B2-409C-BD15-01E2EBC35B41] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence";

                                     tempInsertQuery=@"INSERT INTO @TBL_1064BC8E93B2409CBD1501E2EBC35B41(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)VALUES({0});";
                                     

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
                     
                                    case "D74F91B1-1C1A-47A6-BF5F-B731EB2F53FB":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_D74F91B11C1A47A6BF5FB731EB2F53FB AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT){0}INSERT INTO [D74F91B1-1C1A-47A6-BF5F-B731EB2F53FB](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence FROM @TBL_D74F91B11C1A47A6BF5FB731EB2F53FB TDT
							LEFT JOIN [D74F91B1-1C1A-47A6-BF5F-B731EB2F53FB] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence";

                                     tempInsertQuery=@"INSERT INTO @TBL_D74F91B11C1A47A6BF5FB731EB2F53FB(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)VALUES({0});";
                                     

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
                     
                                    case "1356A8F2-1947-4667-987D-2EA211B288A3":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_1356A8F219474667987D2EA211B288A3 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT){0}INSERT INTO [1356A8F2-1947-4667-987D-2EA211B288A3](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence FROM @TBL_1356A8F219474667987D2EA211B288A3 TDT
							LEFT JOIN [1356A8F2-1947-4667-987D-2EA211B288A3] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence";

                                     tempInsertQuery=@"INSERT INTO @TBL_1356A8F219474667987D2EA211B288A3(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)VALUES({0});";
                                     

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
                     
                                    case "A65EED98-D95D-45DF-9765-1BDBF01908AD":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_A65EED98D95D45DF97651BDBF01908AD AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT){0}INSERT INTO [A65EED98-D95D-45DF-9765-1BDBF01908AD](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence FROM @TBL_A65EED98D95D45DF97651BDBF01908AD TDT
							LEFT JOIN [A65EED98-D95D-45DF-9765-1BDBF01908AD] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence";

                                     tempInsertQuery=@"INSERT INTO @TBL_A65EED98D95D45DF97651BDBF01908AD(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)VALUES({0});";
                                     

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
                     

                                         case "00D69CC2-E6EC-4412-B2A9-14E57A96FB5C":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_00D69CC2E6EC4412B2A914E57A96FB5C AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT){0}INSERT INTO [00D69CC2-E6EC-4412-B2A9-14E57A96FB5C](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence FROM @TBL_00D69CC2E6EC4412B2A914E57A96FB5C TDT
							LEFT JOIN [00D69CC2-E6EC-4412-B2A9-14E57A96FB5C] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence";

                            tempInsertQuery=@"INSERT INTO @TBL_00D69CC2E6EC4412B2A914E57A96FB5C(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)VALUES({0});";

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

                                              case "744177F0-C5DD-4666-BE31-646818F67196":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_744177F0C5DD4666BE31646818F67196 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT){0}INSERT INTO [744177F0-C5DD-4666-BE31-646818F67196](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence FROM @TBL_744177F0C5DD4666BE31646818F67196 TDT
							LEFT JOIN [744177F0-C5DD-4666-BE31-646818F67196] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence";

                            tempInsertQuery=@"INSERT INTO @TBL_744177F0C5DD4666BE31646818F67196(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)VALUES({0});";

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

                                              case "1064BC8E-93B2-409C-BD15-01E2EBC35B41":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_1064BC8E93B2409CBD1501E2EBC35B41 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT){0}INSERT INTO [1064BC8E-93B2-409C-BD15-01E2EBC35B41](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence FROM @TBL_1064BC8E93B2409CBD1501E2EBC35B41 TDT
							LEFT JOIN [1064BC8E-93B2-409C-BD15-01E2EBC35B41] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence";

                            tempInsertQuery=@"INSERT INTO @TBL_1064BC8E93B2409CBD1501E2EBC35B41(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)VALUES({0});";

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

                                              case "D74F91B1-1C1A-47A6-BF5F-B731EB2F53FB":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_D74F91B11C1A47A6BF5FB731EB2F53FB AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT){0}INSERT INTO [D74F91B1-1C1A-47A6-BF5F-B731EB2F53FB](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence FROM @TBL_D74F91B11C1A47A6BF5FB731EB2F53FB TDT
							LEFT JOIN [D74F91B1-1C1A-47A6-BF5F-B731EB2F53FB] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence";

                            tempInsertQuery=@"INSERT INTO @TBL_D74F91B11C1A47A6BF5FB731EB2F53FB(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)VALUES({0});";

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

                                              case "1356A8F2-1947-4667-987D-2EA211B288A3":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_1356A8F219474667987D2EA211B288A3 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT){0}INSERT INTO [1356A8F2-1947-4667-987D-2EA211B288A3](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence FROM @TBL_1356A8F219474667987D2EA211B288A3 TDT
							LEFT JOIN [1356A8F2-1947-4667-987D-2EA211B288A3] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence";

                            tempInsertQuery=@"INSERT INTO @TBL_1356A8F219474667987D2EA211B288A3(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)VALUES({0});";

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

                                              case "A65EED98-D95D-45DF-9765-1BDBF01908AD":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_A65EED98D95D45DF97651BDBF01908AD AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT){0}INSERT INTO [A65EED98-D95D-45DF-9765-1BDBF01908AD](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence FROM @TBL_A65EED98D95D45DF97651BDBF01908AD TDT
							LEFT JOIN [A65EED98-D95D-45DF-9765-1BDBF01908AD] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence";

                            tempInsertQuery=@"INSERT INTO @TBL_A65EED98D95D45DF97651BDBF01908AD(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)VALUES({0});";

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
public class ISpaceB2EE67FA41C14A1BAB23466B572ACE72 : VirtualForm
{
IISpace iSpace = new ISpace();
AcDataISpaceB2EE67FA41C14A1BAB23466B572ACE72 acdataIspaceB2EE67FA41C14A1BAB23466B572ACE72=new AcDataISpaceB2EE67FA41C14A1BAB23466B572ACE72();
private void SubscribeFormEvents_root(ref Dictionary<string, ServiceElementData> ISpace)
{
try
{
base.WriteDebugInfo(@"Root-OnAfterFormLoad");
ISpace["M_Advanceformid"].Value=ISpace["gv_instanceid"].Value;
base.WriteDebugInfo(@"ISpace[""M_Advanceformid""].Value=ISpace[""gv_instanceid""].Value;");
ISpace["M_Advanceformid"].Value=ISpace["gv_instanceid"].Value;
base.WriteDebugInfo(@"ISpace[""M_Advanceformid""].Value=ISpace[""gv_instanceid""].Value;");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["MF_P1_ApplicationStatus"].Visible="false";ISpace["MFG_P2_ReimbursementDetailsId"].Visible="false";ISpace["MF_P1_EmployeeBasicInfoId"].Visible="false";ISpace["MFG_P3_FundDetailsId"].Visible="true";ISpace["MFG_P2_BillDocument"].Visible="false";ISpace["MF_P1_UpdatedBy"].Visible="false";ISpace["MF_P1_Initiatedon"].Visible="false";ISpace["MFG_P3_ReimbursementId"].Visible="false";ISpace["MFG_P2_BillDate"].Visible="true";ISpace["MF_P1_TotalAmount"].Visible="true";ISpace["MF_P1_InitatedBy"].Visible="false";ISpace["MFG_P2_ReimbursementId"].Visible="false";ISpace["MFG_P2_BillNo"].Visible="true";ISpace["MFG_P2_Amount"].Visible="true";ISpace["MF_P1_UpdatedOn"].Visible="false";ISpace["MFG_P3_FundTypeId"].Visible="true";ISpace["MFG_P3_ProjectDetailsId"].Visible="true";ISpace["MFG_P3_Amount"].Visible="false";ISpace["MFG_P2_ItemDescription"].Visible="true";ISpace["MF_P1_ReimbursementId"].Visible="false";ISpace["MFG_P3_BudgetHeadId"].Visible="true";
base.WriteDebugInfo(@"ISpace[""MF_P1_ApplicationStatus""].Visible=""false"";ISpace[""MFG_P2_ReimbursementDetailsId""].Visible=""false"";ISpace[""MF_P1_EmployeeBasicInfoId""].Visible=""false"";ISpace[""MFG_P3_FundDetailsId""].Visible=""true"";ISpace[""MFG_P2_BillDocument""].Visible=""false"";ISpace[""MF_P1_UpdatedBy""].Visible=""false"";ISpace[""MF_P1_Initiatedon""].Visible=""false"";ISpace[""MFG_P3_ReimbursementId""].Visible=""false"";ISpace[""MFG_P2_BillDate""].Visible=""true"";ISpace[""MF_P1_TotalAmount""].Visible=""true"";ISpace[""MF_P1_InitatedBy""].Visible=""false"";ISpace[""MFG_P2_ReimbursementId""].Visible=""false"";ISpace[""MFG_P2_BillNo""].Visible=""true"";ISpace[""MFG_P2_Amount""].Visible=""true"";ISpace[""MF_P1_UpdatedOn""].Visible=""false"";ISpace[""MFG_P3_FundTypeId""].Visible=""true"";ISpace[""MFG_P3_ProjectDetailsId""].Visible=""true"";ISpace[""MFG_P3_Amount""].Visible=""false"";ISpace[""MFG_P2_ItemDescription""].Visible=""true"";ISpace[""MF_P1_ReimbursementId""].Visible=""false"";ISpace[""MFG_P3_BudgetHeadId""].Visible=""true"";");
ISpace["MFG_P3_ProjectDetailsId"].Visible="false";ISpace["MFG_P3_Amount"].Visible="false";ISpace["MFG_P3_BudgetHeadId"].Visible="false";
base.WriteDebugInfo(@"ISpace[""MFG_P3_ProjectDetailsId""].Visible=""false"";ISpace[""MFG_P3_Amount""].Visible=""false"";ISpace[""MFG_P3_BudgetHeadId""].Visible=""false"";");
ISpace["MG_P2_BillNo"].Visible="true";ISpace["MG_P2_BillDocument"].Visible="false";ISpace["MG_P2_ReimbursementDetailsId"].Visible="false";ISpace["MG_P2_ReimbursementId"].Visible="false";ISpace["MG_P2_ItemDescription"].Visible="true";ISpace["MG_P2_BillDate"].Visible="true";ISpace["MG_P2_Amount"].Visible="true";
base.WriteDebugInfo(@"ISpace[""MG_P2_BillNo""].Visible=""true"";ISpace[""MG_P2_BillDocument""].Visible=""false"";ISpace[""MG_P2_ReimbursementDetailsId""].Visible=""false"";ISpace[""MG_P2_ReimbursementId""].Visible=""false"";ISpace[""MG_P2_ItemDescription""].Visible=""true"";ISpace[""MG_P2_BillDate""].Visible=""true"";ISpace[""MG_P2_Amount""].Visible=""true"";");
ISpace["MG_P3_ProjectDetailsId"].Visible="true";ISpace["MG_P3_BudgetHeadId"].Visible="true";ISpace["MG_P3_FundTypeId"].Visible="true";ISpace["MG_P3_FundDetailsId"].Visible="false";ISpace["MG_P3_Amount"].Visible="true";ISpace["MG_P3_ReimbursementId"].Visible="false";
base.WriteDebugInfo(@"ISpace[""MG_P3_ProjectDetailsId""].Visible=""true"";ISpace[""MG_P3_BudgetHeadId""].Visible=""true"";ISpace[""MG_P3_FundTypeId""].Visible=""true"";ISpace[""MG_P3_FundDetailsId""].Visible=""false"";ISpace[""MG_P3_Amount""].Visible=""true"";ISpace[""MG_P3_ReimbursementId""].Visible=""false"";");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC [GetEmployeeUserContextDetails] "@@gv_UserId"");

var querySource10ACD400F60043A6B4F244863C61AA73 =GetQueryExpressionDataSource("10ACD400-F600-43A6-B4F2-44863C61AA73");
Dictionary<short,object> result10ACD400F60043A6B4F244863C61AA73=iSpace.ExecuteQuery(querySource10ACD400F60043A6B4F244863C61AA73,@"EXEC [GetEmployeeUserContextDetails] "" + ISpace["gv_userid"].Value + @""",false);

base.WriteDebugInfo(@"var querySource10ACD400F60043A6B4F244863C61AA73 =GetQueryExpressionDataSource(""10ACD400-F600-43A6-B4F2-44863C61AA73"");Dictionary<short,object> result10ACD400F60043A6B4F244863C61AA73=iSpace.ExecuteQuery(querySource10ACD400F60043A6B4F244863C61AA73,@""EXEC [GetEmployeeUserContextDetails] """" + ISpace[""gv_userid""].Value + @"""""",false);");
base.WriteDebugInfo(@"");

if((result10ACD400F60043A6B4F244863C61AA73!=null) && (result10ACD400F60043A6B4F244863C61AA73.Count!=0))
{
if(result10ACD400F60043A6B4F244863C61AA73.ContainsKey(1))
ISpace["UC_EmployeeId"].Value = result10ACD400F60043A6B4F244863C61AA73[1];
if(result10ACD400F60043A6B4F244863C61AA73.ContainsKey(6))
ISpace["UC_Department"].Value = result10ACD400F60043A6B4F244863C61AA73[6];
if(result10ACD400F60043A6B4F244863C61AA73.ContainsKey(0))
ISpace["UC_EmployeeBaicInfoId"].Value = result10ACD400F60043A6B4F244863C61AA73[0];
if(result10ACD400F60043A6B4F244863C61AA73.ContainsKey(7))
ISpace["UC_Designation"].Value = result10ACD400F60043A6B4F244863C61AA73[7];
if(result10ACD400F60043A6B4F244863C61AA73.ContainsKey(9))
ISpace["UC_DOB"].Value = result10ACD400F60043A6B4F244863C61AA73[9];
if(result10ACD400F60043A6B4F244863C61AA73.ContainsKey(4))
ISpace["UC_DOJ"].Value = result10ACD400F60043A6B4F244863C61AA73[4];
if(result10ACD400F60043A6B4F244863C61AA73.ContainsKey(12))
ISpace["UC_Paylevel"].Value = result10ACD400F60043A6B4F244863C61AA73[12];
if(result10ACD400F60043A6B4F244863C61AA73.ContainsKey(10))
ISpace["UC_DOR"].Value = result10ACD400F60043A6B4F244863C61AA73[10];
if(result10ACD400F60043A6B4F244863C61AA73.ContainsKey(11))
ISpace["UC_Grade"].Value = result10ACD400F60043A6B4F244863C61AA73[11];
if(result10ACD400F60043A6B4F244863C61AA73.ContainsKey(3))
ISpace["UC_EmailId"].Value = result10ACD400F60043A6B4F244863C61AA73[3];
if(result10ACD400F60043A6B4F244863C61AA73.ContainsKey(2))
ISpace["UC_Name"].Value = result10ACD400F60043A6B4F244863C61AA73[2];
if(result10ACD400F60043A6B4F244863C61AA73.ContainsKey(5))
ISpace["UC_PhoneNumber"].Value = result10ACD400F60043A6B4F244863C61AA73[5];
}
else{
ISpace["UC_EmployeeId"].Value = null;ISpace["UC_Department"].Value = null;ISpace["UC_EmployeeBaicInfoId"].Value = null;ISpace["UC_Designation"].Value = null;ISpace["UC_DOB"].Value = null;ISpace["UC_DOJ"].Value = null;ISpace["UC_Paylevel"].Value = null;ISpace["UC_DOR"].Value = null;ISpace["UC_Grade"].Value = null;ISpace["UC_EmailId"].Value = null;ISpace["UC_Name"].Value = null;ISpace["UC_PhoneNumber"].Value = null;
}
}
ISpace["MFG_P3_FundTypeId"].rElemData=iSpace.Reload(ISpace["MFG_P3_FundTypeId"].Value,@"exec SP_GetDistrubitionDetails 4,"" + ISpace["M_PackageProcessMapId"].Value + @"","",""","9ADED37B-CD11-426B-AF16-DEAC75685EF5");
base.WriteDebugInfo(@"ISpace[""MFG_P3_FundTypeId""].rElemData=iSpace.Reload(ISpace[""MFG_P3_FundTypeId""].Value,@""exec SP_GetDistrubitionDetails 4,"""" + ISpace[""M_PackageProcessMapId""].Value + @"""","""","""""",""9ADED37B-CD11-426B-AF16-DEAC75685EF5"");");



{
base.WriteDebugInfo(@"");
}


base.WriteDebugInfo(@"");
ISpace["M_SourceActivityMapId"].Value=ISpace["gv_activitymapid"].Value;
base.WriteDebugInfo(@"ISpace[""M_SourceActivityMapId""].Value=ISpace[""gv_activitymapid""].Value;");
ISpace["M_PackageProcessMapId"].Value=ISpace["gv_processmapid"].Value;
base.WriteDebugInfo(@"ISpace[""M_PackageProcessMapId""].Value=ISpace[""gv_processmapid""].Value;");
ISpace["M_InstanceId"].Value=ISpace["gv_instanceid"].Value;
base.WriteDebugInfo(@"ISpace[""M_InstanceId""].Value=ISpace[""gv_instanceid""].Value;");
ISpace["M_IsSourceStep"].Value=0;
base.WriteDebugInfo(@"ISpace[""M_IsSourceStep""].Value=0;");


base.WriteDebugInfo(@"EXEC GetDestinationDetails "#M_SourceActivityMapId"");

var querySource770E6D040AD041D692DE50A2A8E84E7D =GetQueryExpressionDataSource("770E6D04-0AD0-41D6-92DE-50A2A8E84E7D");
Dictionary<short,object> result770E6D040AD041D692DE50A2A8E84E7D=iSpace.ExecuteQuery(querySource770E6D040AD041D692DE50A2A8E84E7D,@"EXEC GetDestinationDetails "" + ISpace["M_SourceActivityMapId"].Value + @""",false);

base.WriteDebugInfo(@"var querySource770E6D040AD041D692DE50A2A8E84E7D =GetQueryExpressionDataSource(""770E6D04-0AD0-41D6-92DE-50A2A8E84E7D"");Dictionary<short,object> result770E6D040AD041D692DE50A2A8E84E7D=iSpace.ExecuteQuery(querySource770E6D040AD041D692DE50A2A8E84E7D,@""EXEC GetDestinationDetails """" + ISpace[""M_SourceActivityMapId""].Value + @"""""",false);");
base.WriteDebugInfo(@"");

if((result770E6D040AD041D692DE50A2A8E84E7D!=null) && (result770E6D040AD041D692DE50A2A8E84E7D.Count!=0))
{
if(result770E6D040AD041D692DE50A2A8E84E7D.ContainsKey(2))
ISpace["M_NextStage"].Value = result770E6D040AD041D692DE50A2A8E84E7D[2];
if(result770E6D040AD041D692DE50A2A8E84E7D.ContainsKey(0))
ISpace["M_DestinationActivityId"].Value = result770E6D040AD041D692DE50A2A8E84E7D[0];
if(result770E6D040AD041D692DE50A2A8E84E7D.ContainsKey(5))
ISpace["MF_P1_Remarks"].Value = result770E6D040AD041D692DE50A2A8E84E7D[5];
}
else{
ISpace["M_NextStage"].Value = null;ISpace["M_DestinationActivityId"].Value = null;ISpace["MF_P1_Remarks"].Value = null;
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"SELECT CONCAT("IITDH/SRC/",Right(Year(getdate()),2),"-",Right(Year(getdate()),2)+1,"/TA/",NEXT VALUE FOR TemporarySeq)");

var querySourceA58A83FE0FF74A0C8C899744967E99A5 =GetQueryExpressionDataSource("A58A83FE-0FF7-4A0C-8C89-9744967E99A5");
Dictionary<short,object> resultA58A83FE0FF74A0C8C899744967E99A5=iSpace.ExecuteQuery(querySourceA58A83FE0FF74A0C8C899744967E99A5,@"SELECT CONCAT("IITDH/SRC/",Right(Year(getdate()),2),"-",Right(Year(getdate()),2)+1,"/TA/",NEXT VALUE FOR TemporarySeq)",false);

base.WriteDebugInfo(@"var querySourceA58A83FE0FF74A0C8C899744967E99A5 =GetQueryExpressionDataSource(""A58A83FE-0FF7-4A0C-8C89-9744967E99A5"");Dictionary<short,object> resultA58A83FE0FF74A0C8C899744967E99A5=iSpace.ExecuteQuery(querySourceA58A83FE0FF74A0C8C899744967E99A5,@""SELECT CONCAT(""IITDH/SRC/"",Right(Year(getdate()),2),""-"",Right(Year(getdate()),2)+1,""/TA/"",NEXT VALUE FOR TemporarySeq)"",false);");
base.WriteDebugInfo(@"");

if((resultA58A83FE0FF74A0C8C899744967E99A5!=null) && (resultA58A83FE0FF74A0C8C899744967E99A5.Count!=0))
{
if(resultA58A83FE0FF74A0C8C899744967E99A5.ContainsKey(0))
ISpace["M_ReferenceNo"].Value = resultA58A83FE0FF74A0C8C899744967E99A5[0];
}
else{
ISpace["M_ReferenceNo"].Value = null;
}
ISpace["Subject"].Value=ISpace["M_ReferenceNo"].Value;
base.WriteDebugInfo(@"ISpace[""Subject""].Value=ISpace[""M_ReferenceNo""].Value;");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["MFG_P2_BillDate"].Man=true;ISpace["MF_P1_TotalAmount"].Man=true;ISpace["MFG_P2_BillNo"].Man=true;ISpace["Declaration"].Man=true;ISpace["MFG_P2_Amount"].Man=true;ISpace["MFG_P3_FundTypeId"].Man=true;ISpace["MFG_P3_Amount"].Man=true;ISpace["MFG_P2_ItemDescription"].Man=true;
base.WriteDebugInfo(@"ISpace[""MFG_P2_BillDate""].Man=true;ISpace[""MF_P1_TotalAmount""].Man=true;ISpace[""MFG_P2_BillNo""].Man=true;ISpace[""Declaration""].Man=true;ISpace[""MFG_P2_Amount""].Man=true;ISpace[""MFG_P3_FundTypeId""].Man=true;ISpace[""MFG_P3_Amount""].Man=true;ISpace[""MFG_P2_ItemDescription""].Man=true;");
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_submitform (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"SubmitForm-OnClick");
base.WriteDebugInfo(@"Entering DomainDataMap for Remarks Domain");
var RemarksDomain_repoObj = new RepositoryMapper(DbTypes.SQLServer);


var ActivityTrailLogDetailsRemarksDomaintableObj = new RepositoryTable("ActivityTrailLogDetails");
  ActivityTrailLogDetailsRemarksDomaintableObj.AppConnectionSettingsId  ="9ADED37B-CD11-426B-AF16-DEAC75685EF5";ActivityTrailLogDetailsRemarksDomaintableObj.ProofConnectionId = "C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0)";
var RemarksDomain_ActivityTrailLogDetails_rows = GetElementClientData(ISpace["InstanceId"].Value,"6B463D69-64AB-468E-B2E3-DB12E6B90014");

if(RemarksDomain_ActivityTrailLogDetails_rows!=null && RemarksDomain_ActivityTrailLogDetails_rows.Count>0){
var RemarksDomain_ActivityTrailLogDetails_rowsObj = new List<RepositoryRow>();
foreach(var rows in RemarksDomain_ActivityTrailLogDetails_rows){RepositoryRow repositoryRowObj = null;string elementData = null;RepositoryColumn repositoryColumnObj = null;if(rows !=null){ var ActivityTrailLogDetails_colObj = new List<RepositoryColumn>();repositoryRowObj= new RepositoryRow();//var myByte = (byte)rowData.Value.RwSt;//repositoryRowObj.RowState=(RepositoryRowState)myByte;

if(rows.ContainsKey("5354760A-9EAC-491E-BAB1-C3614187A9BE"))     elementData = rows["5354760A-9EAC-491E-BAB1-C3614187A9BE"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ProcessedInProgressFlag",false,false,5);
if(repositoryColumnObj!=null)ActivityTrailLogDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-M_IsSourceStep not found");}

elementData = CurrentDate().ToString() ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Updatedon",false,false,8);
if(repositoryColumnObj!=null)ActivityTrailLogDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-CurrentDate not found");}

if(rows.ContainsKey("D7BB255E-9A01-4B5B-AE06-CC4D6E088D52"))     elementData = rows["D7BB255E-9A01-4B5B-AE06-CC4D6E088D52"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"InstanceID",false,false,9);
if(repositoryColumnObj!=null)ActivityTrailLogDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-M_InstanceId not found");}

elementData = ISpace["gv_UserId"].Value != null? Convert.ToString(ISpace["gv_UserId"].Value):null ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Updatedby",false,false,6);
if(repositoryColumnObj!=null)ActivityTrailLogDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-gv_UserId not found");}

if(rows.ContainsKey("6DB9BC45-F167-4D8A-9596-1DBA9872F253"))     elementData = rows["6DB9BC45-F167-4D8A-9596-1DBA9872F253"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"DestinationActivityMapID",false,false,9);
if(repositoryColumnObj!=null)ActivityTrailLogDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-M_DestinationActivityId not found");}

elementData = ISpace["gv_UserName"].Value != null? Convert.ToString(ISpace["gv_UserName"].Value):null ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"RemarksBy",false,false,9);
if(repositoryColumnObj!=null)ActivityTrailLogDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-gv_UserName not found");}

elementData = ISpace["gv_ActivityName"].Value != null? Convert.ToString(ISpace["gv_ActivityName"].Value):null ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ActivityName",false,false,9);
if(repositoryColumnObj!=null)ActivityTrailLogDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-gv_ActivityName not found");}

if(rows.ContainsKey("F78328FF-68D9-45E9-BC40-27CD650C9D6C"))     elementData = rows["F78328FF-68D9-45E9-BC40-27CD650C9D6C"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Remarks",false,false,9);
if(repositoryColumnObj!=null)ActivityTrailLogDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MF_P1_Remarks not found");}

elementData = ISpace["gv_TenantId"].Value != null? Convert.ToString(ISpace["gv_TenantId"].Value):null ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"TenantID",false,false,9);
if(repositoryColumnObj!=null)ActivityTrailLogDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-gv_TenantId not found");}

elementData = Guid.NewGuid().ToString();if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"TrailLogId",true,false,9);
if(repositoryColumnObj!=null)ActivityTrailLogDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-GUID not found");}

if(rows.ContainsKey("52A564C4-B656-4F43-B6F3-E592002351F6"))     elementData = rows["52A564C4-B656-4F43-B6F3-E592002351F6"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"SourceActivityMapID",false,false,9);
if(repositoryColumnObj!=null)ActivityTrailLogDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-M_SourceActivityMapId not found");}

elementData = CurrentDate().ToString() ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"RemarksOn",false,false,8);
if(repositoryColumnObj!=null)ActivityTrailLogDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-CurrentDate not found");}
repositoryRowObj.Columns=ActivityTrailLogDetails_colObj;
RemarksDomain_ActivityTrailLogDetails_rowsObj.Add(repositoryRowObj);
}}

ActivityTrailLogDetailsRemarksDomaintableObj.Rows=RemarksDomain_ActivityTrailLogDetails_rowsObj;
var RemarksDomain_repoObj_status_ActivityTrailLogDetails = RemarksDomain_repoObj.Execute(DomainOperationTypes.CreateOrUpdate,ref ActivityTrailLogDetailsRemarksDomaintableObj);if(!RemarksDomain_repoObj_status_ActivityTrailLogDetails) throw new Exception("Error in Execute Domain Data Map");}
base.WriteDebugInfo(@"Exiting DomainDataMap for Remarks Domain");
if(IsNullOrEmpty(ISpace["Declaration"].Value))
{
base.WriteDebugInfo(@"if(IsNullOrEmpty(ISpace[""Declaration""].Value))");
ISpace["Message"].Value=@"Select the declaration";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Select the declaration"";");
return;
base.WriteDebugInfo(@"return;");
}
if(ISpace["M_SaveDomainData"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""M_SaveDomainData""].Value==1)");
ISpace["MF_P1_ApplicationStatus"].Value="A";
base.WriteDebugInfo(@"ISpace[""MF_P1_ApplicationStatus""].Value=""A"";");
}
if(ISpace["M_SaveDomainData"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""M_SaveDomainData""].Value==1)");
base.WriteDebugInfo(@"Entering DomainDataMap for Project Advance Details REPO 1");
var ProjectAdvanceDetailsREPO1_repoObj = new RepositoryMapper(DbTypes.SQLServer);


var ProjectAdvanceFormProjectAdvanceDetailsREPO1tableObj = new RepositoryTable("ProjectAdvanceForm");
  ProjectAdvanceFormProjectAdvanceDetailsREPO1tableObj.AppConnectionSettingsId  ="3A103712-5244-4427-B2B6-1C4E046FD337";ProjectAdvanceFormProjectAdvanceDetailsREPO1tableObj.ProofConnectionId = "C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0)";
var ProjectAdvanceDetailsREPO1_ProjectAdvanceForm_rows = GetElementClientData(ISpace["InstanceId"].Value,"6B463D69-64AB-468E-B2E3-DB12E6B90014");

if(ProjectAdvanceDetailsREPO1_ProjectAdvanceForm_rows!=null && ProjectAdvanceDetailsREPO1_ProjectAdvanceForm_rows.Count>0){
var ProjectAdvanceDetailsREPO1_ProjectAdvanceForm_rowsObj = new List<RepositoryRow>();
foreach(var rows in ProjectAdvanceDetailsREPO1_ProjectAdvanceForm_rows){RepositoryRow repositoryRowObj = null;string elementData = null;RepositoryColumn repositoryColumnObj = null;if(rows !=null){ var ProjectAdvanceForm_colObj = new List<RepositoryColumn>();repositoryRowObj= new RepositoryRow();//var myByte = (byte)rowData.Value.RwSt;//repositoryRowObj.RowState=(RepositoryRowState)myByte;

if(rows.ContainsKey("72A0167C-47E6-4BBA-964A-D18B4C2724BE"))     elementData = rows["72A0167C-47E6-4BBA-964A-D18B4C2724BE"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"AdvanceFormId",true,false,9);
if(repositoryColumnObj!=null)ProjectAdvanceForm_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-M_Advanceformid not found");}

elementData = ISpace["gv_UserName"].Value != null? Convert.ToString(ISpace["gv_UserName"].Value):null ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"InitatedBy",false,false,9);
if(repositoryColumnObj!=null)ProjectAdvanceForm_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-gv_UserName not found");}

elementData = ISpace["gv_UserName"].Value != null? Convert.ToString(ISpace["gv_UserName"].Value):null ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"UpdatedBy",false,false,9);
if(repositoryColumnObj!=null)ProjectAdvanceForm_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-gv_UserName not found");}

if(rows.ContainsKey("16BFBC4B-9CB5-4677-AAE8-85CE6C7260E5"))     elementData = rows["16BFBC4B-9CB5-4677-AAE8-85CE6C7260E5"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ApplicationStatus",false,false,9);
if(repositoryColumnObj!=null)ProjectAdvanceForm_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MF_P1_ApplicationStatus not found");}

if(rows.ContainsKey("329D5240-1DBD-433E-A8EB-0F29F5AA668C"))     elementData = rows["329D5240-1DBD-433E-A8EB-0F29F5AA668C"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"EmployeeBasicInfoId",false,false,9);
if(repositoryColumnObj!=null)ProjectAdvanceForm_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-UC_EmployeeBaicInfoId not found");}

if(rows.ContainsKey("68A2EC13-D240-4EBC-8828-E795581544DA"))     elementData = rows["68A2EC13-D240-4EBC-8828-E795581544DA"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"TotalAmount",false,false,3);
if(repositoryColumnObj!=null)ProjectAdvanceForm_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MF_P1_TotalAmount not found");}

elementData = CurrentDate().ToString() ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Initiatedon",false,false,8);
if(repositoryColumnObj!=null)ProjectAdvanceForm_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-CurrentDate not found");}

elementData = CurrentDate().ToString() ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"UpdatedOn",false,false,8);
if(repositoryColumnObj!=null)ProjectAdvanceForm_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-CurrentDate not found");}
repositoryRowObj.Columns=ProjectAdvanceForm_colObj;
ProjectAdvanceDetailsREPO1_ProjectAdvanceForm_rowsObj.Add(repositoryRowObj);
}}

ProjectAdvanceFormProjectAdvanceDetailsREPO1tableObj.Rows=ProjectAdvanceDetailsREPO1_ProjectAdvanceForm_rowsObj;
var ProjectAdvanceDetailsREPO1_repoObj_status_ProjectAdvanceForm = ProjectAdvanceDetailsREPO1_repoObj.Execute(DomainOperationTypes.CreateOrUpdate,ref ProjectAdvanceFormProjectAdvanceDetailsREPO1tableObj);if(!ProjectAdvanceDetailsREPO1_repoObj_status_ProjectAdvanceForm) throw new Exception("Error in Execute Domain Data Map");}
base.WriteDebugInfo(@"Exiting DomainDataMap for Project Advance Details REPO 1");
base.WriteDebugInfo(@"Entering DomainDataMap for Project Advance Details REPO 2");
var ProjectAdvanceDetailsREPO2_repoObj = new RepositoryMapper(DbTypes.SQLServer);


var ProjectAdvanceFundDetailsProjectAdvanceDetailsREPO2tableObj = new RepositoryTable("ProjectAdvanceFundDetails");
  ProjectAdvanceFundDetailsProjectAdvanceDetailsREPO2tableObj.AppConnectionSettingsId  ="3A103712-5244-4427-B2B6-1C4E046FD337";ProjectAdvanceFundDetailsProjectAdvanceDetailsREPO2tableObj.ProofConnectionId = "C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0)";
var ProjectAdvanceDetailsREPO2_ProjectAdvanceFundDetails_rows = GetElementClientData(ISpace["InstanceId"].Value,"00D69CC2-E6EC-4412-B2A9-14E57A96FB5C");

if(ProjectAdvanceDetailsREPO2_ProjectAdvanceFundDetails_rows!=null && ProjectAdvanceDetailsREPO2_ProjectAdvanceFundDetails_rows.Count>0){
var ProjectAdvanceDetailsREPO2_ProjectAdvanceFundDetails_rowsObj = new List<RepositoryRow>();
foreach(var rows in ProjectAdvanceDetailsREPO2_ProjectAdvanceFundDetails_rows){RepositoryRow repositoryRowObj = null;string elementData = null;RepositoryColumn repositoryColumnObj = null;if(rows !=null){ var ProjectAdvanceFundDetails_colObj = new List<RepositoryColumn>();repositoryRowObj= new RepositoryRow();//var myByte = (byte)rowData.Value.RwSt;//repositoryRowObj.RowState=(RepositoryRowState)myByte;

if(rows.ContainsKey("E20A9876-034C-49BC-A309-26338AAD45BD"))     elementData = rows["E20A9876-034C-49BC-A309-26338AAD45BD"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"AdvanceFormId",false,false,9);
if(repositoryColumnObj!=null)ProjectAdvanceFundDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MG_P3_Advanceformid not found");}

if(rows.ContainsKey("B24F329A-C286-4040-ABD2-B67B5AE4F7BE"))     elementData = rows["B24F329A-C286-4040-ABD2-B67B5AE4F7BE"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"FundDetailsId",true,false,9);
if(repositoryColumnObj!=null)ProjectAdvanceFundDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MG_P3_FundDetailsId not found");}

if(rows.ContainsKey("4F81555E-3503-43B3-AD28-23293B41E926"))     elementData = rows["4F81555E-3503-43B3-AD28-23293B41E926"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ProjectDetailsId",false,false,9);
if(repositoryColumnObj!=null)ProjectAdvanceFundDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MG_P3_ProjectDetailsId not found");}

if(rows.ContainsKey("CCBB2219-451D-4EAE-BA26-1C16A9B0FF7D"))     elementData = rows["CCBB2219-451D-4EAE-BA26-1C16A9B0FF7D"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Amount",false,false,3);
if(repositoryColumnObj!=null)ProjectAdvanceFundDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MG_P3_Amount not found");}

if(rows.ContainsKey("8F687AA1-A6B1-4250-9948-DBAF2D40AB51"))     elementData = rows["8F687AA1-A6B1-4250-9948-DBAF2D40AB51"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"BudgetHeadId",false,false,9);
if(repositoryColumnObj!=null)ProjectAdvanceFundDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MG_P3_BudgetHeadId not found");}

if(rows.ContainsKey("99E459F3-F338-40A6-A1E3-1F7AD7A198CD"))     elementData = rows["99E459F3-F338-40A6-A1E3-1F7AD7A198CD"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"FundTypeId",false,false,6);
if(repositoryColumnObj!=null)ProjectAdvanceFundDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MG_P3_FundTypeId not found");}
repositoryRowObj.Columns=ProjectAdvanceFundDetails_colObj;
ProjectAdvanceDetailsREPO2_ProjectAdvanceFundDetails_rowsObj.Add(repositoryRowObj);
}}

ProjectAdvanceFundDetailsProjectAdvanceDetailsREPO2tableObj.Rows=ProjectAdvanceDetailsREPO2_ProjectAdvanceFundDetails_rowsObj;
var ProjectAdvanceDetailsREPO2_repoObj_status_ProjectAdvanceFundDetails = ProjectAdvanceDetailsREPO2_repoObj.Execute(DomainOperationTypes.CreateOrUpdate,ref ProjectAdvanceFundDetailsProjectAdvanceDetailsREPO2tableObj);if(!ProjectAdvanceDetailsREPO2_repoObj_status_ProjectAdvanceFundDetails) throw new Exception("Error in Execute Domain Data Map");}
base.WriteDebugInfo(@"Exiting DomainDataMap for Project Advance Details REPO 2");
base.WriteDebugInfo(@"Entering DomainDataMap for Project Advance Details REPO 3");
var ProjectAdvanceDetailsREPO3_repoObj = new RepositoryMapper(DbTypes.SQLServer);


var ProjectAdvanceRequestDetailsProjectAdvanceDetailsREPO3tableObj = new RepositoryTable("ProjectAdvanceRequestDetails");
  ProjectAdvanceRequestDetailsProjectAdvanceDetailsREPO3tableObj.AppConnectionSettingsId  ="3A103712-5244-4427-B2B6-1C4E046FD337";ProjectAdvanceRequestDetailsProjectAdvanceDetailsREPO3tableObj.ProofConnectionId = "C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0)";
var ProjectAdvanceDetailsREPO3_ProjectAdvanceRequestDetails_rows = GetElementClientData(ISpace["InstanceId"].Value,"1356A8F2-1947-4667-987D-2EA211B288A3");

if(ProjectAdvanceDetailsREPO3_ProjectAdvanceRequestDetails_rows!=null && ProjectAdvanceDetailsREPO3_ProjectAdvanceRequestDetails_rows.Count>0){
var ProjectAdvanceDetailsREPO3_ProjectAdvanceRequestDetails_rowsObj = new List<RepositoryRow>();
foreach(var rows in ProjectAdvanceDetailsREPO3_ProjectAdvanceRequestDetails_rows){RepositoryRow repositoryRowObj = null;string elementData = null;RepositoryColumn repositoryColumnObj = null;if(rows !=null){ var ProjectAdvanceRequestDetails_colObj = new List<RepositoryColumn>();repositoryRowObj= new RepositoryRow();//var myByte = (byte)rowData.Value.RwSt;//repositoryRowObj.RowState=(RepositoryRowState)myByte;

if(rows.ContainsKey("04D90722-37D7-40B0-96B6-D6CA55ABA8F2"))     elementData = rows["04D90722-37D7-40B0-96B6-D6CA55ABA8F2"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ExpenseDetails",false,false,9);
if(repositoryColumnObj!=null)ProjectAdvanceRequestDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MGA_DetailsofExpenses not found");}

if(rows.ContainsKey("B1EB21F5-30E2-4DB3-B72E-E6BB3E4A1D2B"))     elementData = rows["B1EB21F5-30E2-4DB3-B72E-E6BB3E4A1D2B"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ItemDescription",false,false,9);
if(repositoryColumnObj!=null)ProjectAdvanceRequestDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MGA_Description not found");}

if(rows.ContainsKey("8E8892C8-B328-42D2-A630-B8A2C3C4D26B"))     elementData = rows["8E8892C8-B328-42D2-A630-B8A2C3C4D26B"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Amount",false,false,3);
if(repositoryColumnObj!=null)ProjectAdvanceRequestDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MGA_Amount not found");}

if(rows.ContainsKey("67C65E87-8293-495E-97A2-E7431BF75D69"))     elementData = rows["67C65E87-8293-495E-97A2-E7431BF75D69"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"RequestDetailsId",true,false,9);
if(repositoryColumnObj!=null)ProjectAdvanceRequestDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MGA_RequestDetailsId not found");}

if(rows.ContainsKey("6E5FD9F2-E29C-4922-B6C5-78C591A395A6"))     elementData = rows["6E5FD9F2-E29C-4922-B6C5-78C591A395A6"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"AdvanceFormId",false,false,9);
if(repositoryColumnObj!=null)ProjectAdvanceRequestDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MGA_AdvanceFormId not found");}
repositoryRowObj.Columns=ProjectAdvanceRequestDetails_colObj;
ProjectAdvanceDetailsREPO3_ProjectAdvanceRequestDetails_rowsObj.Add(repositoryRowObj);
}}

ProjectAdvanceRequestDetailsProjectAdvanceDetailsREPO3tableObj.Rows=ProjectAdvanceDetailsREPO3_ProjectAdvanceRequestDetails_rowsObj;
var ProjectAdvanceDetailsREPO3_repoObj_status_ProjectAdvanceRequestDetails = ProjectAdvanceDetailsREPO3_repoObj.Execute(DomainOperationTypes.CreateOrUpdate,ref ProjectAdvanceRequestDetailsProjectAdvanceDetailsREPO3tableObj);if(!ProjectAdvanceDetailsREPO3_repoObj_status_ProjectAdvanceRequestDetails) throw new Exception("Error in Execute Domain Data Map");}
base.WriteDebugInfo(@"Exiting DomainDataMap for Project Advance Details REPO 3");
}
ISpace["Subject"].Value="Temporary Advance";
base.WriteDebugInfo(@"ISpace[""Subject""].Value=""Temporary Advance"";");
ISpace["SetDestinationTo"].Value=ISpace["M_DestinationActivityId"].Value;
base.WriteDebugInfo(@"ISpace[""SetDestinationTo""].Value=ISpace[""M_DestinationActivityId""].Value;");
base.WriteDebugInfo(@"#ReimbursementFundDetails[Rows]");
iSpace.GetLoopExpressionData("ReimbursementFundDetails",ref ISpace);

foreach(var gridChild in ISpace["ReimbursementFundDetails"].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 

base.WriteDebugInfo(@"EXEC [UpsertProjectBudgetDetails] 5,"#MG_P3_ProjectDetailsId","","#MG_P3_Amount","#MG_P3_BudgetHeadId",1,"#MG_P3_FundTypeId"");

var querySource75E44CDA64284B8E87579CF0529D0DC9 =GetQueryExpressionDataSource("75E44CDA-6428-4B8E-8757-9CF0529D0DC9");
Dictionary<short,object> result75E44CDA64284B8E87579CF0529D0DC9=iSpace.ExecuteQuery(querySource75E44CDA64284B8E87579CF0529D0DC9,@"EXEC [UpsertProjectBudgetDetails] 5,"" + ISpace["MG_P3_ProjectDetailsId"].Value + @"","","" + ISpace["MG_P3_Amount"].Value + @"","" + ISpace["MG_P3_BudgetHeadId"].Value + @"",1,"" + ISpace["MG_P3_FundTypeId"].Value + @""",false);

base.WriteDebugInfo(@"var querySource75E44CDA64284B8E87579CF0529D0DC9 =GetQueryExpressionDataSource(""75E44CDA-6428-4B8E-8757-9CF0529D0DC9"");Dictionary<short,object> result75E44CDA64284B8E87579CF0529D0DC9=iSpace.ExecuteQuery(querySource75E44CDA64284B8E87579CF0529D0DC9,@""EXEC [UpsertProjectBudgetDetails] 5,"""" + ISpace[""MG_P3_ProjectDetailsId""].Value + @"""","""","""" + ISpace[""MG_P3_Amount""].Value + @"""","""" + ISpace[""MG_P3_BudgetHeadId""].Value + @"""",1,"""" + ISpace[""MG_P3_FundTypeId""].Value + @"""""",false);");
base.WriteDebugInfo(@"");

if((result75E44CDA64284B8E87579CF0529D0DC9!=null) && (result75E44CDA64284B8E87579CF0529D0DC9.Count!=0))
{
if(result75E44CDA64284B8E87579CF0529D0DC9.ContainsKey(0))
ISpace["M_UpdateCount"].Value = result75E44CDA64284B8E87579CF0529D0DC9[0];
}
else{
ISpace["M_UpdateCount"].Value = null;
}
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("ReimbursementFundDetails","00D69CC2-E6EC-4412-B2A9-14E57A96FB5C",_objectFactory.GetGridRPP("ReimbursementFundDetails"),_elementBase.GetGridLoopQuery("00D69CC2-E6EC-4412-B2A9-14E57A96FB5C","ReimbursementFundDetails",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""ReimbursementFundDetails"",ref ISpace);

foreach(var gridChild in ISpace[""ReimbursementFundDetails""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
if(ISpace["MF_P1_TotalAmount"].Value==0)
{
base.WriteDebugInfo(@"if(ISpace[""MF_P1_TotalAmount""].Value==0)");
ISpace["Message"].Value=@"Overall Bill Amount should not be 0";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Overall Bill Amount should not be 0"";");
return;
base.WriteDebugInfo(@"return;");
}
if(ISpace["MFG_P3_OverallAmount"].Value!=ISpace["MF_P1_TotalAmount"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MFG_P3_OverallAmount""].Value!=ISpace[""MF_P1_TotalAmount""].Value)");
ISpace["Message"].Value=@"Both Overall Fund Amount and Overall Bill Amount should be same";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Both Overall Fund Amount and Overall Bill Amount should be same"";");
return;
base.WriteDebugInfo(@"return;");
}
base.WriteDebugInfo(@"#MG_DcoumentDetails[Rows]");
iSpace.GetLoopExpressionData("MG_DcoumentDetails",ref ISpace);

foreach(var gridChild in ISpace["MG_DcoumentDetails"].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 


if(
ISpace["M_DocumentName"].Value=="")
{
base.WriteDebugInfo(@"
if(
ISpace[""M_DocumentName""].Value=="""")");
ISpace["Message"].Value=@"Document Name should be Mandatory";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Document Name should be Mandatory"";");
return;
base.WriteDebugInfo(@"return;");
}

if(
IsNullOrEmpty(ISpace["M_UploadDcoument"].Value))
{
base.WriteDebugInfo(@"
if(
IsNullOrEmpty(ISpace[""M_UploadDcoument""].Value))");
ISpace["Message"].Value=@"Upload Document should be mandatory";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Upload Document should be mandatory"";");
return;
base.WriteDebugInfo(@"return;");
}
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("MG_DcoumentDetails","744177F0-C5DD-4666-BE31-646818F67196",_objectFactory.GetGridRPP("MG_DcoumentDetails"),_elementBase.GetGridLoopQuery("744177F0-C5DD-4666-BE31-646818F67196","MG_DcoumentDetails",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""MG_DcoumentDetails"",ref ISpace);

foreach(var gridChild in ISpace[""MG_DcoumentDetails""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["M_Status"].Value="Pending";
base.WriteDebugInfo(@"ISpace[""M_Status""].Value=""Pending"";");
base.WriteDebugInfo(@"Entering DomainDataMap for user request domain");
var userrequestdomain_repoObj = new RepositoryMapper(DbTypes.SQLServer);


var UserRequestsuserrequestdomaintableObj = new RepositoryTable("UserRequests");
  UserRequestsuserrequestdomaintableObj.AppConnectionSettingsId  ="9ADED37B-CD11-426B-AF16-DEAC75685EF5";UserRequestsuserrequestdomaintableObj.ProofConnectionId = "C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0)";
var userrequestdomain_UserRequests_rows = GetElementClientData(ISpace["InstanceId"].Value,"6B463D69-64AB-468E-B2E3-DB12E6B90014");

if(userrequestdomain_UserRequests_rows!=null && userrequestdomain_UserRequests_rows.Count>0){
var userrequestdomain_UserRequests_rowsObj = new List<RepositoryRow>();
foreach(var rows in userrequestdomain_UserRequests_rows){RepositoryRow repositoryRowObj = null;string elementData = null;RepositoryColumn repositoryColumnObj = null;if(rows !=null){ var UserRequests_colObj = new List<RepositoryColumn>();repositoryRowObj= new RepositoryRow();//var myByte = (byte)rowData.Value.RwSt;//repositoryRowObj.RowState=(RepositoryRowState)myByte;

elementData = ISpace["gv_ProcessMapId"].Value != null? Convert.ToString(ISpace["gv_ProcessMapId"].Value):null ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"PackageProcessMapID",false,false,9);
if(repositoryColumnObj!=null)UserRequests_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-gv_ProcessMapId not found");}

if(rows.ContainsKey("34CFB4AA-E9A1-4EAC-83A8-AEC1C4038EE1"))     elementData = rows["34CFB4AA-E9A1-4EAC-83A8-AEC1C4038EE1"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"CurrentLevel",false,false,9);
if(repositoryColumnObj!=null)UserRequests_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-M_NextStage not found");}

if(rows.ContainsKey("6D12DB25-D693-42CF-87A6-65FD81EACB39"))     elementData = rows["6D12DB25-D693-42CF-87A6-65FD81EACB39"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"RequestID",false,true,5);
if(repositoryColumnObj!=null)UserRequests_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-M_RequestId not found");}

if(rows.ContainsKey("B89FF303-5A1C-4060-BAB9-E6F52A11D9FD"))     elementData = rows["B89FF303-5A1C-4060-BAB9-E6F52A11D9FD"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"CurrentStatus",false,false,9);
if(repositoryColumnObj!=null)UserRequests_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-M_Status not found");}

elementData = ISpace["gv_UserId"].Value != null? Convert.ToString(ISpace["gv_UserId"].Value):null ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"LastModifiedByUserID",false,false,5);
if(repositoryColumnObj!=null)UserRequests_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-gv_UserId not found");}

if(rows.ContainsKey("0CDC8D38-F4F4-4C60-BCED-E9F0C8B165B8"))     elementData = rows["0CDC8D38-F4F4-4C60-BCED-E9F0C8B165B8"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"CurrentActivityMapID",false,false,9);
if(repositoryColumnObj!=null)UserRequests_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-SetDestinationTo not found");}

if(rows.ContainsKey("D7BB255E-9A01-4B5B-AE06-CC4D6E088D52"))     elementData = rows["D7BB255E-9A01-4B5B-AE06-CC4D6E088D52"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"InstanceID",true,false,9);
if(repositoryColumnObj!=null)UserRequests_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-M_InstanceId not found");}

elementData = CurrentDate().ToString() ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"InitiatedOn",false,false,8);
if(repositoryColumnObj!=null)UserRequests_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-CurrentDate not found");}

elementData = ISpace["gv_UserId"].Value != null? Convert.ToString(ISpace["gv_UserId"].Value):null ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"InitiatedByUserID",false,false,5);
if(repositoryColumnObj!=null)UserRequests_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-gv_UserId not found");}

elementData = CurrentDate().ToString() ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"LastModifiedOn",false,false,8);
if(repositoryColumnObj!=null)UserRequests_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-CurrentDate not found");}

if(rows.ContainsKey("E2AC84E4-505D-43CF-A99E-7A1B625647A4"))     elementData = rows["E2AC84E4-505D-43CF-A99E-7A1B625647A4"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"RequestTitle",false,false,9);
if(repositoryColumnObj!=null)UserRequests_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Subject not found");}
repositoryRowObj.Columns=UserRequests_colObj;
userrequestdomain_UserRequests_rowsObj.Add(repositoryRowObj);
}}

UserRequestsuserrequestdomaintableObj.Rows=userrequestdomain_UserRequests_rowsObj;
var userrequestdomain_repoObj_status_UserRequests = userrequestdomain_repoObj.Execute(DomainOperationTypes.CreateOrUpdate,ref UserRequestsuserrequestdomaintableObj);if(!userrequestdomain_repoObj_status_UserRequests) throw new Exception("Error in Execute Domain Data Map");}
base.WriteDebugInfo(@"Exiting DomainDataMap for user request domain");
}
ISpace["Message"].Value=@"Submitted Successfully";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Submitted Successfully"";");
ISpace.ExecuteInstanceCommand("Submit");
base.WriteDebugInfo(@"ISpace.ExecuteInstanceCommand(""Submit"");");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_save_reimbursementbilldetails (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Save_ReimbursementBillDetails-OnClick");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(Trim(ISpace["MFG_P2_BillNo"].Value)=="")
{
base.WriteDebugInfo(@"if(Trim(ISpace[""MFG_P2_BillNo""].Value)=="""")");
ISpace["Message"].Value=@"Please Enter the Bill No";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please Enter the Bill No"";");
return;
base.WriteDebugInfo(@"return;");
}
if((ISpace["MFG_P2_BillDate"].Value == null))
{
base.WriteDebugInfo(@"if((ISpace[""MFG_P2_BillDate""].Value == null))");
ISpace["Message"].Value=@"Please Enter the Bill Date";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please Enter the Bill Date"";");
return;
base.WriteDebugInfo(@"return;");
}
if(Trim(ISpace["MFG_P2_ItemDescription"].Value)=="")
{
base.WriteDebugInfo(@"if(Trim(ISpace[""MFG_P2_ItemDescription""].Value)=="""")");
ISpace["Message"].Value=@"Please Enter the Item Description";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please Enter the Item Description"";");
return;
base.WriteDebugInfo(@"return;");
}
if(ISpace["MFG_P2_Amount"].Value==0)
{
base.WriteDebugInfo(@"if(ISpace[""MFG_P2_Amount""].Value==0)");
ISpace["Message"].Value=@"Please Enter the Amount";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please Enter the Amount"";");
return;
base.WriteDebugInfo(@"return;");
}
}
if(ISpace["growid"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""growid""].Value=="""")");

var querySource588878D7B7824F24BAF7A4FE902E4A93 =GetQueryExpressionDataSource("588878D7-B782-4F24-BAF7-A4FE902E4A93");

DataTable result588878D7B7824F24BAF7A4FE902E4A93=iSpace.SetGridDataSource(querySource588878D7B7824F24BAF7A4FE902E4A93, _objectFactory.GetGridRPP("ReimbursementBillDetails"),@"EXEC AddFormGridDataC9ACCA847AF347E79133D777BE46A656 "" + ISpace["gv_instanceid"].Value + @"","" + ISpace["gv_processmapid"].Value + @"","C9ACCA84-7AF3-47E7-9133-D777BE46A656","" + ISpace["gv_activitymapid"].Value + @"","" + ISpace["MFG_P2_ReimbursementDetailsId"].Value + @"","" + ISpace["MFG_P2_ReimbursementId"].Value + @"","" + ISpace["MFG_P2_BillNo"].Value + @"","" + ISpace["MFG_P2_BillDate"].Value + @""," + ISpace["MFG_P2_BillDocument"].Value + @","" + ISpace["MFG_P2_ItemDescription"].Value + @""," + ISpace["MFG_P2_Amount"].Value + @","" + ISpace["growid"].Value + @""");

iSpace.InsertGridBindDetails("ReimbursementBillDetails","11",querySource588878D7B7824F24BAF7A4FE902E4A93,"EXEC AddFormGridDataC9ACCA847AF347E79133D777BE46A656 "" + ISpace["gv_instanceid"].Value + @"","" + ISpace["gv_processmapid"].Value + @"","C9ACCA84-7AF3-47E7-9133-D777BE46A656","" + ISpace["gv_activitymapid"].Value + @"","" + ISpace["MFG_P2_ReimbursementDetailsId"].Value + @"","" + ISpace["MFG_P2_ReimbursementId"].Value + @"","" + ISpace["MFG_P2_BillNo"].Value + @"","" + ISpace["MFG_P2_BillDate"].Value + @""," + ISpace["MFG_P2_BillDocument"].Value + @","" + ISpace["MFG_P2_ItemDescription"].Value + @""," + ISpace["MFG_P2_Amount"].Value + @","" + ISpace["growid"].Value + @""",_objectFactory.GetGridRPP("ReimbursementBillDetails"));

base.WriteDebugInfo(@"var querySource588878D7B7824F24BAF7A4FE902E4A93 =GetQueryExpressionDataSource(""588878D7-B782-4F24-BAF7-A4FE902E4A93"");DataTable result588878D7B7824F24BAF7A4FE902E4A93=iSpace.SetGridDataSource(querySource588878D7B7824F24BAF7A4FE902E4A93, _objectFactory.GetGridRPP(""ReimbursementBillDetails""),@""EXEC AddFormGridDataC9ACCA847AF347E79133D777BE46A656 """" + ISpace[""gv_instanceid""].Value + @"""","""" + ISpace[""gv_processmapid""].Value + @"""",""C9ACCA84-7AF3-47E7-9133-D777BE46A656"","""" + ISpace[""gv_activitymapid""].Value + @"""","""" + ISpace[""MFG_P2_ReimbursementDetailsId""].Value + @"""","""" + ISpace[""MFG_P2_ReimbursementId""].Value + @"""","""" + ISpace[""MFG_P2_BillNo""].Value + @"""","""" + ISpace[""MFG_P2_BillDate""].Value + @"""","" + ISpace[""MFG_P2_BillDocument""].Value + @"","""" + ISpace[""MFG_P2_ItemDescription""].Value + @"""","" + ISpace[""MFG_P2_Amount""].Value + @"","""" + ISpace[""growid""].Value + @"""""");iSpace.InsertGridBindDetails(""ReimbursementBillDetails"",""11"",querySource588878D7B7824F24BAF7A4FE902E4A93,""EXEC AddFormGridDataC9ACCA847AF347E79133D777BE46A656 """" + ISpace[""gv_instanceid""].Value + @"""","""" + ISpace[""gv_processmapid""].Value + @"""",""C9ACCA84-7AF3-47E7-9133-D777BE46A656"","""" + ISpace[""gv_activitymapid""].Value + @"""","""" + ISpace[""MFG_P2_ReimbursementDetailsId""].Value + @"""","""" + ISpace[""MFG_P2_ReimbursementId""].Value + @"""","""" + ISpace[""MFG_P2_BillNo""].Value + @"""","""" + ISpace[""MFG_P2_BillDate""].Value + @"""","" + ISpace[""MFG_P2_BillDocument""].Value + @"","""" + ISpace[""MFG_P2_ItemDescription""].Value + @"""","" + ISpace[""MFG_P2_Amount""].Value + @"","""" + ISpace[""growid""].Value + @"""""",_objectFactory.GetGridRPP(""ReimbursementBillDetails""));");
base.WriteDebugInfo(@"EXEC AddFormGridDataC9ACCA847AF347E79133D777BE46A656 "@@gv_InstanceId","@@gv_ProcessMapId","C9ACCA84-7AF3-47E7-9133-D777BE46A656","@@gv_ActivityMapId","#MFG_P2_ReimbursementDetailsId","#MFG_P2_ReimbursementId","#MFG_P2_BillNo","#MFG_P2_BillDate",#MFG_P2_BillDocument,"#MFG_P2_ItemDescription",#MFG_P2_Amount,"#growid"");


List<Triplet<string, short, short?>> resultAB481A6E87354F09AD1BC0BBEFC0AD56=acdataIspaceB2EE67FA41C14A1BAB23466B572ACE72.GetQueryExpressionBindings("AB481A6E-8735-4F09-AD1B-C0BBEFC0AD56");
iSpace.SetGridData(result588878D7B7824F24BAF7A4FE902E4A93,resultAB481A6E87354F09AD1BC0BBEFC0AD56,"ReimbursementBillDetails",ref ISpace);
iSpace.UpdateGridBindDetails("ReimbursementBillDetails",resultAB481A6E87354F09AD1BC0BBEFC0AD56);
}
else
{
base.WriteDebugInfo(@"else");

var querySourceF3514DB4690A4BE6A6A77FA3D37E5B7C =GetQueryExpressionDataSource("F3514DB4-690A-4BE6-A6A7-7FA3D37E5B7C");

DataTable resultF3514DB4690A4BE6A6A77FA3D37E5B7C=iSpace.SetGridDataSource(querySourceF3514DB4690A4BE6A6A77FA3D37E5B7C, _objectFactory.GetGridRPP("ReimbursementBillDetails"),@"EXEC UpdateFormGridDataC9ACCA847AF347E79133D777BE46A656 "" + ISpace["gv_instanceid"].Value + @"","" + ISpace["gv_processmapid"].Value + @"","C9ACCA84-7AF3-47E7-9133-D777BE46A656","" + ISpace["gv_activitymapid"].Value + @"","" + ISpace["MFG_P2_ReimbursementDetailsId"].Value + @"","" + ISpace["MFG_P2_ReimbursementId"].Value + @"","" + ISpace["MFG_P2_BillNo"].Value + @"","" + ISpace["MFG_P2_BillDate"].Value + @""," + ISpace["MFG_P2_BillDocument"].Value + @","" + ISpace["MFG_P2_ItemDescription"].Value + @""," + ISpace["MFG_P2_Amount"].Value + @","" + ISpace["growid"].Value + @""");

iSpace.InsertGridBindDetails("ReimbursementBillDetails","11",querySourceF3514DB4690A4BE6A6A77FA3D37E5B7C,"EXEC UpdateFormGridDataC9ACCA847AF347E79133D777BE46A656 "" + ISpace["gv_instanceid"].Value + @"","" + ISpace["gv_processmapid"].Value + @"","C9ACCA84-7AF3-47E7-9133-D777BE46A656","" + ISpace["gv_activitymapid"].Value + @"","" + ISpace["MFG_P2_ReimbursementDetailsId"].Value + @"","" + ISpace["MFG_P2_ReimbursementId"].Value + @"","" + ISpace["MFG_P2_BillNo"].Value + @"","" + ISpace["MFG_P2_BillDate"].Value + @""," + ISpace["MFG_P2_BillDocument"].Value + @","" + ISpace["MFG_P2_ItemDescription"].Value + @""," + ISpace["MFG_P2_Amount"].Value + @","" + ISpace["growid"].Value + @""",_objectFactory.GetGridRPP("ReimbursementBillDetails"));

base.WriteDebugInfo(@"var querySourceF3514DB4690A4BE6A6A77FA3D37E5B7C =GetQueryExpressionDataSource(""F3514DB4-690A-4BE6-A6A7-7FA3D37E5B7C"");DataTable resultF3514DB4690A4BE6A6A77FA3D37E5B7C=iSpace.SetGridDataSource(querySourceF3514DB4690A4BE6A6A77FA3D37E5B7C, _objectFactory.GetGridRPP(""ReimbursementBillDetails""),@""EXEC UpdateFormGridDataC9ACCA847AF347E79133D777BE46A656 """" + ISpace[""gv_instanceid""].Value + @"""","""" + ISpace[""gv_processmapid""].Value + @"""",""C9ACCA84-7AF3-47E7-9133-D777BE46A656"","""" + ISpace[""gv_activitymapid""].Value + @"""","""" + ISpace[""MFG_P2_ReimbursementDetailsId""].Value + @"""","""" + ISpace[""MFG_P2_ReimbursementId""].Value + @"""","""" + ISpace[""MFG_P2_BillNo""].Value + @"""","""" + ISpace[""MFG_P2_BillDate""].Value + @"""","" + ISpace[""MFG_P2_BillDocument""].Value + @"","""" + ISpace[""MFG_P2_ItemDescription""].Value + @"""","" + ISpace[""MFG_P2_Amount""].Value + @"","""" + ISpace[""growid""].Value + @"""""");iSpace.InsertGridBindDetails(""ReimbursementBillDetails"",""11"",querySourceF3514DB4690A4BE6A6A77FA3D37E5B7C,""EXEC UpdateFormGridDataC9ACCA847AF347E79133D777BE46A656 """" + ISpace[""gv_instanceid""].Value + @"""","""" + ISpace[""gv_processmapid""].Value + @"""",""C9ACCA84-7AF3-47E7-9133-D777BE46A656"","""" + ISpace[""gv_activitymapid""].Value + @"""","""" + ISpace[""MFG_P2_ReimbursementDetailsId""].Value + @"""","""" + ISpace[""MFG_P2_ReimbursementId""].Value + @"""","""" + ISpace[""MFG_P2_BillNo""].Value + @"""","""" + ISpace[""MFG_P2_BillDate""].Value + @"""","" + ISpace[""MFG_P2_BillDocument""].Value + @"","""" + ISpace[""MFG_P2_ItemDescription""].Value + @"""","" + ISpace[""MFG_P2_Amount""].Value + @"","""" + ISpace[""growid""].Value + @"""""",_objectFactory.GetGridRPP(""ReimbursementBillDetails""));");
base.WriteDebugInfo(@"EXEC UpdateFormGridDataC9ACCA847AF347E79133D777BE46A656 "@@gv_InstanceId","@@gv_ProcessMapId","C9ACCA84-7AF3-47E7-9133-D777BE46A656","@@gv_ActivityMapId","#MFG_P2_ReimbursementDetailsId","#MFG_P2_ReimbursementId","#MFG_P2_BillNo","#MFG_P2_BillDate",#MFG_P2_BillDocument,"#MFG_P2_ItemDescription",#MFG_P2_Amount,"#growid"");


List<Triplet<string, short, short?>> result51CA1824668943C9A9D9B360B3E6BBB8=acdataIspaceB2EE67FA41C14A1BAB23466B572ACE72.GetQueryExpressionBindings("51CA1824-6689-43C9-A9D9-B360B3E6BBB8");
iSpace.SetGridData(resultF3514DB4690A4BE6A6A77FA3D37E5B7C,result51CA1824668943C9A9D9B360B3E6BBB8,"ReimbursementBillDetails",ref ISpace);
iSpace.UpdateGridBindDetails("ReimbursementBillDetails",result51CA1824668943C9A9D9B360B3E6BBB8);
}
ISpace["growid"].Value="";
base.WriteDebugInfo(@"ISpace[""growid""].Value="""";");
ISpace["MFG_P2_ReimbursementDetailsId"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_P2_ReimbursementDetailsId""].Value="""";");
ISpace["MFG_P2_ReimbursementId"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_P2_ReimbursementId""].Value="""";");
ISpace["MFG_P2_BillNo"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_P2_BillNo""].Value="""";");
ISpace["MFG_P2_BillDate"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_P2_BillDate""].Value="""";");
ISpace["MFG_P2_BillDocument"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_P2_BillDocument""].Value="""";");
ISpace["MFG_P2_ItemDescription"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_P2_ItemDescription""].Value="""";");
ISpace["MFG_P2_Amount"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_P2_Amount""].Value="""";");
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

var querySourceDF30243A932448659FFF478698865C85 =GetQueryExpressionDataSource("DF30243A-9324-4865-9FFF-478698865C85");

DataTable resultDF30243A932448659FFF478698865C85=iSpace.SetGridDataSource(querySourceDF30243A932448659FFF478698865C85, _objectFactory.GetGridRPP("MG_CommitmentDetails"),@"EXEC GetProjectBudgetInformation "" + ISpace["MF_ProjectNo"].Value + @""");

iSpace.InsertGridBindDetails("MG_CommitmentDetails","11",querySourceDF30243A932448659FFF478698865C85,"EXEC GetProjectBudgetInformation "" + ISpace["MF_ProjectNo"].Value + @""",_objectFactory.GetGridRPP("MG_CommitmentDetails"));

base.WriteDebugInfo(@"var querySourceDF30243A932448659FFF478698865C85 =GetQueryExpressionDataSource(""DF30243A-9324-4865-9FFF-478698865C85"");DataTable resultDF30243A932448659FFF478698865C85=iSpace.SetGridDataSource(querySourceDF30243A932448659FFF478698865C85, _objectFactory.GetGridRPP(""MG_CommitmentDetails""),@""EXEC GetProjectBudgetInformation """" + ISpace[""MF_ProjectNo""].Value + @"""""");iSpace.InsertGridBindDetails(""MG_CommitmentDetails"",""11"",querySourceDF30243A932448659FFF478698865C85,""EXEC GetProjectBudgetInformation """" + ISpace[""MF_ProjectNo""].Value + @"""""",_objectFactory.GetGridRPP(""MG_CommitmentDetails""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> resultD8C74C9B035C46A493E2CAE4FECC1DA7=acdataIspaceB2EE67FA41C14A1BAB23466B572ACE72.GetQueryExpressionBindings("D8C74C9B-035C-46A4-93E2-CAE4FECC1DA7");
iSpace.SetGridData(resultDF30243A932448659FFF478698865C85,resultD8C74C9B035C46A493E2CAE4FECC1DA7,"MG_CommitmentDetails",ref ISpace);
iSpace.UpdateGridBindDetails("MG_CommitmentDetails",resultD8C74C9B035C46A493E2CAE4FECC1DA7);
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mg_p3_delete (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MG_P3_Delete-OnClick");
ISpace["growid"].Value=ISpace["ReimbursementFundDetails_RowId"].Value;
base.WriteDebugInfo(@"ISpace[""growid""].Value=ISpace[""ReimbursementFundDetails_RowId""].Value;");
ISpace["UI_DeleteDialog"].ShowDialog=true;;
base.WriteDebugInfo(@"ISpace[""UI_DeleteDialog""].ShowDialog=true;;");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_ui_yes (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"UI_Yes-OnClick");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySource21822FB86E0C4D8C9EE538233317BB5C =GetQueryExpressionDataSource("21822FB8-6E0C-4D8C-9EE5-38233317BB5C");

DataTable result21822FB86E0C4D8C9EE538233317BB5C=iSpace.SetGridDataSource(querySource21822FB86E0C4D8C9EE538233317BB5C, _objectFactory.GetGridRPP("ReimbursementFundDetails"),@"EXEC DeleteFormGridData1112A274004543D393C5205DAEFEA917 "" + ISpace["gv_instanceid"].Value + @"","" + ISpace["gv_processmapid"].Value + @"","1112A274-0045-43D3-93C5-205DAEFEA917","" + ISpace["gv_activitymapid"].Value + @"","" + ISpace["growid"].Value + @""");

iSpace.InsertGridBindDetails("ReimbursementFundDetails","11",querySource21822FB86E0C4D8C9EE538233317BB5C,"EXEC DeleteFormGridData1112A274004543D393C5205DAEFEA917 "" + ISpace["gv_instanceid"].Value + @"","" + ISpace["gv_processmapid"].Value + @"","1112A274-0045-43D3-93C5-205DAEFEA917","" + ISpace["gv_activitymapid"].Value + @"","" + ISpace["growid"].Value + @""",_objectFactory.GetGridRPP("ReimbursementFundDetails"));

base.WriteDebugInfo(@"var querySource21822FB86E0C4D8C9EE538233317BB5C =GetQueryExpressionDataSource(""21822FB8-6E0C-4D8C-9EE5-38233317BB5C"");DataTable result21822FB86E0C4D8C9EE538233317BB5C=iSpace.SetGridDataSource(querySource21822FB86E0C4D8C9EE538233317BB5C, _objectFactory.GetGridRPP(""ReimbursementFundDetails""),@""EXEC DeleteFormGridData1112A274004543D393C5205DAEFEA917 """" + ISpace[""gv_instanceid""].Value + @"""","""" + ISpace[""gv_processmapid""].Value + @"""",""1112A274-0045-43D3-93C5-205DAEFEA917"","""" + ISpace[""gv_activitymapid""].Value + @"""","""" + ISpace[""growid""].Value + @"""""");iSpace.InsertGridBindDetails(""ReimbursementFundDetails"",""11"",querySource21822FB86E0C4D8C9EE538233317BB5C,""EXEC DeleteFormGridData1112A274004543D393C5205DAEFEA917 """" + ISpace[""gv_instanceid""].Value + @"""","""" + ISpace[""gv_processmapid""].Value + @"""",""1112A274-0045-43D3-93C5-205DAEFEA917"","""" + ISpace[""gv_activitymapid""].Value + @"""","""" + ISpace[""growid""].Value + @"""""",_objectFactory.GetGridRPP(""ReimbursementFundDetails""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> resultE36ECEF06F8F4B61827C4CB0B5D712E0=acdataIspaceB2EE67FA41C14A1BAB23466B572ACE72.GetQueryExpressionBindings("E36ECEF0-6F8F-4B61-827C-4CB0B5D712E0");
iSpace.SetGridData(result21822FB86E0C4D8C9EE538233317BB5C,resultE36ECEF06F8F4B61827C4CB0B5D712E0,"ReimbursementFundDetails",ref ISpace);
iSpace.UpdateGridBindDetails("ReimbursementFundDetails",resultE36ECEF06F8F4B61827C4CB0B5D712E0);
object MG_P3_Amount=iSpace.Sum("[00D69CC2-E6EC-4412-B2A9-14E57A96FB5C]","MG_P3_Amount","");
ISpace["MFG_P3_OverallAmount"].Value=Convert.ChangeType(MG_P3_Amount, MG_P3_Amount.GetType());;
base.WriteDebugInfo(@"object MG_P3_Amount=iSpace.Sum(""[00D69CC2-E6EC-4412-B2A9-14E57A96FB5C]"",""MG_P3_Amount"","""");
ISpace[""MFG_P3_OverallAmount""].Value=Convert.ChangeType(MG_P3_Amount, MG_P3_Amount.GetType());;");
ISpace["Message"].Value=@"Data deleted successfully";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Data deleted successfully"";");
ISpace["growid"].Value="";
base.WriteDebugInfo(@"ISpace[""growid""].Value="""";");
ISpace["UI_DeleteDialog"].HideDialog=true;;
base.WriteDebugInfo(@"ISpace[""UI_DeleteDialog""].HideDialog=true;;");
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_edit_reimbursementfunddetails (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Edit_ReimbursementFundDetails-OnClick");
ISpace["growid"].Value=ISpace["ReimbursementFundDetails_RowId"].Value;
base.WriteDebugInfo(@"ISpace[""growid""].Value=ISpace[""ReimbursementFundDetails_RowId""].Value;");
base.WriteDebugInfo(@"EXEC  [LoadFormGridData1112A274004543D393C5205DAEFEA917]  "@@gv_InstanceId","@@gv_ProcessMapId","1112A274-0045-43D3-93C5-205DAEFEA917","@@gv_ActivityMapId","#growid"");

var querySource457B75FDB3F34EB787EB96D92F86F9EB =GetQueryExpressionDataSource("457B75FD-B3F3-4EB7-87EB-96D92F86F9EB");
Dictionary<short,object> result457B75FDB3F34EB787EB96D92F86F9EB=iSpace.ExecuteQuery(querySource457B75FDB3F34EB787EB96D92F86F9EB,@"EXEC[LoadFormGridData1112A274004543D393C5205DAEFEA917]"" + ISpace["gv_instanceid"].Value + @"","" + ISpace["gv_processmapid"].Value + @"","1112A274-0045-43D3-93C5-205DAEFEA917","" + ISpace["gv_activitymapid"].Value + @"","" + ISpace["growid"].Value + @""",false);

base.WriteDebugInfo(@"var querySource457B75FDB3F34EB787EB96D92F86F9EB =GetQueryExpressionDataSource(""457B75FD-B3F3-4EB7-87EB-96D92F86F9EB"");Dictionary<short,object> result457B75FDB3F34EB787EB96D92F86F9EB=iSpace.ExecuteQuery(querySource457B75FDB3F34EB787EB96D92F86F9EB,@""EXEC[LoadFormGridData1112A274004543D393C5205DAEFEA917]"""" + ISpace[""gv_instanceid""].Value + @"""","""" + ISpace[""gv_processmapid""].Value + @"""",""1112A274-0045-43D3-93C5-205DAEFEA917"","""" + ISpace[""gv_activitymapid""].Value + @"""","""" + ISpace[""growid""].Value + @"""""",false);");
base.WriteDebugInfo(@"EXEC LoadFormGridDataD85301F7BAF94BE8A2B174E5CBB3D054 "@@gv_InstanceId","@@gv_ProcessMapId","D85301F7-BAF9-4BE8-A2B1-74E5CBB3D054","@@gv_ActivityMapId","#growid"");

if((result457B75FDB3F34EB787EB96D92F86F9EB!=null) && (result457B75FDB3F34EB787EB96D92F86F9EB.Count!=0))
{
if(result457B75FDB3F34EB787EB96D92F86F9EB.ContainsKey(2))
ISpace["MFG_P3_FundTypeId"].Value = result457B75FDB3F34EB787EB96D92F86F9EB[2];
if(result457B75FDB3F34EB787EB96D92F86F9EB.ContainsKey(3))
ISpace["MFG_P3_ProjectDetailsId"].Value = result457B75FDB3F34EB787EB96D92F86F9EB[3];
if(result457B75FDB3F34EB787EB96D92F86F9EB.ContainsKey(4))
ISpace["MFG_P3_BudgetHeadId"].Value = result457B75FDB3F34EB787EB96D92F86F9EB[4];
if(result457B75FDB3F34EB787EB96D92F86F9EB.ContainsKey(5))
ISpace["MFG_P3_Amount"].Value = result457B75FDB3F34EB787EB96D92F86F9EB[5];
if(result457B75FDB3F34EB787EB96D92F86F9EB.ContainsKey(0))
ISpace["MFG_P3_FundDetailsId"].Value = result457B75FDB3F34EB787EB96D92F86F9EB[0];
if(result457B75FDB3F34EB787EB96D92F86F9EB.ContainsKey(1))
ISpace["MFG_P3_ReimbursementId"].Value = result457B75FDB3F34EB787EB96D92F86F9EB[1];
}
else{
ISpace["MFG_P3_FundTypeId"].Value = null;ISpace["MFG_P3_ProjectDetailsId"].Value = null;ISpace["MFG_P3_BudgetHeadId"].Value = null;ISpace["MFG_P3_Amount"].Value = null;ISpace["MFG_P3_FundDetailsId"].Value = null;ISpace["MFG_P3_ReimbursementId"].Value = null;
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mga_amount (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MGA_Amount-OnChange");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
object MGA_Amount=iSpace.Sum("[1356A8F2-1947-4667-987D-2EA211B288A3]","MGA_Amount","");
ISpace["MF_P1_TotalAmount"].Value=Convert.ChangeType(MGA_Amount, MGA_Amount.GetType());;
base.WriteDebugInfo(@"object MGA_Amount=iSpace.Sum(""[1356A8F2-1947-4667-987D-2EA211B288A3]"",""MGA_Amount"","""");
ISpace[""MF_P1_TotalAmount""].Value=Convert.ChangeType(MGA_Amount, MGA_Amount.GetType());;");
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_edit_reimbursementbilldetails (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Edit_ReimbursementBillDetails-OnClick");
base.WriteDebugInfo(@"EXEC LoadFormGridDataC9ACCA847AF347E79133D777BE46A656 "@@gv_InstanceId","@@gv_ProcessMapId","C9ACCA84-7AF3-47E7-9133-D777BE46A656","@@gv_ActivityMapId","#growid"");

var querySourceE12571F81F5945ED9BC6BAF0AA62F4F0 =GetQueryExpressionDataSource("E12571F8-1F59-45ED-9BC6-BAF0AA62F4F0");
Dictionary<short,object> resultE12571F81F5945ED9BC6BAF0AA62F4F0=iSpace.ExecuteQuery(querySourceE12571F81F5945ED9BC6BAF0AA62F4F0,@"EXEC LoadFormGridDataC9ACCA847AF347E79133D777BE46A656 "" + ISpace["gv_instanceid"].Value + @"","" + ISpace["gv_processmapid"].Value + @"","C9ACCA84-7AF3-47E7-9133-D777BE46A656","" + ISpace["gv_activitymapid"].Value + @"","" + ISpace["growid"].Value + @""",false);

base.WriteDebugInfo(@"var querySourceE12571F81F5945ED9BC6BAF0AA62F4F0 =GetQueryExpressionDataSource(""E12571F8-1F59-45ED-9BC6-BAF0AA62F4F0"");Dictionary<short,object> resultE12571F81F5945ED9BC6BAF0AA62F4F0=iSpace.ExecuteQuery(querySourceE12571F81F5945ED9BC6BAF0AA62F4F0,@""EXEC LoadFormGridDataC9ACCA847AF347E79133D777BE46A656 """" + ISpace[""gv_instanceid""].Value + @"""","""" + ISpace[""gv_processmapid""].Value + @"""",""C9ACCA84-7AF3-47E7-9133-D777BE46A656"","""" + ISpace[""gv_activitymapid""].Value + @"""","""" + ISpace[""growid""].Value + @"""""",false);");
base.WriteDebugInfo(@"EXEC LoadFormGridDataC9ACCA847AF347E79133D777BE46A656 "@@gv_InstanceId","@@gv_ProcessMapId","C9ACCA84-7AF3-47E7-9133-D777BE46A656","@@gv_ActivityMapId","#growid"");

if((resultE12571F81F5945ED9BC6BAF0AA62F4F0!=null) && (resultE12571F81F5945ED9BC6BAF0AA62F4F0.Count!=0))
{
if(resultE12571F81F5945ED9BC6BAF0AA62F4F0.ContainsKey(3))
ISpace["MFG_P2_BillDate"].Value = resultE12571F81F5945ED9BC6BAF0AA62F4F0[3];
if(resultE12571F81F5945ED9BC6BAF0AA62F4F0.ContainsKey(4))
ISpace["MFG_P2_BillDocument"].Value = resultE12571F81F5945ED9BC6BAF0AA62F4F0[4];
if(resultE12571F81F5945ED9BC6BAF0AA62F4F0.ContainsKey(6))
ISpace["MFG_P2_Amount"].Value = resultE12571F81F5945ED9BC6BAF0AA62F4F0[6];
if(resultE12571F81F5945ED9BC6BAF0AA62F4F0.ContainsKey(5))
ISpace["MFG_P2_ItemDescription"].Value = resultE12571F81F5945ED9BC6BAF0AA62F4F0[5];
if(resultE12571F81F5945ED9BC6BAF0AA62F4F0.ContainsKey(0))
ISpace["MFG_P2_ReimbursementDetailsId"].Value = resultE12571F81F5945ED9BC6BAF0AA62F4F0[0];
if(resultE12571F81F5945ED9BC6BAF0AA62F4F0.ContainsKey(1))
ISpace["MFG_P2_ReimbursementId"].Value = resultE12571F81F5945ED9BC6BAF0AA62F4F0[1];
if(resultE12571F81F5945ED9BC6BAF0AA62F4F0.ContainsKey(2))
ISpace["MFG_P2_BillNo"].Value = resultE12571F81F5945ED9BC6BAF0AA62F4F0[2];
}
else{
ISpace["MFG_P2_BillDate"].Value = null;ISpace["MFG_P2_BillDocument"].Value = null;ISpace["MFG_P2_Amount"].Value = null;ISpace["MFG_P2_ItemDescription"].Value = null;ISpace["MFG_P2_ReimbursementDetailsId"].Value = null;ISpace["MFG_P2_ReimbursementId"].Value = null;ISpace["MFG_P2_BillNo"].Value = null;
}
ISpace["growid"].Value=ISpace["ReimbursementBillDetails_RowId"].Value;
base.WriteDebugInfo(@"ISpace[""growid""].Value=ISpace[""ReimbursementBillDetails_RowId""].Value;");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_save_reimbursementfunddetails (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Save_ReimbursementFundDetails-OnClick");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(Trim(ISpace["MFG_P3_FundTypeId"].Value)=="")
{
base.WriteDebugInfo(@"if(Trim(ISpace[""MFG_P3_FundTypeId""].Value)=="""")");
ISpace["Message"].Value=@"Please Enter the Fund Type";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please Enter the Fund Type"";");
return;
base.WriteDebugInfo(@"return;");
}
if(ISpace["MFG_P3_FundTypeId"].Value=="1")
{
base.WriteDebugInfo(@"if(ISpace[""MFG_P3_FundTypeId""].Value==""1"")");
if(ISpace["MFG_P3_ProjectDetailsId"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""MFG_P3_ProjectDetailsId""].Value=="""")");
ISpace["Message"].Value=@"Project No should be Mandatory";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Project No should be Mandatory"";");
return;
base.WriteDebugInfo(@"return;");
}
if(ISpace["MFG_P3_BudgetHeadId"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""MFG_P3_BudgetHeadId""].Value=="""")");
ISpace["Message"].Value=@"Budget Head should be mandatory";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Budget Head should be mandatory"";");
return;
base.WriteDebugInfo(@"return;");
}
}
if(ISpace["MFG_P3_Amount"].Value==0)
{
base.WriteDebugInfo(@"if(ISpace[""MFG_P3_Amount""].Value==0)");
ISpace["Message"].Value=@"Please Enter the Amount";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please Enter the Amount"";");
return;
base.WriteDebugInfo(@"return;");
}
base.WriteDebugInfo(@"EXEC [ValidatePaymentFundAvailability] "#MFG_P3_FundTypeId","#MFG_P3_ProjectDetailsId","#MFG_P3_BudgetHeadId","#UC_EmployeeBaicInfoId","#MFG_P3_Amount"");

var querySource07D02D1F066F4E9B8819A44E473F22C2 =GetQueryExpressionDataSource("07D02D1F-066F-4E9B-8819-A44E473F22C2");
Dictionary<short,object> result07D02D1F066F4E9B8819A44E473F22C2=iSpace.ExecuteQuery(querySource07D02D1F066F4E9B8819A44E473F22C2,@"EXEC [ValidatePaymentFundAvailability] "" + ISpace["MFG_P3_FundTypeId"].Value + @"","" + ISpace["MFG_P3_ProjectDetailsId"].Value + @"","" + ISpace["MFG_P3_BudgetHeadId"].Value + @"","" + ISpace["UC_EmployeeBaicInfoId"].Value + @"","" + ISpace["MFG_P3_Amount"].Value + @""",false);

base.WriteDebugInfo(@"var querySource07D02D1F066F4E9B8819A44E473F22C2 =GetQueryExpressionDataSource(""07D02D1F-066F-4E9B-8819-A44E473F22C2"");Dictionary<short,object> result07D02D1F066F4E9B8819A44E473F22C2=iSpace.ExecuteQuery(querySource07D02D1F066F4E9B8819A44E473F22C2,@""EXEC [ValidatePaymentFundAvailability] """" + ISpace[""MFG_P3_FundTypeId""].Value + @"""","""" + ISpace[""MFG_P3_ProjectDetailsId""].Value + @"""","""" + ISpace[""MFG_P3_BudgetHeadId""].Value + @"""","""" + ISpace[""UC_EmployeeBaicInfoId""].Value + @"""","""" + ISpace[""MFG_P3_Amount""].Value + @"""""",false);");
base.WriteDebugInfo(@"");

if((result07D02D1F066F4E9B8819A44E473F22C2!=null) && (result07D02D1F066F4E9B8819A44E473F22C2.Count!=0))
{
if(result07D02D1F066F4E9B8819A44E473F22C2.ContainsKey(0))
ISpace["M_ErrId"].Value = result07D02D1F066F4E9B8819A44E473F22C2[0];
if(result07D02D1F066F4E9B8819A44E473F22C2.ContainsKey(1))
ISpace["M_ErrMsg"].Value = result07D02D1F066F4E9B8819A44E473F22C2[1];
}
else{
ISpace["M_ErrId"].Value = null;ISpace["M_ErrMsg"].Value = null;
}
if(ISpace["M_ErrId"].Value==0)
{
base.WriteDebugInfo(@"if(ISpace[""M_ErrId""].Value==0)");
ISpace["Message"].Value=String.Format(@"{0}",ISpace["M_ErrMsg"].Value);
base.WriteDebugInfo(@"ISpace[""Message""].Value=String.Format(@""{0}"",ISpace[""M_ErrMsg""].Value);");
return;
base.WriteDebugInfo(@"return;");
}
}
if(ISpace["MFG_P3_FundTypeId"].Value=="1")
{
base.WriteDebugInfo(@"if(ISpace[""MFG_P3_FundTypeId""].Value==""1"")");
base.WriteDebugInfo(@"#ReimbursementFundDetails[Rows]");
iSpace.GetLoopExpressionData("ReimbursementFundDetails",ref ISpace);

foreach(var gridChild in ISpace["ReimbursementFundDetails"].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 


if(


ISpace["growid"].Value!=ISpace["ReimbursementFundDetails_RowId"].Value||ISpace["growid"].Value=="")
{
base.WriteDebugInfo(@"
if(


ISpace[""growid""].Value!=ISpace[""ReimbursementFundDetails_RowId""].Value||ISpace[""growid""].Value=="""")");
if(ISpace["MFG_P3_BudgetHeadId"].Value==ISpace["MG_P3_BudgetHeadId"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MFG_P3_BudgetHeadId""].Value==ISpace[""MG_P3_BudgetHeadId""].Value)");
ISpace["Message"].Value=@"Budget Head is already Exists";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Budget Head is already Exists"";");
ISpace["MFG_P3_BudgetHeadId"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_P3_BudgetHeadId""].Value="""";");
return;
base.WriteDebugInfo(@"return;");
}
}
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("ReimbursementFundDetails","00D69CC2-E6EC-4412-B2A9-14E57A96FB5C",_objectFactory.GetGridRPP("ReimbursementFundDetails"),_elementBase.GetGridLoopQuery("00D69CC2-E6EC-4412-B2A9-14E57A96FB5C","ReimbursementFundDetails",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""ReimbursementFundDetails"",ref ISpace);

foreach(var gridChild in ISpace[""ReimbursementFundDetails""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
}
if(ISpace["growid"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""growid""].Value=="""")");

var querySourceC5471BC38ECA4216A66F923825C32508 =GetQueryExpressionDataSource("C5471BC3-8ECA-4216-A66F-923825C32508");

DataTable resultC5471BC38ECA4216A66F923825C32508=iSpace.SetGridDataSource(querySourceC5471BC38ECA4216A66F923825C32508, _objectFactory.GetGridRPP("ReimbursementFundDetails"),@"EXEC AddFormGridData1112A274004543D393C5205DAEFEA917 "" + ISpace["gv_instanceid"].Value + @"","" + ISpace["gv_processmapid"].Value + @"","1112A274-0045-43D3-93C5-205DAEFEA917","" + ISpace["gv_activitymapid"].Value + @"","" + ISpace["MFG_P3_FundDetailsId"].Value + @"","" + ISpace["M_Advanceformid"].Value + @"","" + ISpace["MFG_P3_FundTypeId"].Value + @"","" + ISpace["MFG_P3_ProjectDetailsId"].Value + @"","" + ISpace["MFG_P3_BudgetHeadId"].Value + @""," + ISpace["MFG_P3_Amount"].Value + @","" + ISpace["growid"].Value + @""");

iSpace.InsertGridBindDetails("ReimbursementFundDetails","11",querySourceC5471BC38ECA4216A66F923825C32508,"EXEC AddFormGridData1112A274004543D393C5205DAEFEA917 "" + ISpace["gv_instanceid"].Value + @"","" + ISpace["gv_processmapid"].Value + @"","1112A274-0045-43D3-93C5-205DAEFEA917","" + ISpace["gv_activitymapid"].Value + @"","" + ISpace["MFG_P3_FundDetailsId"].Value + @"","" + ISpace["M_Advanceformid"].Value + @"","" + ISpace["MFG_P3_FundTypeId"].Value + @"","" + ISpace["MFG_P3_ProjectDetailsId"].Value + @"","" + ISpace["MFG_P3_BudgetHeadId"].Value + @""," + ISpace["MFG_P3_Amount"].Value + @","" + ISpace["growid"].Value + @""",_objectFactory.GetGridRPP("ReimbursementFundDetails"));

base.WriteDebugInfo(@"var querySourceC5471BC38ECA4216A66F923825C32508 =GetQueryExpressionDataSource(""C5471BC3-8ECA-4216-A66F-923825C32508"");DataTable resultC5471BC38ECA4216A66F923825C32508=iSpace.SetGridDataSource(querySourceC5471BC38ECA4216A66F923825C32508, _objectFactory.GetGridRPP(""ReimbursementFundDetails""),@""EXEC AddFormGridData1112A274004543D393C5205DAEFEA917 """" + ISpace[""gv_instanceid""].Value + @"""","""" + ISpace[""gv_processmapid""].Value + @"""",""1112A274-0045-43D3-93C5-205DAEFEA917"","""" + ISpace[""gv_activitymapid""].Value + @"""","""" + ISpace[""MFG_P3_FundDetailsId""].Value + @"""","""" + ISpace[""M_Advanceformid""].Value + @"""","""" + ISpace[""MFG_P3_FundTypeId""].Value + @"""","""" + ISpace[""MFG_P3_ProjectDetailsId""].Value + @"""","""" + ISpace[""MFG_P3_BudgetHeadId""].Value + @"""","" + ISpace[""MFG_P3_Amount""].Value + @"","""" + ISpace[""growid""].Value + @"""""");iSpace.InsertGridBindDetails(""ReimbursementFundDetails"",""11"",querySourceC5471BC38ECA4216A66F923825C32508,""EXEC AddFormGridData1112A274004543D393C5205DAEFEA917 """" + ISpace[""gv_instanceid""].Value + @"""","""" + ISpace[""gv_processmapid""].Value + @"""",""1112A274-0045-43D3-93C5-205DAEFEA917"","""" + ISpace[""gv_activitymapid""].Value + @"""","""" + ISpace[""MFG_P3_FundDetailsId""].Value + @"""","""" + ISpace[""M_Advanceformid""].Value + @"""","""" + ISpace[""MFG_P3_FundTypeId""].Value + @"""","""" + ISpace[""MFG_P3_ProjectDetailsId""].Value + @"""","""" + ISpace[""MFG_P3_BudgetHeadId""].Value + @"""","" + ISpace[""MFG_P3_Amount""].Value + @"","""" + ISpace[""growid""].Value + @"""""",_objectFactory.GetGridRPP(""ReimbursementFundDetails""));");
base.WriteDebugInfo(@"EXEC AddFormGridDataD85301F7BAF94BE8A2B174E5CBB3D054 "@@gv_InstanceId","@@gv_ProcessMapId","D85301F7-BAF9-4BE8-A2B1-74E5CBB3D054","@@gv_ActivityMapId","#MFG_P3_FundDetailsId","#MFG_P3_ReimbursementId","#MFG_P3_FundTypeId","#MFG_P3_ProjectDetailsId","#MFG_P3_BudgetHeadId",#MFG_P3_Amount,"#growid"");


List<Triplet<string, short, short?>> result169C69C3949245478D79196C3E1309FB=acdataIspaceB2EE67FA41C14A1BAB23466B572ACE72.GetQueryExpressionBindings("169C69C3-9492-4547-8D79-196C3E1309FB");
iSpace.SetGridData(resultC5471BC38ECA4216A66F923825C32508,result169C69C3949245478D79196C3E1309FB,"ReimbursementFundDetails",ref ISpace);
iSpace.UpdateGridBindDetails("ReimbursementFundDetails",result169C69C3949245478D79196C3E1309FB);
}
else
{
base.WriteDebugInfo(@"else");

var querySourceA8D19C29F512446883DE4C86EF7F0E8F =GetQueryExpressionDataSource("A8D19C29-F512-4468-83DE-4C86EF7F0E8F");

DataTable resultA8D19C29F512446883DE4C86EF7F0E8F=iSpace.SetGridDataSource(querySourceA8D19C29F512446883DE4C86EF7F0E8F, _objectFactory.GetGridRPP("ReimbursementFundDetails"),@"EXEC UpdateFormGridData1112A274004543D393C5205DAEFEA917 "" + ISpace["gv_instanceid"].Value + @"","" + ISpace["gv_processmapid"].Value + @"","1112A274-0045-43D3-93C5-205DAEFEA917","" + ISpace["gv_activitymapid"].Value + @"","" + ISpace["MFG_P3_FundDetailsId"].Value + @"","" + ISpace["M_Advanceformid"].Value + @"","" + ISpace["MFG_P3_FundTypeId"].Value + @"","" + ISpace["MFG_P3_ProjectDetailsId"].Value + @"","" + ISpace["MFG_P3_BudgetHeadId"].Value + @""," + ISpace["MFG_P3_Amount"].Value + @","" + ISpace["growid"].Value + @""");

iSpace.InsertGridBindDetails("ReimbursementFundDetails","11",querySourceA8D19C29F512446883DE4C86EF7F0E8F,"EXEC UpdateFormGridData1112A274004543D393C5205DAEFEA917 "" + ISpace["gv_instanceid"].Value + @"","" + ISpace["gv_processmapid"].Value + @"","1112A274-0045-43D3-93C5-205DAEFEA917","" + ISpace["gv_activitymapid"].Value + @"","" + ISpace["MFG_P3_FundDetailsId"].Value + @"","" + ISpace["M_Advanceformid"].Value + @"","" + ISpace["MFG_P3_FundTypeId"].Value + @"","" + ISpace["MFG_P3_ProjectDetailsId"].Value + @"","" + ISpace["MFG_P3_BudgetHeadId"].Value + @""," + ISpace["MFG_P3_Amount"].Value + @","" + ISpace["growid"].Value + @""",_objectFactory.GetGridRPP("ReimbursementFundDetails"));

base.WriteDebugInfo(@"var querySourceA8D19C29F512446883DE4C86EF7F0E8F =GetQueryExpressionDataSource(""A8D19C29-F512-4468-83DE-4C86EF7F0E8F"");DataTable resultA8D19C29F512446883DE4C86EF7F0E8F=iSpace.SetGridDataSource(querySourceA8D19C29F512446883DE4C86EF7F0E8F, _objectFactory.GetGridRPP(""ReimbursementFundDetails""),@""EXEC UpdateFormGridData1112A274004543D393C5205DAEFEA917 """" + ISpace[""gv_instanceid""].Value + @"""","""" + ISpace[""gv_processmapid""].Value + @"""",""1112A274-0045-43D3-93C5-205DAEFEA917"","""" + ISpace[""gv_activitymapid""].Value + @"""","""" + ISpace[""MFG_P3_FundDetailsId""].Value + @"""","""" + ISpace[""M_Advanceformid""].Value + @"""","""" + ISpace[""MFG_P3_FundTypeId""].Value + @"""","""" + ISpace[""MFG_P3_ProjectDetailsId""].Value + @"""","""" + ISpace[""MFG_P3_BudgetHeadId""].Value + @"""","" + ISpace[""MFG_P3_Amount""].Value + @"","""" + ISpace[""growid""].Value + @"""""");iSpace.InsertGridBindDetails(""ReimbursementFundDetails"",""11"",querySourceA8D19C29F512446883DE4C86EF7F0E8F,""EXEC UpdateFormGridData1112A274004543D393C5205DAEFEA917 """" + ISpace[""gv_instanceid""].Value + @"""","""" + ISpace[""gv_processmapid""].Value + @"""",""1112A274-0045-43D3-93C5-205DAEFEA917"","""" + ISpace[""gv_activitymapid""].Value + @"""","""" + ISpace[""MFG_P3_FundDetailsId""].Value + @"""","""" + ISpace[""M_Advanceformid""].Value + @"""","""" + ISpace[""MFG_P3_FundTypeId""].Value + @"""","""" + ISpace[""MFG_P3_ProjectDetailsId""].Value + @"""","""" + ISpace[""MFG_P3_BudgetHeadId""].Value + @"""","" + ISpace[""MFG_P3_Amount""].Value + @"","""" + ISpace[""growid""].Value + @"""""",_objectFactory.GetGridRPP(""ReimbursementFundDetails""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> resultBDF250C27A244A8EB094E340FDE4659C=acdataIspaceB2EE67FA41C14A1BAB23466B572ACE72.GetQueryExpressionBindings("BDF250C2-7A24-4A8E-B094-E340FDE4659C");
iSpace.SetGridData(resultA8D19C29F512446883DE4C86EF7F0E8F,resultBDF250C27A244A8EB094E340FDE4659C,"ReimbursementFundDetails",ref ISpace);
iSpace.UpdateGridBindDetails("ReimbursementFundDetails",resultBDF250C27A244A8EB094E340FDE4659C);
}
base.WriteDebugInfo(@"#ReimbursementFundDetails[Rows]");
iSpace.GetLoopExpressionData("ReimbursementFundDetails",ref ISpace);

foreach(var gridChild in ISpace["ReimbursementFundDetails"].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 



ISpace["MG_P3_Employeebasicinfoid"].Value=ISpace["UC_EmployeeBaicInfoId"].Value;
base.WriteDebugInfo(@"

ISpace[""MG_P3_Employeebasicinfoid""].Value=ISpace[""UC_EmployeeBaicInfoId""].Value;");


ISpace["MG_P3_Packageprocessmapid"].Value=ISpace["M_PackageProcessMapId"].Value;
base.WriteDebugInfo(@"

ISpace[""MG_P3_Packageprocessmapid""].Value=ISpace[""M_PackageProcessMapId""].Value;");
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("ReimbursementFundDetails","00D69CC2-E6EC-4412-B2A9-14E57A96FB5C",_objectFactory.GetGridRPP("ReimbursementFundDetails"),_elementBase.GetGridLoopQuery("00D69CC2-E6EC-4412-B2A9-14E57A96FB5C","ReimbursementFundDetails",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""ReimbursementFundDetails"",ref ISpace);

foreach(var gridChild in ISpace[""ReimbursementFundDetails""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
object MG_P3_Amount=iSpace.Sum("[00D69CC2-E6EC-4412-B2A9-14E57A96FB5C]","MG_P3_Amount","");
ISpace["MFG_P3_OverallAmount"].Value=Convert.ChangeType(MG_P3_Amount, MG_P3_Amount.GetType());;
base.WriteDebugInfo(@"object MG_P3_Amount=iSpace.Sum(""[00D69CC2-E6EC-4412-B2A9-14E57A96FB5C]"",""MG_P3_Amount"","""");
ISpace[""MFG_P3_OverallAmount""].Value=Convert.ChangeType(MG_P3_Amount, MG_P3_Amount.GetType());;");
ISpace["growid"].Value="";
base.WriteDebugInfo(@"ISpace[""growid""].Value="""";");
ISpace["MFG_P3_FundDetailsId"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_P3_FundDetailsId""].Value="""";");
ISpace["MFG_P3_ReimbursementId"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_P3_ReimbursementId""].Value="""";");
ISpace["MFG_P3_FundTypeId"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_P3_FundTypeId""].Value="""";");
ISpace["MFG_P3_ProjectDetailsId"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_P3_ProjectDetailsId""].Value="""";");
ISpace["MFG_P3_BudgetHeadId"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_P3_BudgetHeadId""].Value="""";");
ISpace["MFG_P3_Amount"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_P3_Amount""].Value="""";");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mfg_p3_fundtypeid (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MFG_P3_FundTypeId-OnChange");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MFG_P3_FundTypeId"].Value=="1")
{
base.WriteDebugInfo(@"if(ISpace[""MFG_P3_FundTypeId""].Value==""1"")");
ISpace["MFG_P3_ProjectDetailsId"].Visible="true";ISpace["MFG_P3_ProjectDetailsId"].Man=true;ISpace["MFG_P3_Amount"].Visible="true";ISpace["MFG_P3_Amount"].Man=true;ISpace["MFG_P3_BudgetHeadId"].Visible="true";ISpace["MFG_P3_BudgetHeadId"].Man=true;
base.WriteDebugInfo(@"ISpace[""MFG_P3_ProjectDetailsId""].Visible=""true"";ISpace[""MFG_P3_ProjectDetailsId""].Man=true;ISpace[""MFG_P3_Amount""].Visible=""true"";ISpace[""MFG_P3_Amount""].Man=true;ISpace[""MFG_P3_BudgetHeadId""].Visible=""true"";ISpace[""MFG_P3_BudgetHeadId""].Man=true;");
ISpace["MFG_P3_BudgetHeadId"].rElemData=iSpace.Reload(ISpace["MFG_P3_BudgetHeadId"].Value,@"exec SP_GetDistrubitionDetails 5,"" + ISpace["M_PackageProcessMapId"].Value + @"","" + ISpace["MFG_P3_FundTypeId"].Value + @"","","","","","" + ISpace["MFG_P3_ProjectDetailsId"].Value + @""","9ADED37B-CD11-426B-AF16-DEAC75685EF5");
base.WriteDebugInfo(@"ISpace[""MFG_P3_BudgetHeadId""].rElemData=iSpace.Reload(ISpace[""MFG_P3_BudgetHeadId""].Value,@""exec SP_GetDistrubitionDetails 5,"""" + ISpace[""M_PackageProcessMapId""].Value + @"""","""" + ISpace[""MFG_P3_FundTypeId""].Value + @"""","""","""","""","""","""" + ISpace[""MFG_P3_ProjectDetailsId""].Value + @"""""",""9ADED37B-CD11-426B-AF16-DEAC75685EF5"");");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MFG_P3_ProjectDetailsId"].Visible="false";ISpace["MFG_P3_ProjectDetailsId"].Man=false;ISpace["MFG_P3_Amount"].Visible="true";ISpace["MFG_P3_Amount"].Man=true;ISpace["MFG_P3_BudgetHeadId"].Visible="false";ISpace["MFG_P3_BudgetHeadId"].Man=false;
base.WriteDebugInfo(@"ISpace[""MFG_P3_ProjectDetailsId""].Visible=""false"";ISpace[""MFG_P3_ProjectDetailsId""].Man=false;ISpace[""MFG_P3_Amount""].Visible=""true"";ISpace[""MFG_P3_Amount""].Man=true;ISpace[""MFG_P3_BudgetHeadId""].Visible=""false"";ISpace[""MFG_P3_BudgetHeadId""].Man=false;");
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["MFG_P3_ProjectDetailsId"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_P3_ProjectDetailsId""].Value="""";");
ISpace["MFG_P3_BudgetHeadId"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_P3_BudgetHeadId""].Value="""";");
ISpace["MFG_P3_Amount"].Value=0;
base.WriteDebugInfo(@"ISpace[""MFG_P3_Amount""].Value=0;");
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mfg_p3_projectdetailsid (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MFG_P3_ProjectDetailsId-OnChange");
ISpace["MFG_P3_BudgetHeadId"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_P3_BudgetHeadId""].Value="""";");
ISpace["MFG_P3_BudgetHeadId"].rElemData=iSpace.Reload(ISpace["MFG_P3_BudgetHeadId"].Value,@"exec SP_GetDistrubitionDetails 5,"" + ISpace["M_PackageProcessMapId"].Value + @"","" + ISpace["MFG_P3_FundTypeId"].Value + @"","","","","","" + ISpace["MFG_P3_ProjectDetailsId"].Value + @""","9ADED37B-CD11-426B-AF16-DEAC75685EF5");
base.WriteDebugInfo(@"ISpace[""MFG_P3_BudgetHeadId""].rElemData=iSpace.Reload(ISpace[""MFG_P3_BudgetHeadId""].Value,@""exec SP_GetDistrubitionDetails 5,"""" + ISpace[""M_PackageProcessMapId""].Value + @"""","""" + ISpace[""MFG_P3_FundTypeId""].Value + @"""","""","""","""","""","""" + ISpace[""MFG_P3_ProjectDetailsId""].Value + @"""""",""9ADED37B-CD11-426B-AF16-DEAC75685EF5"");");
ISpace["MFG_P3_Amount"].Value=0;
base.WriteDebugInfo(@"ISpace[""MFG_P3_Amount""].Value=0;");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_ui_no (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"UI_No-OnClick");
ISpace["growid"].Value="";
base.WriteDebugInfo(@"ISpace[""growid""].Value="""";");
ISpace["UI_DeleteDialog"].HideDialog=true;;
base.WriteDebugInfo(@"ISpace[""UI_DeleteDialog""].HideDialog=true;;");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mfg_p3_budgetheadid (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MFG_P3_BudgetHeadId-OnChange");
ISpace["MFG_P3_Amount"].Value=0;
base.WriteDebugInfo(@"ISpace[""MFG_P3_Amount""].Value=0;");
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
		if(elementName.ToLower().Equals("mga_amount"))
    {
    			SubscribeElementEvents_mga_amount(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mfg_p3_fundtypeid"))
    {
    			SubscribeElementEvents_mfg_p3_fundtypeid(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mfg_p3_projectdetailsid"))
    {
    			SubscribeElementEvents_mfg_p3_projectdetailsid(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mfg_p3_budgetheadid"))
    {
    			SubscribeElementEvents_mfg_p3_budgetheadid(ref dfsParam);
    }
}
	if(methodName.ToLower().Equals("onclick"))
{
		if(elementName.ToLower().Equals("submitform"))
{
			SubscribeElementEvents_submitform(ref dfsParam);
}
		if(elementName.ToLower().Equals("save_reimbursementbilldetails"))
{
			SubscribeElementEvents_save_reimbursementbilldetails(ref dfsParam);
}
		if(elementName.ToLower().Equals("mg_p3_delete"))
{
			SubscribeElementEvents_mg_p3_delete(ref dfsParam);
}
		if(elementName.ToLower().Equals("edit_reimbursementfunddetails"))
{
			SubscribeElementEvents_edit_reimbursementfunddetails(ref dfsParam);
}
		if(elementName.ToLower().Equals("edit_reimbursementbilldetails"))
{
			SubscribeElementEvents_edit_reimbursementbilldetails(ref dfsParam);
}
		if(elementName.ToLower().Equals("save_reimbursementfunddetails"))
{
			SubscribeElementEvents_save_reimbursementfunddetails(ref dfsParam);
}
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
public class ISpace1E274DA615154B96B9224B5CC5F2D423 : VirtualForm
{
IISpace iSpace = new ISpace();
AcDataISpace1E274DA615154B96B9224B5CC5F2D423 acdataIspace1E274DA615154B96B9224B5CC5F2D423=new AcDataISpace1E274DA615154B96B9224B5CC5F2D423();
private void SubscribeFormEvents_root(ref Dictionary<string, ServiceElementData> ISpace)
{
try
{
base.WriteDebugInfo(@"Root-OnAfterFormLoad");
ISpace["M_SourceActivityMapId"].Value=ISpace["gv_activitymapid"].Value;
base.WriteDebugInfo(@"ISpace[""M_SourceActivityMapId""].Value=ISpace[""gv_activitymapid""].Value;");
ISpace["M_PackageProcessMapId"].Value=ISpace["gv_processmapid"].Value;
base.WriteDebugInfo(@"ISpace[""M_PackageProcessMapId""].Value=ISpace[""gv_processmapid""].Value;");
ISpace["M_InstanceId"].Value=ISpace["gv_instanceid"].Value;
base.WriteDebugInfo(@"ISpace[""M_InstanceId""].Value=ISpace[""gv_instanceid""].Value;");
ISpace["M_IsSourceStep"].Value=0;
base.WriteDebugInfo(@"ISpace[""M_IsSourceStep""].Value=0;");


ISpace["M_MoveTo"].Man=true;
base.WriteDebugInfo(@"ISpace[""M_MoveTo""].Man=true;");
ISpace["MF_P1_Remarks"].Value="";
base.WriteDebugInfo(@"ISpace[""MF_P1_Remarks""].Value="""";");
ISpace["M_NextStage"].Value="";
base.WriteDebugInfo(@"ISpace[""M_NextStage""].Value="""";");

var querySource8BBB2BE71E8540E59B13CC03C350EAB8 =GetQueryExpressionDataSource("8BBB2BE7-1E85-40E5-9B13-CC03C350EAB8");

DataTable result8BBB2BE71E8540E59B13CC03C350EAB8=iSpace.SetGridDataSource(querySource8BBB2BE71E8540E59B13CC03C350EAB8, _objectFactory.GetGridRPP("MG_RemarksDetails"),@"EXEC GetRemarks "" + ISpace["M_InstanceId"].Value + @""");

iSpace.InsertGridBindDetails("MG_RemarksDetails","11",querySource8BBB2BE71E8540E59B13CC03C350EAB8,"EXEC GetRemarks "" + ISpace["M_InstanceId"].Value + @""",_objectFactory.GetGridRPP("MG_RemarksDetails"));

base.WriteDebugInfo(@"var querySource8BBB2BE71E8540E59B13CC03C350EAB8 =GetQueryExpressionDataSource(""8BBB2BE7-1E85-40E5-9B13-CC03C350EAB8"");DataTable result8BBB2BE71E8540E59B13CC03C350EAB8=iSpace.SetGridDataSource(querySource8BBB2BE71E8540E59B13CC03C350EAB8, _objectFactory.GetGridRPP(""MG_RemarksDetails""),@""EXEC GetRemarks """" + ISpace[""M_InstanceId""].Value + @"""""");iSpace.InsertGridBindDetails(""MG_RemarksDetails"",""11"",querySource8BBB2BE71E8540E59B13CC03C350EAB8,""EXEC GetRemarks """" + ISpace[""M_InstanceId""].Value + @"""""",_objectFactory.GetGridRPP(""MG_RemarksDetails""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> resultCA798124C2C446CCBDA6419353320A96=acdataIspace1E274DA615154B96B9224B5CC5F2D423.GetQueryExpressionBindings("CA798124-C2C4-46CC-BDA6-419353320A96");
iSpace.SetGridData(result8BBB2BE71E8540E59B13CC03C350EAB8,resultCA798124C2C446CCBDA6419353320A96,"MG_RemarksDetails",ref ISpace);
iSpace.UpdateGridBindDetails("MG_RemarksDetails",resultCA798124C2C446CCBDA6419353320A96);
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["MF_P1_ApplicationStatus"].Visible="false";ISpace["MFG_P2_ReimbursementDetailsId"].Visible="false";ISpace["MF_P1_EmployeeBasicInfoId"].Visible="false";ISpace["MFG_P3_FundDetailsId"].Visible="false";ISpace["MFG_P2_BillDocument"].Visible="false";ISpace["MF_P1_UpdatedBy"].Visible="false";ISpace["MF_P1_Initiatedon"].Visible="false";ISpace["MFG_P3_ReimbursementId"].Visible="false";ISpace["MFG_P2_BillDate"].Visible="false";ISpace["MF_P1_TotalAmount"].Visible="true";ISpace["MF_P1_InitatedBy"].Visible="false";ISpace["MFG_P2_ReimbursementId"].Visible="false";ISpace["MFG_P2_BillNo"].Visible="false";ISpace["MFG_P2_Amount"].Visible="false";ISpace["MF_P1_UpdatedOn"].Visible="false";ISpace["MFG_P3_FundTypeId"].Visible="false";ISpace["MFG_P3_ProjectDetailsId"].Visible="false";ISpace["MFG_P3_Amount"].Visible="false";ISpace["MFG_P2_ItemDescription"].Visible="false";ISpace["MF_P1_ReimbursementId"].Visible="false";ISpace["MFG_P3_BudgetHeadId"].Visible="false";
base.WriteDebugInfo(@"ISpace[""MF_P1_ApplicationStatus""].Visible=""false"";ISpace[""MFG_P2_ReimbursementDetailsId""].Visible=""false"";ISpace[""MF_P1_EmployeeBasicInfoId""].Visible=""false"";ISpace[""MFG_P3_FundDetailsId""].Visible=""false"";ISpace[""MFG_P2_BillDocument""].Visible=""false"";ISpace[""MF_P1_UpdatedBy""].Visible=""false"";ISpace[""MF_P1_Initiatedon""].Visible=""false"";ISpace[""MFG_P3_ReimbursementId""].Visible=""false"";ISpace[""MFG_P2_BillDate""].Visible=""false"";ISpace[""MF_P1_TotalAmount""].Visible=""true"";ISpace[""MF_P1_InitatedBy""].Visible=""false"";ISpace[""MFG_P2_ReimbursementId""].Visible=""false"";ISpace[""MFG_P2_BillNo""].Visible=""false"";ISpace[""MFG_P2_Amount""].Visible=""false"";ISpace[""MF_P1_UpdatedOn""].Visible=""false"";ISpace[""MFG_P3_FundTypeId""].Visible=""false"";ISpace[""MFG_P3_ProjectDetailsId""].Visible=""false"";ISpace[""MFG_P3_Amount""].Visible=""false"";ISpace[""MFG_P2_ItemDescription""].Visible=""false"";ISpace[""MF_P1_ReimbursementId""].Visible=""false"";ISpace[""MFG_P3_BudgetHeadId""].Visible=""false"";");
ISpace["MG_P2_BillNo"].Visible="true";ISpace["MG_P2_BillDocument"].Visible="false";ISpace["MG_P2_ReimbursementDetailsId"].Visible="false";ISpace["MG_P2_ReimbursementId"].Visible="false";ISpace["MG_P2_ItemDescription"].Visible="true";ISpace["MG_P2_BillDate"].Visible="true";ISpace["MG_P2_Amount"].Visible="true";
base.WriteDebugInfo(@"ISpace[""MG_P2_BillNo""].Visible=""true"";ISpace[""MG_P2_BillDocument""].Visible=""false"";ISpace[""MG_P2_ReimbursementDetailsId""].Visible=""false"";ISpace[""MG_P2_ReimbursementId""].Visible=""false"";ISpace[""MG_P2_ItemDescription""].Visible=""true"";ISpace[""MG_P2_BillDate""].Visible=""true"";ISpace[""MG_P2_Amount""].Visible=""true"";");
ISpace["MG_P3_ProjectDetailsId"].Visible="true";ISpace["MG_P3_BudgetHeadId"].Visible="true";ISpace["MG_P3_FundTypeId"].Visible="true";ISpace["MG_P3_FundDetailsId"].Visible="false";ISpace["MG_P3_Amount"].Visible="true";ISpace["MG_P3_ReimbursementId"].Visible="false";
base.WriteDebugInfo(@"ISpace[""MG_P3_ProjectDetailsId""].Visible=""true"";ISpace[""MG_P3_BudgetHeadId""].Visible=""true"";ISpace[""MG_P3_FundTypeId""].Visible=""true"";ISpace[""MG_P3_FundDetailsId""].Visible=""false"";ISpace[""MG_P3_Amount""].Visible=""true"";ISpace[""MG_P3_ReimbursementId""].Visible=""false"";");
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_submitform (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"SubmitForm-OnClick");
base.WriteDebugInfo(@"Entering DomainDataMap for Remarks Domain");
var RemarksDomain_repoObj = new RepositoryMapper(DbTypes.SQLServer);


var ActivityTrailLogDetailsRemarksDomaintableObj = new RepositoryTable("ActivityTrailLogDetails");
  ActivityTrailLogDetailsRemarksDomaintableObj.AppConnectionSettingsId  ="9ADED37B-CD11-426B-AF16-DEAC75685EF5";ActivityTrailLogDetailsRemarksDomaintableObj.ProofConnectionId = "C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0)";
var RemarksDomain_ActivityTrailLogDetails_rows = GetElementClientData(ISpace["InstanceId"].Value,"6B463D69-64AB-468E-B2E3-DB12E6B90014");

if(RemarksDomain_ActivityTrailLogDetails_rows!=null && RemarksDomain_ActivityTrailLogDetails_rows.Count>0){
var RemarksDomain_ActivityTrailLogDetails_rowsObj = new List<RepositoryRow>();
foreach(var rows in RemarksDomain_ActivityTrailLogDetails_rows){RepositoryRow repositoryRowObj = null;string elementData = null;RepositoryColumn repositoryColumnObj = null;if(rows !=null){ var ActivityTrailLogDetails_colObj = new List<RepositoryColumn>();repositoryRowObj= new RepositoryRow();//var myByte = (byte)rowData.Value.RwSt;//repositoryRowObj.RowState=(RepositoryRowState)myByte;

if(rows.ContainsKey("5354760A-9EAC-491E-BAB1-C3614187A9BE"))     elementData = rows["5354760A-9EAC-491E-BAB1-C3614187A9BE"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ProcessedInProgressFlag",false,false,5);
if(repositoryColumnObj!=null)ActivityTrailLogDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-M_IsSourceStep not found");}

elementData = CurrentDate().ToString() ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Updatedon",false,false,8);
if(repositoryColumnObj!=null)ActivityTrailLogDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-CurrentDate not found");}

if(rows.ContainsKey("D7BB255E-9A01-4B5B-AE06-CC4D6E088D52"))     elementData = rows["D7BB255E-9A01-4B5B-AE06-CC4D6E088D52"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"InstanceID",false,false,9);
if(repositoryColumnObj!=null)ActivityTrailLogDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-M_InstanceId not found");}

elementData = ISpace["gv_UserId"].Value != null? Convert.ToString(ISpace["gv_UserId"].Value):null ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Updatedby",false,false,6);
if(repositoryColumnObj!=null)ActivityTrailLogDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-gv_UserId not found");}

if(rows.ContainsKey("6DB9BC45-F167-4D8A-9596-1DBA9872F253"))     elementData = rows["6DB9BC45-F167-4D8A-9596-1DBA9872F253"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"DestinationActivityMapID",false,false,9);
if(repositoryColumnObj!=null)ActivityTrailLogDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-M_DestinationActivityId not found");}

elementData = ISpace["gv_UserName"].Value != null? Convert.ToString(ISpace["gv_UserName"].Value):null ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"RemarksBy",false,false,9);
if(repositoryColumnObj!=null)ActivityTrailLogDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-gv_UserName not found");}

elementData = ISpace["gv_ActivityName"].Value != null? Convert.ToString(ISpace["gv_ActivityName"].Value):null ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ActivityName",false,false,9);
if(repositoryColumnObj!=null)ActivityTrailLogDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-gv_ActivityName not found");}

if(rows.ContainsKey("F78328FF-68D9-45E9-BC40-27CD650C9D6C"))     elementData = rows["F78328FF-68D9-45E9-BC40-27CD650C9D6C"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Remarks",false,false,9);
if(repositoryColumnObj!=null)ActivityTrailLogDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MF_P1_Remarks not found");}

elementData = ISpace["gv_TenantId"].Value != null? Convert.ToString(ISpace["gv_TenantId"].Value):null ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"TenantID",false,false,9);
if(repositoryColumnObj!=null)ActivityTrailLogDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-gv_TenantId not found");}

elementData = Guid.NewGuid().ToString();if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"TrailLogId",true,false,9);
if(repositoryColumnObj!=null)ActivityTrailLogDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-GUID not found");}

if(rows.ContainsKey("52A564C4-B656-4F43-B6F3-E592002351F6"))     elementData = rows["52A564C4-B656-4F43-B6F3-E592002351F6"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"SourceActivityMapID",false,false,9);
if(repositoryColumnObj!=null)ActivityTrailLogDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-M_SourceActivityMapId not found");}

elementData = CurrentDate().ToString() ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"RemarksOn",false,false,8);
if(repositoryColumnObj!=null)ActivityTrailLogDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-CurrentDate not found");}
repositoryRowObj.Columns=ActivityTrailLogDetails_colObj;
RemarksDomain_ActivityTrailLogDetails_rowsObj.Add(repositoryRowObj);
}}

ActivityTrailLogDetailsRemarksDomaintableObj.Rows=RemarksDomain_ActivityTrailLogDetails_rowsObj;
var RemarksDomain_repoObj_status_ActivityTrailLogDetails = RemarksDomain_repoObj.Execute(DomainOperationTypes.CreateOrUpdate,ref ActivityTrailLogDetailsRemarksDomaintableObj);if(!RemarksDomain_repoObj_status_ActivityTrailLogDetails) throw new Exception("Error in Execute Domain Data Map");}
base.WriteDebugInfo(@"Exiting DomainDataMap for Remarks Domain");
if(IsNullOrEmpty(ISpace["Declaration"].Value))
{
base.WriteDebugInfo(@"if(IsNullOrEmpty(ISpace[""Declaration""].Value))");
ISpace["Message"].Value=@"Select the declaration";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Select the declaration"";");
return;
base.WriteDebugInfo(@"return;");
}
if(ISpace["M_SaveDomainData"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""M_SaveDomainData""].Value==1)");
ISpace["MF_P1_ApplicationStatus"].Value="A";
base.WriteDebugInfo(@"ISpace[""MF_P1_ApplicationStatus""].Value=""A"";");
}
if(ISpace["M_SaveDomainData"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""M_SaveDomainData""].Value==1)");
base.WriteDebugInfo(@"Entering DomainDataMap for Project Advance Details REPO 1");
var ProjectAdvanceDetailsREPO1_repoObj = new RepositoryMapper(DbTypes.SQLServer);


var ProjectAdvanceFormProjectAdvanceDetailsREPO1tableObj = new RepositoryTable("ProjectAdvanceForm");
  ProjectAdvanceFormProjectAdvanceDetailsREPO1tableObj.AppConnectionSettingsId  ="3A103712-5244-4427-B2B6-1C4E046FD337";ProjectAdvanceFormProjectAdvanceDetailsREPO1tableObj.ProofConnectionId = "C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0)";
var ProjectAdvanceDetailsREPO1_ProjectAdvanceForm_rows = GetElementClientData(ISpace["InstanceId"].Value,"6B463D69-64AB-468E-B2E3-DB12E6B90014");

if(ProjectAdvanceDetailsREPO1_ProjectAdvanceForm_rows!=null && ProjectAdvanceDetailsREPO1_ProjectAdvanceForm_rows.Count>0){
var ProjectAdvanceDetailsREPO1_ProjectAdvanceForm_rowsObj = new List<RepositoryRow>();
foreach(var rows in ProjectAdvanceDetailsREPO1_ProjectAdvanceForm_rows){RepositoryRow repositoryRowObj = null;string elementData = null;RepositoryColumn repositoryColumnObj = null;if(rows !=null){ var ProjectAdvanceForm_colObj = new List<RepositoryColumn>();repositoryRowObj= new RepositoryRow();//var myByte = (byte)rowData.Value.RwSt;//repositoryRowObj.RowState=(RepositoryRowState)myByte;

if(rows.ContainsKey("72A0167C-47E6-4BBA-964A-D18B4C2724BE"))     elementData = rows["72A0167C-47E6-4BBA-964A-D18B4C2724BE"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"AdvanceFormId",true,false,9);
if(repositoryColumnObj!=null)ProjectAdvanceForm_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-M_Advanceformid not found");}

elementData = ISpace["gv_UserName"].Value != null? Convert.ToString(ISpace["gv_UserName"].Value):null ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"InitatedBy",false,false,9);
if(repositoryColumnObj!=null)ProjectAdvanceForm_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-gv_UserName not found");}

elementData = ISpace["gv_UserName"].Value != null? Convert.ToString(ISpace["gv_UserName"].Value):null ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"UpdatedBy",false,false,9);
if(repositoryColumnObj!=null)ProjectAdvanceForm_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-gv_UserName not found");}

if(rows.ContainsKey("16BFBC4B-9CB5-4677-AAE8-85CE6C7260E5"))     elementData = rows["16BFBC4B-9CB5-4677-AAE8-85CE6C7260E5"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ApplicationStatus",false,false,9);
if(repositoryColumnObj!=null)ProjectAdvanceForm_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MF_P1_ApplicationStatus not found");}

if(rows.ContainsKey("329D5240-1DBD-433E-A8EB-0F29F5AA668C"))     elementData = rows["329D5240-1DBD-433E-A8EB-0F29F5AA668C"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"EmployeeBasicInfoId",false,false,9);
if(repositoryColumnObj!=null)ProjectAdvanceForm_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-UC_EmployeeBaicInfoId not found");}

if(rows.ContainsKey("68A2EC13-D240-4EBC-8828-E795581544DA"))     elementData = rows["68A2EC13-D240-4EBC-8828-E795581544DA"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"TotalAmount",false,false,3);
if(repositoryColumnObj!=null)ProjectAdvanceForm_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MF_P1_TotalAmount not found");}

elementData = CurrentDate().ToString() ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Initiatedon",false,false,8);
if(repositoryColumnObj!=null)ProjectAdvanceForm_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-CurrentDate not found");}

elementData = CurrentDate().ToString() ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"UpdatedOn",false,false,8);
if(repositoryColumnObj!=null)ProjectAdvanceForm_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-CurrentDate not found");}
repositoryRowObj.Columns=ProjectAdvanceForm_colObj;
ProjectAdvanceDetailsREPO1_ProjectAdvanceForm_rowsObj.Add(repositoryRowObj);
}}

ProjectAdvanceFormProjectAdvanceDetailsREPO1tableObj.Rows=ProjectAdvanceDetailsREPO1_ProjectAdvanceForm_rowsObj;
var ProjectAdvanceDetailsREPO1_repoObj_status_ProjectAdvanceForm = ProjectAdvanceDetailsREPO1_repoObj.Execute(DomainOperationTypes.CreateOrUpdate,ref ProjectAdvanceFormProjectAdvanceDetailsREPO1tableObj);if(!ProjectAdvanceDetailsREPO1_repoObj_status_ProjectAdvanceForm) throw new Exception("Error in Execute Domain Data Map");}
base.WriteDebugInfo(@"Exiting DomainDataMap for Project Advance Details REPO 1");
base.WriteDebugInfo(@"Entering DomainDataMap for Project Advance Details REPO 2");
var ProjectAdvanceDetailsREPO2_repoObj = new RepositoryMapper(DbTypes.SQLServer);


var ProjectAdvanceFundDetailsProjectAdvanceDetailsREPO2tableObj = new RepositoryTable("ProjectAdvanceFundDetails");
  ProjectAdvanceFundDetailsProjectAdvanceDetailsREPO2tableObj.AppConnectionSettingsId  ="3A103712-5244-4427-B2B6-1C4E046FD337";ProjectAdvanceFundDetailsProjectAdvanceDetailsREPO2tableObj.ProofConnectionId = "C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0)";
var ProjectAdvanceDetailsREPO2_ProjectAdvanceFundDetails_rows = GetElementClientData(ISpace["InstanceId"].Value,"00D69CC2-E6EC-4412-B2A9-14E57A96FB5C");

if(ProjectAdvanceDetailsREPO2_ProjectAdvanceFundDetails_rows!=null && ProjectAdvanceDetailsREPO2_ProjectAdvanceFundDetails_rows.Count>0){
var ProjectAdvanceDetailsREPO2_ProjectAdvanceFundDetails_rowsObj = new List<RepositoryRow>();
foreach(var rows in ProjectAdvanceDetailsREPO2_ProjectAdvanceFundDetails_rows){RepositoryRow repositoryRowObj = null;string elementData = null;RepositoryColumn repositoryColumnObj = null;if(rows !=null){ var ProjectAdvanceFundDetails_colObj = new List<RepositoryColumn>();repositoryRowObj= new RepositoryRow();//var myByte = (byte)rowData.Value.RwSt;//repositoryRowObj.RowState=(RepositoryRowState)myByte;

if(rows.ContainsKey("E20A9876-034C-49BC-A309-26338AAD45BD"))     elementData = rows["E20A9876-034C-49BC-A309-26338AAD45BD"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"AdvanceFormId",false,false,9);
if(repositoryColumnObj!=null)ProjectAdvanceFundDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MG_P3_Advanceformid not found");}

if(rows.ContainsKey("B24F329A-C286-4040-ABD2-B67B5AE4F7BE"))     elementData = rows["B24F329A-C286-4040-ABD2-B67B5AE4F7BE"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"FundDetailsId",true,false,9);
if(repositoryColumnObj!=null)ProjectAdvanceFundDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MG_P3_FundDetailsId not found");}

if(rows.ContainsKey("4F81555E-3503-43B3-AD28-23293B41E926"))     elementData = rows["4F81555E-3503-43B3-AD28-23293B41E926"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ProjectDetailsId",false,false,9);
if(repositoryColumnObj!=null)ProjectAdvanceFundDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MG_P3_ProjectDetailsId not found");}

if(rows.ContainsKey("CCBB2219-451D-4EAE-BA26-1C16A9B0FF7D"))     elementData = rows["CCBB2219-451D-4EAE-BA26-1C16A9B0FF7D"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Amount",false,false,3);
if(repositoryColumnObj!=null)ProjectAdvanceFundDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MG_P3_Amount not found");}

if(rows.ContainsKey("8F687AA1-A6B1-4250-9948-DBAF2D40AB51"))     elementData = rows["8F687AA1-A6B1-4250-9948-DBAF2D40AB51"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"BudgetHeadId",false,false,9);
if(repositoryColumnObj!=null)ProjectAdvanceFundDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MG_P3_BudgetHeadId not found");}

if(rows.ContainsKey("99E459F3-F338-40A6-A1E3-1F7AD7A198CD"))     elementData = rows["99E459F3-F338-40A6-A1E3-1F7AD7A198CD"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"FundTypeId",false,false,6);
if(repositoryColumnObj!=null)ProjectAdvanceFundDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MG_P3_FundTypeId not found");}
repositoryRowObj.Columns=ProjectAdvanceFundDetails_colObj;
ProjectAdvanceDetailsREPO2_ProjectAdvanceFundDetails_rowsObj.Add(repositoryRowObj);
}}

ProjectAdvanceFundDetailsProjectAdvanceDetailsREPO2tableObj.Rows=ProjectAdvanceDetailsREPO2_ProjectAdvanceFundDetails_rowsObj;
var ProjectAdvanceDetailsREPO2_repoObj_status_ProjectAdvanceFundDetails = ProjectAdvanceDetailsREPO2_repoObj.Execute(DomainOperationTypes.CreateOrUpdate,ref ProjectAdvanceFundDetailsProjectAdvanceDetailsREPO2tableObj);if(!ProjectAdvanceDetailsREPO2_repoObj_status_ProjectAdvanceFundDetails) throw new Exception("Error in Execute Domain Data Map");}
base.WriteDebugInfo(@"Exiting DomainDataMap for Project Advance Details REPO 2");
base.WriteDebugInfo(@"Entering DomainDataMap for Project Advance Details REPO 3");
var ProjectAdvanceDetailsREPO3_repoObj = new RepositoryMapper(DbTypes.SQLServer);


var ProjectAdvanceRequestDetailsProjectAdvanceDetailsREPO3tableObj = new RepositoryTable("ProjectAdvanceRequestDetails");
  ProjectAdvanceRequestDetailsProjectAdvanceDetailsREPO3tableObj.AppConnectionSettingsId  ="3A103712-5244-4427-B2B6-1C4E046FD337";ProjectAdvanceRequestDetailsProjectAdvanceDetailsREPO3tableObj.ProofConnectionId = "C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0)";
var ProjectAdvanceDetailsREPO3_ProjectAdvanceRequestDetails_rows = GetElementClientData(ISpace["InstanceId"].Value,"1356A8F2-1947-4667-987D-2EA211B288A3");

if(ProjectAdvanceDetailsREPO3_ProjectAdvanceRequestDetails_rows!=null && ProjectAdvanceDetailsREPO3_ProjectAdvanceRequestDetails_rows.Count>0){
var ProjectAdvanceDetailsREPO3_ProjectAdvanceRequestDetails_rowsObj = new List<RepositoryRow>();
foreach(var rows in ProjectAdvanceDetailsREPO3_ProjectAdvanceRequestDetails_rows){RepositoryRow repositoryRowObj = null;string elementData = null;RepositoryColumn repositoryColumnObj = null;if(rows !=null){ var ProjectAdvanceRequestDetails_colObj = new List<RepositoryColumn>();repositoryRowObj= new RepositoryRow();//var myByte = (byte)rowData.Value.RwSt;//repositoryRowObj.RowState=(RepositoryRowState)myByte;

if(rows.ContainsKey("04D90722-37D7-40B0-96B6-D6CA55ABA8F2"))     elementData = rows["04D90722-37D7-40B0-96B6-D6CA55ABA8F2"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ExpenseDetails",false,false,9);
if(repositoryColumnObj!=null)ProjectAdvanceRequestDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MGA_DetailsofExpenses not found");}

if(rows.ContainsKey("B1EB21F5-30E2-4DB3-B72E-E6BB3E4A1D2B"))     elementData = rows["B1EB21F5-30E2-4DB3-B72E-E6BB3E4A1D2B"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ItemDescription",false,false,9);
if(repositoryColumnObj!=null)ProjectAdvanceRequestDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MGA_Description not found");}

if(rows.ContainsKey("8E8892C8-B328-42D2-A630-B8A2C3C4D26B"))     elementData = rows["8E8892C8-B328-42D2-A630-B8A2C3C4D26B"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Amount",false,false,3);
if(repositoryColumnObj!=null)ProjectAdvanceRequestDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MGA_Amount not found");}

if(rows.ContainsKey("67C65E87-8293-495E-97A2-E7431BF75D69"))     elementData = rows["67C65E87-8293-495E-97A2-E7431BF75D69"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"RequestDetailsId",true,false,9);
if(repositoryColumnObj!=null)ProjectAdvanceRequestDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MGA_RequestDetailsId not found");}

if(rows.ContainsKey("6E5FD9F2-E29C-4922-B6C5-78C591A395A6"))     elementData = rows["6E5FD9F2-E29C-4922-B6C5-78C591A395A6"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"AdvanceFormId",false,false,9);
if(repositoryColumnObj!=null)ProjectAdvanceRequestDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MGA_AdvanceFormId not found");}
repositoryRowObj.Columns=ProjectAdvanceRequestDetails_colObj;
ProjectAdvanceDetailsREPO3_ProjectAdvanceRequestDetails_rowsObj.Add(repositoryRowObj);
}}

ProjectAdvanceRequestDetailsProjectAdvanceDetailsREPO3tableObj.Rows=ProjectAdvanceDetailsREPO3_ProjectAdvanceRequestDetails_rowsObj;
var ProjectAdvanceDetailsREPO3_repoObj_status_ProjectAdvanceRequestDetails = ProjectAdvanceDetailsREPO3_repoObj.Execute(DomainOperationTypes.CreateOrUpdate,ref ProjectAdvanceRequestDetailsProjectAdvanceDetailsREPO3tableObj);if(!ProjectAdvanceDetailsREPO3_repoObj_status_ProjectAdvanceRequestDetails) throw new Exception("Error in Execute Domain Data Map");}
base.WriteDebugInfo(@"Exiting DomainDataMap for Project Advance Details REPO 3");
}
if(ISpace["M_IsflowReturned"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""M_IsflowReturned""].Value==1)");
ISpace["AssignToUser"].Value=ISpace["M_InitiatorUserMapId"].Value;
base.WriteDebugInfo(@"ISpace[""AssignToUser""].Value=ISpace[""M_InitiatorUserMapId""].Value;");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["AssignToUser"].Value="";
base.WriteDebugInfo(@"ISpace[""AssignToUser""].Value="""";");
}
base.WriteDebugInfo(@"#ReimbursementFundDetails[Rows]");
iSpace.GetLoopExpressionData("ReimbursementFundDetails",ref ISpace);

foreach(var gridChild in ISpace["ReimbursementFundDetails"].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 


if(
ISpace["M_IsflowReturned"].Value==1)
{
base.WriteDebugInfo(@"
if(
ISpace[""M_IsflowReturned""].Value==1)");
base.WriteDebugInfo(@"EXEC [UpsertProjectBudgetDetails] 6,"#MG_P3_ProjectDetailsId","","#MG_P3_Amount","#MG_P3_BudgetHeadId",1,"#MG_P3_FundTypeId"");

var querySource318EAB61FF354EB2A293264135B2F298 =GetQueryExpressionDataSource("318EAB61-FF35-4EB2-A293-264135B2F298");
Dictionary<short,object> result318EAB61FF354EB2A293264135B2F298=iSpace.ExecuteQuery(querySource318EAB61FF354EB2A293264135B2F298,@"EXEC [UpsertProjectBudgetDetails] 6,"" + ISpace["MG_P3_ProjectDetailsId"].Value + @"","","" + ISpace["MG_P3_Amount"].Value + @"","" + ISpace["MG_P3_BudgetHeadId"].Value + @"",1,"" + ISpace["MG_P3_FundTypeId"].Value + @""",false);

base.WriteDebugInfo(@"var querySource318EAB61FF354EB2A293264135B2F298 =GetQueryExpressionDataSource(""318EAB61-FF35-4EB2-A293-264135B2F298"");Dictionary<short,object> result318EAB61FF354EB2A293264135B2F298=iSpace.ExecuteQuery(querySource318EAB61FF354EB2A293264135B2F298,@""EXEC [UpsertProjectBudgetDetails] 6,"""" + ISpace[""MG_P3_ProjectDetailsId""].Value + @"""","""","""" + ISpace[""MG_P3_Amount""].Value + @"""","""" + ISpace[""MG_P3_BudgetHeadId""].Value + @"""",1,"""" + ISpace[""MG_P3_FundTypeId""].Value + @"""""",false);");
base.WriteDebugInfo(@"");

if((result318EAB61FF354EB2A293264135B2F298!=null) && (result318EAB61FF354EB2A293264135B2F298.Count!=0))
{
if(result318EAB61FF354EB2A293264135B2F298.ContainsKey(0))
ISpace["M_UpdateCount"].Value = result318EAB61FF354EB2A293264135B2F298[0];
}
else{
ISpace["M_UpdateCount"].Value = null;
}
}
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("ReimbursementFundDetails","00D69CC2-E6EC-4412-B2A9-14E57A96FB5C",_objectFactory.GetGridRPP("ReimbursementFundDetails"),_elementBase.GetGridLoopQuery("00D69CC2-E6EC-4412-B2A9-14E57A96FB5C","ReimbursementFundDetails",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""ReimbursementFundDetails"",ref ISpace);

foreach(var gridChild in ISpace[""ReimbursementFundDetails""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["M_MoveTo"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""M_MoveTo""].Value=="""")");
ISpace["Message"].Value=@"Move To should be mandatory";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Move To should be mandatory"";");
return;
base.WriteDebugInfo(@"return;");
}
}
if(ISpace["M_SaveDomainData"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""M_SaveDomainData""].Value==1)");
ISpace["M_Status"].Value="Approved";
base.WriteDebugInfo(@"ISpace[""M_Status""].Value=""Approved"";");
}
if(ISpace["M_IsCancelReject"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""M_IsCancelReject""].Value==1)");
ISpace["M_Status"].Value="Dropped";
base.WriteDebugInfo(@"ISpace[""M_Status""].Value=""Dropped"";");
}
base.WriteDebugInfo(@"Entering DomainDataMap for User Request For other steps");
var UserRequestForothersteps_repoObj = new RepositoryMapper(DbTypes.SQLServer);


var UserRequestsUserRequestForotherstepstableObj = new RepositoryTable("UserRequests");
  UserRequestsUserRequestForotherstepstableObj.AppConnectionSettingsId  ="9ADED37B-CD11-426B-AF16-DEAC75685EF5";UserRequestsUserRequestForotherstepstableObj.ProofConnectionId = "C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0)";
var UserRequestForothersteps_UserRequests_rows = GetElementClientData(ISpace["InstanceId"].Value,"6B463D69-64AB-468E-B2E3-DB12E6B90014");

if(UserRequestForothersteps_UserRequests_rows!=null && UserRequestForothersteps_UserRequests_rows.Count>0){
var UserRequestForothersteps_UserRequests_rowsObj = new List<RepositoryRow>();
foreach(var rows in UserRequestForothersteps_UserRequests_rows){RepositoryRow repositoryRowObj = null;string elementData = null;RepositoryColumn repositoryColumnObj = null;if(rows !=null){ var UserRequests_colObj = new List<RepositoryColumn>();repositoryRowObj= new RepositoryRow();//var myByte = (byte)rowData.Value.RwSt;//repositoryRowObj.RowState=(RepositoryRowState)myByte;

if(rows.ContainsKey("34CFB4AA-E9A1-4EAC-83A8-AEC1C4038EE1"))     elementData = rows["34CFB4AA-E9A1-4EAC-83A8-AEC1C4038EE1"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"CurrentLevel",false,false,9);
if(repositoryColumnObj!=null)UserRequests_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-M_NextStage not found");}

if(rows.ContainsKey("B89FF303-5A1C-4060-BAB9-E6F52A11D9FD"))     elementData = rows["B89FF303-5A1C-4060-BAB9-E6F52A11D9FD"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"CurrentStatus",false,false,9);
if(repositoryColumnObj!=null)UserRequests_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-M_Status not found");}

elementData = ISpace["gv_UserId"].Value != null? Convert.ToString(ISpace["gv_UserId"].Value):null ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"LastModifiedByUserID",false,false,5);
if(repositoryColumnObj!=null)UserRequests_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-gv_UserId not found");}

if(rows.ContainsKey("0CDC8D38-F4F4-4C60-BCED-E9F0C8B165B8"))     elementData = rows["0CDC8D38-F4F4-4C60-BCED-E9F0C8B165B8"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"CurrentActivityMapID",false,false,9);
if(repositoryColumnObj!=null)UserRequests_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-SetDestinationTo not found");}

if(rows.ContainsKey("D7BB255E-9A01-4B5B-AE06-CC4D6E088D52"))     elementData = rows["D7BB255E-9A01-4B5B-AE06-CC4D6E088D52"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"InstanceID",true,false,9);
if(repositoryColumnObj!=null)UserRequests_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-M_InstanceId not found");}

elementData = CurrentDate().ToString() ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"LastModifiedOn",false,false,8);
if(repositoryColumnObj!=null)UserRequests_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-CurrentDate not found");}
repositoryRowObj.Columns=UserRequests_colObj;
UserRequestForothersteps_UserRequests_rowsObj.Add(repositoryRowObj);
}}

UserRequestsUserRequestForotherstepstableObj.Rows=UserRequestForothersteps_UserRequests_rowsObj;
var UserRequestForothersteps_repoObj_status_UserRequests = UserRequestForothersteps_repoObj.Execute(DomainOperationTypes.Update,ref UserRequestsUserRequestForotherstepstableObj);if(!UserRequestForothersteps_repoObj_status_UserRequests) throw new Exception("Error in Execute Domain Data Map");}
base.WriteDebugInfo(@"Exiting DomainDataMap for User Request For other steps");
ISpace["Message"].Value=@"Submitted Successfully";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Submitted Successfully"";");
ISpace.ExecuteInstanceCommand("Submit");
base.WriteDebugInfo(@"ISpace.ExecuteInstanceCommand(""Submit"");");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_save_reimbursementbilldetails (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Save_ReimbursementBillDetails-OnClick");
if(ISpace["growid"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""growid""].Value=="""")");

var querySource588878D7B7824F24BAF7A4FE902E4A93 =GetQueryExpressionDataSource("588878D7-B782-4F24-BAF7-A4FE902E4A93");

DataTable result588878D7B7824F24BAF7A4FE902E4A93=iSpace.SetGridDataSource(querySource588878D7B7824F24BAF7A4FE902E4A93, _objectFactory.GetGridRPP("ReimbursementBillDetails"),@"EXEC AddFormGridDataC9ACCA847AF347E79133D777BE46A656 "" + ISpace["gv_instanceid"].Value + @"","" + ISpace["gv_processmapid"].Value + @"","C9ACCA84-7AF3-47E7-9133-D777BE46A656","" + ISpace["gv_activitymapid"].Value + @"","" + ISpace["MFG_P2_ReimbursementDetailsId"].Value + @"","" + ISpace["MFG_P2_ReimbursementId"].Value + @"","" + ISpace["MFG_P2_BillNo"].Value + @"","" + ISpace["MFG_P2_BillDate"].Value + @""," + ISpace["MFG_P2_BillDocument"].Value + @","" + ISpace["MFG_P2_ItemDescription"].Value + @""," + ISpace["MFG_P2_Amount"].Value + @","" + ISpace["growid"].Value + @""");

iSpace.InsertGridBindDetails("ReimbursementBillDetails","11",querySource588878D7B7824F24BAF7A4FE902E4A93,"EXEC AddFormGridDataC9ACCA847AF347E79133D777BE46A656 "" + ISpace["gv_instanceid"].Value + @"","" + ISpace["gv_processmapid"].Value + @"","C9ACCA84-7AF3-47E7-9133-D777BE46A656","" + ISpace["gv_activitymapid"].Value + @"","" + ISpace["MFG_P2_ReimbursementDetailsId"].Value + @"","" + ISpace["MFG_P2_ReimbursementId"].Value + @"","" + ISpace["MFG_P2_BillNo"].Value + @"","" + ISpace["MFG_P2_BillDate"].Value + @""," + ISpace["MFG_P2_BillDocument"].Value + @","" + ISpace["MFG_P2_ItemDescription"].Value + @""," + ISpace["MFG_P2_Amount"].Value + @","" + ISpace["growid"].Value + @""",_objectFactory.GetGridRPP("ReimbursementBillDetails"));

base.WriteDebugInfo(@"var querySource588878D7B7824F24BAF7A4FE902E4A93 =GetQueryExpressionDataSource(""588878D7-B782-4F24-BAF7-A4FE902E4A93"");DataTable result588878D7B7824F24BAF7A4FE902E4A93=iSpace.SetGridDataSource(querySource588878D7B7824F24BAF7A4FE902E4A93, _objectFactory.GetGridRPP(""ReimbursementBillDetails""),@""EXEC AddFormGridDataC9ACCA847AF347E79133D777BE46A656 """" + ISpace[""gv_instanceid""].Value + @"""","""" + ISpace[""gv_processmapid""].Value + @"""",""C9ACCA84-7AF3-47E7-9133-D777BE46A656"","""" + ISpace[""gv_activitymapid""].Value + @"""","""" + ISpace[""MFG_P2_ReimbursementDetailsId""].Value + @"""","""" + ISpace[""MFG_P2_ReimbursementId""].Value + @"""","""" + ISpace[""MFG_P2_BillNo""].Value + @"""","""" + ISpace[""MFG_P2_BillDate""].Value + @"""","" + ISpace[""MFG_P2_BillDocument""].Value + @"","""" + ISpace[""MFG_P2_ItemDescription""].Value + @"""","" + ISpace[""MFG_P2_Amount""].Value + @"","""" + ISpace[""growid""].Value + @"""""");iSpace.InsertGridBindDetails(""ReimbursementBillDetails"",""11"",querySource588878D7B7824F24BAF7A4FE902E4A93,""EXEC AddFormGridDataC9ACCA847AF347E79133D777BE46A656 """" + ISpace[""gv_instanceid""].Value + @"""","""" + ISpace[""gv_processmapid""].Value + @"""",""C9ACCA84-7AF3-47E7-9133-D777BE46A656"","""" + ISpace[""gv_activitymapid""].Value + @"""","""" + ISpace[""MFG_P2_ReimbursementDetailsId""].Value + @"""","""" + ISpace[""MFG_P2_ReimbursementId""].Value + @"""","""" + ISpace[""MFG_P2_BillNo""].Value + @"""","""" + ISpace[""MFG_P2_BillDate""].Value + @"""","" + ISpace[""MFG_P2_BillDocument""].Value + @"","""" + ISpace[""MFG_P2_ItemDescription""].Value + @"""","" + ISpace[""MFG_P2_Amount""].Value + @"","""" + ISpace[""growid""].Value + @"""""",_objectFactory.GetGridRPP(""ReimbursementBillDetails""));");
base.WriteDebugInfo(@"EXEC AddFormGridDataC9ACCA847AF347E79133D777BE46A656 "@@gv_InstanceId","@@gv_ProcessMapId","C9ACCA84-7AF3-47E7-9133-D777BE46A656","@@gv_ActivityMapId","#MFG_P2_ReimbursementDetailsId","#MFG_P2_ReimbursementId","#MFG_P2_BillNo","#MFG_P2_BillDate",#MFG_P2_BillDocument,"#MFG_P2_ItemDescription",#MFG_P2_Amount,"#growid"");


List<Triplet<string, short, short?>> resultAB481A6E87354F09AD1BC0BBEFC0AD56=acdataIspace1E274DA615154B96B9224B5CC5F2D423.GetQueryExpressionBindings("AB481A6E-8735-4F09-AD1B-C0BBEFC0AD56");
iSpace.SetGridData(result588878D7B7824F24BAF7A4FE902E4A93,resultAB481A6E87354F09AD1BC0BBEFC0AD56,"ReimbursementBillDetails",ref ISpace);
iSpace.UpdateGridBindDetails("ReimbursementBillDetails",resultAB481A6E87354F09AD1BC0BBEFC0AD56);
}
else
{
base.WriteDebugInfo(@"else");

var querySourceF3514DB4690A4BE6A6A77FA3D37E5B7C =GetQueryExpressionDataSource("F3514DB4-690A-4BE6-A6A7-7FA3D37E5B7C");

DataTable resultF3514DB4690A4BE6A6A77FA3D37E5B7C=iSpace.SetGridDataSource(querySourceF3514DB4690A4BE6A6A77FA3D37E5B7C, _objectFactory.GetGridRPP("ReimbursementBillDetails"),@"EXEC UpdateFormGridDataC9ACCA847AF347E79133D777BE46A656 "" + ISpace["gv_instanceid"].Value + @"","" + ISpace["gv_processmapid"].Value + @"","C9ACCA84-7AF3-47E7-9133-D777BE46A656","" + ISpace["gv_activitymapid"].Value + @"","" + ISpace["MFG_P2_ReimbursementDetailsId"].Value + @"","" + ISpace["MFG_P2_ReimbursementId"].Value + @"","" + ISpace["MFG_P2_BillNo"].Value + @"","" + ISpace["MFG_P2_BillDate"].Value + @""," + ISpace["MFG_P2_BillDocument"].Value + @","" + ISpace["MFG_P2_ItemDescription"].Value + @""," + ISpace["MFG_P2_Amount"].Value + @","" + ISpace["growid"].Value + @""");

iSpace.InsertGridBindDetails("ReimbursementBillDetails","11",querySourceF3514DB4690A4BE6A6A77FA3D37E5B7C,"EXEC UpdateFormGridDataC9ACCA847AF347E79133D777BE46A656 "" + ISpace["gv_instanceid"].Value + @"","" + ISpace["gv_processmapid"].Value + @"","C9ACCA84-7AF3-47E7-9133-D777BE46A656","" + ISpace["gv_activitymapid"].Value + @"","" + ISpace["MFG_P2_ReimbursementDetailsId"].Value + @"","" + ISpace["MFG_P2_ReimbursementId"].Value + @"","" + ISpace["MFG_P2_BillNo"].Value + @"","" + ISpace["MFG_P2_BillDate"].Value + @""," + ISpace["MFG_P2_BillDocument"].Value + @","" + ISpace["MFG_P2_ItemDescription"].Value + @""," + ISpace["MFG_P2_Amount"].Value + @","" + ISpace["growid"].Value + @""",_objectFactory.GetGridRPP("ReimbursementBillDetails"));

base.WriteDebugInfo(@"var querySourceF3514DB4690A4BE6A6A77FA3D37E5B7C =GetQueryExpressionDataSource(""F3514DB4-690A-4BE6-A6A7-7FA3D37E5B7C"");DataTable resultF3514DB4690A4BE6A6A77FA3D37E5B7C=iSpace.SetGridDataSource(querySourceF3514DB4690A4BE6A6A77FA3D37E5B7C, _objectFactory.GetGridRPP(""ReimbursementBillDetails""),@""EXEC UpdateFormGridDataC9ACCA847AF347E79133D777BE46A656 """" + ISpace[""gv_instanceid""].Value + @"""","""" + ISpace[""gv_processmapid""].Value + @"""",""C9ACCA84-7AF3-47E7-9133-D777BE46A656"","""" + ISpace[""gv_activitymapid""].Value + @"""","""" + ISpace[""MFG_P2_ReimbursementDetailsId""].Value + @"""","""" + ISpace[""MFG_P2_ReimbursementId""].Value + @"""","""" + ISpace[""MFG_P2_BillNo""].Value + @"""","""" + ISpace[""MFG_P2_BillDate""].Value + @"""","" + ISpace[""MFG_P2_BillDocument""].Value + @"","""" + ISpace[""MFG_P2_ItemDescription""].Value + @"""","" + ISpace[""MFG_P2_Amount""].Value + @"","""" + ISpace[""growid""].Value + @"""""");iSpace.InsertGridBindDetails(""ReimbursementBillDetails"",""11"",querySourceF3514DB4690A4BE6A6A77FA3D37E5B7C,""EXEC UpdateFormGridDataC9ACCA847AF347E79133D777BE46A656 """" + ISpace[""gv_instanceid""].Value + @"""","""" + ISpace[""gv_processmapid""].Value + @"""",""C9ACCA84-7AF3-47E7-9133-D777BE46A656"","""" + ISpace[""gv_activitymapid""].Value + @"""","""" + ISpace[""MFG_P2_ReimbursementDetailsId""].Value + @"""","""" + ISpace[""MFG_P2_ReimbursementId""].Value + @"""","""" + ISpace[""MFG_P2_BillNo""].Value + @"""","""" + ISpace[""MFG_P2_BillDate""].Value + @"""","" + ISpace[""MFG_P2_BillDocument""].Value + @"","""" + ISpace[""MFG_P2_ItemDescription""].Value + @"""","" + ISpace[""MFG_P2_Amount""].Value + @"","""" + ISpace[""growid""].Value + @"""""",_objectFactory.GetGridRPP(""ReimbursementBillDetails""));");
base.WriteDebugInfo(@"EXEC UpdateFormGridDataC9ACCA847AF347E79133D777BE46A656 "@@gv_InstanceId","@@gv_ProcessMapId","C9ACCA84-7AF3-47E7-9133-D777BE46A656","@@gv_ActivityMapId","#MFG_P2_ReimbursementDetailsId","#MFG_P2_ReimbursementId","#MFG_P2_BillNo","#MFG_P2_BillDate",#MFG_P2_BillDocument,"#MFG_P2_ItemDescription",#MFG_P2_Amount,"#growid"");


List<Triplet<string, short, short?>> result51CA1824668943C9A9D9B360B3E6BBB8=acdataIspace1E274DA615154B96B9224B5CC5F2D423.GetQueryExpressionBindings("51CA1824-6689-43C9-A9D9-B360B3E6BBB8");
iSpace.SetGridData(resultF3514DB4690A4BE6A6A77FA3D37E5B7C,result51CA1824668943C9A9D9B360B3E6BBB8,"ReimbursementBillDetails",ref ISpace);
iSpace.UpdateGridBindDetails("ReimbursementBillDetails",result51CA1824668943C9A9D9B360B3E6BBB8);
}
ISpace["growid"].Value="";
base.WriteDebugInfo(@"ISpace[""growid""].Value="""";");
ISpace["MFG_P2_ReimbursementDetailsId"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_P2_ReimbursementDetailsId""].Value="""";");
ISpace["MFG_P2_ReimbursementId"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_P2_ReimbursementId""].Value="""";");
ISpace["MFG_P2_BillNo"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_P2_BillNo""].Value="""";");
ISpace["MFG_P2_BillDate"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_P2_BillDate""].Value="""";");
ISpace["MFG_P2_BillDocument"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_P2_BillDocument""].Value="""";");
ISpace["MFG_P2_ItemDescription"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_P2_ItemDescription""].Value="""";");
ISpace["MFG_P2_Amount"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_P2_Amount""].Value="""";");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_edit_reimbursementfunddetails (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Edit_ReimbursementFundDetails-OnClick");
ISpace["growid"].Value=ISpace["ReimbursementFundDetails_RowId"].Value;
base.WriteDebugInfo(@"ISpace[""growid""].Value=ISpace[""ReimbursementFundDetails_RowId""].Value;");
base.WriteDebugInfo(@"EXEC  [LoadFormGridData1112A274004543D393C5205DAEFEA917]  "@@gv_InstanceId","@@gv_ProcessMapId","1112A274-0045-43D3-93C5-205DAEFEA917","@@gv_ActivityMapId","#growid"");

var querySource457B75FDB3F34EB787EB96D92F86F9EB =GetQueryExpressionDataSource("457B75FD-B3F3-4EB7-87EB-96D92F86F9EB");
Dictionary<short,object> result457B75FDB3F34EB787EB96D92F86F9EB=iSpace.ExecuteQuery(querySource457B75FDB3F34EB787EB96D92F86F9EB,@"EXEC[LoadFormGridData1112A274004543D393C5205DAEFEA917]"" + ISpace["gv_instanceid"].Value + @"","" + ISpace["gv_processmapid"].Value + @"","1112A274-0045-43D3-93C5-205DAEFEA917","" + ISpace["gv_activitymapid"].Value + @"","" + ISpace["growid"].Value + @""",false);

base.WriteDebugInfo(@"var querySource457B75FDB3F34EB787EB96D92F86F9EB =GetQueryExpressionDataSource(""457B75FD-B3F3-4EB7-87EB-96D92F86F9EB"");Dictionary<short,object> result457B75FDB3F34EB787EB96D92F86F9EB=iSpace.ExecuteQuery(querySource457B75FDB3F34EB787EB96D92F86F9EB,@""EXEC[LoadFormGridData1112A274004543D393C5205DAEFEA917]"""" + ISpace[""gv_instanceid""].Value + @"""","""" + ISpace[""gv_processmapid""].Value + @"""",""1112A274-0045-43D3-93C5-205DAEFEA917"","""" + ISpace[""gv_activitymapid""].Value + @"""","""" + ISpace[""growid""].Value + @"""""",false);");
base.WriteDebugInfo(@"EXEC LoadFormGridDataD85301F7BAF94BE8A2B174E5CBB3D054 "@@gv_InstanceId","@@gv_ProcessMapId","D85301F7-BAF9-4BE8-A2B1-74E5CBB3D054","@@gv_ActivityMapId","#growid"");

if((result457B75FDB3F34EB787EB96D92F86F9EB!=null) && (result457B75FDB3F34EB787EB96D92F86F9EB.Count!=0))
{
if(result457B75FDB3F34EB787EB96D92F86F9EB.ContainsKey(2))
ISpace["MFG_P3_FundTypeId"].Value = result457B75FDB3F34EB787EB96D92F86F9EB[2];
if(result457B75FDB3F34EB787EB96D92F86F9EB.ContainsKey(3))
ISpace["MFG_P3_ProjectDetailsId"].Value = result457B75FDB3F34EB787EB96D92F86F9EB[3];
if(result457B75FDB3F34EB787EB96D92F86F9EB.ContainsKey(4))
ISpace["MFG_P3_BudgetHeadId"].Value = result457B75FDB3F34EB787EB96D92F86F9EB[4];
if(result457B75FDB3F34EB787EB96D92F86F9EB.ContainsKey(5))
ISpace["MFG_P3_Amount"].Value = result457B75FDB3F34EB787EB96D92F86F9EB[5];
if(result457B75FDB3F34EB787EB96D92F86F9EB.ContainsKey(0))
ISpace["MFG_P3_FundDetailsId"].Value = result457B75FDB3F34EB787EB96D92F86F9EB[0];
if(result457B75FDB3F34EB787EB96D92F86F9EB.ContainsKey(1))
ISpace["MFG_P3_ReimbursementId"].Value = result457B75FDB3F34EB787EB96D92F86F9EB[1];
}
else{
ISpace["MFG_P3_FundTypeId"].Value = null;ISpace["MFG_P3_ProjectDetailsId"].Value = null;ISpace["MFG_P3_BudgetHeadId"].Value = null;ISpace["MFG_P3_Amount"].Value = null;ISpace["MFG_P3_FundDetailsId"].Value = null;ISpace["MFG_P3_ReimbursementId"].Value = null;
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_m_moveto (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"M_MoveTo-OnChange");
ISpace["M_MoveToValue"].Value=ISpace["M_MoveTo"].Value;
base.WriteDebugInfo(@"ISpace[""M_MoveToValue""].Value=ISpace[""M_MoveTo""].Value;");
base.WriteDebugInfo(@"Exec GetStageStatus 1,"","","#M_MoveToValue","#M_SourceActivityMapId"");

var querySource549686A138974AFCA19EC95972C37210 =GetQueryExpressionDataSource("549686A1-3897-4AFC-A19E-C95972C37210");
Dictionary<short,object> result549686A138974AFCA19EC95972C37210=iSpace.ExecuteQuery(querySource549686A138974AFCA19EC95972C37210,@"Exec GetStageStatus 1,"","","" + ISpace["M_MoveToValue"].Value + @"","" + ISpace["M_SourceActivityMapId"].Value + @""",false);

base.WriteDebugInfo(@"var querySource549686A138974AFCA19EC95972C37210 =GetQueryExpressionDataSource(""549686A1-3897-4AFC-A19E-C95972C37210"");Dictionary<short,object> result549686A138974AFCA19EC95972C37210=iSpace.ExecuteQuery(querySource549686A138974AFCA19EC95972C37210,@""Exec GetStageStatus 1,"""","""","""" + ISpace[""M_MoveToValue""].Value + @"""","""" + ISpace[""M_SourceActivityMapId""].Value + @"""""",false);");
base.WriteDebugInfo(@"");

if((result549686A138974AFCA19EC95972C37210!=null) && (result549686A138974AFCA19EC95972C37210.Count!=0))
{
if(result549686A138974AFCA19EC95972C37210.ContainsKey(3))
ISpace["M_SaveDomainData"].Value = result549686A138974AFCA19EC95972C37210[3];
if(result549686A138974AFCA19EC95972C37210.ContainsKey(1))
ISpace["M_RemarksMandatory"].Value = result549686A138974AFCA19EC95972C37210[1];
if(result549686A138974AFCA19EC95972C37210.ContainsKey(4))
ISpace["M_FieldMandatory"].Value = result549686A138974AFCA19EC95972C37210[4];
if(result549686A138974AFCA19EC95972C37210.ContainsKey(2))
ISpace["MF_P1_Remarks"].Value = result549686A138974AFCA19EC95972C37210[2];
if(result549686A138974AFCA19EC95972C37210.ContainsKey(0))
ISpace["M_NextStage"].Value = result549686A138974AFCA19EC95972C37210[0];
}
else{
ISpace["M_SaveDomainData"].Value = null;ISpace["M_RemarksMandatory"].Value = null;ISpace["M_FieldMandatory"].Value = null;ISpace["MF_P1_Remarks"].Value = null;ISpace["M_NextStage"].Value = null;
}
ISpace["SetDestinationTo"].Value=ISpace["M_MoveTo"].Value;
base.WriteDebugInfo(@"ISpace[""SetDestinationTo""].Value=ISpace[""M_MoveTo""].Value;");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_edit_reimbursementbilldetails (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Edit_ReimbursementBillDetails-OnClick");
base.WriteDebugInfo(@"EXEC LoadFormGridDataC9ACCA847AF347E79133D777BE46A656 "@@gv_InstanceId","@@gv_ProcessMapId","C9ACCA84-7AF3-47E7-9133-D777BE46A656","@@gv_ActivityMapId","#growid"");

var querySourceE12571F81F5945ED9BC6BAF0AA62F4F0 =GetQueryExpressionDataSource("E12571F8-1F59-45ED-9BC6-BAF0AA62F4F0");
Dictionary<short,object> resultE12571F81F5945ED9BC6BAF0AA62F4F0=iSpace.ExecuteQuery(querySourceE12571F81F5945ED9BC6BAF0AA62F4F0,@"EXEC LoadFormGridDataC9ACCA847AF347E79133D777BE46A656 "" + ISpace["gv_instanceid"].Value + @"","" + ISpace["gv_processmapid"].Value + @"","C9ACCA84-7AF3-47E7-9133-D777BE46A656","" + ISpace["gv_activitymapid"].Value + @"","" + ISpace["growid"].Value + @""",false);

base.WriteDebugInfo(@"var querySourceE12571F81F5945ED9BC6BAF0AA62F4F0 =GetQueryExpressionDataSource(""E12571F8-1F59-45ED-9BC6-BAF0AA62F4F0"");Dictionary<short,object> resultE12571F81F5945ED9BC6BAF0AA62F4F0=iSpace.ExecuteQuery(querySourceE12571F81F5945ED9BC6BAF0AA62F4F0,@""EXEC LoadFormGridDataC9ACCA847AF347E79133D777BE46A656 """" + ISpace[""gv_instanceid""].Value + @"""","""" + ISpace[""gv_processmapid""].Value + @"""",""C9ACCA84-7AF3-47E7-9133-D777BE46A656"","""" + ISpace[""gv_activitymapid""].Value + @"""","""" + ISpace[""growid""].Value + @"""""",false);");
base.WriteDebugInfo(@"EXEC LoadFormGridDataC9ACCA847AF347E79133D777BE46A656 "@@gv_InstanceId","@@gv_ProcessMapId","C9ACCA84-7AF3-47E7-9133-D777BE46A656","@@gv_ActivityMapId","#growid"");

if((resultE12571F81F5945ED9BC6BAF0AA62F4F0!=null) && (resultE12571F81F5945ED9BC6BAF0AA62F4F0.Count!=0))
{
if(resultE12571F81F5945ED9BC6BAF0AA62F4F0.ContainsKey(3))
ISpace["MFG_P2_BillDate"].Value = resultE12571F81F5945ED9BC6BAF0AA62F4F0[3];
if(resultE12571F81F5945ED9BC6BAF0AA62F4F0.ContainsKey(4))
ISpace["MFG_P2_BillDocument"].Value = resultE12571F81F5945ED9BC6BAF0AA62F4F0[4];
if(resultE12571F81F5945ED9BC6BAF0AA62F4F0.ContainsKey(6))
ISpace["MFG_P2_Amount"].Value = resultE12571F81F5945ED9BC6BAF0AA62F4F0[6];
if(resultE12571F81F5945ED9BC6BAF0AA62F4F0.ContainsKey(5))
ISpace["MFG_P2_ItemDescription"].Value = resultE12571F81F5945ED9BC6BAF0AA62F4F0[5];
if(resultE12571F81F5945ED9BC6BAF0AA62F4F0.ContainsKey(0))
ISpace["MFG_P2_ReimbursementDetailsId"].Value = resultE12571F81F5945ED9BC6BAF0AA62F4F0[0];
if(resultE12571F81F5945ED9BC6BAF0AA62F4F0.ContainsKey(1))
ISpace["MFG_P2_ReimbursementId"].Value = resultE12571F81F5945ED9BC6BAF0AA62F4F0[1];
if(resultE12571F81F5945ED9BC6BAF0AA62F4F0.ContainsKey(2))
ISpace["MFG_P2_BillNo"].Value = resultE12571F81F5945ED9BC6BAF0AA62F4F0[2];
}
else{
ISpace["MFG_P2_BillDate"].Value = null;ISpace["MFG_P2_BillDocument"].Value = null;ISpace["MFG_P2_Amount"].Value = null;ISpace["MFG_P2_ItemDescription"].Value = null;ISpace["MFG_P2_ReimbursementDetailsId"].Value = null;ISpace["MFG_P2_ReimbursementId"].Value = null;ISpace["MFG_P2_BillNo"].Value = null;
}
ISpace["growid"].Value=ISpace["ReimbursementBillDetails_RowId"].Value;
base.WriteDebugInfo(@"ISpace[""growid""].Value=ISpace[""ReimbursementBillDetails_RowId""].Value;");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_save_reimbursementfunddetails (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Save_ReimbursementFundDetails-OnClick");
if(ISpace["MFG_P3_FundTypeId"].Value=="1")
{
base.WriteDebugInfo(@"if(ISpace[""MFG_P3_FundTypeId""].Value==""1"")");
base.WriteDebugInfo(@"#ReimbursementFundDetails[Rows]");
iSpace.GetLoopExpressionData("ReimbursementFundDetails",ref ISpace);

foreach(var gridChild in ISpace["ReimbursementFundDetails"].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 


if(


ISpace["growid"].Value!=ISpace["ReimbursementFundDetails_RowId"].Value||ISpace["growid"].Value=="")
{
base.WriteDebugInfo(@"
if(


ISpace[""growid""].Value!=ISpace[""ReimbursementFundDetails_RowId""].Value||ISpace[""growid""].Value=="""")");
if(ISpace["MFG_P3_BudgetHeadId"].Value==ISpace["MG_P3_BudgetHeadId"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MFG_P3_BudgetHeadId""].Value==ISpace[""MG_P3_BudgetHeadId""].Value)");
ISpace["Message"].Value=@"Budget Head is already Exists";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Budget Head is already Exists"";");
ISpace["MFG_P3_BudgetHeadId"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_P3_BudgetHeadId""].Value="""";");
return;
base.WriteDebugInfo(@"return;");
}
}
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("ReimbursementFundDetails","00D69CC2-E6EC-4412-B2A9-14E57A96FB5C",_objectFactory.GetGridRPP("ReimbursementFundDetails"),_elementBase.GetGridLoopQuery("00D69CC2-E6EC-4412-B2A9-14E57A96FB5C","ReimbursementFundDetails",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""ReimbursementFundDetails"",ref ISpace);

foreach(var gridChild in ISpace[""ReimbursementFundDetails""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
}
if(ISpace["growid"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""growid""].Value=="""")");

var querySourceC5471BC38ECA4216A66F923825C32508 =GetQueryExpressionDataSource("C5471BC3-8ECA-4216-A66F-923825C32508");

DataTable resultC5471BC38ECA4216A66F923825C32508=iSpace.SetGridDataSource(querySourceC5471BC38ECA4216A66F923825C32508, _objectFactory.GetGridRPP("ReimbursementFundDetails"),@"EXEC AddFormGridData1112A274004543D393C5205DAEFEA917 "" + ISpace["gv_instanceid"].Value + @"","" + ISpace["gv_processmapid"].Value + @"","1112A274-0045-43D3-93C5-205DAEFEA917","" + ISpace["gv_activitymapid"].Value + @"","" + ISpace["MFG_P3_FundDetailsId"].Value + @"","" + ISpace["M_Advanceformid"].Value + @"","" + ISpace["MFG_P3_FundTypeId"].Value + @"","" + ISpace["MFG_P3_ProjectDetailsId"].Value + @"","" + ISpace["MFG_P3_BudgetHeadId"].Value + @""," + ISpace["MFG_P3_Amount"].Value + @","" + ISpace["growid"].Value + @""");

iSpace.InsertGridBindDetails("ReimbursementFundDetails","11",querySourceC5471BC38ECA4216A66F923825C32508,"EXEC AddFormGridData1112A274004543D393C5205DAEFEA917 "" + ISpace["gv_instanceid"].Value + @"","" + ISpace["gv_processmapid"].Value + @"","1112A274-0045-43D3-93C5-205DAEFEA917","" + ISpace["gv_activitymapid"].Value + @"","" + ISpace["MFG_P3_FundDetailsId"].Value + @"","" + ISpace["M_Advanceformid"].Value + @"","" + ISpace["MFG_P3_FundTypeId"].Value + @"","" + ISpace["MFG_P3_ProjectDetailsId"].Value + @"","" + ISpace["MFG_P3_BudgetHeadId"].Value + @""," + ISpace["MFG_P3_Amount"].Value + @","" + ISpace["growid"].Value + @""",_objectFactory.GetGridRPP("ReimbursementFundDetails"));

base.WriteDebugInfo(@"var querySourceC5471BC38ECA4216A66F923825C32508 =GetQueryExpressionDataSource(""C5471BC3-8ECA-4216-A66F-923825C32508"");DataTable resultC5471BC38ECA4216A66F923825C32508=iSpace.SetGridDataSource(querySourceC5471BC38ECA4216A66F923825C32508, _objectFactory.GetGridRPP(""ReimbursementFundDetails""),@""EXEC AddFormGridData1112A274004543D393C5205DAEFEA917 """" + ISpace[""gv_instanceid""].Value + @"""","""" + ISpace[""gv_processmapid""].Value + @"""",""1112A274-0045-43D3-93C5-205DAEFEA917"","""" + ISpace[""gv_activitymapid""].Value + @"""","""" + ISpace[""MFG_P3_FundDetailsId""].Value + @"""","""" + ISpace[""M_Advanceformid""].Value + @"""","""" + ISpace[""MFG_P3_FundTypeId""].Value + @"""","""" + ISpace[""MFG_P3_ProjectDetailsId""].Value + @"""","""" + ISpace[""MFG_P3_BudgetHeadId""].Value + @"""","" + ISpace[""MFG_P3_Amount""].Value + @"","""" + ISpace[""growid""].Value + @"""""");iSpace.InsertGridBindDetails(""ReimbursementFundDetails"",""11"",querySourceC5471BC38ECA4216A66F923825C32508,""EXEC AddFormGridData1112A274004543D393C5205DAEFEA917 """" + ISpace[""gv_instanceid""].Value + @"""","""" + ISpace[""gv_processmapid""].Value + @"""",""1112A274-0045-43D3-93C5-205DAEFEA917"","""" + ISpace[""gv_activitymapid""].Value + @"""","""" + ISpace[""MFG_P3_FundDetailsId""].Value + @"""","""" + ISpace[""M_Advanceformid""].Value + @"""","""" + ISpace[""MFG_P3_FundTypeId""].Value + @"""","""" + ISpace[""MFG_P3_ProjectDetailsId""].Value + @"""","""" + ISpace[""MFG_P3_BudgetHeadId""].Value + @"""","" + ISpace[""MFG_P3_Amount""].Value + @"","""" + ISpace[""growid""].Value + @"""""",_objectFactory.GetGridRPP(""ReimbursementFundDetails""));");
base.WriteDebugInfo(@"EXEC AddFormGridDataD85301F7BAF94BE8A2B174E5CBB3D054 "@@gv_InstanceId","@@gv_ProcessMapId","D85301F7-BAF9-4BE8-A2B1-74E5CBB3D054","@@gv_ActivityMapId","#MFG_P3_FundDetailsId","#MFG_P3_ReimbursementId","#MFG_P3_FundTypeId","#MFG_P3_ProjectDetailsId","#MFG_P3_BudgetHeadId",#MFG_P3_Amount,"#growid"");


List<Triplet<string, short, short?>> result169C69C3949245478D79196C3E1309FB=acdataIspace1E274DA615154B96B9224B5CC5F2D423.GetQueryExpressionBindings("169C69C3-9492-4547-8D79-196C3E1309FB");
iSpace.SetGridData(resultC5471BC38ECA4216A66F923825C32508,result169C69C3949245478D79196C3E1309FB,"ReimbursementFundDetails",ref ISpace);
iSpace.UpdateGridBindDetails("ReimbursementFundDetails",result169C69C3949245478D79196C3E1309FB);
}
else
{
base.WriteDebugInfo(@"else");

var querySourceA8D19C29F512446883DE4C86EF7F0E8F =GetQueryExpressionDataSource("A8D19C29-F512-4468-83DE-4C86EF7F0E8F");

DataTable resultA8D19C29F512446883DE4C86EF7F0E8F=iSpace.SetGridDataSource(querySourceA8D19C29F512446883DE4C86EF7F0E8F, _objectFactory.GetGridRPP("ReimbursementFundDetails"),@"EXEC UpdateFormGridData1112A274004543D393C5205DAEFEA917 "" + ISpace["gv_instanceid"].Value + @"","" + ISpace["gv_processmapid"].Value + @"","1112A274-0045-43D3-93C5-205DAEFEA917","" + ISpace["gv_activitymapid"].Value + @"","" + ISpace["MFG_P3_FundDetailsId"].Value + @"","" + ISpace["M_Advanceformid"].Value + @"","" + ISpace["MFG_P3_FundTypeId"].Value + @"","" + ISpace["MFG_P3_ProjectDetailsId"].Value + @"","" + ISpace["MFG_P3_BudgetHeadId"].Value + @""," + ISpace["MFG_P3_Amount"].Value + @","" + ISpace["growid"].Value + @""");

iSpace.InsertGridBindDetails("ReimbursementFundDetails","11",querySourceA8D19C29F512446883DE4C86EF7F0E8F,"EXEC UpdateFormGridData1112A274004543D393C5205DAEFEA917 "" + ISpace["gv_instanceid"].Value + @"","" + ISpace["gv_processmapid"].Value + @"","1112A274-0045-43D3-93C5-205DAEFEA917","" + ISpace["gv_activitymapid"].Value + @"","" + ISpace["MFG_P3_FundDetailsId"].Value + @"","" + ISpace["M_Advanceformid"].Value + @"","" + ISpace["MFG_P3_FundTypeId"].Value + @"","" + ISpace["MFG_P3_ProjectDetailsId"].Value + @"","" + ISpace["MFG_P3_BudgetHeadId"].Value + @""," + ISpace["MFG_P3_Amount"].Value + @","" + ISpace["growid"].Value + @""",_objectFactory.GetGridRPP("ReimbursementFundDetails"));

base.WriteDebugInfo(@"var querySourceA8D19C29F512446883DE4C86EF7F0E8F =GetQueryExpressionDataSource(""A8D19C29-F512-4468-83DE-4C86EF7F0E8F"");DataTable resultA8D19C29F512446883DE4C86EF7F0E8F=iSpace.SetGridDataSource(querySourceA8D19C29F512446883DE4C86EF7F0E8F, _objectFactory.GetGridRPP(""ReimbursementFundDetails""),@""EXEC UpdateFormGridData1112A274004543D393C5205DAEFEA917 """" + ISpace[""gv_instanceid""].Value + @"""","""" + ISpace[""gv_processmapid""].Value + @"""",""1112A274-0045-43D3-93C5-205DAEFEA917"","""" + ISpace[""gv_activitymapid""].Value + @"""","""" + ISpace[""MFG_P3_FundDetailsId""].Value + @"""","""" + ISpace[""M_Advanceformid""].Value + @"""","""" + ISpace[""MFG_P3_FundTypeId""].Value + @"""","""" + ISpace[""MFG_P3_ProjectDetailsId""].Value + @"""","""" + ISpace[""MFG_P3_BudgetHeadId""].Value + @"""","" + ISpace[""MFG_P3_Amount""].Value + @"","""" + ISpace[""growid""].Value + @"""""");iSpace.InsertGridBindDetails(""ReimbursementFundDetails"",""11"",querySourceA8D19C29F512446883DE4C86EF7F0E8F,""EXEC UpdateFormGridData1112A274004543D393C5205DAEFEA917 """" + ISpace[""gv_instanceid""].Value + @"""","""" + ISpace[""gv_processmapid""].Value + @"""",""1112A274-0045-43D3-93C5-205DAEFEA917"","""" + ISpace[""gv_activitymapid""].Value + @"""","""" + ISpace[""MFG_P3_FundDetailsId""].Value + @"""","""" + ISpace[""M_Advanceformid""].Value + @"""","""" + ISpace[""MFG_P3_FundTypeId""].Value + @"""","""" + ISpace[""MFG_P3_ProjectDetailsId""].Value + @"""","""" + ISpace[""MFG_P3_BudgetHeadId""].Value + @"""","" + ISpace[""MFG_P3_Amount""].Value + @"","""" + ISpace[""growid""].Value + @"""""",_objectFactory.GetGridRPP(""ReimbursementFundDetails""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> resultBDF250C27A244A8EB094E340FDE4659C=acdataIspace1E274DA615154B96B9224B5CC5F2D423.GetQueryExpressionBindings("BDF250C2-7A24-4A8E-B094-E340FDE4659C");
iSpace.SetGridData(resultA8D19C29F512446883DE4C86EF7F0E8F,resultBDF250C27A244A8EB094E340FDE4659C,"ReimbursementFundDetails",ref ISpace);
iSpace.UpdateGridBindDetails("ReimbursementFundDetails",resultBDF250C27A244A8EB094E340FDE4659C);
}
base.WriteDebugInfo(@"#ReimbursementFundDetails[Rows]");
iSpace.GetLoopExpressionData("ReimbursementFundDetails",ref ISpace);

foreach(var gridChild in ISpace["ReimbursementFundDetails"].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 



ISpace["MG_P3_Employeebasicinfoid"].Value=ISpace["UC_EmployeeBaicInfoId"].Value;
base.WriteDebugInfo(@"

ISpace[""MG_P3_Employeebasicinfoid""].Value=ISpace[""UC_EmployeeBaicInfoId""].Value;");


ISpace["MG_P3_Packageprocessmapid"].Value=ISpace["M_PackageProcessMapId"].Value;
base.WriteDebugInfo(@"

ISpace[""MG_P3_Packageprocessmapid""].Value=ISpace[""M_PackageProcessMapId""].Value;");
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("ReimbursementFundDetails","00D69CC2-E6EC-4412-B2A9-14E57A96FB5C",_objectFactory.GetGridRPP("ReimbursementFundDetails"),_elementBase.GetGridLoopQuery("00D69CC2-E6EC-4412-B2A9-14E57A96FB5C","ReimbursementFundDetails",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""ReimbursementFundDetails"",ref ISpace);

foreach(var gridChild in ISpace[""ReimbursementFundDetails""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
object MG_P3_Amount=iSpace.Sum("[00D69CC2-E6EC-4412-B2A9-14E57A96FB5C]","MG_P3_Amount","");
ISpace["MFG_P3_OverallAmount"].Value=Convert.ChangeType(MG_P3_Amount, MG_P3_Amount.GetType());;
base.WriteDebugInfo(@"object MG_P3_Amount=iSpace.Sum(""[00D69CC2-E6EC-4412-B2A9-14E57A96FB5C]"",""MG_P3_Amount"","""");
ISpace[""MFG_P3_OverallAmount""].Value=Convert.ChangeType(MG_P3_Amount, MG_P3_Amount.GetType());;");
ISpace["growid"].Value="";
base.WriteDebugInfo(@"ISpace[""growid""].Value="""";");
ISpace["MFG_P3_FundDetailsId"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_P3_FundDetailsId""].Value="""";");
ISpace["MFG_P3_ReimbursementId"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_P3_ReimbursementId""].Value="""";");
ISpace["MFG_P3_FundTypeId"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_P3_FundTypeId""].Value="""";");
ISpace["MFG_P3_ProjectDetailsId"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_P3_ProjectDetailsId""].Value="""";");
ISpace["MFG_P3_BudgetHeadId"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_P3_BudgetHeadId""].Value="""";");
ISpace["MFG_P3_Amount"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_P3_Amount""].Value="""";");
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
		if(elementName.ToLower().Equals("m_moveto"))
    {
    			SubscribeElementEvents_m_moveto(ref dfsParam);
    }
}
	if(methodName.ToLower().Equals("onclick"))
{
		if(elementName.ToLower().Equals("submitform"))
{
			SubscribeElementEvents_submitform(ref dfsParam);
}
		if(elementName.ToLower().Equals("save_reimbursementbilldetails"))
{
			SubscribeElementEvents_save_reimbursementbilldetails(ref dfsParam);
}
		if(elementName.ToLower().Equals("edit_reimbursementfunddetails"))
{
			SubscribeElementEvents_edit_reimbursementfunddetails(ref dfsParam);
}
		if(elementName.ToLower().Equals("edit_reimbursementbilldetails"))
{
			SubscribeElementEvents_edit_reimbursementbilldetails(ref dfsParam);
}
		if(elementName.ToLower().Equals("save_reimbursementfunddetails"))
{
			SubscribeElementEvents_save_reimbursementfunddetails(ref dfsParam);
}
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
public class ISpace893AB0C88E484E9C8DCDEF160F9C9A43 : VirtualForm
{
IISpace iSpace = new ISpace();
AcDataISpace893AB0C88E484E9C8DCDEF160F9C9A43 acdataIspace893AB0C88E484E9C8DCDEF160F9C9A43=new AcDataISpace893AB0C88E484E9C8DCDEF160F9C9A43();
private void SubscribeFormEvents_root(ref Dictionary<string, ServiceElementData> ISpace)
{
try
{
base.WriteDebugInfo(@"Root-OnAfterFormLoad");
ISpace["M_SourceActivityMapId"].Value=ISpace["gv_activitymapid"].Value;
base.WriteDebugInfo(@"ISpace[""M_SourceActivityMapId""].Value=ISpace[""gv_activitymapid""].Value;");
ISpace["M_PackageProcessMapId"].Value=ISpace["gv_processmapid"].Value;
base.WriteDebugInfo(@"ISpace[""M_PackageProcessMapId""].Value=ISpace[""gv_processmapid""].Value;");
ISpace["M_InstanceId"].Value=ISpace["gv_instanceid"].Value;
base.WriteDebugInfo(@"ISpace[""M_InstanceId""].Value=ISpace[""gv_instanceid""].Value;");
ISpace["M_IsSourceStep"].Value=0;
base.WriteDebugInfo(@"ISpace[""M_IsSourceStep""].Value=0;");


ISpace["M_MoveTo"].Man=true;
base.WriteDebugInfo(@"ISpace[""M_MoveTo""].Man=true;");
ISpace["MF_P1_Remarks"].Value="";
base.WriteDebugInfo(@"ISpace[""MF_P1_Remarks""].Value="""";");
ISpace["M_NextStage"].Value="";
base.WriteDebugInfo(@"ISpace[""M_NextStage""].Value="""";");

var querySource8BBB2BE71E8540E59B13CC03C350EAB8 =GetQueryExpressionDataSource("8BBB2BE7-1E85-40E5-9B13-CC03C350EAB8");

DataTable result8BBB2BE71E8540E59B13CC03C350EAB8=iSpace.SetGridDataSource(querySource8BBB2BE71E8540E59B13CC03C350EAB8, _objectFactory.GetGridRPP("MG_RemarksDetails"),@"EXEC GetRemarks "" + ISpace["M_InstanceId"].Value + @""");

iSpace.InsertGridBindDetails("MG_RemarksDetails","11",querySource8BBB2BE71E8540E59B13CC03C350EAB8,"EXEC GetRemarks "" + ISpace["M_InstanceId"].Value + @""",_objectFactory.GetGridRPP("MG_RemarksDetails"));

base.WriteDebugInfo(@"var querySource8BBB2BE71E8540E59B13CC03C350EAB8 =GetQueryExpressionDataSource(""8BBB2BE7-1E85-40E5-9B13-CC03C350EAB8"");DataTable result8BBB2BE71E8540E59B13CC03C350EAB8=iSpace.SetGridDataSource(querySource8BBB2BE71E8540E59B13CC03C350EAB8, _objectFactory.GetGridRPP(""MG_RemarksDetails""),@""EXEC GetRemarks """" + ISpace[""M_InstanceId""].Value + @"""""");iSpace.InsertGridBindDetails(""MG_RemarksDetails"",""11"",querySource8BBB2BE71E8540E59B13CC03C350EAB8,""EXEC GetRemarks """" + ISpace[""M_InstanceId""].Value + @"""""",_objectFactory.GetGridRPP(""MG_RemarksDetails""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> resultCA798124C2C446CCBDA6419353320A96=acdataIspace893AB0C88E484E9C8DCDEF160F9C9A43.GetQueryExpressionBindings("CA798124-C2C4-46CC-BDA6-419353320A96");
iSpace.SetGridData(result8BBB2BE71E8540E59B13CC03C350EAB8,resultCA798124C2C446CCBDA6419353320A96,"MG_RemarksDetails",ref ISpace);
iSpace.UpdateGridBindDetails("MG_RemarksDetails",resultCA798124C2C446CCBDA6419353320A96);
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["MF_P1_ApplicationStatus"].Visible="false";ISpace["MFG_P2_ReimbursementDetailsId"].Visible="false";ISpace["MF_P1_EmployeeBasicInfoId"].Visible="false";ISpace["MFG_P3_FundDetailsId"].Visible="false";ISpace["MFG_P2_BillDocument"].Visible="false";ISpace["MF_P1_UpdatedBy"].Visible="false";ISpace["MF_P1_Initiatedon"].Visible="false";ISpace["MFG_P3_ReimbursementId"].Visible="false";ISpace["MFG_P2_BillDate"].Visible="false";ISpace["MF_P1_TotalAmount"].Visible="true";ISpace["MF_P1_InitatedBy"].Visible="false";ISpace["MFG_P2_ReimbursementId"].Visible="false";ISpace["MFG_P2_BillNo"].Visible="false";ISpace["MFG_P2_Amount"].Visible="false";ISpace["MF_P1_UpdatedOn"].Visible="false";ISpace["MFG_P3_FundTypeId"].Visible="false";ISpace["MFG_P3_ProjectDetailsId"].Visible="false";ISpace["MFG_P3_Amount"].Visible="false";ISpace["MFG_P2_ItemDescription"].Visible="false";ISpace["MF_P1_ReimbursementId"].Visible="false";ISpace["MFG_P3_BudgetHeadId"].Visible="false";
base.WriteDebugInfo(@"ISpace[""MF_P1_ApplicationStatus""].Visible=""false"";ISpace[""MFG_P2_ReimbursementDetailsId""].Visible=""false"";ISpace[""MF_P1_EmployeeBasicInfoId""].Visible=""false"";ISpace[""MFG_P3_FundDetailsId""].Visible=""false"";ISpace[""MFG_P2_BillDocument""].Visible=""false"";ISpace[""MF_P1_UpdatedBy""].Visible=""false"";ISpace[""MF_P1_Initiatedon""].Visible=""false"";ISpace[""MFG_P3_ReimbursementId""].Visible=""false"";ISpace[""MFG_P2_BillDate""].Visible=""false"";ISpace[""MF_P1_TotalAmount""].Visible=""true"";ISpace[""MF_P1_InitatedBy""].Visible=""false"";ISpace[""MFG_P2_ReimbursementId""].Visible=""false"";ISpace[""MFG_P2_BillNo""].Visible=""false"";ISpace[""MFG_P2_Amount""].Visible=""false"";ISpace[""MF_P1_UpdatedOn""].Visible=""false"";ISpace[""MFG_P3_FundTypeId""].Visible=""false"";ISpace[""MFG_P3_ProjectDetailsId""].Visible=""false"";ISpace[""MFG_P3_Amount""].Visible=""false"";ISpace[""MFG_P2_ItemDescription""].Visible=""false"";ISpace[""MF_P1_ReimbursementId""].Visible=""false"";ISpace[""MFG_P3_BudgetHeadId""].Visible=""false"";");
ISpace["MG_P2_BillNo"].Visible="true";ISpace["MG_P2_BillDocument"].Visible="false";ISpace["MG_P2_ReimbursementDetailsId"].Visible="false";ISpace["MG_P2_ReimbursementId"].Visible="false";ISpace["MG_P2_ItemDescription"].Visible="true";ISpace["MG_P2_BillDate"].Visible="true";ISpace["MG_P2_Amount"].Visible="true";
base.WriteDebugInfo(@"ISpace[""MG_P2_BillNo""].Visible=""true"";ISpace[""MG_P2_BillDocument""].Visible=""false"";ISpace[""MG_P2_ReimbursementDetailsId""].Visible=""false"";ISpace[""MG_P2_ReimbursementId""].Visible=""false"";ISpace[""MG_P2_ItemDescription""].Visible=""true"";ISpace[""MG_P2_BillDate""].Visible=""true"";ISpace[""MG_P2_Amount""].Visible=""true"";");
ISpace["MG_P3_ProjectDetailsId"].Visible="true";ISpace["MG_P3_BudgetHeadId"].Visible="true";ISpace["MG_P3_FundTypeId"].Visible="true";ISpace["MG_P3_FundDetailsId"].Visible="false";ISpace["MG_P3_Amount"].Visible="true";ISpace["MG_P3_ReimbursementId"].Visible="false";
base.WriteDebugInfo(@"ISpace[""MG_P3_ProjectDetailsId""].Visible=""true"";ISpace[""MG_P3_BudgetHeadId""].Visible=""true"";ISpace[""MG_P3_FundTypeId""].Visible=""true"";ISpace[""MG_P3_FundDetailsId""].Visible=""false"";ISpace[""MG_P3_Amount""].Visible=""true"";ISpace[""MG_P3_ReimbursementId""].Visible=""false"";");
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_submitform (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"SubmitForm-OnClick");
base.WriteDebugInfo(@"Entering DomainDataMap for Remarks Domain");
var RemarksDomain_repoObj = new RepositoryMapper(DbTypes.SQLServer);


var ActivityTrailLogDetailsRemarksDomaintableObj = new RepositoryTable("ActivityTrailLogDetails");
  ActivityTrailLogDetailsRemarksDomaintableObj.AppConnectionSettingsId  ="9ADED37B-CD11-426B-AF16-DEAC75685EF5";ActivityTrailLogDetailsRemarksDomaintableObj.ProofConnectionId = "C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0)";
var RemarksDomain_ActivityTrailLogDetails_rows = GetElementClientData(ISpace["InstanceId"].Value,"6B463D69-64AB-468E-B2E3-DB12E6B90014");

if(RemarksDomain_ActivityTrailLogDetails_rows!=null && RemarksDomain_ActivityTrailLogDetails_rows.Count>0){
var RemarksDomain_ActivityTrailLogDetails_rowsObj = new List<RepositoryRow>();
foreach(var rows in RemarksDomain_ActivityTrailLogDetails_rows){RepositoryRow repositoryRowObj = null;string elementData = null;RepositoryColumn repositoryColumnObj = null;if(rows !=null){ var ActivityTrailLogDetails_colObj = new List<RepositoryColumn>();repositoryRowObj= new RepositoryRow();//var myByte = (byte)rowData.Value.RwSt;//repositoryRowObj.RowState=(RepositoryRowState)myByte;

if(rows.ContainsKey("5354760A-9EAC-491E-BAB1-C3614187A9BE"))     elementData = rows["5354760A-9EAC-491E-BAB1-C3614187A9BE"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ProcessedInProgressFlag",false,false,5);
if(repositoryColumnObj!=null)ActivityTrailLogDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-M_IsSourceStep not found");}

elementData = CurrentDate().ToString() ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Updatedon",false,false,8);
if(repositoryColumnObj!=null)ActivityTrailLogDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-CurrentDate not found");}

if(rows.ContainsKey("D7BB255E-9A01-4B5B-AE06-CC4D6E088D52"))     elementData = rows["D7BB255E-9A01-4B5B-AE06-CC4D6E088D52"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"InstanceID",false,false,9);
if(repositoryColumnObj!=null)ActivityTrailLogDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-M_InstanceId not found");}

elementData = ISpace["gv_UserId"].Value != null? Convert.ToString(ISpace["gv_UserId"].Value):null ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Updatedby",false,false,6);
if(repositoryColumnObj!=null)ActivityTrailLogDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-gv_UserId not found");}

if(rows.ContainsKey("6DB9BC45-F167-4D8A-9596-1DBA9872F253"))     elementData = rows["6DB9BC45-F167-4D8A-9596-1DBA9872F253"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"DestinationActivityMapID",false,false,9);
if(repositoryColumnObj!=null)ActivityTrailLogDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-M_DestinationActivityId not found");}

elementData = ISpace["gv_UserName"].Value != null? Convert.ToString(ISpace["gv_UserName"].Value):null ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"RemarksBy",false,false,9);
if(repositoryColumnObj!=null)ActivityTrailLogDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-gv_UserName not found");}

elementData = ISpace["gv_ActivityName"].Value != null? Convert.ToString(ISpace["gv_ActivityName"].Value):null ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ActivityName",false,false,9);
if(repositoryColumnObj!=null)ActivityTrailLogDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-gv_ActivityName not found");}

if(rows.ContainsKey("F78328FF-68D9-45E9-BC40-27CD650C9D6C"))     elementData = rows["F78328FF-68D9-45E9-BC40-27CD650C9D6C"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Remarks",false,false,9);
if(repositoryColumnObj!=null)ActivityTrailLogDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MF_P1_Remarks not found");}

elementData = ISpace["gv_TenantId"].Value != null? Convert.ToString(ISpace["gv_TenantId"].Value):null ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"TenantID",false,false,9);
if(repositoryColumnObj!=null)ActivityTrailLogDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-gv_TenantId not found");}

elementData = Guid.NewGuid().ToString();if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"TrailLogId",true,false,9);
if(repositoryColumnObj!=null)ActivityTrailLogDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-GUID not found");}

if(rows.ContainsKey("52A564C4-B656-4F43-B6F3-E592002351F6"))     elementData = rows["52A564C4-B656-4F43-B6F3-E592002351F6"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"SourceActivityMapID",false,false,9);
if(repositoryColumnObj!=null)ActivityTrailLogDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-M_SourceActivityMapId not found");}

elementData = CurrentDate().ToString() ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"RemarksOn",false,false,8);
if(repositoryColumnObj!=null)ActivityTrailLogDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-CurrentDate not found");}
repositoryRowObj.Columns=ActivityTrailLogDetails_colObj;
RemarksDomain_ActivityTrailLogDetails_rowsObj.Add(repositoryRowObj);
}}

ActivityTrailLogDetailsRemarksDomaintableObj.Rows=RemarksDomain_ActivityTrailLogDetails_rowsObj;
var RemarksDomain_repoObj_status_ActivityTrailLogDetails = RemarksDomain_repoObj.Execute(DomainOperationTypes.CreateOrUpdate,ref ActivityTrailLogDetailsRemarksDomaintableObj);if(!RemarksDomain_repoObj_status_ActivityTrailLogDetails) throw new Exception("Error in Execute Domain Data Map");}
base.WriteDebugInfo(@"Exiting DomainDataMap for Remarks Domain");
if(IsNullOrEmpty(ISpace["Declaration"].Value))
{
base.WriteDebugInfo(@"if(IsNullOrEmpty(ISpace[""Declaration""].Value))");
ISpace["Message"].Value=@"Select the declaration";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Select the declaration"";");
return;
base.WriteDebugInfo(@"return;");
}
if(ISpace["M_SaveDomainData"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""M_SaveDomainData""].Value==1)");
ISpace["MF_P1_ApplicationStatus"].Value="A";
base.WriteDebugInfo(@"ISpace[""MF_P1_ApplicationStatus""].Value=""A"";");
}
if(ISpace["M_SaveDomainData"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""M_SaveDomainData""].Value==1)");
base.WriteDebugInfo(@"Entering DomainDataMap for Project Advance Details REPO 1");
var ProjectAdvanceDetailsREPO1_repoObj = new RepositoryMapper(DbTypes.SQLServer);


var ProjectAdvanceFormProjectAdvanceDetailsREPO1tableObj = new RepositoryTable("ProjectAdvanceForm");
  ProjectAdvanceFormProjectAdvanceDetailsREPO1tableObj.AppConnectionSettingsId  ="3A103712-5244-4427-B2B6-1C4E046FD337";ProjectAdvanceFormProjectAdvanceDetailsREPO1tableObj.ProofConnectionId = "C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0)";
var ProjectAdvanceDetailsREPO1_ProjectAdvanceForm_rows = GetElementClientData(ISpace["InstanceId"].Value,"6B463D69-64AB-468E-B2E3-DB12E6B90014");

if(ProjectAdvanceDetailsREPO1_ProjectAdvanceForm_rows!=null && ProjectAdvanceDetailsREPO1_ProjectAdvanceForm_rows.Count>0){
var ProjectAdvanceDetailsREPO1_ProjectAdvanceForm_rowsObj = new List<RepositoryRow>();
foreach(var rows in ProjectAdvanceDetailsREPO1_ProjectAdvanceForm_rows){RepositoryRow repositoryRowObj = null;string elementData = null;RepositoryColumn repositoryColumnObj = null;if(rows !=null){ var ProjectAdvanceForm_colObj = new List<RepositoryColumn>();repositoryRowObj= new RepositoryRow();//var myByte = (byte)rowData.Value.RwSt;//repositoryRowObj.RowState=(RepositoryRowState)myByte;

if(rows.ContainsKey("72A0167C-47E6-4BBA-964A-D18B4C2724BE"))     elementData = rows["72A0167C-47E6-4BBA-964A-D18B4C2724BE"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"AdvanceFormId",true,false,9);
if(repositoryColumnObj!=null)ProjectAdvanceForm_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-M_Advanceformid not found");}

elementData = ISpace["gv_UserName"].Value != null? Convert.ToString(ISpace["gv_UserName"].Value):null ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"InitatedBy",false,false,9);
if(repositoryColumnObj!=null)ProjectAdvanceForm_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-gv_UserName not found");}

elementData = ISpace["gv_UserName"].Value != null? Convert.ToString(ISpace["gv_UserName"].Value):null ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"UpdatedBy",false,false,9);
if(repositoryColumnObj!=null)ProjectAdvanceForm_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-gv_UserName not found");}

if(rows.ContainsKey("16BFBC4B-9CB5-4677-AAE8-85CE6C7260E5"))     elementData = rows["16BFBC4B-9CB5-4677-AAE8-85CE6C7260E5"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ApplicationStatus",false,false,9);
if(repositoryColumnObj!=null)ProjectAdvanceForm_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MF_P1_ApplicationStatus not found");}

if(rows.ContainsKey("329D5240-1DBD-433E-A8EB-0F29F5AA668C"))     elementData = rows["329D5240-1DBD-433E-A8EB-0F29F5AA668C"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"EmployeeBasicInfoId",false,false,9);
if(repositoryColumnObj!=null)ProjectAdvanceForm_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-UC_EmployeeBaicInfoId not found");}

if(rows.ContainsKey("68A2EC13-D240-4EBC-8828-E795581544DA"))     elementData = rows["68A2EC13-D240-4EBC-8828-E795581544DA"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"TotalAmount",false,false,3);
if(repositoryColumnObj!=null)ProjectAdvanceForm_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MF_P1_TotalAmount not found");}

elementData = CurrentDate().ToString() ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Initiatedon",false,false,8);
if(repositoryColumnObj!=null)ProjectAdvanceForm_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-CurrentDate not found");}

elementData = CurrentDate().ToString() ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"UpdatedOn",false,false,8);
if(repositoryColumnObj!=null)ProjectAdvanceForm_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-CurrentDate not found");}
repositoryRowObj.Columns=ProjectAdvanceForm_colObj;
ProjectAdvanceDetailsREPO1_ProjectAdvanceForm_rowsObj.Add(repositoryRowObj);
}}

ProjectAdvanceFormProjectAdvanceDetailsREPO1tableObj.Rows=ProjectAdvanceDetailsREPO1_ProjectAdvanceForm_rowsObj;
var ProjectAdvanceDetailsREPO1_repoObj_status_ProjectAdvanceForm = ProjectAdvanceDetailsREPO1_repoObj.Execute(DomainOperationTypes.CreateOrUpdate,ref ProjectAdvanceFormProjectAdvanceDetailsREPO1tableObj);if(!ProjectAdvanceDetailsREPO1_repoObj_status_ProjectAdvanceForm) throw new Exception("Error in Execute Domain Data Map");}
base.WriteDebugInfo(@"Exiting DomainDataMap for Project Advance Details REPO 1");
base.WriteDebugInfo(@"Entering DomainDataMap for Project Advance Details REPO 2");
var ProjectAdvanceDetailsREPO2_repoObj = new RepositoryMapper(DbTypes.SQLServer);


var ProjectAdvanceFundDetailsProjectAdvanceDetailsREPO2tableObj = new RepositoryTable("ProjectAdvanceFundDetails");
  ProjectAdvanceFundDetailsProjectAdvanceDetailsREPO2tableObj.AppConnectionSettingsId  ="3A103712-5244-4427-B2B6-1C4E046FD337";ProjectAdvanceFundDetailsProjectAdvanceDetailsREPO2tableObj.ProofConnectionId = "C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0)";
var ProjectAdvanceDetailsREPO2_ProjectAdvanceFundDetails_rows = GetElementClientData(ISpace["InstanceId"].Value,"00D69CC2-E6EC-4412-B2A9-14E57A96FB5C");

if(ProjectAdvanceDetailsREPO2_ProjectAdvanceFundDetails_rows!=null && ProjectAdvanceDetailsREPO2_ProjectAdvanceFundDetails_rows.Count>0){
var ProjectAdvanceDetailsREPO2_ProjectAdvanceFundDetails_rowsObj = new List<RepositoryRow>();
foreach(var rows in ProjectAdvanceDetailsREPO2_ProjectAdvanceFundDetails_rows){RepositoryRow repositoryRowObj = null;string elementData = null;RepositoryColumn repositoryColumnObj = null;if(rows !=null){ var ProjectAdvanceFundDetails_colObj = new List<RepositoryColumn>();repositoryRowObj= new RepositoryRow();//var myByte = (byte)rowData.Value.RwSt;//repositoryRowObj.RowState=(RepositoryRowState)myByte;

if(rows.ContainsKey("E20A9876-034C-49BC-A309-26338AAD45BD"))     elementData = rows["E20A9876-034C-49BC-A309-26338AAD45BD"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"AdvanceFormId",false,false,9);
if(repositoryColumnObj!=null)ProjectAdvanceFundDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MG_P3_Advanceformid not found");}

if(rows.ContainsKey("B24F329A-C286-4040-ABD2-B67B5AE4F7BE"))     elementData = rows["B24F329A-C286-4040-ABD2-B67B5AE4F7BE"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"FundDetailsId",true,false,9);
if(repositoryColumnObj!=null)ProjectAdvanceFundDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MG_P3_FundDetailsId not found");}

if(rows.ContainsKey("4F81555E-3503-43B3-AD28-23293B41E926"))     elementData = rows["4F81555E-3503-43B3-AD28-23293B41E926"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ProjectDetailsId",false,false,9);
if(repositoryColumnObj!=null)ProjectAdvanceFundDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MG_P3_ProjectDetailsId not found");}

if(rows.ContainsKey("CCBB2219-451D-4EAE-BA26-1C16A9B0FF7D"))     elementData = rows["CCBB2219-451D-4EAE-BA26-1C16A9B0FF7D"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Amount",false,false,3);
if(repositoryColumnObj!=null)ProjectAdvanceFundDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MG_P3_Amount not found");}

if(rows.ContainsKey("8F687AA1-A6B1-4250-9948-DBAF2D40AB51"))     elementData = rows["8F687AA1-A6B1-4250-9948-DBAF2D40AB51"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"BudgetHeadId",false,false,9);
if(repositoryColumnObj!=null)ProjectAdvanceFundDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MG_P3_BudgetHeadId not found");}

if(rows.ContainsKey("99E459F3-F338-40A6-A1E3-1F7AD7A198CD"))     elementData = rows["99E459F3-F338-40A6-A1E3-1F7AD7A198CD"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"FundTypeId",false,false,6);
if(repositoryColumnObj!=null)ProjectAdvanceFundDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MG_P3_FundTypeId not found");}
repositoryRowObj.Columns=ProjectAdvanceFundDetails_colObj;
ProjectAdvanceDetailsREPO2_ProjectAdvanceFundDetails_rowsObj.Add(repositoryRowObj);
}}

ProjectAdvanceFundDetailsProjectAdvanceDetailsREPO2tableObj.Rows=ProjectAdvanceDetailsREPO2_ProjectAdvanceFundDetails_rowsObj;
var ProjectAdvanceDetailsREPO2_repoObj_status_ProjectAdvanceFundDetails = ProjectAdvanceDetailsREPO2_repoObj.Execute(DomainOperationTypes.CreateOrUpdate,ref ProjectAdvanceFundDetailsProjectAdvanceDetailsREPO2tableObj);if(!ProjectAdvanceDetailsREPO2_repoObj_status_ProjectAdvanceFundDetails) throw new Exception("Error in Execute Domain Data Map");}
base.WriteDebugInfo(@"Exiting DomainDataMap for Project Advance Details REPO 2");
base.WriteDebugInfo(@"Entering DomainDataMap for Project Advance Details REPO 3");
var ProjectAdvanceDetailsREPO3_repoObj = new RepositoryMapper(DbTypes.SQLServer);


var ProjectAdvanceRequestDetailsProjectAdvanceDetailsREPO3tableObj = new RepositoryTable("ProjectAdvanceRequestDetails");
  ProjectAdvanceRequestDetailsProjectAdvanceDetailsREPO3tableObj.AppConnectionSettingsId  ="3A103712-5244-4427-B2B6-1C4E046FD337";ProjectAdvanceRequestDetailsProjectAdvanceDetailsREPO3tableObj.ProofConnectionId = "C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0)";
var ProjectAdvanceDetailsREPO3_ProjectAdvanceRequestDetails_rows = GetElementClientData(ISpace["InstanceId"].Value,"1356A8F2-1947-4667-987D-2EA211B288A3");

if(ProjectAdvanceDetailsREPO3_ProjectAdvanceRequestDetails_rows!=null && ProjectAdvanceDetailsREPO3_ProjectAdvanceRequestDetails_rows.Count>0){
var ProjectAdvanceDetailsREPO3_ProjectAdvanceRequestDetails_rowsObj = new List<RepositoryRow>();
foreach(var rows in ProjectAdvanceDetailsREPO3_ProjectAdvanceRequestDetails_rows){RepositoryRow repositoryRowObj = null;string elementData = null;RepositoryColumn repositoryColumnObj = null;if(rows !=null){ var ProjectAdvanceRequestDetails_colObj = new List<RepositoryColumn>();repositoryRowObj= new RepositoryRow();//var myByte = (byte)rowData.Value.RwSt;//repositoryRowObj.RowState=(RepositoryRowState)myByte;

if(rows.ContainsKey("04D90722-37D7-40B0-96B6-D6CA55ABA8F2"))     elementData = rows["04D90722-37D7-40B0-96B6-D6CA55ABA8F2"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ExpenseDetails",false,false,9);
if(repositoryColumnObj!=null)ProjectAdvanceRequestDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MGA_DetailsofExpenses not found");}

if(rows.ContainsKey("B1EB21F5-30E2-4DB3-B72E-E6BB3E4A1D2B"))     elementData = rows["B1EB21F5-30E2-4DB3-B72E-E6BB3E4A1D2B"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ItemDescription",false,false,9);
if(repositoryColumnObj!=null)ProjectAdvanceRequestDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MGA_Description not found");}

if(rows.ContainsKey("8E8892C8-B328-42D2-A630-B8A2C3C4D26B"))     elementData = rows["8E8892C8-B328-42D2-A630-B8A2C3C4D26B"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Amount",false,false,3);
if(repositoryColumnObj!=null)ProjectAdvanceRequestDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MGA_Amount not found");}

if(rows.ContainsKey("67C65E87-8293-495E-97A2-E7431BF75D69"))     elementData = rows["67C65E87-8293-495E-97A2-E7431BF75D69"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"RequestDetailsId",true,false,9);
if(repositoryColumnObj!=null)ProjectAdvanceRequestDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MGA_RequestDetailsId not found");}

if(rows.ContainsKey("6E5FD9F2-E29C-4922-B6C5-78C591A395A6"))     elementData = rows["6E5FD9F2-E29C-4922-B6C5-78C591A395A6"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"AdvanceFormId",false,false,9);
if(repositoryColumnObj!=null)ProjectAdvanceRequestDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MGA_AdvanceFormId not found");}
repositoryRowObj.Columns=ProjectAdvanceRequestDetails_colObj;
ProjectAdvanceDetailsREPO3_ProjectAdvanceRequestDetails_rowsObj.Add(repositoryRowObj);
}}

ProjectAdvanceRequestDetailsProjectAdvanceDetailsREPO3tableObj.Rows=ProjectAdvanceDetailsREPO3_ProjectAdvanceRequestDetails_rowsObj;
var ProjectAdvanceDetailsREPO3_repoObj_status_ProjectAdvanceRequestDetails = ProjectAdvanceDetailsREPO3_repoObj.Execute(DomainOperationTypes.CreateOrUpdate,ref ProjectAdvanceRequestDetailsProjectAdvanceDetailsREPO3tableObj);if(!ProjectAdvanceDetailsREPO3_repoObj_status_ProjectAdvanceRequestDetails) throw new Exception("Error in Execute Domain Data Map");}
base.WriteDebugInfo(@"Exiting DomainDataMap for Project Advance Details REPO 3");
}
if(ISpace["M_IsflowReturned"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""M_IsflowReturned""].Value==1)");
ISpace["AssignToUser"].Value=ISpace["M_InitiatorUserMapId"].Value;
base.WriteDebugInfo(@"ISpace[""AssignToUser""].Value=ISpace[""M_InitiatorUserMapId""].Value;");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["AssignToUser"].Value="";
base.WriteDebugInfo(@"ISpace[""AssignToUser""].Value="""";");
}
base.WriteDebugInfo(@"#ReimbursementFundDetails[Rows]");
iSpace.GetLoopExpressionData("ReimbursementFundDetails",ref ISpace);

foreach(var gridChild in ISpace["ReimbursementFundDetails"].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 


if(
ISpace["M_IsflowReturned"].Value==1)
{
base.WriteDebugInfo(@"
if(
ISpace[""M_IsflowReturned""].Value==1)");
base.WriteDebugInfo(@"EXEC [UpsertProjectBudgetDetails] 6,"#MG_P3_ProjectDetailsId","","#MG_P3_Amount","#MG_P3_BudgetHeadId",1,"#MG_P3_FundTypeId"");

var querySource318EAB61FF354EB2A293264135B2F298 =GetQueryExpressionDataSource("318EAB61-FF35-4EB2-A293-264135B2F298");
Dictionary<short,object> result318EAB61FF354EB2A293264135B2F298=iSpace.ExecuteQuery(querySource318EAB61FF354EB2A293264135B2F298,@"EXEC [UpsertProjectBudgetDetails] 6,"" + ISpace["MG_P3_ProjectDetailsId"].Value + @"","","" + ISpace["MG_P3_Amount"].Value + @"","" + ISpace["MG_P3_BudgetHeadId"].Value + @"",1,"" + ISpace["MG_P3_FundTypeId"].Value + @""",false);

base.WriteDebugInfo(@"var querySource318EAB61FF354EB2A293264135B2F298 =GetQueryExpressionDataSource(""318EAB61-FF35-4EB2-A293-264135B2F298"");Dictionary<short,object> result318EAB61FF354EB2A293264135B2F298=iSpace.ExecuteQuery(querySource318EAB61FF354EB2A293264135B2F298,@""EXEC [UpsertProjectBudgetDetails] 6,"""" + ISpace[""MG_P3_ProjectDetailsId""].Value + @"""","""","""" + ISpace[""MG_P3_Amount""].Value + @"""","""" + ISpace[""MG_P3_BudgetHeadId""].Value + @"""",1,"""" + ISpace[""MG_P3_FundTypeId""].Value + @"""""",false);");
base.WriteDebugInfo(@"");

if((result318EAB61FF354EB2A293264135B2F298!=null) && (result318EAB61FF354EB2A293264135B2F298.Count!=0))
{
if(result318EAB61FF354EB2A293264135B2F298.ContainsKey(0))
ISpace["M_UpdateCount"].Value = result318EAB61FF354EB2A293264135B2F298[0];
}
else{
ISpace["M_UpdateCount"].Value = null;
}
}
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("ReimbursementFundDetails","00D69CC2-E6EC-4412-B2A9-14E57A96FB5C",_objectFactory.GetGridRPP("ReimbursementFundDetails"),_elementBase.GetGridLoopQuery("00D69CC2-E6EC-4412-B2A9-14E57A96FB5C","ReimbursementFundDetails",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""ReimbursementFundDetails"",ref ISpace);

foreach(var gridChild in ISpace[""ReimbursementFundDetails""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["M_MoveTo"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""M_MoveTo""].Value=="""")");
ISpace["Message"].Value=@"Move To should be mandatory";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Move To should be mandatory"";");
return;
base.WriteDebugInfo(@"return;");
}
}
if(ISpace["M_SaveDomainData"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""M_SaveDomainData""].Value==1)");
ISpace["M_Status"].Value="Approved";
base.WriteDebugInfo(@"ISpace[""M_Status""].Value=""Approved"";");
}
if(ISpace["M_IsCancelReject"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""M_IsCancelReject""].Value==1)");
ISpace["M_Status"].Value="Dropped";
base.WriteDebugInfo(@"ISpace[""M_Status""].Value=""Dropped"";");
}
base.WriteDebugInfo(@"Entering DomainDataMap for User Request For other steps");
var UserRequestForothersteps_repoObj = new RepositoryMapper(DbTypes.SQLServer);


var UserRequestsUserRequestForotherstepstableObj = new RepositoryTable("UserRequests");
  UserRequestsUserRequestForotherstepstableObj.AppConnectionSettingsId  ="9ADED37B-CD11-426B-AF16-DEAC75685EF5";UserRequestsUserRequestForotherstepstableObj.ProofConnectionId = "C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0)";
var UserRequestForothersteps_UserRequests_rows = GetElementClientData(ISpace["InstanceId"].Value,"6B463D69-64AB-468E-B2E3-DB12E6B90014");

if(UserRequestForothersteps_UserRequests_rows!=null && UserRequestForothersteps_UserRequests_rows.Count>0){
var UserRequestForothersteps_UserRequests_rowsObj = new List<RepositoryRow>();
foreach(var rows in UserRequestForothersteps_UserRequests_rows){RepositoryRow repositoryRowObj = null;string elementData = null;RepositoryColumn repositoryColumnObj = null;if(rows !=null){ var UserRequests_colObj = new List<RepositoryColumn>();repositoryRowObj= new RepositoryRow();//var myByte = (byte)rowData.Value.RwSt;//repositoryRowObj.RowState=(RepositoryRowState)myByte;

if(rows.ContainsKey("34CFB4AA-E9A1-4EAC-83A8-AEC1C4038EE1"))     elementData = rows["34CFB4AA-E9A1-4EAC-83A8-AEC1C4038EE1"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"CurrentLevel",false,false,9);
if(repositoryColumnObj!=null)UserRequests_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-M_NextStage not found");}

if(rows.ContainsKey("B89FF303-5A1C-4060-BAB9-E6F52A11D9FD"))     elementData = rows["B89FF303-5A1C-4060-BAB9-E6F52A11D9FD"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"CurrentStatus",false,false,9);
if(repositoryColumnObj!=null)UserRequests_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-M_Status not found");}

elementData = ISpace["gv_UserId"].Value != null? Convert.ToString(ISpace["gv_UserId"].Value):null ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"LastModifiedByUserID",false,false,5);
if(repositoryColumnObj!=null)UserRequests_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-gv_UserId not found");}

if(rows.ContainsKey("0CDC8D38-F4F4-4C60-BCED-E9F0C8B165B8"))     elementData = rows["0CDC8D38-F4F4-4C60-BCED-E9F0C8B165B8"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"CurrentActivityMapID",false,false,9);
if(repositoryColumnObj!=null)UserRequests_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-SetDestinationTo not found");}

if(rows.ContainsKey("D7BB255E-9A01-4B5B-AE06-CC4D6E088D52"))     elementData = rows["D7BB255E-9A01-4B5B-AE06-CC4D6E088D52"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"InstanceID",true,false,9);
if(repositoryColumnObj!=null)UserRequests_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-M_InstanceId not found");}

elementData = CurrentDate().ToString() ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"LastModifiedOn",false,false,8);
if(repositoryColumnObj!=null)UserRequests_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-CurrentDate not found");}
repositoryRowObj.Columns=UserRequests_colObj;
UserRequestForothersteps_UserRequests_rowsObj.Add(repositoryRowObj);
}}

UserRequestsUserRequestForotherstepstableObj.Rows=UserRequestForothersteps_UserRequests_rowsObj;
var UserRequestForothersteps_repoObj_status_UserRequests = UserRequestForothersteps_repoObj.Execute(DomainOperationTypes.Update,ref UserRequestsUserRequestForotherstepstableObj);if(!UserRequestForothersteps_repoObj_status_UserRequests) throw new Exception("Error in Execute Domain Data Map");}
base.WriteDebugInfo(@"Exiting DomainDataMap for User Request For other steps");
ISpace["Message"].Value=@"Submitted Successfully";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Submitted Successfully"";");
ISpace.ExecuteInstanceCommand("Submit");
base.WriteDebugInfo(@"ISpace.ExecuteInstanceCommand(""Submit"");");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_save_reimbursementbilldetails (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Save_ReimbursementBillDetails-OnClick");
if(ISpace["growid"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""growid""].Value=="""")");

var querySource588878D7B7824F24BAF7A4FE902E4A93 =GetQueryExpressionDataSource("588878D7-B782-4F24-BAF7-A4FE902E4A93");

DataTable result588878D7B7824F24BAF7A4FE902E4A93=iSpace.SetGridDataSource(querySource588878D7B7824F24BAF7A4FE902E4A93, _objectFactory.GetGridRPP("ReimbursementBillDetails"),@"EXEC AddFormGridDataC9ACCA847AF347E79133D777BE46A656 "" + ISpace["gv_instanceid"].Value + @"","" + ISpace["gv_processmapid"].Value + @"","C9ACCA84-7AF3-47E7-9133-D777BE46A656","" + ISpace["gv_activitymapid"].Value + @"","" + ISpace["MFG_P2_ReimbursementDetailsId"].Value + @"","" + ISpace["MFG_P2_ReimbursementId"].Value + @"","" + ISpace["MFG_P2_BillNo"].Value + @"","" + ISpace["MFG_P2_BillDate"].Value + @""," + ISpace["MFG_P2_BillDocument"].Value + @","" + ISpace["MFG_P2_ItemDescription"].Value + @""," + ISpace["MFG_P2_Amount"].Value + @","" + ISpace["growid"].Value + @""");

iSpace.InsertGridBindDetails("ReimbursementBillDetails","11",querySource588878D7B7824F24BAF7A4FE902E4A93,"EXEC AddFormGridDataC9ACCA847AF347E79133D777BE46A656 "" + ISpace["gv_instanceid"].Value + @"","" + ISpace["gv_processmapid"].Value + @"","C9ACCA84-7AF3-47E7-9133-D777BE46A656","" + ISpace["gv_activitymapid"].Value + @"","" + ISpace["MFG_P2_ReimbursementDetailsId"].Value + @"","" + ISpace["MFG_P2_ReimbursementId"].Value + @"","" + ISpace["MFG_P2_BillNo"].Value + @"","" + ISpace["MFG_P2_BillDate"].Value + @""," + ISpace["MFG_P2_BillDocument"].Value + @","" + ISpace["MFG_P2_ItemDescription"].Value + @""," + ISpace["MFG_P2_Amount"].Value + @","" + ISpace["growid"].Value + @""",_objectFactory.GetGridRPP("ReimbursementBillDetails"));

base.WriteDebugInfo(@"var querySource588878D7B7824F24BAF7A4FE902E4A93 =GetQueryExpressionDataSource(""588878D7-B782-4F24-BAF7-A4FE902E4A93"");DataTable result588878D7B7824F24BAF7A4FE902E4A93=iSpace.SetGridDataSource(querySource588878D7B7824F24BAF7A4FE902E4A93, _objectFactory.GetGridRPP(""ReimbursementBillDetails""),@""EXEC AddFormGridDataC9ACCA847AF347E79133D777BE46A656 """" + ISpace[""gv_instanceid""].Value + @"""","""" + ISpace[""gv_processmapid""].Value + @"""",""C9ACCA84-7AF3-47E7-9133-D777BE46A656"","""" + ISpace[""gv_activitymapid""].Value + @"""","""" + ISpace[""MFG_P2_ReimbursementDetailsId""].Value + @"""","""" + ISpace[""MFG_P2_ReimbursementId""].Value + @"""","""" + ISpace[""MFG_P2_BillNo""].Value + @"""","""" + ISpace[""MFG_P2_BillDate""].Value + @"""","" + ISpace[""MFG_P2_BillDocument""].Value + @"","""" + ISpace[""MFG_P2_ItemDescription""].Value + @"""","" + ISpace[""MFG_P2_Amount""].Value + @"","""" + ISpace[""growid""].Value + @"""""");iSpace.InsertGridBindDetails(""ReimbursementBillDetails"",""11"",querySource588878D7B7824F24BAF7A4FE902E4A93,""EXEC AddFormGridDataC9ACCA847AF347E79133D777BE46A656 """" + ISpace[""gv_instanceid""].Value + @"""","""" + ISpace[""gv_processmapid""].Value + @"""",""C9ACCA84-7AF3-47E7-9133-D777BE46A656"","""" + ISpace[""gv_activitymapid""].Value + @"""","""" + ISpace[""MFG_P2_ReimbursementDetailsId""].Value + @"""","""" + ISpace[""MFG_P2_ReimbursementId""].Value + @"""","""" + ISpace[""MFG_P2_BillNo""].Value + @"""","""" + ISpace[""MFG_P2_BillDate""].Value + @"""","" + ISpace[""MFG_P2_BillDocument""].Value + @"","""" + ISpace[""MFG_P2_ItemDescription""].Value + @"""","" + ISpace[""MFG_P2_Amount""].Value + @"","""" + ISpace[""growid""].Value + @"""""",_objectFactory.GetGridRPP(""ReimbursementBillDetails""));");
base.WriteDebugInfo(@"EXEC AddFormGridDataC9ACCA847AF347E79133D777BE46A656 "@@gv_InstanceId","@@gv_ProcessMapId","C9ACCA84-7AF3-47E7-9133-D777BE46A656","@@gv_ActivityMapId","#MFG_P2_ReimbursementDetailsId","#MFG_P2_ReimbursementId","#MFG_P2_BillNo","#MFG_P2_BillDate",#MFG_P2_BillDocument,"#MFG_P2_ItemDescription",#MFG_P2_Amount,"#growid"");


List<Triplet<string, short, short?>> resultAB481A6E87354F09AD1BC0BBEFC0AD56=acdataIspace893AB0C88E484E9C8DCDEF160F9C9A43.GetQueryExpressionBindings("AB481A6E-8735-4F09-AD1B-C0BBEFC0AD56");
iSpace.SetGridData(result588878D7B7824F24BAF7A4FE902E4A93,resultAB481A6E87354F09AD1BC0BBEFC0AD56,"ReimbursementBillDetails",ref ISpace);
iSpace.UpdateGridBindDetails("ReimbursementBillDetails",resultAB481A6E87354F09AD1BC0BBEFC0AD56);
}
else
{
base.WriteDebugInfo(@"else");

var querySourceF3514DB4690A4BE6A6A77FA3D37E5B7C =GetQueryExpressionDataSource("F3514DB4-690A-4BE6-A6A7-7FA3D37E5B7C");

DataTable resultF3514DB4690A4BE6A6A77FA3D37E5B7C=iSpace.SetGridDataSource(querySourceF3514DB4690A4BE6A6A77FA3D37E5B7C, _objectFactory.GetGridRPP("ReimbursementBillDetails"),@"EXEC UpdateFormGridDataC9ACCA847AF347E79133D777BE46A656 "" + ISpace["gv_instanceid"].Value + @"","" + ISpace["gv_processmapid"].Value + @"","C9ACCA84-7AF3-47E7-9133-D777BE46A656","" + ISpace["gv_activitymapid"].Value + @"","" + ISpace["MFG_P2_ReimbursementDetailsId"].Value + @"","" + ISpace["MFG_P2_ReimbursementId"].Value + @"","" + ISpace["MFG_P2_BillNo"].Value + @"","" + ISpace["MFG_P2_BillDate"].Value + @""," + ISpace["MFG_P2_BillDocument"].Value + @","" + ISpace["MFG_P2_ItemDescription"].Value + @""," + ISpace["MFG_P2_Amount"].Value + @","" + ISpace["growid"].Value + @""");

iSpace.InsertGridBindDetails("ReimbursementBillDetails","11",querySourceF3514DB4690A4BE6A6A77FA3D37E5B7C,"EXEC UpdateFormGridDataC9ACCA847AF347E79133D777BE46A656 "" + ISpace["gv_instanceid"].Value + @"","" + ISpace["gv_processmapid"].Value + @"","C9ACCA84-7AF3-47E7-9133-D777BE46A656","" + ISpace["gv_activitymapid"].Value + @"","" + ISpace["MFG_P2_ReimbursementDetailsId"].Value + @"","" + ISpace["MFG_P2_ReimbursementId"].Value + @"","" + ISpace["MFG_P2_BillNo"].Value + @"","" + ISpace["MFG_P2_BillDate"].Value + @""," + ISpace["MFG_P2_BillDocument"].Value + @","" + ISpace["MFG_P2_ItemDescription"].Value + @""," + ISpace["MFG_P2_Amount"].Value + @","" + ISpace["growid"].Value + @""",_objectFactory.GetGridRPP("ReimbursementBillDetails"));

base.WriteDebugInfo(@"var querySourceF3514DB4690A4BE6A6A77FA3D37E5B7C =GetQueryExpressionDataSource(""F3514DB4-690A-4BE6-A6A7-7FA3D37E5B7C"");DataTable resultF3514DB4690A4BE6A6A77FA3D37E5B7C=iSpace.SetGridDataSource(querySourceF3514DB4690A4BE6A6A77FA3D37E5B7C, _objectFactory.GetGridRPP(""ReimbursementBillDetails""),@""EXEC UpdateFormGridDataC9ACCA847AF347E79133D777BE46A656 """" + ISpace[""gv_instanceid""].Value + @"""","""" + ISpace[""gv_processmapid""].Value + @"""",""C9ACCA84-7AF3-47E7-9133-D777BE46A656"","""" + ISpace[""gv_activitymapid""].Value + @"""","""" + ISpace[""MFG_P2_ReimbursementDetailsId""].Value + @"""","""" + ISpace[""MFG_P2_ReimbursementId""].Value + @"""","""" + ISpace[""MFG_P2_BillNo""].Value + @"""","""" + ISpace[""MFG_P2_BillDate""].Value + @"""","" + ISpace[""MFG_P2_BillDocument""].Value + @"","""" + ISpace[""MFG_P2_ItemDescription""].Value + @"""","" + ISpace[""MFG_P2_Amount""].Value + @"","""" + ISpace[""growid""].Value + @"""""");iSpace.InsertGridBindDetails(""ReimbursementBillDetails"",""11"",querySourceF3514DB4690A4BE6A6A77FA3D37E5B7C,""EXEC UpdateFormGridDataC9ACCA847AF347E79133D777BE46A656 """" + ISpace[""gv_instanceid""].Value + @"""","""" + ISpace[""gv_processmapid""].Value + @"""",""C9ACCA84-7AF3-47E7-9133-D777BE46A656"","""" + ISpace[""gv_activitymapid""].Value + @"""","""" + ISpace[""MFG_P2_ReimbursementDetailsId""].Value + @"""","""" + ISpace[""MFG_P2_ReimbursementId""].Value + @"""","""" + ISpace[""MFG_P2_BillNo""].Value + @"""","""" + ISpace[""MFG_P2_BillDate""].Value + @"""","" + ISpace[""MFG_P2_BillDocument""].Value + @"","""" + ISpace[""MFG_P2_ItemDescription""].Value + @"""","" + ISpace[""MFG_P2_Amount""].Value + @"","""" + ISpace[""growid""].Value + @"""""",_objectFactory.GetGridRPP(""ReimbursementBillDetails""));");
base.WriteDebugInfo(@"EXEC UpdateFormGridDataC9ACCA847AF347E79133D777BE46A656 "@@gv_InstanceId","@@gv_ProcessMapId","C9ACCA84-7AF3-47E7-9133-D777BE46A656","@@gv_ActivityMapId","#MFG_P2_ReimbursementDetailsId","#MFG_P2_ReimbursementId","#MFG_P2_BillNo","#MFG_P2_BillDate",#MFG_P2_BillDocument,"#MFG_P2_ItemDescription",#MFG_P2_Amount,"#growid"");


List<Triplet<string, short, short?>> result51CA1824668943C9A9D9B360B3E6BBB8=acdataIspace893AB0C88E484E9C8DCDEF160F9C9A43.GetQueryExpressionBindings("51CA1824-6689-43C9-A9D9-B360B3E6BBB8");
iSpace.SetGridData(resultF3514DB4690A4BE6A6A77FA3D37E5B7C,result51CA1824668943C9A9D9B360B3E6BBB8,"ReimbursementBillDetails",ref ISpace);
iSpace.UpdateGridBindDetails("ReimbursementBillDetails",result51CA1824668943C9A9D9B360B3E6BBB8);
}
ISpace["growid"].Value="";
base.WriteDebugInfo(@"ISpace[""growid""].Value="""";");
ISpace["MFG_P2_ReimbursementDetailsId"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_P2_ReimbursementDetailsId""].Value="""";");
ISpace["MFG_P2_ReimbursementId"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_P2_ReimbursementId""].Value="""";");
ISpace["MFG_P2_BillNo"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_P2_BillNo""].Value="""";");
ISpace["MFG_P2_BillDate"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_P2_BillDate""].Value="""";");
ISpace["MFG_P2_BillDocument"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_P2_BillDocument""].Value="""";");
ISpace["MFG_P2_ItemDescription"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_P2_ItemDescription""].Value="""";");
ISpace["MFG_P2_Amount"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_P2_Amount""].Value="""";");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_edit_reimbursementfunddetails (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Edit_ReimbursementFundDetails-OnClick");
ISpace["growid"].Value=ISpace["ReimbursementFundDetails_RowId"].Value;
base.WriteDebugInfo(@"ISpace[""growid""].Value=ISpace[""ReimbursementFundDetails_RowId""].Value;");
base.WriteDebugInfo(@"EXEC  [LoadFormGridData1112A274004543D393C5205DAEFEA917]  "@@gv_InstanceId","@@gv_ProcessMapId","1112A274-0045-43D3-93C5-205DAEFEA917","@@gv_ActivityMapId","#growid"");

var querySource457B75FDB3F34EB787EB96D92F86F9EB =GetQueryExpressionDataSource("457B75FD-B3F3-4EB7-87EB-96D92F86F9EB");
Dictionary<short,object> result457B75FDB3F34EB787EB96D92F86F9EB=iSpace.ExecuteQuery(querySource457B75FDB3F34EB787EB96D92F86F9EB,@"EXEC[LoadFormGridData1112A274004543D393C5205DAEFEA917]"" + ISpace["gv_instanceid"].Value + @"","" + ISpace["gv_processmapid"].Value + @"","1112A274-0045-43D3-93C5-205DAEFEA917","" + ISpace["gv_activitymapid"].Value + @"","" + ISpace["growid"].Value + @""",false);

base.WriteDebugInfo(@"var querySource457B75FDB3F34EB787EB96D92F86F9EB =GetQueryExpressionDataSource(""457B75FD-B3F3-4EB7-87EB-96D92F86F9EB"");Dictionary<short,object> result457B75FDB3F34EB787EB96D92F86F9EB=iSpace.ExecuteQuery(querySource457B75FDB3F34EB787EB96D92F86F9EB,@""EXEC[LoadFormGridData1112A274004543D393C5205DAEFEA917]"""" + ISpace[""gv_instanceid""].Value + @"""","""" + ISpace[""gv_processmapid""].Value + @"""",""1112A274-0045-43D3-93C5-205DAEFEA917"","""" + ISpace[""gv_activitymapid""].Value + @"""","""" + ISpace[""growid""].Value + @"""""",false);");
base.WriteDebugInfo(@"EXEC LoadFormGridDataD85301F7BAF94BE8A2B174E5CBB3D054 "@@gv_InstanceId","@@gv_ProcessMapId","D85301F7-BAF9-4BE8-A2B1-74E5CBB3D054","@@gv_ActivityMapId","#growid"");

if((result457B75FDB3F34EB787EB96D92F86F9EB!=null) && (result457B75FDB3F34EB787EB96D92F86F9EB.Count!=0))
{
if(result457B75FDB3F34EB787EB96D92F86F9EB.ContainsKey(2))
ISpace["MFG_P3_FundTypeId"].Value = result457B75FDB3F34EB787EB96D92F86F9EB[2];
if(result457B75FDB3F34EB787EB96D92F86F9EB.ContainsKey(3))
ISpace["MFG_P3_ProjectDetailsId"].Value = result457B75FDB3F34EB787EB96D92F86F9EB[3];
if(result457B75FDB3F34EB787EB96D92F86F9EB.ContainsKey(4))
ISpace["MFG_P3_BudgetHeadId"].Value = result457B75FDB3F34EB787EB96D92F86F9EB[4];
if(result457B75FDB3F34EB787EB96D92F86F9EB.ContainsKey(5))
ISpace["MFG_P3_Amount"].Value = result457B75FDB3F34EB787EB96D92F86F9EB[5];
if(result457B75FDB3F34EB787EB96D92F86F9EB.ContainsKey(0))
ISpace["MFG_P3_FundDetailsId"].Value = result457B75FDB3F34EB787EB96D92F86F9EB[0];
if(result457B75FDB3F34EB787EB96D92F86F9EB.ContainsKey(1))
ISpace["MFG_P3_ReimbursementId"].Value = result457B75FDB3F34EB787EB96D92F86F9EB[1];
}
else{
ISpace["MFG_P3_FundTypeId"].Value = null;ISpace["MFG_P3_ProjectDetailsId"].Value = null;ISpace["MFG_P3_BudgetHeadId"].Value = null;ISpace["MFG_P3_Amount"].Value = null;ISpace["MFG_P3_FundDetailsId"].Value = null;ISpace["MFG_P3_ReimbursementId"].Value = null;
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_m_moveto (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"M_MoveTo-OnChange");
ISpace["M_MoveToValue"].Value=ISpace["M_MoveTo"].Value;
base.WriteDebugInfo(@"ISpace[""M_MoveToValue""].Value=ISpace[""M_MoveTo""].Value;");
base.WriteDebugInfo(@"Exec GetStageStatus 1,"","","#M_MoveToValue","#M_SourceActivityMapId"");

var querySource549686A138974AFCA19EC95972C37210 =GetQueryExpressionDataSource("549686A1-3897-4AFC-A19E-C95972C37210");
Dictionary<short,object> result549686A138974AFCA19EC95972C37210=iSpace.ExecuteQuery(querySource549686A138974AFCA19EC95972C37210,@"Exec GetStageStatus 1,"","","" + ISpace["M_MoveToValue"].Value + @"","" + ISpace["M_SourceActivityMapId"].Value + @""",false);

base.WriteDebugInfo(@"var querySource549686A138974AFCA19EC95972C37210 =GetQueryExpressionDataSource(""549686A1-3897-4AFC-A19E-C95972C37210"");Dictionary<short,object> result549686A138974AFCA19EC95972C37210=iSpace.ExecuteQuery(querySource549686A138974AFCA19EC95972C37210,@""Exec GetStageStatus 1,"""","""","""" + ISpace[""M_MoveToValue""].Value + @"""","""" + ISpace[""M_SourceActivityMapId""].Value + @"""""",false);");
base.WriteDebugInfo(@"");

if((result549686A138974AFCA19EC95972C37210!=null) && (result549686A138974AFCA19EC95972C37210.Count!=0))
{
if(result549686A138974AFCA19EC95972C37210.ContainsKey(3))
ISpace["M_SaveDomainData"].Value = result549686A138974AFCA19EC95972C37210[3];
if(result549686A138974AFCA19EC95972C37210.ContainsKey(1))
ISpace["M_RemarksMandatory"].Value = result549686A138974AFCA19EC95972C37210[1];
if(result549686A138974AFCA19EC95972C37210.ContainsKey(4))
ISpace["M_FieldMandatory"].Value = result549686A138974AFCA19EC95972C37210[4];
if(result549686A138974AFCA19EC95972C37210.ContainsKey(2))
ISpace["MF_P1_Remarks"].Value = result549686A138974AFCA19EC95972C37210[2];
if(result549686A138974AFCA19EC95972C37210.ContainsKey(0))
ISpace["M_NextStage"].Value = result549686A138974AFCA19EC95972C37210[0];
}
else{
ISpace["M_SaveDomainData"].Value = null;ISpace["M_RemarksMandatory"].Value = null;ISpace["M_FieldMandatory"].Value = null;ISpace["MF_P1_Remarks"].Value = null;ISpace["M_NextStage"].Value = null;
}
ISpace["SetDestinationTo"].Value=ISpace["M_MoveTo"].Value;
base.WriteDebugInfo(@"ISpace[""SetDestinationTo""].Value=ISpace[""M_MoveTo""].Value;");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_edit_reimbursementbilldetails (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Edit_ReimbursementBillDetails-OnClick");
base.WriteDebugInfo(@"EXEC LoadFormGridDataC9ACCA847AF347E79133D777BE46A656 "@@gv_InstanceId","@@gv_ProcessMapId","C9ACCA84-7AF3-47E7-9133-D777BE46A656","@@gv_ActivityMapId","#growid"");

var querySourceE12571F81F5945ED9BC6BAF0AA62F4F0 =GetQueryExpressionDataSource("E12571F8-1F59-45ED-9BC6-BAF0AA62F4F0");
Dictionary<short,object> resultE12571F81F5945ED9BC6BAF0AA62F4F0=iSpace.ExecuteQuery(querySourceE12571F81F5945ED9BC6BAF0AA62F4F0,@"EXEC LoadFormGridDataC9ACCA847AF347E79133D777BE46A656 "" + ISpace["gv_instanceid"].Value + @"","" + ISpace["gv_processmapid"].Value + @"","C9ACCA84-7AF3-47E7-9133-D777BE46A656","" + ISpace["gv_activitymapid"].Value + @"","" + ISpace["growid"].Value + @""",false);

base.WriteDebugInfo(@"var querySourceE12571F81F5945ED9BC6BAF0AA62F4F0 =GetQueryExpressionDataSource(""E12571F8-1F59-45ED-9BC6-BAF0AA62F4F0"");Dictionary<short,object> resultE12571F81F5945ED9BC6BAF0AA62F4F0=iSpace.ExecuteQuery(querySourceE12571F81F5945ED9BC6BAF0AA62F4F0,@""EXEC LoadFormGridDataC9ACCA847AF347E79133D777BE46A656 """" + ISpace[""gv_instanceid""].Value + @"""","""" + ISpace[""gv_processmapid""].Value + @"""",""C9ACCA84-7AF3-47E7-9133-D777BE46A656"","""" + ISpace[""gv_activitymapid""].Value + @"""","""" + ISpace[""growid""].Value + @"""""",false);");
base.WriteDebugInfo(@"EXEC LoadFormGridDataC9ACCA847AF347E79133D777BE46A656 "@@gv_InstanceId","@@gv_ProcessMapId","C9ACCA84-7AF3-47E7-9133-D777BE46A656","@@gv_ActivityMapId","#growid"");

if((resultE12571F81F5945ED9BC6BAF0AA62F4F0!=null) && (resultE12571F81F5945ED9BC6BAF0AA62F4F0.Count!=0))
{
if(resultE12571F81F5945ED9BC6BAF0AA62F4F0.ContainsKey(3))
ISpace["MFG_P2_BillDate"].Value = resultE12571F81F5945ED9BC6BAF0AA62F4F0[3];
if(resultE12571F81F5945ED9BC6BAF0AA62F4F0.ContainsKey(4))
ISpace["MFG_P2_BillDocument"].Value = resultE12571F81F5945ED9BC6BAF0AA62F4F0[4];
if(resultE12571F81F5945ED9BC6BAF0AA62F4F0.ContainsKey(6))
ISpace["MFG_P2_Amount"].Value = resultE12571F81F5945ED9BC6BAF0AA62F4F0[6];
if(resultE12571F81F5945ED9BC6BAF0AA62F4F0.ContainsKey(5))
ISpace["MFG_P2_ItemDescription"].Value = resultE12571F81F5945ED9BC6BAF0AA62F4F0[5];
if(resultE12571F81F5945ED9BC6BAF0AA62F4F0.ContainsKey(0))
ISpace["MFG_P2_ReimbursementDetailsId"].Value = resultE12571F81F5945ED9BC6BAF0AA62F4F0[0];
if(resultE12571F81F5945ED9BC6BAF0AA62F4F0.ContainsKey(1))
ISpace["MFG_P2_ReimbursementId"].Value = resultE12571F81F5945ED9BC6BAF0AA62F4F0[1];
if(resultE12571F81F5945ED9BC6BAF0AA62F4F0.ContainsKey(2))
ISpace["MFG_P2_BillNo"].Value = resultE12571F81F5945ED9BC6BAF0AA62F4F0[2];
}
else{
ISpace["MFG_P2_BillDate"].Value = null;ISpace["MFG_P2_BillDocument"].Value = null;ISpace["MFG_P2_Amount"].Value = null;ISpace["MFG_P2_ItemDescription"].Value = null;ISpace["MFG_P2_ReimbursementDetailsId"].Value = null;ISpace["MFG_P2_ReimbursementId"].Value = null;ISpace["MFG_P2_BillNo"].Value = null;
}
ISpace["growid"].Value=ISpace["ReimbursementBillDetails_RowId"].Value;
base.WriteDebugInfo(@"ISpace[""growid""].Value=ISpace[""ReimbursementBillDetails_RowId""].Value;");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_save_reimbursementfunddetails (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Save_ReimbursementFundDetails-OnClick");
if(ISpace["MFG_P3_FundTypeId"].Value=="1")
{
base.WriteDebugInfo(@"if(ISpace[""MFG_P3_FundTypeId""].Value==""1"")");
base.WriteDebugInfo(@"#ReimbursementFundDetails[Rows]");
iSpace.GetLoopExpressionData("ReimbursementFundDetails",ref ISpace);

foreach(var gridChild in ISpace["ReimbursementFundDetails"].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 


if(


ISpace["growid"].Value!=ISpace["ReimbursementFundDetails_RowId"].Value||ISpace["growid"].Value=="")
{
base.WriteDebugInfo(@"
if(


ISpace[""growid""].Value!=ISpace[""ReimbursementFundDetails_RowId""].Value||ISpace[""growid""].Value=="""")");
if(ISpace["MFG_P3_BudgetHeadId"].Value==ISpace["MG_P3_BudgetHeadId"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MFG_P3_BudgetHeadId""].Value==ISpace[""MG_P3_BudgetHeadId""].Value)");
ISpace["Message"].Value=@"Budget Head is already Exists";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Budget Head is already Exists"";");
ISpace["MFG_P3_BudgetHeadId"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_P3_BudgetHeadId""].Value="""";");
return;
base.WriteDebugInfo(@"return;");
}
}
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("ReimbursementFundDetails","00D69CC2-E6EC-4412-B2A9-14E57A96FB5C",_objectFactory.GetGridRPP("ReimbursementFundDetails"),_elementBase.GetGridLoopQuery("00D69CC2-E6EC-4412-B2A9-14E57A96FB5C","ReimbursementFundDetails",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""ReimbursementFundDetails"",ref ISpace);

foreach(var gridChild in ISpace[""ReimbursementFundDetails""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
}
if(ISpace["growid"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""growid""].Value=="""")");

var querySourceC5471BC38ECA4216A66F923825C32508 =GetQueryExpressionDataSource("C5471BC3-8ECA-4216-A66F-923825C32508");

DataTable resultC5471BC38ECA4216A66F923825C32508=iSpace.SetGridDataSource(querySourceC5471BC38ECA4216A66F923825C32508, _objectFactory.GetGridRPP("ReimbursementFundDetails"),@"EXEC AddFormGridData1112A274004543D393C5205DAEFEA917 "" + ISpace["gv_instanceid"].Value + @"","" + ISpace["gv_processmapid"].Value + @"","1112A274-0045-43D3-93C5-205DAEFEA917","" + ISpace["gv_activitymapid"].Value + @"","" + ISpace["MFG_P3_FundDetailsId"].Value + @"","" + ISpace["M_Advanceformid"].Value + @"","" + ISpace["MFG_P3_FundTypeId"].Value + @"","" + ISpace["MFG_P3_ProjectDetailsId"].Value + @"","" + ISpace["MFG_P3_BudgetHeadId"].Value + @""," + ISpace["MFG_P3_Amount"].Value + @","" + ISpace["growid"].Value + @""");

iSpace.InsertGridBindDetails("ReimbursementFundDetails","11",querySourceC5471BC38ECA4216A66F923825C32508,"EXEC AddFormGridData1112A274004543D393C5205DAEFEA917 "" + ISpace["gv_instanceid"].Value + @"","" + ISpace["gv_processmapid"].Value + @"","1112A274-0045-43D3-93C5-205DAEFEA917","" + ISpace["gv_activitymapid"].Value + @"","" + ISpace["MFG_P3_FundDetailsId"].Value + @"","" + ISpace["M_Advanceformid"].Value + @"","" + ISpace["MFG_P3_FundTypeId"].Value + @"","" + ISpace["MFG_P3_ProjectDetailsId"].Value + @"","" + ISpace["MFG_P3_BudgetHeadId"].Value + @""," + ISpace["MFG_P3_Amount"].Value + @","" + ISpace["growid"].Value + @""",_objectFactory.GetGridRPP("ReimbursementFundDetails"));

base.WriteDebugInfo(@"var querySourceC5471BC38ECA4216A66F923825C32508 =GetQueryExpressionDataSource(""C5471BC3-8ECA-4216-A66F-923825C32508"");DataTable resultC5471BC38ECA4216A66F923825C32508=iSpace.SetGridDataSource(querySourceC5471BC38ECA4216A66F923825C32508, _objectFactory.GetGridRPP(""ReimbursementFundDetails""),@""EXEC AddFormGridData1112A274004543D393C5205DAEFEA917 """" + ISpace[""gv_instanceid""].Value + @"""","""" + ISpace[""gv_processmapid""].Value + @"""",""1112A274-0045-43D3-93C5-205DAEFEA917"","""" + ISpace[""gv_activitymapid""].Value + @"""","""" + ISpace[""MFG_P3_FundDetailsId""].Value + @"""","""" + ISpace[""M_Advanceformid""].Value + @"""","""" + ISpace[""MFG_P3_FundTypeId""].Value + @"""","""" + ISpace[""MFG_P3_ProjectDetailsId""].Value + @"""","""" + ISpace[""MFG_P3_BudgetHeadId""].Value + @"""","" + ISpace[""MFG_P3_Amount""].Value + @"","""" + ISpace[""growid""].Value + @"""""");iSpace.InsertGridBindDetails(""ReimbursementFundDetails"",""11"",querySourceC5471BC38ECA4216A66F923825C32508,""EXEC AddFormGridData1112A274004543D393C5205DAEFEA917 """" + ISpace[""gv_instanceid""].Value + @"""","""" + ISpace[""gv_processmapid""].Value + @"""",""1112A274-0045-43D3-93C5-205DAEFEA917"","""" + ISpace[""gv_activitymapid""].Value + @"""","""" + ISpace[""MFG_P3_FundDetailsId""].Value + @"""","""" + ISpace[""M_Advanceformid""].Value + @"""","""" + ISpace[""MFG_P3_FundTypeId""].Value + @"""","""" + ISpace[""MFG_P3_ProjectDetailsId""].Value + @"""","""" + ISpace[""MFG_P3_BudgetHeadId""].Value + @"""","" + ISpace[""MFG_P3_Amount""].Value + @"","""" + ISpace[""growid""].Value + @"""""",_objectFactory.GetGridRPP(""ReimbursementFundDetails""));");
base.WriteDebugInfo(@"EXEC AddFormGridDataD85301F7BAF94BE8A2B174E5CBB3D054 "@@gv_InstanceId","@@gv_ProcessMapId","D85301F7-BAF9-4BE8-A2B1-74E5CBB3D054","@@gv_ActivityMapId","#MFG_P3_FundDetailsId","#MFG_P3_ReimbursementId","#MFG_P3_FundTypeId","#MFG_P3_ProjectDetailsId","#MFG_P3_BudgetHeadId",#MFG_P3_Amount,"#growid"");


List<Triplet<string, short, short?>> result169C69C3949245478D79196C3E1309FB=acdataIspace893AB0C88E484E9C8DCDEF160F9C9A43.GetQueryExpressionBindings("169C69C3-9492-4547-8D79-196C3E1309FB");
iSpace.SetGridData(resultC5471BC38ECA4216A66F923825C32508,result169C69C3949245478D79196C3E1309FB,"ReimbursementFundDetails",ref ISpace);
iSpace.UpdateGridBindDetails("ReimbursementFundDetails",result169C69C3949245478D79196C3E1309FB);
}
else
{
base.WriteDebugInfo(@"else");

var querySourceA8D19C29F512446883DE4C86EF7F0E8F =GetQueryExpressionDataSource("A8D19C29-F512-4468-83DE-4C86EF7F0E8F");

DataTable resultA8D19C29F512446883DE4C86EF7F0E8F=iSpace.SetGridDataSource(querySourceA8D19C29F512446883DE4C86EF7F0E8F, _objectFactory.GetGridRPP("ReimbursementFundDetails"),@"EXEC UpdateFormGridData1112A274004543D393C5205DAEFEA917 "" + ISpace["gv_instanceid"].Value + @"","" + ISpace["gv_processmapid"].Value + @"","1112A274-0045-43D3-93C5-205DAEFEA917","" + ISpace["gv_activitymapid"].Value + @"","" + ISpace["MFG_P3_FundDetailsId"].Value + @"","" + ISpace["M_Advanceformid"].Value + @"","" + ISpace["MFG_P3_FundTypeId"].Value + @"","" + ISpace["MFG_P3_ProjectDetailsId"].Value + @"","" + ISpace["MFG_P3_BudgetHeadId"].Value + @""," + ISpace["MFG_P3_Amount"].Value + @","" + ISpace["growid"].Value + @""");

iSpace.InsertGridBindDetails("ReimbursementFundDetails","11",querySourceA8D19C29F512446883DE4C86EF7F0E8F,"EXEC UpdateFormGridData1112A274004543D393C5205DAEFEA917 "" + ISpace["gv_instanceid"].Value + @"","" + ISpace["gv_processmapid"].Value + @"","1112A274-0045-43D3-93C5-205DAEFEA917","" + ISpace["gv_activitymapid"].Value + @"","" + ISpace["MFG_P3_FundDetailsId"].Value + @"","" + ISpace["M_Advanceformid"].Value + @"","" + ISpace["MFG_P3_FundTypeId"].Value + @"","" + ISpace["MFG_P3_ProjectDetailsId"].Value + @"","" + ISpace["MFG_P3_BudgetHeadId"].Value + @""," + ISpace["MFG_P3_Amount"].Value + @","" + ISpace["growid"].Value + @""",_objectFactory.GetGridRPP("ReimbursementFundDetails"));

base.WriteDebugInfo(@"var querySourceA8D19C29F512446883DE4C86EF7F0E8F =GetQueryExpressionDataSource(""A8D19C29-F512-4468-83DE-4C86EF7F0E8F"");DataTable resultA8D19C29F512446883DE4C86EF7F0E8F=iSpace.SetGridDataSource(querySourceA8D19C29F512446883DE4C86EF7F0E8F, _objectFactory.GetGridRPP(""ReimbursementFundDetails""),@""EXEC UpdateFormGridData1112A274004543D393C5205DAEFEA917 """" + ISpace[""gv_instanceid""].Value + @"""","""" + ISpace[""gv_processmapid""].Value + @"""",""1112A274-0045-43D3-93C5-205DAEFEA917"","""" + ISpace[""gv_activitymapid""].Value + @"""","""" + ISpace[""MFG_P3_FundDetailsId""].Value + @"""","""" + ISpace[""M_Advanceformid""].Value + @"""","""" + ISpace[""MFG_P3_FundTypeId""].Value + @"""","""" + ISpace[""MFG_P3_ProjectDetailsId""].Value + @"""","""" + ISpace[""MFG_P3_BudgetHeadId""].Value + @"""","" + ISpace[""MFG_P3_Amount""].Value + @"","""" + ISpace[""growid""].Value + @"""""");iSpace.InsertGridBindDetails(""ReimbursementFundDetails"",""11"",querySourceA8D19C29F512446883DE4C86EF7F0E8F,""EXEC UpdateFormGridData1112A274004543D393C5205DAEFEA917 """" + ISpace[""gv_instanceid""].Value + @"""","""" + ISpace[""gv_processmapid""].Value + @"""",""1112A274-0045-43D3-93C5-205DAEFEA917"","""" + ISpace[""gv_activitymapid""].Value + @"""","""" + ISpace[""MFG_P3_FundDetailsId""].Value + @"""","""" + ISpace[""M_Advanceformid""].Value + @"""","""" + ISpace[""MFG_P3_FundTypeId""].Value + @"""","""" + ISpace[""MFG_P3_ProjectDetailsId""].Value + @"""","""" + ISpace[""MFG_P3_BudgetHeadId""].Value + @"""","" + ISpace[""MFG_P3_Amount""].Value + @"","""" + ISpace[""growid""].Value + @"""""",_objectFactory.GetGridRPP(""ReimbursementFundDetails""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> resultBDF250C27A244A8EB094E340FDE4659C=acdataIspace893AB0C88E484E9C8DCDEF160F9C9A43.GetQueryExpressionBindings("BDF250C2-7A24-4A8E-B094-E340FDE4659C");
iSpace.SetGridData(resultA8D19C29F512446883DE4C86EF7F0E8F,resultBDF250C27A244A8EB094E340FDE4659C,"ReimbursementFundDetails",ref ISpace);
iSpace.UpdateGridBindDetails("ReimbursementFundDetails",resultBDF250C27A244A8EB094E340FDE4659C);
}
base.WriteDebugInfo(@"#ReimbursementFundDetails[Rows]");
iSpace.GetLoopExpressionData("ReimbursementFundDetails",ref ISpace);

foreach(var gridChild in ISpace["ReimbursementFundDetails"].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 



ISpace["MG_P3_Employeebasicinfoid"].Value=ISpace["UC_EmployeeBaicInfoId"].Value;
base.WriteDebugInfo(@"

ISpace[""MG_P3_Employeebasicinfoid""].Value=ISpace[""UC_EmployeeBaicInfoId""].Value;");


ISpace["MG_P3_Packageprocessmapid"].Value=ISpace["M_PackageProcessMapId"].Value;
base.WriteDebugInfo(@"

ISpace[""MG_P3_Packageprocessmapid""].Value=ISpace[""M_PackageProcessMapId""].Value;");
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("ReimbursementFundDetails","00D69CC2-E6EC-4412-B2A9-14E57A96FB5C",_objectFactory.GetGridRPP("ReimbursementFundDetails"),_elementBase.GetGridLoopQuery("00D69CC2-E6EC-4412-B2A9-14E57A96FB5C","ReimbursementFundDetails",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""ReimbursementFundDetails"",ref ISpace);

foreach(var gridChild in ISpace[""ReimbursementFundDetails""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
object MG_P3_Amount=iSpace.Sum("[00D69CC2-E6EC-4412-B2A9-14E57A96FB5C]","MG_P3_Amount","");
ISpace["MFG_P3_OverallAmount"].Value=Convert.ChangeType(MG_P3_Amount, MG_P3_Amount.GetType());;
base.WriteDebugInfo(@"object MG_P3_Amount=iSpace.Sum(""[00D69CC2-E6EC-4412-B2A9-14E57A96FB5C]"",""MG_P3_Amount"","""");
ISpace[""MFG_P3_OverallAmount""].Value=Convert.ChangeType(MG_P3_Amount, MG_P3_Amount.GetType());;");
ISpace["growid"].Value="";
base.WriteDebugInfo(@"ISpace[""growid""].Value="""";");
ISpace["MFG_P3_FundDetailsId"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_P3_FundDetailsId""].Value="""";");
ISpace["MFG_P3_ReimbursementId"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_P3_ReimbursementId""].Value="""";");
ISpace["MFG_P3_FundTypeId"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_P3_FundTypeId""].Value="""";");
ISpace["MFG_P3_ProjectDetailsId"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_P3_ProjectDetailsId""].Value="""";");
ISpace["MFG_P3_BudgetHeadId"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_P3_BudgetHeadId""].Value="""";");
ISpace["MFG_P3_Amount"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_P3_Amount""].Value="""";");
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
		if(elementName.ToLower().Equals("m_moveto"))
    {
    			SubscribeElementEvents_m_moveto(ref dfsParam);
    }
}
	if(methodName.ToLower().Equals("onclick"))
{
		if(elementName.ToLower().Equals("submitform"))
{
			SubscribeElementEvents_submitform(ref dfsParam);
}
		if(elementName.ToLower().Equals("save_reimbursementbilldetails"))
{
			SubscribeElementEvents_save_reimbursementbilldetails(ref dfsParam);
}
		if(elementName.ToLower().Equals("edit_reimbursementfunddetails"))
{
			SubscribeElementEvents_edit_reimbursementfunddetails(ref dfsParam);
}
		if(elementName.ToLower().Equals("edit_reimbursementbilldetails"))
{
			SubscribeElementEvents_edit_reimbursementbilldetails(ref dfsParam);
}
		if(elementName.ToLower().Equals("save_reimbursementfunddetails"))
{
			SubscribeElementEvents_save_reimbursementfunddetails(ref dfsParam);
}
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
public class ISpace99884CE250CB494DB49B5828617FE860 : VirtualForm
{
IISpace iSpace = new ISpace();
AcDataISpace99884CE250CB494DB49B5828617FE860 acdataIspace99884CE250CB494DB49B5828617FE860=new AcDataISpace99884CE250CB494DB49B5828617FE860();
private void SubscribeFormEvents_root(ref Dictionary<string, ServiceElementData> ISpace)
{
try
{
base.WriteDebugInfo(@"Root-OnAfterFormLoad");
ISpace["M_SourceActivityMapId"].Value=ISpace["gv_activitymapid"].Value;
base.WriteDebugInfo(@"ISpace[""M_SourceActivityMapId""].Value=ISpace[""gv_activitymapid""].Value;");
ISpace["M_PackageProcessMapId"].Value=ISpace["gv_processmapid"].Value;
base.WriteDebugInfo(@"ISpace[""M_PackageProcessMapId""].Value=ISpace[""gv_processmapid""].Value;");
ISpace["M_InstanceId"].Value=ISpace["gv_instanceid"].Value;
base.WriteDebugInfo(@"ISpace[""M_InstanceId""].Value=ISpace[""gv_instanceid""].Value;");
ISpace["M_IsSourceStep"].Value=0;
base.WriteDebugInfo(@"ISpace[""M_IsSourceStep""].Value=0;");


ISpace["M_MoveTo"].Man=true;
base.WriteDebugInfo(@"ISpace[""M_MoveTo""].Man=true;");
ISpace["MF_P1_Remarks"].Value="";
base.WriteDebugInfo(@"ISpace[""MF_P1_Remarks""].Value="""";");
ISpace["M_NextStage"].Value="";
base.WriteDebugInfo(@"ISpace[""M_NextStage""].Value="""";");

var querySource8BBB2BE71E8540E59B13CC03C350EAB8 =GetQueryExpressionDataSource("8BBB2BE7-1E85-40E5-9B13-CC03C350EAB8");

DataTable result8BBB2BE71E8540E59B13CC03C350EAB8=iSpace.SetGridDataSource(querySource8BBB2BE71E8540E59B13CC03C350EAB8, _objectFactory.GetGridRPP("MG_RemarksDetails"),@"EXEC GetRemarks "" + ISpace["M_InstanceId"].Value + @""");

iSpace.InsertGridBindDetails("MG_RemarksDetails","11",querySource8BBB2BE71E8540E59B13CC03C350EAB8,"EXEC GetRemarks "" + ISpace["M_InstanceId"].Value + @""",_objectFactory.GetGridRPP("MG_RemarksDetails"));

base.WriteDebugInfo(@"var querySource8BBB2BE71E8540E59B13CC03C350EAB8 =GetQueryExpressionDataSource(""8BBB2BE7-1E85-40E5-9B13-CC03C350EAB8"");DataTable result8BBB2BE71E8540E59B13CC03C350EAB8=iSpace.SetGridDataSource(querySource8BBB2BE71E8540E59B13CC03C350EAB8, _objectFactory.GetGridRPP(""MG_RemarksDetails""),@""EXEC GetRemarks """" + ISpace[""M_InstanceId""].Value + @"""""");iSpace.InsertGridBindDetails(""MG_RemarksDetails"",""11"",querySource8BBB2BE71E8540E59B13CC03C350EAB8,""EXEC GetRemarks """" + ISpace[""M_InstanceId""].Value + @"""""",_objectFactory.GetGridRPP(""MG_RemarksDetails""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> resultCA798124C2C446CCBDA6419353320A96=acdataIspace99884CE250CB494DB49B5828617FE860.GetQueryExpressionBindings("CA798124-C2C4-46CC-BDA6-419353320A96");
iSpace.SetGridData(result8BBB2BE71E8540E59B13CC03C350EAB8,resultCA798124C2C446CCBDA6419353320A96,"MG_RemarksDetails",ref ISpace);
iSpace.UpdateGridBindDetails("MG_RemarksDetails",resultCA798124C2C446CCBDA6419353320A96);
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["MF_P1_ApplicationStatus"].Visible="false";ISpace["MFG_P2_ReimbursementDetailsId"].Visible="false";ISpace["MF_P1_EmployeeBasicInfoId"].Visible="false";ISpace["MFG_P3_FundDetailsId"].Visible="false";ISpace["MFG_P2_BillDocument"].Visible="false";ISpace["MF_P1_UpdatedBy"].Visible="false";ISpace["MF_P1_Initiatedon"].Visible="false";ISpace["MFG_P3_ReimbursementId"].Visible="false";ISpace["MFG_P2_BillDate"].Visible="false";ISpace["MF_P1_TotalAmount"].Visible="true";ISpace["MF_P1_InitatedBy"].Visible="false";ISpace["MFG_P2_ReimbursementId"].Visible="false";ISpace["MFG_P2_BillNo"].Visible="false";ISpace["MFG_P2_Amount"].Visible="false";ISpace["MF_P1_UpdatedOn"].Visible="false";ISpace["MFG_P3_FundTypeId"].Visible="false";ISpace["MFG_P3_ProjectDetailsId"].Visible="false";ISpace["MFG_P3_Amount"].Visible="false";ISpace["MFG_P2_ItemDescription"].Visible="false";ISpace["MF_P1_ReimbursementId"].Visible="false";ISpace["MFG_P3_BudgetHeadId"].Visible="false";
base.WriteDebugInfo(@"ISpace[""MF_P1_ApplicationStatus""].Visible=""false"";ISpace[""MFG_P2_ReimbursementDetailsId""].Visible=""false"";ISpace[""MF_P1_EmployeeBasicInfoId""].Visible=""false"";ISpace[""MFG_P3_FundDetailsId""].Visible=""false"";ISpace[""MFG_P2_BillDocument""].Visible=""false"";ISpace[""MF_P1_UpdatedBy""].Visible=""false"";ISpace[""MF_P1_Initiatedon""].Visible=""false"";ISpace[""MFG_P3_ReimbursementId""].Visible=""false"";ISpace[""MFG_P2_BillDate""].Visible=""false"";ISpace[""MF_P1_TotalAmount""].Visible=""true"";ISpace[""MF_P1_InitatedBy""].Visible=""false"";ISpace[""MFG_P2_ReimbursementId""].Visible=""false"";ISpace[""MFG_P2_BillNo""].Visible=""false"";ISpace[""MFG_P2_Amount""].Visible=""false"";ISpace[""MF_P1_UpdatedOn""].Visible=""false"";ISpace[""MFG_P3_FundTypeId""].Visible=""false"";ISpace[""MFG_P3_ProjectDetailsId""].Visible=""false"";ISpace[""MFG_P3_Amount""].Visible=""false"";ISpace[""MFG_P2_ItemDescription""].Visible=""false"";ISpace[""MF_P1_ReimbursementId""].Visible=""false"";ISpace[""MFG_P3_BudgetHeadId""].Visible=""false"";");
ISpace["MG_P2_BillNo"].Visible="true";ISpace["MG_P2_BillDocument"].Visible="false";ISpace["MG_P2_ReimbursementDetailsId"].Visible="false";ISpace["MG_P2_ReimbursementId"].Visible="false";ISpace["MG_P2_ItemDescription"].Visible="true";ISpace["MG_P2_BillDate"].Visible="true";ISpace["MG_P2_Amount"].Visible="true";
base.WriteDebugInfo(@"ISpace[""MG_P2_BillNo""].Visible=""true"";ISpace[""MG_P2_BillDocument""].Visible=""false"";ISpace[""MG_P2_ReimbursementDetailsId""].Visible=""false"";ISpace[""MG_P2_ReimbursementId""].Visible=""false"";ISpace[""MG_P2_ItemDescription""].Visible=""true"";ISpace[""MG_P2_BillDate""].Visible=""true"";ISpace[""MG_P2_Amount""].Visible=""true"";");
ISpace["MG_P3_ProjectDetailsId"].Visible="true";ISpace["MG_P3_BudgetHeadId"].Visible="true";ISpace["MG_P3_FundTypeId"].Visible="true";ISpace["MG_P3_FundDetailsId"].Visible="false";ISpace["MG_P3_Amount"].Visible="true";ISpace["MG_P3_ReimbursementId"].Visible="false";
base.WriteDebugInfo(@"ISpace[""MG_P3_ProjectDetailsId""].Visible=""true"";ISpace[""MG_P3_BudgetHeadId""].Visible=""true"";ISpace[""MG_P3_FundTypeId""].Visible=""true"";ISpace[""MG_P3_FundDetailsId""].Visible=""false"";ISpace[""MG_P3_Amount""].Visible=""true"";ISpace[""MG_P3_ReimbursementId""].Visible=""false"";");
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_submitform (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"SubmitForm-OnClick");
base.WriteDebugInfo(@"Entering DomainDataMap for Remarks Domain");
var RemarksDomain_repoObj = new RepositoryMapper(DbTypes.SQLServer);


var ActivityTrailLogDetailsRemarksDomaintableObj = new RepositoryTable("ActivityTrailLogDetails");
  ActivityTrailLogDetailsRemarksDomaintableObj.AppConnectionSettingsId  ="9ADED37B-CD11-426B-AF16-DEAC75685EF5";ActivityTrailLogDetailsRemarksDomaintableObj.ProofConnectionId = "C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0)";
var RemarksDomain_ActivityTrailLogDetails_rows = GetElementClientData(ISpace["InstanceId"].Value,"6B463D69-64AB-468E-B2E3-DB12E6B90014");

if(RemarksDomain_ActivityTrailLogDetails_rows!=null && RemarksDomain_ActivityTrailLogDetails_rows.Count>0){
var RemarksDomain_ActivityTrailLogDetails_rowsObj = new List<RepositoryRow>();
foreach(var rows in RemarksDomain_ActivityTrailLogDetails_rows){RepositoryRow repositoryRowObj = null;string elementData = null;RepositoryColumn repositoryColumnObj = null;if(rows !=null){ var ActivityTrailLogDetails_colObj = new List<RepositoryColumn>();repositoryRowObj= new RepositoryRow();//var myByte = (byte)rowData.Value.RwSt;//repositoryRowObj.RowState=(RepositoryRowState)myByte;

if(rows.ContainsKey("5354760A-9EAC-491E-BAB1-C3614187A9BE"))     elementData = rows["5354760A-9EAC-491E-BAB1-C3614187A9BE"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ProcessedInProgressFlag",false,false,5);
if(repositoryColumnObj!=null)ActivityTrailLogDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-M_IsSourceStep not found");}

elementData = CurrentDate().ToString() ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Updatedon",false,false,8);
if(repositoryColumnObj!=null)ActivityTrailLogDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-CurrentDate not found");}

if(rows.ContainsKey("D7BB255E-9A01-4B5B-AE06-CC4D6E088D52"))     elementData = rows["D7BB255E-9A01-4B5B-AE06-CC4D6E088D52"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"InstanceID",false,false,9);
if(repositoryColumnObj!=null)ActivityTrailLogDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-M_InstanceId not found");}

elementData = ISpace["gv_UserId"].Value != null? Convert.ToString(ISpace["gv_UserId"].Value):null ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Updatedby",false,false,6);
if(repositoryColumnObj!=null)ActivityTrailLogDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-gv_UserId not found");}

if(rows.ContainsKey("6DB9BC45-F167-4D8A-9596-1DBA9872F253"))     elementData = rows["6DB9BC45-F167-4D8A-9596-1DBA9872F253"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"DestinationActivityMapID",false,false,9);
if(repositoryColumnObj!=null)ActivityTrailLogDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-M_DestinationActivityId not found");}

elementData = ISpace["gv_UserName"].Value != null? Convert.ToString(ISpace["gv_UserName"].Value):null ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"RemarksBy",false,false,9);
if(repositoryColumnObj!=null)ActivityTrailLogDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-gv_UserName not found");}

elementData = ISpace["gv_ActivityName"].Value != null? Convert.ToString(ISpace["gv_ActivityName"].Value):null ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ActivityName",false,false,9);
if(repositoryColumnObj!=null)ActivityTrailLogDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-gv_ActivityName not found");}

if(rows.ContainsKey("F78328FF-68D9-45E9-BC40-27CD650C9D6C"))     elementData = rows["F78328FF-68D9-45E9-BC40-27CD650C9D6C"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Remarks",false,false,9);
if(repositoryColumnObj!=null)ActivityTrailLogDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MF_P1_Remarks not found");}

elementData = ISpace["gv_TenantId"].Value != null? Convert.ToString(ISpace["gv_TenantId"].Value):null ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"TenantID",false,false,9);
if(repositoryColumnObj!=null)ActivityTrailLogDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-gv_TenantId not found");}

elementData = Guid.NewGuid().ToString();if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"TrailLogId",true,false,9);
if(repositoryColumnObj!=null)ActivityTrailLogDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-GUID not found");}

if(rows.ContainsKey("52A564C4-B656-4F43-B6F3-E592002351F6"))     elementData = rows["52A564C4-B656-4F43-B6F3-E592002351F6"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"SourceActivityMapID",false,false,9);
if(repositoryColumnObj!=null)ActivityTrailLogDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-M_SourceActivityMapId not found");}

elementData = CurrentDate().ToString() ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"RemarksOn",false,false,8);
if(repositoryColumnObj!=null)ActivityTrailLogDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-CurrentDate not found");}
repositoryRowObj.Columns=ActivityTrailLogDetails_colObj;
RemarksDomain_ActivityTrailLogDetails_rowsObj.Add(repositoryRowObj);
}}

ActivityTrailLogDetailsRemarksDomaintableObj.Rows=RemarksDomain_ActivityTrailLogDetails_rowsObj;
var RemarksDomain_repoObj_status_ActivityTrailLogDetails = RemarksDomain_repoObj.Execute(DomainOperationTypes.CreateOrUpdate,ref ActivityTrailLogDetailsRemarksDomaintableObj);if(!RemarksDomain_repoObj_status_ActivityTrailLogDetails) throw new Exception("Error in Execute Domain Data Map");}
base.WriteDebugInfo(@"Exiting DomainDataMap for Remarks Domain");
if(IsNullOrEmpty(ISpace["Declaration"].Value))
{
base.WriteDebugInfo(@"if(IsNullOrEmpty(ISpace[""Declaration""].Value))");
ISpace["Message"].Value=@"Select the declaration";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Select the declaration"";");
return;
base.WriteDebugInfo(@"return;");
}
if(ISpace["M_SaveDomainData"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""M_SaveDomainData""].Value==1)");
ISpace["MF_P1_ApplicationStatus"].Value="A";
base.WriteDebugInfo(@"ISpace[""MF_P1_ApplicationStatus""].Value=""A"";");
}
if(ISpace["M_SaveDomainData"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""M_SaveDomainData""].Value==1)");
base.WriteDebugInfo(@"Entering DomainDataMap for Project Advance Details REPO 1");
var ProjectAdvanceDetailsREPO1_repoObj = new RepositoryMapper(DbTypes.SQLServer);


var ProjectAdvanceFormProjectAdvanceDetailsREPO1tableObj = new RepositoryTable("ProjectAdvanceForm");
  ProjectAdvanceFormProjectAdvanceDetailsREPO1tableObj.AppConnectionSettingsId  ="3A103712-5244-4427-B2B6-1C4E046FD337";ProjectAdvanceFormProjectAdvanceDetailsREPO1tableObj.ProofConnectionId = "C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0)";
var ProjectAdvanceDetailsREPO1_ProjectAdvanceForm_rows = GetElementClientData(ISpace["InstanceId"].Value,"6B463D69-64AB-468E-B2E3-DB12E6B90014");

if(ProjectAdvanceDetailsREPO1_ProjectAdvanceForm_rows!=null && ProjectAdvanceDetailsREPO1_ProjectAdvanceForm_rows.Count>0){
var ProjectAdvanceDetailsREPO1_ProjectAdvanceForm_rowsObj = new List<RepositoryRow>();
foreach(var rows in ProjectAdvanceDetailsREPO1_ProjectAdvanceForm_rows){RepositoryRow repositoryRowObj = null;string elementData = null;RepositoryColumn repositoryColumnObj = null;if(rows !=null){ var ProjectAdvanceForm_colObj = new List<RepositoryColumn>();repositoryRowObj= new RepositoryRow();//var myByte = (byte)rowData.Value.RwSt;//repositoryRowObj.RowState=(RepositoryRowState)myByte;

if(rows.ContainsKey("72A0167C-47E6-4BBA-964A-D18B4C2724BE"))     elementData = rows["72A0167C-47E6-4BBA-964A-D18B4C2724BE"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"AdvanceFormId",true,false,9);
if(repositoryColumnObj!=null)ProjectAdvanceForm_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-M_Advanceformid not found");}

elementData = ISpace["gv_UserName"].Value != null? Convert.ToString(ISpace["gv_UserName"].Value):null ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"InitatedBy",false,false,9);
if(repositoryColumnObj!=null)ProjectAdvanceForm_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-gv_UserName not found");}

elementData = ISpace["gv_UserName"].Value != null? Convert.ToString(ISpace["gv_UserName"].Value):null ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"UpdatedBy",false,false,9);
if(repositoryColumnObj!=null)ProjectAdvanceForm_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-gv_UserName not found");}

if(rows.ContainsKey("16BFBC4B-9CB5-4677-AAE8-85CE6C7260E5"))     elementData = rows["16BFBC4B-9CB5-4677-AAE8-85CE6C7260E5"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ApplicationStatus",false,false,9);
if(repositoryColumnObj!=null)ProjectAdvanceForm_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MF_P1_ApplicationStatus not found");}

if(rows.ContainsKey("329D5240-1DBD-433E-A8EB-0F29F5AA668C"))     elementData = rows["329D5240-1DBD-433E-A8EB-0F29F5AA668C"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"EmployeeBasicInfoId",false,false,9);
if(repositoryColumnObj!=null)ProjectAdvanceForm_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-UC_EmployeeBaicInfoId not found");}

if(rows.ContainsKey("68A2EC13-D240-4EBC-8828-E795581544DA"))     elementData = rows["68A2EC13-D240-4EBC-8828-E795581544DA"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"TotalAmount",false,false,3);
if(repositoryColumnObj!=null)ProjectAdvanceForm_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MF_P1_TotalAmount not found");}

elementData = CurrentDate().ToString() ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Initiatedon",false,false,8);
if(repositoryColumnObj!=null)ProjectAdvanceForm_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-CurrentDate not found");}

elementData = CurrentDate().ToString() ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"UpdatedOn",false,false,8);
if(repositoryColumnObj!=null)ProjectAdvanceForm_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-CurrentDate not found");}
repositoryRowObj.Columns=ProjectAdvanceForm_colObj;
ProjectAdvanceDetailsREPO1_ProjectAdvanceForm_rowsObj.Add(repositoryRowObj);
}}

ProjectAdvanceFormProjectAdvanceDetailsREPO1tableObj.Rows=ProjectAdvanceDetailsREPO1_ProjectAdvanceForm_rowsObj;
var ProjectAdvanceDetailsREPO1_repoObj_status_ProjectAdvanceForm = ProjectAdvanceDetailsREPO1_repoObj.Execute(DomainOperationTypes.CreateOrUpdate,ref ProjectAdvanceFormProjectAdvanceDetailsREPO1tableObj);if(!ProjectAdvanceDetailsREPO1_repoObj_status_ProjectAdvanceForm) throw new Exception("Error in Execute Domain Data Map");}
base.WriteDebugInfo(@"Exiting DomainDataMap for Project Advance Details REPO 1");
base.WriteDebugInfo(@"Entering DomainDataMap for Project Advance Details REPO 2");
var ProjectAdvanceDetailsREPO2_repoObj = new RepositoryMapper(DbTypes.SQLServer);


var ProjectAdvanceFundDetailsProjectAdvanceDetailsREPO2tableObj = new RepositoryTable("ProjectAdvanceFundDetails");
  ProjectAdvanceFundDetailsProjectAdvanceDetailsREPO2tableObj.AppConnectionSettingsId  ="3A103712-5244-4427-B2B6-1C4E046FD337";ProjectAdvanceFundDetailsProjectAdvanceDetailsREPO2tableObj.ProofConnectionId = "C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0)";
var ProjectAdvanceDetailsREPO2_ProjectAdvanceFundDetails_rows = GetElementClientData(ISpace["InstanceId"].Value,"00D69CC2-E6EC-4412-B2A9-14E57A96FB5C");

if(ProjectAdvanceDetailsREPO2_ProjectAdvanceFundDetails_rows!=null && ProjectAdvanceDetailsREPO2_ProjectAdvanceFundDetails_rows.Count>0){
var ProjectAdvanceDetailsREPO2_ProjectAdvanceFundDetails_rowsObj = new List<RepositoryRow>();
foreach(var rows in ProjectAdvanceDetailsREPO2_ProjectAdvanceFundDetails_rows){RepositoryRow repositoryRowObj = null;string elementData = null;RepositoryColumn repositoryColumnObj = null;if(rows !=null){ var ProjectAdvanceFundDetails_colObj = new List<RepositoryColumn>();repositoryRowObj= new RepositoryRow();//var myByte = (byte)rowData.Value.RwSt;//repositoryRowObj.RowState=(RepositoryRowState)myByte;

if(rows.ContainsKey("E20A9876-034C-49BC-A309-26338AAD45BD"))     elementData = rows["E20A9876-034C-49BC-A309-26338AAD45BD"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"AdvanceFormId",false,false,9);
if(repositoryColumnObj!=null)ProjectAdvanceFundDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MG_P3_Advanceformid not found");}

if(rows.ContainsKey("B24F329A-C286-4040-ABD2-B67B5AE4F7BE"))     elementData = rows["B24F329A-C286-4040-ABD2-B67B5AE4F7BE"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"FundDetailsId",true,false,9);
if(repositoryColumnObj!=null)ProjectAdvanceFundDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MG_P3_FundDetailsId not found");}

if(rows.ContainsKey("4F81555E-3503-43B3-AD28-23293B41E926"))     elementData = rows["4F81555E-3503-43B3-AD28-23293B41E926"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ProjectDetailsId",false,false,9);
if(repositoryColumnObj!=null)ProjectAdvanceFundDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MG_P3_ProjectDetailsId not found");}

if(rows.ContainsKey("CCBB2219-451D-4EAE-BA26-1C16A9B0FF7D"))     elementData = rows["CCBB2219-451D-4EAE-BA26-1C16A9B0FF7D"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Amount",false,false,3);
if(repositoryColumnObj!=null)ProjectAdvanceFundDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MG_P3_Amount not found");}

if(rows.ContainsKey("8F687AA1-A6B1-4250-9948-DBAF2D40AB51"))     elementData = rows["8F687AA1-A6B1-4250-9948-DBAF2D40AB51"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"BudgetHeadId",false,false,9);
if(repositoryColumnObj!=null)ProjectAdvanceFundDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MG_P3_BudgetHeadId not found");}

if(rows.ContainsKey("99E459F3-F338-40A6-A1E3-1F7AD7A198CD"))     elementData = rows["99E459F3-F338-40A6-A1E3-1F7AD7A198CD"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"FundTypeId",false,false,6);
if(repositoryColumnObj!=null)ProjectAdvanceFundDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MG_P3_FundTypeId not found");}
repositoryRowObj.Columns=ProjectAdvanceFundDetails_colObj;
ProjectAdvanceDetailsREPO2_ProjectAdvanceFundDetails_rowsObj.Add(repositoryRowObj);
}}

ProjectAdvanceFundDetailsProjectAdvanceDetailsREPO2tableObj.Rows=ProjectAdvanceDetailsREPO2_ProjectAdvanceFundDetails_rowsObj;
var ProjectAdvanceDetailsREPO2_repoObj_status_ProjectAdvanceFundDetails = ProjectAdvanceDetailsREPO2_repoObj.Execute(DomainOperationTypes.CreateOrUpdate,ref ProjectAdvanceFundDetailsProjectAdvanceDetailsREPO2tableObj);if(!ProjectAdvanceDetailsREPO2_repoObj_status_ProjectAdvanceFundDetails) throw new Exception("Error in Execute Domain Data Map");}
base.WriteDebugInfo(@"Exiting DomainDataMap for Project Advance Details REPO 2");
base.WriteDebugInfo(@"Entering DomainDataMap for Project Advance Details REPO 3");
var ProjectAdvanceDetailsREPO3_repoObj = new RepositoryMapper(DbTypes.SQLServer);


var ProjectAdvanceRequestDetailsProjectAdvanceDetailsREPO3tableObj = new RepositoryTable("ProjectAdvanceRequestDetails");
  ProjectAdvanceRequestDetailsProjectAdvanceDetailsREPO3tableObj.AppConnectionSettingsId  ="3A103712-5244-4427-B2B6-1C4E046FD337";ProjectAdvanceRequestDetailsProjectAdvanceDetailsREPO3tableObj.ProofConnectionId = "C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0)";
var ProjectAdvanceDetailsREPO3_ProjectAdvanceRequestDetails_rows = GetElementClientData(ISpace["InstanceId"].Value,"1356A8F2-1947-4667-987D-2EA211B288A3");

if(ProjectAdvanceDetailsREPO3_ProjectAdvanceRequestDetails_rows!=null && ProjectAdvanceDetailsREPO3_ProjectAdvanceRequestDetails_rows.Count>0){
var ProjectAdvanceDetailsREPO3_ProjectAdvanceRequestDetails_rowsObj = new List<RepositoryRow>();
foreach(var rows in ProjectAdvanceDetailsREPO3_ProjectAdvanceRequestDetails_rows){RepositoryRow repositoryRowObj = null;string elementData = null;RepositoryColumn repositoryColumnObj = null;if(rows !=null){ var ProjectAdvanceRequestDetails_colObj = new List<RepositoryColumn>();repositoryRowObj= new RepositoryRow();//var myByte = (byte)rowData.Value.RwSt;//repositoryRowObj.RowState=(RepositoryRowState)myByte;

if(rows.ContainsKey("04D90722-37D7-40B0-96B6-D6CA55ABA8F2"))     elementData = rows["04D90722-37D7-40B0-96B6-D6CA55ABA8F2"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ExpenseDetails",false,false,9);
if(repositoryColumnObj!=null)ProjectAdvanceRequestDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MGA_DetailsofExpenses not found");}

if(rows.ContainsKey("B1EB21F5-30E2-4DB3-B72E-E6BB3E4A1D2B"))     elementData = rows["B1EB21F5-30E2-4DB3-B72E-E6BB3E4A1D2B"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ItemDescription",false,false,9);
if(repositoryColumnObj!=null)ProjectAdvanceRequestDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MGA_Description not found");}

if(rows.ContainsKey("8E8892C8-B328-42D2-A630-B8A2C3C4D26B"))     elementData = rows["8E8892C8-B328-42D2-A630-B8A2C3C4D26B"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Amount",false,false,3);
if(repositoryColumnObj!=null)ProjectAdvanceRequestDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MGA_Amount not found");}

if(rows.ContainsKey("67C65E87-8293-495E-97A2-E7431BF75D69"))     elementData = rows["67C65E87-8293-495E-97A2-E7431BF75D69"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"RequestDetailsId",true,false,9);
if(repositoryColumnObj!=null)ProjectAdvanceRequestDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MGA_RequestDetailsId not found");}

if(rows.ContainsKey("6E5FD9F2-E29C-4922-B6C5-78C591A395A6"))     elementData = rows["6E5FD9F2-E29C-4922-B6C5-78C591A395A6"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"AdvanceFormId",false,false,9);
if(repositoryColumnObj!=null)ProjectAdvanceRequestDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MGA_AdvanceFormId not found");}
repositoryRowObj.Columns=ProjectAdvanceRequestDetails_colObj;
ProjectAdvanceDetailsREPO3_ProjectAdvanceRequestDetails_rowsObj.Add(repositoryRowObj);
}}

ProjectAdvanceRequestDetailsProjectAdvanceDetailsREPO3tableObj.Rows=ProjectAdvanceDetailsREPO3_ProjectAdvanceRequestDetails_rowsObj;
var ProjectAdvanceDetailsREPO3_repoObj_status_ProjectAdvanceRequestDetails = ProjectAdvanceDetailsREPO3_repoObj.Execute(DomainOperationTypes.CreateOrUpdate,ref ProjectAdvanceRequestDetailsProjectAdvanceDetailsREPO3tableObj);if(!ProjectAdvanceDetailsREPO3_repoObj_status_ProjectAdvanceRequestDetails) throw new Exception("Error in Execute Domain Data Map");}
base.WriteDebugInfo(@"Exiting DomainDataMap for Project Advance Details REPO 3");
}
if(ISpace["M_IsflowReturned"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""M_IsflowReturned""].Value==1)");
ISpace["AssignToUser"].Value=ISpace["M_InitiatorUserMapId"].Value;
base.WriteDebugInfo(@"ISpace[""AssignToUser""].Value=ISpace[""M_InitiatorUserMapId""].Value;");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["AssignToUser"].Value="";
base.WriteDebugInfo(@"ISpace[""AssignToUser""].Value="""";");
}
base.WriteDebugInfo(@"#ReimbursementFundDetails[Rows]");
iSpace.GetLoopExpressionData("ReimbursementFundDetails",ref ISpace);

foreach(var gridChild in ISpace["ReimbursementFundDetails"].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 


if(
ISpace["M_IsflowReturned"].Value==1)
{
base.WriteDebugInfo(@"
if(
ISpace[""M_IsflowReturned""].Value==1)");
base.WriteDebugInfo(@"EXEC [UpsertProjectBudgetDetails] 6,"#MG_P3_ProjectDetailsId","","#MG_P3_Amount","#MG_P3_BudgetHeadId",1,"#MG_P3_FundTypeId"");

var querySource318EAB61FF354EB2A293264135B2F298 =GetQueryExpressionDataSource("318EAB61-FF35-4EB2-A293-264135B2F298");
Dictionary<short,object> result318EAB61FF354EB2A293264135B2F298=iSpace.ExecuteQuery(querySource318EAB61FF354EB2A293264135B2F298,@"EXEC [UpsertProjectBudgetDetails] 6,"" + ISpace["MG_P3_ProjectDetailsId"].Value + @"","","" + ISpace["MG_P3_Amount"].Value + @"","" + ISpace["MG_P3_BudgetHeadId"].Value + @"",1,"" + ISpace["MG_P3_FundTypeId"].Value + @""",false);

base.WriteDebugInfo(@"var querySource318EAB61FF354EB2A293264135B2F298 =GetQueryExpressionDataSource(""318EAB61-FF35-4EB2-A293-264135B2F298"");Dictionary<short,object> result318EAB61FF354EB2A293264135B2F298=iSpace.ExecuteQuery(querySource318EAB61FF354EB2A293264135B2F298,@""EXEC [UpsertProjectBudgetDetails] 6,"""" + ISpace[""MG_P3_ProjectDetailsId""].Value + @"""","""","""" + ISpace[""MG_P3_Amount""].Value + @"""","""" + ISpace[""MG_P3_BudgetHeadId""].Value + @"""",1,"""" + ISpace[""MG_P3_FundTypeId""].Value + @"""""",false);");
base.WriteDebugInfo(@"");

if((result318EAB61FF354EB2A293264135B2F298!=null) && (result318EAB61FF354EB2A293264135B2F298.Count!=0))
{
if(result318EAB61FF354EB2A293264135B2F298.ContainsKey(0))
ISpace["M_UpdateCount"].Value = result318EAB61FF354EB2A293264135B2F298[0];
}
else{
ISpace["M_UpdateCount"].Value = null;
}
}
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("ReimbursementFundDetails","00D69CC2-E6EC-4412-B2A9-14E57A96FB5C",_objectFactory.GetGridRPP("ReimbursementFundDetails"),_elementBase.GetGridLoopQuery("00D69CC2-E6EC-4412-B2A9-14E57A96FB5C","ReimbursementFundDetails",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""ReimbursementFundDetails"",ref ISpace);

foreach(var gridChild in ISpace[""ReimbursementFundDetails""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["M_MoveTo"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""M_MoveTo""].Value=="""")");
ISpace["Message"].Value=@"Move To should be mandatory";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Move To should be mandatory"";");
return;
base.WriteDebugInfo(@"return;");
}
}
if(ISpace["M_SaveDomainData"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""M_SaveDomainData""].Value==1)");
ISpace["M_Status"].Value="Approved";
base.WriteDebugInfo(@"ISpace[""M_Status""].Value=""Approved"";");
}
if(ISpace["M_IsCancelReject"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""M_IsCancelReject""].Value==1)");
ISpace["M_Status"].Value="Dropped";
base.WriteDebugInfo(@"ISpace[""M_Status""].Value=""Dropped"";");
}
base.WriteDebugInfo(@"Entering DomainDataMap for User Request For other steps");
var UserRequestForothersteps_repoObj = new RepositoryMapper(DbTypes.SQLServer);


var UserRequestsUserRequestForotherstepstableObj = new RepositoryTable("UserRequests");
  UserRequestsUserRequestForotherstepstableObj.AppConnectionSettingsId  ="9ADED37B-CD11-426B-AF16-DEAC75685EF5";UserRequestsUserRequestForotherstepstableObj.ProofConnectionId = "C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0)";
var UserRequestForothersteps_UserRequests_rows = GetElementClientData(ISpace["InstanceId"].Value,"6B463D69-64AB-468E-B2E3-DB12E6B90014");

if(UserRequestForothersteps_UserRequests_rows!=null && UserRequestForothersteps_UserRequests_rows.Count>0){
var UserRequestForothersteps_UserRequests_rowsObj = new List<RepositoryRow>();
foreach(var rows in UserRequestForothersteps_UserRequests_rows){RepositoryRow repositoryRowObj = null;string elementData = null;RepositoryColumn repositoryColumnObj = null;if(rows !=null){ var UserRequests_colObj = new List<RepositoryColumn>();repositoryRowObj= new RepositoryRow();//var myByte = (byte)rowData.Value.RwSt;//repositoryRowObj.RowState=(RepositoryRowState)myByte;

if(rows.ContainsKey("34CFB4AA-E9A1-4EAC-83A8-AEC1C4038EE1"))     elementData = rows["34CFB4AA-E9A1-4EAC-83A8-AEC1C4038EE1"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"CurrentLevel",false,false,9);
if(repositoryColumnObj!=null)UserRequests_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-M_NextStage not found");}

if(rows.ContainsKey("B89FF303-5A1C-4060-BAB9-E6F52A11D9FD"))     elementData = rows["B89FF303-5A1C-4060-BAB9-E6F52A11D9FD"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"CurrentStatus",false,false,9);
if(repositoryColumnObj!=null)UserRequests_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-M_Status not found");}

elementData = ISpace["gv_UserId"].Value != null? Convert.ToString(ISpace["gv_UserId"].Value):null ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"LastModifiedByUserID",false,false,5);
if(repositoryColumnObj!=null)UserRequests_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-gv_UserId not found");}

if(rows.ContainsKey("0CDC8D38-F4F4-4C60-BCED-E9F0C8B165B8"))     elementData = rows["0CDC8D38-F4F4-4C60-BCED-E9F0C8B165B8"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"CurrentActivityMapID",false,false,9);
if(repositoryColumnObj!=null)UserRequests_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-SetDestinationTo not found");}

if(rows.ContainsKey("D7BB255E-9A01-4B5B-AE06-CC4D6E088D52"))     elementData = rows["D7BB255E-9A01-4B5B-AE06-CC4D6E088D52"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"InstanceID",true,false,9);
if(repositoryColumnObj!=null)UserRequests_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-M_InstanceId not found");}

elementData = CurrentDate().ToString() ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"LastModifiedOn",false,false,8);
if(repositoryColumnObj!=null)UserRequests_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-CurrentDate not found");}
repositoryRowObj.Columns=UserRequests_colObj;
UserRequestForothersteps_UserRequests_rowsObj.Add(repositoryRowObj);
}}

UserRequestsUserRequestForotherstepstableObj.Rows=UserRequestForothersteps_UserRequests_rowsObj;
var UserRequestForothersteps_repoObj_status_UserRequests = UserRequestForothersteps_repoObj.Execute(DomainOperationTypes.Update,ref UserRequestsUserRequestForotherstepstableObj);if(!UserRequestForothersteps_repoObj_status_UserRequests) throw new Exception("Error in Execute Domain Data Map");}
base.WriteDebugInfo(@"Exiting DomainDataMap for User Request For other steps");
ISpace["Message"].Value=@"Submitted Successfully";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Submitted Successfully"";");
ISpace.ExecuteInstanceCommand("Submit");
base.WriteDebugInfo(@"ISpace.ExecuteInstanceCommand(""Submit"");");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_save_reimbursementbilldetails (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Save_ReimbursementBillDetails-OnClick");
if(ISpace["growid"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""growid""].Value=="""")");

var querySource588878D7B7824F24BAF7A4FE902E4A93 =GetQueryExpressionDataSource("588878D7-B782-4F24-BAF7-A4FE902E4A93");

DataTable result588878D7B7824F24BAF7A4FE902E4A93=iSpace.SetGridDataSource(querySource588878D7B7824F24BAF7A4FE902E4A93, _objectFactory.GetGridRPP("ReimbursementBillDetails"),@"EXEC AddFormGridDataC9ACCA847AF347E79133D777BE46A656 "" + ISpace["gv_instanceid"].Value + @"","" + ISpace["gv_processmapid"].Value + @"","C9ACCA84-7AF3-47E7-9133-D777BE46A656","" + ISpace["gv_activitymapid"].Value + @"","" + ISpace["MFG_P2_ReimbursementDetailsId"].Value + @"","" + ISpace["MFG_P2_ReimbursementId"].Value + @"","" + ISpace["MFG_P2_BillNo"].Value + @"","" + ISpace["MFG_P2_BillDate"].Value + @""," + ISpace["MFG_P2_BillDocument"].Value + @","" + ISpace["MFG_P2_ItemDescription"].Value + @""," + ISpace["MFG_P2_Amount"].Value + @","" + ISpace["growid"].Value + @""");

iSpace.InsertGridBindDetails("ReimbursementBillDetails","11",querySource588878D7B7824F24BAF7A4FE902E4A93,"EXEC AddFormGridDataC9ACCA847AF347E79133D777BE46A656 "" + ISpace["gv_instanceid"].Value + @"","" + ISpace["gv_processmapid"].Value + @"","C9ACCA84-7AF3-47E7-9133-D777BE46A656","" + ISpace["gv_activitymapid"].Value + @"","" + ISpace["MFG_P2_ReimbursementDetailsId"].Value + @"","" + ISpace["MFG_P2_ReimbursementId"].Value + @"","" + ISpace["MFG_P2_BillNo"].Value + @"","" + ISpace["MFG_P2_BillDate"].Value + @""," + ISpace["MFG_P2_BillDocument"].Value + @","" + ISpace["MFG_P2_ItemDescription"].Value + @""," + ISpace["MFG_P2_Amount"].Value + @","" + ISpace["growid"].Value + @""",_objectFactory.GetGridRPP("ReimbursementBillDetails"));

base.WriteDebugInfo(@"var querySource588878D7B7824F24BAF7A4FE902E4A93 =GetQueryExpressionDataSource(""588878D7-B782-4F24-BAF7-A4FE902E4A93"");DataTable result588878D7B7824F24BAF7A4FE902E4A93=iSpace.SetGridDataSource(querySource588878D7B7824F24BAF7A4FE902E4A93, _objectFactory.GetGridRPP(""ReimbursementBillDetails""),@""EXEC AddFormGridDataC9ACCA847AF347E79133D777BE46A656 """" + ISpace[""gv_instanceid""].Value + @"""","""" + ISpace[""gv_processmapid""].Value + @"""",""C9ACCA84-7AF3-47E7-9133-D777BE46A656"","""" + ISpace[""gv_activitymapid""].Value + @"""","""" + ISpace[""MFG_P2_ReimbursementDetailsId""].Value + @"""","""" + ISpace[""MFG_P2_ReimbursementId""].Value + @"""","""" + ISpace[""MFG_P2_BillNo""].Value + @"""","""" + ISpace[""MFG_P2_BillDate""].Value + @"""","" + ISpace[""MFG_P2_BillDocument""].Value + @"","""" + ISpace[""MFG_P2_ItemDescription""].Value + @"""","" + ISpace[""MFG_P2_Amount""].Value + @"","""" + ISpace[""growid""].Value + @"""""");iSpace.InsertGridBindDetails(""ReimbursementBillDetails"",""11"",querySource588878D7B7824F24BAF7A4FE902E4A93,""EXEC AddFormGridDataC9ACCA847AF347E79133D777BE46A656 """" + ISpace[""gv_instanceid""].Value + @"""","""" + ISpace[""gv_processmapid""].Value + @"""",""C9ACCA84-7AF3-47E7-9133-D777BE46A656"","""" + ISpace[""gv_activitymapid""].Value + @"""","""" + ISpace[""MFG_P2_ReimbursementDetailsId""].Value + @"""","""" + ISpace[""MFG_P2_ReimbursementId""].Value + @"""","""" + ISpace[""MFG_P2_BillNo""].Value + @"""","""" + ISpace[""MFG_P2_BillDate""].Value + @"""","" + ISpace[""MFG_P2_BillDocument""].Value + @"","""" + ISpace[""MFG_P2_ItemDescription""].Value + @"""","" + ISpace[""MFG_P2_Amount""].Value + @"","""" + ISpace[""growid""].Value + @"""""",_objectFactory.GetGridRPP(""ReimbursementBillDetails""));");
base.WriteDebugInfo(@"EXEC AddFormGridDataC9ACCA847AF347E79133D777BE46A656 "@@gv_InstanceId","@@gv_ProcessMapId","C9ACCA84-7AF3-47E7-9133-D777BE46A656","@@gv_ActivityMapId","#MFG_P2_ReimbursementDetailsId","#MFG_P2_ReimbursementId","#MFG_P2_BillNo","#MFG_P2_BillDate",#MFG_P2_BillDocument,"#MFG_P2_ItemDescription",#MFG_P2_Amount,"#growid"");


List<Triplet<string, short, short?>> resultAB481A6E87354F09AD1BC0BBEFC0AD56=acdataIspace99884CE250CB494DB49B5828617FE860.GetQueryExpressionBindings("AB481A6E-8735-4F09-AD1B-C0BBEFC0AD56");
iSpace.SetGridData(result588878D7B7824F24BAF7A4FE902E4A93,resultAB481A6E87354F09AD1BC0BBEFC0AD56,"ReimbursementBillDetails",ref ISpace);
iSpace.UpdateGridBindDetails("ReimbursementBillDetails",resultAB481A6E87354F09AD1BC0BBEFC0AD56);
}
else
{
base.WriteDebugInfo(@"else");

var querySourceF3514DB4690A4BE6A6A77FA3D37E5B7C =GetQueryExpressionDataSource("F3514DB4-690A-4BE6-A6A7-7FA3D37E5B7C");

DataTable resultF3514DB4690A4BE6A6A77FA3D37E5B7C=iSpace.SetGridDataSource(querySourceF3514DB4690A4BE6A6A77FA3D37E5B7C, _objectFactory.GetGridRPP("ReimbursementBillDetails"),@"EXEC UpdateFormGridDataC9ACCA847AF347E79133D777BE46A656 "" + ISpace["gv_instanceid"].Value + @"","" + ISpace["gv_processmapid"].Value + @"","C9ACCA84-7AF3-47E7-9133-D777BE46A656","" + ISpace["gv_activitymapid"].Value + @"","" + ISpace["MFG_P2_ReimbursementDetailsId"].Value + @"","" + ISpace["MFG_P2_ReimbursementId"].Value + @"","" + ISpace["MFG_P2_BillNo"].Value + @"","" + ISpace["MFG_P2_BillDate"].Value + @""," + ISpace["MFG_P2_BillDocument"].Value + @","" + ISpace["MFG_P2_ItemDescription"].Value + @""," + ISpace["MFG_P2_Amount"].Value + @","" + ISpace["growid"].Value + @""");

iSpace.InsertGridBindDetails("ReimbursementBillDetails","11",querySourceF3514DB4690A4BE6A6A77FA3D37E5B7C,"EXEC UpdateFormGridDataC9ACCA847AF347E79133D777BE46A656 "" + ISpace["gv_instanceid"].Value + @"","" + ISpace["gv_processmapid"].Value + @"","C9ACCA84-7AF3-47E7-9133-D777BE46A656","" + ISpace["gv_activitymapid"].Value + @"","" + ISpace["MFG_P2_ReimbursementDetailsId"].Value + @"","" + ISpace["MFG_P2_ReimbursementId"].Value + @"","" + ISpace["MFG_P2_BillNo"].Value + @"","" + ISpace["MFG_P2_BillDate"].Value + @""," + ISpace["MFG_P2_BillDocument"].Value + @","" + ISpace["MFG_P2_ItemDescription"].Value + @""," + ISpace["MFG_P2_Amount"].Value + @","" + ISpace["growid"].Value + @""",_objectFactory.GetGridRPP("ReimbursementBillDetails"));

base.WriteDebugInfo(@"var querySourceF3514DB4690A4BE6A6A77FA3D37E5B7C =GetQueryExpressionDataSource(""F3514DB4-690A-4BE6-A6A7-7FA3D37E5B7C"");DataTable resultF3514DB4690A4BE6A6A77FA3D37E5B7C=iSpace.SetGridDataSource(querySourceF3514DB4690A4BE6A6A77FA3D37E5B7C, _objectFactory.GetGridRPP(""ReimbursementBillDetails""),@""EXEC UpdateFormGridDataC9ACCA847AF347E79133D777BE46A656 """" + ISpace[""gv_instanceid""].Value + @"""","""" + ISpace[""gv_processmapid""].Value + @"""",""C9ACCA84-7AF3-47E7-9133-D777BE46A656"","""" + ISpace[""gv_activitymapid""].Value + @"""","""" + ISpace[""MFG_P2_ReimbursementDetailsId""].Value + @"""","""" + ISpace[""MFG_P2_ReimbursementId""].Value + @"""","""" + ISpace[""MFG_P2_BillNo""].Value + @"""","""" + ISpace[""MFG_P2_BillDate""].Value + @"""","" + ISpace[""MFG_P2_BillDocument""].Value + @"","""" + ISpace[""MFG_P2_ItemDescription""].Value + @"""","" + ISpace[""MFG_P2_Amount""].Value + @"","""" + ISpace[""growid""].Value + @"""""");iSpace.InsertGridBindDetails(""ReimbursementBillDetails"",""11"",querySourceF3514DB4690A4BE6A6A77FA3D37E5B7C,""EXEC UpdateFormGridDataC9ACCA847AF347E79133D777BE46A656 """" + ISpace[""gv_instanceid""].Value + @"""","""" + ISpace[""gv_processmapid""].Value + @"""",""C9ACCA84-7AF3-47E7-9133-D777BE46A656"","""" + ISpace[""gv_activitymapid""].Value + @"""","""" + ISpace[""MFG_P2_ReimbursementDetailsId""].Value + @"""","""" + ISpace[""MFG_P2_ReimbursementId""].Value + @"""","""" + ISpace[""MFG_P2_BillNo""].Value + @"""","""" + ISpace[""MFG_P2_BillDate""].Value + @"""","" + ISpace[""MFG_P2_BillDocument""].Value + @"","""" + ISpace[""MFG_P2_ItemDescription""].Value + @"""","" + ISpace[""MFG_P2_Amount""].Value + @"","""" + ISpace[""growid""].Value + @"""""",_objectFactory.GetGridRPP(""ReimbursementBillDetails""));");
base.WriteDebugInfo(@"EXEC UpdateFormGridDataC9ACCA847AF347E79133D777BE46A656 "@@gv_InstanceId","@@gv_ProcessMapId","C9ACCA84-7AF3-47E7-9133-D777BE46A656","@@gv_ActivityMapId","#MFG_P2_ReimbursementDetailsId","#MFG_P2_ReimbursementId","#MFG_P2_BillNo","#MFG_P2_BillDate",#MFG_P2_BillDocument,"#MFG_P2_ItemDescription",#MFG_P2_Amount,"#growid"");


List<Triplet<string, short, short?>> result51CA1824668943C9A9D9B360B3E6BBB8=acdataIspace99884CE250CB494DB49B5828617FE860.GetQueryExpressionBindings("51CA1824-6689-43C9-A9D9-B360B3E6BBB8");
iSpace.SetGridData(resultF3514DB4690A4BE6A6A77FA3D37E5B7C,result51CA1824668943C9A9D9B360B3E6BBB8,"ReimbursementBillDetails",ref ISpace);
iSpace.UpdateGridBindDetails("ReimbursementBillDetails",result51CA1824668943C9A9D9B360B3E6BBB8);
}
ISpace["growid"].Value="";
base.WriteDebugInfo(@"ISpace[""growid""].Value="""";");
ISpace["MFG_P2_ReimbursementDetailsId"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_P2_ReimbursementDetailsId""].Value="""";");
ISpace["MFG_P2_ReimbursementId"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_P2_ReimbursementId""].Value="""";");
ISpace["MFG_P2_BillNo"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_P2_BillNo""].Value="""";");
ISpace["MFG_P2_BillDate"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_P2_BillDate""].Value="""";");
ISpace["MFG_P2_BillDocument"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_P2_BillDocument""].Value="""";");
ISpace["MFG_P2_ItemDescription"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_P2_ItemDescription""].Value="""";");
ISpace["MFG_P2_Amount"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_P2_Amount""].Value="""";");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_edit_reimbursementfunddetails (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Edit_ReimbursementFundDetails-OnClick");
ISpace["growid"].Value=ISpace["ReimbursementFundDetails_RowId"].Value;
base.WriteDebugInfo(@"ISpace[""growid""].Value=ISpace[""ReimbursementFundDetails_RowId""].Value;");
base.WriteDebugInfo(@"EXEC  [LoadFormGridData1112A274004543D393C5205DAEFEA917]  "@@gv_InstanceId","@@gv_ProcessMapId","1112A274-0045-43D3-93C5-205DAEFEA917","@@gv_ActivityMapId","#growid"");

var querySource457B75FDB3F34EB787EB96D92F86F9EB =GetQueryExpressionDataSource("457B75FD-B3F3-4EB7-87EB-96D92F86F9EB");
Dictionary<short,object> result457B75FDB3F34EB787EB96D92F86F9EB=iSpace.ExecuteQuery(querySource457B75FDB3F34EB787EB96D92F86F9EB,@"EXEC[LoadFormGridData1112A274004543D393C5205DAEFEA917]"" + ISpace["gv_instanceid"].Value + @"","" + ISpace["gv_processmapid"].Value + @"","1112A274-0045-43D3-93C5-205DAEFEA917","" + ISpace["gv_activitymapid"].Value + @"","" + ISpace["growid"].Value + @""",false);

base.WriteDebugInfo(@"var querySource457B75FDB3F34EB787EB96D92F86F9EB =GetQueryExpressionDataSource(""457B75FD-B3F3-4EB7-87EB-96D92F86F9EB"");Dictionary<short,object> result457B75FDB3F34EB787EB96D92F86F9EB=iSpace.ExecuteQuery(querySource457B75FDB3F34EB787EB96D92F86F9EB,@""EXEC[LoadFormGridData1112A274004543D393C5205DAEFEA917]"""" + ISpace[""gv_instanceid""].Value + @"""","""" + ISpace[""gv_processmapid""].Value + @"""",""1112A274-0045-43D3-93C5-205DAEFEA917"","""" + ISpace[""gv_activitymapid""].Value + @"""","""" + ISpace[""growid""].Value + @"""""",false);");
base.WriteDebugInfo(@"EXEC LoadFormGridDataD85301F7BAF94BE8A2B174E5CBB3D054 "@@gv_InstanceId","@@gv_ProcessMapId","D85301F7-BAF9-4BE8-A2B1-74E5CBB3D054","@@gv_ActivityMapId","#growid"");

if((result457B75FDB3F34EB787EB96D92F86F9EB!=null) && (result457B75FDB3F34EB787EB96D92F86F9EB.Count!=0))
{
if(result457B75FDB3F34EB787EB96D92F86F9EB.ContainsKey(2))
ISpace["MFG_P3_FundTypeId"].Value = result457B75FDB3F34EB787EB96D92F86F9EB[2];
if(result457B75FDB3F34EB787EB96D92F86F9EB.ContainsKey(3))
ISpace["MFG_P3_ProjectDetailsId"].Value = result457B75FDB3F34EB787EB96D92F86F9EB[3];
if(result457B75FDB3F34EB787EB96D92F86F9EB.ContainsKey(4))
ISpace["MFG_P3_BudgetHeadId"].Value = result457B75FDB3F34EB787EB96D92F86F9EB[4];
if(result457B75FDB3F34EB787EB96D92F86F9EB.ContainsKey(5))
ISpace["MFG_P3_Amount"].Value = result457B75FDB3F34EB787EB96D92F86F9EB[5];
if(result457B75FDB3F34EB787EB96D92F86F9EB.ContainsKey(0))
ISpace["MFG_P3_FundDetailsId"].Value = result457B75FDB3F34EB787EB96D92F86F9EB[0];
if(result457B75FDB3F34EB787EB96D92F86F9EB.ContainsKey(1))
ISpace["MFG_P3_ReimbursementId"].Value = result457B75FDB3F34EB787EB96D92F86F9EB[1];
}
else{
ISpace["MFG_P3_FundTypeId"].Value = null;ISpace["MFG_P3_ProjectDetailsId"].Value = null;ISpace["MFG_P3_BudgetHeadId"].Value = null;ISpace["MFG_P3_Amount"].Value = null;ISpace["MFG_P3_FundDetailsId"].Value = null;ISpace["MFG_P3_ReimbursementId"].Value = null;
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_m_moveto (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"M_MoveTo-OnChange");
ISpace["M_MoveToValue"].Value=ISpace["M_MoveTo"].Value;
base.WriteDebugInfo(@"ISpace[""M_MoveToValue""].Value=ISpace[""M_MoveTo""].Value;");
base.WriteDebugInfo(@"Exec GetStageStatus 1,"","","#M_MoveToValue","#M_SourceActivityMapId"");

var querySource549686A138974AFCA19EC95972C37210 =GetQueryExpressionDataSource("549686A1-3897-4AFC-A19E-C95972C37210");
Dictionary<short,object> result549686A138974AFCA19EC95972C37210=iSpace.ExecuteQuery(querySource549686A138974AFCA19EC95972C37210,@"Exec GetStageStatus 1,"","","" + ISpace["M_MoveToValue"].Value + @"","" + ISpace["M_SourceActivityMapId"].Value + @""",false);

base.WriteDebugInfo(@"var querySource549686A138974AFCA19EC95972C37210 =GetQueryExpressionDataSource(""549686A1-3897-4AFC-A19E-C95972C37210"");Dictionary<short,object> result549686A138974AFCA19EC95972C37210=iSpace.ExecuteQuery(querySource549686A138974AFCA19EC95972C37210,@""Exec GetStageStatus 1,"""","""","""" + ISpace[""M_MoveToValue""].Value + @"""","""" + ISpace[""M_SourceActivityMapId""].Value + @"""""",false);");
base.WriteDebugInfo(@"");

if((result549686A138974AFCA19EC95972C37210!=null) && (result549686A138974AFCA19EC95972C37210.Count!=0))
{
if(result549686A138974AFCA19EC95972C37210.ContainsKey(3))
ISpace["M_SaveDomainData"].Value = result549686A138974AFCA19EC95972C37210[3];
if(result549686A138974AFCA19EC95972C37210.ContainsKey(1))
ISpace["M_RemarksMandatory"].Value = result549686A138974AFCA19EC95972C37210[1];
if(result549686A138974AFCA19EC95972C37210.ContainsKey(4))
ISpace["M_FieldMandatory"].Value = result549686A138974AFCA19EC95972C37210[4];
if(result549686A138974AFCA19EC95972C37210.ContainsKey(2))
ISpace["MF_P1_Remarks"].Value = result549686A138974AFCA19EC95972C37210[2];
if(result549686A138974AFCA19EC95972C37210.ContainsKey(0))
ISpace["M_NextStage"].Value = result549686A138974AFCA19EC95972C37210[0];
}
else{
ISpace["M_SaveDomainData"].Value = null;ISpace["M_RemarksMandatory"].Value = null;ISpace["M_FieldMandatory"].Value = null;ISpace["MF_P1_Remarks"].Value = null;ISpace["M_NextStage"].Value = null;
}
ISpace["SetDestinationTo"].Value=ISpace["M_MoveTo"].Value;
base.WriteDebugInfo(@"ISpace[""SetDestinationTo""].Value=ISpace[""M_MoveTo""].Value;");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_edit_reimbursementbilldetails (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Edit_ReimbursementBillDetails-OnClick");
base.WriteDebugInfo(@"EXEC LoadFormGridDataC9ACCA847AF347E79133D777BE46A656 "@@gv_InstanceId","@@gv_ProcessMapId","C9ACCA84-7AF3-47E7-9133-D777BE46A656","@@gv_ActivityMapId","#growid"");

var querySourceE12571F81F5945ED9BC6BAF0AA62F4F0 =GetQueryExpressionDataSource("E12571F8-1F59-45ED-9BC6-BAF0AA62F4F0");
Dictionary<short,object> resultE12571F81F5945ED9BC6BAF0AA62F4F0=iSpace.ExecuteQuery(querySourceE12571F81F5945ED9BC6BAF0AA62F4F0,@"EXEC LoadFormGridDataC9ACCA847AF347E79133D777BE46A656 "" + ISpace["gv_instanceid"].Value + @"","" + ISpace["gv_processmapid"].Value + @"","C9ACCA84-7AF3-47E7-9133-D777BE46A656","" + ISpace["gv_activitymapid"].Value + @"","" + ISpace["growid"].Value + @""",false);

base.WriteDebugInfo(@"var querySourceE12571F81F5945ED9BC6BAF0AA62F4F0 =GetQueryExpressionDataSource(""E12571F8-1F59-45ED-9BC6-BAF0AA62F4F0"");Dictionary<short,object> resultE12571F81F5945ED9BC6BAF0AA62F4F0=iSpace.ExecuteQuery(querySourceE12571F81F5945ED9BC6BAF0AA62F4F0,@""EXEC LoadFormGridDataC9ACCA847AF347E79133D777BE46A656 """" + ISpace[""gv_instanceid""].Value + @"""","""" + ISpace[""gv_processmapid""].Value + @"""",""C9ACCA84-7AF3-47E7-9133-D777BE46A656"","""" + ISpace[""gv_activitymapid""].Value + @"""","""" + ISpace[""growid""].Value + @"""""",false);");
base.WriteDebugInfo(@"EXEC LoadFormGridDataC9ACCA847AF347E79133D777BE46A656 "@@gv_InstanceId","@@gv_ProcessMapId","C9ACCA84-7AF3-47E7-9133-D777BE46A656","@@gv_ActivityMapId","#growid"");

if((resultE12571F81F5945ED9BC6BAF0AA62F4F0!=null) && (resultE12571F81F5945ED9BC6BAF0AA62F4F0.Count!=0))
{
if(resultE12571F81F5945ED9BC6BAF0AA62F4F0.ContainsKey(3))
ISpace["MFG_P2_BillDate"].Value = resultE12571F81F5945ED9BC6BAF0AA62F4F0[3];
if(resultE12571F81F5945ED9BC6BAF0AA62F4F0.ContainsKey(4))
ISpace["MFG_P2_BillDocument"].Value = resultE12571F81F5945ED9BC6BAF0AA62F4F0[4];
if(resultE12571F81F5945ED9BC6BAF0AA62F4F0.ContainsKey(6))
ISpace["MFG_P2_Amount"].Value = resultE12571F81F5945ED9BC6BAF0AA62F4F0[6];
if(resultE12571F81F5945ED9BC6BAF0AA62F4F0.ContainsKey(5))
ISpace["MFG_P2_ItemDescription"].Value = resultE12571F81F5945ED9BC6BAF0AA62F4F0[5];
if(resultE12571F81F5945ED9BC6BAF0AA62F4F0.ContainsKey(0))
ISpace["MFG_P2_ReimbursementDetailsId"].Value = resultE12571F81F5945ED9BC6BAF0AA62F4F0[0];
if(resultE12571F81F5945ED9BC6BAF0AA62F4F0.ContainsKey(1))
ISpace["MFG_P2_ReimbursementId"].Value = resultE12571F81F5945ED9BC6BAF0AA62F4F0[1];
if(resultE12571F81F5945ED9BC6BAF0AA62F4F0.ContainsKey(2))
ISpace["MFG_P2_BillNo"].Value = resultE12571F81F5945ED9BC6BAF0AA62F4F0[2];
}
else{
ISpace["MFG_P2_BillDate"].Value = null;ISpace["MFG_P2_BillDocument"].Value = null;ISpace["MFG_P2_Amount"].Value = null;ISpace["MFG_P2_ItemDescription"].Value = null;ISpace["MFG_P2_ReimbursementDetailsId"].Value = null;ISpace["MFG_P2_ReimbursementId"].Value = null;ISpace["MFG_P2_BillNo"].Value = null;
}
ISpace["growid"].Value=ISpace["ReimbursementBillDetails_RowId"].Value;
base.WriteDebugInfo(@"ISpace[""growid""].Value=ISpace[""ReimbursementBillDetails_RowId""].Value;");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_save_reimbursementfunddetails (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Save_ReimbursementFundDetails-OnClick");
if(ISpace["MFG_P3_FundTypeId"].Value=="1")
{
base.WriteDebugInfo(@"if(ISpace[""MFG_P3_FundTypeId""].Value==""1"")");
base.WriteDebugInfo(@"#ReimbursementFundDetails[Rows]");
iSpace.GetLoopExpressionData("ReimbursementFundDetails",ref ISpace);

foreach(var gridChild in ISpace["ReimbursementFundDetails"].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 


if(


ISpace["growid"].Value!=ISpace["ReimbursementFundDetails_RowId"].Value||ISpace["growid"].Value=="")
{
base.WriteDebugInfo(@"
if(


ISpace[""growid""].Value!=ISpace[""ReimbursementFundDetails_RowId""].Value||ISpace[""growid""].Value=="""")");
if(ISpace["MFG_P3_BudgetHeadId"].Value==ISpace["MG_P3_BudgetHeadId"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MFG_P3_BudgetHeadId""].Value==ISpace[""MG_P3_BudgetHeadId""].Value)");
ISpace["Message"].Value=@"Budget Head is already Exists";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Budget Head is already Exists"";");
ISpace["MFG_P3_BudgetHeadId"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_P3_BudgetHeadId""].Value="""";");
return;
base.WriteDebugInfo(@"return;");
}
}
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("ReimbursementFundDetails","00D69CC2-E6EC-4412-B2A9-14E57A96FB5C",_objectFactory.GetGridRPP("ReimbursementFundDetails"),_elementBase.GetGridLoopQuery("00D69CC2-E6EC-4412-B2A9-14E57A96FB5C","ReimbursementFundDetails",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""ReimbursementFundDetails"",ref ISpace);

foreach(var gridChild in ISpace[""ReimbursementFundDetails""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
}
if(ISpace["growid"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""growid""].Value=="""")");

var querySourceC5471BC38ECA4216A66F923825C32508 =GetQueryExpressionDataSource("C5471BC3-8ECA-4216-A66F-923825C32508");

DataTable resultC5471BC38ECA4216A66F923825C32508=iSpace.SetGridDataSource(querySourceC5471BC38ECA4216A66F923825C32508, _objectFactory.GetGridRPP("ReimbursementFundDetails"),@"EXEC AddFormGridData1112A274004543D393C5205DAEFEA917 "" + ISpace["gv_instanceid"].Value + @"","" + ISpace["gv_processmapid"].Value + @"","1112A274-0045-43D3-93C5-205DAEFEA917","" + ISpace["gv_activitymapid"].Value + @"","" + ISpace["MFG_P3_FundDetailsId"].Value + @"","" + ISpace["M_Advanceformid"].Value + @"","" + ISpace["MFG_P3_FundTypeId"].Value + @"","" + ISpace["MFG_P3_ProjectDetailsId"].Value + @"","" + ISpace["MFG_P3_BudgetHeadId"].Value + @""," + ISpace["MFG_P3_Amount"].Value + @","" + ISpace["growid"].Value + @""");

iSpace.InsertGridBindDetails("ReimbursementFundDetails","11",querySourceC5471BC38ECA4216A66F923825C32508,"EXEC AddFormGridData1112A274004543D393C5205DAEFEA917 "" + ISpace["gv_instanceid"].Value + @"","" + ISpace["gv_processmapid"].Value + @"","1112A274-0045-43D3-93C5-205DAEFEA917","" + ISpace["gv_activitymapid"].Value + @"","" + ISpace["MFG_P3_FundDetailsId"].Value + @"","" + ISpace["M_Advanceformid"].Value + @"","" + ISpace["MFG_P3_FundTypeId"].Value + @"","" + ISpace["MFG_P3_ProjectDetailsId"].Value + @"","" + ISpace["MFG_P3_BudgetHeadId"].Value + @""," + ISpace["MFG_P3_Amount"].Value + @","" + ISpace["growid"].Value + @""",_objectFactory.GetGridRPP("ReimbursementFundDetails"));

base.WriteDebugInfo(@"var querySourceC5471BC38ECA4216A66F923825C32508 =GetQueryExpressionDataSource(""C5471BC3-8ECA-4216-A66F-923825C32508"");DataTable resultC5471BC38ECA4216A66F923825C32508=iSpace.SetGridDataSource(querySourceC5471BC38ECA4216A66F923825C32508, _objectFactory.GetGridRPP(""ReimbursementFundDetails""),@""EXEC AddFormGridData1112A274004543D393C5205DAEFEA917 """" + ISpace[""gv_instanceid""].Value + @"""","""" + ISpace[""gv_processmapid""].Value + @"""",""1112A274-0045-43D3-93C5-205DAEFEA917"","""" + ISpace[""gv_activitymapid""].Value + @"""","""" + ISpace[""MFG_P3_FundDetailsId""].Value + @"""","""" + ISpace[""M_Advanceformid""].Value + @"""","""" + ISpace[""MFG_P3_FundTypeId""].Value + @"""","""" + ISpace[""MFG_P3_ProjectDetailsId""].Value + @"""","""" + ISpace[""MFG_P3_BudgetHeadId""].Value + @"""","" + ISpace[""MFG_P3_Amount""].Value + @"","""" + ISpace[""growid""].Value + @"""""");iSpace.InsertGridBindDetails(""ReimbursementFundDetails"",""11"",querySourceC5471BC38ECA4216A66F923825C32508,""EXEC AddFormGridData1112A274004543D393C5205DAEFEA917 """" + ISpace[""gv_instanceid""].Value + @"""","""" + ISpace[""gv_processmapid""].Value + @"""",""1112A274-0045-43D3-93C5-205DAEFEA917"","""" + ISpace[""gv_activitymapid""].Value + @"""","""" + ISpace[""MFG_P3_FundDetailsId""].Value + @"""","""" + ISpace[""M_Advanceformid""].Value + @"""","""" + ISpace[""MFG_P3_FundTypeId""].Value + @"""","""" + ISpace[""MFG_P3_ProjectDetailsId""].Value + @"""","""" + ISpace[""MFG_P3_BudgetHeadId""].Value + @"""","" + ISpace[""MFG_P3_Amount""].Value + @"","""" + ISpace[""growid""].Value + @"""""",_objectFactory.GetGridRPP(""ReimbursementFundDetails""));");
base.WriteDebugInfo(@"EXEC AddFormGridDataD85301F7BAF94BE8A2B174E5CBB3D054 "@@gv_InstanceId","@@gv_ProcessMapId","D85301F7-BAF9-4BE8-A2B1-74E5CBB3D054","@@gv_ActivityMapId","#MFG_P3_FundDetailsId","#MFG_P3_ReimbursementId","#MFG_P3_FundTypeId","#MFG_P3_ProjectDetailsId","#MFG_P3_BudgetHeadId",#MFG_P3_Amount,"#growid"");


List<Triplet<string, short, short?>> result169C69C3949245478D79196C3E1309FB=acdataIspace99884CE250CB494DB49B5828617FE860.GetQueryExpressionBindings("169C69C3-9492-4547-8D79-196C3E1309FB");
iSpace.SetGridData(resultC5471BC38ECA4216A66F923825C32508,result169C69C3949245478D79196C3E1309FB,"ReimbursementFundDetails",ref ISpace);
iSpace.UpdateGridBindDetails("ReimbursementFundDetails",result169C69C3949245478D79196C3E1309FB);
}
else
{
base.WriteDebugInfo(@"else");

var querySourceA8D19C29F512446883DE4C86EF7F0E8F =GetQueryExpressionDataSource("A8D19C29-F512-4468-83DE-4C86EF7F0E8F");

DataTable resultA8D19C29F512446883DE4C86EF7F0E8F=iSpace.SetGridDataSource(querySourceA8D19C29F512446883DE4C86EF7F0E8F, _objectFactory.GetGridRPP("ReimbursementFundDetails"),@"EXEC UpdateFormGridData1112A274004543D393C5205DAEFEA917 "" + ISpace["gv_instanceid"].Value + @"","" + ISpace["gv_processmapid"].Value + @"","1112A274-0045-43D3-93C5-205DAEFEA917","" + ISpace["gv_activitymapid"].Value + @"","" + ISpace["MFG_P3_FundDetailsId"].Value + @"","" + ISpace["M_Advanceformid"].Value + @"","" + ISpace["MFG_P3_FundTypeId"].Value + @"","" + ISpace["MFG_P3_ProjectDetailsId"].Value + @"","" + ISpace["MFG_P3_BudgetHeadId"].Value + @""," + ISpace["MFG_P3_Amount"].Value + @","" + ISpace["growid"].Value + @""");

iSpace.InsertGridBindDetails("ReimbursementFundDetails","11",querySourceA8D19C29F512446883DE4C86EF7F0E8F,"EXEC UpdateFormGridData1112A274004543D393C5205DAEFEA917 "" + ISpace["gv_instanceid"].Value + @"","" + ISpace["gv_processmapid"].Value + @"","1112A274-0045-43D3-93C5-205DAEFEA917","" + ISpace["gv_activitymapid"].Value + @"","" + ISpace["MFG_P3_FundDetailsId"].Value + @"","" + ISpace["M_Advanceformid"].Value + @"","" + ISpace["MFG_P3_FundTypeId"].Value + @"","" + ISpace["MFG_P3_ProjectDetailsId"].Value + @"","" + ISpace["MFG_P3_BudgetHeadId"].Value + @""," + ISpace["MFG_P3_Amount"].Value + @","" + ISpace["growid"].Value + @""",_objectFactory.GetGridRPP("ReimbursementFundDetails"));

base.WriteDebugInfo(@"var querySourceA8D19C29F512446883DE4C86EF7F0E8F =GetQueryExpressionDataSource(""A8D19C29-F512-4468-83DE-4C86EF7F0E8F"");DataTable resultA8D19C29F512446883DE4C86EF7F0E8F=iSpace.SetGridDataSource(querySourceA8D19C29F512446883DE4C86EF7F0E8F, _objectFactory.GetGridRPP(""ReimbursementFundDetails""),@""EXEC UpdateFormGridData1112A274004543D393C5205DAEFEA917 """" + ISpace[""gv_instanceid""].Value + @"""","""" + ISpace[""gv_processmapid""].Value + @"""",""1112A274-0045-43D3-93C5-205DAEFEA917"","""" + ISpace[""gv_activitymapid""].Value + @"""","""" + ISpace[""MFG_P3_FundDetailsId""].Value + @"""","""" + ISpace[""M_Advanceformid""].Value + @"""","""" + ISpace[""MFG_P3_FundTypeId""].Value + @"""","""" + ISpace[""MFG_P3_ProjectDetailsId""].Value + @"""","""" + ISpace[""MFG_P3_BudgetHeadId""].Value + @"""","" + ISpace[""MFG_P3_Amount""].Value + @"","""" + ISpace[""growid""].Value + @"""""");iSpace.InsertGridBindDetails(""ReimbursementFundDetails"",""11"",querySourceA8D19C29F512446883DE4C86EF7F0E8F,""EXEC UpdateFormGridData1112A274004543D393C5205DAEFEA917 """" + ISpace[""gv_instanceid""].Value + @"""","""" + ISpace[""gv_processmapid""].Value + @"""",""1112A274-0045-43D3-93C5-205DAEFEA917"","""" + ISpace[""gv_activitymapid""].Value + @"""","""" + ISpace[""MFG_P3_FundDetailsId""].Value + @"""","""" + ISpace[""M_Advanceformid""].Value + @"""","""" + ISpace[""MFG_P3_FundTypeId""].Value + @"""","""" + ISpace[""MFG_P3_ProjectDetailsId""].Value + @"""","""" + ISpace[""MFG_P3_BudgetHeadId""].Value + @"""","" + ISpace[""MFG_P3_Amount""].Value + @"","""" + ISpace[""growid""].Value + @"""""",_objectFactory.GetGridRPP(""ReimbursementFundDetails""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> resultBDF250C27A244A8EB094E340FDE4659C=acdataIspace99884CE250CB494DB49B5828617FE860.GetQueryExpressionBindings("BDF250C2-7A24-4A8E-B094-E340FDE4659C");
iSpace.SetGridData(resultA8D19C29F512446883DE4C86EF7F0E8F,resultBDF250C27A244A8EB094E340FDE4659C,"ReimbursementFundDetails",ref ISpace);
iSpace.UpdateGridBindDetails("ReimbursementFundDetails",resultBDF250C27A244A8EB094E340FDE4659C);
}
base.WriteDebugInfo(@"#ReimbursementFundDetails[Rows]");
iSpace.GetLoopExpressionData("ReimbursementFundDetails",ref ISpace);

foreach(var gridChild in ISpace["ReimbursementFundDetails"].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 



ISpace["MG_P3_Employeebasicinfoid"].Value=ISpace["UC_EmployeeBaicInfoId"].Value;
base.WriteDebugInfo(@"

ISpace[""MG_P3_Employeebasicinfoid""].Value=ISpace[""UC_EmployeeBaicInfoId""].Value;");


ISpace["MG_P3_Packageprocessmapid"].Value=ISpace["M_PackageProcessMapId"].Value;
base.WriteDebugInfo(@"

ISpace[""MG_P3_Packageprocessmapid""].Value=ISpace[""M_PackageProcessMapId""].Value;");
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("ReimbursementFundDetails","00D69CC2-E6EC-4412-B2A9-14E57A96FB5C",_objectFactory.GetGridRPP("ReimbursementFundDetails"),_elementBase.GetGridLoopQuery("00D69CC2-E6EC-4412-B2A9-14E57A96FB5C","ReimbursementFundDetails",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""ReimbursementFundDetails"",ref ISpace);

foreach(var gridChild in ISpace[""ReimbursementFundDetails""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
object MG_P3_Amount=iSpace.Sum("[00D69CC2-E6EC-4412-B2A9-14E57A96FB5C]","MG_P3_Amount","");
ISpace["MFG_P3_OverallAmount"].Value=Convert.ChangeType(MG_P3_Amount, MG_P3_Amount.GetType());;
base.WriteDebugInfo(@"object MG_P3_Amount=iSpace.Sum(""[00D69CC2-E6EC-4412-B2A9-14E57A96FB5C]"",""MG_P3_Amount"","""");
ISpace[""MFG_P3_OverallAmount""].Value=Convert.ChangeType(MG_P3_Amount, MG_P3_Amount.GetType());;");
ISpace["growid"].Value="";
base.WriteDebugInfo(@"ISpace[""growid""].Value="""";");
ISpace["MFG_P3_FundDetailsId"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_P3_FundDetailsId""].Value="""";");
ISpace["MFG_P3_ReimbursementId"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_P3_ReimbursementId""].Value="""";");
ISpace["MFG_P3_FundTypeId"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_P3_FundTypeId""].Value="""";");
ISpace["MFG_P3_ProjectDetailsId"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_P3_ProjectDetailsId""].Value="""";");
ISpace["MFG_P3_BudgetHeadId"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_P3_BudgetHeadId""].Value="""";");
ISpace["MFG_P3_Amount"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_P3_Amount""].Value="""";");
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
		if(elementName.ToLower().Equals("m_moveto"))
    {
    			SubscribeElementEvents_m_moveto(ref dfsParam);
    }
}
	if(methodName.ToLower().Equals("onclick"))
{
		if(elementName.ToLower().Equals("submitform"))
{
			SubscribeElementEvents_submitform(ref dfsParam);
}
		if(elementName.ToLower().Equals("save_reimbursementbilldetails"))
{
			SubscribeElementEvents_save_reimbursementbilldetails(ref dfsParam);
}
		if(elementName.ToLower().Equals("edit_reimbursementfunddetails"))
{
			SubscribeElementEvents_edit_reimbursementfunddetails(ref dfsParam);
}
		if(elementName.ToLower().Equals("edit_reimbursementbilldetails"))
{
			SubscribeElementEvents_edit_reimbursementbilldetails(ref dfsParam);
}
		if(elementName.ToLower().Equals("save_reimbursementfunddetails"))
{
			SubscribeElementEvents_save_reimbursementfunddetails(ref dfsParam);
}
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
public class ISpace9FE779D2129C47A2B87D173C6AFE51CB : VirtualForm
{
IISpace iSpace = new ISpace();
AcDataISpace9FE779D2129C47A2B87D173C6AFE51CB acdataIspace9FE779D2129C47A2B87D173C6AFE51CB=new AcDataISpace9FE779D2129C47A2B87D173C6AFE51CB();
private void SubscribeFormEvents_root(ref Dictionary<string, ServiceElementData> ISpace)
{
try
{
base.WriteDebugInfo(@"Root-OnAfterFormLoad");
ISpace["M_SourceActivityMapId"].Value=ISpace["gv_activitymapid"].Value;
base.WriteDebugInfo(@"ISpace[""M_SourceActivityMapId""].Value=ISpace[""gv_activitymapid""].Value;");
ISpace["M_PackageProcessMapId"].Value=ISpace["gv_processmapid"].Value;
base.WriteDebugInfo(@"ISpace[""M_PackageProcessMapId""].Value=ISpace[""gv_processmapid""].Value;");
ISpace["M_InstanceId"].Value=ISpace["gv_instanceid"].Value;
base.WriteDebugInfo(@"ISpace[""M_InstanceId""].Value=ISpace[""gv_instanceid""].Value;");
ISpace["M_IsSourceStep"].Value=0;
base.WriteDebugInfo(@"ISpace[""M_IsSourceStep""].Value=0;");


ISpace["M_MoveTo"].Man=true;
base.WriteDebugInfo(@"ISpace[""M_MoveTo""].Man=true;");
ISpace["MF_P1_Remarks"].Value="";
base.WriteDebugInfo(@"ISpace[""MF_P1_Remarks""].Value="""";");
ISpace["M_NextStage"].Value="";
base.WriteDebugInfo(@"ISpace[""M_NextStage""].Value="""";");

var querySource8BBB2BE71E8540E59B13CC03C350EAB8 =GetQueryExpressionDataSource("8BBB2BE7-1E85-40E5-9B13-CC03C350EAB8");

DataTable result8BBB2BE71E8540E59B13CC03C350EAB8=iSpace.SetGridDataSource(querySource8BBB2BE71E8540E59B13CC03C350EAB8, _objectFactory.GetGridRPP("MG_RemarksDetails"),@"EXEC GetRemarks "" + ISpace["M_InstanceId"].Value + @""");

iSpace.InsertGridBindDetails("MG_RemarksDetails","11",querySource8BBB2BE71E8540E59B13CC03C350EAB8,"EXEC GetRemarks "" + ISpace["M_InstanceId"].Value + @""",_objectFactory.GetGridRPP("MG_RemarksDetails"));

base.WriteDebugInfo(@"var querySource8BBB2BE71E8540E59B13CC03C350EAB8 =GetQueryExpressionDataSource(""8BBB2BE7-1E85-40E5-9B13-CC03C350EAB8"");DataTable result8BBB2BE71E8540E59B13CC03C350EAB8=iSpace.SetGridDataSource(querySource8BBB2BE71E8540E59B13CC03C350EAB8, _objectFactory.GetGridRPP(""MG_RemarksDetails""),@""EXEC GetRemarks """" + ISpace[""M_InstanceId""].Value + @"""""");iSpace.InsertGridBindDetails(""MG_RemarksDetails"",""11"",querySource8BBB2BE71E8540E59B13CC03C350EAB8,""EXEC GetRemarks """" + ISpace[""M_InstanceId""].Value + @"""""",_objectFactory.GetGridRPP(""MG_RemarksDetails""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> resultCA798124C2C446CCBDA6419353320A96=acdataIspace9FE779D2129C47A2B87D173C6AFE51CB.GetQueryExpressionBindings("CA798124-C2C4-46CC-BDA6-419353320A96");
iSpace.SetGridData(result8BBB2BE71E8540E59B13CC03C350EAB8,resultCA798124C2C446CCBDA6419353320A96,"MG_RemarksDetails",ref ISpace);
iSpace.UpdateGridBindDetails("MG_RemarksDetails",resultCA798124C2C446CCBDA6419353320A96);
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["MF_P1_ApplicationStatus"].Visible="false";ISpace["MFG_P2_ReimbursementDetailsId"].Visible="false";ISpace["MF_P1_EmployeeBasicInfoId"].Visible="false";ISpace["MFG_P3_FundDetailsId"].Visible="false";ISpace["MFG_P2_BillDocument"].Visible="false";ISpace["MF_P1_UpdatedBy"].Visible="false";ISpace["MF_P1_Initiatedon"].Visible="false";ISpace["MFG_P3_ReimbursementId"].Visible="false";ISpace["MFG_P2_BillDate"].Visible="false";ISpace["MF_P1_TotalAmount"].Visible="true";ISpace["MF_P1_InitatedBy"].Visible="false";ISpace["MFG_P2_ReimbursementId"].Visible="false";ISpace["MFG_P2_BillNo"].Visible="false";ISpace["MFG_P2_Amount"].Visible="false";ISpace["MF_P1_UpdatedOn"].Visible="false";ISpace["MFG_P3_FundTypeId"].Visible="false";ISpace["MFG_P3_ProjectDetailsId"].Visible="false";ISpace["MFG_P3_Amount"].Visible="false";ISpace["MFG_P2_ItemDescription"].Visible="false";ISpace["MF_P1_ReimbursementId"].Visible="false";ISpace["MFG_P3_BudgetHeadId"].Visible="false";
base.WriteDebugInfo(@"ISpace[""MF_P1_ApplicationStatus""].Visible=""false"";ISpace[""MFG_P2_ReimbursementDetailsId""].Visible=""false"";ISpace[""MF_P1_EmployeeBasicInfoId""].Visible=""false"";ISpace[""MFG_P3_FundDetailsId""].Visible=""false"";ISpace[""MFG_P2_BillDocument""].Visible=""false"";ISpace[""MF_P1_UpdatedBy""].Visible=""false"";ISpace[""MF_P1_Initiatedon""].Visible=""false"";ISpace[""MFG_P3_ReimbursementId""].Visible=""false"";ISpace[""MFG_P2_BillDate""].Visible=""false"";ISpace[""MF_P1_TotalAmount""].Visible=""true"";ISpace[""MF_P1_InitatedBy""].Visible=""false"";ISpace[""MFG_P2_ReimbursementId""].Visible=""false"";ISpace[""MFG_P2_BillNo""].Visible=""false"";ISpace[""MFG_P2_Amount""].Visible=""false"";ISpace[""MF_P1_UpdatedOn""].Visible=""false"";ISpace[""MFG_P3_FundTypeId""].Visible=""false"";ISpace[""MFG_P3_ProjectDetailsId""].Visible=""false"";ISpace[""MFG_P3_Amount""].Visible=""false"";ISpace[""MFG_P2_ItemDescription""].Visible=""false"";ISpace[""MF_P1_ReimbursementId""].Visible=""false"";ISpace[""MFG_P3_BudgetHeadId""].Visible=""false"";");
ISpace["MG_P2_BillNo"].Visible="true";ISpace["MG_P2_BillDocument"].Visible="false";ISpace["MG_P2_ReimbursementDetailsId"].Visible="false";ISpace["MG_P2_ReimbursementId"].Visible="false";ISpace["MG_P2_ItemDescription"].Visible="true";ISpace["MG_P2_BillDate"].Visible="true";ISpace["MG_P2_Amount"].Visible="true";
base.WriteDebugInfo(@"ISpace[""MG_P2_BillNo""].Visible=""true"";ISpace[""MG_P2_BillDocument""].Visible=""false"";ISpace[""MG_P2_ReimbursementDetailsId""].Visible=""false"";ISpace[""MG_P2_ReimbursementId""].Visible=""false"";ISpace[""MG_P2_ItemDescription""].Visible=""true"";ISpace[""MG_P2_BillDate""].Visible=""true"";ISpace[""MG_P2_Amount""].Visible=""true"";");
ISpace["MG_P3_ProjectDetailsId"].Visible="true";ISpace["MG_P3_BudgetHeadId"].Visible="true";ISpace["MG_P3_FundTypeId"].Visible="true";ISpace["MG_P3_FundDetailsId"].Visible="false";ISpace["MG_P3_Amount"].Visible="true";ISpace["MG_P3_ReimbursementId"].Visible="false";
base.WriteDebugInfo(@"ISpace[""MG_P3_ProjectDetailsId""].Visible=""true"";ISpace[""MG_P3_BudgetHeadId""].Visible=""true"";ISpace[""MG_P3_FundTypeId""].Visible=""true"";ISpace[""MG_P3_FundDetailsId""].Visible=""false"";ISpace[""MG_P3_Amount""].Visible=""true"";ISpace[""MG_P3_ReimbursementId""].Visible=""false"";");
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_submitform (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"SubmitForm-OnClick");
base.WriteDebugInfo(@"Entering DomainDataMap for Remarks Domain");
var RemarksDomain_repoObj = new RepositoryMapper(DbTypes.SQLServer);


var ActivityTrailLogDetailsRemarksDomaintableObj = new RepositoryTable("ActivityTrailLogDetails");
  ActivityTrailLogDetailsRemarksDomaintableObj.AppConnectionSettingsId  ="9ADED37B-CD11-426B-AF16-DEAC75685EF5";ActivityTrailLogDetailsRemarksDomaintableObj.ProofConnectionId = "C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0)";
var RemarksDomain_ActivityTrailLogDetails_rows = GetElementClientData(ISpace["InstanceId"].Value,"6B463D69-64AB-468E-B2E3-DB12E6B90014");

if(RemarksDomain_ActivityTrailLogDetails_rows!=null && RemarksDomain_ActivityTrailLogDetails_rows.Count>0){
var RemarksDomain_ActivityTrailLogDetails_rowsObj = new List<RepositoryRow>();
foreach(var rows in RemarksDomain_ActivityTrailLogDetails_rows){RepositoryRow repositoryRowObj = null;string elementData = null;RepositoryColumn repositoryColumnObj = null;if(rows !=null){ var ActivityTrailLogDetails_colObj = new List<RepositoryColumn>();repositoryRowObj= new RepositoryRow();//var myByte = (byte)rowData.Value.RwSt;//repositoryRowObj.RowState=(RepositoryRowState)myByte;

if(rows.ContainsKey("5354760A-9EAC-491E-BAB1-C3614187A9BE"))     elementData = rows["5354760A-9EAC-491E-BAB1-C3614187A9BE"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ProcessedInProgressFlag",false,false,5);
if(repositoryColumnObj!=null)ActivityTrailLogDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-M_IsSourceStep not found");}

elementData = CurrentDate().ToString() ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Updatedon",false,false,8);
if(repositoryColumnObj!=null)ActivityTrailLogDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-CurrentDate not found");}

if(rows.ContainsKey("D7BB255E-9A01-4B5B-AE06-CC4D6E088D52"))     elementData = rows["D7BB255E-9A01-4B5B-AE06-CC4D6E088D52"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"InstanceID",false,false,9);
if(repositoryColumnObj!=null)ActivityTrailLogDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-M_InstanceId not found");}

elementData = ISpace["gv_UserId"].Value != null? Convert.ToString(ISpace["gv_UserId"].Value):null ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Updatedby",false,false,6);
if(repositoryColumnObj!=null)ActivityTrailLogDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-gv_UserId not found");}

if(rows.ContainsKey("6DB9BC45-F167-4D8A-9596-1DBA9872F253"))     elementData = rows["6DB9BC45-F167-4D8A-9596-1DBA9872F253"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"DestinationActivityMapID",false,false,9);
if(repositoryColumnObj!=null)ActivityTrailLogDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-M_DestinationActivityId not found");}

elementData = ISpace["gv_UserName"].Value != null? Convert.ToString(ISpace["gv_UserName"].Value):null ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"RemarksBy",false,false,9);
if(repositoryColumnObj!=null)ActivityTrailLogDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-gv_UserName not found");}

elementData = ISpace["gv_ActivityName"].Value != null? Convert.ToString(ISpace["gv_ActivityName"].Value):null ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ActivityName",false,false,9);
if(repositoryColumnObj!=null)ActivityTrailLogDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-gv_ActivityName not found");}

if(rows.ContainsKey("F78328FF-68D9-45E9-BC40-27CD650C9D6C"))     elementData = rows["F78328FF-68D9-45E9-BC40-27CD650C9D6C"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Remarks",false,false,9);
if(repositoryColumnObj!=null)ActivityTrailLogDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MF_P1_Remarks not found");}

elementData = ISpace["gv_TenantId"].Value != null? Convert.ToString(ISpace["gv_TenantId"].Value):null ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"TenantID",false,false,9);
if(repositoryColumnObj!=null)ActivityTrailLogDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-gv_TenantId not found");}

elementData = Guid.NewGuid().ToString();if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"TrailLogId",true,false,9);
if(repositoryColumnObj!=null)ActivityTrailLogDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-GUID not found");}

if(rows.ContainsKey("52A564C4-B656-4F43-B6F3-E592002351F6"))     elementData = rows["52A564C4-B656-4F43-B6F3-E592002351F6"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"SourceActivityMapID",false,false,9);
if(repositoryColumnObj!=null)ActivityTrailLogDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-M_SourceActivityMapId not found");}

elementData = CurrentDate().ToString() ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"RemarksOn",false,false,8);
if(repositoryColumnObj!=null)ActivityTrailLogDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-CurrentDate not found");}
repositoryRowObj.Columns=ActivityTrailLogDetails_colObj;
RemarksDomain_ActivityTrailLogDetails_rowsObj.Add(repositoryRowObj);
}}

ActivityTrailLogDetailsRemarksDomaintableObj.Rows=RemarksDomain_ActivityTrailLogDetails_rowsObj;
var RemarksDomain_repoObj_status_ActivityTrailLogDetails = RemarksDomain_repoObj.Execute(DomainOperationTypes.CreateOrUpdate,ref ActivityTrailLogDetailsRemarksDomaintableObj);if(!RemarksDomain_repoObj_status_ActivityTrailLogDetails) throw new Exception("Error in Execute Domain Data Map");}
base.WriteDebugInfo(@"Exiting DomainDataMap for Remarks Domain");
if(IsNullOrEmpty(ISpace["Declaration"].Value))
{
base.WriteDebugInfo(@"if(IsNullOrEmpty(ISpace[""Declaration""].Value))");
ISpace["Message"].Value=@"Select the declaration";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Select the declaration"";");
return;
base.WriteDebugInfo(@"return;");
}
if(ISpace["M_SaveDomainData"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""M_SaveDomainData""].Value==1)");
ISpace["MF_P1_ApplicationStatus"].Value="A";
base.WriteDebugInfo(@"ISpace[""MF_P1_ApplicationStatus""].Value=""A"";");
}
if(ISpace["M_SaveDomainData"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""M_SaveDomainData""].Value==1)");
base.WriteDebugInfo(@"Entering DomainDataMap for Project Advance Details REPO 1");
var ProjectAdvanceDetailsREPO1_repoObj = new RepositoryMapper(DbTypes.SQLServer);


var ProjectAdvanceFormProjectAdvanceDetailsREPO1tableObj = new RepositoryTable("ProjectAdvanceForm");
  ProjectAdvanceFormProjectAdvanceDetailsREPO1tableObj.AppConnectionSettingsId  ="3A103712-5244-4427-B2B6-1C4E046FD337";ProjectAdvanceFormProjectAdvanceDetailsREPO1tableObj.ProofConnectionId = "C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0)";
var ProjectAdvanceDetailsREPO1_ProjectAdvanceForm_rows = GetElementClientData(ISpace["InstanceId"].Value,"6B463D69-64AB-468E-B2E3-DB12E6B90014");

if(ProjectAdvanceDetailsREPO1_ProjectAdvanceForm_rows!=null && ProjectAdvanceDetailsREPO1_ProjectAdvanceForm_rows.Count>0){
var ProjectAdvanceDetailsREPO1_ProjectAdvanceForm_rowsObj = new List<RepositoryRow>();
foreach(var rows in ProjectAdvanceDetailsREPO1_ProjectAdvanceForm_rows){RepositoryRow repositoryRowObj = null;string elementData = null;RepositoryColumn repositoryColumnObj = null;if(rows !=null){ var ProjectAdvanceForm_colObj = new List<RepositoryColumn>();repositoryRowObj= new RepositoryRow();//var myByte = (byte)rowData.Value.RwSt;//repositoryRowObj.RowState=(RepositoryRowState)myByte;

if(rows.ContainsKey("72A0167C-47E6-4BBA-964A-D18B4C2724BE"))     elementData = rows["72A0167C-47E6-4BBA-964A-D18B4C2724BE"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"AdvanceFormId",true,false,9);
if(repositoryColumnObj!=null)ProjectAdvanceForm_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-M_Advanceformid not found");}

elementData = ISpace["gv_UserName"].Value != null? Convert.ToString(ISpace["gv_UserName"].Value):null ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"InitatedBy",false,false,9);
if(repositoryColumnObj!=null)ProjectAdvanceForm_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-gv_UserName not found");}

elementData = ISpace["gv_UserName"].Value != null? Convert.ToString(ISpace["gv_UserName"].Value):null ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"UpdatedBy",false,false,9);
if(repositoryColumnObj!=null)ProjectAdvanceForm_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-gv_UserName not found");}

if(rows.ContainsKey("16BFBC4B-9CB5-4677-AAE8-85CE6C7260E5"))     elementData = rows["16BFBC4B-9CB5-4677-AAE8-85CE6C7260E5"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ApplicationStatus",false,false,9);
if(repositoryColumnObj!=null)ProjectAdvanceForm_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MF_P1_ApplicationStatus not found");}

if(rows.ContainsKey("329D5240-1DBD-433E-A8EB-0F29F5AA668C"))     elementData = rows["329D5240-1DBD-433E-A8EB-0F29F5AA668C"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"EmployeeBasicInfoId",false,false,9);
if(repositoryColumnObj!=null)ProjectAdvanceForm_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-UC_EmployeeBaicInfoId not found");}

if(rows.ContainsKey("68A2EC13-D240-4EBC-8828-E795581544DA"))     elementData = rows["68A2EC13-D240-4EBC-8828-E795581544DA"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"TotalAmount",false,false,3);
if(repositoryColumnObj!=null)ProjectAdvanceForm_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MF_P1_TotalAmount not found");}

elementData = CurrentDate().ToString() ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Initiatedon",false,false,8);
if(repositoryColumnObj!=null)ProjectAdvanceForm_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-CurrentDate not found");}

elementData = CurrentDate().ToString() ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"UpdatedOn",false,false,8);
if(repositoryColumnObj!=null)ProjectAdvanceForm_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-CurrentDate not found");}
repositoryRowObj.Columns=ProjectAdvanceForm_colObj;
ProjectAdvanceDetailsREPO1_ProjectAdvanceForm_rowsObj.Add(repositoryRowObj);
}}

ProjectAdvanceFormProjectAdvanceDetailsREPO1tableObj.Rows=ProjectAdvanceDetailsREPO1_ProjectAdvanceForm_rowsObj;
var ProjectAdvanceDetailsREPO1_repoObj_status_ProjectAdvanceForm = ProjectAdvanceDetailsREPO1_repoObj.Execute(DomainOperationTypes.CreateOrUpdate,ref ProjectAdvanceFormProjectAdvanceDetailsREPO1tableObj);if(!ProjectAdvanceDetailsREPO1_repoObj_status_ProjectAdvanceForm) throw new Exception("Error in Execute Domain Data Map");}
base.WriteDebugInfo(@"Exiting DomainDataMap for Project Advance Details REPO 1");
base.WriteDebugInfo(@"Entering DomainDataMap for Project Advance Details REPO 2");
var ProjectAdvanceDetailsREPO2_repoObj = new RepositoryMapper(DbTypes.SQLServer);


var ProjectAdvanceFundDetailsProjectAdvanceDetailsREPO2tableObj = new RepositoryTable("ProjectAdvanceFundDetails");
  ProjectAdvanceFundDetailsProjectAdvanceDetailsREPO2tableObj.AppConnectionSettingsId  ="3A103712-5244-4427-B2B6-1C4E046FD337";ProjectAdvanceFundDetailsProjectAdvanceDetailsREPO2tableObj.ProofConnectionId = "C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0)";
var ProjectAdvanceDetailsREPO2_ProjectAdvanceFundDetails_rows = GetElementClientData(ISpace["InstanceId"].Value,"00D69CC2-E6EC-4412-B2A9-14E57A96FB5C");

if(ProjectAdvanceDetailsREPO2_ProjectAdvanceFundDetails_rows!=null && ProjectAdvanceDetailsREPO2_ProjectAdvanceFundDetails_rows.Count>0){
var ProjectAdvanceDetailsREPO2_ProjectAdvanceFundDetails_rowsObj = new List<RepositoryRow>();
foreach(var rows in ProjectAdvanceDetailsREPO2_ProjectAdvanceFundDetails_rows){RepositoryRow repositoryRowObj = null;string elementData = null;RepositoryColumn repositoryColumnObj = null;if(rows !=null){ var ProjectAdvanceFundDetails_colObj = new List<RepositoryColumn>();repositoryRowObj= new RepositoryRow();//var myByte = (byte)rowData.Value.RwSt;//repositoryRowObj.RowState=(RepositoryRowState)myByte;

if(rows.ContainsKey("E20A9876-034C-49BC-A309-26338AAD45BD"))     elementData = rows["E20A9876-034C-49BC-A309-26338AAD45BD"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"AdvanceFormId",false,false,9);
if(repositoryColumnObj!=null)ProjectAdvanceFundDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MG_P3_Advanceformid not found");}

if(rows.ContainsKey("B24F329A-C286-4040-ABD2-B67B5AE4F7BE"))     elementData = rows["B24F329A-C286-4040-ABD2-B67B5AE4F7BE"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"FundDetailsId",true,false,9);
if(repositoryColumnObj!=null)ProjectAdvanceFundDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MG_P3_FundDetailsId not found");}

if(rows.ContainsKey("4F81555E-3503-43B3-AD28-23293B41E926"))     elementData = rows["4F81555E-3503-43B3-AD28-23293B41E926"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ProjectDetailsId",false,false,9);
if(repositoryColumnObj!=null)ProjectAdvanceFundDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MG_P3_ProjectDetailsId not found");}

if(rows.ContainsKey("CCBB2219-451D-4EAE-BA26-1C16A9B0FF7D"))     elementData = rows["CCBB2219-451D-4EAE-BA26-1C16A9B0FF7D"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Amount",false,false,3);
if(repositoryColumnObj!=null)ProjectAdvanceFundDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MG_P3_Amount not found");}

if(rows.ContainsKey("8F687AA1-A6B1-4250-9948-DBAF2D40AB51"))     elementData = rows["8F687AA1-A6B1-4250-9948-DBAF2D40AB51"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"BudgetHeadId",false,false,9);
if(repositoryColumnObj!=null)ProjectAdvanceFundDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MG_P3_BudgetHeadId not found");}

if(rows.ContainsKey("99E459F3-F338-40A6-A1E3-1F7AD7A198CD"))     elementData = rows["99E459F3-F338-40A6-A1E3-1F7AD7A198CD"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"FundTypeId",false,false,6);
if(repositoryColumnObj!=null)ProjectAdvanceFundDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MG_P3_FundTypeId not found");}
repositoryRowObj.Columns=ProjectAdvanceFundDetails_colObj;
ProjectAdvanceDetailsREPO2_ProjectAdvanceFundDetails_rowsObj.Add(repositoryRowObj);
}}

ProjectAdvanceFundDetailsProjectAdvanceDetailsREPO2tableObj.Rows=ProjectAdvanceDetailsREPO2_ProjectAdvanceFundDetails_rowsObj;
var ProjectAdvanceDetailsREPO2_repoObj_status_ProjectAdvanceFundDetails = ProjectAdvanceDetailsREPO2_repoObj.Execute(DomainOperationTypes.CreateOrUpdate,ref ProjectAdvanceFundDetailsProjectAdvanceDetailsREPO2tableObj);if(!ProjectAdvanceDetailsREPO2_repoObj_status_ProjectAdvanceFundDetails) throw new Exception("Error in Execute Domain Data Map");}
base.WriteDebugInfo(@"Exiting DomainDataMap for Project Advance Details REPO 2");
base.WriteDebugInfo(@"Entering DomainDataMap for Project Advance Details REPO 3");
var ProjectAdvanceDetailsREPO3_repoObj = new RepositoryMapper(DbTypes.SQLServer);


var ProjectAdvanceRequestDetailsProjectAdvanceDetailsREPO3tableObj = new RepositoryTable("ProjectAdvanceRequestDetails");
  ProjectAdvanceRequestDetailsProjectAdvanceDetailsREPO3tableObj.AppConnectionSettingsId  ="3A103712-5244-4427-B2B6-1C4E046FD337";ProjectAdvanceRequestDetailsProjectAdvanceDetailsREPO3tableObj.ProofConnectionId = "C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0)";
var ProjectAdvanceDetailsREPO3_ProjectAdvanceRequestDetails_rows = GetElementClientData(ISpace["InstanceId"].Value,"1356A8F2-1947-4667-987D-2EA211B288A3");

if(ProjectAdvanceDetailsREPO3_ProjectAdvanceRequestDetails_rows!=null && ProjectAdvanceDetailsREPO3_ProjectAdvanceRequestDetails_rows.Count>0){
var ProjectAdvanceDetailsREPO3_ProjectAdvanceRequestDetails_rowsObj = new List<RepositoryRow>();
foreach(var rows in ProjectAdvanceDetailsREPO3_ProjectAdvanceRequestDetails_rows){RepositoryRow repositoryRowObj = null;string elementData = null;RepositoryColumn repositoryColumnObj = null;if(rows !=null){ var ProjectAdvanceRequestDetails_colObj = new List<RepositoryColumn>();repositoryRowObj= new RepositoryRow();//var myByte = (byte)rowData.Value.RwSt;//repositoryRowObj.RowState=(RepositoryRowState)myByte;

if(rows.ContainsKey("04D90722-37D7-40B0-96B6-D6CA55ABA8F2"))     elementData = rows["04D90722-37D7-40B0-96B6-D6CA55ABA8F2"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ExpenseDetails",false,false,9);
if(repositoryColumnObj!=null)ProjectAdvanceRequestDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MGA_DetailsofExpenses not found");}

if(rows.ContainsKey("B1EB21F5-30E2-4DB3-B72E-E6BB3E4A1D2B"))     elementData = rows["B1EB21F5-30E2-4DB3-B72E-E6BB3E4A1D2B"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ItemDescription",false,false,9);
if(repositoryColumnObj!=null)ProjectAdvanceRequestDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MGA_Description not found");}

if(rows.ContainsKey("8E8892C8-B328-42D2-A630-B8A2C3C4D26B"))     elementData = rows["8E8892C8-B328-42D2-A630-B8A2C3C4D26B"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Amount",false,false,3);
if(repositoryColumnObj!=null)ProjectAdvanceRequestDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MGA_Amount not found");}

if(rows.ContainsKey("67C65E87-8293-495E-97A2-E7431BF75D69"))     elementData = rows["67C65E87-8293-495E-97A2-E7431BF75D69"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"RequestDetailsId",true,false,9);
if(repositoryColumnObj!=null)ProjectAdvanceRequestDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MGA_RequestDetailsId not found");}

if(rows.ContainsKey("6E5FD9F2-E29C-4922-B6C5-78C591A395A6"))     elementData = rows["6E5FD9F2-E29C-4922-B6C5-78C591A395A6"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"AdvanceFormId",false,false,9);
if(repositoryColumnObj!=null)ProjectAdvanceRequestDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MGA_AdvanceFormId not found");}
repositoryRowObj.Columns=ProjectAdvanceRequestDetails_colObj;
ProjectAdvanceDetailsREPO3_ProjectAdvanceRequestDetails_rowsObj.Add(repositoryRowObj);
}}

ProjectAdvanceRequestDetailsProjectAdvanceDetailsREPO3tableObj.Rows=ProjectAdvanceDetailsREPO3_ProjectAdvanceRequestDetails_rowsObj;
var ProjectAdvanceDetailsREPO3_repoObj_status_ProjectAdvanceRequestDetails = ProjectAdvanceDetailsREPO3_repoObj.Execute(DomainOperationTypes.CreateOrUpdate,ref ProjectAdvanceRequestDetailsProjectAdvanceDetailsREPO3tableObj);if(!ProjectAdvanceDetailsREPO3_repoObj_status_ProjectAdvanceRequestDetails) throw new Exception("Error in Execute Domain Data Map");}
base.WriteDebugInfo(@"Exiting DomainDataMap for Project Advance Details REPO 3");
}
if(ISpace["M_IsflowReturned"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""M_IsflowReturned""].Value==1)");
ISpace["AssignToUser"].Value=ISpace["M_InitiatorUserMapId"].Value;
base.WriteDebugInfo(@"ISpace[""AssignToUser""].Value=ISpace[""M_InitiatorUserMapId""].Value;");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["AssignToUser"].Value="";
base.WriteDebugInfo(@"ISpace[""AssignToUser""].Value="""";");
}
base.WriteDebugInfo(@"#ReimbursementFundDetails[Rows]");
iSpace.GetLoopExpressionData("ReimbursementFundDetails",ref ISpace);

foreach(var gridChild in ISpace["ReimbursementFundDetails"].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 


if(
ISpace["M_SaveDomainData"].Value==1)
{
base.WriteDebugInfo(@"
if(
ISpace[""M_SaveDomainData""].Value==1)");
base.WriteDebugInfo(@"EXEC [UpsertProjectBudgetDetails] 5,"#MG_P3_ProjectDetailsId","","#MG_P3_Amount","#MG_P3_BudgetHeadId",0,"#MG_P3_FundTypeId"");

var querySourceB460B189F97546FAAA0EC134AA7CDECC =GetQueryExpressionDataSource("B460B189-F975-46FA-AA0E-C134AA7CDECC");
Dictionary<short,object> resultB460B189F97546FAAA0EC134AA7CDECC=iSpace.ExecuteQuery(querySourceB460B189F97546FAAA0EC134AA7CDECC,@"EXEC [UpsertProjectBudgetDetails] 5,"" + ISpace["MG_P3_ProjectDetailsId"].Value + @"","","" + ISpace["MG_P3_Amount"].Value + @"","" + ISpace["MG_P3_BudgetHeadId"].Value + @"",0,"" + ISpace["MG_P3_FundTypeId"].Value + @""",false);

base.WriteDebugInfo(@"var querySourceB460B189F97546FAAA0EC134AA7CDECC =GetQueryExpressionDataSource(""B460B189-F975-46FA-AA0E-C134AA7CDECC"");Dictionary<short,object> resultB460B189F97546FAAA0EC134AA7CDECC=iSpace.ExecuteQuery(querySourceB460B189F97546FAAA0EC134AA7CDECC,@""EXEC [UpsertProjectBudgetDetails] 5,"""" + ISpace[""MG_P3_ProjectDetailsId""].Value + @"""","""","""" + ISpace[""MG_P3_Amount""].Value + @"""","""" + ISpace[""MG_P3_BudgetHeadId""].Value + @"""",0,"""" + ISpace[""MG_P3_FundTypeId""].Value + @"""""",false);");
base.WriteDebugInfo(@"");

if((resultB460B189F97546FAAA0EC134AA7CDECC!=null) && (resultB460B189F97546FAAA0EC134AA7CDECC.Count!=0))
{
if(resultB460B189F97546FAAA0EC134AA7CDECC.ContainsKey(0))
ISpace["M_UpdateCount"].Value = resultB460B189F97546FAAA0EC134AA7CDECC[0];
}
else{
ISpace["M_UpdateCount"].Value = null;
}
}
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("ReimbursementFundDetails","00D69CC2-E6EC-4412-B2A9-14E57A96FB5C",_objectFactory.GetGridRPP("ReimbursementFundDetails"),_elementBase.GetGridLoopQuery("00D69CC2-E6EC-4412-B2A9-14E57A96FB5C","ReimbursementFundDetails",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""ReimbursementFundDetails"",ref ISpace);

foreach(var gridChild in ISpace[""ReimbursementFundDetails""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
base.WriteDebugInfo(@"#ReimbursementFundDetails[Rows]");
iSpace.GetLoopExpressionData("ReimbursementFundDetails",ref ISpace);

foreach(var gridChild in ISpace["ReimbursementFundDetails"].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 


if(
ISpace["M_IsflowReturned"].Value==1)
{
base.WriteDebugInfo(@"
if(
ISpace[""M_IsflowReturned""].Value==1)");
base.WriteDebugInfo(@"EXEC [UpsertProjectBudgetDetails] 6,"#MG_P3_ProjectDetailsId","","#MG_P3_Amount","#MG_P3_BudgetHeadId",1,"#MG_P3_FundTypeId"");

var querySource318EAB61FF354EB2A293264135B2F298 =GetQueryExpressionDataSource("318EAB61-FF35-4EB2-A293-264135B2F298");
Dictionary<short,object> result318EAB61FF354EB2A293264135B2F298=iSpace.ExecuteQuery(querySource318EAB61FF354EB2A293264135B2F298,@"EXEC [UpsertProjectBudgetDetails] 6,"" + ISpace["MG_P3_ProjectDetailsId"].Value + @"","","" + ISpace["MG_P3_Amount"].Value + @"","" + ISpace["MG_P3_BudgetHeadId"].Value + @"",1,"" + ISpace["MG_P3_FundTypeId"].Value + @""",false);

base.WriteDebugInfo(@"var querySource318EAB61FF354EB2A293264135B2F298 =GetQueryExpressionDataSource(""318EAB61-FF35-4EB2-A293-264135B2F298"");Dictionary<short,object> result318EAB61FF354EB2A293264135B2F298=iSpace.ExecuteQuery(querySource318EAB61FF354EB2A293264135B2F298,@""EXEC [UpsertProjectBudgetDetails] 6,"""" + ISpace[""MG_P3_ProjectDetailsId""].Value + @"""","""","""" + ISpace[""MG_P3_Amount""].Value + @"""","""" + ISpace[""MG_P3_BudgetHeadId""].Value + @"""",1,"""" + ISpace[""MG_P3_FundTypeId""].Value + @"""""",false);");
base.WriteDebugInfo(@"");

if((result318EAB61FF354EB2A293264135B2F298!=null) && (result318EAB61FF354EB2A293264135B2F298.Count!=0))
{
if(result318EAB61FF354EB2A293264135B2F298.ContainsKey(0))
ISpace["M_UpdateCount"].Value = result318EAB61FF354EB2A293264135B2F298[0];
}
else{
ISpace["M_UpdateCount"].Value = null;
}
}
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("ReimbursementFundDetails","00D69CC2-E6EC-4412-B2A9-14E57A96FB5C",_objectFactory.GetGridRPP("ReimbursementFundDetails"),_elementBase.GetGridLoopQuery("00D69CC2-E6EC-4412-B2A9-14E57A96FB5C","ReimbursementFundDetails",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""ReimbursementFundDetails"",ref ISpace);

foreach(var gridChild in ISpace[""ReimbursementFundDetails""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["M_MoveTo"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""M_MoveTo""].Value=="""")");
ISpace["Message"].Value=@"Move To should be mandatory";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Move To should be mandatory"";");
return;
base.WriteDebugInfo(@"return;");
}
}
if(ISpace["M_SaveDomainData"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""M_SaveDomainData""].Value==1)");
ISpace["M_Status"].Value="Approved";
base.WriteDebugInfo(@"ISpace[""M_Status""].Value=""Approved"";");
}
if(ISpace["M_IsCancelReject"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""M_IsCancelReject""].Value==1)");
ISpace["M_Status"].Value="Dropped";
base.WriteDebugInfo(@"ISpace[""M_Status""].Value=""Dropped"";");
}
base.WriteDebugInfo(@"Entering DomainDataMap for User Request For other steps");
var UserRequestForothersteps_repoObj = new RepositoryMapper(DbTypes.SQLServer);


var UserRequestsUserRequestForotherstepstableObj = new RepositoryTable("UserRequests");
  UserRequestsUserRequestForotherstepstableObj.AppConnectionSettingsId  ="9ADED37B-CD11-426B-AF16-DEAC75685EF5";UserRequestsUserRequestForotherstepstableObj.ProofConnectionId = "C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0)";
var UserRequestForothersteps_UserRequests_rows = GetElementClientData(ISpace["InstanceId"].Value,"6B463D69-64AB-468E-B2E3-DB12E6B90014");

if(UserRequestForothersteps_UserRequests_rows!=null && UserRequestForothersteps_UserRequests_rows.Count>0){
var UserRequestForothersteps_UserRequests_rowsObj = new List<RepositoryRow>();
foreach(var rows in UserRequestForothersteps_UserRequests_rows){RepositoryRow repositoryRowObj = null;string elementData = null;RepositoryColumn repositoryColumnObj = null;if(rows !=null){ var UserRequests_colObj = new List<RepositoryColumn>();repositoryRowObj= new RepositoryRow();//var myByte = (byte)rowData.Value.RwSt;//repositoryRowObj.RowState=(RepositoryRowState)myByte;

if(rows.ContainsKey("34CFB4AA-E9A1-4EAC-83A8-AEC1C4038EE1"))     elementData = rows["34CFB4AA-E9A1-4EAC-83A8-AEC1C4038EE1"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"CurrentLevel",false,false,9);
if(repositoryColumnObj!=null)UserRequests_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-M_NextStage not found");}

if(rows.ContainsKey("B89FF303-5A1C-4060-BAB9-E6F52A11D9FD"))     elementData = rows["B89FF303-5A1C-4060-BAB9-E6F52A11D9FD"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"CurrentStatus",false,false,9);
if(repositoryColumnObj!=null)UserRequests_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-M_Status not found");}

elementData = ISpace["gv_UserId"].Value != null? Convert.ToString(ISpace["gv_UserId"].Value):null ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"LastModifiedByUserID",false,false,5);
if(repositoryColumnObj!=null)UserRequests_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-gv_UserId not found");}

if(rows.ContainsKey("0CDC8D38-F4F4-4C60-BCED-E9F0C8B165B8"))     elementData = rows["0CDC8D38-F4F4-4C60-BCED-E9F0C8B165B8"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"CurrentActivityMapID",false,false,9);
if(repositoryColumnObj!=null)UserRequests_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-SetDestinationTo not found");}

if(rows.ContainsKey("D7BB255E-9A01-4B5B-AE06-CC4D6E088D52"))     elementData = rows["D7BB255E-9A01-4B5B-AE06-CC4D6E088D52"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"InstanceID",true,false,9);
if(repositoryColumnObj!=null)UserRequests_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-M_InstanceId not found");}

elementData = CurrentDate().ToString() ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"LastModifiedOn",false,false,8);
if(repositoryColumnObj!=null)UserRequests_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-CurrentDate not found");}
repositoryRowObj.Columns=UserRequests_colObj;
UserRequestForothersteps_UserRequests_rowsObj.Add(repositoryRowObj);
}}

UserRequestsUserRequestForotherstepstableObj.Rows=UserRequestForothersteps_UserRequests_rowsObj;
var UserRequestForothersteps_repoObj_status_UserRequests = UserRequestForothersteps_repoObj.Execute(DomainOperationTypes.Update,ref UserRequestsUserRequestForotherstepstableObj);if(!UserRequestForothersteps_repoObj_status_UserRequests) throw new Exception("Error in Execute Domain Data Map");}
base.WriteDebugInfo(@"Exiting DomainDataMap for User Request For other steps");
ISpace["Message"].Value=@"Submitted Successfully";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Submitted Successfully"";");
ISpace.ExecuteInstanceCommand("Submit");
base.WriteDebugInfo(@"ISpace.ExecuteInstanceCommand(""Submit"");");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_save_reimbursementbilldetails (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Save_ReimbursementBillDetails-OnClick");
if(ISpace["growid"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""growid""].Value=="""")");

var querySource588878D7B7824F24BAF7A4FE902E4A93 =GetQueryExpressionDataSource("588878D7-B782-4F24-BAF7-A4FE902E4A93");

DataTable result588878D7B7824F24BAF7A4FE902E4A93=iSpace.SetGridDataSource(querySource588878D7B7824F24BAF7A4FE902E4A93, _objectFactory.GetGridRPP("ReimbursementBillDetails"),@"EXEC AddFormGridDataC9ACCA847AF347E79133D777BE46A656 "" + ISpace["gv_instanceid"].Value + @"","" + ISpace["gv_processmapid"].Value + @"","C9ACCA84-7AF3-47E7-9133-D777BE46A656","" + ISpace["gv_activitymapid"].Value + @"","" + ISpace["MFG_P2_ReimbursementDetailsId"].Value + @"","" + ISpace["MFG_P2_ReimbursementId"].Value + @"","" + ISpace["MFG_P2_BillNo"].Value + @"","" + ISpace["MFG_P2_BillDate"].Value + @""," + ISpace["MFG_P2_BillDocument"].Value + @","" + ISpace["MFG_P2_ItemDescription"].Value + @""," + ISpace["MFG_P2_Amount"].Value + @","" + ISpace["growid"].Value + @""");

iSpace.InsertGridBindDetails("ReimbursementBillDetails","11",querySource588878D7B7824F24BAF7A4FE902E4A93,"EXEC AddFormGridDataC9ACCA847AF347E79133D777BE46A656 "" + ISpace["gv_instanceid"].Value + @"","" + ISpace["gv_processmapid"].Value + @"","C9ACCA84-7AF3-47E7-9133-D777BE46A656","" + ISpace["gv_activitymapid"].Value + @"","" + ISpace["MFG_P2_ReimbursementDetailsId"].Value + @"","" + ISpace["MFG_P2_ReimbursementId"].Value + @"","" + ISpace["MFG_P2_BillNo"].Value + @"","" + ISpace["MFG_P2_BillDate"].Value + @""," + ISpace["MFG_P2_BillDocument"].Value + @","" + ISpace["MFG_P2_ItemDescription"].Value + @""," + ISpace["MFG_P2_Amount"].Value + @","" + ISpace["growid"].Value + @""",_objectFactory.GetGridRPP("ReimbursementBillDetails"));

base.WriteDebugInfo(@"var querySource588878D7B7824F24BAF7A4FE902E4A93 =GetQueryExpressionDataSource(""588878D7-B782-4F24-BAF7-A4FE902E4A93"");DataTable result588878D7B7824F24BAF7A4FE902E4A93=iSpace.SetGridDataSource(querySource588878D7B7824F24BAF7A4FE902E4A93, _objectFactory.GetGridRPP(""ReimbursementBillDetails""),@""EXEC AddFormGridDataC9ACCA847AF347E79133D777BE46A656 """" + ISpace[""gv_instanceid""].Value + @"""","""" + ISpace[""gv_processmapid""].Value + @"""",""C9ACCA84-7AF3-47E7-9133-D777BE46A656"","""" + ISpace[""gv_activitymapid""].Value + @"""","""" + ISpace[""MFG_P2_ReimbursementDetailsId""].Value + @"""","""" + ISpace[""MFG_P2_ReimbursementId""].Value + @"""","""" + ISpace[""MFG_P2_BillNo""].Value + @"""","""" + ISpace[""MFG_P2_BillDate""].Value + @"""","" + ISpace[""MFG_P2_BillDocument""].Value + @"","""" + ISpace[""MFG_P2_ItemDescription""].Value + @"""","" + ISpace[""MFG_P2_Amount""].Value + @"","""" + ISpace[""growid""].Value + @"""""");iSpace.InsertGridBindDetails(""ReimbursementBillDetails"",""11"",querySource588878D7B7824F24BAF7A4FE902E4A93,""EXEC AddFormGridDataC9ACCA847AF347E79133D777BE46A656 """" + ISpace[""gv_instanceid""].Value + @"""","""" + ISpace[""gv_processmapid""].Value + @"""",""C9ACCA84-7AF3-47E7-9133-D777BE46A656"","""" + ISpace[""gv_activitymapid""].Value + @"""","""" + ISpace[""MFG_P2_ReimbursementDetailsId""].Value + @"""","""" + ISpace[""MFG_P2_ReimbursementId""].Value + @"""","""" + ISpace[""MFG_P2_BillNo""].Value + @"""","""" + ISpace[""MFG_P2_BillDate""].Value + @"""","" + ISpace[""MFG_P2_BillDocument""].Value + @"","""" + ISpace[""MFG_P2_ItemDescription""].Value + @"""","" + ISpace[""MFG_P2_Amount""].Value + @"","""" + ISpace[""growid""].Value + @"""""",_objectFactory.GetGridRPP(""ReimbursementBillDetails""));");
base.WriteDebugInfo(@"EXEC AddFormGridDataC9ACCA847AF347E79133D777BE46A656 "@@gv_InstanceId","@@gv_ProcessMapId","C9ACCA84-7AF3-47E7-9133-D777BE46A656","@@gv_ActivityMapId","#MFG_P2_ReimbursementDetailsId","#MFG_P2_ReimbursementId","#MFG_P2_BillNo","#MFG_P2_BillDate",#MFG_P2_BillDocument,"#MFG_P2_ItemDescription",#MFG_P2_Amount,"#growid"");


List<Triplet<string, short, short?>> resultAB481A6E87354F09AD1BC0BBEFC0AD56=acdataIspace9FE779D2129C47A2B87D173C6AFE51CB.GetQueryExpressionBindings("AB481A6E-8735-4F09-AD1B-C0BBEFC0AD56");
iSpace.SetGridData(result588878D7B7824F24BAF7A4FE902E4A93,resultAB481A6E87354F09AD1BC0BBEFC0AD56,"ReimbursementBillDetails",ref ISpace);
iSpace.UpdateGridBindDetails("ReimbursementBillDetails",resultAB481A6E87354F09AD1BC0BBEFC0AD56);
}
else
{
base.WriteDebugInfo(@"else");

var querySourceF3514DB4690A4BE6A6A77FA3D37E5B7C =GetQueryExpressionDataSource("F3514DB4-690A-4BE6-A6A7-7FA3D37E5B7C");

DataTable resultF3514DB4690A4BE6A6A77FA3D37E5B7C=iSpace.SetGridDataSource(querySourceF3514DB4690A4BE6A6A77FA3D37E5B7C, _objectFactory.GetGridRPP("ReimbursementBillDetails"),@"EXEC UpdateFormGridDataC9ACCA847AF347E79133D777BE46A656 "" + ISpace["gv_instanceid"].Value + @"","" + ISpace["gv_processmapid"].Value + @"","C9ACCA84-7AF3-47E7-9133-D777BE46A656","" + ISpace["gv_activitymapid"].Value + @"","" + ISpace["MFG_P2_ReimbursementDetailsId"].Value + @"","" + ISpace["MFG_P2_ReimbursementId"].Value + @"","" + ISpace["MFG_P2_BillNo"].Value + @"","" + ISpace["MFG_P2_BillDate"].Value + @""," + ISpace["MFG_P2_BillDocument"].Value + @","" + ISpace["MFG_P2_ItemDescription"].Value + @""," + ISpace["MFG_P2_Amount"].Value + @","" + ISpace["growid"].Value + @""");

iSpace.InsertGridBindDetails("ReimbursementBillDetails","11",querySourceF3514DB4690A4BE6A6A77FA3D37E5B7C,"EXEC UpdateFormGridDataC9ACCA847AF347E79133D777BE46A656 "" + ISpace["gv_instanceid"].Value + @"","" + ISpace["gv_processmapid"].Value + @"","C9ACCA84-7AF3-47E7-9133-D777BE46A656","" + ISpace["gv_activitymapid"].Value + @"","" + ISpace["MFG_P2_ReimbursementDetailsId"].Value + @"","" + ISpace["MFG_P2_ReimbursementId"].Value + @"","" + ISpace["MFG_P2_BillNo"].Value + @"","" + ISpace["MFG_P2_BillDate"].Value + @""," + ISpace["MFG_P2_BillDocument"].Value + @","" + ISpace["MFG_P2_ItemDescription"].Value + @""," + ISpace["MFG_P2_Amount"].Value + @","" + ISpace["growid"].Value + @""",_objectFactory.GetGridRPP("ReimbursementBillDetails"));

base.WriteDebugInfo(@"var querySourceF3514DB4690A4BE6A6A77FA3D37E5B7C =GetQueryExpressionDataSource(""F3514DB4-690A-4BE6-A6A7-7FA3D37E5B7C"");DataTable resultF3514DB4690A4BE6A6A77FA3D37E5B7C=iSpace.SetGridDataSource(querySourceF3514DB4690A4BE6A6A77FA3D37E5B7C, _objectFactory.GetGridRPP(""ReimbursementBillDetails""),@""EXEC UpdateFormGridDataC9ACCA847AF347E79133D777BE46A656 """" + ISpace[""gv_instanceid""].Value + @"""","""" + ISpace[""gv_processmapid""].Value + @"""",""C9ACCA84-7AF3-47E7-9133-D777BE46A656"","""" + ISpace[""gv_activitymapid""].Value + @"""","""" + ISpace[""MFG_P2_ReimbursementDetailsId""].Value + @"""","""" + ISpace[""MFG_P2_ReimbursementId""].Value + @"""","""" + ISpace[""MFG_P2_BillNo""].Value + @"""","""" + ISpace[""MFG_P2_BillDate""].Value + @"""","" + ISpace[""MFG_P2_BillDocument""].Value + @"","""" + ISpace[""MFG_P2_ItemDescription""].Value + @"""","" + ISpace[""MFG_P2_Amount""].Value + @"","""" + ISpace[""growid""].Value + @"""""");iSpace.InsertGridBindDetails(""ReimbursementBillDetails"",""11"",querySourceF3514DB4690A4BE6A6A77FA3D37E5B7C,""EXEC UpdateFormGridDataC9ACCA847AF347E79133D777BE46A656 """" + ISpace[""gv_instanceid""].Value + @"""","""" + ISpace[""gv_processmapid""].Value + @"""",""C9ACCA84-7AF3-47E7-9133-D777BE46A656"","""" + ISpace[""gv_activitymapid""].Value + @"""","""" + ISpace[""MFG_P2_ReimbursementDetailsId""].Value + @"""","""" + ISpace[""MFG_P2_ReimbursementId""].Value + @"""","""" + ISpace[""MFG_P2_BillNo""].Value + @"""","""" + ISpace[""MFG_P2_BillDate""].Value + @"""","" + ISpace[""MFG_P2_BillDocument""].Value + @"","""" + ISpace[""MFG_P2_ItemDescription""].Value + @"""","" + ISpace[""MFG_P2_Amount""].Value + @"","""" + ISpace[""growid""].Value + @"""""",_objectFactory.GetGridRPP(""ReimbursementBillDetails""));");
base.WriteDebugInfo(@"EXEC UpdateFormGridDataC9ACCA847AF347E79133D777BE46A656 "@@gv_InstanceId","@@gv_ProcessMapId","C9ACCA84-7AF3-47E7-9133-D777BE46A656","@@gv_ActivityMapId","#MFG_P2_ReimbursementDetailsId","#MFG_P2_ReimbursementId","#MFG_P2_BillNo","#MFG_P2_BillDate",#MFG_P2_BillDocument,"#MFG_P2_ItemDescription",#MFG_P2_Amount,"#growid"");


List<Triplet<string, short, short?>> result51CA1824668943C9A9D9B360B3E6BBB8=acdataIspace9FE779D2129C47A2B87D173C6AFE51CB.GetQueryExpressionBindings("51CA1824-6689-43C9-A9D9-B360B3E6BBB8");
iSpace.SetGridData(resultF3514DB4690A4BE6A6A77FA3D37E5B7C,result51CA1824668943C9A9D9B360B3E6BBB8,"ReimbursementBillDetails",ref ISpace);
iSpace.UpdateGridBindDetails("ReimbursementBillDetails",result51CA1824668943C9A9D9B360B3E6BBB8);
}
ISpace["growid"].Value="";
base.WriteDebugInfo(@"ISpace[""growid""].Value="""";");
ISpace["MFG_P2_ReimbursementDetailsId"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_P2_ReimbursementDetailsId""].Value="""";");
ISpace["MFG_P2_ReimbursementId"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_P2_ReimbursementId""].Value="""";");
ISpace["MFG_P2_BillNo"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_P2_BillNo""].Value="""";");
ISpace["MFG_P2_BillDate"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_P2_BillDate""].Value="""";");
ISpace["MFG_P2_BillDocument"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_P2_BillDocument""].Value="""";");
ISpace["MFG_P2_ItemDescription"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_P2_ItemDescription""].Value="""";");
ISpace["MFG_P2_Amount"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_P2_Amount""].Value="""";");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_edit_reimbursementfunddetails (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Edit_ReimbursementFundDetails-OnClick");
ISpace["growid"].Value=ISpace["ReimbursementFundDetails_RowId"].Value;
base.WriteDebugInfo(@"ISpace[""growid""].Value=ISpace[""ReimbursementFundDetails_RowId""].Value;");
base.WriteDebugInfo(@"EXEC  [LoadFormGridData1112A274004543D393C5205DAEFEA917]  "@@gv_InstanceId","@@gv_ProcessMapId","1112A274-0045-43D3-93C5-205DAEFEA917","@@gv_ActivityMapId","#growid"");

var querySource457B75FDB3F34EB787EB96D92F86F9EB =GetQueryExpressionDataSource("457B75FD-B3F3-4EB7-87EB-96D92F86F9EB");
Dictionary<short,object> result457B75FDB3F34EB787EB96D92F86F9EB=iSpace.ExecuteQuery(querySource457B75FDB3F34EB787EB96D92F86F9EB,@"EXEC[LoadFormGridData1112A274004543D393C5205DAEFEA917]"" + ISpace["gv_instanceid"].Value + @"","" + ISpace["gv_processmapid"].Value + @"","1112A274-0045-43D3-93C5-205DAEFEA917","" + ISpace["gv_activitymapid"].Value + @"","" + ISpace["growid"].Value + @""",false);

base.WriteDebugInfo(@"var querySource457B75FDB3F34EB787EB96D92F86F9EB =GetQueryExpressionDataSource(""457B75FD-B3F3-4EB7-87EB-96D92F86F9EB"");Dictionary<short,object> result457B75FDB3F34EB787EB96D92F86F9EB=iSpace.ExecuteQuery(querySource457B75FDB3F34EB787EB96D92F86F9EB,@""EXEC[LoadFormGridData1112A274004543D393C5205DAEFEA917]"""" + ISpace[""gv_instanceid""].Value + @"""","""" + ISpace[""gv_processmapid""].Value + @"""",""1112A274-0045-43D3-93C5-205DAEFEA917"","""" + ISpace[""gv_activitymapid""].Value + @"""","""" + ISpace[""growid""].Value + @"""""",false);");
base.WriteDebugInfo(@"EXEC LoadFormGridDataD85301F7BAF94BE8A2B174E5CBB3D054 "@@gv_InstanceId","@@gv_ProcessMapId","D85301F7-BAF9-4BE8-A2B1-74E5CBB3D054","@@gv_ActivityMapId","#growid"");

if((result457B75FDB3F34EB787EB96D92F86F9EB!=null) && (result457B75FDB3F34EB787EB96D92F86F9EB.Count!=0))
{
if(result457B75FDB3F34EB787EB96D92F86F9EB.ContainsKey(2))
ISpace["MFG_P3_FundTypeId"].Value = result457B75FDB3F34EB787EB96D92F86F9EB[2];
if(result457B75FDB3F34EB787EB96D92F86F9EB.ContainsKey(3))
ISpace["MFG_P3_ProjectDetailsId"].Value = result457B75FDB3F34EB787EB96D92F86F9EB[3];
if(result457B75FDB3F34EB787EB96D92F86F9EB.ContainsKey(4))
ISpace["MFG_P3_BudgetHeadId"].Value = result457B75FDB3F34EB787EB96D92F86F9EB[4];
if(result457B75FDB3F34EB787EB96D92F86F9EB.ContainsKey(5))
ISpace["MFG_P3_Amount"].Value = result457B75FDB3F34EB787EB96D92F86F9EB[5];
if(result457B75FDB3F34EB787EB96D92F86F9EB.ContainsKey(0))
ISpace["MFG_P3_FundDetailsId"].Value = result457B75FDB3F34EB787EB96D92F86F9EB[0];
if(result457B75FDB3F34EB787EB96D92F86F9EB.ContainsKey(1))
ISpace["MFG_P3_ReimbursementId"].Value = result457B75FDB3F34EB787EB96D92F86F9EB[1];
}
else{
ISpace["MFG_P3_FundTypeId"].Value = null;ISpace["MFG_P3_ProjectDetailsId"].Value = null;ISpace["MFG_P3_BudgetHeadId"].Value = null;ISpace["MFG_P3_Amount"].Value = null;ISpace["MFG_P3_FundDetailsId"].Value = null;ISpace["MFG_P3_ReimbursementId"].Value = null;
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_m_moveto (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"M_MoveTo-OnChange");
ISpace["M_MoveToValue"].Value=ISpace["M_MoveTo"].Value;
base.WriteDebugInfo(@"ISpace[""M_MoveToValue""].Value=ISpace[""M_MoveTo""].Value;");
base.WriteDebugInfo(@"Exec GetStageStatus 1,"","","#M_MoveToValue","#M_SourceActivityMapId"");

var querySource549686A138974AFCA19EC95972C37210 =GetQueryExpressionDataSource("549686A1-3897-4AFC-A19E-C95972C37210");
Dictionary<short,object> result549686A138974AFCA19EC95972C37210=iSpace.ExecuteQuery(querySource549686A138974AFCA19EC95972C37210,@"Exec GetStageStatus 1,"","","" + ISpace["M_MoveToValue"].Value + @"","" + ISpace["M_SourceActivityMapId"].Value + @""",false);

base.WriteDebugInfo(@"var querySource549686A138974AFCA19EC95972C37210 =GetQueryExpressionDataSource(""549686A1-3897-4AFC-A19E-C95972C37210"");Dictionary<short,object> result549686A138974AFCA19EC95972C37210=iSpace.ExecuteQuery(querySource549686A138974AFCA19EC95972C37210,@""Exec GetStageStatus 1,"""","""","""" + ISpace[""M_MoveToValue""].Value + @"""","""" + ISpace[""M_SourceActivityMapId""].Value + @"""""",false);");
base.WriteDebugInfo(@"");

if((result549686A138974AFCA19EC95972C37210!=null) && (result549686A138974AFCA19EC95972C37210.Count!=0))
{
if(result549686A138974AFCA19EC95972C37210.ContainsKey(3))
ISpace["M_SaveDomainData"].Value = result549686A138974AFCA19EC95972C37210[3];
if(result549686A138974AFCA19EC95972C37210.ContainsKey(1))
ISpace["M_RemarksMandatory"].Value = result549686A138974AFCA19EC95972C37210[1];
if(result549686A138974AFCA19EC95972C37210.ContainsKey(4))
ISpace["M_FieldMandatory"].Value = result549686A138974AFCA19EC95972C37210[4];
if(result549686A138974AFCA19EC95972C37210.ContainsKey(2))
ISpace["MF_P1_Remarks"].Value = result549686A138974AFCA19EC95972C37210[2];
if(result549686A138974AFCA19EC95972C37210.ContainsKey(0))
ISpace["M_NextStage"].Value = result549686A138974AFCA19EC95972C37210[0];
}
else{
ISpace["M_SaveDomainData"].Value = null;ISpace["M_RemarksMandatory"].Value = null;ISpace["M_FieldMandatory"].Value = null;ISpace["MF_P1_Remarks"].Value = null;ISpace["M_NextStage"].Value = null;
}
ISpace["SetDestinationTo"].Value=ISpace["M_MoveTo"].Value;
base.WriteDebugInfo(@"ISpace[""SetDestinationTo""].Value=ISpace[""M_MoveTo""].Value;");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_edit_reimbursementbilldetails (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Edit_ReimbursementBillDetails-OnClick");
base.WriteDebugInfo(@"EXEC LoadFormGridDataC9ACCA847AF347E79133D777BE46A656 "@@gv_InstanceId","@@gv_ProcessMapId","C9ACCA84-7AF3-47E7-9133-D777BE46A656","@@gv_ActivityMapId","#growid"");

var querySourceE12571F81F5945ED9BC6BAF0AA62F4F0 =GetQueryExpressionDataSource("E12571F8-1F59-45ED-9BC6-BAF0AA62F4F0");
Dictionary<short,object> resultE12571F81F5945ED9BC6BAF0AA62F4F0=iSpace.ExecuteQuery(querySourceE12571F81F5945ED9BC6BAF0AA62F4F0,@"EXEC LoadFormGridDataC9ACCA847AF347E79133D777BE46A656 "" + ISpace["gv_instanceid"].Value + @"","" + ISpace["gv_processmapid"].Value + @"","C9ACCA84-7AF3-47E7-9133-D777BE46A656","" + ISpace["gv_activitymapid"].Value + @"","" + ISpace["growid"].Value + @""",false);

base.WriteDebugInfo(@"var querySourceE12571F81F5945ED9BC6BAF0AA62F4F0 =GetQueryExpressionDataSource(""E12571F8-1F59-45ED-9BC6-BAF0AA62F4F0"");Dictionary<short,object> resultE12571F81F5945ED9BC6BAF0AA62F4F0=iSpace.ExecuteQuery(querySourceE12571F81F5945ED9BC6BAF0AA62F4F0,@""EXEC LoadFormGridDataC9ACCA847AF347E79133D777BE46A656 """" + ISpace[""gv_instanceid""].Value + @"""","""" + ISpace[""gv_processmapid""].Value + @"""",""C9ACCA84-7AF3-47E7-9133-D777BE46A656"","""" + ISpace[""gv_activitymapid""].Value + @"""","""" + ISpace[""growid""].Value + @"""""",false);");
base.WriteDebugInfo(@"EXEC LoadFormGridDataC9ACCA847AF347E79133D777BE46A656 "@@gv_InstanceId","@@gv_ProcessMapId","C9ACCA84-7AF3-47E7-9133-D777BE46A656","@@gv_ActivityMapId","#growid"");

if((resultE12571F81F5945ED9BC6BAF0AA62F4F0!=null) && (resultE12571F81F5945ED9BC6BAF0AA62F4F0.Count!=0))
{
if(resultE12571F81F5945ED9BC6BAF0AA62F4F0.ContainsKey(3))
ISpace["MFG_P2_BillDate"].Value = resultE12571F81F5945ED9BC6BAF0AA62F4F0[3];
if(resultE12571F81F5945ED9BC6BAF0AA62F4F0.ContainsKey(4))
ISpace["MFG_P2_BillDocument"].Value = resultE12571F81F5945ED9BC6BAF0AA62F4F0[4];
if(resultE12571F81F5945ED9BC6BAF0AA62F4F0.ContainsKey(6))
ISpace["MFG_P2_Amount"].Value = resultE12571F81F5945ED9BC6BAF0AA62F4F0[6];
if(resultE12571F81F5945ED9BC6BAF0AA62F4F0.ContainsKey(5))
ISpace["MFG_P2_ItemDescription"].Value = resultE12571F81F5945ED9BC6BAF0AA62F4F0[5];
if(resultE12571F81F5945ED9BC6BAF0AA62F4F0.ContainsKey(0))
ISpace["MFG_P2_ReimbursementDetailsId"].Value = resultE12571F81F5945ED9BC6BAF0AA62F4F0[0];
if(resultE12571F81F5945ED9BC6BAF0AA62F4F0.ContainsKey(1))
ISpace["MFG_P2_ReimbursementId"].Value = resultE12571F81F5945ED9BC6BAF0AA62F4F0[1];
if(resultE12571F81F5945ED9BC6BAF0AA62F4F0.ContainsKey(2))
ISpace["MFG_P2_BillNo"].Value = resultE12571F81F5945ED9BC6BAF0AA62F4F0[2];
}
else{
ISpace["MFG_P2_BillDate"].Value = null;ISpace["MFG_P2_BillDocument"].Value = null;ISpace["MFG_P2_Amount"].Value = null;ISpace["MFG_P2_ItemDescription"].Value = null;ISpace["MFG_P2_ReimbursementDetailsId"].Value = null;ISpace["MFG_P2_ReimbursementId"].Value = null;ISpace["MFG_P2_BillNo"].Value = null;
}
ISpace["growid"].Value=ISpace["ReimbursementBillDetails_RowId"].Value;
base.WriteDebugInfo(@"ISpace[""growid""].Value=ISpace[""ReimbursementBillDetails_RowId""].Value;");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_save_reimbursementfunddetails (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Save_ReimbursementFundDetails-OnClick");
if(ISpace["MFG_P3_FundTypeId"].Value=="1")
{
base.WriteDebugInfo(@"if(ISpace[""MFG_P3_FundTypeId""].Value==""1"")");
base.WriteDebugInfo(@"#ReimbursementFundDetails[Rows]");
iSpace.GetLoopExpressionData("ReimbursementFundDetails",ref ISpace);

foreach(var gridChild in ISpace["ReimbursementFundDetails"].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 


if(


ISpace["growid"].Value!=ISpace["ReimbursementFundDetails_RowId"].Value||ISpace["growid"].Value=="")
{
base.WriteDebugInfo(@"
if(


ISpace[""growid""].Value!=ISpace[""ReimbursementFundDetails_RowId""].Value||ISpace[""growid""].Value=="""")");
if(ISpace["MFG_P3_BudgetHeadId"].Value==ISpace["MG_P3_BudgetHeadId"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MFG_P3_BudgetHeadId""].Value==ISpace[""MG_P3_BudgetHeadId""].Value)");
ISpace["Message"].Value=@"Budget Head is already Exists";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Budget Head is already Exists"";");
ISpace["MFG_P3_BudgetHeadId"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_P3_BudgetHeadId""].Value="""";");
return;
base.WriteDebugInfo(@"return;");
}
}
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("ReimbursementFundDetails","00D69CC2-E6EC-4412-B2A9-14E57A96FB5C",_objectFactory.GetGridRPP("ReimbursementFundDetails"),_elementBase.GetGridLoopQuery("00D69CC2-E6EC-4412-B2A9-14E57A96FB5C","ReimbursementFundDetails",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""ReimbursementFundDetails"",ref ISpace);

foreach(var gridChild in ISpace[""ReimbursementFundDetails""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
}
if(ISpace["growid"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""growid""].Value=="""")");

var querySourceC5471BC38ECA4216A66F923825C32508 =GetQueryExpressionDataSource("C5471BC3-8ECA-4216-A66F-923825C32508");

DataTable resultC5471BC38ECA4216A66F923825C32508=iSpace.SetGridDataSource(querySourceC5471BC38ECA4216A66F923825C32508, _objectFactory.GetGridRPP("ReimbursementFundDetails"),@"EXEC AddFormGridData1112A274004543D393C5205DAEFEA917 "" + ISpace["gv_instanceid"].Value + @"","" + ISpace["gv_processmapid"].Value + @"","1112A274-0045-43D3-93C5-205DAEFEA917","" + ISpace["gv_activitymapid"].Value + @"","" + ISpace["MFG_P3_FundDetailsId"].Value + @"","" + ISpace["M_Advanceformid"].Value + @"","" + ISpace["MFG_P3_FundTypeId"].Value + @"","" + ISpace["MFG_P3_ProjectDetailsId"].Value + @"","" + ISpace["MFG_P3_BudgetHeadId"].Value + @""," + ISpace["MFG_P3_Amount"].Value + @","" + ISpace["growid"].Value + @""");

iSpace.InsertGridBindDetails("ReimbursementFundDetails","11",querySourceC5471BC38ECA4216A66F923825C32508,"EXEC AddFormGridData1112A274004543D393C5205DAEFEA917 "" + ISpace["gv_instanceid"].Value + @"","" + ISpace["gv_processmapid"].Value + @"","1112A274-0045-43D3-93C5-205DAEFEA917","" + ISpace["gv_activitymapid"].Value + @"","" + ISpace["MFG_P3_FundDetailsId"].Value + @"","" + ISpace["M_Advanceformid"].Value + @"","" + ISpace["MFG_P3_FundTypeId"].Value + @"","" + ISpace["MFG_P3_ProjectDetailsId"].Value + @"","" + ISpace["MFG_P3_BudgetHeadId"].Value + @""," + ISpace["MFG_P3_Amount"].Value + @","" + ISpace["growid"].Value + @""",_objectFactory.GetGridRPP("ReimbursementFundDetails"));

base.WriteDebugInfo(@"var querySourceC5471BC38ECA4216A66F923825C32508 =GetQueryExpressionDataSource(""C5471BC3-8ECA-4216-A66F-923825C32508"");DataTable resultC5471BC38ECA4216A66F923825C32508=iSpace.SetGridDataSource(querySourceC5471BC38ECA4216A66F923825C32508, _objectFactory.GetGridRPP(""ReimbursementFundDetails""),@""EXEC AddFormGridData1112A274004543D393C5205DAEFEA917 """" + ISpace[""gv_instanceid""].Value + @"""","""" + ISpace[""gv_processmapid""].Value + @"""",""1112A274-0045-43D3-93C5-205DAEFEA917"","""" + ISpace[""gv_activitymapid""].Value + @"""","""" + ISpace[""MFG_P3_FundDetailsId""].Value + @"""","""" + ISpace[""M_Advanceformid""].Value + @"""","""" + ISpace[""MFG_P3_FundTypeId""].Value + @"""","""" + ISpace[""MFG_P3_ProjectDetailsId""].Value + @"""","""" + ISpace[""MFG_P3_BudgetHeadId""].Value + @"""","" + ISpace[""MFG_P3_Amount""].Value + @"","""" + ISpace[""growid""].Value + @"""""");iSpace.InsertGridBindDetails(""ReimbursementFundDetails"",""11"",querySourceC5471BC38ECA4216A66F923825C32508,""EXEC AddFormGridData1112A274004543D393C5205DAEFEA917 """" + ISpace[""gv_instanceid""].Value + @"""","""" + ISpace[""gv_processmapid""].Value + @"""",""1112A274-0045-43D3-93C5-205DAEFEA917"","""" + ISpace[""gv_activitymapid""].Value + @"""","""" + ISpace[""MFG_P3_FundDetailsId""].Value + @"""","""" + ISpace[""M_Advanceformid""].Value + @"""","""" + ISpace[""MFG_P3_FundTypeId""].Value + @"""","""" + ISpace[""MFG_P3_ProjectDetailsId""].Value + @"""","""" + ISpace[""MFG_P3_BudgetHeadId""].Value + @"""","" + ISpace[""MFG_P3_Amount""].Value + @"","""" + ISpace[""growid""].Value + @"""""",_objectFactory.GetGridRPP(""ReimbursementFundDetails""));");
base.WriteDebugInfo(@"EXEC AddFormGridDataD85301F7BAF94BE8A2B174E5CBB3D054 "@@gv_InstanceId","@@gv_ProcessMapId","D85301F7-BAF9-4BE8-A2B1-74E5CBB3D054","@@gv_ActivityMapId","#MFG_P3_FundDetailsId","#MFG_P3_ReimbursementId","#MFG_P3_FundTypeId","#MFG_P3_ProjectDetailsId","#MFG_P3_BudgetHeadId",#MFG_P3_Amount,"#growid"");


List<Triplet<string, short, short?>> result169C69C3949245478D79196C3E1309FB=acdataIspace9FE779D2129C47A2B87D173C6AFE51CB.GetQueryExpressionBindings("169C69C3-9492-4547-8D79-196C3E1309FB");
iSpace.SetGridData(resultC5471BC38ECA4216A66F923825C32508,result169C69C3949245478D79196C3E1309FB,"ReimbursementFundDetails",ref ISpace);
iSpace.UpdateGridBindDetails("ReimbursementFundDetails",result169C69C3949245478D79196C3E1309FB);
}
else
{
base.WriteDebugInfo(@"else");

var querySourceA8D19C29F512446883DE4C86EF7F0E8F =GetQueryExpressionDataSource("A8D19C29-F512-4468-83DE-4C86EF7F0E8F");

DataTable resultA8D19C29F512446883DE4C86EF7F0E8F=iSpace.SetGridDataSource(querySourceA8D19C29F512446883DE4C86EF7F0E8F, _objectFactory.GetGridRPP("ReimbursementFundDetails"),@"EXEC UpdateFormGridData1112A274004543D393C5205DAEFEA917 "" + ISpace["gv_instanceid"].Value + @"","" + ISpace["gv_processmapid"].Value + @"","1112A274-0045-43D3-93C5-205DAEFEA917","" + ISpace["gv_activitymapid"].Value + @"","" + ISpace["MFG_P3_FundDetailsId"].Value + @"","" + ISpace["M_Advanceformid"].Value + @"","" + ISpace["MFG_P3_FundTypeId"].Value + @"","" + ISpace["MFG_P3_ProjectDetailsId"].Value + @"","" + ISpace["MFG_P3_BudgetHeadId"].Value + @""," + ISpace["MFG_P3_Amount"].Value + @","" + ISpace["growid"].Value + @""");

iSpace.InsertGridBindDetails("ReimbursementFundDetails","11",querySourceA8D19C29F512446883DE4C86EF7F0E8F,"EXEC UpdateFormGridData1112A274004543D393C5205DAEFEA917 "" + ISpace["gv_instanceid"].Value + @"","" + ISpace["gv_processmapid"].Value + @"","1112A274-0045-43D3-93C5-205DAEFEA917","" + ISpace["gv_activitymapid"].Value + @"","" + ISpace["MFG_P3_FundDetailsId"].Value + @"","" + ISpace["M_Advanceformid"].Value + @"","" + ISpace["MFG_P3_FundTypeId"].Value + @"","" + ISpace["MFG_P3_ProjectDetailsId"].Value + @"","" + ISpace["MFG_P3_BudgetHeadId"].Value + @""," + ISpace["MFG_P3_Amount"].Value + @","" + ISpace["growid"].Value + @""",_objectFactory.GetGridRPP("ReimbursementFundDetails"));

base.WriteDebugInfo(@"var querySourceA8D19C29F512446883DE4C86EF7F0E8F =GetQueryExpressionDataSource(""A8D19C29-F512-4468-83DE-4C86EF7F0E8F"");DataTable resultA8D19C29F512446883DE4C86EF7F0E8F=iSpace.SetGridDataSource(querySourceA8D19C29F512446883DE4C86EF7F0E8F, _objectFactory.GetGridRPP(""ReimbursementFundDetails""),@""EXEC UpdateFormGridData1112A274004543D393C5205DAEFEA917 """" + ISpace[""gv_instanceid""].Value + @"""","""" + ISpace[""gv_processmapid""].Value + @"""",""1112A274-0045-43D3-93C5-205DAEFEA917"","""" + ISpace[""gv_activitymapid""].Value + @"""","""" + ISpace[""MFG_P3_FundDetailsId""].Value + @"""","""" + ISpace[""M_Advanceformid""].Value + @"""","""" + ISpace[""MFG_P3_FundTypeId""].Value + @"""","""" + ISpace[""MFG_P3_ProjectDetailsId""].Value + @"""","""" + ISpace[""MFG_P3_BudgetHeadId""].Value + @"""","" + ISpace[""MFG_P3_Amount""].Value + @"","""" + ISpace[""growid""].Value + @"""""");iSpace.InsertGridBindDetails(""ReimbursementFundDetails"",""11"",querySourceA8D19C29F512446883DE4C86EF7F0E8F,""EXEC UpdateFormGridData1112A274004543D393C5205DAEFEA917 """" + ISpace[""gv_instanceid""].Value + @"""","""" + ISpace[""gv_processmapid""].Value + @"""",""1112A274-0045-43D3-93C5-205DAEFEA917"","""" + ISpace[""gv_activitymapid""].Value + @"""","""" + ISpace[""MFG_P3_FundDetailsId""].Value + @"""","""" + ISpace[""M_Advanceformid""].Value + @"""","""" + ISpace[""MFG_P3_FundTypeId""].Value + @"""","""" + ISpace[""MFG_P3_ProjectDetailsId""].Value + @"""","""" + ISpace[""MFG_P3_BudgetHeadId""].Value + @"""","" + ISpace[""MFG_P3_Amount""].Value + @"","""" + ISpace[""growid""].Value + @"""""",_objectFactory.GetGridRPP(""ReimbursementFundDetails""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> resultBDF250C27A244A8EB094E340FDE4659C=acdataIspace9FE779D2129C47A2B87D173C6AFE51CB.GetQueryExpressionBindings("BDF250C2-7A24-4A8E-B094-E340FDE4659C");
iSpace.SetGridData(resultA8D19C29F512446883DE4C86EF7F0E8F,resultBDF250C27A244A8EB094E340FDE4659C,"ReimbursementFundDetails",ref ISpace);
iSpace.UpdateGridBindDetails("ReimbursementFundDetails",resultBDF250C27A244A8EB094E340FDE4659C);
}
base.WriteDebugInfo(@"#ReimbursementFundDetails[Rows]");
iSpace.GetLoopExpressionData("ReimbursementFundDetails",ref ISpace);

foreach(var gridChild in ISpace["ReimbursementFundDetails"].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 



ISpace["MG_P3_Employeebasicinfoid"].Value=ISpace["UC_EmployeeBaicInfoId"].Value;
base.WriteDebugInfo(@"

ISpace[""MG_P3_Employeebasicinfoid""].Value=ISpace[""UC_EmployeeBaicInfoId""].Value;");


ISpace["MG_P3_Packageprocessmapid"].Value=ISpace["M_PackageProcessMapId"].Value;
base.WriteDebugInfo(@"

ISpace[""MG_P3_Packageprocessmapid""].Value=ISpace[""M_PackageProcessMapId""].Value;");
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("ReimbursementFundDetails","00D69CC2-E6EC-4412-B2A9-14E57A96FB5C",_objectFactory.GetGridRPP("ReimbursementFundDetails"),_elementBase.GetGridLoopQuery("00D69CC2-E6EC-4412-B2A9-14E57A96FB5C","ReimbursementFundDetails",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""ReimbursementFundDetails"",ref ISpace);

foreach(var gridChild in ISpace[""ReimbursementFundDetails""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
object MG_P3_Amount=iSpace.Sum("[00D69CC2-E6EC-4412-B2A9-14E57A96FB5C]","MG_P3_Amount","");
ISpace["MFG_P3_OverallAmount"].Value=Convert.ChangeType(MG_P3_Amount, MG_P3_Amount.GetType());;
base.WriteDebugInfo(@"object MG_P3_Amount=iSpace.Sum(""[00D69CC2-E6EC-4412-B2A9-14E57A96FB5C]"",""MG_P3_Amount"","""");
ISpace[""MFG_P3_OverallAmount""].Value=Convert.ChangeType(MG_P3_Amount, MG_P3_Amount.GetType());;");
ISpace["growid"].Value="";
base.WriteDebugInfo(@"ISpace[""growid""].Value="""";");
ISpace["MFG_P3_FundDetailsId"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_P3_FundDetailsId""].Value="""";");
ISpace["MFG_P3_ReimbursementId"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_P3_ReimbursementId""].Value="""";");
ISpace["MFG_P3_FundTypeId"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_P3_FundTypeId""].Value="""";");
ISpace["MFG_P3_ProjectDetailsId"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_P3_ProjectDetailsId""].Value="""";");
ISpace["MFG_P3_BudgetHeadId"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_P3_BudgetHeadId""].Value="""";");
ISpace["MFG_P3_Amount"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_P3_Amount""].Value="""";");
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
		if(elementName.ToLower().Equals("m_moveto"))
    {
    			SubscribeElementEvents_m_moveto(ref dfsParam);
    }
}
	if(methodName.ToLower().Equals("onclick"))
{
		if(elementName.ToLower().Equals("submitform"))
{
			SubscribeElementEvents_submitform(ref dfsParam);
}
		if(elementName.ToLower().Equals("save_reimbursementbilldetails"))
{
			SubscribeElementEvents_save_reimbursementbilldetails(ref dfsParam);
}
		if(elementName.ToLower().Equals("edit_reimbursementfunddetails"))
{
			SubscribeElementEvents_edit_reimbursementfunddetails(ref dfsParam);
}
		if(elementName.ToLower().Equals("edit_reimbursementbilldetails"))
{
			SubscribeElementEvents_edit_reimbursementbilldetails(ref dfsParam);
}
		if(elementName.ToLower().Equals("save_reimbursementfunddetails"))
{
			SubscribeElementEvents_save_reimbursementfunddetails(ref dfsParam);
}
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
public class ISpace69B6AE86D2BA40489EE6B4627B21F951 : VirtualForm
{
IISpace iSpace = new ISpace();
AcDataISpace69B6AE86D2BA40489EE6B4627B21F951 acdataIspace69B6AE86D2BA40489EE6B4627B21F951=new AcDataISpace69B6AE86D2BA40489EE6B4627B21F951();
private void SubscribeFormEvents_root(ref Dictionary<string, ServiceElementData> ISpace)
{
try
{
base.WriteDebugInfo(@"Root-OnAfterFormLoad");
ISpace["M_SourceActivityMapId"].Value=ISpace["gv_activitymapid"].Value;
base.WriteDebugInfo(@"ISpace[""M_SourceActivityMapId""].Value=ISpace[""gv_activitymapid""].Value;");
ISpace["M_PackageProcessMapId"].Value=ISpace["gv_processmapid"].Value;
base.WriteDebugInfo(@"ISpace[""M_PackageProcessMapId""].Value=ISpace[""gv_processmapid""].Value;");
ISpace["M_InstanceId"].Value=ISpace["gv_instanceid"].Value;
base.WriteDebugInfo(@"ISpace[""M_InstanceId""].Value=ISpace[""gv_instanceid""].Value;");
ISpace["M_IsSourceStep"].Value=0;
base.WriteDebugInfo(@"ISpace[""M_IsSourceStep""].Value=0;");


ISpace["M_MoveTo"].Man=true;
base.WriteDebugInfo(@"ISpace[""M_MoveTo""].Man=true;");
ISpace["MF_P1_Remarks"].Value="";
base.WriteDebugInfo(@"ISpace[""MF_P1_Remarks""].Value="""";");
ISpace["M_NextStage"].Value="";
base.WriteDebugInfo(@"ISpace[""M_NextStage""].Value="""";");

var querySource8BBB2BE71E8540E59B13CC03C350EAB8 =GetQueryExpressionDataSource("8BBB2BE7-1E85-40E5-9B13-CC03C350EAB8");

DataTable result8BBB2BE71E8540E59B13CC03C350EAB8=iSpace.SetGridDataSource(querySource8BBB2BE71E8540E59B13CC03C350EAB8, _objectFactory.GetGridRPP("MG_RemarksDetails"),@"EXEC GetRemarks "" + ISpace["M_InstanceId"].Value + @""");

iSpace.InsertGridBindDetails("MG_RemarksDetails","11",querySource8BBB2BE71E8540E59B13CC03C350EAB8,"EXEC GetRemarks "" + ISpace["M_InstanceId"].Value + @""",_objectFactory.GetGridRPP("MG_RemarksDetails"));

base.WriteDebugInfo(@"var querySource8BBB2BE71E8540E59B13CC03C350EAB8 =GetQueryExpressionDataSource(""8BBB2BE7-1E85-40E5-9B13-CC03C350EAB8"");DataTable result8BBB2BE71E8540E59B13CC03C350EAB8=iSpace.SetGridDataSource(querySource8BBB2BE71E8540E59B13CC03C350EAB8, _objectFactory.GetGridRPP(""MG_RemarksDetails""),@""EXEC GetRemarks """" + ISpace[""M_InstanceId""].Value + @"""""");iSpace.InsertGridBindDetails(""MG_RemarksDetails"",""11"",querySource8BBB2BE71E8540E59B13CC03C350EAB8,""EXEC GetRemarks """" + ISpace[""M_InstanceId""].Value + @"""""",_objectFactory.GetGridRPP(""MG_RemarksDetails""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> resultCA798124C2C446CCBDA6419353320A96=acdataIspace69B6AE86D2BA40489EE6B4627B21F951.GetQueryExpressionBindings("CA798124-C2C4-46CC-BDA6-419353320A96");
iSpace.SetGridData(result8BBB2BE71E8540E59B13CC03C350EAB8,resultCA798124C2C446CCBDA6419353320A96,"MG_RemarksDetails",ref ISpace);
iSpace.UpdateGridBindDetails("MG_RemarksDetails",resultCA798124C2C446CCBDA6419353320A96);
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_submitform (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"SubmitForm-OnClick");
base.WriteDebugInfo(@"Entering DomainDataMap for Remarks Domain");
var RemarksDomain_repoObj = new RepositoryMapper(DbTypes.SQLServer);


var ActivityTrailLogDetailsRemarksDomaintableObj = new RepositoryTable("ActivityTrailLogDetails");
  ActivityTrailLogDetailsRemarksDomaintableObj.AppConnectionSettingsId  ="9ADED37B-CD11-426B-AF16-DEAC75685EF5";ActivityTrailLogDetailsRemarksDomaintableObj.ProofConnectionId = "C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0)";
var RemarksDomain_ActivityTrailLogDetails_rows = GetElementClientData(ISpace["InstanceId"].Value,"6B463D69-64AB-468E-B2E3-DB12E6B90014");

if(RemarksDomain_ActivityTrailLogDetails_rows!=null && RemarksDomain_ActivityTrailLogDetails_rows.Count>0){
var RemarksDomain_ActivityTrailLogDetails_rowsObj = new List<RepositoryRow>();
foreach(var rows in RemarksDomain_ActivityTrailLogDetails_rows){RepositoryRow repositoryRowObj = null;string elementData = null;RepositoryColumn repositoryColumnObj = null;if(rows !=null){ var ActivityTrailLogDetails_colObj = new List<RepositoryColumn>();repositoryRowObj= new RepositoryRow();//var myByte = (byte)rowData.Value.RwSt;//repositoryRowObj.RowState=(RepositoryRowState)myByte;

if(rows.ContainsKey("5354760A-9EAC-491E-BAB1-C3614187A9BE"))     elementData = rows["5354760A-9EAC-491E-BAB1-C3614187A9BE"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ProcessedInProgressFlag",false,false,5);
if(repositoryColumnObj!=null)ActivityTrailLogDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-M_IsSourceStep not found");}

elementData = CurrentDate().ToString() ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Updatedon",false,false,8);
if(repositoryColumnObj!=null)ActivityTrailLogDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-CurrentDate not found");}

if(rows.ContainsKey("D7BB255E-9A01-4B5B-AE06-CC4D6E088D52"))     elementData = rows["D7BB255E-9A01-4B5B-AE06-CC4D6E088D52"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"InstanceID",false,false,9);
if(repositoryColumnObj!=null)ActivityTrailLogDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-M_InstanceId not found");}

elementData = ISpace["gv_UserId"].Value != null? Convert.ToString(ISpace["gv_UserId"].Value):null ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Updatedby",false,false,6);
if(repositoryColumnObj!=null)ActivityTrailLogDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-gv_UserId not found");}

if(rows.ContainsKey("6DB9BC45-F167-4D8A-9596-1DBA9872F253"))     elementData = rows["6DB9BC45-F167-4D8A-9596-1DBA9872F253"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"DestinationActivityMapID",false,false,9);
if(repositoryColumnObj!=null)ActivityTrailLogDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-M_DestinationActivityId not found");}

elementData = ISpace["gv_UserName"].Value != null? Convert.ToString(ISpace["gv_UserName"].Value):null ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"RemarksBy",false,false,9);
if(repositoryColumnObj!=null)ActivityTrailLogDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-gv_UserName not found");}

elementData = ISpace["gv_ActivityName"].Value != null? Convert.ToString(ISpace["gv_ActivityName"].Value):null ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ActivityName",false,false,9);
if(repositoryColumnObj!=null)ActivityTrailLogDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-gv_ActivityName not found");}

if(rows.ContainsKey("F78328FF-68D9-45E9-BC40-27CD650C9D6C"))     elementData = rows["F78328FF-68D9-45E9-BC40-27CD650C9D6C"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Remarks",false,false,9);
if(repositoryColumnObj!=null)ActivityTrailLogDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MF_P1_Remarks not found");}

elementData = ISpace["gv_TenantId"].Value != null? Convert.ToString(ISpace["gv_TenantId"].Value):null ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"TenantID",false,false,9);
if(repositoryColumnObj!=null)ActivityTrailLogDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-gv_TenantId not found");}

elementData = Guid.NewGuid().ToString();if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"TrailLogId",true,false,9);
if(repositoryColumnObj!=null)ActivityTrailLogDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-GUID not found");}

if(rows.ContainsKey("52A564C4-B656-4F43-B6F3-E592002351F6"))     elementData = rows["52A564C4-B656-4F43-B6F3-E592002351F6"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"SourceActivityMapID",false,false,9);
if(repositoryColumnObj!=null)ActivityTrailLogDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-M_SourceActivityMapId not found");}

elementData = CurrentDate().ToString() ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"RemarksOn",false,false,8);
if(repositoryColumnObj!=null)ActivityTrailLogDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-CurrentDate not found");}
repositoryRowObj.Columns=ActivityTrailLogDetails_colObj;
RemarksDomain_ActivityTrailLogDetails_rowsObj.Add(repositoryRowObj);
}}

ActivityTrailLogDetailsRemarksDomaintableObj.Rows=RemarksDomain_ActivityTrailLogDetails_rowsObj;
var RemarksDomain_repoObj_status_ActivityTrailLogDetails = RemarksDomain_repoObj.Execute(DomainOperationTypes.CreateOrUpdate,ref ActivityTrailLogDetailsRemarksDomaintableObj);if(!RemarksDomain_repoObj_status_ActivityTrailLogDetails) throw new Exception("Error in Execute Domain Data Map");}
base.WriteDebugInfo(@"Exiting DomainDataMap for Remarks Domain");
if(IsNullOrEmpty(ISpace["Declaration"].Value))
{
base.WriteDebugInfo(@"if(IsNullOrEmpty(ISpace[""Declaration""].Value))");
ISpace["Message"].Value=@"Select the declaration";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Select the declaration"";");
return;
base.WriteDebugInfo(@"return;");
}
if(ISpace["M_SaveDomainData"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""M_SaveDomainData""].Value==1)");
ISpace["MF_P1_ApplicationStatus"].Value="A";
base.WriteDebugInfo(@"ISpace[""MF_P1_ApplicationStatus""].Value=""A"";");
}
if(ISpace["M_SaveDomainData"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""M_SaveDomainData""].Value==1)");
base.WriteDebugInfo(@"Entering DomainDataMap for Project Advance Details REPO 1");
var ProjectAdvanceDetailsREPO1_repoObj = new RepositoryMapper(DbTypes.SQLServer);


var ProjectAdvanceFormProjectAdvanceDetailsREPO1tableObj = new RepositoryTable("ProjectAdvanceForm");
  ProjectAdvanceFormProjectAdvanceDetailsREPO1tableObj.AppConnectionSettingsId  ="3A103712-5244-4427-B2B6-1C4E046FD337";ProjectAdvanceFormProjectAdvanceDetailsREPO1tableObj.ProofConnectionId = "C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0)";
var ProjectAdvanceDetailsREPO1_ProjectAdvanceForm_rows = GetElementClientData(ISpace["InstanceId"].Value,"6B463D69-64AB-468E-B2E3-DB12E6B90014");

if(ProjectAdvanceDetailsREPO1_ProjectAdvanceForm_rows!=null && ProjectAdvanceDetailsREPO1_ProjectAdvanceForm_rows.Count>0){
var ProjectAdvanceDetailsREPO1_ProjectAdvanceForm_rowsObj = new List<RepositoryRow>();
foreach(var rows in ProjectAdvanceDetailsREPO1_ProjectAdvanceForm_rows){RepositoryRow repositoryRowObj = null;string elementData = null;RepositoryColumn repositoryColumnObj = null;if(rows !=null){ var ProjectAdvanceForm_colObj = new List<RepositoryColumn>();repositoryRowObj= new RepositoryRow();//var myByte = (byte)rowData.Value.RwSt;//repositoryRowObj.RowState=(RepositoryRowState)myByte;

if(rows.ContainsKey("72A0167C-47E6-4BBA-964A-D18B4C2724BE"))     elementData = rows["72A0167C-47E6-4BBA-964A-D18B4C2724BE"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"AdvanceFormId",true,false,9);
if(repositoryColumnObj!=null)ProjectAdvanceForm_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-M_Advanceformid not found");}

elementData = ISpace["gv_UserName"].Value != null? Convert.ToString(ISpace["gv_UserName"].Value):null ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"InitatedBy",false,false,9);
if(repositoryColumnObj!=null)ProjectAdvanceForm_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-gv_UserName not found");}

elementData = ISpace["gv_UserName"].Value != null? Convert.ToString(ISpace["gv_UserName"].Value):null ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"UpdatedBy",false,false,9);
if(repositoryColumnObj!=null)ProjectAdvanceForm_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-gv_UserName not found");}

if(rows.ContainsKey("16BFBC4B-9CB5-4677-AAE8-85CE6C7260E5"))     elementData = rows["16BFBC4B-9CB5-4677-AAE8-85CE6C7260E5"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ApplicationStatus",false,false,9);
if(repositoryColumnObj!=null)ProjectAdvanceForm_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MF_P1_ApplicationStatus not found");}

if(rows.ContainsKey("329D5240-1DBD-433E-A8EB-0F29F5AA668C"))     elementData = rows["329D5240-1DBD-433E-A8EB-0F29F5AA668C"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"EmployeeBasicInfoId",false,false,9);
if(repositoryColumnObj!=null)ProjectAdvanceForm_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-UC_EmployeeBaicInfoId not found");}

if(rows.ContainsKey("68A2EC13-D240-4EBC-8828-E795581544DA"))     elementData = rows["68A2EC13-D240-4EBC-8828-E795581544DA"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"TotalAmount",false,false,3);
if(repositoryColumnObj!=null)ProjectAdvanceForm_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MF_P1_TotalAmount not found");}

elementData = CurrentDate().ToString() ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Initiatedon",false,false,8);
if(repositoryColumnObj!=null)ProjectAdvanceForm_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-CurrentDate not found");}

elementData = CurrentDate().ToString() ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"UpdatedOn",false,false,8);
if(repositoryColumnObj!=null)ProjectAdvanceForm_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-CurrentDate not found");}
repositoryRowObj.Columns=ProjectAdvanceForm_colObj;
ProjectAdvanceDetailsREPO1_ProjectAdvanceForm_rowsObj.Add(repositoryRowObj);
}}

ProjectAdvanceFormProjectAdvanceDetailsREPO1tableObj.Rows=ProjectAdvanceDetailsREPO1_ProjectAdvanceForm_rowsObj;
var ProjectAdvanceDetailsREPO1_repoObj_status_ProjectAdvanceForm = ProjectAdvanceDetailsREPO1_repoObj.Execute(DomainOperationTypes.CreateOrUpdate,ref ProjectAdvanceFormProjectAdvanceDetailsREPO1tableObj);if(!ProjectAdvanceDetailsREPO1_repoObj_status_ProjectAdvanceForm) throw new Exception("Error in Execute Domain Data Map");}
base.WriteDebugInfo(@"Exiting DomainDataMap for Project Advance Details REPO 1");
base.WriteDebugInfo(@"Entering DomainDataMap for Project Advance Details REPO 2");
var ProjectAdvanceDetailsREPO2_repoObj = new RepositoryMapper(DbTypes.SQLServer);


var ProjectAdvanceFundDetailsProjectAdvanceDetailsREPO2tableObj = new RepositoryTable("ProjectAdvanceFundDetails");
  ProjectAdvanceFundDetailsProjectAdvanceDetailsREPO2tableObj.AppConnectionSettingsId  ="3A103712-5244-4427-B2B6-1C4E046FD337";ProjectAdvanceFundDetailsProjectAdvanceDetailsREPO2tableObj.ProofConnectionId = "C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0)";
var ProjectAdvanceDetailsREPO2_ProjectAdvanceFundDetails_rows = GetElementClientData(ISpace["InstanceId"].Value,"00D69CC2-E6EC-4412-B2A9-14E57A96FB5C");

if(ProjectAdvanceDetailsREPO2_ProjectAdvanceFundDetails_rows!=null && ProjectAdvanceDetailsREPO2_ProjectAdvanceFundDetails_rows.Count>0){
var ProjectAdvanceDetailsREPO2_ProjectAdvanceFundDetails_rowsObj = new List<RepositoryRow>();
foreach(var rows in ProjectAdvanceDetailsREPO2_ProjectAdvanceFundDetails_rows){RepositoryRow repositoryRowObj = null;string elementData = null;RepositoryColumn repositoryColumnObj = null;if(rows !=null){ var ProjectAdvanceFundDetails_colObj = new List<RepositoryColumn>();repositoryRowObj= new RepositoryRow();//var myByte = (byte)rowData.Value.RwSt;//repositoryRowObj.RowState=(RepositoryRowState)myByte;

if(rows.ContainsKey("E20A9876-034C-49BC-A309-26338AAD45BD"))     elementData = rows["E20A9876-034C-49BC-A309-26338AAD45BD"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"AdvanceFormId",false,false,9);
if(repositoryColumnObj!=null)ProjectAdvanceFundDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MG_P3_Advanceformid not found");}

if(rows.ContainsKey("B24F329A-C286-4040-ABD2-B67B5AE4F7BE"))     elementData = rows["B24F329A-C286-4040-ABD2-B67B5AE4F7BE"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"FundDetailsId",true,false,9);
if(repositoryColumnObj!=null)ProjectAdvanceFundDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MG_P3_FundDetailsId not found");}

if(rows.ContainsKey("4F81555E-3503-43B3-AD28-23293B41E926"))     elementData = rows["4F81555E-3503-43B3-AD28-23293B41E926"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ProjectDetailsId",false,false,9);
if(repositoryColumnObj!=null)ProjectAdvanceFundDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MG_P3_ProjectDetailsId not found");}

if(rows.ContainsKey("CCBB2219-451D-4EAE-BA26-1C16A9B0FF7D"))     elementData = rows["CCBB2219-451D-4EAE-BA26-1C16A9B0FF7D"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Amount",false,false,3);
if(repositoryColumnObj!=null)ProjectAdvanceFundDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MG_P3_Amount not found");}

if(rows.ContainsKey("8F687AA1-A6B1-4250-9948-DBAF2D40AB51"))     elementData = rows["8F687AA1-A6B1-4250-9948-DBAF2D40AB51"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"BudgetHeadId",false,false,9);
if(repositoryColumnObj!=null)ProjectAdvanceFundDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MG_P3_BudgetHeadId not found");}

if(rows.ContainsKey("99E459F3-F338-40A6-A1E3-1F7AD7A198CD"))     elementData = rows["99E459F3-F338-40A6-A1E3-1F7AD7A198CD"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"FundTypeId",false,false,6);
if(repositoryColumnObj!=null)ProjectAdvanceFundDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MG_P3_FundTypeId not found");}
repositoryRowObj.Columns=ProjectAdvanceFundDetails_colObj;
ProjectAdvanceDetailsREPO2_ProjectAdvanceFundDetails_rowsObj.Add(repositoryRowObj);
}}

ProjectAdvanceFundDetailsProjectAdvanceDetailsREPO2tableObj.Rows=ProjectAdvanceDetailsREPO2_ProjectAdvanceFundDetails_rowsObj;
var ProjectAdvanceDetailsREPO2_repoObj_status_ProjectAdvanceFundDetails = ProjectAdvanceDetailsREPO2_repoObj.Execute(DomainOperationTypes.CreateOrUpdate,ref ProjectAdvanceFundDetailsProjectAdvanceDetailsREPO2tableObj);if(!ProjectAdvanceDetailsREPO2_repoObj_status_ProjectAdvanceFundDetails) throw new Exception("Error in Execute Domain Data Map");}
base.WriteDebugInfo(@"Exiting DomainDataMap for Project Advance Details REPO 2");
base.WriteDebugInfo(@"Entering DomainDataMap for Project Advance Details REPO 3");
var ProjectAdvanceDetailsREPO3_repoObj = new RepositoryMapper(DbTypes.SQLServer);


var ProjectAdvanceRequestDetailsProjectAdvanceDetailsREPO3tableObj = new RepositoryTable("ProjectAdvanceRequestDetails");
  ProjectAdvanceRequestDetailsProjectAdvanceDetailsREPO3tableObj.AppConnectionSettingsId  ="3A103712-5244-4427-B2B6-1C4E046FD337";ProjectAdvanceRequestDetailsProjectAdvanceDetailsREPO3tableObj.ProofConnectionId = "C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0)";
var ProjectAdvanceDetailsREPO3_ProjectAdvanceRequestDetails_rows = GetElementClientData(ISpace["InstanceId"].Value,"1356A8F2-1947-4667-987D-2EA211B288A3");

if(ProjectAdvanceDetailsREPO3_ProjectAdvanceRequestDetails_rows!=null && ProjectAdvanceDetailsREPO3_ProjectAdvanceRequestDetails_rows.Count>0){
var ProjectAdvanceDetailsREPO3_ProjectAdvanceRequestDetails_rowsObj = new List<RepositoryRow>();
foreach(var rows in ProjectAdvanceDetailsREPO3_ProjectAdvanceRequestDetails_rows){RepositoryRow repositoryRowObj = null;string elementData = null;RepositoryColumn repositoryColumnObj = null;if(rows !=null){ var ProjectAdvanceRequestDetails_colObj = new List<RepositoryColumn>();repositoryRowObj= new RepositoryRow();//var myByte = (byte)rowData.Value.RwSt;//repositoryRowObj.RowState=(RepositoryRowState)myByte;

if(rows.ContainsKey("04D90722-37D7-40B0-96B6-D6CA55ABA8F2"))     elementData = rows["04D90722-37D7-40B0-96B6-D6CA55ABA8F2"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ExpenseDetails",false,false,9);
if(repositoryColumnObj!=null)ProjectAdvanceRequestDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MGA_DetailsofExpenses not found");}

if(rows.ContainsKey("B1EB21F5-30E2-4DB3-B72E-E6BB3E4A1D2B"))     elementData = rows["B1EB21F5-30E2-4DB3-B72E-E6BB3E4A1D2B"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ItemDescription",false,false,9);
if(repositoryColumnObj!=null)ProjectAdvanceRequestDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MGA_Description not found");}

if(rows.ContainsKey("8E8892C8-B328-42D2-A630-B8A2C3C4D26B"))     elementData = rows["8E8892C8-B328-42D2-A630-B8A2C3C4D26B"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Amount",false,false,3);
if(repositoryColumnObj!=null)ProjectAdvanceRequestDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MGA_Amount not found");}

if(rows.ContainsKey("67C65E87-8293-495E-97A2-E7431BF75D69"))     elementData = rows["67C65E87-8293-495E-97A2-E7431BF75D69"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"RequestDetailsId",true,false,9);
if(repositoryColumnObj!=null)ProjectAdvanceRequestDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MGA_RequestDetailsId not found");}

if(rows.ContainsKey("6E5FD9F2-E29C-4922-B6C5-78C591A395A6"))     elementData = rows["6E5FD9F2-E29C-4922-B6C5-78C591A395A6"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"AdvanceFormId",false,false,9);
if(repositoryColumnObj!=null)ProjectAdvanceRequestDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MGA_AdvanceFormId not found");}
repositoryRowObj.Columns=ProjectAdvanceRequestDetails_colObj;
ProjectAdvanceDetailsREPO3_ProjectAdvanceRequestDetails_rowsObj.Add(repositoryRowObj);
}}

ProjectAdvanceRequestDetailsProjectAdvanceDetailsREPO3tableObj.Rows=ProjectAdvanceDetailsREPO3_ProjectAdvanceRequestDetails_rowsObj;
var ProjectAdvanceDetailsREPO3_repoObj_status_ProjectAdvanceRequestDetails = ProjectAdvanceDetailsREPO3_repoObj.Execute(DomainOperationTypes.CreateOrUpdate,ref ProjectAdvanceRequestDetailsProjectAdvanceDetailsREPO3tableObj);if(!ProjectAdvanceDetailsREPO3_repoObj_status_ProjectAdvanceRequestDetails) throw new Exception("Error in Execute Domain Data Map");}
base.WriteDebugInfo(@"Exiting DomainDataMap for Project Advance Details REPO 3");
}
if(ISpace["M_IsflowReturned"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""M_IsflowReturned""].Value==1)");
ISpace["AssignToUser"].Value=ISpace["M_InitiatorUserMapId"].Value;
base.WriteDebugInfo(@"ISpace[""AssignToUser""].Value=ISpace[""M_InitiatorUserMapId""].Value;");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["AssignToUser"].Value="";
base.WriteDebugInfo(@"ISpace[""AssignToUser""].Value="""";");
}
base.WriteDebugInfo(@"#ReimbursementFundDetails[Rows]");
iSpace.GetLoopExpressionData("ReimbursementFundDetails",ref ISpace);

foreach(var gridChild in ISpace["ReimbursementFundDetails"].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 


if(
ISpace["M_IsCancelReject"].Value==1)
{
base.WriteDebugInfo(@"
if(
ISpace[""M_IsCancelReject""].Value==1)");
base.WriteDebugInfo(@"EXEC [UpsertProjectBudgetDetails] 6,"#MG_P3_ProjectDetailsId","","#MG_P3_Amount","#MG_P3_BudgetHeadId",1,"#MG_P3_FundTypeId"");

var querySourceEE0DA86FC2744B2F80388A33B103F110 =GetQueryExpressionDataSource("EE0DA86F-C274-4B2F-8038-8A33B103F110");
Dictionary<short,object> resultEE0DA86FC2744B2F80388A33B103F110=iSpace.ExecuteQuery(querySourceEE0DA86FC2744B2F80388A33B103F110,@"EXEC [UpsertProjectBudgetDetails] 6,"" + ISpace["MG_P3_ProjectDetailsId"].Value + @"","","" + ISpace["MG_P3_Amount"].Value + @"","" + ISpace["MG_P3_BudgetHeadId"].Value + @"",1,"" + ISpace["MG_P3_FundTypeId"].Value + @""",false);

base.WriteDebugInfo(@"var querySourceEE0DA86FC2744B2F80388A33B103F110 =GetQueryExpressionDataSource(""EE0DA86F-C274-4B2F-8038-8A33B103F110"");Dictionary<short,object> resultEE0DA86FC2744B2F80388A33B103F110=iSpace.ExecuteQuery(querySourceEE0DA86FC2744B2F80388A33B103F110,@""EXEC [UpsertProjectBudgetDetails] 6,"""" + ISpace[""MG_P3_ProjectDetailsId""].Value + @"""","""","""" + ISpace[""MG_P3_Amount""].Value + @"""","""" + ISpace[""MG_P3_BudgetHeadId""].Value + @"""",1,"""" + ISpace[""MG_P3_FundTypeId""].Value + @"""""",false);");
base.WriteDebugInfo(@"");

if((resultEE0DA86FC2744B2F80388A33B103F110!=null) && (resultEE0DA86FC2744B2F80388A33B103F110.Count!=0))
{
if(resultEE0DA86FC2744B2F80388A33B103F110.ContainsKey(0))
ISpace["M_UpdateCount"].Value = resultEE0DA86FC2744B2F80388A33B103F110[0];
}
else{
ISpace["M_UpdateCount"].Value = null;
}
}
else
{
base.WriteDebugInfo(@"else");
base.WriteDebugInfo(@"EXEC [UpsertProjectBudgetDetails] 5,"#MG_P3_ProjectDetailsId","","#MG_P3_Amount","#MG_P3_BudgetHeadId",1,"#MG_P3_FundTypeId"");

var querySource27ED5457FD384124AB17A6225151D7BE =GetQueryExpressionDataSource("27ED5457-FD38-4124-AB17-A6225151D7BE");
Dictionary<short,object> result27ED5457FD384124AB17A6225151D7BE=iSpace.ExecuteQuery(querySource27ED5457FD384124AB17A6225151D7BE,@"EXEC [UpsertProjectBudgetDetails] 5,"" + ISpace["MG_P3_ProjectDetailsId"].Value + @"","","" + ISpace["MG_P3_Amount"].Value + @"","" + ISpace["MG_P3_BudgetHeadId"].Value + @"",1,"" + ISpace["MG_P3_FundTypeId"].Value + @""",false);

base.WriteDebugInfo(@"var querySource27ED5457FD384124AB17A6225151D7BE =GetQueryExpressionDataSource(""27ED5457-FD38-4124-AB17-A6225151D7BE"");Dictionary<short,object> result27ED5457FD384124AB17A6225151D7BE=iSpace.ExecuteQuery(querySource27ED5457FD384124AB17A6225151D7BE,@""EXEC [UpsertProjectBudgetDetails] 5,"""" + ISpace[""MG_P3_ProjectDetailsId""].Value + @"""","""","""" + ISpace[""MG_P3_Amount""].Value + @"""","""" + ISpace[""MG_P3_BudgetHeadId""].Value + @"""",1,"""" + ISpace[""MG_P3_FundTypeId""].Value + @"""""",false);");
base.WriteDebugInfo(@"");

if((result27ED5457FD384124AB17A6225151D7BE!=null) && (result27ED5457FD384124AB17A6225151D7BE.Count!=0))
{
if(result27ED5457FD384124AB17A6225151D7BE.ContainsKey(0))
ISpace["M_UpdateCount"].Value = result27ED5457FD384124AB17A6225151D7BE[0];
}
else{
ISpace["M_UpdateCount"].Value = null;
}
}
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("ReimbursementFundDetails","00D69CC2-E6EC-4412-B2A9-14E57A96FB5C",_objectFactory.GetGridRPP("ReimbursementFundDetails"),_elementBase.GetGridLoopQuery("00D69CC2-E6EC-4412-B2A9-14E57A96FB5C","ReimbursementFundDetails",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""ReimbursementFundDetails"",ref ISpace);

foreach(var gridChild in ISpace[""ReimbursementFundDetails""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
if(ISpace["MF_P1_TotalAmount"].Value==0)
{
base.WriteDebugInfo(@"if(ISpace[""MF_P1_TotalAmount""].Value==0)");
ISpace["Message"].Value=@"Overall Bill Amount should not be 0";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Overall Bill Amount should not be 0"";");
return;
base.WriteDebugInfo(@"return;");
}
if(ISpace["MFG_P3_OverallAmount"].Value!=ISpace["MF_P1_TotalAmount"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MFG_P3_OverallAmount""].Value!=ISpace[""MF_P1_TotalAmount""].Value)");
ISpace["Message"].Value=@"Both Overall Fund Amount and Overall Bill Amount should be same";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Both Overall Fund Amount and Overall Bill Amount should be same"";");
return;
base.WriteDebugInfo(@"return;");
}
base.WriteDebugInfo(@"#MG_DcoumentDetails[Rows]");
iSpace.GetLoopExpressionData("MG_DcoumentDetails",ref ISpace);

foreach(var gridChild in ISpace["MG_DcoumentDetails"].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 


if(
ISpace["M_DocumentName"].Value=="")
{
base.WriteDebugInfo(@"
if(
ISpace[""M_DocumentName""].Value=="""")");
ISpace["Message"].Value=@"Document Name should be Mandatory";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Document Name should be Mandatory"";");
return;
base.WriteDebugInfo(@"return;");
}

if(
IsNullOrEmpty(ISpace["M_UploadDcoument"].Value))
{
base.WriteDebugInfo(@"
if(
IsNullOrEmpty(ISpace[""M_UploadDcoument""].Value))");
ISpace["Message"].Value=@"Upload Document should be mandatory";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Upload Document should be mandatory"";");
return;
base.WriteDebugInfo(@"return;");
}
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("MG_DcoumentDetails","744177F0-C5DD-4666-BE31-646818F67196",_objectFactory.GetGridRPP("MG_DcoumentDetails"),_elementBase.GetGridLoopQuery("744177F0-C5DD-4666-BE31-646818F67196","MG_DcoumentDetails",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""MG_DcoumentDetails"",ref ISpace);

foreach(var gridChild in ISpace[""MG_DcoumentDetails""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["M_MoveTo"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""M_MoveTo""].Value=="""")");
ISpace["Message"].Value=@"Move To should be mandatory";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Move To should be mandatory"";");
return;
base.WriteDebugInfo(@"return;");
}
}
if(ISpace["M_SaveDomainData"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""M_SaveDomainData""].Value==1)");
ISpace["M_Status"].Value="Approved";
base.WriteDebugInfo(@"ISpace[""M_Status""].Value=""Approved"";");
}
if(ISpace["M_IsCancelReject"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""M_IsCancelReject""].Value==1)");
ISpace["M_Status"].Value="Dropped";
base.WriteDebugInfo(@"ISpace[""M_Status""].Value=""Dropped"";");
}
base.WriteDebugInfo(@"Entering DomainDataMap for User Request For other steps");
var UserRequestForothersteps_repoObj = new RepositoryMapper(DbTypes.SQLServer);


var UserRequestsUserRequestForotherstepstableObj = new RepositoryTable("UserRequests");
  UserRequestsUserRequestForotherstepstableObj.AppConnectionSettingsId  ="9ADED37B-CD11-426B-AF16-DEAC75685EF5";UserRequestsUserRequestForotherstepstableObj.ProofConnectionId = "C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0)";
var UserRequestForothersteps_UserRequests_rows = GetElementClientData(ISpace["InstanceId"].Value,"6B463D69-64AB-468E-B2E3-DB12E6B90014");

if(UserRequestForothersteps_UserRequests_rows!=null && UserRequestForothersteps_UserRequests_rows.Count>0){
var UserRequestForothersteps_UserRequests_rowsObj = new List<RepositoryRow>();
foreach(var rows in UserRequestForothersteps_UserRequests_rows){RepositoryRow repositoryRowObj = null;string elementData = null;RepositoryColumn repositoryColumnObj = null;if(rows !=null){ var UserRequests_colObj = new List<RepositoryColumn>();repositoryRowObj= new RepositoryRow();//var myByte = (byte)rowData.Value.RwSt;//repositoryRowObj.RowState=(RepositoryRowState)myByte;

if(rows.ContainsKey("34CFB4AA-E9A1-4EAC-83A8-AEC1C4038EE1"))     elementData = rows["34CFB4AA-E9A1-4EAC-83A8-AEC1C4038EE1"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"CurrentLevel",false,false,9);
if(repositoryColumnObj!=null)UserRequests_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-M_NextStage not found");}

if(rows.ContainsKey("B89FF303-5A1C-4060-BAB9-E6F52A11D9FD"))     elementData = rows["B89FF303-5A1C-4060-BAB9-E6F52A11D9FD"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"CurrentStatus",false,false,9);
if(repositoryColumnObj!=null)UserRequests_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-M_Status not found");}

elementData = ISpace["gv_UserId"].Value != null? Convert.ToString(ISpace["gv_UserId"].Value):null ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"LastModifiedByUserID",false,false,5);
if(repositoryColumnObj!=null)UserRequests_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-gv_UserId not found");}

if(rows.ContainsKey("0CDC8D38-F4F4-4C60-BCED-E9F0C8B165B8"))     elementData = rows["0CDC8D38-F4F4-4C60-BCED-E9F0C8B165B8"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"CurrentActivityMapID",false,false,9);
if(repositoryColumnObj!=null)UserRequests_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-SetDestinationTo not found");}

if(rows.ContainsKey("D7BB255E-9A01-4B5B-AE06-CC4D6E088D52"))     elementData = rows["D7BB255E-9A01-4B5B-AE06-CC4D6E088D52"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"InstanceID",true,false,9);
if(repositoryColumnObj!=null)UserRequests_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-M_InstanceId not found");}

elementData = CurrentDate().ToString() ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"LastModifiedOn",false,false,8);
if(repositoryColumnObj!=null)UserRequests_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-CurrentDate not found");}
repositoryRowObj.Columns=UserRequests_colObj;
UserRequestForothersteps_UserRequests_rowsObj.Add(repositoryRowObj);
}}

UserRequestsUserRequestForotherstepstableObj.Rows=UserRequestForothersteps_UserRequests_rowsObj;
var UserRequestForothersteps_repoObj_status_UserRequests = UserRequestForothersteps_repoObj.Execute(DomainOperationTypes.Update,ref UserRequestsUserRequestForotherstepstableObj);if(!UserRequestForothersteps_repoObj_status_UserRequests) throw new Exception("Error in Execute Domain Data Map");}
base.WriteDebugInfo(@"Exiting DomainDataMap for User Request For other steps");
ISpace["Message"].Value=@"Submitted Successfully";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Submitted Successfully"";");
ISpace.ExecuteInstanceCommand("Submit");
base.WriteDebugInfo(@"ISpace.ExecuteInstanceCommand(""Submit"");");
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

var querySourceDF30243A932448659FFF478698865C85 =GetQueryExpressionDataSource("DF30243A-9324-4865-9FFF-478698865C85");

DataTable resultDF30243A932448659FFF478698865C85=iSpace.SetGridDataSource(querySourceDF30243A932448659FFF478698865C85, _objectFactory.GetGridRPP("MG_CommitmentDetails"),@"EXEC GetProjectBudgetInformation "" + ISpace["MF_ProjectNo"].Value + @""");

iSpace.InsertGridBindDetails("MG_CommitmentDetails","11",querySourceDF30243A932448659FFF478698865C85,"EXEC GetProjectBudgetInformation "" + ISpace["MF_ProjectNo"].Value + @""",_objectFactory.GetGridRPP("MG_CommitmentDetails"));

base.WriteDebugInfo(@"var querySourceDF30243A932448659FFF478698865C85 =GetQueryExpressionDataSource(""DF30243A-9324-4865-9FFF-478698865C85"");DataTable resultDF30243A932448659FFF478698865C85=iSpace.SetGridDataSource(querySourceDF30243A932448659FFF478698865C85, _objectFactory.GetGridRPP(""MG_CommitmentDetails""),@""EXEC GetProjectBudgetInformation """" + ISpace[""MF_ProjectNo""].Value + @"""""");iSpace.InsertGridBindDetails(""MG_CommitmentDetails"",""11"",querySourceDF30243A932448659FFF478698865C85,""EXEC GetProjectBudgetInformation """" + ISpace[""MF_ProjectNo""].Value + @"""""",_objectFactory.GetGridRPP(""MG_CommitmentDetails""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> resultD8C74C9B035C46A493E2CAE4FECC1DA7=acdataIspace69B6AE86D2BA40489EE6B4627B21F951.GetQueryExpressionBindings("D8C74C9B-035C-46A4-93E2-CAE4FECC1DA7");
iSpace.SetGridData(resultDF30243A932448659FFF478698865C85,resultD8C74C9B035C46A493E2CAE4FECC1DA7,"MG_CommitmentDetails",ref ISpace);
iSpace.UpdateGridBindDetails("MG_CommitmentDetails",resultD8C74C9B035C46A493E2CAE4FECC1DA7);
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_m_moveto (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"M_MoveTo-OnChange");
ISpace["M_MoveToValue"].Value=ISpace["M_MoveTo"].Value;
base.WriteDebugInfo(@"ISpace[""M_MoveToValue""].Value=ISpace[""M_MoveTo""].Value;");
base.WriteDebugInfo(@"Exec GetStageStatus 1,"","","#M_MoveToValue","#M_SourceActivityMapId"");

var querySource549686A138974AFCA19EC95972C37210 =GetQueryExpressionDataSource("549686A1-3897-4AFC-A19E-C95972C37210");
Dictionary<short,object> result549686A138974AFCA19EC95972C37210=iSpace.ExecuteQuery(querySource549686A138974AFCA19EC95972C37210,@"Exec GetStageStatus 1,"","","" + ISpace["M_MoveToValue"].Value + @"","" + ISpace["M_SourceActivityMapId"].Value + @""",false);

base.WriteDebugInfo(@"var querySource549686A138974AFCA19EC95972C37210 =GetQueryExpressionDataSource(""549686A1-3897-4AFC-A19E-C95972C37210"");Dictionary<short,object> result549686A138974AFCA19EC95972C37210=iSpace.ExecuteQuery(querySource549686A138974AFCA19EC95972C37210,@""Exec GetStageStatus 1,"""","""","""" + ISpace[""M_MoveToValue""].Value + @"""","""" + ISpace[""M_SourceActivityMapId""].Value + @"""""",false);");
base.WriteDebugInfo(@"");

if((result549686A138974AFCA19EC95972C37210!=null) && (result549686A138974AFCA19EC95972C37210.Count!=0))
{
if(result549686A138974AFCA19EC95972C37210.ContainsKey(3))
ISpace["M_SaveDomainData"].Value = result549686A138974AFCA19EC95972C37210[3];
if(result549686A138974AFCA19EC95972C37210.ContainsKey(1))
ISpace["M_RemarksMandatory"].Value = result549686A138974AFCA19EC95972C37210[1];
if(result549686A138974AFCA19EC95972C37210.ContainsKey(4))
ISpace["M_FieldMandatory"].Value = result549686A138974AFCA19EC95972C37210[4];
if(result549686A138974AFCA19EC95972C37210.ContainsKey(2))
ISpace["MF_P1_Remarks"].Value = result549686A138974AFCA19EC95972C37210[2];
if(result549686A138974AFCA19EC95972C37210.ContainsKey(0))
ISpace["M_NextStage"].Value = result549686A138974AFCA19EC95972C37210[0];
}
else{
ISpace["M_SaveDomainData"].Value = null;ISpace["M_RemarksMandatory"].Value = null;ISpace["M_FieldMandatory"].Value = null;ISpace["MF_P1_Remarks"].Value = null;ISpace["M_NextStage"].Value = null;
}
ISpace["SetDestinationTo"].Value=ISpace["M_MoveTo"].Value;
base.WriteDebugInfo(@"ISpace[""SetDestinationTo""].Value=ISpace[""M_MoveTo""].Value;");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_save_reimbursementfunddetails (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Save_ReimbursementFundDetails-OnClick");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(Trim(ISpace["MFG_P3_FundTypeId"].Value)=="")
{
base.WriteDebugInfo(@"if(Trim(ISpace[""MFG_P3_FundTypeId""].Value)=="""")");
ISpace["Message"].Value=@"Please Enter the Fund Type";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please Enter the Fund Type"";");
return;
base.WriteDebugInfo(@"return;");
}
if(ISpace["MFG_P3_FundTypeId"].Value=="1")
{
base.WriteDebugInfo(@"if(ISpace[""MFG_P3_FundTypeId""].Value==""1"")");
if(ISpace["MFG_P3_ProjectDetailsId"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""MFG_P3_ProjectDetailsId""].Value=="""")");
ISpace["Message"].Value=@"Project No should be Mandatory";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Project No should be Mandatory"";");
return;
base.WriteDebugInfo(@"return;");
}
if(ISpace["MFG_P3_BudgetHeadId"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""MFG_P3_BudgetHeadId""].Value=="""")");
ISpace["Message"].Value=@"Budget Head should be mandatory";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Budget Head should be mandatory"";");
return;
base.WriteDebugInfo(@"return;");
}
}
if(ISpace["MFG_P3_Amount"].Value==0)
{
base.WriteDebugInfo(@"if(ISpace[""MFG_P3_Amount""].Value==0)");
ISpace["Message"].Value=@"Please Enter the Amount";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please Enter the Amount"";");
return;
base.WriteDebugInfo(@"return;");
}
base.WriteDebugInfo(@"EXEC [ValidatePaymentFundAvailability] "#MFG_P3_FundTypeId","#MFG_P3_ProjectDetailsId","#MFG_P3_BudgetHeadId","#UC_EmployeeBaicInfoId","#MFG_P3_Amount"");

var querySource07D02D1F066F4E9B8819A44E473F22C2 =GetQueryExpressionDataSource("07D02D1F-066F-4E9B-8819-A44E473F22C2");
Dictionary<short,object> result07D02D1F066F4E9B8819A44E473F22C2=iSpace.ExecuteQuery(querySource07D02D1F066F4E9B8819A44E473F22C2,@"EXEC [ValidatePaymentFundAvailability] "" + ISpace["MFG_P3_FundTypeId"].Value + @"","" + ISpace["MFG_P3_ProjectDetailsId"].Value + @"","" + ISpace["MFG_P3_BudgetHeadId"].Value + @"","" + ISpace["UC_EmployeeBaicInfoId"].Value + @"","" + ISpace["MFG_P3_Amount"].Value + @""",false);

base.WriteDebugInfo(@"var querySource07D02D1F066F4E9B8819A44E473F22C2 =GetQueryExpressionDataSource(""07D02D1F-066F-4E9B-8819-A44E473F22C2"");Dictionary<short,object> result07D02D1F066F4E9B8819A44E473F22C2=iSpace.ExecuteQuery(querySource07D02D1F066F4E9B8819A44E473F22C2,@""EXEC [ValidatePaymentFundAvailability] """" + ISpace[""MFG_P3_FundTypeId""].Value + @"""","""" + ISpace[""MFG_P3_ProjectDetailsId""].Value + @"""","""" + ISpace[""MFG_P3_BudgetHeadId""].Value + @"""","""" + ISpace[""UC_EmployeeBaicInfoId""].Value + @"""","""" + ISpace[""MFG_P3_Amount""].Value + @"""""",false);");
base.WriteDebugInfo(@"");

if((result07D02D1F066F4E9B8819A44E473F22C2!=null) && (result07D02D1F066F4E9B8819A44E473F22C2.Count!=0))
{
if(result07D02D1F066F4E9B8819A44E473F22C2.ContainsKey(0))
ISpace["M_ErrId"].Value = result07D02D1F066F4E9B8819A44E473F22C2[0];
if(result07D02D1F066F4E9B8819A44E473F22C2.ContainsKey(1))
ISpace["M_ErrMsg"].Value = result07D02D1F066F4E9B8819A44E473F22C2[1];
}
else{
ISpace["M_ErrId"].Value = null;ISpace["M_ErrMsg"].Value = null;
}
if(ISpace["M_ErrId"].Value==0)
{
base.WriteDebugInfo(@"if(ISpace[""M_ErrId""].Value==0)");
ISpace["Message"].Value=String.Format(@"{0}",ISpace["M_ErrMsg"].Value);
base.WriteDebugInfo(@"ISpace[""Message""].Value=String.Format(@""{0}"",ISpace[""M_ErrMsg""].Value);");
return;
base.WriteDebugInfo(@"return;");
}
}
if(ISpace["MFG_P3_FundTypeId"].Value=="1")
{
base.WriteDebugInfo(@"if(ISpace[""MFG_P3_FundTypeId""].Value==""1"")");
base.WriteDebugInfo(@"#ReimbursementFundDetails[Rows]");
iSpace.GetLoopExpressionData("ReimbursementFundDetails",ref ISpace);

foreach(var gridChild in ISpace["ReimbursementFundDetails"].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 


if(


ISpace["growid"].Value!=ISpace["ReimbursementFundDetails_RowId"].Value||ISpace["growid"].Value=="")
{
base.WriteDebugInfo(@"
if(


ISpace[""growid""].Value!=ISpace[""ReimbursementFundDetails_RowId""].Value||ISpace[""growid""].Value=="""")");
if(ISpace["MFG_P3_BudgetHeadId"].Value==ISpace["MG_P3_BudgetHeadId"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MFG_P3_BudgetHeadId""].Value==ISpace[""MG_P3_BudgetHeadId""].Value)");
ISpace["Message"].Value=@"Budget Head is already Exists";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Budget Head is already Exists"";");
ISpace["MFG_P3_BudgetHeadId"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_P3_BudgetHeadId""].Value="""";");
return;
base.WriteDebugInfo(@"return;");
}
}
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("ReimbursementFundDetails","00D69CC2-E6EC-4412-B2A9-14E57A96FB5C",_objectFactory.GetGridRPP("ReimbursementFundDetails"),_elementBase.GetGridLoopQuery("00D69CC2-E6EC-4412-B2A9-14E57A96FB5C","ReimbursementFundDetails",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""ReimbursementFundDetails"",ref ISpace);

foreach(var gridChild in ISpace[""ReimbursementFundDetails""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
}
if(ISpace["growid"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""growid""].Value=="""")");

var querySourceC5471BC38ECA4216A66F923825C32508 =GetQueryExpressionDataSource("C5471BC3-8ECA-4216-A66F-923825C32508");

DataTable resultC5471BC38ECA4216A66F923825C32508=iSpace.SetGridDataSource(querySourceC5471BC38ECA4216A66F923825C32508, _objectFactory.GetGridRPP("ReimbursementFundDetails"),@"EXEC AddFormGridData1112A274004543D393C5205DAEFEA917 "" + ISpace["gv_instanceid"].Value + @"","" + ISpace["gv_processmapid"].Value + @"","1112A274-0045-43D3-93C5-205DAEFEA917","" + ISpace["gv_activitymapid"].Value + @"","" + ISpace["MFG_P3_FundDetailsId"].Value + @"","" + ISpace["M_Advanceformid"].Value + @"","" + ISpace["MFG_P3_FundTypeId"].Value + @"","" + ISpace["MFG_P3_ProjectDetailsId"].Value + @"","" + ISpace["MFG_P3_BudgetHeadId"].Value + @""," + ISpace["MFG_P3_Amount"].Value + @","" + ISpace["growid"].Value + @""");

iSpace.InsertGridBindDetails("ReimbursementFundDetails","11",querySourceC5471BC38ECA4216A66F923825C32508,"EXEC AddFormGridData1112A274004543D393C5205DAEFEA917 "" + ISpace["gv_instanceid"].Value + @"","" + ISpace["gv_processmapid"].Value + @"","1112A274-0045-43D3-93C5-205DAEFEA917","" + ISpace["gv_activitymapid"].Value + @"","" + ISpace["MFG_P3_FundDetailsId"].Value + @"","" + ISpace["M_Advanceformid"].Value + @"","" + ISpace["MFG_P3_FundTypeId"].Value + @"","" + ISpace["MFG_P3_ProjectDetailsId"].Value + @"","" + ISpace["MFG_P3_BudgetHeadId"].Value + @""," + ISpace["MFG_P3_Amount"].Value + @","" + ISpace["growid"].Value + @""",_objectFactory.GetGridRPP("ReimbursementFundDetails"));

base.WriteDebugInfo(@"var querySourceC5471BC38ECA4216A66F923825C32508 =GetQueryExpressionDataSource(""C5471BC3-8ECA-4216-A66F-923825C32508"");DataTable resultC5471BC38ECA4216A66F923825C32508=iSpace.SetGridDataSource(querySourceC5471BC38ECA4216A66F923825C32508, _objectFactory.GetGridRPP(""ReimbursementFundDetails""),@""EXEC AddFormGridData1112A274004543D393C5205DAEFEA917 """" + ISpace[""gv_instanceid""].Value + @"""","""" + ISpace[""gv_processmapid""].Value + @"""",""1112A274-0045-43D3-93C5-205DAEFEA917"","""" + ISpace[""gv_activitymapid""].Value + @"""","""" + ISpace[""MFG_P3_FundDetailsId""].Value + @"""","""" + ISpace[""M_Advanceformid""].Value + @"""","""" + ISpace[""MFG_P3_FundTypeId""].Value + @"""","""" + ISpace[""MFG_P3_ProjectDetailsId""].Value + @"""","""" + ISpace[""MFG_P3_BudgetHeadId""].Value + @"""","" + ISpace[""MFG_P3_Amount""].Value + @"","""" + ISpace[""growid""].Value + @"""""");iSpace.InsertGridBindDetails(""ReimbursementFundDetails"",""11"",querySourceC5471BC38ECA4216A66F923825C32508,""EXEC AddFormGridData1112A274004543D393C5205DAEFEA917 """" + ISpace[""gv_instanceid""].Value + @"""","""" + ISpace[""gv_processmapid""].Value + @"""",""1112A274-0045-43D3-93C5-205DAEFEA917"","""" + ISpace[""gv_activitymapid""].Value + @"""","""" + ISpace[""MFG_P3_FundDetailsId""].Value + @"""","""" + ISpace[""M_Advanceformid""].Value + @"""","""" + ISpace[""MFG_P3_FundTypeId""].Value + @"""","""" + ISpace[""MFG_P3_ProjectDetailsId""].Value + @"""","""" + ISpace[""MFG_P3_BudgetHeadId""].Value + @"""","" + ISpace[""MFG_P3_Amount""].Value + @"","""" + ISpace[""growid""].Value + @"""""",_objectFactory.GetGridRPP(""ReimbursementFundDetails""));");
base.WriteDebugInfo(@"EXEC AddFormGridDataD85301F7BAF94BE8A2B174E5CBB3D054 "@@gv_InstanceId","@@gv_ProcessMapId","D85301F7-BAF9-4BE8-A2B1-74E5CBB3D054","@@gv_ActivityMapId","#MFG_P3_FundDetailsId","#MFG_P3_ReimbursementId","#MFG_P3_FundTypeId","#MFG_P3_ProjectDetailsId","#MFG_P3_BudgetHeadId",#MFG_P3_Amount,"#growid"");


List<Triplet<string, short, short?>> result169C69C3949245478D79196C3E1309FB=acdataIspace69B6AE86D2BA40489EE6B4627B21F951.GetQueryExpressionBindings("169C69C3-9492-4547-8D79-196C3E1309FB");
iSpace.SetGridData(resultC5471BC38ECA4216A66F923825C32508,result169C69C3949245478D79196C3E1309FB,"ReimbursementFundDetails",ref ISpace);
iSpace.UpdateGridBindDetails("ReimbursementFundDetails",result169C69C3949245478D79196C3E1309FB);
}
else
{
base.WriteDebugInfo(@"else");

var querySourceA8D19C29F512446883DE4C86EF7F0E8F =GetQueryExpressionDataSource("A8D19C29-F512-4468-83DE-4C86EF7F0E8F");

DataTable resultA8D19C29F512446883DE4C86EF7F0E8F=iSpace.SetGridDataSource(querySourceA8D19C29F512446883DE4C86EF7F0E8F, _objectFactory.GetGridRPP("ReimbursementFundDetails"),@"EXEC UpdateFormGridData1112A274004543D393C5205DAEFEA917 "" + ISpace["gv_instanceid"].Value + @"","" + ISpace["gv_processmapid"].Value + @"","1112A274-0045-43D3-93C5-205DAEFEA917","" + ISpace["gv_activitymapid"].Value + @"","" + ISpace["MFG_P3_FundDetailsId"].Value + @"","" + ISpace["M_Advanceformid"].Value + @"","" + ISpace["MFG_P3_FundTypeId"].Value + @"","" + ISpace["MFG_P3_ProjectDetailsId"].Value + @"","" + ISpace["MFG_P3_BudgetHeadId"].Value + @""," + ISpace["MFG_P3_Amount"].Value + @","" + ISpace["growid"].Value + @""");

iSpace.InsertGridBindDetails("ReimbursementFundDetails","11",querySourceA8D19C29F512446883DE4C86EF7F0E8F,"EXEC UpdateFormGridData1112A274004543D393C5205DAEFEA917 "" + ISpace["gv_instanceid"].Value + @"","" + ISpace["gv_processmapid"].Value + @"","1112A274-0045-43D3-93C5-205DAEFEA917","" + ISpace["gv_activitymapid"].Value + @"","" + ISpace["MFG_P3_FundDetailsId"].Value + @"","" + ISpace["M_Advanceformid"].Value + @"","" + ISpace["MFG_P3_FundTypeId"].Value + @"","" + ISpace["MFG_P3_ProjectDetailsId"].Value + @"","" + ISpace["MFG_P3_BudgetHeadId"].Value + @""," + ISpace["MFG_P3_Amount"].Value + @","" + ISpace["growid"].Value + @""",_objectFactory.GetGridRPP("ReimbursementFundDetails"));

base.WriteDebugInfo(@"var querySourceA8D19C29F512446883DE4C86EF7F0E8F =GetQueryExpressionDataSource(""A8D19C29-F512-4468-83DE-4C86EF7F0E8F"");DataTable resultA8D19C29F512446883DE4C86EF7F0E8F=iSpace.SetGridDataSource(querySourceA8D19C29F512446883DE4C86EF7F0E8F, _objectFactory.GetGridRPP(""ReimbursementFundDetails""),@""EXEC UpdateFormGridData1112A274004543D393C5205DAEFEA917 """" + ISpace[""gv_instanceid""].Value + @"""","""" + ISpace[""gv_processmapid""].Value + @"""",""1112A274-0045-43D3-93C5-205DAEFEA917"","""" + ISpace[""gv_activitymapid""].Value + @"""","""" + ISpace[""MFG_P3_FundDetailsId""].Value + @"""","""" + ISpace[""M_Advanceformid""].Value + @"""","""" + ISpace[""MFG_P3_FundTypeId""].Value + @"""","""" + ISpace[""MFG_P3_ProjectDetailsId""].Value + @"""","""" + ISpace[""MFG_P3_BudgetHeadId""].Value + @"""","" + ISpace[""MFG_P3_Amount""].Value + @"","""" + ISpace[""growid""].Value + @"""""");iSpace.InsertGridBindDetails(""ReimbursementFundDetails"",""11"",querySourceA8D19C29F512446883DE4C86EF7F0E8F,""EXEC UpdateFormGridData1112A274004543D393C5205DAEFEA917 """" + ISpace[""gv_instanceid""].Value + @"""","""" + ISpace[""gv_processmapid""].Value + @"""",""1112A274-0045-43D3-93C5-205DAEFEA917"","""" + ISpace[""gv_activitymapid""].Value + @"""","""" + ISpace[""MFG_P3_FundDetailsId""].Value + @"""","""" + ISpace[""M_Advanceformid""].Value + @"""","""" + ISpace[""MFG_P3_FundTypeId""].Value + @"""","""" + ISpace[""MFG_P3_ProjectDetailsId""].Value + @"""","""" + ISpace[""MFG_P3_BudgetHeadId""].Value + @"""","" + ISpace[""MFG_P3_Amount""].Value + @"","""" + ISpace[""growid""].Value + @"""""",_objectFactory.GetGridRPP(""ReimbursementFundDetails""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> resultBDF250C27A244A8EB094E340FDE4659C=acdataIspace69B6AE86D2BA40489EE6B4627B21F951.GetQueryExpressionBindings("BDF250C2-7A24-4A8E-B094-E340FDE4659C");
iSpace.SetGridData(resultA8D19C29F512446883DE4C86EF7F0E8F,resultBDF250C27A244A8EB094E340FDE4659C,"ReimbursementFundDetails",ref ISpace);
iSpace.UpdateGridBindDetails("ReimbursementFundDetails",resultBDF250C27A244A8EB094E340FDE4659C);
}
base.WriteDebugInfo(@"#ReimbursementFundDetails[Rows]");
iSpace.GetLoopExpressionData("ReimbursementFundDetails",ref ISpace);

foreach(var gridChild in ISpace["ReimbursementFundDetails"].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 



ISpace["MG_P3_Employeebasicinfoid"].Value=ISpace["UC_EmployeeBaicInfoId"].Value;
base.WriteDebugInfo(@"

ISpace[""MG_P3_Employeebasicinfoid""].Value=ISpace[""UC_EmployeeBaicInfoId""].Value;");


ISpace["MG_P3_Packageprocessmapid"].Value=ISpace["M_PackageProcessMapId"].Value;
base.WriteDebugInfo(@"

ISpace[""MG_P3_Packageprocessmapid""].Value=ISpace[""M_PackageProcessMapId""].Value;");
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("ReimbursementFundDetails","00D69CC2-E6EC-4412-B2A9-14E57A96FB5C",_objectFactory.GetGridRPP("ReimbursementFundDetails"),_elementBase.GetGridLoopQuery("00D69CC2-E6EC-4412-B2A9-14E57A96FB5C","ReimbursementFundDetails",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""ReimbursementFundDetails"",ref ISpace);

foreach(var gridChild in ISpace[""ReimbursementFundDetails""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
object MG_P3_Amount=iSpace.Sum("[00D69CC2-E6EC-4412-B2A9-14E57A96FB5C]","MG_P3_Amount","");
ISpace["MFG_P3_OverallAmount"].Value=Convert.ChangeType(MG_P3_Amount, MG_P3_Amount.GetType());;
base.WriteDebugInfo(@"object MG_P3_Amount=iSpace.Sum(""[00D69CC2-E6EC-4412-B2A9-14E57A96FB5C]"",""MG_P3_Amount"","""");
ISpace[""MFG_P3_OverallAmount""].Value=Convert.ChangeType(MG_P3_Amount, MG_P3_Amount.GetType());;");
ISpace["growid"].Value="";
base.WriteDebugInfo(@"ISpace[""growid""].Value="""";");
ISpace["MFG_P3_FundDetailsId"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_P3_FundDetailsId""].Value="""";");
ISpace["MFG_P3_ReimbursementId"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_P3_ReimbursementId""].Value="""";");
ISpace["MFG_P3_FundTypeId"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_P3_FundTypeId""].Value="""";");
ISpace["MFG_P3_ProjectDetailsId"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_P3_ProjectDetailsId""].Value="""";");
ISpace["MFG_P3_BudgetHeadId"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_P3_BudgetHeadId""].Value="""";");
ISpace["MFG_P3_Amount"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_P3_Amount""].Value="""";");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mfg_p3_fundtypeid (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MFG_P3_FundTypeId-OnChange");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MFG_P3_FundTypeId"].Value=="1")
{
base.WriteDebugInfo(@"if(ISpace[""MFG_P3_FundTypeId""].Value==""1"")");
ISpace["MFG_P3_ProjectDetailsId"].Visible="true";ISpace["MFG_P3_ProjectDetailsId"].Man=true;ISpace["MFG_P3_Amount"].Visible="true";ISpace["MFG_P3_Amount"].Man=true;ISpace["MFG_P3_BudgetHeadId"].Visible="true";ISpace["MFG_P3_BudgetHeadId"].Man=true;
base.WriteDebugInfo(@"ISpace[""MFG_P3_ProjectDetailsId""].Visible=""true"";ISpace[""MFG_P3_ProjectDetailsId""].Man=true;ISpace[""MFG_P3_Amount""].Visible=""true"";ISpace[""MFG_P3_Amount""].Man=true;ISpace[""MFG_P3_BudgetHeadId""].Visible=""true"";ISpace[""MFG_P3_BudgetHeadId""].Man=true;");
ISpace["MFG_P3_BudgetHeadId"].rElemData=iSpace.Reload(ISpace["MFG_P3_BudgetHeadId"].Value,@"exec SP_GetDistrubitionDetails 5,"" + ISpace["M_PackageProcessMapId"].Value + @"","" + ISpace["MFG_P3_FundTypeId"].Value + @"","","","","","" + ISpace["MFG_P3_ProjectDetailsId"].Value + @""","9ADED37B-CD11-426B-AF16-DEAC75685EF5");
base.WriteDebugInfo(@"ISpace[""MFG_P3_BudgetHeadId""].rElemData=iSpace.Reload(ISpace[""MFG_P3_BudgetHeadId""].Value,@""exec SP_GetDistrubitionDetails 5,"""" + ISpace[""M_PackageProcessMapId""].Value + @"""","""" + ISpace[""MFG_P3_FundTypeId""].Value + @"""","""","""","""","""","""" + ISpace[""MFG_P3_ProjectDetailsId""].Value + @"""""",""9ADED37B-CD11-426B-AF16-DEAC75685EF5"");");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MFG_P3_ProjectDetailsId"].Visible="false";ISpace["MFG_P3_ProjectDetailsId"].Man=false;ISpace["MFG_P3_Amount"].Visible="true";ISpace["MFG_P3_Amount"].Man=true;ISpace["MFG_P3_BudgetHeadId"].Visible="false";ISpace["MFG_P3_BudgetHeadId"].Man=false;
base.WriteDebugInfo(@"ISpace[""MFG_P3_ProjectDetailsId""].Visible=""false"";ISpace[""MFG_P3_ProjectDetailsId""].Man=false;ISpace[""MFG_P3_Amount""].Visible=""true"";ISpace[""MFG_P3_Amount""].Man=true;ISpace[""MFG_P3_BudgetHeadId""].Visible=""false"";ISpace[""MFG_P3_BudgetHeadId""].Man=false;");
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["MFG_P3_ProjectDetailsId"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_P3_ProjectDetailsId""].Value="""";");
ISpace["MFG_P3_BudgetHeadId"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_P3_BudgetHeadId""].Value="""";");
ISpace["MFG_P3_Amount"].Value=0;
base.WriteDebugInfo(@"ISpace[""MFG_P3_Amount""].Value=0;");
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mfg_p3_projectdetailsid (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MFG_P3_ProjectDetailsId-OnChange");
ISpace["MFG_P3_BudgetHeadId"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_P3_BudgetHeadId""].Value="""";");
ISpace["MFG_P3_BudgetHeadId"].rElemData=iSpace.Reload(ISpace["MFG_P3_BudgetHeadId"].Value,@"exec SP_GetDistrubitionDetails 5,"" + ISpace["M_PackageProcessMapId"].Value + @"","" + ISpace["MFG_P3_FundTypeId"].Value + @"","","","","","" + ISpace["MFG_P3_ProjectDetailsId"].Value + @""","9ADED37B-CD11-426B-AF16-DEAC75685EF5");
base.WriteDebugInfo(@"ISpace[""MFG_P3_BudgetHeadId""].rElemData=iSpace.Reload(ISpace[""MFG_P3_BudgetHeadId""].Value,@""exec SP_GetDistrubitionDetails 5,"""" + ISpace[""M_PackageProcessMapId""].Value + @"""","""" + ISpace[""MFG_P3_FundTypeId""].Value + @"""","""","""","""","""","""" + ISpace[""MFG_P3_ProjectDetailsId""].Value + @"""""",""9ADED37B-CD11-426B-AF16-DEAC75685EF5"");");
ISpace["MFG_P3_Amount"].Value=0;
base.WriteDebugInfo(@"ISpace[""MFG_P3_Amount""].Value=0;");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mfg_p3_budgetheadid (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MFG_P3_BudgetHeadId-OnChange");
ISpace["MFG_P3_Amount"].Value=0;
base.WriteDebugInfo(@"ISpace[""MFG_P3_Amount""].Value=0;");
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
		if(elementName.ToLower().Equals("m_moveto"))
    {
    			SubscribeElementEvents_m_moveto(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mfg_p3_fundtypeid"))
    {
    			SubscribeElementEvents_mfg_p3_fundtypeid(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mfg_p3_projectdetailsid"))
    {
    			SubscribeElementEvents_mfg_p3_projectdetailsid(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mfg_p3_budgetheadid"))
    {
    			SubscribeElementEvents_mfg_p3_budgetheadid(ref dfsParam);
    }
}
	if(methodName.ToLower().Equals("onclick"))
{
		if(elementName.ToLower().Equals("submitform"))
{
			SubscribeElementEvents_submitform(ref dfsParam);
}
		if(elementName.ToLower().Equals("save_reimbursementfunddetails"))
{
			SubscribeElementEvents_save_reimbursementfunddetails(ref dfsParam);
}
}
}
}
}
namespace CPS.Proof.DFSExtension
{
}
namespace CPS.Proof.DFSExtension
{
}
namespace CPS.Proof.DFSExtension
{

using System.Collections.Generic;
using System;
using CPS.Proof.DFSExtension;
using System.Linq;using System.Data;
using System.Runtime.CompilerServices;
public class ISpaceBD4B416FE1844A6FB8DE4D2B42649FF4 : VirtualForm
{
IISpace iSpace = new ISpace();
AcDataISpaceBD4B416FE1844A6FB8DE4D2B42649FF4 acdataIspaceBD4B416FE1844A6FB8DE4D2B42649FF4=new AcDataISpaceBD4B416FE1844A6FB8DE4D2B42649FF4();
private void SubscribeFormEvents_root(ref Dictionary<string, ServiceElementData> ISpace)
{
try
{
base.WriteDebugInfo(@"Root-OnAfterFormLoad");
ISpace["M_SourceActivityMapId"].Value=ISpace["gv_activitymapid"].Value;
base.WriteDebugInfo(@"ISpace[""M_SourceActivityMapId""].Value=ISpace[""gv_activitymapid""].Value;");
ISpace["M_PackageProcessMapId"].Value=ISpace["gv_processmapid"].Value;
base.WriteDebugInfo(@"ISpace[""M_PackageProcessMapId""].Value=ISpace[""gv_processmapid""].Value;");
ISpace["M_InstanceId"].Value=ISpace["gv_instanceid"].Value;
base.WriteDebugInfo(@"ISpace[""M_InstanceId""].Value=ISpace[""gv_instanceid""].Value;");
ISpace["M_IsSourceStep"].Value=0;
base.WriteDebugInfo(@"ISpace[""M_IsSourceStep""].Value=0;");


ISpace["M_MoveTo"].Man=true;
base.WriteDebugInfo(@"ISpace[""M_MoveTo""].Man=true;");
ISpace["MF_P1_Remarks"].Value="";
base.WriteDebugInfo(@"ISpace[""MF_P1_Remarks""].Value="""";");
ISpace["M_NextStage"].Value="";
base.WriteDebugInfo(@"ISpace[""M_NextStage""].Value="""";");

var querySource8BBB2BE71E8540E59B13CC03C350EAB8 =GetQueryExpressionDataSource("8BBB2BE7-1E85-40E5-9B13-CC03C350EAB8");

DataTable result8BBB2BE71E8540E59B13CC03C350EAB8=iSpace.SetGridDataSource(querySource8BBB2BE71E8540E59B13CC03C350EAB8, _objectFactory.GetGridRPP("MG_RemarksDetails"),@"EXEC GetRemarks "" + ISpace["M_InstanceId"].Value + @""");

iSpace.InsertGridBindDetails("MG_RemarksDetails","11",querySource8BBB2BE71E8540E59B13CC03C350EAB8,"EXEC GetRemarks "" + ISpace["M_InstanceId"].Value + @""",_objectFactory.GetGridRPP("MG_RemarksDetails"));

base.WriteDebugInfo(@"var querySource8BBB2BE71E8540E59B13CC03C350EAB8 =GetQueryExpressionDataSource(""8BBB2BE7-1E85-40E5-9B13-CC03C350EAB8"");DataTable result8BBB2BE71E8540E59B13CC03C350EAB8=iSpace.SetGridDataSource(querySource8BBB2BE71E8540E59B13CC03C350EAB8, _objectFactory.GetGridRPP(""MG_RemarksDetails""),@""EXEC GetRemarks """" + ISpace[""M_InstanceId""].Value + @"""""");iSpace.InsertGridBindDetails(""MG_RemarksDetails"",""11"",querySource8BBB2BE71E8540E59B13CC03C350EAB8,""EXEC GetRemarks """" + ISpace[""M_InstanceId""].Value + @"""""",_objectFactory.GetGridRPP(""MG_RemarksDetails""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> resultCA798124C2C446CCBDA6419353320A96=acdataIspaceBD4B416FE1844A6FB8DE4D2B42649FF4.GetQueryExpressionBindings("CA798124-C2C4-46CC-BDA6-419353320A96");
iSpace.SetGridData(result8BBB2BE71E8540E59B13CC03C350EAB8,resultCA798124C2C446CCBDA6419353320A96,"MG_RemarksDetails",ref ISpace);
iSpace.UpdateGridBindDetails("MG_RemarksDetails",resultCA798124C2C446CCBDA6419353320A96);
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_submitform (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"SubmitForm-OnClick");
base.WriteDebugInfo(@"Entering DomainDataMap for Remarks Domain");
var RemarksDomain_repoObj = new RepositoryMapper(DbTypes.SQLServer);


var ActivityTrailLogDetailsRemarksDomaintableObj = new RepositoryTable("ActivityTrailLogDetails");
  ActivityTrailLogDetailsRemarksDomaintableObj.AppConnectionSettingsId  ="9ADED37B-CD11-426B-AF16-DEAC75685EF5";ActivityTrailLogDetailsRemarksDomaintableObj.ProofConnectionId = "C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0)";
var RemarksDomain_ActivityTrailLogDetails_rows = GetElementClientData(ISpace["InstanceId"].Value,"6B463D69-64AB-468E-B2E3-DB12E6B90014");

if(RemarksDomain_ActivityTrailLogDetails_rows!=null && RemarksDomain_ActivityTrailLogDetails_rows.Count>0){
var RemarksDomain_ActivityTrailLogDetails_rowsObj = new List<RepositoryRow>();
foreach(var rows in RemarksDomain_ActivityTrailLogDetails_rows){RepositoryRow repositoryRowObj = null;string elementData = null;RepositoryColumn repositoryColumnObj = null;if(rows !=null){ var ActivityTrailLogDetails_colObj = new List<RepositoryColumn>();repositoryRowObj= new RepositoryRow();//var myByte = (byte)rowData.Value.RwSt;//repositoryRowObj.RowState=(RepositoryRowState)myByte;

if(rows.ContainsKey("5354760A-9EAC-491E-BAB1-C3614187A9BE"))     elementData = rows["5354760A-9EAC-491E-BAB1-C3614187A9BE"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ProcessedInProgressFlag",false,false,5);
if(repositoryColumnObj!=null)ActivityTrailLogDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-M_IsSourceStep not found");}

elementData = CurrentDate().ToString() ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Updatedon",false,false,8);
if(repositoryColumnObj!=null)ActivityTrailLogDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-CurrentDate not found");}

if(rows.ContainsKey("D7BB255E-9A01-4B5B-AE06-CC4D6E088D52"))     elementData = rows["D7BB255E-9A01-4B5B-AE06-CC4D6E088D52"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"InstanceID",false,false,9);
if(repositoryColumnObj!=null)ActivityTrailLogDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-M_InstanceId not found");}

elementData = ISpace["gv_UserId"].Value != null? Convert.ToString(ISpace["gv_UserId"].Value):null ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Updatedby",false,false,6);
if(repositoryColumnObj!=null)ActivityTrailLogDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-gv_UserId not found");}

if(rows.ContainsKey("6DB9BC45-F167-4D8A-9596-1DBA9872F253"))     elementData = rows["6DB9BC45-F167-4D8A-9596-1DBA9872F253"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"DestinationActivityMapID",false,false,9);
if(repositoryColumnObj!=null)ActivityTrailLogDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-M_DestinationActivityId not found");}

elementData = ISpace["gv_UserName"].Value != null? Convert.ToString(ISpace["gv_UserName"].Value):null ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"RemarksBy",false,false,9);
if(repositoryColumnObj!=null)ActivityTrailLogDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-gv_UserName not found");}

elementData = ISpace["gv_ActivityName"].Value != null? Convert.ToString(ISpace["gv_ActivityName"].Value):null ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ActivityName",false,false,9);
if(repositoryColumnObj!=null)ActivityTrailLogDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-gv_ActivityName not found");}

if(rows.ContainsKey("F78328FF-68D9-45E9-BC40-27CD650C9D6C"))     elementData = rows["F78328FF-68D9-45E9-BC40-27CD650C9D6C"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Remarks",false,false,9);
if(repositoryColumnObj!=null)ActivityTrailLogDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MF_P1_Remarks not found");}

elementData = ISpace["gv_TenantId"].Value != null? Convert.ToString(ISpace["gv_TenantId"].Value):null ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"TenantID",false,false,9);
if(repositoryColumnObj!=null)ActivityTrailLogDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-gv_TenantId not found");}

elementData = Guid.NewGuid().ToString();if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"TrailLogId",true,false,9);
if(repositoryColumnObj!=null)ActivityTrailLogDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-GUID not found");}

if(rows.ContainsKey("52A564C4-B656-4F43-B6F3-E592002351F6"))     elementData = rows["52A564C4-B656-4F43-B6F3-E592002351F6"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"SourceActivityMapID",false,false,9);
if(repositoryColumnObj!=null)ActivityTrailLogDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-M_SourceActivityMapId not found");}

elementData = CurrentDate().ToString() ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"RemarksOn",false,false,8);
if(repositoryColumnObj!=null)ActivityTrailLogDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-CurrentDate not found");}
repositoryRowObj.Columns=ActivityTrailLogDetails_colObj;
RemarksDomain_ActivityTrailLogDetails_rowsObj.Add(repositoryRowObj);
}}

ActivityTrailLogDetailsRemarksDomaintableObj.Rows=RemarksDomain_ActivityTrailLogDetails_rowsObj;
var RemarksDomain_repoObj_status_ActivityTrailLogDetails = RemarksDomain_repoObj.Execute(DomainOperationTypes.CreateOrUpdate,ref ActivityTrailLogDetailsRemarksDomaintableObj);if(!RemarksDomain_repoObj_status_ActivityTrailLogDetails) throw new Exception("Error in Execute Domain Data Map");}
base.WriteDebugInfo(@"Exiting DomainDataMap for Remarks Domain");
if(IsNullOrEmpty(ISpace["Declaration"].Value))
{
base.WriteDebugInfo(@"if(IsNullOrEmpty(ISpace[""Declaration""].Value))");
ISpace["Message"].Value=@"Select the declaration";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Select the declaration"";");
return;
base.WriteDebugInfo(@"return;");
}
if(ISpace["M_SaveDomainData"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""M_SaveDomainData""].Value==1)");
ISpace["MF_P1_ApplicationStatus"].Value="A";
base.WriteDebugInfo(@"ISpace[""MF_P1_ApplicationStatus""].Value=""A"";");
}
if(ISpace["M_SaveDomainData"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""M_SaveDomainData""].Value==1)");
base.WriteDebugInfo(@"Entering DomainDataMap for Project Advance Details REPO 1");
var ProjectAdvanceDetailsREPO1_repoObj = new RepositoryMapper(DbTypes.SQLServer);


var ProjectAdvanceFormProjectAdvanceDetailsREPO1tableObj = new RepositoryTable("ProjectAdvanceForm");
  ProjectAdvanceFormProjectAdvanceDetailsREPO1tableObj.AppConnectionSettingsId  ="3A103712-5244-4427-B2B6-1C4E046FD337";ProjectAdvanceFormProjectAdvanceDetailsREPO1tableObj.ProofConnectionId = "C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0)";
var ProjectAdvanceDetailsREPO1_ProjectAdvanceForm_rows = GetElementClientData(ISpace["InstanceId"].Value,"6B463D69-64AB-468E-B2E3-DB12E6B90014");

if(ProjectAdvanceDetailsREPO1_ProjectAdvanceForm_rows!=null && ProjectAdvanceDetailsREPO1_ProjectAdvanceForm_rows.Count>0){
var ProjectAdvanceDetailsREPO1_ProjectAdvanceForm_rowsObj = new List<RepositoryRow>();
foreach(var rows in ProjectAdvanceDetailsREPO1_ProjectAdvanceForm_rows){RepositoryRow repositoryRowObj = null;string elementData = null;RepositoryColumn repositoryColumnObj = null;if(rows !=null){ var ProjectAdvanceForm_colObj = new List<RepositoryColumn>();repositoryRowObj= new RepositoryRow();//var myByte = (byte)rowData.Value.RwSt;//repositoryRowObj.RowState=(RepositoryRowState)myByte;

if(rows.ContainsKey("72A0167C-47E6-4BBA-964A-D18B4C2724BE"))     elementData = rows["72A0167C-47E6-4BBA-964A-D18B4C2724BE"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"AdvanceFormId",true,false,9);
if(repositoryColumnObj!=null)ProjectAdvanceForm_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-M_Advanceformid not found");}

elementData = ISpace["gv_UserName"].Value != null? Convert.ToString(ISpace["gv_UserName"].Value):null ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"InitatedBy",false,false,9);
if(repositoryColumnObj!=null)ProjectAdvanceForm_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-gv_UserName not found");}

elementData = ISpace["gv_UserName"].Value != null? Convert.ToString(ISpace["gv_UserName"].Value):null ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"UpdatedBy",false,false,9);
if(repositoryColumnObj!=null)ProjectAdvanceForm_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-gv_UserName not found");}

if(rows.ContainsKey("16BFBC4B-9CB5-4677-AAE8-85CE6C7260E5"))     elementData = rows["16BFBC4B-9CB5-4677-AAE8-85CE6C7260E5"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ApplicationStatus",false,false,9);
if(repositoryColumnObj!=null)ProjectAdvanceForm_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MF_P1_ApplicationStatus not found");}

if(rows.ContainsKey("329D5240-1DBD-433E-A8EB-0F29F5AA668C"))     elementData = rows["329D5240-1DBD-433E-A8EB-0F29F5AA668C"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"EmployeeBasicInfoId",false,false,9);
if(repositoryColumnObj!=null)ProjectAdvanceForm_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-UC_EmployeeBaicInfoId not found");}

if(rows.ContainsKey("68A2EC13-D240-4EBC-8828-E795581544DA"))     elementData = rows["68A2EC13-D240-4EBC-8828-E795581544DA"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"TotalAmount",false,false,3);
if(repositoryColumnObj!=null)ProjectAdvanceForm_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MF_P1_TotalAmount not found");}

elementData = CurrentDate().ToString() ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Initiatedon",false,false,8);
if(repositoryColumnObj!=null)ProjectAdvanceForm_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-CurrentDate not found");}

elementData = CurrentDate().ToString() ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"UpdatedOn",false,false,8);
if(repositoryColumnObj!=null)ProjectAdvanceForm_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-CurrentDate not found");}
repositoryRowObj.Columns=ProjectAdvanceForm_colObj;
ProjectAdvanceDetailsREPO1_ProjectAdvanceForm_rowsObj.Add(repositoryRowObj);
}}

ProjectAdvanceFormProjectAdvanceDetailsREPO1tableObj.Rows=ProjectAdvanceDetailsREPO1_ProjectAdvanceForm_rowsObj;
var ProjectAdvanceDetailsREPO1_repoObj_status_ProjectAdvanceForm = ProjectAdvanceDetailsREPO1_repoObj.Execute(DomainOperationTypes.CreateOrUpdate,ref ProjectAdvanceFormProjectAdvanceDetailsREPO1tableObj);if(!ProjectAdvanceDetailsREPO1_repoObj_status_ProjectAdvanceForm) throw new Exception("Error in Execute Domain Data Map");}
base.WriteDebugInfo(@"Exiting DomainDataMap for Project Advance Details REPO 1");
base.WriteDebugInfo(@"Entering DomainDataMap for Project Advance Details REPO 2");
var ProjectAdvanceDetailsREPO2_repoObj = new RepositoryMapper(DbTypes.SQLServer);


var ProjectAdvanceFundDetailsProjectAdvanceDetailsREPO2tableObj = new RepositoryTable("ProjectAdvanceFundDetails");
  ProjectAdvanceFundDetailsProjectAdvanceDetailsREPO2tableObj.AppConnectionSettingsId  ="3A103712-5244-4427-B2B6-1C4E046FD337";ProjectAdvanceFundDetailsProjectAdvanceDetailsREPO2tableObj.ProofConnectionId = "C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0)";
var ProjectAdvanceDetailsREPO2_ProjectAdvanceFundDetails_rows = GetElementClientData(ISpace["InstanceId"].Value,"00D69CC2-E6EC-4412-B2A9-14E57A96FB5C");

if(ProjectAdvanceDetailsREPO2_ProjectAdvanceFundDetails_rows!=null && ProjectAdvanceDetailsREPO2_ProjectAdvanceFundDetails_rows.Count>0){
var ProjectAdvanceDetailsREPO2_ProjectAdvanceFundDetails_rowsObj = new List<RepositoryRow>();
foreach(var rows in ProjectAdvanceDetailsREPO2_ProjectAdvanceFundDetails_rows){RepositoryRow repositoryRowObj = null;string elementData = null;RepositoryColumn repositoryColumnObj = null;if(rows !=null){ var ProjectAdvanceFundDetails_colObj = new List<RepositoryColumn>();repositoryRowObj= new RepositoryRow();//var myByte = (byte)rowData.Value.RwSt;//repositoryRowObj.RowState=(RepositoryRowState)myByte;

if(rows.ContainsKey("E20A9876-034C-49BC-A309-26338AAD45BD"))     elementData = rows["E20A9876-034C-49BC-A309-26338AAD45BD"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"AdvanceFormId",false,false,9);
if(repositoryColumnObj!=null)ProjectAdvanceFundDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MG_P3_Advanceformid not found");}

if(rows.ContainsKey("B24F329A-C286-4040-ABD2-B67B5AE4F7BE"))     elementData = rows["B24F329A-C286-4040-ABD2-B67B5AE4F7BE"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"FundDetailsId",true,false,9);
if(repositoryColumnObj!=null)ProjectAdvanceFundDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MG_P3_FundDetailsId not found");}

if(rows.ContainsKey("4F81555E-3503-43B3-AD28-23293B41E926"))     elementData = rows["4F81555E-3503-43B3-AD28-23293B41E926"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ProjectDetailsId",false,false,9);
if(repositoryColumnObj!=null)ProjectAdvanceFundDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MG_P3_ProjectDetailsId not found");}

if(rows.ContainsKey("CCBB2219-451D-4EAE-BA26-1C16A9B0FF7D"))     elementData = rows["CCBB2219-451D-4EAE-BA26-1C16A9B0FF7D"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Amount",false,false,3);
if(repositoryColumnObj!=null)ProjectAdvanceFundDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MG_P3_Amount not found");}

if(rows.ContainsKey("8F687AA1-A6B1-4250-9948-DBAF2D40AB51"))     elementData = rows["8F687AA1-A6B1-4250-9948-DBAF2D40AB51"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"BudgetHeadId",false,false,9);
if(repositoryColumnObj!=null)ProjectAdvanceFundDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MG_P3_BudgetHeadId not found");}

if(rows.ContainsKey("99E459F3-F338-40A6-A1E3-1F7AD7A198CD"))     elementData = rows["99E459F3-F338-40A6-A1E3-1F7AD7A198CD"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"FundTypeId",false,false,6);
if(repositoryColumnObj!=null)ProjectAdvanceFundDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MG_P3_FundTypeId not found");}
repositoryRowObj.Columns=ProjectAdvanceFundDetails_colObj;
ProjectAdvanceDetailsREPO2_ProjectAdvanceFundDetails_rowsObj.Add(repositoryRowObj);
}}

ProjectAdvanceFundDetailsProjectAdvanceDetailsREPO2tableObj.Rows=ProjectAdvanceDetailsREPO2_ProjectAdvanceFundDetails_rowsObj;
var ProjectAdvanceDetailsREPO2_repoObj_status_ProjectAdvanceFundDetails = ProjectAdvanceDetailsREPO2_repoObj.Execute(DomainOperationTypes.CreateOrUpdate,ref ProjectAdvanceFundDetailsProjectAdvanceDetailsREPO2tableObj);if(!ProjectAdvanceDetailsREPO2_repoObj_status_ProjectAdvanceFundDetails) throw new Exception("Error in Execute Domain Data Map");}
base.WriteDebugInfo(@"Exiting DomainDataMap for Project Advance Details REPO 2");
base.WriteDebugInfo(@"Entering DomainDataMap for Project Advance Details REPO 3");
var ProjectAdvanceDetailsREPO3_repoObj = new RepositoryMapper(DbTypes.SQLServer);


var ProjectAdvanceRequestDetailsProjectAdvanceDetailsREPO3tableObj = new RepositoryTable("ProjectAdvanceRequestDetails");
  ProjectAdvanceRequestDetailsProjectAdvanceDetailsREPO3tableObj.AppConnectionSettingsId  ="3A103712-5244-4427-B2B6-1C4E046FD337";ProjectAdvanceRequestDetailsProjectAdvanceDetailsREPO3tableObj.ProofConnectionId = "C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0)";
var ProjectAdvanceDetailsREPO3_ProjectAdvanceRequestDetails_rows = GetElementClientData(ISpace["InstanceId"].Value,"1356A8F2-1947-4667-987D-2EA211B288A3");

if(ProjectAdvanceDetailsREPO3_ProjectAdvanceRequestDetails_rows!=null && ProjectAdvanceDetailsREPO3_ProjectAdvanceRequestDetails_rows.Count>0){
var ProjectAdvanceDetailsREPO3_ProjectAdvanceRequestDetails_rowsObj = new List<RepositoryRow>();
foreach(var rows in ProjectAdvanceDetailsREPO3_ProjectAdvanceRequestDetails_rows){RepositoryRow repositoryRowObj = null;string elementData = null;RepositoryColumn repositoryColumnObj = null;if(rows !=null){ var ProjectAdvanceRequestDetails_colObj = new List<RepositoryColumn>();repositoryRowObj= new RepositoryRow();//var myByte = (byte)rowData.Value.RwSt;//repositoryRowObj.RowState=(RepositoryRowState)myByte;

if(rows.ContainsKey("04D90722-37D7-40B0-96B6-D6CA55ABA8F2"))     elementData = rows["04D90722-37D7-40B0-96B6-D6CA55ABA8F2"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ExpenseDetails",false,false,9);
if(repositoryColumnObj!=null)ProjectAdvanceRequestDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MGA_DetailsofExpenses not found");}

if(rows.ContainsKey("B1EB21F5-30E2-4DB3-B72E-E6BB3E4A1D2B"))     elementData = rows["B1EB21F5-30E2-4DB3-B72E-E6BB3E4A1D2B"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ItemDescription",false,false,9);
if(repositoryColumnObj!=null)ProjectAdvanceRequestDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MGA_Description not found");}

if(rows.ContainsKey("8E8892C8-B328-42D2-A630-B8A2C3C4D26B"))     elementData = rows["8E8892C8-B328-42D2-A630-B8A2C3C4D26B"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Amount",false,false,3);
if(repositoryColumnObj!=null)ProjectAdvanceRequestDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MGA_Amount not found");}

if(rows.ContainsKey("67C65E87-8293-495E-97A2-E7431BF75D69"))     elementData = rows["67C65E87-8293-495E-97A2-E7431BF75D69"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"RequestDetailsId",true,false,9);
if(repositoryColumnObj!=null)ProjectAdvanceRequestDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MGA_RequestDetailsId not found");}

if(rows.ContainsKey("6E5FD9F2-E29C-4922-B6C5-78C591A395A6"))     elementData = rows["6E5FD9F2-E29C-4922-B6C5-78C591A395A6"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"AdvanceFormId",false,false,9);
if(repositoryColumnObj!=null)ProjectAdvanceRequestDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MGA_AdvanceFormId not found");}
repositoryRowObj.Columns=ProjectAdvanceRequestDetails_colObj;
ProjectAdvanceDetailsREPO3_ProjectAdvanceRequestDetails_rowsObj.Add(repositoryRowObj);
}}

ProjectAdvanceRequestDetailsProjectAdvanceDetailsREPO3tableObj.Rows=ProjectAdvanceDetailsREPO3_ProjectAdvanceRequestDetails_rowsObj;
var ProjectAdvanceDetailsREPO3_repoObj_status_ProjectAdvanceRequestDetails = ProjectAdvanceDetailsREPO3_repoObj.Execute(DomainOperationTypes.CreateOrUpdate,ref ProjectAdvanceRequestDetailsProjectAdvanceDetailsREPO3tableObj);if(!ProjectAdvanceDetailsREPO3_repoObj_status_ProjectAdvanceRequestDetails) throw new Exception("Error in Execute Domain Data Map");}
base.WriteDebugInfo(@"Exiting DomainDataMap for Project Advance Details REPO 3");
}
if(ISpace["M_IsflowReturned"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""M_IsflowReturned""].Value==1)");
ISpace["AssignToUser"].Value=ISpace["M_InitiatorUserMapId"].Value;
base.WriteDebugInfo(@"ISpace[""AssignToUser""].Value=ISpace[""M_InitiatorUserMapId""].Value;");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["AssignToUser"].Value="";
base.WriteDebugInfo(@"ISpace[""AssignToUser""].Value="""";");
}
base.WriteDebugInfo(@"#ReimbursementFundDetails[Rows]");
iSpace.GetLoopExpressionData("ReimbursementFundDetails",ref ISpace);

foreach(var gridChild in ISpace["ReimbursementFundDetails"].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 


if(
ISpace["M_SaveDomainData"].Value==1)
{
base.WriteDebugInfo(@"
if(
ISpace[""M_SaveDomainData""].Value==1)");
base.WriteDebugInfo(@"EXEC [UpsertProjectBudgetDetails] 5,"#MG_P3_ProjectDetailsId","","#MG_P3_Amount","#MG_P3_BudgetHeadId",0,"#MG_P3_FundTypeId"");

var querySourceB460B189F97546FAAA0EC134AA7CDECC =GetQueryExpressionDataSource("B460B189-F975-46FA-AA0E-C134AA7CDECC");
Dictionary<short,object> resultB460B189F97546FAAA0EC134AA7CDECC=iSpace.ExecuteQuery(querySourceB460B189F97546FAAA0EC134AA7CDECC,@"EXEC [UpsertProjectBudgetDetails] 5,"" + ISpace["MG_P3_ProjectDetailsId"].Value + @"","","" + ISpace["MG_P3_Amount"].Value + @"","" + ISpace["MG_P3_BudgetHeadId"].Value + @"",0,"" + ISpace["MG_P3_FundTypeId"].Value + @""",false);

base.WriteDebugInfo(@"var querySourceB460B189F97546FAAA0EC134AA7CDECC =GetQueryExpressionDataSource(""B460B189-F975-46FA-AA0E-C134AA7CDECC"");Dictionary<short,object> resultB460B189F97546FAAA0EC134AA7CDECC=iSpace.ExecuteQuery(querySourceB460B189F97546FAAA0EC134AA7CDECC,@""EXEC [UpsertProjectBudgetDetails] 5,"""" + ISpace[""MG_P3_ProjectDetailsId""].Value + @"""","""","""" + ISpace[""MG_P3_Amount""].Value + @"""","""" + ISpace[""MG_P3_BudgetHeadId""].Value + @"""",0,"""" + ISpace[""MG_P3_FundTypeId""].Value + @"""""",false);");
base.WriteDebugInfo(@"");

if((resultB460B189F97546FAAA0EC134AA7CDECC!=null) && (resultB460B189F97546FAAA0EC134AA7CDECC.Count!=0))
{
if(resultB460B189F97546FAAA0EC134AA7CDECC.ContainsKey(0))
ISpace["M_UpdateCount"].Value = resultB460B189F97546FAAA0EC134AA7CDECC[0];
}
else{
ISpace["M_UpdateCount"].Value = null;
}
}
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("ReimbursementFundDetails","00D69CC2-E6EC-4412-B2A9-14E57A96FB5C",_objectFactory.GetGridRPP("ReimbursementFundDetails"),_elementBase.GetGridLoopQuery("00D69CC2-E6EC-4412-B2A9-14E57A96FB5C","ReimbursementFundDetails",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""ReimbursementFundDetails"",ref ISpace);

foreach(var gridChild in ISpace[""ReimbursementFundDetails""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
base.WriteDebugInfo(@"#ReimbursementFundDetails[Rows]");
iSpace.GetLoopExpressionData("ReimbursementFundDetails",ref ISpace);

foreach(var gridChild in ISpace["ReimbursementFundDetails"].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 


if(
ISpace["M_IsflowReturned"].Value==1)
{
base.WriteDebugInfo(@"
if(
ISpace[""M_IsflowReturned""].Value==1)");
base.WriteDebugInfo(@"EXEC [UpsertProjectBudgetDetails] 6,"#MG_P3_ProjectDetailsId","","#MG_P3_Amount","#MG_P3_BudgetHeadId",1,"#MG_P3_FundTypeId"");

var querySource318EAB61FF354EB2A293264135B2F298 =GetQueryExpressionDataSource("318EAB61-FF35-4EB2-A293-264135B2F298");
Dictionary<short,object> result318EAB61FF354EB2A293264135B2F298=iSpace.ExecuteQuery(querySource318EAB61FF354EB2A293264135B2F298,@"EXEC [UpsertProjectBudgetDetails] 6,"" + ISpace["MG_P3_ProjectDetailsId"].Value + @"","","" + ISpace["MG_P3_Amount"].Value + @"","" + ISpace["MG_P3_BudgetHeadId"].Value + @"",1,"" + ISpace["MG_P3_FundTypeId"].Value + @""",false);

base.WriteDebugInfo(@"var querySource318EAB61FF354EB2A293264135B2F298 =GetQueryExpressionDataSource(""318EAB61-FF35-4EB2-A293-264135B2F298"");Dictionary<short,object> result318EAB61FF354EB2A293264135B2F298=iSpace.ExecuteQuery(querySource318EAB61FF354EB2A293264135B2F298,@""EXEC [UpsertProjectBudgetDetails] 6,"""" + ISpace[""MG_P3_ProjectDetailsId""].Value + @"""","""","""" + ISpace[""MG_P3_Amount""].Value + @"""","""" + ISpace[""MG_P3_BudgetHeadId""].Value + @"""",1,"""" + ISpace[""MG_P3_FundTypeId""].Value + @"""""",false);");
base.WriteDebugInfo(@"");

if((result318EAB61FF354EB2A293264135B2F298!=null) && (result318EAB61FF354EB2A293264135B2F298.Count!=0))
{
if(result318EAB61FF354EB2A293264135B2F298.ContainsKey(0))
ISpace["M_UpdateCount"].Value = result318EAB61FF354EB2A293264135B2F298[0];
}
else{
ISpace["M_UpdateCount"].Value = null;
}
}
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("ReimbursementFundDetails","00D69CC2-E6EC-4412-B2A9-14E57A96FB5C",_objectFactory.GetGridRPP("ReimbursementFundDetails"),_elementBase.GetGridLoopQuery("00D69CC2-E6EC-4412-B2A9-14E57A96FB5C","ReimbursementFundDetails",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""ReimbursementFundDetails"",ref ISpace);

foreach(var gridChild in ISpace[""ReimbursementFundDetails""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["M_MoveTo"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""M_MoveTo""].Value=="""")");
ISpace["Message"].Value=@"Move To should be mandatory";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Move To should be mandatory"";");
return;
base.WriteDebugInfo(@"return;");
}
}
if(ISpace["M_SaveDomainData"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""M_SaveDomainData""].Value==1)");
ISpace["M_Status"].Value="Approved";
base.WriteDebugInfo(@"ISpace[""M_Status""].Value=""Approved"";");
}
if(ISpace["M_IsCancelReject"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""M_IsCancelReject""].Value==1)");
ISpace["M_Status"].Value="Dropped";
base.WriteDebugInfo(@"ISpace[""M_Status""].Value=""Dropped"";");
}
base.WriteDebugInfo(@"Entering DomainDataMap for User Request For other steps");
var UserRequestForothersteps_repoObj = new RepositoryMapper(DbTypes.SQLServer);


var UserRequestsUserRequestForotherstepstableObj = new RepositoryTable("UserRequests");
  UserRequestsUserRequestForotherstepstableObj.AppConnectionSettingsId  ="9ADED37B-CD11-426B-AF16-DEAC75685EF5";UserRequestsUserRequestForotherstepstableObj.ProofConnectionId = "C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0)";
var UserRequestForothersteps_UserRequests_rows = GetElementClientData(ISpace["InstanceId"].Value,"6B463D69-64AB-468E-B2E3-DB12E6B90014");

if(UserRequestForothersteps_UserRequests_rows!=null && UserRequestForothersteps_UserRequests_rows.Count>0){
var UserRequestForothersteps_UserRequests_rowsObj = new List<RepositoryRow>();
foreach(var rows in UserRequestForothersteps_UserRequests_rows){RepositoryRow repositoryRowObj = null;string elementData = null;RepositoryColumn repositoryColumnObj = null;if(rows !=null){ var UserRequests_colObj = new List<RepositoryColumn>();repositoryRowObj= new RepositoryRow();//var myByte = (byte)rowData.Value.RwSt;//repositoryRowObj.RowState=(RepositoryRowState)myByte;

if(rows.ContainsKey("34CFB4AA-E9A1-4EAC-83A8-AEC1C4038EE1"))     elementData = rows["34CFB4AA-E9A1-4EAC-83A8-AEC1C4038EE1"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"CurrentLevel",false,false,9);
if(repositoryColumnObj!=null)UserRequests_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-M_NextStage not found");}

if(rows.ContainsKey("B89FF303-5A1C-4060-BAB9-E6F52A11D9FD"))     elementData = rows["B89FF303-5A1C-4060-BAB9-E6F52A11D9FD"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"CurrentStatus",false,false,9);
if(repositoryColumnObj!=null)UserRequests_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-M_Status not found");}

elementData = ISpace["gv_UserId"].Value != null? Convert.ToString(ISpace["gv_UserId"].Value):null ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"LastModifiedByUserID",false,false,5);
if(repositoryColumnObj!=null)UserRequests_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-gv_UserId not found");}

if(rows.ContainsKey("0CDC8D38-F4F4-4C60-BCED-E9F0C8B165B8"))     elementData = rows["0CDC8D38-F4F4-4C60-BCED-E9F0C8B165B8"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"CurrentActivityMapID",false,false,9);
if(repositoryColumnObj!=null)UserRequests_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-SetDestinationTo not found");}

if(rows.ContainsKey("D7BB255E-9A01-4B5B-AE06-CC4D6E088D52"))     elementData = rows["D7BB255E-9A01-4B5B-AE06-CC4D6E088D52"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"InstanceID",true,false,9);
if(repositoryColumnObj!=null)UserRequests_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-M_InstanceId not found");}

elementData = CurrentDate().ToString() ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"LastModifiedOn",false,false,8);
if(repositoryColumnObj!=null)UserRequests_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-CurrentDate not found");}
repositoryRowObj.Columns=UserRequests_colObj;
UserRequestForothersteps_UserRequests_rowsObj.Add(repositoryRowObj);
}}

UserRequestsUserRequestForotherstepstableObj.Rows=UserRequestForothersteps_UserRequests_rowsObj;
var UserRequestForothersteps_repoObj_status_UserRequests = UserRequestForothersteps_repoObj.Execute(DomainOperationTypes.Update,ref UserRequestsUserRequestForotherstepstableObj);if(!UserRequestForothersteps_repoObj_status_UserRequests) throw new Exception("Error in Execute Domain Data Map");}
base.WriteDebugInfo(@"Exiting DomainDataMap for User Request For other steps");
ISpace["Message"].Value=@"Submitted Successfully";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Submitted Successfully"";");
ISpace.ExecuteInstanceCommand("Submit");
base.WriteDebugInfo(@"ISpace.ExecuteInstanceCommand(""Submit"");");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_m_moveto (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"M_MoveTo-OnChange");
ISpace["M_MoveToValue"].Value=ISpace["M_MoveTo"].Value;
base.WriteDebugInfo(@"ISpace[""M_MoveToValue""].Value=ISpace[""M_MoveTo""].Value;");
base.WriteDebugInfo(@"Exec GetStageStatus 1,"","","#M_MoveToValue","#M_SourceActivityMapId"");

var querySource549686A138974AFCA19EC95972C37210 =GetQueryExpressionDataSource("549686A1-3897-4AFC-A19E-C95972C37210");
Dictionary<short,object> result549686A138974AFCA19EC95972C37210=iSpace.ExecuteQuery(querySource549686A138974AFCA19EC95972C37210,@"Exec GetStageStatus 1,"","","" + ISpace["M_MoveToValue"].Value + @"","" + ISpace["M_SourceActivityMapId"].Value + @""",false);

base.WriteDebugInfo(@"var querySource549686A138974AFCA19EC95972C37210 =GetQueryExpressionDataSource(""549686A1-3897-4AFC-A19E-C95972C37210"");Dictionary<short,object> result549686A138974AFCA19EC95972C37210=iSpace.ExecuteQuery(querySource549686A138974AFCA19EC95972C37210,@""Exec GetStageStatus 1,"""","""","""" + ISpace[""M_MoveToValue""].Value + @"""","""" + ISpace[""M_SourceActivityMapId""].Value + @"""""",false);");
base.WriteDebugInfo(@"");

if((result549686A138974AFCA19EC95972C37210!=null) && (result549686A138974AFCA19EC95972C37210.Count!=0))
{
if(result549686A138974AFCA19EC95972C37210.ContainsKey(3))
ISpace["M_SaveDomainData"].Value = result549686A138974AFCA19EC95972C37210[3];
if(result549686A138974AFCA19EC95972C37210.ContainsKey(1))
ISpace["M_RemarksMandatory"].Value = result549686A138974AFCA19EC95972C37210[1];
if(result549686A138974AFCA19EC95972C37210.ContainsKey(4))
ISpace["M_FieldMandatory"].Value = result549686A138974AFCA19EC95972C37210[4];
if(result549686A138974AFCA19EC95972C37210.ContainsKey(2))
ISpace["MF_P1_Remarks"].Value = result549686A138974AFCA19EC95972C37210[2];
if(result549686A138974AFCA19EC95972C37210.ContainsKey(0))
ISpace["M_NextStage"].Value = result549686A138974AFCA19EC95972C37210[0];
}
else{
ISpace["M_SaveDomainData"].Value = null;ISpace["M_RemarksMandatory"].Value = null;ISpace["M_FieldMandatory"].Value = null;ISpace["MF_P1_Remarks"].Value = null;ISpace["M_NextStage"].Value = null;
}
ISpace["SetDestinationTo"].Value=ISpace["M_MoveTo"].Value;
base.WriteDebugInfo(@"ISpace[""SetDestinationTo""].Value=ISpace[""M_MoveTo""].Value;");
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
		if(elementName.ToLower().Equals("m_moveto"))
    {
    			SubscribeElementEvents_m_moveto(ref dfsParam);
    }
}
	if(methodName.ToLower().Equals("onclick"))
{
		if(elementName.ToLower().Equals("submitform"))
{
			SubscribeElementEvents_submitform(ref dfsParam);
}
}
}
}
}
namespace CPS.Proof.DFSExtension
{
}

  







namespace CPS.Proof.DFSExtension
{
	
using System;
    using System.Collections.Generic;    
    using System.Text;	
    using System.Linq;	


	public partial class AcDataISpaceB2EE67FA41C14A1BAB23466B572ACE72  : ExtensionActivityBase
	{		
		
		
		private Dictionary<string,  List<Triplet<string, short, short?>>> queryExpressionBindings = 
											new Dictionary<string,  List<Triplet<string, short, short?>>>
		{
							{"AB481A6E-8735-4F09-AD1B-C0BBEFC0AD56", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_P2_BillNo",2,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_Amount",6,
														   -1),
								   new Triplet<string, short, short?>("ReimbursementBillDetails_RowId",7,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_BillDocument",4,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_ItemDescription",5,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_ReimbursementId",1,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_BillDate",3,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_ReimbursementDetailsId",0,
														   -1),
								}
			},
							{"D8C74C9B-035C-46A4-93E2-CAE4FECC1DA7", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_YetToReceive",2,
														   -1),
								   new Triplet<string, short, short?>("MG_Balance",6,
														   -1),
								   new Triplet<string, short, short?>("MG_ReceivedAmount",3,
														   -1),
								   new Triplet<string, short, short?>("MG_Commitment",4,
														   -1),
								   new Triplet<string, short, short?>("MG_SanctionedAmount",1,
														   -1),
								   new Triplet<string, short, short?>("MG_Spent",5,
														   -1),
								   new Triplet<string, short, short?>("MG_BudgetName",0,
														   -1),
								}
			},
							{"51CA1824-6689-43C9-A9D9-B360B3E6BBB8", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_P2_BillDate",3,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_ItemDescription",5,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_ReimbursementId",1,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_BillNo",2,
														   -1),
								   new Triplet<string, short, short?>("ReimbursementBillDetails_RowId",7,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_BillDocument",4,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_ReimbursementDetailsId",0,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_Amount",6,
														   -1),
								}
			},
							{"169C69C3-9492-4547-8D79-196C3E1309FB", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_P3_Amount",5,
														   -1),
								   new Triplet<string, short, short?>("ReimbursementFundDetails_RowId",6,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_FundDetailsId",0,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_ProjectDetailsId",3,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_FundTypeId",2,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_ReimbursementId",1,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_BudgetHeadId",4,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_Advanceformid",1,
														   -1),
								}
			},
							{"E36ECEF0-6F8F-4B61-827C-4CB0B5D712E0", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_P3_BudgetHeadId",4,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_FundDetailsId",0,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_Amount",5,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_ReimbursementId",1,
														   -1),
								   new Triplet<string, short, short?>("ReimbursementFundDetails_RowId",6,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_FundTypeId",2,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_ProjectDetailsId",3,
														   -1),
								}
			},
							{"BDF250C2-7A24-4A8E-B094-E340FDE4659C", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_P3_FundDetailsId",0,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_ProjectDetailsId",3,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_Amount",5,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_ReimbursementId",1,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_Advanceformid",1,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_BudgetHeadId",4,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_FundTypeId",2,
														   -1),
								   new Triplet<string, short, short?>("ReimbursementFundDetails_RowId",6,
														   -1),
								}
			},
							{"CA798124-C2C4-46CC-BDA6-419353320A96", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("ActivityName",1,
														   -1),
								   new Triplet<string, short, short?>("Remarks",4,
														   -1),
								   new Triplet<string, short, short?>("UserName",2,
														   -1),
								   new Triplet<string, short, short?>("RemarksId",0,
														   -1),
								   new Triplet<string, short, short?>("DateOfRemarks",3,
														   -1),
								}
			},
					};	

	

		private Dictionary<string,string> formVersionList =new Dictionary<string,string> 
		{
							{"CE5B9B97-27CE-4812-ABB3-650ADC79D12E", "Medium"},
					};	

		
		private Dictionary<string,string> formVersionLayoutList =new Dictionary<string,string> 
		{
							{"30C11FF1-AB59-477E-9CCF-B5C287704944", ""},
							{"982B4FEE-F07C-43C9-821A-7971F8D0F5DC", ""},
							{"CE5B9B97-27CE-4812-ABB3-650ADC79D12E", ""},
							{"41E31511-B7DB-45A3-8E2D-13FBB540E344", ""},
							{"D76C0EDE-D6E2-4A5B-9CE3-26E87EE2FA33", ""},
							{"8BDC9ED4-061B-49D1-BCF4-C3883F79611F", ""},
							{"6E6EF850-0E3D-4C14-9281-9C2DB19C1AEA", ""},
							{"C85F20CB-E7F0-44FE-8309-8B65CED5DFE7", ""},
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
		
  







namespace CPS.Proof.DFSExtension
{
	
using System;
    using System.Collections.Generic;    
    using System.Text;	
    using System.Linq;	


	public partial class AcDataISpace1E274DA615154B96B9224B5CC5F2D423  : ExtensionActivityBase
	{		
		
		
		private Dictionary<string,  List<Triplet<string, short, short?>>> queryExpressionBindings = 
											new Dictionary<string,  List<Triplet<string, short, short?>>>
		{
							{"AB481A6E-8735-4F09-AD1B-C0BBEFC0AD56", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_P2_BillNo",2,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_Amount",6,
														   -1),
								   new Triplet<string, short, short?>("ReimbursementBillDetails_RowId",7,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_BillDocument",4,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_ItemDescription",5,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_ReimbursementId",1,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_BillDate",3,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_ReimbursementDetailsId",0,
														   -1),
								}
			},
							{"51CA1824-6689-43C9-A9D9-B360B3E6BBB8", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_P2_BillDate",3,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_ItemDescription",5,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_ReimbursementId",1,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_BillNo",2,
														   -1),
								   new Triplet<string, short, short?>("ReimbursementBillDetails_RowId",7,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_BillDocument",4,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_ReimbursementDetailsId",0,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_Amount",6,
														   -1),
								}
			},
							{"169C69C3-9492-4547-8D79-196C3E1309FB", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_P3_Amount",5,
														   -1),
								   new Triplet<string, short, short?>("ReimbursementFundDetails_RowId",6,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_FundDetailsId",0,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_ProjectDetailsId",3,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_FundTypeId",2,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_ReimbursementId",1,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_BudgetHeadId",4,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_Advanceformid",1,
														   -1),
								}
			},
							{"BDF250C2-7A24-4A8E-B094-E340FDE4659C", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_P3_FundDetailsId",0,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_ProjectDetailsId",3,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_Amount",5,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_ReimbursementId",1,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_Advanceformid",1,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_BudgetHeadId",4,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_FundTypeId",2,
														   -1),
								   new Triplet<string, short, short?>("ReimbursementFundDetails_RowId",6,
														   -1),
								}
			},
							{"CA798124-C2C4-46CC-BDA6-419353320A96", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("ActivityName",1,
														   -1),
								   new Triplet<string, short, short?>("Remarks",4,
														   -1),
								   new Triplet<string, short, short?>("UserName",2,
														   -1),
								   new Triplet<string, short, short?>("RemarksId",0,
														   -1),
								   new Triplet<string, short, short?>("DateOfRemarks",3,
														   -1),
								}
			},
					};	

	

		private Dictionary<string,string> formVersionList =new Dictionary<string,string> 
		{
							{"CE5B9B97-27CE-4812-ABB3-650ADC79D12E", "Medium"},
					};	

		
		private Dictionary<string,string> formVersionLayoutList =new Dictionary<string,string> 
		{
							{"30C11FF1-AB59-477E-9CCF-B5C287704944", ""},
							{"982B4FEE-F07C-43C9-821A-7971F8D0F5DC", ""},
							{"CE5B9B97-27CE-4812-ABB3-650ADC79D12E", ""},
							{"41E31511-B7DB-45A3-8E2D-13FBB540E344", ""},
							{"D76C0EDE-D6E2-4A5B-9CE3-26E87EE2FA33", ""},
							{"8BDC9ED4-061B-49D1-BCF4-C3883F79611F", ""},
							{"6E6EF850-0E3D-4C14-9281-9C2DB19C1AEA", ""},
							{"C85F20CB-E7F0-44FE-8309-8B65CED5DFE7", ""},
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
		
  







namespace CPS.Proof.DFSExtension
{
	
using System;
    using System.Collections.Generic;    
    using System.Text;	
    using System.Linq;	


	public partial class AcDataISpace893AB0C88E484E9C8DCDEF160F9C9A43  : ExtensionActivityBase
	{		
		
		
		private Dictionary<string,  List<Triplet<string, short, short?>>> queryExpressionBindings = 
											new Dictionary<string,  List<Triplet<string, short, short?>>>
		{
							{"AB481A6E-8735-4F09-AD1B-C0BBEFC0AD56", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_P2_BillNo",2,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_Amount",6,
														   -1),
								   new Triplet<string, short, short?>("ReimbursementBillDetails_RowId",7,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_BillDocument",4,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_ItemDescription",5,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_ReimbursementId",1,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_BillDate",3,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_ReimbursementDetailsId",0,
														   -1),
								}
			},
							{"51CA1824-6689-43C9-A9D9-B360B3E6BBB8", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_P2_BillDate",3,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_ItemDescription",5,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_ReimbursementId",1,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_BillNo",2,
														   -1),
								   new Triplet<string, short, short?>("ReimbursementBillDetails_RowId",7,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_BillDocument",4,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_ReimbursementDetailsId",0,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_Amount",6,
														   -1),
								}
			},
							{"169C69C3-9492-4547-8D79-196C3E1309FB", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_P3_Amount",5,
														   -1),
								   new Triplet<string, short, short?>("ReimbursementFundDetails_RowId",6,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_FundDetailsId",0,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_ProjectDetailsId",3,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_FundTypeId",2,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_ReimbursementId",1,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_BudgetHeadId",4,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_Advanceformid",1,
														   -1),
								}
			},
							{"BDF250C2-7A24-4A8E-B094-E340FDE4659C", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_P3_FundDetailsId",0,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_ProjectDetailsId",3,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_Amount",5,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_ReimbursementId",1,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_Advanceformid",1,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_BudgetHeadId",4,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_FundTypeId",2,
														   -1),
								   new Triplet<string, short, short?>("ReimbursementFundDetails_RowId",6,
														   -1),
								}
			},
							{"CA798124-C2C4-46CC-BDA6-419353320A96", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("ActivityName",1,
														   -1),
								   new Triplet<string, short, short?>("Remarks",4,
														   -1),
								   new Triplet<string, short, short?>("UserName",2,
														   -1),
								   new Triplet<string, short, short?>("RemarksId",0,
														   -1),
								   new Triplet<string, short, short?>("DateOfRemarks",3,
														   -1),
								}
			},
					};	

	

		private Dictionary<string,string> formVersionList =new Dictionary<string,string> 
		{
							{"CE5B9B97-27CE-4812-ABB3-650ADC79D12E", "Medium"},
					};	

		
		private Dictionary<string,string> formVersionLayoutList =new Dictionary<string,string> 
		{
							{"30C11FF1-AB59-477E-9CCF-B5C287704944", ""},
							{"982B4FEE-F07C-43C9-821A-7971F8D0F5DC", ""},
							{"CE5B9B97-27CE-4812-ABB3-650ADC79D12E", ""},
							{"41E31511-B7DB-45A3-8E2D-13FBB540E344", ""},
							{"D76C0EDE-D6E2-4A5B-9CE3-26E87EE2FA33", ""},
							{"8BDC9ED4-061B-49D1-BCF4-C3883F79611F", ""},
							{"6E6EF850-0E3D-4C14-9281-9C2DB19C1AEA", ""},
							{"C85F20CB-E7F0-44FE-8309-8B65CED5DFE7", ""},
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
		
  







namespace CPS.Proof.DFSExtension
{
	
using System;
    using System.Collections.Generic;    
    using System.Text;	
    using System.Linq;	


	public partial class AcDataISpace99884CE250CB494DB49B5828617FE860  : ExtensionActivityBase
	{		
		
		
		private Dictionary<string,  List<Triplet<string, short, short?>>> queryExpressionBindings = 
											new Dictionary<string,  List<Triplet<string, short, short?>>>
		{
							{"AB481A6E-8735-4F09-AD1B-C0BBEFC0AD56", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_P2_BillNo",2,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_Amount",6,
														   -1),
								   new Triplet<string, short, short?>("ReimbursementBillDetails_RowId",7,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_BillDocument",4,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_ItemDescription",5,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_ReimbursementId",1,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_BillDate",3,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_ReimbursementDetailsId",0,
														   -1),
								}
			},
							{"51CA1824-6689-43C9-A9D9-B360B3E6BBB8", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_P2_BillDate",3,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_ItemDescription",5,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_ReimbursementId",1,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_BillNo",2,
														   -1),
								   new Triplet<string, short, short?>("ReimbursementBillDetails_RowId",7,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_BillDocument",4,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_ReimbursementDetailsId",0,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_Amount",6,
														   -1),
								}
			},
							{"169C69C3-9492-4547-8D79-196C3E1309FB", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_P3_Amount",5,
														   -1),
								   new Triplet<string, short, short?>("ReimbursementFundDetails_RowId",6,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_FundDetailsId",0,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_ProjectDetailsId",3,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_FundTypeId",2,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_ReimbursementId",1,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_BudgetHeadId",4,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_Advanceformid",1,
														   -1),
								}
			},
							{"BDF250C2-7A24-4A8E-B094-E340FDE4659C", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_P3_FundDetailsId",0,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_ProjectDetailsId",3,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_Amount",5,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_ReimbursementId",1,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_Advanceformid",1,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_BudgetHeadId",4,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_FundTypeId",2,
														   -1),
								   new Triplet<string, short, short?>("ReimbursementFundDetails_RowId",6,
														   -1),
								}
			},
							{"CA798124-C2C4-46CC-BDA6-419353320A96", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("ActivityName",1,
														   -1),
								   new Triplet<string, short, short?>("Remarks",4,
														   -1),
								   new Triplet<string, short, short?>("UserName",2,
														   -1),
								   new Triplet<string, short, short?>("RemarksId",0,
														   -1),
								   new Triplet<string, short, short?>("DateOfRemarks",3,
														   -1),
								}
			},
					};	

	

		private Dictionary<string,string> formVersionList =new Dictionary<string,string> 
		{
							{"CE5B9B97-27CE-4812-ABB3-650ADC79D12E", "Medium"},
					};	

		
		private Dictionary<string,string> formVersionLayoutList =new Dictionary<string,string> 
		{
							{"30C11FF1-AB59-477E-9CCF-B5C287704944", ""},
							{"982B4FEE-F07C-43C9-821A-7971F8D0F5DC", ""},
							{"CE5B9B97-27CE-4812-ABB3-650ADC79D12E", ""},
							{"41E31511-B7DB-45A3-8E2D-13FBB540E344", ""},
							{"D76C0EDE-D6E2-4A5B-9CE3-26E87EE2FA33", ""},
							{"8BDC9ED4-061B-49D1-BCF4-C3883F79611F", ""},
							{"6E6EF850-0E3D-4C14-9281-9C2DB19C1AEA", ""},
							{"C85F20CB-E7F0-44FE-8309-8B65CED5DFE7", ""},
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
		
  







namespace CPS.Proof.DFSExtension
{
	
using System;
    using System.Collections.Generic;    
    using System.Text;	
    using System.Linq;	


	public partial class AcDataISpace9FE779D2129C47A2B87D173C6AFE51CB  : ExtensionActivityBase
	{		
		
		
		private Dictionary<string,  List<Triplet<string, short, short?>>> queryExpressionBindings = 
											new Dictionary<string,  List<Triplet<string, short, short?>>>
		{
							{"AB481A6E-8735-4F09-AD1B-C0BBEFC0AD56", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_P2_BillNo",2,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_Amount",6,
														   -1),
								   new Triplet<string, short, short?>("ReimbursementBillDetails_RowId",7,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_BillDocument",4,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_ItemDescription",5,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_ReimbursementId",1,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_BillDate",3,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_ReimbursementDetailsId",0,
														   -1),
								}
			},
							{"51CA1824-6689-43C9-A9D9-B360B3E6BBB8", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_P2_BillDate",3,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_ItemDescription",5,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_ReimbursementId",1,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_BillNo",2,
														   -1),
								   new Triplet<string, short, short?>("ReimbursementBillDetails_RowId",7,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_BillDocument",4,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_ReimbursementDetailsId",0,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_Amount",6,
														   -1),
								}
			},
							{"169C69C3-9492-4547-8D79-196C3E1309FB", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_P3_Amount",5,
														   -1),
								   new Triplet<string, short, short?>("ReimbursementFundDetails_RowId",6,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_FundDetailsId",0,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_ProjectDetailsId",3,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_FundTypeId",2,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_ReimbursementId",1,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_BudgetHeadId",4,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_Advanceformid",1,
														   -1),
								}
			},
							{"BDF250C2-7A24-4A8E-B094-E340FDE4659C", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_P3_FundDetailsId",0,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_ProjectDetailsId",3,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_Amount",5,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_ReimbursementId",1,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_Advanceformid",1,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_BudgetHeadId",4,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_FundTypeId",2,
														   -1),
								   new Triplet<string, short, short?>("ReimbursementFundDetails_RowId",6,
														   -1),
								}
			},
							{"CA798124-C2C4-46CC-BDA6-419353320A96", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("ActivityName",1,
														   -1),
								   new Triplet<string, short, short?>("Remarks",4,
														   -1),
								   new Triplet<string, short, short?>("UserName",2,
														   -1),
								   new Triplet<string, short, short?>("RemarksId",0,
														   -1),
								   new Triplet<string, short, short?>("DateOfRemarks",3,
														   -1),
								}
			},
					};	

	

		private Dictionary<string,string> formVersionList =new Dictionary<string,string> 
		{
							{"CE5B9B97-27CE-4812-ABB3-650ADC79D12E", "Medium"},
					};	

		
		private Dictionary<string,string> formVersionLayoutList =new Dictionary<string,string> 
		{
							{"30C11FF1-AB59-477E-9CCF-B5C287704944", ""},
							{"982B4FEE-F07C-43C9-821A-7971F8D0F5DC", ""},
							{"CE5B9B97-27CE-4812-ABB3-650ADC79D12E", ""},
							{"41E31511-B7DB-45A3-8E2D-13FBB540E344", ""},
							{"D76C0EDE-D6E2-4A5B-9CE3-26E87EE2FA33", ""},
							{"8BDC9ED4-061B-49D1-BCF4-C3883F79611F", ""},
							{"6E6EF850-0E3D-4C14-9281-9C2DB19C1AEA", ""},
							{"C85F20CB-E7F0-44FE-8309-8B65CED5DFE7", ""},
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
		
  







namespace CPS.Proof.DFSExtension
{
	
using System;
    using System.Collections.Generic;    
    using System.Text;	
    using System.Linq;	


	public partial class AcDataISpace69B6AE86D2BA40489EE6B4627B21F951  : ExtensionActivityBase
	{		
		
		
		private Dictionary<string,  List<Triplet<string, short, short?>>> queryExpressionBindings = 
											new Dictionary<string,  List<Triplet<string, short, short?>>>
		{
							{"D8C74C9B-035C-46A4-93E2-CAE4FECC1DA7", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_YetToReceive",2,
														   -1),
								   new Triplet<string, short, short?>("MG_Balance",6,
														   -1),
								   new Triplet<string, short, short?>("MG_ReceivedAmount",3,
														   -1),
								   new Triplet<string, short, short?>("MG_Commitment",4,
														   -1),
								   new Triplet<string, short, short?>("MG_SanctionedAmount",1,
														   -1),
								   new Triplet<string, short, short?>("MG_Spent",5,
														   -1),
								   new Triplet<string, short, short?>("MG_BudgetName",0,
														   -1),
								}
			},
							{"169C69C3-9492-4547-8D79-196C3E1309FB", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_P3_Amount",5,
														   -1),
								   new Triplet<string, short, short?>("ReimbursementFundDetails_RowId",6,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_FundDetailsId",0,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_ProjectDetailsId",3,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_FundTypeId",2,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_ReimbursementId",1,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_BudgetHeadId",4,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_Advanceformid",1,
														   -1),
								}
			},
							{"BDF250C2-7A24-4A8E-B094-E340FDE4659C", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_P3_FundDetailsId",0,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_ProjectDetailsId",3,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_Amount",5,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_ReimbursementId",1,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_Advanceformid",1,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_BudgetHeadId",4,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_FundTypeId",2,
														   -1),
								   new Triplet<string, short, short?>("ReimbursementFundDetails_RowId",6,
														   -1),
								}
			},
							{"CA798124-C2C4-46CC-BDA6-419353320A96", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("ActivityName",1,
														   -1),
								   new Triplet<string, short, short?>("Remarks",4,
														   -1),
								   new Triplet<string, short, short?>("UserName",2,
														   -1),
								   new Triplet<string, short, short?>("RemarksId",0,
														   -1),
								   new Triplet<string, short, short?>("DateOfRemarks",3,
														   -1),
								}
			},
					};	

	

		private Dictionary<string,string> formVersionList =new Dictionary<string,string> 
		{
							{"CE5B9B97-27CE-4812-ABB3-650ADC79D12E", "Medium"},
					};	

		
		private Dictionary<string,string> formVersionLayoutList =new Dictionary<string,string> 
		{
							{"30C11FF1-AB59-477E-9CCF-B5C287704944", ""},
							{"982B4FEE-F07C-43C9-821A-7971F8D0F5DC", ""},
							{"CE5B9B97-27CE-4812-ABB3-650ADC79D12E", ""},
							{"41E31511-B7DB-45A3-8E2D-13FBB540E344", ""},
							{"D76C0EDE-D6E2-4A5B-9CE3-26E87EE2FA33", ""},
							{"8BDC9ED4-061B-49D1-BCF4-C3883F79611F", ""},
							{"6E6EF850-0E3D-4C14-9281-9C2DB19C1AEA", ""},
							{"C85F20CB-E7F0-44FE-8309-8B65CED5DFE7", ""},
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
		
  







namespace CPS.Proof.DFSExtension
{
	
using System;
    using System.Collections.Generic;    
    using System.Text;	
    using System.Linq;	


	public partial class AcDataISpaceD8627A0AFE2847709EEEC6A8CFD2FD85  : ExtensionActivityBase
	{		
		
		
		private Dictionary<string,  List<Triplet<string, short, short?>>> queryExpressionBindings = 
											new Dictionary<string,  List<Triplet<string, short, short?>>>
		{
							{"CA798124-C2C4-46CC-BDA6-419353320A96", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("ActivityName",1,
														   -1),
								   new Triplet<string, short, short?>("Remarks",4,
														   -1),
								   new Triplet<string, short, short?>("UserName",2,
														   -1),
								   new Triplet<string, short, short?>("RemarksId",0,
														   -1),
								   new Triplet<string, short, short?>("DateOfRemarks",3,
														   -1),
								}
			},
					};	

	

		private Dictionary<string,string> formVersionList =new Dictionary<string,string> 
		{
							{"30C11FF1-AB59-477E-9CCF-B5C287704944", "Mobile-Hybrid"},
							{"982B4FEE-F07C-43C9-821A-7971F8D0F5DC", "Tab"},
							{"CE5B9B97-27CE-4812-ABB3-650ADC79D12E", "Medium"},
							{"41E31511-B7DB-45A3-8E2D-13FBB540E344", "Large"},
							{"D76C0EDE-D6E2-4A5B-9CE3-26E87EE2FA33", "AR"},
							{"8BDC9ED4-061B-49D1-BCF4-C3883F79611F", "MR"},
							{"6E6EF850-0E3D-4C14-9281-9C2DB19C1AEA", "HHT"},
							{"C85F20CB-E7F0-44FE-8309-8B65CED5DFE7", "Mobile-Native"},
					};	

		
		private Dictionary<string,string> formVersionLayoutList =new Dictionary<string,string> 
		{
							{"30C11FF1-AB59-477E-9CCF-B5C287704944", ""},
							{"982B4FEE-F07C-43C9-821A-7971F8D0F5DC", ""},
							{"CE5B9B97-27CE-4812-ABB3-650ADC79D12E", ""},
							{"41E31511-B7DB-45A3-8E2D-13FBB540E344", ""},
							{"D76C0EDE-D6E2-4A5B-9CE3-26E87EE2FA33", ""},
							{"8BDC9ED4-061B-49D1-BCF4-C3883F79611F", ""},
							{"6E6EF850-0E3D-4C14-9281-9C2DB19C1AEA", ""},
							{"C85F20CB-E7F0-44FE-8309-8B65CED5DFE7", ""},
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
		
  







namespace CPS.Proof.DFSExtension
{
	
using System;
    using System.Collections.Generic;    
    using System.Text;	
    using System.Linq;	


	public partial class AcDataISpace64C9C32BA8F44F1AB13A74724BDB17FE  : ExtensionActivityBase
	{		
		
		
		private Dictionary<string,  List<Triplet<string, short, short?>>> queryExpressionBindings = 
											new Dictionary<string,  List<Triplet<string, short, short?>>>
		{
							{"CA798124-C2C4-46CC-BDA6-419353320A96", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("ActivityName",1,
														   -1),
								   new Triplet<string, short, short?>("Remarks",4,
														   -1),
								   new Triplet<string, short, short?>("UserName",2,
														   -1),
								   new Triplet<string, short, short?>("RemarksId",0,
														   -1),
								   new Triplet<string, short, short?>("DateOfRemarks",3,
														   -1),
								}
			},
					};	

	

		private Dictionary<string,string> formVersionList =new Dictionary<string,string> 
		{
							{"30C11FF1-AB59-477E-9CCF-B5C287704944", "Mobile-Hybrid"},
							{"982B4FEE-F07C-43C9-821A-7971F8D0F5DC", "Tab"},
							{"CE5B9B97-27CE-4812-ABB3-650ADC79D12E", "Medium"},
							{"41E31511-B7DB-45A3-8E2D-13FBB540E344", "Large"},
							{"D76C0EDE-D6E2-4A5B-9CE3-26E87EE2FA33", "AR"},
							{"8BDC9ED4-061B-49D1-BCF4-C3883F79611F", "MR"},
							{"6E6EF850-0E3D-4C14-9281-9C2DB19C1AEA", "HHT"},
							{"C85F20CB-E7F0-44FE-8309-8B65CED5DFE7", "Mobile-Native"},
					};	

		
		private Dictionary<string,string> formVersionLayoutList =new Dictionary<string,string> 
		{
							{"30C11FF1-AB59-477E-9CCF-B5C287704944", ""},
							{"982B4FEE-F07C-43C9-821A-7971F8D0F5DC", ""},
							{"CE5B9B97-27CE-4812-ABB3-650ADC79D12E", ""},
							{"41E31511-B7DB-45A3-8E2D-13FBB540E344", ""},
							{"D76C0EDE-D6E2-4A5B-9CE3-26E87EE2FA33", ""},
							{"8BDC9ED4-061B-49D1-BCF4-C3883F79611F", ""},
							{"6E6EF850-0E3D-4C14-9281-9C2DB19C1AEA", ""},
							{"C85F20CB-E7F0-44FE-8309-8B65CED5DFE7", ""},
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
		
  







namespace CPS.Proof.DFSExtension
{
	
using System;
    using System.Collections.Generic;    
    using System.Text;	
    using System.Linq;	


	public partial class AcDataISpaceBD4B416FE1844A6FB8DE4D2B42649FF4  : ExtensionActivityBase
	{		
		
		
		private Dictionary<string,  List<Triplet<string, short, short?>>> queryExpressionBindings = 
											new Dictionary<string,  List<Triplet<string, short, short?>>>
		{
							{"CA798124-C2C4-46CC-BDA6-419353320A96", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("ActivityName",1,
														   -1),
								   new Triplet<string, short, short?>("Remarks",4,
														   -1),
								   new Triplet<string, short, short?>("UserName",2,
														   -1),
								   new Triplet<string, short, short?>("RemarksId",0,
														   -1),
								   new Triplet<string, short, short?>("DateOfRemarks",3,
														   -1),
								}
			},
					};	

	

		private Dictionary<string,string> formVersionList =new Dictionary<string,string> 
		{
							{"CE5B9B97-27CE-4812-ABB3-650ADC79D12E", "Medium"},
					};	

		
		private Dictionary<string,string> formVersionLayoutList =new Dictionary<string,string> 
		{
							{"30C11FF1-AB59-477E-9CCF-B5C287704944", ""},
							{"982B4FEE-F07C-43C9-821A-7971F8D0F5DC", ""},
							{"CE5B9B97-27CE-4812-ABB3-650ADC79D12E", ""},
							{"41E31511-B7DB-45A3-8E2D-13FBB540E344", ""},
							{"D76C0EDE-D6E2-4A5B-9CE3-26E87EE2FA33", ""},
							{"8BDC9ED4-061B-49D1-BCF4-C3883F79611F", ""},
							{"6E6EF850-0E3D-4C14-9281-9C2DB19C1AEA", ""},
							{"C85F20CB-E7F0-44FE-8309-8B65CED5DFE7", ""},
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
		
  







namespace CPS.Proof.DFSExtension
{
	
using System;
    using System.Collections.Generic;    
    using System.Text;	
    using System.Linq;	


	public partial class AcDataISpace073F304CFEDE46418B25F5F06D2A6CD2  : ExtensionActivityBase
	{		
		
		
		private Dictionary<string,  List<Triplet<string, short, short?>>> queryExpressionBindings = 
											new Dictionary<string,  List<Triplet<string, short, short?>>>
		{
							{"CA798124-C2C4-46CC-BDA6-419353320A96", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("ActivityName",1,
														   -1),
								   new Triplet<string, short, short?>("Remarks",4,
														   -1),
								   new Triplet<string, short, short?>("UserName",2,
														   -1),
								   new Triplet<string, short, short?>("RemarksId",0,
														   -1),
								   new Triplet<string, short, short?>("DateOfRemarks",3,
														   -1),
								}
			},
					};	

	

		private Dictionary<string,string> formVersionList =new Dictionary<string,string> 
		{
							{"CE5B9B97-27CE-4812-ABB3-650ADC79D12E", "Medium"},
					};	

		
		private Dictionary<string,string> formVersionLayoutList =new Dictionary<string,string> 
		{
							{"30C11FF1-AB59-477E-9CCF-B5C287704944", ""},
							{"982B4FEE-F07C-43C9-821A-7971F8D0F5DC", ""},
							{"CE5B9B97-27CE-4812-ABB3-650ADC79D12E", ""},
							{"41E31511-B7DB-45A3-8E2D-13FBB540E344", ""},
							{"D76C0EDE-D6E2-4A5B-9CE3-26E87EE2FA33", ""},
							{"8BDC9ED4-061B-49D1-BCF4-C3883F79611F", ""},
							{"6E6EF850-0E3D-4C14-9281-9C2DB19C1AEA", ""},
							{"C85F20CB-E7F0-44FE-8309-8B65CED5DFE7", ""},
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
		


