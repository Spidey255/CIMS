  







namespace CPS.Proof.DFSExtension
{
	using System;
    using System.Collections.Generic;     
	using System.Linq;
	
	
	public partial class TravelSettlementProcessMetadata : ExtensionProcessBase
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
            get { return "AC69E996-4AE4-4D34-829F-4DFC7F63582C"; }
        }

        public override string ProcessName
        {
            get { return "TravelSettlement"; }
        }

		public override string ProcessDescription
        {
            get { return "Travel Settlement"; }
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
            get {return "AC69E996-4AE4-4D34-829F-4DFC7F63582C";}
        }

		public override byte ProcessInstanceMode
        {
            get {return 3;}
        }		

		public override string MasterFormId
        {
            get {  
				   return "22A823DE-0760-4F0D-A347-1C1315A2967E";	}
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
	

	public partial class TravelSettlementObjectFactory  : ExtObjectFactoryBase
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
        //    return (IExtBaseMetaData)new TravelSettlementProcessMetadata();
        //}
	


		private List<Triplet<string, string, string>> queryExpressionData = new List<Triplet<string, string, string>>
		{
	  			
			     new Triplet<string, string, string>("2A1DECB9-E01F-4B34-AEB6-2F63419086A1","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("98BF359E-FA14-492F-88A1-7DFD32D76570","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("C0238006-3D5A-49CA-8B25-C5F643BF76D0","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("F3E10461-3226-4803-B4FB-B1BC501BB6F5","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("ED15FA1F-D7F9-4F6A-9FC4-35EEE23FA142","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"300A3A31-6181-43BC-865F-73BE07692674"),
			
						
			     new Triplet<string, string, string>("42780740-8C6F-4DAB-BF41-1EB6F16F1F21","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"9ADED37B-CD11-426B-AF16-DEAC75685EF5"),
			
						
			     new Triplet<string, string, string>("10050FA1-3EE9-447A-84B7-3196AC6C3700","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("26121ea8-dc1b-0c61-3f1e-2020d59e6348","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("451B4D6A-0157-45DE-996B-9B03FB97D453","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("D707F6E5-B336-4B14-BB90-DCBE65B38460","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("935F2074-D9D8-4E08-A479-5C1D1110C173","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("CA31643F-8CD6-46EF-9214-A9D08E22313D","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("c9219f16-b139-e53f-19ec-6f479fd577a9","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("899d988f-f382-7c8e-861e-1b768959533f","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("800FCB85-CC5F-4550-9D3F-5D7AE4650DF2","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"9ADED37B-CD11-426B-AF16-DEAC75685EF5"),
			
						
			     new Triplet<string, string, string>("DC541083-0878-4D23-B8BB-9B0CE733EEDF","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("5bbc413f-6dd3-b484-1a57-30313545216f","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("4e1eac81-75f9-9be7-2989-2a70d1faefb7","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("d6f9f1fd-934e-bb27-6136-f84a8acf834b","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("dac4474c-4194-5355-7c0e-212eeaad53e2","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("38798B7F-B90F-4A26-9A30-5317A9489D0E","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("BD4FA256-2A90-4537-81F7-851553AB7968","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("200CEBCC-9949-420E-B45F-F8454BAC10B5","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"300A3A31-6181-43BC-865F-73BE07692674"),
			
						
			     new Triplet<string, string, string>("90bb3f4f-0578-a7cf-d380-981e7e131e6f","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("C92176EC-E806-43BC-88D2-348E8005BA14","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"300A3A31-6181-43BC-865F-73BE07692674"),
			
						
			     new Triplet<string, string, string>("a39f50b8-052d-58d3-4891-d914ec82bc69","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("CDE96348-64D4-4000-A9C3-51D8F7B31566","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("4F4B72E2-20D7-4166-89F9-0192E1123361","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("3F5245D2-69E4-48F8-9496-2B2EFB5417B0","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("997258b7-9a78-46b9-6069-8bf404ec23ed","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("47DEECA9-8E4E-4FDE-806B-D716B4F25534","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"300A3A31-6181-43BC-865F-73BE07692674"),
			
						
			     new Triplet<string, string, string>("68C5D0A5-8E30-49AB-91AD-12CEEA91048F","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"300A3A31-6181-43BC-865F-73BE07692674"),
			
						
			     new Triplet<string, string, string>("9B59C95F-3EF4-4759-B14A-AA281DE48F47","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"300A3A31-6181-43BC-865F-73BE07692674"),
			
						
			     new Triplet<string, string, string>("DBDB2E68-FF43-4B97-9BBF-45C54F74665E","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"9ADED37B-CD11-426B-AF16-DEAC75685EF5"),
			
						
			     new Triplet<string, string, string>("EC6B13CB-059E-4F92-AA67-9389538CBAE4","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"028B1EFF-34A8-4D44-BF39-06CE99DF7C67"),
			
						
			     new Triplet<string, string, string>("03AA5526-D290-4937-ABD4-5C5942084D2F","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("BFC04E58-2088-49F5-8A00-F1DDCBA4ACF1","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("6EDD76BB-4D26-460A-AC08-830AA164885A","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"028B1EFF-34A8-4D44-BF39-06CE99DF7C67"),
			
						
			     new Triplet<string, string, string>("B5136E55-467F-46BF-9D46-AE1BE798E3D4","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"9ADED37B-CD11-426B-AF16-DEAC75685EF5"),
			
						
			     new Triplet<string, string, string>("7a376b7e-cb57-2943-c84b-3046179e2a17","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("D8D9A976-5AAA-4BD2-B7D8-AE2AA0ACF5BB","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"300A3A31-6181-43BC-865F-73BE07692674"),
			
						
			     new Triplet<string, string, string>("12B0DEF7-CA44-4A9E-A1D6-DF341107FA9C","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"300A3A31-6181-43BC-865F-73BE07692674"),
			
						
			     new Triplet<string, string, string>("6c18b6b2-6100-28b9-40e2-1f6cd380da57","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("90205139-c571-01bd-3a5b-d9675759a3ac","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("CFCAC793-5C3F-4301-99EA-29692D7A07E4","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("8AF4DAA1-39C0-43E7-A565-12D8253420A4","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("E883B5B2-F18C-4602-A27E-420FD56789E3","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("10050FA1-3EE9-447A-84B7-3196AC6C3700","Load ProjectCommitmentSpentDetails",
												     @"BD17B4AF-1152-47EA-9EEB-DDA244A8B9F9"),
			
						
			     new Triplet<string, string, string>("800FCB85-CC5F-4550-9D3F-5D7AE4650DF2","Load Remarks Details",
												     @"F9CBD66E-80AF-4A49-805E-978379D06B55"),
			
						
			     new Triplet<string, string, string>("DC541083-0878-4D23-B8BB-9B0CE733EEDF","Delete fund",
												     @"0BFAF73B-02D4-4680-B1C9-625AAFB02DB5"),
			
						
			     new Triplet<string, string, string>("200CEBCC-9949-420E-B45F-F8454BAC10B5","Delete Records",
												     @"9F49372F-0255-42EC-AB05-31E6C4F9F2EA"),
			
						
			     new Triplet<string, string, string>("4F4B72E2-20D7-4166-89F9-0192E1123361","Load Fund details",
												     @"0BFAF73B-02D4-4680-B1C9-625AAFB02DB5"),
			
						
			     new Triplet<string, string, string>("47DEECA9-8E4E-4FDE-806B-D716B4F25534","Grid BindingE",
												     @"9F49372F-0255-42EC-AB05-31E6C4F9F2EA"),
			
						
			     new Triplet<string, string, string>("68C5D0A5-8E30-49AB-91AD-12CEEA91048F","Grid Binding8",
												     @"9F49372F-0255-42EC-AB05-31E6C4F9F2EA"),
			
						
			     new Triplet<string, string, string>("9B59C95F-3EF4-4759-B14A-AA281DE48F47","Delete Records",
												     @"7D2812B7-3A49-4DA7-9E48-082B26C3333C"),
			
						
			     new Triplet<string, string, string>("D8D9A976-5AAA-4BD2-B7D8-AE2AA0ACF5BB","Update the Other Expenses",
												     @"7D2812B7-3A49-4DA7-9E48-082B26C3333C"),
			
						
			     new Triplet<string, string, string>("12B0DEF7-CA44-4A9E-A1D6-DF341107FA9C","Add Other Expenses",
												     @"7D2812B7-3A49-4DA7-9E48-082B26C3333C"),
			
			
			
		};

		
		private List<Triplet<string, string, string>> ComboDataSource = new List<Triplet<string, string, string>>
		{

		
	  			
			     new Triplet<string, string, string>("MF_T1_TravelType","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMAqCwOWy+D7Ogje1I4jfjiAZNrjEazgaNyfBj9pr2u90lOsHzRNfKnSybWqRxrZGqV",
												     @"Select 1,1"),
			
						
			     new Triplet<string, string, string>("MG_T2_ModeofJourney","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMAqCwOWy+D7Ogje1I4jfjiAZNrjEazgaNyfBj9pr2u90lOsHzRNfKnSybWqRxrZGqV",
												     @"EXEC GetTravelAdvanceDetailCombo 4"),
			
						
			     new Triplet<string, string, string>("C_FC_ProjectNo_33","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMAqCwOWy+D7Ogje1I4jfjiAZNrjEazgaNyfBj9pr2u90lOsHzRNfKnSybWqRxrZGqV",
												     @"EXEC GetProjects"),
			
						
			     new Triplet<string, string, string>("MFG_T2_ExpenditureTypeID","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMAqCwOWy+D7Ogje1I4jfjiAZNrjEazgaNyfBj9pr2u90lOsHzRNfKnSybWqRxrZGqV",
												     @"EXEC GetTravelAdvanceView 3,''"),
			
						
			     new Triplet<string, string, string>("MFG_T2_ModeofJourney","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMAqCwOWy+D7Ogje1I4jfjiAZNrjEazgaNyfBj9pr2u90lOsHzRNfKnSybWqRxrZGqV",
												     @"EXEC GetTravelAdvanceDetailCombo 4"),
			
						
			     new Triplet<string, string, string>("MG_L1_Expenditure_Type","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMAqCwOWy+D7Ogje1I4jfjiAZNrjEazgaNyfBj9pr2u90lOsHzRNfKnSybWqRxrZGqV",
												     @"EXEC GetTravelAdvanceView 3,''"),
			
						
			     new Triplet<string, string, string>("Expenditure_Type","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMAqCwOWy+D7Ogje1I4jfjiAZNrjEazgaNyfBj9pr2u90lOsHzRNfKnSybWqRxrZGqV",
												     @"EXEC GetTravelAdvanceView 3,''"),
			
						
			     new Triplet<string, string, string>("MG_T2_JourneyClass","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMAqCwOWy+D7Ogje1I4jfjiAZNrjEazgaNyfBj9pr2u90lOsHzRNfKnSybWqRxrZGqV",
												     @"EXEC GetTravelAdvanceDetailCombo 17,''"),
			
						
			     new Triplet<string, string, string>("R_ReferenceNo","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMAqCwOWy+D7Ogje1I4jfjiAZNrjEazgaNyfBj9pr2u90lOsHzRNfKnSybWqRxrZGqV",
												     @"Exec GetTravelSettlement 5,'','@UC_EmployeeBaicInfoID'"),
			
						
			     new Triplet<string, string, string>("MF_BudgetHead","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMA18yFT7KruzVDa0TqsqpOM+grujzoqor1KqRIderPPsozBAr7TiIaPx7MYO2zQclV",
												     @"exec common..SP_GetDistrubitionDetails 6,'@@gv_ProcessMapId',@MF_FundType,'',@MF_T1_AdvanceAmount,'@UC_EmployeeBaicInfoId','@R_ReferenceNo'"),
			
						
			     new Triplet<string, string, string>("MG_L1_JourneyClass","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMAqCwOWy+D7Ogje1I4jfjiAZNrjEazgaNyfBj9pr2u90lOsHzRNfKnSybWqRxrZGqV",
												     @"EXEC GetTravelAdvanceDetailCombo 17,''"),
			
						
			     new Triplet<string, string, string>("MG_T2_DepartureTime","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMAqCwOWy+D7Ogje1I4jfjiAZNrjEazgaNyfBj9pr2u90lOsHzRNfKnSybWqRxrZGqV",
												     @"EXEC GetTravelAdvanceDetailCombo 6"),
			
						
			     new Triplet<string, string, string>("A","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMA18yFT7KruzVDa0TqsqpOM+grujzoqor1KqRIderPPsozBAr7TiIaPx7MYO2zQclV",
												     @"exec SP_GetDistrubitionDetails 5,'',@MF_FundType,''"),
			
						
			     new Triplet<string, string, string>("MG_T2_ArrivalTime","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMAqCwOWy+D7Ogje1I4jfjiAZNrjEazgaNyfBj9pr2u90lOsHzRNfKnSybWqRxrZGqV",
												     @"EXEC GetTravelAdvanceDetailCombo 6"),
			
						
			     new Triplet<string, string, string>("MFG_T2_JourneyClass","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMAqCwOWy+D7Ogje1I4jfjiAZNrjEazgaNyfBj9pr2u90lOsHzRNfKnSybWqRxrZGqV",
												     @"EXEC GetTravelAdvanceDetailCombo 7,'@MFG_T2_ModeofJourney'"),
			
						
			     new Triplet<string, string, string>("MF_T1_BudgetHead","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMAqCwOWy+D7Ogje1I4jfjiAZNrjEazgaNyfBj9pr2u90lOsHzRNfKnSybWqRxrZGqV",
												     @"EXEC GetBudgetHeads"),
			
						
			     new Triplet<string, string, string>("M_MoveTo","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMA18yFT7KruzVDa0TqsqpOM+grujzoqor1KqRIderPPsozBAr7TiIaPx7MYO2zQclV",
												     @"EXEC GetMovetoValues '@M_SourceActivityMapId','@M_PackageProcessMapId'"),
			
						
			     new Triplet<string, string, string>("MF_FundType","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMA18yFT7KruzVDa0TqsqpOM+grujzoqor1KqRIderPPsozBAr7TiIaPx7MYO2zQclV",
												     @"exec SP_GetDistrubitionDetails 7,'@@gv_ProcessMapId','','',@MF_T1_AdvanceAmount,'','@R_ReferenceNo',''"),
			
						
			     new Triplet<string, string, string>("MG_L1_ModeofJourney","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMAqCwOWy+D7Ogje1I4jfjiAZNrjEazgaNyfBj9pr2u90lOsHzRNfKnSybWqRxrZGqV",
												     @"EXEC GetTravelAdvanceDetailCombo 4"),
			
						
			     new Triplet<string, string, string>("MF_ProjectNo","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMAqCwOWy+D7Ogje1I4jfjiAZNrjEazgaNyfBj9pr2u90lOsHzRNfKnSybWqRxrZGqV",
												     @"EXEC Projects..GetProjectExtensionDetails 8,'@UC_EmployeeBaicInfoId','','','',@MF_T1_AdvanceAmount,'@R_ReferenceNo'"),
			
						
			     new Triplet<string, string, string>("Travel_Type","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMAqCwOWy+D7Ogje1I4jfjiAZNrjEazgaNyfBj9pr2u90lOsHzRNfKnSybWqRxrZGqV",
												     @"EXEC GetTravelTypes"),
			
						
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
		
	  			
			     new Tuple<string, int>("MF_FundAmount",5),
			
						
			     new Tuple<string, int>("TravelExpense",5),
			
						
			     new Tuple<string, int>("M_TravelExpense",5),
			
						
			     new Tuple<string, int>("MG_DcoumentDetails",5),
			
						
			     new Tuple<string, int>("M_FundAmount",5),
			
						
			     new Tuple<string, int>("OtherExpense",5),
			
						
			     new Tuple<string, int>("MG_CommitmentDetails",25),
			
						
			     new Tuple<string, int>("M_OtherExpense",5),
			
						
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
											case "0D9E568F-8790-489D-A846-3C6057A39268":
							virtualInstance=new ISpace0D9E568F8790489DA8463C6057A39268();
							break;
					
											case "F4BD3F24-901C-43AB-8607-4D7817A2621C":
							virtualInstance=new ISpaceF4BD3F24901C43AB86074D7817A2621C();
							break;
					
											case "F5D55501-419C-4E8D-97D9-EFE380D7D47D":
							virtualInstance=new ISpaceF5D55501419C4E8D97D9EFE380D7D47D();
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
	

	public partial class TravelSettlementDataElementFactory  : ExtElementBase
    {

     /// <summary>
        /// A <see cref="log4net.ILog"/> that contains the logger instance for 
        /// logging
        /// </summary>
        private readonly ILog _sysLog;

        public TravelSettlementDataElementFactory()
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

               
                
                                      case "22A823DE-0760-4F0D-A347-1C1315A2967E":
                    {
                     
                                     fInsertQuery=@"IF NOT EXISTS(SELECT 1 FROM [22A823DE-0760-4F0D-A347-1C1315A2967E] WHERE InstanceId='{0}' AND
							 FormId='{2}') BEGIN INSERT INTO [22A823DE-0760-4F0D-A347-1C1315A2967E](ProcessActivityMapId,FormId,growid,C_FC_AgencyCode_33,M_InstanceId,M_PackageProcessMapId,M_Remarks,UC_Department,IN_InstanceName,UC_DOR,M_ActualTransactionNo,UC_DOJ,ExecuteCommand,UC_EmailId,FC_ProjectNo,FC_Category,M_Status,CancelRedirectUrl,UC_DOB,MF_TransactionNo,MF_InstanceId,M_DestinationActivityId,M_MoveToValue,FC_AgencyCode,FC_EndDate,MF_T1_BeneficiaryName,FC_SanctionNo,C_FC_ProjectName_33,C_FC_Category_33,MF_T1_ReferenceNo,MF_SaveBudgetName,MF_T1_Destination,UC_PhoneNumber,ExecutionStatus,M_BudgetErrMsg,MF_T1_BankName,MF_T1_BankBranch,C_FC_SanctionedValue_33,M_SourceActivityMapId,IN_SLA,AssignToRole,M_TravelPlace,UC_Designation,UC_Name,MF_E1_EmployeeBasicInfoId,M_InitiatorUserMapId,Subject,C_FC_SanctionNo_33,FC_StartDate,AssignToUser,MF_PackageProcessMapId,FC_ProjectName,UC_EmployeeId,MF_FundDetailsId,SetDestinationTo,UC_EmployeeBaicInfoId,M_NextStage,MF_T1_AccountNo,MF_T1_TravellingPerson,KeyContext,M_SourceHeader,DisplayContext,UC_Grade,M_MiscDetails,FC_SanctionedDate,MF_T1_JourneyPurpose,RedirectUrl,MF_TravelStatus,MF_T1_ProjectNo,ExecutionMessage,FC_SanctionedValue,MF_T1_TravelAdvanceID,UC_Paylevel,MF_SaveBudgetAmount,C_FC_BudgetHeadAmount,AdvanceAmount,MF_T1_AvailableBudget,T_ExpenditureTotal,IN_Category,M_IsTravelRequest,MF_Amount,M_FieldMandatory,M_IsFlowReturned,M_RemarksMandatory,MF_T1_AdvanceAmount,M_IsSourceStep,M_IsCancelReject,M_BudgetErr,T_AdvanceDrawn,SLATime,M_T1_AdvanceAmount,C_FC_ReceiptAmountinBudgetHead,T_TravelAdvanceTotal,M_SaveDomainData,IN_Priority,IN_Status,MF_CountDoc,M_OverAll_Total,MF_GrdFundCount,M_IsCommitment,M_RequestId,OverAll_Total,M_SumOfFund,MF_T1_TravelType,C_FC_ProjectNo_33,R_ReferenceNo,MF_BudgetHead,A,MF_T1_BudgetHead,M_MoveTo,MF_FundType,MF_ProjectNo,Travel_Type,C_FC_SanctionedDate_33,M_RandDTransactionDate,C_FC_StartDate_33,M_ActualTransactionDate,MF_TransactionDate,C_FC_EndDate_33,MF_T1_BankDocument,Thumbnail,M_TravelInstanceId,M_RandDTransactionNo,M_ActivityName,InstanceId,M_IsAdvanceRequired)
							VALUES( {3}) END ELSE BEGIN UPDATE [22A823DE-0760-4F0D-A347-1C1315A2967E]SET {4}WHERE InstanceId='{0}'END ";

                                     colList=@"ProcessActivityMapId,FormId,growid,C_FC_AgencyCode_33,M_InstanceId,M_PackageProcessMapId,M_Remarks,UC_Department,IN_InstanceName,UC_DOR,M_ActualTransactionNo,UC_DOJ,ExecuteCommand,UC_EmailId,FC_ProjectNo,FC_Category,M_Status,CancelRedirectUrl,UC_DOB,MF_TransactionNo,MF_InstanceId,M_DestinationActivityId,M_MoveToValue,FC_AgencyCode,FC_EndDate,MF_T1_BeneficiaryName,FC_SanctionNo,C_FC_ProjectName_33,C_FC_Category_33,MF_T1_ReferenceNo,MF_SaveBudgetName,MF_T1_Destination,UC_PhoneNumber,ExecutionStatus,M_BudgetErrMsg,MF_T1_BankName,MF_T1_BankBranch,C_FC_SanctionedValue_33,M_SourceActivityMapId,IN_SLA,AssignToRole,M_TravelPlace,UC_Designation,UC_Name,MF_E1_EmployeeBasicInfoId,M_InitiatorUserMapId,Subject,C_FC_SanctionNo_33,FC_StartDate,AssignToUser,MF_PackageProcessMapId,FC_ProjectName,UC_EmployeeId,MF_FundDetailsId,SetDestinationTo,UC_EmployeeBaicInfoId,M_NextStage,MF_T1_AccountNo,MF_T1_TravellingPerson,KeyContext,M_SourceHeader,DisplayContext,UC_Grade,M_MiscDetails,FC_SanctionedDate,MF_T1_JourneyPurpose,RedirectUrl,MF_TravelStatus,MF_T1_ProjectNo,ExecutionMessage,FC_SanctionedValue,MF_T1_TravelAdvanceID,UC_Paylevel,MF_SaveBudgetAmount,C_FC_BudgetHeadAmount,AdvanceAmount,MF_T1_AvailableBudget,T_ExpenditureTotal,IN_Category,M_IsTravelRequest,MF_Amount,M_FieldMandatory,M_IsFlowReturned,M_RemarksMandatory,MF_T1_AdvanceAmount,M_IsSourceStep,M_IsCancelReject,M_BudgetErr,T_AdvanceDrawn,SLATime,M_T1_AdvanceAmount,C_FC_ReceiptAmountinBudgetHead,T_TravelAdvanceTotal,M_SaveDomainData,IN_Priority,IN_Status,MF_CountDoc,M_OverAll_Total,MF_GrdFundCount,M_IsCommitment,M_RequestId,OverAll_Total,M_SumOfFund,MF_T1_TravelType,C_FC_ProjectNo_33,R_ReferenceNo,MF_BudgetHead,A,MF_T1_BudgetHead,M_MoveTo,MF_FundType,MF_ProjectNo,Travel_Type,C_FC_SanctionedDate_33,M_RandDTransactionDate,C_FC_StartDate_33,M_ActualTransactionDate,MF_TransactionDate,C_FC_EndDate_33,MF_T1_BankDocument,Thumbnail,M_TravelInstanceId,M_RandDTransactionNo,M_ActivityName,InstanceId,M_IsAdvanceRequired";
                                    
                     
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

                
                 
                                      case "BD17B4AF-1152-47EA-9EEB-DDA244A8B9F9":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_BD17B4AF115247EA9EEBDDA244A8B9F9 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_BudgetName] VARCHAR(MAX)	, [MG_SanctionedAmount] DECIMAL(18,2)	, [MG_Balance] DECIMAL(18,2)	, [MG_ReceivedAmount] DECIMAL(18,2)	, [MG_Commitment] DECIMAL(18,2)	, [MG_YetToReceive] DECIMAL(18,2)	, [MG_Spent] DECIMAL(18,2)){0}INSERT INTO [BD17B4AF-1152-47EA-9EEB-DDA244A8B9F9](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_BudgetName,MG_SanctionedAmount,MG_Balance,MG_ReceivedAmount,MG_Commitment,MG_YetToReceive,MG_Spent)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_BudgetName,TDT.MG_SanctionedAmount,TDT.MG_Balance,TDT.MG_ReceivedAmount,TDT.MG_Commitment,TDT.MG_YetToReceive,TDT.MG_Spent FROM @TBL_BD17B4AF115247EA9EEBDDA244A8B9F9 TDT
							LEFT JOIN [BD17B4AF-1152-47EA-9EEB-DDA244A8B9F9] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MG_BudgetName=TDT.MG_BudgetName,MG_SanctionedAmount=TDT.MG_SanctionedAmount,MG_Balance=TDT.MG_Balance,MG_ReceivedAmount=TDT.MG_ReceivedAmount,MG_Commitment=TDT.MG_Commitment,MG_YetToReceive=TDT.MG_YetToReceive,MG_Spent=TDT.MG_Spent FROM @TBL_BD17B4AF115247EA9EEBDDA244A8B9F9 TDT
							JOIN [BD17B4AF-1152-47EA-9EEB-DDA244A8B9F9] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_BudgetName,MG_SanctionedAmount,MG_Balance,MG_ReceivedAmount,MG_Commitment,MG_YetToReceive,MG_Spent";

                                     tempInsertQuery=@"INSERT INTO @TBL_BD17B4AF115247EA9EEBDDA244A8B9F9(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_BudgetName,MG_SanctionedAmount,MG_Balance,MG_ReceivedAmount,MG_Commitment,MG_YetToReceive,MG_Spent)VALUES({0});";
                                     

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
                     
                                    case "e98f5784-8a4e-9d27-6b7a-42c76b854469":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_e98f57848a4e9d276b7a42c76b854469 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_L1_Amount] VARCHAR(MAX)	, [MG_L1_TravelAdvanceID] VARCHAR(MAX)	, [MG_L1_DepartureTime] VARCHAR(MAX)	, [MG_L1_Departure] VARCHAR(MAX)	, [MG_L1_ArrivalTime] VARCHAR(MAX)	, [MG_L1_Arrival] VARCHAR(MAX)	, [MG_L1_PNRNo] VARCHAR(MAX)	, [MG_L1_TADetailsID] VARCHAR(MAX)	, [MG_L1_Road] INT	, [MG_L1_JourneyClass] VARCHAR(250)	, [MG_L1_ModeofJourney] VARCHAR(250)	, [MG_L1_DepartureDate] DATETIME	, [MG_L1_ArrivalDate] DATETIME){0}INSERT INTO [e98f5784-8a4e-9d27-6b7a-42c76b854469](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_L1_Amount,MG_L1_TravelAdvanceID,MG_L1_DepartureTime,MG_L1_Departure,MG_L1_ArrivalTime,MG_L1_Arrival,MG_L1_PNRNo,MG_L1_TADetailsID,MG_L1_Road,MG_L1_JourneyClass,MG_L1_ModeofJourney,MG_L1_DepartureDate,MG_L1_ArrivalDate)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_L1_Amount,TDT.MG_L1_TravelAdvanceID,TDT.MG_L1_DepartureTime,TDT.MG_L1_Departure,TDT.MG_L1_ArrivalTime,TDT.MG_L1_Arrival,TDT.MG_L1_PNRNo,TDT.MG_L1_TADetailsID,TDT.MG_L1_Road,TDT.MG_L1_JourneyClass,TDT.MG_L1_ModeofJourney,TDT.MG_L1_DepartureDate,TDT.MG_L1_ArrivalDate FROM @TBL_e98f57848a4e9d276b7a42c76b854469 TDT
							LEFT JOIN [e98f5784-8a4e-9d27-6b7a-42c76b854469] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MG_L1_Amount=TDT.MG_L1_Amount,MG_L1_TravelAdvanceID=TDT.MG_L1_TravelAdvanceID,MG_L1_DepartureTime=TDT.MG_L1_DepartureTime,MG_L1_Departure=TDT.MG_L1_Departure,MG_L1_ArrivalTime=TDT.MG_L1_ArrivalTime,MG_L1_Arrival=TDT.MG_L1_Arrival,MG_L1_PNRNo=TDT.MG_L1_PNRNo,MG_L1_TADetailsID=TDT.MG_L1_TADetailsID,MG_L1_Road=TDT.MG_L1_Road,MG_L1_JourneyClass=TDT.MG_L1_JourneyClass,MG_L1_ModeofJourney=TDT.MG_L1_ModeofJourney,MG_L1_DepartureDate=TDT.MG_L1_DepartureDate,MG_L1_ArrivalDate=TDT.MG_L1_ArrivalDate FROM @TBL_e98f57848a4e9d276b7a42c76b854469 TDT
							JOIN [e98f5784-8a4e-9d27-6b7a-42c76b854469] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_L1_Amount,MG_L1_TravelAdvanceID,MG_L1_DepartureTime,MG_L1_Departure,MG_L1_ArrivalTime,MG_L1_Arrival,MG_L1_PNRNo,MG_L1_TADetailsID,MG_L1_Road,MG_L1_JourneyClass,MG_L1_ModeofJourney,MG_L1_DepartureDate,MG_L1_ArrivalDate";

                                     tempInsertQuery=@"INSERT INTO @TBL_e98f57848a4e9d276b7a42c76b854469(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_L1_Amount,MG_L1_TravelAdvanceID,MG_L1_DepartureTime,MG_L1_Departure,MG_L1_ArrivalTime,MG_L1_Arrival,MG_L1_PNRNo,MG_L1_TADetailsID,MG_L1_Road,MG_L1_JourneyClass,MG_L1_ModeofJourney,MG_L1_DepartureDate,MG_L1_ArrivalDate)VALUES({0});";
                                     

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
                     
                                    case "ee7fd670-c5c9-69f4-ccc3-80f0e8883f29":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_ee7fd670c5c969f4ccc380f0e8883f29 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_L1_OETravelAdvanceID] VARCHAR(MAX)	, [MG_L1_ExpenditureTypeID] VARCHAR(MAX)	, [MG_L1_OEAmount] DECIMAL(18,2)	, [MG_L1_Expenditure_Type] VARCHAR(250)	, [MG_L1_ToDate] DATETIME	, [MG_L1_FromDate] DATETIME){0}INSERT INTO [ee7fd670-c5c9-69f4-ccc3-80f0e8883f29](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_L1_OETravelAdvanceID,MG_L1_ExpenditureTypeID,MG_L1_OEAmount,MG_L1_Expenditure_Type,MG_L1_ToDate,MG_L1_FromDate)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_L1_OETravelAdvanceID,TDT.MG_L1_ExpenditureTypeID,TDT.MG_L1_OEAmount,TDT.MG_L1_Expenditure_Type,TDT.MG_L1_ToDate,TDT.MG_L1_FromDate FROM @TBL_ee7fd670c5c969f4ccc380f0e8883f29 TDT
							LEFT JOIN [ee7fd670-c5c9-69f4-ccc3-80f0e8883f29] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MG_L1_OETravelAdvanceID=TDT.MG_L1_OETravelAdvanceID,MG_L1_ExpenditureTypeID=TDT.MG_L1_ExpenditureTypeID,MG_L1_OEAmount=TDT.MG_L1_OEAmount,MG_L1_Expenditure_Type=TDT.MG_L1_Expenditure_Type,MG_L1_ToDate=TDT.MG_L1_ToDate,MG_L1_FromDate=TDT.MG_L1_FromDate FROM @TBL_ee7fd670c5c969f4ccc380f0e8883f29 TDT
							JOIN [ee7fd670-c5c9-69f4-ccc3-80f0e8883f29] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_L1_OETravelAdvanceID,MG_L1_ExpenditureTypeID,MG_L1_OEAmount,MG_L1_Expenditure_Type,MG_L1_ToDate,MG_L1_FromDate";

                                     tempInsertQuery=@"INSERT INTO @TBL_ee7fd670c5c969f4ccc380f0e8883f29(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_L1_OETravelAdvanceID,MG_L1_ExpenditureTypeID,MG_L1_OEAmount,MG_L1_Expenditure_Type,MG_L1_ToDate,MG_L1_FromDate)VALUES({0});";
                                     

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
                     
                                    case "0BFAF73B-02D4-4680-B1C9-625AAFB02DB5":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_0BFAF73B02D44680B1C9625AAFB02DB5 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_FundDetailsID] VARCHAR(MAX)	, [MG_FundType] VARCHAR(MAX)	, [MG_BudgetHead] VARCHAR(MAX)	, [MG_ProjectDetailsId] VARCHAR(MAX)	, [MG_ProjectDesc] VARCHAR(MAX)	, [MG_Amount] DECIMAL(18,2)	, [MG_FundTypeId] INT){0}INSERT INTO [0BFAF73B-02D4-4680-B1C9-625AAFB02DB5](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_FundDetailsID,MG_FundType,MG_BudgetHead,MG_ProjectDetailsId,MG_ProjectDesc,MG_Amount,MG_FundTypeId)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_FundDetailsID,TDT.MG_FundType,TDT.MG_BudgetHead,TDT.MG_ProjectDetailsId,TDT.MG_ProjectDesc,TDT.MG_Amount,TDT.MG_FundTypeId FROM @TBL_0BFAF73B02D44680B1C9625AAFB02DB5 TDT
							LEFT JOIN [0BFAF73B-02D4-4680-B1C9-625AAFB02DB5] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MG_FundDetailsID=TDT.MG_FundDetailsID,MG_FundType=TDT.MG_FundType,MG_BudgetHead=TDT.MG_BudgetHead,MG_ProjectDetailsId=TDT.MG_ProjectDetailsId,MG_ProjectDesc=TDT.MG_ProjectDesc,MG_Amount=TDT.MG_Amount,MG_FundTypeId=TDT.MG_FundTypeId FROM @TBL_0BFAF73B02D44680B1C9625AAFB02DB5 TDT
							JOIN [0BFAF73B-02D4-4680-B1C9-625AAFB02DB5] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_FundDetailsID,MG_FundType,MG_BudgetHead,MG_ProjectDetailsId,MG_ProjectDesc,MG_Amount,MG_FundTypeId";

                                     tempInsertQuery=@"INSERT INTO @TBL_0BFAF73B02D44680B1C9625AAFB02DB5(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_FundDetailsID,MG_FundType,MG_BudgetHead,MG_ProjectDetailsId,MG_ProjectDesc,MG_Amount,MG_FundTypeId)VALUES({0});";
                                     

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
                     
                                    case "1234ab8a-bdd0-8930-2afd-ae17d0438c29":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_1234ab8abdd089302afdae17d0438c29 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_L1_FundDetailsID] VARCHAR(MAX)	, [MG_L1_FundType] VARCHAR(MAX)	, [MG_L1_ProjectDesc] VARCHAR(MAX)	, [MG_L1_ProjectDetailsId] VARCHAR(MAX)	, [MG_L1_BudgetHead] VARCHAR(MAX)	, [MG_L1_FundTypeId] INT	, [MG_L1_FTAmount] DECIMAL(18,2)){0}INSERT INTO [1234ab8a-bdd0-8930-2afd-ae17d0438c29](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_L1_FundDetailsID,MG_L1_FundType,MG_L1_ProjectDesc,MG_L1_ProjectDetailsId,MG_L1_BudgetHead,MG_L1_FundTypeId,MG_L1_FTAmount)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_L1_FundDetailsID,TDT.MG_L1_FundType,TDT.MG_L1_ProjectDesc,TDT.MG_L1_ProjectDetailsId,TDT.MG_L1_BudgetHead,TDT.MG_L1_FundTypeId,TDT.MG_L1_FTAmount FROM @TBL_1234ab8abdd089302afdae17d0438c29 TDT
							LEFT JOIN [1234ab8a-bdd0-8930-2afd-ae17d0438c29] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MG_L1_FundDetailsID=TDT.MG_L1_FundDetailsID,MG_L1_FundType=TDT.MG_L1_FundType,MG_L1_ProjectDesc=TDT.MG_L1_ProjectDesc,MG_L1_ProjectDetailsId=TDT.MG_L1_ProjectDetailsId,MG_L1_BudgetHead=TDT.MG_L1_BudgetHead,MG_L1_FundTypeId=TDT.MG_L1_FundTypeId,MG_L1_FTAmount=TDT.MG_L1_FTAmount FROM @TBL_1234ab8abdd089302afdae17d0438c29 TDT
							JOIN [1234ab8a-bdd0-8930-2afd-ae17d0438c29] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_L1_FundDetailsID,MG_L1_FundType,MG_L1_ProjectDesc,MG_L1_ProjectDetailsId,MG_L1_BudgetHead,MG_L1_FundTypeId,MG_L1_FTAmount";

                                     tempInsertQuery=@"INSERT INTO @TBL_1234ab8abdd089302afdae17d0438c29(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_L1_FundDetailsID,MG_L1_FundType,MG_L1_ProjectDesc,MG_L1_ProjectDetailsId,MG_L1_BudgetHead,MG_L1_FundTypeId,MG_L1_FTAmount)VALUES({0});";
                                     

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
                     
                                    case "2624976A-0052-420C-8D20-F5C9444C7A48":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_2624976A0052420C8D20F5C9444C7A48 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [M_DocumentName] VARCHAR(MAX)	, [M_DocumentDetailsId] VARCHAR(MAX)	, [M_UploadDcoument] VARCHAR(36)){0}INSERT INTO [2624976A-0052-420C-8D20-F5C9444C7A48](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,M_DocumentName,M_DocumentDetailsId,M_UploadDcoument)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.M_DocumentName,TDT.M_DocumentDetailsId,TDT.M_UploadDcoument FROM @TBL_2624976A0052420C8D20F5C9444C7A48 TDT
							LEFT JOIN [2624976A-0052-420C-8D20-F5C9444C7A48] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,M_DocumentName=TDT.M_DocumentName,M_DocumentDetailsId=TDT.M_DocumentDetailsId,M_UploadDcoument=TDT.M_UploadDcoument FROM @TBL_2624976A0052420C8D20F5C9444C7A48 TDT
							JOIN [2624976A-0052-420C-8D20-F5C9444C7A48] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,M_DocumentName,M_DocumentDetailsId,M_UploadDcoument";

                                     tempInsertQuery=@"INSERT INTO @TBL_2624976A0052420C8D20F5C9444C7A48(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,M_DocumentName,M_DocumentDetailsId,M_UploadDcoument)VALUES({0});";
                                     

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
                     
                                    case "F9CBD66E-80AF-4A49-805E-978379D06B55":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_F9CBD66E80AF4A49805E978379D06B55 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [RemarksId] VARCHAR(MAX)	, [Remarks] VARCHAR(MAX)	, [ActivityName] VARCHAR(MAX)	, [UserName] VARCHAR(MAX)	, [DateOfRemarks] DATETIME){0}INSERT INTO [F9CBD66E-80AF-4A49-805E-978379D06B55](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,RemarksId,Remarks,ActivityName,UserName,DateOfRemarks)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.RemarksId,TDT.Remarks,TDT.ActivityName,TDT.UserName,TDT.DateOfRemarks FROM @TBL_F9CBD66E80AF4A49805E978379D06B55 TDT
							LEFT JOIN [F9CBD66E-80AF-4A49-805E-978379D06B55] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,RemarksId=TDT.RemarksId,Remarks=TDT.Remarks,ActivityName=TDT.ActivityName,UserName=TDT.UserName,DateOfRemarks=TDT.DateOfRemarks FROM @TBL_F9CBD66E80AF4A49805E978379D06B55 TDT
							JOIN [F9CBD66E-80AF-4A49-805E-978379D06B55] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,RemarksId,Remarks,ActivityName,UserName,DateOfRemarks";

                                     tempInsertQuery=@"INSERT INTO @TBL_F9CBD66E80AF4A49805E978379D06B55(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,RemarksId,Remarks,ActivityName,UserName,DateOfRemarks)VALUES({0});";
                                     

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
                     
                                    case "7D2812B7-3A49-4DA7-9E48-082B26C3333C":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_7D2812B73A494DA79E48082B26C3333C AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_T3_MiscDetails] VARCHAR(MAX)	, [MG_T2_ExpenditureTypeID] VARCHAR(MAX)	, [MG_T2_TravelAdvanceID] VARCHAR(MAX)	, [MG_T3_Amount] INT	, [Expenditure_Type] VARCHAR(250)	, [MG_T2_FromDate] DATETIME	, [MG_T2_ToDate] DATETIME){0}INSERT INTO [7D2812B7-3A49-4DA7-9E48-082B26C3333C](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_T3_MiscDetails,MG_T2_ExpenditureTypeID,MG_T2_TravelAdvanceID,MG_T3_Amount,Expenditure_Type,MG_T2_FromDate,MG_T2_ToDate)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_T3_MiscDetails,TDT.MG_T2_ExpenditureTypeID,TDT.MG_T2_TravelAdvanceID,TDT.MG_T3_Amount,TDT.Expenditure_Type,TDT.MG_T2_FromDate,TDT.MG_T2_ToDate FROM @TBL_7D2812B73A494DA79E48082B26C3333C TDT
							LEFT JOIN [7D2812B7-3A49-4DA7-9E48-082B26C3333C] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MG_T3_MiscDetails=TDT.MG_T3_MiscDetails,MG_T2_ExpenditureTypeID=TDT.MG_T2_ExpenditureTypeID,MG_T2_TravelAdvanceID=TDT.MG_T2_TravelAdvanceID,MG_T3_Amount=TDT.MG_T3_Amount,Expenditure_Type=TDT.Expenditure_Type,MG_T2_FromDate=TDT.MG_T2_FromDate,MG_T2_ToDate=TDT.MG_T2_ToDate FROM @TBL_7D2812B73A494DA79E48082B26C3333C TDT
							JOIN [7D2812B7-3A49-4DA7-9E48-082B26C3333C] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_T3_MiscDetails,MG_T2_ExpenditureTypeID,MG_T2_TravelAdvanceID,MG_T3_Amount,Expenditure_Type,MG_T2_FromDate,MG_T2_ToDate";

                                     tempInsertQuery=@"INSERT INTO @TBL_7D2812B73A494DA79E48082B26C3333C(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_T3_MiscDetails,MG_T2_ExpenditureTypeID,MG_T2_TravelAdvanceID,MG_T3_Amount,Expenditure_Type,MG_T2_FromDate,MG_T2_ToDate)VALUES({0});";
                                     

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
                     
                                    case "9F49372F-0255-42EC-AB05-31E6C4F9F2EA":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_9F49372F025542ECAB0531E6C4F9F2EA AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_T3_TravelAdvanceID] VARCHAR(MAX)	, [MG_T2_Departure] VARCHAR(MAX)	, [MG_T2_TADetailsID] VARCHAR(MAX)	, [MG_T2_DepartureTime] VARCHAR(MAX)	, [MG_T2_ArrivalTime] VARCHAR(MAX)	, [MG_T2_Arrival] VARCHAR(MAX)	, [MG_T2_PNRNo] VARCHAR(MAX)	, [MG_T2_Amount] INT	, [MG_T2_Road] INT	, [MG_T2_ModeofJourney] VARCHAR(250)	, [MG_T2_JourneyClass] VARCHAR(250)	, [MG_T2_DepartureDate] DATETIME	, [MG_T2_ArrivalDate] DATETIME){0}INSERT INTO [9F49372F-0255-42EC-AB05-31E6C4F9F2EA](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_T3_TravelAdvanceID,MG_T2_Departure,MG_T2_TADetailsID,MG_T2_DepartureTime,MG_T2_ArrivalTime,MG_T2_Arrival,MG_T2_PNRNo,MG_T2_Amount,MG_T2_Road,MG_T2_ModeofJourney,MG_T2_JourneyClass,MG_T2_DepartureDate,MG_T2_ArrivalDate)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_T3_TravelAdvanceID,TDT.MG_T2_Departure,TDT.MG_T2_TADetailsID,TDT.MG_T2_DepartureTime,TDT.MG_T2_ArrivalTime,TDT.MG_T2_Arrival,TDT.MG_T2_PNRNo,TDT.MG_T2_Amount,TDT.MG_T2_Road,TDT.MG_T2_ModeofJourney,TDT.MG_T2_JourneyClass,TDT.MG_T2_DepartureDate,TDT.MG_T2_ArrivalDate FROM @TBL_9F49372F025542ECAB0531E6C4F9F2EA TDT
							LEFT JOIN [9F49372F-0255-42EC-AB05-31E6C4F9F2EA] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MG_T3_TravelAdvanceID=TDT.MG_T3_TravelAdvanceID,MG_T2_Departure=TDT.MG_T2_Departure,MG_T2_TADetailsID=TDT.MG_T2_TADetailsID,MG_T2_DepartureTime=TDT.MG_T2_DepartureTime,MG_T2_ArrivalTime=TDT.MG_T2_ArrivalTime,MG_T2_Arrival=TDT.MG_T2_Arrival,MG_T2_PNRNo=TDT.MG_T2_PNRNo,MG_T2_Amount=TDT.MG_T2_Amount,MG_T2_Road=TDT.MG_T2_Road,MG_T2_ModeofJourney=TDT.MG_T2_ModeofJourney,MG_T2_JourneyClass=TDT.MG_T2_JourneyClass,MG_T2_DepartureDate=TDT.MG_T2_DepartureDate,MG_T2_ArrivalDate=TDT.MG_T2_ArrivalDate FROM @TBL_9F49372F025542ECAB0531E6C4F9F2EA TDT
							JOIN [9F49372F-0255-42EC-AB05-31E6C4F9F2EA] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_T3_TravelAdvanceID,MG_T2_Departure,MG_T2_TADetailsID,MG_T2_DepartureTime,MG_T2_ArrivalTime,MG_T2_Arrival,MG_T2_PNRNo,MG_T2_Amount,MG_T2_Road,MG_T2_ModeofJourney,MG_T2_JourneyClass,MG_T2_DepartureDate,MG_T2_ArrivalDate";

                                     tempInsertQuery=@"INSERT INTO @TBL_9F49372F025542ECAB0531E6C4F9F2EA(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_T3_TravelAdvanceID,MG_T2_Departure,MG_T2_TADetailsID,MG_T2_DepartureTime,MG_T2_ArrivalTime,MG_T2_Arrival,MG_T2_PNRNo,MG_T2_Amount,MG_T2_Road,MG_T2_ModeofJourney,MG_T2_JourneyClass,MG_T2_DepartureDate,MG_T2_ArrivalDate)VALUES({0});";
                                     

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
                     

                                         case "BD17B4AF-1152-47EA-9EEB-DDA244A8B9F9":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_BD17B4AF115247EA9EEBDDA244A8B9F9 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_BudgetName] VARCHAR(MAX)	, [MG_SanctionedAmount] DECIMAL(18,2)	, [MG_Balance] DECIMAL(18,2)	, [MG_ReceivedAmount] DECIMAL(18,2)	, [MG_Commitment] DECIMAL(18,2)	, [MG_YetToReceive] DECIMAL(18,2)	, [MG_Spent] DECIMAL(18,2)){0}INSERT INTO [BD17B4AF-1152-47EA-9EEB-DDA244A8B9F9](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_BudgetName,MG_SanctionedAmount,MG_Balance,MG_ReceivedAmount,MG_Commitment,MG_YetToReceive,MG_Spent)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_BudgetName,TDT.MG_SanctionedAmount,TDT.MG_Balance,TDT.MG_ReceivedAmount,TDT.MG_Commitment,TDT.MG_YetToReceive,TDT.MG_Spent FROM @TBL_BD17B4AF115247EA9EEBDDA244A8B9F9 TDT
							LEFT JOIN [BD17B4AF-1152-47EA-9EEB-DDA244A8B9F9] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MG_BudgetName=TDT.MG_BudgetName,MG_SanctionedAmount=TDT.MG_SanctionedAmount,MG_Balance=TDT.MG_Balance,MG_ReceivedAmount=TDT.MG_ReceivedAmount,MG_Commitment=TDT.MG_Commitment,MG_YetToReceive=TDT.MG_YetToReceive,MG_Spent=TDT.MG_Spent FROM @TBL_BD17B4AF115247EA9EEBDDA244A8B9F9 TDT
							JOIN [BD17B4AF-1152-47EA-9EEB-DDA244A8B9F9] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_BudgetName,MG_SanctionedAmount,MG_Balance,MG_ReceivedAmount,MG_Commitment,MG_YetToReceive,MG_Spent";

                            tempInsertQuery=@"INSERT INTO @TBL_BD17B4AF115247EA9EEBDDA244A8B9F9(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_BudgetName,MG_SanctionedAmount,MG_Balance,MG_ReceivedAmount,MG_Commitment,MG_YetToReceive,MG_Spent)VALUES({0});";

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

                                              case "ee7fd670-c5c9-69f4-ccc3-80f0e8883f29":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_ee7fd670c5c969f4ccc380f0e8883f29 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_L1_OETravelAdvanceID] VARCHAR(MAX)	, [MG_L1_ExpenditureTypeID] VARCHAR(MAX)	, [MG_L1_OEAmount] DECIMAL(18,2)	, [MG_L1_Expenditure_Type] VARCHAR(250)	, [MG_L1_ToDate] DATETIME	, [MG_L1_FromDate] DATETIME){0}INSERT INTO [ee7fd670-c5c9-69f4-ccc3-80f0e8883f29](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_L1_OETravelAdvanceID,MG_L1_ExpenditureTypeID,MG_L1_OEAmount,MG_L1_Expenditure_Type,MG_L1_ToDate,MG_L1_FromDate)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_L1_OETravelAdvanceID,TDT.MG_L1_ExpenditureTypeID,TDT.MG_L1_OEAmount,TDT.MG_L1_Expenditure_Type,TDT.MG_L1_ToDate,TDT.MG_L1_FromDate FROM @TBL_ee7fd670c5c969f4ccc380f0e8883f29 TDT
							LEFT JOIN [ee7fd670-c5c9-69f4-ccc3-80f0e8883f29] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MG_L1_OETravelAdvanceID=TDT.MG_L1_OETravelAdvanceID,MG_L1_ExpenditureTypeID=TDT.MG_L1_ExpenditureTypeID,MG_L1_OEAmount=TDT.MG_L1_OEAmount,MG_L1_Expenditure_Type=TDT.MG_L1_Expenditure_Type,MG_L1_ToDate=TDT.MG_L1_ToDate,MG_L1_FromDate=TDT.MG_L1_FromDate FROM @TBL_ee7fd670c5c969f4ccc380f0e8883f29 TDT
							JOIN [ee7fd670-c5c9-69f4-ccc3-80f0e8883f29] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_L1_OETravelAdvanceID,MG_L1_ExpenditureTypeID,MG_L1_OEAmount,MG_L1_Expenditure_Type,MG_L1_ToDate,MG_L1_FromDate";

                            tempInsertQuery=@"INSERT INTO @TBL_ee7fd670c5c969f4ccc380f0e8883f29(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_L1_OETravelAdvanceID,MG_L1_ExpenditureTypeID,MG_L1_OEAmount,MG_L1_Expenditure_Type,MG_L1_ToDate,MG_L1_FromDate)VALUES({0});";

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

                                              case "e98f5784-8a4e-9d27-6b7a-42c76b854469":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_e98f57848a4e9d276b7a42c76b854469 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_L1_Amount] VARCHAR(MAX)	, [MG_L1_TravelAdvanceID] VARCHAR(MAX)	, [MG_L1_DepartureTime] VARCHAR(MAX)	, [MG_L1_Departure] VARCHAR(MAX)	, [MG_L1_ArrivalTime] VARCHAR(MAX)	, [MG_L1_Arrival] VARCHAR(MAX)	, [MG_L1_PNRNo] VARCHAR(MAX)	, [MG_L1_TADetailsID] VARCHAR(MAX)	, [MG_L1_Road] INT	, [MG_L1_JourneyClass] VARCHAR(250)	, [MG_L1_ModeofJourney] VARCHAR(250)	, [MG_L1_DepartureDate] DATETIME	, [MG_L1_ArrivalDate] DATETIME){0}INSERT INTO [e98f5784-8a4e-9d27-6b7a-42c76b854469](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_L1_Amount,MG_L1_TravelAdvanceID,MG_L1_DepartureTime,MG_L1_Departure,MG_L1_ArrivalTime,MG_L1_Arrival,MG_L1_PNRNo,MG_L1_TADetailsID,MG_L1_Road,MG_L1_JourneyClass,MG_L1_ModeofJourney,MG_L1_DepartureDate,MG_L1_ArrivalDate)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_L1_Amount,TDT.MG_L1_TravelAdvanceID,TDT.MG_L1_DepartureTime,TDT.MG_L1_Departure,TDT.MG_L1_ArrivalTime,TDT.MG_L1_Arrival,TDT.MG_L1_PNRNo,TDT.MG_L1_TADetailsID,TDT.MG_L1_Road,TDT.MG_L1_JourneyClass,TDT.MG_L1_ModeofJourney,TDT.MG_L1_DepartureDate,TDT.MG_L1_ArrivalDate FROM @TBL_e98f57848a4e9d276b7a42c76b854469 TDT
							LEFT JOIN [e98f5784-8a4e-9d27-6b7a-42c76b854469] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MG_L1_Amount=TDT.MG_L1_Amount,MG_L1_TravelAdvanceID=TDT.MG_L1_TravelAdvanceID,MG_L1_DepartureTime=TDT.MG_L1_DepartureTime,MG_L1_Departure=TDT.MG_L1_Departure,MG_L1_ArrivalTime=TDT.MG_L1_ArrivalTime,MG_L1_Arrival=TDT.MG_L1_Arrival,MG_L1_PNRNo=TDT.MG_L1_PNRNo,MG_L1_TADetailsID=TDT.MG_L1_TADetailsID,MG_L1_Road=TDT.MG_L1_Road,MG_L1_JourneyClass=TDT.MG_L1_JourneyClass,MG_L1_ModeofJourney=TDT.MG_L1_ModeofJourney,MG_L1_DepartureDate=TDT.MG_L1_DepartureDate,MG_L1_ArrivalDate=TDT.MG_L1_ArrivalDate FROM @TBL_e98f57848a4e9d276b7a42c76b854469 TDT
							JOIN [e98f5784-8a4e-9d27-6b7a-42c76b854469] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_L1_Amount,MG_L1_TravelAdvanceID,MG_L1_DepartureTime,MG_L1_Departure,MG_L1_ArrivalTime,MG_L1_Arrival,MG_L1_PNRNo,MG_L1_TADetailsID,MG_L1_Road,MG_L1_JourneyClass,MG_L1_ModeofJourney,MG_L1_DepartureDate,MG_L1_ArrivalDate";

                            tempInsertQuery=@"INSERT INTO @TBL_e98f57848a4e9d276b7a42c76b854469(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_L1_Amount,MG_L1_TravelAdvanceID,MG_L1_DepartureTime,MG_L1_Departure,MG_L1_ArrivalTime,MG_L1_Arrival,MG_L1_PNRNo,MG_L1_TADetailsID,MG_L1_Road,MG_L1_JourneyClass,MG_L1_ModeofJourney,MG_L1_DepartureDate,MG_L1_ArrivalDate)VALUES({0});";

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

                                              case "0BFAF73B-02D4-4680-B1C9-625AAFB02DB5":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_0BFAF73B02D44680B1C9625AAFB02DB5 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_FundDetailsID] VARCHAR(MAX)	, [MG_FundType] VARCHAR(MAX)	, [MG_BudgetHead] VARCHAR(MAX)	, [MG_ProjectDetailsId] VARCHAR(MAX)	, [MG_ProjectDesc] VARCHAR(MAX)	, [MG_Amount] DECIMAL(18,2)	, [MG_FundTypeId] INT){0}INSERT INTO [0BFAF73B-02D4-4680-B1C9-625AAFB02DB5](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_FundDetailsID,MG_FundType,MG_BudgetHead,MG_ProjectDetailsId,MG_ProjectDesc,MG_Amount,MG_FundTypeId)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_FundDetailsID,TDT.MG_FundType,TDT.MG_BudgetHead,TDT.MG_ProjectDetailsId,TDT.MG_ProjectDesc,TDT.MG_Amount,TDT.MG_FundTypeId FROM @TBL_0BFAF73B02D44680B1C9625AAFB02DB5 TDT
							LEFT JOIN [0BFAF73B-02D4-4680-B1C9-625AAFB02DB5] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MG_FundDetailsID=TDT.MG_FundDetailsID,MG_FundType=TDT.MG_FundType,MG_BudgetHead=TDT.MG_BudgetHead,MG_ProjectDetailsId=TDT.MG_ProjectDetailsId,MG_ProjectDesc=TDT.MG_ProjectDesc,MG_Amount=TDT.MG_Amount,MG_FundTypeId=TDT.MG_FundTypeId FROM @TBL_0BFAF73B02D44680B1C9625AAFB02DB5 TDT
							JOIN [0BFAF73B-02D4-4680-B1C9-625AAFB02DB5] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_FundDetailsID,MG_FundType,MG_BudgetHead,MG_ProjectDetailsId,MG_ProjectDesc,MG_Amount,MG_FundTypeId";

                            tempInsertQuery=@"INSERT INTO @TBL_0BFAF73B02D44680B1C9625AAFB02DB5(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_FundDetailsID,MG_FundType,MG_BudgetHead,MG_ProjectDetailsId,MG_ProjectDesc,MG_Amount,MG_FundTypeId)VALUES({0});";

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

                                              case "2624976A-0052-420C-8D20-F5C9444C7A48":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_2624976A0052420C8D20F5C9444C7A48 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [M_DocumentName] VARCHAR(MAX)	, [M_DocumentDetailsId] VARCHAR(MAX)	, [M_UploadDcoument] VARCHAR(36)){0}INSERT INTO [2624976A-0052-420C-8D20-F5C9444C7A48](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,M_DocumentName,M_DocumentDetailsId,M_UploadDcoument)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.M_DocumentName,TDT.M_DocumentDetailsId,TDT.M_UploadDcoument FROM @TBL_2624976A0052420C8D20F5C9444C7A48 TDT
							LEFT JOIN [2624976A-0052-420C-8D20-F5C9444C7A48] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,M_DocumentName=TDT.M_DocumentName,M_DocumentDetailsId=TDT.M_DocumentDetailsId,M_UploadDcoument=TDT.M_UploadDcoument FROM @TBL_2624976A0052420C8D20F5C9444C7A48 TDT
							JOIN [2624976A-0052-420C-8D20-F5C9444C7A48] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,M_DocumentName,M_DocumentDetailsId,M_UploadDcoument";

                            tempInsertQuery=@"INSERT INTO @TBL_2624976A0052420C8D20F5C9444C7A48(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,M_DocumentName,M_DocumentDetailsId,M_UploadDcoument)VALUES({0});";

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

                                              case "1234ab8a-bdd0-8930-2afd-ae17d0438c29":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_1234ab8abdd089302afdae17d0438c29 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_L1_FundDetailsID] VARCHAR(MAX)	, [MG_L1_FundType] VARCHAR(MAX)	, [MG_L1_ProjectDesc] VARCHAR(MAX)	, [MG_L1_ProjectDetailsId] VARCHAR(MAX)	, [MG_L1_BudgetHead] VARCHAR(MAX)	, [MG_L1_FundTypeId] INT	, [MG_L1_FTAmount] DECIMAL(18,2)){0}INSERT INTO [1234ab8a-bdd0-8930-2afd-ae17d0438c29](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_L1_FundDetailsID,MG_L1_FundType,MG_L1_ProjectDesc,MG_L1_ProjectDetailsId,MG_L1_BudgetHead,MG_L1_FundTypeId,MG_L1_FTAmount)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_L1_FundDetailsID,TDT.MG_L1_FundType,TDT.MG_L1_ProjectDesc,TDT.MG_L1_ProjectDetailsId,TDT.MG_L1_BudgetHead,TDT.MG_L1_FundTypeId,TDT.MG_L1_FTAmount FROM @TBL_1234ab8abdd089302afdae17d0438c29 TDT
							LEFT JOIN [1234ab8a-bdd0-8930-2afd-ae17d0438c29] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MG_L1_FundDetailsID=TDT.MG_L1_FundDetailsID,MG_L1_FundType=TDT.MG_L1_FundType,MG_L1_ProjectDesc=TDT.MG_L1_ProjectDesc,MG_L1_ProjectDetailsId=TDT.MG_L1_ProjectDetailsId,MG_L1_BudgetHead=TDT.MG_L1_BudgetHead,MG_L1_FundTypeId=TDT.MG_L1_FundTypeId,MG_L1_FTAmount=TDT.MG_L1_FTAmount FROM @TBL_1234ab8abdd089302afdae17d0438c29 TDT
							JOIN [1234ab8a-bdd0-8930-2afd-ae17d0438c29] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_L1_FundDetailsID,MG_L1_FundType,MG_L1_ProjectDesc,MG_L1_ProjectDetailsId,MG_L1_BudgetHead,MG_L1_FundTypeId,MG_L1_FTAmount";

                            tempInsertQuery=@"INSERT INTO @TBL_1234ab8abdd089302afdae17d0438c29(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_L1_FundDetailsID,MG_L1_FundType,MG_L1_ProjectDesc,MG_L1_ProjectDetailsId,MG_L1_BudgetHead,MG_L1_FundTypeId,MG_L1_FTAmount)VALUES({0});";

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

                                              case "7D2812B7-3A49-4DA7-9E48-082B26C3333C":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_7D2812B73A494DA79E48082B26C3333C AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_T3_MiscDetails] VARCHAR(MAX)	, [MG_T2_ExpenditureTypeID] VARCHAR(MAX)	, [MG_T2_TravelAdvanceID] VARCHAR(MAX)	, [MG_T3_Amount] INT	, [Expenditure_Type] VARCHAR(250)	, [MG_T2_FromDate] DATETIME	, [MG_T2_ToDate] DATETIME){0}INSERT INTO [7D2812B7-3A49-4DA7-9E48-082B26C3333C](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_T3_MiscDetails,MG_T2_ExpenditureTypeID,MG_T2_TravelAdvanceID,MG_T3_Amount,Expenditure_Type,MG_T2_FromDate,MG_T2_ToDate)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_T3_MiscDetails,TDT.MG_T2_ExpenditureTypeID,TDT.MG_T2_TravelAdvanceID,TDT.MG_T3_Amount,TDT.Expenditure_Type,TDT.MG_T2_FromDate,TDT.MG_T2_ToDate FROM @TBL_7D2812B73A494DA79E48082B26C3333C TDT
							LEFT JOIN [7D2812B7-3A49-4DA7-9E48-082B26C3333C] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MG_T3_MiscDetails=TDT.MG_T3_MiscDetails,MG_T2_ExpenditureTypeID=TDT.MG_T2_ExpenditureTypeID,MG_T2_TravelAdvanceID=TDT.MG_T2_TravelAdvanceID,MG_T3_Amount=TDT.MG_T3_Amount,Expenditure_Type=TDT.Expenditure_Type,MG_T2_FromDate=TDT.MG_T2_FromDate,MG_T2_ToDate=TDT.MG_T2_ToDate FROM @TBL_7D2812B73A494DA79E48082B26C3333C TDT
							JOIN [7D2812B7-3A49-4DA7-9E48-082B26C3333C] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_T3_MiscDetails,MG_T2_ExpenditureTypeID,MG_T2_TravelAdvanceID,MG_T3_Amount,Expenditure_Type,MG_T2_FromDate,MG_T2_ToDate";

                            tempInsertQuery=@"INSERT INTO @TBL_7D2812B73A494DA79E48082B26C3333C(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_T3_MiscDetails,MG_T2_ExpenditureTypeID,MG_T2_TravelAdvanceID,MG_T3_Amount,Expenditure_Type,MG_T2_FromDate,MG_T2_ToDate)VALUES({0});";

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

                                              case "9F49372F-0255-42EC-AB05-31E6C4F9F2EA":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_9F49372F025542ECAB0531E6C4F9F2EA AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_T3_TravelAdvanceID] VARCHAR(MAX)	, [MG_T2_Departure] VARCHAR(MAX)	, [MG_T2_TADetailsID] VARCHAR(MAX)	, [MG_T2_DepartureTime] VARCHAR(MAX)	, [MG_T2_ArrivalTime] VARCHAR(MAX)	, [MG_T2_Arrival] VARCHAR(MAX)	, [MG_T2_PNRNo] VARCHAR(MAX)	, [MG_T2_Amount] INT	, [MG_T2_Road] INT	, [MG_T2_ModeofJourney] VARCHAR(250)	, [MG_T2_JourneyClass] VARCHAR(250)	, [MG_T2_DepartureDate] DATETIME	, [MG_T2_ArrivalDate] DATETIME){0}INSERT INTO [9F49372F-0255-42EC-AB05-31E6C4F9F2EA](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_T3_TravelAdvanceID,MG_T2_Departure,MG_T2_TADetailsID,MG_T2_DepartureTime,MG_T2_ArrivalTime,MG_T2_Arrival,MG_T2_PNRNo,MG_T2_Amount,MG_T2_Road,MG_T2_ModeofJourney,MG_T2_JourneyClass,MG_T2_DepartureDate,MG_T2_ArrivalDate)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_T3_TravelAdvanceID,TDT.MG_T2_Departure,TDT.MG_T2_TADetailsID,TDT.MG_T2_DepartureTime,TDT.MG_T2_ArrivalTime,TDT.MG_T2_Arrival,TDT.MG_T2_PNRNo,TDT.MG_T2_Amount,TDT.MG_T2_Road,TDT.MG_T2_ModeofJourney,TDT.MG_T2_JourneyClass,TDT.MG_T2_DepartureDate,TDT.MG_T2_ArrivalDate FROM @TBL_9F49372F025542ECAB0531E6C4F9F2EA TDT
							LEFT JOIN [9F49372F-0255-42EC-AB05-31E6C4F9F2EA] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MG_T3_TravelAdvanceID=TDT.MG_T3_TravelAdvanceID,MG_T2_Departure=TDT.MG_T2_Departure,MG_T2_TADetailsID=TDT.MG_T2_TADetailsID,MG_T2_DepartureTime=TDT.MG_T2_DepartureTime,MG_T2_ArrivalTime=TDT.MG_T2_ArrivalTime,MG_T2_Arrival=TDT.MG_T2_Arrival,MG_T2_PNRNo=TDT.MG_T2_PNRNo,MG_T2_Amount=TDT.MG_T2_Amount,MG_T2_Road=TDT.MG_T2_Road,MG_T2_ModeofJourney=TDT.MG_T2_ModeofJourney,MG_T2_JourneyClass=TDT.MG_T2_JourneyClass,MG_T2_DepartureDate=TDT.MG_T2_DepartureDate,MG_T2_ArrivalDate=TDT.MG_T2_ArrivalDate FROM @TBL_9F49372F025542ECAB0531E6C4F9F2EA TDT
							JOIN [9F49372F-0255-42EC-AB05-31E6C4F9F2EA] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_T3_TravelAdvanceID,MG_T2_Departure,MG_T2_TADetailsID,MG_T2_DepartureTime,MG_T2_ArrivalTime,MG_T2_Arrival,MG_T2_PNRNo,MG_T2_Amount,MG_T2_Road,MG_T2_ModeofJourney,MG_T2_JourneyClass,MG_T2_DepartureDate,MG_T2_ArrivalDate";

                            tempInsertQuery=@"INSERT INTO @TBL_9F49372F025542ECAB0531E6C4F9F2EA(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_T3_TravelAdvanceID,MG_T2_Departure,MG_T2_TADetailsID,MG_T2_DepartureTime,MG_T2_ArrivalTime,MG_T2_Arrival,MG_T2_PNRNo,MG_T2_Amount,MG_T2_Road,MG_T2_ModeofJourney,MG_T2_JourneyClass,MG_T2_DepartureDate,MG_T2_ArrivalDate)VALUES({0});";

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

                                              case "F9CBD66E-80AF-4A49-805E-978379D06B55":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_F9CBD66E80AF4A49805E978379D06B55 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [RemarksId] VARCHAR(MAX)	, [Remarks] VARCHAR(MAX)	, [ActivityName] VARCHAR(MAX)	, [UserName] VARCHAR(MAX)	, [DateOfRemarks] DATETIME){0}INSERT INTO [F9CBD66E-80AF-4A49-805E-978379D06B55](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,RemarksId,Remarks,ActivityName,UserName,DateOfRemarks)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.RemarksId,TDT.Remarks,TDT.ActivityName,TDT.UserName,TDT.DateOfRemarks FROM @TBL_F9CBD66E80AF4A49805E978379D06B55 TDT
							LEFT JOIN [F9CBD66E-80AF-4A49-805E-978379D06B55] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,RemarksId=TDT.RemarksId,Remarks=TDT.Remarks,ActivityName=TDT.ActivityName,UserName=TDT.UserName,DateOfRemarks=TDT.DateOfRemarks FROM @TBL_F9CBD66E80AF4A49805E978379D06B55 TDT
							JOIN [F9CBD66E-80AF-4A49-805E-978379D06B55] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,RemarksId,Remarks,ActivityName,UserName,DateOfRemarks";

                            tempInsertQuery=@"INSERT INTO @TBL_F9CBD66E80AF4A49805E978379D06B55(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,RemarksId,Remarks,ActivityName,UserName,DateOfRemarks)VALUES({0});";

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
public class ISpace0D9E568F8790489DA8463C6057A39268 : VirtualForm
{
IISpace iSpace = new ISpace();
AcDataISpace0D9E568F8790489DA8463C6057A39268 acdataIspace0D9E568F8790489DA8463C6057A39268=new AcDataISpace0D9E568F8790489DA8463C6057A39268();
private void SubscribeFormEvents_root(ref Dictionary<string, ServiceElementData> ISpace)
{
try
{
base.WriteDebugInfo(@"Root-OnAfterFormLoad");
ISpace["M_TravelInstanceId"].Value=Guid.NewGuid().ToString();
base.WriteDebugInfo(@"ISpace[""M_TravelInstanceId""].Value=Guid.NewGuid().ToString();");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["M_InitiatorUserMapId"].Value=ISpace["gv_usermapid"].Value;
base.WriteDebugInfo(@"ISpace[""M_InitiatorUserMapId""].Value=ISpace[""gv_usermapid""].Value;");
if(ISpace["FormVersionId"].Value=="7952C83C-2CDF-4039-A6A9-BF37615109C8")
{
ISpace["UI_InvisibleRow"].Visible="false";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""7952C83C-2CDF-4039-A6A9-BF37615109C8"")
{
ISpace[""UI_InvisibleRow""].Visible=""false"";
}");
base.WriteDebugInfo(@"EXEC [GetEmployeeUserContextDetails] '@@gv_UserId'");

var querySource6EDD76BB4D26460AAC08830AA164885A =GetQueryExpressionDataSource("6EDD76BB-4D26-460A-AC08-830AA164885A");
Dictionary<short,object> result6EDD76BB4D26460AAC08830AA164885A=iSpace.ExecuteQuery(querySource6EDD76BB4D26460AAC08830AA164885A,@"EXEC [GetEmployeeUserContextDetails] '" + ISpace["gv_userid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource6EDD76BB4D26460AAC08830AA164885A =GetQueryExpressionDataSource(""6EDD76BB-4D26-460A-AC08-830AA164885A"");Dictionary<short,object> result6EDD76BB4D26460AAC08830AA164885A=iSpace.ExecuteQuery(querySource6EDD76BB4D26460AAC08830AA164885A,@""EXEC [GetEmployeeUserContextDetails] '"" + ISpace[""gv_userid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result6EDD76BB4D26460AAC08830AA164885A!=null) && (result6EDD76BB4D26460AAC08830AA164885A.Count!=0))
{
if(result6EDD76BB4D26460AAC08830AA164885A.ContainsKey(5))
ISpace["UC_PhoneNumber"].Value = result6EDD76BB4D26460AAC08830AA164885A[5];
if(result6EDD76BB4D26460AAC08830AA164885A.ContainsKey(11))
ISpace["UC_Grade"].Value = result6EDD76BB4D26460AAC08830AA164885A[11];
if(result6EDD76BB4D26460AAC08830AA164885A.ContainsKey(12))
ISpace["UC_Paylevel"].Value = result6EDD76BB4D26460AAC08830AA164885A[12];
if(result6EDD76BB4D26460AAC08830AA164885A.ContainsKey(7))
ISpace["UC_Designation"].Value = result6EDD76BB4D26460AAC08830AA164885A[7];
if(result6EDD76BB4D26460AAC08830AA164885A.ContainsKey(2))
ISpace["UC_Name"].Value = result6EDD76BB4D26460AAC08830AA164885A[2];
if(result6EDD76BB4D26460AAC08830AA164885A.ContainsKey(6))
ISpace["UC_Department"].Value = result6EDD76BB4D26460AAC08830AA164885A[6];
if(result6EDD76BB4D26460AAC08830AA164885A.ContainsKey(10))
ISpace["UC_DOR"].Value = result6EDD76BB4D26460AAC08830AA164885A[10];
if(result6EDD76BB4D26460AAC08830AA164885A.ContainsKey(4))
ISpace["UC_DOJ"].Value = result6EDD76BB4D26460AAC08830AA164885A[4];
if(result6EDD76BB4D26460AAC08830AA164885A.ContainsKey(3))
ISpace["UC_EmailId"].Value = result6EDD76BB4D26460AAC08830AA164885A[3];
if(result6EDD76BB4D26460AAC08830AA164885A.ContainsKey(9))
ISpace["UC_DOB"].Value = result6EDD76BB4D26460AAC08830AA164885A[9];
if(result6EDD76BB4D26460AAC08830AA164885A.ContainsKey(1))
ISpace["UC_EmployeeId"].Value = result6EDD76BB4D26460AAC08830AA164885A[1];
if(result6EDD76BB4D26460AAC08830AA164885A.ContainsKey(0))
ISpace["UC_EmployeeBaicInfoId"].Value = result6EDD76BB4D26460AAC08830AA164885A[0];
}
else{
ISpace["UC_PhoneNumber"].Value = null;ISpace["UC_Grade"].Value = null;ISpace["UC_Paylevel"].Value = null;ISpace["UC_Designation"].Value = null;ISpace["UC_Name"].Value = null;ISpace["UC_Department"].Value = null;ISpace["UC_DOR"].Value = null;ISpace["UC_DOJ"].Value = null;ISpace["UC_EmailId"].Value = null;ISpace["UC_DOB"].Value = null;ISpace["UC_EmployeeId"].Value = null;ISpace["UC_EmployeeBaicInfoId"].Value = null;
}
ISpace["M_MiscDetails"].Visible="false";ISpace["M_IsAdvanceRequired"].Enbl="false";ISpace["Travel_Type"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""M_MiscDetails""].Visible=""false"";ISpace[""M_IsAdvanceRequired""].Enbl=""false"";ISpace[""Travel_Type""].Enbl=""false"";");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC [GetEmployeeUserContextDetails] '@@gv_UserId'");

var querySourceEC6B13CB059E4F92AA679389538CBAE4 =GetQueryExpressionDataSource("EC6B13CB-059E-4F92-AA67-9389538CBAE4");
Dictionary<short,object> resultEC6B13CB059E4F92AA679389538CBAE4=iSpace.ExecuteQuery(querySourceEC6B13CB059E4F92AA679389538CBAE4,@"EXEC [GetEmployeeUserContextDetails] '" + ISpace["gv_userid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceEC6B13CB059E4F92AA679389538CBAE4 =GetQueryExpressionDataSource(""EC6B13CB-059E-4F92-AA67-9389538CBAE4"");Dictionary<short,object> resultEC6B13CB059E4F92AA679389538CBAE4=iSpace.ExecuteQuery(querySourceEC6B13CB059E4F92AA679389538CBAE4,@""EXEC [GetEmployeeUserContextDetails] '"" + ISpace[""gv_userid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultEC6B13CB059E4F92AA679389538CBAE4!=null) && (resultEC6B13CB059E4F92AA679389538CBAE4.Count!=0))
{
if(resultEC6B13CB059E4F92AA679389538CBAE4.ContainsKey(5))
ISpace["UC_PhoneNumber"].Value = resultEC6B13CB059E4F92AA679389538CBAE4[5];
if(resultEC6B13CB059E4F92AA679389538CBAE4.ContainsKey(11))
ISpace["UC_Grade"].Value = resultEC6B13CB059E4F92AA679389538CBAE4[11];
if(resultEC6B13CB059E4F92AA679389538CBAE4.ContainsKey(12))
ISpace["UC_Paylevel"].Value = resultEC6B13CB059E4F92AA679389538CBAE4[12];
if(resultEC6B13CB059E4F92AA679389538CBAE4.ContainsKey(7))
ISpace["UC_Designation"].Value = resultEC6B13CB059E4F92AA679389538CBAE4[7];
if(resultEC6B13CB059E4F92AA679389538CBAE4.ContainsKey(2))
ISpace["UC_Name"].Value = resultEC6B13CB059E4F92AA679389538CBAE4[2];
if(resultEC6B13CB059E4F92AA679389538CBAE4.ContainsKey(6))
ISpace["UC_Department"].Value = resultEC6B13CB059E4F92AA679389538CBAE4[6];
if(resultEC6B13CB059E4F92AA679389538CBAE4.ContainsKey(10))
ISpace["UC_DOR"].Value = resultEC6B13CB059E4F92AA679389538CBAE4[10];
if(resultEC6B13CB059E4F92AA679389538CBAE4.ContainsKey(4))
ISpace["UC_DOJ"].Value = resultEC6B13CB059E4F92AA679389538CBAE4[4];
if(resultEC6B13CB059E4F92AA679389538CBAE4.ContainsKey(3))
ISpace["UC_EmailId"].Value = resultEC6B13CB059E4F92AA679389538CBAE4[3];
if(resultEC6B13CB059E4F92AA679389538CBAE4.ContainsKey(9))
ISpace["UC_DOB"].Value = resultEC6B13CB059E4F92AA679389538CBAE4[9];
if(resultEC6B13CB059E4F92AA679389538CBAE4.ContainsKey(1))
ISpace["UC_EmployeeId"].Value = resultEC6B13CB059E4F92AA679389538CBAE4[1];
if(resultEC6B13CB059E4F92AA679389538CBAE4.ContainsKey(0))
ISpace["UC_EmployeeBaicInfoId"].Value = resultEC6B13CB059E4F92AA679389538CBAE4[0];
}
else{
ISpace["UC_PhoneNumber"].Value = null;ISpace["UC_Grade"].Value = null;ISpace["UC_Paylevel"].Value = null;ISpace["UC_Designation"].Value = null;ISpace["UC_Name"].Value = null;ISpace["UC_Department"].Value = null;ISpace["UC_DOR"].Value = null;ISpace["UC_DOJ"].Value = null;ISpace["UC_EmailId"].Value = null;ISpace["UC_DOB"].Value = null;ISpace["UC_EmployeeId"].Value = null;ISpace["UC_EmployeeBaicInfoId"].Value = null;
}
ISpace["Subject"].Value="Travel Settlement";
base.WriteDebugInfo(@"ISpace[""Subject""].Value=""Travel Settlement"";");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["MF_T1_BeneficiaryName"].Visible="true";ISpace["MF_T1_TravelType"].Visible="true";ISpace["MF_T1_ReferenceNo"].Visible="true";ISpace["MF_T1_Destination"].Visible="true";ISpace["MF_T1_AvailableBudget"].Visible="true";ISpace["MF_T1_AccountNo"].Visible="true";ISpace["MF_T1_TravellingPerson"].Visible="true";ISpace["MFG_T2_ArrivalDate"].Visible="true";ISpace["MFG_T2_ModeofJourney"].Visible="true";ISpace["MF_T1_JourneyPurpose"].Visible="true";ISpace["MFG_T2_Road"].Visible="true";ISpace["MFG_T2_ArrivalTime"].Visible="true";ISpace["MF_T1_ProjectNo"].Visible="true";ISpace["MF_T1_AdvanceAmount"].Visible="true";ISpace["MF_T1_TravelAdvanceID"].Visible="false";ISpace["MF_T1_BankName"].Visible="true";ISpace["MF_T1_BankBranch"].Visible="true";ISpace["MFG_T2_DepartureDate"].Visible="true";ISpace["MFG_T2_Departure"].Visible="true";ISpace["MFG_T2_PNRNo"].Visible="true";ISpace["MFG_T2_Amount"].Visible="true";ISpace["MF_T1_BankDocument"].Visible="true";ISpace["MFG_T2_JourneyClass"].Visible="true";ISpace["MF_T1_BudgetHead"].Visible="true";ISpace["MFG_T2_DepartureTime"].Visible="true";ISpace["MFG_T2_FromDate"].Visible="true";ISpace["MFG_T2_Arrival"].Visible="true";ISpace["MFG_T2_ToDate"].Visible="true";ISpace["MFG_T3_Amount"].Visible="true";
base.WriteDebugInfo(@"ISpace[""MF_T1_BeneficiaryName""].Visible=""true"";ISpace[""MF_T1_TravelType""].Visible=""true"";ISpace[""MF_T1_ReferenceNo""].Visible=""true"";ISpace[""MF_T1_Destination""].Visible=""true"";ISpace[""MF_T1_AvailableBudget""].Visible=""true"";ISpace[""MF_T1_AccountNo""].Visible=""true"";ISpace[""MF_T1_TravellingPerson""].Visible=""true"";ISpace[""MFG_T2_ArrivalDate""].Visible=""true"";ISpace[""MFG_T2_ModeofJourney""].Visible=""true"";ISpace[""MF_T1_JourneyPurpose""].Visible=""true"";ISpace[""MFG_T2_Road""].Visible=""true"";ISpace[""MFG_T2_ArrivalTime""].Visible=""true"";ISpace[""MF_T1_ProjectNo""].Visible=""true"";ISpace[""MF_T1_AdvanceAmount""].Visible=""true"";ISpace[""MF_T1_TravelAdvanceID""].Visible=""false"";ISpace[""MF_T1_BankName""].Visible=""true"";ISpace[""MF_T1_BankBranch""].Visible=""true"";ISpace[""MFG_T2_DepartureDate""].Visible=""true"";ISpace[""MFG_T2_Departure""].Visible=""true"";ISpace[""MFG_T2_PNRNo""].Visible=""true"";ISpace[""MFG_T2_Amount""].Visible=""true"";ISpace[""MF_T1_BankDocument""].Visible=""true"";ISpace[""MFG_T2_JourneyClass""].Visible=""true"";ISpace[""MF_T1_BudgetHead""].Visible=""true"";ISpace[""MFG_T2_DepartureTime""].Visible=""true"";ISpace[""MFG_T2_FromDate""].Visible=""true"";ISpace[""MFG_T2_Arrival""].Visible=""true"";ISpace[""MFG_T2_ToDate""].Visible=""true"";ISpace[""MFG_T3_Amount""].Visible=""true"";");

ISpace["M_OpenModal"].Visible="false";
base.WriteDebugInfo(@"ISpace[""M_OpenModal""].Visible=""false"";");
ISpace["M_IsAdvanceRequired"].Enbl="false";ISpace["Travel_Type"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""M_IsAdvanceRequired""].Enbl=""false"";ISpace[""Travel_Type""].Enbl=""false"";");
ISpace["MG_T3_TravelAdvanceID"].Visible="false";ISpace["MG_T2_ModeofJourney"].Visible="true";ISpace["MG_T2_JourneyClass"].Visible="true";ISpace["MG_T2_Departure"].Visible="true";ISpace["MG_T2_TADetailsID"].Visible="false";ISpace["MG_T2_Amount"].Visible="true";ISpace["MG_T2_DepartureTime"].Visible="true";ISpace["MG_T2_ArrivalTime"].Visible="true";ISpace["MG_T2_Road"].Visible="true";ISpace["MG_T2_DepartureDate"].Visible="true";ISpace["MG_T2_Arrival"].Visible="true";ISpace["MG_T2_ArrivalDate"].Visible="true";ISpace["MG_T2_PNRNo"].Visible="true";
base.WriteDebugInfo(@"ISpace[""MG_T3_TravelAdvanceID""].Visible=""false"";ISpace[""MG_T2_ModeofJourney""].Visible=""true"";ISpace[""MG_T2_JourneyClass""].Visible=""true"";ISpace[""MG_T2_Departure""].Visible=""true"";ISpace[""MG_T2_TADetailsID""].Visible=""false"";ISpace[""MG_T2_Amount""].Visible=""true"";ISpace[""MG_T2_DepartureTime""].Visible=""true"";ISpace[""MG_T2_ArrivalTime""].Visible=""true"";ISpace[""MG_T2_Road""].Visible=""true"";ISpace[""MG_T2_DepartureDate""].Visible=""true"";ISpace[""MG_T2_Arrival""].Visible=""true"";ISpace[""MG_T2_ArrivalDate""].Visible=""true"";ISpace[""MG_T2_PNRNo""].Visible=""true"";");
ISpace["MG_T2_ExpenditureTypeID"].Visible="false";ISpace["MG_T2_FromDate"].Visible="true";ISpace["MG_T2_ToDate"].Visible="true";ISpace["MG_T3_Amount"].Visible="true";ISpace["MG_T2_TravelAdvanceID"].Visible="false";
base.WriteDebugInfo(@"ISpace[""MG_T2_ExpenditureTypeID""].Visible=""false"";ISpace[""MG_T2_FromDate""].Visible=""true"";ISpace[""MG_T2_ToDate""].Visible=""true"";ISpace[""MG_T3_Amount""].Visible=""true"";ISpace[""MG_T2_TravelAdvanceID""].Visible=""false"";");
ISpace["MFG_T2_Road"].Visible="false";ISpace["MFG_T2_PNRNo"].Visible="false";
base.WriteDebugInfo(@"ISpace[""MFG_T2_Road""].Visible=""false"";ISpace[""MFG_T2_PNRNo""].Visible=""false"";");
}
if(1==2)
{
base.WriteDebugInfo(@"if(1==2)");
ISpace["Travel_Type"].Value="1110";
base.WriteDebugInfo(@"ISpace[""Travel_Type""].Value=""1110"";");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["MF_T1_TravelAdvanceID"].Value=ISpace["gv_instanceid"].Value;
base.WriteDebugInfo(@"ISpace[""MF_T1_TravelAdvanceID""].Value=ISpace[""gv_instanceid""].Value;");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["MF_Amount"].Visible="false";ISpace["MF_BudgetHead"].Visible="false";ISpace["MF_ProjectNo"].Visible="false";
base.WriteDebugInfo(@"ISpace[""MF_Amount""].Visible=""false"";ISpace[""MF_BudgetHead""].Visible=""false"";ISpace[""MF_ProjectNo""].Visible=""false"";");
ISpace["MF_InstanceId"].Value=Guid.NewGuid().ToString();
base.WriteDebugInfo(@"ISpace[""MF_InstanceId""].Value=Guid.NewGuid().ToString();");
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
ISpace["UC_PhoneNumber"].Visible="false";ISpace["UC_Grade"].Visible="false";ISpace["UC_Paylevel"].Visible="false";ISpace["UC_DOR"].Visible="false";ISpace["UC_DOJ"].Visible="false";ISpace["UC_EmailId"].Visible="false";ISpace["UC_DOB"].Visible="false";
base.WriteDebugInfo(@"ISpace[""UC_PhoneNumber""].Visible=""false"";ISpace[""UC_Grade""].Visible=""false"";ISpace[""UC_Paylevel""].Visible=""false"";ISpace[""UC_DOR""].Visible=""false"";ISpace[""UC_DOJ""].Visible=""false"";ISpace[""UC_EmailId""].Visible=""false"";ISpace[""UC_DOB""].Visible=""false"";");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["MF_T1_BeneficiaryName"].Man=true;ISpace["MF_T1_TravelType"].Man=true;ISpace["MF_T1_ReferenceNo"].Man=true;ISpace["MF_T1_Destination"].Man=true;ISpace["MF_T1_AvailableBudget"].Man=true;ISpace["MF_T1_AccountNo"].Man=true;ISpace["MF_T1_TravellingPerson"].Man=true;ISpace["MFG_T2_ArrivalDate"].Man=true;ISpace["MFG_T2_ModeofJourney"].Man=true;ISpace["MFG_T2_Road"].Man=true;ISpace["MFG_T2_ArrivalTime"].Man=true;ISpace["MF_T1_ProjectNo"].Man=true;ISpace["MF_T1_BankName"].Man=true;ISpace["MF_T1_BankBranch"].Man=true;ISpace["MFG_T2_DepartureDate"].Man=true;ISpace["MFG_T2_Departure"].Man=true;ISpace["MFG_T2_PNRNo"].Man=false;ISpace["MFG_T2_Amount"].Man=true;ISpace["MF_T1_BankDocument"].Man=true;ISpace["MFG_T2_JourneyClass"].Man=false;ISpace["MF_T1_BudgetHead"].Man=true;ISpace["MFG_T2_DepartureTime"].Man=true;ISpace["MFG_T2_FromDate"].Man=true;ISpace["MFG_T2_Arrival"].Man=true;ISpace["MFG_T2_ToDate"].Man=true;ISpace["MFG_T3_Amount"].Man=true;
base.WriteDebugInfo(@"ISpace[""MF_T1_BeneficiaryName""].Man=true;ISpace[""MF_T1_TravelType""].Man=true;ISpace[""MF_T1_ReferenceNo""].Man=true;ISpace[""MF_T1_Destination""].Man=true;ISpace[""MF_T1_AvailableBudget""].Man=true;ISpace[""MF_T1_AccountNo""].Man=true;ISpace[""MF_T1_TravellingPerson""].Man=true;ISpace[""MFG_T2_ArrivalDate""].Man=true;ISpace[""MFG_T2_ModeofJourney""].Man=true;ISpace[""MFG_T2_Road""].Man=true;ISpace[""MFG_T2_ArrivalTime""].Man=true;ISpace[""MF_T1_ProjectNo""].Man=true;ISpace[""MF_T1_BankName""].Man=true;ISpace[""MF_T1_BankBranch""].Man=true;ISpace[""MFG_T2_DepartureDate""].Man=true;ISpace[""MFG_T2_Departure""].Man=true;ISpace[""MFG_T2_PNRNo""].Man=false;ISpace[""MFG_T2_Amount""].Man=true;ISpace[""MF_T1_BankDocument""].Man=true;ISpace[""MFG_T2_JourneyClass""].Man=false;ISpace[""MF_T1_BudgetHead""].Man=true;ISpace[""MFG_T2_DepartureTime""].Man=true;ISpace[""MFG_T2_FromDate""].Man=true;ISpace[""MFG_T2_Arrival""].Man=true;ISpace[""MFG_T2_ToDate""].Man=true;ISpace[""MFG_T3_Amount""].Man=true;");
ISpace["M_ActualTransactionDate"].Man=true;ISpace["M_ActualTransactionNo"].Man=true;
base.WriteDebugInfo(@"ISpace[""M_ActualTransactionDate""].Man=true;ISpace[""M_ActualTransactionNo""].Man=true;");
ISpace["M_DocumentName"].Man=true;ISpace["M_UploadDcoument"].Man=true;
base.WriteDebugInfo(@"ISpace[""M_DocumentName""].Man=true;ISpace[""M_UploadDcoument""].Man=true;");
ISpace["MF_FundType"].Man=true;
base.WriteDebugInfo(@"ISpace[""MF_FundType""].Man=true;");
ISpace["MG_T2_ModeofJourney"].Man=true;ISpace["MG_T2_JourneyClass"].Man=false;ISpace["MG_T2_Departure"].Man=true;ISpace["MG_T2_Amount"].Man=true;ISpace["MG_T2_DepartureTime"].Man=true;ISpace["MG_T2_ArrivalTime"].Man=true;ISpace["MG_T2_DepartureDate"].Man=true;ISpace["MG_T2_Arrival"].Man=true;ISpace["MG_T2_ArrivalDate"].Man=true;
base.WriteDebugInfo(@"ISpace[""MG_T2_ModeofJourney""].Man=true;ISpace[""MG_T2_JourneyClass""].Man=false;ISpace[""MG_T2_Departure""].Man=true;ISpace[""MG_T2_Amount""].Man=true;ISpace[""MG_T2_DepartureTime""].Man=true;ISpace[""MG_T2_ArrivalTime""].Man=true;ISpace[""MG_T2_DepartureDate""].Man=true;ISpace[""MG_T2_Arrival""].Man=true;ISpace[""MG_T2_ArrivalDate""].Man=true;");
ISpace["MG_T2_FromDate"].Man=true;ISpace["MG_T2_ToDate"].Man=true;ISpace["MG_T3_Amount"].Man=true;
base.WriteDebugInfo(@"ISpace[""MG_T2_FromDate""].Man=true;ISpace[""MG_T2_ToDate""].Man=true;ISpace[""MG_T3_Amount""].Man=true;");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC GetDestinationDetails '#M_SourceActivityMapId'");

var querySourceDBDB2E68FF434B979BBF45C54F74665E =GetQueryExpressionDataSource("DBDB2E68-FF43-4B97-9BBF-45C54F74665E");
Dictionary<short,object> resultDBDB2E68FF434B979BBF45C54F74665E=iSpace.ExecuteQuery(querySourceDBDB2E68FF434B979BBF45C54F74665E,@"EXEC GetDestinationDetails '" + ISpace["M_SourceActivityMapId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceDBDB2E68FF434B979BBF45C54F74665E =GetQueryExpressionDataSource(""DBDB2E68-FF43-4B97-9BBF-45C54F74665E"");Dictionary<short,object> resultDBDB2E68FF434B979BBF45C54F74665E=iSpace.ExecuteQuery(querySourceDBDB2E68FF434B979BBF45C54F74665E,@""EXEC GetDestinationDetails '"" + ISpace[""M_SourceActivityMapId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultDBDB2E68FF434B979BBF45C54F74665E!=null) && (resultDBDB2E68FF434B979BBF45C54F74665E.Count!=0))
{
if(resultDBDB2E68FF434B979BBF45C54F74665E.ContainsKey(2))
ISpace["M_NextStage"].Value = resultDBDB2E68FF434B979BBF45C54F74665E[2];
if(resultDBDB2E68FF434B979BBF45C54F74665E.ContainsKey(5))
ISpace["M_Remarks"].Value = resultDBDB2E68FF434B979BBF45C54F74665E[5];
if(resultDBDB2E68FF434B979BBF45C54F74665E.ContainsKey(0))
ISpace["M_DestinationActivityId"].Value = resultDBDB2E68FF434B979BBF45C54F74665E[0];
}
else{
ISpace["M_NextStage"].Value = null;ISpace["M_Remarks"].Value = null;ISpace["M_DestinationActivityId"].Value = null;
}
}
if(ISpace["Travel_Type"].Value=="1")
{
base.WriteDebugInfo(@"if(ISpace[""Travel_Type""].Value==""1"")");
ISpace["MF_T1_BeneficiaryName"].Man=false;ISpace["MF_T1_AccountNo"].Man=false;ISpace["MF_T1_BankName"].Man=false;ISpace["MF_T1_BankBranch"].Man=false;ISpace["MF_T1_BankDocument"].Man=false;
base.WriteDebugInfo(@"ISpace[""MF_T1_BeneficiaryName""].Man=false;ISpace[""MF_T1_AccountNo""].Man=false;ISpace[""MF_T1_BankName""].Man=false;ISpace[""MF_T1_BankBranch""].Man=false;ISpace[""MF_T1_BankDocument""].Man=false;");
}
if(ISpace["Travel_Type"].Value=="3")
{
base.WriteDebugInfo(@"if(ISpace[""Travel_Type""].Value==""3"")");
ISpace["MF_T1_BeneficiaryName"].Man=true;ISpace["MF_T1_BeneficiaryName"].Enbl="true";ISpace["MF_T1_AccountNo"].Man=true;ISpace["MF_T1_AccountNo"].Enbl="true";ISpace["MF_T1_AdvanceAmount"].Man=true;ISpace["MF_T1_AdvanceAmount"].Enbl="true";ISpace["MF_T1_BankName"].Man=true;ISpace["MF_T1_BankName"].Enbl="true";ISpace["MF_T1_BankBranch"].Man=true;ISpace["MF_T1_BankBranch"].Enbl="true";ISpace["MF_T1_BankDocument"].Man=true;ISpace["MF_T1_BankDocument"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_T1_BeneficiaryName""].Man=true;ISpace[""MF_T1_BeneficiaryName""].Enbl=""true"";ISpace[""MF_T1_AccountNo""].Man=true;ISpace[""MF_T1_AccountNo""].Enbl=""true"";ISpace[""MF_T1_AdvanceAmount""].Man=true;ISpace[""MF_T1_AdvanceAmount""].Enbl=""true"";ISpace[""MF_T1_BankName""].Man=true;ISpace[""MF_T1_BankName""].Enbl=""true"";ISpace[""MF_T1_BankBranch""].Man=true;ISpace[""MF_T1_BankBranch""].Enbl=""true"";ISpace[""MF_T1_BankDocument""].Man=true;ISpace[""MF_T1_BankDocument""].Enbl=""true"";");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"SELECT CONCAT('IITDH/SRC/','22-23','/TA/',NEXT VALUE FOR TravelSeq)");

var querySourceE883B5B2F18C4602A27E420FD56789E3 =GetQueryExpressionDataSource("E883B5B2-F18C-4602-A27E-420FD56789E3");
Dictionary<short,object> resultE883B5B2F18C4602A27E420FD56789E3=iSpace.ExecuteQuery(querySourceE883B5B2F18C4602A27E420FD56789E3,@"SELECT CONCAT('IITDH/SRC/','22-23','/TA/',NEXT VALUE FOR TravelSeq)",false);

base.WriteDebugInfo(@"var querySourceE883B5B2F18C4602A27E420FD56789E3 =GetQueryExpressionDataSource(""E883B5B2-F18C-4602-A27E-420FD56789E3"");Dictionary<short,object> resultE883B5B2F18C4602A27E420FD56789E3=iSpace.ExecuteQuery(querySourceE883B5B2F18C4602A27E420FD56789E3,@""SELECT CONCAT('IITDH/SRC/','22-23','/TA/',NEXT VALUE FOR TravelSeq)"",false);");
base.WriteDebugInfo(@"");

if((resultE883B5B2F18C4602A27E420FD56789E3!=null) && (resultE883B5B2F18C4602A27E420FD56789E3.Count!=0))
{
if(resultE883B5B2F18C4602A27E420FD56789E3.ContainsKey(0))
ISpace["MF_T1_ReferenceNo"].Value = resultE883B5B2F18C4602A27E420FD56789E3[0];
}
else{
ISpace["MF_T1_ReferenceNo"].Value = null;
}
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_advanceamount (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"AdvanceAmount-OnChange");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_T1_AdvanceAmount"].Value>ISpace["T_AdvanceDrawn"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_T1_AdvanceAmount""].Value>ISpace[""T_AdvanceDrawn""].Value)");
ISpace["Message"].Value=@"Advance amount should be less than the 90% of Total Amount";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Advance amount should be less than the 90% of Total Amount"";");
ISpace["AdvanceAmount"].Value=null;
base.WriteDebugInfo(@"ISpace[""AdvanceAmount""].Value=null;");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_c_fc_projectno_33 (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"C_FC_ProjectNo_33-OnChange");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC GETReceiptAmountBalace 2,'#C_FC_ProjectNo_33'");

var querySource03AA5526D2904937ABD45C5942084D2F =GetQueryExpressionDataSource("03AA5526-D290-4937-ABD4-5C5942084D2F");
Dictionary<short,object> result03AA5526D2904937ABD45C5942084D2F=iSpace.ExecuteQuery(querySource03AA5526D2904937ABD45C5942084D2F,@"EXEC GETReceiptAmountBalace 2,'" + ISpace["C_FC_ProjectNo_33"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource03AA5526D2904937ABD45C5942084D2F =GetQueryExpressionDataSource(""03AA5526-D290-4937-ABD4-5C5942084D2F"");Dictionary<short,object> result03AA5526D2904937ABD45C5942084D2F=iSpace.ExecuteQuery(querySource03AA5526D2904937ABD45C5942084D2F,@""EXEC GETReceiptAmountBalace 2,'"" + ISpace[""C_FC_ProjectNo_33""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result03AA5526D2904937ABD45C5942084D2F!=null) && (result03AA5526D2904937ABD45C5942084D2F.Count!=0))
{
if(result03AA5526D2904937ABD45C5942084D2F.ContainsKey(2))
ISpace["C_FC_SanctionedDate_33"].Value = result03AA5526D2904937ABD45C5942084D2F[2];
if(result03AA5526D2904937ABD45C5942084D2F.ContainsKey(3))
ISpace["C_FC_StartDate_33"].Value = result03AA5526D2904937ABD45C5942084D2F[3];
if(result03AA5526D2904937ABD45C5942084D2F.ContainsKey(4))
ISpace["C_FC_EndDate_33"].Value = result03AA5526D2904937ABD45C5942084D2F[4];
if(result03AA5526D2904937ABD45C5942084D2F.ContainsKey(5))
ISpace["C_FC_SanctionNo_33"].Value = result03AA5526D2904937ABD45C5942084D2F[5];
if(result03AA5526D2904937ABD45C5942084D2F.ContainsKey(1))
ISpace["C_FC_ProjectName_33"].Value = result03AA5526D2904937ABD45C5942084D2F[1];
if(result03AA5526D2904937ABD45C5942084D2F.ContainsKey(7))
ISpace["C_FC_Category_33"].Value = result03AA5526D2904937ABD45C5942084D2F[7];
if(result03AA5526D2904937ABD45C5942084D2F.ContainsKey(8))
ISpace["C_FC_SanctionedValue_33"].Value = result03AA5526D2904937ABD45C5942084D2F[8];
if(result03AA5526D2904937ABD45C5942084D2F.ContainsKey(6))
ISpace["C_FC_AgencyCode_33"].Value = result03AA5526D2904937ABD45C5942084D2F[6];
}
else{
ISpace["C_FC_SanctionedDate_33"].Value = null;ISpace["C_FC_StartDate_33"].Value = null;ISpace["C_FC_EndDate_33"].Value = null;ISpace["C_FC_SanctionNo_33"].Value = null;ISpace["C_FC_ProjectName_33"].Value = null;ISpace["C_FC_Category_33"].Value = null;ISpace["C_FC_SanctionedValue_33"].Value = null;ISpace["C_FC_AgencyCode_33"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC GETReceiptAmountBalace 3,'#C_FC_ProjectNo_33'");

var querySourceBFC04E58208849F58A00F1DDCBA4ACF1 =GetQueryExpressionDataSource("BFC04E58-2088-49F5-8A00-F1DDCBA4ACF1");
Dictionary<short,object> resultBFC04E58208849F58A00F1DDCBA4ACF1=iSpace.ExecuteQuery(querySourceBFC04E58208849F58A00F1DDCBA4ACF1,@"EXEC GETReceiptAmountBalace 3,'" + ISpace["C_FC_ProjectNo_33"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceBFC04E58208849F58A00F1DDCBA4ACF1 =GetQueryExpressionDataSource(""BFC04E58-2088-49F5-8A00-F1DDCBA4ACF1"");Dictionary<short,object> resultBFC04E58208849F58A00F1DDCBA4ACF1=iSpace.ExecuteQuery(querySourceBFC04E58208849F58A00F1DDCBA4ACF1,@""EXEC GETReceiptAmountBalace 3,'"" + ISpace[""C_FC_ProjectNo_33""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultBFC04E58208849F58A00F1DDCBA4ACF1!=null) && (resultBFC04E58208849F58A00F1DDCBA4ACF1.Count!=0))
{
if(resultBFC04E58208849F58A00F1DDCBA4ACF1.ContainsKey(1))
ISpace["C_FC_BudgetHeadAmount"].Value = resultBFC04E58208849F58A00F1DDCBA4ACF1[1];
if(resultBFC04E58208849F58A00F1DDCBA4ACF1.ContainsKey(2))
ISpace["C_FC_ReceiptAmountinBudgetHead"].Value = resultBFC04E58208849F58A00F1DDCBA4ACF1[2];
}
else{
ISpace["C_FC_BudgetHeadAmount"].Value = null;ISpace["C_FC_ReceiptAmountinBudgetHead"].Value = null;
}
}
ISpace["Subject"].Value=ISpace["C_FC_ProjectName_33"].Value;
base.WriteDebugInfo(@"ISpace[""Subject""].Value=ISpace[""C_FC_ProjectName_33""].Value;");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_t_expendituretotal (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"T_ExpenditureTotal-OnChange");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["OverAll_Total"].Value=ISpace["T_ExpenditureTotal"].Value+ISpace["T_TravelAdvanceTotal"].Value;
base.WriteDebugInfo(@"ISpace[""OverAll_Total""].Value=ISpace[""T_ExpenditureTotal""].Value+ISpace[""T_TravelAdvanceTotal""].Value;");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"SELECT #OverAll_Total*0.9");

var querySourceB5136E55467F46BF9D46AE1BE798E3D4 =GetQueryExpressionDataSource("B5136E55-467F-46BF-9D46-AE1BE798E3D4");
Dictionary<short,object> resultB5136E55467F46BF9D46AE1BE798E3D4=iSpace.ExecuteQuery(querySourceB5136E55467F46BF9D46AE1BE798E3D4,@"SELECT " + ISpace["OverAll_Total"].Value + @"*0.9",false);

base.WriteDebugInfo(@"var querySourceB5136E55467F46BF9D46AE1BE798E3D4 =GetQueryExpressionDataSource(""B5136E55-467F-46BF-9D46-AE1BE798E3D4"");Dictionary<short,object> resultB5136E55467F46BF9D46AE1BE798E3D4=iSpace.ExecuteQuery(querySourceB5136E55467F46BF9D46AE1BE798E3D4,@""SELECT "" + ISpace[""OverAll_Total""].Value + @""*0.9"",false);");
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mfg_t2_expendituretypeid (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MFG_T2_ExpenditureTypeID-OnChange");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MFG_T2_ExpenditureTypeID"].Value=="1045")
{
base.WriteDebugInfo(@"if(ISpace[""MFG_T2_ExpenditureTypeID""].Value==""1045"")");
ISpace["M_MiscDetails"].Visible="true";ISpace["M_MiscDetails"].Man=true;
base.WriteDebugInfo(@"ISpace[""M_MiscDetails""].Visible=""true"";ISpace[""M_MiscDetails""].Man=true;");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["M_MiscDetails"].Visible="false";ISpace["M_MiscDetails"].Man=false;
base.WriteDebugInfo(@"ISpace[""M_MiscDetails""].Visible=""false"";ISpace[""M_MiscDetails""].Man=false;");
ISpace["M_MiscDetails"].Value=null;
base.WriteDebugInfo(@"ISpace[""M_MiscDetails""].Value=null;");
}
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mfg_t2_arrivaldate (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MFG_T2_ArrivalDate-OnChange");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MFG_T2_ArrivalDate"].Value<ISpace["MFG_T2_DepartureDate"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MFG_T2_ArrivalDate""].Value<ISpace[""MFG_T2_DepartureDate""].Value)");
ISpace["Message"].Value=@"Arrival Date should be greater than Departure Date";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Arrival Date should be greater than Departure Date"";");
ISpace["MFG_T2_ArrivalDate"].Value=null;
base.WriteDebugInfo(@"ISpace[""MFG_T2_ArrivalDate""].Value=null;");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_m_otherno (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"M_OtherNo-OnClick");
ISpace["growid"].Value="";
base.WriteDebugInfo(@"ISpace[""growid""].Value="""";");
ISpace["UI_DialogOther"].HideDialog=true;;
base.WriteDebugInfo(@"ISpace[""UI_DialogOther""].HideDialog=true;;");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mfg_t2_modeofjourney (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MFG_T2_ModeofJourney-OnChange");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["MFG_T2_JourneyClass"].rElemData=iSpace.Reload(ISpace["MFG_T2_JourneyClass"].Value,@"EXEC GetTravelAdvanceDetailCombo 7,'" + ISpace["MFG_T2_ModeofJourney"].Value + @"'","3A103712-5244-4427-B2B6-1C4E046FD337");
base.WriteDebugInfo(@"ISpace[""MFG_T2_JourneyClass""].rElemData=iSpace.Reload(ISpace[""MFG_T2_JourneyClass""].Value,@""EXEC GetTravelAdvanceDetailCombo 7,'"" + ISpace[""MFG_T2_ModeofJourney""].Value + @""'"",""3A103712-5244-4427-B2B6-1C4E046FD337"");");
}
if(ISpace["MFG_T2_ModeofJourney"].Value=="477")
{
base.WriteDebugInfo(@"if(ISpace[""MFG_T2_ModeofJourney""].Value==""477"")");
ISpace["MFG_T2_Road"].Visible="true";ISpace["MFG_T2_Road"].Man=false;ISpace["MFG_T2_PNRNo"].Visible="false";ISpace["MFG_T2_PNRNo"].Man=false;
base.WriteDebugInfo(@"ISpace[""MFG_T2_Road""].Visible=""true"";ISpace[""MFG_T2_Road""].Man=false;ISpace[""MFG_T2_PNRNo""].Visible=""false"";ISpace[""MFG_T2_PNRNo""].Man=false;");
}
if(ISpace["MFG_T2_ModeofJourney"].Value=="478"||ISpace["MFG_T2_ModeofJourney"].Value=="479")
{
base.WriteDebugInfo(@"if(ISpace[""MFG_T2_ModeofJourney""].Value==""478""||ISpace[""MFG_T2_ModeofJourney""].Value==""479"")");
ISpace["MFG_T2_Road"].Visible="false";ISpace["MFG_T2_Road"].Man=false;ISpace["MFG_T2_PNRNo"].Visible="true";ISpace["MFG_T2_PNRNo"].Man=true;
base.WriteDebugInfo(@"ISpace[""MFG_T2_Road""].Visible=""false"";ISpace[""MFG_T2_Road""].Man=false;ISpace[""MFG_T2_PNRNo""].Visible=""true"";ISpace[""MFG_T2_PNRNo""].Man=true;");
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
if(ISpace["R_ReferenceNo"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""R_ReferenceNo""].Value=="""")");
ISpace["Message"].Value=@"Please select Travel Reference No";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please select Travel Reference No"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if(ISpace["MF_GrdFundCount"].Value==0)
{
base.WriteDebugInfo(@"if(ISpace[""MF_GrdFundCount""].Value==0)");
ISpace["Message"].Value=@"Please enter at least one Funding Details";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please enter at least one Funding Details"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
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
ISpace["Message"].Value=@"Please Enter Document Name";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please Enter Document Name"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}

if(
IsNullOrEmpty(ISpace["M_UploadDcoument"].Value))
{
base.WriteDebugInfo(@"
if(
IsNullOrEmpty(ISpace[""M_UploadDcoument""].Value))");
ISpace["Message"].Value=@"Please Upload Document";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please Upload Document"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("MG_DcoumentDetails","2624976A-0052-420C-8D20-F5C9444C7A48",_objectFactory.GetGridRPP("MG_DcoumentDetails"),_elementBase.GetGridLoopQuery("2624976A-0052-420C-8D20-F5C9444C7A48","MG_DcoumentDetails",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""MG_DcoumentDetails"",ref ISpace);

foreach(var gridChild in ISpace[""MG_DcoumentDetails""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
}
if(ISpace["MF_T1_AdvanceAmount"].Value<0)
{
base.WriteDebugInfo(@"if(ISpace[""MF_T1_AdvanceAmount""].Value<0)");
if(ISpace["M_ActualTransactionNo"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""M_ActualTransactionNo""].Value=="""")");
ISpace["Message"].Value=@"Please Enter Transaction No";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please Enter Transaction No"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if((ISpace["M_ActualTransactionDate"].Value == null))
{
base.WriteDebugInfo(@"if((ISpace[""M_ActualTransactionDate""].Value == null))");
ISpace["Message"].Value=@"Please enter Transaction Date";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please enter Transaction Date"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"#M_FundAmount[Rows]");
iSpace.GetLoopExpressionData("M_FundAmount",ref ISpace);

foreach(var gridChild in ISpace["M_FundAmount"].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 

base.WriteDebugInfo(@"EXEC UpsertProjectBudgetDetails 7,'#MG_L1_ProjectDetailsId','#R_ReferenceNo','#MG_L1_FTAmount','#MG_L1_BudgetHead','1','#MG_L1_FundTypeId','#M_PackageProcessMapId','#UC_EmployeeBaicInfoId'");

var querySourcea39f50b8052d58d34891d914ec82bc69 =GetQueryExpressionDataSource("a39f50b8-052d-58d3-4891-d914ec82bc69");
Dictionary<short,object> resulta39f50b8052d58d34891d914ec82bc69=iSpace.ExecuteQuery(querySourcea39f50b8052d58d34891d914ec82bc69,@"EXEC UpsertProjectBudgetDetails 7,'" + ISpace["MG_L1_ProjectDetailsId"].Value + @"','" + ISpace["R_ReferenceNo"].Value + @"','" + ISpace["MG_L1_FTAmount"].Value + @"','" + ISpace["MG_L1_BudgetHead"].Value + @"','1','" + ISpace["MG_L1_FundTypeId"].Value + @"','" + ISpace["M_PackageProcessMapId"].Value + @"','" + ISpace["UC_EmployeeBaicInfoId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourcea39f50b8052d58d34891d914ec82bc69 =GetQueryExpressionDataSource(""a39f50b8-052d-58d3-4891-d914ec82bc69"");Dictionary<short,object> resulta39f50b8052d58d34891d914ec82bc69=iSpace.ExecuteQuery(querySourcea39f50b8052d58d34891d914ec82bc69,@""EXEC UpsertProjectBudgetDetails 7,'"" + ISpace[""MG_L1_ProjectDetailsId""].Value + @""','"" + ISpace[""R_ReferenceNo""].Value + @""','"" + ISpace[""MG_L1_FTAmount""].Value + @""','"" + ISpace[""MG_L1_BudgetHead""].Value + @""','1','"" + ISpace[""MG_L1_FundTypeId""].Value + @""','"" + ISpace[""M_PackageProcessMapId""].Value + @""','"" + ISpace[""UC_EmployeeBaicInfoId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resulta39f50b8052d58d34891d914ec82bc69!=null) && (resulta39f50b8052d58d34891d914ec82bc69.Count!=0))
{
if(resulta39f50b8052d58d34891d914ec82bc69.ContainsKey(0))
ISpace["A"].Value = resulta39f50b8052d58d34891d914ec82bc69[0];
}
else{
ISpace["A"].Value = null;
}
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("M_FundAmount","1234ab8a-bdd0-8930-2afd-ae17d0438c29",_objectFactory.GetGridRPP("M_FundAmount"),_elementBase.GetGridLoopQuery("1234ab8a-bdd0-8930-2afd-ae17d0438c29","M_FundAmount",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""M_FundAmount"",ref ISpace);

foreach(var gridChild in ISpace[""M_FundAmount""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
}
ISpace["MF_TravelStatus"].Value="I";
base.WriteDebugInfo(@"ISpace[""MF_TravelStatus""].Value=""I"";");
ISpace["M_IsCommitment"].Value=1;
base.WriteDebugInfo(@"ISpace[""M_IsCommitment""].Value=1;");
base.WriteDebugInfo(@"EXEC Repo198E5A8A61F54E7C92DD34146A7059EF '#M_ActualTransactionDate','#M_ActualTransactionDate','#R_ReferenceNo','#M_RandDTransactionNo','#OverAll_Total','#MF_TravelStatus','#M_ActualTransactionNo'");

var querySource98BF359EFA14492F88A17DFD32D76570 =GetQueryExpressionDataSource("98BF359E-FA14-492F-88A1-7DFD32D76570");
Dictionary<short,object> result98BF359EFA14492F88A17DFD32D76570=iSpace.ExecuteQuery(querySource98BF359EFA14492F88A17DFD32D76570,@"EXEC Repo198E5A8A61F54E7C92DD34146A7059EF '" + ISpace["M_ActualTransactionDate"].Value + @"','" + ISpace["M_ActualTransactionDate"].Value + @"','" + ISpace["R_ReferenceNo"].Value + @"','" + ISpace["M_RandDTransactionNo"].Value + @"','" + ISpace["OverAll_Total"].Value + @"','" + ISpace["MF_TravelStatus"].Value + @"','" + ISpace["M_ActualTransactionNo"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource98BF359EFA14492F88A17DFD32D76570 =GetQueryExpressionDataSource(""98BF359E-FA14-492F-88A1-7DFD32D76570"");Dictionary<short,object> result98BF359EFA14492F88A17DFD32D76570=iSpace.ExecuteQuery(querySource98BF359EFA14492F88A17DFD32D76570,@""EXEC Repo198E5A8A61F54E7C92DD34146A7059EF '"" + ISpace[""M_ActualTransactionDate""].Value + @""','"" + ISpace[""M_ActualTransactionDate""].Value + @""','"" + ISpace[""R_ReferenceNo""].Value + @""','"" + ISpace[""M_RandDTransactionNo""].Value + @""','"" + ISpace[""OverAll_Total""].Value + @""','"" + ISpace[""MF_TravelStatus""].Value + @""','"" + ISpace[""M_ActualTransactionNo""].Value + @""'"",false);");
base.WriteDebugInfo(@"EXEC Repo374fb8a88dd94cf1bf73f40ae18fcad7 '#M_IsTravelRequest','#UpdatedOn','#MG_T2_TADetailsID','#gv_UserId','#MG_T2_DepartureDate','#MG_T2_DepartureTime','#MG_T2_ArrivalDate','#MG_T2_Road','#R_ReferenceNo','#MG_T2_Departure','#MG_T2_Amount','#MG_T2_JourneyClass','#MG_T2_Arrival','#MG_T2_PNRNo','#MG_T2_ModeofJourney','#MG_T2_ArrivalTime'");

var querySource2A1DECB9E01F4B34AEB62F63419086A1 =GetQueryExpressionDataSource("2A1DECB9-E01F-4B34-AEB6-2F63419086A1");
Dictionary<short,object> result2A1DECB9E01F4B34AEB62F63419086A1=iSpace.ExecuteQuery(querySource2A1DECB9E01F4B34AEB62F63419086A1,@"EXEC Repo374fb8a88dd94cf1bf73f40ae18fcad7 '" + ISpace["M_IsTravelRequest"].Value + @"','" + ISpace["UpdatedOn"].Value + @"','" + ISpace["MG_T2_TADetailsID"].Value + @"','" + ISpace["gv_UserId"].Value + @"','" + ISpace["MG_T2_DepartureDate"].Value + @"','" + ISpace["MG_T2_DepartureTime"].Value + @"','" + ISpace["MG_T2_ArrivalDate"].Value + @"','" + ISpace["MG_T2_Road"].Value + @"','" + ISpace["R_ReferenceNo"].Value + @"','" + ISpace["MG_T2_Departure"].Value + @"','" + ISpace["MG_T2_Amount"].Value + @"','" + ISpace["MG_T2_JourneyClass"].Value + @"','" + ISpace["MG_T2_Arrival"].Value + @"','" + ISpace["MG_T2_PNRNo"].Value + @"','" + ISpace["MG_T2_ModeofJourney"].Value + @"','" + ISpace["MG_T2_ArrivalTime"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource2A1DECB9E01F4B34AEB62F63419086A1 =GetQueryExpressionDataSource(""2A1DECB9-E01F-4B34-AEB6-2F63419086A1"");Dictionary<short,object> result2A1DECB9E01F4B34AEB62F63419086A1=iSpace.ExecuteQuery(querySource2A1DECB9E01F4B34AEB62F63419086A1,@""EXEC Repo374fb8a88dd94cf1bf73f40ae18fcad7 '"" + ISpace[""M_IsTravelRequest""].Value + @""','"" + ISpace[""UpdatedOn""].Value + @""','"" + ISpace[""MG_T2_TADetailsID""].Value + @""','"" + ISpace[""gv_UserId""].Value + @""','"" + ISpace[""MG_T2_DepartureDate""].Value + @""','"" + ISpace[""MG_T2_DepartureTime""].Value + @""','"" + ISpace[""MG_T2_ArrivalDate""].Value + @""','"" + ISpace[""MG_T2_Road""].Value + @""','"" + ISpace[""R_ReferenceNo""].Value + @""','"" + ISpace[""MG_T2_Departure""].Value + @""','"" + ISpace[""MG_T2_Amount""].Value + @""','"" + ISpace[""MG_T2_JourneyClass""].Value + @""','"" + ISpace[""MG_T2_Arrival""].Value + @""','"" + ISpace[""MG_T2_PNRNo""].Value + @""','"" + ISpace[""MG_T2_ModeofJourney""].Value + @""','"" + ISpace[""MG_T2_ArrivalTime""].Value + @""'"",false);");
base.WriteDebugInfo(@"EXEC Repo51838b372ec64d358a5e38648bc93ab1 '#gv_UserId','#UpdatedOn','#R_ReferenceNo','#M_MiscDetails','#MG_T2_ToDate','#MG_T2_FromDate','#M_IsTravelRequest','#MG_T2_ExpenditureTypeID','#Expenditure_Type','#MG_T3_Amount'");

var querySourceF3E1046132264803B4FBB1BC501BB6F5 =GetQueryExpressionDataSource("F3E10461-3226-4803-B4FB-B1BC501BB6F5");
Dictionary<short,object> resultF3E1046132264803B4FBB1BC501BB6F5=iSpace.ExecuteQuery(querySourceF3E1046132264803B4FBB1BC501BB6F5,@"EXEC Repo51838b372ec64d358a5e38648bc93ab1 '" + ISpace["gv_UserId"].Value + @"','" + ISpace["UpdatedOn"].Value + @"','" + ISpace["R_ReferenceNo"].Value + @"','" + ISpace["M_MiscDetails"].Value + @"','" + ISpace["MG_T2_ToDate"].Value + @"','" + ISpace["MG_T2_FromDate"].Value + @"','" + ISpace["M_IsTravelRequest"].Value + @"','" + ISpace["MG_T2_ExpenditureTypeID"].Value + @"','" + ISpace["Expenditure_Type"].Value + @"','" + ISpace["MG_T3_Amount"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceF3E1046132264803B4FBB1BC501BB6F5 =GetQueryExpressionDataSource(""F3E10461-3226-4803-B4FB-B1BC501BB6F5"");Dictionary<short,object> resultF3E1046132264803B4FBB1BC501BB6F5=iSpace.ExecuteQuery(querySourceF3E1046132264803B4FBB1BC501BB6F5,@""EXEC Repo51838b372ec64d358a5e38648bc93ab1 '"" + ISpace[""gv_UserId""].Value + @""','"" + ISpace[""UpdatedOn""].Value + @""','"" + ISpace[""R_ReferenceNo""].Value + @""','"" + ISpace[""M_MiscDetails""].Value + @""','"" + ISpace[""MG_T2_ToDate""].Value + @""','"" + ISpace[""MG_T2_FromDate""].Value + @""','"" + ISpace[""M_IsTravelRequest""].Value + @""','"" + ISpace[""MG_T2_ExpenditureTypeID""].Value + @""','"" + ISpace[""Expenditure_Type""].Value + @""','"" + ISpace[""MG_T3_Amount""].Value + @""'"",false);");
base.WriteDebugInfo(@"EXEC DocumentsDomain '#M_DocumentDetailsId','#M_PackageProcessMapId','#UpdatedOn','#M_DocumentName','#gv_UserId','#M_UploadDcoument','#R_ReferenceNo'");

var querySourceC02380063D5A49CA8B25C5F643BF76D0 =GetQueryExpressionDataSource("C0238006-3D5A-49CA-8B25-C5F643BF76D0");
Dictionary<short,object> resultC02380063D5A49CA8B25C5F643BF76D0=iSpace.ExecuteQuery(querySourceC02380063D5A49CA8B25C5F643BF76D0,@"EXEC DocumentsDomain '" + ISpace["M_DocumentDetailsId"].Value + @"','" + ISpace["M_PackageProcessMapId"].Value + @"','" + ISpace["UpdatedOn"].Value + @"','" + ISpace["M_DocumentName"].Value + @"','" + ISpace["gv_UserId"].Value + @"','" + ISpace["M_UploadDcoument"].Value + @"','" + ISpace["R_ReferenceNo"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceC02380063D5A49CA8B25C5F643BF76D0 =GetQueryExpressionDataSource(""C0238006-3D5A-49CA-8B25-C5F643BF76D0"");Dictionary<short,object> resultC02380063D5A49CA8B25C5F643BF76D0=iSpace.ExecuteQuery(querySourceC02380063D5A49CA8B25C5F643BF76D0,@""EXEC DocumentsDomain '"" + ISpace[""M_DocumentDetailsId""].Value + @""','"" + ISpace[""M_PackageProcessMapId""].Value + @""','"" + ISpace[""UpdatedOn""].Value + @""','"" + ISpace[""M_DocumentName""].Value + @""','"" + ISpace[""gv_UserId""].Value + @""','"" + ISpace[""M_UploadDcoument""].Value + @""','"" + ISpace[""R_ReferenceNo""].Value + @""'"",false);");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"#MF_FundAmount[Rows]");
iSpace.GetLoopExpressionData("MF_FundAmount",ref ISpace);

foreach(var gridChild in ISpace["MF_FundAmount"].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 


if(
ISpace["MF_T1_AdvanceAmount"].Value>=0)
{
base.WriteDebugInfo(@"
if(
ISpace[""MF_T1_AdvanceAmount""].Value>=0)");
base.WriteDebugInfo(@"EXEC UpsertProjectBudgetDetails 5,'#MG_ProjectDetailsId','#R_ReferenceNo','#MG_Amount','#MG_BudgetHead','#M_IsCommitment','#MG_FundTypeid','#M_PackageProcessMapId','#UC_EmployeeBaicInfoId'");

var querySource90205139c57101bd3a5bd9675759a3ac =GetQueryExpressionDataSource("90205139-c571-01bd-3a5b-d9675759a3ac");
Dictionary<short,object> result90205139c57101bd3a5bd9675759a3ac=iSpace.ExecuteQuery(querySource90205139c57101bd3a5bd9675759a3ac,@"EXEC UpsertProjectBudgetDetails 5,'" + ISpace["MG_ProjectDetailsId"].Value + @"','" + ISpace["R_ReferenceNo"].Value + @"','" + ISpace["MG_Amount"].Value + @"','" + ISpace["MG_BudgetHead"].Value + @"','" + ISpace["M_IsCommitment"].Value + @"','" + ISpace["MG_FundTypeid"].Value + @"','" + ISpace["M_PackageProcessMapId"].Value + @"','" + ISpace["UC_EmployeeBaicInfoId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource90205139c57101bd3a5bd9675759a3ac =GetQueryExpressionDataSource(""90205139-c571-01bd-3a5b-d9675759a3ac"");Dictionary<short,object> result90205139c57101bd3a5bd9675759a3ac=iSpace.ExecuteQuery(querySource90205139c57101bd3a5bd9675759a3ac,@""EXEC UpsertProjectBudgetDetails 5,'"" + ISpace[""MG_ProjectDetailsId""].Value + @""','"" + ISpace[""R_ReferenceNo""].Value + @""','"" + ISpace[""MG_Amount""].Value + @""','"" + ISpace[""MG_BudgetHead""].Value + @""','"" + ISpace[""M_IsCommitment""].Value + @""','"" + ISpace[""MG_FundTypeid""].Value + @""','"" + ISpace[""M_PackageProcessMapId""].Value + @""','"" + ISpace[""UC_EmployeeBaicInfoId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result90205139c57101bd3a5bd9675759a3ac!=null) && (result90205139c57101bd3a5bd9675759a3ac.Count!=0))
{
if(result90205139c57101bd3a5bd9675759a3ac.ContainsKey(0))
ISpace["A"].Value = result90205139c57101bd3a5bd9675759a3ac[0];
}
else{
ISpace["A"].Value = null;
}
}
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("MF_FundAmount","0BFAF73B-02D4-4680-B1C9-625AAFB02DB5",_objectFactory.GetGridRPP("MF_FundAmount"),_elementBase.GetGridLoopQuery("0BFAF73B-02D4-4680-B1C9-625AAFB02DB5","MF_FundAmount",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""MF_FundAmount"",ref ISpace);

foreach(var gridChild in ISpace[""MF_FundAmount""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["SetDestinationTo"].Value=ISpace["M_DestinationActivityId"].Value;
base.WriteDebugInfo(@"ISpace[""SetDestinationTo""].Value=ISpace[""M_DestinationActivityId""].Value;");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC RemarksDomain '#M_IsSourceStep','#Updatedon','#M_InstanceId','#gv_UserId','#SetDestinationTo','#gv_UserName','#gv_ActivityName','#M_Remarks','#gv_TenantId','#TrailLogId','#M_SourceActivityMapId','#RemarksOn'");

var querySourceCFCAC7935C3F430199EA29692D7A07E4 =GetQueryExpressionDataSource("CFCAC793-5C3F-4301-99EA-29692D7A07E4");
Dictionary<short,object> resultCFCAC7935C3F430199EA29692D7A07E4=iSpace.ExecuteQuery(querySourceCFCAC7935C3F430199EA29692D7A07E4,@"EXEC RemarksDomain '" + ISpace["M_IsSourceStep"].Value + @"','" + ISpace["Updatedon"].Value + @"','" + ISpace["M_InstanceId"].Value + @"','" + ISpace["gv_UserId"].Value + @"','" + ISpace["SetDestinationTo"].Value + @"','" + ISpace["gv_UserName"].Value + @"','" + ISpace["gv_ActivityName"].Value + @"','" + ISpace["M_Remarks"].Value + @"','" + ISpace["gv_TenantId"].Value + @"','" + ISpace["TrailLogId"].Value + @"','" + ISpace["M_SourceActivityMapId"].Value + @"','" + ISpace["RemarksOn"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceCFCAC7935C3F430199EA29692D7A07E4 =GetQueryExpressionDataSource(""CFCAC793-5C3F-4301-99EA-29692D7A07E4"");Dictionary<short,object> resultCFCAC7935C3F430199EA29692D7A07E4=iSpace.ExecuteQuery(querySourceCFCAC7935C3F430199EA29692D7A07E4,@""EXEC RemarksDomain '"" + ISpace[""M_IsSourceStep""].Value + @""','"" + ISpace[""Updatedon""].Value + @""','"" + ISpace[""M_InstanceId""].Value + @""','"" + ISpace[""gv_UserId""].Value + @""','"" + ISpace[""SetDestinationTo""].Value + @""','"" + ISpace[""gv_UserName""].Value + @""','"" + ISpace[""gv_ActivityName""].Value + @""','"" + ISpace[""M_Remarks""].Value + @""','"" + ISpace[""gv_TenantId""].Value + @""','"" + ISpace[""TrailLogId""].Value + @""','"" + ISpace[""M_SourceActivityMapId""].Value + @""','"" + ISpace[""RemarksOn""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultCFCAC7935C3F430199EA29692D7A07E4!=null) && (resultCFCAC7935C3F430199EA29692D7A07E4.Count!=0))
{
}
else{

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
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"SELECT #OverAll_Total*0.9");

var querySourceB5136E55467F46BF9D46AE1BE798E3D4 =GetQueryExpressionDataSource("B5136E55-467F-46BF-9D46-AE1BE798E3D4");
Dictionary<short,object> resultB5136E55467F46BF9D46AE1BE798E3D4=iSpace.ExecuteQuery(querySourceB5136E55467F46BF9D46AE1BE798E3D4,@"SELECT " + ISpace["OverAll_Total"].Value + @"*0.9",false);

base.WriteDebugInfo(@"var querySourceB5136E55467F46BF9D46AE1BE798E3D4 =GetQueryExpressionDataSource(""B5136E55-467F-46BF-9D46-AE1BE798E3D4"");Dictionary<short,object> resultB5136E55467F46BF9D46AE1BE798E3D4=iSpace.ExecuteQuery(querySourceB5136E55467F46BF9D46AE1BE798E3D4,@""SELECT "" + ISpace[""OverAll_Total""].Value + @""*0.9"",false);");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["M_Status"].Value="Pending";
base.WriteDebugInfo(@"ISpace[""M_Status""].Value=""Pending"";");
base.WriteDebugInfo(@"EXEC UserRequest '#gv_ProcessMapId','#M_NextStage','#M_RequestId','#M_Status','#gv_UserId','#SetDestinationTo','#M_InstanceId','#InitiatedOn','#gv_UserId','#LastModifiedOn','#Subject'");

var querySource90bb3f4f0578a7cfd380981e7e131e6f =GetQueryExpressionDataSource("90bb3f4f-0578-a7cf-d380-981e7e131e6f");
Dictionary<short,object> result90bb3f4f0578a7cfd380981e7e131e6f=iSpace.ExecuteQuery(querySource90bb3f4f0578a7cfd380981e7e131e6f,@"EXEC UserRequest '" + ISpace["gv_ProcessMapId"].Value + @"','" + ISpace["M_NextStage"].Value + @"','" + ISpace["M_RequestId"].Value + @"','" + ISpace["M_Status"].Value + @"','" + ISpace["gv_UserId"].Value + @"','" + ISpace["SetDestinationTo"].Value + @"','" + ISpace["M_InstanceId"].Value + @"','" + ISpace["InitiatedOn"].Value + @"','" + ISpace["gv_UserId"].Value + @"','" + ISpace["LastModifiedOn"].Value + @"','" + ISpace["Subject"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource90bb3f4f0578a7cfd380981e7e131e6f =GetQueryExpressionDataSource(""90bb3f4f-0578-a7cf-d380-981e7e131e6f"");Dictionary<short,object> result90bb3f4f0578a7cfd380981e7e131e6f=iSpace.ExecuteQuery(querySource90bb3f4f0578a7cfd380981e7e131e6f,@""EXEC UserRequest '"" + ISpace[""gv_ProcessMapId""].Value + @""','"" + ISpace[""M_NextStage""].Value + @""','"" + ISpace[""M_RequestId""].Value + @""','"" + ISpace[""M_Status""].Value + @""','"" + ISpace[""gv_UserId""].Value + @""','"" + ISpace[""SetDestinationTo""].Value + @""','"" + ISpace[""M_InstanceId""].Value + @""','"" + ISpace[""InitiatedOn""].Value + @""','"" + ISpace[""gv_UserId""].Value + @""','"" + ISpace[""LastModifiedOn""].Value + @""','"" + ISpace[""Subject""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result90bb3f4f0578a7cfd380981e7e131e6f!=null) && (result90bb3f4f0578a7cfd380981e7e131e6f.Count!=0))
{
}
else{

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
private void SubscribeElementEvents_m_openmodal (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"M_OpenModal-OnClick");
ISpace["UI_AvailableBudget"].ShowDialog=true;;
base.WriteDebugInfo(@"ISpace[""UI_AvailableBudget""].ShowDialog=true;;");

var querySource10050FA13EE9447A84B73196AC6C3700 =GetQueryExpressionDataSource("10050FA1-3EE9-447A-84B7-3196AC6C3700");

DataTable result10050FA13EE9447A84B73196AC6C3700=iSpace.SetGridDataSource(querySource10050FA13EE9447A84B73196AC6C3700, _objectFactory.GetGridRPP("MG_CommitmentDetails"),@"EXEC GetProjectBudgetInformation '" + ISpace["MF_ProjectNo"].Value + @"'");

iSpace.InsertGridBindDetails("MG_CommitmentDetails","11",querySource10050FA13EE9447A84B73196AC6C3700,"EXEC GetProjectBudgetInformation '" + ISpace["MF_ProjectNo"].Value + @"'",_objectFactory.GetGridRPP("MG_CommitmentDetails"));

base.WriteDebugInfo(@"var querySource10050FA13EE9447A84B73196AC6C3700 =GetQueryExpressionDataSource(""10050FA1-3EE9-447A-84B7-3196AC6C3700"");DataTable result10050FA13EE9447A84B73196AC6C3700=iSpace.SetGridDataSource(querySource10050FA13EE9447A84B73196AC6C3700, _objectFactory.GetGridRPP(""MG_CommitmentDetails""),@""EXEC GetProjectBudgetInformation '"" + ISpace[""MF_ProjectNo""].Value + @""'"");iSpace.InsertGridBindDetails(""MG_CommitmentDetails"",""11"",querySource10050FA13EE9447A84B73196AC6C3700,""EXEC GetProjectBudgetInformation '"" + ISpace[""MF_ProjectNo""].Value + @""'"",_objectFactory.GetGridRPP(""MG_CommitmentDetails""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result33B5DB3CC03544548035C74029C72FC1=acdataIspace0D9E568F8790489DA8463C6057A39268.GetQueryExpressionBindings("33B5DB3C-C035-4454-8035-C74029C72FC1");
iSpace.SetGridData(result10050FA13EE9447A84B73196AC6C3700,result33B5DB3CC03544548035C74029C72FC1,"MG_CommitmentDetails",ref ISpace);
iSpace.UpdateGridBindDetails("MG_CommitmentDetails",result33B5DB3CC03544548035C74029C72FC1);
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_m_travelyes (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"M_TravelYes-OnClick");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySource200CEBCC9949420EB45FF8454BAC10B5 =GetQueryExpressionDataSource("200CEBCC-9949-420E-B45F-F8454BAC10B5");

DataTable result200CEBCC9949420EB45FF8454BAC10B5=iSpace.SetGridDataSource(querySource200CEBCC9949420EB45FF8454BAC10B5, _objectFactory.GetGridRPP("TravelExpense"),@"EXEC [DeleteFormGridData9F49372F-0255-42EC-AB05-31E6C4F9F2EA] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["growid"].Value + @"'");

iSpace.InsertGridBindDetails("TravelExpense","11",querySource200CEBCC9949420EB45FF8454BAC10B5,"EXEC [DeleteFormGridData9F49372F-0255-42EC-AB05-31E6C4F9F2EA] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["growid"].Value + @"'",_objectFactory.GetGridRPP("TravelExpense"));

base.WriteDebugInfo(@"var querySource200CEBCC9949420EB45FF8454BAC10B5 =GetQueryExpressionDataSource(""200CEBCC-9949-420E-B45F-F8454BAC10B5"");DataTable result200CEBCC9949420EB45FF8454BAC10B5=iSpace.SetGridDataSource(querySource200CEBCC9949420EB45FF8454BAC10B5, _objectFactory.GetGridRPP(""TravelExpense""),@""EXEC [DeleteFormGridData9F49372F-0255-42EC-AB05-31E6C4F9F2EA] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""growid""].Value + @""'"");iSpace.InsertGridBindDetails(""TravelExpense"",""11"",querySource200CEBCC9949420EB45FF8454BAC10B5,""EXEC [DeleteFormGridData9F49372F-0255-42EC-AB05-31E6C4F9F2EA] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""growid""].Value + @""'"",_objectFactory.GetGridRPP(""TravelExpense""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> resultC5D359807A8E48F3A09BFFDE2E631008=acdataIspace0D9E568F8790489DA8463C6057A39268.GetQueryExpressionBindings("C5D35980-7A8E-48F3-A09B-FFDE2E631008");
iSpace.SetGridData(result200CEBCC9949420EB45FF8454BAC10B5,resultC5D359807A8E48F3A09BFFDE2E631008,"TravelExpense",ref ISpace);
iSpace.UpdateGridBindDetails("TravelExpense",resultC5D359807A8E48F3A09BFFDE2E631008);
ISpace["Message"].Value=@"Data deleted successfully";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Data deleted successfully"";");
ISpace["UI_DialogTravel"].HideDialog=true;;
base.WriteDebugInfo(@"ISpace[""UI_DialogTravel""].HideDialog=true;;");
object MG_T2_Amount=iSpace.Sum("[9F49372F-0255-42EC-AB05-31E6C4F9F2EA]","MG_T2_Amount","",ISpace["gv_instanceid"].Value);
ISpace["T_TravelAdvanceTotal"].Value=Convert.ChangeType(MG_T2_Amount, MG_T2_Amount.GetType());;
base.WriteDebugInfo(@"object MG_T2_Amount=iSpace.Sum(""[9F49372F-0255-42EC-AB05-31E6C4F9F2EA]"",""MG_T2_Amount"","""",ISpace[""gv_instanceid""].Value);
ISpace[""T_TravelAdvanceTotal""].Value=Convert.ChangeType(MG_T2_Amount, MG_T2_Amount.GetType());;");
ISpace["OverAll_Total"].Value=ISpace["T_TravelAdvanceTotal"].Value+ISpace["T_ExpenditureTotal"].Value;
base.WriteDebugInfo(@"ISpace[""OverAll_Total""].Value=ISpace[""T_TravelAdvanceTotal""].Value+ISpace[""T_ExpenditureTotal""].Value;");
object MG_Amount=iSpace.Sum("[0BFAF73B-02D4-4680-B1C9-625AAFB02DB5]","MG_Amount","",ISpace["gv_instanceid"].Value);
ISpace["M_SumOfFund"].Value=Convert.ChangeType(MG_Amount, MG_Amount.GetType());;
base.WriteDebugInfo(@"object MG_Amount=iSpace.Sum(""[0BFAF73B-02D4-4680-B1C9-625AAFB02DB5]"",""MG_Amount"","""",ISpace[""gv_instanceid""].Value);
ISpace[""M_SumOfFund""].Value=Convert.ChangeType(MG_Amount, MG_Amount.GetType());;");
ISpace["MF_T1_AdvanceAmount"].Value=Tostring(ISpace["OverAll_Total"].Value-ISpace["M_T1_AdvanceAmount"].Value);
base.WriteDebugInfo(@"ISpace[""MF_T1_AdvanceAmount""].Value=Tostring(ISpace[""OverAll_Total""].Value-ISpace[""M_T1_AdvanceAmount""].Value);");
ISpace["growid"].Value="";
base.WriteDebugInfo(@"ISpace[""growid""].Value="""";");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"SELECT #OverAll_Total*0.9");

var querySourceB5136E55467F46BF9D46AE1BE798E3D4 =GetQueryExpressionDataSource("B5136E55-467F-46BF-9D46-AE1BE798E3D4");
Dictionary<short,object> resultB5136E55467F46BF9D46AE1BE798E3D4=iSpace.ExecuteQuery(querySourceB5136E55467F46BF9D46AE1BE798E3D4,@"SELECT " + ISpace["OverAll_Total"].Value + @"*0.9",false);

base.WriteDebugInfo(@"var querySourceB5136E55467F46BF9D46AE1BE798E3D4 =GetQueryExpressionDataSource(""B5136E55-467F-46BF-9D46-AE1BE798E3D4"");Dictionary<short,object> resultB5136E55467F46BF9D46AE1BE798E3D4=iSpace.ExecuteQuery(querySourceB5136E55467F46BF9D46AE1BE798E3D4,@""SELECT "" + ISpace[""OverAll_Total""].Value + @""*0.9"",false);");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_T1_AdvanceAmount"].Value<0)
{
base.WriteDebugInfo(@"if(ISpace[""MF_T1_AdvanceAmount""].Value<0)");

ISpace["M_ActualTransactionDate"].Man=true;ISpace["M_ActualTransactionNo"].Man=true;
base.WriteDebugInfo(@"ISpace[""M_ActualTransactionDate""].Man=true;ISpace[""M_ActualTransactionNo""].Man=true;");
ISpace["M_SourceHeader"].Value="Actual Sources of Fund for Settlement";
base.WriteDebugInfo(@"ISpace[""M_SourceHeader""].Value=""Actual Sources of Fund for Settlement"";");
}
else
{
base.WriteDebugInfo(@"else");

ISpace["M_ActualTransactionDate"].Man=false;ISpace["M_ActualTransactionNo"].Man=false;
base.WriteDebugInfo(@"ISpace[""M_ActualTransactionDate""].Man=false;ISpace[""M_ActualTransactionNo""].Man=false;");
ISpace["M_ActualTransactionDate"].Value=null;
base.WriteDebugInfo(@"ISpace[""M_ActualTransactionDate""].Value=null;");
ISpace["M_ActualTransactionNo"].Value=null;
base.WriteDebugInfo(@"ISpace[""M_ActualTransactionNo""].Value=null;");
ISpace["M_SourceHeader"].Value="Actual Sources of Fund for Claim";
base.WriteDebugInfo(@"ISpace[""M_SourceHeader""].Value=""Actual Sources of Fund for Claim"";");
}
ISpace["MF_FundType"].rElemData=iSpace.Reload(ISpace["MF_FundType"].Value,@"exec SP_GetDistrubitionDetails 7,'@" + ISpace["gv_ProcessMapId"].Value + @"','',''," + ISpace["MF_T1_AdvanceAmount"].Value + @",'','" + ISpace["R_ReferenceNo"].Value + @"',''","9ADED37B-CD11-426B-AF16-DEAC75685EF5");
base.WriteDebugInfo(@"ISpace[""MF_FundType""].rElemData=iSpace.Reload(ISpace[""MF_FundType""].Value,@""exec SP_GetDistrubitionDetails 7,'@"" + ISpace[""gv_ProcessMapId""].Value + @""','','',"" + ISpace[""MF_T1_AdvanceAmount""].Value + @"",'','"" + ISpace[""R_ReferenceNo""].Value + @""',''"",""9ADED37B-CD11-426B-AF16-DEAC75685EF5"");");
ISpace["MF_ProjectNo"].rElemData=iSpace.Reload(ISpace["MF_ProjectNo"].Value,@"EXEC Projects..GetProjectExtensionDetails 8,'" + ISpace["UC_EmployeeBaicInfoId"].Value + @"','','',''," + ISpace["MF_T1_AdvanceAmount"].Value + @",'" + ISpace["R_ReferenceNo"].Value + @"'","3A103712-5244-4427-B2B6-1C4E046FD337");
base.WriteDebugInfo(@"ISpace[""MF_ProjectNo""].rElemData=iSpace.Reload(ISpace[""MF_ProjectNo""].Value,@""EXEC Projects..GetProjectExtensionDetails 8,'"" + ISpace[""UC_EmployeeBaicInfoId""].Value + @""','','','',"" + ISpace[""MF_T1_AdvanceAmount""].Value + @"",'"" + ISpace[""R_ReferenceNo""].Value + @""'"",""3A103712-5244-4427-B2B6-1C4E046FD337"");");
ISpace["MF_BudgetHead"].rElemData=iSpace.Reload(ISpace["MF_BudgetHead"].Value,@"exec common..SP_GetDistrubitionDetails 6,'@" + ISpace["gv_ProcessMapId"].Value + @"'," + ISpace["MF_FundType"].Value + @",''," + ISpace["MF_T1_AdvanceAmount"].Value + @",'" + ISpace["UC_EmployeeBaicInfoId"].Value + @"','" + ISpace["R_ReferenceNo"].Value + @"'","9ADED37B-CD11-426B-AF16-DEAC75685EF5");
base.WriteDebugInfo(@"ISpace[""MF_BudgetHead""].rElemData=iSpace.Reload(ISpace[""MF_BudgetHead""].Value,@""exec common..SP_GetDistrubitionDetails 6,'@"" + ISpace[""gv_ProcessMapId""].Value + @""',"" + ISpace[""MF_FundType""].Value + @"",'',"" + ISpace[""MF_T1_AdvanceAmount""].Value + @"",'"" + ISpace[""UC_EmployeeBaicInfoId""].Value + @""','"" + ISpace[""R_ReferenceNo""].Value + @""'"",""9ADED37B-CD11-426B-AF16-DEAC75685EF5"");");
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_r_referenceno (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"R_ReferenceNo-OnChange");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"exec GetTravelSettlement 1,'#R_ReferenceNo'");

var querySourcedac4474c419453557c0e212eeaad53e2 =GetQueryExpressionDataSource("dac4474c-4194-5355-7c0e-212eeaad53e2");
Dictionary<short,object> resultdac4474c419453557c0e212eeaad53e2=iSpace.ExecuteQuery(querySourcedac4474c419453557c0e212eeaad53e2,@"execGetTravelSettlement 1,'" + ISpace["R_ReferenceNo"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourcedac4474c419453557c0e212eeaad53e2 =GetQueryExpressionDataSource(""dac4474c-4194-5355-7c0e-212eeaad53e2"");Dictionary<short,object> resultdac4474c419453557c0e212eeaad53e2=iSpace.ExecuteQuery(querySourcedac4474c419453557c0e212eeaad53e2,@""execGetTravelSettlement 1,'"" + ISpace[""R_ReferenceNo""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultdac4474c419453557c0e212eeaad53e2!=null) && (resultdac4474c419453557c0e212eeaad53e2.Count!=0))
{
if(resultdac4474c419453557c0e212eeaad53e2.ContainsKey(10))
ISpace["MF_TransactionDate"].Value = resultdac4474c419453557c0e212eeaad53e2[10];
if(resultdac4474c419453557c0e212eeaad53e2.ContainsKey(3))
ISpace["Travel_Type"].Value = resultdac4474c419453557c0e212eeaad53e2[3];
if(resultdac4474c419453557c0e212eeaad53e2.ContainsKey(5))
ISpace["M_IsAdvanceRequired"].Value = resultdac4474c419453557c0e212eeaad53e2[5];
if(resultdac4474c419453557c0e212eeaad53e2.ContainsKey(7))
ISpace["M_T1_AdvanceAmount"].Value = resultdac4474c419453557c0e212eeaad53e2[7];
if(resultdac4474c419453557c0e212eeaad53e2.ContainsKey(6))
ISpace["M_OverAll_Total"].Value = resultdac4474c419453557c0e212eeaad53e2[6];
if(resultdac4474c419453557c0e212eeaad53e2.ContainsKey(9))
ISpace["MF_TransactionNo"].Value = resultdac4474c419453557c0e212eeaad53e2[9];
if(resultdac4474c419453557c0e212eeaad53e2.ContainsKey(2))
ISpace["MF_T1_JourneyPurpose"].Value = resultdac4474c419453557c0e212eeaad53e2[2];
if(resultdac4474c419453557c0e212eeaad53e2.ContainsKey(4))
ISpace["M_TravelPlace"].Value = resultdac4474c419453557c0e212eeaad53e2[4];
}
else{
ISpace["MF_TransactionDate"].Value = null;ISpace["Travel_Type"].Value = null;ISpace["M_IsAdvanceRequired"].Value = null;ISpace["M_T1_AdvanceAmount"].Value = null;ISpace["M_OverAll_Total"].Value = null;ISpace["MF_TransactionNo"].Value = null;ISpace["MF_T1_JourneyPurpose"].Value = null;ISpace["M_TravelPlace"].Value = null;
}

var querySource5bbc413f6dd3b4841a5730313545216f =GetQueryExpressionDataSource("5bbc413f-6dd3-b484-1a57-30313545216f");

DataTable result5bbc413f6dd3b4841a5730313545216f=iSpace.SetGridDataSource(querySource5bbc413f6dd3b4841a5730313545216f, _objectFactory.GetGridRPP("M_FundAmount"),@"exec GetTravelSettlement 2,'" + ISpace["R_ReferenceNo"].Value + @"'");

iSpace.InsertGridBindDetails("M_FundAmount","11",querySource5bbc413f6dd3b4841a5730313545216f,"exec GetTravelSettlement 2,'" + ISpace["R_ReferenceNo"].Value + @"'",_objectFactory.GetGridRPP("M_FundAmount"));

base.WriteDebugInfo(@"var querySource5bbc413f6dd3b4841a5730313545216f =GetQueryExpressionDataSource(""5bbc413f-6dd3-b484-1a57-30313545216f"");DataTable result5bbc413f6dd3b4841a5730313545216f=iSpace.SetGridDataSource(querySource5bbc413f6dd3b4841a5730313545216f, _objectFactory.GetGridRPP(""M_FundAmount""),@""exec GetTravelSettlement 2,'"" + ISpace[""R_ReferenceNo""].Value + @""'"");iSpace.InsertGridBindDetails(""M_FundAmount"",""11"",querySource5bbc413f6dd3b4841a5730313545216f,""exec GetTravelSettlement 2,'"" + ISpace[""R_ReferenceNo""].Value + @""'"",_objectFactory.GetGridRPP(""M_FundAmount""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result4ae98202ec93624ff546c36904d7b1f5=acdataIspace0D9E568F8790489DA8463C6057A39268.GetQueryExpressionBindings("4ae98202-ec93-624f-f546-c36904d7b1f5");
iSpace.SetGridData(result5bbc413f6dd3b4841a5730313545216f,result4ae98202ec93624ff546c36904d7b1f5,"M_FundAmount",ref ISpace);
iSpace.UpdateGridBindDetails("M_FundAmount",result4ae98202ec93624ff546c36904d7b1f5);

var querySource4e1eac8175f99be729892a70d1faefb7 =GetQueryExpressionDataSource("4e1eac81-75f9-9be7-2989-2a70d1faefb7");

DataTable result4e1eac8175f99be729892a70d1faefb7=iSpace.SetGridDataSource(querySource4e1eac8175f99be729892a70d1faefb7, _objectFactory.GetGridRPP("M_OtherExpense"),@"exec GetTravelSettlement 3,'" + ISpace["R_ReferenceNo"].Value + @"'");

iSpace.InsertGridBindDetails("M_OtherExpense","11",querySource4e1eac8175f99be729892a70d1faefb7,"exec GetTravelSettlement 3,'" + ISpace["R_ReferenceNo"].Value + @"'",_objectFactory.GetGridRPP("M_OtherExpense"));

base.WriteDebugInfo(@"var querySource4e1eac8175f99be729892a70d1faefb7 =GetQueryExpressionDataSource(""4e1eac81-75f9-9be7-2989-2a70d1faefb7"");DataTable result4e1eac8175f99be729892a70d1faefb7=iSpace.SetGridDataSource(querySource4e1eac8175f99be729892a70d1faefb7, _objectFactory.GetGridRPP(""M_OtherExpense""),@""exec GetTravelSettlement 3,'"" + ISpace[""R_ReferenceNo""].Value + @""'"");iSpace.InsertGridBindDetails(""M_OtherExpense"",""11"",querySource4e1eac8175f99be729892a70d1faefb7,""exec GetTravelSettlement 3,'"" + ISpace[""R_ReferenceNo""].Value + @""'"",_objectFactory.GetGridRPP(""M_OtherExpense""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result20b66f202421f3a12150d1af5746d196=acdataIspace0D9E568F8790489DA8463C6057A39268.GetQueryExpressionBindings("20b66f20-2421-f3a1-2150-d1af5746d196");
iSpace.SetGridData(result4e1eac8175f99be729892a70d1faefb7,result20b66f202421f3a12150d1af5746d196,"M_OtherExpense",ref ISpace);
iSpace.UpdateGridBindDetails("M_OtherExpense",result20b66f202421f3a12150d1af5746d196);

var querySourced6f9f1fd934ebb276136f84a8acf834b =GetQueryExpressionDataSource("d6f9f1fd-934e-bb27-6136-f84a8acf834b");

DataTable resultd6f9f1fd934ebb276136f84a8acf834b=iSpace.SetGridDataSource(querySourced6f9f1fd934ebb276136f84a8acf834b, _objectFactory.GetGridRPP("M_TravelExpense"),@"exec GetTravelSettlement 4,'" + ISpace["R_ReferenceNo"].Value + @"'");

iSpace.InsertGridBindDetails("M_TravelExpense","11",querySourced6f9f1fd934ebb276136f84a8acf834b,"exec GetTravelSettlement 4,'" + ISpace["R_ReferenceNo"].Value + @"'",_objectFactory.GetGridRPP("M_TravelExpense"));

base.WriteDebugInfo(@"var querySourced6f9f1fd934ebb276136f84a8acf834b =GetQueryExpressionDataSource(""d6f9f1fd-934e-bb27-6136-f84a8acf834b"");DataTable resultd6f9f1fd934ebb276136f84a8acf834b=iSpace.SetGridDataSource(querySourced6f9f1fd934ebb276136f84a8acf834b, _objectFactory.GetGridRPP(""M_TravelExpense""),@""exec GetTravelSettlement 4,'"" + ISpace[""R_ReferenceNo""].Value + @""'"");iSpace.InsertGridBindDetails(""M_TravelExpense"",""11"",querySourced6f9f1fd934ebb276136f84a8acf834b,""exec GetTravelSettlement 4,'"" + ISpace[""R_ReferenceNo""].Value + @""'"",_objectFactory.GetGridRPP(""M_TravelExpense""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> resultd22d161570d787268132f1daf7e9ba08=acdataIspace0D9E568F8790489DA8463C6057A39268.GetQueryExpressionBindings("d22d1615-70d7-8726-8132-f1daf7e9ba08");
iSpace.SetGridData(resultd6f9f1fd934ebb276136f84a8acf834b,resultd22d161570d787268132f1daf7e9ba08,"M_TravelExpense",ref ISpace);
iSpace.UpdateGridBindDetails("M_TravelExpense",resultd22d161570d787268132f1daf7e9ba08);
}
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mfg_t2_departuredate (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MFG_T2_DepartureDate-OnChange");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MFG_T2_ArrivalDate"].Value<ISpace["MFG_T2_DepartureDate"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MFG_T2_ArrivalDate""].Value<ISpace[""MFG_T2_DepartureDate""].Value)");
ISpace["Message"].Value=@"Arrival Date should be greater than Departure Date";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Arrival Date should be greater than Departure Date"";");
ISpace["MFG_T2_ArrivalDate"].Value=null;
base.WriteDebugInfo(@"ISpace[""MFG_T2_ArrivalDate""].Value=null;");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_edit_travelexpense (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Edit_TravelExpense-OnClick");
ISpace["growid"].Value=ISpace["TravelExpense_RowId"].Value;
base.WriteDebugInfo(@"ISpace[""growid""].Value=ISpace[""TravelExpense_RowId""].Value;");
base.WriteDebugInfo(@"EXEC [LoadFormGridData9F49372F-0255-42EC-AB05-31E6C4F9F2EA] '@@gv_InstanceId','@@gv_ProcessMapId','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','@@gv_ActivityMapId','#growid'");

var querySourceED15FA1FD7F94F6A9FC435EEE23FA142 =GetQueryExpressionDataSource("ED15FA1F-D7F9-4F6A-9FC4-35EEE23FA142");
Dictionary<short,object> resultED15FA1FD7F94F6A9FC435EEE23FA142=iSpace.ExecuteQuery(querySourceED15FA1FD7F94F6A9FC435EEE23FA142,@"EXEC [LoadFormGridData9F49372F-0255-42EC-AB05-31E6C4F9F2EA] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["growid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceED15FA1FD7F94F6A9FC435EEE23FA142 =GetQueryExpressionDataSource(""ED15FA1F-D7F9-4F6A-9FC4-35EEE23FA142"");Dictionary<short,object> resultED15FA1FD7F94F6A9FC435EEE23FA142=iSpace.ExecuteQuery(querySourceED15FA1FD7F94F6A9FC435EEE23FA142,@""EXEC [LoadFormGridData9F49372F-0255-42EC-AB05-31E6C4F9F2EA] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""growid""].Value + @""'"",false);");
base.WriteDebugInfo(@"EXEC LoadFormGridData374fb8a88dd94cf1bf73f40ae18fcad7 '@@gv_InstanceId','@@gv_ProcessMapId','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','@@gv_ActivityMapId','#growid'");

if((resultED15FA1FD7F94F6A9FC435EEE23FA142!=null) && (resultED15FA1FD7F94F6A9FC435EEE23FA142.Count!=0))
{
if(resultED15FA1FD7F94F6A9FC435EEE23FA142.ContainsKey(6))
ISpace["MFG_T2_ArrivalDate"].Value = resultED15FA1FD7F94F6A9FC435EEE23FA142[6];
if(resultED15FA1FD7F94F6A9FC435EEE23FA142.ContainsKey(3))
ISpace["MFG_T2_DepartureDate"].Value = resultED15FA1FD7F94F6A9FC435EEE23FA142[3];
if(resultED15FA1FD7F94F6A9FC435EEE23FA142.ContainsKey(8))
ISpace["MFG_T2_ModeofJourney"].Value = resultED15FA1FD7F94F6A9FC435EEE23FA142[8];
if(resultED15FA1FD7F94F6A9FC435EEE23FA142.ContainsKey(9))
ISpace["MFG_T2_JourneyClass"].Value = resultED15FA1FD7F94F6A9FC435EEE23FA142[9];
if(resultED15FA1FD7F94F6A9FC435EEE23FA142.ContainsKey(10))
ISpace["MFG_T2_Road"].Value = resultED15FA1FD7F94F6A9FC435EEE23FA142[10];
if(resultED15FA1FD7F94F6A9FC435EEE23FA142.ContainsKey(12))
ISpace["MFG_T2_Amount"].Value = resultED15FA1FD7F94F6A9FC435EEE23FA142[12];
if(resultED15FA1FD7F94F6A9FC435EEE23FA142.ContainsKey(1))
ISpace["MFG_T2_TravelAdvanceID"].Value = resultED15FA1FD7F94F6A9FC435EEE23FA142[1];
if(resultED15FA1FD7F94F6A9FC435EEE23FA142.ContainsKey(2))
ISpace["MFG_T2_Departure"].Value = resultED15FA1FD7F94F6A9FC435EEE23FA142[2];
if(resultED15FA1FD7F94F6A9FC435EEE23FA142.ContainsKey(11))
ISpace["MFG_T2_PNRNo"].Value = resultED15FA1FD7F94F6A9FC435EEE23FA142[11];
if(resultED15FA1FD7F94F6A9FC435EEE23FA142.ContainsKey(7))
ISpace["MFG_T2_ArrivalTime"].Value = resultED15FA1FD7F94F6A9FC435EEE23FA142[7];
if(resultED15FA1FD7F94F6A9FC435EEE23FA142.ContainsKey(4))
ISpace["MFG_T2_DepartureTime"].Value = resultED15FA1FD7F94F6A9FC435EEE23FA142[4];
if(resultED15FA1FD7F94F6A9FC435EEE23FA142.ContainsKey(5))
ISpace["MFG_T2_Arrival"].Value = resultED15FA1FD7F94F6A9FC435EEE23FA142[5];
if(resultED15FA1FD7F94F6A9FC435EEE23FA142.ContainsKey(0))
ISpace["MFG_T2_TADetailsID"].Value = resultED15FA1FD7F94F6A9FC435EEE23FA142[0];
}
else{
ISpace["MFG_T2_ArrivalDate"].Value = null;ISpace["MFG_T2_DepartureDate"].Value = null;ISpace["MFG_T2_ModeofJourney"].Value = null;ISpace["MFG_T2_JourneyClass"].Value = null;ISpace["MFG_T2_Road"].Value = null;ISpace["MFG_T2_Amount"].Value = null;ISpace["MFG_T2_TravelAdvanceID"].Value = null;ISpace["MFG_T2_Departure"].Value = null;ISpace["MFG_T2_PNRNo"].Value = null;ISpace["MFG_T2_ArrivalTime"].Value = null;ISpace["MFG_T2_DepartureTime"].Value = null;ISpace["MFG_T2_Arrival"].Value = null;ISpace["MFG_T2_TADetailsID"].Value = null;
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_edit_otherexpense (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Edit_OtherExpense-OnClick");
ISpace["growid"].Value=ISpace["OtherExpense_RowId"].Value;
base.WriteDebugInfo(@"ISpace[""growid""].Value=ISpace[""OtherExpense_RowId""].Value;");
if(1==2)
{
base.WriteDebugInfo(@"if(1==2)");
ISpace["growid"].Value=ISpace["OtherExpense_RowId"].Value;
base.WriteDebugInfo(@"ISpace[""growid""].Value=ISpace[""OtherExpense_RowId""].Value;");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC [LoadFormGridData7D2812B7-3A49-4DA7-9E48-082B26C3333C] '@@gv_InstanceId','@@gv_ProcessMapId','51838b37-2ec6-4d35-8a5e-38648bc93ab1','@@gv_ActivityMapId','#growid'");

var querySourceC92176ECE80643BC88D2348E8005BA14 =GetQueryExpressionDataSource("C92176EC-E806-43BC-88D2-348E8005BA14");
Dictionary<short,object> resultC92176ECE80643BC88D2348E8005BA14=iSpace.ExecuteQuery(querySourceC92176ECE80643BC88D2348E8005BA14,@"EXEC [LoadFormGridData7D2812B7-3A49-4DA7-9E48-082B26C3333C]'" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','51838b37-2ec6-4d35-8a5e-38648bc93ab1','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["growid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceC92176ECE80643BC88D2348E8005BA14 =GetQueryExpressionDataSource(""C92176EC-E806-43BC-88D2-348E8005BA14"");Dictionary<short,object> resultC92176ECE80643BC88D2348E8005BA14=iSpace.ExecuteQuery(querySourceC92176ECE80643BC88D2348E8005BA14,@""EXEC [LoadFormGridData7D2812B7-3A49-4DA7-9E48-082B26C3333C]'"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','51838b37-2ec6-4d35-8a5e-38648bc93ab1','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""growid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultC92176ECE80643BC88D2348E8005BA14!=null) && (resultC92176ECE80643BC88D2348E8005BA14.Count!=0))
{
if(resultC92176ECE80643BC88D2348E8005BA14.ContainsKey(2))
ISpace["MFG_T2_FromDate"].Value = resultC92176ECE80643BC88D2348E8005BA14[2];
if(resultC92176ECE80643BC88D2348E8005BA14.ContainsKey(3))
ISpace["MFG_T2_ToDate"].Value = resultC92176ECE80643BC88D2348E8005BA14[3];
if(resultC92176ECE80643BC88D2348E8005BA14.ContainsKey(0))
ISpace["MFG_T2_ExpenditureTypeID"].Value = resultC92176ECE80643BC88D2348E8005BA14[0];
if(resultC92176ECE80643BC88D2348E8005BA14.ContainsKey(4))
ISpace["MFG_T3_Amount"].Value = resultC92176ECE80643BC88D2348E8005BA14[4];
if(resultC92176ECE80643BC88D2348E8005BA14.ContainsKey(6))
ISpace["M_MiscDetails"].Value = resultC92176ECE80643BC88D2348E8005BA14[6];
if(resultC92176ECE80643BC88D2348E8005BA14.ContainsKey(1))
ISpace["MFG_T2_TravelAdvanceID"].Value = resultC92176ECE80643BC88D2348E8005BA14[1];
}
else{
ISpace["MFG_T2_FromDate"].Value = null;ISpace["MFG_T2_ToDate"].Value = null;ISpace["MFG_T2_ExpenditureTypeID"].Value = null;ISpace["MFG_T3_Amount"].Value = null;ISpace["M_MiscDetails"].Value = null;ISpace["MFG_T2_TravelAdvanceID"].Value = null;
}
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_save_travelexpense (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Save_TravelExpense-OnClick");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(Trim(ISpace["MFG_T2_ModeofJourney"].Value)=="")
{
base.WriteDebugInfo(@"if(Trim(ISpace[""MFG_T2_ModeofJourney""].Value)=="""")");
ISpace["Message"].Value=@"Please Enter the Mode of Journey";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please Enter the Mode of Journey"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if(Trim(ISpace["MFG_T2_Departure"].Value)=="")
{
base.WriteDebugInfo(@"if(Trim(ISpace[""MFG_T2_Departure""].Value)=="""")");
ISpace["Message"].Value=@"Please Enter the Departure";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please Enter the Departure"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if((ISpace["MFG_T2_DepartureDate"].Value == null))
{
base.WriteDebugInfo(@"if((ISpace[""MFG_T2_DepartureDate""].Value == null))");
ISpace["Message"].Value=@"Please Enter the Departure Date";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please Enter the Departure Date"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if(Trim(ISpace["MFG_T2_Arrival"].Value)=="")
{
base.WriteDebugInfo(@"if(Trim(ISpace[""MFG_T2_Arrival""].Value)=="""")");
ISpace["Message"].Value=@"Please Enter the Arrival";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please Enter the Arrival"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if((ISpace["MFG_T2_ArrivalDate"].Value == null))
{
base.WriteDebugInfo(@"if((ISpace[""MFG_T2_ArrivalDate""].Value == null))");
ISpace["Message"].Value=@"Please Enter the Arrival Date";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please Enter the Arrival Date"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if(ISpace["MFG_T2_ArrivalDate"].Value<ISpace["MFG_T2_DepartureDate"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MFG_T2_ArrivalDate""].Value<ISpace[""MFG_T2_DepartureDate""].Value)");
ISpace["Message"].Value=@"Arrival Date should be greater than Departure Date";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Arrival Date should be greater than Departure Date"";");
ISpace["MFG_T2_ArrivalDate"].Value=null;
base.WriteDebugInfo(@"ISpace[""MFG_T2_ArrivalDate""].Value=null;");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if(ISpace["MFG_T2_Amount"].Value==0)
{
base.WriteDebugInfo(@"if(ISpace[""MFG_T2_Amount""].Value==0)");
ISpace["Message"].Value=@"Please Enter the Amount";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please Enter the Amount"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
}
if(ISpace["growid"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""growid""].Value=="""")");

var querySource47DEECA98E4E4FDE806BD716B4F25534 =GetQueryExpressionDataSource("47DEECA9-8E4E-4FDE-806B-D716B4F25534");

DataTable result47DEECA98E4E4FDE806BD716B4F25534=iSpace.SetGridDataSource(querySource47DEECA98E4E4FDE806BD716B4F25534, _objectFactory.GetGridRPP("TravelExpense"),@"EXEC [AddFormGridData9F49372F-0255-42EC-AB05-31E6C4F9F2EA] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["MFG_T2_TADetailsID"].Value + @"','" + ISpace["MFG_T2_TravelAdvanceID"].Value + @"','" + ISpace["MFG_T2_Departure"].Value + @"','" + ISpace["MFG_T2_DepartureDate"].Value + @"','" + ISpace["MFG_T2_DepartureTime"].Value + @"','" + ISpace["MFG_T2_Arrival"].Value + @"','" + ISpace["MFG_T2_ArrivalDate"].Value + @"','" + ISpace["MFG_T2_ArrivalTime"].Value + @"','" + ISpace["MFG_T2_ModeofJourney"].Value + @"','" + ISpace["MFG_T2_JourneyClass"].Value + @"'," + ISpace["MFG_T2_Road"].Value + @",'" + ISpace["MFG_T2_PNRNo"].Value + @"'," + ISpace["MFG_T2_Amount"].Value + @",'" + ISpace["growid"].Value + @"'");

iSpace.InsertGridBindDetails("TravelExpense","11",querySource47DEECA98E4E4FDE806BD716B4F25534,"EXEC [AddFormGridData9F49372F-0255-42EC-AB05-31E6C4F9F2EA] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["MFG_T2_TADetailsID"].Value + @"','" + ISpace["MFG_T2_TravelAdvanceID"].Value + @"','" + ISpace["MFG_T2_Departure"].Value + @"','" + ISpace["MFG_T2_DepartureDate"].Value + @"','" + ISpace["MFG_T2_DepartureTime"].Value + @"','" + ISpace["MFG_T2_Arrival"].Value + @"','" + ISpace["MFG_T2_ArrivalDate"].Value + @"','" + ISpace["MFG_T2_ArrivalTime"].Value + @"','" + ISpace["MFG_T2_ModeofJourney"].Value + @"','" + ISpace["MFG_T2_JourneyClass"].Value + @"'," + ISpace["MFG_T2_Road"].Value + @",'" + ISpace["MFG_T2_PNRNo"].Value + @"'," + ISpace["MFG_T2_Amount"].Value + @",'" + ISpace["growid"].Value + @"'",_objectFactory.GetGridRPP("TravelExpense"));

base.WriteDebugInfo(@"var querySource47DEECA98E4E4FDE806BD716B4F25534 =GetQueryExpressionDataSource(""47DEECA9-8E4E-4FDE-806B-D716B4F25534"");DataTable result47DEECA98E4E4FDE806BD716B4F25534=iSpace.SetGridDataSource(querySource47DEECA98E4E4FDE806BD716B4F25534, _objectFactory.GetGridRPP(""TravelExpense""),@""EXEC [AddFormGridData9F49372F-0255-42EC-AB05-31E6C4F9F2EA] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""MFG_T2_TADetailsID""].Value + @""','"" + ISpace[""MFG_T2_TravelAdvanceID""].Value + @""','"" + ISpace[""MFG_T2_Departure""].Value + @""','"" + ISpace[""MFG_T2_DepartureDate""].Value + @""','"" + ISpace[""MFG_T2_DepartureTime""].Value + @""','"" + ISpace[""MFG_T2_Arrival""].Value + @""','"" + ISpace[""MFG_T2_ArrivalDate""].Value + @""','"" + ISpace[""MFG_T2_ArrivalTime""].Value + @""','"" + ISpace[""MFG_T2_ModeofJourney""].Value + @""','"" + ISpace[""MFG_T2_JourneyClass""].Value + @""',"" + ISpace[""MFG_T2_Road""].Value + @"",'"" + ISpace[""MFG_T2_PNRNo""].Value + @""',"" + ISpace[""MFG_T2_Amount""].Value + @"",'"" + ISpace[""growid""].Value + @""'"");iSpace.InsertGridBindDetails(""TravelExpense"",""11"",querySource47DEECA98E4E4FDE806BD716B4F25534,""EXEC [AddFormGridData9F49372F-0255-42EC-AB05-31E6C4F9F2EA] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""MFG_T2_TADetailsID""].Value + @""','"" + ISpace[""MFG_T2_TravelAdvanceID""].Value + @""','"" + ISpace[""MFG_T2_Departure""].Value + @""','"" + ISpace[""MFG_T2_DepartureDate""].Value + @""','"" + ISpace[""MFG_T2_DepartureTime""].Value + @""','"" + ISpace[""MFG_T2_Arrival""].Value + @""','"" + ISpace[""MFG_T2_ArrivalDate""].Value + @""','"" + ISpace[""MFG_T2_ArrivalTime""].Value + @""','"" + ISpace[""MFG_T2_ModeofJourney""].Value + @""','"" + ISpace[""MFG_T2_JourneyClass""].Value + @""',"" + ISpace[""MFG_T2_Road""].Value + @"",'"" + ISpace[""MFG_T2_PNRNo""].Value + @""',"" + ISpace[""MFG_T2_Amount""].Value + @"",'"" + ISpace[""growid""].Value + @""'"",_objectFactory.GetGridRPP(""TravelExpense""));");
base.WriteDebugInfo(@"EXEC AddFormGridData374fb8a88dd94cf1bf73f40ae18fcad7 '@@gv_InstanceId','@@gv_ProcessMapId','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','@@gv_ActivityMapId','#MFG_T2_TADetailsID','#MFG_T2_TravelAdvanceID','#MFG_T2_Departure','#MFG_T2_DepartureDate','#MFG_T2_DepartureTime','#MFG_T2_Arrival','#MFG_T2_ArrivalDate','#MFG_T2_ArrivalTime','#MFG_T2_ModeofJourney','#MFG_T2_JourneyClass',#MFG_T2_Road,'#MFG_T2_PNRNo',#MFG_T3_Amount,'#growid'");


List<Triplet<string, short, short?>> result5FF52A9FC7A9483893076D31A18D61AB=acdataIspace0D9E568F8790489DA8463C6057A39268.GetQueryExpressionBindings("5FF52A9F-C7A9-4838-9307-6D31A18D61AB");
iSpace.SetGridData(result47DEECA98E4E4FDE806BD716B4F25534,result5FF52A9FC7A9483893076D31A18D61AB,"TravelExpense",ref ISpace);
iSpace.UpdateGridBindDetails("TravelExpense",result5FF52A9FC7A9483893076D31A18D61AB);
}
else
{
base.WriteDebugInfo(@"else");

var querySource68C5D0A58E3049AB91AD12CEEA91048F =GetQueryExpressionDataSource("68C5D0A5-8E30-49AB-91AD-12CEEA91048F");

DataTable result68C5D0A58E3049AB91AD12CEEA91048F=iSpace.SetGridDataSource(querySource68C5D0A58E3049AB91AD12CEEA91048F, _objectFactory.GetGridRPP("TravelExpense"),@"EXEC [UpdateFormGridData9F49372F-0255-42EC-AB05-31E6C4F9F2EA] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["MFG_T2_TADetailsID"].Value + @"','" + ISpace["MFG_T2_TravelAdvanceID"].Value + @"','" + ISpace["MFG_T2_Departure"].Value + @"','" + ISpace["MFG_T2_DepartureDate"].Value + @"','" + ISpace["MFG_T2_DepartureTime"].Value + @"','" + ISpace["MFG_T2_Arrival"].Value + @"','" + ISpace["MFG_T2_ArrivalDate"].Value + @"','" + ISpace["MFG_T2_ArrivalTime"].Value + @"','" + ISpace["MFG_T2_ModeofJourney"].Value + @"','" + ISpace["MFG_T2_JourneyClass"].Value + @"'," + ISpace["MFG_T2_Road"].Value + @",'" + ISpace["MFG_T2_PNRNo"].Value + @"'," + ISpace["MFG_T2_Amount"].Value + @",'" + ISpace["growid"].Value + @"'");

iSpace.InsertGridBindDetails("TravelExpense","11",querySource68C5D0A58E3049AB91AD12CEEA91048F,"EXEC [UpdateFormGridData9F49372F-0255-42EC-AB05-31E6C4F9F2EA] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["MFG_T2_TADetailsID"].Value + @"','" + ISpace["MFG_T2_TravelAdvanceID"].Value + @"','" + ISpace["MFG_T2_Departure"].Value + @"','" + ISpace["MFG_T2_DepartureDate"].Value + @"','" + ISpace["MFG_T2_DepartureTime"].Value + @"','" + ISpace["MFG_T2_Arrival"].Value + @"','" + ISpace["MFG_T2_ArrivalDate"].Value + @"','" + ISpace["MFG_T2_ArrivalTime"].Value + @"','" + ISpace["MFG_T2_ModeofJourney"].Value + @"','" + ISpace["MFG_T2_JourneyClass"].Value + @"'," + ISpace["MFG_T2_Road"].Value + @",'" + ISpace["MFG_T2_PNRNo"].Value + @"'," + ISpace["MFG_T2_Amount"].Value + @",'" + ISpace["growid"].Value + @"'",_objectFactory.GetGridRPP("TravelExpense"));

base.WriteDebugInfo(@"var querySource68C5D0A58E3049AB91AD12CEEA91048F =GetQueryExpressionDataSource(""68C5D0A5-8E30-49AB-91AD-12CEEA91048F"");DataTable result68C5D0A58E3049AB91AD12CEEA91048F=iSpace.SetGridDataSource(querySource68C5D0A58E3049AB91AD12CEEA91048F, _objectFactory.GetGridRPP(""TravelExpense""),@""EXEC [UpdateFormGridData9F49372F-0255-42EC-AB05-31E6C4F9F2EA] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""MFG_T2_TADetailsID""].Value + @""','"" + ISpace[""MFG_T2_TravelAdvanceID""].Value + @""','"" + ISpace[""MFG_T2_Departure""].Value + @""','"" + ISpace[""MFG_T2_DepartureDate""].Value + @""','"" + ISpace[""MFG_T2_DepartureTime""].Value + @""','"" + ISpace[""MFG_T2_Arrival""].Value + @""','"" + ISpace[""MFG_T2_ArrivalDate""].Value + @""','"" + ISpace[""MFG_T2_ArrivalTime""].Value + @""','"" + ISpace[""MFG_T2_ModeofJourney""].Value + @""','"" + ISpace[""MFG_T2_JourneyClass""].Value + @""',"" + ISpace[""MFG_T2_Road""].Value + @"",'"" + ISpace[""MFG_T2_PNRNo""].Value + @""',"" + ISpace[""MFG_T2_Amount""].Value + @"",'"" + ISpace[""growid""].Value + @""'"");iSpace.InsertGridBindDetails(""TravelExpense"",""11"",querySource68C5D0A58E3049AB91AD12CEEA91048F,""EXEC [UpdateFormGridData9F49372F-0255-42EC-AB05-31E6C4F9F2EA] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""MFG_T2_TADetailsID""].Value + @""','"" + ISpace[""MFG_T2_TravelAdvanceID""].Value + @""','"" + ISpace[""MFG_T2_Departure""].Value + @""','"" + ISpace[""MFG_T2_DepartureDate""].Value + @""','"" + ISpace[""MFG_T2_DepartureTime""].Value + @""','"" + ISpace[""MFG_T2_Arrival""].Value + @""','"" + ISpace[""MFG_T2_ArrivalDate""].Value + @""','"" + ISpace[""MFG_T2_ArrivalTime""].Value + @""','"" + ISpace[""MFG_T2_ModeofJourney""].Value + @""','"" + ISpace[""MFG_T2_JourneyClass""].Value + @""',"" + ISpace[""MFG_T2_Road""].Value + @"",'"" + ISpace[""MFG_T2_PNRNo""].Value + @""',"" + ISpace[""MFG_T2_Amount""].Value + @"",'"" + ISpace[""growid""].Value + @""'"",_objectFactory.GetGridRPP(""TravelExpense""));");
base.WriteDebugInfo(@"EXEC UpdateFormGridData374fb8a88dd94cf1bf73f40ae18fcad7 '@@gv_InstanceId','@@gv_ProcessMapId','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','@@gv_ActivityMapId','#MFG_T2_TADetailsID','#MFG_T2_TravelAdvanceID','#MFG_T2_Departure','#MFG_T2_DepartureDate','#MFG_T2_DepartureTime','#MFG_T2_Arrival','#MFG_T2_ArrivalDate','#MFG_T2_ArrivalTime','#MFG_T2_ModeofJourney','#MFG_T2_JourneyClass',#MFG_T2_Road,'#MFG_T2_PNRNo',#MFG_T3_Amount,'#growid'");


List<Triplet<string, short, short?>> resultDA3CF2FEBFBD482BB0D7A4FADF01F4B2=acdataIspace0D9E568F8790489DA8463C6057A39268.GetQueryExpressionBindings("DA3CF2FE-BFBD-482B-B0D7-A4FADF01F4B2");
iSpace.SetGridData(result68C5D0A58E3049AB91AD12CEEA91048F,resultDA3CF2FEBFBD482BB0D7A4FADF01F4B2,"TravelExpense",ref ISpace);
iSpace.UpdateGridBindDetails("TravelExpense",resultDA3CF2FEBFBD482BB0D7A4FADF01F4B2);
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["growid"].Value="";
base.WriteDebugInfo(@"ISpace[""growid""].Value="""";");
}
ISpace["growid"].Value="";
base.WriteDebugInfo(@"ISpace[""growid""].Value="""";");
ISpace["MFG_T2_TADetailsID"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_T2_TADetailsID""].Value="""";");
ISpace["MFG_T2_TravelAdvanceID"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_T2_TravelAdvanceID""].Value="""";");
ISpace["MFG_T2_Departure"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_T2_Departure""].Value="""";");
ISpace["MFG_T2_DepartureDate"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_T2_DepartureDate""].Value="""";");
ISpace["MFG_T2_DepartureTime"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_T2_DepartureTime""].Value="""";");
ISpace["MFG_T2_Arrival"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_T2_Arrival""].Value="""";");
ISpace["MFG_T2_ArrivalDate"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_T2_ArrivalDate""].Value="""";");
ISpace["MFG_T2_ArrivalTime"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_T2_ArrivalTime""].Value="""";");
ISpace["MFG_T2_ModeofJourney"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_T2_ModeofJourney""].Value="""";");
ISpace["MFG_T2_JourneyClass"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_T2_JourneyClass""].Value="""";");
ISpace["MFG_T2_Road"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_T2_Road""].Value="""";");
ISpace["MFG_T2_PNRNo"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_T2_PNRNo""].Value="""";");
ISpace["MFG_T2_Amount"].Value=null;
base.WriteDebugInfo(@"ISpace[""MFG_T2_Amount""].Value=null;");
object MG_T2_Amount=iSpace.Sum("[9F49372F-0255-42EC-AB05-31E6C4F9F2EA]","MG_T2_Amount","",ISpace["gv_instanceid"].Value);
ISpace["T_TravelAdvanceTotal"].Value=Convert.ChangeType(MG_T2_Amount, MG_T2_Amount.GetType());;
base.WriteDebugInfo(@"object MG_T2_Amount=iSpace.Sum(""[9F49372F-0255-42EC-AB05-31E6C4F9F2EA]"",""MG_T2_Amount"","""",ISpace[""gv_instanceid""].Value);
ISpace[""T_TravelAdvanceTotal""].Value=Convert.ChangeType(MG_T2_Amount, MG_T2_Amount.GetType());;");
ISpace["OverAll_Total"].Value=ISpace["T_TravelAdvanceTotal"].Value+ISpace["T_ExpenditureTotal"].Value;
base.WriteDebugInfo(@"ISpace[""OverAll_Total""].Value=ISpace[""T_TravelAdvanceTotal""].Value+ISpace[""T_ExpenditureTotal""].Value;");
object MG_Amount=iSpace.Sum("[0BFAF73B-02D4-4680-B1C9-625AAFB02DB5]","MG_Amount","",ISpace["gv_instanceid"].Value);
ISpace["M_SumOfFund"].Value=Convert.ChangeType(MG_Amount, MG_Amount.GetType());;
base.WriteDebugInfo(@"object MG_Amount=iSpace.Sum(""[0BFAF73B-02D4-4680-B1C9-625AAFB02DB5]"",""MG_Amount"","""",ISpace[""gv_instanceid""].Value);
ISpace[""M_SumOfFund""].Value=Convert.ChangeType(MG_Amount, MG_Amount.GetType());;");
ISpace["MF_T1_AdvanceAmount"].Value=Tostring(ISpace["OverAll_Total"].Value-ISpace["M_T1_AdvanceAmount"].Value);
base.WriteDebugInfo(@"ISpace[""MF_T1_AdvanceAmount""].Value=Tostring(ISpace[""OverAll_Total""].Value-ISpace[""M_T1_AdvanceAmount""].Value);");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"SELECT #OverAll_Total*0.9");

var querySourceB5136E55467F46BF9D46AE1BE798E3D4 =GetQueryExpressionDataSource("B5136E55-467F-46BF-9D46-AE1BE798E3D4");
Dictionary<short,object> resultB5136E55467F46BF9D46AE1BE798E3D4=iSpace.ExecuteQuery(querySourceB5136E55467F46BF9D46AE1BE798E3D4,@"SELECT " + ISpace["OverAll_Total"].Value + @"*0.9",false);

base.WriteDebugInfo(@"var querySourceB5136E55467F46BF9D46AE1BE798E3D4 =GetQueryExpressionDataSource(""B5136E55-467F-46BF-9D46-AE1BE798E3D4"");Dictionary<short,object> resultB5136E55467F46BF9D46AE1BE798E3D4=iSpace.ExecuteQuery(querySourceB5136E55467F46BF9D46AE1BE798E3D4,@""SELECT "" + ISpace[""OverAll_Total""].Value + @""*0.9"",false);");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_T1_AdvanceAmount"].Value<0)
{
base.WriteDebugInfo(@"if(ISpace[""MF_T1_AdvanceAmount""].Value<0)");

ISpace["M_ActualTransactionDate"].Man=true;ISpace["M_ActualTransactionNo"].Man=true;
base.WriteDebugInfo(@"ISpace[""M_ActualTransactionDate""].Man=true;ISpace[""M_ActualTransactionNo""].Man=true;");
ISpace["M_SourceHeader"].Value="Actual Sources of Fund for Settlement";
base.WriteDebugInfo(@"ISpace[""M_SourceHeader""].Value=""Actual Sources of Fund for Settlement"";");
}
else
{
base.WriteDebugInfo(@"else");

ISpace["M_ActualTransactionDate"].Man=false;ISpace["M_ActualTransactionNo"].Man=false;
base.WriteDebugInfo(@"ISpace[""M_ActualTransactionDate""].Man=false;ISpace[""M_ActualTransactionNo""].Man=false;");
ISpace["M_ActualTransactionDate"].Value=null;
base.WriteDebugInfo(@"ISpace[""M_ActualTransactionDate""].Value=null;");
ISpace["M_ActualTransactionNo"].Value=null;
base.WriteDebugInfo(@"ISpace[""M_ActualTransactionNo""].Value=null;");
ISpace["M_SourceHeader"].Value="Actual Sources of Fund for Claim";
base.WriteDebugInfo(@"ISpace[""M_SourceHeader""].Value=""Actual Sources of Fund for Claim"";");
}
ISpace["MF_FundType"].rElemData=iSpace.Reload(ISpace["MF_FundType"].Value,@"exec SP_GetDistrubitionDetails 7,'@" + ISpace["gv_ProcessMapId"].Value + @"','',''," + ISpace["MF_T1_AdvanceAmount"].Value + @",'','" + ISpace["R_ReferenceNo"].Value + @"',''","9ADED37B-CD11-426B-AF16-DEAC75685EF5");
base.WriteDebugInfo(@"ISpace[""MF_FundType""].rElemData=iSpace.Reload(ISpace[""MF_FundType""].Value,@""exec SP_GetDistrubitionDetails 7,'@"" + ISpace[""gv_ProcessMapId""].Value + @""','','',"" + ISpace[""MF_T1_AdvanceAmount""].Value + @"",'','"" + ISpace[""R_ReferenceNo""].Value + @""',''"",""9ADED37B-CD11-426B-AF16-DEAC75685EF5"");");
ISpace["MF_ProjectNo"].rElemData=iSpace.Reload(ISpace["MF_ProjectNo"].Value,@"EXEC Projects..GetProjectExtensionDetails 8,'" + ISpace["UC_EmployeeBaicInfoId"].Value + @"','','',''," + ISpace["MF_T1_AdvanceAmount"].Value + @",'" + ISpace["R_ReferenceNo"].Value + @"'","3A103712-5244-4427-B2B6-1C4E046FD337");
base.WriteDebugInfo(@"ISpace[""MF_ProjectNo""].rElemData=iSpace.Reload(ISpace[""MF_ProjectNo""].Value,@""EXEC Projects..GetProjectExtensionDetails 8,'"" + ISpace[""UC_EmployeeBaicInfoId""].Value + @""','','','',"" + ISpace[""MF_T1_AdvanceAmount""].Value + @"",'"" + ISpace[""R_ReferenceNo""].Value + @""'"",""3A103712-5244-4427-B2B6-1C4E046FD337"");");
ISpace["MF_BudgetHead"].rElemData=iSpace.Reload(ISpace["MF_BudgetHead"].Value,@"exec common..SP_GetDistrubitionDetails 6,'@" + ISpace["gv_ProcessMapId"].Value + @"'," + ISpace["MF_FundType"].Value + @",''," + ISpace["MF_T1_AdvanceAmount"].Value + @",'" + ISpace["UC_EmployeeBaicInfoId"].Value + @"','" + ISpace["R_ReferenceNo"].Value + @"'","9ADED37B-CD11-426B-AF16-DEAC75685EF5");
base.WriteDebugInfo(@"ISpace[""MF_BudgetHead""].rElemData=iSpace.Reload(ISpace[""MF_BudgetHead""].Value,@""exec common..SP_GetDistrubitionDetails 6,'@"" + ISpace[""gv_ProcessMapId""].Value + @""',"" + ISpace[""MF_FundType""].Value + @"",'',"" + ISpace[""MF_T1_AdvanceAmount""].Value + @"",'"" + ISpace[""UC_EmployeeBaicInfoId""].Value + @""','"" + ISpace[""R_ReferenceNo""].Value + @""'"",""9ADED37B-CD11-426B-AF16-DEAC75685EF5"");");
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mfg_t2_departure (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MFG_T2_Departure-OnChange");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MFG_T2_Departure"].Value==ISpace["MFG_T2_Arrival"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MFG_T2_Departure""].Value==ISpace[""MFG_T2_Arrival""].Value)");
ISpace["Message"].Value=@"Arrival Station and Departure Station can""t be same.";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Arrival Station and Departure Station can""""t be same."";");
ISpace["MFG_T2_Arrival"].Value=null;
base.WriteDebugInfo(@"ISpace[""MFG_T2_Arrival""].Value=null;");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_save_otherexpense (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Save_OtherExpense-OnClick");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MFG_T2_ExpenditureTypeID"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""MFG_T2_ExpenditureTypeID""].Value=="""")");
ISpace["Message"].Value=@"Please enter Expenditure type";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please enter Expenditure type"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if((ISpace["MFG_T2_FromDate"].Value == null))
{
base.WriteDebugInfo(@"if((ISpace[""MFG_T2_FromDate""].Value == null))");
ISpace["Message"].Value=@"Please Enter the From Date";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please Enter the From Date"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if((ISpace["MFG_T2_ToDate"].Value == null))
{
base.WriteDebugInfo(@"if((ISpace[""MFG_T2_ToDate""].Value == null))");
ISpace["Message"].Value=@"Please Enter the To Date";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please Enter the To Date"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if(ISpace["MFG_T2_ToDate"].Value< ISpace["MFG_T2_FromDate"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MFG_T2_ToDate""].Value< ISpace[""MFG_T2_FromDate""].Value)");
ISpace["Message"].Value=@"To Date should be greater than From Date";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""To Date should be greater than From Date"";");
ISpace["MFG_T2_ToDate"].Value=null;
base.WriteDebugInfo(@"ISpace[""MFG_T2_ToDate""].Value=null;");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if(ISpace["MFG_T3_Amount"].Value==0)
{
base.WriteDebugInfo(@"if(ISpace[""MFG_T3_Amount""].Value==0)");
ISpace["Message"].Value=@"Please Enter the Amount";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please Enter the Amount"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
}
if(ISpace["growid"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""growid""].Value=="""")");

var querySource12B0DEF7CA444A9EA1D6DF341107FA9C =GetQueryExpressionDataSource("12B0DEF7-CA44-4A9E-A1D6-DF341107FA9C");

DataTable result12B0DEF7CA444A9EA1D6DF341107FA9C=iSpace.SetGridDataSource(querySource12B0DEF7CA444A9EA1D6DF341107FA9C, _objectFactory.GetGridRPP("OtherExpense"),@"EXEC [AddFormGridData7D2812B7-3A49-4DA7-9E48-082B26C3333C] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','51838b37-2ec6-4d35-8a5e-38648bc93ab1','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["MFG_T2_ExpenditureTypeID"].Value + @"','" + ISpace["MFG_T3_TravelAdvanceID"].Value + @"','" + ISpace["MFG_T2_FromDate"].Value + @"','" + ISpace["MFG_T2_ToDate"].Value + @"'," + ISpace["MFG_T3_Amount"].Value + @",'" + ISpace["M_MiscDetails"].Value + @"','" + ISpace["growid"].Value + @"'");

iSpace.InsertGridBindDetails("OtherExpense","11",querySource12B0DEF7CA444A9EA1D6DF341107FA9C,"EXEC [AddFormGridData7D2812B7-3A49-4DA7-9E48-082B26C3333C] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','51838b37-2ec6-4d35-8a5e-38648bc93ab1','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["MFG_T2_ExpenditureTypeID"].Value + @"','" + ISpace["MFG_T3_TravelAdvanceID"].Value + @"','" + ISpace["MFG_T2_FromDate"].Value + @"','" + ISpace["MFG_T2_ToDate"].Value + @"'," + ISpace["MFG_T3_Amount"].Value + @",'" + ISpace["M_MiscDetails"].Value + @"','" + ISpace["growid"].Value + @"'",_objectFactory.GetGridRPP("OtherExpense"));

base.WriteDebugInfo(@"var querySource12B0DEF7CA444A9EA1D6DF341107FA9C =GetQueryExpressionDataSource(""12B0DEF7-CA44-4A9E-A1D6-DF341107FA9C"");DataTable result12B0DEF7CA444A9EA1D6DF341107FA9C=iSpace.SetGridDataSource(querySource12B0DEF7CA444A9EA1D6DF341107FA9C, _objectFactory.GetGridRPP(""OtherExpense""),@""EXEC [AddFormGridData7D2812B7-3A49-4DA7-9E48-082B26C3333C] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','51838b37-2ec6-4d35-8a5e-38648bc93ab1','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""MFG_T2_ExpenditureTypeID""].Value + @""','"" + ISpace[""MFG_T3_TravelAdvanceID""].Value + @""','"" + ISpace[""MFG_T2_FromDate""].Value + @""','"" + ISpace[""MFG_T2_ToDate""].Value + @""',"" + ISpace[""MFG_T3_Amount""].Value + @"",'"" + ISpace[""M_MiscDetails""].Value + @""','"" + ISpace[""growid""].Value + @""'"");iSpace.InsertGridBindDetails(""OtherExpense"",""11"",querySource12B0DEF7CA444A9EA1D6DF341107FA9C,""EXEC [AddFormGridData7D2812B7-3A49-4DA7-9E48-082B26C3333C] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','51838b37-2ec6-4d35-8a5e-38648bc93ab1','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""MFG_T2_ExpenditureTypeID""].Value + @""','"" + ISpace[""MFG_T3_TravelAdvanceID""].Value + @""','"" + ISpace[""MFG_T2_FromDate""].Value + @""','"" + ISpace[""MFG_T2_ToDate""].Value + @""',"" + ISpace[""MFG_T3_Amount""].Value + @"",'"" + ISpace[""M_MiscDetails""].Value + @""','"" + ISpace[""growid""].Value + @""'"",_objectFactory.GetGridRPP(""OtherExpense""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result64882DB7743847AABD1485B89B960F95=acdataIspace0D9E568F8790489DA8463C6057A39268.GetQueryExpressionBindings("64882DB7-7438-47AA-BD14-85B89B960F95");
iSpace.SetGridData(result12B0DEF7CA444A9EA1D6DF341107FA9C,result64882DB7743847AABD1485B89B960F95,"OtherExpense",ref ISpace);
iSpace.UpdateGridBindDetails("OtherExpense",result64882DB7743847AABD1485B89B960F95);
}
else
{
base.WriteDebugInfo(@"else");

var querySourceD8D9A9765AAA4BD2B7D8AE2AA0ACF5BB =GetQueryExpressionDataSource("D8D9A976-5AAA-4BD2-B7D8-AE2AA0ACF5BB");

DataTable resultD8D9A9765AAA4BD2B7D8AE2AA0ACF5BB=iSpace.SetGridDataSource(querySourceD8D9A9765AAA4BD2B7D8AE2AA0ACF5BB, _objectFactory.GetGridRPP("OtherExpense"),@"EXEC [UpdateFormGridData7D2812B7-3A49-4DA7-9E48-082B26C3333C] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','51838b37-2ec6-4d35-8a5e-38648bc93ab1','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["MFG_T2_ExpenditureTypeID"].Value + @"','" + ISpace["MFG_T3_TravelAdvanceID"].Value + @"','" + ISpace["MFG_T2_FromDate"].Value + @"','" + ISpace["MFG_T2_ToDate"].Value + @"'," + ISpace["MFG_T3_Amount"].Value + @",'" + ISpace["M_MiscDetails"].Value + @"','" + ISpace["growid"].Value + @"'");

iSpace.InsertGridBindDetails("OtherExpense","11",querySourceD8D9A9765AAA4BD2B7D8AE2AA0ACF5BB,"EXEC [UpdateFormGridData7D2812B7-3A49-4DA7-9E48-082B26C3333C] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','51838b37-2ec6-4d35-8a5e-38648bc93ab1','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["MFG_T2_ExpenditureTypeID"].Value + @"','" + ISpace["MFG_T3_TravelAdvanceID"].Value + @"','" + ISpace["MFG_T2_FromDate"].Value + @"','" + ISpace["MFG_T2_ToDate"].Value + @"'," + ISpace["MFG_T3_Amount"].Value + @",'" + ISpace["M_MiscDetails"].Value + @"','" + ISpace["growid"].Value + @"'",_objectFactory.GetGridRPP("OtherExpense"));

base.WriteDebugInfo(@"var querySourceD8D9A9765AAA4BD2B7D8AE2AA0ACF5BB =GetQueryExpressionDataSource(""D8D9A976-5AAA-4BD2-B7D8-AE2AA0ACF5BB"");DataTable resultD8D9A9765AAA4BD2B7D8AE2AA0ACF5BB=iSpace.SetGridDataSource(querySourceD8D9A9765AAA4BD2B7D8AE2AA0ACF5BB, _objectFactory.GetGridRPP(""OtherExpense""),@""EXEC [UpdateFormGridData7D2812B7-3A49-4DA7-9E48-082B26C3333C] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','51838b37-2ec6-4d35-8a5e-38648bc93ab1','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""MFG_T2_ExpenditureTypeID""].Value + @""','"" + ISpace[""MFG_T3_TravelAdvanceID""].Value + @""','"" + ISpace[""MFG_T2_FromDate""].Value + @""','"" + ISpace[""MFG_T2_ToDate""].Value + @""',"" + ISpace[""MFG_T3_Amount""].Value + @"",'"" + ISpace[""M_MiscDetails""].Value + @""','"" + ISpace[""growid""].Value + @""'"");iSpace.InsertGridBindDetails(""OtherExpense"",""11"",querySourceD8D9A9765AAA4BD2B7D8AE2AA0ACF5BB,""EXEC [UpdateFormGridData7D2812B7-3A49-4DA7-9E48-082B26C3333C] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','51838b37-2ec6-4d35-8a5e-38648bc93ab1','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""MFG_T2_ExpenditureTypeID""].Value + @""','"" + ISpace[""MFG_T3_TravelAdvanceID""].Value + @""','"" + ISpace[""MFG_T2_FromDate""].Value + @""','"" + ISpace[""MFG_T2_ToDate""].Value + @""',"" + ISpace[""MFG_T3_Amount""].Value + @"",'"" + ISpace[""M_MiscDetails""].Value + @""','"" + ISpace[""growid""].Value + @""'"",_objectFactory.GetGridRPP(""OtherExpense""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result6576B6646EA0465AB088222E2C22B535=acdataIspace0D9E568F8790489DA8463C6057A39268.GetQueryExpressionBindings("6576B664-6EA0-465A-B088-222E2C22B535");
iSpace.SetGridData(resultD8D9A9765AAA4BD2B7D8AE2AA0ACF5BB,result6576B6646EA0465AB088222E2C22B535,"OtherExpense",ref ISpace);
iSpace.UpdateGridBindDetails("OtherExpense",result6576B6646EA0465AB088222E2C22B535);
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["growid"].Value="";
base.WriteDebugInfo(@"ISpace[""growid""].Value="""";");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["MFG_T3_Amount"].Value=null;
base.WriteDebugInfo(@"ISpace[""MFG_T3_Amount""].Value=null;");
ISpace["MFG_T2_FromDate"].Value=null;
base.WriteDebugInfo(@"ISpace[""MFG_T2_FromDate""].Value=null;");
ISpace["MFG_T2_ToDate"].Value=null;
base.WriteDebugInfo(@"ISpace[""MFG_T2_ToDate""].Value=null;");
ISpace["MFG_T2_ExpenditureTypeID"].Value=null;
base.WriteDebugInfo(@"ISpace[""MFG_T2_ExpenditureTypeID""].Value=null;");
}
object MG_T3_Amount=iSpace.Sum("[7D2812B7-3A49-4DA7-9E48-082B26C3333C]","MG_T3_Amount","",ISpace["gv_instanceid"].Value);
ISpace["T_ExpenditureTotal"].Value=Convert.ChangeType(MG_T3_Amount, MG_T3_Amount.GetType());;
base.WriteDebugInfo(@"object MG_T3_Amount=iSpace.Sum(""[7D2812B7-3A49-4DA7-9E48-082B26C3333C]"",""MG_T3_Amount"","""",ISpace[""gv_instanceid""].Value);
ISpace[""T_ExpenditureTotal""].Value=Convert.ChangeType(MG_T3_Amount, MG_T3_Amount.GetType());;");
ISpace["OverAll_Total"].Value=ISpace["T_TravelAdvanceTotal"].Value+ISpace["T_ExpenditureTotal"].Value;
base.WriteDebugInfo(@"ISpace[""OverAll_Total""].Value=ISpace[""T_TravelAdvanceTotal""].Value+ISpace[""T_ExpenditureTotal""].Value;");
object MG_Amount=iSpace.Sum("[0BFAF73B-02D4-4680-B1C9-625AAFB02DB5]","MG_Amount","",ISpace["gv_instanceid"].Value);
ISpace["M_SumOfFund"].Value=Convert.ChangeType(MG_Amount, MG_Amount.GetType());;
base.WriteDebugInfo(@"object MG_Amount=iSpace.Sum(""[0BFAF73B-02D4-4680-B1C9-625AAFB02DB5]"",""MG_Amount"","""",ISpace[""gv_instanceid""].Value);
ISpace[""M_SumOfFund""].Value=Convert.ChangeType(MG_Amount, MG_Amount.GetType());;");
ISpace["MF_T1_AdvanceAmount"].Value=Tostring(ISpace["OverAll_Total"].Value-ISpace["M_T1_AdvanceAmount"].Value);
base.WriteDebugInfo(@"ISpace[""MF_T1_AdvanceAmount""].Value=Tostring(ISpace[""OverAll_Total""].Value-ISpace[""M_T1_AdvanceAmount""].Value);");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"SELECT #OverAll_Total*0.9");

var querySourceB5136E55467F46BF9D46AE1BE798E3D4 =GetQueryExpressionDataSource("B5136E55-467F-46BF-9D46-AE1BE798E3D4");
Dictionary<short,object> resultB5136E55467F46BF9D46AE1BE798E3D4=iSpace.ExecuteQuery(querySourceB5136E55467F46BF9D46AE1BE798E3D4,@"SELECT " + ISpace["OverAll_Total"].Value + @"*0.9",false);

base.WriteDebugInfo(@"var querySourceB5136E55467F46BF9D46AE1BE798E3D4 =GetQueryExpressionDataSource(""B5136E55-467F-46BF-9D46-AE1BE798E3D4"");Dictionary<short,object> resultB5136E55467F46BF9D46AE1BE798E3D4=iSpace.ExecuteQuery(querySourceB5136E55467F46BF9D46AE1BE798E3D4,@""SELECT "" + ISpace[""OverAll_Total""].Value + @""*0.9"",false);");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_T1_AdvanceAmount"].Value<0)
{
base.WriteDebugInfo(@"if(ISpace[""MF_T1_AdvanceAmount""].Value<0)");

ISpace["M_ActualTransactionDate"].Man=true;ISpace["M_ActualTransactionNo"].Man=true;
base.WriteDebugInfo(@"ISpace[""M_ActualTransactionDate""].Man=true;ISpace[""M_ActualTransactionNo""].Man=true;");
ISpace["M_SourceHeader"].Value="Actual Sources of Fund for Settlement";
base.WriteDebugInfo(@"ISpace[""M_SourceHeader""].Value=""Actual Sources of Fund for Settlement"";");
}
else
{
base.WriteDebugInfo(@"else");

ISpace["M_ActualTransactionDate"].Man=false;ISpace["M_ActualTransactionNo"].Man=false;
base.WriteDebugInfo(@"ISpace[""M_ActualTransactionDate""].Man=false;ISpace[""M_ActualTransactionNo""].Man=false;");
ISpace["M_ActualTransactionDate"].Value=null;
base.WriteDebugInfo(@"ISpace[""M_ActualTransactionDate""].Value=null;");
ISpace["M_ActualTransactionNo"].Value=null;
base.WriteDebugInfo(@"ISpace[""M_ActualTransactionNo""].Value=null;");
ISpace["M_SourceHeader"].Value="Actual Sources of Fund for Claim";
base.WriteDebugInfo(@"ISpace[""M_SourceHeader""].Value=""Actual Sources of Fund for Claim"";");
}
ISpace["MF_FundType"].rElemData=iSpace.Reload(ISpace["MF_FundType"].Value,@"exec SP_GetDistrubitionDetails 7,'@" + ISpace["gv_ProcessMapId"].Value + @"','',''," + ISpace["MF_T1_AdvanceAmount"].Value + @",'','" + ISpace["R_ReferenceNo"].Value + @"',''","9ADED37B-CD11-426B-AF16-DEAC75685EF5");
base.WriteDebugInfo(@"ISpace[""MF_FundType""].rElemData=iSpace.Reload(ISpace[""MF_FundType""].Value,@""exec SP_GetDistrubitionDetails 7,'@"" + ISpace[""gv_ProcessMapId""].Value + @""','','',"" + ISpace[""MF_T1_AdvanceAmount""].Value + @"",'','"" + ISpace[""R_ReferenceNo""].Value + @""',''"",""9ADED37B-CD11-426B-AF16-DEAC75685EF5"");");
ISpace["MF_ProjectNo"].rElemData=iSpace.Reload(ISpace["MF_ProjectNo"].Value,@"EXEC Projects..GetProjectExtensionDetails 8,'" + ISpace["UC_EmployeeBaicInfoId"].Value + @"','','',''," + ISpace["MF_T1_AdvanceAmount"].Value + @",'" + ISpace["R_ReferenceNo"].Value + @"'","3A103712-5244-4427-B2B6-1C4E046FD337");
base.WriteDebugInfo(@"ISpace[""MF_ProjectNo""].rElemData=iSpace.Reload(ISpace[""MF_ProjectNo""].Value,@""EXEC Projects..GetProjectExtensionDetails 8,'"" + ISpace[""UC_EmployeeBaicInfoId""].Value + @""','','','',"" + ISpace[""MF_T1_AdvanceAmount""].Value + @"",'"" + ISpace[""R_ReferenceNo""].Value + @""'"",""3A103712-5244-4427-B2B6-1C4E046FD337"");");
ISpace["MF_BudgetHead"].rElemData=iSpace.Reload(ISpace["MF_BudgetHead"].Value,@"exec common..SP_GetDistrubitionDetails 6,'@" + ISpace["gv_ProcessMapId"].Value + @"'," + ISpace["MF_FundType"].Value + @",''," + ISpace["MF_T1_AdvanceAmount"].Value + @",'" + ISpace["UC_EmployeeBaicInfoId"].Value + @"','" + ISpace["R_ReferenceNo"].Value + @"'","9ADED37B-CD11-426B-AF16-DEAC75685EF5");
base.WriteDebugInfo(@"ISpace[""MF_BudgetHead""].rElemData=iSpace.Reload(ISpace[""MF_BudgetHead""].Value,@""exec common..SP_GetDistrubitionDetails 6,'@"" + ISpace[""gv_ProcessMapId""].Value + @""',"" + ISpace[""MF_FundType""].Value + @"",'',"" + ISpace[""MF_T1_AdvanceAmount""].Value + @"",'"" + ISpace[""UC_EmployeeBaicInfoId""].Value + @""','"" + ISpace[""R_ReferenceNo""].Value + @""'"",""9ADED37B-CD11-426B-AF16-DEAC75685EF5"");");
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mg_t2_amount (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MG_T2_Amount-OnChange");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
object MG_T2_Amount=iSpace.Sum("[9F49372F-0255-42EC-AB05-31E6C4F9F2EA]","MG_T2_Amount","",ISpace["gv_instanceid"].Value);
ISpace["T_TravelAdvanceTotal"].Value=Convert.ChangeType(MG_T2_Amount, MG_T2_Amount.GetType());;
base.WriteDebugInfo(@"object MG_T2_Amount=iSpace.Sum(""[9F49372F-0255-42EC-AB05-31E6C4F9F2EA]"",""MG_T2_Amount"","""",ISpace[""gv_instanceid""].Value);
ISpace[""T_TravelAdvanceTotal""].Value=Convert.ChangeType(MG_T2_Amount, MG_T2_Amount.GetType());;");
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_m_fundyes (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"M_FundYes-OnClick");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySourceDC54108308784D23B8BB9B0CE733EEDF =GetQueryExpressionDataSource("DC541083-0878-4D23-B8BB-9B0CE733EEDF");

DataTable resultDC54108308784D23B8BB9B0CE733EEDF=iSpace.SetGridDataSource(querySourceDC54108308784D23B8BB9B0CE733EEDF, _objectFactory.GetGridRPP("MF_FundAmount"),@"exec SP_GetTravelAdvanceFundDetails 5,'" + ISpace["R_ReferenceNo"].Value + @"','" + ISpace["MF_FundDetailsId"].Value + @"','" + ISpace["M_TravelInstanceId"].Value + @"'");

iSpace.InsertGridBindDetails("MF_FundAmount","11",querySourceDC54108308784D23B8BB9B0CE733EEDF,"exec SP_GetTravelAdvanceFundDetails 5,'" + ISpace["R_ReferenceNo"].Value + @"','" + ISpace["MF_FundDetailsId"].Value + @"','" + ISpace["M_TravelInstanceId"].Value + @"'",_objectFactory.GetGridRPP("MF_FundAmount"));

base.WriteDebugInfo(@"var querySourceDC54108308784D23B8BB9B0CE733EEDF =GetQueryExpressionDataSource(""DC541083-0878-4D23-B8BB-9B0CE733EEDF"");DataTable resultDC54108308784D23B8BB9B0CE733EEDF=iSpace.SetGridDataSource(querySourceDC54108308784D23B8BB9B0CE733EEDF, _objectFactory.GetGridRPP(""MF_FundAmount""),@""exec SP_GetTravelAdvanceFundDetails 5,'"" + ISpace[""R_ReferenceNo""].Value + @""','"" + ISpace[""MF_FundDetailsId""].Value + @""','"" + ISpace[""M_TravelInstanceId""].Value + @""'"");iSpace.InsertGridBindDetails(""MF_FundAmount"",""11"",querySourceDC54108308784D23B8BB9B0CE733EEDF,""exec SP_GetTravelAdvanceFundDetails 5,'"" + ISpace[""R_ReferenceNo""].Value + @""','"" + ISpace[""MF_FundDetailsId""].Value + @""','"" + ISpace[""M_TravelInstanceId""].Value + @""'"",_objectFactory.GetGridRPP(""MF_FundAmount""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> resultE5D66127B8634FE5BB07A33C0F84EDE2=acdataIspace0D9E568F8790489DA8463C6057A39268.GetQueryExpressionBindings("E5D66127-B863-4FE5-BB07-A33C0F84EDE2");
iSpace.SetGridData(resultDC54108308784D23B8BB9B0CE733EEDF,resultE5D66127B8634FE5BB07A33C0F84EDE2,"MF_FundAmount",ref ISpace);
iSpace.UpdateGridBindDetails("MF_FundAmount",resultE5D66127B8634FE5BB07A33C0F84EDE2);
ISpace["MF_FundDetailsId"].Value="";
base.WriteDebugInfo(@"ISpace[""MF_FundDetailsId""].Value="""";");
object MG_Amount=iSpace.Sum("[0BFAF73B-02D4-4680-B1C9-625AAFB02DB5]","MG_Amount","",ISpace["gv_instanceid"].Value);
ISpace["M_SumOfFund"].Value=Convert.ChangeType(MG_Amount, MG_Amount.GetType());;
base.WriteDebugInfo(@"object MG_Amount=iSpace.Sum(""[0BFAF73B-02D4-4680-B1C9-625AAFB02DB5]"",""MG_Amount"","""",ISpace[""gv_instanceid""].Value);
ISpace[""M_SumOfFund""].Value=Convert.ChangeType(MG_Amount, MG_Amount.GetType());;");
ISpace["Message"].Value=@"Data deleted successfully";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Data deleted successfully"";");
ISpace["UI_DialogFund"].HideDialog=true;;
base.WriteDebugInfo(@"ISpace[""UI_DialogFund""].HideDialog=true;;");
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_m_travelno (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"M_TravelNo-OnClick");
ISpace["growid"].Value="";
base.WriteDebugInfo(@"ISpace[""growid""].Value="""";");
ISpace["UI_DialogTravel"].HideDialog=true;;
base.WriteDebugInfo(@"ISpace[""UI_DialogTravel""].HideDialog=true;;");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_m_otheryes (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"M_OtherYes-OnClick");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"SELECT #OverAll_Total*0.9");

var querySourceB5136E55467F46BF9D46AE1BE798E3D4 =GetQueryExpressionDataSource("B5136E55-467F-46BF-9D46-AE1BE798E3D4");
Dictionary<short,object> resultB5136E55467F46BF9D46AE1BE798E3D4=iSpace.ExecuteQuery(querySourceB5136E55467F46BF9D46AE1BE798E3D4,@"SELECT " + ISpace["OverAll_Total"].Value + @"*0.9",false);

base.WriteDebugInfo(@"var querySourceB5136E55467F46BF9D46AE1BE798E3D4 =GetQueryExpressionDataSource(""B5136E55-467F-46BF-9D46-AE1BE798E3D4"");Dictionary<short,object> resultB5136E55467F46BF9D46AE1BE798E3D4=iSpace.ExecuteQuery(querySourceB5136E55467F46BF9D46AE1BE798E3D4,@""SELECT "" + ISpace[""OverAll_Total""].Value + @""*0.9"",false);");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySource9B59C95F3EF44759B14AAA281DE48F47 =GetQueryExpressionDataSource("9B59C95F-3EF4-4759-B14A-AA281DE48F47");

DataTable result9B59C95F3EF44759B14AAA281DE48F47=iSpace.SetGridDataSource(querySource9B59C95F3EF44759B14AAA281DE48F47, _objectFactory.GetGridRPP("OtherExpense"),@"EXEC [DeleteFormGridData7D2812B7-3A49-4DA7-9E48-082B26C3333C] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','51838b37-2ec6-4d35-8a5e-38648bc93ab1','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["growid"].Value + @"'");

iSpace.InsertGridBindDetails("OtherExpense","11",querySource9B59C95F3EF44759B14AAA281DE48F47,"EXEC [DeleteFormGridData7D2812B7-3A49-4DA7-9E48-082B26C3333C] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','51838b37-2ec6-4d35-8a5e-38648bc93ab1','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["growid"].Value + @"'",_objectFactory.GetGridRPP("OtherExpense"));

base.WriteDebugInfo(@"var querySource9B59C95F3EF44759B14AAA281DE48F47 =GetQueryExpressionDataSource(""9B59C95F-3EF4-4759-B14A-AA281DE48F47"");DataTable result9B59C95F3EF44759B14AAA281DE48F47=iSpace.SetGridDataSource(querySource9B59C95F3EF44759B14AAA281DE48F47, _objectFactory.GetGridRPP(""OtherExpense""),@""EXEC [DeleteFormGridData7D2812B7-3A49-4DA7-9E48-082B26C3333C] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','51838b37-2ec6-4d35-8a5e-38648bc93ab1','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""growid""].Value + @""'"");iSpace.InsertGridBindDetails(""OtherExpense"",""11"",querySource9B59C95F3EF44759B14AAA281DE48F47,""EXEC [DeleteFormGridData7D2812B7-3A49-4DA7-9E48-082B26C3333C] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','51838b37-2ec6-4d35-8a5e-38648bc93ab1','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""growid""].Value + @""'"",_objectFactory.GetGridRPP(""OtherExpense""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> resultE4242D902E8F4517812054465963606A=acdataIspace0D9E568F8790489DA8463C6057A39268.GetQueryExpressionBindings("E4242D90-2E8F-4517-8120-54465963606A");
iSpace.SetGridData(result9B59C95F3EF44759B14AAA281DE48F47,resultE4242D902E8F4517812054465963606A,"OtherExpense",ref ISpace);
iSpace.UpdateGridBindDetails("OtherExpense",resultE4242D902E8F4517812054465963606A);
ISpace["Message"].Value=@"Data deleted successfully";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Data deleted successfully"";");
object MG_T3_Amount=iSpace.Sum("[7D2812B7-3A49-4DA7-9E48-082B26C3333C]","MG_T3_Amount","",ISpace["gv_instanceid"].Value);
ISpace["T_ExpenditureTotal"].Value=Convert.ChangeType(MG_T3_Amount, MG_T3_Amount.GetType());;
base.WriteDebugInfo(@"object MG_T3_Amount=iSpace.Sum(""[7D2812B7-3A49-4DA7-9E48-082B26C3333C]"",""MG_T3_Amount"","""",ISpace[""gv_instanceid""].Value);
ISpace[""T_ExpenditureTotal""].Value=Convert.ChangeType(MG_T3_Amount, MG_T3_Amount.GetType());;");
ISpace["OverAll_Total"].Value=ISpace["T_TravelAdvanceTotal"].Value+ISpace["T_ExpenditureTotal"].Value;
base.WriteDebugInfo(@"ISpace[""OverAll_Total""].Value=ISpace[""T_TravelAdvanceTotal""].Value+ISpace[""T_ExpenditureTotal""].Value;");
ISpace["growid"].Value="";
base.WriteDebugInfo(@"ISpace[""growid""].Value="""";");
object MG_Amount=iSpace.Sum("[0BFAF73B-02D4-4680-B1C9-625AAFB02DB5]","MG_Amount","",ISpace["gv_instanceid"].Value);
ISpace["M_SumOfFund"].Value=Convert.ChangeType(MG_Amount, MG_Amount.GetType());;
base.WriteDebugInfo(@"object MG_Amount=iSpace.Sum(""[0BFAF73B-02D4-4680-B1C9-625AAFB02DB5]"",""MG_Amount"","""",ISpace[""gv_instanceid""].Value);
ISpace[""M_SumOfFund""].Value=Convert.ChangeType(MG_Amount, MG_Amount.GetType());;");
ISpace["MF_T1_AdvanceAmount"].Value=Tostring(ISpace["OverAll_Total"].Value-ISpace["M_T1_AdvanceAmount"].Value);
base.WriteDebugInfo(@"ISpace[""MF_T1_AdvanceAmount""].Value=Tostring(ISpace[""OverAll_Total""].Value-ISpace[""M_T1_AdvanceAmount""].Value);");
ISpace["UI_DialogOther"].HideDialog=true;;
base.WriteDebugInfo(@"ISpace[""UI_DialogOther""].HideDialog=true;;");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_T1_AdvanceAmount"].Value<0)
{
base.WriteDebugInfo(@"if(ISpace[""MF_T1_AdvanceAmount""].Value<0)");

ISpace["M_ActualTransactionDate"].Man=true;ISpace["M_ActualTransactionNo"].Man=true;
base.WriteDebugInfo(@"ISpace[""M_ActualTransactionDate""].Man=true;ISpace[""M_ActualTransactionNo""].Man=true;");
ISpace["M_SourceHeader"].Value="Actual Sources of Fund for Settlement";
base.WriteDebugInfo(@"ISpace[""M_SourceHeader""].Value=""Actual Sources of Fund for Settlement"";");
}
else
{
base.WriteDebugInfo(@"else");

ISpace["M_ActualTransactionDate"].Man=false;ISpace["M_ActualTransactionNo"].Man=false;
base.WriteDebugInfo(@"ISpace[""M_ActualTransactionDate""].Man=false;ISpace[""M_ActualTransactionNo""].Man=false;");
ISpace["M_ActualTransactionDate"].Value=null;
base.WriteDebugInfo(@"ISpace[""M_ActualTransactionDate""].Value=null;");
ISpace["M_ActualTransactionNo"].Value=null;
base.WriteDebugInfo(@"ISpace[""M_ActualTransactionNo""].Value=null;");
ISpace["M_SourceHeader"].Value="Actual Sources of Fund for Claim";
base.WriteDebugInfo(@"ISpace[""M_SourceHeader""].Value=""Actual Sources of Fund for Claim"";");
}
ISpace["MF_FundType"].rElemData=iSpace.Reload(ISpace["MF_FundType"].Value,@"exec SP_GetDistrubitionDetails 7,'@" + ISpace["gv_ProcessMapId"].Value + @"','',''," + ISpace["MF_T1_AdvanceAmount"].Value + @",'','" + ISpace["R_ReferenceNo"].Value + @"',''","9ADED37B-CD11-426B-AF16-DEAC75685EF5");
base.WriteDebugInfo(@"ISpace[""MF_FundType""].rElemData=iSpace.Reload(ISpace[""MF_FundType""].Value,@""exec SP_GetDistrubitionDetails 7,'@"" + ISpace[""gv_ProcessMapId""].Value + @""','','',"" + ISpace[""MF_T1_AdvanceAmount""].Value + @"",'','"" + ISpace[""R_ReferenceNo""].Value + @""',''"",""9ADED37B-CD11-426B-AF16-DEAC75685EF5"");");
ISpace["MF_ProjectNo"].rElemData=iSpace.Reload(ISpace["MF_ProjectNo"].Value,@"EXEC Projects..GetProjectExtensionDetails 8,'" + ISpace["UC_EmployeeBaicInfoId"].Value + @"','','',''," + ISpace["MF_T1_AdvanceAmount"].Value + @",'" + ISpace["R_ReferenceNo"].Value + @"'","3A103712-5244-4427-B2B6-1C4E046FD337");
base.WriteDebugInfo(@"ISpace[""MF_ProjectNo""].rElemData=iSpace.Reload(ISpace[""MF_ProjectNo""].Value,@""EXEC Projects..GetProjectExtensionDetails 8,'"" + ISpace[""UC_EmployeeBaicInfoId""].Value + @""','','','',"" + ISpace[""MF_T1_AdvanceAmount""].Value + @"",'"" + ISpace[""R_ReferenceNo""].Value + @""'"",""3A103712-5244-4427-B2B6-1C4E046FD337"");");
ISpace["MF_BudgetHead"].rElemData=iSpace.Reload(ISpace["MF_BudgetHead"].Value,@"exec common..SP_GetDistrubitionDetails 6,'@" + ISpace["gv_ProcessMapId"].Value + @"'," + ISpace["MF_FundType"].Value + @",''," + ISpace["MF_T1_AdvanceAmount"].Value + @",'" + ISpace["UC_EmployeeBaicInfoId"].Value + @"','" + ISpace["R_ReferenceNo"].Value + @"'","9ADED37B-CD11-426B-AF16-DEAC75685EF5");
base.WriteDebugInfo(@"ISpace[""MF_BudgetHead""].rElemData=iSpace.Reload(ISpace[""MF_BudgetHead""].Value,@""exec common..SP_GetDistrubitionDetails 6,'@"" + ISpace[""gv_ProcessMapId""].Value + @""',"" + ISpace[""MF_FundType""].Value + @"",'',"" + ISpace[""MF_T1_AdvanceAmount""].Value + @"",'"" + ISpace[""UC_EmployeeBaicInfoId""].Value + @""','"" + ISpace[""R_ReferenceNo""].Value + @""'"",""9ADED37B-CD11-426B-AF16-DEAC75685EF5"");");
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mg_edit (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MG_Edit-OnClick");
if(1==2)
{
base.WriteDebugInfo(@"if(1==2)");
ISpace["MF_FundType"].Value=Tostring(ISpace["MG_FundTypeId"].Value);
base.WriteDebugInfo(@"ISpace[""MF_FundType""].Value=Tostring(ISpace[""MG_FundTypeId""].Value);");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_FundType"].Value=="1")
{
base.WriteDebugInfo(@"if(ISpace[""MF_FundType""].Value==""1"")");
ISpace["MF_Amount"].Visible="true";ISpace["MF_Amount"].Man=true;ISpace["MF_BudgetHead"].Visible="true";ISpace["MF_BudgetHead"].Man=true;ISpace["MF_ProjectNo"].Visible="true";ISpace["MF_ProjectNo"].Man=true;
base.WriteDebugInfo(@"ISpace[""MF_Amount""].Visible=""true"";ISpace[""MF_Amount""].Man=true;ISpace[""MF_BudgetHead""].Visible=""true"";ISpace[""MF_BudgetHead""].Man=true;ISpace[""MF_ProjectNo""].Visible=""true"";ISpace[""MF_ProjectNo""].Man=true;");
ISpace["M_OpenModal"].Visible="true";
base.WriteDebugInfo(@"ISpace[""M_OpenModal""].Visible=""true"";");
ISpace["MF_BudgetHead"].rElemData=iSpace.Reload(ISpace["MF_BudgetHead"].Value,@"exec common..SP_GetDistrubitionDetails 6,'@" + ISpace["gv_ProcessMapId"].Value + @"'," + ISpace["MF_FundType"].Value + @",''," + ISpace["MF_T1_AdvanceAmount"].Value + @",'" + ISpace["UC_EmployeeBaicInfoId"].Value + @"','" + ISpace["R_ReferenceNo"].Value + @"'","9ADED37B-CD11-426B-AF16-DEAC75685EF5");
base.WriteDebugInfo(@"ISpace[""MF_BudgetHead""].rElemData=iSpace.Reload(ISpace[""MF_BudgetHead""].Value,@""exec common..SP_GetDistrubitionDetails 6,'@"" + ISpace[""gv_ProcessMapId""].Value + @""',"" + ISpace[""MF_FundType""].Value + @"",'',"" + ISpace[""MF_T1_AdvanceAmount""].Value + @"",'"" + ISpace[""UC_EmployeeBaicInfoId""].Value + @""','"" + ISpace[""R_ReferenceNo""].Value + @""'"",""9ADED37B-CD11-426B-AF16-DEAC75685EF5"");");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_Amount"].Visible="true";ISpace["MF_Amount"].Man=true;ISpace["MF_BudgetHead"].Visible="false";ISpace["MF_BudgetHead"].Man=false;ISpace["MF_ProjectNo"].Visible="false";ISpace["MF_ProjectNo"].Man=false;
base.WriteDebugInfo(@"ISpace[""MF_Amount""].Visible=""true"";ISpace[""MF_Amount""].Man=true;ISpace[""MF_BudgetHead""].Visible=""false"";ISpace[""MF_BudgetHead""].Man=false;ISpace[""MF_ProjectNo""].Visible=""false"";ISpace[""MF_ProjectNo""].Man=false;");
ISpace["M_OpenModal"].Visible="false";
base.WriteDebugInfo(@"ISpace[""M_OpenModal""].Visible=""false"";");
}
if(ISpace["MF_FundDetailsId"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""MF_FundDetailsId""].Value=="""")");
ISpace["MF_ProjectNo"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_ProjectNo""].Value=null;");
ISpace["MF_BudgetHead"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_BudgetHead""].Value=null;");
ISpace["MF_Amount"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_Amount""].Value=null;");
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"exec SP_GetTravelAdvanceFundDetails 2,'','#MG_FundDetailsID'");

var querySource38798B7FB90F4A269A305317A9489D0E =GetQueryExpressionDataSource("38798B7F-B90F-4A26-9A30-5317A9489D0E");
Dictionary<short,object> result38798B7FB90F4A269A305317A9489D0E=iSpace.ExecuteQuery(querySource38798B7FB90F4A269A305317A9489D0E,@"exec SP_GetTravelAdvanceFundDetails 2,'','" + ISpace["MG_FundDetailsID"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource38798B7FB90F4A269A305317A9489D0E =GetQueryExpressionDataSource(""38798B7F-B90F-4A26-9A30-5317A9489D0E"");Dictionary<short,object> result38798B7FB90F4A269A305317A9489D0E=iSpace.ExecuteQuery(querySource38798B7FB90F4A269A305317A9489D0E,@""exec SP_GetTravelAdvanceFundDetails 2,'','"" + ISpace[""MG_FundDetailsID""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result38798B7FB90F4A269A305317A9489D0E!=null) && (result38798B7FB90F4A269A305317A9489D0E.Count!=0))
{
if(result38798B7FB90F4A269A305317A9489D0E.ContainsKey(4))
ISpace["MF_BudgetHead"].Value = result38798B7FB90F4A269A305317A9489D0E[4];
if(result38798B7FB90F4A269A305317A9489D0E.ContainsKey(2))
ISpace["MF_FundType"].Value = result38798B7FB90F4A269A305317A9489D0E[2];
if(result38798B7FB90F4A269A305317A9489D0E.ContainsKey(3))
ISpace["MF_ProjectNo"].Value = result38798B7FB90F4A269A305317A9489D0E[3];
if(result38798B7FB90F4A269A305317A9489D0E.ContainsKey(5))
ISpace["MF_Amount"].Value = result38798B7FB90F4A269A305317A9489D0E[5];
if(result38798B7FB90F4A269A305317A9489D0E.ContainsKey(0))
ISpace["MF_FundDetailsId"].Value = result38798B7FB90F4A269A305317A9489D0E[0];
}
else{
ISpace["MF_BudgetHead"].Value = null;ISpace["MF_FundType"].Value = null;ISpace["MF_ProjectNo"].Value = null;ISpace["MF_Amount"].Value = null;ISpace["MF_FundDetailsId"].Value = null;
}
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_t_traveladvancetotal (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"T_TravelAdvanceTotal-OnChange");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["OverAll_Total"].Value=ISpace["T_ExpenditureTotal"].Value+ISpace["T_TravelAdvanceTotal"].Value;
base.WriteDebugInfo(@"ISpace[""OverAll_Total""].Value=ISpace[""T_ExpenditureTotal""].Value+ISpace[""T_TravelAdvanceTotal""].Value;");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"SELECT #OverAll_Total*0.9");

var querySourceB5136E55467F46BF9D46AE1BE798E3D4 =GetQueryExpressionDataSource("B5136E55-467F-46BF-9D46-AE1BE798E3D4");
Dictionary<short,object> resultB5136E55467F46BF9D46AE1BE798E3D4=iSpace.ExecuteQuery(querySourceB5136E55467F46BF9D46AE1BE798E3D4,@"SELECT " + ISpace["OverAll_Total"].Value + @"*0.9",false);

base.WriteDebugInfo(@"var querySourceB5136E55467F46BF9D46AE1BE798E3D4 =GetQueryExpressionDataSource(""B5136E55-467F-46BF-9D46-AE1BE798E3D4"");Dictionary<short,object> resultB5136E55467F46BF9D46AE1BE798E3D4=iSpace.ExecuteQuery(querySourceB5136E55467F46BF9D46AE1BE798E3D4,@""SELECT "" + ISpace[""OverAll_Total""].Value + @""*0.9"",false);");
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mf_t1_budgethead (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MF_T1_BudgetHead-OnChange");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC GetAvailableBudget '#MF_T1_BudgetHead'");

var querySource8AF4DAA139C043E7A56512D8253420A4 =GetQueryExpressionDataSource("8AF4DAA1-39C0-43E7-A565-12D8253420A4");
Dictionary<short,object> result8AF4DAA139C043E7A56512D8253420A4=iSpace.ExecuteQuery(querySource8AF4DAA139C043E7A56512D8253420A4,@"EXEC GetAvailableBudget '" + ISpace["MF_T1_BudgetHead"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource8AF4DAA139C043E7A56512D8253420A4 =GetQueryExpressionDataSource(""8AF4DAA1-39C0-43E7-A565-12D8253420A4"");Dictionary<short,object> result8AF4DAA139C043E7A56512D8253420A4=iSpace.ExecuteQuery(querySource8AF4DAA139C043E7A56512D8253420A4,@""EXEC GetAvailableBudget '"" + ISpace[""MF_T1_BudgetHead""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result8AF4DAA139C043E7A56512D8253420A4!=null) && (result8AF4DAA139C043E7A56512D8253420A4.Count!=0))
{
if(result8AF4DAA139C043E7A56512D8253420A4.ContainsKey(0))
ISpace["MF_T1_AvailableBudget"].Value = result8AF4DAA139C043E7A56512D8253420A4[0];
}
else{
ISpace["MF_T1_AvailableBudget"].Value = null;
}
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mfg_t2_fromdate (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MFG_T2_FromDate-OnChange");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MFG_T2_ToDate"].Value< ISpace["MFG_T2_FromDate"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MFG_T2_ToDate""].Value< ISpace[""MFG_T2_FromDate""].Value)");
ISpace["Message"].Value=@"To Date should be greater than From Date";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""To Date should be greater than From Date"";");
ISpace["MFG_T2_ToDate"].Value=null;
base.WriteDebugInfo(@"ISpace[""MFG_T2_ToDate""].Value=null;");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mg_t2_fromdate (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MG_T2_FromDate-OnChange");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MFG_T2_ToDate"].Value< ISpace["MFG_T2_FromDate"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MFG_T2_ToDate""].Value< ISpace[""MFG_T2_FromDate""].Value)");
ISpace["Message"].Value=@"To Date should be greater than From Date";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""To Date should be greater than From Date"";");
ISpace["MFG_T2_ToDate"].Value=null;
base.WriteDebugInfo(@"ISpace[""MFG_T2_ToDate""].Value=null;");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mg_t2_todate (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MG_T2_ToDate-OnChange");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MFG_T2_ToDate"].Value< ISpace["MFG_T2_FromDate"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MFG_T2_ToDate""].Value< ISpace[""MFG_T2_FromDate""].Value)");
ISpace["Message"].Value=@"To Date should be greater than From Date";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""To Date should be greater than From Date"";");
ISpace["MFG_T2_ToDate"].Value=null;
base.WriteDebugInfo(@"ISpace[""MFG_T2_ToDate""].Value=null;");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mg_delete (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MG_Delete-OnClick");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["UI_DialogFund"].ShowDialog=true;;
base.WriteDebugInfo(@"ISpace[""UI_DialogFund""].ShowDialog=true;;");
ISpace["MF_FundDetailsId"].Value=ISpace["MG_FundDetailsID"].Value;
base.WriteDebugInfo(@"ISpace[""MF_FundDetailsId""].Value=ISpace[""MG_FundDetailsID""].Value;");
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mfg_t2_arrival (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MFG_T2_Arrival-OnChange");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MFG_T2_Departure"].Value==ISpace["MFG_T2_Arrival"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MFG_T2_Departure""].Value==ISpace[""MFG_T2_Arrival""].Value)");
ISpace["Message"].Value=@"Arrival Station and Departure Station can""t be same.";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Arrival Station and Departure Station can""""t be same."";");
ISpace["MFG_T2_Arrival"].Value=null;
base.WriteDebugInfo(@"ISpace[""MFG_T2_Arrival""].Value=null;");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_delete_travelexpense (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Delete_TravelExpense-OnClick");
ISpace["growid"].Value=ISpace["TravelExpense_RowId"].Value;
base.WriteDebugInfo(@"ISpace[""growid""].Value=ISpace[""TravelExpense_RowId""].Value;");
ISpace["UI_DialogTravel"].ShowDialog=true;;
base.WriteDebugInfo(@"ISpace[""UI_DialogTravel""].ShowDialog=true;;");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mf_fundtype (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MF_FundType-OnChange");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_FundType"].Value=="1")
{
base.WriteDebugInfo(@"if(ISpace[""MF_FundType""].Value==""1"")");
ISpace["MF_Amount"].Visible="true";ISpace["MF_Amount"].Man=true;ISpace["MF_BudgetHead"].Visible="true";ISpace["MF_BudgetHead"].Man=true;ISpace["MF_ProjectNo"].Visible="true";ISpace["MF_ProjectNo"].Man=true;
base.WriteDebugInfo(@"ISpace[""MF_Amount""].Visible=""true"";ISpace[""MF_Amount""].Man=true;ISpace[""MF_BudgetHead""].Visible=""true"";ISpace[""MF_BudgetHead""].Man=true;ISpace[""MF_ProjectNo""].Visible=""true"";ISpace[""MF_ProjectNo""].Man=true;");
ISpace["M_OpenModal"].Visible="true";
base.WriteDebugInfo(@"ISpace[""M_OpenModal""].Visible=""true"";");
ISpace["MF_BudgetHead"].rElemData=iSpace.Reload(ISpace["MF_BudgetHead"].Value,@"exec common..SP_GetDistrubitionDetails 6,'@" + ISpace["gv_ProcessMapId"].Value + @"'," + ISpace["MF_FundType"].Value + @",''," + ISpace["MF_T1_AdvanceAmount"].Value + @",'" + ISpace["UC_EmployeeBaicInfoId"].Value + @"','" + ISpace["R_ReferenceNo"].Value + @"'","9ADED37B-CD11-426B-AF16-DEAC75685EF5");
base.WriteDebugInfo(@"ISpace[""MF_BudgetHead""].rElemData=iSpace.Reload(ISpace[""MF_BudgetHead""].Value,@""exec common..SP_GetDistrubitionDetails 6,'@"" + ISpace[""gv_ProcessMapId""].Value + @""',"" + ISpace[""MF_FundType""].Value + @"",'',"" + ISpace[""MF_T1_AdvanceAmount""].Value + @"",'"" + ISpace[""UC_EmployeeBaicInfoId""].Value + @""','"" + ISpace[""R_ReferenceNo""].Value + @""'"",""9ADED37B-CD11-426B-AF16-DEAC75685EF5"");");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_Amount"].Visible="true";ISpace["MF_Amount"].Man=true;ISpace["MF_BudgetHead"].Visible="false";ISpace["MF_BudgetHead"].Man=false;ISpace["MF_ProjectNo"].Visible="false";ISpace["MF_ProjectNo"].Man=false;
base.WriteDebugInfo(@"ISpace[""MF_Amount""].Visible=""true"";ISpace[""MF_Amount""].Man=true;ISpace[""MF_BudgetHead""].Visible=""false"";ISpace[""MF_BudgetHead""].Man=false;ISpace[""MF_ProjectNo""].Visible=""false"";ISpace[""MF_ProjectNo""].Man=false;");
ISpace["M_OpenModal"].Visible="false";
base.WriteDebugInfo(@"ISpace[""M_OpenModal""].Visible=""false"";");
}
if(ISpace["MF_FundDetailsId"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""MF_FundDetailsId""].Value=="""")");
ISpace["MF_ProjectNo"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_ProjectNo""].Value=null;");
ISpace["MF_BudgetHead"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_BudgetHead""].Value=null;");
ISpace["MF_Amount"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_Amount""].Value=null;");
}
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mg_t3_amount (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MG_T3_Amount-OnChange");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
object MG_T3_Amount=iSpace.Sum("[7D2812B7-3A49-4DA7-9E48-082B26C3333C]","MG_T3_Amount","",ISpace["gv_instanceid"].Value);
ISpace["T_ExpenditureTotal"].Value=Convert.ChangeType(MG_T3_Amount, MG_T3_Amount.GetType());;
base.WriteDebugInfo(@"object MG_T3_Amount=iSpace.Sum(""[7D2812B7-3A49-4DA7-9E48-082B26C3333C]"",""MG_T3_Amount"","""",ISpace[""gv_instanceid""].Value);
ISpace[""T_ExpenditureTotal""].Value=Convert.ChangeType(MG_T3_Amount, MG_T3_Amount.GetType());;");
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mfg_t2_todate (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MFG_T2_ToDate-OnChange");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MFG_T2_ToDate"].Value< ISpace["MFG_T2_FromDate"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MFG_T2_ToDate""].Value< ISpace[""MFG_T2_FromDate""].Value)");
ISpace["Message"].Value=@"To Date should be greater than From Date";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""To Date should be greater than From Date"";");
ISpace["MFG_T2_ToDate"].Value=null;
base.WriteDebugInfo(@"ISpace[""MFG_T2_ToDate""].Value=null;");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_m_fundno (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"M_FundNo-OnClick");
ISpace["UI_DialogFund"].HideDialog=true;;
base.WriteDebugInfo(@"ISpace[""UI_DialogFund""].HideDialog=true;;");
ISpace["MF_FundDetailsId"].Value="";
base.WriteDebugInfo(@"ISpace[""MF_FundDetailsId""].Value="""";");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_delete_otherexpense (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Delete_OtherExpense-OnClick");
ISpace["growid"].Value=ISpace["OtherExpense_RowId"].Value;
base.WriteDebugInfo(@"ISpace[""growid""].Value=ISpace[""OtherExpense_RowId""].Value;");
ISpace["UI_DialogOther"].ShowDialog=true;;
base.WriteDebugInfo(@"ISpace[""UI_DialogOther""].ShowDialog=true;;");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_overall_total (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"OverAll_Total-OnChange");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"SELECT #OverAll_Total*0.9");

var querySourceB5136E55467F46BF9D46AE1BE798E3D4 =GetQueryExpressionDataSource("B5136E55-467F-46BF-9D46-AE1BE798E3D4");
Dictionary<short,object> resultB5136E55467F46BF9D46AE1BE798E3D4=iSpace.ExecuteQuery(querySourceB5136E55467F46BF9D46AE1BE798E3D4,@"SELECT " + ISpace["OverAll_Total"].Value + @"*0.9",false);

base.WriteDebugInfo(@"var querySourceB5136E55467F46BF9D46AE1BE798E3D4 =GetQueryExpressionDataSource(""B5136E55-467F-46BF-9D46-AE1BE798E3D4"");Dictionary<short,object> resultB5136E55467F46BF9D46AE1BE798E3D4=iSpace.ExecuteQuery(querySourceB5136E55467F46BF9D46AE1BE798E3D4,@""SELECT "" + ISpace[""OverAll_Total""].Value + @""*0.9"",false);");
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
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_FundType"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""MF_FundType""].Value=="""")");
ISpace["Message"].Value=@"Please enter Fund Type";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please enter Fund Type"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if(ISpace["MF_FundType"].Value=="1")
{
base.WriteDebugInfo(@"if(ISpace[""MF_FundType""].Value==""1"")");
if(ISpace["MF_ProjectNo"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""MF_ProjectNo""].Value=="""")");
ISpace["Message"].Value=@"Please enter Project No";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please enter Project No"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if(ISpace["MF_BudgetHead"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""MF_BudgetHead""].Value=="""")");
ISpace["Message"].Value=@"Please enter Budget Head";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please enter Budget Head"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
if(ISpace["MF_Amount"].Value==0)
{
base.WriteDebugInfo(@"if(ISpace[""MF_Amount""].Value==0)");
ISpace["Message"].Value=@"Please enter Amount";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please enter Amount"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
}
else
{
base.WriteDebugInfo(@"else");
if(ISpace["MF_Amount"].Value==0)
{
base.WriteDebugInfo(@"if(ISpace[""MF_Amount""].Value==0)");
ISpace["Message"].Value=@"Please enter Amount";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please enter Amount"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
}
if(ISpace["MF_T1_AdvanceAmount"].Value<0)
{
base.WriteDebugInfo(@"if(ISpace[""MF_T1_AdvanceAmount""].Value<0)");
base.WriteDebugInfo(@"exec GetSumOfTravelAmountbyHead 1,'#UC_EmployeeBaicInfoId','#R_ReferenceNo','#MF_ProjectNo','#MF_T1_AdvanceAmount','#MF_BudgetHead'");

var querySource997258b79a7846b960698bf404ec23ed =GetQueryExpressionDataSource("997258b7-9a78-46b9-6069-8bf404ec23ed");
Dictionary<short,object> result997258b79a7846b960698bf404ec23ed=iSpace.ExecuteQuery(querySource997258b79a7846b960698bf404ec23ed,@"execGetSumOfTravelAmountbyHead 1,'" + ISpace["UC_EmployeeBaicInfoId"].Value + @"','" + ISpace["R_ReferenceNo"].Value + @"','" + ISpace["MF_ProjectNo"].Value + @"','" + ISpace["MF_T1_AdvanceAmount"].Value + @"','" + ISpace["MF_BudgetHead"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource997258b79a7846b960698bf404ec23ed =GetQueryExpressionDataSource(""997258b7-9a78-46b9-6069-8bf404ec23ed"");Dictionary<short,object> result997258b79a7846b960698bf404ec23ed=iSpace.ExecuteQuery(querySource997258b79a7846b960698bf404ec23ed,@""execGetSumOfTravelAmountbyHead 1,'"" + ISpace[""UC_EmployeeBaicInfoId""].Value + @""','"" + ISpace[""R_ReferenceNo""].Value + @""','"" + ISpace[""MF_ProjectNo""].Value + @""','"" + ISpace[""MF_T1_AdvanceAmount""].Value + @""','"" + ISpace[""MF_BudgetHead""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result997258b79a7846b960698bf404ec23ed!=null) && (result997258b79a7846b960698bf404ec23ed.Count!=0))
{
if(result997258b79a7846b960698bf404ec23ed.ContainsKey(1))
ISpace["MF_SaveBudgetAmount"].Value = result997258b79a7846b960698bf404ec23ed[1];
if(result997258b79a7846b960698bf404ec23ed.ContainsKey(0))
ISpace["MF_SaveBudgetName"].Value = result997258b79a7846b960698bf404ec23ed[0];
}
else{
ISpace["MF_SaveBudgetAmount"].Value = null;ISpace["MF_SaveBudgetName"].Value = null;
}
if(ISpace["MF_Amount"].Value<ISpace["MF_SaveBudgetAmount"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MF_Amount""].Value<ISpace[""MF_SaveBudgetAmount""].Value)");
ISpace["Message"].Value=String.Format(@"Please enter valid {0} Amount",ISpace["MF_SaveBudgetName"].Value);
base.WriteDebugInfo(@"ISpace[""Message""].Value=String.Format(@""Please enter valid {0} Amount"",ISpace[""MF_SaveBudgetName""].Value);");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
}
if(ISpace["MF_FundType"].Value=="1")
{
base.WriteDebugInfo(@"if(ISpace[""MF_FundType""].Value==""1"")");
base.WriteDebugInfo(@"exec ValidatePaymentFundAvailability '#MF_FundType','#MF_ProjectNo','#MF_BudgetHead','#UC_EmployeeBaicInfoId','#MF_Amount',1,'#R_ReferenceNo'");

var querySource3F5245D269E448F894962B2EFB5417B0 =GetQueryExpressionDataSource("3F5245D2-69E4-48F8-9496-2B2EFB5417B0");
Dictionary<short,object> result3F5245D269E448F894962B2EFB5417B0=iSpace.ExecuteQuery(querySource3F5245D269E448F894962B2EFB5417B0,@"exec ValidatePaymentFundAvailability '" + ISpace["MF_FundType"].Value + @"','" + ISpace["MF_ProjectNo"].Value + @"','" + ISpace["MF_BudgetHead"].Value + @"','" + ISpace["UC_EmployeeBaicInfoId"].Value + @"','" + ISpace["MF_Amount"].Value + @"',1,'" + ISpace["R_ReferenceNo"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource3F5245D269E448F894962B2EFB5417B0 =GetQueryExpressionDataSource(""3F5245D2-69E4-48F8-9496-2B2EFB5417B0"");Dictionary<short,object> result3F5245D269E448F894962B2EFB5417B0=iSpace.ExecuteQuery(querySource3F5245D269E448F894962B2EFB5417B0,@""exec ValidatePaymentFundAvailability '"" + ISpace[""MF_FundType""].Value + @""','"" + ISpace[""MF_ProjectNo""].Value + @""','"" + ISpace[""MF_BudgetHead""].Value + @""','"" + ISpace[""UC_EmployeeBaicInfoId""].Value + @""','"" + ISpace[""MF_Amount""].Value + @""',1,'"" + ISpace[""R_ReferenceNo""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result3F5245D269E448F894962B2EFB5417B0!=null) && (result3F5245D269E448F894962B2EFB5417B0.Count!=0))
{
if(result3F5245D269E448F894962B2EFB5417B0.ContainsKey(0))
ISpace["M_BudgetErr"].Value = result3F5245D269E448F894962B2EFB5417B0[0];
if(result3F5245D269E448F894962B2EFB5417B0.ContainsKey(1))
ISpace["M_BudgetErrMsg"].Value = result3F5245D269E448F894962B2EFB5417B0[1];
}
else{
ISpace["M_BudgetErr"].Value = null;ISpace["M_BudgetErrMsg"].Value = null;
}
if(ISpace["M_BudgetErr"].Value==0)
{
base.WriteDebugInfo(@"if(ISpace[""M_BudgetErr""].Value==0)");
ISpace["Message"].Value=String.Format(@"{0}",ISpace["M_BudgetErrMsg"].Value);
base.WriteDebugInfo(@"ISpace[""Message""].Value=String.Format(@""{0}"",ISpace[""M_BudgetErrMsg""].Value);");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
}
if(ISpace["MF_FundDetailsId"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""MF_FundDetailsId""].Value=="""")");
ISpace["MF_FundDetailsId"].Value=Guid.NewGuid().ToString();
base.WriteDebugInfo(@"ISpace[""MF_FundDetailsId""].Value=Guid.NewGuid().ToString();");
}
}
base.WriteDebugInfo(@"EXEC TravelAdvanceFundDetails '#MF_ProjectNo','#M_TravelInstanceId','#M_IsTravelRequest','#MF_FundDetailsId','#MF_FundType','#R_ReferenceNo','#MF_BudgetHead','#MF_Amount'");

var querySourceCDE9634864D44000A9C351D8F7B31566 =GetQueryExpressionDataSource("CDE96348-64D4-4000-A9C3-51D8F7B31566");
Dictionary<short,object> resultCDE9634864D44000A9C351D8F7B31566=iSpace.ExecuteQuery(querySourceCDE9634864D44000A9C351D8F7B31566,@"EXEC TravelAdvanceFundDetails '" + ISpace["MF_ProjectNo"].Value + @"','" + ISpace["M_TravelInstanceId"].Value + @"','" + ISpace["M_IsTravelRequest"].Value + @"','" + ISpace["MF_FundDetailsId"].Value + @"','" + ISpace["MF_FundType"].Value + @"','" + ISpace["R_ReferenceNo"].Value + @"','" + ISpace["MF_BudgetHead"].Value + @"','" + ISpace["MF_Amount"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceCDE9634864D44000A9C351D8F7B31566 =GetQueryExpressionDataSource(""CDE96348-64D4-4000-A9C3-51D8F7B31566"");Dictionary<short,object> resultCDE9634864D44000A9C351D8F7B31566=iSpace.ExecuteQuery(querySourceCDE9634864D44000A9C351D8F7B31566,@""EXEC TravelAdvanceFundDetails '"" + ISpace[""MF_ProjectNo""].Value + @""','"" + ISpace[""M_TravelInstanceId""].Value + @""','"" + ISpace[""M_IsTravelRequest""].Value + @""','"" + ISpace[""MF_FundDetailsId""].Value + @""','"" + ISpace[""MF_FundType""].Value + @""','"" + ISpace[""R_ReferenceNo""].Value + @""','"" + ISpace[""MF_BudgetHead""].Value + @""','"" + ISpace[""MF_Amount""].Value + @""'"",false);");
ISpace["Message"].Value=@"Saved Successfully";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Saved Successfully"";");
base.WriteDebugInfo(@"");

if((resultCDE9634864D44000A9C351D8F7B31566!=null) && (resultCDE9634864D44000A9C351D8F7B31566.Count!=0))
{
}
else{

}

var querySource4F4B72E220D7416689F90192E1123361 =GetQueryExpressionDataSource("4F4B72E2-20D7-4166-89F9-0192E1123361");

DataTable result4F4B72E220D7416689F90192E1123361=iSpace.SetGridDataSource(querySource4F4B72E220D7416689F90192E1123361, _objectFactory.GetGridRPP("MF_FundAmount"),@"exec SP_GetTravelAdvanceFundDetails 4,'" + ISpace["R_ReferenceNo"].Value + @"','','" + ISpace["M_TravelInstanceId"].Value + @"'");

iSpace.InsertGridBindDetails("MF_FundAmount","11",querySource4F4B72E220D7416689F90192E1123361,"exec SP_GetTravelAdvanceFundDetails 4,'" + ISpace["R_ReferenceNo"].Value + @"','','" + ISpace["M_TravelInstanceId"].Value + @"'",_objectFactory.GetGridRPP("MF_FundAmount"));

base.WriteDebugInfo(@"var querySource4F4B72E220D7416689F90192E1123361 =GetQueryExpressionDataSource(""4F4B72E2-20D7-4166-89F9-0192E1123361"");DataTable result4F4B72E220D7416689F90192E1123361=iSpace.SetGridDataSource(querySource4F4B72E220D7416689F90192E1123361, _objectFactory.GetGridRPP(""MF_FundAmount""),@""exec SP_GetTravelAdvanceFundDetails 4,'"" + ISpace[""R_ReferenceNo""].Value + @""','','"" + ISpace[""M_TravelInstanceId""].Value + @""'"");iSpace.InsertGridBindDetails(""MF_FundAmount"",""11"",querySource4F4B72E220D7416689F90192E1123361,""exec SP_GetTravelAdvanceFundDetails 4,'"" + ISpace[""R_ReferenceNo""].Value + @""','','"" + ISpace[""M_TravelInstanceId""].Value + @""'"",_objectFactory.GetGridRPP(""MF_FundAmount""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result660A5B657E364792BC4AF2BBCA0468A9=acdataIspace0D9E568F8790489DA8463C6057A39268.GetQueryExpressionBindings("660A5B65-7E36-4792-BC4A-F2BBCA0468A9");
iSpace.SetGridData(result4F4B72E220D7416689F90192E1123361,result660A5B657E364792BC4AF2BBCA0468A9,"MF_FundAmount",ref ISpace);
iSpace.UpdateGridBindDetails("MF_FundAmount",result660A5B657E364792BC4AF2BBCA0468A9);
object MG_Amount=iSpace.Sum("[0BFAF73B-02D4-4680-B1C9-625AAFB02DB5]","MG_Amount","",ISpace["gv_instanceid"].Value);
ISpace["M_SumOfFund"].Value=Convert.ChangeType(MG_Amount, MG_Amount.GetType());;
base.WriteDebugInfo(@"object MG_Amount=iSpace.Sum(""[0BFAF73B-02D4-4680-B1C9-625AAFB02DB5]"",""MG_Amount"","""",ISpace[""gv_instanceid""].Value);
ISpace[""M_SumOfFund""].Value=Convert.ChangeType(MG_Amount, MG_Amount.GetType());;");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["MF_FundType"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_FundType""].Value=null;");
ISpace["M_BudgetErr"].Value=null;
base.WriteDebugInfo(@"ISpace[""M_BudgetErr""].Value=null;");
ISpace["MF_ProjectNo"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_ProjectNo""].Value=null;");
ISpace["MF_BudgetHead"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_BudgetHead""].Value=null;");
ISpace["M_BudgetErrMsg"].Value=null;
base.WriteDebugInfo(@"ISpace[""M_BudgetErrMsg""].Value=null;");
ISpace["MF_FundDetailsId"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_FundDetailsId""].Value=null;");
ISpace["MF_Amount"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_Amount""].Value=null;");
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_m_isadvancerequired (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"M_IsAdvanceRequired-OnChange");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["M_IsAdvanceRequired"].Value=="Yes")
{
base.WriteDebugInfo(@"if(ISpace[""M_IsAdvanceRequired""].Value==""Yes"")");
ISpace["T_AdvanceDrawn"].Visible="true";
base.WriteDebugInfo(@"ISpace[""T_AdvanceDrawn""].Visible=""true"";");

}
else
{
base.WriteDebugInfo(@"else");
ISpace["T_AdvanceDrawn"].Visible="false";
base.WriteDebugInfo(@"ISpace[""T_AdvanceDrawn""].Visible=""false"";");

}
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_travel_type (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Travel_Type-OnChange");
if(ISpace["Travel_Type"].Value=="1")
{
base.WriteDebugInfo(@"if(ISpace[""Travel_Type""].Value==""1"")");
ISpace["MF_T1_BeneficiaryName"].Man=false;ISpace["MF_T1_AccountNo"].Man=false;ISpace["MF_T1_BankName"].Man=false;ISpace["MF_T1_BankBranch"].Man=false;ISpace["MF_T1_BankDocument"].Man=false;
base.WriteDebugInfo(@"ISpace[""MF_T1_BeneficiaryName""].Man=false;ISpace[""MF_T1_AccountNo""].Man=false;ISpace[""MF_T1_BankName""].Man=false;ISpace[""MF_T1_BankBranch""].Man=false;ISpace[""MF_T1_BankDocument""].Man=false;");
}
if(ISpace["Travel_Type"].Value=="3")
{
base.WriteDebugInfo(@"if(ISpace[""Travel_Type""].Value==""3"")");
ISpace["MF_T1_BeneficiaryName"].Man=true;ISpace["MF_T1_BeneficiaryName"].Enbl="true";ISpace["MF_T1_AccountNo"].Man=true;ISpace["MF_T1_AccountNo"].Enbl="true";ISpace["MF_T1_AdvanceAmount"].Man=true;ISpace["MF_T1_AdvanceAmount"].Enbl="true";ISpace["MF_T1_BankName"].Man=true;ISpace["MF_T1_BankName"].Enbl="true";ISpace["MF_T1_BankBranch"].Man=true;ISpace["MF_T1_BankBranch"].Enbl="true";ISpace["MF_T1_BankDocument"].Man=true;ISpace["MF_T1_BankDocument"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_T1_BeneficiaryName""].Man=true;ISpace[""MF_T1_BeneficiaryName""].Enbl=""true"";ISpace[""MF_T1_AccountNo""].Man=true;ISpace[""MF_T1_AccountNo""].Enbl=""true"";ISpace[""MF_T1_AdvanceAmount""].Man=true;ISpace[""MF_T1_AdvanceAmount""].Enbl=""true"";ISpace[""MF_T1_BankName""].Man=true;ISpace[""MF_T1_BankName""].Enbl=""true"";ISpace[""MF_T1_BankBranch""].Man=true;ISpace[""MF_T1_BankBranch""].Enbl=""true"";ISpace[""MF_T1_BankDocument""].Man=true;ISpace[""MF_T1_BankDocument""].Enbl=""true"";");
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
		if(elementName.ToLower().Equals("advanceamount"))
    {
    			SubscribeElementEvents_advanceamount(ref dfsParam);
    }
		if(elementName.ToLower().Equals("c_fc_projectno_33"))
    {
    			SubscribeElementEvents_c_fc_projectno_33(ref dfsParam);
    }
		if(elementName.ToLower().Equals("t_expendituretotal"))
    {
    			SubscribeElementEvents_t_expendituretotal(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mfg_t2_expendituretypeid"))
    {
    			SubscribeElementEvents_mfg_t2_expendituretypeid(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mfg_t2_arrivaldate"))
    {
    			SubscribeElementEvents_mfg_t2_arrivaldate(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mfg_t2_modeofjourney"))
    {
    			SubscribeElementEvents_mfg_t2_modeofjourney(ref dfsParam);
    }
		if(elementName.ToLower().Equals("r_referenceno"))
    {
    			SubscribeElementEvents_r_referenceno(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mfg_t2_departuredate"))
    {
    			SubscribeElementEvents_mfg_t2_departuredate(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mfg_t2_departure"))
    {
    			SubscribeElementEvents_mfg_t2_departure(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mg_t2_amount"))
    {
    			SubscribeElementEvents_mg_t2_amount(ref dfsParam);
    }
		if(elementName.ToLower().Equals("t_traveladvancetotal"))
    {
    			SubscribeElementEvents_t_traveladvancetotal(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mf_t1_budgethead"))
    {
    			SubscribeElementEvents_mf_t1_budgethead(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mfg_t2_fromdate"))
    {
    			SubscribeElementEvents_mfg_t2_fromdate(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mg_t2_fromdate"))
    {
    			SubscribeElementEvents_mg_t2_fromdate(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mg_t2_todate"))
    {
    			SubscribeElementEvents_mg_t2_todate(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mfg_t2_arrival"))
    {
    			SubscribeElementEvents_mfg_t2_arrival(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mf_fundtype"))
    {
    			SubscribeElementEvents_mf_fundtype(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mg_t3_amount"))
    {
    			SubscribeElementEvents_mg_t3_amount(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mfg_t2_todate"))
    {
    			SubscribeElementEvents_mfg_t2_todate(ref dfsParam);
    }
		if(elementName.ToLower().Equals("overall_total"))
    {
    			SubscribeElementEvents_overall_total(ref dfsParam);
    }
		if(elementName.ToLower().Equals("m_isadvancerequired"))
    {
    			SubscribeElementEvents_m_isadvancerequired(ref dfsParam);
    }
		if(elementName.ToLower().Equals("travel_type"))
    {
    			SubscribeElementEvents_travel_type(ref dfsParam);
    }
}
	if(methodName.ToLower().Equals("onclick"))
{
		if(elementName.ToLower().Equals("m_otherno"))
{
			SubscribeElementEvents_m_otherno(ref dfsParam);
}
		if(elementName.ToLower().Equals("submitform"))
{
			SubscribeElementEvents_submitform(ref dfsParam);
}
		if(elementName.ToLower().Equals("m_openmodal"))
{
			SubscribeElementEvents_m_openmodal(ref dfsParam);
}
		if(elementName.ToLower().Equals("m_travelyes"))
{
			SubscribeElementEvents_m_travelyes(ref dfsParam);
}
		if(elementName.ToLower().Equals("edit_travelexpense"))
{
			SubscribeElementEvents_edit_travelexpense(ref dfsParam);
}
		if(elementName.ToLower().Equals("edit_otherexpense"))
{
			SubscribeElementEvents_edit_otherexpense(ref dfsParam);
}
		if(elementName.ToLower().Equals("save_travelexpense"))
{
			SubscribeElementEvents_save_travelexpense(ref dfsParam);
}
		if(elementName.ToLower().Equals("save_otherexpense"))
{
			SubscribeElementEvents_save_otherexpense(ref dfsParam);
}
		if(elementName.ToLower().Equals("m_fundyes"))
{
			SubscribeElementEvents_m_fundyes(ref dfsParam);
}
		if(elementName.ToLower().Equals("m_travelno"))
{
			SubscribeElementEvents_m_travelno(ref dfsParam);
}
		if(elementName.ToLower().Equals("m_otheryes"))
{
			SubscribeElementEvents_m_otheryes(ref dfsParam);
}
		if(elementName.ToLower().Equals("mg_edit"))
{
			SubscribeElementEvents_mg_edit(ref dfsParam);
}
		if(elementName.ToLower().Equals("mg_delete"))
{
			SubscribeElementEvents_mg_delete(ref dfsParam);
}
		if(elementName.ToLower().Equals("delete_travelexpense"))
{
			SubscribeElementEvents_delete_travelexpense(ref dfsParam);
}
		if(elementName.ToLower().Equals("m_fundno"))
{
			SubscribeElementEvents_m_fundno(ref dfsParam);
}
		if(elementName.ToLower().Equals("delete_otherexpense"))
{
			SubscribeElementEvents_delete_otherexpense(ref dfsParam);
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

using System.Collections.Generic;
using System;
using CPS.Proof.DFSExtension;
using System.Linq;using System.Data;
using System.Runtime.CompilerServices;
public class ISpaceF4BD3F24901C43AB86074D7817A2621C : VirtualForm
{
IISpace iSpace = new ISpace();
AcDataISpaceF4BD3F24901C43AB86074D7817A2621C acdataIspaceF4BD3F24901C43AB86074D7817A2621C=new AcDataISpaceF4BD3F24901C43AB86074D7817A2621C();
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
ISpace["M_RandDTransactionDate"].Man=true;ISpace["M_RandDTransactionNo"].Man=true;
base.WriteDebugInfo(@"ISpace[""M_RandDTransactionDate""].Man=true;ISpace[""M_RandDTransactionNo""].Man=true;");
ISpace["UC_PhoneNumber"].Visible="false";ISpace["UC_Grade"].Visible="false";ISpace["UC_Paylevel"].Visible="false";ISpace["UC_DOR"].Visible="false";ISpace["UC_DOJ"].Visible="false";ISpace["UC_EmailId"].Visible="false";ISpace["UC_DOB"].Visible="false";
base.WriteDebugInfo(@"ISpace[""UC_PhoneNumber""].Visible=""false"";ISpace[""UC_Grade""].Visible=""false"";ISpace[""UC_Paylevel""].Visible=""false"";ISpace[""UC_DOR""].Visible=""false"";ISpace[""UC_DOJ""].Visible=""false"";ISpace[""UC_EmailId""].Visible=""false"";ISpace[""UC_DOB""].Visible=""false"";");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySource800FCB85CC5F45509D3F5D7AE4650DF2 =GetQueryExpressionDataSource("800FCB85-CC5F-4550-9D3F-5D7AE4650DF2");

DataTable result800FCB85CC5F45509D3F5D7AE4650DF2=iSpace.SetGridDataSource(querySource800FCB85CC5F45509D3F5D7AE4650DF2, _objectFactory.GetGridRPP("MG_RemarksDetails"),@"EXEC GetRemarks '" + ISpace["M_InstanceId"].Value + @"'");

iSpace.InsertGridBindDetails("MG_RemarksDetails","11",querySource800FCB85CC5F45509D3F5D7AE4650DF2,"EXEC GetRemarks '" + ISpace["M_InstanceId"].Value + @"'",_objectFactory.GetGridRPP("MG_RemarksDetails"));

base.WriteDebugInfo(@"var querySource800FCB85CC5F45509D3F5D7AE4650DF2 =GetQueryExpressionDataSource(""800FCB85-CC5F-4550-9D3F-5D7AE4650DF2"");DataTable result800FCB85CC5F45509D3F5D7AE4650DF2=iSpace.SetGridDataSource(querySource800FCB85CC5F45509D3F5D7AE4650DF2, _objectFactory.GetGridRPP(""MG_RemarksDetails""),@""EXEC GetRemarks '"" + ISpace[""M_InstanceId""].Value + @""'"");iSpace.InsertGridBindDetails(""MG_RemarksDetails"",""11"",querySource800FCB85CC5F45509D3F5D7AE4650DF2,""EXEC GetRemarks '"" + ISpace[""M_InstanceId""].Value + @""'"",_objectFactory.GetGridRPP(""MG_RemarksDetails""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> resultF6CCD46BA27D469EB390A56BFBF805A6=acdataIspaceF4BD3F24901C43AB86074D7817A2621C.GetQueryExpressionBindings("F6CCD46B-A27D-469E-B390-A56BFBF805A6");
iSpace.SetGridData(result800FCB85CC5F45509D3F5D7AE4650DF2,resultF6CCD46BA27D469EB390A56BFBF805A6,"MG_RemarksDetails",ref ISpace);
iSpace.UpdateGridBindDetails("MG_RemarksDetails",resultF6CCD46BA27D469EB390A56BFBF805A6);
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["MF_T1_BeneficiaryName"].Visible="true";ISpace["MF_T1_TravelType"].Visible="true";ISpace["MF_T1_ReferenceNo"].Visible="true";ISpace["MF_T1_Destination"].Visible="true";ISpace["MF_T1_AvailableBudget"].Visible="true";ISpace["MFG_T2_ExpenditureTypeID"].Visible="true";ISpace["MF_T1_AccountNo"].Visible="true";ISpace["MF_T1_TravellingPerson"].Visible="true";ISpace["MFG_T2_ArrivalDate"].Visible="true";ISpace["MFG_T2_ModeofJourney"].Visible="true";ISpace["MF_T1_JourneyPurpose"].Visible="true";ISpace["MFG_T2_Road"].Visible="true";ISpace["MFG_T2_ArrivalTime"].Visible="true";ISpace["MF_T1_ProjectNo"].Visible="true";ISpace["MF_T1_AdvanceAmount"].Visible="true";ISpace["MF_T1_TravelAdvanceID"].Visible="false";ISpace["MF_T1_BankName"].Visible="true";ISpace["MF_T1_BankBranch"].Visible="true";ISpace["MFG_T2_DepartureDate"].Visible="true";ISpace["MFG_T2_Departure"].Visible="true";ISpace["MFG_T2_PNRNo"].Visible="true";ISpace["MFG_T2_Amount"].Visible="true";ISpace["MFG_T3_TravelAdvanceID"].Visible="false";ISpace["MFG_T2_TravelAdvanceID"].Visible="false";ISpace["MF_T1_BankDocument"].Visible="true";ISpace["MFG_T2_JourneyClass"].Visible="true";ISpace["MF_T1_BudgetHead"].Visible="true";ISpace["MFG_T2_DepartureTime"].Visible="true";ISpace["MFG_T2_FromDate"].Visible="true";ISpace["MFG_T2_Arrival"].Visible="true";ISpace["MFG_T2_ToDate"].Visible="true";ISpace["MFG_T3_Amount"].Visible="true";ISpace["MFG_T2_TADetailsID"].Visible="false";
base.WriteDebugInfo(@"ISpace[""MF_T1_BeneficiaryName""].Visible=""true"";ISpace[""MF_T1_TravelType""].Visible=""true"";ISpace[""MF_T1_ReferenceNo""].Visible=""true"";ISpace[""MF_T1_Destination""].Visible=""true"";ISpace[""MF_T1_AvailableBudget""].Visible=""true"";ISpace[""MFG_T2_ExpenditureTypeID""].Visible=""true"";ISpace[""MF_T1_AccountNo""].Visible=""true"";ISpace[""MF_T1_TravellingPerson""].Visible=""true"";ISpace[""MFG_T2_ArrivalDate""].Visible=""true"";ISpace[""MFG_T2_ModeofJourney""].Visible=""true"";ISpace[""MF_T1_JourneyPurpose""].Visible=""true"";ISpace[""MFG_T2_Road""].Visible=""true"";ISpace[""MFG_T2_ArrivalTime""].Visible=""true"";ISpace[""MF_T1_ProjectNo""].Visible=""true"";ISpace[""MF_T1_AdvanceAmount""].Visible=""true"";ISpace[""MF_T1_TravelAdvanceID""].Visible=""false"";ISpace[""MF_T1_BankName""].Visible=""true"";ISpace[""MF_T1_BankBranch""].Visible=""true"";ISpace[""MFG_T2_DepartureDate""].Visible=""true"";ISpace[""MFG_T2_Departure""].Visible=""true"";ISpace[""MFG_T2_PNRNo""].Visible=""true"";ISpace[""MFG_T2_Amount""].Visible=""true"";ISpace[""MFG_T3_TravelAdvanceID""].Visible=""false"";ISpace[""MFG_T2_TravelAdvanceID""].Visible=""false"";ISpace[""MF_T1_BankDocument""].Visible=""true"";ISpace[""MFG_T2_JourneyClass""].Visible=""true"";ISpace[""MF_T1_BudgetHead""].Visible=""true"";ISpace[""MFG_T2_DepartureTime""].Visible=""true"";ISpace[""MFG_T2_FromDate""].Visible=""true"";ISpace[""MFG_T2_Arrival""].Visible=""true"";ISpace[""MFG_T2_ToDate""].Visible=""true"";ISpace[""MFG_T3_Amount""].Visible=""true"";ISpace[""MFG_T2_TADetailsID""].Visible=""false"";");
ISpace["MG_T3_TravelAdvanceID"].Visible="false";ISpace["MG_T2_ModeofJourney"].Visible="true";ISpace["MG_T2_JourneyClass"].Visible="true";ISpace["MG_T2_Departure"].Visible="true";ISpace["MG_T2_TADetailsID"].Visible="false";ISpace["MG_T2_Amount"].Visible="true";ISpace["MG_T2_DepartureTime"].Visible="true";ISpace["MG_T2_ArrivalTime"].Visible="true";ISpace["MG_T2_Road"].Visible="true";ISpace["MG_T2_DepartureDate"].Visible="true";ISpace["MG_T2_Arrival"].Visible="true";ISpace["MG_T2_ArrivalDate"].Visible="true";ISpace["MG_T2_PNRNo"].Visible="true";
base.WriteDebugInfo(@"ISpace[""MG_T3_TravelAdvanceID""].Visible=""false"";ISpace[""MG_T2_ModeofJourney""].Visible=""true"";ISpace[""MG_T2_JourneyClass""].Visible=""true"";ISpace[""MG_T2_Departure""].Visible=""true"";ISpace[""MG_T2_TADetailsID""].Visible=""false"";ISpace[""MG_T2_Amount""].Visible=""true"";ISpace[""MG_T2_DepartureTime""].Visible=""true"";ISpace[""MG_T2_ArrivalTime""].Visible=""true"";ISpace[""MG_T2_Road""].Visible=""true"";ISpace[""MG_T2_DepartureDate""].Visible=""true"";ISpace[""MG_T2_Arrival""].Visible=""true"";ISpace[""MG_T2_ArrivalDate""].Visible=""true"";ISpace[""MG_T2_PNRNo""].Visible=""true"";");
ISpace["MG_T2_ExpenditureTypeID"].Visible="true";ISpace["MG_T2_FromDate"].Visible="true";ISpace["MG_T2_ToDate"].Visible="true";ISpace["MG_T3_Amount"].Visible="true";ISpace["MG_T2_TravelAdvanceID"].Visible="false";
base.WriteDebugInfo(@"ISpace[""MG_T2_ExpenditureTypeID""].Visible=""true"";ISpace[""MG_T2_FromDate""].Visible=""true"";ISpace[""MG_T2_ToDate""].Visible=""true"";ISpace[""MG_T3_Amount""].Visible=""true"";ISpace[""MG_T2_TravelAdvanceID""].Visible=""false"";");
}
if(ISpace["Travel_Type"].Value=="1")
{
base.WriteDebugInfo(@"if(ISpace[""Travel_Type""].Value==""1"")");
ISpace["MF_T1_BeneficiaryName"].Man=false;ISpace["MF_T1_AccountNo"].Man=false;ISpace["MF_T1_BankName"].Man=false;ISpace["MF_T1_BankBranch"].Man=false;ISpace["MF_T1_BankDocument"].Man=false;
base.WriteDebugInfo(@"ISpace[""MF_T1_BeneficiaryName""].Man=false;ISpace[""MF_T1_AccountNo""].Man=false;ISpace[""MF_T1_BankName""].Man=false;ISpace[""MF_T1_BankBranch""].Man=false;ISpace[""MF_T1_BankDocument""].Man=false;");
}
if(ISpace["Travel_Type"].Value=="3")
{
base.WriteDebugInfo(@"if(ISpace[""Travel_Type""].Value==""3"")");
ISpace["MF_T1_BeneficiaryName"].Man=true;ISpace["MF_T1_BeneficiaryName"].Enbl="true";ISpace["MF_T1_AccountNo"].Man=true;ISpace["MF_T1_AccountNo"].Enbl="true";ISpace["MF_T1_AdvanceAmount"].Man=true;ISpace["MF_T1_AdvanceAmount"].Enbl="true";ISpace["MF_T1_BankName"].Man=true;ISpace["MF_T1_BankName"].Enbl="true";ISpace["MF_T1_BankBranch"].Man=true;ISpace["MF_T1_BankBranch"].Enbl="true";ISpace["MF_T1_BankDocument"].Man=true;ISpace["MF_T1_BankDocument"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_T1_BeneficiaryName""].Man=true;ISpace[""MF_T1_BeneficiaryName""].Enbl=""true"";ISpace[""MF_T1_AccountNo""].Man=true;ISpace[""MF_T1_AccountNo""].Enbl=""true"";ISpace[""MF_T1_AdvanceAmount""].Man=true;ISpace[""MF_T1_AdvanceAmount""].Enbl=""true"";ISpace[""MF_T1_BankName""].Man=true;ISpace[""MF_T1_BankName""].Enbl=""true"";ISpace[""MF_T1_BankBranch""].Man=true;ISpace[""MF_T1_BankBranch""].Enbl=""true"";ISpace[""MF_T1_BankDocument""].Man=true;ISpace[""MF_T1_BankDocument""].Enbl=""true"";");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["M_IsAdvanceRequired"].Value=="Yes")
{
base.WriteDebugInfo(@"if(ISpace[""M_IsAdvanceRequired""].Value==""Yes"")");
ISpace["T_AdvanceDrawn"].Visible="true";
base.WriteDebugInfo(@"ISpace[""T_AdvanceDrawn""].Visible=""true"";");

}
else
{
base.WriteDebugInfo(@"else");
ISpace["T_AdvanceDrawn"].Visible="false";
base.WriteDebugInfo(@"ISpace[""T_AdvanceDrawn""].Visible=""false"";");

}
}
ISpace["M_IsAdvanceRequired"].Enbl="false";ISpace["Travel_Type"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""M_IsAdvanceRequired""].Enbl=""false"";ISpace[""Travel_Type""].Enbl=""false"";");
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
ISpace["Message"].Value=@"Move To should be mandatory";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Move To should be mandatory"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
ISpace["MF_TravelStatus"].Value="A";
base.WriteDebugInfo(@"ISpace[""MF_TravelStatus""].Value=""A"";");
ISpace["M_IsCommitment"].Value=0;
base.WriteDebugInfo(@"ISpace[""M_IsCommitment""].Value=0;");
if(ISpace["M_SaveDomainData"].Value==0&&ISpace["M_IsflowReturned"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""M_SaveDomainData""].Value==0&&ISpace[""M_IsflowReturned""].Value==1)");
base.WriteDebugInfo(@"exec [SendReturnEmailForTS] '#MF_T1_TravelAdvanceID'");

var querySource7a376b7ecb572943c84b3046179e2a17 =GetQueryExpressionDataSource("7a376b7e-cb57-2943-c84b-3046179e2a17");
Dictionary<short,object> result7a376b7ecb572943c84b3046179e2a17=iSpace.ExecuteQuery(querySource7a376b7ecb572943c84b3046179e2a17,@"exec [SendReturnEmailForTS] '" + ISpace["MF_T1_TravelAdvanceID"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource7a376b7ecb572943c84b3046179e2a17 =GetQueryExpressionDataSource(""7a376b7e-cb57-2943-c84b-3046179e2a17"");Dictionary<short,object> result7a376b7ecb572943c84b3046179e2a17=iSpace.ExecuteQuery(querySource7a376b7ecb572943c84b3046179e2a17,@""exec [SendReturnEmailForTS] '"" + ISpace[""MF_T1_TravelAdvanceID""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result7a376b7ecb572943c84b3046179e2a17!=null) && (result7a376b7ecb572943c84b3046179e2a17.Count!=0))
{
if(result7a376b7ecb572943c84b3046179e2a17.ContainsKey(0))
ISpace["A"].Value = result7a376b7ecb572943c84b3046179e2a17[0];
}
else{
ISpace["A"].Value = null;
}
}
if(ISpace["M_SaveDomainData"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""M_SaveDomainData""].Value==1)");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC Repo198E5A8A61F54E7C92DD34146A7059EF '#M_ActualTransactionDate','#M_ActualTransactionDate','#R_ReferenceNo','#M_RandDTransactionNo','#OverAll_Total','#MF_TravelStatus','#M_ActualTransactionNo'");

var querySource451B4D6A015745DE996B9B03FB97D453 =GetQueryExpressionDataSource("451B4D6A-0157-45DE-996B-9B03FB97D453");
Dictionary<short,object> result451B4D6A015745DE996B9B03FB97D453=iSpace.ExecuteQuery(querySource451B4D6A015745DE996B9B03FB97D453,@"EXEC Repo198E5A8A61F54E7C92DD34146A7059EF '" + ISpace["M_ActualTransactionDate"].Value + @"','" + ISpace["M_ActualTransactionDate"].Value + @"','" + ISpace["R_ReferenceNo"].Value + @"','" + ISpace["M_RandDTransactionNo"].Value + @"','" + ISpace["OverAll_Total"].Value + @"','" + ISpace["MF_TravelStatus"].Value + @"','" + ISpace["M_ActualTransactionNo"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource451B4D6A015745DE996B9B03FB97D453 =GetQueryExpressionDataSource(""451B4D6A-0157-45DE-996B-9B03FB97D453"");Dictionary<short,object> result451B4D6A015745DE996B9B03FB97D453=iSpace.ExecuteQuery(querySource451B4D6A015745DE996B9B03FB97D453,@""EXEC Repo198E5A8A61F54E7C92DD34146A7059EF '"" + ISpace[""M_ActualTransactionDate""].Value + @""','"" + ISpace[""M_ActualTransactionDate""].Value + @""','"" + ISpace[""R_ReferenceNo""].Value + @""','"" + ISpace[""M_RandDTransactionNo""].Value + @""','"" + ISpace[""OverAll_Total""].Value + @""','"" + ISpace[""MF_TravelStatus""].Value + @""','"" + ISpace[""M_ActualTransactionNo""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result451B4D6A015745DE996B9B03FB97D453!=null) && (result451B4D6A015745DE996B9B03FB97D453.Count!=0))
{
}
else{

}
base.WriteDebugInfo(@"EXEC Repo374fb8a88dd94cf1bf73f40ae18fcad7 '#M_IsTravelRequest','#UpdatedOn','#MG_T2_TADetailsID','#gv_UserId','#MG_T2_DepartureDate','#MG_T2_DepartureTime','#MG_T2_ArrivalDate','#MG_T2_Road','#R_ReferenceNo','#MG_T2_Departure','#MG_T2_Amount','#MG_T2_JourneyClass','#MG_T2_Arrival','#MG_T2_PNRNo','#MG_T2_ModeofJourney','#MG_T2_ArrivalTime'");

var querySourceCA31643F8CD646EF9214A9D08E22313D =GetQueryExpressionDataSource("CA31643F-8CD6-46EF-9214-A9D08E22313D");
Dictionary<short,object> resultCA31643F8CD646EF9214A9D08E22313D=iSpace.ExecuteQuery(querySourceCA31643F8CD646EF9214A9D08E22313D,@"EXEC Repo374fb8a88dd94cf1bf73f40ae18fcad7 '" + ISpace["M_IsTravelRequest"].Value + @"','" + ISpace["UpdatedOn"].Value + @"','" + ISpace["MG_T2_TADetailsID"].Value + @"','" + ISpace["gv_UserId"].Value + @"','" + ISpace["MG_T2_DepartureDate"].Value + @"','" + ISpace["MG_T2_DepartureTime"].Value + @"','" + ISpace["MG_T2_ArrivalDate"].Value + @"','" + ISpace["MG_T2_Road"].Value + @"','" + ISpace["R_ReferenceNo"].Value + @"','" + ISpace["MG_T2_Departure"].Value + @"','" + ISpace["MG_T2_Amount"].Value + @"','" + ISpace["MG_T2_JourneyClass"].Value + @"','" + ISpace["MG_T2_Arrival"].Value + @"','" + ISpace["MG_T2_PNRNo"].Value + @"','" + ISpace["MG_T2_ModeofJourney"].Value + @"','" + ISpace["MG_T2_ArrivalTime"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceCA31643F8CD646EF9214A9D08E22313D =GetQueryExpressionDataSource(""CA31643F-8CD6-46EF-9214-A9D08E22313D"");Dictionary<short,object> resultCA31643F8CD646EF9214A9D08E22313D=iSpace.ExecuteQuery(querySourceCA31643F8CD646EF9214A9D08E22313D,@""EXEC Repo374fb8a88dd94cf1bf73f40ae18fcad7 '"" + ISpace[""M_IsTravelRequest""].Value + @""','"" + ISpace[""UpdatedOn""].Value + @""','"" + ISpace[""MG_T2_TADetailsID""].Value + @""','"" + ISpace[""gv_UserId""].Value + @""','"" + ISpace[""MG_T2_DepartureDate""].Value + @""','"" + ISpace[""MG_T2_DepartureTime""].Value + @""','"" + ISpace[""MG_T2_ArrivalDate""].Value + @""','"" + ISpace[""MG_T2_Road""].Value + @""','"" + ISpace[""R_ReferenceNo""].Value + @""','"" + ISpace[""MG_T2_Departure""].Value + @""','"" + ISpace[""MG_T2_Amount""].Value + @""','"" + ISpace[""MG_T2_JourneyClass""].Value + @""','"" + ISpace[""MG_T2_Arrival""].Value + @""','"" + ISpace[""MG_T2_PNRNo""].Value + @""','"" + ISpace[""MG_T2_ModeofJourney""].Value + @""','"" + ISpace[""MG_T2_ArrivalTime""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultCA31643F8CD646EF9214A9D08E22313D!=null) && (resultCA31643F8CD646EF9214A9D08E22313D.Count!=0))
{
}
else{

}
base.WriteDebugInfo(@"EXEC Repo51838b372ec64d358a5e38648bc93ab1 '#gv_UserId','#UpdatedOn','#R_ReferenceNo','#M_MiscDetails','#MG_T2_ToDate','#MG_T2_FromDate','#M_IsTravelRequest','#MG_T2_ExpenditureTypeID','#Expenditure_Type','#MG_T3_Amount'");

var querySourceD707F6E5B3364B14BB90DCBE65B38460 =GetQueryExpressionDataSource("D707F6E5-B336-4B14-BB90-DCBE65B38460");
Dictionary<short,object> resultD707F6E5B3364B14BB90DCBE65B38460=iSpace.ExecuteQuery(querySourceD707F6E5B3364B14BB90DCBE65B38460,@"EXEC Repo51838b372ec64d358a5e38648bc93ab1 '" + ISpace["gv_UserId"].Value + @"','" + ISpace["UpdatedOn"].Value + @"','" + ISpace["R_ReferenceNo"].Value + @"','" + ISpace["M_MiscDetails"].Value + @"','" + ISpace["MG_T2_ToDate"].Value + @"','" + ISpace["MG_T2_FromDate"].Value + @"','" + ISpace["M_IsTravelRequest"].Value + @"','" + ISpace["MG_T2_ExpenditureTypeID"].Value + @"','" + ISpace["Expenditure_Type"].Value + @"','" + ISpace["MG_T3_Amount"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceD707F6E5B3364B14BB90DCBE65B38460 =GetQueryExpressionDataSource(""D707F6E5-B336-4B14-BB90-DCBE65B38460"");Dictionary<short,object> resultD707F6E5B3364B14BB90DCBE65B38460=iSpace.ExecuteQuery(querySourceD707F6E5B3364B14BB90DCBE65B38460,@""EXEC Repo51838b372ec64d358a5e38648bc93ab1 '"" + ISpace[""gv_UserId""].Value + @""','"" + ISpace[""UpdatedOn""].Value + @""','"" + ISpace[""R_ReferenceNo""].Value + @""','"" + ISpace[""M_MiscDetails""].Value + @""','"" + ISpace[""MG_T2_ToDate""].Value + @""','"" + ISpace[""MG_T2_FromDate""].Value + @""','"" + ISpace[""M_IsTravelRequest""].Value + @""','"" + ISpace[""MG_T2_ExpenditureTypeID""].Value + @""','"" + ISpace[""Expenditure_Type""].Value + @""','"" + ISpace[""MG_T3_Amount""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultD707F6E5B3364B14BB90DCBE65B38460!=null) && (resultD707F6E5B3364B14BB90DCBE65B38460.Count!=0))
{
}
else{

}
base.WriteDebugInfo(@"EXEC DocumentsDomain '#M_DocumentDetailsId','#M_PackageProcessMapId','#UpdatedOn','#M_DocumentName','#gv_UserId','#M_UploadDcoument','#R_ReferenceNo'");

var querySource935F2074D9D84E08A4795C1D1110C173 =GetQueryExpressionDataSource("935F2074-D9D8-4E08-A479-5C1D1110C173");
Dictionary<short,object> result935F2074D9D84E08A4795C1D1110C173=iSpace.ExecuteQuery(querySource935F2074D9D84E08A4795C1D1110C173,@"EXEC DocumentsDomain '" + ISpace["M_DocumentDetailsId"].Value + @"','" + ISpace["M_PackageProcessMapId"].Value + @"','" + ISpace["UpdatedOn"].Value + @"','" + ISpace["M_DocumentName"].Value + @"','" + ISpace["gv_UserId"].Value + @"','" + ISpace["M_UploadDcoument"].Value + @"','" + ISpace["R_ReferenceNo"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource935F2074D9D84E08A4795C1D1110C173 =GetQueryExpressionDataSource(""935F2074-D9D8-4E08-A479-5C1D1110C173"");Dictionary<short,object> result935F2074D9D84E08A4795C1D1110C173=iSpace.ExecuteQuery(querySource935F2074D9D84E08A4795C1D1110C173,@""EXEC DocumentsDomain '"" + ISpace[""M_DocumentDetailsId""].Value + @""','"" + ISpace[""M_PackageProcessMapId""].Value + @""','"" + ISpace[""UpdatedOn""].Value + @""','"" + ISpace[""M_DocumentName""].Value + @""','"" + ISpace[""gv_UserId""].Value + @""','"" + ISpace[""M_UploadDcoument""].Value + @""','"" + ISpace[""R_ReferenceNo""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result935F2074D9D84E08A4795C1D1110C173!=null) && (result935F2074D9D84E08A4795C1D1110C173.Count!=0))
{
}
else{

}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"#MF_FundAmount[Rows]");
iSpace.GetLoopExpressionData("MF_FundAmount",ref ISpace);

foreach(var gridChild in ISpace["MF_FundAmount"].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 


if(
ISpace["MF_T1_AdvanceAmount"].Value<0)
{
base.WriteDebugInfo(@"
if(
ISpace[""MF_T1_AdvanceAmount""].Value<0)");
base.WriteDebugInfo(@"EXEC UpsertProjectBudgetDetails 9,'#MG_ProjectDetailsId','#R_ReferenceNo','#MG_Amount','#MG_BudgetHead','#M_IsCommitment','#MG_FundTypeid','#M_PackageProcessMapId','#UC_EmployeeBaicInfoId'");

var querySource899d988ff3827c8e861e1b768959533f =GetQueryExpressionDataSource("899d988f-f382-7c8e-861e-1b768959533f");
Dictionary<short,object> result899d988ff3827c8e861e1b768959533f=iSpace.ExecuteQuery(querySource899d988ff3827c8e861e1b768959533f,@"EXEC UpsertProjectBudgetDetails 9,'" + ISpace["MG_ProjectDetailsId"].Value + @"','" + ISpace["R_ReferenceNo"].Value + @"','" + ISpace["MG_Amount"].Value + @"','" + ISpace["MG_BudgetHead"].Value + @"','" + ISpace["M_IsCommitment"].Value + @"','" + ISpace["MG_FundTypeid"].Value + @"','" + ISpace["M_PackageProcessMapId"].Value + @"','" + ISpace["UC_EmployeeBaicInfoId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource899d988ff3827c8e861e1b768959533f =GetQueryExpressionDataSource(""899d988f-f382-7c8e-861e-1b768959533f"");Dictionary<short,object> result899d988ff3827c8e861e1b768959533f=iSpace.ExecuteQuery(querySource899d988ff3827c8e861e1b768959533f,@""EXEC UpsertProjectBudgetDetails 9,'"" + ISpace[""MG_ProjectDetailsId""].Value + @""','"" + ISpace[""R_ReferenceNo""].Value + @""','"" + ISpace[""MG_Amount""].Value + @""','"" + ISpace[""MG_BudgetHead""].Value + @""','"" + ISpace[""M_IsCommitment""].Value + @""','"" + ISpace[""MG_FundTypeid""].Value + @""','"" + ISpace[""M_PackageProcessMapId""].Value + @""','"" + ISpace[""UC_EmployeeBaicInfoId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result899d988ff3827c8e861e1b768959533f!=null) && (result899d988ff3827c8e861e1b768959533f.Count!=0))
{
if(result899d988ff3827c8e861e1b768959533f.ContainsKey(0))
ISpace["A"].Value = result899d988ff3827c8e861e1b768959533f[0];
}
else{
ISpace["A"].Value = null;
}
}
else
{
base.WriteDebugInfo(@"else");
base.WriteDebugInfo(@"EXEC UpsertProjectBudgetDetails 5,'#MG_ProjectDetailsId','#R_ReferenceNo','#MG_Amount','#MG_BudgetHead','#M_IsCommitment','#MG_FundTypeid','#M_PackageProcessMapId','#UC_EmployeeBaicInfoId'");

var querySourcec9219f16b139e53f19ec6f479fd577a9 =GetQueryExpressionDataSource("c9219f16-b139-e53f-19ec-6f479fd577a9");
Dictionary<short,object> resultc9219f16b139e53f19ec6f479fd577a9=iSpace.ExecuteQuery(querySourcec9219f16b139e53f19ec6f479fd577a9,@"EXEC UpsertProjectBudgetDetails 5,'" + ISpace["MG_ProjectDetailsId"].Value + @"','" + ISpace["R_ReferenceNo"].Value + @"','" + ISpace["MG_Amount"].Value + @"','" + ISpace["MG_BudgetHead"].Value + @"','" + ISpace["M_IsCommitment"].Value + @"','" + ISpace["MG_FundTypeid"].Value + @"','" + ISpace["M_PackageProcessMapId"].Value + @"','" + ISpace["UC_EmployeeBaicInfoId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourcec9219f16b139e53f19ec6f479fd577a9 =GetQueryExpressionDataSource(""c9219f16-b139-e53f-19ec-6f479fd577a9"");Dictionary<short,object> resultc9219f16b139e53f19ec6f479fd577a9=iSpace.ExecuteQuery(querySourcec9219f16b139e53f19ec6f479fd577a9,@""EXEC UpsertProjectBudgetDetails 5,'"" + ISpace[""MG_ProjectDetailsId""].Value + @""','"" + ISpace[""R_ReferenceNo""].Value + @""','"" + ISpace[""MG_Amount""].Value + @""','"" + ISpace[""MG_BudgetHead""].Value + @""','"" + ISpace[""M_IsCommitment""].Value + @""','"" + ISpace[""MG_FundTypeid""].Value + @""','"" + ISpace[""M_PackageProcessMapId""].Value + @""','"" + ISpace[""UC_EmployeeBaicInfoId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultc9219f16b139e53f19ec6f479fd577a9!=null) && (resultc9219f16b139e53f19ec6f479fd577a9.Count!=0))
{
if(resultc9219f16b139e53f19ec6f479fd577a9.ContainsKey(0))
ISpace["A"].Value = resultc9219f16b139e53f19ec6f479fd577a9[0];
}
else{
ISpace["A"].Value = null;
}
}
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("MF_FundAmount","0BFAF73B-02D4-4680-B1C9-625AAFB02DB5",_objectFactory.GetGridRPP("MF_FundAmount"),_elementBase.GetGridLoopQuery("0BFAF73B-02D4-4680-B1C9-625AAFB02DB5","MF_FundAmount",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""MF_FundAmount"",ref ISpace);

foreach(var gridChild in ISpace[""MF_FundAmount""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC RemarksDomain '#M_IsSourceStep','#Updatedon','#M_InstanceId','#gv_UserId','#SetDestinationTo','#gv_UserName','#gv_ActivityName','#M_Remarks','#gv_TenantId','#TrailLogId','#M_SourceActivityMapId','#RemarksOn'");

var querySourceCFCAC7935C3F430199EA29692D7A07E4 =GetQueryExpressionDataSource("CFCAC793-5C3F-4301-99EA-29692D7A07E4");
Dictionary<short,object> resultCFCAC7935C3F430199EA29692D7A07E4=iSpace.ExecuteQuery(querySourceCFCAC7935C3F430199EA29692D7A07E4,@"EXEC RemarksDomain '" + ISpace["M_IsSourceStep"].Value + @"','" + ISpace["Updatedon"].Value + @"','" + ISpace["M_InstanceId"].Value + @"','" + ISpace["gv_UserId"].Value + @"','" + ISpace["SetDestinationTo"].Value + @"','" + ISpace["gv_UserName"].Value + @"','" + ISpace["gv_ActivityName"].Value + @"','" + ISpace["M_Remarks"].Value + @"','" + ISpace["gv_TenantId"].Value + @"','" + ISpace["TrailLogId"].Value + @"','" + ISpace["M_SourceActivityMapId"].Value + @"','" + ISpace["RemarksOn"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceCFCAC7935C3F430199EA29692D7A07E4 =GetQueryExpressionDataSource(""CFCAC793-5C3F-4301-99EA-29692D7A07E4"");Dictionary<short,object> resultCFCAC7935C3F430199EA29692D7A07E4=iSpace.ExecuteQuery(querySourceCFCAC7935C3F430199EA29692D7A07E4,@""EXEC RemarksDomain '"" + ISpace[""M_IsSourceStep""].Value + @""','"" + ISpace[""Updatedon""].Value + @""','"" + ISpace[""M_InstanceId""].Value + @""','"" + ISpace[""gv_UserId""].Value + @""','"" + ISpace[""SetDestinationTo""].Value + @""','"" + ISpace[""gv_UserName""].Value + @""','"" + ISpace[""gv_ActivityName""].Value + @""','"" + ISpace[""M_Remarks""].Value + @""','"" + ISpace[""gv_TenantId""].Value + @""','"" + ISpace[""TrailLogId""].Value + @""','"" + ISpace[""M_SourceActivityMapId""].Value + @""','"" + ISpace[""RemarksOn""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultCFCAC7935C3F430199EA29692D7A07E4!=null) && (resultCFCAC7935C3F430199EA29692D7A07E4.Count!=0))
{
}
else{

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
if(ISpace["M_IsFlowReturned"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""M_IsFlowReturned""].Value==1)");
base.WriteDebugInfo(@"#MF_FundAmount[Rows]");
iSpace.GetLoopExpressionData("MF_FundAmount",ref ISpace);

foreach(var gridChild in ISpace["MF_FundAmount"].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 

base.WriteDebugInfo(@"EXEC UpsertProjectBudgetDetails 6,'#MG_ProjectDetailsId','#R_ReferenceNo','#MG_Amount','#MG_BudgetHead','1','#MG_FundTypeid','#M_PackageProcessMapId','#UC_EmployeeBaicInfoId'");

var querySourceBD4FA2562A90453781F7851553AB7968 =GetQueryExpressionDataSource("BD4FA256-2A90-4537-81F7-851553AB7968");
Dictionary<short,object> resultBD4FA2562A90453781F7851553AB7968=iSpace.ExecuteQuery(querySourceBD4FA2562A90453781F7851553AB7968,@"EXEC UpsertProjectBudgetDetails 6,'" + ISpace["MG_ProjectDetailsId"].Value + @"','" + ISpace["R_ReferenceNo"].Value + @"','" + ISpace["MG_Amount"].Value + @"','" + ISpace["MG_BudgetHead"].Value + @"','1','" + ISpace["MG_FundTypeid"].Value + @"','" + ISpace["M_PackageProcessMapId"].Value + @"','" + ISpace["UC_EmployeeBaicInfoId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceBD4FA2562A90453781F7851553AB7968 =GetQueryExpressionDataSource(""BD4FA256-2A90-4537-81F7-851553AB7968"");Dictionary<short,object> resultBD4FA2562A90453781F7851553AB7968=iSpace.ExecuteQuery(querySourceBD4FA2562A90453781F7851553AB7968,@""EXEC UpsertProjectBudgetDetails 6,'"" + ISpace[""MG_ProjectDetailsId""].Value + @""','"" + ISpace[""R_ReferenceNo""].Value + @""','"" + ISpace[""MG_Amount""].Value + @""','"" + ISpace[""MG_BudgetHead""].Value + @""','1','"" + ISpace[""MG_FundTypeid""].Value + @""','"" + ISpace[""M_PackageProcessMapId""].Value + @""','"" + ISpace[""UC_EmployeeBaicInfoId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultBD4FA2562A90453781F7851553AB7968!=null) && (resultBD4FA2562A90453781F7851553AB7968.Count!=0))
{
if(resultBD4FA2562A90453781F7851553AB7968.ContainsKey(0))
ISpace["A"].Value = resultBD4FA2562A90453781F7851553AB7968[0];
}
else{
ISpace["A"].Value = null;
}
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("MF_FundAmount","0BFAF73B-02D4-4680-B1C9-625AAFB02DB5",_objectFactory.GetGridRPP("MF_FundAmount"),_elementBase.GetGridLoopQuery("0BFAF73B-02D4-4680-B1C9-625AAFB02DB5","MF_FundAmount",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""MF_FundAmount"",ref ISpace);

foreach(var gridChild in ISpace[""MF_FundAmount""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
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
base.WriteDebugInfo(@"EXEC UserRequestForOtherStep '#M_NextStage','#M_Status','#gv_UserId','#SetDestinationTo','#M_InstanceId','#LastModifiedOn'");

var querySource26121ea8dc1b0c613f1e2020d59e6348 =GetQueryExpressionDataSource("26121ea8-dc1b-0c61-3f1e-2020d59e6348");
Dictionary<short,object> result26121ea8dc1b0c613f1e2020d59e6348=iSpace.ExecuteQuery(querySource26121ea8dc1b0c613f1e2020d59e6348,@"EXEC UserRequestForOtherStep '" + ISpace["M_NextStage"].Value + @"','" + ISpace["M_Status"].Value + @"','" + ISpace["gv_UserId"].Value + @"','" + ISpace["SetDestinationTo"].Value + @"','" + ISpace["M_InstanceId"].Value + @"','" + ISpace["LastModifiedOn"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource26121ea8dc1b0c613f1e2020d59e6348 =GetQueryExpressionDataSource(""26121ea8-dc1b-0c61-3f1e-2020d59e6348"");Dictionary<short,object> result26121ea8dc1b0c613f1e2020d59e6348=iSpace.ExecuteQuery(querySource26121ea8dc1b0c613f1e2020d59e6348,@""EXEC UserRequestForOtherStep '"" + ISpace[""M_NextStage""].Value + @""','"" + ISpace[""M_Status""].Value + @""','"" + ISpace[""gv_UserId""].Value + @""','"" + ISpace[""SetDestinationTo""].Value + @""','"" + ISpace[""M_InstanceId""].Value + @""','"" + ISpace[""LastModifiedOn""].Value + @""'"",false);");
ISpace["Message"].Value=@"Submitted Successfully";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Submitted Successfully"";");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_edit_travelexpense (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Edit_TravelExpense-OnClick");
ISpace["growid"].Value=ISpace["TravelExpense_RowId"].Value;
base.WriteDebugInfo(@"ISpace[""growid""].Value=ISpace[""TravelExpense_RowId""].Value;");
base.WriteDebugInfo(@"EXEC [LoadFormGridData9F49372F-0255-42EC-AB05-31E6C4F9F2EA] '@@gv_InstanceId','@@gv_ProcessMapId','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','@@gv_ActivityMapId','#growid'");

var querySourceED15FA1FD7F94F6A9FC435EEE23FA142 =GetQueryExpressionDataSource("ED15FA1F-D7F9-4F6A-9FC4-35EEE23FA142");
Dictionary<short,object> resultED15FA1FD7F94F6A9FC435EEE23FA142=iSpace.ExecuteQuery(querySourceED15FA1FD7F94F6A9FC435EEE23FA142,@"EXEC [LoadFormGridData9F49372F-0255-42EC-AB05-31E6C4F9F2EA] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["growid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceED15FA1FD7F94F6A9FC435EEE23FA142 =GetQueryExpressionDataSource(""ED15FA1F-D7F9-4F6A-9FC4-35EEE23FA142"");Dictionary<short,object> resultED15FA1FD7F94F6A9FC435EEE23FA142=iSpace.ExecuteQuery(querySourceED15FA1FD7F94F6A9FC435EEE23FA142,@""EXEC [LoadFormGridData9F49372F-0255-42EC-AB05-31E6C4F9F2EA] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""growid""].Value + @""'"",false);");
base.WriteDebugInfo(@"EXEC LoadFormGridData374fb8a88dd94cf1bf73f40ae18fcad7 '@@gv_InstanceId','@@gv_ProcessMapId','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','@@gv_ActivityMapId','#growid'");

if((resultED15FA1FD7F94F6A9FC435EEE23FA142!=null) && (resultED15FA1FD7F94F6A9FC435EEE23FA142.Count!=0))
{
if(resultED15FA1FD7F94F6A9FC435EEE23FA142.ContainsKey(6))
ISpace["MFG_T2_ArrivalDate"].Value = resultED15FA1FD7F94F6A9FC435EEE23FA142[6];
if(resultED15FA1FD7F94F6A9FC435EEE23FA142.ContainsKey(3))
ISpace["MFG_T2_DepartureDate"].Value = resultED15FA1FD7F94F6A9FC435EEE23FA142[3];
if(resultED15FA1FD7F94F6A9FC435EEE23FA142.ContainsKey(8))
ISpace["MFG_T2_ModeofJourney"].Value = resultED15FA1FD7F94F6A9FC435EEE23FA142[8];
if(resultED15FA1FD7F94F6A9FC435EEE23FA142.ContainsKey(9))
ISpace["MFG_T2_JourneyClass"].Value = resultED15FA1FD7F94F6A9FC435EEE23FA142[9];
if(resultED15FA1FD7F94F6A9FC435EEE23FA142.ContainsKey(10))
ISpace["MFG_T2_Road"].Value = resultED15FA1FD7F94F6A9FC435EEE23FA142[10];
if(resultED15FA1FD7F94F6A9FC435EEE23FA142.ContainsKey(12))
ISpace["MFG_T2_Amount"].Value = resultED15FA1FD7F94F6A9FC435EEE23FA142[12];
if(resultED15FA1FD7F94F6A9FC435EEE23FA142.ContainsKey(1))
ISpace["MFG_T2_TravelAdvanceID"].Value = resultED15FA1FD7F94F6A9FC435EEE23FA142[1];
if(resultED15FA1FD7F94F6A9FC435EEE23FA142.ContainsKey(2))
ISpace["MFG_T2_Departure"].Value = resultED15FA1FD7F94F6A9FC435EEE23FA142[2];
if(resultED15FA1FD7F94F6A9FC435EEE23FA142.ContainsKey(11))
ISpace["MFG_T2_PNRNo"].Value = resultED15FA1FD7F94F6A9FC435EEE23FA142[11];
if(resultED15FA1FD7F94F6A9FC435EEE23FA142.ContainsKey(7))
ISpace["MFG_T2_ArrivalTime"].Value = resultED15FA1FD7F94F6A9FC435EEE23FA142[7];
if(resultED15FA1FD7F94F6A9FC435EEE23FA142.ContainsKey(4))
ISpace["MFG_T2_DepartureTime"].Value = resultED15FA1FD7F94F6A9FC435EEE23FA142[4];
if(resultED15FA1FD7F94F6A9FC435EEE23FA142.ContainsKey(5))
ISpace["MFG_T2_Arrival"].Value = resultED15FA1FD7F94F6A9FC435EEE23FA142[5];
if(resultED15FA1FD7F94F6A9FC435EEE23FA142.ContainsKey(0))
ISpace["MFG_T2_TADetailsID"].Value = resultED15FA1FD7F94F6A9FC435EEE23FA142[0];
}
else{
ISpace["MFG_T2_ArrivalDate"].Value = null;ISpace["MFG_T2_DepartureDate"].Value = null;ISpace["MFG_T2_ModeofJourney"].Value = null;ISpace["MFG_T2_JourneyClass"].Value = null;ISpace["MFG_T2_Road"].Value = null;ISpace["MFG_T2_Amount"].Value = null;ISpace["MFG_T2_TravelAdvanceID"].Value = null;ISpace["MFG_T2_Departure"].Value = null;ISpace["MFG_T2_PNRNo"].Value = null;ISpace["MFG_T2_ArrivalTime"].Value = null;ISpace["MFG_T2_DepartureTime"].Value = null;ISpace["MFG_T2_Arrival"].Value = null;ISpace["MFG_T2_TADetailsID"].Value = null;
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_save_travelexpense (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Save_TravelExpense-OnClick");
if(ISpace["growid"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""growid""].Value=="""")");

var querySource47DEECA98E4E4FDE806BD716B4F25534 =GetQueryExpressionDataSource("47DEECA9-8E4E-4FDE-806B-D716B4F25534");

DataTable result47DEECA98E4E4FDE806BD716B4F25534=iSpace.SetGridDataSource(querySource47DEECA98E4E4FDE806BD716B4F25534, _objectFactory.GetGridRPP("TravelExpense"),@"EXEC [AddFormGridData9F49372F-0255-42EC-AB05-31E6C4F9F2EA] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["MFG_T2_TADetailsID"].Value + @"','" + ISpace["MFG_T2_TravelAdvanceID"].Value + @"','" + ISpace["MFG_T2_Departure"].Value + @"','" + ISpace["MFG_T2_DepartureDate"].Value + @"','" + ISpace["MFG_T2_DepartureTime"].Value + @"','" + ISpace["MFG_T2_Arrival"].Value + @"','" + ISpace["MFG_T2_ArrivalDate"].Value + @"','" + ISpace["MFG_T2_ArrivalTime"].Value + @"','" + ISpace["MFG_T2_ModeofJourney"].Value + @"','" + ISpace["MFG_T2_JourneyClass"].Value + @"'," + ISpace["MFG_T2_Road"].Value + @",'" + ISpace["MFG_T2_PNRNo"].Value + @"'," + ISpace["MFG_T2_Amount"].Value + @",'" + ISpace["growid"].Value + @"'");

iSpace.InsertGridBindDetails("TravelExpense","11",querySource47DEECA98E4E4FDE806BD716B4F25534,"EXEC [AddFormGridData9F49372F-0255-42EC-AB05-31E6C4F9F2EA] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["MFG_T2_TADetailsID"].Value + @"','" + ISpace["MFG_T2_TravelAdvanceID"].Value + @"','" + ISpace["MFG_T2_Departure"].Value + @"','" + ISpace["MFG_T2_DepartureDate"].Value + @"','" + ISpace["MFG_T2_DepartureTime"].Value + @"','" + ISpace["MFG_T2_Arrival"].Value + @"','" + ISpace["MFG_T2_ArrivalDate"].Value + @"','" + ISpace["MFG_T2_ArrivalTime"].Value + @"','" + ISpace["MFG_T2_ModeofJourney"].Value + @"','" + ISpace["MFG_T2_JourneyClass"].Value + @"'," + ISpace["MFG_T2_Road"].Value + @",'" + ISpace["MFG_T2_PNRNo"].Value + @"'," + ISpace["MFG_T2_Amount"].Value + @",'" + ISpace["growid"].Value + @"'",_objectFactory.GetGridRPP("TravelExpense"));

base.WriteDebugInfo(@"var querySource47DEECA98E4E4FDE806BD716B4F25534 =GetQueryExpressionDataSource(""47DEECA9-8E4E-4FDE-806B-D716B4F25534"");DataTable result47DEECA98E4E4FDE806BD716B4F25534=iSpace.SetGridDataSource(querySource47DEECA98E4E4FDE806BD716B4F25534, _objectFactory.GetGridRPP(""TravelExpense""),@""EXEC [AddFormGridData9F49372F-0255-42EC-AB05-31E6C4F9F2EA] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""MFG_T2_TADetailsID""].Value + @""','"" + ISpace[""MFG_T2_TravelAdvanceID""].Value + @""','"" + ISpace[""MFG_T2_Departure""].Value + @""','"" + ISpace[""MFG_T2_DepartureDate""].Value + @""','"" + ISpace[""MFG_T2_DepartureTime""].Value + @""','"" + ISpace[""MFG_T2_Arrival""].Value + @""','"" + ISpace[""MFG_T2_ArrivalDate""].Value + @""','"" + ISpace[""MFG_T2_ArrivalTime""].Value + @""','"" + ISpace[""MFG_T2_ModeofJourney""].Value + @""','"" + ISpace[""MFG_T2_JourneyClass""].Value + @""',"" + ISpace[""MFG_T2_Road""].Value + @"",'"" + ISpace[""MFG_T2_PNRNo""].Value + @""',"" + ISpace[""MFG_T2_Amount""].Value + @"",'"" + ISpace[""growid""].Value + @""'"");iSpace.InsertGridBindDetails(""TravelExpense"",""11"",querySource47DEECA98E4E4FDE806BD716B4F25534,""EXEC [AddFormGridData9F49372F-0255-42EC-AB05-31E6C4F9F2EA] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""MFG_T2_TADetailsID""].Value + @""','"" + ISpace[""MFG_T2_TravelAdvanceID""].Value + @""','"" + ISpace[""MFG_T2_Departure""].Value + @""','"" + ISpace[""MFG_T2_DepartureDate""].Value + @""','"" + ISpace[""MFG_T2_DepartureTime""].Value + @""','"" + ISpace[""MFG_T2_Arrival""].Value + @""','"" + ISpace[""MFG_T2_ArrivalDate""].Value + @""','"" + ISpace[""MFG_T2_ArrivalTime""].Value + @""','"" + ISpace[""MFG_T2_ModeofJourney""].Value + @""','"" + ISpace[""MFG_T2_JourneyClass""].Value + @""',"" + ISpace[""MFG_T2_Road""].Value + @"",'"" + ISpace[""MFG_T2_PNRNo""].Value + @""',"" + ISpace[""MFG_T2_Amount""].Value + @"",'"" + ISpace[""growid""].Value + @""'"",_objectFactory.GetGridRPP(""TravelExpense""));");
base.WriteDebugInfo(@"EXEC AddFormGridData374fb8a88dd94cf1bf73f40ae18fcad7 '@@gv_InstanceId','@@gv_ProcessMapId','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','@@gv_ActivityMapId','#MFG_T2_TADetailsID','#MFG_T2_TravelAdvanceID','#MFG_T2_Departure','#MFG_T2_DepartureDate','#MFG_T2_DepartureTime','#MFG_T2_Arrival','#MFG_T2_ArrivalDate','#MFG_T2_ArrivalTime','#MFG_T2_ModeofJourney','#MFG_T2_JourneyClass',#MFG_T2_Road,'#MFG_T2_PNRNo',#MFG_T3_Amount,'#growid'");


List<Triplet<string, short, short?>> result5FF52A9FC7A9483893076D31A18D61AB=acdataIspaceF4BD3F24901C43AB86074D7817A2621C.GetQueryExpressionBindings("5FF52A9F-C7A9-4838-9307-6D31A18D61AB");
iSpace.SetGridData(result47DEECA98E4E4FDE806BD716B4F25534,result5FF52A9FC7A9483893076D31A18D61AB,"TravelExpense",ref ISpace);
iSpace.UpdateGridBindDetails("TravelExpense",result5FF52A9FC7A9483893076D31A18D61AB);
}
else
{
base.WriteDebugInfo(@"else");

var querySource68C5D0A58E3049AB91AD12CEEA91048F =GetQueryExpressionDataSource("68C5D0A5-8E30-49AB-91AD-12CEEA91048F");

DataTable result68C5D0A58E3049AB91AD12CEEA91048F=iSpace.SetGridDataSource(querySource68C5D0A58E3049AB91AD12CEEA91048F, _objectFactory.GetGridRPP("TravelExpense"),@"EXEC [UpdateFormGridData9F49372F-0255-42EC-AB05-31E6C4F9F2EA] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["MFG_T2_TADetailsID"].Value + @"','" + ISpace["MFG_T2_TravelAdvanceID"].Value + @"','" + ISpace["MFG_T2_Departure"].Value + @"','" + ISpace["MFG_T2_DepartureDate"].Value + @"','" + ISpace["MFG_T2_DepartureTime"].Value + @"','" + ISpace["MFG_T2_Arrival"].Value + @"','" + ISpace["MFG_T2_ArrivalDate"].Value + @"','" + ISpace["MFG_T2_ArrivalTime"].Value + @"','" + ISpace["MFG_T2_ModeofJourney"].Value + @"','" + ISpace["MFG_T2_JourneyClass"].Value + @"'," + ISpace["MFG_T2_Road"].Value + @",'" + ISpace["MFG_T2_PNRNo"].Value + @"'," + ISpace["MFG_T2_Amount"].Value + @",'" + ISpace["growid"].Value + @"'");

iSpace.InsertGridBindDetails("TravelExpense","11",querySource68C5D0A58E3049AB91AD12CEEA91048F,"EXEC [UpdateFormGridData9F49372F-0255-42EC-AB05-31E6C4F9F2EA] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["MFG_T2_TADetailsID"].Value + @"','" + ISpace["MFG_T2_TravelAdvanceID"].Value + @"','" + ISpace["MFG_T2_Departure"].Value + @"','" + ISpace["MFG_T2_DepartureDate"].Value + @"','" + ISpace["MFG_T2_DepartureTime"].Value + @"','" + ISpace["MFG_T2_Arrival"].Value + @"','" + ISpace["MFG_T2_ArrivalDate"].Value + @"','" + ISpace["MFG_T2_ArrivalTime"].Value + @"','" + ISpace["MFG_T2_ModeofJourney"].Value + @"','" + ISpace["MFG_T2_JourneyClass"].Value + @"'," + ISpace["MFG_T2_Road"].Value + @",'" + ISpace["MFG_T2_PNRNo"].Value + @"'," + ISpace["MFG_T2_Amount"].Value + @",'" + ISpace["growid"].Value + @"'",_objectFactory.GetGridRPP("TravelExpense"));

base.WriteDebugInfo(@"var querySource68C5D0A58E3049AB91AD12CEEA91048F =GetQueryExpressionDataSource(""68C5D0A5-8E30-49AB-91AD-12CEEA91048F"");DataTable result68C5D0A58E3049AB91AD12CEEA91048F=iSpace.SetGridDataSource(querySource68C5D0A58E3049AB91AD12CEEA91048F, _objectFactory.GetGridRPP(""TravelExpense""),@""EXEC [UpdateFormGridData9F49372F-0255-42EC-AB05-31E6C4F9F2EA] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""MFG_T2_TADetailsID""].Value + @""','"" + ISpace[""MFG_T2_TravelAdvanceID""].Value + @""','"" + ISpace[""MFG_T2_Departure""].Value + @""','"" + ISpace[""MFG_T2_DepartureDate""].Value + @""','"" + ISpace[""MFG_T2_DepartureTime""].Value + @""','"" + ISpace[""MFG_T2_Arrival""].Value + @""','"" + ISpace[""MFG_T2_ArrivalDate""].Value + @""','"" + ISpace[""MFG_T2_ArrivalTime""].Value + @""','"" + ISpace[""MFG_T2_ModeofJourney""].Value + @""','"" + ISpace[""MFG_T2_JourneyClass""].Value + @""',"" + ISpace[""MFG_T2_Road""].Value + @"",'"" + ISpace[""MFG_T2_PNRNo""].Value + @""',"" + ISpace[""MFG_T2_Amount""].Value + @"",'"" + ISpace[""growid""].Value + @""'"");iSpace.InsertGridBindDetails(""TravelExpense"",""11"",querySource68C5D0A58E3049AB91AD12CEEA91048F,""EXEC [UpdateFormGridData9F49372F-0255-42EC-AB05-31E6C4F9F2EA] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""MFG_T2_TADetailsID""].Value + @""','"" + ISpace[""MFG_T2_TravelAdvanceID""].Value + @""','"" + ISpace[""MFG_T2_Departure""].Value + @""','"" + ISpace[""MFG_T2_DepartureDate""].Value + @""','"" + ISpace[""MFG_T2_DepartureTime""].Value + @""','"" + ISpace[""MFG_T2_Arrival""].Value + @""','"" + ISpace[""MFG_T2_ArrivalDate""].Value + @""','"" + ISpace[""MFG_T2_ArrivalTime""].Value + @""','"" + ISpace[""MFG_T2_ModeofJourney""].Value + @""','"" + ISpace[""MFG_T2_JourneyClass""].Value + @""',"" + ISpace[""MFG_T2_Road""].Value + @"",'"" + ISpace[""MFG_T2_PNRNo""].Value + @""',"" + ISpace[""MFG_T2_Amount""].Value + @"",'"" + ISpace[""growid""].Value + @""'"",_objectFactory.GetGridRPP(""TravelExpense""));");
base.WriteDebugInfo(@"EXEC UpdateFormGridData374fb8a88dd94cf1bf73f40ae18fcad7 '@@gv_InstanceId','@@gv_ProcessMapId','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','@@gv_ActivityMapId','#MFG_T2_TADetailsID','#MFG_T2_TravelAdvanceID','#MFG_T2_Departure','#MFG_T2_DepartureDate','#MFG_T2_DepartureTime','#MFG_T2_Arrival','#MFG_T2_ArrivalDate','#MFG_T2_ArrivalTime','#MFG_T2_ModeofJourney','#MFG_T2_JourneyClass',#MFG_T2_Road,'#MFG_T2_PNRNo',#MFG_T3_Amount,'#growid'");


List<Triplet<string, short, short?>> resultDA3CF2FEBFBD482BB0D7A4FADF01F4B2=acdataIspaceF4BD3F24901C43AB86074D7817A2621C.GetQueryExpressionBindings("DA3CF2FE-BFBD-482B-B0D7-A4FADF01F4B2");
iSpace.SetGridData(result68C5D0A58E3049AB91AD12CEEA91048F,resultDA3CF2FEBFBD482BB0D7A4FADF01F4B2,"TravelExpense",ref ISpace);
iSpace.UpdateGridBindDetails("TravelExpense",resultDA3CF2FEBFBD482BB0D7A4FADF01F4B2);
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["growid"].Value="";
base.WriteDebugInfo(@"ISpace[""growid""].Value="""";");
}
ISpace["growid"].Value="";
base.WriteDebugInfo(@"ISpace[""growid""].Value="""";");
ISpace["MFG_T2_TADetailsID"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_T2_TADetailsID""].Value="""";");
ISpace["MFG_T2_TravelAdvanceID"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_T2_TravelAdvanceID""].Value="""";");
ISpace["MFG_T2_Departure"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_T2_Departure""].Value="""";");
ISpace["MFG_T2_DepartureDate"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_T2_DepartureDate""].Value="""";");
ISpace["MFG_T2_DepartureTime"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_T2_DepartureTime""].Value="""";");
ISpace["MFG_T2_Arrival"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_T2_Arrival""].Value="""";");
ISpace["MFG_T2_ArrivalDate"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_T2_ArrivalDate""].Value="""";");
ISpace["MFG_T2_ArrivalTime"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_T2_ArrivalTime""].Value="""";");
ISpace["MFG_T2_ModeofJourney"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_T2_ModeofJourney""].Value="""";");
ISpace["MFG_T2_JourneyClass"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_T2_JourneyClass""].Value="""";");
ISpace["MFG_T2_Road"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_T2_Road""].Value="""";");
ISpace["MFG_T2_PNRNo"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_T2_PNRNo""].Value="""";");
ISpace["MFG_T2_Amount"].Value=null;
base.WriteDebugInfo(@"ISpace[""MFG_T2_Amount""].Value=null;");
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

var querySource427807408C6F4DABBF411EB6F16F1F21 =GetQueryExpressionDataSource("42780740-8C6F-4DAB-BF41-1EB6F16F1F21");
Dictionary<short,object> result427807408C6F4DABBF411EB6F16F1F21=iSpace.ExecuteQuery(querySource427807408C6F4DABBF411EB6F16F1F21,@"Exec GetStageStatus 1,'','','" + ISpace["M_MoveToValue"].Value + @"','" + ISpace["M_SourceActivityMapId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource427807408C6F4DABBF411EB6F16F1F21 =GetQueryExpressionDataSource(""42780740-8C6F-4DAB-BF41-1EB6F16F1F21"");Dictionary<short,object> result427807408C6F4DABBF411EB6F16F1F21=iSpace.ExecuteQuery(querySource427807408C6F4DABBF411EB6F16F1F21,@""Exec GetStageStatus 1,'','','"" + ISpace[""M_MoveToValue""].Value + @""','"" + ISpace[""M_SourceActivityMapId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result427807408C6F4DABBF411EB6F16F1F21!=null) && (result427807408C6F4DABBF411EB6F16F1F21.Count!=0))
{
if(result427807408C6F4DABBF411EB6F16F1F21.ContainsKey(4))
ISpace["M_FieldMandatory"].Value = result427807408C6F4DABBF411EB6F16F1F21[4];
if(result427807408C6F4DABBF411EB6F16F1F21.ContainsKey(5))
ISpace["M_IsFlowReturned"].Value = result427807408C6F4DABBF411EB6F16F1F21[5];
if(result427807408C6F4DABBF411EB6F16F1F21.ContainsKey(1))
ISpace["M_RemarksMandatory"].Value = result427807408C6F4DABBF411EB6F16F1F21[1];
if(result427807408C6F4DABBF411EB6F16F1F21.ContainsKey(6))
ISpace["M_IsCancelReject"].Value = result427807408C6F4DABBF411EB6F16F1F21[6];
if(result427807408C6F4DABBF411EB6F16F1F21.ContainsKey(3))
ISpace["M_SaveDomainData"].Value = result427807408C6F4DABBF411EB6F16F1F21[3];
if(result427807408C6F4DABBF411EB6F16F1F21.ContainsKey(0))
ISpace["M_NextStage"].Value = result427807408C6F4DABBF411EB6F16F1F21[0];
if(result427807408C6F4DABBF411EB6F16F1F21.ContainsKey(2))
ISpace["M_Remarks"].Value = result427807408C6F4DABBF411EB6F16F1F21[2];
}
else{
ISpace["M_FieldMandatory"].Value = null;ISpace["M_IsFlowReturned"].Value = null;ISpace["M_RemarksMandatory"].Value = null;ISpace["M_IsCancelReject"].Value = null;ISpace["M_SaveDomainData"].Value = null;ISpace["M_NextStage"].Value = null;ISpace["M_Remarks"].Value = null;
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
		if(elementName.ToLower().Equals("edit_travelexpense"))
{
			SubscribeElementEvents_edit_travelexpense(ref dfsParam);
}
		if(elementName.ToLower().Equals("save_travelexpense"))
{
			SubscribeElementEvents_save_travelexpense(ref dfsParam);
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
public class ISpaceF5D55501419C4E8D97D9EFE380D7D47D : VirtualForm
{
IISpace iSpace = new ISpace();
AcDataISpaceF5D55501419C4E8D97D9EFE380D7D47D acdataIspaceF5D55501419C4E8D97D9EFE380D7D47D=new AcDataISpaceF5D55501419C4E8D97D9EFE380D7D47D();
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
ISpace["M_RandDTransactionDate"].Man=true;ISpace["M_RandDTransactionNo"].Man=true;
base.WriteDebugInfo(@"ISpace[""M_RandDTransactionDate""].Man=true;ISpace[""M_RandDTransactionNo""].Man=true;");
ISpace["UC_PhoneNumber"].Visible="false";ISpace["UC_Grade"].Visible="false";ISpace["UC_Paylevel"].Visible="false";ISpace["UC_DOR"].Visible="false";ISpace["UC_DOJ"].Visible="false";ISpace["UC_EmailId"].Visible="false";ISpace["UC_DOB"].Visible="false";
base.WriteDebugInfo(@"ISpace[""UC_PhoneNumber""].Visible=""false"";ISpace[""UC_Grade""].Visible=""false"";ISpace[""UC_Paylevel""].Visible=""false"";ISpace[""UC_DOR""].Visible=""false"";ISpace[""UC_DOJ""].Visible=""false"";ISpace[""UC_EmailId""].Visible=""false"";ISpace[""UC_DOB""].Visible=""false"";");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySource800FCB85CC5F45509D3F5D7AE4650DF2 =GetQueryExpressionDataSource("800FCB85-CC5F-4550-9D3F-5D7AE4650DF2");

DataTable result800FCB85CC5F45509D3F5D7AE4650DF2=iSpace.SetGridDataSource(querySource800FCB85CC5F45509D3F5D7AE4650DF2, _objectFactory.GetGridRPP("MG_RemarksDetails"),@"EXEC GetRemarks '" + ISpace["M_InstanceId"].Value + @"'");

iSpace.InsertGridBindDetails("MG_RemarksDetails","11",querySource800FCB85CC5F45509D3F5D7AE4650DF2,"EXEC GetRemarks '" + ISpace["M_InstanceId"].Value + @"'",_objectFactory.GetGridRPP("MG_RemarksDetails"));

base.WriteDebugInfo(@"var querySource800FCB85CC5F45509D3F5D7AE4650DF2 =GetQueryExpressionDataSource(""800FCB85-CC5F-4550-9D3F-5D7AE4650DF2"");DataTable result800FCB85CC5F45509D3F5D7AE4650DF2=iSpace.SetGridDataSource(querySource800FCB85CC5F45509D3F5D7AE4650DF2, _objectFactory.GetGridRPP(""MG_RemarksDetails""),@""EXEC GetRemarks '"" + ISpace[""M_InstanceId""].Value + @""'"");iSpace.InsertGridBindDetails(""MG_RemarksDetails"",""11"",querySource800FCB85CC5F45509D3F5D7AE4650DF2,""EXEC GetRemarks '"" + ISpace[""M_InstanceId""].Value + @""'"",_objectFactory.GetGridRPP(""MG_RemarksDetails""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> resultF6CCD46BA27D469EB390A56BFBF805A6=acdataIspaceF5D55501419C4E8D97D9EFE380D7D47D.GetQueryExpressionBindings("F6CCD46B-A27D-469E-B390-A56BFBF805A6");
iSpace.SetGridData(result800FCB85CC5F45509D3F5D7AE4650DF2,resultF6CCD46BA27D469EB390A56BFBF805A6,"MG_RemarksDetails",ref ISpace);
iSpace.UpdateGridBindDetails("MG_RemarksDetails",resultF6CCD46BA27D469EB390A56BFBF805A6);
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["MF_T1_BeneficiaryName"].Visible="true";ISpace["MF_T1_TravelType"].Visible="true";ISpace["MF_T1_ReferenceNo"].Visible="true";ISpace["MF_T1_Destination"].Visible="true";ISpace["MF_T1_AvailableBudget"].Visible="true";ISpace["MFG_T2_ExpenditureTypeID"].Visible="true";ISpace["MF_T1_AccountNo"].Visible="true";ISpace["MF_T1_TravellingPerson"].Visible="true";ISpace["MFG_T2_ArrivalDate"].Visible="true";ISpace["MFG_T2_ModeofJourney"].Visible="true";ISpace["MF_T1_JourneyPurpose"].Visible="true";ISpace["MFG_T2_Road"].Visible="true";ISpace["MFG_T2_ArrivalTime"].Visible="true";ISpace["MF_T1_ProjectNo"].Visible="true";ISpace["MF_T1_AdvanceAmount"].Visible="true";ISpace["MF_T1_TravelAdvanceID"].Visible="false";ISpace["MF_T1_BankName"].Visible="true";ISpace["MF_T1_BankBranch"].Visible="true";ISpace["MFG_T2_DepartureDate"].Visible="true";ISpace["MFG_T2_Departure"].Visible="true";ISpace["MFG_T2_PNRNo"].Visible="true";ISpace["MFG_T2_Amount"].Visible="true";ISpace["MFG_T3_TravelAdvanceID"].Visible="false";ISpace["MFG_T2_TravelAdvanceID"].Visible="false";ISpace["MF_T1_BankDocument"].Visible="true";ISpace["MFG_T2_JourneyClass"].Visible="true";ISpace["MF_T1_BudgetHead"].Visible="true";ISpace["MFG_T2_DepartureTime"].Visible="true";ISpace["MFG_T2_FromDate"].Visible="true";ISpace["MFG_T2_Arrival"].Visible="true";ISpace["MFG_T2_ToDate"].Visible="true";ISpace["MFG_T3_Amount"].Visible="true";ISpace["MFG_T2_TADetailsID"].Visible="true";
base.WriteDebugInfo(@"ISpace[""MF_T1_BeneficiaryName""].Visible=""true"";ISpace[""MF_T1_TravelType""].Visible=""true"";ISpace[""MF_T1_ReferenceNo""].Visible=""true"";ISpace[""MF_T1_Destination""].Visible=""true"";ISpace[""MF_T1_AvailableBudget""].Visible=""true"";ISpace[""MFG_T2_ExpenditureTypeID""].Visible=""true"";ISpace[""MF_T1_AccountNo""].Visible=""true"";ISpace[""MF_T1_TravellingPerson""].Visible=""true"";ISpace[""MFG_T2_ArrivalDate""].Visible=""true"";ISpace[""MFG_T2_ModeofJourney""].Visible=""true"";ISpace[""MF_T1_JourneyPurpose""].Visible=""true"";ISpace[""MFG_T2_Road""].Visible=""true"";ISpace[""MFG_T2_ArrivalTime""].Visible=""true"";ISpace[""MF_T1_ProjectNo""].Visible=""true"";ISpace[""MF_T1_AdvanceAmount""].Visible=""true"";ISpace[""MF_T1_TravelAdvanceID""].Visible=""false"";ISpace[""MF_T1_BankName""].Visible=""true"";ISpace[""MF_T1_BankBranch""].Visible=""true"";ISpace[""MFG_T2_DepartureDate""].Visible=""true"";ISpace[""MFG_T2_Departure""].Visible=""true"";ISpace[""MFG_T2_PNRNo""].Visible=""true"";ISpace[""MFG_T2_Amount""].Visible=""true"";ISpace[""MFG_T3_TravelAdvanceID""].Visible=""false"";ISpace[""MFG_T2_TravelAdvanceID""].Visible=""false"";ISpace[""MF_T1_BankDocument""].Visible=""true"";ISpace[""MFG_T2_JourneyClass""].Visible=""true"";ISpace[""MF_T1_BudgetHead""].Visible=""true"";ISpace[""MFG_T2_DepartureTime""].Visible=""true"";ISpace[""MFG_T2_FromDate""].Visible=""true"";ISpace[""MFG_T2_Arrival""].Visible=""true"";ISpace[""MFG_T2_ToDate""].Visible=""true"";ISpace[""MFG_T3_Amount""].Visible=""true"";ISpace[""MFG_T2_TADetailsID""].Visible=""true"";");
ISpace["MG_T3_TravelAdvanceID"].Visible="true";ISpace["MG_T2_ModeofJourney"].Visible="true";ISpace["MG_T2_JourneyClass"].Visible="true";ISpace["MG_T2_Departure"].Visible="true";ISpace["MG_T2_TADetailsID"].Visible="false";ISpace["MG_T2_Amount"].Visible="true";ISpace["MG_T2_DepartureTime"].Visible="true";ISpace["MG_T2_ArrivalTime"].Visible="true";ISpace["MG_T2_Road"].Visible="true";ISpace["MG_T2_DepartureDate"].Visible="true";ISpace["MG_T2_Arrival"].Visible="true";ISpace["MG_T2_ArrivalDate"].Visible="true";ISpace["MG_T2_PNRNo"].Visible="true";
base.WriteDebugInfo(@"ISpace[""MG_T3_TravelAdvanceID""].Visible=""true"";ISpace[""MG_T2_ModeofJourney""].Visible=""true"";ISpace[""MG_T2_JourneyClass""].Visible=""true"";ISpace[""MG_T2_Departure""].Visible=""true"";ISpace[""MG_T2_TADetailsID""].Visible=""false"";ISpace[""MG_T2_Amount""].Visible=""true"";ISpace[""MG_T2_DepartureTime""].Visible=""true"";ISpace[""MG_T2_ArrivalTime""].Visible=""true"";ISpace[""MG_T2_Road""].Visible=""true"";ISpace[""MG_T2_DepartureDate""].Visible=""true"";ISpace[""MG_T2_Arrival""].Visible=""true"";ISpace[""MG_T2_ArrivalDate""].Visible=""true"";ISpace[""MG_T2_PNRNo""].Visible=""true"";");
ISpace["MG_T2_ExpenditureTypeID"].Visible="true";ISpace["MG_T2_FromDate"].Visible="true";ISpace["MG_T2_ToDate"].Visible="true";ISpace["MG_T3_Amount"].Visible="true";ISpace["MG_T2_TravelAdvanceID"].Visible="false";
base.WriteDebugInfo(@"ISpace[""MG_T2_ExpenditureTypeID""].Visible=""true"";ISpace[""MG_T2_FromDate""].Visible=""true"";ISpace[""MG_T2_ToDate""].Visible=""true"";ISpace[""MG_T3_Amount""].Visible=""true"";ISpace[""MG_T2_TravelAdvanceID""].Visible=""false"";");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["MF_T1_BeneficiaryName"].Man=true;ISpace["MF_T1_TravelType"].Man=true;ISpace["MF_T1_ReferenceNo"].Man=true;ISpace["MF_T1_Destination"].Man=true;ISpace["MF_T1_AvailableBudget"].Man=true;ISpace["MF_T1_AccountNo"].Man=true;ISpace["MF_T1_TravellingPerson"].Man=true;ISpace["MF_T1_JourneyPurpose"].Man=true;ISpace["MF_T1_ProjectNo"].Man=true;ISpace["MF_T1_AdvanceAmount"].Man=true;ISpace["MF_T1_BankName"].Man=true;ISpace["MF_T1_BankBranch"].Man=true;ISpace["MF_T1_BankDocument"].Man=true;ISpace["MF_T1_BudgetHead"].Man=true;
base.WriteDebugInfo(@"ISpace[""MF_T1_BeneficiaryName""].Man=true;ISpace[""MF_T1_TravelType""].Man=true;ISpace[""MF_T1_ReferenceNo""].Man=true;ISpace[""MF_T1_Destination""].Man=true;ISpace[""MF_T1_AvailableBudget""].Man=true;ISpace[""MF_T1_AccountNo""].Man=true;ISpace[""MF_T1_TravellingPerson""].Man=true;ISpace[""MF_T1_JourneyPurpose""].Man=true;ISpace[""MF_T1_ProjectNo""].Man=true;ISpace[""MF_T1_AdvanceAmount""].Man=true;ISpace[""MF_T1_BankName""].Man=true;ISpace[""MF_T1_BankBranch""].Man=true;ISpace[""MF_T1_BankDocument""].Man=true;ISpace[""MF_T1_BudgetHead""].Man=true;");
}
if(ISpace["Travel_Type"].Value=="1")
{
base.WriteDebugInfo(@"if(ISpace[""Travel_Type""].Value==""1"")");
ISpace["MF_T1_BeneficiaryName"].Man=false;ISpace["MF_T1_AccountNo"].Man=false;ISpace["MF_T1_BankName"].Man=false;ISpace["MF_T1_BankBranch"].Man=false;ISpace["MF_T1_BankDocument"].Man=false;
base.WriteDebugInfo(@"ISpace[""MF_T1_BeneficiaryName""].Man=false;ISpace[""MF_T1_AccountNo""].Man=false;ISpace[""MF_T1_BankName""].Man=false;ISpace[""MF_T1_BankBranch""].Man=false;ISpace[""MF_T1_BankDocument""].Man=false;");
}
if(ISpace["Travel_Type"].Value=="3")
{
base.WriteDebugInfo(@"if(ISpace[""Travel_Type""].Value==""3"")");
ISpace["MF_T1_BeneficiaryName"].Man=true;ISpace["MF_T1_BeneficiaryName"].Enbl="true";ISpace["MF_T1_AccountNo"].Man=true;ISpace["MF_T1_AccountNo"].Enbl="true";ISpace["MF_T1_AdvanceAmount"].Man=true;ISpace["MF_T1_AdvanceAmount"].Enbl="true";ISpace["MF_T1_BankName"].Man=true;ISpace["MF_T1_BankName"].Enbl="true";ISpace["MF_T1_BankBranch"].Man=true;ISpace["MF_T1_BankBranch"].Enbl="true";ISpace["MF_T1_BankDocument"].Man=true;ISpace["MF_T1_BankDocument"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_T1_BeneficiaryName""].Man=true;ISpace[""MF_T1_BeneficiaryName""].Enbl=""true"";ISpace[""MF_T1_AccountNo""].Man=true;ISpace[""MF_T1_AccountNo""].Enbl=""true"";ISpace[""MF_T1_AdvanceAmount""].Man=true;ISpace[""MF_T1_AdvanceAmount""].Enbl=""true"";ISpace[""MF_T1_BankName""].Man=true;ISpace[""MF_T1_BankName""].Enbl=""true"";ISpace[""MF_T1_BankBranch""].Man=true;ISpace[""MF_T1_BankBranch""].Enbl=""true"";ISpace[""MF_T1_BankDocument""].Man=true;ISpace[""MF_T1_BankDocument""].Enbl=""true"";");
}
if(ISpace["M_SaveDomainData"].Value==0&&ISpace["M_IsflowReturned"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""M_SaveDomainData""].Value==0&&ISpace[""M_IsflowReturned""].Value==1)");
base.WriteDebugInfo(@"exec [SendReturnEmailForTS] '#MF_T1_TravelAdvanceID'");

var querySource7a376b7ecb572943c84b3046179e2a17 =GetQueryExpressionDataSource("7a376b7e-cb57-2943-c84b-3046179e2a17");
Dictionary<short,object> result7a376b7ecb572943c84b3046179e2a17=iSpace.ExecuteQuery(querySource7a376b7ecb572943c84b3046179e2a17,@"exec [SendReturnEmailForTS] '" + ISpace["MF_T1_TravelAdvanceID"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource7a376b7ecb572943c84b3046179e2a17 =GetQueryExpressionDataSource(""7a376b7e-cb57-2943-c84b-3046179e2a17"");Dictionary<short,object> result7a376b7ecb572943c84b3046179e2a17=iSpace.ExecuteQuery(querySource7a376b7ecb572943c84b3046179e2a17,@""exec [SendReturnEmailForTS] '"" + ISpace[""MF_T1_TravelAdvanceID""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result7a376b7ecb572943c84b3046179e2a17!=null) && (result7a376b7ecb572943c84b3046179e2a17.Count!=0))
{
if(result7a376b7ecb572943c84b3046179e2a17.ContainsKey(0))
ISpace["A"].Value = result7a376b7ecb572943c84b3046179e2a17[0];
}
else{
ISpace["A"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["M_IsAdvanceRequired"].Value=="Yes")
{
base.WriteDebugInfo(@"if(ISpace[""M_IsAdvanceRequired""].Value==""Yes"")");
ISpace["T_AdvanceDrawn"].Visible="true";
base.WriteDebugInfo(@"ISpace[""T_AdvanceDrawn""].Visible=""true"";");

}
else
{
base.WriteDebugInfo(@"else");
ISpace["T_AdvanceDrawn"].Visible="false";
base.WriteDebugInfo(@"ISpace[""T_AdvanceDrawn""].Visible=""false"";");

}
}
ISpace["M_IsAdvanceRequired"].Enbl="false";ISpace["Travel_Type"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""M_IsAdvanceRequired""].Enbl=""false"";ISpace[""Travel_Type""].Enbl=""false"";");
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
ISpace["Message"].Value=@"Move To should be mandatory";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Move To should be mandatory"";");
ISpace["IsCancelled"].Value = true; 

return;
base.WriteDebugInfo(@"ISpace[""IsCancelled""].Value = true; 

return;");
}
ISpace["MF_TravelStatus"].Value="A";
base.WriteDebugInfo(@"ISpace[""MF_TravelStatus""].Value=""A"";");
ISpace["M_IsCommitment"].Value=0;
base.WriteDebugInfo(@"ISpace[""M_IsCommitment""].Value=0;");
if(ISpace["M_SaveDomainData"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""M_SaveDomainData""].Value==1)");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC Repo198E5A8A61F54E7C92DD34146A7059EF '#M_ActualTransactionDate','#M_ActualTransactionDate','#R_ReferenceNo','#M_RandDTransactionNo','#OverAll_Total','#MF_TravelStatus','#M_ActualTransactionNo'");

var querySource451B4D6A015745DE996B9B03FB97D453 =GetQueryExpressionDataSource("451B4D6A-0157-45DE-996B-9B03FB97D453");
Dictionary<short,object> result451B4D6A015745DE996B9B03FB97D453=iSpace.ExecuteQuery(querySource451B4D6A015745DE996B9B03FB97D453,@"EXEC Repo198E5A8A61F54E7C92DD34146A7059EF '" + ISpace["M_ActualTransactionDate"].Value + @"','" + ISpace["M_ActualTransactionDate"].Value + @"','" + ISpace["R_ReferenceNo"].Value + @"','" + ISpace["M_RandDTransactionNo"].Value + @"','" + ISpace["OverAll_Total"].Value + @"','" + ISpace["MF_TravelStatus"].Value + @"','" + ISpace["M_ActualTransactionNo"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource451B4D6A015745DE996B9B03FB97D453 =GetQueryExpressionDataSource(""451B4D6A-0157-45DE-996B-9B03FB97D453"");Dictionary<short,object> result451B4D6A015745DE996B9B03FB97D453=iSpace.ExecuteQuery(querySource451B4D6A015745DE996B9B03FB97D453,@""EXEC Repo198E5A8A61F54E7C92DD34146A7059EF '"" + ISpace[""M_ActualTransactionDate""].Value + @""','"" + ISpace[""M_ActualTransactionDate""].Value + @""','"" + ISpace[""R_ReferenceNo""].Value + @""','"" + ISpace[""M_RandDTransactionNo""].Value + @""','"" + ISpace[""OverAll_Total""].Value + @""','"" + ISpace[""MF_TravelStatus""].Value + @""','"" + ISpace[""M_ActualTransactionNo""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result451B4D6A015745DE996B9B03FB97D453!=null) && (result451B4D6A015745DE996B9B03FB97D453.Count!=0))
{
}
else{

}
base.WriteDebugInfo(@"EXEC Repo374fb8a88dd94cf1bf73f40ae18fcad7 '#M_IsTravelRequest','#UpdatedOn','#MG_T2_TADetailsID','#gv_UserId','#MG_T2_DepartureDate','#MG_T2_DepartureTime','#MG_T2_ArrivalDate','#MG_T2_Road','#R_ReferenceNo','#MG_T2_Departure','#MG_T2_Amount','#MG_T2_JourneyClass','#MG_T2_Arrival','#MG_T2_PNRNo','#MG_T2_ModeofJourney','#MG_T2_ArrivalTime'");

var querySourceCA31643F8CD646EF9214A9D08E22313D =GetQueryExpressionDataSource("CA31643F-8CD6-46EF-9214-A9D08E22313D");
Dictionary<short,object> resultCA31643F8CD646EF9214A9D08E22313D=iSpace.ExecuteQuery(querySourceCA31643F8CD646EF9214A9D08E22313D,@"EXEC Repo374fb8a88dd94cf1bf73f40ae18fcad7 '" + ISpace["M_IsTravelRequest"].Value + @"','" + ISpace["UpdatedOn"].Value + @"','" + ISpace["MG_T2_TADetailsID"].Value + @"','" + ISpace["gv_UserId"].Value + @"','" + ISpace["MG_T2_DepartureDate"].Value + @"','" + ISpace["MG_T2_DepartureTime"].Value + @"','" + ISpace["MG_T2_ArrivalDate"].Value + @"','" + ISpace["MG_T2_Road"].Value + @"','" + ISpace["R_ReferenceNo"].Value + @"','" + ISpace["MG_T2_Departure"].Value + @"','" + ISpace["MG_T2_Amount"].Value + @"','" + ISpace["MG_T2_JourneyClass"].Value + @"','" + ISpace["MG_T2_Arrival"].Value + @"','" + ISpace["MG_T2_PNRNo"].Value + @"','" + ISpace["MG_T2_ModeofJourney"].Value + @"','" + ISpace["MG_T2_ArrivalTime"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceCA31643F8CD646EF9214A9D08E22313D =GetQueryExpressionDataSource(""CA31643F-8CD6-46EF-9214-A9D08E22313D"");Dictionary<short,object> resultCA31643F8CD646EF9214A9D08E22313D=iSpace.ExecuteQuery(querySourceCA31643F8CD646EF9214A9D08E22313D,@""EXEC Repo374fb8a88dd94cf1bf73f40ae18fcad7 '"" + ISpace[""M_IsTravelRequest""].Value + @""','"" + ISpace[""UpdatedOn""].Value + @""','"" + ISpace[""MG_T2_TADetailsID""].Value + @""','"" + ISpace[""gv_UserId""].Value + @""','"" + ISpace[""MG_T2_DepartureDate""].Value + @""','"" + ISpace[""MG_T2_DepartureTime""].Value + @""','"" + ISpace[""MG_T2_ArrivalDate""].Value + @""','"" + ISpace[""MG_T2_Road""].Value + @""','"" + ISpace[""R_ReferenceNo""].Value + @""','"" + ISpace[""MG_T2_Departure""].Value + @""','"" + ISpace[""MG_T2_Amount""].Value + @""','"" + ISpace[""MG_T2_JourneyClass""].Value + @""','"" + ISpace[""MG_T2_Arrival""].Value + @""','"" + ISpace[""MG_T2_PNRNo""].Value + @""','"" + ISpace[""MG_T2_ModeofJourney""].Value + @""','"" + ISpace[""MG_T2_ArrivalTime""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultCA31643F8CD646EF9214A9D08E22313D!=null) && (resultCA31643F8CD646EF9214A9D08E22313D.Count!=0))
{
}
else{

}
base.WriteDebugInfo(@"EXEC Repo51838b372ec64d358a5e38648bc93ab1 '#gv_UserId','#UpdatedOn','#R_ReferenceNo','#M_MiscDetails','#MG_T2_ToDate','#MG_T2_FromDate','#M_IsTravelRequest','#MG_T2_ExpenditureTypeID','#Expenditure_Type','#MG_T3_Amount'");

var querySourceD707F6E5B3364B14BB90DCBE65B38460 =GetQueryExpressionDataSource("D707F6E5-B336-4B14-BB90-DCBE65B38460");
Dictionary<short,object> resultD707F6E5B3364B14BB90DCBE65B38460=iSpace.ExecuteQuery(querySourceD707F6E5B3364B14BB90DCBE65B38460,@"EXEC Repo51838b372ec64d358a5e38648bc93ab1 '" + ISpace["gv_UserId"].Value + @"','" + ISpace["UpdatedOn"].Value + @"','" + ISpace["R_ReferenceNo"].Value + @"','" + ISpace["M_MiscDetails"].Value + @"','" + ISpace["MG_T2_ToDate"].Value + @"','" + ISpace["MG_T2_FromDate"].Value + @"','" + ISpace["M_IsTravelRequest"].Value + @"','" + ISpace["MG_T2_ExpenditureTypeID"].Value + @"','" + ISpace["Expenditure_Type"].Value + @"','" + ISpace["MG_T3_Amount"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceD707F6E5B3364B14BB90DCBE65B38460 =GetQueryExpressionDataSource(""D707F6E5-B336-4B14-BB90-DCBE65B38460"");Dictionary<short,object> resultD707F6E5B3364B14BB90DCBE65B38460=iSpace.ExecuteQuery(querySourceD707F6E5B3364B14BB90DCBE65B38460,@""EXEC Repo51838b372ec64d358a5e38648bc93ab1 '"" + ISpace[""gv_UserId""].Value + @""','"" + ISpace[""UpdatedOn""].Value + @""','"" + ISpace[""R_ReferenceNo""].Value + @""','"" + ISpace[""M_MiscDetails""].Value + @""','"" + ISpace[""MG_T2_ToDate""].Value + @""','"" + ISpace[""MG_T2_FromDate""].Value + @""','"" + ISpace[""M_IsTravelRequest""].Value + @""','"" + ISpace[""MG_T2_ExpenditureTypeID""].Value + @""','"" + ISpace[""Expenditure_Type""].Value + @""','"" + ISpace[""MG_T3_Amount""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultD707F6E5B3364B14BB90DCBE65B38460!=null) && (resultD707F6E5B3364B14BB90DCBE65B38460.Count!=0))
{
}
else{

}
base.WriteDebugInfo(@"EXEC DocumentsDomain '#M_DocumentDetailsId','#M_PackageProcessMapId','#UpdatedOn','#M_DocumentName','#gv_UserId','#M_UploadDcoument','#R_ReferenceNo'");

var querySource935F2074D9D84E08A4795C1D1110C173 =GetQueryExpressionDataSource("935F2074-D9D8-4E08-A479-5C1D1110C173");
Dictionary<short,object> result935F2074D9D84E08A4795C1D1110C173=iSpace.ExecuteQuery(querySource935F2074D9D84E08A4795C1D1110C173,@"EXEC DocumentsDomain '" + ISpace["M_DocumentDetailsId"].Value + @"','" + ISpace["M_PackageProcessMapId"].Value + @"','" + ISpace["UpdatedOn"].Value + @"','" + ISpace["M_DocumentName"].Value + @"','" + ISpace["gv_UserId"].Value + @"','" + ISpace["M_UploadDcoument"].Value + @"','" + ISpace["R_ReferenceNo"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource935F2074D9D84E08A4795C1D1110C173 =GetQueryExpressionDataSource(""935F2074-D9D8-4E08-A479-5C1D1110C173"");Dictionary<short,object> result935F2074D9D84E08A4795C1D1110C173=iSpace.ExecuteQuery(querySource935F2074D9D84E08A4795C1D1110C173,@""EXEC DocumentsDomain '"" + ISpace[""M_DocumentDetailsId""].Value + @""','"" + ISpace[""M_PackageProcessMapId""].Value + @""','"" + ISpace[""UpdatedOn""].Value + @""','"" + ISpace[""M_DocumentName""].Value + @""','"" + ISpace[""gv_UserId""].Value + @""','"" + ISpace[""M_UploadDcoument""].Value + @""','"" + ISpace[""R_ReferenceNo""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result935F2074D9D84E08A4795C1D1110C173!=null) && (result935F2074D9D84E08A4795C1D1110C173.Count!=0))
{
}
else{

}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"#MF_FundAmount[Rows]");
iSpace.GetLoopExpressionData("MF_FundAmount",ref ISpace);

foreach(var gridChild in ISpace["MF_FundAmount"].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 


if(
ISpace["MF_T1_AdvanceAmount"].Value<0)
{
base.WriteDebugInfo(@"
if(
ISpace[""MF_T1_AdvanceAmount""].Value<0)");
base.WriteDebugInfo(@"EXEC UpsertProjectBudgetDetails 9,'#MG_ProjectDetailsId','#R_ReferenceNo','#MG_Amount','#MG_BudgetHead','#M_IsCommitment','#MG_FundTypeid','#M_PackageProcessMapId','#UC_EmployeeBaicInfoId'");

var querySource899d988ff3827c8e861e1b768959533f =GetQueryExpressionDataSource("899d988f-f382-7c8e-861e-1b768959533f");
Dictionary<short,object> result899d988ff3827c8e861e1b768959533f=iSpace.ExecuteQuery(querySource899d988ff3827c8e861e1b768959533f,@"EXEC UpsertProjectBudgetDetails 9,'" + ISpace["MG_ProjectDetailsId"].Value + @"','" + ISpace["R_ReferenceNo"].Value + @"','" + ISpace["MG_Amount"].Value + @"','" + ISpace["MG_BudgetHead"].Value + @"','" + ISpace["M_IsCommitment"].Value + @"','" + ISpace["MG_FundTypeid"].Value + @"','" + ISpace["M_PackageProcessMapId"].Value + @"','" + ISpace["UC_EmployeeBaicInfoId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource899d988ff3827c8e861e1b768959533f =GetQueryExpressionDataSource(""899d988f-f382-7c8e-861e-1b768959533f"");Dictionary<short,object> result899d988ff3827c8e861e1b768959533f=iSpace.ExecuteQuery(querySource899d988ff3827c8e861e1b768959533f,@""EXEC UpsertProjectBudgetDetails 9,'"" + ISpace[""MG_ProjectDetailsId""].Value + @""','"" + ISpace[""R_ReferenceNo""].Value + @""','"" + ISpace[""MG_Amount""].Value + @""','"" + ISpace[""MG_BudgetHead""].Value + @""','"" + ISpace[""M_IsCommitment""].Value + @""','"" + ISpace[""MG_FundTypeid""].Value + @""','"" + ISpace[""M_PackageProcessMapId""].Value + @""','"" + ISpace[""UC_EmployeeBaicInfoId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result899d988ff3827c8e861e1b768959533f!=null) && (result899d988ff3827c8e861e1b768959533f.Count!=0))
{
if(result899d988ff3827c8e861e1b768959533f.ContainsKey(0))
ISpace["A"].Value = result899d988ff3827c8e861e1b768959533f[0];
}
else{
ISpace["A"].Value = null;
}
}
else
{
base.WriteDebugInfo(@"else");
base.WriteDebugInfo(@"EXEC UpsertProjectBudgetDetails 5,'#MG_ProjectDetailsId','#R_ReferenceNo','#MG_Amount','#MG_BudgetHead','#M_IsCommitment','#MG_FundTypeid','#M_PackageProcessMapId','#UC_EmployeeBaicInfoId'");

var querySourcec9219f16b139e53f19ec6f479fd577a9 =GetQueryExpressionDataSource("c9219f16-b139-e53f-19ec-6f479fd577a9");
Dictionary<short,object> resultc9219f16b139e53f19ec6f479fd577a9=iSpace.ExecuteQuery(querySourcec9219f16b139e53f19ec6f479fd577a9,@"EXEC UpsertProjectBudgetDetails 5,'" + ISpace["MG_ProjectDetailsId"].Value + @"','" + ISpace["R_ReferenceNo"].Value + @"','" + ISpace["MG_Amount"].Value + @"','" + ISpace["MG_BudgetHead"].Value + @"','" + ISpace["M_IsCommitment"].Value + @"','" + ISpace["MG_FundTypeid"].Value + @"','" + ISpace["M_PackageProcessMapId"].Value + @"','" + ISpace["UC_EmployeeBaicInfoId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourcec9219f16b139e53f19ec6f479fd577a9 =GetQueryExpressionDataSource(""c9219f16-b139-e53f-19ec-6f479fd577a9"");Dictionary<short,object> resultc9219f16b139e53f19ec6f479fd577a9=iSpace.ExecuteQuery(querySourcec9219f16b139e53f19ec6f479fd577a9,@""EXEC UpsertProjectBudgetDetails 5,'"" + ISpace[""MG_ProjectDetailsId""].Value + @""','"" + ISpace[""R_ReferenceNo""].Value + @""','"" + ISpace[""MG_Amount""].Value + @""','"" + ISpace[""MG_BudgetHead""].Value + @""','"" + ISpace[""M_IsCommitment""].Value + @""','"" + ISpace[""MG_FundTypeid""].Value + @""','"" + ISpace[""M_PackageProcessMapId""].Value + @""','"" + ISpace[""UC_EmployeeBaicInfoId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultc9219f16b139e53f19ec6f479fd577a9!=null) && (resultc9219f16b139e53f19ec6f479fd577a9.Count!=0))
{
if(resultc9219f16b139e53f19ec6f479fd577a9.ContainsKey(0))
ISpace["A"].Value = resultc9219f16b139e53f19ec6f479fd577a9[0];
}
else{
ISpace["A"].Value = null;
}
}
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("MF_FundAmount","0BFAF73B-02D4-4680-B1C9-625AAFB02DB5",_objectFactory.GetGridRPP("MF_FundAmount"),_elementBase.GetGridLoopQuery("0BFAF73B-02D4-4680-B1C9-625AAFB02DB5","MF_FundAmount",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""MF_FundAmount"",ref ISpace);

foreach(var gridChild in ISpace[""MF_FundAmount""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC RemarksDomain '#M_IsSourceStep','#Updatedon','#M_InstanceId','#gv_UserId','#SetDestinationTo','#gv_UserName','#gv_ActivityName','#M_Remarks','#gv_TenantId','#TrailLogId','#M_SourceActivityMapId','#RemarksOn'");

var querySourceCFCAC7935C3F430199EA29692D7A07E4 =GetQueryExpressionDataSource("CFCAC793-5C3F-4301-99EA-29692D7A07E4");
Dictionary<short,object> resultCFCAC7935C3F430199EA29692D7A07E4=iSpace.ExecuteQuery(querySourceCFCAC7935C3F430199EA29692D7A07E4,@"EXEC RemarksDomain '" + ISpace["M_IsSourceStep"].Value + @"','" + ISpace["Updatedon"].Value + @"','" + ISpace["M_InstanceId"].Value + @"','" + ISpace["gv_UserId"].Value + @"','" + ISpace["SetDestinationTo"].Value + @"','" + ISpace["gv_UserName"].Value + @"','" + ISpace["gv_ActivityName"].Value + @"','" + ISpace["M_Remarks"].Value + @"','" + ISpace["gv_TenantId"].Value + @"','" + ISpace["TrailLogId"].Value + @"','" + ISpace["M_SourceActivityMapId"].Value + @"','" + ISpace["RemarksOn"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceCFCAC7935C3F430199EA29692D7A07E4 =GetQueryExpressionDataSource(""CFCAC793-5C3F-4301-99EA-29692D7A07E4"");Dictionary<short,object> resultCFCAC7935C3F430199EA29692D7A07E4=iSpace.ExecuteQuery(querySourceCFCAC7935C3F430199EA29692D7A07E4,@""EXEC RemarksDomain '"" + ISpace[""M_IsSourceStep""].Value + @""','"" + ISpace[""Updatedon""].Value + @""','"" + ISpace[""M_InstanceId""].Value + @""','"" + ISpace[""gv_UserId""].Value + @""','"" + ISpace[""SetDestinationTo""].Value + @""','"" + ISpace[""gv_UserName""].Value + @""','"" + ISpace[""gv_ActivityName""].Value + @""','"" + ISpace[""M_Remarks""].Value + @""','"" + ISpace[""gv_TenantId""].Value + @""','"" + ISpace[""TrailLogId""].Value + @""','"" + ISpace[""M_SourceActivityMapId""].Value + @""','"" + ISpace[""RemarksOn""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultCFCAC7935C3F430199EA29692D7A07E4!=null) && (resultCFCAC7935C3F430199EA29692D7A07E4.Count!=0))
{
}
else{

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
if(ISpace["M_IsFlowReturned"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""M_IsFlowReturned""].Value==1)");
base.WriteDebugInfo(@"#MF_FundAmount[Rows]");
iSpace.GetLoopExpressionData("MF_FundAmount",ref ISpace);

foreach(var gridChild in ISpace["MF_FundAmount"].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 

base.WriteDebugInfo(@"EXEC UpsertProjectBudgetDetails 6,'#MG_ProjectDetailsId','#R_ReferenceNo','#MG_Amount','#MG_BudgetHead','1','#MG_FundTypeid','#M_PackageProcessMapId','#UC_EmployeeBaicInfoId'");

var querySourceBD4FA2562A90453781F7851553AB7968 =GetQueryExpressionDataSource("BD4FA256-2A90-4537-81F7-851553AB7968");
Dictionary<short,object> resultBD4FA2562A90453781F7851553AB7968=iSpace.ExecuteQuery(querySourceBD4FA2562A90453781F7851553AB7968,@"EXEC UpsertProjectBudgetDetails 6,'" + ISpace["MG_ProjectDetailsId"].Value + @"','" + ISpace["R_ReferenceNo"].Value + @"','" + ISpace["MG_Amount"].Value + @"','" + ISpace["MG_BudgetHead"].Value + @"','1','" + ISpace["MG_FundTypeid"].Value + @"','" + ISpace["M_PackageProcessMapId"].Value + @"','" + ISpace["UC_EmployeeBaicInfoId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceBD4FA2562A90453781F7851553AB7968 =GetQueryExpressionDataSource(""BD4FA256-2A90-4537-81F7-851553AB7968"");Dictionary<short,object> resultBD4FA2562A90453781F7851553AB7968=iSpace.ExecuteQuery(querySourceBD4FA2562A90453781F7851553AB7968,@""EXEC UpsertProjectBudgetDetails 6,'"" + ISpace[""MG_ProjectDetailsId""].Value + @""','"" + ISpace[""R_ReferenceNo""].Value + @""','"" + ISpace[""MG_Amount""].Value + @""','"" + ISpace[""MG_BudgetHead""].Value + @""','1','"" + ISpace[""MG_FundTypeid""].Value + @""','"" + ISpace[""M_PackageProcessMapId""].Value + @""','"" + ISpace[""UC_EmployeeBaicInfoId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultBD4FA2562A90453781F7851553AB7968!=null) && (resultBD4FA2562A90453781F7851553AB7968.Count!=0))
{
if(resultBD4FA2562A90453781F7851553AB7968.ContainsKey(0))
ISpace["A"].Value = resultBD4FA2562A90453781F7851553AB7968[0];
}
else{
ISpace["A"].Value = null;
}
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("MF_FundAmount","0BFAF73B-02D4-4680-B1C9-625AAFB02DB5",_objectFactory.GetGridRPP("MF_FundAmount"),_elementBase.GetGridLoopQuery("0BFAF73B-02D4-4680-B1C9-625AAFB02DB5","MF_FundAmount",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""MF_FundAmount"",ref ISpace);

foreach(var gridChild in ISpace[""MF_FundAmount""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
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
base.WriteDebugInfo(@"EXEC UserRequestForOtherStep '#M_NextStage','#M_Status','#gv_UserId','#SetDestinationTo','#M_InstanceId','#LastModifiedOn'");

var querySource26121ea8dc1b0c613f1e2020d59e6348 =GetQueryExpressionDataSource("26121ea8-dc1b-0c61-3f1e-2020d59e6348");
Dictionary<short,object> result26121ea8dc1b0c613f1e2020d59e6348=iSpace.ExecuteQuery(querySource26121ea8dc1b0c613f1e2020d59e6348,@"EXEC UserRequestForOtherStep '" + ISpace["M_NextStage"].Value + @"','" + ISpace["M_Status"].Value + @"','" + ISpace["gv_UserId"].Value + @"','" + ISpace["SetDestinationTo"].Value + @"','" + ISpace["M_InstanceId"].Value + @"','" + ISpace["LastModifiedOn"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource26121ea8dc1b0c613f1e2020d59e6348 =GetQueryExpressionDataSource(""26121ea8-dc1b-0c61-3f1e-2020d59e6348"");Dictionary<short,object> result26121ea8dc1b0c613f1e2020d59e6348=iSpace.ExecuteQuery(querySource26121ea8dc1b0c613f1e2020d59e6348,@""EXEC UserRequestForOtherStep '"" + ISpace[""M_NextStage""].Value + @""','"" + ISpace[""M_Status""].Value + @""','"" + ISpace[""gv_UserId""].Value + @""','"" + ISpace[""SetDestinationTo""].Value + @""','"" + ISpace[""M_InstanceId""].Value + @""','"" + ISpace[""LastModifiedOn""].Value + @""'"",false);");
ISpace["Message"].Value=@"Submitted Successfully";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Submitted Successfully"";");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_edit_travelexpense (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Edit_TravelExpense-OnClick");
ISpace["growid"].Value=ISpace["TravelExpense_RowId"].Value;
base.WriteDebugInfo(@"ISpace[""growid""].Value=ISpace[""TravelExpense_RowId""].Value;");
base.WriteDebugInfo(@"EXEC [LoadFormGridData9F49372F-0255-42EC-AB05-31E6C4F9F2EA] '@@gv_InstanceId','@@gv_ProcessMapId','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','@@gv_ActivityMapId','#growid'");

var querySourceED15FA1FD7F94F6A9FC435EEE23FA142 =GetQueryExpressionDataSource("ED15FA1F-D7F9-4F6A-9FC4-35EEE23FA142");
Dictionary<short,object> resultED15FA1FD7F94F6A9FC435EEE23FA142=iSpace.ExecuteQuery(querySourceED15FA1FD7F94F6A9FC435EEE23FA142,@"EXEC [LoadFormGridData9F49372F-0255-42EC-AB05-31E6C4F9F2EA] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["growid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceED15FA1FD7F94F6A9FC435EEE23FA142 =GetQueryExpressionDataSource(""ED15FA1F-D7F9-4F6A-9FC4-35EEE23FA142"");Dictionary<short,object> resultED15FA1FD7F94F6A9FC435EEE23FA142=iSpace.ExecuteQuery(querySourceED15FA1FD7F94F6A9FC435EEE23FA142,@""EXEC [LoadFormGridData9F49372F-0255-42EC-AB05-31E6C4F9F2EA] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""growid""].Value + @""'"",false);");
base.WriteDebugInfo(@"EXEC LoadFormGridData374fb8a88dd94cf1bf73f40ae18fcad7 '@@gv_InstanceId','@@gv_ProcessMapId','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','@@gv_ActivityMapId','#growid'");

if((resultED15FA1FD7F94F6A9FC435EEE23FA142!=null) && (resultED15FA1FD7F94F6A9FC435EEE23FA142.Count!=0))
{
if(resultED15FA1FD7F94F6A9FC435EEE23FA142.ContainsKey(6))
ISpace["MFG_T2_ArrivalDate"].Value = resultED15FA1FD7F94F6A9FC435EEE23FA142[6];
if(resultED15FA1FD7F94F6A9FC435EEE23FA142.ContainsKey(3))
ISpace["MFG_T2_DepartureDate"].Value = resultED15FA1FD7F94F6A9FC435EEE23FA142[3];
if(resultED15FA1FD7F94F6A9FC435EEE23FA142.ContainsKey(8))
ISpace["MFG_T2_ModeofJourney"].Value = resultED15FA1FD7F94F6A9FC435EEE23FA142[8];
if(resultED15FA1FD7F94F6A9FC435EEE23FA142.ContainsKey(9))
ISpace["MFG_T2_JourneyClass"].Value = resultED15FA1FD7F94F6A9FC435EEE23FA142[9];
if(resultED15FA1FD7F94F6A9FC435EEE23FA142.ContainsKey(10))
ISpace["MFG_T2_Road"].Value = resultED15FA1FD7F94F6A9FC435EEE23FA142[10];
if(resultED15FA1FD7F94F6A9FC435EEE23FA142.ContainsKey(12))
ISpace["MFG_T2_Amount"].Value = resultED15FA1FD7F94F6A9FC435EEE23FA142[12];
if(resultED15FA1FD7F94F6A9FC435EEE23FA142.ContainsKey(1))
ISpace["MFG_T2_TravelAdvanceID"].Value = resultED15FA1FD7F94F6A9FC435EEE23FA142[1];
if(resultED15FA1FD7F94F6A9FC435EEE23FA142.ContainsKey(2))
ISpace["MFG_T2_Departure"].Value = resultED15FA1FD7F94F6A9FC435EEE23FA142[2];
if(resultED15FA1FD7F94F6A9FC435EEE23FA142.ContainsKey(11))
ISpace["MFG_T2_PNRNo"].Value = resultED15FA1FD7F94F6A9FC435EEE23FA142[11];
if(resultED15FA1FD7F94F6A9FC435EEE23FA142.ContainsKey(7))
ISpace["MFG_T2_ArrivalTime"].Value = resultED15FA1FD7F94F6A9FC435EEE23FA142[7];
if(resultED15FA1FD7F94F6A9FC435EEE23FA142.ContainsKey(4))
ISpace["MFG_T2_DepartureTime"].Value = resultED15FA1FD7F94F6A9FC435EEE23FA142[4];
if(resultED15FA1FD7F94F6A9FC435EEE23FA142.ContainsKey(5))
ISpace["MFG_T2_Arrival"].Value = resultED15FA1FD7F94F6A9FC435EEE23FA142[5];
if(resultED15FA1FD7F94F6A9FC435EEE23FA142.ContainsKey(0))
ISpace["MFG_T2_TADetailsID"].Value = resultED15FA1FD7F94F6A9FC435EEE23FA142[0];
}
else{
ISpace["MFG_T2_ArrivalDate"].Value = null;ISpace["MFG_T2_DepartureDate"].Value = null;ISpace["MFG_T2_ModeofJourney"].Value = null;ISpace["MFG_T2_JourneyClass"].Value = null;ISpace["MFG_T2_Road"].Value = null;ISpace["MFG_T2_Amount"].Value = null;ISpace["MFG_T2_TravelAdvanceID"].Value = null;ISpace["MFG_T2_Departure"].Value = null;ISpace["MFG_T2_PNRNo"].Value = null;ISpace["MFG_T2_ArrivalTime"].Value = null;ISpace["MFG_T2_DepartureTime"].Value = null;ISpace["MFG_T2_Arrival"].Value = null;ISpace["MFG_T2_TADetailsID"].Value = null;
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_save_travelexpense (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Save_TravelExpense-OnClick");
if(ISpace["growid"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""growid""].Value=="""")");

var querySource47DEECA98E4E4FDE806BD716B4F25534 =GetQueryExpressionDataSource("47DEECA9-8E4E-4FDE-806B-D716B4F25534");

DataTable result47DEECA98E4E4FDE806BD716B4F25534=iSpace.SetGridDataSource(querySource47DEECA98E4E4FDE806BD716B4F25534, _objectFactory.GetGridRPP("TravelExpense"),@"EXEC [AddFormGridData9F49372F-0255-42EC-AB05-31E6C4F9F2EA] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["MFG_T2_TADetailsID"].Value + @"','" + ISpace["MFG_T2_TravelAdvanceID"].Value + @"','" + ISpace["MFG_T2_Departure"].Value + @"','" + ISpace["MFG_T2_DepartureDate"].Value + @"','" + ISpace["MFG_T2_DepartureTime"].Value + @"','" + ISpace["MFG_T2_Arrival"].Value + @"','" + ISpace["MFG_T2_ArrivalDate"].Value + @"','" + ISpace["MFG_T2_ArrivalTime"].Value + @"','" + ISpace["MFG_T2_ModeofJourney"].Value + @"','" + ISpace["MFG_T2_JourneyClass"].Value + @"'," + ISpace["MFG_T2_Road"].Value + @",'" + ISpace["MFG_T2_PNRNo"].Value + @"'," + ISpace["MFG_T2_Amount"].Value + @",'" + ISpace["growid"].Value + @"'");

iSpace.InsertGridBindDetails("TravelExpense","11",querySource47DEECA98E4E4FDE806BD716B4F25534,"EXEC [AddFormGridData9F49372F-0255-42EC-AB05-31E6C4F9F2EA] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["MFG_T2_TADetailsID"].Value + @"','" + ISpace["MFG_T2_TravelAdvanceID"].Value + @"','" + ISpace["MFG_T2_Departure"].Value + @"','" + ISpace["MFG_T2_DepartureDate"].Value + @"','" + ISpace["MFG_T2_DepartureTime"].Value + @"','" + ISpace["MFG_T2_Arrival"].Value + @"','" + ISpace["MFG_T2_ArrivalDate"].Value + @"','" + ISpace["MFG_T2_ArrivalTime"].Value + @"','" + ISpace["MFG_T2_ModeofJourney"].Value + @"','" + ISpace["MFG_T2_JourneyClass"].Value + @"'," + ISpace["MFG_T2_Road"].Value + @",'" + ISpace["MFG_T2_PNRNo"].Value + @"'," + ISpace["MFG_T2_Amount"].Value + @",'" + ISpace["growid"].Value + @"'",_objectFactory.GetGridRPP("TravelExpense"));

base.WriteDebugInfo(@"var querySource47DEECA98E4E4FDE806BD716B4F25534 =GetQueryExpressionDataSource(""47DEECA9-8E4E-4FDE-806B-D716B4F25534"");DataTable result47DEECA98E4E4FDE806BD716B4F25534=iSpace.SetGridDataSource(querySource47DEECA98E4E4FDE806BD716B4F25534, _objectFactory.GetGridRPP(""TravelExpense""),@""EXEC [AddFormGridData9F49372F-0255-42EC-AB05-31E6C4F9F2EA] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""MFG_T2_TADetailsID""].Value + @""','"" + ISpace[""MFG_T2_TravelAdvanceID""].Value + @""','"" + ISpace[""MFG_T2_Departure""].Value + @""','"" + ISpace[""MFG_T2_DepartureDate""].Value + @""','"" + ISpace[""MFG_T2_DepartureTime""].Value + @""','"" + ISpace[""MFG_T2_Arrival""].Value + @""','"" + ISpace[""MFG_T2_ArrivalDate""].Value + @""','"" + ISpace[""MFG_T2_ArrivalTime""].Value + @""','"" + ISpace[""MFG_T2_ModeofJourney""].Value + @""','"" + ISpace[""MFG_T2_JourneyClass""].Value + @""',"" + ISpace[""MFG_T2_Road""].Value + @"",'"" + ISpace[""MFG_T2_PNRNo""].Value + @""',"" + ISpace[""MFG_T2_Amount""].Value + @"",'"" + ISpace[""growid""].Value + @""'"");iSpace.InsertGridBindDetails(""TravelExpense"",""11"",querySource47DEECA98E4E4FDE806BD716B4F25534,""EXEC [AddFormGridData9F49372F-0255-42EC-AB05-31E6C4F9F2EA] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""MFG_T2_TADetailsID""].Value + @""','"" + ISpace[""MFG_T2_TravelAdvanceID""].Value + @""','"" + ISpace[""MFG_T2_Departure""].Value + @""','"" + ISpace[""MFG_T2_DepartureDate""].Value + @""','"" + ISpace[""MFG_T2_DepartureTime""].Value + @""','"" + ISpace[""MFG_T2_Arrival""].Value + @""','"" + ISpace[""MFG_T2_ArrivalDate""].Value + @""','"" + ISpace[""MFG_T2_ArrivalTime""].Value + @""','"" + ISpace[""MFG_T2_ModeofJourney""].Value + @""','"" + ISpace[""MFG_T2_JourneyClass""].Value + @""',"" + ISpace[""MFG_T2_Road""].Value + @"",'"" + ISpace[""MFG_T2_PNRNo""].Value + @""',"" + ISpace[""MFG_T2_Amount""].Value + @"",'"" + ISpace[""growid""].Value + @""'"",_objectFactory.GetGridRPP(""TravelExpense""));");
base.WriteDebugInfo(@"EXEC AddFormGridData374fb8a88dd94cf1bf73f40ae18fcad7 '@@gv_InstanceId','@@gv_ProcessMapId','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','@@gv_ActivityMapId','#MFG_T2_TADetailsID','#MFG_T2_TravelAdvanceID','#MFG_T2_Departure','#MFG_T2_DepartureDate','#MFG_T2_DepartureTime','#MFG_T2_Arrival','#MFG_T2_ArrivalDate','#MFG_T2_ArrivalTime','#MFG_T2_ModeofJourney','#MFG_T2_JourneyClass',#MFG_T2_Road,'#MFG_T2_PNRNo',#MFG_T3_Amount,'#growid'");


List<Triplet<string, short, short?>> result5FF52A9FC7A9483893076D31A18D61AB=acdataIspaceF5D55501419C4E8D97D9EFE380D7D47D.GetQueryExpressionBindings("5FF52A9F-C7A9-4838-9307-6D31A18D61AB");
iSpace.SetGridData(result47DEECA98E4E4FDE806BD716B4F25534,result5FF52A9FC7A9483893076D31A18D61AB,"TravelExpense",ref ISpace);
iSpace.UpdateGridBindDetails("TravelExpense",result5FF52A9FC7A9483893076D31A18D61AB);
}
else
{
base.WriteDebugInfo(@"else");

var querySource68C5D0A58E3049AB91AD12CEEA91048F =GetQueryExpressionDataSource("68C5D0A5-8E30-49AB-91AD-12CEEA91048F");

DataTable result68C5D0A58E3049AB91AD12CEEA91048F=iSpace.SetGridDataSource(querySource68C5D0A58E3049AB91AD12CEEA91048F, _objectFactory.GetGridRPP("TravelExpense"),@"EXEC [UpdateFormGridData9F49372F-0255-42EC-AB05-31E6C4F9F2EA] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["MFG_T2_TADetailsID"].Value + @"','" + ISpace["MFG_T2_TravelAdvanceID"].Value + @"','" + ISpace["MFG_T2_Departure"].Value + @"','" + ISpace["MFG_T2_DepartureDate"].Value + @"','" + ISpace["MFG_T2_DepartureTime"].Value + @"','" + ISpace["MFG_T2_Arrival"].Value + @"','" + ISpace["MFG_T2_ArrivalDate"].Value + @"','" + ISpace["MFG_T2_ArrivalTime"].Value + @"','" + ISpace["MFG_T2_ModeofJourney"].Value + @"','" + ISpace["MFG_T2_JourneyClass"].Value + @"'," + ISpace["MFG_T2_Road"].Value + @",'" + ISpace["MFG_T2_PNRNo"].Value + @"'," + ISpace["MFG_T2_Amount"].Value + @",'" + ISpace["growid"].Value + @"'");

iSpace.InsertGridBindDetails("TravelExpense","11",querySource68C5D0A58E3049AB91AD12CEEA91048F,"EXEC [UpdateFormGridData9F49372F-0255-42EC-AB05-31E6C4F9F2EA] '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["MFG_T2_TADetailsID"].Value + @"','" + ISpace["MFG_T2_TravelAdvanceID"].Value + @"','" + ISpace["MFG_T2_Departure"].Value + @"','" + ISpace["MFG_T2_DepartureDate"].Value + @"','" + ISpace["MFG_T2_DepartureTime"].Value + @"','" + ISpace["MFG_T2_Arrival"].Value + @"','" + ISpace["MFG_T2_ArrivalDate"].Value + @"','" + ISpace["MFG_T2_ArrivalTime"].Value + @"','" + ISpace["MFG_T2_ModeofJourney"].Value + @"','" + ISpace["MFG_T2_JourneyClass"].Value + @"'," + ISpace["MFG_T2_Road"].Value + @",'" + ISpace["MFG_T2_PNRNo"].Value + @"'," + ISpace["MFG_T2_Amount"].Value + @",'" + ISpace["growid"].Value + @"'",_objectFactory.GetGridRPP("TravelExpense"));

base.WriteDebugInfo(@"var querySource68C5D0A58E3049AB91AD12CEEA91048F =GetQueryExpressionDataSource(""68C5D0A5-8E30-49AB-91AD-12CEEA91048F"");DataTable result68C5D0A58E3049AB91AD12CEEA91048F=iSpace.SetGridDataSource(querySource68C5D0A58E3049AB91AD12CEEA91048F, _objectFactory.GetGridRPP(""TravelExpense""),@""EXEC [UpdateFormGridData9F49372F-0255-42EC-AB05-31E6C4F9F2EA] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""MFG_T2_TADetailsID""].Value + @""','"" + ISpace[""MFG_T2_TravelAdvanceID""].Value + @""','"" + ISpace[""MFG_T2_Departure""].Value + @""','"" + ISpace[""MFG_T2_DepartureDate""].Value + @""','"" + ISpace[""MFG_T2_DepartureTime""].Value + @""','"" + ISpace[""MFG_T2_Arrival""].Value + @""','"" + ISpace[""MFG_T2_ArrivalDate""].Value + @""','"" + ISpace[""MFG_T2_ArrivalTime""].Value + @""','"" + ISpace[""MFG_T2_ModeofJourney""].Value + @""','"" + ISpace[""MFG_T2_JourneyClass""].Value + @""',"" + ISpace[""MFG_T2_Road""].Value + @"",'"" + ISpace[""MFG_T2_PNRNo""].Value + @""',"" + ISpace[""MFG_T2_Amount""].Value + @"",'"" + ISpace[""growid""].Value + @""'"");iSpace.InsertGridBindDetails(""TravelExpense"",""11"",querySource68C5D0A58E3049AB91AD12CEEA91048F,""EXEC [UpdateFormGridData9F49372F-0255-42EC-AB05-31E6C4F9F2EA] '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""MFG_T2_TADetailsID""].Value + @""','"" + ISpace[""MFG_T2_TravelAdvanceID""].Value + @""','"" + ISpace[""MFG_T2_Departure""].Value + @""','"" + ISpace[""MFG_T2_DepartureDate""].Value + @""','"" + ISpace[""MFG_T2_DepartureTime""].Value + @""','"" + ISpace[""MFG_T2_Arrival""].Value + @""','"" + ISpace[""MFG_T2_ArrivalDate""].Value + @""','"" + ISpace[""MFG_T2_ArrivalTime""].Value + @""','"" + ISpace[""MFG_T2_ModeofJourney""].Value + @""','"" + ISpace[""MFG_T2_JourneyClass""].Value + @""',"" + ISpace[""MFG_T2_Road""].Value + @"",'"" + ISpace[""MFG_T2_PNRNo""].Value + @""',"" + ISpace[""MFG_T2_Amount""].Value + @"",'"" + ISpace[""growid""].Value + @""'"",_objectFactory.GetGridRPP(""TravelExpense""));");
base.WriteDebugInfo(@"EXEC UpdateFormGridData374fb8a88dd94cf1bf73f40ae18fcad7 '@@gv_InstanceId','@@gv_ProcessMapId','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','@@gv_ActivityMapId','#MFG_T2_TADetailsID','#MFG_T2_TravelAdvanceID','#MFG_T2_Departure','#MFG_T2_DepartureDate','#MFG_T2_DepartureTime','#MFG_T2_Arrival','#MFG_T2_ArrivalDate','#MFG_T2_ArrivalTime','#MFG_T2_ModeofJourney','#MFG_T2_JourneyClass',#MFG_T2_Road,'#MFG_T2_PNRNo',#MFG_T3_Amount,'#growid'");


List<Triplet<string, short, short?>> resultDA3CF2FEBFBD482BB0D7A4FADF01F4B2=acdataIspaceF5D55501419C4E8D97D9EFE380D7D47D.GetQueryExpressionBindings("DA3CF2FE-BFBD-482B-B0D7-A4FADF01F4B2");
iSpace.SetGridData(result68C5D0A58E3049AB91AD12CEEA91048F,resultDA3CF2FEBFBD482BB0D7A4FADF01F4B2,"TravelExpense",ref ISpace);
iSpace.UpdateGridBindDetails("TravelExpense",resultDA3CF2FEBFBD482BB0D7A4FADF01F4B2);
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["growid"].Value="";
base.WriteDebugInfo(@"ISpace[""growid""].Value="""";");
}
ISpace["growid"].Value="";
base.WriteDebugInfo(@"ISpace[""growid""].Value="""";");
ISpace["MFG_T2_TADetailsID"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_T2_TADetailsID""].Value="""";");
ISpace["MFG_T2_TravelAdvanceID"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_T2_TravelAdvanceID""].Value="""";");
ISpace["MFG_T2_Departure"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_T2_Departure""].Value="""";");
ISpace["MFG_T2_DepartureDate"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_T2_DepartureDate""].Value="""";");
ISpace["MFG_T2_DepartureTime"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_T2_DepartureTime""].Value="""";");
ISpace["MFG_T2_Arrival"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_T2_Arrival""].Value="""";");
ISpace["MFG_T2_ArrivalDate"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_T2_ArrivalDate""].Value="""";");
ISpace["MFG_T2_ArrivalTime"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_T2_ArrivalTime""].Value="""";");
ISpace["MFG_T2_ModeofJourney"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_T2_ModeofJourney""].Value="""";");
ISpace["MFG_T2_JourneyClass"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_T2_JourneyClass""].Value="""";");
ISpace["MFG_T2_Road"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_T2_Road""].Value="""";");
ISpace["MFG_T2_PNRNo"].Value="";
base.WriteDebugInfo(@"ISpace[""MFG_T2_PNRNo""].Value="""";");
ISpace["MFG_T2_Amount"].Value=null;
base.WriteDebugInfo(@"ISpace[""MFG_T2_Amount""].Value=null;");
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

var querySource427807408C6F4DABBF411EB6F16F1F21 =GetQueryExpressionDataSource("42780740-8C6F-4DAB-BF41-1EB6F16F1F21");
Dictionary<short,object> result427807408C6F4DABBF411EB6F16F1F21=iSpace.ExecuteQuery(querySource427807408C6F4DABBF411EB6F16F1F21,@"Exec GetStageStatus 1,'','','" + ISpace["M_MoveToValue"].Value + @"','" + ISpace["M_SourceActivityMapId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource427807408C6F4DABBF411EB6F16F1F21 =GetQueryExpressionDataSource(""42780740-8C6F-4DAB-BF41-1EB6F16F1F21"");Dictionary<short,object> result427807408C6F4DABBF411EB6F16F1F21=iSpace.ExecuteQuery(querySource427807408C6F4DABBF411EB6F16F1F21,@""Exec GetStageStatus 1,'','','"" + ISpace[""M_MoveToValue""].Value + @""','"" + ISpace[""M_SourceActivityMapId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result427807408C6F4DABBF411EB6F16F1F21!=null) && (result427807408C6F4DABBF411EB6F16F1F21.Count!=0))
{
if(result427807408C6F4DABBF411EB6F16F1F21.ContainsKey(4))
ISpace["M_FieldMandatory"].Value = result427807408C6F4DABBF411EB6F16F1F21[4];
if(result427807408C6F4DABBF411EB6F16F1F21.ContainsKey(5))
ISpace["M_IsFlowReturned"].Value = result427807408C6F4DABBF411EB6F16F1F21[5];
if(result427807408C6F4DABBF411EB6F16F1F21.ContainsKey(1))
ISpace["M_RemarksMandatory"].Value = result427807408C6F4DABBF411EB6F16F1F21[1];
if(result427807408C6F4DABBF411EB6F16F1F21.ContainsKey(6))
ISpace["M_IsCancelReject"].Value = result427807408C6F4DABBF411EB6F16F1F21[6];
if(result427807408C6F4DABBF411EB6F16F1F21.ContainsKey(3))
ISpace["M_SaveDomainData"].Value = result427807408C6F4DABBF411EB6F16F1F21[3];
if(result427807408C6F4DABBF411EB6F16F1F21.ContainsKey(0))
ISpace["M_NextStage"].Value = result427807408C6F4DABBF411EB6F16F1F21[0];
if(result427807408C6F4DABBF411EB6F16F1F21.ContainsKey(2))
ISpace["M_Remarks"].Value = result427807408C6F4DABBF411EB6F16F1F21[2];
}
else{
ISpace["M_FieldMandatory"].Value = null;ISpace["M_IsFlowReturned"].Value = null;ISpace["M_RemarksMandatory"].Value = null;ISpace["M_IsCancelReject"].Value = null;ISpace["M_SaveDomainData"].Value = null;ISpace["M_NextStage"].Value = null;ISpace["M_Remarks"].Value = null;
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
		if(elementName.ToLower().Equals("edit_travelexpense"))
{
			SubscribeElementEvents_edit_travelexpense(ref dfsParam);
}
		if(elementName.ToLower().Equals("save_travelexpense"))
{
			SubscribeElementEvents_save_travelexpense(ref dfsParam);
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
	
using System;
    using System.Collections.Generic;    
    using System.Text;	
    using System.Linq;	


	public partial class AcDataISpace0D9E568F8790489DA8463C6057A39268  : ExtensionActivityBase
	{		
		
		
		private Dictionary<string,  List<Triplet<string, short, short?>>> queryExpressionBindings = 
											new Dictionary<string,  List<Triplet<string, short, short?>>>
		{
							{"20b66f20-2421-f3a1-2150-d1af5746d196", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_L1_Expenditure_Type",5,
														   -1),
								   new Triplet<string, short, short?>("MG_L1_FromDate",2,
														   -1),
								   new Triplet<string, short, short?>("MG_L1_OEAmount",4,
														   -1),
								   new Triplet<string, short, short?>("MG_L1_ToDate",3,
														   -1),
								}
			},
							{"33B5DB3C-C035-4454-8035-C74029C72FC1", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_Balance",6,
														   -1),
								   new Triplet<string, short, short?>("MG_BudgetName",0,
														   -1),
								   new Triplet<string, short, short?>("MG_Commitment",4,
														   -1),
								   new Triplet<string, short, short?>("MG_ReceivedAmount",3,
														   -1),
								   new Triplet<string, short, short?>("MG_SanctionedAmount",1,
														   -1),
								   new Triplet<string, short, short?>("MG_Spent",5,
														   -1),
								   new Triplet<string, short, short?>("MG_YetToReceive",2,
														   -1),
								}
			},
							{"4ae98202-ec93-624f-f546-c36904d7b1f5", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_L1_BudgetHead",7,
														   -1),
								   new Triplet<string, short, short?>("MG_L1_FTAmount",6,
														   -1),
								   new Triplet<string, short, short?>("MG_L1_FundDetailsID",0,
														   -1),
								   new Triplet<string, short, short?>("MG_L1_FundType",4,
														   -1),
								   new Triplet<string, short, short?>("MG_L1_FundTypeId",3,
														   -1),
								   new Triplet<string, short, short?>("MG_L1_ProjectDesc",5,
														   -1),
								   new Triplet<string, short, short?>("MG_L1_ProjectDetailsId",2,
														   -1),
								}
			},
							{"5FF52A9F-C7A9-4838-9307-6D31A18D61AB", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_T2_Amount",12,
														   -1),
								   new Triplet<string, short, short?>("MG_T2_Arrival",5,
														   -1),
								   new Triplet<string, short, short?>("MG_T2_ArrivalDate",6,
														   -1),
								   new Triplet<string, short, short?>("MG_T2_ArrivalTime",7,
														   -1),
								   new Triplet<string, short, short?>("MG_T2_Departure",2,
														   -1),
								   new Triplet<string, short, short?>("MG_T2_DepartureDate",3,
														   -1),
								   new Triplet<string, short, short?>("MG_T2_DepartureTime",4,
														   -1),
								   new Triplet<string, short, short?>("MG_T2_JourneyClass",9,
														   -1),
								   new Triplet<string, short, short?>("MG_T2_ModeofJourney",8,
														   -1),
								   new Triplet<string, short, short?>("MG_T2_PNRNo",11,
														   -1),
								   new Triplet<string, short, short?>("MG_T2_Road",10,
														   -1),
								   new Triplet<string, short, short?>("MG_T2_TADetailsID",0,
														   -1),
								   new Triplet<string, short, short?>("MG_T3_TravelAdvanceID",1,
														   -1),
								   new Triplet<string, short, short?>("TravelExpense_RowId",13,
														   -1),
								}
			},
							{"64882DB7-7438-47AA-BD14-85B89B960F95", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("Expenditure_Type",0,
														   -1),
								   new Triplet<string, short, short?>("MG_T2_FromDate",2,
														   -1),
								   new Triplet<string, short, short?>("MG_T2_ToDate",3,
														   -1),
								   new Triplet<string, short, short?>("MG_T2_TravelAdvanceID",1,
														   -1),
								   new Triplet<string, short, short?>("MG_T3_Amount",4,
														   -1),
								   new Triplet<string, short, short?>("MG_T3_MiscDetails",6,
														   -1),
								   new Triplet<string, short, short?>("OtherExpense_RowId",5,
														   -1),
								}
			},
							{"6576B664-6EA0-465A-B088-222E2C22B535", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("Expenditure_Type",0,
														   -1),
								   new Triplet<string, short, short?>("MG_T2_FromDate",2,
														   -1),
								   new Triplet<string, short, short?>("MG_T2_ToDate",3,
														   -1),
								   new Triplet<string, short, short?>("MG_T2_TravelAdvanceID",1,
														   -1),
								   new Triplet<string, short, short?>("MG_T3_Amount",4,
														   -1),
								   new Triplet<string, short, short?>("MG_T3_MiscDetails",6,
														   -1),
								   new Triplet<string, short, short?>("OtherExpense_RowId",5,
														   -1),
								}
			},
							{"660A5B65-7E36-4792-BC4A-F2BBCA0468A9", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_Amount",6,
														   -1),
								   new Triplet<string, short, short?>("MG_BudgetHead",7,
														   -1),
								   new Triplet<string, short, short?>("MG_FundDetailsID",0,
														   -1),
								   new Triplet<string, short, short?>("MG_FundType",4,
														   -1),
								   new Triplet<string, short, short?>("MG_FundTypeId",3,
														   -1),
								   new Triplet<string, short, short?>("MG_ProjectDesc",5,
														   -1),
								   new Triplet<string, short, short?>("MG_ProjectDetailsId",2,
														   -1),
								}
			},
							{"C5D35980-7A8E-48F3-A09B-FFDE2E631008", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_T2_Amount",12,
														   -1),
								   new Triplet<string, short, short?>("MG_T2_Arrival",5,
														   -1),
								   new Triplet<string, short, short?>("MG_T2_ArrivalDate",6,
														   -1),
								   new Triplet<string, short, short?>("MG_T2_ArrivalTime",7,
														   -1),
								   new Triplet<string, short, short?>("MG_T2_Departure",2,
														   -1),
								   new Triplet<string, short, short?>("MG_T2_DepartureDate",3,
														   -1),
								   new Triplet<string, short, short?>("MG_T2_DepartureTime",4,
														   -1),
								   new Triplet<string, short, short?>("MG_T2_JourneyClass",9,
														   -1),
								   new Triplet<string, short, short?>("MG_T2_ModeofJourney",8,
														   -1),
								   new Triplet<string, short, short?>("MG_T2_PNRNo",11,
														   -1),
								   new Triplet<string, short, short?>("MG_T2_Road",10,
														   -1),
								   new Triplet<string, short, short?>("MG_T2_TADetailsID",0,
														   -1),
								   new Triplet<string, short, short?>("MG_T3_TravelAdvanceID",1,
														   -1),
								   new Triplet<string, short, short?>("TravelExpense_RowId",13,
														   -1),
								}
			},
							{"d22d1615-70d7-8726-8132-f1daf7e9ba08", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_L1_Amount",11,
														   -1),
								   new Triplet<string, short, short?>("MG_L1_Arrival",4,
														   -1),
								   new Triplet<string, short, short?>("MG_L1_ArrivalDate",5,
														   -1),
								   new Triplet<string, short, short?>("MG_L1_Departure",1,
														   -1),
								   new Triplet<string, short, short?>("MG_L1_DepartureDate",2,
														   -1),
								   new Triplet<string, short, short?>("MG_L1_JourneyClass",8,
														   -1),
								   new Triplet<string, short, short?>("MG_L1_ModeofJourney",7,
														   -1),
								   new Triplet<string, short, short?>("MG_L1_PNRNo",10,
														   -1),
								   new Triplet<string, short, short?>("MG_L1_Road",9,
														   -1),
								}
			},
							{"DA3CF2FE-BFBD-482B-B0D7-A4FADF01F4B2", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_T2_Amount",12,
														   -1),
								   new Triplet<string, short, short?>("MG_T2_Arrival",5,
														   -1),
								   new Triplet<string, short, short?>("MG_T2_ArrivalDate",6,
														   -1),
								   new Triplet<string, short, short?>("MG_T2_ArrivalTime",7,
														   -1),
								   new Triplet<string, short, short?>("MG_T2_Departure",2,
														   -1),
								   new Triplet<string, short, short?>("MG_T2_DepartureDate",3,
														   -1),
								   new Triplet<string, short, short?>("MG_T2_DepartureTime",4,
														   -1),
								   new Triplet<string, short, short?>("MG_T2_JourneyClass",9,
														   -1),
								   new Triplet<string, short, short?>("MG_T2_ModeofJourney",8,
														   -1),
								   new Triplet<string, short, short?>("MG_T2_PNRNo",11,
														   -1),
								   new Triplet<string, short, short?>("MG_T2_Road",10,
														   -1),
								   new Triplet<string, short, short?>("MG_T2_TADetailsID",0,
														   -1),
								   new Triplet<string, short, short?>("MG_T3_TravelAdvanceID",1,
														   -1),
								   new Triplet<string, short, short?>("TravelExpense_RowId",13,
														   -1),
								}
			},
							{"E4242D90-2E8F-4517-8120-54465963606A", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("Expenditure_Type",0,
														   -1),
								   new Triplet<string, short, short?>("MG_T2_FromDate",2,
														   -1),
								   new Triplet<string, short, short?>("MG_T2_ToDate",3,
														   -1),
								   new Triplet<string, short, short?>("MG_T2_TravelAdvanceID",1,
														   -1),
								   new Triplet<string, short, short?>("MG_T3_Amount",4,
														   -1),
								   new Triplet<string, short, short?>("MG_T3_MiscDetails",6,
														   -1),
								   new Triplet<string, short, short?>("OtherExpense_RowId",5,
														   -1),
								}
			},
							{"E5D66127-B863-4FE5-BB07-A33C0F84EDE2", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_Amount",6,
														   -1),
								   new Triplet<string, short, short?>("MG_BudgetHead",7,
														   -1),
								   new Triplet<string, short, short?>("MG_FundDetailsID",0,
														   -1),
								   new Triplet<string, short, short?>("MG_FundType",4,
														   -1),
								   new Triplet<string, short, short?>("MG_FundTypeId",3,
														   -1),
								   new Triplet<string, short, short?>("MG_ProjectDesc",5,
														   -1),
								}
			},
					};	

	

		private Dictionary<string,string> formVersionList =new Dictionary<string,string> 
		{
							{"19C5A4DD-E5BF-44CD-93B0-88D010315268", "Tab"},
							{"62369CF1-A2EA-4E7B-BEE7-EDA46D5487EF", "Mobile-Hybrid"},
							{"7952C83C-2CDF-4039-A6A9-BF37615109C8", "Medium"},
					};	

		
		private Dictionary<string,string> formVersionLayoutList =new Dictionary<string,string> 
		{
							{"62369CF1-A2EA-4E7B-BEE7-EDA46D5487EF", ""},
							{"19C5A4DD-E5BF-44CD-93B0-88D010315268", ""},
							{"7952C83C-2CDF-4039-A6A9-BF37615109C8", ""},
							{"5550DB72-00B6-4FB4-92C7-655485402337", ""},
							{"9E4CC9DF-40B8-4351-BEC2-EAE735CA0D01", ""},
							{"AEA804A6-CC48-4A68-94C0-0EA269EE987C", ""},
							{"2A425DEF-B974-49D3-A364-3F9F0AE936A4", ""},
							{"70DB408C-FC37-44F2-BB64-51E6FF2A7196", ""},
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


	public partial class AcDataISpaceF4BD3F24901C43AB86074D7817A2621C  : ExtensionActivityBase
	{		
		
		
		private Dictionary<string,  List<Triplet<string, short, short?>>> queryExpressionBindings = 
											new Dictionary<string,  List<Triplet<string, short, short?>>>
		{
							{"33B5DB3C-C035-4454-8035-C74029C72FC1", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_Balance",6,
														   -1),
								   new Triplet<string, short, short?>("MG_BudgetName",0,
														   -1),
								   new Triplet<string, short, short?>("MG_Commitment",4,
														   -1),
								   new Triplet<string, short, short?>("MG_ReceivedAmount",3,
														   -1),
								   new Triplet<string, short, short?>("MG_SanctionedAmount",1,
														   -1),
								   new Triplet<string, short, short?>("MG_Spent",5,
														   -1),
								   new Triplet<string, short, short?>("MG_YetToReceive",2,
														   -1),
								}
			},
							{"5FF52A9F-C7A9-4838-9307-6D31A18D61AB", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_T2_Amount",12,
														   -1),
								   new Triplet<string, short, short?>("MG_T2_Arrival",5,
														   -1),
								   new Triplet<string, short, short?>("MG_T2_ArrivalDate",6,
														   -1),
								   new Triplet<string, short, short?>("MG_T2_ArrivalTime",7,
														   -1),
								   new Triplet<string, short, short?>("MG_T2_Departure",2,
														   -1),
								   new Triplet<string, short, short?>("MG_T2_DepartureDate",3,
														   -1),
								   new Triplet<string, short, short?>("MG_T2_DepartureTime",4,
														   -1),
								   new Triplet<string, short, short?>("MG_T2_JourneyClass",9,
														   -1),
								   new Triplet<string, short, short?>("MG_T2_ModeofJourney",8,
														   -1),
								   new Triplet<string, short, short?>("MG_T2_PNRNo",11,
														   -1),
								   new Triplet<string, short, short?>("MG_T2_Road",10,
														   -1),
								   new Triplet<string, short, short?>("MG_T2_TADetailsID",0,
														   -1),
								   new Triplet<string, short, short?>("MG_T3_TravelAdvanceID",1,
														   -1),
								   new Triplet<string, short, short?>("TravelExpense_RowId",13,
														   -1),
								}
			},
							{"DA3CF2FE-BFBD-482B-B0D7-A4FADF01F4B2", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_T2_Amount",12,
														   -1),
								   new Triplet<string, short, short?>("MG_T2_Arrival",5,
														   -1),
								   new Triplet<string, short, short?>("MG_T2_ArrivalDate",6,
														   -1),
								   new Triplet<string, short, short?>("MG_T2_ArrivalTime",7,
														   -1),
								   new Triplet<string, short, short?>("MG_T2_Departure",2,
														   -1),
								   new Triplet<string, short, short?>("MG_T2_DepartureDate",3,
														   -1),
								   new Triplet<string, short, short?>("MG_T2_DepartureTime",4,
														   -1),
								   new Triplet<string, short, short?>("MG_T2_JourneyClass",9,
														   -1),
								   new Triplet<string, short, short?>("MG_T2_ModeofJourney",8,
														   -1),
								   new Triplet<string, short, short?>("MG_T2_PNRNo",11,
														   -1),
								   new Triplet<string, short, short?>("MG_T2_Road",10,
														   -1),
								   new Triplet<string, short, short?>("MG_T2_TADetailsID",0,
														   -1),
								   new Triplet<string, short, short?>("MG_T3_TravelAdvanceID",1,
														   -1),
								   new Triplet<string, short, short?>("TravelExpense_RowId",13,
														   -1),
								}
			},
							{"F6CCD46B-A27D-469E-B390-A56BFBF805A6", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("ActivityName",1,
														   -1),
								   new Triplet<string, short, short?>("DateOfRemarks",3,
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
							{"19C5A4DD-E5BF-44CD-93B0-88D010315268", "Tab"},
							{"62369CF1-A2EA-4E7B-BEE7-EDA46D5487EF", "Mobile-Hybrid"},
							{"7952C83C-2CDF-4039-A6A9-BF37615109C8", "Medium"},
					};	

		
		private Dictionary<string,string> formVersionLayoutList =new Dictionary<string,string> 
		{
							{"62369CF1-A2EA-4E7B-BEE7-EDA46D5487EF", ""},
							{"19C5A4DD-E5BF-44CD-93B0-88D010315268", ""},
							{"7952C83C-2CDF-4039-A6A9-BF37615109C8", ""},
							{"5550DB72-00B6-4FB4-92C7-655485402337", ""},
							{"9E4CC9DF-40B8-4351-BEC2-EAE735CA0D01", ""},
							{"AEA804A6-CC48-4A68-94C0-0EA269EE987C", ""},
							{"2A425DEF-B974-49D3-A364-3F9F0AE936A4", ""},
							{"70DB408C-FC37-44F2-BB64-51E6FF2A7196", ""},
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


	public partial class AcDataISpaceF5D55501419C4E8D97D9EFE380D7D47D  : ExtensionActivityBase
	{		
		
		
		private Dictionary<string,  List<Triplet<string, short, short?>>> queryExpressionBindings = 
											new Dictionary<string,  List<Triplet<string, short, short?>>>
		{
							{"33B5DB3C-C035-4454-8035-C74029C72FC1", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_Balance",6,
														   -1),
								   new Triplet<string, short, short?>("MG_BudgetName",0,
														   -1),
								   new Triplet<string, short, short?>("MG_Commitment",4,
														   -1),
								   new Triplet<string, short, short?>("MG_ReceivedAmount",3,
														   -1),
								   new Triplet<string, short, short?>("MG_SanctionedAmount",1,
														   -1),
								   new Triplet<string, short, short?>("MG_Spent",5,
														   -1),
								   new Triplet<string, short, short?>("MG_YetToReceive",2,
														   -1),
								}
			},
							{"5FF52A9F-C7A9-4838-9307-6D31A18D61AB", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_T2_Amount",12,
														   -1),
								   new Triplet<string, short, short?>("MG_T2_Arrival",5,
														   -1),
								   new Triplet<string, short, short?>("MG_T2_ArrivalDate",6,
														   -1),
								   new Triplet<string, short, short?>("MG_T2_ArrivalTime",7,
														   -1),
								   new Triplet<string, short, short?>("MG_T2_Departure",2,
														   -1),
								   new Triplet<string, short, short?>("MG_T2_DepartureDate",3,
														   -1),
								   new Triplet<string, short, short?>("MG_T2_DepartureTime",4,
														   -1),
								   new Triplet<string, short, short?>("MG_T2_JourneyClass",9,
														   -1),
								   new Triplet<string, short, short?>("MG_T2_ModeofJourney",8,
														   -1),
								   new Triplet<string, short, short?>("MG_T2_PNRNo",11,
														   -1),
								   new Triplet<string, short, short?>("MG_T2_Road",10,
														   -1),
								   new Triplet<string, short, short?>("MG_T2_TADetailsID",0,
														   -1),
								   new Triplet<string, short, short?>("MG_T3_TravelAdvanceID",1,
														   -1),
								   new Triplet<string, short, short?>("TravelExpense_RowId",13,
														   -1),
								}
			},
							{"DA3CF2FE-BFBD-482B-B0D7-A4FADF01F4B2", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_T2_Amount",12,
														   -1),
								   new Triplet<string, short, short?>("MG_T2_Arrival",5,
														   -1),
								   new Triplet<string, short, short?>("MG_T2_ArrivalDate",6,
														   -1),
								   new Triplet<string, short, short?>("MG_T2_ArrivalTime",7,
														   -1),
								   new Triplet<string, short, short?>("MG_T2_Departure",2,
														   -1),
								   new Triplet<string, short, short?>("MG_T2_DepartureDate",3,
														   -1),
								   new Triplet<string, short, short?>("MG_T2_DepartureTime",4,
														   -1),
								   new Triplet<string, short, short?>("MG_T2_JourneyClass",9,
														   -1),
								   new Triplet<string, short, short?>("MG_T2_ModeofJourney",8,
														   -1),
								   new Triplet<string, short, short?>("MG_T2_PNRNo",11,
														   -1),
								   new Triplet<string, short, short?>("MG_T2_Road",10,
														   -1),
								   new Triplet<string, short, short?>("MG_T2_TADetailsID",0,
														   -1),
								   new Triplet<string, short, short?>("MG_T3_TravelAdvanceID",1,
														   -1),
								   new Triplet<string, short, short?>("TravelExpense_RowId",13,
														   -1),
								}
			},
							{"F6CCD46B-A27D-469E-B390-A56BFBF805A6", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("ActivityName",1,
														   -1),
								   new Triplet<string, short, short?>("DateOfRemarks",3,
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
							{"19C5A4DD-E5BF-44CD-93B0-88D010315268", "Tab"},
							{"62369CF1-A2EA-4E7B-BEE7-EDA46D5487EF", "Mobile-Hybrid"},
							{"7952C83C-2CDF-4039-A6A9-BF37615109C8", "Medium"},
					};	

		
		private Dictionary<string,string> formVersionLayoutList =new Dictionary<string,string> 
		{
							{"62369CF1-A2EA-4E7B-BEE7-EDA46D5487EF", ""},
							{"19C5A4DD-E5BF-44CD-93B0-88D010315268", ""},
							{"7952C83C-2CDF-4039-A6A9-BF37615109C8", ""},
							{"5550DB72-00B6-4FB4-92C7-655485402337", ""},
							{"9E4CC9DF-40B8-4351-BEC2-EAE735CA0D01", ""},
							{"AEA804A6-CC48-4A68-94C0-0EA269EE987C", ""},
							{"2A425DEF-B974-49D3-A364-3F9F0AE936A4", ""},
							{"70DB408C-FC37-44F2-BB64-51E6FF2A7196", ""},
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


	public partial class AcDataISpace5d5985337b811ca39e2dbb0389a50491  : ExtensionActivityBase
	{		
		
		
		private Dictionary<string,  List<Triplet<string, short, short?>>> queryExpressionBindings = 
											new Dictionary<string,  List<Triplet<string, short, short?>>>
		{
							{"33B5DB3C-C035-4454-8035-C74029C72FC1", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_Balance",6,
														   -1),
								   new Triplet<string, short, short?>("MG_BudgetName",0,
														   -1),
								   new Triplet<string, short, short?>("MG_Commitment",4,
														   -1),
								   new Triplet<string, short, short?>("MG_ReceivedAmount",3,
														   -1),
								   new Triplet<string, short, short?>("MG_SanctionedAmount",1,
														   -1),
								   new Triplet<string, short, short?>("MG_Spent",5,
														   -1),
								   new Triplet<string, short, short?>("MG_YetToReceive",2,
														   -1),
								}
			},
					};	

	

		private Dictionary<string,string> formVersionList =new Dictionary<string,string> 
		{
							{"62369CF1-A2EA-4E7B-BEE7-EDA46D5487EF", "Mobile-Hybrid"},
							{"19C5A4DD-E5BF-44CD-93B0-88D010315268", "Tab"},
							{"7952C83C-2CDF-4039-A6A9-BF37615109C8", "Medium"},
							{"5550DB72-00B6-4FB4-92C7-655485402337", "Large"},
							{"9E4CC9DF-40B8-4351-BEC2-EAE735CA0D01", "AR"},
							{"AEA804A6-CC48-4A68-94C0-0EA269EE987C", "MR"},
							{"2A425DEF-B974-49D3-A364-3F9F0AE936A4", "HHT"},
							{"70DB408C-FC37-44F2-BB64-51E6FF2A7196", "Mobile-Native"},
					};	

		
		private Dictionary<string,string> formVersionLayoutList =new Dictionary<string,string> 
		{
							{"62369CF1-A2EA-4E7B-BEE7-EDA46D5487EF", ""},
							{"19C5A4DD-E5BF-44CD-93B0-88D010315268", ""},
							{"7952C83C-2CDF-4039-A6A9-BF37615109C8", ""},
							{"5550DB72-00B6-4FB4-92C7-655485402337", ""},
							{"9E4CC9DF-40B8-4351-BEC2-EAE735CA0D01", ""},
							{"AEA804A6-CC48-4A68-94C0-0EA269EE987C", ""},
							{"2A425DEF-B974-49D3-A364-3F9F0AE936A4", ""},
							{"70DB408C-FC37-44F2-BB64-51E6FF2A7196", ""},
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


	public partial class AcDataISpacef5004f095bb0e6d6d972de383b2a4e39  : ExtensionActivityBase
	{		
		
		
		private Dictionary<string,  List<Triplet<string, short, short?>>> queryExpressionBindings = 
											new Dictionary<string,  List<Triplet<string, short, short?>>>
		{
							{"33B5DB3C-C035-4454-8035-C74029C72FC1", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MG_Balance",6,
														   -1),
								   new Triplet<string, short, short?>("MG_BudgetName",0,
														   -1),
								   new Triplet<string, short, short?>("MG_Commitment",4,
														   -1),
								   new Triplet<string, short, short?>("MG_ReceivedAmount",3,
														   -1),
								   new Triplet<string, short, short?>("MG_SanctionedAmount",1,
														   -1),
								   new Triplet<string, short, short?>("MG_Spent",5,
														   -1),
								   new Triplet<string, short, short?>("MG_YetToReceive",2,
														   -1),
								}
			},
					};	

	

		private Dictionary<string,string> formVersionList =new Dictionary<string,string> 
		{
							{"62369CF1-A2EA-4E7B-BEE7-EDA46D5487EF", "Mobile-Hybrid"},
							{"19C5A4DD-E5BF-44CD-93B0-88D010315268", "Tab"},
							{"7952C83C-2CDF-4039-A6A9-BF37615109C8", "Medium"},
							{"5550DB72-00B6-4FB4-92C7-655485402337", "Large"},
							{"9E4CC9DF-40B8-4351-BEC2-EAE735CA0D01", "AR"},
							{"AEA804A6-CC48-4A68-94C0-0EA269EE987C", "MR"},
							{"2A425DEF-B974-49D3-A364-3F9F0AE936A4", "HHT"},
							{"70DB408C-FC37-44F2-BB64-51E6FF2A7196", "Mobile-Native"},
					};	

		
		private Dictionary<string,string> formVersionLayoutList =new Dictionary<string,string> 
		{
							{"62369CF1-A2EA-4E7B-BEE7-EDA46D5487EF", ""},
							{"19C5A4DD-E5BF-44CD-93B0-88D010315268", ""},
							{"7952C83C-2CDF-4039-A6A9-BF37615109C8", ""},
							{"5550DB72-00B6-4FB4-92C7-655485402337", ""},
							{"9E4CC9DF-40B8-4351-BEC2-EAE735CA0D01", ""},
							{"AEA804A6-CC48-4A68-94C0-0EA269EE987C", ""},
							{"2A425DEF-B974-49D3-A364-3F9F0AE936A4", ""},
							{"70DB408C-FC37-44F2-BB64-51E6FF2A7196", ""},
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
		


