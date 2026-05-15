  







namespace CPS.Proof.DFSExtension
{
	using System;
    using System.Collections.Generic;     
	using System.Linq;
	
	
	public partial class ProjectReimbursementProcessMetadata : ExtensionProcessBase
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
            get { return "B1037B85-D9C1-411B-87DE-0658365B81A8"; }
        }

        public override string ProcessName
        {
            get { return "ProjectReimbursement"; }
        }

		public override string ProcessDescription
        {
            get { return "Project Reimbursement"; }
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
            get {return "B1037B85-D9C1-411B-87DE-0658365B81A8";}
        }

		public override byte ProcessInstanceMode
        {
            get {return 3;}
        }		

		public override string MasterFormId
        {
            get {  
				   return "93D6004F-3BCB-4A62-A41B-473BC5A0F0ED";	}
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
	

	public partial class ProjectReimbursementObjectFactory  : ExtObjectFactoryBase
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
        //    return (IExtBaseMetaData)new ProjectReimbursementProcessMetadata();
        //}
	


		private List<Triplet<string, string, string>> queryExpressionData = new List<Triplet<string, string, string>>
		{
	  			
			     new Triplet<string, string, string>("1F49FB0D-A84D-47A5-8942-368F58A2D97A","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"2F28A839-0875-4C17-8ADF-2FC7F8F8847C"),
			
						
			     new Triplet<string, string, string>("959A027E-58AA-471D-ADF1-501D54E16A1B","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"9ADED37B-CD11-426B-AF16-DEAC75685EF5"),
			
						
			     new Triplet<string, string, string>("820D767A-20CC-4BA1-AADC-A484B0BFBEFA","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"9ADED37B-CD11-426B-AF16-DEAC75685EF5"),
			
						
			     new Triplet<string, string, string>("3BC8920E-9488-421C-BBA1-6D92ECF94CB2","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"2F28A839-0875-4C17-8ADF-2FC7F8F8847C"),
			
						
			     new Triplet<string, string, string>("87cbcf91-1fba-16fd-3029-f8855a072138","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("501CB7C7-6A07-43B9-965B-700958ACB8D8","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"9ADED37B-CD11-426B-AF16-DEAC75685EF5"),
			
						
			     new Triplet<string, string, string>("CBB39281-01F4-4B3A-B892-47A0222DAFBA","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"2F28A839-0875-4C17-8ADF-2FC7F8F8847C"),
			
						
			     new Triplet<string, string, string>("334BDAE0-A76B-4B0F-84BC-AEF7F4F927FE","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"2F28A839-0875-4C17-8ADF-2FC7F8F8847C"),
			
						
			     new Triplet<string, string, string>("478236c4-5c79-3773-d354-02c74092c916","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("d58dc3c8-687f-1ebc-d475-4068de464713","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("0ac6af4e-84d7-e8d4-0994-6108bb08331c","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("17adfd2b-bf7a-a796-8851-003732efc9c7","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("f9e187b2-10af-cb84-3cd9-43870f735c13","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("9DA02CB3-5092-4C4C-9B65-5E0BE2B0C944","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("C27F66A4-6C24-43FF-8C14-9CEB345FD074","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("000156F0-11EC-4492-A054-7C093B6DAE0A","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"028B1EFF-34A8-4D44-BF39-06CE99DF7C67"),
			
						
			     new Triplet<string, string, string>("1AE2D056-5D6C-472F-96B1-8D59F543FEE1","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("00E65BF5-4289-49A4-9522-8BFA76F6F516","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("8D078B34-2273-40D4-A2DD-23A371ABE1A6","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"2F28A839-0875-4C17-8ADF-2FC7F8F8847C"),
			
						
			     new Triplet<string, string, string>("9B5B780E-4C6E-4FCE-A2BD-A3A4764A9120","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"2F28A839-0875-4C17-8ADF-2FC7F8F8847C"),
			
						
			     new Triplet<string, string, string>("B5618765-36C3-484C-A564-3707FD364056","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"2F28A839-0875-4C17-8ADF-2FC7F8F8847C"),
			
						
			     new Triplet<string, string, string>("65F843A2-27D0-4177-B79D-CF4225F30450","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("befdd5b2-07e9-12dc-5d36-82026e5e2134","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("71BB9B08-DE61-44CB-80C5-CC85FCFEF138","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"2F28A839-0875-4C17-8ADF-2FC7F8F8847C"),
			
						
			     new Triplet<string, string, string>("59AD5C1B-340B-4461-9071-60C69FF84844","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("BA4985A9-C4A2-4DC6-BBD1-661F0431909A","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("068CB074-46DC-429F-9887-7296FCE9263F","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("820D767A-20CC-4BA1-AADC-A484B0BFBEFA","Load Remarks Details",
												     @"B49EFF11-DEBD-4F34-BEC5-7C607851D347"),
			
						
			     new Triplet<string, string, string>("CBB39281-01F4-4B3A-B892-47A0222DAFBA","Grid BindingC",
												     @"84AEB9E0-3009-4426-AB92-AAF06D2B42AF"),
			
						
			     new Triplet<string, string, string>("334BDAE0-A76B-4B0F-84BC-AEF7F4F927FE","Grid BindingA",
												     @"84AEB9E0-3009-4426-AB92-AAF06D2B42AF"),
			
						
			     new Triplet<string, string, string>("8D078B34-2273-40D4-A2DD-23A371ABE1A6","Grid BindingB",
												     @"1D198218-D4AF-4E09-9A9D-119D03D0C3BA"),
			
						
			     new Triplet<string, string, string>("9B5B780E-4C6E-4FCE-A2BD-A3A4764A9120","Grid BindingC",
												     @"1D198218-D4AF-4E09-9A9D-119D03D0C3BA"),
			
						
			     new Triplet<string, string, string>("B5618765-36C3-484C-A564-3707FD364056","Delete Records",
												     @"1D198218-D4AF-4E09-9A9D-119D03D0C3BA"),
			
						
			     new Triplet<string, string, string>("71BB9B08-DE61-44CB-80C5-CC85FCFEF138","Delete Records",
												     @"84AEB9E0-3009-4426-AB92-AAF06D2B42AF"),
			
						
			     new Triplet<string, string, string>("068CB074-46DC-429F-9887-7296FCE9263F","Load Commitments",
												     @"B3C42BFD-4F71-4A59-BC58-E5B5C95B481C"),
			
			
			
		};

		
		private List<Triplet<string, string, string>> ComboDataSource = new List<Triplet<string, string, string>>
		{

		
	  			
			     new Triplet<string, string, string>("M_Classification","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw1z/z9sf1712IST2TisZRbDL01cRO080NYHWsKvkYJS77XPhhEPANfatU8lJP0mJJjSopgrwrPOlAa7ekRdWJpCoSneyUlDBd6d1RrcOybG3s",
												     @"exec LoadPurchaseItemCombo"),
			
						
			     new Triplet<string, string, string>("M_ReimbursementType","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw1z/z9sf1712IST2TisZRbDL01cRO080NYHWsKvkYJS77XPhhEPANfatU8lJP0mJJjSopgrwrPOlAa7ekRdWJpCoSneyUlDBd6d1RrcOybG3s",
												     @"EXEC GetReimbursementType"),
			
						
			     new Triplet<string, string, string>("MG_P3_BudgetHeadId","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw1z/z9sf1712IST2TisZRbDL01cRO080NYHWsKvkYJS77cc4eTVUER6yxhHgktDkfvWfwBNgoOezuhR3VTahYodgYs1XIsswI0A==",
												     @"exec SP_GetDistrubitionDetails 5,'@MG_P3_PackageProcessMapId','@MG_P3_FundTypeId','','','','','@MG_P3_ProjectDetailsId'"),
			
						
			     new Triplet<string, string, string>("MFG_P3_BudgetHeadId","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw1z/z9sf1712IST2TisZRbDL01cRO080NYHWsKvkYJS77cc4eTVUER6yxhHgktDkfvWfwBNgoOezuhR3VTahYodgYs1XIsswI0A==",
												     @"exec SP_GetDistrubitionDetails 5,'@M_PackageProcessMapId','@MFG_P3_FundTypeId','','','','','@MFG_P3_ProjectDetailsId'"),
			
						
			     new Triplet<string, string, string>("MG_P3_ProjectDetailsId","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw1z/z9sf1712IST2TisZRbDL01cRO080NYHWsKvkYJS77XPhhEPANfatU8lJP0mJJjSopgrwrPOlAa7ekRdWJpCoSneyUlDBd6d1RrcOybG3s",
												     @"EXEC Projects..GetProjectExtensionDetails 1,'@MG_P3_EmployeeBaicInfoId'"),
			
						
			     new Triplet<string, string, string>("MFG_P3_ProjectDetailsId","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw1z/z9sf1712IST2TisZRbDL01cRO080NYHWsKvkYJS77XPhhEPANfatU8lJP0mJJjSopgrwrPOlAa7ekRdWJpCoSneyUlDBd6d1RrcOybG3s",
												     @"EXEC Projects..GetProjectExtensionDetails 1,'@UC_EmployeeBaicInfoId'"),
			
						
			     new Triplet<string, string, string>("MFG_P3_FundTypeId","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw1z/z9sf1712IST2TisZRbDL01cRO080NYHWsKvkYJS77cc4eTVUER6yxhHgktDkfvWfwBNgoOezuhR3VTahYodgYs1XIsswI0A==",
												     @"exec SP_GetDistrubitionDetails 4,'@M_PackageProcessMapId','',''"),
			
						
			     new Triplet<string, string, string>("M_SubClassication","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw1z/z9sf1712IST2TisZRbDL01cRO080NYHWsKvkYJS77XPhhEPANfatU8lJP0mJJjSopgrwrPOlAa7ekRdWJpCoSneyUlDBd6d1RrcOybG3s",
												     @"exec LoadItemSubCombo '@M_Classification'"),
			
						
			     new Triplet<string, string, string>("MF_ProjectNo","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw1z/z9sf1712IST2TisZRbDL01cRO080NYHWsKvkYJS77XPhhEPANfatU8lJP0mJJjSopgrwrPOlAa7ekRdWJpCoSneyUlDBd6d1RrcOybG3s",
												     @"EXEC GetProjectExtensionDetails 1,'@UC_EmployeeBaicInfoId'"),
			
						
			     new Triplet<string, string, string>("MG_P3_FundTypeId","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw1z/z9sf1712IST2TisZRbDL01cRO080NYHWsKvkYJS77cc4eTVUER6yxhHgktDkfvWfwBNgoOezuhR3VTahYodgYs1XIsswI0A==",
												     @"exec SP_GetDistrubitionDetails 4,'@MG_P3_PackageProcessMapId','',''"),
			
						
			     new Triplet<string, string, string>("M_MoveTo","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw1z/z9sf1712IST2TisZRbDL01cRO080NYHWsKvkYJS77cc4eTVUER6yxhHgktDkfvWfwBNgoOezuhR3VTahYodgYs1XIsswI0A==",
												     @"EXEC GetMovetoValues '@M_SourceActivityMapId','@M_PackageProcessMapId'"),
			
						
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
		
	  			
			     new Tuple<string, int>("MG_CommitmentDetails",1000),
			
						
			     new Tuple<string, int>("ReimbursementBillDetails",100),
			
						
			     new Tuple<string, int>("ReimbursementFundDetails",25),
			
						
			     new Tuple<string, int>("MG_DcoumentDetails",50),
			
						
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
											case "788CA62E-DF0F-4071-B3E3-4239827AFC52":
							virtualInstance=new ISpace788CA62EDF0F4071B3E34239827AFC52();
							break;
					
											case "01ABEB23-E635-437D-A24F-27342FB92C55":
							virtualInstance=new ISpace01ABEB23E635437DA24F27342FB92C55();
							break;
					
											case "89D38028-FA53-4F9E-89EA-42C506E8E381":
							virtualInstance=new ISpace89D38028FA534F9E89EA42C506E8E381();
							break;
					
											case "C4E2EC4C-58BD-44FB-91D1-3D8E475D6C14":
							virtualInstance=new ISpaceC4E2EC4C58BD44FB91D13D8E475D6C14();
							break;
					
											case "7B9E10F1-A9E8-4A0C-90D9-F183CC3B49D0":
							virtualInstance=new ISpace7B9E10F1A9E84A0C90D9F183CC3B49D0();
							break;
					
											case "DFE5FDDD-AC9D-4714-A581-68E139EAC447":
							virtualInstance=new ISpaceDFE5FDDDAC9D4714A58168E139EAC447();
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
	

	public partial class ProjectReimbursementDataElementFactory  : ExtElementBase
    {

     /// <summary>
        /// A <see cref="log4net.ILog"/> that contains the logger instance for 
        /// logging
        /// </summary>
        private readonly ILog _sysLog;

        public ProjectReimbursementDataElementFactory()
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

               
                
                                      case "93D6004F-3BCB-4A62-A41B-473BC5A0F0ED":
                    {
                     
                                     fInsertQuery=@"IF NOT EXISTS(SELECT 1 FROM [93D6004F-3BCB-4A62-A41B-473BC5A0F0ED] WHERE InstanceId='{0}' AND
							ProcessActivityMapId='{1}' AND FormId='{2}') BEGIN INSERT INTO [93D6004F-3BCB-4A62-A41B-473BC5A0F0ED](ProcessActivityMapId,FormId,KeyContext,UC_Name,MF_P1_InitatedBy,M_MoveToValue,M_NextStage,M_Status,SetDestinationTo,AssignToUser,M_ErrMsg,AssignToRole,MF_P1_UpdatedBy,M_InstanceId,MF_P1_ReimbursementId,Subject,M_DestinationActivityId,ExecutionStatus,ExecutionMessage,UC_PhoneNumber,CancelRedirectUrl,DisplayContext,UC_Designation,UC_Paylevel,M_SourceActivityMapId,UC_Department,ExecuteCommand,UC_Grade,UC_EmployeeBaicInfoId,M_IsSourceStep,IN_Status,IN_Category,M_UpdateCount,M_IsflowReturned,M_IsCancelReject,M_RequestId,M_ErrId,M_RemarksMandatory,SLATime,MF_P1_TotalAmount,M_FieldMandatory,M_SaveDomainData,M_Gridcount,IN_Priority,M_InitiatorUserMapId,UC_DOB,growid,MF_P1_Remarks,RedirectUrl,M_Stage,MF_P1_EmployeeBasicInfoId,UC_DOJ,M_ReimbursementId,IN_SLA,MF_E1_EmployeeBasicInfoId,UC_DOR,UC_EmployeeId,IN_InstanceName,MF_P1_ApplicationStatus,M_PackageProcessMapId,UC_EmailId,M_ReimbursementType,MF_ProjectNo,M_Classification,M_SubClassication,M_MoveTo,MF_P1_Initiatedon,MF_P1_UpdatedOn,Thumbnail,InstanceId)
							VALUES( {3}) END ELSE BEGIN UPDATE [93D6004F-3BCB-4A62-A41B-473BC5A0F0ED]SET {4}WHERE InstanceId='{0}'AND ProcessActivityMapId='{1}'AND FormId='{2}'END ";

                                     colList=@"ProcessActivityMapId,FormId,KeyContext,UC_Name,MF_P1_InitatedBy,M_MoveToValue,M_NextStage,M_Status,SetDestinationTo,AssignToUser,M_ErrMsg,AssignToRole,MF_P1_UpdatedBy,M_InstanceId,MF_P1_ReimbursementId,Subject,M_DestinationActivityId,ExecutionStatus,ExecutionMessage,UC_PhoneNumber,CancelRedirectUrl,DisplayContext,UC_Designation,UC_Paylevel,M_SourceActivityMapId,UC_Department,ExecuteCommand,UC_Grade,UC_EmployeeBaicInfoId,M_IsSourceStep,IN_Status,IN_Category,M_UpdateCount,M_IsflowReturned,M_IsCancelReject,M_RequestId,M_ErrId,M_RemarksMandatory,SLATime,MF_P1_TotalAmount,M_FieldMandatory,M_SaveDomainData,M_Gridcount,IN_Priority,M_InitiatorUserMapId,UC_DOB,growid,MF_P1_Remarks,RedirectUrl,M_Stage,MF_P1_EmployeeBasicInfoId,UC_DOJ,M_ReimbursementId,IN_SLA,MF_E1_EmployeeBasicInfoId,UC_DOR,UC_EmployeeId,IN_InstanceName,MF_P1_ApplicationStatus,M_PackageProcessMapId,UC_EmailId,M_ReimbursementType,MF_ProjectNo,M_Classification,M_SubClassication,M_MoveTo,MF_P1_Initiatedon,MF_P1_UpdatedOn,Thumbnail,InstanceId";
                                    
                     
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

                
                 
                                      case "93570AD2-BC61-4B0C-AE1C-2A20265D17E7":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_93570AD2BC614B0CAE1C2A20265D17E7 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [M_DocumentDetailsId] VARCHAR(MAX)	, [M_DocumentName] VARCHAR(MAX)	, [M_UploadDcoument] VARBINARY(MAX)){0}INSERT INTO [93570AD2-BC61-4B0C-AE1C-2A20265D17E7](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,M_DocumentDetailsId,M_DocumentName,M_UploadDcoument)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.M_DocumentDetailsId,TDT.M_DocumentName,TDT.M_UploadDcoument FROM @TBL_93570AD2BC614B0CAE1C2A20265D17E7 TDT
							LEFT JOIN [93570AD2-BC61-4B0C-AE1C-2A20265D17E7] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,M_DocumentDetailsId,M_DocumentName,M_UploadDcoument";

                                     tempInsertQuery=@"INSERT INTO @TBL_93570AD2BC614B0CAE1C2A20265D17E7(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,M_DocumentDetailsId,M_DocumentName,M_UploadDcoument)VALUES({0});";
                                     

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
                     
                                    case "B3C42BFD-4F71-4A59-BC58-E5B5C95B481C":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_B3C42BFD4F714A59BC58E5B5C95B481C AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_Balance] DECIMAL(18,2)	, [MG_Commitment] DECIMAL(18,2)	, [MG_YetToReceive] DECIMAL(18,2)	, [MG_ReceivedAmount] DECIMAL(18,2)	, [MG_SanctionedAmount] DECIMAL(18,2)	, [MG_Spent] DECIMAL(18,2)	, [MG_BudgetName] VARCHAR(MAX)){0}INSERT INTO [B3C42BFD-4F71-4A59-BC58-E5B5C95B481C](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_Balance,MG_Commitment,MG_YetToReceive,MG_ReceivedAmount,MG_SanctionedAmount,MG_Spent,MG_BudgetName)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_Balance,TDT.MG_Commitment,TDT.MG_YetToReceive,TDT.MG_ReceivedAmount,TDT.MG_SanctionedAmount,TDT.MG_Spent,TDT.MG_BudgetName FROM @TBL_B3C42BFD4F714A59BC58E5B5C95B481C TDT
							LEFT JOIN [B3C42BFD-4F71-4A59-BC58-E5B5C95B481C] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_Balance,MG_Commitment,MG_YetToReceive,MG_ReceivedAmount,MG_SanctionedAmount,MG_Spent,MG_BudgetName";

                                     tempInsertQuery=@"INSERT INTO @TBL_B3C42BFD4F714A59BC58E5B5C95B481C(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_Balance,MG_Commitment,MG_YetToReceive,MG_ReceivedAmount,MG_SanctionedAmount,MG_Spent,MG_BudgetName)VALUES({0});";
                                     

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
                     
                                    case "B49EFF11-DEBD-4F34-BEC5-7C607851D347":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_B49EFF11DEBD4F34BEC57C607851D347 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [RemarksId] VARCHAR(MAX)	, [ActivityName] VARCHAR(MAX)	, [Remarks] VARCHAR(MAX)	, [UserName] VARCHAR(MAX)	, [DateOfRemarks] DATETIME){0}INSERT INTO [B49EFF11-DEBD-4F34-BEC5-7C607851D347](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,RemarksId,ActivityName,Remarks,UserName,DateOfRemarks)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.RemarksId,TDT.ActivityName,TDT.Remarks,TDT.UserName,TDT.DateOfRemarks FROM @TBL_B49EFF11DEBD4F34BEC57C607851D347 TDT
							LEFT JOIN [B49EFF11-DEBD-4F34-BEC5-7C607851D347] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,RemarksId,ActivityName,Remarks,UserName,DateOfRemarks";

                                     tempInsertQuery=@"INSERT INTO @TBL_B49EFF11DEBD4F34BEC57C607851D347(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,RemarksId,ActivityName,Remarks,UserName,DateOfRemarks)VALUES({0});";
                                     

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
                     
                                    case "1D198218-D4AF-4E09-9A9D-119D03D0C3BA":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_1D198218D4AF4E099A9D119D03D0C3BA AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_P2_ReimbursementDetailsId] VARCHAR(MAX)	, [MG_P2_ReimbursementId] VARCHAR(MAX)	, [MG_P2_ItemDescription] VARCHAR(MAX)	, [MG_P2_BillNo] VARCHAR(MAX)	, [MG_P2_BillDocument] INT	, [MG_P2_Amount] DECIMAL(18,2)	, [MG_P2_BillDate] DATETIME){0}INSERT INTO [1D198218-D4AF-4E09-9A9D-119D03D0C3BA](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_P2_ReimbursementDetailsId,MG_P2_ReimbursementId,MG_P2_ItemDescription,MG_P2_BillNo,MG_P2_BillDocument,MG_P2_Amount,MG_P2_BillDate)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_P2_ReimbursementDetailsId,TDT.MG_P2_ReimbursementId,TDT.MG_P2_ItemDescription,TDT.MG_P2_BillNo,TDT.MG_P2_BillDocument,TDT.MG_P2_Amount,TDT.MG_P2_BillDate FROM @TBL_1D198218D4AF4E099A9D119D03D0C3BA TDT
							LEFT JOIN [1D198218-D4AF-4E09-9A9D-119D03D0C3BA] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_P2_ReimbursementDetailsId,MG_P2_ReimbursementId,MG_P2_ItemDescription,MG_P2_BillNo,MG_P2_BillDocument,MG_P2_Amount,MG_P2_BillDate";

                                     tempInsertQuery=@"INSERT INTO @TBL_1D198218D4AF4E099A9D119D03D0C3BA(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_P2_ReimbursementDetailsId,MG_P2_ReimbursementId,MG_P2_ItemDescription,MG_P2_BillNo,MG_P2_BillDocument,MG_P2_Amount,MG_P2_BillDate)VALUES({0});";
                                     

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
                     
                                    case "84AEB9E0-3009-4426-AB92-AAF06D2B42AF":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_84AEB9E030094426AB92AAF06D2B42AF AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_P3_PackageProcessMapId] VARCHAR(MAX)	, [MG_P3_FundDetailsId] VARCHAR(MAX)	, [MG_P3_ReimbursementId] VARCHAR(MAX)	, [MG_P3_EmployeeBaicInfoId] VARCHAR(MAX)	, [MG_P3_Amount] DECIMAL(18,2)	, [MG_P3_FundTypeId] VARCHAR(250)	, [MG_P3_BudgetHeadId] VARCHAR(250)	, [MG_P3_ProjectDetailsId] VARCHAR(250)){0}INSERT INTO [84AEB9E0-3009-4426-AB92-AAF06D2B42AF](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_P3_PackageProcessMapId,MG_P3_FundDetailsId,MG_P3_ReimbursementId,MG_P3_EmployeeBaicInfoId,MG_P3_Amount,MG_P3_FundTypeId,MG_P3_BudgetHeadId,MG_P3_ProjectDetailsId)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_P3_PackageProcessMapId,TDT.MG_P3_FundDetailsId,TDT.MG_P3_ReimbursementId,TDT.MG_P3_EmployeeBaicInfoId,TDT.MG_P3_Amount,TDT.MG_P3_FundTypeId,TDT.MG_P3_BudgetHeadId,TDT.MG_P3_ProjectDetailsId FROM @TBL_84AEB9E030094426AB92AAF06D2B42AF TDT
							LEFT JOIN [84AEB9E0-3009-4426-AB92-AAF06D2B42AF] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_P3_PackageProcessMapId,MG_P3_FundDetailsId,MG_P3_ReimbursementId,MG_P3_EmployeeBaicInfoId,MG_P3_Amount,MG_P3_FundTypeId,MG_P3_BudgetHeadId,MG_P3_ProjectDetailsId";

                                     tempInsertQuery=@"INSERT INTO @TBL_84AEB9E030094426AB92AAF06D2B42AF(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_P3_PackageProcessMapId,MG_P3_FundDetailsId,MG_P3_ReimbursementId,MG_P3_EmployeeBaicInfoId,MG_P3_Amount,MG_P3_FundTypeId,MG_P3_BudgetHeadId,MG_P3_ProjectDetailsId)VALUES({0});";
                                     

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
                     

                                         case "93570AD2-BC61-4B0C-AE1C-2A20265D17E7":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_93570AD2BC614B0CAE1C2A20265D17E7 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [M_DocumentDetailsId] VARCHAR(MAX)	, [M_DocumentName] VARCHAR(MAX)	, [M_UploadDcoument] VARBINARY(MAX)){0}INSERT INTO [93570AD2-BC61-4B0C-AE1C-2A20265D17E7](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,M_DocumentDetailsId,M_DocumentName,M_UploadDcoument)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.M_DocumentDetailsId,TDT.M_DocumentName,TDT.M_UploadDcoument FROM @TBL_93570AD2BC614B0CAE1C2A20265D17E7 TDT
							LEFT JOIN [93570AD2-BC61-4B0C-AE1C-2A20265D17E7] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,M_DocumentDetailsId,M_DocumentName,M_UploadDcoument";

                            tempInsertQuery=@"INSERT INTO @TBL_93570AD2BC614B0CAE1C2A20265D17E7(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,M_DocumentDetailsId,M_DocumentName,M_UploadDcoument)VALUES({0});";

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

                                              case "B3C42BFD-4F71-4A59-BC58-E5B5C95B481C":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_B3C42BFD4F714A59BC58E5B5C95B481C AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_Balance] DECIMAL(18,2)	, [MG_Commitment] DECIMAL(18,2)	, [MG_YetToReceive] DECIMAL(18,2)	, [MG_ReceivedAmount] DECIMAL(18,2)	, [MG_SanctionedAmount] DECIMAL(18,2)	, [MG_Spent] DECIMAL(18,2)	, [MG_BudgetName] VARCHAR(MAX)){0}INSERT INTO [B3C42BFD-4F71-4A59-BC58-E5B5C95B481C](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_Balance,MG_Commitment,MG_YetToReceive,MG_ReceivedAmount,MG_SanctionedAmount,MG_Spent,MG_BudgetName)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_Balance,TDT.MG_Commitment,TDT.MG_YetToReceive,TDT.MG_ReceivedAmount,TDT.MG_SanctionedAmount,TDT.MG_Spent,TDT.MG_BudgetName FROM @TBL_B3C42BFD4F714A59BC58E5B5C95B481C TDT
							LEFT JOIN [B3C42BFD-4F71-4A59-BC58-E5B5C95B481C] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_Balance,MG_Commitment,MG_YetToReceive,MG_ReceivedAmount,MG_SanctionedAmount,MG_Spent,MG_BudgetName";

                            tempInsertQuery=@"INSERT INTO @TBL_B3C42BFD4F714A59BC58E5B5C95B481C(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_Balance,MG_Commitment,MG_YetToReceive,MG_ReceivedAmount,MG_SanctionedAmount,MG_Spent,MG_BudgetName)VALUES({0});";

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

                                              case "B49EFF11-DEBD-4F34-BEC5-7C607851D347":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_B49EFF11DEBD4F34BEC57C607851D347 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [RemarksId] VARCHAR(MAX)	, [ActivityName] VARCHAR(MAX)	, [Remarks] VARCHAR(MAX)	, [UserName] VARCHAR(MAX)	, [DateOfRemarks] DATETIME){0}INSERT INTO [B49EFF11-DEBD-4F34-BEC5-7C607851D347](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,RemarksId,ActivityName,Remarks,UserName,DateOfRemarks)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.RemarksId,TDT.ActivityName,TDT.Remarks,TDT.UserName,TDT.DateOfRemarks FROM @TBL_B49EFF11DEBD4F34BEC57C607851D347 TDT
							LEFT JOIN [B49EFF11-DEBD-4F34-BEC5-7C607851D347] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,RemarksId,ActivityName,Remarks,UserName,DateOfRemarks";

                            tempInsertQuery=@"INSERT INTO @TBL_B49EFF11DEBD4F34BEC57C607851D347(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,RemarksId,ActivityName,Remarks,UserName,DateOfRemarks)VALUES({0});";

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

                                              case "1D198218-D4AF-4E09-9A9D-119D03D0C3BA":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_1D198218D4AF4E099A9D119D03D0C3BA AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_P2_ReimbursementDetailsId] VARCHAR(MAX)	, [MG_P2_ReimbursementId] VARCHAR(MAX)	, [MG_P2_ItemDescription] VARCHAR(MAX)	, [MG_P2_BillNo] VARCHAR(MAX)	, [MG_P2_BillDocument] INT	, [MG_P2_Amount] DECIMAL(18,2)	, [MG_P2_BillDate] DATETIME){0}INSERT INTO [1D198218-D4AF-4E09-9A9D-119D03D0C3BA](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_P2_ReimbursementDetailsId,MG_P2_ReimbursementId,MG_P2_ItemDescription,MG_P2_BillNo,MG_P2_BillDocument,MG_P2_Amount,MG_P2_BillDate)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_P2_ReimbursementDetailsId,TDT.MG_P2_ReimbursementId,TDT.MG_P2_ItemDescription,TDT.MG_P2_BillNo,TDT.MG_P2_BillDocument,TDT.MG_P2_Amount,TDT.MG_P2_BillDate FROM @TBL_1D198218D4AF4E099A9D119D03D0C3BA TDT
							LEFT JOIN [1D198218-D4AF-4E09-9A9D-119D03D0C3BA] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_P2_ReimbursementDetailsId,MG_P2_ReimbursementId,MG_P2_ItemDescription,MG_P2_BillNo,MG_P2_BillDocument,MG_P2_Amount,MG_P2_BillDate";

                            tempInsertQuery=@"INSERT INTO @TBL_1D198218D4AF4E099A9D119D03D0C3BA(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_P2_ReimbursementDetailsId,MG_P2_ReimbursementId,MG_P2_ItemDescription,MG_P2_BillNo,MG_P2_BillDocument,MG_P2_Amount,MG_P2_BillDate)VALUES({0});";

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

                                              case "84AEB9E0-3009-4426-AB92-AAF06D2B42AF":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_84AEB9E030094426AB92AAF06D2B42AF AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_P3_PackageProcessMapId] VARCHAR(MAX)	, [MG_P3_FundDetailsId] VARCHAR(MAX)	, [MG_P3_ReimbursementId] VARCHAR(MAX)	, [MG_P3_EmployeeBaicInfoId] VARCHAR(MAX)	, [MG_P3_Amount] DECIMAL(18,2)	, [MG_P3_FundTypeId] VARCHAR(250)	, [MG_P3_BudgetHeadId] VARCHAR(250)	, [MG_P3_ProjectDetailsId] VARCHAR(250)){0}INSERT INTO [84AEB9E0-3009-4426-AB92-AAF06D2B42AF](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_P3_PackageProcessMapId,MG_P3_FundDetailsId,MG_P3_ReimbursementId,MG_P3_EmployeeBaicInfoId,MG_P3_Amount,MG_P3_FundTypeId,MG_P3_BudgetHeadId,MG_P3_ProjectDetailsId)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_P3_PackageProcessMapId,TDT.MG_P3_FundDetailsId,TDT.MG_P3_ReimbursementId,TDT.MG_P3_EmployeeBaicInfoId,TDT.MG_P3_Amount,TDT.MG_P3_FundTypeId,TDT.MG_P3_BudgetHeadId,TDT.MG_P3_ProjectDetailsId FROM @TBL_84AEB9E030094426AB92AAF06D2B42AF TDT
							LEFT JOIN [84AEB9E0-3009-4426-AB92-AAF06D2B42AF] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_P3_PackageProcessMapId,MG_P3_FundDetailsId,MG_P3_ReimbursementId,MG_P3_EmployeeBaicInfoId,MG_P3_Amount,MG_P3_FundTypeId,MG_P3_BudgetHeadId,MG_P3_ProjectDetailsId";

                            tempInsertQuery=@"INSERT INTO @TBL_84AEB9E030094426AB92AAF06D2B42AF(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_P3_PackageProcessMapId,MG_P3_FundDetailsId,MG_P3_ReimbursementId,MG_P3_EmployeeBaicInfoId,MG_P3_Amount,MG_P3_FundTypeId,MG_P3_BudgetHeadId,MG_P3_ProjectDetailsId)VALUES({0});";

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
public class ISpace788CA62EDF0F4071B3E34239827AFC52 : VirtualForm
{
IISpace iSpace = new ISpace();
AcDataISpace788CA62EDF0F4071B3E34239827AFC52 acdataIspace788CA62EDF0F4071B3E34239827AFC52=new AcDataISpace788CA62EDF0F4071B3E34239827AFC52();
private void SubscribeFormEvents_root(ref Dictionary<string, ServiceElementData> ISpace)
{
try
{
base.WriteDebugInfo(@"Root-OnAfterFormLoad");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["MFG_P2_ItemDescription"].Visible="true";ISpace["MFG_P2_BillDocument"].Visible="false";ISpace["MFG_P2_ReimbursementId"].Visible="false";ISpace["MFG_P2_BillNo"].Visible="true";ISpace["MFG_P3_ReimbursementId"].Visible="false";ISpace["MF_P1_TotalAmount"].Visible="true";ISpace["MF_P1_ApplicationStatus"].Visible="false";ISpace["MF_P1_Initiatedon"].Visible="false";ISpace["MFG_P2_Amount"].Visible="true";ISpace["MF_P1_ReimbursementId"].Visible="false";ISpace["MFG_P2_ReimbursementDetailsId"].Visible="false";ISpace["MFG_P3_BudgetHeadId"].Visible="true";ISpace["MF_P1_InitatedBy"].Visible="false";ISpace["MFG_P3_ProjectDetailsId"].Visible="true";ISpace["MFG_P3_FundTypeId"].Visible="true";ISpace["MFG_P3_FundDetailsId"].Visible="false";ISpace["MFG_P3_Amount"].Visible="true";ISpace["MF_P1_UpdatedBy"].Visible="false";ISpace["MF_P1_UpdatedOn"].Visible="false";ISpace["MFG_P2_BillDate"].Visible="true";ISpace["MF_P1_EmployeeBasicInfoId"].Visible="false";
base.WriteDebugInfo(@"ISpace[""MFG_P2_ItemDescription""].Visible=""true"";ISpace[""MFG_P2_BillDocument""].Visible=""false"";ISpace[""MFG_P2_ReimbursementId""].Visible=""false"";ISpace[""MFG_P2_BillNo""].Visible=""true"";ISpace[""MFG_P3_ReimbursementId""].Visible=""false"";ISpace[""MF_P1_TotalAmount""].Visible=""true"";ISpace[""MF_P1_ApplicationStatus""].Visible=""false"";ISpace[""MF_P1_Initiatedon""].Visible=""false"";ISpace[""MFG_P2_Amount""].Visible=""true"";ISpace[""MF_P1_ReimbursementId""].Visible=""false"";ISpace[""MFG_P2_ReimbursementDetailsId""].Visible=""false"";ISpace[""MFG_P3_BudgetHeadId""].Visible=""true"";ISpace[""MF_P1_InitatedBy""].Visible=""false"";ISpace[""MFG_P3_ProjectDetailsId""].Visible=""true"";ISpace[""MFG_P3_FundTypeId""].Visible=""true"";ISpace[""MFG_P3_FundDetailsId""].Visible=""false"";ISpace[""MFG_P3_Amount""].Visible=""true"";ISpace[""MF_P1_UpdatedBy""].Visible=""false"";ISpace[""MF_P1_UpdatedOn""].Visible=""false"";ISpace[""MFG_P2_BillDate""].Visible=""true"";ISpace[""MF_P1_EmployeeBasicInfoId""].Visible=""false"";");
ISpace["MG_P2_ReimbursementId"].Visible="false";ISpace["MG_P2_BillDocument"].Visible="false";ISpace["MG_P2_BillDate"].Visible="true";ISpace["MG_P2_BillNo"].Visible="true";ISpace["MG_P2_ItemDescription"].Visible="true";ISpace["MG_P2_Amount"].Visible="true";ISpace["MG_P2_ReimbursementDetailsId"].Visible="false";
base.WriteDebugInfo(@"ISpace[""MG_P2_ReimbursementId""].Visible=""false"";ISpace[""MG_P2_BillDocument""].Visible=""false"";ISpace[""MG_P2_BillDate""].Visible=""true"";ISpace[""MG_P2_BillNo""].Visible=""true"";ISpace[""MG_P2_ItemDescription""].Visible=""true"";ISpace[""MG_P2_Amount""].Visible=""true"";ISpace[""MG_P2_ReimbursementDetailsId""].Visible=""false"";");
ISpace["MG_P3_Amount"].Visible="true";ISpace["MG_P3_BudgetHeadId"].Visible="true";ISpace["MG_P3_ProjectDetailsId"].Visible="true";ISpace["MG_P3_ReimbursementId"].Visible="false";ISpace["MG_P3_FundDetailsId"].Visible="false";ISpace["MG_P3_FundTypeId"].Visible="true";
base.WriteDebugInfo(@"ISpace[""MG_P3_Amount""].Visible=""true"";ISpace[""MG_P3_BudgetHeadId""].Visible=""true"";ISpace[""MG_P3_ProjectDetailsId""].Visible=""true"";ISpace[""MG_P3_ReimbursementId""].Visible=""false"";ISpace[""MG_P3_FundDetailsId""].Visible=""false"";ISpace[""MG_P3_FundTypeId""].Visible=""true"";");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["MF_P1_ReimbursementId"].Value=ISpace["gv_instanceid"].Value;
base.WriteDebugInfo(@"ISpace[""MF_P1_ReimbursementId""].Value=ISpace[""gv_instanceid""].Value;");
ISpace["MF_P1_ApplicationStatus"].Value="S";
base.WriteDebugInfo(@"ISpace[""MF_P1_ApplicationStatus""].Value=""S"";");
ISpace["M_InitiatorUserMapId"].Value=ISpace["gv_usermapid"].Value;
base.WriteDebugInfo(@"ISpace[""M_InitiatorUserMapId""].Value=ISpace[""gv_usermapid""].Value;");
base.WriteDebugInfo(@"EXEC [GetEmployeeUserContextDetails] '@@gv_UserId'");

var querySource000156F011EC4492A0547C093B6DAE0A =GetQueryExpressionDataSource("000156F0-11EC-4492-A054-7C093B6DAE0A");
Dictionary<short,object> result000156F011EC4492A0547C093B6DAE0A=iSpace.ExecuteQuery(querySource000156F011EC4492A0547C093B6DAE0A,@"EXEC [GetEmployeeUserContextDetails] '" + ISpace["gv_userid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource000156F011EC4492A0547C093B6DAE0A =GetQueryExpressionDataSource(""000156F0-11EC-4492-A054-7C093B6DAE0A"");Dictionary<short,object> result000156F011EC4492A0547C093B6DAE0A=iSpace.ExecuteQuery(querySource000156F011EC4492A0547C093B6DAE0A,@""EXEC [GetEmployeeUserContextDetails] '"" + ISpace[""gv_userid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result000156F011EC4492A0547C093B6DAE0A!=null) && (result000156F011EC4492A0547C093B6DAE0A.Count!=0))
{
if(result000156F011EC4492A0547C093B6DAE0A.ContainsKey(3))
ISpace["UC_EmailId"].Value = result000156F011EC4492A0547C093B6DAE0A[3];
if(result000156F011EC4492A0547C093B6DAE0A.ContainsKey(0))
ISpace["UC_EmployeeBaicInfoId"].Value = result000156F011EC4492A0547C093B6DAE0A[0];
if(result000156F011EC4492A0547C093B6DAE0A.ContainsKey(10))
ISpace["UC_DOR"].Value = result000156F011EC4492A0547C093B6DAE0A[10];
if(result000156F011EC4492A0547C093B6DAE0A.ContainsKey(2))
ISpace["UC_Name"].Value = result000156F011EC4492A0547C093B6DAE0A[2];
if(result000156F011EC4492A0547C093B6DAE0A.ContainsKey(4))
ISpace["UC_DOJ"].Value = result000156F011EC4492A0547C093B6DAE0A[4];
if(result000156F011EC4492A0547C093B6DAE0A.ContainsKey(6))
ISpace["UC_Department"].Value = result000156F011EC4492A0547C093B6DAE0A[6];
if(result000156F011EC4492A0547C093B6DAE0A.ContainsKey(1))
ISpace["UC_EmployeeId"].Value = result000156F011EC4492A0547C093B6DAE0A[1];
if(result000156F011EC4492A0547C093B6DAE0A.ContainsKey(11))
ISpace["UC_Grade"].Value = result000156F011EC4492A0547C093B6DAE0A[11];
if(result000156F011EC4492A0547C093B6DAE0A.ContainsKey(12))
ISpace["UC_Paylevel"].Value = result000156F011EC4492A0547C093B6DAE0A[12];
if(result000156F011EC4492A0547C093B6DAE0A.ContainsKey(9))
ISpace["UC_DOB"].Value = result000156F011EC4492A0547C093B6DAE0A[9];
if(result000156F011EC4492A0547C093B6DAE0A.ContainsKey(5))
ISpace["UC_PhoneNumber"].Value = result000156F011EC4492A0547C093B6DAE0A[5];
if(result000156F011EC4492A0547C093B6DAE0A.ContainsKey(7))
ISpace["UC_Designation"].Value = result000156F011EC4492A0547C093B6DAE0A[7];
}
else{
ISpace["UC_EmailId"].Value = null;ISpace["UC_EmployeeBaicInfoId"].Value = null;ISpace["UC_DOR"].Value = null;ISpace["UC_Name"].Value = null;ISpace["UC_DOJ"].Value = null;ISpace["UC_Department"].Value = null;ISpace["UC_EmployeeId"].Value = null;ISpace["UC_Grade"].Value = null;ISpace["UC_Paylevel"].Value = null;ISpace["UC_DOB"].Value = null;ISpace["UC_PhoneNumber"].Value = null;ISpace["UC_Designation"].Value = null;
}
}
ISpace["M_SourceActivityMapId"].Value=ISpace["gv_activitymapid"].Value;
base.WriteDebugInfo(@"ISpace[""M_SourceActivityMapId""].Value=ISpace[""gv_activitymapid""].Value;");
ISpace["M_PackageProcessMapId"].Value=ISpace["gv_processmapid"].Value;
base.WriteDebugInfo(@"ISpace[""M_PackageProcessMapId""].Value=ISpace[""gv_processmapid""].Value;");
ISpace["M_InstanceId"].Value=ISpace["gv_instanceid"].Value;
base.WriteDebugInfo(@"ISpace[""M_InstanceId""].Value=ISpace[""gv_instanceid""].Value;");
ISpace["M_IsSourceStep"].Value=0;
base.WriteDebugInfo(@"ISpace[""M_IsSourceStep""].Value=0;");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["FormVersionId"].Value=="9376EEBF-92B0-4B68-9085-73DD4ED3F42B")
{
ISpace["UI_BudgetColumn"].Visible="false";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""9376EEBF-92B0-4B68-9085-73DD4ED3F42B"")
{
ISpace[""UI_BudgetColumn""].Visible=""false"";
}");
ISpace["M_Classification"].Visible="false";ISpace["M_SubClassication"].Visible="false";
base.WriteDebugInfo(@"ISpace[""M_Classification""].Visible=""false"";ISpace[""M_SubClassication""].Visible=""false"";");
}
base.WriteDebugInfo(@"EXEC GetDestinationDetails '#M_SourceActivityMapId'");

var querySource501CB7C76A0743B9965B700958ACB8D8 =GetQueryExpressionDataSource("501CB7C7-6A07-43B9-965B-700958ACB8D8");
Dictionary<short,object> result501CB7C76A0743B9965B700958ACB8D8=iSpace.ExecuteQuery(querySource501CB7C76A0743B9965B700958ACB8D8,@"EXEC GetDestinationDetails '" + ISpace["M_SourceActivityMapId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource501CB7C76A0743B9965B700958ACB8D8 =GetQueryExpressionDataSource(""501CB7C7-6A07-43B9-965B-700958ACB8D8"");Dictionary<short,object> result501CB7C76A0743B9965B700958ACB8D8=iSpace.ExecuteQuery(querySource501CB7C76A0743B9965B700958ACB8D8,@""EXEC GetDestinationDetails '"" + ISpace[""M_SourceActivityMapId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result501CB7C76A0743B9965B700958ACB8D8!=null) && (result501CB7C76A0743B9965B700958ACB8D8.Count!=0))
{
if(result501CB7C76A0743B9965B700958ACB8D8.ContainsKey(0))
ISpace["M_DestinationActivityId"].Value = result501CB7C76A0743B9965B700958ACB8D8[0];
if(result501CB7C76A0743B9965B700958ACB8D8.ContainsKey(5))
ISpace["MF_P1_Remarks"].Value = result501CB7C76A0743B9965B700958ACB8D8[5];
if(result501CB7C76A0743B9965B700958ACB8D8.ContainsKey(1))
ISpace["M_Stage"].Value = result501CB7C76A0743B9965B700958ACB8D8[1];
if(result501CB7C76A0743B9965B700958ACB8D8.ContainsKey(2))
ISpace["M_NextStage"].Value = result501CB7C76A0743B9965B700958ACB8D8[2];
}
else{
ISpace["M_DestinationActivityId"].Value = null;ISpace["MF_P1_Remarks"].Value = null;ISpace["M_Stage"].Value = null;ISpace["M_NextStage"].Value = null;
}
ISpace["MFG_P3_BudgetHeadId"].Visible="false";ISpace["MFG_P3_ProjectDetailsId"].Visible="false";ISpace["MFG_P3_Amount"].Visible="false";
base.WriteDebugInfo(@"ISpace[""MFG_P3_BudgetHeadId""].Visible=""false"";ISpace[""MFG_P3_ProjectDetailsId""].Visible=""false"";ISpace[""MFG_P3_Amount""].Visible=""false"";");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["MFG_P2_ItemDescription"].Man=true;ISpace["MFG_P2_BillNo"].Man=true;ISpace["MF_P1_TotalAmount"].Man=true;ISpace["MFG_P2_Amount"].Man=true;ISpace["MFG_P3_FundTypeId"].Man=true;ISpace["MFG_P3_Amount"].Man=true;ISpace["MFG_P2_BillDate"].Man=true;
base.WriteDebugInfo(@"ISpace[""MFG_P2_ItemDescription""].Man=true;ISpace[""MFG_P2_BillNo""].Man=true;ISpace[""MF_P1_TotalAmount""].Man=true;ISpace[""MFG_P2_Amount""].Man=true;ISpace[""MFG_P3_FundTypeId""].Man=true;ISpace[""MFG_P3_Amount""].Man=true;ISpace[""MFG_P2_BillDate""].Man=true;");
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_delete_reimbursementbilldetails (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Delete_ReimbursementBillDetails-OnClick");
ISpace["growid"].Value=ISpace["ReimbursementBillDetails_RowId"].Value;
base.WriteDebugInfo(@"ISpace[""growid""].Value=ISpace[""ReimbursementBillDetails_RowId""].Value;");
ISpace["UI_DialogBox"].ShowDialog=true;;
base.WriteDebugInfo(@"ISpace[""UI_DialogBox""].ShowDialog=true;;");
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
ISpace["growid"].Value=ISpace["ReimbursementBillDetails_RowId"].Value;
base.WriteDebugInfo(@"ISpace[""growid""].Value=ISpace[""ReimbursementBillDetails_RowId""].Value;");
base.WriteDebugInfo(@"EXEC LoadFormGridDataC9ACCA847AF347E79133D777BE46A656 '@@gv_InstanceId','@@gv_ProcessMapId','C9ACCA84-7AF3-47E7-9133-D777BE46A656','@@gv_ActivityMapId','#growid'");

var querySource3BC8920E9488421CBBA16D92ECF94CB2 =GetQueryExpressionDataSource("3BC8920E-9488-421C-BBA1-6D92ECF94CB2");
Dictionary<short,object> result3BC8920E9488421CBBA16D92ECF94CB2=iSpace.ExecuteQuery(querySource3BC8920E9488421CBBA16D92ECF94CB2,@"EXEC LoadFormGridDataC9ACCA847AF347E79133D777BE46A656 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','C9ACCA84-7AF3-47E7-9133-D777BE46A656','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["growid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource3BC8920E9488421CBBA16D92ECF94CB2 =GetQueryExpressionDataSource(""3BC8920E-9488-421C-BBA1-6D92ECF94CB2"");Dictionary<short,object> result3BC8920E9488421CBBA16D92ECF94CB2=iSpace.ExecuteQuery(querySource3BC8920E9488421CBBA16D92ECF94CB2,@""EXEC LoadFormGridDataC9ACCA847AF347E79133D777BE46A656 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','C9ACCA84-7AF3-47E7-9133-D777BE46A656','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""growid""].Value + @""'"",false);");
base.WriteDebugInfo(@"EXEC LoadFormGridDataC9ACCA847AF347E79133D777BE46A656 '@@gv_InstanceId','@@gv_ProcessMapId','C9ACCA84-7AF3-47E7-9133-D777BE46A656','@@gv_ActivityMapId','#growid'");

if((result3BC8920E9488421CBBA16D92ECF94CB2!=null) && (result3BC8920E9488421CBBA16D92ECF94CB2.Count!=0))
{
if(result3BC8920E9488421CBBA16D92ECF94CB2.ContainsKey(3))
ISpace["MFG_P2_BillDate"].Value = result3BC8920E9488421CBBA16D92ECF94CB2[3];
if(result3BC8920E9488421CBBA16D92ECF94CB2.ContainsKey(4))
ISpace["MFG_P2_BillDocument"].Value = result3BC8920E9488421CBBA16D92ECF94CB2[4];
if(result3BC8920E9488421CBBA16D92ECF94CB2.ContainsKey(6))
ISpace["MFG_P2_Amount"].Value = result3BC8920E9488421CBBA16D92ECF94CB2[6];
if(result3BC8920E9488421CBBA16D92ECF94CB2.ContainsKey(0))
ISpace["MFG_P2_ReimbursementDetailsId"].Value = result3BC8920E9488421CBBA16D92ECF94CB2[0];
if(result3BC8920E9488421CBBA16D92ECF94CB2.ContainsKey(1))
ISpace["MFG_P2_ReimbursementId"].Value = result3BC8920E9488421CBBA16D92ECF94CB2[1];
if(result3BC8920E9488421CBBA16D92ECF94CB2.ContainsKey(2))
ISpace["MFG_P2_BillNo"].Value = result3BC8920E9488421CBBA16D92ECF94CB2[2];
if(result3BC8920E9488421CBBA16D92ECF94CB2.ContainsKey(5))
ISpace["MFG_P2_ItemDescription"].Value = result3BC8920E9488421CBBA16D92ECF94CB2[5];
}
else{
ISpace["MFG_P2_BillDate"].Value = null;ISpace["MFG_P2_BillDocument"].Value = null;ISpace["MFG_P2_Amount"].Value = null;ISpace["MFG_P2_ReimbursementDetailsId"].Value = null;ISpace["MFG_P2_ReimbursementId"].Value = null;ISpace["MFG_P2_BillNo"].Value = null;ISpace["MFG_P2_ItemDescription"].Value = null;
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_ui_availablebudgetmodal (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"UI_AvailablebudgetModal-OnClick");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["MF_ProjectNo"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_ProjectNo""].Value=null;");
}
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
ISpace["UI_DialogBox"].HideDialog=true;;
base.WriteDebugInfo(@"ISpace[""UI_DialogBox""].HideDialog=true;;");
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
if(ISpace["MFG_P2_BillDate"].Value>CurrentDate())
{
base.WriteDebugInfo(@"if(ISpace[""MFG_P2_BillDate""].Value>CurrentDate())");
ISpace["Message"].Value=@"Bill Date should be less than or equal to Current Date";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Bill Date should be less than or equal to Current Date"";");
ISpace["MFG_P2_BillDate"].Value=null;
base.WriteDebugInfo(@"ISpace[""MFG_P2_BillDate""].Value=null;");
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

var querySource8D078B34227340D4A2DD23A371ABE1A6 =GetQueryExpressionDataSource("8D078B34-2273-40D4-A2DD-23A371ABE1A6");

DataTable result8D078B34227340D4A2DD23A371ABE1A6=iSpace.SetGridDataSource(querySource8D078B34227340D4A2DD23A371ABE1A6, _objectFactory.GetGridRPP("ReimbursementBillDetails"),@"EXEC AddFormGridDataC9ACCA847AF347E79133D777BE46A656 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','C9ACCA84-7AF3-47E7-9133-D777BE46A656','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["MFG_P2_ReimbursementDetailsId"].Value + @"','" + ISpace["MFG_P2_ReimbursementId"].Value + @"','" + ISpace["MFG_P2_BillNo"].Value + @"','" + ISpace["MFG_P2_BillDate"].Value + @"'," + ISpace["MFG_P2_BillDocument"].Value + @",'" + ISpace["MFG_P2_ItemDescription"].Value + @"'," + ISpace["MFG_P2_Amount"].Value + @",'" + ISpace["growid"].Value + @"'");

iSpace.InsertGridBindDetails("ReimbursementBillDetails","11",querySource8D078B34227340D4A2DD23A371ABE1A6,"EXEC AddFormGridDataC9ACCA847AF347E79133D777BE46A656 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','C9ACCA84-7AF3-47E7-9133-D777BE46A656','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["MFG_P2_ReimbursementDetailsId"].Value + @"','" + ISpace["MFG_P2_ReimbursementId"].Value + @"','" + ISpace["MFG_P2_BillNo"].Value + @"','" + ISpace["MFG_P2_BillDate"].Value + @"'," + ISpace["MFG_P2_BillDocument"].Value + @",'" + ISpace["MFG_P2_ItemDescription"].Value + @"'," + ISpace["MFG_P2_Amount"].Value + @",'" + ISpace["growid"].Value + @"'",_objectFactory.GetGridRPP("ReimbursementBillDetails"));

base.WriteDebugInfo(@"var querySource8D078B34227340D4A2DD23A371ABE1A6 =GetQueryExpressionDataSource(""8D078B34-2273-40D4-A2DD-23A371ABE1A6"");DataTable result8D078B34227340D4A2DD23A371ABE1A6=iSpace.SetGridDataSource(querySource8D078B34227340D4A2DD23A371ABE1A6, _objectFactory.GetGridRPP(""ReimbursementBillDetails""),@""EXEC AddFormGridDataC9ACCA847AF347E79133D777BE46A656 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','C9ACCA84-7AF3-47E7-9133-D777BE46A656','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""MFG_P2_ReimbursementDetailsId""].Value + @""','"" + ISpace[""MFG_P2_ReimbursementId""].Value + @""','"" + ISpace[""MFG_P2_BillNo""].Value + @""','"" + ISpace[""MFG_P2_BillDate""].Value + @""',"" + ISpace[""MFG_P2_BillDocument""].Value + @"",'"" + ISpace[""MFG_P2_ItemDescription""].Value + @""',"" + ISpace[""MFG_P2_Amount""].Value + @"",'"" + ISpace[""growid""].Value + @""'"");iSpace.InsertGridBindDetails(""ReimbursementBillDetails"",""11"",querySource8D078B34227340D4A2DD23A371ABE1A6,""EXEC AddFormGridDataC9ACCA847AF347E79133D777BE46A656 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','C9ACCA84-7AF3-47E7-9133-D777BE46A656','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""MFG_P2_ReimbursementDetailsId""].Value + @""','"" + ISpace[""MFG_P2_ReimbursementId""].Value + @""','"" + ISpace[""MFG_P2_BillNo""].Value + @""','"" + ISpace[""MFG_P2_BillDate""].Value + @""',"" + ISpace[""MFG_P2_BillDocument""].Value + @"",'"" + ISpace[""MFG_P2_ItemDescription""].Value + @""',"" + ISpace[""MFG_P2_Amount""].Value + @"",'"" + ISpace[""growid""].Value + @""'"",_objectFactory.GetGridRPP(""ReimbursementBillDetails""));");
base.WriteDebugInfo(@"EXEC AddFormGridDataC9ACCA847AF347E79133D777BE46A656 '@@gv_InstanceId','@@gv_ProcessMapId','C9ACCA84-7AF3-47E7-9133-D777BE46A656','@@gv_ActivityMapId','#MFG_P2_ReimbursementDetailsId','#MFG_P2_ReimbursementId','#MFG_P2_BillNo','#MFG_P2_BillDate',#MFG_P2_BillDocument,'#MFG_P2_ItemDescription',#MFG_P2_Amount,'#growid'");


List<Triplet<string, short, short?>> resultC48E5BD17B2A4917979A69F487396125=acdataIspace788CA62EDF0F4071B3E34239827AFC52.GetQueryExpressionBindings("C48E5BD1-7B2A-4917-979A-69F487396125");
iSpace.SetGridData(result8D078B34227340D4A2DD23A371ABE1A6,resultC48E5BD17B2A4917979A69F487396125,"ReimbursementBillDetails",ref ISpace);
iSpace.UpdateGridBindDetails("ReimbursementBillDetails",resultC48E5BD17B2A4917979A69F487396125);
}
else
{
base.WriteDebugInfo(@"else");

var querySource9B5B780E4C6E4FCEA2BDA3A4764A9120 =GetQueryExpressionDataSource("9B5B780E-4C6E-4FCE-A2BD-A3A4764A9120");

DataTable result9B5B780E4C6E4FCEA2BDA3A4764A9120=iSpace.SetGridDataSource(querySource9B5B780E4C6E4FCEA2BDA3A4764A9120, _objectFactory.GetGridRPP("ReimbursementBillDetails"),@"EXEC UpdateFormGridDataC9ACCA847AF347E79133D777BE46A656 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','C9ACCA84-7AF3-47E7-9133-D777BE46A656','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["MFG_P2_ReimbursementDetailsId"].Value + @"','" + ISpace["MFG_P2_ReimbursementId"].Value + @"','" + ISpace["MFG_P2_BillNo"].Value + @"','" + ISpace["MFG_P2_BillDate"].Value + @"'," + ISpace["MFG_P2_BillDocument"].Value + @",'" + ISpace["MFG_P2_ItemDescription"].Value + @"'," + ISpace["MFG_P2_Amount"].Value + @",'" + ISpace["growid"].Value + @"'");

iSpace.InsertGridBindDetails("ReimbursementBillDetails","11",querySource9B5B780E4C6E4FCEA2BDA3A4764A9120,"EXEC UpdateFormGridDataC9ACCA847AF347E79133D777BE46A656 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','C9ACCA84-7AF3-47E7-9133-D777BE46A656','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["MFG_P2_ReimbursementDetailsId"].Value + @"','" + ISpace["MFG_P2_ReimbursementId"].Value + @"','" + ISpace["MFG_P2_BillNo"].Value + @"','" + ISpace["MFG_P2_BillDate"].Value + @"'," + ISpace["MFG_P2_BillDocument"].Value + @",'" + ISpace["MFG_P2_ItemDescription"].Value + @"'," + ISpace["MFG_P2_Amount"].Value + @",'" + ISpace["growid"].Value + @"'",_objectFactory.GetGridRPP("ReimbursementBillDetails"));

base.WriteDebugInfo(@"var querySource9B5B780E4C6E4FCEA2BDA3A4764A9120 =GetQueryExpressionDataSource(""9B5B780E-4C6E-4FCE-A2BD-A3A4764A9120"");DataTable result9B5B780E4C6E4FCEA2BDA3A4764A9120=iSpace.SetGridDataSource(querySource9B5B780E4C6E4FCEA2BDA3A4764A9120, _objectFactory.GetGridRPP(""ReimbursementBillDetails""),@""EXEC UpdateFormGridDataC9ACCA847AF347E79133D777BE46A656 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','C9ACCA84-7AF3-47E7-9133-D777BE46A656','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""MFG_P2_ReimbursementDetailsId""].Value + @""','"" + ISpace[""MFG_P2_ReimbursementId""].Value + @""','"" + ISpace[""MFG_P2_BillNo""].Value + @""','"" + ISpace[""MFG_P2_BillDate""].Value + @""',"" + ISpace[""MFG_P2_BillDocument""].Value + @"",'"" + ISpace[""MFG_P2_ItemDescription""].Value + @""',"" + ISpace[""MFG_P2_Amount""].Value + @"",'"" + ISpace[""growid""].Value + @""'"");iSpace.InsertGridBindDetails(""ReimbursementBillDetails"",""11"",querySource9B5B780E4C6E4FCEA2BDA3A4764A9120,""EXEC UpdateFormGridDataC9ACCA847AF347E79133D777BE46A656 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','C9ACCA84-7AF3-47E7-9133-D777BE46A656','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""MFG_P2_ReimbursementDetailsId""].Value + @""','"" + ISpace[""MFG_P2_ReimbursementId""].Value + @""','"" + ISpace[""MFG_P2_BillNo""].Value + @""','"" + ISpace[""MFG_P2_BillDate""].Value + @""',"" + ISpace[""MFG_P2_BillDocument""].Value + @"",'"" + ISpace[""MFG_P2_ItemDescription""].Value + @""',"" + ISpace[""MFG_P2_Amount""].Value + @"",'"" + ISpace[""growid""].Value + @""'"",_objectFactory.GetGridRPP(""ReimbursementBillDetails""));");
base.WriteDebugInfo(@"EXEC UpdateFormGridDataC9ACCA847AF347E79133D777BE46A656 '@@gv_InstanceId','@@gv_ProcessMapId','C9ACCA84-7AF3-47E7-9133-D777BE46A656','@@gv_ActivityMapId','#MFG_P2_ReimbursementDetailsId','#MFG_P2_ReimbursementId','#MFG_P2_BillNo','#MFG_P2_BillDate',#MFG_P2_BillDocument,'#MFG_P2_ItemDescription',#MFG_P2_Amount,'#growid'");


List<Triplet<string, short, short?>> result9EA07CACF2274E83A5EE8C316E74D75C=acdataIspace788CA62EDF0F4071B3E34239827AFC52.GetQueryExpressionBindings("9EA07CAC-F227-4E83-A5EE-8C316E74D75C");
iSpace.SetGridData(result9B5B780E4C6E4FCEA2BDA3A4764A9120,result9EA07CACF2274E83A5EE8C316E74D75C,"ReimbursementBillDetails",ref ISpace);
iSpace.UpdateGridBindDetails("ReimbursementBillDetails",result9EA07CACF2274E83A5EE8C316E74D75C);
}
object MG_P2_Amount=iSpace.Sum("[1D198218-D4AF-4E09-9A9D-119D03D0C3BA]","MG_P2_Amount","",ISpace["gv_instanceid"].Value);
ISpace["MF_P1_TotalAmount"].Value=Convert.ChangeType(MG_P2_Amount, MG_P2_Amount.GetType());;
base.WriteDebugInfo(@"object MG_P2_Amount=iSpace.Sum(""[1D198218-D4AF-4E09-9A9D-119D03D0C3BA]"",""MG_P2_Amount"","""",ISpace[""gv_instanceid""].Value);
ISpace[""MF_P1_TotalAmount""].Value=Convert.ChangeType(MG_P2_Amount, MG_P2_Amount.GetType());;");
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
private void SubscribeElementEvents_m_classification (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"M_Classification-OnChange");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["M_SubClassication"].rElemData=iSpace.Reload(ISpace["M_SubClassication"].Value,@"exec LoadItemSubCombo '" + ISpace["M_Classification"].Value + @"'","3A103712-5244-4427-B2B6-1C4E046FD337");
base.WriteDebugInfo(@"ISpace[""M_SubClassication""].rElemData=iSpace.Reload(ISpace[""M_SubClassication""].Value,@""exec LoadItemSubCombo '"" + ISpace[""M_Classification""].Value + @""'"",""3A103712-5244-4427-B2B6-1C4E046FD337"");");
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_delete_reimbursementfunddetails (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Delete_ReimbursementFundDetails-OnClick");
ISpace["growid"].Value=ISpace["ReimbursementFundDetails_RowId"].Value;
base.WriteDebugInfo(@"ISpace[""growid""].Value=ISpace[""ReimbursementFundDetails_RowId""].Value;");
ISpace["UI_DialogBox1"].ShowDialog=true;;
base.WriteDebugInfo(@"ISpace[""UI_DialogBox1""].ShowDialog=true;;");
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
base.WriteDebugInfo(@"EXEC [ValidatePaymentFundAvailability] '#MFG_P3_FundTypeId','#MFG_P3_ProjectDetailsId','#MFG_P3_BudgetHeadId','#UC_EmployeeBaicInfoId','#MFG_P3_Amount'");

var querySource65F843A227D04177B79DCF4225F30450 =GetQueryExpressionDataSource("65F843A2-27D0-4177-B79D-CF4225F30450");
Dictionary<short,object> result65F843A227D04177B79DCF4225F30450=iSpace.ExecuteQuery(querySource65F843A227D04177B79DCF4225F30450,@"EXEC [ValidatePaymentFundAvailability] '" + ISpace["MFG_P3_FundTypeId"].Value + @"','" + ISpace["MFG_P3_ProjectDetailsId"].Value + @"','" + ISpace["MFG_P3_BudgetHeadId"].Value + @"','" + ISpace["UC_EmployeeBaicInfoId"].Value + @"','" + ISpace["MFG_P3_Amount"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource65F843A227D04177B79DCF4225F30450 =GetQueryExpressionDataSource(""65F843A2-27D0-4177-B79D-CF4225F30450"");Dictionary<short,object> result65F843A227D04177B79DCF4225F30450=iSpace.ExecuteQuery(querySource65F843A227D04177B79DCF4225F30450,@""EXEC [ValidatePaymentFundAvailability] '"" + ISpace[""MFG_P3_FundTypeId""].Value + @""','"" + ISpace[""MFG_P3_ProjectDetailsId""].Value + @""','"" + ISpace[""MFG_P3_BudgetHeadId""].Value + @""','"" + ISpace[""UC_EmployeeBaicInfoId""].Value + @""','"" + ISpace[""MFG_P3_Amount""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result65F843A227D04177B79DCF4225F30450!=null) && (result65F843A227D04177B79DCF4225F30450.Count!=0))
{
if(result65F843A227D04177B79DCF4225F30450.ContainsKey(0))
ISpace["M_ErrId"].Value = result65F843A227D04177B79DCF4225F30450[0];
if(result65F843A227D04177B79DCF4225F30450.ContainsKey(1))
ISpace["M_ErrMsg"].Value = result65F843A227D04177B79DCF4225F30450[1];
}
else{
ISpace["M_ErrId"].Value = null;ISpace["M_ErrMsg"].Value = null;
}
if(ISpace["M_ErrId"].Value==0&&ISpace["MFG_P3_FundTypeId"].Value=="1")
{
base.WriteDebugInfo(@"if(ISpace[""M_ErrId""].Value==0&&ISpace[""MFG_P3_FundTypeId""].Value==""1"")");
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
if (_elementBase != null)  iSpace.SetLoopExpressionData("ReimbursementFundDetails","84AEB9E0-3009-4426-AB92-AAF06D2B42AF",_objectFactory.GetGridRPP("ReimbursementFundDetails"),_elementBase.GetGridLoopQuery("84AEB9E0-3009-4426-AB92-AAF06D2B42AF","ReimbursementFundDetails",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""ReimbursementFundDetails"",ref ISpace);

foreach(var gridChild in ISpace[""ReimbursementFundDetails""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
}
if(ISpace["growid"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""growid""].Value=="""")");

var querySourceCBB3928101F44B3AB89247A0222DAFBA =GetQueryExpressionDataSource("CBB39281-01F4-4B3A-B892-47A0222DAFBA");

DataTable resultCBB3928101F44B3AB89247A0222DAFBA=iSpace.SetGridDataSource(querySourceCBB3928101F44B3AB89247A0222DAFBA, _objectFactory.GetGridRPP("ReimbursementFundDetails"),@"EXEC AddFormGridDataD85301F7BAF94BE8A2B174E5CBB3D054 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','D85301F7-BAF9-4BE8-A2B1-74E5CBB3D054','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["MFG_P3_FundDetailsId"].Value + @"','" + ISpace["MFG_P3_ReimbursementId"].Value + @"','" + ISpace["MFG_P3_FundTypeId"].Value + @"','" + ISpace["MFG_P3_ProjectDetailsId"].Value + @"','" + ISpace["MFG_P3_BudgetHeadId"].Value + @"','" + ISpace["MFG_P3_Amount"].Value + @"','" + ISpace["growid"].Value + @"'");

iSpace.InsertGridBindDetails("ReimbursementFundDetails","11",querySourceCBB3928101F44B3AB89247A0222DAFBA,"EXEC AddFormGridDataD85301F7BAF94BE8A2B174E5CBB3D054 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','D85301F7-BAF9-4BE8-A2B1-74E5CBB3D054','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["MFG_P3_FundDetailsId"].Value + @"','" + ISpace["MFG_P3_ReimbursementId"].Value + @"','" + ISpace["MFG_P3_FundTypeId"].Value + @"','" + ISpace["MFG_P3_ProjectDetailsId"].Value + @"','" + ISpace["MFG_P3_BudgetHeadId"].Value + @"','" + ISpace["MFG_P3_Amount"].Value + @"','" + ISpace["growid"].Value + @"'",_objectFactory.GetGridRPP("ReimbursementFundDetails"));

base.WriteDebugInfo(@"var querySourceCBB3928101F44B3AB89247A0222DAFBA =GetQueryExpressionDataSource(""CBB39281-01F4-4B3A-B892-47A0222DAFBA"");DataTable resultCBB3928101F44B3AB89247A0222DAFBA=iSpace.SetGridDataSource(querySourceCBB3928101F44B3AB89247A0222DAFBA, _objectFactory.GetGridRPP(""ReimbursementFundDetails""),@""EXEC AddFormGridDataD85301F7BAF94BE8A2B174E5CBB3D054 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','D85301F7-BAF9-4BE8-A2B1-74E5CBB3D054','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""MFG_P3_FundDetailsId""].Value + @""','"" + ISpace[""MFG_P3_ReimbursementId""].Value + @""','"" + ISpace[""MFG_P3_FundTypeId""].Value + @""','"" + ISpace[""MFG_P3_ProjectDetailsId""].Value + @""','"" + ISpace[""MFG_P3_BudgetHeadId""].Value + @""','"" + ISpace[""MFG_P3_Amount""].Value + @""','"" + ISpace[""growid""].Value + @""'"");iSpace.InsertGridBindDetails(""ReimbursementFundDetails"",""11"",querySourceCBB3928101F44B3AB89247A0222DAFBA,""EXEC AddFormGridDataD85301F7BAF94BE8A2B174E5CBB3D054 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','D85301F7-BAF9-4BE8-A2B1-74E5CBB3D054','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""MFG_P3_FundDetailsId""].Value + @""','"" + ISpace[""MFG_P3_ReimbursementId""].Value + @""','"" + ISpace[""MFG_P3_FundTypeId""].Value + @""','"" + ISpace[""MFG_P3_ProjectDetailsId""].Value + @""','"" + ISpace[""MFG_P3_BudgetHeadId""].Value + @""','"" + ISpace[""MFG_P3_Amount""].Value + @""','"" + ISpace[""growid""].Value + @""'"",_objectFactory.GetGridRPP(""ReimbursementFundDetails""));");
base.WriteDebugInfo(@"EXEC AddFormGridDataD85301F7BAF94BE8A2B174E5CBB3D054 '@@gv_InstanceId','@@gv_ProcessMapId','D85301F7-BAF9-4BE8-A2B1-74E5CBB3D054','@@gv_ActivityMapId','#MFG_P3_FundDetailsId','#MFG_P3_ReimbursementId','#MFG_P3_FundTypeId','#MFG_P3_ProjectDetailsId','#MFG_P3_BudgetHeadId',#MFG_P3_Amount,'#growid'");


List<Triplet<string, short, short?>> result25A00CF73B354322B4DFFE24D90229BC=acdataIspace788CA62EDF0F4071B3E34239827AFC52.GetQueryExpressionBindings("25A00CF7-3B35-4322-B4DF-FE24D90229BC");
iSpace.SetGridData(resultCBB3928101F44B3AB89247A0222DAFBA,result25A00CF73B354322B4DFFE24D90229BC,"ReimbursementFundDetails",ref ISpace);
iSpace.UpdateGridBindDetails("ReimbursementFundDetails",result25A00CF73B354322B4DFFE24D90229BC);
}
else
{
base.WriteDebugInfo(@"else");

var querySource334BDAE0A76B4B0F84BCAEF7F4F927FE =GetQueryExpressionDataSource("334BDAE0-A76B-4B0F-84BC-AEF7F4F927FE");

DataTable result334BDAE0A76B4B0F84BCAEF7F4F927FE=iSpace.SetGridDataSource(querySource334BDAE0A76B4B0F84BCAEF7F4F927FE, _objectFactory.GetGridRPP("ReimbursementFundDetails"),@"EXEC UpdateFormGridDataD85301F7BAF94BE8A2B174E5CBB3D054 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','D85301F7-BAF9-4BE8-A2B1-74E5CBB3D054','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["MFG_P3_FundDetailsId"].Value + @"','" + ISpace["MFG_P3_ReimbursementId"].Value + @"','" + ISpace["MFG_P3_FundTypeId"].Value + @"','" + ISpace["MFG_P3_ProjectDetailsId"].Value + @"','" + ISpace["MFG_P3_BudgetHeadId"].Value + @"'," + ISpace["MFG_P3_Amount"].Value + @",'" + ISpace["growid"].Value + @"'");

iSpace.InsertGridBindDetails("ReimbursementFundDetails","11",querySource334BDAE0A76B4B0F84BCAEF7F4F927FE,"EXEC UpdateFormGridDataD85301F7BAF94BE8A2B174E5CBB3D054 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','D85301F7-BAF9-4BE8-A2B1-74E5CBB3D054','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["MFG_P3_FundDetailsId"].Value + @"','" + ISpace["MFG_P3_ReimbursementId"].Value + @"','" + ISpace["MFG_P3_FundTypeId"].Value + @"','" + ISpace["MFG_P3_ProjectDetailsId"].Value + @"','" + ISpace["MFG_P3_BudgetHeadId"].Value + @"'," + ISpace["MFG_P3_Amount"].Value + @",'" + ISpace["growid"].Value + @"'",_objectFactory.GetGridRPP("ReimbursementFundDetails"));

base.WriteDebugInfo(@"var querySource334BDAE0A76B4B0F84BCAEF7F4F927FE =GetQueryExpressionDataSource(""334BDAE0-A76B-4B0F-84BC-AEF7F4F927FE"");DataTable result334BDAE0A76B4B0F84BCAEF7F4F927FE=iSpace.SetGridDataSource(querySource334BDAE0A76B4B0F84BCAEF7F4F927FE, _objectFactory.GetGridRPP(""ReimbursementFundDetails""),@""EXEC UpdateFormGridDataD85301F7BAF94BE8A2B174E5CBB3D054 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','D85301F7-BAF9-4BE8-A2B1-74E5CBB3D054','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""MFG_P3_FundDetailsId""].Value + @""','"" + ISpace[""MFG_P3_ReimbursementId""].Value + @""','"" + ISpace[""MFG_P3_FundTypeId""].Value + @""','"" + ISpace[""MFG_P3_ProjectDetailsId""].Value + @""','"" + ISpace[""MFG_P3_BudgetHeadId""].Value + @""',"" + ISpace[""MFG_P3_Amount""].Value + @"",'"" + ISpace[""growid""].Value + @""'"");iSpace.InsertGridBindDetails(""ReimbursementFundDetails"",""11"",querySource334BDAE0A76B4B0F84BCAEF7F4F927FE,""EXEC UpdateFormGridDataD85301F7BAF94BE8A2B174E5CBB3D054 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','D85301F7-BAF9-4BE8-A2B1-74E5CBB3D054','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""MFG_P3_FundDetailsId""].Value + @""','"" + ISpace[""MFG_P3_ReimbursementId""].Value + @""','"" + ISpace[""MFG_P3_FundTypeId""].Value + @""','"" + ISpace[""MFG_P3_ProjectDetailsId""].Value + @""','"" + ISpace[""MFG_P3_BudgetHeadId""].Value + @""',"" + ISpace[""MFG_P3_Amount""].Value + @"",'"" + ISpace[""growid""].Value + @""'"",_objectFactory.GetGridRPP(""ReimbursementFundDetails""));");
base.WriteDebugInfo(@"EXEC UpdateFormGridDataD85301F7BAF94BE8A2B174E5CBB3D054 '@@gv_InstanceId','@@gv_ProcessMapId','D85301F7-BAF9-4BE8-A2B1-74E5CBB3D054','@@gv_ActivityMapId','#MFG_P3_FundDetailsId','#MFG_P3_ReimbursementId','#MFG_P3_FundTypeId','#MFG_P3_ProjectDetailsId','#MFG_P3_BudgetHeadId',#MFG_P3_Amount,'#growid'");


List<Triplet<string, short, short?>> resultEFFC55B685564D91AE91384F68B422FF=acdataIspace788CA62EDF0F4071B3E34239827AFC52.GetQueryExpressionBindings("EFFC55B6-8556-4D91-AE91-384F68B422FF");
iSpace.SetGridData(result334BDAE0A76B4B0F84BCAEF7F4F927FE,resultEFFC55B685564D91AE91384F68B422FF,"ReimbursementFundDetails",ref ISpace);
iSpace.UpdateGridBindDetails("ReimbursementFundDetails",resultEFFC55B685564D91AE91384F68B422FF);
}
base.WriteDebugInfo(@"#ReimbursementFundDetails[Rows]");
iSpace.GetLoopExpressionData("ReimbursementFundDetails",ref ISpace);

foreach(var gridChild in ISpace["ReimbursementFundDetails"].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 



ISpace["MG_P3_PackageProcessMapId"].Value=ISpace["M_PackageProcessMapId"].Value;
base.WriteDebugInfo(@"

ISpace[""MG_P3_PackageProcessMapId""].Value=ISpace[""M_PackageProcessMapId""].Value;");


ISpace["MG_P3_EmployeeBaicInfoId"].Value=ISpace["UC_EmployeeBaicInfoId"].Value;
base.WriteDebugInfo(@"

ISpace[""MG_P3_EmployeeBaicInfoId""].Value=ISpace[""UC_EmployeeBaicInfoId""].Value;");
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("ReimbursementFundDetails","84AEB9E0-3009-4426-AB92-AAF06D2B42AF",_objectFactory.GetGridRPP("ReimbursementFundDetails"),_elementBase.GetGridLoopQuery("84AEB9E0-3009-4426-AB92-AAF06D2B42AF","ReimbursementFundDetails",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""ReimbursementFundDetails"",ref ISpace);

foreach(var gridChild in ISpace[""ReimbursementFundDetails""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
object MG_P3_Amount=iSpace.Sum("[84AEB9E0-3009-4426-AB92-AAF06D2B42AF]","MG_P3_Amount","",ISpace["gv_instanceid"].Value);
ISpace["MFG_P3_OverallAmount"].Value=Convert.ChangeType(MG_P3_Amount, MG_P3_Amount.GetType());;
base.WriteDebugInfo(@"object MG_P3_Amount=iSpace.Sum(""[84AEB9E0-3009-4426-AB92-AAF06D2B42AF]"",""MG_P3_Amount"","""",ISpace[""gv_instanceid""].Value);
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
private void SubscribeElementEvents_m_view (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"M_View-OnClick");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["MF_ProjectNo"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_ProjectNo""].Value=null;");
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_m_reimbursementtype (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"M_ReimbursementType-OnChange");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["M_ReimbursementType"].Value=="2")
{
base.WriteDebugInfo(@"if(ISpace[""M_ReimbursementType""].Value==""2"")");
ISpace["M_Classification"].Visible="true";ISpace["M_SubClassication"].Visible="true";
base.WriteDebugInfo(@"ISpace[""M_Classification""].Visible=""true"";ISpace[""M_SubClassication""].Visible=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["M_Classification"].Visible="false";ISpace["M_SubClassication"].Visible="false";
base.WriteDebugInfo(@"ISpace[""M_Classification""].Visible=""false"";ISpace[""M_SubClassication""].Visible=""false"";");
}
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
base.WriteDebugInfo(@"EXEC UpsertActivityTrailLogDetails '@@gv_TenantId','#M_InstanceId','@@gv_ActivityName','#MF_P1_Remarks','@@gv_UserName','#M_SourceActivityMapId','#SetDestinationTo','@@gv_UserId','#M_IsSourceStep'");

var querySourcebefdd5b207e912dc5d3682026e5e2134 =GetQueryExpressionDataSource("befdd5b2-07e9-12dc-5d36-82026e5e2134");
Dictionary<short,object> resultbefdd5b207e912dc5d3682026e5e2134=iSpace.ExecuteQuery(querySourcebefdd5b207e912dc5d3682026e5e2134,@"EXEC UpsertActivityTrailLogDetails '" + ISpace["gv_tenantid"].Value + @"','" + ISpace["M_InstanceId"].Value + @"','" + ISpace["gv_activityname"].Value + @"','" + ISpace["MF_P1_Remarks"].Value + @"','" + ISpace["gv_username"].Value + @"','" + ISpace["M_SourceActivityMapId"].Value + @"','" + ISpace["SetDestinationTo"].Value + @"','" + ISpace["gv_userid"].Value + @"','" + ISpace["M_IsSourceStep"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourcebefdd5b207e912dc5d3682026e5e2134 =GetQueryExpressionDataSource(""befdd5b2-07e9-12dc-5d36-82026e5e2134"");Dictionary<short,object> resultbefdd5b207e912dc5d3682026e5e2134=iSpace.ExecuteQuery(querySourcebefdd5b207e912dc5d3682026e5e2134,@""EXEC UpsertActivityTrailLogDetails '"" + ISpace[""gv_tenantid""].Value + @""','"" + ISpace[""M_InstanceId""].Value + @""','"" + ISpace[""gv_activityname""].Value + @""','"" + ISpace[""MF_P1_Remarks""].Value + @""','"" + ISpace[""gv_username""].Value + @""','"" + ISpace[""M_SourceActivityMapId""].Value + @""','"" + ISpace[""SetDestinationTo""].Value + @""','"" + ISpace[""gv_userid""].Value + @""','"" + ISpace[""M_IsSourceStep""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultbefdd5b207e912dc5d3682026e5e2134!=null) && (resultbefdd5b207e912dc5d3682026e5e2134.Count!=0))
{
if(resultbefdd5b207e912dc5d3682026e5e2134.ContainsKey(0))
ISpace["ExecutionMessage"].Value = resultbefdd5b207e912dc5d3682026e5e2134[0];
}
else{
ISpace["ExecutionMessage"].Value = null;
}
}
if(ISpace["M_SaveDomainData"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""M_SaveDomainData""].Value==1)");
ISpace["MF_P1_ApplicationStatus"].Value="A";
base.WriteDebugInfo(@"ISpace[""MF_P1_ApplicationStatus""].Value=""A"";");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC UpsertProjectReimbursement '#MF_P1_ReimbursementId','#UC_EmployeeBaicInfoId','#MF_P1_TotalAmount','@@gv_UserId','#MF_P1_ApplicationStatus','#M_ReimbursementType','#M_Classification','#M_SubClassication','@@gv_UserId'");

var querySourced58dc3c8687f1ebcd4754068de464713 =GetQueryExpressionDataSource("d58dc3c8-687f-1ebc-d475-4068de464713");
Dictionary<short,object> resultd58dc3c8687f1ebcd4754068de464713=iSpace.ExecuteQuery(querySourced58dc3c8687f1ebcd4754068de464713,@"EXEC UpsertProjectReimbursement '" + ISpace["MF_P1_ReimbursementId"].Value + @"','" + ISpace["UC_EmployeeBaicInfoId"].Value + @"','" + ISpace["MF_P1_TotalAmount"].Value + @"','" + ISpace["gv_userid"].Value + @"','" + ISpace["MF_P1_ApplicationStatus"].Value + @"','" + ISpace["M_ReimbursementType"].Value + @"','" + ISpace["M_Classification"].Value + @"','" + ISpace["M_SubClassication"].Value + @"','" + ISpace["gv_userid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourced58dc3c8687f1ebcd4754068de464713 =GetQueryExpressionDataSource(""d58dc3c8-687f-1ebc-d475-4068de464713"");Dictionary<short,object> resultd58dc3c8687f1ebcd4754068de464713=iSpace.ExecuteQuery(querySourced58dc3c8687f1ebcd4754068de464713,@""EXEC UpsertProjectReimbursement '"" + ISpace[""MF_P1_ReimbursementId""].Value + @""','"" + ISpace[""UC_EmployeeBaicInfoId""].Value + @""','"" + ISpace[""MF_P1_TotalAmount""].Value + @""','"" + ISpace[""gv_userid""].Value + @""','"" + ISpace[""MF_P1_ApplicationStatus""].Value + @""','"" + ISpace[""M_ReimbursementType""].Value + @""','"" + ISpace[""M_Classification""].Value + @""','"" + ISpace[""M_SubClassication""].Value + @""','"" + ISpace[""gv_userid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultd58dc3c8687f1ebcd4754068de464713!=null) && (resultd58dc3c8687f1ebcd4754068de464713.Count!=0))
{
if(resultd58dc3c8687f1ebcd4754068de464713.ContainsKey(0))
ISpace["ExecutionMessage"].Value = resultd58dc3c8687f1ebcd4754068de464713[0];
}
else{
ISpace["ExecutionMessage"].Value = null;
}
base.WriteDebugInfo(@"EXEC UpsertProjectReimbursementFundDetails '#MG_P3_FundDetailsId','#MF_P1_ReimbursementId','#MG_P3_FundTypeId','#MG_P3_ProjectDetailsId','#MG_P3_BudgetHeadId','#MG_P3_Amount'");

var querySource478236c45c793773d35402c74092c916 =GetQueryExpressionDataSource("478236c4-5c79-3773-d354-02c74092c916");
Dictionary<short,object> result478236c45c793773d35402c74092c916=iSpace.ExecuteQuery(querySource478236c45c793773d35402c74092c916,@"EXEC UpsertProjectReimbursementFundDetails '" + ISpace["MG_P3_FundDetailsId"].Value + @"','" + ISpace["MF_P1_ReimbursementId"].Value + @"','" + ISpace["MG_P3_FundTypeId"].Value + @"','" + ISpace["MG_P3_ProjectDetailsId"].Value + @"','" + ISpace["MG_P3_BudgetHeadId"].Value + @"','" + ISpace["MG_P3_Amount"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource478236c45c793773d35402c74092c916 =GetQueryExpressionDataSource(""478236c4-5c79-3773-d354-02c74092c916"");Dictionary<short,object> result478236c45c793773d35402c74092c916=iSpace.ExecuteQuery(querySource478236c45c793773d35402c74092c916,@""EXEC UpsertProjectReimbursementFundDetails '"" + ISpace[""MG_P3_FundDetailsId""].Value + @""','"" + ISpace[""MF_P1_ReimbursementId""].Value + @""','"" + ISpace[""MG_P3_FundTypeId""].Value + @""','"" + ISpace[""MG_P3_ProjectDetailsId""].Value + @""','"" + ISpace[""MG_P3_BudgetHeadId""].Value + @""','"" + ISpace[""MG_P3_Amount""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result478236c45c793773d35402c74092c916!=null) && (result478236c45c793773d35402c74092c916.Count!=0))
{
if(result478236c45c793773d35402c74092c916.ContainsKey(0))
ISpace["ExecutionMessage"].Value = result478236c45c793773d35402c74092c916[0];
}
else{
ISpace["ExecutionMessage"].Value = null;
}
base.WriteDebugInfo(@"EXEC UpsertProjectReimbursementBillDetails '#MG_P2_ReimbursementDetailsId','#MF_P1_ReimbursementId','#MG_P2_BillNo','#MG_P2_BillDate',NULL,'#MG_P2_ItemDescription','#MG_P2_Amount'");

var querySource0ac6af4e84d7e8d409946108bb08331c =GetQueryExpressionDataSource("0ac6af4e-84d7-e8d4-0994-6108bb08331c");
Dictionary<short,object> result0ac6af4e84d7e8d409946108bb08331c=iSpace.ExecuteQuery(querySource0ac6af4e84d7e8d409946108bb08331c,@"EXEC UpsertProjectReimbursementBillDetails '" + ISpace["MG_P2_ReimbursementDetailsId"].Value + @"','" + ISpace["MF_P1_ReimbursementId"].Value + @"','" + ISpace["MG_P2_BillNo"].Value + @"','" + ISpace["MG_P2_BillDate"].Value + @"',NULL,'" + ISpace["MG_P2_ItemDescription"].Value + @"','" + ISpace["MG_P2_Amount"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource0ac6af4e84d7e8d409946108bb08331c =GetQueryExpressionDataSource(""0ac6af4e-84d7-e8d4-0994-6108bb08331c"");Dictionary<short,object> result0ac6af4e84d7e8d409946108bb08331c=iSpace.ExecuteQuery(querySource0ac6af4e84d7e8d409946108bb08331c,@""EXEC UpsertProjectReimbursementBillDetails '"" + ISpace[""MG_P2_ReimbursementDetailsId""].Value + @""','"" + ISpace[""MF_P1_ReimbursementId""].Value + @""','"" + ISpace[""MG_P2_BillNo""].Value + @""','"" + ISpace[""MG_P2_BillDate""].Value + @""',NULL,'"" + ISpace[""MG_P2_ItemDescription""].Value + @""','"" + ISpace[""MG_P2_Amount""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result0ac6af4e84d7e8d409946108bb08331c!=null) && (result0ac6af4e84d7e8d409946108bb08331c.Count!=0))
{
if(result0ac6af4e84d7e8d409946108bb08331c.ContainsKey(0))
ISpace["ExecutionMessage"].Value = result0ac6af4e84d7e8d409946108bb08331c[0];
}
else{
ISpace["ExecutionMessage"].Value = null;
}
base.WriteDebugInfo(@"EXEC UpsertDocumentDetails '#M_DocumentDetailsId','#M_InstanceId','#M_PackageProcessMapId','#M_DocumentName','#M_UploadDcoument',' @@gv_UserId'");

var querySource17adfd2bbf7aa7968851003732efc9c7 =GetQueryExpressionDataSource("17adfd2b-bf7a-a796-8851-003732efc9c7");
Dictionary<short,object> result17adfd2bbf7aa7968851003732efc9c7=iSpace.ExecuteQuery(querySource17adfd2bbf7aa7968851003732efc9c7,@"EXEC UpsertDocumentDetails '" + ISpace["M_DocumentDetailsId"].Value + @"','" + ISpace["M_InstanceId"].Value + @"','" + ISpace["M_PackageProcessMapId"].Value + @"','" + ISpace["M_DocumentName"].Value + @"','" + ISpace["M_UploadDcoument"].Value + @"',' " + ISpace["gv_userid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource17adfd2bbf7aa7968851003732efc9c7 =GetQueryExpressionDataSource(""17adfd2b-bf7a-a796-8851-003732efc9c7"");Dictionary<short,object> result17adfd2bbf7aa7968851003732efc9c7=iSpace.ExecuteQuery(querySource17adfd2bbf7aa7968851003732efc9c7,@""EXEC UpsertDocumentDetails '"" + ISpace[""M_DocumentDetailsId""].Value + @""','"" + ISpace[""M_InstanceId""].Value + @""','"" + ISpace[""M_PackageProcessMapId""].Value + @""','"" + ISpace[""M_DocumentName""].Value + @""','"" + ISpace[""M_UploadDcoument""].Value + @""',' "" + ISpace[""gv_userid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result17adfd2bbf7aa7968851003732efc9c7!=null) && (result17adfd2bbf7aa7968851003732efc9c7.Count!=0))
{
if(result17adfd2bbf7aa7968851003732efc9c7.ContainsKey(0))
ISpace["ExecutionMessage"].Value = result17adfd2bbf7aa7968851003732efc9c7[0];
}
else{
ISpace["ExecutionMessage"].Value = null;
}
}
}
ISpace["Subject"].Value="Project Reimbursement";
base.WriteDebugInfo(@"ISpace[""Subject""].Value=""Project Reimbursement"";");
ISpace["SetDestinationTo"].Value=ISpace["M_DestinationActivityId"].Value;
base.WriteDebugInfo(@"ISpace[""SetDestinationTo""].Value=ISpace[""M_DestinationActivityId""].Value;");
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
object M_DocumentDetailsId=iSpace.Count("[93570AD2-BC61-4B0C-AE1C-2A20265D17E7]","M_DocumentDetailsId","",ISpace["gv_instanceid"].Value);
ISpace["M_Gridcount"].Value=Convert.ChangeType(M_DocumentDetailsId, M_DocumentDetailsId.GetType());;
base.WriteDebugInfo(@"object M_DocumentDetailsId=iSpace.Count(""[93570AD2-BC61-4B0C-AE1C-2A20265D17E7]"",""M_DocumentDetailsId"","""",ISpace[""gv_instanceid""].Value);
ISpace[""M_Gridcount""].Value=Convert.ChangeType(M_DocumentDetailsId, M_DocumentDetailsId.GetType());;");
if(ISpace["M_Gridcount"].Value==0)
{
base.WriteDebugInfo(@"if(ISpace[""M_Gridcount""].Value==0)");
ISpace["Message"].Value=@"Please upload atleast one Document in Document Details Grid";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please upload atleast one Document in Document Details Grid"";");
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
if (_elementBase != null)  iSpace.SetLoopExpressionData("MG_DcoumentDetails","93570AD2-BC61-4B0C-AE1C-2A20265D17E7",_objectFactory.GetGridRPP("MG_DcoumentDetails"),_elementBase.GetGridLoopQuery("93570AD2-BC61-4B0C-AE1C-2A20265D17E7","MG_DcoumentDetails",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""MG_DcoumentDetails"",ref ISpace);

foreach(var gridChild in ISpace[""MG_DcoumentDetails""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
base.WriteDebugInfo(@"#ReimbursementFundDetails[Rows]");
iSpace.GetLoopExpressionData("ReimbursementFundDetails",ref ISpace);

foreach(var gridChild in ISpace["ReimbursementFundDetails"].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 

base.WriteDebugInfo(@"EXEC [UpsertProjectBudgetDetails] 5,'#MG_P3_ProjectDetailsId','','#MG_P3_Amount','#MG_P3_BudgetHeadId',1,'#MG_P3_FundTypeId'");

var querySource59AD5C1B340B4461907160C69FF84844 =GetQueryExpressionDataSource("59AD5C1B-340B-4461-9071-60C69FF84844");
Dictionary<short,object> result59AD5C1B340B4461907160C69FF84844=iSpace.ExecuteQuery(querySource59AD5C1B340B4461907160C69FF84844,@"EXEC [UpsertProjectBudgetDetails] 5,'" + ISpace["MG_P3_ProjectDetailsId"].Value + @"','','" + ISpace["MG_P3_Amount"].Value + @"','" + ISpace["MG_P3_BudgetHeadId"].Value + @"',1,'" + ISpace["MG_P3_FundTypeId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource59AD5C1B340B4461907160C69FF84844 =GetQueryExpressionDataSource(""59AD5C1B-340B-4461-9071-60C69FF84844"");Dictionary<short,object> result59AD5C1B340B4461907160C69FF84844=iSpace.ExecuteQuery(querySource59AD5C1B340B4461907160C69FF84844,@""EXEC [UpsertProjectBudgetDetails] 5,'"" + ISpace[""MG_P3_ProjectDetailsId""].Value + @""','','"" + ISpace[""MG_P3_Amount""].Value + @""','"" + ISpace[""MG_P3_BudgetHeadId""].Value + @""',1,'"" + ISpace[""MG_P3_FundTypeId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result59AD5C1B340B4461907160C69FF84844!=null) && (result59AD5C1B340B4461907160C69FF84844.Count!=0))
{
if(result59AD5C1B340B4461907160C69FF84844.ContainsKey(0))
ISpace["M_UpdateCount"].Value = result59AD5C1B340B4461907160C69FF84844[0];
}
else{
ISpace["M_UpdateCount"].Value = null;
}
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("ReimbursementFundDetails","84AEB9E0-3009-4426-AB92-AAF06D2B42AF",_objectFactory.GetGridRPP("ReimbursementFundDetails"),_elementBase.GetGridLoopQuery("84AEB9E0-3009-4426-AB92-AAF06D2B42AF","ReimbursementFundDetails",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""ReimbursementFundDetails"",ref ISpace);

foreach(var gridChild in ISpace[""ReimbursementFundDetails""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["M_Status"].Value="Pending";
base.WriteDebugInfo(@"ISpace[""M_Status""].Value=""Pending"";");
base.WriteDebugInfo(@"EXEC UpsertUserRequestsInitation '#M_InstanceId','@@gv_ProcessMapId','#Subject','@@gv_UserId','#SetDestinationTo','#M_Stage','#M_Status','@@gv_UserId','#M_RequestId'");

var querySourcef9e187b210afcb843cd943870f735c13 =GetQueryExpressionDataSource("f9e187b2-10af-cb84-3cd9-43870f735c13");
Dictionary<short,object> resultf9e187b210afcb843cd943870f735c13=iSpace.ExecuteQuery(querySourcef9e187b210afcb843cd943870f735c13,@"EXEC UpsertUserRequestsInitation '" + ISpace["M_InstanceId"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','" + ISpace["Subject"].Value + @"','" + ISpace["gv_userid"].Value + @"','" + ISpace["SetDestinationTo"].Value + @"','" + ISpace["M_Stage"].Value + @"','" + ISpace["M_Status"].Value + @"','" + ISpace["gv_userid"].Value + @"','" + ISpace["M_RequestId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourcef9e187b210afcb843cd943870f735c13 =GetQueryExpressionDataSource(""f9e187b2-10af-cb84-3cd9-43870f735c13"");Dictionary<short,object> resultf9e187b210afcb843cd943870f735c13=iSpace.ExecuteQuery(querySourcef9e187b210afcb843cd943870f735c13,@""EXEC UpsertUserRequestsInitation '"" + ISpace[""M_InstanceId""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','"" + ISpace[""Subject""].Value + @""','"" + ISpace[""gv_userid""].Value + @""','"" + ISpace[""SetDestinationTo""].Value + @""','"" + ISpace[""M_Stage""].Value + @""','"" + ISpace[""M_Status""].Value + @""','"" + ISpace[""gv_userid""].Value + @""','"" + ISpace[""M_RequestId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultf9e187b210afcb843cd943870f735c13!=null) && (resultf9e187b210afcb843cd943870f735c13.Count!=0))
{
if(resultf9e187b210afcb843cd943870f735c13.ContainsKey(0))
ISpace["ExecutionMessage"].Value = resultf9e187b210afcb843cd943870f735c13[0];
}
else{
ISpace["ExecutionMessage"].Value = null;
}
}
ISpace["Message"].Value=@"Submitted Successfully";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Submitted Successfully"";");
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
base.WriteDebugInfo(@"EXEC LoadFormGridDataD85301F7BAF94BE8A2B174E5CBB3D054 '@@gv_InstanceId','@@gv_ProcessMapId','D85301F7-BAF9-4BE8-A2B1-74E5CBB3D054','@@gv_ActivityMapId','#growid'");

var querySource1F49FB0DA84D47A58942368F58A2D97A =GetQueryExpressionDataSource("1F49FB0D-A84D-47A5-8942-368F58A2D97A");
Dictionary<short,object> result1F49FB0DA84D47A58942368F58A2D97A=iSpace.ExecuteQuery(querySource1F49FB0DA84D47A58942368F58A2D97A,@"EXEC LoadFormGridDataD85301F7BAF94BE8A2B174E5CBB3D054 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','D85301F7-BAF9-4BE8-A2B1-74E5CBB3D054','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["growid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource1F49FB0DA84D47A58942368F58A2D97A =GetQueryExpressionDataSource(""1F49FB0D-A84D-47A5-8942-368F58A2D97A"");Dictionary<short,object> result1F49FB0DA84D47A58942368F58A2D97A=iSpace.ExecuteQuery(querySource1F49FB0DA84D47A58942368F58A2D97A,@""EXEC LoadFormGridDataD85301F7BAF94BE8A2B174E5CBB3D054 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','D85301F7-BAF9-4BE8-A2B1-74E5CBB3D054','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""growid""].Value + @""'"",false);");
base.WriteDebugInfo(@"EXEC LoadFormGridDataD85301F7BAF94BE8A2B174E5CBB3D054 '@@gv_InstanceId','@@gv_ProcessMapId','D85301F7-BAF9-4BE8-A2B1-74E5CBB3D054','@@gv_ActivityMapId','#growid'");

if((result1F49FB0DA84D47A58942368F58A2D97A!=null) && (result1F49FB0DA84D47A58942368F58A2D97A.Count!=0))
{
if(result1F49FB0DA84D47A58942368F58A2D97A.ContainsKey(4))
ISpace["MFG_P3_BudgetHeadId"].Value = result1F49FB0DA84D47A58942368F58A2D97A[4];
if(result1F49FB0DA84D47A58942368F58A2D97A.ContainsKey(3))
ISpace["MFG_P3_ProjectDetailsId"].Value = result1F49FB0DA84D47A58942368F58A2D97A[3];
if(result1F49FB0DA84D47A58942368F58A2D97A.ContainsKey(2))
ISpace["MFG_P3_FundTypeId"].Value = result1F49FB0DA84D47A58942368F58A2D97A[2];
if(result1F49FB0DA84D47A58942368F58A2D97A.ContainsKey(5))
ISpace["MFG_P3_Amount"].Value = result1F49FB0DA84D47A58942368F58A2D97A[5];
if(result1F49FB0DA84D47A58942368F58A2D97A.ContainsKey(1))
ISpace["MFG_P3_ReimbursementId"].Value = result1F49FB0DA84D47A58942368F58A2D97A[1];
if(result1F49FB0DA84D47A58942368F58A2D97A.ContainsKey(0))
ISpace["MFG_P3_FundDetailsId"].Value = result1F49FB0DA84D47A58942368F58A2D97A[0];
}
else{
ISpace["MFG_P3_BudgetHeadId"].Value = null;ISpace["MFG_P3_ProjectDetailsId"].Value = null;ISpace["MFG_P3_FundTypeId"].Value = null;ISpace["MFG_P3_Amount"].Value = null;ISpace["MFG_P3_ReimbursementId"].Value = null;ISpace["MFG_P3_FundDetailsId"].Value = null;
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MFG_P3_FundTypeId"].Value=="1")
{
base.WriteDebugInfo(@"if(ISpace[""MFG_P3_FundTypeId""].Value==""1"")");
ISpace["MFG_P3_BudgetHeadId"].Visible="true";ISpace["MFG_P3_BudgetHeadId"].Man=true;ISpace["MFG_P3_ProjectDetailsId"].Visible="true";ISpace["MFG_P3_ProjectDetailsId"].Man=true;ISpace["MFG_P3_Amount"].Visible="true";
base.WriteDebugInfo(@"ISpace[""MFG_P3_BudgetHeadId""].Visible=""true"";ISpace[""MFG_P3_BudgetHeadId""].Man=true;ISpace[""MFG_P3_ProjectDetailsId""].Visible=""true"";ISpace[""MFG_P3_ProjectDetailsId""].Man=true;ISpace[""MFG_P3_Amount""].Visible=""true"";");
if(ISpace["FormVersionId"].Value=="9376EEBF-92B0-4B68-9085-73DD4ED3F42B")
{
ISpace["UI_BudgetColumn"].Visible="true";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""9376EEBF-92B0-4B68-9085-73DD4ED3F42B"")
{
ISpace[""UI_BudgetColumn""].Visible=""true"";
}");
ISpace["MFG_P3_BudgetHeadId"].rElemData=iSpace.Reload(ISpace["MFG_P3_BudgetHeadId"].Value,@"exec SP_GetDistrubitionDetails 5,'" + ISpace["M_PackageProcessMapId"].Value + @"','" + ISpace["MFG_P3_FundTypeId"].Value + @"','','','','','" + ISpace["MFG_P3_ProjectDetailsId"].Value + @"'","9ADED37B-CD11-426B-AF16-DEAC75685EF5");
base.WriteDebugInfo(@"ISpace[""MFG_P3_BudgetHeadId""].rElemData=iSpace.Reload(ISpace[""MFG_P3_BudgetHeadId""].Value,@""exec SP_GetDistrubitionDetails 5,'"" + ISpace[""M_PackageProcessMapId""].Value + @""','"" + ISpace[""MFG_P3_FundTypeId""].Value + @""','','','','','"" + ISpace[""MFG_P3_ProjectDetailsId""].Value + @""'"",""9ADED37B-CD11-426B-AF16-DEAC75685EF5"");");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MFG_P3_BudgetHeadId"].Visible="false";ISpace["MFG_P3_BudgetHeadId"].Man=false;ISpace["MFG_P3_ProjectDetailsId"].Visible="false";ISpace["MFG_P3_ProjectDetailsId"].Man=false;ISpace["MFG_P3_Amount"].Visible="true";
base.WriteDebugInfo(@"ISpace[""MFG_P3_BudgetHeadId""].Visible=""false"";ISpace[""MFG_P3_BudgetHeadId""].Man=false;ISpace[""MFG_P3_ProjectDetailsId""].Visible=""false"";ISpace[""MFG_P3_ProjectDetailsId""].Man=false;ISpace[""MFG_P3_Amount""].Visible=""true"";");
if(ISpace["FormVersionId"].Value=="9376EEBF-92B0-4B68-9085-73DD4ED3F42B")
{
ISpace["UI_BudgetColumn"].Visible="false";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""9376EEBF-92B0-4B68-9085-73DD4ED3F42B"")
{
ISpace[""UI_BudgetColumn""].Visible=""false"";
}");
}
}
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
private void SubscribeElementEvents_mfg_p3_projectdetailsid (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MFG_P3_ProjectDetailsId-OnChange");
ISpace["MFG_P3_BudgetHeadId"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_P3_BudgetHeadId""].Value="""";");
ISpace["MFG_P3_BudgetHeadId"].rElemData=iSpace.Reload(ISpace["MFG_P3_BudgetHeadId"].Value,@"exec SP_GetDistrubitionDetails 5,'" + ISpace["M_PackageProcessMapId"].Value + @"','" + ISpace["MFG_P3_FundTypeId"].Value + @"','','','','','" + ISpace["MFG_P3_ProjectDetailsId"].Value + @"'","9ADED37B-CD11-426B-AF16-DEAC75685EF5");
base.WriteDebugInfo(@"ISpace[""MFG_P3_BudgetHeadId""].rElemData=iSpace.Reload(ISpace[""MFG_P3_BudgetHeadId""].Value,@""exec SP_GetDistrubitionDetails 5,'"" + ISpace[""M_PackageProcessMapId""].Value + @""','"" + ISpace[""MFG_P3_FundTypeId""].Value + @""','','','','','"" + ISpace[""MFG_P3_ProjectDetailsId""].Value + @""'"",""9ADED37B-CD11-426B-AF16-DEAC75685EF5"");");
ISpace["MFG_P3_Amount"].Value=0;
base.WriteDebugInfo(@"ISpace[""MFG_P3_Amount""].Value=0;");
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
ISpace["MFG_P3_BudgetHeadId"].Visible="true";ISpace["MFG_P3_BudgetHeadId"].Man=true;ISpace["MFG_P3_ProjectDetailsId"].Visible="true";ISpace["MFG_P3_ProjectDetailsId"].Man=true;ISpace["MFG_P3_Amount"].Visible="true";
base.WriteDebugInfo(@"ISpace[""MFG_P3_BudgetHeadId""].Visible=""true"";ISpace[""MFG_P3_BudgetHeadId""].Man=true;ISpace[""MFG_P3_ProjectDetailsId""].Visible=""true"";ISpace[""MFG_P3_ProjectDetailsId""].Man=true;ISpace[""MFG_P3_Amount""].Visible=""true"";");
if(ISpace["FormVersionId"].Value=="9376EEBF-92B0-4B68-9085-73DD4ED3F42B")
{
ISpace["UI_BudgetColumn"].Visible="true";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""9376EEBF-92B0-4B68-9085-73DD4ED3F42B"")
{
ISpace[""UI_BudgetColumn""].Visible=""true"";
}");
ISpace["MFG_P3_BudgetHeadId"].rElemData=iSpace.Reload(ISpace["MFG_P3_BudgetHeadId"].Value,@"exec SP_GetDistrubitionDetails 5,'" + ISpace["M_PackageProcessMapId"].Value + @"','" + ISpace["MFG_P3_FundTypeId"].Value + @"','','','','','" + ISpace["MFG_P3_ProjectDetailsId"].Value + @"'","9ADED37B-CD11-426B-AF16-DEAC75685EF5");
base.WriteDebugInfo(@"ISpace[""MFG_P3_BudgetHeadId""].rElemData=iSpace.Reload(ISpace[""MFG_P3_BudgetHeadId""].Value,@""exec SP_GetDistrubitionDetails 5,'"" + ISpace[""M_PackageProcessMapId""].Value + @""','"" + ISpace[""MFG_P3_FundTypeId""].Value + @""','','','','','"" + ISpace[""MFG_P3_ProjectDetailsId""].Value + @""'"",""9ADED37B-CD11-426B-AF16-DEAC75685EF5"");");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MFG_P3_BudgetHeadId"].Visible="false";ISpace["MFG_P3_BudgetHeadId"].Man=false;ISpace["MFG_P3_ProjectDetailsId"].Visible="false";ISpace["MFG_P3_ProjectDetailsId"].Man=false;ISpace["MFG_P3_Amount"].Visible="true";
base.WriteDebugInfo(@"ISpace[""MFG_P3_BudgetHeadId""].Visible=""false"";ISpace[""MFG_P3_BudgetHeadId""].Man=false;ISpace[""MFG_P3_ProjectDetailsId""].Visible=""false"";ISpace[""MFG_P3_ProjectDetailsId""].Man=false;ISpace[""MFG_P3_Amount""].Visible=""true"";");
if(ISpace["FormVersionId"].Value=="9376EEBF-92B0-4B68-9085-73DD4ED3F42B")
{
ISpace["UI_BudgetColumn"].Visible="false";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""9376EEBF-92B0-4B68-9085-73DD4ED3F42B"")
{
ISpace[""UI_BudgetColumn""].Visible=""false"";
}");
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
private void SubscribeElementEvents_ui_yes (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"UI_Yes-OnClick");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySourceB561876536C3484CA5643707FD364056 =GetQueryExpressionDataSource("B5618765-36C3-484C-A564-3707FD364056");

DataTable resultB561876536C3484CA5643707FD364056=iSpace.SetGridDataSource(querySourceB561876536C3484CA5643707FD364056, _objectFactory.GetGridRPP("ReimbursementBillDetails"),@"EXEC DeleteFormGridDataC9ACCA847AF347E79133D777BE46A656 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','C9ACCA84-7AF3-47E7-9133-D777BE46A656','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["growid"].Value + @"'");

iSpace.InsertGridBindDetails("ReimbursementBillDetails","11",querySourceB561876536C3484CA5643707FD364056,"EXEC DeleteFormGridDataC9ACCA847AF347E79133D777BE46A656 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','C9ACCA84-7AF3-47E7-9133-D777BE46A656','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["growid"].Value + @"'",_objectFactory.GetGridRPP("ReimbursementBillDetails"));

base.WriteDebugInfo(@"var querySourceB561876536C3484CA5643707FD364056 =GetQueryExpressionDataSource(""B5618765-36C3-484C-A564-3707FD364056"");DataTable resultB561876536C3484CA5643707FD364056=iSpace.SetGridDataSource(querySourceB561876536C3484CA5643707FD364056, _objectFactory.GetGridRPP(""ReimbursementBillDetails""),@""EXEC DeleteFormGridDataC9ACCA847AF347E79133D777BE46A656 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','C9ACCA84-7AF3-47E7-9133-D777BE46A656','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""growid""].Value + @""'"");iSpace.InsertGridBindDetails(""ReimbursementBillDetails"",""11"",querySourceB561876536C3484CA5643707FD364056,""EXEC DeleteFormGridDataC9ACCA847AF347E79133D777BE46A656 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','C9ACCA84-7AF3-47E7-9133-D777BE46A656','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""growid""].Value + @""'"",_objectFactory.GetGridRPP(""ReimbursementBillDetails""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> resultB2246D72F13D45E7B72CEFE79CE1C2E4=acdataIspace788CA62EDF0F4071B3E34239827AFC52.GetQueryExpressionBindings("B2246D72-F13D-45E7-B72C-EFE79CE1C2E4");
iSpace.SetGridData(resultB561876536C3484CA5643707FD364056,resultB2246D72F13D45E7B72CEFE79CE1C2E4,"ReimbursementBillDetails",ref ISpace);
iSpace.UpdateGridBindDetails("ReimbursementBillDetails",resultB2246D72F13D45E7B72CEFE79CE1C2E4);
object MG_P2_Amount=iSpace.Sum("[1D198218-D4AF-4E09-9A9D-119D03D0C3BA]","MG_P2_Amount","",ISpace["gv_instanceid"].Value);
ISpace["MF_P1_TotalAmount"].Value=Convert.ChangeType(MG_P2_Amount, MG_P2_Amount.GetType());;
base.WriteDebugInfo(@"object MG_P2_Amount=iSpace.Sum(""[1D198218-D4AF-4E09-9A9D-119D03D0C3BA]"",""MG_P2_Amount"","""",ISpace[""gv_instanceid""].Value);
ISpace[""MF_P1_TotalAmount""].Value=Convert.ChangeType(MG_P2_Amount, MG_P2_Amount.GetType());;");
ISpace["Message"].Value=@"Data Deleted Successfully";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Data Deleted Successfully"";");
ISpace["growid"].Value="";
base.WriteDebugInfo(@"ISpace[""growid""].Value="""";");
ISpace["UI_DialogBox"].HideDialog=true;;
base.WriteDebugInfo(@"ISpace[""UI_DialogBox""].HideDialog=true;;");
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

var querySource068CB07446DC429F98877296FCE9263F =GetQueryExpressionDataSource("068CB074-46DC-429F-9887-7296FCE9263F");

DataTable result068CB07446DC429F98877296FCE9263F=iSpace.SetGridDataSource(querySource068CB07446DC429F98877296FCE9263F, _objectFactory.GetGridRPP("MG_CommitmentDetails"),@"EXEC GetProjectBudgetInformation '" + ISpace["MF_ProjectNo"].Value + @"'");

iSpace.InsertGridBindDetails("MG_CommitmentDetails","11",querySource068CB07446DC429F98877296FCE9263F,"EXEC GetProjectBudgetInformation '" + ISpace["MF_ProjectNo"].Value + @"'",_objectFactory.GetGridRPP("MG_CommitmentDetails"));

base.WriteDebugInfo(@"var querySource068CB07446DC429F98877296FCE9263F =GetQueryExpressionDataSource(""068CB074-46DC-429F-9887-7296FCE9263F"");DataTable result068CB07446DC429F98877296FCE9263F=iSpace.SetGridDataSource(querySource068CB07446DC429F98877296FCE9263F, _objectFactory.GetGridRPP(""MG_CommitmentDetails""),@""EXEC GetProjectBudgetInformation '"" + ISpace[""MF_ProjectNo""].Value + @""'"");iSpace.InsertGridBindDetails(""MG_CommitmentDetails"",""11"",querySource068CB07446DC429F98877296FCE9263F,""EXEC GetProjectBudgetInformation '"" + ISpace[""MF_ProjectNo""].Value + @""'"",_objectFactory.GetGridRPP(""MG_CommitmentDetails""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result6A8A8C0472ED4B2E9A10872111E1778C=acdataIspace788CA62EDF0F4071B3E34239827AFC52.GetQueryExpressionBindings("6A8A8C04-72ED-4B2E-9A10-872111E1778C");
iSpace.SetGridData(result068CB07446DC429F98877296FCE9263F,result6A8A8C0472ED4B2E9A10872111E1778C,"MG_CommitmentDetails",ref ISpace);
iSpace.UpdateGridBindDetails("MG_CommitmentDetails",result6A8A8C0472ED4B2E9A10872111E1778C);
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
		if(elementName.ToLower().Equals("m_classification"))
    {
    			SubscribeElementEvents_m_classification(ref dfsParam);
    }
		if(elementName.ToLower().Equals("m_reimbursementtype"))
    {
    			SubscribeElementEvents_m_reimbursementtype(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mfg_p3_budgetheadid"))
    {
    			SubscribeElementEvents_mfg_p3_budgetheadid(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mfg_p3_projectdetailsid"))
    {
    			SubscribeElementEvents_mfg_p3_projectdetailsid(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mfg_p3_fundtypeid"))
    {
    			SubscribeElementEvents_mfg_p3_fundtypeid(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mf_projectno"))
    {
    			SubscribeElementEvents_mf_projectno(ref dfsParam);
    }
}
	if(methodName.ToLower().Equals("onclick"))
{
		if(elementName.ToLower().Equals("delete_reimbursementbilldetails"))
{
			SubscribeElementEvents_delete_reimbursementbilldetails(ref dfsParam);
}
		if(elementName.ToLower().Equals("edit_reimbursementbilldetails"))
{
			SubscribeElementEvents_edit_reimbursementbilldetails(ref dfsParam);
}
		if(elementName.ToLower().Equals("save_reimbursementbilldetails"))
{
			SubscribeElementEvents_save_reimbursementbilldetails(ref dfsParam);
}
		if(elementName.ToLower().Equals("delete_reimbursementfunddetails"))
{
			SubscribeElementEvents_delete_reimbursementfunddetails(ref dfsParam);
}
		if(elementName.ToLower().Equals("save_reimbursementfunddetails"))
{
			SubscribeElementEvents_save_reimbursementfunddetails(ref dfsParam);
}
		if(elementName.ToLower().Equals("m_view"))
{
			SubscribeElementEvents_m_view(ref dfsParam);
}
		if(elementName.ToLower().Equals("submitform"))
{
			SubscribeElementEvents_submitform(ref dfsParam);
}
		if(elementName.ToLower().Equals("edit_reimbursementfunddetails"))
{
			SubscribeElementEvents_edit_reimbursementfunddetails(ref dfsParam);
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
public class ISpace01ABEB23E635437DA24F27342FB92C55 : VirtualForm
{
IISpace iSpace = new ISpace();
AcDataISpace01ABEB23E635437DA24F27342FB92C55 acdataIspace01ABEB23E635437DA24F27342FB92C55=new AcDataISpace01ABEB23E635437DA24F27342FB92C55();
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

var querySource820D767A20CC4BA1AADCA484B0BFBEFA =GetQueryExpressionDataSource("820D767A-20CC-4BA1-AADC-A484B0BFBEFA");

DataTable result820D767A20CC4BA1AADCA484B0BFBEFA=iSpace.SetGridDataSource(querySource820D767A20CC4BA1AADCA484B0BFBEFA, _objectFactory.GetGridRPP("MG_RemarksDetails"),@"EXEC GetRemarks '" + ISpace["M_InstanceId"].Value + @"'");

iSpace.InsertGridBindDetails("MG_RemarksDetails","11",querySource820D767A20CC4BA1AADCA484B0BFBEFA,"EXEC GetRemarks '" + ISpace["M_InstanceId"].Value + @"'",_objectFactory.GetGridRPP("MG_RemarksDetails"));

base.WriteDebugInfo(@"var querySource820D767A20CC4BA1AADCA484B0BFBEFA =GetQueryExpressionDataSource(""820D767A-20CC-4BA1-AADC-A484B0BFBEFA"");DataTable result820D767A20CC4BA1AADCA484B0BFBEFA=iSpace.SetGridDataSource(querySource820D767A20CC4BA1AADCA484B0BFBEFA, _objectFactory.GetGridRPP(""MG_RemarksDetails""),@""EXEC GetRemarks '"" + ISpace[""M_InstanceId""].Value + @""'"");iSpace.InsertGridBindDetails(""MG_RemarksDetails"",""11"",querySource820D767A20CC4BA1AADCA484B0BFBEFA,""EXEC GetRemarks '"" + ISpace[""M_InstanceId""].Value + @""'"",_objectFactory.GetGridRPP(""MG_RemarksDetails""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> resultE57D76A324374EAF8C530F41C6AF052C=acdataIspace01ABEB23E635437DA24F27342FB92C55.GetQueryExpressionBindings("E57D76A3-2437-4EAF-8C53-0F41C6AF052C");
iSpace.SetGridData(result820D767A20CC4BA1AADCA484B0BFBEFA,resultE57D76A324374EAF8C530F41C6AF052C,"MG_RemarksDetails",ref ISpace);
iSpace.UpdateGridBindDetails("MG_RemarksDetails",resultE57D76A324374EAF8C530F41C6AF052C);
ISpace["MFG_P3_BudgetHeadId"].Visible="false";ISpace["MFG_P3_ProjectDetailsId"].Visible="false";ISpace["MFG_P3_Amount"].Visible="false";
base.WriteDebugInfo(@"ISpace[""MFG_P3_BudgetHeadId""].Visible=""false"";ISpace[""MFG_P3_ProjectDetailsId""].Visible=""false"";ISpace[""MFG_P3_Amount""].Visible=""false"";");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["MFG_P2_ItemDescription"].Visible="false";ISpace["MFG_P2_BillDocument"].Visible="false";ISpace["MFG_P2_ReimbursementId"].Visible="false";ISpace["MFG_P2_BillNo"].Visible="false";ISpace["MFG_P3_ReimbursementId"].Visible="false";ISpace["MF_P1_TotalAmount"].Visible="true";ISpace["MF_P1_ApplicationStatus"].Visible="false";ISpace["MF_P1_Initiatedon"].Visible="false";ISpace["MFG_P2_Amount"].Visible="false";ISpace["MF_P1_ReimbursementId"].Visible="false";ISpace["MFG_P2_ReimbursementDetailsId"].Visible="false";ISpace["MFG_P3_BudgetHeadId"].Visible="false";ISpace["MF_P1_InitatedBy"].Visible="false";ISpace["MFG_P3_ProjectDetailsId"].Visible="false";ISpace["MFG_P3_FundTypeId"].Visible="false";ISpace["MFG_P3_FundDetailsId"].Visible="false";ISpace["MFG_P3_Amount"].Visible="false";ISpace["MF_P1_UpdatedBy"].Visible="false";ISpace["MF_P1_UpdatedOn"].Visible="false";ISpace["MFG_P2_BillDate"].Visible="false";ISpace["MF_P1_EmployeeBasicInfoId"].Visible="false";
base.WriteDebugInfo(@"ISpace[""MFG_P2_ItemDescription""].Visible=""false"";ISpace[""MFG_P2_BillDocument""].Visible=""false"";ISpace[""MFG_P2_ReimbursementId""].Visible=""false"";ISpace[""MFG_P2_BillNo""].Visible=""false"";ISpace[""MFG_P3_ReimbursementId""].Visible=""false"";ISpace[""MF_P1_TotalAmount""].Visible=""true"";ISpace[""MF_P1_ApplicationStatus""].Visible=""false"";ISpace[""MF_P1_Initiatedon""].Visible=""false"";ISpace[""MFG_P2_Amount""].Visible=""false"";ISpace[""MF_P1_ReimbursementId""].Visible=""false"";ISpace[""MFG_P2_ReimbursementDetailsId""].Visible=""false"";ISpace[""MFG_P3_BudgetHeadId""].Visible=""false"";ISpace[""MF_P1_InitatedBy""].Visible=""false"";ISpace[""MFG_P3_ProjectDetailsId""].Visible=""false"";ISpace[""MFG_P3_FundTypeId""].Visible=""false"";ISpace[""MFG_P3_FundDetailsId""].Visible=""false"";ISpace[""MFG_P3_Amount""].Visible=""false"";ISpace[""MF_P1_UpdatedBy""].Visible=""false"";ISpace[""MF_P1_UpdatedOn""].Visible=""false"";ISpace[""MFG_P2_BillDate""].Visible=""false"";ISpace[""MF_P1_EmployeeBasicInfoId""].Visible=""false"";");
ISpace["MG_P2_ReimbursementId"].Visible="false";ISpace["MG_P2_BillDocument"].Visible="false";ISpace["MG_P2_BillDate"].Visible="true";ISpace["MG_P2_BillNo"].Visible="true";ISpace["MG_P2_ItemDescription"].Visible="true";ISpace["MG_P2_Amount"].Visible="true";ISpace["MG_P2_ReimbursementDetailsId"].Visible="false";
base.WriteDebugInfo(@"ISpace[""MG_P2_ReimbursementId""].Visible=""false"";ISpace[""MG_P2_BillDocument""].Visible=""false"";ISpace[""MG_P2_BillDate""].Visible=""true"";ISpace[""MG_P2_BillNo""].Visible=""true"";ISpace[""MG_P2_ItemDescription""].Visible=""true"";ISpace[""MG_P2_Amount""].Visible=""true"";ISpace[""MG_P2_ReimbursementDetailsId""].Visible=""false"";");
ISpace["MG_P3_Amount"].Visible="true";ISpace["MG_P3_BudgetHeadId"].Visible="true";ISpace["MG_P3_ProjectDetailsId"].Visible="true";ISpace["MG_P3_ReimbursementId"].Visible="false";ISpace["MG_P3_FundDetailsId"].Visible="false";ISpace["MG_P3_FundTypeId"].Visible="true";
base.WriteDebugInfo(@"ISpace[""MG_P3_Amount""].Visible=""true"";ISpace[""MG_P3_BudgetHeadId""].Visible=""true"";ISpace[""MG_P3_ProjectDetailsId""].Visible=""true"";ISpace[""MG_P3_ReimbursementId""].Visible=""false"";ISpace[""MG_P3_FundDetailsId""].Visible=""false"";ISpace[""MG_P3_FundTypeId""].Visible=""true"";");
}
if(ISpace["M_ReimbursementType"].Value=="2")
{
base.WriteDebugInfo(@"if(ISpace[""M_ReimbursementType""].Value==""2"")");
ISpace["M_Classification"].Visible="true";ISpace["M_SubClassication"].Visible="true";
base.WriteDebugInfo(@"ISpace[""M_Classification""].Visible=""true"";ISpace[""M_SubClassication""].Visible=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["M_Classification"].Visible="false";ISpace["M_SubClassication"].Visible="false";
base.WriteDebugInfo(@"ISpace[""M_Classification""].Visible=""false"";ISpace[""M_SubClassication""].Visible=""false"";");
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
ISpace["growid"].Value=ISpace["ReimbursementBillDetails_RowId"].Value;
base.WriteDebugInfo(@"ISpace[""growid""].Value=ISpace[""ReimbursementBillDetails_RowId""].Value;");
base.WriteDebugInfo(@"EXEC LoadFormGridDataC9ACCA847AF347E79133D777BE46A656 '@@gv_InstanceId','@@gv_ProcessMapId','C9ACCA84-7AF3-47E7-9133-D777BE46A656','@@gv_ActivityMapId','#growid'");

var querySource3BC8920E9488421CBBA16D92ECF94CB2 =GetQueryExpressionDataSource("3BC8920E-9488-421C-BBA1-6D92ECF94CB2");
Dictionary<short,object> result3BC8920E9488421CBBA16D92ECF94CB2=iSpace.ExecuteQuery(querySource3BC8920E9488421CBBA16D92ECF94CB2,@"EXEC LoadFormGridDataC9ACCA847AF347E79133D777BE46A656 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','C9ACCA84-7AF3-47E7-9133-D777BE46A656','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["growid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource3BC8920E9488421CBBA16D92ECF94CB2 =GetQueryExpressionDataSource(""3BC8920E-9488-421C-BBA1-6D92ECF94CB2"");Dictionary<short,object> result3BC8920E9488421CBBA16D92ECF94CB2=iSpace.ExecuteQuery(querySource3BC8920E9488421CBBA16D92ECF94CB2,@""EXEC LoadFormGridDataC9ACCA847AF347E79133D777BE46A656 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','C9ACCA84-7AF3-47E7-9133-D777BE46A656','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""growid""].Value + @""'"",false);");
base.WriteDebugInfo(@"EXEC LoadFormGridDataC9ACCA847AF347E79133D777BE46A656 '@@gv_InstanceId','@@gv_ProcessMapId','C9ACCA84-7AF3-47E7-9133-D777BE46A656','@@gv_ActivityMapId','#growid'");

if((result3BC8920E9488421CBBA16D92ECF94CB2!=null) && (result3BC8920E9488421CBBA16D92ECF94CB2.Count!=0))
{
if(result3BC8920E9488421CBBA16D92ECF94CB2.ContainsKey(3))
ISpace["MFG_P2_BillDate"].Value = result3BC8920E9488421CBBA16D92ECF94CB2[3];
if(result3BC8920E9488421CBBA16D92ECF94CB2.ContainsKey(4))
ISpace["MFG_P2_BillDocument"].Value = result3BC8920E9488421CBBA16D92ECF94CB2[4];
if(result3BC8920E9488421CBBA16D92ECF94CB2.ContainsKey(6))
ISpace["MFG_P2_Amount"].Value = result3BC8920E9488421CBBA16D92ECF94CB2[6];
if(result3BC8920E9488421CBBA16D92ECF94CB2.ContainsKey(0))
ISpace["MFG_P2_ReimbursementDetailsId"].Value = result3BC8920E9488421CBBA16D92ECF94CB2[0];
if(result3BC8920E9488421CBBA16D92ECF94CB2.ContainsKey(1))
ISpace["MFG_P2_ReimbursementId"].Value = result3BC8920E9488421CBBA16D92ECF94CB2[1];
if(result3BC8920E9488421CBBA16D92ECF94CB2.ContainsKey(2))
ISpace["MFG_P2_BillNo"].Value = result3BC8920E9488421CBBA16D92ECF94CB2[2];
if(result3BC8920E9488421CBBA16D92ECF94CB2.ContainsKey(5))
ISpace["MFG_P2_ItemDescription"].Value = result3BC8920E9488421CBBA16D92ECF94CB2[5];
}
else{
ISpace["MFG_P2_BillDate"].Value = null;ISpace["MFG_P2_BillDocument"].Value = null;ISpace["MFG_P2_Amount"].Value = null;ISpace["MFG_P2_ReimbursementDetailsId"].Value = null;ISpace["MFG_P2_ReimbursementId"].Value = null;ISpace["MFG_P2_BillNo"].Value = null;ISpace["MFG_P2_ItemDescription"].Value = null;
}
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

var querySource8D078B34227340D4A2DD23A371ABE1A6 =GetQueryExpressionDataSource("8D078B34-2273-40D4-A2DD-23A371ABE1A6");

DataTable result8D078B34227340D4A2DD23A371ABE1A6=iSpace.SetGridDataSource(querySource8D078B34227340D4A2DD23A371ABE1A6, _objectFactory.GetGridRPP("ReimbursementBillDetails"),@"EXEC AddFormGridDataC9ACCA847AF347E79133D777BE46A656 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','C9ACCA84-7AF3-47E7-9133-D777BE46A656','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["MFG_P2_ReimbursementDetailsId"].Value + @"','" + ISpace["MFG_P2_ReimbursementId"].Value + @"','" + ISpace["MFG_P2_BillNo"].Value + @"','" + ISpace["MFG_P2_BillDate"].Value + @"'," + ISpace["MFG_P2_BillDocument"].Value + @",'" + ISpace["MFG_P2_ItemDescription"].Value + @"'," + ISpace["MFG_P2_Amount"].Value + @",'" + ISpace["growid"].Value + @"'");

iSpace.InsertGridBindDetails("ReimbursementBillDetails","11",querySource8D078B34227340D4A2DD23A371ABE1A6,"EXEC AddFormGridDataC9ACCA847AF347E79133D777BE46A656 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','C9ACCA84-7AF3-47E7-9133-D777BE46A656','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["MFG_P2_ReimbursementDetailsId"].Value + @"','" + ISpace["MFG_P2_ReimbursementId"].Value + @"','" + ISpace["MFG_P2_BillNo"].Value + @"','" + ISpace["MFG_P2_BillDate"].Value + @"'," + ISpace["MFG_P2_BillDocument"].Value + @",'" + ISpace["MFG_P2_ItemDescription"].Value + @"'," + ISpace["MFG_P2_Amount"].Value + @",'" + ISpace["growid"].Value + @"'",_objectFactory.GetGridRPP("ReimbursementBillDetails"));

base.WriteDebugInfo(@"var querySource8D078B34227340D4A2DD23A371ABE1A6 =GetQueryExpressionDataSource(""8D078B34-2273-40D4-A2DD-23A371ABE1A6"");DataTable result8D078B34227340D4A2DD23A371ABE1A6=iSpace.SetGridDataSource(querySource8D078B34227340D4A2DD23A371ABE1A6, _objectFactory.GetGridRPP(""ReimbursementBillDetails""),@""EXEC AddFormGridDataC9ACCA847AF347E79133D777BE46A656 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','C9ACCA84-7AF3-47E7-9133-D777BE46A656','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""MFG_P2_ReimbursementDetailsId""].Value + @""','"" + ISpace[""MFG_P2_ReimbursementId""].Value + @""','"" + ISpace[""MFG_P2_BillNo""].Value + @""','"" + ISpace[""MFG_P2_BillDate""].Value + @""',"" + ISpace[""MFG_P2_BillDocument""].Value + @"",'"" + ISpace[""MFG_P2_ItemDescription""].Value + @""',"" + ISpace[""MFG_P2_Amount""].Value + @"",'"" + ISpace[""growid""].Value + @""'"");iSpace.InsertGridBindDetails(""ReimbursementBillDetails"",""11"",querySource8D078B34227340D4A2DD23A371ABE1A6,""EXEC AddFormGridDataC9ACCA847AF347E79133D777BE46A656 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','C9ACCA84-7AF3-47E7-9133-D777BE46A656','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""MFG_P2_ReimbursementDetailsId""].Value + @""','"" + ISpace[""MFG_P2_ReimbursementId""].Value + @""','"" + ISpace[""MFG_P2_BillNo""].Value + @""','"" + ISpace[""MFG_P2_BillDate""].Value + @""',"" + ISpace[""MFG_P2_BillDocument""].Value + @"",'"" + ISpace[""MFG_P2_ItemDescription""].Value + @""',"" + ISpace[""MFG_P2_Amount""].Value + @"",'"" + ISpace[""growid""].Value + @""'"",_objectFactory.GetGridRPP(""ReimbursementBillDetails""));");
base.WriteDebugInfo(@"EXEC AddFormGridDataC9ACCA847AF347E79133D777BE46A656 '@@gv_InstanceId','@@gv_ProcessMapId','C9ACCA84-7AF3-47E7-9133-D777BE46A656','@@gv_ActivityMapId','#MFG_P2_ReimbursementDetailsId','#MFG_P2_ReimbursementId','#MFG_P2_BillNo','#MFG_P2_BillDate',#MFG_P2_BillDocument,'#MFG_P2_ItemDescription',#MFG_P2_Amount,'#growid'");


List<Triplet<string, short, short?>> resultC48E5BD17B2A4917979A69F487396125=acdataIspace01ABEB23E635437DA24F27342FB92C55.GetQueryExpressionBindings("C48E5BD1-7B2A-4917-979A-69F487396125");
iSpace.SetGridData(result8D078B34227340D4A2DD23A371ABE1A6,resultC48E5BD17B2A4917979A69F487396125,"ReimbursementBillDetails",ref ISpace);
iSpace.UpdateGridBindDetails("ReimbursementBillDetails",resultC48E5BD17B2A4917979A69F487396125);
}
else
{
base.WriteDebugInfo(@"else");

var querySource9B5B780E4C6E4FCEA2BDA3A4764A9120 =GetQueryExpressionDataSource("9B5B780E-4C6E-4FCE-A2BD-A3A4764A9120");

DataTable result9B5B780E4C6E4FCEA2BDA3A4764A9120=iSpace.SetGridDataSource(querySource9B5B780E4C6E4FCEA2BDA3A4764A9120, _objectFactory.GetGridRPP("ReimbursementBillDetails"),@"EXEC UpdateFormGridDataC9ACCA847AF347E79133D777BE46A656 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','C9ACCA84-7AF3-47E7-9133-D777BE46A656','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["MFG_P2_ReimbursementDetailsId"].Value + @"','" + ISpace["MFG_P2_ReimbursementId"].Value + @"','" + ISpace["MFG_P2_BillNo"].Value + @"','" + ISpace["MFG_P2_BillDate"].Value + @"'," + ISpace["MFG_P2_BillDocument"].Value + @",'" + ISpace["MFG_P2_ItemDescription"].Value + @"'," + ISpace["MFG_P2_Amount"].Value + @",'" + ISpace["growid"].Value + @"'");

iSpace.InsertGridBindDetails("ReimbursementBillDetails","11",querySource9B5B780E4C6E4FCEA2BDA3A4764A9120,"EXEC UpdateFormGridDataC9ACCA847AF347E79133D777BE46A656 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','C9ACCA84-7AF3-47E7-9133-D777BE46A656','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["MFG_P2_ReimbursementDetailsId"].Value + @"','" + ISpace["MFG_P2_ReimbursementId"].Value + @"','" + ISpace["MFG_P2_BillNo"].Value + @"','" + ISpace["MFG_P2_BillDate"].Value + @"'," + ISpace["MFG_P2_BillDocument"].Value + @",'" + ISpace["MFG_P2_ItemDescription"].Value + @"'," + ISpace["MFG_P2_Amount"].Value + @",'" + ISpace["growid"].Value + @"'",_objectFactory.GetGridRPP("ReimbursementBillDetails"));

base.WriteDebugInfo(@"var querySource9B5B780E4C6E4FCEA2BDA3A4764A9120 =GetQueryExpressionDataSource(""9B5B780E-4C6E-4FCE-A2BD-A3A4764A9120"");DataTable result9B5B780E4C6E4FCEA2BDA3A4764A9120=iSpace.SetGridDataSource(querySource9B5B780E4C6E4FCEA2BDA3A4764A9120, _objectFactory.GetGridRPP(""ReimbursementBillDetails""),@""EXEC UpdateFormGridDataC9ACCA847AF347E79133D777BE46A656 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','C9ACCA84-7AF3-47E7-9133-D777BE46A656','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""MFG_P2_ReimbursementDetailsId""].Value + @""','"" + ISpace[""MFG_P2_ReimbursementId""].Value + @""','"" + ISpace[""MFG_P2_BillNo""].Value + @""','"" + ISpace[""MFG_P2_BillDate""].Value + @""',"" + ISpace[""MFG_P2_BillDocument""].Value + @"",'"" + ISpace[""MFG_P2_ItemDescription""].Value + @""',"" + ISpace[""MFG_P2_Amount""].Value + @"",'"" + ISpace[""growid""].Value + @""'"");iSpace.InsertGridBindDetails(""ReimbursementBillDetails"",""11"",querySource9B5B780E4C6E4FCEA2BDA3A4764A9120,""EXEC UpdateFormGridDataC9ACCA847AF347E79133D777BE46A656 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','C9ACCA84-7AF3-47E7-9133-D777BE46A656','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""MFG_P2_ReimbursementDetailsId""].Value + @""','"" + ISpace[""MFG_P2_ReimbursementId""].Value + @""','"" + ISpace[""MFG_P2_BillNo""].Value + @""','"" + ISpace[""MFG_P2_BillDate""].Value + @""',"" + ISpace[""MFG_P2_BillDocument""].Value + @"",'"" + ISpace[""MFG_P2_ItemDescription""].Value + @""',"" + ISpace[""MFG_P2_Amount""].Value + @"",'"" + ISpace[""growid""].Value + @""'"",_objectFactory.GetGridRPP(""ReimbursementBillDetails""));");
base.WriteDebugInfo(@"EXEC UpdateFormGridDataC9ACCA847AF347E79133D777BE46A656 '@@gv_InstanceId','@@gv_ProcessMapId','C9ACCA84-7AF3-47E7-9133-D777BE46A656','@@gv_ActivityMapId','#MFG_P2_ReimbursementDetailsId','#MFG_P2_ReimbursementId','#MFG_P2_BillNo','#MFG_P2_BillDate',#MFG_P2_BillDocument,'#MFG_P2_ItemDescription',#MFG_P2_Amount,'#growid'");


List<Triplet<string, short, short?>> result9EA07CACF2274E83A5EE8C316E74D75C=acdataIspace01ABEB23E635437DA24F27342FB92C55.GetQueryExpressionBindings("9EA07CAC-F227-4E83-A5EE-8C316E74D75C");
iSpace.SetGridData(result9B5B780E4C6E4FCEA2BDA3A4764A9120,result9EA07CACF2274E83A5EE8C316E74D75C,"ReimbursementBillDetails",ref ISpace);
iSpace.UpdateGridBindDetails("ReimbursementBillDetails",result9EA07CACF2274E83A5EE8C316E74D75C);
}
object MG_P2_Amount=iSpace.Sum("[1D198218-D4AF-4E09-9A9D-119D03D0C3BA]","MG_P2_Amount","",ISpace["gv_instanceid"].Value);
ISpace["MF_P1_TotalAmount"].Value=Convert.ChangeType(MG_P2_Amount, MG_P2_Amount.GetType());;
base.WriteDebugInfo(@"object MG_P2_Amount=iSpace.Sum(""[1D198218-D4AF-4E09-9A9D-119D03D0C3BA]"",""MG_P2_Amount"","""",ISpace[""gv_instanceid""].Value);
ISpace[""MF_P1_TotalAmount""].Value=Convert.ChangeType(MG_P2_Amount, MG_P2_Amount.GetType());;");
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
if (_elementBase != null)  iSpace.SetLoopExpressionData("ReimbursementFundDetails","84AEB9E0-3009-4426-AB92-AAF06D2B42AF",_objectFactory.GetGridRPP("ReimbursementFundDetails"),_elementBase.GetGridLoopQuery("84AEB9E0-3009-4426-AB92-AAF06D2B42AF","ReimbursementFundDetails",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""ReimbursementFundDetails"",ref ISpace);

foreach(var gridChild in ISpace[""ReimbursementFundDetails""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
}
if(ISpace["growid"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""growid""].Value=="""")");

var querySourceCBB3928101F44B3AB89247A0222DAFBA =GetQueryExpressionDataSource("CBB39281-01F4-4B3A-B892-47A0222DAFBA");

DataTable resultCBB3928101F44B3AB89247A0222DAFBA=iSpace.SetGridDataSource(querySourceCBB3928101F44B3AB89247A0222DAFBA, _objectFactory.GetGridRPP("ReimbursementFundDetails"),@"EXEC AddFormGridDataD85301F7BAF94BE8A2B174E5CBB3D054 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','D85301F7-BAF9-4BE8-A2B1-74E5CBB3D054','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["MFG_P3_FundDetailsId"].Value + @"','" + ISpace["MFG_P3_ReimbursementId"].Value + @"','" + ISpace["MFG_P3_FundTypeId"].Value + @"','" + ISpace["MFG_P3_ProjectDetailsId"].Value + @"','" + ISpace["MFG_P3_BudgetHeadId"].Value + @"','" + ISpace["MFG_P3_Amount"].Value + @"','" + ISpace["growid"].Value + @"'");

iSpace.InsertGridBindDetails("ReimbursementFundDetails","11",querySourceCBB3928101F44B3AB89247A0222DAFBA,"EXEC AddFormGridDataD85301F7BAF94BE8A2B174E5CBB3D054 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','D85301F7-BAF9-4BE8-A2B1-74E5CBB3D054','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["MFG_P3_FundDetailsId"].Value + @"','" + ISpace["MFG_P3_ReimbursementId"].Value + @"','" + ISpace["MFG_P3_FundTypeId"].Value + @"','" + ISpace["MFG_P3_ProjectDetailsId"].Value + @"','" + ISpace["MFG_P3_BudgetHeadId"].Value + @"','" + ISpace["MFG_P3_Amount"].Value + @"','" + ISpace["growid"].Value + @"'",_objectFactory.GetGridRPP("ReimbursementFundDetails"));

base.WriteDebugInfo(@"var querySourceCBB3928101F44B3AB89247A0222DAFBA =GetQueryExpressionDataSource(""CBB39281-01F4-4B3A-B892-47A0222DAFBA"");DataTable resultCBB3928101F44B3AB89247A0222DAFBA=iSpace.SetGridDataSource(querySourceCBB3928101F44B3AB89247A0222DAFBA, _objectFactory.GetGridRPP(""ReimbursementFundDetails""),@""EXEC AddFormGridDataD85301F7BAF94BE8A2B174E5CBB3D054 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','D85301F7-BAF9-4BE8-A2B1-74E5CBB3D054','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""MFG_P3_FundDetailsId""].Value + @""','"" + ISpace[""MFG_P3_ReimbursementId""].Value + @""','"" + ISpace[""MFG_P3_FundTypeId""].Value + @""','"" + ISpace[""MFG_P3_ProjectDetailsId""].Value + @""','"" + ISpace[""MFG_P3_BudgetHeadId""].Value + @""','"" + ISpace[""MFG_P3_Amount""].Value + @""','"" + ISpace[""growid""].Value + @""'"");iSpace.InsertGridBindDetails(""ReimbursementFundDetails"",""11"",querySourceCBB3928101F44B3AB89247A0222DAFBA,""EXEC AddFormGridDataD85301F7BAF94BE8A2B174E5CBB3D054 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','D85301F7-BAF9-4BE8-A2B1-74E5CBB3D054','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""MFG_P3_FundDetailsId""].Value + @""','"" + ISpace[""MFG_P3_ReimbursementId""].Value + @""','"" + ISpace[""MFG_P3_FundTypeId""].Value + @""','"" + ISpace[""MFG_P3_ProjectDetailsId""].Value + @""','"" + ISpace[""MFG_P3_BudgetHeadId""].Value + @""','"" + ISpace[""MFG_P3_Amount""].Value + @""','"" + ISpace[""growid""].Value + @""'"",_objectFactory.GetGridRPP(""ReimbursementFundDetails""));");
base.WriteDebugInfo(@"EXEC AddFormGridDataD85301F7BAF94BE8A2B174E5CBB3D054 '@@gv_InstanceId','@@gv_ProcessMapId','D85301F7-BAF9-4BE8-A2B1-74E5CBB3D054','@@gv_ActivityMapId','#MFG_P3_FundDetailsId','#MFG_P3_ReimbursementId','#MFG_P3_FundTypeId','#MFG_P3_ProjectDetailsId','#MFG_P3_BudgetHeadId',#MFG_P3_Amount,'#growid'");


List<Triplet<string, short, short?>> result25A00CF73B354322B4DFFE24D90229BC=acdataIspace01ABEB23E635437DA24F27342FB92C55.GetQueryExpressionBindings("25A00CF7-3B35-4322-B4DF-FE24D90229BC");
iSpace.SetGridData(resultCBB3928101F44B3AB89247A0222DAFBA,result25A00CF73B354322B4DFFE24D90229BC,"ReimbursementFundDetails",ref ISpace);
iSpace.UpdateGridBindDetails("ReimbursementFundDetails",result25A00CF73B354322B4DFFE24D90229BC);
}
else
{
base.WriteDebugInfo(@"else");

var querySource334BDAE0A76B4B0F84BCAEF7F4F927FE =GetQueryExpressionDataSource("334BDAE0-A76B-4B0F-84BC-AEF7F4F927FE");

DataTable result334BDAE0A76B4B0F84BCAEF7F4F927FE=iSpace.SetGridDataSource(querySource334BDAE0A76B4B0F84BCAEF7F4F927FE, _objectFactory.GetGridRPP("ReimbursementFundDetails"),@"EXEC UpdateFormGridDataD85301F7BAF94BE8A2B174E5CBB3D054 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','D85301F7-BAF9-4BE8-A2B1-74E5CBB3D054','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["MFG_P3_FundDetailsId"].Value + @"','" + ISpace["MFG_P3_ReimbursementId"].Value + @"','" + ISpace["MFG_P3_FundTypeId"].Value + @"','" + ISpace["MFG_P3_ProjectDetailsId"].Value + @"','" + ISpace["MFG_P3_BudgetHeadId"].Value + @"'," + ISpace["MFG_P3_Amount"].Value + @",'" + ISpace["growid"].Value + @"'");

iSpace.InsertGridBindDetails("ReimbursementFundDetails","11",querySource334BDAE0A76B4B0F84BCAEF7F4F927FE,"EXEC UpdateFormGridDataD85301F7BAF94BE8A2B174E5CBB3D054 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','D85301F7-BAF9-4BE8-A2B1-74E5CBB3D054','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["MFG_P3_FundDetailsId"].Value + @"','" + ISpace["MFG_P3_ReimbursementId"].Value + @"','" + ISpace["MFG_P3_FundTypeId"].Value + @"','" + ISpace["MFG_P3_ProjectDetailsId"].Value + @"','" + ISpace["MFG_P3_BudgetHeadId"].Value + @"'," + ISpace["MFG_P3_Amount"].Value + @",'" + ISpace["growid"].Value + @"'",_objectFactory.GetGridRPP("ReimbursementFundDetails"));

base.WriteDebugInfo(@"var querySource334BDAE0A76B4B0F84BCAEF7F4F927FE =GetQueryExpressionDataSource(""334BDAE0-A76B-4B0F-84BC-AEF7F4F927FE"");DataTable result334BDAE0A76B4B0F84BCAEF7F4F927FE=iSpace.SetGridDataSource(querySource334BDAE0A76B4B0F84BCAEF7F4F927FE, _objectFactory.GetGridRPP(""ReimbursementFundDetails""),@""EXEC UpdateFormGridDataD85301F7BAF94BE8A2B174E5CBB3D054 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','D85301F7-BAF9-4BE8-A2B1-74E5CBB3D054','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""MFG_P3_FundDetailsId""].Value + @""','"" + ISpace[""MFG_P3_ReimbursementId""].Value + @""','"" + ISpace[""MFG_P3_FundTypeId""].Value + @""','"" + ISpace[""MFG_P3_ProjectDetailsId""].Value + @""','"" + ISpace[""MFG_P3_BudgetHeadId""].Value + @""',"" + ISpace[""MFG_P3_Amount""].Value + @"",'"" + ISpace[""growid""].Value + @""'"");iSpace.InsertGridBindDetails(""ReimbursementFundDetails"",""11"",querySource334BDAE0A76B4B0F84BCAEF7F4F927FE,""EXEC UpdateFormGridDataD85301F7BAF94BE8A2B174E5CBB3D054 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','D85301F7-BAF9-4BE8-A2B1-74E5CBB3D054','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""MFG_P3_FundDetailsId""].Value + @""','"" + ISpace[""MFG_P3_ReimbursementId""].Value + @""','"" + ISpace[""MFG_P3_FundTypeId""].Value + @""','"" + ISpace[""MFG_P3_ProjectDetailsId""].Value + @""','"" + ISpace[""MFG_P3_BudgetHeadId""].Value + @""',"" + ISpace[""MFG_P3_Amount""].Value + @"",'"" + ISpace[""growid""].Value + @""'"",_objectFactory.GetGridRPP(""ReimbursementFundDetails""));");
base.WriteDebugInfo(@"EXEC UpdateFormGridDataD85301F7BAF94BE8A2B174E5CBB3D054 '@@gv_InstanceId','@@gv_ProcessMapId','D85301F7-BAF9-4BE8-A2B1-74E5CBB3D054','@@gv_ActivityMapId','#MFG_P3_FundDetailsId','#MFG_P3_ReimbursementId','#MFG_P3_FundTypeId','#MFG_P3_ProjectDetailsId','#MFG_P3_BudgetHeadId',#MFG_P3_Amount,'#growid'");


List<Triplet<string, short, short?>> resultEFFC55B685564D91AE91384F68B422FF=acdataIspace01ABEB23E635437DA24F27342FB92C55.GetQueryExpressionBindings("EFFC55B6-8556-4D91-AE91-384F68B422FF");
iSpace.SetGridData(result334BDAE0A76B4B0F84BCAEF7F4F927FE,resultEFFC55B685564D91AE91384F68B422FF,"ReimbursementFundDetails",ref ISpace);
iSpace.UpdateGridBindDetails("ReimbursementFundDetails",resultEFFC55B685564D91AE91384F68B422FF);
}
base.WriteDebugInfo(@"#ReimbursementFundDetails[Rows]");
iSpace.GetLoopExpressionData("ReimbursementFundDetails",ref ISpace);

foreach(var gridChild in ISpace["ReimbursementFundDetails"].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 



ISpace["MG_P3_PackageProcessMapId"].Value=ISpace["M_PackageProcessMapId"].Value;
base.WriteDebugInfo(@"

ISpace[""MG_P3_PackageProcessMapId""].Value=ISpace[""M_PackageProcessMapId""].Value;");


ISpace["MG_P3_EmployeeBaicInfoId"].Value=ISpace["UC_EmployeeBaicInfoId"].Value;
base.WriteDebugInfo(@"

ISpace[""MG_P3_EmployeeBaicInfoId""].Value=ISpace[""UC_EmployeeBaicInfoId""].Value;");
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("ReimbursementFundDetails","84AEB9E0-3009-4426-AB92-AAF06D2B42AF",_objectFactory.GetGridRPP("ReimbursementFundDetails"),_elementBase.GetGridLoopQuery("84AEB9E0-3009-4426-AB92-AAF06D2B42AF","ReimbursementFundDetails",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""ReimbursementFundDetails"",ref ISpace);

foreach(var gridChild in ISpace[""ReimbursementFundDetails""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
object MG_P3_Amount=iSpace.Sum("[84AEB9E0-3009-4426-AB92-AAF06D2B42AF]","MG_P3_Amount","",ISpace["gv_instanceid"].Value);
ISpace["MFG_P3_OverallAmount"].Value=Convert.ChangeType(MG_P3_Amount, MG_P3_Amount.GetType());;
base.WriteDebugInfo(@"object MG_P3_Amount=iSpace.Sum(""[84AEB9E0-3009-4426-AB92-AAF06D2B42AF]"",""MG_P3_Amount"","""",ISpace[""gv_instanceid""].Value);
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
private void SubscribeElementEvents_submitform (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"SubmitForm-OnClick");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC UpsertActivityTrailLogDetails '@@gv_TenantId','#M_InstanceId','@@gv_ActivityName','#MF_P1_Remarks','@@gv_UserName','#M_SourceActivityMapId','#SetDestinationTo','@@gv_UserId','#M_IsSourceStep'");

var querySourcebefdd5b207e912dc5d3682026e5e2134 =GetQueryExpressionDataSource("befdd5b2-07e9-12dc-5d36-82026e5e2134");
Dictionary<short,object> resultbefdd5b207e912dc5d3682026e5e2134=iSpace.ExecuteQuery(querySourcebefdd5b207e912dc5d3682026e5e2134,@"EXEC UpsertActivityTrailLogDetails '" + ISpace["gv_tenantid"].Value + @"','" + ISpace["M_InstanceId"].Value + @"','" + ISpace["gv_activityname"].Value + @"','" + ISpace["MF_P1_Remarks"].Value + @"','" + ISpace["gv_username"].Value + @"','" + ISpace["M_SourceActivityMapId"].Value + @"','" + ISpace["SetDestinationTo"].Value + @"','" + ISpace["gv_userid"].Value + @"','" + ISpace["M_IsSourceStep"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourcebefdd5b207e912dc5d3682026e5e2134 =GetQueryExpressionDataSource(""befdd5b2-07e9-12dc-5d36-82026e5e2134"");Dictionary<short,object> resultbefdd5b207e912dc5d3682026e5e2134=iSpace.ExecuteQuery(querySourcebefdd5b207e912dc5d3682026e5e2134,@""EXEC UpsertActivityTrailLogDetails '"" + ISpace[""gv_tenantid""].Value + @""','"" + ISpace[""M_InstanceId""].Value + @""','"" + ISpace[""gv_activityname""].Value + @""','"" + ISpace[""MF_P1_Remarks""].Value + @""','"" + ISpace[""gv_username""].Value + @""','"" + ISpace[""M_SourceActivityMapId""].Value + @""','"" + ISpace[""SetDestinationTo""].Value + @""','"" + ISpace[""gv_userid""].Value + @""','"" + ISpace[""M_IsSourceStep""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultbefdd5b207e912dc5d3682026e5e2134!=null) && (resultbefdd5b207e912dc5d3682026e5e2134.Count!=0))
{
if(resultbefdd5b207e912dc5d3682026e5e2134.ContainsKey(0))
ISpace["ExecutionMessage"].Value = resultbefdd5b207e912dc5d3682026e5e2134[0];
}
else{
ISpace["ExecutionMessage"].Value = null;
}
}
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
ISpace["MF_P1_ApplicationStatus"].Value="A";
base.WriteDebugInfo(@"ISpace[""MF_P1_ApplicationStatus""].Value=""A"";");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC UpsertProjectReimbursement '#MF_P1_ReimbursementId','#UC_EmployeeBaicInfoId','#MF_P1_TotalAmount','@@gv_UserId','#MF_P1_ApplicationStatus','#M_ReimbursementType','#M_Classification','#M_SubClassication','@@gv_UserId'");

var querySourced58dc3c8687f1ebcd4754068de464713 =GetQueryExpressionDataSource("d58dc3c8-687f-1ebc-d475-4068de464713");
Dictionary<short,object> resultd58dc3c8687f1ebcd4754068de464713=iSpace.ExecuteQuery(querySourced58dc3c8687f1ebcd4754068de464713,@"EXEC UpsertProjectReimbursement '" + ISpace["MF_P1_ReimbursementId"].Value + @"','" + ISpace["UC_EmployeeBaicInfoId"].Value + @"','" + ISpace["MF_P1_TotalAmount"].Value + @"','" + ISpace["gv_userid"].Value + @"','" + ISpace["MF_P1_ApplicationStatus"].Value + @"','" + ISpace["M_ReimbursementType"].Value + @"','" + ISpace["M_Classification"].Value + @"','" + ISpace["M_SubClassication"].Value + @"','" + ISpace["gv_userid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourced58dc3c8687f1ebcd4754068de464713 =GetQueryExpressionDataSource(""d58dc3c8-687f-1ebc-d475-4068de464713"");Dictionary<short,object> resultd58dc3c8687f1ebcd4754068de464713=iSpace.ExecuteQuery(querySourced58dc3c8687f1ebcd4754068de464713,@""EXEC UpsertProjectReimbursement '"" + ISpace[""MF_P1_ReimbursementId""].Value + @""','"" + ISpace[""UC_EmployeeBaicInfoId""].Value + @""','"" + ISpace[""MF_P1_TotalAmount""].Value + @""','"" + ISpace[""gv_userid""].Value + @""','"" + ISpace[""MF_P1_ApplicationStatus""].Value + @""','"" + ISpace[""M_ReimbursementType""].Value + @""','"" + ISpace[""M_Classification""].Value + @""','"" + ISpace[""M_SubClassication""].Value + @""','"" + ISpace[""gv_userid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultd58dc3c8687f1ebcd4754068de464713!=null) && (resultd58dc3c8687f1ebcd4754068de464713.Count!=0))
{
if(resultd58dc3c8687f1ebcd4754068de464713.ContainsKey(0))
ISpace["ExecutionMessage"].Value = resultd58dc3c8687f1ebcd4754068de464713[0];
}
else{
ISpace["ExecutionMessage"].Value = null;
}
base.WriteDebugInfo(@"EXEC UpsertProjectReimbursementFundDetails '#MG_P3_FundDetailsId','#MF_P1_ReimbursementId','#MG_P3_FundTypeId','#MG_P3_ProjectDetailsId','#MG_P3_BudgetHeadId','#MG_P3_Amount'");

var querySource478236c45c793773d35402c74092c916 =GetQueryExpressionDataSource("478236c4-5c79-3773-d354-02c74092c916");
Dictionary<short,object> result478236c45c793773d35402c74092c916=iSpace.ExecuteQuery(querySource478236c45c793773d35402c74092c916,@"EXEC UpsertProjectReimbursementFundDetails '" + ISpace["MG_P3_FundDetailsId"].Value + @"','" + ISpace["MF_P1_ReimbursementId"].Value + @"','" + ISpace["MG_P3_FundTypeId"].Value + @"','" + ISpace["MG_P3_ProjectDetailsId"].Value + @"','" + ISpace["MG_P3_BudgetHeadId"].Value + @"','" + ISpace["MG_P3_Amount"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource478236c45c793773d35402c74092c916 =GetQueryExpressionDataSource(""478236c4-5c79-3773-d354-02c74092c916"");Dictionary<short,object> result478236c45c793773d35402c74092c916=iSpace.ExecuteQuery(querySource478236c45c793773d35402c74092c916,@""EXEC UpsertProjectReimbursementFundDetails '"" + ISpace[""MG_P3_FundDetailsId""].Value + @""','"" + ISpace[""MF_P1_ReimbursementId""].Value + @""','"" + ISpace[""MG_P3_FundTypeId""].Value + @""','"" + ISpace[""MG_P3_ProjectDetailsId""].Value + @""','"" + ISpace[""MG_P3_BudgetHeadId""].Value + @""','"" + ISpace[""MG_P3_Amount""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result478236c45c793773d35402c74092c916!=null) && (result478236c45c793773d35402c74092c916.Count!=0))
{
if(result478236c45c793773d35402c74092c916.ContainsKey(0))
ISpace["ExecutionMessage"].Value = result478236c45c793773d35402c74092c916[0];
}
else{
ISpace["ExecutionMessage"].Value = null;
}
base.WriteDebugInfo(@"EXEC UpsertProjectReimbursementBillDetails '#MG_P2_ReimbursementDetailsId','#MF_P1_ReimbursementId','#MG_P2_BillNo','#MG_P2_BillDate',NULL,'#MG_P2_ItemDescription','#MG_P2_Amount'");

var querySource0ac6af4e84d7e8d409946108bb08331c =GetQueryExpressionDataSource("0ac6af4e-84d7-e8d4-0994-6108bb08331c");
Dictionary<short,object> result0ac6af4e84d7e8d409946108bb08331c=iSpace.ExecuteQuery(querySource0ac6af4e84d7e8d409946108bb08331c,@"EXEC UpsertProjectReimbursementBillDetails '" + ISpace["MG_P2_ReimbursementDetailsId"].Value + @"','" + ISpace["MF_P1_ReimbursementId"].Value + @"','" + ISpace["MG_P2_BillNo"].Value + @"','" + ISpace["MG_P2_BillDate"].Value + @"',NULL,'" + ISpace["MG_P2_ItemDescription"].Value + @"','" + ISpace["MG_P2_Amount"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource0ac6af4e84d7e8d409946108bb08331c =GetQueryExpressionDataSource(""0ac6af4e-84d7-e8d4-0994-6108bb08331c"");Dictionary<short,object> result0ac6af4e84d7e8d409946108bb08331c=iSpace.ExecuteQuery(querySource0ac6af4e84d7e8d409946108bb08331c,@""EXEC UpsertProjectReimbursementBillDetails '"" + ISpace[""MG_P2_ReimbursementDetailsId""].Value + @""','"" + ISpace[""MF_P1_ReimbursementId""].Value + @""','"" + ISpace[""MG_P2_BillNo""].Value + @""','"" + ISpace[""MG_P2_BillDate""].Value + @""',NULL,'"" + ISpace[""MG_P2_ItemDescription""].Value + @""','"" + ISpace[""MG_P2_Amount""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result0ac6af4e84d7e8d409946108bb08331c!=null) && (result0ac6af4e84d7e8d409946108bb08331c.Count!=0))
{
if(result0ac6af4e84d7e8d409946108bb08331c.ContainsKey(0))
ISpace["ExecutionMessage"].Value = result0ac6af4e84d7e8d409946108bb08331c[0];
}
else{
ISpace["ExecutionMessage"].Value = null;
}
base.WriteDebugInfo(@"EXEC UpsertDocumentDetails '#M_DocumentDetailsId','#M_InstanceId','#M_PackageProcessMapId','#M_DocumentName','#M_UploadDcoument',' @@gv_UserId'");

var querySource17adfd2bbf7aa7968851003732efc9c7 =GetQueryExpressionDataSource("17adfd2b-bf7a-a796-8851-003732efc9c7");
Dictionary<short,object> result17adfd2bbf7aa7968851003732efc9c7=iSpace.ExecuteQuery(querySource17adfd2bbf7aa7968851003732efc9c7,@"EXEC UpsertDocumentDetails '" + ISpace["M_DocumentDetailsId"].Value + @"','" + ISpace["M_InstanceId"].Value + @"','" + ISpace["M_PackageProcessMapId"].Value + @"','" + ISpace["M_DocumentName"].Value + @"','" + ISpace["M_UploadDcoument"].Value + @"',' " + ISpace["gv_userid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource17adfd2bbf7aa7968851003732efc9c7 =GetQueryExpressionDataSource(""17adfd2b-bf7a-a796-8851-003732efc9c7"");Dictionary<short,object> result17adfd2bbf7aa7968851003732efc9c7=iSpace.ExecuteQuery(querySource17adfd2bbf7aa7968851003732efc9c7,@""EXEC UpsertDocumentDetails '"" + ISpace[""M_DocumentDetailsId""].Value + @""','"" + ISpace[""M_InstanceId""].Value + @""','"" + ISpace[""M_PackageProcessMapId""].Value + @""','"" + ISpace[""M_DocumentName""].Value + @""','"" + ISpace[""M_UploadDcoument""].Value + @""',' "" + ISpace[""gv_userid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result17adfd2bbf7aa7968851003732efc9c7!=null) && (result17adfd2bbf7aa7968851003732efc9c7.Count!=0))
{
if(result17adfd2bbf7aa7968851003732efc9c7.ContainsKey(0))
ISpace["ExecutionMessage"].Value = result17adfd2bbf7aa7968851003732efc9c7[0];
}
else{
ISpace["ExecutionMessage"].Value = null;
}
}
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
base.WriteDebugInfo(@"EXEC [UpsertProjectBudgetDetails] 6,'#MG_P3_ProjectDetailsId','','#MG_P3_Amount','#MG_P3_BudgetHeadId',1,'#MG_P3_FundTypeId'");

var querySourceBA4985A9C4A24DC6BBD1661F0431909A =GetQueryExpressionDataSource("BA4985A9-C4A2-4DC6-BBD1-661F0431909A");
Dictionary<short,object> resultBA4985A9C4A24DC6BBD1661F0431909A=iSpace.ExecuteQuery(querySourceBA4985A9C4A24DC6BBD1661F0431909A,@"EXEC [UpsertProjectBudgetDetails] 6,'" + ISpace["MG_P3_ProjectDetailsId"].Value + @"','','" + ISpace["MG_P3_Amount"].Value + @"','" + ISpace["MG_P3_BudgetHeadId"].Value + @"',1,'" + ISpace["MG_P3_FundTypeId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceBA4985A9C4A24DC6BBD1661F0431909A =GetQueryExpressionDataSource(""BA4985A9-C4A2-4DC6-BBD1-661F0431909A"");Dictionary<short,object> resultBA4985A9C4A24DC6BBD1661F0431909A=iSpace.ExecuteQuery(querySourceBA4985A9C4A24DC6BBD1661F0431909A,@""EXEC [UpsertProjectBudgetDetails] 6,'"" + ISpace[""MG_P3_ProjectDetailsId""].Value + @""','','"" + ISpace[""MG_P3_Amount""].Value + @""','"" + ISpace[""MG_P3_BudgetHeadId""].Value + @""',1,'"" + ISpace[""MG_P3_FundTypeId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultBA4985A9C4A24DC6BBD1661F0431909A!=null) && (resultBA4985A9C4A24DC6BBD1661F0431909A.Count!=0))
{
if(resultBA4985A9C4A24DC6BBD1661F0431909A.ContainsKey(0))
ISpace["M_UpdateCount"].Value = resultBA4985A9C4A24DC6BBD1661F0431909A[0];
}
else{
ISpace["M_UpdateCount"].Value = null;
}
}
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("ReimbursementFundDetails","84AEB9E0-3009-4426-AB92-AAF06D2B42AF",_objectFactory.GetGridRPP("ReimbursementFundDetails"),_elementBase.GetGridLoopQuery("84AEB9E0-3009-4426-AB92-AAF06D2B42AF","ReimbursementFundDetails",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""ReimbursementFundDetails"",ref ISpace);

foreach(var gridChild in ISpace[""ReimbursementFundDetails""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
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
base.WriteDebugInfo(@"EXEC UpsertUserRequestsUpdation '#M_InstanceId','#SetDestinationTo','#M_Stage','#M_Status','@@gv_UserId','#M_RequestId'");

var querySource87cbcf911fba16fd3029f8855a072138 =GetQueryExpressionDataSource("87cbcf91-1fba-16fd-3029-f8855a072138");
Dictionary<short,object> result87cbcf911fba16fd3029f8855a072138=iSpace.ExecuteQuery(querySource87cbcf911fba16fd3029f8855a072138,@"EXEC UpsertUserRequestsUpdation '" + ISpace["M_InstanceId"].Value + @"','" + ISpace["SetDestinationTo"].Value + @"','" + ISpace["M_Stage"].Value + @"','" + ISpace["M_Status"].Value + @"','" + ISpace["gv_userid"].Value + @"','" + ISpace["M_RequestId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource87cbcf911fba16fd3029f8855a072138 =GetQueryExpressionDataSource(""87cbcf91-1fba-16fd-3029-f8855a072138"");Dictionary<short,object> result87cbcf911fba16fd3029f8855a072138=iSpace.ExecuteQuery(querySource87cbcf911fba16fd3029f8855a072138,@""EXEC UpsertUserRequestsUpdation '"" + ISpace[""M_InstanceId""].Value + @""','"" + ISpace[""SetDestinationTo""].Value + @""','"" + ISpace[""M_Stage""].Value + @""','"" + ISpace[""M_Status""].Value + @""','"" + ISpace[""gv_userid""].Value + @""','"" + ISpace[""M_RequestId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result87cbcf911fba16fd3029f8855a072138!=null) && (result87cbcf911fba16fd3029f8855a072138.Count!=0))
{
if(result87cbcf911fba16fd3029f8855a072138.ContainsKey(0))
ISpace["ExecutionMessage"].Value = result87cbcf911fba16fd3029f8855a072138[0];
}
else{
ISpace["ExecutionMessage"].Value = null;
}
ISpace["Message"].Value=@"Submitted Successfully";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Submitted Successfully"";");
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
base.WriteDebugInfo(@"EXEC LoadFormGridDataD85301F7BAF94BE8A2B174E5CBB3D054 '@@gv_InstanceId','@@gv_ProcessMapId','D85301F7-BAF9-4BE8-A2B1-74E5CBB3D054','@@gv_ActivityMapId','#growid'");

var querySource1F49FB0DA84D47A58942368F58A2D97A =GetQueryExpressionDataSource("1F49FB0D-A84D-47A5-8942-368F58A2D97A");
Dictionary<short,object> result1F49FB0DA84D47A58942368F58A2D97A=iSpace.ExecuteQuery(querySource1F49FB0DA84D47A58942368F58A2D97A,@"EXEC LoadFormGridDataD85301F7BAF94BE8A2B174E5CBB3D054 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','D85301F7-BAF9-4BE8-A2B1-74E5CBB3D054','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["growid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource1F49FB0DA84D47A58942368F58A2D97A =GetQueryExpressionDataSource(""1F49FB0D-A84D-47A5-8942-368F58A2D97A"");Dictionary<short,object> result1F49FB0DA84D47A58942368F58A2D97A=iSpace.ExecuteQuery(querySource1F49FB0DA84D47A58942368F58A2D97A,@""EXEC LoadFormGridDataD85301F7BAF94BE8A2B174E5CBB3D054 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','D85301F7-BAF9-4BE8-A2B1-74E5CBB3D054','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""growid""].Value + @""'"",false);");
base.WriteDebugInfo(@"EXEC LoadFormGridDataD85301F7BAF94BE8A2B174E5CBB3D054 '@@gv_InstanceId','@@gv_ProcessMapId','D85301F7-BAF9-4BE8-A2B1-74E5CBB3D054','@@gv_ActivityMapId','#growid'");

if((result1F49FB0DA84D47A58942368F58A2D97A!=null) && (result1F49FB0DA84D47A58942368F58A2D97A.Count!=0))
{
if(result1F49FB0DA84D47A58942368F58A2D97A.ContainsKey(4))
ISpace["MFG_P3_BudgetHeadId"].Value = result1F49FB0DA84D47A58942368F58A2D97A[4];
if(result1F49FB0DA84D47A58942368F58A2D97A.ContainsKey(3))
ISpace["MFG_P3_ProjectDetailsId"].Value = result1F49FB0DA84D47A58942368F58A2D97A[3];
if(result1F49FB0DA84D47A58942368F58A2D97A.ContainsKey(2))
ISpace["MFG_P3_FundTypeId"].Value = result1F49FB0DA84D47A58942368F58A2D97A[2];
if(result1F49FB0DA84D47A58942368F58A2D97A.ContainsKey(5))
ISpace["MFG_P3_Amount"].Value = result1F49FB0DA84D47A58942368F58A2D97A[5];
if(result1F49FB0DA84D47A58942368F58A2D97A.ContainsKey(1))
ISpace["MFG_P3_ReimbursementId"].Value = result1F49FB0DA84D47A58942368F58A2D97A[1];
if(result1F49FB0DA84D47A58942368F58A2D97A.ContainsKey(0))
ISpace["MFG_P3_FundDetailsId"].Value = result1F49FB0DA84D47A58942368F58A2D97A[0];
}
else{
ISpace["MFG_P3_BudgetHeadId"].Value = null;ISpace["MFG_P3_ProjectDetailsId"].Value = null;ISpace["MFG_P3_FundTypeId"].Value = null;ISpace["MFG_P3_Amount"].Value = null;ISpace["MFG_P3_ReimbursementId"].Value = null;ISpace["MFG_P3_FundDetailsId"].Value = null;
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_m_unlock (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"M_Unlock-OnClick");
ISpace.ExecuteInstanceCommand("Cancel");
base.WriteDebugInfo(@"ISpace.ExecuteInstanceCommand(""Cancel"");");
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
base.WriteDebugInfo(@"Exec GetStageStatus 1,'','','#M_MoveToValue','#M_SourceActivityMapId'");

var querySource959A027E58AA471DADF1501D54E16A1B =GetQueryExpressionDataSource("959A027E-58AA-471D-ADF1-501D54E16A1B");
Dictionary<short,object> result959A027E58AA471DADF1501D54E16A1B=iSpace.ExecuteQuery(querySource959A027E58AA471DADF1501D54E16A1B,@"Exec GetStageStatus 1,'','','" + ISpace["M_MoveToValue"].Value + @"','" + ISpace["M_SourceActivityMapId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource959A027E58AA471DADF1501D54E16A1B =GetQueryExpressionDataSource(""959A027E-58AA-471D-ADF1-501D54E16A1B"");Dictionary<short,object> result959A027E58AA471DADF1501D54E16A1B=iSpace.ExecuteQuery(querySource959A027E58AA471DADF1501D54E16A1B,@""Exec GetStageStatus 1,'','','"" + ISpace[""M_MoveToValue""].Value + @""','"" + ISpace[""M_SourceActivityMapId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result959A027E58AA471DADF1501D54E16A1B!=null) && (result959A027E58AA471DADF1501D54E16A1B.Count!=0))
{
if(result959A027E58AA471DADF1501D54E16A1B.ContainsKey(1))
ISpace["M_RemarksMandatory"].Value = result959A027E58AA471DADF1501D54E16A1B[1];
if(result959A027E58AA471DADF1501D54E16A1B.ContainsKey(5))
ISpace["M_IsflowReturned"].Value = result959A027E58AA471DADF1501D54E16A1B[5];
if(result959A027E58AA471DADF1501D54E16A1B.ContainsKey(6))
ISpace["M_IsCancelReject"].Value = result959A027E58AA471DADF1501D54E16A1B[6];
if(result959A027E58AA471DADF1501D54E16A1B.ContainsKey(4))
ISpace["M_FieldMandatory"].Value = result959A027E58AA471DADF1501D54E16A1B[4];
if(result959A027E58AA471DADF1501D54E16A1B.ContainsKey(3))
ISpace["M_SaveDomainData"].Value = result959A027E58AA471DADF1501D54E16A1B[3];
if(result959A027E58AA471DADF1501D54E16A1B.ContainsKey(7))
ISpace["M_Stage"].Value = result959A027E58AA471DADF1501D54E16A1B[7];
if(result959A027E58AA471DADF1501D54E16A1B.ContainsKey(0))
ISpace["M_NextStage"].Value = result959A027E58AA471DADF1501D54E16A1B[0];
if(result959A027E58AA471DADF1501D54E16A1B.ContainsKey(2))
ISpace["MF_P1_Remarks"].Value = result959A027E58AA471DADF1501D54E16A1B[2];
}
else{
ISpace["M_RemarksMandatory"].Value = null;ISpace["M_IsflowReturned"].Value = null;ISpace["M_IsCancelReject"].Value = null;ISpace["M_FieldMandatory"].Value = null;ISpace["M_SaveDomainData"].Value = null;ISpace["M_Stage"].Value = null;ISpace["M_NextStage"].Value = null;ISpace["MF_P1_Remarks"].Value = null;
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
		if(elementName.ToLower().Equals("edit_reimbursementbilldetails"))
{
			SubscribeElementEvents_edit_reimbursementbilldetails(ref dfsParam);
}
		if(elementName.ToLower().Equals("save_reimbursementbilldetails"))
{
			SubscribeElementEvents_save_reimbursementbilldetails(ref dfsParam);
}
		if(elementName.ToLower().Equals("save_reimbursementfunddetails"))
{
			SubscribeElementEvents_save_reimbursementfunddetails(ref dfsParam);
}
		if(elementName.ToLower().Equals("submitform"))
{
			SubscribeElementEvents_submitform(ref dfsParam);
}
		if(elementName.ToLower().Equals("edit_reimbursementfunddetails"))
{
			SubscribeElementEvents_edit_reimbursementfunddetails(ref dfsParam);
}
		if(elementName.ToLower().Equals("m_unlock"))
{
			SubscribeElementEvents_m_unlock(ref dfsParam);
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
public class ISpace89D38028FA534F9E89EA42C506E8E381 : VirtualForm
{
IISpace iSpace = new ISpace();
AcDataISpace89D38028FA534F9E89EA42C506E8E381 acdataIspace89D38028FA534F9E89EA42C506E8E381=new AcDataISpace89D38028FA534F9E89EA42C506E8E381();
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

var querySource820D767A20CC4BA1AADCA484B0BFBEFA =GetQueryExpressionDataSource("820D767A-20CC-4BA1-AADC-A484B0BFBEFA");

DataTable result820D767A20CC4BA1AADCA484B0BFBEFA=iSpace.SetGridDataSource(querySource820D767A20CC4BA1AADCA484B0BFBEFA, _objectFactory.GetGridRPP("MG_RemarksDetails"),@"EXEC GetRemarks '" + ISpace["M_InstanceId"].Value + @"'");

iSpace.InsertGridBindDetails("MG_RemarksDetails","11",querySource820D767A20CC4BA1AADCA484B0BFBEFA,"EXEC GetRemarks '" + ISpace["M_InstanceId"].Value + @"'",_objectFactory.GetGridRPP("MG_RemarksDetails"));

base.WriteDebugInfo(@"var querySource820D767A20CC4BA1AADCA484B0BFBEFA =GetQueryExpressionDataSource(""820D767A-20CC-4BA1-AADC-A484B0BFBEFA"");DataTable result820D767A20CC4BA1AADCA484B0BFBEFA=iSpace.SetGridDataSource(querySource820D767A20CC4BA1AADCA484B0BFBEFA, _objectFactory.GetGridRPP(""MG_RemarksDetails""),@""EXEC GetRemarks '"" + ISpace[""M_InstanceId""].Value + @""'"");iSpace.InsertGridBindDetails(""MG_RemarksDetails"",""11"",querySource820D767A20CC4BA1AADCA484B0BFBEFA,""EXEC GetRemarks '"" + ISpace[""M_InstanceId""].Value + @""'"",_objectFactory.GetGridRPP(""MG_RemarksDetails""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> resultE57D76A324374EAF8C530F41C6AF052C=acdataIspace89D38028FA534F9E89EA42C506E8E381.GetQueryExpressionBindings("E57D76A3-2437-4EAF-8C53-0F41C6AF052C");
iSpace.SetGridData(result820D767A20CC4BA1AADCA484B0BFBEFA,resultE57D76A324374EAF8C530F41C6AF052C,"MG_RemarksDetails",ref ISpace);
iSpace.UpdateGridBindDetails("MG_RemarksDetails",resultE57D76A324374EAF8C530F41C6AF052C);
ISpace["MFG_P3_BudgetHeadId"].Visible="false";ISpace["MFG_P3_ProjectDetailsId"].Visible="false";ISpace["MFG_P3_Amount"].Visible="false";
base.WriteDebugInfo(@"ISpace[""MFG_P3_BudgetHeadId""].Visible=""false"";ISpace[""MFG_P3_ProjectDetailsId""].Visible=""false"";ISpace[""MFG_P3_Amount""].Visible=""false"";");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["MFG_P2_ItemDescription"].Visible="false";ISpace["MFG_P2_BillDocument"].Visible="false";ISpace["MFG_P2_ReimbursementId"].Visible="false";ISpace["MFG_P2_BillNo"].Visible="false";ISpace["MFG_P3_ReimbursementId"].Visible="false";ISpace["MF_P1_TotalAmount"].Visible="true";ISpace["MF_P1_ApplicationStatus"].Visible="false";ISpace["MF_P1_Initiatedon"].Visible="false";ISpace["MFG_P2_Amount"].Visible="false";ISpace["MF_P1_ReimbursementId"].Visible="false";ISpace["MFG_P2_ReimbursementDetailsId"].Visible="false";ISpace["MFG_P3_BudgetHeadId"].Visible="false";ISpace["MF_P1_InitatedBy"].Visible="false";ISpace["MFG_P3_ProjectDetailsId"].Visible="false";ISpace["MFG_P3_FundTypeId"].Visible="false";ISpace["MFG_P3_FundDetailsId"].Visible="false";ISpace["MFG_P3_Amount"].Visible="false";ISpace["MF_P1_UpdatedBy"].Visible="false";ISpace["MF_P1_UpdatedOn"].Visible="false";ISpace["MFG_P2_BillDate"].Visible="false";ISpace["MF_P1_EmployeeBasicInfoId"].Visible="false";
base.WriteDebugInfo(@"ISpace[""MFG_P2_ItemDescription""].Visible=""false"";ISpace[""MFG_P2_BillDocument""].Visible=""false"";ISpace[""MFG_P2_ReimbursementId""].Visible=""false"";ISpace[""MFG_P2_BillNo""].Visible=""false"";ISpace[""MFG_P3_ReimbursementId""].Visible=""false"";ISpace[""MF_P1_TotalAmount""].Visible=""true"";ISpace[""MF_P1_ApplicationStatus""].Visible=""false"";ISpace[""MF_P1_Initiatedon""].Visible=""false"";ISpace[""MFG_P2_Amount""].Visible=""false"";ISpace[""MF_P1_ReimbursementId""].Visible=""false"";ISpace[""MFG_P2_ReimbursementDetailsId""].Visible=""false"";ISpace[""MFG_P3_BudgetHeadId""].Visible=""false"";ISpace[""MF_P1_InitatedBy""].Visible=""false"";ISpace[""MFG_P3_ProjectDetailsId""].Visible=""false"";ISpace[""MFG_P3_FundTypeId""].Visible=""false"";ISpace[""MFG_P3_FundDetailsId""].Visible=""false"";ISpace[""MFG_P3_Amount""].Visible=""false"";ISpace[""MF_P1_UpdatedBy""].Visible=""false"";ISpace[""MF_P1_UpdatedOn""].Visible=""false"";ISpace[""MFG_P2_BillDate""].Visible=""false"";ISpace[""MF_P1_EmployeeBasicInfoId""].Visible=""false"";");
ISpace["MG_P2_ReimbursementId"].Visible="false";ISpace["MG_P2_BillDocument"].Visible="false";ISpace["MG_P2_BillDate"].Visible="true";ISpace["MG_P2_BillNo"].Visible="true";ISpace["MG_P2_ItemDescription"].Visible="true";ISpace["MG_P2_Amount"].Visible="true";ISpace["MG_P2_ReimbursementDetailsId"].Visible="false";
base.WriteDebugInfo(@"ISpace[""MG_P2_ReimbursementId""].Visible=""false"";ISpace[""MG_P2_BillDocument""].Visible=""false"";ISpace[""MG_P2_BillDate""].Visible=""true"";ISpace[""MG_P2_BillNo""].Visible=""true"";ISpace[""MG_P2_ItemDescription""].Visible=""true"";ISpace[""MG_P2_Amount""].Visible=""true"";ISpace[""MG_P2_ReimbursementDetailsId""].Visible=""false"";");
ISpace["MG_P3_Amount"].Visible="true";ISpace["MG_P3_BudgetHeadId"].Visible="true";ISpace["MG_P3_ProjectDetailsId"].Visible="true";ISpace["MG_P3_ReimbursementId"].Visible="false";ISpace["MG_P3_FundDetailsId"].Visible="false";ISpace["MG_P3_FundTypeId"].Visible="true";
base.WriteDebugInfo(@"ISpace[""MG_P3_Amount""].Visible=""true"";ISpace[""MG_P3_BudgetHeadId""].Visible=""true"";ISpace[""MG_P3_ProjectDetailsId""].Visible=""true"";ISpace[""MG_P3_ReimbursementId""].Visible=""false"";ISpace[""MG_P3_FundDetailsId""].Visible=""false"";ISpace[""MG_P3_FundTypeId""].Visible=""true"";");
}
if(ISpace["M_ReimbursementType"].Value=="2")
{
base.WriteDebugInfo(@"if(ISpace[""M_ReimbursementType""].Value==""2"")");
ISpace["M_Classification"].Visible="true";ISpace["M_SubClassication"].Visible="true";
base.WriteDebugInfo(@"ISpace[""M_Classification""].Visible=""true"";ISpace[""M_SubClassication""].Visible=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["M_Classification"].Visible="false";ISpace["M_SubClassication"].Visible="false";
base.WriteDebugInfo(@"ISpace[""M_Classification""].Visible=""false"";ISpace[""M_SubClassication""].Visible=""false"";");
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
ISpace["growid"].Value=ISpace["ReimbursementBillDetails_RowId"].Value;
base.WriteDebugInfo(@"ISpace[""growid""].Value=ISpace[""ReimbursementBillDetails_RowId""].Value;");
base.WriteDebugInfo(@"EXEC LoadFormGridDataC9ACCA847AF347E79133D777BE46A656 '@@gv_InstanceId','@@gv_ProcessMapId','C9ACCA84-7AF3-47E7-9133-D777BE46A656','@@gv_ActivityMapId','#growid'");

var querySource3BC8920E9488421CBBA16D92ECF94CB2 =GetQueryExpressionDataSource("3BC8920E-9488-421C-BBA1-6D92ECF94CB2");
Dictionary<short,object> result3BC8920E9488421CBBA16D92ECF94CB2=iSpace.ExecuteQuery(querySource3BC8920E9488421CBBA16D92ECF94CB2,@"EXEC LoadFormGridDataC9ACCA847AF347E79133D777BE46A656 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','C9ACCA84-7AF3-47E7-9133-D777BE46A656','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["growid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource3BC8920E9488421CBBA16D92ECF94CB2 =GetQueryExpressionDataSource(""3BC8920E-9488-421C-BBA1-6D92ECF94CB2"");Dictionary<short,object> result3BC8920E9488421CBBA16D92ECF94CB2=iSpace.ExecuteQuery(querySource3BC8920E9488421CBBA16D92ECF94CB2,@""EXEC LoadFormGridDataC9ACCA847AF347E79133D777BE46A656 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','C9ACCA84-7AF3-47E7-9133-D777BE46A656','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""growid""].Value + @""'"",false);");
base.WriteDebugInfo(@"EXEC LoadFormGridDataC9ACCA847AF347E79133D777BE46A656 '@@gv_InstanceId','@@gv_ProcessMapId','C9ACCA84-7AF3-47E7-9133-D777BE46A656','@@gv_ActivityMapId','#growid'");

if((result3BC8920E9488421CBBA16D92ECF94CB2!=null) && (result3BC8920E9488421CBBA16D92ECF94CB2.Count!=0))
{
if(result3BC8920E9488421CBBA16D92ECF94CB2.ContainsKey(3))
ISpace["MFG_P2_BillDate"].Value = result3BC8920E9488421CBBA16D92ECF94CB2[3];
if(result3BC8920E9488421CBBA16D92ECF94CB2.ContainsKey(4))
ISpace["MFG_P2_BillDocument"].Value = result3BC8920E9488421CBBA16D92ECF94CB2[4];
if(result3BC8920E9488421CBBA16D92ECF94CB2.ContainsKey(6))
ISpace["MFG_P2_Amount"].Value = result3BC8920E9488421CBBA16D92ECF94CB2[6];
if(result3BC8920E9488421CBBA16D92ECF94CB2.ContainsKey(0))
ISpace["MFG_P2_ReimbursementDetailsId"].Value = result3BC8920E9488421CBBA16D92ECF94CB2[0];
if(result3BC8920E9488421CBBA16D92ECF94CB2.ContainsKey(1))
ISpace["MFG_P2_ReimbursementId"].Value = result3BC8920E9488421CBBA16D92ECF94CB2[1];
if(result3BC8920E9488421CBBA16D92ECF94CB2.ContainsKey(2))
ISpace["MFG_P2_BillNo"].Value = result3BC8920E9488421CBBA16D92ECF94CB2[2];
if(result3BC8920E9488421CBBA16D92ECF94CB2.ContainsKey(5))
ISpace["MFG_P2_ItemDescription"].Value = result3BC8920E9488421CBBA16D92ECF94CB2[5];
}
else{
ISpace["MFG_P2_BillDate"].Value = null;ISpace["MFG_P2_BillDocument"].Value = null;ISpace["MFG_P2_Amount"].Value = null;ISpace["MFG_P2_ReimbursementDetailsId"].Value = null;ISpace["MFG_P2_ReimbursementId"].Value = null;ISpace["MFG_P2_BillNo"].Value = null;ISpace["MFG_P2_ItemDescription"].Value = null;
}
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

var querySource8D078B34227340D4A2DD23A371ABE1A6 =GetQueryExpressionDataSource("8D078B34-2273-40D4-A2DD-23A371ABE1A6");

DataTable result8D078B34227340D4A2DD23A371ABE1A6=iSpace.SetGridDataSource(querySource8D078B34227340D4A2DD23A371ABE1A6, _objectFactory.GetGridRPP("ReimbursementBillDetails"),@"EXEC AddFormGridDataC9ACCA847AF347E79133D777BE46A656 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','C9ACCA84-7AF3-47E7-9133-D777BE46A656','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["MFG_P2_ReimbursementDetailsId"].Value + @"','" + ISpace["MFG_P2_ReimbursementId"].Value + @"','" + ISpace["MFG_P2_BillNo"].Value + @"','" + ISpace["MFG_P2_BillDate"].Value + @"'," + ISpace["MFG_P2_BillDocument"].Value + @",'" + ISpace["MFG_P2_ItemDescription"].Value + @"'," + ISpace["MFG_P2_Amount"].Value + @",'" + ISpace["growid"].Value + @"'");

iSpace.InsertGridBindDetails("ReimbursementBillDetails","11",querySource8D078B34227340D4A2DD23A371ABE1A6,"EXEC AddFormGridDataC9ACCA847AF347E79133D777BE46A656 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','C9ACCA84-7AF3-47E7-9133-D777BE46A656','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["MFG_P2_ReimbursementDetailsId"].Value + @"','" + ISpace["MFG_P2_ReimbursementId"].Value + @"','" + ISpace["MFG_P2_BillNo"].Value + @"','" + ISpace["MFG_P2_BillDate"].Value + @"'," + ISpace["MFG_P2_BillDocument"].Value + @",'" + ISpace["MFG_P2_ItemDescription"].Value + @"'," + ISpace["MFG_P2_Amount"].Value + @",'" + ISpace["growid"].Value + @"'",_objectFactory.GetGridRPP("ReimbursementBillDetails"));

base.WriteDebugInfo(@"var querySource8D078B34227340D4A2DD23A371ABE1A6 =GetQueryExpressionDataSource(""8D078B34-2273-40D4-A2DD-23A371ABE1A6"");DataTable result8D078B34227340D4A2DD23A371ABE1A6=iSpace.SetGridDataSource(querySource8D078B34227340D4A2DD23A371ABE1A6, _objectFactory.GetGridRPP(""ReimbursementBillDetails""),@""EXEC AddFormGridDataC9ACCA847AF347E79133D777BE46A656 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','C9ACCA84-7AF3-47E7-9133-D777BE46A656','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""MFG_P2_ReimbursementDetailsId""].Value + @""','"" + ISpace[""MFG_P2_ReimbursementId""].Value + @""','"" + ISpace[""MFG_P2_BillNo""].Value + @""','"" + ISpace[""MFG_P2_BillDate""].Value + @""',"" + ISpace[""MFG_P2_BillDocument""].Value + @"",'"" + ISpace[""MFG_P2_ItemDescription""].Value + @""',"" + ISpace[""MFG_P2_Amount""].Value + @"",'"" + ISpace[""growid""].Value + @""'"");iSpace.InsertGridBindDetails(""ReimbursementBillDetails"",""11"",querySource8D078B34227340D4A2DD23A371ABE1A6,""EXEC AddFormGridDataC9ACCA847AF347E79133D777BE46A656 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','C9ACCA84-7AF3-47E7-9133-D777BE46A656','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""MFG_P2_ReimbursementDetailsId""].Value + @""','"" + ISpace[""MFG_P2_ReimbursementId""].Value + @""','"" + ISpace[""MFG_P2_BillNo""].Value + @""','"" + ISpace[""MFG_P2_BillDate""].Value + @""',"" + ISpace[""MFG_P2_BillDocument""].Value + @"",'"" + ISpace[""MFG_P2_ItemDescription""].Value + @""',"" + ISpace[""MFG_P2_Amount""].Value + @"",'"" + ISpace[""growid""].Value + @""'"",_objectFactory.GetGridRPP(""ReimbursementBillDetails""));");
base.WriteDebugInfo(@"EXEC AddFormGridDataC9ACCA847AF347E79133D777BE46A656 '@@gv_InstanceId','@@gv_ProcessMapId','C9ACCA84-7AF3-47E7-9133-D777BE46A656','@@gv_ActivityMapId','#MFG_P2_ReimbursementDetailsId','#MFG_P2_ReimbursementId','#MFG_P2_BillNo','#MFG_P2_BillDate',#MFG_P2_BillDocument,'#MFG_P2_ItemDescription',#MFG_P2_Amount,'#growid'");


List<Triplet<string, short, short?>> resultC48E5BD17B2A4917979A69F487396125=acdataIspace89D38028FA534F9E89EA42C506E8E381.GetQueryExpressionBindings("C48E5BD1-7B2A-4917-979A-69F487396125");
iSpace.SetGridData(result8D078B34227340D4A2DD23A371ABE1A6,resultC48E5BD17B2A4917979A69F487396125,"ReimbursementBillDetails",ref ISpace);
iSpace.UpdateGridBindDetails("ReimbursementBillDetails",resultC48E5BD17B2A4917979A69F487396125);
}
else
{
base.WriteDebugInfo(@"else");

var querySource9B5B780E4C6E4FCEA2BDA3A4764A9120 =GetQueryExpressionDataSource("9B5B780E-4C6E-4FCE-A2BD-A3A4764A9120");

DataTable result9B5B780E4C6E4FCEA2BDA3A4764A9120=iSpace.SetGridDataSource(querySource9B5B780E4C6E4FCEA2BDA3A4764A9120, _objectFactory.GetGridRPP("ReimbursementBillDetails"),@"EXEC UpdateFormGridDataC9ACCA847AF347E79133D777BE46A656 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','C9ACCA84-7AF3-47E7-9133-D777BE46A656','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["MFG_P2_ReimbursementDetailsId"].Value + @"','" + ISpace["MFG_P2_ReimbursementId"].Value + @"','" + ISpace["MFG_P2_BillNo"].Value + @"','" + ISpace["MFG_P2_BillDate"].Value + @"'," + ISpace["MFG_P2_BillDocument"].Value + @",'" + ISpace["MFG_P2_ItemDescription"].Value + @"'," + ISpace["MFG_P2_Amount"].Value + @",'" + ISpace["growid"].Value + @"'");

iSpace.InsertGridBindDetails("ReimbursementBillDetails","11",querySource9B5B780E4C6E4FCEA2BDA3A4764A9120,"EXEC UpdateFormGridDataC9ACCA847AF347E79133D777BE46A656 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','C9ACCA84-7AF3-47E7-9133-D777BE46A656','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["MFG_P2_ReimbursementDetailsId"].Value + @"','" + ISpace["MFG_P2_ReimbursementId"].Value + @"','" + ISpace["MFG_P2_BillNo"].Value + @"','" + ISpace["MFG_P2_BillDate"].Value + @"'," + ISpace["MFG_P2_BillDocument"].Value + @",'" + ISpace["MFG_P2_ItemDescription"].Value + @"'," + ISpace["MFG_P2_Amount"].Value + @",'" + ISpace["growid"].Value + @"'",_objectFactory.GetGridRPP("ReimbursementBillDetails"));

base.WriteDebugInfo(@"var querySource9B5B780E4C6E4FCEA2BDA3A4764A9120 =GetQueryExpressionDataSource(""9B5B780E-4C6E-4FCE-A2BD-A3A4764A9120"");DataTable result9B5B780E4C6E4FCEA2BDA3A4764A9120=iSpace.SetGridDataSource(querySource9B5B780E4C6E4FCEA2BDA3A4764A9120, _objectFactory.GetGridRPP(""ReimbursementBillDetails""),@""EXEC UpdateFormGridDataC9ACCA847AF347E79133D777BE46A656 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','C9ACCA84-7AF3-47E7-9133-D777BE46A656','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""MFG_P2_ReimbursementDetailsId""].Value + @""','"" + ISpace[""MFG_P2_ReimbursementId""].Value + @""','"" + ISpace[""MFG_P2_BillNo""].Value + @""','"" + ISpace[""MFG_P2_BillDate""].Value + @""',"" + ISpace[""MFG_P2_BillDocument""].Value + @"",'"" + ISpace[""MFG_P2_ItemDescription""].Value + @""',"" + ISpace[""MFG_P2_Amount""].Value + @"",'"" + ISpace[""growid""].Value + @""'"");iSpace.InsertGridBindDetails(""ReimbursementBillDetails"",""11"",querySource9B5B780E4C6E4FCEA2BDA3A4764A9120,""EXEC UpdateFormGridDataC9ACCA847AF347E79133D777BE46A656 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','C9ACCA84-7AF3-47E7-9133-D777BE46A656','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""MFG_P2_ReimbursementDetailsId""].Value + @""','"" + ISpace[""MFG_P2_ReimbursementId""].Value + @""','"" + ISpace[""MFG_P2_BillNo""].Value + @""','"" + ISpace[""MFG_P2_BillDate""].Value + @""',"" + ISpace[""MFG_P2_BillDocument""].Value + @"",'"" + ISpace[""MFG_P2_ItemDescription""].Value + @""',"" + ISpace[""MFG_P2_Amount""].Value + @"",'"" + ISpace[""growid""].Value + @""'"",_objectFactory.GetGridRPP(""ReimbursementBillDetails""));");
base.WriteDebugInfo(@"EXEC UpdateFormGridDataC9ACCA847AF347E79133D777BE46A656 '@@gv_InstanceId','@@gv_ProcessMapId','C9ACCA84-7AF3-47E7-9133-D777BE46A656','@@gv_ActivityMapId','#MFG_P2_ReimbursementDetailsId','#MFG_P2_ReimbursementId','#MFG_P2_BillNo','#MFG_P2_BillDate',#MFG_P2_BillDocument,'#MFG_P2_ItemDescription',#MFG_P2_Amount,'#growid'");


List<Triplet<string, short, short?>> result9EA07CACF2274E83A5EE8C316E74D75C=acdataIspace89D38028FA534F9E89EA42C506E8E381.GetQueryExpressionBindings("9EA07CAC-F227-4E83-A5EE-8C316E74D75C");
iSpace.SetGridData(result9B5B780E4C6E4FCEA2BDA3A4764A9120,result9EA07CACF2274E83A5EE8C316E74D75C,"ReimbursementBillDetails",ref ISpace);
iSpace.UpdateGridBindDetails("ReimbursementBillDetails",result9EA07CACF2274E83A5EE8C316E74D75C);
}
object MG_P2_Amount=iSpace.Sum("[1D198218-D4AF-4E09-9A9D-119D03D0C3BA]","MG_P2_Amount","",ISpace["gv_instanceid"].Value);
ISpace["MF_P1_TotalAmount"].Value=Convert.ChangeType(MG_P2_Amount, MG_P2_Amount.GetType());;
base.WriteDebugInfo(@"object MG_P2_Amount=iSpace.Sum(""[1D198218-D4AF-4E09-9A9D-119D03D0C3BA]"",""MG_P2_Amount"","""",ISpace[""gv_instanceid""].Value);
ISpace[""MF_P1_TotalAmount""].Value=Convert.ChangeType(MG_P2_Amount, MG_P2_Amount.GetType());;");
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
if (_elementBase != null)  iSpace.SetLoopExpressionData("ReimbursementFundDetails","84AEB9E0-3009-4426-AB92-AAF06D2B42AF",_objectFactory.GetGridRPP("ReimbursementFundDetails"),_elementBase.GetGridLoopQuery("84AEB9E0-3009-4426-AB92-AAF06D2B42AF","ReimbursementFundDetails",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""ReimbursementFundDetails"",ref ISpace);

foreach(var gridChild in ISpace[""ReimbursementFundDetails""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
}
if(ISpace["growid"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""growid""].Value=="""")");

var querySourceCBB3928101F44B3AB89247A0222DAFBA =GetQueryExpressionDataSource("CBB39281-01F4-4B3A-B892-47A0222DAFBA");

DataTable resultCBB3928101F44B3AB89247A0222DAFBA=iSpace.SetGridDataSource(querySourceCBB3928101F44B3AB89247A0222DAFBA, _objectFactory.GetGridRPP("ReimbursementFundDetails"),@"EXEC AddFormGridDataD85301F7BAF94BE8A2B174E5CBB3D054 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','D85301F7-BAF9-4BE8-A2B1-74E5CBB3D054','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["MFG_P3_FundDetailsId"].Value + @"','" + ISpace["MFG_P3_ReimbursementId"].Value + @"','" + ISpace["MFG_P3_FundTypeId"].Value + @"','" + ISpace["MFG_P3_ProjectDetailsId"].Value + @"','" + ISpace["MFG_P3_BudgetHeadId"].Value + @"','" + ISpace["MFG_P3_Amount"].Value + @"','" + ISpace["growid"].Value + @"'");

iSpace.InsertGridBindDetails("ReimbursementFundDetails","11",querySourceCBB3928101F44B3AB89247A0222DAFBA,"EXEC AddFormGridDataD85301F7BAF94BE8A2B174E5CBB3D054 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','D85301F7-BAF9-4BE8-A2B1-74E5CBB3D054','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["MFG_P3_FundDetailsId"].Value + @"','" + ISpace["MFG_P3_ReimbursementId"].Value + @"','" + ISpace["MFG_P3_FundTypeId"].Value + @"','" + ISpace["MFG_P3_ProjectDetailsId"].Value + @"','" + ISpace["MFG_P3_BudgetHeadId"].Value + @"','" + ISpace["MFG_P3_Amount"].Value + @"','" + ISpace["growid"].Value + @"'",_objectFactory.GetGridRPP("ReimbursementFundDetails"));

base.WriteDebugInfo(@"var querySourceCBB3928101F44B3AB89247A0222DAFBA =GetQueryExpressionDataSource(""CBB39281-01F4-4B3A-B892-47A0222DAFBA"");DataTable resultCBB3928101F44B3AB89247A0222DAFBA=iSpace.SetGridDataSource(querySourceCBB3928101F44B3AB89247A0222DAFBA, _objectFactory.GetGridRPP(""ReimbursementFundDetails""),@""EXEC AddFormGridDataD85301F7BAF94BE8A2B174E5CBB3D054 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','D85301F7-BAF9-4BE8-A2B1-74E5CBB3D054','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""MFG_P3_FundDetailsId""].Value + @""','"" + ISpace[""MFG_P3_ReimbursementId""].Value + @""','"" + ISpace[""MFG_P3_FundTypeId""].Value + @""','"" + ISpace[""MFG_P3_ProjectDetailsId""].Value + @""','"" + ISpace[""MFG_P3_BudgetHeadId""].Value + @""','"" + ISpace[""MFG_P3_Amount""].Value + @""','"" + ISpace[""growid""].Value + @""'"");iSpace.InsertGridBindDetails(""ReimbursementFundDetails"",""11"",querySourceCBB3928101F44B3AB89247A0222DAFBA,""EXEC AddFormGridDataD85301F7BAF94BE8A2B174E5CBB3D054 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','D85301F7-BAF9-4BE8-A2B1-74E5CBB3D054','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""MFG_P3_FundDetailsId""].Value + @""','"" + ISpace[""MFG_P3_ReimbursementId""].Value + @""','"" + ISpace[""MFG_P3_FundTypeId""].Value + @""','"" + ISpace[""MFG_P3_ProjectDetailsId""].Value + @""','"" + ISpace[""MFG_P3_BudgetHeadId""].Value + @""','"" + ISpace[""MFG_P3_Amount""].Value + @""','"" + ISpace[""growid""].Value + @""'"",_objectFactory.GetGridRPP(""ReimbursementFundDetails""));");
base.WriteDebugInfo(@"EXEC AddFormGridDataD85301F7BAF94BE8A2B174E5CBB3D054 '@@gv_InstanceId','@@gv_ProcessMapId','D85301F7-BAF9-4BE8-A2B1-74E5CBB3D054','@@gv_ActivityMapId','#MFG_P3_FundDetailsId','#MFG_P3_ReimbursementId','#MFG_P3_FundTypeId','#MFG_P3_ProjectDetailsId','#MFG_P3_BudgetHeadId',#MFG_P3_Amount,'#growid'");


List<Triplet<string, short, short?>> result25A00CF73B354322B4DFFE24D90229BC=acdataIspace89D38028FA534F9E89EA42C506E8E381.GetQueryExpressionBindings("25A00CF7-3B35-4322-B4DF-FE24D90229BC");
iSpace.SetGridData(resultCBB3928101F44B3AB89247A0222DAFBA,result25A00CF73B354322B4DFFE24D90229BC,"ReimbursementFundDetails",ref ISpace);
iSpace.UpdateGridBindDetails("ReimbursementFundDetails",result25A00CF73B354322B4DFFE24D90229BC);
}
else
{
base.WriteDebugInfo(@"else");

var querySource334BDAE0A76B4B0F84BCAEF7F4F927FE =GetQueryExpressionDataSource("334BDAE0-A76B-4B0F-84BC-AEF7F4F927FE");

DataTable result334BDAE0A76B4B0F84BCAEF7F4F927FE=iSpace.SetGridDataSource(querySource334BDAE0A76B4B0F84BCAEF7F4F927FE, _objectFactory.GetGridRPP("ReimbursementFundDetails"),@"EXEC UpdateFormGridDataD85301F7BAF94BE8A2B174E5CBB3D054 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','D85301F7-BAF9-4BE8-A2B1-74E5CBB3D054','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["MFG_P3_FundDetailsId"].Value + @"','" + ISpace["MFG_P3_ReimbursementId"].Value + @"','" + ISpace["MFG_P3_FundTypeId"].Value + @"','" + ISpace["MFG_P3_ProjectDetailsId"].Value + @"','" + ISpace["MFG_P3_BudgetHeadId"].Value + @"'," + ISpace["MFG_P3_Amount"].Value + @",'" + ISpace["growid"].Value + @"'");

iSpace.InsertGridBindDetails("ReimbursementFundDetails","11",querySource334BDAE0A76B4B0F84BCAEF7F4F927FE,"EXEC UpdateFormGridDataD85301F7BAF94BE8A2B174E5CBB3D054 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','D85301F7-BAF9-4BE8-A2B1-74E5CBB3D054','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["MFG_P3_FundDetailsId"].Value + @"','" + ISpace["MFG_P3_ReimbursementId"].Value + @"','" + ISpace["MFG_P3_FundTypeId"].Value + @"','" + ISpace["MFG_P3_ProjectDetailsId"].Value + @"','" + ISpace["MFG_P3_BudgetHeadId"].Value + @"'," + ISpace["MFG_P3_Amount"].Value + @",'" + ISpace["growid"].Value + @"'",_objectFactory.GetGridRPP("ReimbursementFundDetails"));

base.WriteDebugInfo(@"var querySource334BDAE0A76B4B0F84BCAEF7F4F927FE =GetQueryExpressionDataSource(""334BDAE0-A76B-4B0F-84BC-AEF7F4F927FE"");DataTable result334BDAE0A76B4B0F84BCAEF7F4F927FE=iSpace.SetGridDataSource(querySource334BDAE0A76B4B0F84BCAEF7F4F927FE, _objectFactory.GetGridRPP(""ReimbursementFundDetails""),@""EXEC UpdateFormGridDataD85301F7BAF94BE8A2B174E5CBB3D054 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','D85301F7-BAF9-4BE8-A2B1-74E5CBB3D054','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""MFG_P3_FundDetailsId""].Value + @""','"" + ISpace[""MFG_P3_ReimbursementId""].Value + @""','"" + ISpace[""MFG_P3_FundTypeId""].Value + @""','"" + ISpace[""MFG_P3_ProjectDetailsId""].Value + @""','"" + ISpace[""MFG_P3_BudgetHeadId""].Value + @""',"" + ISpace[""MFG_P3_Amount""].Value + @"",'"" + ISpace[""growid""].Value + @""'"");iSpace.InsertGridBindDetails(""ReimbursementFundDetails"",""11"",querySource334BDAE0A76B4B0F84BCAEF7F4F927FE,""EXEC UpdateFormGridDataD85301F7BAF94BE8A2B174E5CBB3D054 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','D85301F7-BAF9-4BE8-A2B1-74E5CBB3D054','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""MFG_P3_FundDetailsId""].Value + @""','"" + ISpace[""MFG_P3_ReimbursementId""].Value + @""','"" + ISpace[""MFG_P3_FundTypeId""].Value + @""','"" + ISpace[""MFG_P3_ProjectDetailsId""].Value + @""','"" + ISpace[""MFG_P3_BudgetHeadId""].Value + @""',"" + ISpace[""MFG_P3_Amount""].Value + @"",'"" + ISpace[""growid""].Value + @""'"",_objectFactory.GetGridRPP(""ReimbursementFundDetails""));");
base.WriteDebugInfo(@"EXEC UpdateFormGridDataD85301F7BAF94BE8A2B174E5CBB3D054 '@@gv_InstanceId','@@gv_ProcessMapId','D85301F7-BAF9-4BE8-A2B1-74E5CBB3D054','@@gv_ActivityMapId','#MFG_P3_FundDetailsId','#MFG_P3_ReimbursementId','#MFG_P3_FundTypeId','#MFG_P3_ProjectDetailsId','#MFG_P3_BudgetHeadId',#MFG_P3_Amount,'#growid'");


List<Triplet<string, short, short?>> resultEFFC55B685564D91AE91384F68B422FF=acdataIspace89D38028FA534F9E89EA42C506E8E381.GetQueryExpressionBindings("EFFC55B6-8556-4D91-AE91-384F68B422FF");
iSpace.SetGridData(result334BDAE0A76B4B0F84BCAEF7F4F927FE,resultEFFC55B685564D91AE91384F68B422FF,"ReimbursementFundDetails",ref ISpace);
iSpace.UpdateGridBindDetails("ReimbursementFundDetails",resultEFFC55B685564D91AE91384F68B422FF);
}
base.WriteDebugInfo(@"#ReimbursementFundDetails[Rows]");
iSpace.GetLoopExpressionData("ReimbursementFundDetails",ref ISpace);

foreach(var gridChild in ISpace["ReimbursementFundDetails"].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 



ISpace["MG_P3_PackageProcessMapId"].Value=ISpace["M_PackageProcessMapId"].Value;
base.WriteDebugInfo(@"

ISpace[""MG_P3_PackageProcessMapId""].Value=ISpace[""M_PackageProcessMapId""].Value;");


ISpace["MG_P3_EmployeeBaicInfoId"].Value=ISpace["UC_EmployeeBaicInfoId"].Value;
base.WriteDebugInfo(@"

ISpace[""MG_P3_EmployeeBaicInfoId""].Value=ISpace[""UC_EmployeeBaicInfoId""].Value;");
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("ReimbursementFundDetails","84AEB9E0-3009-4426-AB92-AAF06D2B42AF",_objectFactory.GetGridRPP("ReimbursementFundDetails"),_elementBase.GetGridLoopQuery("84AEB9E0-3009-4426-AB92-AAF06D2B42AF","ReimbursementFundDetails",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""ReimbursementFundDetails"",ref ISpace);

foreach(var gridChild in ISpace[""ReimbursementFundDetails""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
object MG_P3_Amount=iSpace.Sum("[84AEB9E0-3009-4426-AB92-AAF06D2B42AF]","MG_P3_Amount","",ISpace["gv_instanceid"].Value);
ISpace["MFG_P3_OverallAmount"].Value=Convert.ChangeType(MG_P3_Amount, MG_P3_Amount.GetType());;
base.WriteDebugInfo(@"object MG_P3_Amount=iSpace.Sum(""[84AEB9E0-3009-4426-AB92-AAF06D2B42AF]"",""MG_P3_Amount"","""",ISpace[""gv_instanceid""].Value);
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
private void SubscribeElementEvents_submitform (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"SubmitForm-OnClick");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC UpsertActivityTrailLogDetails '@@gv_TenantId','#M_InstanceId','@@gv_ActivityName','#MF_P1_Remarks','@@gv_UserName','#M_SourceActivityMapId','#SetDestinationTo','@@gv_UserId','#M_IsSourceStep'");

var querySourcebefdd5b207e912dc5d3682026e5e2134 =GetQueryExpressionDataSource("befdd5b2-07e9-12dc-5d36-82026e5e2134");
Dictionary<short,object> resultbefdd5b207e912dc5d3682026e5e2134=iSpace.ExecuteQuery(querySourcebefdd5b207e912dc5d3682026e5e2134,@"EXEC UpsertActivityTrailLogDetails '" + ISpace["gv_tenantid"].Value + @"','" + ISpace["M_InstanceId"].Value + @"','" + ISpace["gv_activityname"].Value + @"','" + ISpace["MF_P1_Remarks"].Value + @"','" + ISpace["gv_username"].Value + @"','" + ISpace["M_SourceActivityMapId"].Value + @"','" + ISpace["SetDestinationTo"].Value + @"','" + ISpace["gv_userid"].Value + @"','" + ISpace["M_IsSourceStep"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourcebefdd5b207e912dc5d3682026e5e2134 =GetQueryExpressionDataSource(""befdd5b2-07e9-12dc-5d36-82026e5e2134"");Dictionary<short,object> resultbefdd5b207e912dc5d3682026e5e2134=iSpace.ExecuteQuery(querySourcebefdd5b207e912dc5d3682026e5e2134,@""EXEC UpsertActivityTrailLogDetails '"" + ISpace[""gv_tenantid""].Value + @""','"" + ISpace[""M_InstanceId""].Value + @""','"" + ISpace[""gv_activityname""].Value + @""','"" + ISpace[""MF_P1_Remarks""].Value + @""','"" + ISpace[""gv_username""].Value + @""','"" + ISpace[""M_SourceActivityMapId""].Value + @""','"" + ISpace[""SetDestinationTo""].Value + @""','"" + ISpace[""gv_userid""].Value + @""','"" + ISpace[""M_IsSourceStep""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultbefdd5b207e912dc5d3682026e5e2134!=null) && (resultbefdd5b207e912dc5d3682026e5e2134.Count!=0))
{
if(resultbefdd5b207e912dc5d3682026e5e2134.ContainsKey(0))
ISpace["ExecutionMessage"].Value = resultbefdd5b207e912dc5d3682026e5e2134[0];
}
else{
ISpace["ExecutionMessage"].Value = null;
}
}
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
ISpace["MF_P1_ApplicationStatus"].Value="A";
base.WriteDebugInfo(@"ISpace[""MF_P1_ApplicationStatus""].Value=""A"";");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC UpsertProjectReimbursement '#MF_P1_ReimbursementId','#UC_EmployeeBaicInfoId','#MF_P1_TotalAmount','@@gv_UserId','#MF_P1_ApplicationStatus','#M_ReimbursementType','#M_Classification','#M_SubClassication','@@gv_UserId'");

var querySourced58dc3c8687f1ebcd4754068de464713 =GetQueryExpressionDataSource("d58dc3c8-687f-1ebc-d475-4068de464713");
Dictionary<short,object> resultd58dc3c8687f1ebcd4754068de464713=iSpace.ExecuteQuery(querySourced58dc3c8687f1ebcd4754068de464713,@"EXEC UpsertProjectReimbursement '" + ISpace["MF_P1_ReimbursementId"].Value + @"','" + ISpace["UC_EmployeeBaicInfoId"].Value + @"','" + ISpace["MF_P1_TotalAmount"].Value + @"','" + ISpace["gv_userid"].Value + @"','" + ISpace["MF_P1_ApplicationStatus"].Value + @"','" + ISpace["M_ReimbursementType"].Value + @"','" + ISpace["M_Classification"].Value + @"','" + ISpace["M_SubClassication"].Value + @"','" + ISpace["gv_userid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourced58dc3c8687f1ebcd4754068de464713 =GetQueryExpressionDataSource(""d58dc3c8-687f-1ebc-d475-4068de464713"");Dictionary<short,object> resultd58dc3c8687f1ebcd4754068de464713=iSpace.ExecuteQuery(querySourced58dc3c8687f1ebcd4754068de464713,@""EXEC UpsertProjectReimbursement '"" + ISpace[""MF_P1_ReimbursementId""].Value + @""','"" + ISpace[""UC_EmployeeBaicInfoId""].Value + @""','"" + ISpace[""MF_P1_TotalAmount""].Value + @""','"" + ISpace[""gv_userid""].Value + @""','"" + ISpace[""MF_P1_ApplicationStatus""].Value + @""','"" + ISpace[""M_ReimbursementType""].Value + @""','"" + ISpace[""M_Classification""].Value + @""','"" + ISpace[""M_SubClassication""].Value + @""','"" + ISpace[""gv_userid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultd58dc3c8687f1ebcd4754068de464713!=null) && (resultd58dc3c8687f1ebcd4754068de464713.Count!=0))
{
if(resultd58dc3c8687f1ebcd4754068de464713.ContainsKey(0))
ISpace["ExecutionMessage"].Value = resultd58dc3c8687f1ebcd4754068de464713[0];
}
else{
ISpace["ExecutionMessage"].Value = null;
}
base.WriteDebugInfo(@"EXEC UpsertProjectReimbursementFundDetails '#MG_P3_FundDetailsId','#MF_P1_ReimbursementId','#MG_P3_FundTypeId','#MG_P3_ProjectDetailsId','#MG_P3_BudgetHeadId','#MG_P3_Amount'");

var querySource478236c45c793773d35402c74092c916 =GetQueryExpressionDataSource("478236c4-5c79-3773-d354-02c74092c916");
Dictionary<short,object> result478236c45c793773d35402c74092c916=iSpace.ExecuteQuery(querySource478236c45c793773d35402c74092c916,@"EXEC UpsertProjectReimbursementFundDetails '" + ISpace["MG_P3_FundDetailsId"].Value + @"','" + ISpace["MF_P1_ReimbursementId"].Value + @"','" + ISpace["MG_P3_FundTypeId"].Value + @"','" + ISpace["MG_P3_ProjectDetailsId"].Value + @"','" + ISpace["MG_P3_BudgetHeadId"].Value + @"','" + ISpace["MG_P3_Amount"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource478236c45c793773d35402c74092c916 =GetQueryExpressionDataSource(""478236c4-5c79-3773-d354-02c74092c916"");Dictionary<short,object> result478236c45c793773d35402c74092c916=iSpace.ExecuteQuery(querySource478236c45c793773d35402c74092c916,@""EXEC UpsertProjectReimbursementFundDetails '"" + ISpace[""MG_P3_FundDetailsId""].Value + @""','"" + ISpace[""MF_P1_ReimbursementId""].Value + @""','"" + ISpace[""MG_P3_FundTypeId""].Value + @""','"" + ISpace[""MG_P3_ProjectDetailsId""].Value + @""','"" + ISpace[""MG_P3_BudgetHeadId""].Value + @""','"" + ISpace[""MG_P3_Amount""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result478236c45c793773d35402c74092c916!=null) && (result478236c45c793773d35402c74092c916.Count!=0))
{
if(result478236c45c793773d35402c74092c916.ContainsKey(0))
ISpace["ExecutionMessage"].Value = result478236c45c793773d35402c74092c916[0];
}
else{
ISpace["ExecutionMessage"].Value = null;
}
base.WriteDebugInfo(@"EXEC UpsertProjectReimbursementBillDetails '#MG_P2_ReimbursementDetailsId','#MF_P1_ReimbursementId','#MG_P2_BillNo','#MG_P2_BillDate',NULL,'#MG_P2_ItemDescription','#MG_P2_Amount'");

var querySource0ac6af4e84d7e8d409946108bb08331c =GetQueryExpressionDataSource("0ac6af4e-84d7-e8d4-0994-6108bb08331c");
Dictionary<short,object> result0ac6af4e84d7e8d409946108bb08331c=iSpace.ExecuteQuery(querySource0ac6af4e84d7e8d409946108bb08331c,@"EXEC UpsertProjectReimbursementBillDetails '" + ISpace["MG_P2_ReimbursementDetailsId"].Value + @"','" + ISpace["MF_P1_ReimbursementId"].Value + @"','" + ISpace["MG_P2_BillNo"].Value + @"','" + ISpace["MG_P2_BillDate"].Value + @"',NULL,'" + ISpace["MG_P2_ItemDescription"].Value + @"','" + ISpace["MG_P2_Amount"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource0ac6af4e84d7e8d409946108bb08331c =GetQueryExpressionDataSource(""0ac6af4e-84d7-e8d4-0994-6108bb08331c"");Dictionary<short,object> result0ac6af4e84d7e8d409946108bb08331c=iSpace.ExecuteQuery(querySource0ac6af4e84d7e8d409946108bb08331c,@""EXEC UpsertProjectReimbursementBillDetails '"" + ISpace[""MG_P2_ReimbursementDetailsId""].Value + @""','"" + ISpace[""MF_P1_ReimbursementId""].Value + @""','"" + ISpace[""MG_P2_BillNo""].Value + @""','"" + ISpace[""MG_P2_BillDate""].Value + @""',NULL,'"" + ISpace[""MG_P2_ItemDescription""].Value + @""','"" + ISpace[""MG_P2_Amount""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result0ac6af4e84d7e8d409946108bb08331c!=null) && (result0ac6af4e84d7e8d409946108bb08331c.Count!=0))
{
if(result0ac6af4e84d7e8d409946108bb08331c.ContainsKey(0))
ISpace["ExecutionMessage"].Value = result0ac6af4e84d7e8d409946108bb08331c[0];
}
else{
ISpace["ExecutionMessage"].Value = null;
}
base.WriteDebugInfo(@"EXEC UpsertDocumentDetails '#M_DocumentDetailsId','#M_InstanceId','#M_PackageProcessMapId','#M_DocumentName','#M_UploadDcoument',' @@gv_UserId'");

var querySource17adfd2bbf7aa7968851003732efc9c7 =GetQueryExpressionDataSource("17adfd2b-bf7a-a796-8851-003732efc9c7");
Dictionary<short,object> result17adfd2bbf7aa7968851003732efc9c7=iSpace.ExecuteQuery(querySource17adfd2bbf7aa7968851003732efc9c7,@"EXEC UpsertDocumentDetails '" + ISpace["M_DocumentDetailsId"].Value + @"','" + ISpace["M_InstanceId"].Value + @"','" + ISpace["M_PackageProcessMapId"].Value + @"','" + ISpace["M_DocumentName"].Value + @"','" + ISpace["M_UploadDcoument"].Value + @"',' " + ISpace["gv_userid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource17adfd2bbf7aa7968851003732efc9c7 =GetQueryExpressionDataSource(""17adfd2b-bf7a-a796-8851-003732efc9c7"");Dictionary<short,object> result17adfd2bbf7aa7968851003732efc9c7=iSpace.ExecuteQuery(querySource17adfd2bbf7aa7968851003732efc9c7,@""EXEC UpsertDocumentDetails '"" + ISpace[""M_DocumentDetailsId""].Value + @""','"" + ISpace[""M_InstanceId""].Value + @""','"" + ISpace[""M_PackageProcessMapId""].Value + @""','"" + ISpace[""M_DocumentName""].Value + @""','"" + ISpace[""M_UploadDcoument""].Value + @""',' "" + ISpace[""gv_userid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result17adfd2bbf7aa7968851003732efc9c7!=null) && (result17adfd2bbf7aa7968851003732efc9c7.Count!=0))
{
if(result17adfd2bbf7aa7968851003732efc9c7.ContainsKey(0))
ISpace["ExecutionMessage"].Value = result17adfd2bbf7aa7968851003732efc9c7[0];
}
else{
ISpace["ExecutionMessage"].Value = null;
}
}
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
base.WriteDebugInfo(@"EXEC [UpsertProjectBudgetDetails] 6,'#MG_P3_ProjectDetailsId','','#MG_P3_Amount','#MG_P3_BudgetHeadId',1,'#MG_P3_FundTypeId'");

var querySourceBA4985A9C4A24DC6BBD1661F0431909A =GetQueryExpressionDataSource("BA4985A9-C4A2-4DC6-BBD1-661F0431909A");
Dictionary<short,object> resultBA4985A9C4A24DC6BBD1661F0431909A=iSpace.ExecuteQuery(querySourceBA4985A9C4A24DC6BBD1661F0431909A,@"EXEC [UpsertProjectBudgetDetails] 6,'" + ISpace["MG_P3_ProjectDetailsId"].Value + @"','','" + ISpace["MG_P3_Amount"].Value + @"','" + ISpace["MG_P3_BudgetHeadId"].Value + @"',1,'" + ISpace["MG_P3_FundTypeId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceBA4985A9C4A24DC6BBD1661F0431909A =GetQueryExpressionDataSource(""BA4985A9-C4A2-4DC6-BBD1-661F0431909A"");Dictionary<short,object> resultBA4985A9C4A24DC6BBD1661F0431909A=iSpace.ExecuteQuery(querySourceBA4985A9C4A24DC6BBD1661F0431909A,@""EXEC [UpsertProjectBudgetDetails] 6,'"" + ISpace[""MG_P3_ProjectDetailsId""].Value + @""','','"" + ISpace[""MG_P3_Amount""].Value + @""','"" + ISpace[""MG_P3_BudgetHeadId""].Value + @""',1,'"" + ISpace[""MG_P3_FundTypeId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultBA4985A9C4A24DC6BBD1661F0431909A!=null) && (resultBA4985A9C4A24DC6BBD1661F0431909A.Count!=0))
{
if(resultBA4985A9C4A24DC6BBD1661F0431909A.ContainsKey(0))
ISpace["M_UpdateCount"].Value = resultBA4985A9C4A24DC6BBD1661F0431909A[0];
}
else{
ISpace["M_UpdateCount"].Value = null;
}
}
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("ReimbursementFundDetails","84AEB9E0-3009-4426-AB92-AAF06D2B42AF",_objectFactory.GetGridRPP("ReimbursementFundDetails"),_elementBase.GetGridLoopQuery("84AEB9E0-3009-4426-AB92-AAF06D2B42AF","ReimbursementFundDetails",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""ReimbursementFundDetails"",ref ISpace);

foreach(var gridChild in ISpace[""ReimbursementFundDetails""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
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
base.WriteDebugInfo(@"EXEC UpsertUserRequestsUpdation '#M_InstanceId','#SetDestinationTo','#M_Stage','#M_Status','@@gv_UserId','#M_RequestId'");

var querySource87cbcf911fba16fd3029f8855a072138 =GetQueryExpressionDataSource("87cbcf91-1fba-16fd-3029-f8855a072138");
Dictionary<short,object> result87cbcf911fba16fd3029f8855a072138=iSpace.ExecuteQuery(querySource87cbcf911fba16fd3029f8855a072138,@"EXEC UpsertUserRequestsUpdation '" + ISpace["M_InstanceId"].Value + @"','" + ISpace["SetDestinationTo"].Value + @"','" + ISpace["M_Stage"].Value + @"','" + ISpace["M_Status"].Value + @"','" + ISpace["gv_userid"].Value + @"','" + ISpace["M_RequestId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource87cbcf911fba16fd3029f8855a072138 =GetQueryExpressionDataSource(""87cbcf91-1fba-16fd-3029-f8855a072138"");Dictionary<short,object> result87cbcf911fba16fd3029f8855a072138=iSpace.ExecuteQuery(querySource87cbcf911fba16fd3029f8855a072138,@""EXEC UpsertUserRequestsUpdation '"" + ISpace[""M_InstanceId""].Value + @""','"" + ISpace[""SetDestinationTo""].Value + @""','"" + ISpace[""M_Stage""].Value + @""','"" + ISpace[""M_Status""].Value + @""','"" + ISpace[""gv_userid""].Value + @""','"" + ISpace[""M_RequestId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result87cbcf911fba16fd3029f8855a072138!=null) && (result87cbcf911fba16fd3029f8855a072138.Count!=0))
{
if(result87cbcf911fba16fd3029f8855a072138.ContainsKey(0))
ISpace["ExecutionMessage"].Value = result87cbcf911fba16fd3029f8855a072138[0];
}
else{
ISpace["ExecutionMessage"].Value = null;
}
ISpace["Message"].Value=@"Submitted Successfully";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Submitted Successfully"";");
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
base.WriteDebugInfo(@"EXEC LoadFormGridDataD85301F7BAF94BE8A2B174E5CBB3D054 '@@gv_InstanceId','@@gv_ProcessMapId','D85301F7-BAF9-4BE8-A2B1-74E5CBB3D054','@@gv_ActivityMapId','#growid'");

var querySource1F49FB0DA84D47A58942368F58A2D97A =GetQueryExpressionDataSource("1F49FB0D-A84D-47A5-8942-368F58A2D97A");
Dictionary<short,object> result1F49FB0DA84D47A58942368F58A2D97A=iSpace.ExecuteQuery(querySource1F49FB0DA84D47A58942368F58A2D97A,@"EXEC LoadFormGridDataD85301F7BAF94BE8A2B174E5CBB3D054 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','D85301F7-BAF9-4BE8-A2B1-74E5CBB3D054','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["growid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource1F49FB0DA84D47A58942368F58A2D97A =GetQueryExpressionDataSource(""1F49FB0D-A84D-47A5-8942-368F58A2D97A"");Dictionary<short,object> result1F49FB0DA84D47A58942368F58A2D97A=iSpace.ExecuteQuery(querySource1F49FB0DA84D47A58942368F58A2D97A,@""EXEC LoadFormGridDataD85301F7BAF94BE8A2B174E5CBB3D054 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','D85301F7-BAF9-4BE8-A2B1-74E5CBB3D054','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""growid""].Value + @""'"",false);");
base.WriteDebugInfo(@"EXEC LoadFormGridDataD85301F7BAF94BE8A2B174E5CBB3D054 '@@gv_InstanceId','@@gv_ProcessMapId','D85301F7-BAF9-4BE8-A2B1-74E5CBB3D054','@@gv_ActivityMapId','#growid'");

if((result1F49FB0DA84D47A58942368F58A2D97A!=null) && (result1F49FB0DA84D47A58942368F58A2D97A.Count!=0))
{
if(result1F49FB0DA84D47A58942368F58A2D97A.ContainsKey(4))
ISpace["MFG_P3_BudgetHeadId"].Value = result1F49FB0DA84D47A58942368F58A2D97A[4];
if(result1F49FB0DA84D47A58942368F58A2D97A.ContainsKey(3))
ISpace["MFG_P3_ProjectDetailsId"].Value = result1F49FB0DA84D47A58942368F58A2D97A[3];
if(result1F49FB0DA84D47A58942368F58A2D97A.ContainsKey(2))
ISpace["MFG_P3_FundTypeId"].Value = result1F49FB0DA84D47A58942368F58A2D97A[2];
if(result1F49FB0DA84D47A58942368F58A2D97A.ContainsKey(5))
ISpace["MFG_P3_Amount"].Value = result1F49FB0DA84D47A58942368F58A2D97A[5];
if(result1F49FB0DA84D47A58942368F58A2D97A.ContainsKey(1))
ISpace["MFG_P3_ReimbursementId"].Value = result1F49FB0DA84D47A58942368F58A2D97A[1];
if(result1F49FB0DA84D47A58942368F58A2D97A.ContainsKey(0))
ISpace["MFG_P3_FundDetailsId"].Value = result1F49FB0DA84D47A58942368F58A2D97A[0];
}
else{
ISpace["MFG_P3_BudgetHeadId"].Value = null;ISpace["MFG_P3_ProjectDetailsId"].Value = null;ISpace["MFG_P3_FundTypeId"].Value = null;ISpace["MFG_P3_Amount"].Value = null;ISpace["MFG_P3_ReimbursementId"].Value = null;ISpace["MFG_P3_FundDetailsId"].Value = null;
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
base.WriteDebugInfo(@"Exec GetStageStatus 1,'','','#M_MoveToValue','#M_SourceActivityMapId'");

var querySource959A027E58AA471DADF1501D54E16A1B =GetQueryExpressionDataSource("959A027E-58AA-471D-ADF1-501D54E16A1B");
Dictionary<short,object> result959A027E58AA471DADF1501D54E16A1B=iSpace.ExecuteQuery(querySource959A027E58AA471DADF1501D54E16A1B,@"Exec GetStageStatus 1,'','','" + ISpace["M_MoveToValue"].Value + @"','" + ISpace["M_SourceActivityMapId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource959A027E58AA471DADF1501D54E16A1B =GetQueryExpressionDataSource(""959A027E-58AA-471D-ADF1-501D54E16A1B"");Dictionary<short,object> result959A027E58AA471DADF1501D54E16A1B=iSpace.ExecuteQuery(querySource959A027E58AA471DADF1501D54E16A1B,@""Exec GetStageStatus 1,'','','"" + ISpace[""M_MoveToValue""].Value + @""','"" + ISpace[""M_SourceActivityMapId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result959A027E58AA471DADF1501D54E16A1B!=null) && (result959A027E58AA471DADF1501D54E16A1B.Count!=0))
{
if(result959A027E58AA471DADF1501D54E16A1B.ContainsKey(1))
ISpace["M_RemarksMandatory"].Value = result959A027E58AA471DADF1501D54E16A1B[1];
if(result959A027E58AA471DADF1501D54E16A1B.ContainsKey(5))
ISpace["M_IsflowReturned"].Value = result959A027E58AA471DADF1501D54E16A1B[5];
if(result959A027E58AA471DADF1501D54E16A1B.ContainsKey(6))
ISpace["M_IsCancelReject"].Value = result959A027E58AA471DADF1501D54E16A1B[6];
if(result959A027E58AA471DADF1501D54E16A1B.ContainsKey(4))
ISpace["M_FieldMandatory"].Value = result959A027E58AA471DADF1501D54E16A1B[4];
if(result959A027E58AA471DADF1501D54E16A1B.ContainsKey(3))
ISpace["M_SaveDomainData"].Value = result959A027E58AA471DADF1501D54E16A1B[3];
if(result959A027E58AA471DADF1501D54E16A1B.ContainsKey(7))
ISpace["M_Stage"].Value = result959A027E58AA471DADF1501D54E16A1B[7];
if(result959A027E58AA471DADF1501D54E16A1B.ContainsKey(0))
ISpace["M_NextStage"].Value = result959A027E58AA471DADF1501D54E16A1B[0];
if(result959A027E58AA471DADF1501D54E16A1B.ContainsKey(2))
ISpace["MF_P1_Remarks"].Value = result959A027E58AA471DADF1501D54E16A1B[2];
}
else{
ISpace["M_RemarksMandatory"].Value = null;ISpace["M_IsflowReturned"].Value = null;ISpace["M_IsCancelReject"].Value = null;ISpace["M_FieldMandatory"].Value = null;ISpace["M_SaveDomainData"].Value = null;ISpace["M_Stage"].Value = null;ISpace["M_NextStage"].Value = null;ISpace["MF_P1_Remarks"].Value = null;
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
		if(elementName.ToLower().Equals("edit_reimbursementbilldetails"))
{
			SubscribeElementEvents_edit_reimbursementbilldetails(ref dfsParam);
}
		if(elementName.ToLower().Equals("save_reimbursementbilldetails"))
{
			SubscribeElementEvents_save_reimbursementbilldetails(ref dfsParam);
}
		if(elementName.ToLower().Equals("save_reimbursementfunddetails"))
{
			SubscribeElementEvents_save_reimbursementfunddetails(ref dfsParam);
}
		if(elementName.ToLower().Equals("submitform"))
{
			SubscribeElementEvents_submitform(ref dfsParam);
}
		if(elementName.ToLower().Equals("edit_reimbursementfunddetails"))
{
			SubscribeElementEvents_edit_reimbursementfunddetails(ref dfsParam);
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
public class ISpaceC4E2EC4C58BD44FB91D13D8E475D6C14 : VirtualForm
{
IISpace iSpace = new ISpace();
AcDataISpaceC4E2EC4C58BD44FB91D13D8E475D6C14 acdataIspaceC4E2EC4C58BD44FB91D13D8E475D6C14=new AcDataISpaceC4E2EC4C58BD44FB91D13D8E475D6C14();
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

var querySource820D767A20CC4BA1AADCA484B0BFBEFA =GetQueryExpressionDataSource("820D767A-20CC-4BA1-AADC-A484B0BFBEFA");

DataTable result820D767A20CC4BA1AADCA484B0BFBEFA=iSpace.SetGridDataSource(querySource820D767A20CC4BA1AADCA484B0BFBEFA, _objectFactory.GetGridRPP("MG_RemarksDetails"),@"EXEC GetRemarks '" + ISpace["M_InstanceId"].Value + @"'");

iSpace.InsertGridBindDetails("MG_RemarksDetails","11",querySource820D767A20CC4BA1AADCA484B0BFBEFA,"EXEC GetRemarks '" + ISpace["M_InstanceId"].Value + @"'",_objectFactory.GetGridRPP("MG_RemarksDetails"));

base.WriteDebugInfo(@"var querySource820D767A20CC4BA1AADCA484B0BFBEFA =GetQueryExpressionDataSource(""820D767A-20CC-4BA1-AADC-A484B0BFBEFA"");DataTable result820D767A20CC4BA1AADCA484B0BFBEFA=iSpace.SetGridDataSource(querySource820D767A20CC4BA1AADCA484B0BFBEFA, _objectFactory.GetGridRPP(""MG_RemarksDetails""),@""EXEC GetRemarks '"" + ISpace[""M_InstanceId""].Value + @""'"");iSpace.InsertGridBindDetails(""MG_RemarksDetails"",""11"",querySource820D767A20CC4BA1AADCA484B0BFBEFA,""EXEC GetRemarks '"" + ISpace[""M_InstanceId""].Value + @""'"",_objectFactory.GetGridRPP(""MG_RemarksDetails""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> resultE57D76A324374EAF8C530F41C6AF052C=acdataIspaceC4E2EC4C58BD44FB91D13D8E475D6C14.GetQueryExpressionBindings("E57D76A3-2437-4EAF-8C53-0F41C6AF052C");
iSpace.SetGridData(result820D767A20CC4BA1AADCA484B0BFBEFA,resultE57D76A324374EAF8C530F41C6AF052C,"MG_RemarksDetails",ref ISpace);
iSpace.UpdateGridBindDetails("MG_RemarksDetails",resultE57D76A324374EAF8C530F41C6AF052C);
ISpace["MFG_P3_BudgetHeadId"].Visible="false";ISpace["MFG_P3_ProjectDetailsId"].Visible="false";ISpace["MFG_P3_Amount"].Visible="false";
base.WriteDebugInfo(@"ISpace[""MFG_P3_BudgetHeadId""].Visible=""false"";ISpace[""MFG_P3_ProjectDetailsId""].Visible=""false"";ISpace[""MFG_P3_Amount""].Visible=""false"";");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["MFG_P2_ItemDescription"].Visible="false";ISpace["MFG_P2_BillDocument"].Visible="false";ISpace["MFG_P2_ReimbursementId"].Visible="false";ISpace["MFG_P2_BillNo"].Visible="false";ISpace["MFG_P3_ReimbursementId"].Visible="false";ISpace["MF_P1_TotalAmount"].Visible="true";ISpace["MF_P1_ApplicationStatus"].Visible="false";ISpace["MF_P1_Initiatedon"].Visible="false";ISpace["MFG_P2_Amount"].Visible="false";ISpace["MF_P1_ReimbursementId"].Visible="false";ISpace["MFG_P2_ReimbursementDetailsId"].Visible="false";ISpace["MFG_P3_BudgetHeadId"].Visible="false";ISpace["MF_P1_InitatedBy"].Visible="false";ISpace["MFG_P3_ProjectDetailsId"].Visible="false";ISpace["MFG_P3_FundTypeId"].Visible="false";ISpace["MFG_P3_FundDetailsId"].Visible="false";ISpace["MFG_P3_Amount"].Visible="false";ISpace["MF_P1_UpdatedBy"].Visible="false";ISpace["MF_P1_UpdatedOn"].Visible="false";ISpace["MFG_P2_BillDate"].Visible="false";ISpace["MF_P1_EmployeeBasicInfoId"].Visible="false";
base.WriteDebugInfo(@"ISpace[""MFG_P2_ItemDescription""].Visible=""false"";ISpace[""MFG_P2_BillDocument""].Visible=""false"";ISpace[""MFG_P2_ReimbursementId""].Visible=""false"";ISpace[""MFG_P2_BillNo""].Visible=""false"";ISpace[""MFG_P3_ReimbursementId""].Visible=""false"";ISpace[""MF_P1_TotalAmount""].Visible=""true"";ISpace[""MF_P1_ApplicationStatus""].Visible=""false"";ISpace[""MF_P1_Initiatedon""].Visible=""false"";ISpace[""MFG_P2_Amount""].Visible=""false"";ISpace[""MF_P1_ReimbursementId""].Visible=""false"";ISpace[""MFG_P2_ReimbursementDetailsId""].Visible=""false"";ISpace[""MFG_P3_BudgetHeadId""].Visible=""false"";ISpace[""MF_P1_InitatedBy""].Visible=""false"";ISpace[""MFG_P3_ProjectDetailsId""].Visible=""false"";ISpace[""MFG_P3_FundTypeId""].Visible=""false"";ISpace[""MFG_P3_FundDetailsId""].Visible=""false"";ISpace[""MFG_P3_Amount""].Visible=""false"";ISpace[""MF_P1_UpdatedBy""].Visible=""false"";ISpace[""MF_P1_UpdatedOn""].Visible=""false"";ISpace[""MFG_P2_BillDate""].Visible=""false"";ISpace[""MF_P1_EmployeeBasicInfoId""].Visible=""false"";");
ISpace["MG_P2_ReimbursementId"].Visible="false";ISpace["MG_P2_BillDocument"].Visible="false";ISpace["MG_P2_BillDate"].Visible="true";ISpace["MG_P2_BillNo"].Visible="true";ISpace["MG_P2_ItemDescription"].Visible="true";ISpace["MG_P2_Amount"].Visible="true";ISpace["MG_P2_ReimbursementDetailsId"].Visible="false";
base.WriteDebugInfo(@"ISpace[""MG_P2_ReimbursementId""].Visible=""false"";ISpace[""MG_P2_BillDocument""].Visible=""false"";ISpace[""MG_P2_BillDate""].Visible=""true"";ISpace[""MG_P2_BillNo""].Visible=""true"";ISpace[""MG_P2_ItemDescription""].Visible=""true"";ISpace[""MG_P2_Amount""].Visible=""true"";ISpace[""MG_P2_ReimbursementDetailsId""].Visible=""false"";");
ISpace["MG_P3_Amount"].Visible="true";ISpace["MG_P3_BudgetHeadId"].Visible="true";ISpace["MG_P3_ProjectDetailsId"].Visible="true";ISpace["MG_P3_ReimbursementId"].Visible="false";ISpace["MG_P3_FundDetailsId"].Visible="false";ISpace["MG_P3_FundTypeId"].Visible="true";
base.WriteDebugInfo(@"ISpace[""MG_P3_Amount""].Visible=""true"";ISpace[""MG_P3_BudgetHeadId""].Visible=""true"";ISpace[""MG_P3_ProjectDetailsId""].Visible=""true"";ISpace[""MG_P3_ReimbursementId""].Visible=""false"";ISpace[""MG_P3_FundDetailsId""].Visible=""false"";ISpace[""MG_P3_FundTypeId""].Visible=""true"";");
}
if(ISpace["M_ReimbursementType"].Value=="2")
{
base.WriteDebugInfo(@"if(ISpace[""M_ReimbursementType""].Value==""2"")");
ISpace["M_Classification"].Visible="true";ISpace["M_SubClassication"].Visible="true";
base.WriteDebugInfo(@"ISpace[""M_Classification""].Visible=""true"";ISpace[""M_SubClassication""].Visible=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["M_Classification"].Visible="false";ISpace["M_SubClassication"].Visible="false";
base.WriteDebugInfo(@"ISpace[""M_Classification""].Visible=""false"";ISpace[""M_SubClassication""].Visible=""false"";");
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
ISpace["growid"].Value=ISpace["ReimbursementBillDetails_RowId"].Value;
base.WriteDebugInfo(@"ISpace[""growid""].Value=ISpace[""ReimbursementBillDetails_RowId""].Value;");
base.WriteDebugInfo(@"EXEC LoadFormGridDataC9ACCA847AF347E79133D777BE46A656 '@@gv_InstanceId','@@gv_ProcessMapId','C9ACCA84-7AF3-47E7-9133-D777BE46A656','@@gv_ActivityMapId','#growid'");

var querySource3BC8920E9488421CBBA16D92ECF94CB2 =GetQueryExpressionDataSource("3BC8920E-9488-421C-BBA1-6D92ECF94CB2");
Dictionary<short,object> result3BC8920E9488421CBBA16D92ECF94CB2=iSpace.ExecuteQuery(querySource3BC8920E9488421CBBA16D92ECF94CB2,@"EXEC LoadFormGridDataC9ACCA847AF347E79133D777BE46A656 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','C9ACCA84-7AF3-47E7-9133-D777BE46A656','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["growid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource3BC8920E9488421CBBA16D92ECF94CB2 =GetQueryExpressionDataSource(""3BC8920E-9488-421C-BBA1-6D92ECF94CB2"");Dictionary<short,object> result3BC8920E9488421CBBA16D92ECF94CB2=iSpace.ExecuteQuery(querySource3BC8920E9488421CBBA16D92ECF94CB2,@""EXEC LoadFormGridDataC9ACCA847AF347E79133D777BE46A656 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','C9ACCA84-7AF3-47E7-9133-D777BE46A656','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""growid""].Value + @""'"",false);");
base.WriteDebugInfo(@"EXEC LoadFormGridDataC9ACCA847AF347E79133D777BE46A656 '@@gv_InstanceId','@@gv_ProcessMapId','C9ACCA84-7AF3-47E7-9133-D777BE46A656','@@gv_ActivityMapId','#growid'");

if((result3BC8920E9488421CBBA16D92ECF94CB2!=null) && (result3BC8920E9488421CBBA16D92ECF94CB2.Count!=0))
{
if(result3BC8920E9488421CBBA16D92ECF94CB2.ContainsKey(3))
ISpace["MFG_P2_BillDate"].Value = result3BC8920E9488421CBBA16D92ECF94CB2[3];
if(result3BC8920E9488421CBBA16D92ECF94CB2.ContainsKey(4))
ISpace["MFG_P2_BillDocument"].Value = result3BC8920E9488421CBBA16D92ECF94CB2[4];
if(result3BC8920E9488421CBBA16D92ECF94CB2.ContainsKey(6))
ISpace["MFG_P2_Amount"].Value = result3BC8920E9488421CBBA16D92ECF94CB2[6];
if(result3BC8920E9488421CBBA16D92ECF94CB2.ContainsKey(0))
ISpace["MFG_P2_ReimbursementDetailsId"].Value = result3BC8920E9488421CBBA16D92ECF94CB2[0];
if(result3BC8920E9488421CBBA16D92ECF94CB2.ContainsKey(1))
ISpace["MFG_P2_ReimbursementId"].Value = result3BC8920E9488421CBBA16D92ECF94CB2[1];
if(result3BC8920E9488421CBBA16D92ECF94CB2.ContainsKey(2))
ISpace["MFG_P2_BillNo"].Value = result3BC8920E9488421CBBA16D92ECF94CB2[2];
if(result3BC8920E9488421CBBA16D92ECF94CB2.ContainsKey(5))
ISpace["MFG_P2_ItemDescription"].Value = result3BC8920E9488421CBBA16D92ECF94CB2[5];
}
else{
ISpace["MFG_P2_BillDate"].Value = null;ISpace["MFG_P2_BillDocument"].Value = null;ISpace["MFG_P2_Amount"].Value = null;ISpace["MFG_P2_ReimbursementDetailsId"].Value = null;ISpace["MFG_P2_ReimbursementId"].Value = null;ISpace["MFG_P2_BillNo"].Value = null;ISpace["MFG_P2_ItemDescription"].Value = null;
}
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

var querySource8D078B34227340D4A2DD23A371ABE1A6 =GetQueryExpressionDataSource("8D078B34-2273-40D4-A2DD-23A371ABE1A6");

DataTable result8D078B34227340D4A2DD23A371ABE1A6=iSpace.SetGridDataSource(querySource8D078B34227340D4A2DD23A371ABE1A6, _objectFactory.GetGridRPP("ReimbursementBillDetails"),@"EXEC AddFormGridDataC9ACCA847AF347E79133D777BE46A656 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','C9ACCA84-7AF3-47E7-9133-D777BE46A656','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["MFG_P2_ReimbursementDetailsId"].Value + @"','" + ISpace["MFG_P2_ReimbursementId"].Value + @"','" + ISpace["MFG_P2_BillNo"].Value + @"','" + ISpace["MFG_P2_BillDate"].Value + @"'," + ISpace["MFG_P2_BillDocument"].Value + @",'" + ISpace["MFG_P2_ItemDescription"].Value + @"'," + ISpace["MFG_P2_Amount"].Value + @",'" + ISpace["growid"].Value + @"'");

iSpace.InsertGridBindDetails("ReimbursementBillDetails","11",querySource8D078B34227340D4A2DD23A371ABE1A6,"EXEC AddFormGridDataC9ACCA847AF347E79133D777BE46A656 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','C9ACCA84-7AF3-47E7-9133-D777BE46A656','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["MFG_P2_ReimbursementDetailsId"].Value + @"','" + ISpace["MFG_P2_ReimbursementId"].Value + @"','" + ISpace["MFG_P2_BillNo"].Value + @"','" + ISpace["MFG_P2_BillDate"].Value + @"'," + ISpace["MFG_P2_BillDocument"].Value + @",'" + ISpace["MFG_P2_ItemDescription"].Value + @"'," + ISpace["MFG_P2_Amount"].Value + @",'" + ISpace["growid"].Value + @"'",_objectFactory.GetGridRPP("ReimbursementBillDetails"));

base.WriteDebugInfo(@"var querySource8D078B34227340D4A2DD23A371ABE1A6 =GetQueryExpressionDataSource(""8D078B34-2273-40D4-A2DD-23A371ABE1A6"");DataTable result8D078B34227340D4A2DD23A371ABE1A6=iSpace.SetGridDataSource(querySource8D078B34227340D4A2DD23A371ABE1A6, _objectFactory.GetGridRPP(""ReimbursementBillDetails""),@""EXEC AddFormGridDataC9ACCA847AF347E79133D777BE46A656 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','C9ACCA84-7AF3-47E7-9133-D777BE46A656','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""MFG_P2_ReimbursementDetailsId""].Value + @""','"" + ISpace[""MFG_P2_ReimbursementId""].Value + @""','"" + ISpace[""MFG_P2_BillNo""].Value + @""','"" + ISpace[""MFG_P2_BillDate""].Value + @""',"" + ISpace[""MFG_P2_BillDocument""].Value + @"",'"" + ISpace[""MFG_P2_ItemDescription""].Value + @""',"" + ISpace[""MFG_P2_Amount""].Value + @"",'"" + ISpace[""growid""].Value + @""'"");iSpace.InsertGridBindDetails(""ReimbursementBillDetails"",""11"",querySource8D078B34227340D4A2DD23A371ABE1A6,""EXEC AddFormGridDataC9ACCA847AF347E79133D777BE46A656 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','C9ACCA84-7AF3-47E7-9133-D777BE46A656','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""MFG_P2_ReimbursementDetailsId""].Value + @""','"" + ISpace[""MFG_P2_ReimbursementId""].Value + @""','"" + ISpace[""MFG_P2_BillNo""].Value + @""','"" + ISpace[""MFG_P2_BillDate""].Value + @""',"" + ISpace[""MFG_P2_BillDocument""].Value + @"",'"" + ISpace[""MFG_P2_ItemDescription""].Value + @""',"" + ISpace[""MFG_P2_Amount""].Value + @"",'"" + ISpace[""growid""].Value + @""'"",_objectFactory.GetGridRPP(""ReimbursementBillDetails""));");
base.WriteDebugInfo(@"EXEC AddFormGridDataC9ACCA847AF347E79133D777BE46A656 '@@gv_InstanceId','@@gv_ProcessMapId','C9ACCA84-7AF3-47E7-9133-D777BE46A656','@@gv_ActivityMapId','#MFG_P2_ReimbursementDetailsId','#MFG_P2_ReimbursementId','#MFG_P2_BillNo','#MFG_P2_BillDate',#MFG_P2_BillDocument,'#MFG_P2_ItemDescription',#MFG_P2_Amount,'#growid'");


List<Triplet<string, short, short?>> resultC48E5BD17B2A4917979A69F487396125=acdataIspaceC4E2EC4C58BD44FB91D13D8E475D6C14.GetQueryExpressionBindings("C48E5BD1-7B2A-4917-979A-69F487396125");
iSpace.SetGridData(result8D078B34227340D4A2DD23A371ABE1A6,resultC48E5BD17B2A4917979A69F487396125,"ReimbursementBillDetails",ref ISpace);
iSpace.UpdateGridBindDetails("ReimbursementBillDetails",resultC48E5BD17B2A4917979A69F487396125);
}
else
{
base.WriteDebugInfo(@"else");

var querySource9B5B780E4C6E4FCEA2BDA3A4764A9120 =GetQueryExpressionDataSource("9B5B780E-4C6E-4FCE-A2BD-A3A4764A9120");

DataTable result9B5B780E4C6E4FCEA2BDA3A4764A9120=iSpace.SetGridDataSource(querySource9B5B780E4C6E4FCEA2BDA3A4764A9120, _objectFactory.GetGridRPP("ReimbursementBillDetails"),@"EXEC UpdateFormGridDataC9ACCA847AF347E79133D777BE46A656 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','C9ACCA84-7AF3-47E7-9133-D777BE46A656','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["MFG_P2_ReimbursementDetailsId"].Value + @"','" + ISpace["MFG_P2_ReimbursementId"].Value + @"','" + ISpace["MFG_P2_BillNo"].Value + @"','" + ISpace["MFG_P2_BillDate"].Value + @"'," + ISpace["MFG_P2_BillDocument"].Value + @",'" + ISpace["MFG_P2_ItemDescription"].Value + @"'," + ISpace["MFG_P2_Amount"].Value + @",'" + ISpace["growid"].Value + @"'");

iSpace.InsertGridBindDetails("ReimbursementBillDetails","11",querySource9B5B780E4C6E4FCEA2BDA3A4764A9120,"EXEC UpdateFormGridDataC9ACCA847AF347E79133D777BE46A656 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','C9ACCA84-7AF3-47E7-9133-D777BE46A656','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["MFG_P2_ReimbursementDetailsId"].Value + @"','" + ISpace["MFG_P2_ReimbursementId"].Value + @"','" + ISpace["MFG_P2_BillNo"].Value + @"','" + ISpace["MFG_P2_BillDate"].Value + @"'," + ISpace["MFG_P2_BillDocument"].Value + @",'" + ISpace["MFG_P2_ItemDescription"].Value + @"'," + ISpace["MFG_P2_Amount"].Value + @",'" + ISpace["growid"].Value + @"'",_objectFactory.GetGridRPP("ReimbursementBillDetails"));

base.WriteDebugInfo(@"var querySource9B5B780E4C6E4FCEA2BDA3A4764A9120 =GetQueryExpressionDataSource(""9B5B780E-4C6E-4FCE-A2BD-A3A4764A9120"");DataTable result9B5B780E4C6E4FCEA2BDA3A4764A9120=iSpace.SetGridDataSource(querySource9B5B780E4C6E4FCEA2BDA3A4764A9120, _objectFactory.GetGridRPP(""ReimbursementBillDetails""),@""EXEC UpdateFormGridDataC9ACCA847AF347E79133D777BE46A656 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','C9ACCA84-7AF3-47E7-9133-D777BE46A656','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""MFG_P2_ReimbursementDetailsId""].Value + @""','"" + ISpace[""MFG_P2_ReimbursementId""].Value + @""','"" + ISpace[""MFG_P2_BillNo""].Value + @""','"" + ISpace[""MFG_P2_BillDate""].Value + @""',"" + ISpace[""MFG_P2_BillDocument""].Value + @"",'"" + ISpace[""MFG_P2_ItemDescription""].Value + @""',"" + ISpace[""MFG_P2_Amount""].Value + @"",'"" + ISpace[""growid""].Value + @""'"");iSpace.InsertGridBindDetails(""ReimbursementBillDetails"",""11"",querySource9B5B780E4C6E4FCEA2BDA3A4764A9120,""EXEC UpdateFormGridDataC9ACCA847AF347E79133D777BE46A656 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','C9ACCA84-7AF3-47E7-9133-D777BE46A656','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""MFG_P2_ReimbursementDetailsId""].Value + @""','"" + ISpace[""MFG_P2_ReimbursementId""].Value + @""','"" + ISpace[""MFG_P2_BillNo""].Value + @""','"" + ISpace[""MFG_P2_BillDate""].Value + @""',"" + ISpace[""MFG_P2_BillDocument""].Value + @"",'"" + ISpace[""MFG_P2_ItemDescription""].Value + @""',"" + ISpace[""MFG_P2_Amount""].Value + @"",'"" + ISpace[""growid""].Value + @""'"",_objectFactory.GetGridRPP(""ReimbursementBillDetails""));");
base.WriteDebugInfo(@"EXEC UpdateFormGridDataC9ACCA847AF347E79133D777BE46A656 '@@gv_InstanceId','@@gv_ProcessMapId','C9ACCA84-7AF3-47E7-9133-D777BE46A656','@@gv_ActivityMapId','#MFG_P2_ReimbursementDetailsId','#MFG_P2_ReimbursementId','#MFG_P2_BillNo','#MFG_P2_BillDate',#MFG_P2_BillDocument,'#MFG_P2_ItemDescription',#MFG_P2_Amount,'#growid'");


List<Triplet<string, short, short?>> result9EA07CACF2274E83A5EE8C316E74D75C=acdataIspaceC4E2EC4C58BD44FB91D13D8E475D6C14.GetQueryExpressionBindings("9EA07CAC-F227-4E83-A5EE-8C316E74D75C");
iSpace.SetGridData(result9B5B780E4C6E4FCEA2BDA3A4764A9120,result9EA07CACF2274E83A5EE8C316E74D75C,"ReimbursementBillDetails",ref ISpace);
iSpace.UpdateGridBindDetails("ReimbursementBillDetails",result9EA07CACF2274E83A5EE8C316E74D75C);
}
object MG_P2_Amount=iSpace.Sum("[1D198218-D4AF-4E09-9A9D-119D03D0C3BA]","MG_P2_Amount","",ISpace["gv_instanceid"].Value);
ISpace["MF_P1_TotalAmount"].Value=Convert.ChangeType(MG_P2_Amount, MG_P2_Amount.GetType());;
base.WriteDebugInfo(@"object MG_P2_Amount=iSpace.Sum(""[1D198218-D4AF-4E09-9A9D-119D03D0C3BA]"",""MG_P2_Amount"","""",ISpace[""gv_instanceid""].Value);
ISpace[""MF_P1_TotalAmount""].Value=Convert.ChangeType(MG_P2_Amount, MG_P2_Amount.GetType());;");
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
if (_elementBase != null)  iSpace.SetLoopExpressionData("ReimbursementFundDetails","84AEB9E0-3009-4426-AB92-AAF06D2B42AF",_objectFactory.GetGridRPP("ReimbursementFundDetails"),_elementBase.GetGridLoopQuery("84AEB9E0-3009-4426-AB92-AAF06D2B42AF","ReimbursementFundDetails",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""ReimbursementFundDetails"",ref ISpace);

foreach(var gridChild in ISpace[""ReimbursementFundDetails""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
}
if(ISpace["growid"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""growid""].Value=="""")");

var querySourceCBB3928101F44B3AB89247A0222DAFBA =GetQueryExpressionDataSource("CBB39281-01F4-4B3A-B892-47A0222DAFBA");

DataTable resultCBB3928101F44B3AB89247A0222DAFBA=iSpace.SetGridDataSource(querySourceCBB3928101F44B3AB89247A0222DAFBA, _objectFactory.GetGridRPP("ReimbursementFundDetails"),@"EXEC AddFormGridDataD85301F7BAF94BE8A2B174E5CBB3D054 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','D85301F7-BAF9-4BE8-A2B1-74E5CBB3D054','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["MFG_P3_FundDetailsId"].Value + @"','" + ISpace["MFG_P3_ReimbursementId"].Value + @"','" + ISpace["MFG_P3_FundTypeId"].Value + @"','" + ISpace["MFG_P3_ProjectDetailsId"].Value + @"','" + ISpace["MFG_P3_BudgetHeadId"].Value + @"','" + ISpace["MFG_P3_Amount"].Value + @"','" + ISpace["growid"].Value + @"'");

iSpace.InsertGridBindDetails("ReimbursementFundDetails","11",querySourceCBB3928101F44B3AB89247A0222DAFBA,"EXEC AddFormGridDataD85301F7BAF94BE8A2B174E5CBB3D054 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','D85301F7-BAF9-4BE8-A2B1-74E5CBB3D054','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["MFG_P3_FundDetailsId"].Value + @"','" + ISpace["MFG_P3_ReimbursementId"].Value + @"','" + ISpace["MFG_P3_FundTypeId"].Value + @"','" + ISpace["MFG_P3_ProjectDetailsId"].Value + @"','" + ISpace["MFG_P3_BudgetHeadId"].Value + @"','" + ISpace["MFG_P3_Amount"].Value + @"','" + ISpace["growid"].Value + @"'",_objectFactory.GetGridRPP("ReimbursementFundDetails"));

base.WriteDebugInfo(@"var querySourceCBB3928101F44B3AB89247A0222DAFBA =GetQueryExpressionDataSource(""CBB39281-01F4-4B3A-B892-47A0222DAFBA"");DataTable resultCBB3928101F44B3AB89247A0222DAFBA=iSpace.SetGridDataSource(querySourceCBB3928101F44B3AB89247A0222DAFBA, _objectFactory.GetGridRPP(""ReimbursementFundDetails""),@""EXEC AddFormGridDataD85301F7BAF94BE8A2B174E5CBB3D054 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','D85301F7-BAF9-4BE8-A2B1-74E5CBB3D054','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""MFG_P3_FundDetailsId""].Value + @""','"" + ISpace[""MFG_P3_ReimbursementId""].Value + @""','"" + ISpace[""MFG_P3_FundTypeId""].Value + @""','"" + ISpace[""MFG_P3_ProjectDetailsId""].Value + @""','"" + ISpace[""MFG_P3_BudgetHeadId""].Value + @""','"" + ISpace[""MFG_P3_Amount""].Value + @""','"" + ISpace[""growid""].Value + @""'"");iSpace.InsertGridBindDetails(""ReimbursementFundDetails"",""11"",querySourceCBB3928101F44B3AB89247A0222DAFBA,""EXEC AddFormGridDataD85301F7BAF94BE8A2B174E5CBB3D054 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','D85301F7-BAF9-4BE8-A2B1-74E5CBB3D054','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""MFG_P3_FundDetailsId""].Value + @""','"" + ISpace[""MFG_P3_ReimbursementId""].Value + @""','"" + ISpace[""MFG_P3_FundTypeId""].Value + @""','"" + ISpace[""MFG_P3_ProjectDetailsId""].Value + @""','"" + ISpace[""MFG_P3_BudgetHeadId""].Value + @""','"" + ISpace[""MFG_P3_Amount""].Value + @""','"" + ISpace[""growid""].Value + @""'"",_objectFactory.GetGridRPP(""ReimbursementFundDetails""));");
base.WriteDebugInfo(@"EXEC AddFormGridDataD85301F7BAF94BE8A2B174E5CBB3D054 '@@gv_InstanceId','@@gv_ProcessMapId','D85301F7-BAF9-4BE8-A2B1-74E5CBB3D054','@@gv_ActivityMapId','#MFG_P3_FundDetailsId','#MFG_P3_ReimbursementId','#MFG_P3_FundTypeId','#MFG_P3_ProjectDetailsId','#MFG_P3_BudgetHeadId',#MFG_P3_Amount,'#growid'");


List<Triplet<string, short, short?>> result25A00CF73B354322B4DFFE24D90229BC=acdataIspaceC4E2EC4C58BD44FB91D13D8E475D6C14.GetQueryExpressionBindings("25A00CF7-3B35-4322-B4DF-FE24D90229BC");
iSpace.SetGridData(resultCBB3928101F44B3AB89247A0222DAFBA,result25A00CF73B354322B4DFFE24D90229BC,"ReimbursementFundDetails",ref ISpace);
iSpace.UpdateGridBindDetails("ReimbursementFundDetails",result25A00CF73B354322B4DFFE24D90229BC);
}
else
{
base.WriteDebugInfo(@"else");

var querySource334BDAE0A76B4B0F84BCAEF7F4F927FE =GetQueryExpressionDataSource("334BDAE0-A76B-4B0F-84BC-AEF7F4F927FE");

DataTable result334BDAE0A76B4B0F84BCAEF7F4F927FE=iSpace.SetGridDataSource(querySource334BDAE0A76B4B0F84BCAEF7F4F927FE, _objectFactory.GetGridRPP("ReimbursementFundDetails"),@"EXEC UpdateFormGridDataD85301F7BAF94BE8A2B174E5CBB3D054 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','D85301F7-BAF9-4BE8-A2B1-74E5CBB3D054','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["MFG_P3_FundDetailsId"].Value + @"','" + ISpace["MFG_P3_ReimbursementId"].Value + @"','" + ISpace["MFG_P3_FundTypeId"].Value + @"','" + ISpace["MFG_P3_ProjectDetailsId"].Value + @"','" + ISpace["MFG_P3_BudgetHeadId"].Value + @"'," + ISpace["MFG_P3_Amount"].Value + @",'" + ISpace["growid"].Value + @"'");

iSpace.InsertGridBindDetails("ReimbursementFundDetails","11",querySource334BDAE0A76B4B0F84BCAEF7F4F927FE,"EXEC UpdateFormGridDataD85301F7BAF94BE8A2B174E5CBB3D054 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','D85301F7-BAF9-4BE8-A2B1-74E5CBB3D054','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["MFG_P3_FundDetailsId"].Value + @"','" + ISpace["MFG_P3_ReimbursementId"].Value + @"','" + ISpace["MFG_P3_FundTypeId"].Value + @"','" + ISpace["MFG_P3_ProjectDetailsId"].Value + @"','" + ISpace["MFG_P3_BudgetHeadId"].Value + @"'," + ISpace["MFG_P3_Amount"].Value + @",'" + ISpace["growid"].Value + @"'",_objectFactory.GetGridRPP("ReimbursementFundDetails"));

base.WriteDebugInfo(@"var querySource334BDAE0A76B4B0F84BCAEF7F4F927FE =GetQueryExpressionDataSource(""334BDAE0-A76B-4B0F-84BC-AEF7F4F927FE"");DataTable result334BDAE0A76B4B0F84BCAEF7F4F927FE=iSpace.SetGridDataSource(querySource334BDAE0A76B4B0F84BCAEF7F4F927FE, _objectFactory.GetGridRPP(""ReimbursementFundDetails""),@""EXEC UpdateFormGridDataD85301F7BAF94BE8A2B174E5CBB3D054 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','D85301F7-BAF9-4BE8-A2B1-74E5CBB3D054','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""MFG_P3_FundDetailsId""].Value + @""','"" + ISpace[""MFG_P3_ReimbursementId""].Value + @""','"" + ISpace[""MFG_P3_FundTypeId""].Value + @""','"" + ISpace[""MFG_P3_ProjectDetailsId""].Value + @""','"" + ISpace[""MFG_P3_BudgetHeadId""].Value + @""',"" + ISpace[""MFG_P3_Amount""].Value + @"",'"" + ISpace[""growid""].Value + @""'"");iSpace.InsertGridBindDetails(""ReimbursementFundDetails"",""11"",querySource334BDAE0A76B4B0F84BCAEF7F4F927FE,""EXEC UpdateFormGridDataD85301F7BAF94BE8A2B174E5CBB3D054 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','D85301F7-BAF9-4BE8-A2B1-74E5CBB3D054','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""MFG_P3_FundDetailsId""].Value + @""','"" + ISpace[""MFG_P3_ReimbursementId""].Value + @""','"" + ISpace[""MFG_P3_FundTypeId""].Value + @""','"" + ISpace[""MFG_P3_ProjectDetailsId""].Value + @""','"" + ISpace[""MFG_P3_BudgetHeadId""].Value + @""',"" + ISpace[""MFG_P3_Amount""].Value + @"",'"" + ISpace[""growid""].Value + @""'"",_objectFactory.GetGridRPP(""ReimbursementFundDetails""));");
base.WriteDebugInfo(@"EXEC UpdateFormGridDataD85301F7BAF94BE8A2B174E5CBB3D054 '@@gv_InstanceId','@@gv_ProcessMapId','D85301F7-BAF9-4BE8-A2B1-74E5CBB3D054','@@gv_ActivityMapId','#MFG_P3_FundDetailsId','#MFG_P3_ReimbursementId','#MFG_P3_FundTypeId','#MFG_P3_ProjectDetailsId','#MFG_P3_BudgetHeadId',#MFG_P3_Amount,'#growid'");


List<Triplet<string, short, short?>> resultEFFC55B685564D91AE91384F68B422FF=acdataIspaceC4E2EC4C58BD44FB91D13D8E475D6C14.GetQueryExpressionBindings("EFFC55B6-8556-4D91-AE91-384F68B422FF");
iSpace.SetGridData(result334BDAE0A76B4B0F84BCAEF7F4F927FE,resultEFFC55B685564D91AE91384F68B422FF,"ReimbursementFundDetails",ref ISpace);
iSpace.UpdateGridBindDetails("ReimbursementFundDetails",resultEFFC55B685564D91AE91384F68B422FF);
}
base.WriteDebugInfo(@"#ReimbursementFundDetails[Rows]");
iSpace.GetLoopExpressionData("ReimbursementFundDetails",ref ISpace);

foreach(var gridChild in ISpace["ReimbursementFundDetails"].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 



ISpace["MG_P3_PackageProcessMapId"].Value=ISpace["M_PackageProcessMapId"].Value;
base.WriteDebugInfo(@"

ISpace[""MG_P3_PackageProcessMapId""].Value=ISpace[""M_PackageProcessMapId""].Value;");


ISpace["MG_P3_EmployeeBaicInfoId"].Value=ISpace["UC_EmployeeBaicInfoId"].Value;
base.WriteDebugInfo(@"

ISpace[""MG_P3_EmployeeBaicInfoId""].Value=ISpace[""UC_EmployeeBaicInfoId""].Value;");
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("ReimbursementFundDetails","84AEB9E0-3009-4426-AB92-AAF06D2B42AF",_objectFactory.GetGridRPP("ReimbursementFundDetails"),_elementBase.GetGridLoopQuery("84AEB9E0-3009-4426-AB92-AAF06D2B42AF","ReimbursementFundDetails",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""ReimbursementFundDetails"",ref ISpace);

foreach(var gridChild in ISpace[""ReimbursementFundDetails""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
object MG_P3_Amount=iSpace.Sum("[84AEB9E0-3009-4426-AB92-AAF06D2B42AF]","MG_P3_Amount","",ISpace["gv_instanceid"].Value);
ISpace["MFG_P3_OverallAmount"].Value=Convert.ChangeType(MG_P3_Amount, MG_P3_Amount.GetType());;
base.WriteDebugInfo(@"object MG_P3_Amount=iSpace.Sum(""[84AEB9E0-3009-4426-AB92-AAF06D2B42AF]"",""MG_P3_Amount"","""",ISpace[""gv_instanceid""].Value);
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
private void SubscribeElementEvents_submitform (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"SubmitForm-OnClick");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC UpsertActivityTrailLogDetails '@@gv_TenantId','#M_InstanceId','@@gv_ActivityName','#MF_P1_Remarks','@@gv_UserName','#M_SourceActivityMapId','#SetDestinationTo','@@gv_UserId','#M_IsSourceStep'");

var querySourcebefdd5b207e912dc5d3682026e5e2134 =GetQueryExpressionDataSource("befdd5b2-07e9-12dc-5d36-82026e5e2134");
Dictionary<short,object> resultbefdd5b207e912dc5d3682026e5e2134=iSpace.ExecuteQuery(querySourcebefdd5b207e912dc5d3682026e5e2134,@"EXEC UpsertActivityTrailLogDetails '" + ISpace["gv_tenantid"].Value + @"','" + ISpace["M_InstanceId"].Value + @"','" + ISpace["gv_activityname"].Value + @"','" + ISpace["MF_P1_Remarks"].Value + @"','" + ISpace["gv_username"].Value + @"','" + ISpace["M_SourceActivityMapId"].Value + @"','" + ISpace["SetDestinationTo"].Value + @"','" + ISpace["gv_userid"].Value + @"','" + ISpace["M_IsSourceStep"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourcebefdd5b207e912dc5d3682026e5e2134 =GetQueryExpressionDataSource(""befdd5b2-07e9-12dc-5d36-82026e5e2134"");Dictionary<short,object> resultbefdd5b207e912dc5d3682026e5e2134=iSpace.ExecuteQuery(querySourcebefdd5b207e912dc5d3682026e5e2134,@""EXEC UpsertActivityTrailLogDetails '"" + ISpace[""gv_tenantid""].Value + @""','"" + ISpace[""M_InstanceId""].Value + @""','"" + ISpace[""gv_activityname""].Value + @""','"" + ISpace[""MF_P1_Remarks""].Value + @""','"" + ISpace[""gv_username""].Value + @""','"" + ISpace[""M_SourceActivityMapId""].Value + @""','"" + ISpace[""SetDestinationTo""].Value + @""','"" + ISpace[""gv_userid""].Value + @""','"" + ISpace[""M_IsSourceStep""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultbefdd5b207e912dc5d3682026e5e2134!=null) && (resultbefdd5b207e912dc5d3682026e5e2134.Count!=0))
{
if(resultbefdd5b207e912dc5d3682026e5e2134.ContainsKey(0))
ISpace["ExecutionMessage"].Value = resultbefdd5b207e912dc5d3682026e5e2134[0];
}
else{
ISpace["ExecutionMessage"].Value = null;
}
}
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
ISpace["MF_P1_ApplicationStatus"].Value="A";
base.WriteDebugInfo(@"ISpace[""MF_P1_ApplicationStatus""].Value=""A"";");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC UpsertProjectReimbursement '#MF_P1_ReimbursementId','#UC_EmployeeBaicInfoId','#MF_P1_TotalAmount','@@gv_UserId','#MF_P1_ApplicationStatus','#M_ReimbursementType','#M_Classification','#M_SubClassication','@@gv_UserId'");

var querySourced58dc3c8687f1ebcd4754068de464713 =GetQueryExpressionDataSource("d58dc3c8-687f-1ebc-d475-4068de464713");
Dictionary<short,object> resultd58dc3c8687f1ebcd4754068de464713=iSpace.ExecuteQuery(querySourced58dc3c8687f1ebcd4754068de464713,@"EXEC UpsertProjectReimbursement '" + ISpace["MF_P1_ReimbursementId"].Value + @"','" + ISpace["UC_EmployeeBaicInfoId"].Value + @"','" + ISpace["MF_P1_TotalAmount"].Value + @"','" + ISpace["gv_userid"].Value + @"','" + ISpace["MF_P1_ApplicationStatus"].Value + @"','" + ISpace["M_ReimbursementType"].Value + @"','" + ISpace["M_Classification"].Value + @"','" + ISpace["M_SubClassication"].Value + @"','" + ISpace["gv_userid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourced58dc3c8687f1ebcd4754068de464713 =GetQueryExpressionDataSource(""d58dc3c8-687f-1ebc-d475-4068de464713"");Dictionary<short,object> resultd58dc3c8687f1ebcd4754068de464713=iSpace.ExecuteQuery(querySourced58dc3c8687f1ebcd4754068de464713,@""EXEC UpsertProjectReimbursement '"" + ISpace[""MF_P1_ReimbursementId""].Value + @""','"" + ISpace[""UC_EmployeeBaicInfoId""].Value + @""','"" + ISpace[""MF_P1_TotalAmount""].Value + @""','"" + ISpace[""gv_userid""].Value + @""','"" + ISpace[""MF_P1_ApplicationStatus""].Value + @""','"" + ISpace[""M_ReimbursementType""].Value + @""','"" + ISpace[""M_Classification""].Value + @""','"" + ISpace[""M_SubClassication""].Value + @""','"" + ISpace[""gv_userid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultd58dc3c8687f1ebcd4754068de464713!=null) && (resultd58dc3c8687f1ebcd4754068de464713.Count!=0))
{
if(resultd58dc3c8687f1ebcd4754068de464713.ContainsKey(0))
ISpace["ExecutionMessage"].Value = resultd58dc3c8687f1ebcd4754068de464713[0];
}
else{
ISpace["ExecutionMessage"].Value = null;
}
base.WriteDebugInfo(@"EXEC UpsertProjectReimbursementFundDetails '#MG_P3_FundDetailsId','#MF_P1_ReimbursementId','#MG_P3_FundTypeId','#MG_P3_ProjectDetailsId','#MG_P3_BudgetHeadId','#MG_P3_Amount'");

var querySource478236c45c793773d35402c74092c916 =GetQueryExpressionDataSource("478236c4-5c79-3773-d354-02c74092c916");
Dictionary<short,object> result478236c45c793773d35402c74092c916=iSpace.ExecuteQuery(querySource478236c45c793773d35402c74092c916,@"EXEC UpsertProjectReimbursementFundDetails '" + ISpace["MG_P3_FundDetailsId"].Value + @"','" + ISpace["MF_P1_ReimbursementId"].Value + @"','" + ISpace["MG_P3_FundTypeId"].Value + @"','" + ISpace["MG_P3_ProjectDetailsId"].Value + @"','" + ISpace["MG_P3_BudgetHeadId"].Value + @"','" + ISpace["MG_P3_Amount"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource478236c45c793773d35402c74092c916 =GetQueryExpressionDataSource(""478236c4-5c79-3773-d354-02c74092c916"");Dictionary<short,object> result478236c45c793773d35402c74092c916=iSpace.ExecuteQuery(querySource478236c45c793773d35402c74092c916,@""EXEC UpsertProjectReimbursementFundDetails '"" + ISpace[""MG_P3_FundDetailsId""].Value + @""','"" + ISpace[""MF_P1_ReimbursementId""].Value + @""','"" + ISpace[""MG_P3_FundTypeId""].Value + @""','"" + ISpace[""MG_P3_ProjectDetailsId""].Value + @""','"" + ISpace[""MG_P3_BudgetHeadId""].Value + @""','"" + ISpace[""MG_P3_Amount""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result478236c45c793773d35402c74092c916!=null) && (result478236c45c793773d35402c74092c916.Count!=0))
{
if(result478236c45c793773d35402c74092c916.ContainsKey(0))
ISpace["ExecutionMessage"].Value = result478236c45c793773d35402c74092c916[0];
}
else{
ISpace["ExecutionMessage"].Value = null;
}
base.WriteDebugInfo(@"EXEC UpsertProjectReimbursementBillDetails '#MG_P2_ReimbursementDetailsId','#MF_P1_ReimbursementId','#MG_P2_BillNo','#MG_P2_BillDate',NULL,'#MG_P2_ItemDescription','#MG_P2_Amount'");

var querySource0ac6af4e84d7e8d409946108bb08331c =GetQueryExpressionDataSource("0ac6af4e-84d7-e8d4-0994-6108bb08331c");
Dictionary<short,object> result0ac6af4e84d7e8d409946108bb08331c=iSpace.ExecuteQuery(querySource0ac6af4e84d7e8d409946108bb08331c,@"EXEC UpsertProjectReimbursementBillDetails '" + ISpace["MG_P2_ReimbursementDetailsId"].Value + @"','" + ISpace["MF_P1_ReimbursementId"].Value + @"','" + ISpace["MG_P2_BillNo"].Value + @"','" + ISpace["MG_P2_BillDate"].Value + @"',NULL,'" + ISpace["MG_P2_ItemDescription"].Value + @"','" + ISpace["MG_P2_Amount"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource0ac6af4e84d7e8d409946108bb08331c =GetQueryExpressionDataSource(""0ac6af4e-84d7-e8d4-0994-6108bb08331c"");Dictionary<short,object> result0ac6af4e84d7e8d409946108bb08331c=iSpace.ExecuteQuery(querySource0ac6af4e84d7e8d409946108bb08331c,@""EXEC UpsertProjectReimbursementBillDetails '"" + ISpace[""MG_P2_ReimbursementDetailsId""].Value + @""','"" + ISpace[""MF_P1_ReimbursementId""].Value + @""','"" + ISpace[""MG_P2_BillNo""].Value + @""','"" + ISpace[""MG_P2_BillDate""].Value + @""',NULL,'"" + ISpace[""MG_P2_ItemDescription""].Value + @""','"" + ISpace[""MG_P2_Amount""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result0ac6af4e84d7e8d409946108bb08331c!=null) && (result0ac6af4e84d7e8d409946108bb08331c.Count!=0))
{
if(result0ac6af4e84d7e8d409946108bb08331c.ContainsKey(0))
ISpace["ExecutionMessage"].Value = result0ac6af4e84d7e8d409946108bb08331c[0];
}
else{
ISpace["ExecutionMessage"].Value = null;
}
base.WriteDebugInfo(@"EXEC UpsertDocumentDetails '#M_DocumentDetailsId','#M_InstanceId','#M_PackageProcessMapId','#M_DocumentName','#M_UploadDcoument',' @@gv_UserId'");

var querySource17adfd2bbf7aa7968851003732efc9c7 =GetQueryExpressionDataSource("17adfd2b-bf7a-a796-8851-003732efc9c7");
Dictionary<short,object> result17adfd2bbf7aa7968851003732efc9c7=iSpace.ExecuteQuery(querySource17adfd2bbf7aa7968851003732efc9c7,@"EXEC UpsertDocumentDetails '" + ISpace["M_DocumentDetailsId"].Value + @"','" + ISpace["M_InstanceId"].Value + @"','" + ISpace["M_PackageProcessMapId"].Value + @"','" + ISpace["M_DocumentName"].Value + @"','" + ISpace["M_UploadDcoument"].Value + @"',' " + ISpace["gv_userid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource17adfd2bbf7aa7968851003732efc9c7 =GetQueryExpressionDataSource(""17adfd2b-bf7a-a796-8851-003732efc9c7"");Dictionary<short,object> result17adfd2bbf7aa7968851003732efc9c7=iSpace.ExecuteQuery(querySource17adfd2bbf7aa7968851003732efc9c7,@""EXEC UpsertDocumentDetails '"" + ISpace[""M_DocumentDetailsId""].Value + @""','"" + ISpace[""M_InstanceId""].Value + @""','"" + ISpace[""M_PackageProcessMapId""].Value + @""','"" + ISpace[""M_DocumentName""].Value + @""','"" + ISpace[""M_UploadDcoument""].Value + @""',' "" + ISpace[""gv_userid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result17adfd2bbf7aa7968851003732efc9c7!=null) && (result17adfd2bbf7aa7968851003732efc9c7.Count!=0))
{
if(result17adfd2bbf7aa7968851003732efc9c7.ContainsKey(0))
ISpace["ExecutionMessage"].Value = result17adfd2bbf7aa7968851003732efc9c7[0];
}
else{
ISpace["ExecutionMessage"].Value = null;
}
}
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
base.WriteDebugInfo(@"EXEC [UpsertProjectBudgetDetails] 6,'#MG_P3_ProjectDetailsId','','#MG_P3_Amount','#MG_P3_BudgetHeadId',1,'#MG_P3_FundTypeId'");

var querySourceBA4985A9C4A24DC6BBD1661F0431909A =GetQueryExpressionDataSource("BA4985A9-C4A2-4DC6-BBD1-661F0431909A");
Dictionary<short,object> resultBA4985A9C4A24DC6BBD1661F0431909A=iSpace.ExecuteQuery(querySourceBA4985A9C4A24DC6BBD1661F0431909A,@"EXEC [UpsertProjectBudgetDetails] 6,'" + ISpace["MG_P3_ProjectDetailsId"].Value + @"','','" + ISpace["MG_P3_Amount"].Value + @"','" + ISpace["MG_P3_BudgetHeadId"].Value + @"',1,'" + ISpace["MG_P3_FundTypeId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceBA4985A9C4A24DC6BBD1661F0431909A =GetQueryExpressionDataSource(""BA4985A9-C4A2-4DC6-BBD1-661F0431909A"");Dictionary<short,object> resultBA4985A9C4A24DC6BBD1661F0431909A=iSpace.ExecuteQuery(querySourceBA4985A9C4A24DC6BBD1661F0431909A,@""EXEC [UpsertProjectBudgetDetails] 6,'"" + ISpace[""MG_P3_ProjectDetailsId""].Value + @""','','"" + ISpace[""MG_P3_Amount""].Value + @""','"" + ISpace[""MG_P3_BudgetHeadId""].Value + @""',1,'"" + ISpace[""MG_P3_FundTypeId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultBA4985A9C4A24DC6BBD1661F0431909A!=null) && (resultBA4985A9C4A24DC6BBD1661F0431909A.Count!=0))
{
if(resultBA4985A9C4A24DC6BBD1661F0431909A.ContainsKey(0))
ISpace["M_UpdateCount"].Value = resultBA4985A9C4A24DC6BBD1661F0431909A[0];
}
else{
ISpace["M_UpdateCount"].Value = null;
}
}
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("ReimbursementFundDetails","84AEB9E0-3009-4426-AB92-AAF06D2B42AF",_objectFactory.GetGridRPP("ReimbursementFundDetails"),_elementBase.GetGridLoopQuery("84AEB9E0-3009-4426-AB92-AAF06D2B42AF","ReimbursementFundDetails",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""ReimbursementFundDetails"",ref ISpace);

foreach(var gridChild in ISpace[""ReimbursementFundDetails""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
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
base.WriteDebugInfo(@"EXEC UpsertUserRequestsUpdation '#M_InstanceId','#SetDestinationTo','#M_Stage','#M_Status','@@gv_UserId','#M_RequestId'");

var querySource87cbcf911fba16fd3029f8855a072138 =GetQueryExpressionDataSource("87cbcf91-1fba-16fd-3029-f8855a072138");
Dictionary<short,object> result87cbcf911fba16fd3029f8855a072138=iSpace.ExecuteQuery(querySource87cbcf911fba16fd3029f8855a072138,@"EXEC UpsertUserRequestsUpdation '" + ISpace["M_InstanceId"].Value + @"','" + ISpace["SetDestinationTo"].Value + @"','" + ISpace["M_Stage"].Value + @"','" + ISpace["M_Status"].Value + @"','" + ISpace["gv_userid"].Value + @"','" + ISpace["M_RequestId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource87cbcf911fba16fd3029f8855a072138 =GetQueryExpressionDataSource(""87cbcf91-1fba-16fd-3029-f8855a072138"");Dictionary<short,object> result87cbcf911fba16fd3029f8855a072138=iSpace.ExecuteQuery(querySource87cbcf911fba16fd3029f8855a072138,@""EXEC UpsertUserRequestsUpdation '"" + ISpace[""M_InstanceId""].Value + @""','"" + ISpace[""SetDestinationTo""].Value + @""','"" + ISpace[""M_Stage""].Value + @""','"" + ISpace[""M_Status""].Value + @""','"" + ISpace[""gv_userid""].Value + @""','"" + ISpace[""M_RequestId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result87cbcf911fba16fd3029f8855a072138!=null) && (result87cbcf911fba16fd3029f8855a072138.Count!=0))
{
if(result87cbcf911fba16fd3029f8855a072138.ContainsKey(0))
ISpace["ExecutionMessage"].Value = result87cbcf911fba16fd3029f8855a072138[0];
}
else{
ISpace["ExecutionMessage"].Value = null;
}
ISpace["Message"].Value=@"Submitted Successfully";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Submitted Successfully"";");
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
base.WriteDebugInfo(@"EXEC LoadFormGridDataD85301F7BAF94BE8A2B174E5CBB3D054 '@@gv_InstanceId','@@gv_ProcessMapId','D85301F7-BAF9-4BE8-A2B1-74E5CBB3D054','@@gv_ActivityMapId','#growid'");

var querySource1F49FB0DA84D47A58942368F58A2D97A =GetQueryExpressionDataSource("1F49FB0D-A84D-47A5-8942-368F58A2D97A");
Dictionary<short,object> result1F49FB0DA84D47A58942368F58A2D97A=iSpace.ExecuteQuery(querySource1F49FB0DA84D47A58942368F58A2D97A,@"EXEC LoadFormGridDataD85301F7BAF94BE8A2B174E5CBB3D054 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','D85301F7-BAF9-4BE8-A2B1-74E5CBB3D054','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["growid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource1F49FB0DA84D47A58942368F58A2D97A =GetQueryExpressionDataSource(""1F49FB0D-A84D-47A5-8942-368F58A2D97A"");Dictionary<short,object> result1F49FB0DA84D47A58942368F58A2D97A=iSpace.ExecuteQuery(querySource1F49FB0DA84D47A58942368F58A2D97A,@""EXEC LoadFormGridDataD85301F7BAF94BE8A2B174E5CBB3D054 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','D85301F7-BAF9-4BE8-A2B1-74E5CBB3D054','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""growid""].Value + @""'"",false);");
base.WriteDebugInfo(@"EXEC LoadFormGridDataD85301F7BAF94BE8A2B174E5CBB3D054 '@@gv_InstanceId','@@gv_ProcessMapId','D85301F7-BAF9-4BE8-A2B1-74E5CBB3D054','@@gv_ActivityMapId','#growid'");

if((result1F49FB0DA84D47A58942368F58A2D97A!=null) && (result1F49FB0DA84D47A58942368F58A2D97A.Count!=0))
{
if(result1F49FB0DA84D47A58942368F58A2D97A.ContainsKey(4))
ISpace["MFG_P3_BudgetHeadId"].Value = result1F49FB0DA84D47A58942368F58A2D97A[4];
if(result1F49FB0DA84D47A58942368F58A2D97A.ContainsKey(3))
ISpace["MFG_P3_ProjectDetailsId"].Value = result1F49FB0DA84D47A58942368F58A2D97A[3];
if(result1F49FB0DA84D47A58942368F58A2D97A.ContainsKey(2))
ISpace["MFG_P3_FundTypeId"].Value = result1F49FB0DA84D47A58942368F58A2D97A[2];
if(result1F49FB0DA84D47A58942368F58A2D97A.ContainsKey(5))
ISpace["MFG_P3_Amount"].Value = result1F49FB0DA84D47A58942368F58A2D97A[5];
if(result1F49FB0DA84D47A58942368F58A2D97A.ContainsKey(1))
ISpace["MFG_P3_ReimbursementId"].Value = result1F49FB0DA84D47A58942368F58A2D97A[1];
if(result1F49FB0DA84D47A58942368F58A2D97A.ContainsKey(0))
ISpace["MFG_P3_FundDetailsId"].Value = result1F49FB0DA84D47A58942368F58A2D97A[0];
}
else{
ISpace["MFG_P3_BudgetHeadId"].Value = null;ISpace["MFG_P3_ProjectDetailsId"].Value = null;ISpace["MFG_P3_FundTypeId"].Value = null;ISpace["MFG_P3_Amount"].Value = null;ISpace["MFG_P3_ReimbursementId"].Value = null;ISpace["MFG_P3_FundDetailsId"].Value = null;
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
base.WriteDebugInfo(@"Exec GetStageStatus 1,'','','#M_MoveToValue','#M_SourceActivityMapId'");

var querySource959A027E58AA471DADF1501D54E16A1B =GetQueryExpressionDataSource("959A027E-58AA-471D-ADF1-501D54E16A1B");
Dictionary<short,object> result959A027E58AA471DADF1501D54E16A1B=iSpace.ExecuteQuery(querySource959A027E58AA471DADF1501D54E16A1B,@"Exec GetStageStatus 1,'','','" + ISpace["M_MoveToValue"].Value + @"','" + ISpace["M_SourceActivityMapId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource959A027E58AA471DADF1501D54E16A1B =GetQueryExpressionDataSource(""959A027E-58AA-471D-ADF1-501D54E16A1B"");Dictionary<short,object> result959A027E58AA471DADF1501D54E16A1B=iSpace.ExecuteQuery(querySource959A027E58AA471DADF1501D54E16A1B,@""Exec GetStageStatus 1,'','','"" + ISpace[""M_MoveToValue""].Value + @""','"" + ISpace[""M_SourceActivityMapId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result959A027E58AA471DADF1501D54E16A1B!=null) && (result959A027E58AA471DADF1501D54E16A1B.Count!=0))
{
if(result959A027E58AA471DADF1501D54E16A1B.ContainsKey(1))
ISpace["M_RemarksMandatory"].Value = result959A027E58AA471DADF1501D54E16A1B[1];
if(result959A027E58AA471DADF1501D54E16A1B.ContainsKey(5))
ISpace["M_IsflowReturned"].Value = result959A027E58AA471DADF1501D54E16A1B[5];
if(result959A027E58AA471DADF1501D54E16A1B.ContainsKey(6))
ISpace["M_IsCancelReject"].Value = result959A027E58AA471DADF1501D54E16A1B[6];
if(result959A027E58AA471DADF1501D54E16A1B.ContainsKey(4))
ISpace["M_FieldMandatory"].Value = result959A027E58AA471DADF1501D54E16A1B[4];
if(result959A027E58AA471DADF1501D54E16A1B.ContainsKey(3))
ISpace["M_SaveDomainData"].Value = result959A027E58AA471DADF1501D54E16A1B[3];
if(result959A027E58AA471DADF1501D54E16A1B.ContainsKey(7))
ISpace["M_Stage"].Value = result959A027E58AA471DADF1501D54E16A1B[7];
if(result959A027E58AA471DADF1501D54E16A1B.ContainsKey(0))
ISpace["M_NextStage"].Value = result959A027E58AA471DADF1501D54E16A1B[0];
if(result959A027E58AA471DADF1501D54E16A1B.ContainsKey(2))
ISpace["MF_P1_Remarks"].Value = result959A027E58AA471DADF1501D54E16A1B[2];
}
else{
ISpace["M_RemarksMandatory"].Value = null;ISpace["M_IsflowReturned"].Value = null;ISpace["M_IsCancelReject"].Value = null;ISpace["M_FieldMandatory"].Value = null;ISpace["M_SaveDomainData"].Value = null;ISpace["M_Stage"].Value = null;ISpace["M_NextStage"].Value = null;ISpace["MF_P1_Remarks"].Value = null;
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
		if(elementName.ToLower().Equals("edit_reimbursementbilldetails"))
{
			SubscribeElementEvents_edit_reimbursementbilldetails(ref dfsParam);
}
		if(elementName.ToLower().Equals("save_reimbursementbilldetails"))
{
			SubscribeElementEvents_save_reimbursementbilldetails(ref dfsParam);
}
		if(elementName.ToLower().Equals("save_reimbursementfunddetails"))
{
			SubscribeElementEvents_save_reimbursementfunddetails(ref dfsParam);
}
		if(elementName.ToLower().Equals("submitform"))
{
			SubscribeElementEvents_submitform(ref dfsParam);
}
		if(elementName.ToLower().Equals("edit_reimbursementfunddetails"))
{
			SubscribeElementEvents_edit_reimbursementfunddetails(ref dfsParam);
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
public class ISpace7B9E10F1A9E84A0C90D9F183CC3B49D0 : VirtualForm
{
IISpace iSpace = new ISpace();
AcDataISpace7B9E10F1A9E84A0C90D9F183CC3B49D0 acdataIspace7B9E10F1A9E84A0C90D9F183CC3B49D0=new AcDataISpace7B9E10F1A9E84A0C90D9F183CC3B49D0();
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

var querySource820D767A20CC4BA1AADCA484B0BFBEFA =GetQueryExpressionDataSource("820D767A-20CC-4BA1-AADC-A484B0BFBEFA");

DataTable result820D767A20CC4BA1AADCA484B0BFBEFA=iSpace.SetGridDataSource(querySource820D767A20CC4BA1AADCA484B0BFBEFA, _objectFactory.GetGridRPP("MG_RemarksDetails"),@"EXEC GetRemarks '" + ISpace["M_InstanceId"].Value + @"'");

iSpace.InsertGridBindDetails("MG_RemarksDetails","11",querySource820D767A20CC4BA1AADCA484B0BFBEFA,"EXEC GetRemarks '" + ISpace["M_InstanceId"].Value + @"'",_objectFactory.GetGridRPP("MG_RemarksDetails"));

base.WriteDebugInfo(@"var querySource820D767A20CC4BA1AADCA484B0BFBEFA =GetQueryExpressionDataSource(""820D767A-20CC-4BA1-AADC-A484B0BFBEFA"");DataTable result820D767A20CC4BA1AADCA484B0BFBEFA=iSpace.SetGridDataSource(querySource820D767A20CC4BA1AADCA484B0BFBEFA, _objectFactory.GetGridRPP(""MG_RemarksDetails""),@""EXEC GetRemarks '"" + ISpace[""M_InstanceId""].Value + @""'"");iSpace.InsertGridBindDetails(""MG_RemarksDetails"",""11"",querySource820D767A20CC4BA1AADCA484B0BFBEFA,""EXEC GetRemarks '"" + ISpace[""M_InstanceId""].Value + @""'"",_objectFactory.GetGridRPP(""MG_RemarksDetails""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> resultE57D76A324374EAF8C530F41C6AF052C=acdataIspace7B9E10F1A9E84A0C90D9F183CC3B49D0.GetQueryExpressionBindings("E57D76A3-2437-4EAF-8C53-0F41C6AF052C");
iSpace.SetGridData(result820D767A20CC4BA1AADCA484B0BFBEFA,resultE57D76A324374EAF8C530F41C6AF052C,"MG_RemarksDetails",ref ISpace);
iSpace.UpdateGridBindDetails("MG_RemarksDetails",resultE57D76A324374EAF8C530F41C6AF052C);
ISpace["MFG_P3_BudgetHeadId"].Visible="false";ISpace["MFG_P3_ProjectDetailsId"].Visible="false";ISpace["MFG_P3_Amount"].Visible="false";
base.WriteDebugInfo(@"ISpace[""MFG_P3_BudgetHeadId""].Visible=""false"";ISpace[""MFG_P3_ProjectDetailsId""].Visible=""false"";ISpace[""MFG_P3_Amount""].Visible=""false"";");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["MFG_P2_ItemDescription"].Visible="false";ISpace["MFG_P2_BillDocument"].Visible="false";ISpace["MFG_P2_ReimbursementId"].Visible="false";ISpace["MFG_P2_BillNo"].Visible="false";ISpace["MFG_P3_ReimbursementId"].Visible="false";ISpace["MF_P1_TotalAmount"].Visible="true";ISpace["MF_P1_ApplicationStatus"].Visible="false";ISpace["MF_P1_Initiatedon"].Visible="false";ISpace["MFG_P2_Amount"].Visible="false";ISpace["MF_P1_ReimbursementId"].Visible="false";ISpace["MFG_P2_ReimbursementDetailsId"].Visible="false";ISpace["MFG_P3_BudgetHeadId"].Visible="false";ISpace["MF_P1_InitatedBy"].Visible="false";ISpace["MFG_P3_ProjectDetailsId"].Visible="false";ISpace["MFG_P3_FundTypeId"].Visible="false";ISpace["MFG_P3_FundDetailsId"].Visible="false";ISpace["MFG_P3_Amount"].Visible="false";ISpace["MF_P1_UpdatedBy"].Visible="false";ISpace["MF_P1_UpdatedOn"].Visible="false";ISpace["MFG_P2_BillDate"].Visible="false";ISpace["MF_P1_EmployeeBasicInfoId"].Visible="false";
base.WriteDebugInfo(@"ISpace[""MFG_P2_ItemDescription""].Visible=""false"";ISpace[""MFG_P2_BillDocument""].Visible=""false"";ISpace[""MFG_P2_ReimbursementId""].Visible=""false"";ISpace[""MFG_P2_BillNo""].Visible=""false"";ISpace[""MFG_P3_ReimbursementId""].Visible=""false"";ISpace[""MF_P1_TotalAmount""].Visible=""true"";ISpace[""MF_P1_ApplicationStatus""].Visible=""false"";ISpace[""MF_P1_Initiatedon""].Visible=""false"";ISpace[""MFG_P2_Amount""].Visible=""false"";ISpace[""MF_P1_ReimbursementId""].Visible=""false"";ISpace[""MFG_P2_ReimbursementDetailsId""].Visible=""false"";ISpace[""MFG_P3_BudgetHeadId""].Visible=""false"";ISpace[""MF_P1_InitatedBy""].Visible=""false"";ISpace[""MFG_P3_ProjectDetailsId""].Visible=""false"";ISpace[""MFG_P3_FundTypeId""].Visible=""false"";ISpace[""MFG_P3_FundDetailsId""].Visible=""false"";ISpace[""MFG_P3_Amount""].Visible=""false"";ISpace[""MF_P1_UpdatedBy""].Visible=""false"";ISpace[""MF_P1_UpdatedOn""].Visible=""false"";ISpace[""MFG_P2_BillDate""].Visible=""false"";ISpace[""MF_P1_EmployeeBasicInfoId""].Visible=""false"";");
ISpace["MG_P2_ReimbursementId"].Visible="false";ISpace["MG_P2_BillDocument"].Visible="false";ISpace["MG_P2_BillDate"].Visible="true";ISpace["MG_P2_BillNo"].Visible="true";ISpace["MG_P2_ItemDescription"].Visible="true";ISpace["MG_P2_Amount"].Visible="true";ISpace["MG_P2_ReimbursementDetailsId"].Visible="false";
base.WriteDebugInfo(@"ISpace[""MG_P2_ReimbursementId""].Visible=""false"";ISpace[""MG_P2_BillDocument""].Visible=""false"";ISpace[""MG_P2_BillDate""].Visible=""true"";ISpace[""MG_P2_BillNo""].Visible=""true"";ISpace[""MG_P2_ItemDescription""].Visible=""true"";ISpace[""MG_P2_Amount""].Visible=""true"";ISpace[""MG_P2_ReimbursementDetailsId""].Visible=""false"";");
ISpace["MG_P3_Amount"].Visible="true";ISpace["MG_P3_BudgetHeadId"].Visible="true";ISpace["MG_P3_ProjectDetailsId"].Visible="true";ISpace["MG_P3_ReimbursementId"].Visible="false";ISpace["MG_P3_FundDetailsId"].Visible="false";ISpace["MG_P3_FundTypeId"].Visible="true";
base.WriteDebugInfo(@"ISpace[""MG_P3_Amount""].Visible=""true"";ISpace[""MG_P3_BudgetHeadId""].Visible=""true"";ISpace[""MG_P3_ProjectDetailsId""].Visible=""true"";ISpace[""MG_P3_ReimbursementId""].Visible=""false"";ISpace[""MG_P3_FundDetailsId""].Visible=""false"";ISpace[""MG_P3_FundTypeId""].Visible=""true"";");
}
if(ISpace["M_ReimbursementType"].Value=="2")
{
base.WriteDebugInfo(@"if(ISpace[""M_ReimbursementType""].Value==""2"")");
ISpace["M_Classification"].Visible="true";ISpace["M_SubClassication"].Visible="true";
base.WriteDebugInfo(@"ISpace[""M_Classification""].Visible=""true"";ISpace[""M_SubClassication""].Visible=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["M_Classification"].Visible="false";ISpace["M_SubClassication"].Visible="false";
base.WriteDebugInfo(@"ISpace[""M_Classification""].Visible=""false"";ISpace[""M_SubClassication""].Visible=""false"";");
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
ISpace["growid"].Value=ISpace["ReimbursementBillDetails_RowId"].Value;
base.WriteDebugInfo(@"ISpace[""growid""].Value=ISpace[""ReimbursementBillDetails_RowId""].Value;");
base.WriteDebugInfo(@"EXEC LoadFormGridDataC9ACCA847AF347E79133D777BE46A656 '@@gv_InstanceId','@@gv_ProcessMapId','C9ACCA84-7AF3-47E7-9133-D777BE46A656','@@gv_ActivityMapId','#growid'");

var querySource3BC8920E9488421CBBA16D92ECF94CB2 =GetQueryExpressionDataSource("3BC8920E-9488-421C-BBA1-6D92ECF94CB2");
Dictionary<short,object> result3BC8920E9488421CBBA16D92ECF94CB2=iSpace.ExecuteQuery(querySource3BC8920E9488421CBBA16D92ECF94CB2,@"EXEC LoadFormGridDataC9ACCA847AF347E79133D777BE46A656 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','C9ACCA84-7AF3-47E7-9133-D777BE46A656','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["growid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource3BC8920E9488421CBBA16D92ECF94CB2 =GetQueryExpressionDataSource(""3BC8920E-9488-421C-BBA1-6D92ECF94CB2"");Dictionary<short,object> result3BC8920E9488421CBBA16D92ECF94CB2=iSpace.ExecuteQuery(querySource3BC8920E9488421CBBA16D92ECF94CB2,@""EXEC LoadFormGridDataC9ACCA847AF347E79133D777BE46A656 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','C9ACCA84-7AF3-47E7-9133-D777BE46A656','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""growid""].Value + @""'"",false);");
base.WriteDebugInfo(@"EXEC LoadFormGridDataC9ACCA847AF347E79133D777BE46A656 '@@gv_InstanceId','@@gv_ProcessMapId','C9ACCA84-7AF3-47E7-9133-D777BE46A656','@@gv_ActivityMapId','#growid'");

if((result3BC8920E9488421CBBA16D92ECF94CB2!=null) && (result3BC8920E9488421CBBA16D92ECF94CB2.Count!=0))
{
if(result3BC8920E9488421CBBA16D92ECF94CB2.ContainsKey(3))
ISpace["MFG_P2_BillDate"].Value = result3BC8920E9488421CBBA16D92ECF94CB2[3];
if(result3BC8920E9488421CBBA16D92ECF94CB2.ContainsKey(4))
ISpace["MFG_P2_BillDocument"].Value = result3BC8920E9488421CBBA16D92ECF94CB2[4];
if(result3BC8920E9488421CBBA16D92ECF94CB2.ContainsKey(6))
ISpace["MFG_P2_Amount"].Value = result3BC8920E9488421CBBA16D92ECF94CB2[6];
if(result3BC8920E9488421CBBA16D92ECF94CB2.ContainsKey(0))
ISpace["MFG_P2_ReimbursementDetailsId"].Value = result3BC8920E9488421CBBA16D92ECF94CB2[0];
if(result3BC8920E9488421CBBA16D92ECF94CB2.ContainsKey(1))
ISpace["MFG_P2_ReimbursementId"].Value = result3BC8920E9488421CBBA16D92ECF94CB2[1];
if(result3BC8920E9488421CBBA16D92ECF94CB2.ContainsKey(2))
ISpace["MFG_P2_BillNo"].Value = result3BC8920E9488421CBBA16D92ECF94CB2[2];
if(result3BC8920E9488421CBBA16D92ECF94CB2.ContainsKey(5))
ISpace["MFG_P2_ItemDescription"].Value = result3BC8920E9488421CBBA16D92ECF94CB2[5];
}
else{
ISpace["MFG_P2_BillDate"].Value = null;ISpace["MFG_P2_BillDocument"].Value = null;ISpace["MFG_P2_Amount"].Value = null;ISpace["MFG_P2_ReimbursementDetailsId"].Value = null;ISpace["MFG_P2_ReimbursementId"].Value = null;ISpace["MFG_P2_BillNo"].Value = null;ISpace["MFG_P2_ItemDescription"].Value = null;
}
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

var querySource8D078B34227340D4A2DD23A371ABE1A6 =GetQueryExpressionDataSource("8D078B34-2273-40D4-A2DD-23A371ABE1A6");

DataTable result8D078B34227340D4A2DD23A371ABE1A6=iSpace.SetGridDataSource(querySource8D078B34227340D4A2DD23A371ABE1A6, _objectFactory.GetGridRPP("ReimbursementBillDetails"),@"EXEC AddFormGridDataC9ACCA847AF347E79133D777BE46A656 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','C9ACCA84-7AF3-47E7-9133-D777BE46A656','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["MFG_P2_ReimbursementDetailsId"].Value + @"','" + ISpace["MFG_P2_ReimbursementId"].Value + @"','" + ISpace["MFG_P2_BillNo"].Value + @"','" + ISpace["MFG_P2_BillDate"].Value + @"'," + ISpace["MFG_P2_BillDocument"].Value + @",'" + ISpace["MFG_P2_ItemDescription"].Value + @"'," + ISpace["MFG_P2_Amount"].Value + @",'" + ISpace["growid"].Value + @"'");

iSpace.InsertGridBindDetails("ReimbursementBillDetails","11",querySource8D078B34227340D4A2DD23A371ABE1A6,"EXEC AddFormGridDataC9ACCA847AF347E79133D777BE46A656 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','C9ACCA84-7AF3-47E7-9133-D777BE46A656','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["MFG_P2_ReimbursementDetailsId"].Value + @"','" + ISpace["MFG_P2_ReimbursementId"].Value + @"','" + ISpace["MFG_P2_BillNo"].Value + @"','" + ISpace["MFG_P2_BillDate"].Value + @"'," + ISpace["MFG_P2_BillDocument"].Value + @",'" + ISpace["MFG_P2_ItemDescription"].Value + @"'," + ISpace["MFG_P2_Amount"].Value + @",'" + ISpace["growid"].Value + @"'",_objectFactory.GetGridRPP("ReimbursementBillDetails"));

base.WriteDebugInfo(@"var querySource8D078B34227340D4A2DD23A371ABE1A6 =GetQueryExpressionDataSource(""8D078B34-2273-40D4-A2DD-23A371ABE1A6"");DataTable result8D078B34227340D4A2DD23A371ABE1A6=iSpace.SetGridDataSource(querySource8D078B34227340D4A2DD23A371ABE1A6, _objectFactory.GetGridRPP(""ReimbursementBillDetails""),@""EXEC AddFormGridDataC9ACCA847AF347E79133D777BE46A656 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','C9ACCA84-7AF3-47E7-9133-D777BE46A656','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""MFG_P2_ReimbursementDetailsId""].Value + @""','"" + ISpace[""MFG_P2_ReimbursementId""].Value + @""','"" + ISpace[""MFG_P2_BillNo""].Value + @""','"" + ISpace[""MFG_P2_BillDate""].Value + @""',"" + ISpace[""MFG_P2_BillDocument""].Value + @"",'"" + ISpace[""MFG_P2_ItemDescription""].Value + @""',"" + ISpace[""MFG_P2_Amount""].Value + @"",'"" + ISpace[""growid""].Value + @""'"");iSpace.InsertGridBindDetails(""ReimbursementBillDetails"",""11"",querySource8D078B34227340D4A2DD23A371ABE1A6,""EXEC AddFormGridDataC9ACCA847AF347E79133D777BE46A656 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','C9ACCA84-7AF3-47E7-9133-D777BE46A656','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""MFG_P2_ReimbursementDetailsId""].Value + @""','"" + ISpace[""MFG_P2_ReimbursementId""].Value + @""','"" + ISpace[""MFG_P2_BillNo""].Value + @""','"" + ISpace[""MFG_P2_BillDate""].Value + @""',"" + ISpace[""MFG_P2_BillDocument""].Value + @"",'"" + ISpace[""MFG_P2_ItemDescription""].Value + @""',"" + ISpace[""MFG_P2_Amount""].Value + @"",'"" + ISpace[""growid""].Value + @""'"",_objectFactory.GetGridRPP(""ReimbursementBillDetails""));");
base.WriteDebugInfo(@"EXEC AddFormGridDataC9ACCA847AF347E79133D777BE46A656 '@@gv_InstanceId','@@gv_ProcessMapId','C9ACCA84-7AF3-47E7-9133-D777BE46A656','@@gv_ActivityMapId','#MFG_P2_ReimbursementDetailsId','#MFG_P2_ReimbursementId','#MFG_P2_BillNo','#MFG_P2_BillDate',#MFG_P2_BillDocument,'#MFG_P2_ItemDescription',#MFG_P2_Amount,'#growid'");


List<Triplet<string, short, short?>> resultC48E5BD17B2A4917979A69F487396125=acdataIspace7B9E10F1A9E84A0C90D9F183CC3B49D0.GetQueryExpressionBindings("C48E5BD1-7B2A-4917-979A-69F487396125");
iSpace.SetGridData(result8D078B34227340D4A2DD23A371ABE1A6,resultC48E5BD17B2A4917979A69F487396125,"ReimbursementBillDetails",ref ISpace);
iSpace.UpdateGridBindDetails("ReimbursementBillDetails",resultC48E5BD17B2A4917979A69F487396125);
}
else
{
base.WriteDebugInfo(@"else");

var querySource9B5B780E4C6E4FCEA2BDA3A4764A9120 =GetQueryExpressionDataSource("9B5B780E-4C6E-4FCE-A2BD-A3A4764A9120");

DataTable result9B5B780E4C6E4FCEA2BDA3A4764A9120=iSpace.SetGridDataSource(querySource9B5B780E4C6E4FCEA2BDA3A4764A9120, _objectFactory.GetGridRPP("ReimbursementBillDetails"),@"EXEC UpdateFormGridDataC9ACCA847AF347E79133D777BE46A656 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','C9ACCA84-7AF3-47E7-9133-D777BE46A656','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["MFG_P2_ReimbursementDetailsId"].Value + @"','" + ISpace["MFG_P2_ReimbursementId"].Value + @"','" + ISpace["MFG_P2_BillNo"].Value + @"','" + ISpace["MFG_P2_BillDate"].Value + @"'," + ISpace["MFG_P2_BillDocument"].Value + @",'" + ISpace["MFG_P2_ItemDescription"].Value + @"'," + ISpace["MFG_P2_Amount"].Value + @",'" + ISpace["growid"].Value + @"'");

iSpace.InsertGridBindDetails("ReimbursementBillDetails","11",querySource9B5B780E4C6E4FCEA2BDA3A4764A9120,"EXEC UpdateFormGridDataC9ACCA847AF347E79133D777BE46A656 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','C9ACCA84-7AF3-47E7-9133-D777BE46A656','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["MFG_P2_ReimbursementDetailsId"].Value + @"','" + ISpace["MFG_P2_ReimbursementId"].Value + @"','" + ISpace["MFG_P2_BillNo"].Value + @"','" + ISpace["MFG_P2_BillDate"].Value + @"'," + ISpace["MFG_P2_BillDocument"].Value + @",'" + ISpace["MFG_P2_ItemDescription"].Value + @"'," + ISpace["MFG_P2_Amount"].Value + @",'" + ISpace["growid"].Value + @"'",_objectFactory.GetGridRPP("ReimbursementBillDetails"));

base.WriteDebugInfo(@"var querySource9B5B780E4C6E4FCEA2BDA3A4764A9120 =GetQueryExpressionDataSource(""9B5B780E-4C6E-4FCE-A2BD-A3A4764A9120"");DataTable result9B5B780E4C6E4FCEA2BDA3A4764A9120=iSpace.SetGridDataSource(querySource9B5B780E4C6E4FCEA2BDA3A4764A9120, _objectFactory.GetGridRPP(""ReimbursementBillDetails""),@""EXEC UpdateFormGridDataC9ACCA847AF347E79133D777BE46A656 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','C9ACCA84-7AF3-47E7-9133-D777BE46A656','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""MFG_P2_ReimbursementDetailsId""].Value + @""','"" + ISpace[""MFG_P2_ReimbursementId""].Value + @""','"" + ISpace[""MFG_P2_BillNo""].Value + @""','"" + ISpace[""MFG_P2_BillDate""].Value + @""',"" + ISpace[""MFG_P2_BillDocument""].Value + @"",'"" + ISpace[""MFG_P2_ItemDescription""].Value + @""',"" + ISpace[""MFG_P2_Amount""].Value + @"",'"" + ISpace[""growid""].Value + @""'"");iSpace.InsertGridBindDetails(""ReimbursementBillDetails"",""11"",querySource9B5B780E4C6E4FCEA2BDA3A4764A9120,""EXEC UpdateFormGridDataC9ACCA847AF347E79133D777BE46A656 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','C9ACCA84-7AF3-47E7-9133-D777BE46A656','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""MFG_P2_ReimbursementDetailsId""].Value + @""','"" + ISpace[""MFG_P2_ReimbursementId""].Value + @""','"" + ISpace[""MFG_P2_BillNo""].Value + @""','"" + ISpace[""MFG_P2_BillDate""].Value + @""',"" + ISpace[""MFG_P2_BillDocument""].Value + @"",'"" + ISpace[""MFG_P2_ItemDescription""].Value + @""',"" + ISpace[""MFG_P2_Amount""].Value + @"",'"" + ISpace[""growid""].Value + @""'"",_objectFactory.GetGridRPP(""ReimbursementBillDetails""));");
base.WriteDebugInfo(@"EXEC UpdateFormGridDataC9ACCA847AF347E79133D777BE46A656 '@@gv_InstanceId','@@gv_ProcessMapId','C9ACCA84-7AF3-47E7-9133-D777BE46A656','@@gv_ActivityMapId','#MFG_P2_ReimbursementDetailsId','#MFG_P2_ReimbursementId','#MFG_P2_BillNo','#MFG_P2_BillDate',#MFG_P2_BillDocument,'#MFG_P2_ItemDescription',#MFG_P2_Amount,'#growid'");


List<Triplet<string, short, short?>> result9EA07CACF2274E83A5EE8C316E74D75C=acdataIspace7B9E10F1A9E84A0C90D9F183CC3B49D0.GetQueryExpressionBindings("9EA07CAC-F227-4E83-A5EE-8C316E74D75C");
iSpace.SetGridData(result9B5B780E4C6E4FCEA2BDA3A4764A9120,result9EA07CACF2274E83A5EE8C316E74D75C,"ReimbursementBillDetails",ref ISpace);
iSpace.UpdateGridBindDetails("ReimbursementBillDetails",result9EA07CACF2274E83A5EE8C316E74D75C);
}
object MG_P2_Amount=iSpace.Sum("[1D198218-D4AF-4E09-9A9D-119D03D0C3BA]","MG_P2_Amount","",ISpace["gv_instanceid"].Value);
ISpace["MF_P1_TotalAmount"].Value=Convert.ChangeType(MG_P2_Amount, MG_P2_Amount.GetType());;
base.WriteDebugInfo(@"object MG_P2_Amount=iSpace.Sum(""[1D198218-D4AF-4E09-9A9D-119D03D0C3BA]"",""MG_P2_Amount"","""",ISpace[""gv_instanceid""].Value);
ISpace[""MF_P1_TotalAmount""].Value=Convert.ChangeType(MG_P2_Amount, MG_P2_Amount.GetType());;");
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
if (_elementBase != null)  iSpace.SetLoopExpressionData("ReimbursementFundDetails","84AEB9E0-3009-4426-AB92-AAF06D2B42AF",_objectFactory.GetGridRPP("ReimbursementFundDetails"),_elementBase.GetGridLoopQuery("84AEB9E0-3009-4426-AB92-AAF06D2B42AF","ReimbursementFundDetails",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""ReimbursementFundDetails"",ref ISpace);

foreach(var gridChild in ISpace[""ReimbursementFundDetails""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
}
if(ISpace["growid"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""growid""].Value=="""")");

var querySourceCBB3928101F44B3AB89247A0222DAFBA =GetQueryExpressionDataSource("CBB39281-01F4-4B3A-B892-47A0222DAFBA");

DataTable resultCBB3928101F44B3AB89247A0222DAFBA=iSpace.SetGridDataSource(querySourceCBB3928101F44B3AB89247A0222DAFBA, _objectFactory.GetGridRPP("ReimbursementFundDetails"),@"EXEC AddFormGridDataD85301F7BAF94BE8A2B174E5CBB3D054 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','D85301F7-BAF9-4BE8-A2B1-74E5CBB3D054','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["MFG_P3_FundDetailsId"].Value + @"','" + ISpace["MFG_P3_ReimbursementId"].Value + @"','" + ISpace["MFG_P3_FundTypeId"].Value + @"','" + ISpace["MFG_P3_ProjectDetailsId"].Value + @"','" + ISpace["MFG_P3_BudgetHeadId"].Value + @"','" + ISpace["MFG_P3_Amount"].Value + @"','" + ISpace["growid"].Value + @"'");

iSpace.InsertGridBindDetails("ReimbursementFundDetails","11",querySourceCBB3928101F44B3AB89247A0222DAFBA,"EXEC AddFormGridDataD85301F7BAF94BE8A2B174E5CBB3D054 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','D85301F7-BAF9-4BE8-A2B1-74E5CBB3D054','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["MFG_P3_FundDetailsId"].Value + @"','" + ISpace["MFG_P3_ReimbursementId"].Value + @"','" + ISpace["MFG_P3_FundTypeId"].Value + @"','" + ISpace["MFG_P3_ProjectDetailsId"].Value + @"','" + ISpace["MFG_P3_BudgetHeadId"].Value + @"','" + ISpace["MFG_P3_Amount"].Value + @"','" + ISpace["growid"].Value + @"'",_objectFactory.GetGridRPP("ReimbursementFundDetails"));

base.WriteDebugInfo(@"var querySourceCBB3928101F44B3AB89247A0222DAFBA =GetQueryExpressionDataSource(""CBB39281-01F4-4B3A-B892-47A0222DAFBA"");DataTable resultCBB3928101F44B3AB89247A0222DAFBA=iSpace.SetGridDataSource(querySourceCBB3928101F44B3AB89247A0222DAFBA, _objectFactory.GetGridRPP(""ReimbursementFundDetails""),@""EXEC AddFormGridDataD85301F7BAF94BE8A2B174E5CBB3D054 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','D85301F7-BAF9-4BE8-A2B1-74E5CBB3D054','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""MFG_P3_FundDetailsId""].Value + @""','"" + ISpace[""MFG_P3_ReimbursementId""].Value + @""','"" + ISpace[""MFG_P3_FundTypeId""].Value + @""','"" + ISpace[""MFG_P3_ProjectDetailsId""].Value + @""','"" + ISpace[""MFG_P3_BudgetHeadId""].Value + @""','"" + ISpace[""MFG_P3_Amount""].Value + @""','"" + ISpace[""growid""].Value + @""'"");iSpace.InsertGridBindDetails(""ReimbursementFundDetails"",""11"",querySourceCBB3928101F44B3AB89247A0222DAFBA,""EXEC AddFormGridDataD85301F7BAF94BE8A2B174E5CBB3D054 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','D85301F7-BAF9-4BE8-A2B1-74E5CBB3D054','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""MFG_P3_FundDetailsId""].Value + @""','"" + ISpace[""MFG_P3_ReimbursementId""].Value + @""','"" + ISpace[""MFG_P3_FundTypeId""].Value + @""','"" + ISpace[""MFG_P3_ProjectDetailsId""].Value + @""','"" + ISpace[""MFG_P3_BudgetHeadId""].Value + @""','"" + ISpace[""MFG_P3_Amount""].Value + @""','"" + ISpace[""growid""].Value + @""'"",_objectFactory.GetGridRPP(""ReimbursementFundDetails""));");
base.WriteDebugInfo(@"EXEC AddFormGridDataD85301F7BAF94BE8A2B174E5CBB3D054 '@@gv_InstanceId','@@gv_ProcessMapId','D85301F7-BAF9-4BE8-A2B1-74E5CBB3D054','@@gv_ActivityMapId','#MFG_P3_FundDetailsId','#MFG_P3_ReimbursementId','#MFG_P3_FundTypeId','#MFG_P3_ProjectDetailsId','#MFG_P3_BudgetHeadId',#MFG_P3_Amount,'#growid'");


List<Triplet<string, short, short?>> result25A00CF73B354322B4DFFE24D90229BC=acdataIspace7B9E10F1A9E84A0C90D9F183CC3B49D0.GetQueryExpressionBindings("25A00CF7-3B35-4322-B4DF-FE24D90229BC");
iSpace.SetGridData(resultCBB3928101F44B3AB89247A0222DAFBA,result25A00CF73B354322B4DFFE24D90229BC,"ReimbursementFundDetails",ref ISpace);
iSpace.UpdateGridBindDetails("ReimbursementFundDetails",result25A00CF73B354322B4DFFE24D90229BC);
}
else
{
base.WriteDebugInfo(@"else");

var querySource334BDAE0A76B4B0F84BCAEF7F4F927FE =GetQueryExpressionDataSource("334BDAE0-A76B-4B0F-84BC-AEF7F4F927FE");

DataTable result334BDAE0A76B4B0F84BCAEF7F4F927FE=iSpace.SetGridDataSource(querySource334BDAE0A76B4B0F84BCAEF7F4F927FE, _objectFactory.GetGridRPP("ReimbursementFundDetails"),@"EXEC UpdateFormGridDataD85301F7BAF94BE8A2B174E5CBB3D054 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','D85301F7-BAF9-4BE8-A2B1-74E5CBB3D054','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["MFG_P3_FundDetailsId"].Value + @"','" + ISpace["MFG_P3_ReimbursementId"].Value + @"','" + ISpace["MFG_P3_FundTypeId"].Value + @"','" + ISpace["MFG_P3_ProjectDetailsId"].Value + @"','" + ISpace["MFG_P3_BudgetHeadId"].Value + @"'," + ISpace["MFG_P3_Amount"].Value + @",'" + ISpace["growid"].Value + @"'");

iSpace.InsertGridBindDetails("ReimbursementFundDetails","11",querySource334BDAE0A76B4B0F84BCAEF7F4F927FE,"EXEC UpdateFormGridDataD85301F7BAF94BE8A2B174E5CBB3D054 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','D85301F7-BAF9-4BE8-A2B1-74E5CBB3D054','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["MFG_P3_FundDetailsId"].Value + @"','" + ISpace["MFG_P3_ReimbursementId"].Value + @"','" + ISpace["MFG_P3_FundTypeId"].Value + @"','" + ISpace["MFG_P3_ProjectDetailsId"].Value + @"','" + ISpace["MFG_P3_BudgetHeadId"].Value + @"'," + ISpace["MFG_P3_Amount"].Value + @",'" + ISpace["growid"].Value + @"'",_objectFactory.GetGridRPP("ReimbursementFundDetails"));

base.WriteDebugInfo(@"var querySource334BDAE0A76B4B0F84BCAEF7F4F927FE =GetQueryExpressionDataSource(""334BDAE0-A76B-4B0F-84BC-AEF7F4F927FE"");DataTable result334BDAE0A76B4B0F84BCAEF7F4F927FE=iSpace.SetGridDataSource(querySource334BDAE0A76B4B0F84BCAEF7F4F927FE, _objectFactory.GetGridRPP(""ReimbursementFundDetails""),@""EXEC UpdateFormGridDataD85301F7BAF94BE8A2B174E5CBB3D054 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','D85301F7-BAF9-4BE8-A2B1-74E5CBB3D054','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""MFG_P3_FundDetailsId""].Value + @""','"" + ISpace[""MFG_P3_ReimbursementId""].Value + @""','"" + ISpace[""MFG_P3_FundTypeId""].Value + @""','"" + ISpace[""MFG_P3_ProjectDetailsId""].Value + @""','"" + ISpace[""MFG_P3_BudgetHeadId""].Value + @""',"" + ISpace[""MFG_P3_Amount""].Value + @"",'"" + ISpace[""growid""].Value + @""'"");iSpace.InsertGridBindDetails(""ReimbursementFundDetails"",""11"",querySource334BDAE0A76B4B0F84BCAEF7F4F927FE,""EXEC UpdateFormGridDataD85301F7BAF94BE8A2B174E5CBB3D054 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','D85301F7-BAF9-4BE8-A2B1-74E5CBB3D054','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""MFG_P3_FundDetailsId""].Value + @""','"" + ISpace[""MFG_P3_ReimbursementId""].Value + @""','"" + ISpace[""MFG_P3_FundTypeId""].Value + @""','"" + ISpace[""MFG_P3_ProjectDetailsId""].Value + @""','"" + ISpace[""MFG_P3_BudgetHeadId""].Value + @""',"" + ISpace[""MFG_P3_Amount""].Value + @"",'"" + ISpace[""growid""].Value + @""'"",_objectFactory.GetGridRPP(""ReimbursementFundDetails""));");
base.WriteDebugInfo(@"EXEC UpdateFormGridDataD85301F7BAF94BE8A2B174E5CBB3D054 '@@gv_InstanceId','@@gv_ProcessMapId','D85301F7-BAF9-4BE8-A2B1-74E5CBB3D054','@@gv_ActivityMapId','#MFG_P3_FundDetailsId','#MFG_P3_ReimbursementId','#MFG_P3_FundTypeId','#MFG_P3_ProjectDetailsId','#MFG_P3_BudgetHeadId',#MFG_P3_Amount,'#growid'");


List<Triplet<string, short, short?>> resultEFFC55B685564D91AE91384F68B422FF=acdataIspace7B9E10F1A9E84A0C90D9F183CC3B49D0.GetQueryExpressionBindings("EFFC55B6-8556-4D91-AE91-384F68B422FF");
iSpace.SetGridData(result334BDAE0A76B4B0F84BCAEF7F4F927FE,resultEFFC55B685564D91AE91384F68B422FF,"ReimbursementFundDetails",ref ISpace);
iSpace.UpdateGridBindDetails("ReimbursementFundDetails",resultEFFC55B685564D91AE91384F68B422FF);
}
base.WriteDebugInfo(@"#ReimbursementFundDetails[Rows]");
iSpace.GetLoopExpressionData("ReimbursementFundDetails",ref ISpace);

foreach(var gridChild in ISpace["ReimbursementFundDetails"].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 



ISpace["MG_P3_PackageProcessMapId"].Value=ISpace["M_PackageProcessMapId"].Value;
base.WriteDebugInfo(@"

ISpace[""MG_P3_PackageProcessMapId""].Value=ISpace[""M_PackageProcessMapId""].Value;");


ISpace["MG_P3_EmployeeBaicInfoId"].Value=ISpace["UC_EmployeeBaicInfoId"].Value;
base.WriteDebugInfo(@"

ISpace[""MG_P3_EmployeeBaicInfoId""].Value=ISpace[""UC_EmployeeBaicInfoId""].Value;");
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("ReimbursementFundDetails","84AEB9E0-3009-4426-AB92-AAF06D2B42AF",_objectFactory.GetGridRPP("ReimbursementFundDetails"),_elementBase.GetGridLoopQuery("84AEB9E0-3009-4426-AB92-AAF06D2B42AF","ReimbursementFundDetails",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""ReimbursementFundDetails"",ref ISpace);

foreach(var gridChild in ISpace[""ReimbursementFundDetails""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
object MG_P3_Amount=iSpace.Sum("[84AEB9E0-3009-4426-AB92-AAF06D2B42AF]","MG_P3_Amount","",ISpace["gv_instanceid"].Value);
ISpace["MFG_P3_OverallAmount"].Value=Convert.ChangeType(MG_P3_Amount, MG_P3_Amount.GetType());;
base.WriteDebugInfo(@"object MG_P3_Amount=iSpace.Sum(""[84AEB9E0-3009-4426-AB92-AAF06D2B42AF]"",""MG_P3_Amount"","""",ISpace[""gv_instanceid""].Value);
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
private void SubscribeElementEvents_submitform (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"SubmitForm-OnClick");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC UpsertActivityTrailLogDetails '@@gv_TenantId','#M_InstanceId','@@gv_ActivityName','#MF_P1_Remarks','@@gv_UserName','#M_SourceActivityMapId','#SetDestinationTo','@@gv_UserId','#M_IsSourceStep'");

var querySourcebefdd5b207e912dc5d3682026e5e2134 =GetQueryExpressionDataSource("befdd5b2-07e9-12dc-5d36-82026e5e2134");
Dictionary<short,object> resultbefdd5b207e912dc5d3682026e5e2134=iSpace.ExecuteQuery(querySourcebefdd5b207e912dc5d3682026e5e2134,@"EXEC UpsertActivityTrailLogDetails '" + ISpace["gv_tenantid"].Value + @"','" + ISpace["M_InstanceId"].Value + @"','" + ISpace["gv_activityname"].Value + @"','" + ISpace["MF_P1_Remarks"].Value + @"','" + ISpace["gv_username"].Value + @"','" + ISpace["M_SourceActivityMapId"].Value + @"','" + ISpace["SetDestinationTo"].Value + @"','" + ISpace["gv_userid"].Value + @"','" + ISpace["M_IsSourceStep"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourcebefdd5b207e912dc5d3682026e5e2134 =GetQueryExpressionDataSource(""befdd5b2-07e9-12dc-5d36-82026e5e2134"");Dictionary<short,object> resultbefdd5b207e912dc5d3682026e5e2134=iSpace.ExecuteQuery(querySourcebefdd5b207e912dc5d3682026e5e2134,@""EXEC UpsertActivityTrailLogDetails '"" + ISpace[""gv_tenantid""].Value + @""','"" + ISpace[""M_InstanceId""].Value + @""','"" + ISpace[""gv_activityname""].Value + @""','"" + ISpace[""MF_P1_Remarks""].Value + @""','"" + ISpace[""gv_username""].Value + @""','"" + ISpace[""M_SourceActivityMapId""].Value + @""','"" + ISpace[""SetDestinationTo""].Value + @""','"" + ISpace[""gv_userid""].Value + @""','"" + ISpace[""M_IsSourceStep""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultbefdd5b207e912dc5d3682026e5e2134!=null) && (resultbefdd5b207e912dc5d3682026e5e2134.Count!=0))
{
if(resultbefdd5b207e912dc5d3682026e5e2134.ContainsKey(0))
ISpace["ExecutionMessage"].Value = resultbefdd5b207e912dc5d3682026e5e2134[0];
}
else{
ISpace["ExecutionMessage"].Value = null;
}
}
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
ISpace["MF_P1_ApplicationStatus"].Value="A";
base.WriteDebugInfo(@"ISpace[""MF_P1_ApplicationStatus""].Value=""A"";");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC UpsertProjectReimbursement '#MF_P1_ReimbursementId','#UC_EmployeeBaicInfoId','#MF_P1_TotalAmount','@@gv_UserId','#MF_P1_ApplicationStatus','#M_ReimbursementType','#M_Classification','#M_SubClassication','@@gv_UserId'");

var querySourced58dc3c8687f1ebcd4754068de464713 =GetQueryExpressionDataSource("d58dc3c8-687f-1ebc-d475-4068de464713");
Dictionary<short,object> resultd58dc3c8687f1ebcd4754068de464713=iSpace.ExecuteQuery(querySourced58dc3c8687f1ebcd4754068de464713,@"EXEC UpsertProjectReimbursement '" + ISpace["MF_P1_ReimbursementId"].Value + @"','" + ISpace["UC_EmployeeBaicInfoId"].Value + @"','" + ISpace["MF_P1_TotalAmount"].Value + @"','" + ISpace["gv_userid"].Value + @"','" + ISpace["MF_P1_ApplicationStatus"].Value + @"','" + ISpace["M_ReimbursementType"].Value + @"','" + ISpace["M_Classification"].Value + @"','" + ISpace["M_SubClassication"].Value + @"','" + ISpace["gv_userid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourced58dc3c8687f1ebcd4754068de464713 =GetQueryExpressionDataSource(""d58dc3c8-687f-1ebc-d475-4068de464713"");Dictionary<short,object> resultd58dc3c8687f1ebcd4754068de464713=iSpace.ExecuteQuery(querySourced58dc3c8687f1ebcd4754068de464713,@""EXEC UpsertProjectReimbursement '"" + ISpace[""MF_P1_ReimbursementId""].Value + @""','"" + ISpace[""UC_EmployeeBaicInfoId""].Value + @""','"" + ISpace[""MF_P1_TotalAmount""].Value + @""','"" + ISpace[""gv_userid""].Value + @""','"" + ISpace[""MF_P1_ApplicationStatus""].Value + @""','"" + ISpace[""M_ReimbursementType""].Value + @""','"" + ISpace[""M_Classification""].Value + @""','"" + ISpace[""M_SubClassication""].Value + @""','"" + ISpace[""gv_userid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultd58dc3c8687f1ebcd4754068de464713!=null) && (resultd58dc3c8687f1ebcd4754068de464713.Count!=0))
{
if(resultd58dc3c8687f1ebcd4754068de464713.ContainsKey(0))
ISpace["ExecutionMessage"].Value = resultd58dc3c8687f1ebcd4754068de464713[0];
}
else{
ISpace["ExecutionMessage"].Value = null;
}
base.WriteDebugInfo(@"EXEC UpsertProjectReimbursementFundDetails '#MG_P3_FundDetailsId','#MF_P1_ReimbursementId','#MG_P3_FundTypeId','#MG_P3_ProjectDetailsId','#MG_P3_BudgetHeadId','#MG_P3_Amount'");

var querySource478236c45c793773d35402c74092c916 =GetQueryExpressionDataSource("478236c4-5c79-3773-d354-02c74092c916");
Dictionary<short,object> result478236c45c793773d35402c74092c916=iSpace.ExecuteQuery(querySource478236c45c793773d35402c74092c916,@"EXEC UpsertProjectReimbursementFundDetails '" + ISpace["MG_P3_FundDetailsId"].Value + @"','" + ISpace["MF_P1_ReimbursementId"].Value + @"','" + ISpace["MG_P3_FundTypeId"].Value + @"','" + ISpace["MG_P3_ProjectDetailsId"].Value + @"','" + ISpace["MG_P3_BudgetHeadId"].Value + @"','" + ISpace["MG_P3_Amount"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource478236c45c793773d35402c74092c916 =GetQueryExpressionDataSource(""478236c4-5c79-3773-d354-02c74092c916"");Dictionary<short,object> result478236c45c793773d35402c74092c916=iSpace.ExecuteQuery(querySource478236c45c793773d35402c74092c916,@""EXEC UpsertProjectReimbursementFundDetails '"" + ISpace[""MG_P3_FundDetailsId""].Value + @""','"" + ISpace[""MF_P1_ReimbursementId""].Value + @""','"" + ISpace[""MG_P3_FundTypeId""].Value + @""','"" + ISpace[""MG_P3_ProjectDetailsId""].Value + @""','"" + ISpace[""MG_P3_BudgetHeadId""].Value + @""','"" + ISpace[""MG_P3_Amount""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result478236c45c793773d35402c74092c916!=null) && (result478236c45c793773d35402c74092c916.Count!=0))
{
if(result478236c45c793773d35402c74092c916.ContainsKey(0))
ISpace["ExecutionMessage"].Value = result478236c45c793773d35402c74092c916[0];
}
else{
ISpace["ExecutionMessage"].Value = null;
}
base.WriteDebugInfo(@"EXEC UpsertProjectReimbursementBillDetails '#MG_P2_ReimbursementDetailsId','#MF_P1_ReimbursementId','#MG_P2_BillNo','#MG_P2_BillDate',NULL,'#MG_P2_ItemDescription','#MG_P2_Amount'");

var querySource0ac6af4e84d7e8d409946108bb08331c =GetQueryExpressionDataSource("0ac6af4e-84d7-e8d4-0994-6108bb08331c");
Dictionary<short,object> result0ac6af4e84d7e8d409946108bb08331c=iSpace.ExecuteQuery(querySource0ac6af4e84d7e8d409946108bb08331c,@"EXEC UpsertProjectReimbursementBillDetails '" + ISpace["MG_P2_ReimbursementDetailsId"].Value + @"','" + ISpace["MF_P1_ReimbursementId"].Value + @"','" + ISpace["MG_P2_BillNo"].Value + @"','" + ISpace["MG_P2_BillDate"].Value + @"',NULL,'" + ISpace["MG_P2_ItemDescription"].Value + @"','" + ISpace["MG_P2_Amount"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource0ac6af4e84d7e8d409946108bb08331c =GetQueryExpressionDataSource(""0ac6af4e-84d7-e8d4-0994-6108bb08331c"");Dictionary<short,object> result0ac6af4e84d7e8d409946108bb08331c=iSpace.ExecuteQuery(querySource0ac6af4e84d7e8d409946108bb08331c,@""EXEC UpsertProjectReimbursementBillDetails '"" + ISpace[""MG_P2_ReimbursementDetailsId""].Value + @""','"" + ISpace[""MF_P1_ReimbursementId""].Value + @""','"" + ISpace[""MG_P2_BillNo""].Value + @""','"" + ISpace[""MG_P2_BillDate""].Value + @""',NULL,'"" + ISpace[""MG_P2_ItemDescription""].Value + @""','"" + ISpace[""MG_P2_Amount""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result0ac6af4e84d7e8d409946108bb08331c!=null) && (result0ac6af4e84d7e8d409946108bb08331c.Count!=0))
{
if(result0ac6af4e84d7e8d409946108bb08331c.ContainsKey(0))
ISpace["ExecutionMessage"].Value = result0ac6af4e84d7e8d409946108bb08331c[0];
}
else{
ISpace["ExecutionMessage"].Value = null;
}
base.WriteDebugInfo(@"EXEC UpsertDocumentDetails '#M_DocumentDetailsId','#M_InstanceId','#M_PackageProcessMapId','#M_DocumentName','#M_UploadDcoument',' @@gv_UserId'");

var querySource17adfd2bbf7aa7968851003732efc9c7 =GetQueryExpressionDataSource("17adfd2b-bf7a-a796-8851-003732efc9c7");
Dictionary<short,object> result17adfd2bbf7aa7968851003732efc9c7=iSpace.ExecuteQuery(querySource17adfd2bbf7aa7968851003732efc9c7,@"EXEC UpsertDocumentDetails '" + ISpace["M_DocumentDetailsId"].Value + @"','" + ISpace["M_InstanceId"].Value + @"','" + ISpace["M_PackageProcessMapId"].Value + @"','" + ISpace["M_DocumentName"].Value + @"','" + ISpace["M_UploadDcoument"].Value + @"',' " + ISpace["gv_userid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource17adfd2bbf7aa7968851003732efc9c7 =GetQueryExpressionDataSource(""17adfd2b-bf7a-a796-8851-003732efc9c7"");Dictionary<short,object> result17adfd2bbf7aa7968851003732efc9c7=iSpace.ExecuteQuery(querySource17adfd2bbf7aa7968851003732efc9c7,@""EXEC UpsertDocumentDetails '"" + ISpace[""M_DocumentDetailsId""].Value + @""','"" + ISpace[""M_InstanceId""].Value + @""','"" + ISpace[""M_PackageProcessMapId""].Value + @""','"" + ISpace[""M_DocumentName""].Value + @""','"" + ISpace[""M_UploadDcoument""].Value + @""',' "" + ISpace[""gv_userid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result17adfd2bbf7aa7968851003732efc9c7!=null) && (result17adfd2bbf7aa7968851003732efc9c7.Count!=0))
{
if(result17adfd2bbf7aa7968851003732efc9c7.ContainsKey(0))
ISpace["ExecutionMessage"].Value = result17adfd2bbf7aa7968851003732efc9c7[0];
}
else{
ISpace["ExecutionMessage"].Value = null;
}
}
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
base.WriteDebugInfo(@"EXEC [UpsertProjectBudgetDetails] 6,'#MG_P3_ProjectDetailsId','','#MG_P3_Amount','#MG_P3_BudgetHeadId',1,'#MG_P3_FundTypeId'");

var querySourceBA4985A9C4A24DC6BBD1661F0431909A =GetQueryExpressionDataSource("BA4985A9-C4A2-4DC6-BBD1-661F0431909A");
Dictionary<short,object> resultBA4985A9C4A24DC6BBD1661F0431909A=iSpace.ExecuteQuery(querySourceBA4985A9C4A24DC6BBD1661F0431909A,@"EXEC [UpsertProjectBudgetDetails] 6,'" + ISpace["MG_P3_ProjectDetailsId"].Value + @"','','" + ISpace["MG_P3_Amount"].Value + @"','" + ISpace["MG_P3_BudgetHeadId"].Value + @"',1,'" + ISpace["MG_P3_FundTypeId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceBA4985A9C4A24DC6BBD1661F0431909A =GetQueryExpressionDataSource(""BA4985A9-C4A2-4DC6-BBD1-661F0431909A"");Dictionary<short,object> resultBA4985A9C4A24DC6BBD1661F0431909A=iSpace.ExecuteQuery(querySourceBA4985A9C4A24DC6BBD1661F0431909A,@""EXEC [UpsertProjectBudgetDetails] 6,'"" + ISpace[""MG_P3_ProjectDetailsId""].Value + @""','','"" + ISpace[""MG_P3_Amount""].Value + @""','"" + ISpace[""MG_P3_BudgetHeadId""].Value + @""',1,'"" + ISpace[""MG_P3_FundTypeId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultBA4985A9C4A24DC6BBD1661F0431909A!=null) && (resultBA4985A9C4A24DC6BBD1661F0431909A.Count!=0))
{
if(resultBA4985A9C4A24DC6BBD1661F0431909A.ContainsKey(0))
ISpace["M_UpdateCount"].Value = resultBA4985A9C4A24DC6BBD1661F0431909A[0];
}
else{
ISpace["M_UpdateCount"].Value = null;
}
}
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("ReimbursementFundDetails","84AEB9E0-3009-4426-AB92-AAF06D2B42AF",_objectFactory.GetGridRPP("ReimbursementFundDetails"),_elementBase.GetGridLoopQuery("84AEB9E0-3009-4426-AB92-AAF06D2B42AF","ReimbursementFundDetails",ISpace), ref ISpace);
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
ISpace["M_SaveDomainData"].Value==1)
{
base.WriteDebugInfo(@"
if(
ISpace[""M_SaveDomainData""].Value==1)");
base.WriteDebugInfo(@"EXEC [UpsertProjectBudgetDetails] 5,'#MG_P3_ProjectDetailsId','','#MG_P3_Amount','#MG_P3_BudgetHeadId',0,'#MG_P3_FundTypeId'");

var querySource1AE2D0565D6C472F96B18D59F543FEE1 =GetQueryExpressionDataSource("1AE2D056-5D6C-472F-96B1-8D59F543FEE1");
Dictionary<short,object> result1AE2D0565D6C472F96B18D59F543FEE1=iSpace.ExecuteQuery(querySource1AE2D0565D6C472F96B18D59F543FEE1,@"EXEC [UpsertProjectBudgetDetails] 5,'" + ISpace["MG_P3_ProjectDetailsId"].Value + @"','','" + ISpace["MG_P3_Amount"].Value + @"','" + ISpace["MG_P3_BudgetHeadId"].Value + @"',0,'" + ISpace["MG_P3_FundTypeId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource1AE2D0565D6C472F96B18D59F543FEE1 =GetQueryExpressionDataSource(""1AE2D056-5D6C-472F-96B1-8D59F543FEE1"");Dictionary<short,object> result1AE2D0565D6C472F96B18D59F543FEE1=iSpace.ExecuteQuery(querySource1AE2D0565D6C472F96B18D59F543FEE1,@""EXEC [UpsertProjectBudgetDetails] 5,'"" + ISpace[""MG_P3_ProjectDetailsId""].Value + @""','','"" + ISpace[""MG_P3_Amount""].Value + @""','"" + ISpace[""MG_P3_BudgetHeadId""].Value + @""',0,'"" + ISpace[""MG_P3_FundTypeId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result1AE2D0565D6C472F96B18D59F543FEE1!=null) && (result1AE2D0565D6C472F96B18D59F543FEE1.Count!=0))
{
if(result1AE2D0565D6C472F96B18D59F543FEE1.ContainsKey(0))
ISpace["M_UpdateCount"].Value = result1AE2D0565D6C472F96B18D59F543FEE1[0];
}
else{
ISpace["M_UpdateCount"].Value = null;
}
}
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("ReimbursementFundDetails","84AEB9E0-3009-4426-AB92-AAF06D2B42AF",_objectFactory.GetGridRPP("ReimbursementFundDetails"),_elementBase.GetGridLoopQuery("84AEB9E0-3009-4426-AB92-AAF06D2B42AF","ReimbursementFundDetails",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""ReimbursementFundDetails"",ref ISpace);

foreach(var gridChild in ISpace[""ReimbursementFundDetails""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
if(ISpace["M_SaveDomainData"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""M_SaveDomainData""].Value==1)");
base.WriteDebugInfo(@"EXEC SendApproveEmailForPRI '#MF_P1_ReimbursementId'");

var querySource00E65BF5428949A495228BFA76F6F516 =GetQueryExpressionDataSource("00E65BF5-4289-49A4-9522-8BFA76F6F516");
Dictionary<short,object> result00E65BF5428949A495228BFA76F6F516=iSpace.ExecuteQuery(querySource00E65BF5428949A495228BFA76F6F516,@"EXEC SendApproveEmailForPRI '" + ISpace["MF_P1_ReimbursementId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource00E65BF5428949A495228BFA76F6F516 =GetQueryExpressionDataSource(""00E65BF5-4289-49A4-9522-8BFA76F6F516"");Dictionary<short,object> result00E65BF5428949A495228BFA76F6F516=iSpace.ExecuteQuery(querySource00E65BF5428949A495228BFA76F6F516,@""EXEC SendApproveEmailForPRI '"" + ISpace[""MF_P1_ReimbursementId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result00E65BF5428949A495228BFA76F6F516!=null) && (result00E65BF5428949A495228BFA76F6F516.Count!=0))
{
if(result00E65BF5428949A495228BFA76F6F516.ContainsKey(0))
ISpace["M_UpdateCount"].Value = result00E65BF5428949A495228BFA76F6F516[0];
}
else{
ISpace["M_UpdateCount"].Value = null;
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
base.WriteDebugInfo(@"EXEC UpsertUserRequestsUpdation '#M_InstanceId','#SetDestinationTo','#M_Stage','#M_Status','@@gv_UserId','#M_RequestId'");

var querySource87cbcf911fba16fd3029f8855a072138 =GetQueryExpressionDataSource("87cbcf91-1fba-16fd-3029-f8855a072138");
Dictionary<short,object> result87cbcf911fba16fd3029f8855a072138=iSpace.ExecuteQuery(querySource87cbcf911fba16fd3029f8855a072138,@"EXEC UpsertUserRequestsUpdation '" + ISpace["M_InstanceId"].Value + @"','" + ISpace["SetDestinationTo"].Value + @"','" + ISpace["M_Stage"].Value + @"','" + ISpace["M_Status"].Value + @"','" + ISpace["gv_userid"].Value + @"','" + ISpace["M_RequestId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource87cbcf911fba16fd3029f8855a072138 =GetQueryExpressionDataSource(""87cbcf91-1fba-16fd-3029-f8855a072138"");Dictionary<short,object> result87cbcf911fba16fd3029f8855a072138=iSpace.ExecuteQuery(querySource87cbcf911fba16fd3029f8855a072138,@""EXEC UpsertUserRequestsUpdation '"" + ISpace[""M_InstanceId""].Value + @""','"" + ISpace[""SetDestinationTo""].Value + @""','"" + ISpace[""M_Stage""].Value + @""','"" + ISpace[""M_Status""].Value + @""','"" + ISpace[""gv_userid""].Value + @""','"" + ISpace[""M_RequestId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result87cbcf911fba16fd3029f8855a072138!=null) && (result87cbcf911fba16fd3029f8855a072138.Count!=0))
{
if(result87cbcf911fba16fd3029f8855a072138.ContainsKey(0))
ISpace["ExecutionMessage"].Value = result87cbcf911fba16fd3029f8855a072138[0];
}
else{
ISpace["ExecutionMessage"].Value = null;
}
ISpace["Message"].Value=@"Submitted Successfully";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Submitted Successfully"";");
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
base.WriteDebugInfo(@"EXEC LoadFormGridDataD85301F7BAF94BE8A2B174E5CBB3D054 '@@gv_InstanceId','@@gv_ProcessMapId','D85301F7-BAF9-4BE8-A2B1-74E5CBB3D054','@@gv_ActivityMapId','#growid'");

var querySource1F49FB0DA84D47A58942368F58A2D97A =GetQueryExpressionDataSource("1F49FB0D-A84D-47A5-8942-368F58A2D97A");
Dictionary<short,object> result1F49FB0DA84D47A58942368F58A2D97A=iSpace.ExecuteQuery(querySource1F49FB0DA84D47A58942368F58A2D97A,@"EXEC LoadFormGridDataD85301F7BAF94BE8A2B174E5CBB3D054 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','D85301F7-BAF9-4BE8-A2B1-74E5CBB3D054','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["growid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource1F49FB0DA84D47A58942368F58A2D97A =GetQueryExpressionDataSource(""1F49FB0D-A84D-47A5-8942-368F58A2D97A"");Dictionary<short,object> result1F49FB0DA84D47A58942368F58A2D97A=iSpace.ExecuteQuery(querySource1F49FB0DA84D47A58942368F58A2D97A,@""EXEC LoadFormGridDataD85301F7BAF94BE8A2B174E5CBB3D054 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','D85301F7-BAF9-4BE8-A2B1-74E5CBB3D054','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""growid""].Value + @""'"",false);");
base.WriteDebugInfo(@"EXEC LoadFormGridDataD85301F7BAF94BE8A2B174E5CBB3D054 '@@gv_InstanceId','@@gv_ProcessMapId','D85301F7-BAF9-4BE8-A2B1-74E5CBB3D054','@@gv_ActivityMapId','#growid'");

if((result1F49FB0DA84D47A58942368F58A2D97A!=null) && (result1F49FB0DA84D47A58942368F58A2D97A.Count!=0))
{
if(result1F49FB0DA84D47A58942368F58A2D97A.ContainsKey(4))
ISpace["MFG_P3_BudgetHeadId"].Value = result1F49FB0DA84D47A58942368F58A2D97A[4];
if(result1F49FB0DA84D47A58942368F58A2D97A.ContainsKey(3))
ISpace["MFG_P3_ProjectDetailsId"].Value = result1F49FB0DA84D47A58942368F58A2D97A[3];
if(result1F49FB0DA84D47A58942368F58A2D97A.ContainsKey(2))
ISpace["MFG_P3_FundTypeId"].Value = result1F49FB0DA84D47A58942368F58A2D97A[2];
if(result1F49FB0DA84D47A58942368F58A2D97A.ContainsKey(5))
ISpace["MFG_P3_Amount"].Value = result1F49FB0DA84D47A58942368F58A2D97A[5];
if(result1F49FB0DA84D47A58942368F58A2D97A.ContainsKey(1))
ISpace["MFG_P3_ReimbursementId"].Value = result1F49FB0DA84D47A58942368F58A2D97A[1];
if(result1F49FB0DA84D47A58942368F58A2D97A.ContainsKey(0))
ISpace["MFG_P3_FundDetailsId"].Value = result1F49FB0DA84D47A58942368F58A2D97A[0];
}
else{
ISpace["MFG_P3_BudgetHeadId"].Value = null;ISpace["MFG_P3_ProjectDetailsId"].Value = null;ISpace["MFG_P3_FundTypeId"].Value = null;ISpace["MFG_P3_Amount"].Value = null;ISpace["MFG_P3_ReimbursementId"].Value = null;ISpace["MFG_P3_FundDetailsId"].Value = null;
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
base.WriteDebugInfo(@"Exec GetStageStatus 1,'','','#M_MoveToValue','#M_SourceActivityMapId'");

var querySource959A027E58AA471DADF1501D54E16A1B =GetQueryExpressionDataSource("959A027E-58AA-471D-ADF1-501D54E16A1B");
Dictionary<short,object> result959A027E58AA471DADF1501D54E16A1B=iSpace.ExecuteQuery(querySource959A027E58AA471DADF1501D54E16A1B,@"Exec GetStageStatus 1,'','','" + ISpace["M_MoveToValue"].Value + @"','" + ISpace["M_SourceActivityMapId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource959A027E58AA471DADF1501D54E16A1B =GetQueryExpressionDataSource(""959A027E-58AA-471D-ADF1-501D54E16A1B"");Dictionary<short,object> result959A027E58AA471DADF1501D54E16A1B=iSpace.ExecuteQuery(querySource959A027E58AA471DADF1501D54E16A1B,@""Exec GetStageStatus 1,'','','"" + ISpace[""M_MoveToValue""].Value + @""','"" + ISpace[""M_SourceActivityMapId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result959A027E58AA471DADF1501D54E16A1B!=null) && (result959A027E58AA471DADF1501D54E16A1B.Count!=0))
{
if(result959A027E58AA471DADF1501D54E16A1B.ContainsKey(1))
ISpace["M_RemarksMandatory"].Value = result959A027E58AA471DADF1501D54E16A1B[1];
if(result959A027E58AA471DADF1501D54E16A1B.ContainsKey(5))
ISpace["M_IsflowReturned"].Value = result959A027E58AA471DADF1501D54E16A1B[5];
if(result959A027E58AA471DADF1501D54E16A1B.ContainsKey(6))
ISpace["M_IsCancelReject"].Value = result959A027E58AA471DADF1501D54E16A1B[6];
if(result959A027E58AA471DADF1501D54E16A1B.ContainsKey(4))
ISpace["M_FieldMandatory"].Value = result959A027E58AA471DADF1501D54E16A1B[4];
if(result959A027E58AA471DADF1501D54E16A1B.ContainsKey(3))
ISpace["M_SaveDomainData"].Value = result959A027E58AA471DADF1501D54E16A1B[3];
if(result959A027E58AA471DADF1501D54E16A1B.ContainsKey(7))
ISpace["M_Stage"].Value = result959A027E58AA471DADF1501D54E16A1B[7];
if(result959A027E58AA471DADF1501D54E16A1B.ContainsKey(0))
ISpace["M_NextStage"].Value = result959A027E58AA471DADF1501D54E16A1B[0];
if(result959A027E58AA471DADF1501D54E16A1B.ContainsKey(2))
ISpace["MF_P1_Remarks"].Value = result959A027E58AA471DADF1501D54E16A1B[2];
}
else{
ISpace["M_RemarksMandatory"].Value = null;ISpace["M_IsflowReturned"].Value = null;ISpace["M_IsCancelReject"].Value = null;ISpace["M_FieldMandatory"].Value = null;ISpace["M_SaveDomainData"].Value = null;ISpace["M_Stage"].Value = null;ISpace["M_NextStage"].Value = null;ISpace["MF_P1_Remarks"].Value = null;
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
		if(elementName.ToLower().Equals("edit_reimbursementbilldetails"))
{
			SubscribeElementEvents_edit_reimbursementbilldetails(ref dfsParam);
}
		if(elementName.ToLower().Equals("save_reimbursementbilldetails"))
{
			SubscribeElementEvents_save_reimbursementbilldetails(ref dfsParam);
}
		if(elementName.ToLower().Equals("save_reimbursementfunddetails"))
{
			SubscribeElementEvents_save_reimbursementfunddetails(ref dfsParam);
}
		if(elementName.ToLower().Equals("submitform"))
{
			SubscribeElementEvents_submitform(ref dfsParam);
}
		if(elementName.ToLower().Equals("edit_reimbursementfunddetails"))
{
			SubscribeElementEvents_edit_reimbursementfunddetails(ref dfsParam);
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
public class ISpaceDFE5FDDDAC9D4714A58168E139EAC447 : VirtualForm
{
IISpace iSpace = new ISpace();
AcDataISpaceDFE5FDDDAC9D4714A58168E139EAC447 acdataIspaceDFE5FDDDAC9D4714A58168E139EAC447=new AcDataISpaceDFE5FDDDAC9D4714A58168E139EAC447();
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
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["FormVersionId"].Value=="9376EEBF-92B0-4B68-9085-73DD4ED3F42B")
{
ISpace["UI_BudgetColumn"].Visible="false";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""9376EEBF-92B0-4B68-9085-73DD4ED3F42B"")
{
ISpace[""UI_BudgetColumn""].Visible=""false"";
}");
ISpace["M_Classification"].Visible="false";ISpace["M_SubClassication"].Visible="false";
base.WriteDebugInfo(@"ISpace[""M_Classification""].Visible=""false"";ISpace[""M_SubClassication""].Visible=""false"";");
}

var querySource820D767A20CC4BA1AADCA484B0BFBEFA =GetQueryExpressionDataSource("820D767A-20CC-4BA1-AADC-A484B0BFBEFA");

DataTable result820D767A20CC4BA1AADCA484B0BFBEFA=iSpace.SetGridDataSource(querySource820D767A20CC4BA1AADCA484B0BFBEFA, _objectFactory.GetGridRPP("MG_RemarksDetails"),@"EXEC GetRemarks '" + ISpace["M_InstanceId"].Value + @"'");

iSpace.InsertGridBindDetails("MG_RemarksDetails","11",querySource820D767A20CC4BA1AADCA484B0BFBEFA,"EXEC GetRemarks '" + ISpace["M_InstanceId"].Value + @"'",_objectFactory.GetGridRPP("MG_RemarksDetails"));

base.WriteDebugInfo(@"var querySource820D767A20CC4BA1AADCA484B0BFBEFA =GetQueryExpressionDataSource(""820D767A-20CC-4BA1-AADC-A484B0BFBEFA"");DataTable result820D767A20CC4BA1AADCA484B0BFBEFA=iSpace.SetGridDataSource(querySource820D767A20CC4BA1AADCA484B0BFBEFA, _objectFactory.GetGridRPP(""MG_RemarksDetails""),@""EXEC GetRemarks '"" + ISpace[""M_InstanceId""].Value + @""'"");iSpace.InsertGridBindDetails(""MG_RemarksDetails"",""11"",querySource820D767A20CC4BA1AADCA484B0BFBEFA,""EXEC GetRemarks '"" + ISpace[""M_InstanceId""].Value + @""'"",_objectFactory.GetGridRPP(""MG_RemarksDetails""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> resultE57D76A324374EAF8C530F41C6AF052C=acdataIspaceDFE5FDDDAC9D4714A58168E139EAC447.GetQueryExpressionBindings("E57D76A3-2437-4EAF-8C53-0F41C6AF052C");
iSpace.SetGridData(result820D767A20CC4BA1AADCA484B0BFBEFA,resultE57D76A324374EAF8C530F41C6AF052C,"MG_RemarksDetails",ref ISpace);
iSpace.UpdateGridBindDetails("MG_RemarksDetails",resultE57D76A324374EAF8C530F41C6AF052C);
ISpace["MFG_P3_BudgetHeadId"].Visible="false";ISpace["MFG_P3_ProjectDetailsId"].Visible="false";ISpace["MFG_P3_Amount"].Visible="false";
base.WriteDebugInfo(@"ISpace[""MFG_P3_BudgetHeadId""].Visible=""false"";ISpace[""MFG_P3_ProjectDetailsId""].Visible=""false"";ISpace[""MFG_P3_Amount""].Visible=""false"";");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["MFG_P2_ItemDescription"].Man=true;ISpace["MFG_P2_BillNo"].Man=true;ISpace["MF_P1_TotalAmount"].Man=true;ISpace["MFG_P2_Amount"].Man=true;ISpace["MFG_P3_FundTypeId"].Man=true;ISpace["MFG_P3_Amount"].Man=true;ISpace["MFG_P2_BillDate"].Man=true;
base.WriteDebugInfo(@"ISpace[""MFG_P2_ItemDescription""].Man=true;ISpace[""MFG_P2_BillNo""].Man=true;ISpace[""MF_P1_TotalAmount""].Man=true;ISpace[""MFG_P2_Amount""].Man=true;ISpace[""MFG_P3_FundTypeId""].Man=true;ISpace[""MFG_P3_Amount""].Man=true;ISpace[""MFG_P2_BillDate""].Man=true;");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["M_ReimbursementType"].Value=="2")
{
base.WriteDebugInfo(@"if(ISpace[""M_ReimbursementType""].Value==""2"")");
ISpace["M_Classification"].Visible="true";ISpace["M_SubClassication"].Visible="true";
base.WriteDebugInfo(@"ISpace[""M_Classification""].Visible=""true"";ISpace[""M_SubClassication""].Visible=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["M_Classification"].Visible="false";ISpace["M_SubClassication"].Visible="false";
base.WriteDebugInfo(@"ISpace[""M_Classification""].Visible=""false"";ISpace[""M_SubClassication""].Visible=""false"";");
}
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_delete_reimbursementbilldetails (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Delete_ReimbursementBillDetails-OnClick");
ISpace["growid"].Value=ISpace["ReimbursementBillDetails_RowId"].Value;
base.WriteDebugInfo(@"ISpace[""growid""].Value=ISpace[""ReimbursementBillDetails_RowId""].Value;");
ISpace["UI_DialogBox"].ShowDialog=true;;
base.WriteDebugInfo(@"ISpace[""UI_DialogBox""].ShowDialog=true;;");
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
ISpace["growid"].Value=ISpace["ReimbursementBillDetails_RowId"].Value;
base.WriteDebugInfo(@"ISpace[""growid""].Value=ISpace[""ReimbursementBillDetails_RowId""].Value;");
base.WriteDebugInfo(@"EXEC LoadFormGridDataC9ACCA847AF347E79133D777BE46A656 '@@gv_InstanceId','@@gv_ProcessMapId','C9ACCA84-7AF3-47E7-9133-D777BE46A656','@@gv_ActivityMapId','#growid'");

var querySource3BC8920E9488421CBBA16D92ECF94CB2 =GetQueryExpressionDataSource("3BC8920E-9488-421C-BBA1-6D92ECF94CB2");
Dictionary<short,object> result3BC8920E9488421CBBA16D92ECF94CB2=iSpace.ExecuteQuery(querySource3BC8920E9488421CBBA16D92ECF94CB2,@"EXEC LoadFormGridDataC9ACCA847AF347E79133D777BE46A656 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','C9ACCA84-7AF3-47E7-9133-D777BE46A656','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["growid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource3BC8920E9488421CBBA16D92ECF94CB2 =GetQueryExpressionDataSource(""3BC8920E-9488-421C-BBA1-6D92ECF94CB2"");Dictionary<short,object> result3BC8920E9488421CBBA16D92ECF94CB2=iSpace.ExecuteQuery(querySource3BC8920E9488421CBBA16D92ECF94CB2,@""EXEC LoadFormGridDataC9ACCA847AF347E79133D777BE46A656 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','C9ACCA84-7AF3-47E7-9133-D777BE46A656','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""growid""].Value + @""'"",false);");
base.WriteDebugInfo(@"EXEC LoadFormGridDataC9ACCA847AF347E79133D777BE46A656 '@@gv_InstanceId','@@gv_ProcessMapId','C9ACCA84-7AF3-47E7-9133-D777BE46A656','@@gv_ActivityMapId','#growid'");

if((result3BC8920E9488421CBBA16D92ECF94CB2!=null) && (result3BC8920E9488421CBBA16D92ECF94CB2.Count!=0))
{
if(result3BC8920E9488421CBBA16D92ECF94CB2.ContainsKey(3))
ISpace["MFG_P2_BillDate"].Value = result3BC8920E9488421CBBA16D92ECF94CB2[3];
if(result3BC8920E9488421CBBA16D92ECF94CB2.ContainsKey(4))
ISpace["MFG_P2_BillDocument"].Value = result3BC8920E9488421CBBA16D92ECF94CB2[4];
if(result3BC8920E9488421CBBA16D92ECF94CB2.ContainsKey(6))
ISpace["MFG_P2_Amount"].Value = result3BC8920E9488421CBBA16D92ECF94CB2[6];
if(result3BC8920E9488421CBBA16D92ECF94CB2.ContainsKey(0))
ISpace["MFG_P2_ReimbursementDetailsId"].Value = result3BC8920E9488421CBBA16D92ECF94CB2[0];
if(result3BC8920E9488421CBBA16D92ECF94CB2.ContainsKey(1))
ISpace["MFG_P2_ReimbursementId"].Value = result3BC8920E9488421CBBA16D92ECF94CB2[1];
if(result3BC8920E9488421CBBA16D92ECF94CB2.ContainsKey(2))
ISpace["MFG_P2_BillNo"].Value = result3BC8920E9488421CBBA16D92ECF94CB2[2];
if(result3BC8920E9488421CBBA16D92ECF94CB2.ContainsKey(5))
ISpace["MFG_P2_ItemDescription"].Value = result3BC8920E9488421CBBA16D92ECF94CB2[5];
}
else{
ISpace["MFG_P2_BillDate"].Value = null;ISpace["MFG_P2_BillDocument"].Value = null;ISpace["MFG_P2_Amount"].Value = null;ISpace["MFG_P2_ReimbursementDetailsId"].Value = null;ISpace["MFG_P2_ReimbursementId"].Value = null;ISpace["MFG_P2_BillNo"].Value = null;ISpace["MFG_P2_ItemDescription"].Value = null;
}
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
if(ISpace["MFG_P2_BillDate"].Value>CurrentDate())
{
base.WriteDebugInfo(@"if(ISpace[""MFG_P2_BillDate""].Value>CurrentDate())");
ISpace["Message"].Value=@"Bill Date should be less than or equal to Current Date";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Bill Date should be less than or equal to Current Date"";");
ISpace["MFG_P2_BillDate"].Value=null;
base.WriteDebugInfo(@"ISpace[""MFG_P2_BillDate""].Value=null;");
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

var querySource8D078B34227340D4A2DD23A371ABE1A6 =GetQueryExpressionDataSource("8D078B34-2273-40D4-A2DD-23A371ABE1A6");

DataTable result8D078B34227340D4A2DD23A371ABE1A6=iSpace.SetGridDataSource(querySource8D078B34227340D4A2DD23A371ABE1A6, _objectFactory.GetGridRPP("ReimbursementBillDetails"),@"EXEC AddFormGridDataC9ACCA847AF347E79133D777BE46A656 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','C9ACCA84-7AF3-47E7-9133-D777BE46A656','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["MFG_P2_ReimbursementDetailsId"].Value + @"','" + ISpace["MFG_P2_ReimbursementId"].Value + @"','" + ISpace["MFG_P2_BillNo"].Value + @"','" + ISpace["MFG_P2_BillDate"].Value + @"'," + ISpace["MFG_P2_BillDocument"].Value + @",'" + ISpace["MFG_P2_ItemDescription"].Value + @"'," + ISpace["MFG_P2_Amount"].Value + @",'" + ISpace["growid"].Value + @"'");

iSpace.InsertGridBindDetails("ReimbursementBillDetails","11",querySource8D078B34227340D4A2DD23A371ABE1A6,"EXEC AddFormGridDataC9ACCA847AF347E79133D777BE46A656 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','C9ACCA84-7AF3-47E7-9133-D777BE46A656','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["MFG_P2_ReimbursementDetailsId"].Value + @"','" + ISpace["MFG_P2_ReimbursementId"].Value + @"','" + ISpace["MFG_P2_BillNo"].Value + @"','" + ISpace["MFG_P2_BillDate"].Value + @"'," + ISpace["MFG_P2_BillDocument"].Value + @",'" + ISpace["MFG_P2_ItemDescription"].Value + @"'," + ISpace["MFG_P2_Amount"].Value + @",'" + ISpace["growid"].Value + @"'",_objectFactory.GetGridRPP("ReimbursementBillDetails"));

base.WriteDebugInfo(@"var querySource8D078B34227340D4A2DD23A371ABE1A6 =GetQueryExpressionDataSource(""8D078B34-2273-40D4-A2DD-23A371ABE1A6"");DataTable result8D078B34227340D4A2DD23A371ABE1A6=iSpace.SetGridDataSource(querySource8D078B34227340D4A2DD23A371ABE1A6, _objectFactory.GetGridRPP(""ReimbursementBillDetails""),@""EXEC AddFormGridDataC9ACCA847AF347E79133D777BE46A656 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','C9ACCA84-7AF3-47E7-9133-D777BE46A656','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""MFG_P2_ReimbursementDetailsId""].Value + @""','"" + ISpace[""MFG_P2_ReimbursementId""].Value + @""','"" + ISpace[""MFG_P2_BillNo""].Value + @""','"" + ISpace[""MFG_P2_BillDate""].Value + @""',"" + ISpace[""MFG_P2_BillDocument""].Value + @"",'"" + ISpace[""MFG_P2_ItemDescription""].Value + @""',"" + ISpace[""MFG_P2_Amount""].Value + @"",'"" + ISpace[""growid""].Value + @""'"");iSpace.InsertGridBindDetails(""ReimbursementBillDetails"",""11"",querySource8D078B34227340D4A2DD23A371ABE1A6,""EXEC AddFormGridDataC9ACCA847AF347E79133D777BE46A656 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','C9ACCA84-7AF3-47E7-9133-D777BE46A656','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""MFG_P2_ReimbursementDetailsId""].Value + @""','"" + ISpace[""MFG_P2_ReimbursementId""].Value + @""','"" + ISpace[""MFG_P2_BillNo""].Value + @""','"" + ISpace[""MFG_P2_BillDate""].Value + @""',"" + ISpace[""MFG_P2_BillDocument""].Value + @"",'"" + ISpace[""MFG_P2_ItemDescription""].Value + @""',"" + ISpace[""MFG_P2_Amount""].Value + @"",'"" + ISpace[""growid""].Value + @""'"",_objectFactory.GetGridRPP(""ReimbursementBillDetails""));");
base.WriteDebugInfo(@"EXEC AddFormGridDataC9ACCA847AF347E79133D777BE46A656 '@@gv_InstanceId','@@gv_ProcessMapId','C9ACCA84-7AF3-47E7-9133-D777BE46A656','@@gv_ActivityMapId','#MFG_P2_ReimbursementDetailsId','#MFG_P2_ReimbursementId','#MFG_P2_BillNo','#MFG_P2_BillDate',#MFG_P2_BillDocument,'#MFG_P2_ItemDescription',#MFG_P2_Amount,'#growid'");


List<Triplet<string, short, short?>> resultC48E5BD17B2A4917979A69F487396125=acdataIspaceDFE5FDDDAC9D4714A58168E139EAC447.GetQueryExpressionBindings("C48E5BD1-7B2A-4917-979A-69F487396125");
iSpace.SetGridData(result8D078B34227340D4A2DD23A371ABE1A6,resultC48E5BD17B2A4917979A69F487396125,"ReimbursementBillDetails",ref ISpace);
iSpace.UpdateGridBindDetails("ReimbursementBillDetails",resultC48E5BD17B2A4917979A69F487396125);
}
else
{
base.WriteDebugInfo(@"else");

var querySource9B5B780E4C6E4FCEA2BDA3A4764A9120 =GetQueryExpressionDataSource("9B5B780E-4C6E-4FCE-A2BD-A3A4764A9120");

DataTable result9B5B780E4C6E4FCEA2BDA3A4764A9120=iSpace.SetGridDataSource(querySource9B5B780E4C6E4FCEA2BDA3A4764A9120, _objectFactory.GetGridRPP("ReimbursementBillDetails"),@"EXEC UpdateFormGridDataC9ACCA847AF347E79133D777BE46A656 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','C9ACCA84-7AF3-47E7-9133-D777BE46A656','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["MFG_P2_ReimbursementDetailsId"].Value + @"','" + ISpace["MFG_P2_ReimbursementId"].Value + @"','" + ISpace["MFG_P2_BillNo"].Value + @"','" + ISpace["MFG_P2_BillDate"].Value + @"'," + ISpace["MFG_P2_BillDocument"].Value + @",'" + ISpace["MFG_P2_ItemDescription"].Value + @"'," + ISpace["MFG_P2_Amount"].Value + @",'" + ISpace["growid"].Value + @"'");

iSpace.InsertGridBindDetails("ReimbursementBillDetails","11",querySource9B5B780E4C6E4FCEA2BDA3A4764A9120,"EXEC UpdateFormGridDataC9ACCA847AF347E79133D777BE46A656 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','C9ACCA84-7AF3-47E7-9133-D777BE46A656','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["MFG_P2_ReimbursementDetailsId"].Value + @"','" + ISpace["MFG_P2_ReimbursementId"].Value + @"','" + ISpace["MFG_P2_BillNo"].Value + @"','" + ISpace["MFG_P2_BillDate"].Value + @"'," + ISpace["MFG_P2_BillDocument"].Value + @",'" + ISpace["MFG_P2_ItemDescription"].Value + @"'," + ISpace["MFG_P2_Amount"].Value + @",'" + ISpace["growid"].Value + @"'",_objectFactory.GetGridRPP("ReimbursementBillDetails"));

base.WriteDebugInfo(@"var querySource9B5B780E4C6E4FCEA2BDA3A4764A9120 =GetQueryExpressionDataSource(""9B5B780E-4C6E-4FCE-A2BD-A3A4764A9120"");DataTable result9B5B780E4C6E4FCEA2BDA3A4764A9120=iSpace.SetGridDataSource(querySource9B5B780E4C6E4FCEA2BDA3A4764A9120, _objectFactory.GetGridRPP(""ReimbursementBillDetails""),@""EXEC UpdateFormGridDataC9ACCA847AF347E79133D777BE46A656 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','C9ACCA84-7AF3-47E7-9133-D777BE46A656','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""MFG_P2_ReimbursementDetailsId""].Value + @""','"" + ISpace[""MFG_P2_ReimbursementId""].Value + @""','"" + ISpace[""MFG_P2_BillNo""].Value + @""','"" + ISpace[""MFG_P2_BillDate""].Value + @""',"" + ISpace[""MFG_P2_BillDocument""].Value + @"",'"" + ISpace[""MFG_P2_ItemDescription""].Value + @""',"" + ISpace[""MFG_P2_Amount""].Value + @"",'"" + ISpace[""growid""].Value + @""'"");iSpace.InsertGridBindDetails(""ReimbursementBillDetails"",""11"",querySource9B5B780E4C6E4FCEA2BDA3A4764A9120,""EXEC UpdateFormGridDataC9ACCA847AF347E79133D777BE46A656 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','C9ACCA84-7AF3-47E7-9133-D777BE46A656','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""MFG_P2_ReimbursementDetailsId""].Value + @""','"" + ISpace[""MFG_P2_ReimbursementId""].Value + @""','"" + ISpace[""MFG_P2_BillNo""].Value + @""','"" + ISpace[""MFG_P2_BillDate""].Value + @""',"" + ISpace[""MFG_P2_BillDocument""].Value + @"",'"" + ISpace[""MFG_P2_ItemDescription""].Value + @""',"" + ISpace[""MFG_P2_Amount""].Value + @"",'"" + ISpace[""growid""].Value + @""'"",_objectFactory.GetGridRPP(""ReimbursementBillDetails""));");
base.WriteDebugInfo(@"EXEC UpdateFormGridDataC9ACCA847AF347E79133D777BE46A656 '@@gv_InstanceId','@@gv_ProcessMapId','C9ACCA84-7AF3-47E7-9133-D777BE46A656','@@gv_ActivityMapId','#MFG_P2_ReimbursementDetailsId','#MFG_P2_ReimbursementId','#MFG_P2_BillNo','#MFG_P2_BillDate',#MFG_P2_BillDocument,'#MFG_P2_ItemDescription',#MFG_P2_Amount,'#growid'");


List<Triplet<string, short, short?>> result9EA07CACF2274E83A5EE8C316E74D75C=acdataIspaceDFE5FDDDAC9D4714A58168E139EAC447.GetQueryExpressionBindings("9EA07CAC-F227-4E83-A5EE-8C316E74D75C");
iSpace.SetGridData(result9B5B780E4C6E4FCEA2BDA3A4764A9120,result9EA07CACF2274E83A5EE8C316E74D75C,"ReimbursementBillDetails",ref ISpace);
iSpace.UpdateGridBindDetails("ReimbursementBillDetails",result9EA07CACF2274E83A5EE8C316E74D75C);
}
object MG_P2_Amount=iSpace.Sum("[1D198218-D4AF-4E09-9A9D-119D03D0C3BA]","MG_P2_Amount","",ISpace["gv_instanceid"].Value);
ISpace["MF_P1_TotalAmount"].Value=Convert.ChangeType(MG_P2_Amount, MG_P2_Amount.GetType());;
base.WriteDebugInfo(@"object MG_P2_Amount=iSpace.Sum(""[1D198218-D4AF-4E09-9A9D-119D03D0C3BA]"",""MG_P2_Amount"","""",ISpace[""gv_instanceid""].Value);
ISpace[""MF_P1_TotalAmount""].Value=Convert.ChangeType(MG_P2_Amount, MG_P2_Amount.GetType());;");
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
private void SubscribeElementEvents_m_classification (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"M_Classification-OnChange");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["M_SubClassication"].rElemData=iSpace.Reload(ISpace["M_SubClassication"].Value,@"exec LoadItemSubCombo '" + ISpace["M_Classification"].Value + @"'","3A103712-5244-4427-B2B6-1C4E046FD337");
base.WriteDebugInfo(@"ISpace[""M_SubClassication""].rElemData=iSpace.Reload(ISpace[""M_SubClassication""].Value,@""exec LoadItemSubCombo '"" + ISpace[""M_Classification""].Value + @""'"",""3A103712-5244-4427-B2B6-1C4E046FD337"");");
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_delete_reimbursementfunddetails (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Delete_ReimbursementFundDetails-OnClick");
ISpace["growid"].Value=ISpace["ReimbursementFundDetails_RowId"].Value;
base.WriteDebugInfo(@"ISpace[""growid""].Value=ISpace[""ReimbursementFundDetails_RowId""].Value;");
ISpace["UI_DialogBox1"].ShowDialog=true;;
base.WriteDebugInfo(@"ISpace[""UI_DialogBox1""].ShowDialog=true;;");
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
base.WriteDebugInfo(@"EXEC [ValidatePaymentFundAvailability] '#MFG_P3_FundTypeId','#MFG_P3_ProjectDetailsId','#MFG_P3_BudgetHeadId','#UC_EmployeeBaicInfoId','#MFG_P3_Amount'");

var querySource65F843A227D04177B79DCF4225F30450 =GetQueryExpressionDataSource("65F843A2-27D0-4177-B79D-CF4225F30450");
Dictionary<short,object> result65F843A227D04177B79DCF4225F30450=iSpace.ExecuteQuery(querySource65F843A227D04177B79DCF4225F30450,@"EXEC [ValidatePaymentFundAvailability] '" + ISpace["MFG_P3_FundTypeId"].Value + @"','" + ISpace["MFG_P3_ProjectDetailsId"].Value + @"','" + ISpace["MFG_P3_BudgetHeadId"].Value + @"','" + ISpace["UC_EmployeeBaicInfoId"].Value + @"','" + ISpace["MFG_P3_Amount"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource65F843A227D04177B79DCF4225F30450 =GetQueryExpressionDataSource(""65F843A2-27D0-4177-B79D-CF4225F30450"");Dictionary<short,object> result65F843A227D04177B79DCF4225F30450=iSpace.ExecuteQuery(querySource65F843A227D04177B79DCF4225F30450,@""EXEC [ValidatePaymentFundAvailability] '"" + ISpace[""MFG_P3_FundTypeId""].Value + @""','"" + ISpace[""MFG_P3_ProjectDetailsId""].Value + @""','"" + ISpace[""MFG_P3_BudgetHeadId""].Value + @""','"" + ISpace[""UC_EmployeeBaicInfoId""].Value + @""','"" + ISpace[""MFG_P3_Amount""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result65F843A227D04177B79DCF4225F30450!=null) && (result65F843A227D04177B79DCF4225F30450.Count!=0))
{
if(result65F843A227D04177B79DCF4225F30450.ContainsKey(0))
ISpace["M_ErrId"].Value = result65F843A227D04177B79DCF4225F30450[0];
if(result65F843A227D04177B79DCF4225F30450.ContainsKey(1))
ISpace["M_ErrMsg"].Value = result65F843A227D04177B79DCF4225F30450[1];
}
else{
ISpace["M_ErrId"].Value = null;ISpace["M_ErrMsg"].Value = null;
}
if(ISpace["M_ErrId"].Value==0&&ISpace["MFG_P3_FundTypeId"].Value=="1")
{
base.WriteDebugInfo(@"if(ISpace[""M_ErrId""].Value==0&&ISpace[""MFG_P3_FundTypeId""].Value==""1"")");
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
if (_elementBase != null)  iSpace.SetLoopExpressionData("ReimbursementFundDetails","84AEB9E0-3009-4426-AB92-AAF06D2B42AF",_objectFactory.GetGridRPP("ReimbursementFundDetails"),_elementBase.GetGridLoopQuery("84AEB9E0-3009-4426-AB92-AAF06D2B42AF","ReimbursementFundDetails",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""ReimbursementFundDetails"",ref ISpace);

foreach(var gridChild in ISpace[""ReimbursementFundDetails""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
}
if(ISpace["growid"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""growid""].Value=="""")");

var querySourceCBB3928101F44B3AB89247A0222DAFBA =GetQueryExpressionDataSource("CBB39281-01F4-4B3A-B892-47A0222DAFBA");

DataTable resultCBB3928101F44B3AB89247A0222DAFBA=iSpace.SetGridDataSource(querySourceCBB3928101F44B3AB89247A0222DAFBA, _objectFactory.GetGridRPP("ReimbursementFundDetails"),@"EXEC AddFormGridDataD85301F7BAF94BE8A2B174E5CBB3D054 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','D85301F7-BAF9-4BE8-A2B1-74E5CBB3D054','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["MFG_P3_FundDetailsId"].Value + @"','" + ISpace["MFG_P3_ReimbursementId"].Value + @"','" + ISpace["MFG_P3_FundTypeId"].Value + @"','" + ISpace["MFG_P3_ProjectDetailsId"].Value + @"','" + ISpace["MFG_P3_BudgetHeadId"].Value + @"','" + ISpace["MFG_P3_Amount"].Value + @"','" + ISpace["growid"].Value + @"'");

iSpace.InsertGridBindDetails("ReimbursementFundDetails","11",querySourceCBB3928101F44B3AB89247A0222DAFBA,"EXEC AddFormGridDataD85301F7BAF94BE8A2B174E5CBB3D054 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','D85301F7-BAF9-4BE8-A2B1-74E5CBB3D054','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["MFG_P3_FundDetailsId"].Value + @"','" + ISpace["MFG_P3_ReimbursementId"].Value + @"','" + ISpace["MFG_P3_FundTypeId"].Value + @"','" + ISpace["MFG_P3_ProjectDetailsId"].Value + @"','" + ISpace["MFG_P3_BudgetHeadId"].Value + @"','" + ISpace["MFG_P3_Amount"].Value + @"','" + ISpace["growid"].Value + @"'",_objectFactory.GetGridRPP("ReimbursementFundDetails"));

base.WriteDebugInfo(@"var querySourceCBB3928101F44B3AB89247A0222DAFBA =GetQueryExpressionDataSource(""CBB39281-01F4-4B3A-B892-47A0222DAFBA"");DataTable resultCBB3928101F44B3AB89247A0222DAFBA=iSpace.SetGridDataSource(querySourceCBB3928101F44B3AB89247A0222DAFBA, _objectFactory.GetGridRPP(""ReimbursementFundDetails""),@""EXEC AddFormGridDataD85301F7BAF94BE8A2B174E5CBB3D054 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','D85301F7-BAF9-4BE8-A2B1-74E5CBB3D054','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""MFG_P3_FundDetailsId""].Value + @""','"" + ISpace[""MFG_P3_ReimbursementId""].Value + @""','"" + ISpace[""MFG_P3_FundTypeId""].Value + @""','"" + ISpace[""MFG_P3_ProjectDetailsId""].Value + @""','"" + ISpace[""MFG_P3_BudgetHeadId""].Value + @""','"" + ISpace[""MFG_P3_Amount""].Value + @""','"" + ISpace[""growid""].Value + @""'"");iSpace.InsertGridBindDetails(""ReimbursementFundDetails"",""11"",querySourceCBB3928101F44B3AB89247A0222DAFBA,""EXEC AddFormGridDataD85301F7BAF94BE8A2B174E5CBB3D054 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','D85301F7-BAF9-4BE8-A2B1-74E5CBB3D054','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""MFG_P3_FundDetailsId""].Value + @""','"" + ISpace[""MFG_P3_ReimbursementId""].Value + @""','"" + ISpace[""MFG_P3_FundTypeId""].Value + @""','"" + ISpace[""MFG_P3_ProjectDetailsId""].Value + @""','"" + ISpace[""MFG_P3_BudgetHeadId""].Value + @""','"" + ISpace[""MFG_P3_Amount""].Value + @""','"" + ISpace[""growid""].Value + @""'"",_objectFactory.GetGridRPP(""ReimbursementFundDetails""));");
base.WriteDebugInfo(@"EXEC AddFormGridDataD85301F7BAF94BE8A2B174E5CBB3D054 '@@gv_InstanceId','@@gv_ProcessMapId','D85301F7-BAF9-4BE8-A2B1-74E5CBB3D054','@@gv_ActivityMapId','#MFG_P3_FundDetailsId','#MFG_P3_ReimbursementId','#MFG_P3_FundTypeId','#MFG_P3_ProjectDetailsId','#MFG_P3_BudgetHeadId',#MFG_P3_Amount,'#growid'");


List<Triplet<string, short, short?>> result25A00CF73B354322B4DFFE24D90229BC=acdataIspaceDFE5FDDDAC9D4714A58168E139EAC447.GetQueryExpressionBindings("25A00CF7-3B35-4322-B4DF-FE24D90229BC");
iSpace.SetGridData(resultCBB3928101F44B3AB89247A0222DAFBA,result25A00CF73B354322B4DFFE24D90229BC,"ReimbursementFundDetails",ref ISpace);
iSpace.UpdateGridBindDetails("ReimbursementFundDetails",result25A00CF73B354322B4DFFE24D90229BC);
}
else
{
base.WriteDebugInfo(@"else");

var querySource334BDAE0A76B4B0F84BCAEF7F4F927FE =GetQueryExpressionDataSource("334BDAE0-A76B-4B0F-84BC-AEF7F4F927FE");

DataTable result334BDAE0A76B4B0F84BCAEF7F4F927FE=iSpace.SetGridDataSource(querySource334BDAE0A76B4B0F84BCAEF7F4F927FE, _objectFactory.GetGridRPP("ReimbursementFundDetails"),@"EXEC UpdateFormGridDataD85301F7BAF94BE8A2B174E5CBB3D054 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','D85301F7-BAF9-4BE8-A2B1-74E5CBB3D054','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["MFG_P3_FundDetailsId"].Value + @"','" + ISpace["MFG_P3_ReimbursementId"].Value + @"','" + ISpace["MFG_P3_FundTypeId"].Value + @"','" + ISpace["MFG_P3_ProjectDetailsId"].Value + @"','" + ISpace["MFG_P3_BudgetHeadId"].Value + @"'," + ISpace["MFG_P3_Amount"].Value + @",'" + ISpace["growid"].Value + @"'");

iSpace.InsertGridBindDetails("ReimbursementFundDetails","11",querySource334BDAE0A76B4B0F84BCAEF7F4F927FE,"EXEC UpdateFormGridDataD85301F7BAF94BE8A2B174E5CBB3D054 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','D85301F7-BAF9-4BE8-A2B1-74E5CBB3D054','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["MFG_P3_FundDetailsId"].Value + @"','" + ISpace["MFG_P3_ReimbursementId"].Value + @"','" + ISpace["MFG_P3_FundTypeId"].Value + @"','" + ISpace["MFG_P3_ProjectDetailsId"].Value + @"','" + ISpace["MFG_P3_BudgetHeadId"].Value + @"'," + ISpace["MFG_P3_Amount"].Value + @",'" + ISpace["growid"].Value + @"'",_objectFactory.GetGridRPP("ReimbursementFundDetails"));

base.WriteDebugInfo(@"var querySource334BDAE0A76B4B0F84BCAEF7F4F927FE =GetQueryExpressionDataSource(""334BDAE0-A76B-4B0F-84BC-AEF7F4F927FE"");DataTable result334BDAE0A76B4B0F84BCAEF7F4F927FE=iSpace.SetGridDataSource(querySource334BDAE0A76B4B0F84BCAEF7F4F927FE, _objectFactory.GetGridRPP(""ReimbursementFundDetails""),@""EXEC UpdateFormGridDataD85301F7BAF94BE8A2B174E5CBB3D054 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','D85301F7-BAF9-4BE8-A2B1-74E5CBB3D054','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""MFG_P3_FundDetailsId""].Value + @""','"" + ISpace[""MFG_P3_ReimbursementId""].Value + @""','"" + ISpace[""MFG_P3_FundTypeId""].Value + @""','"" + ISpace[""MFG_P3_ProjectDetailsId""].Value + @""','"" + ISpace[""MFG_P3_BudgetHeadId""].Value + @""',"" + ISpace[""MFG_P3_Amount""].Value + @"",'"" + ISpace[""growid""].Value + @""'"");iSpace.InsertGridBindDetails(""ReimbursementFundDetails"",""11"",querySource334BDAE0A76B4B0F84BCAEF7F4F927FE,""EXEC UpdateFormGridDataD85301F7BAF94BE8A2B174E5CBB3D054 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','D85301F7-BAF9-4BE8-A2B1-74E5CBB3D054','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""MFG_P3_FundDetailsId""].Value + @""','"" + ISpace[""MFG_P3_ReimbursementId""].Value + @""','"" + ISpace[""MFG_P3_FundTypeId""].Value + @""','"" + ISpace[""MFG_P3_ProjectDetailsId""].Value + @""','"" + ISpace[""MFG_P3_BudgetHeadId""].Value + @""',"" + ISpace[""MFG_P3_Amount""].Value + @"",'"" + ISpace[""growid""].Value + @""'"",_objectFactory.GetGridRPP(""ReimbursementFundDetails""));");
base.WriteDebugInfo(@"EXEC UpdateFormGridDataD85301F7BAF94BE8A2B174E5CBB3D054 '@@gv_InstanceId','@@gv_ProcessMapId','D85301F7-BAF9-4BE8-A2B1-74E5CBB3D054','@@gv_ActivityMapId','#MFG_P3_FundDetailsId','#MFG_P3_ReimbursementId','#MFG_P3_FundTypeId','#MFG_P3_ProjectDetailsId','#MFG_P3_BudgetHeadId',#MFG_P3_Amount,'#growid'");


List<Triplet<string, short, short?>> resultEFFC55B685564D91AE91384F68B422FF=acdataIspaceDFE5FDDDAC9D4714A58168E139EAC447.GetQueryExpressionBindings("EFFC55B6-8556-4D91-AE91-384F68B422FF");
iSpace.SetGridData(result334BDAE0A76B4B0F84BCAEF7F4F927FE,resultEFFC55B685564D91AE91384F68B422FF,"ReimbursementFundDetails",ref ISpace);
iSpace.UpdateGridBindDetails("ReimbursementFundDetails",resultEFFC55B685564D91AE91384F68B422FF);
}
base.WriteDebugInfo(@"#ReimbursementFundDetails[Rows]");
iSpace.GetLoopExpressionData("ReimbursementFundDetails",ref ISpace);

foreach(var gridChild in ISpace["ReimbursementFundDetails"].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 



ISpace["MG_P3_PackageProcessMapId"].Value=ISpace["M_PackageProcessMapId"].Value;
base.WriteDebugInfo(@"

ISpace[""MG_P3_PackageProcessMapId""].Value=ISpace[""M_PackageProcessMapId""].Value;");


ISpace["MG_P3_EmployeeBaicInfoId"].Value=ISpace["UC_EmployeeBaicInfoId"].Value;
base.WriteDebugInfo(@"

ISpace[""MG_P3_EmployeeBaicInfoId""].Value=ISpace[""UC_EmployeeBaicInfoId""].Value;");
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("ReimbursementFundDetails","84AEB9E0-3009-4426-AB92-AAF06D2B42AF",_objectFactory.GetGridRPP("ReimbursementFundDetails"),_elementBase.GetGridLoopQuery("84AEB9E0-3009-4426-AB92-AAF06D2B42AF","ReimbursementFundDetails",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""ReimbursementFundDetails"",ref ISpace);

foreach(var gridChild in ISpace[""ReimbursementFundDetails""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
object MG_P3_Amount=iSpace.Sum("[84AEB9E0-3009-4426-AB92-AAF06D2B42AF]","MG_P3_Amount","",ISpace["gv_instanceid"].Value);
ISpace["MFG_P3_OverallAmount"].Value=Convert.ChangeType(MG_P3_Amount, MG_P3_Amount.GetType());;
base.WriteDebugInfo(@"object MG_P3_Amount=iSpace.Sum(""[84AEB9E0-3009-4426-AB92-AAF06D2B42AF]"",""MG_P3_Amount"","""",ISpace[""gv_instanceid""].Value);
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
private void SubscribeElementEvents_m_reimbursementtype (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"M_ReimbursementType-OnChange");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["M_ReimbursementType"].Value=="2")
{
base.WriteDebugInfo(@"if(ISpace[""M_ReimbursementType""].Value==""2"")");
ISpace["M_Classification"].Visible="true";ISpace["M_SubClassication"].Visible="true";
base.WriteDebugInfo(@"ISpace[""M_Classification""].Visible=""true"";ISpace[""M_SubClassication""].Visible=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["M_Classification"].Visible="false";ISpace["M_SubClassication"].Visible="false";
base.WriteDebugInfo(@"ISpace[""M_Classification""].Visible=""false"";ISpace[""M_SubClassication""].Visible=""false"";");
}
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
base.WriteDebugInfo(@"EXEC UpsertActivityTrailLogDetails '@@gv_TenantId','#M_InstanceId','@@gv_ActivityName','#MF_P1_Remarks','@@gv_UserName','#M_SourceActivityMapId','#SetDestinationTo','@@gv_UserId','#M_IsSourceStep'");

var querySourcebefdd5b207e912dc5d3682026e5e2134 =GetQueryExpressionDataSource("befdd5b2-07e9-12dc-5d36-82026e5e2134");
Dictionary<short,object> resultbefdd5b207e912dc5d3682026e5e2134=iSpace.ExecuteQuery(querySourcebefdd5b207e912dc5d3682026e5e2134,@"EXEC UpsertActivityTrailLogDetails '" + ISpace["gv_tenantid"].Value + @"','" + ISpace["M_InstanceId"].Value + @"','" + ISpace["gv_activityname"].Value + @"','" + ISpace["MF_P1_Remarks"].Value + @"','" + ISpace["gv_username"].Value + @"','" + ISpace["M_SourceActivityMapId"].Value + @"','" + ISpace["SetDestinationTo"].Value + @"','" + ISpace["gv_userid"].Value + @"','" + ISpace["M_IsSourceStep"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourcebefdd5b207e912dc5d3682026e5e2134 =GetQueryExpressionDataSource(""befdd5b2-07e9-12dc-5d36-82026e5e2134"");Dictionary<short,object> resultbefdd5b207e912dc5d3682026e5e2134=iSpace.ExecuteQuery(querySourcebefdd5b207e912dc5d3682026e5e2134,@""EXEC UpsertActivityTrailLogDetails '"" + ISpace[""gv_tenantid""].Value + @""','"" + ISpace[""M_InstanceId""].Value + @""','"" + ISpace[""gv_activityname""].Value + @""','"" + ISpace[""MF_P1_Remarks""].Value + @""','"" + ISpace[""gv_username""].Value + @""','"" + ISpace[""M_SourceActivityMapId""].Value + @""','"" + ISpace[""SetDestinationTo""].Value + @""','"" + ISpace[""gv_userid""].Value + @""','"" + ISpace[""M_IsSourceStep""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultbefdd5b207e912dc5d3682026e5e2134!=null) && (resultbefdd5b207e912dc5d3682026e5e2134.Count!=0))
{
if(resultbefdd5b207e912dc5d3682026e5e2134.ContainsKey(0))
ISpace["ExecutionMessage"].Value = resultbefdd5b207e912dc5d3682026e5e2134[0];
}
else{
ISpace["ExecutionMessage"].Value = null;
}
}
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
ISpace["MF_P1_ApplicationStatus"].Value="A";
base.WriteDebugInfo(@"ISpace[""MF_P1_ApplicationStatus""].Value=""A"";");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC UpsertProjectReimbursement '#MF_P1_ReimbursementId','#UC_EmployeeBaicInfoId','#MF_P1_TotalAmount','@@gv_UserId','#MF_P1_ApplicationStatus','#M_ReimbursementType','#M_Classification','#M_SubClassication','@@gv_UserId'");

var querySourced58dc3c8687f1ebcd4754068de464713 =GetQueryExpressionDataSource("d58dc3c8-687f-1ebc-d475-4068de464713");
Dictionary<short,object> resultd58dc3c8687f1ebcd4754068de464713=iSpace.ExecuteQuery(querySourced58dc3c8687f1ebcd4754068de464713,@"EXEC UpsertProjectReimbursement '" + ISpace["MF_P1_ReimbursementId"].Value + @"','" + ISpace["UC_EmployeeBaicInfoId"].Value + @"','" + ISpace["MF_P1_TotalAmount"].Value + @"','" + ISpace["gv_userid"].Value + @"','" + ISpace["MF_P1_ApplicationStatus"].Value + @"','" + ISpace["M_ReimbursementType"].Value + @"','" + ISpace["M_Classification"].Value + @"','" + ISpace["M_SubClassication"].Value + @"','" + ISpace["gv_userid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourced58dc3c8687f1ebcd4754068de464713 =GetQueryExpressionDataSource(""d58dc3c8-687f-1ebc-d475-4068de464713"");Dictionary<short,object> resultd58dc3c8687f1ebcd4754068de464713=iSpace.ExecuteQuery(querySourced58dc3c8687f1ebcd4754068de464713,@""EXEC UpsertProjectReimbursement '"" + ISpace[""MF_P1_ReimbursementId""].Value + @""','"" + ISpace[""UC_EmployeeBaicInfoId""].Value + @""','"" + ISpace[""MF_P1_TotalAmount""].Value + @""','"" + ISpace[""gv_userid""].Value + @""','"" + ISpace[""MF_P1_ApplicationStatus""].Value + @""','"" + ISpace[""M_ReimbursementType""].Value + @""','"" + ISpace[""M_Classification""].Value + @""','"" + ISpace[""M_SubClassication""].Value + @""','"" + ISpace[""gv_userid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultd58dc3c8687f1ebcd4754068de464713!=null) && (resultd58dc3c8687f1ebcd4754068de464713.Count!=0))
{
if(resultd58dc3c8687f1ebcd4754068de464713.ContainsKey(0))
ISpace["ExecutionMessage"].Value = resultd58dc3c8687f1ebcd4754068de464713[0];
}
else{
ISpace["ExecutionMessage"].Value = null;
}
base.WriteDebugInfo(@"EXEC UpsertProjectReimbursementFundDetails '#MG_P3_FundDetailsId','#MF_P1_ReimbursementId','#MG_P3_FundTypeId','#MG_P3_ProjectDetailsId','#MG_P3_BudgetHeadId','#MG_P3_Amount'");

var querySource478236c45c793773d35402c74092c916 =GetQueryExpressionDataSource("478236c4-5c79-3773-d354-02c74092c916");
Dictionary<short,object> result478236c45c793773d35402c74092c916=iSpace.ExecuteQuery(querySource478236c45c793773d35402c74092c916,@"EXEC UpsertProjectReimbursementFundDetails '" + ISpace["MG_P3_FundDetailsId"].Value + @"','" + ISpace["MF_P1_ReimbursementId"].Value + @"','" + ISpace["MG_P3_FundTypeId"].Value + @"','" + ISpace["MG_P3_ProjectDetailsId"].Value + @"','" + ISpace["MG_P3_BudgetHeadId"].Value + @"','" + ISpace["MG_P3_Amount"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource478236c45c793773d35402c74092c916 =GetQueryExpressionDataSource(""478236c4-5c79-3773-d354-02c74092c916"");Dictionary<short,object> result478236c45c793773d35402c74092c916=iSpace.ExecuteQuery(querySource478236c45c793773d35402c74092c916,@""EXEC UpsertProjectReimbursementFundDetails '"" + ISpace[""MG_P3_FundDetailsId""].Value + @""','"" + ISpace[""MF_P1_ReimbursementId""].Value + @""','"" + ISpace[""MG_P3_FundTypeId""].Value + @""','"" + ISpace[""MG_P3_ProjectDetailsId""].Value + @""','"" + ISpace[""MG_P3_BudgetHeadId""].Value + @""','"" + ISpace[""MG_P3_Amount""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result478236c45c793773d35402c74092c916!=null) && (result478236c45c793773d35402c74092c916.Count!=0))
{
if(result478236c45c793773d35402c74092c916.ContainsKey(0))
ISpace["ExecutionMessage"].Value = result478236c45c793773d35402c74092c916[0];
}
else{
ISpace["ExecutionMessage"].Value = null;
}
base.WriteDebugInfo(@"EXEC UpsertProjectReimbursementBillDetails '#MG_P2_ReimbursementDetailsId','#MF_P1_ReimbursementId','#MG_P2_BillNo','#MG_P2_BillDate',NULL,'#MG_P2_ItemDescription','#MG_P2_Amount'");

var querySource0ac6af4e84d7e8d409946108bb08331c =GetQueryExpressionDataSource("0ac6af4e-84d7-e8d4-0994-6108bb08331c");
Dictionary<short,object> result0ac6af4e84d7e8d409946108bb08331c=iSpace.ExecuteQuery(querySource0ac6af4e84d7e8d409946108bb08331c,@"EXEC UpsertProjectReimbursementBillDetails '" + ISpace["MG_P2_ReimbursementDetailsId"].Value + @"','" + ISpace["MF_P1_ReimbursementId"].Value + @"','" + ISpace["MG_P2_BillNo"].Value + @"','" + ISpace["MG_P2_BillDate"].Value + @"',NULL,'" + ISpace["MG_P2_ItemDescription"].Value + @"','" + ISpace["MG_P2_Amount"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource0ac6af4e84d7e8d409946108bb08331c =GetQueryExpressionDataSource(""0ac6af4e-84d7-e8d4-0994-6108bb08331c"");Dictionary<short,object> result0ac6af4e84d7e8d409946108bb08331c=iSpace.ExecuteQuery(querySource0ac6af4e84d7e8d409946108bb08331c,@""EXEC UpsertProjectReimbursementBillDetails '"" + ISpace[""MG_P2_ReimbursementDetailsId""].Value + @""','"" + ISpace[""MF_P1_ReimbursementId""].Value + @""','"" + ISpace[""MG_P2_BillNo""].Value + @""','"" + ISpace[""MG_P2_BillDate""].Value + @""',NULL,'"" + ISpace[""MG_P2_ItemDescription""].Value + @""','"" + ISpace[""MG_P2_Amount""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result0ac6af4e84d7e8d409946108bb08331c!=null) && (result0ac6af4e84d7e8d409946108bb08331c.Count!=0))
{
if(result0ac6af4e84d7e8d409946108bb08331c.ContainsKey(0))
ISpace["ExecutionMessage"].Value = result0ac6af4e84d7e8d409946108bb08331c[0];
}
else{
ISpace["ExecutionMessage"].Value = null;
}
base.WriteDebugInfo(@"EXEC UpsertDocumentDetails '#M_DocumentDetailsId','#M_InstanceId','#M_PackageProcessMapId','#M_DocumentName','#M_UploadDcoument',' @@gv_UserId'");

var querySource17adfd2bbf7aa7968851003732efc9c7 =GetQueryExpressionDataSource("17adfd2b-bf7a-a796-8851-003732efc9c7");
Dictionary<short,object> result17adfd2bbf7aa7968851003732efc9c7=iSpace.ExecuteQuery(querySource17adfd2bbf7aa7968851003732efc9c7,@"EXEC UpsertDocumentDetails '" + ISpace["M_DocumentDetailsId"].Value + @"','" + ISpace["M_InstanceId"].Value + @"','" + ISpace["M_PackageProcessMapId"].Value + @"','" + ISpace["M_DocumentName"].Value + @"','" + ISpace["M_UploadDcoument"].Value + @"',' " + ISpace["gv_userid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource17adfd2bbf7aa7968851003732efc9c7 =GetQueryExpressionDataSource(""17adfd2b-bf7a-a796-8851-003732efc9c7"");Dictionary<short,object> result17adfd2bbf7aa7968851003732efc9c7=iSpace.ExecuteQuery(querySource17adfd2bbf7aa7968851003732efc9c7,@""EXEC UpsertDocumentDetails '"" + ISpace[""M_DocumentDetailsId""].Value + @""','"" + ISpace[""M_InstanceId""].Value + @""','"" + ISpace[""M_PackageProcessMapId""].Value + @""','"" + ISpace[""M_DocumentName""].Value + @""','"" + ISpace[""M_UploadDcoument""].Value + @""',' "" + ISpace[""gv_userid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result17adfd2bbf7aa7968851003732efc9c7!=null) && (result17adfd2bbf7aa7968851003732efc9c7.Count!=0))
{
if(result17adfd2bbf7aa7968851003732efc9c7.ContainsKey(0))
ISpace["ExecutionMessage"].Value = result17adfd2bbf7aa7968851003732efc9c7[0];
}
else{
ISpace["ExecutionMessage"].Value = null;
}
}
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
object M_DocumentDetailsId=iSpace.Count("[93570AD2-BC61-4B0C-AE1C-2A20265D17E7]","M_DocumentDetailsId","",ISpace["gv_instanceid"].Value);
ISpace["M_Gridcount"].Value=Convert.ChangeType(M_DocumentDetailsId, M_DocumentDetailsId.GetType());;
base.WriteDebugInfo(@"object M_DocumentDetailsId=iSpace.Count(""[93570AD2-BC61-4B0C-AE1C-2A20265D17E7]"",""M_DocumentDetailsId"","""",ISpace[""gv_instanceid""].Value);
ISpace[""M_Gridcount""].Value=Convert.ChangeType(M_DocumentDetailsId, M_DocumentDetailsId.GetType());;");
if(ISpace["M_Gridcount"].Value==0)
{
base.WriteDebugInfo(@"if(ISpace[""M_Gridcount""].Value==0)");
ISpace["Message"].Value=@"Please upload atleast one Document in Document Details Grid";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please upload atleast one Document in Document Details Grid"";");
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
if (_elementBase != null)  iSpace.SetLoopExpressionData("MG_DcoumentDetails","93570AD2-BC61-4B0C-AE1C-2A20265D17E7",_objectFactory.GetGridRPP("MG_DcoumentDetails"),_elementBase.GetGridLoopQuery("93570AD2-BC61-4B0C-AE1C-2A20265D17E7","MG_DcoumentDetails",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""MG_DcoumentDetails"",ref ISpace);

foreach(var gridChild in ISpace[""MG_DcoumentDetails""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
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
base.WriteDebugInfo(@"EXEC [UpsertProjectBudgetDetails] 6,'#MG_P3_ProjectDetailsId','','#MG_P3_Amount','#MG_P3_BudgetHeadId',1,'#MG_P3_FundTypeId'");

var querySource9DA02CB350924C4C9B655E0BE2B0C944 =GetQueryExpressionDataSource("9DA02CB3-5092-4C4C-9B65-5E0BE2B0C944");
Dictionary<short,object> result9DA02CB350924C4C9B655E0BE2B0C944=iSpace.ExecuteQuery(querySource9DA02CB350924C4C9B655E0BE2B0C944,@"EXEC [UpsertProjectBudgetDetails] 6,'" + ISpace["MG_P3_ProjectDetailsId"].Value + @"','','" + ISpace["MG_P3_Amount"].Value + @"','" + ISpace["MG_P3_BudgetHeadId"].Value + @"',1,'" + ISpace["MG_P3_FundTypeId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource9DA02CB350924C4C9B655E0BE2B0C944 =GetQueryExpressionDataSource(""9DA02CB3-5092-4C4C-9B65-5E0BE2B0C944"");Dictionary<short,object> result9DA02CB350924C4C9B655E0BE2B0C944=iSpace.ExecuteQuery(querySource9DA02CB350924C4C9B655E0BE2B0C944,@""EXEC [UpsertProjectBudgetDetails] 6,'"" + ISpace[""MG_P3_ProjectDetailsId""].Value + @""','','"" + ISpace[""MG_P3_Amount""].Value + @""','"" + ISpace[""MG_P3_BudgetHeadId""].Value + @""',1,'"" + ISpace[""MG_P3_FundTypeId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result9DA02CB350924C4C9B655E0BE2B0C944!=null) && (result9DA02CB350924C4C9B655E0BE2B0C944.Count!=0))
{
if(result9DA02CB350924C4C9B655E0BE2B0C944.ContainsKey(0))
ISpace["M_UpdateCount"].Value = result9DA02CB350924C4C9B655E0BE2B0C944[0];
}
else{
ISpace["M_UpdateCount"].Value = null;
}
}
else
{
base.WriteDebugInfo(@"else");
base.WriteDebugInfo(@"EXEC [UpsertProjectBudgetDetails] 5,'#MG_P3_ProjectDetailsId','','#MG_P3_Amount','#MG_P3_BudgetHeadId',1,'#MG_P3_FundTypeId'");

var querySourceC27F66A46C2443FF8C149CEB345FD074 =GetQueryExpressionDataSource("C27F66A4-6C24-43FF-8C14-9CEB345FD074");
Dictionary<short,object> resultC27F66A46C2443FF8C149CEB345FD074=iSpace.ExecuteQuery(querySourceC27F66A46C2443FF8C149CEB345FD074,@"EXEC [UpsertProjectBudgetDetails] 5,'" + ISpace["MG_P3_ProjectDetailsId"].Value + @"','','" + ISpace["MG_P3_Amount"].Value + @"','" + ISpace["MG_P3_BudgetHeadId"].Value + @"',1,'" + ISpace["MG_P3_FundTypeId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceC27F66A46C2443FF8C149CEB345FD074 =GetQueryExpressionDataSource(""C27F66A4-6C24-43FF-8C14-9CEB345FD074"");Dictionary<short,object> resultC27F66A46C2443FF8C149CEB345FD074=iSpace.ExecuteQuery(querySourceC27F66A46C2443FF8C149CEB345FD074,@""EXEC [UpsertProjectBudgetDetails] 5,'"" + ISpace[""MG_P3_ProjectDetailsId""].Value + @""','','"" + ISpace[""MG_P3_Amount""].Value + @""','"" + ISpace[""MG_P3_BudgetHeadId""].Value + @""',1,'"" + ISpace[""MG_P3_FundTypeId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultC27F66A46C2443FF8C149CEB345FD074!=null) && (resultC27F66A46C2443FF8C149CEB345FD074.Count!=0))
{
if(resultC27F66A46C2443FF8C149CEB345FD074.ContainsKey(0))
ISpace["M_UpdateCount"].Value = resultC27F66A46C2443FF8C149CEB345FD074[0];
}
else{
ISpace["M_UpdateCount"].Value = null;
}
}
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("ReimbursementFundDetails","84AEB9E0-3009-4426-AB92-AAF06D2B42AF",_objectFactory.GetGridRPP("ReimbursementFundDetails"),_elementBase.GetGridLoopQuery("84AEB9E0-3009-4426-AB92-AAF06D2B42AF","ReimbursementFundDetails",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""ReimbursementFundDetails"",ref ISpace);

foreach(var gridChild in ISpace[""ReimbursementFundDetails""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
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
base.WriteDebugInfo(@"EXEC UpsertUserRequestsUpdation '#M_InstanceId','#SetDestinationTo','#M_Stage','#M_Status','@@gv_UserId','#M_RequestId'");

var querySource87cbcf911fba16fd3029f8855a072138 =GetQueryExpressionDataSource("87cbcf91-1fba-16fd-3029-f8855a072138");
Dictionary<short,object> result87cbcf911fba16fd3029f8855a072138=iSpace.ExecuteQuery(querySource87cbcf911fba16fd3029f8855a072138,@"EXEC UpsertUserRequestsUpdation '" + ISpace["M_InstanceId"].Value + @"','" + ISpace["SetDestinationTo"].Value + @"','" + ISpace["M_Stage"].Value + @"','" + ISpace["M_Status"].Value + @"','" + ISpace["gv_userid"].Value + @"','" + ISpace["M_RequestId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource87cbcf911fba16fd3029f8855a072138 =GetQueryExpressionDataSource(""87cbcf91-1fba-16fd-3029-f8855a072138"");Dictionary<short,object> result87cbcf911fba16fd3029f8855a072138=iSpace.ExecuteQuery(querySource87cbcf911fba16fd3029f8855a072138,@""EXEC UpsertUserRequestsUpdation '"" + ISpace[""M_InstanceId""].Value + @""','"" + ISpace[""SetDestinationTo""].Value + @""','"" + ISpace[""M_Stage""].Value + @""','"" + ISpace[""M_Status""].Value + @""','"" + ISpace[""gv_userid""].Value + @""','"" + ISpace[""M_RequestId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result87cbcf911fba16fd3029f8855a072138!=null) && (result87cbcf911fba16fd3029f8855a072138.Count!=0))
{
if(result87cbcf911fba16fd3029f8855a072138.ContainsKey(0))
ISpace["ExecutionMessage"].Value = result87cbcf911fba16fd3029f8855a072138[0];
}
else{
ISpace["ExecutionMessage"].Value = null;
}
ISpace["Message"].Value=@"Submitted Successfully";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Submitted Successfully"";");
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
base.WriteDebugInfo(@"EXEC LoadFormGridDataD85301F7BAF94BE8A2B174E5CBB3D054 '@@gv_InstanceId','@@gv_ProcessMapId','D85301F7-BAF9-4BE8-A2B1-74E5CBB3D054','@@gv_ActivityMapId','#growid'");

var querySource1F49FB0DA84D47A58942368F58A2D97A =GetQueryExpressionDataSource("1F49FB0D-A84D-47A5-8942-368F58A2D97A");
Dictionary<short,object> result1F49FB0DA84D47A58942368F58A2D97A=iSpace.ExecuteQuery(querySource1F49FB0DA84D47A58942368F58A2D97A,@"EXEC LoadFormGridDataD85301F7BAF94BE8A2B174E5CBB3D054 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','D85301F7-BAF9-4BE8-A2B1-74E5CBB3D054','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["growid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource1F49FB0DA84D47A58942368F58A2D97A =GetQueryExpressionDataSource(""1F49FB0D-A84D-47A5-8942-368F58A2D97A"");Dictionary<short,object> result1F49FB0DA84D47A58942368F58A2D97A=iSpace.ExecuteQuery(querySource1F49FB0DA84D47A58942368F58A2D97A,@""EXEC LoadFormGridDataD85301F7BAF94BE8A2B174E5CBB3D054 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','D85301F7-BAF9-4BE8-A2B1-74E5CBB3D054','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""growid""].Value + @""'"",false);");
base.WriteDebugInfo(@"EXEC LoadFormGridDataD85301F7BAF94BE8A2B174E5CBB3D054 '@@gv_InstanceId','@@gv_ProcessMapId','D85301F7-BAF9-4BE8-A2B1-74E5CBB3D054','@@gv_ActivityMapId','#growid'");

if((result1F49FB0DA84D47A58942368F58A2D97A!=null) && (result1F49FB0DA84D47A58942368F58A2D97A.Count!=0))
{
if(result1F49FB0DA84D47A58942368F58A2D97A.ContainsKey(4))
ISpace["MFG_P3_BudgetHeadId"].Value = result1F49FB0DA84D47A58942368F58A2D97A[4];
if(result1F49FB0DA84D47A58942368F58A2D97A.ContainsKey(3))
ISpace["MFG_P3_ProjectDetailsId"].Value = result1F49FB0DA84D47A58942368F58A2D97A[3];
if(result1F49FB0DA84D47A58942368F58A2D97A.ContainsKey(2))
ISpace["MFG_P3_FundTypeId"].Value = result1F49FB0DA84D47A58942368F58A2D97A[2];
if(result1F49FB0DA84D47A58942368F58A2D97A.ContainsKey(5))
ISpace["MFG_P3_Amount"].Value = result1F49FB0DA84D47A58942368F58A2D97A[5];
if(result1F49FB0DA84D47A58942368F58A2D97A.ContainsKey(1))
ISpace["MFG_P3_ReimbursementId"].Value = result1F49FB0DA84D47A58942368F58A2D97A[1];
if(result1F49FB0DA84D47A58942368F58A2D97A.ContainsKey(0))
ISpace["MFG_P3_FundDetailsId"].Value = result1F49FB0DA84D47A58942368F58A2D97A[0];
}
else{
ISpace["MFG_P3_BudgetHeadId"].Value = null;ISpace["MFG_P3_ProjectDetailsId"].Value = null;ISpace["MFG_P3_FundTypeId"].Value = null;ISpace["MFG_P3_Amount"].Value = null;ISpace["MFG_P3_ReimbursementId"].Value = null;ISpace["MFG_P3_FundDetailsId"].Value = null;
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MFG_P3_FundTypeId"].Value=="1")
{
base.WriteDebugInfo(@"if(ISpace[""MFG_P3_FundTypeId""].Value==""1"")");
ISpace["MFG_P3_BudgetHeadId"].Visible="true";ISpace["MFG_P3_BudgetHeadId"].Man=true;ISpace["MFG_P3_ProjectDetailsId"].Visible="true";ISpace["MFG_P3_ProjectDetailsId"].Man=true;ISpace["MFG_P3_Amount"].Visible="true";
base.WriteDebugInfo(@"ISpace[""MFG_P3_BudgetHeadId""].Visible=""true"";ISpace[""MFG_P3_BudgetHeadId""].Man=true;ISpace[""MFG_P3_ProjectDetailsId""].Visible=""true"";ISpace[""MFG_P3_ProjectDetailsId""].Man=true;ISpace[""MFG_P3_Amount""].Visible=""true"";");
if(ISpace["FormVersionId"].Value=="9376EEBF-92B0-4B68-9085-73DD4ED3F42B")
{
ISpace["UI_BudgetColumn"].Visible="true";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""9376EEBF-92B0-4B68-9085-73DD4ED3F42B"")
{
ISpace[""UI_BudgetColumn""].Visible=""true"";
}");
ISpace["MFG_P3_BudgetHeadId"].rElemData=iSpace.Reload(ISpace["MFG_P3_BudgetHeadId"].Value,@"exec SP_GetDistrubitionDetails 5,'" + ISpace["M_PackageProcessMapId"].Value + @"','" + ISpace["MFG_P3_FundTypeId"].Value + @"','','','','','" + ISpace["MFG_P3_ProjectDetailsId"].Value + @"'","9ADED37B-CD11-426B-AF16-DEAC75685EF5");
base.WriteDebugInfo(@"ISpace[""MFG_P3_BudgetHeadId""].rElemData=iSpace.Reload(ISpace[""MFG_P3_BudgetHeadId""].Value,@""exec SP_GetDistrubitionDetails 5,'"" + ISpace[""M_PackageProcessMapId""].Value + @""','"" + ISpace[""MFG_P3_FundTypeId""].Value + @""','','','','','"" + ISpace[""MFG_P3_ProjectDetailsId""].Value + @""'"",""9ADED37B-CD11-426B-AF16-DEAC75685EF5"");");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MFG_P3_BudgetHeadId"].Visible="false";ISpace["MFG_P3_BudgetHeadId"].Man=false;ISpace["MFG_P3_ProjectDetailsId"].Visible="false";ISpace["MFG_P3_ProjectDetailsId"].Man=false;ISpace["MFG_P3_Amount"].Visible="true";
base.WriteDebugInfo(@"ISpace[""MFG_P3_BudgetHeadId""].Visible=""false"";ISpace[""MFG_P3_BudgetHeadId""].Man=false;ISpace[""MFG_P3_ProjectDetailsId""].Visible=""false"";ISpace[""MFG_P3_ProjectDetailsId""].Man=false;ISpace[""MFG_P3_Amount""].Visible=""true"";");
if(ISpace["FormVersionId"].Value=="9376EEBF-92B0-4B68-9085-73DD4ED3F42B")
{
ISpace["UI_BudgetColumn"].Visible="false";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""9376EEBF-92B0-4B68-9085-73DD4ED3F42B"")
{
ISpace[""UI_BudgetColumn""].Visible=""false"";
}");
}
}
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
private void SubscribeElementEvents_mfg_p3_projectdetailsid (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MFG_P3_ProjectDetailsId-OnChange");
ISpace["MFG_P3_BudgetHeadId"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_P3_BudgetHeadId""].Value="""";");
ISpace["MFG_P3_BudgetHeadId"].rElemData=iSpace.Reload(ISpace["MFG_P3_BudgetHeadId"].Value,@"exec SP_GetDistrubitionDetails 5,'" + ISpace["M_PackageProcessMapId"].Value + @"','" + ISpace["MFG_P3_FundTypeId"].Value + @"','','','','','" + ISpace["MFG_P3_ProjectDetailsId"].Value + @"'","9ADED37B-CD11-426B-AF16-DEAC75685EF5");
base.WriteDebugInfo(@"ISpace[""MFG_P3_BudgetHeadId""].rElemData=iSpace.Reload(ISpace[""MFG_P3_BudgetHeadId""].Value,@""exec SP_GetDistrubitionDetails 5,'"" + ISpace[""M_PackageProcessMapId""].Value + @""','"" + ISpace[""MFG_P3_FundTypeId""].Value + @""','','','','','"" + ISpace[""MFG_P3_ProjectDetailsId""].Value + @""'"",""9ADED37B-CD11-426B-AF16-DEAC75685EF5"");");
ISpace["MFG_P3_Amount"].Value=0;
base.WriteDebugInfo(@"ISpace[""MFG_P3_Amount""].Value=0;");
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
ISpace["MFG_P3_BudgetHeadId"].Visible="true";ISpace["MFG_P3_BudgetHeadId"].Man=true;ISpace["MFG_P3_ProjectDetailsId"].Visible="true";ISpace["MFG_P3_ProjectDetailsId"].Man=true;ISpace["MFG_P3_Amount"].Visible="true";
base.WriteDebugInfo(@"ISpace[""MFG_P3_BudgetHeadId""].Visible=""true"";ISpace[""MFG_P3_BudgetHeadId""].Man=true;ISpace[""MFG_P3_ProjectDetailsId""].Visible=""true"";ISpace[""MFG_P3_ProjectDetailsId""].Man=true;ISpace[""MFG_P3_Amount""].Visible=""true"";");
if(ISpace["FormVersionId"].Value=="9376EEBF-92B0-4B68-9085-73DD4ED3F42B")
{
ISpace["UI_BudgetColumn"].Visible="true";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""9376EEBF-92B0-4B68-9085-73DD4ED3F42B"")
{
ISpace[""UI_BudgetColumn""].Visible=""true"";
}");
ISpace["MFG_P3_BudgetHeadId"].rElemData=iSpace.Reload(ISpace["MFG_P3_BudgetHeadId"].Value,@"exec SP_GetDistrubitionDetails 5,'" + ISpace["M_PackageProcessMapId"].Value + @"','" + ISpace["MFG_P3_FundTypeId"].Value + @"','','','','','" + ISpace["MFG_P3_ProjectDetailsId"].Value + @"'","9ADED37B-CD11-426B-AF16-DEAC75685EF5");
base.WriteDebugInfo(@"ISpace[""MFG_P3_BudgetHeadId""].rElemData=iSpace.Reload(ISpace[""MFG_P3_BudgetHeadId""].Value,@""exec SP_GetDistrubitionDetails 5,'"" + ISpace[""M_PackageProcessMapId""].Value + @""','"" + ISpace[""MFG_P3_FundTypeId""].Value + @""','','','','','"" + ISpace[""MFG_P3_ProjectDetailsId""].Value + @""'"",""9ADED37B-CD11-426B-AF16-DEAC75685EF5"");");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MFG_P3_BudgetHeadId"].Visible="false";ISpace["MFG_P3_BudgetHeadId"].Man=false;ISpace["MFG_P3_ProjectDetailsId"].Visible="false";ISpace["MFG_P3_ProjectDetailsId"].Man=false;ISpace["MFG_P3_Amount"].Visible="true";
base.WriteDebugInfo(@"ISpace[""MFG_P3_BudgetHeadId""].Visible=""false"";ISpace[""MFG_P3_BudgetHeadId""].Man=false;ISpace[""MFG_P3_ProjectDetailsId""].Visible=""false"";ISpace[""MFG_P3_ProjectDetailsId""].Man=false;ISpace[""MFG_P3_Amount""].Visible=""true"";");
if(ISpace["FormVersionId"].Value=="9376EEBF-92B0-4B68-9085-73DD4ED3F42B")
{
ISpace["UI_BudgetColumn"].Visible="false";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""9376EEBF-92B0-4B68-9085-73DD4ED3F42B"")
{
ISpace[""UI_BudgetColumn""].Visible=""false"";
}");
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
private void SubscribeElementEvents_mf_projectno (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MF_ProjectNo-OnChange");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySource068CB07446DC429F98877296FCE9263F =GetQueryExpressionDataSource("068CB074-46DC-429F-9887-7296FCE9263F");

DataTable result068CB07446DC429F98877296FCE9263F=iSpace.SetGridDataSource(querySource068CB07446DC429F98877296FCE9263F, _objectFactory.GetGridRPP("MG_CommitmentDetails"),@"EXEC GetProjectBudgetInformation '" + ISpace["MF_ProjectNo"].Value + @"'");

iSpace.InsertGridBindDetails("MG_CommitmentDetails","11",querySource068CB07446DC429F98877296FCE9263F,"EXEC GetProjectBudgetInformation '" + ISpace["MF_ProjectNo"].Value + @"'",_objectFactory.GetGridRPP("MG_CommitmentDetails"));

base.WriteDebugInfo(@"var querySource068CB07446DC429F98877296FCE9263F =GetQueryExpressionDataSource(""068CB074-46DC-429F-9887-7296FCE9263F"");DataTable result068CB07446DC429F98877296FCE9263F=iSpace.SetGridDataSource(querySource068CB07446DC429F98877296FCE9263F, _objectFactory.GetGridRPP(""MG_CommitmentDetails""),@""EXEC GetProjectBudgetInformation '"" + ISpace[""MF_ProjectNo""].Value + @""'"");iSpace.InsertGridBindDetails(""MG_CommitmentDetails"",""11"",querySource068CB07446DC429F98877296FCE9263F,""EXEC GetProjectBudgetInformation '"" + ISpace[""MF_ProjectNo""].Value + @""'"",_objectFactory.GetGridRPP(""MG_CommitmentDetails""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result6A8A8C0472ED4B2E9A10872111E1778C=acdataIspaceDFE5FDDDAC9D4714A58168E139EAC447.GetQueryExpressionBindings("6A8A8C04-72ED-4B2E-9A10-872111E1778C");
iSpace.SetGridData(result068CB07446DC429F98877296FCE9263F,result6A8A8C0472ED4B2E9A10872111E1778C,"MG_CommitmentDetails",ref ISpace);
iSpace.UpdateGridBindDetails("MG_CommitmentDetails",result6A8A8C0472ED4B2E9A10872111E1778C);
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
base.WriteDebugInfo(@"Exec GetStageStatus 1,'','','#M_MoveToValue','#M_SourceActivityMapId'");

var querySource959A027E58AA471DADF1501D54E16A1B =GetQueryExpressionDataSource("959A027E-58AA-471D-ADF1-501D54E16A1B");
Dictionary<short,object> result959A027E58AA471DADF1501D54E16A1B=iSpace.ExecuteQuery(querySource959A027E58AA471DADF1501D54E16A1B,@"Exec GetStageStatus 1,'','','" + ISpace["M_MoveToValue"].Value + @"','" + ISpace["M_SourceActivityMapId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource959A027E58AA471DADF1501D54E16A1B =GetQueryExpressionDataSource(""959A027E-58AA-471D-ADF1-501D54E16A1B"");Dictionary<short,object> result959A027E58AA471DADF1501D54E16A1B=iSpace.ExecuteQuery(querySource959A027E58AA471DADF1501D54E16A1B,@""Exec GetStageStatus 1,'','','"" + ISpace[""M_MoveToValue""].Value + @""','"" + ISpace[""M_SourceActivityMapId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result959A027E58AA471DADF1501D54E16A1B!=null) && (result959A027E58AA471DADF1501D54E16A1B.Count!=0))
{
if(result959A027E58AA471DADF1501D54E16A1B.ContainsKey(1))
ISpace["M_RemarksMandatory"].Value = result959A027E58AA471DADF1501D54E16A1B[1];
if(result959A027E58AA471DADF1501D54E16A1B.ContainsKey(5))
ISpace["M_IsflowReturned"].Value = result959A027E58AA471DADF1501D54E16A1B[5];
if(result959A027E58AA471DADF1501D54E16A1B.ContainsKey(6))
ISpace["M_IsCancelReject"].Value = result959A027E58AA471DADF1501D54E16A1B[6];
if(result959A027E58AA471DADF1501D54E16A1B.ContainsKey(4))
ISpace["M_FieldMandatory"].Value = result959A027E58AA471DADF1501D54E16A1B[4];
if(result959A027E58AA471DADF1501D54E16A1B.ContainsKey(3))
ISpace["M_SaveDomainData"].Value = result959A027E58AA471DADF1501D54E16A1B[3];
if(result959A027E58AA471DADF1501D54E16A1B.ContainsKey(7))
ISpace["M_Stage"].Value = result959A027E58AA471DADF1501D54E16A1B[7];
if(result959A027E58AA471DADF1501D54E16A1B.ContainsKey(0))
ISpace["M_NextStage"].Value = result959A027E58AA471DADF1501D54E16A1B[0];
if(result959A027E58AA471DADF1501D54E16A1B.ContainsKey(2))
ISpace["MF_P1_Remarks"].Value = result959A027E58AA471DADF1501D54E16A1B[2];
}
else{
ISpace["M_RemarksMandatory"].Value = null;ISpace["M_IsflowReturned"].Value = null;ISpace["M_IsCancelReject"].Value = null;ISpace["M_FieldMandatory"].Value = null;ISpace["M_SaveDomainData"].Value = null;ISpace["M_Stage"].Value = null;ISpace["M_NextStage"].Value = null;ISpace["MF_P1_Remarks"].Value = null;
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
		if(elementName.ToLower().Equals("m_classification"))
    {
    			SubscribeElementEvents_m_classification(ref dfsParam);
    }
		if(elementName.ToLower().Equals("m_reimbursementtype"))
    {
    			SubscribeElementEvents_m_reimbursementtype(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mfg_p3_budgetheadid"))
    {
    			SubscribeElementEvents_mfg_p3_budgetheadid(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mfg_p3_projectdetailsid"))
    {
    			SubscribeElementEvents_mfg_p3_projectdetailsid(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mfg_p3_fundtypeid"))
    {
    			SubscribeElementEvents_mfg_p3_fundtypeid(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mf_projectno"))
    {
    			SubscribeElementEvents_mf_projectno(ref dfsParam);
    }
		if(elementName.ToLower().Equals("m_moveto"))
    {
    			SubscribeElementEvents_m_moveto(ref dfsParam);
    }
}
	if(methodName.ToLower().Equals("onclick"))
{
		if(elementName.ToLower().Equals("delete_reimbursementbilldetails"))
{
			SubscribeElementEvents_delete_reimbursementbilldetails(ref dfsParam);
}
		if(elementName.ToLower().Equals("edit_reimbursementbilldetails"))
{
			SubscribeElementEvents_edit_reimbursementbilldetails(ref dfsParam);
}
		if(elementName.ToLower().Equals("save_reimbursementbilldetails"))
{
			SubscribeElementEvents_save_reimbursementbilldetails(ref dfsParam);
}
		if(elementName.ToLower().Equals("delete_reimbursementfunddetails"))
{
			SubscribeElementEvents_delete_reimbursementfunddetails(ref dfsParam);
}
		if(elementName.ToLower().Equals("save_reimbursementfunddetails"))
{
			SubscribeElementEvents_save_reimbursementfunddetails(ref dfsParam);
}
		if(elementName.ToLower().Equals("submitform"))
{
			SubscribeElementEvents_submitform(ref dfsParam);
}
		if(elementName.ToLower().Equals("edit_reimbursementfunddetails"))
{
			SubscribeElementEvents_edit_reimbursementfunddetails(ref dfsParam);
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
}

  







namespace CPS.Proof.DFSExtension
{
	
using System;
    using System.Collections.Generic;    
    using System.Text;	
    using System.Linq;	


	public partial class AcDataISpace788CA62EDF0F4071B3E34239827AFC52  : ExtensionActivityBase
	{		
		
		
		private Dictionary<string,  List<Triplet<string, short, short?>>> queryExpressionBindings = 
											new Dictionary<string,  List<Triplet<string, short, short?>>>
		{
							{"25A00CF7-3B35-4322-B4DF-FE24D90229BC", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_P3_ProjectDetailsId",3,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_ReimbursementId",1,
														   -1),
								   new Triplet<string, short, short?>("ReimbursementFundDetails_RowId",6,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_Amount",5,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_FundTypeId",2,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_BudgetHeadId",4,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_FundDetailsId",0,
														   -1),
								}
			},
							{"B2246D72-F13D-45E7-B72C-EFE79CE1C2E4", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_P2_BillDate",3,
														   -1),
								   new Triplet<string, short, short?>("ReimbursementBillDetails_RowId",7,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_ReimbursementDetailsId",0,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_BillNo",2,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_BillDocument",4,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_ItemDescription",5,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_Amount",6,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_ReimbursementId",1,
														   -1),
								}
			},
							{"EFFC55B6-8556-4D91-AE91-384F68B422FF", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_P3_ProjectDetailsId",3,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_FundDetailsId",0,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_ReimbursementId",1,
														   -1),
								   new Triplet<string, short, short?>("ReimbursementFundDetails_RowId",6,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_BudgetHeadId",4,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_Amount",5,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_FundTypeId",2,
														   -1),
								}
			},
							{"C48E5BD1-7B2A-4917-979A-69F487396125", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_P2_ItemDescription",5,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_BillNo",2,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_ReimbursementId",1,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_ReimbursementDetailsId",0,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_BillDate",3,
														   -1),
								   new Triplet<string, short, short?>("ReimbursementBillDetails_RowId",7,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_Amount",6,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_BillDocument",4,
														   -1),
								}
			},
							{"6A8A8C04-72ED-4B2E-9A10-872111E1778C", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_Balance",6,
														   -1),
								   new Triplet<string, short, short?>("MG_Commitment",4,
														   -1),
								   new Triplet<string, short, short?>("MG_Spent",5,
														   -1),
								   new Triplet<string, short, short?>("MG_BudgetName",0,
														   -1),
								   new Triplet<string, short, short?>("MG_YetToReceive",2,
														   -1),
								   new Triplet<string, short, short?>("MG_SanctionedAmount",1,
														   -1),
								   new Triplet<string, short, short?>("MG_ReceivedAmount",3,
														   -1),
								}
			},
							{"9EA07CAC-F227-4E83-A5EE-8C316E74D75C", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_P2_BillDocument",4,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_ItemDescription",5,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_BillDate",3,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_ReimbursementId",1,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_BillNo",2,
														   -1),
								   new Triplet<string, short, short?>("ReimbursementBillDetails_RowId",7,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_Amount",6,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_ReimbursementDetailsId",0,
														   -1),
								}
			},
							{"E57D76A3-2437-4EAF-8C53-0F41C6AF052C", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("DateOfRemarks",3,
														   -1),
								   new Triplet<string, short, short?>("ActivityName",1,
														   -1),
								   new Triplet<string, short, short?>("Remarks",4,
														   -1),
								   new Triplet<string, short, short?>("UserName",2,
														   -1),
								   new Triplet<string, short, short?>("RemarksId",0,
														   -1),
								}
			},
					};	

	

		private Dictionary<string,string> formVersionList =new Dictionary<string,string> 
		{
							{"9376EEBF-92B0-4B68-9085-73DD4ED3F42B", "Medium"},
					};	

		
		private Dictionary<string,string> formVersionLayoutList =new Dictionary<string,string> 
		{
							{"5253EB83-3801-4CFD-96C7-6348CAAB6D1A", ""},
							{"702FAD5A-79DD-40C8-AA3F-035B8B0CF80F", ""},
							{"9376EEBF-92B0-4B68-9085-73DD4ED3F42B", ""},
							{"E7DA6C1D-CF1E-4097-87DB-393972C65DA8", ""},
							{"56FA292D-5881-4E1D-9CB4-63EFD29E1617", ""},
							{"6D16BAC2-EC07-4B88-8012-AAA12ECB2678", ""},
							{"E41CB087-4850-44F9-BD93-00BCD4248C31", ""},
							{"77A5140F-12F8-47DA-86B2-A75FC0DC8315", ""},
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


	public partial class AcDataISpace01ABEB23E635437DA24F27342FB92C55  : ExtensionActivityBase
	{		
		
		
		private Dictionary<string,  List<Triplet<string, short, short?>>> queryExpressionBindings = 
											new Dictionary<string,  List<Triplet<string, short, short?>>>
		{
							{"25A00CF7-3B35-4322-B4DF-FE24D90229BC", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_P3_ProjectDetailsId",3,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_ReimbursementId",1,
														   -1),
								   new Triplet<string, short, short?>("ReimbursementFundDetails_RowId",6,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_Amount",5,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_FundTypeId",2,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_BudgetHeadId",4,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_FundDetailsId",0,
														   -1),
								}
			},
							{"EFFC55B6-8556-4D91-AE91-384F68B422FF", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_P3_ProjectDetailsId",3,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_FundDetailsId",0,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_ReimbursementId",1,
														   -1),
								   new Triplet<string, short, short?>("ReimbursementFundDetails_RowId",6,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_BudgetHeadId",4,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_Amount",5,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_FundTypeId",2,
														   -1),
								}
			},
							{"C48E5BD1-7B2A-4917-979A-69F487396125", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_P2_ItemDescription",5,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_BillNo",2,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_ReimbursementId",1,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_ReimbursementDetailsId",0,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_BillDate",3,
														   -1),
								   new Triplet<string, short, short?>("ReimbursementBillDetails_RowId",7,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_Amount",6,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_BillDocument",4,
														   -1),
								}
			},
							{"9EA07CAC-F227-4E83-A5EE-8C316E74D75C", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_P2_BillDocument",4,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_ItemDescription",5,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_BillDate",3,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_ReimbursementId",1,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_BillNo",2,
														   -1),
								   new Triplet<string, short, short?>("ReimbursementBillDetails_RowId",7,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_Amount",6,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_ReimbursementDetailsId",0,
														   -1),
								}
			},
							{"E57D76A3-2437-4EAF-8C53-0F41C6AF052C", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("DateOfRemarks",3,
														   -1),
								   new Triplet<string, short, short?>("ActivityName",1,
														   -1),
								   new Triplet<string, short, short?>("Remarks",4,
														   -1),
								   new Triplet<string, short, short?>("UserName",2,
														   -1),
								   new Triplet<string, short, short?>("RemarksId",0,
														   -1),
								}
			},
					};	

	

		private Dictionary<string,string> formVersionList =new Dictionary<string,string> 
		{
							{"9376EEBF-92B0-4B68-9085-73DD4ED3F42B", "Medium"},
					};	

		
		private Dictionary<string,string> formVersionLayoutList =new Dictionary<string,string> 
		{
							{"5253EB83-3801-4CFD-96C7-6348CAAB6D1A", ""},
							{"702FAD5A-79DD-40C8-AA3F-035B8B0CF80F", ""},
							{"9376EEBF-92B0-4B68-9085-73DD4ED3F42B", ""},
							{"E7DA6C1D-CF1E-4097-87DB-393972C65DA8", ""},
							{"56FA292D-5881-4E1D-9CB4-63EFD29E1617", ""},
							{"6D16BAC2-EC07-4B88-8012-AAA12ECB2678", ""},
							{"E41CB087-4850-44F9-BD93-00BCD4248C31", ""},
							{"77A5140F-12F8-47DA-86B2-A75FC0DC8315", ""},
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


	public partial class AcDataISpace89D38028FA534F9E89EA42C506E8E381  : ExtensionActivityBase
	{		
		
		
		private Dictionary<string,  List<Triplet<string, short, short?>>> queryExpressionBindings = 
											new Dictionary<string,  List<Triplet<string, short, short?>>>
		{
							{"25A00CF7-3B35-4322-B4DF-FE24D90229BC", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_P3_ProjectDetailsId",3,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_ReimbursementId",1,
														   -1),
								   new Triplet<string, short, short?>("ReimbursementFundDetails_RowId",6,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_Amount",5,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_FundTypeId",2,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_BudgetHeadId",4,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_FundDetailsId",0,
														   -1),
								}
			},
							{"EFFC55B6-8556-4D91-AE91-384F68B422FF", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_P3_ProjectDetailsId",3,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_FundDetailsId",0,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_ReimbursementId",1,
														   -1),
								   new Triplet<string, short, short?>("ReimbursementFundDetails_RowId",6,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_BudgetHeadId",4,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_Amount",5,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_FundTypeId",2,
														   -1),
								}
			},
							{"C48E5BD1-7B2A-4917-979A-69F487396125", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_P2_ItemDescription",5,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_BillNo",2,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_ReimbursementId",1,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_ReimbursementDetailsId",0,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_BillDate",3,
														   -1),
								   new Triplet<string, short, short?>("ReimbursementBillDetails_RowId",7,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_Amount",6,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_BillDocument",4,
														   -1),
								}
			},
							{"9EA07CAC-F227-4E83-A5EE-8C316E74D75C", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_P2_BillDocument",4,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_ItemDescription",5,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_BillDate",3,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_ReimbursementId",1,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_BillNo",2,
														   -1),
								   new Triplet<string, short, short?>("ReimbursementBillDetails_RowId",7,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_Amount",6,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_ReimbursementDetailsId",0,
														   -1),
								}
			},
							{"E57D76A3-2437-4EAF-8C53-0F41C6AF052C", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("DateOfRemarks",3,
														   -1),
								   new Triplet<string, short, short?>("ActivityName",1,
														   -1),
								   new Triplet<string, short, short?>("Remarks",4,
														   -1),
								   new Triplet<string, short, short?>("UserName",2,
														   -1),
								   new Triplet<string, short, short?>("RemarksId",0,
														   -1),
								}
			},
					};	

	

		private Dictionary<string,string> formVersionList =new Dictionary<string,string> 
		{
							{"9376EEBF-92B0-4B68-9085-73DD4ED3F42B", "Medium"},
					};	

		
		private Dictionary<string,string> formVersionLayoutList =new Dictionary<string,string> 
		{
							{"5253EB83-3801-4CFD-96C7-6348CAAB6D1A", ""},
							{"702FAD5A-79DD-40C8-AA3F-035B8B0CF80F", ""},
							{"9376EEBF-92B0-4B68-9085-73DD4ED3F42B", ""},
							{"E7DA6C1D-CF1E-4097-87DB-393972C65DA8", ""},
							{"56FA292D-5881-4E1D-9CB4-63EFD29E1617", ""},
							{"6D16BAC2-EC07-4B88-8012-AAA12ECB2678", ""},
							{"E41CB087-4850-44F9-BD93-00BCD4248C31", ""},
							{"77A5140F-12F8-47DA-86B2-A75FC0DC8315", ""},
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


	public partial class AcDataISpaceC4E2EC4C58BD44FB91D13D8E475D6C14  : ExtensionActivityBase
	{		
		
		
		private Dictionary<string,  List<Triplet<string, short, short?>>> queryExpressionBindings = 
											new Dictionary<string,  List<Triplet<string, short, short?>>>
		{
							{"25A00CF7-3B35-4322-B4DF-FE24D90229BC", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_P3_ProjectDetailsId",3,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_ReimbursementId",1,
														   -1),
								   new Triplet<string, short, short?>("ReimbursementFundDetails_RowId",6,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_Amount",5,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_FundTypeId",2,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_BudgetHeadId",4,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_FundDetailsId",0,
														   -1),
								}
			},
							{"EFFC55B6-8556-4D91-AE91-384F68B422FF", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_P3_ProjectDetailsId",3,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_FundDetailsId",0,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_ReimbursementId",1,
														   -1),
								   new Triplet<string, short, short?>("ReimbursementFundDetails_RowId",6,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_BudgetHeadId",4,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_Amount",5,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_FundTypeId",2,
														   -1),
								}
			},
							{"C48E5BD1-7B2A-4917-979A-69F487396125", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_P2_ItemDescription",5,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_BillNo",2,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_ReimbursementId",1,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_ReimbursementDetailsId",0,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_BillDate",3,
														   -1),
								   new Triplet<string, short, short?>("ReimbursementBillDetails_RowId",7,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_Amount",6,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_BillDocument",4,
														   -1),
								}
			},
							{"9EA07CAC-F227-4E83-A5EE-8C316E74D75C", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_P2_BillDocument",4,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_ItemDescription",5,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_BillDate",3,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_ReimbursementId",1,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_BillNo",2,
														   -1),
								   new Triplet<string, short, short?>("ReimbursementBillDetails_RowId",7,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_Amount",6,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_ReimbursementDetailsId",0,
														   -1),
								}
			},
							{"E57D76A3-2437-4EAF-8C53-0F41C6AF052C", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("DateOfRemarks",3,
														   -1),
								   new Triplet<string, short, short?>("ActivityName",1,
														   -1),
								   new Triplet<string, short, short?>("Remarks",4,
														   -1),
								   new Triplet<string, short, short?>("UserName",2,
														   -1),
								   new Triplet<string, short, short?>("RemarksId",0,
														   -1),
								}
			},
					};	

	

		private Dictionary<string,string> formVersionList =new Dictionary<string,string> 
		{
							{"9376EEBF-92B0-4B68-9085-73DD4ED3F42B", "Medium"},
					};	

		
		private Dictionary<string,string> formVersionLayoutList =new Dictionary<string,string> 
		{
							{"5253EB83-3801-4CFD-96C7-6348CAAB6D1A", ""},
							{"702FAD5A-79DD-40C8-AA3F-035B8B0CF80F", ""},
							{"9376EEBF-92B0-4B68-9085-73DD4ED3F42B", ""},
							{"E7DA6C1D-CF1E-4097-87DB-393972C65DA8", ""},
							{"56FA292D-5881-4E1D-9CB4-63EFD29E1617", ""},
							{"6D16BAC2-EC07-4B88-8012-AAA12ECB2678", ""},
							{"E41CB087-4850-44F9-BD93-00BCD4248C31", ""},
							{"77A5140F-12F8-47DA-86B2-A75FC0DC8315", ""},
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


	public partial class AcDataISpace7B9E10F1A9E84A0C90D9F183CC3B49D0  : ExtensionActivityBase
	{		
		
		
		private Dictionary<string,  List<Triplet<string, short, short?>>> queryExpressionBindings = 
											new Dictionary<string,  List<Triplet<string, short, short?>>>
		{
							{"25A00CF7-3B35-4322-B4DF-FE24D90229BC", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_P3_ProjectDetailsId",3,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_ReimbursementId",1,
														   -1),
								   new Triplet<string, short, short?>("ReimbursementFundDetails_RowId",6,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_Amount",5,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_FundTypeId",2,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_BudgetHeadId",4,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_FundDetailsId",0,
														   -1),
								}
			},
							{"EFFC55B6-8556-4D91-AE91-384F68B422FF", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_P3_ProjectDetailsId",3,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_FundDetailsId",0,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_ReimbursementId",1,
														   -1),
								   new Triplet<string, short, short?>("ReimbursementFundDetails_RowId",6,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_BudgetHeadId",4,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_Amount",5,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_FundTypeId",2,
														   -1),
								}
			},
							{"C48E5BD1-7B2A-4917-979A-69F487396125", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_P2_ItemDescription",5,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_BillNo",2,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_ReimbursementId",1,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_ReimbursementDetailsId",0,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_BillDate",3,
														   -1),
								   new Triplet<string, short, short?>("ReimbursementBillDetails_RowId",7,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_Amount",6,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_BillDocument",4,
														   -1),
								}
			},
							{"9EA07CAC-F227-4E83-A5EE-8C316E74D75C", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_P2_BillDocument",4,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_ItemDescription",5,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_BillDate",3,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_ReimbursementId",1,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_BillNo",2,
														   -1),
								   new Triplet<string, short, short?>("ReimbursementBillDetails_RowId",7,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_Amount",6,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_ReimbursementDetailsId",0,
														   -1),
								}
			},
							{"E57D76A3-2437-4EAF-8C53-0F41C6AF052C", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("DateOfRemarks",3,
														   -1),
								   new Triplet<string, short, short?>("ActivityName",1,
														   -1),
								   new Triplet<string, short, short?>("Remarks",4,
														   -1),
								   new Triplet<string, short, short?>("UserName",2,
														   -1),
								   new Triplet<string, short, short?>("RemarksId",0,
														   -1),
								}
			},
					};	

	

		private Dictionary<string,string> formVersionList =new Dictionary<string,string> 
		{
							{"9376EEBF-92B0-4B68-9085-73DD4ED3F42B", "Medium"},
					};	

		
		private Dictionary<string,string> formVersionLayoutList =new Dictionary<string,string> 
		{
							{"5253EB83-3801-4CFD-96C7-6348CAAB6D1A", ""},
							{"702FAD5A-79DD-40C8-AA3F-035B8B0CF80F", ""},
							{"9376EEBF-92B0-4B68-9085-73DD4ED3F42B", ""},
							{"E7DA6C1D-CF1E-4097-87DB-393972C65DA8", ""},
							{"56FA292D-5881-4E1D-9CB4-63EFD29E1617", ""},
							{"6D16BAC2-EC07-4B88-8012-AAA12ECB2678", ""},
							{"E41CB087-4850-44F9-BD93-00BCD4248C31", ""},
							{"77A5140F-12F8-47DA-86B2-A75FC0DC8315", ""},
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


	public partial class AcDataISpaceDFE5FDDDAC9D4714A58168E139EAC447  : ExtensionActivityBase
	{		
		
		
		private Dictionary<string,  List<Triplet<string, short, short?>>> queryExpressionBindings = 
											new Dictionary<string,  List<Triplet<string, short, short?>>>
		{
							{"25A00CF7-3B35-4322-B4DF-FE24D90229BC", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_P3_ProjectDetailsId",3,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_ReimbursementId",1,
														   -1),
								   new Triplet<string, short, short?>("ReimbursementFundDetails_RowId",6,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_Amount",5,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_FundTypeId",2,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_BudgetHeadId",4,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_FundDetailsId",0,
														   -1),
								}
			},
							{"EFFC55B6-8556-4D91-AE91-384F68B422FF", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_P3_ProjectDetailsId",3,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_FundDetailsId",0,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_ReimbursementId",1,
														   -1),
								   new Triplet<string, short, short?>("ReimbursementFundDetails_RowId",6,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_BudgetHeadId",4,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_Amount",5,
														   -1),
								   new Triplet<string, short, short?>("MG_P3_FundTypeId",2,
														   -1),
								}
			},
							{"C48E5BD1-7B2A-4917-979A-69F487396125", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_P2_ItemDescription",5,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_BillNo",2,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_ReimbursementId",1,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_ReimbursementDetailsId",0,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_BillDate",3,
														   -1),
								   new Triplet<string, short, short?>("ReimbursementBillDetails_RowId",7,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_Amount",6,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_BillDocument",4,
														   -1),
								}
			},
							{"6A8A8C04-72ED-4B2E-9A10-872111E1778C", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_Balance",6,
														   -1),
								   new Triplet<string, short, short?>("MG_Commitment",4,
														   -1),
								   new Triplet<string, short, short?>("MG_Spent",5,
														   -1),
								   new Triplet<string, short, short?>("MG_BudgetName",0,
														   -1),
								   new Triplet<string, short, short?>("MG_YetToReceive",2,
														   -1),
								   new Triplet<string, short, short?>("MG_SanctionedAmount",1,
														   -1),
								   new Triplet<string, short, short?>("MG_ReceivedAmount",3,
														   -1),
								}
			},
							{"9EA07CAC-F227-4E83-A5EE-8C316E74D75C", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_P2_BillDocument",4,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_ItemDescription",5,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_BillDate",3,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_ReimbursementId",1,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_BillNo",2,
														   -1),
								   new Triplet<string, short, short?>("ReimbursementBillDetails_RowId",7,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_Amount",6,
														   -1),
								   new Triplet<string, short, short?>("MG_P2_ReimbursementDetailsId",0,
														   -1),
								}
			},
							{"E57D76A3-2437-4EAF-8C53-0F41C6AF052C", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("DateOfRemarks",3,
														   -1),
								   new Triplet<string, short, short?>("ActivityName",1,
														   -1),
								   new Triplet<string, short, short?>("Remarks",4,
														   -1),
								   new Triplet<string, short, short?>("UserName",2,
														   -1),
								   new Triplet<string, short, short?>("RemarksId",0,
														   -1),
								}
			},
					};	

	

		private Dictionary<string,string> formVersionList =new Dictionary<string,string> 
		{
							{"9376EEBF-92B0-4B68-9085-73DD4ED3F42B", "Medium"},
					};	

		
		private Dictionary<string,string> formVersionLayoutList =new Dictionary<string,string> 
		{
							{"5253EB83-3801-4CFD-96C7-6348CAAB6D1A", ""},
							{"702FAD5A-79DD-40C8-AA3F-035B8B0CF80F", ""},
							{"9376EEBF-92B0-4B68-9085-73DD4ED3F42B", ""},
							{"E7DA6C1D-CF1E-4097-87DB-393972C65DA8", ""},
							{"56FA292D-5881-4E1D-9CB4-63EFD29E1617", ""},
							{"6D16BAC2-EC07-4B88-8012-AAA12ECB2678", ""},
							{"E41CB087-4850-44F9-BD93-00BCD4248C31", ""},
							{"77A5140F-12F8-47DA-86B2-A75FC0DC8315", ""},
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


	public partial class AcDataISpace8FD0D67950BA4D679BDF2A794BE4B8D7  : ExtensionActivityBase
	{		
		
		
		private Dictionary<string,  List<Triplet<string, short, short?>>> queryExpressionBindings = 
											new Dictionary<string,  List<Triplet<string, short, short?>>>
		{
							{"E57D76A3-2437-4EAF-8C53-0F41C6AF052C", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("DateOfRemarks",3,
														   -1),
								   new Triplet<string, short, short?>("ActivityName",1,
														   -1),
								   new Triplet<string, short, short?>("Remarks",4,
														   -1),
								   new Triplet<string, short, short?>("UserName",2,
														   -1),
								   new Triplet<string, short, short?>("RemarksId",0,
														   -1),
								}
			},
					};	

	

		private Dictionary<string,string> formVersionList =new Dictionary<string,string> 
		{
							{"5253EB83-3801-4CFD-96C7-6348CAAB6D1A", "Mobile-Hybrid"},
							{"702FAD5A-79DD-40C8-AA3F-035B8B0CF80F", "Tab"},
							{"9376EEBF-92B0-4B68-9085-73DD4ED3F42B", "Medium"},
							{"E7DA6C1D-CF1E-4097-87DB-393972C65DA8", "Large"},
							{"56FA292D-5881-4E1D-9CB4-63EFD29E1617", "AR"},
							{"6D16BAC2-EC07-4B88-8012-AAA12ECB2678", "MR"},
							{"E41CB087-4850-44F9-BD93-00BCD4248C31", "HHT"},
							{"77A5140F-12F8-47DA-86B2-A75FC0DC8315", "Mobile-Native"},
					};	

		
		private Dictionary<string,string> formVersionLayoutList =new Dictionary<string,string> 
		{
							{"5253EB83-3801-4CFD-96C7-6348CAAB6D1A", ""},
							{"702FAD5A-79DD-40C8-AA3F-035B8B0CF80F", ""},
							{"9376EEBF-92B0-4B68-9085-73DD4ED3F42B", ""},
							{"E7DA6C1D-CF1E-4097-87DB-393972C65DA8", ""},
							{"56FA292D-5881-4E1D-9CB4-63EFD29E1617", ""},
							{"6D16BAC2-EC07-4B88-8012-AAA12ECB2678", ""},
							{"E41CB087-4850-44F9-BD93-00BCD4248C31", ""},
							{"77A5140F-12F8-47DA-86B2-A75FC0DC8315", ""},
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


	public partial class AcDataISpace8736E2716C244B7DB118FADA43118D73  : ExtensionActivityBase
	{		
		
		
		private Dictionary<string,  List<Triplet<string, short, short?>>> queryExpressionBindings = 
											new Dictionary<string,  List<Triplet<string, short, short?>>>
		{
							{"E57D76A3-2437-4EAF-8C53-0F41C6AF052C", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("DateOfRemarks",3,
														   -1),
								   new Triplet<string, short, short?>("ActivityName",1,
														   -1),
								   new Triplet<string, short, short?>("Remarks",4,
														   -1),
								   new Triplet<string, short, short?>("UserName",2,
														   -1),
								   new Triplet<string, short, short?>("RemarksId",0,
														   -1),
								}
			},
					};	

	

		private Dictionary<string,string> formVersionList =new Dictionary<string,string> 
		{
							{"5253EB83-3801-4CFD-96C7-6348CAAB6D1A", "Mobile-Hybrid"},
							{"702FAD5A-79DD-40C8-AA3F-035B8B0CF80F", "Tab"},
							{"9376EEBF-92B0-4B68-9085-73DD4ED3F42B", "Medium"},
							{"E7DA6C1D-CF1E-4097-87DB-393972C65DA8", "Large"},
							{"56FA292D-5881-4E1D-9CB4-63EFD29E1617", "AR"},
							{"6D16BAC2-EC07-4B88-8012-AAA12ECB2678", "MR"},
							{"E41CB087-4850-44F9-BD93-00BCD4248C31", "HHT"},
							{"77A5140F-12F8-47DA-86B2-A75FC0DC8315", "Mobile-Native"},
					};	

		
		private Dictionary<string,string> formVersionLayoutList =new Dictionary<string,string> 
		{
							{"5253EB83-3801-4CFD-96C7-6348CAAB6D1A", ""},
							{"702FAD5A-79DD-40C8-AA3F-035B8B0CF80F", ""},
							{"9376EEBF-92B0-4B68-9085-73DD4ED3F42B", ""},
							{"E7DA6C1D-CF1E-4097-87DB-393972C65DA8", ""},
							{"56FA292D-5881-4E1D-9CB4-63EFD29E1617", ""},
							{"6D16BAC2-EC07-4B88-8012-AAA12ECB2678", ""},
							{"E41CB087-4850-44F9-BD93-00BCD4248C31", ""},
							{"77A5140F-12F8-47DA-86B2-A75FC0DC8315", ""},
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


	public partial class AcDataISpace01E9234C0DC24C3486FD046F4A039091  : ExtensionActivityBase
	{		
		
		
		private Dictionary<string,  List<Triplet<string, short, short?>>> queryExpressionBindings = 
											new Dictionary<string,  List<Triplet<string, short, short?>>>
		{
							{"E57D76A3-2437-4EAF-8C53-0F41C6AF052C", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("DateOfRemarks",3,
														   -1),
								   new Triplet<string, short, short?>("ActivityName",1,
														   -1),
								   new Triplet<string, short, short?>("Remarks",4,
														   -1),
								   new Triplet<string, short, short?>("UserName",2,
														   -1),
								   new Triplet<string, short, short?>("RemarksId",0,
														   -1),
								}
			},
					};	

	

		private Dictionary<string,string> formVersionList =new Dictionary<string,string> 
		{
							{"9376EEBF-92B0-4B68-9085-73DD4ED3F42B", "Medium"},
					};	

		
		private Dictionary<string,string> formVersionLayoutList =new Dictionary<string,string> 
		{
							{"5253EB83-3801-4CFD-96C7-6348CAAB6D1A", ""},
							{"702FAD5A-79DD-40C8-AA3F-035B8B0CF80F", ""},
							{"9376EEBF-92B0-4B68-9085-73DD4ED3F42B", ""},
							{"E7DA6C1D-CF1E-4097-87DB-393972C65DA8", ""},
							{"56FA292D-5881-4E1D-9CB4-63EFD29E1617", ""},
							{"6D16BAC2-EC07-4B88-8012-AAA12ECB2678", ""},
							{"E41CB087-4850-44F9-BD93-00BCD4248C31", ""},
							{"77A5140F-12F8-47DA-86B2-A75FC0DC8315", ""},
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
		


