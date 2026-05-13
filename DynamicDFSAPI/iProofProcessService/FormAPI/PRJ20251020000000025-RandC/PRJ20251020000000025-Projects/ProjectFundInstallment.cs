  







namespace CPS.Proof.DFSExtension
{
	using System;
    using System.Collections.Generic;     
	using System.Linq;
	
	
	public partial class ProjectFundInstallmentProcessMetadata : ExtensionProcessBase
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
            get { return "64C42232-67DB-43B8-8B68-4468FE0DD17F"; }
        }

        public override string ProcessName
        {
            get { return "ProjectFundInstallment"; }
        }

		public override string ProcessDescription
        {
            get { return "Project Fund Installment"; }
        }

        public override ProcessType ProcessType
        {
            get { return ProcessType.RuleBased; }
        }

      

		public override string FileGroupId
        {
            get { return "9BA46702-C911-4CC1-9D1E-902823B1CEFE"; }
        } 

		public override string FileGroup
        {
            get { return "Default"; }
        } 
		
        public override string PackageProcessMapId
        {
            get {return "64C42232-67DB-43B8-8B68-4468FE0DD17F";}
        }

		public override byte ProcessInstanceMode
        {
            get {return 3;}
        }		

		public override string MasterFormId
        {
            get {  
				   return "8A7A4CC4-0187-401F-BAF6-2AC1394A9245";	}
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
	

	public partial class ProjectFundInstallmentObjectFactory  : ExtObjectFactoryBase
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
        //    return (IExtBaseMetaData)new ProjectFundInstallmentProcessMetadata();
        //}
	


		private List<Triplet<string, string, string>> queryExpressionData = new List<Triplet<string, string, string>>
		{
	  			
			     new Triplet<string, string, string>("566D32B3-6586-4115-B5DB-148796882A52","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"9ADED37B-CD11-426B-AF16-DEAC75685EF5"),
			
						
			     new Triplet<string, string, string>("7DA1AAC4-1079-4683-ACB6-836196476D5A","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"9ADED37B-CD11-426B-AF16-DEAC75685EF5"),
			
						
			     new Triplet<string, string, string>("A5DC1822-50F5-461F-AA7F-4043FAB5724D","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"2F28A839-0875-4C17-8ADF-2FC7F8F8847C"),
			
						
			     new Triplet<string, string, string>("B8A2A58C-91CA-4FD4-B326-9652593DD27B","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"9ADED37B-CD11-426B-AF16-DEAC75685EF5"),
			
						
			     new Triplet<string, string, string>("b25829de-0dac-f553-841b-af18f5d427f5","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("8ededcfe-5ada-cbe6-9029-76086059adc4","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("DE3FD546-5790-40D2-8E8A-EB9179B047C4","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("0B4B727A-F2FC-49FD-ADAE-2CCF203DB052","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("f9725457-6a47-71b9-0f3c-9b5f75e48ca1","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("dbd67128-b3fd-6fe2-32e3-a8d6e1f86bde","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("F8133204-4D25-45DD-90C1-B4DD31CFF7F4","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("3A06B075-E487-4835-B114-FD3DF7DAC69D","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"028B1EFF-34A8-4D44-BF39-06CE99DF7C67"),
			
						
			     new Triplet<string, string, string>("490A453A-6852-4615-B83B-173BC38F190B","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"2F28A839-0875-4C17-8ADF-2FC7F8F8847C"),
			
						
			     new Triplet<string, string, string>("C102915B-AF51-44F9-A85E-2C1A53654BCF","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"2F28A839-0875-4C17-8ADF-2FC7F8F8847C"),
			
						
			     new Triplet<string, string, string>("658407BF-CBFF-443B-AA60-4C126BC8B3CE","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"2F28A839-0875-4C17-8ADF-2FC7F8F8847C"),
			
						
			     new Triplet<string, string, string>("3B027C62-1634-4105-BF4D-15B3AA014207","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("82426A40-A870-4190-9F2B-6350B84FC4D6","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("53963539-D3EB-42AC-923B-633B75334F3E","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("84E66A1A-D77D-4A8F-9C71-C6E469B653E2","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"9AE80211-3943-4A9E-9DD9-C091F77BF194"),
			
						
			     new Triplet<string, string, string>("EE2E79C5-4A8F-4AC1-A64E-6FCFA533D02D","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("940556A6-58CF-4959-8DD3-0E1D927449F2","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("526137CD-61B5-430F-B81F-F00B94BC6A8E","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("B8A2A58C-91CA-4FD4-B326-9652593DD27B","Load Remarks Details",
												     @"8B4BCD21-9BD3-4278-AA2C-99F30B18BC32"),
			
						
			     new Triplet<string, string, string>("EE2E79C5-4A8F-4AC1-A64E-6FCFA533D02D","Available Balance",
												     @"9A0E4095-1BE8-44D4-97FB-822ADA862E58"),
			
						
			     new Triplet<string, string, string>("658407BF-CBFF-443B-AA60-4C126BC8B3CE","Delete Grid rows",
												     @"249EF445-9B49-4EF9-8045-46BD1E6FF8ED"),
			
						
			     new Triplet<string, string, string>("490A453A-6852-4615-B83B-173BC38F190B","Grid BindingF",
												     @"249EF445-9B49-4EF9-8045-46BD1E6FF8ED"),
			
						
			     new Triplet<string, string, string>("C102915B-AF51-44F9-A85E-2C1A53654BCF","Grid Binding6",
												     @"249EF445-9B49-4EF9-8045-46BD1E6FF8ED"),
			
			
			
		};

		
		private List<Triplet<string, string, string>> ComboDataSource = new List<Triplet<string, string, string>>
		{

		
	  			
			     new Triplet<string, string, string>("MF_P1_TransferReferenceBankId","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw1z/z9sf1712IST2TisZRbDL01cRO080NYHWsKvkYJS77XPhhEPANfatU8lJP0mJJjSopgrwrPOlAa7ekRdWJpCoSneyUlDBd6d1RrcOybG3s",
												     @"EXEC GetReceiptsTransferType"),
			
						
			     new Triplet<string, string, string>("MG_R2_BudgetId","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw1z/z9sf1712IST2TisZRbDL01cRO080NYHWsKvkYJS77XPhhEPANfatU8lJP0mJJjSopgrwrPOlAa7ekRdWJpCoSneyUlDBd6d1RrcOybG3s",
												     @"EXEC GetBudgetDetails"),
			
						
			     new Triplet<string, string, string>("MF_P1_TransferType","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw1z/z9sf1712IST2TisZRbDL01cRO080NYHWsKvkYJS77XPhhEPANfatU8lJP0mJJjSopgrwrPOlAa7ekRdWJpCoSneyUlDBd6d1RrcOybG3s",
												     @"EXEC GetReceiptsTransferType"),
			
						
			     new Triplet<string, string, string>("C_FC_ProjectNo_15","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw1z/z9sf1712IST2TisZRbDL01cRO080NYHWsKvkYJS77XPhhEPANfatU8lJP0mJJjSopgrwrPOlAa7ekRdWJpCoSneyUlDBd6d1RrcOybG3s",
												     @"EXEC GetProjectExtensionDetails 1,'@UC_EmployeeBaicInfoId'"),
			
						
			     new Triplet<string, string, string>("M_MoveTo","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw1z/z9sf1712IST2TisZRbDL01cRO080NYHWsKvkYJS77cc4eTVUER6yxhHgktDkfvWfwBNgoOezuhR3VTahYodgYs1XIsswI0A==",
												     @"EXEC GetMovetoValuesProjectFundInstallment 1,'@C_FC_Category_15','@M_ActivityName'"),
			
						
			     new Triplet<string, string, string>("MFG_R2_BudgetId","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw1z/z9sf1712IST2TisZRbDL01cRO080NYHWsKvkYJS77XPhhEPANfatU8lJP0mJJjSopgrwrPOlAa7ekRdWJpCoSneyUlDBd6d1RrcOybG3s",
												     @"EXEC SP_GetBudgetDetails  '@C_FC_ProjectNo_15'"),
			
						
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
		
	  			
			     new Tuple<string, int>("AvailableBudgetHeadAmount",50),
			
						
			     new Tuple<string, int>("ReceiptSplitUp",5),
			
						
			     new Tuple<string, int>("MG_DcoumentDetails",5),
			
						
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
											case "DDBF5292-6EF4-4C37-B72A-E6DCFFBF7B02":
							virtualInstance=new ISpaceDDBF52926EF44C37B72AE6DCFFBF7B02();
							break;
					
											case "FF2ED876-20AB-4F5D-B62B-385405DFB900":
							virtualInstance=new ISpaceFF2ED87620AB4F5DB62B385405DFB900();
							break;
					
											case "2B40E332-9840-42E3-8DDC-002EAFAA05FA":
							virtualInstance=new ISpace2B40E332984042E38DDC002EAFAA05FA();
							break;
					
											case "537084A6-7B72-4CBE-A0A2-057049686345":
							virtualInstance=new ISpace537084A67B724CBEA0A2057049686345();
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
	

	public partial class ProjectFundInstallmentDataElementFactory  : ExtElementBase
    {

     /// <summary>
        /// A <see cref="log4net.ILog"/> that contains the logger instance for 
        /// logging
        /// </summary>
        private readonly ILog _sysLog;

        public ProjectFundInstallmentDataElementFactory()
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

               
                
                                      case "8A7A4CC4-0187-401F-BAF6-2AC1394A9245":
                    {
                     
                                     fInsertQuery=@"IF NOT EXISTS(SELECT 1 FROM [8A7A4CC4-0187-401F-BAF6-2AC1394A9245] WHERE InstanceId='{0}' AND
							ProcessActivityMapId='{1}' AND FormId='{2}') BEGIN INSERT INTO [8A7A4CC4-0187-401F-BAF6-2AC1394A9245](ProcessActivityMapId,FormId,MF_P1_ReceiptAmount,Amounttest,Addflag,IN_Status,M_FieldMandatory,MF_ProjectDetailsID,M_RemarksMandatory,R_ReceiptAmountBalance,R_ReceiptAmountValidation,M_IsSourceStep,M_Amount,MF_P1_Duration,M_SaveDomainData,Editflag,M_IsflowReturned,M_IsCancelReject,MF_P1_UpdatedBy,SLATime,C_FC_SanctionedValue_15,M_BudgetErr,IN_Priority,M_Totalsum,MF_P1_YearMonth,IN_Category,M_RequestId,R_TotalSplitUpAmount,RedirectUrl,IN_InstanceName,MF_E1_EmployeeBasicInfoId,CancelRedirectUrl,SetDestinationTo,UC_EmployeeId,C_FC_SanctionNo_15,UC_Designation,Mailcount,FC_SanctionedValue,MF_P1_ReceiptsId,C_FC_AgencyCode_15,C_FC_ProjectName_15,M_ActivityName,UC_EmployeeBaicInfoId,M_NextStage,AssignToRole,M_Budgetid,ProjectCode,HODUSERID,MF_P1_TransferReferenceNumber,MF_P1_ProjectDetailsId,Subject,FC_AgencyCode,FRValues,M_R2_ReceiptSplitUpId,M_DestinationActivityId,M_BudgetErrMsg,growid,IN_SLA,FC_ProjectNo,MF_P1_ReceiptNo,FC_Category,UC_DOB,FC_EndDate,FC_SanctionedDate,M_PackageProcessMapId,FC_ProjectName,M_Currentlevel,M_Remarks,UC_Grade,FC_SanctionNo,ExecutionStatus,UC_EmailId,Instanceid,UC_PhoneNumber,M_SourceActivityMapId,MF_P1_Status,UC_DOR,UC_Name,MF_P1_TransferReferenceBranch,ExecutionMessage,AssignToUser,M_Status,FC_StartDate,ExecuteCommand,M_InstanceId,KeyContext,DisplayContext,UC_Department,UC_Paylevel,C_FC_Category_15,M_InitiatorUserMapId,M_MoveToValue,UC_DOJ,M_MoveTo,C_FC_ProjectNo_15,MF_P1_TransferReferenceBankId,MF_P1_TransferType,MF_P1_UpdatedOn,MF_P1_ActualEndDate,C_FC_SanctionedDate_15,C_FC_StartDate_15,MF_P1_ReceiptDate,MF_P1_TransferReferenceDate,MF_P1_ActualDate,C_FC_EndDate,Thumbnail)
							VALUES( {3}) END ELSE BEGIN UPDATE [8A7A4CC4-0187-401F-BAF6-2AC1394A9245]SET {4}WHERE InstanceId='{0}'AND ProcessActivityMapId='{1}'AND FormId='{2}'END ";

                                     colList=@"ProcessActivityMapId,FormId,MF_P1_ReceiptAmount,Amounttest,Addflag,IN_Status,M_FieldMandatory,MF_ProjectDetailsID,M_RemarksMandatory,R_ReceiptAmountBalance,R_ReceiptAmountValidation,M_IsSourceStep,M_Amount,MF_P1_Duration,M_SaveDomainData,Editflag,M_IsflowReturned,M_IsCancelReject,MF_P1_UpdatedBy,SLATime,C_FC_SanctionedValue_15,M_BudgetErr,IN_Priority,M_Totalsum,MF_P1_YearMonth,IN_Category,M_RequestId,R_TotalSplitUpAmount,RedirectUrl,IN_InstanceName,MF_E1_EmployeeBasicInfoId,CancelRedirectUrl,SetDestinationTo,UC_EmployeeId,C_FC_SanctionNo_15,UC_Designation,Mailcount,FC_SanctionedValue,MF_P1_ReceiptsId,C_FC_AgencyCode_15,C_FC_ProjectName_15,M_ActivityName,UC_EmployeeBaicInfoId,M_NextStage,AssignToRole,M_Budgetid,ProjectCode,HODUSERID,MF_P1_TransferReferenceNumber,MF_P1_ProjectDetailsId,Subject,FC_AgencyCode,FRValues,M_R2_ReceiptSplitUpId,M_DestinationActivityId,M_BudgetErrMsg,growid,IN_SLA,FC_ProjectNo,MF_P1_ReceiptNo,FC_Category,UC_DOB,FC_EndDate,FC_SanctionedDate,M_PackageProcessMapId,FC_ProjectName,M_Currentlevel,M_Remarks,UC_Grade,FC_SanctionNo,ExecutionStatus,UC_EmailId,Instanceid,UC_PhoneNumber,M_SourceActivityMapId,MF_P1_Status,UC_DOR,UC_Name,MF_P1_TransferReferenceBranch,ExecutionMessage,AssignToUser,M_Status,FC_StartDate,ExecuteCommand,M_InstanceId,KeyContext,DisplayContext,UC_Department,UC_Paylevel,C_FC_Category_15,M_InitiatorUserMapId,M_MoveToValue,UC_DOJ,M_MoveTo,C_FC_ProjectNo_15,MF_P1_TransferReferenceBankId,MF_P1_TransferType,MF_P1_UpdatedOn,MF_P1_ActualEndDate,C_FC_SanctionedDate_15,C_FC_StartDate_15,MF_P1_ReceiptDate,MF_P1_TransferReferenceDate,MF_P1_ActualDate,C_FC_EndDate,Thumbnail";
                                    
                     
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

                
                 
                                      case "9A0E4095-1BE8-44D4-97FB-822ADA862E58":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_9A0E40951BE844D497FB822ADA862E58 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT){0}INSERT INTO [9A0E4095-1BE8-44D4-97FB-822ADA862E58](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence FROM @TBL_9A0E40951BE844D497FB822ADA862E58 TDT
							LEFT JOIN [9A0E4095-1BE8-44D4-97FB-822ADA862E58] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence";

                                     tempInsertQuery=@"INSERT INTO @TBL_9A0E40951BE844D497FB822ADA862E58(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)VALUES({0});";
                                     

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
                     
                                    case "C2287754-790E-4853-A5A7-64772676D00E":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_C2287754790E4853A5A764772676D00E AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT){0}INSERT INTO [C2287754-790E-4853-A5A7-64772676D00E](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence FROM @TBL_C2287754790E4853A5A764772676D00E TDT
							LEFT JOIN [C2287754-790E-4853-A5A7-64772676D00E] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence";

                                     tempInsertQuery=@"INSERT INTO @TBL_C2287754790E4853A5A764772676D00E(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)VALUES({0});";
                                     

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
                     
                                    case "8B4BCD21-9BD3-4278-AA2C-99F30B18BC32":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_8B4BCD219BD34278AA2C99F30B18BC32 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT){0}INSERT INTO [8B4BCD21-9BD3-4278-AA2C-99F30B18BC32](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence FROM @TBL_8B4BCD219BD34278AA2C99F30B18BC32 TDT
							LEFT JOIN [8B4BCD21-9BD3-4278-AA2C-99F30B18BC32] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence";

                                     tempInsertQuery=@"INSERT INTO @TBL_8B4BCD219BD34278AA2C99F30B18BC32(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)VALUES({0});";
                                     

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
                     
                                    case "249EF445-9B49-4EF9-8045-46BD1E6FF8ED":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_249EF4459B494EF9804546BD1E6FF8ED AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT){0}INSERT INTO [249EF445-9B49-4EF9-8045-46BD1E6FF8ED](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence FROM @TBL_249EF4459B494EF9804546BD1E6FF8ED TDT
							LEFT JOIN [249EF445-9B49-4EF9-8045-46BD1E6FF8ED] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence";

                                     tempInsertQuery=@"INSERT INTO @TBL_249EF4459B494EF9804546BD1E6FF8ED(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)VALUES({0});";
                                     

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
                     

                                         case "9A0E4095-1BE8-44D4-97FB-822ADA862E58":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_9A0E40951BE844D497FB822ADA862E58 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT){0}INSERT INTO [9A0E4095-1BE8-44D4-97FB-822ADA862E58](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence FROM @TBL_9A0E40951BE844D497FB822ADA862E58 TDT
							LEFT JOIN [9A0E4095-1BE8-44D4-97FB-822ADA862E58] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence";

                            tempInsertQuery=@"INSERT INTO @TBL_9A0E40951BE844D497FB822ADA862E58(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)VALUES({0});";

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

                                              case "C2287754-790E-4853-A5A7-64772676D00E":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_C2287754790E4853A5A764772676D00E AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT){0}INSERT INTO [C2287754-790E-4853-A5A7-64772676D00E](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence FROM @TBL_C2287754790E4853A5A764772676D00E TDT
							LEFT JOIN [C2287754-790E-4853-A5A7-64772676D00E] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence";

                            tempInsertQuery=@"INSERT INTO @TBL_C2287754790E4853A5A764772676D00E(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)VALUES({0});";

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

                                              case "8B4BCD21-9BD3-4278-AA2C-99F30B18BC32":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_8B4BCD219BD34278AA2C99F30B18BC32 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT){0}INSERT INTO [8B4BCD21-9BD3-4278-AA2C-99F30B18BC32](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence FROM @TBL_8B4BCD219BD34278AA2C99F30B18BC32 TDT
							LEFT JOIN [8B4BCD21-9BD3-4278-AA2C-99F30B18BC32] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence";

                            tempInsertQuery=@"INSERT INTO @TBL_8B4BCD219BD34278AA2C99F30B18BC32(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)VALUES({0});";

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

                                              case "249EF445-9B49-4EF9-8045-46BD1E6FF8ED":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_249EF4459B494EF9804546BD1E6FF8ED AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT){0}INSERT INTO [249EF445-9B49-4EF9-8045-46BD1E6FF8ED](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence FROM @TBL_249EF4459B494EF9804546BD1E6FF8ED TDT
							LEFT JOIN [249EF445-9B49-4EF9-8045-46BD1E6FF8ED] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence";

                            tempInsertQuery=@"INSERT INTO @TBL_249EF4459B494EF9804546BD1E6FF8ED(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)VALUES({0});";

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
public class ISpaceDDBF52926EF44C37B72AE6DCFFBF7B02 : VirtualForm
{
IISpace iSpace = new ISpace();
AcDataISpaceDDBF52926EF44C37B72AE6DCFFBF7B02 acdataIspaceDDBF52926EF44C37B72AE6DCFFBF7B02=new AcDataISpaceDDBF52926EF44C37B72AE6DCFFBF7B02();
private void SubscribeFormEvents_root(ref Dictionary<string, ServiceElementData> ISpace)
{
try
{
base.WriteDebugInfo(@"Root-OnAfterFormLoad");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["M_InitiatorUserMapId"].Value=ISpace["gv_usermapid"].Value;
base.WriteDebugInfo(@"ISpace[""M_InitiatorUserMapId""].Value=ISpace[""gv_usermapid""].Value;");
ISpace["MF_P1_ReceiptsId"].Value=ISpace["gv_instanceid"].Value;
base.WriteDebugInfo(@"ISpace[""MF_P1_ReceiptsId""].Value=ISpace[""gv_instanceid""].Value;");
base.WriteDebugInfo(@"EXEC [GetEmployeeUserContextDetails] '@@gv_UserId'");

var querySource3A06B075E4874835B114FD3DF7DAC69D =GetQueryExpressionDataSource("3A06B075-E487-4835-B114-FD3DF7DAC69D");
Dictionary<short,object> result3A06B075E4874835B114FD3DF7DAC69D=iSpace.ExecuteQuery(querySource3A06B075E4874835B114FD3DF7DAC69D,@"EXEC [GetEmployeeUserContextDetails] '" + ISpace["gv_userid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource3A06B075E4874835B114FD3DF7DAC69D =GetQueryExpressionDataSource(""3A06B075-E487-4835-B114-FD3DF7DAC69D"");Dictionary<short,object> result3A06B075E4874835B114FD3DF7DAC69D=iSpace.ExecuteQuery(querySource3A06B075E4874835B114FD3DF7DAC69D,@""EXEC [GetEmployeeUserContextDetails] '"" + ISpace[""gv_userid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result3A06B075E4874835B114FD3DF7DAC69D!=null) && (result3A06B075E4874835B114FD3DF7DAC69D.Count!=0))
{
if(result3A06B075E4874835B114FD3DF7DAC69D.ContainsKey(5))
ISpace["UC_PhoneNumber"].Value = result3A06B075E4874835B114FD3DF7DAC69D[5];
if(result3A06B075E4874835B114FD3DF7DAC69D.ContainsKey(2))
ISpace["UC_Name"].Value = result3A06B075E4874835B114FD3DF7DAC69D[2];
if(result3A06B075E4874835B114FD3DF7DAC69D.ContainsKey(1))
ISpace["UC_EmployeeId"].Value = result3A06B075E4874835B114FD3DF7DAC69D[1];
if(result3A06B075E4874835B114FD3DF7DAC69D.ContainsKey(9))
ISpace["UC_DOB"].Value = result3A06B075E4874835B114FD3DF7DAC69D[9];
if(result3A06B075E4874835B114FD3DF7DAC69D.ContainsKey(7))
ISpace["UC_Designation"].Value = result3A06B075E4874835B114FD3DF7DAC69D[7];
if(result3A06B075E4874835B114FD3DF7DAC69D.ContainsKey(10))
ISpace["UC_DOR"].Value = result3A06B075E4874835B114FD3DF7DAC69D[10];
if(result3A06B075E4874835B114FD3DF7DAC69D.ContainsKey(12))
ISpace["UC_Paylevel"].Value = result3A06B075E4874835B114FD3DF7DAC69D[12];
if(result3A06B075E4874835B114FD3DF7DAC69D.ContainsKey(6))
ISpace["UC_Department"].Value = result3A06B075E4874835B114FD3DF7DAC69D[6];
if(result3A06B075E4874835B114FD3DF7DAC69D.ContainsKey(3))
ISpace["UC_EmailId"].Value = result3A06B075E4874835B114FD3DF7DAC69D[3];
if(result3A06B075E4874835B114FD3DF7DAC69D.ContainsKey(0))
ISpace["UC_EmployeeBaicInfoId"].Value = result3A06B075E4874835B114FD3DF7DAC69D[0];
if(result3A06B075E4874835B114FD3DF7DAC69D.ContainsKey(11))
ISpace["UC_Grade"].Value = result3A06B075E4874835B114FD3DF7DAC69D[11];
if(result3A06B075E4874835B114FD3DF7DAC69D.ContainsKey(4))
ISpace["UC_DOJ"].Value = result3A06B075E4874835B114FD3DF7DAC69D[4];
}
else{
ISpace["UC_PhoneNumber"].Value = null;ISpace["UC_Name"].Value = null;ISpace["UC_EmployeeId"].Value = null;ISpace["UC_DOB"].Value = null;ISpace["UC_Designation"].Value = null;ISpace["UC_DOR"].Value = null;ISpace["UC_Paylevel"].Value = null;ISpace["UC_Department"].Value = null;ISpace["UC_EmailId"].Value = null;ISpace["UC_EmployeeBaicInfoId"].Value = null;ISpace["UC_Grade"].Value = null;ISpace["UC_DOJ"].Value = null;
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
ISpace["M_ActivityName"].Value=ISpace["gv_activityname"].Value;
base.WriteDebugInfo(@"ISpace[""M_ActivityName""].Value=ISpace[""gv_activityname""].Value;");
ISpace["UC_PhoneNumber"].Visible="false";ISpace["UC_DOB"].Visible="false";ISpace["UC_DOR"].Visible="false";ISpace["UC_Paylevel"].Visible="false";ISpace["UC_EmailId"].Visible="false";ISpace["UC_Grade"].Visible="false";ISpace["UC_DOJ"].Visible="false";
base.WriteDebugInfo(@"ISpace[""UC_PhoneNumber""].Visible=""false"";ISpace[""UC_DOB""].Visible=""false"";ISpace[""UC_DOR""].Visible=""false"";ISpace[""UC_Paylevel""].Visible=""false"";ISpace[""UC_EmailId""].Visible=""false"";ISpace[""UC_Grade""].Visible=""false"";ISpace[""UC_DOJ""].Visible=""false"";");
if(ISpace["FormVersionId"].Value=="B1CB93DB-7B9C-4661-BE11-02ED3BFD5725")
{
ISpace["UI_AvailablebudgetModal"].Visible="false";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""B1CB93DB-7B9C-4661-BE11-02ED3BFD5725"")
{
ISpace[""UI_AvailablebudgetModal""].Visible=""false"";
}");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["MFG_R2_ReceiptSplitUpId"].Visible="false";ISpace["MF_P1_TransferReferenceBankId"].Visible="true";ISpace["MF_P1_TransferReferenceBranch"].Visible="true";ISpace["MF_P1_ReceiptAmount"].Visible="true";ISpace["MF_P1_TransferType"].Visible="true";ISpace["MF_P1_TransferReferenceNumber"].Visible="true";ISpace["MF_P1_Status"].Visible="false";ISpace["MF_P1_ReceiptNo"].Visible="true";ISpace["MF_P1_ProjectDetailsId"].Visible="true";ISpace["MF_P1_UpdatedOn"].Visible="false";ISpace["MF_P1_TransferReferenceDate"].Visible="true";ISpace["MFG_R2_UpdatedBy"].Visible="false";ISpace["MF_P1_ReceiptsId"].Visible="true";ISpace["MF_P1_ReceiptDate"].Visible="true";ISpace["MF_P1_UpdatedBy"].Visible="false";ISpace["MFG_R2_Amount"].Visible="true";ISpace["MFG_R2_UpdatedOn"].Visible="false";ISpace["MFG_R2_ReceiptsId"].Visible="false";ISpace["MFG_R2_BudgetId"].Visible="true";
base.WriteDebugInfo(@"ISpace[""MFG_R2_ReceiptSplitUpId""].Visible=""false"";ISpace[""MF_P1_TransferReferenceBankId""].Visible=""true"";ISpace[""MF_P1_TransferReferenceBranch""].Visible=""true"";ISpace[""MF_P1_ReceiptAmount""].Visible=""true"";ISpace[""MF_P1_TransferType""].Visible=""true"";ISpace[""MF_P1_TransferReferenceNumber""].Visible=""true"";ISpace[""MF_P1_Status""].Visible=""false"";ISpace[""MF_P1_ReceiptNo""].Visible=""true"";ISpace[""MF_P1_ProjectDetailsId""].Visible=""true"";ISpace[""MF_P1_UpdatedOn""].Visible=""false"";ISpace[""MF_P1_TransferReferenceDate""].Visible=""true"";ISpace[""MFG_R2_UpdatedBy""].Visible=""false"";ISpace[""MF_P1_ReceiptsId""].Visible=""true"";ISpace[""MF_P1_ReceiptDate""].Visible=""true"";ISpace[""MF_P1_UpdatedBy""].Visible=""false"";ISpace[""MFG_R2_Amount""].Visible=""true"";ISpace[""MFG_R2_UpdatedOn""].Visible=""false"";ISpace[""MFG_R2_ReceiptsId""].Visible=""false"";ISpace[""MFG_R2_BudgetId""].Visible=""true"";");
ISpace["MG_R2_ReceiptsId"].Visible="true";ISpace["MG_R2_BudgetId"].Visible="true";ISpace["MG_R2_Amount"].Visible="true";ISpace["MG_R2_UpdatedBy"].Visible="false";ISpace["MG_R2_UpdatedOn"].Visible="false";ISpace["MG_R2_ReceiptSplitUpId"].Visible="true";
base.WriteDebugInfo(@"ISpace[""MG_R2_ReceiptsId""].Visible=""true"";ISpace[""MG_R2_BudgetId""].Visible=""true"";ISpace[""MG_R2_Amount""].Visible=""true"";ISpace[""MG_R2_UpdatedBy""].Visible=""false"";ISpace[""MG_R2_UpdatedOn""].Visible=""false"";ISpace[""MG_R2_ReceiptSplitUpId""].Visible=""true"";");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["MF_P1_ReceiptAmount"].Man=true;ISpace["MF_P1_ProjectDetailsId"].Man=true;ISpace["MF_P1_ReceiptDate"].Man=true;ISpace["MFG_R2_Amount"].Man=true;ISpace["MFG_R2_BudgetId"].Man=true;
base.WriteDebugInfo(@"ISpace[""MF_P1_ReceiptAmount""].Man=true;ISpace[""MF_P1_ProjectDetailsId""].Man=true;ISpace[""MF_P1_ReceiptDate""].Man=true;ISpace[""MFG_R2_Amount""].Man=true;ISpace[""MFG_R2_BudgetId""].Man=true;");
}

var querySourceB8A2A58C91CA4FD4B3269652593DD27B =GetQueryExpressionDataSource("B8A2A58C-91CA-4FD4-B326-9652593DD27B");

DataTable resultB8A2A58C91CA4FD4B3269652593DD27B=iSpace.SetGridDataSource(querySourceB8A2A58C91CA4FD4B3269652593DD27B, _objectFactory.GetGridRPP("MG_RemarksDetails"),@"EXEC GetRemarks '" + ISpace["Instanceid"].Value + @"'");

iSpace.InsertGridBindDetails("MG_RemarksDetails","11",querySourceB8A2A58C91CA4FD4B3269652593DD27B,"EXEC GetRemarks '" + ISpace["Instanceid"].Value + @"'",_objectFactory.GetGridRPP("MG_RemarksDetails"));

base.WriteDebugInfo(@"var querySourceB8A2A58C91CA4FD4B3269652593DD27B =GetQueryExpressionDataSource(""B8A2A58C-91CA-4FD4-B326-9652593DD27B"");DataTable resultB8A2A58C91CA4FD4B3269652593DD27B=iSpace.SetGridDataSource(querySourceB8A2A58C91CA4FD4B3269652593DD27B, _objectFactory.GetGridRPP(""MG_RemarksDetails""),@""EXEC GetRemarks '"" + ISpace[""Instanceid""].Value + @""'"");iSpace.InsertGridBindDetails(""MG_RemarksDetails"",""11"",querySourceB8A2A58C91CA4FD4B3269652593DD27B,""EXEC GetRemarks '"" + ISpace[""Instanceid""].Value + @""'"",_objectFactory.GetGridRPP(""MG_RemarksDetails""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result4ACD680C9EAE4FDBA4A3FC5C4D353701=acdataIspaceDDBF52926EF44C37B72AE6DCFFBF7B02.GetQueryExpressionBindings("4ACD680C-9EAE-4FDB-A4A3-FC5C4D353701");
iSpace.SetGridData(resultB8A2A58C91CA4FD4B3269652593DD27B,result4ACD680C9EAE4FDBA4A3FC5C4D353701,"MG_RemarksDetails",ref ISpace);
iSpace.UpdateGridBindDetails("MG_RemarksDetails",result4ACD680C9EAE4FDBA4A3FC5C4D353701);
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
if(ISpace["MF_P1_ReceiptAmount"].Value==0)
{
base.WriteDebugInfo(@"if(ISpace[""MF_P1_ReceiptAmount""].Value==0)");
ISpace["Message"].Value=@"Please Enter the Amount";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please Enter the Amount"";");
return;
base.WriteDebugInfo(@"return;");
}
if((ISpace["MF_P1_ReceiptDate"].Value == null))
{
base.WriteDebugInfo(@"if((ISpace[""MF_P1_ReceiptDate""].Value == null))");
ISpace["Message"].Value=@"Please Enter the Date";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please Enter the Date"";");
return;
base.WriteDebugInfo(@"return;");
}
if(1==2)
{
base.WriteDebugInfo(@"if(1==2)");
ISpace["Message"].Value=@"Please Enter the Transfer Type";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please Enter the Transfer Type"";");
return;
base.WriteDebugInfo(@"return;");
}
if(1==2)
{
base.WriteDebugInfo(@"if(1==2)");
ISpace["Message"].Value=@"Please Enter the Transfer Reference Number";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please Enter the Transfer Reference Number"";");
return;
base.WriteDebugInfo(@"return;");
}
if(1==2)
{
base.WriteDebugInfo(@"if(1==2)");
ISpace["Message"].Value=@"Please Enter the Transfer Date";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please Enter the Transfer Date"";");
return;
base.WriteDebugInfo(@"return;");
}
if(1==2)
{
base.WriteDebugInfo(@"if(1==2)");
ISpace["Message"].Value=@"Please Enter the Bank Name";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please Enter the Bank Name"";");
return;
base.WriteDebugInfo(@"return;");
}
if(1==2)
{
base.WriteDebugInfo(@"if(1==2)");
ISpace["Message"].Value=@"Please Enter the Branch Name";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please Enter the Branch Name"";");
return;
base.WriteDebugInfo(@"return;");
}
if(1==2)
{
base.WriteDebugInfo(@"if(1==2)");
ISpace["Message"].Value=@"Please Enter the Receipt No";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please Enter the Receipt No"";");
return;
base.WriteDebugInfo(@"return;");
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_P1_ReceiptAmount"].Value!=ISpace["R_TotalSplitUpAmount"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_P1_ReceiptAmount""].Value!=ISpace[""R_TotalSplitUpAmount""].Value)");
ISpace["Message"].Value=@"Split Up total should be equal to Fund Installment Amount";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Split Up total should be equal to Fund Installment Amount"";");
return;
base.WriteDebugInfo(@"return;");
}
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
if (_elementBase != null)  iSpace.SetLoopExpressionData("MG_DcoumentDetails","C2287754-790E-4853-A5A7-64772676D00E",_objectFactory.GetGridRPP("MG_DcoumentDetails"),_elementBase.GetGridLoopQuery("C2287754-790E-4853-A5A7-64772676D00E","MG_DcoumentDetails",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""MG_DcoumentDetails"",ref ISpace);

foreach(var gridChild in ISpace[""MG_DcoumentDetails""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
ISpace["SetDestinationTo"].Value=ISpace["M_DestinationActivityId"].Value;
base.WriteDebugInfo(@"ISpace[""SetDestinationTo""].Value=ISpace[""M_DestinationActivityId""].Value;");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["M_Status"].Value="Pending";
base.WriteDebugInfo(@"ISpace[""M_Status""].Value=""Pending"";");
}
ISpace["Message"].Value=@"Submitted Successfully";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Submitted Successfully"";");

var querySourceB8A2A58C91CA4FD4B3269652593DD27B =GetQueryExpressionDataSource("B8A2A58C-91CA-4FD4-B326-9652593DD27B");

DataTable resultB8A2A58C91CA4FD4B3269652593DD27B=iSpace.SetGridDataSource(querySourceB8A2A58C91CA4FD4B3269652593DD27B, _objectFactory.GetGridRPP("MG_RemarksDetails"),@"EXEC GetRemarks '" + ISpace["Instanceid"].Value + @"'");

iSpace.InsertGridBindDetails("MG_RemarksDetails","11",querySourceB8A2A58C91CA4FD4B3269652593DD27B,"EXEC GetRemarks '" + ISpace["Instanceid"].Value + @"'",_objectFactory.GetGridRPP("MG_RemarksDetails"));

base.WriteDebugInfo(@"var querySourceB8A2A58C91CA4FD4B3269652593DD27B =GetQueryExpressionDataSource(""B8A2A58C-91CA-4FD4-B326-9652593DD27B"");DataTable resultB8A2A58C91CA4FD4B3269652593DD27B=iSpace.SetGridDataSource(querySourceB8A2A58C91CA4FD4B3269652593DD27B, _objectFactory.GetGridRPP(""MG_RemarksDetails""),@""EXEC GetRemarks '"" + ISpace[""Instanceid""].Value + @""'"");iSpace.InsertGridBindDetails(""MG_RemarksDetails"",""11"",querySourceB8A2A58C91CA4FD4B3269652593DD27B,""EXEC GetRemarks '"" + ISpace[""Instanceid""].Value + @""'"",_objectFactory.GetGridRPP(""MG_RemarksDetails""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result4ACD680C9EAE4FDBA4A3FC5C4D353701=acdataIspaceDDBF52926EF44C37B72AE6DCFFBF7B02.GetQueryExpressionBindings("4ACD680C-9EAE-4FDB-A4A3-FC5C4D353701");
iSpace.SetGridData(resultB8A2A58C91CA4FD4B3269652593DD27B,result4ACD680C9EAE4FDBA4A3FC5C4D353701,"MG_RemarksDetails",ref ISpace);
iSpace.UpdateGridBindDetails("MG_RemarksDetails",result4ACD680C9EAE4FDBA4A3FC5C4D353701);
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mg_r2_amount (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MG_R2_Amount-OnChange");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
object MG_R2_Amount=iSpace.Sum("[249EF445-9B49-4EF9-8045-46BD1E6FF8ED]","MG_R2_Amount","");
ISpace["R_TotalSplitUpAmount"].Value=Convert.ChangeType(MG_R2_Amount, MG_R2_Amount.GetType());;
base.WriteDebugInfo(@"object MG_R2_Amount=iSpace.Sum(""[249EF445-9B49-4EF9-8045-46BD1E6FF8ED]"",""MG_R2_Amount"","""");
ISpace[""R_TotalSplitUpAmount""].Value=Convert.ChangeType(MG_R2_Amount, MG_R2_Amount.GetType());;");
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mf_p1_actualdate (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MF_P1_ActualDate-OnChange");
if(ISpace["MF_P1_YearMonth"].Value!=0)
{
base.WriteDebugInfo(@"if(ISpace[""MF_P1_YearMonth""].Value!=0)");
if(ISpace["MF_P1_YearMonth"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""MF_P1_YearMonth""].Value==1)");
ISpace["MF_P1_ActualendDate"].Value=AddMonth(ISpace["MF_P1_ActualDate"].Value,ISpace["MF_P1_Duration"].Value);
base.WriteDebugInfo(@"ISpace[""MF_P1_ActualendDate""].Value=AddMonth(ISpace[""MF_P1_ActualDate""].Value,ISpace[""MF_P1_Duration""].Value);");
}
if(ISpace["MF_P1_YearMonth"].Value==2)
{
base.WriteDebugInfo(@"if(ISpace[""MF_P1_YearMonth""].Value==2)");
ISpace["MF_P1_ActualendDate"].Value=AddYear(ISpace["MF_P1_ActualDate"].Value,ISpace["MF_P1_Duration"].Value);
base.WriteDebugInfo(@"ISpace[""MF_P1_ActualendDate""].Value=AddYear(ISpace[""MF_P1_ActualDate""].Value,ISpace[""MF_P1_Duration""].Value);");
}
ISpace["MF_P1_ActualendDate"].Value=AddDay(ISpace["MF_P1_ActualendDate"].Value,-1);
base.WriteDebugInfo(@"ISpace[""MF_P1_ActualendDate""].Value=AddDay(ISpace[""MF_P1_ActualendDate""].Value,-1);");
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mf_p1_receiptamount (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MF_P1_ReceiptAmount-OnChange");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_P1_ReceiptAmount"].Value>ISpace["R_ReceiptAmountValidation"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_P1_ReceiptAmount""].Value>ISpace[""R_ReceiptAmountValidation""].Value)");
ISpace["Message"].Value=@"Fund Installment amount should be less than the Project Sanctioned Value.";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Fund Installment amount should be less than the Project Sanctioned Value."";");
ISpace["MF_P1_ReceiptAmount"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_P1_ReceiptAmount""].Value=null;");
return;
base.WriteDebugInfo(@"return;");
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["R_ReceiptAmountBalance"].Value=ISpace["MF_P1_ReceiptAmount"].Value;
base.WriteDebugInfo(@"ISpace[""R_ReceiptAmountBalance""].Value=ISpace[""MF_P1_ReceiptAmount""].Value;");
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_availablebudgetclose (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"AvailableBudgetclose-OnClick");

if(ISpace["FormVersionId"].Value=="B1CB93DB-7B9C-4661-BE11-02ED3BFD5725")
{
iSpace.SetUIControlProperty("UI_AvailablebudgetModal","ShowModal","false",ref  ISpace);;
}

base.WriteDebugInfo(@"
if(ISpace[""FormVersionId""].Value==""B1CB93DB-7B9C-4661-BE11-02ED3BFD5725"")
{
iSpace.SetUIControlProperty(""UI_AvailablebudgetModal"",""ShowModal"",""false"",ref  ISpace);;
}
");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_c_fc_projectno_15 (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"C_FC_ProjectNo_15-OnChange");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC GETReceiptAmountBalace 2,'#C_FC_ProjectNo_15'");

var querySource82426A40A87041909F2B6350B84FC4D6 =GetQueryExpressionDataSource("82426A40-A870-4190-9F2B-6350B84FC4D6");
Dictionary<short,object> result82426A40A87041909F2B6350B84FC4D6=iSpace.ExecuteQuery(querySource82426A40A87041909F2B6350B84FC4D6,@"EXEC GETReceiptAmountBalace 2,'" + ISpace["C_FC_ProjectNo_15"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource82426A40A87041909F2B6350B84FC4D6 =GetQueryExpressionDataSource(""82426A40-A870-4190-9F2B-6350B84FC4D6"");Dictionary<short,object> result82426A40A87041909F2B6350B84FC4D6=iSpace.ExecuteQuery(querySource82426A40A87041909F2B6350B84FC4D6,@""EXEC GETReceiptAmountBalace 2,'"" + ISpace[""C_FC_ProjectNo_15""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result82426A40A87041909F2B6350B84FC4D6!=null) && (result82426A40A87041909F2B6350B84FC4D6.Count!=0))
{
if(result82426A40A87041909F2B6350B84FC4D6.ContainsKey(2))
ISpace["C_FC_SanctionedDate_15"].Value = result82426A40A87041909F2B6350B84FC4D6[2];
if(result82426A40A87041909F2B6350B84FC4D6.ContainsKey(11))
ISpace["MF_P1_ActualDate"].Value = result82426A40A87041909F2B6350B84FC4D6[11];
if(result82426A40A87041909F2B6350B84FC4D6.ContainsKey(4))
ISpace["C_FC_EndDate"].Value = result82426A40A87041909F2B6350B84FC4D6[4];
if(result82426A40A87041909F2B6350B84FC4D6.ContainsKey(3))
ISpace["C_FC_StartDate_15"].Value = result82426A40A87041909F2B6350B84FC4D6[3];
if(result82426A40A87041909F2B6350B84FC4D6.ContainsKey(14))
ISpace["MF_P1_ActualEndDate"].Value = result82426A40A87041909F2B6350B84FC4D6[14];
if(result82426A40A87041909F2B6350B84FC4D6.ContainsKey(8))
ISpace["C_FC_SanctionedValue_15"].Value = result82426A40A87041909F2B6350B84FC4D6[8];
if(result82426A40A87041909F2B6350B84FC4D6.ContainsKey(12))
ISpace["MF_P1_YearMonth"].Value = result82426A40A87041909F2B6350B84FC4D6[12];
if(result82426A40A87041909F2B6350B84FC4D6.ContainsKey(10))
ISpace["MF_ProjectDetailsID"].Value = result82426A40A87041909F2B6350B84FC4D6[10];
if(result82426A40A87041909F2B6350B84FC4D6.ContainsKey(13))
ISpace["MF_P1_Duration"].Value = result82426A40A87041909F2B6350B84FC4D6[13];
if(result82426A40A87041909F2B6350B84FC4D6.ContainsKey(5))
ISpace["C_FC_SanctionNo_15"].Value = result82426A40A87041909F2B6350B84FC4D6[5];
if(result82426A40A87041909F2B6350B84FC4D6.ContainsKey(9))
ISpace["ProjectCode"].Value = result82426A40A87041909F2B6350B84FC4D6[9];
if(result82426A40A87041909F2B6350B84FC4D6.ContainsKey(7))
ISpace["C_FC_Category_15"].Value = result82426A40A87041909F2B6350B84FC4D6[7];
if(result82426A40A87041909F2B6350B84FC4D6.ContainsKey(1))
ISpace["C_FC_ProjectName_15"].Value = result82426A40A87041909F2B6350B84FC4D6[1];
if(result82426A40A87041909F2B6350B84FC4D6.ContainsKey(6))
ISpace["C_FC_AgencyCode_15"].Value = result82426A40A87041909F2B6350B84FC4D6[6];
}
else{
ISpace["C_FC_SanctionedDate_15"].Value = null;ISpace["MF_P1_ActualDate"].Value = null;ISpace["C_FC_EndDate"].Value = null;ISpace["C_FC_StartDate_15"].Value = null;ISpace["MF_P1_ActualEndDate"].Value = null;ISpace["C_FC_SanctionedValue_15"].Value = null;ISpace["MF_P1_YearMonth"].Value = null;ISpace["MF_ProjectDetailsID"].Value = null;ISpace["MF_P1_Duration"].Value = null;ISpace["C_FC_SanctionNo_15"].Value = null;ISpace["ProjectCode"].Value = null;ISpace["C_FC_Category_15"].Value = null;ISpace["C_FC_ProjectName_15"].Value = null;ISpace["C_FC_AgencyCode_15"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC GETReceiptAmountBalace 1,'#C_FC_ProjectNo_15'");

var querySource53963539D3EB42AC923B633B75334F3E =GetQueryExpressionDataSource("53963539-D3EB-42AC-923B-633B75334F3E");
Dictionary<short,object> result53963539D3EB42AC923B633B75334F3E=iSpace.ExecuteQuery(querySource53963539D3EB42AC923B633B75334F3E,@"EXEC GETReceiptAmountBalace 1,'" + ISpace["C_FC_ProjectNo_15"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource53963539D3EB42AC923B633B75334F3E =GetQueryExpressionDataSource(""53963539-D3EB-42AC-923B-633B75334F3E"");Dictionary<short,object> result53963539D3EB42AC923B633B75334F3E=iSpace.ExecuteQuery(querySource53963539D3EB42AC923B633B75334F3E,@""EXEC GETReceiptAmountBalace 1,'"" + ISpace[""C_FC_ProjectNo_15""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result53963539D3EB42AC923B633B75334F3E!=null) && (result53963539D3EB42AC923B633B75334F3E.Count!=0))
{
if(result53963539D3EB42AC923B633B75334F3E.ContainsKey(0))
ISpace["R_ReceiptAmountValidation"].Value = result53963539D3EB42AC923B633B75334F3E[0];
}
else{
ISpace["R_ReceiptAmountValidation"].Value = null;
}
}
ISpace["Subject"].Value=ISpace["C_FC_ProjectName_15"].Value;
base.WriteDebugInfo(@"ISpace[""Subject""].Value=ISpace[""C_FC_ProjectName_15""].Value;");
ISpace["MFG_R2_BudgetId"].rElemData=iSpace.Reload(ISpace["MFG_R2_BudgetId"].Value,@"EXEC SP_GetBudgetDetails  '" + ISpace["C_FC_ProjectNo_15"].Value + @"'","3A103712-5244-4427-B2B6-1C4E046FD337");
base.WriteDebugInfo(@"ISpace[""MFG_R2_BudgetId""].rElemData=iSpace.Reload(ISpace[""MFG_R2_BudgetId""].Value,@""EXEC SP_GetBudgetDetails  '"" + ISpace[""C_FC_ProjectNo_15""].Value + @""'"",""3A103712-5244-4427-B2B6-1C4E046FD337"");");
ISpace["M_MoveTo"].rElemData=iSpace.Reload(ISpace["M_MoveTo"].Value,@"EXEC GetMovetoValuesProjectFundInstallment 1,'" + ISpace["C_FC_Category_15"].Value + @"','" + ISpace["M_ActivityName"].Value + @"'","9ADED37B-CD11-426B-AF16-DEAC75685EF5");
base.WriteDebugInfo(@"ISpace[""M_MoveTo""].rElemData=iSpace.Reload(ISpace[""M_MoveTo""].Value,@""EXEC GetMovetoValuesProjectFundInstallment 1,'"" + ISpace[""C_FC_Category_15""].Value + @""','"" + ISpace[""M_ActivityName""].Value + @""'"",""9ADED37B-CD11-426B-AF16-DEAC75685EF5"");");
base.WriteDebugInfo(@"EXEC GetMovetoValuesProjectFundInstallment 2,'#C_FC_Category_15','#M_ActivityName'");

var querySource7DA1AAC410794683ACB6836196476D5A =GetQueryExpressionDataSource("7DA1AAC4-1079-4683-ACB6-836196476D5A");
Dictionary<short,object> result7DA1AAC410794683ACB6836196476D5A=iSpace.ExecuteQuery(querySource7DA1AAC410794683ACB6836196476D5A,@"EXECGetMovetoValuesProjectFundInstallment2,'" + ISpace["C_FC_Category_15"].Value + @"','" + ISpace["M_ActivityName"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource7DA1AAC410794683ACB6836196476D5A =GetQueryExpressionDataSource(""7DA1AAC4-1079-4683-ACB6-836196476D5A"");Dictionary<short,object> result7DA1AAC410794683ACB6836196476D5A=iSpace.ExecuteQuery(querySource7DA1AAC410794683ACB6836196476D5A,@""EXECGetMovetoValuesProjectFundInstallment2,'"" + ISpace[""C_FC_Category_15""].Value + @""','"" + ISpace[""M_ActivityName""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result7DA1AAC410794683ACB6836196476D5A!=null) && (result7DA1AAC410794683ACB6836196476D5A.Count!=0))
{
if(result7DA1AAC410794683ACB6836196476D5A.ContainsKey(2))
ISpace["M_NextStage"].Value = result7DA1AAC410794683ACB6836196476D5A[2];
if(result7DA1AAC410794683ACB6836196476D5A.ContainsKey(5))
ISpace["M_Remarks"].Value = result7DA1AAC410794683ACB6836196476D5A[5];
if(result7DA1AAC410794683ACB6836196476D5A.ContainsKey(0))
ISpace["M_DestinationActivityId"].Value = result7DA1AAC410794683ACB6836196476D5A[0];
}
else{
ISpace["M_NextStage"].Value = null;ISpace["M_Remarks"].Value = null;ISpace["M_DestinationActivityId"].Value = null;
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySourceEE2E79C54A8F4AC1A64E6FCFA533D02D =GetQueryExpressionDataSource("EE2E79C5-4A8F-4AC1-A64E-6FCFA533D02D");

DataTable resultEE2E79C54A8F4AC1A64E6FCFA533D02D=iSpace.SetGridDataSource(querySourceEE2E79C54A8F4AC1A64E6FCFA533D02D, _objectFactory.GetGridRPP("AvailableBudgetHeadAmount"),@"EXEC GetReceiptClaimRecords 1,'" + ISpace["C_FC_ProjectNo_15"].Value + @"',''");

iSpace.InsertGridBindDetails("AvailableBudgetHeadAmount","11",querySourceEE2E79C54A8F4AC1A64E6FCFA533D02D,"EXEC GetReceiptClaimRecords 1,'" + ISpace["C_FC_ProjectNo_15"].Value + @"',''",_objectFactory.GetGridRPP("AvailableBudgetHeadAmount"));

base.WriteDebugInfo(@"var querySourceEE2E79C54A8F4AC1A64E6FCFA533D02D =GetQueryExpressionDataSource(""EE2E79C5-4A8F-4AC1-A64E-6FCFA533D02D"");DataTable resultEE2E79C54A8F4AC1A64E6FCFA533D02D=iSpace.SetGridDataSource(querySourceEE2E79C54A8F4AC1A64E6FCFA533D02D, _objectFactory.GetGridRPP(""AvailableBudgetHeadAmount""),@""EXEC GetReceiptClaimRecords 1,'"" + ISpace[""C_FC_ProjectNo_15""].Value + @""',''"");iSpace.InsertGridBindDetails(""AvailableBudgetHeadAmount"",""11"",querySourceEE2E79C54A8F4AC1A64E6FCFA533D02D,""EXEC GetReceiptClaimRecords 1,'"" + ISpace[""C_FC_ProjectNo_15""].Value + @""',''"",_objectFactory.GetGridRPP(""AvailableBudgetHeadAmount""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result7383DEAC014B4719858E5F2EDC911594=acdataIspaceDDBF52926EF44C37B72AE6DCFFBF7B02.GetQueryExpressionBindings("7383DEAC-014B-4719-858E-5F2EDC911594");
iSpace.SetGridData(resultEE2E79C54A8F4AC1A64E6FCFA533D02D,result7383DEAC014B4719858E5F2EDC911594,"AvailableBudgetHeadAmount",ref ISpace);
iSpace.UpdateGridBindDetails("AvailableBudgetHeadAmount",result7383DEAC014B4719858E5F2EDC911594);
}
ISpace["MF_P1_ReceiptAmount"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_P1_ReceiptAmount""].Enbl=""true"";");
ISpace["MF_P1_ReceiptAmount"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_P1_ReceiptAmount""].Value=null;");
ISpace["MF_P1_ReceiptDate"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_P1_ReceiptDate""].Value=null;");
ISpace["MF_P1_TransferReferenceNumber"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_P1_TransferReferenceNumber""].Value=null;");
ISpace["MF_P1_TransferReferenceBankId"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_P1_TransferReferenceBankId""].Value=null;");
ISpace["MF_P1_TransferReferenceBranch"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_P1_TransferReferenceBranch""].Value=null;");
ISpace["MF_P1_TransferReferenceDate"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_P1_TransferReferenceDate""].Value=null;");
ISpace["MF_P1_TransferType"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_P1_TransferType""].Value=null;");
ISpace["MFG_R2_BudgetId"].Value=null;
base.WriteDebugInfo(@"ISpace[""MFG_R2_BudgetId""].Value=null;");
ISpace["MFG_R2_Amount"].Value=null;
base.WriteDebugInfo(@"ISpace[""MFG_R2_Amount""].Value=null;");
ISpace["ReceiptSplitUp"].Value=null;
base.WriteDebugInfo(@"ISpace[""ReceiptSplitUp""].Value=null;");
ISpace["R_ReceiptAmountBalance"].Value=null;
base.WriteDebugInfo(@"ISpace[""R_ReceiptAmountBalance""].Value=null;");
ISpace["R_TotalSplitUpAmount"].Value=null;
base.WriteDebugInfo(@"ISpace[""R_TotalSplitUpAmount""].Value=null;");
ISpace["Instanceid"].Value=Guid.NewGuid().ToString();
base.WriteDebugInfo(@"ISpace[""Instanceid""].Value=Guid.NewGuid().ToString();");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"exec GetMySponsoredProjects 6,'#ProjectCode',''");

var querySource3B027C6216344105BF4D15B3AA014207 =GetQueryExpressionDataSource("3B027C62-1634-4105-BF4D-15B3AA014207");
Dictionary<short,object> result3B027C6216344105BF4D15B3AA014207=iSpace.ExecuteQuery(querySource3B027C6216344105BF4D15B3AA014207,@"execGetMySponsoredProjects 6,'" + ISpace["ProjectCode"].Value + @"',''",false);

base.WriteDebugInfo(@"var querySource3B027C6216344105BF4D15B3AA014207 =GetQueryExpressionDataSource(""3B027C62-1634-4105-BF4D-15B3AA014207"");Dictionary<short,object> result3B027C6216344105BF4D15B3AA014207=iSpace.ExecuteQuery(querySource3B027C6216344105BF4D15B3AA014207,@""execGetMySponsoredProjects 6,'"" + ISpace[""ProjectCode""].Value + @""',''"",false);");
base.WriteDebugInfo(@"");

if((result3B027C6216344105BF4D15B3AA014207!=null) && (result3B027C6216344105BF4D15B3AA014207.Count!=0))
{
if(result3B027C6216344105BF4D15B3AA014207.ContainsKey(0))
ISpace["MF_P1_ReceiptNo"].Value = result3B027C6216344105BF4D15B3AA014207[0];
if(result3B027C6216344105BF4D15B3AA014207.ContainsKey(1))
ISpace["FRValues"].Value = result3B027C6216344105BF4D15B3AA014207[1];
}
else{
ISpace["MF_P1_ReceiptNo"].Value = null;ISpace["FRValues"].Value = null;
}
}
if(ISpace["FRValues"].Value=="1")
{
base.WriteDebugInfo(@"if(ISpace[""FRValues""].Value==""1"")");
ISpace["MF_P1_ActualDate"].Enbl="false";ISpace["MF_P1_ActualEndDate"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MF_P1_ActualDate""].Enbl=""false"";ISpace[""MF_P1_ActualEndDate""].Enbl=""false"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_P1_ActualDate"].Enbl="true";ISpace["MF_P1_ActualEndDate"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_P1_ActualDate""].Enbl=""true"";ISpace[""MF_P1_ActualEndDate""].Enbl=""true"";");
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mf_p1_transferreferencedate (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MF_P1_TransferReferenceDate-OnChange");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_P1_TransferReferenceDate"].Value>ISpace["MF_P1_ReceiptDate"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_P1_TransferReferenceDate""].Value>ISpace[""MF_P1_ReceiptDate""].Value)");
ISpace["Message"].Value=@"Transfer Date should be less than or equal to Fund Installment Date or Actual Date";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Transfer Date should be less than or equal to Fund Installment Date or Actual Date"";");
ISpace["MF_P1_TransferReferenceDate"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_P1_TransferReferenceDate""].Value=null;");
return;
base.WriteDebugInfo(@"return;");
}
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
base.WriteDebugInfo(@"EXEC GetMovetoValuesProjectFundInstallment 2,'#C_FC_Category_15','#M_ActivityName'");

var querySource7DA1AAC410794683ACB6836196476D5A =GetQueryExpressionDataSource("7DA1AAC4-1079-4683-ACB6-836196476D5A");
Dictionary<short,object> result7DA1AAC410794683ACB6836196476D5A=iSpace.ExecuteQuery(querySource7DA1AAC410794683ACB6836196476D5A,@"EXECGetMovetoValuesProjectFundInstallment2,'" + ISpace["C_FC_Category_15"].Value + @"','" + ISpace["M_ActivityName"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource7DA1AAC410794683ACB6836196476D5A =GetQueryExpressionDataSource(""7DA1AAC4-1079-4683-ACB6-836196476D5A"");Dictionary<short,object> result7DA1AAC410794683ACB6836196476D5A=iSpace.ExecuteQuery(querySource7DA1AAC410794683ACB6836196476D5A,@""EXECGetMovetoValuesProjectFundInstallment2,'"" + ISpace[""C_FC_Category_15""].Value + @""','"" + ISpace[""M_ActivityName""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result7DA1AAC410794683ACB6836196476D5A!=null) && (result7DA1AAC410794683ACB6836196476D5A.Count!=0))
{
if(result7DA1AAC410794683ACB6836196476D5A.ContainsKey(2))
ISpace["M_NextStage"].Value = result7DA1AAC410794683ACB6836196476D5A[2];
if(result7DA1AAC410794683ACB6836196476D5A.ContainsKey(5))
ISpace["M_Remarks"].Value = result7DA1AAC410794683ACB6836196476D5A[5];
if(result7DA1AAC410794683ACB6836196476D5A.ContainsKey(0))
ISpace["M_DestinationActivityId"].Value = result7DA1AAC410794683ACB6836196476D5A[0];
}
else{
ISpace["M_NextStage"].Value = null;ISpace["M_Remarks"].Value = null;ISpace["M_DestinationActivityId"].Value = null;
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mf_p1_receiptdate (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MF_P1_ReceiptDate-OnChange");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_P1_ReceiptDate"].Value>CurrentDate())
{
base.WriteDebugInfo(@"if(ISpace[""MF_P1_ReceiptDate""].Value>CurrentDate())");
ISpace["Message"].Value=@"Fund Installment Date should be less than the current date.";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Fund Installment Date should be less than the current date."";");
ISpace["MF_P1_ReceiptDate"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_P1_ReceiptDate""].Value=null;");
return;
base.WriteDebugInfo(@"return;");
}
if(ISpace["MF_P1_ReceiptDate"].Value<ISpace["C_FC_StartDate_15"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_P1_ReceiptDate""].Value<ISpace[""C_FC_StartDate_15""].Value)");
ISpace["Message"].Value=@"Fund Installment Date should be greater than or equal to Starting Date or Actual Start Date";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Fund Installment Date should be greater than or equal to Starting Date or Actual Start Date"";");
ISpace["MF_P1_ReceiptDate"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_P1_ReceiptDate""].Value=null;");
return;
base.WriteDebugInfo(@"return;");
}
if(ISpace["MF_P1_ReceiptDate"].Value>=ISpace["C_FC_EndDate"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_P1_ReceiptDate""].Value>=ISpace[""C_FC_EndDate""].Value)");
ISpace["Message"].Value=@"Fund Installment Date should be less than Closing Date  or Actual End Date";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Fund Installment Date should be less than Closing Date  or Actual End Date"";");
ISpace["MF_P1_ReceiptDate"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_P1_ReceiptDate""].Value=null;");
return;
base.WriteDebugInfo(@"return;");
}
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_save_receiptsplitup (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Save_ReceiptSplitUp-OnClick");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(Trim(ISpace["MFG_R2_BudgetId"].Value)=="")
{
base.WriteDebugInfo(@"if(Trim(ISpace[""MFG_R2_BudgetId""].Value)=="""")");
ISpace["Message"].Value=@"Please Enter the Budget Head";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please Enter the Budget Head"";");
return;
base.WriteDebugInfo(@"return;");
}
if(ISpace["MFG_R2_Amount"].Value==0)
{
base.WriteDebugInfo(@"if(ISpace[""MFG_R2_Amount""].Value==0)");
ISpace["Message"].Value=@"Please Enter the Amount";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please Enter the Amount"";");
return;
base.WriteDebugInfo(@"return;");
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["MF_P1_ReceiptAmount"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MF_P1_ReceiptAmount""].Enbl=""false"";");
}
if(1==2)
{
base.WriteDebugInfo(@"if(1==2)");
base.WriteDebugInfo(@"#ReceiptSplitUp[Rows]");
iSpace.GetLoopExpressionData("ReceiptSplitUp",ref ISpace);

foreach(var gridChild in ISpace["ReceiptSplitUp"].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 



ISpace["M_Budgetid"].Value=ISpace["MG_R2_BudgetId"].Value;
base.WriteDebugInfo(@"

ISpace[""M_Budgetid""].Value=ISpace[""MG_R2_BudgetId""].Value;");


ISpace["M_R2_ReceiptSplitUpId"].Value=ISpace["MG_R2_ReceiptSplitUpId"].Value;
base.WriteDebugInfo(@"

ISpace[""M_R2_ReceiptSplitUpId""].Value=ISpace[""MG_R2_ReceiptSplitUpId""].Value;");

if(
ISpace["Editflag"].Value==1)
{
base.WriteDebugInfo(@"
if(
ISpace[""Editflag""].Value==1)");
if(ISpace["M_Budgetid"].Value==ISpace["MFG_R2_BudgetId"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""M_Budgetid""].Value==ISpace[""MFG_R2_BudgetId""].Value)");
ISpace["Message"].Value=@"This Budget head is already added";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""This Budget head is already added"";");
return;
base.WriteDebugInfo(@"return;");
}
}
else
{
base.WriteDebugInfo(@"else");
if(ISpace["M_Budgetid"].Value==ISpace["MFG_R2_BudgetId"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""M_Budgetid""].Value==ISpace[""MFG_R2_BudgetId""].Value)");
ISpace["Message"].Value=@"This Budget head is already added";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""This Budget head is already added"";");
return;
base.WriteDebugInfo(@"return;");
}
}
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("ReceiptSplitUp","249EF445-9B49-4EF9-8045-46BD1E6FF8ED",_objectFactory.GetGridRPP("ReceiptSplitUp"),_elementBase.GetGridLoopQuery("249EF445-9B49-4EF9-8045-46BD1E6FF8ED","ReceiptSplitUp",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""ReceiptSplitUp"",ref ISpace);

foreach(var gridChild in ISpace[""ReceiptSplitUp""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"exec ValidateBudgetHeadAmount '#C_FC_ProjectNo_15','#MFG_R2_BudgetId','#MFG_R2_Amount'");

var querySource526137CD61B5430FB81FF00B94BC6A8E =GetQueryExpressionDataSource("526137CD-61B5-430F-B81F-F00B94BC6A8E");
Dictionary<short,object> result526137CD61B5430FB81FF00B94BC6A8E=iSpace.ExecuteQuery(querySource526137CD61B5430FB81FF00B94BC6A8E,@"exec ValidateBudgetHeadAmount '" + ISpace["C_FC_ProjectNo_15"].Value + @"','" + ISpace["MFG_R2_BudgetId"].Value + @"','" + ISpace["MFG_R2_Amount"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource526137CD61B5430FB81FF00B94BC6A8E =GetQueryExpressionDataSource(""526137CD-61B5-430F-B81F-F00B94BC6A8E"");Dictionary<short,object> result526137CD61B5430FB81FF00B94BC6A8E=iSpace.ExecuteQuery(querySource526137CD61B5430FB81FF00B94BC6A8E,@""exec ValidateBudgetHeadAmount '"" + ISpace[""C_FC_ProjectNo_15""].Value + @""','"" + ISpace[""MFG_R2_BudgetId""].Value + @""','"" + ISpace[""MFG_R2_Amount""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result526137CD61B5430FB81FF00B94BC6A8E!=null) && (result526137CD61B5430FB81FF00B94BC6A8E.Count!=0))
{
if(result526137CD61B5430FB81FF00B94BC6A8E.ContainsKey(0))
ISpace["M_BudgetErr"].Value = result526137CD61B5430FB81FF00B94BC6A8E[0];
if(result526137CD61B5430FB81FF00B94BC6A8E.ContainsKey(1))
ISpace["M_BudgetErrMsg"].Value = result526137CD61B5430FB81FF00B94BC6A8E[1];
}
else{
ISpace["M_BudgetErr"].Value = null;ISpace["M_BudgetErrMsg"].Value = null;
}
if(ISpace["M_BudgetErr"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""M_BudgetErr""].Value==1)");
ISpace["Message"].Value=String.Format(@"{0}",ISpace["M_BudgetErrMsg"].Value);
base.WriteDebugInfo(@"ISpace[""Message""].Value=String.Format(@""{0}"",ISpace[""M_BudgetErrMsg""].Value);");
return;
base.WriteDebugInfo(@"return;");
}
}
if(1==2)
{
base.WriteDebugInfo(@"if(1==2)");
if(ISpace["MFG_R2_Amount"].Value>ISpace["R_ReceiptAmountBalance"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MFG_R2_Amount""].Value>ISpace[""R_ReceiptAmountBalance""].Value)");
ISpace["Message"].Value=@"Splitup Amount Should be less than or equal to Fund Installment Amount";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Splitup Amount Should be less than or equal to Fund Installment Amount"";");
ISpace["MFG_R2_Amount"].Value=null;
base.WriteDebugInfo(@"ISpace[""MFG_R2_Amount""].Value=null;");
return;
base.WriteDebugInfo(@"return;");
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"#ReceiptSplitUp[rows]");
iSpace.GetLoopExpressionData("ReceiptSplitUp",ref ISpace);

foreach(var gridChild in ISpace["ReceiptSplitUp"].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 


if(


ISpace["growid"].Value!=ISpace["ReceiptSplitUp_RowId"].Value||ISpace["growid"].Value=="")
{
base.WriteDebugInfo(@"
if(


ISpace[""growid""].Value!=ISpace[""ReceiptSplitUp_RowId""].Value||ISpace[""growid""].Value=="""")");
if(ISpace["MFG_R2_BudgetId"].Value==ISpace["MG_R2_BudgetId"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MFG_R2_BudgetId""].Value==ISpace[""MG_R2_BudgetId""].Value)");
ISpace["Message"].Value=@"Budget Head is already Exists";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Budget Head is already Exists"";");
ISpace["MFG_R2_BudgetId"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_R2_BudgetId""].Value="""";");
return;
base.WriteDebugInfo(@"return;");
}
}
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("ReceiptSplitUp","249EF445-9B49-4EF9-8045-46BD1E6FF8ED",_objectFactory.GetGridRPP("ReceiptSplitUp"),_elementBase.GetGridLoopQuery("249EF445-9B49-4EF9-8045-46BD1E6FF8ED","ReceiptSplitUp",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""ReceiptSplitUp"",ref ISpace);

foreach(var gridChild in ISpace[""ReceiptSplitUp""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
}
if(ISpace["MFG_R2_ReceiptSplitUpId"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""MFG_R2_ReceiptSplitUpId""].Value=="""")");
ISpace["MFG_R2_ReceiptSplitUpId"].Value=Guid.NewGuid().ToString();
base.WriteDebugInfo(@"ISpace[""MFG_R2_ReceiptSplitUpId""].Value=Guid.NewGuid().ToString();");
}
if(ISpace["growid"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""growid""].Value=="""")");

var querySource490A453A68524615B83B173BC38F190B =GetQueryExpressionDataSource("490A453A-6852-4615-B83B-173BC38F190B");

DataTable result490A453A68524615B83B173BC38F190B=iSpace.SetGridDataSource(querySource490A453A68524615B83B173BC38F190B, _objectFactory.GetGridRPP("ReceiptSplitUp"),@"EXEC AddFormGridDatacc29fcb5b804498f8b8407ad780fb5af '" + ISpace["Instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','cc29fcb5-b804-498f-8b84-07ad780fb5af','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["MFG_R2_ReceiptSplitUpId"].Value + @"','" + ISpace["MFG_R2_ReceiptsId"].Value + @"','" + ISpace["MFG_R2_BudgetId"].Value + @"'," + ISpace["MFG_R2_Amount"].Value + @"," + ISpace["gv_userid"].Value + @",'" + ISpace["MFG_R2_UpdatedOn"].Value + @"','" + ISpace["growid"].Value + @"'");

iSpace.InsertGridBindDetails("ReceiptSplitUp","11",querySource490A453A68524615B83B173BC38F190B,"EXEC AddFormGridDatacc29fcb5b804498f8b8407ad780fb5af '" + ISpace["Instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','cc29fcb5-b804-498f-8b84-07ad780fb5af','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["MFG_R2_ReceiptSplitUpId"].Value + @"','" + ISpace["MFG_R2_ReceiptsId"].Value + @"','" + ISpace["MFG_R2_BudgetId"].Value + @"'," + ISpace["MFG_R2_Amount"].Value + @"," + ISpace["gv_userid"].Value + @",'" + ISpace["MFG_R2_UpdatedOn"].Value + @"','" + ISpace["growid"].Value + @"'",_objectFactory.GetGridRPP("ReceiptSplitUp"));

base.WriteDebugInfo(@"var querySource490A453A68524615B83B173BC38F190B =GetQueryExpressionDataSource(""490A453A-6852-4615-B83B-173BC38F190B"");DataTable result490A453A68524615B83B173BC38F190B=iSpace.SetGridDataSource(querySource490A453A68524615B83B173BC38F190B, _objectFactory.GetGridRPP(""ReceiptSplitUp""),@""EXEC AddFormGridDatacc29fcb5b804498f8b8407ad780fb5af '"" + ISpace[""Instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','cc29fcb5-b804-498f-8b84-07ad780fb5af','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""MFG_R2_ReceiptSplitUpId""].Value + @""','"" + ISpace[""MFG_R2_ReceiptsId""].Value + @""','"" + ISpace[""MFG_R2_BudgetId""].Value + @""',"" + ISpace[""MFG_R2_Amount""].Value + @"","" + ISpace[""gv_userid""].Value + @"",'"" + ISpace[""MFG_R2_UpdatedOn""].Value + @""','"" + ISpace[""growid""].Value + @""'"");iSpace.InsertGridBindDetails(""ReceiptSplitUp"",""11"",querySource490A453A68524615B83B173BC38F190B,""EXEC AddFormGridDatacc29fcb5b804498f8b8407ad780fb5af '"" + ISpace[""Instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','cc29fcb5-b804-498f-8b84-07ad780fb5af','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""MFG_R2_ReceiptSplitUpId""].Value + @""','"" + ISpace[""MFG_R2_ReceiptsId""].Value + @""','"" + ISpace[""MFG_R2_BudgetId""].Value + @""',"" + ISpace[""MFG_R2_Amount""].Value + @"","" + ISpace[""gv_userid""].Value + @"",'"" + ISpace[""MFG_R2_UpdatedOn""].Value + @""','"" + ISpace[""growid""].Value + @""'"",_objectFactory.GetGridRPP(""ReceiptSplitUp""));");
base.WriteDebugInfo(@"EXEC AddFormGridDatacc29fcb5b804498f8b8407ad780fb5af '@@gv_InstanceId','@@gv_ProcessMapId','cc29fcb5-b804-498f-8b84-07ad780fb5af','@@gv_ActivityMapId','#MFG_R2_ReceiptSplitUpId','#MFG_R2_ReceiptsId',#MFG_R2_BudgetId,#MFG_R2_Amount,#MFG_R2_UpdatedBy,#MFG_R2_UpdatedOn,'#growid'");


List<Triplet<string, short, short?>> result68E47F7523D14580ABFCB23D3E6D49FF=acdataIspaceDDBF52926EF44C37B72AE6DCFFBF7B02.GetQueryExpressionBindings("68E47F75-23D1-4580-ABFC-B23D3E6D49FF");
iSpace.SetGridData(result490A453A68524615B83B173BC38F190B,result68E47F7523D14580ABFCB23D3E6D49FF,"ReceiptSplitUp",ref ISpace);
iSpace.UpdateGridBindDetails("ReceiptSplitUp",result68E47F7523D14580ABFCB23D3E6D49FF);
}
else
{
base.WriteDebugInfo(@"else");

var querySourceC102915BAF5144F9A85E2C1A53654BCF =GetQueryExpressionDataSource("C102915B-AF51-44F9-A85E-2C1A53654BCF");

DataTable resultC102915BAF5144F9A85E2C1A53654BCF=iSpace.SetGridDataSource(querySourceC102915BAF5144F9A85E2C1A53654BCF, _objectFactory.GetGridRPP("ReceiptSplitUp"),@"EXEC UpdateFormGridDatacc29fcb5b804498f8b8407ad780fb5af '" + ISpace["Instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','cc29fcb5-b804-498f-8b84-07ad780fb5af','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["MFG_R2_ReceiptSplitUpId"].Value + @"','" + ISpace["MFG_R2_ReceiptsId"].Value + @"','" + ISpace["MFG_R2_BudgetId"].Value + @"'," + ISpace["MFG_R2_Amount"].Value + @"," + ISpace["MFG_R2_UpdatedBy"].Value + @",'" + ISpace["MFG_R2_UpdatedOn"].Value + @"','" + ISpace["growid"].Value + @"'");

iSpace.InsertGridBindDetails("ReceiptSplitUp","11",querySourceC102915BAF5144F9A85E2C1A53654BCF,"EXEC UpdateFormGridDatacc29fcb5b804498f8b8407ad780fb5af '" + ISpace["Instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','cc29fcb5-b804-498f-8b84-07ad780fb5af','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["MFG_R2_ReceiptSplitUpId"].Value + @"','" + ISpace["MFG_R2_ReceiptsId"].Value + @"','" + ISpace["MFG_R2_BudgetId"].Value + @"'," + ISpace["MFG_R2_Amount"].Value + @"," + ISpace["MFG_R2_UpdatedBy"].Value + @",'" + ISpace["MFG_R2_UpdatedOn"].Value + @"','" + ISpace["growid"].Value + @"'",_objectFactory.GetGridRPP("ReceiptSplitUp"));

base.WriteDebugInfo(@"var querySourceC102915BAF5144F9A85E2C1A53654BCF =GetQueryExpressionDataSource(""C102915B-AF51-44F9-A85E-2C1A53654BCF"");DataTable resultC102915BAF5144F9A85E2C1A53654BCF=iSpace.SetGridDataSource(querySourceC102915BAF5144F9A85E2C1A53654BCF, _objectFactory.GetGridRPP(""ReceiptSplitUp""),@""EXEC UpdateFormGridDatacc29fcb5b804498f8b8407ad780fb5af '"" + ISpace[""Instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','cc29fcb5-b804-498f-8b84-07ad780fb5af','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""MFG_R2_ReceiptSplitUpId""].Value + @""','"" + ISpace[""MFG_R2_ReceiptsId""].Value + @""','"" + ISpace[""MFG_R2_BudgetId""].Value + @""',"" + ISpace[""MFG_R2_Amount""].Value + @"","" + ISpace[""MFG_R2_UpdatedBy""].Value + @"",'"" + ISpace[""MFG_R2_UpdatedOn""].Value + @""','"" + ISpace[""growid""].Value + @""'"");iSpace.InsertGridBindDetails(""ReceiptSplitUp"",""11"",querySourceC102915BAF5144F9A85E2C1A53654BCF,""EXEC UpdateFormGridDatacc29fcb5b804498f8b8407ad780fb5af '"" + ISpace[""Instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','cc29fcb5-b804-498f-8b84-07ad780fb5af','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""MFG_R2_ReceiptSplitUpId""].Value + @""','"" + ISpace[""MFG_R2_ReceiptsId""].Value + @""','"" + ISpace[""MFG_R2_BudgetId""].Value + @""',"" + ISpace[""MFG_R2_Amount""].Value + @"","" + ISpace[""MFG_R2_UpdatedBy""].Value + @"",'"" + ISpace[""MFG_R2_UpdatedOn""].Value + @""','"" + ISpace[""growid""].Value + @""'"",_objectFactory.GetGridRPP(""ReceiptSplitUp""));");
base.WriteDebugInfo(@"EXEC UpdateFormGridDatacc29fcb5b804498f8b8407ad780fb5af '@@gv_InstanceId','@@gv_ProcessMapId','cc29fcb5-b804-498f-8b84-07ad780fb5af','@@gv_ActivityMapId','#MFG_R2_ReceiptSplitUpId','#MFG_R2_ReceiptsId',#MFG_R2_BudgetId,#MFG_R2_Amount,#MFG_R2_UpdatedBy,#MFG_R2_UpdatedOn,'#growid'");


List<Triplet<string, short, short?>> resultCA26392720D64C629E9F015B3ED8015D=acdataIspaceDDBF52926EF44C37B72AE6DCFFBF7B02.GetQueryExpressionBindings("CA263927-20D6-4C62-9E9F-015B3ED8015D");
iSpace.SetGridData(resultC102915BAF5144F9A85E2C1A53654BCF,resultCA26392720D64C629E9F015B3ED8015D,"ReceiptSplitUp",ref ISpace);
iSpace.UpdateGridBindDetails("ReceiptSplitUp",resultCA26392720D64C629E9F015B3ED8015D);
}
object MG_R2_Amount=iSpace.Sum("[249EF445-9B49-4EF9-8045-46BD1E6FF8ED]","MG_R2_Amount","");
ISpace["R_TotalSplitUpAmount"].Value=Convert.ChangeType(MG_R2_Amount, MG_R2_Amount.GetType());;
base.WriteDebugInfo(@"object MG_R2_Amount=iSpace.Sum(""[249EF445-9B49-4EF9-8045-46BD1E6FF8ED]"",""MG_R2_Amount"","""");
ISpace[""R_TotalSplitUpAmount""].Value=Convert.ChangeType(MG_R2_Amount, MG_R2_Amount.GetType());;");
ISpace["growid"].Value="";
base.WriteDebugInfo(@"ISpace[""growid""].Value="""";");
ISpace["MFG_R2_ReceiptSplitUpId"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_R2_ReceiptSplitUpId""].Value="""";");
ISpace["MFG_R2_ReceiptsId"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_R2_ReceiptsId""].Value="""";");
ISpace["MFG_R2_BudgetId"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_R2_BudgetId""].Value="""";");
ISpace["MFG_R2_Amount"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_R2_Amount""].Value="""";");
ISpace["MFG_R2_UpdatedBy"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_R2_UpdatedBy""].Value="""";");
ISpace["MFG_R2_UpdatedOn"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_R2_UpdatedOn""].Value="""";");
ISpace["Editflag"].Value=null;
base.WriteDebugInfo(@"ISpace[""Editflag""].Value=null;");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["R_ReceiptAmountBalance"].Value=ISpace["MF_P1_ReceiptAmount"].Value - ISpace["R_TotalSplitUpAmount"].Value;
base.WriteDebugInfo(@"ISpace[""R_ReceiptAmountBalance""].Value=ISpace[""MF_P1_ReceiptAmount""].Value - ISpace[""R_TotalSplitUpAmount""].Value;");
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_delete (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Delete-OnClick");
ISpace["growid"].Value=ISpace["ReceiptSplitUp_RowId"].Value;
base.WriteDebugInfo(@"ISpace[""growid""].Value=ISpace[""ReceiptSplitUp_RowId""].Value;");
ISpace["UI_DeleteDialog"].ShowDialog=true;;
base.WriteDebugInfo(@"ISpace[""UI_DeleteDialog""].ShowDialog=true;;");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_edit_receiptsplitup (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Edit_ReceiptSplitUp-OnClick");
ISpace["growid"].Value=ISpace["ReceiptSplitUp_RowId"].Value;
base.WriteDebugInfo(@"ISpace[""growid""].Value=ISpace[""ReceiptSplitUp_RowId""].Value;");
ISpace["Editflag"].Value=null;
base.WriteDebugInfo(@"ISpace[""Editflag""].Value=null;");
ISpace["Editflag"].Value=1;
base.WriteDebugInfo(@"ISpace[""Editflag""].Value=1;");
if(ISpace["growid"].Value!=ISpace["MFG_R2_ReceiptSplitUpId"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""growid""].Value!=ISpace[""MFG_R2_ReceiptSplitUpId""].Value)");
ISpace["R_TotalSplitUpAmount"].Value=ISpace["R_TotalSplitUpAmount"].Value-ISpace["MG_R2_Amount"].Value;
base.WriteDebugInfo(@"ISpace[""R_TotalSplitUpAmount""].Value=ISpace[""R_TotalSplitUpAmount""].Value-ISpace[""MG_R2_Amount""].Value;");
ISpace["R_ReceiptAmountBalance"].Value=ISpace["R_ReceiptAmountBalance"].Value+ISpace["MG_R2_Amount"].Value;
base.WriteDebugInfo(@"ISpace[""R_ReceiptAmountBalance""].Value=ISpace[""R_ReceiptAmountBalance""].Value+ISpace[""MG_R2_Amount""].Value;");
}
base.WriteDebugInfo(@"EXEC LoadFormGridDatacc29fcb5b804498f8b8407ad780fb5af '#Instanceid','@@gv_ProcessMapId','cc29fcb5-b804-498f-8b84-07ad780fb5af','@@gv_ActivityMapId','#growid'");

var querySourceA5DC182250F5461FAA7F4043FAB5724D =GetQueryExpressionDataSource("A5DC1822-50F5-461F-AA7F-4043FAB5724D");
Dictionary<short,object> resultA5DC182250F5461FAA7F4043FAB5724D=iSpace.ExecuteQuery(querySourceA5DC182250F5461FAA7F4043FAB5724D,@"EXEC LoadFormGridDatacc29fcb5b804498f8b8407ad780fb5af '" + ISpace["Instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','cc29fcb5-b804-498f-8b84-07ad780fb5af','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["growid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceA5DC182250F5461FAA7F4043FAB5724D =GetQueryExpressionDataSource(""A5DC1822-50F5-461F-AA7F-4043FAB5724D"");Dictionary<short,object> resultA5DC182250F5461FAA7F4043FAB5724D=iSpace.ExecuteQuery(querySourceA5DC182250F5461FAA7F4043FAB5724D,@""EXEC LoadFormGridDatacc29fcb5b804498f8b8407ad780fb5af '"" + ISpace[""Instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','cc29fcb5-b804-498f-8b84-07ad780fb5af','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""growid""].Value + @""'"",false);");
base.WriteDebugInfo(@"EXEC LoadFormGridDatacc29fcb5b804498f8b8407ad780fb5af '@@gv_InstanceId','@@gv_ProcessMapId','cc29fcb5-b804-498f-8b84-07ad780fb5af','@@gv_ActivityMapId','#growid'");

if((resultA5DC182250F5461FAA7F4043FAB5724D!=null) && (resultA5DC182250F5461FAA7F4043FAB5724D.Count!=0))
{
if(resultA5DC182250F5461FAA7F4043FAB5724D.ContainsKey(5))
ISpace["MFG_R2_UpdatedOn"].Value = resultA5DC182250F5461FAA7F4043FAB5724D[5];
if(resultA5DC182250F5461FAA7F4043FAB5724D.ContainsKey(2))
ISpace["MFG_R2_BudgetId"].Value = resultA5DC182250F5461FAA7F4043FAB5724D[2];
if(resultA5DC182250F5461FAA7F4043FAB5724D.ContainsKey(4))
ISpace["MFG_R2_UpdatedBy"].Value = resultA5DC182250F5461FAA7F4043FAB5724D[4];
if(resultA5DC182250F5461FAA7F4043FAB5724D.ContainsKey(3))
ISpace["MFG_R2_Amount"].Value = resultA5DC182250F5461FAA7F4043FAB5724D[3];
if(resultA5DC182250F5461FAA7F4043FAB5724D.ContainsKey(1))
ISpace["MFG_R2_ReceiptsId"].Value = resultA5DC182250F5461FAA7F4043FAB5724D[1];
if(resultA5DC182250F5461FAA7F4043FAB5724D.ContainsKey(6))
ISpace["MFG_R2_ReceiptSplitUpId"].Value = resultA5DC182250F5461FAA7F4043FAB5724D[6];
}
else{
ISpace["MFG_R2_UpdatedOn"].Value = null;ISpace["MFG_R2_BudgetId"].Value = null;ISpace["MFG_R2_UpdatedBy"].Value = null;ISpace["MFG_R2_Amount"].Value = null;ISpace["MFG_R2_ReceiptsId"].Value = null;ISpace["MFG_R2_ReceiptSplitUpId"].Value = null;
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_add (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Add-OnClick");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

if(ISpace["FormVersionId"].Value=="B1CB93DB-7B9C-4661-BE11-02ED3BFD5725")
{
iSpace.SetUIControlProperty("UI_AvailablebudgetModal","ShowModal","true",ref  ISpace);;
}

base.WriteDebugInfo(@"
if(ISpace[""FormVersionId""].Value==""B1CB93DB-7B9C-4661-BE11-02ED3BFD5725"")
{
iSpace.SetUIControlProperty(""UI_AvailablebudgetModal"",""ShowModal"",""true"",ref  ISpace);;
}
");
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
		if(elementName.ToLower().Equals("mg_r2_amount"))
    {
    			SubscribeElementEvents_mg_r2_amount(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mf_p1_actualdate"))
    {
    			SubscribeElementEvents_mf_p1_actualdate(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mf_p1_receiptamount"))
    {
    			SubscribeElementEvents_mf_p1_receiptamount(ref dfsParam);
    }
		if(elementName.ToLower().Equals("c_fc_projectno_15"))
    {
    			SubscribeElementEvents_c_fc_projectno_15(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mf_p1_transferreferencedate"))
    {
    			SubscribeElementEvents_mf_p1_transferreferencedate(ref dfsParam);
    }
		if(elementName.ToLower().Equals("m_moveto"))
    {
    			SubscribeElementEvents_m_moveto(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mf_p1_receiptdate"))
    {
    			SubscribeElementEvents_mf_p1_receiptdate(ref dfsParam);
    }
}
	if(methodName.ToLower().Equals("onclick"))
{
		if(elementName.ToLower().Equals("submitform"))
{
			SubscribeElementEvents_submitform(ref dfsParam);
}
		if(elementName.ToLower().Equals("availablebudgetclose"))
{
			SubscribeElementEvents_availablebudgetclose(ref dfsParam);
}
		if(elementName.ToLower().Equals("save_receiptsplitup"))
{
			SubscribeElementEvents_save_receiptsplitup(ref dfsParam);
}
		if(elementName.ToLower().Equals("delete"))
{
			SubscribeElementEvents_delete(ref dfsParam);
}
		if(elementName.ToLower().Equals("edit_receiptsplitup"))
{
			SubscribeElementEvents_edit_receiptsplitup(ref dfsParam);
}
		if(elementName.ToLower().Equals("add"))
{
			SubscribeElementEvents_add(ref dfsParam);
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
public class ISpaceFF2ED87620AB4F5DB62B385405DFB900 : VirtualForm
{
IISpace iSpace = new ISpace();
AcDataISpaceFF2ED87620AB4F5DB62B385405DFB900 acdataIspaceFF2ED87620AB4F5DB62B385405DFB900=new AcDataISpaceFF2ED87620AB4F5DB62B385405DFB900();
private void SubscribeFormEvents_root(ref Dictionary<string, ServiceElementData> ISpace)
{
try
{
base.WriteDebugInfo(@"Root-OnAfterFormLoad");
if(ISpace["FormVersionId"].Value=="B1CB93DB-7B9C-4661-BE11-02ED3BFD5725")
{
ISpace["UI_BudgetPanelBody"].Visible="false";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""B1CB93DB-7B9C-4661-BE11-02ED3BFD5725"")
{
ISpace[""UI_BudgetPanelBody""].Visible=""false"";
}");
ISpace["Delete"].Visible="false";ISpace["Edit_ReceiptSplitUp"].Visible="false";
base.WriteDebugInfo(@"ISpace[""Delete""].Visible=""false"";ISpace[""Edit_ReceiptSplitUp""].Visible=""false"";");
if((ISpace["MF_P1_ActualDate"].Value == null))
{
base.WriteDebugInfo(@"if((ISpace[""MF_P1_ActualDate""].Value == null))");
ISpace["MF_P1_ActualEndDate"].Visible="false";
base.WriteDebugInfo(@"ISpace[""MF_P1_ActualEndDate""].Visible=""false"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_P1_ActualEndDate"].Visible="true";
base.WriteDebugInfo(@"ISpace[""MF_P1_ActualEndDate""].Visible=""true"";");
}
ISpace["M_SourceActivityMapId"].Value=ISpace["gv_activitymapid"].Value;
base.WriteDebugInfo(@"ISpace[""M_SourceActivityMapId""].Value=ISpace[""gv_activitymapid""].Value;");
ISpace["M_PackageProcessMapId"].Value=ISpace["gv_processmapid"].Value;
base.WriteDebugInfo(@"ISpace[""M_PackageProcessMapId""].Value=ISpace[""gv_processmapid""].Value;");
ISpace["M_InstanceId"].Value=ISpace["gv_instanceid"].Value;
base.WriteDebugInfo(@"ISpace[""M_InstanceId""].Value=ISpace[""gv_instanceid""].Value;");
ISpace["M_IsSourceStep"].Value=0;
base.WriteDebugInfo(@"ISpace[""M_IsSourceStep""].Value=0;");
ISpace["M_ActivityName"].Value=ISpace["gv_activityname"].Value;
base.WriteDebugInfo(@"ISpace[""M_ActivityName""].Value=ISpace[""gv_activityname""].Value;");
ISpace["M_MoveTo"].Man=true;
base.WriteDebugInfo(@"ISpace[""M_MoveTo""].Man=true;");
ISpace["M_Remarks"].Value="";
base.WriteDebugInfo(@"ISpace[""M_Remarks""].Value="""";");
ISpace["M_NextStage"].Value="";
base.WriteDebugInfo(@"ISpace[""M_NextStage""].Value="""";");
ISpace["UC_PhoneNumber"].Visible="false";ISpace["UC_DOB"].Visible="false";ISpace["UC_DOR"].Visible="false";ISpace["UC_Paylevel"].Visible="false";ISpace["UC_EmailId"].Visible="false";ISpace["UC_Grade"].Visible="false";ISpace["UC_DOJ"].Visible="false";
base.WriteDebugInfo(@"ISpace[""UC_PhoneNumber""].Visible=""false"";ISpace[""UC_DOB""].Visible=""false"";ISpace[""UC_DOR""].Visible=""false"";ISpace[""UC_Paylevel""].Visible=""false"";ISpace[""UC_EmailId""].Visible=""false"";ISpace[""UC_Grade""].Visible=""false"";ISpace[""UC_DOJ""].Visible=""false"";");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["MFG_R2_ReceiptSplitUpId"].Visible="false";ISpace["MF_P1_TransferReferenceBankId"].Visible="true";ISpace["MF_P1_TransferReferenceBranch"].Visible="true";ISpace["MF_P1_ReceiptAmount"].Visible="true";ISpace["MF_P1_TransferType"].Visible="true";ISpace["MF_P1_TransferReferenceNumber"].Visible="true";ISpace["MF_P1_Status"].Visible="false";ISpace["MF_P1_ReceiptNo"].Visible="true";ISpace["MF_P1_ProjectDetailsId"].Visible="true";ISpace["MF_P1_UpdatedOn"].Visible="false";ISpace["MF_P1_TransferReferenceDate"].Visible="true";ISpace["MFG_R2_UpdatedBy"].Visible="false";ISpace["MF_P1_ReceiptsId"].Visible="true";ISpace["MF_P1_ReceiptDate"].Visible="true";ISpace["MF_P1_UpdatedBy"].Visible="false";ISpace["MFG_R2_Amount"].Visible="true";ISpace["MFG_R2_UpdatedOn"].Visible="false";ISpace["MFG_R2_ReceiptsId"].Visible="false";ISpace["MFG_R2_BudgetId"].Visible="true";
base.WriteDebugInfo(@"ISpace[""MFG_R2_ReceiptSplitUpId""].Visible=""false"";ISpace[""MF_P1_TransferReferenceBankId""].Visible=""true"";ISpace[""MF_P1_TransferReferenceBranch""].Visible=""true"";ISpace[""MF_P1_ReceiptAmount""].Visible=""true"";ISpace[""MF_P1_TransferType""].Visible=""true"";ISpace[""MF_P1_TransferReferenceNumber""].Visible=""true"";ISpace[""MF_P1_Status""].Visible=""false"";ISpace[""MF_P1_ReceiptNo""].Visible=""true"";ISpace[""MF_P1_ProjectDetailsId""].Visible=""true"";ISpace[""MF_P1_UpdatedOn""].Visible=""false"";ISpace[""MF_P1_TransferReferenceDate""].Visible=""true"";ISpace[""MFG_R2_UpdatedBy""].Visible=""false"";ISpace[""MF_P1_ReceiptsId""].Visible=""true"";ISpace[""MF_P1_ReceiptDate""].Visible=""true"";ISpace[""MF_P1_UpdatedBy""].Visible=""false"";ISpace[""MFG_R2_Amount""].Visible=""true"";ISpace[""MFG_R2_UpdatedOn""].Visible=""false"";ISpace[""MFG_R2_ReceiptsId""].Visible=""false"";ISpace[""MFG_R2_BudgetId""].Visible=""true"";");
ISpace["MG_R2_ReceiptsId"].Visible="false";ISpace["MG_R2_BudgetId"].Visible="true";ISpace["MG_R2_Amount"].Visible="true";ISpace["MG_R2_UpdatedBy"].Visible="false";ISpace["MG_R2_UpdatedOn"].Visible="false";ISpace["MG_R2_ReceiptSplitUpId"].Visible="false";
base.WriteDebugInfo(@"ISpace[""MG_R2_ReceiptsId""].Visible=""false"";ISpace[""MG_R2_BudgetId""].Visible=""true"";ISpace[""MG_R2_Amount""].Visible=""true"";ISpace[""MG_R2_UpdatedBy""].Visible=""false"";ISpace[""MG_R2_UpdatedOn""].Visible=""false"";ISpace[""MG_R2_ReceiptSplitUpId""].Visible=""false"";");
}

var querySourceB8A2A58C91CA4FD4B3269652593DD27B =GetQueryExpressionDataSource("B8A2A58C-91CA-4FD4-B326-9652593DD27B");

DataTable resultB8A2A58C91CA4FD4B3269652593DD27B=iSpace.SetGridDataSource(querySourceB8A2A58C91CA4FD4B3269652593DD27B, _objectFactory.GetGridRPP("MG_RemarksDetails"),@"EXEC GetRemarks '" + ISpace["Instanceid"].Value + @"'");

iSpace.InsertGridBindDetails("MG_RemarksDetails","11",querySourceB8A2A58C91CA4FD4B3269652593DD27B,"EXEC GetRemarks '" + ISpace["Instanceid"].Value + @"'",_objectFactory.GetGridRPP("MG_RemarksDetails"));

base.WriteDebugInfo(@"var querySourceB8A2A58C91CA4FD4B3269652593DD27B =GetQueryExpressionDataSource(""B8A2A58C-91CA-4FD4-B326-9652593DD27B"");DataTable resultB8A2A58C91CA4FD4B3269652593DD27B=iSpace.SetGridDataSource(querySourceB8A2A58C91CA4FD4B3269652593DD27B, _objectFactory.GetGridRPP(""MG_RemarksDetails""),@""EXEC GetRemarks '"" + ISpace[""Instanceid""].Value + @""'"");iSpace.InsertGridBindDetails(""MG_RemarksDetails"",""11"",querySourceB8A2A58C91CA4FD4B3269652593DD27B,""EXEC GetRemarks '"" + ISpace[""Instanceid""].Value + @""'"",_objectFactory.GetGridRPP(""MG_RemarksDetails""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result4ACD680C9EAE4FDBA4A3FC5C4D353701=acdataIspaceFF2ED87620AB4F5DB62B385405DFB900.GetQueryExpressionBindings("4ACD680C-9EAE-4FDB-A4A3-FC5C4D353701");
iSpace.SetGridData(resultB8A2A58C91CA4FD4B3269652593DD27B,result4ACD680C9EAE4FDBA4A3FC5C4D353701,"MG_RemarksDetails",ref ISpace);
iSpace.UpdateGridBindDetails("MG_RemarksDetails",result4ACD680C9EAE4FDBA4A3FC5C4D353701);
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
ISpace["Message"].Value=@"Please select the value for Move To";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please select the value for Move To"";");
return;
base.WriteDebugInfo(@"return;");
}
base.WriteDebugInfo(@"#ReceiptSplitUp[Rows]");
iSpace.GetLoopExpressionData("ReceiptSplitUp",ref ISpace);

foreach(var gridChild in ISpace["ReceiptSplitUp"].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 



ISpace["M_Amount"].Value=ISpace["MG_R2_Amount"].Value;
base.WriteDebugInfo(@"

ISpace[""M_Amount""].Value=ISpace[""MG_R2_Amount""].Value;");


ISpace["M_Budgetid"].Value=ISpace["MG_R2_BudgetId"].Value;
base.WriteDebugInfo(@"

ISpace[""M_Budgetid""].Value=ISpace[""MG_R2_BudgetId""].Value;");
base.WriteDebugInfo(@"exec ValidateBudgetHeadAmount '#C_FC_ProjectNo_15','#M_Budgetid','#M_Amount'");

var querySourceF81332044D2545DD90C1B4DD31CFF7F4 =GetQueryExpressionDataSource("F8133204-4D25-45DD-90C1-B4DD31CFF7F4");
Dictionary<short,object> resultF81332044D2545DD90C1B4DD31CFF7F4=iSpace.ExecuteQuery(querySourceF81332044D2545DD90C1B4DD31CFF7F4,@"exec ValidateBudgetHeadAmount '" + ISpace["C_FC_ProjectNo_15"].Value + @"','" + ISpace["M_Budgetid"].Value + @"','" + ISpace["M_Amount"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceF81332044D2545DD90C1B4DD31CFF7F4 =GetQueryExpressionDataSource(""F8133204-4D25-45DD-90C1-B4DD31CFF7F4"");Dictionary<short,object> resultF81332044D2545DD90C1B4DD31CFF7F4=iSpace.ExecuteQuery(querySourceF81332044D2545DD90C1B4DD31CFF7F4,@""exec ValidateBudgetHeadAmount '"" + ISpace[""C_FC_ProjectNo_15""].Value + @""','"" + ISpace[""M_Budgetid""].Value + @""','"" + ISpace[""M_Amount""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultF81332044D2545DD90C1B4DD31CFF7F4!=null) && (resultF81332044D2545DD90C1B4DD31CFF7F4.Count!=0))
{
if(resultF81332044D2545DD90C1B4DD31CFF7F4.ContainsKey(0))
ISpace["M_BudgetErr"].Value = resultF81332044D2545DD90C1B4DD31CFF7F4[0];
if(resultF81332044D2545DD90C1B4DD31CFF7F4.ContainsKey(1))
ISpace["M_BudgetErrMsg"].Value = resultF81332044D2545DD90C1B4DD31CFF7F4[1];
}
else{
ISpace["M_BudgetErr"].Value = null;ISpace["M_BudgetErrMsg"].Value = null;
}

if(
ISpace["M_BudgetErr"].Value==1)
{
base.WriteDebugInfo(@"
if(
ISpace[""M_BudgetErr""].Value==1)");
ISpace["Message"].Value=String.Format(@"{0}",ISpace["M_BudgetErrMsg"].Value);
base.WriteDebugInfo(@"ISpace[""Message""].Value=String.Format(@""{0}"",ISpace[""M_BudgetErrMsg""].Value);");
return;
base.WriteDebugInfo(@"return;");
}
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("ReceiptSplitUp","249EF445-9B49-4EF9-8045-46BD1E6FF8ED",_objectFactory.GetGridRPP("ReceiptSplitUp"),_elementBase.GetGridLoopQuery("249EF445-9B49-4EF9-8045-46BD1E6FF8ED","ReceiptSplitUp",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""ReceiptSplitUp"",ref ISpace);

foreach(var gridChild in ISpace[""ReceiptSplitUp""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
if(ISpace["M_SaveDomainData"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""M_SaveDomainData""].Value==1)");
ISpace["MF_P1_Status"].Value="A";
base.WriteDebugInfo(@"ISpace[""MF_P1_Status""].Value=""A"";");
base.WriteDebugInfo(@"EXEC UpsertProjectReceipts '#MF_P1_ReceiptsId','#MF_P1_TransferReferenceBankId','#MF_P1_ReceiptDate','#MF_P1_ReceiptNo','#UC_EmployeeBaicInfoId','#MF_P1_Status','#MF_P1_TransferReferenceDate','#MF_P1_TransferReferenceBranch','#MF_P1_UpdatedBy','#MF_P1_TransferType','#C_FC_ProjectNo_15'");

var querySource8ededcfe5adacbe6902976086059adc4 =GetQueryExpressionDataSource("8ededcfe-5ada-cbe6-9029-76086059adc4");
Dictionary<short,object> result8ededcfe5adacbe6902976086059adc4=iSpace.ExecuteQuery(querySource8ededcfe5adacbe6902976086059adc4,@"EXEC UpsertProjectReceipts '" + ISpace["MF_P1_ReceiptsId"].Value + @"','" + ISpace["MF_P1_TransferReferenceBankId"].Value + @"','" + ISpace["MF_P1_ReceiptDate"].Value + @"','" + ISpace["MF_P1_ReceiptNo"].Value + @"','" + ISpace["UC_EmployeeBaicInfoId"].Value + @"','" + ISpace["MF_P1_Status"].Value + @"','" + ISpace["MF_P1_TransferReferenceDate"].Value + @"','" + ISpace["MF_P1_TransferReferenceBranch"].Value + @"','" + ISpace["MF_P1_UpdatedBy"].Value + @"','" + ISpace["MF_P1_TransferType"].Value + @"','" + ISpace["C_FC_ProjectNo_15"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource8ededcfe5adacbe6902976086059adc4 =GetQueryExpressionDataSource(""8ededcfe-5ada-cbe6-9029-76086059adc4"");Dictionary<short,object> result8ededcfe5adacbe6902976086059adc4=iSpace.ExecuteQuery(querySource8ededcfe5adacbe6902976086059adc4,@""EXEC UpsertProjectReceipts '"" + ISpace[""MF_P1_ReceiptsId""].Value + @""','"" + ISpace[""MF_P1_TransferReferenceBankId""].Value + @""','"" + ISpace[""MF_P1_ReceiptDate""].Value + @""','"" + ISpace[""MF_P1_ReceiptNo""].Value + @""','"" + ISpace[""UC_EmployeeBaicInfoId""].Value + @""','"" + ISpace[""MF_P1_Status""].Value + @""','"" + ISpace[""MF_P1_TransferReferenceDate""].Value + @""','"" + ISpace[""MF_P1_TransferReferenceBranch""].Value + @""','"" + ISpace[""MF_P1_UpdatedBy""].Value + @""','"" + ISpace[""MF_P1_TransferType""].Value + @""','"" + ISpace[""C_FC_ProjectNo_15""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result8ededcfe5adacbe6902976086059adc4!=null) && (result8ededcfe5adacbe6902976086059adc4.Count!=0))
{
if(result8ededcfe5adacbe6902976086059adc4.ContainsKey(0))
ISpace["ExecutionMessage"].Value = result8ededcfe5adacbe6902976086059adc4[0];
}
else{
ISpace["ExecutionMessage"].Value = null;
}
base.WriteDebugInfo(@"#ReceiptSplitUp[Rows]");
iSpace.GetLoopExpressionData("ReceiptSplitUp",ref ISpace);

foreach(var gridChild in ISpace["ReceiptSplitUp"].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 

base.WriteDebugInfo(@"EXEC UpsertReceiptSplitUpDetails '#MG_R2_ReceiptSplitUpId','#MF_P1_ReceiptsId','#MG_R2_BudgetId','#MG_R2_Amount','@@gv_UserId'");

var querySourcef97254576a4771b90f3c9b5f75e48ca1 =GetQueryExpressionDataSource("f9725457-6a47-71b9-0f3c-9b5f75e48ca1");
Dictionary<short,object> resultf97254576a4771b90f3c9b5f75e48ca1=iSpace.ExecuteQuery(querySourcef97254576a4771b90f3c9b5f75e48ca1,@"EXEC UpsertReceiptSplitUpDetails '" + ISpace["MG_R2_ReceiptSplitUpId"].Value + @"','" + ISpace["MF_P1_ReceiptsId"].Value + @"','" + ISpace["MG_R2_BudgetId"].Value + @"','" + ISpace["MG_R2_Amount"].Value + @"','" + ISpace["gv_userid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourcef97254576a4771b90f3c9b5f75e48ca1 =GetQueryExpressionDataSource(""f9725457-6a47-71b9-0f3c-9b5f75e48ca1"");Dictionary<short,object> resultf97254576a4771b90f3c9b5f75e48ca1=iSpace.ExecuteQuery(querySourcef97254576a4771b90f3c9b5f75e48ca1,@""EXEC UpsertReceiptSplitUpDetails '"" + ISpace[""MG_R2_ReceiptSplitUpId""].Value + @""','"" + ISpace[""MF_P1_ReceiptsId""].Value + @""','"" + ISpace[""MG_R2_BudgetId""].Value + @""','"" + ISpace[""MG_R2_Amount""].Value + @""','"" + ISpace[""gv_userid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultf97254576a4771b90f3c9b5f75e48ca1!=null) && (resultf97254576a4771b90f3c9b5f75e48ca1.Count!=0))
{
if(resultf97254576a4771b90f3c9b5f75e48ca1.ContainsKey(0))
ISpace["ExecutionMessage"].Value = resultf97254576a4771b90f3c9b5f75e48ca1[0];
}
else{
ISpace["ExecutionMessage"].Value = null;
}
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("ReceiptSplitUp","249EF445-9B49-4EF9-8045-46BD1E6FF8ED",_objectFactory.GetGridRPP("ReceiptSplitUp"),_elementBase.GetGridLoopQuery("249EF445-9B49-4EF9-8045-46BD1E6FF8ED","ReceiptSplitUp",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""ReceiptSplitUp"",ref ISpace);

foreach(var gridChild in ISpace[""ReceiptSplitUp""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
base.WriteDebugInfo(@"#MG_DcoumentDetails[Rows]");
iSpace.GetLoopExpressionData("MG_DcoumentDetails",ref ISpace);

foreach(var gridChild in ISpace["MG_DcoumentDetails"].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 

base.WriteDebugInfo(@"EXEC UpsertDocumentDetails '#M_DocumentDetailsId','@@gv_InstanceId','#M_PackageProcessMapId','#M_DocumentName','#M_UploadDcoument','@@gv_UserId'");

var querySourcedbd67128b3fd6fe232e3a8d6e1f86bde =GetQueryExpressionDataSource("dbd67128-b3fd-6fe2-32e3-a8d6e1f86bde");
Dictionary<short,object> resultdbd67128b3fd6fe232e3a8d6e1f86bde=iSpace.ExecuteQuery(querySourcedbd67128b3fd6fe232e3a8d6e1f86bde,@"EXEC UpsertDocumentDetails '" + ISpace["M_DocumentDetailsId"].Value + @"','" + ISpace["gv_instanceid"].Value + @"','" + ISpace["M_PackageProcessMapId"].Value + @"','" + ISpace["M_DocumentName"].Value + @"','" + ISpace["M_UploadDcoument"].Value + @"','" + ISpace["gv_userid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourcedbd67128b3fd6fe232e3a8d6e1f86bde =GetQueryExpressionDataSource(""dbd67128-b3fd-6fe2-32e3-a8d6e1f86bde"");Dictionary<short,object> resultdbd67128b3fd6fe232e3a8d6e1f86bde=iSpace.ExecuteQuery(querySourcedbd67128b3fd6fe232e3a8d6e1f86bde,@""EXEC UpsertDocumentDetails '"" + ISpace[""M_DocumentDetailsId""].Value + @""','"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""M_PackageProcessMapId""].Value + @""','"" + ISpace[""M_DocumentName""].Value + @""','"" + ISpace[""M_UploadDcoument""].Value + @""','"" + ISpace[""gv_userid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultdbd67128b3fd6fe232e3a8d6e1f86bde!=null) && (resultdbd67128b3fd6fe232e3a8d6e1f86bde.Count!=0))
{
if(resultdbd67128b3fd6fe232e3a8d6e1f86bde.ContainsKey(0))
ISpace["ExecutionMessage"].Value = resultdbd67128b3fd6fe232e3a8d6e1f86bde[0];
}
else{
ISpace["ExecutionMessage"].Value = null;
}
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("MG_DcoumentDetails","C2287754-790E-4853-A5A7-64772676D00E",_objectFactory.GetGridRPP("MG_DcoumentDetails"),_elementBase.GetGridLoopQuery("C2287754-790E-4853-A5A7-64772676D00E","MG_DcoumentDetails",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""MG_DcoumentDetails"",ref ISpace);

foreach(var gridChild in ISpace[""MG_DcoumentDetails""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
base.WriteDebugInfo(@"EXEC UpsertCreateProjectDetails '#MF_ProjectDetailsID','#MF_P1_ActualDate','#MF_P1_ActualEndDate'");

var querySourceb25829de0dacf553841baf18f5d427f5 =GetQueryExpressionDataSource("b25829de-0dac-f553-841b-af18f5d427f5");
Dictionary<short,object> resultb25829de0dacf553841baf18f5d427f5=iSpace.ExecuteQuery(querySourceb25829de0dacf553841baf18f5d427f5,@"EXEC UpsertCreateProjectDetails '" + ISpace["MF_ProjectDetailsID"].Value + @"','" + ISpace["MF_P1_ActualDate"].Value + @"','" + ISpace["MF_P1_ActualEndDate"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceb25829de0dacf553841baf18f5d427f5 =GetQueryExpressionDataSource(""b25829de-0dac-f553-841b-af18f5d427f5"");Dictionary<short,object> resultb25829de0dacf553841baf18f5d427f5=iSpace.ExecuteQuery(querySourceb25829de0dacf553841baf18f5d427f5,@""EXEC UpsertCreateProjectDetails '"" + ISpace[""MF_ProjectDetailsID""].Value + @""','"" + ISpace[""MF_P1_ActualDate""].Value + @""','"" + ISpace[""MF_P1_ActualEndDate""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultb25829de0dacf553841baf18f5d427f5!=null) && (resultb25829de0dacf553841baf18f5d427f5.Count!=0))
{
if(resultb25829de0dacf553841baf18f5d427f5.ContainsKey(0))
ISpace["ExecutionMessage"].Value = resultb25829de0dacf553841baf18f5d427f5[0];
}
else{
ISpace["ExecutionMessage"].Value = null;
}
base.WriteDebugInfo(@"exec UpdateOverHeadSplitData '#C_FC_ProjectNo_15','#MF_P1_ReceiptsId','@@gv_ProcessMapId'");

var querySourceDE3FD546579040D28E8AEB9179B047C4 =GetQueryExpressionDataSource("DE3FD546-5790-40D2-8E8A-EB9179B047C4");
Dictionary<short,object> resultDE3FD546579040D28E8AEB9179B047C4=iSpace.ExecuteQuery(querySourceDE3FD546579040D28E8AEB9179B047C4,@"exec UpdateOverHeadSplitData '" + ISpace["C_FC_ProjectNo_15"].Value + @"','" + ISpace["MF_P1_ReceiptsId"].Value + @"','" + ISpace["gv_processmapid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceDE3FD546579040D28E8AEB9179B047C4 =GetQueryExpressionDataSource(""DE3FD546-5790-40D2-8E8A-EB9179B047C4"");Dictionary<short,object> resultDE3FD546579040D28E8AEB9179B047C4=iSpace.ExecuteQuery(querySourceDE3FD546579040D28E8AEB9179B047C4,@""exec UpdateOverHeadSplitData '"" + ISpace[""C_FC_ProjectNo_15""].Value + @""','"" + ISpace[""MF_P1_ReceiptsId""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultDE3FD546579040D28E8AEB9179B047C4!=null) && (resultDE3FD546579040D28E8AEB9179B047C4.Count!=0))
{
if(resultDE3FD546579040D28E8AEB9179B047C4.ContainsKey(0))
ISpace["Subject"].Value = resultDE3FD546579040D28E8AEB9179B047C4[0];
}
else{
ISpace["Subject"].Value = null;
}
base.WriteDebugInfo(@"EXEC [UpsertProjectBudgetDetails] 4,'#C_FC_ProjectNo_15','#MF_P1_ReceiptsId'");

var querySource0B4B727AF2FC49FDADAE2CCF203DB052 =GetQueryExpressionDataSource("0B4B727A-F2FC-49FD-ADAE-2CCF203DB052");
Dictionary<short,object> result0B4B727AF2FC49FDADAE2CCF203DB052=iSpace.ExecuteQuery(querySource0B4B727AF2FC49FDADAE2CCF203DB052,@"EXEC [UpsertProjectBudgetDetails] 4,'" + ISpace["C_FC_ProjectNo_15"].Value + @"','" + ISpace["MF_P1_ReceiptsId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource0B4B727AF2FC49FDADAE2CCF203DB052 =GetQueryExpressionDataSource(""0B4B727A-F2FC-49FD-ADAE-2CCF203DB052"");Dictionary<short,object> result0B4B727AF2FC49FDADAE2CCF203DB052=iSpace.ExecuteQuery(querySource0B4B727AF2FC49FDADAE2CCF203DB052,@""EXEC [UpsertProjectBudgetDetails] 4,'"" + ISpace[""C_FC_ProjectNo_15""].Value + @""','"" + ISpace[""MF_P1_ReceiptsId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result0B4B727AF2FC49FDADAE2CCF203DB052!=null) && (result0B4B727AF2FC49FDADAE2CCF203DB052.Count!=0))
{
if(result0B4B727AF2FC49FDADAE2CCF203DB052.ContainsKey(0))
ISpace["Subject"].Value = result0B4B727AF2FC49FDADAE2CCF203DB052[0];
}
else{
ISpace["Subject"].Value = null;
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
if(ISpace["M_SaveDomainData"].Value==1&&ISpace["MF_P1_Status"].Value=="A")
{
base.WriteDebugInfo(@"if(ISpace[""M_SaveDomainData""].Value==1&&ISpace[""MF_P1_Status""].Value==""A"")");
base.WriteDebugInfo(@"Exec [SendApproveEmailForPFI] '#MF_P1_ReceiptsId'");

var querySource940556A658CF49598DD30E1D927449F2 =GetQueryExpressionDataSource("940556A6-58CF-4959-8DD3-0E1D927449F2");
Dictionary<short,object> result940556A658CF49598DD30E1D927449F2=iSpace.ExecuteQuery(querySource940556A658CF49598DD30E1D927449F2,@"Exec [SendApproveEmailForPFI] '" + ISpace["MF_P1_ReceiptsId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource940556A658CF49598DD30E1D927449F2 =GetQueryExpressionDataSource(""940556A6-58CF-4959-8DD3-0E1D927449F2"");Dictionary<short,object> result940556A658CF49598DD30E1D927449F2=iSpace.ExecuteQuery(querySource940556A658CF49598DD30E1D927449F2,@""Exec [SendApproveEmailForPFI] '"" + ISpace[""MF_P1_ReceiptsId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result940556A658CF49598DD30E1D927449F2!=null) && (result940556A658CF49598DD30E1D927449F2.Count!=0))
{
if(result940556A658CF49598DD30E1D927449F2.ContainsKey(0))
ISpace["Mailcount"].Value = result940556A658CF49598DD30E1D927449F2[0];
}
else{
ISpace["Mailcount"].Value = null;
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
ISpace["Message"].Value=@"Submitted Successfully";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Submitted Successfully"";");

var querySourceB8A2A58C91CA4FD4B3269652593DD27B =GetQueryExpressionDataSource("B8A2A58C-91CA-4FD4-B326-9652593DD27B");

DataTable resultB8A2A58C91CA4FD4B3269652593DD27B=iSpace.SetGridDataSource(querySourceB8A2A58C91CA4FD4B3269652593DD27B, _objectFactory.GetGridRPP("MG_RemarksDetails"),@"EXEC GetRemarks '" + ISpace["Instanceid"].Value + @"'");

iSpace.InsertGridBindDetails("MG_RemarksDetails","11",querySourceB8A2A58C91CA4FD4B3269652593DD27B,"EXEC GetRemarks '" + ISpace["Instanceid"].Value + @"'",_objectFactory.GetGridRPP("MG_RemarksDetails"));

base.WriteDebugInfo(@"var querySourceB8A2A58C91CA4FD4B3269652593DD27B =GetQueryExpressionDataSource(""B8A2A58C-91CA-4FD4-B326-9652593DD27B"");DataTable resultB8A2A58C91CA4FD4B3269652593DD27B=iSpace.SetGridDataSource(querySourceB8A2A58C91CA4FD4B3269652593DD27B, _objectFactory.GetGridRPP(""MG_RemarksDetails""),@""EXEC GetRemarks '"" + ISpace[""Instanceid""].Value + @""'"");iSpace.InsertGridBindDetails(""MG_RemarksDetails"",""11"",querySourceB8A2A58C91CA4FD4B3269652593DD27B,""EXEC GetRemarks '"" + ISpace[""Instanceid""].Value + @""'"",_objectFactory.GetGridRPP(""MG_RemarksDetails""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result4ACD680C9EAE4FDBA4A3FC5C4D353701=acdataIspaceFF2ED87620AB4F5DB62B385405DFB900.GetQueryExpressionBindings("4ACD680C-9EAE-4FDB-A4A3-FC5C4D353701");
iSpace.SetGridData(resultB8A2A58C91CA4FD4B3269652593DD27B,result4ACD680C9EAE4FDBA4A3FC5C4D353701,"MG_RemarksDetails",ref ISpace);
iSpace.UpdateGridBindDetails("MG_RemarksDetails",result4ACD680C9EAE4FDBA4A3FC5C4D353701);
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
ISpace["SetDestinationTo"].Value=ISpace["M_MoveTo"].Value;
base.WriteDebugInfo(@"ISpace[""SetDestinationTo""].Value=ISpace[""M_MoveTo""].Value;");
ISpace["M_MoveToValue"].Value=ISpace["M_MoveTo"].Value;
base.WriteDebugInfo(@"ISpace[""M_MoveToValue""].Value=ISpace[""M_MoveTo""].Value;");
base.WriteDebugInfo(@"Exec GetStageStatus 1,'','','#M_MoveToValue','#M_SourceActivityMapId'");

var querySource566D32B365864115B5DB148796882A52 =GetQueryExpressionDataSource("566D32B3-6586-4115-B5DB-148796882A52");
Dictionary<short,object> result566D32B365864115B5DB148796882A52=iSpace.ExecuteQuery(querySource566D32B365864115B5DB148796882A52,@"Exec GetStageStatus 1,'','','" + ISpace["M_MoveToValue"].Value + @"','" + ISpace["M_SourceActivityMapId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource566D32B365864115B5DB148796882A52 =GetQueryExpressionDataSource(""566D32B3-6586-4115-B5DB-148796882A52"");Dictionary<short,object> result566D32B365864115B5DB148796882A52=iSpace.ExecuteQuery(querySource566D32B365864115B5DB148796882A52,@""Exec GetStageStatus 1,'','','"" + ISpace[""M_MoveToValue""].Value + @""','"" + ISpace[""M_SourceActivityMapId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result566D32B365864115B5DB148796882A52!=null) && (result566D32B365864115B5DB148796882A52.Count!=0))
{
if(result566D32B365864115B5DB148796882A52.ContainsKey(3))
ISpace["M_SaveDomainData"].Value = result566D32B365864115B5DB148796882A52[3];
if(result566D32B365864115B5DB148796882A52.ContainsKey(1))
ISpace["M_RemarksMandatory"].Value = result566D32B365864115B5DB148796882A52[1];
if(result566D32B365864115B5DB148796882A52.ContainsKey(4))
ISpace["M_FieldMandatory"].Value = result566D32B365864115B5DB148796882A52[4];
if(result566D32B365864115B5DB148796882A52.ContainsKey(5))
ISpace["M_IsflowReturned"].Value = result566D32B365864115B5DB148796882A52[5];
if(result566D32B365864115B5DB148796882A52.ContainsKey(6))
ISpace["M_IsCancelReject"].Value = result566D32B365864115B5DB148796882A52[6];
if(result566D32B365864115B5DB148796882A52.ContainsKey(7))
ISpace["M_Currentlevel"].Value = result566D32B365864115B5DB148796882A52[7];
if(result566D32B365864115B5DB148796882A52.ContainsKey(0))
ISpace["M_NextStage"].Value = result566D32B365864115B5DB148796882A52[0];
if(result566D32B365864115B5DB148796882A52.ContainsKey(2))
ISpace["M_Remarks"].Value = result566D32B365864115B5DB148796882A52[2];
}
else{
ISpace["M_SaveDomainData"].Value = null;ISpace["M_RemarksMandatory"].Value = null;ISpace["M_FieldMandatory"].Value = null;ISpace["M_IsflowReturned"].Value = null;ISpace["M_IsCancelReject"].Value = null;ISpace["M_Currentlevel"].Value = null;ISpace["M_NextStage"].Value = null;ISpace["M_Remarks"].Value = null;
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
public class ISpace2B40E332984042E38DDC002EAFAA05FA : VirtualForm
{
IISpace iSpace = new ISpace();
AcDataISpace2B40E332984042E38DDC002EAFAA05FA acdataIspace2B40E332984042E38DDC002EAFAA05FA=new AcDataISpace2B40E332984042E38DDC002EAFAA05FA();
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
ISpace["M_ActivityName"].Value=ISpace["gv_activityname"].Value;
base.WriteDebugInfo(@"ISpace[""M_ActivityName""].Value=ISpace[""gv_activityname""].Value;");
ISpace["M_MoveTo"].Man=true;
base.WriteDebugInfo(@"ISpace[""M_MoveTo""].Man=true;");
ISpace["M_Remarks"].Value="";
base.WriteDebugInfo(@"ISpace[""M_Remarks""].Value="""";");
ISpace["M_NextStage"].Value="";
base.WriteDebugInfo(@"ISpace[""M_NextStage""].Value="""";");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"select DBO.[FN_GetEmployeeHoD] ('@@gv_UserName')");

var querySource84E66A1AD77D4A8F9C71C6E469B653E2 =GetQueryExpressionDataSource("84E66A1A-D77D-4A8F-9C71-C6E469B653E2");
Dictionary<short,object> result84E66A1AD77D4A8F9C71C6E469B653E2=iSpace.ExecuteQuery(querySource84E66A1AD77D4A8F9C71C6E469B653E2,@"select DBO.[FN_GetEmployeeHoD] ('" + ISpace["gv_username"].Value + @"')",false);

base.WriteDebugInfo(@"var querySource84E66A1AD77D4A8F9C71C6E469B653E2 =GetQueryExpressionDataSource(""84E66A1A-D77D-4A8F-9C71-C6E469B653E2"");Dictionary<short,object> result84E66A1AD77D4A8F9C71C6E469B653E2=iSpace.ExecuteQuery(querySource84E66A1AD77D4A8F9C71C6E469B653E2,@""select DBO.[FN_GetEmployeeHoD] ('"" + ISpace[""gv_username""].Value + @""')"",false);");
base.WriteDebugInfo(@"");

if((result84E66A1AD77D4A8F9C71C6E469B653E2!=null) && (result84E66A1AD77D4A8F9C71C6E469B653E2.Count!=0))
{
if(result84E66A1AD77D4A8F9C71C6E469B653E2.ContainsKey(0))
ISpace["HODUSERID"].Value = result84E66A1AD77D4A8F9C71C6E469B653E2[0];
}
else{
ISpace["HODUSERID"].Value = null;
}
if(ISpace["C_FC_Category_15"].Value=="Consultancy")
{
base.WriteDebugInfo(@"if(ISpace[""C_FC_Category_15""].Value==""Consultancy"")");
ISpace["AssignToUser"].Value=ISpace["HODUSERID"].Value;
base.WriteDebugInfo(@"ISpace[""AssignToUser""].Value=ISpace[""HODUSERID""].Value;");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["AssignToUser"].Value=null;
base.WriteDebugInfo(@"ISpace[""AssignToUser""].Value=null;");
}
}
ISpace["UC_PhoneNumber"].Visible="false";ISpace["UC_DOB"].Visible="false";ISpace["UC_DOR"].Visible="false";ISpace["UC_Paylevel"].Visible="false";ISpace["UC_EmailId"].Visible="false";ISpace["UC_Grade"].Visible="false";ISpace["UC_DOJ"].Visible="false";
base.WriteDebugInfo(@"ISpace[""UC_PhoneNumber""].Visible=""false"";ISpace[""UC_DOB""].Visible=""false"";ISpace[""UC_DOR""].Visible=""false"";ISpace[""UC_Paylevel""].Visible=""false"";ISpace[""UC_EmailId""].Visible=""false"";ISpace[""UC_Grade""].Visible=""false"";ISpace[""UC_DOJ""].Visible=""false"";");
if(ISpace["FormVersionId"].Value=="B1CB93DB-7B9C-4661-BE11-02ED3BFD5725")
{
ISpace["UI_AvailablebudgetModal"].Visible="false";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""B1CB93DB-7B9C-4661-BE11-02ED3BFD5725"")
{
ISpace[""UI_AvailablebudgetModal""].Visible=""false"";
}");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["MFG_R2_ReceiptSplitUpId"].Visible="false";ISpace["MF_P1_TransferReferenceBankId"].Visible="true";ISpace["MF_P1_TransferReferenceBranch"].Visible="true";ISpace["MF_P1_ReceiptAmount"].Visible="true";ISpace["MF_P1_TransferType"].Visible="true";ISpace["MF_P1_TransferReferenceNumber"].Visible="true";ISpace["MF_P1_Status"].Visible="false";ISpace["MF_P1_ReceiptNo"].Visible="true";ISpace["MF_P1_ProjectDetailsId"].Visible="true";ISpace["MF_P1_UpdatedOn"].Visible="false";ISpace["MF_P1_TransferReferenceDate"].Visible="true";ISpace["MFG_R2_UpdatedBy"].Visible="false";ISpace["MF_P1_ReceiptsId"].Visible="true";ISpace["MF_P1_ReceiptDate"].Visible="true";ISpace["MF_P1_UpdatedBy"].Visible="false";ISpace["MFG_R2_Amount"].Visible="true";ISpace["MFG_R2_UpdatedOn"].Visible="false";ISpace["MFG_R2_ReceiptsId"].Visible="false";ISpace["MFG_R2_BudgetId"].Visible="true";
base.WriteDebugInfo(@"ISpace[""MFG_R2_ReceiptSplitUpId""].Visible=""false"";ISpace[""MF_P1_TransferReferenceBankId""].Visible=""true"";ISpace[""MF_P1_TransferReferenceBranch""].Visible=""true"";ISpace[""MF_P1_ReceiptAmount""].Visible=""true"";ISpace[""MF_P1_TransferType""].Visible=""true"";ISpace[""MF_P1_TransferReferenceNumber""].Visible=""true"";ISpace[""MF_P1_Status""].Visible=""false"";ISpace[""MF_P1_ReceiptNo""].Visible=""true"";ISpace[""MF_P1_ProjectDetailsId""].Visible=""true"";ISpace[""MF_P1_UpdatedOn""].Visible=""false"";ISpace[""MF_P1_TransferReferenceDate""].Visible=""true"";ISpace[""MFG_R2_UpdatedBy""].Visible=""false"";ISpace[""MF_P1_ReceiptsId""].Visible=""true"";ISpace[""MF_P1_ReceiptDate""].Visible=""true"";ISpace[""MF_P1_UpdatedBy""].Visible=""false"";ISpace[""MFG_R2_Amount""].Visible=""true"";ISpace[""MFG_R2_UpdatedOn""].Visible=""false"";ISpace[""MFG_R2_ReceiptsId""].Visible=""false"";ISpace[""MFG_R2_BudgetId""].Visible=""true"";");
ISpace["MG_R2_ReceiptsId"].Visible="true";ISpace["MG_R2_BudgetId"].Visible="true";ISpace["MG_R2_Amount"].Visible="true";ISpace["MG_R2_UpdatedBy"].Visible="false";ISpace["MG_R2_UpdatedOn"].Visible="false";ISpace["MG_R2_ReceiptSplitUpId"].Visible="true";
base.WriteDebugInfo(@"ISpace[""MG_R2_ReceiptsId""].Visible=""true"";ISpace[""MG_R2_BudgetId""].Visible=""true"";ISpace[""MG_R2_Amount""].Visible=""true"";ISpace[""MG_R2_UpdatedBy""].Visible=""false"";ISpace[""MG_R2_UpdatedOn""].Visible=""false"";ISpace[""MG_R2_ReceiptSplitUpId""].Visible=""true"";");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["MF_P1_ReceiptAmount"].Man=true;ISpace["MF_P1_ProjectDetailsId"].Man=true;ISpace["MF_P1_ReceiptDate"].Man=true;ISpace["MFG_R2_Amount"].Man=true;ISpace["MFG_R2_BudgetId"].Man=true;
base.WriteDebugInfo(@"ISpace[""MF_P1_ReceiptAmount""].Man=true;ISpace[""MF_P1_ProjectDetailsId""].Man=true;ISpace[""MF_P1_ReceiptDate""].Man=true;ISpace[""MFG_R2_Amount""].Man=true;ISpace[""MFG_R2_BudgetId""].Man=true;");
}

var querySourceB8A2A58C91CA4FD4B3269652593DD27B =GetQueryExpressionDataSource("B8A2A58C-91CA-4FD4-B326-9652593DD27B");

DataTable resultB8A2A58C91CA4FD4B3269652593DD27B=iSpace.SetGridDataSource(querySourceB8A2A58C91CA4FD4B3269652593DD27B, _objectFactory.GetGridRPP("MG_RemarksDetails"),@"EXEC GetRemarks '" + ISpace["Instanceid"].Value + @"'");

iSpace.InsertGridBindDetails("MG_RemarksDetails","11",querySourceB8A2A58C91CA4FD4B3269652593DD27B,"EXEC GetRemarks '" + ISpace["Instanceid"].Value + @"'",_objectFactory.GetGridRPP("MG_RemarksDetails"));

base.WriteDebugInfo(@"var querySourceB8A2A58C91CA4FD4B3269652593DD27B =GetQueryExpressionDataSource(""B8A2A58C-91CA-4FD4-B326-9652593DD27B"");DataTable resultB8A2A58C91CA4FD4B3269652593DD27B=iSpace.SetGridDataSource(querySourceB8A2A58C91CA4FD4B3269652593DD27B, _objectFactory.GetGridRPP(""MG_RemarksDetails""),@""EXEC GetRemarks '"" + ISpace[""Instanceid""].Value + @""'"");iSpace.InsertGridBindDetails(""MG_RemarksDetails"",""11"",querySourceB8A2A58C91CA4FD4B3269652593DD27B,""EXEC GetRemarks '"" + ISpace[""Instanceid""].Value + @""'"",_objectFactory.GetGridRPP(""MG_RemarksDetails""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result4ACD680C9EAE4FDBA4A3FC5C4D353701=acdataIspace2B40E332984042E38DDC002EAFAA05FA.GetQueryExpressionBindings("4ACD680C-9EAE-4FDB-A4A3-FC5C4D353701");
iSpace.SetGridData(resultB8A2A58C91CA4FD4B3269652593DD27B,result4ACD680C9EAE4FDBA4A3FC5C4D353701,"MG_RemarksDetails",ref ISpace);
iSpace.UpdateGridBindDetails("MG_RemarksDetails",result4ACD680C9EAE4FDBA4A3FC5C4D353701);
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
if(ISpace["MF_P1_ReceiptAmount"].Value==0)
{
base.WriteDebugInfo(@"if(ISpace[""MF_P1_ReceiptAmount""].Value==0)");
ISpace["Message"].Value=@"Please Enter the Amount";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please Enter the Amount"";");
return;
base.WriteDebugInfo(@"return;");
}
if((ISpace["MF_P1_ReceiptDate"].Value == null))
{
base.WriteDebugInfo(@"if((ISpace[""MF_P1_ReceiptDate""].Value == null))");
ISpace["Message"].Value=@"Please Enter the Date";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please Enter the Date"";");
return;
base.WriteDebugInfo(@"return;");
}
if(1==2)
{
base.WriteDebugInfo(@"if(1==2)");
ISpace["Message"].Value=@"Please Enter the Transfer Type";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please Enter the Transfer Type"";");
return;
base.WriteDebugInfo(@"return;");
}
if(1==2)
{
base.WriteDebugInfo(@"if(1==2)");
ISpace["Message"].Value=@"Please Enter the Transfer Reference Number";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please Enter the Transfer Reference Number"";");
return;
base.WriteDebugInfo(@"return;");
}
if(1==2)
{
base.WriteDebugInfo(@"if(1==2)");
ISpace["Message"].Value=@"Please Enter the Transfer Date";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please Enter the Transfer Date"";");
return;
base.WriteDebugInfo(@"return;");
}
if(1==2)
{
base.WriteDebugInfo(@"if(1==2)");
ISpace["Message"].Value=@"Please Enter the Bank Name";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please Enter the Bank Name"";");
return;
base.WriteDebugInfo(@"return;");
}
if(1==2)
{
base.WriteDebugInfo(@"if(1==2)");
ISpace["Message"].Value=@"Please Enter the Branch Name";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please Enter the Branch Name"";");
return;
base.WriteDebugInfo(@"return;");
}
if(1==2)
{
base.WriteDebugInfo(@"if(1==2)");
ISpace["Message"].Value=@"Please Enter the Receipt No";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please Enter the Receipt No"";");
return;
base.WriteDebugInfo(@"return;");
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_P1_ReceiptAmount"].Value!=ISpace["R_TotalSplitUpAmount"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_P1_ReceiptAmount""].Value!=ISpace[""R_TotalSplitUpAmount""].Value)");
ISpace["Message"].Value=@"Split Up total should be equal to Fund Installment Amount";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Split Up total should be equal to Fund Installment Amount"";");
return;
base.WriteDebugInfo(@"return;");
}
}
if(ISpace["M_MoveTo"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""M_MoveTo""].Value=="""")");
ISpace["Message"].Value=@"Please select the value for Move To";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please select the value for Move To"";");
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
if (_elementBase != null)  iSpace.SetLoopExpressionData("MG_DcoumentDetails","C2287754-790E-4853-A5A7-64772676D00E",_objectFactory.GetGridRPP("MG_DcoumentDetails"),_elementBase.GetGridLoopQuery("C2287754-790E-4853-A5A7-64772676D00E","MG_DcoumentDetails",ISpace), ref ISpace);
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
}
ISpace["Message"].Value=@"Submitted Successfully";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Submitted Successfully"";");

var querySourceB8A2A58C91CA4FD4B3269652593DD27B =GetQueryExpressionDataSource("B8A2A58C-91CA-4FD4-B326-9652593DD27B");

DataTable resultB8A2A58C91CA4FD4B3269652593DD27B=iSpace.SetGridDataSource(querySourceB8A2A58C91CA4FD4B3269652593DD27B, _objectFactory.GetGridRPP("MG_RemarksDetails"),@"EXEC GetRemarks '" + ISpace["Instanceid"].Value + @"'");

iSpace.InsertGridBindDetails("MG_RemarksDetails","11",querySourceB8A2A58C91CA4FD4B3269652593DD27B,"EXEC GetRemarks '" + ISpace["Instanceid"].Value + @"'",_objectFactory.GetGridRPP("MG_RemarksDetails"));

base.WriteDebugInfo(@"var querySourceB8A2A58C91CA4FD4B3269652593DD27B =GetQueryExpressionDataSource(""B8A2A58C-91CA-4FD4-B326-9652593DD27B"");DataTable resultB8A2A58C91CA4FD4B3269652593DD27B=iSpace.SetGridDataSource(querySourceB8A2A58C91CA4FD4B3269652593DD27B, _objectFactory.GetGridRPP(""MG_RemarksDetails""),@""EXEC GetRemarks '"" + ISpace[""Instanceid""].Value + @""'"");iSpace.InsertGridBindDetails(""MG_RemarksDetails"",""11"",querySourceB8A2A58C91CA4FD4B3269652593DD27B,""EXEC GetRemarks '"" + ISpace[""Instanceid""].Value + @""'"",_objectFactory.GetGridRPP(""MG_RemarksDetails""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result4ACD680C9EAE4FDBA4A3FC5C4D353701=acdataIspace2B40E332984042E38DDC002EAFAA05FA.GetQueryExpressionBindings("4ACD680C-9EAE-4FDB-A4A3-FC5C4D353701");
iSpace.SetGridData(resultB8A2A58C91CA4FD4B3269652593DD27B,result4ACD680C9EAE4FDBA4A3FC5C4D353701,"MG_RemarksDetails",ref ISpace);
iSpace.UpdateGridBindDetails("MG_RemarksDetails",result4ACD680C9EAE4FDBA4A3FC5C4D353701);
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mg_r2_amount (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MG_R2_Amount-OnChange");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
object MG_R2_Amount=iSpace.Sum("[249EF445-9B49-4EF9-8045-46BD1E6FF8ED]","MG_R2_Amount","");
ISpace["R_TotalSplitUpAmount"].Value=Convert.ChangeType(MG_R2_Amount, MG_R2_Amount.GetType());;
base.WriteDebugInfo(@"object MG_R2_Amount=iSpace.Sum(""[249EF445-9B49-4EF9-8045-46BD1E6FF8ED]"",""MG_R2_Amount"","""");
ISpace[""R_TotalSplitUpAmount""].Value=Convert.ChangeType(MG_R2_Amount, MG_R2_Amount.GetType());;");
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_c_fc_sanctionno_15 (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"C_FC_SanctionNo_15-OnChange");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC GETReceiptAmountBalace 2,'#C_FC_ProjectNo_15'");

var querySource82426A40A87041909F2B6350B84FC4D6 =GetQueryExpressionDataSource("82426A40-A870-4190-9F2B-6350B84FC4D6");
Dictionary<short,object> result82426A40A87041909F2B6350B84FC4D6=iSpace.ExecuteQuery(querySource82426A40A87041909F2B6350B84FC4D6,@"EXEC GETReceiptAmountBalace 2,'" + ISpace["C_FC_ProjectNo_15"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource82426A40A87041909F2B6350B84FC4D6 =GetQueryExpressionDataSource(""82426A40-A870-4190-9F2B-6350B84FC4D6"");Dictionary<short,object> result82426A40A87041909F2B6350B84FC4D6=iSpace.ExecuteQuery(querySource82426A40A87041909F2B6350B84FC4D6,@""EXEC GETReceiptAmountBalace 2,'"" + ISpace[""C_FC_ProjectNo_15""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result82426A40A87041909F2B6350B84FC4D6!=null) && (result82426A40A87041909F2B6350B84FC4D6.Count!=0))
{
if(result82426A40A87041909F2B6350B84FC4D6.ContainsKey(2))
ISpace["C_FC_SanctionedDate_15"].Value = result82426A40A87041909F2B6350B84FC4D6[2];
if(result82426A40A87041909F2B6350B84FC4D6.ContainsKey(11))
ISpace["MF_P1_ActualDate"].Value = result82426A40A87041909F2B6350B84FC4D6[11];
if(result82426A40A87041909F2B6350B84FC4D6.ContainsKey(4))
ISpace["C_FC_EndDate"].Value = result82426A40A87041909F2B6350B84FC4D6[4];
if(result82426A40A87041909F2B6350B84FC4D6.ContainsKey(3))
ISpace["C_FC_StartDate_15"].Value = result82426A40A87041909F2B6350B84FC4D6[3];
if(result82426A40A87041909F2B6350B84FC4D6.ContainsKey(14))
ISpace["MF_P1_ActualEndDate"].Value = result82426A40A87041909F2B6350B84FC4D6[14];
if(result82426A40A87041909F2B6350B84FC4D6.ContainsKey(8))
ISpace["C_FC_SanctionedValue_15"].Value = result82426A40A87041909F2B6350B84FC4D6[8];
if(result82426A40A87041909F2B6350B84FC4D6.ContainsKey(12))
ISpace["MF_P1_YearMonth"].Value = result82426A40A87041909F2B6350B84FC4D6[12];
if(result82426A40A87041909F2B6350B84FC4D6.ContainsKey(10))
ISpace["MF_ProjectDetailsID"].Value = result82426A40A87041909F2B6350B84FC4D6[10];
if(result82426A40A87041909F2B6350B84FC4D6.ContainsKey(13))
ISpace["MF_P1_Duration"].Value = result82426A40A87041909F2B6350B84FC4D6[13];
if(result82426A40A87041909F2B6350B84FC4D6.ContainsKey(5))
ISpace["C_FC_SanctionNo_15"].Value = result82426A40A87041909F2B6350B84FC4D6[5];
if(result82426A40A87041909F2B6350B84FC4D6.ContainsKey(9))
ISpace["ProjectCode"].Value = result82426A40A87041909F2B6350B84FC4D6[9];
if(result82426A40A87041909F2B6350B84FC4D6.ContainsKey(7))
ISpace["C_FC_Category_15"].Value = result82426A40A87041909F2B6350B84FC4D6[7];
if(result82426A40A87041909F2B6350B84FC4D6.ContainsKey(1))
ISpace["C_FC_ProjectName_15"].Value = result82426A40A87041909F2B6350B84FC4D6[1];
if(result82426A40A87041909F2B6350B84FC4D6.ContainsKey(6))
ISpace["C_FC_AgencyCode_15"].Value = result82426A40A87041909F2B6350B84FC4D6[6];
}
else{
ISpace["C_FC_SanctionedDate_15"].Value = null;ISpace["MF_P1_ActualDate"].Value = null;ISpace["C_FC_EndDate"].Value = null;ISpace["C_FC_StartDate_15"].Value = null;ISpace["MF_P1_ActualEndDate"].Value = null;ISpace["C_FC_SanctionedValue_15"].Value = null;ISpace["MF_P1_YearMonth"].Value = null;ISpace["MF_ProjectDetailsID"].Value = null;ISpace["MF_P1_Duration"].Value = null;ISpace["C_FC_SanctionNo_15"].Value = null;ISpace["ProjectCode"].Value = null;ISpace["C_FC_Category_15"].Value = null;ISpace["C_FC_ProjectName_15"].Value = null;ISpace["C_FC_AgencyCode_15"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC GETReceiptAmountBalace 1,'#C_FC_ProjectNo_15'");

var querySource53963539D3EB42AC923B633B75334F3E =GetQueryExpressionDataSource("53963539-D3EB-42AC-923B-633B75334F3E");
Dictionary<short,object> result53963539D3EB42AC923B633B75334F3E=iSpace.ExecuteQuery(querySource53963539D3EB42AC923B633B75334F3E,@"EXEC GETReceiptAmountBalace 1,'" + ISpace["C_FC_ProjectNo_15"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource53963539D3EB42AC923B633B75334F3E =GetQueryExpressionDataSource(""53963539-D3EB-42AC-923B-633B75334F3E"");Dictionary<short,object> result53963539D3EB42AC923B633B75334F3E=iSpace.ExecuteQuery(querySource53963539D3EB42AC923B633B75334F3E,@""EXEC GETReceiptAmountBalace 1,'"" + ISpace[""C_FC_ProjectNo_15""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result53963539D3EB42AC923B633B75334F3E!=null) && (result53963539D3EB42AC923B633B75334F3E.Count!=0))
{
if(result53963539D3EB42AC923B633B75334F3E.ContainsKey(0))
ISpace["R_ReceiptAmountValidation"].Value = result53963539D3EB42AC923B633B75334F3E[0];
}
else{
ISpace["R_ReceiptAmountValidation"].Value = null;
}
}
ISpace["Subject"].Value=ISpace["C_FC_ProjectName_15"].Value;
base.WriteDebugInfo(@"ISpace[""Subject""].Value=ISpace[""C_FC_ProjectName_15""].Value;");
ISpace["MFG_R2_BudgetId"].rElemData=iSpace.Reload(ISpace["MFG_R2_BudgetId"].Value,@"EXEC SP_GetBudgetDetails  '" + ISpace["C_FC_ProjectNo_15"].Value + @"'","3A103712-5244-4427-B2B6-1C4E046FD337");
base.WriteDebugInfo(@"ISpace[""MFG_R2_BudgetId""].rElemData=iSpace.Reload(ISpace[""MFG_R2_BudgetId""].Value,@""EXEC SP_GetBudgetDetails  '"" + ISpace[""C_FC_ProjectNo_15""].Value + @""'"",""3A103712-5244-4427-B2B6-1C4E046FD337"");");
ISpace["M_MoveTo"].rElemData=iSpace.Reload(ISpace["M_MoveTo"].Value,@"EXEC GetMovetoValuesProjectFundInstallment 1,'" + ISpace["C_FC_Category_15"].Value + @"','" + ISpace["M_ActivityName"].Value + @"'","9ADED37B-CD11-426B-AF16-DEAC75685EF5");
base.WriteDebugInfo(@"ISpace[""M_MoveTo""].rElemData=iSpace.Reload(ISpace[""M_MoveTo""].Value,@""EXEC GetMovetoValuesProjectFundInstallment 1,'"" + ISpace[""C_FC_Category_15""].Value + @""','"" + ISpace[""M_ActivityName""].Value + @""'"",""9ADED37B-CD11-426B-AF16-DEAC75685EF5"");");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySourceEE2E79C54A8F4AC1A64E6FCFA533D02D =GetQueryExpressionDataSource("EE2E79C5-4A8F-4AC1-A64E-6FCFA533D02D");

DataTable resultEE2E79C54A8F4AC1A64E6FCFA533D02D=iSpace.SetGridDataSource(querySourceEE2E79C54A8F4AC1A64E6FCFA533D02D, _objectFactory.GetGridRPP("AvailableBudgetHeadAmount"),@"EXEC GetReceiptClaimRecords 1,'" + ISpace["C_FC_ProjectNo_15"].Value + @"',''");

iSpace.InsertGridBindDetails("AvailableBudgetHeadAmount","11",querySourceEE2E79C54A8F4AC1A64E6FCFA533D02D,"EXEC GetReceiptClaimRecords 1,'" + ISpace["C_FC_ProjectNo_15"].Value + @"',''",_objectFactory.GetGridRPP("AvailableBudgetHeadAmount"));

base.WriteDebugInfo(@"var querySourceEE2E79C54A8F4AC1A64E6FCFA533D02D =GetQueryExpressionDataSource(""EE2E79C5-4A8F-4AC1-A64E-6FCFA533D02D"");DataTable resultEE2E79C54A8F4AC1A64E6FCFA533D02D=iSpace.SetGridDataSource(querySourceEE2E79C54A8F4AC1A64E6FCFA533D02D, _objectFactory.GetGridRPP(""AvailableBudgetHeadAmount""),@""EXEC GetReceiptClaimRecords 1,'"" + ISpace[""C_FC_ProjectNo_15""].Value + @""',''"");iSpace.InsertGridBindDetails(""AvailableBudgetHeadAmount"",""11"",querySourceEE2E79C54A8F4AC1A64E6FCFA533D02D,""EXEC GetReceiptClaimRecords 1,'"" + ISpace[""C_FC_ProjectNo_15""].Value + @""',''"",_objectFactory.GetGridRPP(""AvailableBudgetHeadAmount""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result7383DEAC014B4719858E5F2EDC911594=acdataIspace2B40E332984042E38DDC002EAFAA05FA.GetQueryExpressionBindings("7383DEAC-014B-4719-858E-5F2EDC911594");
iSpace.SetGridData(resultEE2E79C54A8F4AC1A64E6FCFA533D02D,result7383DEAC014B4719858E5F2EDC911594,"AvailableBudgetHeadAmount",ref ISpace);
iSpace.UpdateGridBindDetails("AvailableBudgetHeadAmount",result7383DEAC014B4719858E5F2EDC911594);
}
ISpace["MF_P1_ReceiptAmount"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_P1_ReceiptAmount""].Enbl=""true"";");
ISpace["MF_P1_ReceiptAmount"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_P1_ReceiptAmount""].Value=null;");
ISpace["MF_P1_ReceiptDate"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_P1_ReceiptDate""].Value=null;");
ISpace["MF_P1_TransferReferenceNumber"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_P1_TransferReferenceNumber""].Value=null;");
ISpace["MF_P1_TransferReferenceBankId"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_P1_TransferReferenceBankId""].Value=null;");
ISpace["MF_P1_TransferReferenceBranch"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_P1_TransferReferenceBranch""].Value=null;");
ISpace["MF_P1_TransferReferenceDate"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_P1_TransferReferenceDate""].Value=null;");
ISpace["MF_P1_TransferType"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_P1_TransferType""].Value=null;");
ISpace["MFG_R2_BudgetId"].Value=null;
base.WriteDebugInfo(@"ISpace[""MFG_R2_BudgetId""].Value=null;");
ISpace["MFG_R2_Amount"].Value=null;
base.WriteDebugInfo(@"ISpace[""MFG_R2_Amount""].Value=null;");
ISpace["ReceiptSplitUp"].Value=null;
base.WriteDebugInfo(@"ISpace[""ReceiptSplitUp""].Value=null;");
ISpace["R_ReceiptAmountBalance"].Value=null;
base.WriteDebugInfo(@"ISpace[""R_ReceiptAmountBalance""].Value=null;");
ISpace["R_TotalSplitUpAmount"].Value=null;
base.WriteDebugInfo(@"ISpace[""R_TotalSplitUpAmount""].Value=null;");
ISpace["Instanceid"].Value=Guid.NewGuid().ToString();
base.WriteDebugInfo(@"ISpace[""Instanceid""].Value=Guid.NewGuid().ToString();");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"exec GetMySponsoredProjects 6,'#ProjectCode',''");

var querySource3B027C6216344105BF4D15B3AA014207 =GetQueryExpressionDataSource("3B027C62-1634-4105-BF4D-15B3AA014207");
Dictionary<short,object> result3B027C6216344105BF4D15B3AA014207=iSpace.ExecuteQuery(querySource3B027C6216344105BF4D15B3AA014207,@"execGetMySponsoredProjects 6,'" + ISpace["ProjectCode"].Value + @"',''",false);

base.WriteDebugInfo(@"var querySource3B027C6216344105BF4D15B3AA014207 =GetQueryExpressionDataSource(""3B027C62-1634-4105-BF4D-15B3AA014207"");Dictionary<short,object> result3B027C6216344105BF4D15B3AA014207=iSpace.ExecuteQuery(querySource3B027C6216344105BF4D15B3AA014207,@""execGetMySponsoredProjects 6,'"" + ISpace[""ProjectCode""].Value + @""',''"",false);");
base.WriteDebugInfo(@"");

if((result3B027C6216344105BF4D15B3AA014207!=null) && (result3B027C6216344105BF4D15B3AA014207.Count!=0))
{
if(result3B027C6216344105BF4D15B3AA014207.ContainsKey(0))
ISpace["MF_P1_ReceiptNo"].Value = result3B027C6216344105BF4D15B3AA014207[0];
if(result3B027C6216344105BF4D15B3AA014207.ContainsKey(1))
ISpace["FRValues"].Value = result3B027C6216344105BF4D15B3AA014207[1];
}
else{
ISpace["MF_P1_ReceiptNo"].Value = null;ISpace["FRValues"].Value = null;
}
}
if(ISpace["FRValues"].Value=="1")
{
base.WriteDebugInfo(@"if(ISpace[""FRValues""].Value==""1"")");
ISpace["MF_P1_ActualDate"].Enbl="false";ISpace["MF_P1_ActualEndDate"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MF_P1_ActualDate""].Enbl=""false"";ISpace[""MF_P1_ActualEndDate""].Enbl=""false"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_P1_ActualDate"].Enbl="true";ISpace["MF_P1_ActualEndDate"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_P1_ActualDate""].Enbl=""true"";ISpace[""MF_P1_ActualEndDate""].Enbl=""true"";");
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mf_p1_actualdate (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MF_P1_ActualDate-OnChange");
if(ISpace["MF_P1_YearMonth"].Value!=0)
{
base.WriteDebugInfo(@"if(ISpace[""MF_P1_YearMonth""].Value!=0)");
if(ISpace["MF_P1_YearMonth"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""MF_P1_YearMonth""].Value==1)");
ISpace["MF_P1_ActualendDate"].Value=AddMonth(ISpace["MF_P1_ActualDate"].Value,ISpace["MF_P1_Duration"].Value);
base.WriteDebugInfo(@"ISpace[""MF_P1_ActualendDate""].Value=AddMonth(ISpace[""MF_P1_ActualDate""].Value,ISpace[""MF_P1_Duration""].Value);");
}
if(ISpace["MF_P1_YearMonth"].Value==2)
{
base.WriteDebugInfo(@"if(ISpace[""MF_P1_YearMonth""].Value==2)");
ISpace["MF_P1_ActualendDate"].Value=AddYear(ISpace["MF_P1_ActualDate"].Value,ISpace["MF_P1_Duration"].Value);
base.WriteDebugInfo(@"ISpace[""MF_P1_ActualendDate""].Value=AddYear(ISpace[""MF_P1_ActualDate""].Value,ISpace[""MF_P1_Duration""].Value);");
}
ISpace["MF_P1_ActualendDate"].Value=AddDay(ISpace["MF_P1_ActualendDate"].Value,-1);
base.WriteDebugInfo(@"ISpace[""MF_P1_ActualendDate""].Value=AddDay(ISpace[""MF_P1_ActualendDate""].Value,-1);");
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mf_p1_receiptamount (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MF_P1_ReceiptAmount-OnChange");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_P1_ReceiptAmount"].Value>ISpace["R_ReceiptAmountValidation"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_P1_ReceiptAmount""].Value>ISpace[""R_ReceiptAmountValidation""].Value)");
ISpace["Message"].Value=@"Fund Installment amount should be less than the Project Sanctioned Value.";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Fund Installment amount should be less than the Project Sanctioned Value."";");
ISpace["MF_P1_ReceiptAmount"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_P1_ReceiptAmount""].Value=null;");
return;
base.WriteDebugInfo(@"return;");
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["R_ReceiptAmountBalance"].Value=ISpace["MF_P1_ReceiptAmount"].Value;
base.WriteDebugInfo(@"ISpace[""R_ReceiptAmountBalance""].Value=ISpace[""MF_P1_ReceiptAmount""].Value;");
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_c_fc_projectno_15 (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"C_FC_ProjectNo_15-OnChange");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC GETReceiptAmountBalace 2,'#C_FC_ProjectNo_15'");

var querySource82426A40A87041909F2B6350B84FC4D6 =GetQueryExpressionDataSource("82426A40-A870-4190-9F2B-6350B84FC4D6");
Dictionary<short,object> result82426A40A87041909F2B6350B84FC4D6=iSpace.ExecuteQuery(querySource82426A40A87041909F2B6350B84FC4D6,@"EXEC GETReceiptAmountBalace 2,'" + ISpace["C_FC_ProjectNo_15"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource82426A40A87041909F2B6350B84FC4D6 =GetQueryExpressionDataSource(""82426A40-A870-4190-9F2B-6350B84FC4D6"");Dictionary<short,object> result82426A40A87041909F2B6350B84FC4D6=iSpace.ExecuteQuery(querySource82426A40A87041909F2B6350B84FC4D6,@""EXEC GETReceiptAmountBalace 2,'"" + ISpace[""C_FC_ProjectNo_15""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result82426A40A87041909F2B6350B84FC4D6!=null) && (result82426A40A87041909F2B6350B84FC4D6.Count!=0))
{
if(result82426A40A87041909F2B6350B84FC4D6.ContainsKey(2))
ISpace["C_FC_SanctionedDate_15"].Value = result82426A40A87041909F2B6350B84FC4D6[2];
if(result82426A40A87041909F2B6350B84FC4D6.ContainsKey(11))
ISpace["MF_P1_ActualDate"].Value = result82426A40A87041909F2B6350B84FC4D6[11];
if(result82426A40A87041909F2B6350B84FC4D6.ContainsKey(4))
ISpace["C_FC_EndDate"].Value = result82426A40A87041909F2B6350B84FC4D6[4];
if(result82426A40A87041909F2B6350B84FC4D6.ContainsKey(3))
ISpace["C_FC_StartDate_15"].Value = result82426A40A87041909F2B6350B84FC4D6[3];
if(result82426A40A87041909F2B6350B84FC4D6.ContainsKey(14))
ISpace["MF_P1_ActualEndDate"].Value = result82426A40A87041909F2B6350B84FC4D6[14];
if(result82426A40A87041909F2B6350B84FC4D6.ContainsKey(8))
ISpace["C_FC_SanctionedValue_15"].Value = result82426A40A87041909F2B6350B84FC4D6[8];
if(result82426A40A87041909F2B6350B84FC4D6.ContainsKey(12))
ISpace["MF_P1_YearMonth"].Value = result82426A40A87041909F2B6350B84FC4D6[12];
if(result82426A40A87041909F2B6350B84FC4D6.ContainsKey(10))
ISpace["MF_ProjectDetailsID"].Value = result82426A40A87041909F2B6350B84FC4D6[10];
if(result82426A40A87041909F2B6350B84FC4D6.ContainsKey(13))
ISpace["MF_P1_Duration"].Value = result82426A40A87041909F2B6350B84FC4D6[13];
if(result82426A40A87041909F2B6350B84FC4D6.ContainsKey(5))
ISpace["C_FC_SanctionNo_15"].Value = result82426A40A87041909F2B6350B84FC4D6[5];
if(result82426A40A87041909F2B6350B84FC4D6.ContainsKey(9))
ISpace["ProjectCode"].Value = result82426A40A87041909F2B6350B84FC4D6[9];
if(result82426A40A87041909F2B6350B84FC4D6.ContainsKey(7))
ISpace["C_FC_Category_15"].Value = result82426A40A87041909F2B6350B84FC4D6[7];
if(result82426A40A87041909F2B6350B84FC4D6.ContainsKey(1))
ISpace["C_FC_ProjectName_15"].Value = result82426A40A87041909F2B6350B84FC4D6[1];
if(result82426A40A87041909F2B6350B84FC4D6.ContainsKey(6))
ISpace["C_FC_AgencyCode_15"].Value = result82426A40A87041909F2B6350B84FC4D6[6];
}
else{
ISpace["C_FC_SanctionedDate_15"].Value = null;ISpace["MF_P1_ActualDate"].Value = null;ISpace["C_FC_EndDate"].Value = null;ISpace["C_FC_StartDate_15"].Value = null;ISpace["MF_P1_ActualEndDate"].Value = null;ISpace["C_FC_SanctionedValue_15"].Value = null;ISpace["MF_P1_YearMonth"].Value = null;ISpace["MF_ProjectDetailsID"].Value = null;ISpace["MF_P1_Duration"].Value = null;ISpace["C_FC_SanctionNo_15"].Value = null;ISpace["ProjectCode"].Value = null;ISpace["C_FC_Category_15"].Value = null;ISpace["C_FC_ProjectName_15"].Value = null;ISpace["C_FC_AgencyCode_15"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC GETReceiptAmountBalace 1,'#C_FC_ProjectNo_15'");

var querySource53963539D3EB42AC923B633B75334F3E =GetQueryExpressionDataSource("53963539-D3EB-42AC-923B-633B75334F3E");
Dictionary<short,object> result53963539D3EB42AC923B633B75334F3E=iSpace.ExecuteQuery(querySource53963539D3EB42AC923B633B75334F3E,@"EXEC GETReceiptAmountBalace 1,'" + ISpace["C_FC_ProjectNo_15"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource53963539D3EB42AC923B633B75334F3E =GetQueryExpressionDataSource(""53963539-D3EB-42AC-923B-633B75334F3E"");Dictionary<short,object> result53963539D3EB42AC923B633B75334F3E=iSpace.ExecuteQuery(querySource53963539D3EB42AC923B633B75334F3E,@""EXEC GETReceiptAmountBalace 1,'"" + ISpace[""C_FC_ProjectNo_15""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result53963539D3EB42AC923B633B75334F3E!=null) && (result53963539D3EB42AC923B633B75334F3E.Count!=0))
{
if(result53963539D3EB42AC923B633B75334F3E.ContainsKey(0))
ISpace["R_ReceiptAmountValidation"].Value = result53963539D3EB42AC923B633B75334F3E[0];
}
else{
ISpace["R_ReceiptAmountValidation"].Value = null;
}
}
ISpace["Subject"].Value=ISpace["C_FC_ProjectName_15"].Value;
base.WriteDebugInfo(@"ISpace[""Subject""].Value=ISpace[""C_FC_ProjectName_15""].Value;");
ISpace["MFG_R2_BudgetId"].rElemData=iSpace.Reload(ISpace["MFG_R2_BudgetId"].Value,@"EXEC SP_GetBudgetDetails  '" + ISpace["C_FC_ProjectNo_15"].Value + @"'","3A103712-5244-4427-B2B6-1C4E046FD337");
base.WriteDebugInfo(@"ISpace[""MFG_R2_BudgetId""].rElemData=iSpace.Reload(ISpace[""MFG_R2_BudgetId""].Value,@""EXEC SP_GetBudgetDetails  '"" + ISpace[""C_FC_ProjectNo_15""].Value + @""'"",""3A103712-5244-4427-B2B6-1C4E046FD337"");");
ISpace["M_MoveTo"].rElemData=iSpace.Reload(ISpace["M_MoveTo"].Value,@"EXEC GetMovetoValuesProjectFundInstallment 1,'" + ISpace["C_FC_Category_15"].Value + @"','" + ISpace["M_ActivityName"].Value + @"'","9ADED37B-CD11-426B-AF16-DEAC75685EF5");
base.WriteDebugInfo(@"ISpace[""M_MoveTo""].rElemData=iSpace.Reload(ISpace[""M_MoveTo""].Value,@""EXEC GetMovetoValuesProjectFundInstallment 1,'"" + ISpace[""C_FC_Category_15""].Value + @""','"" + ISpace[""M_ActivityName""].Value + @""'"",""9ADED37B-CD11-426B-AF16-DEAC75685EF5"");");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mf_p1_transferreferencedate (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MF_P1_TransferReferenceDate-OnChange");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_P1_TransferReferenceDate"].Value>ISpace["MF_P1_ReceiptDate"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_P1_TransferReferenceDate""].Value>ISpace[""MF_P1_ReceiptDate""].Value)");
ISpace["Message"].Value=@"Transfer Date should be less than or equal to Fund Installment Date or Actual Date";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Transfer Date should be less than or equal to Fund Installment Date or Actual Date"";");
ISpace["MF_P1_TransferReferenceDate"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_P1_TransferReferenceDate""].Value=null;");
return;
base.WriteDebugInfo(@"return;");
}
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
ISpace["SetDestinationTo"].Value=ISpace["M_MoveTo"].Value;
base.WriteDebugInfo(@"ISpace[""SetDestinationTo""].Value=ISpace[""M_MoveTo""].Value;");
ISpace["M_MoveToValue"].Value=ISpace["M_MoveTo"].Value;
base.WriteDebugInfo(@"ISpace[""M_MoveToValue""].Value=ISpace[""M_MoveTo""].Value;");
base.WriteDebugInfo(@"Exec GetStageStatus 1,'','','#M_MoveToValue','#M_SourceActivityMapId'");

var querySource566D32B365864115B5DB148796882A52 =GetQueryExpressionDataSource("566D32B3-6586-4115-B5DB-148796882A52");
Dictionary<short,object> result566D32B365864115B5DB148796882A52=iSpace.ExecuteQuery(querySource566D32B365864115B5DB148796882A52,@"Exec GetStageStatus 1,'','','" + ISpace["M_MoveToValue"].Value + @"','" + ISpace["M_SourceActivityMapId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource566D32B365864115B5DB148796882A52 =GetQueryExpressionDataSource(""566D32B3-6586-4115-B5DB-148796882A52"");Dictionary<short,object> result566D32B365864115B5DB148796882A52=iSpace.ExecuteQuery(querySource566D32B365864115B5DB148796882A52,@""Exec GetStageStatus 1,'','','"" + ISpace[""M_MoveToValue""].Value + @""','"" + ISpace[""M_SourceActivityMapId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result566D32B365864115B5DB148796882A52!=null) && (result566D32B365864115B5DB148796882A52.Count!=0))
{
if(result566D32B365864115B5DB148796882A52.ContainsKey(3))
ISpace["M_SaveDomainData"].Value = result566D32B365864115B5DB148796882A52[3];
if(result566D32B365864115B5DB148796882A52.ContainsKey(1))
ISpace["M_RemarksMandatory"].Value = result566D32B365864115B5DB148796882A52[1];
if(result566D32B365864115B5DB148796882A52.ContainsKey(4))
ISpace["M_FieldMandatory"].Value = result566D32B365864115B5DB148796882A52[4];
if(result566D32B365864115B5DB148796882A52.ContainsKey(5))
ISpace["M_IsflowReturned"].Value = result566D32B365864115B5DB148796882A52[5];
if(result566D32B365864115B5DB148796882A52.ContainsKey(6))
ISpace["M_IsCancelReject"].Value = result566D32B365864115B5DB148796882A52[6];
if(result566D32B365864115B5DB148796882A52.ContainsKey(7))
ISpace["M_Currentlevel"].Value = result566D32B365864115B5DB148796882A52[7];
if(result566D32B365864115B5DB148796882A52.ContainsKey(0))
ISpace["M_NextStage"].Value = result566D32B365864115B5DB148796882A52[0];
if(result566D32B365864115B5DB148796882A52.ContainsKey(2))
ISpace["M_Remarks"].Value = result566D32B365864115B5DB148796882A52[2];
}
else{
ISpace["M_SaveDomainData"].Value = null;ISpace["M_RemarksMandatory"].Value = null;ISpace["M_FieldMandatory"].Value = null;ISpace["M_IsflowReturned"].Value = null;ISpace["M_IsCancelReject"].Value = null;ISpace["M_Currentlevel"].Value = null;ISpace["M_NextStage"].Value = null;ISpace["M_Remarks"].Value = null;
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mf_p1_receiptdate (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MF_P1_ReceiptDate-OnChange");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_P1_ReceiptDate"].Value>CurrentDate())
{
base.WriteDebugInfo(@"if(ISpace[""MF_P1_ReceiptDate""].Value>CurrentDate())");
ISpace["Message"].Value=@"Fund Installment Date should be less than the current date.";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Fund Installment Date should be less than the current date."";");
ISpace["MF_P1_ReceiptDate"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_P1_ReceiptDate""].Value=null;");
return;
base.WriteDebugInfo(@"return;");
}
if(ISpace["MF_P1_ReceiptDate"].Value<ISpace["C_FC_StartDate_15"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_P1_ReceiptDate""].Value<ISpace[""C_FC_StartDate_15""].Value)");
ISpace["Message"].Value=@"Fund Installment Date should be greater than or equal to Starting Date or Actual Start Date";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Fund Installment Date should be greater than or equal to Starting Date or Actual Start Date"";");
ISpace["MF_P1_ReceiptDate"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_P1_ReceiptDate""].Value=null;");
return;
base.WriteDebugInfo(@"return;");
}
if(ISpace["MF_P1_ReceiptDate"].Value>=ISpace["C_FC_EndDate"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_P1_ReceiptDate""].Value>=ISpace[""C_FC_EndDate""].Value)");
ISpace["Message"].Value=@"Fund Installment Date should be less than Closing Date  or Actual End Date";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Fund Installment Date should be less than Closing Date  or Actual End Date"";");
ISpace["MF_P1_ReceiptDate"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_P1_ReceiptDate""].Value=null;");
return;
base.WriteDebugInfo(@"return;");
}
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mfg_r2_amount (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MFG_R2_Amount-OnChange");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"exec ValidateBudgetHeadAmount '#C_FC_ProjectNo_15','#MFG_R2_BudgetId','#MFG_R2_Amount'");

var querySource526137CD61B5430FB81FF00B94BC6A8E =GetQueryExpressionDataSource("526137CD-61B5-430F-B81F-F00B94BC6A8E");
Dictionary<short,object> result526137CD61B5430FB81FF00B94BC6A8E=iSpace.ExecuteQuery(querySource526137CD61B5430FB81FF00B94BC6A8E,@"exec ValidateBudgetHeadAmount '" + ISpace["C_FC_ProjectNo_15"].Value + @"','" + ISpace["MFG_R2_BudgetId"].Value + @"','" + ISpace["MFG_R2_Amount"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource526137CD61B5430FB81FF00B94BC6A8E =GetQueryExpressionDataSource(""526137CD-61B5-430F-B81F-F00B94BC6A8E"");Dictionary<short,object> result526137CD61B5430FB81FF00B94BC6A8E=iSpace.ExecuteQuery(querySource526137CD61B5430FB81FF00B94BC6A8E,@""exec ValidateBudgetHeadAmount '"" + ISpace[""C_FC_ProjectNo_15""].Value + @""','"" + ISpace[""MFG_R2_BudgetId""].Value + @""','"" + ISpace[""MFG_R2_Amount""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result526137CD61B5430FB81FF00B94BC6A8E!=null) && (result526137CD61B5430FB81FF00B94BC6A8E.Count!=0))
{
if(result526137CD61B5430FB81FF00B94BC6A8E.ContainsKey(0))
ISpace["M_BudgetErr"].Value = result526137CD61B5430FB81FF00B94BC6A8E[0];
if(result526137CD61B5430FB81FF00B94BC6A8E.ContainsKey(1))
ISpace["M_BudgetErrMsg"].Value = result526137CD61B5430FB81FF00B94BC6A8E[1];
}
else{
ISpace["M_BudgetErr"].Value = null;ISpace["M_BudgetErrMsg"].Value = null;
}
if(ISpace["M_BudgetErr"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""M_BudgetErr""].Value==1)");
ISpace["Message"].Value=String.Format(@"{0}",ISpace["M_BudgetErrMsg"].Value);
base.WriteDebugInfo(@"ISpace[""Message""].Value=String.Format(@""{0}"",ISpace[""M_BudgetErrMsg""].Value);");
return;
base.WriteDebugInfo(@"return;");
}
}
if(1==2)
{
base.WriteDebugInfo(@"if(1==2)");
if(ISpace["MFG_R2_Amount"].Value>ISpace["R_ReceiptAmountBalance"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MFG_R2_Amount""].Value>ISpace[""R_ReceiptAmountBalance""].Value)");
ISpace["Message"].Value=@"Splitup Amount Should be less than or equal to Fund Installment Amount";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Splitup Amount Should be less than or equal to Fund Installment Amount"";");
ISpace["MFG_R2_Amount"].Value=null;
base.WriteDebugInfo(@"ISpace[""MFG_R2_Amount""].Value=null;");
return;
base.WriteDebugInfo(@"return;");
}
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_save_receiptsplitup (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Save_ReceiptSplitUp-OnClick");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(Trim(ISpace["MFG_R2_BudgetId"].Value)=="")
{
base.WriteDebugInfo(@"if(Trim(ISpace[""MFG_R2_BudgetId""].Value)=="""")");
ISpace["Message"].Value=@"Please Enter the Budget Head";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please Enter the Budget Head"";");
return;
base.WriteDebugInfo(@"return;");
}
if(ISpace["MFG_R2_Amount"].Value==0)
{
base.WriteDebugInfo(@"if(ISpace[""MFG_R2_Amount""].Value==0)");
ISpace["Message"].Value=@"Please Enter the Amount";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please Enter the Amount"";");
return;
base.WriteDebugInfo(@"return;");
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["MF_P1_ReceiptAmount"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""MF_P1_ReceiptAmount""].Enbl=""false"";");
}
if(1==2)
{
base.WriteDebugInfo(@"if(1==2)");
base.WriteDebugInfo(@"#ReceiptSplitUp[Rows]");
iSpace.GetLoopExpressionData("ReceiptSplitUp",ref ISpace);

foreach(var gridChild in ISpace["ReceiptSplitUp"].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 



ISpace["M_Budgetid"].Value=ISpace["MG_R2_BudgetId"].Value;
base.WriteDebugInfo(@"

ISpace[""M_Budgetid""].Value=ISpace[""MG_R2_BudgetId""].Value;");


ISpace["M_R2_ReceiptSplitUpId"].Value=ISpace["MG_R2_ReceiptSplitUpId"].Value;
base.WriteDebugInfo(@"

ISpace[""M_R2_ReceiptSplitUpId""].Value=ISpace[""MG_R2_ReceiptSplitUpId""].Value;");

if(
ISpace["Editflag"].Value==1)
{
base.WriteDebugInfo(@"
if(
ISpace[""Editflag""].Value==1)");
if(ISpace["M_Budgetid"].Value==ISpace["MFG_R2_BudgetId"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""M_Budgetid""].Value==ISpace[""MFG_R2_BudgetId""].Value)");
ISpace["Message"].Value=@"This Budget head is already added";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""This Budget head is already added"";");
return;
base.WriteDebugInfo(@"return;");
}
}
else
{
base.WriteDebugInfo(@"else");
if(ISpace["M_Budgetid"].Value==ISpace["MFG_R2_BudgetId"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""M_Budgetid""].Value==ISpace[""MFG_R2_BudgetId""].Value)");
ISpace["Message"].Value=@"This Budget head is already added";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""This Budget head is already added"";");
return;
base.WriteDebugInfo(@"return;");
}
}
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("ReceiptSplitUp","249EF445-9B49-4EF9-8045-46BD1E6FF8ED",_objectFactory.GetGridRPP("ReceiptSplitUp"),_elementBase.GetGridLoopQuery("249EF445-9B49-4EF9-8045-46BD1E6FF8ED","ReceiptSplitUp",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""ReceiptSplitUp"",ref ISpace);

foreach(var gridChild in ISpace[""ReceiptSplitUp""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"exec ValidateBudgetHeadAmount '#C_FC_ProjectNo_15','#MFG_R2_BudgetId','#MFG_R2_Amount'");

var querySource526137CD61B5430FB81FF00B94BC6A8E =GetQueryExpressionDataSource("526137CD-61B5-430F-B81F-F00B94BC6A8E");
Dictionary<short,object> result526137CD61B5430FB81FF00B94BC6A8E=iSpace.ExecuteQuery(querySource526137CD61B5430FB81FF00B94BC6A8E,@"exec ValidateBudgetHeadAmount '" + ISpace["C_FC_ProjectNo_15"].Value + @"','" + ISpace["MFG_R2_BudgetId"].Value + @"','" + ISpace["MFG_R2_Amount"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource526137CD61B5430FB81FF00B94BC6A8E =GetQueryExpressionDataSource(""526137CD-61B5-430F-B81F-F00B94BC6A8E"");Dictionary<short,object> result526137CD61B5430FB81FF00B94BC6A8E=iSpace.ExecuteQuery(querySource526137CD61B5430FB81FF00B94BC6A8E,@""exec ValidateBudgetHeadAmount '"" + ISpace[""C_FC_ProjectNo_15""].Value + @""','"" + ISpace[""MFG_R2_BudgetId""].Value + @""','"" + ISpace[""MFG_R2_Amount""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result526137CD61B5430FB81FF00B94BC6A8E!=null) && (result526137CD61B5430FB81FF00B94BC6A8E.Count!=0))
{
if(result526137CD61B5430FB81FF00B94BC6A8E.ContainsKey(0))
ISpace["M_BudgetErr"].Value = result526137CD61B5430FB81FF00B94BC6A8E[0];
if(result526137CD61B5430FB81FF00B94BC6A8E.ContainsKey(1))
ISpace["M_BudgetErrMsg"].Value = result526137CD61B5430FB81FF00B94BC6A8E[1];
}
else{
ISpace["M_BudgetErr"].Value = null;ISpace["M_BudgetErrMsg"].Value = null;
}
if(ISpace["M_BudgetErr"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""M_BudgetErr""].Value==1)");
ISpace["Message"].Value=String.Format(@"{0}",ISpace["M_BudgetErrMsg"].Value);
base.WriteDebugInfo(@"ISpace[""Message""].Value=String.Format(@""{0}"",ISpace[""M_BudgetErrMsg""].Value);");
return;
base.WriteDebugInfo(@"return;");
}
}
if(1==2)
{
base.WriteDebugInfo(@"if(1==2)");
if(ISpace["MFG_R2_Amount"].Value>ISpace["R_ReceiptAmountBalance"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MFG_R2_Amount""].Value>ISpace[""R_ReceiptAmountBalance""].Value)");
ISpace["Message"].Value=@"Splitup Amount Should be less than or equal to Fund Installment Amount";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Splitup Amount Should be less than or equal to Fund Installment Amount"";");
ISpace["MFG_R2_Amount"].Value=null;
base.WriteDebugInfo(@"ISpace[""MFG_R2_Amount""].Value=null;");
return;
base.WriteDebugInfo(@"return;");
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"#ReceiptSplitUp[rows]");
iSpace.GetLoopExpressionData("ReceiptSplitUp",ref ISpace);

foreach(var gridChild in ISpace["ReceiptSplitUp"].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 


if(


ISpace["growid"].Value!=ISpace["ReceiptSplitUp_RowId"].Value||ISpace["growid"].Value=="")
{
base.WriteDebugInfo(@"
if(


ISpace[""growid""].Value!=ISpace[""ReceiptSplitUp_RowId""].Value||ISpace[""growid""].Value=="""")");
if(ISpace["MFG_R2_BudgetId"].Value==ISpace["MG_R2_BudgetId"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MFG_R2_BudgetId""].Value==ISpace[""MG_R2_BudgetId""].Value)");
ISpace["Message"].Value=@"Budget Head is already Exists";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Budget Head is already Exists"";");
ISpace["MFG_R2_BudgetId"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_R2_BudgetId""].Value="""";");
return;
base.WriteDebugInfo(@"return;");
}
}
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("ReceiptSplitUp","249EF445-9B49-4EF9-8045-46BD1E6FF8ED",_objectFactory.GetGridRPP("ReceiptSplitUp"),_elementBase.GetGridLoopQuery("249EF445-9B49-4EF9-8045-46BD1E6FF8ED","ReceiptSplitUp",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""ReceiptSplitUp"",ref ISpace);

foreach(var gridChild in ISpace[""ReceiptSplitUp""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
}
if(ISpace["MFG_R2_ReceiptSplitUpId"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""MFG_R2_ReceiptSplitUpId""].Value=="""")");
ISpace["MFG_R2_ReceiptSplitUpId"].Value=Guid.NewGuid().ToString();
base.WriteDebugInfo(@"ISpace[""MFG_R2_ReceiptSplitUpId""].Value=Guid.NewGuid().ToString();");
}
if(ISpace["growid"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""growid""].Value=="""")");

var querySource490A453A68524615B83B173BC38F190B =GetQueryExpressionDataSource("490A453A-6852-4615-B83B-173BC38F190B");

DataTable result490A453A68524615B83B173BC38F190B=iSpace.SetGridDataSource(querySource490A453A68524615B83B173BC38F190B, _objectFactory.GetGridRPP("ReceiptSplitUp"),@"EXEC AddFormGridDatacc29fcb5b804498f8b8407ad780fb5af '" + ISpace["Instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','cc29fcb5-b804-498f-8b84-07ad780fb5af','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["MFG_R2_ReceiptSplitUpId"].Value + @"','" + ISpace["MFG_R2_ReceiptsId"].Value + @"','" + ISpace["MFG_R2_BudgetId"].Value + @"'," + ISpace["MFG_R2_Amount"].Value + @"," + ISpace["gv_userid"].Value + @",'" + ISpace["MFG_R2_UpdatedOn"].Value + @"','" + ISpace["growid"].Value + @"'");

iSpace.InsertGridBindDetails("ReceiptSplitUp","11",querySource490A453A68524615B83B173BC38F190B,"EXEC AddFormGridDatacc29fcb5b804498f8b8407ad780fb5af '" + ISpace["Instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','cc29fcb5-b804-498f-8b84-07ad780fb5af','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["MFG_R2_ReceiptSplitUpId"].Value + @"','" + ISpace["MFG_R2_ReceiptsId"].Value + @"','" + ISpace["MFG_R2_BudgetId"].Value + @"'," + ISpace["MFG_R2_Amount"].Value + @"," + ISpace["gv_userid"].Value + @",'" + ISpace["MFG_R2_UpdatedOn"].Value + @"','" + ISpace["growid"].Value + @"'",_objectFactory.GetGridRPP("ReceiptSplitUp"));

base.WriteDebugInfo(@"var querySource490A453A68524615B83B173BC38F190B =GetQueryExpressionDataSource(""490A453A-6852-4615-B83B-173BC38F190B"");DataTable result490A453A68524615B83B173BC38F190B=iSpace.SetGridDataSource(querySource490A453A68524615B83B173BC38F190B, _objectFactory.GetGridRPP(""ReceiptSplitUp""),@""EXEC AddFormGridDatacc29fcb5b804498f8b8407ad780fb5af '"" + ISpace[""Instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','cc29fcb5-b804-498f-8b84-07ad780fb5af','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""MFG_R2_ReceiptSplitUpId""].Value + @""','"" + ISpace[""MFG_R2_ReceiptsId""].Value + @""','"" + ISpace[""MFG_R2_BudgetId""].Value + @""',"" + ISpace[""MFG_R2_Amount""].Value + @"","" + ISpace[""gv_userid""].Value + @"",'"" + ISpace[""MFG_R2_UpdatedOn""].Value + @""','"" + ISpace[""growid""].Value + @""'"");iSpace.InsertGridBindDetails(""ReceiptSplitUp"",""11"",querySource490A453A68524615B83B173BC38F190B,""EXEC AddFormGridDatacc29fcb5b804498f8b8407ad780fb5af '"" + ISpace[""Instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','cc29fcb5-b804-498f-8b84-07ad780fb5af','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""MFG_R2_ReceiptSplitUpId""].Value + @""','"" + ISpace[""MFG_R2_ReceiptsId""].Value + @""','"" + ISpace[""MFG_R2_BudgetId""].Value + @""',"" + ISpace[""MFG_R2_Amount""].Value + @"","" + ISpace[""gv_userid""].Value + @"",'"" + ISpace[""MFG_R2_UpdatedOn""].Value + @""','"" + ISpace[""growid""].Value + @""'"",_objectFactory.GetGridRPP(""ReceiptSplitUp""));");
base.WriteDebugInfo(@"EXEC AddFormGridDatacc29fcb5b804498f8b8407ad780fb5af '@@gv_InstanceId','@@gv_ProcessMapId','cc29fcb5-b804-498f-8b84-07ad780fb5af','@@gv_ActivityMapId','#MFG_R2_ReceiptSplitUpId','#MFG_R2_ReceiptsId',#MFG_R2_BudgetId,#MFG_R2_Amount,#MFG_R2_UpdatedBy,#MFG_R2_UpdatedOn,'#growid'");


List<Triplet<string, short, short?>> result68E47F7523D14580ABFCB23D3E6D49FF=acdataIspace2B40E332984042E38DDC002EAFAA05FA.GetQueryExpressionBindings("68E47F75-23D1-4580-ABFC-B23D3E6D49FF");
iSpace.SetGridData(result490A453A68524615B83B173BC38F190B,result68E47F7523D14580ABFCB23D3E6D49FF,"ReceiptSplitUp",ref ISpace);
iSpace.UpdateGridBindDetails("ReceiptSplitUp",result68E47F7523D14580ABFCB23D3E6D49FF);
}
else
{
base.WriteDebugInfo(@"else");

var querySourceC102915BAF5144F9A85E2C1A53654BCF =GetQueryExpressionDataSource("C102915B-AF51-44F9-A85E-2C1A53654BCF");

DataTable resultC102915BAF5144F9A85E2C1A53654BCF=iSpace.SetGridDataSource(querySourceC102915BAF5144F9A85E2C1A53654BCF, _objectFactory.GetGridRPP("ReceiptSplitUp"),@"EXEC UpdateFormGridDatacc29fcb5b804498f8b8407ad780fb5af '" + ISpace["Instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','cc29fcb5-b804-498f-8b84-07ad780fb5af','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["MFG_R2_ReceiptSplitUpId"].Value + @"','" + ISpace["MFG_R2_ReceiptsId"].Value + @"','" + ISpace["MFG_R2_BudgetId"].Value + @"'," + ISpace["MFG_R2_Amount"].Value + @"," + ISpace["MFG_R2_UpdatedBy"].Value + @",'" + ISpace["MFG_R2_UpdatedOn"].Value + @"','" + ISpace["growid"].Value + @"'");

iSpace.InsertGridBindDetails("ReceiptSplitUp","11",querySourceC102915BAF5144F9A85E2C1A53654BCF,"EXEC UpdateFormGridDatacc29fcb5b804498f8b8407ad780fb5af '" + ISpace["Instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','cc29fcb5-b804-498f-8b84-07ad780fb5af','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["MFG_R2_ReceiptSplitUpId"].Value + @"','" + ISpace["MFG_R2_ReceiptsId"].Value + @"','" + ISpace["MFG_R2_BudgetId"].Value + @"'," + ISpace["MFG_R2_Amount"].Value + @"," + ISpace["MFG_R2_UpdatedBy"].Value + @",'" + ISpace["MFG_R2_UpdatedOn"].Value + @"','" + ISpace["growid"].Value + @"'",_objectFactory.GetGridRPP("ReceiptSplitUp"));

base.WriteDebugInfo(@"var querySourceC102915BAF5144F9A85E2C1A53654BCF =GetQueryExpressionDataSource(""C102915B-AF51-44F9-A85E-2C1A53654BCF"");DataTable resultC102915BAF5144F9A85E2C1A53654BCF=iSpace.SetGridDataSource(querySourceC102915BAF5144F9A85E2C1A53654BCF, _objectFactory.GetGridRPP(""ReceiptSplitUp""),@""EXEC UpdateFormGridDatacc29fcb5b804498f8b8407ad780fb5af '"" + ISpace[""Instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','cc29fcb5-b804-498f-8b84-07ad780fb5af','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""MFG_R2_ReceiptSplitUpId""].Value + @""','"" + ISpace[""MFG_R2_ReceiptsId""].Value + @""','"" + ISpace[""MFG_R2_BudgetId""].Value + @""',"" + ISpace[""MFG_R2_Amount""].Value + @"","" + ISpace[""MFG_R2_UpdatedBy""].Value + @"",'"" + ISpace[""MFG_R2_UpdatedOn""].Value + @""','"" + ISpace[""growid""].Value + @""'"");iSpace.InsertGridBindDetails(""ReceiptSplitUp"",""11"",querySourceC102915BAF5144F9A85E2C1A53654BCF,""EXEC UpdateFormGridDatacc29fcb5b804498f8b8407ad780fb5af '"" + ISpace[""Instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','cc29fcb5-b804-498f-8b84-07ad780fb5af','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""MFG_R2_ReceiptSplitUpId""].Value + @""','"" + ISpace[""MFG_R2_ReceiptsId""].Value + @""','"" + ISpace[""MFG_R2_BudgetId""].Value + @""',"" + ISpace[""MFG_R2_Amount""].Value + @"","" + ISpace[""MFG_R2_UpdatedBy""].Value + @"",'"" + ISpace[""MFG_R2_UpdatedOn""].Value + @""','"" + ISpace[""growid""].Value + @""'"",_objectFactory.GetGridRPP(""ReceiptSplitUp""));");
base.WriteDebugInfo(@"EXEC UpdateFormGridDatacc29fcb5b804498f8b8407ad780fb5af '@@gv_InstanceId','@@gv_ProcessMapId','cc29fcb5-b804-498f-8b84-07ad780fb5af','@@gv_ActivityMapId','#MFG_R2_ReceiptSplitUpId','#MFG_R2_ReceiptsId',#MFG_R2_BudgetId,#MFG_R2_Amount,#MFG_R2_UpdatedBy,#MFG_R2_UpdatedOn,'#growid'");


List<Triplet<string, short, short?>> resultCA26392720D64C629E9F015B3ED8015D=acdataIspace2B40E332984042E38DDC002EAFAA05FA.GetQueryExpressionBindings("CA263927-20D6-4C62-9E9F-015B3ED8015D");
iSpace.SetGridData(resultC102915BAF5144F9A85E2C1A53654BCF,resultCA26392720D64C629E9F015B3ED8015D,"ReceiptSplitUp",ref ISpace);
iSpace.UpdateGridBindDetails("ReceiptSplitUp",resultCA26392720D64C629E9F015B3ED8015D);
}
object MG_R2_Amount=iSpace.Sum("[249EF445-9B49-4EF9-8045-46BD1E6FF8ED]","MG_R2_Amount","");
ISpace["R_TotalSplitUpAmount"].Value=Convert.ChangeType(MG_R2_Amount, MG_R2_Amount.GetType());;
base.WriteDebugInfo(@"object MG_R2_Amount=iSpace.Sum(""[249EF445-9B49-4EF9-8045-46BD1E6FF8ED]"",""MG_R2_Amount"","""");
ISpace[""R_TotalSplitUpAmount""].Value=Convert.ChangeType(MG_R2_Amount, MG_R2_Amount.GetType());;");
ISpace["growid"].Value="";
base.WriteDebugInfo(@"ISpace[""growid""].Value="""";");
ISpace["MFG_R2_ReceiptSplitUpId"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_R2_ReceiptSplitUpId""].Value="""";");
ISpace["MFG_R2_ReceiptsId"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_R2_ReceiptsId""].Value="""";");
ISpace["MFG_R2_BudgetId"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_R2_BudgetId""].Value="""";");
ISpace["MFG_R2_Amount"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_R2_Amount""].Value="""";");
ISpace["MFG_R2_UpdatedBy"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_R2_UpdatedBy""].Value="""";");
ISpace["MFG_R2_UpdatedOn"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_R2_UpdatedOn""].Value="""";");
ISpace["Editflag"].Value=null;
base.WriteDebugInfo(@"ISpace[""Editflag""].Value=null;");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["R_ReceiptAmountBalance"].Value=ISpace["MF_P1_ReceiptAmount"].Value - ISpace["R_TotalSplitUpAmount"].Value;
base.WriteDebugInfo(@"ISpace[""R_ReceiptAmountBalance""].Value=ISpace[""MF_P1_ReceiptAmount""].Value - ISpace[""R_TotalSplitUpAmount""].Value;");
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_delete (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Delete-OnClick");
ISpace["growid"].Value=ISpace["ReceiptSplitUp_RowId"].Value;
base.WriteDebugInfo(@"ISpace[""growid""].Value=ISpace[""ReceiptSplitUp_RowId""].Value;");
ISpace["UI_DeleteDialog"].ShowDialog=true;;
base.WriteDebugInfo(@"ISpace[""UI_DeleteDialog""].ShowDialog=true;;");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_edit_receiptsplitup (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Edit_ReceiptSplitUp-OnClick");
ISpace["growid"].Value=ISpace["ReceiptSplitUp_RowId"].Value;
base.WriteDebugInfo(@"ISpace[""growid""].Value=ISpace[""ReceiptSplitUp_RowId""].Value;");
ISpace["Editflag"].Value=null;
base.WriteDebugInfo(@"ISpace[""Editflag""].Value=null;");
ISpace["Editflag"].Value=1;
base.WriteDebugInfo(@"ISpace[""Editflag""].Value=1;");
if(ISpace["growid"].Value!=ISpace["MFG_R2_ReceiptSplitUpId"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""growid""].Value!=ISpace[""MFG_R2_ReceiptSplitUpId""].Value)");
ISpace["R_TotalSplitUpAmount"].Value=ISpace["R_TotalSplitUpAmount"].Value-ISpace["MG_R2_Amount"].Value;
base.WriteDebugInfo(@"ISpace[""R_TotalSplitUpAmount""].Value=ISpace[""R_TotalSplitUpAmount""].Value-ISpace[""MG_R2_Amount""].Value;");
ISpace["R_ReceiptAmountBalance"].Value=ISpace["R_ReceiptAmountBalance"].Value+ISpace["MG_R2_Amount"].Value;
base.WriteDebugInfo(@"ISpace[""R_ReceiptAmountBalance""].Value=ISpace[""R_ReceiptAmountBalance""].Value+ISpace[""MG_R2_Amount""].Value;");
}
base.WriteDebugInfo(@"EXEC LoadFormGridDatacc29fcb5b804498f8b8407ad780fb5af '#Instanceid','@@gv_ProcessMapId','cc29fcb5-b804-498f-8b84-07ad780fb5af','@@gv_ActivityMapId','#growid'");

var querySourceA5DC182250F5461FAA7F4043FAB5724D =GetQueryExpressionDataSource("A5DC1822-50F5-461F-AA7F-4043FAB5724D");
Dictionary<short,object> resultA5DC182250F5461FAA7F4043FAB5724D=iSpace.ExecuteQuery(querySourceA5DC182250F5461FAA7F4043FAB5724D,@"EXEC LoadFormGridDatacc29fcb5b804498f8b8407ad780fb5af '" + ISpace["Instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','cc29fcb5-b804-498f-8b84-07ad780fb5af','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["growid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceA5DC182250F5461FAA7F4043FAB5724D =GetQueryExpressionDataSource(""A5DC1822-50F5-461F-AA7F-4043FAB5724D"");Dictionary<short,object> resultA5DC182250F5461FAA7F4043FAB5724D=iSpace.ExecuteQuery(querySourceA5DC182250F5461FAA7F4043FAB5724D,@""EXEC LoadFormGridDatacc29fcb5b804498f8b8407ad780fb5af '"" + ISpace[""Instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','cc29fcb5-b804-498f-8b84-07ad780fb5af','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""growid""].Value + @""'"",false);");
base.WriteDebugInfo(@"EXEC LoadFormGridDatacc29fcb5b804498f8b8407ad780fb5af '@@gv_InstanceId','@@gv_ProcessMapId','cc29fcb5-b804-498f-8b84-07ad780fb5af','@@gv_ActivityMapId','#growid'");

if((resultA5DC182250F5461FAA7F4043FAB5724D!=null) && (resultA5DC182250F5461FAA7F4043FAB5724D.Count!=0))
{
if(resultA5DC182250F5461FAA7F4043FAB5724D.ContainsKey(5))
ISpace["MFG_R2_UpdatedOn"].Value = resultA5DC182250F5461FAA7F4043FAB5724D[5];
if(resultA5DC182250F5461FAA7F4043FAB5724D.ContainsKey(2))
ISpace["MFG_R2_BudgetId"].Value = resultA5DC182250F5461FAA7F4043FAB5724D[2];
if(resultA5DC182250F5461FAA7F4043FAB5724D.ContainsKey(4))
ISpace["MFG_R2_UpdatedBy"].Value = resultA5DC182250F5461FAA7F4043FAB5724D[4];
if(resultA5DC182250F5461FAA7F4043FAB5724D.ContainsKey(3))
ISpace["MFG_R2_Amount"].Value = resultA5DC182250F5461FAA7F4043FAB5724D[3];
if(resultA5DC182250F5461FAA7F4043FAB5724D.ContainsKey(1))
ISpace["MFG_R2_ReceiptsId"].Value = resultA5DC182250F5461FAA7F4043FAB5724D[1];
if(resultA5DC182250F5461FAA7F4043FAB5724D.ContainsKey(6))
ISpace["MFG_R2_ReceiptSplitUpId"].Value = resultA5DC182250F5461FAA7F4043FAB5724D[6];
}
else{
ISpace["MFG_R2_UpdatedOn"].Value = null;ISpace["MFG_R2_BudgetId"].Value = null;ISpace["MFG_R2_UpdatedBy"].Value = null;ISpace["MFG_R2_Amount"].Value = null;ISpace["MFG_R2_ReceiptsId"].Value = null;ISpace["MFG_R2_ReceiptSplitUpId"].Value = null;
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_add (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Add-OnClick");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

if(ISpace["FormVersionId"].Value=="B1CB93DB-7B9C-4661-BE11-02ED3BFD5725")
{
iSpace.SetUIControlProperty("UI_AvailablebudgetModal","ShowModal","true",ref  ISpace);;
}

base.WriteDebugInfo(@"
if(ISpace[""FormVersionId""].Value==""B1CB93DB-7B9C-4661-BE11-02ED3BFD5725"")
{
iSpace.SetUIControlProperty(""UI_AvailablebudgetModal"",""ShowModal"",""true"",ref  ISpace);;
}
");
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
		if(elementName.ToLower().Equals("mg_r2_amount"))
    {
    			SubscribeElementEvents_mg_r2_amount(ref dfsParam);
    }
		if(elementName.ToLower().Equals("c_fc_sanctionno_15"))
    {
    			SubscribeElementEvents_c_fc_sanctionno_15(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mf_p1_actualdate"))
    {
    			SubscribeElementEvents_mf_p1_actualdate(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mf_p1_receiptamount"))
    {
    			SubscribeElementEvents_mf_p1_receiptamount(ref dfsParam);
    }
		if(elementName.ToLower().Equals("c_fc_projectno_15"))
    {
    			SubscribeElementEvents_c_fc_projectno_15(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mf_p1_transferreferencedate"))
    {
    			SubscribeElementEvents_mf_p1_transferreferencedate(ref dfsParam);
    }
		if(elementName.ToLower().Equals("m_moveto"))
    {
    			SubscribeElementEvents_m_moveto(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mf_p1_receiptdate"))
    {
    			SubscribeElementEvents_mf_p1_receiptdate(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mfg_r2_amount"))
    {
    			SubscribeElementEvents_mfg_r2_amount(ref dfsParam);
    }
}
	if(methodName.ToLower().Equals("onclick"))
{
		if(elementName.ToLower().Equals("submitform"))
{
			SubscribeElementEvents_submitform(ref dfsParam);
}
		if(elementName.ToLower().Equals("save_receiptsplitup"))
{
			SubscribeElementEvents_save_receiptsplitup(ref dfsParam);
}
		if(elementName.ToLower().Equals("delete"))
{
			SubscribeElementEvents_delete(ref dfsParam);
}
		if(elementName.ToLower().Equals("edit_receiptsplitup"))
{
			SubscribeElementEvents_edit_receiptsplitup(ref dfsParam);
}
		if(elementName.ToLower().Equals("add"))
{
			SubscribeElementEvents_add(ref dfsParam);
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

using System.Collections.Generic;
using System;
using CPS.Proof.DFSExtension;
using System.Linq;using System.Data;
using System.Runtime.CompilerServices;
public class ISpace537084A67B724CBEA0A2057049686345 : VirtualForm
{
IISpace iSpace = new ISpace();
AcDataISpace537084A67B724CBEA0A2057049686345 acdataIspace537084A67B724CBEA0A2057049686345=new AcDataISpace537084A67B724CBEA0A2057049686345();
private void SubscribeFormEvents_root(ref Dictionary<string, ServiceElementData> ISpace)
{
try
{
base.WriteDebugInfo(@"Root-OnAfterFormLoad");
if(ISpace["FormVersionId"].Value=="B1CB93DB-7B9C-4661-BE11-02ED3BFD5725")
{
ISpace["UI_BudgetPanelBody"].Visible="false";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""B1CB93DB-7B9C-4661-BE11-02ED3BFD5725"")
{
ISpace[""UI_BudgetPanelBody""].Visible=""false"";
}");
ISpace["Delete"].Visible="false";ISpace["Edit_ReceiptSplitUp"].Visible="false";
base.WriteDebugInfo(@"ISpace[""Delete""].Visible=""false"";ISpace[""Edit_ReceiptSplitUp""].Visible=""false"";");
if((ISpace["MF_P1_ActualDate"].Value == null))
{
base.WriteDebugInfo(@"if((ISpace[""MF_P1_ActualDate""].Value == null))");
ISpace["MF_P1_ActualEndDate"].Visible="false";
base.WriteDebugInfo(@"ISpace[""MF_P1_ActualEndDate""].Visible=""false"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_P1_ActualEndDate"].Visible="true";
base.WriteDebugInfo(@"ISpace[""MF_P1_ActualEndDate""].Visible=""true"";");
}
ISpace["M_SourceActivityMapId"].Value=ISpace["gv_activitymapid"].Value;
base.WriteDebugInfo(@"ISpace[""M_SourceActivityMapId""].Value=ISpace[""gv_activitymapid""].Value;");
ISpace["M_PackageProcessMapId"].Value=ISpace["gv_processmapid"].Value;
base.WriteDebugInfo(@"ISpace[""M_PackageProcessMapId""].Value=ISpace[""gv_processmapid""].Value;");
ISpace["M_InstanceId"].Value=ISpace["gv_instanceid"].Value;
base.WriteDebugInfo(@"ISpace[""M_InstanceId""].Value=ISpace[""gv_instanceid""].Value;");
ISpace["M_IsSourceStep"].Value=0;
base.WriteDebugInfo(@"ISpace[""M_IsSourceStep""].Value=0;");
ISpace["M_ActivityName"].Value=ISpace["gv_activityname"].Value;
base.WriteDebugInfo(@"ISpace[""M_ActivityName""].Value=ISpace[""gv_activityname""].Value;");
ISpace["M_MoveTo"].Man=true;
base.WriteDebugInfo(@"ISpace[""M_MoveTo""].Man=true;");
ISpace["M_Remarks"].Value="";
base.WriteDebugInfo(@"ISpace[""M_Remarks""].Value="""";");
ISpace["M_NextStage"].Value="";
base.WriteDebugInfo(@"ISpace[""M_NextStage""].Value="""";");
ISpace["UC_PhoneNumber"].Visible="false";ISpace["UC_DOB"].Visible="false";ISpace["UC_DOR"].Visible="false";ISpace["UC_Paylevel"].Visible="false";ISpace["UC_EmailId"].Visible="false";ISpace["UC_Grade"].Visible="false";ISpace["UC_DOJ"].Visible="false";
base.WriteDebugInfo(@"ISpace[""UC_PhoneNumber""].Visible=""false"";ISpace[""UC_DOB""].Visible=""false"";ISpace[""UC_DOR""].Visible=""false"";ISpace[""UC_Paylevel""].Visible=""false"";ISpace[""UC_EmailId""].Visible=""false"";ISpace[""UC_Grade""].Visible=""false"";ISpace[""UC_DOJ""].Visible=""false"";");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["MFG_R2_ReceiptSplitUpId"].Visible="false";ISpace["MF_P1_TransferReferenceBankId"].Visible="true";ISpace["MF_P1_TransferReferenceBranch"].Visible="true";ISpace["MF_P1_ReceiptAmount"].Visible="true";ISpace["MF_P1_TransferType"].Visible="true";ISpace["MF_P1_TransferReferenceNumber"].Visible="true";ISpace["MF_P1_Status"].Visible="false";ISpace["MF_P1_ReceiptNo"].Visible="true";ISpace["MF_P1_ProjectDetailsId"].Visible="true";ISpace["MF_P1_UpdatedOn"].Visible="false";ISpace["MF_P1_TransferReferenceDate"].Visible="true";ISpace["MFG_R2_UpdatedBy"].Visible="false";ISpace["MF_P1_ReceiptsId"].Visible="true";ISpace["MF_P1_ReceiptDate"].Visible="true";ISpace["MF_P1_UpdatedBy"].Visible="false";ISpace["MFG_R2_Amount"].Visible="true";ISpace["MFG_R2_UpdatedOn"].Visible="false";ISpace["MFG_R2_ReceiptsId"].Visible="false";ISpace["MFG_R2_BudgetId"].Visible="true";
base.WriteDebugInfo(@"ISpace[""MFG_R2_ReceiptSplitUpId""].Visible=""false"";ISpace[""MF_P1_TransferReferenceBankId""].Visible=""true"";ISpace[""MF_P1_TransferReferenceBranch""].Visible=""true"";ISpace[""MF_P1_ReceiptAmount""].Visible=""true"";ISpace[""MF_P1_TransferType""].Visible=""true"";ISpace[""MF_P1_TransferReferenceNumber""].Visible=""true"";ISpace[""MF_P1_Status""].Visible=""false"";ISpace[""MF_P1_ReceiptNo""].Visible=""true"";ISpace[""MF_P1_ProjectDetailsId""].Visible=""true"";ISpace[""MF_P1_UpdatedOn""].Visible=""false"";ISpace[""MF_P1_TransferReferenceDate""].Visible=""true"";ISpace[""MFG_R2_UpdatedBy""].Visible=""false"";ISpace[""MF_P1_ReceiptsId""].Visible=""true"";ISpace[""MF_P1_ReceiptDate""].Visible=""true"";ISpace[""MF_P1_UpdatedBy""].Visible=""false"";ISpace[""MFG_R2_Amount""].Visible=""true"";ISpace[""MFG_R2_UpdatedOn""].Visible=""false"";ISpace[""MFG_R2_ReceiptsId""].Visible=""false"";ISpace[""MFG_R2_BudgetId""].Visible=""true"";");
ISpace["MG_R2_ReceiptsId"].Visible="false";ISpace["MG_R2_BudgetId"].Visible="true";ISpace["MG_R2_Amount"].Visible="true";ISpace["MG_R2_UpdatedBy"].Visible="false";ISpace["MG_R2_UpdatedOn"].Visible="false";ISpace["MG_R2_ReceiptSplitUpId"].Visible="false";
base.WriteDebugInfo(@"ISpace[""MG_R2_ReceiptsId""].Visible=""false"";ISpace[""MG_R2_BudgetId""].Visible=""true"";ISpace[""MG_R2_Amount""].Visible=""true"";ISpace[""MG_R2_UpdatedBy""].Visible=""false"";ISpace[""MG_R2_UpdatedOn""].Visible=""false"";ISpace[""MG_R2_ReceiptSplitUpId""].Visible=""false"";");
}

var querySourceB8A2A58C91CA4FD4B3269652593DD27B =GetQueryExpressionDataSource("B8A2A58C-91CA-4FD4-B326-9652593DD27B");

DataTable resultB8A2A58C91CA4FD4B3269652593DD27B=iSpace.SetGridDataSource(querySourceB8A2A58C91CA4FD4B3269652593DD27B, _objectFactory.GetGridRPP("MG_RemarksDetails"),@"EXEC GetRemarks '" + ISpace["Instanceid"].Value + @"'");

iSpace.InsertGridBindDetails("MG_RemarksDetails","11",querySourceB8A2A58C91CA4FD4B3269652593DD27B,"EXEC GetRemarks '" + ISpace["Instanceid"].Value + @"'",_objectFactory.GetGridRPP("MG_RemarksDetails"));

base.WriteDebugInfo(@"var querySourceB8A2A58C91CA4FD4B3269652593DD27B =GetQueryExpressionDataSource(""B8A2A58C-91CA-4FD4-B326-9652593DD27B"");DataTable resultB8A2A58C91CA4FD4B3269652593DD27B=iSpace.SetGridDataSource(querySourceB8A2A58C91CA4FD4B3269652593DD27B, _objectFactory.GetGridRPP(""MG_RemarksDetails""),@""EXEC GetRemarks '"" + ISpace[""Instanceid""].Value + @""'"");iSpace.InsertGridBindDetails(""MG_RemarksDetails"",""11"",querySourceB8A2A58C91CA4FD4B3269652593DD27B,""EXEC GetRemarks '"" + ISpace[""Instanceid""].Value + @""'"",_objectFactory.GetGridRPP(""MG_RemarksDetails""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result4ACD680C9EAE4FDBA4A3FC5C4D353701=acdataIspace537084A67B724CBEA0A2057049686345.GetQueryExpressionBindings("4ACD680C-9EAE-4FDB-A4A3-FC5C4D353701");
iSpace.SetGridData(resultB8A2A58C91CA4FD4B3269652593DD27B,result4ACD680C9EAE4FDBA4A3FC5C4D353701,"MG_RemarksDetails",ref ISpace);
iSpace.UpdateGridBindDetails("MG_RemarksDetails",result4ACD680C9EAE4FDBA4A3FC5C4D353701);
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
ISpace["Message"].Value=@"Please select the value for Move To";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please select the value for Move To"";");
return;
base.WriteDebugInfo(@"return;");
}
base.WriteDebugInfo(@"#ReceiptSplitUp[Rows]");
iSpace.GetLoopExpressionData("ReceiptSplitUp",ref ISpace);

foreach(var gridChild in ISpace["ReceiptSplitUp"].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 



ISpace["M_Amount"].Value=ISpace["MG_R2_Amount"].Value;
base.WriteDebugInfo(@"

ISpace[""M_Amount""].Value=ISpace[""MG_R2_Amount""].Value;");


ISpace["M_Budgetid"].Value=ISpace["MG_R2_BudgetId"].Value;
base.WriteDebugInfo(@"

ISpace[""M_Budgetid""].Value=ISpace[""MG_R2_BudgetId""].Value;");
base.WriteDebugInfo(@"exec ValidateBudgetHeadAmount '#C_FC_ProjectNo_15','#M_Budgetid','#M_Amount'");

var querySourceF81332044D2545DD90C1B4DD31CFF7F4 =GetQueryExpressionDataSource("F8133204-4D25-45DD-90C1-B4DD31CFF7F4");
Dictionary<short,object> resultF81332044D2545DD90C1B4DD31CFF7F4=iSpace.ExecuteQuery(querySourceF81332044D2545DD90C1B4DD31CFF7F4,@"exec ValidateBudgetHeadAmount '" + ISpace["C_FC_ProjectNo_15"].Value + @"','" + ISpace["M_Budgetid"].Value + @"','" + ISpace["M_Amount"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceF81332044D2545DD90C1B4DD31CFF7F4 =GetQueryExpressionDataSource(""F8133204-4D25-45DD-90C1-B4DD31CFF7F4"");Dictionary<short,object> resultF81332044D2545DD90C1B4DD31CFF7F4=iSpace.ExecuteQuery(querySourceF81332044D2545DD90C1B4DD31CFF7F4,@""exec ValidateBudgetHeadAmount '"" + ISpace[""C_FC_ProjectNo_15""].Value + @""','"" + ISpace[""M_Budgetid""].Value + @""','"" + ISpace[""M_Amount""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultF81332044D2545DD90C1B4DD31CFF7F4!=null) && (resultF81332044D2545DD90C1B4DD31CFF7F4.Count!=0))
{
if(resultF81332044D2545DD90C1B4DD31CFF7F4.ContainsKey(0))
ISpace["M_BudgetErr"].Value = resultF81332044D2545DD90C1B4DD31CFF7F4[0];
if(resultF81332044D2545DD90C1B4DD31CFF7F4.ContainsKey(1))
ISpace["M_BudgetErrMsg"].Value = resultF81332044D2545DD90C1B4DD31CFF7F4[1];
}
else{
ISpace["M_BudgetErr"].Value = null;ISpace["M_BudgetErrMsg"].Value = null;
}

if(
ISpace["M_BudgetErr"].Value==1)
{
base.WriteDebugInfo(@"
if(
ISpace[""M_BudgetErr""].Value==1)");
ISpace["Message"].Value=String.Format(@"{0}",ISpace["M_BudgetErrMsg"].Value);
base.WriteDebugInfo(@"ISpace[""Message""].Value=String.Format(@""{0}"",ISpace[""M_BudgetErrMsg""].Value);");
return;
base.WriteDebugInfo(@"return;");
}
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("ReceiptSplitUp","249EF445-9B49-4EF9-8045-46BD1E6FF8ED",_objectFactory.GetGridRPP("ReceiptSplitUp"),_elementBase.GetGridLoopQuery("249EF445-9B49-4EF9-8045-46BD1E6FF8ED","ReceiptSplitUp",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""ReceiptSplitUp"",ref ISpace);

foreach(var gridChild in ISpace[""ReceiptSplitUp""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
if(ISpace["M_SaveDomainData"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""M_SaveDomainData""].Value==1)");
ISpace["MF_P1_Status"].Value="A";
base.WriteDebugInfo(@"ISpace[""MF_P1_Status""].Value=""A"";");
base.WriteDebugInfo(@"EXEC UpsertProjectReceipts '#MF_P1_ReceiptsId','#MF_P1_TransferReferenceBankId','#MF_P1_ReceiptDate','#MF_P1_ReceiptNo','#UC_EmployeeBaicInfoId','#MF_P1_Status','#MF_P1_TransferReferenceDate','#MF_P1_TransferReferenceBranch','#MF_P1_UpdatedBy','#MF_P1_TransferType','#C_FC_ProjectNo_15'");

var querySource8ededcfe5adacbe6902976086059adc4 =GetQueryExpressionDataSource("8ededcfe-5ada-cbe6-9029-76086059adc4");
Dictionary<short,object> result8ededcfe5adacbe6902976086059adc4=iSpace.ExecuteQuery(querySource8ededcfe5adacbe6902976086059adc4,@"EXEC UpsertProjectReceipts '" + ISpace["MF_P1_ReceiptsId"].Value + @"','" + ISpace["MF_P1_TransferReferenceBankId"].Value + @"','" + ISpace["MF_P1_ReceiptDate"].Value + @"','" + ISpace["MF_P1_ReceiptNo"].Value + @"','" + ISpace["UC_EmployeeBaicInfoId"].Value + @"','" + ISpace["MF_P1_Status"].Value + @"','" + ISpace["MF_P1_TransferReferenceDate"].Value + @"','" + ISpace["MF_P1_TransferReferenceBranch"].Value + @"','" + ISpace["MF_P1_UpdatedBy"].Value + @"','" + ISpace["MF_P1_TransferType"].Value + @"','" + ISpace["C_FC_ProjectNo_15"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource8ededcfe5adacbe6902976086059adc4 =GetQueryExpressionDataSource(""8ededcfe-5ada-cbe6-9029-76086059adc4"");Dictionary<short,object> result8ededcfe5adacbe6902976086059adc4=iSpace.ExecuteQuery(querySource8ededcfe5adacbe6902976086059adc4,@""EXEC UpsertProjectReceipts '"" + ISpace[""MF_P1_ReceiptsId""].Value + @""','"" + ISpace[""MF_P1_TransferReferenceBankId""].Value + @""','"" + ISpace[""MF_P1_ReceiptDate""].Value + @""','"" + ISpace[""MF_P1_ReceiptNo""].Value + @""','"" + ISpace[""UC_EmployeeBaicInfoId""].Value + @""','"" + ISpace[""MF_P1_Status""].Value + @""','"" + ISpace[""MF_P1_TransferReferenceDate""].Value + @""','"" + ISpace[""MF_P1_TransferReferenceBranch""].Value + @""','"" + ISpace[""MF_P1_UpdatedBy""].Value + @""','"" + ISpace[""MF_P1_TransferType""].Value + @""','"" + ISpace[""C_FC_ProjectNo_15""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result8ededcfe5adacbe6902976086059adc4!=null) && (result8ededcfe5adacbe6902976086059adc4.Count!=0))
{
if(result8ededcfe5adacbe6902976086059adc4.ContainsKey(0))
ISpace["ExecutionMessage"].Value = result8ededcfe5adacbe6902976086059adc4[0];
}
else{
ISpace["ExecutionMessage"].Value = null;
}
base.WriteDebugInfo(@"#ReceiptSplitUp[Rows]");
iSpace.GetLoopExpressionData("ReceiptSplitUp",ref ISpace);

foreach(var gridChild in ISpace["ReceiptSplitUp"].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 

base.WriteDebugInfo(@"EXEC UpsertReceiptSplitUpDetails '#MG_R2_ReceiptSplitUpId','#MF_P1_ReceiptsId','#MG_R2_BudgetId','#MG_R2_Amount','@@gv_UserId'");

var querySourcef97254576a4771b90f3c9b5f75e48ca1 =GetQueryExpressionDataSource("f9725457-6a47-71b9-0f3c-9b5f75e48ca1");
Dictionary<short,object> resultf97254576a4771b90f3c9b5f75e48ca1=iSpace.ExecuteQuery(querySourcef97254576a4771b90f3c9b5f75e48ca1,@"EXEC UpsertReceiptSplitUpDetails '" + ISpace["MG_R2_ReceiptSplitUpId"].Value + @"','" + ISpace["MF_P1_ReceiptsId"].Value + @"','" + ISpace["MG_R2_BudgetId"].Value + @"','" + ISpace["MG_R2_Amount"].Value + @"','" + ISpace["gv_userid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourcef97254576a4771b90f3c9b5f75e48ca1 =GetQueryExpressionDataSource(""f9725457-6a47-71b9-0f3c-9b5f75e48ca1"");Dictionary<short,object> resultf97254576a4771b90f3c9b5f75e48ca1=iSpace.ExecuteQuery(querySourcef97254576a4771b90f3c9b5f75e48ca1,@""EXEC UpsertReceiptSplitUpDetails '"" + ISpace[""MG_R2_ReceiptSplitUpId""].Value + @""','"" + ISpace[""MF_P1_ReceiptsId""].Value + @""','"" + ISpace[""MG_R2_BudgetId""].Value + @""','"" + ISpace[""MG_R2_Amount""].Value + @""','"" + ISpace[""gv_userid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultf97254576a4771b90f3c9b5f75e48ca1!=null) && (resultf97254576a4771b90f3c9b5f75e48ca1.Count!=0))
{
if(resultf97254576a4771b90f3c9b5f75e48ca1.ContainsKey(0))
ISpace["ExecutionMessage"].Value = resultf97254576a4771b90f3c9b5f75e48ca1[0];
}
else{
ISpace["ExecutionMessage"].Value = null;
}
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("ReceiptSplitUp","249EF445-9B49-4EF9-8045-46BD1E6FF8ED",_objectFactory.GetGridRPP("ReceiptSplitUp"),_elementBase.GetGridLoopQuery("249EF445-9B49-4EF9-8045-46BD1E6FF8ED","ReceiptSplitUp",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""ReceiptSplitUp"",ref ISpace);

foreach(var gridChild in ISpace[""ReceiptSplitUp""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
base.WriteDebugInfo(@"#MG_DcoumentDetails[Rows]");
iSpace.GetLoopExpressionData("MG_DcoumentDetails",ref ISpace);

foreach(var gridChild in ISpace["MG_DcoumentDetails"].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 

base.WriteDebugInfo(@"EXEC UpsertDocumentDetails '#M_DocumentDetailsId','@@gv_InstanceId','#M_PackageProcessMapId','#M_DocumentName','#M_UploadDcoument','@@gv_UserId'");

var querySourcedbd67128b3fd6fe232e3a8d6e1f86bde =GetQueryExpressionDataSource("dbd67128-b3fd-6fe2-32e3-a8d6e1f86bde");
Dictionary<short,object> resultdbd67128b3fd6fe232e3a8d6e1f86bde=iSpace.ExecuteQuery(querySourcedbd67128b3fd6fe232e3a8d6e1f86bde,@"EXEC UpsertDocumentDetails '" + ISpace["M_DocumentDetailsId"].Value + @"','" + ISpace["gv_instanceid"].Value + @"','" + ISpace["M_PackageProcessMapId"].Value + @"','" + ISpace["M_DocumentName"].Value + @"','" + ISpace["M_UploadDcoument"].Value + @"','" + ISpace["gv_userid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourcedbd67128b3fd6fe232e3a8d6e1f86bde =GetQueryExpressionDataSource(""dbd67128-b3fd-6fe2-32e3-a8d6e1f86bde"");Dictionary<short,object> resultdbd67128b3fd6fe232e3a8d6e1f86bde=iSpace.ExecuteQuery(querySourcedbd67128b3fd6fe232e3a8d6e1f86bde,@""EXEC UpsertDocumentDetails '"" + ISpace[""M_DocumentDetailsId""].Value + @""','"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""M_PackageProcessMapId""].Value + @""','"" + ISpace[""M_DocumentName""].Value + @""','"" + ISpace[""M_UploadDcoument""].Value + @""','"" + ISpace[""gv_userid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultdbd67128b3fd6fe232e3a8d6e1f86bde!=null) && (resultdbd67128b3fd6fe232e3a8d6e1f86bde.Count!=0))
{
if(resultdbd67128b3fd6fe232e3a8d6e1f86bde.ContainsKey(0))
ISpace["ExecutionMessage"].Value = resultdbd67128b3fd6fe232e3a8d6e1f86bde[0];
}
else{
ISpace["ExecutionMessage"].Value = null;
}
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("MG_DcoumentDetails","C2287754-790E-4853-A5A7-64772676D00E",_objectFactory.GetGridRPP("MG_DcoumentDetails"),_elementBase.GetGridLoopQuery("C2287754-790E-4853-A5A7-64772676D00E","MG_DcoumentDetails",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""MG_DcoumentDetails"",ref ISpace);

foreach(var gridChild in ISpace[""MG_DcoumentDetails""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
base.WriteDebugInfo(@"EXEC UpsertCreateProjectDetails '#MF_ProjectDetailsID','#MF_P1_ActualDate','#MF_P1_ActualEndDate'");

var querySourceb25829de0dacf553841baf18f5d427f5 =GetQueryExpressionDataSource("b25829de-0dac-f553-841b-af18f5d427f5");
Dictionary<short,object> resultb25829de0dacf553841baf18f5d427f5=iSpace.ExecuteQuery(querySourceb25829de0dacf553841baf18f5d427f5,@"EXEC UpsertCreateProjectDetails '" + ISpace["MF_ProjectDetailsID"].Value + @"','" + ISpace["MF_P1_ActualDate"].Value + @"','" + ISpace["MF_P1_ActualEndDate"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceb25829de0dacf553841baf18f5d427f5 =GetQueryExpressionDataSource(""b25829de-0dac-f553-841b-af18f5d427f5"");Dictionary<short,object> resultb25829de0dacf553841baf18f5d427f5=iSpace.ExecuteQuery(querySourceb25829de0dacf553841baf18f5d427f5,@""EXEC UpsertCreateProjectDetails '"" + ISpace[""MF_ProjectDetailsID""].Value + @""','"" + ISpace[""MF_P1_ActualDate""].Value + @""','"" + ISpace[""MF_P1_ActualEndDate""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultb25829de0dacf553841baf18f5d427f5!=null) && (resultb25829de0dacf553841baf18f5d427f5.Count!=0))
{
if(resultb25829de0dacf553841baf18f5d427f5.ContainsKey(0))
ISpace["ExecutionMessage"].Value = resultb25829de0dacf553841baf18f5d427f5[0];
}
else{
ISpace["ExecutionMessage"].Value = null;
}
base.WriteDebugInfo(@"exec UpdateOverHeadSplitData '#C_FC_ProjectNo_15','#MF_P1_ReceiptsId','@@gv_ProcessMapId'");

var querySourceDE3FD546579040D28E8AEB9179B047C4 =GetQueryExpressionDataSource("DE3FD546-5790-40D2-8E8A-EB9179B047C4");
Dictionary<short,object> resultDE3FD546579040D28E8AEB9179B047C4=iSpace.ExecuteQuery(querySourceDE3FD546579040D28E8AEB9179B047C4,@"exec UpdateOverHeadSplitData '" + ISpace["C_FC_ProjectNo_15"].Value + @"','" + ISpace["MF_P1_ReceiptsId"].Value + @"','" + ISpace["gv_processmapid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceDE3FD546579040D28E8AEB9179B047C4 =GetQueryExpressionDataSource(""DE3FD546-5790-40D2-8E8A-EB9179B047C4"");Dictionary<short,object> resultDE3FD546579040D28E8AEB9179B047C4=iSpace.ExecuteQuery(querySourceDE3FD546579040D28E8AEB9179B047C4,@""exec UpdateOverHeadSplitData '"" + ISpace[""C_FC_ProjectNo_15""].Value + @""','"" + ISpace[""MF_P1_ReceiptsId""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultDE3FD546579040D28E8AEB9179B047C4!=null) && (resultDE3FD546579040D28E8AEB9179B047C4.Count!=0))
{
if(resultDE3FD546579040D28E8AEB9179B047C4.ContainsKey(0))
ISpace["Subject"].Value = resultDE3FD546579040D28E8AEB9179B047C4[0];
}
else{
ISpace["Subject"].Value = null;
}
base.WriteDebugInfo(@"EXEC [UpsertProjectBudgetDetails] 4,'#C_FC_ProjectNo_15','#MF_P1_ReceiptsId'");

var querySource0B4B727AF2FC49FDADAE2CCF203DB052 =GetQueryExpressionDataSource("0B4B727A-F2FC-49FD-ADAE-2CCF203DB052");
Dictionary<short,object> result0B4B727AF2FC49FDADAE2CCF203DB052=iSpace.ExecuteQuery(querySource0B4B727AF2FC49FDADAE2CCF203DB052,@"EXEC [UpsertProjectBudgetDetails] 4,'" + ISpace["C_FC_ProjectNo_15"].Value + @"','" + ISpace["MF_P1_ReceiptsId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource0B4B727AF2FC49FDADAE2CCF203DB052 =GetQueryExpressionDataSource(""0B4B727A-F2FC-49FD-ADAE-2CCF203DB052"");Dictionary<short,object> result0B4B727AF2FC49FDADAE2CCF203DB052=iSpace.ExecuteQuery(querySource0B4B727AF2FC49FDADAE2CCF203DB052,@""EXEC [UpsertProjectBudgetDetails] 4,'"" + ISpace[""C_FC_ProjectNo_15""].Value + @""','"" + ISpace[""MF_P1_ReceiptsId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result0B4B727AF2FC49FDADAE2CCF203DB052!=null) && (result0B4B727AF2FC49FDADAE2CCF203DB052.Count!=0))
{
if(result0B4B727AF2FC49FDADAE2CCF203DB052.ContainsKey(0))
ISpace["Subject"].Value = result0B4B727AF2FC49FDADAE2CCF203DB052[0];
}
else{
ISpace["Subject"].Value = null;
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
ISpace["Message"].Value=@"Submitted Successfully";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Submitted Successfully"";");

var querySourceB8A2A58C91CA4FD4B3269652593DD27B =GetQueryExpressionDataSource("B8A2A58C-91CA-4FD4-B326-9652593DD27B");

DataTable resultB8A2A58C91CA4FD4B3269652593DD27B=iSpace.SetGridDataSource(querySourceB8A2A58C91CA4FD4B3269652593DD27B, _objectFactory.GetGridRPP("MG_RemarksDetails"),@"EXEC GetRemarks '" + ISpace["Instanceid"].Value + @"'");

iSpace.InsertGridBindDetails("MG_RemarksDetails","11",querySourceB8A2A58C91CA4FD4B3269652593DD27B,"EXEC GetRemarks '" + ISpace["Instanceid"].Value + @"'",_objectFactory.GetGridRPP("MG_RemarksDetails"));

base.WriteDebugInfo(@"var querySourceB8A2A58C91CA4FD4B3269652593DD27B =GetQueryExpressionDataSource(""B8A2A58C-91CA-4FD4-B326-9652593DD27B"");DataTable resultB8A2A58C91CA4FD4B3269652593DD27B=iSpace.SetGridDataSource(querySourceB8A2A58C91CA4FD4B3269652593DD27B, _objectFactory.GetGridRPP(""MG_RemarksDetails""),@""EXEC GetRemarks '"" + ISpace[""Instanceid""].Value + @""'"");iSpace.InsertGridBindDetails(""MG_RemarksDetails"",""11"",querySourceB8A2A58C91CA4FD4B3269652593DD27B,""EXEC GetRemarks '"" + ISpace[""Instanceid""].Value + @""'"",_objectFactory.GetGridRPP(""MG_RemarksDetails""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result4ACD680C9EAE4FDBA4A3FC5C4D353701=acdataIspace537084A67B724CBEA0A2057049686345.GetQueryExpressionBindings("4ACD680C-9EAE-4FDB-A4A3-FC5C4D353701");
iSpace.SetGridData(resultB8A2A58C91CA4FD4B3269652593DD27B,result4ACD680C9EAE4FDBA4A3FC5C4D353701,"MG_RemarksDetails",ref ISpace);
iSpace.UpdateGridBindDetails("MG_RemarksDetails",result4ACD680C9EAE4FDBA4A3FC5C4D353701);
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
ISpace["SetDestinationTo"].Value=ISpace["M_MoveTo"].Value;
base.WriteDebugInfo(@"ISpace[""SetDestinationTo""].Value=ISpace[""M_MoveTo""].Value;");
ISpace["M_MoveToValue"].Value=ISpace["M_MoveTo"].Value;
base.WriteDebugInfo(@"ISpace[""M_MoveToValue""].Value=ISpace[""M_MoveTo""].Value;");
base.WriteDebugInfo(@"Exec GetStageStatus 1,'','','#M_MoveToValue','#M_SourceActivityMapId'");

var querySource566D32B365864115B5DB148796882A52 =GetQueryExpressionDataSource("566D32B3-6586-4115-B5DB-148796882A52");
Dictionary<short,object> result566D32B365864115B5DB148796882A52=iSpace.ExecuteQuery(querySource566D32B365864115B5DB148796882A52,@"Exec GetStageStatus 1,'','','" + ISpace["M_MoveToValue"].Value + @"','" + ISpace["M_SourceActivityMapId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource566D32B365864115B5DB148796882A52 =GetQueryExpressionDataSource(""566D32B3-6586-4115-B5DB-148796882A52"");Dictionary<short,object> result566D32B365864115B5DB148796882A52=iSpace.ExecuteQuery(querySource566D32B365864115B5DB148796882A52,@""Exec GetStageStatus 1,'','','"" + ISpace[""M_MoveToValue""].Value + @""','"" + ISpace[""M_SourceActivityMapId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result566D32B365864115B5DB148796882A52!=null) && (result566D32B365864115B5DB148796882A52.Count!=0))
{
if(result566D32B365864115B5DB148796882A52.ContainsKey(3))
ISpace["M_SaveDomainData"].Value = result566D32B365864115B5DB148796882A52[3];
if(result566D32B365864115B5DB148796882A52.ContainsKey(1))
ISpace["M_RemarksMandatory"].Value = result566D32B365864115B5DB148796882A52[1];
if(result566D32B365864115B5DB148796882A52.ContainsKey(4))
ISpace["M_FieldMandatory"].Value = result566D32B365864115B5DB148796882A52[4];
if(result566D32B365864115B5DB148796882A52.ContainsKey(5))
ISpace["M_IsflowReturned"].Value = result566D32B365864115B5DB148796882A52[5];
if(result566D32B365864115B5DB148796882A52.ContainsKey(6))
ISpace["M_IsCancelReject"].Value = result566D32B365864115B5DB148796882A52[6];
if(result566D32B365864115B5DB148796882A52.ContainsKey(7))
ISpace["M_Currentlevel"].Value = result566D32B365864115B5DB148796882A52[7];
if(result566D32B365864115B5DB148796882A52.ContainsKey(0))
ISpace["M_NextStage"].Value = result566D32B365864115B5DB148796882A52[0];
if(result566D32B365864115B5DB148796882A52.ContainsKey(2))
ISpace["M_Remarks"].Value = result566D32B365864115B5DB148796882A52[2];
}
else{
ISpace["M_SaveDomainData"].Value = null;ISpace["M_RemarksMandatory"].Value = null;ISpace["M_FieldMandatory"].Value = null;ISpace["M_IsflowReturned"].Value = null;ISpace["M_IsCancelReject"].Value = null;ISpace["M_Currentlevel"].Value = null;ISpace["M_NextStage"].Value = null;ISpace["M_Remarks"].Value = null;
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
	
using System;
    using System.Collections.Generic;    
    using System.Text;	
    using System.Linq;	


	public partial class AcDataISpaceDDBF52926EF44C37B72AE6DCFFBF7B02  : ExtensionActivityBase
	{		
		
		
		private Dictionary<string,  List<Triplet<string, short, short?>>> queryExpressionBindings = 
											new Dictionary<string,  List<Triplet<string, short, short?>>>
		{
							{"4ACD680C-9EAE-4FDB-A4A3-FC5C4D353701", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("DateOfRemarks",3,
														   -1),
								   new Triplet<string, short, short?>("ActivityName",1,
														   -1),
								   new Triplet<string, short, short?>("Remarks",4,
														   -1),
								   new Triplet<string, short, short?>("RemarksId",0,
														   -1),
								   new Triplet<string, short, short?>("UserName",2,
														   -1),
								}
			},
							{"7383DEAC-014B-4719-858E-5F2EDC911594", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("A_BudgetID",3,
														   -1),
								   new Triplet<string, short, short?>("A_OverallSantionedAmount",5,
														   -1),
								   new Triplet<string, short, short?>("A_BudgetClaimedAmount",1,
														   -1),
								   new Triplet<string, short, short?>("A_BudgetName",0,
														   -1),
								   new Triplet<string, short, short?>("MG_AvailableAmount",4,
														   -1),
								}
			},
							{"68E47F75-23D1-4580-ABFC-B23D3E6D49FF", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_R2_Amount",3,
														   -1),
								   new Triplet<string, short, short?>("MG_R2_BudgetId",2,
														   -1),
								   new Triplet<string, short, short?>("MG_R2_ReceiptsId",1,
														   -1),
								   new Triplet<string, short, short?>("MG_R2_UpdatedBy",4,
														   -1),
								   new Triplet<string, short, short?>("MG_R2_ReceiptSplitUpId",0,
														   -1),
								   new Triplet<string, short, short?>("MG_R2_UpdatedOn",5,
														   -1),
								   new Triplet<string, short, short?>("ReceiptSplitUp_RowId",6,
														   -1),
								}
			},
							{"CA263927-20D6-4C62-9E9F-015B3ED8015D", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_R2_ReceiptsId",1,
														   -1),
								   new Triplet<string, short, short?>("MG_R2_BudgetId",2,
														   -1),
								   new Triplet<string, short, short?>("MG_R2_ReceiptSplitUpId",0,
														   -1),
								   new Triplet<string, short, short?>("MG_R2_UpdatedOn",5,
														   -1),
								   new Triplet<string, short, short?>("MG_R2_UpdatedBy",4,
														   -1),
								   new Triplet<string, short, short?>("ReceiptSplitUp_RowId",6,
														   -1),
								   new Triplet<string, short, short?>("MG_R2_Amount",3,
														   -1),
								}
			},
					};	

	

		private Dictionary<string,string> formVersionList =new Dictionary<string,string> 
		{
							{"0481C68C-08AC-4DAC-BFF0-06A4EF027A88", "Mobile-Hybrid"},
							{"7885C0A2-264B-4055-A2D0-B0D3D6927FF4", "Tab"},
							{"B1CB93DB-7B9C-4661-BE11-02ED3BFD5725", "Medium"},
					};	

		
		private Dictionary<string,string> formVersionLayoutList =new Dictionary<string,string> 
		{
							{"0481C68C-08AC-4DAC-BFF0-06A4EF027A88", ""},
							{"7885C0A2-264B-4055-A2D0-B0D3D6927FF4", ""},
							{"B1CB93DB-7B9C-4661-BE11-02ED3BFD5725", ""},
							{"A04AACAE-3004-4D2D-BC78-73839968D39D", ""},
							{"640C283B-38E9-4C7A-A237-CE1978ED1C51", ""},
							{"E0738E17-715D-430D-9E81-C362B6C9B420", ""},
							{"57F82DC6-5E93-477D-88EA-45127573FE4E", ""},
							{"D9B3CA04-18F0-4441-8908-A9B5A672A9E7", ""},
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


	public partial class AcDataISpaceFF2ED87620AB4F5DB62B385405DFB900  : ExtensionActivityBase
	{		
		
		
		private Dictionary<string,  List<Triplet<string, short, short?>>> queryExpressionBindings = 
											new Dictionary<string,  List<Triplet<string, short, short?>>>
		{
							{"4ACD680C-9EAE-4FDB-A4A3-FC5C4D353701", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("DateOfRemarks",3,
														   -1),
								   new Triplet<string, short, short?>("ActivityName",1,
														   -1),
								   new Triplet<string, short, short?>("Remarks",4,
														   -1),
								   new Triplet<string, short, short?>("RemarksId",0,
														   -1),
								   new Triplet<string, short, short?>("UserName",2,
														   -1),
								}
			},
					};	

	

		private Dictionary<string,string> formVersionList =new Dictionary<string,string> 
		{
							{"0481C68C-08AC-4DAC-BFF0-06A4EF027A88", "Mobile-Hybrid"},
							{"7885C0A2-264B-4055-A2D0-B0D3D6927FF4", "Tab"},
							{"B1CB93DB-7B9C-4661-BE11-02ED3BFD5725", "Medium"},
					};	

		
		private Dictionary<string,string> formVersionLayoutList =new Dictionary<string,string> 
		{
							{"0481C68C-08AC-4DAC-BFF0-06A4EF027A88", ""},
							{"7885C0A2-264B-4055-A2D0-B0D3D6927FF4", ""},
							{"B1CB93DB-7B9C-4661-BE11-02ED3BFD5725", ""},
							{"A04AACAE-3004-4D2D-BC78-73839968D39D", ""},
							{"640C283B-38E9-4C7A-A237-CE1978ED1C51", ""},
							{"E0738E17-715D-430D-9E81-C362B6C9B420", ""},
							{"57F82DC6-5E93-477D-88EA-45127573FE4E", ""},
							{"D9B3CA04-18F0-4441-8908-A9B5A672A9E7", ""},
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


	public partial class AcDataISpace2B40E332984042E38DDC002EAFAA05FA  : ExtensionActivityBase
	{		
		
		
		private Dictionary<string,  List<Triplet<string, short, short?>>> queryExpressionBindings = 
											new Dictionary<string,  List<Triplet<string, short, short?>>>
		{
							{"4ACD680C-9EAE-4FDB-A4A3-FC5C4D353701", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("DateOfRemarks",3,
														   -1),
								   new Triplet<string, short, short?>("ActivityName",1,
														   -1),
								   new Triplet<string, short, short?>("Remarks",4,
														   -1),
								   new Triplet<string, short, short?>("RemarksId",0,
														   -1),
								   new Triplet<string, short, short?>("UserName",2,
														   -1),
								}
			},
							{"7383DEAC-014B-4719-858E-5F2EDC911594", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("A_BudgetID",3,
														   -1),
								   new Triplet<string, short, short?>("A_OverallSantionedAmount",5,
														   -1),
								   new Triplet<string, short, short?>("A_BudgetClaimedAmount",1,
														   -1),
								   new Triplet<string, short, short?>("A_BudgetName",0,
														   -1),
								   new Triplet<string, short, short?>("MG_AvailableAmount",4,
														   -1),
								}
			},
							{"68E47F75-23D1-4580-ABFC-B23D3E6D49FF", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_R2_Amount",3,
														   -1),
								   new Triplet<string, short, short?>("MG_R2_BudgetId",2,
														   -1),
								   new Triplet<string, short, short?>("MG_R2_ReceiptsId",1,
														   -1),
								   new Triplet<string, short, short?>("MG_R2_UpdatedBy",4,
														   -1),
								   new Triplet<string, short, short?>("MG_R2_ReceiptSplitUpId",0,
														   -1),
								   new Triplet<string, short, short?>("MG_R2_UpdatedOn",5,
														   -1),
								   new Triplet<string, short, short?>("ReceiptSplitUp_RowId",6,
														   -1),
								}
			},
							{"CA263927-20D6-4C62-9E9F-015B3ED8015D", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_R2_ReceiptsId",1,
														   -1),
								   new Triplet<string, short, short?>("MG_R2_BudgetId",2,
														   -1),
								   new Triplet<string, short, short?>("MG_R2_ReceiptSplitUpId",0,
														   -1),
								   new Triplet<string, short, short?>("MG_R2_UpdatedOn",5,
														   -1),
								   new Triplet<string, short, short?>("MG_R2_UpdatedBy",4,
														   -1),
								   new Triplet<string, short, short?>("ReceiptSplitUp_RowId",6,
														   -1),
								   new Triplet<string, short, short?>("MG_R2_Amount",3,
														   -1),
								}
			},
					};	

	

		private Dictionary<string,string> formVersionList =new Dictionary<string,string> 
		{
							{"0481C68C-08AC-4DAC-BFF0-06A4EF027A88", "Mobile-Hybrid"},
							{"7885C0A2-264B-4055-A2D0-B0D3D6927FF4", "Tab"},
							{"B1CB93DB-7B9C-4661-BE11-02ED3BFD5725", "Medium"},
					};	

		
		private Dictionary<string,string> formVersionLayoutList =new Dictionary<string,string> 
		{
							{"0481C68C-08AC-4DAC-BFF0-06A4EF027A88", ""},
							{"7885C0A2-264B-4055-A2D0-B0D3D6927FF4", ""},
							{"B1CB93DB-7B9C-4661-BE11-02ED3BFD5725", ""},
							{"A04AACAE-3004-4D2D-BC78-73839968D39D", ""},
							{"640C283B-38E9-4C7A-A237-CE1978ED1C51", ""},
							{"E0738E17-715D-430D-9E81-C362B6C9B420", ""},
							{"57F82DC6-5E93-477D-88EA-45127573FE4E", ""},
							{"D9B3CA04-18F0-4441-8908-A9B5A672A9E7", ""},
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


	public partial class AcDataISpaceF39D0937CEBB498CBECDC97995411514  : ExtensionActivityBase
	{		
		
		
		private Dictionary<string,  List<Triplet<string, short, short?>>> queryExpressionBindings = 
											new Dictionary<string,  List<Triplet<string, short, short?>>>
		{
							{"4ACD680C-9EAE-4FDB-A4A3-FC5C4D353701", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("DateOfRemarks",3,
														   -1),
								   new Triplet<string, short, short?>("ActivityName",1,
														   -1),
								   new Triplet<string, short, short?>("Remarks",4,
														   -1),
								   new Triplet<string, short, short?>("RemarksId",0,
														   -1),
								   new Triplet<string, short, short?>("UserName",2,
														   -1),
								}
			},
					};	

	

		private Dictionary<string,string> formVersionList =new Dictionary<string,string> 
		{
							{"0481C68C-08AC-4DAC-BFF0-06A4EF027A88", "Mobile-Hybrid"},
							{"7885C0A2-264B-4055-A2D0-B0D3D6927FF4", "Tab"},
							{"B1CB93DB-7B9C-4661-BE11-02ED3BFD5725", "Medium"},
							{"A04AACAE-3004-4D2D-BC78-73839968D39D", "Large"},
							{"640C283B-38E9-4C7A-A237-CE1978ED1C51", "AR"},
							{"E0738E17-715D-430D-9E81-C362B6C9B420", "MR"},
							{"57F82DC6-5E93-477D-88EA-45127573FE4E", "HHT"},
							{"D9B3CA04-18F0-4441-8908-A9B5A672A9E7", "Mobile-Native"},
					};	

		
		private Dictionary<string,string> formVersionLayoutList =new Dictionary<string,string> 
		{
							{"0481C68C-08AC-4DAC-BFF0-06A4EF027A88", ""},
							{"7885C0A2-264B-4055-A2D0-B0D3D6927FF4", ""},
							{"B1CB93DB-7B9C-4661-BE11-02ED3BFD5725", ""},
							{"A04AACAE-3004-4D2D-BC78-73839968D39D", ""},
							{"640C283B-38E9-4C7A-A237-CE1978ED1C51", ""},
							{"E0738E17-715D-430D-9E81-C362B6C9B420", ""},
							{"57F82DC6-5E93-477D-88EA-45127573FE4E", ""},
							{"D9B3CA04-18F0-4441-8908-A9B5A672A9E7", ""},
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


	public partial class AcDataISpace63E101E317124F9CAF4DA8820791C99B  : ExtensionActivityBase
	{		
		
		
		private Dictionary<string,  List<Triplet<string, short, short?>>> queryExpressionBindings = 
											new Dictionary<string,  List<Triplet<string, short, short?>>>
		{
							{"4ACD680C-9EAE-4FDB-A4A3-FC5C4D353701", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("DateOfRemarks",3,
														   -1),
								   new Triplet<string, short, short?>("ActivityName",1,
														   -1),
								   new Triplet<string, short, short?>("Remarks",4,
														   -1),
								   new Triplet<string, short, short?>("RemarksId",0,
														   -1),
								   new Triplet<string, short, short?>("UserName",2,
														   -1),
								}
			},
					};	

	

		private Dictionary<string,string> formVersionList =new Dictionary<string,string> 
		{
							{"0481C68C-08AC-4DAC-BFF0-06A4EF027A88", "Mobile-Hybrid"},
							{"7885C0A2-264B-4055-A2D0-B0D3D6927FF4", "Tab"},
							{"B1CB93DB-7B9C-4661-BE11-02ED3BFD5725", "Medium"},
							{"A04AACAE-3004-4D2D-BC78-73839968D39D", "Large"},
							{"640C283B-38E9-4C7A-A237-CE1978ED1C51", "AR"},
							{"E0738E17-715D-430D-9E81-C362B6C9B420", "MR"},
							{"57F82DC6-5E93-477D-88EA-45127573FE4E", "HHT"},
							{"D9B3CA04-18F0-4441-8908-A9B5A672A9E7", "Mobile-Native"},
					};	

		
		private Dictionary<string,string> formVersionLayoutList =new Dictionary<string,string> 
		{
							{"0481C68C-08AC-4DAC-BFF0-06A4EF027A88", ""},
							{"7885C0A2-264B-4055-A2D0-B0D3D6927FF4", ""},
							{"B1CB93DB-7B9C-4661-BE11-02ED3BFD5725", ""},
							{"A04AACAE-3004-4D2D-BC78-73839968D39D", ""},
							{"640C283B-38E9-4C7A-A237-CE1978ED1C51", ""},
							{"E0738E17-715D-430D-9E81-C362B6C9B420", ""},
							{"57F82DC6-5E93-477D-88EA-45127573FE4E", ""},
							{"D9B3CA04-18F0-4441-8908-A9B5A672A9E7", ""},
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


	public partial class AcDataISpaceF38AD8C868324FC5A52D7EB3B0FEE9F8  : ExtensionActivityBase
	{		
		
		
		private Dictionary<string,  List<Triplet<string, short, short?>>> queryExpressionBindings = 
											new Dictionary<string,  List<Triplet<string, short, short?>>>
		{
							{"4ACD680C-9EAE-4FDB-A4A3-FC5C4D353701", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("DateOfRemarks",3,
														   -1),
								   new Triplet<string, short, short?>("ActivityName",1,
														   -1),
								   new Triplet<string, short, short?>("Remarks",4,
														   -1),
								   new Triplet<string, short, short?>("RemarksId",0,
														   -1),
								   new Triplet<string, short, short?>("UserName",2,
														   -1),
								}
			},
					};	

	

		private Dictionary<string,string> formVersionList =new Dictionary<string,string> 
		{
							{"0481C68C-08AC-4DAC-BFF0-06A4EF027A88", "Mobile-Hybrid"},
							{"7885C0A2-264B-4055-A2D0-B0D3D6927FF4", "Tab"},
							{"B1CB93DB-7B9C-4661-BE11-02ED3BFD5725", "Medium"},
					};	

		
		private Dictionary<string,string> formVersionLayoutList =new Dictionary<string,string> 
		{
							{"0481C68C-08AC-4DAC-BFF0-06A4EF027A88", ""},
							{"7885C0A2-264B-4055-A2D0-B0D3D6927FF4", ""},
							{"B1CB93DB-7B9C-4661-BE11-02ED3BFD5725", ""},
							{"A04AACAE-3004-4D2D-BC78-73839968D39D", ""},
							{"640C283B-38E9-4C7A-A237-CE1978ED1C51", ""},
							{"E0738E17-715D-430D-9E81-C362B6C9B420", ""},
							{"57F82DC6-5E93-477D-88EA-45127573FE4E", ""},
							{"D9B3CA04-18F0-4441-8908-A9B5A672A9E7", ""},
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


	public partial class AcDataISpace537084A67B724CBEA0A2057049686345  : ExtensionActivityBase
	{		
		
		
		private Dictionary<string,  List<Triplet<string, short, short?>>> queryExpressionBindings = 
											new Dictionary<string,  List<Triplet<string, short, short?>>>
		{
							{"4ACD680C-9EAE-4FDB-A4A3-FC5C4D353701", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("DateOfRemarks",3,
														   -1),
								   new Triplet<string, short, short?>("ActivityName",1,
														   -1),
								   new Triplet<string, short, short?>("Remarks",4,
														   -1),
								   new Triplet<string, short, short?>("RemarksId",0,
														   -1),
								   new Triplet<string, short, short?>("UserName",2,
														   -1),
								}
			},
					};	

	

		private Dictionary<string,string> formVersionList =new Dictionary<string,string> 
		{
							{"0481C68C-08AC-4DAC-BFF0-06A4EF027A88", "Mobile-Hybrid"},
							{"7885C0A2-264B-4055-A2D0-B0D3D6927FF4", "Tab"},
							{"B1CB93DB-7B9C-4661-BE11-02ED3BFD5725", "Medium"},
					};	

		
		private Dictionary<string,string> formVersionLayoutList =new Dictionary<string,string> 
		{
							{"0481C68C-08AC-4DAC-BFF0-06A4EF027A88", ""},
							{"7885C0A2-264B-4055-A2D0-B0D3D6927FF4", ""},
							{"B1CB93DB-7B9C-4661-BE11-02ED3BFD5725", ""},
							{"A04AACAE-3004-4D2D-BC78-73839968D39D", ""},
							{"640C283B-38E9-4C7A-A237-CE1978ED1C51", ""},
							{"E0738E17-715D-430D-9E81-C362B6C9B420", ""},
							{"57F82DC6-5E93-477D-88EA-45127573FE4E", ""},
							{"D9B3CA04-18F0-4441-8908-A9B5A672A9E7", ""},
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
		


