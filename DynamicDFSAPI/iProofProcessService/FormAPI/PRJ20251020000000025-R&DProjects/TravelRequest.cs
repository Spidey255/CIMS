  







namespace CPS.Proof.DFSExtension
{
	using System;
    using System.Collections.Generic;     
	using System.Linq;
	
	
	public partial class TravelRequestProcessMetadata : ExtensionProcessBase
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
            get { return "654C8734-EE30-4F33-B278-659E77BFDD71"; }
        }

        public override string ProcessName
        {
            get { return "TravelRequest"; }
        }

		public override string ProcessDescription
        {
            get { return "Travel Request"; }
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
            get {return "654C8734-EE30-4F33-B278-659E77BFDD71";}
        }

		public override byte ProcessInstanceMode
        {
            get {return 3;}
        }		

		public override string MasterFormId
        {
            get {  
				   return "EE0139AD-5EB8-4786-96CB-2C87A8B572D9";	}
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
	

	public partial class TravelRequestObjectFactory  : ExtObjectFactoryBase
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
        //    return (IExtBaseMetaData)new TravelRequestProcessMetadata();
        //}
	


		private List<Triplet<string, string, string>> queryExpressionData = new List<Triplet<string, string, string>>
		{
	  			
			     new Triplet<string, string, string>("9116BDE3-E175-48D9-92EE-87A8F58EDC21","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("5BE98974-AD59-4580-A751-30D0492B011E","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("4DA95BD5-CD3F-4A6D-8AE5-4C8A839E94D6","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"9ADED37B-CD11-426B-AF16-DEAC75685EF5"),
			
						
			     new Triplet<string, string, string>("2ACCBC57-2E9C-4A0F-BD46-FAB4E50951D4","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"300A3A31-6181-43BC-865F-73BE07692674"),
			
						
			     new Triplet<string, string, string>("DFBF6D46-81E0-41F6-94F4-5547F670F5AF","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("0C732937-A40A-4ABB-BB7D-D89BDA0D481E","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("030B3094-527B-4F84-B2E3-92458D34E946","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("EA86EC98-9465-469D-97F2-36E0D8B7BEB7","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("1D2378FB-2963-4898-9902-2B61F44BE0AD","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("864963C6-427C-451F-8C30-D7E8FCDD4228","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("EBE446FD-1D9E-41DE-B663-DEAA6EE73345","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("D16F9C83-EA71-4542-AB4D-E3D99AB969B2","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("4213CFEE-A88E-4B67-BEEC-B0AEF4337465","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("F83D458B-7CDF-409F-9329-98D97A3D6B68","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"300A3A31-6181-43BC-865F-73BE07692674"),
			
						
			     new Triplet<string, string, string>("5FF745B4-E8FE-40A7-98DD-1695E33EAF99","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("DEC46E0F-7EB5-48CF-8CA8-6728550C0AD3","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("805F857A-E616-4D34-A849-14552D9D77C8","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"028B1EFF-34A8-4D44-BF39-06CE99DF7C67"),
			
						
			     new Triplet<string, string, string>("CFA12554-1F39-4BC4-8046-E8A347DB7B6E","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"9ADED37B-CD11-426B-AF16-DEAC75685EF5"),
			
						
			     new Triplet<string, string, string>("AFBC2448-5761-40CF-A8EB-1C60C3DC33D1","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"300A3A31-6181-43BC-865F-73BE07692674"),
			
						
			     new Triplet<string, string, string>("D659A8A1-8261-4852-878E-8F0B73B79721","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"300A3A31-6181-43BC-865F-73BE07692674"),
			
						
			     new Triplet<string, string, string>("ED8F039D-5B07-4E67-A918-1A0BCE50C57F","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"300A3A31-6181-43BC-865F-73BE07692674"),
			
						
			     new Triplet<string, string, string>("09DA8B20-908E-4A22-A295-478F4E3F2DEB","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"028B1EFF-34A8-4D44-BF39-06CE99DF7C67"),
			
						
			     new Triplet<string, string, string>("A0ECD2B8-9809-41FB-814E-CFF85B9E0A09","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"9ADED37B-CD11-426B-AF16-DEAC75685EF5"),
			
						
			     new Triplet<string, string, string>("4D420532-A153-4648-8F67-A53328C6B6EC","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"300A3A31-6181-43BC-865F-73BE07692674"),
			
						
			     new Triplet<string, string, string>("E51258BF-79BE-40CF-B8C4-A28ACDA2DAA4","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("579419E7-90FA-4F5A-847A-ADEFF8FBD8C9","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("13D4A6E9-DC91-43DC-B6A1-C740A96DAFA6","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("35103DBC-9C79-44E2-A5BC-8BA3E5A2960A","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"300A3A31-6181-43BC-865F-73BE07692674"),
			
						
			     new Triplet<string, string, string>("4F7F1264-1768-4CE3-875C-0113E884A910","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"300A3A31-6181-43BC-865F-73BE07692674"),
			
						
			     new Triplet<string, string, string>("DD228B60-7D71-4F66-90FD-26F71FC14E4E","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("BA60CD90-0CDC-4883-991C-21CD74ED46AA","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("41A49BE0-8FEE-4020-BEAA-0553B628681F","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("DE33E12B-FBC1-42E0-94A9-B51B2789A1AE","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("797A60C1-0BB6-4A40-9156-95B92AAFC889","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"9ADED37B-CD11-426B-AF16-DEAC75685EF5"),
			
						
			     new Triplet<string, string, string>("9116BDE3-E175-48D9-92EE-87A8F58EDC21","Load ProjectCommitmentSpentDetails",
												     @"8259E1B0-2F90-4FE9-8BE4-875AEB9D5F40"),
			
						
			     new Triplet<string, string, string>("0C732937-A40A-4ABB-BB7D-D89BDA0D481E","Load Fund details",
												     @"AD9C54EC-27A0-4C21-9923-063084E3B588"),
			
						
			     new Triplet<string, string, string>("F83D458B-7CDF-409F-9329-98D97A3D6B68","Delete Records",
												     @"A694A330-AAD5-4856-853C-D6AD1573AF0B"),
			
						
			     new Triplet<string, string, string>("AFBC2448-5761-40CF-A8EB-1C60C3DC33D1","Grid Binding8",
												     @"FA412DDD-7AD9-49AF-B8D7-2B7E1620D8FC"),
			
						
			     new Triplet<string, string, string>("D659A8A1-8261-4852-878E-8F0B73B79721","Grid BindingE",
												     @"FA412DDD-7AD9-49AF-B8D7-2B7E1620D8FC"),
			
						
			     new Triplet<string, string, string>("ED8F039D-5B07-4E67-A918-1A0BCE50C57F","Delete Records",
												     @"FA412DDD-7AD9-49AF-B8D7-2B7E1620D8FC"),
			
						
			     new Triplet<string, string, string>("A0ECD2B8-9809-41FB-814E-CFF85B9E0A09","Load Remarks Details",
												     @"C9F458E5-830A-413E-BD1F-94F72A4AFB50"),
			
						
			     new Triplet<string, string, string>("E51258BF-79BE-40CF-B8C4-A28ACDA2DAA4","Delete fund",
												     @"AD9C54EC-27A0-4C21-9923-063084E3B588"),
			
						
			     new Triplet<string, string, string>("35103DBC-9C79-44E2-A5BC-8BA3E5A2960A","Add Other Expenses",
												     @"A694A330-AAD5-4856-853C-D6AD1573AF0B"),
			
						
			     new Triplet<string, string, string>("4F7F1264-1768-4CE3-875C-0113E884A910","Update the Other Expenses",
												     @"A694A330-AAD5-4856-853C-D6AD1573AF0B"),
			
			
			
		};

		
		private List<Triplet<string, string, string>> ComboDataSource = new List<Triplet<string, string, string>>
		{

		
	  			
			     new Triplet<string, string, string>("MFG_T2_ModeofJourney","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMAqCwOWy+D7Ogje1I4jfjiAZNrjEazgaNyfBj9pr2u90lOsHzRNfKnSybWqRxrZGqV",
												     @"EXEC GetTravelAdvanceDetailCombo 4"),
			
						
			     new Triplet<string, string, string>("MF_ProjectNo","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMAqCwOWy+D7Ogje1I4jfjiAZNrjEazgaNyfBj9pr2u90lOsHzRNfKnSybWqRxrZGqV",
												     @"EXEC Projects..GetProjectExtensionDetails 1,'@UC_EmployeeBaicInfoId'"),
			
						
			     new Triplet<string, string, string>("MF_FundType","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMA18yFT7KruzVDa0TqsqpOM+grujzoqor1KqRIderPPsozBAr7TiIaPx7MYO2zQclV",
												     @"exec SP_GetDistrubitionDetails 4,'@@gv_ProcessMapId','',''"),
			
						
			     new Triplet<string, string, string>("MF_T1_BudgetHead","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMAqCwOWy+D7Ogje1I4jfjiAZNrjEazgaNyfBj9pr2u90lOsHzRNfKnSybWqRxrZGqV",
												     @"EXEC GetBudgetHeads"),
			
						
			     new Triplet<string, string, string>("Expenditure_Type","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMAqCwOWy+D7Ogje1I4jfjiAZNrjEazgaNyfBj9pr2u90lOsHzRNfKnSybWqRxrZGqV",
												     @"EXEC GetTravelAdvanceView 3,''"),
			
						
			     new Triplet<string, string, string>("MF_BudgetHead","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMA18yFT7KruzVDa0TqsqpOM+grujzoqor1KqRIderPPsozBAr7TiIaPx7MYO2zQclV",
												     @"exec SP_GetDistrubitionDetails 5,'@@gv_ProcessMapId',@MF_FundType,'','','','','@MF_ProjectNo'"),
			
						
			     new Triplet<string, string, string>("M_MoveTo","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMA18yFT7KruzVDa0TqsqpOM+grujzoqor1KqRIderPPsozBAr7TiIaPx7MYO2zQclV",
												     @"EXEC GetMovetoValuesForTravelAdvance 1,'@M_IsAdvanceRequired','@M_ActivityName'"),
			
						
			     new Triplet<string, string, string>("MFG_T2_JourneyClass","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMAqCwOWy+D7Ogje1I4jfjiAZNrjEazgaNyfBj9pr2u90lOsHzRNfKnSybWqRxrZGqV",
												     @"EXEC GetTravelAdvanceDetailCombo 7,'@MFG_T2_ModeofJourney'"),
			
						
			     new Triplet<string, string, string>("A","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMA18yFT7KruzVDa0TqsqpOM+grujzoqor1KqRIderPPsozBAr7TiIaPx7MYO2zQclV",
												     @"exec SP_GetDistrubitionDetails 5,'',@MF_FundType,''"),
			
						
			     new Triplet<string, string, string>("MF_T1_TravelType","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMAqCwOWy+D7Ogje1I4jfjiAZNrjEazgaNyfBj9pr2u90lOsHzRNfKnSybWqRxrZGqV",
												     @"Select 1,1"),
			
						
			     new Triplet<string, string, string>("MG_T2_DepartureTime","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMAqCwOWy+D7Ogje1I4jfjiAZNrjEazgaNyfBj9pr2u90lOsHzRNfKnSybWqRxrZGqV",
												     @"EXEC GetTravelAdvanceDetailCombo 6"),
			
						
			     new Triplet<string, string, string>("MG_T2_JourneyClass","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMAqCwOWy+D7Ogje1I4jfjiAZNrjEazgaNyfBj9pr2u90lOsHzRNfKnSybWqRxrZGqV",
												     @"EXEC GetTravelAdvanceDetailCombo 17,''"),
			
						
			     new Triplet<string, string, string>("MFG_T2_ExpenditureTypeID","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMAqCwOWy+D7Ogje1I4jfjiAZNrjEazgaNyfBj9pr2u90lOsHzRNfKnSybWqRxrZGqV",
												     @"EXEC GetTravelAdvanceView 3,''"),
			
						
			     new Triplet<string, string, string>("C_FC_ProjectNo_33","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMAqCwOWy+D7Ogje1I4jfjiAZNrjEazgaNyfBj9pr2u90lOsHzRNfKnSybWqRxrZGqV",
												     @"EXEC GetProjects"),
			
						
			     new Triplet<string, string, string>("MG_T2_ModeofJourney","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMAqCwOWy+D7Ogje1I4jfjiAZNrjEazgaNyfBj9pr2u90lOsHzRNfKnSybWqRxrZGqV",
												     @"EXEC GetTravelAdvanceDetailCombo 4"),
			
						
			     new Triplet<string, string, string>("Travel_Type","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMAqCwOWy+D7Ogje1I4jfjiAZNrjEazgaNyfBj9pr2u90lOsHzRNfKnSybWqRxrZGqV",
												     @"EXEC GetTravelTypes"),
			
						
			     new Triplet<string, string, string>("MG_T2_ArrivalTime","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMAqCwOWy+D7Ogje1I4jfjiAZNrjEazgaNyfBj9pr2u90lOsHzRNfKnSybWqRxrZGqV",
												     @"EXEC GetTravelAdvanceDetailCombo 6"),
			
						
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
		
	  			
			     new Tuple<string, int>("OtherExpense",5),
			
						
			     new Tuple<string, int>("TravelExpense",5),
			
						
			     new Tuple<string, int>("MF_FundAmount",5),
			
						
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
											case "AAB05128-7AAE-4A99-8278-465822CE1E85":
							virtualInstance=new ISpaceAAB051287AAE4A998278465822CE1E85();
							break;
					
											case "CE310762-909A-4A90-A266-630580753EC6":
							virtualInstance=new ISpaceCE310762909A4A90A266630580753EC6();
							break;
					
											case "CFA9B7B2-8CF5-4389-B203-8EA7C779EE9A":
							virtualInstance=new ISpaceCFA9B7B28CF54389B2038EA7C779EE9A();
							break;
					
											case "C9900B03-EFE6-417C-9C4E-A09EA54B60FD":
							virtualInstance=new ISpaceC9900B03EFE6417C9C4EA09EA54B60FD();
							break;
					
											case "B26F9122-89B2-4163-B938-37AD78E21338":
							virtualInstance=new ISpaceB26F912289B24163B93837AD78E21338();
							break;
					
											case "5E4661C9-726C-4AD7-A457-7C4A84E9192D":
							virtualInstance=new ISpace5E4661C9726C4AD7A4577C4A84E9192D();
							break;
					
											case "A6341F06-0394-4CAA-88D0-B7B36027AF06":
							virtualInstance=new ISpaceA6341F0603944CAA88D0B7B36027AF06();
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
	

	public partial class TravelRequestDataElementFactory  : ExtElementBase
    {

     /// <summary>
        /// A <see cref="log4net.ILog"/> that contains the logger instance for 
        /// logging
        /// </summary>
        private readonly ILog _sysLog;

        public TravelRequestDataElementFactory()
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

               
                
                                      case "EE0139AD-5EB8-4786-96CB-2C87A8B572D9":
                    {
                     
                                     fInsertQuery=@"IF NOT EXISTS(SELECT 1 FROM [EE0139AD-5EB8-4786-96CB-2C87A8B572D9] WHERE InstanceId='{0}' AND
							ProcessActivityMapId='{1}' AND FormId='{2}') BEGIN INSERT INTO [EE0139AD-5EB8-4786-96CB-2C87A8B572D9](ProcessActivityMapId,FormId,MF_T1_TravelAdvanceID,M_MoveToValue,FC_SanctionedValue,MF_E1_EmployeeBasicInfoId,FC_Category,SetDestinationTo,UC_PhoneNumber,M_Remarks,MF_T1_BankName,M_ActivityName,C_FC_ProjectName_33,FC_AgencyCode,M_SourceActivityMapId,UC_EmailId,MF_FundDetailsId,ExecutionStatus,C_FC_SanctionNo_33,FC_ProjectName,ExecutionMessage,RedirectUrl,UC_Name,MF_T1_BankBranch,UC_Paylevel,M_DestinationActivityId,UC_EmployeeBaicInfoId,M_BudgetErrMsg,UC_DOB,DisplayContext,UC_DOR,CancelRedirectUrl,MF_T1_BeneficiaryName,MF_TravelStatus,ExecuteCommand,IN_SLA,C_FC_AgencyCode_33,KeyContext,C_FC_Category_33,UC_Designation,AssignToUser,UC_EmployeeId,M_TravelPlace,M_NextStage,MF_TransactionNo,MF_T1_ReferenceNo,MF_T1_Destination,FC_SanctionNo,M_InstanceId,MF_T1_TravellingPerson,FC_ProjectNo,M_PackageProcessMapId,MF_PackageProcessMapId,FC_EndDate,MF_T1_ProjectNo,UC_Grade,C_FC_SanctionedValue_33,growid,UC_DOJ,FC_SanctionedDate,AssignToRole,M_Status,MF_InstanceId,MF_T1_JourneyPurpose,M_InitiatorUserMapId,M_TravelInstanceId,UC_Department,Subject,MF_T1_AccountNo,IN_InstanceName,FC_StartDate,IN_Priority,M_IsFlowReturned,OverAll_Total,T_TravelAdvanceTotal,IN_Status,M_IsTravelRequest,MF_T1_AvailableBudget,SLATime,MF_GrdFundCount,M_SaveDomainData,M_FieldMandatory,M_IsSourceStep,T_ExpenditureTotal,MF_T1_AdvanceAmount,MF_Amount,C_FC_ReceiptAmountinBudgetHead,M_SumOfFund,C_FC_BudgetHeadAmount,T_AdvanceDrawn,M_BudgetErr,MF_CountDoc,M_RemarksMandatory,M_IsCommitment,M_IsCancelReject,IN_Category,M_RequestId,AdvanceAmount,M_MoveTo,Travel_Type,MF_T1_TravelType,MF_FundType,MF_BudgetHead,MF_ProjectNo,A,MF_T1_BudgetHead,C_FC_ProjectNo_33,C_FC_StartDate_33,C_FC_SanctionedDate_33,MF_TransactionDate,C_FC_EndDate_33,Thumbnail,MF_T1_BankDocument,InstanceId)
							VALUES( {3}) END ELSE BEGIN UPDATE [EE0139AD-5EB8-4786-96CB-2C87A8B572D9]SET {4}WHERE InstanceId='{0}'AND ProcessActivityMapId='{1}'AND FormId='{2}'END ";

                                     colList=@"ProcessActivityMapId,FormId,MF_T1_TravelAdvanceID,M_MoveToValue,FC_SanctionedValue,MF_E1_EmployeeBasicInfoId,FC_Category,SetDestinationTo,UC_PhoneNumber,M_Remarks,MF_T1_BankName,M_ActivityName,C_FC_ProjectName_33,FC_AgencyCode,M_SourceActivityMapId,UC_EmailId,MF_FundDetailsId,ExecutionStatus,C_FC_SanctionNo_33,FC_ProjectName,ExecutionMessage,RedirectUrl,UC_Name,MF_T1_BankBranch,UC_Paylevel,M_DestinationActivityId,UC_EmployeeBaicInfoId,M_BudgetErrMsg,UC_DOB,DisplayContext,UC_DOR,CancelRedirectUrl,MF_T1_BeneficiaryName,MF_TravelStatus,ExecuteCommand,IN_SLA,C_FC_AgencyCode_33,KeyContext,C_FC_Category_33,UC_Designation,AssignToUser,UC_EmployeeId,M_TravelPlace,M_NextStage,MF_TransactionNo,MF_T1_ReferenceNo,MF_T1_Destination,FC_SanctionNo,M_InstanceId,MF_T1_TravellingPerson,FC_ProjectNo,M_PackageProcessMapId,MF_PackageProcessMapId,FC_EndDate,MF_T1_ProjectNo,UC_Grade,C_FC_SanctionedValue_33,growid,UC_DOJ,FC_SanctionedDate,AssignToRole,M_Status,MF_InstanceId,MF_T1_JourneyPurpose,M_InitiatorUserMapId,M_TravelInstanceId,UC_Department,Subject,MF_T1_AccountNo,IN_InstanceName,FC_StartDate,IN_Priority,M_IsFlowReturned,OverAll_Total,T_TravelAdvanceTotal,IN_Status,M_IsTravelRequest,MF_T1_AvailableBudget,SLATime,MF_GrdFundCount,M_SaveDomainData,M_FieldMandatory,M_IsSourceStep,T_ExpenditureTotal,MF_T1_AdvanceAmount,MF_Amount,C_FC_ReceiptAmountinBudgetHead,M_SumOfFund,C_FC_BudgetHeadAmount,T_AdvanceDrawn,M_BudgetErr,MF_CountDoc,M_RemarksMandatory,M_IsCommitment,M_IsCancelReject,IN_Category,M_RequestId,AdvanceAmount,M_MoveTo,Travel_Type,MF_T1_TravelType,MF_FundType,MF_BudgetHead,MF_ProjectNo,A,MF_T1_BudgetHead,C_FC_ProjectNo_33,C_FC_StartDate_33,C_FC_SanctionedDate_33,MF_TransactionDate,C_FC_EndDate_33,Thumbnail,MF_T1_BankDocument,InstanceId";
                                    
                     
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

                
                 
                                      case "AD9C54EC-27A0-4C21-9923-063084E3B588":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_AD9C54EC27A04C219923063084E3B588 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_BudgetHead] VARCHAR(MAX)	, [MG_ProjectDesc] VARCHAR(MAX)	, [MG_ProjectDetailsId] VARCHAR(MAX)	, [MG_FundDetailsID] VARCHAR(MAX)	, [MG_FundType] VARCHAR(MAX)	, [MG_FundTypeId] INT	, [MG_Amount] DECIMAL(18,2)){0}INSERT INTO [AD9C54EC-27A0-4C21-9923-063084E3B588](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_BudgetHead,MG_ProjectDesc,MG_ProjectDetailsId,MG_FundDetailsID,MG_FundType,MG_FundTypeId,MG_Amount)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_BudgetHead,TDT.MG_ProjectDesc,TDT.MG_ProjectDetailsId,TDT.MG_FundDetailsID,TDT.MG_FundType,TDT.MG_FundTypeId,TDT.MG_Amount FROM @TBL_AD9C54EC27A04C219923063084E3B588 TDT
							LEFT JOIN [AD9C54EC-27A0-4C21-9923-063084E3B588] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_BudgetHead,MG_ProjectDesc,MG_ProjectDetailsId,MG_FundDetailsID,MG_FundType,MG_FundTypeId,MG_Amount";

                                     tempInsertQuery=@"INSERT INTO @TBL_AD9C54EC27A04C219923063084E3B588(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_BudgetHead,MG_ProjectDesc,MG_ProjectDetailsId,MG_FundDetailsID,MG_FundType,MG_FundTypeId,MG_Amount)VALUES({0});";
                                     

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
                     
                                    case "B5EF84C8-83A9-4B1C-9431-0489F9EC063B":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_B5EF84C883A94B1C94310489F9EC063B AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [M_DocumentName] VARCHAR(MAX)	, [M_DocumentDetailsId] VARCHAR(MAX)	, [M_UploadDcoument] VARBINARY(MAX)){0}INSERT INTO [B5EF84C8-83A9-4B1C-9431-0489F9EC063B](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,M_DocumentName,M_DocumentDetailsId,M_UploadDcoument)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.M_DocumentName,TDT.M_DocumentDetailsId,TDT.M_UploadDcoument FROM @TBL_B5EF84C883A94B1C94310489F9EC063B TDT
							LEFT JOIN [B5EF84C8-83A9-4B1C-9431-0489F9EC063B] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,M_DocumentName,M_DocumentDetailsId,M_UploadDcoument";

                                     tempInsertQuery=@"INSERT INTO @TBL_B5EF84C883A94B1C94310489F9EC063B(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,M_DocumentName,M_DocumentDetailsId,M_UploadDcoument)VALUES({0});";
                                     

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
                     
                                    case "A694A330-AAD5-4856-853C-D6AD1573AF0B":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_A694A330AAD54856853CD6AD1573AF0B AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_T2_TravelAdvanceID] VARCHAR(MAX)	, [MG_T2_ExpenditureTypeID] VARCHAR(MAX)	, [MG_T3_Amount] INT	, [Expenditure_Type] VARCHAR(250)	, [MG_T2_ToDate] DATETIME	, [MG_T2_FromDate] DATETIME){0}INSERT INTO [A694A330-AAD5-4856-853C-D6AD1573AF0B](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_T2_TravelAdvanceID,MG_T2_ExpenditureTypeID,MG_T3_Amount,Expenditure_Type,MG_T2_ToDate,MG_T2_FromDate)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_T2_TravelAdvanceID,TDT.MG_T2_ExpenditureTypeID,TDT.MG_T3_Amount,TDT.Expenditure_Type,TDT.MG_T2_ToDate,TDT.MG_T2_FromDate FROM @TBL_A694A330AAD54856853CD6AD1573AF0B TDT
							LEFT JOIN [A694A330-AAD5-4856-853C-D6AD1573AF0B] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_T2_TravelAdvanceID,MG_T2_ExpenditureTypeID,MG_T3_Amount,Expenditure_Type,MG_T2_ToDate,MG_T2_FromDate";

                                     tempInsertQuery=@"INSERT INTO @TBL_A694A330AAD54856853CD6AD1573AF0B(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_T2_TravelAdvanceID,MG_T2_ExpenditureTypeID,MG_T3_Amount,Expenditure_Type,MG_T2_ToDate,MG_T2_FromDate)VALUES({0});";
                                     

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
                     
                                    case "FA412DDD-7AD9-49AF-B8D7-2B7E1620D8FC":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_FA412DDD7AD949AFB8D72B7E1620D8FC AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_T2_TADetailsID] VARCHAR(MAX)	, [MG_T2_DepartureTime] VARCHAR(MAX)	, [MG_T2_PNRNo] VARCHAR(MAX)	, [MG_T2_Arrival] VARCHAR(MAX)	, [MG_T2_ArrivalTime] VARCHAR(MAX)	, [MG_T2_Departure] VARCHAR(MAX)	, [MG_T3_TravelAdvanceID] VARCHAR(MAX)	, [MG_T2_Road] INT	, [MG_T2_Amount] INT	, [MG_T2_ModeofJourney] VARCHAR(250)	, [MG_T2_JourneyClass] VARCHAR(250)	, [MG_T2_DepartureDate] DATETIME	, [MG_T2_ArrivalDate] DATETIME){0}INSERT INTO [FA412DDD-7AD9-49AF-B8D7-2B7E1620D8FC](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_T2_TADetailsID,MG_T2_DepartureTime,MG_T2_PNRNo,MG_T2_Arrival,MG_T2_ArrivalTime,MG_T2_Departure,MG_T3_TravelAdvanceID,MG_T2_Road,MG_T2_Amount,MG_T2_ModeofJourney,MG_T2_JourneyClass,MG_T2_DepartureDate,MG_T2_ArrivalDate)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_T2_TADetailsID,TDT.MG_T2_DepartureTime,TDT.MG_T2_PNRNo,TDT.MG_T2_Arrival,TDT.MG_T2_ArrivalTime,TDT.MG_T2_Departure,TDT.MG_T3_TravelAdvanceID,TDT.MG_T2_Road,TDT.MG_T2_Amount,TDT.MG_T2_ModeofJourney,TDT.MG_T2_JourneyClass,TDT.MG_T2_DepartureDate,TDT.MG_T2_ArrivalDate FROM @TBL_FA412DDD7AD949AFB8D72B7E1620D8FC TDT
							LEFT JOIN [FA412DDD-7AD9-49AF-B8D7-2B7E1620D8FC] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_T2_TADetailsID,MG_T2_DepartureTime,MG_T2_PNRNo,MG_T2_Arrival,MG_T2_ArrivalTime,MG_T2_Departure,MG_T3_TravelAdvanceID,MG_T2_Road,MG_T2_Amount,MG_T2_ModeofJourney,MG_T2_JourneyClass,MG_T2_DepartureDate,MG_T2_ArrivalDate";

                                     tempInsertQuery=@"INSERT INTO @TBL_FA412DDD7AD949AFB8D72B7E1620D8FC(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_T2_TADetailsID,MG_T2_DepartureTime,MG_T2_PNRNo,MG_T2_Arrival,MG_T2_ArrivalTime,MG_T2_Departure,MG_T3_TravelAdvanceID,MG_T2_Road,MG_T2_Amount,MG_T2_ModeofJourney,MG_T2_JourneyClass,MG_T2_DepartureDate,MG_T2_ArrivalDate)VALUES({0});";
                                     

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
                     
                                    case "8259E1B0-2F90-4FE9-8BE4-875AEB9D5F40":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_8259E1B02F904FE98BE4875AEB9D5F40 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_BudgetName] VARCHAR(MAX)	, [MG_ReceivedAmount] DECIMAL(18,2)	, [MG_Balance] DECIMAL(18,2)	, [MG_Spent] DECIMAL(18,2)	, [MG_YetToReceive] DECIMAL(18,2)	, [MG_Commitment] DECIMAL(18,2)	, [MG_SanctionedAmount] DECIMAL(18,2)){0}INSERT INTO [8259E1B0-2F90-4FE9-8BE4-875AEB9D5F40](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_BudgetName,MG_ReceivedAmount,MG_Balance,MG_Spent,MG_YetToReceive,MG_Commitment,MG_SanctionedAmount)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_BudgetName,TDT.MG_ReceivedAmount,TDT.MG_Balance,TDT.MG_Spent,TDT.MG_YetToReceive,TDT.MG_Commitment,TDT.MG_SanctionedAmount FROM @TBL_8259E1B02F904FE98BE4875AEB9D5F40 TDT
							LEFT JOIN [8259E1B0-2F90-4FE9-8BE4-875AEB9D5F40] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_BudgetName,MG_ReceivedAmount,MG_Balance,MG_Spent,MG_YetToReceive,MG_Commitment,MG_SanctionedAmount";

                                     tempInsertQuery=@"INSERT INTO @TBL_8259E1B02F904FE98BE4875AEB9D5F40(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_BudgetName,MG_ReceivedAmount,MG_Balance,MG_Spent,MG_YetToReceive,MG_Commitment,MG_SanctionedAmount)VALUES({0});";
                                     

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
                     
                                    case "C9F458E5-830A-413E-BD1F-94F72A4AFB50":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_C9F458E5830A413EBD1F94F72A4AFB50 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [ActivityName] VARCHAR(MAX)	, [UserName] VARCHAR(MAX)	, [Remarks] VARCHAR(MAX)	, [RemarksId] VARCHAR(MAX)	, [DateOfRemarks] DATETIME){0}INSERT INTO [C9F458E5-830A-413E-BD1F-94F72A4AFB50](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,ActivityName,UserName,Remarks,RemarksId,DateOfRemarks)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.ActivityName,TDT.UserName,TDT.Remarks,TDT.RemarksId,TDT.DateOfRemarks FROM @TBL_C9F458E5830A413EBD1F94F72A4AFB50 TDT
							LEFT JOIN [C9F458E5-830A-413E-BD1F-94F72A4AFB50] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,ActivityName,UserName,Remarks,RemarksId,DateOfRemarks";

                                     tempInsertQuery=@"INSERT INTO @TBL_C9F458E5830A413EBD1F94F72A4AFB50(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,ActivityName,UserName,Remarks,RemarksId,DateOfRemarks)VALUES({0});";
                                     

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
                     

                                         case "AD9C54EC-27A0-4C21-9923-063084E3B588":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_AD9C54EC27A04C219923063084E3B588 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_BudgetHead] VARCHAR(MAX)	, [MG_ProjectDesc] VARCHAR(MAX)	, [MG_ProjectDetailsId] VARCHAR(MAX)	, [MG_FundDetailsID] VARCHAR(MAX)	, [MG_FundType] VARCHAR(MAX)	, [MG_FundTypeId] INT	, [MG_Amount] DECIMAL(18,2)){0}INSERT INTO [AD9C54EC-27A0-4C21-9923-063084E3B588](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_BudgetHead,MG_ProjectDesc,MG_ProjectDetailsId,MG_FundDetailsID,MG_FundType,MG_FundTypeId,MG_Amount)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_BudgetHead,TDT.MG_ProjectDesc,TDT.MG_ProjectDetailsId,TDT.MG_FundDetailsID,TDT.MG_FundType,TDT.MG_FundTypeId,TDT.MG_Amount FROM @TBL_AD9C54EC27A04C219923063084E3B588 TDT
							LEFT JOIN [AD9C54EC-27A0-4C21-9923-063084E3B588] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_BudgetHead,MG_ProjectDesc,MG_ProjectDetailsId,MG_FundDetailsID,MG_FundType,MG_FundTypeId,MG_Amount";

                            tempInsertQuery=@"INSERT INTO @TBL_AD9C54EC27A04C219923063084E3B588(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_BudgetHead,MG_ProjectDesc,MG_ProjectDetailsId,MG_FundDetailsID,MG_FundType,MG_FundTypeId,MG_Amount)VALUES({0});";

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

                                              case "B5EF84C8-83A9-4B1C-9431-0489F9EC063B":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_B5EF84C883A94B1C94310489F9EC063B AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [M_DocumentName] VARCHAR(MAX)	, [M_DocumentDetailsId] VARCHAR(MAX)	, [M_UploadDcoument] VARBINARY(MAX)){0}INSERT INTO [B5EF84C8-83A9-4B1C-9431-0489F9EC063B](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,M_DocumentName,M_DocumentDetailsId,M_UploadDcoument)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.M_DocumentName,TDT.M_DocumentDetailsId,TDT.M_UploadDcoument FROM @TBL_B5EF84C883A94B1C94310489F9EC063B TDT
							LEFT JOIN [B5EF84C8-83A9-4B1C-9431-0489F9EC063B] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,M_DocumentName,M_DocumentDetailsId,M_UploadDcoument";

                            tempInsertQuery=@"INSERT INTO @TBL_B5EF84C883A94B1C94310489F9EC063B(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,M_DocumentName,M_DocumentDetailsId,M_UploadDcoument)VALUES({0});";

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

                                              case "A694A330-AAD5-4856-853C-D6AD1573AF0B":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_A694A330AAD54856853CD6AD1573AF0B AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_T2_TravelAdvanceID] VARCHAR(MAX)	, [MG_T2_ExpenditureTypeID] VARCHAR(MAX)	, [MG_T3_Amount] INT	, [Expenditure_Type] VARCHAR(250)	, [MG_T2_ToDate] DATETIME	, [MG_T2_FromDate] DATETIME){0}INSERT INTO [A694A330-AAD5-4856-853C-D6AD1573AF0B](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_T2_TravelAdvanceID,MG_T2_ExpenditureTypeID,MG_T3_Amount,Expenditure_Type,MG_T2_ToDate,MG_T2_FromDate)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_T2_TravelAdvanceID,TDT.MG_T2_ExpenditureTypeID,TDT.MG_T3_Amount,TDT.Expenditure_Type,TDT.MG_T2_ToDate,TDT.MG_T2_FromDate FROM @TBL_A694A330AAD54856853CD6AD1573AF0B TDT
							LEFT JOIN [A694A330-AAD5-4856-853C-D6AD1573AF0B] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_T2_TravelAdvanceID,MG_T2_ExpenditureTypeID,MG_T3_Amount,Expenditure_Type,MG_T2_ToDate,MG_T2_FromDate";

                            tempInsertQuery=@"INSERT INTO @TBL_A694A330AAD54856853CD6AD1573AF0B(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_T2_TravelAdvanceID,MG_T2_ExpenditureTypeID,MG_T3_Amount,Expenditure_Type,MG_T2_ToDate,MG_T2_FromDate)VALUES({0});";

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

                                              case "FA412DDD-7AD9-49AF-B8D7-2B7E1620D8FC":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_FA412DDD7AD949AFB8D72B7E1620D8FC AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_T2_TADetailsID] VARCHAR(MAX)	, [MG_T2_DepartureTime] VARCHAR(MAX)	, [MG_T2_PNRNo] VARCHAR(MAX)	, [MG_T2_Arrival] VARCHAR(MAX)	, [MG_T2_ArrivalTime] VARCHAR(MAX)	, [MG_T2_Departure] VARCHAR(MAX)	, [MG_T3_TravelAdvanceID] VARCHAR(MAX)	, [MG_T2_Road] INT	, [MG_T2_Amount] INT	, [MG_T2_ModeofJourney] VARCHAR(250)	, [MG_T2_JourneyClass] VARCHAR(250)	, [MG_T2_DepartureDate] DATETIME	, [MG_T2_ArrivalDate] DATETIME){0}INSERT INTO [FA412DDD-7AD9-49AF-B8D7-2B7E1620D8FC](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_T2_TADetailsID,MG_T2_DepartureTime,MG_T2_PNRNo,MG_T2_Arrival,MG_T2_ArrivalTime,MG_T2_Departure,MG_T3_TravelAdvanceID,MG_T2_Road,MG_T2_Amount,MG_T2_ModeofJourney,MG_T2_JourneyClass,MG_T2_DepartureDate,MG_T2_ArrivalDate)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_T2_TADetailsID,TDT.MG_T2_DepartureTime,TDT.MG_T2_PNRNo,TDT.MG_T2_Arrival,TDT.MG_T2_ArrivalTime,TDT.MG_T2_Departure,TDT.MG_T3_TravelAdvanceID,TDT.MG_T2_Road,TDT.MG_T2_Amount,TDT.MG_T2_ModeofJourney,TDT.MG_T2_JourneyClass,TDT.MG_T2_DepartureDate,TDT.MG_T2_ArrivalDate FROM @TBL_FA412DDD7AD949AFB8D72B7E1620D8FC TDT
							LEFT JOIN [FA412DDD-7AD9-49AF-B8D7-2B7E1620D8FC] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_T2_TADetailsID,MG_T2_DepartureTime,MG_T2_PNRNo,MG_T2_Arrival,MG_T2_ArrivalTime,MG_T2_Departure,MG_T3_TravelAdvanceID,MG_T2_Road,MG_T2_Amount,MG_T2_ModeofJourney,MG_T2_JourneyClass,MG_T2_DepartureDate,MG_T2_ArrivalDate";

                            tempInsertQuery=@"INSERT INTO @TBL_FA412DDD7AD949AFB8D72B7E1620D8FC(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_T2_TADetailsID,MG_T2_DepartureTime,MG_T2_PNRNo,MG_T2_Arrival,MG_T2_ArrivalTime,MG_T2_Departure,MG_T3_TravelAdvanceID,MG_T2_Road,MG_T2_Amount,MG_T2_ModeofJourney,MG_T2_JourneyClass,MG_T2_DepartureDate,MG_T2_ArrivalDate)VALUES({0});";

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

                                              case "8259E1B0-2F90-4FE9-8BE4-875AEB9D5F40":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_8259E1B02F904FE98BE4875AEB9D5F40 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_BudgetName] VARCHAR(MAX)	, [MG_ReceivedAmount] DECIMAL(18,2)	, [MG_Balance] DECIMAL(18,2)	, [MG_Spent] DECIMAL(18,2)	, [MG_YetToReceive] DECIMAL(18,2)	, [MG_Commitment] DECIMAL(18,2)	, [MG_SanctionedAmount] DECIMAL(18,2)){0}INSERT INTO [8259E1B0-2F90-4FE9-8BE4-875AEB9D5F40](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_BudgetName,MG_ReceivedAmount,MG_Balance,MG_Spent,MG_YetToReceive,MG_Commitment,MG_SanctionedAmount)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_BudgetName,TDT.MG_ReceivedAmount,TDT.MG_Balance,TDT.MG_Spent,TDT.MG_YetToReceive,TDT.MG_Commitment,TDT.MG_SanctionedAmount FROM @TBL_8259E1B02F904FE98BE4875AEB9D5F40 TDT
							LEFT JOIN [8259E1B0-2F90-4FE9-8BE4-875AEB9D5F40] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_BudgetName,MG_ReceivedAmount,MG_Balance,MG_Spent,MG_YetToReceive,MG_Commitment,MG_SanctionedAmount";

                            tempInsertQuery=@"INSERT INTO @TBL_8259E1B02F904FE98BE4875AEB9D5F40(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_BudgetName,MG_ReceivedAmount,MG_Balance,MG_Spent,MG_YetToReceive,MG_Commitment,MG_SanctionedAmount)VALUES({0});";

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

                                              case "C9F458E5-830A-413E-BD1F-94F72A4AFB50":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_C9F458E5830A413EBD1F94F72A4AFB50 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [ActivityName] VARCHAR(MAX)	, [UserName] VARCHAR(MAX)	, [Remarks] VARCHAR(MAX)	, [RemarksId] VARCHAR(MAX)	, [DateOfRemarks] DATETIME){0}INSERT INTO [C9F458E5-830A-413E-BD1F-94F72A4AFB50](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,ActivityName,UserName,Remarks,RemarksId,DateOfRemarks)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.ActivityName,TDT.UserName,TDT.Remarks,TDT.RemarksId,TDT.DateOfRemarks FROM @TBL_C9F458E5830A413EBD1F94F72A4AFB50 TDT
							LEFT JOIN [C9F458E5-830A-413E-BD1F-94F72A4AFB50] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,ActivityName,UserName,Remarks,RemarksId,DateOfRemarks";

                            tempInsertQuery=@"INSERT INTO @TBL_C9F458E5830A413EBD1F94F72A4AFB50(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,ActivityName,UserName,Remarks,RemarksId,DateOfRemarks)VALUES({0});";

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
public class ISpaceAAB051287AAE4A998278465822CE1E85 : VirtualForm
{
IISpace iSpace = new ISpace();
AcDataISpaceAAB051287AAE4A998278465822CE1E85 acdataIspaceAAB051287AAE4A998278465822CE1E85=new AcDataISpaceAAB051287AAE4A998278465822CE1E85();
private void SubscribeFormEvents_root(ref Dictionary<string, ServiceElementData> ISpace)
{
try
{
base.WriteDebugInfo(@"Root-OnAfterFormLoad");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC [GetEmployeeUserContextDetails] '@@gv_UserId'");

var querySource09DA8B20908E4A22A295478F4E3F2DEB =GetQueryExpressionDataSource("09DA8B20-908E-4A22-A295-478F4E3F2DEB");
Dictionary<short,object> result09DA8B20908E4A22A295478F4E3F2DEB=iSpace.ExecuteQuery(querySource09DA8B20908E4A22A295478F4E3F2DEB,@"EXEC [GetEmployeeUserContextDetails] '" + ISpace["gv_userid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource09DA8B20908E4A22A295478F4E3F2DEB =GetQueryExpressionDataSource(""09DA8B20-908E-4A22-A295-478F4E3F2DEB"");Dictionary<short,object> result09DA8B20908E4A22A295478F4E3F2DEB=iSpace.ExecuteQuery(querySource09DA8B20908E4A22A295478F4E3F2DEB,@""EXEC [GetEmployeeUserContextDetails] '"" + ISpace[""gv_userid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result09DA8B20908E4A22A295478F4E3F2DEB!=null) && (result09DA8B20908E4A22A295478F4E3F2DEB.Count!=0))
{
if(result09DA8B20908E4A22A295478F4E3F2DEB.ContainsKey(4))
ISpace["UC_DOJ"].Value = result09DA8B20908E4A22A295478F4E3F2DEB[4];
if(result09DA8B20908E4A22A295478F4E3F2DEB.ContainsKey(3))
ISpace["UC_EmailId"].Value = result09DA8B20908E4A22A295478F4E3F2DEB[3];
if(result09DA8B20908E4A22A295478F4E3F2DEB.ContainsKey(5))
ISpace["UC_PhoneNumber"].Value = result09DA8B20908E4A22A295478F4E3F2DEB[5];
if(result09DA8B20908E4A22A295478F4E3F2DEB.ContainsKey(7))
ISpace["UC_Designation"].Value = result09DA8B20908E4A22A295478F4E3F2DEB[7];
if(result09DA8B20908E4A22A295478F4E3F2DEB.ContainsKey(0))
ISpace["UC_EmployeeBaicInfoId"].Value = result09DA8B20908E4A22A295478F4E3F2DEB[0];
if(result09DA8B20908E4A22A295478F4E3F2DEB.ContainsKey(1))
ISpace["UC_EmployeeId"].Value = result09DA8B20908E4A22A295478F4E3F2DEB[1];
if(result09DA8B20908E4A22A295478F4E3F2DEB.ContainsKey(9))
ISpace["UC_DOB"].Value = result09DA8B20908E4A22A295478F4E3F2DEB[9];
if(result09DA8B20908E4A22A295478F4E3F2DEB.ContainsKey(11))
ISpace["UC_Grade"].Value = result09DA8B20908E4A22A295478F4E3F2DEB[11];
if(result09DA8B20908E4A22A295478F4E3F2DEB.ContainsKey(10))
ISpace["UC_DOR"].Value = result09DA8B20908E4A22A295478F4E3F2DEB[10];
if(result09DA8B20908E4A22A295478F4E3F2DEB.ContainsKey(2))
ISpace["UC_Name"].Value = result09DA8B20908E4A22A295478F4E3F2DEB[2];
if(result09DA8B20908E4A22A295478F4E3F2DEB.ContainsKey(6))
ISpace["UC_Department"].Value = result09DA8B20908E4A22A295478F4E3F2DEB[6];
if(result09DA8B20908E4A22A295478F4E3F2DEB.ContainsKey(12))
ISpace["UC_Paylevel"].Value = result09DA8B20908E4A22A295478F4E3F2DEB[12];
}
else{
ISpace["UC_DOJ"].Value = null;ISpace["UC_EmailId"].Value = null;ISpace["UC_PhoneNumber"].Value = null;ISpace["UC_Designation"].Value = null;ISpace["UC_EmployeeBaicInfoId"].Value = null;ISpace["UC_EmployeeId"].Value = null;ISpace["UC_DOB"].Value = null;ISpace["UC_Grade"].Value = null;ISpace["UC_DOR"].Value = null;ISpace["UC_Name"].Value = null;ISpace["UC_Department"].Value = null;ISpace["UC_Paylevel"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["MFG_T2_ModeofJourney"].Visible="true";ISpace["MFG_T2_Departure"].Visible="true";ISpace["MFG_T2_Road"].Visible="true";ISpace["MFG_T2_DepartureDate"].Visible="true";ISpace["MFG_T2_ArrivalDate"].Visible="true";ISpace["MF_T1_BudgetHead"].Visible="true";ISpace["MF_T1_Destination"].Visible="true";ISpace["MFG_T2_Amount"].Visible="true";ISpace["MF_T1_AvailableBudget"].Visible="true";ISpace["MF_T1_JourneyPurpose"].Visible="true";ISpace["MFG_T2_PNRNo"].Visible="true";ISpace["MFG_T2_JourneyClass"].Visible="true";ISpace["MFG_T2_DepartureTime"].Visible="true";ISpace["MFG_T2_ToDate"].Visible="true";ISpace["MF_T1_AccountNo"].Visible="true";ISpace["MFG_T2_FromDate"].Visible="true";ISpace["MFG_T3_Amount"].Visible="true";ISpace["MF_T1_TravelType"].Visible="true";ISpace["MF_T1_BankBranch"].Visible="true";ISpace["MF_T1_ProjectNo"].Visible="true";ISpace["MFG_T2_ArrivalTime"].Visible="true";ISpace["MF_T1_AdvanceAmount"].Visible="true";ISpace["MF_T1_TravellingPerson"].Visible="true";ISpace["MF_T1_BeneficiaryName"].Visible="true";ISpace["MF_T1_BankDocument"].Visible="true";ISpace["MF_T1_TravelAdvanceID"].Visible="false";ISpace["MF_T1_BankName"].Visible="true";ISpace["MFG_T2_Arrival"].Visible="true";ISpace["MF_T1_ReferenceNo"].Visible="true";
base.WriteDebugInfo(@"ISpace[""MFG_T2_ModeofJourney""].Visible=""true"";ISpace[""MFG_T2_Departure""].Visible=""true"";ISpace[""MFG_T2_Road""].Visible=""true"";ISpace[""MFG_T2_DepartureDate""].Visible=""true"";ISpace[""MFG_T2_ArrivalDate""].Visible=""true"";ISpace[""MF_T1_BudgetHead""].Visible=""true"";ISpace[""MF_T1_Destination""].Visible=""true"";ISpace[""MFG_T2_Amount""].Visible=""true"";ISpace[""MF_T1_AvailableBudget""].Visible=""true"";ISpace[""MF_T1_JourneyPurpose""].Visible=""true"";ISpace[""MFG_T2_PNRNo""].Visible=""true"";ISpace[""MFG_T2_JourneyClass""].Visible=""true"";ISpace[""MFG_T2_DepartureTime""].Visible=""true"";ISpace[""MFG_T2_ToDate""].Visible=""true"";ISpace[""MF_T1_AccountNo""].Visible=""true"";ISpace[""MFG_T2_FromDate""].Visible=""true"";ISpace[""MFG_T3_Amount""].Visible=""true"";ISpace[""MF_T1_TravelType""].Visible=""true"";ISpace[""MF_T1_BankBranch""].Visible=""true"";ISpace[""MF_T1_ProjectNo""].Visible=""true"";ISpace[""MFG_T2_ArrivalTime""].Visible=""true"";ISpace[""MF_T1_AdvanceAmount""].Visible=""true"";ISpace[""MF_T1_TravellingPerson""].Visible=""true"";ISpace[""MF_T1_BeneficiaryName""].Visible=""true"";ISpace[""MF_T1_BankDocument""].Visible=""true"";ISpace[""MF_T1_TravelAdvanceID""].Visible=""false"";ISpace[""MF_T1_BankName""].Visible=""true"";ISpace[""MFG_T2_Arrival""].Visible=""true"";ISpace[""MF_T1_ReferenceNo""].Visible=""true"";");
ISpace["MG_T2_Arrival"].Visible="true";ISpace["MG_T2_Road"].Visible="true";ISpace["MG_T2_TADetailsID"].Visible="false";ISpace["MG_T2_PNRNo"].Visible="true";ISpace["MG_T2_Departure"].Visible="true";ISpace["MG_T2_DepartureDate"].Visible="true";ISpace["MG_T2_ArrivalDate"].Visible="true";ISpace["MG_T3_TravelAdvanceID"].Visible="false";ISpace["MG_T2_DepartureTime"].Visible="true";ISpace["MG_T2_JourneyClass"].Visible="true";ISpace["MG_T2_ModeofJourney"].Visible="true";ISpace["MG_T2_ArrivalTime"].Visible="true";ISpace["MG_T2_Amount"].Visible="true";
base.WriteDebugInfo(@"ISpace[""MG_T2_Arrival""].Visible=""true"";ISpace[""MG_T2_Road""].Visible=""true"";ISpace[""MG_T2_TADetailsID""].Visible=""false"";ISpace[""MG_T2_PNRNo""].Visible=""true"";ISpace[""MG_T2_Departure""].Visible=""true"";ISpace[""MG_T2_DepartureDate""].Visible=""true"";ISpace[""MG_T2_ArrivalDate""].Visible=""true"";ISpace[""MG_T3_TravelAdvanceID""].Visible=""false"";ISpace[""MG_T2_DepartureTime""].Visible=""true"";ISpace[""MG_T2_JourneyClass""].Visible=""true"";ISpace[""MG_T2_ModeofJourney""].Visible=""true"";ISpace[""MG_T2_ArrivalTime""].Visible=""true"";ISpace[""MG_T2_Amount""].Visible=""true"";");
ISpace["MG_T3_Amount"].Visible="true";ISpace["MG_T2_ExpenditureTypeID"].Visible="false";ISpace["MG_T2_FromDate"].Visible="true";ISpace["MG_T2_ToDate"].Visible="true";ISpace["MG_T2_TravelAdvanceID"].Visible="false";
base.WriteDebugInfo(@"ISpace[""MG_T3_Amount""].Visible=""true"";ISpace[""MG_T2_ExpenditureTypeID""].Visible=""false"";ISpace[""MG_T2_FromDate""].Visible=""true"";ISpace[""MG_T2_ToDate""].Visible=""true"";ISpace[""MG_T2_TravelAdvanceID""].Visible=""false"";");

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
ISpace["MF_ProjectNo"].Visible="false";ISpace["MF_BudgetHead"].Visible="false";ISpace["MF_Amount"].Visible="false";
base.WriteDebugInfo(@"ISpace[""MF_ProjectNo""].Visible=""false"";ISpace[""MF_BudgetHead""].Visible=""false"";ISpace[""MF_Amount""].Visible=""false"";");

ISpace["M_OpenModal"].Visible="false";
base.WriteDebugInfo(@"ISpace[""M_OpenModal""].Visible=""false"";");
ISpace["MF_InstanceId"].Value=Guid.NewGuid().ToString();
base.WriteDebugInfo(@"ISpace[""MF_InstanceId""].Value=Guid.NewGuid().ToString();");

}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["M_InitiatorUserMapId"].Value=ISpace["gv_usermapid"].Value;
base.WriteDebugInfo(@"ISpace[""M_InitiatorUserMapId""].Value=ISpace[""gv_usermapid""].Value;");
if(ISpace["FormVersionId"].Value=="817AE0D5-4499-4C2A-9284-F655B64E42CE")
{
ISpace["UI_InvisibleRow"].Visible="false";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""817AE0D5-4499-4C2A-9284-F655B64E42CE"")
{
ISpace[""UI_InvisibleRow""].Visible=""false"";
}");
base.WriteDebugInfo(@"EXEC [GetEmployeeUserContextDetails] '@@gv_UserId'");

var querySource805F857AE6164D34A84914552D9D77C8 =GetQueryExpressionDataSource("805F857A-E616-4D34-A849-14552D9D77C8");
Dictionary<short,object> result805F857AE6164D34A84914552D9D77C8=iSpace.ExecuteQuery(querySource805F857AE6164D34A84914552D9D77C8,@"EXEC [GetEmployeeUserContextDetails] '" + ISpace["gv_userid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource805F857AE6164D34A84914552D9D77C8 =GetQueryExpressionDataSource(""805F857A-E616-4D34-A849-14552D9D77C8"");Dictionary<short,object> result805F857AE6164D34A84914552D9D77C8=iSpace.ExecuteQuery(querySource805F857AE6164D34A84914552D9D77C8,@""EXEC [GetEmployeeUserContextDetails] '"" + ISpace[""gv_userid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result805F857AE6164D34A84914552D9D77C8!=null) && (result805F857AE6164D34A84914552D9D77C8.Count!=0))
{
if(result805F857AE6164D34A84914552D9D77C8.ContainsKey(4))
ISpace["UC_DOJ"].Value = result805F857AE6164D34A84914552D9D77C8[4];
if(result805F857AE6164D34A84914552D9D77C8.ContainsKey(3))
ISpace["UC_EmailId"].Value = result805F857AE6164D34A84914552D9D77C8[3];
if(result805F857AE6164D34A84914552D9D77C8.ContainsKey(5))
ISpace["UC_PhoneNumber"].Value = result805F857AE6164D34A84914552D9D77C8[5];
if(result805F857AE6164D34A84914552D9D77C8.ContainsKey(7))
ISpace["UC_Designation"].Value = result805F857AE6164D34A84914552D9D77C8[7];
if(result805F857AE6164D34A84914552D9D77C8.ContainsKey(0))
ISpace["UC_EmployeeBaicInfoId"].Value = result805F857AE6164D34A84914552D9D77C8[0];
if(result805F857AE6164D34A84914552D9D77C8.ContainsKey(1))
ISpace["UC_EmployeeId"].Value = result805F857AE6164D34A84914552D9D77C8[1];
if(result805F857AE6164D34A84914552D9D77C8.ContainsKey(9))
ISpace["UC_DOB"].Value = result805F857AE6164D34A84914552D9D77C8[9];
if(result805F857AE6164D34A84914552D9D77C8.ContainsKey(11))
ISpace["UC_Grade"].Value = result805F857AE6164D34A84914552D9D77C8[11];
if(result805F857AE6164D34A84914552D9D77C8.ContainsKey(10))
ISpace["UC_DOR"].Value = result805F857AE6164D34A84914552D9D77C8[10];
if(result805F857AE6164D34A84914552D9D77C8.ContainsKey(2))
ISpace["UC_Name"].Value = result805F857AE6164D34A84914552D9D77C8[2];
if(result805F857AE6164D34A84914552D9D77C8.ContainsKey(6))
ISpace["UC_Department"].Value = result805F857AE6164D34A84914552D9D77C8[6];
if(result805F857AE6164D34A84914552D9D77C8.ContainsKey(12))
ISpace["UC_Paylevel"].Value = result805F857AE6164D34A84914552D9D77C8[12];
}
else{
ISpace["UC_DOJ"].Value = null;ISpace["UC_EmailId"].Value = null;ISpace["UC_PhoneNumber"].Value = null;ISpace["UC_Designation"].Value = null;ISpace["UC_EmployeeBaicInfoId"].Value = null;ISpace["UC_EmployeeId"].Value = null;ISpace["UC_DOB"].Value = null;ISpace["UC_Grade"].Value = null;ISpace["UC_DOR"].Value = null;ISpace["UC_Name"].Value = null;ISpace["UC_Department"].Value = null;ISpace["UC_Paylevel"].Value = null;
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
ISpace["M_TravelInstanceId"].Value=Guid.NewGuid().ToString();
base.WriteDebugInfo(@"ISpace[""M_TravelInstanceId""].Value=Guid.NewGuid().ToString();");
ISpace["UC_DOJ"].Visible="false";ISpace["UC_EmailId"].Visible="false";ISpace["UC_PhoneNumber"].Visible="false";ISpace["UC_DOB"].Visible="false";ISpace["UC_Grade"].Visible="false";ISpace["UC_DOR"].Visible="false";ISpace["UC_Paylevel"].Visible="false";
base.WriteDebugInfo(@"ISpace[""UC_DOJ""].Visible=""false"";ISpace[""UC_EmailId""].Visible=""false"";ISpace[""UC_PhoneNumber""].Visible=""false"";ISpace[""UC_DOB""].Visible=""false"";ISpace[""UC_Grade""].Visible=""false"";ISpace[""UC_DOR""].Visible=""false"";ISpace[""UC_Paylevel""].Visible=""false"";");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC GetDestinationDetails '#M_SourceActivityMapId'");

var querySourceCFA125541F394BC48046E8A347DB7B6E =GetQueryExpressionDataSource("CFA12554-1F39-4BC4-8046-E8A347DB7B6E");
Dictionary<short,object> resultCFA125541F394BC48046E8A347DB7B6E=iSpace.ExecuteQuery(querySourceCFA125541F394BC48046E8A347DB7B6E,@"EXEC GetDestinationDetails '" + ISpace["M_SourceActivityMapId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceCFA125541F394BC48046E8A347DB7B6E =GetQueryExpressionDataSource(""CFA12554-1F39-4BC4-8046-E8A347DB7B6E"");Dictionary<short,object> resultCFA125541F394BC48046E8A347DB7B6E=iSpace.ExecuteQuery(querySourceCFA125541F394BC48046E8A347DB7B6E,@""EXEC GetDestinationDetails '"" + ISpace[""M_SourceActivityMapId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultCFA125541F394BC48046E8A347DB7B6E!=null) && (resultCFA125541F394BC48046E8A347DB7B6E.Count!=0))
{
if(resultCFA125541F394BC48046E8A347DB7B6E.ContainsKey(2))
ISpace["M_NextStage"].Value = resultCFA125541F394BC48046E8A347DB7B6E[2];
if(resultCFA125541F394BC48046E8A347DB7B6E.ContainsKey(0))
ISpace["M_DestinationActivityId"].Value = resultCFA125541F394BC48046E8A347DB7B6E[0];
if(resultCFA125541F394BC48046E8A347DB7B6E.ContainsKey(5))
ISpace["M_Remarks"].Value = resultCFA125541F394BC48046E8A347DB7B6E[5];
}
else{
ISpace["M_NextStage"].Value = null;ISpace["M_DestinationActivityId"].Value = null;ISpace["M_Remarks"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["MFG_T2_ModeofJourney"].Man=true;ISpace["MFG_T2_Departure"].Man=true;ISpace["MFG_T2_Road"].Man=true;ISpace["MFG_T2_DepartureDate"].Man=true;ISpace["MFG_T2_ArrivalDate"].Man=true;ISpace["MF_T1_BudgetHead"].Man=true;ISpace["M_IsAdvanceRequired"].Man=true;ISpace["MF_T1_Destination"].Man=true;ISpace["MFG_T2_Amount"].Man=true;ISpace["MF_T1_AvailableBudget"].Man=true;ISpace["MF_T1_JourneyPurpose"].Man=true;ISpace["MFG_T2_PNRNo"].Man=false;ISpace["MFG_T2_JourneyClass"].Man=false;ISpace["MFG_T2_DepartureTime"].Man=true;ISpace["MFG_T2_ToDate"].Man=true;ISpace["M_TravelPlace"].Man=true;ISpace["MF_T1_AccountNo"].Man=true;ISpace["MFG_T2_FromDate"].Man=true;ISpace["MFG_T3_Amount"].Man=true;ISpace["MF_T1_TravelType"].Man=true;ISpace["MF_T1_BankBranch"].Man=true;ISpace["MF_T1_ProjectNo"].Man=true;ISpace["MFG_T2_ArrivalTime"].Man=true;ISpace["MF_T1_AdvanceAmount"].Man=true;ISpace["MF_T1_TravellingPerson"].Man=true;ISpace["MF_T1_BeneficiaryName"].Man=true;ISpace["MF_T1_BankDocument"].Man=true;ISpace["Travel_Type"].Man=true;ISpace["Travel_Type"].Enbl="true";ISpace["MF_T1_BankName"].Man=true;ISpace["MFG_T2_Arrival"].Man=true;ISpace["MF_T1_ReferenceNo"].Man=true;
base.WriteDebugInfo(@"ISpace[""MFG_T2_ModeofJourney""].Man=true;ISpace[""MFG_T2_Departure""].Man=true;ISpace[""MFG_T2_Road""].Man=true;ISpace[""MFG_T2_DepartureDate""].Man=true;ISpace[""MFG_T2_ArrivalDate""].Man=true;ISpace[""MF_T1_BudgetHead""].Man=true;ISpace[""M_IsAdvanceRequired""].Man=true;ISpace[""MF_T1_Destination""].Man=true;ISpace[""MFG_T2_Amount""].Man=true;ISpace[""MF_T1_AvailableBudget""].Man=true;ISpace[""MF_T1_JourneyPurpose""].Man=true;ISpace[""MFG_T2_PNRNo""].Man=false;ISpace[""MFG_T2_JourneyClass""].Man=false;ISpace[""MFG_T2_DepartureTime""].Man=true;ISpace[""MFG_T2_ToDate""].Man=true;ISpace[""M_TravelPlace""].Man=true;ISpace[""MF_T1_AccountNo""].Man=true;ISpace[""MFG_T2_FromDate""].Man=true;ISpace[""MFG_T3_Amount""].Man=true;ISpace[""MF_T1_TravelType""].Man=true;ISpace[""MF_T1_BankBranch""].Man=true;ISpace[""MF_T1_ProjectNo""].Man=true;ISpace[""MFG_T2_ArrivalTime""].Man=true;ISpace[""MF_T1_AdvanceAmount""].Man=true;ISpace[""MF_T1_TravellingPerson""].Man=true;ISpace[""MF_T1_BeneficiaryName""].Man=true;ISpace[""MF_T1_BankDocument""].Man=true;ISpace[""Travel_Type""].Man=true;ISpace[""Travel_Type""].Enbl=""true"";ISpace[""MF_T1_BankName""].Man=true;ISpace[""MFG_T2_Arrival""].Man=true;ISpace[""MF_T1_ReferenceNo""].Man=true;");
ISpace["MF_FundType"].Man=true;
base.WriteDebugInfo(@"ISpace[""MF_FundType""].Man=true;");
ISpace["MG_T2_Arrival"].Man=true;ISpace["MG_T2_Departure"].Man=true;ISpace["MG_T2_DepartureDate"].Man=true;ISpace["MG_T2_ArrivalDate"].Man=true;ISpace["MG_T2_DepartureTime"].Man=true;ISpace["MG_T2_JourneyClass"].Man=false;ISpace["MG_T2_ModeofJourney"].Man=true;ISpace["MG_T2_ArrivalTime"].Man=true;ISpace["MG_T2_Amount"].Man=true;
base.WriteDebugInfo(@"ISpace[""MG_T2_Arrival""].Man=true;ISpace[""MG_T2_Departure""].Man=true;ISpace[""MG_T2_DepartureDate""].Man=true;ISpace[""MG_T2_ArrivalDate""].Man=true;ISpace[""MG_T2_DepartureTime""].Man=true;ISpace[""MG_T2_JourneyClass""].Man=false;ISpace[""MG_T2_ModeofJourney""].Man=true;ISpace[""MG_T2_ArrivalTime""].Man=true;ISpace[""MG_T2_Amount""].Man=true;");
ISpace["MG_T3_Amount"].Man=true;ISpace["MG_T2_FromDate"].Man=true;ISpace["MG_T2_ToDate"].Man=true;
base.WriteDebugInfo(@"ISpace[""MG_T3_Amount""].Man=true;ISpace[""MG_T2_FromDate""].Man=true;ISpace[""MG_T2_ToDate""].Man=true;");
}
if(ISpace["Travel_Type"].Value=="1")
{
base.WriteDebugInfo(@"if(ISpace[""Travel_Type""].Value==""1"")");
ISpace["MF_T1_AccountNo"].Man=false;ISpace["MF_T1_BankBranch"].Man=false;ISpace["MF_T1_BeneficiaryName"].Man=false;ISpace["MF_T1_BankDocument"].Man=false;ISpace["MF_T1_BankName"].Man=false;
base.WriteDebugInfo(@"ISpace[""MF_T1_AccountNo""].Man=false;ISpace[""MF_T1_BankBranch""].Man=false;ISpace[""MF_T1_BeneficiaryName""].Man=false;ISpace[""MF_T1_BankDocument""].Man=false;ISpace[""MF_T1_BankName""].Man=false;");
}
if(ISpace["Travel_Type"].Value=="3")
{
base.WriteDebugInfo(@"if(ISpace[""Travel_Type""].Value==""3"")");
ISpace["MF_T1_AccountNo"].Man=true;ISpace["MF_T1_AccountNo"].Enbl="true";ISpace["MF_T1_BankBranch"].Man=true;ISpace["MF_T1_BankBranch"].Enbl="true";ISpace["MF_T1_AdvanceAmount"].Man=true;ISpace["MF_T1_AdvanceAmount"].Enbl="true";ISpace["MF_T1_BeneficiaryName"].Man=true;ISpace["MF_T1_BeneficiaryName"].Enbl="true";ISpace["MF_T1_BankDocument"].Man=true;ISpace["MF_T1_BankDocument"].Enbl="true";ISpace["MF_T1_BankName"].Man=true;ISpace["MF_T1_BankName"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_T1_AccountNo""].Man=true;ISpace[""MF_T1_AccountNo""].Enbl=""true"";ISpace[""MF_T1_BankBranch""].Man=true;ISpace[""MF_T1_BankBranch""].Enbl=""true"";ISpace[""MF_T1_AdvanceAmount""].Man=true;ISpace[""MF_T1_AdvanceAmount""].Enbl=""true"";ISpace[""MF_T1_BeneficiaryName""].Man=true;ISpace[""MF_T1_BeneficiaryName""].Enbl=""true"";ISpace[""MF_T1_BankDocument""].Man=true;ISpace[""MF_T1_BankDocument""].Enbl=""true"";ISpace[""MF_T1_BankName""].Man=true;ISpace[""MF_T1_BankName""].Enbl=""true"";");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"SELECT CONCAT('#UC_EmployeeId','/',Right(Year(getdate()),2),'-',Right(Year(getdate()),2)+1,'/TR/',NEXT VALUE FOR TravelSeq)");

var querySourceDEC46E0F7EB548CF8CA86728550C0AD3 =GetQueryExpressionDataSource("DEC46E0F-7EB5-48CF-8CA8-6728550C0AD3");
Dictionary<short,object> resultDEC46E0F7EB548CF8CA86728550C0AD3=iSpace.ExecuteQuery(querySourceDEC46E0F7EB548CF8CA86728550C0AD3,@"SELECT CONCAT('" + ISpace["UC_EmployeeId"].Value + @"','/',Right(Year(getdate()),2),'-',Right(Year(getdate()),2)+1,'/TR/',NEXT VALUE FOR TravelSeq)",false);

base.WriteDebugInfo(@"var querySourceDEC46E0F7EB548CF8CA86728550C0AD3 =GetQueryExpressionDataSource(""DEC46E0F-7EB5-48CF-8CA8-6728550C0AD3"");Dictionary<short,object> resultDEC46E0F7EB548CF8CA86728550C0AD3=iSpace.ExecuteQuery(querySourceDEC46E0F7EB548CF8CA86728550C0AD3,@""SELECT CONCAT('"" + ISpace[""UC_EmployeeId""].Value + @""','/',Right(Year(getdate()),2),'-',Right(Year(getdate()),2)+1,'/TR/',NEXT VALUE FOR TravelSeq)"",false);");
base.WriteDebugInfo(@"");

if((resultDEC46E0F7EB548CF8CA86728550C0AD3!=null) && (resultDEC46E0F7EB548CF8CA86728550C0AD3.Count!=0))
{
if(resultDEC46E0F7EB548CF8CA86728550C0AD3.ContainsKey(0))
ISpace["MF_T1_ReferenceNo"].Value = resultDEC46E0F7EB548CF8CA86728550C0AD3[0];
}
else{
ISpace["MF_T1_ReferenceNo"].Value = null;
}
ISpace["Subject"].Value=ISpace["MF_T1_ReferenceNo"].Value;
base.WriteDebugInfo(@"ISpace[""Subject""].Value=ISpace[""MF_T1_ReferenceNo""].Value;");
}
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
ISpace["MFG_T2_Road"].Visible="false";ISpace["MFG_T2_Road"].Man=false;ISpace["MFG_T2_PNRNo"].Visible="false";ISpace["MFG_T2_PNRNo"].Man=false;
base.WriteDebugInfo(@"ISpace[""MFG_T2_Road""].Visible=""false"";ISpace[""MFG_T2_Road""].Man=false;ISpace[""MFG_T2_PNRNo""].Visible=""false"";ISpace[""MFG_T2_PNRNo""].Man=false;");
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
base.WriteDebugInfo(@"EXEC LoadFormGridData51838b372ec64d358a5e38648bc93ab1 '@@gv_InstanceId','@@gv_ProcessMapId','51838b37-2ec6-4d35-8a5e-38648bc93ab1','@@gv_ActivityMapId','#growid'");

var querySource4D420532A15346488F67A53328C6B6EC =GetQueryExpressionDataSource("4D420532-A153-4648-8F67-A53328C6B6EC");
Dictionary<short,object> result4D420532A15346488F67A53328C6B6EC=iSpace.ExecuteQuery(querySource4D420532A15346488F67A53328C6B6EC,@"EXEC LoadFormGridData51838b372ec64d358a5e38648bc93ab1 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','51838b37-2ec6-4d35-8a5e-38648bc93ab1','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["growid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource4D420532A15346488F67A53328C6B6EC =GetQueryExpressionDataSource(""4D420532-A153-4648-8F67-A53328C6B6EC"");Dictionary<short,object> result4D420532A15346488F67A53328C6B6EC=iSpace.ExecuteQuery(querySource4D420532A15346488F67A53328C6B6EC,@""EXEC LoadFormGridData51838b372ec64d358a5e38648bc93ab1 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','51838b37-2ec6-4d35-8a5e-38648bc93ab1','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""growid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result4D420532A15346488F67A53328C6B6EC!=null) && (result4D420532A15346488F67A53328C6B6EC.Count!=0))
{
if(result4D420532A15346488F67A53328C6B6EC.ContainsKey(3))
ISpace["MFG_T2_ToDate"].Value = result4D420532A15346488F67A53328C6B6EC[3];
if(result4D420532A15346488F67A53328C6B6EC.ContainsKey(2))
ISpace["MFG_T2_FromDate"].Value = result4D420532A15346488F67A53328C6B6EC[2];
if(result4D420532A15346488F67A53328C6B6EC.ContainsKey(0))
ISpace["MFG_T2_ExpenditureTypeID"].Value = result4D420532A15346488F67A53328C6B6EC[0];
if(result4D420532A15346488F67A53328C6B6EC.ContainsKey(4))
ISpace["MFG_T3_Amount"].Value = result4D420532A15346488F67A53328C6B6EC[4];
if(result4D420532A15346488F67A53328C6B6EC.ContainsKey(1))
ISpace["MFG_T2_TravelAdvanceID"].Value = result4D420532A15346488F67A53328C6B6EC[1];
}
else{
ISpace["MFG_T2_ToDate"].Value = null;ISpace["MFG_T2_FromDate"].Value = null;ISpace["MFG_T2_ExpenditureTypeID"].Value = null;ISpace["MFG_T3_Amount"].Value = null;ISpace["MFG_T2_TravelAdvanceID"].Value = null;
}
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
ISpace["MF_BudgetHead"].rElemData=iSpace.Reload(ISpace["MF_BudgetHead"].Value,@"exec SP_GetDistrubitionDetails 5,'@" + ISpace["gv_ProcessMapId"].Value + @"'," + ISpace["MF_FundType"].Value + @",'','','','','" + ISpace["MF_ProjectNo"].Value + @"'","9ADED37B-CD11-426B-AF16-DEAC75685EF5");
base.WriteDebugInfo(@"ISpace[""MF_BudgetHead""].rElemData=iSpace.Reload(ISpace[""MF_BudgetHead""].Value,@""exec SP_GetDistrubitionDetails 5,'@"" + ISpace[""gv_ProcessMapId""].Value + @""',"" + ISpace[""MF_FundType""].Value + @"",'','','','','"" + ISpace[""MF_ProjectNo""].Value + @""'"",""9ADED37B-CD11-426B-AF16-DEAC75685EF5"");");
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

var querySource797A60C10BB64A40915695B92AAFC889 =GetQueryExpressionDataSource("797A60C1-0BB6-4A40-9156-95B92AAFC889");
Dictionary<short,object> result797A60C10BB64A40915695B92AAFC889=iSpace.ExecuteQuery(querySource797A60C10BB64A40915695B92AAFC889,@"SELECT " + ISpace["OverAll_Total"].Value + @"*0.9",false);

base.WriteDebugInfo(@"var querySource797A60C10BB64A40915695B92AAFC889 =GetQueryExpressionDataSource(""797A60C1-0BB6-4A40-9156-95B92AAFC889"");Dictionary<short,object> result797A60C10BB64A40915695B92AAFC889=iSpace.ExecuteQuery(querySource797A60C10BB64A40915695B92AAFC889,@""SELECT "" + ISpace[""OverAll_Total""].Value + @""*0.9"",false);");
base.WriteDebugInfo(@"");

if((result797A60C10BB64A40915695B92AAFC889!=null) && (result797A60C10BB64A40915695B92AAFC889.Count!=0))
{
if(result797A60C10BB64A40915695B92AAFC889.ContainsKey(0))
ISpace["T_AdvanceDrawn"].Value = result797A60C10BB64A40915695B92AAFC889[0];
}
else{
ISpace["T_AdvanceDrawn"].Value = null;
}
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

var querySource797A60C10BB64A40915695B92AAFC889 =GetQueryExpressionDataSource("797A60C1-0BB6-4A40-9156-95B92AAFC889");
Dictionary<short,object> result797A60C10BB64A40915695B92AAFC889=iSpace.ExecuteQuery(querySource797A60C10BB64A40915695B92AAFC889,@"SELECT " + ISpace["OverAll_Total"].Value + @"*0.9",false);

base.WriteDebugInfo(@"var querySource797A60C10BB64A40915695B92AAFC889 =GetQueryExpressionDataSource(""797A60C1-0BB6-4A40-9156-95B92AAFC889"");Dictionary<short,object> result797A60C10BB64A40915695B92AAFC889=iSpace.ExecuteQuery(querySource797A60C10BB64A40915695B92AAFC889,@""SELECT "" + ISpace[""OverAll_Total""].Value + @""*0.9"",false);");
base.WriteDebugInfo(@"");

if((result797A60C10BB64A40915695B92AAFC889!=null) && (result797A60C10BB64A40915695B92AAFC889.Count!=0))
{
if(result797A60C10BB64A40915695B92AAFC889.ContainsKey(0))
ISpace["T_AdvanceDrawn"].Value = result797A60C10BB64A40915695B92AAFC889[0];
}
else{
ISpace["T_AdvanceDrawn"].Value = null;
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
object MG_Amount=iSpace.Sum("[AD9C54EC-27A0-4C21-9923-063084E3B588]","MG_Amount","",ISpace["gv_instanceid"].Value);
ISpace["M_SumOfFund"].Value=Convert.ChangeType(MG_Amount, MG_Amount.GetType());;
base.WriteDebugInfo(@"object MG_Amount=iSpace.Sum(""[AD9C54EC-27A0-4C21-9923-063084E3B588]"",""MG_Amount"","""",ISpace[""gv_instanceid""].Value);
ISpace[""M_SumOfFund""].Value=Convert.ChangeType(MG_Amount, MG_Amount.GetType());;");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["Travel_Type"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""Travel_Type""].Value=="""")");
ISpace["Message"].Value=@"Please enter the Travel Type";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please enter the Travel Type"";");
return;
base.WriteDebugInfo(@"return;");
}
if(ISpace["M_TravelPlace"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""M_TravelPlace""].Value=="""")");
ISpace["Message"].Value=@"Please enter the Place of Travel";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please enter the Place of Travel"";");
return;
base.WriteDebugInfo(@"return;");
}
if(Trim(ISpace["MF_T1_JourneyPurpose"].Value)=="")
{
base.WriteDebugInfo(@"if(Trim(ISpace[""MF_T1_JourneyPurpose""].Value)=="""")");
ISpace["Message"].Value=@"Please enter the Purpose of Travel";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please enter the Purpose of Travel"";");
return;
base.WriteDebugInfo(@"return;");
}
if(ISpace["M_IsAdvanceRequired"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""M_IsAdvanceRequired""].Value=="""")");
ISpace["Message"].Value=@"Please select Is Advance Required";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please select Is Advance Required"";");
return;
base.WriteDebugInfo(@"return;");
}
if(Trim(ISpace["MF_T1_BankBranch"].Value)==""&&ISpace["Travel_Type"].Value=="3")
{
base.WriteDebugInfo(@"if(Trim(ISpace[""MF_T1_BankBranch""].Value)==""""&&ISpace[""Travel_Type""].Value==""3"")");
ISpace["Message"].Value=@"Please enter the Bank Branch";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please enter the Bank Branch"";");
return;
base.WriteDebugInfo(@"return;");
}
if(Trim(ISpace["MF_T1_BeneficiaryName"].Value)==""&&ISpace["Travel_Type"].Value=="3")
{
base.WriteDebugInfo(@"if(Trim(ISpace[""MF_T1_BeneficiaryName""].Value)==""""&&ISpace[""Travel_Type""].Value==""3"")");
ISpace["Message"].Value=@"Please enter the Beneficiary Name";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please enter the Beneficiary Name"";");
return;
base.WriteDebugInfo(@"return;");
}
if(Trim(ISpace["MF_T1_AccountNo"].Value)==""&&ISpace["Travel_Type"].Value=="3")
{
base.WriteDebugInfo(@"if(Trim(ISpace[""MF_T1_AccountNo""].Value)==""""&&ISpace[""Travel_Type""].Value==""3"")");
ISpace["Message"].Value=@"Please enter the Account No";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please enter the Account No"";");
return;
base.WriteDebugInfo(@"return;");
}
if(Trim(ISpace["MF_T1_BankName"].Value)==""&&ISpace["Travel_Type"].Value=="3")
{
base.WriteDebugInfo(@"if(Trim(ISpace[""MF_T1_BankName""].Value)==""""&&ISpace[""Travel_Type""].Value==""3"")");
ISpace["Message"].Value=@"Please enter the Bank Name";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please enter the Bank Name"";");
return;
base.WriteDebugInfo(@"return;");
}
if((ISpace["MF_T1_BankDocument"].Value == null)&&ISpace["Travel_Type"].Value=="3")
{
base.WriteDebugInfo(@"if((ISpace[""MF_T1_BankDocument""].Value == null)&&ISpace[""Travel_Type""].Value==""3"")");
ISpace["Message"].Value=@"Please enter the Bank Document";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please enter the Bank Document"";");
return;
base.WriteDebugInfo(@"return;");
}
if(ISpace["M_IsAdvanceRequired"].Value=="Yes")
{
base.WriteDebugInfo(@"if(ISpace[""M_IsAdvanceRequired""].Value==""Yes"")");
if(ISpace["MF_T1_AdvanceAmount"].Value==0)
{
base.WriteDebugInfo(@"if(ISpace[""MF_T1_AdvanceAmount""].Value==0)");
ISpace["Message"].Value=@"Please enter the Advance Amount";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please enter the Advance Amount"";");
return;
base.WriteDebugInfo(@"return;");
}
if(ISpace["T_AdvanceDrawn"].Value<ISpace["MF_T1_AdvanceAmount"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""T_AdvanceDrawn""].Value<ISpace[""MF_T1_AdvanceAmount""].Value)");
ISpace["Message"].Value=@"Eligible Advance and Advance Amount should be Equal or lesser than";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Eligible Advance and Advance Amount should be Equal or lesser than"";");
return;
base.WriteDebugInfo(@"return;");
}
}
if(ISpace["M_IsAdvanceRequired"].Value=="Yes")
{
base.WriteDebugInfo(@"if(ISpace[""M_IsAdvanceRequired""].Value==""Yes"")");
if(ISpace["M_SumOfFund"].Value!=ISpace["MF_T1_AdvanceAmount"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""M_SumOfFund""].Value!=ISpace[""MF_T1_AdvanceAmount""].Value)");
ISpace["Message"].Value=@"Please add Source Fund Amount equal to Advance Amount";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please add Source Fund Amount equal to Advance Amount"";");
return;
base.WriteDebugInfo(@"return;");
}
}
if(ISpace["MF_CountDoc"].Value>0)
{
base.WriteDebugInfo(@"if(ISpace[""MF_CountDoc""].Value>0)");
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
return;
base.WriteDebugInfo(@"return;");
}

if(
IsNullOrEmpty(ISpace["M_UploadDcoument"].Value))
{
base.WriteDebugInfo(@"
if(
IsNullOrEmpty(ISpace[""M_UploadDcoument""].Value))");
ISpace["Message"].Value=@"Please Upload Document";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please Upload Document"";");
return;
base.WriteDebugInfo(@"return;");
}
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("MG_DcoumentDetails","B5EF84C8-83A9-4B1C-9431-0489F9EC063B",_objectFactory.GetGridRPP("MG_DcoumentDetails"),_elementBase.GetGridLoopQuery("B5EF84C8-83A9-4B1C-9431-0489F9EC063B","MG_DcoumentDetails",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""MG_DcoumentDetails"",ref ISpace);

foreach(var gridChild in ISpace[""MG_DcoumentDetails""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
}
}
ISpace["MF_TravelStatus"].Value="I";
base.WriteDebugInfo(@"ISpace[""MF_TravelStatus""].Value=""I"";");
ISpace["M_IsCommitment"].Value=1;
base.WriteDebugInfo(@"ISpace[""M_IsCommitment""].Value=1;");
if(ISpace["M_SaveDomainData"].Value==1||1==1)
{
base.WriteDebugInfo(@"if(ISpace[""M_SaveDomainData""].Value==1||1==1)");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC Repo198E5A8A61F54E7C92DD34146A7059EF '#CreatedOn','#MF_T1_BankDocument','#MF_T1_ReferenceNo','#MF_T1_AccountNo','#OverAll_Total','#UC_EmployeeBaicInfoId','#M_TravelPlace','#MF_T1_AdvanceAmount','#MF_T1_BankName','#MF_T1_TravelAdvanceID','#MF_T1_JourneyPurpose','#Travel_Type','#MF_T1_BeneficiaryName','#gv_UserId','#MF_TransactionNo','#MF_TravelStatus','#MF_TransactionDate','#M_IsAdvanceRequired'");

var querySourceD16F9C83EA714542AB4DE3D99AB969B2 =GetQueryExpressionDataSource("D16F9C83-EA71-4542-AB4D-E3D99AB969B2");
Dictionary<short,object> resultD16F9C83EA714542AB4DE3D99AB969B2=iSpace.ExecuteQuery(querySourceD16F9C83EA714542AB4DE3D99AB969B2,@"EXEC Repo198E5A8A61F54E7C92DD34146A7059EF '" + ISpace["CreatedOn"].Value + @"','" + ISpace["MF_T1_BankDocument"].Value + @"','" + ISpace["MF_T1_ReferenceNo"].Value + @"','" + ISpace["MF_T1_AccountNo"].Value + @"','" + ISpace["OverAll_Total"].Value + @"','" + ISpace["UC_EmployeeBaicInfoId"].Value + @"','" + ISpace["M_TravelPlace"].Value + @"','" + ISpace["MF_T1_AdvanceAmount"].Value + @"','" + ISpace["MF_T1_BankName"].Value + @"','" + ISpace["MF_T1_TravelAdvanceID"].Value + @"','" + ISpace["MF_T1_JourneyPurpose"].Value + @"','" + ISpace["Travel_Type"].Value + @"','" + ISpace["MF_T1_BeneficiaryName"].Value + @"','" + ISpace["gv_UserId"].Value + @"','" + ISpace["MF_TransactionNo"].Value + @"','" + ISpace["MF_TravelStatus"].Value + @"','" + ISpace["MF_TransactionDate"].Value + @"','" + ISpace["M_IsAdvanceRequired"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceD16F9C83EA714542AB4DE3D99AB969B2 =GetQueryExpressionDataSource(""D16F9C83-EA71-4542-AB4D-E3D99AB969B2"");Dictionary<short,object> resultD16F9C83EA714542AB4DE3D99AB969B2=iSpace.ExecuteQuery(querySourceD16F9C83EA714542AB4DE3D99AB969B2,@""EXEC Repo198E5A8A61F54E7C92DD34146A7059EF '"" + ISpace[""CreatedOn""].Value + @""','"" + ISpace[""MF_T1_BankDocument""].Value + @""','"" + ISpace[""MF_T1_ReferenceNo""].Value + @""','"" + ISpace[""MF_T1_AccountNo""].Value + @""','"" + ISpace[""OverAll_Total""].Value + @""','"" + ISpace[""UC_EmployeeBaicInfoId""].Value + @""','"" + ISpace[""M_TravelPlace""].Value + @""','"" + ISpace[""MF_T1_AdvanceAmount""].Value + @""','"" + ISpace[""MF_T1_BankName""].Value + @""','"" + ISpace[""MF_T1_TravelAdvanceID""].Value + @""','"" + ISpace[""MF_T1_JourneyPurpose""].Value + @""','"" + ISpace[""Travel_Type""].Value + @""','"" + ISpace[""MF_T1_BeneficiaryName""].Value + @""','"" + ISpace[""gv_UserId""].Value + @""','"" + ISpace[""MF_TransactionNo""].Value + @""','"" + ISpace[""MF_TravelStatus""].Value + @""','"" + ISpace[""MF_TransactionDate""].Value + @""','"" + ISpace[""M_IsAdvanceRequired""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultD16F9C83EA714542AB4DE3D99AB969B2!=null) && (resultD16F9C83EA714542AB4DE3D99AB969B2.Count!=0))
{
}
else{

}
base.WriteDebugInfo(@"EXEC Repo51838b372ec64d358a5e38648bc93ab1 '#gv_UserId','#UpdatedOn','#MF_T1_TravelAdvanceID','#MG_T2_ToDate','#MG_T2_FromDate','#M_IsTravelRequest','#MG_T2_ExpenditureTypeID','#Expenditure_Type','#MG_T3_Amount'");

var querySource864963C6427C451F8C30D7E8FCDD4228 =GetQueryExpressionDataSource("864963C6-427C-451F-8C30-D7E8FCDD4228");
Dictionary<short,object> result864963C6427C451F8C30D7E8FCDD4228=iSpace.ExecuteQuery(querySource864963C6427C451F8C30D7E8FCDD4228,@"EXEC Repo51838b372ec64d358a5e38648bc93ab1 '" + ISpace["gv_UserId"].Value + @"','" + ISpace["UpdatedOn"].Value + @"','" + ISpace["MF_T1_TravelAdvanceID"].Value + @"','" + ISpace["MG_T2_ToDate"].Value + @"','" + ISpace["MG_T2_FromDate"].Value + @"','" + ISpace["M_IsTravelRequest"].Value + @"','" + ISpace["MG_T2_ExpenditureTypeID"].Value + @"','" + ISpace["Expenditure_Type"].Value + @"','" + ISpace["MG_T3_Amount"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource864963C6427C451F8C30D7E8FCDD4228 =GetQueryExpressionDataSource(""864963C6-427C-451F-8C30-D7E8FCDD4228"");Dictionary<short,object> result864963C6427C451F8C30D7E8FCDD4228=iSpace.ExecuteQuery(querySource864963C6427C451F8C30D7E8FCDD4228,@""EXEC Repo51838b372ec64d358a5e38648bc93ab1 '"" + ISpace[""gv_UserId""].Value + @""','"" + ISpace[""UpdatedOn""].Value + @""','"" + ISpace[""MF_T1_TravelAdvanceID""].Value + @""','"" + ISpace[""MG_T2_ToDate""].Value + @""','"" + ISpace[""MG_T2_FromDate""].Value + @""','"" + ISpace[""M_IsTravelRequest""].Value + @""','"" + ISpace[""MG_T2_ExpenditureTypeID""].Value + @""','"" + ISpace[""Expenditure_Type""].Value + @""','"" + ISpace[""MG_T3_Amount""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result864963C6427C451F8C30D7E8FCDD4228!=null) && (result864963C6427C451F8C30D7E8FCDD4228.Count!=0))
{
}
else{

}
base.WriteDebugInfo(@"EXEC Repo374fb8a88dd94cf1bf73f40ae18fcad7 '#M_IsTravelRequest','#UpdatedOn','#MG_T2_TADetailsID','#gv_UserId','#MG_T2_DepartureDate','#MG_T2_DepartureTime','#MG_T2_ArrivalDate','#MG_T2_Road','#MF_T1_TravelAdvanceID','#MG_T2_Departure','#MG_T2_Amount','#MG_T2_JourneyClass','#MG_T2_Arrival','#MG_T2_PNRNo','#MG_T2_ModeofJourney','#MG_T2_ArrivalTime'");

var querySourceEBE446FD1D9E41DEB663DEAA6EE73345 =GetQueryExpressionDataSource("EBE446FD-1D9E-41DE-B663-DEAA6EE73345");
Dictionary<short,object> resultEBE446FD1D9E41DEB663DEAA6EE73345=iSpace.ExecuteQuery(querySourceEBE446FD1D9E41DEB663DEAA6EE73345,@"EXEC Repo374fb8a88dd94cf1bf73f40ae18fcad7 '" + ISpace["M_IsTravelRequest"].Value + @"','" + ISpace["UpdatedOn"].Value + @"','" + ISpace["MG_T2_TADetailsID"].Value + @"','" + ISpace["gv_UserId"].Value + @"','" + ISpace["MG_T2_DepartureDate"].Value + @"','" + ISpace["MG_T2_DepartureTime"].Value + @"','" + ISpace["MG_T2_ArrivalDate"].Value + @"','" + ISpace["MG_T2_Road"].Value + @"','" + ISpace["MF_T1_TravelAdvanceID"].Value + @"','" + ISpace["MG_T2_Departure"].Value + @"','" + ISpace["MG_T2_Amount"].Value + @"','" + ISpace["MG_T2_JourneyClass"].Value + @"','" + ISpace["MG_T2_Arrival"].Value + @"','" + ISpace["MG_T2_PNRNo"].Value + @"','" + ISpace["MG_T2_ModeofJourney"].Value + @"','" + ISpace["MG_T2_ArrivalTime"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceEBE446FD1D9E41DEB663DEAA6EE73345 =GetQueryExpressionDataSource(""EBE446FD-1D9E-41DE-B663-DEAA6EE73345"");Dictionary<short,object> resultEBE446FD1D9E41DEB663DEAA6EE73345=iSpace.ExecuteQuery(querySourceEBE446FD1D9E41DEB663DEAA6EE73345,@""EXEC Repo374fb8a88dd94cf1bf73f40ae18fcad7 '"" + ISpace[""M_IsTravelRequest""].Value + @""','"" + ISpace[""UpdatedOn""].Value + @""','"" + ISpace[""MG_T2_TADetailsID""].Value + @""','"" + ISpace[""gv_UserId""].Value + @""','"" + ISpace[""MG_T2_DepartureDate""].Value + @""','"" + ISpace[""MG_T2_DepartureTime""].Value + @""','"" + ISpace[""MG_T2_ArrivalDate""].Value + @""','"" + ISpace[""MG_T2_Road""].Value + @""','"" + ISpace[""MF_T1_TravelAdvanceID""].Value + @""','"" + ISpace[""MG_T2_Departure""].Value + @""','"" + ISpace[""MG_T2_Amount""].Value + @""','"" + ISpace[""MG_T2_JourneyClass""].Value + @""','"" + ISpace[""MG_T2_Arrival""].Value + @""','"" + ISpace[""MG_T2_PNRNo""].Value + @""','"" + ISpace[""MG_T2_ModeofJourney""].Value + @""','"" + ISpace[""MG_T2_ArrivalTime""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultEBE446FD1D9E41DEB663DEAA6EE73345!=null) && (resultEBE446FD1D9E41DEB663DEAA6EE73345.Count!=0))
{
}
else{

}
base.WriteDebugInfo(@"EXEC DocumentsDomain '#M_DocumentDetailsId','#M_PackageProcessMapId','#UpdatedOn','#M_DocumentName','#gv_UserId','#M_UploadDcoument','#MF_T1_TravelAdvanceID'");

var querySource1D2378FB2963489899022B61F44BE0AD =GetQueryExpressionDataSource("1D2378FB-2963-4898-9902-2B61F44BE0AD");
Dictionary<short,object> result1D2378FB2963489899022B61F44BE0AD=iSpace.ExecuteQuery(querySource1D2378FB2963489899022B61F44BE0AD,@"EXEC DocumentsDomain '" + ISpace["M_DocumentDetailsId"].Value + @"','" + ISpace["M_PackageProcessMapId"].Value + @"','" + ISpace["UpdatedOn"].Value + @"','" + ISpace["M_DocumentName"].Value + @"','" + ISpace["gv_UserId"].Value + @"','" + ISpace["M_UploadDcoument"].Value + @"','" + ISpace["MF_T1_TravelAdvanceID"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource1D2378FB2963489899022B61F44BE0AD =GetQueryExpressionDataSource(""1D2378FB-2963-4898-9902-2B61F44BE0AD"");Dictionary<short,object> result1D2378FB2963489899022B61F44BE0AD=iSpace.ExecuteQuery(querySource1D2378FB2963489899022B61F44BE0AD,@""EXEC DocumentsDomain '"" + ISpace[""M_DocumentDetailsId""].Value + @""','"" + ISpace[""M_PackageProcessMapId""].Value + @""','"" + ISpace[""UpdatedOn""].Value + @""','"" + ISpace[""M_DocumentName""].Value + @""','"" + ISpace[""gv_UserId""].Value + @""','"" + ISpace[""M_UploadDcoument""].Value + @""','"" + ISpace[""MF_T1_TravelAdvanceID""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result1D2378FB2963489899022B61F44BE0AD!=null) && (result1D2378FB2963489899022B61F44BE0AD.Count!=0))
{
}
else{

}
base.WriteDebugInfo(@"#MF_FundAmount[rows]");
iSpace.GetLoopExpressionData("MF_FundAmount",ref ISpace);

foreach(var gridChild in ISpace["MF_FundAmount"].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 


if(
ISpace["MG_FundTypeId"].Value==1)
{
base.WriteDebugInfo(@"
if(
ISpace[""MG_FundTypeId""].Value==1)");
base.WriteDebugInfo(@"EXEC ProjectApprovalCommittmentDetails '#MG_Amount','#MF_T1_TravelAdvanceID','#MG_ProjectDetailsId','#MG_BudgetHead','#gv_ProcessMapId'");

var querySource4213CFEEA88E4B67BEECB0AEF4337465 =GetQueryExpressionDataSource("4213CFEE-A88E-4B67-BEEC-B0AEF4337465");
Dictionary<short,object> result4213CFEEA88E4B67BEECB0AEF4337465=iSpace.ExecuteQuery(querySource4213CFEEA88E4B67BEECB0AEF4337465,@"EXEC ProjectApprovalCommittmentDetails '" + ISpace["MG_Amount"].Value + @"','" + ISpace["MF_T1_TravelAdvanceID"].Value + @"','" + ISpace["MG_ProjectDetailsId"].Value + @"','" + ISpace["MG_BudgetHead"].Value + @"','" + ISpace["gv_ProcessMapId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource4213CFEEA88E4B67BEECB0AEF4337465 =GetQueryExpressionDataSource(""4213CFEE-A88E-4B67-BEEC-B0AEF4337465"");Dictionary<short,object> result4213CFEEA88E4B67BEECB0AEF4337465=iSpace.ExecuteQuery(querySource4213CFEEA88E4B67BEECB0AEF4337465,@""EXEC ProjectApprovalCommittmentDetails '"" + ISpace[""MG_Amount""].Value + @""','"" + ISpace[""MF_T1_TravelAdvanceID""].Value + @""','"" + ISpace[""MG_ProjectDetailsId""].Value + @""','"" + ISpace[""MG_BudgetHead""].Value + @""','"" + ISpace[""gv_ProcessMapId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result4213CFEEA88E4B67BEECB0AEF4337465!=null) && (result4213CFEEA88E4B67BEECB0AEF4337465.Count!=0))
{
}
else{

}
}
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("MF_FundAmount","AD9C54EC-27A0-4C21-9923-063084E3B588",_objectFactory.GetGridRPP("MF_FundAmount"),_elementBase.GetGridLoopQuery("AD9C54EC-27A0-4C21-9923-063084E3B588","MF_FundAmount",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""MF_FundAmount"",ref ISpace);

foreach(var gridChild in ISpace[""MF_FundAmount""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
}
if(1==2)
{
base.WriteDebugInfo(@"if(1==2)");
base.WriteDebugInfo(@"#MF_FundAmount[Rows]");
iSpace.GetLoopExpressionData("MF_FundAmount",ref ISpace);

foreach(var gridChild in ISpace["MF_FundAmount"].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 

base.WriteDebugInfo(@"EXEC UpsertProjectBudgetDetails 5,'#MG_ProjectDetailsId','#MF_T1_TravelAdvanceID','#MG_Amount','#MG_BudgetHead','1','#MG_FundTypeid','#M_PackageProcessMapId','#UC_EmployeeBaicInfoId'");

var querySourceEA86EC989465469D97F236E0D8B7BEB7 =GetQueryExpressionDataSource("EA86EC98-9465-469D-97F2-36E0D8B7BEB7");
Dictionary<short,object> resultEA86EC989465469D97F236E0D8B7BEB7=iSpace.ExecuteQuery(querySourceEA86EC989465469D97F236E0D8B7BEB7,@"EXEC UpsertProjectBudgetDetails 5,'" + ISpace["MG_ProjectDetailsId"].Value + @"','" + ISpace["MF_T1_TravelAdvanceID"].Value + @"','" + ISpace["MG_Amount"].Value + @"','" + ISpace["MG_BudgetHead"].Value + @"','1','" + ISpace["MG_FundTypeid"].Value + @"','" + ISpace["M_PackageProcessMapId"].Value + @"','" + ISpace["UC_EmployeeBaicInfoId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceEA86EC989465469D97F236E0D8B7BEB7 =GetQueryExpressionDataSource(""EA86EC98-9465-469D-97F2-36E0D8B7BEB7"");Dictionary<short,object> resultEA86EC989465469D97F236E0D8B7BEB7=iSpace.ExecuteQuery(querySourceEA86EC989465469D97F236E0D8B7BEB7,@""EXEC UpsertProjectBudgetDetails 5,'"" + ISpace[""MG_ProjectDetailsId""].Value + @""','"" + ISpace[""MF_T1_TravelAdvanceID""].Value + @""','"" + ISpace[""MG_Amount""].Value + @""','"" + ISpace[""MG_BudgetHead""].Value + @""','1','"" + ISpace[""MG_FundTypeid""].Value + @""','"" + ISpace[""M_PackageProcessMapId""].Value + @""','"" + ISpace[""UC_EmployeeBaicInfoId""].Value + @""'"",false);");
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("MF_FundAmount","AD9C54EC-27A0-4C21-9923-063084E3B588",_objectFactory.GetGridRPP("MF_FundAmount"),_elementBase.GetGridLoopQuery("AD9C54EC-27A0-4C21-9923-063084E3B588","MF_FundAmount",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""MF_FundAmount"",ref ISpace);

foreach(var gridChild in ISpace[""MF_FundAmount""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
}
}
base.WriteDebugInfo(@"EXEC Repo198E5A8A61F54E7C92DD34146A7059EF '#CreatedOn','#MF_T1_BankDocument','#MF_T1_ReferenceNo','#MF_T1_AccountNo','#OverAll_Total','#UC_EmployeeBaicInfoId','#M_TravelPlace','#MF_T1_AdvanceAmount','#MF_T1_BankName','#MF_T1_TravelAdvanceID','#MF_T1_JourneyPurpose','#Travel_Type','#MF_T1_BeneficiaryName','#gv_UserId','#MF_TransactionNo','#MF_TravelStatus','#MF_TransactionDate','#M_IsAdvanceRequired'");

var querySource5BE98974AD594580A75130D0492B011E =GetQueryExpressionDataSource("5BE98974-AD59-4580-A751-30D0492B011E");
Dictionary<short,object> result5BE98974AD594580A75130D0492B011E=iSpace.ExecuteQuery(querySource5BE98974AD594580A75130D0492B011E,@"EXEC Repo198E5A8A61F54E7C92DD34146A7059EF '" + ISpace["CreatedOn"].Value + @"','" + ISpace["MF_T1_BankDocument"].Value + @"','" + ISpace["MF_T1_ReferenceNo"].Value + @"','" + ISpace["MF_T1_AccountNo"].Value + @"','" + ISpace["OverAll_Total"].Value + @"','" + ISpace["UC_EmployeeBaicInfoId"].Value + @"','" + ISpace["M_TravelPlace"].Value + @"','" + ISpace["MF_T1_AdvanceAmount"].Value + @"','" + ISpace["MF_T1_BankName"].Value + @"','" + ISpace["MF_T1_TravelAdvanceID"].Value + @"','" + ISpace["MF_T1_JourneyPurpose"].Value + @"','" + ISpace["Travel_Type"].Value + @"','" + ISpace["MF_T1_BeneficiaryName"].Value + @"','" + ISpace["gv_UserId"].Value + @"','" + ISpace["MF_TransactionNo"].Value + @"','" + ISpace["MF_TravelStatus"].Value + @"','" + ISpace["MF_TransactionDate"].Value + @"','" + ISpace["M_IsAdvanceRequired"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource5BE98974AD594580A75130D0492B011E =GetQueryExpressionDataSource(""5BE98974-AD59-4580-A751-30D0492B011E"");Dictionary<short,object> result5BE98974AD594580A75130D0492B011E=iSpace.ExecuteQuery(querySource5BE98974AD594580A75130D0492B011E,@""EXEC Repo198E5A8A61F54E7C92DD34146A7059EF '"" + ISpace[""CreatedOn""].Value + @""','"" + ISpace[""MF_T1_BankDocument""].Value + @""','"" + ISpace[""MF_T1_ReferenceNo""].Value + @""','"" + ISpace[""MF_T1_AccountNo""].Value + @""','"" + ISpace[""OverAll_Total""].Value + @""','"" + ISpace[""UC_EmployeeBaicInfoId""].Value + @""','"" + ISpace[""M_TravelPlace""].Value + @""','"" + ISpace[""MF_T1_AdvanceAmount""].Value + @""','"" + ISpace[""MF_T1_BankName""].Value + @""','"" + ISpace[""MF_T1_TravelAdvanceID""].Value + @""','"" + ISpace[""MF_T1_JourneyPurpose""].Value + @""','"" + ISpace[""Travel_Type""].Value + @""','"" + ISpace[""MF_T1_BeneficiaryName""].Value + @""','"" + ISpace[""gv_UserId""].Value + @""','"" + ISpace[""MF_TransactionNo""].Value + @""','"" + ISpace[""MF_TravelStatus""].Value + @""','"" + ISpace[""MF_TransactionDate""].Value + @""','"" + ISpace[""M_IsAdvanceRequired""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result5BE98974AD594580A75130D0492B011E!=null) && (result5BE98974AD594580A75130D0492B011E.Count!=0))
{
}
else{

}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"#MF_FundAmount[Rows]");
iSpace.GetLoopExpressionData("MF_FundAmount",ref ISpace);

foreach(var gridChild in ISpace["MF_FundAmount"].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 

base.WriteDebugInfo(@"EXEC UpsertProjectBudgetDetails 5,'#MG_ProjectDetailsId','#MF_T1_TravelAdvanceID','#MG_Amount','#MG_BudgetHead','#M_IsCommitment','#MG_FundTypeid','#M_PackageProcessMapId','#UC_EmployeeBaicInfoId'");

var querySource13D4A6E9DC9143DCB6A1C740A96DAFA6 =GetQueryExpressionDataSource("13D4A6E9-DC91-43DC-B6A1-C740A96DAFA6");
Dictionary<short,object> result13D4A6E9DC9143DCB6A1C740A96DAFA6=iSpace.ExecuteQuery(querySource13D4A6E9DC9143DCB6A1C740A96DAFA6,@"EXEC UpsertProjectBudgetDetails 5,'" + ISpace["MG_ProjectDetailsId"].Value + @"','" + ISpace["MF_T1_TravelAdvanceID"].Value + @"','" + ISpace["MG_Amount"].Value + @"','" + ISpace["MG_BudgetHead"].Value + @"','" + ISpace["M_IsCommitment"].Value + @"','" + ISpace["MG_FundTypeid"].Value + @"','" + ISpace["M_PackageProcessMapId"].Value + @"','" + ISpace["UC_EmployeeBaicInfoId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource13D4A6E9DC9143DCB6A1C740A96DAFA6 =GetQueryExpressionDataSource(""13D4A6E9-DC91-43DC-B6A1-C740A96DAFA6"");Dictionary<short,object> result13D4A6E9DC9143DCB6A1C740A96DAFA6=iSpace.ExecuteQuery(querySource13D4A6E9DC9143DCB6A1C740A96DAFA6,@""EXEC UpsertProjectBudgetDetails 5,'"" + ISpace[""MG_ProjectDetailsId""].Value + @""','"" + ISpace[""MF_T1_TravelAdvanceID""].Value + @""','"" + ISpace[""MG_Amount""].Value + @""','"" + ISpace[""MG_BudgetHead""].Value + @""','"" + ISpace[""M_IsCommitment""].Value + @""','"" + ISpace[""MG_FundTypeid""].Value + @""','"" + ISpace[""M_PackageProcessMapId""].Value + @""','"" + ISpace[""UC_EmployeeBaicInfoId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result13D4A6E9DC9143DCB6A1C740A96DAFA6!=null) && (result13D4A6E9DC9143DCB6A1C740A96DAFA6.Count!=0))
{
if(result13D4A6E9DC9143DCB6A1C740A96DAFA6.ContainsKey(0))
ISpace["A"].Value = result13D4A6E9DC9143DCB6A1C740A96DAFA6[0];
}
else{
ISpace["A"].Value = null;
}
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("MF_FundAmount","AD9C54EC-27A0-4C21-9923-063084E3B588",_objectFactory.GetGridRPP("MF_FundAmount"),_elementBase.GetGridLoopQuery("AD9C54EC-27A0-4C21-9923-063084E3B588","MF_FundAmount",ISpace), ref ISpace);
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

var querySource797A60C10BB64A40915695B92AAFC889 =GetQueryExpressionDataSource("797A60C1-0BB6-4A40-9156-95B92AAFC889");
Dictionary<short,object> result797A60C10BB64A40915695B92AAFC889=iSpace.ExecuteQuery(querySource797A60C10BB64A40915695B92AAFC889,@"SELECT " + ISpace["OverAll_Total"].Value + @"*0.9",false);

base.WriteDebugInfo(@"var querySource797A60C10BB64A40915695B92AAFC889 =GetQueryExpressionDataSource(""797A60C1-0BB6-4A40-9156-95B92AAFC889"");Dictionary<short,object> result797A60C10BB64A40915695B92AAFC889=iSpace.ExecuteQuery(querySource797A60C10BB64A40915695B92AAFC889,@""SELECT "" + ISpace[""OverAll_Total""].Value + @""*0.9"",false);");
base.WriteDebugInfo(@"");

if((result797A60C10BB64A40915695B92AAFC889!=null) && (result797A60C10BB64A40915695B92AAFC889.Count!=0))
{
if(result797A60C10BB64A40915695B92AAFC889.ContainsKey(0))
ISpace["T_AdvanceDrawn"].Value = result797A60C10BB64A40915695B92AAFC889[0];
}
else{
ISpace["T_AdvanceDrawn"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["M_Status"].Value="Pending";
base.WriteDebugInfo(@"ISpace[""M_Status""].Value=""Pending"";");
}
ISpace["Message"].Value=@"Submitted Successfully";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Submitted Successfully"";");
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
object MG_T3_Amount=iSpace.Sum("[A694A330-AAD5-4856-853C-D6AD1573AF0B]","MG_T3_Amount","",ISpace["gv_instanceid"].Value);
ISpace["T_ExpenditureTotal"].Value=Convert.ChangeType(MG_T3_Amount, MG_T3_Amount.GetType());;
base.WriteDebugInfo(@"object MG_T3_Amount=iSpace.Sum(""[A694A330-AAD5-4856-853C-D6AD1573AF0B]"",""MG_T3_Amount"","""",ISpace[""gv_instanceid""].Value);
ISpace[""T_ExpenditureTotal""].Value=Convert.ChangeType(MG_T3_Amount, MG_T3_Amount.GetType());;");
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
ISpace["MF_ProjectNo"].Visible="true";ISpace["MF_ProjectNo"].Man=true;ISpace["MF_BudgetHead"].Visible="true";ISpace["MF_BudgetHead"].Man=true;ISpace["MF_Amount"].Visible="true";ISpace["MF_Amount"].Man=true;
base.WriteDebugInfo(@"ISpace[""MF_ProjectNo""].Visible=""true"";ISpace[""MF_ProjectNo""].Man=true;ISpace[""MF_BudgetHead""].Visible=""true"";ISpace[""MF_BudgetHead""].Man=true;ISpace[""MF_Amount""].Visible=""true"";ISpace[""MF_Amount""].Man=true;");
ISpace["M_OpenModal"].Visible="true";
base.WriteDebugInfo(@"ISpace[""M_OpenModal""].Visible=""true"";");
ISpace["MF_BudgetHead"].rElemData=iSpace.Reload(ISpace["MF_BudgetHead"].Value,@"exec SP_GetDistrubitionDetails 5,'@" + ISpace["gv_ProcessMapId"].Value + @"'," + ISpace["MF_FundType"].Value + @",'','','','','" + ISpace["MF_ProjectNo"].Value + @"'","9ADED37B-CD11-426B-AF16-DEAC75685EF5");
base.WriteDebugInfo(@"ISpace[""MF_BudgetHead""].rElemData=iSpace.Reload(ISpace[""MF_BudgetHead""].Value,@""exec SP_GetDistrubitionDetails 5,'@"" + ISpace[""gv_ProcessMapId""].Value + @""',"" + ISpace[""MF_FundType""].Value + @"",'','','','','"" + ISpace[""MF_ProjectNo""].Value + @""'"",""9ADED37B-CD11-426B-AF16-DEAC75685EF5"");");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_ProjectNo"].Visible="false";ISpace["MF_ProjectNo"].Man=false;ISpace["MF_BudgetHead"].Visible="false";ISpace["MF_BudgetHead"].Man=false;ISpace["MF_Amount"].Visible="true";ISpace["MF_Amount"].Man=true;
base.WriteDebugInfo(@"ISpace[""MF_ProjectNo""].Visible=""false"";ISpace[""MF_ProjectNo""].Man=false;ISpace[""MF_BudgetHead""].Visible=""false"";ISpace[""MF_BudgetHead""].Man=false;ISpace[""MF_Amount""].Visible=""true"";ISpace[""MF_Amount""].Man=true;");
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

var querySourceDFBF6D4681E041F694F45547F670F5AF =GetQueryExpressionDataSource("DFBF6D46-81E0-41F6-94F4-5547F670F5AF");
Dictionary<short,object> resultDFBF6D4681E041F694F45547F670F5AF=iSpace.ExecuteQuery(querySourceDFBF6D4681E041F694F45547F670F5AF,@"EXEC GetAvailableBudget '" + ISpace["MF_T1_BudgetHead"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceDFBF6D4681E041F694F45547F670F5AF =GetQueryExpressionDataSource(""DFBF6D46-81E0-41F6-94F4-5547F670F5AF"");Dictionary<short,object> resultDFBF6D4681E041F694F45547F670F5AF=iSpace.ExecuteQuery(querySourceDFBF6D4681E041F694F45547F670F5AF,@""EXEC GetAvailableBudget '"" + ISpace[""MF_T1_BudgetHead""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultDFBF6D4681E041F694F45547F670F5AF!=null) && (resultDFBF6D4681E041F694F45547F670F5AF.Count!=0))
{
if(resultDFBF6D4681E041F694F45547F670F5AF.ContainsKey(0))
ISpace["MF_T1_AvailableBudget"].Value = resultDFBF6D4681E041F694F45547F670F5AF[0];
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
private void SubscribeElementEvents_save_travelexpense (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Save_TravelExpense-OnClick");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MFG_T2_ModeofJourney"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""MFG_T2_ModeofJourney""].Value=="""")");
ISpace["Message"].Value=@"Please Enter the Mode of Journey";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please Enter the Mode of Journey"";");
return;
base.WriteDebugInfo(@"return;");
}
if(Trim(ISpace["MFG_T2_Departure"].Value)=="")
{
base.WriteDebugInfo(@"if(Trim(ISpace[""MFG_T2_Departure""].Value)=="""")");
ISpace["Message"].Value=@"Please Enter the Departure";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please Enter the Departure"";");
return;
base.WriteDebugInfo(@"return;");
}
if((ISpace["MFG_T2_DepartureDate"].Value == null))
{
base.WriteDebugInfo(@"if((ISpace[""MFG_T2_DepartureDate""].Value == null))");
ISpace["Message"].Value=@"Please Enter the Departure Date";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please Enter the Departure Date"";");
return;
base.WriteDebugInfo(@"return;");
}
if(Trim(ISpace["MFG_T2_Arrival"].Value)=="")
{
base.WriteDebugInfo(@"if(Trim(ISpace[""MFG_T2_Arrival""].Value)=="""")");
ISpace["Message"].Value=@"Please Enter the Arrival";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please Enter the Arrival"";");
return;
base.WriteDebugInfo(@"return;");
}
if((ISpace["MFG_T2_ArrivalDate"].Value == null))
{
base.WriteDebugInfo(@"if((ISpace[""MFG_T2_ArrivalDate""].Value == null))");
ISpace["Message"].Value=@"Please Enter the Arrival Date";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please Enter the Arrival Date"";");
return;
base.WriteDebugInfo(@"return;");
}
if(ISpace["MFG_T2_ArrivalDate"].Value<ISpace["MFG_T2_DepartureDate"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MFG_T2_ArrivalDate""].Value<ISpace[""MFG_T2_DepartureDate""].Value)");
ISpace["Message"].Value=@"Arrival Date should be greater than Departure Date";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Arrival Date should be greater than Departure Date"";");
ISpace["MFG_T2_ArrivalDate"].Value=null;
base.WriteDebugInfo(@"ISpace[""MFG_T2_ArrivalDate""].Value=null;");
return;
base.WriteDebugInfo(@"return;");
}
if(ISpace["MFG_T2_Amount"].Value==0)
{
base.WriteDebugInfo(@"if(ISpace[""MFG_T2_Amount""].Value==0)");
ISpace["Message"].Value=@"Please Enter the Amount";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please Enter the Amount"";");
return;
base.WriteDebugInfo(@"return;");
}
}
if(ISpace["growid"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""growid""].Value=="""")");

var querySourceD659A8A182614852878E8F0B73B79721 =GetQueryExpressionDataSource("D659A8A1-8261-4852-878E-8F0B73B79721");

DataTable resultD659A8A182614852878E8F0B73B79721=iSpace.SetGridDataSource(querySourceD659A8A182614852878E8F0B73B79721, _objectFactory.GetGridRPP("TravelExpense"),@"EXEC AddFormGridData374fb8a88dd94cf1bf73f40ae18fcad7 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["MFG_T2_TADetailsID"].Value + @"','" + ISpace["MFG_T2_TravelAdvanceID"].Value + @"','" + ISpace["MFG_T2_Departure"].Value + @"','" + ISpace["MFG_T2_DepartureDate"].Value + @"','" + ISpace["MFG_T2_DepartureTime"].Value + @"','" + ISpace["MFG_T2_Arrival"].Value + @"','" + ISpace["MFG_T2_ArrivalDate"].Value + @"','" + ISpace["MFG_T2_ArrivalTime"].Value + @"','" + ISpace["MFG_T2_ModeofJourney"].Value + @"','" + ISpace["MFG_T2_JourneyClass"].Value + @"'," + ISpace["MFG_T2_Road"].Value + @",'" + ISpace["MFG_T2_PNRNo"].Value + @"'," + ISpace["MFG_T2_Amount"].Value + @",'" + ISpace["growid"].Value + @"'");

iSpace.InsertGridBindDetails("TravelExpense","11",querySourceD659A8A182614852878E8F0B73B79721,"EXEC AddFormGridData374fb8a88dd94cf1bf73f40ae18fcad7 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["MFG_T2_TADetailsID"].Value + @"','" + ISpace["MFG_T2_TravelAdvanceID"].Value + @"','" + ISpace["MFG_T2_Departure"].Value + @"','" + ISpace["MFG_T2_DepartureDate"].Value + @"','" + ISpace["MFG_T2_DepartureTime"].Value + @"','" + ISpace["MFG_T2_Arrival"].Value + @"','" + ISpace["MFG_T2_ArrivalDate"].Value + @"','" + ISpace["MFG_T2_ArrivalTime"].Value + @"','" + ISpace["MFG_T2_ModeofJourney"].Value + @"','" + ISpace["MFG_T2_JourneyClass"].Value + @"'," + ISpace["MFG_T2_Road"].Value + @",'" + ISpace["MFG_T2_PNRNo"].Value + @"'," + ISpace["MFG_T2_Amount"].Value + @",'" + ISpace["growid"].Value + @"'",_objectFactory.GetGridRPP("TravelExpense"));

base.WriteDebugInfo(@"var querySourceD659A8A182614852878E8F0B73B79721 =GetQueryExpressionDataSource(""D659A8A1-8261-4852-878E-8F0B73B79721"");DataTable resultD659A8A182614852878E8F0B73B79721=iSpace.SetGridDataSource(querySourceD659A8A182614852878E8F0B73B79721, _objectFactory.GetGridRPP(""TravelExpense""),@""EXEC AddFormGridData374fb8a88dd94cf1bf73f40ae18fcad7 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""MFG_T2_TADetailsID""].Value + @""','"" + ISpace[""MFG_T2_TravelAdvanceID""].Value + @""','"" + ISpace[""MFG_T2_Departure""].Value + @""','"" + ISpace[""MFG_T2_DepartureDate""].Value + @""','"" + ISpace[""MFG_T2_DepartureTime""].Value + @""','"" + ISpace[""MFG_T2_Arrival""].Value + @""','"" + ISpace[""MFG_T2_ArrivalDate""].Value + @""','"" + ISpace[""MFG_T2_ArrivalTime""].Value + @""','"" + ISpace[""MFG_T2_ModeofJourney""].Value + @""','"" + ISpace[""MFG_T2_JourneyClass""].Value + @""',"" + ISpace[""MFG_T2_Road""].Value + @"",'"" + ISpace[""MFG_T2_PNRNo""].Value + @""',"" + ISpace[""MFG_T2_Amount""].Value + @"",'"" + ISpace[""growid""].Value + @""'"");iSpace.InsertGridBindDetails(""TravelExpense"",""11"",querySourceD659A8A182614852878E8F0B73B79721,""EXEC AddFormGridData374fb8a88dd94cf1bf73f40ae18fcad7 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""MFG_T2_TADetailsID""].Value + @""','"" + ISpace[""MFG_T2_TravelAdvanceID""].Value + @""','"" + ISpace[""MFG_T2_Departure""].Value + @""','"" + ISpace[""MFG_T2_DepartureDate""].Value + @""','"" + ISpace[""MFG_T2_DepartureTime""].Value + @""','"" + ISpace[""MFG_T2_Arrival""].Value + @""','"" + ISpace[""MFG_T2_ArrivalDate""].Value + @""','"" + ISpace[""MFG_T2_ArrivalTime""].Value + @""','"" + ISpace[""MFG_T2_ModeofJourney""].Value + @""','"" + ISpace[""MFG_T2_JourneyClass""].Value + @""',"" + ISpace[""MFG_T2_Road""].Value + @"",'"" + ISpace[""MFG_T2_PNRNo""].Value + @""',"" + ISpace[""MFG_T2_Amount""].Value + @"",'"" + ISpace[""growid""].Value + @""'"",_objectFactory.GetGridRPP(""TravelExpense""));");
base.WriteDebugInfo(@"EXEC AddFormGridData374fb8a88dd94cf1bf73f40ae18fcad7 '@@gv_InstanceId','@@gv_ProcessMapId','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','@@gv_ActivityMapId','#MFG_T2_TADetailsID','#MFG_T2_TravelAdvanceID','#MFG_T2_Departure','#MFG_T2_DepartureDate','#MFG_T2_DepartureTime','#MFG_T2_Arrival','#MFG_T2_ArrivalDate','#MFG_T2_ArrivalTime','#MFG_T2_ModeofJourney','#MFG_T2_JourneyClass',#MFG_T2_Road,'#MFG_T2_PNRNo',#MFG_T3_Amount,'#growid'");


List<Triplet<string, short, short?>> result8F99128D9EF74BCF8A425714C2D6D166=acdataIspaceAAB051287AAE4A998278465822CE1E85.GetQueryExpressionBindings("8F99128D-9EF7-4BCF-8A42-5714C2D6D166");
iSpace.SetGridData(resultD659A8A182614852878E8F0B73B79721,result8F99128D9EF74BCF8A425714C2D6D166,"TravelExpense",ref ISpace);
iSpace.UpdateGridBindDetails("TravelExpense",result8F99128D9EF74BCF8A425714C2D6D166);
}
else
{
base.WriteDebugInfo(@"else");

var querySourceAFBC2448576140CFA8EB1C60C3DC33D1 =GetQueryExpressionDataSource("AFBC2448-5761-40CF-A8EB-1C60C3DC33D1");

DataTable resultAFBC2448576140CFA8EB1C60C3DC33D1=iSpace.SetGridDataSource(querySourceAFBC2448576140CFA8EB1C60C3DC33D1, _objectFactory.GetGridRPP("TravelExpense"),@"EXEC UpdateFormGridData374fb8a88dd94cf1bf73f40ae18fcad7 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["MFG_T2_TADetailsID"].Value + @"','" + ISpace["MFG_T2_TravelAdvanceID"].Value + @"','" + ISpace["MFG_T2_Departure"].Value + @"','" + ISpace["MFG_T2_DepartureDate"].Value + @"','" + ISpace["MFG_T2_DepartureTime"].Value + @"','" + ISpace["MFG_T2_Arrival"].Value + @"','" + ISpace["MFG_T2_ArrivalDate"].Value + @"','" + ISpace["MFG_T2_ArrivalTime"].Value + @"','" + ISpace["MFG_T2_ModeofJourney"].Value + @"','" + ISpace["MFG_T2_JourneyClass"].Value + @"'," + ISpace["MFG_T2_Road"].Value + @",'" + ISpace["MFG_T2_PNRNo"].Value + @"'," + ISpace["MFG_T2_Amount"].Value + @",'" + ISpace["growid"].Value + @"'");

iSpace.InsertGridBindDetails("TravelExpense","11",querySourceAFBC2448576140CFA8EB1C60C3DC33D1,"EXEC UpdateFormGridData374fb8a88dd94cf1bf73f40ae18fcad7 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["MFG_T2_TADetailsID"].Value + @"','" + ISpace["MFG_T2_TravelAdvanceID"].Value + @"','" + ISpace["MFG_T2_Departure"].Value + @"','" + ISpace["MFG_T2_DepartureDate"].Value + @"','" + ISpace["MFG_T2_DepartureTime"].Value + @"','" + ISpace["MFG_T2_Arrival"].Value + @"','" + ISpace["MFG_T2_ArrivalDate"].Value + @"','" + ISpace["MFG_T2_ArrivalTime"].Value + @"','" + ISpace["MFG_T2_ModeofJourney"].Value + @"','" + ISpace["MFG_T2_JourneyClass"].Value + @"'," + ISpace["MFG_T2_Road"].Value + @",'" + ISpace["MFG_T2_PNRNo"].Value + @"'," + ISpace["MFG_T2_Amount"].Value + @",'" + ISpace["growid"].Value + @"'",_objectFactory.GetGridRPP("TravelExpense"));

base.WriteDebugInfo(@"var querySourceAFBC2448576140CFA8EB1C60C3DC33D1 =GetQueryExpressionDataSource(""AFBC2448-5761-40CF-A8EB-1C60C3DC33D1"");DataTable resultAFBC2448576140CFA8EB1C60C3DC33D1=iSpace.SetGridDataSource(querySourceAFBC2448576140CFA8EB1C60C3DC33D1, _objectFactory.GetGridRPP(""TravelExpense""),@""EXEC UpdateFormGridData374fb8a88dd94cf1bf73f40ae18fcad7 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""MFG_T2_TADetailsID""].Value + @""','"" + ISpace[""MFG_T2_TravelAdvanceID""].Value + @""','"" + ISpace[""MFG_T2_Departure""].Value + @""','"" + ISpace[""MFG_T2_DepartureDate""].Value + @""','"" + ISpace[""MFG_T2_DepartureTime""].Value + @""','"" + ISpace[""MFG_T2_Arrival""].Value + @""','"" + ISpace[""MFG_T2_ArrivalDate""].Value + @""','"" + ISpace[""MFG_T2_ArrivalTime""].Value + @""','"" + ISpace[""MFG_T2_ModeofJourney""].Value + @""','"" + ISpace[""MFG_T2_JourneyClass""].Value + @""',"" + ISpace[""MFG_T2_Road""].Value + @"",'"" + ISpace[""MFG_T2_PNRNo""].Value + @""',"" + ISpace[""MFG_T2_Amount""].Value + @"",'"" + ISpace[""growid""].Value + @""'"");iSpace.InsertGridBindDetails(""TravelExpense"",""11"",querySourceAFBC2448576140CFA8EB1C60C3DC33D1,""EXEC UpdateFormGridData374fb8a88dd94cf1bf73f40ae18fcad7 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""MFG_T2_TADetailsID""].Value + @""','"" + ISpace[""MFG_T2_TravelAdvanceID""].Value + @""','"" + ISpace[""MFG_T2_Departure""].Value + @""','"" + ISpace[""MFG_T2_DepartureDate""].Value + @""','"" + ISpace[""MFG_T2_DepartureTime""].Value + @""','"" + ISpace[""MFG_T2_Arrival""].Value + @""','"" + ISpace[""MFG_T2_ArrivalDate""].Value + @""','"" + ISpace[""MFG_T2_ArrivalTime""].Value + @""','"" + ISpace[""MFG_T2_ModeofJourney""].Value + @""','"" + ISpace[""MFG_T2_JourneyClass""].Value + @""',"" + ISpace[""MFG_T2_Road""].Value + @"",'"" + ISpace[""MFG_T2_PNRNo""].Value + @""',"" + ISpace[""MFG_T2_Amount""].Value + @"",'"" + ISpace[""growid""].Value + @""'"",_objectFactory.GetGridRPP(""TravelExpense""));");
base.WriteDebugInfo(@"EXEC UpdateFormGridData374fb8a88dd94cf1bf73f40ae18fcad7 '@@gv_InstanceId','@@gv_ProcessMapId','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','@@gv_ActivityMapId','#MFG_T2_TADetailsID','#MFG_T2_TravelAdvanceID','#MFG_T2_Departure','#MFG_T2_DepartureDate','#MFG_T2_DepartureTime','#MFG_T2_Arrival','#MFG_T2_ArrivalDate','#MFG_T2_ArrivalTime','#MFG_T2_ModeofJourney','#MFG_T2_JourneyClass',#MFG_T2_Road,'#MFG_T2_PNRNo',#MFG_T3_Amount,'#growid'");


List<Triplet<string, short, short?>> result49C758C3CB9E452A80535E2651156E3D=acdataIspaceAAB051287AAE4A998278465822CE1E85.GetQueryExpressionBindings("49C758C3-CB9E-452A-8053-5E2651156E3D");
iSpace.SetGridData(resultAFBC2448576140CFA8EB1C60C3DC33D1,result49C758C3CB9E452A80535E2651156E3D,"TravelExpense",ref ISpace);
iSpace.UpdateGridBindDetails("TravelExpense",result49C758C3CB9E452A80535E2651156E3D);
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
object MG_T2_Amount=iSpace.Sum("[FA412DDD-7AD9-49AF-B8D7-2B7E1620D8FC]","MG_T2_Amount","",ISpace["gv_instanceid"].Value);
ISpace["T_TravelAdvanceTotal"].Value=Convert.ChangeType(MG_T2_Amount, MG_T2_Amount.GetType());;
base.WriteDebugInfo(@"object MG_T2_Amount=iSpace.Sum(""[FA412DDD-7AD9-49AF-B8D7-2B7E1620D8FC]"",""MG_T2_Amount"","""",ISpace[""gv_instanceid""].Value);
ISpace[""T_TravelAdvanceTotal""].Value=Convert.ChangeType(MG_T2_Amount, MG_T2_Amount.GetType());;");
ISpace["OverAll_Total"].Value=ISpace["T_TravelAdvanceTotal"].Value+ISpace["T_ExpenditureTotal"].Value;
base.WriteDebugInfo(@"ISpace[""OverAll_Total""].Value=ISpace[""T_TravelAdvanceTotal""].Value+ISpace[""T_ExpenditureTotal""].Value;");

if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"SELECT #OverAll_Total*0.9");

var querySource797A60C10BB64A40915695B92AAFC889 =GetQueryExpressionDataSource("797A60C1-0BB6-4A40-9156-95B92AAFC889");
Dictionary<short,object> result797A60C10BB64A40915695B92AAFC889=iSpace.ExecuteQuery(querySource797A60C10BB64A40915695B92AAFC889,@"SELECT " + ISpace["OverAll_Total"].Value + @"*0.9",false);

base.WriteDebugInfo(@"var querySource797A60C10BB64A40915695B92AAFC889 =GetQueryExpressionDataSource(""797A60C1-0BB6-4A40-9156-95B92AAFC889"");Dictionary<short,object> result797A60C10BB64A40915695B92AAFC889=iSpace.ExecuteQuery(querySource797A60C10BB64A40915695B92AAFC889,@""SELECT "" + ISpace[""OverAll_Total""].Value + @""*0.9"",false);");
base.WriteDebugInfo(@"");

if((result797A60C10BB64A40915695B92AAFC889!=null) && (result797A60C10BB64A40915695B92AAFC889.Count!=0))
{
if(result797A60C10BB64A40915695B92AAFC889.ContainsKey(0))
ISpace["T_AdvanceDrawn"].Value = result797A60C10BB64A40915695B92AAFC889[0];
}
else{
ISpace["T_AdvanceDrawn"].Value = null;
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
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_FundType"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""MF_FundType""].Value=="""")");
ISpace["Message"].Value=@"Please enter Fund Type";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please enter Fund Type"";");
return;
base.WriteDebugInfo(@"return;");
}
if(ISpace["MF_FundType"].Value=="1")
{
base.WriteDebugInfo(@"if(ISpace[""MF_FundType""].Value==""1"")");
if(ISpace["MF_ProjectNo"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""MF_ProjectNo""].Value=="""")");
ISpace["Message"].Value=@"Please enter Project No";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please enter Project No"";");
return;
base.WriteDebugInfo(@"return;");
}
if(ISpace["MF_BudgetHead"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""MF_BudgetHead""].Value=="""")");
ISpace["Message"].Value=@"Please enter Budget Head";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please enter Budget Head"";");
return;
base.WriteDebugInfo(@"return;");
}
if(ISpace["MF_Amount"].Value==0)
{
base.WriteDebugInfo(@"if(ISpace[""MF_Amount""].Value==0)");
ISpace["Message"].Value=@"Please enter Amount";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please enter Amount"";");
return;
base.WriteDebugInfo(@"return;");
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
return;
base.WriteDebugInfo(@"return;");
}
}
if(ISpace["MF_FundType"].Value=="1")
{
base.WriteDebugInfo(@"if(ISpace[""MF_FundType""].Value==""1"")");
base.WriteDebugInfo(@"exec ValidatePaymentFundAvailability '#MF_FundType','#MF_ProjectNo','#MF_BudgetHead','#UC_EmployeeBaicInfoId','#MF_Amount'");

var querySource030B3094527B4F84B2E392458D34E946 =GetQueryExpressionDataSource("030B3094-527B-4F84-B2E3-92458D34E946");
Dictionary<short,object> result030B3094527B4F84B2E392458D34E946=iSpace.ExecuteQuery(querySource030B3094527B4F84B2E392458D34E946,@"exec ValidatePaymentFundAvailability '" + ISpace["MF_FundType"].Value + @"','" + ISpace["MF_ProjectNo"].Value + @"','" + ISpace["MF_BudgetHead"].Value + @"','" + ISpace["UC_EmployeeBaicInfoId"].Value + @"','" + ISpace["MF_Amount"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource030B3094527B4F84B2E392458D34E946 =GetQueryExpressionDataSource(""030B3094-527B-4F84-B2E3-92458D34E946"");Dictionary<short,object> result030B3094527B4F84B2E392458D34E946=iSpace.ExecuteQuery(querySource030B3094527B4F84B2E392458D34E946,@""exec ValidatePaymentFundAvailability '"" + ISpace[""MF_FundType""].Value + @""','"" + ISpace[""MF_ProjectNo""].Value + @""','"" + ISpace[""MF_BudgetHead""].Value + @""','"" + ISpace[""UC_EmployeeBaicInfoId""].Value + @""','"" + ISpace[""MF_Amount""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result030B3094527B4F84B2E392458D34E946!=null) && (result030B3094527B4F84B2E392458D34E946.Count!=0))
{
if(result030B3094527B4F84B2E392458D34E946.ContainsKey(0))
ISpace["M_BudgetErr"].Value = result030B3094527B4F84B2E392458D34E946[0];
if(result030B3094527B4F84B2E392458D34E946.ContainsKey(1))
ISpace["M_BudgetErrMsg"].Value = result030B3094527B4F84B2E392458D34E946[1];
}
else{
ISpace["M_BudgetErr"].Value = null;ISpace["M_BudgetErrMsg"].Value = null;
}
if(ISpace["M_BudgetErr"].Value==0)
{
base.WriteDebugInfo(@"if(ISpace[""M_BudgetErr""].Value==0)");
ISpace["Message"].Value=String.Format(@"{0}",ISpace["M_BudgetErrMsg"].Value);
base.WriteDebugInfo(@"ISpace[""Message""].Value=String.Format(@""{0}"",ISpace[""M_BudgetErrMsg""].Value);");
return;
base.WriteDebugInfo(@"return;");
}
}
if(ISpace["MF_FundDetailsId"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""MF_FundDetailsId""].Value=="""")");
ISpace["MF_FundDetailsId"].Value=Guid.NewGuid().ToString();
base.WriteDebugInfo(@"ISpace[""MF_FundDetailsId""].Value=Guid.NewGuid().ToString();");
}
}
ISpace["Message"].Value=@"Saved Successfully";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Saved Successfully"";");

var querySource0C732937A40A4ABBBB7DD89BDA0D481E =GetQueryExpressionDataSource("0C732937-A40A-4ABB-BB7D-D89BDA0D481E");

DataTable result0C732937A40A4ABBBB7DD89BDA0D481E=iSpace.SetGridDataSource(querySource0C732937A40A4ABBBB7DD89BDA0D481E, _objectFactory.GetGridRPP("MF_FundAmount"),@"exec SP_GetTravelAdvanceFundDetails 1,'" + ISpace["MF_T1_TravelAdvanceID"].Value + @"','','" + ISpace["M_TravelInstanceId"].Value + @"'");

iSpace.InsertGridBindDetails("MF_FundAmount","11",querySource0C732937A40A4ABBBB7DD89BDA0D481E,"exec SP_GetTravelAdvanceFundDetails 1,'" + ISpace["MF_T1_TravelAdvanceID"].Value + @"','','" + ISpace["M_TravelInstanceId"].Value + @"'",_objectFactory.GetGridRPP("MF_FundAmount"));

base.WriteDebugInfo(@"var querySource0C732937A40A4ABBBB7DD89BDA0D481E =GetQueryExpressionDataSource(""0C732937-A40A-4ABB-BB7D-D89BDA0D481E"");DataTable result0C732937A40A4ABBBB7DD89BDA0D481E=iSpace.SetGridDataSource(querySource0C732937A40A4ABBBB7DD89BDA0D481E, _objectFactory.GetGridRPP(""MF_FundAmount""),@""exec SP_GetTravelAdvanceFundDetails 1,'"" + ISpace[""MF_T1_TravelAdvanceID""].Value + @""','','"" + ISpace[""M_TravelInstanceId""].Value + @""'"");iSpace.InsertGridBindDetails(""MF_FundAmount"",""11"",querySource0C732937A40A4ABBBB7DD89BDA0D481E,""exec SP_GetTravelAdvanceFundDetails 1,'"" + ISpace[""MF_T1_TravelAdvanceID""].Value + @""','','"" + ISpace[""M_TravelInstanceId""].Value + @""'"",_objectFactory.GetGridRPP(""MF_FundAmount""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result1678D80AE83E4BA4B40F952B0A39779B=acdataIspaceAAB051287AAE4A998278465822CE1E85.GetQueryExpressionBindings("1678D80A-E83E-4BA4-B40F-952B0A39779B");
iSpace.SetGridData(result0C732937A40A4ABBBB7DD89BDA0D481E,result1678D80AE83E4BA4B40F952B0A39779B,"MF_FundAmount",ref ISpace);
iSpace.UpdateGridBindDetails("MF_FundAmount",result1678D80AE83E4BA4B40F952B0A39779B);
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["MF_FundType"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_FundType""].Value=null;");
ISpace["MF_ProjectNo"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_ProjectNo""].Value=null;");
ISpace["M_BudgetErr"].Value=null;
base.WriteDebugInfo(@"ISpace[""M_BudgetErr""].Value=null;");
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
private void SubscribeElementEvents_edit_travelexpense (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Edit_TravelExpense-OnClick");
ISpace["growid"].Value=ISpace["TravelExpense_RowId"].Value;
base.WriteDebugInfo(@"ISpace[""growid""].Value=ISpace[""TravelExpense_RowId""].Value;");
base.WriteDebugInfo(@"EXEC LoadFormGridData374fb8a88dd94cf1bf73f40ae18fcad7 '@@gv_InstanceId','@@gv_ProcessMapId','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','@@gv_ActivityMapId','#growid'");

var querySource2ACCBC572E9C4A0FBD46FAB4E50951D4 =GetQueryExpressionDataSource("2ACCBC57-2E9C-4A0F-BD46-FAB4E50951D4");
Dictionary<short,object> result2ACCBC572E9C4A0FBD46FAB4E50951D4=iSpace.ExecuteQuery(querySource2ACCBC572E9C4A0FBD46FAB4E50951D4,@"EXEC LoadFormGridData374fb8a88dd94cf1bf73f40ae18fcad7 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["growid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource2ACCBC572E9C4A0FBD46FAB4E50951D4 =GetQueryExpressionDataSource(""2ACCBC57-2E9C-4A0F-BD46-FAB4E50951D4"");Dictionary<short,object> result2ACCBC572E9C4A0FBD46FAB4E50951D4=iSpace.ExecuteQuery(querySource2ACCBC572E9C4A0FBD46FAB4E50951D4,@""EXEC LoadFormGridData374fb8a88dd94cf1bf73f40ae18fcad7 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""growid""].Value + @""'"",false);");
base.WriteDebugInfo(@"EXEC LoadFormGridData374fb8a88dd94cf1bf73f40ae18fcad7 '@@gv_InstanceId','@@gv_ProcessMapId','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','@@gv_ActivityMapId','#growid'");

if((result2ACCBC572E9C4A0FBD46FAB4E50951D4!=null) && (result2ACCBC572E9C4A0FBD46FAB4E50951D4.Count!=0))
{
if(result2ACCBC572E9C4A0FBD46FAB4E50951D4.ContainsKey(3))
ISpace["MFG_T2_DepartureDate"].Value = result2ACCBC572E9C4A0FBD46FAB4E50951D4[3];
if(result2ACCBC572E9C4A0FBD46FAB4E50951D4.ContainsKey(6))
ISpace["MFG_T2_ArrivalDate"].Value = result2ACCBC572E9C4A0FBD46FAB4E50951D4[6];
if(result2ACCBC572E9C4A0FBD46FAB4E50951D4.ContainsKey(8))
ISpace["MFG_T2_ModeofJourney"].Value = result2ACCBC572E9C4A0FBD46FAB4E50951D4[8];
if(result2ACCBC572E9C4A0FBD46FAB4E50951D4.ContainsKey(9))
ISpace["MFG_T2_JourneyClass"].Value = result2ACCBC572E9C4A0FBD46FAB4E50951D4[9];
if(result2ACCBC572E9C4A0FBD46FAB4E50951D4.ContainsKey(12))
ISpace["MFG_T2_Amount"].Value = result2ACCBC572E9C4A0FBD46FAB4E50951D4[12];
if(result2ACCBC572E9C4A0FBD46FAB4E50951D4.ContainsKey(10))
ISpace["MFG_T2_Road"].Value = result2ACCBC572E9C4A0FBD46FAB4E50951D4[10];
if(result2ACCBC572E9C4A0FBD46FAB4E50951D4.ContainsKey(11))
ISpace["MFG_T2_PNRNo"].Value = result2ACCBC572E9C4A0FBD46FAB4E50951D4[11];
if(result2ACCBC572E9C4A0FBD46FAB4E50951D4.ContainsKey(4))
ISpace["MFG_T2_DepartureTime"].Value = result2ACCBC572E9C4A0FBD46FAB4E50951D4[4];
if(result2ACCBC572E9C4A0FBD46FAB4E50951D4.ContainsKey(0))
ISpace["MFG_T2_TADetailsID"].Value = result2ACCBC572E9C4A0FBD46FAB4E50951D4[0];
if(result2ACCBC572E9C4A0FBD46FAB4E50951D4.ContainsKey(7))
ISpace["MFG_T2_ArrivalTime"].Value = result2ACCBC572E9C4A0FBD46FAB4E50951D4[7];
if(result2ACCBC572E9C4A0FBD46FAB4E50951D4.ContainsKey(5))
ISpace["MFG_T2_Arrival"].Value = result2ACCBC572E9C4A0FBD46FAB4E50951D4[5];
if(result2ACCBC572E9C4A0FBD46FAB4E50951D4.ContainsKey(2))
ISpace["MFG_T2_Departure"].Value = result2ACCBC572E9C4A0FBD46FAB4E50951D4[2];
if(result2ACCBC572E9C4A0FBD46FAB4E50951D4.ContainsKey(1))
ISpace["MFG_T2_TravelAdvanceID"].Value = result2ACCBC572E9C4A0FBD46FAB4E50951D4[1];
}
else{
ISpace["MFG_T2_DepartureDate"].Value = null;ISpace["MFG_T2_ArrivalDate"].Value = null;ISpace["MFG_T2_ModeofJourney"].Value = null;ISpace["MFG_T2_JourneyClass"].Value = null;ISpace["MFG_T2_Amount"].Value = null;ISpace["MFG_T2_Road"].Value = null;ISpace["MFG_T2_PNRNo"].Value = null;ISpace["MFG_T2_DepartureTime"].Value = null;ISpace["MFG_T2_TADetailsID"].Value = null;ISpace["MFG_T2_ArrivalTime"].Value = null;ISpace["MFG_T2_Arrival"].Value = null;ISpace["MFG_T2_Departure"].Value = null;ISpace["MFG_T2_TravelAdvanceID"].Value = null;
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

var querySource797A60C10BB64A40915695B92AAFC889 =GetQueryExpressionDataSource("797A60C1-0BB6-4A40-9156-95B92AAFC889");
Dictionary<short,object> result797A60C10BB64A40915695B92AAFC889=iSpace.ExecuteQuery(querySource797A60C10BB64A40915695B92AAFC889,@"SELECT " + ISpace["OverAll_Total"].Value + @"*0.9",false);

base.WriteDebugInfo(@"var querySource797A60C10BB64A40915695B92AAFC889 =GetQueryExpressionDataSource(""797A60C1-0BB6-4A40-9156-95B92AAFC889"");Dictionary<short,object> result797A60C10BB64A40915695B92AAFC889=iSpace.ExecuteQuery(querySource797A60C10BB64A40915695B92AAFC889,@""SELECT "" + ISpace[""OverAll_Total""].Value + @""*0.9"",false);");
base.WriteDebugInfo(@"");

if((result797A60C10BB64A40915695B92AAFC889!=null) && (result797A60C10BB64A40915695B92AAFC889.Count!=0))
{
if(result797A60C10BB64A40915695B92AAFC889.ContainsKey(0))
ISpace["T_AdvanceDrawn"].Value = result797A60C10BB64A40915695B92AAFC889[0];
}
else{
ISpace["T_AdvanceDrawn"].Value = null;
}
}
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


base.WriteDebugInfo(@"
");

var querySource9116BDE3E17548D992EE87A8F58EDC21 =GetQueryExpressionDataSource("9116BDE3-E175-48D9-92EE-87A8F58EDC21");

DataTable result9116BDE3E17548D992EE87A8F58EDC21=iSpace.SetGridDataSource(querySource9116BDE3E17548D992EE87A8F58EDC21, _objectFactory.GetGridRPP("MG_CommitmentDetails"),@"EXEC GetProjectBudgetInformation '" + ISpace["MF_ProjectNo"].Value + @"'");

iSpace.InsertGridBindDetails("MG_CommitmentDetails","11",querySource9116BDE3E17548D992EE87A8F58EDC21,"EXEC GetProjectBudgetInformation '" + ISpace["MF_ProjectNo"].Value + @"'",_objectFactory.GetGridRPP("MG_CommitmentDetails"));

base.WriteDebugInfo(@"var querySource9116BDE3E17548D992EE87A8F58EDC21 =GetQueryExpressionDataSource(""9116BDE3-E175-48D9-92EE-87A8F58EDC21"");DataTable result9116BDE3E17548D992EE87A8F58EDC21=iSpace.SetGridDataSource(querySource9116BDE3E17548D992EE87A8F58EDC21, _objectFactory.GetGridRPP(""MG_CommitmentDetails""),@""EXEC GetProjectBudgetInformation '"" + ISpace[""MF_ProjectNo""].Value + @""'"");iSpace.InsertGridBindDetails(""MG_CommitmentDetails"",""11"",querySource9116BDE3E17548D992EE87A8F58EDC21,""EXEC GetProjectBudgetInformation '"" + ISpace[""MF_ProjectNo""].Value + @""'"",_objectFactory.GetGridRPP(""MG_CommitmentDetails""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> resultCDF3C6581D6D49A190108A78BDE5A1F0=acdataIspaceAAB051287AAE4A998278465822CE1E85.GetQueryExpressionBindings("CDF3C658-1D6D-49A1-9010-8A78BDE5A1F0");
iSpace.SetGridData(result9116BDE3E17548D992EE87A8F58EDC21,resultCDF3C6581D6D49A190108A78BDE5A1F0,"MG_CommitmentDetails",ref ISpace);
iSpace.UpdateGridBindDetails("MG_CommitmentDetails",resultCDF3C6581D6D49A190108A78BDE5A1F0);
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
return;
base.WriteDebugInfo(@"return;");
}
if((ISpace["MFG_T2_FromDate"].Value == null))
{
base.WriteDebugInfo(@"if((ISpace[""MFG_T2_FromDate""].Value == null))");
ISpace["Message"].Value=@"Please Enter the From Date";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please Enter the From Date"";");
return;
base.WriteDebugInfo(@"return;");
}
if((ISpace["MFG_T2_ToDate"].Value == null))
{
base.WriteDebugInfo(@"if((ISpace[""MFG_T2_ToDate""].Value == null))");
ISpace["Message"].Value=@"Please Enter the To Date";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please Enter the To Date"";");
return;
base.WriteDebugInfo(@"return;");
}
if(ISpace["MFG_T2_ToDate"].Value< ISpace["MFG_T2_FromDate"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MFG_T2_ToDate""].Value< ISpace[""MFG_T2_FromDate""].Value)");
ISpace["Message"].Value=@"To Date should be greater than From Date";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""To Date should be greater than From Date"";");
ISpace["MFG_T2_ToDate"].Value=null;
base.WriteDebugInfo(@"ISpace[""MFG_T2_ToDate""].Value=null;");
return;
base.WriteDebugInfo(@"return;");
}
if(ISpace["MFG_T3_Amount"].Value==0)
{
base.WriteDebugInfo(@"if(ISpace[""MFG_T3_Amount""].Value==0)");
ISpace["Message"].Value=@"Please Enter the Amount";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please Enter the Amount"";");
return;
base.WriteDebugInfo(@"return;");
}
}
if(ISpace["growid"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""growid""].Value=="""")");

var querySource35103DBC9C7944E2A5BC8BA3E5A2960A =GetQueryExpressionDataSource("35103DBC-9C79-44E2-A5BC-8BA3E5A2960A");

DataTable result35103DBC9C7944E2A5BC8BA3E5A2960A=iSpace.SetGridDataSource(querySource35103DBC9C7944E2A5BC8BA3E5A2960A, _objectFactory.GetGridRPP("OtherExpense"),@"EXEC AddFormGridData51838b372ec64d358a5e38648bc93ab1 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','51838b37-2ec6-4d35-8a5e-38648bc93ab1','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["MFG_T2_ExpenditureTypeID"].Value + @"','" + ISpace["MFG_T3_TravelAdvanceID"].Value + @"','" + ISpace["MFG_T2_FromDate"].Value + @"','" + ISpace["MFG_T2_ToDate"].Value + @"'," + ISpace["MFG_T3_Amount"].Value + @",'" + ISpace["growid"].Value + @"'");

iSpace.InsertGridBindDetails("OtherExpense","11",querySource35103DBC9C7944E2A5BC8BA3E5A2960A,"EXEC AddFormGridData51838b372ec64d358a5e38648bc93ab1 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','51838b37-2ec6-4d35-8a5e-38648bc93ab1','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["MFG_T2_ExpenditureTypeID"].Value + @"','" + ISpace["MFG_T3_TravelAdvanceID"].Value + @"','" + ISpace["MFG_T2_FromDate"].Value + @"','" + ISpace["MFG_T2_ToDate"].Value + @"'," + ISpace["MFG_T3_Amount"].Value + @",'" + ISpace["growid"].Value + @"'",_objectFactory.GetGridRPP("OtherExpense"));

base.WriteDebugInfo(@"var querySource35103DBC9C7944E2A5BC8BA3E5A2960A =GetQueryExpressionDataSource(""35103DBC-9C79-44E2-A5BC-8BA3E5A2960A"");DataTable result35103DBC9C7944E2A5BC8BA3E5A2960A=iSpace.SetGridDataSource(querySource35103DBC9C7944E2A5BC8BA3E5A2960A, _objectFactory.GetGridRPP(""OtherExpense""),@""EXEC AddFormGridData51838b372ec64d358a5e38648bc93ab1 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','51838b37-2ec6-4d35-8a5e-38648bc93ab1','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""MFG_T2_ExpenditureTypeID""].Value + @""','"" + ISpace[""MFG_T3_TravelAdvanceID""].Value + @""','"" + ISpace[""MFG_T2_FromDate""].Value + @""','"" + ISpace[""MFG_T2_ToDate""].Value + @""',"" + ISpace[""MFG_T3_Amount""].Value + @"",'"" + ISpace[""growid""].Value + @""'"");iSpace.InsertGridBindDetails(""OtherExpense"",""11"",querySource35103DBC9C7944E2A5BC8BA3E5A2960A,""EXEC AddFormGridData51838b372ec64d358a5e38648bc93ab1 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','51838b37-2ec6-4d35-8a5e-38648bc93ab1','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""MFG_T2_ExpenditureTypeID""].Value + @""','"" + ISpace[""MFG_T3_TravelAdvanceID""].Value + @""','"" + ISpace[""MFG_T2_FromDate""].Value + @""','"" + ISpace[""MFG_T2_ToDate""].Value + @""',"" + ISpace[""MFG_T3_Amount""].Value + @"",'"" + ISpace[""growid""].Value + @""'"",_objectFactory.GetGridRPP(""OtherExpense""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> resultF4BA7E5B4EDA4DCC873156AE15108198=acdataIspaceAAB051287AAE4A998278465822CE1E85.GetQueryExpressionBindings("F4BA7E5B-4EDA-4DCC-8731-56AE15108198");
iSpace.SetGridData(result35103DBC9C7944E2A5BC8BA3E5A2960A,resultF4BA7E5B4EDA4DCC873156AE15108198,"OtherExpense",ref ISpace);
iSpace.UpdateGridBindDetails("OtherExpense",resultF4BA7E5B4EDA4DCC873156AE15108198);
}
else
{
base.WriteDebugInfo(@"else");

var querySource4F7F126417684CE3875C0113E884A910 =GetQueryExpressionDataSource("4F7F1264-1768-4CE3-875C-0113E884A910");

DataTable result4F7F126417684CE3875C0113E884A910=iSpace.SetGridDataSource(querySource4F7F126417684CE3875C0113E884A910, _objectFactory.GetGridRPP("OtherExpense"),@"EXEC UpdateFormGridData51838b372ec64d358a5e38648bc93ab1 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','51838b37-2ec6-4d35-8a5e-38648bc93ab1','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["MFG_T2_ExpenditureTypeID"].Value + @"','" + ISpace["MFG_T3_TravelAdvanceID"].Value + @"','" + ISpace["MFG_T2_FromDate"].Value + @"','" + ISpace["MFG_T2_ToDate"].Value + @"'," + ISpace["MFG_T3_Amount"].Value + @",'" + ISpace["growid"].Value + @"'");

iSpace.InsertGridBindDetails("OtherExpense","11",querySource4F7F126417684CE3875C0113E884A910,"EXEC UpdateFormGridData51838b372ec64d358a5e38648bc93ab1 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','51838b37-2ec6-4d35-8a5e-38648bc93ab1','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["MFG_T2_ExpenditureTypeID"].Value + @"','" + ISpace["MFG_T3_TravelAdvanceID"].Value + @"','" + ISpace["MFG_T2_FromDate"].Value + @"','" + ISpace["MFG_T2_ToDate"].Value + @"'," + ISpace["MFG_T3_Amount"].Value + @",'" + ISpace["growid"].Value + @"'",_objectFactory.GetGridRPP("OtherExpense"));

base.WriteDebugInfo(@"var querySource4F7F126417684CE3875C0113E884A910 =GetQueryExpressionDataSource(""4F7F1264-1768-4CE3-875C-0113E884A910"");DataTable result4F7F126417684CE3875C0113E884A910=iSpace.SetGridDataSource(querySource4F7F126417684CE3875C0113E884A910, _objectFactory.GetGridRPP(""OtherExpense""),@""EXEC UpdateFormGridData51838b372ec64d358a5e38648bc93ab1 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','51838b37-2ec6-4d35-8a5e-38648bc93ab1','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""MFG_T2_ExpenditureTypeID""].Value + @""','"" + ISpace[""MFG_T3_TravelAdvanceID""].Value + @""','"" + ISpace[""MFG_T2_FromDate""].Value + @""','"" + ISpace[""MFG_T2_ToDate""].Value + @""',"" + ISpace[""MFG_T3_Amount""].Value + @"",'"" + ISpace[""growid""].Value + @""'"");iSpace.InsertGridBindDetails(""OtherExpense"",""11"",querySource4F7F126417684CE3875C0113E884A910,""EXEC UpdateFormGridData51838b372ec64d358a5e38648bc93ab1 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','51838b37-2ec6-4d35-8a5e-38648bc93ab1','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""MFG_T2_ExpenditureTypeID""].Value + @""','"" + ISpace[""MFG_T3_TravelAdvanceID""].Value + @""','"" + ISpace[""MFG_T2_FromDate""].Value + @""','"" + ISpace[""MFG_T2_ToDate""].Value + @""',"" + ISpace[""MFG_T3_Amount""].Value + @"",'"" + ISpace[""growid""].Value + @""'"",_objectFactory.GetGridRPP(""OtherExpense""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> resultBDC496F72D4A42209C085EEFBC69334B=acdataIspaceAAB051287AAE4A998278465822CE1E85.GetQueryExpressionBindings("BDC496F7-2D4A-4220-9C08-5EEFBC69334B");
iSpace.SetGridData(result4F7F126417684CE3875C0113E884A910,resultBDC496F72D4A42209C085EEFBC69334B,"OtherExpense",ref ISpace);
iSpace.UpdateGridBindDetails("OtherExpense",resultBDC496F72D4A42209C085EEFBC69334B);
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
object MG_T3_Amount=iSpace.Sum("[A694A330-AAD5-4856-853C-D6AD1573AF0B]","MG_T3_Amount","",ISpace["gv_instanceid"].Value);
ISpace["T_ExpenditureTotal"].Value=Convert.ChangeType(MG_T3_Amount, MG_T3_Amount.GetType());;
base.WriteDebugInfo(@"object MG_T3_Amount=iSpace.Sum(""[A694A330-AAD5-4856-853C-D6AD1573AF0B]"",""MG_T3_Amount"","""",ISpace[""gv_instanceid""].Value);
ISpace[""T_ExpenditureTotal""].Value=Convert.ChangeType(MG_T3_Amount, MG_T3_Amount.GetType());;");
ISpace["OverAll_Total"].Value=ISpace["T_TravelAdvanceTotal"].Value+ISpace["T_ExpenditureTotal"].Value;
base.WriteDebugInfo(@"ISpace[""OverAll_Total""].Value=ISpace[""T_TravelAdvanceTotal""].Value+ISpace[""T_ExpenditureTotal""].Value;");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"SELECT #OverAll_Total*0.9");

var querySource797A60C10BB64A40915695B92AAFC889 =GetQueryExpressionDataSource("797A60C1-0BB6-4A40-9156-95B92AAFC889");
Dictionary<short,object> result797A60C10BB64A40915695B92AAFC889=iSpace.ExecuteQuery(querySource797A60C10BB64A40915695B92AAFC889,@"SELECT " + ISpace["OverAll_Total"].Value + @"*0.9",false);

base.WriteDebugInfo(@"var querySource797A60C10BB64A40915695B92AAFC889 =GetQueryExpressionDataSource(""797A60C1-0BB6-4A40-9156-95B92AAFC889"");Dictionary<short,object> result797A60C10BB64A40915695B92AAFC889=iSpace.ExecuteQuery(querySource797A60C10BB64A40915695B92AAFC889,@""SELECT "" + ISpace[""OverAll_Total""].Value + @""*0.9"",false);");
base.WriteDebugInfo(@"");

if((result797A60C10BB64A40915695B92AAFC889!=null) && (result797A60C10BB64A40915695B92AAFC889.Count!=0))
{
if(result797A60C10BB64A40915695B92AAFC889.ContainsKey(0))
ISpace["T_AdvanceDrawn"].Value = result797A60C10BB64A40915695B92AAFC889[0];
}
else{
ISpace["T_AdvanceDrawn"].Value = null;
}
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
base.WriteDebugInfo(@"exec SP_GetTravelAdvanceFundDetails 2,'','#MG_FundDetailsID'");

var querySource5FF745B4E8FE40A798DD1695E33EAF99 =GetQueryExpressionDataSource("5FF745B4-E8FE-40A7-98DD-1695E33EAF99");
Dictionary<short,object> result5FF745B4E8FE40A798DD1695E33EAF99=iSpace.ExecuteQuery(querySource5FF745B4E8FE40A798DD1695E33EAF99,@"exec SP_GetTravelAdvanceFundDetails 2,'','" + ISpace["MG_FundDetailsID"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource5FF745B4E8FE40A798DD1695E33EAF99 =GetQueryExpressionDataSource(""5FF745B4-E8FE-40A7-98DD-1695E33EAF99"");Dictionary<short,object> result5FF745B4E8FE40A798DD1695E33EAF99=iSpace.ExecuteQuery(querySource5FF745B4E8FE40A798DD1695E33EAF99,@""exec SP_GetTravelAdvanceFundDetails 2,'','"" + ISpace[""MG_FundDetailsID""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result5FF745B4E8FE40A798DD1695E33EAF99!=null) && (result5FF745B4E8FE40A798DD1695E33EAF99.Count!=0))
{
if(result5FF745B4E8FE40A798DD1695E33EAF99.ContainsKey(3))
ISpace["MF_ProjectNo"].Value = result5FF745B4E8FE40A798DD1695E33EAF99[3];
if(result5FF745B4E8FE40A798DD1695E33EAF99.ContainsKey(2))
ISpace["MF_FundType"].Value = result5FF745B4E8FE40A798DD1695E33EAF99[2];
if(result5FF745B4E8FE40A798DD1695E33EAF99.ContainsKey(4))
ISpace["MF_BudgetHead"].Value = result5FF745B4E8FE40A798DD1695E33EAF99[4];
if(result5FF745B4E8FE40A798DD1695E33EAF99.ContainsKey(5))
ISpace["MF_Amount"].Value = result5FF745B4E8FE40A798DD1695E33EAF99[5];
if(result5FF745B4E8FE40A798DD1695E33EAF99.ContainsKey(0))
ISpace["MF_FundDetailsId"].Value = result5FF745B4E8FE40A798DD1695E33EAF99[0];
}
else{
ISpace["MF_ProjectNo"].Value = null;ISpace["MF_FundType"].Value = null;ISpace["MF_BudgetHead"].Value = null;ISpace["MF_Amount"].Value = null;ISpace["MF_FundDetailsId"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_FundType"].Value=="1")
{
base.WriteDebugInfo(@"if(ISpace[""MF_FundType""].Value==""1"")");
ISpace["MF_ProjectNo"].Visible="true";ISpace["MF_ProjectNo"].Man=true;ISpace["MF_BudgetHead"].Visible="true";ISpace["MF_BudgetHead"].Man=true;ISpace["MF_Amount"].Visible="true";ISpace["MF_Amount"].Man=true;
base.WriteDebugInfo(@"ISpace[""MF_ProjectNo""].Visible=""true"";ISpace[""MF_ProjectNo""].Man=true;ISpace[""MF_BudgetHead""].Visible=""true"";ISpace[""MF_BudgetHead""].Man=true;ISpace[""MF_Amount""].Visible=""true"";ISpace[""MF_Amount""].Man=true;");
ISpace["M_OpenModal"].Visible="true";
base.WriteDebugInfo(@"ISpace[""M_OpenModal""].Visible=""true"";");
ISpace["MF_BudgetHead"].rElemData=iSpace.Reload(ISpace["MF_BudgetHead"].Value,@"exec SP_GetDistrubitionDetails 5,'@" + ISpace["gv_ProcessMapId"].Value + @"'," + ISpace["MF_FundType"].Value + @",'','','','','" + ISpace["MF_ProjectNo"].Value + @"'","9ADED37B-CD11-426B-AF16-DEAC75685EF5");
base.WriteDebugInfo(@"ISpace[""MF_BudgetHead""].rElemData=iSpace.Reload(ISpace[""MF_BudgetHead""].Value,@""exec SP_GetDistrubitionDetails 5,'@"" + ISpace[""gv_ProcessMapId""].Value + @""',"" + ISpace[""MF_FundType""].Value + @"",'','','','','"" + ISpace[""MF_ProjectNo""].Value + @""'"",""9ADED37B-CD11-426B-AF16-DEAC75685EF5"");");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_ProjectNo"].Visible="false";ISpace["MF_ProjectNo"].Man=false;ISpace["MF_BudgetHead"].Visible="false";ISpace["MF_BudgetHead"].Man=false;ISpace["MF_Amount"].Visible="true";ISpace["MF_Amount"].Man=true;
base.WriteDebugInfo(@"ISpace[""MF_ProjectNo""].Visible=""false"";ISpace[""MF_ProjectNo""].Man=false;ISpace[""MF_BudgetHead""].Visible=""false"";ISpace[""MF_BudgetHead""].Man=false;ISpace[""MF_Amount""].Visible=""true"";ISpace[""MF_Amount""].Man=true;");
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
private void SubscribeElementEvents_m_travelyes (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"M_TravelYes-OnClick");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySourceED8F039D5B074E67A9181A0BCE50C57F =GetQueryExpressionDataSource("ED8F039D-5B07-4E67-A918-1A0BCE50C57F");

DataTable resultED8F039D5B074E67A9181A0BCE50C57F=iSpace.SetGridDataSource(querySourceED8F039D5B074E67A9181A0BCE50C57F, _objectFactory.GetGridRPP("TravelExpense"),@"EXEC DeleteFormGridData374fb8a88dd94cf1bf73f40ae18fcad7 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["growid"].Value + @"'");

iSpace.InsertGridBindDetails("TravelExpense","11",querySourceED8F039D5B074E67A9181A0BCE50C57F,"EXEC DeleteFormGridData374fb8a88dd94cf1bf73f40ae18fcad7 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["growid"].Value + @"'",_objectFactory.GetGridRPP("TravelExpense"));

base.WriteDebugInfo(@"var querySourceED8F039D5B074E67A9181A0BCE50C57F =GetQueryExpressionDataSource(""ED8F039D-5B07-4E67-A918-1A0BCE50C57F"");DataTable resultED8F039D5B074E67A9181A0BCE50C57F=iSpace.SetGridDataSource(querySourceED8F039D5B074E67A9181A0BCE50C57F, _objectFactory.GetGridRPP(""TravelExpense""),@""EXEC DeleteFormGridData374fb8a88dd94cf1bf73f40ae18fcad7 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""growid""].Value + @""'"");iSpace.InsertGridBindDetails(""TravelExpense"",""11"",querySourceED8F039D5B074E67A9181A0BCE50C57F,""EXEC DeleteFormGridData374fb8a88dd94cf1bf73f40ae18fcad7 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""growid""].Value + @""'"",_objectFactory.GetGridRPP(""TravelExpense""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result8D30243FBB2A463A85FF7259BCF2E3B1=acdataIspaceAAB051287AAE4A998278465822CE1E85.GetQueryExpressionBindings("8D30243F-BB2A-463A-85FF-7259BCF2E3B1");
iSpace.SetGridData(resultED8F039D5B074E67A9181A0BCE50C57F,result8D30243FBB2A463A85FF7259BCF2E3B1,"TravelExpense",ref ISpace);
iSpace.UpdateGridBindDetails("TravelExpense",result8D30243FBB2A463A85FF7259BCF2E3B1);
ISpace["Message"].Value=@"Data deleted successfully";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Data deleted successfully"";");
ISpace["UI_DialogTravel"].HideDialog=true;;
base.WriteDebugInfo(@"ISpace[""UI_DialogTravel""].HideDialog=true;;");
object MG_T2_Amount=iSpace.Sum("[FA412DDD-7AD9-49AF-B8D7-2B7E1620D8FC]","MG_T2_Amount","",ISpace["gv_instanceid"].Value);
ISpace["T_TravelAdvanceTotal"].Value=Convert.ChangeType(MG_T2_Amount, MG_T2_Amount.GetType());;
base.WriteDebugInfo(@"object MG_T2_Amount=iSpace.Sum(""[FA412DDD-7AD9-49AF-B8D7-2B7E1620D8FC]"",""MG_T2_Amount"","""",ISpace[""gv_instanceid""].Value);
ISpace[""T_TravelAdvanceTotal""].Value=Convert.ChangeType(MG_T2_Amount, MG_T2_Amount.GetType());;");
ISpace["OverAll_Total"].Value=ISpace["T_TravelAdvanceTotal"].Value+ISpace["T_ExpenditureTotal"].Value;
base.WriteDebugInfo(@"ISpace[""OverAll_Total""].Value=ISpace[""T_TravelAdvanceTotal""].Value+ISpace[""T_ExpenditureTotal""].Value;");
ISpace["growid"].Value="";
base.WriteDebugInfo(@"ISpace[""growid""].Value="""";");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"SELECT #OverAll_Total*0.9");

var querySource797A60C10BB64A40915695B92AAFC889 =GetQueryExpressionDataSource("797A60C1-0BB6-4A40-9156-95B92AAFC889");
Dictionary<short,object> result797A60C10BB64A40915695B92AAFC889=iSpace.ExecuteQuery(querySource797A60C10BB64A40915695B92AAFC889,@"SELECT " + ISpace["OverAll_Total"].Value + @"*0.9",false);

base.WriteDebugInfo(@"var querySource797A60C10BB64A40915695B92AAFC889 =GetQueryExpressionDataSource(""797A60C1-0BB6-4A40-9156-95B92AAFC889"");Dictionary<short,object> result797A60C10BB64A40915695B92AAFC889=iSpace.ExecuteQuery(querySource797A60C10BB64A40915695B92AAFC889,@""SELECT "" + ISpace[""OverAll_Total""].Value + @""*0.9"",false);");
base.WriteDebugInfo(@"");

if((result797A60C10BB64A40915695B92AAFC889!=null) && (result797A60C10BB64A40915695B92AAFC889.Count!=0))
{
if(result797A60C10BB64A40915695B92AAFC889.ContainsKey(0))
ISpace["T_AdvanceDrawn"].Value = result797A60C10BB64A40915695B92AAFC889[0];
}
else{
ISpace["T_AdvanceDrawn"].Value = null;
}
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

var querySourceE51258BF79BE40CFB8C4A28ACDA2DAA4 =GetQueryExpressionDataSource("E51258BF-79BE-40CF-B8C4-A28ACDA2DAA4");

DataTable resultE51258BF79BE40CFB8C4A28ACDA2DAA4=iSpace.SetGridDataSource(querySourceE51258BF79BE40CFB8C4A28ACDA2DAA4, _objectFactory.GetGridRPP("MF_FundAmount"),@"exec SP_GetTravelAdvanceFundDetails 3,'" + ISpace["MF_T1_TravelAdvanceID"].Value + @"','" + ISpace["MF_FundDetailsId"].Value + @"','" + ISpace["M_TravelInstanceId"].Value + @"'");

iSpace.InsertGridBindDetails("MF_FundAmount","11",querySourceE51258BF79BE40CFB8C4A28ACDA2DAA4,"exec SP_GetTravelAdvanceFundDetails 3,'" + ISpace["MF_T1_TravelAdvanceID"].Value + @"','" + ISpace["MF_FundDetailsId"].Value + @"','" + ISpace["M_TravelInstanceId"].Value + @"'",_objectFactory.GetGridRPP("MF_FundAmount"));

base.WriteDebugInfo(@"var querySourceE51258BF79BE40CFB8C4A28ACDA2DAA4 =GetQueryExpressionDataSource(""E51258BF-79BE-40CF-B8C4-A28ACDA2DAA4"");DataTable resultE51258BF79BE40CFB8C4A28ACDA2DAA4=iSpace.SetGridDataSource(querySourceE51258BF79BE40CFB8C4A28ACDA2DAA4, _objectFactory.GetGridRPP(""MF_FundAmount""),@""exec SP_GetTravelAdvanceFundDetails 3,'"" + ISpace[""MF_T1_TravelAdvanceID""].Value + @""','"" + ISpace[""MF_FundDetailsId""].Value + @""','"" + ISpace[""M_TravelInstanceId""].Value + @""'"");iSpace.InsertGridBindDetails(""MF_FundAmount"",""11"",querySourceE51258BF79BE40CFB8C4A28ACDA2DAA4,""exec SP_GetTravelAdvanceFundDetails 3,'"" + ISpace[""MF_T1_TravelAdvanceID""].Value + @""','"" + ISpace[""MF_FundDetailsId""].Value + @""','"" + ISpace[""M_TravelInstanceId""].Value + @""'"",_objectFactory.GetGridRPP(""MF_FundAmount""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result5A20F168471849C2B6E4F11345E33F05=acdataIspaceAAB051287AAE4A998278465822CE1E85.GetQueryExpressionBindings("5A20F168-4718-49C2-B6E4-F11345E33F05");
iSpace.SetGridData(resultE51258BF79BE40CFB8C4A28ACDA2DAA4,result5A20F168471849C2B6E4F11345E33F05,"MF_FundAmount",ref ISpace);
iSpace.UpdateGridBindDetails("MF_FundAmount",result5A20F168471849C2B6E4F11345E33F05);
ISpace["MF_FundDetailsId"].Value="";
base.WriteDebugInfo(@"ISpace[""MF_FundDetailsId""].Value="""";");
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

var querySource797A60C10BB64A40915695B92AAFC889 =GetQueryExpressionDataSource("797A60C1-0BB6-4A40-9156-95B92AAFC889");
Dictionary<short,object> result797A60C10BB64A40915695B92AAFC889=iSpace.ExecuteQuery(querySource797A60C10BB64A40915695B92AAFC889,@"SELECT " + ISpace["OverAll_Total"].Value + @"*0.9",false);

base.WriteDebugInfo(@"var querySource797A60C10BB64A40915695B92AAFC889 =GetQueryExpressionDataSource(""797A60C1-0BB6-4A40-9156-95B92AAFC889"");Dictionary<short,object> result797A60C10BB64A40915695B92AAFC889=iSpace.ExecuteQuery(querySource797A60C10BB64A40915695B92AAFC889,@""SELECT "" + ISpace[""OverAll_Total""].Value + @""*0.9"",false);");
base.WriteDebugInfo(@"");

if((result797A60C10BB64A40915695B92AAFC889!=null) && (result797A60C10BB64A40915695B92AAFC889.Count!=0))
{
if(result797A60C10BB64A40915695B92AAFC889.ContainsKey(0))
ISpace["T_AdvanceDrawn"].Value = result797A60C10BB64A40915695B92AAFC889[0];
}
else{
ISpace["T_AdvanceDrawn"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySourceF83D458B7CDF409F932998D97A3D6B68 =GetQueryExpressionDataSource("F83D458B-7CDF-409F-9329-98D97A3D6B68");

DataTable resultF83D458B7CDF409F932998D97A3D6B68=iSpace.SetGridDataSource(querySourceF83D458B7CDF409F932998D97A3D6B68, _objectFactory.GetGridRPP("OtherExpense"),@"EXEC DeleteFormGridData51838b372ec64d358a5e38648bc93ab1 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','51838b37-2ec6-4d35-8a5e-38648bc93ab1','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["growid"].Value + @"'");

iSpace.InsertGridBindDetails("OtherExpense","11",querySourceF83D458B7CDF409F932998D97A3D6B68,"EXEC DeleteFormGridData51838b372ec64d358a5e38648bc93ab1 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','51838b37-2ec6-4d35-8a5e-38648bc93ab1','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["growid"].Value + @"'",_objectFactory.GetGridRPP("OtherExpense"));

base.WriteDebugInfo(@"var querySourceF83D458B7CDF409F932998D97A3D6B68 =GetQueryExpressionDataSource(""F83D458B-7CDF-409F-9329-98D97A3D6B68"");DataTable resultF83D458B7CDF409F932998D97A3D6B68=iSpace.SetGridDataSource(querySourceF83D458B7CDF409F932998D97A3D6B68, _objectFactory.GetGridRPP(""OtherExpense""),@""EXEC DeleteFormGridData51838b372ec64d358a5e38648bc93ab1 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','51838b37-2ec6-4d35-8a5e-38648bc93ab1','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""growid""].Value + @""'"");iSpace.InsertGridBindDetails(""OtherExpense"",""11"",querySourceF83D458B7CDF409F932998D97A3D6B68,""EXEC DeleteFormGridData51838b372ec64d358a5e38648bc93ab1 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','51838b37-2ec6-4d35-8a5e-38648bc93ab1','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""growid""].Value + @""'"",_objectFactory.GetGridRPP(""OtherExpense""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> resultF3AFBB51AFF14D34B12216E3E1E5CA86=acdataIspaceAAB051287AAE4A998278465822CE1E85.GetQueryExpressionBindings("F3AFBB51-AFF1-4D34-B122-16E3E1E5CA86");
iSpace.SetGridData(resultF83D458B7CDF409F932998D97A3D6B68,resultF3AFBB51AFF14D34B12216E3E1E5CA86,"OtherExpense",ref ISpace);
iSpace.UpdateGridBindDetails("OtherExpense",resultF3AFBB51AFF14D34B12216E3E1E5CA86);
ISpace["Message"].Value=@"Data deleted successfully";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Data deleted successfully"";");
object MG_T3_Amount=iSpace.Sum("[A694A330-AAD5-4856-853C-D6AD1573AF0B]","MG_T3_Amount","",ISpace["gv_instanceid"].Value);
ISpace["T_ExpenditureTotal"].Value=Convert.ChangeType(MG_T3_Amount, MG_T3_Amount.GetType());;
base.WriteDebugInfo(@"object MG_T3_Amount=iSpace.Sum(""[A694A330-AAD5-4856-853C-D6AD1573AF0B]"",""MG_T3_Amount"","""",ISpace[""gv_instanceid""].Value);
ISpace[""T_ExpenditureTotal""].Value=Convert.ChangeType(MG_T3_Amount, MG_T3_Amount.GetType());;");
ISpace["OverAll_Total"].Value=ISpace["T_TravelAdvanceTotal"].Value+ISpace["T_ExpenditureTotal"].Value;
base.WriteDebugInfo(@"ISpace[""OverAll_Total""].Value=ISpace[""T_TravelAdvanceTotal""].Value+ISpace[""T_ExpenditureTotal""].Value;");
ISpace["growid"].Value="";
base.WriteDebugInfo(@"ISpace[""growid""].Value="""";");
ISpace["UI_DialogOther"].HideDialog=true;;
base.WriteDebugInfo(@"ISpace[""UI_DialogOther""].HideDialog=true;;");
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

var querySource41A49BE08FEE4020BEAA0553B628681F =GetQueryExpressionDataSource("41A49BE0-8FEE-4020-BEAA-0553B628681F");
Dictionary<short,object> result41A49BE08FEE4020BEAA0553B628681F=iSpace.ExecuteQuery(querySource41A49BE08FEE4020BEAA0553B628681F,@"EXEC GETReceiptAmountBalace 2,'" + ISpace["C_FC_ProjectNo_33"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource41A49BE08FEE4020BEAA0553B628681F =GetQueryExpressionDataSource(""41A49BE0-8FEE-4020-BEAA-0553B628681F"");Dictionary<short,object> result41A49BE08FEE4020BEAA0553B628681F=iSpace.ExecuteQuery(querySource41A49BE08FEE4020BEAA0553B628681F,@""EXEC GETReceiptAmountBalace 2,'"" + ISpace[""C_FC_ProjectNo_33""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result41A49BE08FEE4020BEAA0553B628681F!=null) && (result41A49BE08FEE4020BEAA0553B628681F.Count!=0))
{
if(result41A49BE08FEE4020BEAA0553B628681F.ContainsKey(3))
ISpace["C_FC_StartDate_33"].Value = result41A49BE08FEE4020BEAA0553B628681F[3];
if(result41A49BE08FEE4020BEAA0553B628681F.ContainsKey(4))
ISpace["C_FC_EndDate_33"].Value = result41A49BE08FEE4020BEAA0553B628681F[4];
if(result41A49BE08FEE4020BEAA0553B628681F.ContainsKey(2))
ISpace["C_FC_SanctionedDate_33"].Value = result41A49BE08FEE4020BEAA0553B628681F[2];
if(result41A49BE08FEE4020BEAA0553B628681F.ContainsKey(7))
ISpace["C_FC_Category_33"].Value = result41A49BE08FEE4020BEAA0553B628681F[7];
if(result41A49BE08FEE4020BEAA0553B628681F.ContainsKey(5))
ISpace["C_FC_SanctionNo_33"].Value = result41A49BE08FEE4020BEAA0553B628681F[5];
if(result41A49BE08FEE4020BEAA0553B628681F.ContainsKey(6))
ISpace["C_FC_AgencyCode_33"].Value = result41A49BE08FEE4020BEAA0553B628681F[6];
if(result41A49BE08FEE4020BEAA0553B628681F.ContainsKey(8))
ISpace["C_FC_SanctionedValue_33"].Value = result41A49BE08FEE4020BEAA0553B628681F[8];
if(result41A49BE08FEE4020BEAA0553B628681F.ContainsKey(1))
ISpace["C_FC_ProjectName_33"].Value = result41A49BE08FEE4020BEAA0553B628681F[1];
}
else{
ISpace["C_FC_StartDate_33"].Value = null;ISpace["C_FC_EndDate_33"].Value = null;ISpace["C_FC_SanctionedDate_33"].Value = null;ISpace["C_FC_Category_33"].Value = null;ISpace["C_FC_SanctionNo_33"].Value = null;ISpace["C_FC_AgencyCode_33"].Value = null;ISpace["C_FC_SanctionedValue_33"].Value = null;ISpace["C_FC_ProjectName_33"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC GETReceiptAmountBalace 3,'#C_FC_ProjectNo_33'");

var querySourceBA60CD900CDC4883991C21CD74ED46AA =GetQueryExpressionDataSource("BA60CD90-0CDC-4883-991C-21CD74ED46AA");
Dictionary<short,object> resultBA60CD900CDC4883991C21CD74ED46AA=iSpace.ExecuteQuery(querySourceBA60CD900CDC4883991C21CD74ED46AA,@"EXEC GETReceiptAmountBalace 3,'" + ISpace["C_FC_ProjectNo_33"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceBA60CD900CDC4883991C21CD74ED46AA =GetQueryExpressionDataSource(""BA60CD90-0CDC-4883-991C-21CD74ED46AA"");Dictionary<short,object> resultBA60CD900CDC4883991C21CD74ED46AA=iSpace.ExecuteQuery(querySourceBA60CD900CDC4883991C21CD74ED46AA,@""EXEC GETReceiptAmountBalace 3,'"" + ISpace[""C_FC_ProjectNo_33""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultBA60CD900CDC4883991C21CD74ED46AA!=null) && (resultBA60CD900CDC4883991C21CD74ED46AA.Count!=0))
{
if(resultBA60CD900CDC4883991C21CD74ED46AA.ContainsKey(2))
ISpace["C_FC_ReceiptAmountinBudgetHead"].Value = resultBA60CD900CDC4883991C21CD74ED46AA[2];
if(resultBA60CD900CDC4883991C21CD74ED46AA.ContainsKey(1))
ISpace["C_FC_BudgetHeadAmount"].Value = resultBA60CD900CDC4883991C21CD74ED46AA[1];
}
else{
ISpace["C_FC_ReceiptAmountinBudgetHead"].Value = null;ISpace["C_FC_BudgetHeadAmount"].Value = null;
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
private void SubscribeElementEvents_travel_type (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Travel_Type-OnChange");
if(ISpace["Travel_Type"].Value=="1")
{
base.WriteDebugInfo(@"if(ISpace[""Travel_Type""].Value==""1"")");
ISpace["MF_T1_AccountNo"].Man=false;ISpace["MF_T1_BankBranch"].Man=false;ISpace["MF_T1_BeneficiaryName"].Man=false;ISpace["MF_T1_BankDocument"].Man=false;ISpace["MF_T1_BankName"].Man=false;
base.WriteDebugInfo(@"ISpace[""MF_T1_AccountNo""].Man=false;ISpace[""MF_T1_BankBranch""].Man=false;ISpace[""MF_T1_BeneficiaryName""].Man=false;ISpace[""MF_T1_BankDocument""].Man=false;ISpace[""MF_T1_BankName""].Man=false;");
}
if(ISpace["Travel_Type"].Value=="3")
{
base.WriteDebugInfo(@"if(ISpace[""Travel_Type""].Value==""3"")");
ISpace["MF_T1_AccountNo"].Man=true;ISpace["MF_T1_AccountNo"].Enbl="true";ISpace["MF_T1_BankBranch"].Man=true;ISpace["MF_T1_BankBranch"].Enbl="true";ISpace["MF_T1_AdvanceAmount"].Man=true;ISpace["MF_T1_AdvanceAmount"].Enbl="true";ISpace["MF_T1_BeneficiaryName"].Man=true;ISpace["MF_T1_BeneficiaryName"].Enbl="true";ISpace["MF_T1_BankDocument"].Man=true;ISpace["MF_T1_BankDocument"].Enbl="true";ISpace["MF_T1_BankName"].Man=true;ISpace["MF_T1_BankName"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_T1_AccountNo""].Man=true;ISpace[""MF_T1_AccountNo""].Enbl=""true"";ISpace[""MF_T1_BankBranch""].Man=true;ISpace[""MF_T1_BankBranch""].Enbl=""true"";ISpace[""MF_T1_AdvanceAmount""].Man=true;ISpace[""MF_T1_AdvanceAmount""].Enbl=""true"";ISpace[""MF_T1_BeneficiaryName""].Man=true;ISpace[""MF_T1_BeneficiaryName""].Enbl=""true"";ISpace[""MF_T1_BankDocument""].Man=true;ISpace[""MF_T1_BankDocument""].Enbl=""true"";ISpace[""MF_T1_BankName""].Man=true;ISpace[""MF_T1_BankName""].Enbl=""true"";");
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
private void SubscribeElementEvents_mg_t2_amount (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MG_T2_Amount-OnChange");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
object MG_T2_Amount=iSpace.Sum("[FA412DDD-7AD9-49AF-B8D7-2B7E1620D8FC]","MG_T2_Amount","",ISpace["gv_instanceid"].Value);
ISpace["T_TravelAdvanceTotal"].Value=Convert.ChangeType(MG_T2_Amount, MG_T2_Amount.GetType());;
base.WriteDebugInfo(@"object MG_T2_Amount=iSpace.Sum(""[FA412DDD-7AD9-49AF-B8D7-2B7E1620D8FC]"",""MG_T2_Amount"","""",ISpace[""gv_instanceid""].Value);
ISpace[""T_TravelAdvanceTotal""].Value=Convert.ChangeType(MG_T2_Amount, MG_T2_Amount.GetType());;");
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
		if(elementName.ToLower().Equals("mfg_t2_modeofjourney"))
    {
    			SubscribeElementEvents_mfg_t2_modeofjourney(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mf_projectno"))
    {
    			SubscribeElementEvents_mf_projectno(ref dfsParam);
    }
		if(elementName.ToLower().Equals("t_expendituretotal"))
    {
    			SubscribeElementEvents_t_expendituretotal(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mfg_t2_departure"))
    {
    			SubscribeElementEvents_mfg_t2_departure(ref dfsParam);
    }
		if(elementName.ToLower().Equals("overall_total"))
    {
    			SubscribeElementEvents_overall_total(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mg_t3_amount"))
    {
    			SubscribeElementEvents_mg_t3_amount(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mfg_t2_departuredate"))
    {
    			SubscribeElementEvents_mfg_t2_departuredate(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mfg_t2_arrivaldate"))
    {
    			SubscribeElementEvents_mfg_t2_arrivaldate(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mf_fundtype"))
    {
    			SubscribeElementEvents_mf_fundtype(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mf_t1_budgethead"))
    {
    			SubscribeElementEvents_mf_t1_budgethead(ref dfsParam);
    }
		if(elementName.ToLower().Equals("m_isadvancerequired"))
    {
    			SubscribeElementEvents_m_isadvancerequired(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mg_t2_fromdate"))
    {
    			SubscribeElementEvents_mg_t2_fromdate(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mg_t2_todate"))
    {
    			SubscribeElementEvents_mg_t2_todate(ref dfsParam);
    }
		if(elementName.ToLower().Equals("t_traveladvancetotal"))
    {
    			SubscribeElementEvents_t_traveladvancetotal(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mfg_t2_todate"))
    {
    			SubscribeElementEvents_mfg_t2_todate(ref dfsParam);
    }
		if(elementName.ToLower().Equals("advanceamount"))
    {
    			SubscribeElementEvents_advanceamount(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mfg_t2_fromdate"))
    {
    			SubscribeElementEvents_mfg_t2_fromdate(ref dfsParam);
    }
		if(elementName.ToLower().Equals("c_fc_projectno_33"))
    {
    			SubscribeElementEvents_c_fc_projectno_33(ref dfsParam);
    }
		if(elementName.ToLower().Equals("travel_type"))
    {
    			SubscribeElementEvents_travel_type(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mfg_t2_arrival"))
    {
    			SubscribeElementEvents_mfg_t2_arrival(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mg_t2_amount"))
    {
    			SubscribeElementEvents_mg_t2_amount(ref dfsParam);
    }
}
	if(methodName.ToLower().Equals("onclick"))
{
		if(elementName.ToLower().Equals("delete_travelexpense"))
{
			SubscribeElementEvents_delete_travelexpense(ref dfsParam);
}
		if(elementName.ToLower().Equals("edit_otherexpense"))
{
			SubscribeElementEvents_edit_otherexpense(ref dfsParam);
}
		if(elementName.ToLower().Equals("submitform"))
{
			SubscribeElementEvents_submitform(ref dfsParam);
}
		if(elementName.ToLower().Equals("delete_otherexpense"))
{
			SubscribeElementEvents_delete_otherexpense(ref dfsParam);
}
		if(elementName.ToLower().Equals("m_otherno"))
{
			SubscribeElementEvents_m_otherno(ref dfsParam);
}
		if(elementName.ToLower().Equals("save_travelexpense"))
{
			SubscribeElementEvents_save_travelexpense(ref dfsParam);
}
		if(elementName.ToLower().Equals("mf_add"))
{
			SubscribeElementEvents_mf_add(ref dfsParam);
}
		if(elementName.ToLower().Equals("edit_travelexpense"))
{
			SubscribeElementEvents_edit_travelexpense(ref dfsParam);
}
		if(elementName.ToLower().Equals("m_openmodal"))
{
			SubscribeElementEvents_m_openmodal(ref dfsParam);
}
		if(elementName.ToLower().Equals("save_otherexpense"))
{
			SubscribeElementEvents_save_otherexpense(ref dfsParam);
}
		if(elementName.ToLower().Equals("m_travelno"))
{
			SubscribeElementEvents_m_travelno(ref dfsParam);
}
		if(elementName.ToLower().Equals("mg_edit"))
{
			SubscribeElementEvents_mg_edit(ref dfsParam);
}
		if(elementName.ToLower().Equals("m_fundno"))
{
			SubscribeElementEvents_m_fundno(ref dfsParam);
}
		if(elementName.ToLower().Equals("m_travelyes"))
{
			SubscribeElementEvents_m_travelyes(ref dfsParam);
}
		if(elementName.ToLower().Equals("m_fundyes"))
{
			SubscribeElementEvents_m_fundyes(ref dfsParam);
}
		if(elementName.ToLower().Equals("m_otheryes"))
{
			SubscribeElementEvents_m_otheryes(ref dfsParam);
}
		if(elementName.ToLower().Equals("mg_delete"))
{
			SubscribeElementEvents_mg_delete(ref dfsParam);
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
public class ISpaceCE310762909A4A90A266630580753EC6 : VirtualForm
{
IISpace iSpace = new ISpace();
AcDataISpaceCE310762909A4A90A266630580753EC6 acdataIspaceCE310762909A4A90A266630580753EC6=new AcDataISpaceCE310762909A4A90A266630580753EC6();
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
ISpace["M_TravelInstanceId"].Value=Guid.NewGuid().ToString();
base.WriteDebugInfo(@"ISpace[""M_TravelInstanceId""].Value=Guid.NewGuid().ToString();");
ISpace["M_MoveTo"].Man=true;
base.WriteDebugInfo(@"ISpace[""M_MoveTo""].Man=true;");
ISpace["M_Remarks"].Value="";
base.WriteDebugInfo(@"ISpace[""M_Remarks""].Value="""";");
ISpace["M_NextStage"].Value="";
base.WriteDebugInfo(@"ISpace[""M_NextStage""].Value="""";");
ISpace["MF_TransactionDate"].Man=true;ISpace["MF_TransactionNo"].Man=true;
base.WriteDebugInfo(@"ISpace[""MF_TransactionDate""].Man=true;ISpace[""MF_TransactionNo""].Man=true;");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySourceA0ECD2B8980941FB814ECFF85B9E0A09 =GetQueryExpressionDataSource("A0ECD2B8-9809-41FB-814E-CFF85B9E0A09");

DataTable resultA0ECD2B8980941FB814ECFF85B9E0A09=iSpace.SetGridDataSource(querySourceA0ECD2B8980941FB814ECFF85B9E0A09, _objectFactory.GetGridRPP("MG_RemarksDetails"),@"EXEC GetRemarks '" + ISpace["M_InstanceId"].Value + @"'");

iSpace.InsertGridBindDetails("MG_RemarksDetails","11",querySourceA0ECD2B8980941FB814ECFF85B9E0A09,"EXEC GetRemarks '" + ISpace["M_InstanceId"].Value + @"'",_objectFactory.GetGridRPP("MG_RemarksDetails"));

base.WriteDebugInfo(@"var querySourceA0ECD2B8980941FB814ECFF85B9E0A09 =GetQueryExpressionDataSource(""A0ECD2B8-9809-41FB-814E-CFF85B9E0A09"");DataTable resultA0ECD2B8980941FB814ECFF85B9E0A09=iSpace.SetGridDataSource(querySourceA0ECD2B8980941FB814ECFF85B9E0A09, _objectFactory.GetGridRPP(""MG_RemarksDetails""),@""EXEC GetRemarks '"" + ISpace[""M_InstanceId""].Value + @""'"");iSpace.InsertGridBindDetails(""MG_RemarksDetails"",""11"",querySourceA0ECD2B8980941FB814ECFF85B9E0A09,""EXEC GetRemarks '"" + ISpace[""M_InstanceId""].Value + @""'"",_objectFactory.GetGridRPP(""MG_RemarksDetails""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> resultCBD3E108E08C4B5F8ACA817E51BDACD4=acdataIspaceCE310762909A4A90A266630580753EC6.GetQueryExpressionBindings("CBD3E108-E08C-4B5F-8ACA-817E51BDACD4");
iSpace.SetGridData(resultA0ECD2B8980941FB814ECFF85B9E0A09,resultCBD3E108E08C4B5F8ACA817E51BDACD4,"MG_RemarksDetails",ref ISpace);
iSpace.UpdateGridBindDetails("MG_RemarksDetails",resultCBD3E108E08C4B5F8ACA817E51BDACD4);
}
ISpace["UC_DOJ"].Visible="false";ISpace["UC_EmailId"].Visible="false";ISpace["UC_PhoneNumber"].Visible="false";ISpace["UC_DOB"].Visible="false";ISpace["UC_Grade"].Visible="false";ISpace["UC_DOR"].Visible="false";ISpace["UC_Paylevel"].Visible="false";
base.WriteDebugInfo(@"ISpace[""UC_DOJ""].Visible=""false"";ISpace[""UC_EmailId""].Visible=""false"";ISpace[""UC_PhoneNumber""].Visible=""false"";ISpace[""UC_DOB""].Visible=""false"";ISpace[""UC_Grade""].Visible=""false"";ISpace[""UC_DOR""].Visible=""false"";ISpace[""UC_Paylevel""].Visible=""false"";");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["MFG_T2_ModeofJourney"].Visible="true";ISpace["MFG_T2_Departure"].Visible="true";ISpace["MFG_T2_Road"].Visible="true";ISpace["MFG_T2_DepartureDate"].Visible="true";ISpace["MFG_T2_ArrivalDate"].Visible="true";ISpace["MF_T1_BudgetHead"].Visible="true";ISpace["MFG_T2_TravelAdvanceID"].Visible="false";ISpace["MF_T1_Destination"].Visible="true";ISpace["MFG_T2_Amount"].Visible="true";ISpace["MF_T1_AvailableBudget"].Visible="true";ISpace["MF_T1_JourneyPurpose"].Visible="true";ISpace["MFG_T2_PNRNo"].Visible="true";ISpace["MFG_T2_JourneyClass"].Visible="true";ISpace["MFG_T2_DepartureTime"].Visible="true";ISpace["MFG_T2_ToDate"].Visible="true";ISpace["MF_T1_AccountNo"].Visible="true";ISpace["MFG_T2_FromDate"].Visible="true";ISpace["MFG_T3_Amount"].Visible="true";ISpace["MFG_T3_TravelAdvanceID"].Visible="false";ISpace["MF_T1_TravelType"].Visible="true";ISpace["MF_T1_BankBranch"].Visible="true";ISpace["MF_T1_ProjectNo"].Visible="true";ISpace["MFG_T2_TADetailsID"].Visible="false";ISpace["MFG_T2_ArrivalTime"].Visible="true";ISpace["MF_T1_AdvanceAmount"].Visible="true";ISpace["MFG_T2_ExpenditureTypeID"].Visible="true";ISpace["MF_T1_TravellingPerson"].Visible="true";ISpace["MF_T1_BeneficiaryName"].Visible="true";ISpace["MF_T1_BankDocument"].Visible="true";ISpace["MF_T1_TravelAdvanceID"].Visible="false";ISpace["MF_T1_BankName"].Visible="true";ISpace["MFG_T2_Arrival"].Visible="true";ISpace["MF_T1_ReferenceNo"].Visible="true";
base.WriteDebugInfo(@"ISpace[""MFG_T2_ModeofJourney""].Visible=""true"";ISpace[""MFG_T2_Departure""].Visible=""true"";ISpace[""MFG_T2_Road""].Visible=""true"";ISpace[""MFG_T2_DepartureDate""].Visible=""true"";ISpace[""MFG_T2_ArrivalDate""].Visible=""true"";ISpace[""MF_T1_BudgetHead""].Visible=""true"";ISpace[""MFG_T2_TravelAdvanceID""].Visible=""false"";ISpace[""MF_T1_Destination""].Visible=""true"";ISpace[""MFG_T2_Amount""].Visible=""true"";ISpace[""MF_T1_AvailableBudget""].Visible=""true"";ISpace[""MF_T1_JourneyPurpose""].Visible=""true"";ISpace[""MFG_T2_PNRNo""].Visible=""true"";ISpace[""MFG_T2_JourneyClass""].Visible=""true"";ISpace[""MFG_T2_DepartureTime""].Visible=""true"";ISpace[""MFG_T2_ToDate""].Visible=""true"";ISpace[""MF_T1_AccountNo""].Visible=""true"";ISpace[""MFG_T2_FromDate""].Visible=""true"";ISpace[""MFG_T3_Amount""].Visible=""true"";ISpace[""MFG_T3_TravelAdvanceID""].Visible=""false"";ISpace[""MF_T1_TravelType""].Visible=""true"";ISpace[""MF_T1_BankBranch""].Visible=""true"";ISpace[""MF_T1_ProjectNo""].Visible=""true"";ISpace[""MFG_T2_TADetailsID""].Visible=""false"";ISpace[""MFG_T2_ArrivalTime""].Visible=""true"";ISpace[""MF_T1_AdvanceAmount""].Visible=""true"";ISpace[""MFG_T2_ExpenditureTypeID""].Visible=""true"";ISpace[""MF_T1_TravellingPerson""].Visible=""true"";ISpace[""MF_T1_BeneficiaryName""].Visible=""true"";ISpace[""MF_T1_BankDocument""].Visible=""true"";ISpace[""MF_T1_TravelAdvanceID""].Visible=""false"";ISpace[""MF_T1_BankName""].Visible=""true"";ISpace[""MFG_T2_Arrival""].Visible=""true"";ISpace[""MF_T1_ReferenceNo""].Visible=""true"";");
ISpace["MG_T2_Arrival"].Visible="true";ISpace["MG_T2_Road"].Visible="true";ISpace["MG_T2_TADetailsID"].Visible="false";ISpace["MG_T2_PNRNo"].Visible="true";ISpace["MG_T2_Departure"].Visible="true";ISpace["MG_T2_DepartureDate"].Visible="true";ISpace["MG_T2_ArrivalDate"].Visible="true";ISpace["MG_T3_TravelAdvanceID"].Visible="false";ISpace["MG_T2_DepartureTime"].Visible="true";ISpace["MG_T2_JourneyClass"].Visible="true";ISpace["MG_T2_ModeofJourney"].Visible="true";ISpace["MG_T2_ArrivalTime"].Visible="true";ISpace["MG_T2_Amount"].Visible="true";
base.WriteDebugInfo(@"ISpace[""MG_T2_Arrival""].Visible=""true"";ISpace[""MG_T2_Road""].Visible=""true"";ISpace[""MG_T2_TADetailsID""].Visible=""false"";ISpace[""MG_T2_PNRNo""].Visible=""true"";ISpace[""MG_T2_Departure""].Visible=""true"";ISpace[""MG_T2_DepartureDate""].Visible=""true"";ISpace[""MG_T2_ArrivalDate""].Visible=""true"";ISpace[""MG_T3_TravelAdvanceID""].Visible=""false"";ISpace[""MG_T2_DepartureTime""].Visible=""true"";ISpace[""MG_T2_JourneyClass""].Visible=""true"";ISpace[""MG_T2_ModeofJourney""].Visible=""true"";ISpace[""MG_T2_ArrivalTime""].Visible=""true"";ISpace[""MG_T2_Amount""].Visible=""true"";");
ISpace["MG_T3_Amount"].Visible="true";ISpace["MG_T2_ExpenditureTypeID"].Visible="true";ISpace["MG_T2_FromDate"].Visible="true";ISpace["MG_T2_ToDate"].Visible="true";ISpace["MG_T2_TravelAdvanceID"].Visible="false";
base.WriteDebugInfo(@"ISpace[""MG_T3_Amount""].Visible=""true"";ISpace[""MG_T2_ExpenditureTypeID""].Visible=""true"";ISpace[""MG_T2_FromDate""].Visible=""true"";ISpace[""MG_T2_ToDate""].Visible=""true"";ISpace[""MG_T2_TravelAdvanceID""].Visible=""false"";");
}
if(ISpace["Travel_Type"].Value=="1")
{
base.WriteDebugInfo(@"if(ISpace[""Travel_Type""].Value==""1"")");
ISpace["MF_T1_AccountNo"].Man=false;ISpace["MF_T1_BankBranch"].Man=false;ISpace["MF_T1_BeneficiaryName"].Man=false;ISpace["MF_T1_BankDocument"].Man=false;ISpace["MF_T1_BankName"].Man=false;
base.WriteDebugInfo(@"ISpace[""MF_T1_AccountNo""].Man=false;ISpace[""MF_T1_BankBranch""].Man=false;ISpace[""MF_T1_BeneficiaryName""].Man=false;ISpace[""MF_T1_BankDocument""].Man=false;ISpace[""MF_T1_BankName""].Man=false;");
}
if(ISpace["Travel_Type"].Value=="3")
{
base.WriteDebugInfo(@"if(ISpace[""Travel_Type""].Value==""3"")");
ISpace["MF_T1_AccountNo"].Man=true;ISpace["MF_T1_AccountNo"].Enbl="true";ISpace["MF_T1_BankBranch"].Man=true;ISpace["MF_T1_BankBranch"].Enbl="true";ISpace["MF_T1_AdvanceAmount"].Man=true;ISpace["MF_T1_AdvanceAmount"].Enbl="true";ISpace["MF_T1_BeneficiaryName"].Man=true;ISpace["MF_T1_BeneficiaryName"].Enbl="true";ISpace["MF_T1_BankDocument"].Man=true;ISpace["MF_T1_BankDocument"].Enbl="true";ISpace["MF_T1_BankName"].Man=true;ISpace["MF_T1_BankName"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_T1_AccountNo""].Man=true;ISpace[""MF_T1_AccountNo""].Enbl=""true"";ISpace[""MF_T1_BankBranch""].Man=true;ISpace[""MF_T1_BankBranch""].Enbl=""true"";ISpace[""MF_T1_AdvanceAmount""].Man=true;ISpace[""MF_T1_AdvanceAmount""].Enbl=""true"";ISpace[""MF_T1_BeneficiaryName""].Man=true;ISpace[""MF_T1_BeneficiaryName""].Enbl=""true"";ISpace[""MF_T1_BankDocument""].Man=true;ISpace[""MF_T1_BankDocument""].Enbl=""true"";ISpace[""MF_T1_BankName""].Man=true;ISpace[""MF_T1_BankName""].Enbl=""true"";");
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
return;
base.WriteDebugInfo(@"return;");
}
ISpace["MF_TravelStatus"].Value="A";
base.WriteDebugInfo(@"ISpace[""MF_TravelStatus""].Value=""A"";");
ISpace["M_IsCommitment"].Value=0;
base.WriteDebugInfo(@"ISpace[""M_IsCommitment""].Value=0;");
if(ISpace["M_SaveDomainData"].Value==1||1==1)
{
base.WriteDebugInfo(@"if(ISpace[""M_SaveDomainData""].Value==1||1==1)");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC Repo198E5A8A61F54E7C92DD34146A7059EF '#CreatedOn','#MF_T1_BankDocument','#MF_T1_ReferenceNo','#MF_T1_AccountNo','#OverAll_Total','#UC_EmployeeBaicInfoId','#M_TravelPlace','#MF_T1_AdvanceAmount','#MF_T1_BankName','#MF_T1_TravelAdvanceID','#MF_T1_JourneyPurpose','#Travel_Type','#MF_T1_BeneficiaryName','#gv_UserId','#MF_TransactionNo','#MF_TravelStatus','#MF_TransactionDate','#M_IsAdvanceRequired'");

var querySourceD16F9C83EA714542AB4DE3D99AB969B2 =GetQueryExpressionDataSource("D16F9C83-EA71-4542-AB4D-E3D99AB969B2");
Dictionary<short,object> resultD16F9C83EA714542AB4DE3D99AB969B2=iSpace.ExecuteQuery(querySourceD16F9C83EA714542AB4DE3D99AB969B2,@"EXEC Repo198E5A8A61F54E7C92DD34146A7059EF '" + ISpace["CreatedOn"].Value + @"','" + ISpace["MF_T1_BankDocument"].Value + @"','" + ISpace["MF_T1_ReferenceNo"].Value + @"','" + ISpace["MF_T1_AccountNo"].Value + @"','" + ISpace["OverAll_Total"].Value + @"','" + ISpace["UC_EmployeeBaicInfoId"].Value + @"','" + ISpace["M_TravelPlace"].Value + @"','" + ISpace["MF_T1_AdvanceAmount"].Value + @"','" + ISpace["MF_T1_BankName"].Value + @"','" + ISpace["MF_T1_TravelAdvanceID"].Value + @"','" + ISpace["MF_T1_JourneyPurpose"].Value + @"','" + ISpace["Travel_Type"].Value + @"','" + ISpace["MF_T1_BeneficiaryName"].Value + @"','" + ISpace["gv_UserId"].Value + @"','" + ISpace["MF_TransactionNo"].Value + @"','" + ISpace["MF_TravelStatus"].Value + @"','" + ISpace["MF_TransactionDate"].Value + @"','" + ISpace["M_IsAdvanceRequired"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceD16F9C83EA714542AB4DE3D99AB969B2 =GetQueryExpressionDataSource(""D16F9C83-EA71-4542-AB4D-E3D99AB969B2"");Dictionary<short,object> resultD16F9C83EA714542AB4DE3D99AB969B2=iSpace.ExecuteQuery(querySourceD16F9C83EA714542AB4DE3D99AB969B2,@""EXEC Repo198E5A8A61F54E7C92DD34146A7059EF '"" + ISpace[""CreatedOn""].Value + @""','"" + ISpace[""MF_T1_BankDocument""].Value + @""','"" + ISpace[""MF_T1_ReferenceNo""].Value + @""','"" + ISpace[""MF_T1_AccountNo""].Value + @""','"" + ISpace[""OverAll_Total""].Value + @""','"" + ISpace[""UC_EmployeeBaicInfoId""].Value + @""','"" + ISpace[""M_TravelPlace""].Value + @""','"" + ISpace[""MF_T1_AdvanceAmount""].Value + @""','"" + ISpace[""MF_T1_BankName""].Value + @""','"" + ISpace[""MF_T1_TravelAdvanceID""].Value + @""','"" + ISpace[""MF_T1_JourneyPurpose""].Value + @""','"" + ISpace[""Travel_Type""].Value + @""','"" + ISpace[""MF_T1_BeneficiaryName""].Value + @""','"" + ISpace[""gv_UserId""].Value + @""','"" + ISpace[""MF_TransactionNo""].Value + @""','"" + ISpace[""MF_TravelStatus""].Value + @""','"" + ISpace[""MF_TransactionDate""].Value + @""','"" + ISpace[""M_IsAdvanceRequired""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultD16F9C83EA714542AB4DE3D99AB969B2!=null) && (resultD16F9C83EA714542AB4DE3D99AB969B2.Count!=0))
{
}
else{

}
base.WriteDebugInfo(@"EXEC Repo51838b372ec64d358a5e38648bc93ab1 '#gv_UserId','#UpdatedOn','#MF_T1_TravelAdvanceID','#MG_T2_ToDate','#MG_T2_FromDate','#M_IsTravelRequest','#MG_T2_ExpenditureTypeID','#Expenditure_Type','#MG_T3_Amount'");

var querySource864963C6427C451F8C30D7E8FCDD4228 =GetQueryExpressionDataSource("864963C6-427C-451F-8C30-D7E8FCDD4228");
Dictionary<short,object> result864963C6427C451F8C30D7E8FCDD4228=iSpace.ExecuteQuery(querySource864963C6427C451F8C30D7E8FCDD4228,@"EXEC Repo51838b372ec64d358a5e38648bc93ab1 '" + ISpace["gv_UserId"].Value + @"','" + ISpace["UpdatedOn"].Value + @"','" + ISpace["MF_T1_TravelAdvanceID"].Value + @"','" + ISpace["MG_T2_ToDate"].Value + @"','" + ISpace["MG_T2_FromDate"].Value + @"','" + ISpace["M_IsTravelRequest"].Value + @"','" + ISpace["MG_T2_ExpenditureTypeID"].Value + @"','" + ISpace["Expenditure_Type"].Value + @"','" + ISpace["MG_T3_Amount"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource864963C6427C451F8C30D7E8FCDD4228 =GetQueryExpressionDataSource(""864963C6-427C-451F-8C30-D7E8FCDD4228"");Dictionary<short,object> result864963C6427C451F8C30D7E8FCDD4228=iSpace.ExecuteQuery(querySource864963C6427C451F8C30D7E8FCDD4228,@""EXEC Repo51838b372ec64d358a5e38648bc93ab1 '"" + ISpace[""gv_UserId""].Value + @""','"" + ISpace[""UpdatedOn""].Value + @""','"" + ISpace[""MF_T1_TravelAdvanceID""].Value + @""','"" + ISpace[""MG_T2_ToDate""].Value + @""','"" + ISpace[""MG_T2_FromDate""].Value + @""','"" + ISpace[""M_IsTravelRequest""].Value + @""','"" + ISpace[""MG_T2_ExpenditureTypeID""].Value + @""','"" + ISpace[""Expenditure_Type""].Value + @""','"" + ISpace[""MG_T3_Amount""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result864963C6427C451F8C30D7E8FCDD4228!=null) && (result864963C6427C451F8C30D7E8FCDD4228.Count!=0))
{
}
else{

}
base.WriteDebugInfo(@"EXEC Repo374fb8a88dd94cf1bf73f40ae18fcad7 '#M_IsTravelRequest','#UpdatedOn','#MG_T2_TADetailsID','#gv_UserId','#MG_T2_DepartureDate','#MG_T2_DepartureTime','#MG_T2_ArrivalDate','#MG_T2_Road','#MF_T1_TravelAdvanceID','#MG_T2_Departure','#MG_T2_Amount','#MG_T2_JourneyClass','#MG_T2_Arrival','#MG_T2_PNRNo','#MG_T2_ModeofJourney','#MG_T2_ArrivalTime'");

var querySourceEBE446FD1D9E41DEB663DEAA6EE73345 =GetQueryExpressionDataSource("EBE446FD-1D9E-41DE-B663-DEAA6EE73345");
Dictionary<short,object> resultEBE446FD1D9E41DEB663DEAA6EE73345=iSpace.ExecuteQuery(querySourceEBE446FD1D9E41DEB663DEAA6EE73345,@"EXEC Repo374fb8a88dd94cf1bf73f40ae18fcad7 '" + ISpace["M_IsTravelRequest"].Value + @"','" + ISpace["UpdatedOn"].Value + @"','" + ISpace["MG_T2_TADetailsID"].Value + @"','" + ISpace["gv_UserId"].Value + @"','" + ISpace["MG_T2_DepartureDate"].Value + @"','" + ISpace["MG_T2_DepartureTime"].Value + @"','" + ISpace["MG_T2_ArrivalDate"].Value + @"','" + ISpace["MG_T2_Road"].Value + @"','" + ISpace["MF_T1_TravelAdvanceID"].Value + @"','" + ISpace["MG_T2_Departure"].Value + @"','" + ISpace["MG_T2_Amount"].Value + @"','" + ISpace["MG_T2_JourneyClass"].Value + @"','" + ISpace["MG_T2_Arrival"].Value + @"','" + ISpace["MG_T2_PNRNo"].Value + @"','" + ISpace["MG_T2_ModeofJourney"].Value + @"','" + ISpace["MG_T2_ArrivalTime"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceEBE446FD1D9E41DEB663DEAA6EE73345 =GetQueryExpressionDataSource(""EBE446FD-1D9E-41DE-B663-DEAA6EE73345"");Dictionary<short,object> resultEBE446FD1D9E41DEB663DEAA6EE73345=iSpace.ExecuteQuery(querySourceEBE446FD1D9E41DEB663DEAA6EE73345,@""EXEC Repo374fb8a88dd94cf1bf73f40ae18fcad7 '"" + ISpace[""M_IsTravelRequest""].Value + @""','"" + ISpace[""UpdatedOn""].Value + @""','"" + ISpace[""MG_T2_TADetailsID""].Value + @""','"" + ISpace[""gv_UserId""].Value + @""','"" + ISpace[""MG_T2_DepartureDate""].Value + @""','"" + ISpace[""MG_T2_DepartureTime""].Value + @""','"" + ISpace[""MG_T2_ArrivalDate""].Value + @""','"" + ISpace[""MG_T2_Road""].Value + @""','"" + ISpace[""MF_T1_TravelAdvanceID""].Value + @""','"" + ISpace[""MG_T2_Departure""].Value + @""','"" + ISpace[""MG_T2_Amount""].Value + @""','"" + ISpace[""MG_T2_JourneyClass""].Value + @""','"" + ISpace[""MG_T2_Arrival""].Value + @""','"" + ISpace[""MG_T2_PNRNo""].Value + @""','"" + ISpace[""MG_T2_ModeofJourney""].Value + @""','"" + ISpace[""MG_T2_ArrivalTime""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultEBE446FD1D9E41DEB663DEAA6EE73345!=null) && (resultEBE446FD1D9E41DEB663DEAA6EE73345.Count!=0))
{
}
else{

}
base.WriteDebugInfo(@"EXEC DocumentsDomain '#M_DocumentDetailsId','#M_PackageProcessMapId','#UpdatedOn','#M_DocumentName','#gv_UserId','#M_UploadDcoument','#MF_T1_TravelAdvanceID'");

var querySource1D2378FB2963489899022B61F44BE0AD =GetQueryExpressionDataSource("1D2378FB-2963-4898-9902-2B61F44BE0AD");
Dictionary<short,object> result1D2378FB2963489899022B61F44BE0AD=iSpace.ExecuteQuery(querySource1D2378FB2963489899022B61F44BE0AD,@"EXEC DocumentsDomain '" + ISpace["M_DocumentDetailsId"].Value + @"','" + ISpace["M_PackageProcessMapId"].Value + @"','" + ISpace["UpdatedOn"].Value + @"','" + ISpace["M_DocumentName"].Value + @"','" + ISpace["gv_UserId"].Value + @"','" + ISpace["M_UploadDcoument"].Value + @"','" + ISpace["MF_T1_TravelAdvanceID"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource1D2378FB2963489899022B61F44BE0AD =GetQueryExpressionDataSource(""1D2378FB-2963-4898-9902-2B61F44BE0AD"");Dictionary<short,object> result1D2378FB2963489899022B61F44BE0AD=iSpace.ExecuteQuery(querySource1D2378FB2963489899022B61F44BE0AD,@""EXEC DocumentsDomain '"" + ISpace[""M_DocumentDetailsId""].Value + @""','"" + ISpace[""M_PackageProcessMapId""].Value + @""','"" + ISpace[""UpdatedOn""].Value + @""','"" + ISpace[""M_DocumentName""].Value + @""','"" + ISpace[""gv_UserId""].Value + @""','"" + ISpace[""M_UploadDcoument""].Value + @""','"" + ISpace[""MF_T1_TravelAdvanceID""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result1D2378FB2963489899022B61F44BE0AD!=null) && (result1D2378FB2963489899022B61F44BE0AD.Count!=0))
{
}
else{

}
base.WriteDebugInfo(@"#MF_FundAmount[rows]");
iSpace.GetLoopExpressionData("MF_FundAmount",ref ISpace);

foreach(var gridChild in ISpace["MF_FundAmount"].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 


if(
ISpace["MG_FundTypeId"].Value==1)
{
base.WriteDebugInfo(@"
if(
ISpace[""MG_FundTypeId""].Value==1)");
base.WriteDebugInfo(@"EXEC ProjectApprovalCommittmentDetails '#MG_Amount','#MF_T1_TravelAdvanceID','#MG_ProjectDetailsId','#MG_BudgetHead','#gv_ProcessMapId'");

var querySource4213CFEEA88E4B67BEECB0AEF4337465 =GetQueryExpressionDataSource("4213CFEE-A88E-4B67-BEEC-B0AEF4337465");
Dictionary<short,object> result4213CFEEA88E4B67BEECB0AEF4337465=iSpace.ExecuteQuery(querySource4213CFEEA88E4B67BEECB0AEF4337465,@"EXEC ProjectApprovalCommittmentDetails '" + ISpace["MG_Amount"].Value + @"','" + ISpace["MF_T1_TravelAdvanceID"].Value + @"','" + ISpace["MG_ProjectDetailsId"].Value + @"','" + ISpace["MG_BudgetHead"].Value + @"','" + ISpace["gv_ProcessMapId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource4213CFEEA88E4B67BEECB0AEF4337465 =GetQueryExpressionDataSource(""4213CFEE-A88E-4B67-BEEC-B0AEF4337465"");Dictionary<short,object> result4213CFEEA88E4B67BEECB0AEF4337465=iSpace.ExecuteQuery(querySource4213CFEEA88E4B67BEECB0AEF4337465,@""EXEC ProjectApprovalCommittmentDetails '"" + ISpace[""MG_Amount""].Value + @""','"" + ISpace[""MF_T1_TravelAdvanceID""].Value + @""','"" + ISpace[""MG_ProjectDetailsId""].Value + @""','"" + ISpace[""MG_BudgetHead""].Value + @""','"" + ISpace[""gv_ProcessMapId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result4213CFEEA88E4B67BEECB0AEF4337465!=null) && (result4213CFEEA88E4B67BEECB0AEF4337465.Count!=0))
{
}
else{

}
}
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("MF_FundAmount","AD9C54EC-27A0-4C21-9923-063084E3B588",_objectFactory.GetGridRPP("MF_FundAmount"),_elementBase.GetGridLoopQuery("AD9C54EC-27A0-4C21-9923-063084E3B588","MF_FundAmount",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""MF_FundAmount"",ref ISpace);

foreach(var gridChild in ISpace[""MF_FundAmount""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
}
if(1==2)
{
base.WriteDebugInfo(@"if(1==2)");
base.WriteDebugInfo(@"#MF_FundAmount[Rows]");
iSpace.GetLoopExpressionData("MF_FundAmount",ref ISpace);

foreach(var gridChild in ISpace["MF_FundAmount"].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 

base.WriteDebugInfo(@"EXEC UpsertProjectBudgetDetails 5,'#MG_ProjectDetailsId','#MF_T1_TravelAdvanceID','#MG_Amount','#MG_BudgetHead','1','#MG_FundTypeid','#M_PackageProcessMapId','#UC_EmployeeBaicInfoId'");

var querySourceEA86EC989465469D97F236E0D8B7BEB7 =GetQueryExpressionDataSource("EA86EC98-9465-469D-97F2-36E0D8B7BEB7");
Dictionary<short,object> resultEA86EC989465469D97F236E0D8B7BEB7=iSpace.ExecuteQuery(querySourceEA86EC989465469D97F236E0D8B7BEB7,@"EXEC UpsertProjectBudgetDetails 5,'" + ISpace["MG_ProjectDetailsId"].Value + @"','" + ISpace["MF_T1_TravelAdvanceID"].Value + @"','" + ISpace["MG_Amount"].Value + @"','" + ISpace["MG_BudgetHead"].Value + @"','1','" + ISpace["MG_FundTypeid"].Value + @"','" + ISpace["M_PackageProcessMapId"].Value + @"','" + ISpace["UC_EmployeeBaicInfoId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceEA86EC989465469D97F236E0D8B7BEB7 =GetQueryExpressionDataSource(""EA86EC98-9465-469D-97F2-36E0D8B7BEB7"");Dictionary<short,object> resultEA86EC989465469D97F236E0D8B7BEB7=iSpace.ExecuteQuery(querySourceEA86EC989465469D97F236E0D8B7BEB7,@""EXEC UpsertProjectBudgetDetails 5,'"" + ISpace[""MG_ProjectDetailsId""].Value + @""','"" + ISpace[""MF_T1_TravelAdvanceID""].Value + @""','"" + ISpace[""MG_Amount""].Value + @""','"" + ISpace[""MG_BudgetHead""].Value + @""','1','"" + ISpace[""MG_FundTypeid""].Value + @""','"" + ISpace[""M_PackageProcessMapId""].Value + @""','"" + ISpace[""UC_EmployeeBaicInfoId""].Value + @""'"",false);");
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("MF_FundAmount","AD9C54EC-27A0-4C21-9923-063084E3B588",_objectFactory.GetGridRPP("MF_FundAmount"),_elementBase.GetGridLoopQuery("AD9C54EC-27A0-4C21-9923-063084E3B588","MF_FundAmount",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""MF_FundAmount"",ref ISpace);

foreach(var gridChild in ISpace[""MF_FundAmount""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
}
}
if(ISpace["M_SaveDomainData"].Value==0&&ISpace["M_IsflowReturned"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""M_SaveDomainData""].Value==0&&ISpace[""M_IsflowReturned""].Value==1)");
base.WriteDebugInfo(@"exec [SendReturnEmailForTR] '#MF_T1_TravelAdvanceID'");

var querySourceDE33E12BFBC142E094A9B51B2789A1AE =GetQueryExpressionDataSource("DE33E12B-FBC1-42E0-94A9-B51B2789A1AE");
Dictionary<short,object> resultDE33E12BFBC142E094A9B51B2789A1AE=iSpace.ExecuteQuery(querySourceDE33E12BFBC142E094A9B51B2789A1AE,@"exec [SendReturnEmailForTR] '" + ISpace["MF_T1_TravelAdvanceID"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceDE33E12BFBC142E094A9B51B2789A1AE =GetQueryExpressionDataSource(""DE33E12B-FBC1-42E0-94A9-B51B2789A1AE"");Dictionary<short,object> resultDE33E12BFBC142E094A9B51B2789A1AE=iSpace.ExecuteQuery(querySourceDE33E12BFBC142E094A9B51B2789A1AE,@""exec [SendReturnEmailForTR] '"" + ISpace[""MF_T1_TravelAdvanceID""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultDE33E12BFBC142E094A9B51B2789A1AE!=null) && (resultDE33E12BFBC142E094A9B51B2789A1AE.Count!=0))
{
if(resultDE33E12BFBC142E094A9B51B2789A1AE.ContainsKey(0))
ISpace["A"].Value = resultDE33E12BFBC142E094A9B51B2789A1AE[0];
}
else{
ISpace["A"].Value = null;
}
}
if(ISpace["M_SaveDomainData"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""M_SaveDomainData""].Value==1)");
base.WriteDebugInfo(@"exec SendApproveEmailForTR '#MF_T1_TravelAdvanceID'");

var querySourceDD228B607D714F6690FD26F71FC14E4E =GetQueryExpressionDataSource("DD228B60-7D71-4F66-90FD-26F71FC14E4E");
Dictionary<short,object> resultDD228B607D714F6690FD26F71FC14E4E=iSpace.ExecuteQuery(querySourceDD228B607D714F6690FD26F71FC14E4E,@"execSendApproveEmailForTR '" + ISpace["MF_T1_TravelAdvanceID"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceDD228B607D714F6690FD26F71FC14E4E =GetQueryExpressionDataSource(""DD228B60-7D71-4F66-90FD-26F71FC14E4E"");Dictionary<short,object> resultDD228B607D714F6690FD26F71FC14E4E=iSpace.ExecuteQuery(querySourceDD228B607D714F6690FD26F71FC14E4E,@""execSendApproveEmailForTR '"" + ISpace[""MF_T1_TravelAdvanceID""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultDD228B607D714F6690FD26F71FC14E4E!=null) && (resultDD228B607D714F6690FD26F71FC14E4E.Count!=0))
{
if(resultDD228B607D714F6690FD26F71FC14E4E.ContainsKey(0))
ISpace["A"].Value = resultDD228B607D714F6690FD26F71FC14E4E[0];
}
else{
ISpace["A"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
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

base.WriteDebugInfo(@"EXEC UpsertProjectBudgetDetails 6,'#MG_ProjectDetailsId','#MF_T1_TravelAdvanceID','#MG_Amount','#MG_BudgetHead','1','#MG_FundTypeid','#M_PackageProcessMapId','#UC_EmployeeBaicInfoId'");

var querySource579419E790FA4F5A847AADEFF8FBD8C9 =GetQueryExpressionDataSource("579419E7-90FA-4F5A-847A-ADEFF8FBD8C9");
Dictionary<short,object> result579419E790FA4F5A847AADEFF8FBD8C9=iSpace.ExecuteQuery(querySource579419E790FA4F5A847AADEFF8FBD8C9,@"EXEC UpsertProjectBudgetDetails 6,'" + ISpace["MG_ProjectDetailsId"].Value + @"','" + ISpace["MF_T1_TravelAdvanceID"].Value + @"','" + ISpace["MG_Amount"].Value + @"','" + ISpace["MG_BudgetHead"].Value + @"','1','" + ISpace["MG_FundTypeid"].Value + @"','" + ISpace["M_PackageProcessMapId"].Value + @"','" + ISpace["UC_EmployeeBaicInfoId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource579419E790FA4F5A847AADEFF8FBD8C9 =GetQueryExpressionDataSource(""579419E7-90FA-4F5A-847A-ADEFF8FBD8C9"");Dictionary<short,object> result579419E790FA4F5A847AADEFF8FBD8C9=iSpace.ExecuteQuery(querySource579419E790FA4F5A847AADEFF8FBD8C9,@""EXEC UpsertProjectBudgetDetails 6,'"" + ISpace[""MG_ProjectDetailsId""].Value + @""','"" + ISpace[""MF_T1_TravelAdvanceID""].Value + @""','"" + ISpace[""MG_Amount""].Value + @""','"" + ISpace[""MG_BudgetHead""].Value + @""','1','"" + ISpace[""MG_FundTypeid""].Value + @""','"" + ISpace[""M_PackageProcessMapId""].Value + @""','"" + ISpace[""UC_EmployeeBaicInfoId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result579419E790FA4F5A847AADEFF8FBD8C9!=null) && (result579419E790FA4F5A847AADEFF8FBD8C9.Count!=0))
{
if(result579419E790FA4F5A847AADEFF8FBD8C9.ContainsKey(0))
ISpace["A"].Value = result579419E790FA4F5A847AADEFF8FBD8C9[0];
}
else{
ISpace["A"].Value = null;
}
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("MF_FundAmount","AD9C54EC-27A0-4C21-9923-063084E3B588",_objectFactory.GetGridRPP("MF_FundAmount"),_elementBase.GetGridLoopQuery("AD9C54EC-27A0-4C21-9923-063084E3B588","MF_FundAmount",ISpace), ref ISpace);
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
ISpace["Message"].Value=@"Submitted Successfully";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Submitted Successfully"";");
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

var querySourceD659A8A182614852878E8F0B73B79721 =GetQueryExpressionDataSource("D659A8A1-8261-4852-878E-8F0B73B79721");

DataTable resultD659A8A182614852878E8F0B73B79721=iSpace.SetGridDataSource(querySourceD659A8A182614852878E8F0B73B79721, _objectFactory.GetGridRPP("TravelExpense"),@"EXEC AddFormGridData374fb8a88dd94cf1bf73f40ae18fcad7 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["MFG_T2_TADetailsID"].Value + @"','" + ISpace["MFG_T2_TravelAdvanceID"].Value + @"','" + ISpace["MFG_T2_Departure"].Value + @"','" + ISpace["MFG_T2_DepartureDate"].Value + @"','" + ISpace["MFG_T2_DepartureTime"].Value + @"','" + ISpace["MFG_T2_Arrival"].Value + @"','" + ISpace["MFG_T2_ArrivalDate"].Value + @"','" + ISpace["MFG_T2_ArrivalTime"].Value + @"','" + ISpace["MFG_T2_ModeofJourney"].Value + @"','" + ISpace["MFG_T2_JourneyClass"].Value + @"'," + ISpace["MFG_T2_Road"].Value + @",'" + ISpace["MFG_T2_PNRNo"].Value + @"'," + ISpace["MFG_T2_Amount"].Value + @",'" + ISpace["growid"].Value + @"'");

iSpace.InsertGridBindDetails("TravelExpense","11",querySourceD659A8A182614852878E8F0B73B79721,"EXEC AddFormGridData374fb8a88dd94cf1bf73f40ae18fcad7 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["MFG_T2_TADetailsID"].Value + @"','" + ISpace["MFG_T2_TravelAdvanceID"].Value + @"','" + ISpace["MFG_T2_Departure"].Value + @"','" + ISpace["MFG_T2_DepartureDate"].Value + @"','" + ISpace["MFG_T2_DepartureTime"].Value + @"','" + ISpace["MFG_T2_Arrival"].Value + @"','" + ISpace["MFG_T2_ArrivalDate"].Value + @"','" + ISpace["MFG_T2_ArrivalTime"].Value + @"','" + ISpace["MFG_T2_ModeofJourney"].Value + @"','" + ISpace["MFG_T2_JourneyClass"].Value + @"'," + ISpace["MFG_T2_Road"].Value + @",'" + ISpace["MFG_T2_PNRNo"].Value + @"'," + ISpace["MFG_T2_Amount"].Value + @",'" + ISpace["growid"].Value + @"'",_objectFactory.GetGridRPP("TravelExpense"));

base.WriteDebugInfo(@"var querySourceD659A8A182614852878E8F0B73B79721 =GetQueryExpressionDataSource(""D659A8A1-8261-4852-878E-8F0B73B79721"");DataTable resultD659A8A182614852878E8F0B73B79721=iSpace.SetGridDataSource(querySourceD659A8A182614852878E8F0B73B79721, _objectFactory.GetGridRPP(""TravelExpense""),@""EXEC AddFormGridData374fb8a88dd94cf1bf73f40ae18fcad7 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""MFG_T2_TADetailsID""].Value + @""','"" + ISpace[""MFG_T2_TravelAdvanceID""].Value + @""','"" + ISpace[""MFG_T2_Departure""].Value + @""','"" + ISpace[""MFG_T2_DepartureDate""].Value + @""','"" + ISpace[""MFG_T2_DepartureTime""].Value + @""','"" + ISpace[""MFG_T2_Arrival""].Value + @""','"" + ISpace[""MFG_T2_ArrivalDate""].Value + @""','"" + ISpace[""MFG_T2_ArrivalTime""].Value + @""','"" + ISpace[""MFG_T2_ModeofJourney""].Value + @""','"" + ISpace[""MFG_T2_JourneyClass""].Value + @""',"" + ISpace[""MFG_T2_Road""].Value + @"",'"" + ISpace[""MFG_T2_PNRNo""].Value + @""',"" + ISpace[""MFG_T2_Amount""].Value + @"",'"" + ISpace[""growid""].Value + @""'"");iSpace.InsertGridBindDetails(""TravelExpense"",""11"",querySourceD659A8A182614852878E8F0B73B79721,""EXEC AddFormGridData374fb8a88dd94cf1bf73f40ae18fcad7 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""MFG_T2_TADetailsID""].Value + @""','"" + ISpace[""MFG_T2_TravelAdvanceID""].Value + @""','"" + ISpace[""MFG_T2_Departure""].Value + @""','"" + ISpace[""MFG_T2_DepartureDate""].Value + @""','"" + ISpace[""MFG_T2_DepartureTime""].Value + @""','"" + ISpace[""MFG_T2_Arrival""].Value + @""','"" + ISpace[""MFG_T2_ArrivalDate""].Value + @""','"" + ISpace[""MFG_T2_ArrivalTime""].Value + @""','"" + ISpace[""MFG_T2_ModeofJourney""].Value + @""','"" + ISpace[""MFG_T2_JourneyClass""].Value + @""',"" + ISpace[""MFG_T2_Road""].Value + @"",'"" + ISpace[""MFG_T2_PNRNo""].Value + @""',"" + ISpace[""MFG_T2_Amount""].Value + @"",'"" + ISpace[""growid""].Value + @""'"",_objectFactory.GetGridRPP(""TravelExpense""));");
base.WriteDebugInfo(@"EXEC AddFormGridData374fb8a88dd94cf1bf73f40ae18fcad7 '@@gv_InstanceId','@@gv_ProcessMapId','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','@@gv_ActivityMapId','#MFG_T2_TADetailsID','#MFG_T2_TravelAdvanceID','#MFG_T2_Departure','#MFG_T2_DepartureDate','#MFG_T2_DepartureTime','#MFG_T2_Arrival','#MFG_T2_ArrivalDate','#MFG_T2_ArrivalTime','#MFG_T2_ModeofJourney','#MFG_T2_JourneyClass',#MFG_T2_Road,'#MFG_T2_PNRNo',#MFG_T3_Amount,'#growid'");


List<Triplet<string, short, short?>> result8F99128D9EF74BCF8A425714C2D6D166=acdataIspaceCE310762909A4A90A266630580753EC6.GetQueryExpressionBindings("8F99128D-9EF7-4BCF-8A42-5714C2D6D166");
iSpace.SetGridData(resultD659A8A182614852878E8F0B73B79721,result8F99128D9EF74BCF8A425714C2D6D166,"TravelExpense",ref ISpace);
iSpace.UpdateGridBindDetails("TravelExpense",result8F99128D9EF74BCF8A425714C2D6D166);
}
else
{
base.WriteDebugInfo(@"else");

var querySourceAFBC2448576140CFA8EB1C60C3DC33D1 =GetQueryExpressionDataSource("AFBC2448-5761-40CF-A8EB-1C60C3DC33D1");

DataTable resultAFBC2448576140CFA8EB1C60C3DC33D1=iSpace.SetGridDataSource(querySourceAFBC2448576140CFA8EB1C60C3DC33D1, _objectFactory.GetGridRPP("TravelExpense"),@"EXEC UpdateFormGridData374fb8a88dd94cf1bf73f40ae18fcad7 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["MFG_T2_TADetailsID"].Value + @"','" + ISpace["MFG_T2_TravelAdvanceID"].Value + @"','" + ISpace["MFG_T2_Departure"].Value + @"','" + ISpace["MFG_T2_DepartureDate"].Value + @"','" + ISpace["MFG_T2_DepartureTime"].Value + @"','" + ISpace["MFG_T2_Arrival"].Value + @"','" + ISpace["MFG_T2_ArrivalDate"].Value + @"','" + ISpace["MFG_T2_ArrivalTime"].Value + @"','" + ISpace["MFG_T2_ModeofJourney"].Value + @"','" + ISpace["MFG_T2_JourneyClass"].Value + @"'," + ISpace["MFG_T2_Road"].Value + @",'" + ISpace["MFG_T2_PNRNo"].Value + @"'," + ISpace["MFG_T2_Amount"].Value + @",'" + ISpace["growid"].Value + @"'");

iSpace.InsertGridBindDetails("TravelExpense","11",querySourceAFBC2448576140CFA8EB1C60C3DC33D1,"EXEC UpdateFormGridData374fb8a88dd94cf1bf73f40ae18fcad7 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["MFG_T2_TADetailsID"].Value + @"','" + ISpace["MFG_T2_TravelAdvanceID"].Value + @"','" + ISpace["MFG_T2_Departure"].Value + @"','" + ISpace["MFG_T2_DepartureDate"].Value + @"','" + ISpace["MFG_T2_DepartureTime"].Value + @"','" + ISpace["MFG_T2_Arrival"].Value + @"','" + ISpace["MFG_T2_ArrivalDate"].Value + @"','" + ISpace["MFG_T2_ArrivalTime"].Value + @"','" + ISpace["MFG_T2_ModeofJourney"].Value + @"','" + ISpace["MFG_T2_JourneyClass"].Value + @"'," + ISpace["MFG_T2_Road"].Value + @",'" + ISpace["MFG_T2_PNRNo"].Value + @"'," + ISpace["MFG_T2_Amount"].Value + @",'" + ISpace["growid"].Value + @"'",_objectFactory.GetGridRPP("TravelExpense"));

base.WriteDebugInfo(@"var querySourceAFBC2448576140CFA8EB1C60C3DC33D1 =GetQueryExpressionDataSource(""AFBC2448-5761-40CF-A8EB-1C60C3DC33D1"");DataTable resultAFBC2448576140CFA8EB1C60C3DC33D1=iSpace.SetGridDataSource(querySourceAFBC2448576140CFA8EB1C60C3DC33D1, _objectFactory.GetGridRPP(""TravelExpense""),@""EXEC UpdateFormGridData374fb8a88dd94cf1bf73f40ae18fcad7 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""MFG_T2_TADetailsID""].Value + @""','"" + ISpace[""MFG_T2_TravelAdvanceID""].Value + @""','"" + ISpace[""MFG_T2_Departure""].Value + @""','"" + ISpace[""MFG_T2_DepartureDate""].Value + @""','"" + ISpace[""MFG_T2_DepartureTime""].Value + @""','"" + ISpace[""MFG_T2_Arrival""].Value + @""','"" + ISpace[""MFG_T2_ArrivalDate""].Value + @""','"" + ISpace[""MFG_T2_ArrivalTime""].Value + @""','"" + ISpace[""MFG_T2_ModeofJourney""].Value + @""','"" + ISpace[""MFG_T2_JourneyClass""].Value + @""',"" + ISpace[""MFG_T2_Road""].Value + @"",'"" + ISpace[""MFG_T2_PNRNo""].Value + @""',"" + ISpace[""MFG_T2_Amount""].Value + @"",'"" + ISpace[""growid""].Value + @""'"");iSpace.InsertGridBindDetails(""TravelExpense"",""11"",querySourceAFBC2448576140CFA8EB1C60C3DC33D1,""EXEC UpdateFormGridData374fb8a88dd94cf1bf73f40ae18fcad7 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""MFG_T2_TADetailsID""].Value + @""','"" + ISpace[""MFG_T2_TravelAdvanceID""].Value + @""','"" + ISpace[""MFG_T2_Departure""].Value + @""','"" + ISpace[""MFG_T2_DepartureDate""].Value + @""','"" + ISpace[""MFG_T2_DepartureTime""].Value + @""','"" + ISpace[""MFG_T2_Arrival""].Value + @""','"" + ISpace[""MFG_T2_ArrivalDate""].Value + @""','"" + ISpace[""MFG_T2_ArrivalTime""].Value + @""','"" + ISpace[""MFG_T2_ModeofJourney""].Value + @""','"" + ISpace[""MFG_T2_JourneyClass""].Value + @""',"" + ISpace[""MFG_T2_Road""].Value + @"",'"" + ISpace[""MFG_T2_PNRNo""].Value + @""',"" + ISpace[""MFG_T2_Amount""].Value + @"",'"" + ISpace[""growid""].Value + @""'"",_objectFactory.GetGridRPP(""TravelExpense""));");
base.WriteDebugInfo(@"EXEC UpdateFormGridData374fb8a88dd94cf1bf73f40ae18fcad7 '@@gv_InstanceId','@@gv_ProcessMapId','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','@@gv_ActivityMapId','#MFG_T2_TADetailsID','#MFG_T2_TravelAdvanceID','#MFG_T2_Departure','#MFG_T2_DepartureDate','#MFG_T2_DepartureTime','#MFG_T2_Arrival','#MFG_T2_ArrivalDate','#MFG_T2_ArrivalTime','#MFG_T2_ModeofJourney','#MFG_T2_JourneyClass',#MFG_T2_Road,'#MFG_T2_PNRNo',#MFG_T3_Amount,'#growid'");


List<Triplet<string, short, short?>> result49C758C3CB9E452A80535E2651156E3D=acdataIspaceCE310762909A4A90A266630580753EC6.GetQueryExpressionBindings("49C758C3-CB9E-452A-8053-5E2651156E3D");
iSpace.SetGridData(resultAFBC2448576140CFA8EB1C60C3DC33D1,result49C758C3CB9E452A80535E2651156E3D,"TravelExpense",ref ISpace);
iSpace.UpdateGridBindDetails("TravelExpense",result49C758C3CB9E452A80535E2651156E3D);
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
private void SubscribeElementEvents_edit_travelexpense (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Edit_TravelExpense-OnClick");
ISpace["growid"].Value=ISpace["TravelExpense_RowId"].Value;
base.WriteDebugInfo(@"ISpace[""growid""].Value=ISpace[""TravelExpense_RowId""].Value;");
base.WriteDebugInfo(@"EXEC LoadFormGridData374fb8a88dd94cf1bf73f40ae18fcad7 '@@gv_InstanceId','@@gv_ProcessMapId','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','@@gv_ActivityMapId','#growid'");

var querySource2ACCBC572E9C4A0FBD46FAB4E50951D4 =GetQueryExpressionDataSource("2ACCBC57-2E9C-4A0F-BD46-FAB4E50951D4");
Dictionary<short,object> result2ACCBC572E9C4A0FBD46FAB4E50951D4=iSpace.ExecuteQuery(querySource2ACCBC572E9C4A0FBD46FAB4E50951D4,@"EXEC LoadFormGridData374fb8a88dd94cf1bf73f40ae18fcad7 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["growid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource2ACCBC572E9C4A0FBD46FAB4E50951D4 =GetQueryExpressionDataSource(""2ACCBC57-2E9C-4A0F-BD46-FAB4E50951D4"");Dictionary<short,object> result2ACCBC572E9C4A0FBD46FAB4E50951D4=iSpace.ExecuteQuery(querySource2ACCBC572E9C4A0FBD46FAB4E50951D4,@""EXEC LoadFormGridData374fb8a88dd94cf1bf73f40ae18fcad7 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""growid""].Value + @""'"",false);");
base.WriteDebugInfo(@"EXEC LoadFormGridData374fb8a88dd94cf1bf73f40ae18fcad7 '@@gv_InstanceId','@@gv_ProcessMapId','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','@@gv_ActivityMapId','#growid'");

if((result2ACCBC572E9C4A0FBD46FAB4E50951D4!=null) && (result2ACCBC572E9C4A0FBD46FAB4E50951D4.Count!=0))
{
if(result2ACCBC572E9C4A0FBD46FAB4E50951D4.ContainsKey(3))
ISpace["MFG_T2_DepartureDate"].Value = result2ACCBC572E9C4A0FBD46FAB4E50951D4[3];
if(result2ACCBC572E9C4A0FBD46FAB4E50951D4.ContainsKey(6))
ISpace["MFG_T2_ArrivalDate"].Value = result2ACCBC572E9C4A0FBD46FAB4E50951D4[6];
if(result2ACCBC572E9C4A0FBD46FAB4E50951D4.ContainsKey(8))
ISpace["MFG_T2_ModeofJourney"].Value = result2ACCBC572E9C4A0FBD46FAB4E50951D4[8];
if(result2ACCBC572E9C4A0FBD46FAB4E50951D4.ContainsKey(9))
ISpace["MFG_T2_JourneyClass"].Value = result2ACCBC572E9C4A0FBD46FAB4E50951D4[9];
if(result2ACCBC572E9C4A0FBD46FAB4E50951D4.ContainsKey(12))
ISpace["MFG_T2_Amount"].Value = result2ACCBC572E9C4A0FBD46FAB4E50951D4[12];
if(result2ACCBC572E9C4A0FBD46FAB4E50951D4.ContainsKey(10))
ISpace["MFG_T2_Road"].Value = result2ACCBC572E9C4A0FBD46FAB4E50951D4[10];
if(result2ACCBC572E9C4A0FBD46FAB4E50951D4.ContainsKey(11))
ISpace["MFG_T2_PNRNo"].Value = result2ACCBC572E9C4A0FBD46FAB4E50951D4[11];
if(result2ACCBC572E9C4A0FBD46FAB4E50951D4.ContainsKey(4))
ISpace["MFG_T2_DepartureTime"].Value = result2ACCBC572E9C4A0FBD46FAB4E50951D4[4];
if(result2ACCBC572E9C4A0FBD46FAB4E50951D4.ContainsKey(0))
ISpace["MFG_T2_TADetailsID"].Value = result2ACCBC572E9C4A0FBD46FAB4E50951D4[0];
if(result2ACCBC572E9C4A0FBD46FAB4E50951D4.ContainsKey(7))
ISpace["MFG_T2_ArrivalTime"].Value = result2ACCBC572E9C4A0FBD46FAB4E50951D4[7];
if(result2ACCBC572E9C4A0FBD46FAB4E50951D4.ContainsKey(5))
ISpace["MFG_T2_Arrival"].Value = result2ACCBC572E9C4A0FBD46FAB4E50951D4[5];
if(result2ACCBC572E9C4A0FBD46FAB4E50951D4.ContainsKey(2))
ISpace["MFG_T2_Departure"].Value = result2ACCBC572E9C4A0FBD46FAB4E50951D4[2];
if(result2ACCBC572E9C4A0FBD46FAB4E50951D4.ContainsKey(1))
ISpace["MFG_T2_TravelAdvanceID"].Value = result2ACCBC572E9C4A0FBD46FAB4E50951D4[1];
}
else{
ISpace["MFG_T2_DepartureDate"].Value = null;ISpace["MFG_T2_ArrivalDate"].Value = null;ISpace["MFG_T2_ModeofJourney"].Value = null;ISpace["MFG_T2_JourneyClass"].Value = null;ISpace["MFG_T2_Amount"].Value = null;ISpace["MFG_T2_Road"].Value = null;ISpace["MFG_T2_PNRNo"].Value = null;ISpace["MFG_T2_DepartureTime"].Value = null;ISpace["MFG_T2_TADetailsID"].Value = null;ISpace["MFG_T2_ArrivalTime"].Value = null;ISpace["MFG_T2_Arrival"].Value = null;ISpace["MFG_T2_Departure"].Value = null;ISpace["MFG_T2_TravelAdvanceID"].Value = null;
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

var querySource4DA95BD5CD3F4A6D8AE54C8A839E94D6 =GetQueryExpressionDataSource("4DA95BD5-CD3F-4A6D-8AE5-4C8A839E94D6");
Dictionary<short,object> result4DA95BD5CD3F4A6D8AE54C8A839E94D6=iSpace.ExecuteQuery(querySource4DA95BD5CD3F4A6D8AE54C8A839E94D6,@"Exec GetStageStatus 1,'','','" + ISpace["M_MoveToValue"].Value + @"','" + ISpace["M_SourceActivityMapId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource4DA95BD5CD3F4A6D8AE54C8A839E94D6 =GetQueryExpressionDataSource(""4DA95BD5-CD3F-4A6D-8AE5-4C8A839E94D6"");Dictionary<short,object> result4DA95BD5CD3F4A6D8AE54C8A839E94D6=iSpace.ExecuteQuery(querySource4DA95BD5CD3F4A6D8AE54C8A839E94D6,@""Exec GetStageStatus 1,'','','"" + ISpace[""M_MoveToValue""].Value + @""','"" + ISpace[""M_SourceActivityMapId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result4DA95BD5CD3F4A6D8AE54C8A839E94D6!=null) && (result4DA95BD5CD3F4A6D8AE54C8A839E94D6.Count!=0))
{
if(result4DA95BD5CD3F4A6D8AE54C8A839E94D6.ContainsKey(5))
ISpace["M_IsFlowReturned"].Value = result4DA95BD5CD3F4A6D8AE54C8A839E94D6[5];
if(result4DA95BD5CD3F4A6D8AE54C8A839E94D6.ContainsKey(6))
ISpace["M_IsCancelReject"].Value = result4DA95BD5CD3F4A6D8AE54C8A839E94D6[6];
if(result4DA95BD5CD3F4A6D8AE54C8A839E94D6.ContainsKey(4))
ISpace["M_FieldMandatory"].Value = result4DA95BD5CD3F4A6D8AE54C8A839E94D6[4];
if(result4DA95BD5CD3F4A6D8AE54C8A839E94D6.ContainsKey(1))
ISpace["M_RemarksMandatory"].Value = result4DA95BD5CD3F4A6D8AE54C8A839E94D6[1];
if(result4DA95BD5CD3F4A6D8AE54C8A839E94D6.ContainsKey(3))
ISpace["M_SaveDomainData"].Value = result4DA95BD5CD3F4A6D8AE54C8A839E94D6[3];
if(result4DA95BD5CD3F4A6D8AE54C8A839E94D6.ContainsKey(2))
ISpace["M_Remarks"].Value = result4DA95BD5CD3F4A6D8AE54C8A839E94D6[2];
if(result4DA95BD5CD3F4A6D8AE54C8A839E94D6.ContainsKey(0))
ISpace["M_NextStage"].Value = result4DA95BD5CD3F4A6D8AE54C8A839E94D6[0];
}
else{
ISpace["M_IsFlowReturned"].Value = null;ISpace["M_IsCancelReject"].Value = null;ISpace["M_FieldMandatory"].Value = null;ISpace["M_RemarksMandatory"].Value = null;ISpace["M_SaveDomainData"].Value = null;ISpace["M_Remarks"].Value = null;ISpace["M_NextStage"].Value = null;
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
		if(elementName.ToLower().Equals("save_travelexpense"))
{
			SubscribeElementEvents_save_travelexpense(ref dfsParam);
}
		if(elementName.ToLower().Equals("edit_travelexpense"))
{
			SubscribeElementEvents_edit_travelexpense(ref dfsParam);
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
public class ISpaceCFA9B7B28CF54389B2038EA7C779EE9A : VirtualForm
{
IISpace iSpace = new ISpace();
AcDataISpaceCFA9B7B28CF54389B2038EA7C779EE9A acdataIspaceCFA9B7B28CF54389B2038EA7C779EE9A=new AcDataISpaceCFA9B7B28CF54389B2038EA7C779EE9A();
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
ISpace["M_TravelInstanceId"].Value=Guid.NewGuid().ToString();
base.WriteDebugInfo(@"ISpace[""M_TravelInstanceId""].Value=Guid.NewGuid().ToString();");
ISpace["M_MoveTo"].Man=true;
base.WriteDebugInfo(@"ISpace[""M_MoveTo""].Man=true;");
ISpace["M_Remarks"].Value="";
base.WriteDebugInfo(@"ISpace[""M_Remarks""].Value="""";");
ISpace["M_NextStage"].Value="";
base.WriteDebugInfo(@"ISpace[""M_NextStage""].Value="""";");
ISpace["MF_TransactionDate"].Man=true;ISpace["MF_TransactionNo"].Man=true;
base.WriteDebugInfo(@"ISpace[""MF_TransactionDate""].Man=true;ISpace[""MF_TransactionNo""].Man=true;");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySourceA0ECD2B8980941FB814ECFF85B9E0A09 =GetQueryExpressionDataSource("A0ECD2B8-9809-41FB-814E-CFF85B9E0A09");

DataTable resultA0ECD2B8980941FB814ECFF85B9E0A09=iSpace.SetGridDataSource(querySourceA0ECD2B8980941FB814ECFF85B9E0A09, _objectFactory.GetGridRPP("MG_RemarksDetails"),@"EXEC GetRemarks '" + ISpace["M_InstanceId"].Value + @"'");

iSpace.InsertGridBindDetails("MG_RemarksDetails","11",querySourceA0ECD2B8980941FB814ECFF85B9E0A09,"EXEC GetRemarks '" + ISpace["M_InstanceId"].Value + @"'",_objectFactory.GetGridRPP("MG_RemarksDetails"));

base.WriteDebugInfo(@"var querySourceA0ECD2B8980941FB814ECFF85B9E0A09 =GetQueryExpressionDataSource(""A0ECD2B8-9809-41FB-814E-CFF85B9E0A09"");DataTable resultA0ECD2B8980941FB814ECFF85B9E0A09=iSpace.SetGridDataSource(querySourceA0ECD2B8980941FB814ECFF85B9E0A09, _objectFactory.GetGridRPP(""MG_RemarksDetails""),@""EXEC GetRemarks '"" + ISpace[""M_InstanceId""].Value + @""'"");iSpace.InsertGridBindDetails(""MG_RemarksDetails"",""11"",querySourceA0ECD2B8980941FB814ECFF85B9E0A09,""EXEC GetRemarks '"" + ISpace[""M_InstanceId""].Value + @""'"",_objectFactory.GetGridRPP(""MG_RemarksDetails""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> resultCBD3E108E08C4B5F8ACA817E51BDACD4=acdataIspaceCFA9B7B28CF54389B2038EA7C779EE9A.GetQueryExpressionBindings("CBD3E108-E08C-4B5F-8ACA-817E51BDACD4");
iSpace.SetGridData(resultA0ECD2B8980941FB814ECFF85B9E0A09,resultCBD3E108E08C4B5F8ACA817E51BDACD4,"MG_RemarksDetails",ref ISpace);
iSpace.UpdateGridBindDetails("MG_RemarksDetails",resultCBD3E108E08C4B5F8ACA817E51BDACD4);
}
ISpace["UC_DOJ"].Visible="false";ISpace["UC_EmailId"].Visible="false";ISpace["UC_PhoneNumber"].Visible="false";ISpace["UC_DOB"].Visible="false";ISpace["UC_Grade"].Visible="false";ISpace["UC_DOR"].Visible="false";ISpace["UC_Paylevel"].Visible="false";
base.WriteDebugInfo(@"ISpace[""UC_DOJ""].Visible=""false"";ISpace[""UC_EmailId""].Visible=""false"";ISpace[""UC_PhoneNumber""].Visible=""false"";ISpace[""UC_DOB""].Visible=""false"";ISpace[""UC_Grade""].Visible=""false"";ISpace[""UC_DOR""].Visible=""false"";ISpace[""UC_Paylevel""].Visible=""false"";");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["MFG_T2_ModeofJourney"].Visible="true";ISpace["MFG_T2_Departure"].Visible="true";ISpace["MFG_T2_Road"].Visible="true";ISpace["MFG_T2_DepartureDate"].Visible="true";ISpace["MFG_T2_ArrivalDate"].Visible="true";ISpace["MF_T1_BudgetHead"].Visible="true";ISpace["MFG_T2_TravelAdvanceID"].Visible="false";ISpace["MF_T1_Destination"].Visible="true";ISpace["MFG_T2_Amount"].Visible="true";ISpace["MF_T1_AvailableBudget"].Visible="true";ISpace["MF_T1_JourneyPurpose"].Visible="true";ISpace["MFG_T2_PNRNo"].Visible="true";ISpace["MFG_T2_JourneyClass"].Visible="true";ISpace["MFG_T2_DepartureTime"].Visible="true";ISpace["MFG_T2_ToDate"].Visible="true";ISpace["MF_T1_AccountNo"].Visible="true";ISpace["MFG_T2_FromDate"].Visible="true";ISpace["MFG_T3_Amount"].Visible="true";ISpace["MFG_T3_TravelAdvanceID"].Visible="false";ISpace["MF_T1_TravelType"].Visible="true";ISpace["MF_T1_BankBranch"].Visible="true";ISpace["MF_T1_ProjectNo"].Visible="true";ISpace["MFG_T2_TADetailsID"].Visible="true";ISpace["MFG_T2_ArrivalTime"].Visible="true";ISpace["MF_T1_AdvanceAmount"].Visible="true";ISpace["MFG_T2_ExpenditureTypeID"].Visible="true";ISpace["MF_T1_TravellingPerson"].Visible="true";ISpace["MF_T1_BeneficiaryName"].Visible="true";ISpace["MF_T1_BankDocument"].Visible="true";ISpace["MF_T1_TravelAdvanceID"].Visible="false";ISpace["MF_T1_BankName"].Visible="true";ISpace["MFG_T2_Arrival"].Visible="true";ISpace["MF_T1_ReferenceNo"].Visible="true";
base.WriteDebugInfo(@"ISpace[""MFG_T2_ModeofJourney""].Visible=""true"";ISpace[""MFG_T2_Departure""].Visible=""true"";ISpace[""MFG_T2_Road""].Visible=""true"";ISpace[""MFG_T2_DepartureDate""].Visible=""true"";ISpace[""MFG_T2_ArrivalDate""].Visible=""true"";ISpace[""MF_T1_BudgetHead""].Visible=""true"";ISpace[""MFG_T2_TravelAdvanceID""].Visible=""false"";ISpace[""MF_T1_Destination""].Visible=""true"";ISpace[""MFG_T2_Amount""].Visible=""true"";ISpace[""MF_T1_AvailableBudget""].Visible=""true"";ISpace[""MF_T1_JourneyPurpose""].Visible=""true"";ISpace[""MFG_T2_PNRNo""].Visible=""true"";ISpace[""MFG_T2_JourneyClass""].Visible=""true"";ISpace[""MFG_T2_DepartureTime""].Visible=""true"";ISpace[""MFG_T2_ToDate""].Visible=""true"";ISpace[""MF_T1_AccountNo""].Visible=""true"";ISpace[""MFG_T2_FromDate""].Visible=""true"";ISpace[""MFG_T3_Amount""].Visible=""true"";ISpace[""MFG_T3_TravelAdvanceID""].Visible=""false"";ISpace[""MF_T1_TravelType""].Visible=""true"";ISpace[""MF_T1_BankBranch""].Visible=""true"";ISpace[""MF_T1_ProjectNo""].Visible=""true"";ISpace[""MFG_T2_TADetailsID""].Visible=""true"";ISpace[""MFG_T2_ArrivalTime""].Visible=""true"";ISpace[""MF_T1_AdvanceAmount""].Visible=""true"";ISpace[""MFG_T2_ExpenditureTypeID""].Visible=""true"";ISpace[""MF_T1_TravellingPerson""].Visible=""true"";ISpace[""MF_T1_BeneficiaryName""].Visible=""true"";ISpace[""MF_T1_BankDocument""].Visible=""true"";ISpace[""MF_T1_TravelAdvanceID""].Visible=""false"";ISpace[""MF_T1_BankName""].Visible=""true"";ISpace[""MFG_T2_Arrival""].Visible=""true"";ISpace[""MF_T1_ReferenceNo""].Visible=""true"";");
ISpace["MG_T2_Arrival"].Visible="true";ISpace["MG_T2_Road"].Visible="true";ISpace["MG_T2_TADetailsID"].Visible="false";ISpace["MG_T2_PNRNo"].Visible="true";ISpace["MG_T2_Departure"].Visible="true";ISpace["MG_T2_DepartureDate"].Visible="true";ISpace["MG_T2_ArrivalDate"].Visible="true";ISpace["MG_T3_TravelAdvanceID"].Visible="true";ISpace["MG_T2_DepartureTime"].Visible="true";ISpace["MG_T2_JourneyClass"].Visible="true";ISpace["MG_T2_ModeofJourney"].Visible="true";ISpace["MG_T2_ArrivalTime"].Visible="true";ISpace["MG_T2_Amount"].Visible="true";
base.WriteDebugInfo(@"ISpace[""MG_T2_Arrival""].Visible=""true"";ISpace[""MG_T2_Road""].Visible=""true"";ISpace[""MG_T2_TADetailsID""].Visible=""false"";ISpace[""MG_T2_PNRNo""].Visible=""true"";ISpace[""MG_T2_Departure""].Visible=""true"";ISpace[""MG_T2_DepartureDate""].Visible=""true"";ISpace[""MG_T2_ArrivalDate""].Visible=""true"";ISpace[""MG_T3_TravelAdvanceID""].Visible=""true"";ISpace[""MG_T2_DepartureTime""].Visible=""true"";ISpace[""MG_T2_JourneyClass""].Visible=""true"";ISpace[""MG_T2_ModeofJourney""].Visible=""true"";ISpace[""MG_T2_ArrivalTime""].Visible=""true"";ISpace[""MG_T2_Amount""].Visible=""true"";");
ISpace["MG_T3_Amount"].Visible="true";ISpace["MG_T2_ExpenditureTypeID"].Visible="true";ISpace["MG_T2_FromDate"].Visible="true";ISpace["MG_T2_ToDate"].Visible="true";ISpace["MG_T2_TravelAdvanceID"].Visible="false";
base.WriteDebugInfo(@"ISpace[""MG_T3_Amount""].Visible=""true"";ISpace[""MG_T2_ExpenditureTypeID""].Visible=""true"";ISpace[""MG_T2_FromDate""].Visible=""true"";ISpace[""MG_T2_ToDate""].Visible=""true"";ISpace[""MG_T2_TravelAdvanceID""].Visible=""false"";");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["MF_T1_BudgetHead"].Man=true;ISpace["MF_T1_Destination"].Man=true;ISpace["MF_T1_AvailableBudget"].Man=true;ISpace["MF_T1_JourneyPurpose"].Man=true;ISpace["MF_T1_AccountNo"].Man=true;ISpace["MF_T1_TravelType"].Man=true;ISpace["MF_T1_BankBranch"].Man=true;ISpace["MF_T1_ProjectNo"].Man=true;ISpace["MF_T1_AdvanceAmount"].Man=true;ISpace["MF_T1_TravellingPerson"].Man=true;ISpace["MF_T1_BeneficiaryName"].Man=true;ISpace["MF_T1_BankDocument"].Man=true;ISpace["MF_T1_BankName"].Man=true;ISpace["MF_T1_ReferenceNo"].Man=true;
base.WriteDebugInfo(@"ISpace[""MF_T1_BudgetHead""].Man=true;ISpace[""MF_T1_Destination""].Man=true;ISpace[""MF_T1_AvailableBudget""].Man=true;ISpace[""MF_T1_JourneyPurpose""].Man=true;ISpace[""MF_T1_AccountNo""].Man=true;ISpace[""MF_T1_TravelType""].Man=true;ISpace[""MF_T1_BankBranch""].Man=true;ISpace[""MF_T1_ProjectNo""].Man=true;ISpace[""MF_T1_AdvanceAmount""].Man=true;ISpace[""MF_T1_TravellingPerson""].Man=true;ISpace[""MF_T1_BeneficiaryName""].Man=true;ISpace[""MF_T1_BankDocument""].Man=true;ISpace[""MF_T1_BankName""].Man=true;ISpace[""MF_T1_ReferenceNo""].Man=true;");
}
if(ISpace["Travel_Type"].Value=="1")
{
base.WriteDebugInfo(@"if(ISpace[""Travel_Type""].Value==""1"")");
ISpace["MF_T1_AccountNo"].Man=false;ISpace["MF_T1_BankBranch"].Man=false;ISpace["MF_T1_BeneficiaryName"].Man=false;ISpace["MF_T1_BankDocument"].Man=false;ISpace["MF_T1_BankName"].Man=false;
base.WriteDebugInfo(@"ISpace[""MF_T1_AccountNo""].Man=false;ISpace[""MF_T1_BankBranch""].Man=false;ISpace[""MF_T1_BeneficiaryName""].Man=false;ISpace[""MF_T1_BankDocument""].Man=false;ISpace[""MF_T1_BankName""].Man=false;");
}
if(ISpace["Travel_Type"].Value=="3")
{
base.WriteDebugInfo(@"if(ISpace[""Travel_Type""].Value==""3"")");
ISpace["MF_T1_AccountNo"].Man=true;ISpace["MF_T1_AccountNo"].Enbl="true";ISpace["MF_T1_BankBranch"].Man=true;ISpace["MF_T1_BankBranch"].Enbl="true";ISpace["MF_T1_AdvanceAmount"].Man=true;ISpace["MF_T1_AdvanceAmount"].Enbl="true";ISpace["MF_T1_BeneficiaryName"].Man=true;ISpace["MF_T1_BeneficiaryName"].Enbl="true";ISpace["MF_T1_BankDocument"].Man=true;ISpace["MF_T1_BankDocument"].Enbl="true";ISpace["MF_T1_BankName"].Man=true;ISpace["MF_T1_BankName"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_T1_AccountNo""].Man=true;ISpace[""MF_T1_AccountNo""].Enbl=""true"";ISpace[""MF_T1_BankBranch""].Man=true;ISpace[""MF_T1_BankBranch""].Enbl=""true"";ISpace[""MF_T1_AdvanceAmount""].Man=true;ISpace[""MF_T1_AdvanceAmount""].Enbl=""true"";ISpace[""MF_T1_BeneficiaryName""].Man=true;ISpace[""MF_T1_BeneficiaryName""].Enbl=""true"";ISpace[""MF_T1_BankDocument""].Man=true;ISpace[""MF_T1_BankDocument""].Enbl=""true"";ISpace[""MF_T1_BankName""].Man=true;ISpace[""MF_T1_BankName""].Enbl=""true"";");
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
return;
base.WriteDebugInfo(@"return;");
}
ISpace["MF_TravelStatus"].Value="A";
base.WriteDebugInfo(@"ISpace[""MF_TravelStatus""].Value=""A"";");
ISpace["M_IsCommitment"].Value=0;
base.WriteDebugInfo(@"ISpace[""M_IsCommitment""].Value=0;");
if(ISpace["M_SaveDomainData"].Value==1||1==1)
{
base.WriteDebugInfo(@"if(ISpace[""M_SaveDomainData""].Value==1||1==1)");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC Repo198E5A8A61F54E7C92DD34146A7059EF '#CreatedOn','#MF_T1_BankDocument','#MF_T1_ReferenceNo','#MF_T1_AccountNo','#OverAll_Total','#UC_EmployeeBaicInfoId','#M_TravelPlace','#MF_T1_AdvanceAmount','#MF_T1_BankName','#MF_T1_TravelAdvanceID','#MF_T1_JourneyPurpose','#Travel_Type','#MF_T1_BeneficiaryName','#gv_UserId','#MF_TransactionNo','#MF_TravelStatus','#MF_TransactionDate','#M_IsAdvanceRequired'");

var querySourceD16F9C83EA714542AB4DE3D99AB969B2 =GetQueryExpressionDataSource("D16F9C83-EA71-4542-AB4D-E3D99AB969B2");
Dictionary<short,object> resultD16F9C83EA714542AB4DE3D99AB969B2=iSpace.ExecuteQuery(querySourceD16F9C83EA714542AB4DE3D99AB969B2,@"EXEC Repo198E5A8A61F54E7C92DD34146A7059EF '" + ISpace["CreatedOn"].Value + @"','" + ISpace["MF_T1_BankDocument"].Value + @"','" + ISpace["MF_T1_ReferenceNo"].Value + @"','" + ISpace["MF_T1_AccountNo"].Value + @"','" + ISpace["OverAll_Total"].Value + @"','" + ISpace["UC_EmployeeBaicInfoId"].Value + @"','" + ISpace["M_TravelPlace"].Value + @"','" + ISpace["MF_T1_AdvanceAmount"].Value + @"','" + ISpace["MF_T1_BankName"].Value + @"','" + ISpace["MF_T1_TravelAdvanceID"].Value + @"','" + ISpace["MF_T1_JourneyPurpose"].Value + @"','" + ISpace["Travel_Type"].Value + @"','" + ISpace["MF_T1_BeneficiaryName"].Value + @"','" + ISpace["gv_UserId"].Value + @"','" + ISpace["MF_TransactionNo"].Value + @"','" + ISpace["MF_TravelStatus"].Value + @"','" + ISpace["MF_TransactionDate"].Value + @"','" + ISpace["M_IsAdvanceRequired"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceD16F9C83EA714542AB4DE3D99AB969B2 =GetQueryExpressionDataSource(""D16F9C83-EA71-4542-AB4D-E3D99AB969B2"");Dictionary<short,object> resultD16F9C83EA714542AB4DE3D99AB969B2=iSpace.ExecuteQuery(querySourceD16F9C83EA714542AB4DE3D99AB969B2,@""EXEC Repo198E5A8A61F54E7C92DD34146A7059EF '"" + ISpace[""CreatedOn""].Value + @""','"" + ISpace[""MF_T1_BankDocument""].Value + @""','"" + ISpace[""MF_T1_ReferenceNo""].Value + @""','"" + ISpace[""MF_T1_AccountNo""].Value + @""','"" + ISpace[""OverAll_Total""].Value + @""','"" + ISpace[""UC_EmployeeBaicInfoId""].Value + @""','"" + ISpace[""M_TravelPlace""].Value + @""','"" + ISpace[""MF_T1_AdvanceAmount""].Value + @""','"" + ISpace[""MF_T1_BankName""].Value + @""','"" + ISpace[""MF_T1_TravelAdvanceID""].Value + @""','"" + ISpace[""MF_T1_JourneyPurpose""].Value + @""','"" + ISpace[""Travel_Type""].Value + @""','"" + ISpace[""MF_T1_BeneficiaryName""].Value + @""','"" + ISpace[""gv_UserId""].Value + @""','"" + ISpace[""MF_TransactionNo""].Value + @""','"" + ISpace[""MF_TravelStatus""].Value + @""','"" + ISpace[""MF_TransactionDate""].Value + @""','"" + ISpace[""M_IsAdvanceRequired""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultD16F9C83EA714542AB4DE3D99AB969B2!=null) && (resultD16F9C83EA714542AB4DE3D99AB969B2.Count!=0))
{
}
else{

}
base.WriteDebugInfo(@"EXEC Repo51838b372ec64d358a5e38648bc93ab1 '#gv_UserId','#UpdatedOn','#MF_T1_TravelAdvanceID','#MG_T2_ToDate','#MG_T2_FromDate','#M_IsTravelRequest','#MG_T2_ExpenditureTypeID','#Expenditure_Type','#MG_T3_Amount'");

var querySource864963C6427C451F8C30D7E8FCDD4228 =GetQueryExpressionDataSource("864963C6-427C-451F-8C30-D7E8FCDD4228");
Dictionary<short,object> result864963C6427C451F8C30D7E8FCDD4228=iSpace.ExecuteQuery(querySource864963C6427C451F8C30D7E8FCDD4228,@"EXEC Repo51838b372ec64d358a5e38648bc93ab1 '" + ISpace["gv_UserId"].Value + @"','" + ISpace["UpdatedOn"].Value + @"','" + ISpace["MF_T1_TravelAdvanceID"].Value + @"','" + ISpace["MG_T2_ToDate"].Value + @"','" + ISpace["MG_T2_FromDate"].Value + @"','" + ISpace["M_IsTravelRequest"].Value + @"','" + ISpace["MG_T2_ExpenditureTypeID"].Value + @"','" + ISpace["Expenditure_Type"].Value + @"','" + ISpace["MG_T3_Amount"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource864963C6427C451F8C30D7E8FCDD4228 =GetQueryExpressionDataSource(""864963C6-427C-451F-8C30-D7E8FCDD4228"");Dictionary<short,object> result864963C6427C451F8C30D7E8FCDD4228=iSpace.ExecuteQuery(querySource864963C6427C451F8C30D7E8FCDD4228,@""EXEC Repo51838b372ec64d358a5e38648bc93ab1 '"" + ISpace[""gv_UserId""].Value + @""','"" + ISpace[""UpdatedOn""].Value + @""','"" + ISpace[""MF_T1_TravelAdvanceID""].Value + @""','"" + ISpace[""MG_T2_ToDate""].Value + @""','"" + ISpace[""MG_T2_FromDate""].Value + @""','"" + ISpace[""M_IsTravelRequest""].Value + @""','"" + ISpace[""MG_T2_ExpenditureTypeID""].Value + @""','"" + ISpace[""Expenditure_Type""].Value + @""','"" + ISpace[""MG_T3_Amount""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result864963C6427C451F8C30D7E8FCDD4228!=null) && (result864963C6427C451F8C30D7E8FCDD4228.Count!=0))
{
}
else{

}
base.WriteDebugInfo(@"EXEC Repo374fb8a88dd94cf1bf73f40ae18fcad7 '#M_IsTravelRequest','#UpdatedOn','#MG_T2_TADetailsID','#gv_UserId','#MG_T2_DepartureDate','#MG_T2_DepartureTime','#MG_T2_ArrivalDate','#MG_T2_Road','#MF_T1_TravelAdvanceID','#MG_T2_Departure','#MG_T2_Amount','#MG_T2_JourneyClass','#MG_T2_Arrival','#MG_T2_PNRNo','#MG_T2_ModeofJourney','#MG_T2_ArrivalTime'");

var querySourceEBE446FD1D9E41DEB663DEAA6EE73345 =GetQueryExpressionDataSource("EBE446FD-1D9E-41DE-B663-DEAA6EE73345");
Dictionary<short,object> resultEBE446FD1D9E41DEB663DEAA6EE73345=iSpace.ExecuteQuery(querySourceEBE446FD1D9E41DEB663DEAA6EE73345,@"EXEC Repo374fb8a88dd94cf1bf73f40ae18fcad7 '" + ISpace["M_IsTravelRequest"].Value + @"','" + ISpace["UpdatedOn"].Value + @"','" + ISpace["MG_T2_TADetailsID"].Value + @"','" + ISpace["gv_UserId"].Value + @"','" + ISpace["MG_T2_DepartureDate"].Value + @"','" + ISpace["MG_T2_DepartureTime"].Value + @"','" + ISpace["MG_T2_ArrivalDate"].Value + @"','" + ISpace["MG_T2_Road"].Value + @"','" + ISpace["MF_T1_TravelAdvanceID"].Value + @"','" + ISpace["MG_T2_Departure"].Value + @"','" + ISpace["MG_T2_Amount"].Value + @"','" + ISpace["MG_T2_JourneyClass"].Value + @"','" + ISpace["MG_T2_Arrival"].Value + @"','" + ISpace["MG_T2_PNRNo"].Value + @"','" + ISpace["MG_T2_ModeofJourney"].Value + @"','" + ISpace["MG_T2_ArrivalTime"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceEBE446FD1D9E41DEB663DEAA6EE73345 =GetQueryExpressionDataSource(""EBE446FD-1D9E-41DE-B663-DEAA6EE73345"");Dictionary<short,object> resultEBE446FD1D9E41DEB663DEAA6EE73345=iSpace.ExecuteQuery(querySourceEBE446FD1D9E41DEB663DEAA6EE73345,@""EXEC Repo374fb8a88dd94cf1bf73f40ae18fcad7 '"" + ISpace[""M_IsTravelRequest""].Value + @""','"" + ISpace[""UpdatedOn""].Value + @""','"" + ISpace[""MG_T2_TADetailsID""].Value + @""','"" + ISpace[""gv_UserId""].Value + @""','"" + ISpace[""MG_T2_DepartureDate""].Value + @""','"" + ISpace[""MG_T2_DepartureTime""].Value + @""','"" + ISpace[""MG_T2_ArrivalDate""].Value + @""','"" + ISpace[""MG_T2_Road""].Value + @""','"" + ISpace[""MF_T1_TravelAdvanceID""].Value + @""','"" + ISpace[""MG_T2_Departure""].Value + @""','"" + ISpace[""MG_T2_Amount""].Value + @""','"" + ISpace[""MG_T2_JourneyClass""].Value + @""','"" + ISpace[""MG_T2_Arrival""].Value + @""','"" + ISpace[""MG_T2_PNRNo""].Value + @""','"" + ISpace[""MG_T2_ModeofJourney""].Value + @""','"" + ISpace[""MG_T2_ArrivalTime""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultEBE446FD1D9E41DEB663DEAA6EE73345!=null) && (resultEBE446FD1D9E41DEB663DEAA6EE73345.Count!=0))
{
}
else{

}
base.WriteDebugInfo(@"EXEC DocumentsDomain '#M_DocumentDetailsId','#M_PackageProcessMapId','#UpdatedOn','#M_DocumentName','#gv_UserId','#M_UploadDcoument','#MF_T1_TravelAdvanceID'");

var querySource1D2378FB2963489899022B61F44BE0AD =GetQueryExpressionDataSource("1D2378FB-2963-4898-9902-2B61F44BE0AD");
Dictionary<short,object> result1D2378FB2963489899022B61F44BE0AD=iSpace.ExecuteQuery(querySource1D2378FB2963489899022B61F44BE0AD,@"EXEC DocumentsDomain '" + ISpace["M_DocumentDetailsId"].Value + @"','" + ISpace["M_PackageProcessMapId"].Value + @"','" + ISpace["UpdatedOn"].Value + @"','" + ISpace["M_DocumentName"].Value + @"','" + ISpace["gv_UserId"].Value + @"','" + ISpace["M_UploadDcoument"].Value + @"','" + ISpace["MF_T1_TravelAdvanceID"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource1D2378FB2963489899022B61F44BE0AD =GetQueryExpressionDataSource(""1D2378FB-2963-4898-9902-2B61F44BE0AD"");Dictionary<short,object> result1D2378FB2963489899022B61F44BE0AD=iSpace.ExecuteQuery(querySource1D2378FB2963489899022B61F44BE0AD,@""EXEC DocumentsDomain '"" + ISpace[""M_DocumentDetailsId""].Value + @""','"" + ISpace[""M_PackageProcessMapId""].Value + @""','"" + ISpace[""UpdatedOn""].Value + @""','"" + ISpace[""M_DocumentName""].Value + @""','"" + ISpace[""gv_UserId""].Value + @""','"" + ISpace[""M_UploadDcoument""].Value + @""','"" + ISpace[""MF_T1_TravelAdvanceID""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result1D2378FB2963489899022B61F44BE0AD!=null) && (result1D2378FB2963489899022B61F44BE0AD.Count!=0))
{
}
else{

}
base.WriteDebugInfo(@"#MF_FundAmount[rows]");
iSpace.GetLoopExpressionData("MF_FundAmount",ref ISpace);

foreach(var gridChild in ISpace["MF_FundAmount"].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 


if(
ISpace["MG_FundTypeId"].Value==1)
{
base.WriteDebugInfo(@"
if(
ISpace[""MG_FundTypeId""].Value==1)");
base.WriteDebugInfo(@"EXEC ProjectApprovalCommittmentDetails '#MG_Amount','#MF_T1_TravelAdvanceID','#MG_ProjectDetailsId','#MG_BudgetHead','#gv_ProcessMapId'");

var querySource4213CFEEA88E4B67BEECB0AEF4337465 =GetQueryExpressionDataSource("4213CFEE-A88E-4B67-BEEC-B0AEF4337465");
Dictionary<short,object> result4213CFEEA88E4B67BEECB0AEF4337465=iSpace.ExecuteQuery(querySource4213CFEEA88E4B67BEECB0AEF4337465,@"EXEC ProjectApprovalCommittmentDetails '" + ISpace["MG_Amount"].Value + @"','" + ISpace["MF_T1_TravelAdvanceID"].Value + @"','" + ISpace["MG_ProjectDetailsId"].Value + @"','" + ISpace["MG_BudgetHead"].Value + @"','" + ISpace["gv_ProcessMapId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource4213CFEEA88E4B67BEECB0AEF4337465 =GetQueryExpressionDataSource(""4213CFEE-A88E-4B67-BEEC-B0AEF4337465"");Dictionary<short,object> result4213CFEEA88E4B67BEECB0AEF4337465=iSpace.ExecuteQuery(querySource4213CFEEA88E4B67BEECB0AEF4337465,@""EXEC ProjectApprovalCommittmentDetails '"" + ISpace[""MG_Amount""].Value + @""','"" + ISpace[""MF_T1_TravelAdvanceID""].Value + @""','"" + ISpace[""MG_ProjectDetailsId""].Value + @""','"" + ISpace[""MG_BudgetHead""].Value + @""','"" + ISpace[""gv_ProcessMapId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result4213CFEEA88E4B67BEECB0AEF4337465!=null) && (result4213CFEEA88E4B67BEECB0AEF4337465.Count!=0))
{
}
else{

}
}
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("MF_FundAmount","AD9C54EC-27A0-4C21-9923-063084E3B588",_objectFactory.GetGridRPP("MF_FundAmount"),_elementBase.GetGridLoopQuery("AD9C54EC-27A0-4C21-9923-063084E3B588","MF_FundAmount",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""MF_FundAmount"",ref ISpace);

foreach(var gridChild in ISpace[""MF_FundAmount""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
}
if(1==2)
{
base.WriteDebugInfo(@"if(1==2)");
base.WriteDebugInfo(@"#MF_FundAmount[Rows]");
iSpace.GetLoopExpressionData("MF_FundAmount",ref ISpace);

foreach(var gridChild in ISpace["MF_FundAmount"].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 

base.WriteDebugInfo(@"EXEC UpsertProjectBudgetDetails 5,'#MG_ProjectDetailsId','#MF_T1_TravelAdvanceID','#MG_Amount','#MG_BudgetHead','1','#MG_FundTypeid','#M_PackageProcessMapId','#UC_EmployeeBaicInfoId'");

var querySourceEA86EC989465469D97F236E0D8B7BEB7 =GetQueryExpressionDataSource("EA86EC98-9465-469D-97F2-36E0D8B7BEB7");
Dictionary<short,object> resultEA86EC989465469D97F236E0D8B7BEB7=iSpace.ExecuteQuery(querySourceEA86EC989465469D97F236E0D8B7BEB7,@"EXEC UpsertProjectBudgetDetails 5,'" + ISpace["MG_ProjectDetailsId"].Value + @"','" + ISpace["MF_T1_TravelAdvanceID"].Value + @"','" + ISpace["MG_Amount"].Value + @"','" + ISpace["MG_BudgetHead"].Value + @"','1','" + ISpace["MG_FundTypeid"].Value + @"','" + ISpace["M_PackageProcessMapId"].Value + @"','" + ISpace["UC_EmployeeBaicInfoId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceEA86EC989465469D97F236E0D8B7BEB7 =GetQueryExpressionDataSource(""EA86EC98-9465-469D-97F2-36E0D8B7BEB7"");Dictionary<short,object> resultEA86EC989465469D97F236E0D8B7BEB7=iSpace.ExecuteQuery(querySourceEA86EC989465469D97F236E0D8B7BEB7,@""EXEC UpsertProjectBudgetDetails 5,'"" + ISpace[""MG_ProjectDetailsId""].Value + @""','"" + ISpace[""MF_T1_TravelAdvanceID""].Value + @""','"" + ISpace[""MG_Amount""].Value + @""','"" + ISpace[""MG_BudgetHead""].Value + @""','1','"" + ISpace[""MG_FundTypeid""].Value + @""','"" + ISpace[""M_PackageProcessMapId""].Value + @""','"" + ISpace[""UC_EmployeeBaicInfoId""].Value + @""'"",false);");
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("MF_FundAmount","AD9C54EC-27A0-4C21-9923-063084E3B588",_objectFactory.GetGridRPP("MF_FundAmount"),_elementBase.GetGridLoopQuery("AD9C54EC-27A0-4C21-9923-063084E3B588","MF_FundAmount",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""MF_FundAmount"",ref ISpace);

foreach(var gridChild in ISpace[""MF_FundAmount""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
}
}
if(ISpace["M_SaveDomainData"].Value==0&&ISpace["M_IsflowReturned"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""M_SaveDomainData""].Value==0&&ISpace[""M_IsflowReturned""].Value==1)");
base.WriteDebugInfo(@"exec [SendReturnEmailForTR] '#MF_T1_TravelAdvanceID'");

var querySourceDE33E12BFBC142E094A9B51B2789A1AE =GetQueryExpressionDataSource("DE33E12B-FBC1-42E0-94A9-B51B2789A1AE");
Dictionary<short,object> resultDE33E12BFBC142E094A9B51B2789A1AE=iSpace.ExecuteQuery(querySourceDE33E12BFBC142E094A9B51B2789A1AE,@"exec [SendReturnEmailForTR] '" + ISpace["MF_T1_TravelAdvanceID"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceDE33E12BFBC142E094A9B51B2789A1AE =GetQueryExpressionDataSource(""DE33E12B-FBC1-42E0-94A9-B51B2789A1AE"");Dictionary<short,object> resultDE33E12BFBC142E094A9B51B2789A1AE=iSpace.ExecuteQuery(querySourceDE33E12BFBC142E094A9B51B2789A1AE,@""exec [SendReturnEmailForTR] '"" + ISpace[""MF_T1_TravelAdvanceID""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultDE33E12BFBC142E094A9B51B2789A1AE!=null) && (resultDE33E12BFBC142E094A9B51B2789A1AE.Count!=0))
{
if(resultDE33E12BFBC142E094A9B51B2789A1AE.ContainsKey(0))
ISpace["A"].Value = resultDE33E12BFBC142E094A9B51B2789A1AE[0];
}
else{
ISpace["A"].Value = null;
}
}
if(ISpace["M_SaveDomainData"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""M_SaveDomainData""].Value==1)");
base.WriteDebugInfo(@"exec SendApproveEmailForTR '#MF_T1_TravelAdvanceID'");

var querySourceDD228B607D714F6690FD26F71FC14E4E =GetQueryExpressionDataSource("DD228B60-7D71-4F66-90FD-26F71FC14E4E");
Dictionary<short,object> resultDD228B607D714F6690FD26F71FC14E4E=iSpace.ExecuteQuery(querySourceDD228B607D714F6690FD26F71FC14E4E,@"execSendApproveEmailForTR '" + ISpace["MF_T1_TravelAdvanceID"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceDD228B607D714F6690FD26F71FC14E4E =GetQueryExpressionDataSource(""DD228B60-7D71-4F66-90FD-26F71FC14E4E"");Dictionary<short,object> resultDD228B607D714F6690FD26F71FC14E4E=iSpace.ExecuteQuery(querySourceDD228B607D714F6690FD26F71FC14E4E,@""execSendApproveEmailForTR '"" + ISpace[""MF_T1_TravelAdvanceID""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultDD228B607D714F6690FD26F71FC14E4E!=null) && (resultDD228B607D714F6690FD26F71FC14E4E.Count!=0))
{
if(resultDD228B607D714F6690FD26F71FC14E4E.ContainsKey(0))
ISpace["A"].Value = resultDD228B607D714F6690FD26F71FC14E4E[0];
}
else{
ISpace["A"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
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

base.WriteDebugInfo(@"EXEC UpsertProjectBudgetDetails 6,'#MG_ProjectDetailsId','#MF_T1_TravelAdvanceID','#MG_Amount','#MG_BudgetHead','1','#MG_FundTypeid','#M_PackageProcessMapId','#UC_EmployeeBaicInfoId'");

var querySource579419E790FA4F5A847AADEFF8FBD8C9 =GetQueryExpressionDataSource("579419E7-90FA-4F5A-847A-ADEFF8FBD8C9");
Dictionary<short,object> result579419E790FA4F5A847AADEFF8FBD8C9=iSpace.ExecuteQuery(querySource579419E790FA4F5A847AADEFF8FBD8C9,@"EXEC UpsertProjectBudgetDetails 6,'" + ISpace["MG_ProjectDetailsId"].Value + @"','" + ISpace["MF_T1_TravelAdvanceID"].Value + @"','" + ISpace["MG_Amount"].Value + @"','" + ISpace["MG_BudgetHead"].Value + @"','1','" + ISpace["MG_FundTypeid"].Value + @"','" + ISpace["M_PackageProcessMapId"].Value + @"','" + ISpace["UC_EmployeeBaicInfoId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource579419E790FA4F5A847AADEFF8FBD8C9 =GetQueryExpressionDataSource(""579419E7-90FA-4F5A-847A-ADEFF8FBD8C9"");Dictionary<short,object> result579419E790FA4F5A847AADEFF8FBD8C9=iSpace.ExecuteQuery(querySource579419E790FA4F5A847AADEFF8FBD8C9,@""EXEC UpsertProjectBudgetDetails 6,'"" + ISpace[""MG_ProjectDetailsId""].Value + @""','"" + ISpace[""MF_T1_TravelAdvanceID""].Value + @""','"" + ISpace[""MG_Amount""].Value + @""','"" + ISpace[""MG_BudgetHead""].Value + @""','1','"" + ISpace[""MG_FundTypeid""].Value + @""','"" + ISpace[""M_PackageProcessMapId""].Value + @""','"" + ISpace[""UC_EmployeeBaicInfoId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result579419E790FA4F5A847AADEFF8FBD8C9!=null) && (result579419E790FA4F5A847AADEFF8FBD8C9.Count!=0))
{
if(result579419E790FA4F5A847AADEFF8FBD8C9.ContainsKey(0))
ISpace["A"].Value = result579419E790FA4F5A847AADEFF8FBD8C9[0];
}
else{
ISpace["A"].Value = null;
}
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("MF_FundAmount","AD9C54EC-27A0-4C21-9923-063084E3B588",_objectFactory.GetGridRPP("MF_FundAmount"),_elementBase.GetGridLoopQuery("AD9C54EC-27A0-4C21-9923-063084E3B588","MF_FundAmount",ISpace), ref ISpace);
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
ISpace["Message"].Value=@"Submitted Successfully";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Submitted Successfully"";");
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

var querySourceD659A8A182614852878E8F0B73B79721 =GetQueryExpressionDataSource("D659A8A1-8261-4852-878E-8F0B73B79721");

DataTable resultD659A8A182614852878E8F0B73B79721=iSpace.SetGridDataSource(querySourceD659A8A182614852878E8F0B73B79721, _objectFactory.GetGridRPP("TravelExpense"),@"EXEC AddFormGridData374fb8a88dd94cf1bf73f40ae18fcad7 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["MFG_T2_TADetailsID"].Value + @"','" + ISpace["MFG_T2_TravelAdvanceID"].Value + @"','" + ISpace["MFG_T2_Departure"].Value + @"','" + ISpace["MFG_T2_DepartureDate"].Value + @"','" + ISpace["MFG_T2_DepartureTime"].Value + @"','" + ISpace["MFG_T2_Arrival"].Value + @"','" + ISpace["MFG_T2_ArrivalDate"].Value + @"','" + ISpace["MFG_T2_ArrivalTime"].Value + @"','" + ISpace["MFG_T2_ModeofJourney"].Value + @"','" + ISpace["MFG_T2_JourneyClass"].Value + @"'," + ISpace["MFG_T2_Road"].Value + @",'" + ISpace["MFG_T2_PNRNo"].Value + @"'," + ISpace["MFG_T2_Amount"].Value + @",'" + ISpace["growid"].Value + @"'");

iSpace.InsertGridBindDetails("TravelExpense","11",querySourceD659A8A182614852878E8F0B73B79721,"EXEC AddFormGridData374fb8a88dd94cf1bf73f40ae18fcad7 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["MFG_T2_TADetailsID"].Value + @"','" + ISpace["MFG_T2_TravelAdvanceID"].Value + @"','" + ISpace["MFG_T2_Departure"].Value + @"','" + ISpace["MFG_T2_DepartureDate"].Value + @"','" + ISpace["MFG_T2_DepartureTime"].Value + @"','" + ISpace["MFG_T2_Arrival"].Value + @"','" + ISpace["MFG_T2_ArrivalDate"].Value + @"','" + ISpace["MFG_T2_ArrivalTime"].Value + @"','" + ISpace["MFG_T2_ModeofJourney"].Value + @"','" + ISpace["MFG_T2_JourneyClass"].Value + @"'," + ISpace["MFG_T2_Road"].Value + @",'" + ISpace["MFG_T2_PNRNo"].Value + @"'," + ISpace["MFG_T2_Amount"].Value + @",'" + ISpace["growid"].Value + @"'",_objectFactory.GetGridRPP("TravelExpense"));

base.WriteDebugInfo(@"var querySourceD659A8A182614852878E8F0B73B79721 =GetQueryExpressionDataSource(""D659A8A1-8261-4852-878E-8F0B73B79721"");DataTable resultD659A8A182614852878E8F0B73B79721=iSpace.SetGridDataSource(querySourceD659A8A182614852878E8F0B73B79721, _objectFactory.GetGridRPP(""TravelExpense""),@""EXEC AddFormGridData374fb8a88dd94cf1bf73f40ae18fcad7 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""MFG_T2_TADetailsID""].Value + @""','"" + ISpace[""MFG_T2_TravelAdvanceID""].Value + @""','"" + ISpace[""MFG_T2_Departure""].Value + @""','"" + ISpace[""MFG_T2_DepartureDate""].Value + @""','"" + ISpace[""MFG_T2_DepartureTime""].Value + @""','"" + ISpace[""MFG_T2_Arrival""].Value + @""','"" + ISpace[""MFG_T2_ArrivalDate""].Value + @""','"" + ISpace[""MFG_T2_ArrivalTime""].Value + @""','"" + ISpace[""MFG_T2_ModeofJourney""].Value + @""','"" + ISpace[""MFG_T2_JourneyClass""].Value + @""',"" + ISpace[""MFG_T2_Road""].Value + @"",'"" + ISpace[""MFG_T2_PNRNo""].Value + @""',"" + ISpace[""MFG_T2_Amount""].Value + @"",'"" + ISpace[""growid""].Value + @""'"");iSpace.InsertGridBindDetails(""TravelExpense"",""11"",querySourceD659A8A182614852878E8F0B73B79721,""EXEC AddFormGridData374fb8a88dd94cf1bf73f40ae18fcad7 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""MFG_T2_TADetailsID""].Value + @""','"" + ISpace[""MFG_T2_TravelAdvanceID""].Value + @""','"" + ISpace[""MFG_T2_Departure""].Value + @""','"" + ISpace[""MFG_T2_DepartureDate""].Value + @""','"" + ISpace[""MFG_T2_DepartureTime""].Value + @""','"" + ISpace[""MFG_T2_Arrival""].Value + @""','"" + ISpace[""MFG_T2_ArrivalDate""].Value + @""','"" + ISpace[""MFG_T2_ArrivalTime""].Value + @""','"" + ISpace[""MFG_T2_ModeofJourney""].Value + @""','"" + ISpace[""MFG_T2_JourneyClass""].Value + @""',"" + ISpace[""MFG_T2_Road""].Value + @"",'"" + ISpace[""MFG_T2_PNRNo""].Value + @""',"" + ISpace[""MFG_T2_Amount""].Value + @"",'"" + ISpace[""growid""].Value + @""'"",_objectFactory.GetGridRPP(""TravelExpense""));");
base.WriteDebugInfo(@"EXEC AddFormGridData374fb8a88dd94cf1bf73f40ae18fcad7 '@@gv_InstanceId','@@gv_ProcessMapId','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','@@gv_ActivityMapId','#MFG_T2_TADetailsID','#MFG_T2_TravelAdvanceID','#MFG_T2_Departure','#MFG_T2_DepartureDate','#MFG_T2_DepartureTime','#MFG_T2_Arrival','#MFG_T2_ArrivalDate','#MFG_T2_ArrivalTime','#MFG_T2_ModeofJourney','#MFG_T2_JourneyClass',#MFG_T2_Road,'#MFG_T2_PNRNo',#MFG_T3_Amount,'#growid'");


List<Triplet<string, short, short?>> result8F99128D9EF74BCF8A425714C2D6D166=acdataIspaceCFA9B7B28CF54389B2038EA7C779EE9A.GetQueryExpressionBindings("8F99128D-9EF7-4BCF-8A42-5714C2D6D166");
iSpace.SetGridData(resultD659A8A182614852878E8F0B73B79721,result8F99128D9EF74BCF8A425714C2D6D166,"TravelExpense",ref ISpace);
iSpace.UpdateGridBindDetails("TravelExpense",result8F99128D9EF74BCF8A425714C2D6D166);
}
else
{
base.WriteDebugInfo(@"else");

var querySourceAFBC2448576140CFA8EB1C60C3DC33D1 =GetQueryExpressionDataSource("AFBC2448-5761-40CF-A8EB-1C60C3DC33D1");

DataTable resultAFBC2448576140CFA8EB1C60C3DC33D1=iSpace.SetGridDataSource(querySourceAFBC2448576140CFA8EB1C60C3DC33D1, _objectFactory.GetGridRPP("TravelExpense"),@"EXEC UpdateFormGridData374fb8a88dd94cf1bf73f40ae18fcad7 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["MFG_T2_TADetailsID"].Value + @"','" + ISpace["MFG_T2_TravelAdvanceID"].Value + @"','" + ISpace["MFG_T2_Departure"].Value + @"','" + ISpace["MFG_T2_DepartureDate"].Value + @"','" + ISpace["MFG_T2_DepartureTime"].Value + @"','" + ISpace["MFG_T2_Arrival"].Value + @"','" + ISpace["MFG_T2_ArrivalDate"].Value + @"','" + ISpace["MFG_T2_ArrivalTime"].Value + @"','" + ISpace["MFG_T2_ModeofJourney"].Value + @"','" + ISpace["MFG_T2_JourneyClass"].Value + @"'," + ISpace["MFG_T2_Road"].Value + @",'" + ISpace["MFG_T2_PNRNo"].Value + @"'," + ISpace["MFG_T2_Amount"].Value + @",'" + ISpace["growid"].Value + @"'");

iSpace.InsertGridBindDetails("TravelExpense","11",querySourceAFBC2448576140CFA8EB1C60C3DC33D1,"EXEC UpdateFormGridData374fb8a88dd94cf1bf73f40ae18fcad7 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["MFG_T2_TADetailsID"].Value + @"','" + ISpace["MFG_T2_TravelAdvanceID"].Value + @"','" + ISpace["MFG_T2_Departure"].Value + @"','" + ISpace["MFG_T2_DepartureDate"].Value + @"','" + ISpace["MFG_T2_DepartureTime"].Value + @"','" + ISpace["MFG_T2_Arrival"].Value + @"','" + ISpace["MFG_T2_ArrivalDate"].Value + @"','" + ISpace["MFG_T2_ArrivalTime"].Value + @"','" + ISpace["MFG_T2_ModeofJourney"].Value + @"','" + ISpace["MFG_T2_JourneyClass"].Value + @"'," + ISpace["MFG_T2_Road"].Value + @",'" + ISpace["MFG_T2_PNRNo"].Value + @"'," + ISpace["MFG_T2_Amount"].Value + @",'" + ISpace["growid"].Value + @"'",_objectFactory.GetGridRPP("TravelExpense"));

base.WriteDebugInfo(@"var querySourceAFBC2448576140CFA8EB1C60C3DC33D1 =GetQueryExpressionDataSource(""AFBC2448-5761-40CF-A8EB-1C60C3DC33D1"");DataTable resultAFBC2448576140CFA8EB1C60C3DC33D1=iSpace.SetGridDataSource(querySourceAFBC2448576140CFA8EB1C60C3DC33D1, _objectFactory.GetGridRPP(""TravelExpense""),@""EXEC UpdateFormGridData374fb8a88dd94cf1bf73f40ae18fcad7 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""MFG_T2_TADetailsID""].Value + @""','"" + ISpace[""MFG_T2_TravelAdvanceID""].Value + @""','"" + ISpace[""MFG_T2_Departure""].Value + @""','"" + ISpace[""MFG_T2_DepartureDate""].Value + @""','"" + ISpace[""MFG_T2_DepartureTime""].Value + @""','"" + ISpace[""MFG_T2_Arrival""].Value + @""','"" + ISpace[""MFG_T2_ArrivalDate""].Value + @""','"" + ISpace[""MFG_T2_ArrivalTime""].Value + @""','"" + ISpace[""MFG_T2_ModeofJourney""].Value + @""','"" + ISpace[""MFG_T2_JourneyClass""].Value + @""',"" + ISpace[""MFG_T2_Road""].Value + @"",'"" + ISpace[""MFG_T2_PNRNo""].Value + @""',"" + ISpace[""MFG_T2_Amount""].Value + @"",'"" + ISpace[""growid""].Value + @""'"");iSpace.InsertGridBindDetails(""TravelExpense"",""11"",querySourceAFBC2448576140CFA8EB1C60C3DC33D1,""EXEC UpdateFormGridData374fb8a88dd94cf1bf73f40ae18fcad7 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""MFG_T2_TADetailsID""].Value + @""','"" + ISpace[""MFG_T2_TravelAdvanceID""].Value + @""','"" + ISpace[""MFG_T2_Departure""].Value + @""','"" + ISpace[""MFG_T2_DepartureDate""].Value + @""','"" + ISpace[""MFG_T2_DepartureTime""].Value + @""','"" + ISpace[""MFG_T2_Arrival""].Value + @""','"" + ISpace[""MFG_T2_ArrivalDate""].Value + @""','"" + ISpace[""MFG_T2_ArrivalTime""].Value + @""','"" + ISpace[""MFG_T2_ModeofJourney""].Value + @""','"" + ISpace[""MFG_T2_JourneyClass""].Value + @""',"" + ISpace[""MFG_T2_Road""].Value + @"",'"" + ISpace[""MFG_T2_PNRNo""].Value + @""',"" + ISpace[""MFG_T2_Amount""].Value + @"",'"" + ISpace[""growid""].Value + @""'"",_objectFactory.GetGridRPP(""TravelExpense""));");
base.WriteDebugInfo(@"EXEC UpdateFormGridData374fb8a88dd94cf1bf73f40ae18fcad7 '@@gv_InstanceId','@@gv_ProcessMapId','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','@@gv_ActivityMapId','#MFG_T2_TADetailsID','#MFG_T2_TravelAdvanceID','#MFG_T2_Departure','#MFG_T2_DepartureDate','#MFG_T2_DepartureTime','#MFG_T2_Arrival','#MFG_T2_ArrivalDate','#MFG_T2_ArrivalTime','#MFG_T2_ModeofJourney','#MFG_T2_JourneyClass',#MFG_T2_Road,'#MFG_T2_PNRNo',#MFG_T3_Amount,'#growid'");


List<Triplet<string, short, short?>> result49C758C3CB9E452A80535E2651156E3D=acdataIspaceCFA9B7B28CF54389B2038EA7C779EE9A.GetQueryExpressionBindings("49C758C3-CB9E-452A-8053-5E2651156E3D");
iSpace.SetGridData(resultAFBC2448576140CFA8EB1C60C3DC33D1,result49C758C3CB9E452A80535E2651156E3D,"TravelExpense",ref ISpace);
iSpace.UpdateGridBindDetails("TravelExpense",result49C758C3CB9E452A80535E2651156E3D);
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
private void SubscribeElementEvents_edit_travelexpense (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Edit_TravelExpense-OnClick");
ISpace["growid"].Value=ISpace["TravelExpense_RowId"].Value;
base.WriteDebugInfo(@"ISpace[""growid""].Value=ISpace[""TravelExpense_RowId""].Value;");
base.WriteDebugInfo(@"EXEC LoadFormGridData374fb8a88dd94cf1bf73f40ae18fcad7 '@@gv_InstanceId','@@gv_ProcessMapId','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','@@gv_ActivityMapId','#growid'");

var querySource2ACCBC572E9C4A0FBD46FAB4E50951D4 =GetQueryExpressionDataSource("2ACCBC57-2E9C-4A0F-BD46-FAB4E50951D4");
Dictionary<short,object> result2ACCBC572E9C4A0FBD46FAB4E50951D4=iSpace.ExecuteQuery(querySource2ACCBC572E9C4A0FBD46FAB4E50951D4,@"EXEC LoadFormGridData374fb8a88dd94cf1bf73f40ae18fcad7 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["growid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource2ACCBC572E9C4A0FBD46FAB4E50951D4 =GetQueryExpressionDataSource(""2ACCBC57-2E9C-4A0F-BD46-FAB4E50951D4"");Dictionary<short,object> result2ACCBC572E9C4A0FBD46FAB4E50951D4=iSpace.ExecuteQuery(querySource2ACCBC572E9C4A0FBD46FAB4E50951D4,@""EXEC LoadFormGridData374fb8a88dd94cf1bf73f40ae18fcad7 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""growid""].Value + @""'"",false);");
base.WriteDebugInfo(@"EXEC LoadFormGridData374fb8a88dd94cf1bf73f40ae18fcad7 '@@gv_InstanceId','@@gv_ProcessMapId','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','@@gv_ActivityMapId','#growid'");

if((result2ACCBC572E9C4A0FBD46FAB4E50951D4!=null) && (result2ACCBC572E9C4A0FBD46FAB4E50951D4.Count!=0))
{
if(result2ACCBC572E9C4A0FBD46FAB4E50951D4.ContainsKey(3))
ISpace["MFG_T2_DepartureDate"].Value = result2ACCBC572E9C4A0FBD46FAB4E50951D4[3];
if(result2ACCBC572E9C4A0FBD46FAB4E50951D4.ContainsKey(6))
ISpace["MFG_T2_ArrivalDate"].Value = result2ACCBC572E9C4A0FBD46FAB4E50951D4[6];
if(result2ACCBC572E9C4A0FBD46FAB4E50951D4.ContainsKey(8))
ISpace["MFG_T2_ModeofJourney"].Value = result2ACCBC572E9C4A0FBD46FAB4E50951D4[8];
if(result2ACCBC572E9C4A0FBD46FAB4E50951D4.ContainsKey(9))
ISpace["MFG_T2_JourneyClass"].Value = result2ACCBC572E9C4A0FBD46FAB4E50951D4[9];
if(result2ACCBC572E9C4A0FBD46FAB4E50951D4.ContainsKey(12))
ISpace["MFG_T2_Amount"].Value = result2ACCBC572E9C4A0FBD46FAB4E50951D4[12];
if(result2ACCBC572E9C4A0FBD46FAB4E50951D4.ContainsKey(10))
ISpace["MFG_T2_Road"].Value = result2ACCBC572E9C4A0FBD46FAB4E50951D4[10];
if(result2ACCBC572E9C4A0FBD46FAB4E50951D4.ContainsKey(11))
ISpace["MFG_T2_PNRNo"].Value = result2ACCBC572E9C4A0FBD46FAB4E50951D4[11];
if(result2ACCBC572E9C4A0FBD46FAB4E50951D4.ContainsKey(4))
ISpace["MFG_T2_DepartureTime"].Value = result2ACCBC572E9C4A0FBD46FAB4E50951D4[4];
if(result2ACCBC572E9C4A0FBD46FAB4E50951D4.ContainsKey(0))
ISpace["MFG_T2_TADetailsID"].Value = result2ACCBC572E9C4A0FBD46FAB4E50951D4[0];
if(result2ACCBC572E9C4A0FBD46FAB4E50951D4.ContainsKey(7))
ISpace["MFG_T2_ArrivalTime"].Value = result2ACCBC572E9C4A0FBD46FAB4E50951D4[7];
if(result2ACCBC572E9C4A0FBD46FAB4E50951D4.ContainsKey(5))
ISpace["MFG_T2_Arrival"].Value = result2ACCBC572E9C4A0FBD46FAB4E50951D4[5];
if(result2ACCBC572E9C4A0FBD46FAB4E50951D4.ContainsKey(2))
ISpace["MFG_T2_Departure"].Value = result2ACCBC572E9C4A0FBD46FAB4E50951D4[2];
if(result2ACCBC572E9C4A0FBD46FAB4E50951D4.ContainsKey(1))
ISpace["MFG_T2_TravelAdvanceID"].Value = result2ACCBC572E9C4A0FBD46FAB4E50951D4[1];
}
else{
ISpace["MFG_T2_DepartureDate"].Value = null;ISpace["MFG_T2_ArrivalDate"].Value = null;ISpace["MFG_T2_ModeofJourney"].Value = null;ISpace["MFG_T2_JourneyClass"].Value = null;ISpace["MFG_T2_Amount"].Value = null;ISpace["MFG_T2_Road"].Value = null;ISpace["MFG_T2_PNRNo"].Value = null;ISpace["MFG_T2_DepartureTime"].Value = null;ISpace["MFG_T2_TADetailsID"].Value = null;ISpace["MFG_T2_ArrivalTime"].Value = null;ISpace["MFG_T2_Arrival"].Value = null;ISpace["MFG_T2_Departure"].Value = null;ISpace["MFG_T2_TravelAdvanceID"].Value = null;
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

var querySource4DA95BD5CD3F4A6D8AE54C8A839E94D6 =GetQueryExpressionDataSource("4DA95BD5-CD3F-4A6D-8AE5-4C8A839E94D6");
Dictionary<short,object> result4DA95BD5CD3F4A6D8AE54C8A839E94D6=iSpace.ExecuteQuery(querySource4DA95BD5CD3F4A6D8AE54C8A839E94D6,@"Exec GetStageStatus 1,'','','" + ISpace["M_MoveToValue"].Value + @"','" + ISpace["M_SourceActivityMapId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource4DA95BD5CD3F4A6D8AE54C8A839E94D6 =GetQueryExpressionDataSource(""4DA95BD5-CD3F-4A6D-8AE5-4C8A839E94D6"");Dictionary<short,object> result4DA95BD5CD3F4A6D8AE54C8A839E94D6=iSpace.ExecuteQuery(querySource4DA95BD5CD3F4A6D8AE54C8A839E94D6,@""Exec GetStageStatus 1,'','','"" + ISpace[""M_MoveToValue""].Value + @""','"" + ISpace[""M_SourceActivityMapId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result4DA95BD5CD3F4A6D8AE54C8A839E94D6!=null) && (result4DA95BD5CD3F4A6D8AE54C8A839E94D6.Count!=0))
{
if(result4DA95BD5CD3F4A6D8AE54C8A839E94D6.ContainsKey(5))
ISpace["M_IsFlowReturned"].Value = result4DA95BD5CD3F4A6D8AE54C8A839E94D6[5];
if(result4DA95BD5CD3F4A6D8AE54C8A839E94D6.ContainsKey(6))
ISpace["M_IsCancelReject"].Value = result4DA95BD5CD3F4A6D8AE54C8A839E94D6[6];
if(result4DA95BD5CD3F4A6D8AE54C8A839E94D6.ContainsKey(4))
ISpace["M_FieldMandatory"].Value = result4DA95BD5CD3F4A6D8AE54C8A839E94D6[4];
if(result4DA95BD5CD3F4A6D8AE54C8A839E94D6.ContainsKey(1))
ISpace["M_RemarksMandatory"].Value = result4DA95BD5CD3F4A6D8AE54C8A839E94D6[1];
if(result4DA95BD5CD3F4A6D8AE54C8A839E94D6.ContainsKey(3))
ISpace["M_SaveDomainData"].Value = result4DA95BD5CD3F4A6D8AE54C8A839E94D6[3];
if(result4DA95BD5CD3F4A6D8AE54C8A839E94D6.ContainsKey(2))
ISpace["M_Remarks"].Value = result4DA95BD5CD3F4A6D8AE54C8A839E94D6[2];
if(result4DA95BD5CD3F4A6D8AE54C8A839E94D6.ContainsKey(0))
ISpace["M_NextStage"].Value = result4DA95BD5CD3F4A6D8AE54C8A839E94D6[0];
}
else{
ISpace["M_IsFlowReturned"].Value = null;ISpace["M_IsCancelReject"].Value = null;ISpace["M_FieldMandatory"].Value = null;ISpace["M_RemarksMandatory"].Value = null;ISpace["M_SaveDomainData"].Value = null;ISpace["M_Remarks"].Value = null;ISpace["M_NextStage"].Value = null;
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
		if(elementName.ToLower().Equals("save_travelexpense"))
{
			SubscribeElementEvents_save_travelexpense(ref dfsParam);
}
		if(elementName.ToLower().Equals("edit_travelexpense"))
{
			SubscribeElementEvents_edit_travelexpense(ref dfsParam);
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
public class ISpaceC9900B03EFE6417C9C4EA09EA54B60FD : VirtualForm
{
IISpace iSpace = new ISpace();
AcDataISpaceC9900B03EFE6417C9C4EA09EA54B60FD acdataIspaceC9900B03EFE6417C9C4EA09EA54B60FD=new AcDataISpaceC9900B03EFE6417C9C4EA09EA54B60FD();
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
ISpace["M_TravelInstanceId"].Value=Guid.NewGuid().ToString();
base.WriteDebugInfo(@"ISpace[""M_TravelInstanceId""].Value=Guid.NewGuid().ToString();");
ISpace["M_MoveTo"].Man=true;
base.WriteDebugInfo(@"ISpace[""M_MoveTo""].Man=true;");
ISpace["M_Remarks"].Value="";
base.WriteDebugInfo(@"ISpace[""M_Remarks""].Value="""";");
ISpace["M_NextStage"].Value="";
base.WriteDebugInfo(@"ISpace[""M_NextStage""].Value="""";");
ISpace["MF_TransactionDate"].Man=true;ISpace["MF_TransactionNo"].Man=true;
base.WriteDebugInfo(@"ISpace[""MF_TransactionDate""].Man=true;ISpace[""MF_TransactionNo""].Man=true;");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySourceA0ECD2B8980941FB814ECFF85B9E0A09 =GetQueryExpressionDataSource("A0ECD2B8-9809-41FB-814E-CFF85B9E0A09");

DataTable resultA0ECD2B8980941FB814ECFF85B9E0A09=iSpace.SetGridDataSource(querySourceA0ECD2B8980941FB814ECFF85B9E0A09, _objectFactory.GetGridRPP("MG_RemarksDetails"),@"EXEC GetRemarks '" + ISpace["M_InstanceId"].Value + @"'");

iSpace.InsertGridBindDetails("MG_RemarksDetails","11",querySourceA0ECD2B8980941FB814ECFF85B9E0A09,"EXEC GetRemarks '" + ISpace["M_InstanceId"].Value + @"'",_objectFactory.GetGridRPP("MG_RemarksDetails"));

base.WriteDebugInfo(@"var querySourceA0ECD2B8980941FB814ECFF85B9E0A09 =GetQueryExpressionDataSource(""A0ECD2B8-9809-41FB-814E-CFF85B9E0A09"");DataTable resultA0ECD2B8980941FB814ECFF85B9E0A09=iSpace.SetGridDataSource(querySourceA0ECD2B8980941FB814ECFF85B9E0A09, _objectFactory.GetGridRPP(""MG_RemarksDetails""),@""EXEC GetRemarks '"" + ISpace[""M_InstanceId""].Value + @""'"");iSpace.InsertGridBindDetails(""MG_RemarksDetails"",""11"",querySourceA0ECD2B8980941FB814ECFF85B9E0A09,""EXEC GetRemarks '"" + ISpace[""M_InstanceId""].Value + @""'"",_objectFactory.GetGridRPP(""MG_RemarksDetails""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> resultCBD3E108E08C4B5F8ACA817E51BDACD4=acdataIspaceC9900B03EFE6417C9C4EA09EA54B60FD.GetQueryExpressionBindings("CBD3E108-E08C-4B5F-8ACA-817E51BDACD4");
iSpace.SetGridData(resultA0ECD2B8980941FB814ECFF85B9E0A09,resultCBD3E108E08C4B5F8ACA817E51BDACD4,"MG_RemarksDetails",ref ISpace);
iSpace.UpdateGridBindDetails("MG_RemarksDetails",resultCBD3E108E08C4B5F8ACA817E51BDACD4);
}
ISpace["UC_DOJ"].Visible="false";ISpace["UC_EmailId"].Visible="false";ISpace["UC_PhoneNumber"].Visible="false";ISpace["UC_DOB"].Visible="false";ISpace["UC_Grade"].Visible="false";ISpace["UC_DOR"].Visible="false";ISpace["UC_Paylevel"].Visible="false";
base.WriteDebugInfo(@"ISpace[""UC_DOJ""].Visible=""false"";ISpace[""UC_EmailId""].Visible=""false"";ISpace[""UC_PhoneNumber""].Visible=""false"";ISpace[""UC_DOB""].Visible=""false"";ISpace[""UC_Grade""].Visible=""false"";ISpace[""UC_DOR""].Visible=""false"";ISpace[""UC_Paylevel""].Visible=""false"";");
if(ISpace["Travel_Type"].Value=="1")
{
base.WriteDebugInfo(@"if(ISpace[""Travel_Type""].Value==""1"")");
ISpace["MF_T1_AccountNo"].Man=false;ISpace["MF_T1_BankBranch"].Man=false;ISpace["MF_T1_BeneficiaryName"].Man=false;ISpace["MF_T1_BankDocument"].Man=false;ISpace["MF_T1_BankName"].Man=false;
base.WriteDebugInfo(@"ISpace[""MF_T1_AccountNo""].Man=false;ISpace[""MF_T1_BankBranch""].Man=false;ISpace[""MF_T1_BeneficiaryName""].Man=false;ISpace[""MF_T1_BankDocument""].Man=false;ISpace[""MF_T1_BankName""].Man=false;");
}
if(ISpace["Travel_Type"].Value=="3")
{
base.WriteDebugInfo(@"if(ISpace[""Travel_Type""].Value==""3"")");
ISpace["MF_T1_AccountNo"].Man=true;ISpace["MF_T1_AccountNo"].Enbl="true";ISpace["MF_T1_BankBranch"].Man=true;ISpace["MF_T1_BankBranch"].Enbl="true";ISpace["MF_T1_AdvanceAmount"].Man=true;ISpace["MF_T1_AdvanceAmount"].Enbl="true";ISpace["MF_T1_BeneficiaryName"].Man=true;ISpace["MF_T1_BeneficiaryName"].Enbl="true";ISpace["MF_T1_BankDocument"].Man=true;ISpace["MF_T1_BankDocument"].Enbl="true";ISpace["MF_T1_BankName"].Man=true;ISpace["MF_T1_BankName"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_T1_AccountNo""].Man=true;ISpace[""MF_T1_AccountNo""].Enbl=""true"";ISpace[""MF_T1_BankBranch""].Man=true;ISpace[""MF_T1_BankBranch""].Enbl=""true"";ISpace[""MF_T1_AdvanceAmount""].Man=true;ISpace[""MF_T1_AdvanceAmount""].Enbl=""true"";ISpace[""MF_T1_BeneficiaryName""].Man=true;ISpace[""MF_T1_BeneficiaryName""].Enbl=""true"";ISpace[""MF_T1_BankDocument""].Man=true;ISpace[""MF_T1_BankDocument""].Enbl=""true"";ISpace[""MF_T1_BankName""].Man=true;ISpace[""MF_T1_BankName""].Enbl=""true"";");
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
return;
base.WriteDebugInfo(@"return;");
}
ISpace["MF_TravelStatus"].Value="A";
base.WriteDebugInfo(@"ISpace[""MF_TravelStatus""].Value=""A"";");
ISpace["M_IsCommitment"].Value=0;
base.WriteDebugInfo(@"ISpace[""M_IsCommitment""].Value=0;");
if(ISpace["M_SaveDomainData"].Value==1||1==1)
{
base.WriteDebugInfo(@"if(ISpace[""M_SaveDomainData""].Value==1||1==1)");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC Repo198E5A8A61F54E7C92DD34146A7059EF '#CreatedOn','#MF_T1_BankDocument','#MF_T1_ReferenceNo','#MF_T1_AccountNo','#OverAll_Total','#UC_EmployeeBaicInfoId','#M_TravelPlace','#MF_T1_AdvanceAmount','#MF_T1_BankName','#MF_T1_TravelAdvanceID','#MF_T1_JourneyPurpose','#Travel_Type','#MF_T1_BeneficiaryName','#gv_UserId','#MF_TransactionNo','#MF_TravelStatus','#MF_TransactionDate','#M_IsAdvanceRequired'");

var querySourceD16F9C83EA714542AB4DE3D99AB969B2 =GetQueryExpressionDataSource("D16F9C83-EA71-4542-AB4D-E3D99AB969B2");
Dictionary<short,object> resultD16F9C83EA714542AB4DE3D99AB969B2=iSpace.ExecuteQuery(querySourceD16F9C83EA714542AB4DE3D99AB969B2,@"EXEC Repo198E5A8A61F54E7C92DD34146A7059EF '" + ISpace["CreatedOn"].Value + @"','" + ISpace["MF_T1_BankDocument"].Value + @"','" + ISpace["MF_T1_ReferenceNo"].Value + @"','" + ISpace["MF_T1_AccountNo"].Value + @"','" + ISpace["OverAll_Total"].Value + @"','" + ISpace["UC_EmployeeBaicInfoId"].Value + @"','" + ISpace["M_TravelPlace"].Value + @"','" + ISpace["MF_T1_AdvanceAmount"].Value + @"','" + ISpace["MF_T1_BankName"].Value + @"','" + ISpace["MF_T1_TravelAdvanceID"].Value + @"','" + ISpace["MF_T1_JourneyPurpose"].Value + @"','" + ISpace["Travel_Type"].Value + @"','" + ISpace["MF_T1_BeneficiaryName"].Value + @"','" + ISpace["gv_UserId"].Value + @"','" + ISpace["MF_TransactionNo"].Value + @"','" + ISpace["MF_TravelStatus"].Value + @"','" + ISpace["MF_TransactionDate"].Value + @"','" + ISpace["M_IsAdvanceRequired"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceD16F9C83EA714542AB4DE3D99AB969B2 =GetQueryExpressionDataSource(""D16F9C83-EA71-4542-AB4D-E3D99AB969B2"");Dictionary<short,object> resultD16F9C83EA714542AB4DE3D99AB969B2=iSpace.ExecuteQuery(querySourceD16F9C83EA714542AB4DE3D99AB969B2,@""EXEC Repo198E5A8A61F54E7C92DD34146A7059EF '"" + ISpace[""CreatedOn""].Value + @""','"" + ISpace[""MF_T1_BankDocument""].Value + @""','"" + ISpace[""MF_T1_ReferenceNo""].Value + @""','"" + ISpace[""MF_T1_AccountNo""].Value + @""','"" + ISpace[""OverAll_Total""].Value + @""','"" + ISpace[""UC_EmployeeBaicInfoId""].Value + @""','"" + ISpace[""M_TravelPlace""].Value + @""','"" + ISpace[""MF_T1_AdvanceAmount""].Value + @""','"" + ISpace[""MF_T1_BankName""].Value + @""','"" + ISpace[""MF_T1_TravelAdvanceID""].Value + @""','"" + ISpace[""MF_T1_JourneyPurpose""].Value + @""','"" + ISpace[""Travel_Type""].Value + @""','"" + ISpace[""MF_T1_BeneficiaryName""].Value + @""','"" + ISpace[""gv_UserId""].Value + @""','"" + ISpace[""MF_TransactionNo""].Value + @""','"" + ISpace[""MF_TravelStatus""].Value + @""','"" + ISpace[""MF_TransactionDate""].Value + @""','"" + ISpace[""M_IsAdvanceRequired""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultD16F9C83EA714542AB4DE3D99AB969B2!=null) && (resultD16F9C83EA714542AB4DE3D99AB969B2.Count!=0))
{
}
else{

}
base.WriteDebugInfo(@"EXEC Repo51838b372ec64d358a5e38648bc93ab1 '#gv_UserId','#UpdatedOn','#MF_T1_TravelAdvanceID','#MG_T2_ToDate','#MG_T2_FromDate','#M_IsTravelRequest','#MG_T2_ExpenditureTypeID','#Expenditure_Type','#MG_T3_Amount'");

var querySource864963C6427C451F8C30D7E8FCDD4228 =GetQueryExpressionDataSource("864963C6-427C-451F-8C30-D7E8FCDD4228");
Dictionary<short,object> result864963C6427C451F8C30D7E8FCDD4228=iSpace.ExecuteQuery(querySource864963C6427C451F8C30D7E8FCDD4228,@"EXEC Repo51838b372ec64d358a5e38648bc93ab1 '" + ISpace["gv_UserId"].Value + @"','" + ISpace["UpdatedOn"].Value + @"','" + ISpace["MF_T1_TravelAdvanceID"].Value + @"','" + ISpace["MG_T2_ToDate"].Value + @"','" + ISpace["MG_T2_FromDate"].Value + @"','" + ISpace["M_IsTravelRequest"].Value + @"','" + ISpace["MG_T2_ExpenditureTypeID"].Value + @"','" + ISpace["Expenditure_Type"].Value + @"','" + ISpace["MG_T3_Amount"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource864963C6427C451F8C30D7E8FCDD4228 =GetQueryExpressionDataSource(""864963C6-427C-451F-8C30-D7E8FCDD4228"");Dictionary<short,object> result864963C6427C451F8C30D7E8FCDD4228=iSpace.ExecuteQuery(querySource864963C6427C451F8C30D7E8FCDD4228,@""EXEC Repo51838b372ec64d358a5e38648bc93ab1 '"" + ISpace[""gv_UserId""].Value + @""','"" + ISpace[""UpdatedOn""].Value + @""','"" + ISpace[""MF_T1_TravelAdvanceID""].Value + @""','"" + ISpace[""MG_T2_ToDate""].Value + @""','"" + ISpace[""MG_T2_FromDate""].Value + @""','"" + ISpace[""M_IsTravelRequest""].Value + @""','"" + ISpace[""MG_T2_ExpenditureTypeID""].Value + @""','"" + ISpace[""Expenditure_Type""].Value + @""','"" + ISpace[""MG_T3_Amount""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result864963C6427C451F8C30D7E8FCDD4228!=null) && (result864963C6427C451F8C30D7E8FCDD4228.Count!=0))
{
}
else{

}
base.WriteDebugInfo(@"EXEC Repo374fb8a88dd94cf1bf73f40ae18fcad7 '#M_IsTravelRequest','#UpdatedOn','#MG_T2_TADetailsID','#gv_UserId','#MG_T2_DepartureDate','#MG_T2_DepartureTime','#MG_T2_ArrivalDate','#MG_T2_Road','#MF_T1_TravelAdvanceID','#MG_T2_Departure','#MG_T2_Amount','#MG_T2_JourneyClass','#MG_T2_Arrival','#MG_T2_PNRNo','#MG_T2_ModeofJourney','#MG_T2_ArrivalTime'");

var querySourceEBE446FD1D9E41DEB663DEAA6EE73345 =GetQueryExpressionDataSource("EBE446FD-1D9E-41DE-B663-DEAA6EE73345");
Dictionary<short,object> resultEBE446FD1D9E41DEB663DEAA6EE73345=iSpace.ExecuteQuery(querySourceEBE446FD1D9E41DEB663DEAA6EE73345,@"EXEC Repo374fb8a88dd94cf1bf73f40ae18fcad7 '" + ISpace["M_IsTravelRequest"].Value + @"','" + ISpace["UpdatedOn"].Value + @"','" + ISpace["MG_T2_TADetailsID"].Value + @"','" + ISpace["gv_UserId"].Value + @"','" + ISpace["MG_T2_DepartureDate"].Value + @"','" + ISpace["MG_T2_DepartureTime"].Value + @"','" + ISpace["MG_T2_ArrivalDate"].Value + @"','" + ISpace["MG_T2_Road"].Value + @"','" + ISpace["MF_T1_TravelAdvanceID"].Value + @"','" + ISpace["MG_T2_Departure"].Value + @"','" + ISpace["MG_T2_Amount"].Value + @"','" + ISpace["MG_T2_JourneyClass"].Value + @"','" + ISpace["MG_T2_Arrival"].Value + @"','" + ISpace["MG_T2_PNRNo"].Value + @"','" + ISpace["MG_T2_ModeofJourney"].Value + @"','" + ISpace["MG_T2_ArrivalTime"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceEBE446FD1D9E41DEB663DEAA6EE73345 =GetQueryExpressionDataSource(""EBE446FD-1D9E-41DE-B663-DEAA6EE73345"");Dictionary<short,object> resultEBE446FD1D9E41DEB663DEAA6EE73345=iSpace.ExecuteQuery(querySourceEBE446FD1D9E41DEB663DEAA6EE73345,@""EXEC Repo374fb8a88dd94cf1bf73f40ae18fcad7 '"" + ISpace[""M_IsTravelRequest""].Value + @""','"" + ISpace[""UpdatedOn""].Value + @""','"" + ISpace[""MG_T2_TADetailsID""].Value + @""','"" + ISpace[""gv_UserId""].Value + @""','"" + ISpace[""MG_T2_DepartureDate""].Value + @""','"" + ISpace[""MG_T2_DepartureTime""].Value + @""','"" + ISpace[""MG_T2_ArrivalDate""].Value + @""','"" + ISpace[""MG_T2_Road""].Value + @""','"" + ISpace[""MF_T1_TravelAdvanceID""].Value + @""','"" + ISpace[""MG_T2_Departure""].Value + @""','"" + ISpace[""MG_T2_Amount""].Value + @""','"" + ISpace[""MG_T2_JourneyClass""].Value + @""','"" + ISpace[""MG_T2_Arrival""].Value + @""','"" + ISpace[""MG_T2_PNRNo""].Value + @""','"" + ISpace[""MG_T2_ModeofJourney""].Value + @""','"" + ISpace[""MG_T2_ArrivalTime""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultEBE446FD1D9E41DEB663DEAA6EE73345!=null) && (resultEBE446FD1D9E41DEB663DEAA6EE73345.Count!=0))
{
}
else{

}
base.WriteDebugInfo(@"EXEC DocumentsDomain '#M_DocumentDetailsId','#M_PackageProcessMapId','#UpdatedOn','#M_DocumentName','#gv_UserId','#M_UploadDcoument','#MF_T1_TravelAdvanceID'");

var querySource1D2378FB2963489899022B61F44BE0AD =GetQueryExpressionDataSource("1D2378FB-2963-4898-9902-2B61F44BE0AD");
Dictionary<short,object> result1D2378FB2963489899022B61F44BE0AD=iSpace.ExecuteQuery(querySource1D2378FB2963489899022B61F44BE0AD,@"EXEC DocumentsDomain '" + ISpace["M_DocumentDetailsId"].Value + @"','" + ISpace["M_PackageProcessMapId"].Value + @"','" + ISpace["UpdatedOn"].Value + @"','" + ISpace["M_DocumentName"].Value + @"','" + ISpace["gv_UserId"].Value + @"','" + ISpace["M_UploadDcoument"].Value + @"','" + ISpace["MF_T1_TravelAdvanceID"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource1D2378FB2963489899022B61F44BE0AD =GetQueryExpressionDataSource(""1D2378FB-2963-4898-9902-2B61F44BE0AD"");Dictionary<short,object> result1D2378FB2963489899022B61F44BE0AD=iSpace.ExecuteQuery(querySource1D2378FB2963489899022B61F44BE0AD,@""EXEC DocumentsDomain '"" + ISpace[""M_DocumentDetailsId""].Value + @""','"" + ISpace[""M_PackageProcessMapId""].Value + @""','"" + ISpace[""UpdatedOn""].Value + @""','"" + ISpace[""M_DocumentName""].Value + @""','"" + ISpace[""gv_UserId""].Value + @""','"" + ISpace[""M_UploadDcoument""].Value + @""','"" + ISpace[""MF_T1_TravelAdvanceID""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result1D2378FB2963489899022B61F44BE0AD!=null) && (result1D2378FB2963489899022B61F44BE0AD.Count!=0))
{
}
else{

}
base.WriteDebugInfo(@"#MF_FundAmount[rows]");
iSpace.GetLoopExpressionData("MF_FundAmount",ref ISpace);

foreach(var gridChild in ISpace["MF_FundAmount"].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 


if(
ISpace["MG_FundTypeId"].Value==1)
{
base.WriteDebugInfo(@"
if(
ISpace[""MG_FundTypeId""].Value==1)");
base.WriteDebugInfo(@"EXEC ProjectApprovalCommittmentDetails '#MG_Amount','#MF_T1_TravelAdvanceID','#MG_ProjectDetailsId','#MG_BudgetHead','#gv_ProcessMapId'");

var querySource4213CFEEA88E4B67BEECB0AEF4337465 =GetQueryExpressionDataSource("4213CFEE-A88E-4B67-BEEC-B0AEF4337465");
Dictionary<short,object> result4213CFEEA88E4B67BEECB0AEF4337465=iSpace.ExecuteQuery(querySource4213CFEEA88E4B67BEECB0AEF4337465,@"EXEC ProjectApprovalCommittmentDetails '" + ISpace["MG_Amount"].Value + @"','" + ISpace["MF_T1_TravelAdvanceID"].Value + @"','" + ISpace["MG_ProjectDetailsId"].Value + @"','" + ISpace["MG_BudgetHead"].Value + @"','" + ISpace["gv_ProcessMapId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource4213CFEEA88E4B67BEECB0AEF4337465 =GetQueryExpressionDataSource(""4213CFEE-A88E-4B67-BEEC-B0AEF4337465"");Dictionary<short,object> result4213CFEEA88E4B67BEECB0AEF4337465=iSpace.ExecuteQuery(querySource4213CFEEA88E4B67BEECB0AEF4337465,@""EXEC ProjectApprovalCommittmentDetails '"" + ISpace[""MG_Amount""].Value + @""','"" + ISpace[""MF_T1_TravelAdvanceID""].Value + @""','"" + ISpace[""MG_ProjectDetailsId""].Value + @""','"" + ISpace[""MG_BudgetHead""].Value + @""','"" + ISpace[""gv_ProcessMapId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result4213CFEEA88E4B67BEECB0AEF4337465!=null) && (result4213CFEEA88E4B67BEECB0AEF4337465.Count!=0))
{
}
else{

}
}
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("MF_FundAmount","AD9C54EC-27A0-4C21-9923-063084E3B588",_objectFactory.GetGridRPP("MF_FundAmount"),_elementBase.GetGridLoopQuery("AD9C54EC-27A0-4C21-9923-063084E3B588","MF_FundAmount",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""MF_FundAmount"",ref ISpace);

foreach(var gridChild in ISpace[""MF_FundAmount""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
}
if(1==2)
{
base.WriteDebugInfo(@"if(1==2)");
base.WriteDebugInfo(@"#MF_FundAmount[Rows]");
iSpace.GetLoopExpressionData("MF_FundAmount",ref ISpace);

foreach(var gridChild in ISpace["MF_FundAmount"].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 

base.WriteDebugInfo(@"EXEC UpsertProjectBudgetDetails 5,'#MG_ProjectDetailsId','#MF_T1_TravelAdvanceID','#MG_Amount','#MG_BudgetHead','1','#MG_FundTypeid','#M_PackageProcessMapId','#UC_EmployeeBaicInfoId'");

var querySourceEA86EC989465469D97F236E0D8B7BEB7 =GetQueryExpressionDataSource("EA86EC98-9465-469D-97F2-36E0D8B7BEB7");
Dictionary<short,object> resultEA86EC989465469D97F236E0D8B7BEB7=iSpace.ExecuteQuery(querySourceEA86EC989465469D97F236E0D8B7BEB7,@"EXEC UpsertProjectBudgetDetails 5,'" + ISpace["MG_ProjectDetailsId"].Value + @"','" + ISpace["MF_T1_TravelAdvanceID"].Value + @"','" + ISpace["MG_Amount"].Value + @"','" + ISpace["MG_BudgetHead"].Value + @"','1','" + ISpace["MG_FundTypeid"].Value + @"','" + ISpace["M_PackageProcessMapId"].Value + @"','" + ISpace["UC_EmployeeBaicInfoId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceEA86EC989465469D97F236E0D8B7BEB7 =GetQueryExpressionDataSource(""EA86EC98-9465-469D-97F2-36E0D8B7BEB7"");Dictionary<short,object> resultEA86EC989465469D97F236E0D8B7BEB7=iSpace.ExecuteQuery(querySourceEA86EC989465469D97F236E0D8B7BEB7,@""EXEC UpsertProjectBudgetDetails 5,'"" + ISpace[""MG_ProjectDetailsId""].Value + @""','"" + ISpace[""MF_T1_TravelAdvanceID""].Value + @""','"" + ISpace[""MG_Amount""].Value + @""','"" + ISpace[""MG_BudgetHead""].Value + @""','1','"" + ISpace[""MG_FundTypeid""].Value + @""','"" + ISpace[""M_PackageProcessMapId""].Value + @""','"" + ISpace[""UC_EmployeeBaicInfoId""].Value + @""'"",false);");
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("MF_FundAmount","AD9C54EC-27A0-4C21-9923-063084E3B588",_objectFactory.GetGridRPP("MF_FundAmount"),_elementBase.GetGridLoopQuery("AD9C54EC-27A0-4C21-9923-063084E3B588","MF_FundAmount",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""MF_FundAmount"",ref ISpace);

foreach(var gridChild in ISpace[""MF_FundAmount""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
}
}
if(ISpace["M_SaveDomainData"].Value==0&&ISpace["M_IsflowReturned"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""M_SaveDomainData""].Value==0&&ISpace[""M_IsflowReturned""].Value==1)");
base.WriteDebugInfo(@"exec [SendReturnEmailForTR] '#MF_T1_TravelAdvanceID'");

var querySourceDE33E12BFBC142E094A9B51B2789A1AE =GetQueryExpressionDataSource("DE33E12B-FBC1-42E0-94A9-B51B2789A1AE");
Dictionary<short,object> resultDE33E12BFBC142E094A9B51B2789A1AE=iSpace.ExecuteQuery(querySourceDE33E12BFBC142E094A9B51B2789A1AE,@"exec [SendReturnEmailForTR] '" + ISpace["MF_T1_TravelAdvanceID"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceDE33E12BFBC142E094A9B51B2789A1AE =GetQueryExpressionDataSource(""DE33E12B-FBC1-42E0-94A9-B51B2789A1AE"");Dictionary<short,object> resultDE33E12BFBC142E094A9B51B2789A1AE=iSpace.ExecuteQuery(querySourceDE33E12BFBC142E094A9B51B2789A1AE,@""exec [SendReturnEmailForTR] '"" + ISpace[""MF_T1_TravelAdvanceID""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultDE33E12BFBC142E094A9B51B2789A1AE!=null) && (resultDE33E12BFBC142E094A9B51B2789A1AE.Count!=0))
{
if(resultDE33E12BFBC142E094A9B51B2789A1AE.ContainsKey(0))
ISpace["A"].Value = resultDE33E12BFBC142E094A9B51B2789A1AE[0];
}
else{
ISpace["A"].Value = null;
}
}
if(ISpace["M_SaveDomainData"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""M_SaveDomainData""].Value==1)");
base.WriteDebugInfo(@"exec SendApproveEmailForTR '#MF_T1_TravelAdvanceID'");

var querySourceDD228B607D714F6690FD26F71FC14E4E =GetQueryExpressionDataSource("DD228B60-7D71-4F66-90FD-26F71FC14E4E");
Dictionary<short,object> resultDD228B607D714F6690FD26F71FC14E4E=iSpace.ExecuteQuery(querySourceDD228B607D714F6690FD26F71FC14E4E,@"execSendApproveEmailForTR '" + ISpace["MF_T1_TravelAdvanceID"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceDD228B607D714F6690FD26F71FC14E4E =GetQueryExpressionDataSource(""DD228B60-7D71-4F66-90FD-26F71FC14E4E"");Dictionary<short,object> resultDD228B607D714F6690FD26F71FC14E4E=iSpace.ExecuteQuery(querySourceDD228B607D714F6690FD26F71FC14E4E,@""execSendApproveEmailForTR '"" + ISpace[""MF_T1_TravelAdvanceID""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultDD228B607D714F6690FD26F71FC14E4E!=null) && (resultDD228B607D714F6690FD26F71FC14E4E.Count!=0))
{
if(resultDD228B607D714F6690FD26F71FC14E4E.ContainsKey(0))
ISpace["A"].Value = resultDD228B607D714F6690FD26F71FC14E4E[0];
}
else{
ISpace["A"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
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

base.WriteDebugInfo(@"EXEC UpsertProjectBudgetDetails 6,'#MG_ProjectDetailsId','#MF_T1_TravelAdvanceID','#MG_Amount','#MG_BudgetHead','1','#MG_FundTypeid','#M_PackageProcessMapId','#UC_EmployeeBaicInfoId'");

var querySource579419E790FA4F5A847AADEFF8FBD8C9 =GetQueryExpressionDataSource("579419E7-90FA-4F5A-847A-ADEFF8FBD8C9");
Dictionary<short,object> result579419E790FA4F5A847AADEFF8FBD8C9=iSpace.ExecuteQuery(querySource579419E790FA4F5A847AADEFF8FBD8C9,@"EXEC UpsertProjectBudgetDetails 6,'" + ISpace["MG_ProjectDetailsId"].Value + @"','" + ISpace["MF_T1_TravelAdvanceID"].Value + @"','" + ISpace["MG_Amount"].Value + @"','" + ISpace["MG_BudgetHead"].Value + @"','1','" + ISpace["MG_FundTypeid"].Value + @"','" + ISpace["M_PackageProcessMapId"].Value + @"','" + ISpace["UC_EmployeeBaicInfoId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource579419E790FA4F5A847AADEFF8FBD8C9 =GetQueryExpressionDataSource(""579419E7-90FA-4F5A-847A-ADEFF8FBD8C9"");Dictionary<short,object> result579419E790FA4F5A847AADEFF8FBD8C9=iSpace.ExecuteQuery(querySource579419E790FA4F5A847AADEFF8FBD8C9,@""EXEC UpsertProjectBudgetDetails 6,'"" + ISpace[""MG_ProjectDetailsId""].Value + @""','"" + ISpace[""MF_T1_TravelAdvanceID""].Value + @""','"" + ISpace[""MG_Amount""].Value + @""','"" + ISpace[""MG_BudgetHead""].Value + @""','1','"" + ISpace[""MG_FundTypeid""].Value + @""','"" + ISpace[""M_PackageProcessMapId""].Value + @""','"" + ISpace[""UC_EmployeeBaicInfoId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result579419E790FA4F5A847AADEFF8FBD8C9!=null) && (result579419E790FA4F5A847AADEFF8FBD8C9.Count!=0))
{
if(result579419E790FA4F5A847AADEFF8FBD8C9.ContainsKey(0))
ISpace["A"].Value = result579419E790FA4F5A847AADEFF8FBD8C9[0];
}
else{
ISpace["A"].Value = null;
}
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("MF_FundAmount","AD9C54EC-27A0-4C21-9923-063084E3B588",_objectFactory.GetGridRPP("MF_FundAmount"),_elementBase.GetGridLoopQuery("AD9C54EC-27A0-4C21-9923-063084E3B588","MF_FundAmount",ISpace), ref ISpace);
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
ISpace["Message"].Value=@"Submitted Successfully";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Submitted Successfully"";");
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

var querySource4DA95BD5CD3F4A6D8AE54C8A839E94D6 =GetQueryExpressionDataSource("4DA95BD5-CD3F-4A6D-8AE5-4C8A839E94D6");
Dictionary<short,object> result4DA95BD5CD3F4A6D8AE54C8A839E94D6=iSpace.ExecuteQuery(querySource4DA95BD5CD3F4A6D8AE54C8A839E94D6,@"Exec GetStageStatus 1,'','','" + ISpace["M_MoveToValue"].Value + @"','" + ISpace["M_SourceActivityMapId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource4DA95BD5CD3F4A6D8AE54C8A839E94D6 =GetQueryExpressionDataSource(""4DA95BD5-CD3F-4A6D-8AE5-4C8A839E94D6"");Dictionary<short,object> result4DA95BD5CD3F4A6D8AE54C8A839E94D6=iSpace.ExecuteQuery(querySource4DA95BD5CD3F4A6D8AE54C8A839E94D6,@""Exec GetStageStatus 1,'','','"" + ISpace[""M_MoveToValue""].Value + @""','"" + ISpace[""M_SourceActivityMapId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result4DA95BD5CD3F4A6D8AE54C8A839E94D6!=null) && (result4DA95BD5CD3F4A6D8AE54C8A839E94D6.Count!=0))
{
if(result4DA95BD5CD3F4A6D8AE54C8A839E94D6.ContainsKey(5))
ISpace["M_IsFlowReturned"].Value = result4DA95BD5CD3F4A6D8AE54C8A839E94D6[5];
if(result4DA95BD5CD3F4A6D8AE54C8A839E94D6.ContainsKey(6))
ISpace["M_IsCancelReject"].Value = result4DA95BD5CD3F4A6D8AE54C8A839E94D6[6];
if(result4DA95BD5CD3F4A6D8AE54C8A839E94D6.ContainsKey(4))
ISpace["M_FieldMandatory"].Value = result4DA95BD5CD3F4A6D8AE54C8A839E94D6[4];
if(result4DA95BD5CD3F4A6D8AE54C8A839E94D6.ContainsKey(1))
ISpace["M_RemarksMandatory"].Value = result4DA95BD5CD3F4A6D8AE54C8A839E94D6[1];
if(result4DA95BD5CD3F4A6D8AE54C8A839E94D6.ContainsKey(3))
ISpace["M_SaveDomainData"].Value = result4DA95BD5CD3F4A6D8AE54C8A839E94D6[3];
if(result4DA95BD5CD3F4A6D8AE54C8A839E94D6.ContainsKey(2))
ISpace["M_Remarks"].Value = result4DA95BD5CD3F4A6D8AE54C8A839E94D6[2];
if(result4DA95BD5CD3F4A6D8AE54C8A839E94D6.ContainsKey(0))
ISpace["M_NextStage"].Value = result4DA95BD5CD3F4A6D8AE54C8A839E94D6[0];
}
else{
ISpace["M_IsFlowReturned"].Value = null;ISpace["M_IsCancelReject"].Value = null;ISpace["M_FieldMandatory"].Value = null;ISpace["M_RemarksMandatory"].Value = null;ISpace["M_SaveDomainData"].Value = null;ISpace["M_Remarks"].Value = null;ISpace["M_NextStage"].Value = null;
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

using System.Collections.Generic;
using System;
using CPS.Proof.DFSExtension;
using System.Linq;using System.Data;
using System.Runtime.CompilerServices;
public class ISpaceB26F912289B24163B93837AD78E21338 : VirtualForm
{
IISpace iSpace = new ISpace();
AcDataISpaceB26F912289B24163B93837AD78E21338 acdataIspaceB26F912289B24163B93837AD78E21338=new AcDataISpaceB26F912289B24163B93837AD78E21338();
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
ISpace["M_TravelInstanceId"].Value=Guid.NewGuid().ToString();
base.WriteDebugInfo(@"ISpace[""M_TravelInstanceId""].Value=Guid.NewGuid().ToString();");
ISpace["M_MoveTo"].Man=true;
base.WriteDebugInfo(@"ISpace[""M_MoveTo""].Man=true;");
ISpace["M_Remarks"].Value="";
base.WriteDebugInfo(@"ISpace[""M_Remarks""].Value="""";");
ISpace["M_NextStage"].Value="";
base.WriteDebugInfo(@"ISpace[""M_NextStage""].Value="""";");
ISpace["MF_TransactionDate"].Man=true;ISpace["MF_TransactionNo"].Man=true;
base.WriteDebugInfo(@"ISpace[""MF_TransactionDate""].Man=true;ISpace[""MF_TransactionNo""].Man=true;");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySourceA0ECD2B8980941FB814ECFF85B9E0A09 =GetQueryExpressionDataSource("A0ECD2B8-9809-41FB-814E-CFF85B9E0A09");

DataTable resultA0ECD2B8980941FB814ECFF85B9E0A09=iSpace.SetGridDataSource(querySourceA0ECD2B8980941FB814ECFF85B9E0A09, _objectFactory.GetGridRPP("MG_RemarksDetails"),@"EXEC GetRemarks '" + ISpace["M_InstanceId"].Value + @"'");

iSpace.InsertGridBindDetails("MG_RemarksDetails","11",querySourceA0ECD2B8980941FB814ECFF85B9E0A09,"EXEC GetRemarks '" + ISpace["M_InstanceId"].Value + @"'",_objectFactory.GetGridRPP("MG_RemarksDetails"));

base.WriteDebugInfo(@"var querySourceA0ECD2B8980941FB814ECFF85B9E0A09 =GetQueryExpressionDataSource(""A0ECD2B8-9809-41FB-814E-CFF85B9E0A09"");DataTable resultA0ECD2B8980941FB814ECFF85B9E0A09=iSpace.SetGridDataSource(querySourceA0ECD2B8980941FB814ECFF85B9E0A09, _objectFactory.GetGridRPP(""MG_RemarksDetails""),@""EXEC GetRemarks '"" + ISpace[""M_InstanceId""].Value + @""'"");iSpace.InsertGridBindDetails(""MG_RemarksDetails"",""11"",querySourceA0ECD2B8980941FB814ECFF85B9E0A09,""EXEC GetRemarks '"" + ISpace[""M_InstanceId""].Value + @""'"",_objectFactory.GetGridRPP(""MG_RemarksDetails""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> resultCBD3E108E08C4B5F8ACA817E51BDACD4=acdataIspaceB26F912289B24163B93837AD78E21338.GetQueryExpressionBindings("CBD3E108-E08C-4B5F-8ACA-817E51BDACD4");
iSpace.SetGridData(resultA0ECD2B8980941FB814ECFF85B9E0A09,resultCBD3E108E08C4B5F8ACA817E51BDACD4,"MG_RemarksDetails",ref ISpace);
iSpace.UpdateGridBindDetails("MG_RemarksDetails",resultCBD3E108E08C4B5F8ACA817E51BDACD4);
}
ISpace["UC_DOJ"].Visible="false";ISpace["UC_EmailId"].Visible="false";ISpace["UC_PhoneNumber"].Visible="false";ISpace["UC_DOB"].Visible="false";ISpace["UC_Grade"].Visible="false";ISpace["UC_DOR"].Visible="false";ISpace["UC_Paylevel"].Visible="false";
base.WriteDebugInfo(@"ISpace[""UC_DOJ""].Visible=""false"";ISpace[""UC_EmailId""].Visible=""false"";ISpace[""UC_PhoneNumber""].Visible=""false"";ISpace[""UC_DOB""].Visible=""false"";ISpace[""UC_Grade""].Visible=""false"";ISpace[""UC_DOR""].Visible=""false"";ISpace[""UC_Paylevel""].Visible=""false"";");
if(ISpace["Travel_Type"].Value=="1")
{
base.WriteDebugInfo(@"if(ISpace[""Travel_Type""].Value==""1"")");
ISpace["MF_T1_AccountNo"].Man=false;ISpace["MF_T1_BankBranch"].Man=false;ISpace["MF_T1_BeneficiaryName"].Man=false;ISpace["MF_T1_BankDocument"].Man=false;ISpace["MF_T1_BankName"].Man=false;
base.WriteDebugInfo(@"ISpace[""MF_T1_AccountNo""].Man=false;ISpace[""MF_T1_BankBranch""].Man=false;ISpace[""MF_T1_BeneficiaryName""].Man=false;ISpace[""MF_T1_BankDocument""].Man=false;ISpace[""MF_T1_BankName""].Man=false;");
}
if(ISpace["Travel_Type"].Value=="3")
{
base.WriteDebugInfo(@"if(ISpace[""Travel_Type""].Value==""3"")");
ISpace["MF_T1_AccountNo"].Man=true;ISpace["MF_T1_AccountNo"].Enbl="true";ISpace["MF_T1_BankBranch"].Man=true;ISpace["MF_T1_BankBranch"].Enbl="true";ISpace["MF_T1_AdvanceAmount"].Man=true;ISpace["MF_T1_AdvanceAmount"].Enbl="true";ISpace["MF_T1_BeneficiaryName"].Man=true;ISpace["MF_T1_BeneficiaryName"].Enbl="true";ISpace["MF_T1_BankDocument"].Man=true;ISpace["MF_T1_BankDocument"].Enbl="true";ISpace["MF_T1_BankName"].Man=true;ISpace["MF_T1_BankName"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_T1_AccountNo""].Man=true;ISpace[""MF_T1_AccountNo""].Enbl=""true"";ISpace[""MF_T1_BankBranch""].Man=true;ISpace[""MF_T1_BankBranch""].Enbl=""true"";ISpace[""MF_T1_AdvanceAmount""].Man=true;ISpace[""MF_T1_AdvanceAmount""].Enbl=""true"";ISpace[""MF_T1_BeneficiaryName""].Man=true;ISpace[""MF_T1_BeneficiaryName""].Enbl=""true"";ISpace[""MF_T1_BankDocument""].Man=true;ISpace[""MF_T1_BankDocument""].Enbl=""true"";ISpace[""MF_T1_BankName""].Man=true;ISpace[""MF_T1_BankName""].Enbl=""true"";");
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
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_TransactionNo"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""MF_TransactionNo""].Value=="""")");
ISpace["Message"].Value=@"Please Enter Transaction No";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please Enter Transaction No"";");
return;
base.WriteDebugInfo(@"return;");
}
if((ISpace["MF_TransactionDate"].Value == null))
{
base.WriteDebugInfo(@"if((ISpace[""MF_TransactionDate""].Value == null))");
ISpace["Message"].Value=@"Please enter Transaction Date";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please enter Transaction Date"";");
return;
base.WriteDebugInfo(@"return;");
}
}
if(ISpace["M_MoveTo"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""M_MoveTo""].Value=="""")");
ISpace["Message"].Value=@"Move To should be mandatory";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Move To should be mandatory"";");
return;
base.WriteDebugInfo(@"return;");
}
ISpace["MF_TravelStatus"].Value="A";
base.WriteDebugInfo(@"ISpace[""MF_TravelStatus""].Value=""A"";");
ISpace["M_IsCommitment"].Value=0;
base.WriteDebugInfo(@"ISpace[""M_IsCommitment""].Value=0;");
if(ISpace["M_SaveDomainData"].Value==1||1==1)
{
base.WriteDebugInfo(@"if(ISpace[""M_SaveDomainData""].Value==1||1==1)");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC Repo198E5A8A61F54E7C92DD34146A7059EF '#CreatedOn','#MF_T1_BankDocument','#MF_T1_ReferenceNo','#MF_T1_AccountNo','#OverAll_Total','#UC_EmployeeBaicInfoId','#M_TravelPlace','#MF_T1_AdvanceAmount','#MF_T1_BankName','#MF_T1_TravelAdvanceID','#MF_T1_JourneyPurpose','#Travel_Type','#MF_T1_BeneficiaryName','#gv_UserId','#MF_TransactionNo','#MF_TravelStatus','#MF_TransactionDate','#M_IsAdvanceRequired'");

var querySourceD16F9C83EA714542AB4DE3D99AB969B2 =GetQueryExpressionDataSource("D16F9C83-EA71-4542-AB4D-E3D99AB969B2");
Dictionary<short,object> resultD16F9C83EA714542AB4DE3D99AB969B2=iSpace.ExecuteQuery(querySourceD16F9C83EA714542AB4DE3D99AB969B2,@"EXEC Repo198E5A8A61F54E7C92DD34146A7059EF '" + ISpace["CreatedOn"].Value + @"','" + ISpace["MF_T1_BankDocument"].Value + @"','" + ISpace["MF_T1_ReferenceNo"].Value + @"','" + ISpace["MF_T1_AccountNo"].Value + @"','" + ISpace["OverAll_Total"].Value + @"','" + ISpace["UC_EmployeeBaicInfoId"].Value + @"','" + ISpace["M_TravelPlace"].Value + @"','" + ISpace["MF_T1_AdvanceAmount"].Value + @"','" + ISpace["MF_T1_BankName"].Value + @"','" + ISpace["MF_T1_TravelAdvanceID"].Value + @"','" + ISpace["MF_T1_JourneyPurpose"].Value + @"','" + ISpace["Travel_Type"].Value + @"','" + ISpace["MF_T1_BeneficiaryName"].Value + @"','" + ISpace["gv_UserId"].Value + @"','" + ISpace["MF_TransactionNo"].Value + @"','" + ISpace["MF_TravelStatus"].Value + @"','" + ISpace["MF_TransactionDate"].Value + @"','" + ISpace["M_IsAdvanceRequired"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceD16F9C83EA714542AB4DE3D99AB969B2 =GetQueryExpressionDataSource(""D16F9C83-EA71-4542-AB4D-E3D99AB969B2"");Dictionary<short,object> resultD16F9C83EA714542AB4DE3D99AB969B2=iSpace.ExecuteQuery(querySourceD16F9C83EA714542AB4DE3D99AB969B2,@""EXEC Repo198E5A8A61F54E7C92DD34146A7059EF '"" + ISpace[""CreatedOn""].Value + @""','"" + ISpace[""MF_T1_BankDocument""].Value + @""','"" + ISpace[""MF_T1_ReferenceNo""].Value + @""','"" + ISpace[""MF_T1_AccountNo""].Value + @""','"" + ISpace[""OverAll_Total""].Value + @""','"" + ISpace[""UC_EmployeeBaicInfoId""].Value + @""','"" + ISpace[""M_TravelPlace""].Value + @""','"" + ISpace[""MF_T1_AdvanceAmount""].Value + @""','"" + ISpace[""MF_T1_BankName""].Value + @""','"" + ISpace[""MF_T1_TravelAdvanceID""].Value + @""','"" + ISpace[""MF_T1_JourneyPurpose""].Value + @""','"" + ISpace[""Travel_Type""].Value + @""','"" + ISpace[""MF_T1_BeneficiaryName""].Value + @""','"" + ISpace[""gv_UserId""].Value + @""','"" + ISpace[""MF_TransactionNo""].Value + @""','"" + ISpace[""MF_TravelStatus""].Value + @""','"" + ISpace[""MF_TransactionDate""].Value + @""','"" + ISpace[""M_IsAdvanceRequired""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultD16F9C83EA714542AB4DE3D99AB969B2!=null) && (resultD16F9C83EA714542AB4DE3D99AB969B2.Count!=0))
{
}
else{

}
base.WriteDebugInfo(@"EXEC Repo51838b372ec64d358a5e38648bc93ab1 '#gv_UserId','#UpdatedOn','#MF_T1_TravelAdvanceID','#MG_T2_ToDate','#MG_T2_FromDate','#M_IsTravelRequest','#MG_T2_ExpenditureTypeID','#Expenditure_Type','#MG_T3_Amount'");

var querySource864963C6427C451F8C30D7E8FCDD4228 =GetQueryExpressionDataSource("864963C6-427C-451F-8C30-D7E8FCDD4228");
Dictionary<short,object> result864963C6427C451F8C30D7E8FCDD4228=iSpace.ExecuteQuery(querySource864963C6427C451F8C30D7E8FCDD4228,@"EXEC Repo51838b372ec64d358a5e38648bc93ab1 '" + ISpace["gv_UserId"].Value + @"','" + ISpace["UpdatedOn"].Value + @"','" + ISpace["MF_T1_TravelAdvanceID"].Value + @"','" + ISpace["MG_T2_ToDate"].Value + @"','" + ISpace["MG_T2_FromDate"].Value + @"','" + ISpace["M_IsTravelRequest"].Value + @"','" + ISpace["MG_T2_ExpenditureTypeID"].Value + @"','" + ISpace["Expenditure_Type"].Value + @"','" + ISpace["MG_T3_Amount"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource864963C6427C451F8C30D7E8FCDD4228 =GetQueryExpressionDataSource(""864963C6-427C-451F-8C30-D7E8FCDD4228"");Dictionary<short,object> result864963C6427C451F8C30D7E8FCDD4228=iSpace.ExecuteQuery(querySource864963C6427C451F8C30D7E8FCDD4228,@""EXEC Repo51838b372ec64d358a5e38648bc93ab1 '"" + ISpace[""gv_UserId""].Value + @""','"" + ISpace[""UpdatedOn""].Value + @""','"" + ISpace[""MF_T1_TravelAdvanceID""].Value + @""','"" + ISpace[""MG_T2_ToDate""].Value + @""','"" + ISpace[""MG_T2_FromDate""].Value + @""','"" + ISpace[""M_IsTravelRequest""].Value + @""','"" + ISpace[""MG_T2_ExpenditureTypeID""].Value + @""','"" + ISpace[""Expenditure_Type""].Value + @""','"" + ISpace[""MG_T3_Amount""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result864963C6427C451F8C30D7E8FCDD4228!=null) && (result864963C6427C451F8C30D7E8FCDD4228.Count!=0))
{
}
else{

}
base.WriteDebugInfo(@"EXEC Repo374fb8a88dd94cf1bf73f40ae18fcad7 '#M_IsTravelRequest','#UpdatedOn','#MG_T2_TADetailsID','#gv_UserId','#MG_T2_DepartureDate','#MG_T2_DepartureTime','#MG_T2_ArrivalDate','#MG_T2_Road','#MF_T1_TravelAdvanceID','#MG_T2_Departure','#MG_T2_Amount','#MG_T2_JourneyClass','#MG_T2_Arrival','#MG_T2_PNRNo','#MG_T2_ModeofJourney','#MG_T2_ArrivalTime'");

var querySourceEBE446FD1D9E41DEB663DEAA6EE73345 =GetQueryExpressionDataSource("EBE446FD-1D9E-41DE-B663-DEAA6EE73345");
Dictionary<short,object> resultEBE446FD1D9E41DEB663DEAA6EE73345=iSpace.ExecuteQuery(querySourceEBE446FD1D9E41DEB663DEAA6EE73345,@"EXEC Repo374fb8a88dd94cf1bf73f40ae18fcad7 '" + ISpace["M_IsTravelRequest"].Value + @"','" + ISpace["UpdatedOn"].Value + @"','" + ISpace["MG_T2_TADetailsID"].Value + @"','" + ISpace["gv_UserId"].Value + @"','" + ISpace["MG_T2_DepartureDate"].Value + @"','" + ISpace["MG_T2_DepartureTime"].Value + @"','" + ISpace["MG_T2_ArrivalDate"].Value + @"','" + ISpace["MG_T2_Road"].Value + @"','" + ISpace["MF_T1_TravelAdvanceID"].Value + @"','" + ISpace["MG_T2_Departure"].Value + @"','" + ISpace["MG_T2_Amount"].Value + @"','" + ISpace["MG_T2_JourneyClass"].Value + @"','" + ISpace["MG_T2_Arrival"].Value + @"','" + ISpace["MG_T2_PNRNo"].Value + @"','" + ISpace["MG_T2_ModeofJourney"].Value + @"','" + ISpace["MG_T2_ArrivalTime"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceEBE446FD1D9E41DEB663DEAA6EE73345 =GetQueryExpressionDataSource(""EBE446FD-1D9E-41DE-B663-DEAA6EE73345"");Dictionary<short,object> resultEBE446FD1D9E41DEB663DEAA6EE73345=iSpace.ExecuteQuery(querySourceEBE446FD1D9E41DEB663DEAA6EE73345,@""EXEC Repo374fb8a88dd94cf1bf73f40ae18fcad7 '"" + ISpace[""M_IsTravelRequest""].Value + @""','"" + ISpace[""UpdatedOn""].Value + @""','"" + ISpace[""MG_T2_TADetailsID""].Value + @""','"" + ISpace[""gv_UserId""].Value + @""','"" + ISpace[""MG_T2_DepartureDate""].Value + @""','"" + ISpace[""MG_T2_DepartureTime""].Value + @""','"" + ISpace[""MG_T2_ArrivalDate""].Value + @""','"" + ISpace[""MG_T2_Road""].Value + @""','"" + ISpace[""MF_T1_TravelAdvanceID""].Value + @""','"" + ISpace[""MG_T2_Departure""].Value + @""','"" + ISpace[""MG_T2_Amount""].Value + @""','"" + ISpace[""MG_T2_JourneyClass""].Value + @""','"" + ISpace[""MG_T2_Arrival""].Value + @""','"" + ISpace[""MG_T2_PNRNo""].Value + @""','"" + ISpace[""MG_T2_ModeofJourney""].Value + @""','"" + ISpace[""MG_T2_ArrivalTime""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultEBE446FD1D9E41DEB663DEAA6EE73345!=null) && (resultEBE446FD1D9E41DEB663DEAA6EE73345.Count!=0))
{
}
else{

}
base.WriteDebugInfo(@"EXEC DocumentsDomain '#M_DocumentDetailsId','#M_PackageProcessMapId','#UpdatedOn','#M_DocumentName','#gv_UserId','#M_UploadDcoument','#MF_T1_TravelAdvanceID'");

var querySource1D2378FB2963489899022B61F44BE0AD =GetQueryExpressionDataSource("1D2378FB-2963-4898-9902-2B61F44BE0AD");
Dictionary<short,object> result1D2378FB2963489899022B61F44BE0AD=iSpace.ExecuteQuery(querySource1D2378FB2963489899022B61F44BE0AD,@"EXEC DocumentsDomain '" + ISpace["M_DocumentDetailsId"].Value + @"','" + ISpace["M_PackageProcessMapId"].Value + @"','" + ISpace["UpdatedOn"].Value + @"','" + ISpace["M_DocumentName"].Value + @"','" + ISpace["gv_UserId"].Value + @"','" + ISpace["M_UploadDcoument"].Value + @"','" + ISpace["MF_T1_TravelAdvanceID"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource1D2378FB2963489899022B61F44BE0AD =GetQueryExpressionDataSource(""1D2378FB-2963-4898-9902-2B61F44BE0AD"");Dictionary<short,object> result1D2378FB2963489899022B61F44BE0AD=iSpace.ExecuteQuery(querySource1D2378FB2963489899022B61F44BE0AD,@""EXEC DocumentsDomain '"" + ISpace[""M_DocumentDetailsId""].Value + @""','"" + ISpace[""M_PackageProcessMapId""].Value + @""','"" + ISpace[""UpdatedOn""].Value + @""','"" + ISpace[""M_DocumentName""].Value + @""','"" + ISpace[""gv_UserId""].Value + @""','"" + ISpace[""M_UploadDcoument""].Value + @""','"" + ISpace[""MF_T1_TravelAdvanceID""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result1D2378FB2963489899022B61F44BE0AD!=null) && (result1D2378FB2963489899022B61F44BE0AD.Count!=0))
{
}
else{

}
base.WriteDebugInfo(@"#MF_FundAmount[rows]");
iSpace.GetLoopExpressionData("MF_FundAmount",ref ISpace);

foreach(var gridChild in ISpace["MF_FundAmount"].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 


if(
ISpace["MG_FundTypeId"].Value==1)
{
base.WriteDebugInfo(@"
if(
ISpace[""MG_FundTypeId""].Value==1)");
base.WriteDebugInfo(@"EXEC ProjectApprovalCommittmentDetails '#MG_Amount','#MF_T1_TravelAdvanceID','#MG_ProjectDetailsId','#MG_BudgetHead','#gv_ProcessMapId'");

var querySource4213CFEEA88E4B67BEECB0AEF4337465 =GetQueryExpressionDataSource("4213CFEE-A88E-4B67-BEEC-B0AEF4337465");
Dictionary<short,object> result4213CFEEA88E4B67BEECB0AEF4337465=iSpace.ExecuteQuery(querySource4213CFEEA88E4B67BEECB0AEF4337465,@"EXEC ProjectApprovalCommittmentDetails '" + ISpace["MG_Amount"].Value + @"','" + ISpace["MF_T1_TravelAdvanceID"].Value + @"','" + ISpace["MG_ProjectDetailsId"].Value + @"','" + ISpace["MG_BudgetHead"].Value + @"','" + ISpace["gv_ProcessMapId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource4213CFEEA88E4B67BEECB0AEF4337465 =GetQueryExpressionDataSource(""4213CFEE-A88E-4B67-BEEC-B0AEF4337465"");Dictionary<short,object> result4213CFEEA88E4B67BEECB0AEF4337465=iSpace.ExecuteQuery(querySource4213CFEEA88E4B67BEECB0AEF4337465,@""EXEC ProjectApprovalCommittmentDetails '"" + ISpace[""MG_Amount""].Value + @""','"" + ISpace[""MF_T1_TravelAdvanceID""].Value + @""','"" + ISpace[""MG_ProjectDetailsId""].Value + @""','"" + ISpace[""MG_BudgetHead""].Value + @""','"" + ISpace[""gv_ProcessMapId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result4213CFEEA88E4B67BEECB0AEF4337465!=null) && (result4213CFEEA88E4B67BEECB0AEF4337465.Count!=0))
{
}
else{

}
}
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("MF_FundAmount","AD9C54EC-27A0-4C21-9923-063084E3B588",_objectFactory.GetGridRPP("MF_FundAmount"),_elementBase.GetGridLoopQuery("AD9C54EC-27A0-4C21-9923-063084E3B588","MF_FundAmount",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""MF_FundAmount"",ref ISpace);

foreach(var gridChild in ISpace[""MF_FundAmount""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
}
if(1==2)
{
base.WriteDebugInfo(@"if(1==2)");
base.WriteDebugInfo(@"#MF_FundAmount[Rows]");
iSpace.GetLoopExpressionData("MF_FundAmount",ref ISpace);

foreach(var gridChild in ISpace["MF_FundAmount"].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 

base.WriteDebugInfo(@"EXEC UpsertProjectBudgetDetails 5,'#MG_ProjectDetailsId','#MF_T1_TravelAdvanceID','#MG_Amount','#MG_BudgetHead','1','#MG_FundTypeid','#M_PackageProcessMapId','#UC_EmployeeBaicInfoId'");

var querySourceEA86EC989465469D97F236E0D8B7BEB7 =GetQueryExpressionDataSource("EA86EC98-9465-469D-97F2-36E0D8B7BEB7");
Dictionary<short,object> resultEA86EC989465469D97F236E0D8B7BEB7=iSpace.ExecuteQuery(querySourceEA86EC989465469D97F236E0D8B7BEB7,@"EXEC UpsertProjectBudgetDetails 5,'" + ISpace["MG_ProjectDetailsId"].Value + @"','" + ISpace["MF_T1_TravelAdvanceID"].Value + @"','" + ISpace["MG_Amount"].Value + @"','" + ISpace["MG_BudgetHead"].Value + @"','1','" + ISpace["MG_FundTypeid"].Value + @"','" + ISpace["M_PackageProcessMapId"].Value + @"','" + ISpace["UC_EmployeeBaicInfoId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceEA86EC989465469D97F236E0D8B7BEB7 =GetQueryExpressionDataSource(""EA86EC98-9465-469D-97F2-36E0D8B7BEB7"");Dictionary<short,object> resultEA86EC989465469D97F236E0D8B7BEB7=iSpace.ExecuteQuery(querySourceEA86EC989465469D97F236E0D8B7BEB7,@""EXEC UpsertProjectBudgetDetails 5,'"" + ISpace[""MG_ProjectDetailsId""].Value + @""','"" + ISpace[""MF_T1_TravelAdvanceID""].Value + @""','"" + ISpace[""MG_Amount""].Value + @""','"" + ISpace[""MG_BudgetHead""].Value + @""','1','"" + ISpace[""MG_FundTypeid""].Value + @""','"" + ISpace[""M_PackageProcessMapId""].Value + @""','"" + ISpace[""UC_EmployeeBaicInfoId""].Value + @""'"",false);");
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("MF_FundAmount","AD9C54EC-27A0-4C21-9923-063084E3B588",_objectFactory.GetGridRPP("MF_FundAmount"),_elementBase.GetGridLoopQuery("AD9C54EC-27A0-4C21-9923-063084E3B588","MF_FundAmount",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""MF_FundAmount"",ref ISpace);

foreach(var gridChild in ISpace[""MF_FundAmount""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
}
}
if(ISpace["M_SaveDomainData"].Value==0&&ISpace["M_IsflowReturned"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""M_SaveDomainData""].Value==0&&ISpace[""M_IsflowReturned""].Value==1)");
base.WriteDebugInfo(@"exec [SendReturnEmailForTR] '#MF_T1_TravelAdvanceID'");

var querySourceDE33E12BFBC142E094A9B51B2789A1AE =GetQueryExpressionDataSource("DE33E12B-FBC1-42E0-94A9-B51B2789A1AE");
Dictionary<short,object> resultDE33E12BFBC142E094A9B51B2789A1AE=iSpace.ExecuteQuery(querySourceDE33E12BFBC142E094A9B51B2789A1AE,@"exec [SendReturnEmailForTR] '" + ISpace["MF_T1_TravelAdvanceID"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceDE33E12BFBC142E094A9B51B2789A1AE =GetQueryExpressionDataSource(""DE33E12B-FBC1-42E0-94A9-B51B2789A1AE"");Dictionary<short,object> resultDE33E12BFBC142E094A9B51B2789A1AE=iSpace.ExecuteQuery(querySourceDE33E12BFBC142E094A9B51B2789A1AE,@""exec [SendReturnEmailForTR] '"" + ISpace[""MF_T1_TravelAdvanceID""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultDE33E12BFBC142E094A9B51B2789A1AE!=null) && (resultDE33E12BFBC142E094A9B51B2789A1AE.Count!=0))
{
if(resultDE33E12BFBC142E094A9B51B2789A1AE.ContainsKey(0))
ISpace["A"].Value = resultDE33E12BFBC142E094A9B51B2789A1AE[0];
}
else{
ISpace["A"].Value = null;
}
}
if(ISpace["M_SaveDomainData"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""M_SaveDomainData""].Value==1)");
base.WriteDebugInfo(@"exec SendApproveEmailForTR '#MF_T1_TravelAdvanceID'");

var querySourceDD228B607D714F6690FD26F71FC14E4E =GetQueryExpressionDataSource("DD228B60-7D71-4F66-90FD-26F71FC14E4E");
Dictionary<short,object> resultDD228B607D714F6690FD26F71FC14E4E=iSpace.ExecuteQuery(querySourceDD228B607D714F6690FD26F71FC14E4E,@"execSendApproveEmailForTR '" + ISpace["MF_T1_TravelAdvanceID"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceDD228B607D714F6690FD26F71FC14E4E =GetQueryExpressionDataSource(""DD228B60-7D71-4F66-90FD-26F71FC14E4E"");Dictionary<short,object> resultDD228B607D714F6690FD26F71FC14E4E=iSpace.ExecuteQuery(querySourceDD228B607D714F6690FD26F71FC14E4E,@""execSendApproveEmailForTR '"" + ISpace[""MF_T1_TravelAdvanceID""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultDD228B607D714F6690FD26F71FC14E4E!=null) && (resultDD228B607D714F6690FD26F71FC14E4E.Count!=0))
{
if(resultDD228B607D714F6690FD26F71FC14E4E.ContainsKey(0))
ISpace["A"].Value = resultDD228B607D714F6690FD26F71FC14E4E[0];
}
else{
ISpace["A"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
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

var querySource4DA95BD5CD3F4A6D8AE54C8A839E94D6 =GetQueryExpressionDataSource("4DA95BD5-CD3F-4A6D-8AE5-4C8A839E94D6");
Dictionary<short,object> result4DA95BD5CD3F4A6D8AE54C8A839E94D6=iSpace.ExecuteQuery(querySource4DA95BD5CD3F4A6D8AE54C8A839E94D6,@"Exec GetStageStatus 1,'','','" + ISpace["M_MoveToValue"].Value + @"','" + ISpace["M_SourceActivityMapId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource4DA95BD5CD3F4A6D8AE54C8A839E94D6 =GetQueryExpressionDataSource(""4DA95BD5-CD3F-4A6D-8AE5-4C8A839E94D6"");Dictionary<short,object> result4DA95BD5CD3F4A6D8AE54C8A839E94D6=iSpace.ExecuteQuery(querySource4DA95BD5CD3F4A6D8AE54C8A839E94D6,@""Exec GetStageStatus 1,'','','"" + ISpace[""M_MoveToValue""].Value + @""','"" + ISpace[""M_SourceActivityMapId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result4DA95BD5CD3F4A6D8AE54C8A839E94D6!=null) && (result4DA95BD5CD3F4A6D8AE54C8A839E94D6.Count!=0))
{
if(result4DA95BD5CD3F4A6D8AE54C8A839E94D6.ContainsKey(5))
ISpace["M_IsFlowReturned"].Value = result4DA95BD5CD3F4A6D8AE54C8A839E94D6[5];
if(result4DA95BD5CD3F4A6D8AE54C8A839E94D6.ContainsKey(6))
ISpace["M_IsCancelReject"].Value = result4DA95BD5CD3F4A6D8AE54C8A839E94D6[6];
if(result4DA95BD5CD3F4A6D8AE54C8A839E94D6.ContainsKey(4))
ISpace["M_FieldMandatory"].Value = result4DA95BD5CD3F4A6D8AE54C8A839E94D6[4];
if(result4DA95BD5CD3F4A6D8AE54C8A839E94D6.ContainsKey(1))
ISpace["M_RemarksMandatory"].Value = result4DA95BD5CD3F4A6D8AE54C8A839E94D6[1];
if(result4DA95BD5CD3F4A6D8AE54C8A839E94D6.ContainsKey(3))
ISpace["M_SaveDomainData"].Value = result4DA95BD5CD3F4A6D8AE54C8A839E94D6[3];
if(result4DA95BD5CD3F4A6D8AE54C8A839E94D6.ContainsKey(2))
ISpace["M_Remarks"].Value = result4DA95BD5CD3F4A6D8AE54C8A839E94D6[2];
if(result4DA95BD5CD3F4A6D8AE54C8A839E94D6.ContainsKey(0))
ISpace["M_NextStage"].Value = result4DA95BD5CD3F4A6D8AE54C8A839E94D6[0];
}
else{
ISpace["M_IsFlowReturned"].Value = null;ISpace["M_IsCancelReject"].Value = null;ISpace["M_FieldMandatory"].Value = null;ISpace["M_RemarksMandatory"].Value = null;ISpace["M_SaveDomainData"].Value = null;ISpace["M_Remarks"].Value = null;ISpace["M_NextStage"].Value = null;
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

using System.Collections.Generic;
using System;
using CPS.Proof.DFSExtension;
using System.Linq;using System.Data;
using System.Runtime.CompilerServices;
public class ISpace5E4661C9726C4AD7A4577C4A84E9192D : VirtualForm
{
IISpace iSpace = new ISpace();
AcDataISpace5E4661C9726C4AD7A4577C4A84E9192D acdataIspace5E4661C9726C4AD7A4577C4A84E9192D=new AcDataISpace5E4661C9726C4AD7A4577C4A84E9192D();
private void SubscribeFormEvents_root(ref Dictionary<string, ServiceElementData> ISpace)
{
try
{
base.WriteDebugInfo(@"Root-OnAfterFormLoad");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC [GetEmployeeUserContextDetails] '@@gv_UserId'");

var querySource09DA8B20908E4A22A295478F4E3F2DEB =GetQueryExpressionDataSource("09DA8B20-908E-4A22-A295-478F4E3F2DEB");
Dictionary<short,object> result09DA8B20908E4A22A295478F4E3F2DEB=iSpace.ExecuteQuery(querySource09DA8B20908E4A22A295478F4E3F2DEB,@"EXEC [GetEmployeeUserContextDetails] '" + ISpace["gv_userid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource09DA8B20908E4A22A295478F4E3F2DEB =GetQueryExpressionDataSource(""09DA8B20-908E-4A22-A295-478F4E3F2DEB"");Dictionary<short,object> result09DA8B20908E4A22A295478F4E3F2DEB=iSpace.ExecuteQuery(querySource09DA8B20908E4A22A295478F4E3F2DEB,@""EXEC [GetEmployeeUserContextDetails] '"" + ISpace[""gv_userid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result09DA8B20908E4A22A295478F4E3F2DEB!=null) && (result09DA8B20908E4A22A295478F4E3F2DEB.Count!=0))
{
if(result09DA8B20908E4A22A295478F4E3F2DEB.ContainsKey(4))
ISpace["UC_DOJ"].Value = result09DA8B20908E4A22A295478F4E3F2DEB[4];
if(result09DA8B20908E4A22A295478F4E3F2DEB.ContainsKey(3))
ISpace["UC_EmailId"].Value = result09DA8B20908E4A22A295478F4E3F2DEB[3];
if(result09DA8B20908E4A22A295478F4E3F2DEB.ContainsKey(5))
ISpace["UC_PhoneNumber"].Value = result09DA8B20908E4A22A295478F4E3F2DEB[5];
if(result09DA8B20908E4A22A295478F4E3F2DEB.ContainsKey(7))
ISpace["UC_Designation"].Value = result09DA8B20908E4A22A295478F4E3F2DEB[7];
if(result09DA8B20908E4A22A295478F4E3F2DEB.ContainsKey(0))
ISpace["UC_EmployeeBaicInfoId"].Value = result09DA8B20908E4A22A295478F4E3F2DEB[0];
if(result09DA8B20908E4A22A295478F4E3F2DEB.ContainsKey(1))
ISpace["UC_EmployeeId"].Value = result09DA8B20908E4A22A295478F4E3F2DEB[1];
if(result09DA8B20908E4A22A295478F4E3F2DEB.ContainsKey(9))
ISpace["UC_DOB"].Value = result09DA8B20908E4A22A295478F4E3F2DEB[9];
if(result09DA8B20908E4A22A295478F4E3F2DEB.ContainsKey(11))
ISpace["UC_Grade"].Value = result09DA8B20908E4A22A295478F4E3F2DEB[11];
if(result09DA8B20908E4A22A295478F4E3F2DEB.ContainsKey(10))
ISpace["UC_DOR"].Value = result09DA8B20908E4A22A295478F4E3F2DEB[10];
if(result09DA8B20908E4A22A295478F4E3F2DEB.ContainsKey(2))
ISpace["UC_Name"].Value = result09DA8B20908E4A22A295478F4E3F2DEB[2];
if(result09DA8B20908E4A22A295478F4E3F2DEB.ContainsKey(6))
ISpace["UC_Department"].Value = result09DA8B20908E4A22A295478F4E3F2DEB[6];
if(result09DA8B20908E4A22A295478F4E3F2DEB.ContainsKey(12))
ISpace["UC_Paylevel"].Value = result09DA8B20908E4A22A295478F4E3F2DEB[12];
}
else{
ISpace["UC_DOJ"].Value = null;ISpace["UC_EmailId"].Value = null;ISpace["UC_PhoneNumber"].Value = null;ISpace["UC_Designation"].Value = null;ISpace["UC_EmployeeBaicInfoId"].Value = null;ISpace["UC_EmployeeId"].Value = null;ISpace["UC_DOB"].Value = null;ISpace["UC_Grade"].Value = null;ISpace["UC_DOR"].Value = null;ISpace["UC_Name"].Value = null;ISpace["UC_Department"].Value = null;ISpace["UC_Paylevel"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["MFG_T2_ModeofJourney"].Visible="true";ISpace["MFG_T2_Departure"].Visible="true";ISpace["MFG_T2_Road"].Visible="true";ISpace["MFG_T2_DepartureDate"].Visible="true";ISpace["MFG_T2_ArrivalDate"].Visible="true";ISpace["MF_T1_BudgetHead"].Visible="true";ISpace["MF_T1_Destination"].Visible="true";ISpace["MFG_T2_Amount"].Visible="true";ISpace["MF_T1_AvailableBudget"].Visible="true";ISpace["MF_T1_JourneyPurpose"].Visible="true";ISpace["MFG_T2_PNRNo"].Visible="true";ISpace["MFG_T2_JourneyClass"].Visible="true";ISpace["MFG_T2_DepartureTime"].Visible="true";ISpace["MFG_T2_ToDate"].Visible="true";ISpace["MF_T1_AccountNo"].Visible="true";ISpace["MFG_T2_FromDate"].Visible="true";ISpace["MFG_T3_Amount"].Visible="true";ISpace["MF_T1_TravelType"].Visible="true";ISpace["MF_T1_BankBranch"].Visible="true";ISpace["MF_T1_ProjectNo"].Visible="true";ISpace["MFG_T2_ArrivalTime"].Visible="true";ISpace["MF_T1_AdvanceAmount"].Visible="true";ISpace["MF_T1_TravellingPerson"].Visible="true";ISpace["MF_T1_BeneficiaryName"].Visible="true";ISpace["MF_T1_BankDocument"].Visible="true";ISpace["MF_T1_TravelAdvanceID"].Visible="false";ISpace["MF_T1_BankName"].Visible="true";ISpace["MFG_T2_Arrival"].Visible="true";ISpace["MF_T1_ReferenceNo"].Visible="true";
base.WriteDebugInfo(@"ISpace[""MFG_T2_ModeofJourney""].Visible=""true"";ISpace[""MFG_T2_Departure""].Visible=""true"";ISpace[""MFG_T2_Road""].Visible=""true"";ISpace[""MFG_T2_DepartureDate""].Visible=""true"";ISpace[""MFG_T2_ArrivalDate""].Visible=""true"";ISpace[""MF_T1_BudgetHead""].Visible=""true"";ISpace[""MF_T1_Destination""].Visible=""true"";ISpace[""MFG_T2_Amount""].Visible=""true"";ISpace[""MF_T1_AvailableBudget""].Visible=""true"";ISpace[""MF_T1_JourneyPurpose""].Visible=""true"";ISpace[""MFG_T2_PNRNo""].Visible=""true"";ISpace[""MFG_T2_JourneyClass""].Visible=""true"";ISpace[""MFG_T2_DepartureTime""].Visible=""true"";ISpace[""MFG_T2_ToDate""].Visible=""true"";ISpace[""MF_T1_AccountNo""].Visible=""true"";ISpace[""MFG_T2_FromDate""].Visible=""true"";ISpace[""MFG_T3_Amount""].Visible=""true"";ISpace[""MF_T1_TravelType""].Visible=""true"";ISpace[""MF_T1_BankBranch""].Visible=""true"";ISpace[""MF_T1_ProjectNo""].Visible=""true"";ISpace[""MFG_T2_ArrivalTime""].Visible=""true"";ISpace[""MF_T1_AdvanceAmount""].Visible=""true"";ISpace[""MF_T1_TravellingPerson""].Visible=""true"";ISpace[""MF_T1_BeneficiaryName""].Visible=""true"";ISpace[""MF_T1_BankDocument""].Visible=""true"";ISpace[""MF_T1_TravelAdvanceID""].Visible=""false"";ISpace[""MF_T1_BankName""].Visible=""true"";ISpace[""MFG_T2_Arrival""].Visible=""true"";ISpace[""MF_T1_ReferenceNo""].Visible=""true"";");
ISpace["MG_T2_Arrival"].Visible="true";ISpace["MG_T2_Road"].Visible="true";ISpace["MG_T2_TADetailsID"].Visible="false";ISpace["MG_T2_PNRNo"].Visible="true";ISpace["MG_T2_Departure"].Visible="true";ISpace["MG_T2_DepartureDate"].Visible="true";ISpace["MG_T2_ArrivalDate"].Visible="true";ISpace["MG_T3_TravelAdvanceID"].Visible="false";ISpace["MG_T2_DepartureTime"].Visible="true";ISpace["MG_T2_JourneyClass"].Visible="true";ISpace["MG_T2_ModeofJourney"].Visible="true";ISpace["MG_T2_ArrivalTime"].Visible="true";ISpace["MG_T2_Amount"].Visible="true";
base.WriteDebugInfo(@"ISpace[""MG_T2_Arrival""].Visible=""true"";ISpace[""MG_T2_Road""].Visible=""true"";ISpace[""MG_T2_TADetailsID""].Visible=""false"";ISpace[""MG_T2_PNRNo""].Visible=""true"";ISpace[""MG_T2_Departure""].Visible=""true"";ISpace[""MG_T2_DepartureDate""].Visible=""true"";ISpace[""MG_T2_ArrivalDate""].Visible=""true"";ISpace[""MG_T3_TravelAdvanceID""].Visible=""false"";ISpace[""MG_T2_DepartureTime""].Visible=""true"";ISpace[""MG_T2_JourneyClass""].Visible=""true"";ISpace[""MG_T2_ModeofJourney""].Visible=""true"";ISpace[""MG_T2_ArrivalTime""].Visible=""true"";ISpace[""MG_T2_Amount""].Visible=""true"";");
ISpace["MG_T3_Amount"].Visible="true";ISpace["MG_T2_ExpenditureTypeID"].Visible="false";ISpace["MG_T2_FromDate"].Visible="true";ISpace["MG_T2_ToDate"].Visible="true";ISpace["MG_T2_TravelAdvanceID"].Visible="false";
base.WriteDebugInfo(@"ISpace[""MG_T3_Amount""].Visible=""true"";ISpace[""MG_T2_ExpenditureTypeID""].Visible=""false"";ISpace[""MG_T2_FromDate""].Visible=""true"";ISpace[""MG_T2_ToDate""].Visible=""true"";ISpace[""MG_T2_TravelAdvanceID""].Visible=""false"";");

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
ISpace["MF_ProjectNo"].Visible="false";ISpace["MF_BudgetHead"].Visible="false";ISpace["MF_Amount"].Visible="false";
base.WriteDebugInfo(@"ISpace[""MF_ProjectNo""].Visible=""false"";ISpace[""MF_BudgetHead""].Visible=""false"";ISpace[""MF_Amount""].Visible=""false"";");

ISpace["M_OpenModal"].Visible="false";
base.WriteDebugInfo(@"ISpace[""M_OpenModal""].Visible=""false"";");
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
ISpace["M_TravelInstanceId"].Value=Guid.NewGuid().ToString();
base.WriteDebugInfo(@"ISpace[""M_TravelInstanceId""].Value=Guid.NewGuid().ToString();");
ISpace["M_MoveTo"].Man=true;
base.WriteDebugInfo(@"ISpace[""M_MoveTo""].Man=true;");
ISpace["M_Remarks"].Value="";
base.WriteDebugInfo(@"ISpace[""M_Remarks""].Value="""";");
ISpace["M_NextStage"].Value="";
base.WriteDebugInfo(@"ISpace[""M_NextStage""].Value="""";");
ISpace["MF_TransactionDate"].Man=true;ISpace["MF_TransactionNo"].Man=true;
base.WriteDebugInfo(@"ISpace[""MF_TransactionDate""].Man=true;ISpace[""MF_TransactionNo""].Man=true;");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySourceA0ECD2B8980941FB814ECFF85B9E0A09 =GetQueryExpressionDataSource("A0ECD2B8-9809-41FB-814E-CFF85B9E0A09");

DataTable resultA0ECD2B8980941FB814ECFF85B9E0A09=iSpace.SetGridDataSource(querySourceA0ECD2B8980941FB814ECFF85B9E0A09, _objectFactory.GetGridRPP("MG_RemarksDetails"),@"EXEC GetRemarks '" + ISpace["M_InstanceId"].Value + @"'");

iSpace.InsertGridBindDetails("MG_RemarksDetails","11",querySourceA0ECD2B8980941FB814ECFF85B9E0A09,"EXEC GetRemarks '" + ISpace["M_InstanceId"].Value + @"'",_objectFactory.GetGridRPP("MG_RemarksDetails"));

base.WriteDebugInfo(@"var querySourceA0ECD2B8980941FB814ECFF85B9E0A09 =GetQueryExpressionDataSource(""A0ECD2B8-9809-41FB-814E-CFF85B9E0A09"");DataTable resultA0ECD2B8980941FB814ECFF85B9E0A09=iSpace.SetGridDataSource(querySourceA0ECD2B8980941FB814ECFF85B9E0A09, _objectFactory.GetGridRPP(""MG_RemarksDetails""),@""EXEC GetRemarks '"" + ISpace[""M_InstanceId""].Value + @""'"");iSpace.InsertGridBindDetails(""MG_RemarksDetails"",""11"",querySourceA0ECD2B8980941FB814ECFF85B9E0A09,""EXEC GetRemarks '"" + ISpace[""M_InstanceId""].Value + @""'"",_objectFactory.GetGridRPP(""MG_RemarksDetails""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> resultCBD3E108E08C4B5F8ACA817E51BDACD4=acdataIspace5E4661C9726C4AD7A4577C4A84E9192D.GetQueryExpressionBindings("CBD3E108-E08C-4B5F-8ACA-817E51BDACD4");
iSpace.SetGridData(resultA0ECD2B8980941FB814ECFF85B9E0A09,resultCBD3E108E08C4B5F8ACA817E51BDACD4,"MG_RemarksDetails",ref ISpace);
iSpace.UpdateGridBindDetails("MG_RemarksDetails",resultCBD3E108E08C4B5F8ACA817E51BDACD4);
}
ISpace["UC_DOJ"].Visible="false";ISpace["UC_EmailId"].Visible="false";ISpace["UC_PhoneNumber"].Visible="false";ISpace["UC_DOB"].Visible="false";ISpace["UC_Grade"].Visible="false";ISpace["UC_DOR"].Visible="false";ISpace["UC_Paylevel"].Visible="false";
base.WriteDebugInfo(@"ISpace[""UC_DOJ""].Visible=""false"";ISpace[""UC_EmailId""].Visible=""false"";ISpace[""UC_PhoneNumber""].Visible=""false"";ISpace[""UC_DOB""].Visible=""false"";ISpace[""UC_Grade""].Visible=""false"";ISpace[""UC_DOR""].Visible=""false"";ISpace[""UC_Paylevel""].Visible=""false"";");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["MFG_T2_ModeofJourney"].Man=true;ISpace["MFG_T2_Departure"].Man=true;ISpace["MFG_T2_Road"].Man=true;ISpace["MFG_T2_DepartureDate"].Man=true;ISpace["MFG_T2_ArrivalDate"].Man=true;ISpace["MF_T1_BudgetHead"].Man=true;ISpace["M_IsAdvanceRequired"].Man=true;ISpace["MF_T1_Destination"].Man=true;ISpace["MFG_T2_Amount"].Man=true;ISpace["MF_T1_AvailableBudget"].Man=true;ISpace["MF_T1_JourneyPurpose"].Man=true;ISpace["MFG_T2_PNRNo"].Man=false;ISpace["MFG_T2_JourneyClass"].Man=false;ISpace["MFG_T2_DepartureTime"].Man=true;ISpace["MFG_T2_ToDate"].Man=true;ISpace["M_TravelPlace"].Man=true;ISpace["MF_T1_AccountNo"].Man=true;ISpace["MFG_T2_FromDate"].Man=true;ISpace["MFG_T3_Amount"].Man=true;ISpace["MF_T1_TravelType"].Man=true;ISpace["MF_T1_BankBranch"].Man=true;ISpace["MF_T1_ProjectNo"].Man=true;ISpace["MFG_T2_ArrivalTime"].Man=true;ISpace["MF_T1_AdvanceAmount"].Man=true;ISpace["MF_T1_TravellingPerson"].Man=true;ISpace["MF_T1_BeneficiaryName"].Man=true;ISpace["MF_T1_BankDocument"].Man=true;ISpace["Travel_Type"].Man=true;ISpace["Travel_Type"].Enbl="true";ISpace["MF_T1_BankName"].Man=true;ISpace["MFG_T2_Arrival"].Man=true;ISpace["MF_T1_ReferenceNo"].Man=true;
base.WriteDebugInfo(@"ISpace[""MFG_T2_ModeofJourney""].Man=true;ISpace[""MFG_T2_Departure""].Man=true;ISpace[""MFG_T2_Road""].Man=true;ISpace[""MFG_T2_DepartureDate""].Man=true;ISpace[""MFG_T2_ArrivalDate""].Man=true;ISpace[""MF_T1_BudgetHead""].Man=true;ISpace[""M_IsAdvanceRequired""].Man=true;ISpace[""MF_T1_Destination""].Man=true;ISpace[""MFG_T2_Amount""].Man=true;ISpace[""MF_T1_AvailableBudget""].Man=true;ISpace[""MF_T1_JourneyPurpose""].Man=true;ISpace[""MFG_T2_PNRNo""].Man=false;ISpace[""MFG_T2_JourneyClass""].Man=false;ISpace[""MFG_T2_DepartureTime""].Man=true;ISpace[""MFG_T2_ToDate""].Man=true;ISpace[""M_TravelPlace""].Man=true;ISpace[""MF_T1_AccountNo""].Man=true;ISpace[""MFG_T2_FromDate""].Man=true;ISpace[""MFG_T3_Amount""].Man=true;ISpace[""MF_T1_TravelType""].Man=true;ISpace[""MF_T1_BankBranch""].Man=true;ISpace[""MF_T1_ProjectNo""].Man=true;ISpace[""MFG_T2_ArrivalTime""].Man=true;ISpace[""MF_T1_AdvanceAmount""].Man=true;ISpace[""MF_T1_TravellingPerson""].Man=true;ISpace[""MF_T1_BeneficiaryName""].Man=true;ISpace[""MF_T1_BankDocument""].Man=true;ISpace[""Travel_Type""].Man=true;ISpace[""Travel_Type""].Enbl=""true"";ISpace[""MF_T1_BankName""].Man=true;ISpace[""MFG_T2_Arrival""].Man=true;ISpace[""MF_T1_ReferenceNo""].Man=true;");
ISpace["MF_FundType"].Man=true;
base.WriteDebugInfo(@"ISpace[""MF_FundType""].Man=true;");
ISpace["MG_T2_Arrival"].Man=true;ISpace["MG_T2_Departure"].Man=true;ISpace["MG_T2_DepartureDate"].Man=true;ISpace["MG_T2_ArrivalDate"].Man=true;ISpace["MG_T2_DepartureTime"].Man=true;ISpace["MG_T2_JourneyClass"].Man=false;ISpace["MG_T2_ModeofJourney"].Man=true;ISpace["MG_T2_ArrivalTime"].Man=true;ISpace["MG_T2_Amount"].Man=true;
base.WriteDebugInfo(@"ISpace[""MG_T2_Arrival""].Man=true;ISpace[""MG_T2_Departure""].Man=true;ISpace[""MG_T2_DepartureDate""].Man=true;ISpace[""MG_T2_ArrivalDate""].Man=true;ISpace[""MG_T2_DepartureTime""].Man=true;ISpace[""MG_T2_JourneyClass""].Man=false;ISpace[""MG_T2_ModeofJourney""].Man=true;ISpace[""MG_T2_ArrivalTime""].Man=true;ISpace[""MG_T2_Amount""].Man=true;");
ISpace["MG_T3_Amount"].Man=true;ISpace["MG_T2_FromDate"].Man=true;ISpace["MG_T2_ToDate"].Man=true;
base.WriteDebugInfo(@"ISpace[""MG_T3_Amount""].Man=true;ISpace[""MG_T2_FromDate""].Man=true;ISpace[""MG_T2_ToDate""].Man=true;");
}
if(ISpace["Travel_Type"].Value=="1")
{
base.WriteDebugInfo(@"if(ISpace[""Travel_Type""].Value==""1"")");
ISpace["MF_T1_AccountNo"].Man=false;ISpace["MF_T1_BankBranch"].Man=false;ISpace["MF_T1_BeneficiaryName"].Man=false;ISpace["MF_T1_BankDocument"].Man=false;ISpace["MF_T1_BankName"].Man=false;
base.WriteDebugInfo(@"ISpace[""MF_T1_AccountNo""].Man=false;ISpace[""MF_T1_BankBranch""].Man=false;ISpace[""MF_T1_BeneficiaryName""].Man=false;ISpace[""MF_T1_BankDocument""].Man=false;ISpace[""MF_T1_BankName""].Man=false;");
}
if(ISpace["Travel_Type"].Value=="3")
{
base.WriteDebugInfo(@"if(ISpace[""Travel_Type""].Value==""3"")");
ISpace["MF_T1_AccountNo"].Man=true;ISpace["MF_T1_AccountNo"].Enbl="true";ISpace["MF_T1_BankBranch"].Man=true;ISpace["MF_T1_BankBranch"].Enbl="true";ISpace["MF_T1_AdvanceAmount"].Man=true;ISpace["MF_T1_AdvanceAmount"].Enbl="true";ISpace["MF_T1_BeneficiaryName"].Man=true;ISpace["MF_T1_BeneficiaryName"].Enbl="true";ISpace["MF_T1_BankDocument"].Man=true;ISpace["MF_T1_BankDocument"].Enbl="true";ISpace["MF_T1_BankName"].Man=true;ISpace["MF_T1_BankName"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_T1_AccountNo""].Man=true;ISpace[""MF_T1_AccountNo""].Enbl=""true"";ISpace[""MF_T1_BankBranch""].Man=true;ISpace[""MF_T1_BankBranch""].Enbl=""true"";ISpace[""MF_T1_AdvanceAmount""].Man=true;ISpace[""MF_T1_AdvanceAmount""].Enbl=""true"";ISpace[""MF_T1_BeneficiaryName""].Man=true;ISpace[""MF_T1_BeneficiaryName""].Enbl=""true"";ISpace[""MF_T1_BankDocument""].Man=true;ISpace[""MF_T1_BankDocument""].Enbl=""true"";ISpace[""MF_T1_BankName""].Man=true;ISpace[""MF_T1_BankName""].Enbl=""true"";");
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
ISpace["MFG_T2_Road"].Visible="false";ISpace["MFG_T2_Road"].Man=false;ISpace["MFG_T2_PNRNo"].Visible="false";ISpace["MFG_T2_PNRNo"].Man=false;
base.WriteDebugInfo(@"ISpace[""MFG_T2_Road""].Visible=""false"";ISpace[""MFG_T2_Road""].Man=false;ISpace[""MFG_T2_PNRNo""].Visible=""false"";ISpace[""MFG_T2_PNRNo""].Man=false;");
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
base.WriteDebugInfo(@"EXEC LoadFormGridData51838b372ec64d358a5e38648bc93ab1 '@@gv_InstanceId','@@gv_ProcessMapId','51838b37-2ec6-4d35-8a5e-38648bc93ab1','@@gv_ActivityMapId','#growid'");

var querySource4D420532A15346488F67A53328C6B6EC =GetQueryExpressionDataSource("4D420532-A153-4648-8F67-A53328C6B6EC");
Dictionary<short,object> result4D420532A15346488F67A53328C6B6EC=iSpace.ExecuteQuery(querySource4D420532A15346488F67A53328C6B6EC,@"EXEC LoadFormGridData51838b372ec64d358a5e38648bc93ab1 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','51838b37-2ec6-4d35-8a5e-38648bc93ab1','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["growid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource4D420532A15346488F67A53328C6B6EC =GetQueryExpressionDataSource(""4D420532-A153-4648-8F67-A53328C6B6EC"");Dictionary<short,object> result4D420532A15346488F67A53328C6B6EC=iSpace.ExecuteQuery(querySource4D420532A15346488F67A53328C6B6EC,@""EXEC LoadFormGridData51838b372ec64d358a5e38648bc93ab1 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','51838b37-2ec6-4d35-8a5e-38648bc93ab1','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""growid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result4D420532A15346488F67A53328C6B6EC!=null) && (result4D420532A15346488F67A53328C6B6EC.Count!=0))
{
if(result4D420532A15346488F67A53328C6B6EC.ContainsKey(3))
ISpace["MFG_T2_ToDate"].Value = result4D420532A15346488F67A53328C6B6EC[3];
if(result4D420532A15346488F67A53328C6B6EC.ContainsKey(2))
ISpace["MFG_T2_FromDate"].Value = result4D420532A15346488F67A53328C6B6EC[2];
if(result4D420532A15346488F67A53328C6B6EC.ContainsKey(0))
ISpace["MFG_T2_ExpenditureTypeID"].Value = result4D420532A15346488F67A53328C6B6EC[0];
if(result4D420532A15346488F67A53328C6B6EC.ContainsKey(4))
ISpace["MFG_T3_Amount"].Value = result4D420532A15346488F67A53328C6B6EC[4];
if(result4D420532A15346488F67A53328C6B6EC.ContainsKey(1))
ISpace["MFG_T2_TravelAdvanceID"].Value = result4D420532A15346488F67A53328C6B6EC[1];
}
else{
ISpace["MFG_T2_ToDate"].Value = null;ISpace["MFG_T2_FromDate"].Value = null;ISpace["MFG_T2_ExpenditureTypeID"].Value = null;ISpace["MFG_T3_Amount"].Value = null;ISpace["MFG_T2_TravelAdvanceID"].Value = null;
}
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
ISpace["MF_BudgetHead"].rElemData=iSpace.Reload(ISpace["MF_BudgetHead"].Value,@"exec SP_GetDistrubitionDetails 5,'@" + ISpace["gv_ProcessMapId"].Value + @"'," + ISpace["MF_FundType"].Value + @",'','','','','" + ISpace["MF_ProjectNo"].Value + @"'","9ADED37B-CD11-426B-AF16-DEAC75685EF5");
base.WriteDebugInfo(@"ISpace[""MF_BudgetHead""].rElemData=iSpace.Reload(ISpace[""MF_BudgetHead""].Value,@""exec SP_GetDistrubitionDetails 5,'@"" + ISpace[""gv_ProcessMapId""].Value + @""',"" + ISpace[""MF_FundType""].Value + @"",'','','','','"" + ISpace[""MF_ProjectNo""].Value + @""'"",""9ADED37B-CD11-426B-AF16-DEAC75685EF5"");");
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

var querySource797A60C10BB64A40915695B92AAFC889 =GetQueryExpressionDataSource("797A60C1-0BB6-4A40-9156-95B92AAFC889");
Dictionary<short,object> result797A60C10BB64A40915695B92AAFC889=iSpace.ExecuteQuery(querySource797A60C10BB64A40915695B92AAFC889,@"SELECT " + ISpace["OverAll_Total"].Value + @"*0.9",false);

base.WriteDebugInfo(@"var querySource797A60C10BB64A40915695B92AAFC889 =GetQueryExpressionDataSource(""797A60C1-0BB6-4A40-9156-95B92AAFC889"");Dictionary<short,object> result797A60C10BB64A40915695B92AAFC889=iSpace.ExecuteQuery(querySource797A60C10BB64A40915695B92AAFC889,@""SELECT "" + ISpace[""OverAll_Total""].Value + @""*0.9"",false);");
base.WriteDebugInfo(@"");

if((result797A60C10BB64A40915695B92AAFC889!=null) && (result797A60C10BB64A40915695B92AAFC889.Count!=0))
{
if(result797A60C10BB64A40915695B92AAFC889.ContainsKey(0))
ISpace["T_AdvanceDrawn"].Value = result797A60C10BB64A40915695B92AAFC889[0];
}
else{
ISpace["T_AdvanceDrawn"].Value = null;
}
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

var querySource797A60C10BB64A40915695B92AAFC889 =GetQueryExpressionDataSource("797A60C1-0BB6-4A40-9156-95B92AAFC889");
Dictionary<short,object> result797A60C10BB64A40915695B92AAFC889=iSpace.ExecuteQuery(querySource797A60C10BB64A40915695B92AAFC889,@"SELECT " + ISpace["OverAll_Total"].Value + @"*0.9",false);

base.WriteDebugInfo(@"var querySource797A60C10BB64A40915695B92AAFC889 =GetQueryExpressionDataSource(""797A60C1-0BB6-4A40-9156-95B92AAFC889"");Dictionary<short,object> result797A60C10BB64A40915695B92AAFC889=iSpace.ExecuteQuery(querySource797A60C10BB64A40915695B92AAFC889,@""SELECT "" + ISpace[""OverAll_Total""].Value + @""*0.9"",false);");
base.WriteDebugInfo(@"");

if((result797A60C10BB64A40915695B92AAFC889!=null) && (result797A60C10BB64A40915695B92AAFC889.Count!=0))
{
if(result797A60C10BB64A40915695B92AAFC889.ContainsKey(0))
ISpace["T_AdvanceDrawn"].Value = result797A60C10BB64A40915695B92AAFC889[0];
}
else{
ISpace["T_AdvanceDrawn"].Value = null;
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
object MG_Amount=iSpace.Sum("[AD9C54EC-27A0-4C21-9923-063084E3B588]","MG_Amount","",ISpace["gv_instanceid"].Value);
ISpace["M_SumOfFund"].Value=Convert.ChangeType(MG_Amount, MG_Amount.GetType());;
base.WriteDebugInfo(@"object MG_Amount=iSpace.Sum(""[AD9C54EC-27A0-4C21-9923-063084E3B588]"",""MG_Amount"","""",ISpace[""gv_instanceid""].Value);
ISpace[""M_SumOfFund""].Value=Convert.ChangeType(MG_Amount, MG_Amount.GetType());;");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["Travel_Type"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""Travel_Type""].Value=="""")");
ISpace["Message"].Value=@"Please enter the Travel Type";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please enter the Travel Type"";");
return;
base.WriteDebugInfo(@"return;");
}
if(ISpace["M_TravelPlace"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""M_TravelPlace""].Value=="""")");
ISpace["Message"].Value=@"Please enter the Place of Travel";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please enter the Place of Travel"";");
return;
base.WriteDebugInfo(@"return;");
}
if(Trim(ISpace["MF_T1_JourneyPurpose"].Value)=="")
{
base.WriteDebugInfo(@"if(Trim(ISpace[""MF_T1_JourneyPurpose""].Value)=="""")");
ISpace["Message"].Value=@"Please enter the Purpose of Travel";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please enter the Purpose of Travel"";");
return;
base.WriteDebugInfo(@"return;");
}
if(ISpace["M_IsAdvanceRequired"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""M_IsAdvanceRequired""].Value=="""")");
ISpace["Message"].Value=@"Please select Is Advance Required";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please select Is Advance Required"";");
return;
base.WriteDebugInfo(@"return;");
}
if(Trim(ISpace["MF_T1_BankBranch"].Value)==""&&ISpace["Travel_Type"].Value=="3")
{
base.WriteDebugInfo(@"if(Trim(ISpace[""MF_T1_BankBranch""].Value)==""""&&ISpace[""Travel_Type""].Value==""3"")");
ISpace["Message"].Value=@"Please enter the Bank Branch";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please enter the Bank Branch"";");
return;
base.WriteDebugInfo(@"return;");
}
if(Trim(ISpace["MF_T1_BeneficiaryName"].Value)==""&&ISpace["Travel_Type"].Value=="3")
{
base.WriteDebugInfo(@"if(Trim(ISpace[""MF_T1_BeneficiaryName""].Value)==""""&&ISpace[""Travel_Type""].Value==""3"")");
ISpace["Message"].Value=@"Please enter the Beneficiary Name";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please enter the Beneficiary Name"";");
return;
base.WriteDebugInfo(@"return;");
}
if(Trim(ISpace["MF_T1_AccountNo"].Value)==""&&ISpace["Travel_Type"].Value=="3")
{
base.WriteDebugInfo(@"if(Trim(ISpace[""MF_T1_AccountNo""].Value)==""""&&ISpace[""Travel_Type""].Value==""3"")");
ISpace["Message"].Value=@"Please enter the Account No";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please enter the Account No"";");
return;
base.WriteDebugInfo(@"return;");
}
if(Trim(ISpace["MF_T1_BankName"].Value)==""&&ISpace["Travel_Type"].Value=="3")
{
base.WriteDebugInfo(@"if(Trim(ISpace[""MF_T1_BankName""].Value)==""""&&ISpace[""Travel_Type""].Value==""3"")");
ISpace["Message"].Value=@"Please enter the Bank Name";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please enter the Bank Name"";");
return;
base.WriteDebugInfo(@"return;");
}
if((ISpace["MF_T1_BankDocument"].Value == null)&&ISpace["Travel_Type"].Value=="3")
{
base.WriteDebugInfo(@"if((ISpace[""MF_T1_BankDocument""].Value == null)&&ISpace[""Travel_Type""].Value==""3"")");
ISpace["Message"].Value=@"Please enter the Bank Document";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please enter the Bank Document"";");
return;
base.WriteDebugInfo(@"return;");
}
if(ISpace["M_IsAdvanceRequired"].Value=="Yes")
{
base.WriteDebugInfo(@"if(ISpace[""M_IsAdvanceRequired""].Value==""Yes"")");
if(ISpace["MF_T1_AdvanceAmount"].Value==0)
{
base.WriteDebugInfo(@"if(ISpace[""MF_T1_AdvanceAmount""].Value==0)");
ISpace["Message"].Value=@"Please enter the Advance Amount";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please enter the Advance Amount"";");
return;
base.WriteDebugInfo(@"return;");
}
if(ISpace["T_AdvanceDrawn"].Value<ISpace["MF_T1_AdvanceAmount"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""T_AdvanceDrawn""].Value<ISpace[""MF_T1_AdvanceAmount""].Value)");
ISpace["Message"].Value=@"Eligible Advance and Advance Amount should be Equal or lesser than";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Eligible Advance and Advance Amount should be Equal or lesser than"";");
return;
base.WriteDebugInfo(@"return;");
}
}
if(ISpace["M_IsAdvanceRequired"].Value=="Yes")
{
base.WriteDebugInfo(@"if(ISpace[""M_IsAdvanceRequired""].Value==""Yes"")");
if(ISpace["M_SumOfFund"].Value!=ISpace["MF_T1_AdvanceAmount"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""M_SumOfFund""].Value!=ISpace[""MF_T1_AdvanceAmount""].Value)");
ISpace["Message"].Value=@"Please add Source Fund Amount equal to Advance Amount";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please add Source Fund Amount equal to Advance Amount"";");
return;
base.WriteDebugInfo(@"return;");
}
}
if(ISpace["MF_CountDoc"].Value>0)
{
base.WriteDebugInfo(@"if(ISpace[""MF_CountDoc""].Value>0)");
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
return;
base.WriteDebugInfo(@"return;");
}

if(
IsNullOrEmpty(ISpace["M_UploadDcoument"].Value))
{
base.WriteDebugInfo(@"
if(
IsNullOrEmpty(ISpace[""M_UploadDcoument""].Value))");
ISpace["Message"].Value=@"Please Upload Document";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please Upload Document"";");
return;
base.WriteDebugInfo(@"return;");
}
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("MG_DcoumentDetails","B5EF84C8-83A9-4B1C-9431-0489F9EC063B",_objectFactory.GetGridRPP("MG_DcoumentDetails"),_elementBase.GetGridLoopQuery("B5EF84C8-83A9-4B1C-9431-0489F9EC063B","MG_DcoumentDetails",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""MG_DcoumentDetails"",ref ISpace);

foreach(var gridChild in ISpace[""MG_DcoumentDetails""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
}
}
ISpace["MF_TravelStatus"].Value="I";
base.WriteDebugInfo(@"ISpace[""MF_TravelStatus""].Value=""I"";");
ISpace["M_IsCommitment"].Value=1;
base.WriteDebugInfo(@"ISpace[""M_IsCommitment""].Value=1;");
if(ISpace["M_MoveTo"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""M_MoveTo""].Value=="""")");
ISpace["Message"].Value=@"Move To should be mandatory";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Move To should be mandatory"";");
return;
base.WriteDebugInfo(@"return;");
}
base.WriteDebugInfo(@"EXEC Repo198E5A8A61F54E7C92DD34146A7059EF '#CreatedOn','#MF_T1_BankDocument','#MF_T1_ReferenceNo','#MF_T1_AccountNo','#OverAll_Total','#UC_EmployeeBaicInfoId','#M_TravelPlace','#MF_T1_AdvanceAmount','#MF_T1_BankName','#MF_T1_TravelAdvanceID','#MF_T1_JourneyPurpose','#Travel_Type','#MF_T1_BeneficiaryName','#gv_UserId','#MF_TransactionNo','#MF_TravelStatus','#MF_TransactionDate','#M_IsAdvanceRequired'");

var querySource5BE98974AD594580A75130D0492B011E =GetQueryExpressionDataSource("5BE98974-AD59-4580-A751-30D0492B011E");
Dictionary<short,object> result5BE98974AD594580A75130D0492B011E=iSpace.ExecuteQuery(querySource5BE98974AD594580A75130D0492B011E,@"EXEC Repo198E5A8A61F54E7C92DD34146A7059EF '" + ISpace["CreatedOn"].Value + @"','" + ISpace["MF_T1_BankDocument"].Value + @"','" + ISpace["MF_T1_ReferenceNo"].Value + @"','" + ISpace["MF_T1_AccountNo"].Value + @"','" + ISpace["OverAll_Total"].Value + @"','" + ISpace["UC_EmployeeBaicInfoId"].Value + @"','" + ISpace["M_TravelPlace"].Value + @"','" + ISpace["MF_T1_AdvanceAmount"].Value + @"','" + ISpace["MF_T1_BankName"].Value + @"','" + ISpace["MF_T1_TravelAdvanceID"].Value + @"','" + ISpace["MF_T1_JourneyPurpose"].Value + @"','" + ISpace["Travel_Type"].Value + @"','" + ISpace["MF_T1_BeneficiaryName"].Value + @"','" + ISpace["gv_UserId"].Value + @"','" + ISpace["MF_TransactionNo"].Value + @"','" + ISpace["MF_TravelStatus"].Value + @"','" + ISpace["MF_TransactionDate"].Value + @"','" + ISpace["M_IsAdvanceRequired"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource5BE98974AD594580A75130D0492B011E =GetQueryExpressionDataSource(""5BE98974-AD59-4580-A751-30D0492B011E"");Dictionary<short,object> result5BE98974AD594580A75130D0492B011E=iSpace.ExecuteQuery(querySource5BE98974AD594580A75130D0492B011E,@""EXEC Repo198E5A8A61F54E7C92DD34146A7059EF '"" + ISpace[""CreatedOn""].Value + @""','"" + ISpace[""MF_T1_BankDocument""].Value + @""','"" + ISpace[""MF_T1_ReferenceNo""].Value + @""','"" + ISpace[""MF_T1_AccountNo""].Value + @""','"" + ISpace[""OverAll_Total""].Value + @""','"" + ISpace[""UC_EmployeeBaicInfoId""].Value + @""','"" + ISpace[""M_TravelPlace""].Value + @""','"" + ISpace[""MF_T1_AdvanceAmount""].Value + @""','"" + ISpace[""MF_T1_BankName""].Value + @""','"" + ISpace[""MF_T1_TravelAdvanceID""].Value + @""','"" + ISpace[""MF_T1_JourneyPurpose""].Value + @""','"" + ISpace[""Travel_Type""].Value + @""','"" + ISpace[""MF_T1_BeneficiaryName""].Value + @""','"" + ISpace[""gv_UserId""].Value + @""','"" + ISpace[""MF_TransactionNo""].Value + @""','"" + ISpace[""MF_TravelStatus""].Value + @""','"" + ISpace[""MF_TransactionDate""].Value + @""','"" + ISpace[""M_IsAdvanceRequired""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result5BE98974AD594580A75130D0492B011E!=null) && (result5BE98974AD594580A75130D0492B011E.Count!=0))
{
}
else{

}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"#MF_FundAmount[Rows]");
iSpace.GetLoopExpressionData("MF_FundAmount",ref ISpace);

foreach(var gridChild in ISpace["MF_FundAmount"].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 

base.WriteDebugInfo(@"EXEC UpsertProjectBudgetDetails 5,'#MG_ProjectDetailsId','#MF_T1_TravelAdvanceID','#MG_Amount','#MG_BudgetHead','#M_IsCommitment','#MG_FundTypeid','#M_PackageProcessMapId','#UC_EmployeeBaicInfoId'");

var querySource13D4A6E9DC9143DCB6A1C740A96DAFA6 =GetQueryExpressionDataSource("13D4A6E9-DC91-43DC-B6A1-C740A96DAFA6");
Dictionary<short,object> result13D4A6E9DC9143DCB6A1C740A96DAFA6=iSpace.ExecuteQuery(querySource13D4A6E9DC9143DCB6A1C740A96DAFA6,@"EXEC UpsertProjectBudgetDetails 5,'" + ISpace["MG_ProjectDetailsId"].Value + @"','" + ISpace["MF_T1_TravelAdvanceID"].Value + @"','" + ISpace["MG_Amount"].Value + @"','" + ISpace["MG_BudgetHead"].Value + @"','" + ISpace["M_IsCommitment"].Value + @"','" + ISpace["MG_FundTypeid"].Value + @"','" + ISpace["M_PackageProcessMapId"].Value + @"','" + ISpace["UC_EmployeeBaicInfoId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource13D4A6E9DC9143DCB6A1C740A96DAFA6 =GetQueryExpressionDataSource(""13D4A6E9-DC91-43DC-B6A1-C740A96DAFA6"");Dictionary<short,object> result13D4A6E9DC9143DCB6A1C740A96DAFA6=iSpace.ExecuteQuery(querySource13D4A6E9DC9143DCB6A1C740A96DAFA6,@""EXEC UpsertProjectBudgetDetails 5,'"" + ISpace[""MG_ProjectDetailsId""].Value + @""','"" + ISpace[""MF_T1_TravelAdvanceID""].Value + @""','"" + ISpace[""MG_Amount""].Value + @""','"" + ISpace[""MG_BudgetHead""].Value + @""','"" + ISpace[""M_IsCommitment""].Value + @""','"" + ISpace[""MG_FundTypeid""].Value + @""','"" + ISpace[""M_PackageProcessMapId""].Value + @""','"" + ISpace[""UC_EmployeeBaicInfoId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result13D4A6E9DC9143DCB6A1C740A96DAFA6!=null) && (result13D4A6E9DC9143DCB6A1C740A96DAFA6.Count!=0))
{
if(result13D4A6E9DC9143DCB6A1C740A96DAFA6.ContainsKey(0))
ISpace["A"].Value = result13D4A6E9DC9143DCB6A1C740A96DAFA6[0];
}
else{
ISpace["A"].Value = null;
}
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("MF_FundAmount","AD9C54EC-27A0-4C21-9923-063084E3B588",_objectFactory.GetGridRPP("MF_FundAmount"),_elementBase.GetGridLoopQuery("AD9C54EC-27A0-4C21-9923-063084E3B588","MF_FundAmount",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""MF_FundAmount"",ref ISpace);

foreach(var gridChild in ISpace[""MF_FundAmount""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
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
object MG_T2_Amount=iSpace.Sum("[FA412DDD-7AD9-49AF-B8D7-2B7E1620D8FC]","MG_T2_Amount","",ISpace["gv_instanceid"].Value);
ISpace["T_TravelAdvanceTotal"].Value=Convert.ChangeType(MG_T2_Amount, MG_T2_Amount.GetType());;
base.WriteDebugInfo(@"object MG_T2_Amount=iSpace.Sum(""[FA412DDD-7AD9-49AF-B8D7-2B7E1620D8FC]"",""MG_T2_Amount"","""",ISpace[""gv_instanceid""].Value);
ISpace[""T_TravelAdvanceTotal""].Value=Convert.ChangeType(MG_T2_Amount, MG_T2_Amount.GetType());;");
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
ISpace["MF_ProjectNo"].Visible="true";ISpace["MF_ProjectNo"].Man=true;ISpace["MF_BudgetHead"].Visible="true";ISpace["MF_BudgetHead"].Man=true;ISpace["MF_Amount"].Visible="true";ISpace["MF_Amount"].Man=true;
base.WriteDebugInfo(@"ISpace[""MF_ProjectNo""].Visible=""true"";ISpace[""MF_ProjectNo""].Man=true;ISpace[""MF_BudgetHead""].Visible=""true"";ISpace[""MF_BudgetHead""].Man=true;ISpace[""MF_Amount""].Visible=""true"";ISpace[""MF_Amount""].Man=true;");
ISpace["M_OpenModal"].Visible="true";
base.WriteDebugInfo(@"ISpace[""M_OpenModal""].Visible=""true"";");
ISpace["MF_BudgetHead"].rElemData=iSpace.Reload(ISpace["MF_BudgetHead"].Value,@"exec SP_GetDistrubitionDetails 5,'@" + ISpace["gv_ProcessMapId"].Value + @"'," + ISpace["MF_FundType"].Value + @",'','','','','" + ISpace["MF_ProjectNo"].Value + @"'","9ADED37B-CD11-426B-AF16-DEAC75685EF5");
base.WriteDebugInfo(@"ISpace[""MF_BudgetHead""].rElemData=iSpace.Reload(ISpace[""MF_BudgetHead""].Value,@""exec SP_GetDistrubitionDetails 5,'@"" + ISpace[""gv_ProcessMapId""].Value + @""',"" + ISpace[""MF_FundType""].Value + @"",'','','','','"" + ISpace[""MF_ProjectNo""].Value + @""'"",""9ADED37B-CD11-426B-AF16-DEAC75685EF5"");");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_ProjectNo"].Visible="false";ISpace["MF_ProjectNo"].Man=false;ISpace["MF_BudgetHead"].Visible="false";ISpace["MF_BudgetHead"].Man=false;ISpace["MF_Amount"].Visible="true";ISpace["MF_Amount"].Man=true;
base.WriteDebugInfo(@"ISpace[""MF_ProjectNo""].Visible=""false"";ISpace[""MF_ProjectNo""].Man=false;ISpace[""MF_BudgetHead""].Visible=""false"";ISpace[""MF_BudgetHead""].Man=false;ISpace[""MF_Amount""].Visible=""true"";ISpace[""MF_Amount""].Man=true;");
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

var querySourceDFBF6D4681E041F694F45547F670F5AF =GetQueryExpressionDataSource("DFBF6D46-81E0-41F6-94F4-5547F670F5AF");
Dictionary<short,object> resultDFBF6D4681E041F694F45547F670F5AF=iSpace.ExecuteQuery(querySourceDFBF6D4681E041F694F45547F670F5AF,@"EXEC GetAvailableBudget '" + ISpace["MF_T1_BudgetHead"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceDFBF6D4681E041F694F45547F670F5AF =GetQueryExpressionDataSource(""DFBF6D46-81E0-41F6-94F4-5547F670F5AF"");Dictionary<short,object> resultDFBF6D4681E041F694F45547F670F5AF=iSpace.ExecuteQuery(querySourceDFBF6D4681E041F694F45547F670F5AF,@""EXEC GetAvailableBudget '"" + ISpace[""MF_T1_BudgetHead""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultDFBF6D4681E041F694F45547F670F5AF!=null) && (resultDFBF6D4681E041F694F45547F670F5AF.Count!=0))
{
if(resultDFBF6D4681E041F694F45547F670F5AF.ContainsKey(0))
ISpace["MF_T1_AvailableBudget"].Value = resultDFBF6D4681E041F694F45547F670F5AF[0];
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
private void SubscribeElementEvents_save_travelexpense (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Save_TravelExpense-OnClick");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MFG_T2_ModeofJourney"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""MFG_T2_ModeofJourney""].Value=="""")");
ISpace["Message"].Value=@"Please Enter the Mode of Journey";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please Enter the Mode of Journey"";");
return;
base.WriteDebugInfo(@"return;");
}
if(Trim(ISpace["MFG_T2_Departure"].Value)=="")
{
base.WriteDebugInfo(@"if(Trim(ISpace[""MFG_T2_Departure""].Value)=="""")");
ISpace["Message"].Value=@"Please Enter the Departure";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please Enter the Departure"";");
return;
base.WriteDebugInfo(@"return;");
}
if((ISpace["MFG_T2_DepartureDate"].Value == null))
{
base.WriteDebugInfo(@"if((ISpace[""MFG_T2_DepartureDate""].Value == null))");
ISpace["Message"].Value=@"Please Enter the Departure Date";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please Enter the Departure Date"";");
return;
base.WriteDebugInfo(@"return;");
}
if(Trim(ISpace["MFG_T2_Arrival"].Value)=="")
{
base.WriteDebugInfo(@"if(Trim(ISpace[""MFG_T2_Arrival""].Value)=="""")");
ISpace["Message"].Value=@"Please Enter the Arrival";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please Enter the Arrival"";");
return;
base.WriteDebugInfo(@"return;");
}
if((ISpace["MFG_T2_ArrivalDate"].Value == null))
{
base.WriteDebugInfo(@"if((ISpace[""MFG_T2_ArrivalDate""].Value == null))");
ISpace["Message"].Value=@"Please Enter the Arrival Date";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please Enter the Arrival Date"";");
return;
base.WriteDebugInfo(@"return;");
}
if(ISpace["MFG_T2_ArrivalDate"].Value<ISpace["MFG_T2_DepartureDate"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MFG_T2_ArrivalDate""].Value<ISpace[""MFG_T2_DepartureDate""].Value)");
ISpace["Message"].Value=@"Arrival Date should be greater than Departure Date";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Arrival Date should be greater than Departure Date"";");
ISpace["MFG_T2_ArrivalDate"].Value=null;
base.WriteDebugInfo(@"ISpace[""MFG_T2_ArrivalDate""].Value=null;");
return;
base.WriteDebugInfo(@"return;");
}
if(ISpace["MFG_T2_Amount"].Value==0)
{
base.WriteDebugInfo(@"if(ISpace[""MFG_T2_Amount""].Value==0)");
ISpace["Message"].Value=@"Please Enter the Amount";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please Enter the Amount"";");
return;
base.WriteDebugInfo(@"return;");
}
}
if(ISpace["growid"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""growid""].Value=="""")");

var querySourceD659A8A182614852878E8F0B73B79721 =GetQueryExpressionDataSource("D659A8A1-8261-4852-878E-8F0B73B79721");

DataTable resultD659A8A182614852878E8F0B73B79721=iSpace.SetGridDataSource(querySourceD659A8A182614852878E8F0B73B79721, _objectFactory.GetGridRPP("TravelExpense"),@"EXEC AddFormGridData374fb8a88dd94cf1bf73f40ae18fcad7 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["MFG_T2_TADetailsID"].Value + @"','" + ISpace["MFG_T2_TravelAdvanceID"].Value + @"','" + ISpace["MFG_T2_Departure"].Value + @"','" + ISpace["MFG_T2_DepartureDate"].Value + @"','" + ISpace["MFG_T2_DepartureTime"].Value + @"','" + ISpace["MFG_T2_Arrival"].Value + @"','" + ISpace["MFG_T2_ArrivalDate"].Value + @"','" + ISpace["MFG_T2_ArrivalTime"].Value + @"','" + ISpace["MFG_T2_ModeofJourney"].Value + @"','" + ISpace["MFG_T2_JourneyClass"].Value + @"'," + ISpace["MFG_T2_Road"].Value + @",'" + ISpace["MFG_T2_PNRNo"].Value + @"'," + ISpace["MFG_T2_Amount"].Value + @",'" + ISpace["growid"].Value + @"'");

iSpace.InsertGridBindDetails("TravelExpense","11",querySourceD659A8A182614852878E8F0B73B79721,"EXEC AddFormGridData374fb8a88dd94cf1bf73f40ae18fcad7 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["MFG_T2_TADetailsID"].Value + @"','" + ISpace["MFG_T2_TravelAdvanceID"].Value + @"','" + ISpace["MFG_T2_Departure"].Value + @"','" + ISpace["MFG_T2_DepartureDate"].Value + @"','" + ISpace["MFG_T2_DepartureTime"].Value + @"','" + ISpace["MFG_T2_Arrival"].Value + @"','" + ISpace["MFG_T2_ArrivalDate"].Value + @"','" + ISpace["MFG_T2_ArrivalTime"].Value + @"','" + ISpace["MFG_T2_ModeofJourney"].Value + @"','" + ISpace["MFG_T2_JourneyClass"].Value + @"'," + ISpace["MFG_T2_Road"].Value + @",'" + ISpace["MFG_T2_PNRNo"].Value + @"'," + ISpace["MFG_T2_Amount"].Value + @",'" + ISpace["growid"].Value + @"'",_objectFactory.GetGridRPP("TravelExpense"));

base.WriteDebugInfo(@"var querySourceD659A8A182614852878E8F0B73B79721 =GetQueryExpressionDataSource(""D659A8A1-8261-4852-878E-8F0B73B79721"");DataTable resultD659A8A182614852878E8F0B73B79721=iSpace.SetGridDataSource(querySourceD659A8A182614852878E8F0B73B79721, _objectFactory.GetGridRPP(""TravelExpense""),@""EXEC AddFormGridData374fb8a88dd94cf1bf73f40ae18fcad7 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""MFG_T2_TADetailsID""].Value + @""','"" + ISpace[""MFG_T2_TravelAdvanceID""].Value + @""','"" + ISpace[""MFG_T2_Departure""].Value + @""','"" + ISpace[""MFG_T2_DepartureDate""].Value + @""','"" + ISpace[""MFG_T2_DepartureTime""].Value + @""','"" + ISpace[""MFG_T2_Arrival""].Value + @""','"" + ISpace[""MFG_T2_ArrivalDate""].Value + @""','"" + ISpace[""MFG_T2_ArrivalTime""].Value + @""','"" + ISpace[""MFG_T2_ModeofJourney""].Value + @""','"" + ISpace[""MFG_T2_JourneyClass""].Value + @""',"" + ISpace[""MFG_T2_Road""].Value + @"",'"" + ISpace[""MFG_T2_PNRNo""].Value + @""',"" + ISpace[""MFG_T2_Amount""].Value + @"",'"" + ISpace[""growid""].Value + @""'"");iSpace.InsertGridBindDetails(""TravelExpense"",""11"",querySourceD659A8A182614852878E8F0B73B79721,""EXEC AddFormGridData374fb8a88dd94cf1bf73f40ae18fcad7 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""MFG_T2_TADetailsID""].Value + @""','"" + ISpace[""MFG_T2_TravelAdvanceID""].Value + @""','"" + ISpace[""MFG_T2_Departure""].Value + @""','"" + ISpace[""MFG_T2_DepartureDate""].Value + @""','"" + ISpace[""MFG_T2_DepartureTime""].Value + @""','"" + ISpace[""MFG_T2_Arrival""].Value + @""','"" + ISpace[""MFG_T2_ArrivalDate""].Value + @""','"" + ISpace[""MFG_T2_ArrivalTime""].Value + @""','"" + ISpace[""MFG_T2_ModeofJourney""].Value + @""','"" + ISpace[""MFG_T2_JourneyClass""].Value + @""',"" + ISpace[""MFG_T2_Road""].Value + @"",'"" + ISpace[""MFG_T2_PNRNo""].Value + @""',"" + ISpace[""MFG_T2_Amount""].Value + @"",'"" + ISpace[""growid""].Value + @""'"",_objectFactory.GetGridRPP(""TravelExpense""));");
base.WriteDebugInfo(@"EXEC AddFormGridData374fb8a88dd94cf1bf73f40ae18fcad7 '@@gv_InstanceId','@@gv_ProcessMapId','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','@@gv_ActivityMapId','#MFG_T2_TADetailsID','#MFG_T2_TravelAdvanceID','#MFG_T2_Departure','#MFG_T2_DepartureDate','#MFG_T2_DepartureTime','#MFG_T2_Arrival','#MFG_T2_ArrivalDate','#MFG_T2_ArrivalTime','#MFG_T2_ModeofJourney','#MFG_T2_JourneyClass',#MFG_T2_Road,'#MFG_T2_PNRNo',#MFG_T3_Amount,'#growid'");


List<Triplet<string, short, short?>> result8F99128D9EF74BCF8A425714C2D6D166=acdataIspace5E4661C9726C4AD7A4577C4A84E9192D.GetQueryExpressionBindings("8F99128D-9EF7-4BCF-8A42-5714C2D6D166");
iSpace.SetGridData(resultD659A8A182614852878E8F0B73B79721,result8F99128D9EF74BCF8A425714C2D6D166,"TravelExpense",ref ISpace);
iSpace.UpdateGridBindDetails("TravelExpense",result8F99128D9EF74BCF8A425714C2D6D166);
}
else
{
base.WriteDebugInfo(@"else");

var querySourceAFBC2448576140CFA8EB1C60C3DC33D1 =GetQueryExpressionDataSource("AFBC2448-5761-40CF-A8EB-1C60C3DC33D1");

DataTable resultAFBC2448576140CFA8EB1C60C3DC33D1=iSpace.SetGridDataSource(querySourceAFBC2448576140CFA8EB1C60C3DC33D1, _objectFactory.GetGridRPP("TravelExpense"),@"EXEC UpdateFormGridData374fb8a88dd94cf1bf73f40ae18fcad7 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["MFG_T2_TADetailsID"].Value + @"','" + ISpace["MFG_T2_TravelAdvanceID"].Value + @"','" + ISpace["MFG_T2_Departure"].Value + @"','" + ISpace["MFG_T2_DepartureDate"].Value + @"','" + ISpace["MFG_T2_DepartureTime"].Value + @"','" + ISpace["MFG_T2_Arrival"].Value + @"','" + ISpace["MFG_T2_ArrivalDate"].Value + @"','" + ISpace["MFG_T2_ArrivalTime"].Value + @"','" + ISpace["MFG_T2_ModeofJourney"].Value + @"','" + ISpace["MFG_T2_JourneyClass"].Value + @"'," + ISpace["MFG_T2_Road"].Value + @",'" + ISpace["MFG_T2_PNRNo"].Value + @"'," + ISpace["MFG_T2_Amount"].Value + @",'" + ISpace["growid"].Value + @"'");

iSpace.InsertGridBindDetails("TravelExpense","11",querySourceAFBC2448576140CFA8EB1C60C3DC33D1,"EXEC UpdateFormGridData374fb8a88dd94cf1bf73f40ae18fcad7 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["MFG_T2_TADetailsID"].Value + @"','" + ISpace["MFG_T2_TravelAdvanceID"].Value + @"','" + ISpace["MFG_T2_Departure"].Value + @"','" + ISpace["MFG_T2_DepartureDate"].Value + @"','" + ISpace["MFG_T2_DepartureTime"].Value + @"','" + ISpace["MFG_T2_Arrival"].Value + @"','" + ISpace["MFG_T2_ArrivalDate"].Value + @"','" + ISpace["MFG_T2_ArrivalTime"].Value + @"','" + ISpace["MFG_T2_ModeofJourney"].Value + @"','" + ISpace["MFG_T2_JourneyClass"].Value + @"'," + ISpace["MFG_T2_Road"].Value + @",'" + ISpace["MFG_T2_PNRNo"].Value + @"'," + ISpace["MFG_T2_Amount"].Value + @",'" + ISpace["growid"].Value + @"'",_objectFactory.GetGridRPP("TravelExpense"));

base.WriteDebugInfo(@"var querySourceAFBC2448576140CFA8EB1C60C3DC33D1 =GetQueryExpressionDataSource(""AFBC2448-5761-40CF-A8EB-1C60C3DC33D1"");DataTable resultAFBC2448576140CFA8EB1C60C3DC33D1=iSpace.SetGridDataSource(querySourceAFBC2448576140CFA8EB1C60C3DC33D1, _objectFactory.GetGridRPP(""TravelExpense""),@""EXEC UpdateFormGridData374fb8a88dd94cf1bf73f40ae18fcad7 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""MFG_T2_TADetailsID""].Value + @""','"" + ISpace[""MFG_T2_TravelAdvanceID""].Value + @""','"" + ISpace[""MFG_T2_Departure""].Value + @""','"" + ISpace[""MFG_T2_DepartureDate""].Value + @""','"" + ISpace[""MFG_T2_DepartureTime""].Value + @""','"" + ISpace[""MFG_T2_Arrival""].Value + @""','"" + ISpace[""MFG_T2_ArrivalDate""].Value + @""','"" + ISpace[""MFG_T2_ArrivalTime""].Value + @""','"" + ISpace[""MFG_T2_ModeofJourney""].Value + @""','"" + ISpace[""MFG_T2_JourneyClass""].Value + @""',"" + ISpace[""MFG_T2_Road""].Value + @"",'"" + ISpace[""MFG_T2_PNRNo""].Value + @""',"" + ISpace[""MFG_T2_Amount""].Value + @"",'"" + ISpace[""growid""].Value + @""'"");iSpace.InsertGridBindDetails(""TravelExpense"",""11"",querySourceAFBC2448576140CFA8EB1C60C3DC33D1,""EXEC UpdateFormGridData374fb8a88dd94cf1bf73f40ae18fcad7 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""MFG_T2_TADetailsID""].Value + @""','"" + ISpace[""MFG_T2_TravelAdvanceID""].Value + @""','"" + ISpace[""MFG_T2_Departure""].Value + @""','"" + ISpace[""MFG_T2_DepartureDate""].Value + @""','"" + ISpace[""MFG_T2_DepartureTime""].Value + @""','"" + ISpace[""MFG_T2_Arrival""].Value + @""','"" + ISpace[""MFG_T2_ArrivalDate""].Value + @""','"" + ISpace[""MFG_T2_ArrivalTime""].Value + @""','"" + ISpace[""MFG_T2_ModeofJourney""].Value + @""','"" + ISpace[""MFG_T2_JourneyClass""].Value + @""',"" + ISpace[""MFG_T2_Road""].Value + @"",'"" + ISpace[""MFG_T2_PNRNo""].Value + @""',"" + ISpace[""MFG_T2_Amount""].Value + @"",'"" + ISpace[""growid""].Value + @""'"",_objectFactory.GetGridRPP(""TravelExpense""));");
base.WriteDebugInfo(@"EXEC UpdateFormGridData374fb8a88dd94cf1bf73f40ae18fcad7 '@@gv_InstanceId','@@gv_ProcessMapId','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','@@gv_ActivityMapId','#MFG_T2_TADetailsID','#MFG_T2_TravelAdvanceID','#MFG_T2_Departure','#MFG_T2_DepartureDate','#MFG_T2_DepartureTime','#MFG_T2_Arrival','#MFG_T2_ArrivalDate','#MFG_T2_ArrivalTime','#MFG_T2_ModeofJourney','#MFG_T2_JourneyClass',#MFG_T2_Road,'#MFG_T2_PNRNo',#MFG_T3_Amount,'#growid'");


List<Triplet<string, short, short?>> result49C758C3CB9E452A80535E2651156E3D=acdataIspace5E4661C9726C4AD7A4577C4A84E9192D.GetQueryExpressionBindings("49C758C3-CB9E-452A-8053-5E2651156E3D");
iSpace.SetGridData(resultAFBC2448576140CFA8EB1C60C3DC33D1,result49C758C3CB9E452A80535E2651156E3D,"TravelExpense",ref ISpace);
iSpace.UpdateGridBindDetails("TravelExpense",result49C758C3CB9E452A80535E2651156E3D);
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
object MG_T2_Amount=iSpace.Sum("[FA412DDD-7AD9-49AF-B8D7-2B7E1620D8FC]","MG_T2_Amount","",ISpace["gv_instanceid"].Value);
ISpace["T_TravelAdvanceTotal"].Value=Convert.ChangeType(MG_T2_Amount, MG_T2_Amount.GetType());;
base.WriteDebugInfo(@"object MG_T2_Amount=iSpace.Sum(""[FA412DDD-7AD9-49AF-B8D7-2B7E1620D8FC]"",""MG_T2_Amount"","""",ISpace[""gv_instanceid""].Value);
ISpace[""T_TravelAdvanceTotal""].Value=Convert.ChangeType(MG_T2_Amount, MG_T2_Amount.GetType());;");
ISpace["OverAll_Total"].Value=ISpace["T_TravelAdvanceTotal"].Value+ISpace["T_ExpenditureTotal"].Value;
base.WriteDebugInfo(@"ISpace[""OverAll_Total""].Value=ISpace[""T_TravelAdvanceTotal""].Value+ISpace[""T_ExpenditureTotal""].Value;");

if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"SELECT #OverAll_Total*0.9");

var querySource797A60C10BB64A40915695B92AAFC889 =GetQueryExpressionDataSource("797A60C1-0BB6-4A40-9156-95B92AAFC889");
Dictionary<short,object> result797A60C10BB64A40915695B92AAFC889=iSpace.ExecuteQuery(querySource797A60C10BB64A40915695B92AAFC889,@"SELECT " + ISpace["OverAll_Total"].Value + @"*0.9",false);

base.WriteDebugInfo(@"var querySource797A60C10BB64A40915695B92AAFC889 =GetQueryExpressionDataSource(""797A60C1-0BB6-4A40-9156-95B92AAFC889"");Dictionary<short,object> result797A60C10BB64A40915695B92AAFC889=iSpace.ExecuteQuery(querySource797A60C10BB64A40915695B92AAFC889,@""SELECT "" + ISpace[""OverAll_Total""].Value + @""*0.9"",false);");
base.WriteDebugInfo(@"");

if((result797A60C10BB64A40915695B92AAFC889!=null) && (result797A60C10BB64A40915695B92AAFC889.Count!=0))
{
if(result797A60C10BB64A40915695B92AAFC889.ContainsKey(0))
ISpace["T_AdvanceDrawn"].Value = result797A60C10BB64A40915695B92AAFC889[0];
}
else{
ISpace["T_AdvanceDrawn"].Value = null;
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
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_FundType"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""MF_FundType""].Value=="""")");
ISpace["Message"].Value=@"Please enter Fund Type";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please enter Fund Type"";");
return;
base.WriteDebugInfo(@"return;");
}
if(ISpace["MF_FundType"].Value=="1")
{
base.WriteDebugInfo(@"if(ISpace[""MF_FundType""].Value==""1"")");
if(ISpace["MF_ProjectNo"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""MF_ProjectNo""].Value=="""")");
ISpace["Message"].Value=@"Please enter Project No";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please enter Project No"";");
return;
base.WriteDebugInfo(@"return;");
}
if(ISpace["MF_BudgetHead"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""MF_BudgetHead""].Value=="""")");
ISpace["Message"].Value=@"Please enter Budget Head";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please enter Budget Head"";");
return;
base.WriteDebugInfo(@"return;");
}
if(ISpace["MF_Amount"].Value==0)
{
base.WriteDebugInfo(@"if(ISpace[""MF_Amount""].Value==0)");
ISpace["Message"].Value=@"Please enter Amount";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please enter Amount"";");
return;
base.WriteDebugInfo(@"return;");
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
return;
base.WriteDebugInfo(@"return;");
}
}
if(ISpace["MF_FundType"].Value=="1")
{
base.WriteDebugInfo(@"if(ISpace[""MF_FundType""].Value==""1"")");
base.WriteDebugInfo(@"exec ValidatePaymentFundAvailability '#MF_FundType','#MF_ProjectNo','#MF_BudgetHead','#UC_EmployeeBaicInfoId','#MF_Amount'");

var querySource030B3094527B4F84B2E392458D34E946 =GetQueryExpressionDataSource("030B3094-527B-4F84-B2E3-92458D34E946");
Dictionary<short,object> result030B3094527B4F84B2E392458D34E946=iSpace.ExecuteQuery(querySource030B3094527B4F84B2E392458D34E946,@"exec ValidatePaymentFundAvailability '" + ISpace["MF_FundType"].Value + @"','" + ISpace["MF_ProjectNo"].Value + @"','" + ISpace["MF_BudgetHead"].Value + @"','" + ISpace["UC_EmployeeBaicInfoId"].Value + @"','" + ISpace["MF_Amount"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource030B3094527B4F84B2E392458D34E946 =GetQueryExpressionDataSource(""030B3094-527B-4F84-B2E3-92458D34E946"");Dictionary<short,object> result030B3094527B4F84B2E392458D34E946=iSpace.ExecuteQuery(querySource030B3094527B4F84B2E392458D34E946,@""exec ValidatePaymentFundAvailability '"" + ISpace[""MF_FundType""].Value + @""','"" + ISpace[""MF_ProjectNo""].Value + @""','"" + ISpace[""MF_BudgetHead""].Value + @""','"" + ISpace[""UC_EmployeeBaicInfoId""].Value + @""','"" + ISpace[""MF_Amount""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result030B3094527B4F84B2E392458D34E946!=null) && (result030B3094527B4F84B2E392458D34E946.Count!=0))
{
if(result030B3094527B4F84B2E392458D34E946.ContainsKey(0))
ISpace["M_BudgetErr"].Value = result030B3094527B4F84B2E392458D34E946[0];
if(result030B3094527B4F84B2E392458D34E946.ContainsKey(1))
ISpace["M_BudgetErrMsg"].Value = result030B3094527B4F84B2E392458D34E946[1];
}
else{
ISpace["M_BudgetErr"].Value = null;ISpace["M_BudgetErrMsg"].Value = null;
}
if(ISpace["M_BudgetErr"].Value==0)
{
base.WriteDebugInfo(@"if(ISpace[""M_BudgetErr""].Value==0)");
ISpace["Message"].Value=String.Format(@"{0}",ISpace["M_BudgetErrMsg"].Value);
base.WriteDebugInfo(@"ISpace[""Message""].Value=String.Format(@""{0}"",ISpace[""M_BudgetErrMsg""].Value);");
return;
base.WriteDebugInfo(@"return;");
}
}
if(ISpace["MF_FundDetailsId"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""MF_FundDetailsId""].Value=="""")");
ISpace["MF_FundDetailsId"].Value=Guid.NewGuid().ToString();
base.WriteDebugInfo(@"ISpace[""MF_FundDetailsId""].Value=Guid.NewGuid().ToString();");
}
}
ISpace["Message"].Value=@"Saved Successfully";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Saved Successfully"";");

var querySource0C732937A40A4ABBBB7DD89BDA0D481E =GetQueryExpressionDataSource("0C732937-A40A-4ABB-BB7D-D89BDA0D481E");

DataTable result0C732937A40A4ABBBB7DD89BDA0D481E=iSpace.SetGridDataSource(querySource0C732937A40A4ABBBB7DD89BDA0D481E, _objectFactory.GetGridRPP("MF_FundAmount"),@"exec SP_GetTravelAdvanceFundDetails 1,'" + ISpace["MF_T1_TravelAdvanceID"].Value + @"','','" + ISpace["M_TravelInstanceId"].Value + @"'");

iSpace.InsertGridBindDetails("MF_FundAmount","11",querySource0C732937A40A4ABBBB7DD89BDA0D481E,"exec SP_GetTravelAdvanceFundDetails 1,'" + ISpace["MF_T1_TravelAdvanceID"].Value + @"','','" + ISpace["M_TravelInstanceId"].Value + @"'",_objectFactory.GetGridRPP("MF_FundAmount"));

base.WriteDebugInfo(@"var querySource0C732937A40A4ABBBB7DD89BDA0D481E =GetQueryExpressionDataSource(""0C732937-A40A-4ABB-BB7D-D89BDA0D481E"");DataTable result0C732937A40A4ABBBB7DD89BDA0D481E=iSpace.SetGridDataSource(querySource0C732937A40A4ABBBB7DD89BDA0D481E, _objectFactory.GetGridRPP(""MF_FundAmount""),@""exec SP_GetTravelAdvanceFundDetails 1,'"" + ISpace[""MF_T1_TravelAdvanceID""].Value + @""','','"" + ISpace[""M_TravelInstanceId""].Value + @""'"");iSpace.InsertGridBindDetails(""MF_FundAmount"",""11"",querySource0C732937A40A4ABBBB7DD89BDA0D481E,""exec SP_GetTravelAdvanceFundDetails 1,'"" + ISpace[""MF_T1_TravelAdvanceID""].Value + @""','','"" + ISpace[""M_TravelInstanceId""].Value + @""'"",_objectFactory.GetGridRPP(""MF_FundAmount""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result1678D80AE83E4BA4B40F952B0A39779B=acdataIspace5E4661C9726C4AD7A4577C4A84E9192D.GetQueryExpressionBindings("1678D80A-E83E-4BA4-B40F-952B0A39779B");
iSpace.SetGridData(result0C732937A40A4ABBBB7DD89BDA0D481E,result1678D80AE83E4BA4B40F952B0A39779B,"MF_FundAmount",ref ISpace);
iSpace.UpdateGridBindDetails("MF_FundAmount",result1678D80AE83E4BA4B40F952B0A39779B);
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["MF_FundType"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_FundType""].Value=null;");
ISpace["MF_ProjectNo"].Value=null;
base.WriteDebugInfo(@"ISpace[""MF_ProjectNo""].Value=null;");
ISpace["M_BudgetErr"].Value=null;
base.WriteDebugInfo(@"ISpace[""M_BudgetErr""].Value=null;");
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
private void SubscribeElementEvents_edit_travelexpense (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Edit_TravelExpense-OnClick");
ISpace["growid"].Value=ISpace["TravelExpense_RowId"].Value;
base.WriteDebugInfo(@"ISpace[""growid""].Value=ISpace[""TravelExpense_RowId""].Value;");
base.WriteDebugInfo(@"EXEC LoadFormGridData374fb8a88dd94cf1bf73f40ae18fcad7 '@@gv_InstanceId','@@gv_ProcessMapId','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','@@gv_ActivityMapId','#growid'");

var querySource2ACCBC572E9C4A0FBD46FAB4E50951D4 =GetQueryExpressionDataSource("2ACCBC57-2E9C-4A0F-BD46-FAB4E50951D4");
Dictionary<short,object> result2ACCBC572E9C4A0FBD46FAB4E50951D4=iSpace.ExecuteQuery(querySource2ACCBC572E9C4A0FBD46FAB4E50951D4,@"EXEC LoadFormGridData374fb8a88dd94cf1bf73f40ae18fcad7 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["growid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource2ACCBC572E9C4A0FBD46FAB4E50951D4 =GetQueryExpressionDataSource(""2ACCBC57-2E9C-4A0F-BD46-FAB4E50951D4"");Dictionary<short,object> result2ACCBC572E9C4A0FBD46FAB4E50951D4=iSpace.ExecuteQuery(querySource2ACCBC572E9C4A0FBD46FAB4E50951D4,@""EXEC LoadFormGridData374fb8a88dd94cf1bf73f40ae18fcad7 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""growid""].Value + @""'"",false);");
base.WriteDebugInfo(@"EXEC LoadFormGridData374fb8a88dd94cf1bf73f40ae18fcad7 '@@gv_InstanceId','@@gv_ProcessMapId','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','@@gv_ActivityMapId','#growid'");

if((result2ACCBC572E9C4A0FBD46FAB4E50951D4!=null) && (result2ACCBC572E9C4A0FBD46FAB4E50951D4.Count!=0))
{
if(result2ACCBC572E9C4A0FBD46FAB4E50951D4.ContainsKey(3))
ISpace["MFG_T2_DepartureDate"].Value = result2ACCBC572E9C4A0FBD46FAB4E50951D4[3];
if(result2ACCBC572E9C4A0FBD46FAB4E50951D4.ContainsKey(6))
ISpace["MFG_T2_ArrivalDate"].Value = result2ACCBC572E9C4A0FBD46FAB4E50951D4[6];
if(result2ACCBC572E9C4A0FBD46FAB4E50951D4.ContainsKey(8))
ISpace["MFG_T2_ModeofJourney"].Value = result2ACCBC572E9C4A0FBD46FAB4E50951D4[8];
if(result2ACCBC572E9C4A0FBD46FAB4E50951D4.ContainsKey(9))
ISpace["MFG_T2_JourneyClass"].Value = result2ACCBC572E9C4A0FBD46FAB4E50951D4[9];
if(result2ACCBC572E9C4A0FBD46FAB4E50951D4.ContainsKey(12))
ISpace["MFG_T2_Amount"].Value = result2ACCBC572E9C4A0FBD46FAB4E50951D4[12];
if(result2ACCBC572E9C4A0FBD46FAB4E50951D4.ContainsKey(10))
ISpace["MFG_T2_Road"].Value = result2ACCBC572E9C4A0FBD46FAB4E50951D4[10];
if(result2ACCBC572E9C4A0FBD46FAB4E50951D4.ContainsKey(11))
ISpace["MFG_T2_PNRNo"].Value = result2ACCBC572E9C4A0FBD46FAB4E50951D4[11];
if(result2ACCBC572E9C4A0FBD46FAB4E50951D4.ContainsKey(4))
ISpace["MFG_T2_DepartureTime"].Value = result2ACCBC572E9C4A0FBD46FAB4E50951D4[4];
if(result2ACCBC572E9C4A0FBD46FAB4E50951D4.ContainsKey(0))
ISpace["MFG_T2_TADetailsID"].Value = result2ACCBC572E9C4A0FBD46FAB4E50951D4[0];
if(result2ACCBC572E9C4A0FBD46FAB4E50951D4.ContainsKey(7))
ISpace["MFG_T2_ArrivalTime"].Value = result2ACCBC572E9C4A0FBD46FAB4E50951D4[7];
if(result2ACCBC572E9C4A0FBD46FAB4E50951D4.ContainsKey(5))
ISpace["MFG_T2_Arrival"].Value = result2ACCBC572E9C4A0FBD46FAB4E50951D4[5];
if(result2ACCBC572E9C4A0FBD46FAB4E50951D4.ContainsKey(2))
ISpace["MFG_T2_Departure"].Value = result2ACCBC572E9C4A0FBD46FAB4E50951D4[2];
if(result2ACCBC572E9C4A0FBD46FAB4E50951D4.ContainsKey(1))
ISpace["MFG_T2_TravelAdvanceID"].Value = result2ACCBC572E9C4A0FBD46FAB4E50951D4[1];
}
else{
ISpace["MFG_T2_DepartureDate"].Value = null;ISpace["MFG_T2_ArrivalDate"].Value = null;ISpace["MFG_T2_ModeofJourney"].Value = null;ISpace["MFG_T2_JourneyClass"].Value = null;ISpace["MFG_T2_Amount"].Value = null;ISpace["MFG_T2_Road"].Value = null;ISpace["MFG_T2_PNRNo"].Value = null;ISpace["MFG_T2_DepartureTime"].Value = null;ISpace["MFG_T2_TADetailsID"].Value = null;ISpace["MFG_T2_ArrivalTime"].Value = null;ISpace["MFG_T2_Arrival"].Value = null;ISpace["MFG_T2_Departure"].Value = null;ISpace["MFG_T2_TravelAdvanceID"].Value = null;
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

var querySource797A60C10BB64A40915695B92AAFC889 =GetQueryExpressionDataSource("797A60C1-0BB6-4A40-9156-95B92AAFC889");
Dictionary<short,object> result797A60C10BB64A40915695B92AAFC889=iSpace.ExecuteQuery(querySource797A60C10BB64A40915695B92AAFC889,@"SELECT " + ISpace["OverAll_Total"].Value + @"*0.9",false);

base.WriteDebugInfo(@"var querySource797A60C10BB64A40915695B92AAFC889 =GetQueryExpressionDataSource(""797A60C1-0BB6-4A40-9156-95B92AAFC889"");Dictionary<short,object> result797A60C10BB64A40915695B92AAFC889=iSpace.ExecuteQuery(querySource797A60C10BB64A40915695B92AAFC889,@""SELECT "" + ISpace[""OverAll_Total""].Value + @""*0.9"",false);");
base.WriteDebugInfo(@"");

if((result797A60C10BB64A40915695B92AAFC889!=null) && (result797A60C10BB64A40915695B92AAFC889.Count!=0))
{
if(result797A60C10BB64A40915695B92AAFC889.ContainsKey(0))
ISpace["T_AdvanceDrawn"].Value = result797A60C10BB64A40915695B92AAFC889[0];
}
else{
ISpace["T_AdvanceDrawn"].Value = null;
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
return;
base.WriteDebugInfo(@"return;");
}
if((ISpace["MFG_T2_FromDate"].Value == null))
{
base.WriteDebugInfo(@"if((ISpace[""MFG_T2_FromDate""].Value == null))");
ISpace["Message"].Value=@"Please Enter the From Date";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please Enter the From Date"";");
return;
base.WriteDebugInfo(@"return;");
}
if((ISpace["MFG_T2_ToDate"].Value == null))
{
base.WriteDebugInfo(@"if((ISpace[""MFG_T2_ToDate""].Value == null))");
ISpace["Message"].Value=@"Please Enter the To Date";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please Enter the To Date"";");
return;
base.WriteDebugInfo(@"return;");
}
if(ISpace["MFG_T2_ToDate"].Value< ISpace["MFG_T2_FromDate"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""MFG_T2_ToDate""].Value< ISpace[""MFG_T2_FromDate""].Value)");
ISpace["Message"].Value=@"To Date should be greater than From Date";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""To Date should be greater than From Date"";");
ISpace["MFG_T2_ToDate"].Value=null;
base.WriteDebugInfo(@"ISpace[""MFG_T2_ToDate""].Value=null;");
return;
base.WriteDebugInfo(@"return;");
}
if(ISpace["MFG_T3_Amount"].Value==0)
{
base.WriteDebugInfo(@"if(ISpace[""MFG_T3_Amount""].Value==0)");
ISpace["Message"].Value=@"Please Enter the Amount";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please Enter the Amount"";");
return;
base.WriteDebugInfo(@"return;");
}
}
if(ISpace["growid"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""growid""].Value=="""")");

var querySource35103DBC9C7944E2A5BC8BA3E5A2960A =GetQueryExpressionDataSource("35103DBC-9C79-44E2-A5BC-8BA3E5A2960A");

DataTable result35103DBC9C7944E2A5BC8BA3E5A2960A=iSpace.SetGridDataSource(querySource35103DBC9C7944E2A5BC8BA3E5A2960A, _objectFactory.GetGridRPP("OtherExpense"),@"EXEC AddFormGridData51838b372ec64d358a5e38648bc93ab1 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','51838b37-2ec6-4d35-8a5e-38648bc93ab1','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["MFG_T2_ExpenditureTypeID"].Value + @"','" + ISpace["MFG_T3_TravelAdvanceID"].Value + @"','" + ISpace["MFG_T2_FromDate"].Value + @"','" + ISpace["MFG_T2_ToDate"].Value + @"'," + ISpace["MFG_T3_Amount"].Value + @",'" + ISpace["growid"].Value + @"'");

iSpace.InsertGridBindDetails("OtherExpense","11",querySource35103DBC9C7944E2A5BC8BA3E5A2960A,"EXEC AddFormGridData51838b372ec64d358a5e38648bc93ab1 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','51838b37-2ec6-4d35-8a5e-38648bc93ab1','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["MFG_T2_ExpenditureTypeID"].Value + @"','" + ISpace["MFG_T3_TravelAdvanceID"].Value + @"','" + ISpace["MFG_T2_FromDate"].Value + @"','" + ISpace["MFG_T2_ToDate"].Value + @"'," + ISpace["MFG_T3_Amount"].Value + @",'" + ISpace["growid"].Value + @"'",_objectFactory.GetGridRPP("OtherExpense"));

base.WriteDebugInfo(@"var querySource35103DBC9C7944E2A5BC8BA3E5A2960A =GetQueryExpressionDataSource(""35103DBC-9C79-44E2-A5BC-8BA3E5A2960A"");DataTable result35103DBC9C7944E2A5BC8BA3E5A2960A=iSpace.SetGridDataSource(querySource35103DBC9C7944E2A5BC8BA3E5A2960A, _objectFactory.GetGridRPP(""OtherExpense""),@""EXEC AddFormGridData51838b372ec64d358a5e38648bc93ab1 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','51838b37-2ec6-4d35-8a5e-38648bc93ab1','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""MFG_T2_ExpenditureTypeID""].Value + @""','"" + ISpace[""MFG_T3_TravelAdvanceID""].Value + @""','"" + ISpace[""MFG_T2_FromDate""].Value + @""','"" + ISpace[""MFG_T2_ToDate""].Value + @""',"" + ISpace[""MFG_T3_Amount""].Value + @"",'"" + ISpace[""growid""].Value + @""'"");iSpace.InsertGridBindDetails(""OtherExpense"",""11"",querySource35103DBC9C7944E2A5BC8BA3E5A2960A,""EXEC AddFormGridData51838b372ec64d358a5e38648bc93ab1 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','51838b37-2ec6-4d35-8a5e-38648bc93ab1','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""MFG_T2_ExpenditureTypeID""].Value + @""','"" + ISpace[""MFG_T3_TravelAdvanceID""].Value + @""','"" + ISpace[""MFG_T2_FromDate""].Value + @""','"" + ISpace[""MFG_T2_ToDate""].Value + @""',"" + ISpace[""MFG_T3_Amount""].Value + @"",'"" + ISpace[""growid""].Value + @""'"",_objectFactory.GetGridRPP(""OtherExpense""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> resultF4BA7E5B4EDA4DCC873156AE15108198=acdataIspace5E4661C9726C4AD7A4577C4A84E9192D.GetQueryExpressionBindings("F4BA7E5B-4EDA-4DCC-8731-56AE15108198");
iSpace.SetGridData(result35103DBC9C7944E2A5BC8BA3E5A2960A,resultF4BA7E5B4EDA4DCC873156AE15108198,"OtherExpense",ref ISpace);
iSpace.UpdateGridBindDetails("OtherExpense",resultF4BA7E5B4EDA4DCC873156AE15108198);
}
else
{
base.WriteDebugInfo(@"else");

var querySource4F7F126417684CE3875C0113E884A910 =GetQueryExpressionDataSource("4F7F1264-1768-4CE3-875C-0113E884A910");

DataTable result4F7F126417684CE3875C0113E884A910=iSpace.SetGridDataSource(querySource4F7F126417684CE3875C0113E884A910, _objectFactory.GetGridRPP("OtherExpense"),@"EXEC UpdateFormGridData51838b372ec64d358a5e38648bc93ab1 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','51838b37-2ec6-4d35-8a5e-38648bc93ab1','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["MFG_T2_ExpenditureTypeID"].Value + @"','" + ISpace["MFG_T3_TravelAdvanceID"].Value + @"','" + ISpace["MFG_T2_FromDate"].Value + @"','" + ISpace["MFG_T2_ToDate"].Value + @"'," + ISpace["MFG_T3_Amount"].Value + @",'" + ISpace["growid"].Value + @"'");

iSpace.InsertGridBindDetails("OtherExpense","11",querySource4F7F126417684CE3875C0113E884A910,"EXEC UpdateFormGridData51838b372ec64d358a5e38648bc93ab1 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','51838b37-2ec6-4d35-8a5e-38648bc93ab1','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["MFG_T2_ExpenditureTypeID"].Value + @"','" + ISpace["MFG_T3_TravelAdvanceID"].Value + @"','" + ISpace["MFG_T2_FromDate"].Value + @"','" + ISpace["MFG_T2_ToDate"].Value + @"'," + ISpace["MFG_T3_Amount"].Value + @",'" + ISpace["growid"].Value + @"'",_objectFactory.GetGridRPP("OtherExpense"));

base.WriteDebugInfo(@"var querySource4F7F126417684CE3875C0113E884A910 =GetQueryExpressionDataSource(""4F7F1264-1768-4CE3-875C-0113E884A910"");DataTable result4F7F126417684CE3875C0113E884A910=iSpace.SetGridDataSource(querySource4F7F126417684CE3875C0113E884A910, _objectFactory.GetGridRPP(""OtherExpense""),@""EXEC UpdateFormGridData51838b372ec64d358a5e38648bc93ab1 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','51838b37-2ec6-4d35-8a5e-38648bc93ab1','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""MFG_T2_ExpenditureTypeID""].Value + @""','"" + ISpace[""MFG_T3_TravelAdvanceID""].Value + @""','"" + ISpace[""MFG_T2_FromDate""].Value + @""','"" + ISpace[""MFG_T2_ToDate""].Value + @""',"" + ISpace[""MFG_T3_Amount""].Value + @"",'"" + ISpace[""growid""].Value + @""'"");iSpace.InsertGridBindDetails(""OtherExpense"",""11"",querySource4F7F126417684CE3875C0113E884A910,""EXEC UpdateFormGridData51838b372ec64d358a5e38648bc93ab1 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','51838b37-2ec6-4d35-8a5e-38648bc93ab1','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""MFG_T2_ExpenditureTypeID""].Value + @""','"" + ISpace[""MFG_T3_TravelAdvanceID""].Value + @""','"" + ISpace[""MFG_T2_FromDate""].Value + @""','"" + ISpace[""MFG_T2_ToDate""].Value + @""',"" + ISpace[""MFG_T3_Amount""].Value + @"",'"" + ISpace[""growid""].Value + @""'"",_objectFactory.GetGridRPP(""OtherExpense""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> resultBDC496F72D4A42209C085EEFBC69334B=acdataIspace5E4661C9726C4AD7A4577C4A84E9192D.GetQueryExpressionBindings("BDC496F7-2D4A-4220-9C08-5EEFBC69334B");
iSpace.SetGridData(result4F7F126417684CE3875C0113E884A910,resultBDC496F72D4A42209C085EEFBC69334B,"OtherExpense",ref ISpace);
iSpace.UpdateGridBindDetails("OtherExpense",resultBDC496F72D4A42209C085EEFBC69334B);
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
object MG_T3_Amount=iSpace.Sum("[A694A330-AAD5-4856-853C-D6AD1573AF0B]","MG_T3_Amount","",ISpace["gv_instanceid"].Value);
ISpace["T_ExpenditureTotal"].Value=Convert.ChangeType(MG_T3_Amount, MG_T3_Amount.GetType());;
base.WriteDebugInfo(@"object MG_T3_Amount=iSpace.Sum(""[A694A330-AAD5-4856-853C-D6AD1573AF0B]"",""MG_T3_Amount"","""",ISpace[""gv_instanceid""].Value);
ISpace[""T_ExpenditureTotal""].Value=Convert.ChangeType(MG_T3_Amount, MG_T3_Amount.GetType());;");
ISpace["OverAll_Total"].Value=ISpace["T_TravelAdvanceTotal"].Value+ISpace["T_ExpenditureTotal"].Value;
base.WriteDebugInfo(@"ISpace[""OverAll_Total""].Value=ISpace[""T_TravelAdvanceTotal""].Value+ISpace[""T_ExpenditureTotal""].Value;");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"SELECT #OverAll_Total*0.9");

var querySource797A60C10BB64A40915695B92AAFC889 =GetQueryExpressionDataSource("797A60C1-0BB6-4A40-9156-95B92AAFC889");
Dictionary<short,object> result797A60C10BB64A40915695B92AAFC889=iSpace.ExecuteQuery(querySource797A60C10BB64A40915695B92AAFC889,@"SELECT " + ISpace["OverAll_Total"].Value + @"*0.9",false);

base.WriteDebugInfo(@"var querySource797A60C10BB64A40915695B92AAFC889 =GetQueryExpressionDataSource(""797A60C1-0BB6-4A40-9156-95B92AAFC889"");Dictionary<short,object> result797A60C10BB64A40915695B92AAFC889=iSpace.ExecuteQuery(querySource797A60C10BB64A40915695B92AAFC889,@""SELECT "" + ISpace[""OverAll_Total""].Value + @""*0.9"",false);");
base.WriteDebugInfo(@"");

if((result797A60C10BB64A40915695B92AAFC889!=null) && (result797A60C10BB64A40915695B92AAFC889.Count!=0))
{
if(result797A60C10BB64A40915695B92AAFC889.ContainsKey(0))
ISpace["T_AdvanceDrawn"].Value = result797A60C10BB64A40915695B92AAFC889[0];
}
else{
ISpace["T_AdvanceDrawn"].Value = null;
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
ISpace["M_MoveToValue"].Value=ISpace["M_MoveTo"].Value;
base.WriteDebugInfo(@"ISpace[""M_MoveToValue""].Value=ISpace[""M_MoveTo""].Value;");
base.WriteDebugInfo(@"Exec GetStageStatus 1,'','','#M_MoveToValue','#M_SourceActivityMapId'");

var querySource4DA95BD5CD3F4A6D8AE54C8A839E94D6 =GetQueryExpressionDataSource("4DA95BD5-CD3F-4A6D-8AE5-4C8A839E94D6");
Dictionary<short,object> result4DA95BD5CD3F4A6D8AE54C8A839E94D6=iSpace.ExecuteQuery(querySource4DA95BD5CD3F4A6D8AE54C8A839E94D6,@"Exec GetStageStatus 1,'','','" + ISpace["M_MoveToValue"].Value + @"','" + ISpace["M_SourceActivityMapId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource4DA95BD5CD3F4A6D8AE54C8A839E94D6 =GetQueryExpressionDataSource(""4DA95BD5-CD3F-4A6D-8AE5-4C8A839E94D6"");Dictionary<short,object> result4DA95BD5CD3F4A6D8AE54C8A839E94D6=iSpace.ExecuteQuery(querySource4DA95BD5CD3F4A6D8AE54C8A839E94D6,@""Exec GetStageStatus 1,'','','"" + ISpace[""M_MoveToValue""].Value + @""','"" + ISpace[""M_SourceActivityMapId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result4DA95BD5CD3F4A6D8AE54C8A839E94D6!=null) && (result4DA95BD5CD3F4A6D8AE54C8A839E94D6.Count!=0))
{
if(result4DA95BD5CD3F4A6D8AE54C8A839E94D6.ContainsKey(5))
ISpace["M_IsFlowReturned"].Value = result4DA95BD5CD3F4A6D8AE54C8A839E94D6[5];
if(result4DA95BD5CD3F4A6D8AE54C8A839E94D6.ContainsKey(6))
ISpace["M_IsCancelReject"].Value = result4DA95BD5CD3F4A6D8AE54C8A839E94D6[6];
if(result4DA95BD5CD3F4A6D8AE54C8A839E94D6.ContainsKey(4))
ISpace["M_FieldMandatory"].Value = result4DA95BD5CD3F4A6D8AE54C8A839E94D6[4];
if(result4DA95BD5CD3F4A6D8AE54C8A839E94D6.ContainsKey(1))
ISpace["M_RemarksMandatory"].Value = result4DA95BD5CD3F4A6D8AE54C8A839E94D6[1];
if(result4DA95BD5CD3F4A6D8AE54C8A839E94D6.ContainsKey(3))
ISpace["M_SaveDomainData"].Value = result4DA95BD5CD3F4A6D8AE54C8A839E94D6[3];
if(result4DA95BD5CD3F4A6D8AE54C8A839E94D6.ContainsKey(2))
ISpace["M_Remarks"].Value = result4DA95BD5CD3F4A6D8AE54C8A839E94D6[2];
if(result4DA95BD5CD3F4A6D8AE54C8A839E94D6.ContainsKey(0))
ISpace["M_NextStage"].Value = result4DA95BD5CD3F4A6D8AE54C8A839E94D6[0];
}
else{
ISpace["M_IsFlowReturned"].Value = null;ISpace["M_IsCancelReject"].Value = null;ISpace["M_FieldMandatory"].Value = null;ISpace["M_RemarksMandatory"].Value = null;ISpace["M_SaveDomainData"].Value = null;ISpace["M_Remarks"].Value = null;ISpace["M_NextStage"].Value = null;
}
ISpace["SetDestinationTo"].Value=ISpace["M_MoveTo"].Value;
base.WriteDebugInfo(@"ISpace[""SetDestinationTo""].Value=ISpace[""M_MoveTo""].Value;");
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
base.WriteDebugInfo(@"exec SP_GetTravelAdvanceFundDetails 2,'','#MG_FundDetailsID'");

var querySource5FF745B4E8FE40A798DD1695E33EAF99 =GetQueryExpressionDataSource("5FF745B4-E8FE-40A7-98DD-1695E33EAF99");
Dictionary<short,object> result5FF745B4E8FE40A798DD1695E33EAF99=iSpace.ExecuteQuery(querySource5FF745B4E8FE40A798DD1695E33EAF99,@"exec SP_GetTravelAdvanceFundDetails 2,'','" + ISpace["MG_FundDetailsID"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource5FF745B4E8FE40A798DD1695E33EAF99 =GetQueryExpressionDataSource(""5FF745B4-E8FE-40A7-98DD-1695E33EAF99"");Dictionary<short,object> result5FF745B4E8FE40A798DD1695E33EAF99=iSpace.ExecuteQuery(querySource5FF745B4E8FE40A798DD1695E33EAF99,@""exec SP_GetTravelAdvanceFundDetails 2,'','"" + ISpace[""MG_FundDetailsID""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result5FF745B4E8FE40A798DD1695E33EAF99!=null) && (result5FF745B4E8FE40A798DD1695E33EAF99.Count!=0))
{
if(result5FF745B4E8FE40A798DD1695E33EAF99.ContainsKey(3))
ISpace["MF_ProjectNo"].Value = result5FF745B4E8FE40A798DD1695E33EAF99[3];
if(result5FF745B4E8FE40A798DD1695E33EAF99.ContainsKey(2))
ISpace["MF_FundType"].Value = result5FF745B4E8FE40A798DD1695E33EAF99[2];
if(result5FF745B4E8FE40A798DD1695E33EAF99.ContainsKey(4))
ISpace["MF_BudgetHead"].Value = result5FF745B4E8FE40A798DD1695E33EAF99[4];
if(result5FF745B4E8FE40A798DD1695E33EAF99.ContainsKey(5))
ISpace["MF_Amount"].Value = result5FF745B4E8FE40A798DD1695E33EAF99[5];
if(result5FF745B4E8FE40A798DD1695E33EAF99.ContainsKey(0))
ISpace["MF_FundDetailsId"].Value = result5FF745B4E8FE40A798DD1695E33EAF99[0];
}
else{
ISpace["MF_ProjectNo"].Value = null;ISpace["MF_FundType"].Value = null;ISpace["MF_BudgetHead"].Value = null;ISpace["MF_Amount"].Value = null;ISpace["MF_FundDetailsId"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MF_FundType"].Value=="1")
{
base.WriteDebugInfo(@"if(ISpace[""MF_FundType""].Value==""1"")");
ISpace["MF_ProjectNo"].Visible="true";ISpace["MF_ProjectNo"].Man=true;ISpace["MF_BudgetHead"].Visible="true";ISpace["MF_BudgetHead"].Man=true;ISpace["MF_Amount"].Visible="true";ISpace["MF_Amount"].Man=true;
base.WriteDebugInfo(@"ISpace[""MF_ProjectNo""].Visible=""true"";ISpace[""MF_ProjectNo""].Man=true;ISpace[""MF_BudgetHead""].Visible=""true"";ISpace[""MF_BudgetHead""].Man=true;ISpace[""MF_Amount""].Visible=""true"";ISpace[""MF_Amount""].Man=true;");
ISpace["M_OpenModal"].Visible="true";
base.WriteDebugInfo(@"ISpace[""M_OpenModal""].Visible=""true"";");
ISpace["MF_BudgetHead"].rElemData=iSpace.Reload(ISpace["MF_BudgetHead"].Value,@"exec SP_GetDistrubitionDetails 5,'@" + ISpace["gv_ProcessMapId"].Value + @"'," + ISpace["MF_FundType"].Value + @",'','','','','" + ISpace["MF_ProjectNo"].Value + @"'","9ADED37B-CD11-426B-AF16-DEAC75685EF5");
base.WriteDebugInfo(@"ISpace[""MF_BudgetHead""].rElemData=iSpace.Reload(ISpace[""MF_BudgetHead""].Value,@""exec SP_GetDistrubitionDetails 5,'@"" + ISpace[""gv_ProcessMapId""].Value + @""',"" + ISpace[""MF_FundType""].Value + @"",'','','','','"" + ISpace[""MF_ProjectNo""].Value + @""'"",""9ADED37B-CD11-426B-AF16-DEAC75685EF5"");");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["MF_ProjectNo"].Visible="false";ISpace["MF_ProjectNo"].Man=false;ISpace["MF_BudgetHead"].Visible="false";ISpace["MF_BudgetHead"].Man=false;ISpace["MF_Amount"].Visible="true";ISpace["MF_Amount"].Man=true;
base.WriteDebugInfo(@"ISpace[""MF_ProjectNo""].Visible=""false"";ISpace[""MF_ProjectNo""].Man=false;ISpace[""MF_BudgetHead""].Visible=""false"";ISpace[""MF_BudgetHead""].Man=false;ISpace[""MF_Amount""].Visible=""true"";ISpace[""MF_Amount""].Man=true;");
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
private void SubscribeElementEvents_m_travelyes (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"M_TravelYes-OnClick");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySourceED8F039D5B074E67A9181A0BCE50C57F =GetQueryExpressionDataSource("ED8F039D-5B07-4E67-A918-1A0BCE50C57F");

DataTable resultED8F039D5B074E67A9181A0BCE50C57F=iSpace.SetGridDataSource(querySourceED8F039D5B074E67A9181A0BCE50C57F, _objectFactory.GetGridRPP("TravelExpense"),@"EXEC DeleteFormGridData374fb8a88dd94cf1bf73f40ae18fcad7 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["growid"].Value + @"'");

iSpace.InsertGridBindDetails("TravelExpense","11",querySourceED8F039D5B074E67A9181A0BCE50C57F,"EXEC DeleteFormGridData374fb8a88dd94cf1bf73f40ae18fcad7 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["growid"].Value + @"'",_objectFactory.GetGridRPP("TravelExpense"));

base.WriteDebugInfo(@"var querySourceED8F039D5B074E67A9181A0BCE50C57F =GetQueryExpressionDataSource(""ED8F039D-5B07-4E67-A918-1A0BCE50C57F"");DataTable resultED8F039D5B074E67A9181A0BCE50C57F=iSpace.SetGridDataSource(querySourceED8F039D5B074E67A9181A0BCE50C57F, _objectFactory.GetGridRPP(""TravelExpense""),@""EXEC DeleteFormGridData374fb8a88dd94cf1bf73f40ae18fcad7 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""growid""].Value + @""'"");iSpace.InsertGridBindDetails(""TravelExpense"",""11"",querySourceED8F039D5B074E67A9181A0BCE50C57F,""EXEC DeleteFormGridData374fb8a88dd94cf1bf73f40ae18fcad7 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','374fb8a8-8dd9-4cf1-bf73-f40ae18fcad7','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""growid""].Value + @""'"",_objectFactory.GetGridRPP(""TravelExpense""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result8D30243FBB2A463A85FF7259BCF2E3B1=acdataIspace5E4661C9726C4AD7A4577C4A84E9192D.GetQueryExpressionBindings("8D30243F-BB2A-463A-85FF-7259BCF2E3B1");
iSpace.SetGridData(resultED8F039D5B074E67A9181A0BCE50C57F,result8D30243FBB2A463A85FF7259BCF2E3B1,"TravelExpense",ref ISpace);
iSpace.UpdateGridBindDetails("TravelExpense",result8D30243FBB2A463A85FF7259BCF2E3B1);
ISpace["Message"].Value=@"Data deleted successfully";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Data deleted successfully"";");
ISpace["UI_DialogTravel"].HideDialog=true;;
base.WriteDebugInfo(@"ISpace[""UI_DialogTravel""].HideDialog=true;;");
object MG_T2_Amount=iSpace.Sum("[FA412DDD-7AD9-49AF-B8D7-2B7E1620D8FC]","MG_T2_Amount","",ISpace["gv_instanceid"].Value);
ISpace["T_TravelAdvanceTotal"].Value=Convert.ChangeType(MG_T2_Amount, MG_T2_Amount.GetType());;
base.WriteDebugInfo(@"object MG_T2_Amount=iSpace.Sum(""[FA412DDD-7AD9-49AF-B8D7-2B7E1620D8FC]"",""MG_T2_Amount"","""",ISpace[""gv_instanceid""].Value);
ISpace[""T_TravelAdvanceTotal""].Value=Convert.ChangeType(MG_T2_Amount, MG_T2_Amount.GetType());;");
ISpace["OverAll_Total"].Value=ISpace["T_TravelAdvanceTotal"].Value+ISpace["T_ExpenditureTotal"].Value;
base.WriteDebugInfo(@"ISpace[""OverAll_Total""].Value=ISpace[""T_TravelAdvanceTotal""].Value+ISpace[""T_ExpenditureTotal""].Value;");
ISpace["growid"].Value="";
base.WriteDebugInfo(@"ISpace[""growid""].Value="""";");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"SELECT #OverAll_Total*0.9");

var querySource797A60C10BB64A40915695B92AAFC889 =GetQueryExpressionDataSource("797A60C1-0BB6-4A40-9156-95B92AAFC889");
Dictionary<short,object> result797A60C10BB64A40915695B92AAFC889=iSpace.ExecuteQuery(querySource797A60C10BB64A40915695B92AAFC889,@"SELECT " + ISpace["OverAll_Total"].Value + @"*0.9",false);

base.WriteDebugInfo(@"var querySource797A60C10BB64A40915695B92AAFC889 =GetQueryExpressionDataSource(""797A60C1-0BB6-4A40-9156-95B92AAFC889"");Dictionary<short,object> result797A60C10BB64A40915695B92AAFC889=iSpace.ExecuteQuery(querySource797A60C10BB64A40915695B92AAFC889,@""SELECT "" + ISpace[""OverAll_Total""].Value + @""*0.9"",false);");
base.WriteDebugInfo(@"");

if((result797A60C10BB64A40915695B92AAFC889!=null) && (result797A60C10BB64A40915695B92AAFC889.Count!=0))
{
if(result797A60C10BB64A40915695B92AAFC889.ContainsKey(0))
ISpace["T_AdvanceDrawn"].Value = result797A60C10BB64A40915695B92AAFC889[0];
}
else{
ISpace["T_AdvanceDrawn"].Value = null;
}
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

var querySourceE51258BF79BE40CFB8C4A28ACDA2DAA4 =GetQueryExpressionDataSource("E51258BF-79BE-40CF-B8C4-A28ACDA2DAA4");

DataTable resultE51258BF79BE40CFB8C4A28ACDA2DAA4=iSpace.SetGridDataSource(querySourceE51258BF79BE40CFB8C4A28ACDA2DAA4, _objectFactory.GetGridRPP("MF_FundAmount"),@"exec SP_GetTravelAdvanceFundDetails 3,'" + ISpace["MF_T1_TravelAdvanceID"].Value + @"','" + ISpace["MF_FundDetailsId"].Value + @"','" + ISpace["M_TravelInstanceId"].Value + @"'");

iSpace.InsertGridBindDetails("MF_FundAmount","11",querySourceE51258BF79BE40CFB8C4A28ACDA2DAA4,"exec SP_GetTravelAdvanceFundDetails 3,'" + ISpace["MF_T1_TravelAdvanceID"].Value + @"','" + ISpace["MF_FundDetailsId"].Value + @"','" + ISpace["M_TravelInstanceId"].Value + @"'",_objectFactory.GetGridRPP("MF_FundAmount"));

base.WriteDebugInfo(@"var querySourceE51258BF79BE40CFB8C4A28ACDA2DAA4 =GetQueryExpressionDataSource(""E51258BF-79BE-40CF-B8C4-A28ACDA2DAA4"");DataTable resultE51258BF79BE40CFB8C4A28ACDA2DAA4=iSpace.SetGridDataSource(querySourceE51258BF79BE40CFB8C4A28ACDA2DAA4, _objectFactory.GetGridRPP(""MF_FundAmount""),@""exec SP_GetTravelAdvanceFundDetails 3,'"" + ISpace[""MF_T1_TravelAdvanceID""].Value + @""','"" + ISpace[""MF_FundDetailsId""].Value + @""','"" + ISpace[""M_TravelInstanceId""].Value + @""'"");iSpace.InsertGridBindDetails(""MF_FundAmount"",""11"",querySourceE51258BF79BE40CFB8C4A28ACDA2DAA4,""exec SP_GetTravelAdvanceFundDetails 3,'"" + ISpace[""MF_T1_TravelAdvanceID""].Value + @""','"" + ISpace[""MF_FundDetailsId""].Value + @""','"" + ISpace[""M_TravelInstanceId""].Value + @""'"",_objectFactory.GetGridRPP(""MF_FundAmount""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result5A20F168471849C2B6E4F11345E33F05=acdataIspace5E4661C9726C4AD7A4577C4A84E9192D.GetQueryExpressionBindings("5A20F168-4718-49C2-B6E4-F11345E33F05");
iSpace.SetGridData(resultE51258BF79BE40CFB8C4A28ACDA2DAA4,result5A20F168471849C2B6E4F11345E33F05,"MF_FundAmount",ref ISpace);
iSpace.UpdateGridBindDetails("MF_FundAmount",result5A20F168471849C2B6E4F11345E33F05);
ISpace["MF_FundDetailsId"].Value="";
base.WriteDebugInfo(@"ISpace[""MF_FundDetailsId""].Value="""";");
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

var querySource797A60C10BB64A40915695B92AAFC889 =GetQueryExpressionDataSource("797A60C1-0BB6-4A40-9156-95B92AAFC889");
Dictionary<short,object> result797A60C10BB64A40915695B92AAFC889=iSpace.ExecuteQuery(querySource797A60C10BB64A40915695B92AAFC889,@"SELECT " + ISpace["OverAll_Total"].Value + @"*0.9",false);

base.WriteDebugInfo(@"var querySource797A60C10BB64A40915695B92AAFC889 =GetQueryExpressionDataSource(""797A60C1-0BB6-4A40-9156-95B92AAFC889"");Dictionary<short,object> result797A60C10BB64A40915695B92AAFC889=iSpace.ExecuteQuery(querySource797A60C10BB64A40915695B92AAFC889,@""SELECT "" + ISpace[""OverAll_Total""].Value + @""*0.9"",false);");
base.WriteDebugInfo(@"");

if((result797A60C10BB64A40915695B92AAFC889!=null) && (result797A60C10BB64A40915695B92AAFC889.Count!=0))
{
if(result797A60C10BB64A40915695B92AAFC889.ContainsKey(0))
ISpace["T_AdvanceDrawn"].Value = result797A60C10BB64A40915695B92AAFC889[0];
}
else{
ISpace["T_AdvanceDrawn"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySourceF83D458B7CDF409F932998D97A3D6B68 =GetQueryExpressionDataSource("F83D458B-7CDF-409F-9329-98D97A3D6B68");

DataTable resultF83D458B7CDF409F932998D97A3D6B68=iSpace.SetGridDataSource(querySourceF83D458B7CDF409F932998D97A3D6B68, _objectFactory.GetGridRPP("OtherExpense"),@"EXEC DeleteFormGridData51838b372ec64d358a5e38648bc93ab1 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','51838b37-2ec6-4d35-8a5e-38648bc93ab1','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["growid"].Value + @"'");

iSpace.InsertGridBindDetails("OtherExpense","11",querySourceF83D458B7CDF409F932998D97A3D6B68,"EXEC DeleteFormGridData51838b372ec64d358a5e38648bc93ab1 '" + ISpace["gv_instanceid"].Value + @"','" + ISpace["gv_processmapid"].Value + @"','51838b37-2ec6-4d35-8a5e-38648bc93ab1','" + ISpace["gv_activitymapid"].Value + @"','" + ISpace["growid"].Value + @"'",_objectFactory.GetGridRPP("OtherExpense"));

base.WriteDebugInfo(@"var querySourceF83D458B7CDF409F932998D97A3D6B68 =GetQueryExpressionDataSource(""F83D458B-7CDF-409F-9329-98D97A3D6B68"");DataTable resultF83D458B7CDF409F932998D97A3D6B68=iSpace.SetGridDataSource(querySourceF83D458B7CDF409F932998D97A3D6B68, _objectFactory.GetGridRPP(""OtherExpense""),@""EXEC DeleteFormGridData51838b372ec64d358a5e38648bc93ab1 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','51838b37-2ec6-4d35-8a5e-38648bc93ab1','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""growid""].Value + @""'"");iSpace.InsertGridBindDetails(""OtherExpense"",""11"",querySourceF83D458B7CDF409F932998D97A3D6B68,""EXEC DeleteFormGridData51838b372ec64d358a5e38648bc93ab1 '"" + ISpace[""gv_instanceid""].Value + @""','"" + ISpace[""gv_processmapid""].Value + @""','51838b37-2ec6-4d35-8a5e-38648bc93ab1','"" + ISpace[""gv_activitymapid""].Value + @""','"" + ISpace[""growid""].Value + @""'"",_objectFactory.GetGridRPP(""OtherExpense""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> resultF3AFBB51AFF14D34B12216E3E1E5CA86=acdataIspace5E4661C9726C4AD7A4577C4A84E9192D.GetQueryExpressionBindings("F3AFBB51-AFF1-4D34-B122-16E3E1E5CA86");
iSpace.SetGridData(resultF83D458B7CDF409F932998D97A3D6B68,resultF3AFBB51AFF14D34B12216E3E1E5CA86,"OtherExpense",ref ISpace);
iSpace.UpdateGridBindDetails("OtherExpense",resultF3AFBB51AFF14D34B12216E3E1E5CA86);
ISpace["Message"].Value=@"Data deleted successfully";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Data deleted successfully"";");
object MG_T3_Amount=iSpace.Sum("[A694A330-AAD5-4856-853C-D6AD1573AF0B]","MG_T3_Amount","",ISpace["gv_instanceid"].Value);
ISpace["T_ExpenditureTotal"].Value=Convert.ChangeType(MG_T3_Amount, MG_T3_Amount.GetType());;
base.WriteDebugInfo(@"object MG_T3_Amount=iSpace.Sum(""[A694A330-AAD5-4856-853C-D6AD1573AF0B]"",""MG_T3_Amount"","""",ISpace[""gv_instanceid""].Value);
ISpace[""T_ExpenditureTotal""].Value=Convert.ChangeType(MG_T3_Amount, MG_T3_Amount.GetType());;");
ISpace["OverAll_Total"].Value=ISpace["T_TravelAdvanceTotal"].Value+ISpace["T_ExpenditureTotal"].Value;
base.WriteDebugInfo(@"ISpace[""OverAll_Total""].Value=ISpace[""T_TravelAdvanceTotal""].Value+ISpace[""T_ExpenditureTotal""].Value;");
ISpace["growid"].Value="";
base.WriteDebugInfo(@"ISpace[""growid""].Value="""";");
ISpace["UI_DialogOther"].HideDialog=true;;
base.WriteDebugInfo(@"ISpace[""UI_DialogOther""].HideDialog=true;;");
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
private void SubscribeElementEvents_ui_commitmentdetailsmodal (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"UI_CommitmentDetailsModal-OnClick");

var querySource9116BDE3E17548D992EE87A8F58EDC21 =GetQueryExpressionDataSource("9116BDE3-E175-48D9-92EE-87A8F58EDC21");

DataTable result9116BDE3E17548D992EE87A8F58EDC21=iSpace.SetGridDataSource(querySource9116BDE3E17548D992EE87A8F58EDC21, _objectFactory.GetGridRPP("MG_CommitmentDetails"),@"EXEC GetProjectBudgetInformation '" + ISpace["MF_ProjectNo"].Value + @"'");

iSpace.InsertGridBindDetails("MG_CommitmentDetails","11",querySource9116BDE3E17548D992EE87A8F58EDC21,"EXEC GetProjectBudgetInformation '" + ISpace["MF_ProjectNo"].Value + @"'",_objectFactory.GetGridRPP("MG_CommitmentDetails"));

base.WriteDebugInfo(@"var querySource9116BDE3E17548D992EE87A8F58EDC21 =GetQueryExpressionDataSource(""9116BDE3-E175-48D9-92EE-87A8F58EDC21"");DataTable result9116BDE3E17548D992EE87A8F58EDC21=iSpace.SetGridDataSource(querySource9116BDE3E17548D992EE87A8F58EDC21, _objectFactory.GetGridRPP(""MG_CommitmentDetails""),@""EXEC GetProjectBudgetInformation '"" + ISpace[""MF_ProjectNo""].Value + @""'"");iSpace.InsertGridBindDetails(""MG_CommitmentDetails"",""11"",querySource9116BDE3E17548D992EE87A8F58EDC21,""EXEC GetProjectBudgetInformation '"" + ISpace[""MF_ProjectNo""].Value + @""'"",_objectFactory.GetGridRPP(""MG_CommitmentDetails""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> resultCDF3C6581D6D49A190108A78BDE5A1F0=acdataIspace5E4661C9726C4AD7A4577C4A84E9192D.GetQueryExpressionBindings("CDF3C658-1D6D-49A1-9010-8A78BDE5A1F0");
iSpace.SetGridData(result9116BDE3E17548D992EE87A8F58EDC21,resultCDF3C6581D6D49A190108A78BDE5A1F0,"MG_CommitmentDetails",ref ISpace);
iSpace.UpdateGridBindDetails("MG_CommitmentDetails",resultCDF3C6581D6D49A190108A78BDE5A1F0);
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

var querySource41A49BE08FEE4020BEAA0553B628681F =GetQueryExpressionDataSource("41A49BE0-8FEE-4020-BEAA-0553B628681F");
Dictionary<short,object> result41A49BE08FEE4020BEAA0553B628681F=iSpace.ExecuteQuery(querySource41A49BE08FEE4020BEAA0553B628681F,@"EXEC GETReceiptAmountBalace 2,'" + ISpace["C_FC_ProjectNo_33"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource41A49BE08FEE4020BEAA0553B628681F =GetQueryExpressionDataSource(""41A49BE0-8FEE-4020-BEAA-0553B628681F"");Dictionary<short,object> result41A49BE08FEE4020BEAA0553B628681F=iSpace.ExecuteQuery(querySource41A49BE08FEE4020BEAA0553B628681F,@""EXEC GETReceiptAmountBalace 2,'"" + ISpace[""C_FC_ProjectNo_33""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result41A49BE08FEE4020BEAA0553B628681F!=null) && (result41A49BE08FEE4020BEAA0553B628681F.Count!=0))
{
if(result41A49BE08FEE4020BEAA0553B628681F.ContainsKey(3))
ISpace["C_FC_StartDate_33"].Value = result41A49BE08FEE4020BEAA0553B628681F[3];
if(result41A49BE08FEE4020BEAA0553B628681F.ContainsKey(4))
ISpace["C_FC_EndDate_33"].Value = result41A49BE08FEE4020BEAA0553B628681F[4];
if(result41A49BE08FEE4020BEAA0553B628681F.ContainsKey(2))
ISpace["C_FC_SanctionedDate_33"].Value = result41A49BE08FEE4020BEAA0553B628681F[2];
if(result41A49BE08FEE4020BEAA0553B628681F.ContainsKey(7))
ISpace["C_FC_Category_33"].Value = result41A49BE08FEE4020BEAA0553B628681F[7];
if(result41A49BE08FEE4020BEAA0553B628681F.ContainsKey(5))
ISpace["C_FC_SanctionNo_33"].Value = result41A49BE08FEE4020BEAA0553B628681F[5];
if(result41A49BE08FEE4020BEAA0553B628681F.ContainsKey(6))
ISpace["C_FC_AgencyCode_33"].Value = result41A49BE08FEE4020BEAA0553B628681F[6];
if(result41A49BE08FEE4020BEAA0553B628681F.ContainsKey(8))
ISpace["C_FC_SanctionedValue_33"].Value = result41A49BE08FEE4020BEAA0553B628681F[8];
if(result41A49BE08FEE4020BEAA0553B628681F.ContainsKey(1))
ISpace["C_FC_ProjectName_33"].Value = result41A49BE08FEE4020BEAA0553B628681F[1];
}
else{
ISpace["C_FC_StartDate_33"].Value = null;ISpace["C_FC_EndDate_33"].Value = null;ISpace["C_FC_SanctionedDate_33"].Value = null;ISpace["C_FC_Category_33"].Value = null;ISpace["C_FC_SanctionNo_33"].Value = null;ISpace["C_FC_AgencyCode_33"].Value = null;ISpace["C_FC_SanctionedValue_33"].Value = null;ISpace["C_FC_ProjectName_33"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC GETReceiptAmountBalace 3,'#C_FC_ProjectNo_33'");

var querySourceBA60CD900CDC4883991C21CD74ED46AA =GetQueryExpressionDataSource("BA60CD90-0CDC-4883-991C-21CD74ED46AA");
Dictionary<short,object> resultBA60CD900CDC4883991C21CD74ED46AA=iSpace.ExecuteQuery(querySourceBA60CD900CDC4883991C21CD74ED46AA,@"EXEC GETReceiptAmountBalace 3,'" + ISpace["C_FC_ProjectNo_33"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceBA60CD900CDC4883991C21CD74ED46AA =GetQueryExpressionDataSource(""BA60CD90-0CDC-4883-991C-21CD74ED46AA"");Dictionary<short,object> resultBA60CD900CDC4883991C21CD74ED46AA=iSpace.ExecuteQuery(querySourceBA60CD900CDC4883991C21CD74ED46AA,@""EXEC GETReceiptAmountBalace 3,'"" + ISpace[""C_FC_ProjectNo_33""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultBA60CD900CDC4883991C21CD74ED46AA!=null) && (resultBA60CD900CDC4883991C21CD74ED46AA.Count!=0))
{
if(resultBA60CD900CDC4883991C21CD74ED46AA.ContainsKey(2))
ISpace["C_FC_ReceiptAmountinBudgetHead"].Value = resultBA60CD900CDC4883991C21CD74ED46AA[2];
if(resultBA60CD900CDC4883991C21CD74ED46AA.ContainsKey(1))
ISpace["C_FC_BudgetHeadAmount"].Value = resultBA60CD900CDC4883991C21CD74ED46AA[1];
}
else{
ISpace["C_FC_ReceiptAmountinBudgetHead"].Value = null;ISpace["C_FC_BudgetHeadAmount"].Value = null;
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
private void SubscribeElementEvents_travel_type (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Travel_Type-OnChange");
if(ISpace["Travel_Type"].Value=="1")
{
base.WriteDebugInfo(@"if(ISpace[""Travel_Type""].Value==""1"")");
ISpace["MF_T1_AccountNo"].Man=false;ISpace["MF_T1_BankBranch"].Man=false;ISpace["MF_T1_BeneficiaryName"].Man=false;ISpace["MF_T1_BankDocument"].Man=false;ISpace["MF_T1_BankName"].Man=false;
base.WriteDebugInfo(@"ISpace[""MF_T1_AccountNo""].Man=false;ISpace[""MF_T1_BankBranch""].Man=false;ISpace[""MF_T1_BeneficiaryName""].Man=false;ISpace[""MF_T1_BankDocument""].Man=false;ISpace[""MF_T1_BankName""].Man=false;");
}
if(ISpace["Travel_Type"].Value=="3")
{
base.WriteDebugInfo(@"if(ISpace[""Travel_Type""].Value==""3"")");
ISpace["MF_T1_AccountNo"].Man=true;ISpace["MF_T1_AccountNo"].Enbl="true";ISpace["MF_T1_BankBranch"].Man=true;ISpace["MF_T1_BankBranch"].Enbl="true";ISpace["MF_T1_AdvanceAmount"].Man=true;ISpace["MF_T1_AdvanceAmount"].Enbl="true";ISpace["MF_T1_BeneficiaryName"].Man=true;ISpace["MF_T1_BeneficiaryName"].Enbl="true";ISpace["MF_T1_BankDocument"].Man=true;ISpace["MF_T1_BankDocument"].Enbl="true";ISpace["MF_T1_BankName"].Man=true;ISpace["MF_T1_BankName"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_T1_AccountNo""].Man=true;ISpace[""MF_T1_AccountNo""].Enbl=""true"";ISpace[""MF_T1_BankBranch""].Man=true;ISpace[""MF_T1_BankBranch""].Enbl=""true"";ISpace[""MF_T1_AdvanceAmount""].Man=true;ISpace[""MF_T1_AdvanceAmount""].Enbl=""true"";ISpace[""MF_T1_BeneficiaryName""].Man=true;ISpace[""MF_T1_BeneficiaryName""].Enbl=""true"";ISpace[""MF_T1_BankDocument""].Man=true;ISpace[""MF_T1_BankDocument""].Enbl=""true"";ISpace[""MF_T1_BankName""].Man=true;ISpace[""MF_T1_BankName""].Enbl=""true"";");
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
private void SubscribeElementEvents_mg_t2_amount (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MG_T2_Amount-OnChange");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
object MG_T2_Amount=iSpace.Sum("[FA412DDD-7AD9-49AF-B8D7-2B7E1620D8FC]","MG_T2_Amount","",ISpace["gv_instanceid"].Value);
ISpace["T_TravelAdvanceTotal"].Value=Convert.ChangeType(MG_T2_Amount, MG_T2_Amount.GetType());;
base.WriteDebugInfo(@"object MG_T2_Amount=iSpace.Sum(""[FA412DDD-7AD9-49AF-B8D7-2B7E1620D8FC]"",""MG_T2_Amount"","""",ISpace[""gv_instanceid""].Value);
ISpace[""T_TravelAdvanceTotal""].Value=Convert.ChangeType(MG_T2_Amount, MG_T2_Amount.GetType());;");
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
		if(elementName.ToLower().Equals("mfg_t2_modeofjourney"))
    {
    			SubscribeElementEvents_mfg_t2_modeofjourney(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mf_projectno"))
    {
    			SubscribeElementEvents_mf_projectno(ref dfsParam);
    }
		if(elementName.ToLower().Equals("t_expendituretotal"))
    {
    			SubscribeElementEvents_t_expendituretotal(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mfg_t2_departure"))
    {
    			SubscribeElementEvents_mfg_t2_departure(ref dfsParam);
    }
		if(elementName.ToLower().Equals("overall_total"))
    {
    			SubscribeElementEvents_overall_total(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mg_t3_amount"))
    {
    			SubscribeElementEvents_mg_t3_amount(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mfg_t2_departuredate"))
    {
    			SubscribeElementEvents_mfg_t2_departuredate(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mfg_t2_arrivaldate"))
    {
    			SubscribeElementEvents_mfg_t2_arrivaldate(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mf_fundtype"))
    {
    			SubscribeElementEvents_mf_fundtype(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mf_t1_budgethead"))
    {
    			SubscribeElementEvents_mf_t1_budgethead(ref dfsParam);
    }
		if(elementName.ToLower().Equals("m_isadvancerequired"))
    {
    			SubscribeElementEvents_m_isadvancerequired(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mg_t2_fromdate"))
    {
    			SubscribeElementEvents_mg_t2_fromdate(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mg_t2_todate"))
    {
    			SubscribeElementEvents_mg_t2_todate(ref dfsParam);
    }
		if(elementName.ToLower().Equals("t_traveladvancetotal"))
    {
    			SubscribeElementEvents_t_traveladvancetotal(ref dfsParam);
    }
		if(elementName.ToLower().Equals("m_moveto"))
    {
    			SubscribeElementEvents_m_moveto(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mfg_t2_todate"))
    {
    			SubscribeElementEvents_mfg_t2_todate(ref dfsParam);
    }
		if(elementName.ToLower().Equals("advanceamount"))
    {
    			SubscribeElementEvents_advanceamount(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mfg_t2_fromdate"))
    {
    			SubscribeElementEvents_mfg_t2_fromdate(ref dfsParam);
    }
		if(elementName.ToLower().Equals("c_fc_projectno_33"))
    {
    			SubscribeElementEvents_c_fc_projectno_33(ref dfsParam);
    }
		if(elementName.ToLower().Equals("travel_type"))
    {
    			SubscribeElementEvents_travel_type(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mfg_t2_arrival"))
    {
    			SubscribeElementEvents_mfg_t2_arrival(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mg_t2_amount"))
    {
    			SubscribeElementEvents_mg_t2_amount(ref dfsParam);
    }
}
	if(methodName.ToLower().Equals("onclick"))
{
		if(elementName.ToLower().Equals("delete_travelexpense"))
{
			SubscribeElementEvents_delete_travelexpense(ref dfsParam);
}
		if(elementName.ToLower().Equals("edit_otherexpense"))
{
			SubscribeElementEvents_edit_otherexpense(ref dfsParam);
}
		if(elementName.ToLower().Equals("submitform"))
{
			SubscribeElementEvents_submitform(ref dfsParam);
}
		if(elementName.ToLower().Equals("delete_otherexpense"))
{
			SubscribeElementEvents_delete_otherexpense(ref dfsParam);
}
		if(elementName.ToLower().Equals("m_otherno"))
{
			SubscribeElementEvents_m_otherno(ref dfsParam);
}
		if(elementName.ToLower().Equals("save_travelexpense"))
{
			SubscribeElementEvents_save_travelexpense(ref dfsParam);
}
		if(elementName.ToLower().Equals("mf_add"))
{
			SubscribeElementEvents_mf_add(ref dfsParam);
}
		if(elementName.ToLower().Equals("edit_travelexpense"))
{
			SubscribeElementEvents_edit_travelexpense(ref dfsParam);
}
		if(elementName.ToLower().Equals("save_otherexpense"))
{
			SubscribeElementEvents_save_otherexpense(ref dfsParam);
}
		if(elementName.ToLower().Equals("m_travelno"))
{
			SubscribeElementEvents_m_travelno(ref dfsParam);
}
		if(elementName.ToLower().Equals("mg_edit"))
{
			SubscribeElementEvents_mg_edit(ref dfsParam);
}
		if(elementName.ToLower().Equals("m_fundno"))
{
			SubscribeElementEvents_m_fundno(ref dfsParam);
}
		if(elementName.ToLower().Equals("m_travelyes"))
{
			SubscribeElementEvents_m_travelyes(ref dfsParam);
}
		if(elementName.ToLower().Equals("m_fundyes"))
{
			SubscribeElementEvents_m_fundyes(ref dfsParam);
}
		if(elementName.ToLower().Equals("m_otheryes"))
{
			SubscribeElementEvents_m_otheryes(ref dfsParam);
}
		if(elementName.ToLower().Equals("mg_delete"))
{
			SubscribeElementEvents_mg_delete(ref dfsParam);
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
public class ISpaceA6341F0603944CAA88D0B7B36027AF06 : VirtualForm
{
IISpace iSpace = new ISpace();
AcDataISpaceA6341F0603944CAA88D0B7B36027AF06 acdataIspaceA6341F0603944CAA88D0B7B36027AF06=new AcDataISpaceA6341F0603944CAA88D0B7B36027AF06();
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
ISpace["M_TravelInstanceId"].Value=Guid.NewGuid().ToString();
base.WriteDebugInfo(@"ISpace[""M_TravelInstanceId""].Value=Guid.NewGuid().ToString();");
ISpace["M_MoveTo"].Man=true;
base.WriteDebugInfo(@"ISpace[""M_MoveTo""].Man=true;");
ISpace["M_Remarks"].Value="";
base.WriteDebugInfo(@"ISpace[""M_Remarks""].Value="""";");
ISpace["M_NextStage"].Value="";
base.WriteDebugInfo(@"ISpace[""M_NextStage""].Value="""";");
ISpace["MF_TransactionDate"].Man=true;ISpace["MF_TransactionNo"].Man=true;
base.WriteDebugInfo(@"ISpace[""MF_TransactionDate""].Man=true;ISpace[""MF_TransactionNo""].Man=true;");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySourceA0ECD2B8980941FB814ECFF85B9E0A09 =GetQueryExpressionDataSource("A0ECD2B8-9809-41FB-814E-CFF85B9E0A09");

DataTable resultA0ECD2B8980941FB814ECFF85B9E0A09=iSpace.SetGridDataSource(querySourceA0ECD2B8980941FB814ECFF85B9E0A09, _objectFactory.GetGridRPP("MG_RemarksDetails"),@"EXEC GetRemarks '" + ISpace["M_InstanceId"].Value + @"'");

iSpace.InsertGridBindDetails("MG_RemarksDetails","11",querySourceA0ECD2B8980941FB814ECFF85B9E0A09,"EXEC GetRemarks '" + ISpace["M_InstanceId"].Value + @"'",_objectFactory.GetGridRPP("MG_RemarksDetails"));

base.WriteDebugInfo(@"var querySourceA0ECD2B8980941FB814ECFF85B9E0A09 =GetQueryExpressionDataSource(""A0ECD2B8-9809-41FB-814E-CFF85B9E0A09"");DataTable resultA0ECD2B8980941FB814ECFF85B9E0A09=iSpace.SetGridDataSource(querySourceA0ECD2B8980941FB814ECFF85B9E0A09, _objectFactory.GetGridRPP(""MG_RemarksDetails""),@""EXEC GetRemarks '"" + ISpace[""M_InstanceId""].Value + @""'"");iSpace.InsertGridBindDetails(""MG_RemarksDetails"",""11"",querySourceA0ECD2B8980941FB814ECFF85B9E0A09,""EXEC GetRemarks '"" + ISpace[""M_InstanceId""].Value + @""'"",_objectFactory.GetGridRPP(""MG_RemarksDetails""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> resultCBD3E108E08C4B5F8ACA817E51BDACD4=acdataIspaceA6341F0603944CAA88D0B7B36027AF06.GetQueryExpressionBindings("CBD3E108-E08C-4B5F-8ACA-817E51BDACD4");
iSpace.SetGridData(resultA0ECD2B8980941FB814ECFF85B9E0A09,resultCBD3E108E08C4B5F8ACA817E51BDACD4,"MG_RemarksDetails",ref ISpace);
iSpace.UpdateGridBindDetails("MG_RemarksDetails",resultCBD3E108E08C4B5F8ACA817E51BDACD4);
}
ISpace["UC_DOJ"].Visible="false";ISpace["UC_EmailId"].Visible="false";ISpace["UC_PhoneNumber"].Visible="false";ISpace["UC_DOB"].Visible="false";ISpace["UC_Grade"].Visible="false";ISpace["UC_DOR"].Visible="false";ISpace["UC_Paylevel"].Visible="false";
base.WriteDebugInfo(@"ISpace[""UC_DOJ""].Visible=""false"";ISpace[""UC_EmailId""].Visible=""false"";ISpace[""UC_PhoneNumber""].Visible=""false"";ISpace[""UC_DOB""].Visible=""false"";ISpace[""UC_Grade""].Visible=""false"";ISpace[""UC_DOR""].Visible=""false"";ISpace[""UC_Paylevel""].Visible=""false"";");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["MFG_T2_ModeofJourney"].Visible="true";ISpace["MFG_T2_Departure"].Visible="true";ISpace["MFG_T2_Road"].Visible="true";ISpace["MFG_T2_DepartureDate"].Visible="true";ISpace["MFG_T2_ArrivalDate"].Visible="true";ISpace["MF_T1_BudgetHead"].Visible="true";ISpace["MFG_T2_TravelAdvanceID"].Visible="false";ISpace["MF_T1_Destination"].Visible="true";ISpace["MFG_T2_Amount"].Visible="true";ISpace["MF_T1_AvailableBudget"].Visible="true";ISpace["MF_T1_JourneyPurpose"].Visible="true";ISpace["MFG_T2_PNRNo"].Visible="true";ISpace["MFG_T2_JourneyClass"].Visible="true";ISpace["MFG_T2_DepartureTime"].Visible="true";ISpace["MFG_T2_ToDate"].Visible="true";ISpace["MF_T1_AccountNo"].Visible="true";ISpace["MFG_T2_FromDate"].Visible="true";ISpace["MFG_T3_Amount"].Visible="true";ISpace["MFG_T3_TravelAdvanceID"].Visible="false";ISpace["MF_T1_TravelType"].Visible="true";ISpace["MF_T1_BankBranch"].Visible="true";ISpace["MF_T1_ProjectNo"].Visible="true";ISpace["MFG_T2_TADetailsID"].Visible="false";ISpace["MFG_T2_ArrivalTime"].Visible="true";ISpace["MF_T1_AdvanceAmount"].Visible="true";ISpace["MFG_T2_ExpenditureTypeID"].Visible="true";ISpace["MF_T1_TravellingPerson"].Visible="true";ISpace["MF_T1_BeneficiaryName"].Visible="true";ISpace["MF_T1_BankDocument"].Visible="true";ISpace["MF_T1_TravelAdvanceID"].Visible="false";ISpace["MF_T1_BankName"].Visible="true";ISpace["MFG_T2_Arrival"].Visible="true";ISpace["MF_T1_ReferenceNo"].Visible="true";
base.WriteDebugInfo(@"ISpace[""MFG_T2_ModeofJourney""].Visible=""true"";ISpace[""MFG_T2_Departure""].Visible=""true"";ISpace[""MFG_T2_Road""].Visible=""true"";ISpace[""MFG_T2_DepartureDate""].Visible=""true"";ISpace[""MFG_T2_ArrivalDate""].Visible=""true"";ISpace[""MF_T1_BudgetHead""].Visible=""true"";ISpace[""MFG_T2_TravelAdvanceID""].Visible=""false"";ISpace[""MF_T1_Destination""].Visible=""true"";ISpace[""MFG_T2_Amount""].Visible=""true"";ISpace[""MF_T1_AvailableBudget""].Visible=""true"";ISpace[""MF_T1_JourneyPurpose""].Visible=""true"";ISpace[""MFG_T2_PNRNo""].Visible=""true"";ISpace[""MFG_T2_JourneyClass""].Visible=""true"";ISpace[""MFG_T2_DepartureTime""].Visible=""true"";ISpace[""MFG_T2_ToDate""].Visible=""true"";ISpace[""MF_T1_AccountNo""].Visible=""true"";ISpace[""MFG_T2_FromDate""].Visible=""true"";ISpace[""MFG_T3_Amount""].Visible=""true"";ISpace[""MFG_T3_TravelAdvanceID""].Visible=""false"";ISpace[""MF_T1_TravelType""].Visible=""true"";ISpace[""MF_T1_BankBranch""].Visible=""true"";ISpace[""MF_T1_ProjectNo""].Visible=""true"";ISpace[""MFG_T2_TADetailsID""].Visible=""false"";ISpace[""MFG_T2_ArrivalTime""].Visible=""true"";ISpace[""MF_T1_AdvanceAmount""].Visible=""true"";ISpace[""MFG_T2_ExpenditureTypeID""].Visible=""true"";ISpace[""MF_T1_TravellingPerson""].Visible=""true"";ISpace[""MF_T1_BeneficiaryName""].Visible=""true"";ISpace[""MF_T1_BankDocument""].Visible=""true"";ISpace[""MF_T1_TravelAdvanceID""].Visible=""false"";ISpace[""MF_T1_BankName""].Visible=""true"";ISpace[""MFG_T2_Arrival""].Visible=""true"";ISpace[""MF_T1_ReferenceNo""].Visible=""true"";");
ISpace["MG_T2_Arrival"].Visible="true";ISpace["MG_T2_Road"].Visible="true";ISpace["MG_T2_TADetailsID"].Visible="false";ISpace["MG_T2_PNRNo"].Visible="true";ISpace["MG_T2_Departure"].Visible="true";ISpace["MG_T2_DepartureDate"].Visible="true";ISpace["MG_T2_ArrivalDate"].Visible="true";ISpace["MG_T3_TravelAdvanceID"].Visible="false";ISpace["MG_T2_DepartureTime"].Visible="true";ISpace["MG_T2_JourneyClass"].Visible="true";ISpace["MG_T2_ModeofJourney"].Visible="true";ISpace["MG_T2_ArrivalTime"].Visible="true";ISpace["MG_T2_Amount"].Visible="true";
base.WriteDebugInfo(@"ISpace[""MG_T2_Arrival""].Visible=""true"";ISpace[""MG_T2_Road""].Visible=""true"";ISpace[""MG_T2_TADetailsID""].Visible=""false"";ISpace[""MG_T2_PNRNo""].Visible=""true"";ISpace[""MG_T2_Departure""].Visible=""true"";ISpace[""MG_T2_DepartureDate""].Visible=""true"";ISpace[""MG_T2_ArrivalDate""].Visible=""true"";ISpace[""MG_T3_TravelAdvanceID""].Visible=""false"";ISpace[""MG_T2_DepartureTime""].Visible=""true"";ISpace[""MG_T2_JourneyClass""].Visible=""true"";ISpace[""MG_T2_ModeofJourney""].Visible=""true"";ISpace[""MG_T2_ArrivalTime""].Visible=""true"";ISpace[""MG_T2_Amount""].Visible=""true"";");
ISpace["MG_T3_Amount"].Visible="true";ISpace["MG_T2_ExpenditureTypeID"].Visible="true";ISpace["MG_T2_FromDate"].Visible="true";ISpace["MG_T2_ToDate"].Visible="true";ISpace["MG_T2_TravelAdvanceID"].Visible="false";
base.WriteDebugInfo(@"ISpace[""MG_T3_Amount""].Visible=""true"";ISpace[""MG_T2_ExpenditureTypeID""].Visible=""true"";ISpace[""MG_T2_FromDate""].Visible=""true"";ISpace[""MG_T2_ToDate""].Visible=""true"";ISpace[""MG_T2_TravelAdvanceID""].Visible=""false"";");
}
if(ISpace["Travel_Type"].Value=="1")
{
base.WriteDebugInfo(@"if(ISpace[""Travel_Type""].Value==""1"")");
ISpace["MF_T1_AccountNo"].Man=false;ISpace["MF_T1_BankBranch"].Man=false;ISpace["MF_T1_BeneficiaryName"].Man=false;ISpace["MF_T1_BankDocument"].Man=false;ISpace["MF_T1_BankName"].Man=false;
base.WriteDebugInfo(@"ISpace[""MF_T1_AccountNo""].Man=false;ISpace[""MF_T1_BankBranch""].Man=false;ISpace[""MF_T1_BeneficiaryName""].Man=false;ISpace[""MF_T1_BankDocument""].Man=false;ISpace[""MF_T1_BankName""].Man=false;");
}
if(ISpace["Travel_Type"].Value=="3")
{
base.WriteDebugInfo(@"if(ISpace[""Travel_Type""].Value==""3"")");
ISpace["MF_T1_AccountNo"].Man=true;ISpace["MF_T1_AccountNo"].Enbl="true";ISpace["MF_T1_BankBranch"].Man=true;ISpace["MF_T1_BankBranch"].Enbl="true";ISpace["MF_T1_AdvanceAmount"].Man=true;ISpace["MF_T1_AdvanceAmount"].Enbl="true";ISpace["MF_T1_BeneficiaryName"].Man=true;ISpace["MF_T1_BeneficiaryName"].Enbl="true";ISpace["MF_T1_BankDocument"].Man=true;ISpace["MF_T1_BankDocument"].Enbl="true";ISpace["MF_T1_BankName"].Man=true;ISpace["MF_T1_BankName"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""MF_T1_AccountNo""].Man=true;ISpace[""MF_T1_AccountNo""].Enbl=""true"";ISpace[""MF_T1_BankBranch""].Man=true;ISpace[""MF_T1_BankBranch""].Enbl=""true"";ISpace[""MF_T1_AdvanceAmount""].Man=true;ISpace[""MF_T1_AdvanceAmount""].Enbl=""true"";ISpace[""MF_T1_BeneficiaryName""].Man=true;ISpace[""MF_T1_BeneficiaryName""].Enbl=""true"";ISpace[""MF_T1_BankDocument""].Man=true;ISpace[""MF_T1_BankDocument""].Enbl=""true"";ISpace[""MF_T1_BankName""].Man=true;ISpace[""MF_T1_BankName""].Enbl=""true"";");
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
return;
base.WriteDebugInfo(@"return;");
}
if(ISpace["M_SaveDomainData"].Value==0&&ISpace["M_IsflowReturned"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""M_SaveDomainData""].Value==0&&ISpace[""M_IsflowReturned""].Value==1)");
base.WriteDebugInfo(@"exec [SendReturnEmailForTR] '#MF_T1_TravelAdvanceID'");

var querySourceDE33E12BFBC142E094A9B51B2789A1AE =GetQueryExpressionDataSource("DE33E12B-FBC1-42E0-94A9-B51B2789A1AE");
Dictionary<short,object> resultDE33E12BFBC142E094A9B51B2789A1AE=iSpace.ExecuteQuery(querySourceDE33E12BFBC142E094A9B51B2789A1AE,@"exec [SendReturnEmailForTR] '" + ISpace["MF_T1_TravelAdvanceID"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceDE33E12BFBC142E094A9B51B2789A1AE =GetQueryExpressionDataSource(""DE33E12B-FBC1-42E0-94A9-B51B2789A1AE"");Dictionary<short,object> resultDE33E12BFBC142E094A9B51B2789A1AE=iSpace.ExecuteQuery(querySourceDE33E12BFBC142E094A9B51B2789A1AE,@""exec [SendReturnEmailForTR] '"" + ISpace[""MF_T1_TravelAdvanceID""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultDE33E12BFBC142E094A9B51B2789A1AE!=null) && (resultDE33E12BFBC142E094A9B51B2789A1AE.Count!=0))
{
if(resultDE33E12BFBC142E094A9B51B2789A1AE.ContainsKey(0))
ISpace["A"].Value = resultDE33E12BFBC142E094A9B51B2789A1AE[0];
}
else{
ISpace["A"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
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

base.WriteDebugInfo(@"EXEC UpsertProjectBudgetDetails 6,'#MG_ProjectDetailsId','#MF_T1_TravelAdvanceID','#MG_Amount','#MG_BudgetHead','1','#MG_FundTypeid','#M_PackageProcessMapId','#UC_EmployeeBaicInfoId'");

var querySource579419E790FA4F5A847AADEFF8FBD8C9 =GetQueryExpressionDataSource("579419E7-90FA-4F5A-847A-ADEFF8FBD8C9");
Dictionary<short,object> result579419E790FA4F5A847AADEFF8FBD8C9=iSpace.ExecuteQuery(querySource579419E790FA4F5A847AADEFF8FBD8C9,@"EXEC UpsertProjectBudgetDetails 6,'" + ISpace["MG_ProjectDetailsId"].Value + @"','" + ISpace["MF_T1_TravelAdvanceID"].Value + @"','" + ISpace["MG_Amount"].Value + @"','" + ISpace["MG_BudgetHead"].Value + @"','1','" + ISpace["MG_FundTypeid"].Value + @"','" + ISpace["M_PackageProcessMapId"].Value + @"','" + ISpace["UC_EmployeeBaicInfoId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource579419E790FA4F5A847AADEFF8FBD8C9 =GetQueryExpressionDataSource(""579419E7-90FA-4F5A-847A-ADEFF8FBD8C9"");Dictionary<short,object> result579419E790FA4F5A847AADEFF8FBD8C9=iSpace.ExecuteQuery(querySource579419E790FA4F5A847AADEFF8FBD8C9,@""EXEC UpsertProjectBudgetDetails 6,'"" + ISpace[""MG_ProjectDetailsId""].Value + @""','"" + ISpace[""MF_T1_TravelAdvanceID""].Value + @""','"" + ISpace[""MG_Amount""].Value + @""','"" + ISpace[""MG_BudgetHead""].Value + @""','1','"" + ISpace[""MG_FundTypeid""].Value + @""','"" + ISpace[""M_PackageProcessMapId""].Value + @""','"" + ISpace[""UC_EmployeeBaicInfoId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result579419E790FA4F5A847AADEFF8FBD8C9!=null) && (result579419E790FA4F5A847AADEFF8FBD8C9.Count!=0))
{
if(result579419E790FA4F5A847AADEFF8FBD8C9.ContainsKey(0))
ISpace["A"].Value = result579419E790FA4F5A847AADEFF8FBD8C9[0];
}
else{
ISpace["A"].Value = null;
}
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("MF_FundAmount","AD9C54EC-27A0-4C21-9923-063084E3B588",_objectFactory.GetGridRPP("MF_FundAmount"),_elementBase.GetGridLoopQuery("AD9C54EC-27A0-4C21-9923-063084E3B588","MF_FundAmount",ISpace), ref ISpace);
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
ISpace["Message"].Value=@"Submitted Successfully";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Submitted Successfully"";");
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

var querySource4DA95BD5CD3F4A6D8AE54C8A839E94D6 =GetQueryExpressionDataSource("4DA95BD5-CD3F-4A6D-8AE5-4C8A839E94D6");
Dictionary<short,object> result4DA95BD5CD3F4A6D8AE54C8A839E94D6=iSpace.ExecuteQuery(querySource4DA95BD5CD3F4A6D8AE54C8A839E94D6,@"Exec GetStageStatus 1,'','','" + ISpace["M_MoveToValue"].Value + @"','" + ISpace["M_SourceActivityMapId"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource4DA95BD5CD3F4A6D8AE54C8A839E94D6 =GetQueryExpressionDataSource(""4DA95BD5-CD3F-4A6D-8AE5-4C8A839E94D6"");Dictionary<short,object> result4DA95BD5CD3F4A6D8AE54C8A839E94D6=iSpace.ExecuteQuery(querySource4DA95BD5CD3F4A6D8AE54C8A839E94D6,@""Exec GetStageStatus 1,'','','"" + ISpace[""M_MoveToValue""].Value + @""','"" + ISpace[""M_SourceActivityMapId""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result4DA95BD5CD3F4A6D8AE54C8A839E94D6!=null) && (result4DA95BD5CD3F4A6D8AE54C8A839E94D6.Count!=0))
{
if(result4DA95BD5CD3F4A6D8AE54C8A839E94D6.ContainsKey(5))
ISpace["M_IsFlowReturned"].Value = result4DA95BD5CD3F4A6D8AE54C8A839E94D6[5];
if(result4DA95BD5CD3F4A6D8AE54C8A839E94D6.ContainsKey(6))
ISpace["M_IsCancelReject"].Value = result4DA95BD5CD3F4A6D8AE54C8A839E94D6[6];
if(result4DA95BD5CD3F4A6D8AE54C8A839E94D6.ContainsKey(4))
ISpace["M_FieldMandatory"].Value = result4DA95BD5CD3F4A6D8AE54C8A839E94D6[4];
if(result4DA95BD5CD3F4A6D8AE54C8A839E94D6.ContainsKey(1))
ISpace["M_RemarksMandatory"].Value = result4DA95BD5CD3F4A6D8AE54C8A839E94D6[1];
if(result4DA95BD5CD3F4A6D8AE54C8A839E94D6.ContainsKey(3))
ISpace["M_SaveDomainData"].Value = result4DA95BD5CD3F4A6D8AE54C8A839E94D6[3];
if(result4DA95BD5CD3F4A6D8AE54C8A839E94D6.ContainsKey(2))
ISpace["M_Remarks"].Value = result4DA95BD5CD3F4A6D8AE54C8A839E94D6[2];
if(result4DA95BD5CD3F4A6D8AE54C8A839E94D6.ContainsKey(0))
ISpace["M_NextStage"].Value = result4DA95BD5CD3F4A6D8AE54C8A839E94D6[0];
}
else{
ISpace["M_IsFlowReturned"].Value = null;ISpace["M_IsCancelReject"].Value = null;ISpace["M_FieldMandatory"].Value = null;ISpace["M_RemarksMandatory"].Value = null;ISpace["M_SaveDomainData"].Value = null;ISpace["M_Remarks"].Value = null;ISpace["M_NextStage"].Value = null;
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


	public partial class AcDataISpaceAAB051287AAE4A998278465822CE1E85  : ExtensionActivityBase
	{		
		
		
		private Dictionary<string,  List<Triplet<string, short, short?>>> queryExpressionBindings = 
											new Dictionary<string,  List<Triplet<string, short, short?>>>
		{
							{"1678D80A-E83E-4BA4-B40F-952B0A39779B", 
				
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
							{"49C758C3-CB9E-452A-8053-5E2651156E3D", 
				
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
							{"5A20F168-4718-49C2-B6E4-F11345E33F05", 
				
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
							{"8D30243F-BB2A-463A-85FF-7259BCF2E3B1", 
				
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
							{"8F99128D-9EF7-4BCF-8A42-5714C2D6D166", 
				
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
							{"BDC496F7-2D4A-4220-9C08-5EEFBC69334B", 
				
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
								   new Triplet<string, short, short?>("OtherExpense_RowId",5,
														   -1),
								}
			},
							{"CDF3C658-1D6D-49A1-9010-8A78BDE5A1F0", 
				
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
							{"F3AFBB51-AFF1-4D34-B122-16E3E1E5CA86", 
				
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
								   new Triplet<string, short, short?>("OtherExpense_RowId",5,
														   -1),
								}
			},
							{"F4BA7E5B-4EDA-4DCC-8731-56AE15108198", 
				
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
								   new Triplet<string, short, short?>("OtherExpense_RowId",5,
														   -1),
								}
			},
					};	

	

		private Dictionary<string,string> formVersionList =new Dictionary<string,string> 
		{
							{"817AE0D5-4499-4C2A-9284-F655B64E42CE", "Medium"},
							{"8DD8778A-50E2-4C00-800A-7842966EFCCA", "Mobile-Hybrid"},
							{"F1999B4E-8501-4C19-8C1E-E6D2CF779C53", "Tab"},
					};	

		
		private Dictionary<string,string> formVersionLayoutList =new Dictionary<string,string> 
		{
							{"8DD8778A-50E2-4C00-800A-7842966EFCCA", ""},
							{"F1999B4E-8501-4C19-8C1E-E6D2CF779C53", ""},
							{"817AE0D5-4499-4C2A-9284-F655B64E42CE", ""},
							{"A19D82AC-01AB-4790-89A6-EE37BEA29041", ""},
							{"42664738-9D61-49DA-87DB-8E2FAD524F07", ""},
							{"3E4523B5-3F0B-4F3C-888F-E54D46E37433", ""},
							{"DBFC7216-6FD5-43E9-A209-B657E720C849", ""},
							{"C4D082E5-520E-44C5-9660-AD68E5694A4D", ""},
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


	public partial class AcDataISpaceCE310762909A4A90A266630580753EC6  : ExtensionActivityBase
	{		
		
		
		private Dictionary<string,  List<Triplet<string, short, short?>>> queryExpressionBindings = 
											new Dictionary<string,  List<Triplet<string, short, short?>>>
		{
							{"49C758C3-CB9E-452A-8053-5E2651156E3D", 
				
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
							{"8F99128D-9EF7-4BCF-8A42-5714C2D6D166", 
				
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
							{"CBD3E108-E08C-4B5F-8ACA-817E51BDACD4", 
				
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
							{"CDF3C658-1D6D-49A1-9010-8A78BDE5A1F0", 
				
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
							{"817AE0D5-4499-4C2A-9284-F655B64E42CE", "Medium"},
							{"8DD8778A-50E2-4C00-800A-7842966EFCCA", "Mobile-Hybrid"},
							{"F1999B4E-8501-4C19-8C1E-E6D2CF779C53", "Tab"},
					};	

		
		private Dictionary<string,string> formVersionLayoutList =new Dictionary<string,string> 
		{
							{"8DD8778A-50E2-4C00-800A-7842966EFCCA", ""},
							{"F1999B4E-8501-4C19-8C1E-E6D2CF779C53", ""},
							{"817AE0D5-4499-4C2A-9284-F655B64E42CE", ""},
							{"A19D82AC-01AB-4790-89A6-EE37BEA29041", ""},
							{"42664738-9D61-49DA-87DB-8E2FAD524F07", ""},
							{"3E4523B5-3F0B-4F3C-888F-E54D46E37433", ""},
							{"DBFC7216-6FD5-43E9-A209-B657E720C849", ""},
							{"C4D082E5-520E-44C5-9660-AD68E5694A4D", ""},
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


	public partial class AcDataISpaceCFA9B7B28CF54389B2038EA7C779EE9A  : ExtensionActivityBase
	{		
		
		
		private Dictionary<string,  List<Triplet<string, short, short?>>> queryExpressionBindings = 
											new Dictionary<string,  List<Triplet<string, short, short?>>>
		{
							{"49C758C3-CB9E-452A-8053-5E2651156E3D", 
				
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
							{"8F99128D-9EF7-4BCF-8A42-5714C2D6D166", 
				
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
							{"CBD3E108-E08C-4B5F-8ACA-817E51BDACD4", 
				
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
							{"CDF3C658-1D6D-49A1-9010-8A78BDE5A1F0", 
				
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
							{"817AE0D5-4499-4C2A-9284-F655B64E42CE", "Medium"},
							{"8DD8778A-50E2-4C00-800A-7842966EFCCA", "Mobile-Hybrid"},
							{"F1999B4E-8501-4C19-8C1E-E6D2CF779C53", "Tab"},
					};	

		
		private Dictionary<string,string> formVersionLayoutList =new Dictionary<string,string> 
		{
							{"8DD8778A-50E2-4C00-800A-7842966EFCCA", ""},
							{"F1999B4E-8501-4C19-8C1E-E6D2CF779C53", ""},
							{"817AE0D5-4499-4C2A-9284-F655B64E42CE", ""},
							{"A19D82AC-01AB-4790-89A6-EE37BEA29041", ""},
							{"42664738-9D61-49DA-87DB-8E2FAD524F07", ""},
							{"3E4523B5-3F0B-4F3C-888F-E54D46E37433", ""},
							{"DBFC7216-6FD5-43E9-A209-B657E720C849", ""},
							{"C4D082E5-520E-44C5-9660-AD68E5694A4D", ""},
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


	public partial class AcDataISpaceC9900B03EFE6417C9C4EA09EA54B60FD  : ExtensionActivityBase
	{		
		
		
		private Dictionary<string,  List<Triplet<string, short, short?>>> queryExpressionBindings = 
											new Dictionary<string,  List<Triplet<string, short, short?>>>
		{
							{"CBD3E108-E08C-4B5F-8ACA-817E51BDACD4", 
				
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
							{"CDF3C658-1D6D-49A1-9010-8A78BDE5A1F0", 
				
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
							{"817AE0D5-4499-4C2A-9284-F655B64E42CE", "Medium"},
							{"8DD8778A-50E2-4C00-800A-7842966EFCCA", "Mobile-Hybrid"},
							{"F1999B4E-8501-4C19-8C1E-E6D2CF779C53", "Tab"},
					};	

		
		private Dictionary<string,string> formVersionLayoutList =new Dictionary<string,string> 
		{
							{"8DD8778A-50E2-4C00-800A-7842966EFCCA", ""},
							{"F1999B4E-8501-4C19-8C1E-E6D2CF779C53", ""},
							{"817AE0D5-4499-4C2A-9284-F655B64E42CE", ""},
							{"A19D82AC-01AB-4790-89A6-EE37BEA29041", ""},
							{"42664738-9D61-49DA-87DB-8E2FAD524F07", ""},
							{"3E4523B5-3F0B-4F3C-888F-E54D46E37433", ""},
							{"DBFC7216-6FD5-43E9-A209-B657E720C849", ""},
							{"C4D082E5-520E-44C5-9660-AD68E5694A4D", ""},
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


	public partial class AcDataISpaceB26F912289B24163B93837AD78E21338  : ExtensionActivityBase
	{		
		
		
		private Dictionary<string,  List<Triplet<string, short, short?>>> queryExpressionBindings = 
											new Dictionary<string,  List<Triplet<string, short, short?>>>
		{
							{"CBD3E108-E08C-4B5F-8ACA-817E51BDACD4", 
				
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
							{"CDF3C658-1D6D-49A1-9010-8A78BDE5A1F0", 
				
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
							{"817AE0D5-4499-4C2A-9284-F655B64E42CE", "Medium"},
							{"8DD8778A-50E2-4C00-800A-7842966EFCCA", "Mobile-Hybrid"},
							{"F1999B4E-8501-4C19-8C1E-E6D2CF779C53", "Tab"},
					};	

		
		private Dictionary<string,string> formVersionLayoutList =new Dictionary<string,string> 
		{
							{"8DD8778A-50E2-4C00-800A-7842966EFCCA", ""},
							{"F1999B4E-8501-4C19-8C1E-E6D2CF779C53", ""},
							{"817AE0D5-4499-4C2A-9284-F655B64E42CE", ""},
							{"A19D82AC-01AB-4790-89A6-EE37BEA29041", ""},
							{"42664738-9D61-49DA-87DB-8E2FAD524F07", ""},
							{"3E4523B5-3F0B-4F3C-888F-E54D46E37433", ""},
							{"DBFC7216-6FD5-43E9-A209-B657E720C849", ""},
							{"C4D082E5-520E-44C5-9660-AD68E5694A4D", ""},
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


	public partial class AcDataISpace5E4661C9726C4AD7A4577C4A84E9192D  : ExtensionActivityBase
	{		
		
		
		private Dictionary<string,  List<Triplet<string, short, short?>>> queryExpressionBindings = 
											new Dictionary<string,  List<Triplet<string, short, short?>>>
		{
							{"1678D80A-E83E-4BA4-B40F-952B0A39779B", 
				
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
							{"49C758C3-CB9E-452A-8053-5E2651156E3D", 
				
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
							{"5A20F168-4718-49C2-B6E4-F11345E33F05", 
				
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
							{"8D30243F-BB2A-463A-85FF-7259BCF2E3B1", 
				
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
							{"8F99128D-9EF7-4BCF-8A42-5714C2D6D166", 
				
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
							{"BDC496F7-2D4A-4220-9C08-5EEFBC69334B", 
				
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
								   new Triplet<string, short, short?>("OtherExpense_RowId",5,
														   -1),
								}
			},
							{"CBD3E108-E08C-4B5F-8ACA-817E51BDACD4", 
				
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
							{"CDF3C658-1D6D-49A1-9010-8A78BDE5A1F0", 
				
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
							{"F3AFBB51-AFF1-4D34-B122-16E3E1E5CA86", 
				
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
								   new Triplet<string, short, short?>("OtherExpense_RowId",5,
														   -1),
								}
			},
							{"F4BA7E5B-4EDA-4DCC-8731-56AE15108198", 
				
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
								   new Triplet<string, short, short?>("OtherExpense_RowId",5,
														   -1),
								}
			},
					};	

	

		private Dictionary<string,string> formVersionList =new Dictionary<string,string> 
		{
							{"817AE0D5-4499-4C2A-9284-F655B64E42CE", "Medium"},
							{"8DD8778A-50E2-4C00-800A-7842966EFCCA", "Mobile-Hybrid"},
							{"F1999B4E-8501-4C19-8C1E-E6D2CF779C53", "Tab"},
					};	

		
		private Dictionary<string,string> formVersionLayoutList =new Dictionary<string,string> 
		{
							{"8DD8778A-50E2-4C00-800A-7842966EFCCA", ""},
							{"F1999B4E-8501-4C19-8C1E-E6D2CF779C53", ""},
							{"817AE0D5-4499-4C2A-9284-F655B64E42CE", ""},
							{"A19D82AC-01AB-4790-89A6-EE37BEA29041", ""},
							{"42664738-9D61-49DA-87DB-8E2FAD524F07", ""},
							{"3E4523B5-3F0B-4F3C-888F-E54D46E37433", ""},
							{"DBFC7216-6FD5-43E9-A209-B657E720C849", ""},
							{"C4D082E5-520E-44C5-9660-AD68E5694A4D", ""},
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


	public partial class AcDataISpaceFC19D7A07BF74056886F90BB845D4611  : ExtensionActivityBase
	{		
		
		
		private Dictionary<string,  List<Triplet<string, short, short?>>> queryExpressionBindings = 
											new Dictionary<string,  List<Triplet<string, short, short?>>>
		{
							{"CDF3C658-1D6D-49A1-9010-8A78BDE5A1F0", 
				
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
							{"8DD8778A-50E2-4C00-800A-7842966EFCCA", "Mobile-Hybrid"},
							{"F1999B4E-8501-4C19-8C1E-E6D2CF779C53", "Tab"},
							{"817AE0D5-4499-4C2A-9284-F655B64E42CE", "Medium"},
							{"A19D82AC-01AB-4790-89A6-EE37BEA29041", "Large"},
							{"42664738-9D61-49DA-87DB-8E2FAD524F07", "AR"},
							{"3E4523B5-3F0B-4F3C-888F-E54D46E37433", "MR"},
							{"DBFC7216-6FD5-43E9-A209-B657E720C849", "HHT"},
							{"C4D082E5-520E-44C5-9660-AD68E5694A4D", "Mobile-Native"},
					};	

		
		private Dictionary<string,string> formVersionLayoutList =new Dictionary<string,string> 
		{
							{"8DD8778A-50E2-4C00-800A-7842966EFCCA", ""},
							{"F1999B4E-8501-4C19-8C1E-E6D2CF779C53", ""},
							{"817AE0D5-4499-4C2A-9284-F655B64E42CE", ""},
							{"A19D82AC-01AB-4790-89A6-EE37BEA29041", ""},
							{"42664738-9D61-49DA-87DB-8E2FAD524F07", ""},
							{"3E4523B5-3F0B-4F3C-888F-E54D46E37433", ""},
							{"DBFC7216-6FD5-43E9-A209-B657E720C849", ""},
							{"C4D082E5-520E-44C5-9660-AD68E5694A4D", ""},
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


	public partial class AcDataISpace8E4A6351852E4B5EA4BBB733D325B7A3  : ExtensionActivityBase
	{		
		
		
		private Dictionary<string,  List<Triplet<string, short, short?>>> queryExpressionBindings = 
											new Dictionary<string,  List<Triplet<string, short, short?>>>
		{
							{"CDF3C658-1D6D-49A1-9010-8A78BDE5A1F0", 
				
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
							{"8DD8778A-50E2-4C00-800A-7842966EFCCA", "Mobile-Hybrid"},
							{"F1999B4E-8501-4C19-8C1E-E6D2CF779C53", "Tab"},
							{"817AE0D5-4499-4C2A-9284-F655B64E42CE", "Medium"},
							{"A19D82AC-01AB-4790-89A6-EE37BEA29041", "Large"},
							{"42664738-9D61-49DA-87DB-8E2FAD524F07", "AR"},
							{"3E4523B5-3F0B-4F3C-888F-E54D46E37433", "MR"},
							{"DBFC7216-6FD5-43E9-A209-B657E720C849", "HHT"},
							{"C4D082E5-520E-44C5-9660-AD68E5694A4D", "Mobile-Native"},
					};	

		
		private Dictionary<string,string> formVersionLayoutList =new Dictionary<string,string> 
		{
							{"8DD8778A-50E2-4C00-800A-7842966EFCCA", ""},
							{"F1999B4E-8501-4C19-8C1E-E6D2CF779C53", ""},
							{"817AE0D5-4499-4C2A-9284-F655B64E42CE", ""},
							{"A19D82AC-01AB-4790-89A6-EE37BEA29041", ""},
							{"42664738-9D61-49DA-87DB-8E2FAD524F07", ""},
							{"3E4523B5-3F0B-4F3C-888F-E54D46E37433", ""},
							{"DBFC7216-6FD5-43E9-A209-B657E720C849", ""},
							{"C4D082E5-520E-44C5-9660-AD68E5694A4D", ""},
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


	public partial class AcDataISpaceA6341F0603944CAA88D0B7B36027AF06  : ExtensionActivityBase
	{		
		
		
		private Dictionary<string,  List<Triplet<string, short, short?>>> queryExpressionBindings = 
											new Dictionary<string,  List<Triplet<string, short, short?>>>
		{
							{"CBD3E108-E08C-4B5F-8ACA-817E51BDACD4", 
				
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
							{"CDF3C658-1D6D-49A1-9010-8A78BDE5A1F0", 
				
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
							{"817AE0D5-4499-4C2A-9284-F655B64E42CE", "Medium"},
							{"8DD8778A-50E2-4C00-800A-7842966EFCCA", "Mobile-Hybrid"},
							{"F1999B4E-8501-4C19-8C1E-E6D2CF779C53", "Tab"},
					};	

		
		private Dictionary<string,string> formVersionLayoutList =new Dictionary<string,string> 
		{
							{"8DD8778A-50E2-4C00-800A-7842966EFCCA", ""},
							{"F1999B4E-8501-4C19-8C1E-E6D2CF779C53", ""},
							{"817AE0D5-4499-4C2A-9284-F655B64E42CE", ""},
							{"A19D82AC-01AB-4790-89A6-EE37BEA29041", ""},
							{"42664738-9D61-49DA-87DB-8E2FAD524F07", ""},
							{"3E4523B5-3F0B-4F3C-888F-E54D46E37433", ""},
							{"DBFC7216-6FD5-43E9-A209-B657E720C849", ""},
							{"C4D082E5-520E-44C5-9660-AD68E5694A4D", ""},
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


	public partial class AcDataISpace70C5DBA74D0C4BCD914FB3C755F174E2  : ExtensionActivityBase
	{		
		
		
		private Dictionary<string,  List<Triplet<string, short, short?>>> queryExpressionBindings = 
											new Dictionary<string,  List<Triplet<string, short, short?>>>
		{
							{"CDF3C658-1D6D-49A1-9010-8A78BDE5A1F0", 
				
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
							{"817AE0D5-4499-4C2A-9284-F655B64E42CE", "Medium"},
							{"8DD8778A-50E2-4C00-800A-7842966EFCCA", "Mobile-Hybrid"},
							{"F1999B4E-8501-4C19-8C1E-E6D2CF779C53", "Tab"},
					};	

		
		private Dictionary<string,string> formVersionLayoutList =new Dictionary<string,string> 
		{
							{"8DD8778A-50E2-4C00-800A-7842966EFCCA", ""},
							{"F1999B4E-8501-4C19-8C1E-E6D2CF779C53", ""},
							{"817AE0D5-4499-4C2A-9284-F655B64E42CE", ""},
							{"A19D82AC-01AB-4790-89A6-EE37BEA29041", ""},
							{"42664738-9D61-49DA-87DB-8E2FAD524F07", ""},
							{"3E4523B5-3F0B-4F3C-888F-E54D46E37433", ""},
							{"DBFC7216-6FD5-43E9-A209-B657E720C849", ""},
							{"C4D082E5-520E-44C5-9660-AD68E5694A4D", ""},
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
		


