  







namespace CPS.Proof.DFSExtension
{
	using System;
    using System.Collections.Generic;     
	using System.Linq;
	
	
	public partial class ProjectProposalProcessMetadata : ExtensionProcessBase
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
            get { return "026e321e-9bb7-4c74-8615-3bbd7cc1b241"; }
        }

        public override string ProcessName
        {
            get { return "ProjectProposal"; }
        }

		public override string ProcessDescription
        {
            get { return "Project Proposal"; }
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
            get {return "026e321e-9bb7-4c74-8615-3bbd7cc1b241";}
        }

		public override byte ProcessInstanceMode
        {
            get {return 3;}
        }		

		public override string MasterFormId
        {
            get {  
				   return "E0AC6667-6D92-49AA-8F4D-01F473F2E426";	}
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
	

	public partial class ProjectProposalObjectFactory  : ExtObjectFactoryBase
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
        //    return (IExtBaseMetaData)new ProjectProposalProcessMetadata();
        //}
	


		private List<Triplet<string, string, string>> queryExpressionData = new List<Triplet<string, string, string>>
		{
	  			
			     new Triplet<string, string, string>("18f009fa-842f-90cf-5d3c-5263dc607c23","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("4D70F9F7-6296-4C9D-BE17-64DD6765B7EB","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"24F5D845-D560-4FC1-B284-00FB19DFB96F"),
			
						
			     new Triplet<string, string, string>("46a6879a-4dfd-54d1-38c9-6438be62af60","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("F928C371-839D-4F0F-AF8D-BCADF87418A6","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("FBADFA2F-E68E-4BCB-A058-D7C63AAD5730","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("0C8CDFAE-5C2A-428D-A7E8-DC4118670282","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("b1129839-7563-b91c-2a45-3c887bc84b31","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("6C11211E-6354-4E64-99A1-D591D85CCC41","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"24F5D845-D560-4FC1-B284-00FB19DFB96F"),
			
						
			     new Triplet<string, string, string>("401A9D34-8FD6-4AD0-8D6D-BFDA8D331663","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"24F5D845-D560-4FC1-B284-00FB19DFB96F"),
			
						
			     new Triplet<string, string, string>("282f122c-129c-3f66-2802-e500377eb9b5","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"028B1EFF-34A8-4D44-BF39-06CE99DF7C67"),
			
						
			     new Triplet<string, string, string>("f503cb55-6d72-d4d5-8857-a65ba2925360","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("0a52bb10-821c-0a9a-8ae2-ec075fba6a8e","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("9ea11c91-985f-03d9-6133-79e184c5089c","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("80332665-9163-4BD6-8426-C075A9016AEF","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("38A4572F-A650-40C2-879C-BCCD9DD5898C","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("F7CC07A7-418E-45D2-9431-6826271A4DA5","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("8D9E2480-7B9A-4810-A517-2F25677BF216","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("40d3e7ce-7290-1b76-8430-a4b65e4802e8","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("cf8665f1-ed60-b9d0-8a13-ee250aa2de27","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("5c6a584d-a4e2-b467-f6c2-c66f0c409f6c","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"24F5D845-D560-4FC1-B284-00FB19DFB96F"),
			
						
			     new Triplet<string, string, string>("f9231ef6-c778-e031-aeb2-2f8be33e4ca2","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("18f009fa-842f-90cf-5d3c-5263dc607c23","Load Additional Document Details based on Funding Agency and Project Category",
												     @"A3BB2140-4053-4558-9363-3BA1B526BD0A"),
			
						
			     new Triplet<string, string, string>("46a6879a-4dfd-54d1-38c9-6438be62af60","Delete Copi Details",
												     @"FC9B8D2E-9EE3-436F-AF08-A774AF04D678"),
			
						
			     new Triplet<string, string, string>("6C11211E-6354-4E64-99A1-D591D85CCC41","Grid BindingF",
												     @"FC9B8D2E-9EE3-436F-AF08-A774AF04D678"),
			
						
			     new Triplet<string, string, string>("401A9D34-8FD6-4AD0-8D6D-BFDA8D331663","Grid Binding2",
												     @"FC9B8D2E-9EE3-436F-AF08-A774AF04D678"),
			
						
			     new Triplet<string, string, string>("0a52bb10-821c-0a9a-8ae2-ec075fba6a8e","Load Proposal Documents",
												     @"D2D6E00A-B6B7-4968-BAAA-EF3D20F2BAC5"),
			
						
			     new Triplet<string, string, string>("80332665-9163-4BD6-8426-C075A9016AEF","Load Grid By IdProposalDocuments",
												     @"D2D6E00A-B6B7-4968-BAAA-EF3D20F2BAC5"),
			
						
			     new Triplet<string, string, string>("F7CC07A7-418E-45D2-9431-6826271A4DA5","Load Grid By IdCopiDetails",
												     @"FC9B8D2E-9EE3-436F-AF08-A774AF04D678"),
			
						
			     new Triplet<string, string, string>("8D9E2480-7B9A-4810-A517-2F25677BF216","Load Grid By IdRequiredDocuments",
												     @"A3BB2140-4053-4558-9363-3BA1B526BD0A"),
			
						
			     new Triplet<string, string, string>("5c6a584d-a4e2-b467-f6c2-c66f0c409f6c","Load History Details Based On Form Load",
												     @"99ae5d17-b4b2-d238-11a3-a33c1b7f516b"),
			
			
			
		};

		
		private List<Triplet<string, string, string>> ComboDataSource = new List<Triplet<string, string, string>>
		{

		
	  			
			     new Triplet<string, string, string>("MF_d1_FinancialYearID","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMAqCwOWy+D7Ogje1I4jfjiAZNrjEazgaNyfBj9pr2u90lOsHzRNfKnSybWqRxrZGqV",
												     @"EXEC GetDateDifferenceInYears 8,'','',''"),
			
						
			     new Triplet<string, string, string>("MF_d1_ProjectCategoryID","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMAqCwOWy+D7Ogje1I4jfjiAZNrjEazgaNyfBj9pr2u90lOsHzRNfKnSybWqRxrZGqV",
												     @"EXEC GetDateDifferenceInYears 4,'','',''"),
			
						
			     new Triplet<string, string, string>("MF_d1_Currency","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMAqCwOWy+D7Ogje1I4jfjiAZNrjEazgaNyfBj9pr2u90lOsHzRNfKnSybWqRxrZGqV",
												     @"EXEC GetCurrency"),
			
						
			     new Triplet<string, string, string>("MF_d1_ProjectType","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMAqCwOWy+D7Ogje1I4jfjiAZNrjEazgaNyfBj9pr2u90lOsHzRNfKnSybWqRxrZGqV",
												     @"EXEC GetProjectDetailCombo 2"),
			
						
			     new Triplet<string, string, string>("MFG_d2_MemberType","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMAqCwOWy+D7Ogje1I4jfjiAZNrjEazgaNyfBj9pr2u90lOsHzRNfKnSybWqRxrZGqV",
												     @"EXEC GetMemberTypes"),
			
						
			     new Triplet<string, string, string>("MF_d1_SectorID","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMAqCwOWy+D7Ogje1I4jfjiAZNrjEazgaNyfBj9pr2u90lOsHzRNfKnSybWqRxrZGqV",
												     @"EXEC GetDateDifferenceInYears 32,'','',''"),
			
						
			     new Triplet<string, string, string>("MG_d2_AdditionalType","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMAqCwOWy+D7Ogje1I4jfjiAZNrjEazgaNyfBj9pr2u90lOsHzRNfKnSybWqRxrZGqV",
												     @"EXEC [GetDepartmentWiseFaculty] '',3,'','',''"),
			
						
			     new Triplet<string, string, string>("M_MoveTo","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMAX4svK5cDYCPw2sEhYNSLVUgHvT8EwteQ6Cu6POiqivUqpEh16s8+yjMECvtOIho/Hsxg7bNByVU=",
												     @"EXEC GetNextStep '@MF_d1_ProjectProposalID','@M_FlowType'"),
			
						
			     new Triplet<string, string, string>("MFG_d2_AdditionalName","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMAqCwOWy+D7Ogje1I4jfjiAZNrjEazgaNyfBj9pr2u90lOsHzRNfKnSybWqRxrZGqV",
												     @"EXEC GetDepartmentWiseFacultyCopi '@MFG_d2_Departmentid',3,'@DummyInstance',''"),
			
						
			     new Triplet<string, string, string>("MFG_d2_Departmentid","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMAqCwOWy+D7Ogje1I4jfjiAZNrjEazgaNyfBj9pr2u90lOsHzRNfKnSybWqRxrZGqV",
												     @"EXEC [GetDepartmentWiseFacultyCopi] '@M_DepartmentId',2,'@DummyInstance','@MFG_d2_AdditionalType'"),
			
						
			     new Triplet<string, string, string>("MF_d1_FundingAgency","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMAqCwOWy+D7Ogje1I4jfjiAZNrjEazgaNyfBj9pr2u90lOsHzRNfKnSybWqRxrZGqV",
												     @"EXEC GetDateDifferenceInYears 7,'','',''"),
			
						
			     new Triplet<string, string, string>("MFG_d2_AdditionalType","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMAqCwOWy+D7Ogje1I4jfjiAZNrjEazgaNyfBj9pr2u90lOsHzRNfKnSybWqRxrZGqV",
												     @"EXEC [GetDepartmentWiseFaculty] '',3,'','',''"),
			
						
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
		
	  			
			     new Tuple<string, int>("CopiDetails",1000),
			
						
			     new Tuple<string, int>("ProposalDocuments",5),
			
						
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
											case "B3A49337-4C4B-42EC-9F9B-1C4C8B4E2E13":
							virtualInstance=new ISpaceB3A493374C4B42EC9F9B1C4C8B4E2E13();
							break;
					
											case "F692D026-2B48-418C-9285-DBD42DAC5F26":
							virtualInstance=new ISpaceF692D0262B48418C9285DBD42DAC5F26();
							break;
					
											case "2D400E54-E6D1-43C7-9824-3831B9AD8F32":
							virtualInstance=new ISpace2D400E54E6D143C798243831B9AD8F32();
							break;
					
											case "6d06ae9b-b587-3c74-a747-3b1063ed2f0d":
							virtualInstance=new ISpace6d06ae9bb5873c74a7473b1063ed2f0d();
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
	

	public partial class ProjectProposalDataElementFactory  : ExtElementBase
    {

     /// <summary>
        /// A <see cref="log4net.ILog"/> that contains the logger instance for 
        /// logging
        /// </summary>
        private readonly ILog _sysLog;

        public ProjectProposalDataElementFactory()
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

               
                
                                      case "E0AC6667-6D92-49AA-8F4D-01F473F2E426":
                    {
                     
                                     fInsertQuery=@"IF NOT EXISTS(SELECT 1 FROM [E0AC6667-6D92-49AA-8F4D-01F473F2E426] WHERE InstanceId='{0}') BEGIN INSERT INTO [E0AC6667-6D92-49AA-8F4D-01F473F2E426](ProcessActivityMapId,FormId,Subject,ExecutionStatus,ExecutionMessage,SetDestinationTo,SLATime,MF_d1_ProjectProposalID,MF_d1_ProjectRefNo,MF_d1_ProjectCategoryID,MF_d1_FinancialYearID,MF_d1_DepartmentID,MF_d1_Designation,MF_d1_ProjectName,MF_d1_ProjectType,MF_d1_FundingAgency,MF_d1_ProjectBudget,MF_d1_Remarks,MF_d1_PrincipalInvestigator,MF_d1_EmployeeBasicInfoId,MF_d1_ProjectStatus,MF_d1_SectorID,MF_d1_EndorsementFileType,MF_d1_ProposalCode,MF_d1_IsSubmitted,MF_d1_OverHead,MF_d1_IfExternalInstitute,MF_d1_UpdatedBy,MF_d1_UpdatedOn,AssignToRole,AssignToUser,IN_Priority,IN_InstanceName,IN_SLA,IN_Status,IN_Category,ExecuteCommand,RedirectUrl,Thumbnail,CancelRedirectUrl,KeyContext,DisplayContext,growid,MF_d1_Currency,M_DepartmentId,M_DesignationId,Dept,DummyInstance,M_EMPCode,M_DeptCode,MF_d1_ProjectCategoryCode,M_MoveTo,InstanceId,M_FlowType,M_ParentRowId,MandatoryCheck,Comments)
							VALUES( {3}) END ELSE BEGIN UPDATE [E0AC6667-6D92-49AA-8F4D-01F473F2E426]SET {4}WHERE InstanceId='{0}'END ";

                                     colList=@"ProcessActivityMapId,FormId,Subject,ExecutionStatus,ExecutionMessage,SetDestinationTo,SLATime,MF_d1_ProjectProposalID,MF_d1_ProjectRefNo,MF_d1_ProjectCategoryID,MF_d1_FinancialYearID,MF_d1_DepartmentID,MF_d1_Designation,MF_d1_ProjectName,MF_d1_ProjectType,MF_d1_FundingAgency,MF_d1_ProjectBudget,MF_d1_Remarks,MF_d1_PrincipalInvestigator,MF_d1_EmployeeBasicInfoId,MF_d1_ProjectStatus,MF_d1_SectorID,MF_d1_EndorsementFileType,MF_d1_ProposalCode,MF_d1_IsSubmitted,MF_d1_OverHead,MF_d1_IfExternalInstitute,MF_d1_UpdatedBy,MF_d1_UpdatedOn,AssignToRole,AssignToUser,IN_Priority,IN_InstanceName,IN_SLA,IN_Status,IN_Category,ExecuteCommand,RedirectUrl,Thumbnail,CancelRedirectUrl,KeyContext,DisplayContext,growid,MF_d1_Currency,M_DepartmentId,M_DesignationId,Dept,DummyInstance,M_EMPCode,M_DeptCode,MF_d1_ProjectCategoryCode,M_MoveTo,InstanceId,M_FlowType,M_ParentRowId,MandatoryCheck,Comments";
                                    
                     
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

                
                 
                                      case "FC9B8D2E-9EE3-436F-AF08-A774AF04D678":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_FC9B8D2E9EE3436FAF08A774AF04D678 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_d2_AdditionalID] VARCHAR(MAX)	, [MG_d2_ProjectDetailsID] VARCHAR(MAX)	, [MG_d2_AdditionalType] VARCHAR(MAX)	, [MG_d2_AdditionalName] VARCHAR(MAX)	, [MG_d2_Departmentid] VARCHAR(MAX)	, [MG_d2_DesignationID] VARCHAR(MAX)	, [MG_d2_ExternalInstituteName] VARCHAR(MAX)	, [MG_d2_ExternalFacultyName] VARCHAR(MAX)	, [MG_d2_ExternalDesignation] VARCHAR(MAX)	, [MG_d2_ExternalEmailId] VARCHAR(MAX)	, [MG_d2_ExternalContactNo] VARCHAR(MAX)	, [MG_d2_UpdatedBy] INT	, [MG_d2_UpdatedOn] DATETIME	, [MG_d2_MemberType] VARCHAR(MAX)	, [MG_EmployeeName] VARCHAR(MAX)	, [MG_EmployeeDepartment] VARCHAR(MAX)	, [MG_AdditionalTypeValue] VARCHAR(MAX)	, [MG_MemberTypeValue] VARCHAR(MAX)){0}INSERT INTO [FC9B8D2E-9EE3-436F-AF08-A774AF04D678](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d2_AdditionalID,MG_d2_ProjectDetailsID,MG_d2_AdditionalType,MG_d2_AdditionalName,MG_d2_Departmentid,MG_d2_DesignationID,MG_d2_ExternalInstituteName,MG_d2_ExternalFacultyName,MG_d2_ExternalDesignation,MG_d2_ExternalEmailId,MG_d2_ExternalContactNo,MG_d2_UpdatedBy,MG_d2_UpdatedOn,MG_d2_MemberType,MG_EmployeeName,MG_EmployeeDepartment,MG_AdditionalTypeValue,MG_MemberTypeValue)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_d2_AdditionalID,TDT.MG_d2_ProjectDetailsID,TDT.MG_d2_AdditionalType,TDT.MG_d2_AdditionalName,TDT.MG_d2_Departmentid,TDT.MG_d2_DesignationID,TDT.MG_d2_ExternalInstituteName,TDT.MG_d2_ExternalFacultyName,TDT.MG_d2_ExternalDesignation,TDT.MG_d2_ExternalEmailId,TDT.MG_d2_ExternalContactNo,TDT.MG_d2_UpdatedBy,TDT.MG_d2_UpdatedOn,TDT.MG_d2_MemberType,TDT.MG_EmployeeName,TDT.MG_EmployeeDepartment,TDT.MG_AdditionalTypeValue,TDT.MG_MemberTypeValue FROM @TBL_FC9B8D2E9EE3436FAF08A774AF04D678 TDT
							LEFT JOIN [FC9B8D2E-9EE3-436F-AF08-A774AF04D678] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MG_d2_AdditionalID=TDT.MG_d2_AdditionalID,MG_d2_ProjectDetailsID=TDT.MG_d2_ProjectDetailsID,MG_d2_AdditionalType=TDT.MG_d2_AdditionalType,MG_d2_AdditionalName=TDT.MG_d2_AdditionalName,MG_d2_Departmentid=TDT.MG_d2_Departmentid,MG_d2_DesignationID=TDT.MG_d2_DesignationID,MG_d2_ExternalInstituteName=TDT.MG_d2_ExternalInstituteName,MG_d2_ExternalFacultyName=TDT.MG_d2_ExternalFacultyName,MG_d2_ExternalDesignation=TDT.MG_d2_ExternalDesignation,MG_d2_ExternalEmailId=TDT.MG_d2_ExternalEmailId,MG_d2_ExternalContactNo=TDT.MG_d2_ExternalContactNo,MG_d2_UpdatedBy=TDT.MG_d2_UpdatedBy,MG_d2_UpdatedOn=TDT.MG_d2_UpdatedOn,MG_d2_MemberType=TDT.MG_d2_MemberType,MG_EmployeeName=TDT.MG_EmployeeName,MG_EmployeeDepartment=TDT.MG_EmployeeDepartment,MG_AdditionalTypeValue=TDT.MG_AdditionalTypeValue,MG_MemberTypeValue=TDT.MG_MemberTypeValue FROM @TBL_FC9B8D2E9EE3436FAF08A774AF04D678 TDT
							JOIN [FC9B8D2E-9EE3-436F-AF08-A774AF04D678] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d2_AdditionalID,MG_d2_ProjectDetailsID,MG_d2_AdditionalType,MG_d2_AdditionalName,MG_d2_Departmentid,MG_d2_DesignationID,MG_d2_ExternalInstituteName,MG_d2_ExternalFacultyName,MG_d2_ExternalDesignation,MG_d2_ExternalEmailId,MG_d2_ExternalContactNo,MG_d2_UpdatedBy,MG_d2_UpdatedOn,MG_d2_MemberType,MG_EmployeeName,MG_EmployeeDepartment,MG_AdditionalTypeValue,MG_MemberTypeValue";

                                     tempInsertQuery=@"INSERT INTO @TBL_FC9B8D2E9EE3436FAF08A774AF04D678(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d2_AdditionalID,MG_d2_ProjectDetailsID,MG_d2_AdditionalType,MG_d2_AdditionalName,MG_d2_Departmentid,MG_d2_DesignationID,MG_d2_ExternalInstituteName,MG_d2_ExternalFacultyName,MG_d2_ExternalDesignation,MG_d2_ExternalEmailId,MG_d2_ExternalContactNo,MG_d2_UpdatedBy,MG_d2_UpdatedOn,MG_d2_MemberType,MG_EmployeeName,MG_EmployeeDepartment,MG_AdditionalTypeValue,MG_MemberTypeValue)VALUES({0});";
                                     

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
                     
                                    case "D2D6E00A-B6B7-4968-BAAA-EF3D20F2BAC5":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_D2D6E00AB6B74968BAAAEF3D20F2BAC5 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_d3_DocumentName] VARCHAR(MAX)	, [MG_d3_UpdatedOn] DATETIME	, [MG_d3_DocumentProposalID] VARCHAR(MAX)	, [MG_d3_UploadDocument] VARCHAR(36)	, [MG_d3_ProposalDocumentID] VARCHAR(MAX)	, [MG_d3_UpdatedBy] INT	, [MG_d3_ProjectproposalID] VARCHAR(MAX)	, [MG_d3_MandatoryCheck] INT){0}INSERT INTO [D2D6E00A-B6B7-4968-BAAA-EF3D20F2BAC5](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d3_DocumentName,MG_d3_UpdatedOn,MG_d3_DocumentProposalID,MG_d3_UploadDocument,MG_d3_ProposalDocumentID,MG_d3_UpdatedBy,MG_d3_ProjectproposalID,MG_d3_MandatoryCheck)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_d3_DocumentName,TDT.MG_d3_UpdatedOn,TDT.MG_d3_DocumentProposalID,TDT.MG_d3_UploadDocument,TDT.MG_d3_ProposalDocumentID,TDT.MG_d3_UpdatedBy,TDT.MG_d3_ProjectproposalID,TDT.MG_d3_MandatoryCheck FROM @TBL_D2D6E00AB6B74968BAAAEF3D20F2BAC5 TDT
							LEFT JOIN [D2D6E00A-B6B7-4968-BAAA-EF3D20F2BAC5] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MG_d3_DocumentName=TDT.MG_d3_DocumentName,MG_d3_UpdatedOn=TDT.MG_d3_UpdatedOn,MG_d3_DocumentProposalID=TDT.MG_d3_DocumentProposalID,MG_d3_UploadDocument=TDT.MG_d3_UploadDocument,MG_d3_ProposalDocumentID=TDT.MG_d3_ProposalDocumentID,MG_d3_UpdatedBy=TDT.MG_d3_UpdatedBy,MG_d3_ProjectproposalID=TDT.MG_d3_ProjectproposalID,MG_d3_MandatoryCheck=TDT.MG_d3_MandatoryCheck FROM @TBL_D2D6E00AB6B74968BAAAEF3D20F2BAC5 TDT
							JOIN [D2D6E00A-B6B7-4968-BAAA-EF3D20F2BAC5] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d3_DocumentName,MG_d3_UpdatedOn,MG_d3_DocumentProposalID,MG_d3_UploadDocument,MG_d3_ProposalDocumentID,MG_d3_UpdatedBy,MG_d3_ProjectproposalID,MG_d3_MandatoryCheck";

                                     tempInsertQuery=@"INSERT INTO @TBL_D2D6E00AB6B74968BAAAEF3D20F2BAC5(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d3_DocumentName,MG_d3_UpdatedOn,MG_d3_DocumentProposalID,MG_d3_UploadDocument,MG_d3_ProposalDocumentID,MG_d3_UpdatedBy,MG_d3_ProjectproposalID,MG_d3_MandatoryCheck)VALUES({0});";
                                     

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
                     
                                    case "A3BB2140-4053-4558-9363-3BA1B526BD0A":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_A3BB21404053455893633BA1B526BD0A AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_d4_UpdatedBy] INT	, [MG_d4_DocumentId] VARCHAR(MAX)	, [MG_d4_UpdatedOn] DATETIME	, [MG_d4_ProjectproposalID] VARCHAR(MAX)	, [MG_d4_Document] VARCHAR(36)	, [MG_d4_DocumentName] VARCHAR(MAX)	, [MG_d4_Categorymapid] VARCHAR(MAX)){0}INSERT INTO [A3BB2140-4053-4558-9363-3BA1B526BD0A](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d4_UpdatedBy,MG_d4_DocumentId,MG_d4_UpdatedOn,MG_d4_ProjectproposalID,MG_d4_Document,MG_d4_DocumentName,MG_d4_Categorymapid)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_d4_UpdatedBy,TDT.MG_d4_DocumentId,TDT.MG_d4_UpdatedOn,TDT.MG_d4_ProjectproposalID,TDT.MG_d4_Document,TDT.MG_d4_DocumentName,TDT.MG_d4_Categorymapid FROM @TBL_A3BB21404053455893633BA1B526BD0A TDT
							LEFT JOIN [A3BB2140-4053-4558-9363-3BA1B526BD0A] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MG_d4_UpdatedBy=TDT.MG_d4_UpdatedBy,MG_d4_DocumentId=TDT.MG_d4_DocumentId,MG_d4_UpdatedOn=TDT.MG_d4_UpdatedOn,MG_d4_ProjectproposalID=TDT.MG_d4_ProjectproposalID,MG_d4_Document=TDT.MG_d4_Document,MG_d4_DocumentName=TDT.MG_d4_DocumentName,MG_d4_Categorymapid=TDT.MG_d4_Categorymapid FROM @TBL_A3BB21404053455893633BA1B526BD0A TDT
							JOIN [A3BB2140-4053-4558-9363-3BA1B526BD0A] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d4_UpdatedBy,MG_d4_DocumentId,MG_d4_UpdatedOn,MG_d4_ProjectproposalID,MG_d4_Document,MG_d4_DocumentName,MG_d4_Categorymapid";

                                     tempInsertQuery=@"INSERT INTO @TBL_A3BB21404053455893633BA1B526BD0A(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d4_UpdatedBy,MG_d4_DocumentId,MG_d4_UpdatedOn,MG_d4_ProjectproposalID,MG_d4_Document,MG_d4_DocumentName,MG_d4_Categorymapid)VALUES({0});";
                                     

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
                     
                                    case "99ae5d17-b4b2-d238-11a3-a33c1b7f516b":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_99ae5d17b4b2d23811a3a33c1b7f516b AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [C_Stepfrom] VARCHAR(MAX)	, [C_StepTo] VARCHAR(MAX)	, [C_Comments] VARCHAR(MAX)	, [C_User] VARCHAR(MAX)	, [C_DateofComments] DATETIME){0}INSERT INTO [99ae5d17-b4b2-d238-11a3-a33c1b7f516b](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,C_Stepfrom,C_StepTo,C_Comments,C_User,C_DateofComments)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.C_Stepfrom,TDT.C_StepTo,TDT.C_Comments,TDT.C_User,TDT.C_DateofComments FROM @TBL_99ae5d17b4b2d23811a3a33c1b7f516b TDT
							LEFT JOIN [99ae5d17-b4b2-d238-11a3-a33c1b7f516b] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,C_Stepfrom=TDT.C_Stepfrom,C_StepTo=TDT.C_StepTo,C_Comments=TDT.C_Comments,C_User=TDT.C_User,C_DateofComments=TDT.C_DateofComments FROM @TBL_99ae5d17b4b2d23811a3a33c1b7f516b TDT
							JOIN [99ae5d17-b4b2-d238-11a3-a33c1b7f516b] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,C_Stepfrom,C_StepTo,C_Comments,C_User,C_DateofComments";

                                     tempInsertQuery=@"INSERT INTO @TBL_99ae5d17b4b2d23811a3a33c1b7f516b(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,C_Stepfrom,C_StepTo,C_Comments,C_User,C_DateofComments)VALUES({0});";
                                     

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
                     

                                         case "FC9B8D2E-9EE3-436F-AF08-A774AF04D678":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_FC9B8D2E9EE3436FAF08A774AF04D678 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_d2_AdditionalID] VARCHAR(MAX)	, [MG_d2_ProjectDetailsID] VARCHAR(MAX)	, [MG_d2_AdditionalType] VARCHAR(MAX)	, [MG_d2_AdditionalName] VARCHAR(MAX)	, [MG_d2_Departmentid] VARCHAR(MAX)	, [MG_d2_DesignationID] VARCHAR(MAX)	, [MG_d2_ExternalInstituteName] VARCHAR(MAX)	, [MG_d2_ExternalFacultyName] VARCHAR(MAX)	, [MG_d2_ExternalDesignation] VARCHAR(MAX)	, [MG_d2_ExternalEmailId] VARCHAR(MAX)	, [MG_d2_ExternalContactNo] VARCHAR(MAX)	, [MG_d2_UpdatedBy] INT	, [MG_d2_UpdatedOn] DATETIME	, [MG_d2_MemberType] VARCHAR(MAX)	, [MG_EmployeeName] VARCHAR(MAX)	, [MG_EmployeeDepartment] VARCHAR(MAX)	, [MG_AdditionalTypeValue] VARCHAR(MAX)	, [MG_MemberTypeValue] VARCHAR(MAX)){0}INSERT INTO [FC9B8D2E-9EE3-436F-AF08-A774AF04D678](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d2_AdditionalID,MG_d2_ProjectDetailsID,MG_d2_AdditionalType,MG_d2_AdditionalName,MG_d2_Departmentid,MG_d2_DesignationID,MG_d2_ExternalInstituteName,MG_d2_ExternalFacultyName,MG_d2_ExternalDesignation,MG_d2_ExternalEmailId,MG_d2_ExternalContactNo,MG_d2_UpdatedBy,MG_d2_UpdatedOn,MG_d2_MemberType,MG_EmployeeName,MG_EmployeeDepartment,MG_AdditionalTypeValue,MG_MemberTypeValue)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_d2_AdditionalID,TDT.MG_d2_ProjectDetailsID,TDT.MG_d2_AdditionalType,TDT.MG_d2_AdditionalName,TDT.MG_d2_Departmentid,TDT.MG_d2_DesignationID,TDT.MG_d2_ExternalInstituteName,TDT.MG_d2_ExternalFacultyName,TDT.MG_d2_ExternalDesignation,TDT.MG_d2_ExternalEmailId,TDT.MG_d2_ExternalContactNo,TDT.MG_d2_UpdatedBy,TDT.MG_d2_UpdatedOn,TDT.MG_d2_MemberType,TDT.MG_EmployeeName,TDT.MG_EmployeeDepartment,TDT.MG_AdditionalTypeValue,TDT.MG_MemberTypeValue FROM @TBL_FC9B8D2E9EE3436FAF08A774AF04D678 TDT
							LEFT JOIN [FC9B8D2E-9EE3-436F-AF08-A774AF04D678] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MG_d2_AdditionalID=TDT.MG_d2_AdditionalID,MG_d2_ProjectDetailsID=TDT.MG_d2_ProjectDetailsID,MG_d2_AdditionalType=TDT.MG_d2_AdditionalType,MG_d2_AdditionalName=TDT.MG_d2_AdditionalName,MG_d2_Departmentid=TDT.MG_d2_Departmentid,MG_d2_DesignationID=TDT.MG_d2_DesignationID,MG_d2_ExternalInstituteName=TDT.MG_d2_ExternalInstituteName,MG_d2_ExternalFacultyName=TDT.MG_d2_ExternalFacultyName,MG_d2_ExternalDesignation=TDT.MG_d2_ExternalDesignation,MG_d2_ExternalEmailId=TDT.MG_d2_ExternalEmailId,MG_d2_ExternalContactNo=TDT.MG_d2_ExternalContactNo,MG_d2_UpdatedBy=TDT.MG_d2_UpdatedBy,MG_d2_UpdatedOn=TDT.MG_d2_UpdatedOn,MG_d2_MemberType=TDT.MG_d2_MemberType,MG_EmployeeName=TDT.MG_EmployeeName,MG_EmployeeDepartment=TDT.MG_EmployeeDepartment,MG_AdditionalTypeValue=TDT.MG_AdditionalTypeValue,MG_MemberTypeValue=TDT.MG_MemberTypeValue FROM @TBL_FC9B8D2E9EE3436FAF08A774AF04D678 TDT
							JOIN [FC9B8D2E-9EE3-436F-AF08-A774AF04D678] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d2_AdditionalID,MG_d2_ProjectDetailsID,MG_d2_AdditionalType,MG_d2_AdditionalName,MG_d2_Departmentid,MG_d2_DesignationID,MG_d2_ExternalInstituteName,MG_d2_ExternalFacultyName,MG_d2_ExternalDesignation,MG_d2_ExternalEmailId,MG_d2_ExternalContactNo,MG_d2_UpdatedBy,MG_d2_UpdatedOn,MG_d2_MemberType,MG_EmployeeName,MG_EmployeeDepartment,MG_AdditionalTypeValue,MG_MemberTypeValue";

                            tempInsertQuery=@"INSERT INTO @TBL_FC9B8D2E9EE3436FAF08A774AF04D678(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d2_AdditionalID,MG_d2_ProjectDetailsID,MG_d2_AdditionalType,MG_d2_AdditionalName,MG_d2_Departmentid,MG_d2_DesignationID,MG_d2_ExternalInstituteName,MG_d2_ExternalFacultyName,MG_d2_ExternalDesignation,MG_d2_ExternalEmailId,MG_d2_ExternalContactNo,MG_d2_UpdatedBy,MG_d2_UpdatedOn,MG_d2_MemberType,MG_EmployeeName,MG_EmployeeDepartment,MG_AdditionalTypeValue,MG_MemberTypeValue)VALUES({0});";

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

                                              case "99ae5d17-b4b2-d238-11a3-a33c1b7f516b":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_99ae5d17b4b2d23811a3a33c1b7f516b AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [C_Stepfrom] VARCHAR(MAX)	, [C_StepTo] VARCHAR(MAX)	, [C_Comments] VARCHAR(MAX)	, [C_User] VARCHAR(MAX)	, [C_DateofComments] DATETIME){0}INSERT INTO [99ae5d17-b4b2-d238-11a3-a33c1b7f516b](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,C_Stepfrom,C_StepTo,C_Comments,C_User,C_DateofComments)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.C_Stepfrom,TDT.C_StepTo,TDT.C_Comments,TDT.C_User,TDT.C_DateofComments FROM @TBL_99ae5d17b4b2d23811a3a33c1b7f516b TDT
							LEFT JOIN [99ae5d17-b4b2-d238-11a3-a33c1b7f516b] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,C_Stepfrom=TDT.C_Stepfrom,C_StepTo=TDT.C_StepTo,C_Comments=TDT.C_Comments,C_User=TDT.C_User,C_DateofComments=TDT.C_DateofComments FROM @TBL_99ae5d17b4b2d23811a3a33c1b7f516b TDT
							JOIN [99ae5d17-b4b2-d238-11a3-a33c1b7f516b] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,C_Stepfrom,C_StepTo,C_Comments,C_User,C_DateofComments";

                            tempInsertQuery=@"INSERT INTO @TBL_99ae5d17b4b2d23811a3a33c1b7f516b(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,C_Stepfrom,C_StepTo,C_Comments,C_User,C_DateofComments)VALUES({0});";

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

                                              case "D2D6E00A-B6B7-4968-BAAA-EF3D20F2BAC5":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_D2D6E00AB6B74968BAAAEF3D20F2BAC5 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_d3_DocumentName] VARCHAR(MAX)	, [MG_d3_UpdatedOn] DATETIME	, [MG_d3_DocumentProposalID] VARCHAR(MAX)	, [MG_d3_UploadDocument] VARCHAR(36)	, [MG_d3_ProposalDocumentID] VARCHAR(MAX)	, [MG_d3_UpdatedBy] INT	, [MG_d3_ProjectproposalID] VARCHAR(MAX)	, [MG_d3_MandatoryCheck] INT){0}INSERT INTO [D2D6E00A-B6B7-4968-BAAA-EF3D20F2BAC5](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d3_DocumentName,MG_d3_UpdatedOn,MG_d3_DocumentProposalID,MG_d3_UploadDocument,MG_d3_ProposalDocumentID,MG_d3_UpdatedBy,MG_d3_ProjectproposalID,MG_d3_MandatoryCheck)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_d3_DocumentName,TDT.MG_d3_UpdatedOn,TDT.MG_d3_DocumentProposalID,TDT.MG_d3_UploadDocument,TDT.MG_d3_ProposalDocumentID,TDT.MG_d3_UpdatedBy,TDT.MG_d3_ProjectproposalID,TDT.MG_d3_MandatoryCheck FROM @TBL_D2D6E00AB6B74968BAAAEF3D20F2BAC5 TDT
							LEFT JOIN [D2D6E00A-B6B7-4968-BAAA-EF3D20F2BAC5] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MG_d3_DocumentName=TDT.MG_d3_DocumentName,MG_d3_UpdatedOn=TDT.MG_d3_UpdatedOn,MG_d3_DocumentProposalID=TDT.MG_d3_DocumentProposalID,MG_d3_UploadDocument=TDT.MG_d3_UploadDocument,MG_d3_ProposalDocumentID=TDT.MG_d3_ProposalDocumentID,MG_d3_UpdatedBy=TDT.MG_d3_UpdatedBy,MG_d3_ProjectproposalID=TDT.MG_d3_ProjectproposalID,MG_d3_MandatoryCheck=TDT.MG_d3_MandatoryCheck FROM @TBL_D2D6E00AB6B74968BAAAEF3D20F2BAC5 TDT
							JOIN [D2D6E00A-B6B7-4968-BAAA-EF3D20F2BAC5] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d3_DocumentName,MG_d3_UpdatedOn,MG_d3_DocumentProposalID,MG_d3_UploadDocument,MG_d3_ProposalDocumentID,MG_d3_UpdatedBy,MG_d3_ProjectproposalID,MG_d3_MandatoryCheck";

                            tempInsertQuery=@"INSERT INTO @TBL_D2D6E00AB6B74968BAAAEF3D20F2BAC5(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d3_DocumentName,MG_d3_UpdatedOn,MG_d3_DocumentProposalID,MG_d3_UploadDocument,MG_d3_ProposalDocumentID,MG_d3_UpdatedBy,MG_d3_ProjectproposalID,MG_d3_MandatoryCheck)VALUES({0});";

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

                                              case "A3BB2140-4053-4558-9363-3BA1B526BD0A":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_A3BB21404053455893633BA1B526BD0A AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_d4_UpdatedBy] INT	, [MG_d4_DocumentId] VARCHAR(MAX)	, [MG_d4_UpdatedOn] DATETIME	, [MG_d4_ProjectproposalID] VARCHAR(MAX)	, [MG_d4_Document] VARCHAR(36)	, [MG_d4_DocumentName] VARCHAR(MAX)	, [MG_d4_Categorymapid] VARCHAR(MAX)){0}INSERT INTO [A3BB2140-4053-4558-9363-3BA1B526BD0A](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d4_UpdatedBy,MG_d4_DocumentId,MG_d4_UpdatedOn,MG_d4_ProjectproposalID,MG_d4_Document,MG_d4_DocumentName,MG_d4_Categorymapid)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_d4_UpdatedBy,TDT.MG_d4_DocumentId,TDT.MG_d4_UpdatedOn,TDT.MG_d4_ProjectproposalID,TDT.MG_d4_Document,TDT.MG_d4_DocumentName,TDT.MG_d4_Categorymapid FROM @TBL_A3BB21404053455893633BA1B526BD0A TDT
							LEFT JOIN [A3BB2140-4053-4558-9363-3BA1B526BD0A] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MG_d4_UpdatedBy=TDT.MG_d4_UpdatedBy,MG_d4_DocumentId=TDT.MG_d4_DocumentId,MG_d4_UpdatedOn=TDT.MG_d4_UpdatedOn,MG_d4_ProjectproposalID=TDT.MG_d4_ProjectproposalID,MG_d4_Document=TDT.MG_d4_Document,MG_d4_DocumentName=TDT.MG_d4_DocumentName,MG_d4_Categorymapid=TDT.MG_d4_Categorymapid FROM @TBL_A3BB21404053455893633BA1B526BD0A TDT
							JOIN [A3BB2140-4053-4558-9363-3BA1B526BD0A] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d4_UpdatedBy,MG_d4_DocumentId,MG_d4_UpdatedOn,MG_d4_ProjectproposalID,MG_d4_Document,MG_d4_DocumentName,MG_d4_Categorymapid";

                            tempInsertQuery=@"INSERT INTO @TBL_A3BB21404053455893633BA1B526BD0A(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d4_UpdatedBy,MG_d4_DocumentId,MG_d4_UpdatedOn,MG_d4_ProjectproposalID,MG_d4_Document,MG_d4_DocumentName,MG_d4_Categorymapid)VALUES({0});";

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
public class ISpaceB3A493374C4B42EC9F9B1C4C8B4E2E13 : VirtualForm
{
IISpace iSpace = new ISpace();
AcDataISpaceB3A493374C4B42EC9F9B1C4C8B4E2E13 acdataIspaceB3A493374C4B42EC9F9B1C4C8B4E2E13=new AcDataISpaceB3A493374C4B42EC9F9B1C4C8B4E2E13();
private void SubscribeFormEvents_root(ref Dictionary<string, ServiceElementData> ISpace)
{
try
{
base.WriteDebugInfo(@"Root-OnAfterFormLoad");
ISpace["M_DepartmentId"].Visible="false";ISpace["MF_d1_Currency"].Visible="false";ISpace["M_DesignationId"].Visible="false";ISpace["MF_d1_EmployeeBasicInfoId"].Visible="false";
base.WriteDebugInfo(@"ISpace[""M_DepartmentId""].Visible=""false"";ISpace[""MF_d1_Currency""].Visible=""false"";ISpace[""M_DesignationId""].Visible=""false"";ISpace[""MF_d1_EmployeeBasicInfoId""].Visible=""false"";");
ISpace["MFG_d2_DesignationID"].Visible="false";ISpace["MFG_d2_ExternalInstituteName"].Visible="false";ISpace["MFG_d2_ExternalEmailId"].Visible="false";ISpace["MFG_d2_ExternalContactNo"].Visible="false";ISpace["MFG_d2_ExternalDesignation"].Visible="false";ISpace["MFG_d2_ExternalFacultyName"].Visible="false";ISpace["MFG_d2_AdditionalName"].Visible="false";ISpace["MFG_d2_Departmentid"].Visible="false";ISpace["MFG_d2_AdditionalType"].Visible="false";
base.WriteDebugInfo(@"ISpace[""MFG_d2_DesignationID""].Visible=""false"";ISpace[""MFG_d2_ExternalInstituteName""].Visible=""false"";ISpace[""MFG_d2_ExternalEmailId""].Visible=""false"";ISpace[""MFG_d2_ExternalContactNo""].Visible=""false"";ISpace[""MFG_d2_ExternalDesignation""].Visible=""false"";ISpace[""MFG_d2_ExternalFacultyName""].Visible=""false"";ISpace[""MFG_d2_AdditionalName""].Visible=""false"";ISpace[""MFG_d2_Departmentid""].Visible=""false"";ISpace[""MFG_d2_AdditionalType""].Visible=""false"";");
if(ISpace["FormVersionId"].Value=="FA963D46-2D52-4A3E-8550-E878A2504252")
{
ISpace["UI_InvisibleRow"].Visible="false";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""FA963D46-2D52-4A3E-8550-E878A2504252"")
{
ISpace[""UI_InvisibleRow""].Visible=""false"";
}");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySource0a52bb10821c0a9a8ae2ec075fba6a8e =GetQueryExpressionDataSource("0a52bb10-821c-0a9a-8ae2-ec075fba6a8e");

DataTable result0a52bb10821c0a9a8ae2ec075fba6a8e=iSpace.SetGridDataSource(querySource0a52bb10821c0a9a8ae2ec075fba6a8e, _objectFactory.GetGridRPP("ProposalDocuments"),@"EXEC [GetProjectProposalDetailsLoad] 4,''");

iSpace.InsertGridBindDetails("ProposalDocuments","11",querySource0a52bb10821c0a9a8ae2ec075fba6a8e,"EXEC [GetProjectProposalDetailsLoad] 4,''",_objectFactory.GetGridRPP("ProposalDocuments"));

base.WriteDebugInfo(@"var querySource0a52bb10821c0a9a8ae2ec075fba6a8e =GetQueryExpressionDataSource(""0a52bb10-821c-0a9a-8ae2-ec075fba6a8e"");DataTable result0a52bb10821c0a9a8ae2ec075fba6a8e=iSpace.SetGridDataSource(querySource0a52bb10821c0a9a8ae2ec075fba6a8e, _objectFactory.GetGridRPP(""ProposalDocuments""),@""EXEC [GetProjectProposalDetailsLoad] 4,''"");iSpace.InsertGridBindDetails(""ProposalDocuments"",""11"",querySource0a52bb10821c0a9a8ae2ec075fba6a8e,""EXEC [GetProjectProposalDetailsLoad] 4,''"",_objectFactory.GetGridRPP(""ProposalDocuments""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> resultef1f2ec4a6cbdd231f52fd0b0d03ba57=acdataIspaceB3A493374C4B42EC9F9B1C4C8B4E2E13.GetQueryExpressionBindings("ef1f2ec4-a6cb-dd23-1f52-fd0b0d03ba57");
iSpace.SetGridData(result0a52bb10821c0a9a8ae2ec075fba6a8e,resultef1f2ec4a6cbdd231f52fd0b0d03ba57,"ProposalDocuments",ref ISpace);
iSpace.UpdateGridBindDetails("ProposalDocuments",resultef1f2ec4a6cbdd231f52fd0b0d03ba57);
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC [sp_GetCurrentFinancialYear]");

var querySource9ea11c91985f03d9613379e184c5089c =GetQueryExpressionDataSource("9ea11c91-985f-03d9-6133-79e184c5089c");
Dictionary<short,object> result9ea11c91985f03d9613379e184c5089c=iSpace.ExecuteQuery(querySource9ea11c91985f03d9613379e184c5089c,@"EXEC [sp_GetCurrentFinancialYear]",false);

base.WriteDebugInfo(@"var querySource9ea11c91985f03d9613379e184c5089c =GetQueryExpressionDataSource(""9ea11c91-985f-03d9-6133-79e184c5089c"");Dictionary<short,object> result9ea11c91985f03d9613379e184c5089c=iSpace.ExecuteQuery(querySource9ea11c91985f03d9613379e184c5089c,@""EXEC [sp_GetCurrentFinancialYear]"",false);");
base.WriteDebugInfo(@"");

if((result9ea11c91985f03d9613379e184c5089c!=null) && (result9ea11c91985f03d9613379e184c5089c.Count!=0))
{
if(result9ea11c91985f03d9613379e184c5089c.ContainsKey(0))
ISpace["MF_d1_FinancialYearID"].Value = result9ea11c91985f03d9613379e184c5089c[0];
}
else{
ISpace["MF_d1_FinancialYearID"].Value = null;
}
}
ISpace["MF_d1_FinancialYearID"].Man=true;ISpace["MF_d1_ProjectName"].Man=true;ISpace["MF_d1_ProjectCategoryID"].Man=true;ISpace["MF_d1_Currency"].Man=true;ISpace["MF_d1_ProjectBudget"].Man=true;ISpace["MF_d1_ProjectType"].Man=true;ISpace["MF_d1_SectorID"].Man=true;ISpace["MF_d1_FundingAgency"].Man=true;
base.WriteDebugInfo(@"ISpace[""MF_d1_FinancialYearID""].Man=true;ISpace[""MF_d1_ProjectName""].Man=true;ISpace[""MF_d1_ProjectCategoryID""].Man=true;ISpace[""MF_d1_Currency""].Man=true;ISpace[""MF_d1_ProjectBudget""].Man=true;ISpace[""MF_d1_ProjectType""].Man=true;ISpace[""MF_d1_SectorID""].Man=true;ISpace[""MF_d1_FundingAgency""].Man=true;");




ISpace["Comments"].Man=true;
base.WriteDebugInfo(@"ISpace[""Comments""].Man=true;");
ISpace["MF_d1_ProjectStatus"].Value="2";
base.WriteDebugInfo(@"ISpace[""MF_d1_ProjectStatus""].Value=""2"";");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC GetEmployeeATOMDetails '@@gv_UserId'");

var querySource282f122c129c3f662802e500377eb9b5 =GetQueryExpressionDataSource("282f122c-129c-3f66-2802-e500377eb9b5");
Dictionary<short,object> result282f122c129c3f662802e500377eb9b5=iSpace.ExecuteQuery(querySource282f122c129c3f662802e500377eb9b5,@"EXEC GetEmployeeATOMDetails '" + ISpace["gv_userid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource282f122c129c3f662802e500377eb9b5 =GetQueryExpressionDataSource(""282f122c-129c-3f66-2802-e500377eb9b5"");Dictionary<short,object> result282f122c129c3f662802e500377eb9b5=iSpace.ExecuteQuery(querySource282f122c129c3f662802e500377eb9b5,@""EXEC GetEmployeeATOMDetails '"" + ISpace[""gv_userid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result282f122c129c3f662802e500377eb9b5!=null) && (result282f122c129c3f662802e500377eb9b5.Count!=0))
{
if(result282f122c129c3f662802e500377eb9b5.ContainsKey(20))
ISpace["M_DeptCode"].Value = result282f122c129c3f662802e500377eb9b5[20];
if(result282f122c129c3f662802e500377eb9b5.ContainsKey(4))
ISpace["M_DepartmentId"].Value = result282f122c129c3f662802e500377eb9b5[4];
if(result282f122c129c3f662802e500377eb9b5.ContainsKey(3))
ISpace["MF_d1_DepartmentID"].Value = result282f122c129c3f662802e500377eb9b5[3];
if(result282f122c129c3f662802e500377eb9b5.ContainsKey(2))
ISpace["MF_d1_Designation"].Value = result282f122c129c3f662802e500377eb9b5[2];
if(result282f122c129c3f662802e500377eb9b5.ContainsKey(0))
ISpace["M_EMPCode"].Value = result282f122c129c3f662802e500377eb9b5[0];
if(result282f122c129c3f662802e500377eb9b5.ContainsKey(19))
ISpace["MF_d1_PrincipalInvestigator"].Value = result282f122c129c3f662802e500377eb9b5[19];
if(result282f122c129c3f662802e500377eb9b5.ContainsKey(21))
ISpace["M_DesignationId"].Value = result282f122c129c3f662802e500377eb9b5[21];
if(result282f122c129c3f662802e500377eb9b5.ContainsKey(8))
ISpace["MF_d1_EmployeeBasicInfoId"].Value = result282f122c129c3f662802e500377eb9b5[8];
}
else{
ISpace["M_DeptCode"].Value = null;ISpace["M_DepartmentId"].Value = null;ISpace["MF_d1_DepartmentID"].Value = null;ISpace["MF_d1_Designation"].Value = null;ISpace["M_EMPCode"].Value = null;ISpace["MF_d1_PrincipalInvestigator"].Value = null;ISpace["M_DesignationId"].Value = null;ISpace["MF_d1_EmployeeBasicInfoId"].Value = null;
}
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mg_d3_uploaddocument (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MG_d3_UploadDocument-OnChange");
if(IsNullOrEmpty(ISpace["MG_d3_UploadDocument"].Value))
{
base.WriteDebugInfo(@"if(IsNullOrEmpty(ISpace[""MG_d3_UploadDocument""].Value))");
ISpace["MG_d3_MandatoryCheck"].Value=0;
base.WriteDebugInfo(@"ISpace[""MG_d3_MandatoryCheck""].Value=0;");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MG_d3_MandatoryCheck"].Value=0;
base.WriteDebugInfo(@"ISpace[""MG_d3_MandatoryCheck""].Value=0;");
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_save_copidetails (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Save_CopiDetails-OnClick");
if(ISpace["growid"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""growid""].Value=="""")");

var querySource6C11211E63544E6499A1D591D85CCC41 =GetQueryExpressionDataSource("6C11211E-6354-4E64-99A1-D591D85CCC41");

DataTable result6C11211E63544E6499A1D591D85CCC41=iSpace.SetGridDataSource(querySource6C11211E63544E6499A1D591D85CCC41, _objectFactory.GetGridRPP("CopiDetails"),@"EXEC [AddFormGridDataFC9B8D2E-9EE3-436F-AF08-A774AF04D678] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','FC9B8D2E-9EE3-436F-AF08-A774AF04D678','" + ISpace["growid"].Value + @"'," + ISpace["CopiDetails_Sequence"].Value + @",'" + ISpace["MFG_d2_AdditionalID"].Value + @"','" + ISpace["MF_d1_ProjectProposalID"].Value + @"','" + ISpace["MFG_d2_AdditionalType"].Value + @"','" + ISpace["MFG_d2_AdditionalName"].Value + @"','" + ISpace["MFG_d2_Departmentid"].Value + @"','" + ISpace["MFG_d2_DesignationID"].Value + @"','" + ISpace["MFG_d2_ExternalInstituteName"].Value + @"','" + ISpace["MFG_d2_ExternalFacultyName"].Value + @"','" + ISpace["MFG_d2_ExternalDesignation"].Value + @"','" + ISpace["MFG_d2_ExternalEmailId"].Value + @"','" + ISpace["MFG_d2_ExternalContactNo"].Value + @"'," + ISpace["MFG_d2_UpdatedBy"].Value + @",'" + ISpace["MFG_d2_UpdatedOn"].Value + @"','" + ISpace["MFG_d2_MemberType"].Value + @"'");

iSpace.InsertGridBindDetails("CopiDetails","11",querySource6C11211E63544E6499A1D591D85CCC41,"EXEC [AddFormGridDataFC9B8D2E-9EE3-436F-AF08-A774AF04D678] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','FC9B8D2E-9EE3-436F-AF08-A774AF04D678','" + ISpace["growid"].Value + @"'," + ISpace["CopiDetails_Sequence"].Value + @",'" + ISpace["MFG_d2_AdditionalID"].Value + @"','" + ISpace["MF_d1_ProjectProposalID"].Value + @"','" + ISpace["MFG_d2_AdditionalType"].Value + @"','" + ISpace["MFG_d2_AdditionalName"].Value + @"','" + ISpace["MFG_d2_Departmentid"].Value + @"','" + ISpace["MFG_d2_DesignationID"].Value + @"','" + ISpace["MFG_d2_ExternalInstituteName"].Value + @"','" + ISpace["MFG_d2_ExternalFacultyName"].Value + @"','" + ISpace["MFG_d2_ExternalDesignation"].Value + @"','" + ISpace["MFG_d2_ExternalEmailId"].Value + @"','" + ISpace["MFG_d2_ExternalContactNo"].Value + @"'," + ISpace["MFG_d2_UpdatedBy"].Value + @",'" + ISpace["MFG_d2_UpdatedOn"].Value + @"','" + ISpace["MFG_d2_MemberType"].Value + @"'",_objectFactory.GetGridRPP("CopiDetails"));

base.WriteDebugInfo(@"var querySource6C11211E63544E6499A1D591D85CCC41 =GetQueryExpressionDataSource(""6C11211E-6354-4E64-99A1-D591D85CCC41"");DataTable result6C11211E63544E6499A1D591D85CCC41=iSpace.SetGridDataSource(querySource6C11211E63544E6499A1D591D85CCC41, _objectFactory.GetGridRPP(""CopiDetails""),@""EXEC [AddFormGridDataFC9B8D2E-9EE3-436F-AF08-A774AF04D678] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','FC9B8D2E-9EE3-436F-AF08-A774AF04D678','"" + ISpace[""growid""].Value + @""',"" + ISpace[""CopiDetails_Sequence""].Value + @"",'"" + ISpace[""MFG_d2_AdditionalID""].Value + @""','"" + ISpace[""MF_d1_ProjectProposalID""].Value + @""','"" + ISpace[""MFG_d2_AdditionalType""].Value + @""','"" + ISpace[""MFG_d2_AdditionalName""].Value + @""','"" + ISpace[""MFG_d2_Departmentid""].Value + @""','"" + ISpace[""MFG_d2_DesignationID""].Value + @""','"" + ISpace[""MFG_d2_ExternalInstituteName""].Value + @""','"" + ISpace[""MFG_d2_ExternalFacultyName""].Value + @""','"" + ISpace[""MFG_d2_ExternalDesignation""].Value + @""','"" + ISpace[""MFG_d2_ExternalEmailId""].Value + @""','"" + ISpace[""MFG_d2_ExternalContactNo""].Value + @""',"" + ISpace[""MFG_d2_UpdatedBy""].Value + @"",'"" + ISpace[""MFG_d2_UpdatedOn""].Value + @""','"" + ISpace[""MFG_d2_MemberType""].Value + @""'"");iSpace.InsertGridBindDetails(""CopiDetails"",""11"",querySource6C11211E63544E6499A1D591D85CCC41,""EXEC [AddFormGridDataFC9B8D2E-9EE3-436F-AF08-A774AF04D678] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','FC9B8D2E-9EE3-436F-AF08-A774AF04D678','"" + ISpace[""growid""].Value + @""',"" + ISpace[""CopiDetails_Sequence""].Value + @"",'"" + ISpace[""MFG_d2_AdditionalID""].Value + @""','"" + ISpace[""MF_d1_ProjectProposalID""].Value + @""','"" + ISpace[""MFG_d2_AdditionalType""].Value + @""','"" + ISpace[""MFG_d2_AdditionalName""].Value + @""','"" + ISpace[""MFG_d2_Departmentid""].Value + @""','"" + ISpace[""MFG_d2_DesignationID""].Value + @""','"" + ISpace[""MFG_d2_ExternalInstituteName""].Value + @""','"" + ISpace[""MFG_d2_ExternalFacultyName""].Value + @""','"" + ISpace[""MFG_d2_ExternalDesignation""].Value + @""','"" + ISpace[""MFG_d2_ExternalEmailId""].Value + @""','"" + ISpace[""MFG_d2_ExternalContactNo""].Value + @""',"" + ISpace[""MFG_d2_UpdatedBy""].Value + @"",'"" + ISpace[""MFG_d2_UpdatedOn""].Value + @""','"" + ISpace[""MFG_d2_MemberType""].Value + @""'"",_objectFactory.GetGridRPP(""CopiDetails""));");
base.WriteDebugInfo(@"EXEC [AddFormGridDataFC9B8D2E-9EE3-436F-AF08-A774AF04D678] '@@gv_InstanceId','@@gv_ActivityMapId','FC9B8D2E-9EE3-436F-AF08-A774AF04D678','#growid',#CopiDetails_Sequence,'#MFG_d2_AdditionalID','#MFG_d2_ProjectDetailsID','#MFG_d2_AdditionalType','#MFG_d2_AdditionalName','#MFG_d2_Departmentid','#MFG_d2_DesignationID','#MFG_d2_ExternalInstituteName','#MFG_d2_ExternalFacultyName','#MFG_d2_ExternalDesignation','#MFG_d2_ExternalEmailId','#MFG_d2_ExternalContactNo',#MFG_d2_UpdatedBy,'#MFG_d2_UpdatedOn'");


List<Triplet<string, short, short?>> result2FAC01E585404425AD0142973E87B3C5=acdataIspaceB3A493374C4B42EC9F9B1C4C8B4E2E13.GetQueryExpressionBindings("2FAC01E5-8540-4425-AD01-42973E87B3C5");
iSpace.SetGridData(result6C11211E63544E6499A1D591D85CCC41,result2FAC01E585404425AD0142973E87B3C5,"CopiDetails",ref ISpace);
iSpace.UpdateGridBindDetails("CopiDetails",result2FAC01E585404425AD0142973E87B3C5);
}
else
{
base.WriteDebugInfo(@"else");

var querySource401A9D348FD64AD08D6DBFDA8D331663 =GetQueryExpressionDataSource("401A9D34-8FD6-4AD0-8D6D-BFDA8D331663");

DataTable result401A9D348FD64AD08D6DBFDA8D331663=iSpace.SetGridDataSource(querySource401A9D348FD64AD08D6DBFDA8D331663, _objectFactory.GetGridRPP("CopiDetails"),@"EXEC [AddFormGridDataFC9B8D2E-9EE3-436F-AF08-A774AF04D678] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','FC9B8D2E-9EE3-436F-AF08-A774AF04D678','" + ISpace["growid"].Value + @"'," + ISpace["CopiDetails_Sequence"].Value + @",'" + ISpace["MFG_d2_AdditionalID"].Value + @"','" + ISpace["MF_d1_ProjectProposalID"].Value + @"','" + ISpace["MFG_d2_AdditionalType"].Value + @"','" + ISpace["MFG_d2_AdditionalName"].Value + @"','" + ISpace["MFG_d2_Departmentid"].Value + @"','" + ISpace["MFG_d2_DesignationID"].Value + @"','" + ISpace["MFG_d2_ExternalInstituteName"].Value + @"','" + ISpace["MFG_d2_ExternalFacultyName"].Value + @"','" + ISpace["MFG_d2_ExternalDesignation"].Value + @"','" + ISpace["MFG_d2_ExternalEmailId"].Value + @"','" + ISpace["MFG_d2_ExternalContactNo"].Value + @"'," + ISpace["MFG_d2_UpdatedBy"].Value + @",'" + ISpace["MFG_d2_UpdatedOn"].Value + @"','" + ISpace["MFG_d2_MemberType"].Value + @"'");

iSpace.InsertGridBindDetails("CopiDetails","11",querySource401A9D348FD64AD08D6DBFDA8D331663,"EXEC [AddFormGridDataFC9B8D2E-9EE3-436F-AF08-A774AF04D678] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','FC9B8D2E-9EE3-436F-AF08-A774AF04D678','" + ISpace["growid"].Value + @"'," + ISpace["CopiDetails_Sequence"].Value + @",'" + ISpace["MFG_d2_AdditionalID"].Value + @"','" + ISpace["MF_d1_ProjectProposalID"].Value + @"','" + ISpace["MFG_d2_AdditionalType"].Value + @"','" + ISpace["MFG_d2_AdditionalName"].Value + @"','" + ISpace["MFG_d2_Departmentid"].Value + @"','" + ISpace["MFG_d2_DesignationID"].Value + @"','" + ISpace["MFG_d2_ExternalInstituteName"].Value + @"','" + ISpace["MFG_d2_ExternalFacultyName"].Value + @"','" + ISpace["MFG_d2_ExternalDesignation"].Value + @"','" + ISpace["MFG_d2_ExternalEmailId"].Value + @"','" + ISpace["MFG_d2_ExternalContactNo"].Value + @"'," + ISpace["MFG_d2_UpdatedBy"].Value + @",'" + ISpace["MFG_d2_UpdatedOn"].Value + @"','" + ISpace["MFG_d2_MemberType"].Value + @"'",_objectFactory.GetGridRPP("CopiDetails"));

base.WriteDebugInfo(@"var querySource401A9D348FD64AD08D6DBFDA8D331663 =GetQueryExpressionDataSource(""401A9D34-8FD6-4AD0-8D6D-BFDA8D331663"");DataTable result401A9D348FD64AD08D6DBFDA8D331663=iSpace.SetGridDataSource(querySource401A9D348FD64AD08D6DBFDA8D331663, _objectFactory.GetGridRPP(""CopiDetails""),@""EXEC [AddFormGridDataFC9B8D2E-9EE3-436F-AF08-A774AF04D678] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','FC9B8D2E-9EE3-436F-AF08-A774AF04D678','"" + ISpace[""growid""].Value + @""',"" + ISpace[""CopiDetails_Sequence""].Value + @"",'"" + ISpace[""MFG_d2_AdditionalID""].Value + @""','"" + ISpace[""MF_d1_ProjectProposalID""].Value + @""','"" + ISpace[""MFG_d2_AdditionalType""].Value + @""','"" + ISpace[""MFG_d2_AdditionalName""].Value + @""','"" + ISpace[""MFG_d2_Departmentid""].Value + @""','"" + ISpace[""MFG_d2_DesignationID""].Value + @""','"" + ISpace[""MFG_d2_ExternalInstituteName""].Value + @""','"" + ISpace[""MFG_d2_ExternalFacultyName""].Value + @""','"" + ISpace[""MFG_d2_ExternalDesignation""].Value + @""','"" + ISpace[""MFG_d2_ExternalEmailId""].Value + @""','"" + ISpace[""MFG_d2_ExternalContactNo""].Value + @""',"" + ISpace[""MFG_d2_UpdatedBy""].Value + @"",'"" + ISpace[""MFG_d2_UpdatedOn""].Value + @""','"" + ISpace[""MFG_d2_MemberType""].Value + @""'"");iSpace.InsertGridBindDetails(""CopiDetails"",""11"",querySource401A9D348FD64AD08D6DBFDA8D331663,""EXEC [AddFormGridDataFC9B8D2E-9EE3-436F-AF08-A774AF04D678] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','FC9B8D2E-9EE3-436F-AF08-A774AF04D678','"" + ISpace[""growid""].Value + @""',"" + ISpace[""CopiDetails_Sequence""].Value + @"",'"" + ISpace[""MFG_d2_AdditionalID""].Value + @""','"" + ISpace[""MF_d1_ProjectProposalID""].Value + @""','"" + ISpace[""MFG_d2_AdditionalType""].Value + @""','"" + ISpace[""MFG_d2_AdditionalName""].Value + @""','"" + ISpace[""MFG_d2_Departmentid""].Value + @""','"" + ISpace[""MFG_d2_DesignationID""].Value + @""','"" + ISpace[""MFG_d2_ExternalInstituteName""].Value + @""','"" + ISpace[""MFG_d2_ExternalFacultyName""].Value + @""','"" + ISpace[""MFG_d2_ExternalDesignation""].Value + @""','"" + ISpace[""MFG_d2_ExternalEmailId""].Value + @""','"" + ISpace[""MFG_d2_ExternalContactNo""].Value + @""',"" + ISpace[""MFG_d2_UpdatedBy""].Value + @"",'"" + ISpace[""MFG_d2_UpdatedOn""].Value + @""','"" + ISpace[""MFG_d2_MemberType""].Value + @""'"",_objectFactory.GetGridRPP(""CopiDetails""));");
base.WriteDebugInfo(@"EXEC [UpdateFormGridDataFC9B8D2E-9EE3-436F-AF08-A774AF04D678] '@@gv_InstanceId','@@gv_ActivityMapId','FC9B8D2E-9EE3-436F-AF08-A774AF04D678','#growid',#CopiDetails_Sequence,'#MFG_d2_AdditionalID','#MFG_d2_ProjectDetailsID','#MFG_d2_AdditionalType','#MFG_d2_AdditionalName','#MFG_d2_Departmentid','#MFG_d2_DesignationID','#MFG_d2_ExternalInstituteName','#MFG_d2_ExternalFacultyName','#MFG_d2_ExternalDesignation','#MFG_d2_ExternalEmailId','#MFG_d2_ExternalContactNo',#MFG_d2_UpdatedBy,'#MFG_d2_UpdatedO");


List<Triplet<string, short, short?>> resultBE604E66309D4989879C431B3984B4B4=acdataIspaceB3A493374C4B42EC9F9B1C4C8B4E2E13.GetQueryExpressionBindings("BE604E66-309D-4989-879C-431B3984B4B4");
iSpace.SetGridData(result401A9D348FD64AD08D6DBFDA8D331663,resultBE604E66309D4989879C431B3984B4B4,"CopiDetails",ref ISpace);
iSpace.UpdateGridBindDetails("CopiDetails",resultBE604E66309D4989879C431B3984B4B4);
}
ISpace["growid"].Value="";
base.WriteDebugInfo(@"ISpace[""growid""].Value="""";");
ISpace["MFG_d2_AdditionalID"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d2_AdditionalID""].Value="""";");
ISpace["MFG_d2_ProjectDetailsID"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d2_ProjectDetailsID""].Value="""";");
ISpace["MFG_d2_AdditionalType"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d2_AdditionalType""].Value="""";");
ISpace["MFG_d2_AdditionalName"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d2_AdditionalName""].Value="""";");
ISpace["MFG_d2_Departmentid"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d2_Departmentid""].Value="""";");
ISpace["MFG_d2_DesignationID"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d2_DesignationID""].Value="""";");
ISpace["MFG_d2_ExternalInstituteName"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d2_ExternalInstituteName""].Value="""";");
ISpace["MFG_d2_ExternalFacultyName"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d2_ExternalFacultyName""].Value="""";");
ISpace["MFG_d2_ExternalDesignation"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d2_ExternalDesignation""].Value="""";");
ISpace["MFG_d2_ExternalEmailId"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d2_ExternalEmailId""].Value="""";");
ISpace["MFG_d2_ExternalContactNo"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d2_ExternalContactNo""].Value="""";");
ISpace["MFG_d2_UpdatedBy"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d2_UpdatedBy""].Value="""";");
ISpace["MFG_d2_UpdatedOn"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d2_UpdatedOn""].Value="""";");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_copi_no (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"COPI_No-OnClick");
ISpace["UI_DeleteDialog"].HideDialog=true;;
base.WriteDebugInfo(@"ISpace[""UI_DeleteDialog""].HideDialog=true;;");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_copi_yes (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"COPI_Yes-OnClick");

var querySource46a6879a4dfd54d138c96438be62af60 =GetQueryExpressionDataSource("46a6879a-4dfd-54d1-38c9-6438be62af60");

DataTable result46a6879a4dfd54d138c96438be62af60=iSpace.SetGridDataSource(querySource46a6879a4dfd54d138c96438be62af60, _objectFactory.GetGridRPP("CopiDetails"),@"Exec [DeleteCoPiDetails] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["growid"].Value + @"'");

iSpace.InsertGridBindDetails("CopiDetails","11",querySource46a6879a4dfd54d138c96438be62af60,"Exec [DeleteCoPiDetails] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["growid"].Value + @"'",_objectFactory.GetGridRPP("CopiDetails"));

base.WriteDebugInfo(@"var querySource46a6879a4dfd54d138c96438be62af60 =GetQueryExpressionDataSource(""46a6879a-4dfd-54d1-38c9-6438be62af60"");DataTable result46a6879a4dfd54d138c96438be62af60=iSpace.SetGridDataSource(querySource46a6879a4dfd54d138c96438be62af60, _objectFactory.GetGridRPP(""CopiDetails""),@""Exec [DeleteCoPiDetails] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""growid""].Value + @""'"");iSpace.InsertGridBindDetails(""CopiDetails"",""11"",querySource46a6879a4dfd54d138c96438be62af60,""Exec [DeleteCoPiDetails] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""growid""].Value + @""'"",_objectFactory.GetGridRPP(""CopiDetails""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> resulte94499bc4a5f3d1caf8ae6389d08f460=acdataIspaceB3A493374C4B42EC9F9B1C4C8B4E2E13.GetQueryExpressionBindings("e94499bc-4a5f-3d1c-af8a-e6389d08f460");
iSpace.SetGridData(result46a6879a4dfd54d138c96438be62af60,resulte94499bc4a5f3d1caf8ae6389d08f460,"CopiDetails",ref ISpace);
iSpace.UpdateGridBindDetails("CopiDetails",resulte94499bc4a5f3d1caf8ae6389d08f460);
ISpace["Message"].Value=@"Success:Deleted Successfully";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Success:Deleted Successfully"";");
ISpace["UI_DeleteDialog"].HideDialog=true;;
base.WriteDebugInfo(@"ISpace[""UI_DeleteDialog""].HideDialog=true;;");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mf_d1_projectcategoryid (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MF_d1_ProjectCategoryID-OnChange");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC GetProjectProposalDetailsLoad 12,'','#MF_d1_ProjectCategoryID'");

var querySourcef9231ef6c778e031aeb22f8be33e4ca2 =GetQueryExpressionDataSource("f9231ef6-c778-e031-aeb2-2f8be33e4ca2");
Dictionary<short,object> resultf9231ef6c778e031aeb22f8be33e4ca2=iSpace.ExecuteQuery(querySourcef9231ef6c778e031aeb22f8be33e4ca2,@"EXEC GetProjectProposalDetailsLoad 12,'','" + ISpace["MF_d1_ProjectCategoryID"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourcef9231ef6c778e031aeb22f8be33e4ca2 =GetQueryExpressionDataSource(""f9231ef6-c778-e031-aeb2-2f8be33e4ca2"");Dictionary<short,object> resultf9231ef6c778e031aeb22f8be33e4ca2=iSpace.ExecuteQuery(querySourcef9231ef6c778e031aeb22f8be33e4ca2,@""EXEC GetProjectProposalDetailsLoad 12,'','"" + ISpace[""MF_d1_ProjectCategoryID""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultf9231ef6c778e031aeb22f8be33e4ca2!=null) && (resultf9231ef6c778e031aeb22f8be33e4ca2.Count!=0))
{
if(resultf9231ef6c778e031aeb22f8be33e4ca2.ContainsKey(1))
ISpace["MF_d1_ProjectCategoryCode"].Value = resultf9231ef6c778e031aeb22f8be33e4ca2[1];
}
else{
ISpace["MF_d1_ProjectCategoryCode"].Value = null;
}
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_edit_copidetails (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Edit_CopiDetails-OnClick");
ISpace["growid"].Value=ISpace["CopiDetails_RowId"].Value;
base.WriteDebugInfo(@"ISpace[""growid""].Value=ISpace[""CopiDetails_RowId""].Value;");
base.WriteDebugInfo(@"EXEC [LoadFormGridDataFC9B8D2E-9EE3-436F-AF08-A774AF04D678] '@@gv_InstanceId','@@gv_ActivityMapId','FC9B8D2E-9EE3-436F-AF08-A774AF04D678','#growid',#CopiDetails_Sequence");

var querySource4D70F9F762964C9DBE1764DD6765B7EB =GetQueryExpressionDataSource("4D70F9F7-6296-4C9D-BE17-64DD6765B7EB");
Dictionary<short,object> result4D70F9F762964C9DBE1764DD6765B7EB=iSpace.ExecuteQuery(querySource4D70F9F762964C9DBE1764DD6765B7EB,@"EXEC [LoadFormGridDataFC9B8D2E-9EE3-436F-AF08-A774AF04D678] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','FC9B8D2E-9EE3-436F-AF08-A774AF04D678','" + ISpace["growid"].Value + @"'," + ISpace["CopiDetails_Sequence"].Value + @"",false);

base.WriteDebugInfo(@"var querySource4D70F9F762964C9DBE1764DD6765B7EB =GetQueryExpressionDataSource(""4D70F9F7-6296-4C9D-BE17-64DD6765B7EB"");Dictionary<short,object> result4D70F9F762964C9DBE1764DD6765B7EB=iSpace.ExecuteQuery(querySource4D70F9F762964C9DBE1764DD6765B7EB,@""EXEC [LoadFormGridDataFC9B8D2E-9EE3-436F-AF08-A774AF04D678] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','FC9B8D2E-9EE3-436F-AF08-A774AF04D678','"" + ISpace[""growid""].Value + @""',"" + ISpace[""CopiDetails_Sequence""].Value + @"""",false);");
base.WriteDebugInfo(@"EXEC [LoadFormGridDataFC9B8D2E-9EE3-436F-AF08-A774AF04D678] '@@gv_InstanceId','@@gv_ActivityMapId','FC9B8D2E-9EE3-436F-AF08-A774AF04D678','#growid',#CopiDetails_Sequence");

if((result4D70F9F762964C9DBE1764DD6765B7EB!=null) && (result4D70F9F762964C9DBE1764DD6765B7EB.Count!=0))
{
if(result4D70F9F762964C9DBE1764DD6765B7EB.ContainsKey(12))
ISpace["MFG_d2_UpdatedOn"].Value = result4D70F9F762964C9DBE1764DD6765B7EB[12];
if(result4D70F9F762964C9DBE1764DD6765B7EB.ContainsKey(14))
ISpace["MFG_d2_MemberType"].Value = result4D70F9F762964C9DBE1764DD6765B7EB[14];
if(result4D70F9F762964C9DBE1764DD6765B7EB.ContainsKey(3))
ISpace["MFG_d2_AdditionalName"].Value = result4D70F9F762964C9DBE1764DD6765B7EB[3];
if(result4D70F9F762964C9DBE1764DD6765B7EB.ContainsKey(4))
ISpace["MFG_d2_Departmentid"].Value = result4D70F9F762964C9DBE1764DD6765B7EB[4];
if(result4D70F9F762964C9DBE1764DD6765B7EB.ContainsKey(2))
ISpace["MFG_d2_AdditionalType"].Value = result4D70F9F762964C9DBE1764DD6765B7EB[2];
if(result4D70F9F762964C9DBE1764DD6765B7EB.ContainsKey(11))
ISpace["MFG_d2_UpdatedBy"].Value = result4D70F9F762964C9DBE1764DD6765B7EB[11];
if(result4D70F9F762964C9DBE1764DD6765B7EB.ContainsKey(8))
ISpace["MFG_d2_ExternalDesignation"].Value = result4D70F9F762964C9DBE1764DD6765B7EB[8];
if(result4D70F9F762964C9DBE1764DD6765B7EB.ContainsKey(7))
ISpace["MFG_d2_ExternalFacultyName"].Value = result4D70F9F762964C9DBE1764DD6765B7EB[7];
if(result4D70F9F762964C9DBE1764DD6765B7EB.ContainsKey(5))
ISpace["MFG_d2_DesignationID"].Value = result4D70F9F762964C9DBE1764DD6765B7EB[5];
if(result4D70F9F762964C9DBE1764DD6765B7EB.ContainsKey(6))
ISpace["MFG_d2_ExternalInstituteName"].Value = result4D70F9F762964C9DBE1764DD6765B7EB[6];
if(result4D70F9F762964C9DBE1764DD6765B7EB.ContainsKey(1))
ISpace["MFG_d2_ProjectDetailsID"].Value = result4D70F9F762964C9DBE1764DD6765B7EB[1];
if(result4D70F9F762964C9DBE1764DD6765B7EB.ContainsKey(9))
ISpace["MFG_d2_ExternalEmailId"].Value = result4D70F9F762964C9DBE1764DD6765B7EB[9];
if(result4D70F9F762964C9DBE1764DD6765B7EB.ContainsKey(10))
ISpace["MFG_d2_ExternalContactNo"].Value = result4D70F9F762964C9DBE1764DD6765B7EB[10];
if(result4D70F9F762964C9DBE1764DD6765B7EB.ContainsKey(0))
ISpace["MFG_d2_AdditionalID"].Value = result4D70F9F762964C9DBE1764DD6765B7EB[0];
}
else{
ISpace["MFG_d2_UpdatedOn"].Value = null;ISpace["MFG_d2_MemberType"].Value = null;ISpace["MFG_d2_AdditionalName"].Value = null;ISpace["MFG_d2_Departmentid"].Value = null;ISpace["MFG_d2_AdditionalType"].Value = null;ISpace["MFG_d2_UpdatedBy"].Value = null;ISpace["MFG_d2_ExternalDesignation"].Value = null;ISpace["MFG_d2_ExternalFacultyName"].Value = null;ISpace["MFG_d2_DesignationID"].Value = null;ISpace["MFG_d2_ExternalInstituteName"].Value = null;ISpace["MFG_d2_ProjectDetailsID"].Value = null;ISpace["MFG_d2_ExternalEmailId"].Value = null;ISpace["MFG_d2_ExternalContactNo"].Value = null;ISpace["MFG_d2_AdditionalID"].Value = null;
}
if(ISpace["MFG_d2_MemberType"].Value=="1")
{
base.WriteDebugInfo(@"if(ISpace[""MFG_d2_MemberType""].Value==""1"")");
ISpace["MFG_d2_ExternalInstituteName"].Visible="false";ISpace["MFG_d2_ExternalEmailId"].Visible="false";ISpace["MFG_d2_ExternalContactNo"].Visible="false";ISpace["MFG_d2_ExternalDesignation"].Visible="false";ISpace["MFG_d2_ExternalFacultyName"].Visible="false";ISpace["MFG_d2_AdditionalName"].Visible="true";ISpace["MFG_d2_Departmentid"].Visible="true";ISpace["MFG_d2_AdditionalType"].Visible="true";
base.WriteDebugInfo(@"ISpace[""MFG_d2_ExternalInstituteName""].Visible=""false"";ISpace[""MFG_d2_ExternalEmailId""].Visible=""false"";ISpace[""MFG_d2_ExternalContactNo""].Visible=""false"";ISpace[""MFG_d2_ExternalDesignation""].Visible=""false"";ISpace[""MFG_d2_ExternalFacultyName""].Visible=""false"";ISpace[""MFG_d2_AdditionalName""].Visible=""true"";ISpace[""MFG_d2_Departmentid""].Visible=""true"";ISpace[""MFG_d2_AdditionalType""].Visible=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MFG_d2_ExternalInstituteName"].Visible="true";ISpace["MFG_d2_ExternalEmailId"].Visible="true";ISpace["MFG_d2_ExternalContactNo"].Visible="true";ISpace["MFG_d2_ExternalDesignation"].Visible="true";ISpace["MFG_d2_ExternalFacultyName"].Visible="true";ISpace["MFG_d2_AdditionalName"].Visible="false";ISpace["MFG_d2_Departmentid"].Visible="false";ISpace["MFG_d2_AdditionalType"].Visible="false";
base.WriteDebugInfo(@"ISpace[""MFG_d2_ExternalInstituteName""].Visible=""true"";ISpace[""MFG_d2_ExternalEmailId""].Visible=""true"";ISpace[""MFG_d2_ExternalContactNo""].Visible=""true"";ISpace[""MFG_d2_ExternalDesignation""].Visible=""true"";ISpace[""MFG_d2_ExternalFacultyName""].Visible=""true"";ISpace[""MFG_d2_AdditionalName""].Visible=""false"";ISpace[""MFG_d2_Departmentid""].Visible=""false"";ISpace[""MFG_d2_AdditionalType""].Visible=""false"";");
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_delete_copidetails (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Delete_CopiDetails-OnClick");
ISpace["UI_DeleteDialog"].ShowDialog=true;;
base.WriteDebugInfo(@"ISpace[""UI_DeleteDialog""].ShowDialog=true;;");
ISpace["growid"].Value= ISpace["CopiDetails_RowId"].Value;
base.WriteDebugInfo(@"ISpace[""growid""].Value= ISpace[""CopiDetails_RowId""].Value;");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mf_d1_projecttype (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MF_d1_ProjectType-OnChange");
if(ISpace["MF_d1_ProjectType"].Value=="450")
{
base.WriteDebugInfo(@"if(ISpace[""MF_d1_ProjectType""].Value==""450"")");
ISpace["MF_d1_Currency"].Visible="true";ISpace["MF_d1_Currency"].Man=true;
base.WriteDebugInfo(@"ISpace[""MF_d1_Currency""].Visible=""true"";ISpace[""MF_d1_Currency""].Man=true;");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_d1_Currency"].Visible="false";ISpace["MF_d1_Currency"].Man=false;
base.WriteDebugInfo(@"ISpace[""MF_d1_Currency""].Visible=""false"";ISpace[""MF_d1_Currency""].Man=false;");
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mfg_d2_membertype (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MFG_d2_MemberType-OnChange");
if(ISpace["MFG_d2_MemberType"].Value=="1")
{
base.WriteDebugInfo(@"if(ISpace[""MFG_d2_MemberType""].Value==""1"")");
ISpace["MFG_d2_ExternalInstituteName"].Visible="false";ISpace["MFG_d2_ExternalEmailId"].Visible="false";ISpace["MFG_d2_ExternalContactNo"].Visible="false";ISpace["MFG_d2_ExternalDesignation"].Visible="false";ISpace["MFG_d2_ExternalFacultyName"].Visible="false";ISpace["MFG_d2_AdditionalName"].Visible="true";ISpace["MFG_d2_Departmentid"].Visible="true";ISpace["MFG_d2_AdditionalType"].Visible="true";
base.WriteDebugInfo(@"ISpace[""MFG_d2_ExternalInstituteName""].Visible=""false"";ISpace[""MFG_d2_ExternalEmailId""].Visible=""false"";ISpace[""MFG_d2_ExternalContactNo""].Visible=""false"";ISpace[""MFG_d2_ExternalDesignation""].Visible=""false"";ISpace[""MFG_d2_ExternalFacultyName""].Visible=""false"";ISpace[""MFG_d2_AdditionalName""].Visible=""true"";ISpace[""MFG_d2_Departmentid""].Visible=""true"";ISpace[""MFG_d2_AdditionalType""].Visible=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MFG_d2_ExternalInstituteName"].Visible="true";ISpace["MFG_d2_ExternalEmailId"].Visible="true";ISpace["MFG_d2_ExternalContactNo"].Visible="true";ISpace["MFG_d2_ExternalDesignation"].Visible="true";ISpace["MFG_d2_ExternalFacultyName"].Visible="true";ISpace["MFG_d2_AdditionalName"].Visible="false";ISpace["MFG_d2_Departmentid"].Visible="false";ISpace["MFG_d2_AdditionalType"].Visible="false";
base.WriteDebugInfo(@"ISpace[""MFG_d2_ExternalInstituteName""].Visible=""true"";ISpace[""MFG_d2_ExternalEmailId""].Visible=""true"";ISpace[""MFG_d2_ExternalContactNo""].Visible=""true"";ISpace[""MFG_d2_ExternalDesignation""].Visible=""true"";ISpace[""MFG_d2_ExternalFacultyName""].Visible=""true"";ISpace[""MFG_d2_AdditionalName""].Visible=""false"";ISpace[""MFG_d2_Departmentid""].Visible=""false"";ISpace[""MFG_d2_AdditionalType""].Visible=""false"";");
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
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_d1_FinancialYearID"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""MF_d1_FinancialYearID""].Value=="""")");
ISpace["Message"].Value=@"ERROR:Financial Year should be Mandatory";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""ERROR:Financial Year should be Mandatory"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if(ISpace["MF_d1_FundingAgency"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""MF_d1_FundingAgency""].Value=="""")");
ISpace["Message"].Value=@"ERROR:Funding Agency should be Mandatory";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""ERROR:Funding Agency should be Mandatory"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if(ISpace["MF_d1_ProjectCategoryID"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""MF_d1_ProjectCategoryID""].Value=="""")");
ISpace["Message"].Value=@"ERROR:Project Category should be Mandatory";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""ERROR:Project Category should be Mandatory"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if(ISpace["MF_d1_SectorID"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""MF_d1_SectorID""].Value=="""")");
ISpace["Message"].Value=@"ERROR:Sector should be Mandatory";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""ERROR:Sector should be Mandatory"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if(ISpace["MF_d1_ProjectName"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""MF_d1_ProjectName""].Value=="""")");
ISpace["Message"].Value=@"ERROR:Project Title shoule be Mandatory";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""ERROR:Project Title shoule be Mandatory"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if(ISpace["MF_d1_ProjectType"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""MF_d1_ProjectType""].Value=="""")");
ISpace["Message"].Value=@"ERROR:Project Type shoule be Mandatory";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""ERROR:Project Type shoule be Mandatory"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if(ISpace["MF_d1_ProjectBudget"].Value==0)
{
base.WriteDebugInfo(@"if(ISpace[""MF_d1_ProjectBudget""].Value==0)");
ISpace["Message"].Value=@"ERROR:Project Budget should not be 0";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""ERROR:Project Budget should not be 0"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if(ISpace["MF_d1_ProjectType"].Value=="450")
{
base.WriteDebugInfo(@"if(ISpace[""MF_d1_ProjectType""].Value==""450"")");
if(ISpace["MF_d1_Currency"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""MF_d1_Currency""].Value=="""")");
ISpace["Message"].Value=@"ERROR:Currency should be Mandatory";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""ERROR:Currency should be Mandatory"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
}
base.WriteDebugInfo(@"EXEC [GetIsProposalDocumentUploaded] '@@gv_InstanceId'");

var querySource40d3e7ce72901b768430a4b65e4802e8 =GetQueryExpressionDataSource("40d3e7ce-7290-1b76-8430-a4b65e4802e8");
Dictionary<short,object> result40d3e7ce72901b768430a4b65e4802e8=iSpace.ExecuteQuery(querySource40d3e7ce72901b768430a4b65e4802e8,@"EXEC [GetIsProposalDocumentUploaded] '" + ISpace["gv_instanceid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource40d3e7ce72901b768430a4b65e4802e8 =GetQueryExpressionDataSource(""40d3e7ce-7290-1b76-8430-a4b65e4802e8"");Dictionary<short,object> result40d3e7ce72901b768430a4b65e4802e8=iSpace.ExecuteQuery(querySource40d3e7ce72901b768430a4b65e4802e8,@""EXEC [GetIsProposalDocumentUploaded] '"" + ISpace[""gv_instanceid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result40d3e7ce72901b768430a4b65e4802e8!=null) && (result40d3e7ce72901b768430a4b65e4802e8.Count!=0))
{
if(result40d3e7ce72901b768430a4b65e4802e8.ContainsKey(0))
ISpace["MandatoryCheck"].Value = result40d3e7ce72901b768430a4b65e4802e8[0];
}
else{
ISpace["MandatoryCheck"].Value = null;
}
if(ISpace["MandatoryCheck"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""MandatoryCheck""].Value==1)");
ISpace["Message"].Value=@"ERROR:Proposal Document should be Mandatory";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""ERROR:Proposal Document should be Mandatory"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
}
if(ISpace["MF_d1_ProjectProposalID"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""MF_d1_ProjectProposalID""].Value=="""")");
ISpace["MF_d1_ProjectProposalID"].Value=ISpace["gv_instanceid"].Value;
base.WriteDebugInfo(@"ISpace[""MF_d1_ProjectProposalID""].Value=ISpace[""gv_instanceid""].Value;");
}
if(ISpace["MF_d1_ProjectRefNo"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""MF_d1_ProjectRefNo""].Value=="""")");
base.WriteDebugInfo(@"EXEC GenerateProjectCode '#M_EMPCode','#M_DeptCode','#MF_d1_ProjectProposalID','#MF_d1_ProjectCategoryCode','#MF_d1_FinancialYearID'");

var querySourcef503cb556d72d4d58857a65ba2925360 =GetQueryExpressionDataSource("f503cb55-6d72-d4d5-8857-a65ba2925360");
Dictionary<short,object> resultf503cb556d72d4d58857a65ba2925360=iSpace.ExecuteQuery(querySourcef503cb556d72d4d58857a65ba2925360,@"EXEC GenerateProjectCode '" + ISpace["M_EMPCode"].Value + @"','" + ISpace["M_DeptCode"].Value + @"','" + ISpace["MF_d1_ProjectProposalID"].Value + @"','" + ISpace["MF_d1_ProjectCategoryCode"].Value + @"','" + ISpace["MF_d1_FinancialYearID"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourcef503cb556d72d4d58857a65ba2925360 =GetQueryExpressionDataSource(""f503cb55-6d72-d4d5-8857-a65ba2925360"");Dictionary<short,object> resultf503cb556d72d4d58857a65ba2925360=iSpace.ExecuteQuery(querySourcef503cb556d72d4d58857a65ba2925360,@""EXEC GenerateProjectCode '"" + ISpace[""M_EMPCode""].Value + @""','"" + ISpace[""M_DeptCode""].Value + @""','"" + ISpace[""MF_d1_ProjectProposalID""].Value + @""','"" + ISpace[""MF_d1_ProjectCategoryCode""].Value + @""','"" + ISpace[""MF_d1_FinancialYearID""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultf503cb556d72d4d58857a65ba2925360!=null) && (resultf503cb556d72d4d58857a65ba2925360.Count!=0))
{
if(resultf503cb556d72d4d58857a65ba2925360.ContainsKey(0))
ISpace["MF_d1_ProjectRefNo"].Value = resultf503cb556d72d4d58857a65ba2925360[0];
}
else{
ISpace["MF_d1_ProjectRefNo"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["Subject"].Value=ISpace["MF_d1_ProjectRefNo"].Value;
base.WriteDebugInfo(@"ISpace[""Subject""].Value=ISpace[""MF_d1_ProjectRefNo""].Value;");
ISpace["Comments"].Value=ISpace["Comments"].Value;
base.WriteDebugInfo(@"ISpace[""Comments""].Value=ISpace[""Comments""].Value;");
}
base.WriteDebugInfo(@"EXEC InnovaceNoCode..[FormSave_E0AC6667-6D92-49AA-8F4D-01F473F2E426] '@@gv_InstanceId','@@gv_ActivityMapId','026e321e-9bb7-4c74-8615-3bbd7cc1b241','#MF_d1_ProjectProposalID','#MF_d1_ProjectRefNo','#MF_d1_ProjectCategoryID','#MF_d1_FinancialYearID','#M_DepartmentId','#M_DesignationId','#MF_d1_ProjectName','#MF_d1_ProjectType','#MF_d1_FundingAgency',#MF_d1_ProjectBudget,'#MF_d1_Remarks','#MF_d1_PrincipalInvestigator','#MF_d1_EmployeeBasicInfoId','#MF_d1_ProjectStatus','#MF_d1_SectorID','#MF_d1_EndorsementFileType','#MF_d1_ProposalCode',#MF_d1_IsSubmitted,#MF_d1_OverHead,#MF_d1_IfExternalInstitute,'@@gv_UserId','#MF_d1_UpdatedOn','@@gv_ProcessMapId','#MF_d1_Currency','#M_DepartmentId','#M_DesignationId','#Dept','#DummyInstance','#Subject'");

var querySource0C8CDFAE5C2A428DA7E8DC4118670282 =GetQueryExpressionDataSource("0C8CDFAE-5C2A-428D-A7E8-DC4118670282");
Dictionary<short,object> result0C8CDFAE5C2A428DA7E8DC4118670282=iSpace.ExecuteQuery(querySource0C8CDFAE5C2A428DA7E8DC4118670282,@"EXEC InnovaceNoCode..[FormSave_E0AC6667-6D92-49AA-8F4D-01F473F2E426] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','026e321e-9bb7-4c74-8615-3bbd7cc1b241','" + ISpace["MF_d1_ProjectProposalID"].Value + @"','" + ISpace["MF_d1_ProjectRefNo"].Value + @"','" + ISpace["MF_d1_ProjectCategoryID"].Value + @"','" + ISpace["MF_d1_FinancialYearID"].Value + @"','" + ISpace["M_DepartmentId"].Value + @"','" + ISpace["M_DesignationId"].Value + @"','" + ISpace["MF_d1_ProjectName"].Value + @"','" + ISpace["MF_d1_ProjectType"].Value + @"','" + ISpace["MF_d1_FundingAgency"].Value + @"'," + ISpace["MF_d1_ProjectBudget"].Value + @",'" + ISpace["MF_d1_Remarks"].Value + @"','" + ISpace["MF_d1_PrincipalInvestigator"].Value + @"','" + ISpace["MF_d1_EmployeeBasicInfoId"].Value + @"','" + ISpace["MF_d1_ProjectStatus"].Value + @"','" + ISpace["MF_d1_SectorID"].Value + @"','" + ISpace["MF_d1_EndorsementFileType"].Value + @"','" + ISpace["MF_d1_ProposalCode"].Value + @"'," + ISpace["MF_d1_IsSubmitted"].Value + @"," + ISpace["MF_d1_OverHead"].Value + @"," + ISpace["MF_d1_IfExternalInstitute"].Value + @",'" + ISpace["gv_userid"].Value + @"','" + ISpace["MF_d1_UpdatedOn"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','" + ISpace["MF_d1_Currency"].Value + @"','" + ISpace["M_DepartmentId"].Value + @"','" + ISpace["M_DesignationId"].Value + @"','" + ISpace["Dept"].Value + @"','" + ISpace["DummyInstance"].Value + @"','" + ISpace["Subject"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource0C8CDFAE5C2A428DA7E8DC4118670282 =GetQueryExpressionDataSource(""0C8CDFAE-5C2A-428D-A7E8-DC4118670282"");Dictionary<short,object> result0C8CDFAE5C2A428DA7E8DC4118670282=iSpace.ExecuteQuery(querySource0C8CDFAE5C2A428DA7E8DC4118670282,@""EXEC InnovaceNoCode..[FormSave_E0AC6667-6D92-49AA-8F4D-01F473F2E426] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','026e321e-9bb7-4c74-8615-3bbd7cc1b241','"" + ISpace[""MF_d1_ProjectProposalID""].Value + @""','"" + ISpace[""MF_d1_ProjectRefNo""].Value + @""','"" + ISpace[""MF_d1_ProjectCategoryID""].Value + @""','"" + ISpace[""MF_d1_FinancialYearID""].Value + @""','"" + ISpace[""M_DepartmentId""].Value + @""','"" + ISpace[""M_DesignationId""].Value + @""','"" + ISpace[""MF_d1_ProjectName""].Value + @""','"" + ISpace[""MF_d1_ProjectType""].Value + @""','"" + ISpace[""MF_d1_FundingAgency""].Value + @""',"" + ISpace[""MF_d1_ProjectBudget""].Value + @"",'"" + ISpace[""MF_d1_Remarks""].Value + @""','"" + ISpace[""MF_d1_PrincipalInvestigator""].Value + @""','"" + ISpace[""MF_d1_EmployeeBasicInfoId""].Value + @""','"" + ISpace[""MF_d1_ProjectStatus""].Value + @""','"" + ISpace[""MF_d1_SectorID""].Value + @""','"" + ISpace[""MF_d1_EndorsementFileType""].Value + @""','"" + ISpace[""MF_d1_ProposalCode""].Value + @""',"" + ISpace[""MF_d1_IsSubmitted""].Value + @"","" + ISpace[""MF_d1_OverHead""].Value + @"","" + ISpace[""MF_d1_IfExternalInstitute""].Value + @"",'"" + ISpace[""gv_userid""].Value + @""','"" + ISpace[""MF_d1_UpdatedOn""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','"" + ISpace[""MF_d1_Currency""].Value + @""','"" + ISpace[""M_DepartmentId""].Value + @""','"" + ISpace[""M_DesignationId""].Value + @""','"" + ISpace[""Dept""].Value + @""','"" + ISpace[""DummyInstance""].Value + @""','"" + ISpace[""Subject""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result0C8CDFAE5C2A428DA7E8DC4118670282!=null) && (result0C8CDFAE5C2A428DA7E8DC4118670282.Count!=0))
{
if(result0C8CDFAE5C2A428DA7E8DC4118670282.ContainsKey(0))
ISpace["ExecutionMessage"].Value = result0C8CDFAE5C2A428DA7E8DC4118670282[0];
}
else{
ISpace["ExecutionMessage"].Value = null;
}
base.WriteDebugInfo(@"EXEC InnovaceNoCode..[GridSave_D2D6E00A-B6B7-4968-BAAA-EF3D20F2BAC5]   '@@gv_InstanceId','@@gv_ActivityMapId','D2D6E00A-B6B7-4968-BAAA-EF3D20F2BAC5'");

var querySourceFBADFA2FE68E4BCBA058D7C63AAD5730 =GetQueryExpressionDataSource("FBADFA2F-E68E-4BCB-A058-D7C63AAD5730");
Dictionary<short,object> resultFBADFA2FE68E4BCBA058D7C63AAD5730=iSpace.ExecuteQuery(querySourceFBADFA2FE68E4BCBA058D7C63AAD5730,@"EXEC InnovaceNoCode..[GridSave_D2D6E00A-B6B7-4968-BAAA-EF3D20F2BAC5]   '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','D2D6E00A-B6B7-4968-BAAA-EF3D20F2BAC5'",false);

base.WriteDebugInfo(@"var querySourceFBADFA2FE68E4BCBA058D7C63AAD5730 =GetQueryExpressionDataSource(""FBADFA2F-E68E-4BCB-A058-D7C63AAD5730"");Dictionary<short,object> resultFBADFA2FE68E4BCBA058D7C63AAD5730=iSpace.ExecuteQuery(querySourceFBADFA2FE68E4BCBA058D7C63AAD5730,@""EXEC InnovaceNoCode..[GridSave_D2D6E00A-B6B7-4968-BAAA-EF3D20F2BAC5]   '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','D2D6E00A-B6B7-4968-BAAA-EF3D20F2BAC5'"",false);");
base.WriteDebugInfo(@"");

if((resultFBADFA2FE68E4BCBA058D7C63AAD5730!=null) && (resultFBADFA2FE68E4BCBA058D7C63AAD5730.Count!=0))
{
if(resultFBADFA2FE68E4BCBA058D7C63AAD5730.ContainsKey(0))
ISpace["ExecutionMessage"].Value = resultFBADFA2FE68E4BCBA058D7C63AAD5730[0];
}
else{
ISpace["ExecutionMessage"].Value = null;
}
base.WriteDebugInfo(@"EXEC InnovaceNoCode..[GridSave_FC9B8D2E-9EE3-436F-AF08-A774AF04D678]   '@@gv_InstanceId','@@gv_ActivityMapId','FC9B8D2E-9EE3-436F-AF08-A774AF04D678'");

var querySourceF928C371839D4F0FAF8DBCADF87418A6 =GetQueryExpressionDataSource("F928C371-839D-4F0F-AF8D-BCADF87418A6");
Dictionary<short,object> resultF928C371839D4F0FAF8DBCADF87418A6=iSpace.ExecuteQuery(querySourceF928C371839D4F0FAF8DBCADF87418A6,@"EXEC InnovaceNoCode..[GridSave_FC9B8D2E-9EE3-436F-AF08-A774AF04D678]   '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','FC9B8D2E-9EE3-436F-AF08-A774AF04D678'",false);

base.WriteDebugInfo(@"var querySourceF928C371839D4F0FAF8DBCADF87418A6 =GetQueryExpressionDataSource(""F928C371-839D-4F0F-AF8D-BCADF87418A6"");Dictionary<short,object> resultF928C371839D4F0FAF8DBCADF87418A6=iSpace.ExecuteQuery(querySourceF928C371839D4F0FAF8DBCADF87418A6,@""EXEC InnovaceNoCode..[GridSave_FC9B8D2E-9EE3-436F-AF08-A774AF04D678]   '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','FC9B8D2E-9EE3-436F-AF08-A774AF04D678'"",false);");
base.WriteDebugInfo(@"");

if((resultF928C371839D4F0FAF8DBCADF87418A6!=null) && (resultF928C371839D4F0FAF8DBCADF87418A6.Count!=0))
{
if(resultF928C371839D4F0FAF8DBCADF87418A6.ContainsKey(0))
ISpace["ExecutionMessage"].Value = resultF928C371839D4F0FAF8DBCADF87418A6[0];
}
else{
ISpace["ExecutionMessage"].Value = null;
}
ISpace["Message"].Value=@"Success:Submitted Successfully";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Success:Submitted Successfully"";");

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
private void SubscribeElementEvents_mfg_d2_departmentid (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MFG_d2_Departmentid-OnChange");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["MFG_d2_AdditionalName"].rElemData=iSpace.Reload(ISpace["MFG_d2_AdditionalName"].Value,@"EXEC GetDepartmentWiseFacultyCopi '" + ISpace["MFG_d2_Departmentid"].Value + @"',3,'" + ISpace["DummyInstance"].Value + @"',''","3A103712-5244-4427-B2B6-1C4E046FD337");
base.WriteDebugInfo(@"ISpace[""MFG_d2_AdditionalName""].rElemData=iSpace.Reload(ISpace[""MFG_d2_AdditionalName""].Value,@""EXEC GetDepartmentWiseFacultyCopi '"" + ISpace[""MFG_d2_Departmentid""].Value + @""',3,'"" + ISpace[""DummyInstance""].Value + @""',''"",""3A103712-5244-4427-B2B6-1C4E046FD337"");");
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mf_d1_fundingagency (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MF_d1_FundingAgency-OnChange");

var querySource18f009fa842f90cf5d3c5263dc607c23 =GetQueryExpressionDataSource("18f009fa-842f-90cf-5d3c-5263dc607c23");

DataTable result18f009fa842f90cf5d3c5263dc607c23=iSpace.SetGridDataSource(querySource18f009fa842f90cf5d3c5263dc607c23, _objectFactory.GetGridRPP("RequiredDocuments"),@"EXEC GetProposalDocumentList 1,'" + ISpace["MF_d1_FundingAgency"].Value + @"','" + ISpace["MF_d1_ProjectCategoryID"].Value + @"'");

iSpace.InsertGridBindDetails("RequiredDocuments","11",querySource18f009fa842f90cf5d3c5263dc607c23,"EXEC GetProposalDocumentList 1,'" + ISpace["MF_d1_FundingAgency"].Value + @"','" + ISpace["MF_d1_ProjectCategoryID"].Value + @"'",_objectFactory.GetGridRPP("RequiredDocuments"));

base.WriteDebugInfo(@"var querySource18f009fa842f90cf5d3c5263dc607c23 =GetQueryExpressionDataSource(""18f009fa-842f-90cf-5d3c-5263dc607c23"");DataTable result18f009fa842f90cf5d3c5263dc607c23=iSpace.SetGridDataSource(querySource18f009fa842f90cf5d3c5263dc607c23, _objectFactory.GetGridRPP(""RequiredDocuments""),@""EXEC GetProposalDocumentList 1,'"" + ISpace[""MF_d1_FundingAgency""].Value + @""','"" + ISpace[""MF_d1_ProjectCategoryID""].Value + @""'"");iSpace.InsertGridBindDetails(""RequiredDocuments"",""11"",querySource18f009fa842f90cf5d3c5263dc607c23,""EXEC GetProposalDocumentList 1,'"" + ISpace[""MF_d1_FundingAgency""].Value + @""','"" + ISpace[""MF_d1_ProjectCategoryID""].Value + @""'"",_objectFactory.GetGridRPP(""RequiredDocuments""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result46a77cd670de6252e1d62429032e267f=acdataIspaceB3A493374C4B42EC9F9B1C4C8B4E2E13.GetQueryExpressionBindings("46a77cd6-70de-6252-e1d6-2429032e267f");
iSpace.SetGridData(result18f009fa842f90cf5d3c5263dc607c23,result46a77cd670de6252e1d62429032e267f,"RequiredDocuments",ref ISpace);
iSpace.UpdateGridBindDetails("RequiredDocuments",result46a77cd670de6252e1d62429032e267f);
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mfg_d2_additionaltype (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MFG_d2_AdditionalType-OnChange");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["MFG_d2_Departmentid"].rElemData=iSpace.Reload(ISpace["MFG_d2_Departmentid"].Value,@"EXEC [GetDepartmentWiseFacultyCopi] '" + ISpace["M_DepartmentId"].Value + @"',2,'" + ISpace["DummyInstance"].Value + @"','" + ISpace["MFG_d2_AdditionalType"].Value + @"'","3A103712-5244-4427-B2B6-1C4E046FD337");
base.WriteDebugInfo(@"ISpace[""MFG_d2_Departmentid""].rElemData=iSpace.Reload(ISpace[""MFG_d2_Departmentid""].Value,@""EXEC [GetDepartmentWiseFacultyCopi] '"" + ISpace[""M_DepartmentId""].Value + @""',2,'"" + ISpace[""DummyInstance""].Value + @""','"" + ISpace[""MFG_d2_AdditionalType""].Value + @""'"",""3A103712-5244-4427-B2B6-1C4E046FD337"");");
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
		if(elementName.ToLower().Equals("mg_d3_uploaddocument"))
    {
    			SubscribeElementEvents_mg_d3_uploaddocument(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mf_d1_projectcategoryid"))
    {
    			SubscribeElementEvents_mf_d1_projectcategoryid(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mf_d1_projecttype"))
    {
    			SubscribeElementEvents_mf_d1_projecttype(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mfg_d2_membertype"))
    {
    			SubscribeElementEvents_mfg_d2_membertype(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mfg_d2_departmentid"))
    {
    			SubscribeElementEvents_mfg_d2_departmentid(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mf_d1_fundingagency"))
    {
    			SubscribeElementEvents_mf_d1_fundingagency(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mfg_d2_additionaltype"))
    {
    			SubscribeElementEvents_mfg_d2_additionaltype(ref dfsParam);
    }
}
	if(methodName.ToLower().Equals("onclick"))
{
		if(elementName.ToLower().Equals("save_copidetails"))
{
			SubscribeElementEvents_save_copidetails(ref dfsParam);
}
		if(elementName.ToLower().Equals("copi_no"))
{
			SubscribeElementEvents_copi_no(ref dfsParam);
}
		if(elementName.ToLower().Equals("copi_yes"))
{
			SubscribeElementEvents_copi_yes(ref dfsParam);
}
		if(elementName.ToLower().Equals("edit_copidetails"))
{
			SubscribeElementEvents_edit_copidetails(ref dfsParam);
}
		if(elementName.ToLower().Equals("delete_copidetails"))
{
			SubscribeElementEvents_delete_copidetails(ref dfsParam);
}
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

using System.Collections.Generic;
using System;
using CPS.Proof.DFSExtension;
using System.Linq;using System.Data;
using System.Runtime.CompilerServices;
public class ISpaceF692D0262B48418C9285DBD42DAC5F26 : VirtualForm
{
IISpace iSpace = new ISpace();
AcDataISpaceF692D0262B48418C9285DBD42DAC5F26 acdataIspaceF692D0262B48418C9285DBD42DAC5F26=new AcDataISpaceF692D0262B48418C9285DBD42DAC5F26();
private void SubscribeFormEvents_root(ref Dictionary<string, ServiceElementData> ISpace)
{
try
{
base.WriteDebugInfo(@"Root-OnAfterFormLoad");
ISpace["M_DepartmentId"].Visible="false";ISpace["MF_d1_Currency"].Visible="false";ISpace["M_DesignationId"].Visible="false";ISpace["MF_d1_EmployeeBasicInfoId"].Visible="false";
base.WriteDebugInfo(@"ISpace[""M_DepartmentId""].Visible=""false"";ISpace[""MF_d1_Currency""].Visible=""false"";ISpace[""M_DesignationId""].Visible=""false"";ISpace[""MF_d1_EmployeeBasicInfoId""].Visible=""false"";");
ISpace["MFG_d2_DesignationID"].Visible="false";ISpace["MFG_d2_ExternalInstituteName"].Visible="false";ISpace["MFG_d2_ExternalEmailId"].Visible="false";ISpace["MFG_d2_ExternalContactNo"].Visible="false";ISpace["MFG_d2_ExternalDesignation"].Visible="false";ISpace["MFG_d2_ExternalFacultyName"].Visible="false";ISpace["MFG_d2_AdditionalName"].Visible="false";ISpace["MFG_d2_Departmentid"].Visible="false";ISpace["MFG_d2_AdditionalType"].Visible="false";
base.WriteDebugInfo(@"ISpace[""MFG_d2_DesignationID""].Visible=""false"";ISpace[""MFG_d2_ExternalInstituteName""].Visible=""false"";ISpace[""MFG_d2_ExternalEmailId""].Visible=""false"";ISpace[""MFG_d2_ExternalContactNo""].Visible=""false"";ISpace[""MFG_d2_ExternalDesignation""].Visible=""false"";ISpace[""MFG_d2_ExternalFacultyName""].Visible=""false"";ISpace[""MFG_d2_AdditionalName""].Visible=""false"";ISpace[""MFG_d2_Departmentid""].Visible=""false"";ISpace[""MFG_d2_AdditionalType""].Visible=""false"";");
if(ISpace["FormVersionId"].Value=="FA963D46-2D52-4A3E-8550-E878A2504252")
{
ISpace["UI_InvisibleRow"].Visible="false";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""FA963D46-2D52-4A3E-8550-E878A2504252"")
{
ISpace[""UI_InvisibleRow""].Visible=""false"";
}");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["FormVersionId"].Value=="FA963D46-2D52-4A3E-8550-E878A2504252")
{
ISpace["UI_InvisibleRow"].Visible="false";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""FA963D46-2D52-4A3E-8550-E878A2504252"")
{
ISpace[""UI_InvisibleRow""].Visible=""false"";
}");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySource5c6a584da4e2b467f6c2c66f0c409f6c =GetQueryExpressionDataSource("5c6a584d-a4e2-b467-f6c2-c66f0c409f6c");

DataTable result5c6a584da4e2b467f6c2c66f0c409f6c=iSpace.SetGridDataSource(querySource5c6a584da4e2b467f6c2c66f0c409f6c, _objectFactory.GetGridRPP("MG_Comments"),@"EXEC [GetInstanceFlowDetais] '" + ISpace["gv_instanceid"].Value + @"'");

iSpace.InsertGridBindDetails("MG_Comments","11",querySource5c6a584da4e2b467f6c2c66f0c409f6c,"EXEC [GetInstanceFlowDetais] '" + ISpace["gv_instanceid"].Value + @"'",_objectFactory.GetGridRPP("MG_Comments"));

base.WriteDebugInfo(@"var querySource5c6a584da4e2b467f6c2c66f0c409f6c =GetQueryExpressionDataSource(""5c6a584d-a4e2-b467-f6c2-c66f0c409f6c"");DataTable result5c6a584da4e2b467f6c2c66f0c409f6c=iSpace.SetGridDataSource(querySource5c6a584da4e2b467f6c2c66f0c409f6c, _objectFactory.GetGridRPP(""MG_Comments""),@""EXEC [GetInstanceFlowDetais] '"" + ISpace[""gv_instanceid""].Value + @""'"");iSpace.InsertGridBindDetails(""MG_Comments"",""11"",querySource5c6a584da4e2b467f6c2c66f0c409f6c,""EXEC [GetInstanceFlowDetais] '"" + ISpace[""gv_instanceid""].Value + @""'"",_objectFactory.GetGridRPP(""MG_Comments""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result803558a97e53bd55f2b553d65d8b0305=acdataIspaceF692D0262B48418C9285DBD42DAC5F26.GetQueryExpressionBindings("803558a9-7e53-bd55-f2b5-53d65d8b0305");
iSpace.SetGridData(result5c6a584da4e2b467f6c2c66f0c409f6c,result803558a97e53bd55f2b553d65d8b0305,"MG_Comments",ref ISpace);
iSpace.UpdateGridBindDetails("MG_Comments",result803558a97e53bd55f2b553d65d8b0305);
}
ISpace["Comments"].Value="";
base.WriteDebugInfo(@"ISpace[""Comments""].Value="""";");
ISpace["M_MoveTo"].Value="";
base.WriteDebugInfo(@"ISpace[""M_MoveTo""].Value="""";");
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

var querySource5c6a584da4e2b467f6c2c66f0c409f6c =GetQueryExpressionDataSource("5c6a584d-a4e2-b467-f6c2-c66f0c409f6c");

DataTable result5c6a584da4e2b467f6c2c66f0c409f6c=iSpace.SetGridDataSource(querySource5c6a584da4e2b467f6c2c66f0c409f6c, _objectFactory.GetGridRPP("MG_Comments"),@"EXEC [GetInstanceFlowDetais] '" + ISpace["gv_instanceid"].Value + @"'");

iSpace.InsertGridBindDetails("MG_Comments","11",querySource5c6a584da4e2b467f6c2c66f0c409f6c,"EXEC [GetInstanceFlowDetais] '" + ISpace["gv_instanceid"].Value + @"'",_objectFactory.GetGridRPP("MG_Comments"));

base.WriteDebugInfo(@"var querySource5c6a584da4e2b467f6c2c66f0c409f6c =GetQueryExpressionDataSource(""5c6a584d-a4e2-b467-f6c2-c66f0c409f6c"");DataTable result5c6a584da4e2b467f6c2c66f0c409f6c=iSpace.SetGridDataSource(querySource5c6a584da4e2b467f6c2c66f0c409f6c, _objectFactory.GetGridRPP(""MG_Comments""),@""EXEC [GetInstanceFlowDetais] '"" + ISpace[""gv_instanceid""].Value + @""'"");iSpace.InsertGridBindDetails(""MG_Comments"",""11"",querySource5c6a584da4e2b467f6c2c66f0c409f6c,""EXEC [GetInstanceFlowDetais] '"" + ISpace[""gv_instanceid""].Value + @""'"",_objectFactory.GetGridRPP(""MG_Comments""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result803558a97e53bd55f2b553d65d8b0305=acdataIspaceF692D0262B48418C9285DBD42DAC5F26.GetQueryExpressionBindings("803558a9-7e53-bd55-f2b5-53d65d8b0305");
iSpace.SetGridData(result5c6a584da4e2b467f6c2c66f0c409f6c,result803558a97e53bd55f2b553d65d8b0305,"MG_Comments",ref ISpace);
iSpace.UpdateGridBindDetails("MG_Comments",result803558a97e53bd55f2b553d65d8b0305);
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
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
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
ISpace["Message"].Value=@"ERROR:Comments should be Mandatory";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""ERROR:Comments should be Mandatory"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
}
}
base.WriteDebugInfo(@"EXEC InnovaceNoCode..[GridSave_A3BB2140-4053-4558-9363-3BA1B526BD0A] '@@gv_InstanceId','@@gv_ActivityMapId','A3BB2140-4053-4558-9363-3BA1B526BD0A'");

var querySourceb11298397563b91c2a453c887bc84b31 =GetQueryExpressionDataSource("b1129839-7563-b91c-2a45-3c887bc84b31");
Dictionary<short,object> resultb11298397563b91c2a453c887bc84b31=iSpace.ExecuteQuery(querySourceb11298397563b91c2a453c887bc84b31,@"EXEC InnovaceNoCode..[GridSave_A3BB2140-4053-4558-9363-3BA1B526BD0A] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','A3BB2140-4053-4558-9363-3BA1B526BD0A'",false);

base.WriteDebugInfo(@"var querySourceb11298397563b91c2a453c887bc84b31 =GetQueryExpressionDataSource(""b1129839-7563-b91c-2a45-3c887bc84b31"");Dictionary<short,object> resultb11298397563b91c2a453c887bc84b31=iSpace.ExecuteQuery(querySourceb11298397563b91c2a453c887bc84b31,@""EXEC InnovaceNoCode..[GridSave_A3BB2140-4053-4558-9363-3BA1B526BD0A] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','A3BB2140-4053-4558-9363-3BA1B526BD0A'"",false);");
base.WriteDebugInfo(@"");

if((resultb11298397563b91c2a453c887bc84b31!=null) && (resultb11298397563b91c2a453c887bc84b31.Count!=0))
{
if(resultb11298397563b91c2a453c887bc84b31.ContainsKey(0))
ISpace["ExecutionMessage"].Value = resultb11298397563b91c2a453c887bc84b31[0];
}
else{
ISpace["ExecutionMessage"].Value = null;
}
ISpace["Message"].Value=@"Success:Submitted Successfully";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Success:Submitted Successfully"";");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC UpdateProposalState '@@gv_InstanceId'");

var querySourcecf8665f1ed60b9d08a13ee250aa2de27 =GetQueryExpressionDataSource("cf8665f1-ed60-b9d0-8a13-ee250aa2de27");
Dictionary<short,object> resultcf8665f1ed60b9d08a13ee250aa2de27=iSpace.ExecuteQuery(querySourcecf8665f1ed60b9d08a13ee250aa2de27,@"EXEC UpdateProposalState '" + ISpace["gv_instanceid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourcecf8665f1ed60b9d08a13ee250aa2de27 =GetQueryExpressionDataSource(""cf8665f1-ed60-b9d0-8a13-ee250aa2de27"");Dictionary<short,object> resultcf8665f1ed60b9d08a13ee250aa2de27=iSpace.ExecuteQuery(querySourcecf8665f1ed60b9d08a13ee250aa2de27,@""EXEC UpdateProposalState '"" + ISpace[""gv_instanceid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultcf8665f1ed60b9d08a13ee250aa2de27!=null) && (resultcf8665f1ed60b9d08a13ee250aa2de27.Count!=0))
{
if(resultcf8665f1ed60b9d08a13ee250aa2de27.ContainsKey(0))
ISpace["ExecutionMessage"].Value = resultcf8665f1ed60b9d08a13ee250aa2de27[0];
}
else{
ISpace["ExecutionMessage"].Value = null;
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
private void SubscribeElementEvents_m_moveto (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"M_MoveTo-OnChange");
if(ISpace["M_MoveTo"].Value=="APPROVE")
{
base.WriteDebugInfo(@"if(ISpace[""M_MoveTo""].Value==""APPROVE"")");
ISpace["MF_d1_ProjectStatus"].Value="5";
base.WriteDebugInfo(@"ISpace[""MF_d1_ProjectStatus""].Value=""5"";");
}
if(ISpace["M_MoveTo"].Value=="RETURN")
{
base.WriteDebugInfo(@"if(ISpace[""M_MoveTo""].Value==""RETURN"")");
ISpace["M_FlowType"].Value="RETURN";
base.WriteDebugInfo(@"ISpace[""M_FlowType""].Value=""RETURN"";");
ISpace["MF_d1_ProjectStatus"].Value="3";
base.WriteDebugInfo(@"ISpace[""MF_d1_ProjectStatus""].Value=""3"";");
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
ISpace["MF_d1_ProjectStatus"].Value="4";
base.WriteDebugInfo(@"ISpace[""MF_d1_ProjectStatus""].Value=""4"";");
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
		if(elementName.ToLower().Equals("m_moveto"))
    {
    			SubscribeElementEvents_m_moveto(ref dfsParam);
    }
}
	if(methodName.ToLower().Equals("onclick"))
{
		if(elementName.ToLower().Equals("m_history"))
{
			SubscribeElementEvents_m_history(ref dfsParam);
}
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

using System.Collections.Generic;
using System;
using CPS.Proof.DFSExtension;
using System.Linq;using System.Data;
using System.Runtime.CompilerServices;
public class ISpace2D400E54E6D143C798243831B9AD8F32 : VirtualForm
{
IISpace iSpace = new ISpace();
AcDataISpace2D400E54E6D143C798243831B9AD8F32 acdataIspace2D400E54E6D143C798243831B9AD8F32=new AcDataISpace2D400E54E6D143C798243831B9AD8F32();
private void SubscribeFormEvents_root(ref Dictionary<string, ServiceElementData> ISpace)
{
try
{
base.WriteDebugInfo(@"Root-OnAfterFormLoad");
ISpace["M_DepartmentId"].Visible="false";ISpace["MF_d1_Currency"].Visible="false";ISpace["M_DesignationId"].Visible="false";ISpace["MF_d1_EmployeeBasicInfoId"].Visible="false";
base.WriteDebugInfo(@"ISpace[""M_DepartmentId""].Visible=""false"";ISpace[""MF_d1_Currency""].Visible=""false"";ISpace[""M_DesignationId""].Visible=""false"";ISpace[""MF_d1_EmployeeBasicInfoId""].Visible=""false"";");
ISpace["MFG_d2_DesignationID"].Visible="false";ISpace["MFG_d2_ExternalInstituteName"].Visible="false";ISpace["MFG_d2_ExternalEmailId"].Visible="false";ISpace["MFG_d2_ExternalContactNo"].Visible="false";ISpace["MFG_d2_ExternalDesignation"].Visible="false";ISpace["MFG_d2_ExternalFacultyName"].Visible="false";ISpace["MFG_d2_AdditionalName"].Visible="false";ISpace["MFG_d2_Departmentid"].Visible="false";ISpace["MFG_d2_AdditionalType"].Visible="false";
base.WriteDebugInfo(@"ISpace[""MFG_d2_DesignationID""].Visible=""false"";ISpace[""MFG_d2_ExternalInstituteName""].Visible=""false"";ISpace[""MFG_d2_ExternalEmailId""].Visible=""false"";ISpace[""MFG_d2_ExternalContactNo""].Visible=""false"";ISpace[""MFG_d2_ExternalDesignation""].Visible=""false"";ISpace[""MFG_d2_ExternalFacultyName""].Visible=""false"";ISpace[""MFG_d2_AdditionalName""].Visible=""false"";ISpace[""MFG_d2_Departmentid""].Visible=""false"";ISpace[""MFG_d2_AdditionalType""].Visible=""false"";");
if(ISpace["FormVersionId"].Value=="FA963D46-2D52-4A3E-8550-E878A2504252")
{
ISpace["UI_InvisibleRow"].Visible="false";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""FA963D46-2D52-4A3E-8550-E878A2504252"")
{
ISpace[""UI_InvisibleRow""].Visible=""false"";
}");
ISpace["MF_d1_FinancialYearID"].Man=true;ISpace["MF_d1_ProjectName"].Man=true;ISpace["MF_d1_ProjectCategoryID"].Man=true;ISpace["MF_d1_Currency"].Man=true;ISpace["MF_d1_ProjectBudget"].Man=true;ISpace["MF_d1_ProjectType"].Man=true;ISpace["MF_d1_SectorID"].Man=true;ISpace["MF_d1_FundingAgency"].Man=true;
base.WriteDebugInfo(@"ISpace[""MF_d1_FinancialYearID""].Man=true;ISpace[""MF_d1_ProjectName""].Man=true;ISpace[""MF_d1_ProjectCategoryID""].Man=true;ISpace[""MF_d1_Currency""].Man=true;ISpace[""MF_d1_ProjectBudget""].Man=true;ISpace[""MF_d1_ProjectType""].Man=true;ISpace[""MF_d1_SectorID""].Man=true;ISpace[""MF_d1_FundingAgency""].Man=true;");




ISpace["Comments"].Man=true;
base.WriteDebugInfo(@"ISpace[""Comments""].Man=true;");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySource5c6a584da4e2b467f6c2c66f0c409f6c =GetQueryExpressionDataSource("5c6a584d-a4e2-b467-f6c2-c66f0c409f6c");

DataTable result5c6a584da4e2b467f6c2c66f0c409f6c=iSpace.SetGridDataSource(querySource5c6a584da4e2b467f6c2c66f0c409f6c, _objectFactory.GetGridRPP("MG_Comments"),@"EXEC [GetInstanceFlowDetais] '" + ISpace["gv_instanceid"].Value + @"'");

iSpace.InsertGridBindDetails("MG_Comments","11",querySource5c6a584da4e2b467f6c2c66f0c409f6c,"EXEC [GetInstanceFlowDetais] '" + ISpace["gv_instanceid"].Value + @"'",_objectFactory.GetGridRPP("MG_Comments"));

base.WriteDebugInfo(@"var querySource5c6a584da4e2b467f6c2c66f0c409f6c =GetQueryExpressionDataSource(""5c6a584d-a4e2-b467-f6c2-c66f0c409f6c"");DataTable result5c6a584da4e2b467f6c2c66f0c409f6c=iSpace.SetGridDataSource(querySource5c6a584da4e2b467f6c2c66f0c409f6c, _objectFactory.GetGridRPP(""MG_Comments""),@""EXEC [GetInstanceFlowDetais] '"" + ISpace[""gv_instanceid""].Value + @""'"");iSpace.InsertGridBindDetails(""MG_Comments"",""11"",querySource5c6a584da4e2b467f6c2c66f0c409f6c,""EXEC [GetInstanceFlowDetais] '"" + ISpace[""gv_instanceid""].Value + @""'"",_objectFactory.GetGridRPP(""MG_Comments""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result803558a97e53bd55f2b553d65d8b0305=acdataIspace2D400E54E6D143C798243831B9AD8F32.GetQueryExpressionBindings("803558a9-7e53-bd55-f2b5-53d65d8b0305");
iSpace.SetGridData(result5c6a584da4e2b467f6c2c66f0c409f6c,result803558a97e53bd55f2b553d65d8b0305,"MG_Comments",ref ISpace);
iSpace.UpdateGridBindDetails("MG_Comments",result803558a97e53bd55f2b553d65d8b0305);
}
ISpace["Comments"].Value="";
base.WriteDebugInfo(@"ISpace[""Comments""].Value="""";");
ISpace["M_MoveTo"].Value="";
base.WriteDebugInfo(@"ISpace[""M_MoveTo""].Value="""";");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mg_d3_uploaddocument (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MG_d3_UploadDocument-OnChange");
if(IsNullOrEmpty(ISpace["MG_d3_UploadDocument"].Value))
{
base.WriteDebugInfo(@"if(IsNullOrEmpty(ISpace[""MG_d3_UploadDocument""].Value))");
ISpace["MG_d3_MandatoryCheck"].Value=0;
base.WriteDebugInfo(@"ISpace[""MG_d3_MandatoryCheck""].Value=0;");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MG_d3_MandatoryCheck"].Value=0;
base.WriteDebugInfo(@"ISpace[""MG_d3_MandatoryCheck""].Value=0;");
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_save_copidetails (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Save_CopiDetails-OnClick");
if(ISpace["growid"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""growid""].Value=="""")");

var querySource6C11211E63544E6499A1D591D85CCC41 =GetQueryExpressionDataSource("6C11211E-6354-4E64-99A1-D591D85CCC41");

DataTable result6C11211E63544E6499A1D591D85CCC41=iSpace.SetGridDataSource(querySource6C11211E63544E6499A1D591D85CCC41, _objectFactory.GetGridRPP("CopiDetails"),@"EXEC [AddFormGridDataFC9B8D2E-9EE3-436F-AF08-A774AF04D678] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','FC9B8D2E-9EE3-436F-AF08-A774AF04D678','" + ISpace["growid"].Value + @"'," + ISpace["CopiDetails_Sequence"].Value + @",'" + ISpace["MFG_d2_AdditionalID"].Value + @"','" + ISpace["MF_d1_ProjectProposalID"].Value + @"','" + ISpace["MFG_d2_AdditionalType"].Value + @"','" + ISpace["MFG_d2_AdditionalName"].Value + @"','" + ISpace["MFG_d2_Departmentid"].Value + @"','" + ISpace["MFG_d2_DesignationID"].Value + @"','" + ISpace["MFG_d2_ExternalInstituteName"].Value + @"','" + ISpace["MFG_d2_ExternalFacultyName"].Value + @"','" + ISpace["MFG_d2_ExternalDesignation"].Value + @"','" + ISpace["MFG_d2_ExternalEmailId"].Value + @"','" + ISpace["MFG_d2_ExternalContactNo"].Value + @"'," + ISpace["MFG_d2_UpdatedBy"].Value + @",'" + ISpace["MFG_d2_UpdatedOn"].Value + @"','" + ISpace["MFG_d2_MemberType"].Value + @"'");

iSpace.InsertGridBindDetails("CopiDetails","11",querySource6C11211E63544E6499A1D591D85CCC41,"EXEC [AddFormGridDataFC9B8D2E-9EE3-436F-AF08-A774AF04D678] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','FC9B8D2E-9EE3-436F-AF08-A774AF04D678','" + ISpace["growid"].Value + @"'," + ISpace["CopiDetails_Sequence"].Value + @",'" + ISpace["MFG_d2_AdditionalID"].Value + @"','" + ISpace["MF_d1_ProjectProposalID"].Value + @"','" + ISpace["MFG_d2_AdditionalType"].Value + @"','" + ISpace["MFG_d2_AdditionalName"].Value + @"','" + ISpace["MFG_d2_Departmentid"].Value + @"','" + ISpace["MFG_d2_DesignationID"].Value + @"','" + ISpace["MFG_d2_ExternalInstituteName"].Value + @"','" + ISpace["MFG_d2_ExternalFacultyName"].Value + @"','" + ISpace["MFG_d2_ExternalDesignation"].Value + @"','" + ISpace["MFG_d2_ExternalEmailId"].Value + @"','" + ISpace["MFG_d2_ExternalContactNo"].Value + @"'," + ISpace["MFG_d2_UpdatedBy"].Value + @",'" + ISpace["MFG_d2_UpdatedOn"].Value + @"','" + ISpace["MFG_d2_MemberType"].Value + @"'",_objectFactory.GetGridRPP("CopiDetails"));

base.WriteDebugInfo(@"var querySource6C11211E63544E6499A1D591D85CCC41 =GetQueryExpressionDataSource(""6C11211E-6354-4E64-99A1-D591D85CCC41"");DataTable result6C11211E63544E6499A1D591D85CCC41=iSpace.SetGridDataSource(querySource6C11211E63544E6499A1D591D85CCC41, _objectFactory.GetGridRPP(""CopiDetails""),@""EXEC [AddFormGridDataFC9B8D2E-9EE3-436F-AF08-A774AF04D678] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','FC9B8D2E-9EE3-436F-AF08-A774AF04D678','"" + ISpace[""growid""].Value + @""',"" + ISpace[""CopiDetails_Sequence""].Value + @"",'"" + ISpace[""MFG_d2_AdditionalID""].Value + @""','"" + ISpace[""MF_d1_ProjectProposalID""].Value + @""','"" + ISpace[""MFG_d2_AdditionalType""].Value + @""','"" + ISpace[""MFG_d2_AdditionalName""].Value + @""','"" + ISpace[""MFG_d2_Departmentid""].Value + @""','"" + ISpace[""MFG_d2_DesignationID""].Value + @""','"" + ISpace[""MFG_d2_ExternalInstituteName""].Value + @""','"" + ISpace[""MFG_d2_ExternalFacultyName""].Value + @""','"" + ISpace[""MFG_d2_ExternalDesignation""].Value + @""','"" + ISpace[""MFG_d2_ExternalEmailId""].Value + @""','"" + ISpace[""MFG_d2_ExternalContactNo""].Value + @""',"" + ISpace[""MFG_d2_UpdatedBy""].Value + @"",'"" + ISpace[""MFG_d2_UpdatedOn""].Value + @""','"" + ISpace[""MFG_d2_MemberType""].Value + @""'"");iSpace.InsertGridBindDetails(""CopiDetails"",""11"",querySource6C11211E63544E6499A1D591D85CCC41,""EXEC [AddFormGridDataFC9B8D2E-9EE3-436F-AF08-A774AF04D678] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','FC9B8D2E-9EE3-436F-AF08-A774AF04D678','"" + ISpace[""growid""].Value + @""',"" + ISpace[""CopiDetails_Sequence""].Value + @"",'"" + ISpace[""MFG_d2_AdditionalID""].Value + @""','"" + ISpace[""MF_d1_ProjectProposalID""].Value + @""','"" + ISpace[""MFG_d2_AdditionalType""].Value + @""','"" + ISpace[""MFG_d2_AdditionalName""].Value + @""','"" + ISpace[""MFG_d2_Departmentid""].Value + @""','"" + ISpace[""MFG_d2_DesignationID""].Value + @""','"" + ISpace[""MFG_d2_ExternalInstituteName""].Value + @""','"" + ISpace[""MFG_d2_ExternalFacultyName""].Value + @""','"" + ISpace[""MFG_d2_ExternalDesignation""].Value + @""','"" + ISpace[""MFG_d2_ExternalEmailId""].Value + @""','"" + ISpace[""MFG_d2_ExternalContactNo""].Value + @""',"" + ISpace[""MFG_d2_UpdatedBy""].Value + @"",'"" + ISpace[""MFG_d2_UpdatedOn""].Value + @""','"" + ISpace[""MFG_d2_MemberType""].Value + @""'"",_objectFactory.GetGridRPP(""CopiDetails""));");
base.WriteDebugInfo(@"EXEC [AddFormGridDataFC9B8D2E-9EE3-436F-AF08-A774AF04D678] '@@gv_InstanceId','@@gv_ActivityMapId','FC9B8D2E-9EE3-436F-AF08-A774AF04D678','#growid',#CopiDetails_Sequence,'#MFG_d2_AdditionalID','#MFG_d2_ProjectDetailsID','#MFG_d2_AdditionalType','#MFG_d2_AdditionalName','#MFG_d2_Departmentid','#MFG_d2_DesignationID','#MFG_d2_ExternalInstituteName','#MFG_d2_ExternalFacultyName','#MFG_d2_ExternalDesignation','#MFG_d2_ExternalEmailId','#MFG_d2_ExternalContactNo',#MFG_d2_UpdatedBy,'#MFG_d2_UpdatedOn'");


List<Triplet<string, short, short?>> result2FAC01E585404425AD0142973E87B3C5=acdataIspace2D400E54E6D143C798243831B9AD8F32.GetQueryExpressionBindings("2FAC01E5-8540-4425-AD01-42973E87B3C5");
iSpace.SetGridData(result6C11211E63544E6499A1D591D85CCC41,result2FAC01E585404425AD0142973E87B3C5,"CopiDetails",ref ISpace);
iSpace.UpdateGridBindDetails("CopiDetails",result2FAC01E585404425AD0142973E87B3C5);
}
else
{
base.WriteDebugInfo(@"else");

var querySource401A9D348FD64AD08D6DBFDA8D331663 =GetQueryExpressionDataSource("401A9D34-8FD6-4AD0-8D6D-BFDA8D331663");

DataTable result401A9D348FD64AD08D6DBFDA8D331663=iSpace.SetGridDataSource(querySource401A9D348FD64AD08D6DBFDA8D331663, _objectFactory.GetGridRPP("CopiDetails"),@"EXEC [AddFormGridDataFC9B8D2E-9EE3-436F-AF08-A774AF04D678] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','FC9B8D2E-9EE3-436F-AF08-A774AF04D678','" + ISpace["growid"].Value + @"'," + ISpace["CopiDetails_Sequence"].Value + @",'" + ISpace["MFG_d2_AdditionalID"].Value + @"','" + ISpace["MF_d1_ProjectProposalID"].Value + @"','" + ISpace["MFG_d2_AdditionalType"].Value + @"','" + ISpace["MFG_d2_AdditionalName"].Value + @"','" + ISpace["MFG_d2_Departmentid"].Value + @"','" + ISpace["MFG_d2_DesignationID"].Value + @"','" + ISpace["MFG_d2_ExternalInstituteName"].Value + @"','" + ISpace["MFG_d2_ExternalFacultyName"].Value + @"','" + ISpace["MFG_d2_ExternalDesignation"].Value + @"','" + ISpace["MFG_d2_ExternalEmailId"].Value + @"','" + ISpace["MFG_d2_ExternalContactNo"].Value + @"'," + ISpace["MFG_d2_UpdatedBy"].Value + @",'" + ISpace["MFG_d2_UpdatedOn"].Value + @"','" + ISpace["MFG_d2_MemberType"].Value + @"'");

iSpace.InsertGridBindDetails("CopiDetails","11",querySource401A9D348FD64AD08D6DBFDA8D331663,"EXEC [AddFormGridDataFC9B8D2E-9EE3-436F-AF08-A774AF04D678] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','FC9B8D2E-9EE3-436F-AF08-A774AF04D678','" + ISpace["growid"].Value + @"'," + ISpace["CopiDetails_Sequence"].Value + @",'" + ISpace["MFG_d2_AdditionalID"].Value + @"','" + ISpace["MF_d1_ProjectProposalID"].Value + @"','" + ISpace["MFG_d2_AdditionalType"].Value + @"','" + ISpace["MFG_d2_AdditionalName"].Value + @"','" + ISpace["MFG_d2_Departmentid"].Value + @"','" + ISpace["MFG_d2_DesignationID"].Value + @"','" + ISpace["MFG_d2_ExternalInstituteName"].Value + @"','" + ISpace["MFG_d2_ExternalFacultyName"].Value + @"','" + ISpace["MFG_d2_ExternalDesignation"].Value + @"','" + ISpace["MFG_d2_ExternalEmailId"].Value + @"','" + ISpace["MFG_d2_ExternalContactNo"].Value + @"'," + ISpace["MFG_d2_UpdatedBy"].Value + @",'" + ISpace["MFG_d2_UpdatedOn"].Value + @"','" + ISpace["MFG_d2_MemberType"].Value + @"'",_objectFactory.GetGridRPP("CopiDetails"));

base.WriteDebugInfo(@"var querySource401A9D348FD64AD08D6DBFDA8D331663 =GetQueryExpressionDataSource(""401A9D34-8FD6-4AD0-8D6D-BFDA8D331663"");DataTable result401A9D348FD64AD08D6DBFDA8D331663=iSpace.SetGridDataSource(querySource401A9D348FD64AD08D6DBFDA8D331663, _objectFactory.GetGridRPP(""CopiDetails""),@""EXEC [AddFormGridDataFC9B8D2E-9EE3-436F-AF08-A774AF04D678] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','FC9B8D2E-9EE3-436F-AF08-A774AF04D678','"" + ISpace[""growid""].Value + @""',"" + ISpace[""CopiDetails_Sequence""].Value + @"",'"" + ISpace[""MFG_d2_AdditionalID""].Value + @""','"" + ISpace[""MF_d1_ProjectProposalID""].Value + @""','"" + ISpace[""MFG_d2_AdditionalType""].Value + @""','"" + ISpace[""MFG_d2_AdditionalName""].Value + @""','"" + ISpace[""MFG_d2_Departmentid""].Value + @""','"" + ISpace[""MFG_d2_DesignationID""].Value + @""','"" + ISpace[""MFG_d2_ExternalInstituteName""].Value + @""','"" + ISpace[""MFG_d2_ExternalFacultyName""].Value + @""','"" + ISpace[""MFG_d2_ExternalDesignation""].Value + @""','"" + ISpace[""MFG_d2_ExternalEmailId""].Value + @""','"" + ISpace[""MFG_d2_ExternalContactNo""].Value + @""',"" + ISpace[""MFG_d2_UpdatedBy""].Value + @"",'"" + ISpace[""MFG_d2_UpdatedOn""].Value + @""','"" + ISpace[""MFG_d2_MemberType""].Value + @""'"");iSpace.InsertGridBindDetails(""CopiDetails"",""11"",querySource401A9D348FD64AD08D6DBFDA8D331663,""EXEC [AddFormGridDataFC9B8D2E-9EE3-436F-AF08-A774AF04D678] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','FC9B8D2E-9EE3-436F-AF08-A774AF04D678','"" + ISpace[""growid""].Value + @""',"" + ISpace[""CopiDetails_Sequence""].Value + @"",'"" + ISpace[""MFG_d2_AdditionalID""].Value + @""','"" + ISpace[""MF_d1_ProjectProposalID""].Value + @""','"" + ISpace[""MFG_d2_AdditionalType""].Value + @""','"" + ISpace[""MFG_d2_AdditionalName""].Value + @""','"" + ISpace[""MFG_d2_Departmentid""].Value + @""','"" + ISpace[""MFG_d2_DesignationID""].Value + @""','"" + ISpace[""MFG_d2_ExternalInstituteName""].Value + @""','"" + ISpace[""MFG_d2_ExternalFacultyName""].Value + @""','"" + ISpace[""MFG_d2_ExternalDesignation""].Value + @""','"" + ISpace[""MFG_d2_ExternalEmailId""].Value + @""','"" + ISpace[""MFG_d2_ExternalContactNo""].Value + @""',"" + ISpace[""MFG_d2_UpdatedBy""].Value + @"",'"" + ISpace[""MFG_d2_UpdatedOn""].Value + @""','"" + ISpace[""MFG_d2_MemberType""].Value + @""'"",_objectFactory.GetGridRPP(""CopiDetails""));");
base.WriteDebugInfo(@"EXEC [UpdateFormGridDataFC9B8D2E-9EE3-436F-AF08-A774AF04D678] '@@gv_InstanceId','@@gv_ActivityMapId','FC9B8D2E-9EE3-436F-AF08-A774AF04D678','#growid',#CopiDetails_Sequence,'#MFG_d2_AdditionalID','#MFG_d2_ProjectDetailsID','#MFG_d2_AdditionalType','#MFG_d2_AdditionalName','#MFG_d2_Departmentid','#MFG_d2_DesignationID','#MFG_d2_ExternalInstituteName','#MFG_d2_ExternalFacultyName','#MFG_d2_ExternalDesignation','#MFG_d2_ExternalEmailId','#MFG_d2_ExternalContactNo',#MFG_d2_UpdatedBy,'#MFG_d2_UpdatedO");


List<Triplet<string, short, short?>> resultBE604E66309D4989879C431B3984B4B4=acdataIspace2D400E54E6D143C798243831B9AD8F32.GetQueryExpressionBindings("BE604E66-309D-4989-879C-431B3984B4B4");
iSpace.SetGridData(result401A9D348FD64AD08D6DBFDA8D331663,resultBE604E66309D4989879C431B3984B4B4,"CopiDetails",ref ISpace);
iSpace.UpdateGridBindDetails("CopiDetails",resultBE604E66309D4989879C431B3984B4B4);
}
ISpace["growid"].Value="";
base.WriteDebugInfo(@"ISpace[""growid""].Value="""";");
ISpace["MFG_d2_AdditionalID"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d2_AdditionalID""].Value="""";");
ISpace["MFG_d2_ProjectDetailsID"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d2_ProjectDetailsID""].Value="""";");
ISpace["MFG_d2_AdditionalType"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d2_AdditionalType""].Value="""";");
ISpace["MFG_d2_AdditionalName"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d2_AdditionalName""].Value="""";");
ISpace["MFG_d2_Departmentid"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d2_Departmentid""].Value="""";");
ISpace["MFG_d2_DesignationID"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d2_DesignationID""].Value="""";");
ISpace["MFG_d2_ExternalInstituteName"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d2_ExternalInstituteName""].Value="""";");
ISpace["MFG_d2_ExternalFacultyName"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d2_ExternalFacultyName""].Value="""";");
ISpace["MFG_d2_ExternalDesignation"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d2_ExternalDesignation""].Value="""";");
ISpace["MFG_d2_ExternalEmailId"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d2_ExternalEmailId""].Value="""";");
ISpace["MFG_d2_ExternalContactNo"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d2_ExternalContactNo""].Value="""";");
ISpace["MFG_d2_UpdatedBy"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d2_UpdatedBy""].Value="""";");
ISpace["MFG_d2_UpdatedOn"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d2_UpdatedOn""].Value="""";");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_copi_no (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"COPI_No-OnClick");
ISpace["UI_DeleteDialog"].HideDialog=true;;
base.WriteDebugInfo(@"ISpace[""UI_DeleteDialog""].HideDialog=true;;");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_copi_yes (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"COPI_Yes-OnClick");

var querySource46a6879a4dfd54d138c96438be62af60 =GetQueryExpressionDataSource("46a6879a-4dfd-54d1-38c9-6438be62af60");

DataTable result46a6879a4dfd54d138c96438be62af60=iSpace.SetGridDataSource(querySource46a6879a4dfd54d138c96438be62af60, _objectFactory.GetGridRPP("CopiDetails"),@"Exec [DeleteCoPiDetails] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["growid"].Value + @"'");

iSpace.InsertGridBindDetails("CopiDetails","11",querySource46a6879a4dfd54d138c96438be62af60,"Exec [DeleteCoPiDetails] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["growid"].Value + @"'",_objectFactory.GetGridRPP("CopiDetails"));

base.WriteDebugInfo(@"var querySource46a6879a4dfd54d138c96438be62af60 =GetQueryExpressionDataSource(""46a6879a-4dfd-54d1-38c9-6438be62af60"");DataTable result46a6879a4dfd54d138c96438be62af60=iSpace.SetGridDataSource(querySource46a6879a4dfd54d138c96438be62af60, _objectFactory.GetGridRPP(""CopiDetails""),@""Exec [DeleteCoPiDetails] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""growid""].Value + @""'"");iSpace.InsertGridBindDetails(""CopiDetails"",""11"",querySource46a6879a4dfd54d138c96438be62af60,""Exec [DeleteCoPiDetails] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""growid""].Value + @""'"",_objectFactory.GetGridRPP(""CopiDetails""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> resulte94499bc4a5f3d1caf8ae6389d08f460=acdataIspace2D400E54E6D143C798243831B9AD8F32.GetQueryExpressionBindings("e94499bc-4a5f-3d1c-af8a-e6389d08f460");
iSpace.SetGridData(result46a6879a4dfd54d138c96438be62af60,resulte94499bc4a5f3d1caf8ae6389d08f460,"CopiDetails",ref ISpace);
iSpace.UpdateGridBindDetails("CopiDetails",resulte94499bc4a5f3d1caf8ae6389d08f460);
ISpace["Message"].Value=@"Success:Deleted Successfully";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Success:Deleted Successfully"";");
ISpace["UI_DeleteDialog"].HideDialog=true;;
base.WriteDebugInfo(@"ISpace[""UI_DeleteDialog""].HideDialog=true;;");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mf_d1_projectcategoryid (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MF_d1_ProjectCategoryID-OnChange");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC GetProjectProposalDetailsLoad 12,'','#MF_d1_ProjectCategoryID'");

var querySourcef9231ef6c778e031aeb22f8be33e4ca2 =GetQueryExpressionDataSource("f9231ef6-c778-e031-aeb2-2f8be33e4ca2");
Dictionary<short,object> resultf9231ef6c778e031aeb22f8be33e4ca2=iSpace.ExecuteQuery(querySourcef9231ef6c778e031aeb22f8be33e4ca2,@"EXEC GetProjectProposalDetailsLoad 12,'','" + ISpace["MF_d1_ProjectCategoryID"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourcef9231ef6c778e031aeb22f8be33e4ca2 =GetQueryExpressionDataSource(""f9231ef6-c778-e031-aeb2-2f8be33e4ca2"");Dictionary<short,object> resultf9231ef6c778e031aeb22f8be33e4ca2=iSpace.ExecuteQuery(querySourcef9231ef6c778e031aeb22f8be33e4ca2,@""EXEC GetProjectProposalDetailsLoad 12,'','"" + ISpace[""MF_d1_ProjectCategoryID""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultf9231ef6c778e031aeb22f8be33e4ca2!=null) && (resultf9231ef6c778e031aeb22f8be33e4ca2.Count!=0))
{
if(resultf9231ef6c778e031aeb22f8be33e4ca2.ContainsKey(1))
ISpace["MF_d1_ProjectCategoryCode"].Value = resultf9231ef6c778e031aeb22f8be33e4ca2[1];
}
else{
ISpace["MF_d1_ProjectCategoryCode"].Value = null;
}
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_edit_copidetails (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Edit_CopiDetails-OnClick");
ISpace["growid"].Value=ISpace["CopiDetails_RowId"].Value;
base.WriteDebugInfo(@"ISpace[""growid""].Value=ISpace[""CopiDetails_RowId""].Value;");
base.WriteDebugInfo(@"EXEC [LoadFormGridDataFC9B8D2E-9EE3-436F-AF08-A774AF04D678] '@@gv_InstanceId','@@gv_ActivityMapId','FC9B8D2E-9EE3-436F-AF08-A774AF04D678','#growid',#CopiDetails_Sequence");

var querySource4D70F9F762964C9DBE1764DD6765B7EB =GetQueryExpressionDataSource("4D70F9F7-6296-4C9D-BE17-64DD6765B7EB");
Dictionary<short,object> result4D70F9F762964C9DBE1764DD6765B7EB=iSpace.ExecuteQuery(querySource4D70F9F762964C9DBE1764DD6765B7EB,@"EXEC [LoadFormGridDataFC9B8D2E-9EE3-436F-AF08-A774AF04D678] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','FC9B8D2E-9EE3-436F-AF08-A774AF04D678','" + ISpace["growid"].Value + @"'," + ISpace["CopiDetails_Sequence"].Value + @"",false);

base.WriteDebugInfo(@"var querySource4D70F9F762964C9DBE1764DD6765B7EB =GetQueryExpressionDataSource(""4D70F9F7-6296-4C9D-BE17-64DD6765B7EB"");Dictionary<short,object> result4D70F9F762964C9DBE1764DD6765B7EB=iSpace.ExecuteQuery(querySource4D70F9F762964C9DBE1764DD6765B7EB,@""EXEC [LoadFormGridDataFC9B8D2E-9EE3-436F-AF08-A774AF04D678] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','FC9B8D2E-9EE3-436F-AF08-A774AF04D678','"" + ISpace[""growid""].Value + @""',"" + ISpace[""CopiDetails_Sequence""].Value + @"""",false);");
base.WriteDebugInfo(@"EXEC [LoadFormGridDataFC9B8D2E-9EE3-436F-AF08-A774AF04D678] '@@gv_InstanceId','@@gv_ActivityMapId','FC9B8D2E-9EE3-436F-AF08-A774AF04D678','#growid',#CopiDetails_Sequence");

if((result4D70F9F762964C9DBE1764DD6765B7EB!=null) && (result4D70F9F762964C9DBE1764DD6765B7EB.Count!=0))
{
if(result4D70F9F762964C9DBE1764DD6765B7EB.ContainsKey(12))
ISpace["MFG_d2_UpdatedOn"].Value = result4D70F9F762964C9DBE1764DD6765B7EB[12];
if(result4D70F9F762964C9DBE1764DD6765B7EB.ContainsKey(14))
ISpace["MFG_d2_MemberType"].Value = result4D70F9F762964C9DBE1764DD6765B7EB[14];
if(result4D70F9F762964C9DBE1764DD6765B7EB.ContainsKey(3))
ISpace["MFG_d2_AdditionalName"].Value = result4D70F9F762964C9DBE1764DD6765B7EB[3];
if(result4D70F9F762964C9DBE1764DD6765B7EB.ContainsKey(4))
ISpace["MFG_d2_Departmentid"].Value = result4D70F9F762964C9DBE1764DD6765B7EB[4];
if(result4D70F9F762964C9DBE1764DD6765B7EB.ContainsKey(2))
ISpace["MFG_d2_AdditionalType"].Value = result4D70F9F762964C9DBE1764DD6765B7EB[2];
if(result4D70F9F762964C9DBE1764DD6765B7EB.ContainsKey(11))
ISpace["MFG_d2_UpdatedBy"].Value = result4D70F9F762964C9DBE1764DD6765B7EB[11];
if(result4D70F9F762964C9DBE1764DD6765B7EB.ContainsKey(8))
ISpace["MFG_d2_ExternalDesignation"].Value = result4D70F9F762964C9DBE1764DD6765B7EB[8];
if(result4D70F9F762964C9DBE1764DD6765B7EB.ContainsKey(7))
ISpace["MFG_d2_ExternalFacultyName"].Value = result4D70F9F762964C9DBE1764DD6765B7EB[7];
if(result4D70F9F762964C9DBE1764DD6765B7EB.ContainsKey(5))
ISpace["MFG_d2_DesignationID"].Value = result4D70F9F762964C9DBE1764DD6765B7EB[5];
if(result4D70F9F762964C9DBE1764DD6765B7EB.ContainsKey(6))
ISpace["MFG_d2_ExternalInstituteName"].Value = result4D70F9F762964C9DBE1764DD6765B7EB[6];
if(result4D70F9F762964C9DBE1764DD6765B7EB.ContainsKey(1))
ISpace["MFG_d2_ProjectDetailsID"].Value = result4D70F9F762964C9DBE1764DD6765B7EB[1];
if(result4D70F9F762964C9DBE1764DD6765B7EB.ContainsKey(9))
ISpace["MFG_d2_ExternalEmailId"].Value = result4D70F9F762964C9DBE1764DD6765B7EB[9];
if(result4D70F9F762964C9DBE1764DD6765B7EB.ContainsKey(10))
ISpace["MFG_d2_ExternalContactNo"].Value = result4D70F9F762964C9DBE1764DD6765B7EB[10];
if(result4D70F9F762964C9DBE1764DD6765B7EB.ContainsKey(0))
ISpace["MFG_d2_AdditionalID"].Value = result4D70F9F762964C9DBE1764DD6765B7EB[0];
}
else{
ISpace["MFG_d2_UpdatedOn"].Value = null;ISpace["MFG_d2_MemberType"].Value = null;ISpace["MFG_d2_AdditionalName"].Value = null;ISpace["MFG_d2_Departmentid"].Value = null;ISpace["MFG_d2_AdditionalType"].Value = null;ISpace["MFG_d2_UpdatedBy"].Value = null;ISpace["MFG_d2_ExternalDesignation"].Value = null;ISpace["MFG_d2_ExternalFacultyName"].Value = null;ISpace["MFG_d2_DesignationID"].Value = null;ISpace["MFG_d2_ExternalInstituteName"].Value = null;ISpace["MFG_d2_ProjectDetailsID"].Value = null;ISpace["MFG_d2_ExternalEmailId"].Value = null;ISpace["MFG_d2_ExternalContactNo"].Value = null;ISpace["MFG_d2_AdditionalID"].Value = null;
}
if(ISpace["MFG_d2_MemberType"].Value=="1")
{
base.WriteDebugInfo(@"if(ISpace[""MFG_d2_MemberType""].Value==""1"")");
ISpace["MFG_d2_ExternalInstituteName"].Visible="false";ISpace["MFG_d2_ExternalEmailId"].Visible="false";ISpace["MFG_d2_ExternalContactNo"].Visible="false";ISpace["MFG_d2_ExternalDesignation"].Visible="false";ISpace["MFG_d2_ExternalFacultyName"].Visible="false";ISpace["MFG_d2_AdditionalName"].Visible="true";ISpace["MFG_d2_Departmentid"].Visible="true";ISpace["MFG_d2_AdditionalType"].Visible="true";
base.WriteDebugInfo(@"ISpace[""MFG_d2_ExternalInstituteName""].Visible=""false"";ISpace[""MFG_d2_ExternalEmailId""].Visible=""false"";ISpace[""MFG_d2_ExternalContactNo""].Visible=""false"";ISpace[""MFG_d2_ExternalDesignation""].Visible=""false"";ISpace[""MFG_d2_ExternalFacultyName""].Visible=""false"";ISpace[""MFG_d2_AdditionalName""].Visible=""true"";ISpace[""MFG_d2_Departmentid""].Visible=""true"";ISpace[""MFG_d2_AdditionalType""].Visible=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MFG_d2_ExternalInstituteName"].Visible="true";ISpace["MFG_d2_ExternalEmailId"].Visible="true";ISpace["MFG_d2_ExternalContactNo"].Visible="true";ISpace["MFG_d2_ExternalDesignation"].Visible="true";ISpace["MFG_d2_ExternalFacultyName"].Visible="true";ISpace["MFG_d2_AdditionalName"].Visible="false";ISpace["MFG_d2_Departmentid"].Visible="false";ISpace["MFG_d2_AdditionalType"].Visible="false";
base.WriteDebugInfo(@"ISpace[""MFG_d2_ExternalInstituteName""].Visible=""true"";ISpace[""MFG_d2_ExternalEmailId""].Visible=""true"";ISpace[""MFG_d2_ExternalContactNo""].Visible=""true"";ISpace[""MFG_d2_ExternalDesignation""].Visible=""true"";ISpace[""MFG_d2_ExternalFacultyName""].Visible=""true"";ISpace[""MFG_d2_AdditionalName""].Visible=""false"";ISpace[""MFG_d2_Departmentid""].Visible=""false"";ISpace[""MFG_d2_AdditionalType""].Visible=""false"";");
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

var querySource5c6a584da4e2b467f6c2c66f0c409f6c =GetQueryExpressionDataSource("5c6a584d-a4e2-b467-f6c2-c66f0c409f6c");

DataTable result5c6a584da4e2b467f6c2c66f0c409f6c=iSpace.SetGridDataSource(querySource5c6a584da4e2b467f6c2c66f0c409f6c, _objectFactory.GetGridRPP("MG_Comments"),@"EXEC [GetInstanceFlowDetais] '" + ISpace["gv_instanceid"].Value + @"'");

iSpace.InsertGridBindDetails("MG_Comments","11",querySource5c6a584da4e2b467f6c2c66f0c409f6c,"EXEC [GetInstanceFlowDetais] '" + ISpace["gv_instanceid"].Value + @"'",_objectFactory.GetGridRPP("MG_Comments"));

base.WriteDebugInfo(@"var querySource5c6a584da4e2b467f6c2c66f0c409f6c =GetQueryExpressionDataSource(""5c6a584d-a4e2-b467-f6c2-c66f0c409f6c"");DataTable result5c6a584da4e2b467f6c2c66f0c409f6c=iSpace.SetGridDataSource(querySource5c6a584da4e2b467f6c2c66f0c409f6c, _objectFactory.GetGridRPP(""MG_Comments""),@""EXEC [GetInstanceFlowDetais] '"" + ISpace[""gv_instanceid""].Value + @""'"");iSpace.InsertGridBindDetails(""MG_Comments"",""11"",querySource5c6a584da4e2b467f6c2c66f0c409f6c,""EXEC [GetInstanceFlowDetais] '"" + ISpace[""gv_instanceid""].Value + @""'"",_objectFactory.GetGridRPP(""MG_Comments""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result803558a97e53bd55f2b553d65d8b0305=acdataIspace2D400E54E6D143C798243831B9AD8F32.GetQueryExpressionBindings("803558a9-7e53-bd55-f2b5-53d65d8b0305");
iSpace.SetGridData(result5c6a584da4e2b467f6c2c66f0c409f6c,result803558a97e53bd55f2b553d65d8b0305,"MG_Comments",ref ISpace);
iSpace.UpdateGridBindDetails("MG_Comments",result803558a97e53bd55f2b553d65d8b0305);
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_delete_copidetails (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Delete_CopiDetails-OnClick");
ISpace["UI_DeleteDialog"].ShowDialog=true;;
base.WriteDebugInfo(@"ISpace[""UI_DeleteDialog""].ShowDialog=true;;");
ISpace["growid"].Value= ISpace["CopiDetails_RowId"].Value;
base.WriteDebugInfo(@"ISpace[""growid""].Value= ISpace[""CopiDetails_RowId""].Value;");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mf_d1_projecttype (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MF_d1_ProjectType-OnChange");
if(ISpace["MF_d1_ProjectType"].Value=="450")
{
base.WriteDebugInfo(@"if(ISpace[""MF_d1_ProjectType""].Value==""450"")");
ISpace["MF_d1_Currency"].Visible="true";ISpace["MF_d1_Currency"].Man=true;
base.WriteDebugInfo(@"ISpace[""MF_d1_Currency""].Visible=""true"";ISpace[""MF_d1_Currency""].Man=true;");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_d1_Currency"].Visible="false";ISpace["MF_d1_Currency"].Man=false;
base.WriteDebugInfo(@"ISpace[""MF_d1_Currency""].Visible=""false"";ISpace[""MF_d1_Currency""].Man=false;");
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mfg_d2_membertype (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MFG_d2_MemberType-OnChange");
if(ISpace["MFG_d2_MemberType"].Value=="1")
{
base.WriteDebugInfo(@"if(ISpace[""MFG_d2_MemberType""].Value==""1"")");
ISpace["MFG_d2_ExternalInstituteName"].Visible="false";ISpace["MFG_d2_ExternalEmailId"].Visible="false";ISpace["MFG_d2_ExternalContactNo"].Visible="false";ISpace["MFG_d2_ExternalDesignation"].Visible="false";ISpace["MFG_d2_ExternalFacultyName"].Visible="false";ISpace["MFG_d2_AdditionalName"].Visible="true";ISpace["MFG_d2_Departmentid"].Visible="true";ISpace["MFG_d2_AdditionalType"].Visible="true";
base.WriteDebugInfo(@"ISpace[""MFG_d2_ExternalInstituteName""].Visible=""false"";ISpace[""MFG_d2_ExternalEmailId""].Visible=""false"";ISpace[""MFG_d2_ExternalContactNo""].Visible=""false"";ISpace[""MFG_d2_ExternalDesignation""].Visible=""false"";ISpace[""MFG_d2_ExternalFacultyName""].Visible=""false"";ISpace[""MFG_d2_AdditionalName""].Visible=""true"";ISpace[""MFG_d2_Departmentid""].Visible=""true"";ISpace[""MFG_d2_AdditionalType""].Visible=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MFG_d2_ExternalInstituteName"].Visible="true";ISpace["MFG_d2_ExternalEmailId"].Visible="true";ISpace["MFG_d2_ExternalContactNo"].Visible="true";ISpace["MFG_d2_ExternalDesignation"].Visible="true";ISpace["MFG_d2_ExternalFacultyName"].Visible="true";ISpace["MFG_d2_AdditionalName"].Visible="false";ISpace["MFG_d2_Departmentid"].Visible="false";ISpace["MFG_d2_AdditionalType"].Visible="false";
base.WriteDebugInfo(@"ISpace[""MFG_d2_ExternalInstituteName""].Visible=""true"";ISpace[""MFG_d2_ExternalEmailId""].Visible=""true"";ISpace[""MFG_d2_ExternalContactNo""].Visible=""true"";ISpace[""MFG_d2_ExternalDesignation""].Visible=""true"";ISpace[""MFG_d2_ExternalFacultyName""].Visible=""true"";ISpace[""MFG_d2_AdditionalName""].Visible=""false"";ISpace[""MFG_d2_Departmentid""].Visible=""false"";ISpace[""MFG_d2_AdditionalType""].Visible=""false"";");
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
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_d1_FinancialYearID"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""MF_d1_FinancialYearID""].Value=="""")");
ISpace["Message"].Value=@"ERROR:Financial Year should be Mandatory";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""ERROR:Financial Year should be Mandatory"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if(ISpace["MF_d1_FundingAgency"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""MF_d1_FundingAgency""].Value=="""")");
ISpace["Message"].Value=@"ERROR:Funding Agency should be Mandatory";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""ERROR:Funding Agency should be Mandatory"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if(ISpace["MF_d1_ProjectCategoryID"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""MF_d1_ProjectCategoryID""].Value=="""")");
ISpace["Message"].Value=@"ERROR:Project Category should be Mandatory";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""ERROR:Project Category should be Mandatory"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if(ISpace["MF_d1_SectorID"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""MF_d1_SectorID""].Value=="""")");
ISpace["Message"].Value=@"ERROR:Sector should be Mandatory";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""ERROR:Sector should be Mandatory"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if(ISpace["MF_d1_ProjectName"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""MF_d1_ProjectName""].Value=="""")");
ISpace["Message"].Value=@"ERROR:Project Title shoule be Mandatory";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""ERROR:Project Title shoule be Mandatory"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if(ISpace["MF_d1_ProjectType"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""MF_d1_ProjectType""].Value=="""")");
ISpace["Message"].Value=@"ERROR:Project Type shoule be Mandatory";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""ERROR:Project Type shoule be Mandatory"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if(ISpace["MF_d1_ProjectBudget"].Value==0)
{
base.WriteDebugInfo(@"if(ISpace[""MF_d1_ProjectBudget""].Value==0)");
ISpace["Message"].Value=@"ERROR:Project Budget should not be 0";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""ERROR:Project Budget should not be 0"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if(ISpace["MF_d1_ProjectType"].Value=="450")
{
base.WriteDebugInfo(@"if(ISpace[""MF_d1_ProjectType""].Value==""450"")");
if(ISpace["MF_d1_Currency"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""MF_d1_Currency""].Value=="""")");
ISpace["Message"].Value=@"ERROR:Currency should be Mandatory";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""ERROR:Currency should be Mandatory"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
}
base.WriteDebugInfo(@"EXEC [GetIsProposalDocumentUploaded] '@@gv_InstanceId'");

var querySource40d3e7ce72901b768430a4b65e4802e8 =GetQueryExpressionDataSource("40d3e7ce-7290-1b76-8430-a4b65e4802e8");
Dictionary<short,object> result40d3e7ce72901b768430a4b65e4802e8=iSpace.ExecuteQuery(querySource40d3e7ce72901b768430a4b65e4802e8,@"EXEC [GetIsProposalDocumentUploaded] '" + ISpace["gv_instanceid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource40d3e7ce72901b768430a4b65e4802e8 =GetQueryExpressionDataSource(""40d3e7ce-7290-1b76-8430-a4b65e4802e8"");Dictionary<short,object> result40d3e7ce72901b768430a4b65e4802e8=iSpace.ExecuteQuery(querySource40d3e7ce72901b768430a4b65e4802e8,@""EXEC [GetIsProposalDocumentUploaded] '"" + ISpace[""gv_instanceid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result40d3e7ce72901b768430a4b65e4802e8!=null) && (result40d3e7ce72901b768430a4b65e4802e8.Count!=0))
{
if(result40d3e7ce72901b768430a4b65e4802e8.ContainsKey(0))
ISpace["MandatoryCheck"].Value = result40d3e7ce72901b768430a4b65e4802e8[0];
}
else{
ISpace["MandatoryCheck"].Value = null;
}
if(ISpace["MandatoryCheck"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""MandatoryCheck""].Value==1)");
ISpace["Message"].Value=@"ERROR:Proposal Document should be Mandatory";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""ERROR:Proposal Document should be Mandatory"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
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
ISpace["Message"].Value=@"ERROR:Comments should be Mandatory";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""ERROR:Comments should be Mandatory"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
}
}
if(ISpace["MF_d1_ProjectProposalID"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""MF_d1_ProjectProposalID""].Value=="""")");
ISpace["MF_d1_ProjectProposalID"].Value=ISpace["gv_instanceid"].Value;
base.WriteDebugInfo(@"ISpace[""MF_d1_ProjectProposalID""].Value=ISpace[""gv_instanceid""].Value;");
}
if(ISpace["MF_d1_ProjectRefNo"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""MF_d1_ProjectRefNo""].Value=="""")");
base.WriteDebugInfo(@"EXEC GenerateProjectCode '#M_EMPCode','#M_DeptCode','#MF_d1_ProjectProposalID','#MF_d1_ProjectCategoryCode','#MF_d1_FinancialYearID'");

var querySourcef503cb556d72d4d58857a65ba2925360 =GetQueryExpressionDataSource("f503cb55-6d72-d4d5-8857-a65ba2925360");
Dictionary<short,object> resultf503cb556d72d4d58857a65ba2925360=iSpace.ExecuteQuery(querySourcef503cb556d72d4d58857a65ba2925360,@"EXEC GenerateProjectCode '" + ISpace["M_EMPCode"].Value + @"','" + ISpace["M_DeptCode"].Value + @"','" + ISpace["MF_d1_ProjectProposalID"].Value + @"','" + ISpace["MF_d1_ProjectCategoryCode"].Value + @"','" + ISpace["MF_d1_FinancialYearID"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourcef503cb556d72d4d58857a65ba2925360 =GetQueryExpressionDataSource(""f503cb55-6d72-d4d5-8857-a65ba2925360"");Dictionary<short,object> resultf503cb556d72d4d58857a65ba2925360=iSpace.ExecuteQuery(querySourcef503cb556d72d4d58857a65ba2925360,@""EXEC GenerateProjectCode '"" + ISpace[""M_EMPCode""].Value + @""','"" + ISpace[""M_DeptCode""].Value + @""','"" + ISpace[""MF_d1_ProjectProposalID""].Value + @""','"" + ISpace[""MF_d1_ProjectCategoryCode""].Value + @""','"" + ISpace[""MF_d1_FinancialYearID""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultf503cb556d72d4d58857a65ba2925360!=null) && (resultf503cb556d72d4d58857a65ba2925360.Count!=0))
{
if(resultf503cb556d72d4d58857a65ba2925360.ContainsKey(0))
ISpace["MF_d1_ProjectRefNo"].Value = resultf503cb556d72d4d58857a65ba2925360[0];
}
else{
ISpace["MF_d1_ProjectRefNo"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["Subject"].Value=ISpace["MF_d1_ProjectRefNo"].Value;
base.WriteDebugInfo(@"ISpace[""Subject""].Value=ISpace[""MF_d1_ProjectRefNo""].Value;");
ISpace["Comments"].Value=ISpace["Comments"].Value;
base.WriteDebugInfo(@"ISpace[""Comments""].Value=ISpace[""Comments""].Value;");
}
base.WriteDebugInfo(@"EXEC InnovaceNoCode..[FormSave_E0AC6667-6D92-49AA-8F4D-01F473F2E426] '@@gv_InstanceId','@@gv_ActivityMapId','026e321e-9bb7-4c74-8615-3bbd7cc1b241','#MF_d1_ProjectProposalID','#MF_d1_ProjectRefNo','#MF_d1_ProjectCategoryID','#MF_d1_FinancialYearID','#M_DepartmentId','#M_DesignationId','#MF_d1_ProjectName','#MF_d1_ProjectType','#MF_d1_FundingAgency',#MF_d1_ProjectBudget,'#MF_d1_Remarks','#MF_d1_PrincipalInvestigator','#MF_d1_EmployeeBasicInfoId','#MF_d1_ProjectStatus','#MF_d1_SectorID','#MF_d1_EndorsementFileType','#MF_d1_ProposalCode',#MF_d1_IsSubmitted,#MF_d1_OverHead,#MF_d1_IfExternalInstitute,'@@gv_UserId','#MF_d1_UpdatedOn','@@gv_ProcessMapId','#MF_d1_Currency','#M_DepartmentId','#M_DesignationId','#Dept','#DummyInstance','#Subject'");

var querySource0C8CDFAE5C2A428DA7E8DC4118670282 =GetQueryExpressionDataSource("0C8CDFAE-5C2A-428D-A7E8-DC4118670282");
Dictionary<short,object> result0C8CDFAE5C2A428DA7E8DC4118670282=iSpace.ExecuteQuery(querySource0C8CDFAE5C2A428DA7E8DC4118670282,@"EXEC InnovaceNoCode..[FormSave_E0AC6667-6D92-49AA-8F4D-01F473F2E426] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','026e321e-9bb7-4c74-8615-3bbd7cc1b241','" + ISpace["MF_d1_ProjectProposalID"].Value + @"','" + ISpace["MF_d1_ProjectRefNo"].Value + @"','" + ISpace["MF_d1_ProjectCategoryID"].Value + @"','" + ISpace["MF_d1_FinancialYearID"].Value + @"','" + ISpace["M_DepartmentId"].Value + @"','" + ISpace["M_DesignationId"].Value + @"','" + ISpace["MF_d1_ProjectName"].Value + @"','" + ISpace["MF_d1_ProjectType"].Value + @"','" + ISpace["MF_d1_FundingAgency"].Value + @"'," + ISpace["MF_d1_ProjectBudget"].Value + @",'" + ISpace["MF_d1_Remarks"].Value + @"','" + ISpace["MF_d1_PrincipalInvestigator"].Value + @"','" + ISpace["MF_d1_EmployeeBasicInfoId"].Value + @"','" + ISpace["MF_d1_ProjectStatus"].Value + @"','" + ISpace["MF_d1_SectorID"].Value + @"','" + ISpace["MF_d1_EndorsementFileType"].Value + @"','" + ISpace["MF_d1_ProposalCode"].Value + @"'," + ISpace["MF_d1_IsSubmitted"].Value + @"," + ISpace["MF_d1_OverHead"].Value + @"," + ISpace["MF_d1_IfExternalInstitute"].Value + @",'" + ISpace["gv_userid"].Value + @"','" + ISpace["MF_d1_UpdatedOn"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','" + ISpace["MF_d1_Currency"].Value + @"','" + ISpace["M_DepartmentId"].Value + @"','" + ISpace["M_DesignationId"].Value + @"','" + ISpace["Dept"].Value + @"','" + ISpace["DummyInstance"].Value + @"','" + ISpace["Subject"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource0C8CDFAE5C2A428DA7E8DC4118670282 =GetQueryExpressionDataSource(""0C8CDFAE-5C2A-428D-A7E8-DC4118670282"");Dictionary<short,object> result0C8CDFAE5C2A428DA7E8DC4118670282=iSpace.ExecuteQuery(querySource0C8CDFAE5C2A428DA7E8DC4118670282,@""EXEC InnovaceNoCode..[FormSave_E0AC6667-6D92-49AA-8F4D-01F473F2E426] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','026e321e-9bb7-4c74-8615-3bbd7cc1b241','"" + ISpace[""MF_d1_ProjectProposalID""].Value + @""','"" + ISpace[""MF_d1_ProjectRefNo""].Value + @""','"" + ISpace[""MF_d1_ProjectCategoryID""].Value + @""','"" + ISpace[""MF_d1_FinancialYearID""].Value + @""','"" + ISpace[""M_DepartmentId""].Value + @""','"" + ISpace[""M_DesignationId""].Value + @""','"" + ISpace[""MF_d1_ProjectName""].Value + @""','"" + ISpace[""MF_d1_ProjectType""].Value + @""','"" + ISpace[""MF_d1_FundingAgency""].Value + @""',"" + ISpace[""MF_d1_ProjectBudget""].Value + @"",'"" + ISpace[""MF_d1_Remarks""].Value + @""','"" + ISpace[""MF_d1_PrincipalInvestigator""].Value + @""','"" + ISpace[""MF_d1_EmployeeBasicInfoId""].Value + @""','"" + ISpace[""MF_d1_ProjectStatus""].Value + @""','"" + ISpace[""MF_d1_SectorID""].Value + @""','"" + ISpace[""MF_d1_EndorsementFileType""].Value + @""','"" + ISpace[""MF_d1_ProposalCode""].Value + @""',"" + ISpace[""MF_d1_IsSubmitted""].Value + @"","" + ISpace[""MF_d1_OverHead""].Value + @"","" + ISpace[""MF_d1_IfExternalInstitute""].Value + @"",'"" + ISpace[""gv_userid""].Value + @""','"" + ISpace[""MF_d1_UpdatedOn""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','"" + ISpace[""MF_d1_Currency""].Value + @""','"" + ISpace[""M_DepartmentId""].Value + @""','"" + ISpace[""M_DesignationId""].Value + @""','"" + ISpace[""Dept""].Value + @""','"" + ISpace[""DummyInstance""].Value + @""','"" + ISpace[""Subject""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result0C8CDFAE5C2A428DA7E8DC4118670282!=null) && (result0C8CDFAE5C2A428DA7E8DC4118670282.Count!=0))
{
if(result0C8CDFAE5C2A428DA7E8DC4118670282.ContainsKey(0))
ISpace["ExecutionMessage"].Value = result0C8CDFAE5C2A428DA7E8DC4118670282[0];
}
else{
ISpace["ExecutionMessage"].Value = null;
}
base.WriteDebugInfo(@"EXEC InnovaceNoCode..[GridSave_D2D6E00A-B6B7-4968-BAAA-EF3D20F2BAC5]   '@@gv_InstanceId','@@gv_ActivityMapId','D2D6E00A-B6B7-4968-BAAA-EF3D20F2BAC5'");

var querySourceFBADFA2FE68E4BCBA058D7C63AAD5730 =GetQueryExpressionDataSource("FBADFA2F-E68E-4BCB-A058-D7C63AAD5730");
Dictionary<short,object> resultFBADFA2FE68E4BCBA058D7C63AAD5730=iSpace.ExecuteQuery(querySourceFBADFA2FE68E4BCBA058D7C63AAD5730,@"EXEC InnovaceNoCode..[GridSave_D2D6E00A-B6B7-4968-BAAA-EF3D20F2BAC5]   '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','D2D6E00A-B6B7-4968-BAAA-EF3D20F2BAC5'",false);

base.WriteDebugInfo(@"var querySourceFBADFA2FE68E4BCBA058D7C63AAD5730 =GetQueryExpressionDataSource(""FBADFA2F-E68E-4BCB-A058-D7C63AAD5730"");Dictionary<short,object> resultFBADFA2FE68E4BCBA058D7C63AAD5730=iSpace.ExecuteQuery(querySourceFBADFA2FE68E4BCBA058D7C63AAD5730,@""EXEC InnovaceNoCode..[GridSave_D2D6E00A-B6B7-4968-BAAA-EF3D20F2BAC5]   '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','D2D6E00A-B6B7-4968-BAAA-EF3D20F2BAC5'"",false);");
base.WriteDebugInfo(@"");

if((resultFBADFA2FE68E4BCBA058D7C63AAD5730!=null) && (resultFBADFA2FE68E4BCBA058D7C63AAD5730.Count!=0))
{
if(resultFBADFA2FE68E4BCBA058D7C63AAD5730.ContainsKey(0))
ISpace["ExecutionMessage"].Value = resultFBADFA2FE68E4BCBA058D7C63AAD5730[0];
}
else{
ISpace["ExecutionMessage"].Value = null;
}
base.WriteDebugInfo(@"EXEC InnovaceNoCode..[GridSave_FC9B8D2E-9EE3-436F-AF08-A774AF04D678]   '@@gv_InstanceId','@@gv_ActivityMapId','FC9B8D2E-9EE3-436F-AF08-A774AF04D678'");

var querySourceF928C371839D4F0FAF8DBCADF87418A6 =GetQueryExpressionDataSource("F928C371-839D-4F0F-AF8D-BCADF87418A6");
Dictionary<short,object> resultF928C371839D4F0FAF8DBCADF87418A6=iSpace.ExecuteQuery(querySourceF928C371839D4F0FAF8DBCADF87418A6,@"EXEC InnovaceNoCode..[GridSave_FC9B8D2E-9EE3-436F-AF08-A774AF04D678]   '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','FC9B8D2E-9EE3-436F-AF08-A774AF04D678'",false);

base.WriteDebugInfo(@"var querySourceF928C371839D4F0FAF8DBCADF87418A6 =GetQueryExpressionDataSource(""F928C371-839D-4F0F-AF8D-BCADF87418A6"");Dictionary<short,object> resultF928C371839D4F0FAF8DBCADF87418A6=iSpace.ExecuteQuery(querySourceF928C371839D4F0FAF8DBCADF87418A6,@""EXEC InnovaceNoCode..[GridSave_FC9B8D2E-9EE3-436F-AF08-A774AF04D678]   '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','FC9B8D2E-9EE3-436F-AF08-A774AF04D678'"",false);");
base.WriteDebugInfo(@"");

if((resultF928C371839D4F0FAF8DBCADF87418A6!=null) && (resultF928C371839D4F0FAF8DBCADF87418A6.Count!=0))
{
if(resultF928C371839D4F0FAF8DBCADF87418A6.ContainsKey(0))
ISpace["ExecutionMessage"].Value = resultF928C371839D4F0FAF8DBCADF87418A6[0];
}
else{
ISpace["ExecutionMessage"].Value = null;
}
ISpace["Message"].Value=@"Success:Submitted Successfully";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Success:Submitted Successfully"";");

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
private void SubscribeElementEvents_m_moveto (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"M_MoveTo-OnChange");
if(ISpace["M_MoveTo"].Value=="APPROVE")
{
base.WriteDebugInfo(@"if(ISpace[""M_MoveTo""].Value==""APPROVE"")");
ISpace["MF_d1_ProjectStatus"].Value="2";
base.WriteDebugInfo(@"ISpace[""MF_d1_ProjectStatus""].Value=""2"";");
}
if(ISpace["M_MoveTo"].Value=="REJECT")
{
base.WriteDebugInfo(@"if(ISpace[""M_MoveTo""].Value==""REJECT"")");
ISpace["MF_d1_ProjectStatus"].Value="4";
base.WriteDebugInfo(@"ISpace[""MF_d1_ProjectStatus""].Value=""4"";");
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
private void SubscribeElementEvents_mfg_d2_departmentid (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MFG_d2_Departmentid-OnChange");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["MFG_d2_AdditionalName"].rElemData=iSpace.Reload(ISpace["MFG_d2_AdditionalName"].Value,@"EXEC GetDepartmentWiseFacultyCopi '" + ISpace["MFG_d2_Departmentid"].Value + @"',3,'" + ISpace["DummyInstance"].Value + @"',''","3A103712-5244-4427-B2B6-1C4E046FD337");
base.WriteDebugInfo(@"ISpace[""MFG_d2_AdditionalName""].rElemData=iSpace.Reload(ISpace[""MFG_d2_AdditionalName""].Value,@""EXEC GetDepartmentWiseFacultyCopi '"" + ISpace[""MFG_d2_Departmentid""].Value + @""',3,'"" + ISpace[""DummyInstance""].Value + @""',''"",""3A103712-5244-4427-B2B6-1C4E046FD337"");");
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mf_d1_fundingagency (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MF_d1_FundingAgency-OnChange");

var querySource18f009fa842f90cf5d3c5263dc607c23 =GetQueryExpressionDataSource("18f009fa-842f-90cf-5d3c-5263dc607c23");

DataTable result18f009fa842f90cf5d3c5263dc607c23=iSpace.SetGridDataSource(querySource18f009fa842f90cf5d3c5263dc607c23, _objectFactory.GetGridRPP("RequiredDocuments"),@"EXEC GetProposalDocumentList 1,'" + ISpace["MF_d1_FundingAgency"].Value + @"','" + ISpace["MF_d1_ProjectCategoryID"].Value + @"'");

iSpace.InsertGridBindDetails("RequiredDocuments","11",querySource18f009fa842f90cf5d3c5263dc607c23,"EXEC GetProposalDocumentList 1,'" + ISpace["MF_d1_FundingAgency"].Value + @"','" + ISpace["MF_d1_ProjectCategoryID"].Value + @"'",_objectFactory.GetGridRPP("RequiredDocuments"));

base.WriteDebugInfo(@"var querySource18f009fa842f90cf5d3c5263dc607c23 =GetQueryExpressionDataSource(""18f009fa-842f-90cf-5d3c-5263dc607c23"");DataTable result18f009fa842f90cf5d3c5263dc607c23=iSpace.SetGridDataSource(querySource18f009fa842f90cf5d3c5263dc607c23, _objectFactory.GetGridRPP(""RequiredDocuments""),@""EXEC GetProposalDocumentList 1,'"" + ISpace[""MF_d1_FundingAgency""].Value + @""','"" + ISpace[""MF_d1_ProjectCategoryID""].Value + @""'"");iSpace.InsertGridBindDetails(""RequiredDocuments"",""11"",querySource18f009fa842f90cf5d3c5263dc607c23,""EXEC GetProposalDocumentList 1,'"" + ISpace[""MF_d1_FundingAgency""].Value + @""','"" + ISpace[""MF_d1_ProjectCategoryID""].Value + @""'"",_objectFactory.GetGridRPP(""RequiredDocuments""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result46a77cd670de6252e1d62429032e267f=acdataIspace2D400E54E6D143C798243831B9AD8F32.GetQueryExpressionBindings("46a77cd6-70de-6252-e1d6-2429032e267f");
iSpace.SetGridData(result18f009fa842f90cf5d3c5263dc607c23,result46a77cd670de6252e1d62429032e267f,"RequiredDocuments",ref ISpace);
iSpace.UpdateGridBindDetails("RequiredDocuments",result46a77cd670de6252e1d62429032e267f);
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mfg_d2_additionaltype (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MFG_d2_AdditionalType-OnChange");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["MFG_d2_Departmentid"].rElemData=iSpace.Reload(ISpace["MFG_d2_Departmentid"].Value,@"EXEC [GetDepartmentWiseFacultyCopi] '" + ISpace["M_DepartmentId"].Value + @"',2,'" + ISpace["DummyInstance"].Value + @"','" + ISpace["MFG_d2_AdditionalType"].Value + @"'","3A103712-5244-4427-B2B6-1C4E046FD337");
base.WriteDebugInfo(@"ISpace[""MFG_d2_Departmentid""].rElemData=iSpace.Reload(ISpace[""MFG_d2_Departmentid""].Value,@""EXEC [GetDepartmentWiseFacultyCopi] '"" + ISpace[""M_DepartmentId""].Value + @""',2,'"" + ISpace[""DummyInstance""].Value + @""','"" + ISpace[""MFG_d2_AdditionalType""].Value + @""'"",""3A103712-5244-4427-B2B6-1C4E046FD337"");");
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
		if(elementName.ToLower().Equals("mg_d3_uploaddocument"))
    {
    			SubscribeElementEvents_mg_d3_uploaddocument(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mf_d1_projectcategoryid"))
    {
    			SubscribeElementEvents_mf_d1_projectcategoryid(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mf_d1_projecttype"))
    {
    			SubscribeElementEvents_mf_d1_projecttype(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mfg_d2_membertype"))
    {
    			SubscribeElementEvents_mfg_d2_membertype(ref dfsParam);
    }
		if(elementName.ToLower().Equals("m_moveto"))
    {
    			SubscribeElementEvents_m_moveto(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mfg_d2_departmentid"))
    {
    			SubscribeElementEvents_mfg_d2_departmentid(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mf_d1_fundingagency"))
    {
    			SubscribeElementEvents_mf_d1_fundingagency(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mfg_d2_additionaltype"))
    {
    			SubscribeElementEvents_mfg_d2_additionaltype(ref dfsParam);
    }
}
	if(methodName.ToLower().Equals("onclick"))
{
		if(elementName.ToLower().Equals("save_copidetails"))
{
			SubscribeElementEvents_save_copidetails(ref dfsParam);
}
		if(elementName.ToLower().Equals("copi_no"))
{
			SubscribeElementEvents_copi_no(ref dfsParam);
}
		if(elementName.ToLower().Equals("copi_yes"))
{
			SubscribeElementEvents_copi_yes(ref dfsParam);
}
		if(elementName.ToLower().Equals("edit_copidetails"))
{
			SubscribeElementEvents_edit_copidetails(ref dfsParam);
}
		if(elementName.ToLower().Equals("m_history"))
{
			SubscribeElementEvents_m_history(ref dfsParam);
}
		if(elementName.ToLower().Equals("delete_copidetails"))
{
			SubscribeElementEvents_delete_copidetails(ref dfsParam);
}
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

using System.Collections.Generic;
using System;
using CPS.Proof.DFSExtension;
using System.Linq;using System.Data;
using System.Runtime.CompilerServices;
public class ISpace6d06ae9bb5873c74a7473b1063ed2f0d : VirtualForm
{
IISpace iSpace = new ISpace();
AcDataISpace6d06ae9bb5873c74a7473b1063ed2f0d acdataIspace6d06ae9bb5873c74a7473b1063ed2f0d=new AcDataISpace6d06ae9bb5873c74a7473b1063ed2f0d();
private void SubscribeFormEvents_root(ref Dictionary<string, ServiceElementData> ISpace)
{
try
{
base.WriteDebugInfo(@"Root-OnAfterFormLoad");
ISpace["M_DepartmentId"].Visible="false";ISpace["MF_d1_Currency"].Visible="false";ISpace["M_DesignationId"].Visible="false";ISpace["MF_d1_EmployeeBasicInfoId"].Visible="false";
base.WriteDebugInfo(@"ISpace[""M_DepartmentId""].Visible=""false"";ISpace[""MF_d1_Currency""].Visible=""false"";ISpace[""M_DesignationId""].Visible=""false"";ISpace[""MF_d1_EmployeeBasicInfoId""].Visible=""false"";");
ISpace["MFG_d2_DesignationID"].Visible="false";ISpace["MFG_d2_ExternalInstituteName"].Visible="false";ISpace["MFG_d2_ExternalEmailId"].Visible="false";ISpace["MFG_d2_ExternalContactNo"].Visible="false";ISpace["MFG_d2_ExternalDesignation"].Visible="false";ISpace["MFG_d2_ExternalFacultyName"].Visible="false";ISpace["MFG_d2_AdditionalName"].Visible="false";ISpace["MFG_d2_Departmentid"].Visible="false";ISpace["MFG_d2_AdditionalType"].Visible="false";
base.WriteDebugInfo(@"ISpace[""MFG_d2_DesignationID""].Visible=""false"";ISpace[""MFG_d2_ExternalInstituteName""].Visible=""false"";ISpace[""MFG_d2_ExternalEmailId""].Visible=""false"";ISpace[""MFG_d2_ExternalContactNo""].Visible=""false"";ISpace[""MFG_d2_ExternalDesignation""].Visible=""false"";ISpace[""MFG_d2_ExternalFacultyName""].Visible=""false"";ISpace[""MFG_d2_AdditionalName""].Visible=""false"";ISpace[""MFG_d2_Departmentid""].Visible=""false"";ISpace[""MFG_d2_AdditionalType""].Visible=""false"";");
if(ISpace["FormVersionId"].Value=="FA963D46-2D52-4A3E-8550-E878A2504252")
{
ISpace["UI_InvisibleRow"].Visible="false";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""FA963D46-2D52-4A3E-8550-E878A2504252"")
{
ISpace[""UI_InvisibleRow""].Visible=""false"";
}");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySource5c6a584da4e2b467f6c2c66f0c409f6c =GetQueryExpressionDataSource("5c6a584d-a4e2-b467-f6c2-c66f0c409f6c");

DataTable result5c6a584da4e2b467f6c2c66f0c409f6c=iSpace.SetGridDataSource(querySource5c6a584da4e2b467f6c2c66f0c409f6c, _objectFactory.GetGridRPP("MG_Comments"),@"EXEC [GetInstanceFlowDetais] '" + ISpace["gv_instanceid"].Value + @"'");

iSpace.InsertGridBindDetails("MG_Comments","11",querySource5c6a584da4e2b467f6c2c66f0c409f6c,"EXEC [GetInstanceFlowDetais] '" + ISpace["gv_instanceid"].Value + @"'",_objectFactory.GetGridRPP("MG_Comments"));

base.WriteDebugInfo(@"var querySource5c6a584da4e2b467f6c2c66f0c409f6c =GetQueryExpressionDataSource(""5c6a584d-a4e2-b467-f6c2-c66f0c409f6c"");DataTable result5c6a584da4e2b467f6c2c66f0c409f6c=iSpace.SetGridDataSource(querySource5c6a584da4e2b467f6c2c66f0c409f6c, _objectFactory.GetGridRPP(""MG_Comments""),@""EXEC [GetInstanceFlowDetais] '"" + ISpace[""gv_instanceid""].Value + @""'"");iSpace.InsertGridBindDetails(""MG_Comments"",""11"",querySource5c6a584da4e2b467f6c2c66f0c409f6c,""EXEC [GetInstanceFlowDetais] '"" + ISpace[""gv_instanceid""].Value + @""'"",_objectFactory.GetGridRPP(""MG_Comments""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result803558a97e53bd55f2b553d65d8b0305=acdataIspace6d06ae9bb5873c74a7473b1063ed2f0d.GetQueryExpressionBindings("803558a9-7e53-bd55-f2b5-53d65d8b0305");
iSpace.SetGridData(result5c6a584da4e2b467f6c2c66f0c409f6c,result803558a97e53bd55f2b553d65d8b0305,"MG_Comments",ref ISpace);
iSpace.UpdateGridBindDetails("MG_Comments",result803558a97e53bd55f2b553d65d8b0305);
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

var querySource5c6a584da4e2b467f6c2c66f0c409f6c =GetQueryExpressionDataSource("5c6a584d-a4e2-b467-f6c2-c66f0c409f6c");

DataTable result5c6a584da4e2b467f6c2c66f0c409f6c=iSpace.SetGridDataSource(querySource5c6a584da4e2b467f6c2c66f0c409f6c, _objectFactory.GetGridRPP("MG_Comments"),@"EXEC [GetInstanceFlowDetais] '" + ISpace["gv_instanceid"].Value + @"'");

iSpace.InsertGridBindDetails("MG_Comments","11",querySource5c6a584da4e2b467f6c2c66f0c409f6c,"EXEC [GetInstanceFlowDetais] '" + ISpace["gv_instanceid"].Value + @"'",_objectFactory.GetGridRPP("MG_Comments"));

base.WriteDebugInfo(@"var querySource5c6a584da4e2b467f6c2c66f0c409f6c =GetQueryExpressionDataSource(""5c6a584d-a4e2-b467-f6c2-c66f0c409f6c"");DataTable result5c6a584da4e2b467f6c2c66f0c409f6c=iSpace.SetGridDataSource(querySource5c6a584da4e2b467f6c2c66f0c409f6c, _objectFactory.GetGridRPP(""MG_Comments""),@""EXEC [GetInstanceFlowDetais] '"" + ISpace[""gv_instanceid""].Value + @""'"");iSpace.InsertGridBindDetails(""MG_Comments"",""11"",querySource5c6a584da4e2b467f6c2c66f0c409f6c,""EXEC [GetInstanceFlowDetais] '"" + ISpace[""gv_instanceid""].Value + @""'"",_objectFactory.GetGridRPP(""MG_Comments""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result803558a97e53bd55f2b553d65d8b0305=acdataIspace6d06ae9bb5873c74a7473b1063ed2f0d.GetQueryExpressionBindings("803558a9-7e53-bd55-f2b5-53d65d8b0305");
iSpace.SetGridData(result5c6a584da4e2b467f6c2c66f0c409f6c,result803558a97e53bd55f2b553d65d8b0305,"MG_Comments",ref ISpace);
iSpace.UpdateGridBindDetails("MG_Comments",result803558a97e53bd55f2b553d65d8b0305);
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
		if(elementName.ToLower().Equals("m_history"))
{
			SubscribeElementEvents_m_history(ref dfsParam);
}
		if(elementName.ToLower().Equals("m_back"))
{
			SubscribeElementEvents_m_back(ref dfsParam);
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


	public partial class AcDataISpaceB3A493374C4B42EC9F9B1C4C8B4E2E13  : ExtensionActivityBase
	{		
		
		
		private Dictionary<string,  List<Triplet<string, short, short?>>> queryExpressionBindings = 
											new Dictionary<string,  List<Triplet<string, short, short?>>>
		{
							{"2FAC01E5-8540-4425-AD01-42973E87B3C5", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("CopiDetails_RowId",13,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_UpdatedOn",12,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_ExternalEmailId",9,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_Departmentid",4,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_ExternalDesignation",8,
														   -1),
								   new Triplet<string, short, short?>("MG_AdditionalTypeValue",18,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_AdditionalID",0,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_AdditionalName",3,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_ProjectDetailsID",1,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_ExternalContactNo",10,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_UpdatedBy",11,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_AdditionalType",2,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_MemberType",14,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_DesignationID",5,
														   -1),
								   new Triplet<string, short, short?>("MG_MemberTypeValue",15,
														   -1),
								   new Triplet<string, short, short?>("MG_EmployeeDepartment",17,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_ExternalFacultyName",7,
														   -1),
								   new Triplet<string, short, short?>("MG_EmployeeName",16,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_ExternalInstituteName",6,
														   -1),
								}
			},
							{"BE604E66-309D-4989-879C-431B3984B4B4", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_d2_UpdatedBy",11,
														   -1),
								   new Triplet<string, short, short?>("MG_EmployeeName",16,
														   -1),
								   new Triplet<string, short, short?>("MG_MemberTypeValue",15,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_AdditionalType",2,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_ExternalInstituteName",6,
														   -1),
								   new Triplet<string, short, short?>("CopiDetails_RowId",13,
														   -1),
								   new Triplet<string, short, short?>("MG_AdditionalTypeValue",18,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_ExternalDesignation",8,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_ProjectDetailsID",1,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_ExternalFacultyName",7,
														   -1),
								   new Triplet<string, short, short?>("MG_EmployeeDepartment",17,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_MemberType",14,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_Departmentid",4,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_DesignationID",5,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_AdditionalID",0,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_UpdatedOn",12,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_ExternalEmailId",9,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_ExternalContactNo",10,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_AdditionalName",3,
														   -1),
								}
			},
							{"e94499bc-4a5f-3d1c-af8a-e6389d08f460", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("CopiDetails_RowId",13,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_Departmentid",4,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_UpdatedBy",11,
														   -1),
								   new Triplet<string, short, short?>("MG_MemberTypeValue",15,
														   -1),
								   new Triplet<string, short, short?>("MG_EmployeeName",16,
														   -1),
								   new Triplet<string, short, short?>("MG_EmployeeDepartment",17,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_AdditionalType",2,
														   -1),
								   new Triplet<string, short, short?>("MG_AdditionalTypeValue",18,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_ExternalEmailId",9,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_AdditionalID",0,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_ExternalContactNo",10,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_ExternalInstituteName",6,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_ProjectDetailsID",1,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_UpdatedOn",12,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_ExternalFacultyName",7,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_DesignationID",5,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_MemberType",14,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_AdditionalName",3,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_ExternalDesignation",8,
														   -1),
								}
			},
							{"ef1f2ec4-a6cb-dd23-1f52-fd0b0d03ba57", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_d3_ProposalDocumentID",0,
														   -1),
								   new Triplet<string, short, short?>("MG_d3_MandatoryCheck",3,
														   -1),
								   new Triplet<string, short, short?>("MG_d3_DocumentName",1,
														   -1),
								   new Triplet<string, short, short?>("MG_d3_DocumentProposalID",2,
														   -1),
								}
			},
							{"46a77cd6-70de-6252-e1d6-2429032e267f", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_d4_Categorymapid",0,
														   -1),
								   new Triplet<string, short, short?>("MG_d4_DocumentName",1,
														   -1),
								   new Triplet<string, short, short?>("MG_d4_DocumentId",2,
														   -1),
								}
			},
					};	

	

		private Dictionary<string,string> formVersionList =new Dictionary<string,string> 
		{
							{"FA963D46-2D52-4A3E-8550-E878A2504252", "Medium"},
					};	

		
		private Dictionary<string,string> formVersionLayoutList =new Dictionary<string,string> 
		{
							{"DF310904-3D78-478E-96E3-680D8603C3F5", ""},
							{"455D44C8-AF0E-4EC6-84C7-8BB6DBAB2069", ""},
							{"FA963D46-2D52-4A3E-8550-E878A2504252", ""},
							{"8A4BBE80-7A6F-48C4-A74C-6D3EC9C624C2", ""},
							{"62054835-2416-4D48-997B-E9F3C389419D", ""},
							{"9B9F8832-C7E8-4A33-AF15-9156440FCBC0", ""},
							{"3AD59A17-0AA6-4617-8D26-9A6E24C1798C", ""},
							{"32BA2907-8800-47E8-AF75-63818566D79A", ""},
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


	public partial class AcDataISpaceF692D0262B48418C9285DBD42DAC5F26  : ExtensionActivityBase
	{		
		
		
		private Dictionary<string,  List<Triplet<string, short, short?>>> queryExpressionBindings = 
											new Dictionary<string,  List<Triplet<string, short, short?>>>
		{
							{"803558a9-7e53-bd55-f2b5-53d65d8b0305", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("C_Comments",5,
														   -1),
								   new Triplet<string, short, short?>("C_Stepfrom",1,
														   -1),
								   new Triplet<string, short, short?>("C_DateofComments",4,
														   -1),
								   new Triplet<string, short, short?>("C_StepTo",2,
														   -1),
								   new Triplet<string, short, short?>("C_User",3,
														   -1),
								}
			},
							{"e94499bc-4a5f-3d1c-af8a-e6389d08f460", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("CopiDetails_RowId",13,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_Departmentid",4,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_UpdatedBy",11,
														   -1),
								   new Triplet<string, short, short?>("MG_MemberTypeValue",15,
														   -1),
								   new Triplet<string, short, short?>("MG_EmployeeName",16,
														   -1),
								   new Triplet<string, short, short?>("MG_EmployeeDepartment",17,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_AdditionalType",2,
														   -1),
								   new Triplet<string, short, short?>("MG_AdditionalTypeValue",18,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_ExternalEmailId",9,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_AdditionalID",0,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_ExternalContactNo",10,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_ExternalInstituteName",6,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_ProjectDetailsID",1,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_UpdatedOn",12,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_ExternalFacultyName",7,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_DesignationID",5,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_MemberType",14,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_AdditionalName",3,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_ExternalDesignation",8,
														   -1),
								}
			},
							{"46a77cd6-70de-6252-e1d6-2429032e267f", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_d4_Categorymapid",0,
														   -1),
								   new Triplet<string, short, short?>("MG_d4_DocumentName",1,
														   -1),
								   new Triplet<string, short, short?>("MG_d4_DocumentId",2,
														   -1),
								}
			},
					};	

	

		private Dictionary<string,string> formVersionList =new Dictionary<string,string> 
		{
							{"FA963D46-2D52-4A3E-8550-E878A2504252", "Medium"},
					};	

		
		private Dictionary<string,string> formVersionLayoutList =new Dictionary<string,string> 
		{
							{"DF310904-3D78-478E-96E3-680D8603C3F5", ""},
							{"455D44C8-AF0E-4EC6-84C7-8BB6DBAB2069", ""},
							{"FA963D46-2D52-4A3E-8550-E878A2504252", ""},
							{"8A4BBE80-7A6F-48C4-A74C-6D3EC9C624C2", ""},
							{"62054835-2416-4D48-997B-E9F3C389419D", ""},
							{"9B9F8832-C7E8-4A33-AF15-9156440FCBC0", ""},
							{"3AD59A17-0AA6-4617-8D26-9A6E24C1798C", ""},
							{"32BA2907-8800-47E8-AF75-63818566D79A", ""},
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


	public partial class AcDataISpace2D400E54E6D143C798243831B9AD8F32  : ExtensionActivityBase
	{		
		
		
		private Dictionary<string,  List<Triplet<string, short, short?>>> queryExpressionBindings = 
											new Dictionary<string,  List<Triplet<string, short, short?>>>
		{
							{"803558a9-7e53-bd55-f2b5-53d65d8b0305", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("C_Comments",5,
														   -1),
								   new Triplet<string, short, short?>("C_Stepfrom",1,
														   -1),
								   new Triplet<string, short, short?>("C_DateofComments",4,
														   -1),
								   new Triplet<string, short, short?>("C_StepTo",2,
														   -1),
								   new Triplet<string, short, short?>("C_User",3,
														   -1),
								}
			},
							{"2FAC01E5-8540-4425-AD01-42973E87B3C5", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("CopiDetails_RowId",13,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_UpdatedOn",12,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_ExternalEmailId",9,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_Departmentid",4,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_ExternalDesignation",8,
														   -1),
								   new Triplet<string, short, short?>("MG_AdditionalTypeValue",18,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_AdditionalID",0,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_AdditionalName",3,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_ProjectDetailsID",1,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_ExternalContactNo",10,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_UpdatedBy",11,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_AdditionalType",2,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_MemberType",14,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_DesignationID",5,
														   -1),
								   new Triplet<string, short, short?>("MG_MemberTypeValue",15,
														   -1),
								   new Triplet<string, short, short?>("MG_EmployeeDepartment",17,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_ExternalFacultyName",7,
														   -1),
								   new Triplet<string, short, short?>("MG_EmployeeName",16,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_ExternalInstituteName",6,
														   -1),
								}
			},
							{"BE604E66-309D-4989-879C-431B3984B4B4", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_d2_UpdatedBy",11,
														   -1),
								   new Triplet<string, short, short?>("MG_EmployeeName",16,
														   -1),
								   new Triplet<string, short, short?>("MG_MemberTypeValue",15,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_AdditionalType",2,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_ExternalInstituteName",6,
														   -1),
								   new Triplet<string, short, short?>("CopiDetails_RowId",13,
														   -1),
								   new Triplet<string, short, short?>("MG_AdditionalTypeValue",18,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_ExternalDesignation",8,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_ProjectDetailsID",1,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_ExternalFacultyName",7,
														   -1),
								   new Triplet<string, short, short?>("MG_EmployeeDepartment",17,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_MemberType",14,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_Departmentid",4,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_DesignationID",5,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_AdditionalID",0,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_UpdatedOn",12,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_ExternalEmailId",9,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_ExternalContactNo",10,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_AdditionalName",3,
														   -1),
								}
			},
							{"e94499bc-4a5f-3d1c-af8a-e6389d08f460", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("CopiDetails_RowId",13,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_Departmentid",4,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_UpdatedBy",11,
														   -1),
								   new Triplet<string, short, short?>("MG_MemberTypeValue",15,
														   -1),
								   new Triplet<string, short, short?>("MG_EmployeeName",16,
														   -1),
								   new Triplet<string, short, short?>("MG_EmployeeDepartment",17,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_AdditionalType",2,
														   -1),
								   new Triplet<string, short, short?>("MG_AdditionalTypeValue",18,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_ExternalEmailId",9,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_AdditionalID",0,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_ExternalContactNo",10,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_ExternalInstituteName",6,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_ProjectDetailsID",1,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_UpdatedOn",12,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_ExternalFacultyName",7,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_DesignationID",5,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_MemberType",14,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_AdditionalName",3,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_ExternalDesignation",8,
														   -1),
								}
			},
							{"46a77cd6-70de-6252-e1d6-2429032e267f", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_d4_Categorymapid",0,
														   -1),
								   new Triplet<string, short, short?>("MG_d4_DocumentName",1,
														   -1),
								   new Triplet<string, short, short?>("MG_d4_DocumentId",2,
														   -1),
								}
			},
					};	

	

		private Dictionary<string,string> formVersionList =new Dictionary<string,string> 
		{
							{"FA963D46-2D52-4A3E-8550-E878A2504252", "Medium"},
					};	

		
		private Dictionary<string,string> formVersionLayoutList =new Dictionary<string,string> 
		{
							{"DF310904-3D78-478E-96E3-680D8603C3F5", ""},
							{"455D44C8-AF0E-4EC6-84C7-8BB6DBAB2069", ""},
							{"FA963D46-2D52-4A3E-8550-E878A2504252", ""},
							{"8A4BBE80-7A6F-48C4-A74C-6D3EC9C624C2", ""},
							{"62054835-2416-4D48-997B-E9F3C389419D", ""},
							{"9B9F8832-C7E8-4A33-AF15-9156440FCBC0", ""},
							{"3AD59A17-0AA6-4617-8D26-9A6E24C1798C", ""},
							{"32BA2907-8800-47E8-AF75-63818566D79A", ""},
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


	public partial class AcDataISpace6d06ae9bb5873c74a7473b1063ed2f0d  : ExtensionActivityBase
	{		
		
		
		private Dictionary<string,  List<Triplet<string, short, short?>>> queryExpressionBindings = 
											new Dictionary<string,  List<Triplet<string, short, short?>>>
		{
							{"803558a9-7e53-bd55-f2b5-53d65d8b0305", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("C_Comments",5,
														   -1),
								   new Triplet<string, short, short?>("C_Stepfrom",1,
														   -1),
								   new Triplet<string, short, short?>("C_DateofComments",4,
														   -1),
								   new Triplet<string, short, short?>("C_StepTo",2,
														   -1),
								   new Triplet<string, short, short?>("C_User",3,
														   -1),
								}
			},
							{"e94499bc-4a5f-3d1c-af8a-e6389d08f460", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("CopiDetails_RowId",13,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_Departmentid",4,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_UpdatedBy",11,
														   -1),
								   new Triplet<string, short, short?>("MG_MemberTypeValue",15,
														   -1),
								   new Triplet<string, short, short?>("MG_EmployeeName",16,
														   -1),
								   new Triplet<string, short, short?>("MG_EmployeeDepartment",17,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_AdditionalType",2,
														   -1),
								   new Triplet<string, short, short?>("MG_AdditionalTypeValue",18,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_ExternalEmailId",9,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_AdditionalID",0,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_ExternalContactNo",10,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_ExternalInstituteName",6,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_ProjectDetailsID",1,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_UpdatedOn",12,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_ExternalFacultyName",7,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_DesignationID",5,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_MemberType",14,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_AdditionalName",3,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_ExternalDesignation",8,
														   -1),
								}
			},
							{"46a77cd6-70de-6252-e1d6-2429032e267f", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_d4_Categorymapid",0,
														   -1),
								   new Triplet<string, short, short?>("MG_d4_DocumentName",1,
														   -1),
								   new Triplet<string, short, short?>("MG_d4_DocumentId",2,
														   -1),
								}
			},
					};	

	

		private Dictionary<string,string> formVersionList =new Dictionary<string,string> 
		{
							{"FA963D46-2D52-4A3E-8550-E878A2504252", "Medium"},
					};	

		
		private Dictionary<string,string> formVersionLayoutList =new Dictionary<string,string> 
		{
							{"DF310904-3D78-478E-96E3-680D8603C3F5", ""},
							{"455D44C8-AF0E-4EC6-84C7-8BB6DBAB2069", ""},
							{"FA963D46-2D52-4A3E-8550-E878A2504252", ""},
							{"8A4BBE80-7A6F-48C4-A74C-6D3EC9C624C2", ""},
							{"62054835-2416-4D48-997B-E9F3C389419D", ""},
							{"9B9F8832-C7E8-4A33-AF15-9156440FCBC0", ""},
							{"3AD59A17-0AA6-4617-8D26-9A6E24C1798C", ""},
							{"32BA2907-8800-47E8-AF75-63818566D79A", ""},
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
		


