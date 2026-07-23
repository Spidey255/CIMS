  







namespace CPS.Proof.DFSExtension
{
	using System;
    using System.Collections.Generic;     
	using System.Linq;
	
	
	public partial class TravelRequestNewProcessMetadata : ExtensionProcessBase
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
            get { return "bfcdccb2-7467-4308-a53d-7cab7b883529"; }
        }

        public override string ProcessName
        {
            get { return "TravelRequestNew"; }
        }

		public override string ProcessDescription
        {
            get { return "Travel Request New"; }
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
            get {return "bfcdccb2-7467-4308-a53d-7cab7b883529";}
        }

		public override byte ProcessInstanceMode
        {
            get {return 3;}
        }		

		public override string MasterFormId
        {
            get {  
				   return "5D394C98-9AAB-4228-B011-FC8008C3247C";	}
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
	

	public partial class TravelRequestNewObjectFactory  : ExtObjectFactoryBase
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
        //    return (IExtBaseMetaData)new TravelRequestNewProcessMetadata();
        //}
	


		private List<Triplet<string, string, string>> queryExpressionData = new List<Triplet<string, string, string>>
		{
	  			
			     new Triplet<string, string, string>("6A3DD019-6ADB-41F4-A451-77D3CE6705D7","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"24F5D845-D560-4FC1-B284-00FB19DFB96F"),
			
						
			     new Triplet<string, string, string>("bbe4aa41-de2b-ed94-cedd-90d80df7192f","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("0e8ceab6-9d8f-ffd6-8fe0-3de1048b96a0","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("5D2551CD-FD03-487A-8106-1EBC8385C05B","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("B926676F-6B9A-4DFE-933F-733A15635C3F","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("E182AF12-DAED-4644-A9FC-9AA3381897FF","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("698205C5-2C1A-42F3-9D81-823D3215AB11","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"24F5D845-D560-4FC1-B284-00FB19DFB96F"),
			
						
			     new Triplet<string, string, string>("4F9BFECD-0062-4E7B-8831-33CCA9BF62FE","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("1D7C9725-F11C-4C72-BB58-A7C49B33E1C9","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("B4045736-7C78-448F-8AD3-74D62A738672","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("cb7a5d06-45d0-748a-c18f-bb48a35f9e4e","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("94A94EAC-1991-4463-9AD7-CC6F7445F90A","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("B39C99E9-4959-4231-A550-79A7280A86B2","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("1A41CC35-C2E4-455C-98AF-7868BC351B2C","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"24F5D845-D560-4FC1-B284-00FB19DFB96F"),
			
						
			     new Triplet<string, string, string>("3c3e1ff7-6c79-c28e-d614-9890b238c224","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"028B1EFF-34A8-4D44-BF39-06CE99DF7C67"),
			
						
			     new Triplet<string, string, string>("15B473E5-5CD0-469A-B3B0-C69EFCAF1CEB","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("4c20e723-6b4e-1baa-1f33-b09cc235bbe6","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"24F5D845-D560-4FC1-B284-00FB19DFB96F"),
			
						
			     new Triplet<string, string, string>("D7D51D58-71D4-428E-A54A-D52FA8744223","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"24F5D845-D560-4FC1-B284-00FB19DFB96F"),
			
						
			     new Triplet<string, string, string>("DDAF997F-6BE4-4246-91A6-BF443D4771D5","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"24F5D845-D560-4FC1-B284-00FB19DFB96F"),
			
						
			     new Triplet<string, string, string>("76804AA1-305E-4E7F-895E-B90B051455D5","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"24F5D845-D560-4FC1-B284-00FB19DFB96F"),
			
						
			     new Triplet<string, string, string>("8A15D75C-E81B-41A9-9447-0F78A10C69DF","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("0B38C232-5A80-430B-A237-2A5E6E1AD125","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("22A090AD-8607-491E-AEE2-3888BF931161","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("d2263c8e-514f-23ed-fc67-87a6b036069a","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("7444A313-0116-4D01-ADC7-D4FB2D3A166B","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"24F5D845-D560-4FC1-B284-00FB19DFB96F"),
			
						
			     new Triplet<string, string, string>("5E4DD494-A941-46D5-861A-1C2B0B9576C2","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"24F5D845-D560-4FC1-B284-00FB19DFB96F"),
			
						
			     new Triplet<string, string, string>("588a57f1-a423-85cb-c854-b18aee523e01","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("fbb131bf-5cbf-0eb8-6f44-bf481055f5b7","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("698205C5-2C1A-42F3-9D81-823D3215AB11","Load Comments",
												     @"25967012-E902-4718-B75F-2ECC20C16014"),
			
						
			     new Triplet<string, string, string>("B4045736-7C78-448F-8AD3-74D62A738672","Load Fund Details",
												     @"D16E4242-8604-48C1-8EF4-A05C77ED8CF5"),
			
						
			     new Triplet<string, string, string>("15B473E5-5CD0-469A-B3B0-C69EFCAF1CEB","Load Commitments",
												     @"A2ABDF83-3F20-4844-9175-EC5BCC4B7DCC"),
			
						
			     new Triplet<string, string, string>("D7D51D58-71D4-428E-A54A-D52FA8744223","Grid Binding6",
												     @"63762982-2C07-4E60-8D86-D3A35CA53EDA"),
			
						
			     new Triplet<string, string, string>("DDAF997F-6BE4-4246-91A6-BF443D4771D5","Grid Binding9",
												     @"63762982-2C07-4E60-8D86-D3A35CA53EDA"),
			
						
			     new Triplet<string, string, string>("0B38C232-5A80-430B-A237-2A5E6E1AD125","Load Grid By IdExpenseDetails",
												     @"63762982-2C07-4E60-8D86-D3A35CA53EDA"),
			
						
			     new Triplet<string, string, string>("22A090AD-8607-491E-AEE2-3888BF931161","Load Grid By IdAdvanceDetails",
												     @"93B856A5-0D32-4A27-8B58-5BFE5FF0162C"),
			
						
			     new Triplet<string, string, string>("7444A313-0116-4D01-ADC7-D4FB2D3A166B","Grid BindingF",
												     @"93B856A5-0D32-4A27-8B58-5BFE5FF0162C"),
			
						
			     new Triplet<string, string, string>("5E4DD494-A941-46D5-861A-1C2B0B9576C2","Grid Binding0",
												     @"93B856A5-0D32-4A27-8B58-5BFE5FF0162C"),
			
			
			
		};

		
		private List<Triplet<string, string, string>> ComboDataSource = new List<Triplet<string, string, string>>
		{

		
	  			
			     new Triplet<string, string, string>("FWFM_BudgetHead","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMA18yFT7KruzVDa0TqsqpOM+grujzoqor1KqRIderPPsozBAr7TiIaPx7MYO2zQclV",
												     @"Exec SP_GetDistrubitionDetails 5,'@PFMF_PackageProcessMapId','@FWFM_FundType','','','','','@FWFM_ProjectNo'"),
			
						
			     new Triplet<string, string, string>("FWFM_ProjectNo","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMAqCwOWy+D7Ogje1I4jfjiAZNrjEazgaNyfBj9pr2u90lOsHzRNfKnSybWqRxrZGqV",
												     @"EXEC GetProjectNoCombo 1,'@PFMF_UserId'"),
			
						
			     new Triplet<string, string, string>("MF_d1_TravelType","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMAqCwOWy+D7Ogje1I4jfjiAZNrjEazgaNyfBj9pr2u90lOsHzRNfKnSybWqRxrZGqV",
												     @"EXEC GetTravelTypes"),
			
						
			     new Triplet<string, string, string>("MFG_d2_JourneyClass","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMAqCwOWy+D7Ogje1I4jfjiAZNrjEazgaNyfBj9pr2u90lOsHzRNfKnSybWqRxrZGqV",
												     @"EXEC TravelClassCombo '@MFG_d2_ModeofJourney'"),
			
						
			     new Triplet<string, string, string>("MG_d2_JourneyClass","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMAqCwOWy+D7Ogje1I4jfjiAZNrjEazgaNyfBj9pr2u90lOsHzRNfKnSybWqRxrZGqV",
												     @"EXEC TravelClassCombo '@MG_d2_ModeofJourney'"),
			
						
			     new Triplet<string, string, string>("FWAB_ProjectNo","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMAqCwOWy+D7Ogje1I4jfjiAZNrjEazgaNyfBj9pr2u90lOsHzRNfKnSybWqRxrZGqV",
												     @"EXEC GetProjectNoCombo 1,'@PFMF_UserId'"),
			
						
			     new Triplet<string, string, string>("MFG_d2_ModeofJourney","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMAqCwOWy+D7Ogje1I4jfjiAZNrjEazgaNyfBj9pr2u90lOsHzRNfKnSybWqRxrZGqV",
												     @"EXEC GetTravelAdvanceDetailCombo 4"),
			
						
			     new Triplet<string, string, string>("MG_d2_ModeofJourney","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMAqCwOWy+D7Ogje1I4jfjiAZNrjEazgaNyfBj9pr2u90lOsHzRNfKnSybWqRxrZGqV",
												     @"EXEC GetTravelAdvanceDetailCombo 4"),
			
						
			     new Triplet<string, string, string>("MF_d1_IsAdvanceRequired","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMAqCwOWy+D7Ogje1I4jfjiAZNrjEazgaNyfBj9pr2u90lOsHzRNfKnSybWqRxrZGqV",
												     @"EXEC GetYesNoCombo"),
			
						
			     new Triplet<string, string, string>("WMF_MoveTo","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMAX4svK5cDYCPw2sEhYNSLVUgHvT8EwteQ6Cu6POiqivUqpEh16s8+yjMECvtOIho/Hsxg7bNByVU=",
												     @"EXEC GetNextStep '@WMF_InstanceId','@WF_FlowType'"),
			
						
			     new Triplet<string, string, string>("FWFM_FundType","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMA18yFT7KruzVDa0TqsqpOM+grujzoqor1KqRIderPPsozBAr7TiIaPx7MYO2zQclV",
												     @"exec SP_GetDistrubitionDetails 4,'@PFMF_PackageProcessMapId','',''"),
			
						
			     new Triplet<string, string, string>("MG_d3_ExpenditureType","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMAqCwOWy+D7Ogje1I4jfjiAZNrjEazgaNyfBj9pr2u90lOsHzRNfKnSybWqRxrZGqV",
												     @"EXEC GetTravelAdvanceView 3,''"),
			
						
			     new Triplet<string, string, string>("MFG_d3_ExpenditureType","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMAqCwOWy+D7Ogje1I4jfjiAZNrjEazgaNyfBj9pr2u90lOsHzRNfKnSybWqRxrZGqV",
												     @"EXEC GetTravelAdvanceView 3,''"),
			
						
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
		
	  			
			     new Tuple<string, int>("ExpenseDetails",5),
			
						
			     new Tuple<string, int>("MG_FundAllocation",5),
			
						
			     new Tuple<string, int>("MG_AvailableBudget",200),
			
						
			     new Tuple<string, int>("MG_RequiredDocuments",5),
			
						
			     new Tuple<string, int>("AdvanceDetails",5),
			
						
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
											case "F1E21952-3E9A-4F37-9C42-2F86E1775788":
							virtualInstance=new ISpaceF1E219523E9A4F379C422F86E1775788();
							break;
					
											case "34A8F37F-24BF-4316-826B-DF78EE6E8579":
							virtualInstance=new ISpace34A8F37F24BF4316826BDF78EE6E8579();
							break;
					
											case "A09DFE70-5741-4CBD-A7B7-6CCED54DCE3D":
							virtualInstance=new ISpaceA09DFE7057414CBDA7B76CCED54DCE3D();
							break;
					
											case "C1E33E74-5080-471B-9D13-5EC3EC7C54E8":
							virtualInstance=new ISpaceC1E33E745080471B9D135EC3EC7C54E8();
							break;
					
											case "82118DD8-5B26-4EE2-8171-D616101898A6":
							virtualInstance=new ISpace82118DD85B264EE28171D616101898A6();
							break;
					
											case "98d8749e-f1dc-685b-3509-35353f8b3c3d":
							virtualInstance=new ISpace98d8749ef1dc685b350935353f8b3c3d();
							break;
					
											case "53f85601-40a8-3229-8209-00367a5bc621":
							virtualInstance=new ISpace53f8560140a83229820900367a5bc621();
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
	

	public partial class TravelRequestNewDataElementFactory  : ExtElementBase
    {

     /// <summary>
        /// A <see cref="log4net.ILog"/> that contains the logger instance for 
        /// logging
        /// </summary>
        private readonly ILog _sysLog;

        public TravelRequestNewDataElementFactory()
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

               
                
                                      case "5D394C98-9AAB-4228-B011-FC8008C3247C":
                    {
                     
                                     fInsertQuery=@"IF NOT EXISTS(SELECT 1 FROM [5D394C98-9AAB-4228-B011-FC8008C3247C] WHERE InstanceId='{0}') BEGIN INSERT INTO [5D394C98-9AAB-4228-B011-FC8008C3247C](ProcessActivityMapId,FormId,WMF_IsInFlow,WMF_MoveTo,Comments,WMF_InstanceId,Subject,ExecutionStatus,ExecutionMessage,SetDestinationTo,SLATime,MF_d1_TravelAdvanceID,MF_d1_EmployeeBasicInfoId,MF_d1_ReferenceNo,MF_d1_JourneyPurpose,MF_d1_TravelType,MF_d1_TravelPlace,MF_d1_IsAdvanceRequired,MF_d1_PaymentRemittenceTo,MF_d1_BeneficiaryName,MF_d1_AccountNo,MF_d1_BankName,MF_d1_IFSCCode,MF_d1_BankDocument,MF_d1_TransactionNo,MF_d1_TransactionDate,MF_d1_TotalAmount,MF_d1_AdvanceAmount,MF_d1_TravelStatus,MF_d1_TSAmount,MF_d1_TSStatus,MF_d1_PITransactionNo,MF_d1_PITransactionDate,MF_d1_TSTransactionNo,MF_d1_TSTransactionDate,MF_d1_CreatedBy,MF_d1_CreatedOn,AssignToRole,AssignToUser,IN_Priority,IN_InstanceName,IN_SLA,IN_Status,IN_Category,ExecuteCommand,RedirectUrl,Thumbnail,CancelRedirectUrl,KeyContext,DisplayContext,growid,MF_TotaTravellExpense,MF_TotalOtherExpense,MF_EligibleAdavnce,FWFM_FundDetailsId,FWFM_FundType,FWFM_ProjectNo,FWFM_BudgetHead,FWFM_Amount,PFMF_PackageProcessMapId,FWAB_ProjectNo,PFMF_UserId,PFM_ErrId,PFM_ErrMsg,PFM_FundDetailsId,InstanceId,UC_EmailId,UC_PhoneNumber,UC_Paylevel,UC_Grade,UC_DOJ,UC_DOR,UC_DOB,UC_EmployeeBaicInfoId,UC_EmployeeId,UC_Name,UC_Designation,UC_Department,PF_FundTotal,WF_FlowType,MF_ErrId,MF_ErrMsg,MF_FundTotal)
							VALUES( {3}) END ELSE BEGIN UPDATE [5D394C98-9AAB-4228-B011-FC8008C3247C]SET {4}WHERE InstanceId='{0}'END ";

                                     colList=@"ProcessActivityMapId,FormId,WMF_IsInFlow,WMF_MoveTo,Comments,WMF_InstanceId,Subject,ExecutionStatus,ExecutionMessage,SetDestinationTo,SLATime,MF_d1_TravelAdvanceID,MF_d1_EmployeeBasicInfoId,MF_d1_ReferenceNo,MF_d1_JourneyPurpose,MF_d1_TravelType,MF_d1_TravelPlace,MF_d1_IsAdvanceRequired,MF_d1_PaymentRemittenceTo,MF_d1_BeneficiaryName,MF_d1_AccountNo,MF_d1_BankName,MF_d1_IFSCCode,MF_d1_BankDocument,MF_d1_TransactionNo,MF_d1_TransactionDate,MF_d1_TotalAmount,MF_d1_AdvanceAmount,MF_d1_TravelStatus,MF_d1_TSAmount,MF_d1_TSStatus,MF_d1_PITransactionNo,MF_d1_PITransactionDate,MF_d1_TSTransactionNo,MF_d1_TSTransactionDate,MF_d1_CreatedBy,MF_d1_CreatedOn,AssignToRole,AssignToUser,IN_Priority,IN_InstanceName,IN_SLA,IN_Status,IN_Category,ExecuteCommand,RedirectUrl,Thumbnail,CancelRedirectUrl,KeyContext,DisplayContext,growid,MF_TotaTravellExpense,MF_TotalOtherExpense,MF_EligibleAdavnce,FWFM_FundDetailsId,FWFM_FundType,FWFM_ProjectNo,FWFM_BudgetHead,FWFM_Amount,PFMF_PackageProcessMapId,FWAB_ProjectNo,PFMF_UserId,PFM_ErrId,PFM_ErrMsg,PFM_FundDetailsId,InstanceId,UC_EmailId,UC_PhoneNumber,UC_Paylevel,UC_Grade,UC_DOJ,UC_DOR,UC_DOB,UC_EmployeeBaicInfoId,UC_EmployeeId,UC_Name,UC_Designation,UC_Department,PF_FundTotal,WF_FlowType,MF_ErrId,MF_ErrMsg,MF_FundTotal";
                                    
                     
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

                
                 
                                      case "25967012-E902-4718-B75F-2ECC20C16014":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_25967012E9024718B75F2ECC20C16014 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [WMC_StepFrom] VARCHAR(MAX)	, [WMC_StepTo] VARCHAR(MAX)	, [WMC_Comments] VARCHAR(MAX)	, [WMC_User] VARCHAR(MAX)	, [WMC_DateofComments] DATETIME){0}INSERT INTO [25967012-E902-4718-B75F-2ECC20C16014](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,WMC_StepFrom,WMC_StepTo,WMC_Comments,WMC_User,WMC_DateofComments)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.WMC_StepFrom,TDT.WMC_StepTo,TDT.WMC_Comments,TDT.WMC_User,TDT.WMC_DateofComments FROM @TBL_25967012E9024718B75F2ECC20C16014 TDT
							LEFT JOIN [25967012-E902-4718-B75F-2ECC20C16014] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,WMC_StepFrom=TDT.WMC_StepFrom,WMC_StepTo=TDT.WMC_StepTo,WMC_Comments=TDT.WMC_Comments,WMC_User=TDT.WMC_User,WMC_DateofComments=TDT.WMC_DateofComments FROM @TBL_25967012E9024718B75F2ECC20C16014 TDT
							JOIN [25967012-E902-4718-B75F-2ECC20C16014] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,WMC_StepFrom,WMC_StepTo,WMC_Comments,WMC_User,WMC_DateofComments";

                                     tempInsertQuery=@"INSERT INTO @TBL_25967012E9024718B75F2ECC20C16014(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,WMC_StepFrom,WMC_StepTo,WMC_Comments,WMC_User,WMC_DateofComments)VALUES({0});";
                                     

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
                     
                                    case "93B856A5-0D32-4A27-8B58-5BFE5FF0162C":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_93B856A50D324A278B585BFE5FF0162C AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_d2_TADetailsID] VARCHAR(MAX)	, [MG_d2_TravelAdvanceID] VARCHAR(MAX)	, [MG_d2_Departure] VARCHAR(MAX)	, [MG_d2_DepartureDate] DATETIME	, [MG_d2_DepartureTime] VARCHAR(MAX)	, [MG_d2_Arrival] VARCHAR(MAX)	, [MG_d2_ArrivalDate] DATETIME	, [MG_d2_ArrivalTime] VARCHAR(MAX)	, [MG_d2_ModeofJourney] VARCHAR(250)	, [MG_d2_JourneyClass] VARCHAR(250)	, [MG_d2_Road] INT	, [MG_d2_PNRNo] VARCHAR(MAX)	, [MG_d2_Amount] DECIMAL(18,2)	, [MG_d2_IsTravelRequest] INT	, [MG_d2_UpdatedBy] INT	, [MG_d2_UpdatedOn] DATETIME){0}INSERT INTO [93B856A5-0D32-4A27-8B58-5BFE5FF0162C](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d2_TADetailsID,MG_d2_TravelAdvanceID,MG_d2_Departure,MG_d2_DepartureDate,MG_d2_DepartureTime,MG_d2_Arrival,MG_d2_ArrivalDate,MG_d2_ArrivalTime,MG_d2_ModeofJourney,MG_d2_JourneyClass,MG_d2_Road,MG_d2_PNRNo,MG_d2_Amount,MG_d2_IsTravelRequest,MG_d2_UpdatedBy,MG_d2_UpdatedOn)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_d2_TADetailsID,TDT.MG_d2_TravelAdvanceID,TDT.MG_d2_Departure,TDT.MG_d2_DepartureDate,TDT.MG_d2_DepartureTime,TDT.MG_d2_Arrival,TDT.MG_d2_ArrivalDate,TDT.MG_d2_ArrivalTime,TDT.MG_d2_ModeofJourney,TDT.MG_d2_JourneyClass,TDT.MG_d2_Road,TDT.MG_d2_PNRNo,TDT.MG_d2_Amount,TDT.MG_d2_IsTravelRequest,TDT.MG_d2_UpdatedBy,TDT.MG_d2_UpdatedOn FROM @TBL_93B856A50D324A278B585BFE5FF0162C TDT
							LEFT JOIN [93B856A5-0D32-4A27-8B58-5BFE5FF0162C] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MG_d2_TADetailsID=TDT.MG_d2_TADetailsID,MG_d2_TravelAdvanceID=TDT.MG_d2_TravelAdvanceID,MG_d2_Departure=TDT.MG_d2_Departure,MG_d2_DepartureDate=TDT.MG_d2_DepartureDate,MG_d2_DepartureTime=TDT.MG_d2_DepartureTime,MG_d2_Arrival=TDT.MG_d2_Arrival,MG_d2_ArrivalDate=TDT.MG_d2_ArrivalDate,MG_d2_ArrivalTime=TDT.MG_d2_ArrivalTime,MG_d2_ModeofJourney=TDT.MG_d2_ModeofJourney,MG_d2_JourneyClass=TDT.MG_d2_JourneyClass,MG_d2_Road=TDT.MG_d2_Road,MG_d2_PNRNo=TDT.MG_d2_PNRNo,MG_d2_Amount=TDT.MG_d2_Amount,MG_d2_IsTravelRequest=TDT.MG_d2_IsTravelRequest,MG_d2_UpdatedBy=TDT.MG_d2_UpdatedBy,MG_d2_UpdatedOn=TDT.MG_d2_UpdatedOn FROM @TBL_93B856A50D324A278B585BFE5FF0162C TDT
							JOIN [93B856A5-0D32-4A27-8B58-5BFE5FF0162C] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d2_TADetailsID,MG_d2_TravelAdvanceID,MG_d2_Departure,MG_d2_DepartureDate,MG_d2_DepartureTime,MG_d2_Arrival,MG_d2_ArrivalDate,MG_d2_ArrivalTime,MG_d2_ModeofJourney,MG_d2_JourneyClass,MG_d2_Road,MG_d2_PNRNo,MG_d2_Amount,MG_d2_IsTravelRequest,MG_d2_UpdatedBy,MG_d2_UpdatedOn";

                                     tempInsertQuery=@"INSERT INTO @TBL_93B856A50D324A278B585BFE5FF0162C(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d2_TADetailsID,MG_d2_TravelAdvanceID,MG_d2_Departure,MG_d2_DepartureDate,MG_d2_DepartureTime,MG_d2_Arrival,MG_d2_ArrivalDate,MG_d2_ArrivalTime,MG_d2_ModeofJourney,MG_d2_JourneyClass,MG_d2_Road,MG_d2_PNRNo,MG_d2_Amount,MG_d2_IsTravelRequest,MG_d2_UpdatedBy,MG_d2_UpdatedOn)VALUES({0});";
                                     

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
                     
                                    case "63762982-2C07-4E60-8D86-D3A35CA53EDA":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_637629822C074E608D86D3A35CA53EDA AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_d3_ExpenditureTypeID] VARCHAR(MAX)	, [MG_d3_TravelAdvanceID] VARCHAR(MAX)	, [MG_d3_FromDate] DATETIME	, [MG_d3_ToDate] DATETIME	, [MG_d3_Amount] DECIMAL(18,2)	, [MG_d3_UpdatedBy] INT	, [MG_d3_UpdatedOn] DATETIME	, [MG_d3_ExpenditureType] VARCHAR(250)	, [MG_d3_OtherExpenditureType] VARCHAR(MAX)	, [MG_d3_IsTravelRequest] INT){0}INSERT INTO [63762982-2C07-4E60-8D86-D3A35CA53EDA](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d3_ExpenditureTypeID,MG_d3_TravelAdvanceID,MG_d3_FromDate,MG_d3_ToDate,MG_d3_Amount,MG_d3_UpdatedBy,MG_d3_UpdatedOn,MG_d3_ExpenditureType,MG_d3_OtherExpenditureType,MG_d3_IsTravelRequest)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_d3_ExpenditureTypeID,TDT.MG_d3_TravelAdvanceID,TDT.MG_d3_FromDate,TDT.MG_d3_ToDate,TDT.MG_d3_Amount,TDT.MG_d3_UpdatedBy,TDT.MG_d3_UpdatedOn,TDT.MG_d3_ExpenditureType,TDT.MG_d3_OtherExpenditureType,TDT.MG_d3_IsTravelRequest FROM @TBL_637629822C074E608D86D3A35CA53EDA TDT
							LEFT JOIN [63762982-2C07-4E60-8D86-D3A35CA53EDA] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MG_d3_ExpenditureTypeID=TDT.MG_d3_ExpenditureTypeID,MG_d3_TravelAdvanceID=TDT.MG_d3_TravelAdvanceID,MG_d3_FromDate=TDT.MG_d3_FromDate,MG_d3_ToDate=TDT.MG_d3_ToDate,MG_d3_Amount=TDT.MG_d3_Amount,MG_d3_UpdatedBy=TDT.MG_d3_UpdatedBy,MG_d3_UpdatedOn=TDT.MG_d3_UpdatedOn,MG_d3_ExpenditureType=TDT.MG_d3_ExpenditureType,MG_d3_OtherExpenditureType=TDT.MG_d3_OtherExpenditureType,MG_d3_IsTravelRequest=TDT.MG_d3_IsTravelRequest FROM @TBL_637629822C074E608D86D3A35CA53EDA TDT
							JOIN [63762982-2C07-4E60-8D86-D3A35CA53EDA] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d3_ExpenditureTypeID,MG_d3_TravelAdvanceID,MG_d3_FromDate,MG_d3_ToDate,MG_d3_Amount,MG_d3_UpdatedBy,MG_d3_UpdatedOn,MG_d3_ExpenditureType,MG_d3_OtherExpenditureType,MG_d3_IsTravelRequest";

                                     tempInsertQuery=@"INSERT INTO @TBL_637629822C074E608D86D3A35CA53EDA(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d3_ExpenditureTypeID,MG_d3_TravelAdvanceID,MG_d3_FromDate,MG_d3_ToDate,MG_d3_Amount,MG_d3_UpdatedBy,MG_d3_UpdatedOn,MG_d3_ExpenditureType,MG_d3_OtherExpenditureType,MG_d3_IsTravelRequest)VALUES({0});";
                                     

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
                     
                                    case "D16E4242-8604-48C1-8EF4-A05C77ED8CF5":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_D16E4242860448C18EF4A05C77ED8CF5 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [PFA_FundType] VARCHAR(MAX)	, [PFA_FundTypeValue] VARCHAR(MAX)	, [PFA_ProjectNo] VARCHAR(MAX)	, [PFA_ProjectNoValue] VARCHAR(MAX)	, [PFA_BudgetHead] VARCHAR(MAX)	, [PFA_BudgetHeadValue] VARCHAR(MAX)	, [PFA_Amount] DECIMAL(18,2)	, [PFA_FundDetailsId] VARCHAR(MAX)){0}INSERT INTO [D16E4242-8604-48C1-8EF4-A05C77ED8CF5](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PFA_FundType,PFA_FundTypeValue,PFA_ProjectNo,PFA_ProjectNoValue,PFA_BudgetHead,PFA_BudgetHeadValue,PFA_Amount,PFA_FundDetailsId)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.PFA_FundType,TDT.PFA_FundTypeValue,TDT.PFA_ProjectNo,TDT.PFA_ProjectNoValue,TDT.PFA_BudgetHead,TDT.PFA_BudgetHeadValue,TDT.PFA_Amount,TDT.PFA_FundDetailsId FROM @TBL_D16E4242860448C18EF4A05C77ED8CF5 TDT
							LEFT JOIN [D16E4242-8604-48C1-8EF4-A05C77ED8CF5] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,PFA_FundType=TDT.PFA_FundType,PFA_FundTypeValue=TDT.PFA_FundTypeValue,PFA_ProjectNo=TDT.PFA_ProjectNo,PFA_ProjectNoValue=TDT.PFA_ProjectNoValue,PFA_BudgetHead=TDT.PFA_BudgetHead,PFA_BudgetHeadValue=TDT.PFA_BudgetHeadValue,PFA_Amount=TDT.PFA_Amount,PFA_FundDetailsId=TDT.PFA_FundDetailsId FROM @TBL_D16E4242860448C18EF4A05C77ED8CF5 TDT
							JOIN [D16E4242-8604-48C1-8EF4-A05C77ED8CF5] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PFA_FundType,PFA_FundTypeValue,PFA_ProjectNo,PFA_ProjectNoValue,PFA_BudgetHead,PFA_BudgetHeadValue,PFA_Amount,PFA_FundDetailsId";

                                     tempInsertQuery=@"INSERT INTO @TBL_D16E4242860448C18EF4A05C77ED8CF5(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PFA_FundType,PFA_FundTypeValue,PFA_ProjectNo,PFA_ProjectNoValue,PFA_BudgetHead,PFA_BudgetHeadValue,PFA_Amount,PFA_FundDetailsId)VALUES({0});";
                                     

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
                     
                                    case "A2ABDF83-3F20-4844-9175-EC5BCC4B7DCC":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_A2ABDF833F2048449175EC5BCC4B7DCC AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [PAB_BudgetName] VARCHAR(MAX)	, [PAB_SanctionedAmount] DECIMAL(18,2)	, [PAB_YetToRecieve] DECIMAL(18,2)	, [PAB_RecievedAmount] DECIMAL(18,2)	, [PAB_Commitment] DECIMAL(18,2)	, [PAB_Spent] DECIMAL(18,2)	, [PAB_Balance] DECIMAL(18,2)){0}INSERT INTO [A2ABDF83-3F20-4844-9175-EC5BCC4B7DCC](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PAB_BudgetName,PAB_SanctionedAmount,PAB_YetToRecieve,PAB_RecievedAmount,PAB_Commitment,PAB_Spent,PAB_Balance)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.PAB_BudgetName,TDT.PAB_SanctionedAmount,TDT.PAB_YetToRecieve,TDT.PAB_RecievedAmount,TDT.PAB_Commitment,TDT.PAB_Spent,TDT.PAB_Balance FROM @TBL_A2ABDF833F2048449175EC5BCC4B7DCC TDT
							LEFT JOIN [A2ABDF83-3F20-4844-9175-EC5BCC4B7DCC] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,PAB_BudgetName=TDT.PAB_BudgetName,PAB_SanctionedAmount=TDT.PAB_SanctionedAmount,PAB_YetToRecieve=TDT.PAB_YetToRecieve,PAB_RecievedAmount=TDT.PAB_RecievedAmount,PAB_Commitment=TDT.PAB_Commitment,PAB_Spent=TDT.PAB_Spent,PAB_Balance=TDT.PAB_Balance FROM @TBL_A2ABDF833F2048449175EC5BCC4B7DCC TDT
							JOIN [A2ABDF83-3F20-4844-9175-EC5BCC4B7DCC] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PAB_BudgetName,PAB_SanctionedAmount,PAB_YetToRecieve,PAB_RecievedAmount,PAB_Commitment,PAB_Spent,PAB_Balance";

                                     tempInsertQuery=@"INSERT INTO @TBL_A2ABDF833F2048449175EC5BCC4B7DCC(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PAB_BudgetName,PAB_SanctionedAmount,PAB_YetToRecieve,PAB_RecievedAmount,PAB_Commitment,PAB_Spent,PAB_Balance)VALUES({0});";
                                     

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
                     
                                    case "281302FF-406D-4F35-B5E6-D8D09F04484C":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_281302FF406D4F35B5E6D8D09F04484C AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [PADD_DocumentName] VARCHAR(MAX)	, [PADD_Document] VARCHAR(MAX)){0}INSERT INTO [281302FF-406D-4F35-B5E6-D8D09F04484C](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PADD_DocumentName,PADD_Document)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.PADD_DocumentName,TDT.PADD_Document FROM @TBL_281302FF406D4F35B5E6D8D09F04484C TDT
							LEFT JOIN [281302FF-406D-4F35-B5E6-D8D09F04484C] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,PADD_DocumentName=TDT.PADD_DocumentName,PADD_Document=TDT.PADD_Document FROM @TBL_281302FF406D4F35B5E6D8D09F04484C TDT
							JOIN [281302FF-406D-4F35-B5E6-D8D09F04484C] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PADD_DocumentName,PADD_Document";

                                     tempInsertQuery=@"INSERT INTO @TBL_281302FF406D4F35B5E6D8D09F04484C(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PADD_DocumentName,PADD_Document)VALUES({0});";
                                     

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
                     

                                         case "25967012-E902-4718-B75F-2ECC20C16014":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_25967012E9024718B75F2ECC20C16014 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [WMC_StepFrom] VARCHAR(MAX)	, [WMC_StepTo] VARCHAR(MAX)	, [WMC_Comments] VARCHAR(MAX)	, [WMC_User] VARCHAR(MAX)	, [WMC_DateofComments] DATETIME){0}INSERT INTO [25967012-E902-4718-B75F-2ECC20C16014](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,WMC_StepFrom,WMC_StepTo,WMC_Comments,WMC_User,WMC_DateofComments)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.WMC_StepFrom,TDT.WMC_StepTo,TDT.WMC_Comments,TDT.WMC_User,TDT.WMC_DateofComments FROM @TBL_25967012E9024718B75F2ECC20C16014 TDT
							LEFT JOIN [25967012-E902-4718-B75F-2ECC20C16014] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,WMC_StepFrom=TDT.WMC_StepFrom,WMC_StepTo=TDT.WMC_StepTo,WMC_Comments=TDT.WMC_Comments,WMC_User=TDT.WMC_User,WMC_DateofComments=TDT.WMC_DateofComments FROM @TBL_25967012E9024718B75F2ECC20C16014 TDT
							JOIN [25967012-E902-4718-B75F-2ECC20C16014] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,WMC_StepFrom,WMC_StepTo,WMC_Comments,WMC_User,WMC_DateofComments";

                            tempInsertQuery=@"INSERT INTO @TBL_25967012E9024718B75F2ECC20C16014(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,WMC_StepFrom,WMC_StepTo,WMC_Comments,WMC_User,WMC_DateofComments)VALUES({0});";

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

                                              case "93B856A5-0D32-4A27-8B58-5BFE5FF0162C":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_93B856A50D324A278B585BFE5FF0162C AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_d2_TADetailsID] VARCHAR(MAX)	, [MG_d2_TravelAdvanceID] VARCHAR(MAX)	, [MG_d2_Departure] VARCHAR(MAX)	, [MG_d2_DepartureDate] DATETIME	, [MG_d2_DepartureTime] VARCHAR(MAX)	, [MG_d2_Arrival] VARCHAR(MAX)	, [MG_d2_ArrivalDate] DATETIME	, [MG_d2_ArrivalTime] VARCHAR(MAX)	, [MG_d2_ModeofJourney] VARCHAR(250)	, [MG_d2_JourneyClass] VARCHAR(250)	, [MG_d2_Road] INT	, [MG_d2_PNRNo] VARCHAR(MAX)	, [MG_d2_Amount] DECIMAL(18,2)	, [MG_d2_IsTravelRequest] INT	, [MG_d2_UpdatedBy] INT	, [MG_d2_UpdatedOn] DATETIME){0}INSERT INTO [93B856A5-0D32-4A27-8B58-5BFE5FF0162C](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d2_TADetailsID,MG_d2_TravelAdvanceID,MG_d2_Departure,MG_d2_DepartureDate,MG_d2_DepartureTime,MG_d2_Arrival,MG_d2_ArrivalDate,MG_d2_ArrivalTime,MG_d2_ModeofJourney,MG_d2_JourneyClass,MG_d2_Road,MG_d2_PNRNo,MG_d2_Amount,MG_d2_IsTravelRequest,MG_d2_UpdatedBy,MG_d2_UpdatedOn)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_d2_TADetailsID,TDT.MG_d2_TravelAdvanceID,TDT.MG_d2_Departure,TDT.MG_d2_DepartureDate,TDT.MG_d2_DepartureTime,TDT.MG_d2_Arrival,TDT.MG_d2_ArrivalDate,TDT.MG_d2_ArrivalTime,TDT.MG_d2_ModeofJourney,TDT.MG_d2_JourneyClass,TDT.MG_d2_Road,TDT.MG_d2_PNRNo,TDT.MG_d2_Amount,TDT.MG_d2_IsTravelRequest,TDT.MG_d2_UpdatedBy,TDT.MG_d2_UpdatedOn FROM @TBL_93B856A50D324A278B585BFE5FF0162C TDT
							LEFT JOIN [93B856A5-0D32-4A27-8B58-5BFE5FF0162C] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MG_d2_TADetailsID=TDT.MG_d2_TADetailsID,MG_d2_TravelAdvanceID=TDT.MG_d2_TravelAdvanceID,MG_d2_Departure=TDT.MG_d2_Departure,MG_d2_DepartureDate=TDT.MG_d2_DepartureDate,MG_d2_DepartureTime=TDT.MG_d2_DepartureTime,MG_d2_Arrival=TDT.MG_d2_Arrival,MG_d2_ArrivalDate=TDT.MG_d2_ArrivalDate,MG_d2_ArrivalTime=TDT.MG_d2_ArrivalTime,MG_d2_ModeofJourney=TDT.MG_d2_ModeofJourney,MG_d2_JourneyClass=TDT.MG_d2_JourneyClass,MG_d2_Road=TDT.MG_d2_Road,MG_d2_PNRNo=TDT.MG_d2_PNRNo,MG_d2_Amount=TDT.MG_d2_Amount,MG_d2_IsTravelRequest=TDT.MG_d2_IsTravelRequest,MG_d2_UpdatedBy=TDT.MG_d2_UpdatedBy,MG_d2_UpdatedOn=TDT.MG_d2_UpdatedOn FROM @TBL_93B856A50D324A278B585BFE5FF0162C TDT
							JOIN [93B856A5-0D32-4A27-8B58-5BFE5FF0162C] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d2_TADetailsID,MG_d2_TravelAdvanceID,MG_d2_Departure,MG_d2_DepartureDate,MG_d2_DepartureTime,MG_d2_Arrival,MG_d2_ArrivalDate,MG_d2_ArrivalTime,MG_d2_ModeofJourney,MG_d2_JourneyClass,MG_d2_Road,MG_d2_PNRNo,MG_d2_Amount,MG_d2_IsTravelRequest,MG_d2_UpdatedBy,MG_d2_UpdatedOn";

                            tempInsertQuery=@"INSERT INTO @TBL_93B856A50D324A278B585BFE5FF0162C(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d2_TADetailsID,MG_d2_TravelAdvanceID,MG_d2_Departure,MG_d2_DepartureDate,MG_d2_DepartureTime,MG_d2_Arrival,MG_d2_ArrivalDate,MG_d2_ArrivalTime,MG_d2_ModeofJourney,MG_d2_JourneyClass,MG_d2_Road,MG_d2_PNRNo,MG_d2_Amount,MG_d2_IsTravelRequest,MG_d2_UpdatedBy,MG_d2_UpdatedOn)VALUES({0});";

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

                                              case "63762982-2C07-4E60-8D86-D3A35CA53EDA":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_637629822C074E608D86D3A35CA53EDA AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_d3_ExpenditureTypeID] VARCHAR(MAX)	, [MG_d3_TravelAdvanceID] VARCHAR(MAX)	, [MG_d3_FromDate] DATETIME	, [MG_d3_ToDate] DATETIME	, [MG_d3_Amount] DECIMAL(18,2)	, [MG_d3_UpdatedBy] INT	, [MG_d3_UpdatedOn] DATETIME	, [MG_d3_ExpenditureType] VARCHAR(250)	, [MG_d3_OtherExpenditureType] VARCHAR(MAX)	, [MG_d3_IsTravelRequest] INT){0}INSERT INTO [63762982-2C07-4E60-8D86-D3A35CA53EDA](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d3_ExpenditureTypeID,MG_d3_TravelAdvanceID,MG_d3_FromDate,MG_d3_ToDate,MG_d3_Amount,MG_d3_UpdatedBy,MG_d3_UpdatedOn,MG_d3_ExpenditureType,MG_d3_OtherExpenditureType,MG_d3_IsTravelRequest)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_d3_ExpenditureTypeID,TDT.MG_d3_TravelAdvanceID,TDT.MG_d3_FromDate,TDT.MG_d3_ToDate,TDT.MG_d3_Amount,TDT.MG_d3_UpdatedBy,TDT.MG_d3_UpdatedOn,TDT.MG_d3_ExpenditureType,TDT.MG_d3_OtherExpenditureType,TDT.MG_d3_IsTravelRequest FROM @TBL_637629822C074E608D86D3A35CA53EDA TDT
							LEFT JOIN [63762982-2C07-4E60-8D86-D3A35CA53EDA] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MG_d3_ExpenditureTypeID=TDT.MG_d3_ExpenditureTypeID,MG_d3_TravelAdvanceID=TDT.MG_d3_TravelAdvanceID,MG_d3_FromDate=TDT.MG_d3_FromDate,MG_d3_ToDate=TDT.MG_d3_ToDate,MG_d3_Amount=TDT.MG_d3_Amount,MG_d3_UpdatedBy=TDT.MG_d3_UpdatedBy,MG_d3_UpdatedOn=TDT.MG_d3_UpdatedOn,MG_d3_ExpenditureType=TDT.MG_d3_ExpenditureType,MG_d3_OtherExpenditureType=TDT.MG_d3_OtherExpenditureType,MG_d3_IsTravelRequest=TDT.MG_d3_IsTravelRequest FROM @TBL_637629822C074E608D86D3A35CA53EDA TDT
							JOIN [63762982-2C07-4E60-8D86-D3A35CA53EDA] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d3_ExpenditureTypeID,MG_d3_TravelAdvanceID,MG_d3_FromDate,MG_d3_ToDate,MG_d3_Amount,MG_d3_UpdatedBy,MG_d3_UpdatedOn,MG_d3_ExpenditureType,MG_d3_OtherExpenditureType,MG_d3_IsTravelRequest";

                            tempInsertQuery=@"INSERT INTO @TBL_637629822C074E608D86D3A35CA53EDA(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d3_ExpenditureTypeID,MG_d3_TravelAdvanceID,MG_d3_FromDate,MG_d3_ToDate,MG_d3_Amount,MG_d3_UpdatedBy,MG_d3_UpdatedOn,MG_d3_ExpenditureType,MG_d3_OtherExpenditureType,MG_d3_IsTravelRequest)VALUES({0});";

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

                                              case "D16E4242-8604-48C1-8EF4-A05C77ED8CF5":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_D16E4242860448C18EF4A05C77ED8CF5 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [PFA_FundType] VARCHAR(MAX)	, [PFA_FundTypeValue] VARCHAR(MAX)	, [PFA_ProjectNo] VARCHAR(MAX)	, [PFA_ProjectNoValue] VARCHAR(MAX)	, [PFA_BudgetHead] VARCHAR(MAX)	, [PFA_BudgetHeadValue] VARCHAR(MAX)	, [PFA_Amount] DECIMAL(18,2)	, [PFA_FundDetailsId] VARCHAR(MAX)){0}INSERT INTO [D16E4242-8604-48C1-8EF4-A05C77ED8CF5](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PFA_FundType,PFA_FundTypeValue,PFA_ProjectNo,PFA_ProjectNoValue,PFA_BudgetHead,PFA_BudgetHeadValue,PFA_Amount,PFA_FundDetailsId)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.PFA_FundType,TDT.PFA_FundTypeValue,TDT.PFA_ProjectNo,TDT.PFA_ProjectNoValue,TDT.PFA_BudgetHead,TDT.PFA_BudgetHeadValue,TDT.PFA_Amount,TDT.PFA_FundDetailsId FROM @TBL_D16E4242860448C18EF4A05C77ED8CF5 TDT
							LEFT JOIN [D16E4242-8604-48C1-8EF4-A05C77ED8CF5] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,PFA_FundType=TDT.PFA_FundType,PFA_FundTypeValue=TDT.PFA_FundTypeValue,PFA_ProjectNo=TDT.PFA_ProjectNo,PFA_ProjectNoValue=TDT.PFA_ProjectNoValue,PFA_BudgetHead=TDT.PFA_BudgetHead,PFA_BudgetHeadValue=TDT.PFA_BudgetHeadValue,PFA_Amount=TDT.PFA_Amount,PFA_FundDetailsId=TDT.PFA_FundDetailsId FROM @TBL_D16E4242860448C18EF4A05C77ED8CF5 TDT
							JOIN [D16E4242-8604-48C1-8EF4-A05C77ED8CF5] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PFA_FundType,PFA_FundTypeValue,PFA_ProjectNo,PFA_ProjectNoValue,PFA_BudgetHead,PFA_BudgetHeadValue,PFA_Amount,PFA_FundDetailsId";

                            tempInsertQuery=@"INSERT INTO @TBL_D16E4242860448C18EF4A05C77ED8CF5(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PFA_FundType,PFA_FundTypeValue,PFA_ProjectNo,PFA_ProjectNoValue,PFA_BudgetHead,PFA_BudgetHeadValue,PFA_Amount,PFA_FundDetailsId)VALUES({0});";

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

                                              case "A2ABDF83-3F20-4844-9175-EC5BCC4B7DCC":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_A2ABDF833F2048449175EC5BCC4B7DCC AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [PAB_BudgetName] VARCHAR(MAX)	, [PAB_SanctionedAmount] DECIMAL(18,2)	, [PAB_YetToRecieve] DECIMAL(18,2)	, [PAB_RecievedAmount] DECIMAL(18,2)	, [PAB_Commitment] DECIMAL(18,2)	, [PAB_Spent] DECIMAL(18,2)	, [PAB_Balance] DECIMAL(18,2)){0}INSERT INTO [A2ABDF83-3F20-4844-9175-EC5BCC4B7DCC](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PAB_BudgetName,PAB_SanctionedAmount,PAB_YetToRecieve,PAB_RecievedAmount,PAB_Commitment,PAB_Spent,PAB_Balance)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.PAB_BudgetName,TDT.PAB_SanctionedAmount,TDT.PAB_YetToRecieve,TDT.PAB_RecievedAmount,TDT.PAB_Commitment,TDT.PAB_Spent,TDT.PAB_Balance FROM @TBL_A2ABDF833F2048449175EC5BCC4B7DCC TDT
							LEFT JOIN [A2ABDF83-3F20-4844-9175-EC5BCC4B7DCC] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,PAB_BudgetName=TDT.PAB_BudgetName,PAB_SanctionedAmount=TDT.PAB_SanctionedAmount,PAB_YetToRecieve=TDT.PAB_YetToRecieve,PAB_RecievedAmount=TDT.PAB_RecievedAmount,PAB_Commitment=TDT.PAB_Commitment,PAB_Spent=TDT.PAB_Spent,PAB_Balance=TDT.PAB_Balance FROM @TBL_A2ABDF833F2048449175EC5BCC4B7DCC TDT
							JOIN [A2ABDF83-3F20-4844-9175-EC5BCC4B7DCC] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PAB_BudgetName,PAB_SanctionedAmount,PAB_YetToRecieve,PAB_RecievedAmount,PAB_Commitment,PAB_Spent,PAB_Balance";

                            tempInsertQuery=@"INSERT INTO @TBL_A2ABDF833F2048449175EC5BCC4B7DCC(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PAB_BudgetName,PAB_SanctionedAmount,PAB_YetToRecieve,PAB_RecievedAmount,PAB_Commitment,PAB_Spent,PAB_Balance)VALUES({0});";

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

                                              case "281302FF-406D-4F35-B5E6-D8D09F04484C":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_281302FF406D4F35B5E6D8D09F04484C AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [PADD_DocumentName] VARCHAR(MAX)	, [PADD_Document] VARCHAR(MAX)){0}INSERT INTO [281302FF-406D-4F35-B5E6-D8D09F04484C](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PADD_DocumentName,PADD_Document)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.PADD_DocumentName,TDT.PADD_Document FROM @TBL_281302FF406D4F35B5E6D8D09F04484C TDT
							LEFT JOIN [281302FF-406D-4F35-B5E6-D8D09F04484C] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,PADD_DocumentName=TDT.PADD_DocumentName,PADD_Document=TDT.PADD_Document FROM @TBL_281302FF406D4F35B5E6D8D09F04484C TDT
							JOIN [281302FF-406D-4F35-B5E6-D8D09F04484C] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PADD_DocumentName,PADD_Document";

                            tempInsertQuery=@"INSERT INTO @TBL_281302FF406D4F35B5E6D8D09F04484C(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PADD_DocumentName,PADD_Document)VALUES({0});";

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
public class ISpaceF1E219523E9A4F379C422F86E1775788 : VirtualForm
{
IISpace iSpace = new ISpace();
AcDataISpaceF1E219523E9A4F379C422F86E1775788 acdataIspaceF1E219523E9A4F379C422F86E1775788=new AcDataISpaceF1E219523E9A4F379C422F86E1775788();
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
if(ISpace["FormVersionId"].Value=="48D9155C-42D2-4414-AF53-3D00D9908DD4")
{
ISpace["UI_PFHideRow"].Visible="false";
}if(ISpace["FormVersionId"].Value=="48D9155C-42D2-4414-AF53-3D00D9908DD4")
{
ISpace["UI_ApprovalHideRow"].Visible="false";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""48D9155C-42D2-4414-AF53-3D00D9908DD4"")
{
ISpace[""UI_PFHideRow""].Visible=""false"";
}if(ISpace[""FormVersionId""].Value==""48D9155C-42D2-4414-AF53-3D00D9908DD4"")
{
ISpace[""UI_ApprovalHideRow""].Visible=""false"";
}");
ISpace["Comments"].Value="";
base.WriteDebugInfo(@"ISpace[""Comments""].Value="""";");
ISpace["WMF_MoveTo"].Value="";
base.WriteDebugInfo(@"ISpace[""WMF_MoveTo""].Value="""";");
}
if(ISpace["WF_FlowType"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""WF_FlowType""].Value=="""")");
ISpace["WMF_IsInFlow"].Value=0;
base.WriteDebugInfo(@"ISpace[""WMF_IsInFlow""].Value=0;");
base.WriteDebugInfo(@"EXEC [GetInstanceInFlow] '@@gv_InstanceId'");

var querySource76804AA1305E4E7F895EB90B051455D5 =GetQueryExpressionDataSource("76804AA1-305E-4E7F-895E-B90B051455D5");
Dictionary<short,object> result76804AA1305E4E7F895EB90B051455D5=iSpace.ExecuteQuery(querySource76804AA1305E4E7F895EB90B051455D5,@"EXEC [GetInstanceInFlow] '" + ISpace["gv_instanceid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource76804AA1305E4E7F895EB90B051455D5 =GetQueryExpressionDataSource(""76804AA1-305E-4E7F-895E-B90B051455D5"");Dictionary<short,object> result76804AA1305E4E7F895EB90B051455D5=iSpace.ExecuteQuery(querySource76804AA1305E4E7F895EB90B051455D5,@""EXEC [GetInstanceInFlow] '"" + ISpace[""gv_instanceid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result76804AA1305E4E7F895EB90B051455D5!=null) && (result76804AA1305E4E7F895EB90B051455D5.Count!=0))
{
if(result76804AA1305E4E7F895EB90B051455D5.ContainsKey(0))
ISpace["WMF_IsInFlow"].Value = result76804AA1305E4E7F895EB90B051455D5[0];
}
else{
ISpace["WMF_IsInFlow"].Value = null;
}
if(ISpace["WMF_IsInFlow"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""WMF_IsInFlow""].Value==1)");
ISpace["WF_FlowType"].Value="APPROVE";
base.WriteDebugInfo(@"ISpace[""WF_FlowType""].Value=""APPROVE"";");
ISpace["WMF_History"].Visible="true";ISpace["WMF_MoveTo"].Visible="true";
base.WriteDebugInfo(@"ISpace[""WMF_History""].Visible=""true"";ISpace[""WMF_MoveTo""].Visible=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["WMF_History"].Visible="false";ISpace["WMF_MoveTo"].Visible="false";
base.WriteDebugInfo(@"ISpace[""WMF_History""].Visible=""false"";ISpace[""WMF_MoveTo""].Visible=""false"";");
}
}
ISpace["WMF_MoveTo"].Man=true;
base.WriteDebugInfo(@"ISpace[""WMF_MoveTo""].Man=true;");
if(ISpace["FWFM_FundType"].Value=="2")
{
base.WriteDebugInfo(@"if(ISpace[""FWFM_FundType""].Value==""2"")");
ISpace["FWFM_BudgetHead"].Visible="false";ISpace["FWFM_ProjectNo"].Visible="false";
base.WriteDebugInfo(@"ISpace[""FWFM_BudgetHead""].Visible=""false"";ISpace[""FWFM_ProjectNo""].Visible=""false"";");
ISpace["FWFM_BudgetHead"].Value="";
base.WriteDebugInfo(@"ISpace[""FWFM_BudgetHead""].Value="""";");
ISpace["FWFM_ProjectNo"].Value="";
base.WriteDebugInfo(@"ISpace[""FWFM_ProjectNo""].Value="""";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["FWFM_BudgetHead"].Visible="true";ISpace["FWFM_ProjectNo"].Visible="true";
base.WriteDebugInfo(@"ISpace[""FWFM_BudgetHead""].Visible=""true"";ISpace[""FWFM_ProjectNo""].Visible=""true"";");
}
if(ISpace["FWFM_FundType"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""FWFM_FundType""].Value=="""")");
ISpace["FWFM_BudgetHead"].Visible="false";ISpace["FWFM_ProjectNo"].Visible="false";ISpace["FWFM_Amount"].Visible="false";
base.WriteDebugInfo(@"ISpace[""FWFM_BudgetHead""].Visible=""false"";ISpace[""FWFM_ProjectNo""].Visible=""false"";ISpace[""FWFM_Amount""].Visible=""false"";");
}
if(ISpace["FormVersionId"].Value=="48D9155C-42D2-4414-AF53-3D00D9908DD4")
{
ISpace["UI_ApprovalHideRow"].Visible="false";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""48D9155C-42D2-4414-AF53-3D00D9908DD4"")
{
ISpace[""UI_ApprovalHideRow""].Visible=""false"";
}");

var querySource698205C52C1A42F39D81823D3215AB11 =GetQueryExpressionDataSource("698205C5-2C1A-42F3-9D81-823D3215AB11");

DataTable result698205C52C1A42F39D81823D3215AB11=iSpace.SetGridDataSource(querySource698205C52C1A42F39D81823D3215AB11, _objectFactory.GetGridRPP("WMG_CommentsHistory"),@"EXEC [GetInstanceFlowDetais] '" + ISpace["gv_instanceid"].Value + @"'");

iSpace.InsertGridBindDetails("WMG_CommentsHistory","11",querySource698205C52C1A42F39D81823D3215AB11,"EXEC [GetInstanceFlowDetais] '" + ISpace["gv_instanceid"].Value + @"'",_objectFactory.GetGridRPP("WMG_CommentsHistory"));

base.WriteDebugInfo(@"var querySource698205C52C1A42F39D81823D3215AB11 =GetQueryExpressionDataSource(""698205C5-2C1A-42F3-9D81-823D3215AB11"");DataTable result698205C52C1A42F39D81823D3215AB11=iSpace.SetGridDataSource(querySource698205C52C1A42F39D81823D3215AB11, _objectFactory.GetGridRPP(""WMG_CommentsHistory""),@""EXEC [GetInstanceFlowDetais] '"" + ISpace[""gv_instanceid""].Value + @""'"");iSpace.InsertGridBindDetails(""WMG_CommentsHistory"",""11"",querySource698205C52C1A42F39D81823D3215AB11,""EXEC [GetInstanceFlowDetais] '"" + ISpace[""gv_instanceid""].Value + @""'"",_objectFactory.GetGridRPP(""WMG_CommentsHistory""));");
ISpace["PFMF_PackageProcessMapId"].Value=ISpace["gv_processmapid"].Value;
base.WriteDebugInfo(@"ISpace[""PFMF_PackageProcessMapId""].Value=ISpace[""gv_processmapid""].Value;");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result794A7328890E42A3B11A5984B2D49196=acdataIspaceF1E219523E9A4F379C422F86E1775788.GetQueryExpressionBindings("794A7328-890E-42A3-B11A-5984B2D49196");
iSpace.SetGridData(result698205C52C1A42F39D81823D3215AB11,result794A7328890E42A3B11A5984B2D49196,"WMG_CommentsHistory",ref ISpace);
iSpace.UpdateGridBindDetails("WMG_CommentsHistory",result794A7328890E42A3B11A5984B2D49196);
ISpace["PFMF_UserId"].Value=ISpace["gv_userid"].Value;
base.WriteDebugInfo(@"ISpace[""PFMF_UserId""].Value=ISpace[""gv_userid""].Value;");
if(ISpace["FormVersionId"].Value=="48D9155C-42D2-4414-AF53-3D00D9908DD4")
{
ISpace["UI_PFHideRow"].Visible="false";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""48D9155C-42D2-4414-AF53-3D00D9908DD4"")
{
ISpace[""UI_PFHideRow""].Visible=""false"";
}");
if(ISpace["MF_d1_TravelAdvanceID"].Value!="0")
{
base.WriteDebugInfo(@"if(ISpace[""MF_d1_TravelAdvanceID""].Value!=""0"")");
base.WriteDebugInfo(@"EXEC InnovaceNoCode..[FormLoadById_5D394C98-9AAB-4228-B011-FC8008C3247C]  '#MF_d1_TravelAdvanceID'");

var querySource8A15D75CE81B41A994470F78A10C69DF =GetQueryExpressionDataSource("8A15D75C-E81B-41A9-9447-0F78A10C69DF");
Dictionary<short,object> result8A15D75CE81B41A994470F78A10C69DF=iSpace.ExecuteQuery(querySource8A15D75CE81B41A994470F78A10C69DF,@"EXEC InnovaceNoCode..[FormLoadById_5D394C98-9AAB-4228-B011-FC8008C3247C]  '" + ISpace["MF_d1_TravelAdvanceID"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource8A15D75CE81B41A994470F78A10C69DF =GetQueryExpressionDataSource(""8A15D75C-E81B-41A9-9447-0F78A10C69DF"");Dictionary<short,object> result8A15D75CE81B41A994470F78A10C69DF=iSpace.ExecuteQuery(querySource8A15D75CE81B41A994470F78A10C69DF,@""EXEC InnovaceNoCode..[FormLoadById_5D394C98-9AAB-4228-B011-FC8008C3247C]  '"" + ISpace[""MF_d1_TravelAdvanceID""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result8A15D75CE81B41A994470F78A10C69DF!=null) && (result8A15D75CE81B41A994470F78A10C69DF.Count!=0))
{
if(result8A15D75CE81B41A994470F78A10C69DF.ContainsKey(23))
ISpace["MF_d1_TSTransactionDate"].Value = result8A15D75CE81B41A994470F78A10C69DF[23];
if(result8A15D75CE81B41A994470F78A10C69DF.ContainsKey(25))
ISpace["MF_d1_CreatedOn"].Value = result8A15D75CE81B41A994470F78A10C69DF[25];
if(result8A15D75CE81B41A994470F78A10C69DF.ContainsKey(21))
ISpace["MF_d1_PITransactionDate"].Value = result8A15D75CE81B41A994470F78A10C69DF[21];
if(result8A15D75CE81B41A994470F78A10C69DF.ContainsKey(14))
ISpace["MF_d1_TransactionDate"].Value = result8A15D75CE81B41A994470F78A10C69DF[14];
if(result8A15D75CE81B41A994470F78A10C69DF.ContainsKey(4))
ISpace["MF_d1_TravelType"].Value = result8A15D75CE81B41A994470F78A10C69DF[4];
if(result8A15D75CE81B41A994470F78A10C69DF.ContainsKey(6))
ISpace["MF_d1_IsAdvanceRequired"].Value = result8A15D75CE81B41A994470F78A10C69DF[6];
if(result8A15D75CE81B41A994470F78A10C69DF.ContainsKey(12))
ISpace["MF_d1_BankDocument"].Value = result8A15D75CE81B41A994470F78A10C69DF[12];
if(result8A15D75CE81B41A994470F78A10C69DF.ContainsKey(15))
ISpace["MF_d1_TotalAmount"].Value = result8A15D75CE81B41A994470F78A10C69DF[15];
if(result8A15D75CE81B41A994470F78A10C69DF.ContainsKey(24))
ISpace["MF_d1_CreatedBy"].Value = result8A15D75CE81B41A994470F78A10C69DF[24];
if(result8A15D75CE81B41A994470F78A10C69DF.ContainsKey(16))
ISpace["MF_d1_AdvanceAmount"].Value = result8A15D75CE81B41A994470F78A10C69DF[16];
if(result8A15D75CE81B41A994470F78A10C69DF.ContainsKey(18))
ISpace["MF_d1_TSAmount"].Value = result8A15D75CE81B41A994470F78A10C69DF[18];
if(result8A15D75CE81B41A994470F78A10C69DF.ContainsKey(7))
ISpace["MF_d1_PaymentRemittenceTo"].Value = result8A15D75CE81B41A994470F78A10C69DF[7];
if(result8A15D75CE81B41A994470F78A10C69DF.ContainsKey(20))
ISpace["MF_d1_PITransactionNo"].Value = result8A15D75CE81B41A994470F78A10C69DF[20];
if(result8A15D75CE81B41A994470F78A10C69DF.ContainsKey(2))
ISpace["MF_d1_ReferenceNo"].Value = result8A15D75CE81B41A994470F78A10C69DF[2];
if(result8A15D75CE81B41A994470F78A10C69DF.ContainsKey(5))
ISpace["MF_d1_TravelPlace"].Value = result8A15D75CE81B41A994470F78A10C69DF[5];
if(result8A15D75CE81B41A994470F78A10C69DF.ContainsKey(13))
ISpace["MF_d1_TransactionNo"].Value = result8A15D75CE81B41A994470F78A10C69DF[13];
if(result8A15D75CE81B41A994470F78A10C69DF.ContainsKey(3))
ISpace["MF_d1_JourneyPurpose"].Value = result8A15D75CE81B41A994470F78A10C69DF[3];
if(result8A15D75CE81B41A994470F78A10C69DF.ContainsKey(22))
ISpace["MF_d1_TSTransactionNo"].Value = result8A15D75CE81B41A994470F78A10C69DF[22];
if(result8A15D75CE81B41A994470F78A10C69DF.ContainsKey(19))
ISpace["MF_d1_TSStatus"].Value = result8A15D75CE81B41A994470F78A10C69DF[19];
if(result8A15D75CE81B41A994470F78A10C69DF.ContainsKey(10))
ISpace["MF_d1_BankName"].Value = result8A15D75CE81B41A994470F78A10C69DF[10];
if(result8A15D75CE81B41A994470F78A10C69DF.ContainsKey(9))
ISpace["MF_d1_AccountNo"].Value = result8A15D75CE81B41A994470F78A10C69DF[9];
if(result8A15D75CE81B41A994470F78A10C69DF.ContainsKey(17))
ISpace["MF_d1_TravelStatus"].Value = result8A15D75CE81B41A994470F78A10C69DF[17];
if(result8A15D75CE81B41A994470F78A10C69DF.ContainsKey(1))
ISpace["MF_d1_EmployeeBasicInfoId"].Value = result8A15D75CE81B41A994470F78A10C69DF[1];
if(result8A15D75CE81B41A994470F78A10C69DF.ContainsKey(11))
ISpace["MF_d1_IFSCCode"].Value = result8A15D75CE81B41A994470F78A10C69DF[11];
if(result8A15D75CE81B41A994470F78A10C69DF.ContainsKey(8))
ISpace["MF_d1_BeneficiaryName"].Value = result8A15D75CE81B41A994470F78A10C69DF[8];
if(result8A15D75CE81B41A994470F78A10C69DF.ContainsKey(0))
ISpace["MF_d1_TravelAdvanceID"].Value = result8A15D75CE81B41A994470F78A10C69DF[0];
}
else{
ISpace["MF_d1_TSTransactionDate"].Value = null;ISpace["MF_d1_CreatedOn"].Value = null;ISpace["MF_d1_PITransactionDate"].Value = null;ISpace["MF_d1_TransactionDate"].Value = null;ISpace["MF_d1_TravelType"].Value = null;ISpace["MF_d1_IsAdvanceRequired"].Value = null;ISpace["MF_d1_BankDocument"].Value = null;ISpace["MF_d1_TotalAmount"].Value = null;ISpace["MF_d1_CreatedBy"].Value = null;ISpace["MF_d1_AdvanceAmount"].Value = null;ISpace["MF_d1_TSAmount"].Value = null;ISpace["MF_d1_PaymentRemittenceTo"].Value = null;ISpace["MF_d1_PITransactionNo"].Value = null;ISpace["MF_d1_ReferenceNo"].Value = null;ISpace["MF_d1_TravelPlace"].Value = null;ISpace["MF_d1_TransactionNo"].Value = null;ISpace["MF_d1_JourneyPurpose"].Value = null;ISpace["MF_d1_TSTransactionNo"].Value = null;ISpace["MF_d1_TSStatus"].Value = null;ISpace["MF_d1_BankName"].Value = null;ISpace["MF_d1_AccountNo"].Value = null;ISpace["MF_d1_TravelStatus"].Value = null;ISpace["MF_d1_EmployeeBasicInfoId"].Value = null;ISpace["MF_d1_IFSCCode"].Value = null;ISpace["MF_d1_BeneficiaryName"].Value = null;ISpace["MF_d1_TravelAdvanceID"].Value = null;
}

var querySource0B38C2325A80430BA2372A5E6E1AD125 =GetQueryExpressionDataSource("0B38C232-5A80-430B-A237-2A5E6E1AD125");

DataTable result0B38C2325A80430BA2372A5E6E1AD125=iSpace.SetGridDataSource(querySource0B38C2325A80430BA2372A5E6E1AD125, _objectFactory.GetGridRPP("ExpenseDetails"),@"EXEC InnovaceNoCode..[GridLoadById_63762982-2C07-4E60-8D86-D3A35CA53EDA]  '" + ISpace["MF_d1_TravelAdvanceID"].Value + @"'");

iSpace.InsertGridBindDetails("ExpenseDetails","11",querySource0B38C2325A80430BA2372A5E6E1AD125,"EXEC InnovaceNoCode..[GridLoadById_63762982-2C07-4E60-8D86-D3A35CA53EDA]  '" + ISpace["MF_d1_TravelAdvanceID"].Value + @"'",_objectFactory.GetGridRPP("ExpenseDetails"));

base.WriteDebugInfo(@"var querySource0B38C2325A80430BA2372A5E6E1AD125 =GetQueryExpressionDataSource(""0B38C232-5A80-430B-A237-2A5E6E1AD125"");DataTable result0B38C2325A80430BA2372A5E6E1AD125=iSpace.SetGridDataSource(querySource0B38C2325A80430BA2372A5E6E1AD125, _objectFactory.GetGridRPP(""ExpenseDetails""),@""EXEC InnovaceNoCode..[GridLoadById_63762982-2C07-4E60-8D86-D3A35CA53EDA]  '"" + ISpace[""MF_d1_TravelAdvanceID""].Value + @""'"");iSpace.InsertGridBindDetails(""ExpenseDetails"",""11"",querySource0B38C2325A80430BA2372A5E6E1AD125,""EXEC InnovaceNoCode..[GridLoadById_63762982-2C07-4E60-8D86-D3A35CA53EDA]  '"" + ISpace[""MF_d1_TravelAdvanceID""].Value + @""'"",_objectFactory.GetGridRPP(""ExpenseDetails""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result9E3B6B37E97348C38A158354D2CC4DEF=acdataIspaceF1E219523E9A4F379C422F86E1775788.GetQueryExpressionBindings("9E3B6B37-E973-48C3-8A15-8354D2CC4DEF");
iSpace.SetGridData(result0B38C2325A80430BA2372A5E6E1AD125,result9E3B6B37E97348C38A158354D2CC4DEF,"ExpenseDetails",ref ISpace);
iSpace.UpdateGridBindDetails("ExpenseDetails",result9E3B6B37E97348C38A158354D2CC4DEF);

var querySource22A090AD8607491EAEE23888BF931161 =GetQueryExpressionDataSource("22A090AD-8607-491E-AEE2-3888BF931161");

DataTable result22A090AD8607491EAEE23888BF931161=iSpace.SetGridDataSource(querySource22A090AD8607491EAEE23888BF931161, _objectFactory.GetGridRPP("AdvanceDetails"),@"EXEC InnovaceNoCode..[GridLoadById_93B856A5-0D32-4A27-8B58-5BFE5FF0162C]  '" + ISpace["MF_d1_TravelAdvanceID"].Value + @"'");

iSpace.InsertGridBindDetails("AdvanceDetails","11",querySource22A090AD8607491EAEE23888BF931161,"EXEC InnovaceNoCode..[GridLoadById_93B856A5-0D32-4A27-8B58-5BFE5FF0162C]  '" + ISpace["MF_d1_TravelAdvanceID"].Value + @"'",_objectFactory.GetGridRPP("AdvanceDetails"));

base.WriteDebugInfo(@"var querySource22A090AD8607491EAEE23888BF931161 =GetQueryExpressionDataSource(""22A090AD-8607-491E-AEE2-3888BF931161"");DataTable result22A090AD8607491EAEE23888BF931161=iSpace.SetGridDataSource(querySource22A090AD8607491EAEE23888BF931161, _objectFactory.GetGridRPP(""AdvanceDetails""),@""EXEC InnovaceNoCode..[GridLoadById_93B856A5-0D32-4A27-8B58-5BFE5FF0162C]  '"" + ISpace[""MF_d1_TravelAdvanceID""].Value + @""'"");iSpace.InsertGridBindDetails(""AdvanceDetails"",""11"",querySource22A090AD8607491EAEE23888BF931161,""EXEC InnovaceNoCode..[GridLoadById_93B856A5-0D32-4A27-8B58-5BFE5FF0162C]  '"" + ISpace[""MF_d1_TravelAdvanceID""].Value + @""'"",_objectFactory.GetGridRPP(""AdvanceDetails""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> resultA86C8422ADD944BAB612C8D9EDB841C5=acdataIspaceF1E219523E9A4F379C422F86E1775788.GetQueryExpressionBindings("A86C8422-ADD9-44BA-B612-C8D9EDB841C5");
iSpace.SetGridData(result22A090AD8607491EAEE23888BF931161,resultA86C8422ADD944BAB612C8D9EDB841C5,"AdvanceDetails",ref ISpace);
iSpace.UpdateGridBindDetails("AdvanceDetails",resultA86C8422ADD944BAB612C8D9EDB841C5);
}
base.WriteDebugInfo(@"EXEC [GetEmployeeUserContextDetails] '@@gv_UserId'");

var querySource3c3e1ff76c79c28ed6149890b238c224 =GetQueryExpressionDataSource("3c3e1ff7-6c79-c28e-d614-9890b238c224");
Dictionary<short,object> result3c3e1ff76c79c28ed6149890b238c224=iSpace.ExecuteQuery(querySource3c3e1ff76c79c28ed6149890b238c224,@"EXEC [GetEmployeeUserContextDetails] '" + ISpace["gv_userid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource3c3e1ff76c79c28ed6149890b238c224 =GetQueryExpressionDataSource(""3c3e1ff7-6c79-c28e-d614-9890b238c224"");Dictionary<short,object> result3c3e1ff76c79c28ed6149890b238c224=iSpace.ExecuteQuery(querySource3c3e1ff76c79c28ed6149890b238c224,@""EXEC [GetEmployeeUserContextDetails] '"" + ISpace[""gv_userid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result3c3e1ff76c79c28ed6149890b238c224!=null) && (result3c3e1ff76c79c28ed6149890b238c224.Count!=0))
{
if(result3c3e1ff76c79c28ed6149890b238c224.ContainsKey(0))
ISpace["UC_EmployeeBaicInfoId"].Value = result3c3e1ff76c79c28ed6149890b238c224[0];
if(result3c3e1ff76c79c28ed6149890b238c224.ContainsKey(7))
ISpace["UC_Designation"].Value = result3c3e1ff76c79c28ed6149890b238c224[7];
if(result3c3e1ff76c79c28ed6149890b238c224.ContainsKey(10))
ISpace["UC_DOR"].Value = result3c3e1ff76c79c28ed6149890b238c224[10];
if(result3c3e1ff76c79c28ed6149890b238c224.ContainsKey(15))
ISpace["UC_PhoneNumber"].Value = result3c3e1ff76c79c28ed6149890b238c224[15];
if(result3c3e1ff76c79c28ed6149890b238c224.ContainsKey(6))
ISpace["UC_Department"].Value = result3c3e1ff76c79c28ed6149890b238c224[6];
if(result3c3e1ff76c79c28ed6149890b238c224.ContainsKey(2))
ISpace["UC_Name"].Value = result3c3e1ff76c79c28ed6149890b238c224[2];
if(result3c3e1ff76c79c28ed6149890b238c224.ContainsKey(3))
ISpace["UC_EmailId"].Value = result3c3e1ff76c79c28ed6149890b238c224[3];
if(result3c3e1ff76c79c28ed6149890b238c224.ContainsKey(12))
ISpace["UC_Paylevel"].Value = result3c3e1ff76c79c28ed6149890b238c224[12];
if(result3c3e1ff76c79c28ed6149890b238c224.ContainsKey(11))
ISpace["UC_Grade"].Value = result3c3e1ff76c79c28ed6149890b238c224[11];
if(result3c3e1ff76c79c28ed6149890b238c224.ContainsKey(4))
ISpace["UC_DOJ"].Value = result3c3e1ff76c79c28ed6149890b238c224[4];
if(result3c3e1ff76c79c28ed6149890b238c224.ContainsKey(9))
ISpace["UC_DOB"].Value = result3c3e1ff76c79c28ed6149890b238c224[9];
if(result3c3e1ff76c79c28ed6149890b238c224.ContainsKey(1))
ISpace["UC_EmployeeId"].Value = result3c3e1ff76c79c28ed6149890b238c224[1];
}
else{
ISpace["UC_EmployeeBaicInfoId"].Value = null;ISpace["UC_Designation"].Value = null;ISpace["UC_DOR"].Value = null;ISpace["UC_PhoneNumber"].Value = null;ISpace["UC_Department"].Value = null;ISpace["UC_Name"].Value = null;ISpace["UC_EmailId"].Value = null;ISpace["UC_Paylevel"].Value = null;ISpace["UC_Grade"].Value = null;ISpace["UC_DOJ"].Value = null;ISpace["UC_DOB"].Value = null;ISpace["UC_EmployeeId"].Value = null;
}
ISpace["MF_d1_TravelStatus"].Value="S";
base.WriteDebugInfo(@"ISpace[""MF_d1_TravelStatus""].Value=""S"";");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["FWFM_BudgetHead"].Man=true;ISpace["FWFM_ProjectNo"].Man=true;ISpace["MF_d1_TravelType"].Man=true;ISpace["MFG_d3_FromDate"].Man=true;ISpace["MF_d1_TravelPlace"].Man=true;ISpace["MFG_d2_JourneyClass"].Man=true;ISpace["MFG_d2_Arrival"].Man=true;ISpace["MF_d1_JourneyPurpose"].Man=true;ISpace["MFG_d3_Amount"].Man=true;ISpace["FWFM_Amount"].Man=true;ISpace["MFG_d2_Amount"].Man=true;ISpace["MF_d1_AdvanceAmount"].Man=true;ISpace["MFG_d2_DepartureDate"].Man=true;ISpace["MFG_d3_OtherExpenditureType"].Man=true;ISpace["MFG_d2_ModeofJourney"].Man=true;ISpace["MFG_d2_Departure"].Man=true;ISpace["MF_d1_IsAdvanceRequired"].Man=true;ISpace["MFG_d2_ArrivalDate"].Man=true;ISpace["FWFM_FundType"].Man=true;ISpace["MFG_d3_ExpenditureType"].Man=true;ISpace["MFG_d3_ToDate"].Man=true;
base.WriteDebugInfo(@"ISpace[""FWFM_BudgetHead""].Man=true;ISpace[""FWFM_ProjectNo""].Man=true;ISpace[""MF_d1_TravelType""].Man=true;ISpace[""MFG_d3_FromDate""].Man=true;ISpace[""MF_d1_TravelPlace""].Man=true;ISpace[""MFG_d2_JourneyClass""].Man=true;ISpace[""MFG_d2_Arrival""].Man=true;ISpace[""MF_d1_JourneyPurpose""].Man=true;ISpace[""MFG_d3_Amount""].Man=true;ISpace[""FWFM_Amount""].Man=true;ISpace[""MFG_d2_Amount""].Man=true;ISpace[""MF_d1_AdvanceAmount""].Man=true;ISpace[""MFG_d2_DepartureDate""].Man=true;ISpace[""MFG_d3_OtherExpenditureType""].Man=true;ISpace[""MFG_d2_ModeofJourney""].Man=true;ISpace[""MFG_d2_Departure""].Man=true;ISpace[""MF_d1_IsAdvanceRequired""].Man=true;ISpace[""MFG_d2_ArrivalDate""].Man=true;ISpace[""FWFM_FundType""].Man=true;ISpace[""MFG_d3_ExpenditureType""].Man=true;ISpace[""MFG_d3_ToDate""].Man=true;");
ISpace["MF_EligibleAdavnce"].Value=0;
base.WriteDebugInfo(@"ISpace[""MF_EligibleAdavnce""].Value=0;");
}
ISpace["MF_TotalOtherExpense"].Value=0;
base.WriteDebugInfo(@"ISpace[""MF_TotalOtherExpense""].Value=0;");
ISpace["MF_TotaTravellExpense"].Value=0;
base.WriteDebugInfo(@"ISpace[""MF_TotaTravellExpense""].Value=0;");
ISpace["MF_d1_TotalAmount"].Value=0;
base.WriteDebugInfo(@"ISpace[""MF_d1_TotalAmount""].Value=0;");
base.WriteDebugInfo(@"EXEC [GenerateRef] 3,'@@gv_UserId'");

var querySourcecb7a5d0645d0748ac18fbb48a35f9e4e =GetQueryExpressionDataSource("cb7a5d06-45d0-748a-c18f-bb48a35f9e4e");
Dictionary<short,object> resultcb7a5d0645d0748ac18fbb48a35f9e4e=iSpace.ExecuteQuery(querySourcecb7a5d0645d0748ac18fbb48a35f9e4e,@"EXEC[GenerateRef] 3,'" + ISpace["gv_userid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourcecb7a5d0645d0748ac18fbb48a35f9e4e =GetQueryExpressionDataSource(""cb7a5d06-45d0-748a-c18f-bb48a35f9e4e"");Dictionary<short,object> resultcb7a5d0645d0748ac18fbb48a35f9e4e=iSpace.ExecuteQuery(querySourcecb7a5d0645d0748ac18fbb48a35f9e4e,@""EXEC[GenerateRef] 3,'"" + ISpace[""gv_userid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultcb7a5d0645d0748ac18fbb48a35f9e4e!=null) && (resultcb7a5d0645d0748ac18fbb48a35f9e4e.Count!=0))
{
if(resultcb7a5d0645d0748ac18fbb48a35f9e4e.ContainsKey(0))
ISpace["Subject"].Value = resultcb7a5d0645d0748ac18fbb48a35f9e4e[0];
if(resultcb7a5d0645d0748ac18fbb48a35f9e4e.ContainsKey(0))
ISpace["MF_d1_ReferenceNo"].Value = resultcb7a5d0645d0748ac18fbb48a35f9e4e[0];
}
else{
ISpace["Subject"].Value = null;ISpace["MF_d1_ReferenceNo"].Value = null;
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_fwfm_save (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"FWFM_Save-OnClick");
base.WriteDebugInfo(@"EXEC [Upsert60e821d0-153e-94bb-1fef-2594b78625bd] '@@gv_InstanceId','@@gv_ProcessMapId','#FWFM_FundDetailsId','#FWFM_FundType','#FWFM_ProjectNo','#FWFM_BudgetHead','#FWFM_Amount','#UC_EmployeeBaicInfoId'");

var querySourceB39C99E949594231A55079A7280A86B2 =GetQueryExpressionDataSource("B39C99E9-4959-4231-A550-79A7280A86B2");
Dictionary<short,object> resultB39C99E949594231A55079A7280A86B2=iSpace.ExecuteQuery(querySourceB39C99E949594231A55079A7280A86B2,@"EXEC [Upsert60e821d0-153e-94bb-1fef-2594b78625bd] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','" + ISpace["FWFM_FundDetailsId"].Value + @"','" + ISpace["FWFM_FundType"].Value + @"','" + ISpace["FWFM_ProjectNo"].Value + @"','" + ISpace["FWFM_BudgetHead"].Value + @"','" + ISpace["FWFM_Amount"].Value + @"','" + ISpace["UC_EmployeeBaicInfoId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceB39C99E949594231A55079A7280A86B2 =GetQueryExpressionDataSource(""B39C99E9-4959-4231-A550-79A7280A86B2"");Dictionary<short,object> resultB39C99E949594231A55079A7280A86B2=iSpace.ExecuteQuery(querySourceB39C99E949594231A55079A7280A86B2,@""EXEC [Upsert60e821d0-153e-94bb-1fef-2594b78625bd] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','"" + ISpace[""FWFM_FundDetailsId""].Value + @""','"" + ISpace[""FWFM_FundType""].Value + @""','"" + ISpace[""FWFM_ProjectNo""].Value + @""','"" + ISpace[""FWFM_BudgetHead""].Value + @""','"" + ISpace[""FWFM_Amount""].Value + @""','"" + ISpace[""UC_EmployeeBaicInfoId""].Value + @""'"",false);");

var querySourceB40457367C78448F8AD374D62A738672 =GetQueryExpressionDataSource("B4045736-7C78-448F-8AD3-74D62A738672");

DataTable resultB40457367C78448F8AD374D62A738672=iSpace.SetGridDataSource(querySourceB40457367C78448F8AD374D62A738672, _objectFactory.GetGridRPP("MG_FundAllocation"),@"Exec [Get60e821d0-153e-94bb-1fef-2594b78625bd] '" + ISpace["gv_instanceid"].Value + @"'");

iSpace.InsertGridBindDetails("MG_FundAllocation","11",querySourceB40457367C78448F8AD374D62A738672,"Exec [Get60e821d0-153e-94bb-1fef-2594b78625bd] '" + ISpace["gv_instanceid"].Value + @"'",_objectFactory.GetGridRPP("MG_FundAllocation"));

base.WriteDebugInfo(@"var querySourceB40457367C78448F8AD374D62A738672 =GetQueryExpressionDataSource(""B4045736-7C78-448F-8AD3-74D62A738672"");DataTable resultB40457367C78448F8AD374D62A738672=iSpace.SetGridDataSource(querySourceB40457367C78448F8AD374D62A738672, _objectFactory.GetGridRPP(""MG_FundAllocation""),@""Exec [Get60e821d0-153e-94bb-1fef-2594b78625bd] '"" + ISpace[""gv_instanceid""].Value + @""'"");iSpace.InsertGridBindDetails(""MG_FundAllocation"",""11"",querySourceB40457367C78448F8AD374D62A738672,""Exec [Get60e821d0-153e-94bb-1fef-2594b78625bd] '"" + ISpace[""gv_instanceid""].Value + @""'"",_objectFactory.GetGridRPP(""MG_FundAllocation""));");
base.WriteDebugInfo(@"");

if((resultB39C99E949594231A55079A7280A86B2!=null) && (resultB39C99E949594231A55079A7280A86B2.Count!=0))
{
if(resultB39C99E949594231A55079A7280A86B2.ContainsKey(0))
ISpace["PFM_ErrId"].Value = resultB39C99E949594231A55079A7280A86B2[0];
if(resultB39C99E949594231A55079A7280A86B2.ContainsKey(1))
ISpace["PFM_ErrMsg"].Value = resultB39C99E949594231A55079A7280A86B2[1];
}
else{
ISpace["PFM_ErrId"].Value = null;ISpace["PFM_ErrMsg"].Value = null;
}
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result25891B7408F44F71BE6136CEA4C143EC=acdataIspaceF1E219523E9A4F379C422F86E1775788.GetQueryExpressionBindings("25891B74-08F4-4F71-BE61-36CEA4C143EC");
iSpace.SetGridData(resultB40457367C78448F8AD374D62A738672,result25891B7408F44F71BE6136CEA4C143EC,"MG_FundAllocation",ref ISpace);
iSpace.UpdateGridBindDetails("MG_FundAllocation",result25891B7408F44F71BE6136CEA4C143EC);
ISpace["Message"].Value=String.Format(@"{0}",ISpace["PFM_ErrMsg"].Value);
base.WriteDebugInfo(@"ISpace[""Message""].Value=String.Format(@""{0}"",ISpace[""PFM_ErrMsg""].Value);");
if(ISpace["PFM_ErrId"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""PFM_ErrId""].Value==1)");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["FWFM_FundDetailsId"].Value="";
base.WriteDebugInfo(@"ISpace[""FWFM_FundDetailsId""].Value="""";");
ISpace["FWFM_FundType"].Value="";
base.WriteDebugInfo(@"ISpace[""FWFM_FundType""].Value="""";");
ISpace["FWFM_ProjectNo"].Value="";
base.WriteDebugInfo(@"ISpace[""FWFM_ProjectNo""].Value="""";");
ISpace["FWFM_BudgetHead"].Value="";
base.WriteDebugInfo(@"ISpace[""FWFM_BudgetHead""].Value="""";");
ISpace["FWFM_Amount"].Value=0;
base.WriteDebugInfo(@"ISpace[""FWFM_Amount""].Value=0;");
}
base.WriteDebugInfo(@"EXEC [GetFundSum] '@@gv_InstanceId'");

var querySourcebbe4aa41de2bed94cedd90d80df7192f =GetQueryExpressionDataSource("bbe4aa41-de2b-ed94-cedd-90d80df7192f");
Dictionary<short,object> resultbbe4aa41de2bed94cedd90d80df7192f=iSpace.ExecuteQuery(querySourcebbe4aa41de2bed94cedd90d80df7192f,@"EXEC [GetFundSum] '" + ISpace["gv_instanceid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourcebbe4aa41de2bed94cedd90d80df7192f =GetQueryExpressionDataSource(""bbe4aa41-de2b-ed94-cedd-90d80df7192f"");Dictionary<short,object> resultbbe4aa41de2bed94cedd90d80df7192f=iSpace.ExecuteQuery(querySourcebbe4aa41de2bed94cedd90d80df7192f,@""EXEC [GetFundSum] '"" + ISpace[""gv_instanceid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultbbe4aa41de2bed94cedd90d80df7192f!=null) && (resultbbe4aa41de2bed94cedd90d80df7192f.Count!=0))
{
if(resultbbe4aa41de2bed94cedd90d80df7192f.ContainsKey(0))
ISpace["MF_FundTotal"].Value = resultbbe4aa41de2bed94cedd90d80df7192f[0];
}
else{
ISpace["MF_FundTotal"].Value = null;
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_pfa_widgetsubmit (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"PFA_WidgetSubmit-OnClick");
base.WriteDebugInfo(@"EXEC [UpsertProjectFundAllocation] '@@gv_InstanceId','@@gv_ProcessMapId','@@gv_UserId'");

var querySource94A94EAC199144639AD7CC6F7445F90A =GetQueryExpressionDataSource("94A94EAC-1991-4463-9AD7-CC6F7445F90A");
Dictionary<short,object> result94A94EAC199144639AD7CC6F7445F90A=iSpace.ExecuteQuery(querySource94A94EAC199144639AD7CC6F7445F90A,@"EXEC [UpsertProjectFundAllocation] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','" + ISpace["gv_userid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource94A94EAC199144639AD7CC6F7445F90A =GetQueryExpressionDataSource(""94A94EAC-1991-4463-9AD7-CC6F7445F90A"");Dictionary<short,object> result94A94EAC199144639AD7CC6F7445F90A=iSpace.ExecuteQuery(querySource94A94EAC199144639AD7CC6F7445F90A,@""EXEC [UpsertProjectFundAllocation] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','"" + ISpace[""gv_userid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result94A94EAC199144639AD7CC6F7445F90A!=null) && (result94A94EAC199144639AD7CC6F7445F90A.Count!=0))
{
if(result94A94EAC199144639AD7CC6F7445F90A.ContainsKey(0))
ISpace["PFM_ErrId"].Value = result94A94EAC199144639AD7CC6F7445F90A[0];
}
else{
ISpace["PFM_ErrId"].Value = null;
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_wmf_history (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"WMF_History-OnClick");

var querySource698205C52C1A42F39D81823D3215AB11 =GetQueryExpressionDataSource("698205C5-2C1A-42F3-9D81-823D3215AB11");

DataTable result698205C52C1A42F39D81823D3215AB11=iSpace.SetGridDataSource(querySource698205C52C1A42F39D81823D3215AB11, _objectFactory.GetGridRPP("WMG_CommentsHistory"),@"EXEC [GetInstanceFlowDetais] '" + ISpace["gv_instanceid"].Value + @"'");

iSpace.InsertGridBindDetails("WMG_CommentsHistory","11",querySource698205C52C1A42F39D81823D3215AB11,"EXEC [GetInstanceFlowDetais] '" + ISpace["gv_instanceid"].Value + @"'",_objectFactory.GetGridRPP("WMG_CommentsHistory"));

base.WriteDebugInfo(@"var querySource698205C52C1A42F39D81823D3215AB11 =GetQueryExpressionDataSource(""698205C5-2C1A-42F3-9D81-823D3215AB11"");DataTable result698205C52C1A42F39D81823D3215AB11=iSpace.SetGridDataSource(querySource698205C52C1A42F39D81823D3215AB11, _objectFactory.GetGridRPP(""WMG_CommentsHistory""),@""EXEC [GetInstanceFlowDetais] '"" + ISpace[""gv_instanceid""].Value + @""'"");iSpace.InsertGridBindDetails(""WMG_CommentsHistory"",""11"",querySource698205C52C1A42F39D81823D3215AB11,""EXEC [GetInstanceFlowDetais] '"" + ISpace[""gv_instanceid""].Value + @""'"",_objectFactory.GetGridRPP(""WMG_CommentsHistory""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result794A7328890E42A3B11A5984B2D49196=acdataIspaceF1E219523E9A4F379C422F86E1775788.GetQueryExpressionBindings("794A7328-890E-42A3-B11A-5984B2D49196");
iSpace.SetGridData(result698205C52C1A42F39D81823D3215AB11,result794A7328890E42A3B11A5984B2D49196,"WMG_CommentsHistory",ref ISpace);
iSpace.UpdateGridBindDetails("WMG_CommentsHistory",result794A7328890E42A3B11A5984B2D49196);
ISpace["UI_History"].ShowDialog=true;;
base.WriteDebugInfo(@"ISpace[""UI_History""].ShowDialog=true;;");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_fwfm_projectno (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"FWFM_ProjectNo-OnChange");
ISpace["FWFM_BudgetHead"].rElemData=iSpace.Reload(ISpace["FWFM_BudgetHead"].Value,@"Exec SP_GetDistrubitionDetails 5,'" + ISpace["PFMF_PackageProcessMapId"].Value + @"','" + ISpace["FWFM_FundType"].Value + @"','','','','','" + ISpace["FWFM_ProjectNo"].Value + @"'","9ADED37B-CD11-426B-AF16-DEAC75685EF5");
base.WriteDebugInfo(@"ISpace[""FWFM_BudgetHead""].rElemData=iSpace.Reload(ISpace[""FWFM_BudgetHead""].Value,@""Exec SP_GetDistrubitionDetails 5,'"" + ISpace[""PFMF_PackageProcessMapId""].Value + @""','"" + ISpace[""FWFM_FundType""].Value + @""','','','','','"" + ISpace[""FWFM_ProjectNo""].Value + @""'"",""9ADED37B-CD11-426B-AF16-DEAC75685EF5"");");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_pfm_yes (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"PFM_Yes-OnClick");
base.WriteDebugInfo(@"EXEC [Delete60e821d0-153e_94bb-1fef-2594b78625bd] '@@gv_InstanceId','#PFM_FundDetailsId'");

var querySource4F9BFECD00624E7B883133CCA9BF62FE =GetQueryExpressionDataSource("4F9BFECD-0062-4E7B-8831-33CCA9BF62FE");
Dictionary<short,object> result4F9BFECD00624E7B883133CCA9BF62FE=iSpace.ExecuteQuery(querySource4F9BFECD00624E7B883133CCA9BF62FE,@"EXEC[Delete60e821d0-153e_94bb-1fef-2594b78625bd] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["PFM_FundDetailsId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource4F9BFECD00624E7B883133CCA9BF62FE =GetQueryExpressionDataSource(""4F9BFECD-0062-4E7B-8831-33CCA9BF62FE"");Dictionary<short,object> result4F9BFECD00624E7B883133CCA9BF62FE=iSpace.ExecuteQuery(querySource4F9BFECD00624E7B883133CCA9BF62FE,@""EXEC[Delete60e821d0-153e_94bb-1fef-2594b78625bd] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""PFM_FundDetailsId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result4F9BFECD00624E7B883133CCA9BF62FE!=null) && (result4F9BFECD00624E7B883133CCA9BF62FE.Count!=0))
{
if(result4F9BFECD00624E7B883133CCA9BF62FE.ContainsKey(0))
ISpace["PFM_ErrId"].Value = result4F9BFECD00624E7B883133CCA9BF62FE[0];
if(result4F9BFECD00624E7B883133CCA9BF62FE.ContainsKey(1))
ISpace["PFM_ErrMsg"].Value = result4F9BFECD00624E7B883133CCA9BF62FE[1];
}
else{
ISpace["PFM_ErrId"].Value = null;ISpace["PFM_ErrMsg"].Value = null;
}
ISpace["Message"].Value=String.Format(@"{0}",ISpace["PFM_ErrMsg"].Value);
base.WriteDebugInfo(@"ISpace[""Message""].Value=String.Format(@""{0}"",ISpace[""PFM_ErrMsg""].Value);");

var querySourceB40457367C78448F8AD374D62A738672 =GetQueryExpressionDataSource("B4045736-7C78-448F-8AD3-74D62A738672");

DataTable resultB40457367C78448F8AD374D62A738672=iSpace.SetGridDataSource(querySourceB40457367C78448F8AD374D62A738672, _objectFactory.GetGridRPP("MG_FundAllocation"),@"Exec [Get60e821d0-153e-94bb-1fef-2594b78625bd] '" + ISpace["gv_instanceid"].Value + @"'");

iSpace.InsertGridBindDetails("MG_FundAllocation","11",querySourceB40457367C78448F8AD374D62A738672,"Exec [Get60e821d0-153e-94bb-1fef-2594b78625bd] '" + ISpace["gv_instanceid"].Value + @"'",_objectFactory.GetGridRPP("MG_FundAllocation"));

base.WriteDebugInfo(@"var querySourceB40457367C78448F8AD374D62A738672 =GetQueryExpressionDataSource(""B4045736-7C78-448F-8AD3-74D62A738672"");DataTable resultB40457367C78448F8AD374D62A738672=iSpace.SetGridDataSource(querySourceB40457367C78448F8AD374D62A738672, _objectFactory.GetGridRPP(""MG_FundAllocation""),@""Exec [Get60e821d0-153e-94bb-1fef-2594b78625bd] '"" + ISpace[""gv_instanceid""].Value + @""'"");iSpace.InsertGridBindDetails(""MG_FundAllocation"",""11"",querySourceB40457367C78448F8AD374D62A738672,""Exec [Get60e821d0-153e-94bb-1fef-2594b78625bd] '"" + ISpace[""gv_instanceid""].Value + @""'"",_objectFactory.GetGridRPP(""MG_FundAllocation""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result25891B7408F44F71BE6136CEA4C143EC=acdataIspaceF1E219523E9A4F379C422F86E1775788.GetQueryExpressionBindings("25891B74-08F4-4F71-BE61-36CEA4C143EC");
iSpace.SetGridData(resultB40457367C78448F8AD374D62A738672,result25891B7408F44F71BE6136CEA4C143EC,"MG_FundAllocation",ref ISpace);
iSpace.UpdateGridBindDetails("MG_FundAllocation",result25891B7408F44F71BE6136CEA4C143EC);
ISpace["PFM_FundDetailsId"].Value="";
base.WriteDebugInfo(@"ISpace[""PFM_FundDetailsId""].Value="""";");
ISpace["UI_DeleteDialog"].HideDialog=true;;
base.WriteDebugInfo(@"ISpace[""UI_DeleteDialog""].HideDialog=true;;");
base.WriteDebugInfo(@"EXEC [GetFundSum] '@@gv_InstanceId'");

var querySourcebbe4aa41de2bed94cedd90d80df7192f =GetQueryExpressionDataSource("bbe4aa41-de2b-ed94-cedd-90d80df7192f");
Dictionary<short,object> resultbbe4aa41de2bed94cedd90d80df7192f=iSpace.ExecuteQuery(querySourcebbe4aa41de2bed94cedd90d80df7192f,@"EXEC [GetFundSum] '" + ISpace["gv_instanceid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourcebbe4aa41de2bed94cedd90d80df7192f =GetQueryExpressionDataSource(""bbe4aa41-de2b-ed94-cedd-90d80df7192f"");Dictionary<short,object> resultbbe4aa41de2bed94cedd90d80df7192f=iSpace.ExecuteQuery(querySourcebbe4aa41de2bed94cedd90d80df7192f,@""EXEC [GetFundSum] '"" + ISpace[""gv_instanceid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultbbe4aa41de2bed94cedd90d80df7192f!=null) && (resultbbe4aa41de2bed94cedd90d80df7192f.Count!=0))
{
if(resultbbe4aa41de2bed94cedd90d80df7192f.ContainsKey(0))
ISpace["MF_FundTotal"].Value = resultbbe4aa41de2bed94cedd90d80df7192f[0];
}
else{
ISpace["MF_FundTotal"].Value = null;
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_fwmf_availablebudget (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"FWMF_AvailableBudget-OnClick");
ISpace["FWAB_ProjectNo"].Value="";
base.WriteDebugInfo(@"ISpace[""FWAB_ProjectNo""].Value="""";");
ISpace["UI_WAvailableBudgetDialog"].ShowDialog=true;;
base.WriteDebugInfo(@"ISpace[""UI_WAvailableBudgetDialog""].ShowDialog=true;;");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_save_advancedetails (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Save_AdvanceDetails-OnClick");
if(ISpace["MFG_d2_ModeofJourney"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""MFG_d2_ModeofJourney""].Value=="""")");
ISpace["Message"].Value=@"Error: Please select the Mode of Journey";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Error: Please select the Mode of Journey"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if(ISpace["MFG_d2_Departure"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""MFG_d2_Departure""].Value=="""")");
ISpace["Message"].Value=@"Error: Please Enter the Departure";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Error: Please Enter the Departure"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if((ISpace["MFG_d2_DepartureDate"].Value == null))
{
base.WriteDebugInfo(@"if((ISpace[""MFG_d2_DepartureDate""].Value == null))");
ISpace["Message"].Value=@"Error: Please select the Departure Date";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Error: Please select the Departure Date"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if(ISpace["MFG_d2_Arrival"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""MFG_d2_Arrival""].Value=="""")");
ISpace["Message"].Value=@"Error: Please Enter the Arrival";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Error: Please Enter the Arrival"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if((ISpace["MFG_d2_ArrivalDate"].Value == null))
{
base.WriteDebugInfo(@"if((ISpace[""MFG_d2_ArrivalDate""].Value == null))");
ISpace["Message"].Value=@"Error: Please select the Arrival Date";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Error: Please select the Arrival Date"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if(ISpace["MFG_d2_ArrivalDate"].Value<ISpace["MFG_d2_DepartureDate"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MFG_d2_ArrivalDate""].Value<ISpace[""MFG_d2_DepartureDate""].Value)");
ISpace["Message"].Value=@"Error: Arrival Date Should be greater than Departure Date";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Error: Arrival Date Should be greater than Departure Date"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if(ISpace["MFG_d2_Amount"].Value==0)
{
base.WriteDebugInfo(@"if(ISpace[""MFG_d2_Amount""].Value==0)");
ISpace["Message"].Value=@"Error: Please Enter the Amount";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Error: Please Enter the Amount"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if(ISpace["MFG_d2_Arrival"].Value==ISpace["MFG_d2_Departure"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MFG_d2_Arrival""].Value==ISpace[""MFG_d2_Departure""].Value)");
ISpace["Message"].Value=@"Error: Departure and Arrival Place Must not be same";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Error: Departure and Arrival Place Must not be same"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if(ISpace["growid"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""growid""].Value=="""")");

var querySource5E4DD494A94146D5861A1C2B0B9576C2 =GetQueryExpressionDataSource("5E4DD494-A941-46D5-861A-1C2B0B9576C2");

DataTable result5E4DD494A94146D5861A1C2B0B9576C2=iSpace.SetGridDataSource(querySource5E4DD494A94146D5861A1C2B0B9576C2, _objectFactory.GetGridRPP("AdvanceDetails"),@"EXEC [AddFormGridData93B856A5-0D32-4A27-8B58-5BFE5FF0162C] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','93B856A5-0D32-4A27-8B58-5BFE5FF0162C','" + ISpace["growid"].Value + @"'," + ISpace["AdvanceDetails_Sequence"].Value + @",'" + ISpace["MFG_d2_TADetailsID"].Value + @"','" + ISpace["MFG_d2_TravelAdvanceID"].Value + @"','" + ISpace["MFG_d2_Departure"].Value + @"','" + ISpace["MFG_d2_DepartureDate"].Value + @"','" + ISpace["MFG_d2_DepartureTime"].Value + @"','" + ISpace["MFG_d2_Arrival"].Value + @"','" + ISpace["MFG_d2_ArrivalDate"].Value + @"','" + ISpace["MFG_d2_ArrivalTime"].Value + @"','" + ISpace["MFG_d2_ModeofJourney"].Value + @"','" + ISpace["MFG_d2_JourneyClass"].Value + @"'," + ISpace["MFG_d2_Road"].Value + @",'" + ISpace["MFG_d2_PNRNo"].Value + @"'," + ISpace["MFG_d2_Amount"].Value + @"," + ISpace["MFG_d2_IsTravelRequest"].Value + @"," + ISpace["MFG_d2_UpdatedBy"].Value + @",'" + ISpace["MFG_d2_UpdatedOn"].Value + @"'");

iSpace.InsertGridBindDetails("AdvanceDetails","11",querySource5E4DD494A94146D5861A1C2B0B9576C2,"EXEC [AddFormGridData93B856A5-0D32-4A27-8B58-5BFE5FF0162C] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','93B856A5-0D32-4A27-8B58-5BFE5FF0162C','" + ISpace["growid"].Value + @"'," + ISpace["AdvanceDetails_Sequence"].Value + @",'" + ISpace["MFG_d2_TADetailsID"].Value + @"','" + ISpace["MFG_d2_TravelAdvanceID"].Value + @"','" + ISpace["MFG_d2_Departure"].Value + @"','" + ISpace["MFG_d2_DepartureDate"].Value + @"','" + ISpace["MFG_d2_DepartureTime"].Value + @"','" + ISpace["MFG_d2_Arrival"].Value + @"','" + ISpace["MFG_d2_ArrivalDate"].Value + @"','" + ISpace["MFG_d2_ArrivalTime"].Value + @"','" + ISpace["MFG_d2_ModeofJourney"].Value + @"','" + ISpace["MFG_d2_JourneyClass"].Value + @"'," + ISpace["MFG_d2_Road"].Value + @",'" + ISpace["MFG_d2_PNRNo"].Value + @"'," + ISpace["MFG_d2_Amount"].Value + @"," + ISpace["MFG_d2_IsTravelRequest"].Value + @"," + ISpace["MFG_d2_UpdatedBy"].Value + @",'" + ISpace["MFG_d2_UpdatedOn"].Value + @"'",_objectFactory.GetGridRPP("AdvanceDetails"));

base.WriteDebugInfo(@"var querySource5E4DD494A94146D5861A1C2B0B9576C2 =GetQueryExpressionDataSource(""5E4DD494-A941-46D5-861A-1C2B0B9576C2"");DataTable result5E4DD494A94146D5861A1C2B0B9576C2=iSpace.SetGridDataSource(querySource5E4DD494A94146D5861A1C2B0B9576C2, _objectFactory.GetGridRPP(""AdvanceDetails""),@""EXEC [AddFormGridData93B856A5-0D32-4A27-8B58-5BFE5FF0162C] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','93B856A5-0D32-4A27-8B58-5BFE5FF0162C','"" + ISpace[""growid""].Value + @""',"" + ISpace[""AdvanceDetails_Sequence""].Value + @"",'"" + ISpace[""MFG_d2_TADetailsID""].Value + @""','"" + ISpace[""MFG_d2_TravelAdvanceID""].Value + @""','"" + ISpace[""MFG_d2_Departure""].Value + @""','"" + ISpace[""MFG_d2_DepartureDate""].Value + @""','"" + ISpace[""MFG_d2_DepartureTime""].Value + @""','"" + ISpace[""MFG_d2_Arrival""].Value + @""','"" + ISpace[""MFG_d2_ArrivalDate""].Value + @""','"" + ISpace[""MFG_d2_ArrivalTime""].Value + @""','"" + ISpace[""MFG_d2_ModeofJourney""].Value + @""','"" + ISpace[""MFG_d2_JourneyClass""].Value + @""',"" + ISpace[""MFG_d2_Road""].Value + @"",'"" + ISpace[""MFG_d2_PNRNo""].Value + @""',"" + ISpace[""MFG_d2_Amount""].Value + @"","" + ISpace[""MFG_d2_IsTravelRequest""].Value + @"","" + ISpace[""MFG_d2_UpdatedBy""].Value + @"",'"" + ISpace[""MFG_d2_UpdatedOn""].Value + @""'"");iSpace.InsertGridBindDetails(""AdvanceDetails"",""11"",querySource5E4DD494A94146D5861A1C2B0B9576C2,""EXEC [AddFormGridData93B856A5-0D32-4A27-8B58-5BFE5FF0162C] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','93B856A5-0D32-4A27-8B58-5BFE5FF0162C','"" + ISpace[""growid""].Value + @""',"" + ISpace[""AdvanceDetails_Sequence""].Value + @"",'"" + ISpace[""MFG_d2_TADetailsID""].Value + @""','"" + ISpace[""MFG_d2_TravelAdvanceID""].Value + @""','"" + ISpace[""MFG_d2_Departure""].Value + @""','"" + ISpace[""MFG_d2_DepartureDate""].Value + @""','"" + ISpace[""MFG_d2_DepartureTime""].Value + @""','"" + ISpace[""MFG_d2_Arrival""].Value + @""','"" + ISpace[""MFG_d2_ArrivalDate""].Value + @""','"" + ISpace[""MFG_d2_ArrivalTime""].Value + @""','"" + ISpace[""MFG_d2_ModeofJourney""].Value + @""','"" + ISpace[""MFG_d2_JourneyClass""].Value + @""',"" + ISpace[""MFG_d2_Road""].Value + @"",'"" + ISpace[""MFG_d2_PNRNo""].Value + @""',"" + ISpace[""MFG_d2_Amount""].Value + @"","" + ISpace[""MFG_d2_IsTravelRequest""].Value + @"","" + ISpace[""MFG_d2_UpdatedBy""].Value + @"",'"" + ISpace[""MFG_d2_UpdatedOn""].Value + @""'"",_objectFactory.GetGridRPP(""AdvanceDetails""));");
base.WriteDebugInfo(@"EXEC [AddFormGridData93B856A5-0D32-4A27-8B58-5BFE5FF0162C] '@@gv_InstanceId','@@gv_ActivityMapId','93B856A5-0D32-4A27-8B58-5BFE5FF0162C','#growid',#AdvanceDetails_Sequence,'#MFG_d2_TADetailsID','#MFG_d2_TravelAdvanceID','#MFG_d2_Departure','#MFG_d2_DepartureDate','#MFG_d2_DepartureTime','#MFG_d2_Arrival','#MFG_d2_ArrivalDate','#MFG_d2_ArrivalTime','#MFG_d2_ModeofJourney','#MFG_d2_JourneyClass',#MFG_d2_Road,'#MFG_d2_PNRNo',#MFG_d2_Amount,#MFG_d2_IsTravelRequest,#MFG_d2_UpdatedBy,'#MFG_d2_UpdatedO");


List<Triplet<string, short, short?>> resultD3F136535A714FF787CF7CCF34A9151A=acdataIspaceF1E219523E9A4F379C422F86E1775788.GetQueryExpressionBindings("D3F13653-5A71-4FF7-87CF-7CCF34A9151A");
iSpace.SetGridData(result5E4DD494A94146D5861A1C2B0B9576C2,resultD3F136535A714FF787CF7CCF34A9151A,"AdvanceDetails",ref ISpace);
iSpace.UpdateGridBindDetails("AdvanceDetails",resultD3F136535A714FF787CF7CCF34A9151A);
}
else
{
base.WriteDebugInfo(@"else");

var querySource7444A31301164D01ADC7D4FB2D3A166B =GetQueryExpressionDataSource("7444A313-0116-4D01-ADC7-D4FB2D3A166B");

DataTable result7444A31301164D01ADC7D4FB2D3A166B=iSpace.SetGridDataSource(querySource7444A31301164D01ADC7D4FB2D3A166B, _objectFactory.GetGridRPP("AdvanceDetails"),@"EXEC [UpdateFormGridData93B856A5-0D32-4A27-8B58-5BFE5FF0162C] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','93B856A5-0D32-4A27-8B58-5BFE5FF0162C','" + ISpace["growid"].Value + @"'," + ISpace["AdvanceDetails_Sequence"].Value + @",'" + ISpace["MFG_d2_TADetailsID"].Value + @"','" + ISpace["MFG_d2_TravelAdvanceID"].Value + @"','" + ISpace["MFG_d2_Departure"].Value + @"','" + ISpace["MFG_d2_DepartureDate"].Value + @"','" + ISpace["MFG_d2_DepartureTime"].Value + @"','" + ISpace["MFG_d2_Arrival"].Value + @"','" + ISpace["MFG_d2_ArrivalDate"].Value + @"','" + ISpace["MFG_d2_ArrivalTime"].Value + @"','" + ISpace["MFG_d2_ModeofJourney"].Value + @"','" + ISpace["MFG_d2_JourneyClass"].Value + @"'," + ISpace["MFG_d2_Road"].Value + @",'" + ISpace["MFG_d2_PNRNo"].Value + @"'," + ISpace["MFG_d2_Amount"].Value + @"," + ISpace["MFG_d2_IsTravelRequest"].Value + @"," + ISpace["MFG_d2_UpdatedBy"].Value + @",'" + ISpace["MFG_d2_Updatedon"].Value + @"'");

iSpace.InsertGridBindDetails("AdvanceDetails","11",querySource7444A31301164D01ADC7D4FB2D3A166B,"EXEC [UpdateFormGridData93B856A5-0D32-4A27-8B58-5BFE5FF0162C] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','93B856A5-0D32-4A27-8B58-5BFE5FF0162C','" + ISpace["growid"].Value + @"'," + ISpace["AdvanceDetails_Sequence"].Value + @",'" + ISpace["MFG_d2_TADetailsID"].Value + @"','" + ISpace["MFG_d2_TravelAdvanceID"].Value + @"','" + ISpace["MFG_d2_Departure"].Value + @"','" + ISpace["MFG_d2_DepartureDate"].Value + @"','" + ISpace["MFG_d2_DepartureTime"].Value + @"','" + ISpace["MFG_d2_Arrival"].Value + @"','" + ISpace["MFG_d2_ArrivalDate"].Value + @"','" + ISpace["MFG_d2_ArrivalTime"].Value + @"','" + ISpace["MFG_d2_ModeofJourney"].Value + @"','" + ISpace["MFG_d2_JourneyClass"].Value + @"'," + ISpace["MFG_d2_Road"].Value + @",'" + ISpace["MFG_d2_PNRNo"].Value + @"'," + ISpace["MFG_d2_Amount"].Value + @"," + ISpace["MFG_d2_IsTravelRequest"].Value + @"," + ISpace["MFG_d2_UpdatedBy"].Value + @",'" + ISpace["MFG_d2_Updatedon"].Value + @"'",_objectFactory.GetGridRPP("AdvanceDetails"));

base.WriteDebugInfo(@"var querySource7444A31301164D01ADC7D4FB2D3A166B =GetQueryExpressionDataSource(""7444A313-0116-4D01-ADC7-D4FB2D3A166B"");DataTable result7444A31301164D01ADC7D4FB2D3A166B=iSpace.SetGridDataSource(querySource7444A31301164D01ADC7D4FB2D3A166B, _objectFactory.GetGridRPP(""AdvanceDetails""),@""EXEC [UpdateFormGridData93B856A5-0D32-4A27-8B58-5BFE5FF0162C] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','93B856A5-0D32-4A27-8B58-5BFE5FF0162C','"" + ISpace[""growid""].Value + @""',"" + ISpace[""AdvanceDetails_Sequence""].Value + @"",'"" + ISpace[""MFG_d2_TADetailsID""].Value + @""','"" + ISpace[""MFG_d2_TravelAdvanceID""].Value + @""','"" + ISpace[""MFG_d2_Departure""].Value + @""','"" + ISpace[""MFG_d2_DepartureDate""].Value + @""','"" + ISpace[""MFG_d2_DepartureTime""].Value + @""','"" + ISpace[""MFG_d2_Arrival""].Value + @""','"" + ISpace[""MFG_d2_ArrivalDate""].Value + @""','"" + ISpace[""MFG_d2_ArrivalTime""].Value + @""','"" + ISpace[""MFG_d2_ModeofJourney""].Value + @""','"" + ISpace[""MFG_d2_JourneyClass""].Value + @""',"" + ISpace[""MFG_d2_Road""].Value + @"",'"" + ISpace[""MFG_d2_PNRNo""].Value + @""',"" + ISpace[""MFG_d2_Amount""].Value + @"","" + ISpace[""MFG_d2_IsTravelRequest""].Value + @"","" + ISpace[""MFG_d2_UpdatedBy""].Value + @"",'"" + ISpace[""MFG_d2_Updatedon""].Value + @""'"");iSpace.InsertGridBindDetails(""AdvanceDetails"",""11"",querySource7444A31301164D01ADC7D4FB2D3A166B,""EXEC [UpdateFormGridData93B856A5-0D32-4A27-8B58-5BFE5FF0162C] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','93B856A5-0D32-4A27-8B58-5BFE5FF0162C','"" + ISpace[""growid""].Value + @""',"" + ISpace[""AdvanceDetails_Sequence""].Value + @"",'"" + ISpace[""MFG_d2_TADetailsID""].Value + @""','"" + ISpace[""MFG_d2_TravelAdvanceID""].Value + @""','"" + ISpace[""MFG_d2_Departure""].Value + @""','"" + ISpace[""MFG_d2_DepartureDate""].Value + @""','"" + ISpace[""MFG_d2_DepartureTime""].Value + @""','"" + ISpace[""MFG_d2_Arrival""].Value + @""','"" + ISpace[""MFG_d2_ArrivalDate""].Value + @""','"" + ISpace[""MFG_d2_ArrivalTime""].Value + @""','"" + ISpace[""MFG_d2_ModeofJourney""].Value + @""','"" + ISpace[""MFG_d2_JourneyClass""].Value + @""',"" + ISpace[""MFG_d2_Road""].Value + @"",'"" + ISpace[""MFG_d2_PNRNo""].Value + @""',"" + ISpace[""MFG_d2_Amount""].Value + @"","" + ISpace[""MFG_d2_IsTravelRequest""].Value + @"","" + ISpace[""MFG_d2_UpdatedBy""].Value + @"",'"" + ISpace[""MFG_d2_Updatedon""].Value + @""'"",_objectFactory.GetGridRPP(""AdvanceDetails""));");
base.WriteDebugInfo(@"EXEC [UpdateFormGridData93B856A5-0D32-4A27-8B58-5BFE5FF0162C] '@@gv_InstanceId','@@gv_ActivityMapId','93B856A5-0D32-4A27-8B58-5BFE5FF0162C','#growid',#AdvanceDetails_Sequence,'#MFG_d2_TADetailsID','#MFG_d2_TravelAdvanceID','#MFG_d2_Departure','#MFG_d2_DepartureDate','#MFG_d2_DepartureTime','#MFG_d2_Arrival','#MFG_d2_ArrivalDate','#MFG_d2_ArrivalTime','#MFG_d2_ModeofJourney','#MFG_d2_JourneyClass',#MFG_d2_Road,'#MFG_d2_PNRNo',#MFG_d2_Amount,#MFG_d2_IsTravelRequest,#MFG_d2_UpdatedBy,'#MFG_d2_Updat");


List<Triplet<string, short, short?>> resultFAA6C5FB3ED241778B276EA6EA73C8C5=acdataIspaceF1E219523E9A4F379C422F86E1775788.GetQueryExpressionBindings("FAA6C5FB-3ED2-4177-8B27-6EA6EA73C8C5");
iSpace.SetGridData(result7444A31301164D01ADC7D4FB2D3A166B,resultFAA6C5FB3ED241778B276EA6EA73C8C5,"AdvanceDetails",ref ISpace);
iSpace.UpdateGridBindDetails("AdvanceDetails",resultFAA6C5FB3ED241778B276EA6EA73C8C5);
}
ISpace["growid"].Value="";
base.WriteDebugInfo(@"ISpace[""growid""].Value="""";");
ISpace["MFG_d2_TADetailsID"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d2_TADetailsID""].Value="""";");
ISpace["MFG_d2_TravelAdvanceID"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d2_TravelAdvanceID""].Value="""";");
ISpace["MFG_d2_Departure"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d2_Departure""].Value="""";");
ISpace["MFG_d2_DepartureDate"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d2_DepartureDate""].Value="""";");
ISpace["MFG_d2_DepartureTime"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d2_DepartureTime""].Value="""";");
ISpace["MFG_d2_Arrival"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d2_Arrival""].Value="""";");
ISpace["MFG_d2_ArrivalDate"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d2_ArrivalDate""].Value="""";");
ISpace["MFG_d2_ArrivalTime"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d2_ArrivalTime""].Value="""";");
ISpace["MFG_d2_ModeofJourney"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d2_ModeofJourney""].Value="""";");
ISpace["MFG_d2_JourneyClass"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d2_JourneyClass""].Value="""";");
ISpace["MFG_d2_Road"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d2_Road""].Value="""";");
ISpace["MFG_d2_PNRNo"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d2_PNRNo""].Value="""";");
ISpace["MFG_d2_Amount"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d2_Amount""].Value="""";");
ISpace["MFG_d2_IsTravelRequest"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d2_IsTravelRequest""].Value="""";");
ISpace["MFG_d2_UpdatedBy"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d2_UpdatedBy""].Value="""";");
ISpace["MFG_d2_UpdatedOn"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d2_UpdatedOn""].Value="""";");
object MG_d2_Amount=iSpace.Sum("[93B856A5-0D32-4A27-8B58-5BFE5FF0162C]","MG_d2_Amount","",ISpace["gv_instanceid"].Value);
ISpace["MF_TotaTravellExpense"].Value=Convert.ChangeType(MG_d2_Amount, MG_d2_Amount.GetType());;
base.WriteDebugInfo(@"object MG_d2_Amount=iSpace.Sum(""[93B856A5-0D32-4A27-8B58-5BFE5FF0162C]"",""MG_d2_Amount"","""",ISpace[""gv_instanceid""].Value);
ISpace[""MF_TotaTravellExpense""].Value=Convert.ChangeType(MG_d2_Amount, MG_d2_Amount.GetType());;");
object MG_d3_Amount=iSpace.Sum("[63762982-2C07-4E60-8D86-D3A35CA53EDA]","MG_d3_Amount","",ISpace["gv_instanceid"].Value);
ISpace["MF_TotalOtherExpense"].Value=Convert.ChangeType(MG_d3_Amount, MG_d3_Amount.GetType());;
base.WriteDebugInfo(@"object MG_d3_Amount=iSpace.Sum(""[63762982-2C07-4E60-8D86-D3A35CA53EDA]"",""MG_d3_Amount"","""",ISpace[""gv_instanceid""].Value);
ISpace[""MF_TotalOtherExpense""].Value=Convert.ChangeType(MG_d3_Amount, MG_d3_Amount.GetType());;");
ISpace["MF_d1_TotalAmount"].Value=ISpace["MF_TotaTravellExpense"].Value+ISpace["MF_TotalOtherExpense"].Value;
base.WriteDebugInfo(@"ISpace[""MF_d1_TotalAmount""].Value=ISpace[""MF_TotaTravellExpense""].Value+ISpace[""MF_TotalOtherExpense""].Value;");
ISpace["MF_EligibleAdavnce"].Value=ISpace["MF_d1_TotalAmount"].Value*90;
base.WriteDebugInfo(@"ISpace[""MF_EligibleAdavnce""].Value=ISpace[""MF_d1_TotalAmount""].Value*90;");
ISpace["MF_EligibleAdavnce"].Value=ISpace["MF_EligibleAdavnce"].Value/100;
base.WriteDebugInfo(@"ISpace[""MF_EligibleAdavnce""].Value=ISpace[""MF_EligibleAdavnce""].Value/100;");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_edit_advancedetails (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Edit_AdvanceDetails-OnClick");
ISpace["growid"].Value=ISpace["AdvanceDetails_RowId"].Value;
base.WriteDebugInfo(@"ISpace[""growid""].Value=ISpace[""AdvanceDetails_RowId""].Value;");
base.WriteDebugInfo(@"EXEC [LoadFormGridData93B856A5-0D32-4A27-8B58-5BFE5FF0162C] '@@gv_InstanceId','@@gv_ActivityMapId','93B856A5-0D32-4A27-8B58-5BFE5FF0162C','#growid',#AdvanceDetails_Sequence");

var querySource6A3DD0196ADB41F4A45177D3CE6705D7 =GetQueryExpressionDataSource("6A3DD019-6ADB-41F4-A451-77D3CE6705D7");
Dictionary<short,object> result6A3DD0196ADB41F4A45177D3CE6705D7=iSpace.ExecuteQuery(querySource6A3DD0196ADB41F4A45177D3CE6705D7,@"EXEC [LoadFormGridData93B856A5-0D32-4A27-8B58-5BFE5FF0162C] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','93B856A5-0D32-4A27-8B58-5BFE5FF0162C','" + ISpace["growid"].Value + @"'," + ISpace["AdvanceDetails_Sequence"].Value + @"",false);

base.WriteDebugInfo(@"var querySource6A3DD0196ADB41F4A45177D3CE6705D7 =GetQueryExpressionDataSource(""6A3DD019-6ADB-41F4-A451-77D3CE6705D7"");Dictionary<short,object> result6A3DD0196ADB41F4A45177D3CE6705D7=iSpace.ExecuteQuery(querySource6A3DD0196ADB41F4A45177D3CE6705D7,@""EXEC [LoadFormGridData93B856A5-0D32-4A27-8B58-5BFE5FF0162C] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','93B856A5-0D32-4A27-8B58-5BFE5FF0162C','"" + ISpace[""growid""].Value + @""',"" + ISpace[""AdvanceDetails_Sequence""].Value + @"""",false);");
base.WriteDebugInfo(@"EXEC [LoadFormGridData93B856A5-0D32-4A27-8B58-5BFE5FF0162C] '@@gv_InstanceId','@@gv_ActivityMapId','93B856A5-0D32-4A27-8B58-5BFE5FF0162C','#growid',#AdvanceDetails_Sequence");

if((result6A3DD0196ADB41F4A45177D3CE6705D7!=null) && (result6A3DD0196ADB41F4A45177D3CE6705D7.Count!=0))
{
if(result6A3DD0196ADB41F4A45177D3CE6705D7.ContainsKey(3))
ISpace["MFG_d2_DepartureDate"].Value = result6A3DD0196ADB41F4A45177D3CE6705D7[3];
if(result6A3DD0196ADB41F4A45177D3CE6705D7.ContainsKey(15))
ISpace["MFG_d2_UpdatedOn"].Value = result6A3DD0196ADB41F4A45177D3CE6705D7[15];
if(result6A3DD0196ADB41F4A45177D3CE6705D7.ContainsKey(6))
ISpace["MFG_d2_ArrivalDate"].Value = result6A3DD0196ADB41F4A45177D3CE6705D7[6];
if(result6A3DD0196ADB41F4A45177D3CE6705D7.ContainsKey(8))
ISpace["MFG_d2_ModeofJourney"].Value = result6A3DD0196ADB41F4A45177D3CE6705D7[8];
if(result6A3DD0196ADB41F4A45177D3CE6705D7.ContainsKey(9))
ISpace["MFG_d2_JourneyClass"].Value = result6A3DD0196ADB41F4A45177D3CE6705D7[9];
if(result6A3DD0196ADB41F4A45177D3CE6705D7.ContainsKey(13))
ISpace["MFG_d2_IsTravelRequest"].Value = result6A3DD0196ADB41F4A45177D3CE6705D7[13];
if(result6A3DD0196ADB41F4A45177D3CE6705D7.ContainsKey(14))
ISpace["MFG_d2_UpdatedBy"].Value = result6A3DD0196ADB41F4A45177D3CE6705D7[14];
if(result6A3DD0196ADB41F4A45177D3CE6705D7.ContainsKey(12))
ISpace["MFG_d2_Amount"].Value = result6A3DD0196ADB41F4A45177D3CE6705D7[12];
if(result6A3DD0196ADB41F4A45177D3CE6705D7.ContainsKey(10))
ISpace["MFG_d2_Road"].Value = result6A3DD0196ADB41F4A45177D3CE6705D7[10];
if(result6A3DD0196ADB41F4A45177D3CE6705D7.ContainsKey(0))
ISpace["MFG_d2_TADetailsID"].Value = result6A3DD0196ADB41F4A45177D3CE6705D7[0];
if(result6A3DD0196ADB41F4A45177D3CE6705D7.ContainsKey(11))
ISpace["MFG_d2_PNRNo"].Value = result6A3DD0196ADB41F4A45177D3CE6705D7[11];
if(result6A3DD0196ADB41F4A45177D3CE6705D7.ContainsKey(5))
ISpace["MFG_d2_Arrival"].Value = result6A3DD0196ADB41F4A45177D3CE6705D7[5];
if(result6A3DD0196ADB41F4A45177D3CE6705D7.ContainsKey(7))
ISpace["MFG_d2_ArrivalTime"].Value = result6A3DD0196ADB41F4A45177D3CE6705D7[7];
if(result6A3DD0196ADB41F4A45177D3CE6705D7.ContainsKey(2))
ISpace["MFG_d2_Departure"].Value = result6A3DD0196ADB41F4A45177D3CE6705D7[2];
if(result6A3DD0196ADB41F4A45177D3CE6705D7.ContainsKey(1))
ISpace["MFG_d2_TravelAdvanceID"].Value = result6A3DD0196ADB41F4A45177D3CE6705D7[1];
if(result6A3DD0196ADB41F4A45177D3CE6705D7.ContainsKey(4))
ISpace["MFG_d2_DepartureTime"].Value = result6A3DD0196ADB41F4A45177D3CE6705D7[4];
}
else{
ISpace["MFG_d2_DepartureDate"].Value = null;ISpace["MFG_d2_UpdatedOn"].Value = null;ISpace["MFG_d2_ArrivalDate"].Value = null;ISpace["MFG_d2_ModeofJourney"].Value = null;ISpace["MFG_d2_JourneyClass"].Value = null;ISpace["MFG_d2_IsTravelRequest"].Value = null;ISpace["MFG_d2_UpdatedBy"].Value = null;ISpace["MFG_d2_Amount"].Value = null;ISpace["MFG_d2_Road"].Value = null;ISpace["MFG_d2_TADetailsID"].Value = null;ISpace["MFG_d2_PNRNo"].Value = null;ISpace["MFG_d2_Arrival"].Value = null;ISpace["MFG_d2_ArrivalTime"].Value = null;ISpace["MFG_d2_Departure"].Value = null;ISpace["MFG_d2_TravelAdvanceID"].Value = null;ISpace["MFG_d2_DepartureTime"].Value = null;
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_pfm_no (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"PFM_No-OnClick");
ISpace["PFM_FundDetailsId"].Value="";
base.WriteDebugInfo(@"ISpace[""PFM_FundDetailsId""].Value="""";");
ISpace["UI_DeleteDialog"].HideDialog=true;;
base.WriteDebugInfo(@"ISpace[""UI_DeleteDialog""].HideDialog=true;;");
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
if(ISpace["MF_d1_TravelType"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""MF_d1_TravelType""].Value=="""")");
ISpace["Message"].Value=@"Error: Please select Travel Type";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Error: Please select Travel Type"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if(ISpace["MF_d1_TravelPlace"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""MF_d1_TravelPlace""].Value=="""")");
ISpace["Message"].Value=@"Error: Please enter the Travel Place";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Error: Please enter the Travel Place"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if(ISpace["MF_d1_JourneyPurpose"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""MF_d1_JourneyPurpose""].Value=="""")");
ISpace["Message"].Value=@"Error: Please Enter the Purpose of Journey";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Error: Please Enter the Purpose of Journey"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if(ISpace["MF_d1_IsAdvanceRequired"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""MF_d1_IsAdvanceRequired""].Value=="""")");
ISpace["Message"].Value=@"Error: Please Select Is Advance Required";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Error: Please Select Is Advance Required"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if(ISpace["MF_d1_IsAdvanceRequired"].Value=="Yes")
{
base.WriteDebugInfo(@"if(ISpace[""MF_d1_IsAdvanceRequired""].Value==""Yes"")");
if(ISpace["MF_d1_AdvanceAmount"].Value==0)
{
base.WriteDebugInfo(@"if(ISpace[""MF_d1_AdvanceAmount""].Value==0)");
ISpace["Message"].Value=@"Please Enter the Advance Amount";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please Enter the Advance Amount"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
}
if(ISpace["MF_FundTotal"].Value!=ISpace["MF_d1_TotalAmount"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_FundTotal""].Value!=ISpace[""MF_d1_TotalAmount""].Value)");
ISpace["Message"].Value=@"Error: Total Fund Amount and Total Amount must be Equal";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Error: Total Fund Amount and Total Amount must be Equal"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if(ISpace["WF_FlowType"].Value=="APPROVE")
{
base.WriteDebugInfo(@"if(ISpace[""WF_FlowType""].Value==""APPROVE"")");
if(ISpace["WMF_MoveTo"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""WMF_MoveTo""].Value=="""")");
ISpace["Message"].Value=@"Error:Please Select Next Action";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Error:Please Select Next Action"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
}
if(ISpace["WF_FlowType"].Value=="RETURN" || ISpace["WF_FlowType"].Value=="REJECT")
{
base.WriteDebugInfo(@"if(ISpace[""WF_FlowType""].Value==""RETURN"" || ISpace[""WF_FlowType""].Value==""REJECT"")");
if(ISpace["WMF_MoveTo"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""WMF_MoveTo""].Value=="""")");
ISpace["Message"].Value=@"Error:Please Select Next Action";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Error:Please Select Next Action"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if(ISpace["Comments"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""Comments""].Value=="""")");
ISpace["Message"].Value=@"Error: Please Enter Comments";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Error: Please Enter Comments"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
}
base.WriteDebugInfo(@"EXEC InnovaceNoCode..[FormSave_5D394C98-9AAB-4228-B011-FC8008C3247C] '@@gv_InstanceId','@@gv_ActivityMapId','bfcdccb2-7467-4308-a53d-7cab7b883529','@@gv_InstanceId','#UC_EmployeeBaicInfoId','#MF_d1_ReferenceNo','#MF_d1_JourneyPurpose','#MF_d1_TravelType','#MF_d1_TravelPlace','#MF_d1_IsAdvanceRequired','#MF_d1_PaymentRemittenceTo','#MF_d1_BeneficiaryName','#MF_d1_AccountNo','#MF_d1_BankName','#MF_d1_IFSCCode','#MF_d1_BankDocument','#MF_d1_TransactionNo','#MF_d1_TransactionDate','#MF_d1_TotalAmount','#MF_d1_AdvanceAmount','#MF_d1_TravelStatus','#MF_d1_TSAmount','#MF_d1_TSStatus','#MF_d1_PITransactionNo','#MF_d1_PITransactionDate','#MF_d1_TSTransactionNo','#MF_d1_TSTransactionDate','@@gv_UserId','#MF_d1_CreatedOn'");

var querySourceE182AF12DAED4644A9FC9AA3381897FF =GetQueryExpressionDataSource("E182AF12-DAED-4644-A9FC-9AA3381897FF");
Dictionary<short,object> resultE182AF12DAED4644A9FC9AA3381897FF=iSpace.ExecuteQuery(querySourceE182AF12DAED4644A9FC9AA3381897FF,@"EXEC InnovaceNoCode..[FormSave_5D394C98-9AAB-4228-B011-FC8008C3247C] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','bfcdccb2-7467-4308-a53d-7cab7b883529','" + ISpace["gv_instanceid"].Value + @"','" + ISpace["UC_EmployeeBaicInfoId"].Value + @"','" + ISpace["MF_d1_ReferenceNo"].Value + @"','" + ISpace["MF_d1_JourneyPurpose"].Value + @"','" + ISpace["MF_d1_TravelType"].Value + @"','" + ISpace["MF_d1_TravelPlace"].Value + @"','" + ISpace["MF_d1_IsAdvanceRequired"].Value + @"','" + ISpace["MF_d1_PaymentRemittenceTo"].Value + @"','" + ISpace["MF_d1_BeneficiaryName"].Value + @"','" + ISpace["MF_d1_AccountNo"].Value + @"','" + ISpace["MF_d1_BankName"].Value + @"','" + ISpace["MF_d1_IFSCCode"].Value + @"','" + ISpace["MF_d1_BankDocument"].Value + @"','" + ISpace["MF_d1_TransactionNo"].Value + @"','" + ISpace["MF_d1_TransactionDate"].Value + @"','" + ISpace["MF_d1_TotalAmount"].Value + @"','" + ISpace["MF_d1_AdvanceAmount"].Value + @"','" + ISpace["MF_d1_TravelStatus"].Value + @"','" + ISpace["MF_d1_TSAmount"].Value + @"','" + ISpace["MF_d1_TSStatus"].Value + @"','" + ISpace["MF_d1_PITransactionNo"].Value + @"','" + ISpace["MF_d1_PITransactionDate"].Value + @"','" + ISpace["MF_d1_TSTransactionNo"].Value + @"','" + ISpace["MF_d1_TSTransactionDate"].Value + @"','" + ISpace["gv_userid"].Value + @"','" + ISpace["MF_d1_CreatedOn"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceE182AF12DAED4644A9FC9AA3381897FF =GetQueryExpressionDataSource(""E182AF12-DAED-4644-A9FC-9AA3381897FF"");Dictionary<short,object> resultE182AF12DAED4644A9FC9AA3381897FF=iSpace.ExecuteQuery(querySourceE182AF12DAED4644A9FC9AA3381897FF,@""EXEC InnovaceNoCode..[FormSave_5D394C98-9AAB-4228-B011-FC8008C3247C] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','bfcdccb2-7467-4308-a53d-7cab7b883529','"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""UC_EmployeeBaicInfoId""].Value + @""','"" + ISpace[""MF_d1_ReferenceNo""].Value + @""','"" + ISpace[""MF_d1_JourneyPurpose""].Value + @""','"" + ISpace[""MF_d1_TravelType""].Value + @""','"" + ISpace[""MF_d1_TravelPlace""].Value + @""','"" + ISpace[""MF_d1_IsAdvanceRequired""].Value + @""','"" + ISpace[""MF_d1_PaymentRemittenceTo""].Value + @""','"" + ISpace[""MF_d1_BeneficiaryName""].Value + @""','"" + ISpace[""MF_d1_AccountNo""].Value + @""','"" + ISpace[""MF_d1_BankName""].Value + @""','"" + ISpace[""MF_d1_IFSCCode""].Value + @""','"" + ISpace[""MF_d1_BankDocument""].Value + @""','"" + ISpace[""MF_d1_TransactionNo""].Value + @""','"" + ISpace[""MF_d1_TransactionDate""].Value + @""','"" + ISpace[""MF_d1_TotalAmount""].Value + @""','"" + ISpace[""MF_d1_AdvanceAmount""].Value + @""','"" + ISpace[""MF_d1_TravelStatus""].Value + @""','"" + ISpace[""MF_d1_TSAmount""].Value + @""','"" + ISpace[""MF_d1_TSStatus""].Value + @""','"" + ISpace[""MF_d1_PITransactionNo""].Value + @""','"" + ISpace[""MF_d1_PITransactionDate""].Value + @""','"" + ISpace[""MF_d1_TSTransactionNo""].Value + @""','"" + ISpace[""MF_d1_TSTransactionDate""].Value + @""','"" + ISpace[""gv_userid""].Value + @""','"" + ISpace[""MF_d1_CreatedOn""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultE182AF12DAED4644A9FC9AA3381897FF!=null) && (resultE182AF12DAED4644A9FC9AA3381897FF.Count!=0))
{
if(resultE182AF12DAED4644A9FC9AA3381897FF.ContainsKey(0))
ISpace["ExecutionMessage"].Value = resultE182AF12DAED4644A9FC9AA3381897FF[0];
}
else{
ISpace["ExecutionMessage"].Value = null;
}
base.WriteDebugInfo(@"EXEC InnovaceNoCode..[GridSave_63762982-2C07-4E60-8D86-D3A35CA53EDA]   '@@gv_InstanceId','@@gv_ActivityMapId','63762982-2C07-4E60-8D86-D3A35CA53EDA'");

var querySource5D2551CDFD03487A81061EBC8385C05B =GetQueryExpressionDataSource("5D2551CD-FD03-487A-8106-1EBC8385C05B");
Dictionary<short,object> result5D2551CDFD03487A81061EBC8385C05B=iSpace.ExecuteQuery(querySource5D2551CDFD03487A81061EBC8385C05B,@"EXEC InnovaceNoCode..[GridSave_63762982-2C07-4E60-8D86-D3A35CA53EDA]   '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','63762982-2C07-4E60-8D86-D3A35CA53EDA'",false);

base.WriteDebugInfo(@"var querySource5D2551CDFD03487A81061EBC8385C05B =GetQueryExpressionDataSource(""5D2551CD-FD03-487A-8106-1EBC8385C05B"");Dictionary<short,object> result5D2551CDFD03487A81061EBC8385C05B=iSpace.ExecuteQuery(querySource5D2551CDFD03487A81061EBC8385C05B,@""EXEC InnovaceNoCode..[GridSave_63762982-2C07-4E60-8D86-D3A35CA53EDA]   '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','63762982-2C07-4E60-8D86-D3A35CA53EDA'"",false);");
base.WriteDebugInfo(@"");

if((result5D2551CDFD03487A81061EBC8385C05B!=null) && (result5D2551CDFD03487A81061EBC8385C05B.Count!=0))
{
if(result5D2551CDFD03487A81061EBC8385C05B.ContainsKey(0))
ISpace["MF_ErrId"].Value = result5D2551CDFD03487A81061EBC8385C05B[0];
if(result5D2551CDFD03487A81061EBC8385C05B.ContainsKey(1))
ISpace["MF_ErrMsg"].Value = result5D2551CDFD03487A81061EBC8385C05B[1];
if(result5D2551CDFD03487A81061EBC8385C05B.ContainsKey(0))
ISpace["ExecutionMessage"].Value = result5D2551CDFD03487A81061EBC8385C05B[0];
}
else{
ISpace["MF_ErrId"].Value = null;ISpace["MF_ErrMsg"].Value = null;ISpace["ExecutionMessage"].Value = null;
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_ErrId"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ErrId""].Value==1)");
ISpace["Message"].Value=String.Format(@"{0}",ISpace["MF_ErrMsg"].Value);
base.WriteDebugInfo(@"ISpace[""Message""].Value=String.Format(@""{0}"",ISpace[""MF_ErrMsg""].Value);");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
}
base.WriteDebugInfo(@"EXEC InnovaceNoCode..[GridSave_93B856A5-0D32-4A27-8B58-5BFE5FF0162C]   '@@gv_InstanceId','@@gv_ActivityMapId','93B856A5-0D32-4A27-8B58-5BFE5FF0162C'");

var querySourceB926676F6B9A4DFE933F733A15635C3F =GetQueryExpressionDataSource("B926676F-6B9A-4DFE-933F-733A15635C3F");
Dictionary<short,object> resultB926676F6B9A4DFE933F733A15635C3F=iSpace.ExecuteQuery(querySourceB926676F6B9A4DFE933F733A15635C3F,@"EXEC InnovaceNoCode..[GridSave_93B856A5-0D32-4A27-8B58-5BFE5FF0162C]   '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','93B856A5-0D32-4A27-8B58-5BFE5FF0162C'",false);

base.WriteDebugInfo(@"var querySourceB926676F6B9A4DFE933F733A15635C3F =GetQueryExpressionDataSource(""B926676F-6B9A-4DFE-933F-733A15635C3F"");Dictionary<short,object> resultB926676F6B9A4DFE933F733A15635C3F=iSpace.ExecuteQuery(querySourceB926676F6B9A4DFE933F733A15635C3F,@""EXEC InnovaceNoCode..[GridSave_93B856A5-0D32-4A27-8B58-5BFE5FF0162C]   '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','93B856A5-0D32-4A27-8B58-5BFE5FF0162C'"",false);");
base.WriteDebugInfo(@"");

if((resultB926676F6B9A4DFE933F733A15635C3F!=null) && (resultB926676F6B9A4DFE933F733A15635C3F.Count!=0))
{
if(resultB926676F6B9A4DFE933F733A15635C3F.ContainsKey(0))
ISpace["MF_ErrId"].Value = resultB926676F6B9A4DFE933F733A15635C3F[0];
if(resultB926676F6B9A4DFE933F733A15635C3F.ContainsKey(1))
ISpace["MF_ErrMsg"].Value = resultB926676F6B9A4DFE933F733A15635C3F[1];
if(resultB926676F6B9A4DFE933F733A15635C3F.ContainsKey(0))
ISpace["ExecutionMessage"].Value = resultB926676F6B9A4DFE933F733A15635C3F[0];
}
else{
ISpace["MF_ErrId"].Value = null;ISpace["MF_ErrMsg"].Value = null;ISpace["ExecutionMessage"].Value = null;
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_ErrId"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ErrId""].Value==1)");
ISpace["Message"].Value=String.Format(@"{0}",ISpace["MF_ErrMsg"].Value);
base.WriteDebugInfo(@"ISpace[""Message""].Value=String.Format(@""{0}"",ISpace[""MF_ErrMsg""].Value);");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
}
base.WriteDebugInfo(@"Exec [SaveTravelRequestDocuments] '@@gv_InstanceId','@@gv_ProcessMapId','@@gv_UserId'");

var querySource0e8ceab69d8fffd68fe03de1048b96a0 =GetQueryExpressionDataSource("0e8ceab6-9d8f-ffd6-8fe0-3de1048b96a0");
Dictionary<short,object> result0e8ceab69d8fffd68fe03de1048b96a0=iSpace.ExecuteQuery(querySource0e8ceab69d8fffd68fe03de1048b96a0,@"Exec [SaveTravelRequestDocuments] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','" + ISpace["gv_userid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource0e8ceab69d8fffd68fe03de1048b96a0 =GetQueryExpressionDataSource(""0e8ceab6-9d8f-ffd6-8fe0-3de1048b96a0"");Dictionary<short,object> result0e8ceab69d8fffd68fe03de1048b96a0=iSpace.ExecuteQuery(querySource0e8ceab69d8fffd68fe03de1048b96a0,@""Exec [SaveTravelRequestDocuments] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','"" + ISpace[""gv_userid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result0e8ceab69d8fffd68fe03de1048b96a0!=null) && (result0e8ceab69d8fffd68fe03de1048b96a0.Count!=0))
{
if(result0e8ceab69d8fffd68fe03de1048b96a0.ContainsKey(0))
ISpace["MF_ErrId"].Value = result0e8ceab69d8fffd68fe03de1048b96a0[0];
if(result0e8ceab69d8fffd68fe03de1048b96a0.ContainsKey(1))
ISpace["MF_ErrMsg"].Value = result0e8ceab69d8fffd68fe03de1048b96a0[1];
}
else{
ISpace["MF_ErrId"].Value = null;ISpace["MF_ErrMsg"].Value = null;
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_ErrId"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ErrId""].Value==1)");
ISpace["Message"].Value=String.Format(@"{0}",ISpace["MF_ErrMsg"].Value);
base.WriteDebugInfo(@"ISpace[""Message""].Value=String.Format(@""{0}"",ISpace[""MF_ErrMsg""].Value);");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
}
base.WriteDebugInfo(@"EXEC [UpsertProjectFundAllocation] '@@gv_InstanceId','@@gv_ProcessMapId','@@gv_UserId'");

var querySource94A94EAC199144639AD7CC6F7445F90A =GetQueryExpressionDataSource("94A94EAC-1991-4463-9AD7-CC6F7445F90A");
Dictionary<short,object> result94A94EAC199144639AD7CC6F7445F90A=iSpace.ExecuteQuery(querySource94A94EAC199144639AD7CC6F7445F90A,@"EXEC [UpsertProjectFundAllocation] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','" + ISpace["gv_userid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource94A94EAC199144639AD7CC6F7445F90A =GetQueryExpressionDataSource(""94A94EAC-1991-4463-9AD7-CC6F7445F90A"");Dictionary<short,object> result94A94EAC199144639AD7CC6F7445F90A=iSpace.ExecuteQuery(querySource94A94EAC199144639AD7CC6F7445F90A,@""EXEC [UpsertProjectFundAllocation] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','"" + ISpace[""gv_userid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result94A94EAC199144639AD7CC6F7445F90A!=null) && (result94A94EAC199144639AD7CC6F7445F90A.Count!=0))
{
if(result94A94EAC199144639AD7CC6F7445F90A.ContainsKey(0))
ISpace["PFM_ErrId"].Value = result94A94EAC199144639AD7CC6F7445F90A[0];
}
else{
ISpace["PFM_ErrId"].Value = null;
}
if(ISpace["WF_FlowType"].Value!="REJECT")
{
base.WriteDebugInfo(@"if(ISpace[""WF_FlowType""].Value!=""REJECT"")");
base.WriteDebugInfo(@"EXEC [UpdateCommitmentSpent] '@@gv_InstanceId'");

var querySource588a57f1a42385cbc854b18aee523e01 =GetQueryExpressionDataSource("588a57f1-a423-85cb-c854-b18aee523e01");
Dictionary<short,object> result588a57f1a42385cbc854b18aee523e01=iSpace.ExecuteQuery(querySource588a57f1a42385cbc854b18aee523e01,@"EXEC [UpdateCommitmentSpent] '" + ISpace["gv_instanceid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource588a57f1a42385cbc854b18aee523e01 =GetQueryExpressionDataSource(""588a57f1-a423-85cb-c854-b18aee523e01"");Dictionary<short,object> result588a57f1a42385cbc854b18aee523e01=iSpace.ExecuteQuery(querySource588a57f1a42385cbc854b18aee523e01,@""EXEC [UpdateCommitmentSpent] '"" + ISpace[""gv_instanceid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result588a57f1a42385cbc854b18aee523e01!=null) && (result588a57f1a42385cbc854b18aee523e01.Count!=0))
{
}
else{

}
}
ISpace["Message"].Value=@"Success: Submitted Successfully";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Success: Submitted Successfully"";");

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
private void SubscribeElementEvents_fwab_projectno (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"FWAB_ProjectNo-OnChange");

var querySource15B473E55CD0469AB3B0C69EFCAF1CEB =GetQueryExpressionDataSource("15B473E5-5CD0-469A-B3B0-C69EFCAF1CEB");

DataTable result15B473E55CD0469AB3B0C69EFCAF1CEB=iSpace.SetGridDataSource(querySource15B473E55CD0469AB3B0C69EFCAF1CEB, _objectFactory.GetGridRPP("MG_AvailableBudget"),@"EXEC [GetProjectBudgetInformation] '" + ISpace["FWAB_ProjectNo"].Value + @"'");

iSpace.InsertGridBindDetails("MG_AvailableBudget","11",querySource15B473E55CD0469AB3B0C69EFCAF1CEB,"EXEC [GetProjectBudgetInformation] '" + ISpace["FWAB_ProjectNo"].Value + @"'",_objectFactory.GetGridRPP("MG_AvailableBudget"));

base.WriteDebugInfo(@"var querySource15B473E55CD0469AB3B0C69EFCAF1CEB =GetQueryExpressionDataSource(""15B473E5-5CD0-469A-B3B0-C69EFCAF1CEB"");DataTable result15B473E55CD0469AB3B0C69EFCAF1CEB=iSpace.SetGridDataSource(querySource15B473E55CD0469AB3B0C69EFCAF1CEB, _objectFactory.GetGridRPP(""MG_AvailableBudget""),@""EXEC [GetProjectBudgetInformation] '"" + ISpace[""FWAB_ProjectNo""].Value + @""'"");iSpace.InsertGridBindDetails(""MG_AvailableBudget"",""11"",querySource15B473E55CD0469AB3B0C69EFCAF1CEB,""EXEC [GetProjectBudgetInformation] '"" + ISpace[""FWAB_ProjectNo""].Value + @""'"",_objectFactory.GetGridRPP(""MG_AvailableBudget""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> resultFCFC08538E66474BA676F339F45380EF=acdataIspaceF1E219523E9A4F379C422F86E1775788.GetQueryExpressionBindings("FCFC0853-8E66-474B-A676-F339F45380EF");
iSpace.SetGridData(result15B473E55CD0469AB3B0C69EFCAF1CEB,resultFCFC08538E66474BA676F339F45380EF,"MG_AvailableBudget",ref ISpace);
iSpace.UpdateGridBindDetails("MG_AvailableBudget",resultFCFC08538E66474BA676F339F45380EF);
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mfg_d2_modeofjourney (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MFG_d2_ModeofJourney-OnChange");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["MFG_d2_JourneyClass"].rElemData=iSpace.Reload(ISpace["MFG_d2_JourneyClass"].Value,@"EXEC TravelClassCombo '" + ISpace["MFG_d2_ModeofJourney"].Value + @"'","3A103712-5244-4427-B2B6-1C4E046FD337");
base.WriteDebugInfo(@"ISpace[""MFG_d2_JourneyClass""].rElemData=iSpace.Reload(ISpace[""MFG_d2_JourneyClass""].Value,@""EXEC TravelClassCombo '"" + ISpace[""MFG_d2_ModeofJourney""].Value + @""'"",""3A103712-5244-4427-B2B6-1C4E046FD337"");");
}
if(ISpace["MFG_d2_ModeofJourney"].Value!="477")
{
base.WriteDebugInfo(@"if(ISpace[""MFG_d2_ModeofJourney""].Value!=""477"")");
ISpace["MFG_d2_Road"].Visible="false";
base.WriteDebugInfo(@"ISpace[""MFG_d2_Road""].Visible=""false"";");
ISpace["MFG_d2_Road"].Value=0;
base.WriteDebugInfo(@"ISpace[""MFG_d2_Road""].Value=0;");
}
if(ISpace["MFG_d2_ModeofJourney"].Value=="477")
{
base.WriteDebugInfo(@"if(ISpace[""MFG_d2_ModeofJourney""].Value==""477"")");
ISpace["MFG_d2_Road"].Visible="true";
base.WriteDebugInfo(@"ISpace[""MFG_d2_Road""].Visible=""true"";");
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_save_expensedetails (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Save_ExpenseDetails-OnClick");
if(ISpace["MFG_d3_ExpenditureType"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""MFG_d3_ExpenditureType""].Value=="""")");
ISpace["Message"].Value=@"Error: Please select the Expenditure Type";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Error: Please select the Expenditure Type"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if((ISpace["MFG_d3_FromDate"].Value == null))
{
base.WriteDebugInfo(@"if((ISpace[""MFG_d3_FromDate""].Value == null))");
ISpace["Message"].Value=@"Error: Please select the From Date";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Error: Please select the From Date"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if((ISpace["MFG_d3_ToDate"].Value == null))
{
base.WriteDebugInfo(@"if((ISpace[""MFG_d3_ToDate""].Value == null))");
ISpace["Message"].Value=@"Error: Please select the To Date";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Error: Please select the To Date"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if(ISpace["MFG_d3_Amount"].Value==0)
{
base.WriteDebugInfo(@"if(ISpace[""MFG_d3_Amount""].Value==0)");
ISpace["Message"].Value=@"Error: Please Enter the Amount";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Error: Please Enter the Amount"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if(ISpace["growid"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""growid""].Value=="""")");

var querySourceD7D51D5871D4428EA54AD52FA8744223 =GetQueryExpressionDataSource("D7D51D58-71D4-428E-A54A-D52FA8744223");

DataTable resultD7D51D5871D4428EA54AD52FA8744223=iSpace.SetGridDataSource(querySourceD7D51D5871D4428EA54AD52FA8744223, _objectFactory.GetGridRPP("ExpenseDetails"),@"EXEC [AddFormGridData63762982-2C07-4E60-8D86-D3A35CA53EDA] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','63762982-2C07-4E60-8D86-D3A35CA53EDA','" + ISpace["growid"].Value + @"'," + ISpace["ExpenseDetails_Sequence"].Value + @",'" + ISpace["MFG_d3_ExpenditureTypeID"].Value + @"','" + ISpace["MFG_d3_TravelAdvanceID"].Value + @"','" + ISpace["MFG_d3_FromDate"].Value + @"','" + ISpace["MFG_d3_ToDate"].Value + @"'," + ISpace["MFG_d3_Amount"].Value + @"," + ISpace["MFG_d3_UpdatedBy"].Value + @",'" + ISpace["MFG_d3_UpdatedOn"].Value + @"'," + ISpace["MFG_d3_ExpenditureType"].Value + @",'" + ISpace["MFG_d3_OtherExpenditureType"].Value + @"'," + ISpace["MFG_d3_IsTravelRequest"].Value + @"");

iSpace.InsertGridBindDetails("ExpenseDetails","11",querySourceD7D51D5871D4428EA54AD52FA8744223,"EXEC [AddFormGridData63762982-2C07-4E60-8D86-D3A35CA53EDA] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','63762982-2C07-4E60-8D86-D3A35CA53EDA','" + ISpace["growid"].Value + @"'," + ISpace["ExpenseDetails_Sequence"].Value + @",'" + ISpace["MFG_d3_ExpenditureTypeID"].Value + @"','" + ISpace["MFG_d3_TravelAdvanceID"].Value + @"','" + ISpace["MFG_d3_FromDate"].Value + @"','" + ISpace["MFG_d3_ToDate"].Value + @"'," + ISpace["MFG_d3_Amount"].Value + @"," + ISpace["MFG_d3_UpdatedBy"].Value + @",'" + ISpace["MFG_d3_UpdatedOn"].Value + @"'," + ISpace["MFG_d3_ExpenditureType"].Value + @",'" + ISpace["MFG_d3_OtherExpenditureType"].Value + @"'," + ISpace["MFG_d3_IsTravelRequest"].Value + @"",_objectFactory.GetGridRPP("ExpenseDetails"));

base.WriteDebugInfo(@"var querySourceD7D51D5871D4428EA54AD52FA8744223 =GetQueryExpressionDataSource(""D7D51D58-71D4-428E-A54A-D52FA8744223"");DataTable resultD7D51D5871D4428EA54AD52FA8744223=iSpace.SetGridDataSource(querySourceD7D51D5871D4428EA54AD52FA8744223, _objectFactory.GetGridRPP(""ExpenseDetails""),@""EXEC [AddFormGridData63762982-2C07-4E60-8D86-D3A35CA53EDA] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','63762982-2C07-4E60-8D86-D3A35CA53EDA','"" + ISpace[""growid""].Value + @""',"" + ISpace[""ExpenseDetails_Sequence""].Value + @"",'"" + ISpace[""MFG_d3_ExpenditureTypeID""].Value + @""','"" + ISpace[""MFG_d3_TravelAdvanceID""].Value + @""','"" + ISpace[""MFG_d3_FromDate""].Value + @""','"" + ISpace[""MFG_d3_ToDate""].Value + @""',"" + ISpace[""MFG_d3_Amount""].Value + @"","" + ISpace[""MFG_d3_UpdatedBy""].Value + @"",'"" + ISpace[""MFG_d3_UpdatedOn""].Value + @""',"" + ISpace[""MFG_d3_ExpenditureType""].Value + @"",'"" + ISpace[""MFG_d3_OtherExpenditureType""].Value + @""',"" + ISpace[""MFG_d3_IsTravelRequest""].Value + @"""");iSpace.InsertGridBindDetails(""ExpenseDetails"",""11"",querySourceD7D51D5871D4428EA54AD52FA8744223,""EXEC [AddFormGridData63762982-2C07-4E60-8D86-D3A35CA53EDA] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','63762982-2C07-4E60-8D86-D3A35CA53EDA','"" + ISpace[""growid""].Value + @""',"" + ISpace[""ExpenseDetails_Sequence""].Value + @"",'"" + ISpace[""MFG_d3_ExpenditureTypeID""].Value + @""','"" + ISpace[""MFG_d3_TravelAdvanceID""].Value + @""','"" + ISpace[""MFG_d3_FromDate""].Value + @""','"" + ISpace[""MFG_d3_ToDate""].Value + @""',"" + ISpace[""MFG_d3_Amount""].Value + @"","" + ISpace[""MFG_d3_UpdatedBy""].Value + @"",'"" + ISpace[""MFG_d3_UpdatedOn""].Value + @""',"" + ISpace[""MFG_d3_ExpenditureType""].Value + @"",'"" + ISpace[""MFG_d3_OtherExpenditureType""].Value + @""',"" + ISpace[""MFG_d3_IsTravelRequest""].Value + @"""",_objectFactory.GetGridRPP(""ExpenseDetails""));");
base.WriteDebugInfo(@"EXEC [AddFormGridData63762982-2C07-4E60-8D86-D3A35CA53EDA] '@@gv_InstanceId','@@gv_ActivityMapId','63762982-2C07-4E60-8D86-D3A35CA53EDA','#growid',#ExpenseDetails_Sequence,'#MFG_d3_ExpenditureTypeID','#MFG_d3_TravelAdvanceID','#MFG_d3_FromDate','#MFG_d3_ToDate',#MFG_d3_Amount,#MFG_d3_UpdatedBy,'#MFG_d3_UpdatedOn',#MFG_d3_ExpenditureType,'#MFG_d3_OtherExpenditureType',#MFG_d3_IsTravelRequest");


List<Triplet<string, short, short?>> result79298EDC73804DCABEFA54D2D36D148A=acdataIspaceF1E219523E9A4F379C422F86E1775788.GetQueryExpressionBindings("79298EDC-7380-4DCA-BEFA-54D2D36D148A");
iSpace.SetGridData(resultD7D51D5871D4428EA54AD52FA8744223,result79298EDC73804DCABEFA54D2D36D148A,"ExpenseDetails",ref ISpace);
iSpace.UpdateGridBindDetails("ExpenseDetails",result79298EDC73804DCABEFA54D2D36D148A);
}
else
{
base.WriteDebugInfo(@"else");

var querySourceDDAF997F6BE4424691A6BF443D4771D5 =GetQueryExpressionDataSource("DDAF997F-6BE4-4246-91A6-BF443D4771D5");

DataTable resultDDAF997F6BE4424691A6BF443D4771D5=iSpace.SetGridDataSource(querySourceDDAF997F6BE4424691A6BF443D4771D5, _objectFactory.GetGridRPP("ExpenseDetails"),@"EXEC [UpdateFormGridData63762982-2C07-4E60-8D86-D3A35CA53EDA] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','63762982-2C07-4E60-8D86-D3A35CA53EDA','" + ISpace["growid"].Value + @"'," + ISpace["ExpenseDetails_Sequence"].Value + @",'" + ISpace["MFG_d3_ExpenditureTypeID"].Value + @"','" + ISpace["MFG_d3_TravelAdvanceID"].Value + @"','" + ISpace["MFG_d3_FromDate"].Value + @"','" + ISpace["MFG_d3_ToDate"].Value + @"'," + ISpace["MFG_d3_Amount"].Value + @"," + ISpace["MFG_d3_UpdatedBy"].Value + @",'" + ISpace["MFG_d3_UpdatedOn"].Value + @"'," + ISpace["MFG_d3_ExpenditureType"].Value + @",'" + ISpace["MFG_d3_OtherExpenditureType"].Value + @"'," + ISpace["MFG_d3_IsTravelRequest"].Value + @"");

iSpace.InsertGridBindDetails("ExpenseDetails","11",querySourceDDAF997F6BE4424691A6BF443D4771D5,"EXEC [UpdateFormGridData63762982-2C07-4E60-8D86-D3A35CA53EDA] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','63762982-2C07-4E60-8D86-D3A35CA53EDA','" + ISpace["growid"].Value + @"'," + ISpace["ExpenseDetails_Sequence"].Value + @",'" + ISpace["MFG_d3_ExpenditureTypeID"].Value + @"','" + ISpace["MFG_d3_TravelAdvanceID"].Value + @"','" + ISpace["MFG_d3_FromDate"].Value + @"','" + ISpace["MFG_d3_ToDate"].Value + @"'," + ISpace["MFG_d3_Amount"].Value + @"," + ISpace["MFG_d3_UpdatedBy"].Value + @",'" + ISpace["MFG_d3_UpdatedOn"].Value + @"'," + ISpace["MFG_d3_ExpenditureType"].Value + @",'" + ISpace["MFG_d3_OtherExpenditureType"].Value + @"'," + ISpace["MFG_d3_IsTravelRequest"].Value + @"",_objectFactory.GetGridRPP("ExpenseDetails"));

base.WriteDebugInfo(@"var querySourceDDAF997F6BE4424691A6BF443D4771D5 =GetQueryExpressionDataSource(""DDAF997F-6BE4-4246-91A6-BF443D4771D5"");DataTable resultDDAF997F6BE4424691A6BF443D4771D5=iSpace.SetGridDataSource(querySourceDDAF997F6BE4424691A6BF443D4771D5, _objectFactory.GetGridRPP(""ExpenseDetails""),@""EXEC [UpdateFormGridData63762982-2C07-4E60-8D86-D3A35CA53EDA] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','63762982-2C07-4E60-8D86-D3A35CA53EDA','"" + ISpace[""growid""].Value + @""',"" + ISpace[""ExpenseDetails_Sequence""].Value + @"",'"" + ISpace[""MFG_d3_ExpenditureTypeID""].Value + @""','"" + ISpace[""MFG_d3_TravelAdvanceID""].Value + @""','"" + ISpace[""MFG_d3_FromDate""].Value + @""','"" + ISpace[""MFG_d3_ToDate""].Value + @""',"" + ISpace[""MFG_d3_Amount""].Value + @"","" + ISpace[""MFG_d3_UpdatedBy""].Value + @"",'"" + ISpace[""MFG_d3_UpdatedOn""].Value + @""',"" + ISpace[""MFG_d3_ExpenditureType""].Value + @"",'"" + ISpace[""MFG_d3_OtherExpenditureType""].Value + @""',"" + ISpace[""MFG_d3_IsTravelRequest""].Value + @"""");iSpace.InsertGridBindDetails(""ExpenseDetails"",""11"",querySourceDDAF997F6BE4424691A6BF443D4771D5,""EXEC [UpdateFormGridData63762982-2C07-4E60-8D86-D3A35CA53EDA] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','63762982-2C07-4E60-8D86-D3A35CA53EDA','"" + ISpace[""growid""].Value + @""',"" + ISpace[""ExpenseDetails_Sequence""].Value + @"",'"" + ISpace[""MFG_d3_ExpenditureTypeID""].Value + @""','"" + ISpace[""MFG_d3_TravelAdvanceID""].Value + @""','"" + ISpace[""MFG_d3_FromDate""].Value + @""','"" + ISpace[""MFG_d3_ToDate""].Value + @""',"" + ISpace[""MFG_d3_Amount""].Value + @"","" + ISpace[""MFG_d3_UpdatedBy""].Value + @"",'"" + ISpace[""MFG_d3_UpdatedOn""].Value + @""',"" + ISpace[""MFG_d3_ExpenditureType""].Value + @"",'"" + ISpace[""MFG_d3_OtherExpenditureType""].Value + @""',"" + ISpace[""MFG_d3_IsTravelRequest""].Value + @"""",_objectFactory.GetGridRPP(""ExpenseDetails""));");
base.WriteDebugInfo(@"EXEC [UpdateFormGridData63762982-2C07-4E60-8D86-D3A35CA53EDA] '@@gv_InstanceId','@@gv_ActivityMapId','63762982-2C07-4E60-8D86-D3A35CA53EDA','#growid',#ExpenseDetails_Sequence,'#MFG_d3_ExpenditureTypeID','#MFG_d3_TravelAdvanceID','#MFG_d3_FromDate','#MFG_d3_ToDate',#MFG_d3_Amount,#MFG_d3_UpdatedBy,'#MFG_d3_UpdatedOn',#MFG_d3_ExpenditureType,'#MFG_d3_OtherExpenditureType',#MFG_d3_IsTravelRequest");


List<Triplet<string, short, short?>> resultC21973820B3942FF967D813A615854D1=acdataIspaceF1E219523E9A4F379C422F86E1775788.GetQueryExpressionBindings("C2197382-0B39-42FF-967D-813A615854D1");
iSpace.SetGridData(resultDDAF997F6BE4424691A6BF443D4771D5,resultC21973820B3942FF967D813A615854D1,"ExpenseDetails",ref ISpace);
iSpace.UpdateGridBindDetails("ExpenseDetails",resultC21973820B3942FF967D813A615854D1);
}
ISpace["growid"].Value="";
base.WriteDebugInfo(@"ISpace[""growid""].Value="""";");
ISpace["MFG_d3_ExpenditureTypeID"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d3_ExpenditureTypeID""].Value="""";");
ISpace["MFG_d3_TravelAdvanceID"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d3_TravelAdvanceID""].Value="""";");
ISpace["MFG_d3_FromDate"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d3_FromDate""].Value="""";");
ISpace["MFG_d3_ToDate"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d3_ToDate""].Value="""";");
ISpace["MFG_d3_Amount"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d3_Amount""].Value="""";");
ISpace["MFG_d3_UpdatedBy"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d3_UpdatedBy""].Value="""";");
ISpace["MFG_d3_UpdatedOn"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d3_UpdatedOn""].Value="""";");
ISpace["MFG_d3_ExpenditureType"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d3_ExpenditureType""].Value="""";");
ISpace["MFG_d3_OtherExpenditureType"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d3_OtherExpenditureType""].Value="""";");
ISpace["MFG_d3_IsTravelRequest"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d3_IsTravelRequest""].Value="""";");
object MG_d2_Amount=iSpace.Sum("[93B856A5-0D32-4A27-8B58-5BFE5FF0162C]","MG_d2_Amount","",ISpace["gv_instanceid"].Value);
ISpace["MF_TotaTravellExpense"].Value=Convert.ChangeType(MG_d2_Amount, MG_d2_Amount.GetType());;
base.WriteDebugInfo(@"object MG_d2_Amount=iSpace.Sum(""[93B856A5-0D32-4A27-8B58-5BFE5FF0162C]"",""MG_d2_Amount"","""",ISpace[""gv_instanceid""].Value);
ISpace[""MF_TotaTravellExpense""].Value=Convert.ChangeType(MG_d2_Amount, MG_d2_Amount.GetType());;");
object MG_d3_Amount=iSpace.Sum("[63762982-2C07-4E60-8D86-D3A35CA53EDA]","MG_d3_Amount","",ISpace["gv_instanceid"].Value);
ISpace["MF_TotalOtherExpense"].Value=Convert.ChangeType(MG_d3_Amount, MG_d3_Amount.GetType());;
base.WriteDebugInfo(@"object MG_d3_Amount=iSpace.Sum(""[63762982-2C07-4E60-8D86-D3A35CA53EDA]"",""MG_d3_Amount"","""",ISpace[""gv_instanceid""].Value);
ISpace[""MF_TotalOtherExpense""].Value=Convert.ChangeType(MG_d3_Amount, MG_d3_Amount.GetType());;");
ISpace["MF_d1_TotalAmount"].Value=ISpace["MF_TotaTravellExpense"].Value+ISpace["MF_TotalOtherExpense"].Value;
base.WriteDebugInfo(@"ISpace[""MF_d1_TotalAmount""].Value=ISpace[""MF_TotaTravellExpense""].Value+ISpace[""MF_TotalOtherExpense""].Value;");
ISpace["MF_EligibleAdavnce"].Value=ISpace["MF_d1_TotalAmount"].Value*90;
base.WriteDebugInfo(@"ISpace[""MF_EligibleAdavnce""].Value=ISpace[""MF_d1_TotalAmount""].Value*90;");
ISpace["MF_EligibleAdavnce"].Value=ISpace["MF_EligibleAdavnce"].Value/100;
base.WriteDebugInfo(@"ISpace[""MF_EligibleAdavnce""].Value=ISpace[""MF_EligibleAdavnce""].Value/100;");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mf_d1_isadvancerequired (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MF_d1_IsAdvanceRequired-OnChange");
if(ISpace["MF_d1_IsAdvanceRequired"].Value=="No")
{
base.WriteDebugInfo(@"if(ISpace[""MF_d1_IsAdvanceRequired""].Value==""No"")");
ISpace["MF_EligibleAdavnce"].Visible="false";ISpace["MF_d1_AdvanceAmount"].Visible="false";
base.WriteDebugInfo(@"ISpace[""MF_EligibleAdavnce""].Visible=""false"";ISpace[""MF_d1_AdvanceAmount""].Visible=""false"";");
}
if(ISpace["MF_d1_IsAdvanceRequired"].Value=="Yes")
{
base.WriteDebugInfo(@"if(ISpace[""MF_d1_IsAdvanceRequired""].Value==""Yes"")");
ISpace["MF_EligibleAdavnce"].Visible="true";ISpace["MF_d1_AdvanceAmount"].Visible="true";ISpace["MF_d1_AdvanceAmount"].Man=true;
base.WriteDebugInfo(@"ISpace[""MF_EligibleAdavnce""].Visible=""true"";ISpace[""MF_d1_AdvanceAmount""].Visible=""true"";ISpace[""MF_d1_AdvanceAmount""].Man=true;");
}
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
ISpace["WF_FlowType"].Value="APPROVE";
base.WriteDebugInfo(@"ISpace[""WF_FlowType""].Value=""APPROVE"";");
ISpace["Comments"].Man=false;
base.WriteDebugInfo(@"ISpace[""Comments""].Man=false;");
}
if(ISpace["WMF_MoveTo"].Value=="RETURN")
{
base.WriteDebugInfo(@"if(ISpace[""WMF_MoveTo""].Value==""RETURN"")");
ISpace["WF_FlowType"].Value="RETURN";
base.WriteDebugInfo(@"ISpace[""WF_FlowType""].Value=""RETURN"";");
ISpace["Comments"].Man=true;
base.WriteDebugInfo(@"ISpace[""Comments""].Man=true;");
}
if(ISpace["WMF_MoveTo"].Value=="REJECT")
{
base.WriteDebugInfo(@"if(ISpace[""WMF_MoveTo""].Value==""REJECT"")");
ISpace["WF_FlowType"].Value="REJECT";
base.WriteDebugInfo(@"ISpace[""WF_FlowType""].Value=""REJECT"";");
ISpace["Comments"].Man=true;
base.WriteDebugInfo(@"ISpace[""Comments""].Man=true;");
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_fwfm_fundtype (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"FWFM_FundType-OnChange");
if(ISpace["FWFM_FundType"].Value=="2")
{
base.WriteDebugInfo(@"if(ISpace[""FWFM_FundType""].Value==""2"")");
ISpace["FWFM_BudgetHead"].Visible="false";ISpace["FWFM_ProjectNo"].Visible="false";
base.WriteDebugInfo(@"ISpace[""FWFM_BudgetHead""].Visible=""false"";ISpace[""FWFM_ProjectNo""].Visible=""false"";");
ISpace["FWFM_BudgetHead"].Value="";
base.WriteDebugInfo(@"ISpace[""FWFM_BudgetHead""].Value="""";");
ISpace["FWFM_ProjectNo"].Value="";
base.WriteDebugInfo(@"ISpace[""FWFM_ProjectNo""].Value="""";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["FWFM_BudgetHead"].Visible="true";ISpace["FWFM_ProjectNo"].Visible="true";
base.WriteDebugInfo(@"ISpace[""FWFM_BudgetHead""].Visible=""true"";ISpace[""FWFM_ProjectNo""].Visible=""true"";");
}
if(ISpace["FWFM_FundType"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""FWFM_FundType""].Value=="""")");
ISpace["FWFM_BudgetHead"].Visible="false";ISpace["FWFM_ProjectNo"].Visible="false";ISpace["FWFM_Amount"].Visible="false";
base.WriteDebugInfo(@"ISpace[""FWFM_BudgetHead""].Visible=""false"";ISpace[""FWFM_ProjectNo""].Visible=""false"";ISpace[""FWFM_Amount""].Visible=""false"";");
}
if(ISpace["FormVersionId"].Value=="48D9155C-42D2-4414-AF53-3D00D9908DD4")
{
ISpace["UI_ApprovalHideRow"].Visible="false";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""48D9155C-42D2-4414-AF53-3D00D9908DD4"")
{
ISpace[""UI_ApprovalHideRow""].Visible=""false"";
}");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_pfa_delete (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"PFA_Delete-OnClick");
ISpace["PFM_FundDetailsId"].Value=ISpace["PFA_FundDetailsId"].Value;
base.WriteDebugInfo(@"ISpace[""PFM_FundDetailsId""].Value=ISpace[""PFA_FundDetailsId""].Value;");
ISpace["UI_DeleteDialog"].ShowDialog=true;;
base.WriteDebugInfo(@"ISpace[""UI_DeleteDialog""].ShowDialog=true;;");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_pfa_edit (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"PFA_Edit-OnClick");
base.WriteDebugInfo(@"Exec [Get60e821d0-153e-94bb-1fef-2594b78625bd] '@@gv_InstanceId','#PFA_FundDetailsId'");

var querySource1D7C9725F11C4C72BB58A7C49B33E1C9 =GetQueryExpressionDataSource("1D7C9725-F11C-4C72-BB58-A7C49B33E1C9");
Dictionary<short,object> result1D7C9725F11C4C72BB58A7C49B33E1C9=iSpace.ExecuteQuery(querySource1D7C9725F11C4C72BB58A7C49B33E1C9,@"Exec [Get60e821d0-153e-94bb-1fef-2594b78625bd] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["PFA_FundDetailsId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource1D7C9725F11C4C72BB58A7C49B33E1C9 =GetQueryExpressionDataSource(""1D7C9725-F11C-4C72-BB58-A7C49B33E1C9"");Dictionary<short,object> result1D7C9725F11C4C72BB58A7C49B33E1C9=iSpace.ExecuteQuery(querySource1D7C9725F11C4C72BB58A7C49B33E1C9,@""Exec [Get60e821d0-153e-94bb-1fef-2594b78625bd] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""PFA_FundDetailsId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result1D7C9725F11C4C72BB58A7C49B33E1C9!=null) && (result1D7C9725F11C4C72BB58A7C49B33E1C9.Count!=0))
{
if(result1D7C9725F11C4C72BB58A7C49B33E1C9.ContainsKey(9))
ISpace["FWFM_BudgetHead"].Value = result1D7C9725F11C4C72BB58A7C49B33E1C9[9];
if(result1D7C9725F11C4C72BB58A7C49B33E1C9.ContainsKey(7))
ISpace["FWFM_ProjectNo"].Value = result1D7C9725F11C4C72BB58A7C49B33E1C9[7];
if(result1D7C9725F11C4C72BB58A7C49B33E1C9.ContainsKey(5))
ISpace["FWFM_FundType"].Value = result1D7C9725F11C4C72BB58A7C49B33E1C9[5];
if(result1D7C9725F11C4C72BB58A7C49B33E1C9.ContainsKey(11))
ISpace["FWFM_Amount"].Value = result1D7C9725F11C4C72BB58A7C49B33E1C9[11];
if(result1D7C9725F11C4C72BB58A7C49B33E1C9.ContainsKey(3))
ISpace["FWFM_FundDetailsId"].Value = result1D7C9725F11C4C72BB58A7C49B33E1C9[3];
}
else{
ISpace["FWFM_BudgetHead"].Value = null;ISpace["FWFM_ProjectNo"].Value = null;ISpace["FWFM_FundType"].Value = null;ISpace["FWFM_Amount"].Value = null;ISpace["FWFM_FundDetailsId"].Value = null;
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mfg_d3_expendituretype (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MFG_d3_ExpenditureType-OnChange");
if(ISpace["MFG_d3_ExpenditureType"].Value!="1045")
{
base.WriteDebugInfo(@"if(ISpace[""MFG_d3_ExpenditureType""].Value!=""1045"")");
ISpace["MFG_d3_OtherExpenditureType"].Visible="false";
base.WriteDebugInfo(@"ISpace[""MFG_d3_OtherExpenditureType""].Visible=""false"";");
}
if(ISpace["MFG_d3_ExpenditureType"].Value=="1045")
{
base.WriteDebugInfo(@"if(ISpace[""MFG_d3_ExpenditureType""].Value==""1045"")");
ISpace["MFG_d3_OtherExpenditureType"].Visible="true";
base.WriteDebugInfo(@"ISpace[""MFG_d3_OtherExpenditureType""].Visible=""true"";");
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_edit_expensedetails (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Edit_ExpenseDetails-OnClick");
ISpace["growid"].Value=ISpace["ExpenseDetails_RowId"].Value;
base.WriteDebugInfo(@"ISpace[""growid""].Value=ISpace[""ExpenseDetails_RowId""].Value;");
base.WriteDebugInfo(@"EXEC [LoadFormGridData63762982-2C07-4E60-8D86-D3A35CA53EDA] '@@gv_InstanceId','@@gv_ActivityMapId','63762982-2C07-4E60-8D86-D3A35CA53EDA','#growid',#ExpenseDetails_Sequence");

var querySource1A41CC35C2E4455C98AF7868BC351B2C =GetQueryExpressionDataSource("1A41CC35-C2E4-455C-98AF-7868BC351B2C");
Dictionary<short,object> result1A41CC35C2E4455C98AF7868BC351B2C=iSpace.ExecuteQuery(querySource1A41CC35C2E4455C98AF7868BC351B2C,@"EXEC [LoadFormGridData63762982-2C07-4E60-8D86-D3A35CA53EDA] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','63762982-2C07-4E60-8D86-D3A35CA53EDA','" + ISpace["growid"].Value + @"'," + ISpace["ExpenseDetails_Sequence"].Value + @"",false);

base.WriteDebugInfo(@"var querySource1A41CC35C2E4455C98AF7868BC351B2C =GetQueryExpressionDataSource(""1A41CC35-C2E4-455C-98AF-7868BC351B2C"");Dictionary<short,object> result1A41CC35C2E4455C98AF7868BC351B2C=iSpace.ExecuteQuery(querySource1A41CC35C2E4455C98AF7868BC351B2C,@""EXEC [LoadFormGridData63762982-2C07-4E60-8D86-D3A35CA53EDA] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','63762982-2C07-4E60-8D86-D3A35CA53EDA','"" + ISpace[""growid""].Value + @""',"" + ISpace[""ExpenseDetails_Sequence""].Value + @"""",false);");
base.WriteDebugInfo(@"EXEC [LoadFormGridData63762982-2C07-4E60-8D86-D3A35CA53EDA] '@@gv_InstanceId','@@gv_ActivityMapId','63762982-2C07-4E60-8D86-D3A35CA53EDA','#growid',#ExpenseDetails_Sequence");

if((result1A41CC35C2E4455C98AF7868BC351B2C!=null) && (result1A41CC35C2E4455C98AF7868BC351B2C.Count!=0))
{
if(result1A41CC35C2E4455C98AF7868BC351B2C.ContainsKey(2))
ISpace["MFG_d3_FromDate"].Value = result1A41CC35C2E4455C98AF7868BC351B2C[2];
if(result1A41CC35C2E4455C98AF7868BC351B2C.ContainsKey(6))
ISpace["MFG_d3_UpdatedOn"].Value = result1A41CC35C2E4455C98AF7868BC351B2C[6];
if(result1A41CC35C2E4455C98AF7868BC351B2C.ContainsKey(3))
ISpace["MFG_d3_ToDate"].Value = result1A41CC35C2E4455C98AF7868BC351B2C[3];
if(result1A41CC35C2E4455C98AF7868BC351B2C.ContainsKey(7))
ISpace["MFG_d3_ExpenditureType"].Value = result1A41CC35C2E4455C98AF7868BC351B2C[7];
if(result1A41CC35C2E4455C98AF7868BC351B2C.ContainsKey(4))
ISpace["MFG_d3_Amount"].Value = result1A41CC35C2E4455C98AF7868BC351B2C[4];
if(result1A41CC35C2E4455C98AF7868BC351B2C.ContainsKey(9))
ISpace["MFG_d3_IsTravelRequest"].Value = result1A41CC35C2E4455C98AF7868BC351B2C[9];
if(result1A41CC35C2E4455C98AF7868BC351B2C.ContainsKey(5))
ISpace["MFG_d3_UpdatedBy"].Value = result1A41CC35C2E4455C98AF7868BC351B2C[5];
if(result1A41CC35C2E4455C98AF7868BC351B2C.ContainsKey(1))
ISpace["MFG_d3_TravelAdvanceID"].Value = result1A41CC35C2E4455C98AF7868BC351B2C[1];
if(result1A41CC35C2E4455C98AF7868BC351B2C.ContainsKey(0))
ISpace["MFG_d3_ExpenditureTypeID"].Value = result1A41CC35C2E4455C98AF7868BC351B2C[0];
if(result1A41CC35C2E4455C98AF7868BC351B2C.ContainsKey(8))
ISpace["MFG_d3_OtherExpenditureType"].Value = result1A41CC35C2E4455C98AF7868BC351B2C[8];
}
else{
ISpace["MFG_d3_FromDate"].Value = null;ISpace["MFG_d3_UpdatedOn"].Value = null;ISpace["MFG_d3_ToDate"].Value = null;ISpace["MFG_d3_ExpenditureType"].Value = null;ISpace["MFG_d3_Amount"].Value = null;ISpace["MFG_d3_IsTravelRequest"].Value = null;ISpace["MFG_d3_UpdatedBy"].Value = null;ISpace["MFG_d3_TravelAdvanceID"].Value = null;ISpace["MFG_d3_ExpenditureTypeID"].Value = null;ISpace["MFG_d3_OtherExpenditureType"].Value = null;
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
		if(elementName.ToLower().Equals("fwfm_projectno"))
    {
    			SubscribeElementEvents_fwfm_projectno(ref dfsParam);
    }
		if(elementName.ToLower().Equals("fwab_projectno"))
    {
    			SubscribeElementEvents_fwab_projectno(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mfg_d2_modeofjourney"))
    {
    			SubscribeElementEvents_mfg_d2_modeofjourney(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mf_d1_isadvancerequired"))
    {
    			SubscribeElementEvents_mf_d1_isadvancerequired(ref dfsParam);
    }
		if(elementName.ToLower().Equals("wmf_moveto"))
    {
    			SubscribeElementEvents_wmf_moveto(ref dfsParam);
    }
		if(elementName.ToLower().Equals("fwfm_fundtype"))
    {
    			SubscribeElementEvents_fwfm_fundtype(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mfg_d3_expendituretype"))
    {
    			SubscribeElementEvents_mfg_d3_expendituretype(ref dfsParam);
    }
}
	if(methodName.ToLower().Equals("onclick"))
{
		if(elementName.ToLower().Equals("fwfm_save"))
{
			SubscribeElementEvents_fwfm_save(ref dfsParam);
}
		if(elementName.ToLower().Equals("pfa_widgetsubmit"))
{
			SubscribeElementEvents_pfa_widgetsubmit(ref dfsParam);
}
		if(elementName.ToLower().Equals("wmf_history"))
{
			SubscribeElementEvents_wmf_history(ref dfsParam);
}
		if(elementName.ToLower().Equals("pfm_yes"))
{
			SubscribeElementEvents_pfm_yes(ref dfsParam);
}
		if(elementName.ToLower().Equals("fwmf_availablebudget"))
{
			SubscribeElementEvents_fwmf_availablebudget(ref dfsParam);
}
		if(elementName.ToLower().Equals("save_advancedetails"))
{
			SubscribeElementEvents_save_advancedetails(ref dfsParam);
}
		if(elementName.ToLower().Equals("edit_advancedetails"))
{
			SubscribeElementEvents_edit_advancedetails(ref dfsParam);
}
		if(elementName.ToLower().Equals("pfm_no"))
{
			SubscribeElementEvents_pfm_no(ref dfsParam);
}
		if(elementName.ToLower().Equals("submitform"))
{
			SubscribeElementEvents_submitform(ref dfsParam);
}
		if(elementName.ToLower().Equals("save_expensedetails"))
{
			SubscribeElementEvents_save_expensedetails(ref dfsParam);
}
		if(elementName.ToLower().Equals("pfa_delete"))
{
			SubscribeElementEvents_pfa_delete(ref dfsParam);
}
		if(elementName.ToLower().Equals("pfa_edit"))
{
			SubscribeElementEvents_pfa_edit(ref dfsParam);
}
		if(elementName.ToLower().Equals("edit_expensedetails"))
{
			SubscribeElementEvents_edit_expensedetails(ref dfsParam);
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
public class ISpace34A8F37F24BF4316826BDF78EE6E8579 : VirtualForm
{
IISpace iSpace = new ISpace();
AcDataISpace34A8F37F24BF4316826BDF78EE6E8579 acdataIspace34A8F37F24BF4316826BDF78EE6E8579=new AcDataISpace34A8F37F24BF4316826BDF78EE6E8579();
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
if(ISpace["FormVersionId"].Value=="48D9155C-42D2-4414-AF53-3D00D9908DD4")
{
ISpace["UI_PFHideRow"].Visible="false";
}if(ISpace["FormVersionId"].Value=="48D9155C-42D2-4414-AF53-3D00D9908DD4")
{
ISpace["UI_ApprovalHideRow"].Visible="false";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""48D9155C-42D2-4414-AF53-3D00D9908DD4"")
{
ISpace[""UI_PFHideRow""].Visible=""false"";
}if(ISpace[""FormVersionId""].Value==""48D9155C-42D2-4414-AF53-3D00D9908DD4"")
{
ISpace[""UI_ApprovalHideRow""].Visible=""false"";
}");
ISpace["Comments"].Value="";
base.WriteDebugInfo(@"ISpace[""Comments""].Value="""";");
ISpace["WMF_MoveTo"].Value="";
base.WriteDebugInfo(@"ISpace[""WMF_MoveTo""].Value="""";");
}
if(ISpace["WF_FlowType"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""WF_FlowType""].Value=="""")");
ISpace["WMF_IsInFlow"].Value=0;
base.WriteDebugInfo(@"ISpace[""WMF_IsInFlow""].Value=0;");
base.WriteDebugInfo(@"EXEC [GetInstanceInFlow] '@@gv_InstanceId'");

var querySource76804AA1305E4E7F895EB90B051455D5 =GetQueryExpressionDataSource("76804AA1-305E-4E7F-895E-B90B051455D5");
Dictionary<short,object> result76804AA1305E4E7F895EB90B051455D5=iSpace.ExecuteQuery(querySource76804AA1305E4E7F895EB90B051455D5,@"EXEC [GetInstanceInFlow] '" + ISpace["gv_instanceid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource76804AA1305E4E7F895EB90B051455D5 =GetQueryExpressionDataSource(""76804AA1-305E-4E7F-895E-B90B051455D5"");Dictionary<short,object> result76804AA1305E4E7F895EB90B051455D5=iSpace.ExecuteQuery(querySource76804AA1305E4E7F895EB90B051455D5,@""EXEC [GetInstanceInFlow] '"" + ISpace[""gv_instanceid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result76804AA1305E4E7F895EB90B051455D5!=null) && (result76804AA1305E4E7F895EB90B051455D5.Count!=0))
{
if(result76804AA1305E4E7F895EB90B051455D5.ContainsKey(0))
ISpace["WMF_IsInFlow"].Value = result76804AA1305E4E7F895EB90B051455D5[0];
}
else{
ISpace["WMF_IsInFlow"].Value = null;
}
if(ISpace["WMF_IsInFlow"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""WMF_IsInFlow""].Value==1)");
ISpace["WF_FlowType"].Value="APPROVE";
base.WriteDebugInfo(@"ISpace[""WF_FlowType""].Value=""APPROVE"";");
ISpace["WMF_History"].Visible="true";ISpace["WMF_MoveTo"].Visible="true";
base.WriteDebugInfo(@"ISpace[""WMF_History""].Visible=""true"";ISpace[""WMF_MoveTo""].Visible=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["WMF_History"].Visible="false";ISpace["WMF_MoveTo"].Visible="false";
base.WriteDebugInfo(@"ISpace[""WMF_History""].Visible=""false"";ISpace[""WMF_MoveTo""].Visible=""false"";");
}
}
ISpace["WMF_MoveTo"].Man=true;
base.WriteDebugInfo(@"ISpace[""WMF_MoveTo""].Man=true;");

var querySource698205C52C1A42F39D81823D3215AB11 =GetQueryExpressionDataSource("698205C5-2C1A-42F3-9D81-823D3215AB11");

DataTable result698205C52C1A42F39D81823D3215AB11=iSpace.SetGridDataSource(querySource698205C52C1A42F39D81823D3215AB11, _objectFactory.GetGridRPP("WMG_CommentsHistory"),@"EXEC [GetInstanceFlowDetais] '" + ISpace["gv_instanceid"].Value + @"'");

iSpace.InsertGridBindDetails("WMG_CommentsHistory","11",querySource698205C52C1A42F39D81823D3215AB11,"EXEC [GetInstanceFlowDetais] '" + ISpace["gv_instanceid"].Value + @"'",_objectFactory.GetGridRPP("WMG_CommentsHistory"));

base.WriteDebugInfo(@"var querySource698205C52C1A42F39D81823D3215AB11 =GetQueryExpressionDataSource(""698205C5-2C1A-42F3-9D81-823D3215AB11"");DataTable result698205C52C1A42F39D81823D3215AB11=iSpace.SetGridDataSource(querySource698205C52C1A42F39D81823D3215AB11, _objectFactory.GetGridRPP(""WMG_CommentsHistory""),@""EXEC [GetInstanceFlowDetais] '"" + ISpace[""gv_instanceid""].Value + @""'"");iSpace.InsertGridBindDetails(""WMG_CommentsHistory"",""11"",querySource698205C52C1A42F39D81823D3215AB11,""EXEC [GetInstanceFlowDetais] '"" + ISpace[""gv_instanceid""].Value + @""'"",_objectFactory.GetGridRPP(""WMG_CommentsHistory""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result794A7328890E42A3B11A5984B2D49196=acdataIspace34A8F37F24BF4316826BDF78EE6E8579.GetQueryExpressionBindings("794A7328-890E-42A3-B11A-5984B2D49196");
iSpace.SetGridData(result698205C52C1A42F39D81823D3215AB11,result794A7328890E42A3B11A5984B2D49196,"WMG_CommentsHistory",ref ISpace);
iSpace.UpdateGridBindDetails("WMG_CommentsHistory",result794A7328890E42A3B11A5984B2D49196);
ISpace["UI_History"].ShowDialog=true;;
base.WriteDebugInfo(@"ISpace[""UI_History""].ShowDialog=true;;");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_wmf_history (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"WMF_History-OnClick");

var querySource698205C52C1A42F39D81823D3215AB11 =GetQueryExpressionDataSource("698205C5-2C1A-42F3-9D81-823D3215AB11");

DataTable result698205C52C1A42F39D81823D3215AB11=iSpace.SetGridDataSource(querySource698205C52C1A42F39D81823D3215AB11, _objectFactory.GetGridRPP("WMG_CommentsHistory"),@"EXEC [GetInstanceFlowDetais] '" + ISpace["gv_instanceid"].Value + @"'");

iSpace.InsertGridBindDetails("WMG_CommentsHistory","11",querySource698205C52C1A42F39D81823D3215AB11,"EXEC [GetInstanceFlowDetais] '" + ISpace["gv_instanceid"].Value + @"'",_objectFactory.GetGridRPP("WMG_CommentsHistory"));

base.WriteDebugInfo(@"var querySource698205C52C1A42F39D81823D3215AB11 =GetQueryExpressionDataSource(""698205C5-2C1A-42F3-9D81-823D3215AB11"");DataTable result698205C52C1A42F39D81823D3215AB11=iSpace.SetGridDataSource(querySource698205C52C1A42F39D81823D3215AB11, _objectFactory.GetGridRPP(""WMG_CommentsHistory""),@""EXEC [GetInstanceFlowDetais] '"" + ISpace[""gv_instanceid""].Value + @""'"");iSpace.InsertGridBindDetails(""WMG_CommentsHistory"",""11"",querySource698205C52C1A42F39D81823D3215AB11,""EXEC [GetInstanceFlowDetais] '"" + ISpace[""gv_instanceid""].Value + @""'"",_objectFactory.GetGridRPP(""WMG_CommentsHistory""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result794A7328890E42A3B11A5984B2D49196=acdataIspace34A8F37F24BF4316826BDF78EE6E8579.GetQueryExpressionBindings("794A7328-890E-42A3-B11A-5984B2D49196");
iSpace.SetGridData(result698205C52C1A42F39D81823D3215AB11,result794A7328890E42A3B11A5984B2D49196,"WMG_CommentsHistory",ref ISpace);
iSpace.UpdateGridBindDetails("WMG_CommentsHistory",result794A7328890E42A3B11A5984B2D49196);
ISpace["UI_History"].ShowDialog=true;;
base.WriteDebugInfo(@"ISpace[""UI_History""].ShowDialog=true;;");
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
if(ISpace["WF_FlowType"].Value=="APPROVE")
{
base.WriteDebugInfo(@"if(ISpace[""WF_FlowType""].Value==""APPROVE"")");
if(ISpace["WMF_MoveTo"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""WMF_MoveTo""].Value=="""")");
ISpace["Message"].Value=@"Error:Please Select Next Action";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Error:Please Select Next Action"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
}
if(ISpace["WF_FlowType"].Value=="RETURN" || ISpace["WF_FlowType"].Value=="REJECT")
{
base.WriteDebugInfo(@"if(ISpace[""WF_FlowType""].Value==""RETURN"" || ISpace[""WF_FlowType""].Value==""REJECT"")");
if(ISpace["WMF_MoveTo"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""WMF_MoveTo""].Value=="""")");
ISpace["Message"].Value=@"Error:Please Select Next Action";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Error:Please Select Next Action"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if(ISpace["Comments"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""Comments""].Value=="""")");
ISpace["Message"].Value=@"Error: Please Enter Comments";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Error: Please Enter Comments"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
}
ISpace["Message"].Value=@"Success: Submitted Successfully";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Success: Submitted Successfully"";");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC [UpdateTravelRequestStatus] '@@gv_InstanceId','@@gv_UserId','#WF_FlowType'");

var querySourcefbb131bf5cbf0eb86f44bf481055f5b7 =GetQueryExpressionDataSource("fbb131bf-5cbf-0eb8-6f44-bf481055f5b7");
Dictionary<short,object> resultfbb131bf5cbf0eb86f44bf481055f5b7=iSpace.ExecuteQuery(querySourcefbb131bf5cbf0eb86f44bf481055f5b7,@"EXEC [UpdateTravelRequestStatus] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_userid"].Value + @"','" + ISpace["WF_FlowType"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourcefbb131bf5cbf0eb86f44bf481055f5b7 =GetQueryExpressionDataSource(""fbb131bf-5cbf-0eb8-6f44-bf481055f5b7"");Dictionary<short,object> resultfbb131bf5cbf0eb86f44bf481055f5b7=iSpace.ExecuteQuery(querySourcefbb131bf5cbf0eb86f44bf481055f5b7,@""EXEC [UpdateTravelRequestStatus] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_userid""].Value + @""','"" + ISpace[""WF_FlowType""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultfbb131bf5cbf0eb86f44bf481055f5b7!=null) && (resultfbb131bf5cbf0eb86f44bf481055f5b7.Count!=0))
{
if(resultfbb131bf5cbf0eb86f44bf481055f5b7.ContainsKey(0))
ISpace["MF_ErrId"].Value = resultfbb131bf5cbf0eb86f44bf481055f5b7[0];
if(resultfbb131bf5cbf0eb86f44bf481055f5b7.ContainsKey(1))
ISpace["MF_ErrMsg"].Value = resultfbb131bf5cbf0eb86f44bf481055f5b7[1];
}
else{
ISpace["MF_ErrId"].Value = null;ISpace["MF_ErrMsg"].Value = null;
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
private void SubscribeElementEvents_wmf_moveto (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"WMF_MoveTo-OnChange");
if(ISpace["WMF_MoveTo"].Value=="APPROVE")
{
base.WriteDebugInfo(@"if(ISpace[""WMF_MoveTo""].Value==""APPROVE"")");
ISpace["WF_FlowType"].Value="APPROVE";
base.WriteDebugInfo(@"ISpace[""WF_FlowType""].Value=""APPROVE"";");
ISpace["Comments"].Man=false;
base.WriteDebugInfo(@"ISpace[""Comments""].Man=false;");
}
if(ISpace["WMF_MoveTo"].Value=="RETURN")
{
base.WriteDebugInfo(@"if(ISpace[""WMF_MoveTo""].Value==""RETURN"")");
ISpace["WF_FlowType"].Value="RETURN";
base.WriteDebugInfo(@"ISpace[""WF_FlowType""].Value=""RETURN"";");
ISpace["Comments"].Man=true;
base.WriteDebugInfo(@"ISpace[""Comments""].Man=true;");
}
if(ISpace["WMF_MoveTo"].Value=="REJECT")
{
base.WriteDebugInfo(@"if(ISpace[""WMF_MoveTo""].Value==""REJECT"")");
ISpace["WF_FlowType"].Value="REJECT";
base.WriteDebugInfo(@"ISpace[""WF_FlowType""].Value=""REJECT"";");
ISpace["Comments"].Man=true;
base.WriteDebugInfo(@"ISpace[""Comments""].Man=true;");
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_cancelform (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"CancelForm-OnClick");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC [UnlockProcessInstance] '@@gv_InstanceId','@@gv_UserMapId'");

var querySource4c20e7236b4e1baa1f33b09cc235bbe6 =GetQueryExpressionDataSource("4c20e723-6b4e-1baa-1f33-b09cc235bbe6");
Dictionary<short,object> result4c20e7236b4e1baa1f33b09cc235bbe6=iSpace.ExecuteQuery(querySource4c20e7236b4e1baa1f33b09cc235bbe6,@"EXEC [UnlockProcessInstance] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_usermapid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource4c20e7236b4e1baa1f33b09cc235bbe6 =GetQueryExpressionDataSource(""4c20e723-6b4e-1baa-1f33-b09cc235bbe6"");Dictionary<short,object> result4c20e7236b4e1baa1f33b09cc235bbe6=iSpace.ExecuteQuery(querySource4c20e7236b4e1baa1f33b09cc235bbe6,@""EXEC [UnlockProcessInstance] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_usermapid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result4c20e7236b4e1baa1f33b09cc235bbe6!=null) && (result4c20e7236b4e1baa1f33b09cc235bbe6.Count!=0))
{
if(result4c20e7236b4e1baa1f33b09cc235bbe6.ContainsKey(0))
ISpace["MF_ErrId"].Value = result4c20e7236b4e1baa1f33b09cc235bbe6[0];
}
else{
ISpace["MF_ErrId"].Value = null;
}
}
ISpace["Message"].Value=@"Success: Cancelled Successfully";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Success: Cancelled Successfully"";");

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
		if(elementName.ToLower().Equals("wmf_moveto"))
    {
    			SubscribeElementEvents_wmf_moveto(ref dfsParam);
    }
}
	if(methodName.ToLower().Equals("onclick"))
{
		if(elementName.ToLower().Equals("wmf_history"))
{
			SubscribeElementEvents_wmf_history(ref dfsParam);
}
		if(elementName.ToLower().Equals("submitform"))
{
			SubscribeElementEvents_submitform(ref dfsParam);
}
		if(elementName.ToLower().Equals("cancelform"))
{
			SubscribeElementEvents_cancelform(ref dfsParam);
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
public class ISpaceA09DFE7057414CBDA7B76CCED54DCE3D : VirtualForm
{
IISpace iSpace = new ISpace();
AcDataISpaceA09DFE7057414CBDA7B76CCED54DCE3D acdataIspaceA09DFE7057414CBDA7B76CCED54DCE3D=new AcDataISpaceA09DFE7057414CBDA7B76CCED54DCE3D();
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
if(ISpace["FormVersionId"].Value=="48D9155C-42D2-4414-AF53-3D00D9908DD4")
{
ISpace["UI_PFHideRow"].Visible="false";
}if(ISpace["FormVersionId"].Value=="48D9155C-42D2-4414-AF53-3D00D9908DD4")
{
ISpace["UI_ApprovalHideRow"].Visible="false";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""48D9155C-42D2-4414-AF53-3D00D9908DD4"")
{
ISpace[""UI_PFHideRow""].Visible=""false"";
}if(ISpace[""FormVersionId""].Value==""48D9155C-42D2-4414-AF53-3D00D9908DD4"")
{
ISpace[""UI_ApprovalHideRow""].Visible=""false"";
}");
ISpace["Comments"].Value="";
base.WriteDebugInfo(@"ISpace[""Comments""].Value="""";");
ISpace["WMF_MoveTo"].Value="";
base.WriteDebugInfo(@"ISpace[""WMF_MoveTo""].Value="""";");
}
if(ISpace["WF_FlowType"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""WF_FlowType""].Value=="""")");
ISpace["WMF_IsInFlow"].Value=0;
base.WriteDebugInfo(@"ISpace[""WMF_IsInFlow""].Value=0;");
base.WriteDebugInfo(@"EXEC [GetInstanceInFlow] '@@gv_InstanceId'");

var querySource76804AA1305E4E7F895EB90B051455D5 =GetQueryExpressionDataSource("76804AA1-305E-4E7F-895E-B90B051455D5");
Dictionary<short,object> result76804AA1305E4E7F895EB90B051455D5=iSpace.ExecuteQuery(querySource76804AA1305E4E7F895EB90B051455D5,@"EXEC [GetInstanceInFlow] '" + ISpace["gv_instanceid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource76804AA1305E4E7F895EB90B051455D5 =GetQueryExpressionDataSource(""76804AA1-305E-4E7F-895E-B90B051455D5"");Dictionary<short,object> result76804AA1305E4E7F895EB90B051455D5=iSpace.ExecuteQuery(querySource76804AA1305E4E7F895EB90B051455D5,@""EXEC [GetInstanceInFlow] '"" + ISpace[""gv_instanceid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result76804AA1305E4E7F895EB90B051455D5!=null) && (result76804AA1305E4E7F895EB90B051455D5.Count!=0))
{
if(result76804AA1305E4E7F895EB90B051455D5.ContainsKey(0))
ISpace["WMF_IsInFlow"].Value = result76804AA1305E4E7F895EB90B051455D5[0];
}
else{
ISpace["WMF_IsInFlow"].Value = null;
}
if(ISpace["WMF_IsInFlow"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""WMF_IsInFlow""].Value==1)");
ISpace["WF_FlowType"].Value="APPROVE";
base.WriteDebugInfo(@"ISpace[""WF_FlowType""].Value=""APPROVE"";");
ISpace["WMF_History"].Visible="true";ISpace["WMF_MoveTo"].Visible="true";
base.WriteDebugInfo(@"ISpace[""WMF_History""].Visible=""true"";ISpace[""WMF_MoveTo""].Visible=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["WMF_History"].Visible="false";ISpace["WMF_MoveTo"].Visible="false";
base.WriteDebugInfo(@"ISpace[""WMF_History""].Visible=""false"";ISpace[""WMF_MoveTo""].Visible=""false"";");
}
}
ISpace["WMF_MoveTo"].Man=true;
base.WriteDebugInfo(@"ISpace[""WMF_MoveTo""].Man=true;");

var querySource698205C52C1A42F39D81823D3215AB11 =GetQueryExpressionDataSource("698205C5-2C1A-42F3-9D81-823D3215AB11");

DataTable result698205C52C1A42F39D81823D3215AB11=iSpace.SetGridDataSource(querySource698205C52C1A42F39D81823D3215AB11, _objectFactory.GetGridRPP("WMG_CommentsHistory"),@"EXEC [GetInstanceFlowDetais] '" + ISpace["gv_instanceid"].Value + @"'");

iSpace.InsertGridBindDetails("WMG_CommentsHistory","11",querySource698205C52C1A42F39D81823D3215AB11,"EXEC [GetInstanceFlowDetais] '" + ISpace["gv_instanceid"].Value + @"'",_objectFactory.GetGridRPP("WMG_CommentsHistory"));

base.WriteDebugInfo(@"var querySource698205C52C1A42F39D81823D3215AB11 =GetQueryExpressionDataSource(""698205C5-2C1A-42F3-9D81-823D3215AB11"");DataTable result698205C52C1A42F39D81823D3215AB11=iSpace.SetGridDataSource(querySource698205C52C1A42F39D81823D3215AB11, _objectFactory.GetGridRPP(""WMG_CommentsHistory""),@""EXEC [GetInstanceFlowDetais] '"" + ISpace[""gv_instanceid""].Value + @""'"");iSpace.InsertGridBindDetails(""WMG_CommentsHistory"",""11"",querySource698205C52C1A42F39D81823D3215AB11,""EXEC [GetInstanceFlowDetais] '"" + ISpace[""gv_instanceid""].Value + @""'"",_objectFactory.GetGridRPP(""WMG_CommentsHistory""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result794A7328890E42A3B11A5984B2D49196=acdataIspaceA09DFE7057414CBDA7B76CCED54DCE3D.GetQueryExpressionBindings("794A7328-890E-42A3-B11A-5984B2D49196");
iSpace.SetGridData(result698205C52C1A42F39D81823D3215AB11,result794A7328890E42A3B11A5984B2D49196,"WMG_CommentsHistory",ref ISpace);
iSpace.UpdateGridBindDetails("WMG_CommentsHistory",result794A7328890E42A3B11A5984B2D49196);
ISpace["UI_History"].ShowDialog=true;;
base.WriteDebugInfo(@"ISpace[""UI_History""].ShowDialog=true;;");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_wmf_history (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"WMF_History-OnClick");

var querySource698205C52C1A42F39D81823D3215AB11 =GetQueryExpressionDataSource("698205C5-2C1A-42F3-9D81-823D3215AB11");

DataTable result698205C52C1A42F39D81823D3215AB11=iSpace.SetGridDataSource(querySource698205C52C1A42F39D81823D3215AB11, _objectFactory.GetGridRPP("WMG_CommentsHistory"),@"EXEC [GetInstanceFlowDetais] '" + ISpace["gv_instanceid"].Value + @"'");

iSpace.InsertGridBindDetails("WMG_CommentsHistory","11",querySource698205C52C1A42F39D81823D3215AB11,"EXEC [GetInstanceFlowDetais] '" + ISpace["gv_instanceid"].Value + @"'",_objectFactory.GetGridRPP("WMG_CommentsHistory"));

base.WriteDebugInfo(@"var querySource698205C52C1A42F39D81823D3215AB11 =GetQueryExpressionDataSource(""698205C5-2C1A-42F3-9D81-823D3215AB11"");DataTable result698205C52C1A42F39D81823D3215AB11=iSpace.SetGridDataSource(querySource698205C52C1A42F39D81823D3215AB11, _objectFactory.GetGridRPP(""WMG_CommentsHistory""),@""EXEC [GetInstanceFlowDetais] '"" + ISpace[""gv_instanceid""].Value + @""'"");iSpace.InsertGridBindDetails(""WMG_CommentsHistory"",""11"",querySource698205C52C1A42F39D81823D3215AB11,""EXEC [GetInstanceFlowDetais] '"" + ISpace[""gv_instanceid""].Value + @""'"",_objectFactory.GetGridRPP(""WMG_CommentsHistory""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result794A7328890E42A3B11A5984B2D49196=acdataIspaceA09DFE7057414CBDA7B76CCED54DCE3D.GetQueryExpressionBindings("794A7328-890E-42A3-B11A-5984B2D49196");
iSpace.SetGridData(result698205C52C1A42F39D81823D3215AB11,result794A7328890E42A3B11A5984B2D49196,"WMG_CommentsHistory",ref ISpace);
iSpace.UpdateGridBindDetails("WMG_CommentsHistory",result794A7328890E42A3B11A5984B2D49196);
ISpace["UI_History"].ShowDialog=true;;
base.WriteDebugInfo(@"ISpace[""UI_History""].ShowDialog=true;;");
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
if(ISpace["WF_FlowType"].Value=="APPROVE")
{
base.WriteDebugInfo(@"if(ISpace[""WF_FlowType""].Value==""APPROVE"")");
if(ISpace["WMF_MoveTo"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""WMF_MoveTo""].Value=="""")");
ISpace["Message"].Value=@"Error:Please Select Next Action";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Error:Please Select Next Action"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
}
if(ISpace["WF_FlowType"].Value=="RETURN" || ISpace["WF_FlowType"].Value=="REJECT")
{
base.WriteDebugInfo(@"if(ISpace[""WF_FlowType""].Value==""RETURN"" || ISpace[""WF_FlowType""].Value==""REJECT"")");
if(ISpace["WMF_MoveTo"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""WMF_MoveTo""].Value=="""")");
ISpace["Message"].Value=@"Error:Please Select Next Action";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Error:Please Select Next Action"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if(ISpace["Comments"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""Comments""].Value=="""")");
ISpace["Message"].Value=@"Error: Please Enter Comments";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Error: Please Enter Comments"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
}
ISpace["Message"].Value=@"Success: Submitted Successfully";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Success: Submitted Successfully"";");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC [UpdateTravelRequestStatus] '@@gv_InstanceId','@@gv_UserId','#WF_FlowType'");

var querySourcefbb131bf5cbf0eb86f44bf481055f5b7 =GetQueryExpressionDataSource("fbb131bf-5cbf-0eb8-6f44-bf481055f5b7");
Dictionary<short,object> resultfbb131bf5cbf0eb86f44bf481055f5b7=iSpace.ExecuteQuery(querySourcefbb131bf5cbf0eb86f44bf481055f5b7,@"EXEC [UpdateTravelRequestStatus] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_userid"].Value + @"','" + ISpace["WF_FlowType"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourcefbb131bf5cbf0eb86f44bf481055f5b7 =GetQueryExpressionDataSource(""fbb131bf-5cbf-0eb8-6f44-bf481055f5b7"");Dictionary<short,object> resultfbb131bf5cbf0eb86f44bf481055f5b7=iSpace.ExecuteQuery(querySourcefbb131bf5cbf0eb86f44bf481055f5b7,@""EXEC [UpdateTravelRequestStatus] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_userid""].Value + @""','"" + ISpace[""WF_FlowType""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultfbb131bf5cbf0eb86f44bf481055f5b7!=null) && (resultfbb131bf5cbf0eb86f44bf481055f5b7.Count!=0))
{
if(resultfbb131bf5cbf0eb86f44bf481055f5b7.ContainsKey(0))
ISpace["MF_ErrId"].Value = resultfbb131bf5cbf0eb86f44bf481055f5b7[0];
if(resultfbb131bf5cbf0eb86f44bf481055f5b7.ContainsKey(1))
ISpace["MF_ErrMsg"].Value = resultfbb131bf5cbf0eb86f44bf481055f5b7[1];
}
else{
ISpace["MF_ErrId"].Value = null;ISpace["MF_ErrMsg"].Value = null;
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
private void SubscribeElementEvents_wmf_moveto (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"WMF_MoveTo-OnChange");
if(ISpace["WMF_MoveTo"].Value=="APPROVE")
{
base.WriteDebugInfo(@"if(ISpace[""WMF_MoveTo""].Value==""APPROVE"")");
ISpace["WF_FlowType"].Value="APPROVE";
base.WriteDebugInfo(@"ISpace[""WF_FlowType""].Value=""APPROVE"";");
ISpace["Comments"].Man=false;
base.WriteDebugInfo(@"ISpace[""Comments""].Man=false;");
}
if(ISpace["WMF_MoveTo"].Value=="RETURN")
{
base.WriteDebugInfo(@"if(ISpace[""WMF_MoveTo""].Value==""RETURN"")");
ISpace["WF_FlowType"].Value="RETURN";
base.WriteDebugInfo(@"ISpace[""WF_FlowType""].Value=""RETURN"";");
ISpace["Comments"].Man=true;
base.WriteDebugInfo(@"ISpace[""Comments""].Man=true;");
}
if(ISpace["WMF_MoveTo"].Value=="REJECT")
{
base.WriteDebugInfo(@"if(ISpace[""WMF_MoveTo""].Value==""REJECT"")");
ISpace["WF_FlowType"].Value="REJECT";
base.WriteDebugInfo(@"ISpace[""WF_FlowType""].Value=""REJECT"";");
ISpace["Comments"].Man=true;
base.WriteDebugInfo(@"ISpace[""Comments""].Man=true;");
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_cancelform (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"CancelForm-OnClick");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC [UnlockProcessInstance] '@@gv_InstanceId','@@gv_UserMapId'");

var querySource4c20e7236b4e1baa1f33b09cc235bbe6 =GetQueryExpressionDataSource("4c20e723-6b4e-1baa-1f33-b09cc235bbe6");
Dictionary<short,object> result4c20e7236b4e1baa1f33b09cc235bbe6=iSpace.ExecuteQuery(querySource4c20e7236b4e1baa1f33b09cc235bbe6,@"EXEC [UnlockProcessInstance] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_usermapid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource4c20e7236b4e1baa1f33b09cc235bbe6 =GetQueryExpressionDataSource(""4c20e723-6b4e-1baa-1f33-b09cc235bbe6"");Dictionary<short,object> result4c20e7236b4e1baa1f33b09cc235bbe6=iSpace.ExecuteQuery(querySource4c20e7236b4e1baa1f33b09cc235bbe6,@""EXEC [UnlockProcessInstance] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_usermapid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result4c20e7236b4e1baa1f33b09cc235bbe6!=null) && (result4c20e7236b4e1baa1f33b09cc235bbe6.Count!=0))
{
if(result4c20e7236b4e1baa1f33b09cc235bbe6.ContainsKey(0))
ISpace["MF_ErrId"].Value = result4c20e7236b4e1baa1f33b09cc235bbe6[0];
}
else{
ISpace["MF_ErrId"].Value = null;
}
}
ISpace["Message"].Value=@"Success: Cancelled Successfully";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Success: Cancelled Successfully"";");

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
		if(elementName.ToLower().Equals("wmf_moveto"))
    {
    			SubscribeElementEvents_wmf_moveto(ref dfsParam);
    }
}
	if(methodName.ToLower().Equals("onclick"))
{
		if(elementName.ToLower().Equals("wmf_history"))
{
			SubscribeElementEvents_wmf_history(ref dfsParam);
}
		if(elementName.ToLower().Equals("submitform"))
{
			SubscribeElementEvents_submitform(ref dfsParam);
}
		if(elementName.ToLower().Equals("cancelform"))
{
			SubscribeElementEvents_cancelform(ref dfsParam);
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
public class ISpaceC1E33E745080471B9D135EC3EC7C54E8 : VirtualForm
{
IISpace iSpace = new ISpace();
AcDataISpaceC1E33E745080471B9D135EC3EC7C54E8 acdataIspaceC1E33E745080471B9D135EC3EC7C54E8=new AcDataISpaceC1E33E745080471B9D135EC3EC7C54E8();
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
if(ISpace["FormVersionId"].Value=="48D9155C-42D2-4414-AF53-3D00D9908DD4")
{
ISpace["UI_PFHideRow"].Visible="false";
}if(ISpace["FormVersionId"].Value=="48D9155C-42D2-4414-AF53-3D00D9908DD4")
{
ISpace["UI_ApprovalHideRow"].Visible="false";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""48D9155C-42D2-4414-AF53-3D00D9908DD4"")
{
ISpace[""UI_PFHideRow""].Visible=""false"";
}if(ISpace[""FormVersionId""].Value==""48D9155C-42D2-4414-AF53-3D00D9908DD4"")
{
ISpace[""UI_ApprovalHideRow""].Visible=""false"";
}");
ISpace["Comments"].Value="";
base.WriteDebugInfo(@"ISpace[""Comments""].Value="""";");
ISpace["WMF_MoveTo"].Value="";
base.WriteDebugInfo(@"ISpace[""WMF_MoveTo""].Value="""";");
}
if(ISpace["WF_FlowType"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""WF_FlowType""].Value=="""")");
ISpace["WMF_IsInFlow"].Value=0;
base.WriteDebugInfo(@"ISpace[""WMF_IsInFlow""].Value=0;");
base.WriteDebugInfo(@"EXEC [GetInstanceInFlow] '@@gv_InstanceId'");

var querySource76804AA1305E4E7F895EB90B051455D5 =GetQueryExpressionDataSource("76804AA1-305E-4E7F-895E-B90B051455D5");
Dictionary<short,object> result76804AA1305E4E7F895EB90B051455D5=iSpace.ExecuteQuery(querySource76804AA1305E4E7F895EB90B051455D5,@"EXEC [GetInstanceInFlow] '" + ISpace["gv_instanceid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource76804AA1305E4E7F895EB90B051455D5 =GetQueryExpressionDataSource(""76804AA1-305E-4E7F-895E-B90B051455D5"");Dictionary<short,object> result76804AA1305E4E7F895EB90B051455D5=iSpace.ExecuteQuery(querySource76804AA1305E4E7F895EB90B051455D5,@""EXEC [GetInstanceInFlow] '"" + ISpace[""gv_instanceid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result76804AA1305E4E7F895EB90B051455D5!=null) && (result76804AA1305E4E7F895EB90B051455D5.Count!=0))
{
if(result76804AA1305E4E7F895EB90B051455D5.ContainsKey(0))
ISpace["WMF_IsInFlow"].Value = result76804AA1305E4E7F895EB90B051455D5[0];
}
else{
ISpace["WMF_IsInFlow"].Value = null;
}
if(ISpace["WMF_IsInFlow"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""WMF_IsInFlow""].Value==1)");
ISpace["WF_FlowType"].Value="APPROVE";
base.WriteDebugInfo(@"ISpace[""WF_FlowType""].Value=""APPROVE"";");
ISpace["WMF_History"].Visible="true";ISpace["WMF_MoveTo"].Visible="true";
base.WriteDebugInfo(@"ISpace[""WMF_History""].Visible=""true"";ISpace[""WMF_MoveTo""].Visible=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["WMF_History"].Visible="false";ISpace["WMF_MoveTo"].Visible="false";
base.WriteDebugInfo(@"ISpace[""WMF_History""].Visible=""false"";ISpace[""WMF_MoveTo""].Visible=""false"";");
}
}
ISpace["WMF_MoveTo"].Man=true;
base.WriteDebugInfo(@"ISpace[""WMF_MoveTo""].Man=true;");

var querySource698205C52C1A42F39D81823D3215AB11 =GetQueryExpressionDataSource("698205C5-2C1A-42F3-9D81-823D3215AB11");

DataTable result698205C52C1A42F39D81823D3215AB11=iSpace.SetGridDataSource(querySource698205C52C1A42F39D81823D3215AB11, _objectFactory.GetGridRPP("WMG_CommentsHistory"),@"EXEC [GetInstanceFlowDetais] '" + ISpace["gv_instanceid"].Value + @"'");

iSpace.InsertGridBindDetails("WMG_CommentsHistory","11",querySource698205C52C1A42F39D81823D3215AB11,"EXEC [GetInstanceFlowDetais] '" + ISpace["gv_instanceid"].Value + @"'",_objectFactory.GetGridRPP("WMG_CommentsHistory"));

base.WriteDebugInfo(@"var querySource698205C52C1A42F39D81823D3215AB11 =GetQueryExpressionDataSource(""698205C5-2C1A-42F3-9D81-823D3215AB11"");DataTable result698205C52C1A42F39D81823D3215AB11=iSpace.SetGridDataSource(querySource698205C52C1A42F39D81823D3215AB11, _objectFactory.GetGridRPP(""WMG_CommentsHistory""),@""EXEC [GetInstanceFlowDetais] '"" + ISpace[""gv_instanceid""].Value + @""'"");iSpace.InsertGridBindDetails(""WMG_CommentsHistory"",""11"",querySource698205C52C1A42F39D81823D3215AB11,""EXEC [GetInstanceFlowDetais] '"" + ISpace[""gv_instanceid""].Value + @""'"",_objectFactory.GetGridRPP(""WMG_CommentsHistory""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result794A7328890E42A3B11A5984B2D49196=acdataIspaceC1E33E745080471B9D135EC3EC7C54E8.GetQueryExpressionBindings("794A7328-890E-42A3-B11A-5984B2D49196");
iSpace.SetGridData(result698205C52C1A42F39D81823D3215AB11,result794A7328890E42A3B11A5984B2D49196,"WMG_CommentsHistory",ref ISpace);
iSpace.UpdateGridBindDetails("WMG_CommentsHistory",result794A7328890E42A3B11A5984B2D49196);
ISpace["UI_History"].ShowDialog=true;;
base.WriteDebugInfo(@"ISpace[""UI_History""].ShowDialog=true;;");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_wmf_history (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"WMF_History-OnClick");

var querySource698205C52C1A42F39D81823D3215AB11 =GetQueryExpressionDataSource("698205C5-2C1A-42F3-9D81-823D3215AB11");

DataTable result698205C52C1A42F39D81823D3215AB11=iSpace.SetGridDataSource(querySource698205C52C1A42F39D81823D3215AB11, _objectFactory.GetGridRPP("WMG_CommentsHistory"),@"EXEC [GetInstanceFlowDetais] '" + ISpace["gv_instanceid"].Value + @"'");

iSpace.InsertGridBindDetails("WMG_CommentsHistory","11",querySource698205C52C1A42F39D81823D3215AB11,"EXEC [GetInstanceFlowDetais] '" + ISpace["gv_instanceid"].Value + @"'",_objectFactory.GetGridRPP("WMG_CommentsHistory"));

base.WriteDebugInfo(@"var querySource698205C52C1A42F39D81823D3215AB11 =GetQueryExpressionDataSource(""698205C5-2C1A-42F3-9D81-823D3215AB11"");DataTable result698205C52C1A42F39D81823D3215AB11=iSpace.SetGridDataSource(querySource698205C52C1A42F39D81823D3215AB11, _objectFactory.GetGridRPP(""WMG_CommentsHistory""),@""EXEC [GetInstanceFlowDetais] '"" + ISpace[""gv_instanceid""].Value + @""'"");iSpace.InsertGridBindDetails(""WMG_CommentsHistory"",""11"",querySource698205C52C1A42F39D81823D3215AB11,""EXEC [GetInstanceFlowDetais] '"" + ISpace[""gv_instanceid""].Value + @""'"",_objectFactory.GetGridRPP(""WMG_CommentsHistory""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result794A7328890E42A3B11A5984B2D49196=acdataIspaceC1E33E745080471B9D135EC3EC7C54E8.GetQueryExpressionBindings("794A7328-890E-42A3-B11A-5984B2D49196");
iSpace.SetGridData(result698205C52C1A42F39D81823D3215AB11,result794A7328890E42A3B11A5984B2D49196,"WMG_CommentsHistory",ref ISpace);
iSpace.UpdateGridBindDetails("WMG_CommentsHistory",result794A7328890E42A3B11A5984B2D49196);
ISpace["UI_History"].ShowDialog=true;;
base.WriteDebugInfo(@"ISpace[""UI_History""].ShowDialog=true;;");
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
if(ISpace["WF_FlowType"].Value=="APPROVE")
{
base.WriteDebugInfo(@"if(ISpace[""WF_FlowType""].Value==""APPROVE"")");
if(ISpace["WMF_MoveTo"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""WMF_MoveTo""].Value=="""")");
ISpace["Message"].Value=@"Error:Please Select Next Action";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Error:Please Select Next Action"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
}
if(ISpace["WF_FlowType"].Value=="RETURN" || ISpace["WF_FlowType"].Value=="REJECT")
{
base.WriteDebugInfo(@"if(ISpace[""WF_FlowType""].Value==""RETURN"" || ISpace[""WF_FlowType""].Value==""REJECT"")");
if(ISpace["WMF_MoveTo"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""WMF_MoveTo""].Value=="""")");
ISpace["Message"].Value=@"Error:Please Select Next Action";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Error:Please Select Next Action"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if(ISpace["Comments"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""Comments""].Value=="""")");
ISpace["Message"].Value=@"Error: Please Enter Comments";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Error: Please Enter Comments"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
}
ISpace["Message"].Value=@"Success: Submitted Successfully";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Success: Submitted Successfully"";");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC [UpdateTravelRequestStatus] '@@gv_InstanceId','@@gv_UserId','#WF_FlowType'");

var querySourcefbb131bf5cbf0eb86f44bf481055f5b7 =GetQueryExpressionDataSource("fbb131bf-5cbf-0eb8-6f44-bf481055f5b7");
Dictionary<short,object> resultfbb131bf5cbf0eb86f44bf481055f5b7=iSpace.ExecuteQuery(querySourcefbb131bf5cbf0eb86f44bf481055f5b7,@"EXEC [UpdateTravelRequestStatus] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_userid"].Value + @"','" + ISpace["WF_FlowType"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourcefbb131bf5cbf0eb86f44bf481055f5b7 =GetQueryExpressionDataSource(""fbb131bf-5cbf-0eb8-6f44-bf481055f5b7"");Dictionary<short,object> resultfbb131bf5cbf0eb86f44bf481055f5b7=iSpace.ExecuteQuery(querySourcefbb131bf5cbf0eb86f44bf481055f5b7,@""EXEC [UpdateTravelRequestStatus] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_userid""].Value + @""','"" + ISpace[""WF_FlowType""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultfbb131bf5cbf0eb86f44bf481055f5b7!=null) && (resultfbb131bf5cbf0eb86f44bf481055f5b7.Count!=0))
{
if(resultfbb131bf5cbf0eb86f44bf481055f5b7.ContainsKey(0))
ISpace["MF_ErrId"].Value = resultfbb131bf5cbf0eb86f44bf481055f5b7[0];
if(resultfbb131bf5cbf0eb86f44bf481055f5b7.ContainsKey(1))
ISpace["MF_ErrMsg"].Value = resultfbb131bf5cbf0eb86f44bf481055f5b7[1];
}
else{
ISpace["MF_ErrId"].Value = null;ISpace["MF_ErrMsg"].Value = null;
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
private void SubscribeElementEvents_wmf_moveto (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"WMF_MoveTo-OnChange");
if(ISpace["WMF_MoveTo"].Value=="APPROVE")
{
base.WriteDebugInfo(@"if(ISpace[""WMF_MoveTo""].Value==""APPROVE"")");
ISpace["WF_FlowType"].Value="APPROVE";
base.WriteDebugInfo(@"ISpace[""WF_FlowType""].Value=""APPROVE"";");
ISpace["Comments"].Man=false;
base.WriteDebugInfo(@"ISpace[""Comments""].Man=false;");
}
if(ISpace["WMF_MoveTo"].Value=="RETURN")
{
base.WriteDebugInfo(@"if(ISpace[""WMF_MoveTo""].Value==""RETURN"")");
ISpace["WF_FlowType"].Value="RETURN";
base.WriteDebugInfo(@"ISpace[""WF_FlowType""].Value=""RETURN"";");
ISpace["Comments"].Man=true;
base.WriteDebugInfo(@"ISpace[""Comments""].Man=true;");
}
if(ISpace["WMF_MoveTo"].Value=="REJECT")
{
base.WriteDebugInfo(@"if(ISpace[""WMF_MoveTo""].Value==""REJECT"")");
ISpace["WF_FlowType"].Value="REJECT";
base.WriteDebugInfo(@"ISpace[""WF_FlowType""].Value=""REJECT"";");
ISpace["Comments"].Man=true;
base.WriteDebugInfo(@"ISpace[""Comments""].Man=true;");
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_cancelform (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"CancelForm-OnClick");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC [UnlockProcessInstance] '@@gv_InstanceId','@@gv_UserMapId'");

var querySource4c20e7236b4e1baa1f33b09cc235bbe6 =GetQueryExpressionDataSource("4c20e723-6b4e-1baa-1f33-b09cc235bbe6");
Dictionary<short,object> result4c20e7236b4e1baa1f33b09cc235bbe6=iSpace.ExecuteQuery(querySource4c20e7236b4e1baa1f33b09cc235bbe6,@"EXEC [UnlockProcessInstance] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_usermapid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource4c20e7236b4e1baa1f33b09cc235bbe6 =GetQueryExpressionDataSource(""4c20e723-6b4e-1baa-1f33-b09cc235bbe6"");Dictionary<short,object> result4c20e7236b4e1baa1f33b09cc235bbe6=iSpace.ExecuteQuery(querySource4c20e7236b4e1baa1f33b09cc235bbe6,@""EXEC [UnlockProcessInstance] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_usermapid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result4c20e7236b4e1baa1f33b09cc235bbe6!=null) && (result4c20e7236b4e1baa1f33b09cc235bbe6.Count!=0))
{
if(result4c20e7236b4e1baa1f33b09cc235bbe6.ContainsKey(0))
ISpace["MF_ErrId"].Value = result4c20e7236b4e1baa1f33b09cc235bbe6[0];
}
else{
ISpace["MF_ErrId"].Value = null;
}
}
ISpace["Message"].Value=@"Success: Cancelled Successfully";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Success: Cancelled Successfully"";");

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
		if(elementName.ToLower().Equals("wmf_moveto"))
    {
    			SubscribeElementEvents_wmf_moveto(ref dfsParam);
    }
}
	if(methodName.ToLower().Equals("onclick"))
{
		if(elementName.ToLower().Equals("wmf_history"))
{
			SubscribeElementEvents_wmf_history(ref dfsParam);
}
		if(elementName.ToLower().Equals("submitform"))
{
			SubscribeElementEvents_submitform(ref dfsParam);
}
		if(elementName.ToLower().Equals("cancelform"))
{
			SubscribeElementEvents_cancelform(ref dfsParam);
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
public class ISpace82118DD85B264EE28171D616101898A6 : VirtualForm
{
IISpace iSpace = new ISpace();
AcDataISpace82118DD85B264EE28171D616101898A6 acdataIspace82118DD85B264EE28171D616101898A6=new AcDataISpace82118DD85B264EE28171D616101898A6();
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
if(ISpace["FormVersionId"].Value=="48D9155C-42D2-4414-AF53-3D00D9908DD4")
{
ISpace["UI_PFHideRow"].Visible="false";
}if(ISpace["FormVersionId"].Value=="48D9155C-42D2-4414-AF53-3D00D9908DD4")
{
ISpace["UI_ApprovalHideRow"].Visible="false";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""48D9155C-42D2-4414-AF53-3D00D9908DD4"")
{
ISpace[""UI_PFHideRow""].Visible=""false"";
}if(ISpace[""FormVersionId""].Value==""48D9155C-42D2-4414-AF53-3D00D9908DD4"")
{
ISpace[""UI_ApprovalHideRow""].Visible=""false"";
}");
ISpace["Comments"].Value="";
base.WriteDebugInfo(@"ISpace[""Comments""].Value="""";");
ISpace["WMF_MoveTo"].Value="";
base.WriteDebugInfo(@"ISpace[""WMF_MoveTo""].Value="""";");
}
if(ISpace["WF_FlowType"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""WF_FlowType""].Value=="""")");
ISpace["WMF_IsInFlow"].Value=0;
base.WriteDebugInfo(@"ISpace[""WMF_IsInFlow""].Value=0;");
base.WriteDebugInfo(@"EXEC [GetInstanceInFlow] '@@gv_InstanceId'");

var querySource76804AA1305E4E7F895EB90B051455D5 =GetQueryExpressionDataSource("76804AA1-305E-4E7F-895E-B90B051455D5");
Dictionary<short,object> result76804AA1305E4E7F895EB90B051455D5=iSpace.ExecuteQuery(querySource76804AA1305E4E7F895EB90B051455D5,@"EXEC [GetInstanceInFlow] '" + ISpace["gv_instanceid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource76804AA1305E4E7F895EB90B051455D5 =GetQueryExpressionDataSource(""76804AA1-305E-4E7F-895E-B90B051455D5"");Dictionary<short,object> result76804AA1305E4E7F895EB90B051455D5=iSpace.ExecuteQuery(querySource76804AA1305E4E7F895EB90B051455D5,@""EXEC [GetInstanceInFlow] '"" + ISpace[""gv_instanceid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result76804AA1305E4E7F895EB90B051455D5!=null) && (result76804AA1305E4E7F895EB90B051455D5.Count!=0))
{
if(result76804AA1305E4E7F895EB90B051455D5.ContainsKey(0))
ISpace["WMF_IsInFlow"].Value = result76804AA1305E4E7F895EB90B051455D5[0];
}
else{
ISpace["WMF_IsInFlow"].Value = null;
}
if(ISpace["WMF_IsInFlow"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""WMF_IsInFlow""].Value==1)");
ISpace["WF_FlowType"].Value="APPROVE";
base.WriteDebugInfo(@"ISpace[""WF_FlowType""].Value=""APPROVE"";");
ISpace["WMF_History"].Visible="true";ISpace["WMF_MoveTo"].Visible="true";
base.WriteDebugInfo(@"ISpace[""WMF_History""].Visible=""true"";ISpace[""WMF_MoveTo""].Visible=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["WMF_History"].Visible="false";ISpace["WMF_MoveTo"].Visible="false";
base.WriteDebugInfo(@"ISpace[""WMF_History""].Visible=""false"";ISpace[""WMF_MoveTo""].Visible=""false"";");
}
}
ISpace["WMF_MoveTo"].Man=true;
base.WriteDebugInfo(@"ISpace[""WMF_MoveTo""].Man=true;");

var querySource698205C52C1A42F39D81823D3215AB11 =GetQueryExpressionDataSource("698205C5-2C1A-42F3-9D81-823D3215AB11");

DataTable result698205C52C1A42F39D81823D3215AB11=iSpace.SetGridDataSource(querySource698205C52C1A42F39D81823D3215AB11, _objectFactory.GetGridRPP("WMG_CommentsHistory"),@"EXEC [GetInstanceFlowDetais] '" + ISpace["gv_instanceid"].Value + @"'");

iSpace.InsertGridBindDetails("WMG_CommentsHistory","11",querySource698205C52C1A42F39D81823D3215AB11,"EXEC [GetInstanceFlowDetais] '" + ISpace["gv_instanceid"].Value + @"'",_objectFactory.GetGridRPP("WMG_CommentsHistory"));

base.WriteDebugInfo(@"var querySource698205C52C1A42F39D81823D3215AB11 =GetQueryExpressionDataSource(""698205C5-2C1A-42F3-9D81-823D3215AB11"");DataTable result698205C52C1A42F39D81823D3215AB11=iSpace.SetGridDataSource(querySource698205C52C1A42F39D81823D3215AB11, _objectFactory.GetGridRPP(""WMG_CommentsHistory""),@""EXEC [GetInstanceFlowDetais] '"" + ISpace[""gv_instanceid""].Value + @""'"");iSpace.InsertGridBindDetails(""WMG_CommentsHistory"",""11"",querySource698205C52C1A42F39D81823D3215AB11,""EXEC [GetInstanceFlowDetais] '"" + ISpace[""gv_instanceid""].Value + @""'"",_objectFactory.GetGridRPP(""WMG_CommentsHistory""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result794A7328890E42A3B11A5984B2D49196=acdataIspace82118DD85B264EE28171D616101898A6.GetQueryExpressionBindings("794A7328-890E-42A3-B11A-5984B2D49196");
iSpace.SetGridData(result698205C52C1A42F39D81823D3215AB11,result794A7328890E42A3B11A5984B2D49196,"WMG_CommentsHistory",ref ISpace);
iSpace.UpdateGridBindDetails("WMG_CommentsHistory",result794A7328890E42A3B11A5984B2D49196);
ISpace["UI_History"].ShowDialog=true;;
base.WriteDebugInfo(@"ISpace[""UI_History""].ShowDialog=true;;");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_wmf_history (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"WMF_History-OnClick");

var querySource698205C52C1A42F39D81823D3215AB11 =GetQueryExpressionDataSource("698205C5-2C1A-42F3-9D81-823D3215AB11");

DataTable result698205C52C1A42F39D81823D3215AB11=iSpace.SetGridDataSource(querySource698205C52C1A42F39D81823D3215AB11, _objectFactory.GetGridRPP("WMG_CommentsHistory"),@"EXEC [GetInstanceFlowDetais] '" + ISpace["gv_instanceid"].Value + @"'");

iSpace.InsertGridBindDetails("WMG_CommentsHistory","11",querySource698205C52C1A42F39D81823D3215AB11,"EXEC [GetInstanceFlowDetais] '" + ISpace["gv_instanceid"].Value + @"'",_objectFactory.GetGridRPP("WMG_CommentsHistory"));

base.WriteDebugInfo(@"var querySource698205C52C1A42F39D81823D3215AB11 =GetQueryExpressionDataSource(""698205C5-2C1A-42F3-9D81-823D3215AB11"");DataTable result698205C52C1A42F39D81823D3215AB11=iSpace.SetGridDataSource(querySource698205C52C1A42F39D81823D3215AB11, _objectFactory.GetGridRPP(""WMG_CommentsHistory""),@""EXEC [GetInstanceFlowDetais] '"" + ISpace[""gv_instanceid""].Value + @""'"");iSpace.InsertGridBindDetails(""WMG_CommentsHistory"",""11"",querySource698205C52C1A42F39D81823D3215AB11,""EXEC [GetInstanceFlowDetais] '"" + ISpace[""gv_instanceid""].Value + @""'"",_objectFactory.GetGridRPP(""WMG_CommentsHistory""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result794A7328890E42A3B11A5984B2D49196=acdataIspace82118DD85B264EE28171D616101898A6.GetQueryExpressionBindings("794A7328-890E-42A3-B11A-5984B2D49196");
iSpace.SetGridData(result698205C52C1A42F39D81823D3215AB11,result794A7328890E42A3B11A5984B2D49196,"WMG_CommentsHistory",ref ISpace);
iSpace.UpdateGridBindDetails("WMG_CommentsHistory",result794A7328890E42A3B11A5984B2D49196);
ISpace["UI_History"].ShowDialog=true;;
base.WriteDebugInfo(@"ISpace[""UI_History""].ShowDialog=true;;");
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
if(ISpace["WF_FlowType"].Value=="APPROVE")
{
base.WriteDebugInfo(@"if(ISpace[""WF_FlowType""].Value==""APPROVE"")");
if(ISpace["WMF_MoveTo"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""WMF_MoveTo""].Value=="""")");
ISpace["Message"].Value=@"Error:Please Select Next Action";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Error:Please Select Next Action"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
}
if(ISpace["WF_FlowType"].Value=="RETURN" || ISpace["WF_FlowType"].Value=="REJECT")
{
base.WriteDebugInfo(@"if(ISpace[""WF_FlowType""].Value==""RETURN"" || ISpace[""WF_FlowType""].Value==""REJECT"")");
if(ISpace["WMF_MoveTo"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""WMF_MoveTo""].Value=="""")");
ISpace["Message"].Value=@"Error:Please Select Next Action";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Error:Please Select Next Action"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if(ISpace["Comments"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""Comments""].Value=="""")");
ISpace["Message"].Value=@"Error: Please Enter Comments";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Error: Please Enter Comments"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
}
ISpace["Message"].Value=@"Success: Submitted Successfully";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Success: Submitted Successfully"";");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC [UpdateTravelRequestStatus] '@@gv_InstanceId','@@gv_UserId','#WF_FlowType'");

var querySourcefbb131bf5cbf0eb86f44bf481055f5b7 =GetQueryExpressionDataSource("fbb131bf-5cbf-0eb8-6f44-bf481055f5b7");
Dictionary<short,object> resultfbb131bf5cbf0eb86f44bf481055f5b7=iSpace.ExecuteQuery(querySourcefbb131bf5cbf0eb86f44bf481055f5b7,@"EXEC [UpdateTravelRequestStatus] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_userid"].Value + @"','" + ISpace["WF_FlowType"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourcefbb131bf5cbf0eb86f44bf481055f5b7 =GetQueryExpressionDataSource(""fbb131bf-5cbf-0eb8-6f44-bf481055f5b7"");Dictionary<short,object> resultfbb131bf5cbf0eb86f44bf481055f5b7=iSpace.ExecuteQuery(querySourcefbb131bf5cbf0eb86f44bf481055f5b7,@""EXEC [UpdateTravelRequestStatus] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_userid""].Value + @""','"" + ISpace[""WF_FlowType""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultfbb131bf5cbf0eb86f44bf481055f5b7!=null) && (resultfbb131bf5cbf0eb86f44bf481055f5b7.Count!=0))
{
if(resultfbb131bf5cbf0eb86f44bf481055f5b7.ContainsKey(0))
ISpace["MF_ErrId"].Value = resultfbb131bf5cbf0eb86f44bf481055f5b7[0];
if(resultfbb131bf5cbf0eb86f44bf481055f5b7.ContainsKey(1))
ISpace["MF_ErrMsg"].Value = resultfbb131bf5cbf0eb86f44bf481055f5b7[1];
}
else{
ISpace["MF_ErrId"].Value = null;ISpace["MF_ErrMsg"].Value = null;
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
private void SubscribeElementEvents_wmf_moveto (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"WMF_MoveTo-OnChange");
if(ISpace["WMF_MoveTo"].Value=="APPROVE")
{
base.WriteDebugInfo(@"if(ISpace[""WMF_MoveTo""].Value==""APPROVE"")");
ISpace["WF_FlowType"].Value="APPROVE";
base.WriteDebugInfo(@"ISpace[""WF_FlowType""].Value=""APPROVE"";");
ISpace["Comments"].Man=false;
base.WriteDebugInfo(@"ISpace[""Comments""].Man=false;");
}
if(ISpace["WMF_MoveTo"].Value=="RETURN")
{
base.WriteDebugInfo(@"if(ISpace[""WMF_MoveTo""].Value==""RETURN"")");
ISpace["WF_FlowType"].Value="RETURN";
base.WriteDebugInfo(@"ISpace[""WF_FlowType""].Value=""RETURN"";");
ISpace["Comments"].Man=true;
base.WriteDebugInfo(@"ISpace[""Comments""].Man=true;");
}
if(ISpace["WMF_MoveTo"].Value=="REJECT")
{
base.WriteDebugInfo(@"if(ISpace[""WMF_MoveTo""].Value==""REJECT"")");
ISpace["WF_FlowType"].Value="REJECT";
base.WriteDebugInfo(@"ISpace[""WF_FlowType""].Value=""REJECT"";");
ISpace["Comments"].Man=true;
base.WriteDebugInfo(@"ISpace[""Comments""].Man=true;");
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_cancelform (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"CancelForm-OnClick");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC [UnlockProcessInstance] '@@gv_InstanceId','@@gv_UserMapId'");

var querySource4c20e7236b4e1baa1f33b09cc235bbe6 =GetQueryExpressionDataSource("4c20e723-6b4e-1baa-1f33-b09cc235bbe6");
Dictionary<short,object> result4c20e7236b4e1baa1f33b09cc235bbe6=iSpace.ExecuteQuery(querySource4c20e7236b4e1baa1f33b09cc235bbe6,@"EXEC [UnlockProcessInstance] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_usermapid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource4c20e7236b4e1baa1f33b09cc235bbe6 =GetQueryExpressionDataSource(""4c20e723-6b4e-1baa-1f33-b09cc235bbe6"");Dictionary<short,object> result4c20e7236b4e1baa1f33b09cc235bbe6=iSpace.ExecuteQuery(querySource4c20e7236b4e1baa1f33b09cc235bbe6,@""EXEC [UnlockProcessInstance] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_usermapid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result4c20e7236b4e1baa1f33b09cc235bbe6!=null) && (result4c20e7236b4e1baa1f33b09cc235bbe6.Count!=0))
{
if(result4c20e7236b4e1baa1f33b09cc235bbe6.ContainsKey(0))
ISpace["MF_ErrId"].Value = result4c20e7236b4e1baa1f33b09cc235bbe6[0];
}
else{
ISpace["MF_ErrId"].Value = null;
}
}
ISpace["Message"].Value=@"Success: Cancelled Successfully";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Success: Cancelled Successfully"";");

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
		if(elementName.ToLower().Equals("wmf_moveto"))
    {
    			SubscribeElementEvents_wmf_moveto(ref dfsParam);
    }
}
	if(methodName.ToLower().Equals("onclick"))
{
		if(elementName.ToLower().Equals("wmf_history"))
{
			SubscribeElementEvents_wmf_history(ref dfsParam);
}
		if(elementName.ToLower().Equals("submitform"))
{
			SubscribeElementEvents_submitform(ref dfsParam);
}
		if(elementName.ToLower().Equals("cancelform"))
{
			SubscribeElementEvents_cancelform(ref dfsParam);
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
public class ISpace98d8749ef1dc685b350935353f8b3c3d : VirtualForm
{
IISpace iSpace = new ISpace();
AcDataISpace98d8749ef1dc685b350935353f8b3c3d acdataIspace98d8749ef1dc685b350935353f8b3c3d=new AcDataISpace98d8749ef1dc685b350935353f8b3c3d();
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
if(ISpace["FormVersionId"].Value=="48D9155C-42D2-4414-AF53-3D00D9908DD4")
{
ISpace["UI_PFHideRow"].Visible="false";
}if(ISpace["FormVersionId"].Value=="48D9155C-42D2-4414-AF53-3D00D9908DD4")
{
ISpace["UI_ApprovalHideRow"].Visible="false";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""48D9155C-42D2-4414-AF53-3D00D9908DD4"")
{
ISpace[""UI_PFHideRow""].Visible=""false"";
}if(ISpace[""FormVersionId""].Value==""48D9155C-42D2-4414-AF53-3D00D9908DD4"")
{
ISpace[""UI_ApprovalHideRow""].Visible=""false"";
}");
ISpace["Comments"].Value="";
base.WriteDebugInfo(@"ISpace[""Comments""].Value="""";");
ISpace["WMF_MoveTo"].Value="";
base.WriteDebugInfo(@"ISpace[""WMF_MoveTo""].Value="""";");
}
if(ISpace["WF_FlowType"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""WF_FlowType""].Value=="""")");
ISpace["WMF_IsInFlow"].Value=0;
base.WriteDebugInfo(@"ISpace[""WMF_IsInFlow""].Value=0;");
base.WriteDebugInfo(@"EXEC [GetInstanceInFlow] '@@gv_InstanceId'");

var querySource76804AA1305E4E7F895EB90B051455D5 =GetQueryExpressionDataSource("76804AA1-305E-4E7F-895E-B90B051455D5");
Dictionary<short,object> result76804AA1305E4E7F895EB90B051455D5=iSpace.ExecuteQuery(querySource76804AA1305E4E7F895EB90B051455D5,@"EXEC [GetInstanceInFlow] '" + ISpace["gv_instanceid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource76804AA1305E4E7F895EB90B051455D5 =GetQueryExpressionDataSource(""76804AA1-305E-4E7F-895E-B90B051455D5"");Dictionary<short,object> result76804AA1305E4E7F895EB90B051455D5=iSpace.ExecuteQuery(querySource76804AA1305E4E7F895EB90B051455D5,@""EXEC [GetInstanceInFlow] '"" + ISpace[""gv_instanceid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result76804AA1305E4E7F895EB90B051455D5!=null) && (result76804AA1305E4E7F895EB90B051455D5.Count!=0))
{
if(result76804AA1305E4E7F895EB90B051455D5.ContainsKey(0))
ISpace["WMF_IsInFlow"].Value = result76804AA1305E4E7F895EB90B051455D5[0];
}
else{
ISpace["WMF_IsInFlow"].Value = null;
}
if(ISpace["WMF_IsInFlow"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""WMF_IsInFlow""].Value==1)");
ISpace["WF_FlowType"].Value="APPROVE";
base.WriteDebugInfo(@"ISpace[""WF_FlowType""].Value=""APPROVE"";");
ISpace["WMF_History"].Visible="true";ISpace["WMF_MoveTo"].Visible="true";
base.WriteDebugInfo(@"ISpace[""WMF_History""].Visible=""true"";ISpace[""WMF_MoveTo""].Visible=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["WMF_History"].Visible="false";ISpace["WMF_MoveTo"].Visible="false";
base.WriteDebugInfo(@"ISpace[""WMF_History""].Visible=""false"";ISpace[""WMF_MoveTo""].Visible=""false"";");
}
}
ISpace["WMF_MoveTo"].Man=true;
base.WriteDebugInfo(@"ISpace[""WMF_MoveTo""].Man=true;");

var querySource698205C52C1A42F39D81823D3215AB11 =GetQueryExpressionDataSource("698205C5-2C1A-42F3-9D81-823D3215AB11");

DataTable result698205C52C1A42F39D81823D3215AB11=iSpace.SetGridDataSource(querySource698205C52C1A42F39D81823D3215AB11, _objectFactory.GetGridRPP("WMG_CommentsHistory"),@"EXEC [GetInstanceFlowDetais] '" + ISpace["gv_instanceid"].Value + @"'");

iSpace.InsertGridBindDetails("WMG_CommentsHistory","11",querySource698205C52C1A42F39D81823D3215AB11,"EXEC [GetInstanceFlowDetais] '" + ISpace["gv_instanceid"].Value + @"'",_objectFactory.GetGridRPP("WMG_CommentsHistory"));

base.WriteDebugInfo(@"var querySource698205C52C1A42F39D81823D3215AB11 =GetQueryExpressionDataSource(""698205C5-2C1A-42F3-9D81-823D3215AB11"");DataTable result698205C52C1A42F39D81823D3215AB11=iSpace.SetGridDataSource(querySource698205C52C1A42F39D81823D3215AB11, _objectFactory.GetGridRPP(""WMG_CommentsHistory""),@""EXEC [GetInstanceFlowDetais] '"" + ISpace[""gv_instanceid""].Value + @""'"");iSpace.InsertGridBindDetails(""WMG_CommentsHistory"",""11"",querySource698205C52C1A42F39D81823D3215AB11,""EXEC [GetInstanceFlowDetais] '"" + ISpace[""gv_instanceid""].Value + @""'"",_objectFactory.GetGridRPP(""WMG_CommentsHistory""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result794A7328890E42A3B11A5984B2D49196=acdataIspace98d8749ef1dc685b350935353f8b3c3d.GetQueryExpressionBindings("794A7328-890E-42A3-B11A-5984B2D49196");
iSpace.SetGridData(result698205C52C1A42F39D81823D3215AB11,result794A7328890E42A3B11A5984B2D49196,"WMG_CommentsHistory",ref ISpace);
iSpace.UpdateGridBindDetails("WMG_CommentsHistory",result794A7328890E42A3B11A5984B2D49196);
ISpace["UI_History"].ShowDialog=true;;
base.WriteDebugInfo(@"ISpace[""UI_History""].ShowDialog=true;;");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_wmf_history (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"WMF_History-OnClick");

var querySource698205C52C1A42F39D81823D3215AB11 =GetQueryExpressionDataSource("698205C5-2C1A-42F3-9D81-823D3215AB11");

DataTable result698205C52C1A42F39D81823D3215AB11=iSpace.SetGridDataSource(querySource698205C52C1A42F39D81823D3215AB11, _objectFactory.GetGridRPP("WMG_CommentsHistory"),@"EXEC [GetInstanceFlowDetais] '" + ISpace["gv_instanceid"].Value + @"'");

iSpace.InsertGridBindDetails("WMG_CommentsHistory","11",querySource698205C52C1A42F39D81823D3215AB11,"EXEC [GetInstanceFlowDetais] '" + ISpace["gv_instanceid"].Value + @"'",_objectFactory.GetGridRPP("WMG_CommentsHistory"));

base.WriteDebugInfo(@"var querySource698205C52C1A42F39D81823D3215AB11 =GetQueryExpressionDataSource(""698205C5-2C1A-42F3-9D81-823D3215AB11"");DataTable result698205C52C1A42F39D81823D3215AB11=iSpace.SetGridDataSource(querySource698205C52C1A42F39D81823D3215AB11, _objectFactory.GetGridRPP(""WMG_CommentsHistory""),@""EXEC [GetInstanceFlowDetais] '"" + ISpace[""gv_instanceid""].Value + @""'"");iSpace.InsertGridBindDetails(""WMG_CommentsHistory"",""11"",querySource698205C52C1A42F39D81823D3215AB11,""EXEC [GetInstanceFlowDetais] '"" + ISpace[""gv_instanceid""].Value + @""'"",_objectFactory.GetGridRPP(""WMG_CommentsHistory""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result794A7328890E42A3B11A5984B2D49196=acdataIspace98d8749ef1dc685b350935353f8b3c3d.GetQueryExpressionBindings("794A7328-890E-42A3-B11A-5984B2D49196");
iSpace.SetGridData(result698205C52C1A42F39D81823D3215AB11,result794A7328890E42A3B11A5984B2D49196,"WMG_CommentsHistory",ref ISpace);
iSpace.UpdateGridBindDetails("WMG_CommentsHistory",result794A7328890E42A3B11A5984B2D49196);
ISpace["UI_History"].ShowDialog=true;;
base.WriteDebugInfo(@"ISpace[""UI_History""].ShowDialog=true;;");
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
if(ISpace["WF_FlowType"].Value=="APPROVE")
{
base.WriteDebugInfo(@"if(ISpace[""WF_FlowType""].Value==""APPROVE"")");
if(ISpace["WMF_MoveTo"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""WMF_MoveTo""].Value=="""")");
ISpace["Message"].Value=@"Error:Please Select Next Action";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Error:Please Select Next Action"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
}
if(ISpace["WF_FlowType"].Value=="RETURN" || ISpace["WF_FlowType"].Value=="REJECT")
{
base.WriteDebugInfo(@"if(ISpace[""WF_FlowType""].Value==""RETURN"" || ISpace[""WF_FlowType""].Value==""REJECT"")");
if(ISpace["WMF_MoveTo"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""WMF_MoveTo""].Value=="""")");
ISpace["Message"].Value=@"Error:Please Select Next Action";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Error:Please Select Next Action"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if(ISpace["Comments"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""Comments""].Value=="""")");
ISpace["Message"].Value=@"Error: Please Enter Comments";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Error: Please Enter Comments"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
}
base.WriteDebugInfo(@"EXEC InnovaceNoCode..[FormSave_5D394C98-9AAB-4228-B011-FC8008C3247C] '@@gv_InstanceId','@@gv_ActivityMapId','bfcdccb2-7467-4308-a53d-7cab7b883529','@@gv_InstanceId','#UC_EmployeeBaicInfoId','#MF_d1_ReferenceNo','#MF_d1_JourneyPurpose','#MF_d1_TravelType','#MF_d1_TravelPlace','#MF_d1_IsAdvanceRequired','#MF_d1_PaymentRemittenceTo','#MF_d1_BeneficiaryName','#MF_d1_AccountNo','#MF_d1_BankName','#MF_d1_IFSCCode','#MF_d1_BankDocument','#MF_d1_TransactionNo','#MF_d1_TransactionDate','#MF_d1_TotalAmount','#MF_d1_AdvanceAmount','#MF_d1_TravelStatus','#MF_d1_TSAmount','#MF_d1_TSStatus','#MF_d1_PITransactionNo','#MF_d1_PITransactionDate','#MF_d1_TSTransactionNo','#MF_d1_TSTransactionDate','@@gv_UserId','#MF_d1_CreatedOn'");

var querySourceE182AF12DAED4644A9FC9AA3381897FF =GetQueryExpressionDataSource("E182AF12-DAED-4644-A9FC-9AA3381897FF");
Dictionary<short,object> resultE182AF12DAED4644A9FC9AA3381897FF=iSpace.ExecuteQuery(querySourceE182AF12DAED4644A9FC9AA3381897FF,@"EXEC InnovaceNoCode..[FormSave_5D394C98-9AAB-4228-B011-FC8008C3247C] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','bfcdccb2-7467-4308-a53d-7cab7b883529','" + ISpace["gv_instanceid"].Value + @"','" + ISpace["UC_EmployeeBaicInfoId"].Value + @"','" + ISpace["MF_d1_ReferenceNo"].Value + @"','" + ISpace["MF_d1_JourneyPurpose"].Value + @"','" + ISpace["MF_d1_TravelType"].Value + @"','" + ISpace["MF_d1_TravelPlace"].Value + @"','" + ISpace["MF_d1_IsAdvanceRequired"].Value + @"','" + ISpace["MF_d1_PaymentRemittenceTo"].Value + @"','" + ISpace["MF_d1_BeneficiaryName"].Value + @"','" + ISpace["MF_d1_AccountNo"].Value + @"','" + ISpace["MF_d1_BankName"].Value + @"','" + ISpace["MF_d1_IFSCCode"].Value + @"','" + ISpace["MF_d1_BankDocument"].Value + @"','" + ISpace["MF_d1_TransactionNo"].Value + @"','" + ISpace["MF_d1_TransactionDate"].Value + @"','" + ISpace["MF_d1_TotalAmount"].Value + @"','" + ISpace["MF_d1_AdvanceAmount"].Value + @"','" + ISpace["MF_d1_TravelStatus"].Value + @"','" + ISpace["MF_d1_TSAmount"].Value + @"','" + ISpace["MF_d1_TSStatus"].Value + @"','" + ISpace["MF_d1_PITransactionNo"].Value + @"','" + ISpace["MF_d1_PITransactionDate"].Value + @"','" + ISpace["MF_d1_TSTransactionNo"].Value + @"','" + ISpace["MF_d1_TSTransactionDate"].Value + @"','" + ISpace["gv_userid"].Value + @"','" + ISpace["MF_d1_CreatedOn"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceE182AF12DAED4644A9FC9AA3381897FF =GetQueryExpressionDataSource(""E182AF12-DAED-4644-A9FC-9AA3381897FF"");Dictionary<short,object> resultE182AF12DAED4644A9FC9AA3381897FF=iSpace.ExecuteQuery(querySourceE182AF12DAED4644A9FC9AA3381897FF,@""EXEC InnovaceNoCode..[FormSave_5D394C98-9AAB-4228-B011-FC8008C3247C] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','bfcdccb2-7467-4308-a53d-7cab7b883529','"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""UC_EmployeeBaicInfoId""].Value + @""','"" + ISpace[""MF_d1_ReferenceNo""].Value + @""','"" + ISpace[""MF_d1_JourneyPurpose""].Value + @""','"" + ISpace[""MF_d1_TravelType""].Value + @""','"" + ISpace[""MF_d1_TravelPlace""].Value + @""','"" + ISpace[""MF_d1_IsAdvanceRequired""].Value + @""','"" + ISpace[""MF_d1_PaymentRemittenceTo""].Value + @""','"" + ISpace[""MF_d1_BeneficiaryName""].Value + @""','"" + ISpace[""MF_d1_AccountNo""].Value + @""','"" + ISpace[""MF_d1_BankName""].Value + @""','"" + ISpace[""MF_d1_IFSCCode""].Value + @""','"" + ISpace[""MF_d1_BankDocument""].Value + @""','"" + ISpace[""MF_d1_TransactionNo""].Value + @""','"" + ISpace[""MF_d1_TransactionDate""].Value + @""','"" + ISpace[""MF_d1_TotalAmount""].Value + @""','"" + ISpace[""MF_d1_AdvanceAmount""].Value + @""','"" + ISpace[""MF_d1_TravelStatus""].Value + @""','"" + ISpace[""MF_d1_TSAmount""].Value + @""','"" + ISpace[""MF_d1_TSStatus""].Value + @""','"" + ISpace[""MF_d1_PITransactionNo""].Value + @""','"" + ISpace[""MF_d1_PITransactionDate""].Value + @""','"" + ISpace[""MF_d1_TSTransactionNo""].Value + @""','"" + ISpace[""MF_d1_TSTransactionDate""].Value + @""','"" + ISpace[""gv_userid""].Value + @""','"" + ISpace[""MF_d1_CreatedOn""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultE182AF12DAED4644A9FC9AA3381897FF!=null) && (resultE182AF12DAED4644A9FC9AA3381897FF.Count!=0))
{
if(resultE182AF12DAED4644A9FC9AA3381897FF.ContainsKey(0))
ISpace["ExecutionMessage"].Value = resultE182AF12DAED4644A9FC9AA3381897FF[0];
}
else{
ISpace["ExecutionMessage"].Value = null;
}
base.WriteDebugInfo(@"EXEC InnovaceNoCode..[GridSave_63762982-2C07-4E60-8D86-D3A35CA53EDA]   '@@gv_InstanceId','@@gv_ActivityMapId','63762982-2C07-4E60-8D86-D3A35CA53EDA'");

var querySource5D2551CDFD03487A81061EBC8385C05B =GetQueryExpressionDataSource("5D2551CD-FD03-487A-8106-1EBC8385C05B");
Dictionary<short,object> result5D2551CDFD03487A81061EBC8385C05B=iSpace.ExecuteQuery(querySource5D2551CDFD03487A81061EBC8385C05B,@"EXEC InnovaceNoCode..[GridSave_63762982-2C07-4E60-8D86-D3A35CA53EDA]   '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','63762982-2C07-4E60-8D86-D3A35CA53EDA'",false);

base.WriteDebugInfo(@"var querySource5D2551CDFD03487A81061EBC8385C05B =GetQueryExpressionDataSource(""5D2551CD-FD03-487A-8106-1EBC8385C05B"");Dictionary<short,object> result5D2551CDFD03487A81061EBC8385C05B=iSpace.ExecuteQuery(querySource5D2551CDFD03487A81061EBC8385C05B,@""EXEC InnovaceNoCode..[GridSave_63762982-2C07-4E60-8D86-D3A35CA53EDA]   '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','63762982-2C07-4E60-8D86-D3A35CA53EDA'"",false);");
base.WriteDebugInfo(@"");

if((result5D2551CDFD03487A81061EBC8385C05B!=null) && (result5D2551CDFD03487A81061EBC8385C05B.Count!=0))
{
if(result5D2551CDFD03487A81061EBC8385C05B.ContainsKey(0))
ISpace["MF_ErrId"].Value = result5D2551CDFD03487A81061EBC8385C05B[0];
if(result5D2551CDFD03487A81061EBC8385C05B.ContainsKey(1))
ISpace["MF_ErrMsg"].Value = result5D2551CDFD03487A81061EBC8385C05B[1];
if(result5D2551CDFD03487A81061EBC8385C05B.ContainsKey(0))
ISpace["ExecutionMessage"].Value = result5D2551CDFD03487A81061EBC8385C05B[0];
}
else{
ISpace["MF_ErrId"].Value = null;ISpace["MF_ErrMsg"].Value = null;ISpace["ExecutionMessage"].Value = null;
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_ErrId"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ErrId""].Value==1)");
ISpace["Message"].Value=String.Format(@"{0}",ISpace["MF_ErrMsg"].Value);
base.WriteDebugInfo(@"ISpace[""Message""].Value=String.Format(@""{0}"",ISpace[""MF_ErrMsg""].Value);");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
}
base.WriteDebugInfo(@"EXEC InnovaceNoCode..[GridSave_93B856A5-0D32-4A27-8B58-5BFE5FF0162C]   '@@gv_InstanceId','@@gv_ActivityMapId','93B856A5-0D32-4A27-8B58-5BFE5FF0162C'");

var querySourceB926676F6B9A4DFE933F733A15635C3F =GetQueryExpressionDataSource("B926676F-6B9A-4DFE-933F-733A15635C3F");
Dictionary<short,object> resultB926676F6B9A4DFE933F733A15635C3F=iSpace.ExecuteQuery(querySourceB926676F6B9A4DFE933F733A15635C3F,@"EXEC InnovaceNoCode..[GridSave_93B856A5-0D32-4A27-8B58-5BFE5FF0162C]   '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','93B856A5-0D32-4A27-8B58-5BFE5FF0162C'",false);

base.WriteDebugInfo(@"var querySourceB926676F6B9A4DFE933F733A15635C3F =GetQueryExpressionDataSource(""B926676F-6B9A-4DFE-933F-733A15635C3F"");Dictionary<short,object> resultB926676F6B9A4DFE933F733A15635C3F=iSpace.ExecuteQuery(querySourceB926676F6B9A4DFE933F733A15635C3F,@""EXEC InnovaceNoCode..[GridSave_93B856A5-0D32-4A27-8B58-5BFE5FF0162C]   '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','93B856A5-0D32-4A27-8B58-5BFE5FF0162C'"",false);");
base.WriteDebugInfo(@"");

if((resultB926676F6B9A4DFE933F733A15635C3F!=null) && (resultB926676F6B9A4DFE933F733A15635C3F.Count!=0))
{
if(resultB926676F6B9A4DFE933F733A15635C3F.ContainsKey(0))
ISpace["MF_ErrId"].Value = resultB926676F6B9A4DFE933F733A15635C3F[0];
if(resultB926676F6B9A4DFE933F733A15635C3F.ContainsKey(1))
ISpace["MF_ErrMsg"].Value = resultB926676F6B9A4DFE933F733A15635C3F[1];
if(resultB926676F6B9A4DFE933F733A15635C3F.ContainsKey(0))
ISpace["ExecutionMessage"].Value = resultB926676F6B9A4DFE933F733A15635C3F[0];
}
else{
ISpace["MF_ErrId"].Value = null;ISpace["MF_ErrMsg"].Value = null;ISpace["ExecutionMessage"].Value = null;
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_ErrId"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ErrId""].Value==1)");
ISpace["Message"].Value=String.Format(@"{0}",ISpace["MF_ErrMsg"].Value);
base.WriteDebugInfo(@"ISpace[""Message""].Value=String.Format(@""{0}"",ISpace[""MF_ErrMsg""].Value);");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
}
base.WriteDebugInfo(@"Exec [SaveTravelRequestDocuments] '@@gv_InstanceId','@@gv_ProcessMapId','@@gv_UserId'");

var querySource0e8ceab69d8fffd68fe03de1048b96a0 =GetQueryExpressionDataSource("0e8ceab6-9d8f-ffd6-8fe0-3de1048b96a0");
Dictionary<short,object> result0e8ceab69d8fffd68fe03de1048b96a0=iSpace.ExecuteQuery(querySource0e8ceab69d8fffd68fe03de1048b96a0,@"Exec [SaveTravelRequestDocuments] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','" + ISpace["gv_userid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource0e8ceab69d8fffd68fe03de1048b96a0 =GetQueryExpressionDataSource(""0e8ceab6-9d8f-ffd6-8fe0-3de1048b96a0"");Dictionary<short,object> result0e8ceab69d8fffd68fe03de1048b96a0=iSpace.ExecuteQuery(querySource0e8ceab69d8fffd68fe03de1048b96a0,@""Exec [SaveTravelRequestDocuments] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','"" + ISpace[""gv_userid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result0e8ceab69d8fffd68fe03de1048b96a0!=null) && (result0e8ceab69d8fffd68fe03de1048b96a0.Count!=0))
{
if(result0e8ceab69d8fffd68fe03de1048b96a0.ContainsKey(0))
ISpace["MF_ErrId"].Value = result0e8ceab69d8fffd68fe03de1048b96a0[0];
if(result0e8ceab69d8fffd68fe03de1048b96a0.ContainsKey(1))
ISpace["MF_ErrMsg"].Value = result0e8ceab69d8fffd68fe03de1048b96a0[1];
}
else{
ISpace["MF_ErrId"].Value = null;ISpace["MF_ErrMsg"].Value = null;
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_ErrId"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ErrId""].Value==1)");
ISpace["Message"].Value=String.Format(@"{0}",ISpace["MF_ErrMsg"].Value);
base.WriteDebugInfo(@"ISpace[""Message""].Value=String.Format(@""{0}"",ISpace[""MF_ErrMsg""].Value);");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
}
ISpace["Message"].Value=@"Success: Submitted Successfully";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Success: Submitted Successfully"";");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC [UpdateTravelRequestStatus] '@@gv_InstanceId','@@gv_UserId','#WF_FlowType'");

var querySourcefbb131bf5cbf0eb86f44bf481055f5b7 =GetQueryExpressionDataSource("fbb131bf-5cbf-0eb8-6f44-bf481055f5b7");
Dictionary<short,object> resultfbb131bf5cbf0eb86f44bf481055f5b7=iSpace.ExecuteQuery(querySourcefbb131bf5cbf0eb86f44bf481055f5b7,@"EXEC [UpdateTravelRequestStatus] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_userid"].Value + @"','" + ISpace["WF_FlowType"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourcefbb131bf5cbf0eb86f44bf481055f5b7 =GetQueryExpressionDataSource(""fbb131bf-5cbf-0eb8-6f44-bf481055f5b7"");Dictionary<short,object> resultfbb131bf5cbf0eb86f44bf481055f5b7=iSpace.ExecuteQuery(querySourcefbb131bf5cbf0eb86f44bf481055f5b7,@""EXEC [UpdateTravelRequestStatus] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_userid""].Value + @""','"" + ISpace[""WF_FlowType""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultfbb131bf5cbf0eb86f44bf481055f5b7!=null) && (resultfbb131bf5cbf0eb86f44bf481055f5b7.Count!=0))
{
if(resultfbb131bf5cbf0eb86f44bf481055f5b7.ContainsKey(0))
ISpace["MF_ErrId"].Value = resultfbb131bf5cbf0eb86f44bf481055f5b7[0];
if(resultfbb131bf5cbf0eb86f44bf481055f5b7.ContainsKey(1))
ISpace["MF_ErrMsg"].Value = resultfbb131bf5cbf0eb86f44bf481055f5b7[1];
}
else{
ISpace["MF_ErrId"].Value = null;ISpace["MF_ErrMsg"].Value = null;
}
}
if(ISpace["WF_FlowType"].Value=="APPROVE")
{
base.WriteDebugInfo(@"if(ISpace[""WF_FlowType""].Value==""APPROVE"")");
base.WriteDebugInfo(@"EXEC [UpdateFinalTravelRequestStatus] '@@gv_InstanceId','@@gv_UserId','#WF_FlowType'");

var querySourced2263c8e514f23edfc6787a6b036069a =GetQueryExpressionDataSource("d2263c8e-514f-23ed-fc67-87a6b036069a");
Dictionary<short,object> resultd2263c8e514f23edfc6787a6b036069a=iSpace.ExecuteQuery(querySourced2263c8e514f23edfc6787a6b036069a,@"EXEC [UpdateFinalTravelRequestStatus] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_userid"].Value + @"','" + ISpace["WF_FlowType"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourced2263c8e514f23edfc6787a6b036069a =GetQueryExpressionDataSource(""d2263c8e-514f-23ed-fc67-87a6b036069a"");Dictionary<short,object> resultd2263c8e514f23edfc6787a6b036069a=iSpace.ExecuteQuery(querySourced2263c8e514f23edfc6787a6b036069a,@""EXEC [UpdateFinalTravelRequestStatus] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_userid""].Value + @""','"" + ISpace[""WF_FlowType""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultd2263c8e514f23edfc6787a6b036069a!=null) && (resultd2263c8e514f23edfc6787a6b036069a.Count!=0))
{
if(resultd2263c8e514f23edfc6787a6b036069a.ContainsKey(0))
ISpace["MF_ErrId"].Value = resultd2263c8e514f23edfc6787a6b036069a[0];
}
else{
ISpace["MF_ErrId"].Value = null;
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
private void SubscribeElementEvents_wmf_moveto (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"WMF_MoveTo-OnChange");
if(ISpace["WMF_MoveTo"].Value=="APPROVE")
{
base.WriteDebugInfo(@"if(ISpace[""WMF_MoveTo""].Value==""APPROVE"")");
ISpace["WF_FlowType"].Value="APPROVE";
base.WriteDebugInfo(@"ISpace[""WF_FlowType""].Value=""APPROVE"";");
ISpace["Comments"].Man=false;
base.WriteDebugInfo(@"ISpace[""Comments""].Man=false;");
}
if(ISpace["WMF_MoveTo"].Value=="RETURN")
{
base.WriteDebugInfo(@"if(ISpace[""WMF_MoveTo""].Value==""RETURN"")");
ISpace["WF_FlowType"].Value="RETURN";
base.WriteDebugInfo(@"ISpace[""WF_FlowType""].Value=""RETURN"";");
ISpace["Comments"].Man=true;
base.WriteDebugInfo(@"ISpace[""Comments""].Man=true;");
}
if(ISpace["WMF_MoveTo"].Value=="REJECT")
{
base.WriteDebugInfo(@"if(ISpace[""WMF_MoveTo""].Value==""REJECT"")");
ISpace["WF_FlowType"].Value="REJECT";
base.WriteDebugInfo(@"ISpace[""WF_FlowType""].Value=""REJECT"";");
ISpace["Comments"].Man=true;
base.WriteDebugInfo(@"ISpace[""Comments""].Man=true;");
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_cancelform (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"CancelForm-OnClick");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC [UnlockProcessInstance] '@@gv_InstanceId','@@gv_UserMapId'");

var querySource4c20e7236b4e1baa1f33b09cc235bbe6 =GetQueryExpressionDataSource("4c20e723-6b4e-1baa-1f33-b09cc235bbe6");
Dictionary<short,object> result4c20e7236b4e1baa1f33b09cc235bbe6=iSpace.ExecuteQuery(querySource4c20e7236b4e1baa1f33b09cc235bbe6,@"EXEC [UnlockProcessInstance] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_usermapid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource4c20e7236b4e1baa1f33b09cc235bbe6 =GetQueryExpressionDataSource(""4c20e723-6b4e-1baa-1f33-b09cc235bbe6"");Dictionary<short,object> result4c20e7236b4e1baa1f33b09cc235bbe6=iSpace.ExecuteQuery(querySource4c20e7236b4e1baa1f33b09cc235bbe6,@""EXEC [UnlockProcessInstance] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_usermapid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result4c20e7236b4e1baa1f33b09cc235bbe6!=null) && (result4c20e7236b4e1baa1f33b09cc235bbe6.Count!=0))
{
if(result4c20e7236b4e1baa1f33b09cc235bbe6.ContainsKey(0))
ISpace["MF_ErrId"].Value = result4c20e7236b4e1baa1f33b09cc235bbe6[0];
}
else{
ISpace["MF_ErrId"].Value = null;
}
}
ISpace["Message"].Value=@"Success: Cancelled Successfully";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Success: Cancelled Successfully"";");

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
		if(elementName.ToLower().Equals("wmf_moveto"))
    {
    			SubscribeElementEvents_wmf_moveto(ref dfsParam);
    }
}
	if(methodName.ToLower().Equals("onclick"))
{
		if(elementName.ToLower().Equals("wmf_history"))
{
			SubscribeElementEvents_wmf_history(ref dfsParam);
}
		if(elementName.ToLower().Equals("submitform"))
{
			SubscribeElementEvents_submitform(ref dfsParam);
}
		if(elementName.ToLower().Equals("cancelform"))
{
			SubscribeElementEvents_cancelform(ref dfsParam);
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
public class ISpace53f8560140a83229820900367a5bc621 : VirtualForm
{
IISpace iSpace = new ISpace();
AcDataISpace53f8560140a83229820900367a5bc621 acdataIspace53f8560140a83229820900367a5bc621=new AcDataISpace53f8560140a83229820900367a5bc621();
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
if(ISpace["FormVersionId"].Value=="48D9155C-42D2-4414-AF53-3D00D9908DD4")
{
ISpace["UI_PFHideRow"].Visible="false";
}if(ISpace["FormVersionId"].Value=="48D9155C-42D2-4414-AF53-3D00D9908DD4")
{
ISpace["UI_ApprovalHideRow"].Visible="false";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""48D9155C-42D2-4414-AF53-3D00D9908DD4"")
{
ISpace[""UI_PFHideRow""].Visible=""false"";
}if(ISpace[""FormVersionId""].Value==""48D9155C-42D2-4414-AF53-3D00D9908DD4"")
{
ISpace[""UI_ApprovalHideRow""].Visible=""false"";
}");
ISpace["Comments"].Value="";
base.WriteDebugInfo(@"ISpace[""Comments""].Value="""";");
ISpace["WMF_MoveTo"].Value="";
base.WriteDebugInfo(@"ISpace[""WMF_MoveTo""].Value="""";");
}
if(ISpace["WF_FlowType"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""WF_FlowType""].Value=="""")");
ISpace["WMF_IsInFlow"].Value=0;
base.WriteDebugInfo(@"ISpace[""WMF_IsInFlow""].Value=0;");
base.WriteDebugInfo(@"EXEC [GetInstanceInFlow] '@@gv_InstanceId'");

var querySource76804AA1305E4E7F895EB90B051455D5 =GetQueryExpressionDataSource("76804AA1-305E-4E7F-895E-B90B051455D5");
Dictionary<short,object> result76804AA1305E4E7F895EB90B051455D5=iSpace.ExecuteQuery(querySource76804AA1305E4E7F895EB90B051455D5,@"EXEC [GetInstanceInFlow] '" + ISpace["gv_instanceid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource76804AA1305E4E7F895EB90B051455D5 =GetQueryExpressionDataSource(""76804AA1-305E-4E7F-895E-B90B051455D5"");Dictionary<short,object> result76804AA1305E4E7F895EB90B051455D5=iSpace.ExecuteQuery(querySource76804AA1305E4E7F895EB90B051455D5,@""EXEC [GetInstanceInFlow] '"" + ISpace[""gv_instanceid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result76804AA1305E4E7F895EB90B051455D5!=null) && (result76804AA1305E4E7F895EB90B051455D5.Count!=0))
{
if(result76804AA1305E4E7F895EB90B051455D5.ContainsKey(0))
ISpace["WMF_IsInFlow"].Value = result76804AA1305E4E7F895EB90B051455D5[0];
}
else{
ISpace["WMF_IsInFlow"].Value = null;
}
if(ISpace["WMF_IsInFlow"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""WMF_IsInFlow""].Value==1)");
ISpace["WF_FlowType"].Value="APPROVE";
base.WriteDebugInfo(@"ISpace[""WF_FlowType""].Value=""APPROVE"";");
ISpace["WMF_History"].Visible="true";ISpace["WMF_MoveTo"].Visible="true";
base.WriteDebugInfo(@"ISpace[""WMF_History""].Visible=""true"";ISpace[""WMF_MoveTo""].Visible=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["WMF_History"].Visible="false";ISpace["WMF_MoveTo"].Visible="false";
base.WriteDebugInfo(@"ISpace[""WMF_History""].Visible=""false"";ISpace[""WMF_MoveTo""].Visible=""false"";");
}
}
ISpace["WMF_MoveTo"].Man=true;
base.WriteDebugInfo(@"ISpace[""WMF_MoveTo""].Man=true;");
if(ISpace["FWFM_FundType"].Value=="2")
{
base.WriteDebugInfo(@"if(ISpace[""FWFM_FundType""].Value==""2"")");
ISpace["FWFM_BudgetHead"].Visible="false";ISpace["FWFM_ProjectNo"].Visible="false";
base.WriteDebugInfo(@"ISpace[""FWFM_BudgetHead""].Visible=""false"";ISpace[""FWFM_ProjectNo""].Visible=""false"";");
ISpace["FWFM_BudgetHead"].Value="";
base.WriteDebugInfo(@"ISpace[""FWFM_BudgetHead""].Value="""";");
ISpace["FWFM_ProjectNo"].Value="";
base.WriteDebugInfo(@"ISpace[""FWFM_ProjectNo""].Value="""";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["FWFM_BudgetHead"].Visible="true";ISpace["FWFM_ProjectNo"].Visible="true";
base.WriteDebugInfo(@"ISpace[""FWFM_BudgetHead""].Visible=""true"";ISpace[""FWFM_ProjectNo""].Visible=""true"";");
}
if(ISpace["FWFM_FundType"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""FWFM_FundType""].Value=="""")");
ISpace["FWFM_BudgetHead"].Visible="false";ISpace["FWFM_ProjectNo"].Visible="false";ISpace["FWFM_Amount"].Visible="false";
base.WriteDebugInfo(@"ISpace[""FWFM_BudgetHead""].Visible=""false"";ISpace[""FWFM_ProjectNo""].Visible=""false"";ISpace[""FWFM_Amount""].Visible=""false"";");
}
if(ISpace["FormVersionId"].Value=="48D9155C-42D2-4414-AF53-3D00D9908DD4")
{
ISpace["UI_ApprovalHideRow"].Visible="false";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""48D9155C-42D2-4414-AF53-3D00D9908DD4"")
{
ISpace[""UI_ApprovalHideRow""].Visible=""false"";
}");

var querySource698205C52C1A42F39D81823D3215AB11 =GetQueryExpressionDataSource("698205C5-2C1A-42F3-9D81-823D3215AB11");

DataTable result698205C52C1A42F39D81823D3215AB11=iSpace.SetGridDataSource(querySource698205C52C1A42F39D81823D3215AB11, _objectFactory.GetGridRPP("WMG_CommentsHistory"),@"EXEC [GetInstanceFlowDetais] '" + ISpace["gv_instanceid"].Value + @"'");

iSpace.InsertGridBindDetails("WMG_CommentsHistory","11",querySource698205C52C1A42F39D81823D3215AB11,"EXEC [GetInstanceFlowDetais] '" + ISpace["gv_instanceid"].Value + @"'",_objectFactory.GetGridRPP("WMG_CommentsHistory"));

base.WriteDebugInfo(@"var querySource698205C52C1A42F39D81823D3215AB11 =GetQueryExpressionDataSource(""698205C5-2C1A-42F3-9D81-823D3215AB11"");DataTable result698205C52C1A42F39D81823D3215AB11=iSpace.SetGridDataSource(querySource698205C52C1A42F39D81823D3215AB11, _objectFactory.GetGridRPP(""WMG_CommentsHistory""),@""EXEC [GetInstanceFlowDetais] '"" + ISpace[""gv_instanceid""].Value + @""'"");iSpace.InsertGridBindDetails(""WMG_CommentsHistory"",""11"",querySource698205C52C1A42F39D81823D3215AB11,""EXEC [GetInstanceFlowDetais] '"" + ISpace[""gv_instanceid""].Value + @""'"",_objectFactory.GetGridRPP(""WMG_CommentsHistory""));");
ISpace["PFMF_PackageProcessMapId"].Value=ISpace["gv_processmapid"].Value;
base.WriteDebugInfo(@"ISpace[""PFMF_PackageProcessMapId""].Value=ISpace[""gv_processmapid""].Value;");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result794A7328890E42A3B11A5984B2D49196=acdataIspace53f8560140a83229820900367a5bc621.GetQueryExpressionBindings("794A7328-890E-42A3-B11A-5984B2D49196");
iSpace.SetGridData(result698205C52C1A42F39D81823D3215AB11,result794A7328890E42A3B11A5984B2D49196,"WMG_CommentsHistory",ref ISpace);
iSpace.UpdateGridBindDetails("WMG_CommentsHistory",result794A7328890E42A3B11A5984B2D49196);
ISpace["PFMF_UserId"].Value=ISpace["gv_userid"].Value;
base.WriteDebugInfo(@"ISpace[""PFMF_UserId""].Value=ISpace[""gv_userid""].Value;");
if(ISpace["FormVersionId"].Value=="48D9155C-42D2-4414-AF53-3D00D9908DD4")
{
ISpace["UI_PFHideRow"].Visible="false";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""48D9155C-42D2-4414-AF53-3D00D9908DD4"")
{
ISpace[""UI_PFHideRow""].Visible=""false"";
}");
if(ISpace["MF_d1_TravelAdvanceID"].Value!="0")
{
base.WriteDebugInfo(@"if(ISpace[""MF_d1_TravelAdvanceID""].Value!=""0"")");
base.WriteDebugInfo(@"EXEC InnovaceNoCode..[FormLoadById_5D394C98-9AAB-4228-B011-FC8008C3247C]  '#MF_d1_TravelAdvanceID'");

var querySource8A15D75CE81B41A994470F78A10C69DF =GetQueryExpressionDataSource("8A15D75C-E81B-41A9-9447-0F78A10C69DF");
Dictionary<short,object> result8A15D75CE81B41A994470F78A10C69DF=iSpace.ExecuteQuery(querySource8A15D75CE81B41A994470F78A10C69DF,@"EXEC InnovaceNoCode..[FormLoadById_5D394C98-9AAB-4228-B011-FC8008C3247C]  '" + ISpace["MF_d1_TravelAdvanceID"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource8A15D75CE81B41A994470F78A10C69DF =GetQueryExpressionDataSource(""8A15D75C-E81B-41A9-9447-0F78A10C69DF"");Dictionary<short,object> result8A15D75CE81B41A994470F78A10C69DF=iSpace.ExecuteQuery(querySource8A15D75CE81B41A994470F78A10C69DF,@""EXEC InnovaceNoCode..[FormLoadById_5D394C98-9AAB-4228-B011-FC8008C3247C]  '"" + ISpace[""MF_d1_TravelAdvanceID""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result8A15D75CE81B41A994470F78A10C69DF!=null) && (result8A15D75CE81B41A994470F78A10C69DF.Count!=0))
{
if(result8A15D75CE81B41A994470F78A10C69DF.ContainsKey(23))
ISpace["MF_d1_TSTransactionDate"].Value = result8A15D75CE81B41A994470F78A10C69DF[23];
if(result8A15D75CE81B41A994470F78A10C69DF.ContainsKey(25))
ISpace["MF_d1_CreatedOn"].Value = result8A15D75CE81B41A994470F78A10C69DF[25];
if(result8A15D75CE81B41A994470F78A10C69DF.ContainsKey(21))
ISpace["MF_d1_PITransactionDate"].Value = result8A15D75CE81B41A994470F78A10C69DF[21];
if(result8A15D75CE81B41A994470F78A10C69DF.ContainsKey(14))
ISpace["MF_d1_TransactionDate"].Value = result8A15D75CE81B41A994470F78A10C69DF[14];
if(result8A15D75CE81B41A994470F78A10C69DF.ContainsKey(4))
ISpace["MF_d1_TravelType"].Value = result8A15D75CE81B41A994470F78A10C69DF[4];
if(result8A15D75CE81B41A994470F78A10C69DF.ContainsKey(6))
ISpace["MF_d1_IsAdvanceRequired"].Value = result8A15D75CE81B41A994470F78A10C69DF[6];
if(result8A15D75CE81B41A994470F78A10C69DF.ContainsKey(12))
ISpace["MF_d1_BankDocument"].Value = result8A15D75CE81B41A994470F78A10C69DF[12];
if(result8A15D75CE81B41A994470F78A10C69DF.ContainsKey(15))
ISpace["MF_d1_TotalAmount"].Value = result8A15D75CE81B41A994470F78A10C69DF[15];
if(result8A15D75CE81B41A994470F78A10C69DF.ContainsKey(24))
ISpace["MF_d1_CreatedBy"].Value = result8A15D75CE81B41A994470F78A10C69DF[24];
if(result8A15D75CE81B41A994470F78A10C69DF.ContainsKey(16))
ISpace["MF_d1_AdvanceAmount"].Value = result8A15D75CE81B41A994470F78A10C69DF[16];
if(result8A15D75CE81B41A994470F78A10C69DF.ContainsKey(18))
ISpace["MF_d1_TSAmount"].Value = result8A15D75CE81B41A994470F78A10C69DF[18];
if(result8A15D75CE81B41A994470F78A10C69DF.ContainsKey(7))
ISpace["MF_d1_PaymentRemittenceTo"].Value = result8A15D75CE81B41A994470F78A10C69DF[7];
if(result8A15D75CE81B41A994470F78A10C69DF.ContainsKey(20))
ISpace["MF_d1_PITransactionNo"].Value = result8A15D75CE81B41A994470F78A10C69DF[20];
if(result8A15D75CE81B41A994470F78A10C69DF.ContainsKey(2))
ISpace["MF_d1_ReferenceNo"].Value = result8A15D75CE81B41A994470F78A10C69DF[2];
if(result8A15D75CE81B41A994470F78A10C69DF.ContainsKey(5))
ISpace["MF_d1_TravelPlace"].Value = result8A15D75CE81B41A994470F78A10C69DF[5];
if(result8A15D75CE81B41A994470F78A10C69DF.ContainsKey(13))
ISpace["MF_d1_TransactionNo"].Value = result8A15D75CE81B41A994470F78A10C69DF[13];
if(result8A15D75CE81B41A994470F78A10C69DF.ContainsKey(3))
ISpace["MF_d1_JourneyPurpose"].Value = result8A15D75CE81B41A994470F78A10C69DF[3];
if(result8A15D75CE81B41A994470F78A10C69DF.ContainsKey(22))
ISpace["MF_d1_TSTransactionNo"].Value = result8A15D75CE81B41A994470F78A10C69DF[22];
if(result8A15D75CE81B41A994470F78A10C69DF.ContainsKey(19))
ISpace["MF_d1_TSStatus"].Value = result8A15D75CE81B41A994470F78A10C69DF[19];
if(result8A15D75CE81B41A994470F78A10C69DF.ContainsKey(10))
ISpace["MF_d1_BankName"].Value = result8A15D75CE81B41A994470F78A10C69DF[10];
if(result8A15D75CE81B41A994470F78A10C69DF.ContainsKey(9))
ISpace["MF_d1_AccountNo"].Value = result8A15D75CE81B41A994470F78A10C69DF[9];
if(result8A15D75CE81B41A994470F78A10C69DF.ContainsKey(17))
ISpace["MF_d1_TravelStatus"].Value = result8A15D75CE81B41A994470F78A10C69DF[17];
if(result8A15D75CE81B41A994470F78A10C69DF.ContainsKey(1))
ISpace["MF_d1_EmployeeBasicInfoId"].Value = result8A15D75CE81B41A994470F78A10C69DF[1];
if(result8A15D75CE81B41A994470F78A10C69DF.ContainsKey(11))
ISpace["MF_d1_IFSCCode"].Value = result8A15D75CE81B41A994470F78A10C69DF[11];
if(result8A15D75CE81B41A994470F78A10C69DF.ContainsKey(8))
ISpace["MF_d1_BeneficiaryName"].Value = result8A15D75CE81B41A994470F78A10C69DF[8];
if(result8A15D75CE81B41A994470F78A10C69DF.ContainsKey(0))
ISpace["MF_d1_TravelAdvanceID"].Value = result8A15D75CE81B41A994470F78A10C69DF[0];
}
else{
ISpace["MF_d1_TSTransactionDate"].Value = null;ISpace["MF_d1_CreatedOn"].Value = null;ISpace["MF_d1_PITransactionDate"].Value = null;ISpace["MF_d1_TransactionDate"].Value = null;ISpace["MF_d1_TravelType"].Value = null;ISpace["MF_d1_IsAdvanceRequired"].Value = null;ISpace["MF_d1_BankDocument"].Value = null;ISpace["MF_d1_TotalAmount"].Value = null;ISpace["MF_d1_CreatedBy"].Value = null;ISpace["MF_d1_AdvanceAmount"].Value = null;ISpace["MF_d1_TSAmount"].Value = null;ISpace["MF_d1_PaymentRemittenceTo"].Value = null;ISpace["MF_d1_PITransactionNo"].Value = null;ISpace["MF_d1_ReferenceNo"].Value = null;ISpace["MF_d1_TravelPlace"].Value = null;ISpace["MF_d1_TransactionNo"].Value = null;ISpace["MF_d1_JourneyPurpose"].Value = null;ISpace["MF_d1_TSTransactionNo"].Value = null;ISpace["MF_d1_TSStatus"].Value = null;ISpace["MF_d1_BankName"].Value = null;ISpace["MF_d1_AccountNo"].Value = null;ISpace["MF_d1_TravelStatus"].Value = null;ISpace["MF_d1_EmployeeBasicInfoId"].Value = null;ISpace["MF_d1_IFSCCode"].Value = null;ISpace["MF_d1_BeneficiaryName"].Value = null;ISpace["MF_d1_TravelAdvanceID"].Value = null;
}

var querySource0B38C2325A80430BA2372A5E6E1AD125 =GetQueryExpressionDataSource("0B38C232-5A80-430B-A237-2A5E6E1AD125");

DataTable result0B38C2325A80430BA2372A5E6E1AD125=iSpace.SetGridDataSource(querySource0B38C2325A80430BA2372A5E6E1AD125, _objectFactory.GetGridRPP("ExpenseDetails"),@"EXEC InnovaceNoCode..[GridLoadById_63762982-2C07-4E60-8D86-D3A35CA53EDA]  '" + ISpace["MF_d1_TravelAdvanceID"].Value + @"'");

iSpace.InsertGridBindDetails("ExpenseDetails","11",querySource0B38C2325A80430BA2372A5E6E1AD125,"EXEC InnovaceNoCode..[GridLoadById_63762982-2C07-4E60-8D86-D3A35CA53EDA]  '" + ISpace["MF_d1_TravelAdvanceID"].Value + @"'",_objectFactory.GetGridRPP("ExpenseDetails"));

base.WriteDebugInfo(@"var querySource0B38C2325A80430BA2372A5E6E1AD125 =GetQueryExpressionDataSource(""0B38C232-5A80-430B-A237-2A5E6E1AD125"");DataTable result0B38C2325A80430BA2372A5E6E1AD125=iSpace.SetGridDataSource(querySource0B38C2325A80430BA2372A5E6E1AD125, _objectFactory.GetGridRPP(""ExpenseDetails""),@""EXEC InnovaceNoCode..[GridLoadById_63762982-2C07-4E60-8D86-D3A35CA53EDA]  '"" + ISpace[""MF_d1_TravelAdvanceID""].Value + @""'"");iSpace.InsertGridBindDetails(""ExpenseDetails"",""11"",querySource0B38C2325A80430BA2372A5E6E1AD125,""EXEC InnovaceNoCode..[GridLoadById_63762982-2C07-4E60-8D86-D3A35CA53EDA]  '"" + ISpace[""MF_d1_TravelAdvanceID""].Value + @""'"",_objectFactory.GetGridRPP(""ExpenseDetails""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result9E3B6B37E97348C38A158354D2CC4DEF=acdataIspace53f8560140a83229820900367a5bc621.GetQueryExpressionBindings("9E3B6B37-E973-48C3-8A15-8354D2CC4DEF");
iSpace.SetGridData(result0B38C2325A80430BA2372A5E6E1AD125,result9E3B6B37E97348C38A158354D2CC4DEF,"ExpenseDetails",ref ISpace);
iSpace.UpdateGridBindDetails("ExpenseDetails",result9E3B6B37E97348C38A158354D2CC4DEF);

var querySource22A090AD8607491EAEE23888BF931161 =GetQueryExpressionDataSource("22A090AD-8607-491E-AEE2-3888BF931161");

DataTable result22A090AD8607491EAEE23888BF931161=iSpace.SetGridDataSource(querySource22A090AD8607491EAEE23888BF931161, _objectFactory.GetGridRPP("AdvanceDetails"),@"EXEC InnovaceNoCode..[GridLoadById_93B856A5-0D32-4A27-8B58-5BFE5FF0162C]  '" + ISpace["MF_d1_TravelAdvanceID"].Value + @"'");

iSpace.InsertGridBindDetails("AdvanceDetails","11",querySource22A090AD8607491EAEE23888BF931161,"EXEC InnovaceNoCode..[GridLoadById_93B856A5-0D32-4A27-8B58-5BFE5FF0162C]  '" + ISpace["MF_d1_TravelAdvanceID"].Value + @"'",_objectFactory.GetGridRPP("AdvanceDetails"));

base.WriteDebugInfo(@"var querySource22A090AD8607491EAEE23888BF931161 =GetQueryExpressionDataSource(""22A090AD-8607-491E-AEE2-3888BF931161"");DataTable result22A090AD8607491EAEE23888BF931161=iSpace.SetGridDataSource(querySource22A090AD8607491EAEE23888BF931161, _objectFactory.GetGridRPP(""AdvanceDetails""),@""EXEC InnovaceNoCode..[GridLoadById_93B856A5-0D32-4A27-8B58-5BFE5FF0162C]  '"" + ISpace[""MF_d1_TravelAdvanceID""].Value + @""'"");iSpace.InsertGridBindDetails(""AdvanceDetails"",""11"",querySource22A090AD8607491EAEE23888BF931161,""EXEC InnovaceNoCode..[GridLoadById_93B856A5-0D32-4A27-8B58-5BFE5FF0162C]  '"" + ISpace[""MF_d1_TravelAdvanceID""].Value + @""'"",_objectFactory.GetGridRPP(""AdvanceDetails""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> resultA86C8422ADD944BAB612C8D9EDB841C5=acdataIspace53f8560140a83229820900367a5bc621.GetQueryExpressionBindings("A86C8422-ADD9-44BA-B612-C8D9EDB841C5");
iSpace.SetGridData(result22A090AD8607491EAEE23888BF931161,resultA86C8422ADD944BAB612C8D9EDB841C5,"AdvanceDetails",ref ISpace);
iSpace.UpdateGridBindDetails("AdvanceDetails",resultA86C8422ADD944BAB612C8D9EDB841C5);
}
base.WriteDebugInfo(@"EXEC [GetEmployeeUserContextDetails] '@@gv_UserId'");

var querySource3c3e1ff76c79c28ed6149890b238c224 =GetQueryExpressionDataSource("3c3e1ff7-6c79-c28e-d614-9890b238c224");
Dictionary<short,object> result3c3e1ff76c79c28ed6149890b238c224=iSpace.ExecuteQuery(querySource3c3e1ff76c79c28ed6149890b238c224,@"EXEC [GetEmployeeUserContextDetails] '" + ISpace["gv_userid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource3c3e1ff76c79c28ed6149890b238c224 =GetQueryExpressionDataSource(""3c3e1ff7-6c79-c28e-d614-9890b238c224"");Dictionary<short,object> result3c3e1ff76c79c28ed6149890b238c224=iSpace.ExecuteQuery(querySource3c3e1ff76c79c28ed6149890b238c224,@""EXEC [GetEmployeeUserContextDetails] '"" + ISpace[""gv_userid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result3c3e1ff76c79c28ed6149890b238c224!=null) && (result3c3e1ff76c79c28ed6149890b238c224.Count!=0))
{
if(result3c3e1ff76c79c28ed6149890b238c224.ContainsKey(0))
ISpace["UC_EmployeeBaicInfoId"].Value = result3c3e1ff76c79c28ed6149890b238c224[0];
if(result3c3e1ff76c79c28ed6149890b238c224.ContainsKey(7))
ISpace["UC_Designation"].Value = result3c3e1ff76c79c28ed6149890b238c224[7];
if(result3c3e1ff76c79c28ed6149890b238c224.ContainsKey(10))
ISpace["UC_DOR"].Value = result3c3e1ff76c79c28ed6149890b238c224[10];
if(result3c3e1ff76c79c28ed6149890b238c224.ContainsKey(15))
ISpace["UC_PhoneNumber"].Value = result3c3e1ff76c79c28ed6149890b238c224[15];
if(result3c3e1ff76c79c28ed6149890b238c224.ContainsKey(6))
ISpace["UC_Department"].Value = result3c3e1ff76c79c28ed6149890b238c224[6];
if(result3c3e1ff76c79c28ed6149890b238c224.ContainsKey(2))
ISpace["UC_Name"].Value = result3c3e1ff76c79c28ed6149890b238c224[2];
if(result3c3e1ff76c79c28ed6149890b238c224.ContainsKey(3))
ISpace["UC_EmailId"].Value = result3c3e1ff76c79c28ed6149890b238c224[3];
if(result3c3e1ff76c79c28ed6149890b238c224.ContainsKey(12))
ISpace["UC_Paylevel"].Value = result3c3e1ff76c79c28ed6149890b238c224[12];
if(result3c3e1ff76c79c28ed6149890b238c224.ContainsKey(11))
ISpace["UC_Grade"].Value = result3c3e1ff76c79c28ed6149890b238c224[11];
if(result3c3e1ff76c79c28ed6149890b238c224.ContainsKey(4))
ISpace["UC_DOJ"].Value = result3c3e1ff76c79c28ed6149890b238c224[4];
if(result3c3e1ff76c79c28ed6149890b238c224.ContainsKey(9))
ISpace["UC_DOB"].Value = result3c3e1ff76c79c28ed6149890b238c224[9];
if(result3c3e1ff76c79c28ed6149890b238c224.ContainsKey(1))
ISpace["UC_EmployeeId"].Value = result3c3e1ff76c79c28ed6149890b238c224[1];
}
else{
ISpace["UC_EmployeeBaicInfoId"].Value = null;ISpace["UC_Designation"].Value = null;ISpace["UC_DOR"].Value = null;ISpace["UC_PhoneNumber"].Value = null;ISpace["UC_Department"].Value = null;ISpace["UC_Name"].Value = null;ISpace["UC_EmailId"].Value = null;ISpace["UC_Paylevel"].Value = null;ISpace["UC_Grade"].Value = null;ISpace["UC_DOJ"].Value = null;ISpace["UC_DOB"].Value = null;ISpace["UC_EmployeeId"].Value = null;
}
ISpace["MF_d1_TravelStatus"].Value="S";
base.WriteDebugInfo(@"ISpace[""MF_d1_TravelStatus""].Value=""S"";");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["FWFM_BudgetHead"].Man=true;ISpace["FWFM_ProjectNo"].Man=true;ISpace["MF_d1_TravelType"].Man=true;ISpace["MFG_d3_FromDate"].Man=true;ISpace["MF_d1_TravelPlace"].Man=true;ISpace["MFG_d2_JourneyClass"].Man=true;ISpace["MFG_d2_Arrival"].Man=true;ISpace["MF_d1_JourneyPurpose"].Man=true;ISpace["MFG_d3_Amount"].Man=true;ISpace["FWFM_Amount"].Man=true;ISpace["MFG_d2_Amount"].Man=true;ISpace["MF_d1_AdvanceAmount"].Man=true;ISpace["MFG_d2_DepartureDate"].Man=true;ISpace["MFG_d3_OtherExpenditureType"].Man=true;ISpace["MFG_d2_ModeofJourney"].Man=true;ISpace["MFG_d2_Departure"].Man=true;ISpace["MF_d1_IsAdvanceRequired"].Man=true;ISpace["MFG_d2_ArrivalDate"].Man=true;ISpace["FWFM_FundType"].Man=true;ISpace["MFG_d3_ExpenditureType"].Man=true;ISpace["MFG_d3_ToDate"].Man=true;
base.WriteDebugInfo(@"ISpace[""FWFM_BudgetHead""].Man=true;ISpace[""FWFM_ProjectNo""].Man=true;ISpace[""MF_d1_TravelType""].Man=true;ISpace[""MFG_d3_FromDate""].Man=true;ISpace[""MF_d1_TravelPlace""].Man=true;ISpace[""MFG_d2_JourneyClass""].Man=true;ISpace[""MFG_d2_Arrival""].Man=true;ISpace[""MF_d1_JourneyPurpose""].Man=true;ISpace[""MFG_d3_Amount""].Man=true;ISpace[""FWFM_Amount""].Man=true;ISpace[""MFG_d2_Amount""].Man=true;ISpace[""MF_d1_AdvanceAmount""].Man=true;ISpace[""MFG_d2_DepartureDate""].Man=true;ISpace[""MFG_d3_OtherExpenditureType""].Man=true;ISpace[""MFG_d2_ModeofJourney""].Man=true;ISpace[""MFG_d2_Departure""].Man=true;ISpace[""MF_d1_IsAdvanceRequired""].Man=true;ISpace[""MFG_d2_ArrivalDate""].Man=true;ISpace[""FWFM_FundType""].Man=true;ISpace[""MFG_d3_ExpenditureType""].Man=true;ISpace[""MFG_d3_ToDate""].Man=true;");
ISpace["MF_EligibleAdavnce"].Value=0;
base.WriteDebugInfo(@"ISpace[""MF_EligibleAdavnce""].Value=0;");
}
ISpace["MF_TotalOtherExpense"].Value=0;
base.WriteDebugInfo(@"ISpace[""MF_TotalOtherExpense""].Value=0;");
ISpace["MF_TotaTravellExpense"].Value=0;
base.WriteDebugInfo(@"ISpace[""MF_TotaTravellExpense""].Value=0;");
ISpace["MF_d1_TotalAmount"].Value=0;
base.WriteDebugInfo(@"ISpace[""MF_d1_TotalAmount""].Value=0;");
base.WriteDebugInfo(@"EXEC [GenerateRef] 3,'@@gv_UserId'");

var querySourcecb7a5d0645d0748ac18fbb48a35f9e4e =GetQueryExpressionDataSource("cb7a5d06-45d0-748a-c18f-bb48a35f9e4e");
Dictionary<short,object> resultcb7a5d0645d0748ac18fbb48a35f9e4e=iSpace.ExecuteQuery(querySourcecb7a5d0645d0748ac18fbb48a35f9e4e,@"EXEC[GenerateRef] 3,'" + ISpace["gv_userid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourcecb7a5d0645d0748ac18fbb48a35f9e4e =GetQueryExpressionDataSource(""cb7a5d06-45d0-748a-c18f-bb48a35f9e4e"");Dictionary<short,object> resultcb7a5d0645d0748ac18fbb48a35f9e4e=iSpace.ExecuteQuery(querySourcecb7a5d0645d0748ac18fbb48a35f9e4e,@""EXEC[GenerateRef] 3,'"" + ISpace[""gv_userid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultcb7a5d0645d0748ac18fbb48a35f9e4e!=null) && (resultcb7a5d0645d0748ac18fbb48a35f9e4e.Count!=0))
{
if(resultcb7a5d0645d0748ac18fbb48a35f9e4e.ContainsKey(0))
ISpace["Subject"].Value = resultcb7a5d0645d0748ac18fbb48a35f9e4e[0];
if(resultcb7a5d0645d0748ac18fbb48a35f9e4e.ContainsKey(0))
ISpace["MF_d1_ReferenceNo"].Value = resultcb7a5d0645d0748ac18fbb48a35f9e4e[0];
}
else{
ISpace["Subject"].Value = null;ISpace["MF_d1_ReferenceNo"].Value = null;
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_fwfm_save (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"FWFM_Save-OnClick");
base.WriteDebugInfo(@"EXEC [Upsert60e821d0-153e-94bb-1fef-2594b78625bd] '@@gv_InstanceId','@@gv_ProcessMapId','#FWFM_FundDetailsId','#FWFM_FundType','#FWFM_ProjectNo','#FWFM_BudgetHead','#FWFM_Amount','#UC_EmployeeBaicInfoId'");

var querySourceB39C99E949594231A55079A7280A86B2 =GetQueryExpressionDataSource("B39C99E9-4959-4231-A550-79A7280A86B2");
Dictionary<short,object> resultB39C99E949594231A55079A7280A86B2=iSpace.ExecuteQuery(querySourceB39C99E949594231A55079A7280A86B2,@"EXEC [Upsert60e821d0-153e-94bb-1fef-2594b78625bd] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','" + ISpace["FWFM_FundDetailsId"].Value + @"','" + ISpace["FWFM_FundType"].Value + @"','" + ISpace["FWFM_ProjectNo"].Value + @"','" + ISpace["FWFM_BudgetHead"].Value + @"','" + ISpace["FWFM_Amount"].Value + @"','" + ISpace["UC_EmployeeBaicInfoId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceB39C99E949594231A55079A7280A86B2 =GetQueryExpressionDataSource(""B39C99E9-4959-4231-A550-79A7280A86B2"");Dictionary<short,object> resultB39C99E949594231A55079A7280A86B2=iSpace.ExecuteQuery(querySourceB39C99E949594231A55079A7280A86B2,@""EXEC [Upsert60e821d0-153e-94bb-1fef-2594b78625bd] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','"" + ISpace[""FWFM_FundDetailsId""].Value + @""','"" + ISpace[""FWFM_FundType""].Value + @""','"" + ISpace[""FWFM_ProjectNo""].Value + @""','"" + ISpace[""FWFM_BudgetHead""].Value + @""','"" + ISpace[""FWFM_Amount""].Value + @""','"" + ISpace[""UC_EmployeeBaicInfoId""].Value + @""'"",false);");

var querySourceB40457367C78448F8AD374D62A738672 =GetQueryExpressionDataSource("B4045736-7C78-448F-8AD3-74D62A738672");

DataTable resultB40457367C78448F8AD374D62A738672=iSpace.SetGridDataSource(querySourceB40457367C78448F8AD374D62A738672, _objectFactory.GetGridRPP("MG_FundAllocation"),@"Exec [Get60e821d0-153e-94bb-1fef-2594b78625bd] '" + ISpace["gv_instanceid"].Value + @"'");

iSpace.InsertGridBindDetails("MG_FundAllocation","11",querySourceB40457367C78448F8AD374D62A738672,"Exec [Get60e821d0-153e-94bb-1fef-2594b78625bd] '" + ISpace["gv_instanceid"].Value + @"'",_objectFactory.GetGridRPP("MG_FundAllocation"));

base.WriteDebugInfo(@"var querySourceB40457367C78448F8AD374D62A738672 =GetQueryExpressionDataSource(""B4045736-7C78-448F-8AD3-74D62A738672"");DataTable resultB40457367C78448F8AD374D62A738672=iSpace.SetGridDataSource(querySourceB40457367C78448F8AD374D62A738672, _objectFactory.GetGridRPP(""MG_FundAllocation""),@""Exec [Get60e821d0-153e-94bb-1fef-2594b78625bd] '"" + ISpace[""gv_instanceid""].Value + @""'"");iSpace.InsertGridBindDetails(""MG_FundAllocation"",""11"",querySourceB40457367C78448F8AD374D62A738672,""Exec [Get60e821d0-153e-94bb-1fef-2594b78625bd] '"" + ISpace[""gv_instanceid""].Value + @""'"",_objectFactory.GetGridRPP(""MG_FundAllocation""));");
base.WriteDebugInfo(@"");

if((resultB39C99E949594231A55079A7280A86B2!=null) && (resultB39C99E949594231A55079A7280A86B2.Count!=0))
{
if(resultB39C99E949594231A55079A7280A86B2.ContainsKey(0))
ISpace["PFM_ErrId"].Value = resultB39C99E949594231A55079A7280A86B2[0];
if(resultB39C99E949594231A55079A7280A86B2.ContainsKey(1))
ISpace["PFM_ErrMsg"].Value = resultB39C99E949594231A55079A7280A86B2[1];
}
else{
ISpace["PFM_ErrId"].Value = null;ISpace["PFM_ErrMsg"].Value = null;
}
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result25891B7408F44F71BE6136CEA4C143EC=acdataIspace53f8560140a83229820900367a5bc621.GetQueryExpressionBindings("25891B74-08F4-4F71-BE61-36CEA4C143EC");
iSpace.SetGridData(resultB40457367C78448F8AD374D62A738672,result25891B7408F44F71BE6136CEA4C143EC,"MG_FundAllocation",ref ISpace);
iSpace.UpdateGridBindDetails("MG_FundAllocation",result25891B7408F44F71BE6136CEA4C143EC);
ISpace["Message"].Value=String.Format(@"{0}",ISpace["PFM_ErrMsg"].Value);
base.WriteDebugInfo(@"ISpace[""Message""].Value=String.Format(@""{0}"",ISpace[""PFM_ErrMsg""].Value);");
if(ISpace["PFM_ErrId"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""PFM_ErrId""].Value==1)");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["FWFM_FundDetailsId"].Value="";
base.WriteDebugInfo(@"ISpace[""FWFM_FundDetailsId""].Value="""";");
ISpace["FWFM_FundType"].Value="";
base.WriteDebugInfo(@"ISpace[""FWFM_FundType""].Value="""";");
ISpace["FWFM_ProjectNo"].Value="";
base.WriteDebugInfo(@"ISpace[""FWFM_ProjectNo""].Value="""";");
ISpace["FWFM_BudgetHead"].Value="";
base.WriteDebugInfo(@"ISpace[""FWFM_BudgetHead""].Value="""";");
ISpace["FWFM_Amount"].Value=0;
base.WriteDebugInfo(@"ISpace[""FWFM_Amount""].Value=0;");
}
base.WriteDebugInfo(@"EXEC [GetFundSum] '@@gv_InstanceId'");

var querySourcebbe4aa41de2bed94cedd90d80df7192f =GetQueryExpressionDataSource("bbe4aa41-de2b-ed94-cedd-90d80df7192f");
Dictionary<short,object> resultbbe4aa41de2bed94cedd90d80df7192f=iSpace.ExecuteQuery(querySourcebbe4aa41de2bed94cedd90d80df7192f,@"EXEC [GetFundSum] '" + ISpace["gv_instanceid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourcebbe4aa41de2bed94cedd90d80df7192f =GetQueryExpressionDataSource(""bbe4aa41-de2b-ed94-cedd-90d80df7192f"");Dictionary<short,object> resultbbe4aa41de2bed94cedd90d80df7192f=iSpace.ExecuteQuery(querySourcebbe4aa41de2bed94cedd90d80df7192f,@""EXEC [GetFundSum] '"" + ISpace[""gv_instanceid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultbbe4aa41de2bed94cedd90d80df7192f!=null) && (resultbbe4aa41de2bed94cedd90d80df7192f.Count!=0))
{
if(resultbbe4aa41de2bed94cedd90d80df7192f.ContainsKey(0))
ISpace["MF_FundTotal"].Value = resultbbe4aa41de2bed94cedd90d80df7192f[0];
}
else{
ISpace["MF_FundTotal"].Value = null;
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_pfa_widgetsubmit (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"PFA_WidgetSubmit-OnClick");
base.WriteDebugInfo(@"EXEC [UpsertProjectFundAllocation] '@@gv_InstanceId','@@gv_ProcessMapId','@@gv_UserId'");

var querySource94A94EAC199144639AD7CC6F7445F90A =GetQueryExpressionDataSource("94A94EAC-1991-4463-9AD7-CC6F7445F90A");
Dictionary<short,object> result94A94EAC199144639AD7CC6F7445F90A=iSpace.ExecuteQuery(querySource94A94EAC199144639AD7CC6F7445F90A,@"EXEC [UpsertProjectFundAllocation] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','" + ISpace["gv_userid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource94A94EAC199144639AD7CC6F7445F90A =GetQueryExpressionDataSource(""94A94EAC-1991-4463-9AD7-CC6F7445F90A"");Dictionary<short,object> result94A94EAC199144639AD7CC6F7445F90A=iSpace.ExecuteQuery(querySource94A94EAC199144639AD7CC6F7445F90A,@""EXEC [UpsertProjectFundAllocation] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','"" + ISpace[""gv_userid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result94A94EAC199144639AD7CC6F7445F90A!=null) && (result94A94EAC199144639AD7CC6F7445F90A.Count!=0))
{
if(result94A94EAC199144639AD7CC6F7445F90A.ContainsKey(0))
ISpace["PFM_ErrId"].Value = result94A94EAC199144639AD7CC6F7445F90A[0];
}
else{
ISpace["PFM_ErrId"].Value = null;
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_wmf_history (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"WMF_History-OnClick");

var querySource698205C52C1A42F39D81823D3215AB11 =GetQueryExpressionDataSource("698205C5-2C1A-42F3-9D81-823D3215AB11");

DataTable result698205C52C1A42F39D81823D3215AB11=iSpace.SetGridDataSource(querySource698205C52C1A42F39D81823D3215AB11, _objectFactory.GetGridRPP("WMG_CommentsHistory"),@"EXEC [GetInstanceFlowDetais] '" + ISpace["gv_instanceid"].Value + @"'");

iSpace.InsertGridBindDetails("WMG_CommentsHistory","11",querySource698205C52C1A42F39D81823D3215AB11,"EXEC [GetInstanceFlowDetais] '" + ISpace["gv_instanceid"].Value + @"'",_objectFactory.GetGridRPP("WMG_CommentsHistory"));

base.WriteDebugInfo(@"var querySource698205C52C1A42F39D81823D3215AB11 =GetQueryExpressionDataSource(""698205C5-2C1A-42F3-9D81-823D3215AB11"");DataTable result698205C52C1A42F39D81823D3215AB11=iSpace.SetGridDataSource(querySource698205C52C1A42F39D81823D3215AB11, _objectFactory.GetGridRPP(""WMG_CommentsHistory""),@""EXEC [GetInstanceFlowDetais] '"" + ISpace[""gv_instanceid""].Value + @""'"");iSpace.InsertGridBindDetails(""WMG_CommentsHistory"",""11"",querySource698205C52C1A42F39D81823D3215AB11,""EXEC [GetInstanceFlowDetais] '"" + ISpace[""gv_instanceid""].Value + @""'"",_objectFactory.GetGridRPP(""WMG_CommentsHistory""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result794A7328890E42A3B11A5984B2D49196=acdataIspace53f8560140a83229820900367a5bc621.GetQueryExpressionBindings("794A7328-890E-42A3-B11A-5984B2D49196");
iSpace.SetGridData(result698205C52C1A42F39D81823D3215AB11,result794A7328890E42A3B11A5984B2D49196,"WMG_CommentsHistory",ref ISpace);
iSpace.UpdateGridBindDetails("WMG_CommentsHistory",result794A7328890E42A3B11A5984B2D49196);
ISpace["UI_History"].ShowDialog=true;;
base.WriteDebugInfo(@"ISpace[""UI_History""].ShowDialog=true;;");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_fwfm_projectno (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"FWFM_ProjectNo-OnChange");
ISpace["FWFM_BudgetHead"].rElemData=iSpace.Reload(ISpace["FWFM_BudgetHead"].Value,@"Exec SP_GetDistrubitionDetails 5,'" + ISpace["PFMF_PackageProcessMapId"].Value + @"','" + ISpace["FWFM_FundType"].Value + @"','','','','','" + ISpace["FWFM_ProjectNo"].Value + @"'","9ADED37B-CD11-426B-AF16-DEAC75685EF5");
base.WriteDebugInfo(@"ISpace[""FWFM_BudgetHead""].rElemData=iSpace.Reload(ISpace[""FWFM_BudgetHead""].Value,@""Exec SP_GetDistrubitionDetails 5,'"" + ISpace[""PFMF_PackageProcessMapId""].Value + @""','"" + ISpace[""FWFM_FundType""].Value + @""','','','','','"" + ISpace[""FWFM_ProjectNo""].Value + @""'"",""9ADED37B-CD11-426B-AF16-DEAC75685EF5"");");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_pfm_yes (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"PFM_Yes-OnClick");
base.WriteDebugInfo(@"EXEC [Delete60e821d0-153e_94bb-1fef-2594b78625bd] '@@gv_InstanceId','#PFM_FundDetailsId'");

var querySource4F9BFECD00624E7B883133CCA9BF62FE =GetQueryExpressionDataSource("4F9BFECD-0062-4E7B-8831-33CCA9BF62FE");
Dictionary<short,object> result4F9BFECD00624E7B883133CCA9BF62FE=iSpace.ExecuteQuery(querySource4F9BFECD00624E7B883133CCA9BF62FE,@"EXEC[Delete60e821d0-153e_94bb-1fef-2594b78625bd] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["PFM_FundDetailsId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource4F9BFECD00624E7B883133CCA9BF62FE =GetQueryExpressionDataSource(""4F9BFECD-0062-4E7B-8831-33CCA9BF62FE"");Dictionary<short,object> result4F9BFECD00624E7B883133CCA9BF62FE=iSpace.ExecuteQuery(querySource4F9BFECD00624E7B883133CCA9BF62FE,@""EXEC[Delete60e821d0-153e_94bb-1fef-2594b78625bd] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""PFM_FundDetailsId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result4F9BFECD00624E7B883133CCA9BF62FE!=null) && (result4F9BFECD00624E7B883133CCA9BF62FE.Count!=0))
{
if(result4F9BFECD00624E7B883133CCA9BF62FE.ContainsKey(0))
ISpace["PFM_ErrId"].Value = result4F9BFECD00624E7B883133CCA9BF62FE[0];
if(result4F9BFECD00624E7B883133CCA9BF62FE.ContainsKey(1))
ISpace["PFM_ErrMsg"].Value = result4F9BFECD00624E7B883133CCA9BF62FE[1];
}
else{
ISpace["PFM_ErrId"].Value = null;ISpace["PFM_ErrMsg"].Value = null;
}
ISpace["Message"].Value=String.Format(@"{0}",ISpace["PFM_ErrMsg"].Value);
base.WriteDebugInfo(@"ISpace[""Message""].Value=String.Format(@""{0}"",ISpace[""PFM_ErrMsg""].Value);");

var querySourceB40457367C78448F8AD374D62A738672 =GetQueryExpressionDataSource("B4045736-7C78-448F-8AD3-74D62A738672");

DataTable resultB40457367C78448F8AD374D62A738672=iSpace.SetGridDataSource(querySourceB40457367C78448F8AD374D62A738672, _objectFactory.GetGridRPP("MG_FundAllocation"),@"Exec [Get60e821d0-153e-94bb-1fef-2594b78625bd] '" + ISpace["gv_instanceid"].Value + @"'");

iSpace.InsertGridBindDetails("MG_FundAllocation","11",querySourceB40457367C78448F8AD374D62A738672,"Exec [Get60e821d0-153e-94bb-1fef-2594b78625bd] '" + ISpace["gv_instanceid"].Value + @"'",_objectFactory.GetGridRPP("MG_FundAllocation"));

base.WriteDebugInfo(@"var querySourceB40457367C78448F8AD374D62A738672 =GetQueryExpressionDataSource(""B4045736-7C78-448F-8AD3-74D62A738672"");DataTable resultB40457367C78448F8AD374D62A738672=iSpace.SetGridDataSource(querySourceB40457367C78448F8AD374D62A738672, _objectFactory.GetGridRPP(""MG_FundAllocation""),@""Exec [Get60e821d0-153e-94bb-1fef-2594b78625bd] '"" + ISpace[""gv_instanceid""].Value + @""'"");iSpace.InsertGridBindDetails(""MG_FundAllocation"",""11"",querySourceB40457367C78448F8AD374D62A738672,""Exec [Get60e821d0-153e-94bb-1fef-2594b78625bd] '"" + ISpace[""gv_instanceid""].Value + @""'"",_objectFactory.GetGridRPP(""MG_FundAllocation""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result25891B7408F44F71BE6136CEA4C143EC=acdataIspace53f8560140a83229820900367a5bc621.GetQueryExpressionBindings("25891B74-08F4-4F71-BE61-36CEA4C143EC");
iSpace.SetGridData(resultB40457367C78448F8AD374D62A738672,result25891B7408F44F71BE6136CEA4C143EC,"MG_FundAllocation",ref ISpace);
iSpace.UpdateGridBindDetails("MG_FundAllocation",result25891B7408F44F71BE6136CEA4C143EC);
ISpace["PFM_FundDetailsId"].Value="";
base.WriteDebugInfo(@"ISpace[""PFM_FundDetailsId""].Value="""";");
ISpace["UI_DeleteDialog"].HideDialog=true;;
base.WriteDebugInfo(@"ISpace[""UI_DeleteDialog""].HideDialog=true;;");
base.WriteDebugInfo(@"EXEC [GetFundSum] '@@gv_InstanceId'");

var querySourcebbe4aa41de2bed94cedd90d80df7192f =GetQueryExpressionDataSource("bbe4aa41-de2b-ed94-cedd-90d80df7192f");
Dictionary<short,object> resultbbe4aa41de2bed94cedd90d80df7192f=iSpace.ExecuteQuery(querySourcebbe4aa41de2bed94cedd90d80df7192f,@"EXEC [GetFundSum] '" + ISpace["gv_instanceid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourcebbe4aa41de2bed94cedd90d80df7192f =GetQueryExpressionDataSource(""bbe4aa41-de2b-ed94-cedd-90d80df7192f"");Dictionary<short,object> resultbbe4aa41de2bed94cedd90d80df7192f=iSpace.ExecuteQuery(querySourcebbe4aa41de2bed94cedd90d80df7192f,@""EXEC [GetFundSum] '"" + ISpace[""gv_instanceid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultbbe4aa41de2bed94cedd90d80df7192f!=null) && (resultbbe4aa41de2bed94cedd90d80df7192f.Count!=0))
{
if(resultbbe4aa41de2bed94cedd90d80df7192f.ContainsKey(0))
ISpace["MF_FundTotal"].Value = resultbbe4aa41de2bed94cedd90d80df7192f[0];
}
else{
ISpace["MF_FundTotal"].Value = null;
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_fwmf_availablebudget (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"FWMF_AvailableBudget-OnClick");
ISpace["FWAB_ProjectNo"].Value="";
base.WriteDebugInfo(@"ISpace[""FWAB_ProjectNo""].Value="""";");
ISpace["UI_WAvailableBudgetDialog"].ShowDialog=true;;
base.WriteDebugInfo(@"ISpace[""UI_WAvailableBudgetDialog""].ShowDialog=true;;");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_save_advancedetails (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Save_AdvanceDetails-OnClick");
if(ISpace["MFG_d2_ModeofJourney"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""MFG_d2_ModeofJourney""].Value=="""")");
ISpace["Message"].Value=@"Error: Please select the Mode of Journey";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Error: Please select the Mode of Journey"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if(ISpace["MFG_d2_Departure"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""MFG_d2_Departure""].Value=="""")");
ISpace["Message"].Value=@"Error: Please Enter the Departure";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Error: Please Enter the Departure"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if((ISpace["MFG_d2_DepartureDate"].Value == null))
{
base.WriteDebugInfo(@"if((ISpace[""MFG_d2_DepartureDate""].Value == null))");
ISpace["Message"].Value=@"Error: Please select the Departure Date";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Error: Please select the Departure Date"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if(ISpace["MFG_d2_Arrival"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""MFG_d2_Arrival""].Value=="""")");
ISpace["Message"].Value=@"Error: Please Enter the Arrival";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Error: Please Enter the Arrival"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if((ISpace["MFG_d2_ArrivalDate"].Value == null))
{
base.WriteDebugInfo(@"if((ISpace[""MFG_d2_ArrivalDate""].Value == null))");
ISpace["Message"].Value=@"Error: Please select the Arrival Date";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Error: Please select the Arrival Date"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if(ISpace["MFG_d2_ArrivalDate"].Value<ISpace["MFG_d2_DepartureDate"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MFG_d2_ArrivalDate""].Value<ISpace[""MFG_d2_DepartureDate""].Value)");
ISpace["Message"].Value=@"Error: Arrival Date Should be greater than Departure Date";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Error: Arrival Date Should be greater than Departure Date"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if(ISpace["MFG_d2_Amount"].Value==0)
{
base.WriteDebugInfo(@"if(ISpace[""MFG_d2_Amount""].Value==0)");
ISpace["Message"].Value=@"Error: Please Enter the Amount";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Error: Please Enter the Amount"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if(ISpace["MFG_d2_Arrival"].Value==ISpace["MFG_d2_Departure"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MFG_d2_Arrival""].Value==ISpace[""MFG_d2_Departure""].Value)");
ISpace["Message"].Value=@"Error: Departure and Arrival Place Must not be same";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Error: Departure and Arrival Place Must not be same"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if(ISpace["growid"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""growid""].Value=="""")");

var querySource5E4DD494A94146D5861A1C2B0B9576C2 =GetQueryExpressionDataSource("5E4DD494-A941-46D5-861A-1C2B0B9576C2");

DataTable result5E4DD494A94146D5861A1C2B0B9576C2=iSpace.SetGridDataSource(querySource5E4DD494A94146D5861A1C2B0B9576C2, _objectFactory.GetGridRPP("AdvanceDetails"),@"EXEC [AddFormGridData93B856A5-0D32-4A27-8B58-5BFE5FF0162C] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','93B856A5-0D32-4A27-8B58-5BFE5FF0162C','" + ISpace["growid"].Value + @"'," + ISpace["AdvanceDetails_Sequence"].Value + @",'" + ISpace["MFG_d2_TADetailsID"].Value + @"','" + ISpace["MFG_d2_TravelAdvanceID"].Value + @"','" + ISpace["MFG_d2_Departure"].Value + @"','" + ISpace["MFG_d2_DepartureDate"].Value + @"','" + ISpace["MFG_d2_DepartureTime"].Value + @"','" + ISpace["MFG_d2_Arrival"].Value + @"','" + ISpace["MFG_d2_ArrivalDate"].Value + @"','" + ISpace["MFG_d2_ArrivalTime"].Value + @"','" + ISpace["MFG_d2_ModeofJourney"].Value + @"','" + ISpace["MFG_d2_JourneyClass"].Value + @"'," + ISpace["MFG_d2_Road"].Value + @",'" + ISpace["MFG_d2_PNRNo"].Value + @"'," + ISpace["MFG_d2_Amount"].Value + @"," + ISpace["MFG_d2_IsTravelRequest"].Value + @"," + ISpace["MFG_d2_UpdatedBy"].Value + @",'" + ISpace["MFG_d2_UpdatedOn"].Value + @"'");

iSpace.InsertGridBindDetails("AdvanceDetails","11",querySource5E4DD494A94146D5861A1C2B0B9576C2,"EXEC [AddFormGridData93B856A5-0D32-4A27-8B58-5BFE5FF0162C] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','93B856A5-0D32-4A27-8B58-5BFE5FF0162C','" + ISpace["growid"].Value + @"'," + ISpace["AdvanceDetails_Sequence"].Value + @",'" + ISpace["MFG_d2_TADetailsID"].Value + @"','" + ISpace["MFG_d2_TravelAdvanceID"].Value + @"','" + ISpace["MFG_d2_Departure"].Value + @"','" + ISpace["MFG_d2_DepartureDate"].Value + @"','" + ISpace["MFG_d2_DepartureTime"].Value + @"','" + ISpace["MFG_d2_Arrival"].Value + @"','" + ISpace["MFG_d2_ArrivalDate"].Value + @"','" + ISpace["MFG_d2_ArrivalTime"].Value + @"','" + ISpace["MFG_d2_ModeofJourney"].Value + @"','" + ISpace["MFG_d2_JourneyClass"].Value + @"'," + ISpace["MFG_d2_Road"].Value + @",'" + ISpace["MFG_d2_PNRNo"].Value + @"'," + ISpace["MFG_d2_Amount"].Value + @"," + ISpace["MFG_d2_IsTravelRequest"].Value + @"," + ISpace["MFG_d2_UpdatedBy"].Value + @",'" + ISpace["MFG_d2_UpdatedOn"].Value + @"'",_objectFactory.GetGridRPP("AdvanceDetails"));

base.WriteDebugInfo(@"var querySource5E4DD494A94146D5861A1C2B0B9576C2 =GetQueryExpressionDataSource(""5E4DD494-A941-46D5-861A-1C2B0B9576C2"");DataTable result5E4DD494A94146D5861A1C2B0B9576C2=iSpace.SetGridDataSource(querySource5E4DD494A94146D5861A1C2B0B9576C2, _objectFactory.GetGridRPP(""AdvanceDetails""),@""EXEC [AddFormGridData93B856A5-0D32-4A27-8B58-5BFE5FF0162C] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','93B856A5-0D32-4A27-8B58-5BFE5FF0162C','"" + ISpace[""growid""].Value + @""',"" + ISpace[""AdvanceDetails_Sequence""].Value + @"",'"" + ISpace[""MFG_d2_TADetailsID""].Value + @""','"" + ISpace[""MFG_d2_TravelAdvanceID""].Value + @""','"" + ISpace[""MFG_d2_Departure""].Value + @""','"" + ISpace[""MFG_d2_DepartureDate""].Value + @""','"" + ISpace[""MFG_d2_DepartureTime""].Value + @""','"" + ISpace[""MFG_d2_Arrival""].Value + @""','"" + ISpace[""MFG_d2_ArrivalDate""].Value + @""','"" + ISpace[""MFG_d2_ArrivalTime""].Value + @""','"" + ISpace[""MFG_d2_ModeofJourney""].Value + @""','"" + ISpace[""MFG_d2_JourneyClass""].Value + @""',"" + ISpace[""MFG_d2_Road""].Value + @"",'"" + ISpace[""MFG_d2_PNRNo""].Value + @""',"" + ISpace[""MFG_d2_Amount""].Value + @"","" + ISpace[""MFG_d2_IsTravelRequest""].Value + @"","" + ISpace[""MFG_d2_UpdatedBy""].Value + @"",'"" + ISpace[""MFG_d2_UpdatedOn""].Value + @""'"");iSpace.InsertGridBindDetails(""AdvanceDetails"",""11"",querySource5E4DD494A94146D5861A1C2B0B9576C2,""EXEC [AddFormGridData93B856A5-0D32-4A27-8B58-5BFE5FF0162C] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','93B856A5-0D32-4A27-8B58-5BFE5FF0162C','"" + ISpace[""growid""].Value + @""',"" + ISpace[""AdvanceDetails_Sequence""].Value + @"",'"" + ISpace[""MFG_d2_TADetailsID""].Value + @""','"" + ISpace[""MFG_d2_TravelAdvanceID""].Value + @""','"" + ISpace[""MFG_d2_Departure""].Value + @""','"" + ISpace[""MFG_d2_DepartureDate""].Value + @""','"" + ISpace[""MFG_d2_DepartureTime""].Value + @""','"" + ISpace[""MFG_d2_Arrival""].Value + @""','"" + ISpace[""MFG_d2_ArrivalDate""].Value + @""','"" + ISpace[""MFG_d2_ArrivalTime""].Value + @""','"" + ISpace[""MFG_d2_ModeofJourney""].Value + @""','"" + ISpace[""MFG_d2_JourneyClass""].Value + @""',"" + ISpace[""MFG_d2_Road""].Value + @"",'"" + ISpace[""MFG_d2_PNRNo""].Value + @""',"" + ISpace[""MFG_d2_Amount""].Value + @"","" + ISpace[""MFG_d2_IsTravelRequest""].Value + @"","" + ISpace[""MFG_d2_UpdatedBy""].Value + @"",'"" + ISpace[""MFG_d2_UpdatedOn""].Value + @""'"",_objectFactory.GetGridRPP(""AdvanceDetails""));");
base.WriteDebugInfo(@"EXEC [AddFormGridData93B856A5-0D32-4A27-8B58-5BFE5FF0162C] '@@gv_InstanceId','@@gv_ActivityMapId','93B856A5-0D32-4A27-8B58-5BFE5FF0162C','#growid',#AdvanceDetails_Sequence,'#MFG_d2_TADetailsID','#MFG_d2_TravelAdvanceID','#MFG_d2_Departure','#MFG_d2_DepartureDate','#MFG_d2_DepartureTime','#MFG_d2_Arrival','#MFG_d2_ArrivalDate','#MFG_d2_ArrivalTime','#MFG_d2_ModeofJourney','#MFG_d2_JourneyClass',#MFG_d2_Road,'#MFG_d2_PNRNo',#MFG_d2_Amount,#MFG_d2_IsTravelRequest,#MFG_d2_UpdatedBy,'#MFG_d2_UpdatedO");


List<Triplet<string, short, short?>> resultD3F136535A714FF787CF7CCF34A9151A=acdataIspace53f8560140a83229820900367a5bc621.GetQueryExpressionBindings("D3F13653-5A71-4FF7-87CF-7CCF34A9151A");
iSpace.SetGridData(result5E4DD494A94146D5861A1C2B0B9576C2,resultD3F136535A714FF787CF7CCF34A9151A,"AdvanceDetails",ref ISpace);
iSpace.UpdateGridBindDetails("AdvanceDetails",resultD3F136535A714FF787CF7CCF34A9151A);
}
else
{
base.WriteDebugInfo(@"else");

var querySource7444A31301164D01ADC7D4FB2D3A166B =GetQueryExpressionDataSource("7444A313-0116-4D01-ADC7-D4FB2D3A166B");

DataTable result7444A31301164D01ADC7D4FB2D3A166B=iSpace.SetGridDataSource(querySource7444A31301164D01ADC7D4FB2D3A166B, _objectFactory.GetGridRPP("AdvanceDetails"),@"EXEC [UpdateFormGridData93B856A5-0D32-4A27-8B58-5BFE5FF0162C] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','93B856A5-0D32-4A27-8B58-5BFE5FF0162C','" + ISpace["growid"].Value + @"'," + ISpace["AdvanceDetails_Sequence"].Value + @",'" + ISpace["MFG_d2_TADetailsID"].Value + @"','" + ISpace["MFG_d2_TravelAdvanceID"].Value + @"','" + ISpace["MFG_d2_Departure"].Value + @"','" + ISpace["MFG_d2_DepartureDate"].Value + @"','" + ISpace["MFG_d2_DepartureTime"].Value + @"','" + ISpace["MFG_d2_Arrival"].Value + @"','" + ISpace["MFG_d2_ArrivalDate"].Value + @"','" + ISpace["MFG_d2_ArrivalTime"].Value + @"','" + ISpace["MFG_d2_ModeofJourney"].Value + @"','" + ISpace["MFG_d2_JourneyClass"].Value + @"'," + ISpace["MFG_d2_Road"].Value + @",'" + ISpace["MFG_d2_PNRNo"].Value + @"'," + ISpace["MFG_d2_Amount"].Value + @"," + ISpace["MFG_d2_IsTravelRequest"].Value + @"," + ISpace["MFG_d2_UpdatedBy"].Value + @",'" + ISpace["MFG_d2_Updatedon"].Value + @"'");

iSpace.InsertGridBindDetails("AdvanceDetails","11",querySource7444A31301164D01ADC7D4FB2D3A166B,"EXEC [UpdateFormGridData93B856A5-0D32-4A27-8B58-5BFE5FF0162C] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','93B856A5-0D32-4A27-8B58-5BFE5FF0162C','" + ISpace["growid"].Value + @"'," + ISpace["AdvanceDetails_Sequence"].Value + @",'" + ISpace["MFG_d2_TADetailsID"].Value + @"','" + ISpace["MFG_d2_TravelAdvanceID"].Value + @"','" + ISpace["MFG_d2_Departure"].Value + @"','" + ISpace["MFG_d2_DepartureDate"].Value + @"','" + ISpace["MFG_d2_DepartureTime"].Value + @"','" + ISpace["MFG_d2_Arrival"].Value + @"','" + ISpace["MFG_d2_ArrivalDate"].Value + @"','" + ISpace["MFG_d2_ArrivalTime"].Value + @"','" + ISpace["MFG_d2_ModeofJourney"].Value + @"','" + ISpace["MFG_d2_JourneyClass"].Value + @"'," + ISpace["MFG_d2_Road"].Value + @",'" + ISpace["MFG_d2_PNRNo"].Value + @"'," + ISpace["MFG_d2_Amount"].Value + @"," + ISpace["MFG_d2_IsTravelRequest"].Value + @"," + ISpace["MFG_d2_UpdatedBy"].Value + @",'" + ISpace["MFG_d2_Updatedon"].Value + @"'",_objectFactory.GetGridRPP("AdvanceDetails"));

base.WriteDebugInfo(@"var querySource7444A31301164D01ADC7D4FB2D3A166B =GetQueryExpressionDataSource(""7444A313-0116-4D01-ADC7-D4FB2D3A166B"");DataTable result7444A31301164D01ADC7D4FB2D3A166B=iSpace.SetGridDataSource(querySource7444A31301164D01ADC7D4FB2D3A166B, _objectFactory.GetGridRPP(""AdvanceDetails""),@""EXEC [UpdateFormGridData93B856A5-0D32-4A27-8B58-5BFE5FF0162C] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','93B856A5-0D32-4A27-8B58-5BFE5FF0162C','"" + ISpace[""growid""].Value + @""',"" + ISpace[""AdvanceDetails_Sequence""].Value + @"",'"" + ISpace[""MFG_d2_TADetailsID""].Value + @""','"" + ISpace[""MFG_d2_TravelAdvanceID""].Value + @""','"" + ISpace[""MFG_d2_Departure""].Value + @""','"" + ISpace[""MFG_d2_DepartureDate""].Value + @""','"" + ISpace[""MFG_d2_DepartureTime""].Value + @""','"" + ISpace[""MFG_d2_Arrival""].Value + @""','"" + ISpace[""MFG_d2_ArrivalDate""].Value + @""','"" + ISpace[""MFG_d2_ArrivalTime""].Value + @""','"" + ISpace[""MFG_d2_ModeofJourney""].Value + @""','"" + ISpace[""MFG_d2_JourneyClass""].Value + @""',"" + ISpace[""MFG_d2_Road""].Value + @"",'"" + ISpace[""MFG_d2_PNRNo""].Value + @""',"" + ISpace[""MFG_d2_Amount""].Value + @"","" + ISpace[""MFG_d2_IsTravelRequest""].Value + @"","" + ISpace[""MFG_d2_UpdatedBy""].Value + @"",'"" + ISpace[""MFG_d2_Updatedon""].Value + @""'"");iSpace.InsertGridBindDetails(""AdvanceDetails"",""11"",querySource7444A31301164D01ADC7D4FB2D3A166B,""EXEC [UpdateFormGridData93B856A5-0D32-4A27-8B58-5BFE5FF0162C] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','93B856A5-0D32-4A27-8B58-5BFE5FF0162C','"" + ISpace[""growid""].Value + @""',"" + ISpace[""AdvanceDetails_Sequence""].Value + @"",'"" + ISpace[""MFG_d2_TADetailsID""].Value + @""','"" + ISpace[""MFG_d2_TravelAdvanceID""].Value + @""','"" + ISpace[""MFG_d2_Departure""].Value + @""','"" + ISpace[""MFG_d2_DepartureDate""].Value + @""','"" + ISpace[""MFG_d2_DepartureTime""].Value + @""','"" + ISpace[""MFG_d2_Arrival""].Value + @""','"" + ISpace[""MFG_d2_ArrivalDate""].Value + @""','"" + ISpace[""MFG_d2_ArrivalTime""].Value + @""','"" + ISpace[""MFG_d2_ModeofJourney""].Value + @""','"" + ISpace[""MFG_d2_JourneyClass""].Value + @""',"" + ISpace[""MFG_d2_Road""].Value + @"",'"" + ISpace[""MFG_d2_PNRNo""].Value + @""',"" + ISpace[""MFG_d2_Amount""].Value + @"","" + ISpace[""MFG_d2_IsTravelRequest""].Value + @"","" + ISpace[""MFG_d2_UpdatedBy""].Value + @"",'"" + ISpace[""MFG_d2_Updatedon""].Value + @""'"",_objectFactory.GetGridRPP(""AdvanceDetails""));");
base.WriteDebugInfo(@"EXEC [UpdateFormGridData93B856A5-0D32-4A27-8B58-5BFE5FF0162C] '@@gv_InstanceId','@@gv_ActivityMapId','93B856A5-0D32-4A27-8B58-5BFE5FF0162C','#growid',#AdvanceDetails_Sequence,'#MFG_d2_TADetailsID','#MFG_d2_TravelAdvanceID','#MFG_d2_Departure','#MFG_d2_DepartureDate','#MFG_d2_DepartureTime','#MFG_d2_Arrival','#MFG_d2_ArrivalDate','#MFG_d2_ArrivalTime','#MFG_d2_ModeofJourney','#MFG_d2_JourneyClass',#MFG_d2_Road,'#MFG_d2_PNRNo',#MFG_d2_Amount,#MFG_d2_IsTravelRequest,#MFG_d2_UpdatedBy,'#MFG_d2_Updat");


List<Triplet<string, short, short?>> resultFAA6C5FB3ED241778B276EA6EA73C8C5=acdataIspace53f8560140a83229820900367a5bc621.GetQueryExpressionBindings("FAA6C5FB-3ED2-4177-8B27-6EA6EA73C8C5");
iSpace.SetGridData(result7444A31301164D01ADC7D4FB2D3A166B,resultFAA6C5FB3ED241778B276EA6EA73C8C5,"AdvanceDetails",ref ISpace);
iSpace.UpdateGridBindDetails("AdvanceDetails",resultFAA6C5FB3ED241778B276EA6EA73C8C5);
}
ISpace["growid"].Value="";
base.WriteDebugInfo(@"ISpace[""growid""].Value="""";");
ISpace["MFG_d2_TADetailsID"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d2_TADetailsID""].Value="""";");
ISpace["MFG_d2_TravelAdvanceID"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d2_TravelAdvanceID""].Value="""";");
ISpace["MFG_d2_Departure"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d2_Departure""].Value="""";");
ISpace["MFG_d2_DepartureDate"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d2_DepartureDate""].Value="""";");
ISpace["MFG_d2_DepartureTime"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d2_DepartureTime""].Value="""";");
ISpace["MFG_d2_Arrival"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d2_Arrival""].Value="""";");
ISpace["MFG_d2_ArrivalDate"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d2_ArrivalDate""].Value="""";");
ISpace["MFG_d2_ArrivalTime"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d2_ArrivalTime""].Value="""";");
ISpace["MFG_d2_ModeofJourney"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d2_ModeofJourney""].Value="""";");
ISpace["MFG_d2_JourneyClass"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d2_JourneyClass""].Value="""";");
ISpace["MFG_d2_Road"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d2_Road""].Value="""";");
ISpace["MFG_d2_PNRNo"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d2_PNRNo""].Value="""";");
ISpace["MFG_d2_Amount"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d2_Amount""].Value="""";");
ISpace["MFG_d2_IsTravelRequest"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d2_IsTravelRequest""].Value="""";");
ISpace["MFG_d2_UpdatedBy"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d2_UpdatedBy""].Value="""";");
ISpace["MFG_d2_UpdatedOn"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d2_UpdatedOn""].Value="""";");
object MG_d2_Amount=iSpace.Sum("[93B856A5-0D32-4A27-8B58-5BFE5FF0162C]","MG_d2_Amount","",ISpace["gv_instanceid"].Value);
ISpace["MF_TotaTravellExpense"].Value=Convert.ChangeType(MG_d2_Amount, MG_d2_Amount.GetType());;
base.WriteDebugInfo(@"object MG_d2_Amount=iSpace.Sum(""[93B856A5-0D32-4A27-8B58-5BFE5FF0162C]"",""MG_d2_Amount"","""",ISpace[""gv_instanceid""].Value);
ISpace[""MF_TotaTravellExpense""].Value=Convert.ChangeType(MG_d2_Amount, MG_d2_Amount.GetType());;");
object MG_d3_Amount=iSpace.Sum("[63762982-2C07-4E60-8D86-D3A35CA53EDA]","MG_d3_Amount","",ISpace["gv_instanceid"].Value);
ISpace["MF_TotalOtherExpense"].Value=Convert.ChangeType(MG_d3_Amount, MG_d3_Amount.GetType());;
base.WriteDebugInfo(@"object MG_d3_Amount=iSpace.Sum(""[63762982-2C07-4E60-8D86-D3A35CA53EDA]"",""MG_d3_Amount"","""",ISpace[""gv_instanceid""].Value);
ISpace[""MF_TotalOtherExpense""].Value=Convert.ChangeType(MG_d3_Amount, MG_d3_Amount.GetType());;");
ISpace["MF_d1_TotalAmount"].Value=ISpace["MF_TotaTravellExpense"].Value+ISpace["MF_TotalOtherExpense"].Value;
base.WriteDebugInfo(@"ISpace[""MF_d1_TotalAmount""].Value=ISpace[""MF_TotaTravellExpense""].Value+ISpace[""MF_TotalOtherExpense""].Value;");
ISpace["MF_EligibleAdavnce"].Value=ISpace["MF_d1_TotalAmount"].Value*90;
base.WriteDebugInfo(@"ISpace[""MF_EligibleAdavnce""].Value=ISpace[""MF_d1_TotalAmount""].Value*90;");
ISpace["MF_EligibleAdavnce"].Value=ISpace["MF_EligibleAdavnce"].Value/100;
base.WriteDebugInfo(@"ISpace[""MF_EligibleAdavnce""].Value=ISpace[""MF_EligibleAdavnce""].Value/100;");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_edit_advancedetails (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Edit_AdvanceDetails-OnClick");
ISpace["growid"].Value=ISpace["AdvanceDetails_RowId"].Value;
base.WriteDebugInfo(@"ISpace[""growid""].Value=ISpace[""AdvanceDetails_RowId""].Value;");
base.WriteDebugInfo(@"EXEC [LoadFormGridData93B856A5-0D32-4A27-8B58-5BFE5FF0162C] '@@gv_InstanceId','@@gv_ActivityMapId','93B856A5-0D32-4A27-8B58-5BFE5FF0162C','#growid',#AdvanceDetails_Sequence");

var querySource6A3DD0196ADB41F4A45177D3CE6705D7 =GetQueryExpressionDataSource("6A3DD019-6ADB-41F4-A451-77D3CE6705D7");
Dictionary<short,object> result6A3DD0196ADB41F4A45177D3CE6705D7=iSpace.ExecuteQuery(querySource6A3DD0196ADB41F4A45177D3CE6705D7,@"EXEC [LoadFormGridData93B856A5-0D32-4A27-8B58-5BFE5FF0162C] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','93B856A5-0D32-4A27-8B58-5BFE5FF0162C','" + ISpace["growid"].Value + @"'," + ISpace["AdvanceDetails_Sequence"].Value + @"",false);

base.WriteDebugInfo(@"var querySource6A3DD0196ADB41F4A45177D3CE6705D7 =GetQueryExpressionDataSource(""6A3DD019-6ADB-41F4-A451-77D3CE6705D7"");Dictionary<short,object> result6A3DD0196ADB41F4A45177D3CE6705D7=iSpace.ExecuteQuery(querySource6A3DD0196ADB41F4A45177D3CE6705D7,@""EXEC [LoadFormGridData93B856A5-0D32-4A27-8B58-5BFE5FF0162C] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','93B856A5-0D32-4A27-8B58-5BFE5FF0162C','"" + ISpace[""growid""].Value + @""',"" + ISpace[""AdvanceDetails_Sequence""].Value + @"""",false);");
base.WriteDebugInfo(@"EXEC [LoadFormGridData93B856A5-0D32-4A27-8B58-5BFE5FF0162C] '@@gv_InstanceId','@@gv_ActivityMapId','93B856A5-0D32-4A27-8B58-5BFE5FF0162C','#growid',#AdvanceDetails_Sequence");

if((result6A3DD0196ADB41F4A45177D3CE6705D7!=null) && (result6A3DD0196ADB41F4A45177D3CE6705D7.Count!=0))
{
if(result6A3DD0196ADB41F4A45177D3CE6705D7.ContainsKey(3))
ISpace["MFG_d2_DepartureDate"].Value = result6A3DD0196ADB41F4A45177D3CE6705D7[3];
if(result6A3DD0196ADB41F4A45177D3CE6705D7.ContainsKey(15))
ISpace["MFG_d2_UpdatedOn"].Value = result6A3DD0196ADB41F4A45177D3CE6705D7[15];
if(result6A3DD0196ADB41F4A45177D3CE6705D7.ContainsKey(6))
ISpace["MFG_d2_ArrivalDate"].Value = result6A3DD0196ADB41F4A45177D3CE6705D7[6];
if(result6A3DD0196ADB41F4A45177D3CE6705D7.ContainsKey(8))
ISpace["MFG_d2_ModeofJourney"].Value = result6A3DD0196ADB41F4A45177D3CE6705D7[8];
if(result6A3DD0196ADB41F4A45177D3CE6705D7.ContainsKey(9))
ISpace["MFG_d2_JourneyClass"].Value = result6A3DD0196ADB41F4A45177D3CE6705D7[9];
if(result6A3DD0196ADB41F4A45177D3CE6705D7.ContainsKey(13))
ISpace["MFG_d2_IsTravelRequest"].Value = result6A3DD0196ADB41F4A45177D3CE6705D7[13];
if(result6A3DD0196ADB41F4A45177D3CE6705D7.ContainsKey(14))
ISpace["MFG_d2_UpdatedBy"].Value = result6A3DD0196ADB41F4A45177D3CE6705D7[14];
if(result6A3DD0196ADB41F4A45177D3CE6705D7.ContainsKey(12))
ISpace["MFG_d2_Amount"].Value = result6A3DD0196ADB41F4A45177D3CE6705D7[12];
if(result6A3DD0196ADB41F4A45177D3CE6705D7.ContainsKey(10))
ISpace["MFG_d2_Road"].Value = result6A3DD0196ADB41F4A45177D3CE6705D7[10];
if(result6A3DD0196ADB41F4A45177D3CE6705D7.ContainsKey(0))
ISpace["MFG_d2_TADetailsID"].Value = result6A3DD0196ADB41F4A45177D3CE6705D7[0];
if(result6A3DD0196ADB41F4A45177D3CE6705D7.ContainsKey(11))
ISpace["MFG_d2_PNRNo"].Value = result6A3DD0196ADB41F4A45177D3CE6705D7[11];
if(result6A3DD0196ADB41F4A45177D3CE6705D7.ContainsKey(5))
ISpace["MFG_d2_Arrival"].Value = result6A3DD0196ADB41F4A45177D3CE6705D7[5];
if(result6A3DD0196ADB41F4A45177D3CE6705D7.ContainsKey(7))
ISpace["MFG_d2_ArrivalTime"].Value = result6A3DD0196ADB41F4A45177D3CE6705D7[7];
if(result6A3DD0196ADB41F4A45177D3CE6705D7.ContainsKey(2))
ISpace["MFG_d2_Departure"].Value = result6A3DD0196ADB41F4A45177D3CE6705D7[2];
if(result6A3DD0196ADB41F4A45177D3CE6705D7.ContainsKey(1))
ISpace["MFG_d2_TravelAdvanceID"].Value = result6A3DD0196ADB41F4A45177D3CE6705D7[1];
if(result6A3DD0196ADB41F4A45177D3CE6705D7.ContainsKey(4))
ISpace["MFG_d2_DepartureTime"].Value = result6A3DD0196ADB41F4A45177D3CE6705D7[4];
}
else{
ISpace["MFG_d2_DepartureDate"].Value = null;ISpace["MFG_d2_UpdatedOn"].Value = null;ISpace["MFG_d2_ArrivalDate"].Value = null;ISpace["MFG_d2_ModeofJourney"].Value = null;ISpace["MFG_d2_JourneyClass"].Value = null;ISpace["MFG_d2_IsTravelRequest"].Value = null;ISpace["MFG_d2_UpdatedBy"].Value = null;ISpace["MFG_d2_Amount"].Value = null;ISpace["MFG_d2_Road"].Value = null;ISpace["MFG_d2_TADetailsID"].Value = null;ISpace["MFG_d2_PNRNo"].Value = null;ISpace["MFG_d2_Arrival"].Value = null;ISpace["MFG_d2_ArrivalTime"].Value = null;ISpace["MFG_d2_Departure"].Value = null;ISpace["MFG_d2_TravelAdvanceID"].Value = null;ISpace["MFG_d2_DepartureTime"].Value = null;
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_pfm_no (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"PFM_No-OnClick");
ISpace["PFM_FundDetailsId"].Value="";
base.WriteDebugInfo(@"ISpace[""PFM_FundDetailsId""].Value="""";");
ISpace["UI_DeleteDialog"].HideDialog=true;;
base.WriteDebugInfo(@"ISpace[""UI_DeleteDialog""].HideDialog=true;;");
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
if(ISpace["MF_d1_TravelType"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""MF_d1_TravelType""].Value=="""")");
ISpace["Message"].Value=@"Error: Please select Travel Type";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Error: Please select Travel Type"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if(ISpace["MF_d1_TravelPlace"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""MF_d1_TravelPlace""].Value=="""")");
ISpace["Message"].Value=@"Error: Please enter the Travel Place";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Error: Please enter the Travel Place"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if(ISpace["MF_d1_JourneyPurpose"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""MF_d1_JourneyPurpose""].Value=="""")");
ISpace["Message"].Value=@"Error: Please Enter the Purpose of Journey";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Error: Please Enter the Purpose of Journey"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if(ISpace["MF_d1_IsAdvanceRequired"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""MF_d1_IsAdvanceRequired""].Value=="""")");
ISpace["Message"].Value=@"Error: Please Select Is Advance Required";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Error: Please Select Is Advance Required"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if(ISpace["MF_d1_IsAdvanceRequired"].Value=="Yes")
{
base.WriteDebugInfo(@"if(ISpace[""MF_d1_IsAdvanceRequired""].Value==""Yes"")");
if(ISpace["MF_d1_AdvanceAmount"].Value==0)
{
base.WriteDebugInfo(@"if(ISpace[""MF_d1_AdvanceAmount""].Value==0)");
ISpace["Message"].Value=@"Please Enter the Advance Amount";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please Enter the Advance Amount"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
}
if(ISpace["MF_FundTotal"].Value!=ISpace["MF_d1_TotalAmount"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_FundTotal""].Value!=ISpace[""MF_d1_TotalAmount""].Value)");
ISpace["Message"].Value=@"Error: Total Fund Amount and Total Amount must be Equal";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Error: Total Fund Amount and Total Amount must be Equal"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if(ISpace["WF_FlowType"].Value=="APPROVE")
{
base.WriteDebugInfo(@"if(ISpace[""WF_FlowType""].Value==""APPROVE"")");
if(ISpace["WMF_MoveTo"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""WMF_MoveTo""].Value=="""")");
ISpace["Message"].Value=@"Error:Please Select Next Action";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Error:Please Select Next Action"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
}
if(ISpace["WF_FlowType"].Value=="RETURN" || ISpace["WF_FlowType"].Value=="REJECT")
{
base.WriteDebugInfo(@"if(ISpace[""WF_FlowType""].Value==""RETURN"" || ISpace[""WF_FlowType""].Value==""REJECT"")");
if(ISpace["WMF_MoveTo"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""WMF_MoveTo""].Value=="""")");
ISpace["Message"].Value=@"Error:Please Select Next Action";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Error:Please Select Next Action"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if(ISpace["Comments"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""Comments""].Value=="""")");
ISpace["Message"].Value=@"Error: Please Enter Comments";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Error: Please Enter Comments"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
}
base.WriteDebugInfo(@"EXEC InnovaceNoCode..[FormSave_5D394C98-9AAB-4228-B011-FC8008C3247C] '@@gv_InstanceId','@@gv_ActivityMapId','bfcdccb2-7467-4308-a53d-7cab7b883529','@@gv_InstanceId','#UC_EmployeeBaicInfoId','#MF_d1_ReferenceNo','#MF_d1_JourneyPurpose','#MF_d1_TravelType','#MF_d1_TravelPlace','#MF_d1_IsAdvanceRequired','#MF_d1_PaymentRemittenceTo','#MF_d1_BeneficiaryName','#MF_d1_AccountNo','#MF_d1_BankName','#MF_d1_IFSCCode','#MF_d1_BankDocument','#MF_d1_TransactionNo','#MF_d1_TransactionDate','#MF_d1_TotalAmount','#MF_d1_AdvanceAmount','#MF_d1_TravelStatus','#MF_d1_TSAmount','#MF_d1_TSStatus','#MF_d1_PITransactionNo','#MF_d1_PITransactionDate','#MF_d1_TSTransactionNo','#MF_d1_TSTransactionDate','@@gv_UserId','#MF_d1_CreatedOn'");

var querySourceE182AF12DAED4644A9FC9AA3381897FF =GetQueryExpressionDataSource("E182AF12-DAED-4644-A9FC-9AA3381897FF");
Dictionary<short,object> resultE182AF12DAED4644A9FC9AA3381897FF=iSpace.ExecuteQuery(querySourceE182AF12DAED4644A9FC9AA3381897FF,@"EXEC InnovaceNoCode..[FormSave_5D394C98-9AAB-4228-B011-FC8008C3247C] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','bfcdccb2-7467-4308-a53d-7cab7b883529','" + ISpace["gv_instanceid"].Value + @"','" + ISpace["UC_EmployeeBaicInfoId"].Value + @"','" + ISpace["MF_d1_ReferenceNo"].Value + @"','" + ISpace["MF_d1_JourneyPurpose"].Value + @"','" + ISpace["MF_d1_TravelType"].Value + @"','" + ISpace["MF_d1_TravelPlace"].Value + @"','" + ISpace["MF_d1_IsAdvanceRequired"].Value + @"','" + ISpace["MF_d1_PaymentRemittenceTo"].Value + @"','" + ISpace["MF_d1_BeneficiaryName"].Value + @"','" + ISpace["MF_d1_AccountNo"].Value + @"','" + ISpace["MF_d1_BankName"].Value + @"','" + ISpace["MF_d1_IFSCCode"].Value + @"','" + ISpace["MF_d1_BankDocument"].Value + @"','" + ISpace["MF_d1_TransactionNo"].Value + @"','" + ISpace["MF_d1_TransactionDate"].Value + @"','" + ISpace["MF_d1_TotalAmount"].Value + @"','" + ISpace["MF_d1_AdvanceAmount"].Value + @"','" + ISpace["MF_d1_TravelStatus"].Value + @"','" + ISpace["MF_d1_TSAmount"].Value + @"','" + ISpace["MF_d1_TSStatus"].Value + @"','" + ISpace["MF_d1_PITransactionNo"].Value + @"','" + ISpace["MF_d1_PITransactionDate"].Value + @"','" + ISpace["MF_d1_TSTransactionNo"].Value + @"','" + ISpace["MF_d1_TSTransactionDate"].Value + @"','" + ISpace["gv_userid"].Value + @"','" + ISpace["MF_d1_CreatedOn"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceE182AF12DAED4644A9FC9AA3381897FF =GetQueryExpressionDataSource(""E182AF12-DAED-4644-A9FC-9AA3381897FF"");Dictionary<short,object> resultE182AF12DAED4644A9FC9AA3381897FF=iSpace.ExecuteQuery(querySourceE182AF12DAED4644A9FC9AA3381897FF,@""EXEC InnovaceNoCode..[FormSave_5D394C98-9AAB-4228-B011-FC8008C3247C] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','bfcdccb2-7467-4308-a53d-7cab7b883529','"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""UC_EmployeeBaicInfoId""].Value + @""','"" + ISpace[""MF_d1_ReferenceNo""].Value + @""','"" + ISpace[""MF_d1_JourneyPurpose""].Value + @""','"" + ISpace[""MF_d1_TravelType""].Value + @""','"" + ISpace[""MF_d1_TravelPlace""].Value + @""','"" + ISpace[""MF_d1_IsAdvanceRequired""].Value + @""','"" + ISpace[""MF_d1_PaymentRemittenceTo""].Value + @""','"" + ISpace[""MF_d1_BeneficiaryName""].Value + @""','"" + ISpace[""MF_d1_AccountNo""].Value + @""','"" + ISpace[""MF_d1_BankName""].Value + @""','"" + ISpace[""MF_d1_IFSCCode""].Value + @""','"" + ISpace[""MF_d1_BankDocument""].Value + @""','"" + ISpace[""MF_d1_TransactionNo""].Value + @""','"" + ISpace[""MF_d1_TransactionDate""].Value + @""','"" + ISpace[""MF_d1_TotalAmount""].Value + @""','"" + ISpace[""MF_d1_AdvanceAmount""].Value + @""','"" + ISpace[""MF_d1_TravelStatus""].Value + @""','"" + ISpace[""MF_d1_TSAmount""].Value + @""','"" + ISpace[""MF_d1_TSStatus""].Value + @""','"" + ISpace[""MF_d1_PITransactionNo""].Value + @""','"" + ISpace[""MF_d1_PITransactionDate""].Value + @""','"" + ISpace[""MF_d1_TSTransactionNo""].Value + @""','"" + ISpace[""MF_d1_TSTransactionDate""].Value + @""','"" + ISpace[""gv_userid""].Value + @""','"" + ISpace[""MF_d1_CreatedOn""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultE182AF12DAED4644A9FC9AA3381897FF!=null) && (resultE182AF12DAED4644A9FC9AA3381897FF.Count!=0))
{
if(resultE182AF12DAED4644A9FC9AA3381897FF.ContainsKey(0))
ISpace["ExecutionMessage"].Value = resultE182AF12DAED4644A9FC9AA3381897FF[0];
}
else{
ISpace["ExecutionMessage"].Value = null;
}
base.WriteDebugInfo(@"EXEC InnovaceNoCode..[GridSave_63762982-2C07-4E60-8D86-D3A35CA53EDA]   '@@gv_InstanceId','@@gv_ActivityMapId','63762982-2C07-4E60-8D86-D3A35CA53EDA'");

var querySource5D2551CDFD03487A81061EBC8385C05B =GetQueryExpressionDataSource("5D2551CD-FD03-487A-8106-1EBC8385C05B");
Dictionary<short,object> result5D2551CDFD03487A81061EBC8385C05B=iSpace.ExecuteQuery(querySource5D2551CDFD03487A81061EBC8385C05B,@"EXEC InnovaceNoCode..[GridSave_63762982-2C07-4E60-8D86-D3A35CA53EDA]   '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','63762982-2C07-4E60-8D86-D3A35CA53EDA'",false);

base.WriteDebugInfo(@"var querySource5D2551CDFD03487A81061EBC8385C05B =GetQueryExpressionDataSource(""5D2551CD-FD03-487A-8106-1EBC8385C05B"");Dictionary<short,object> result5D2551CDFD03487A81061EBC8385C05B=iSpace.ExecuteQuery(querySource5D2551CDFD03487A81061EBC8385C05B,@""EXEC InnovaceNoCode..[GridSave_63762982-2C07-4E60-8D86-D3A35CA53EDA]   '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','63762982-2C07-4E60-8D86-D3A35CA53EDA'"",false);");
base.WriteDebugInfo(@"");

if((result5D2551CDFD03487A81061EBC8385C05B!=null) && (result5D2551CDFD03487A81061EBC8385C05B.Count!=0))
{
if(result5D2551CDFD03487A81061EBC8385C05B.ContainsKey(0))
ISpace["MF_ErrId"].Value = result5D2551CDFD03487A81061EBC8385C05B[0];
if(result5D2551CDFD03487A81061EBC8385C05B.ContainsKey(1))
ISpace["MF_ErrMsg"].Value = result5D2551CDFD03487A81061EBC8385C05B[1];
if(result5D2551CDFD03487A81061EBC8385C05B.ContainsKey(0))
ISpace["ExecutionMessage"].Value = result5D2551CDFD03487A81061EBC8385C05B[0];
}
else{
ISpace["MF_ErrId"].Value = null;ISpace["MF_ErrMsg"].Value = null;ISpace["ExecutionMessage"].Value = null;
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_ErrId"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ErrId""].Value==1)");
ISpace["Message"].Value=String.Format(@"{0}",ISpace["MF_ErrMsg"].Value);
base.WriteDebugInfo(@"ISpace[""Message""].Value=String.Format(@""{0}"",ISpace[""MF_ErrMsg""].Value);");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
}
base.WriteDebugInfo(@"EXEC InnovaceNoCode..[GridSave_93B856A5-0D32-4A27-8B58-5BFE5FF0162C]   '@@gv_InstanceId','@@gv_ActivityMapId','93B856A5-0D32-4A27-8B58-5BFE5FF0162C'");

var querySourceB926676F6B9A4DFE933F733A15635C3F =GetQueryExpressionDataSource("B926676F-6B9A-4DFE-933F-733A15635C3F");
Dictionary<short,object> resultB926676F6B9A4DFE933F733A15635C3F=iSpace.ExecuteQuery(querySourceB926676F6B9A4DFE933F733A15635C3F,@"EXEC InnovaceNoCode..[GridSave_93B856A5-0D32-4A27-8B58-5BFE5FF0162C]   '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','93B856A5-0D32-4A27-8B58-5BFE5FF0162C'",false);

base.WriteDebugInfo(@"var querySourceB926676F6B9A4DFE933F733A15635C3F =GetQueryExpressionDataSource(""B926676F-6B9A-4DFE-933F-733A15635C3F"");Dictionary<short,object> resultB926676F6B9A4DFE933F733A15635C3F=iSpace.ExecuteQuery(querySourceB926676F6B9A4DFE933F733A15635C3F,@""EXEC InnovaceNoCode..[GridSave_93B856A5-0D32-4A27-8B58-5BFE5FF0162C]   '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','93B856A5-0D32-4A27-8B58-5BFE5FF0162C'"",false);");
base.WriteDebugInfo(@"");

if((resultB926676F6B9A4DFE933F733A15635C3F!=null) && (resultB926676F6B9A4DFE933F733A15635C3F.Count!=0))
{
if(resultB926676F6B9A4DFE933F733A15635C3F.ContainsKey(0))
ISpace["MF_ErrId"].Value = resultB926676F6B9A4DFE933F733A15635C3F[0];
if(resultB926676F6B9A4DFE933F733A15635C3F.ContainsKey(1))
ISpace["MF_ErrMsg"].Value = resultB926676F6B9A4DFE933F733A15635C3F[1];
if(resultB926676F6B9A4DFE933F733A15635C3F.ContainsKey(0))
ISpace["ExecutionMessage"].Value = resultB926676F6B9A4DFE933F733A15635C3F[0];
}
else{
ISpace["MF_ErrId"].Value = null;ISpace["MF_ErrMsg"].Value = null;ISpace["ExecutionMessage"].Value = null;
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_ErrId"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ErrId""].Value==1)");
ISpace["Message"].Value=String.Format(@"{0}",ISpace["MF_ErrMsg"].Value);
base.WriteDebugInfo(@"ISpace[""Message""].Value=String.Format(@""{0}"",ISpace[""MF_ErrMsg""].Value);");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
}
base.WriteDebugInfo(@"Exec [SaveTravelRequestDocuments] '@@gv_InstanceId','@@gv_ProcessMapId','@@gv_UserId'");

var querySource0e8ceab69d8fffd68fe03de1048b96a0 =GetQueryExpressionDataSource("0e8ceab6-9d8f-ffd6-8fe0-3de1048b96a0");
Dictionary<short,object> result0e8ceab69d8fffd68fe03de1048b96a0=iSpace.ExecuteQuery(querySource0e8ceab69d8fffd68fe03de1048b96a0,@"Exec [SaveTravelRequestDocuments] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','" + ISpace["gv_userid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource0e8ceab69d8fffd68fe03de1048b96a0 =GetQueryExpressionDataSource(""0e8ceab6-9d8f-ffd6-8fe0-3de1048b96a0"");Dictionary<short,object> result0e8ceab69d8fffd68fe03de1048b96a0=iSpace.ExecuteQuery(querySource0e8ceab69d8fffd68fe03de1048b96a0,@""Exec [SaveTravelRequestDocuments] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','"" + ISpace[""gv_userid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result0e8ceab69d8fffd68fe03de1048b96a0!=null) && (result0e8ceab69d8fffd68fe03de1048b96a0.Count!=0))
{
if(result0e8ceab69d8fffd68fe03de1048b96a0.ContainsKey(0))
ISpace["MF_ErrId"].Value = result0e8ceab69d8fffd68fe03de1048b96a0[0];
if(result0e8ceab69d8fffd68fe03de1048b96a0.ContainsKey(1))
ISpace["MF_ErrMsg"].Value = result0e8ceab69d8fffd68fe03de1048b96a0[1];
}
else{
ISpace["MF_ErrId"].Value = null;ISpace["MF_ErrMsg"].Value = null;
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_ErrId"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""MF_ErrId""].Value==1)");
ISpace["Message"].Value=String.Format(@"{0}",ISpace["MF_ErrMsg"].Value);
base.WriteDebugInfo(@"ISpace[""Message""].Value=String.Format(@""{0}"",ISpace[""MF_ErrMsg""].Value);");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
}
base.WriteDebugInfo(@"EXEC [UpsertProjectFundAllocation] '@@gv_InstanceId','@@gv_ProcessMapId','@@gv_UserId'");

var querySource94A94EAC199144639AD7CC6F7445F90A =GetQueryExpressionDataSource("94A94EAC-1991-4463-9AD7-CC6F7445F90A");
Dictionary<short,object> result94A94EAC199144639AD7CC6F7445F90A=iSpace.ExecuteQuery(querySource94A94EAC199144639AD7CC6F7445F90A,@"EXEC [UpsertProjectFundAllocation] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','" + ISpace["gv_userid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource94A94EAC199144639AD7CC6F7445F90A =GetQueryExpressionDataSource(""94A94EAC-1991-4463-9AD7-CC6F7445F90A"");Dictionary<short,object> result94A94EAC199144639AD7CC6F7445F90A=iSpace.ExecuteQuery(querySource94A94EAC199144639AD7CC6F7445F90A,@""EXEC [UpsertProjectFundAllocation] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','"" + ISpace[""gv_userid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result94A94EAC199144639AD7CC6F7445F90A!=null) && (result94A94EAC199144639AD7CC6F7445F90A.Count!=0))
{
if(result94A94EAC199144639AD7CC6F7445F90A.ContainsKey(0))
ISpace["PFM_ErrId"].Value = result94A94EAC199144639AD7CC6F7445F90A[0];
}
else{
ISpace["PFM_ErrId"].Value = null;
}
if(ISpace["WF_FlowType"].Value!="REJECT")
{
base.WriteDebugInfo(@"if(ISpace[""WF_FlowType""].Value!=""REJECT"")");
base.WriteDebugInfo(@"EXEC [UpdateCommitmentSpent] '@@gv_InstanceId'");

var querySource588a57f1a42385cbc854b18aee523e01 =GetQueryExpressionDataSource("588a57f1-a423-85cb-c854-b18aee523e01");
Dictionary<short,object> result588a57f1a42385cbc854b18aee523e01=iSpace.ExecuteQuery(querySource588a57f1a42385cbc854b18aee523e01,@"EXEC [UpdateCommitmentSpent] '" + ISpace["gv_instanceid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource588a57f1a42385cbc854b18aee523e01 =GetQueryExpressionDataSource(""588a57f1-a423-85cb-c854-b18aee523e01"");Dictionary<short,object> result588a57f1a42385cbc854b18aee523e01=iSpace.ExecuteQuery(querySource588a57f1a42385cbc854b18aee523e01,@""EXEC [UpdateCommitmentSpent] '"" + ISpace[""gv_instanceid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result588a57f1a42385cbc854b18aee523e01!=null) && (result588a57f1a42385cbc854b18aee523e01.Count!=0))
{
}
else{

}
}
ISpace["Message"].Value=@"Success: Submitted Successfully";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Success: Submitted Successfully"";");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC [UpdateTravelRequestStatus] '@@gv_InstanceId','@@gv_UserId','#WF_FlowType'");

var querySourcefbb131bf5cbf0eb86f44bf481055f5b7 =GetQueryExpressionDataSource("fbb131bf-5cbf-0eb8-6f44-bf481055f5b7");
Dictionary<short,object> resultfbb131bf5cbf0eb86f44bf481055f5b7=iSpace.ExecuteQuery(querySourcefbb131bf5cbf0eb86f44bf481055f5b7,@"EXEC [UpdateTravelRequestStatus] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_userid"].Value + @"','" + ISpace["WF_FlowType"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourcefbb131bf5cbf0eb86f44bf481055f5b7 =GetQueryExpressionDataSource(""fbb131bf-5cbf-0eb8-6f44-bf481055f5b7"");Dictionary<short,object> resultfbb131bf5cbf0eb86f44bf481055f5b7=iSpace.ExecuteQuery(querySourcefbb131bf5cbf0eb86f44bf481055f5b7,@""EXEC [UpdateTravelRequestStatus] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_userid""].Value + @""','"" + ISpace[""WF_FlowType""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultfbb131bf5cbf0eb86f44bf481055f5b7!=null) && (resultfbb131bf5cbf0eb86f44bf481055f5b7.Count!=0))
{
if(resultfbb131bf5cbf0eb86f44bf481055f5b7.ContainsKey(0))
ISpace["MF_ErrId"].Value = resultfbb131bf5cbf0eb86f44bf481055f5b7[0];
if(resultfbb131bf5cbf0eb86f44bf481055f5b7.ContainsKey(1))
ISpace["MF_ErrMsg"].Value = resultfbb131bf5cbf0eb86f44bf481055f5b7[1];
}
else{
ISpace["MF_ErrId"].Value = null;ISpace["MF_ErrMsg"].Value = null;
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
private void SubscribeElementEvents_fwab_projectno (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"FWAB_ProjectNo-OnChange");

var querySource15B473E55CD0469AB3B0C69EFCAF1CEB =GetQueryExpressionDataSource("15B473E5-5CD0-469A-B3B0-C69EFCAF1CEB");

DataTable result15B473E55CD0469AB3B0C69EFCAF1CEB=iSpace.SetGridDataSource(querySource15B473E55CD0469AB3B0C69EFCAF1CEB, _objectFactory.GetGridRPP("MG_AvailableBudget"),@"EXEC [GetProjectBudgetInformation] '" + ISpace["FWAB_ProjectNo"].Value + @"'");

iSpace.InsertGridBindDetails("MG_AvailableBudget","11",querySource15B473E55CD0469AB3B0C69EFCAF1CEB,"EXEC [GetProjectBudgetInformation] '" + ISpace["FWAB_ProjectNo"].Value + @"'",_objectFactory.GetGridRPP("MG_AvailableBudget"));

base.WriteDebugInfo(@"var querySource15B473E55CD0469AB3B0C69EFCAF1CEB =GetQueryExpressionDataSource(""15B473E5-5CD0-469A-B3B0-C69EFCAF1CEB"");DataTable result15B473E55CD0469AB3B0C69EFCAF1CEB=iSpace.SetGridDataSource(querySource15B473E55CD0469AB3B0C69EFCAF1CEB, _objectFactory.GetGridRPP(""MG_AvailableBudget""),@""EXEC [GetProjectBudgetInformation] '"" + ISpace[""FWAB_ProjectNo""].Value + @""'"");iSpace.InsertGridBindDetails(""MG_AvailableBudget"",""11"",querySource15B473E55CD0469AB3B0C69EFCAF1CEB,""EXEC [GetProjectBudgetInformation] '"" + ISpace[""FWAB_ProjectNo""].Value + @""'"",_objectFactory.GetGridRPP(""MG_AvailableBudget""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> resultFCFC08538E66474BA676F339F45380EF=acdataIspace53f8560140a83229820900367a5bc621.GetQueryExpressionBindings("FCFC0853-8E66-474B-A676-F339F45380EF");
iSpace.SetGridData(result15B473E55CD0469AB3B0C69EFCAF1CEB,resultFCFC08538E66474BA676F339F45380EF,"MG_AvailableBudget",ref ISpace);
iSpace.UpdateGridBindDetails("MG_AvailableBudget",resultFCFC08538E66474BA676F339F45380EF);
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mfg_d2_modeofjourney (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MFG_d2_ModeofJourney-OnChange");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["MFG_d2_JourneyClass"].rElemData=iSpace.Reload(ISpace["MFG_d2_JourneyClass"].Value,@"EXEC TravelClassCombo '" + ISpace["MFG_d2_ModeofJourney"].Value + @"'","3A103712-5244-4427-B2B6-1C4E046FD337");
base.WriteDebugInfo(@"ISpace[""MFG_d2_JourneyClass""].rElemData=iSpace.Reload(ISpace[""MFG_d2_JourneyClass""].Value,@""EXEC TravelClassCombo '"" + ISpace[""MFG_d2_ModeofJourney""].Value + @""'"",""3A103712-5244-4427-B2B6-1C4E046FD337"");");
}
if(ISpace["MFG_d2_ModeofJourney"].Value!="477")
{
base.WriteDebugInfo(@"if(ISpace[""MFG_d2_ModeofJourney""].Value!=""477"")");
ISpace["MFG_d2_Road"].Visible="false";
base.WriteDebugInfo(@"ISpace[""MFG_d2_Road""].Visible=""false"";");
ISpace["MFG_d2_Road"].Value=0;
base.WriteDebugInfo(@"ISpace[""MFG_d2_Road""].Value=0;");
}
if(ISpace["MFG_d2_ModeofJourney"].Value=="477")
{
base.WriteDebugInfo(@"if(ISpace[""MFG_d2_ModeofJourney""].Value==""477"")");
ISpace["MFG_d2_Road"].Visible="true";
base.WriteDebugInfo(@"ISpace[""MFG_d2_Road""].Visible=""true"";");
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_save_expensedetails (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Save_ExpenseDetails-OnClick");
if(ISpace["MFG_d3_ExpenditureType"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""MFG_d3_ExpenditureType""].Value=="""")");
ISpace["Message"].Value=@"Error: Please select the Expenditure Type";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Error: Please select the Expenditure Type"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if((ISpace["MFG_d3_FromDate"].Value == null))
{
base.WriteDebugInfo(@"if((ISpace[""MFG_d3_FromDate""].Value == null))");
ISpace["Message"].Value=@"Error: Please select the From Date";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Error: Please select the From Date"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if((ISpace["MFG_d3_ToDate"].Value == null))
{
base.WriteDebugInfo(@"if((ISpace[""MFG_d3_ToDate""].Value == null))");
ISpace["Message"].Value=@"Error: Please select the To Date";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Error: Please select the To Date"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if(ISpace["MFG_d3_Amount"].Value==0)
{
base.WriteDebugInfo(@"if(ISpace[""MFG_d3_Amount""].Value==0)");
ISpace["Message"].Value=@"Error: Please Enter the Amount";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Error: Please Enter the Amount"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if(ISpace["growid"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""growid""].Value=="""")");

var querySourceD7D51D5871D4428EA54AD52FA8744223 =GetQueryExpressionDataSource("D7D51D58-71D4-428E-A54A-D52FA8744223");

DataTable resultD7D51D5871D4428EA54AD52FA8744223=iSpace.SetGridDataSource(querySourceD7D51D5871D4428EA54AD52FA8744223, _objectFactory.GetGridRPP("ExpenseDetails"),@"EXEC [AddFormGridData63762982-2C07-4E60-8D86-D3A35CA53EDA] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','63762982-2C07-4E60-8D86-D3A35CA53EDA','" + ISpace["growid"].Value + @"'," + ISpace["ExpenseDetails_Sequence"].Value + @",'" + ISpace["MFG_d3_ExpenditureTypeID"].Value + @"','" + ISpace["MFG_d3_TravelAdvanceID"].Value + @"','" + ISpace["MFG_d3_FromDate"].Value + @"','" + ISpace["MFG_d3_ToDate"].Value + @"'," + ISpace["MFG_d3_Amount"].Value + @"," + ISpace["MFG_d3_UpdatedBy"].Value + @",'" + ISpace["MFG_d3_UpdatedOn"].Value + @"'," + ISpace["MFG_d3_ExpenditureType"].Value + @",'" + ISpace["MFG_d3_OtherExpenditureType"].Value + @"'," + ISpace["MFG_d3_IsTravelRequest"].Value + @"");

iSpace.InsertGridBindDetails("ExpenseDetails","11",querySourceD7D51D5871D4428EA54AD52FA8744223,"EXEC [AddFormGridData63762982-2C07-4E60-8D86-D3A35CA53EDA] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','63762982-2C07-4E60-8D86-D3A35CA53EDA','" + ISpace["growid"].Value + @"'," + ISpace["ExpenseDetails_Sequence"].Value + @",'" + ISpace["MFG_d3_ExpenditureTypeID"].Value + @"','" + ISpace["MFG_d3_TravelAdvanceID"].Value + @"','" + ISpace["MFG_d3_FromDate"].Value + @"','" + ISpace["MFG_d3_ToDate"].Value + @"'," + ISpace["MFG_d3_Amount"].Value + @"," + ISpace["MFG_d3_UpdatedBy"].Value + @",'" + ISpace["MFG_d3_UpdatedOn"].Value + @"'," + ISpace["MFG_d3_ExpenditureType"].Value + @",'" + ISpace["MFG_d3_OtherExpenditureType"].Value + @"'," + ISpace["MFG_d3_IsTravelRequest"].Value + @"",_objectFactory.GetGridRPP("ExpenseDetails"));

base.WriteDebugInfo(@"var querySourceD7D51D5871D4428EA54AD52FA8744223 =GetQueryExpressionDataSource(""D7D51D58-71D4-428E-A54A-D52FA8744223"");DataTable resultD7D51D5871D4428EA54AD52FA8744223=iSpace.SetGridDataSource(querySourceD7D51D5871D4428EA54AD52FA8744223, _objectFactory.GetGridRPP(""ExpenseDetails""),@""EXEC [AddFormGridData63762982-2C07-4E60-8D86-D3A35CA53EDA] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','63762982-2C07-4E60-8D86-D3A35CA53EDA','"" + ISpace[""growid""].Value + @""',"" + ISpace[""ExpenseDetails_Sequence""].Value + @"",'"" + ISpace[""MFG_d3_ExpenditureTypeID""].Value + @""','"" + ISpace[""MFG_d3_TravelAdvanceID""].Value + @""','"" + ISpace[""MFG_d3_FromDate""].Value + @""','"" + ISpace[""MFG_d3_ToDate""].Value + @""',"" + ISpace[""MFG_d3_Amount""].Value + @"","" + ISpace[""MFG_d3_UpdatedBy""].Value + @"",'"" + ISpace[""MFG_d3_UpdatedOn""].Value + @""',"" + ISpace[""MFG_d3_ExpenditureType""].Value + @"",'"" + ISpace[""MFG_d3_OtherExpenditureType""].Value + @""',"" + ISpace[""MFG_d3_IsTravelRequest""].Value + @"""");iSpace.InsertGridBindDetails(""ExpenseDetails"",""11"",querySourceD7D51D5871D4428EA54AD52FA8744223,""EXEC [AddFormGridData63762982-2C07-4E60-8D86-D3A35CA53EDA] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','63762982-2C07-4E60-8D86-D3A35CA53EDA','"" + ISpace[""growid""].Value + @""',"" + ISpace[""ExpenseDetails_Sequence""].Value + @"",'"" + ISpace[""MFG_d3_ExpenditureTypeID""].Value + @""','"" + ISpace[""MFG_d3_TravelAdvanceID""].Value + @""','"" + ISpace[""MFG_d3_FromDate""].Value + @""','"" + ISpace[""MFG_d3_ToDate""].Value + @""',"" + ISpace[""MFG_d3_Amount""].Value + @"","" + ISpace[""MFG_d3_UpdatedBy""].Value + @"",'"" + ISpace[""MFG_d3_UpdatedOn""].Value + @""',"" + ISpace[""MFG_d3_ExpenditureType""].Value + @"",'"" + ISpace[""MFG_d3_OtherExpenditureType""].Value + @""',"" + ISpace[""MFG_d3_IsTravelRequest""].Value + @"""",_objectFactory.GetGridRPP(""ExpenseDetails""));");
base.WriteDebugInfo(@"EXEC [AddFormGridData63762982-2C07-4E60-8D86-D3A35CA53EDA] '@@gv_InstanceId','@@gv_ActivityMapId','63762982-2C07-4E60-8D86-D3A35CA53EDA','#growid',#ExpenseDetails_Sequence,'#MFG_d3_ExpenditureTypeID','#MFG_d3_TravelAdvanceID','#MFG_d3_FromDate','#MFG_d3_ToDate',#MFG_d3_Amount,#MFG_d3_UpdatedBy,'#MFG_d3_UpdatedOn',#MFG_d3_ExpenditureType,'#MFG_d3_OtherExpenditureType',#MFG_d3_IsTravelRequest");


List<Triplet<string, short, short?>> result79298EDC73804DCABEFA54D2D36D148A=acdataIspace53f8560140a83229820900367a5bc621.GetQueryExpressionBindings("79298EDC-7380-4DCA-BEFA-54D2D36D148A");
iSpace.SetGridData(resultD7D51D5871D4428EA54AD52FA8744223,result79298EDC73804DCABEFA54D2D36D148A,"ExpenseDetails",ref ISpace);
iSpace.UpdateGridBindDetails("ExpenseDetails",result79298EDC73804DCABEFA54D2D36D148A);
}
else
{
base.WriteDebugInfo(@"else");

var querySourceDDAF997F6BE4424691A6BF443D4771D5 =GetQueryExpressionDataSource("DDAF997F-6BE4-4246-91A6-BF443D4771D5");

DataTable resultDDAF997F6BE4424691A6BF443D4771D5=iSpace.SetGridDataSource(querySourceDDAF997F6BE4424691A6BF443D4771D5, _objectFactory.GetGridRPP("ExpenseDetails"),@"EXEC [UpdateFormGridData63762982-2C07-4E60-8D86-D3A35CA53EDA] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','63762982-2C07-4E60-8D86-D3A35CA53EDA','" + ISpace["growid"].Value + @"'," + ISpace["ExpenseDetails_Sequence"].Value + @",'" + ISpace["MFG_d3_ExpenditureTypeID"].Value + @"','" + ISpace["MFG_d3_TravelAdvanceID"].Value + @"','" + ISpace["MFG_d3_FromDate"].Value + @"','" + ISpace["MFG_d3_ToDate"].Value + @"'," + ISpace["MFG_d3_Amount"].Value + @"," + ISpace["MFG_d3_UpdatedBy"].Value + @",'" + ISpace["MFG_d3_UpdatedOn"].Value + @"'," + ISpace["MFG_d3_ExpenditureType"].Value + @",'" + ISpace["MFG_d3_OtherExpenditureType"].Value + @"'," + ISpace["MFG_d3_IsTravelRequest"].Value + @"");

iSpace.InsertGridBindDetails("ExpenseDetails","11",querySourceDDAF997F6BE4424691A6BF443D4771D5,"EXEC [UpdateFormGridData63762982-2C07-4E60-8D86-D3A35CA53EDA] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','63762982-2C07-4E60-8D86-D3A35CA53EDA','" + ISpace["growid"].Value + @"'," + ISpace["ExpenseDetails_Sequence"].Value + @",'" + ISpace["MFG_d3_ExpenditureTypeID"].Value + @"','" + ISpace["MFG_d3_TravelAdvanceID"].Value + @"','" + ISpace["MFG_d3_FromDate"].Value + @"','" + ISpace["MFG_d3_ToDate"].Value + @"'," + ISpace["MFG_d3_Amount"].Value + @"," + ISpace["MFG_d3_UpdatedBy"].Value + @",'" + ISpace["MFG_d3_UpdatedOn"].Value + @"'," + ISpace["MFG_d3_ExpenditureType"].Value + @",'" + ISpace["MFG_d3_OtherExpenditureType"].Value + @"'," + ISpace["MFG_d3_IsTravelRequest"].Value + @"",_objectFactory.GetGridRPP("ExpenseDetails"));

base.WriteDebugInfo(@"var querySourceDDAF997F6BE4424691A6BF443D4771D5 =GetQueryExpressionDataSource(""DDAF997F-6BE4-4246-91A6-BF443D4771D5"");DataTable resultDDAF997F6BE4424691A6BF443D4771D5=iSpace.SetGridDataSource(querySourceDDAF997F6BE4424691A6BF443D4771D5, _objectFactory.GetGridRPP(""ExpenseDetails""),@""EXEC [UpdateFormGridData63762982-2C07-4E60-8D86-D3A35CA53EDA] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','63762982-2C07-4E60-8D86-D3A35CA53EDA','"" + ISpace[""growid""].Value + @""',"" + ISpace[""ExpenseDetails_Sequence""].Value + @"",'"" + ISpace[""MFG_d3_ExpenditureTypeID""].Value + @""','"" + ISpace[""MFG_d3_TravelAdvanceID""].Value + @""','"" + ISpace[""MFG_d3_FromDate""].Value + @""','"" + ISpace[""MFG_d3_ToDate""].Value + @""',"" + ISpace[""MFG_d3_Amount""].Value + @"","" + ISpace[""MFG_d3_UpdatedBy""].Value + @"",'"" + ISpace[""MFG_d3_UpdatedOn""].Value + @""',"" + ISpace[""MFG_d3_ExpenditureType""].Value + @"",'"" + ISpace[""MFG_d3_OtherExpenditureType""].Value + @""',"" + ISpace[""MFG_d3_IsTravelRequest""].Value + @"""");iSpace.InsertGridBindDetails(""ExpenseDetails"",""11"",querySourceDDAF997F6BE4424691A6BF443D4771D5,""EXEC [UpdateFormGridData63762982-2C07-4E60-8D86-D3A35CA53EDA] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','63762982-2C07-4E60-8D86-D3A35CA53EDA','"" + ISpace[""growid""].Value + @""',"" + ISpace[""ExpenseDetails_Sequence""].Value + @"",'"" + ISpace[""MFG_d3_ExpenditureTypeID""].Value + @""','"" + ISpace[""MFG_d3_TravelAdvanceID""].Value + @""','"" + ISpace[""MFG_d3_FromDate""].Value + @""','"" + ISpace[""MFG_d3_ToDate""].Value + @""',"" + ISpace[""MFG_d3_Amount""].Value + @"","" + ISpace[""MFG_d3_UpdatedBy""].Value + @"",'"" + ISpace[""MFG_d3_UpdatedOn""].Value + @""',"" + ISpace[""MFG_d3_ExpenditureType""].Value + @"",'"" + ISpace[""MFG_d3_OtherExpenditureType""].Value + @""',"" + ISpace[""MFG_d3_IsTravelRequest""].Value + @"""",_objectFactory.GetGridRPP(""ExpenseDetails""));");
base.WriteDebugInfo(@"EXEC [UpdateFormGridData63762982-2C07-4E60-8D86-D3A35CA53EDA] '@@gv_InstanceId','@@gv_ActivityMapId','63762982-2C07-4E60-8D86-D3A35CA53EDA','#growid',#ExpenseDetails_Sequence,'#MFG_d3_ExpenditureTypeID','#MFG_d3_TravelAdvanceID','#MFG_d3_FromDate','#MFG_d3_ToDate',#MFG_d3_Amount,#MFG_d3_UpdatedBy,'#MFG_d3_UpdatedOn',#MFG_d3_ExpenditureType,'#MFG_d3_OtherExpenditureType',#MFG_d3_IsTravelRequest");


List<Triplet<string, short, short?>> resultC21973820B3942FF967D813A615854D1=acdataIspace53f8560140a83229820900367a5bc621.GetQueryExpressionBindings("C2197382-0B39-42FF-967D-813A615854D1");
iSpace.SetGridData(resultDDAF997F6BE4424691A6BF443D4771D5,resultC21973820B3942FF967D813A615854D1,"ExpenseDetails",ref ISpace);
iSpace.UpdateGridBindDetails("ExpenseDetails",resultC21973820B3942FF967D813A615854D1);
}
ISpace["growid"].Value="";
base.WriteDebugInfo(@"ISpace[""growid""].Value="""";");
ISpace["MFG_d3_ExpenditureTypeID"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d3_ExpenditureTypeID""].Value="""";");
ISpace["MFG_d3_TravelAdvanceID"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d3_TravelAdvanceID""].Value="""";");
ISpace["MFG_d3_FromDate"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d3_FromDate""].Value="""";");
ISpace["MFG_d3_ToDate"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d3_ToDate""].Value="""";");
ISpace["MFG_d3_Amount"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d3_Amount""].Value="""";");
ISpace["MFG_d3_UpdatedBy"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d3_UpdatedBy""].Value="""";");
ISpace["MFG_d3_UpdatedOn"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d3_UpdatedOn""].Value="""";");
ISpace["MFG_d3_ExpenditureType"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d3_ExpenditureType""].Value="""";");
ISpace["MFG_d3_OtherExpenditureType"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d3_OtherExpenditureType""].Value="""";");
ISpace["MFG_d3_IsTravelRequest"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_d3_IsTravelRequest""].Value="""";");
object MG_d2_Amount=iSpace.Sum("[93B856A5-0D32-4A27-8B58-5BFE5FF0162C]","MG_d2_Amount","",ISpace["gv_instanceid"].Value);
ISpace["MF_TotaTravellExpense"].Value=Convert.ChangeType(MG_d2_Amount, MG_d2_Amount.GetType());;
base.WriteDebugInfo(@"object MG_d2_Amount=iSpace.Sum(""[93B856A5-0D32-4A27-8B58-5BFE5FF0162C]"",""MG_d2_Amount"","""",ISpace[""gv_instanceid""].Value);
ISpace[""MF_TotaTravellExpense""].Value=Convert.ChangeType(MG_d2_Amount, MG_d2_Amount.GetType());;");
object MG_d3_Amount=iSpace.Sum("[63762982-2C07-4E60-8D86-D3A35CA53EDA]","MG_d3_Amount","",ISpace["gv_instanceid"].Value);
ISpace["MF_TotalOtherExpense"].Value=Convert.ChangeType(MG_d3_Amount, MG_d3_Amount.GetType());;
base.WriteDebugInfo(@"object MG_d3_Amount=iSpace.Sum(""[63762982-2C07-4E60-8D86-D3A35CA53EDA]"",""MG_d3_Amount"","""",ISpace[""gv_instanceid""].Value);
ISpace[""MF_TotalOtherExpense""].Value=Convert.ChangeType(MG_d3_Amount, MG_d3_Amount.GetType());;");
ISpace["MF_d1_TotalAmount"].Value=ISpace["MF_TotaTravellExpense"].Value+ISpace["MF_TotalOtherExpense"].Value;
base.WriteDebugInfo(@"ISpace[""MF_d1_TotalAmount""].Value=ISpace[""MF_TotaTravellExpense""].Value+ISpace[""MF_TotalOtherExpense""].Value;");
ISpace["MF_EligibleAdavnce"].Value=ISpace["MF_d1_TotalAmount"].Value*90;
base.WriteDebugInfo(@"ISpace[""MF_EligibleAdavnce""].Value=ISpace[""MF_d1_TotalAmount""].Value*90;");
ISpace["MF_EligibleAdavnce"].Value=ISpace["MF_EligibleAdavnce"].Value/100;
base.WriteDebugInfo(@"ISpace[""MF_EligibleAdavnce""].Value=ISpace[""MF_EligibleAdavnce""].Value/100;");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mf_d1_isadvancerequired (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MF_d1_IsAdvanceRequired-OnChange");
if(ISpace["MF_d1_IsAdvanceRequired"].Value=="No")
{
base.WriteDebugInfo(@"if(ISpace[""MF_d1_IsAdvanceRequired""].Value==""No"")");
ISpace["MF_EligibleAdavnce"].Visible="false";ISpace["MF_d1_AdvanceAmount"].Visible="false";
base.WriteDebugInfo(@"ISpace[""MF_EligibleAdavnce""].Visible=""false"";ISpace[""MF_d1_AdvanceAmount""].Visible=""false"";");
}
if(ISpace["MF_d1_IsAdvanceRequired"].Value=="Yes")
{
base.WriteDebugInfo(@"if(ISpace[""MF_d1_IsAdvanceRequired""].Value==""Yes"")");
ISpace["MF_EligibleAdavnce"].Visible="true";ISpace["MF_d1_AdvanceAmount"].Visible="true";ISpace["MF_d1_AdvanceAmount"].Man=true;
base.WriteDebugInfo(@"ISpace[""MF_EligibleAdavnce""].Visible=""true"";ISpace[""MF_d1_AdvanceAmount""].Visible=""true"";ISpace[""MF_d1_AdvanceAmount""].Man=true;");
}
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
ISpace["WF_FlowType"].Value="APPROVE";
base.WriteDebugInfo(@"ISpace[""WF_FlowType""].Value=""APPROVE"";");
ISpace["Comments"].Man=false;
base.WriteDebugInfo(@"ISpace[""Comments""].Man=false;");
}
if(ISpace["WMF_MoveTo"].Value=="RETURN")
{
base.WriteDebugInfo(@"if(ISpace[""WMF_MoveTo""].Value==""RETURN"")");
ISpace["WF_FlowType"].Value="RETURN";
base.WriteDebugInfo(@"ISpace[""WF_FlowType""].Value=""RETURN"";");
ISpace["Comments"].Man=true;
base.WriteDebugInfo(@"ISpace[""Comments""].Man=true;");
}
if(ISpace["WMF_MoveTo"].Value=="REJECT")
{
base.WriteDebugInfo(@"if(ISpace[""WMF_MoveTo""].Value==""REJECT"")");
ISpace["WF_FlowType"].Value="REJECT";
base.WriteDebugInfo(@"ISpace[""WF_FlowType""].Value=""REJECT"";");
ISpace["Comments"].Man=true;
base.WriteDebugInfo(@"ISpace[""Comments""].Man=true;");
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_fwfm_fundtype (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"FWFM_FundType-OnChange");
if(ISpace["FWFM_FundType"].Value=="2")
{
base.WriteDebugInfo(@"if(ISpace[""FWFM_FundType""].Value==""2"")");
ISpace["FWFM_BudgetHead"].Visible="false";ISpace["FWFM_ProjectNo"].Visible="false";
base.WriteDebugInfo(@"ISpace[""FWFM_BudgetHead""].Visible=""false"";ISpace[""FWFM_ProjectNo""].Visible=""false"";");
ISpace["FWFM_BudgetHead"].Value="";
base.WriteDebugInfo(@"ISpace[""FWFM_BudgetHead""].Value="""";");
ISpace["FWFM_ProjectNo"].Value="";
base.WriteDebugInfo(@"ISpace[""FWFM_ProjectNo""].Value="""";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["FWFM_BudgetHead"].Visible="true";ISpace["FWFM_ProjectNo"].Visible="true";
base.WriteDebugInfo(@"ISpace[""FWFM_BudgetHead""].Visible=""true"";ISpace[""FWFM_ProjectNo""].Visible=""true"";");
}
if(ISpace["FWFM_FundType"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""FWFM_FundType""].Value=="""")");
ISpace["FWFM_BudgetHead"].Visible="false";ISpace["FWFM_ProjectNo"].Visible="false";ISpace["FWFM_Amount"].Visible="false";
base.WriteDebugInfo(@"ISpace[""FWFM_BudgetHead""].Visible=""false"";ISpace[""FWFM_ProjectNo""].Visible=""false"";ISpace[""FWFM_Amount""].Visible=""false"";");
}
if(ISpace["FormVersionId"].Value=="48D9155C-42D2-4414-AF53-3D00D9908DD4")
{
ISpace["UI_ApprovalHideRow"].Visible="false";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""48D9155C-42D2-4414-AF53-3D00D9908DD4"")
{
ISpace[""UI_ApprovalHideRow""].Visible=""false"";
}");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_pfa_delete (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"PFA_Delete-OnClick");
ISpace["PFM_FundDetailsId"].Value=ISpace["PFA_FundDetailsId"].Value;
base.WriteDebugInfo(@"ISpace[""PFM_FundDetailsId""].Value=ISpace[""PFA_FundDetailsId""].Value;");
ISpace["UI_DeleteDialog"].ShowDialog=true;;
base.WriteDebugInfo(@"ISpace[""UI_DeleteDialog""].ShowDialog=true;;");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_pfa_edit (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"PFA_Edit-OnClick");
base.WriteDebugInfo(@"Exec [Get60e821d0-153e-94bb-1fef-2594b78625bd] '@@gv_InstanceId','#PFA_FundDetailsId'");

var querySource1D7C9725F11C4C72BB58A7C49B33E1C9 =GetQueryExpressionDataSource("1D7C9725-F11C-4C72-BB58-A7C49B33E1C9");
Dictionary<short,object> result1D7C9725F11C4C72BB58A7C49B33E1C9=iSpace.ExecuteQuery(querySource1D7C9725F11C4C72BB58A7C49B33E1C9,@"Exec [Get60e821d0-153e-94bb-1fef-2594b78625bd] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["PFA_FundDetailsId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource1D7C9725F11C4C72BB58A7C49B33E1C9 =GetQueryExpressionDataSource(""1D7C9725-F11C-4C72-BB58-A7C49B33E1C9"");Dictionary<short,object> result1D7C9725F11C4C72BB58A7C49B33E1C9=iSpace.ExecuteQuery(querySource1D7C9725F11C4C72BB58A7C49B33E1C9,@""Exec [Get60e821d0-153e-94bb-1fef-2594b78625bd] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""PFA_FundDetailsId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result1D7C9725F11C4C72BB58A7C49B33E1C9!=null) && (result1D7C9725F11C4C72BB58A7C49B33E1C9.Count!=0))
{
if(result1D7C9725F11C4C72BB58A7C49B33E1C9.ContainsKey(9))
ISpace["FWFM_BudgetHead"].Value = result1D7C9725F11C4C72BB58A7C49B33E1C9[9];
if(result1D7C9725F11C4C72BB58A7C49B33E1C9.ContainsKey(7))
ISpace["FWFM_ProjectNo"].Value = result1D7C9725F11C4C72BB58A7C49B33E1C9[7];
if(result1D7C9725F11C4C72BB58A7C49B33E1C9.ContainsKey(5))
ISpace["FWFM_FundType"].Value = result1D7C9725F11C4C72BB58A7C49B33E1C9[5];
if(result1D7C9725F11C4C72BB58A7C49B33E1C9.ContainsKey(11))
ISpace["FWFM_Amount"].Value = result1D7C9725F11C4C72BB58A7C49B33E1C9[11];
if(result1D7C9725F11C4C72BB58A7C49B33E1C9.ContainsKey(3))
ISpace["FWFM_FundDetailsId"].Value = result1D7C9725F11C4C72BB58A7C49B33E1C9[3];
}
else{
ISpace["FWFM_BudgetHead"].Value = null;ISpace["FWFM_ProjectNo"].Value = null;ISpace["FWFM_FundType"].Value = null;ISpace["FWFM_Amount"].Value = null;ISpace["FWFM_FundDetailsId"].Value = null;
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mfg_d3_expendituretype (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MFG_d3_ExpenditureType-OnChange");
if(ISpace["MFG_d3_ExpenditureType"].Value!="1045")
{
base.WriteDebugInfo(@"if(ISpace[""MFG_d3_ExpenditureType""].Value!=""1045"")");
ISpace["MFG_d3_OtherExpenditureType"].Visible="false";
base.WriteDebugInfo(@"ISpace[""MFG_d3_OtherExpenditureType""].Visible=""false"";");
}
if(ISpace["MFG_d3_ExpenditureType"].Value=="1045")
{
base.WriteDebugInfo(@"if(ISpace[""MFG_d3_ExpenditureType""].Value==""1045"")");
ISpace["MFG_d3_OtherExpenditureType"].Visible="true";
base.WriteDebugInfo(@"ISpace[""MFG_d3_OtherExpenditureType""].Visible=""true"";");
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_edit_expensedetails (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Edit_ExpenseDetails-OnClick");
ISpace["growid"].Value=ISpace["ExpenseDetails_RowId"].Value;
base.WriteDebugInfo(@"ISpace[""growid""].Value=ISpace[""ExpenseDetails_RowId""].Value;");
base.WriteDebugInfo(@"EXEC [LoadFormGridData63762982-2C07-4E60-8D86-D3A35CA53EDA] '@@gv_InstanceId','@@gv_ActivityMapId','63762982-2C07-4E60-8D86-D3A35CA53EDA','#growid',#ExpenseDetails_Sequence");

var querySource1A41CC35C2E4455C98AF7868BC351B2C =GetQueryExpressionDataSource("1A41CC35-C2E4-455C-98AF-7868BC351B2C");
Dictionary<short,object> result1A41CC35C2E4455C98AF7868BC351B2C=iSpace.ExecuteQuery(querySource1A41CC35C2E4455C98AF7868BC351B2C,@"EXEC [LoadFormGridData63762982-2C07-4E60-8D86-D3A35CA53EDA] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_activitymapid"].Value + @"','63762982-2C07-4E60-8D86-D3A35CA53EDA','" + ISpace["growid"].Value + @"'," + ISpace["ExpenseDetails_Sequence"].Value + @"",false);

base.WriteDebugInfo(@"var querySource1A41CC35C2E4455C98AF7868BC351B2C =GetQueryExpressionDataSource(""1A41CC35-C2E4-455C-98AF-7868BC351B2C"");Dictionary<short,object> result1A41CC35C2E4455C98AF7868BC351B2C=iSpace.ExecuteQuery(querySource1A41CC35C2E4455C98AF7868BC351B2C,@""EXEC [LoadFormGridData63762982-2C07-4E60-8D86-D3A35CA53EDA] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_activitymapid""].Value + @""','63762982-2C07-4E60-8D86-D3A35CA53EDA','"" + ISpace[""growid""].Value + @""',"" + ISpace[""ExpenseDetails_Sequence""].Value + @"""",false);");
base.WriteDebugInfo(@"EXEC [LoadFormGridData63762982-2C07-4E60-8D86-D3A35CA53EDA] '@@gv_InstanceId','@@gv_ActivityMapId','63762982-2C07-4E60-8D86-D3A35CA53EDA','#growid',#ExpenseDetails_Sequence");

if((result1A41CC35C2E4455C98AF7868BC351B2C!=null) && (result1A41CC35C2E4455C98AF7868BC351B2C.Count!=0))
{
if(result1A41CC35C2E4455C98AF7868BC351B2C.ContainsKey(2))
ISpace["MFG_d3_FromDate"].Value = result1A41CC35C2E4455C98AF7868BC351B2C[2];
if(result1A41CC35C2E4455C98AF7868BC351B2C.ContainsKey(6))
ISpace["MFG_d3_UpdatedOn"].Value = result1A41CC35C2E4455C98AF7868BC351B2C[6];
if(result1A41CC35C2E4455C98AF7868BC351B2C.ContainsKey(3))
ISpace["MFG_d3_ToDate"].Value = result1A41CC35C2E4455C98AF7868BC351B2C[3];
if(result1A41CC35C2E4455C98AF7868BC351B2C.ContainsKey(7))
ISpace["MFG_d3_ExpenditureType"].Value = result1A41CC35C2E4455C98AF7868BC351B2C[7];
if(result1A41CC35C2E4455C98AF7868BC351B2C.ContainsKey(4))
ISpace["MFG_d3_Amount"].Value = result1A41CC35C2E4455C98AF7868BC351B2C[4];
if(result1A41CC35C2E4455C98AF7868BC351B2C.ContainsKey(9))
ISpace["MFG_d3_IsTravelRequest"].Value = result1A41CC35C2E4455C98AF7868BC351B2C[9];
if(result1A41CC35C2E4455C98AF7868BC351B2C.ContainsKey(5))
ISpace["MFG_d3_UpdatedBy"].Value = result1A41CC35C2E4455C98AF7868BC351B2C[5];
if(result1A41CC35C2E4455C98AF7868BC351B2C.ContainsKey(1))
ISpace["MFG_d3_TravelAdvanceID"].Value = result1A41CC35C2E4455C98AF7868BC351B2C[1];
if(result1A41CC35C2E4455C98AF7868BC351B2C.ContainsKey(0))
ISpace["MFG_d3_ExpenditureTypeID"].Value = result1A41CC35C2E4455C98AF7868BC351B2C[0];
if(result1A41CC35C2E4455C98AF7868BC351B2C.ContainsKey(8))
ISpace["MFG_d3_OtherExpenditureType"].Value = result1A41CC35C2E4455C98AF7868BC351B2C[8];
}
else{
ISpace["MFG_d3_FromDate"].Value = null;ISpace["MFG_d3_UpdatedOn"].Value = null;ISpace["MFG_d3_ToDate"].Value = null;ISpace["MFG_d3_ExpenditureType"].Value = null;ISpace["MFG_d3_Amount"].Value = null;ISpace["MFG_d3_IsTravelRequest"].Value = null;ISpace["MFG_d3_UpdatedBy"].Value = null;ISpace["MFG_d3_TravelAdvanceID"].Value = null;ISpace["MFG_d3_ExpenditureTypeID"].Value = null;ISpace["MFG_d3_OtherExpenditureType"].Value = null;
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
		if(elementName.ToLower().Equals("fwfm_projectno"))
    {
    			SubscribeElementEvents_fwfm_projectno(ref dfsParam);
    }
		if(elementName.ToLower().Equals("fwab_projectno"))
    {
    			SubscribeElementEvents_fwab_projectno(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mfg_d2_modeofjourney"))
    {
    			SubscribeElementEvents_mfg_d2_modeofjourney(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mf_d1_isadvancerequired"))
    {
    			SubscribeElementEvents_mf_d1_isadvancerequired(ref dfsParam);
    }
		if(elementName.ToLower().Equals("wmf_moveto"))
    {
    			SubscribeElementEvents_wmf_moveto(ref dfsParam);
    }
		if(elementName.ToLower().Equals("fwfm_fundtype"))
    {
    			SubscribeElementEvents_fwfm_fundtype(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mfg_d3_expendituretype"))
    {
    			SubscribeElementEvents_mfg_d3_expendituretype(ref dfsParam);
    }
}
	if(methodName.ToLower().Equals("onclick"))
{
		if(elementName.ToLower().Equals("fwfm_save"))
{
			SubscribeElementEvents_fwfm_save(ref dfsParam);
}
		if(elementName.ToLower().Equals("pfa_widgetsubmit"))
{
			SubscribeElementEvents_pfa_widgetsubmit(ref dfsParam);
}
		if(elementName.ToLower().Equals("wmf_history"))
{
			SubscribeElementEvents_wmf_history(ref dfsParam);
}
		if(elementName.ToLower().Equals("pfm_yes"))
{
			SubscribeElementEvents_pfm_yes(ref dfsParam);
}
		if(elementName.ToLower().Equals("fwmf_availablebudget"))
{
			SubscribeElementEvents_fwmf_availablebudget(ref dfsParam);
}
		if(elementName.ToLower().Equals("save_advancedetails"))
{
			SubscribeElementEvents_save_advancedetails(ref dfsParam);
}
		if(elementName.ToLower().Equals("edit_advancedetails"))
{
			SubscribeElementEvents_edit_advancedetails(ref dfsParam);
}
		if(elementName.ToLower().Equals("pfm_no"))
{
			SubscribeElementEvents_pfm_no(ref dfsParam);
}
		if(elementName.ToLower().Equals("submitform"))
{
			SubscribeElementEvents_submitform(ref dfsParam);
}
		if(elementName.ToLower().Equals("save_expensedetails"))
{
			SubscribeElementEvents_save_expensedetails(ref dfsParam);
}
		if(elementName.ToLower().Equals("pfa_delete"))
{
			SubscribeElementEvents_pfa_delete(ref dfsParam);
}
		if(elementName.ToLower().Equals("pfa_edit"))
{
			SubscribeElementEvents_pfa_edit(ref dfsParam);
}
		if(elementName.ToLower().Equals("edit_expensedetails"))
{
			SubscribeElementEvents_edit_expensedetails(ref dfsParam);
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


	public partial class AcDataISpaceF1E219523E9A4F379C422F86E1775788  : ExtensionActivityBase
	{		
		
		
		private Dictionary<string,  List<Triplet<string, short, short?>>> queryExpressionBindings = 
											new Dictionary<string,  List<Triplet<string, short, short?>>>
		{
							{"9E3B6B37-E973-48C3-8A15-8354D2CC4DEF", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_d3_UpdatedOn",6,
														   -1),
								   new Triplet<string, short, short?>("MG_d3_OtherExpenditureType",8,
														   -1),
								   new Triplet<string, short, short?>("MG_d3_Amount",4,
														   -1),
								   new Triplet<string, short, short?>("MG_d3_TravelAdvanceID",1,
														   -1),
								   new Triplet<string, short, short?>("MG_d3_FromDate",2,
														   -1),
								   new Triplet<string, short, short?>("MG_d3_UpdatedBy",5,
														   -1),
								   new Triplet<string, short, short?>("MG_d3_IsTravelRequest",9,
														   -1),
								   new Triplet<string, short, short?>("MG_d3_ExpenditureType",7,
														   -1),
								   new Triplet<string, short, short?>("MG_d3_ExpenditureTypeID",0,
														   -1),
								   new Triplet<string, short, short?>("MG_d3_ToDate",3,
														   -1),
								   new Triplet<string, short, short?>("ExpenseDetails_RowId",10,
														   -1),
								}
			},
							{"A86C8422-ADD9-44BA-B612-C8D9EDB841C5", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_d2_Amount",12,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_ArrivalTime",7,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_Arrival",5,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_IsTravelRequest",13,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_JourneyClass",9,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_DepartureTime",4,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_ArrivalDate",6,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_DepartureDate",3,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_TADetailsID",0,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_ModeofJourney",8,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_PNRNo",11,
														   -1),
								   new Triplet<string, short, short?>("AdvanceDetails_RowId",16,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_Departure",2,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_UpdatedBy",14,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_TravelAdvanceID",1,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_Road",10,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_UpdatedOn",15,
														   -1),
								}
			},
							{"FCFC0853-8E66-474B-A676-F339F45380EF", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("PAB_YetToRecieve",2,
														   -1),
								   new Triplet<string, short, short?>("PAB_RecievedAmount",3,
														   -1),
								   new Triplet<string, short, short?>("PAB_Spent",5,
														   -1),
								   new Triplet<string, short, short?>("PAB_Commitment",4,
														   -1),
								   new Triplet<string, short, short?>("PAB_SanctionedAmount",1,
														   -1),
								   new Triplet<string, short, short?>("PAB_BudgetName",0,
														   -1),
								   new Triplet<string, short, short?>("PAB_Balance",6,
														   -1),
								}
			},
							{"79298EDC-7380-4DCA-BEFA-54D2D36D148A", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_d3_IsTravelRequest",9,
														   -1),
								   new Triplet<string, short, short?>("ExpenseDetails_RowId",10,
														   -1),
								   new Triplet<string, short, short?>("MG_d3_Amount",4,
														   -1),
								   new Triplet<string, short, short?>("MG_d3_OtherExpenditureType",8,
														   -1),
								   new Triplet<string, short, short?>("MG_d3_TravelAdvanceID",1,
														   -1),
								   new Triplet<string, short, short?>("MG_d3_UpdatedOn",6,
														   -1),
								   new Triplet<string, short, short?>("MG_d3_UpdatedBy",5,
														   -1),
								   new Triplet<string, short, short?>("MG_d3_ExpenditureType",7,
														   -1),
								   new Triplet<string, short, short?>("MG_d3_ToDate",3,
														   -1),
								   new Triplet<string, short, short?>("MG_d3_ExpenditureTypeID",0,
														   -1),
								   new Triplet<string, short, short?>("MG_d3_FromDate",2,
														   -1),
								}
			},
							{"FAA6C5FB-3ED2-4177-8B27-6EA6EA73C8C5", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_d2_IsTravelRequest",13,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_Amount",12,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_ModeofJourney",8,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_JourneyClass",9,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_TADetailsID",0,
														   -1),
								   new Triplet<string, short, short?>("AdvanceDetails_RowId",16,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_Departure",2,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_PNRNo",11,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_ArrivalTime",7,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_Arrival",5,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_UpdatedBy",14,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_TravelAdvanceID",1,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_DepartureDate",3,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_Road",10,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_ArrivalDate",6,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_UpdatedOn",15,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_DepartureTime",4,
														   -1),
								}
			},
							{"D3F13653-5A71-4FF7-87CF-7CCF34A9151A", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_d2_Arrival",5,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_Amount",12,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_DepartureDate",3,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_ModeofJourney",8,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_ArrivalDate",6,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_PNRNo",11,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_UpdatedOn",15,
														   -1),
								   new Triplet<string, short, short?>("AdvanceDetails_RowId",16,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_UpdatedBy",14,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_TADetailsID",0,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_Departure",2,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_ArrivalTime",7,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_Road",10,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_TravelAdvanceID",1,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_IsTravelRequest",13,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_DepartureTime",4,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_JourneyClass",9,
														   -1),
								}
			},
							{"C2197382-0B39-42FF-967D-813A615854D1", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_d3_IsTravelRequest",9,
														   -1),
								   new Triplet<string, short, short?>("MG_d3_FromDate",2,
														   -1),
								   new Triplet<string, short, short?>("MG_d3_Amount",4,
														   -1),
								   new Triplet<string, short, short?>("MG_d3_ToDate",3,
														   -1),
								   new Triplet<string, short, short?>("MG_d3_ExpenditureType",7,
														   -1),
								   new Triplet<string, short, short?>("ExpenseDetails_RowId",10,
														   -1),
								   new Triplet<string, short, short?>("MG_d3_TravelAdvanceID",1,
														   -1),
								   new Triplet<string, short, short?>("MG_d3_UpdatedBy",5,
														   -1),
								   new Triplet<string, short, short?>("MG_d3_UpdatedOn",6,
														   -1),
								   new Triplet<string, short, short?>("MG_d3_ExpenditureTypeID",0,
														   -1),
								   new Triplet<string, short, short?>("MG_d3_OtherExpenditureType",8,
														   -1),
								}
			},
							{"25891B74-08F4-4F71-BE61-36CEA4C143EC", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("PFA_Amount",11,
														   -1),
								   new Triplet<string, short, short?>("PFA_ProjectNoValue",8,
														   -1),
								   new Triplet<string, short, short?>("MG_FundAllocation_RowId",3,
														   -1),
								   new Triplet<string, short, short?>("PFA_FundDetailsId",12,
														   -1),
								   new Triplet<string, short, short?>("PFA_FundTypeValue",6,
														   -1),
								   new Triplet<string, short, short?>("PFA_ProjectNo",7,
														   -1),
								   new Triplet<string, short, short?>("PFA_FundType",5,
														   -1),
								   new Triplet<string, short, short?>("PFA_BudgetHeadValue",10,
														   -1),
								   new Triplet<string, short, short?>("PFA_BudgetHead",9,
														   -1),
								}
			},
							{"794A7328-890E-42A3-B11A-5984B2D49196", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("WMC_DateofComments",4,
														   -1),
								   new Triplet<string, short, short?>("WMC_Comments",5,
														   -1),
								   new Triplet<string, short, short?>("WMC_StepTo",2,
														   -1),
								   new Triplet<string, short, short?>("WMC_User",3,
														   -1),
								   new Triplet<string, short, short?>("WMC_StepFrom",1,
														   -1),
								}
			},
					};	

	

		private Dictionary<string,string> formVersionList =new Dictionary<string,string> 
		{
							{"48D9155C-42D2-4414-AF53-3D00D9908DD4", "Medium"},
					};	

		
		private Dictionary<string,string> formVersionLayoutList =new Dictionary<string,string> 
		{
							{"8B5E7D64-27A5-47EC-AA51-6B0C9FE60F8B", ""},
							{"C09BB3BF-5B1D-4159-A21D-D9F47B2384A3", ""},
							{"48D9155C-42D2-4414-AF53-3D00D9908DD4", ""},
							{"EAD3F27A-81C8-4887-9A84-B78392BE5185", ""},
							{"DAF566B2-97D0-46E2-AE1C-6519FF641BC5", ""},
							{"CBA147CF-E1CD-4D0A-9CDB-076831CC605E", ""},
							{"A97604B2-DA94-49B4-993D-8CCCAF6FEA82", ""},
							{"DAF433BE-67AC-476C-B3F4-C758B6AB75D5", ""},
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


	public partial class AcDataISpace34A8F37F24BF4316826BDF78EE6E8579  : ExtensionActivityBase
	{		
		
		
		private Dictionary<string,  List<Triplet<string, short, short?>>> queryExpressionBindings = 
											new Dictionary<string,  List<Triplet<string, short, short?>>>
		{
							{"FCFC0853-8E66-474B-A676-F339F45380EF", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("PAB_YetToRecieve",2,
														   -1),
								   new Triplet<string, short, short?>("PAB_RecievedAmount",3,
														   -1),
								   new Triplet<string, short, short?>("PAB_Spent",5,
														   -1),
								   new Triplet<string, short, short?>("PAB_Commitment",4,
														   -1),
								   new Triplet<string, short, short?>("PAB_SanctionedAmount",1,
														   -1),
								   new Triplet<string, short, short?>("PAB_BudgetName",0,
														   -1),
								   new Triplet<string, short, short?>("PAB_Balance",6,
														   -1),
								}
			},
							{"25891B74-08F4-4F71-BE61-36CEA4C143EC", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("PFA_Amount",11,
														   -1),
								   new Triplet<string, short, short?>("PFA_ProjectNoValue",8,
														   -1),
								   new Triplet<string, short, short?>("MG_FundAllocation_RowId",3,
														   -1),
								   new Triplet<string, short, short?>("PFA_FundDetailsId",12,
														   -1),
								   new Triplet<string, short, short?>("PFA_FundTypeValue",6,
														   -1),
								   new Triplet<string, short, short?>("PFA_ProjectNo",7,
														   -1),
								   new Triplet<string, short, short?>("PFA_FundType",5,
														   -1),
								   new Triplet<string, short, short?>("PFA_BudgetHeadValue",10,
														   -1),
								   new Triplet<string, short, short?>("PFA_BudgetHead",9,
														   -1),
								}
			},
							{"794A7328-890E-42A3-B11A-5984B2D49196", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("WMC_DateofComments",4,
														   -1),
								   new Triplet<string, short, short?>("WMC_Comments",5,
														   -1),
								   new Triplet<string, short, short?>("WMC_StepTo",2,
														   -1),
								   new Triplet<string, short, short?>("WMC_User",3,
														   -1),
								   new Triplet<string, short, short?>("WMC_StepFrom",1,
														   -1),
								}
			},
					};	

	

		private Dictionary<string,string> formVersionList =new Dictionary<string,string> 
		{
							{"48D9155C-42D2-4414-AF53-3D00D9908DD4", "Medium"},
					};	

		
		private Dictionary<string,string> formVersionLayoutList =new Dictionary<string,string> 
		{
							{"8B5E7D64-27A5-47EC-AA51-6B0C9FE60F8B", ""},
							{"C09BB3BF-5B1D-4159-A21D-D9F47B2384A3", ""},
							{"48D9155C-42D2-4414-AF53-3D00D9908DD4", ""},
							{"EAD3F27A-81C8-4887-9A84-B78392BE5185", ""},
							{"DAF566B2-97D0-46E2-AE1C-6519FF641BC5", ""},
							{"CBA147CF-E1CD-4D0A-9CDB-076831CC605E", ""},
							{"A97604B2-DA94-49B4-993D-8CCCAF6FEA82", ""},
							{"DAF433BE-67AC-476C-B3F4-C758B6AB75D5", ""},
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


	public partial class AcDataISpaceA09DFE7057414CBDA7B76CCED54DCE3D  : ExtensionActivityBase
	{		
		
		
		private Dictionary<string,  List<Triplet<string, short, short?>>> queryExpressionBindings = 
											new Dictionary<string,  List<Triplet<string, short, short?>>>
		{
							{"FCFC0853-8E66-474B-A676-F339F45380EF", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("PAB_YetToRecieve",2,
														   -1),
								   new Triplet<string, short, short?>("PAB_RecievedAmount",3,
														   -1),
								   new Triplet<string, short, short?>("PAB_Spent",5,
														   -1),
								   new Triplet<string, short, short?>("PAB_Commitment",4,
														   -1),
								   new Triplet<string, short, short?>("PAB_SanctionedAmount",1,
														   -1),
								   new Triplet<string, short, short?>("PAB_BudgetName",0,
														   -1),
								   new Triplet<string, short, short?>("PAB_Balance",6,
														   -1),
								}
			},
							{"25891B74-08F4-4F71-BE61-36CEA4C143EC", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("PFA_Amount",11,
														   -1),
								   new Triplet<string, short, short?>("PFA_ProjectNoValue",8,
														   -1),
								   new Triplet<string, short, short?>("MG_FundAllocation_RowId",3,
														   -1),
								   new Triplet<string, short, short?>("PFA_FundDetailsId",12,
														   -1),
								   new Triplet<string, short, short?>("PFA_FundTypeValue",6,
														   -1),
								   new Triplet<string, short, short?>("PFA_ProjectNo",7,
														   -1),
								   new Triplet<string, short, short?>("PFA_FundType",5,
														   -1),
								   new Triplet<string, short, short?>("PFA_BudgetHeadValue",10,
														   -1),
								   new Triplet<string, short, short?>("PFA_BudgetHead",9,
														   -1),
								}
			},
							{"794A7328-890E-42A3-B11A-5984B2D49196", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("WMC_DateofComments",4,
														   -1),
								   new Triplet<string, short, short?>("WMC_Comments",5,
														   -1),
								   new Triplet<string, short, short?>("WMC_StepTo",2,
														   -1),
								   new Triplet<string, short, short?>("WMC_User",3,
														   -1),
								   new Triplet<string, short, short?>("WMC_StepFrom",1,
														   -1),
								}
			},
					};	

	

		private Dictionary<string,string> formVersionList =new Dictionary<string,string> 
		{
							{"48D9155C-42D2-4414-AF53-3D00D9908DD4", "Medium"},
					};	

		
		private Dictionary<string,string> formVersionLayoutList =new Dictionary<string,string> 
		{
							{"8B5E7D64-27A5-47EC-AA51-6B0C9FE60F8B", ""},
							{"C09BB3BF-5B1D-4159-A21D-D9F47B2384A3", ""},
							{"48D9155C-42D2-4414-AF53-3D00D9908DD4", ""},
							{"EAD3F27A-81C8-4887-9A84-B78392BE5185", ""},
							{"DAF566B2-97D0-46E2-AE1C-6519FF641BC5", ""},
							{"CBA147CF-E1CD-4D0A-9CDB-076831CC605E", ""},
							{"A97604B2-DA94-49B4-993D-8CCCAF6FEA82", ""},
							{"DAF433BE-67AC-476C-B3F4-C758B6AB75D5", ""},
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


	public partial class AcDataISpaceC1E33E745080471B9D135EC3EC7C54E8  : ExtensionActivityBase
	{		
		
		
		private Dictionary<string,  List<Triplet<string, short, short?>>> queryExpressionBindings = 
											new Dictionary<string,  List<Triplet<string, short, short?>>>
		{
							{"FCFC0853-8E66-474B-A676-F339F45380EF", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("PAB_YetToRecieve",2,
														   -1),
								   new Triplet<string, short, short?>("PAB_RecievedAmount",3,
														   -1),
								   new Triplet<string, short, short?>("PAB_Spent",5,
														   -1),
								   new Triplet<string, short, short?>("PAB_Commitment",4,
														   -1),
								   new Triplet<string, short, short?>("PAB_SanctionedAmount",1,
														   -1),
								   new Triplet<string, short, short?>("PAB_BudgetName",0,
														   -1),
								   new Triplet<string, short, short?>("PAB_Balance",6,
														   -1),
								}
			},
							{"25891B74-08F4-4F71-BE61-36CEA4C143EC", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("PFA_Amount",11,
														   -1),
								   new Triplet<string, short, short?>("PFA_ProjectNoValue",8,
														   -1),
								   new Triplet<string, short, short?>("MG_FundAllocation_RowId",3,
														   -1),
								   new Triplet<string, short, short?>("PFA_FundDetailsId",12,
														   -1),
								   new Triplet<string, short, short?>("PFA_FundTypeValue",6,
														   -1),
								   new Triplet<string, short, short?>("PFA_ProjectNo",7,
														   -1),
								   new Triplet<string, short, short?>("PFA_FundType",5,
														   -1),
								   new Triplet<string, short, short?>("PFA_BudgetHeadValue",10,
														   -1),
								   new Triplet<string, short, short?>("PFA_BudgetHead",9,
														   -1),
								}
			},
							{"794A7328-890E-42A3-B11A-5984B2D49196", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("WMC_DateofComments",4,
														   -1),
								   new Triplet<string, short, short?>("WMC_Comments",5,
														   -1),
								   new Triplet<string, short, short?>("WMC_StepTo",2,
														   -1),
								   new Triplet<string, short, short?>("WMC_User",3,
														   -1),
								   new Triplet<string, short, short?>("WMC_StepFrom",1,
														   -1),
								}
			},
					};	

	

		private Dictionary<string,string> formVersionList =new Dictionary<string,string> 
		{
							{"48D9155C-42D2-4414-AF53-3D00D9908DD4", "Medium"},
					};	

		
		private Dictionary<string,string> formVersionLayoutList =new Dictionary<string,string> 
		{
							{"8B5E7D64-27A5-47EC-AA51-6B0C9FE60F8B", ""},
							{"C09BB3BF-5B1D-4159-A21D-D9F47B2384A3", ""},
							{"48D9155C-42D2-4414-AF53-3D00D9908DD4", ""},
							{"EAD3F27A-81C8-4887-9A84-B78392BE5185", ""},
							{"DAF566B2-97D0-46E2-AE1C-6519FF641BC5", ""},
							{"CBA147CF-E1CD-4D0A-9CDB-076831CC605E", ""},
							{"A97604B2-DA94-49B4-993D-8CCCAF6FEA82", ""},
							{"DAF433BE-67AC-476C-B3F4-C758B6AB75D5", ""},
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


	public partial class AcDataISpace82118DD85B264EE28171D616101898A6  : ExtensionActivityBase
	{		
		
		
		private Dictionary<string,  List<Triplet<string, short, short?>>> queryExpressionBindings = 
											new Dictionary<string,  List<Triplet<string, short, short?>>>
		{
							{"FCFC0853-8E66-474B-A676-F339F45380EF", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("PAB_YetToRecieve",2,
														   -1),
								   new Triplet<string, short, short?>("PAB_RecievedAmount",3,
														   -1),
								   new Triplet<string, short, short?>("PAB_Spent",5,
														   -1),
								   new Triplet<string, short, short?>("PAB_Commitment",4,
														   -1),
								   new Triplet<string, short, short?>("PAB_SanctionedAmount",1,
														   -1),
								   new Triplet<string, short, short?>("PAB_BudgetName",0,
														   -1),
								   new Triplet<string, short, short?>("PAB_Balance",6,
														   -1),
								}
			},
							{"25891B74-08F4-4F71-BE61-36CEA4C143EC", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("PFA_Amount",11,
														   -1),
								   new Triplet<string, short, short?>("PFA_ProjectNoValue",8,
														   -1),
								   new Triplet<string, short, short?>("MG_FundAllocation_RowId",3,
														   -1),
								   new Triplet<string, short, short?>("PFA_FundDetailsId",12,
														   -1),
								   new Triplet<string, short, short?>("PFA_FundTypeValue",6,
														   -1),
								   new Triplet<string, short, short?>("PFA_ProjectNo",7,
														   -1),
								   new Triplet<string, short, short?>("PFA_FundType",5,
														   -1),
								   new Triplet<string, short, short?>("PFA_BudgetHeadValue",10,
														   -1),
								   new Triplet<string, short, short?>("PFA_BudgetHead",9,
														   -1),
								}
			},
							{"794A7328-890E-42A3-B11A-5984B2D49196", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("WMC_DateofComments",4,
														   -1),
								   new Triplet<string, short, short?>("WMC_Comments",5,
														   -1),
								   new Triplet<string, short, short?>("WMC_StepTo",2,
														   -1),
								   new Triplet<string, short, short?>("WMC_User",3,
														   -1),
								   new Triplet<string, short, short?>("WMC_StepFrom",1,
														   -1),
								}
			},
					};	

	

		private Dictionary<string,string> formVersionList =new Dictionary<string,string> 
		{
							{"48D9155C-42D2-4414-AF53-3D00D9908DD4", "Medium"},
					};	

		
		private Dictionary<string,string> formVersionLayoutList =new Dictionary<string,string> 
		{
							{"8B5E7D64-27A5-47EC-AA51-6B0C9FE60F8B", ""},
							{"C09BB3BF-5B1D-4159-A21D-D9F47B2384A3", ""},
							{"48D9155C-42D2-4414-AF53-3D00D9908DD4", ""},
							{"EAD3F27A-81C8-4887-9A84-B78392BE5185", ""},
							{"DAF566B2-97D0-46E2-AE1C-6519FF641BC5", ""},
							{"CBA147CF-E1CD-4D0A-9CDB-076831CC605E", ""},
							{"A97604B2-DA94-49B4-993D-8CCCAF6FEA82", ""},
							{"DAF433BE-67AC-476C-B3F4-C758B6AB75D5", ""},
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


	public partial class AcDataISpace98d8749ef1dc685b350935353f8b3c3d  : ExtensionActivityBase
	{		
		
		
		private Dictionary<string,  List<Triplet<string, short, short?>>> queryExpressionBindings = 
											new Dictionary<string,  List<Triplet<string, short, short?>>>
		{
							{"FCFC0853-8E66-474B-A676-F339F45380EF", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("PAB_YetToRecieve",2,
														   -1),
								   new Triplet<string, short, short?>("PAB_RecievedAmount",3,
														   -1),
								   new Triplet<string, short, short?>("PAB_Spent",5,
														   -1),
								   new Triplet<string, short, short?>("PAB_Commitment",4,
														   -1),
								   new Triplet<string, short, short?>("PAB_SanctionedAmount",1,
														   -1),
								   new Triplet<string, short, short?>("PAB_BudgetName",0,
														   -1),
								   new Triplet<string, short, short?>("PAB_Balance",6,
														   -1),
								}
			},
							{"25891B74-08F4-4F71-BE61-36CEA4C143EC", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("PFA_Amount",11,
														   -1),
								   new Triplet<string, short, short?>("PFA_ProjectNoValue",8,
														   -1),
								   new Triplet<string, short, short?>("MG_FundAllocation_RowId",3,
														   -1),
								   new Triplet<string, short, short?>("PFA_FundDetailsId",12,
														   -1),
								   new Triplet<string, short, short?>("PFA_FundTypeValue",6,
														   -1),
								   new Triplet<string, short, short?>("PFA_ProjectNo",7,
														   -1),
								   new Triplet<string, short, short?>("PFA_FundType",5,
														   -1),
								   new Triplet<string, short, short?>("PFA_BudgetHeadValue",10,
														   -1),
								   new Triplet<string, short, short?>("PFA_BudgetHead",9,
														   -1),
								}
			},
							{"794A7328-890E-42A3-B11A-5984B2D49196", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("WMC_DateofComments",4,
														   -1),
								   new Triplet<string, short, short?>("WMC_Comments",5,
														   -1),
								   new Triplet<string, short, short?>("WMC_StepTo",2,
														   -1),
								   new Triplet<string, short, short?>("WMC_User",3,
														   -1),
								   new Triplet<string, short, short?>("WMC_StepFrom",1,
														   -1),
								}
			},
					};	

	

		private Dictionary<string,string> formVersionList =new Dictionary<string,string> 
		{
							{"48D9155C-42D2-4414-AF53-3D00D9908DD4", "Medium"},
					};	

		
		private Dictionary<string,string> formVersionLayoutList =new Dictionary<string,string> 
		{
							{"8B5E7D64-27A5-47EC-AA51-6B0C9FE60F8B", ""},
							{"C09BB3BF-5B1D-4159-A21D-D9F47B2384A3", ""},
							{"48D9155C-42D2-4414-AF53-3D00D9908DD4", ""},
							{"EAD3F27A-81C8-4887-9A84-B78392BE5185", ""},
							{"DAF566B2-97D0-46E2-AE1C-6519FF641BC5", ""},
							{"CBA147CF-E1CD-4D0A-9CDB-076831CC605E", ""},
							{"A97604B2-DA94-49B4-993D-8CCCAF6FEA82", ""},
							{"DAF433BE-67AC-476C-B3F4-C758B6AB75D5", ""},
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


	public partial class AcDataISpace53f8560140a83229820900367a5bc621  : ExtensionActivityBase
	{		
		
		
		private Dictionary<string,  List<Triplet<string, short, short?>>> queryExpressionBindings = 
											new Dictionary<string,  List<Triplet<string, short, short?>>>
		{
							{"9E3B6B37-E973-48C3-8A15-8354D2CC4DEF", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_d3_UpdatedOn",6,
														   -1),
								   new Triplet<string, short, short?>("MG_d3_OtherExpenditureType",8,
														   -1),
								   new Triplet<string, short, short?>("MG_d3_Amount",4,
														   -1),
								   new Triplet<string, short, short?>("MG_d3_TravelAdvanceID",1,
														   -1),
								   new Triplet<string, short, short?>("MG_d3_FromDate",2,
														   -1),
								   new Triplet<string, short, short?>("MG_d3_UpdatedBy",5,
														   -1),
								   new Triplet<string, short, short?>("MG_d3_IsTravelRequest",9,
														   -1),
								   new Triplet<string, short, short?>("MG_d3_ExpenditureType",7,
														   -1),
								   new Triplet<string, short, short?>("MG_d3_ExpenditureTypeID",0,
														   -1),
								   new Triplet<string, short, short?>("MG_d3_ToDate",3,
														   -1),
								   new Triplet<string, short, short?>("ExpenseDetails_RowId",10,
														   -1),
								}
			},
							{"A86C8422-ADD9-44BA-B612-C8D9EDB841C5", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_d2_Amount",12,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_ArrivalTime",7,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_Arrival",5,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_IsTravelRequest",13,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_JourneyClass",9,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_DepartureTime",4,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_ArrivalDate",6,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_DepartureDate",3,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_TADetailsID",0,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_ModeofJourney",8,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_PNRNo",11,
														   -1),
								   new Triplet<string, short, short?>("AdvanceDetails_RowId",16,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_Departure",2,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_UpdatedBy",14,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_TravelAdvanceID",1,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_Road",10,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_UpdatedOn",15,
														   -1),
								}
			},
							{"FCFC0853-8E66-474B-A676-F339F45380EF", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("PAB_YetToRecieve",2,
														   -1),
								   new Triplet<string, short, short?>("PAB_RecievedAmount",3,
														   -1),
								   new Triplet<string, short, short?>("PAB_Spent",5,
														   -1),
								   new Triplet<string, short, short?>("PAB_Commitment",4,
														   -1),
								   new Triplet<string, short, short?>("PAB_SanctionedAmount",1,
														   -1),
								   new Triplet<string, short, short?>("PAB_BudgetName",0,
														   -1),
								   new Triplet<string, short, short?>("PAB_Balance",6,
														   -1),
								}
			},
							{"79298EDC-7380-4DCA-BEFA-54D2D36D148A", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_d3_IsTravelRequest",9,
														   -1),
								   new Triplet<string, short, short?>("ExpenseDetails_RowId",10,
														   -1),
								   new Triplet<string, short, short?>("MG_d3_Amount",4,
														   -1),
								   new Triplet<string, short, short?>("MG_d3_OtherExpenditureType",8,
														   -1),
								   new Triplet<string, short, short?>("MG_d3_TravelAdvanceID",1,
														   -1),
								   new Triplet<string, short, short?>("MG_d3_UpdatedOn",6,
														   -1),
								   new Triplet<string, short, short?>("MG_d3_UpdatedBy",5,
														   -1),
								   new Triplet<string, short, short?>("MG_d3_ExpenditureType",7,
														   -1),
								   new Triplet<string, short, short?>("MG_d3_ToDate",3,
														   -1),
								   new Triplet<string, short, short?>("MG_d3_ExpenditureTypeID",0,
														   -1),
								   new Triplet<string, short, short?>("MG_d3_FromDate",2,
														   -1),
								}
			},
							{"FAA6C5FB-3ED2-4177-8B27-6EA6EA73C8C5", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_d2_IsTravelRequest",13,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_Amount",12,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_ModeofJourney",8,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_JourneyClass",9,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_TADetailsID",0,
														   -1),
								   new Triplet<string, short, short?>("AdvanceDetails_RowId",16,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_Departure",2,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_PNRNo",11,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_ArrivalTime",7,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_Arrival",5,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_UpdatedBy",14,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_TravelAdvanceID",1,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_DepartureDate",3,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_Road",10,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_ArrivalDate",6,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_UpdatedOn",15,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_DepartureTime",4,
														   -1),
								}
			},
							{"D3F13653-5A71-4FF7-87CF-7CCF34A9151A", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_d2_Arrival",5,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_Amount",12,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_DepartureDate",3,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_ModeofJourney",8,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_ArrivalDate",6,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_PNRNo",11,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_UpdatedOn",15,
														   -1),
								   new Triplet<string, short, short?>("AdvanceDetails_RowId",16,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_UpdatedBy",14,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_TADetailsID",0,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_Departure",2,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_ArrivalTime",7,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_Road",10,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_TravelAdvanceID",1,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_IsTravelRequest",13,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_DepartureTime",4,
														   -1),
								   new Triplet<string, short, short?>("MG_d2_JourneyClass",9,
														   -1),
								}
			},
							{"C2197382-0B39-42FF-967D-813A615854D1", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_d3_IsTravelRequest",9,
														   -1),
								   new Triplet<string, short, short?>("MG_d3_FromDate",2,
														   -1),
								   new Triplet<string, short, short?>("MG_d3_Amount",4,
														   -1),
								   new Triplet<string, short, short?>("MG_d3_ToDate",3,
														   -1),
								   new Triplet<string, short, short?>("MG_d3_ExpenditureType",7,
														   -1),
								   new Triplet<string, short, short?>("ExpenseDetails_RowId",10,
														   -1),
								   new Triplet<string, short, short?>("MG_d3_TravelAdvanceID",1,
														   -1),
								   new Triplet<string, short, short?>("MG_d3_UpdatedBy",5,
														   -1),
								   new Triplet<string, short, short?>("MG_d3_UpdatedOn",6,
														   -1),
								   new Triplet<string, short, short?>("MG_d3_ExpenditureTypeID",0,
														   -1),
								   new Triplet<string, short, short?>("MG_d3_OtherExpenditureType",8,
														   -1),
								}
			},
							{"25891B74-08F4-4F71-BE61-36CEA4C143EC", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("PFA_Amount",11,
														   -1),
								   new Triplet<string, short, short?>("PFA_ProjectNoValue",8,
														   -1),
								   new Triplet<string, short, short?>("MG_FundAllocation_RowId",3,
														   -1),
								   new Triplet<string, short, short?>("PFA_FundDetailsId",12,
														   -1),
								   new Triplet<string, short, short?>("PFA_FundTypeValue",6,
														   -1),
								   new Triplet<string, short, short?>("PFA_ProjectNo",7,
														   -1),
								   new Triplet<string, short, short?>("PFA_FundType",5,
														   -1),
								   new Triplet<string, short, short?>("PFA_BudgetHeadValue",10,
														   -1),
								   new Triplet<string, short, short?>("PFA_BudgetHead",9,
														   -1),
								}
			},
							{"794A7328-890E-42A3-B11A-5984B2D49196", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("WMC_DateofComments",4,
														   -1),
								   new Triplet<string, short, short?>("WMC_Comments",5,
														   -1),
								   new Triplet<string, short, short?>("WMC_StepTo",2,
														   -1),
								   new Triplet<string, short, short?>("WMC_User",3,
														   -1),
								   new Triplet<string, short, short?>("WMC_StepFrom",1,
														   -1),
								}
			},
					};	

	

		private Dictionary<string,string> formVersionList =new Dictionary<string,string> 
		{
							{"48D9155C-42D2-4414-AF53-3D00D9908DD4", "Medium"},
					};	

		
		private Dictionary<string,string> formVersionLayoutList =new Dictionary<string,string> 
		{
							{"8B5E7D64-27A5-47EC-AA51-6B0C9FE60F8B", ""},
							{"C09BB3BF-5B1D-4159-A21D-D9F47B2384A3", ""},
							{"48D9155C-42D2-4414-AF53-3D00D9908DD4", ""},
							{"EAD3F27A-81C8-4887-9A84-B78392BE5185", ""},
							{"DAF566B2-97D0-46E2-AE1C-6519FF641BC5", ""},
							{"CBA147CF-E1CD-4D0A-9CDB-076831CC605E", ""},
							{"A97604B2-DA94-49B4-993D-8CCCAF6FEA82", ""},
							{"DAF433BE-67AC-476C-B3F4-C758B6AB75D5", ""},
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


	public partial class AcDataISpace66993345063b9dc08b58e3d322bd7e24  : ExtensionActivityBase
	{		
		
		
		private Dictionary<string,  List<Triplet<string, short, short?>>> queryExpressionBindings = 
											new Dictionary<string,  List<Triplet<string, short, short?>>>
		{
							{"FCFC0853-8E66-474B-A676-F339F45380EF", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("PAB_YetToRecieve",2,
														   -1),
								   new Triplet<string, short, short?>("PAB_RecievedAmount",3,
														   -1),
								   new Triplet<string, short, short?>("PAB_Spent",5,
														   -1),
								   new Triplet<string, short, short?>("PAB_Commitment",4,
														   -1),
								   new Triplet<string, short, short?>("PAB_SanctionedAmount",1,
														   -1),
								   new Triplet<string, short, short?>("PAB_BudgetName",0,
														   -1),
								   new Triplet<string, short, short?>("PAB_Balance",6,
														   -1),
								}
			},
							{"25891B74-08F4-4F71-BE61-36CEA4C143EC", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("PFA_Amount",11,
														   -1),
								   new Triplet<string, short, short?>("PFA_ProjectNoValue",8,
														   -1),
								   new Triplet<string, short, short?>("MG_FundAllocation_RowId",3,
														   -1),
								   new Triplet<string, short, short?>("PFA_FundDetailsId",12,
														   -1),
								   new Triplet<string, short, short?>("PFA_FundTypeValue",6,
														   -1),
								   new Triplet<string, short, short?>("PFA_ProjectNo",7,
														   -1),
								   new Triplet<string, short, short?>("PFA_FundType",5,
														   -1),
								   new Triplet<string, short, short?>("PFA_BudgetHeadValue",10,
														   -1),
								   new Triplet<string, short, short?>("PFA_BudgetHead",9,
														   -1),
								}
			},
							{"794A7328-890E-42A3-B11A-5984B2D49196", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("WMC_DateofComments",4,
														   -1),
								   new Triplet<string, short, short?>("WMC_Comments",5,
														   -1),
								   new Triplet<string, short, short?>("WMC_StepTo",2,
														   -1),
								   new Triplet<string, short, short?>("WMC_User",3,
														   -1),
								   new Triplet<string, short, short?>("WMC_StepFrom",1,
														   -1),
								}
			},
					};	

	

		private Dictionary<string,string> formVersionList =new Dictionary<string,string> 
		{
							{"48D9155C-42D2-4414-AF53-3D00D9908DD4", "Medium"},
					};	

		
		private Dictionary<string,string> formVersionLayoutList =new Dictionary<string,string> 
		{
							{"8B5E7D64-27A5-47EC-AA51-6B0C9FE60F8B", ""},
							{"C09BB3BF-5B1D-4159-A21D-D9F47B2384A3", ""},
							{"48D9155C-42D2-4414-AF53-3D00D9908DD4", ""},
							{"EAD3F27A-81C8-4887-9A84-B78392BE5185", ""},
							{"DAF566B2-97D0-46E2-AE1C-6519FF641BC5", ""},
							{"CBA147CF-E1CD-4D0A-9CDB-076831CC605E", ""},
							{"A97604B2-DA94-49B4-993D-8CCCAF6FEA82", ""},
							{"DAF433BE-67AC-476C-B3F4-C758B6AB75D5", ""},
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
		


