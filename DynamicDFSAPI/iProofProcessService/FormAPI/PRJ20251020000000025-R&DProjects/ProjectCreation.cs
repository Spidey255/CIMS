  







namespace CPS.Proof.DFSExtension
{
	using System;
    using System.Collections.Generic;     
	using System.Linq;
	
	
	public partial class ProjectCreationProcessMetadata : ExtensionProcessBase
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
            get { return "b92107f7-28a5-49d0-8b7f-312c4826dd60"; }
        }

        public override string ProcessName
        {
            get { return "ProjectCreation"; }
        }

		public override string ProcessDescription
        {
            get { return "Project Creation"; }
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
            get {return "b92107f7-28a5-49d0-8b7f-312c4826dd60";}
        }

		public override byte ProcessInstanceMode
        {
            get {return 3;}
        }		

		public override string MasterFormId
        {
            get {  
				   return "7F2113FD-876A-41F4-BEAC-881CA7D38469";	}
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
	

	public partial class ProjectCreationObjectFactory  : ExtObjectFactoryBase
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
        //    return (IExtBaseMetaData)new ProjectCreationProcessMetadata();
        //}
	


		private List<Triplet<string, string, string>> queryExpressionData = new List<Triplet<string, string, string>>
		{
	  			
			     new Triplet<string, string, string>("c3995c1b-9f1a-f85f-ab71-5bef2a0b203e","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("61e7d773-40d3-95e9-2de5-549773196e79","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"062C4298-5FB2-4C83-877D-A1D5795686CF"),
			
						
			     new Triplet<string, string, string>("eae2baeb-d143-cc0a-8acf-8c0f81dbfb8a","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("A74347A4-C3F2-4207-8D0D-320D67D9EB3D","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("430846EA-3E49-4909-8632-AC7C0F753F81","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("3E77697F-9C9B-4F70-86A4-EEAF4AAF6937","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("A5343EC8-F5DC-490F-A308-848B457A1F27","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("45376063-88E0-46C8-81D3-04F87FA722B3","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("7c4d94f1-2381-b2c2-c38d-941e8dba8928","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"062C4298-5FB2-4C83-877D-A1D5795686CF"),
			
						
			     new Triplet<string, string, string>("2ed62a73-b6f2-34b7-c20c-dca9b5617146","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("598a64be-325b-1665-a4f0-dc3818c98d36","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"24F5D845-D560-4FC1-B284-00FB19DFB96F"),
			
						
			     new Triplet<string, string, string>("6c6e361f-5060-32e3-99f8-6f2090aa1e0c","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"028B1EFF-34A8-4D44-BF39-06CE99DF7C67"),
			
						
			     new Triplet<string, string, string>("022d541e-ff48-f7a6-f4a9-bbfb60447b55","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("BE17AA72-8920-4740-9BFC-07684FE3DC81","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("9016218E-681F-4C98-8D07-8CD16398F368","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("8312F8DC-B3DC-4046-A85C-AB4A0BF47147","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("DAF6212E-F441-46B2-8C44-E04A8B145F28","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("C0AAD464-4920-49A8-A4E3-0AB336803E58","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("682312DA-B0C6-4126-810E-552155F7C406","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("906fc07f-3f3b-c1be-93f7-44636c228555","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("9cc2bc31-cc30-0ba3-4ad6-22f9e9abf5d5","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("5b1d3894-0d72-9c8d-3a5f-8fe772ffa261","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("502df243-ca8b-5455-c370-be23ac6857ac","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("cfc8b06a-84f1-8ec2-a3f3-3b615821582c","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"24F5D845-D560-4FC1-B284-00FB19DFB96F"),
			
						
			     new Triplet<string, string, string>("61e7d773-40d3-95e9-2de5-549773196e79","Load Data",
												     @"08F73C4A-3B94-4327-8859-B98388D1C9CD"),
			
						
			     new Triplet<string, string, string>("7c4d94f1-2381-b2c2-c38d-941e8dba8928","Load Data",
												     @"25683F52-E21A-4CE3-9196-7BCFA640A94B"),
			
						
			     new Triplet<string, string, string>("598a64be-325b-1665-a4f0-dc3818c98d36","Load History Details Based On Form Load",
												     @"f1825943-98b5-f54f-0225-0081ef436f94"),
			
						
			     new Triplet<string, string, string>("BE17AA72-8920-4740-9BFC-07684FE3DC81","Load Grid By IdRDDocumentGrid",
												     @"6677BAB3-659A-4A96-9067-5D365F60CB62"),
			
						
			     new Triplet<string, string, string>("9016218E-681F-4C98-8D07-8CD16398F368","Load Grid By IdEquipmentGrid",
												     @"08F73C4A-3B94-4327-8859-B98388D1C9CD"),
			
						
			     new Triplet<string, string, string>("8312F8DC-B3DC-4046-A85C-AB4A0BF47147","Load Grid By IdManpowerGrid",
												     @"25683F52-E21A-4CE3-9196-7BCFA640A94B"),
			
						
			     new Triplet<string, string, string>("C0AAD464-4920-49A8-A4E3-0AB336803E58","Load Grid By IdBudgetAllocation",
												     @"B73036BB-FE7D-4B0D-998A-985294F8FC5B"),
			
						
			     new Triplet<string, string, string>("682312DA-B0C6-4126-810E-552155F7C406","Load Grid By IdExternalCoPiGrid",
												     @"59259E21-AFE8-4DAB-A543-74CC22FC79D5"),
			
						
			     new Triplet<string, string, string>("906fc07f-3f3b-c1be-93f7-44636c228555","Load Project Budget Details",
												     @"B73036BB-FE7D-4B0D-998A-985294F8FC5B"),
			
						
			     new Triplet<string, string, string>("5b1d3894-0d72-9c8d-3a5f-8fe772ffa261","CoPi Grid Load",
												     @"59259E21-AFE8-4DAB-A543-74CC22FC79D5"),
			
			
			
		};


		
		private List<Triplet<string, string, string>> ComboDataSource = new List<Triplet<string, string, string>>
		{

		
	  			
			
			     new Triplet<string, string, string>("MF_d10_YearMonth","3A103712-5244-4427-B2B6-1C4E046FD337",
												     @"EXEC GetDateDifferenceInYears 5,'','',''"),
			
						
			
			     new Triplet<string, string, string>("MF_d10_ProjectproposalID","3A103712-5244-4427-B2B6-1C4E046FD337",
												     @"EXEC [GetProjectproposalDetails] 1,'@MF_d10_ProjectDetailsID','@MF_d10_EmployeeBasicInfoId'"),
			
						
			
			     new Triplet<string, string, string>("MF_d10_ProjectCategoryID","3A103712-5244-4427-B2B6-1C4E046FD337",
												     @"EXEC GetDateDifferenceInYears 4,'','',''"),
			
						
			
			     new Triplet<string, string, string>("MF_d10_FundingAgency","3A103712-5244-4427-B2B6-1C4E046FD337",
												     @"EXEC GetDateDifferenceInYears 7,'','',''"),
			
						
			
			     new Triplet<string, string, string>("MF_d10_Sector","3A103712-5244-4427-B2B6-1C4E046FD337",
												     @"EXEC GetGlobalCombo 1,'Sectortype'"),
			
						
			
			     new Triplet<string, string, string>("MF_d10_FundReceiptMode","3A103712-5244-4427-B2B6-1C4E046FD337",
												     @"Exec GetFundReceiptMode"),
			
						
			
			     new Triplet<string, string, string>("MF_d10_FinancialYearID","3A103712-5244-4427-B2B6-1C4E046FD337",
												     @"EXEC GetDateDifferenceInYears 8,'','',''"),
			
						
			
			     new Triplet<string, string, string>("MG_d154_ManpowerPosition","3A103712-5244-4427-B2B6-1C4E046FD337",
												     @"EXEC [GetProjectDetailCombo] 14"),
			
						
			
			     new Triplet<string, string, string>("MF_d10_SchemeID","3A103712-5244-4427-B2B6-1C4E046FD337",
												     @"Exec GetBudgetSchema"),
			
						
			
			     new Triplet<string, string, string>("M_MoveTo","24F5D845-D560-4FC1-B284-00FB19DFB96F",
												     @"EXEC GetNextStep '@MF_d10_InstanceId','@M_FlowType'"),
			
						
			
			     new Triplet<string, string, string>("m_currency","3A103712-5244-4427-B2B6-1C4E046FD337",
												     @"EXEC GetCurrency"),
			
						
			
			     new Triplet<string, string, string>("MF_d10_ProjectType","3A103712-5244-4427-B2B6-1C4E046FD337",
												     @"EXEC GetProjectDetailCombo 2"),
			
						
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
		
	  			
			     new Tuple<string, int>("RDDocumentGrid",5),
			
						
			     new Tuple<string, int>("ManpowerGrid",50),
			
						
			     new Tuple<string, int>("EquipmentGrid",5),
			
						
			     new Tuple<string, int>("BudgetAllocation",100),
			
						
			     new Tuple<string, int>("ExternalCoPiGrid",50),
			
						
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
											case "E1B5DCB8-1278-4AA0-A8B2-1C0CDE17E77A":
							virtualInstance=new ISpaceE1B5DCB812784AA0A8B21C0CDE17E77A();
							break;
					
											case "BD6CC522-F7E6-46CB-B200-9C41F448175B":
							virtualInstance=new ISpaceBD6CC522F7E646CBB2009C41F448175B();
							break;
					
											case "218B0C87-E3E2-4D2E-BB8F-B38C51CAD1FE":
							virtualInstance=new ISpace218B0C87E3E24D2EBB8FB38C51CAD1FE();
							break;
					
											case "88470FA8-05F7-4764-A871-E9DAC8F66C89":
							virtualInstance=new ISpace88470FA805F74764A871E9DAC8F66C89();
							break;
					
											case "DC6D256C-5F94-4FE5-9309-FD74A0FF257E":
							virtualInstance=new ISpaceDC6D256C5F944FE59309FD74A0FF257E();
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
	

	public partial class ProjectCreationDataElementFactory  : ExtElementBase
    {

     /// <summary>
        /// A <see cref="log4net.ILog"/> that contains the logger instance for 
        /// logging
        /// </summary>
        private readonly ILog _sysLog;

        public ProjectCreationDataElementFactory()
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

               
                
                                      case "7F2113FD-876A-41F4-BEAC-881CA7D38469":
                    {
                     
                                     fInsertQuery=@"IF NOT EXISTS(SELECT 1 FROM [7F2113FD-876A-41F4-BEAC-881CA7D38469] WHERE InstanceId='{0}') BEGIN INSERT INTO [7F2113FD-876A-41F4-BEAC-881CA7D38469](ProcessActivityMapId,FormId,MF_d10_Sector,MF_d10_ProjectDetailsID,MF_d10_InstanceId,MF_d10_ProjectCode,MF_d10_ProjectRefNo,MF_d10_EmployeeBasicInfoId,MF_d10_ActualDate,MF_d10_ActualEndDate,MF_d10_NonRecurringAmount,MF_d10_RecurringAmount,MF_d10_IfExtended,MF_d10_ExtendedDate,MF_d10_BudgetTotalAmount,MF_d10_Overhead,MF_d10_ExchangeRate,MF_d10_DocumentComments,MF_d19_OverallAmount,MF_d145_OverallTotalCost,Subject,ExecutionStatus,ExecutionMessage,SetDestinationTo,SLATime,AssignToRole,AssignToUser,IN_Priority,IN_InstanceName,IN_SLA,IN_Status,IN_Category,ExecuteCommand,RedirectUrl,Thumbnail,CancelRedirectUrl,KeyContext,DisplayContext,growid,MF_d10_FinancialYearID,MF_d10_ProjectName,MF_d10_Duration,MF_d10_IfManpower,MF_d10_IfEquipment,MF_d10_IsExternalIns,MF_d10_FundReceiptMode,MF_d10_PrincipalInvestigator,MF_d10_ProjectproposalID,MF_d10_SanctionedNumber,MF_d10_DepartmentID,MF_d10_SchemeID,MF_d10_FundingAgency,MF_d10_YearMonth,MF_d10_ProjectStatus,MF_d10_Designation,MF_d10_ProjectCategoryID,MF_d10_IsSubmitted,MF_d10_SanctionedDate,MF_d10_FromDate,MF_d10_ToDate,MF_d10_ProjectBudget,MF_d10_ProjectType,InstanceId,M_MoveTo,m_currency,m_typeofproject,MF_d10_RecurringValidation,MF_ManPowerTotal,MF_EquipmentTotal,MF_d10_EmployeeCode,MF_d10_EmpDeptCode,MF_Counter,Comments,M_FlowType,ErrId,ErrMsg)
							VALUES( {3}) END ELSE BEGIN UPDATE [7F2113FD-876A-41F4-BEAC-881CA7D38469]SET {4}WHERE InstanceId='{0}'END ";

                                     colList=@"ProcessActivityMapId,FormId,MF_d10_Sector,MF_d10_ProjectDetailsID,MF_d10_InstanceId,MF_d10_ProjectCode,MF_d10_ProjectRefNo,MF_d10_EmployeeBasicInfoId,MF_d10_ActualDate,MF_d10_ActualEndDate,MF_d10_NonRecurringAmount,MF_d10_RecurringAmount,MF_d10_IfExtended,MF_d10_ExtendedDate,MF_d10_BudgetTotalAmount,MF_d10_Overhead,MF_d10_ExchangeRate,MF_d10_DocumentComments,MF_d19_OverallAmount,MF_d145_OverallTotalCost,Subject,ExecutionStatus,ExecutionMessage,SetDestinationTo,SLATime,AssignToRole,AssignToUser,IN_Priority,IN_InstanceName,IN_SLA,IN_Status,IN_Category,ExecuteCommand,RedirectUrl,Thumbnail,CancelRedirectUrl,KeyContext,DisplayContext,growid,MF_d10_FinancialYearID,MF_d10_ProjectName,MF_d10_Duration,MF_d10_IfManpower,MF_d10_IfEquipment,MF_d10_IsExternalIns,MF_d10_FundReceiptMode,MF_d10_PrincipalInvestigator,MF_d10_ProjectproposalID,MF_d10_SanctionedNumber,MF_d10_DepartmentID,MF_d10_SchemeID,MF_d10_FundingAgency,MF_d10_YearMonth,MF_d10_ProjectStatus,MF_d10_Designation,MF_d10_ProjectCategoryID,MF_d10_IsSubmitted,MF_d10_SanctionedDate,MF_d10_FromDate,MF_d10_ToDate,MF_d10_ProjectBudget,MF_d10_ProjectType,InstanceId,M_MoveTo,m_currency,m_typeofproject,MF_d10_RecurringValidation,MF_ManPowerTotal,MF_EquipmentTotal,MF_d10_EmployeeCode,MF_d10_EmpDeptCode,MF_Counter,Comments,M_FlowType,ErrId,ErrMsg";
                                    
                     
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

                
                 
                                      case "B73036BB-FE7D-4B0D-998A-985294F8FC5B":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_B73036BBFE7D4B0D998A985294F8FC5B AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_d28_RecurringValidation] INT	, [MG_d28_Reappropriation] DECIMAL(18,2)	, [MG_d28_BudgetID] VARCHAR(MAX)	, [MG_d28_BudgetAmount] DECIMAL(18,2)	, [MG_d28_Comments] VARCHAR(MAX)	, [MG_d28_RDOfficeComments] VARCHAR(MAX)	, [MG_d28_Justiifcation] VARCHAR(MAX)	, [MG_d28_JustiifcationbyHoD] VARCHAR(MAX)	, [MG_d28_Year1] DECIMAL(18,2)	, [MG_d28_Year2] DECIMAL(18,2)	, [MG_d28_Year3] DECIMAL(18,2)	, [MG_d28_Year4] DECIMAL(18,2)	, [MG_d28_Year5] DECIMAL(18,2)	, [MG_d28_Year6] DECIMAL(18,2)	, [MG_d28_Year7] DECIMAL(18,2)	, [MG_d28_Year8] DECIMAL(18,2)	, [MG_d28_Year9] DECIMAL(18,2)	, [MG_d28_Year10] DECIMAL(18,2)	, [MG_d28_Year11] DECIMAL(18,2)	, [MG_d28_Year12] DECIMAL(18,2)	, [MG_d28_BudgetHead] VARCHAR(MAX)	, [MG_d28_BudgetDetailsId] VARCHAR(MAX)){0}INSERT INTO [B73036BB-FE7D-4B0D-998A-985294F8FC5B](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d28_RecurringValidation,MG_d28_Reappropriation,MG_d28_BudgetID,MG_d28_BudgetAmount,MG_d28_Comments,MG_d28_RDOfficeComments,MG_d28_Justiifcation,MG_d28_JustiifcationbyHoD,MG_d28_Year1,MG_d28_Year2,MG_d28_Year3,MG_d28_Year4,MG_d28_Year5,MG_d28_Year6,MG_d28_Year7,MG_d28_Year8,MG_d28_Year9,MG_d28_Year10,MG_d28_Year11,MG_d28_Year12,MG_d28_BudgetHead,MG_d28_BudgetDetailsId)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_d28_RecurringValidation,TDT.MG_d28_Reappropriation,TDT.MG_d28_BudgetID,TDT.MG_d28_BudgetAmount,TDT.MG_d28_Comments,TDT.MG_d28_RDOfficeComments,TDT.MG_d28_Justiifcation,TDT.MG_d28_JustiifcationbyHoD,TDT.MG_d28_Year1,TDT.MG_d28_Year2,TDT.MG_d28_Year3,TDT.MG_d28_Year4,TDT.MG_d28_Year5,TDT.MG_d28_Year6,TDT.MG_d28_Year7,TDT.MG_d28_Year8,TDT.MG_d28_Year9,TDT.MG_d28_Year10,TDT.MG_d28_Year11,TDT.MG_d28_Year12,TDT.MG_d28_BudgetHead,TDT.MG_d28_BudgetDetailsId FROM @TBL_B73036BBFE7D4B0D998A985294F8FC5B TDT
							LEFT JOIN [B73036BB-FE7D-4B0D-998A-985294F8FC5B] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MG_d28_RecurringValidation=TDT.MG_d28_RecurringValidation,MG_d28_Reappropriation=TDT.MG_d28_Reappropriation,MG_d28_BudgetID=TDT.MG_d28_BudgetID,MG_d28_BudgetAmount=TDT.MG_d28_BudgetAmount,MG_d28_Comments=TDT.MG_d28_Comments,MG_d28_RDOfficeComments=TDT.MG_d28_RDOfficeComments,MG_d28_Justiifcation=TDT.MG_d28_Justiifcation,MG_d28_JustiifcationbyHoD=TDT.MG_d28_JustiifcationbyHoD,MG_d28_Year1=TDT.MG_d28_Year1,MG_d28_Year2=TDT.MG_d28_Year2,MG_d28_Year3=TDT.MG_d28_Year3,MG_d28_Year4=TDT.MG_d28_Year4,MG_d28_Year5=TDT.MG_d28_Year5,MG_d28_Year6=TDT.MG_d28_Year6,MG_d28_Year7=TDT.MG_d28_Year7,MG_d28_Year8=TDT.MG_d28_Year8,MG_d28_Year9=TDT.MG_d28_Year9,MG_d28_Year10=TDT.MG_d28_Year10,MG_d28_Year11=TDT.MG_d28_Year11,MG_d28_Year12=TDT.MG_d28_Year12,MG_d28_BudgetHead=TDT.MG_d28_BudgetHead,MG_d28_BudgetDetailsId=TDT.MG_d28_BudgetDetailsId FROM @TBL_B73036BBFE7D4B0D998A985294F8FC5B TDT
							JOIN [B73036BB-FE7D-4B0D-998A-985294F8FC5B] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d28_RecurringValidation,MG_d28_Reappropriation,MG_d28_BudgetID,MG_d28_BudgetAmount,MG_d28_Comments,MG_d28_RDOfficeComments,MG_d28_Justiifcation,MG_d28_JustiifcationbyHoD,MG_d28_Year1,MG_d28_Year2,MG_d28_Year3,MG_d28_Year4,MG_d28_Year5,MG_d28_Year6,MG_d28_Year7,MG_d28_Year8,MG_d28_Year9,MG_d28_Year10,MG_d28_Year11,MG_d28_Year12,MG_d28_BudgetHead,MG_d28_BudgetDetailsId";

                                     tempInsertQuery=@"INSERT INTO @TBL_B73036BBFE7D4B0D998A985294F8FC5B(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d28_RecurringValidation,MG_d28_Reappropriation,MG_d28_BudgetID,MG_d28_BudgetAmount,MG_d28_Comments,MG_d28_RDOfficeComments,MG_d28_Justiifcation,MG_d28_JustiifcationbyHoD,MG_d28_Year1,MG_d28_Year2,MG_d28_Year3,MG_d28_Year4,MG_d28_Year5,MG_d28_Year6,MG_d28_Year7,MG_d28_Year8,MG_d28_Year9,MG_d28_Year10,MG_d28_Year11,MG_d28_Year12,MG_d28_BudgetHead,MG_d28_BudgetDetailsId)VALUES({0});";
                                     

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
                     
                                    case "59259E21-AFE8-4DAB-A543-74CC22FC79D5":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_59259E21AFE84DABA54374CC22FC79D5 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_d55_Departmentid] VARCHAR(MAX)	, [MG_d55_AdditionalType] VARCHAR(MAX)	, [MG_d55_AdditionalName] VARCHAR(MAX)	, [MG_d55_ExternalInstituteName] VARCHAR(MAX)	, [MG_d55_ExternalFacultyName] VARCHAR(MAX)	, [MG_d55_DesignationID] VARCHAR(MAX)	, [MG_d55_ExternalDesignation] VARCHAR(MAX)	, [MG_d55_ExternalEmailId] VARCHAR(MAX)	, [MG_d55_ExternalContactNo] VARCHAR(MAX)){0}INSERT INTO [59259E21-AFE8-4DAB-A543-74CC22FC79D5](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d55_Departmentid,MG_d55_AdditionalType,MG_d55_AdditionalName,MG_d55_ExternalInstituteName,MG_d55_ExternalFacultyName,MG_d55_DesignationID,MG_d55_ExternalDesignation,MG_d55_ExternalEmailId,MG_d55_ExternalContactNo)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_d55_Departmentid,TDT.MG_d55_AdditionalType,TDT.MG_d55_AdditionalName,TDT.MG_d55_ExternalInstituteName,TDT.MG_d55_ExternalFacultyName,TDT.MG_d55_DesignationID,TDT.MG_d55_ExternalDesignation,TDT.MG_d55_ExternalEmailId,TDT.MG_d55_ExternalContactNo FROM @TBL_59259E21AFE84DABA54374CC22FC79D5 TDT
							LEFT JOIN [59259E21-AFE8-4DAB-A543-74CC22FC79D5] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MG_d55_Departmentid=TDT.MG_d55_Departmentid,MG_d55_AdditionalType=TDT.MG_d55_AdditionalType,MG_d55_AdditionalName=TDT.MG_d55_AdditionalName,MG_d55_ExternalInstituteName=TDT.MG_d55_ExternalInstituteName,MG_d55_ExternalFacultyName=TDT.MG_d55_ExternalFacultyName,MG_d55_DesignationID=TDT.MG_d55_DesignationID,MG_d55_ExternalDesignation=TDT.MG_d55_ExternalDesignation,MG_d55_ExternalEmailId=TDT.MG_d55_ExternalEmailId,MG_d55_ExternalContactNo=TDT.MG_d55_ExternalContactNo FROM @TBL_59259E21AFE84DABA54374CC22FC79D5 TDT
							JOIN [59259E21-AFE8-4DAB-A543-74CC22FC79D5] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d55_Departmentid,MG_d55_AdditionalType,MG_d55_AdditionalName,MG_d55_ExternalInstituteName,MG_d55_ExternalFacultyName,MG_d55_DesignationID,MG_d55_ExternalDesignation,MG_d55_ExternalEmailId,MG_d55_ExternalContactNo";

                                     tempInsertQuery=@"INSERT INTO @TBL_59259E21AFE84DABA54374CC22FC79D5(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d55_Departmentid,MG_d55_AdditionalType,MG_d55_AdditionalName,MG_d55_ExternalInstituteName,MG_d55_ExternalFacultyName,MG_d55_DesignationID,MG_d55_ExternalDesignation,MG_d55_ExternalEmailId,MG_d55_ExternalContactNo)VALUES({0});";
                                     

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
                     
                                    case "6677BAB3-659A-4A96-9067-5D365F60CB62":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_6677BAB3659A4A9690675D365F60CB62 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_d82_DocumentName] VARCHAR(MAX)	, [MG_d82_DocumentID] VARCHAR(36)){0}INSERT INTO [6677BAB3-659A-4A96-9067-5D365F60CB62](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d82_DocumentName,MG_d82_DocumentID)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_d82_DocumentName,TDT.MG_d82_DocumentID FROM @TBL_6677BAB3659A4A9690675D365F60CB62 TDT
							LEFT JOIN [6677BAB3-659A-4A96-9067-5D365F60CB62] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MG_d82_DocumentName=TDT.MG_d82_DocumentName,MG_d82_DocumentID=TDT.MG_d82_DocumentID FROM @TBL_6677BAB3659A4A9690675D365F60CB62 TDT
							JOIN [6677BAB3-659A-4A96-9067-5D365F60CB62] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d82_DocumentName,MG_d82_DocumentID";

                                     tempInsertQuery=@"INSERT INTO @TBL_6677BAB3659A4A9690675D365F60CB62(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d82_DocumentName,MG_d82_DocumentID)VALUES({0});";
                                     

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
                     
                                    case "f1825943-98b5-f54f-0225-0081ef436f94":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_f182594398b5f54f02250081ef436f94 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [C_Stepfrom] VARCHAR(MAX)	, [C_StepTo] VARCHAR(MAX)	, [C_Comments] VARCHAR(MAX)	, [C_User] VARCHAR(MAX)	, [C_DateofComments] DATETIME){0}INSERT INTO [f1825943-98b5-f54f-0225-0081ef436f94](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,C_Stepfrom,C_StepTo,C_Comments,C_User,C_DateofComments)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.C_Stepfrom,TDT.C_StepTo,TDT.C_Comments,TDT.C_User,TDT.C_DateofComments FROM @TBL_f182594398b5f54f02250081ef436f94 TDT
							LEFT JOIN [f1825943-98b5-f54f-0225-0081ef436f94] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,C_Stepfrom=TDT.C_Stepfrom,C_StepTo=TDT.C_StepTo,C_Comments=TDT.C_Comments,C_User=TDT.C_User,C_DateofComments=TDT.C_DateofComments FROM @TBL_f182594398b5f54f02250081ef436f94 TDT
							JOIN [f1825943-98b5-f54f-0225-0081ef436f94] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,C_Stepfrom,C_StepTo,C_Comments,C_User,C_DateofComments";

                                     tempInsertQuery=@"INSERT INTO @TBL_f182594398b5f54f02250081ef436f94(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,C_Stepfrom,C_StepTo,C_Comments,C_User,C_DateofComments)VALUES({0});";
                                     

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
                     
                                    case "08F73C4A-3B94-4327-8859-B98388D1C9CD":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_08F73C4A3B9443278859B98388D1C9CD AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_d109_SerialNo] INT	, [MG_d109_EquipmentName] VARCHAR(MAX)	, [MG_d109_Description] VARCHAR(MAX)	, [MG_d109_Quantity] INT	, [MG_d109_RateinINR] DECIMAL(18,2)	, [MG_d109_TotalEquipmentcost] DECIMAL(18,2)	, [MG_d109_EquipmentBudget] INT	, [MG_d109_OverallEquipmentcost] DECIMAL(18,2)){0}INSERT INTO [08F73C4A-3B94-4327-8859-B98388D1C9CD](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d109_SerialNo,MG_d109_EquipmentName,MG_d109_Description,MG_d109_Quantity,MG_d109_RateinINR,MG_d109_TotalEquipmentcost,MG_d109_EquipmentBudget,MG_d109_OverallEquipmentcost)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_d109_SerialNo,TDT.MG_d109_EquipmentName,TDT.MG_d109_Description,TDT.MG_d109_Quantity,TDT.MG_d109_RateinINR,TDT.MG_d109_TotalEquipmentcost,TDT.MG_d109_EquipmentBudget,TDT.MG_d109_OverallEquipmentcost FROM @TBL_08F73C4A3B9443278859B98388D1C9CD TDT
							LEFT JOIN [08F73C4A-3B94-4327-8859-B98388D1C9CD] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MG_d109_SerialNo=TDT.MG_d109_SerialNo,MG_d109_EquipmentName=TDT.MG_d109_EquipmentName,MG_d109_Description=TDT.MG_d109_Description,MG_d109_Quantity=TDT.MG_d109_Quantity,MG_d109_RateinINR=TDT.MG_d109_RateinINR,MG_d109_TotalEquipmentcost=TDT.MG_d109_TotalEquipmentcost,MG_d109_EquipmentBudget=TDT.MG_d109_EquipmentBudget,MG_d109_OverallEquipmentcost=TDT.MG_d109_OverallEquipmentcost FROM @TBL_08F73C4A3B9443278859B98388D1C9CD TDT
							JOIN [08F73C4A-3B94-4327-8859-B98388D1C9CD] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d109_SerialNo,MG_d109_EquipmentName,MG_d109_Description,MG_d109_Quantity,MG_d109_RateinINR,MG_d109_TotalEquipmentcost,MG_d109_EquipmentBudget,MG_d109_OverallEquipmentcost";

                                     tempInsertQuery=@"INSERT INTO @TBL_08F73C4A3B9443278859B98388D1C9CD(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d109_SerialNo,MG_d109_EquipmentName,MG_d109_Description,MG_d109_Quantity,MG_d109_RateinINR,MG_d109_TotalEquipmentcost,MG_d109_EquipmentBudget,MG_d109_OverallEquipmentcost)VALUES({0});";
                                     

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
                     
                                    case "25683F52-E21A-4CE3-9196-7BCFA640A94B":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_25683F52E21A4CE391967BCFA640A94B AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_d154_Duration] INT	, [MG_d154_SerialNo] INT	, [MG_d154_Comments] VARCHAR(MAX)	, [MG_d154_ManpowerPosition] VARCHAR(250)	, [MG_d154_No_OfManpowerPosition] DECIMAL(18,2)	, [MG_d154_RatePerMonth] DECIMAL(18,2)	, [MG_d154_HRAPercentage] DECIMAL(18,2)	, [MG_d154_HRAPerMonth] DECIMAL(18,2)	, [MG_d154_TotalPerMonth] DECIMAL(18,2)	, [MG_d154_TotalMonths] INT	, [MG_d154_TotalCost] DECIMAL(18,2)){0}INSERT INTO [25683F52-E21A-4CE3-9196-7BCFA640A94B](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d154_Duration,MG_d154_SerialNo,MG_d154_Comments,MG_d154_ManpowerPosition,MG_d154_No_OfManpowerPosition,MG_d154_RatePerMonth,MG_d154_HRAPercentage,MG_d154_HRAPerMonth,MG_d154_TotalPerMonth,MG_d154_TotalMonths,MG_d154_TotalCost)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_d154_Duration,TDT.MG_d154_SerialNo,TDT.MG_d154_Comments,TDT.MG_d154_ManpowerPosition,TDT.MG_d154_No_OfManpowerPosition,TDT.MG_d154_RatePerMonth,TDT.MG_d154_HRAPercentage,TDT.MG_d154_HRAPerMonth,TDT.MG_d154_TotalPerMonth,TDT.MG_d154_TotalMonths,TDT.MG_d154_TotalCost FROM @TBL_25683F52E21A4CE391967BCFA640A94B TDT
							LEFT JOIN [25683F52-E21A-4CE3-9196-7BCFA640A94B] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MG_d154_Duration=TDT.MG_d154_Duration,MG_d154_SerialNo=TDT.MG_d154_SerialNo,MG_d154_Comments=TDT.MG_d154_Comments,MG_d154_ManpowerPosition=TDT.MG_d154_ManpowerPosition,MG_d154_No_OfManpowerPosition=TDT.MG_d154_No_OfManpowerPosition,MG_d154_RatePerMonth=TDT.MG_d154_RatePerMonth,MG_d154_HRAPercentage=TDT.MG_d154_HRAPercentage,MG_d154_HRAPerMonth=TDT.MG_d154_HRAPerMonth,MG_d154_TotalPerMonth=TDT.MG_d154_TotalPerMonth,MG_d154_TotalMonths=TDT.MG_d154_TotalMonths,MG_d154_TotalCost=TDT.MG_d154_TotalCost FROM @TBL_25683F52E21A4CE391967BCFA640A94B TDT
							JOIN [25683F52-E21A-4CE3-9196-7BCFA640A94B] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d154_Duration,MG_d154_SerialNo,MG_d154_Comments,MG_d154_ManpowerPosition,MG_d154_No_OfManpowerPosition,MG_d154_RatePerMonth,MG_d154_HRAPercentage,MG_d154_HRAPerMonth,MG_d154_TotalPerMonth,MG_d154_TotalMonths,MG_d154_TotalCost";

                                     tempInsertQuery=@"INSERT INTO @TBL_25683F52E21A4CE391967BCFA640A94B(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d154_Duration,MG_d154_SerialNo,MG_d154_Comments,MG_d154_ManpowerPosition,MG_d154_No_OfManpowerPosition,MG_d154_RatePerMonth,MG_d154_HRAPercentage,MG_d154_HRAPerMonth,MG_d154_TotalPerMonth,MG_d154_TotalMonths,MG_d154_TotalCost)VALUES({0});";
                                     

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
                     

                                         case "B73036BB-FE7D-4B0D-998A-985294F8FC5B":
                    {
                     
                                //Delete Existing Records of InstanceId
                                deleteQuery="Delete FROM [B73036BB-FE7D-4B0D-998A-985294F8FC5B] WHERE InstanceId='{0}';";

                           

                            gInsertQuery=@"
		
		DECLARE  @TBL_B73036BBFE7D4B0D998A985294F8FC5B AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_d28_RecurringValidation] INT	, [MG_d28_Reappropriation] DECIMAL(18,2)	, [MG_d28_BudgetID] VARCHAR(MAX)	, [MG_d28_BudgetAmount] DECIMAL(18,2)	, [MG_d28_Comments] VARCHAR(MAX)	, [MG_d28_RDOfficeComments] VARCHAR(MAX)	, [MG_d28_Justiifcation] VARCHAR(MAX)	, [MG_d28_JustiifcationbyHoD] VARCHAR(MAX)	, [MG_d28_Year1] DECIMAL(18,2)	, [MG_d28_Year2] DECIMAL(18,2)	, [MG_d28_Year3] DECIMAL(18,2)	, [MG_d28_Year4] DECIMAL(18,2)	, [MG_d28_Year5] DECIMAL(18,2)	, [MG_d28_Year6] DECIMAL(18,2)	, [MG_d28_Year7] DECIMAL(18,2)	, [MG_d28_Year8] DECIMAL(18,2)	, [MG_d28_Year9] DECIMAL(18,2)	, [MG_d28_Year10] DECIMAL(18,2)	, [MG_d28_Year11] DECIMAL(18,2)	, [MG_d28_Year12] DECIMAL(18,2)	, [MG_d28_BudgetHead] VARCHAR(MAX)	, [MG_d28_BudgetDetailsId] VARCHAR(MAX)){0}INSERT INTO [B73036BB-FE7D-4B0D-998A-985294F8FC5B](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d28_RecurringValidation,MG_d28_Reappropriation,MG_d28_BudgetID,MG_d28_BudgetAmount,MG_d28_Comments,MG_d28_RDOfficeComments,MG_d28_Justiifcation,MG_d28_JustiifcationbyHoD,MG_d28_Year1,MG_d28_Year2,MG_d28_Year3,MG_d28_Year4,MG_d28_Year5,MG_d28_Year6,MG_d28_Year7,MG_d28_Year8,MG_d28_Year9,MG_d28_Year10,MG_d28_Year11,MG_d28_Year12,MG_d28_BudgetHead,MG_d28_BudgetDetailsId)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_d28_RecurringValidation,TDT.MG_d28_Reappropriation,TDT.MG_d28_BudgetID,TDT.MG_d28_BudgetAmount,TDT.MG_d28_Comments,TDT.MG_d28_RDOfficeComments,TDT.MG_d28_Justiifcation,TDT.MG_d28_JustiifcationbyHoD,TDT.MG_d28_Year1,TDT.MG_d28_Year2,TDT.MG_d28_Year3,TDT.MG_d28_Year4,TDT.MG_d28_Year5,TDT.MG_d28_Year6,TDT.MG_d28_Year7,TDT.MG_d28_Year8,TDT.MG_d28_Year9,TDT.MG_d28_Year10,TDT.MG_d28_Year11,TDT.MG_d28_Year12,TDT.MG_d28_BudgetHead,TDT.MG_d28_BudgetDetailsId FROM @TBL_B73036BBFE7D4B0D998A985294F8FC5B TDT
							LEFT JOIN [B73036BB-FE7D-4B0D-998A-985294F8FC5B] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MG_d28_RecurringValidation=TDT.MG_d28_RecurringValidation,MG_d28_Reappropriation=TDT.MG_d28_Reappropriation,MG_d28_BudgetID=TDT.MG_d28_BudgetID,MG_d28_BudgetAmount=TDT.MG_d28_BudgetAmount,MG_d28_Comments=TDT.MG_d28_Comments,MG_d28_RDOfficeComments=TDT.MG_d28_RDOfficeComments,MG_d28_Justiifcation=TDT.MG_d28_Justiifcation,MG_d28_JustiifcationbyHoD=TDT.MG_d28_JustiifcationbyHoD,MG_d28_Year1=TDT.MG_d28_Year1,MG_d28_Year2=TDT.MG_d28_Year2,MG_d28_Year3=TDT.MG_d28_Year3,MG_d28_Year4=TDT.MG_d28_Year4,MG_d28_Year5=TDT.MG_d28_Year5,MG_d28_Year6=TDT.MG_d28_Year6,MG_d28_Year7=TDT.MG_d28_Year7,MG_d28_Year8=TDT.MG_d28_Year8,MG_d28_Year9=TDT.MG_d28_Year9,MG_d28_Year10=TDT.MG_d28_Year10,MG_d28_Year11=TDT.MG_d28_Year11,MG_d28_Year12=TDT.MG_d28_Year12,MG_d28_BudgetHead=TDT.MG_d28_BudgetHead,MG_d28_BudgetDetailsId=TDT.MG_d28_BudgetDetailsId FROM @TBL_B73036BBFE7D4B0D998A985294F8FC5B TDT
							JOIN [B73036BB-FE7D-4B0D-998A-985294F8FC5B] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d28_RecurringValidation,MG_d28_Reappropriation,MG_d28_BudgetID,MG_d28_BudgetAmount,MG_d28_Comments,MG_d28_RDOfficeComments,MG_d28_Justiifcation,MG_d28_JustiifcationbyHoD,MG_d28_Year1,MG_d28_Year2,MG_d28_Year3,MG_d28_Year4,MG_d28_Year5,MG_d28_Year6,MG_d28_Year7,MG_d28_Year8,MG_d28_Year9,MG_d28_Year10,MG_d28_Year11,MG_d28_Year12,MG_d28_BudgetHead,MG_d28_BudgetDetailsId";

                            colListwithEDT=@"InstanceId#0,ProcessActivityMapId#0,GridId#0,RowId#0,Sequence#0,MG_d28_RecurringValidation#5,MG_d28_Reappropriation#3,MG_d28_BudgetID#9,MG_d28_BudgetAmount#3,MG_d28_Comments#9,MG_d28_RDOfficeComments#9,MG_d28_Justiifcation#9,MG_d28_JustiifcationbyHoD#9,MG_d28_Year1#3,MG_d28_Year2#3,MG_d28_Year3#3,MG_d28_Year4#3,MG_d28_Year5#3,MG_d28_Year6#3,MG_d28_Year7#3,MG_d28_Year8#3,MG_d28_Year9#3,MG_d28_Year10#3,MG_d28_Year11#3,MG_d28_Year12#3,MG_d28_BudgetHead#9,MG_d28_BudgetDetailsId#9";

                            tempInsertQuery=@"INSERT INTO @TBL_B73036BBFE7D4B0D998A985294F8FC5B(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d28_RecurringValidation,MG_d28_Reappropriation,MG_d28_BudgetID,MG_d28_BudgetAmount,MG_d28_Comments,MG_d28_RDOfficeComments,MG_d28_Justiifcation,MG_d28_JustiifcationbyHoD,MG_d28_Year1,MG_d28_Year2,MG_d28_Year3,MG_d28_Year4,MG_d28_Year5,MG_d28_Year6,MG_d28_Year7,MG_d28_Year8,MG_d28_Year9,MG_d28_Year10,MG_d28_Year11,MG_d28_Year12,MG_d28_BudgetHead,MG_d28_BudgetDetailsId)VALUES({0});";

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

                                              case "6677BAB3-659A-4A96-9067-5D365F60CB62":
                    {
                     
                                //Delete Existing Records of InstanceId
                                deleteQuery="Delete FROM [6677BAB3-659A-4A96-9067-5D365F60CB62] WHERE InstanceId='{0}';";

                           

                            gInsertQuery=@"
		
		DECLARE  @TBL_6677BAB3659A4A9690675D365F60CB62 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_d82_DocumentName] VARCHAR(MAX)	, [MG_d82_DocumentID] VARCHAR(36)){0}INSERT INTO [6677BAB3-659A-4A96-9067-5D365F60CB62](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d82_DocumentName,MG_d82_DocumentID)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_d82_DocumentName,TDT.MG_d82_DocumentID FROM @TBL_6677BAB3659A4A9690675D365F60CB62 TDT
							LEFT JOIN [6677BAB3-659A-4A96-9067-5D365F60CB62] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MG_d82_DocumentName=TDT.MG_d82_DocumentName,MG_d82_DocumentID=TDT.MG_d82_DocumentID FROM @TBL_6677BAB3659A4A9690675D365F60CB62 TDT
							JOIN [6677BAB3-659A-4A96-9067-5D365F60CB62] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d82_DocumentName,MG_d82_DocumentID";

                            colListwithEDT=@"InstanceId#0,ProcessActivityMapId#0,GridId#0,RowId#0,Sequence#0,MG_d82_DocumentName#9,MG_d82_DocumentID#1";

                            tempInsertQuery=@"INSERT INTO @TBL_6677BAB3659A4A9690675D365F60CB62(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d82_DocumentName,MG_d82_DocumentID)VALUES({0});";

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

                                              case "59259E21-AFE8-4DAB-A543-74CC22FC79D5":
                    {
                     
                                //Delete Existing Records of InstanceId
                                deleteQuery="Delete FROM [59259E21-AFE8-4DAB-A543-74CC22FC79D5] WHERE InstanceId='{0}';";

                           

                            gInsertQuery=@"
		
		DECLARE  @TBL_59259E21AFE84DABA54374CC22FC79D5 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_d55_Departmentid] VARCHAR(MAX)	, [MG_d55_AdditionalType] VARCHAR(MAX)	, [MG_d55_AdditionalName] VARCHAR(MAX)	, [MG_d55_ExternalInstituteName] VARCHAR(MAX)	, [MG_d55_ExternalFacultyName] VARCHAR(MAX)	, [MG_d55_DesignationID] VARCHAR(MAX)	, [MG_d55_ExternalDesignation] VARCHAR(MAX)	, [MG_d55_ExternalEmailId] VARCHAR(MAX)	, [MG_d55_ExternalContactNo] VARCHAR(MAX)){0}INSERT INTO [59259E21-AFE8-4DAB-A543-74CC22FC79D5](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d55_Departmentid,MG_d55_AdditionalType,MG_d55_AdditionalName,MG_d55_ExternalInstituteName,MG_d55_ExternalFacultyName,MG_d55_DesignationID,MG_d55_ExternalDesignation,MG_d55_ExternalEmailId,MG_d55_ExternalContactNo)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_d55_Departmentid,TDT.MG_d55_AdditionalType,TDT.MG_d55_AdditionalName,TDT.MG_d55_ExternalInstituteName,TDT.MG_d55_ExternalFacultyName,TDT.MG_d55_DesignationID,TDT.MG_d55_ExternalDesignation,TDT.MG_d55_ExternalEmailId,TDT.MG_d55_ExternalContactNo FROM @TBL_59259E21AFE84DABA54374CC22FC79D5 TDT
							LEFT JOIN [59259E21-AFE8-4DAB-A543-74CC22FC79D5] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MG_d55_Departmentid=TDT.MG_d55_Departmentid,MG_d55_AdditionalType=TDT.MG_d55_AdditionalType,MG_d55_AdditionalName=TDT.MG_d55_AdditionalName,MG_d55_ExternalInstituteName=TDT.MG_d55_ExternalInstituteName,MG_d55_ExternalFacultyName=TDT.MG_d55_ExternalFacultyName,MG_d55_DesignationID=TDT.MG_d55_DesignationID,MG_d55_ExternalDesignation=TDT.MG_d55_ExternalDesignation,MG_d55_ExternalEmailId=TDT.MG_d55_ExternalEmailId,MG_d55_ExternalContactNo=TDT.MG_d55_ExternalContactNo FROM @TBL_59259E21AFE84DABA54374CC22FC79D5 TDT
							JOIN [59259E21-AFE8-4DAB-A543-74CC22FC79D5] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d55_Departmentid,MG_d55_AdditionalType,MG_d55_AdditionalName,MG_d55_ExternalInstituteName,MG_d55_ExternalFacultyName,MG_d55_DesignationID,MG_d55_ExternalDesignation,MG_d55_ExternalEmailId,MG_d55_ExternalContactNo";

                            colListwithEDT=@"InstanceId#0,ProcessActivityMapId#0,GridId#0,RowId#0,Sequence#0,MG_d55_Departmentid#9,MG_d55_AdditionalType#9,MG_d55_AdditionalName#9,MG_d55_ExternalInstituteName#9,MG_d55_ExternalFacultyName#9,MG_d55_DesignationID#9,MG_d55_ExternalDesignation#9,MG_d55_ExternalEmailId#9,MG_d55_ExternalContactNo#9";

                            tempInsertQuery=@"INSERT INTO @TBL_59259E21AFE84DABA54374CC22FC79D5(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d55_Departmentid,MG_d55_AdditionalType,MG_d55_AdditionalName,MG_d55_ExternalInstituteName,MG_d55_ExternalFacultyName,MG_d55_DesignationID,MG_d55_ExternalDesignation,MG_d55_ExternalEmailId,MG_d55_ExternalContactNo)VALUES({0});";

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

                                              case "08F73C4A-3B94-4327-8859-B98388D1C9CD":
                    {
                     
                                //Delete Existing Records of InstanceId
                                deleteQuery="Delete FROM [08F73C4A-3B94-4327-8859-B98388D1C9CD] WHERE InstanceId='{0}';";

                           

                            gInsertQuery=@"
		
		DECLARE  @TBL_08F73C4A3B9443278859B98388D1C9CD AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_d109_SerialNo] INT	, [MG_d109_EquipmentName] VARCHAR(MAX)	, [MG_d109_Description] VARCHAR(MAX)	, [MG_d109_Quantity] INT	, [MG_d109_RateinINR] DECIMAL(18,2)	, [MG_d109_TotalEquipmentcost] DECIMAL(18,2)	, [MG_d109_EquipmentBudget] INT	, [MG_d109_OverallEquipmentcost] DECIMAL(18,2)){0}INSERT INTO [08F73C4A-3B94-4327-8859-B98388D1C9CD](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d109_SerialNo,MG_d109_EquipmentName,MG_d109_Description,MG_d109_Quantity,MG_d109_RateinINR,MG_d109_TotalEquipmentcost,MG_d109_EquipmentBudget,MG_d109_OverallEquipmentcost)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_d109_SerialNo,TDT.MG_d109_EquipmentName,TDT.MG_d109_Description,TDT.MG_d109_Quantity,TDT.MG_d109_RateinINR,TDT.MG_d109_TotalEquipmentcost,TDT.MG_d109_EquipmentBudget,TDT.MG_d109_OverallEquipmentcost FROM @TBL_08F73C4A3B9443278859B98388D1C9CD TDT
							LEFT JOIN [08F73C4A-3B94-4327-8859-B98388D1C9CD] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MG_d109_SerialNo=TDT.MG_d109_SerialNo,MG_d109_EquipmentName=TDT.MG_d109_EquipmentName,MG_d109_Description=TDT.MG_d109_Description,MG_d109_Quantity=TDT.MG_d109_Quantity,MG_d109_RateinINR=TDT.MG_d109_RateinINR,MG_d109_TotalEquipmentcost=TDT.MG_d109_TotalEquipmentcost,MG_d109_EquipmentBudget=TDT.MG_d109_EquipmentBudget,MG_d109_OverallEquipmentcost=TDT.MG_d109_OverallEquipmentcost FROM @TBL_08F73C4A3B9443278859B98388D1C9CD TDT
							JOIN [08F73C4A-3B94-4327-8859-B98388D1C9CD] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d109_SerialNo,MG_d109_EquipmentName,MG_d109_Description,MG_d109_Quantity,MG_d109_RateinINR,MG_d109_TotalEquipmentcost,MG_d109_EquipmentBudget,MG_d109_OverallEquipmentcost";

                            colListwithEDT=@"InstanceId#0,ProcessActivityMapId#0,GridId#0,RowId#0,Sequence#0,MG_d109_SerialNo#5,MG_d109_EquipmentName#9,MG_d109_Description#9,MG_d109_Quantity#5,MG_d109_RateinINR#3,MG_d109_TotalEquipmentcost#3,MG_d109_EquipmentBudget#5,MG_d109_OverallEquipmentcost#3";

                            tempInsertQuery=@"INSERT INTO @TBL_08F73C4A3B9443278859B98388D1C9CD(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d109_SerialNo,MG_d109_EquipmentName,MG_d109_Description,MG_d109_Quantity,MG_d109_RateinINR,MG_d109_TotalEquipmentcost,MG_d109_EquipmentBudget,MG_d109_OverallEquipmentcost)VALUES({0});";

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

                                              case "25683F52-E21A-4CE3-9196-7BCFA640A94B":
                    {
                     
                                //Delete Existing Records of InstanceId
                                deleteQuery="Delete FROM [25683F52-E21A-4CE3-9196-7BCFA640A94B] WHERE InstanceId='{0}';";

                           

                            gInsertQuery=@"
		
		DECLARE  @TBL_25683F52E21A4CE391967BCFA640A94B AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_d154_Duration] INT	, [MG_d154_SerialNo] INT	, [MG_d154_Comments] VARCHAR(MAX)	, [MG_d154_ManpowerPosition] VARCHAR(250)	, [MG_d154_No_OfManpowerPosition] DECIMAL(18,2)	, [MG_d154_RatePerMonth] DECIMAL(18,2)	, [MG_d154_HRAPercentage] DECIMAL(18,2)	, [MG_d154_HRAPerMonth] DECIMAL(18,2)	, [MG_d154_TotalPerMonth] DECIMAL(18,2)	, [MG_d154_TotalMonths] INT	, [MG_d154_TotalCost] DECIMAL(18,2)){0}INSERT INTO [25683F52-E21A-4CE3-9196-7BCFA640A94B](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d154_Duration,MG_d154_SerialNo,MG_d154_Comments,MG_d154_ManpowerPosition,MG_d154_No_OfManpowerPosition,MG_d154_RatePerMonth,MG_d154_HRAPercentage,MG_d154_HRAPerMonth,MG_d154_TotalPerMonth,MG_d154_TotalMonths,MG_d154_TotalCost)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_d154_Duration,TDT.MG_d154_SerialNo,TDT.MG_d154_Comments,TDT.MG_d154_ManpowerPosition,TDT.MG_d154_No_OfManpowerPosition,TDT.MG_d154_RatePerMonth,TDT.MG_d154_HRAPercentage,TDT.MG_d154_HRAPerMonth,TDT.MG_d154_TotalPerMonth,TDT.MG_d154_TotalMonths,TDT.MG_d154_TotalCost FROM @TBL_25683F52E21A4CE391967BCFA640A94B TDT
							LEFT JOIN [25683F52-E21A-4CE3-9196-7BCFA640A94B] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MG_d154_Duration=TDT.MG_d154_Duration,MG_d154_SerialNo=TDT.MG_d154_SerialNo,MG_d154_Comments=TDT.MG_d154_Comments,MG_d154_ManpowerPosition=TDT.MG_d154_ManpowerPosition,MG_d154_No_OfManpowerPosition=TDT.MG_d154_No_OfManpowerPosition,MG_d154_RatePerMonth=TDT.MG_d154_RatePerMonth,MG_d154_HRAPercentage=TDT.MG_d154_HRAPercentage,MG_d154_HRAPerMonth=TDT.MG_d154_HRAPerMonth,MG_d154_TotalPerMonth=TDT.MG_d154_TotalPerMonth,MG_d154_TotalMonths=TDT.MG_d154_TotalMonths,MG_d154_TotalCost=TDT.MG_d154_TotalCost FROM @TBL_25683F52E21A4CE391967BCFA640A94B TDT
							JOIN [25683F52-E21A-4CE3-9196-7BCFA640A94B] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d154_Duration,MG_d154_SerialNo,MG_d154_Comments,MG_d154_ManpowerPosition,MG_d154_No_OfManpowerPosition,MG_d154_RatePerMonth,MG_d154_HRAPercentage,MG_d154_HRAPerMonth,MG_d154_TotalPerMonth,MG_d154_TotalMonths,MG_d154_TotalCost";

                            colListwithEDT=@"InstanceId#0,ProcessActivityMapId#0,GridId#0,RowId#0,Sequence#0,MG_d154_Duration#5,MG_d154_SerialNo#5,MG_d154_Comments#9,MG_d154_ManpowerPosition#9,MG_d154_No_OfManpowerPosition#3,MG_d154_RatePerMonth#3,MG_d154_HRAPercentage#3,MG_d154_HRAPerMonth#3,MG_d154_TotalPerMonth#3,MG_d154_TotalMonths#5,MG_d154_TotalCost#3";

                            tempInsertQuery=@"INSERT INTO @TBL_25683F52E21A4CE391967BCFA640A94B(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d154_Duration,MG_d154_SerialNo,MG_d154_Comments,MG_d154_ManpowerPosition,MG_d154_No_OfManpowerPosition,MG_d154_RatePerMonth,MG_d154_HRAPercentage,MG_d154_HRAPerMonth,MG_d154_TotalPerMonth,MG_d154_TotalMonths,MG_d154_TotalCost)VALUES({0});";

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

                                              case "f1825943-98b5-f54f-0225-0081ef436f94":
                    {
                     
                                //Delete Existing Records of InstanceId
                                deleteQuery="Delete FROM [f1825943-98b5-f54f-0225-0081ef436f94] WHERE InstanceId='{0}';";

                           

                            gInsertQuery=@"
		
		DECLARE  @TBL_f182594398b5f54f02250081ef436f94 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [C_Stepfrom] VARCHAR(MAX)	, [C_StepTo] VARCHAR(MAX)	, [C_Comments] VARCHAR(MAX)	, [C_User] VARCHAR(MAX)	, [C_DateofComments] DATETIME){0}INSERT INTO [f1825943-98b5-f54f-0225-0081ef436f94](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,C_Stepfrom,C_StepTo,C_Comments,C_User,C_DateofComments)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.C_Stepfrom,TDT.C_StepTo,TDT.C_Comments,TDT.C_User,TDT.C_DateofComments FROM @TBL_f182594398b5f54f02250081ef436f94 TDT
							LEFT JOIN [f1825943-98b5-f54f-0225-0081ef436f94] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,C_Stepfrom=TDT.C_Stepfrom,C_StepTo=TDT.C_StepTo,C_Comments=TDT.C_Comments,C_User=TDT.C_User,C_DateofComments=TDT.C_DateofComments FROM @TBL_f182594398b5f54f02250081ef436f94 TDT
							JOIN [f1825943-98b5-f54f-0225-0081ef436f94] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,C_Stepfrom,C_StepTo,C_Comments,C_User,C_DateofComments";

                            colListwithEDT=@"InstanceId#0,ProcessActivityMapId#0,GridId#0,RowId#0,Sequence#0,C_Stepfrom#9,C_StepTo#9,C_Comments#9,C_User#9,C_DateofComments#8";

                            tempInsertQuery=@"INSERT INTO @TBL_f182594398b5f54f02250081ef436f94(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,C_Stepfrom,C_StepTo,C_Comments,C_User,C_DateofComments)VALUES({0});";

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
public class ISpaceE1B5DCB812784AA0A8B21C0CDE17E77A : VirtualForm
{
IISpace iSpace = new ISpace();
AcDataISpaceE1B5DCB812784AA0A8B21C0CDE17E77A acdataIspaceE1B5DCB812784AA0A8B21C0CDE17E77A=new AcDataISpaceE1B5DCB812784AA0A8B21C0CDE17E77A();
private void SubscribeFormEvents_root(ref Dictionary<string, ServiceElementData> ISpace)
{
try
{
base.WriteDebugInfo(@"Root-OnAfterFormLoad");
if(ISpace["FormVersionId"].Value=="ADD720B3-8CFA-4B65-B90D-7D2AC805F75E")
{
ISpace["UI_InvisibleRow"].Visible="false";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""ADD720B3-8CFA-4B65-B90D-7D2AC805F75E"")
{
ISpace[""UI_InvisibleRow""].Visible=""false"";
}");
object MG_d28_BudgetAmount=iSpace.Sum("[B73036BB-FE7D-4B0D-998A-985294F8FC5B]","MG_d28_BudgetAmount","",ISpace["gv_instanceid"].Value);
ISpace["MF_d10_BudgetTotalAmount"].Value=Convert.ChangeType(MG_d28_BudgetAmount, MG_d28_BudgetAmount.GetType());;
base.WriteDebugInfo(@"object MG_d28_BudgetAmount=iSpace.Sum(""[B73036BB-FE7D-4B0D-998A-985294F8FC5B]"",""MG_d28_BudgetAmount"","""",ISpace[""gv_instanceid""].Value);
ISpace[""MF_d10_BudgetTotalAmount""].Value=Convert.ChangeType(MG_d28_BudgetAmount, MG_d28_BudgetAmount.GetType());;");
base.WriteDebugInfo(@"EXEC ProjectCreationBudgetCalculation '@@gv_InstanceId'");

var querySourcec3995c1b9f1af85fab715bef2a0b203e =GetQueryExpressionDataSource("c3995c1b-9f1a-f85f-ab71-5bef2a0b203e");
Dictionary<short,object> resultc3995c1b9f1af85fab715bef2a0b203e=iSpace.ExecuteQuery(querySourcec3995c1b9f1af85fab715bef2a0b203e,@"EXEC ProjectCreationBudgetCalculation '" + ISpace["gv_instanceid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourcec3995c1b9f1af85fab715bef2a0b203e =GetQueryExpressionDataSource(""c3995c1b-9f1a-f85f-ab71-5bef2a0b203e"");Dictionary<short,object> resultc3995c1b9f1af85fab715bef2a0b203e=iSpace.ExecuteQuery(querySourcec3995c1b9f1af85fab715bef2a0b203e,@""EXEC ProjectCreationBudgetCalculation '"" + ISpace[""gv_instanceid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultc3995c1b9f1af85fab715bef2a0b203e!=null) && (resultc3995c1b9f1af85fab715bef2a0b203e.Count!=0))
{
if(resultc3995c1b9f1af85fab715bef2a0b203e.ContainsKey(0))
ISpace["MF_d10_RecurringAmount"].Value = resultc3995c1b9f1af85fab715bef2a0b203e[0];
if(resultc3995c1b9f1af85fab715bef2a0b203e.ContainsKey(1))
ISpace["MF_d10_NonRecurringAmount"].Value = resultc3995c1b9f1af85fab715bef2a0b203e[1];
}
else{
ISpace["MF_d10_RecurringAmount"].Value = null;ISpace["MF_d10_NonRecurringAmount"].Value = null;
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC GetEmployeeATOMDetails '@@gv_UserId'");

var querySource6c6e361f506032e399f86f2090aa1e0c =GetQueryExpressionDataSource("6c6e361f-5060-32e3-99f8-6f2090aa1e0c");
Dictionary<short,object> result6c6e361f506032e399f86f2090aa1e0c=iSpace.ExecuteQuery(querySource6c6e361f506032e399f86f2090aa1e0c,@"EXEC GetEmployeeATOMDetails '" + ISpace["gv_userid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource6c6e361f506032e399f86f2090aa1e0c =GetQueryExpressionDataSource(""6c6e361f-5060-32e3-99f8-6f2090aa1e0c"");Dictionary<short,object> result6c6e361f506032e399f86f2090aa1e0c=iSpace.ExecuteQuery(querySource6c6e361f506032e399f86f2090aa1e0c,@""EXEC GetEmployeeATOMDetails '"" + ISpace[""gv_userid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result6c6e361f506032e399f86f2090aa1e0c!=null) && (result6c6e361f506032e399f86f2090aa1e0c.Count!=0))
{
if(result6c6e361f506032e399f86f2090aa1e0c.ContainsKey(8))
ISpace["MF_d10_EmployeeBasicInfoId"].Value = result6c6e361f506032e399f86f2090aa1e0c[8];
if(result6c6e361f506032e399f86f2090aa1e0c.ContainsKey(0))
ISpace["MF_d10_EmployeeCode"].Value = result6c6e361f506032e399f86f2090aa1e0c[0];
if(result6c6e361f506032e399f86f2090aa1e0c.ContainsKey(19))
ISpace["MF_d10_PrincipalInvestigator"].Value = result6c6e361f506032e399f86f2090aa1e0c[19];
if(result6c6e361f506032e399f86f2090aa1e0c.ContainsKey(2))
ISpace["MF_d10_Designation"].Value = result6c6e361f506032e399f86f2090aa1e0c[2];
if(result6c6e361f506032e399f86f2090aa1e0c.ContainsKey(20))
ISpace["MF_d10_EmpDeptCode"].Value = result6c6e361f506032e399f86f2090aa1e0c[20];
if(result6c6e361f506032e399f86f2090aa1e0c.ContainsKey(3))
ISpace["MF_d10_DepartmentID"].Value = result6c6e361f506032e399f86f2090aa1e0c[3];
}
else{
ISpace["MF_d10_EmployeeBasicInfoId"].Value = null;ISpace["MF_d10_EmployeeCode"].Value = null;ISpace["MF_d10_PrincipalInvestigator"].Value = null;ISpace["MF_d10_Designation"].Value = null;ISpace["MF_d10_EmpDeptCode"].Value = null;ISpace["MF_d10_DepartmentID"].Value = null;
}
ISpace["MF_d10_ProjectStatus"].Value="7";
base.WriteDebugInfo(@"ISpace[""MF_d10_ProjectStatus""].Value=""7"";");
ISpace["MF_d10_YearMonth"].Man=true;ISpace["MF_d10_ProjectCategoryID"].Man=true;ISpace["MF_d10_FundingAgency"].Man=true;ISpace["MF_d10_ProjectBudget"].Man=true;ISpace["MF_d10_Sector"].Man=true;ISpace["MF_d10_FinancialYearID"].Man=true;ISpace["MF_d10_SanctionedDate"].Man=true;ISpace["RDDocumentGrid"].Man=true;ISpace["MG_d28_BudgetAmount"].Man=true;ISpace["MF_d10_Duration"].Man=true;ISpace["BudgetAllocation"].Man=true;ISpace["MG_d82_DocumentID"].Man=true;ISpace["MF_d10_SanctionedNumber"].Man=true;ISpace["MF_d10_ProjectName"].Man=true;
base.WriteDebugInfo(@"ISpace[""MF_d10_YearMonth""].Man=true;ISpace[""MF_d10_ProjectCategoryID""].Man=true;ISpace[""MF_d10_FundingAgency""].Man=true;ISpace[""MF_d10_ProjectBudget""].Man=true;ISpace[""MF_d10_Sector""].Man=true;ISpace[""MF_d10_FinancialYearID""].Man=true;ISpace[""MF_d10_SanctionedDate""].Man=true;ISpace[""RDDocumentGrid""].Man=true;ISpace[""MG_d28_BudgetAmount""].Man=true;ISpace[""MF_d10_Duration""].Man=true;ISpace[""BudgetAllocation""].Man=true;ISpace[""MG_d82_DocumentID""].Man=true;ISpace[""MF_d10_SanctionedNumber""].Man=true;ISpace[""MF_d10_ProjectName""].Man=true;");
ISpace["MF_d10_ProjectDetailsID"].Value=ISpace["gv_instanceid"].Value;
base.WriteDebugInfo(@"ISpace[""MF_d10_ProjectDetailsID""].Value=ISpace[""gv_instanceid""].Value;");
}
ISpace["MF_d10_InstanceId"].Value=ISpace["gv_instanceid"].Value;
base.WriteDebugInfo(@"ISpace[""MF_d10_InstanceId""].Value=ISpace[""gv_instanceid""].Value;");
ISpace["MF_d10_ProjectproposalID"].Man=true;ISpace["MF_d10_ProjectCategoryID"].Man=true;ISpace["MF_d10_FundingAgency"].Man=true;ISpace["MF_d10_Sector"].Man=true;ISpace["MF_d10_FinancialYearID"].Man=true;ISpace["MF_d10_SanctionedDate"].Man=true;ISpace["MF_d10_SchemeID"].Visible="true";ISpace["MF_d10_SchemeID"].Man=false;ISpace["MF_d10_SchemeID"].Enbl="true";ISpace["MF_d10_Duration"].Man=true;ISpace["BudgetAllocation"].Man=true;ISpace["MF_d10_Designation"].Enbl="false";ISpace["MF_d10_SanctionedNumber"].Man=true;ISpace["m_currency"].Man=true;ISpace["MF_d10_ProjectType"].Man=true;ISpace["MF_d10_DepartmentID"].Man=false;ISpace["MF_d10_DepartmentID"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MF_d10_ProjectproposalID""].Man=true;ISpace[""MF_d10_ProjectCategoryID""].Man=true;ISpace[""MF_d10_FundingAgency""].Man=true;ISpace[""MF_d10_Sector""].Man=true;ISpace[""MF_d10_FinancialYearID""].Man=true;ISpace[""MF_d10_SanctionedDate""].Man=true;ISpace[""MF_d10_SchemeID""].Visible=""true"";ISpace[""MF_d10_SchemeID""].Man=false;ISpace[""MF_d10_SchemeID""].Enbl=""true"";ISpace[""MF_d10_Duration""].Man=true;ISpace[""BudgetAllocation""].Man=true;ISpace[""MF_d10_Designation""].Enbl=""false"";ISpace[""MF_d10_SanctionedNumber""].Man=true;ISpace[""m_currency""].Man=true;ISpace[""MF_d10_ProjectType""].Man=true;ISpace[""MF_d10_DepartmentID""].Man=false;ISpace[""MF_d10_DepartmentID""].Enbl=""false"";");
if(ISpace["MF_d10_IfManpower"].Value==true)
{
base.WriteDebugInfo(@"if(ISpace[""MF_d10_IfManpower""].Value==true)");
ISpace["ManpowerGrid"].Visible="true";
base.WriteDebugInfo(@"ISpace[""ManpowerGrid""].Visible=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["ManpowerGrid"].Visible="false";
base.WriteDebugInfo(@"ISpace[""ManpowerGrid""].Visible=""false"";");
}
if(ISpace["MF_d10_IfEquipment"].Value==true)
{
base.WriteDebugInfo(@"if(ISpace[""MF_d10_IfEquipment""].Value==true)");
ISpace["EquipmentGrid"].Visible="true";
base.WriteDebugInfo(@"ISpace[""EquipmentGrid""].Visible=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["EquipmentGrid"].Visible="false";
base.WriteDebugInfo(@"ISpace[""EquipmentGrid""].Visible=""false"";");
}
ISpace["MF_d10_FinancialYearID"].Value="19";
base.WriteDebugInfo(@"ISpace[""MF_d10_FinancialYearID""].Value=""19"";");
ISpace["MF_d10_FundReceiptMode"].Visible="false";ISpace["MF_d10_SchemeID"].Visible="false";
base.WriteDebugInfo(@"ISpace[""MF_d10_FundReceiptMode""].Visible=""false"";ISpace[""MF_d10_SchemeID""].Visible=""false"";");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mf_d10_fromdate (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MF_d10_FromDate-OnChange");
base.WriteDebugInfo(@"EXEC [GetCalculatedEndDate] '#MF_d10_Duration','#MF_d10_YearMonth','#MF_d10_FromDate'");

var querySourceeae2baebd143cc0a8acf8c0f81dbfb8a =GetQueryExpressionDataSource("eae2baeb-d143-cc0a-8acf-8c0f81dbfb8a");
Dictionary<short,object> resulteae2baebd143cc0a8acf8c0f81dbfb8a=iSpace.ExecuteQuery(querySourceeae2baebd143cc0a8acf8c0f81dbfb8a,@"EXEC [GetCalculatedEndDate] '" + ISpace["MF_d10_Duration"].Value + @"','" + ISpace["MF_d10_YearMonth"].Value + @"','" + ISpace["MF_d10_FromDate"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceeae2baebd143cc0a8acf8c0f81dbfb8a =GetQueryExpressionDataSource(""eae2baeb-d143-cc0a-8acf-8c0f81dbfb8a"");Dictionary<short,object> resulteae2baebd143cc0a8acf8c0f81dbfb8a=iSpace.ExecuteQuery(querySourceeae2baebd143cc0a8acf8c0f81dbfb8a,@""EXEC [GetCalculatedEndDate] '"" + ISpace[""MF_d10_Duration""].Value + @""','"" + ISpace[""MF_d10_YearMonth""].Value + @""','"" + ISpace[""MF_d10_FromDate""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resulteae2baebd143cc0a8acf8c0f81dbfb8a!=null) && (resulteae2baebd143cc0a8acf8c0f81dbfb8a.Count!=0))
{
if(resulteae2baebd143cc0a8acf8c0f81dbfb8a.ContainsKey(0))
ISpace["MF_d10_ToDate"].Value = resulteae2baebd143cc0a8acf8c0f81dbfb8a[0];
if(resulteae2baebd143cc0a8acf8c0f81dbfb8a.ContainsKey(0))
ISpace["MF_d10_ActualEndDate"].Value = resulteae2baebd143cc0a8acf8c0f81dbfb8a[0];
}
else{
ISpace["MF_d10_ToDate"].Value = null;ISpace["MF_d10_ActualEndDate"].Value = null;
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_m_cancel (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"M_Cancel-OnClick");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC [UnlockProcessInstance] '@@gv_InstanceId','@@gv_UserMapId'");

var querySourcecfc8b06a84f18ec2a3f33b615821582c =GetQueryExpressionDataSource("cfc8b06a-84f1-8ec2-a3f3-3b615821582c");
Dictionary<short,object> resultcfc8b06a84f18ec2a3f33b615821582c=iSpace.ExecuteQuery(querySourcecfc8b06a84f18ec2a3f33b615821582c,@"EXEC [UnlockProcessInstance] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_usermapid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourcecfc8b06a84f18ec2a3f33b615821582c =GetQueryExpressionDataSource(""cfc8b06a-84f1-8ec2-a3f3-3b615821582c"");Dictionary<short,object> resultcfc8b06a84f18ec2a3f33b615821582c=iSpace.ExecuteQuery(querySourcecfc8b06a84f18ec2a3f33b615821582c,@""EXEC [UnlockProcessInstance] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_usermapid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultcfc8b06a84f18ec2a3f33b615821582c!=null) && (resultcfc8b06a84f18ec2a3f33b615821582c.Count!=0))
{
if(resultcfc8b06a84f18ec2a3f33b615821582c.ContainsKey(0))
ISpace["ExecutionMessage"].Value = resultcfc8b06a84f18ec2a3f33b615821582c[0];
}
else{
ISpace["ExecutionMessage"].Value = null;
}
ISpace["Message"].Value=@"SUCCESS:Cancelled Successfully";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""SUCCESS:Cancelled Successfully"";");
}

ISpace["RedirectUrl"].RedirectType="R";
ISpace["RedirectUrl"].Value="/Inbox";
base.WriteDebugInfo(@"
ISpace[""RedirectUrl""].RedirectType=""R"";
ISpace[""RedirectUrl""].Value=""/Inbox"";");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mf_d10_yearmonth (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MF_d10_YearMonth-OnChange");
base.WriteDebugInfo(@"EXEC [GetCalculatedEndDate] '#MF_d10_Duration','#MF_d10_YearMonth','#MF_d10_FromDate'");

var querySourceeae2baebd143cc0a8acf8c0f81dbfb8a =GetQueryExpressionDataSource("eae2baeb-d143-cc0a-8acf-8c0f81dbfb8a");
Dictionary<short,object> resulteae2baebd143cc0a8acf8c0f81dbfb8a=iSpace.ExecuteQuery(querySourceeae2baebd143cc0a8acf8c0f81dbfb8a,@"EXEC [GetCalculatedEndDate] '" + ISpace["MF_d10_Duration"].Value + @"','" + ISpace["MF_d10_YearMonth"].Value + @"','" + ISpace["MF_d10_FromDate"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceeae2baebd143cc0a8acf8c0f81dbfb8a =GetQueryExpressionDataSource(""eae2baeb-d143-cc0a-8acf-8c0f81dbfb8a"");Dictionary<short,object> resulteae2baebd143cc0a8acf8c0f81dbfb8a=iSpace.ExecuteQuery(querySourceeae2baebd143cc0a8acf8c0f81dbfb8a,@""EXEC [GetCalculatedEndDate] '"" + ISpace[""MF_d10_Duration""].Value + @""','"" + ISpace[""MF_d10_YearMonth""].Value + @""','"" + ISpace[""MF_d10_FromDate""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resulteae2baebd143cc0a8acf8c0f81dbfb8a!=null) && (resulteae2baebd143cc0a8acf8c0f81dbfb8a.Count!=0))
{
if(resulteae2baebd143cc0a8acf8c0f81dbfb8a.ContainsKey(0))
ISpace["MF_d10_ToDate"].Value = resulteae2baebd143cc0a8acf8c0f81dbfb8a[0];
if(resulteae2baebd143cc0a8acf8c0f81dbfb8a.ContainsKey(0))
ISpace["MF_d10_ActualEndDate"].Value = resulteae2baebd143cc0a8acf8c0f81dbfb8a[0];
}
else{
ISpace["MF_d10_ToDate"].Value = null;ISpace["MF_d10_ActualEndDate"].Value = null;
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mf_d10_projectproposalid (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MF_d10_ProjectproposalID-OnChange");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC [GetProjectPropsalDetails] '#MF_d10_ProjectproposalID'");

var querySource9cc2bc31cc300ba34ad622f9e9abf5d5 =GetQueryExpressionDataSource("9cc2bc31-cc30-0ba3-4ad6-22f9e9abf5d5");
Dictionary<short,object> result9cc2bc31cc300ba34ad622f9e9abf5d5=iSpace.ExecuteQuery(querySource9cc2bc31cc300ba34ad622f9e9abf5d5,@"EXEC [GetProjectPropsalDetails] '" + ISpace["MF_d10_ProjectproposalID"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource9cc2bc31cc300ba34ad622f9e9abf5d5 =GetQueryExpressionDataSource(""9cc2bc31-cc30-0ba3-4ad6-22f9e9abf5d5"");Dictionary<short,object> result9cc2bc31cc300ba34ad622f9e9abf5d5=iSpace.ExecuteQuery(querySource9cc2bc31cc300ba34ad622f9e9abf5d5,@""EXEC [GetProjectPropsalDetails] '"" + ISpace[""MF_d10_ProjectproposalID""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result9cc2bc31cc300ba34ad622f9e9abf5d5!=null) && (result9cc2bc31cc300ba34ad622f9e9abf5d5.Count!=0))
{
if(result9cc2bc31cc300ba34ad622f9e9abf5d5.ContainsKey(2))
ISpace["MF_d10_ProjectCategoryID"].Value = result9cc2bc31cc300ba34ad622f9e9abf5d5[2];
if(result9cc2bc31cc300ba34ad622f9e9abf5d5.ContainsKey(6))
ISpace["MF_d10_FundingAgency"].Value = result9cc2bc31cc300ba34ad622f9e9abf5d5[6];
if(result9cc2bc31cc300ba34ad622f9e9abf5d5.ContainsKey(7))
ISpace["MF_d10_Sector"].Value = result9cc2bc31cc300ba34ad622f9e9abf5d5[7];
if(result9cc2bc31cc300ba34ad622f9e9abf5d5.ContainsKey(3))
ISpace["MF_d10_FinancialYearID"].Value = result9cc2bc31cc300ba34ad622f9e9abf5d5[3];
if(result9cc2bc31cc300ba34ad622f9e9abf5d5.ContainsKey(17))
ISpace["m_currency"].Value = result9cc2bc31cc300ba34ad622f9e9abf5d5[17];
if(result9cc2bc31cc300ba34ad622f9e9abf5d5.ContainsKey(13))
ISpace["MF_d10_ProjectType"].Value = result9cc2bc31cc300ba34ad622f9e9abf5d5[13];
if(result9cc2bc31cc300ba34ad622f9e9abf5d5.ContainsKey(21))
ISpace["MF_d10_IsExternalIns"].Value = result9cc2bc31cc300ba34ad622f9e9abf5d5[21];
if(result9cc2bc31cc300ba34ad622f9e9abf5d5.ContainsKey(9))
ISpace["MF_d10_ProjectBudget"].Value = result9cc2bc31cc300ba34ad622f9e9abf5d5[9];
if(result9cc2bc31cc300ba34ad622f9e9abf5d5.ContainsKey(8))
ISpace["MF_d10_ProjectName"].Value = result9cc2bc31cc300ba34ad622f9e9abf5d5[8];
}
else{
ISpace["MF_d10_ProjectCategoryID"].Value = null;ISpace["MF_d10_FundingAgency"].Value = null;ISpace["MF_d10_Sector"].Value = null;ISpace["MF_d10_FinancialYearID"].Value = null;ISpace["m_currency"].Value = null;ISpace["MF_d10_ProjectType"].Value = null;ISpace["MF_d10_IsExternalIns"].Value = null;ISpace["MF_d10_ProjectBudget"].Value = null;ISpace["MF_d10_ProjectName"].Value = null;
}

var querySource906fc07f3f3bc1be93f744636c228555 =GetQueryExpressionDataSource("906fc07f-3f3b-c1be-93f7-44636c228555");

DataTable result906fc07f3f3bc1be93f744636c228555=iSpace.SetGridDataSource(querySource906fc07f3f3bc1be93f744636c228555, _objectFactory.GetGridRPP("BudgetAllocation"),@"EXEC [GetProjectDetailCombo] 1,'" + ISpace["gv_instanceid"].Value + @"'");


base.WriteDebugInfo(@"var querySource906fc07f3f3bc1be93f744636c228555 =GetQueryExpressionDataSource(""906fc07f-3f3b-c1be-93f7-44636c228555"");DataTable result906fc07f3f3bc1be93f744636c228555=iSpace.SetGridDataSource(querySource906fc07f3f3bc1be93f744636c228555, _objectFactory.GetGridRPP(""BudgetAllocation""),@""EXEC [GetProjectDetailCombo] 1,'"" + ISpace[""gv_instanceid""].Value + @""'"");");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result0303e9a5833d0f47596240219e02283c=acdataIspaceE1B5DCB812784AA0A8B21C0CDE17E77A.GetQueryExpressionBindings("0303e9a5-833d-0f47-5962-40219e02283c");
iSpace.SetGridData(result906fc07f3f3bc1be93f744636c228555,result0303e9a5833d0f47596240219e02283c,"BudgetAllocation",ref ISpace);
if (_elementBase != null)  iSpace.SetLoopExpressionData("BudgetAllocation","B73036BB-FE7D-4B0D-998A-985294F8FC5B",_objectFactory.GetGridRPP("BudgetAllocation"),_elementBase.GetGridLoopQuery("B73036BB-FE7D-4B0D-998A-985294F8FC5B","BudgetAllocation",true,ref ISpace), ref ISpace);

}
if(ISpace["MF_d10_ProjectType"].Value=="450")
{
base.WriteDebugInfo(@"if(ISpace[""MF_d10_ProjectType""].Value==""450"")");
ISpace["m_currency"].Visible="true";ISpace["m_currency"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""m_currency""].Visible=""true"";ISpace[""m_currency""].Enbl=""true"";");
}
if(ISpace["MF_d10_ProjectType"].Value=="449")
{
base.WriteDebugInfo(@"if(ISpace[""MF_d10_ProjectType""].Value==""449"")");
ISpace["m_currency"].Visible="false";ISpace["m_currency"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""m_currency""].Visible=""false"";ISpace[""m_currency""].Enbl=""false"";");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySource5b1d38940d729c8d3a5f8fe772ffa261 =GetQueryExpressionDataSource("5b1d3894-0d72-9c8d-3a5f-8fe772ffa261");

DataTable result5b1d38940d729c8d3a5f8fe772ffa261=iSpace.SetGridDataSource(querySource5b1d38940d729c8d3a5f8fe772ffa261, _objectFactory.GetGridRPP("ExternalCoPiGrid"),@"EXEC GetProjectCoPiDetails '" + ISpace["MF_d10_ProjectproposalID"].Value + @"'");


base.WriteDebugInfo(@"var querySource5b1d38940d729c8d3a5f8fe772ffa261 =GetQueryExpressionDataSource(""5b1d3894-0d72-9c8d-3a5f-8fe772ffa261"");DataTable result5b1d38940d729c8d3a5f8fe772ffa261=iSpace.SetGridDataSource(querySource5b1d38940d729c8d3a5f8fe772ffa261, _objectFactory.GetGridRPP(""ExternalCoPiGrid""),@""EXEC GetProjectCoPiDetails '"" + ISpace[""MF_d10_ProjectproposalID""].Value + @""'"");");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result22ae9f9ee9e879dd1f5e44b4433f5e5c=acdataIspaceE1B5DCB812784AA0A8B21C0CDE17E77A.GetQueryExpressionBindings("22ae9f9e-e9e8-79dd-1f5e-44b4433f5e5c");
iSpace.SetGridData(result5b1d38940d729c8d3a5f8fe772ffa261,result22ae9f9ee9e879dd1f5e44b4433f5e5c,"ExternalCoPiGrid",ref ISpace);
if (_elementBase != null)  iSpace.SetLoopExpressionData("ExternalCoPiGrid","59259E21-AFE8-4DAB-A543-74CC22FC79D5",_objectFactory.GetGridRPP("ExternalCoPiGrid"),_elementBase.GetGridLoopQuery("59259E21-AFE8-4DAB-A543-74CC22FC79D5","ExternalCoPiGrid",true,ref ISpace), ref ISpace);

}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["MF_d10_ProjectStatus"].Value="7";
base.WriteDebugInfo(@"ISpace[""MF_d10_ProjectStatus""].Value=""7"";");
ISpace["MF_d10_ProjectDetailsID"].Value=ISpace["gv_instanceid"].Value;
base.WriteDebugInfo(@"ISpace[""MF_d10_ProjectDetailsID""].Value=ISpace[""gv_instanceid""].Value;");
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mg_d154_totalmonths (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MG_d154_TotalMonths-OnChange");
object MG_d154_TotalCost=iSpace.Sum("[25683F52-E21A-4CE3-9196-7BCFA640A94B]","MG_d154_TotalCost","",ISpace["gv_instanceid"].Value);
ISpace["MF_ManPowerTotal"].Value=Convert.ChangeType(MG_d154_TotalCost, MG_d154_TotalCost.GetType());;
base.WriteDebugInfo(@"object MG_d154_TotalCost=iSpace.Sum(""[25683F52-E21A-4CE3-9196-7BCFA640A94B]"",""MG_d154_TotalCost"","""",ISpace[""gv_instanceid""].Value);
ISpace[""MF_ManPowerTotal""].Value=Convert.ChangeType(MG_d154_TotalCost, MG_d154_TotalCost.GetType());;");

var querySource7c4d94f12381b2c2c38d941e8dba8928 =GetQueryExpressionDataSource("7c4d94f1-2381-b2c2-c38d-941e8dba8928");

DataTable result7c4d94f12381b2c2c38d941e8dba8928=iSpace.SetGridDataSource(querySource7c4d94f12381b2c2c38d941e8dba8928, _objectFactory.GetGridRPP("ManpowerGrid"),@"EXEC [GetGridData25683F52-E21A-4CE3-9196-7BCFA640A94B] '" + ISpace["gv_instanceid"].Value + @"'");


base.WriteDebugInfo(@"var querySource7c4d94f12381b2c2c38d941e8dba8928 =GetQueryExpressionDataSource(""7c4d94f1-2381-b2c2-c38d-941e8dba8928"");DataTable result7c4d94f12381b2c2c38d941e8dba8928=iSpace.SetGridDataSource(querySource7c4d94f12381b2c2c38d941e8dba8928, _objectFactory.GetGridRPP(""ManpowerGrid""),@""EXEC [GetGridData25683F52-E21A-4CE3-9196-7BCFA640A94B] '"" + ISpace[""gv_instanceid""].Value + @""'"");");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result2dff53097010e57f5c95f700983350be=acdataIspaceE1B5DCB812784AA0A8B21C0CDE17E77A.GetQueryExpressionBindings("2dff5309-7010-e57f-5c95-f700983350be");
iSpace.SetGridData(result7c4d94f12381b2c2c38d941e8dba8928,result2dff53097010e57f5c95f700983350be,"ManpowerGrid",ref ISpace);
if (_elementBase != null)  iSpace.SetLoopExpressionData("ManpowerGrid","25683F52-E21A-4CE3-9196-7BCFA640A94B",_objectFactory.GetGridRPP("ManpowerGrid"),_elementBase.GetGridLoopQuery("25683F52-E21A-4CE3-9196-7BCFA640A94B","ManpowerGrid",true,ref ISpace), ref ISpace);

}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mg_d109_rateininr (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MG_d109_RateinINR-OnChange");
object MG_d109_TotalEquipmentcost=iSpace.Sum("[08F73C4A-3B94-4327-8859-B98388D1C9CD]","MG_d109_TotalEquipmentcost","",ISpace["gv_instanceid"].Value);
ISpace["MF_EquipmentTotal"].Value=Convert.ChangeType(MG_d109_TotalEquipmentcost, MG_d109_TotalEquipmentcost.GetType());;
base.WriteDebugInfo(@"object MG_d109_TotalEquipmentcost=iSpace.Sum(""[08F73C4A-3B94-4327-8859-B98388D1C9CD]"",""MG_d109_TotalEquipmentcost"","""",ISpace[""gv_instanceid""].Value);
ISpace[""MF_EquipmentTotal""].Value=Convert.ChangeType(MG_d109_TotalEquipmentcost, MG_d109_TotalEquipmentcost.GetType());;");

var querySource61e7d77340d395e92de5549773196e79 =GetQueryExpressionDataSource("61e7d773-40d3-95e9-2de5-549773196e79");

DataTable result61e7d77340d395e92de5549773196e79=iSpace.SetGridDataSource(querySource61e7d77340d395e92de5549773196e79, _objectFactory.GetGridRPP("EquipmentGrid"),@"EXEC [GetGridData08F73C4A-3B94-4327-8859-B98388D1C9CD] '" + ISpace["gv_instanceid"].Value + @"'");


base.WriteDebugInfo(@"var querySource61e7d77340d395e92de5549773196e79 =GetQueryExpressionDataSource(""61e7d773-40d3-95e9-2de5-549773196e79"");DataTable result61e7d77340d395e92de5549773196e79=iSpace.SetGridDataSource(querySource61e7d77340d395e92de5549773196e79, _objectFactory.GetGridRPP(""EquipmentGrid""),@""EXEC [GetGridData08F73C4A-3B94-4327-8859-B98388D1C9CD] '"" + ISpace[""gv_instanceid""].Value + @""'"");");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result83ae6bea5b86be67af2d86bd670877ef=acdataIspaceE1B5DCB812784AA0A8B21C0CDE17E77A.GetQueryExpressionBindings("83ae6bea-5b86-be67-af2d-86bd670877ef");
iSpace.SetGridData(result61e7d77340d395e92de5549773196e79,result83ae6bea5b86be67af2d86bd670877ef,"EquipmentGrid",ref ISpace);
if (_elementBase != null)  iSpace.SetLoopExpressionData("EquipmentGrid","08F73C4A-3B94-4327-8859-B98388D1C9CD",_objectFactory.GetGridRPP("EquipmentGrid"),_elementBase.GetGridLoopQuery("08F73C4A-3B94-4327-8859-B98388D1C9CD","EquipmentGrid",true,ref ISpace), ref ISpace);

}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mg_d154_ratepermonth (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MG_d154_RatePerMonth-OnChange");
object MG_d154_TotalCost=iSpace.Sum("[25683F52-E21A-4CE3-9196-7BCFA640A94B]","MG_d154_TotalCost","",ISpace["gv_instanceid"].Value);
ISpace["MF_ManPowerTotal"].Value=Convert.ChangeType(MG_d154_TotalCost, MG_d154_TotalCost.GetType());;
base.WriteDebugInfo(@"object MG_d154_TotalCost=iSpace.Sum(""[25683F52-E21A-4CE3-9196-7BCFA640A94B]"",""MG_d154_TotalCost"","""",ISpace[""gv_instanceid""].Value);
ISpace[""MF_ManPowerTotal""].Value=Convert.ChangeType(MG_d154_TotalCost, MG_d154_TotalCost.GetType());;");

var querySource7c4d94f12381b2c2c38d941e8dba8928 =GetQueryExpressionDataSource("7c4d94f1-2381-b2c2-c38d-941e8dba8928");

DataTable result7c4d94f12381b2c2c38d941e8dba8928=iSpace.SetGridDataSource(querySource7c4d94f12381b2c2c38d941e8dba8928, _objectFactory.GetGridRPP("ManpowerGrid"),@"EXEC [GetGridData25683F52-E21A-4CE3-9196-7BCFA640A94B] '" + ISpace["gv_instanceid"].Value + @"'");


base.WriteDebugInfo(@"var querySource7c4d94f12381b2c2c38d941e8dba8928 =GetQueryExpressionDataSource(""7c4d94f1-2381-b2c2-c38d-941e8dba8928"");DataTable result7c4d94f12381b2c2c38d941e8dba8928=iSpace.SetGridDataSource(querySource7c4d94f12381b2c2c38d941e8dba8928, _objectFactory.GetGridRPP(""ManpowerGrid""),@""EXEC [GetGridData25683F52-E21A-4CE3-9196-7BCFA640A94B] '"" + ISpace[""gv_instanceid""].Value + @""'"");");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result2dff53097010e57f5c95f700983350be=acdataIspaceE1B5DCB812784AA0A8B21C0CDE17E77A.GetQueryExpressionBindings("2dff5309-7010-e57f-5c95-f700983350be");
iSpace.SetGridData(result7c4d94f12381b2c2c38d941e8dba8928,result2dff53097010e57f5c95f700983350be,"ManpowerGrid",ref ISpace);
if (_elementBase != null)  iSpace.SetLoopExpressionData("ManpowerGrid","25683F52-E21A-4CE3-9196-7BCFA640A94B",_objectFactory.GetGridRPP("ManpowerGrid"),_elementBase.GetGridLoopQuery("25683F52-E21A-4CE3-9196-7BCFA640A94B","ManpowerGrid",true,ref ISpace), ref ISpace);

}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mg_d154_duration (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MG_d154_Duration-OnChange");
base.WriteDebugInfo(@"EXEC [GetCalculatedEndDate] '#MF_d10_Duration','#MF_d10_YearMonth','#MF_d10_FromDate'");

var querySourceeae2baebd143cc0a8acf8c0f81dbfb8a =GetQueryExpressionDataSource("eae2baeb-d143-cc0a-8acf-8c0f81dbfb8a");
Dictionary<short,object> resulteae2baebd143cc0a8acf8c0f81dbfb8a=iSpace.ExecuteQuery(querySourceeae2baebd143cc0a8acf8c0f81dbfb8a,@"EXEC [GetCalculatedEndDate] '" + ISpace["MF_d10_Duration"].Value + @"','" + ISpace["MF_d10_YearMonth"].Value + @"','" + ISpace["MF_d10_FromDate"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceeae2baebd143cc0a8acf8c0f81dbfb8a =GetQueryExpressionDataSource(""eae2baeb-d143-cc0a-8acf-8c0f81dbfb8a"");Dictionary<short,object> resulteae2baebd143cc0a8acf8c0f81dbfb8a=iSpace.ExecuteQuery(querySourceeae2baebd143cc0a8acf8c0f81dbfb8a,@""EXEC [GetCalculatedEndDate] '"" + ISpace[""MF_d10_Duration""].Value + @""','"" + ISpace[""MF_d10_YearMonth""].Value + @""','"" + ISpace[""MF_d10_FromDate""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resulteae2baebd143cc0a8acf8c0f81dbfb8a!=null) && (resulteae2baebd143cc0a8acf8c0f81dbfb8a.Count!=0))
{
if(resulteae2baebd143cc0a8acf8c0f81dbfb8a.ContainsKey(0))
ISpace["MF_d10_ToDate"].Value = resulteae2baebd143cc0a8acf8c0f81dbfb8a[0];
if(resulteae2baebd143cc0a8acf8c0f81dbfb8a.ContainsKey(0))
ISpace["MF_d10_ActualEndDate"].Value = resulteae2baebd143cc0a8acf8c0f81dbfb8a[0];
}
else{
ISpace["MF_d10_ToDate"].Value = null;ISpace["MF_d10_ActualEndDate"].Value = null;
}
object MG_d154_TotalCost=iSpace.Sum("[25683F52-E21A-4CE3-9196-7BCFA640A94B]","MG_d154_TotalCost","",ISpace["gv_instanceid"].Value);
ISpace["MF_ManPowerTotal"].Value=Convert.ChangeType(MG_d154_TotalCost, MG_d154_TotalCost.GetType());;
base.WriteDebugInfo(@"object MG_d154_TotalCost=iSpace.Sum(""[25683F52-E21A-4CE3-9196-7BCFA640A94B]"",""MG_d154_TotalCost"","""",ISpace[""gv_instanceid""].Value);
ISpace[""MF_ManPowerTotal""].Value=Convert.ChangeType(MG_d154_TotalCost, MG_d154_TotalCost.GetType());;");

var querySource7c4d94f12381b2c2c38d941e8dba8928 =GetQueryExpressionDataSource("7c4d94f1-2381-b2c2-c38d-941e8dba8928");

DataTable result7c4d94f12381b2c2c38d941e8dba8928=iSpace.SetGridDataSource(querySource7c4d94f12381b2c2c38d941e8dba8928, _objectFactory.GetGridRPP("ManpowerGrid"),@"EXEC [GetGridData25683F52-E21A-4CE3-9196-7BCFA640A94B] '" + ISpace["gv_instanceid"].Value + @"'");


base.WriteDebugInfo(@"var querySource7c4d94f12381b2c2c38d941e8dba8928 =GetQueryExpressionDataSource(""7c4d94f1-2381-b2c2-c38d-941e8dba8928"");DataTable result7c4d94f12381b2c2c38d941e8dba8928=iSpace.SetGridDataSource(querySource7c4d94f12381b2c2c38d941e8dba8928, _objectFactory.GetGridRPP(""ManpowerGrid""),@""EXEC [GetGridData25683F52-E21A-4CE3-9196-7BCFA640A94B] '"" + ISpace[""gv_instanceid""].Value + @""'"");");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result2dff53097010e57f5c95f700983350be=acdataIspaceE1B5DCB812784AA0A8B21C0CDE17E77A.GetQueryExpressionBindings("2dff5309-7010-e57f-5c95-f700983350be");
iSpace.SetGridData(result7c4d94f12381b2c2c38d941e8dba8928,result2dff53097010e57f5c95f700983350be,"ManpowerGrid",ref ISpace);
if (_elementBase != null)  iSpace.SetLoopExpressionData("ManpowerGrid","25683F52-E21A-4CE3-9196-7BCFA640A94B",_objectFactory.GetGridRPP("ManpowerGrid"),_elementBase.GetGridLoopQuery("25683F52-E21A-4CE3-9196-7BCFA640A94B","ManpowerGrid",true,ref ISpace), ref ISpace);

}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mg_d109_quantity (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MG_d109_Quantity-OnChange");
object MG_d109_TotalEquipmentcost=iSpace.Sum("[08F73C4A-3B94-4327-8859-B98388D1C9CD]","MG_d109_TotalEquipmentcost","",ISpace["gv_instanceid"].Value);
ISpace["MF_EquipmentTotal"].Value=Convert.ChangeType(MG_d109_TotalEquipmentcost, MG_d109_TotalEquipmentcost.GetType());;
base.WriteDebugInfo(@"object MG_d109_TotalEquipmentcost=iSpace.Sum(""[08F73C4A-3B94-4327-8859-B98388D1C9CD]"",""MG_d109_TotalEquipmentcost"","""",ISpace[""gv_instanceid""].Value);
ISpace[""MF_EquipmentTotal""].Value=Convert.ChangeType(MG_d109_TotalEquipmentcost, MG_d109_TotalEquipmentcost.GetType());;");

var querySource61e7d77340d395e92de5549773196e79 =GetQueryExpressionDataSource("61e7d773-40d3-95e9-2de5-549773196e79");

DataTable result61e7d77340d395e92de5549773196e79=iSpace.SetGridDataSource(querySource61e7d77340d395e92de5549773196e79, _objectFactory.GetGridRPP("EquipmentGrid"),@"EXEC [GetGridData08F73C4A-3B94-4327-8859-B98388D1C9CD] '" + ISpace["gv_instanceid"].Value + @"'");


base.WriteDebugInfo(@"var querySource61e7d77340d395e92de5549773196e79 =GetQueryExpressionDataSource(""61e7d773-40d3-95e9-2de5-549773196e79"");DataTable result61e7d77340d395e92de5549773196e79=iSpace.SetGridDataSource(querySource61e7d77340d395e92de5549773196e79, _objectFactory.GetGridRPP(""EquipmentGrid""),@""EXEC [GetGridData08F73C4A-3B94-4327-8859-B98388D1C9CD] '"" + ISpace[""gv_instanceid""].Value + @""'"");");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result83ae6bea5b86be67af2d86bd670877ef=acdataIspaceE1B5DCB812784AA0A8B21C0CDE17E77A.GetQueryExpressionBindings("83ae6bea-5b86-be67-af2d-86bd670877ef");
iSpace.SetGridData(result61e7d77340d395e92de5549773196e79,result83ae6bea5b86be67af2d86bd670877ef,"EquipmentGrid",ref ISpace);
if (_elementBase != null)  iSpace.SetLoopExpressionData("EquipmentGrid","08F73C4A-3B94-4327-8859-B98388D1C9CD",_objectFactory.GetGridRPP("EquipmentGrid"),_elementBase.GetGridLoopQuery("08F73C4A-3B94-4327-8859-B98388D1C9CD","EquipmentGrid",true,ref ISpace), ref ISpace);

}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mg_d28_budgetamount (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MG_d28_BudgetAmount-OnChange");
object MG_d28_BudgetAmount=iSpace.Sum("[B73036BB-FE7D-4B0D-998A-985294F8FC5B]","MG_d28_BudgetAmount","",ISpace["gv_instanceid"].Value);
ISpace["MF_d10_BudgetTotalAmount"].Value=Convert.ChangeType(MG_d28_BudgetAmount, MG_d28_BudgetAmount.GetType());;
base.WriteDebugInfo(@"object MG_d28_BudgetAmount=iSpace.Sum(""[B73036BB-FE7D-4B0D-998A-985294F8FC5B]"",""MG_d28_BudgetAmount"","""",ISpace[""gv_instanceid""].Value);
ISpace[""MF_d10_BudgetTotalAmount""].Value=Convert.ChangeType(MG_d28_BudgetAmount, MG_d28_BudgetAmount.GetType());;");
base.WriteDebugInfo(@"EXEC ProjectCreationBudgetCalculation '@@gv_InstanceId'");

var querySourcec3995c1b9f1af85fab715bef2a0b203e =GetQueryExpressionDataSource("c3995c1b-9f1a-f85f-ab71-5bef2a0b203e");
Dictionary<short,object> resultc3995c1b9f1af85fab715bef2a0b203e=iSpace.ExecuteQuery(querySourcec3995c1b9f1af85fab715bef2a0b203e,@"EXEC ProjectCreationBudgetCalculation '" + ISpace["gv_instanceid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourcec3995c1b9f1af85fab715bef2a0b203e =GetQueryExpressionDataSource(""c3995c1b-9f1a-f85f-ab71-5bef2a0b203e"");Dictionary<short,object> resultc3995c1b9f1af85fab715bef2a0b203e=iSpace.ExecuteQuery(querySourcec3995c1b9f1af85fab715bef2a0b203e,@""EXEC ProjectCreationBudgetCalculation '"" + ISpace[""gv_instanceid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultc3995c1b9f1af85fab715bef2a0b203e!=null) && (resultc3995c1b9f1af85fab715bef2a0b203e.Count!=0))
{
if(resultc3995c1b9f1af85fab715bef2a0b203e.ContainsKey(0))
ISpace["MF_d10_RecurringAmount"].Value = resultc3995c1b9f1af85fab715bef2a0b203e[0];
if(resultc3995c1b9f1af85fab715bef2a0b203e.ContainsKey(1))
ISpace["MF_d10_NonRecurringAmount"].Value = resultc3995c1b9f1af85fab715bef2a0b203e[1];
}
else{
ISpace["MF_d10_RecurringAmount"].Value = null;ISpace["MF_d10_NonRecurringAmount"].Value = null;
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mg_d154_hrapermonth (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MG_d154_HRAPerMonth-OnChange");
object MG_d154_TotalCost=iSpace.Sum("[25683F52-E21A-4CE3-9196-7BCFA640A94B]","MG_d154_TotalCost","",ISpace["gv_instanceid"].Value);
ISpace["MF_ManPowerTotal"].Value=Convert.ChangeType(MG_d154_TotalCost, MG_d154_TotalCost.GetType());;
base.WriteDebugInfo(@"object MG_d154_TotalCost=iSpace.Sum(""[25683F52-E21A-4CE3-9196-7BCFA640A94B]"",""MG_d154_TotalCost"","""",ISpace[""gv_instanceid""].Value);
ISpace[""MF_ManPowerTotal""].Value=Convert.ChangeType(MG_d154_TotalCost, MG_d154_TotalCost.GetType());;");

var querySource7c4d94f12381b2c2c38d941e8dba8928 =GetQueryExpressionDataSource("7c4d94f1-2381-b2c2-c38d-941e8dba8928");

DataTable result7c4d94f12381b2c2c38d941e8dba8928=iSpace.SetGridDataSource(querySource7c4d94f12381b2c2c38d941e8dba8928, _objectFactory.GetGridRPP("ManpowerGrid"),@"EXEC [GetGridData25683F52-E21A-4CE3-9196-7BCFA640A94B] '" + ISpace["gv_instanceid"].Value + @"'");


base.WriteDebugInfo(@"var querySource7c4d94f12381b2c2c38d941e8dba8928 =GetQueryExpressionDataSource(""7c4d94f1-2381-b2c2-c38d-941e8dba8928"");DataTable result7c4d94f12381b2c2c38d941e8dba8928=iSpace.SetGridDataSource(querySource7c4d94f12381b2c2c38d941e8dba8928, _objectFactory.GetGridRPP(""ManpowerGrid""),@""EXEC [GetGridData25683F52-E21A-4CE3-9196-7BCFA640A94B] '"" + ISpace[""gv_instanceid""].Value + @""'"");");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result2dff53097010e57f5c95f700983350be=acdataIspaceE1B5DCB812784AA0A8B21C0CDE17E77A.GetQueryExpressionBindings("2dff5309-7010-e57f-5c95-f700983350be");
iSpace.SetGridData(result7c4d94f12381b2c2c38d941e8dba8928,result2dff53097010e57f5c95f700983350be,"ManpowerGrid",ref ISpace);
if (_elementBase != null)  iSpace.SetLoopExpressionData("ManpowerGrid","25683F52-E21A-4CE3-9196-7BCFA640A94B",_objectFactory.GetGridRPP("ManpowerGrid"),_elementBase.GetGridLoopQuery("25683F52-E21A-4CE3-9196-7BCFA640A94B","ManpowerGrid",true,ref ISpace), ref ISpace);

}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mg_d154_hrapercentage (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MG_d154_HRAPercentage-OnChange");
object MG_d154_TotalCost=iSpace.Sum("[25683F52-E21A-4CE3-9196-7BCFA640A94B]","MG_d154_TotalCost","",ISpace["gv_instanceid"].Value);
ISpace["MF_ManPowerTotal"].Value=Convert.ChangeType(MG_d154_TotalCost, MG_d154_TotalCost.GetType());;
base.WriteDebugInfo(@"object MG_d154_TotalCost=iSpace.Sum(""[25683F52-E21A-4CE3-9196-7BCFA640A94B]"",""MG_d154_TotalCost"","""",ISpace[""gv_instanceid""].Value);
ISpace[""MF_ManPowerTotal""].Value=Convert.ChangeType(MG_d154_TotalCost, MG_d154_TotalCost.GetType());;");

var querySource7c4d94f12381b2c2c38d941e8dba8928 =GetQueryExpressionDataSource("7c4d94f1-2381-b2c2-c38d-941e8dba8928");

DataTable result7c4d94f12381b2c2c38d941e8dba8928=iSpace.SetGridDataSource(querySource7c4d94f12381b2c2c38d941e8dba8928, _objectFactory.GetGridRPP("ManpowerGrid"),@"EXEC [GetGridData25683F52-E21A-4CE3-9196-7BCFA640A94B] '" + ISpace["gv_instanceid"].Value + @"'");


base.WriteDebugInfo(@"var querySource7c4d94f12381b2c2c38d941e8dba8928 =GetQueryExpressionDataSource(""7c4d94f1-2381-b2c2-c38d-941e8dba8928"");DataTable result7c4d94f12381b2c2c38d941e8dba8928=iSpace.SetGridDataSource(querySource7c4d94f12381b2c2c38d941e8dba8928, _objectFactory.GetGridRPP(""ManpowerGrid""),@""EXEC [GetGridData25683F52-E21A-4CE3-9196-7BCFA640A94B] '"" + ISpace[""gv_instanceid""].Value + @""'"");");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result2dff53097010e57f5c95f700983350be=acdataIspaceE1B5DCB812784AA0A8B21C0CDE17E77A.GetQueryExpressionBindings("2dff5309-7010-e57f-5c95-f700983350be");
iSpace.SetGridData(result7c4d94f12381b2c2c38d941e8dba8928,result2dff53097010e57f5c95f700983350be,"ManpowerGrid",ref ISpace);
if (_elementBase != null)  iSpace.SetLoopExpressionData("ManpowerGrid","25683F52-E21A-4CE3-9196-7BCFA640A94B",_objectFactory.GetGridRPP("ManpowerGrid"),_elementBase.GetGridLoopQuery("25683F52-E21A-4CE3-9196-7BCFA640A94B","ManpowerGrid",true,ref ISpace), ref ISpace);

}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mg_d154_no_ofmanpowerposition (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MG_d154_No_OfManpowerPosition-OnChange");
object MG_d154_TotalCost=iSpace.Sum("[25683F52-E21A-4CE3-9196-7BCFA640A94B]","MG_d154_TotalCost","",ISpace["gv_instanceid"].Value);
ISpace["MF_ManPowerTotal"].Value=Convert.ChangeType(MG_d154_TotalCost, MG_d154_TotalCost.GetType());;
base.WriteDebugInfo(@"object MG_d154_TotalCost=iSpace.Sum(""[25683F52-E21A-4CE3-9196-7BCFA640A94B]"",""MG_d154_TotalCost"","""",ISpace[""gv_instanceid""].Value);
ISpace[""MF_ManPowerTotal""].Value=Convert.ChangeType(MG_d154_TotalCost, MG_d154_TotalCost.GetType());;");

var querySource7c4d94f12381b2c2c38d941e8dba8928 =GetQueryExpressionDataSource("7c4d94f1-2381-b2c2-c38d-941e8dba8928");

DataTable result7c4d94f12381b2c2c38d941e8dba8928=iSpace.SetGridDataSource(querySource7c4d94f12381b2c2c38d941e8dba8928, _objectFactory.GetGridRPP("ManpowerGrid"),@"EXEC [GetGridData25683F52-E21A-4CE3-9196-7BCFA640A94B] '" + ISpace["gv_instanceid"].Value + @"'");


base.WriteDebugInfo(@"var querySource7c4d94f12381b2c2c38d941e8dba8928 =GetQueryExpressionDataSource(""7c4d94f1-2381-b2c2-c38d-941e8dba8928"");DataTable result7c4d94f12381b2c2c38d941e8dba8928=iSpace.SetGridDataSource(querySource7c4d94f12381b2c2c38d941e8dba8928, _objectFactory.GetGridRPP(""ManpowerGrid""),@""EXEC [GetGridData25683F52-E21A-4CE3-9196-7BCFA640A94B] '"" + ISpace[""gv_instanceid""].Value + @""'"");");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result2dff53097010e57f5c95f700983350be=acdataIspaceE1B5DCB812784AA0A8B21C0CDE17E77A.GetQueryExpressionBindings("2dff5309-7010-e57f-5c95-f700983350be");
iSpace.SetGridData(result7c4d94f12381b2c2c38d941e8dba8928,result2dff53097010e57f5c95f700983350be,"ManpowerGrid",ref ISpace);
if (_elementBase != null)  iSpace.SetLoopExpressionData("ManpowerGrid","25683F52-E21A-4CE3-9196-7BCFA640A94B",_objectFactory.GetGridRPP("ManpowerGrid"),_elementBase.GetGridLoopQuery("25683F52-E21A-4CE3-9196-7BCFA640A94B","ManpowerGrid",true,ref ISpace), ref ISpace);

}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mf_d10_duration (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MF_d10_Duration-OnChange");
base.WriteDebugInfo(@"EXEC [GetCalculatedEndDate] '#MF_d10_Duration','#MF_d10_YearMonth','#MF_d10_FromDate'");

var querySourceeae2baebd143cc0a8acf8c0f81dbfb8a =GetQueryExpressionDataSource("eae2baeb-d143-cc0a-8acf-8c0f81dbfb8a");
Dictionary<short,object> resulteae2baebd143cc0a8acf8c0f81dbfb8a=iSpace.ExecuteQuery(querySourceeae2baebd143cc0a8acf8c0f81dbfb8a,@"EXEC [GetCalculatedEndDate] '" + ISpace["MF_d10_Duration"].Value + @"','" + ISpace["MF_d10_YearMonth"].Value + @"','" + ISpace["MF_d10_FromDate"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceeae2baebd143cc0a8acf8c0f81dbfb8a =GetQueryExpressionDataSource(""eae2baeb-d143-cc0a-8acf-8c0f81dbfb8a"");Dictionary<short,object> resulteae2baebd143cc0a8acf8c0f81dbfb8a=iSpace.ExecuteQuery(querySourceeae2baebd143cc0a8acf8c0f81dbfb8a,@""EXEC [GetCalculatedEndDate] '"" + ISpace[""MF_d10_Duration""].Value + @""','"" + ISpace[""MF_d10_YearMonth""].Value + @""','"" + ISpace[""MF_d10_FromDate""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resulteae2baebd143cc0a8acf8c0f81dbfb8a!=null) && (resulteae2baebd143cc0a8acf8c0f81dbfb8a.Count!=0))
{
if(resulteae2baebd143cc0a8acf8c0f81dbfb8a.ContainsKey(0))
ISpace["MF_d10_ToDate"].Value = resulteae2baebd143cc0a8acf8c0f81dbfb8a[0];
if(resulteae2baebd143cc0a8acf8c0f81dbfb8a.ContainsKey(0))
ISpace["MF_d10_ActualEndDate"].Value = resulteae2baebd143cc0a8acf8c0f81dbfb8a[0];
}
else{
ISpace["MF_d10_ToDate"].Value = null;ISpace["MF_d10_ActualEndDate"].Value = null;
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
ISpace["MF_d10_ProjectName"].Value=Trim(ISpace["MF_d10_ProjectName"].Value);
base.WriteDebugInfo(@"ISpace[""MF_d10_ProjectName""].Value=Trim(ISpace[""MF_d10_ProjectName""].Value);");
if(ISpace["MF_d10_FinancialYearID"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""MF_d10_FinancialYearID""].Value=="""")");
ISpace["Message"].Value=@"Error:Please Select Financial Year";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Error:Please Select Financial Year"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if(ISpace["MF_d10_FundingAgency"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""MF_d10_FundingAgency""].Value=="""")");
ISpace["Message"].Value=@"ERROR:Please Enter Funding Agency Name";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""ERROR:Please Enter Funding Agency Name"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if(ISpace["MF_d10_ProjectCategoryID"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""MF_d10_ProjectCategoryID""].Value=="""")");
ISpace["Message"].Value=@"Error: Please  Select Project Category";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Error: Please  Select Project Category"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if(ISpace["MF_d10_ProjectName"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""MF_d10_ProjectName""].Value=="""")");
ISpace["Message"].Value=@"ERROR:Please Enter Project Name";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""ERROR:Please Enter Project Name"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if(ISpace["MF_d10_SanctionedNumber"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""MF_d10_SanctionedNumber""].Value=="""")");
ISpace["Message"].Value=@"ERROR:Please Enter Sanctioned Number";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""ERROR:Please Enter Sanctioned Number"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if((ISpace["MF_d10_SanctionedDate"].Value == null))
{
base.WriteDebugInfo(@"if((ISpace[""MF_d10_SanctionedDate""].Value == null))");
ISpace["Message"].Value=@"Error:Please Select Sanctioned Date";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Error:Please Select Sanctioned Date"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if(ISpace["MF_d10_ProjectType"].Value=="450")
{
base.WriteDebugInfo(@"if(ISpace[""MF_d10_ProjectType""].Value==""450"")");
if(ISpace["m_currency"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""m_currency""].Value=="""")");
ISpace["Message"].Value=@"Error:Please Select Currency";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Error:Please Select Currency"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
}
if(ISpace["MF_d10_Duration"].Value==0)
{
base.WriteDebugInfo(@"if(ISpace[""MF_d10_Duration""].Value==0)");
ISpace["Message"].Value=@"Error:Please Enter Duration";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Error:Please Enter Duration"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if(ISpace["MF_d10_YearMonth"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""MF_d10_YearMonth""].Value=="""")");
ISpace["Message"].Value=@"Error:Please Select Month/ Year";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Error:Please Select Month/ Year"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if(ISpace["MF_d10_Sector"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""MF_d10_Sector""].Value=="""")");
ISpace["Message"].Value=@"Error:Please Select Sector";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Error:Please Select Sector"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if(ISpace["MF_d10_ProjectBudget"].Value==0)
{
base.WriteDebugInfo(@"if(ISpace[""MF_d10_ProjectBudget""].Value==0)");
ISpace["Message"].Value=@"Error:Please Enter Project Budget";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Error:Please Enter Project Budget"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if(ISpace["MF_d10_BudgetTotalAmount"].Value!=ISpace["MF_d10_ProjectBudget"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_d10_BudgetTotalAmount""].Value!=ISpace[""MF_d10_ProjectBudget""].Value)");
ISpace["Message"].Value=@"Error:Total Amount Should be Equal to Project Budget";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Error:Total Amount Should be Equal to Project Budget"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC [ValidateProjectBudgetMPEQValidation] '@@gv_InstanceId','#MF_ManPowerTotal','#MF_EquipmentTotal'");

var querySource502df243ca8b5455c370be23ac6857ac =GetQueryExpressionDataSource("502df243-ca8b-5455-c370-be23ac6857ac");
Dictionary<short,object> result502df243ca8b5455c370be23ac6857ac=iSpace.ExecuteQuery(querySource502df243ca8b5455c370be23ac6857ac,@"EXEC [ValidateProjectBudgetMPEQValidation] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["MF_ManPowerTotal"].Value + @"','" + ISpace["MF_EquipmentTotal"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource502df243ca8b5455c370be23ac6857ac =GetQueryExpressionDataSource(""502df243-ca8b-5455-c370-be23ac6857ac"");Dictionary<short,object> result502df243ca8b5455c370be23ac6857ac=iSpace.ExecuteQuery(querySource502df243ca8b5455c370be23ac6857ac,@""EXEC [ValidateProjectBudgetMPEQValidation] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""MF_ManPowerTotal""].Value + @""','"" + ISpace[""MF_EquipmentTotal""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result502df243ca8b5455c370be23ac6857ac!=null) && (result502df243ca8b5455c370be23ac6857ac.Count!=0))
{
if(result502df243ca8b5455c370be23ac6857ac.ContainsKey(0))
ISpace["ErrId"].Value = result502df243ca8b5455c370be23ac6857ac[0];
if(result502df243ca8b5455c370be23ac6857ac.ContainsKey(1))
ISpace["ErrMsg"].Value = result502df243ca8b5455c370be23ac6857ac[1];
}
else{
ISpace["ErrId"].Value = null;ISpace["ErrMsg"].Value = null;
}
}
if(ISpace["ErrId"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""ErrId""].Value==1)");
ISpace["ErrId"].Value=0;
base.WriteDebugInfo(@"ISpace[""ErrId""].Value=0;");
ISpace["Message"].Value=String.Format(@"{0}",ISpace["ErrMsg"].Value);
base.WriteDebugInfo(@"ISpace[""Message""].Value=String.Format(@""{0}"",ISpace[""ErrMsg""].Value);");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if(ISpace["MF_d10_ProjectRefNo"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""MF_d10_ProjectRefNo""].Value=="""")");
base.WriteDebugInfo(@"EXEC [GenerateTemproryProjectCode] '#MF_d10_EmployeeCode','#MF_d10_EmpDeptCode','@@gv_InstanceId','#MF_d10_ProjectCategoryID'");

var querySource022d541eff48f7a6f4a9bbfb60447b55 =GetQueryExpressionDataSource("022d541e-ff48-f7a6-f4a9-bbfb60447b55");
Dictionary<short,object> result022d541eff48f7a6f4a9bbfb60447b55=iSpace.ExecuteQuery(querySource022d541eff48f7a6f4a9bbfb60447b55,@"EXEC [GenerateTemproryProjectCode] '" + ISpace["MF_d10_EmployeeCode"].Value + @"','" + ISpace["MF_d10_EmpDeptCode"].Value + @"','" + ISpace["gv_instanceid"].Value + @"','" + ISpace["MF_d10_ProjectCategoryID"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource022d541eff48f7a6f4a9bbfb60447b55 =GetQueryExpressionDataSource(""022d541e-ff48-f7a6-f4a9-bbfb60447b55"");Dictionary<short,object> result022d541eff48f7a6f4a9bbfb60447b55=iSpace.ExecuteQuery(querySource022d541eff48f7a6f4a9bbfb60447b55,@""EXEC [GenerateTemproryProjectCode] '"" + ISpace[""MF_d10_EmployeeCode""].Value + @""','"" + ISpace[""MF_d10_EmpDeptCode""].Value + @""','"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""MF_d10_ProjectCategoryID""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result022d541eff48f7a6f4a9bbfb60447b55!=null) && (result022d541eff48f7a6f4a9bbfb60447b55.Count!=0))
{
if(result022d541eff48f7a6f4a9bbfb60447b55.ContainsKey(0))
ISpace["MF_d10_ProjectRefNo"].Value = result022d541eff48f7a6f4a9bbfb60447b55[0];
}
else{
ISpace["MF_d10_ProjectRefNo"].Value = null;
}
}
ISpace["Subject"].Value=ISpace["MF_d10_ProjectRefNo"].Value;
base.WriteDebugInfo(@"ISpace[""Subject""].Value=ISpace[""MF_d10_ProjectRefNo""].Value;");
base.WriteDebugInfo(@"EXEC InnovaceNoCode..[FormSave_7F2113FD-876A-41F4-BEAC-881CA7D38469] '@@gv_InstanceId','@@gv_ActivityMapId','b92107f7-28a5-49d0-8b7f-312c4826dd60','#MF_d10_FinancialYearID','#MF_d10_ProjectName',#MF_d10_Duration,#MF_d10_IfManpower,#MF_d10_IfEquipment,#MF_d10_IsExternalIns,'#MF_d10_FundReceiptMode','#MF_d10_PrincipalInvestigator','#MF_d10_ProjectproposalID','#MF_d10_SanctionedNumber','#MF_d10_DepartmentID','#MF_d10_SchemeID','#MF_d10_FundingAgency','#MF_d10_YearMonth','#MF_d10_ProjectStatus','#MF_d10_Designation','#MF_d10_ProjectCategoryID',#MF_d10_IsSubmitted,'#MF_d10_SanctionedDate','#MF_d10_FromDate','#MF_d10_ToDate',#MF_d10_ProjectBudget,'#MF_d10_ProjectType','#MF_d10_Sector','#MF_d10_ProjectDetailsID','#MF_d10_InstanceId','#MF_d10_ProjectCode','#MF_d10_ProjectRefNo','#MF_d10_EmployeeBasicInfoId','#MF_d10_ActualDate','#MF_d10_ActualEndDate',#MF_d10_NonRecurringAmount,#MF_d10_RecurringAmount,#MF_d10_IfExtended,'#MF_d10_ExtendedDate',#MF_d10_BudgetTotalAmount,#MF_d10_Overhead,#MF_d10_ExchangeRate,'#MF_d10_DocumentComments',#MF_d19_OverallAmount,#MF_d145_OverallTotalCost,'@@gv_UserId'");

var querySource4537606388E046C881D304F87FA722B3 =GetQueryExpressionDataSource("45376063-88E0-46C8-81D3-04F87FA722B3");
Dictionary<short,object> result4537606388E046C881D304F87FA722B3=iSpace.ExecuteQuery(querySource4537606388E046C881D304F87FA722B3,@"EXEC InnovaceNoCode..[FormSave_7F2113FD-876A-41F4-BEAC-881CA7D38469] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','b92107f7-28a5-49d0-8b7f-312c4826dd60','" + ISpace["MF_d10_FinancialYearID"].Value + @"','" + ISpace["MF_d10_ProjectName"].Value + @"'," + ISpace["MF_d10_Duration"].Value + @"," + ISpace["MF_d10_IfManpower"].Value + @"," + ISpace["MF_d10_IfEquipment"].Value + @"," + ISpace["MF_d10_IsExternalIns"].Value + @",'" + ISpace["MF_d10_FundReceiptMode"].Value + @"','" + ISpace["MF_d10_PrincipalInvestigator"].Value + @"','" + ISpace["MF_d10_ProjectproposalID"].Value + @"','" + ISpace["MF_d10_SanctionedNumber"].Value + @"','" + ISpace["MF_d10_DepartmentID"].Value + @"','" + ISpace["MF_d10_SchemeID"].Value + @"','" + ISpace["MF_d10_FundingAgency"].Value + @"','" + ISpace["MF_d10_YearMonth"].Value + @"','" + ISpace["MF_d10_ProjectStatus"].Value + @"','" + ISpace["MF_d10_Designation"].Value + @"','" + ISpace["MF_d10_ProjectCategoryID"].Value + @"'," + ISpace["MF_d10_IsSubmitted"].Value + @",'" + ISpace["MF_d10_SanctionedDate"].Value + @"','" + ISpace["MF_d10_FromDate"].Value + @"','" + ISpace["MF_d10_ToDate"].Value + @"'," + ISpace["MF_d10_ProjectBudget"].Value + @",'" + ISpace["MF_d10_ProjectType"].Value + @"','" + ISpace["MF_d10_Sector"].Value + @"','" + ISpace["MF_d10_ProjectDetailsID"].Value + @"','" + ISpace["MF_d10_InstanceId"].Value + @"','" + ISpace["MF_d10_ProjectCode"].Value + @"','" + ISpace["MF_d10_ProjectRefNo"].Value + @"','" + ISpace["MF_d10_EmployeeBasicInfoId"].Value + @"','" + ISpace["MF_d10_ActualDate"].Value + @"','" + ISpace["MF_d10_ActualEndDate"].Value + @"'," + ISpace["MF_d10_NonRecurringAmount"].Value + @"," + ISpace["MF_d10_RecurringAmount"].Value + @"," + ISpace["MF_d10_IfExtended"].Value + @",'" + ISpace["MF_d10_ExtendedDate"].Value + @"'," + ISpace["MF_d10_BudgetTotalAmount"].Value + @"," + ISpace["MF_d10_Overhead"].Value + @"," + ISpace["MF_d10_ExchangeRate"].Value + @",'" + ISpace["MF_d10_DocumentComments"].Value + @"'," + ISpace["MF_d19_OverallAmount"].Value + @"," + ISpace["MF_d145_OverallTotalCost"].Value + @",'" + ISpace["gv_userid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource4537606388E046C881D304F87FA722B3 =GetQueryExpressionDataSource(""45376063-88E0-46C8-81D3-04F87FA722B3"");Dictionary<short,object> result4537606388E046C881D304F87FA722B3=iSpace.ExecuteQuery(querySource4537606388E046C881D304F87FA722B3,@""EXEC InnovaceNoCode..[FormSave_7F2113FD-876A-41F4-BEAC-881CA7D38469] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','b92107f7-28a5-49d0-8b7f-312c4826dd60','"" + ISpace[""MF_d10_FinancialYearID""].Value + @""','"" + ISpace[""MF_d10_ProjectName""].Value + @""',"" + ISpace[""MF_d10_Duration""].Value + @"","" + ISpace[""MF_d10_IfManpower""].Value + @"","" + ISpace[""MF_d10_IfEquipment""].Value + @"","" + ISpace[""MF_d10_IsExternalIns""].Value + @"",'"" + ISpace[""MF_d10_FundReceiptMode""].Value + @""','"" + ISpace[""MF_d10_PrincipalInvestigator""].Value + @""','"" + ISpace[""MF_d10_ProjectproposalID""].Value + @""','"" + ISpace[""MF_d10_SanctionedNumber""].Value + @""','"" + ISpace[""MF_d10_DepartmentID""].Value + @""','"" + ISpace[""MF_d10_SchemeID""].Value + @""','"" + ISpace[""MF_d10_FundingAgency""].Value + @""','"" + ISpace[""MF_d10_YearMonth""].Value + @""','"" + ISpace[""MF_d10_ProjectStatus""].Value + @""','"" + ISpace[""MF_d10_Designation""].Value + @""','"" + ISpace[""MF_d10_ProjectCategoryID""].Value + @""',"" + ISpace[""MF_d10_IsSubmitted""].Value + @"",'"" + ISpace[""MF_d10_SanctionedDate""].Value + @""','"" + ISpace[""MF_d10_FromDate""].Value + @""','"" + ISpace[""MF_d10_ToDate""].Value + @""',"" + ISpace[""MF_d10_ProjectBudget""].Value + @"",'"" + ISpace[""MF_d10_ProjectType""].Value + @""','"" + ISpace[""MF_d10_Sector""].Value + @""','"" + ISpace[""MF_d10_ProjectDetailsID""].Value + @""','"" + ISpace[""MF_d10_InstanceId""].Value + @""','"" + ISpace[""MF_d10_ProjectCode""].Value + @""','"" + ISpace[""MF_d10_ProjectRefNo""].Value + @""','"" + ISpace[""MF_d10_EmployeeBasicInfoId""].Value + @""','"" + ISpace[""MF_d10_ActualDate""].Value + @""','"" + ISpace[""MF_d10_ActualEndDate""].Value + @""',"" + ISpace[""MF_d10_NonRecurringAmount""].Value + @"","" + ISpace[""MF_d10_RecurringAmount""].Value + @"","" + ISpace[""MF_d10_IfExtended""].Value + @"",'"" + ISpace[""MF_d10_ExtendedDate""].Value + @""',"" + ISpace[""MF_d10_BudgetTotalAmount""].Value + @"","" + ISpace[""MF_d10_Overhead""].Value + @"","" + ISpace[""MF_d10_ExchangeRate""].Value + @"",'"" + ISpace[""MF_d10_DocumentComments""].Value + @""',"" + ISpace[""MF_d19_OverallAmount""].Value + @"","" + ISpace[""MF_d145_OverallTotalCost""].Value + @"",'"" + ISpace[""gv_userid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result4537606388E046C881D304F87FA722B3!=null) && (result4537606388E046C881D304F87FA722B3.Count!=0))
{
if(result4537606388E046C881D304F87FA722B3.ContainsKey(0))
ISpace["ExecutionMessage"].Value = result4537606388E046C881D304F87FA722B3[0];
}
else{
ISpace["ExecutionMessage"].Value = null;
}
base.WriteDebugInfo(@"EXEC InnovaceNoCode..[GridSave_6677BAB3-659A-4A96-9067-5D365F60CB62]   '@@gv_InstanceId','@@gv_ActivityMapId','6677BAB3-659A-4A96-9067-5D365F60CB62'");

var querySourceA74347A4C3F242078D0D320D67D9EB3D =GetQueryExpressionDataSource("A74347A4-C3F2-4207-8D0D-320D67D9EB3D");
Dictionary<short,object> resultA74347A4C3F242078D0D320D67D9EB3D=iSpace.ExecuteQuery(querySourceA74347A4C3F242078D0D320D67D9EB3D,@"EXEC InnovaceNoCode..[GridSave_6677BAB3-659A-4A96-9067-5D365F60CB62]   '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','6677BAB3-659A-4A96-9067-5D365F60CB62'",false);

base.WriteDebugInfo(@"var querySourceA74347A4C3F242078D0D320D67D9EB3D =GetQueryExpressionDataSource(""A74347A4-C3F2-4207-8D0D-320D67D9EB3D"");Dictionary<short,object> resultA74347A4C3F242078D0D320D67D9EB3D=iSpace.ExecuteQuery(querySourceA74347A4C3F242078D0D320D67D9EB3D,@""EXEC InnovaceNoCode..[GridSave_6677BAB3-659A-4A96-9067-5D365F60CB62]   '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','6677BAB3-659A-4A96-9067-5D365F60CB62'"",false);");
base.WriteDebugInfo(@"");

if((resultA74347A4C3F242078D0D320D67D9EB3D!=null) && (resultA74347A4C3F242078D0D320D67D9EB3D.Count!=0))
{
if(resultA74347A4C3F242078D0D320D67D9EB3D.ContainsKey(0))
ISpace["ExecutionMessage"].Value = resultA74347A4C3F242078D0D320D67D9EB3D[0];
}
else{
ISpace["ExecutionMessage"].Value = null;
}
base.WriteDebugInfo(@"EXEC InnovaceNoCode..[GridSave_08F73C4A-3B94-4327-8859-B98388D1C9CD]   '@@gv_InstanceId','@@gv_ActivityMapId','08F73C4A-3B94-4327-8859-B98388D1C9CD'");

var querySource430846EA3E4949098632AC7C0F753F81 =GetQueryExpressionDataSource("430846EA-3E49-4909-8632-AC7C0F753F81");
Dictionary<short,object> result430846EA3E4949098632AC7C0F753F81=iSpace.ExecuteQuery(querySource430846EA3E4949098632AC7C0F753F81,@"EXEC InnovaceNoCode..[GridSave_08F73C4A-3B94-4327-8859-B98388D1C9CD]   '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','08F73C4A-3B94-4327-8859-B98388D1C9CD'",false);

base.WriteDebugInfo(@"var querySource430846EA3E4949098632AC7C0F753F81 =GetQueryExpressionDataSource(""430846EA-3E49-4909-8632-AC7C0F753F81"");Dictionary<short,object> result430846EA3E4949098632AC7C0F753F81=iSpace.ExecuteQuery(querySource430846EA3E4949098632AC7C0F753F81,@""EXEC InnovaceNoCode..[GridSave_08F73C4A-3B94-4327-8859-B98388D1C9CD]   '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','08F73C4A-3B94-4327-8859-B98388D1C9CD'"",false);");
base.WriteDebugInfo(@"");

if((result430846EA3E4949098632AC7C0F753F81!=null) && (result430846EA3E4949098632AC7C0F753F81.Count!=0))
{
if(result430846EA3E4949098632AC7C0F753F81.ContainsKey(0))
ISpace["ExecutionMessage"].Value = result430846EA3E4949098632AC7C0F753F81[0];
}
else{
ISpace["ExecutionMessage"].Value = null;
}
base.WriteDebugInfo(@"EXEC InnovaceNoCode..[GridSave_B73036BB-FE7D-4B0D-998A-985294F8FC5B]   '@@gv_InstanceId','@@gv_ActivityMapId','B73036BB-FE7D-4B0D-998A-985294F8FC5B'");

var querySourceA5343EC8F5DC490FA308848B457A1F27 =GetQueryExpressionDataSource("A5343EC8-F5DC-490F-A308-848B457A1F27");
Dictionary<short,object> resultA5343EC8F5DC490FA308848B457A1F27=iSpace.ExecuteQuery(querySourceA5343EC8F5DC490FA308848B457A1F27,@"EXEC InnovaceNoCode..[GridSave_B73036BB-FE7D-4B0D-998A-985294F8FC5B]   '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','B73036BB-FE7D-4B0D-998A-985294F8FC5B'",false);

base.WriteDebugInfo(@"var querySourceA5343EC8F5DC490FA308848B457A1F27 =GetQueryExpressionDataSource(""A5343EC8-F5DC-490F-A308-848B457A1F27"");Dictionary<short,object> resultA5343EC8F5DC490FA308848B457A1F27=iSpace.ExecuteQuery(querySourceA5343EC8F5DC490FA308848B457A1F27,@""EXEC InnovaceNoCode..[GridSave_B73036BB-FE7D-4B0D-998A-985294F8FC5B]   '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','B73036BB-FE7D-4B0D-998A-985294F8FC5B'"",false);");
base.WriteDebugInfo(@"");

if((resultA5343EC8F5DC490FA308848B457A1F27!=null) && (resultA5343EC8F5DC490FA308848B457A1F27.Count!=0))
{
if(resultA5343EC8F5DC490FA308848B457A1F27.ContainsKey(0))
ISpace["ExecutionMessage"].Value = resultA5343EC8F5DC490FA308848B457A1F27[0];
}
else{
ISpace["ExecutionMessage"].Value = null;
}
base.WriteDebugInfo(@"EXEC InnovaceNoCode..[GridSave_25683F52-E21A-4CE3-9196-7BCFA640A94B]   '@@gv_InstanceId','@@gv_ActivityMapId','25683F52-E21A-4CE3-9196-7BCFA640A94B'");

var querySource3E77697F9C9B4F7086A4EEAF4AAF6937 =GetQueryExpressionDataSource("3E77697F-9C9B-4F70-86A4-EEAF4AAF6937");
Dictionary<short,object> result3E77697F9C9B4F7086A4EEAF4AAF6937=iSpace.ExecuteQuery(querySource3E77697F9C9B4F7086A4EEAF4AAF6937,@"EXEC InnovaceNoCode..[GridSave_25683F52-E21A-4CE3-9196-7BCFA640A94B]   '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','25683F52-E21A-4CE3-9196-7BCFA640A94B'",false);

base.WriteDebugInfo(@"var querySource3E77697F9C9B4F7086A4EEAF4AAF6937 =GetQueryExpressionDataSource(""3E77697F-9C9B-4F70-86A4-EEAF4AAF6937"");Dictionary<short,object> result3E77697F9C9B4F7086A4EEAF4AAF6937=iSpace.ExecuteQuery(querySource3E77697F9C9B4F7086A4EEAF4AAF6937,@""EXEC InnovaceNoCode..[GridSave_25683F52-E21A-4CE3-9196-7BCFA640A94B]   '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','25683F52-E21A-4CE3-9196-7BCFA640A94B'"",false);");
base.WriteDebugInfo(@"");

if((result3E77697F9C9B4F7086A4EEAF4AAF6937!=null) && (result3E77697F9C9B4F7086A4EEAF4AAF6937.Count!=0))
{
if(result3E77697F9C9B4F7086A4EEAF4AAF6937.ContainsKey(0))
ISpace["ExecutionMessage"].Value = result3E77697F9C9B4F7086A4EEAF4AAF6937[0];
}
else{
ISpace["ExecutionMessage"].Value = null;
}
ISpace["Message"].Value=@"Success:Submitted Successfully";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Success:Submitted Successfully"";");

ISpace["RedirectUrl"].RedirectType="R";
ISpace["RedirectUrl"].Value="?PkActMId=34CF8FAF-7574-478F-9C4A-A65F98E4D18A&frmElementId=7816392B-A9EF-486D-88F9-AC7C972D679B&PkPrMId=B219A0EA-0254-4F69-B989-B681DD475183&formVersionId=02A1FE25-AE94-461D-9B6F-A7AC8493B6F6&Ver=0.0000";
base.WriteDebugInfo(@"
ISpace[""RedirectUrl""].RedirectType=""R"";
ISpace[""RedirectUrl""].Value=""?PkActMId=34CF8FAF-7574-478F-9C4A-A65F98E4D18A&frmElementId=7816392B-A9EF-486D-88F9-AC7C972D679B&PkPrMId=B219A0EA-0254-4F69-B989-B681DD475183&formVersionId=02A1FE25-AE94-461D-9B6F-A7AC8493B6F6&Ver=0.0000"";");
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
		if(elementName.ToLower().Equals("mf_d10_fromdate"))
    {
    			SubscribeElementEvents_mf_d10_fromdate(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mf_d10_yearmonth"))
    {
    			SubscribeElementEvents_mf_d10_yearmonth(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mf_d10_projectproposalid"))
    {
    			SubscribeElementEvents_mf_d10_projectproposalid(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mg_d154_totalmonths"))
    {
    			SubscribeElementEvents_mg_d154_totalmonths(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mg_d109_rateininr"))
    {
    			SubscribeElementEvents_mg_d109_rateininr(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mg_d154_ratepermonth"))
    {
    			SubscribeElementEvents_mg_d154_ratepermonth(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mg_d154_duration"))
    {
    			SubscribeElementEvents_mg_d154_duration(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mg_d109_quantity"))
    {
    			SubscribeElementEvents_mg_d109_quantity(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mg_d28_budgetamount"))
    {
    			SubscribeElementEvents_mg_d28_budgetamount(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mg_d154_hrapermonth"))
    {
    			SubscribeElementEvents_mg_d154_hrapermonth(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mg_d154_hrapercentage"))
    {
    			SubscribeElementEvents_mg_d154_hrapercentage(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mg_d154_no_ofmanpowerposition"))
    {
    			SubscribeElementEvents_mg_d154_no_ofmanpowerposition(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mf_d10_duration"))
    {
    			SubscribeElementEvents_mf_d10_duration(ref dfsParam);
    }
}
	if(methodName.ToLower().Equals("onclick"))
{
		if(elementName.ToLower().Equals("m_cancel"))
{
			SubscribeElementEvents_m_cancel(ref dfsParam);
}
		if(elementName.ToLower().Equals("submitform"))
{
			SubscribeElementEvents_submitform(ref dfsParam);
}
}
	if(methodName.ToLower().Equals("onafterrowdeleting"))
{
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
public class ISpaceBD6CC522F7E646CBB2009C41F448175B : VirtualForm
{
IISpace iSpace = new ISpace();
AcDataISpaceBD6CC522F7E646CBB2009C41F448175B acdataIspaceBD6CC522F7E646CBB2009C41F448175B=new AcDataISpaceBD6CC522F7E646CBB2009C41F448175B();
private void SubscribeFormEvents_root(ref Dictionary<string, ServiceElementData> ISpace)
{
try
{
base.WriteDebugInfo(@"Root-OnAfterFormLoad");
if(ISpace["FormVersionId"].Value=="ADD720B3-8CFA-4B65-B90D-7D2AC805F75E")
{
ISpace["UI_InvisibleRow"].Visible="false";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""ADD720B3-8CFA-4B65-B90D-7D2AC805F75E"")
{
ISpace[""UI_InvisibleRow""].Visible=""false"";
}");
ISpace["Comments"].Value="";
base.WriteDebugInfo(@"ISpace[""Comments""].Value="""";");
ISpace["M_MoveTo"].Value="";
base.WriteDebugInfo(@"ISpace[""M_MoveTo""].Value="""";");
ISpace["MF_d10_FundReceiptMode"].Visible="false";ISpace["MF_d10_SchemeID"].Visible="false";
base.WriteDebugInfo(@"ISpace[""MF_d10_FundReceiptMode""].Visible=""false"";ISpace[""MF_d10_SchemeID""].Visible=""false"";");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_m_cancel (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"M_Cancel-OnClick");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC [UnlockProcessInstance] '@@gv_InstanceId','@@gv_UserMapId'");

var querySourcecfc8b06a84f18ec2a3f33b615821582c =GetQueryExpressionDataSource("cfc8b06a-84f1-8ec2-a3f3-3b615821582c");
Dictionary<short,object> resultcfc8b06a84f18ec2a3f33b615821582c=iSpace.ExecuteQuery(querySourcecfc8b06a84f18ec2a3f33b615821582c,@"EXEC [UnlockProcessInstance] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_usermapid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourcecfc8b06a84f18ec2a3f33b615821582c =GetQueryExpressionDataSource(""cfc8b06a-84f1-8ec2-a3f3-3b615821582c"");Dictionary<short,object> resultcfc8b06a84f18ec2a3f33b615821582c=iSpace.ExecuteQuery(querySourcecfc8b06a84f18ec2a3f33b615821582c,@""EXEC [UnlockProcessInstance] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_usermapid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultcfc8b06a84f18ec2a3f33b615821582c!=null) && (resultcfc8b06a84f18ec2a3f33b615821582c.Count!=0))
{
if(resultcfc8b06a84f18ec2a3f33b615821582c.ContainsKey(0))
ISpace["ExecutionMessage"].Value = resultcfc8b06a84f18ec2a3f33b615821582c[0];
}
else{
ISpace["ExecutionMessage"].Value = null;
}
ISpace["Message"].Value=@"SUCCESS:Cancelled Successfully";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""SUCCESS:Cancelled Successfully"";");
}

ISpace["RedirectUrl"].RedirectType="R";
ISpace["RedirectUrl"].Value="/Inbox";
base.WriteDebugInfo(@"
ISpace[""RedirectUrl""].RedirectType=""R"";
ISpace[""RedirectUrl""].Value=""/Inbox"";");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_m_history (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"M_History-OnClick");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["UI_History"].ShowDialog=true;;
base.WriteDebugInfo(@"ISpace[""UI_History""].ShowDialog=true;;");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySource598a64be325b1665a4f0dc3818c98d36 =GetQueryExpressionDataSource("598a64be-325b-1665-a4f0-dc3818c98d36");

DataTable result598a64be325b1665a4f0dc3818c98d36=iSpace.SetGridDataSource(querySource598a64be325b1665a4f0dc3818c98d36, _objectFactory.GetGridRPP("MG_Comments"),@"EXEC [GetInstanceFlowDetais] '" + ISpace["gv_instanceid"].Value + @"'");


base.WriteDebugInfo(@"var querySource598a64be325b1665a4f0dc3818c98d36 =GetQueryExpressionDataSource(""598a64be-325b-1665-a4f0-dc3818c98d36"");DataTable result598a64be325b1665a4f0dc3818c98d36=iSpace.SetGridDataSource(querySource598a64be325b1665a4f0dc3818c98d36, _objectFactory.GetGridRPP(""MG_Comments""),@""EXEC [GetInstanceFlowDetais] '"" + ISpace[""gv_instanceid""].Value + @""'"");");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result89cce784320fd42d41c53fb5840cbc25=acdataIspaceBD6CC522F7E646CBB2009C41F448175B.GetQueryExpressionBindings("89cce784-320f-d42d-41c5-3fb5840cbc25");
iSpace.SetGridData(result598a64be325b1665a4f0dc3818c98d36,result89cce784320fd42d41c53fb5840cbc25,"MG_Comments",ref ISpace);
if (_elementBase != null)  iSpace.SetLoopExpressionData("MG_Comments","f1825943-98b5-f54f-0225-0081ef436f94",_objectFactory.GetGridRPP("MG_Comments"),_elementBase.GetGridLoopQuery("f1825943-98b5-f54f-0225-0081ef436f94","MG_Comments",true,ref ISpace), ref ISpace);

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
if(ISpace["M_MoveTo"].Value=="RETURN")
{
base.WriteDebugInfo(@"if(ISpace[""M_MoveTo""].Value==""RETURN"")");
ISpace["M_FlowType"].Value="RETURN";
base.WriteDebugInfo(@"ISpace[""M_FlowType""].Value=""RETURN"";");
ISpace["MF_d10_ProjectStatus"].Value="8";
base.WriteDebugInfo(@"ISpace[""MF_d10_ProjectStatus""].Value=""8"";");
}
if(ISpace["M_MoveTo"].Value=="APPROVE")
{
base.WriteDebugInfo(@"if(ISpace[""M_MoveTo""].Value==""APPROVE"")");
ISpace["M_FlowType"].Value="APPROVE";
base.WriteDebugInfo(@"ISpace[""M_FlowType""].Value=""APPROVE"";");
}
if(ISpace["M_MoveTo"].Value=="REJECT")
{
base.WriteDebugInfo(@"if(ISpace[""M_MoveTo""].Value==""REJECT"")");
ISpace["M_FlowType"].Value="REJECT";
base.WriteDebugInfo(@"ISpace[""M_FlowType""].Value=""REJECT"";");
ISpace["MF_d10_ProjectStatus"].Value="32";
base.WriteDebugInfo(@"ISpace[""MF_d10_ProjectStatus""].Value=""32"";");
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
if(ISpace["M_MoveTo"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""M_MoveTo""].Value=="""")");
ISpace["Message"].Value=@"ERROR:Move To should be Mandatory";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""ERROR:Move To should be Mandatory"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if(ISpace["M_MoveTo"].Value=="RETURN"||ISpace["M_MoveTo"].Value=="REJECT")
{
base.WriteDebugInfo(@"if(ISpace[""M_MoveTo""].Value==""RETURN""||ISpace[""M_MoveTo""].Value==""REJECT"")");
if(ISpace["Comments"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""Comments""].Value=="""")");
ISpace["Message"].Value=@"ERROR:Comments should be Mandatory";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""ERROR:Comments should be Mandatory"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
}
base.WriteDebugInfo(@"EXEC [UpdateProjectStatus] '@@gv_InstanceId'");

var querySource2ed62a73b6f234b7c20cdca9b5617146 =GetQueryExpressionDataSource("2ed62a73-b6f2-34b7-c20c-dca9b5617146");
Dictionary<short,object> result2ed62a73b6f234b7c20cdca9b5617146=iSpace.ExecuteQuery(querySource2ed62a73b6f234b7c20cdca9b5617146,@"EXEC [UpdateProjectStatus] '" + ISpace["gv_instanceid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource2ed62a73b6f234b7c20cdca9b5617146 =GetQueryExpressionDataSource(""2ed62a73-b6f2-34b7-c20c-dca9b5617146"");Dictionary<short,object> result2ed62a73b6f234b7c20cdca9b5617146=iSpace.ExecuteQuery(querySource2ed62a73b6f234b7c20cdca9b5617146,@""EXEC [UpdateProjectStatus] '"" + ISpace[""gv_instanceid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result2ed62a73b6f234b7c20cdca9b5617146!=null) && (result2ed62a73b6f234b7c20cdca9b5617146.Count!=0))
{
if(result2ed62a73b6f234b7c20cdca9b5617146.ContainsKey(0))
ISpace["ExecutionMessage"].Value = result2ed62a73b6f234b7c20cdca9b5617146[0];
}
else{
ISpace["ExecutionMessage"].Value = null;
}
ISpace["Message"].Value=@"Success:Submitted Successfully";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Success:Submitted Successfully"";");

ISpace["RedirectUrl"].RedirectType="R";
ISpace["RedirectUrl"].Value="/Inbox";
base.WriteDebugInfo(@"
ISpace[""RedirectUrl""].RedirectType=""R"";
ISpace[""RedirectUrl""].Value=""/Inbox"";");
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
		if(elementName.ToLower().Equals("m_cancel"))
{
			SubscribeElementEvents_m_cancel(ref dfsParam);
}
		if(elementName.ToLower().Equals("m_history"))
{
			SubscribeElementEvents_m_history(ref dfsParam);
}
		if(elementName.ToLower().Equals("submitform"))
{
			SubscribeElementEvents_submitform(ref dfsParam);
}
}
	if(methodName.ToLower().Equals("onafterrowdeleting"))
{
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
public class ISpace218B0C87E3E24D2EBB8FB38C51CAD1FE : VirtualForm
{
IISpace iSpace = new ISpace();
AcDataISpace218B0C87E3E24D2EBB8FB38C51CAD1FE acdataIspace218B0C87E3E24D2EBB8FB38C51CAD1FE=new AcDataISpace218B0C87E3E24D2EBB8FB38C51CAD1FE();
private void SubscribeFormEvents_root(ref Dictionary<string, ServiceElementData> ISpace)
{
try
{
base.WriteDebugInfo(@"Root-OnAfterFormLoad");
if(ISpace["FormVersionId"].Value=="ADD720B3-8CFA-4B65-B90D-7D2AC805F75E")
{
ISpace["UI_InvisibleRow"].Visible="false";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""ADD720B3-8CFA-4B65-B90D-7D2AC805F75E"")
{
ISpace[""UI_InvisibleRow""].Visible=""false"";
}");
ISpace["Comments"].Value="";
base.WriteDebugInfo(@"ISpace[""Comments""].Value="""";");
ISpace["M_MoveTo"].Value="";
base.WriteDebugInfo(@"ISpace[""M_MoveTo""].Value="""";");
ISpace["MF_d10_FundReceiptMode"].Visible="false";ISpace["MF_d10_SchemeID"].Visible="false";
base.WriteDebugInfo(@"ISpace[""MF_d10_FundReceiptMode""].Visible=""false"";ISpace[""MF_d10_SchemeID""].Visible=""false"";");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_m_cancel (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"M_Cancel-OnClick");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC [UnlockProcessInstance] '@@gv_InstanceId','@@gv_UserMapId'");

var querySourcecfc8b06a84f18ec2a3f33b615821582c =GetQueryExpressionDataSource("cfc8b06a-84f1-8ec2-a3f3-3b615821582c");
Dictionary<short,object> resultcfc8b06a84f18ec2a3f33b615821582c=iSpace.ExecuteQuery(querySourcecfc8b06a84f18ec2a3f33b615821582c,@"EXEC [UnlockProcessInstance] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_usermapid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourcecfc8b06a84f18ec2a3f33b615821582c =GetQueryExpressionDataSource(""cfc8b06a-84f1-8ec2-a3f3-3b615821582c"");Dictionary<short,object> resultcfc8b06a84f18ec2a3f33b615821582c=iSpace.ExecuteQuery(querySourcecfc8b06a84f18ec2a3f33b615821582c,@""EXEC [UnlockProcessInstance] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_usermapid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultcfc8b06a84f18ec2a3f33b615821582c!=null) && (resultcfc8b06a84f18ec2a3f33b615821582c.Count!=0))
{
if(resultcfc8b06a84f18ec2a3f33b615821582c.ContainsKey(0))
ISpace["ExecutionMessage"].Value = resultcfc8b06a84f18ec2a3f33b615821582c[0];
}
else{
ISpace["ExecutionMessage"].Value = null;
}
ISpace["Message"].Value=@"SUCCESS:Cancelled Successfully";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""SUCCESS:Cancelled Successfully"";");
}

ISpace["RedirectUrl"].RedirectType="R";
ISpace["RedirectUrl"].Value="/Inbox";
base.WriteDebugInfo(@"
ISpace[""RedirectUrl""].RedirectType=""R"";
ISpace[""RedirectUrl""].Value=""/Inbox"";");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_m_history (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"M_History-OnClick");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["UI_History"].ShowDialog=true;;
base.WriteDebugInfo(@"ISpace[""UI_History""].ShowDialog=true;;");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySource598a64be325b1665a4f0dc3818c98d36 =GetQueryExpressionDataSource("598a64be-325b-1665-a4f0-dc3818c98d36");

DataTable result598a64be325b1665a4f0dc3818c98d36=iSpace.SetGridDataSource(querySource598a64be325b1665a4f0dc3818c98d36, _objectFactory.GetGridRPP("MG_Comments"),@"EXEC [GetInstanceFlowDetais] '" + ISpace["gv_instanceid"].Value + @"'");


base.WriteDebugInfo(@"var querySource598a64be325b1665a4f0dc3818c98d36 =GetQueryExpressionDataSource(""598a64be-325b-1665-a4f0-dc3818c98d36"");DataTable result598a64be325b1665a4f0dc3818c98d36=iSpace.SetGridDataSource(querySource598a64be325b1665a4f0dc3818c98d36, _objectFactory.GetGridRPP(""MG_Comments""),@""EXEC [GetInstanceFlowDetais] '"" + ISpace[""gv_instanceid""].Value + @""'"");");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result89cce784320fd42d41c53fb5840cbc25=acdataIspace218B0C87E3E24D2EBB8FB38C51CAD1FE.GetQueryExpressionBindings("89cce784-320f-d42d-41c5-3fb5840cbc25");
iSpace.SetGridData(result598a64be325b1665a4f0dc3818c98d36,result89cce784320fd42d41c53fb5840cbc25,"MG_Comments",ref ISpace);
if (_elementBase != null)  iSpace.SetLoopExpressionData("MG_Comments","f1825943-98b5-f54f-0225-0081ef436f94",_objectFactory.GetGridRPP("MG_Comments"),_elementBase.GetGridLoopQuery("f1825943-98b5-f54f-0225-0081ef436f94","MG_Comments",true,ref ISpace), ref ISpace);

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
if(ISpace["M_MoveTo"].Value=="APPROVE")
{
base.WriteDebugInfo(@"if(ISpace[""M_MoveTo""].Value==""APPROVE"")");
ISpace["MF_d10_ProjectStatus"].Value="9";
base.WriteDebugInfo(@"ISpace[""MF_d10_ProjectStatus""].Value=""9"";");
}
if(ISpace["M_MoveTo"].Value=="RETURN")
{
base.WriteDebugInfo(@"if(ISpace[""M_MoveTo""].Value==""RETURN"")");
ISpace["M_FlowType"].Value="RETURN";
base.WriteDebugInfo(@"ISpace[""M_FlowType""].Value=""RETURN"";");
ISpace["MF_d10_ProjectStatus"].Value="8";
base.WriteDebugInfo(@"ISpace[""MF_d10_ProjectStatus""].Value=""8"";");
}
if(ISpace["M_MoveTo"].Value=="APPROVE")
{
base.WriteDebugInfo(@"if(ISpace[""M_MoveTo""].Value==""APPROVE"")");
ISpace["M_FlowType"].Value="APPROVE";
base.WriteDebugInfo(@"ISpace[""M_FlowType""].Value=""APPROVE"";");
}
if(ISpace["M_MoveTo"].Value=="REJECT")
{
base.WriteDebugInfo(@"if(ISpace[""M_MoveTo""].Value==""REJECT"")");
ISpace["M_FlowType"].Value="REJECT";
base.WriteDebugInfo(@"ISpace[""M_FlowType""].Value=""REJECT"";");
ISpace["MF_d10_ProjectStatus"].Value="32";
base.WriteDebugInfo(@"ISpace[""MF_d10_ProjectStatus""].Value=""32"";");
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
if(ISpace["M_MoveTo"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""M_MoveTo""].Value=="""")");
ISpace["Message"].Value=@"ERROR:Move To should be Mandatory";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""ERROR:Move To should be Mandatory"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if(ISpace["M_MoveTo"].Value=="RETURN"||ISpace["M_MoveTo"].Value=="REJECT")
{
base.WriteDebugInfo(@"if(ISpace[""M_MoveTo""].Value==""RETURN""||ISpace[""M_MoveTo""].Value==""REJECT"")");
if(ISpace["Comments"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""Comments""].Value=="""")");
ISpace["Message"].Value=@"ERROR:Comments should be Mandatory";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""ERROR:Comments should be Mandatory"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
}
base.WriteDebugInfo(@"EXEC [UpdateProjectStatus] '@@gv_InstanceId'");

var querySource2ed62a73b6f234b7c20cdca9b5617146 =GetQueryExpressionDataSource("2ed62a73-b6f2-34b7-c20c-dca9b5617146");
Dictionary<short,object> result2ed62a73b6f234b7c20cdca9b5617146=iSpace.ExecuteQuery(querySource2ed62a73b6f234b7c20cdca9b5617146,@"EXEC [UpdateProjectStatus] '" + ISpace["gv_instanceid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource2ed62a73b6f234b7c20cdca9b5617146 =GetQueryExpressionDataSource(""2ed62a73-b6f2-34b7-c20c-dca9b5617146"");Dictionary<short,object> result2ed62a73b6f234b7c20cdca9b5617146=iSpace.ExecuteQuery(querySource2ed62a73b6f234b7c20cdca9b5617146,@""EXEC [UpdateProjectStatus] '"" + ISpace[""gv_instanceid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result2ed62a73b6f234b7c20cdca9b5617146!=null) && (result2ed62a73b6f234b7c20cdca9b5617146.Count!=0))
{
if(result2ed62a73b6f234b7c20cdca9b5617146.ContainsKey(0))
ISpace["ExecutionMessage"].Value = result2ed62a73b6f234b7c20cdca9b5617146[0];
}
else{
ISpace["ExecutionMessage"].Value = null;
}
ISpace["Message"].Value=@"Success:Submitted Successfully";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Success:Submitted Successfully"";");

ISpace["RedirectUrl"].RedirectType="R";
ISpace["RedirectUrl"].Value="/Inbox";
base.WriteDebugInfo(@"
ISpace[""RedirectUrl""].RedirectType=""R"";
ISpace[""RedirectUrl""].Value=""/Inbox"";");
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
		if(elementName.ToLower().Equals("m_cancel"))
{
			SubscribeElementEvents_m_cancel(ref dfsParam);
}
		if(elementName.ToLower().Equals("m_history"))
{
			SubscribeElementEvents_m_history(ref dfsParam);
}
		if(elementName.ToLower().Equals("submitform"))
{
			SubscribeElementEvents_submitform(ref dfsParam);
}
}
	if(methodName.ToLower().Equals("onafterrowdeleting"))
{
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
public class ISpace88470FA805F74764A871E9DAC8F66C89 : VirtualForm
{
IISpace iSpace = new ISpace();
AcDataISpace88470FA805F74764A871E9DAC8F66C89 acdataIspace88470FA805F74764A871E9DAC8F66C89=new AcDataISpace88470FA805F74764A871E9DAC8F66C89();
private void SubscribeFormEvents_root(ref Dictionary<string, ServiceElementData> ISpace)
{
try
{
base.WriteDebugInfo(@"Root-OnAfterFormLoad");
if(ISpace["FormVersionId"].Value=="ADD720B3-8CFA-4B65-B90D-7D2AC805F75E")
{
ISpace["UI_InvisibleRow"].Visible="false";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""ADD720B3-8CFA-4B65-B90D-7D2AC805F75E"")
{
ISpace[""UI_InvisibleRow""].Visible=""false"";
}");
ISpace["Comments"].Value="";
base.WriteDebugInfo(@"ISpace[""Comments""].Value="""";");
ISpace["M_MoveTo"].Value="";
base.WriteDebugInfo(@"ISpace[""M_MoveTo""].Value="""";");
ISpace["MF_d10_FundReceiptMode"].Visible="false";ISpace["MF_d10_SchemeID"].Visible="false";
base.WriteDebugInfo(@"ISpace[""MF_d10_FundReceiptMode""].Visible=""false"";ISpace[""MF_d10_SchemeID""].Visible=""false"";");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_m_cancel (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"M_Cancel-OnClick");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC [UnlockProcessInstance] '@@gv_InstanceId','@@gv_UserMapId'");

var querySourcecfc8b06a84f18ec2a3f33b615821582c =GetQueryExpressionDataSource("cfc8b06a-84f1-8ec2-a3f3-3b615821582c");
Dictionary<short,object> resultcfc8b06a84f18ec2a3f33b615821582c=iSpace.ExecuteQuery(querySourcecfc8b06a84f18ec2a3f33b615821582c,@"EXEC [UnlockProcessInstance] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_usermapid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourcecfc8b06a84f18ec2a3f33b615821582c =GetQueryExpressionDataSource(""cfc8b06a-84f1-8ec2-a3f3-3b615821582c"");Dictionary<short,object> resultcfc8b06a84f18ec2a3f33b615821582c=iSpace.ExecuteQuery(querySourcecfc8b06a84f18ec2a3f33b615821582c,@""EXEC [UnlockProcessInstance] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_usermapid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultcfc8b06a84f18ec2a3f33b615821582c!=null) && (resultcfc8b06a84f18ec2a3f33b615821582c.Count!=0))
{
if(resultcfc8b06a84f18ec2a3f33b615821582c.ContainsKey(0))
ISpace["ExecutionMessage"].Value = resultcfc8b06a84f18ec2a3f33b615821582c[0];
}
else{
ISpace["ExecutionMessage"].Value = null;
}
ISpace["Message"].Value=@"SUCCESS:Cancelled Successfully";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""SUCCESS:Cancelled Successfully"";");
}

ISpace["RedirectUrl"].RedirectType="R";
ISpace["RedirectUrl"].Value="/Inbox";
base.WriteDebugInfo(@"
ISpace[""RedirectUrl""].RedirectType=""R"";
ISpace[""RedirectUrl""].Value=""/Inbox"";");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_m_history (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"M_History-OnClick");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["UI_History"].ShowDialog=true;;
base.WriteDebugInfo(@"ISpace[""UI_History""].ShowDialog=true;;");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySource598a64be325b1665a4f0dc3818c98d36 =GetQueryExpressionDataSource("598a64be-325b-1665-a4f0-dc3818c98d36");

DataTable result598a64be325b1665a4f0dc3818c98d36=iSpace.SetGridDataSource(querySource598a64be325b1665a4f0dc3818c98d36, _objectFactory.GetGridRPP("MG_Comments"),@"EXEC [GetInstanceFlowDetais] '" + ISpace["gv_instanceid"].Value + @"'");


base.WriteDebugInfo(@"var querySource598a64be325b1665a4f0dc3818c98d36 =GetQueryExpressionDataSource(""598a64be-325b-1665-a4f0-dc3818c98d36"");DataTable result598a64be325b1665a4f0dc3818c98d36=iSpace.SetGridDataSource(querySource598a64be325b1665a4f0dc3818c98d36, _objectFactory.GetGridRPP(""MG_Comments""),@""EXEC [GetInstanceFlowDetais] '"" + ISpace[""gv_instanceid""].Value + @""'"");");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result89cce784320fd42d41c53fb5840cbc25=acdataIspace88470FA805F74764A871E9DAC8F66C89.GetQueryExpressionBindings("89cce784-320f-d42d-41c5-3fb5840cbc25");
iSpace.SetGridData(result598a64be325b1665a4f0dc3818c98d36,result89cce784320fd42d41c53fb5840cbc25,"MG_Comments",ref ISpace);
if (_elementBase != null)  iSpace.SetLoopExpressionData("MG_Comments","f1825943-98b5-f54f-0225-0081ef436f94",_objectFactory.GetGridRPP("MG_Comments"),_elementBase.GetGridLoopQuery("f1825943-98b5-f54f-0225-0081ef436f94","MG_Comments",true,ref ISpace), ref ISpace);

}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_m_back (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"M_Back-OnClick");

ISpace["RedirectUrl"].RedirectType="R";
ISpace["RedirectUrl"].Value="?PkActMId=34CF8FAF-7574-478F-9C4A-A65F98E4D18A&frmElementId=7816392B-A9EF-486D-88F9-AC7C972D679B&PkPrMId=B219A0EA-0254-4F69-B989-B681DD475183&formVersionId=02A1FE25-AE94-461D-9B6F-A7AC8493B6F6&Ver=0.0000";
base.WriteDebugInfo(@"
ISpace[""RedirectUrl""].RedirectType=""R"";
ISpace[""RedirectUrl""].Value=""?PkActMId=34CF8FAF-7574-478F-9C4A-A65F98E4D18A&frmElementId=7816392B-A9EF-486D-88F9-AC7C972D679B&PkPrMId=B219A0EA-0254-4F69-B989-B681DD475183&formVersionId=02A1FE25-AE94-461D-9B6F-A7AC8493B6F6&Ver=0.0000"";");
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
}
	if(methodName.ToLower().Equals("onclick"))
{
		if(elementName.ToLower().Equals("m_cancel"))
{
			SubscribeElementEvents_m_cancel(ref dfsParam);
}
		if(elementName.ToLower().Equals("m_history"))
{
			SubscribeElementEvents_m_history(ref dfsParam);
}
		if(elementName.ToLower().Equals("m_back"))
{
			SubscribeElementEvents_m_back(ref dfsParam);
}
}
	if(methodName.ToLower().Equals("onafterrowdeleting"))
{
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
public class ISpaceDC6D256C5F944FE59309FD74A0FF257E : VirtualForm
{
IISpace iSpace = new ISpace();
AcDataISpaceDC6D256C5F944FE59309FD74A0FF257E acdataIspaceDC6D256C5F944FE59309FD74A0FF257E=new AcDataISpaceDC6D256C5F944FE59309FD74A0FF257E();
private void equipmentgrid_onafterrowdeleting(ref Dictionary<string, ServiceElementData> ISpace)
{
try
{
base.WriteDebugInfo(@"EquipmentGrid-OnAfterRowDeleting");
base.WriteDebugInfo(@"EquipmentGrid-OnAfterRowDeleting");
object MG_d109_TotalEquipmentcost=iSpace.Sum("[08F73C4A-3B94-4327-8859-B98388D1C9CD]","MG_d109_TotalEquipmentcost","",ISpace["gv_instanceid"].Value);
ISpace["MF_EquipmentTotal"].Value=Convert.ChangeType(MG_d109_TotalEquipmentcost, MG_d109_TotalEquipmentcost.GetType());;
base.WriteDebugInfo(@"object MG_d109_TotalEquipmentcost=iSpace.Sum(""[08F73C4A-3B94-4327-8859-B98388D1C9CD]"",""MG_d109_TotalEquipmentcost"","""",ISpace[""gv_instanceid""].Value);
ISpace[""MF_EquipmentTotal""].Value=Convert.ChangeType(MG_d109_TotalEquipmentcost, MG_d109_TotalEquipmentcost.GetType());;");

var querySource61e7d77340d395e92de5549773196e79 =GetQueryExpressionDataSource("61e7d773-40d3-95e9-2de5-549773196e79");

DataTable result61e7d77340d395e92de5549773196e79=iSpace.SetGridDataSource(querySource61e7d77340d395e92de5549773196e79, _objectFactory.GetGridRPP("EquipmentGrid"),@"EXEC [GetGridData08F73C4A-3B94-4327-8859-B98388D1C9CD] '" + ISpace["gv_instanceid"].Value + @"'");


base.WriteDebugInfo(@"var querySource61e7d77340d395e92de5549773196e79 =GetQueryExpressionDataSource(""61e7d773-40d3-95e9-2de5-549773196e79"");DataTable result61e7d77340d395e92de5549773196e79=iSpace.SetGridDataSource(querySource61e7d77340d395e92de5549773196e79, _objectFactory.GetGridRPP(""EquipmentGrid""),@""EXEC [GetGridData08F73C4A-3B94-4327-8859-B98388D1C9CD] '"" + ISpace[""gv_instanceid""].Value + @""'"");");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result83ae6bea5b86be67af2d86bd670877ef=acdataIspaceDC6D256C5F944FE59309FD74A0FF257E.GetQueryExpressionBindings("83ae6bea-5b86-be67-af2d-86bd670877ef");
iSpace.SetGridData(result61e7d77340d395e92de5549773196e79,result83ae6bea5b86be67af2d86bd670877ef,"EquipmentGrid",ref ISpace);
if (_elementBase != null)  iSpace.SetLoopExpressionData("EquipmentGrid","08F73C4A-3B94-4327-8859-B98388D1C9CD",_objectFactory.GetGridRPP("EquipmentGrid"),_elementBase.GetGridLoopQuery("08F73C4A-3B94-4327-8859-B98388D1C9CD","EquipmentGrid",true,ref ISpace), ref ISpace);

}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void manpowergrid_onafterrowdeleting(ref Dictionary<string, ServiceElementData> ISpace)
{
try
{
base.WriteDebugInfo(@"ManpowerGrid-OnAfterRowDeleting");
base.WriteDebugInfo(@"ManpowerGrid-OnAfterRowDeleting");
object MG_d154_TotalCost=iSpace.Sum("[25683F52-E21A-4CE3-9196-7BCFA640A94B]","MG_d154_TotalCost","",ISpace["gv_instanceid"].Value);
ISpace["MF_ManPowerTotal"].Value=Convert.ChangeType(MG_d154_TotalCost, MG_d154_TotalCost.GetType());;
base.WriteDebugInfo(@"object MG_d154_TotalCost=iSpace.Sum(""[25683F52-E21A-4CE3-9196-7BCFA640A94B]"",""MG_d154_TotalCost"","""",ISpace[""gv_instanceid""].Value);
ISpace[""MF_ManPowerTotal""].Value=Convert.ChangeType(MG_d154_TotalCost, MG_d154_TotalCost.GetType());;");

var querySource7c4d94f12381b2c2c38d941e8dba8928 =GetQueryExpressionDataSource("7c4d94f1-2381-b2c2-c38d-941e8dba8928");

DataTable result7c4d94f12381b2c2c38d941e8dba8928=iSpace.SetGridDataSource(querySource7c4d94f12381b2c2c38d941e8dba8928, _objectFactory.GetGridRPP("ManpowerGrid"),@"EXEC [GetGridData25683F52-E21A-4CE3-9196-7BCFA640A94B] '" + ISpace["gv_instanceid"].Value + @"'");


base.WriteDebugInfo(@"var querySource7c4d94f12381b2c2c38d941e8dba8928 =GetQueryExpressionDataSource(""7c4d94f1-2381-b2c2-c38d-941e8dba8928"");DataTable result7c4d94f12381b2c2c38d941e8dba8928=iSpace.SetGridDataSource(querySource7c4d94f12381b2c2c38d941e8dba8928, _objectFactory.GetGridRPP(""ManpowerGrid""),@""EXEC [GetGridData25683F52-E21A-4CE3-9196-7BCFA640A94B] '"" + ISpace[""gv_instanceid""].Value + @""'"");");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result2dff53097010e57f5c95f700983350be=acdataIspaceDC6D256C5F944FE59309FD74A0FF257E.GetQueryExpressionBindings("2dff5309-7010-e57f-5c95-f700983350be");
iSpace.SetGridData(result7c4d94f12381b2c2c38d941e8dba8928,result2dff53097010e57f5c95f700983350be,"ManpowerGrid",ref ISpace);
if (_elementBase != null)  iSpace.SetLoopExpressionData("ManpowerGrid","25683F52-E21A-4CE3-9196-7BCFA640A94B",_objectFactory.GetGridRPP("ManpowerGrid"),_elementBase.GetGridLoopQuery("25683F52-E21A-4CE3-9196-7BCFA640A94B","ManpowerGrid",true,ref ISpace), ref ISpace);

}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeFormEvents_root(ref Dictionary<string, ServiceElementData> ISpace)
{
try
{
base.WriteDebugInfo(@"Root-OnAfterFormLoad");
if(ISpace["FormVersionId"].Value=="ADD720B3-8CFA-4B65-B90D-7D2AC805F75E")
{
ISpace["UI_InvisibleRow"].Visible="false";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""ADD720B3-8CFA-4B65-B90D-7D2AC805F75E"")
{
ISpace[""UI_InvisibleRow""].Visible=""false"";
}");
object MG_d28_BudgetAmount=iSpace.Sum("[B73036BB-FE7D-4B0D-998A-985294F8FC5B]","MG_d28_BudgetAmount","",ISpace["gv_instanceid"].Value);
ISpace["MF_d10_BudgetTotalAmount"].Value=Convert.ChangeType(MG_d28_BudgetAmount, MG_d28_BudgetAmount.GetType());;
base.WriteDebugInfo(@"object MG_d28_BudgetAmount=iSpace.Sum(""[B73036BB-FE7D-4B0D-998A-985294F8FC5B]"",""MG_d28_BudgetAmount"","""",ISpace[""gv_instanceid""].Value);
ISpace[""MF_d10_BudgetTotalAmount""].Value=Convert.ChangeType(MG_d28_BudgetAmount, MG_d28_BudgetAmount.GetType());;");
base.WriteDebugInfo(@"EXEC ProjectCreationBudgetCalculation '@@gv_InstanceId'");

var querySourcec3995c1b9f1af85fab715bef2a0b203e =GetQueryExpressionDataSource("c3995c1b-9f1a-f85f-ab71-5bef2a0b203e");
Dictionary<short,object> resultc3995c1b9f1af85fab715bef2a0b203e=iSpace.ExecuteQuery(querySourcec3995c1b9f1af85fab715bef2a0b203e,@"EXEC ProjectCreationBudgetCalculation '" + ISpace["gv_instanceid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourcec3995c1b9f1af85fab715bef2a0b203e =GetQueryExpressionDataSource(""c3995c1b-9f1a-f85f-ab71-5bef2a0b203e"");Dictionary<short,object> resultc3995c1b9f1af85fab715bef2a0b203e=iSpace.ExecuteQuery(querySourcec3995c1b9f1af85fab715bef2a0b203e,@""EXEC ProjectCreationBudgetCalculation '"" + ISpace[""gv_instanceid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultc3995c1b9f1af85fab715bef2a0b203e!=null) && (resultc3995c1b9f1af85fab715bef2a0b203e.Count!=0))
{
if(resultc3995c1b9f1af85fab715bef2a0b203e.ContainsKey(0))
ISpace["MF_d10_RecurringAmount"].Value = resultc3995c1b9f1af85fab715bef2a0b203e[0];
if(resultc3995c1b9f1af85fab715bef2a0b203e.ContainsKey(1))
ISpace["MF_d10_NonRecurringAmount"].Value = resultc3995c1b9f1af85fab715bef2a0b203e[1];
}
else{
ISpace["MF_d10_RecurringAmount"].Value = null;ISpace["MF_d10_NonRecurringAmount"].Value = null;
}
ISpace["MF_d10_ProjectproposalID"].Man=true;ISpace["MF_d10_ProjectCategoryID"].Man=true;ISpace["MF_d10_FundingAgency"].Man=true;ISpace["MF_d10_Sector"].Man=true;ISpace["MF_d10_FinancialYearID"].Man=true;ISpace["MF_d10_SanctionedDate"].Man=true;ISpace["MF_d10_SchemeID"].Visible="true";ISpace["MF_d10_SchemeID"].Man=false;ISpace["MF_d10_SchemeID"].Enbl="true";ISpace["MF_d10_Duration"].Man=true;ISpace["BudgetAllocation"].Man=true;ISpace["MF_d10_Designation"].Enbl="false";ISpace["MF_d10_SanctionedNumber"].Man=true;ISpace["m_currency"].Man=true;ISpace["MF_d10_ProjectType"].Man=true;ISpace["MF_d10_DepartmentID"].Man=false;ISpace["MF_d10_DepartmentID"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MF_d10_ProjectproposalID""].Man=true;ISpace[""MF_d10_ProjectCategoryID""].Man=true;ISpace[""MF_d10_FundingAgency""].Man=true;ISpace[""MF_d10_Sector""].Man=true;ISpace[""MF_d10_FinancialYearID""].Man=true;ISpace[""MF_d10_SanctionedDate""].Man=true;ISpace[""MF_d10_SchemeID""].Visible=""true"";ISpace[""MF_d10_SchemeID""].Man=false;ISpace[""MF_d10_SchemeID""].Enbl=""true"";ISpace[""MF_d10_Duration""].Man=true;ISpace[""BudgetAllocation""].Man=true;ISpace[""MF_d10_Designation""].Enbl=""false"";ISpace[""MF_d10_SanctionedNumber""].Man=true;ISpace[""m_currency""].Man=true;ISpace[""MF_d10_ProjectType""].Man=true;ISpace[""MF_d10_DepartmentID""].Man=false;ISpace[""MF_d10_DepartmentID""].Enbl=""false"";");
if(ISpace["MF_d10_IfManpower"].Value==true)
{
base.WriteDebugInfo(@"if(ISpace[""MF_d10_IfManpower""].Value==true)");
ISpace["ManpowerGrid"].Visible="true";
base.WriteDebugInfo(@"ISpace[""ManpowerGrid""].Visible=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["ManpowerGrid"].Visible="false";
base.WriteDebugInfo(@"ISpace[""ManpowerGrid""].Visible=""false"";");
}
if(ISpace["MF_d10_IfEquipment"].Value==true)
{
base.WriteDebugInfo(@"if(ISpace[""MF_d10_IfEquipment""].Value==true)");
ISpace["EquipmentGrid"].Visible="true";
base.WriteDebugInfo(@"ISpace[""EquipmentGrid""].Visible=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["EquipmentGrid"].Visible="false";
base.WriteDebugInfo(@"ISpace[""EquipmentGrid""].Visible=""false"";");
}
ISpace["MF_d10_FinancialYearID"].Value="19";
base.WriteDebugInfo(@"ISpace[""MF_d10_FinancialYearID""].Value=""19"";");
ISpace["Comments"].Value="";
base.WriteDebugInfo(@"ISpace[""Comments""].Value="""";");
ISpace["M_MoveTo"].Value="";
base.WriteDebugInfo(@"ISpace[""M_MoveTo""].Value="""";");
ISpace["MF_d10_FundReceiptMode"].Visible="false";ISpace["MF_d10_SchemeID"].Visible="false";
base.WriteDebugInfo(@"ISpace[""MF_d10_FundReceiptMode""].Visible=""false"";ISpace[""MF_d10_SchemeID""].Visible=""false"";");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mf_d10_fromdate (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MF_d10_FromDate-OnChange");
base.WriteDebugInfo(@"EXEC [GetCalculatedEndDate] '#MF_d10_Duration','#MF_d10_YearMonth','#MF_d10_FromDate'");

var querySourceeae2baebd143cc0a8acf8c0f81dbfb8a =GetQueryExpressionDataSource("eae2baeb-d143-cc0a-8acf-8c0f81dbfb8a");
Dictionary<short,object> resulteae2baebd143cc0a8acf8c0f81dbfb8a=iSpace.ExecuteQuery(querySourceeae2baebd143cc0a8acf8c0f81dbfb8a,@"EXEC [GetCalculatedEndDate] '" + ISpace["MF_d10_Duration"].Value + @"','" + ISpace["MF_d10_YearMonth"].Value + @"','" + ISpace["MF_d10_FromDate"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceeae2baebd143cc0a8acf8c0f81dbfb8a =GetQueryExpressionDataSource(""eae2baeb-d143-cc0a-8acf-8c0f81dbfb8a"");Dictionary<short,object> resulteae2baebd143cc0a8acf8c0f81dbfb8a=iSpace.ExecuteQuery(querySourceeae2baebd143cc0a8acf8c0f81dbfb8a,@""EXEC [GetCalculatedEndDate] '"" + ISpace[""MF_d10_Duration""].Value + @""','"" + ISpace[""MF_d10_YearMonth""].Value + @""','"" + ISpace[""MF_d10_FromDate""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resulteae2baebd143cc0a8acf8c0f81dbfb8a!=null) && (resulteae2baebd143cc0a8acf8c0f81dbfb8a.Count!=0))
{
if(resulteae2baebd143cc0a8acf8c0f81dbfb8a.ContainsKey(0))
ISpace["MF_d10_ToDate"].Value = resulteae2baebd143cc0a8acf8c0f81dbfb8a[0];
if(resulteae2baebd143cc0a8acf8c0f81dbfb8a.ContainsKey(0))
ISpace["MF_d10_ActualEndDate"].Value = resulteae2baebd143cc0a8acf8c0f81dbfb8a[0];
}
else{
ISpace["MF_d10_ToDate"].Value = null;ISpace["MF_d10_ActualEndDate"].Value = null;
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_m_cancel (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"M_Cancel-OnClick");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC [UnlockProcessInstance] '@@gv_InstanceId','@@gv_UserMapId'");

var querySourcecfc8b06a84f18ec2a3f33b615821582c =GetQueryExpressionDataSource("cfc8b06a-84f1-8ec2-a3f3-3b615821582c");
Dictionary<short,object> resultcfc8b06a84f18ec2a3f33b615821582c=iSpace.ExecuteQuery(querySourcecfc8b06a84f18ec2a3f33b615821582c,@"EXEC [UnlockProcessInstance] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_usermapid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourcecfc8b06a84f18ec2a3f33b615821582c =GetQueryExpressionDataSource(""cfc8b06a-84f1-8ec2-a3f3-3b615821582c"");Dictionary<short,object> resultcfc8b06a84f18ec2a3f33b615821582c=iSpace.ExecuteQuery(querySourcecfc8b06a84f18ec2a3f33b615821582c,@""EXEC [UnlockProcessInstance] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_usermapid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultcfc8b06a84f18ec2a3f33b615821582c!=null) && (resultcfc8b06a84f18ec2a3f33b615821582c.Count!=0))
{
if(resultcfc8b06a84f18ec2a3f33b615821582c.ContainsKey(0))
ISpace["ExecutionMessage"].Value = resultcfc8b06a84f18ec2a3f33b615821582c[0];
}
else{
ISpace["ExecutionMessage"].Value = null;
}
ISpace["Message"].Value=@"SUCCESS:Cancelled Successfully";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""SUCCESS:Cancelled Successfully"";");
}

ISpace["RedirectUrl"].RedirectType="R";
ISpace["RedirectUrl"].Value="/Inbox";
base.WriteDebugInfo(@"
ISpace[""RedirectUrl""].RedirectType=""R"";
ISpace[""RedirectUrl""].Value=""/Inbox"";");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mf_d10_yearmonth (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MF_d10_YearMonth-OnChange");
base.WriteDebugInfo(@"EXEC [GetCalculatedEndDate] '#MF_d10_Duration','#MF_d10_YearMonth','#MF_d10_FromDate'");

var querySourceeae2baebd143cc0a8acf8c0f81dbfb8a =GetQueryExpressionDataSource("eae2baeb-d143-cc0a-8acf-8c0f81dbfb8a");
Dictionary<short,object> resulteae2baebd143cc0a8acf8c0f81dbfb8a=iSpace.ExecuteQuery(querySourceeae2baebd143cc0a8acf8c0f81dbfb8a,@"EXEC [GetCalculatedEndDate] '" + ISpace["MF_d10_Duration"].Value + @"','" + ISpace["MF_d10_YearMonth"].Value + @"','" + ISpace["MF_d10_FromDate"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceeae2baebd143cc0a8acf8c0f81dbfb8a =GetQueryExpressionDataSource(""eae2baeb-d143-cc0a-8acf-8c0f81dbfb8a"");Dictionary<short,object> resulteae2baebd143cc0a8acf8c0f81dbfb8a=iSpace.ExecuteQuery(querySourceeae2baebd143cc0a8acf8c0f81dbfb8a,@""EXEC [GetCalculatedEndDate] '"" + ISpace[""MF_d10_Duration""].Value + @""','"" + ISpace[""MF_d10_YearMonth""].Value + @""','"" + ISpace[""MF_d10_FromDate""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resulteae2baebd143cc0a8acf8c0f81dbfb8a!=null) && (resulteae2baebd143cc0a8acf8c0f81dbfb8a.Count!=0))
{
if(resulteae2baebd143cc0a8acf8c0f81dbfb8a.ContainsKey(0))
ISpace["MF_d10_ToDate"].Value = resulteae2baebd143cc0a8acf8c0f81dbfb8a[0];
if(resulteae2baebd143cc0a8acf8c0f81dbfb8a.ContainsKey(0))
ISpace["MF_d10_ActualEndDate"].Value = resulteae2baebd143cc0a8acf8c0f81dbfb8a[0];
}
else{
ISpace["MF_d10_ToDate"].Value = null;ISpace["MF_d10_ActualEndDate"].Value = null;
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mf_d10_projectproposalid (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MF_d10_ProjectproposalID-OnChange");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC [GetProjectPropsalDetails] '#MF_d10_ProjectproposalID'");

var querySource9cc2bc31cc300ba34ad622f9e9abf5d5 =GetQueryExpressionDataSource("9cc2bc31-cc30-0ba3-4ad6-22f9e9abf5d5");
Dictionary<short,object> result9cc2bc31cc300ba34ad622f9e9abf5d5=iSpace.ExecuteQuery(querySource9cc2bc31cc300ba34ad622f9e9abf5d5,@"EXEC [GetProjectPropsalDetails] '" + ISpace["MF_d10_ProjectproposalID"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource9cc2bc31cc300ba34ad622f9e9abf5d5 =GetQueryExpressionDataSource(""9cc2bc31-cc30-0ba3-4ad6-22f9e9abf5d5"");Dictionary<short,object> result9cc2bc31cc300ba34ad622f9e9abf5d5=iSpace.ExecuteQuery(querySource9cc2bc31cc300ba34ad622f9e9abf5d5,@""EXEC [GetProjectPropsalDetails] '"" + ISpace[""MF_d10_ProjectproposalID""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result9cc2bc31cc300ba34ad622f9e9abf5d5!=null) && (result9cc2bc31cc300ba34ad622f9e9abf5d5.Count!=0))
{
if(result9cc2bc31cc300ba34ad622f9e9abf5d5.ContainsKey(2))
ISpace["MF_d10_ProjectCategoryID"].Value = result9cc2bc31cc300ba34ad622f9e9abf5d5[2];
if(result9cc2bc31cc300ba34ad622f9e9abf5d5.ContainsKey(6))
ISpace["MF_d10_FundingAgency"].Value = result9cc2bc31cc300ba34ad622f9e9abf5d5[6];
if(result9cc2bc31cc300ba34ad622f9e9abf5d5.ContainsKey(7))
ISpace["MF_d10_Sector"].Value = result9cc2bc31cc300ba34ad622f9e9abf5d5[7];
if(result9cc2bc31cc300ba34ad622f9e9abf5d5.ContainsKey(3))
ISpace["MF_d10_FinancialYearID"].Value = result9cc2bc31cc300ba34ad622f9e9abf5d5[3];
if(result9cc2bc31cc300ba34ad622f9e9abf5d5.ContainsKey(17))
ISpace["m_currency"].Value = result9cc2bc31cc300ba34ad622f9e9abf5d5[17];
if(result9cc2bc31cc300ba34ad622f9e9abf5d5.ContainsKey(13))
ISpace["MF_d10_ProjectType"].Value = result9cc2bc31cc300ba34ad622f9e9abf5d5[13];
if(result9cc2bc31cc300ba34ad622f9e9abf5d5.ContainsKey(21))
ISpace["MF_d10_IsExternalIns"].Value = result9cc2bc31cc300ba34ad622f9e9abf5d5[21];
if(result9cc2bc31cc300ba34ad622f9e9abf5d5.ContainsKey(9))
ISpace["MF_d10_ProjectBudget"].Value = result9cc2bc31cc300ba34ad622f9e9abf5d5[9];
if(result9cc2bc31cc300ba34ad622f9e9abf5d5.ContainsKey(8))
ISpace["MF_d10_ProjectName"].Value = result9cc2bc31cc300ba34ad622f9e9abf5d5[8];
}
else{
ISpace["MF_d10_ProjectCategoryID"].Value = null;ISpace["MF_d10_FundingAgency"].Value = null;ISpace["MF_d10_Sector"].Value = null;ISpace["MF_d10_FinancialYearID"].Value = null;ISpace["m_currency"].Value = null;ISpace["MF_d10_ProjectType"].Value = null;ISpace["MF_d10_IsExternalIns"].Value = null;ISpace["MF_d10_ProjectBudget"].Value = null;ISpace["MF_d10_ProjectName"].Value = null;
}

var querySource906fc07f3f3bc1be93f744636c228555 =GetQueryExpressionDataSource("906fc07f-3f3b-c1be-93f7-44636c228555");

DataTable result906fc07f3f3bc1be93f744636c228555=iSpace.SetGridDataSource(querySource906fc07f3f3bc1be93f744636c228555, _objectFactory.GetGridRPP("BudgetAllocation"),@"EXEC [GetProjectDetailCombo] 1,'" + ISpace["gv_instanceid"].Value + @"'");


base.WriteDebugInfo(@"var querySource906fc07f3f3bc1be93f744636c228555 =GetQueryExpressionDataSource(""906fc07f-3f3b-c1be-93f7-44636c228555"");DataTable result906fc07f3f3bc1be93f744636c228555=iSpace.SetGridDataSource(querySource906fc07f3f3bc1be93f744636c228555, _objectFactory.GetGridRPP(""BudgetAllocation""),@""EXEC [GetProjectDetailCombo] 1,'"" + ISpace[""gv_instanceid""].Value + @""'"");");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result0303e9a5833d0f47596240219e02283c=acdataIspaceDC6D256C5F944FE59309FD74A0FF257E.GetQueryExpressionBindings("0303e9a5-833d-0f47-5962-40219e02283c");
iSpace.SetGridData(result906fc07f3f3bc1be93f744636c228555,result0303e9a5833d0f47596240219e02283c,"BudgetAllocation",ref ISpace);
if (_elementBase != null)  iSpace.SetLoopExpressionData("BudgetAllocation","B73036BB-FE7D-4B0D-998A-985294F8FC5B",_objectFactory.GetGridRPP("BudgetAllocation"),_elementBase.GetGridLoopQuery("B73036BB-FE7D-4B0D-998A-985294F8FC5B","BudgetAllocation",true,ref ISpace), ref ISpace);

}
if(ISpace["MF_d10_ProjectType"].Value=="450")
{
base.WriteDebugInfo(@"if(ISpace[""MF_d10_ProjectType""].Value==""450"")");
ISpace["m_currency"].Visible="true";ISpace["m_currency"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""m_currency""].Visible=""true"";ISpace[""m_currency""].Enbl=""true"";");
}
if(ISpace["MF_d10_ProjectType"].Value=="449")
{
base.WriteDebugInfo(@"if(ISpace[""MF_d10_ProjectType""].Value==""449"")");
ISpace["m_currency"].Visible="false";ISpace["m_currency"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""m_currency""].Visible=""false"";ISpace[""m_currency""].Enbl=""false"";");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySource5b1d38940d729c8d3a5f8fe772ffa261 =GetQueryExpressionDataSource("5b1d3894-0d72-9c8d-3a5f-8fe772ffa261");

DataTable result5b1d38940d729c8d3a5f8fe772ffa261=iSpace.SetGridDataSource(querySource5b1d38940d729c8d3a5f8fe772ffa261, _objectFactory.GetGridRPP("ExternalCoPiGrid"),@"EXEC GetProjectCoPiDetails '" + ISpace["MF_d10_ProjectproposalID"].Value + @"'");


base.WriteDebugInfo(@"var querySource5b1d38940d729c8d3a5f8fe772ffa261 =GetQueryExpressionDataSource(""5b1d3894-0d72-9c8d-3a5f-8fe772ffa261"");DataTable result5b1d38940d729c8d3a5f8fe772ffa261=iSpace.SetGridDataSource(querySource5b1d38940d729c8d3a5f8fe772ffa261, _objectFactory.GetGridRPP(""ExternalCoPiGrid""),@""EXEC GetProjectCoPiDetails '"" + ISpace[""MF_d10_ProjectproposalID""].Value + @""'"");");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result22ae9f9ee9e879dd1f5e44b4433f5e5c=acdataIspaceDC6D256C5F944FE59309FD74A0FF257E.GetQueryExpressionBindings("22ae9f9e-e9e8-79dd-1f5e-44b4433f5e5c");
iSpace.SetGridData(result5b1d38940d729c8d3a5f8fe772ffa261,result22ae9f9ee9e879dd1f5e44b4433f5e5c,"ExternalCoPiGrid",ref ISpace);
if (_elementBase != null)  iSpace.SetLoopExpressionData("ExternalCoPiGrid","59259E21-AFE8-4DAB-A543-74CC22FC79D5",_objectFactory.GetGridRPP("ExternalCoPiGrid"),_elementBase.GetGridLoopQuery("59259E21-AFE8-4DAB-A543-74CC22FC79D5","ExternalCoPiGrid",true,ref ISpace), ref ISpace);

}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["MF_d10_ProjectStatus"].Value="7";
base.WriteDebugInfo(@"ISpace[""MF_d10_ProjectStatus""].Value=""7"";");
ISpace["MF_d10_ProjectDetailsID"].Value=ISpace["gv_instanceid"].Value;
base.WriteDebugInfo(@"ISpace[""MF_d10_ProjectDetailsID""].Value=ISpace[""gv_instanceid""].Value;");
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mg_d154_totalmonths (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MG_d154_TotalMonths-OnChange");
object MG_d154_TotalCost=iSpace.Sum("[25683F52-E21A-4CE3-9196-7BCFA640A94B]","MG_d154_TotalCost","",ISpace["gv_instanceid"].Value);
ISpace["MF_ManPowerTotal"].Value=Convert.ChangeType(MG_d154_TotalCost, MG_d154_TotalCost.GetType());;
base.WriteDebugInfo(@"object MG_d154_TotalCost=iSpace.Sum(""[25683F52-E21A-4CE3-9196-7BCFA640A94B]"",""MG_d154_TotalCost"","""",ISpace[""gv_instanceid""].Value);
ISpace[""MF_ManPowerTotal""].Value=Convert.ChangeType(MG_d154_TotalCost, MG_d154_TotalCost.GetType());;");

var querySource7c4d94f12381b2c2c38d941e8dba8928 =GetQueryExpressionDataSource("7c4d94f1-2381-b2c2-c38d-941e8dba8928");

DataTable result7c4d94f12381b2c2c38d941e8dba8928=iSpace.SetGridDataSource(querySource7c4d94f12381b2c2c38d941e8dba8928, _objectFactory.GetGridRPP("ManpowerGrid"),@"EXEC [GetGridData25683F52-E21A-4CE3-9196-7BCFA640A94B] '" + ISpace["gv_instanceid"].Value + @"'");


base.WriteDebugInfo(@"var querySource7c4d94f12381b2c2c38d941e8dba8928 =GetQueryExpressionDataSource(""7c4d94f1-2381-b2c2-c38d-941e8dba8928"");DataTable result7c4d94f12381b2c2c38d941e8dba8928=iSpace.SetGridDataSource(querySource7c4d94f12381b2c2c38d941e8dba8928, _objectFactory.GetGridRPP(""ManpowerGrid""),@""EXEC [GetGridData25683F52-E21A-4CE3-9196-7BCFA640A94B] '"" + ISpace[""gv_instanceid""].Value + @""'"");");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result2dff53097010e57f5c95f700983350be=acdataIspaceDC6D256C5F944FE59309FD74A0FF257E.GetQueryExpressionBindings("2dff5309-7010-e57f-5c95-f700983350be");
iSpace.SetGridData(result7c4d94f12381b2c2c38d941e8dba8928,result2dff53097010e57f5c95f700983350be,"ManpowerGrid",ref ISpace);
if (_elementBase != null)  iSpace.SetLoopExpressionData("ManpowerGrid","25683F52-E21A-4CE3-9196-7BCFA640A94B",_objectFactory.GetGridRPP("ManpowerGrid"),_elementBase.GetGridLoopQuery("25683F52-E21A-4CE3-9196-7BCFA640A94B","ManpowerGrid",true,ref ISpace), ref ISpace);

}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mg_d109_rateininr (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MG_d109_RateinINR-OnChange");
object MG_d109_TotalEquipmentcost=iSpace.Sum("[08F73C4A-3B94-4327-8859-B98388D1C9CD]","MG_d109_TotalEquipmentcost","",ISpace["gv_instanceid"].Value);
ISpace["MF_EquipmentTotal"].Value=Convert.ChangeType(MG_d109_TotalEquipmentcost, MG_d109_TotalEquipmentcost.GetType());;
base.WriteDebugInfo(@"object MG_d109_TotalEquipmentcost=iSpace.Sum(""[08F73C4A-3B94-4327-8859-B98388D1C9CD]"",""MG_d109_TotalEquipmentcost"","""",ISpace[""gv_instanceid""].Value);
ISpace[""MF_EquipmentTotal""].Value=Convert.ChangeType(MG_d109_TotalEquipmentcost, MG_d109_TotalEquipmentcost.GetType());;");

var querySource61e7d77340d395e92de5549773196e79 =GetQueryExpressionDataSource("61e7d773-40d3-95e9-2de5-549773196e79");

DataTable result61e7d77340d395e92de5549773196e79=iSpace.SetGridDataSource(querySource61e7d77340d395e92de5549773196e79, _objectFactory.GetGridRPP("EquipmentGrid"),@"EXEC [GetGridData08F73C4A-3B94-4327-8859-B98388D1C9CD] '" + ISpace["gv_instanceid"].Value + @"'");


base.WriteDebugInfo(@"var querySource61e7d77340d395e92de5549773196e79 =GetQueryExpressionDataSource(""61e7d773-40d3-95e9-2de5-549773196e79"");DataTable result61e7d77340d395e92de5549773196e79=iSpace.SetGridDataSource(querySource61e7d77340d395e92de5549773196e79, _objectFactory.GetGridRPP(""EquipmentGrid""),@""EXEC [GetGridData08F73C4A-3B94-4327-8859-B98388D1C9CD] '"" + ISpace[""gv_instanceid""].Value + @""'"");");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result83ae6bea5b86be67af2d86bd670877ef=acdataIspaceDC6D256C5F944FE59309FD74A0FF257E.GetQueryExpressionBindings("83ae6bea-5b86-be67-af2d-86bd670877ef");
iSpace.SetGridData(result61e7d77340d395e92de5549773196e79,result83ae6bea5b86be67af2d86bd670877ef,"EquipmentGrid",ref ISpace);
if (_elementBase != null)  iSpace.SetLoopExpressionData("EquipmentGrid","08F73C4A-3B94-4327-8859-B98388D1C9CD",_objectFactory.GetGridRPP("EquipmentGrid"),_elementBase.GetGridLoopQuery("08F73C4A-3B94-4327-8859-B98388D1C9CD","EquipmentGrid",true,ref ISpace), ref ISpace);

}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mg_d154_ratepermonth (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MG_d154_RatePerMonth-OnChange");
object MG_d154_TotalCost=iSpace.Sum("[25683F52-E21A-4CE3-9196-7BCFA640A94B]","MG_d154_TotalCost","",ISpace["gv_instanceid"].Value);
ISpace["MF_ManPowerTotal"].Value=Convert.ChangeType(MG_d154_TotalCost, MG_d154_TotalCost.GetType());;
base.WriteDebugInfo(@"object MG_d154_TotalCost=iSpace.Sum(""[25683F52-E21A-4CE3-9196-7BCFA640A94B]"",""MG_d154_TotalCost"","""",ISpace[""gv_instanceid""].Value);
ISpace[""MF_ManPowerTotal""].Value=Convert.ChangeType(MG_d154_TotalCost, MG_d154_TotalCost.GetType());;");

var querySource7c4d94f12381b2c2c38d941e8dba8928 =GetQueryExpressionDataSource("7c4d94f1-2381-b2c2-c38d-941e8dba8928");

DataTable result7c4d94f12381b2c2c38d941e8dba8928=iSpace.SetGridDataSource(querySource7c4d94f12381b2c2c38d941e8dba8928, _objectFactory.GetGridRPP("ManpowerGrid"),@"EXEC [GetGridData25683F52-E21A-4CE3-9196-7BCFA640A94B] '" + ISpace["gv_instanceid"].Value + @"'");


base.WriteDebugInfo(@"var querySource7c4d94f12381b2c2c38d941e8dba8928 =GetQueryExpressionDataSource(""7c4d94f1-2381-b2c2-c38d-941e8dba8928"");DataTable result7c4d94f12381b2c2c38d941e8dba8928=iSpace.SetGridDataSource(querySource7c4d94f12381b2c2c38d941e8dba8928, _objectFactory.GetGridRPP(""ManpowerGrid""),@""EXEC [GetGridData25683F52-E21A-4CE3-9196-7BCFA640A94B] '"" + ISpace[""gv_instanceid""].Value + @""'"");");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result2dff53097010e57f5c95f700983350be=acdataIspaceDC6D256C5F944FE59309FD74A0FF257E.GetQueryExpressionBindings("2dff5309-7010-e57f-5c95-f700983350be");
iSpace.SetGridData(result7c4d94f12381b2c2c38d941e8dba8928,result2dff53097010e57f5c95f700983350be,"ManpowerGrid",ref ISpace);
if (_elementBase != null)  iSpace.SetLoopExpressionData("ManpowerGrid","25683F52-E21A-4CE3-9196-7BCFA640A94B",_objectFactory.GetGridRPP("ManpowerGrid"),_elementBase.GetGridLoopQuery("25683F52-E21A-4CE3-9196-7BCFA640A94B","ManpowerGrid",true,ref ISpace), ref ISpace);

}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mg_d154_duration (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MG_d154_Duration-OnChange");
base.WriteDebugInfo(@"EXEC [GetCalculatedEndDate] '#MF_d10_Duration','#MF_d10_YearMonth','#MF_d10_FromDate'");

var querySourceeae2baebd143cc0a8acf8c0f81dbfb8a =GetQueryExpressionDataSource("eae2baeb-d143-cc0a-8acf-8c0f81dbfb8a");
Dictionary<short,object> resulteae2baebd143cc0a8acf8c0f81dbfb8a=iSpace.ExecuteQuery(querySourceeae2baebd143cc0a8acf8c0f81dbfb8a,@"EXEC [GetCalculatedEndDate] '" + ISpace["MF_d10_Duration"].Value + @"','" + ISpace["MF_d10_YearMonth"].Value + @"','" + ISpace["MF_d10_FromDate"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceeae2baebd143cc0a8acf8c0f81dbfb8a =GetQueryExpressionDataSource(""eae2baeb-d143-cc0a-8acf-8c0f81dbfb8a"");Dictionary<short,object> resulteae2baebd143cc0a8acf8c0f81dbfb8a=iSpace.ExecuteQuery(querySourceeae2baebd143cc0a8acf8c0f81dbfb8a,@""EXEC [GetCalculatedEndDate] '"" + ISpace[""MF_d10_Duration""].Value + @""','"" + ISpace[""MF_d10_YearMonth""].Value + @""','"" + ISpace[""MF_d10_FromDate""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resulteae2baebd143cc0a8acf8c0f81dbfb8a!=null) && (resulteae2baebd143cc0a8acf8c0f81dbfb8a.Count!=0))
{
if(resulteae2baebd143cc0a8acf8c0f81dbfb8a.ContainsKey(0))
ISpace["MF_d10_ToDate"].Value = resulteae2baebd143cc0a8acf8c0f81dbfb8a[0];
if(resulteae2baebd143cc0a8acf8c0f81dbfb8a.ContainsKey(0))
ISpace["MF_d10_ActualEndDate"].Value = resulteae2baebd143cc0a8acf8c0f81dbfb8a[0];
}
else{
ISpace["MF_d10_ToDate"].Value = null;ISpace["MF_d10_ActualEndDate"].Value = null;
}
object MG_d154_TotalCost=iSpace.Sum("[25683F52-E21A-4CE3-9196-7BCFA640A94B]","MG_d154_TotalCost","",ISpace["gv_instanceid"].Value);
ISpace["MF_ManPowerTotal"].Value=Convert.ChangeType(MG_d154_TotalCost, MG_d154_TotalCost.GetType());;
base.WriteDebugInfo(@"object MG_d154_TotalCost=iSpace.Sum(""[25683F52-E21A-4CE3-9196-7BCFA640A94B]"",""MG_d154_TotalCost"","""",ISpace[""gv_instanceid""].Value);
ISpace[""MF_ManPowerTotal""].Value=Convert.ChangeType(MG_d154_TotalCost, MG_d154_TotalCost.GetType());;");

var querySource7c4d94f12381b2c2c38d941e8dba8928 =GetQueryExpressionDataSource("7c4d94f1-2381-b2c2-c38d-941e8dba8928");

DataTable result7c4d94f12381b2c2c38d941e8dba8928=iSpace.SetGridDataSource(querySource7c4d94f12381b2c2c38d941e8dba8928, _objectFactory.GetGridRPP("ManpowerGrid"),@"EXEC [GetGridData25683F52-E21A-4CE3-9196-7BCFA640A94B] '" + ISpace["gv_instanceid"].Value + @"'");


base.WriteDebugInfo(@"var querySource7c4d94f12381b2c2c38d941e8dba8928 =GetQueryExpressionDataSource(""7c4d94f1-2381-b2c2-c38d-941e8dba8928"");DataTable result7c4d94f12381b2c2c38d941e8dba8928=iSpace.SetGridDataSource(querySource7c4d94f12381b2c2c38d941e8dba8928, _objectFactory.GetGridRPP(""ManpowerGrid""),@""EXEC [GetGridData25683F52-E21A-4CE3-9196-7BCFA640A94B] '"" + ISpace[""gv_instanceid""].Value + @""'"");");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result2dff53097010e57f5c95f700983350be=acdataIspaceDC6D256C5F944FE59309FD74A0FF257E.GetQueryExpressionBindings("2dff5309-7010-e57f-5c95-f700983350be");
iSpace.SetGridData(result7c4d94f12381b2c2c38d941e8dba8928,result2dff53097010e57f5c95f700983350be,"ManpowerGrid",ref ISpace);
if (_elementBase != null)  iSpace.SetLoopExpressionData("ManpowerGrid","25683F52-E21A-4CE3-9196-7BCFA640A94B",_objectFactory.GetGridRPP("ManpowerGrid"),_elementBase.GetGridLoopQuery("25683F52-E21A-4CE3-9196-7BCFA640A94B","ManpowerGrid",true,ref ISpace), ref ISpace);

}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mg_d109_quantity (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MG_d109_Quantity-OnChange");
object MG_d109_TotalEquipmentcost=iSpace.Sum("[08F73C4A-3B94-4327-8859-B98388D1C9CD]","MG_d109_TotalEquipmentcost","",ISpace["gv_instanceid"].Value);
ISpace["MF_EquipmentTotal"].Value=Convert.ChangeType(MG_d109_TotalEquipmentcost, MG_d109_TotalEquipmentcost.GetType());;
base.WriteDebugInfo(@"object MG_d109_TotalEquipmentcost=iSpace.Sum(""[08F73C4A-3B94-4327-8859-B98388D1C9CD]"",""MG_d109_TotalEquipmentcost"","""",ISpace[""gv_instanceid""].Value);
ISpace[""MF_EquipmentTotal""].Value=Convert.ChangeType(MG_d109_TotalEquipmentcost, MG_d109_TotalEquipmentcost.GetType());;");

var querySource61e7d77340d395e92de5549773196e79 =GetQueryExpressionDataSource("61e7d773-40d3-95e9-2de5-549773196e79");

DataTable result61e7d77340d395e92de5549773196e79=iSpace.SetGridDataSource(querySource61e7d77340d395e92de5549773196e79, _objectFactory.GetGridRPP("EquipmentGrid"),@"EXEC [GetGridData08F73C4A-3B94-4327-8859-B98388D1C9CD] '" + ISpace["gv_instanceid"].Value + @"'");


base.WriteDebugInfo(@"var querySource61e7d77340d395e92de5549773196e79 =GetQueryExpressionDataSource(""61e7d773-40d3-95e9-2de5-549773196e79"");DataTable result61e7d77340d395e92de5549773196e79=iSpace.SetGridDataSource(querySource61e7d77340d395e92de5549773196e79, _objectFactory.GetGridRPP(""EquipmentGrid""),@""EXEC [GetGridData08F73C4A-3B94-4327-8859-B98388D1C9CD] '"" + ISpace[""gv_instanceid""].Value + @""'"");");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result83ae6bea5b86be67af2d86bd670877ef=acdataIspaceDC6D256C5F944FE59309FD74A0FF257E.GetQueryExpressionBindings("83ae6bea-5b86-be67-af2d-86bd670877ef");
iSpace.SetGridData(result61e7d77340d395e92de5549773196e79,result83ae6bea5b86be67af2d86bd670877ef,"EquipmentGrid",ref ISpace);
if (_elementBase != null)  iSpace.SetLoopExpressionData("EquipmentGrid","08F73C4A-3B94-4327-8859-B98388D1C9CD",_objectFactory.GetGridRPP("EquipmentGrid"),_elementBase.GetGridLoopQuery("08F73C4A-3B94-4327-8859-B98388D1C9CD","EquipmentGrid",true,ref ISpace), ref ISpace);

}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mg_d28_budgetamount (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MG_d28_BudgetAmount-OnChange");
object MG_d28_BudgetAmount=iSpace.Sum("[B73036BB-FE7D-4B0D-998A-985294F8FC5B]","MG_d28_BudgetAmount","",ISpace["gv_instanceid"].Value);
ISpace["MF_d10_BudgetTotalAmount"].Value=Convert.ChangeType(MG_d28_BudgetAmount, MG_d28_BudgetAmount.GetType());;
base.WriteDebugInfo(@"object MG_d28_BudgetAmount=iSpace.Sum(""[B73036BB-FE7D-4B0D-998A-985294F8FC5B]"",""MG_d28_BudgetAmount"","""",ISpace[""gv_instanceid""].Value);
ISpace[""MF_d10_BudgetTotalAmount""].Value=Convert.ChangeType(MG_d28_BudgetAmount, MG_d28_BudgetAmount.GetType());;");
base.WriteDebugInfo(@"EXEC ProjectCreationBudgetCalculation '@@gv_InstanceId'");

var querySourcec3995c1b9f1af85fab715bef2a0b203e =GetQueryExpressionDataSource("c3995c1b-9f1a-f85f-ab71-5bef2a0b203e");
Dictionary<short,object> resultc3995c1b9f1af85fab715bef2a0b203e=iSpace.ExecuteQuery(querySourcec3995c1b9f1af85fab715bef2a0b203e,@"EXEC ProjectCreationBudgetCalculation '" + ISpace["gv_instanceid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourcec3995c1b9f1af85fab715bef2a0b203e =GetQueryExpressionDataSource(""c3995c1b-9f1a-f85f-ab71-5bef2a0b203e"");Dictionary<short,object> resultc3995c1b9f1af85fab715bef2a0b203e=iSpace.ExecuteQuery(querySourcec3995c1b9f1af85fab715bef2a0b203e,@""EXEC ProjectCreationBudgetCalculation '"" + ISpace[""gv_instanceid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultc3995c1b9f1af85fab715bef2a0b203e!=null) && (resultc3995c1b9f1af85fab715bef2a0b203e.Count!=0))
{
if(resultc3995c1b9f1af85fab715bef2a0b203e.ContainsKey(0))
ISpace["MF_d10_RecurringAmount"].Value = resultc3995c1b9f1af85fab715bef2a0b203e[0];
if(resultc3995c1b9f1af85fab715bef2a0b203e.ContainsKey(1))
ISpace["MF_d10_NonRecurringAmount"].Value = resultc3995c1b9f1af85fab715bef2a0b203e[1];
}
else{
ISpace["MF_d10_RecurringAmount"].Value = null;ISpace["MF_d10_NonRecurringAmount"].Value = null;
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_m_history (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"M_History-OnClick");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["UI_History"].ShowDialog=true;;
base.WriteDebugInfo(@"ISpace[""UI_History""].ShowDialog=true;;");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySource598a64be325b1665a4f0dc3818c98d36 =GetQueryExpressionDataSource("598a64be-325b-1665-a4f0-dc3818c98d36");

DataTable result598a64be325b1665a4f0dc3818c98d36=iSpace.SetGridDataSource(querySource598a64be325b1665a4f0dc3818c98d36, _objectFactory.GetGridRPP("MG_Comments"),@"EXEC [GetInstanceFlowDetais] '" + ISpace["gv_instanceid"].Value + @"'");


base.WriteDebugInfo(@"var querySource598a64be325b1665a4f0dc3818c98d36 =GetQueryExpressionDataSource(""598a64be-325b-1665-a4f0-dc3818c98d36"");DataTable result598a64be325b1665a4f0dc3818c98d36=iSpace.SetGridDataSource(querySource598a64be325b1665a4f0dc3818c98d36, _objectFactory.GetGridRPP(""MG_Comments""),@""EXEC [GetInstanceFlowDetais] '"" + ISpace[""gv_instanceid""].Value + @""'"");");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result89cce784320fd42d41c53fb5840cbc25=acdataIspaceDC6D256C5F944FE59309FD74A0FF257E.GetQueryExpressionBindings("89cce784-320f-d42d-41c5-3fb5840cbc25");
iSpace.SetGridData(result598a64be325b1665a4f0dc3818c98d36,result89cce784320fd42d41c53fb5840cbc25,"MG_Comments",ref ISpace);
if (_elementBase != null)  iSpace.SetLoopExpressionData("MG_Comments","f1825943-98b5-f54f-0225-0081ef436f94",_objectFactory.GetGridRPP("MG_Comments"),_elementBase.GetGridLoopQuery("f1825943-98b5-f54f-0225-0081ef436f94","MG_Comments",true,ref ISpace), ref ISpace);

}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mg_d154_hrapermonth (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MG_d154_HRAPerMonth-OnChange");
object MG_d154_TotalCost=iSpace.Sum("[25683F52-E21A-4CE3-9196-7BCFA640A94B]","MG_d154_TotalCost","",ISpace["gv_instanceid"].Value);
ISpace["MF_ManPowerTotal"].Value=Convert.ChangeType(MG_d154_TotalCost, MG_d154_TotalCost.GetType());;
base.WriteDebugInfo(@"object MG_d154_TotalCost=iSpace.Sum(""[25683F52-E21A-4CE3-9196-7BCFA640A94B]"",""MG_d154_TotalCost"","""",ISpace[""gv_instanceid""].Value);
ISpace[""MF_ManPowerTotal""].Value=Convert.ChangeType(MG_d154_TotalCost, MG_d154_TotalCost.GetType());;");

var querySource7c4d94f12381b2c2c38d941e8dba8928 =GetQueryExpressionDataSource("7c4d94f1-2381-b2c2-c38d-941e8dba8928");

DataTable result7c4d94f12381b2c2c38d941e8dba8928=iSpace.SetGridDataSource(querySource7c4d94f12381b2c2c38d941e8dba8928, _objectFactory.GetGridRPP("ManpowerGrid"),@"EXEC [GetGridData25683F52-E21A-4CE3-9196-7BCFA640A94B] '" + ISpace["gv_instanceid"].Value + @"'");


base.WriteDebugInfo(@"var querySource7c4d94f12381b2c2c38d941e8dba8928 =GetQueryExpressionDataSource(""7c4d94f1-2381-b2c2-c38d-941e8dba8928"");DataTable result7c4d94f12381b2c2c38d941e8dba8928=iSpace.SetGridDataSource(querySource7c4d94f12381b2c2c38d941e8dba8928, _objectFactory.GetGridRPP(""ManpowerGrid""),@""EXEC [GetGridData25683F52-E21A-4CE3-9196-7BCFA640A94B] '"" + ISpace[""gv_instanceid""].Value + @""'"");");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result2dff53097010e57f5c95f700983350be=acdataIspaceDC6D256C5F944FE59309FD74A0FF257E.GetQueryExpressionBindings("2dff5309-7010-e57f-5c95-f700983350be");
iSpace.SetGridData(result7c4d94f12381b2c2c38d941e8dba8928,result2dff53097010e57f5c95f700983350be,"ManpowerGrid",ref ISpace);
if (_elementBase != null)  iSpace.SetLoopExpressionData("ManpowerGrid","25683F52-E21A-4CE3-9196-7BCFA640A94B",_objectFactory.GetGridRPP("ManpowerGrid"),_elementBase.GetGridLoopQuery("25683F52-E21A-4CE3-9196-7BCFA640A94B","ManpowerGrid",true,ref ISpace), ref ISpace);

}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mg_d154_hrapercentage (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MG_d154_HRAPercentage-OnChange");
object MG_d154_TotalCost=iSpace.Sum("[25683F52-E21A-4CE3-9196-7BCFA640A94B]","MG_d154_TotalCost","",ISpace["gv_instanceid"].Value);
ISpace["MF_ManPowerTotal"].Value=Convert.ChangeType(MG_d154_TotalCost, MG_d154_TotalCost.GetType());;
base.WriteDebugInfo(@"object MG_d154_TotalCost=iSpace.Sum(""[25683F52-E21A-4CE3-9196-7BCFA640A94B]"",""MG_d154_TotalCost"","""",ISpace[""gv_instanceid""].Value);
ISpace[""MF_ManPowerTotal""].Value=Convert.ChangeType(MG_d154_TotalCost, MG_d154_TotalCost.GetType());;");

var querySource7c4d94f12381b2c2c38d941e8dba8928 =GetQueryExpressionDataSource("7c4d94f1-2381-b2c2-c38d-941e8dba8928");

DataTable result7c4d94f12381b2c2c38d941e8dba8928=iSpace.SetGridDataSource(querySource7c4d94f12381b2c2c38d941e8dba8928, _objectFactory.GetGridRPP("ManpowerGrid"),@"EXEC [GetGridData25683F52-E21A-4CE3-9196-7BCFA640A94B] '" + ISpace["gv_instanceid"].Value + @"'");


base.WriteDebugInfo(@"var querySource7c4d94f12381b2c2c38d941e8dba8928 =GetQueryExpressionDataSource(""7c4d94f1-2381-b2c2-c38d-941e8dba8928"");DataTable result7c4d94f12381b2c2c38d941e8dba8928=iSpace.SetGridDataSource(querySource7c4d94f12381b2c2c38d941e8dba8928, _objectFactory.GetGridRPP(""ManpowerGrid""),@""EXEC [GetGridData25683F52-E21A-4CE3-9196-7BCFA640A94B] '"" + ISpace[""gv_instanceid""].Value + @""'"");");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result2dff53097010e57f5c95f700983350be=acdataIspaceDC6D256C5F944FE59309FD74A0FF257E.GetQueryExpressionBindings("2dff5309-7010-e57f-5c95-f700983350be");
iSpace.SetGridData(result7c4d94f12381b2c2c38d941e8dba8928,result2dff53097010e57f5c95f700983350be,"ManpowerGrid",ref ISpace);
if (_elementBase != null)  iSpace.SetLoopExpressionData("ManpowerGrid","25683F52-E21A-4CE3-9196-7BCFA640A94B",_objectFactory.GetGridRPP("ManpowerGrid"),_elementBase.GetGridLoopQuery("25683F52-E21A-4CE3-9196-7BCFA640A94B","ManpowerGrid",true,ref ISpace), ref ISpace);

}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mg_d154_no_ofmanpowerposition (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MG_d154_No_OfManpowerPosition-OnChange");
object MG_d154_TotalCost=iSpace.Sum("[25683F52-E21A-4CE3-9196-7BCFA640A94B]","MG_d154_TotalCost","",ISpace["gv_instanceid"].Value);
ISpace["MF_ManPowerTotal"].Value=Convert.ChangeType(MG_d154_TotalCost, MG_d154_TotalCost.GetType());;
base.WriteDebugInfo(@"object MG_d154_TotalCost=iSpace.Sum(""[25683F52-E21A-4CE3-9196-7BCFA640A94B]"",""MG_d154_TotalCost"","""",ISpace[""gv_instanceid""].Value);
ISpace[""MF_ManPowerTotal""].Value=Convert.ChangeType(MG_d154_TotalCost, MG_d154_TotalCost.GetType());;");

var querySource7c4d94f12381b2c2c38d941e8dba8928 =GetQueryExpressionDataSource("7c4d94f1-2381-b2c2-c38d-941e8dba8928");

DataTable result7c4d94f12381b2c2c38d941e8dba8928=iSpace.SetGridDataSource(querySource7c4d94f12381b2c2c38d941e8dba8928, _objectFactory.GetGridRPP("ManpowerGrid"),@"EXEC [GetGridData25683F52-E21A-4CE3-9196-7BCFA640A94B] '" + ISpace["gv_instanceid"].Value + @"'");


base.WriteDebugInfo(@"var querySource7c4d94f12381b2c2c38d941e8dba8928 =GetQueryExpressionDataSource(""7c4d94f1-2381-b2c2-c38d-941e8dba8928"");DataTable result7c4d94f12381b2c2c38d941e8dba8928=iSpace.SetGridDataSource(querySource7c4d94f12381b2c2c38d941e8dba8928, _objectFactory.GetGridRPP(""ManpowerGrid""),@""EXEC [GetGridData25683F52-E21A-4CE3-9196-7BCFA640A94B] '"" + ISpace[""gv_instanceid""].Value + @""'"");");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result2dff53097010e57f5c95f700983350be=acdataIspaceDC6D256C5F944FE59309FD74A0FF257E.GetQueryExpressionBindings("2dff5309-7010-e57f-5c95-f700983350be");
iSpace.SetGridData(result7c4d94f12381b2c2c38d941e8dba8928,result2dff53097010e57f5c95f700983350be,"ManpowerGrid",ref ISpace);
if (_elementBase != null)  iSpace.SetLoopExpressionData("ManpowerGrid","25683F52-E21A-4CE3-9196-7BCFA640A94B",_objectFactory.GetGridRPP("ManpowerGrid"),_elementBase.GetGridLoopQuery("25683F52-E21A-4CE3-9196-7BCFA640A94B","ManpowerGrid",true,ref ISpace), ref ISpace);

}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mf_d10_duration (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MF_d10_Duration-OnChange");
base.WriteDebugInfo(@"EXEC [GetCalculatedEndDate] '#MF_d10_Duration','#MF_d10_YearMonth','#MF_d10_FromDate'");

var querySourceeae2baebd143cc0a8acf8c0f81dbfb8a =GetQueryExpressionDataSource("eae2baeb-d143-cc0a-8acf-8c0f81dbfb8a");
Dictionary<short,object> resulteae2baebd143cc0a8acf8c0f81dbfb8a=iSpace.ExecuteQuery(querySourceeae2baebd143cc0a8acf8c0f81dbfb8a,@"EXEC [GetCalculatedEndDate] '" + ISpace["MF_d10_Duration"].Value + @"','" + ISpace["MF_d10_YearMonth"].Value + @"','" + ISpace["MF_d10_FromDate"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceeae2baebd143cc0a8acf8c0f81dbfb8a =GetQueryExpressionDataSource(""eae2baeb-d143-cc0a-8acf-8c0f81dbfb8a"");Dictionary<short,object> resulteae2baebd143cc0a8acf8c0f81dbfb8a=iSpace.ExecuteQuery(querySourceeae2baebd143cc0a8acf8c0f81dbfb8a,@""EXEC [GetCalculatedEndDate] '"" + ISpace[""MF_d10_Duration""].Value + @""','"" + ISpace[""MF_d10_YearMonth""].Value + @""','"" + ISpace[""MF_d10_FromDate""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resulteae2baebd143cc0a8acf8c0f81dbfb8a!=null) && (resulteae2baebd143cc0a8acf8c0f81dbfb8a.Count!=0))
{
if(resulteae2baebd143cc0a8acf8c0f81dbfb8a.ContainsKey(0))
ISpace["MF_d10_ToDate"].Value = resulteae2baebd143cc0a8acf8c0f81dbfb8a[0];
if(resulteae2baebd143cc0a8acf8c0f81dbfb8a.ContainsKey(0))
ISpace["MF_d10_ActualEndDate"].Value = resulteae2baebd143cc0a8acf8c0f81dbfb8a[0];
}
else{
ISpace["MF_d10_ToDate"].Value = null;ISpace["MF_d10_ActualEndDate"].Value = null;
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
if(ISpace["M_MoveTo"].Value=="APPROVE")
{
base.WriteDebugInfo(@"if(ISpace[""M_MoveTo""].Value==""APPROVE"")");
ISpace["MF_d10_ProjectStatus"].Value="7";
base.WriteDebugInfo(@"ISpace[""MF_d10_ProjectStatus""].Value=""7"";");
}
if(ISpace["M_MoveTo"].Value=="REJECT")
{
base.WriteDebugInfo(@"if(ISpace[""M_MoveTo""].Value==""REJECT"")");
ISpace["MF_d10_ProjectStatus"].Value="32";
base.WriteDebugInfo(@"ISpace[""MF_d10_ProjectStatus""].Value=""32"";");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["M_FlowType"].Value="";
base.WriteDebugInfo(@"ISpace[""M_FlowType""].Value="""";");
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
ISpace["MF_d10_ProjectName"].Value=Trim(ISpace["MF_d10_ProjectName"].Value);
base.WriteDebugInfo(@"ISpace[""MF_d10_ProjectName""].Value=Trim(ISpace[""MF_d10_ProjectName""].Value);");
if(ISpace["MF_d10_FinancialYearID"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""MF_d10_FinancialYearID""].Value=="""")");
ISpace["Message"].Value=@"Error:Please Select Financial Year";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Error:Please Select Financial Year"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if(ISpace["MF_d10_FundingAgency"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""MF_d10_FundingAgency""].Value=="""")");
ISpace["Message"].Value=@"ERROR:Please Enter Funding Agency Name";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""ERROR:Please Enter Funding Agency Name"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if(ISpace["MF_d10_ProjectCategoryID"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""MF_d10_ProjectCategoryID""].Value=="""")");
ISpace["Message"].Value=@"Error: Please  Select Project Category";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Error: Please  Select Project Category"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if(ISpace["MF_d10_ProjectName"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""MF_d10_ProjectName""].Value=="""")");
ISpace["Message"].Value=@"ERROR:Please Enter Project Name";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""ERROR:Please Enter Project Name"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if(ISpace["MF_d10_SanctionedNumber"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""MF_d10_SanctionedNumber""].Value=="""")");
ISpace["Message"].Value=@"ERROR:Please Enter Sanctioned Number";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""ERROR:Please Enter Sanctioned Number"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if((ISpace["MF_d10_SanctionedDate"].Value == null))
{
base.WriteDebugInfo(@"if((ISpace[""MF_d10_SanctionedDate""].Value == null))");
ISpace["Message"].Value=@"Error:Please Select Sanctioned Date";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Error:Please Select Sanctioned Date"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if(ISpace["MF_d10_ProjectType"].Value=="450")
{
base.WriteDebugInfo(@"if(ISpace[""MF_d10_ProjectType""].Value==""450"")");
if(ISpace["m_currency"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""m_currency""].Value=="""")");
ISpace["Message"].Value=@"Error:Please Select Currency";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Error:Please Select Currency"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
}
if(ISpace["MF_d10_Duration"].Value==0)
{
base.WriteDebugInfo(@"if(ISpace[""MF_d10_Duration""].Value==0)");
ISpace["Message"].Value=@"Error:Please Enter Duration";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Error:Please Enter Duration"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if(ISpace["MF_d10_YearMonth"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""MF_d10_YearMonth""].Value=="""")");
ISpace["Message"].Value=@"Error:Please Select Month/ Year";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Error:Please Select Month/ Year"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if(ISpace["MF_d10_Sector"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""MF_d10_Sector""].Value=="""")");
ISpace["Message"].Value=@"Error:Please Select Sector";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Error:Please Select Sector"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if(ISpace["MF_d10_ProjectBudget"].Value==0)
{
base.WriteDebugInfo(@"if(ISpace[""MF_d10_ProjectBudget""].Value==0)");
ISpace["Message"].Value=@"Error:Please Enter Project Budget";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Error:Please Enter Project Budget"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if(ISpace["MF_d10_BudgetTotalAmount"].Value!=ISpace["MF_d10_ProjectBudget"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_d10_BudgetTotalAmount""].Value!=ISpace[""MF_d10_ProjectBudget""].Value)");
ISpace["Message"].Value=@"Error:Total Amount Should be Equal to Project Budget";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Error:Total Amount Should be Equal to Project Budget"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC [ValidateProjectBudgetMPEQValidation] '@@gv_InstanceId','#MF_ManPowerTotal','#MF_EquipmentTotal'");

var querySource502df243ca8b5455c370be23ac6857ac =GetQueryExpressionDataSource("502df243-ca8b-5455-c370-be23ac6857ac");
Dictionary<short,object> result502df243ca8b5455c370be23ac6857ac=iSpace.ExecuteQuery(querySource502df243ca8b5455c370be23ac6857ac,@"EXEC [ValidateProjectBudgetMPEQValidation] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["MF_ManPowerTotal"].Value + @"','" + ISpace["MF_EquipmentTotal"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource502df243ca8b5455c370be23ac6857ac =GetQueryExpressionDataSource(""502df243-ca8b-5455-c370-be23ac6857ac"");Dictionary<short,object> result502df243ca8b5455c370be23ac6857ac=iSpace.ExecuteQuery(querySource502df243ca8b5455c370be23ac6857ac,@""EXEC [ValidateProjectBudgetMPEQValidation] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""MF_ManPowerTotal""].Value + @""','"" + ISpace[""MF_EquipmentTotal""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result502df243ca8b5455c370be23ac6857ac!=null) && (result502df243ca8b5455c370be23ac6857ac.Count!=0))
{
if(result502df243ca8b5455c370be23ac6857ac.ContainsKey(0))
ISpace["ErrId"].Value = result502df243ca8b5455c370be23ac6857ac[0];
if(result502df243ca8b5455c370be23ac6857ac.ContainsKey(1))
ISpace["ErrMsg"].Value = result502df243ca8b5455c370be23ac6857ac[1];
}
else{
ISpace["ErrId"].Value = null;ISpace["ErrMsg"].Value = null;
}
}
if(ISpace["ErrId"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""ErrId""].Value==1)");
ISpace["ErrId"].Value=0;
base.WriteDebugInfo(@"ISpace[""ErrId""].Value=0;");
ISpace["Message"].Value=String.Format(@"{0}",ISpace["ErrMsg"].Value);
base.WriteDebugInfo(@"ISpace[""Message""].Value=String.Format(@""{0}"",ISpace[""ErrMsg""].Value);");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if(ISpace["MF_d10_ProjectRefNo"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""MF_d10_ProjectRefNo""].Value=="""")");
base.WriteDebugInfo(@"EXEC [GenerateTemproryProjectCode] '#MF_d10_EmployeeCode','#MF_d10_EmpDeptCode','@@gv_InstanceId','#MF_d10_ProjectCategoryID'");

var querySource022d541eff48f7a6f4a9bbfb60447b55 =GetQueryExpressionDataSource("022d541e-ff48-f7a6-f4a9-bbfb60447b55");
Dictionary<short,object> result022d541eff48f7a6f4a9bbfb60447b55=iSpace.ExecuteQuery(querySource022d541eff48f7a6f4a9bbfb60447b55,@"EXEC [GenerateTemproryProjectCode] '" + ISpace["MF_d10_EmployeeCode"].Value + @"','" + ISpace["MF_d10_EmpDeptCode"].Value + @"','" + ISpace["gv_instanceid"].Value + @"','" + ISpace["MF_d10_ProjectCategoryID"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource022d541eff48f7a6f4a9bbfb60447b55 =GetQueryExpressionDataSource(""022d541e-ff48-f7a6-f4a9-bbfb60447b55"");Dictionary<short,object> result022d541eff48f7a6f4a9bbfb60447b55=iSpace.ExecuteQuery(querySource022d541eff48f7a6f4a9bbfb60447b55,@""EXEC [GenerateTemproryProjectCode] '"" + ISpace[""MF_d10_EmployeeCode""].Value + @""','"" + ISpace[""MF_d10_EmpDeptCode""].Value + @""','"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""MF_d10_ProjectCategoryID""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result022d541eff48f7a6f4a9bbfb60447b55!=null) && (result022d541eff48f7a6f4a9bbfb60447b55.Count!=0))
{
if(result022d541eff48f7a6f4a9bbfb60447b55.ContainsKey(0))
ISpace["MF_d10_ProjectRefNo"].Value = result022d541eff48f7a6f4a9bbfb60447b55[0];
}
else{
ISpace["MF_d10_ProjectRefNo"].Value = null;
}
}
ISpace["Subject"].Value=ISpace["MF_d10_ProjectRefNo"].Value;
base.WriteDebugInfo(@"ISpace[""Subject""].Value=ISpace[""MF_d10_ProjectRefNo""].Value;");
base.WriteDebugInfo(@"EXEC InnovaceNoCode..[FormSave_7F2113FD-876A-41F4-BEAC-881CA7D38469] '@@gv_InstanceId','@@gv_ActivityMapId','b92107f7-28a5-49d0-8b7f-312c4826dd60','#MF_d10_FinancialYearID','#MF_d10_ProjectName',#MF_d10_Duration,#MF_d10_IfManpower,#MF_d10_IfEquipment,#MF_d10_IsExternalIns,'#MF_d10_FundReceiptMode','#MF_d10_PrincipalInvestigator','#MF_d10_ProjectproposalID','#MF_d10_SanctionedNumber','#MF_d10_DepartmentID','#MF_d10_SchemeID','#MF_d10_FundingAgency','#MF_d10_YearMonth','#MF_d10_ProjectStatus','#MF_d10_Designation','#MF_d10_ProjectCategoryID',#MF_d10_IsSubmitted,'#MF_d10_SanctionedDate','#MF_d10_FromDate','#MF_d10_ToDate',#MF_d10_ProjectBudget,'#MF_d10_ProjectType','#MF_d10_Sector','#MF_d10_ProjectDetailsID','#MF_d10_InstanceId','#MF_d10_ProjectCode','#MF_d10_ProjectRefNo','#MF_d10_EmployeeBasicInfoId','#MF_d10_ActualDate','#MF_d10_ActualEndDate',#MF_d10_NonRecurringAmount,#MF_d10_RecurringAmount,#MF_d10_IfExtended,'#MF_d10_ExtendedDate',#MF_d10_BudgetTotalAmount,#MF_d10_Overhead,#MF_d10_ExchangeRate,'#MF_d10_DocumentComments',#MF_d19_OverallAmount,#MF_d145_OverallTotalCost,'@@gv_UserId'");

var querySource4537606388E046C881D304F87FA722B3 =GetQueryExpressionDataSource("45376063-88E0-46C8-81D3-04F87FA722B3");
Dictionary<short,object> result4537606388E046C881D304F87FA722B3=iSpace.ExecuteQuery(querySource4537606388E046C881D304F87FA722B3,@"EXEC InnovaceNoCode..[FormSave_7F2113FD-876A-41F4-BEAC-881CA7D38469] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','b92107f7-28a5-49d0-8b7f-312c4826dd60','" + ISpace["MF_d10_FinancialYearID"].Value + @"','" + ISpace["MF_d10_ProjectName"].Value + @"'," + ISpace["MF_d10_Duration"].Value + @"," + ISpace["MF_d10_IfManpower"].Value + @"," + ISpace["MF_d10_IfEquipment"].Value + @"," + ISpace["MF_d10_IsExternalIns"].Value + @",'" + ISpace["MF_d10_FundReceiptMode"].Value + @"','" + ISpace["MF_d10_PrincipalInvestigator"].Value + @"','" + ISpace["MF_d10_ProjectproposalID"].Value + @"','" + ISpace["MF_d10_SanctionedNumber"].Value + @"','" + ISpace["MF_d10_DepartmentID"].Value + @"','" + ISpace["MF_d10_SchemeID"].Value + @"','" + ISpace["MF_d10_FundingAgency"].Value + @"','" + ISpace["MF_d10_YearMonth"].Value + @"','" + ISpace["MF_d10_ProjectStatus"].Value + @"','" + ISpace["MF_d10_Designation"].Value + @"','" + ISpace["MF_d10_ProjectCategoryID"].Value + @"'," + ISpace["MF_d10_IsSubmitted"].Value + @",'" + ISpace["MF_d10_SanctionedDate"].Value + @"','" + ISpace["MF_d10_FromDate"].Value + @"','" + ISpace["MF_d10_ToDate"].Value + @"'," + ISpace["MF_d10_ProjectBudget"].Value + @",'" + ISpace["MF_d10_ProjectType"].Value + @"','" + ISpace["MF_d10_Sector"].Value + @"','" + ISpace["MF_d10_ProjectDetailsID"].Value + @"','" + ISpace["MF_d10_InstanceId"].Value + @"','" + ISpace["MF_d10_ProjectCode"].Value + @"','" + ISpace["MF_d10_ProjectRefNo"].Value + @"','" + ISpace["MF_d10_EmployeeBasicInfoId"].Value + @"','" + ISpace["MF_d10_ActualDate"].Value + @"','" + ISpace["MF_d10_ActualEndDate"].Value + @"'," + ISpace["MF_d10_NonRecurringAmount"].Value + @"," + ISpace["MF_d10_RecurringAmount"].Value + @"," + ISpace["MF_d10_IfExtended"].Value + @",'" + ISpace["MF_d10_ExtendedDate"].Value + @"'," + ISpace["MF_d10_BudgetTotalAmount"].Value + @"," + ISpace["MF_d10_Overhead"].Value + @"," + ISpace["MF_d10_ExchangeRate"].Value + @",'" + ISpace["MF_d10_DocumentComments"].Value + @"'," + ISpace["MF_d19_OverallAmount"].Value + @"," + ISpace["MF_d145_OverallTotalCost"].Value + @",'" + ISpace["gv_userid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource4537606388E046C881D304F87FA722B3 =GetQueryExpressionDataSource(""45376063-88E0-46C8-81D3-04F87FA722B3"");Dictionary<short,object> result4537606388E046C881D304F87FA722B3=iSpace.ExecuteQuery(querySource4537606388E046C881D304F87FA722B3,@""EXEC InnovaceNoCode..[FormSave_7F2113FD-876A-41F4-BEAC-881CA7D38469] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','b92107f7-28a5-49d0-8b7f-312c4826dd60','"" + ISpace[""MF_d10_FinancialYearID""].Value + @""','"" + ISpace[""MF_d10_ProjectName""].Value + @""',"" + ISpace[""MF_d10_Duration""].Value + @"","" + ISpace[""MF_d10_IfManpower""].Value + @"","" + ISpace[""MF_d10_IfEquipment""].Value + @"","" + ISpace[""MF_d10_IsExternalIns""].Value + @"",'"" + ISpace[""MF_d10_FundReceiptMode""].Value + @""','"" + ISpace[""MF_d10_PrincipalInvestigator""].Value + @""','"" + ISpace[""MF_d10_ProjectproposalID""].Value + @""','"" + ISpace[""MF_d10_SanctionedNumber""].Value + @""','"" + ISpace[""MF_d10_DepartmentID""].Value + @""','"" + ISpace[""MF_d10_SchemeID""].Value + @""','"" + ISpace[""MF_d10_FundingAgency""].Value + @""','"" + ISpace[""MF_d10_YearMonth""].Value + @""','"" + ISpace[""MF_d10_ProjectStatus""].Value + @""','"" + ISpace[""MF_d10_Designation""].Value + @""','"" + ISpace[""MF_d10_ProjectCategoryID""].Value + @""',"" + ISpace[""MF_d10_IsSubmitted""].Value + @"",'"" + ISpace[""MF_d10_SanctionedDate""].Value + @""','"" + ISpace[""MF_d10_FromDate""].Value + @""','"" + ISpace[""MF_d10_ToDate""].Value + @""',"" + ISpace[""MF_d10_ProjectBudget""].Value + @"",'"" + ISpace[""MF_d10_ProjectType""].Value + @""','"" + ISpace[""MF_d10_Sector""].Value + @""','"" + ISpace[""MF_d10_ProjectDetailsID""].Value + @""','"" + ISpace[""MF_d10_InstanceId""].Value + @""','"" + ISpace[""MF_d10_ProjectCode""].Value + @""','"" + ISpace[""MF_d10_ProjectRefNo""].Value + @""','"" + ISpace[""MF_d10_EmployeeBasicInfoId""].Value + @""','"" + ISpace[""MF_d10_ActualDate""].Value + @""','"" + ISpace[""MF_d10_ActualEndDate""].Value + @""',"" + ISpace[""MF_d10_NonRecurringAmount""].Value + @"","" + ISpace[""MF_d10_RecurringAmount""].Value + @"","" + ISpace[""MF_d10_IfExtended""].Value + @"",'"" + ISpace[""MF_d10_ExtendedDate""].Value + @""',"" + ISpace[""MF_d10_BudgetTotalAmount""].Value + @"","" + ISpace[""MF_d10_Overhead""].Value + @"","" + ISpace[""MF_d10_ExchangeRate""].Value + @"",'"" + ISpace[""MF_d10_DocumentComments""].Value + @""',"" + ISpace[""MF_d19_OverallAmount""].Value + @"","" + ISpace[""MF_d145_OverallTotalCost""].Value + @"",'"" + ISpace[""gv_userid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result4537606388E046C881D304F87FA722B3!=null) && (result4537606388E046C881D304F87FA722B3.Count!=0))
{
if(result4537606388E046C881D304F87FA722B3.ContainsKey(0))
ISpace["ExecutionMessage"].Value = result4537606388E046C881D304F87FA722B3[0];
}
else{
ISpace["ExecutionMessage"].Value = null;
}
base.WriteDebugInfo(@"EXEC InnovaceNoCode..[GridSave_6677BAB3-659A-4A96-9067-5D365F60CB62]   '@@gv_InstanceId','@@gv_ActivityMapId','6677BAB3-659A-4A96-9067-5D365F60CB62'");

var querySourceA74347A4C3F242078D0D320D67D9EB3D =GetQueryExpressionDataSource("A74347A4-C3F2-4207-8D0D-320D67D9EB3D");
Dictionary<short,object> resultA74347A4C3F242078D0D320D67D9EB3D=iSpace.ExecuteQuery(querySourceA74347A4C3F242078D0D320D67D9EB3D,@"EXEC InnovaceNoCode..[GridSave_6677BAB3-659A-4A96-9067-5D365F60CB62]   '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','6677BAB3-659A-4A96-9067-5D365F60CB62'",false);

base.WriteDebugInfo(@"var querySourceA74347A4C3F242078D0D320D67D9EB3D =GetQueryExpressionDataSource(""A74347A4-C3F2-4207-8D0D-320D67D9EB3D"");Dictionary<short,object> resultA74347A4C3F242078D0D320D67D9EB3D=iSpace.ExecuteQuery(querySourceA74347A4C3F242078D0D320D67D9EB3D,@""EXEC InnovaceNoCode..[GridSave_6677BAB3-659A-4A96-9067-5D365F60CB62]   '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','6677BAB3-659A-4A96-9067-5D365F60CB62'"",false);");
base.WriteDebugInfo(@"");

if((resultA74347A4C3F242078D0D320D67D9EB3D!=null) && (resultA74347A4C3F242078D0D320D67D9EB3D.Count!=0))
{
if(resultA74347A4C3F242078D0D320D67D9EB3D.ContainsKey(0))
ISpace["ExecutionMessage"].Value = resultA74347A4C3F242078D0D320D67D9EB3D[0];
}
else{
ISpace["ExecutionMessage"].Value = null;
}
base.WriteDebugInfo(@"EXEC InnovaceNoCode..[GridSave_08F73C4A-3B94-4327-8859-B98388D1C9CD]   '@@gv_InstanceId','@@gv_ActivityMapId','08F73C4A-3B94-4327-8859-B98388D1C9CD'");

var querySource430846EA3E4949098632AC7C0F753F81 =GetQueryExpressionDataSource("430846EA-3E49-4909-8632-AC7C0F753F81");
Dictionary<short,object> result430846EA3E4949098632AC7C0F753F81=iSpace.ExecuteQuery(querySource430846EA3E4949098632AC7C0F753F81,@"EXEC InnovaceNoCode..[GridSave_08F73C4A-3B94-4327-8859-B98388D1C9CD]   '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','08F73C4A-3B94-4327-8859-B98388D1C9CD'",false);

base.WriteDebugInfo(@"var querySource430846EA3E4949098632AC7C0F753F81 =GetQueryExpressionDataSource(""430846EA-3E49-4909-8632-AC7C0F753F81"");Dictionary<short,object> result430846EA3E4949098632AC7C0F753F81=iSpace.ExecuteQuery(querySource430846EA3E4949098632AC7C0F753F81,@""EXEC InnovaceNoCode..[GridSave_08F73C4A-3B94-4327-8859-B98388D1C9CD]   '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','08F73C4A-3B94-4327-8859-B98388D1C9CD'"",false);");
base.WriteDebugInfo(@"");

if((result430846EA3E4949098632AC7C0F753F81!=null) && (result430846EA3E4949098632AC7C0F753F81.Count!=0))
{
if(result430846EA3E4949098632AC7C0F753F81.ContainsKey(0))
ISpace["ExecutionMessage"].Value = result430846EA3E4949098632AC7C0F753F81[0];
}
else{
ISpace["ExecutionMessage"].Value = null;
}
base.WriteDebugInfo(@"EXEC InnovaceNoCode..[GridSave_B73036BB-FE7D-4B0D-998A-985294F8FC5B]   '@@gv_InstanceId','@@gv_ActivityMapId','B73036BB-FE7D-4B0D-998A-985294F8FC5B'");

var querySourceA5343EC8F5DC490FA308848B457A1F27 =GetQueryExpressionDataSource("A5343EC8-F5DC-490F-A308-848B457A1F27");
Dictionary<short,object> resultA5343EC8F5DC490FA308848B457A1F27=iSpace.ExecuteQuery(querySourceA5343EC8F5DC490FA308848B457A1F27,@"EXEC InnovaceNoCode..[GridSave_B73036BB-FE7D-4B0D-998A-985294F8FC5B]   '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','B73036BB-FE7D-4B0D-998A-985294F8FC5B'",false);

base.WriteDebugInfo(@"var querySourceA5343EC8F5DC490FA308848B457A1F27 =GetQueryExpressionDataSource(""A5343EC8-F5DC-490F-A308-848B457A1F27"");Dictionary<short,object> resultA5343EC8F5DC490FA308848B457A1F27=iSpace.ExecuteQuery(querySourceA5343EC8F5DC490FA308848B457A1F27,@""EXEC InnovaceNoCode..[GridSave_B73036BB-FE7D-4B0D-998A-985294F8FC5B]   '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','B73036BB-FE7D-4B0D-998A-985294F8FC5B'"",false);");
base.WriteDebugInfo(@"");

if((resultA5343EC8F5DC490FA308848B457A1F27!=null) && (resultA5343EC8F5DC490FA308848B457A1F27.Count!=0))
{
if(resultA5343EC8F5DC490FA308848B457A1F27.ContainsKey(0))
ISpace["ExecutionMessage"].Value = resultA5343EC8F5DC490FA308848B457A1F27[0];
}
else{
ISpace["ExecutionMessage"].Value = null;
}
base.WriteDebugInfo(@"EXEC InnovaceNoCode..[GridSave_25683F52-E21A-4CE3-9196-7BCFA640A94B]   '@@gv_InstanceId','@@gv_ActivityMapId','25683F52-E21A-4CE3-9196-7BCFA640A94B'");

var querySource3E77697F9C9B4F7086A4EEAF4AAF6937 =GetQueryExpressionDataSource("3E77697F-9C9B-4F70-86A4-EEAF4AAF6937");
Dictionary<short,object> result3E77697F9C9B4F7086A4EEAF4AAF6937=iSpace.ExecuteQuery(querySource3E77697F9C9B4F7086A4EEAF4AAF6937,@"EXEC InnovaceNoCode..[GridSave_25683F52-E21A-4CE3-9196-7BCFA640A94B]   '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','25683F52-E21A-4CE3-9196-7BCFA640A94B'",false);

base.WriteDebugInfo(@"var querySource3E77697F9C9B4F7086A4EEAF4AAF6937 =GetQueryExpressionDataSource(""3E77697F-9C9B-4F70-86A4-EEAF4AAF6937"");Dictionary<short,object> result3E77697F9C9B4F7086A4EEAF4AAF6937=iSpace.ExecuteQuery(querySource3E77697F9C9B4F7086A4EEAF4AAF6937,@""EXEC InnovaceNoCode..[GridSave_25683F52-E21A-4CE3-9196-7BCFA640A94B]   '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','25683F52-E21A-4CE3-9196-7BCFA640A94B'"",false);");
base.WriteDebugInfo(@"");

if((result3E77697F9C9B4F7086A4EEAF4AAF6937!=null) && (result3E77697F9C9B4F7086A4EEAF4AAF6937.Count!=0))
{
if(result3E77697F9C9B4F7086A4EEAF4AAF6937.ContainsKey(0))
ISpace["ExecutionMessage"].Value = result3E77697F9C9B4F7086A4EEAF4AAF6937[0];
}
else{
ISpace["ExecutionMessage"].Value = null;
}
ISpace["Message"].Value=@"Success:Submitted Successfully";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Success:Submitted Successfully"";");
if(ISpace["M_MoveTo"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""M_MoveTo""].Value=="""")");
ISpace["Message"].Value=@"ERROR:Move To should be Mandatory";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""ERROR:Move To should be Mandatory"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if(ISpace["M_MoveTo"].Value=="RETURN"||ISpace["M_MoveTo"].Value=="REJECT")
{
base.WriteDebugInfo(@"if(ISpace[""M_MoveTo""].Value==""RETURN""||ISpace[""M_MoveTo""].Value==""REJECT"")");
if(ISpace["Comments"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""Comments""].Value=="""")");
ISpace["Message"].Value=@"ERROR:Comments should be Mandatory";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""ERROR:Comments should be Mandatory"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
}

ISpace["RedirectUrl"].RedirectType="R";
ISpace["RedirectUrl"].Value="/Inbox";
base.WriteDebugInfo(@"
ISpace[""RedirectUrl""].RedirectType=""R"";
ISpace[""RedirectUrl""].Value=""/Inbox"";");
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
		if(elementName.ToLower().Equals("mf_d10_fromdate"))
    {
    			SubscribeElementEvents_mf_d10_fromdate(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mf_d10_yearmonth"))
    {
    			SubscribeElementEvents_mf_d10_yearmonth(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mf_d10_projectproposalid"))
    {
    			SubscribeElementEvents_mf_d10_projectproposalid(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mg_d154_totalmonths"))
    {
    			SubscribeElementEvents_mg_d154_totalmonths(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mg_d109_rateininr"))
    {
    			SubscribeElementEvents_mg_d109_rateininr(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mg_d154_ratepermonth"))
    {
    			SubscribeElementEvents_mg_d154_ratepermonth(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mg_d154_duration"))
    {
    			SubscribeElementEvents_mg_d154_duration(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mg_d109_quantity"))
    {
    			SubscribeElementEvents_mg_d109_quantity(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mg_d28_budgetamount"))
    {
    			SubscribeElementEvents_mg_d28_budgetamount(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mg_d154_hrapermonth"))
    {
    			SubscribeElementEvents_mg_d154_hrapermonth(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mg_d154_hrapercentage"))
    {
    			SubscribeElementEvents_mg_d154_hrapercentage(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mg_d154_no_ofmanpowerposition"))
    {
    			SubscribeElementEvents_mg_d154_no_ofmanpowerposition(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mf_d10_duration"))
    {
    			SubscribeElementEvents_mf_d10_duration(ref dfsParam);
    }
		if(elementName.ToLower().Equals("m_moveto"))
    {
    			SubscribeElementEvents_m_moveto(ref dfsParam);
    }
}
	if(methodName.ToLower().Equals("onclick"))
{
		if(elementName.ToLower().Equals("m_cancel"))
{
			SubscribeElementEvents_m_cancel(ref dfsParam);
}
		if(elementName.ToLower().Equals("m_history"))
{
			SubscribeElementEvents_m_history(ref dfsParam);
}
		if(elementName.ToLower().Equals("submitform"))
{
			SubscribeElementEvents_submitform(ref dfsParam);
}
}
	if(methodName.ToLower().Equals("onafterrowdeleting"))
{
		if(elementName.ToLower().Equals("equipmentgrid"))
{
			equipmentgrid_onafterrowdeleting(ref dfsParam);
}
		if(elementName.ToLower().Equals("manpowergrid"))
{
			manpowergrid_onafterrowdeleting(ref dfsParam);
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


	public partial class AcDataISpaceE1B5DCB812784AA0A8B21C0CDE17E77A  : ExtensionActivityBase
	{		
		
		
		private Dictionary<string,  List<Triplet<string, short, short?>>> queryExpressionBindings = 
											new Dictionary<string,  List<Triplet<string, short, short?>>>
		{
							{"22ae9f9e-e9e8-79dd-1f5e-44b4433f5e5c", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_d55_ExternalEmailId",9,
														   -1),
								   new Triplet<string, short, short?>("MG_d55_ExternalInstituteName",6,
														   -1),
								   new Triplet<string, short, short?>("MG_d55_ExternalFacultyName",7,
														   -1),
								   new Triplet<string, short, short?>("MG_d55_DesignationID",5,
														   -1),
								   new Triplet<string, short, short?>("MG_d55_AdditionalName",3,
														   -1),
								   new Triplet<string, short, short?>("MG_d55_Departmentid",4,
														   -1),
								   new Triplet<string, short, short?>("MG_d55_ExternalContactNo",10,
														   -1),
								   new Triplet<string, short, short?>("MG_d55_AdditionalType",2,
														   -1),
								   new Triplet<string, short, short?>("MG_d55_ExternalDesignation",8,
														   -1),
								}
			},
							{"83ae6bea-5b86-be67-af2d-86bd670877ef", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("EquipmentGrid_Sequence",1,
														   -1),
								   new Triplet<string, short, short?>("MG_d109_Description",4,
														   -1),
								   new Triplet<string, short, short?>("MG_d109_OverallEquipmentcost",10,
														   -1),
								   new Triplet<string, short, short?>("MG_d109_SerialNo",2,
														   -1),
								   new Triplet<string, short, short?>("MG_d109_TotalEquipmentcost",7,
														   -1),
								   new Triplet<string, short, short?>("MG_d109_EquipmentName",3,
														   -1),
								   new Triplet<string, short, short?>("MG_d109_Quantity",5,
														   -1),
								   new Triplet<string, short, short?>("MG_d109_RateinINR",6,
														   -1),
								   new Triplet<string, short, short?>("MG_d109_EquipmentBudget",8,
														   -1),
								   new Triplet<string, short, short?>("EquipmentGrid_RowId",0,
														   -1),
								}
			},
							{"0303e9a5-833d-0f47-5962-40219e02283c", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_d28_Year4",8,
														   -1),
								   new Triplet<string, short, short?>("MG_d28_Year12",16,
														   -1),
								   new Triplet<string, short, short?>("MG_d28_BudgetID",0,
														   -1),
								   new Triplet<string, short, short?>("MG_d28_Year9",13,
														   -1),
								   new Triplet<string, short, short?>("MG_d28_BudgetDetailsId",3,
														   -1),
								   new Triplet<string, short, short?>("MG_d28_Year10",14,
														   -1),
								   new Triplet<string, short, short?>("MG_d28_RecurringValidation",4,
														   -1),
								   new Triplet<string, short, short?>("MG_d28_Year6",10,
														   -1),
								   new Triplet<string, short, short?>("MG_d28_Year1",5,
														   -1),
								   new Triplet<string, short, short?>("MG_d28_BudgetAmount",2,
														   -1),
								   new Triplet<string, short, short?>("MG_d28_Year3",7,
														   -1),
								   new Triplet<string, short, short?>("MG_d28_RDOfficeComments",19,
														   -1),
								   new Triplet<string, short, short?>("MG_d28_Year7",11,
														   -1),
								   new Triplet<string, short, short?>("MG_d28_BudgetHead",1,
														   -1),
								   new Triplet<string, short, short?>("MG_d28_Comments",18,
														   -1),
								   new Triplet<string, short, short?>("MG_d28_Year8",12,
														   -1),
								   new Triplet<string, short, short?>("MG_d28_Year11",15,
														   -1),
								   new Triplet<string, short, short?>("MG_d28_Year2",6,
														   -1),
								   new Triplet<string, short, short?>("MG_d28_Year5",9,
														   -1),
								   new Triplet<string, short, short?>("BudgetAllocation_RowId",3,
														   -1),
								}
			},
							{"2dff5309-7010-e57f-5c95-f700983350be", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_d154_HRAPercentage",11,
														   -1),
								   new Triplet<string, short, short?>("MG_d154_No_OfManpowerPosition",9,
														   -1),
								   new Triplet<string, short, short?>("MG_d154_ManpowerPosition",8,
														   -1),
								   new Triplet<string, short, short?>("ManpowerGrid_RowId",3,
														   -1),
								   new Triplet<string, short, short?>("MG_d154_TotalMonths",14,
														   -1),
								   new Triplet<string, short, short?>("MG_d154_SerialNo",6,
														   -1),
								   new Triplet<string, short, short?>("MG_d154_Comments",7,
														   -1),
								   new Triplet<string, short, short?>("MG_d154_TotalPerMonth",13,
														   -1),
								   new Triplet<string, short, short?>("MG_d154_Duration",5,
														   -1),
								   new Triplet<string, short, short?>("ManpowerGrid_Sequence",4,
														   -1),
								   new Triplet<string, short, short?>("MG_d154_RatePerMonth",10,
														   -1),
								   new Triplet<string, short, short?>("MG_d154_TotalCost",15,
														   -1),
								   new Triplet<string, short, short?>("MG_d154_HRAPerMonth",12,
														   -1),
								}
			},
					};	

	

		private Dictionary<string,string> formVersionList =new Dictionary<string,string> 
		{
							{"ADD720B3-8CFA-4B65-B90D-7D2AC805F75E", "Medium"},
					};	

		
		private Dictionary<string,string> formVersionLayoutList =new Dictionary<string,string> 
		{
							{"31654BBF-8458-456E-8A97-CB8DF287B3DB", ""},
							{"EBBA6551-A152-4A27-82F0-344BEE3D1C74", ""},
							{"ADD720B3-8CFA-4B65-B90D-7D2AC805F75E", ""},
							{"1C730369-E250-46DB-9E51-30F22612CB56", ""},
							{"99FCAD3E-E7DB-44BF-8861-E8E67BB4EFD9", ""},
							{"78F4762C-C3DC-4D5C-8F7F-FDAEF042ECE1", ""},
							{"726D44DF-A6FD-4940-9565-95DBBB36D41E", ""},
							{"45C301A8-42F3-41D5-9730-7E4737153AD4", ""},
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


	public partial class AcDataISpaceBD6CC522F7E646CBB2009C41F448175B  : ExtensionActivityBase
	{		
		
		
		private Dictionary<string,  List<Triplet<string, short, short?>>> queryExpressionBindings = 
											new Dictionary<string,  List<Triplet<string, short, short?>>>
		{
							{"83ae6bea-5b86-be67-af2d-86bd670877ef", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("EquipmentGrid_Sequence",1,
														   -1),
								   new Triplet<string, short, short?>("MG_d109_Description",4,
														   -1),
								   new Triplet<string, short, short?>("MG_d109_OverallEquipmentcost",10,
														   -1),
								   new Triplet<string, short, short?>("MG_d109_SerialNo",2,
														   -1),
								   new Triplet<string, short, short?>("MG_d109_TotalEquipmentcost",7,
														   -1),
								   new Triplet<string, short, short?>("MG_d109_EquipmentName",3,
														   -1),
								   new Triplet<string, short, short?>("MG_d109_Quantity",5,
														   -1),
								   new Triplet<string, short, short?>("MG_d109_RateinINR",6,
														   -1),
								   new Triplet<string, short, short?>("MG_d109_EquipmentBudget",8,
														   -1),
								   new Triplet<string, short, short?>("EquipmentGrid_RowId",0,
														   -1),
								}
			},
							{"2dff5309-7010-e57f-5c95-f700983350be", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_d154_HRAPercentage",11,
														   -1),
								   new Triplet<string, short, short?>("MG_d154_No_OfManpowerPosition",9,
														   -1),
								   new Triplet<string, short, short?>("MG_d154_ManpowerPosition",8,
														   -1),
								   new Triplet<string, short, short?>("ManpowerGrid_RowId",3,
														   -1),
								   new Triplet<string, short, short?>("MG_d154_TotalMonths",14,
														   -1),
								   new Triplet<string, short, short?>("MG_d154_SerialNo",6,
														   -1),
								   new Triplet<string, short, short?>("MG_d154_Comments",7,
														   -1),
								   new Triplet<string, short, short?>("MG_d154_TotalPerMonth",13,
														   -1),
								   new Triplet<string, short, short?>("MG_d154_Duration",5,
														   -1),
								   new Triplet<string, short, short?>("ManpowerGrid_Sequence",4,
														   -1),
								   new Triplet<string, short, short?>("MG_d154_RatePerMonth",10,
														   -1),
								   new Triplet<string, short, short?>("MG_d154_TotalCost",15,
														   -1),
								   new Triplet<string, short, short?>("MG_d154_HRAPerMonth",12,
														   -1),
								}
			},
							{"89cce784-320f-d42d-41c5-3fb5840cbc25", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("C_Stepfrom",1,
														   -1),
								   new Triplet<string, short, short?>("C_StepTo",2,
														   -1),
								   new Triplet<string, short, short?>("C_DateofComments",4,
														   -1),
								   new Triplet<string, short, short?>("C_User",3,
														   -1),
								   new Triplet<string, short, short?>("C_Comments",5,
														   -1),
								}
			},
					};	

	

		private Dictionary<string,string> formVersionList =new Dictionary<string,string> 
		{
							{"ADD720B3-8CFA-4B65-B90D-7D2AC805F75E", "Medium"},
					};	

		
		private Dictionary<string,string> formVersionLayoutList =new Dictionary<string,string> 
		{
							{"31654BBF-8458-456E-8A97-CB8DF287B3DB", ""},
							{"EBBA6551-A152-4A27-82F0-344BEE3D1C74", ""},
							{"ADD720B3-8CFA-4B65-B90D-7D2AC805F75E", ""},
							{"1C730369-E250-46DB-9E51-30F22612CB56", ""},
							{"99FCAD3E-E7DB-44BF-8861-E8E67BB4EFD9", ""},
							{"78F4762C-C3DC-4D5C-8F7F-FDAEF042ECE1", ""},
							{"726D44DF-A6FD-4940-9565-95DBBB36D41E", ""},
							{"45C301A8-42F3-41D5-9730-7E4737153AD4", ""},
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


	public partial class AcDataISpace218B0C87E3E24D2EBB8FB38C51CAD1FE  : ExtensionActivityBase
	{		
		
		
		private Dictionary<string,  List<Triplet<string, short, short?>>> queryExpressionBindings = 
											new Dictionary<string,  List<Triplet<string, short, short?>>>
		{
							{"83ae6bea-5b86-be67-af2d-86bd670877ef", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("EquipmentGrid_Sequence",1,
														   -1),
								   new Triplet<string, short, short?>("MG_d109_Description",4,
														   -1),
								   new Triplet<string, short, short?>("MG_d109_OverallEquipmentcost",10,
														   -1),
								   new Triplet<string, short, short?>("MG_d109_SerialNo",2,
														   -1),
								   new Triplet<string, short, short?>("MG_d109_TotalEquipmentcost",7,
														   -1),
								   new Triplet<string, short, short?>("MG_d109_EquipmentName",3,
														   -1),
								   new Triplet<string, short, short?>("MG_d109_Quantity",5,
														   -1),
								   new Triplet<string, short, short?>("MG_d109_RateinINR",6,
														   -1),
								   new Triplet<string, short, short?>("MG_d109_EquipmentBudget",8,
														   -1),
								   new Triplet<string, short, short?>("EquipmentGrid_RowId",0,
														   -1),
								}
			},
							{"2dff5309-7010-e57f-5c95-f700983350be", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_d154_HRAPercentage",11,
														   -1),
								   new Triplet<string, short, short?>("MG_d154_No_OfManpowerPosition",9,
														   -1),
								   new Triplet<string, short, short?>("MG_d154_ManpowerPosition",8,
														   -1),
								   new Triplet<string, short, short?>("ManpowerGrid_RowId",3,
														   -1),
								   new Triplet<string, short, short?>("MG_d154_TotalMonths",14,
														   -1),
								   new Triplet<string, short, short?>("MG_d154_SerialNo",6,
														   -1),
								   new Triplet<string, short, short?>("MG_d154_Comments",7,
														   -1),
								   new Triplet<string, short, short?>("MG_d154_TotalPerMonth",13,
														   -1),
								   new Triplet<string, short, short?>("MG_d154_Duration",5,
														   -1),
								   new Triplet<string, short, short?>("ManpowerGrid_Sequence",4,
														   -1),
								   new Triplet<string, short, short?>("MG_d154_RatePerMonth",10,
														   -1),
								   new Triplet<string, short, short?>("MG_d154_TotalCost",15,
														   -1),
								   new Triplet<string, short, short?>("MG_d154_HRAPerMonth",12,
														   -1),
								}
			},
							{"89cce784-320f-d42d-41c5-3fb5840cbc25", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("C_Stepfrom",1,
														   -1),
								   new Triplet<string, short, short?>("C_StepTo",2,
														   -1),
								   new Triplet<string, short, short?>("C_DateofComments",4,
														   -1),
								   new Triplet<string, short, short?>("C_User",3,
														   -1),
								   new Triplet<string, short, short?>("C_Comments",5,
														   -1),
								}
			},
					};	

	

		private Dictionary<string,string> formVersionList =new Dictionary<string,string> 
		{
							{"ADD720B3-8CFA-4B65-B90D-7D2AC805F75E", "Medium"},
					};	

		
		private Dictionary<string,string> formVersionLayoutList =new Dictionary<string,string> 
		{
							{"31654BBF-8458-456E-8A97-CB8DF287B3DB", ""},
							{"EBBA6551-A152-4A27-82F0-344BEE3D1C74", ""},
							{"ADD720B3-8CFA-4B65-B90D-7D2AC805F75E", ""},
							{"1C730369-E250-46DB-9E51-30F22612CB56", ""},
							{"99FCAD3E-E7DB-44BF-8861-E8E67BB4EFD9", ""},
							{"78F4762C-C3DC-4D5C-8F7F-FDAEF042ECE1", ""},
							{"726D44DF-A6FD-4940-9565-95DBBB36D41E", ""},
							{"45C301A8-42F3-41D5-9730-7E4737153AD4", ""},
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


	public partial class AcDataISpace88470FA805F74764A871E9DAC8F66C89  : ExtensionActivityBase
	{		
		
		
		private Dictionary<string,  List<Triplet<string, short, short?>>> queryExpressionBindings = 
											new Dictionary<string,  List<Triplet<string, short, short?>>>
		{
							{"83ae6bea-5b86-be67-af2d-86bd670877ef", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("EquipmentGrid_Sequence",1,
														   -1),
								   new Triplet<string, short, short?>("MG_d109_Description",4,
														   -1),
								   new Triplet<string, short, short?>("MG_d109_OverallEquipmentcost",10,
														   -1),
								   new Triplet<string, short, short?>("MG_d109_SerialNo",2,
														   -1),
								   new Triplet<string, short, short?>("MG_d109_TotalEquipmentcost",7,
														   -1),
								   new Triplet<string, short, short?>("MG_d109_EquipmentName",3,
														   -1),
								   new Triplet<string, short, short?>("MG_d109_Quantity",5,
														   -1),
								   new Triplet<string, short, short?>("MG_d109_RateinINR",6,
														   -1),
								   new Triplet<string, short, short?>("MG_d109_EquipmentBudget",8,
														   -1),
								   new Triplet<string, short, short?>("EquipmentGrid_RowId",0,
														   -1),
								}
			},
							{"2dff5309-7010-e57f-5c95-f700983350be", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_d154_HRAPercentage",11,
														   -1),
								   new Triplet<string, short, short?>("MG_d154_No_OfManpowerPosition",9,
														   -1),
								   new Triplet<string, short, short?>("MG_d154_ManpowerPosition",8,
														   -1),
								   new Triplet<string, short, short?>("ManpowerGrid_RowId",3,
														   -1),
								   new Triplet<string, short, short?>("MG_d154_TotalMonths",14,
														   -1),
								   new Triplet<string, short, short?>("MG_d154_SerialNo",6,
														   -1),
								   new Triplet<string, short, short?>("MG_d154_Comments",7,
														   -1),
								   new Triplet<string, short, short?>("MG_d154_TotalPerMonth",13,
														   -1),
								   new Triplet<string, short, short?>("MG_d154_Duration",5,
														   -1),
								   new Triplet<string, short, short?>("ManpowerGrid_Sequence",4,
														   -1),
								   new Triplet<string, short, short?>("MG_d154_RatePerMonth",10,
														   -1),
								   new Triplet<string, short, short?>("MG_d154_TotalCost",15,
														   -1),
								   new Triplet<string, short, short?>("MG_d154_HRAPerMonth",12,
														   -1),
								}
			},
							{"89cce784-320f-d42d-41c5-3fb5840cbc25", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("C_Stepfrom",1,
														   -1),
								   new Triplet<string, short, short?>("C_StepTo",2,
														   -1),
								   new Triplet<string, short, short?>("C_DateofComments",4,
														   -1),
								   new Triplet<string, short, short?>("C_User",3,
														   -1),
								   new Triplet<string, short, short?>("C_Comments",5,
														   -1),
								}
			},
					};	

	

		private Dictionary<string,string> formVersionList =new Dictionary<string,string> 
		{
							{"ADD720B3-8CFA-4B65-B90D-7D2AC805F75E", "Medium"},
					};	

		
		private Dictionary<string,string> formVersionLayoutList =new Dictionary<string,string> 
		{
							{"31654BBF-8458-456E-8A97-CB8DF287B3DB", ""},
							{"EBBA6551-A152-4A27-82F0-344BEE3D1C74", ""},
							{"ADD720B3-8CFA-4B65-B90D-7D2AC805F75E", ""},
							{"1C730369-E250-46DB-9E51-30F22612CB56", ""},
							{"99FCAD3E-E7DB-44BF-8861-E8E67BB4EFD9", ""},
							{"78F4762C-C3DC-4D5C-8F7F-FDAEF042ECE1", ""},
							{"726D44DF-A6FD-4940-9565-95DBBB36D41E", ""},
							{"45C301A8-42F3-41D5-9730-7E4737153AD4", ""},
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


	public partial class AcDataISpaceDC6D256C5F944FE59309FD74A0FF257E  : ExtensionActivityBase
	{		
		
		
		private Dictionary<string,  List<Triplet<string, short, short?>>> queryExpressionBindings = 
											new Dictionary<string,  List<Triplet<string, short, short?>>>
		{
							{"22ae9f9e-e9e8-79dd-1f5e-44b4433f5e5c", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_d55_ExternalEmailId",9,
														   -1),
								   new Triplet<string, short, short?>("MG_d55_ExternalInstituteName",6,
														   -1),
								   new Triplet<string, short, short?>("MG_d55_ExternalFacultyName",7,
														   -1),
								   new Triplet<string, short, short?>("MG_d55_DesignationID",5,
														   -1),
								   new Triplet<string, short, short?>("MG_d55_AdditionalName",3,
														   -1),
								   new Triplet<string, short, short?>("MG_d55_Departmentid",4,
														   -1),
								   new Triplet<string, short, short?>("MG_d55_ExternalContactNo",10,
														   -1),
								   new Triplet<string, short, short?>("MG_d55_AdditionalType",2,
														   -1),
								   new Triplet<string, short, short?>("MG_d55_ExternalDesignation",8,
														   -1),
								}
			},
							{"83ae6bea-5b86-be67-af2d-86bd670877ef", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("EquipmentGrid_Sequence",1,
														   -1),
								   new Triplet<string, short, short?>("MG_d109_Description",4,
														   -1),
								   new Triplet<string, short, short?>("MG_d109_OverallEquipmentcost",10,
														   -1),
								   new Triplet<string, short, short?>("MG_d109_SerialNo",2,
														   -1),
								   new Triplet<string, short, short?>("MG_d109_TotalEquipmentcost",7,
														   -1),
								   new Triplet<string, short, short?>("MG_d109_EquipmentName",3,
														   -1),
								   new Triplet<string, short, short?>("MG_d109_Quantity",5,
														   -1),
								   new Triplet<string, short, short?>("MG_d109_RateinINR",6,
														   -1),
								   new Triplet<string, short, short?>("MG_d109_EquipmentBudget",8,
														   -1),
								   new Triplet<string, short, short?>("EquipmentGrid_RowId",0,
														   -1),
								}
			},
							{"0303e9a5-833d-0f47-5962-40219e02283c", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_d28_Year4",8,
														   -1),
								   new Triplet<string, short, short?>("MG_d28_Year12",16,
														   -1),
								   new Triplet<string, short, short?>("MG_d28_BudgetID",0,
														   -1),
								   new Triplet<string, short, short?>("MG_d28_Year9",13,
														   -1),
								   new Triplet<string, short, short?>("MG_d28_BudgetDetailsId",3,
														   -1),
								   new Triplet<string, short, short?>("MG_d28_Year10",14,
														   -1),
								   new Triplet<string, short, short?>("MG_d28_RecurringValidation",4,
														   -1),
								   new Triplet<string, short, short?>("MG_d28_Year6",10,
														   -1),
								   new Triplet<string, short, short?>("MG_d28_Year1",5,
														   -1),
								   new Triplet<string, short, short?>("MG_d28_BudgetAmount",2,
														   -1),
								   new Triplet<string, short, short?>("MG_d28_Year3",7,
														   -1),
								   new Triplet<string, short, short?>("MG_d28_RDOfficeComments",19,
														   -1),
								   new Triplet<string, short, short?>("MG_d28_Year7",11,
														   -1),
								   new Triplet<string, short, short?>("MG_d28_BudgetHead",1,
														   -1),
								   new Triplet<string, short, short?>("MG_d28_Comments",18,
														   -1),
								   new Triplet<string, short, short?>("MG_d28_Year8",12,
														   -1),
								   new Triplet<string, short, short?>("MG_d28_Year11",15,
														   -1),
								   new Triplet<string, short, short?>("MG_d28_Year2",6,
														   -1),
								   new Triplet<string, short, short?>("MG_d28_Year5",9,
														   -1),
								   new Triplet<string, short, short?>("BudgetAllocation_RowId",3,
														   -1),
								}
			},
							{"2dff5309-7010-e57f-5c95-f700983350be", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_d154_HRAPercentage",11,
														   -1),
								   new Triplet<string, short, short?>("MG_d154_No_OfManpowerPosition",9,
														   -1),
								   new Triplet<string, short, short?>("MG_d154_ManpowerPosition",8,
														   -1),
								   new Triplet<string, short, short?>("ManpowerGrid_RowId",3,
														   -1),
								   new Triplet<string, short, short?>("MG_d154_TotalMonths",14,
														   -1),
								   new Triplet<string, short, short?>("MG_d154_SerialNo",6,
														   -1),
								   new Triplet<string, short, short?>("MG_d154_Comments",7,
														   -1),
								   new Triplet<string, short, short?>("MG_d154_TotalPerMonth",13,
														   -1),
								   new Triplet<string, short, short?>("MG_d154_Duration",5,
														   -1),
								   new Triplet<string, short, short?>("ManpowerGrid_Sequence",4,
														   -1),
								   new Triplet<string, short, short?>("MG_d154_RatePerMonth",10,
														   -1),
								   new Triplet<string, short, short?>("MG_d154_TotalCost",15,
														   -1),
								   new Triplet<string, short, short?>("MG_d154_HRAPerMonth",12,
														   -1),
								}
			},
							{"89cce784-320f-d42d-41c5-3fb5840cbc25", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("C_Stepfrom",1,
														   -1),
								   new Triplet<string, short, short?>("C_StepTo",2,
														   -1),
								   new Triplet<string, short, short?>("C_DateofComments",4,
														   -1),
								   new Triplet<string, short, short?>("C_User",3,
														   -1),
								   new Triplet<string, short, short?>("C_Comments",5,
														   -1),
								}
			},
					};	

	

		private Dictionary<string,string> formVersionList =new Dictionary<string,string> 
		{
							{"ADD720B3-8CFA-4B65-B90D-7D2AC805F75E", "Medium"},
					};	

		
		private Dictionary<string,string> formVersionLayoutList =new Dictionary<string,string> 
		{
							{"31654BBF-8458-456E-8A97-CB8DF287B3DB", ""},
							{"EBBA6551-A152-4A27-82F0-344BEE3D1C74", ""},
							{"ADD720B3-8CFA-4B65-B90D-7D2AC805F75E", ""},
							{"1C730369-E250-46DB-9E51-30F22612CB56", ""},
							{"99FCAD3E-E7DB-44BF-8861-E8E67BB4EFD9", ""},
							{"78F4762C-C3DC-4D5C-8F7F-FDAEF042ECE1", ""},
							{"726D44DF-A6FD-4940-9565-95DBBB36D41E", ""},
							{"45C301A8-42F3-41D5-9730-7E4737153AD4", ""},
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
		


