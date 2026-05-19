  







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
            get { return "6B8D5C61-726C-4E9B-96C6-9D4269CAB215"; }
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
            get { return "7EADC0EB-F718-4236-831D-51ED9DD6B47E"; }
        } 

		public override string FileGroup
        {
            get { return "Default"; }
        } 
		
        public override string PackageProcessMapId
        {
            get {return "6B8D5C61-726C-4E9B-96C6-9D4269CAB215";}
        }

		public override byte ProcessInstanceMode
        {
            get {return 3;}
        }		

		public override string MasterFormId
        {
            get {  
				   return "A83D8B17-78DB-4B11-86C7-91E3F9A7C20E";	}
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
	  			
			     new Triplet<string, string, string>("7A759801-183A-4615-8EDE-EA8E8ADD66BD","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"40BDEB14-07CC-4150-8A52-9B088A428E2D"),
			
						
			     new Triplet<string, string, string>("C3DD3B84-EDB4-4D12-BBD2-1628F58F0240","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("513C9438-A18C-49B9-8B6A-494F5A0E9D67","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"40BDEB14-07CC-4150-8A52-9B088A428E2D"),
			
						
			     new Triplet<string, string, string>("AEFACC4D-5CE9-417C-8C4C-FD22CB38EF75","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"CA34B07F-5D19-412F-A39F-3ADA64B5E0C0"),
			
						
			     new Triplet<string, string, string>("E28E41A4-DCE2-47A8-BF8B-175F80711881","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"40BDEB14-07CC-4150-8A52-9B088A428E2D"),
			
						
			     new Triplet<string, string, string>("B6ABAF29-49FA-4F27-8BAD-DC38EABC23C3","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"CA34B07F-5D19-412F-A39F-3ADA64B5E0C0"),
			
						
			     new Triplet<string, string, string>("52868FA1-8269-4E2A-BEAD-9A31AE431459","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"CA34B07F-5D19-412F-A39F-3ADA64B5E0C0"),
			
						
			     new Triplet<string, string, string>("6CBC85F9-5138-423B-9EC7-DC52792809B4","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"9ADED37B-CD11-426B-AF16-DEAC75685EF5"),
			
						
			     new Triplet<string, string, string>("7AD86927-2FFA-4555-BA40-DAA289C8646D","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"40BDEB14-07CC-4150-8A52-9B088A428E2D"),
			
						
			     new Triplet<string, string, string>("3158A085-81EB-4C06-AB09-0EE7136CEFA1","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"40BDEB14-07CC-4150-8A52-9B088A428E2D"),
			
						
			     new Triplet<string, string, string>("B8862B25-6DA5-4AA6-BA4A-FA4D3BF7D939","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"40BDEB14-07CC-4150-8A52-9B088A428E2D"),
			
						
			     new Triplet<string, string, string>("EDFA4E4D-24A3-46DB-9CEB-0D911F7A7788","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"028B1EFF-34A8-4D44-BF39-06CE99DF7C67"),
			
						
			     new Triplet<string, string, string>("F53C40FA-97A2-447F-9605-4E5BE7B63C82","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"CA34B07F-5D19-412F-A39F-3ADA64B5E0C0"),
			
						
			     new Triplet<string, string, string>("8CCD9B52-430B-4335-AB76-7F537BAD0538","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"CA34B07F-5D19-412F-A39F-3ADA64B5E0C0"),
			
						
			     new Triplet<string, string, string>("1E299FD2-2832-4078-A7C0-CAD053381515","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"40BDEB14-07CC-4150-8A52-9B088A428E2D"),
			
						
			     new Triplet<string, string, string>("5AA6086D-7B8E-418A-BF6A-ED65C96EC67F","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"40BDEB14-07CC-4150-8A52-9B088A428E2D"),
			
						
			     new Triplet<string, string, string>("4719FB3F-2577-4CA6-83C6-F0F853525696","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("CBF938DF-3126-4575-A0D3-09AC72307CDC","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("233CFB39-7AD7-4A45-AC65-B56FCE66F176","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"40BDEB14-07CC-4150-8A52-9B088A428E2D"),
			
						
			     new Triplet<string, string, string>("932BDBDF-7F2C-47CE-A185-EC1F9BCD25E0","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"40BDEB14-07CC-4150-8A52-9B088A428E2D"),
			
						
			     new Triplet<string, string, string>("7BED2578-928E-4BE6-954B-5BC6430BA133","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"40BDEB14-07CC-4150-8A52-9B088A428E2D"),
			
						
			     new Triplet<string, string, string>("81DC99CC-C22A-43C0-BB5D-79B98A0E5694","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"40BDEB14-07CC-4150-8A52-9B088A428E2D"),
			
						
			     new Triplet<string, string, string>("7470299E-490B-4DA1-B8F5-E586A05CF3F7","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"40BDEB14-07CC-4150-8A52-9B088A428E2D"),
			
						
			     new Triplet<string, string, string>("91DBFA58-C7F6-4EE3-B996-CB80B3DB89DA","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"40BDEB14-07CC-4150-8A52-9B088A428E2D"),
			
						
			     new Triplet<string, string, string>("5996D6F1-CAB8-49FD-A40F-68A8B580D8D5","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"40BDEB14-07CC-4150-8A52-9B088A428E2D"),
			
						
			     new Triplet<string, string, string>("109E996C-EF4B-435C-BA00-83A3578BC91C","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"40BDEB14-07CC-4150-8A52-9B088A428E2D"),
			
						
			     new Triplet<string, string, string>("00355DC3-AB59-4492-B9B9-02B50A5D90C0","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"40BDEB14-07CC-4150-8A52-9B088A428E2D"),
			
						
			     new Triplet<string, string, string>("BE406FDA-7399-493A-AD0D-40B5976591BD","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"40BDEB14-07CC-4150-8A52-9B088A428E2D"),
			
						
			     new Triplet<string, string, string>("B1B67B4A-1810-429B-B2EA-1E4E403EF164","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"40BDEB14-07CC-4150-8A52-9B088A428E2D"),
			
						
			     new Triplet<string, string, string>("B18506D4-9C13-4173-B34F-85F7A1DF7BA0","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"40BDEB14-07CC-4150-8A52-9B088A428E2D"),
			
						
			     new Triplet<string, string, string>("858ABA6B-4E8F-437C-974B-182BF16A305F","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"40BDEB14-07CC-4150-8A52-9B088A428E2D"),
			
						
			     new Triplet<string, string, string>("69D87FBD-9BEB-47BE-B916-F267A651A953","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"40BDEB14-07CC-4150-8A52-9B088A428E2D"),
			
						
			     new Triplet<string, string, string>("50B1C2C1-17D6-43DD-AABC-875561B59218","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("0B66B030-5C54-45D6-9318-D07B02259694","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"40BDEB14-07CC-4150-8A52-9B088A428E2D"),
			
						
			     new Triplet<string, string, string>("00EA9A50-A5C2-4EDB-9721-1F1969A17844","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"CA34B07F-5D19-412F-A39F-3ADA64B5E0C0"),
			
						
			     new Triplet<string, string, string>("30F76DA7-F4A3-4FC4-842D-F0B7584B8DD2","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"40BDEB14-07CC-4150-8A52-9B088A428E2D"),
			
						
			     new Triplet<string, string, string>("1C1F3E03-4BF7-47F4-9183-671021C3E6E6","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("8B95AB67-9C99-4ABA-B895-8DDF81393BE5","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("1DB6185E-E0DE-42DE-8D3F-09C15E423E6D","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"3A103712-5244-4427-B2B6-1C4E046FD337"),
			
						
			     new Triplet<string, string, string>("F580305D-8B4F-4B27-9DAC-649134053E19","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"CA34B07F-5D19-412F-A39F-3ADA64B5E0C0"),
			
						
			     new Triplet<string, string, string>("1711E384-D9DC-44A1-B25C-A5E3AE8384A6","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"CA34B07F-5D19-412F-A39F-3ADA64B5E0C0"),
			
						
			     new Triplet<string, string, string>("3BA2388F-D9AD-4AA1-B445-85AEEC9A21F5","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"40BDEB14-07CC-4150-8A52-9B088A428E2D"),
			
						
			     new Triplet<string, string, string>("20D9A82D-1FC5-44DF-9367-4FD5D55CF5CD","C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0",
												     @"40BDEB14-07CC-4150-8A52-9B088A428E2D"),
			
						
			     new Triplet<string, string, string>("8CCD9B52-430B-4335-AB76-7F537BAD0538","Reload grid",
												     @"C92F6C5D-F7CB-4E81-835C-3D655C7FCC52"),
			
						
			     new Triplet<string, string, string>("4719FB3F-2577-4CA6-83C6-F0F853525696","Delete row",
												     @"7CD25981-D914-448A-873A-2820C07FB607"),
			
						
			     new Triplet<string, string, string>("233CFB39-7AD7-4A45-AC65-B56FCE66F176","RDDOCUMENT",
												     @"1BD06026-1AB3-47A6-BF57-934CCF70B816"),
			
						
			     new Triplet<string, string, string>("932BDBDF-7F2C-47CE-A185-EC1F9BCD25E0","Co Pi Grid Load",
												     @"A8711B81-85A3-41BC-8B9B-67F9DAAFFCD5"),
			
						
			     new Triplet<string, string, string>("7BED2578-928E-4BE6-954B-5BC6430BA133","Document Grid Load",
												     @"7CD25981-D914-448A-873A-2820C07FB607"),
			
						
			     new Triplet<string, string, string>("81DC99CC-C22A-43C0-BB5D-79B98A0E5694","externalgrid",
												     @"1B307D9B-9E56-415F-8C11-BF109F7A2E30"),
			
						
			     new Triplet<string, string, string>("7470299E-490B-4DA1-B8F5-E586A05CF3F7","Budget Details Grid Load",
												     @"C92F6C5D-F7CB-4E81-835C-3D655C7FCC52"),
			
						
			     new Triplet<string, string, string>("91DBFA58-C7F6-4EE3-B996-CB80B3DB89DA","Equipment Grid Load",
												     @"71802A68-968A-4C2C-8AFE-32BA5B817B50"),
			
						
			     new Triplet<string, string, string>("B1B67B4A-1810-429B-B2EA-1E4E403EF164","ManpowerLoad",
												     @"70051D3C-20CA-47D4-9917-B33DED7ACE9C"),
			
						
			     new Triplet<string, string, string>("B18506D4-9C13-4173-B34F-85F7A1DF7BA0","R and D doc",
												     @"1BD06026-1AB3-47A6-BF57-934CCF70B816"),
			
						
			     new Triplet<string, string, string>("69D87FBD-9BEB-47BE-B916-F267A651A953","Budget Reload grid",
												     @"C92F6C5D-F7CB-4E81-835C-3D655C7FCC52"),
			
						
			     new Triplet<string, string, string>("50B1C2C1-17D6-43DD-AABC-875561B59218","Edit Budget Reload",
												     @"C92F6C5D-F7CB-4E81-835C-3D655C7FCC52"),
			
						
			     new Triplet<string, string, string>("0B66B030-5C54-45D6-9318-D07B02259694","externalgridFL",
												     @"1B307D9B-9E56-415F-8C11-BF109F7A2E30"),
			
						
			     new Triplet<string, string, string>("00EA9A50-A5C2-4EDB-9721-1F1969A17844","Co Pi Grid LoadFL",
												     @"A8711B81-85A3-41BC-8B9B-67F9DAAFFCD5"),
			
						
			     new Triplet<string, string, string>("3BA2388F-D9AD-4AA1-B445-85AEEC9A21F5","gridbind",
												     @"C92F6C5D-F7CB-4E81-835C-3D655C7FCC52"),
			
			
			
		};

		
		private List<Triplet<string, string, string>> ComboDataSource = new List<Triplet<string, string, string>>
		{

		
	  			
			     new Triplet<string, string, string>("Name","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43FK94a5ZctHFIArjst1ThMAqCwOWy+D7Ogje1I4jfjiAZNrjEazgaNyfBj9pr2u90nY6j9e5uwFkY5ACZLPM6ex3VGtw7Jsbew=",
												     @"EXEC GetDepartmentWiseFacultyCopi '@ExternalDepartment',3,'@DummyInstance',''"),
			
						
			     new Triplet<string, string, string>("MoveTo","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMA18yFT7KruzVDa0TqsqpOM+grujzoqor1KqRIderPPsozBAr7TiIaPx7MYO2zQclV",
												     @"EXEC GetMoveToValue '@ActivityMapid'"),
			
						
			     new Triplet<string, string, string>("TypeOfProject","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43FK94a5ZctHFIArjst1ThMAqCwOWy+D7Ogje1I4jfjiAZNrjEazgaNyfBj9pr2u90nY6j9e5uwFkY5ACZLPM6ex3VGtw7Jsbew=",
												     @"EXEC GetProjectDetailCombo 2"),
			
						
			     new Triplet<string, string, string>("ProjectProposal","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43FK94a5ZctHFIArjst1ThMAqCwOWy+D7Ogje1I4jfjiAZNrjEazgaNyfBj9pr2u90nY6j9e5uwFkY5ACZLPM6ex3VGtw7Jsbew=",
												     @"EXEC [GetProjectproposalDetails] 1,'@ID1','@EmpEmployeeBasicId'"),
			
						
			     new Triplet<string, string, string>("PrincipleInvestigator","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMAqCwOWy+D7Ogje1I4jfjiAZNrjEazgaNyfBj9pr2u90lOsHzRNfKnSybWqRxrZGqV",
												     @"EXEC GetDepartmentWiseFaculty '@Department',1,'','',''"),
			
						
			     new Triplet<string, string, string>("FundingAcencyName","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43FK94a5ZctHFIArjst1ThMAqCwOWy+D7Ogje1I4jfjiAZNrjEazgaNyfBj9pr2u90nY6j9e5uwFkY5ACZLPM6ex3VGtw7Jsbew=",
												     @"EXEC GetDateDifferenceInYears 7,'','',''"),
			
						
			     new Triplet<string, string, string>("FacultyType","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43FK94a5ZctHFIArjst1ThMAqCwOWy+D7Ogje1I4jfjiAZNrjEazgaNyfBj9pr2u90nY6j9e5uwFkY5ACZLPM6ex3VGtw7Jsbew=",
												     @"EXEC [GetDepartmentWiseFaculty] '',3,'','',''"),
			
						
			     new Triplet<string, string, string>("DocumentName","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43FK94a5ZctHFIArjst1ThMAqCwOWy+D7Ogje1I4jfjiAZNrjEazgaNyfBj9pr2u90nY6j9e5uwFkY5ACZLPM6ex3VGtw7Jsbew=",
												     @"EXEC GetDateDifferenceInYears 2,'','',''"),
			
						
			     new Triplet<string, string, string>("FundReceiptMode","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43FK94a5ZctHFIArjst1ThMAqCwOWy+D7Ogje1I4jfjiAZNrjEazgaNyfBj9pr2u90nY6j9e5uwFkY5ACZLPM6ex3VGtw7Jsbew=",
												     @"EXEC GetDateDifferenceInYears 16,'','',''"),
			
						
			     new Triplet<string, string, string>("Currency","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMA18yFT7KruzVDa0TqsqpOM+grujzoqor1KqRIderPPsozBAr7TiIaPx7MYO2zQclV",
												     @"select SubCategory,DictionaryValue from projects..GlobalDictionary where Category='Currenys'"),
			
						
			     new Triplet<string, string, string>("Department","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMAqCwOWy+D7Ogje1I4jfjiAZNrjEazgaNyfBj9pr2u90lOsHzRNfKnSybWqRxrZGqV",
												     @"EXEC [GetDepartmentCombo] 1"),
			
						
			     new Triplet<string, string, string>("MP_Position","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43FK94a5ZctHFIArjst1ThMAqCwOWy+D7Ogje1I4jfjiAZNrjEazgaNyfBj9pr2u90nY6j9e5uwFkY5ACZLPM6ex3VGtw7Jsbew=",
												     @"EXEC [GetProjectDetailCombo] 14"),
			
						
			     new Triplet<string, string, string>("Sector","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43FK94a5ZctHFIArjst1ThMAqCwOWy+D7Ogje1I4jfjiAZNrjEazgaNyfBj9pr2u90nY6j9e5uwFkY5ACZLPM6ex3VGtw7Jsbew=",
												     @"select DictionaryKey,DictionaryValue from GlobalDictionary where Category='Sectortype'"),
			
						
			     new Triplet<string, string, string>("ProjectCategory","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43FK94a5ZctHFIArjst1ThMAqCwOWy+D7Ogje1I4jfjiAZNrjEazgaNyfBj9pr2u90nY6j9e5uwFkY5ACZLPM6ex3VGtw7Jsbew=",
												     @"EXEC GetDateDifferenceInYears 4,'','',''"),
			
						
			     new Triplet<string, string, string>("BudgetHead","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43Ehmc2lZ2dV6IArjst1ThMAqCwOWy+D7Ogje1I4jfjiAZNrjEazgaNyfBj9pr2u90lOsHzRNfKnSybWqRxrZGqV",
												     @"EXEC GetProjectDetailCombo 6"),
			
						
			     new Triplet<string, string, string>("Name1","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43FK94a5ZctHFIArjst1ThMAqCwOWy+D7Ogje1I4jfjiAZNrjEazgaNyfBj9pr2u90nY6j9e5uwFkY5ACZLPM6ex3VGtw7Jsbew=",
												     @"EXEC [GetDepartmentWiseFacultyCopi] '',2,'@DummyInstance','@FacultyType'"),
			
						
			     new Triplet<string, string, string>("Duration","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43FK94a5ZctHFIArjst1ThMAqCwOWy+D7Ogje1I4jfjiAZNrjEazgaNyfBj9pr2u90nY6j9e5uwFkY5ACZLPM6ex3VGtw7Jsbew=",
												     @"EXEC GetDateDifferenceInYears 6,'','',''"),
			
						
			     new Triplet<string, string, string>("MonthYear","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43FK94a5ZctHFIArjst1ThMAqCwOWy+D7Ogje1I4jfjiAZNrjEazgaNyfBj9pr2u90nY6j9e5uwFkY5ACZLPM6ex3VGtw7Jsbew=",
												     @"EXEC GetDateDifferenceInYears 5,'','',''"),
			
						
			     new Triplet<string, string, string>("SchemeType","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43FK94a5ZctHFIArjst1ThMAqCwOWy+D7Ogje1I4jfjiAZNrjEazgaNyfBj9pr2u90nY6j9e5uwFkY5ACZLPM6ex3VGtw7Jsbew=",
												     @"EXEC GetProjectDetailCombo 5,'@FundingAcencyName'"),
			
						
			     new Triplet<string, string, string>("ExternalDepartment","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43FK94a5ZctHFIArjst1ThMAqCwOWy+D7Ogje1I4jfjiAZNrjEazgaNyfBj9pr2u90nY6j9e5uwFkY5ACZLPM6ex3VGtw7Jsbew=",
												     @"EXEC [GetDepartmentWiseFacultyCopi] '@Dept',2,'@DummyInstance','@facultytype'"),
			
						
			     new Triplet<string, string, string>("FinancialYear","Z4IrlPTfl7E3UHhZKuDmi6JCY+YHcA863SqFhgUyVVzIeVWsNWiw16Mu4wxMKNVEYFCkgoGo43FK94a5ZctHFIArjst1ThMAqCwOWy+D7Ogje1I4jfjiAZNrjEazgaNyfBj9pr2u90nY6j9e5uwFkY5ACZLPM6ex3VGtw7Jsbew=",
												     @"EXEC GetDateDifferenceInYears 8,'','',''"),
			
						
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
		
	  			
			     new Tuple<string, int>("ApprovalStatus",100),
			
						
			     new Tuple<string, int>("RDDocumentGrid",5),
			
						
			     new Tuple<string, int>("IncomeDetails",5),
			
						
			     new Tuple<string, int>("ExternalInstitute",50),
			
						
			     new Tuple<string, int>("BudgetDetails",100),
			
						
			     new Tuple<string, int>("DocumentDetails",25),
			
						
			     new Tuple<string, int>("CoPiDetails",50),
			
						
			     new Tuple<string, int>("EquipmentDetails",5),
			
						
			     new Tuple<string, int>("ManPowerDetails",100),
			
						
			     new Tuple<string, int>("ExpenditureDetails",5),
			
						
			     new Tuple<string, int>("FundReleaseDetails",5),
			
						
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
											case "D0B6EBB9-10A4-4D43-A76E-F39441A41EF6":
							virtualInstance=new ISpaceD0B6EBB910A44D43A76EF39441A41EF6();
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

               
                
                                      case "A83D8B17-78DB-4B11-86C7-91E3F9A7C20E":
                    {
                     
                                     fInsertQuery=@"IF NOT EXISTS(SELECT 1 FROM [A83D8B17-78DB-4B11-86C7-91E3F9A7C20E] WHERE InstanceId='{0}' AND
							ProcessActivityMapId='{1}' AND FormId='{2}') BEGIN INSERT INTO [A83D8B17-78DB-4B11-86C7-91E3F9A7C20E](ProcessActivityMapId,FormId,IntAmount,ManpowerTotalCost,BudgetID,ProjectBudget1,ReleaseAmount,DocumentCount,NonRecurringAmount,ProjectDetailsID,JourneyID,IsSubmit,ActiveEdit,EquipmentTotalCost,ManPowerAmount,CountCopi,RecurringAmount,ExtCount,ManPowerRequired,FundReceiptISActive,IfExternalIns,IFEquipment,Duration,ProjectKey,BudgetName,EmployeeName,EmpDepartment,Comments,TProjectName,FundReceiptCode,PackageprocessmapID,DuplicateBudget,TempInstanceID,DummyProject,DuplicateCheck,ReleaseDescription,BudgetDescription,DMValidation,ProcessID,REdit1,Department,Department1,SanctionNumber,setflowdummyremarks,Description1,SchemeDuplicate,AAName,DCode,ProjectRefNo,BudgetDuplicate1,TypeofprojectKey,FinancialYear1,FName,RedirectUrl,DepartmentType1,ProjectStatus,PrincipleInvestigator,DName,EmpEmployeeBasicId,EmpDeptCode,ExternalCount,Monthyear1,SetDestinationTo,ExecutionMessage,EmpDesignationID,Duration1,NextStage,InstanceId,FCode,Designation,DocumentComments,CategoryDuplicate,ProjectCode,AEmployeeID,ACode,FundDupCheck,EmpCode,PrincipleInvestigator1,FundReceiptName,JourneyDescription,InternalCount,ADepartment,ID1,FundingAcencyName1,ProjectName1,Subject,RootCopi,ProjectName,ProjectCategory1,AgencyDuplicate,Description,BudgetDuplicate,ActivityMapid,ExecutionStatus,Overheads,Aid,BudgetDomainCount,EquipmentAmount,Did,FundReceiptID,EndorsementAmount,BudgetCount,OverallBudgetTotal,EquipmentGridCount,IntExpense,Logid,Fid,SLATime,IsSubmitted,projectbudgets,ManpowerGridCount,ProjectBudget,DocumentName,MonthYear,Currency,Sector,SanctionedRelease,ProjectCategory,FinancialYear,TypeOfProject,SchemeType,FundingAcencyName,ProjectProposal,MoveTo,FundReceiptMode,StartDate1,SanctionDate,EndDate1,StartDate,ReleaseDate,EndDate,Upload,ImageUpload)
							VALUES( {3}) END ELSE BEGIN UPDATE [A83D8B17-78DB-4B11-86C7-91E3F9A7C20E]SET {4}WHERE InstanceId='{0}'AND ProcessActivityMapId='{1}'AND FormId='{2}'END ";

                                     colList=@"ProcessActivityMapId,FormId,IntAmount,ManpowerTotalCost,BudgetID,ProjectBudget1,ReleaseAmount,DocumentCount,NonRecurringAmount,ProjectDetailsID,JourneyID,IsSubmit,ActiveEdit,EquipmentTotalCost,ManPowerAmount,CountCopi,RecurringAmount,ExtCount,ManPowerRequired,FundReceiptISActive,IfExternalIns,IFEquipment,Duration,ProjectKey,BudgetName,EmployeeName,EmpDepartment,Comments,TProjectName,FundReceiptCode,PackageprocessmapID,DuplicateBudget,TempInstanceID,DummyProject,DuplicateCheck,ReleaseDescription,BudgetDescription,DMValidation,ProcessID,REdit1,Department,Department1,SanctionNumber,setflowdummyremarks,Description1,SchemeDuplicate,AAName,DCode,ProjectRefNo,BudgetDuplicate1,TypeofprojectKey,FinancialYear1,FName,RedirectUrl,DepartmentType1,ProjectStatus,PrincipleInvestigator,DName,EmpEmployeeBasicId,EmpDeptCode,ExternalCount,Monthyear1,SetDestinationTo,ExecutionMessage,EmpDesignationID,Duration1,NextStage,InstanceId,FCode,Designation,DocumentComments,CategoryDuplicate,ProjectCode,AEmployeeID,ACode,FundDupCheck,EmpCode,PrincipleInvestigator1,FundReceiptName,JourneyDescription,InternalCount,ADepartment,ID1,FundingAcencyName1,ProjectName1,Subject,RootCopi,ProjectName,ProjectCategory1,AgencyDuplicate,Description,BudgetDuplicate,ActivityMapid,ExecutionStatus,Overheads,Aid,BudgetDomainCount,EquipmentAmount,Did,FundReceiptID,EndorsementAmount,BudgetCount,OverallBudgetTotal,EquipmentGridCount,IntExpense,Logid,Fid,SLATime,IsSubmitted,projectbudgets,ManpowerGridCount,ProjectBudget,DocumentName,MonthYear,Currency,Sector,SanctionedRelease,ProjectCategory,FinancialYear,TypeOfProject,SchemeType,FundingAcencyName,ProjectProposal,MoveTo,FundReceiptMode,StartDate1,SanctionDate,EndDate1,StartDate,ReleaseDate,EndDate,Upload,ImageUpload";
                                    
                     
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

                
                 
                                      case "C92F6C5D-F7CB-4E81-835C-3D655C7FCC52":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_C92F6C5DF7CB4E81835C3D655C7FCC52 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [RDComments] VARCHAR(MAX)	, [ProjectBudgetDetailsid] VARCHAR(MAX)	, [BudgetHead] VARCHAR(MAX)	, [commentss] VARCHAR(MAX)	, [TotalBudget] DECIMAL(18,2)	, [Year21] INT	, [IncrementId] INT	, [Year19] INT	, [RecurringValidation] INT	, [Year13] INT	, [Year18] INT	, [Year20] INT	, [Year11] DECIMAL(18,2)	, [Year14] INT	, [Year16] INT	, [Year15] INT	, [Year22] INT	, [Reappropriation] DECIMAL(18,2)	, [BudgetAmount] DECIMAL(18,2)	, [Year17] INT	, [Bid] INT	, [Year12] INT){0}INSERT INTO [C92F6C5D-F7CB-4E81-835C-3D655C7FCC52](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,RDComments,ProjectBudgetDetailsid,BudgetHead,commentss,TotalBudget,Year21,IncrementId,Year19,RecurringValidation,Year13,Year18,Year20,Year11,Year14,Year16,Year15,Year22,Reappropriation,BudgetAmount,Year17,Bid,Year12)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.RDComments,TDT.ProjectBudgetDetailsid,TDT.BudgetHead,TDT.commentss,TDT.TotalBudget,TDT.Year21,TDT.IncrementId,TDT.Year19,TDT.RecurringValidation,TDT.Year13,TDT.Year18,TDT.Year20,TDT.Year11,TDT.Year14,TDT.Year16,TDT.Year15,TDT.Year22,TDT.Reappropriation,TDT.BudgetAmount,TDT.Year17,TDT.Bid,TDT.Year12 FROM @TBL_C92F6C5DF7CB4E81835C3D655C7FCC52 TDT
							LEFT JOIN [C92F6C5D-F7CB-4E81-835C-3D655C7FCC52] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,RDComments,ProjectBudgetDetailsid,BudgetHead,commentss,TotalBudget,Year21,IncrementId,Year19,RecurringValidation,Year13,Year18,Year20,Year11,Year14,Year16,Year15,Year22,Reappropriation,BudgetAmount,Year17,Bid,Year12";

                                     tempInsertQuery=@"INSERT INTO @TBL_C92F6C5DF7CB4E81835C3D655C7FCC52(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,RDComments,ProjectBudgetDetailsid,BudgetHead,commentss,TotalBudget,Year21,IncrementId,Year19,RecurringValidation,Year13,Year18,Year20,Year11,Year14,Year16,Year15,Year22,Reappropriation,BudgetAmount,Year17,Bid,Year12)VALUES({0});";
                                     

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
                     
                                    case "1B307D9B-9E56-415F-8C11-BF109F7A2E30":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_1B307D9B9E56415F8C11BF109F7A2E30 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [NKLIEI_Facultytype] VARCHAR(MAX)	, [NKLIEI_Name] VARCHAR(MAX)	, [NKLIEI_FacultyName] VARCHAR(MAX)	, [NKLIEI_ProjectdetailsID] VARCHAR(MAX)	, [NKLIEI_Mail] VARCHAR(MAX)	, [NKLIEI_PhoneNumber] VARCHAR(MAX)	, [NKLICoPiID] VARCHAR(MAX)	, [NKLIEI_Designation] VARCHAR(MAX)){0}INSERT INTO [1B307D9B-9E56-415F-8C11-BF109F7A2E30](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,NKLIEI_Facultytype,NKLIEI_Name,NKLIEI_FacultyName,NKLIEI_ProjectdetailsID,NKLIEI_Mail,NKLIEI_PhoneNumber,NKLICoPiID,NKLIEI_Designation)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.NKLIEI_Facultytype,TDT.NKLIEI_Name,TDT.NKLIEI_FacultyName,TDT.NKLIEI_ProjectdetailsID,TDT.NKLIEI_Mail,TDT.NKLIEI_PhoneNumber,TDT.NKLICoPiID,TDT.NKLIEI_Designation FROM @TBL_1B307D9B9E56415F8C11BF109F7A2E30 TDT
							LEFT JOIN [1B307D9B-9E56-415F-8C11-BF109F7A2E30] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,NKLIEI_Facultytype,NKLIEI_Name,NKLIEI_FacultyName,NKLIEI_ProjectdetailsID,NKLIEI_Mail,NKLIEI_PhoneNumber,NKLICoPiID,NKLIEI_Designation";

                                     tempInsertQuery=@"INSERT INTO @TBL_1B307D9B9E56415F8C11BF109F7A2E30(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,NKLIEI_Facultytype,NKLIEI_Name,NKLIEI_FacultyName,NKLIEI_ProjectdetailsID,NKLIEI_Mail,NKLIEI_PhoneNumber,NKLICoPiID,NKLIEI_Designation)VALUES({0});";
                                     

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
                     
                                    case "71802A68-968A-4C2C-8AFE-32BA5B817B50":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_71802A68968A4C2C8AFE32BA5B817B50 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [EquipmentID] VARCHAR(MAX)	, [EquipmentName] VARCHAR(MAX)	, [EQEquipmentDescription] VARCHAR(MAX)	, [EQEquipmentRateinINR] DECIMAL(18,2)	, [EQEquipmentTotalCost] DECIMAL(18,2)	, [EQEquipmentQuantity] INT	, [EquipmentBudget] DECIMAL(18,2)	, [EQSerialNo] INT){0}INSERT INTO [71802A68-968A-4C2C-8AFE-32BA5B817B50](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,EquipmentID,EquipmentName,EQEquipmentDescription,EQEquipmentRateinINR,EQEquipmentTotalCost,EQEquipmentQuantity,EquipmentBudget,EQSerialNo)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.EquipmentID,TDT.EquipmentName,TDT.EQEquipmentDescription,TDT.EQEquipmentRateinINR,TDT.EQEquipmentTotalCost,TDT.EQEquipmentQuantity,TDT.EquipmentBudget,TDT.EQSerialNo FROM @TBL_71802A68968A4C2C8AFE32BA5B817B50 TDT
							LEFT JOIN [71802A68-968A-4C2C-8AFE-32BA5B817B50] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,EquipmentID,EquipmentName,EQEquipmentDescription,EQEquipmentRateinINR,EQEquipmentTotalCost,EQEquipmentQuantity,EquipmentBudget,EQSerialNo";

                                     tempInsertQuery=@"INSERT INTO @TBL_71802A68968A4C2C8AFE32BA5B817B50(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,EquipmentID,EquipmentName,EQEquipmentDescription,EQEquipmentRateinINR,EQEquipmentTotalCost,EQEquipmentQuantity,EquipmentBudget,EQSerialNo)VALUES({0});";
                                     

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
                     
                                    case "4D3925E7-62C4-4A06-922B-2C6457DB2C5D":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_4D3925E762C44A06922B2C6457DB2C5D AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [IDR] VARCHAR(MAX)	, [GeturlR] VARCHAR(MAX)	, [NameR] VARCHAR(MAX)){0}INSERT INTO [4D3925E7-62C4-4A06-922B-2C6457DB2C5D](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,IDR,GeturlR,NameR)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.IDR,TDT.GeturlR,TDT.NameR FROM @TBL_4D3925E762C44A06922B2C6457DB2C5D TDT
							LEFT JOIN [4D3925E7-62C4-4A06-922B-2C6457DB2C5D] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,IDR,GeturlR,NameR";

                                     tempInsertQuery=@"INSERT INTO @TBL_4D3925E762C44A06922B2C6457DB2C5D(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,IDR,GeturlR,NameR)VALUES({0});";
                                     

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
                     
                                    case "385ECC80-9707-4403-A5A8-5C4DE0BBE223":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_385ECC8097074403A5A85C4DE0BBE223 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [ProjectJourneyDescription] VARCHAR(MAX)	, [SINO] INT	, [Date] DATETIME){0}INSERT INTO [385ECC80-9707-4403-A5A8-5C4DE0BBE223](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,ProjectJourneyDescription,SINO,Date)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.ProjectJourneyDescription,TDT.SINO,TDT.Date FROM @TBL_385ECC8097074403A5A85C4DE0BBE223 TDT
							LEFT JOIN [385ECC80-9707-4403-A5A8-5C4DE0BBE223] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,ProjectJourneyDescription,SINO,Date";

                                     tempInsertQuery=@"INSERT INTO @TBL_385ECC8097074403A5A85C4DE0BBE223(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,ProjectJourneyDescription,SINO,Date)VALUES({0});";
                                     

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
                     
                                    case "1BD06026-1AB3-47A6-BF57-934CCF70B816":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_1BD060261AB347A6BF57934CCF70B816 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [RDID] VARCHAR(MAX)	, [RDName] VARCHAR(MAX)	, [RDUpload] VARBINARY(MAX)){0}INSERT INTO [1BD06026-1AB3-47A6-BF57-934CCF70B816](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,RDID,RDName,RDUpload)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.RDID,TDT.RDName,TDT.RDUpload FROM @TBL_1BD060261AB347A6BF57934CCF70B816 TDT
							LEFT JOIN [1BD06026-1AB3-47A6-BF57-934CCF70B816] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,RDID,RDName,RDUpload";

                                     tempInsertQuery=@"INSERT INTO @TBL_1BD060261AB347A6BF57934CCF70B816(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,RDID,RDName,RDUpload)VALUES({0});";
                                     

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
                     
                                    case "A8711B81-85A3-41BC-8B9B-67F9DAAFFCD5":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_A8711B8185A341BC8B9B67F9DAAFFCD5 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [ExternalDepartment] VARCHAR(250)	, [FacultyType] VARCHAR(250)	, [Name1] VARCHAR(250)	, [EI_PhoneNumber] VARCHAR(MAX)	, [Email] VARCHAR(MAX)	, [CoPiID] VARCHAR(MAX)	, [DummyInstance] VARCHAR(MAX)	, [EI_FacultyName] VARCHAR(MAX)	, [EI_DesignationId] VARCHAR(MAX)	, [EmployeeBasicInfo] VARCHAR(MAX)	, [UserName] VARCHAR(MAX)	, [EI_Name] VARCHAR(MAX)	, [Dept] VARCHAR(MAX)	, [EI_Mail] VARCHAR(MAX)	, [EI_Designation] VARCHAR(MAX)	, [Role] VARCHAR(MAX)	, [Overhead] DECIMAL(18,2)	, [Name] VARCHAR(250)){0}INSERT INTO [A8711B81-85A3-41BC-8B9B-67F9DAAFFCD5](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,ExternalDepartment,FacultyType,Name1,EI_PhoneNumber,Email,CoPiID,DummyInstance,EI_FacultyName,EI_DesignationId,EmployeeBasicInfo,UserName,EI_Name,Dept,EI_Mail,EI_Designation,Role,Overhead,Name)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.ExternalDepartment,TDT.FacultyType,TDT.Name1,TDT.EI_PhoneNumber,TDT.Email,TDT.CoPiID,TDT.DummyInstance,TDT.EI_FacultyName,TDT.EI_DesignationId,TDT.EmployeeBasicInfo,TDT.UserName,TDT.EI_Name,TDT.Dept,TDT.EI_Mail,TDT.EI_Designation,TDT.Role,TDT.Overhead,TDT.Name FROM @TBL_A8711B8185A341BC8B9B67F9DAAFFCD5 TDT
							LEFT JOIN [A8711B81-85A3-41BC-8B9B-67F9DAAFFCD5] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,ExternalDepartment,FacultyType,Name1,EI_PhoneNumber,Email,CoPiID,DummyInstance,EI_FacultyName,EI_DesignationId,EmployeeBasicInfo,UserName,EI_Name,Dept,EI_Mail,EI_Designation,Role,Overhead,Name";

                                     tempInsertQuery=@"INSERT INTO @TBL_A8711B8185A341BC8B9B67F9DAAFFCD5(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,ExternalDepartment,FacultyType,Name1,EI_PhoneNumber,Email,CoPiID,DummyInstance,EI_FacultyName,EI_DesignationId,EmployeeBasicInfo,UserName,EI_Name,Dept,EI_Mail,EI_Designation,Role,Overhead,Name)VALUES({0});";
                                     

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
                     
                                    case "F881EC0D-6E67-48C0-89B4-792F4EF70410":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_F881EC0D6E6748C089B4792F4EF70410 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [AName] VARCHAR(MAX)	, [ARole] VARCHAR(MAX)	, [AAction] VARCHAR(MAX)	, [Status] VARCHAR(MAX)	, [ADate] DATETIME){0}INSERT INTO [F881EC0D-6E67-48C0-89B4-792F4EF70410](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,AName,ARole,AAction,Status,ADate)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.AName,TDT.ARole,TDT.AAction,TDT.Status,TDT.ADate FROM @TBL_F881EC0D6E6748C089B4792F4EF70410 TDT
							LEFT JOIN [F881EC0D-6E67-48C0-89B4-792F4EF70410] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,AName,ARole,AAction,Status,ADate";

                                     tempInsertQuery=@"INSERT INTO @TBL_F881EC0D6E6748C089B4792F4EF70410(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,AName,ARole,AAction,Status,ADate)VALUES({0});";
                                     

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
                     
                                    case "8BE3755C-1DAD-43F6-9580-0244610D89AF":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_8BE3755C1DAD43F695800244610D89AF AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [ROYXOReleaseDescription] VARCHAR(MAX)	, [EStatus] VARCHAR(MAX)	, [ROYXOReleaseAmount] INT	, [ROYXOSanctionedRelease] VARCHAR(250)	, [ROYXOReleaseDate] DATETIME){0}INSERT INTO [8BE3755C-1DAD-43F6-9580-0244610D89AF](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,ROYXOReleaseDescription,EStatus,ROYXOReleaseAmount,ROYXOSanctionedRelease,ROYXOReleaseDate)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.ROYXOReleaseDescription,TDT.EStatus,TDT.ROYXOReleaseAmount,TDT.ROYXOSanctionedRelease,TDT.ROYXOReleaseDate FROM @TBL_8BE3755C1DAD43F695800244610D89AF TDT
							LEFT JOIN [8BE3755C-1DAD-43F6-9580-0244610D89AF] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,ROYXOReleaseDescription,EStatus,ROYXOReleaseAmount,ROYXOSanctionedRelease,ROYXOReleaseDate";

                                     tempInsertQuery=@"INSERT INTO @TBL_8BE3755C1DAD43F695800244610D89AF(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,ROYXOReleaseDescription,EStatus,ROYXOReleaseAmount,ROYXOSanctionedRelease,ROYXOReleaseDate)VALUES({0});";
                                     

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
                     
                                    case "70051D3C-20CA-47D4-9917-B33DED7ACE9C":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_70051D3C20CA47D49917B33DED7ACE9C AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MP_HRAPercal] DECIMAL(18,2)	, [MP_TotalMonths] INT	, [MP_RatePerMonth] DECIMAL(18,2)	, [MP_HRAPer] INT	, [MP_No] INT	, [MP_SerialNo] INT	, [MP_Duration] INT	, [MP_ManpowerTotalCost] DECIMAL(18,2)	, [MP_TotalPerMonth] INT	, [MP_HRAperMonth] DECIMAL(18,2)	, [MP_Comment] VARCHAR(MAX)	, [MP_ProjectId] VARCHAR(MAX)	, [MP_ManpowerId] VARCHAR(MAX)	, [MP_Position] VARCHAR(250)){0}INSERT INTO [70051D3C-20CA-47D4-9917-B33DED7ACE9C](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MP_HRAPercal,MP_TotalMonths,MP_RatePerMonth,MP_HRAPer,MP_No,MP_SerialNo,MP_Duration,MP_ManpowerTotalCost,MP_TotalPerMonth,MP_HRAperMonth,MP_Comment,MP_ProjectId,MP_ManpowerId,MP_Position)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MP_HRAPercal,TDT.MP_TotalMonths,TDT.MP_RatePerMonth,TDT.MP_HRAPer,TDT.MP_No,TDT.MP_SerialNo,TDT.MP_Duration,TDT.MP_ManpowerTotalCost,TDT.MP_TotalPerMonth,TDT.MP_HRAperMonth,TDT.MP_Comment,TDT.MP_ProjectId,TDT.MP_ManpowerId,TDT.MP_Position FROM @TBL_70051D3C20CA47D49917B33DED7ACE9C TDT
							LEFT JOIN [70051D3C-20CA-47D4-9917-B33DED7ACE9C] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MP_HRAPercal,MP_TotalMonths,MP_RatePerMonth,MP_HRAPer,MP_No,MP_SerialNo,MP_Duration,MP_ManpowerTotalCost,MP_TotalPerMonth,MP_HRAperMonth,MP_Comment,MP_ProjectId,MP_ManpowerId,MP_Position";

                                     tempInsertQuery=@"INSERT INTO @TBL_70051D3C20CA47D49917B33DED7ACE9C(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MP_HRAPercal,MP_TotalMonths,MP_RatePerMonth,MP_HRAPer,MP_No,MP_SerialNo,MP_Duration,MP_ManpowerTotalCost,MP_TotalPerMonth,MP_HRAperMonth,MP_Comment,MP_ProjectId,MP_ManpowerId,MP_Position)VALUES({0});";
                                     

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
                     
                                    case "F6AFE0E4-D106-405F-A6D9-CC28F2196A48":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_F6AFE0E4D106405FA6D9CC28F2196A48 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [RProject] VARCHAR(MAX)	, [RAgencyName] VARCHAR(MAX)	, [RPrincipleInvestigator] VARCHAR(MAX)	, [RProjectDetailsID] VARCHAR(MAX)	, [RFinancialYear] VARCHAR(MAX)	, [RProjectCategory] VARCHAR(MAX)){0}INSERT INTO [F6AFE0E4-D106-405F-A6D9-CC28F2196A48](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,RProject,RAgencyName,RPrincipleInvestigator,RProjectDetailsID,RFinancialYear,RProjectCategory)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.RProject,TDT.RAgencyName,TDT.RPrincipleInvestigator,TDT.RProjectDetailsID,TDT.RFinancialYear,TDT.RProjectCategory FROM @TBL_F6AFE0E4D106405FA6D9CC28F2196A48 TDT
							LEFT JOIN [F6AFE0E4-D106-405F-A6D9-CC28F2196A48] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,RProject,RAgencyName,RPrincipleInvestigator,RProjectDetailsID,RFinancialYear,RProjectCategory";

                                     tempInsertQuery=@"INSERT INTO @TBL_F6AFE0E4D106405FA6D9CC28F2196A48(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,RProject,RAgencyName,RPrincipleInvestigator,RProjectDetailsID,RFinancialYear,RProjectCategory)VALUES({0});";
                                     

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
                     
                                    case "2E73640F-0DAD-4B0D-918D-2EADBCE4344C":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_2E73640F0DAD4B0D918D2EADBCE4344C AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [TotalAmount] INT	, [Slno] INT	, [EDescription] VARCHAR(MAX)	, [Category] VARCHAR(MAX)){0}INSERT INTO [2E73640F-0DAD-4B0D-918D-2EADBCE4344C](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,TotalAmount,Slno,EDescription,Category)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.TotalAmount,TDT.Slno,TDT.EDescription,TDT.Category FROM @TBL_2E73640F0DAD4B0D918D2EADBCE4344C TDT
							LEFT JOIN [2E73640F-0DAD-4B0D-918D-2EADBCE4344C] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,TotalAmount,Slno,EDescription,Category";

                                     tempInsertQuery=@"INSERT INTO @TBL_2E73640F0DAD4B0D918D2EADBCE4344C(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,TotalAmount,Slno,EDescription,Category)VALUES({0});";
                                     

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
                     
                                    case "3DCC9E43-EA6E-47B6-B9D6-316997A1A239":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_3DCC9E43EA6E47B6B9D6316997A1A239 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [ReceiptAmount] INT	, [ICheque] VARCHAR(MAX)	, [ReceiptNumber] VARCHAR(MAX)	, [IProjectNo] VARCHAR(MAX)	, [IDescription] VARCHAR(MAX)	, [IYear] VARCHAR(MAX)){0}INSERT INTO [3DCC9E43-EA6E-47B6-B9D6-316997A1A239](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,ReceiptAmount,ICheque,ReceiptNumber,IProjectNo,IDescription,IYear)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.ReceiptAmount,TDT.ICheque,TDT.ReceiptNumber,TDT.IProjectNo,TDT.IDescription,TDT.IYear FROM @TBL_3DCC9E43EA6E47B6B9D6316997A1A239 TDT
							LEFT JOIN [3DCC9E43-EA6E-47B6-B9D6-316997A1A239] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,ReceiptAmount,ICheque,ReceiptNumber,IProjectNo,IDescription,IYear";

                                     tempInsertQuery=@"INSERT INTO @TBL_3DCC9E43EA6E47B6B9D6316997A1A239(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,ReceiptAmount,ICheque,ReceiptNumber,IProjectNo,IDescription,IYear)VALUES({0});";
                                     

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
                     
                                    case "7CD25981-D914-448A-873A-2820C07FB607":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_7CD25981D914448A873A2820C07FB607 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [Docid] INT	, [TEMPDocid] INT	, [Document] VARCHAR(MAX)	, [UploadDocument] VARBINARY(MAX)){0}INSERT INTO [7CD25981-D914-448A-873A-2820C07FB607](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,Docid,TEMPDocid,Document,UploadDocument)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.Docid,TDT.TEMPDocid,TDT.Document,TDT.UploadDocument FROM @TBL_7CD25981D914448A873A2820C07FB607 TDT
							LEFT JOIN [7CD25981-D914-448A-873A-2820C07FB607] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,Docid,TEMPDocid,Document,UploadDocument";

                                     tempInsertQuery=@"INSERT INTO @TBL_7CD25981D914448A873A2820C07FB607(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,Docid,TEMPDocid,Document,UploadDocument)VALUES({0});";
                                     

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
                     

                                         case "C92F6C5D-F7CB-4E81-835C-3D655C7FCC52":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_C92F6C5DF7CB4E81835C3D655C7FCC52 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [RDComments] VARCHAR(MAX)	, [ProjectBudgetDetailsid] VARCHAR(MAX)	, [BudgetHead] VARCHAR(MAX)	, [commentss] VARCHAR(MAX)	, [TotalBudget] DECIMAL(18,2)	, [Year21] INT	, [IncrementId] INT	, [Year19] INT	, [RecurringValidation] INT	, [Year13] INT	, [Year18] INT	, [Year20] INT	, [Year11] DECIMAL(18,2)	, [Year14] INT	, [Year16] INT	, [Year15] INT	, [Year22] INT	, [Reappropriation] DECIMAL(18,2)	, [BudgetAmount] DECIMAL(18,2)	, [Year17] INT	, [Bid] INT	, [Year12] INT){0}INSERT INTO [C92F6C5D-F7CB-4E81-835C-3D655C7FCC52](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,RDComments,ProjectBudgetDetailsid,BudgetHead,commentss,TotalBudget,Year21,IncrementId,Year19,RecurringValidation,Year13,Year18,Year20,Year11,Year14,Year16,Year15,Year22,Reappropriation,BudgetAmount,Year17,Bid,Year12)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.RDComments,TDT.ProjectBudgetDetailsid,TDT.BudgetHead,TDT.commentss,TDT.TotalBudget,TDT.Year21,TDT.IncrementId,TDT.Year19,TDT.RecurringValidation,TDT.Year13,TDT.Year18,TDT.Year20,TDT.Year11,TDT.Year14,TDT.Year16,TDT.Year15,TDT.Year22,TDT.Reappropriation,TDT.BudgetAmount,TDT.Year17,TDT.Bid,TDT.Year12 FROM @TBL_C92F6C5DF7CB4E81835C3D655C7FCC52 TDT
							LEFT JOIN [C92F6C5D-F7CB-4E81-835C-3D655C7FCC52] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,RDComments,ProjectBudgetDetailsid,BudgetHead,commentss,TotalBudget,Year21,IncrementId,Year19,RecurringValidation,Year13,Year18,Year20,Year11,Year14,Year16,Year15,Year22,Reappropriation,BudgetAmount,Year17,Bid,Year12";

                            tempInsertQuery=@"INSERT INTO @TBL_C92F6C5DF7CB4E81835C3D655C7FCC52(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,RDComments,ProjectBudgetDetailsid,BudgetHead,commentss,TotalBudget,Year21,IncrementId,Year19,RecurringValidation,Year13,Year18,Year20,Year11,Year14,Year16,Year15,Year22,Reappropriation,BudgetAmount,Year17,Bid,Year12)VALUES({0});";

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

                                              case "1B307D9B-9E56-415F-8C11-BF109F7A2E30":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_1B307D9B9E56415F8C11BF109F7A2E30 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [NKLIEI_Facultytype] VARCHAR(MAX)	, [NKLIEI_Name] VARCHAR(MAX)	, [NKLIEI_FacultyName] VARCHAR(MAX)	, [NKLIEI_ProjectdetailsID] VARCHAR(MAX)	, [NKLIEI_Mail] VARCHAR(MAX)	, [NKLIEI_PhoneNumber] VARCHAR(MAX)	, [NKLICoPiID] VARCHAR(MAX)	, [NKLIEI_Designation] VARCHAR(MAX)){0}INSERT INTO [1B307D9B-9E56-415F-8C11-BF109F7A2E30](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,NKLIEI_Facultytype,NKLIEI_Name,NKLIEI_FacultyName,NKLIEI_ProjectdetailsID,NKLIEI_Mail,NKLIEI_PhoneNumber,NKLICoPiID,NKLIEI_Designation)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.NKLIEI_Facultytype,TDT.NKLIEI_Name,TDT.NKLIEI_FacultyName,TDT.NKLIEI_ProjectdetailsID,TDT.NKLIEI_Mail,TDT.NKLIEI_PhoneNumber,TDT.NKLICoPiID,TDT.NKLIEI_Designation FROM @TBL_1B307D9B9E56415F8C11BF109F7A2E30 TDT
							LEFT JOIN [1B307D9B-9E56-415F-8C11-BF109F7A2E30] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,NKLIEI_Facultytype,NKLIEI_Name,NKLIEI_FacultyName,NKLIEI_ProjectdetailsID,NKLIEI_Mail,NKLIEI_PhoneNumber,NKLICoPiID,NKLIEI_Designation";

                            tempInsertQuery=@"INSERT INTO @TBL_1B307D9B9E56415F8C11BF109F7A2E30(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,NKLIEI_Facultytype,NKLIEI_Name,NKLIEI_FacultyName,NKLIEI_ProjectdetailsID,NKLIEI_Mail,NKLIEI_PhoneNumber,NKLICoPiID,NKLIEI_Designation)VALUES({0});";

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

                                              case "71802A68-968A-4C2C-8AFE-32BA5B817B50":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_71802A68968A4C2C8AFE32BA5B817B50 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [EquipmentID] VARCHAR(MAX)	, [EquipmentName] VARCHAR(MAX)	, [EQEquipmentDescription] VARCHAR(MAX)	, [EQEquipmentRateinINR] DECIMAL(18,2)	, [EQEquipmentTotalCost] DECIMAL(18,2)	, [EQEquipmentQuantity] INT	, [EquipmentBudget] DECIMAL(18,2)	, [EQSerialNo] INT){0}INSERT INTO [71802A68-968A-4C2C-8AFE-32BA5B817B50](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,EquipmentID,EquipmentName,EQEquipmentDescription,EQEquipmentRateinINR,EQEquipmentTotalCost,EQEquipmentQuantity,EquipmentBudget,EQSerialNo)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.EquipmentID,TDT.EquipmentName,TDT.EQEquipmentDescription,TDT.EQEquipmentRateinINR,TDT.EQEquipmentTotalCost,TDT.EQEquipmentQuantity,TDT.EquipmentBudget,TDT.EQSerialNo FROM @TBL_71802A68968A4C2C8AFE32BA5B817B50 TDT
							LEFT JOIN [71802A68-968A-4C2C-8AFE-32BA5B817B50] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,EquipmentID,EquipmentName,EQEquipmentDescription,EQEquipmentRateinINR,EQEquipmentTotalCost,EQEquipmentQuantity,EquipmentBudget,EQSerialNo";

                            tempInsertQuery=@"INSERT INTO @TBL_71802A68968A4C2C8AFE32BA5B817B50(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,EquipmentID,EquipmentName,EQEquipmentDescription,EQEquipmentRateinINR,EQEquipmentTotalCost,EQEquipmentQuantity,EquipmentBudget,EQSerialNo)VALUES({0});";

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

                                              case "4D3925E7-62C4-4A06-922B-2C6457DB2C5D":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_4D3925E762C44A06922B2C6457DB2C5D AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [IDR] VARCHAR(MAX)	, [GeturlR] VARCHAR(MAX)	, [NameR] VARCHAR(MAX)){0}INSERT INTO [4D3925E7-62C4-4A06-922B-2C6457DB2C5D](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,IDR,GeturlR,NameR)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.IDR,TDT.GeturlR,TDT.NameR FROM @TBL_4D3925E762C44A06922B2C6457DB2C5D TDT
							LEFT JOIN [4D3925E7-62C4-4A06-922B-2C6457DB2C5D] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,IDR,GeturlR,NameR";

                            tempInsertQuery=@"INSERT INTO @TBL_4D3925E762C44A06922B2C6457DB2C5D(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,IDR,GeturlR,NameR)VALUES({0});";

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

                                              case "385ECC80-9707-4403-A5A8-5C4DE0BBE223":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_385ECC8097074403A5A85C4DE0BBE223 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [ProjectJourneyDescription] VARCHAR(MAX)	, [SINO] INT	, [Date] DATETIME){0}INSERT INTO [385ECC80-9707-4403-A5A8-5C4DE0BBE223](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,ProjectJourneyDescription,SINO,Date)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.ProjectJourneyDescription,TDT.SINO,TDT.Date FROM @TBL_385ECC8097074403A5A85C4DE0BBE223 TDT
							LEFT JOIN [385ECC80-9707-4403-A5A8-5C4DE0BBE223] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,ProjectJourneyDescription,SINO,Date";

                            tempInsertQuery=@"INSERT INTO @TBL_385ECC8097074403A5A85C4DE0BBE223(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,ProjectJourneyDescription,SINO,Date)VALUES({0});";

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

                                              case "1BD06026-1AB3-47A6-BF57-934CCF70B816":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_1BD060261AB347A6BF57934CCF70B816 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [RDID] VARCHAR(MAX)	, [RDName] VARCHAR(MAX)	, [RDUpload] VARBINARY(MAX)){0}INSERT INTO [1BD06026-1AB3-47A6-BF57-934CCF70B816](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,RDID,RDName,RDUpload)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.RDID,TDT.RDName,TDT.RDUpload FROM @TBL_1BD060261AB347A6BF57934CCF70B816 TDT
							LEFT JOIN [1BD06026-1AB3-47A6-BF57-934CCF70B816] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,RDID,RDName,RDUpload";

                            tempInsertQuery=@"INSERT INTO @TBL_1BD060261AB347A6BF57934CCF70B816(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,RDID,RDName,RDUpload)VALUES({0});";

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

                                              case "A8711B81-85A3-41BC-8B9B-67F9DAAFFCD5":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_A8711B8185A341BC8B9B67F9DAAFFCD5 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [ExternalDepartment] VARCHAR(250)	, [FacultyType] VARCHAR(250)	, [Name1] VARCHAR(250)	, [EI_PhoneNumber] VARCHAR(MAX)	, [Email] VARCHAR(MAX)	, [CoPiID] VARCHAR(MAX)	, [DummyInstance] VARCHAR(MAX)	, [EI_FacultyName] VARCHAR(MAX)	, [EI_DesignationId] VARCHAR(MAX)	, [EmployeeBasicInfo] VARCHAR(MAX)	, [UserName] VARCHAR(MAX)	, [EI_Name] VARCHAR(MAX)	, [Dept] VARCHAR(MAX)	, [EI_Mail] VARCHAR(MAX)	, [EI_Designation] VARCHAR(MAX)	, [Role] VARCHAR(MAX)	, [Overhead] DECIMAL(18,2)	, [Name] VARCHAR(250)){0}INSERT INTO [A8711B81-85A3-41BC-8B9B-67F9DAAFFCD5](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,ExternalDepartment,FacultyType,Name1,EI_PhoneNumber,Email,CoPiID,DummyInstance,EI_FacultyName,EI_DesignationId,EmployeeBasicInfo,UserName,EI_Name,Dept,EI_Mail,EI_Designation,Role,Overhead,Name)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.ExternalDepartment,TDT.FacultyType,TDT.Name1,TDT.EI_PhoneNumber,TDT.Email,TDT.CoPiID,TDT.DummyInstance,TDT.EI_FacultyName,TDT.EI_DesignationId,TDT.EmployeeBasicInfo,TDT.UserName,TDT.EI_Name,TDT.Dept,TDT.EI_Mail,TDT.EI_Designation,TDT.Role,TDT.Overhead,TDT.Name FROM @TBL_A8711B8185A341BC8B9B67F9DAAFFCD5 TDT
							LEFT JOIN [A8711B81-85A3-41BC-8B9B-67F9DAAFFCD5] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,ExternalDepartment,FacultyType,Name1,EI_PhoneNumber,Email,CoPiID,DummyInstance,EI_FacultyName,EI_DesignationId,EmployeeBasicInfo,UserName,EI_Name,Dept,EI_Mail,EI_Designation,Role,Overhead,Name";

                            tempInsertQuery=@"INSERT INTO @TBL_A8711B8185A341BC8B9B67F9DAAFFCD5(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,ExternalDepartment,FacultyType,Name1,EI_PhoneNumber,Email,CoPiID,DummyInstance,EI_FacultyName,EI_DesignationId,EmployeeBasicInfo,UserName,EI_Name,Dept,EI_Mail,EI_Designation,Role,Overhead,Name)VALUES({0});";

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

                                              case "F881EC0D-6E67-48C0-89B4-792F4EF70410":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_F881EC0D6E6748C089B4792F4EF70410 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [AName] VARCHAR(MAX)	, [ARole] VARCHAR(MAX)	, [AAction] VARCHAR(MAX)	, [Status] VARCHAR(MAX)	, [ADate] DATETIME){0}INSERT INTO [F881EC0D-6E67-48C0-89B4-792F4EF70410](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,AName,ARole,AAction,Status,ADate)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.AName,TDT.ARole,TDT.AAction,TDT.Status,TDT.ADate FROM @TBL_F881EC0D6E6748C089B4792F4EF70410 TDT
							LEFT JOIN [F881EC0D-6E67-48C0-89B4-792F4EF70410] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,AName,ARole,AAction,Status,ADate";

                            tempInsertQuery=@"INSERT INTO @TBL_F881EC0D6E6748C089B4792F4EF70410(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,AName,ARole,AAction,Status,ADate)VALUES({0});";

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

                                              case "8BE3755C-1DAD-43F6-9580-0244610D89AF":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_8BE3755C1DAD43F695800244610D89AF AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [ROYXOReleaseDescription] VARCHAR(MAX)	, [EStatus] VARCHAR(MAX)	, [ROYXOReleaseAmount] INT	, [ROYXOSanctionedRelease] VARCHAR(250)	, [ROYXOReleaseDate] DATETIME){0}INSERT INTO [8BE3755C-1DAD-43F6-9580-0244610D89AF](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,ROYXOReleaseDescription,EStatus,ROYXOReleaseAmount,ROYXOSanctionedRelease,ROYXOReleaseDate)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.ROYXOReleaseDescription,TDT.EStatus,TDT.ROYXOReleaseAmount,TDT.ROYXOSanctionedRelease,TDT.ROYXOReleaseDate FROM @TBL_8BE3755C1DAD43F695800244610D89AF TDT
							LEFT JOIN [8BE3755C-1DAD-43F6-9580-0244610D89AF] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,ROYXOReleaseDescription,EStatus,ROYXOReleaseAmount,ROYXOSanctionedRelease,ROYXOReleaseDate";

                            tempInsertQuery=@"INSERT INTO @TBL_8BE3755C1DAD43F695800244610D89AF(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,ROYXOReleaseDescription,EStatus,ROYXOReleaseAmount,ROYXOSanctionedRelease,ROYXOReleaseDate)VALUES({0});";

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

                                              case "70051D3C-20CA-47D4-9917-B33DED7ACE9C":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_70051D3C20CA47D49917B33DED7ACE9C AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MP_HRAPercal] DECIMAL(18,2)	, [MP_TotalMonths] INT	, [MP_RatePerMonth] DECIMAL(18,2)	, [MP_HRAPer] INT	, [MP_No] INT	, [MP_SerialNo] INT	, [MP_Duration] INT	, [MP_ManpowerTotalCost] DECIMAL(18,2)	, [MP_TotalPerMonth] INT	, [MP_HRAperMonth] DECIMAL(18,2)	, [MP_Comment] VARCHAR(MAX)	, [MP_ProjectId] VARCHAR(MAX)	, [MP_ManpowerId] VARCHAR(MAX)	, [MP_Position] VARCHAR(250)){0}INSERT INTO [70051D3C-20CA-47D4-9917-B33DED7ACE9C](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MP_HRAPercal,MP_TotalMonths,MP_RatePerMonth,MP_HRAPer,MP_No,MP_SerialNo,MP_Duration,MP_ManpowerTotalCost,MP_TotalPerMonth,MP_HRAperMonth,MP_Comment,MP_ProjectId,MP_ManpowerId,MP_Position)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MP_HRAPercal,TDT.MP_TotalMonths,TDT.MP_RatePerMonth,TDT.MP_HRAPer,TDT.MP_No,TDT.MP_SerialNo,TDT.MP_Duration,TDT.MP_ManpowerTotalCost,TDT.MP_TotalPerMonth,TDT.MP_HRAperMonth,TDT.MP_Comment,TDT.MP_ProjectId,TDT.MP_ManpowerId,TDT.MP_Position FROM @TBL_70051D3C20CA47D49917B33DED7ACE9C TDT
							LEFT JOIN [70051D3C-20CA-47D4-9917-B33DED7ACE9C] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MP_HRAPercal,MP_TotalMonths,MP_RatePerMonth,MP_HRAPer,MP_No,MP_SerialNo,MP_Duration,MP_ManpowerTotalCost,MP_TotalPerMonth,MP_HRAperMonth,MP_Comment,MP_ProjectId,MP_ManpowerId,MP_Position";

                            tempInsertQuery=@"INSERT INTO @TBL_70051D3C20CA47D49917B33DED7ACE9C(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MP_HRAPercal,MP_TotalMonths,MP_RatePerMonth,MP_HRAPer,MP_No,MP_SerialNo,MP_Duration,MP_ManpowerTotalCost,MP_TotalPerMonth,MP_HRAperMonth,MP_Comment,MP_ProjectId,MP_ManpowerId,MP_Position)VALUES({0});";

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

                                              case "F6AFE0E4-D106-405F-A6D9-CC28F2196A48":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_F6AFE0E4D106405FA6D9CC28F2196A48 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [RProject] VARCHAR(MAX)	, [RAgencyName] VARCHAR(MAX)	, [RPrincipleInvestigator] VARCHAR(MAX)	, [RProjectDetailsID] VARCHAR(MAX)	, [RFinancialYear] VARCHAR(MAX)	, [RProjectCategory] VARCHAR(MAX)){0}INSERT INTO [F6AFE0E4-D106-405F-A6D9-CC28F2196A48](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,RProject,RAgencyName,RPrincipleInvestigator,RProjectDetailsID,RFinancialYear,RProjectCategory)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.RProject,TDT.RAgencyName,TDT.RPrincipleInvestigator,TDT.RProjectDetailsID,TDT.RFinancialYear,TDT.RProjectCategory FROM @TBL_F6AFE0E4D106405FA6D9CC28F2196A48 TDT
							LEFT JOIN [F6AFE0E4-D106-405F-A6D9-CC28F2196A48] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,RProject,RAgencyName,RPrincipleInvestigator,RProjectDetailsID,RFinancialYear,RProjectCategory";

                            tempInsertQuery=@"INSERT INTO @TBL_F6AFE0E4D106405FA6D9CC28F2196A48(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,RProject,RAgencyName,RPrincipleInvestigator,RProjectDetailsID,RFinancialYear,RProjectCategory)VALUES({0});";

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

                                              case "2E73640F-0DAD-4B0D-918D-2EADBCE4344C":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_2E73640F0DAD4B0D918D2EADBCE4344C AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [TotalAmount] INT	, [Slno] INT	, [EDescription] VARCHAR(MAX)	, [Category] VARCHAR(MAX)){0}INSERT INTO [2E73640F-0DAD-4B0D-918D-2EADBCE4344C](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,TotalAmount,Slno,EDescription,Category)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.TotalAmount,TDT.Slno,TDT.EDescription,TDT.Category FROM @TBL_2E73640F0DAD4B0D918D2EADBCE4344C TDT
							LEFT JOIN [2E73640F-0DAD-4B0D-918D-2EADBCE4344C] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,TotalAmount,Slno,EDescription,Category";

                            tempInsertQuery=@"INSERT INTO @TBL_2E73640F0DAD4B0D918D2EADBCE4344C(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,TotalAmount,Slno,EDescription,Category)VALUES({0});";

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

                                              case "3DCC9E43-EA6E-47B6-B9D6-316997A1A239":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_3DCC9E43EA6E47B6B9D6316997A1A239 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [ReceiptAmount] INT	, [ICheque] VARCHAR(MAX)	, [ReceiptNumber] VARCHAR(MAX)	, [IProjectNo] VARCHAR(MAX)	, [IDescription] VARCHAR(MAX)	, [IYear] VARCHAR(MAX)){0}INSERT INTO [3DCC9E43-EA6E-47B6-B9D6-316997A1A239](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,ReceiptAmount,ICheque,ReceiptNumber,IProjectNo,IDescription,IYear)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.ReceiptAmount,TDT.ICheque,TDT.ReceiptNumber,TDT.IProjectNo,TDT.IDescription,TDT.IYear FROM @TBL_3DCC9E43EA6E47B6B9D6316997A1A239 TDT
							LEFT JOIN [3DCC9E43-EA6E-47B6-B9D6-316997A1A239] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,ReceiptAmount,ICheque,ReceiptNumber,IProjectNo,IDescription,IYear";

                            tempInsertQuery=@"INSERT INTO @TBL_3DCC9E43EA6E47B6B9D6316997A1A239(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,ReceiptAmount,ICheque,ReceiptNumber,IProjectNo,IDescription,IYear)VALUES({0});";

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

                                              case "7CD25981-D914-448A-873A-2820C07FB607":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_7CD25981D914448A873A2820C07FB607 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [Docid] INT	, [TEMPDocid] INT	, [Document] VARCHAR(MAX)	, [UploadDocument] VARBINARY(MAX)){0}INSERT INTO [7CD25981-D914-448A-873A-2820C07FB607](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,Docid,TEMPDocid,Document,UploadDocument)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.Docid,TDT.TEMPDocid,TDT.Document,TDT.UploadDocument FROM @TBL_7CD25981D914448A873A2820C07FB607 TDT
							LEFT JOIN [7CD25981-D914-448A-873A-2820C07FB607] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,Docid,TEMPDocid,Document,UploadDocument";

                            tempInsertQuery=@"INSERT INTO @TBL_7CD25981D914448A873A2820C07FB607(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,Docid,TEMPDocid,Document,UploadDocument)VALUES({0});";

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
public class ISpaceD0B6EBB910A44D43A76EF39441A41EF6 : VirtualForm
{
IISpace iSpace = new ISpace();
AcDataISpaceD0B6EBB910A44D43A76EF39441A41EF6 acdataIspaceD0B6EBB910A44D43A76EF39441A41EF6=new AcDataISpaceD0B6EBB910A44D43A76EF39441A41EF6();
private void SubscribeFormEvents_root(ref Dictionary<string, ServiceElementData> ISpace)
{
try
{
base.WriteDebugInfo(@"Root-OnAfterFormLoad");
ISpace["SanctionNumber"].Man=true;ISpace["IntAmount"].Man=true;ISpace["ProjectName1"].Enbl="false";ISpace["TypeOfProject"].Man=true;ISpace["ProjectProposal"].Man=true;ISpace["PrincipleInvestigator"].Man=false;ISpace["PrincipleInvestigator"].Enbl="false";ISpace["FundingAcencyName"].Man=true;ISpace["FinancialYear1"].Man=false;ISpace["FinancialYear1"].Enbl="false";ISpace["IntExpense"].Man=true;ISpace["Designation"].Enbl="false";ISpace["Currency"].Man=true;ISpace["Department"].Man=false;ISpace["Department"].Enbl="false";ISpace["ProjectBudget"].Man=false;ISpace["Sector"].Man=true;ISpace["ProjectCategory"].Man=true;ISpace["ProjectCategory1"].Man=false;ISpace["ProjectCategory1"].Enbl="false";ISpace["Duration"].Man=true;ISpace["BudgetDetails"].Man=true;ISpace["ProjectName"].Man=false;ISpace["MonthYear"].Man=true;ISpace["SchemeType"].Visible="true";ISpace["SchemeType"].Man=false;ISpace["SchemeType"].Enbl="true";ISpace["SanctionedRelease"].Man=false;ISpace["SanctionDate"].Man=true;ISpace["Add1"].Enbl="true";ISpace["FinancialYear"].Man=true;
base.WriteDebugInfo(@"ISpace[""SanctionNumber""].Man=true;ISpace[""IntAmount""].Man=true;ISpace[""ProjectName1""].Enbl=""false"";ISpace[""TypeOfProject""].Man=true;ISpace[""ProjectProposal""].Man=true;ISpace[""PrincipleInvestigator""].Man=false;ISpace[""PrincipleInvestigator""].Enbl=""false"";ISpace[""FundingAcencyName""].Man=true;ISpace[""FinancialYear1""].Man=false;ISpace[""FinancialYear1""].Enbl=""false"";ISpace[""IntExpense""].Man=true;ISpace[""Designation""].Enbl=""false"";ISpace[""Currency""].Man=true;ISpace[""Department""].Man=false;ISpace[""Department""].Enbl=""false"";ISpace[""ProjectBudget""].Man=false;ISpace[""Sector""].Man=true;ISpace[""ProjectCategory""].Man=true;ISpace[""ProjectCategory1""].Man=false;ISpace[""ProjectCategory1""].Enbl=""false"";ISpace[""Duration""].Man=true;ISpace[""BudgetDetails""].Man=true;ISpace[""ProjectName""].Man=false;ISpace[""MonthYear""].Man=true;ISpace[""SchemeType""].Visible=""true"";ISpace[""SchemeType""].Man=false;ISpace[""SchemeType""].Enbl=""true"";ISpace[""SanctionedRelease""].Man=false;ISpace[""SanctionDate""].Man=true;ISpace[""Add1""].Enbl=""true"";ISpace[""FinancialYear""].Man=true;");
if((ISpace["ProjectProposal"].Value == null))
{
base.WriteDebugInfo(@"if((ISpace[""ProjectProposal""].Value == null))");
ISpace["Message"].Value=@"Please select the Project Proposal ID.";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please select the Project Proposal ID."";");
return;
base.WriteDebugInfo(@"return;");
}
if((ISpace["Overhead"].Value == null))
{
base.WriteDebugInfo(@"if((ISpace[""Overhead""].Value == null))");
ISpace["Message"].Value=@"Please Enter the overhead value.";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please Enter the overhead value."";");
return;
base.WriteDebugInfo(@"return;");
}
ISpace["BudgetHead"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""BudgetHead""].Enbl=""false"";");
ISpace["IfExternalIns"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""IfExternalIns""].Enbl=""false"";");
ISpace["Reappropriation"].Visible="false";
base.WriteDebugInfo(@"ISpace[""Reappropriation""].Visible=""false"";");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["FormVersionId"].Value=="EB102E80-C3DC-4EB9-8511-B1018E342530")
{
ISpace["UI_ProjectJourney"].Visible="false";
}if(ISpace["FormVersionId"].Value=="EB102E80-C3DC-4EB9-8511-B1018E342530")
{
ISpace["UI_ApprovalStatus1"].Visible="false";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""EB102E80-C3DC-4EB9-8511-B1018E342530"")
{
ISpace[""UI_ProjectJourney""].Visible=""false"";
}if(ISpace[""FormVersionId""].Value==""EB102E80-C3DC-4EB9-8511-B1018E342530"")
{
ISpace[""UI_ApprovalStatus1""].Visible=""false"";
}");
}
ISpace["FundReceiptAdd"].Visible="false";ISpace["Add1"].Visible="false";
base.WriteDebugInfo(@"ISpace[""FundReceiptAdd""].Visible=""false"";ISpace[""Add1""].Visible=""false"";");
ISpace["BudgetAdd"].Visible="false";
base.WriteDebugInfo(@"ISpace[""BudgetAdd""].Visible=""false"";");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["Add"].Visible="false";ISpace["Add2"].Visible="false";
base.WriteDebugInfo(@"ISpace[""Add""].Visible=""false"";ISpace[""Add2""].Visible=""false"";");
}
base.WriteDebugInfo(@"EXEC GetEmployeeATOMDetails '@@gv_UserId'");

var querySourceEDFA4E4D24A346DB9CEB0D911F7A7788 =GetQueryExpressionDataSource("EDFA4E4D-24A3-46DB-9CEB-0D911F7A7788");
Dictionary<short,object> resultEDFA4E4D24A346DB9CEB0D911F7A7788=iSpace.ExecuteQuery(querySourceEDFA4E4D24A346DB9CEB0D911F7A7788,@"EXEC GetEmployeeATOMDetails '" + ISpace["gv_userid"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceEDFA4E4D24A346DB9CEB0D911F7A7788 =GetQueryExpressionDataSource(""EDFA4E4D-24A3-46DB-9CEB-0D911F7A7788"");Dictionary<short,object> resultEDFA4E4D24A346DB9CEB0D911F7A7788=iSpace.ExecuteQuery(querySourceEDFA4E4D24A346DB9CEB0D911F7A7788,@""EXEC GetEmployeeATOMDetails '"" + ISpace[""gv_userid""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultEDFA4E4D24A346DB9CEB0D911F7A7788!=null) && (resultEDFA4E4D24A346DB9CEB0D911F7A7788.Count!=0))
{
if(resultEDFA4E4D24A346DB9CEB0D911F7A7788.ContainsKey(19))
ISpace["PrincipleInvestigator"].Value = resultEDFA4E4D24A346DB9CEB0D911F7A7788[19];
if(resultEDFA4E4D24A346DB9CEB0D911F7A7788.ContainsKey(0))
ISpace["EmpCode"].Value = resultEDFA4E4D24A346DB9CEB0D911F7A7788[0];
if(resultEDFA4E4D24A346DB9CEB0D911F7A7788.ContainsKey(2))
ISpace["Designation"].Value = resultEDFA4E4D24A346DB9CEB0D911F7A7788[2];
if(resultEDFA4E4D24A346DB9CEB0D911F7A7788.ContainsKey(4))
ISpace["EmpDepartment"].Value = resultEDFA4E4D24A346DB9CEB0D911F7A7788[4];
if(resultEDFA4E4D24A346DB9CEB0D911F7A7788.ContainsKey(3))
ISpace["Department"].Value = resultEDFA4E4D24A346DB9CEB0D911F7A7788[3];
if(resultEDFA4E4D24A346DB9CEB0D911F7A7788.ContainsKey(20))
ISpace["EmpDeptCode"].Value = resultEDFA4E4D24A346DB9CEB0D911F7A7788[20];
if(resultEDFA4E4D24A346DB9CEB0D911F7A7788.ContainsKey(8))
ISpace["EmpEmployeeBasicId"].Value = resultEDFA4E4D24A346DB9CEB0D911F7A7788[8];
if(resultEDFA4E4D24A346DB9CEB0D911F7A7788.ContainsKey(21))
ISpace["EmpDesignationID"].Value = resultEDFA4E4D24A346DB9CEB0D911F7A7788[21];
if(resultEDFA4E4D24A346DB9CEB0D911F7A7788.ContainsKey(8))
ISpace["EmployeeBasicInfo"].Value = resultEDFA4E4D24A346DB9CEB0D911F7A7788[8];
}
else{
ISpace["PrincipleInvestigator"].Value = null;ISpace["EmpCode"].Value = null;ISpace["Designation"].Value = null;ISpace["EmpDepartment"].Value = null;ISpace["Department"].Value = null;ISpace["EmpDeptCode"].Value = null;ISpace["EmpEmployeeBasicId"].Value = null;ISpace["EmpDesignationID"].Value = null;ISpace["EmployeeBasicInfo"].Value = null;
}
ISpace["ActivityMapid"].Value=ISpace["gv_activitymapid"].Value;
base.WriteDebugInfo(@"ISpace[""ActivityMapid""].Value=ISpace[""gv_activitymapid""].Value;");
ISpace["PackageprocessmapID"].Value=ISpace["gv_processmapid"].Value;
base.WriteDebugInfo(@"ISpace[""PackageprocessmapID""].Value=ISpace[""gv_processmapid""].Value;");
ISpace["PrincipleInvestigator"].Enbl="false";ISpace["Department"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""PrincipleInvestigator""].Enbl=""false"";ISpace[""Department""].Enbl=""false"";");
ISpace["EndDate"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""EndDate""].Enbl=""false"";");
if(ISpace["FormVersionId"].Value=="EB102E80-C3DC-4EB9-8511-B1018E342530")
{
ISpace["UI_DuplicatePanel"].Visible="false";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""EB102E80-C3DC-4EB9-8511-B1018E342530"")
{
ISpace[""UI_DuplicatePanel""].Visible=""false"";
}");
if(ISpace["FormVersionId"].Value=="EB102E80-C3DC-4EB9-8511-B1018E342530")
{
ISpace["UI_Tab"].Visible="false";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""EB102E80-C3DC-4EB9-8511-B1018E342530"")
{
ISpace[""UI_Tab""].Visible=""false"";
}");
if(ISpace["FormVersionId"].Value=="EB102E80-C3DC-4EB9-8511-B1018E342530")
{
ISpace["UI_Tab"].Visible="false";
}if(ISpace["FormVersionId"].Value=="EB102E80-C3DC-4EB9-8511-B1018E342530")
{
ISpace["UI_FirstRow"].Visible="true";
}if(ISpace["FormVersionId"].Value=="EB102E80-C3DC-4EB9-8511-B1018E342530")
{
ISpace["UI_SecondRow"].Visible="false";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""EB102E80-C3DC-4EB9-8511-B1018E342530"")
{
ISpace[""UI_Tab""].Visible=""false"";
}if(ISpace[""FormVersionId""].Value==""EB102E80-C3DC-4EB9-8511-B1018E342530"")
{
ISpace[""UI_FirstRow""].Visible=""true"";
}if(ISpace[""FormVersionId""].Value==""EB102E80-C3DC-4EB9-8511-B1018E342530"")
{
ISpace[""UI_SecondRow""].Visible=""false"";
}");
if(ISpace["FormVersionId"].Value=="EB102E80-C3DC-4EB9-8511-B1018E342530")
{
ISpace["UI_Row"].Visible="false";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""EB102E80-C3DC-4EB9-8511-B1018E342530"")
{
ISpace[""UI_Row""].Visible=""false"";
}");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["IntAmount"].Visible="false";ISpace["IntExpense"].Visible="false";ISpace["Currency"].Visible="false";
base.WriteDebugInfo(@"ISpace[""IntAmount""].Visible=""false"";ISpace[""IntExpense""].Visible=""false"";ISpace[""Currency""].Visible=""false"";");
ISpace["EndDate"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""EndDate""].Enbl=""false"";");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"exec GetDateDifferenceInYears 9,'','','','#ID1'");

var querySource858ABA6B4E8F437C974B182BF16A305F =GetQueryExpressionDataSource("858ABA6B-4E8F-437C-974B-182BF16A305F");
Dictionary<short,object> result858ABA6B4E8F437C974B182BF16A305F=iSpace.ExecuteQuery(querySource858ABA6B4E8F437C974B182BF16A305F,@"exec GetDateDifferenceInYears 9,'','','','" + ISpace["ID1"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource858ABA6B4E8F437C974B182BF16A305F =GetQueryExpressionDataSource(""858ABA6B-4E8F-437C-974B-182BF16A305F"");Dictionary<short,object> result858ABA6B4E8F437C974B182BF16A305F=iSpace.ExecuteQuery(querySource858ABA6B4E8F437C974B182BF16A305F,@""exec GetDateDifferenceInYears 9,'','','','"" + ISpace[""ID1""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result858ABA6B4E8F437C974B182BF16A305F!=null) && (result858ABA6B4E8F437C974B182BF16A305F.Count!=0))
{
if(result858ABA6B4E8F437C974B182BF16A305F.ContainsKey(14))
ISpace["EndDate"].Value = result858ABA6B4E8F437C974B182BF16A305F[14];
if(result858ABA6B4E8F437C974B182BF16A305F.ContainsKey(13))
ISpace["StartDate"].Value = result858ABA6B4E8F437C974B182BF16A305F[13];
if(result858ABA6B4E8F437C974B182BF16A305F.ContainsKey(16))
ISpace["SanctionDate"].Value = result858ABA6B4E8F437C974B182BF16A305F[16];
if(result858ABA6B4E8F437C974B182BF16A305F.ContainsKey(3))
ISpace["FinancialYear"].Value = result858ABA6B4E8F437C974B182BF16A305F[3];
if(result858ABA6B4E8F437C974B182BF16A305F.ContainsKey(2))
ISpace["ProjectCategory"].Value = result858ABA6B4E8F437C974B182BF16A305F[2];
if(result858ABA6B4E8F437C974B182BF16A305F.ContainsKey(29))
ISpace["Sector"].Value = result858ABA6B4E8F437C974B182BF16A305F[29];
if(result858ABA6B4E8F437C974B182BF16A305F.ContainsKey(11))
ISpace["MonthYear"].Value = result858ABA6B4E8F437C974B182BF16A305F[11];
if(result858ABA6B4E8F437C974B182BF16A305F.ContainsKey(7))
ISpace["SchemeType"].Value = result858ABA6B4E8F437C974B182BF16A305F[7];
if(result858ABA6B4E8F437C974B182BF16A305F.ContainsKey(36))
ISpace["FundReceiptMode"].Value = result858ABA6B4E8F437C974B182BF16A305F[36];
if(result858ABA6B4E8F437C974B182BF16A305F.ContainsKey(20))
ISpace["Currency"].Value = result858ABA6B4E8F437C974B182BF16A305F[20];
if(result858ABA6B4E8F437C974B182BF16A305F.ContainsKey(15))
ISpace["FundingAcencyName"].Value = result858ABA6B4E8F437C974B182BF16A305F[15];
if(result858ABA6B4E8F437C974B182BF16A305F.ContainsKey(19))
ISpace["TypeOfProject"].Value = result858ABA6B4E8F437C974B182BF16A305F[19];
if(result858ABA6B4E8F437C974B182BF16A305F.ContainsKey(32))
ISpace["ProjectProposal"].Value = result858ABA6B4E8F437C974B182BF16A305F[32];
if(result858ABA6B4E8F437C974B182BF16A305F.ContainsKey(39))
ISpace["IFEquipment"].Value = result858ABA6B4E8F437C974B182BF16A305F[39];
if(result858ABA6B4E8F437C974B182BF16A305F.ContainsKey(37))
ISpace["ManPowerRequired"].Value = result858ABA6B4E8F437C974B182BF16A305F[37];
if(result858ABA6B4E8F437C974B182BF16A305F.ContainsKey(34))
ISpace["IfExternalIns"].Value = result858ABA6B4E8F437C974B182BF16A305F[34];
if(result858ABA6B4E8F437C974B182BF16A305F.ContainsKey(21))
ISpace["IntExpense"].Value = result858ABA6B4E8F437C974B182BF16A305F[21];
if(result858ABA6B4E8F437C974B182BF16A305F.ContainsKey(42))
ISpace["RecurringAmount"].Value = result858ABA6B4E8F437C974B182BF16A305F[42];
if(result858ABA6B4E8F437C974B182BF16A305F.ContainsKey(33))
ISpace["EndorsementAmount"].Value = result858ABA6B4E8F437C974B182BF16A305F[33];
if(result858ABA6B4E8F437C974B182BF16A305F.ContainsKey(30))
ISpace["Overheads"].Value = result858ABA6B4E8F437C974B182BF16A305F[30];
if(result858ABA6B4E8F437C974B182BF16A305F.ContainsKey(44))
ISpace["OverallBudgetTotal"].Value = result858ABA6B4E8F437C974B182BF16A305F[44];
if(result858ABA6B4E8F437C974B182BF16A305F.ContainsKey(22))
ISpace["IntAmount"].Value = result858ABA6B4E8F437C974B182BF16A305F[22];
if(result858ABA6B4E8F437C974B182BF16A305F.ContainsKey(43))
ISpace["NonRecurringAmount"].Value = result858ABA6B4E8F437C974B182BF16A305F[43];
if(result858ABA6B4E8F437C974B182BF16A305F.ContainsKey(9))
ISpace["ProjectBudget"].Value = result858ABA6B4E8F437C974B182BF16A305F[9];
if(result858ABA6B4E8F437C974B182BF16A305F.ContainsKey(28))
ISpace["DocumentComments"].Value = result858ABA6B4E8F437C974B182BF16A305F[28];
if(result858ABA6B4E8F437C974B182BF16A305F.ContainsKey(26))
ISpace["DMValidation"].Value = result858ABA6B4E8F437C974B182BF16A305F[26];
if(result858ABA6B4E8F437C974B182BF16A305F.ContainsKey(17))
ISpace["SanctionNumber"].Value = result858ABA6B4E8F437C974B182BF16A305F[17];
if(result858ABA6B4E8F437C974B182BF16A305F.ContainsKey(18))
ISpace["ProjectRefNo"].Value = result858ABA6B4E8F437C974B182BF16A305F[18];
if(result858ABA6B4E8F437C974B182BF16A305F.ContainsKey(19))
ISpace["DummyProject"].Value = result858ABA6B4E8F437C974B182BF16A305F[19];
if(result858ABA6B4E8F437C974B182BF16A305F.ContainsKey(12))
ISpace["Duration"].Value = result858ABA6B4E8F437C974B182BF16A305F[12];
if(result858ABA6B4E8F437C974B182BF16A305F.ContainsKey(6))
ISpace["ProjectName"].Value = result858ABA6B4E8F437C974B182BF16A305F[6];
if(result858ABA6B4E8F437C974B182BF16A305F.ContainsKey(35))
ISpace["ProjectStatus"].Value = result858ABA6B4E8F437C974B182BF16A305F[35];
if(result858ABA6B4E8F437C974B182BF16A305F.ContainsKey(1))
ISpace["ProjectCode"].Value = result858ABA6B4E8F437C974B182BF16A305F[1];
}
else{
ISpace["EndDate"].Value = null;ISpace["StartDate"].Value = null;ISpace["SanctionDate"].Value = null;ISpace["FinancialYear"].Value = null;ISpace["ProjectCategory"].Value = null;ISpace["Sector"].Value = null;ISpace["MonthYear"].Value = null;ISpace["SchemeType"].Value = null;ISpace["FundReceiptMode"].Value = null;ISpace["Currency"].Value = null;ISpace["FundingAcencyName"].Value = null;ISpace["TypeOfProject"].Value = null;ISpace["ProjectProposal"].Value = null;ISpace["IFEquipment"].Value = null;ISpace["ManPowerRequired"].Value = null;ISpace["IfExternalIns"].Value = null;ISpace["IntExpense"].Value = null;ISpace["RecurringAmount"].Value = null;ISpace["EndorsementAmount"].Value = null;ISpace["Overheads"].Value = null;ISpace["OverallBudgetTotal"].Value = null;ISpace["IntAmount"].Value = null;ISpace["NonRecurringAmount"].Value = null;ISpace["ProjectBudget"].Value = null;ISpace["DocumentComments"].Value = null;ISpace["DMValidation"].Value = null;ISpace["SanctionNumber"].Value = null;ISpace["ProjectRefNo"].Value = null;ISpace["DummyProject"].Value = null;ISpace["Duration"].Value = null;ISpace["ProjectName"].Value = null;ISpace["ProjectStatus"].Value = null;ISpace["ProjectCode"].Value = null;
}
}
if(ISpace["DummyProject"].Value=="450")
{
base.WriteDebugInfo(@"if(ISpace[""DummyProject""].Value==""450"")");
ISpace["IntAmount"].Visible="true";ISpace["IntExpense"].Visible="true";ISpace["Currency"].Visible="true";
base.WriteDebugInfo(@"ISpace[""IntAmount""].Visible=""true"";ISpace[""IntExpense""].Visible=""true"";ISpace[""Currency""].Visible=""true"";");
}
if(ISpace["DummyProject"].Value=="449")
{
base.WriteDebugInfo(@"if(ISpace[""DummyProject""].Value==""449"")");
ISpace["IntAmount"].Visible="false";ISpace["IntExpense"].Visible="false";ISpace["Currency"].Visible="false";
base.WriteDebugInfo(@"ISpace[""IntAmount""].Visible=""false"";ISpace[""IntExpense""].Visible=""false"";ISpace[""Currency""].Visible=""false"";");
}
if(ISpace["ProcessID"].Value!=""||ISpace["ID1"].Value!="")
{
base.WriteDebugInfo(@"if(ISpace[""ProcessID""].Value!=""""||ISpace[""ID1""].Value!="""")");
ISpace["ProjectProposal"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""ProjectProposal""].Enbl=""false"";");
}
if(ISpace["ID1"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""ID1""].Value=="""")");
ISpace["ID1"].Value=ISpace["gv_instanceid"].Value;
base.WriteDebugInfo(@"ISpace[""ID1""].Value=ISpace[""gv_instanceid""].Value;");
ISpace["ProjectProposal"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""ProjectProposal""].Enbl=""true"";");
ISpace["IntAmount"].Visible="false";ISpace["IntExpense"].Visible="false";ISpace["Currency"].Visible="false";
base.WriteDebugInfo(@"ISpace[""IntAmount""].Visible=""false"";ISpace[""IntExpense""].Visible=""false"";ISpace[""Currency""].Visible=""false"";");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySource7470299E490B4DA1B8F5E586A05CF3F7 =GetQueryExpressionDataSource("7470299E-490B-4DA1-B8F5-E586A05CF3F7");

DataTable result7470299E490B4DA1B8F5E586A05CF3F7=iSpace.SetGridDataSource(querySource7470299E490B4DA1B8F5E586A05CF3F7, _objectFactory.GetGridRPP("BudgetDetails"),@"EXEC [GetProjectDetailCombo] 1,'" + ISpace["ID1"].Value + @"'");

iSpace.InsertGridBindDetails("BudgetDetails","11",querySource7470299E490B4DA1B8F5E586A05CF3F7,"EXEC [GetProjectDetailCombo] 1,'" + ISpace["ID1"].Value + @"'",_objectFactory.GetGridRPP("BudgetDetails"));

base.WriteDebugInfo(@"var querySource7470299E490B4DA1B8F5E586A05CF3F7 =GetQueryExpressionDataSource(""7470299E-490B-4DA1-B8F5-E586A05CF3F7"");DataTable result7470299E490B4DA1B8F5E586A05CF3F7=iSpace.SetGridDataSource(querySource7470299E490B4DA1B8F5E586A05CF3F7, _objectFactory.GetGridRPP(""BudgetDetails""),@""EXEC [GetProjectDetailCombo] 1,'"" + ISpace[""ID1""].Value + @""'"");iSpace.InsertGridBindDetails(""BudgetDetails"",""11"",querySource7470299E490B4DA1B8F5E586A05CF3F7,""EXEC [GetProjectDetailCombo] 1,'"" + ISpace[""ID1""].Value + @""'"",_objectFactory.GetGridRPP(""BudgetDetails""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> resultD9CC73AE5CF345A791209864A85C89BE=acdataIspaceD0B6EBB910A44D43A76EF39441A41EF6.GetQueryExpressionBindings("D9CC73AE-5CF3-45A7-9120-9864A85C89BE");
iSpace.SetGridData(result7470299E490B4DA1B8F5E586A05CF3F7,resultD9CC73AE5CF345A791209864A85C89BE,"BudgetDetails",ref ISpace);
iSpace.UpdateGridBindDetails("BudgetDetails",resultD9CC73AE5CF345A791209864A85C89BE);
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC [GetProjectDetailCombo] 1,'#ID1'");

var querySource00355DC3AB594492B9B902B50A5D90C0 =GetQueryExpressionDataSource("00355DC3-AB59-4492-B9B9-02B50A5D90C0");
Dictionary<short,object> result00355DC3AB594492B9B902B50A5D90C0=iSpace.ExecuteQuery(querySource00355DC3AB594492B9B902B50A5D90C0,@"EXEC [GetProjectDetailCombo] 1,'" + ISpace["ID1"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource00355DC3AB594492B9B902B50A5D90C0 =GetQueryExpressionDataSource(""00355DC3-AB59-4492-B9B9-02B50A5D90C0"");Dictionary<short,object> result00355DC3AB594492B9B902B50A5D90C0=iSpace.ExecuteQuery(querySource00355DC3AB594492B9B902B50A5D90C0,@""EXEC [GetProjectDetailCombo] 1,'"" + ISpace[""ID1""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result00355DC3AB594492B9B902B50A5D90C0!=null) && (result00355DC3AB594492B9B902B50A5D90C0.Count!=0))
{
if(result00355DC3AB594492B9B902B50A5D90C0.ContainsKey(17))
ISpace["OverallBudgetTotal"].Value = result00355DC3AB594492B9B902B50A5D90C0[17];
}
else{
ISpace["OverallBudgetTotal"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySource81DC99CCC22A43C0BB5D79B98A0E5694 =GetQueryExpressionDataSource("81DC99CC-C22A-43C0-BB5D-79B98A0E5694");

DataTable result81DC99CCC22A43C0BB5D79B98A0E5694=iSpace.SetGridDataSource(querySource81DC99CCC22A43C0BB5D79B98A0E5694, _objectFactory.GetGridRPP("ExternalInstitute"),@"EXEC GetCoPiDetailsBasedOnProject 2,'" + ISpace["ProjectProposal"].Value + @"'");

iSpace.InsertGridBindDetails("ExternalInstitute","11",querySource81DC99CCC22A43C0BB5D79B98A0E5694,"EXEC GetCoPiDetailsBasedOnProject 2,'" + ISpace["ProjectProposal"].Value + @"'",_objectFactory.GetGridRPP("ExternalInstitute"));

base.WriteDebugInfo(@"var querySource81DC99CCC22A43C0BB5D79B98A0E5694 =GetQueryExpressionDataSource(""81DC99CC-C22A-43C0-BB5D-79B98A0E5694"");DataTable result81DC99CCC22A43C0BB5D79B98A0E5694=iSpace.SetGridDataSource(querySource81DC99CCC22A43C0BB5D79B98A0E5694, _objectFactory.GetGridRPP(""ExternalInstitute""),@""EXEC GetCoPiDetailsBasedOnProject 2,'"" + ISpace[""ProjectProposal""].Value + @""'"");iSpace.InsertGridBindDetails(""ExternalInstitute"",""11"",querySource81DC99CCC22A43C0BB5D79B98A0E5694,""EXEC GetCoPiDetailsBasedOnProject 2,'"" + ISpace[""ProjectProposal""].Value + @""'"",_objectFactory.GetGridRPP(""ExternalInstitute""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result0A77E47949AD420E94EF65936C5187C7=acdataIspaceD0B6EBB910A44D43A76EF39441A41EF6.GetQueryExpressionBindings("0A77E479-49AD-420E-94EF-65936C5187C7");
iSpace.SetGridData(result81DC99CCC22A43C0BB5D79B98A0E5694,result0A77E47949AD420E94EF65936C5187C7,"ExternalInstitute",ref ISpace);
iSpace.UpdateGridBindDetails("ExternalInstitute",result0A77E47949AD420E94EF65936C5187C7);
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySource932BDBDF7F2C47CEA185EC1F9BCD25E0 =GetQueryExpressionDataSource("932BDBDF-7F2C-47CE-A185-EC1F9BCD25E0");

DataTable result932BDBDF7F2C47CEA185EC1F9BCD25E0=iSpace.SetGridDataSource(querySource932BDBDF7F2C47CEA185EC1F9BCD25E0, _objectFactory.GetGridRPP("CoPiDetails"),@"EXEC GetCoPiDetailsBasedOnProject 1,'" + ISpace["ProjectProposal"].Value + @"'");

iSpace.InsertGridBindDetails("CoPiDetails","11",querySource932BDBDF7F2C47CEA185EC1F9BCD25E0,"EXEC GetCoPiDetailsBasedOnProject 1,'" + ISpace["ProjectProposal"].Value + @"'",_objectFactory.GetGridRPP("CoPiDetails"));

base.WriteDebugInfo(@"var querySource932BDBDF7F2C47CEA185EC1F9BCD25E0 =GetQueryExpressionDataSource(""932BDBDF-7F2C-47CE-A185-EC1F9BCD25E0"");DataTable result932BDBDF7F2C47CEA185EC1F9BCD25E0=iSpace.SetGridDataSource(querySource932BDBDF7F2C47CEA185EC1F9BCD25E0, _objectFactory.GetGridRPP(""CoPiDetails""),@""EXEC GetCoPiDetailsBasedOnProject 1,'"" + ISpace[""ProjectProposal""].Value + @""'"");iSpace.InsertGridBindDetails(""CoPiDetails"",""11"",querySource932BDBDF7F2C47CEA185EC1F9BCD25E0,""EXEC GetCoPiDetailsBasedOnProject 1,'"" + ISpace[""ProjectProposal""].Value + @""'"",_objectFactory.GetGridRPP(""CoPiDetails""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result60083B68496B43CC86D50B59F2B10067=acdataIspaceD0B6EBB910A44D43A76EF39441A41EF6.GetQueryExpressionBindings("60083B68-496B-43CC-86D5-0B59F2B10067");
iSpace.SetGridData(result932BDBDF7F2C47CEA185EC1F9BCD25E0,result60083B68496B43CC86D50B59F2B10067,"CoPiDetails",ref ISpace);
iSpace.UpdateGridBindDetails("CoPiDetails",result60083B68496B43CC86D50B59F2B10067);
}
if(ISpace["ID1"].Value!="")
{
base.WriteDebugInfo(@"if(ISpace[""ID1""].Value!="""")");

var querySource7BED2578928E4BE6954B5BC6430BA133 =GetQueryExpressionDataSource("7BED2578-928E-4BE6-954B-5BC6430BA133");

DataTable result7BED2578928E4BE6954B5BC6430BA133=iSpace.SetGridDataSource(querySource7BED2578928E4BE6954B5BC6430BA133, _objectFactory.GetGridRPP("DocumentDetails"),@"EXEC GetProjectDocument '" + ISpace["ID1"].Value + @"'");

iSpace.InsertGridBindDetails("DocumentDetails","11",querySource7BED2578928E4BE6954B5BC6430BA133,"EXEC GetProjectDocument '" + ISpace["ID1"].Value + @"'",_objectFactory.GetGridRPP("DocumentDetails"));

base.WriteDebugInfo(@"var querySource7BED2578928E4BE6954B5BC6430BA133 =GetQueryExpressionDataSource(""7BED2578-928E-4BE6-954B-5BC6430BA133"");DataTable result7BED2578928E4BE6954B5BC6430BA133=iSpace.SetGridDataSource(querySource7BED2578928E4BE6954B5BC6430BA133, _objectFactory.GetGridRPP(""DocumentDetails""),@""EXEC GetProjectDocument '"" + ISpace[""ID1""].Value + @""'"");iSpace.InsertGridBindDetails(""DocumentDetails"",""11"",querySource7BED2578928E4BE6954B5BC6430BA133,""EXEC GetProjectDocument '"" + ISpace[""ID1""].Value + @""'"",_objectFactory.GetGridRPP(""DocumentDetails""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> resultE59048C62310416E983E247A556B3045=acdataIspaceD0B6EBB910A44D43A76EF39441A41EF6.GetQueryExpressionBindings("E59048C6-2310-416E-983E-247A556B3045");
iSpace.SetGridData(result7BED2578928E4BE6954B5BC6430BA133,resultE59048C62310416E983E247A556B3045,"DocumentDetails",ref ISpace);
iSpace.UpdateGridBindDetails("DocumentDetails",resultE59048C62310416E983E247A556B3045);
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["FundReceiptMode"].Value=="2"||ISpace["FundReceiptMode"].Value=="3")
{
base.WriteDebugInfo(@"if(ISpace[""FundReceiptMode""].Value==""2""||ISpace[""FundReceiptMode""].Value==""3"")");
ISpace["SchemeType"].Man=true;ISpace["SchemeType"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""SchemeType""].Man=true;ISpace[""SchemeType""].Enbl=""true"";");
}
ISpace["ProjectBudget"].Man=true;
base.WriteDebugInfo(@"ISpace[""ProjectBudget""].Man=true;");
}
if(ISpace["ProjectRefNo"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""ProjectRefNo""].Value=="""")");
base.WriteDebugInfo(@"EXEC GenerateProjectCode '#EmpCode','#EmpDeptCode'");

var querySource109E996CEF4B435CBA0083A3578BC91C =GetQueryExpressionDataSource("109E996C-EF4B-435C-BA00-83A3578BC91C");
Dictionary<short,object> result109E996CEF4B435CBA0083A3578BC91C=iSpace.ExecuteQuery(querySource109E996CEF4B435CBA0083A3578BC91C,@"EXEC GenerateProjectCode '" + ISpace["EmpCode"].Value + @"','" + ISpace["EmpDeptCode"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource109E996CEF4B435CBA0083A3578BC91C =GetQueryExpressionDataSource(""109E996C-EF4B-435C-BA00-83A3578BC91C"");Dictionary<short,object> result109E996CEF4B435CBA0083A3578BC91C=iSpace.ExecuteQuery(querySource109E996CEF4B435CBA0083A3578BC91C,@""EXEC GenerateProjectCode '"" + ISpace[""EmpCode""].Value + @""','"" + ISpace[""EmpDeptCode""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result109E996CEF4B435CBA0083A3578BC91C!=null) && (result109E996CEF4B435CBA0083A3578BC91C.Count!=0))
{
if(result109E996CEF4B435CBA0083A3578BC91C.ContainsKey(0))
ISpace["ProjectRefNo"].Value = result109E996CEF4B435CBA0083A3578BC91C[0];
}
else{
ISpace["ProjectRefNo"].Value = null;
}
}
ISpace["ProjectProposal"].rElemData=iSpace.Reload(ISpace["ProjectProposal"].Value,@"EXEC [GetProjectproposalDetails] 1,'" + ISpace["ID1"].Value + @"','" + ISpace["EmpEmployeeBasicId"].Value + @"'","40BDEB14-07CC-4150-8A52-9B088A428E2D");
base.WriteDebugInfo(@"ISpace[""ProjectProposal""].rElemData=iSpace.Reload(ISpace[""ProjectProposal""].Value,@""EXEC [GetProjectproposalDetails] 1,'"" + ISpace[""ID1""].Value + @""','"" + ISpace[""EmpEmployeeBasicId""].Value + @""'"",""40BDEB14-07CC-4150-8A52-9B088A428E2D"");");
if(ISpace["ProcessID"].Value!="")
{
base.WriteDebugInfo(@"if(ISpace[""ProcessID""].Value!="""")");
ISpace["BSave"].Visible="false";
base.WriteDebugInfo(@"ISpace[""BSave""].Visible=""false"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["BSave"].Visible="true";
base.WriteDebugInfo(@"ISpace[""BSave""].Visible=""true"";");
}
if(ISpace["ManPowerRequired"].Value==true)
{
base.WriteDebugInfo(@"if(ISpace[""ManPowerRequired""].Value==true)");
ISpace["ManPowerDetails"].Visible="true";
base.WriteDebugInfo(@"ISpace[""ManPowerDetails""].Visible=""true"";");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySourceB1B67B4A1810429BB2EA1E4E403EF164 =GetQueryExpressionDataSource("B1B67B4A-1810-429B-B2EA-1E4E403EF164");

DataTable resultB1B67B4A1810429BB2EA1E4E403EF164=iSpace.SetGridDataSource(querySourceB1B67B4A1810429BB2EA1E4E403EF164, _objectFactory.GetGridRPP("ManPowerDetails"),@"EXEC [GetProjectDetailCombo] 13,'" + ISpace["ID1"].Value + @"'");

iSpace.InsertGridBindDetails("ManPowerDetails","11",querySourceB1B67B4A1810429BB2EA1E4E403EF164,"EXEC [GetProjectDetailCombo] 13,'" + ISpace["ID1"].Value + @"'",_objectFactory.GetGridRPP("ManPowerDetails"));

base.WriteDebugInfo(@"var querySourceB1B67B4A1810429BB2EA1E4E403EF164 =GetQueryExpressionDataSource(""B1B67B4A-1810-429B-B2EA-1E4E403EF164"");DataTable resultB1B67B4A1810429BB2EA1E4E403EF164=iSpace.SetGridDataSource(querySourceB1B67B4A1810429BB2EA1E4E403EF164, _objectFactory.GetGridRPP(""ManPowerDetails""),@""EXEC [GetProjectDetailCombo] 13,'"" + ISpace[""ID1""].Value + @""'"");iSpace.InsertGridBindDetails(""ManPowerDetails"",""11"",querySourceB1B67B4A1810429BB2EA1E4E403EF164,""EXEC [GetProjectDetailCombo] 13,'"" + ISpace[""ID1""].Value + @""'"",_objectFactory.GetGridRPP(""ManPowerDetails""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> resultC77CBF47D3B544EEAF6391DA2A0F89A5=acdataIspaceD0B6EBB910A44D43A76EF39441A41EF6.GetQueryExpressionBindings("C77CBF47-D3B5-44EE-AF63-91DA2A0F89A5");
iSpace.SetGridData(resultB1B67B4A1810429BB2EA1E4E403EF164,resultC77CBF47D3B544EEAF6391DA2A0F89A5,"ManPowerDetails",ref ISpace);
iSpace.UpdateGridBindDetails("ManPowerDetails",resultC77CBF47D3B544EEAF6391DA2A0F89A5);
base.WriteDebugInfo(@"EXEC [GetProjectDetailCombo] 13,'#ID1'");

var querySourceBE406FDA7399493AAD0D40B5976591BD =GetQueryExpressionDataSource("BE406FDA-7399-493A-AD0D-40B5976591BD");
Dictionary<short,object> resultBE406FDA7399493AAD0D40B5976591BD=iSpace.ExecuteQuery(querySourceBE406FDA7399493AAD0D40B5976591BD,@"EXEC [GetProjectDetailCombo] 13,'" + ISpace["ID1"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceBE406FDA7399493AAD0D40B5976591BD =GetQueryExpressionDataSource(""BE406FDA-7399-493A-AD0D-40B5976591BD"");Dictionary<short,object> resultBE406FDA7399493AAD0D40B5976591BD=iSpace.ExecuteQuery(querySourceBE406FDA7399493AAD0D40B5976591BD,@""EXEC [GetProjectDetailCombo] 13,'"" + ISpace[""ID1""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultBE406FDA7399493AAD0D40B5976591BD!=null) && (resultBE406FDA7399493AAD0D40B5976591BD.Count!=0))
{
if(resultBE406FDA7399493AAD0D40B5976591BD.ContainsKey(12))
ISpace["ManpowerTotalCost"].Value = resultBE406FDA7399493AAD0D40B5976591BD[12];
}
else{
ISpace["ManpowerTotalCost"].Value = null;
}
}
else
{
base.WriteDebugInfo(@"else");
ISpace["ManPowerDetails"].Visible="false";
base.WriteDebugInfo(@"ISpace[""ManPowerDetails""].Visible=""false"";");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySource91DBFA58C7F64EE3B996CB80B3DB89DA =GetQueryExpressionDataSource("91DBFA58-C7F6-4EE3-B996-CB80B3DB89DA");

DataTable result91DBFA58C7F64EE3B996CB80B3DB89DA=iSpace.SetGridDataSource(querySource91DBFA58C7F64EE3B996CB80B3DB89DA, _objectFactory.GetGridRPP("EquipmentDetails"),@"exec GetDateDifferenceInYears 31,'','','','" + ISpace["ID1"].Value + @"'");

iSpace.InsertGridBindDetails("EquipmentDetails","11",querySource91DBFA58C7F64EE3B996CB80B3DB89DA,"exec GetDateDifferenceInYears 31,'','','','" + ISpace["ID1"].Value + @"'",_objectFactory.GetGridRPP("EquipmentDetails"));

base.WriteDebugInfo(@"var querySource91DBFA58C7F64EE3B996CB80B3DB89DA =GetQueryExpressionDataSource(""91DBFA58-C7F6-4EE3-B996-CB80B3DB89DA"");DataTable result91DBFA58C7F64EE3B996CB80B3DB89DA=iSpace.SetGridDataSource(querySource91DBFA58C7F64EE3B996CB80B3DB89DA, _objectFactory.GetGridRPP(""EquipmentDetails""),@""exec GetDateDifferenceInYears 31,'','','','"" + ISpace[""ID1""].Value + @""'"");iSpace.InsertGridBindDetails(""EquipmentDetails"",""11"",querySource91DBFA58C7F64EE3B996CB80B3DB89DA,""exec GetDateDifferenceInYears 31,'','','','"" + ISpace[""ID1""].Value + @""'"",_objectFactory.GetGridRPP(""EquipmentDetails""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result2CBC92A2065C4EB9B516DD746385C81B=acdataIspaceD0B6EBB910A44D43A76EF39441A41EF6.GetQueryExpressionBindings("2CBC92A2-065C-4EB9-B516-DD746385C81B");
iSpace.SetGridData(result91DBFA58C7F64EE3B996CB80B3DB89DA,result2CBC92A2065C4EB9B516DD746385C81B,"EquipmentDetails",ref ISpace);
iSpace.UpdateGridBindDetails("EquipmentDetails",result2CBC92A2065C4EB9B516DD746385C81B);
base.WriteDebugInfo(@"exec GetDateDifferenceInYears 31,'','','','#ID1'");

var querySource5996D6F1CAB849FDA40F68A8B580D8D5 =GetQueryExpressionDataSource("5996D6F1-CAB8-49FD-A40F-68A8B580D8D5");
Dictionary<short,object> result5996D6F1CAB849FDA40F68A8B580D8D5=iSpace.ExecuteQuery(querySource5996D6F1CAB849FDA40F68A8B580D8D5,@"exec GetDateDifferenceInYears 31,'','','','" + ISpace["ID1"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource5996D6F1CAB849FDA40F68A8B580D8D5 =GetQueryExpressionDataSource(""5996D6F1-CAB8-49FD-A40F-68A8B580D8D5"");Dictionary<short,object> result5996D6F1CAB849FDA40F68A8B580D8D5=iSpace.ExecuteQuery(querySource5996D6F1CAB849FDA40F68A8B580D8D5,@""exec GetDateDifferenceInYears 31,'','','','"" + ISpace[""ID1""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result5996D6F1CAB849FDA40F68A8B580D8D5!=null) && (result5996D6F1CAB849FDA40F68A8B580D8D5.Count!=0))
{
if(result5996D6F1CAB849FDA40F68A8B580D8D5.ContainsKey(9))
ISpace["EquipmentTotalCost"].Value = result5996D6F1CAB849FDA40F68A8B580D8D5[9];
}
else{
ISpace["EquipmentTotalCost"].Value = null;
}
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySourceB18506D49C134173B34F85F7A1DF7BA0 =GetQueryExpressionDataSource("B18506D4-9C13-4173-B34F-85F7A1DF7BA0");

DataTable resultB18506D49C134173B34F85F7A1DF7BA0=iSpace.SetGridDataSource(querySourceB18506D49C134173B34F85F7A1DF7BA0, _objectFactory.GetGridRPP("RDDocumentGrid"),@"EXEC [GetRandDDetailsLoad] 1,'" + ISpace["ID1"].Value + @"'");

iSpace.InsertGridBindDetails("RDDocumentGrid","11",querySourceB18506D49C134173B34F85F7A1DF7BA0,"EXEC [GetRandDDetailsLoad] 1,'" + ISpace["ID1"].Value + @"'",_objectFactory.GetGridRPP("RDDocumentGrid"));

base.WriteDebugInfo(@"var querySourceB18506D49C134173B34F85F7A1DF7BA0 =GetQueryExpressionDataSource(""B18506D4-9C13-4173-B34F-85F7A1DF7BA0"");DataTable resultB18506D49C134173B34F85F7A1DF7BA0=iSpace.SetGridDataSource(querySourceB18506D49C134173B34F85F7A1DF7BA0, _objectFactory.GetGridRPP(""RDDocumentGrid""),@""EXEC [GetRandDDetailsLoad] 1,'"" + ISpace[""ID1""].Value + @""'"");iSpace.InsertGridBindDetails(""RDDocumentGrid"",""11"",querySourceB18506D49C134173B34F85F7A1DF7BA0,""EXEC [GetRandDDetailsLoad] 1,'"" + ISpace[""ID1""].Value + @""'"",_objectFactory.GetGridRPP(""RDDocumentGrid""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result58F56CDF92BA4AFCA02513E676182234=acdataIspaceD0B6EBB910A44D43A76EF39441A41EF6.GetQueryExpressionBindings("58F56CDF-92BA-4AFC-A025-13E676182234");
iSpace.SetGridData(resultB18506D49C134173B34F85F7A1DF7BA0,result58F56CDF92BA4AFCA02513E676182234,"RDDocumentGrid",ref ISpace);
iSpace.UpdateGridBindDetails("RDDocumentGrid",result58F56CDF92BA4AFCA02513E676182234);
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySource233CFB397AD74A45AC65B56FCE66F176 =GetQueryExpressionDataSource("233CFB39-7AD7-4A45-AC65-B56FCE66F176");

DataTable result233CFB397AD74A45AC65B56FCE66F176=iSpace.SetGridDataSource(querySource233CFB397AD74A45AC65B56FCE66F176, _objectFactory.GetGridRPP("RDDocumentGrid"),@"EXEC GetRDProjectDocument '" + ISpace["ID1"].Value + @"'");

iSpace.InsertGridBindDetails("RDDocumentGrid","11",querySource233CFB397AD74A45AC65B56FCE66F176,"EXEC GetRDProjectDocument '" + ISpace["ID1"].Value + @"'",_objectFactory.GetGridRPP("RDDocumentGrid"));

base.WriteDebugInfo(@"var querySource233CFB397AD74A45AC65B56FCE66F176 =GetQueryExpressionDataSource(""233CFB39-7AD7-4A45-AC65-B56FCE66F176"");DataTable result233CFB397AD74A45AC65B56FCE66F176=iSpace.SetGridDataSource(querySource233CFB397AD74A45AC65B56FCE66F176, _objectFactory.GetGridRPP(""RDDocumentGrid""),@""EXEC GetRDProjectDocument '"" + ISpace[""ID1""].Value + @""'"");iSpace.InsertGridBindDetails(""RDDocumentGrid"",""11"",querySource233CFB397AD74A45AC65B56FCE66F176,""EXEC GetRDProjectDocument '"" + ISpace[""ID1""].Value + @""'"",_objectFactory.GetGridRPP(""RDDocumentGrid""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result1C8EBE3F26E74988A4B3BF7ECE102252=acdataIspaceD0B6EBB910A44D43A76EF39441A41EF6.GetQueryExpressionBindings("1C8EBE3F-26E7-4988-A4B3-BF7ECE102252");
iSpace.SetGridData(result233CFB397AD74A45AC65B56FCE66F176,result1C8EBE3F26E74988A4B3BF7ECE102252,"RDDocumentGrid",ref ISpace);
iSpace.UpdateGridBindDetails("RDDocumentGrid",result1C8EBE3F26E74988A4B3BF7ECE102252);
}
if(ISpace["ProjectStatus"].Value=="8")
{
base.WriteDebugInfo(@"if(ISpace[""ProjectStatus""].Value==""8"")");
ISpace["BSave"].Visible="false";
base.WriteDebugInfo(@"ISpace[""BSave""].Visible=""false"";");
}
if(ISpace["ActiveEdit"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""ActiveEdit""].Value==1)");
ISpace["TempInstanceID"].Value=Guid.NewGuid().ToString();
base.WriteDebugInfo(@"ISpace[""TempInstanceID""].Value=Guid.NewGuid().ToString();");
ISpace["BSave"].Visible="false";
base.WriteDebugInfo(@"ISpace[""BSave""].Visible=""false"";");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["FinancialYear"].Value="18";
base.WriteDebugInfo(@"ISpace[""FinancialYear""].Value=""18"";");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
}
if(ISpace["FormVersionId"].Value=="EB102E80-C3DC-4EB9-8511-B1018E342530")
{
ISpace["UI_ProjectJourney"].Visible="false";ISpace["UI_ProjectJourney"].Enbl="false";
}if(ISpace["FormVersionId"].Value=="EB102E80-C3DC-4EB9-8511-B1018E342530")
{
ISpace["UI_ApprovalStatus1"].Visible="false";ISpace["UI_ApprovalStatus1"].Enbl="false";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""EB102E80-C3DC-4EB9-8511-B1018E342530"")
{
ISpace[""UI_ProjectJourney""].Visible=""false"";ISpace[""UI_ProjectJourney""].Enbl=""false"";
}if(ISpace[""FormVersionId""].Value==""EB102E80-C3DC-4EB9-8511-B1018E342530"")
{
ISpace[""UI_ApprovalStatus1""].Visible=""false"";ISpace[""UI_ApprovalStatus1""].Enbl=""false"";
}");
ISpace["Document"].Man=true;ISpace["DocumentDetails"].Man=true;ISpace["BudgetAmount"].Man=true;ISpace["BudgetDetails"].Man=true;
base.WriteDebugInfo(@"ISpace[""Document""].Man=true;ISpace[""DocumentDetails""].Man=true;ISpace[""BudgetAmount""].Man=true;ISpace[""BudgetDetails""].Man=true;");
ISpace["RecurringAmount"].Value=0;
base.WriteDebugInfo(@"ISpace[""RecurringAmount""].Value=0;");
ISpace["NonRecurringAmount"].Value=0;
base.WriteDebugInfo(@"ISpace[""NonRecurringAmount""].Value=0;");
object BudgetAmount=iSpace.Sum("[C92F6C5D-F7CB-4E81-835C-3D655C7FCC52]","BudgetAmount","",ISpace["gv_instanceid"].Value);
ISpace["OverallBudgetTotal"].Value=Convert.ChangeType(BudgetAmount, BudgetAmount.GetType());;
base.WriteDebugInfo(@"object BudgetAmount=iSpace.Sum(""[C92F6C5D-F7CB-4E81-835C-3D655C7FCC52]"",""BudgetAmount"","""",ISpace[""gv_instanceid""].Value);
ISpace[""OverallBudgetTotal""].Value=Convert.ChangeType(BudgetAmount, BudgetAmount.GetType());;");
if(1==2)
{
base.WriteDebugInfo(@"if(1==2)");
base.WriteDebugInfo(@"#BudgetDetails[Rows]");
iSpace.GetLoopExpressionData("BudgetDetails",ref ISpace);

foreach(var gridChild in ISpace["BudgetDetails"].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 


if(
ISpace["RecurringValidation"].Value==518)
{
base.WriteDebugInfo(@"
if(
ISpace[""RecurringValidation""].Value==518)");
object BudgetAmount=iSpace.Sum("[C92F6C5D-F7CB-4E81-835C-3D655C7FCC52]","BudgetAmount","",ISpace["gv_instanceid"].Value);
ISpace["RecurringAmount"].Value=Convert.ChangeType(BudgetAmount, BudgetAmount.GetType());;
base.WriteDebugInfo(@"object BudgetAmount=iSpace.Sum(""[C92F6C5D-F7CB-4E81-835C-3D655C7FCC52]"",""BudgetAmount"","""",ISpace[""gv_instanceid""].Value);
ISpace[""RecurringAmount""].Value=Convert.ChangeType(BudgetAmount, BudgetAmount.GetType());;");
}
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("BudgetDetails","C92F6C5D-F7CB-4E81-835C-3D655C7FCC52",_objectFactory.GetGridRPP("BudgetDetails"),_elementBase.GetGridLoopQuery("C92F6C5D-F7CB-4E81-835C-3D655C7FCC52","BudgetDetails",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""BudgetDetails"",ref ISpace);

foreach(var gridChild in ISpace[""BudgetDetails""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
}
base.WriteDebugInfo(@"#BudgetDetails[Rows]");
iSpace.GetLoopExpressionData("BudgetDetails",ref ISpace);

foreach(var gridChild in ISpace["BudgetDetails"].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 


if(
ISpace["RecurringValidation"].Value==519)
{
base.WriteDebugInfo(@"
if(
ISpace[""RecurringValidation""].Value==519)");
ISpace["NonRecurringAmount"].Value=ISpace["NonRecurringAmount"].Value+ISpace["BudgetAmount"].Value;
base.WriteDebugInfo(@"ISpace[""NonRecurringAmount""].Value=ISpace[""NonRecurringAmount""].Value+ISpace[""BudgetAmount""].Value;");
}

if(
ISpace["RecurringValidation"].Value==518)
{
base.WriteDebugInfo(@"
if(
ISpace[""RecurringValidation""].Value==518)");
ISpace["RecurringAmount"].Value=ISpace["RecurringAmount"].Value+ISpace["BudgetAmount"].Value;
base.WriteDebugInfo(@"ISpace[""RecurringAmount""].Value=ISpace[""RecurringAmount""].Value+ISpace[""BudgetAmount""].Value;");
}
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("BudgetDetails","C92F6C5D-F7CB-4E81-835C-3D655C7FCC52",_objectFactory.GetGridRPP("BudgetDetails"),_elementBase.GetGridLoopQuery("C92F6C5D-F7CB-4E81-835C-3D655C7FCC52","BudgetDetails",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""BudgetDetails"",ref ISpace);

foreach(var gridChild in ISpace[""BudgetDetails""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
if(ISpace["ProcessID"].Value!="")
{
base.WriteDebugInfo(@"if(ISpace[""ProcessID""].Value!="""")");
ISpace["ProjectProposal"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""ProjectProposal""].Enbl=""false"";");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["ProjectBudgetDetailsid"].Value=Guid.NewGuid().ToString();
base.WriteDebugInfo(@"ISpace[""ProjectBudgetDetailsid""].Value=Guid.NewGuid().ToString();");
}
if(ISpace["FormVersionId"].Value=="EB102E80-C3DC-4EB9-8511-B1018E342530")
{
ISpace["UI_ProjectJourney"].Visible="false";ISpace["UI_ProjectJourney"].Enbl="false";
}if(ISpace["FormVersionId"].Value=="EB102E80-C3DC-4EB9-8511-B1018E342530")
{
ISpace["UI_ApprovalStatus1"].Visible="false";ISpace["UI_ApprovalStatus1"].Enbl="false";
}if(ISpace["FormVersionId"].Value=="EB102E80-C3DC-4EB9-8511-B1018E342530")
{
ISpace["UI_Income"].Visible="false";ISpace["UI_Income"].Enbl="false";
}if(ISpace["FormVersionId"].Value=="EB102E80-C3DC-4EB9-8511-B1018E342530")
{
ISpace["UI_Expenditure"].Visible="false";ISpace["UI_Expenditure"].Enbl="false";
}if(ISpace["FormVersionId"].Value=="EB102E80-C3DC-4EB9-8511-B1018E342530")
{
ISpace["UI_Fundrelease"].Visible="false";ISpace["UI_Fundrelease"].Enbl="false";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""EB102E80-C3DC-4EB9-8511-B1018E342530"")
{
ISpace[""UI_ProjectJourney""].Visible=""false"";ISpace[""UI_ProjectJourney""].Enbl=""false"";
}if(ISpace[""FormVersionId""].Value==""EB102E80-C3DC-4EB9-8511-B1018E342530"")
{
ISpace[""UI_ApprovalStatus1""].Visible=""false"";ISpace[""UI_ApprovalStatus1""].Enbl=""false"";
}if(ISpace[""FormVersionId""].Value==""EB102E80-C3DC-4EB9-8511-B1018E342530"")
{
ISpace[""UI_Income""].Visible=""false"";ISpace[""UI_Income""].Enbl=""false"";
}if(ISpace[""FormVersionId""].Value==""EB102E80-C3DC-4EB9-8511-B1018E342530"")
{
ISpace[""UI_Expenditure""].Visible=""false"";ISpace[""UI_Expenditure""].Enbl=""false"";
}if(ISpace[""FormVersionId""].Value==""EB102E80-C3DC-4EB9-8511-B1018E342530"")
{
ISpace[""UI_Fundrelease""].Visible=""false"";ISpace[""UI_Fundrelease""].Enbl=""false"";
}");
ISpace["ProjectRefNo"].Enbl="true";ISpace["SchemeType"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""ProjectRefNo""].Enbl=""true"";ISpace[""SchemeType""].Enbl=""true"";");
if(ISpace["ManPowerRequired"].Value==true)
{
base.WriteDebugInfo(@"if(ISpace[""ManPowerRequired""].Value==true)");
ISpace["ManPowerDetails"].Visible="true";
base.WriteDebugInfo(@"ISpace[""ManPowerDetails""].Visible=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["ManPowerDetails"].Visible="false";
base.WriteDebugInfo(@"ISpace[""ManPowerDetails""].Visible=""false"";");
}
if(ISpace["IFEquipment"].Value==true)
{
base.WriteDebugInfo(@"if(ISpace[""IFEquipment""].Value==true)");
ISpace["EquipmentDetails"].Visible="true";
base.WriteDebugInfo(@"ISpace[""EquipmentDetails""].Visible=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["EquipmentDetails"].Visible="false";
base.WriteDebugInfo(@"ISpace[""EquipmentDetails""].Visible=""false"";");
}
ISpace["FinancialYear"].Value="19";
base.WriteDebugInfo(@"ISpace[""FinancialYear""].Value=""19"";");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_name (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Name-OnChange");
ISpace["CountCopi"].Value=0;
base.WriteDebugInfo(@"ISpace[""CountCopi""].Value=0;");
ISpace["RootCopi"].Value=ISpace["Name"].Value;
base.WriteDebugInfo(@"ISpace[""RootCopi""].Value=ISpace[""Name""].Value;");
base.WriteDebugInfo(@"#CoPiDetails[Rows]");
iSpace.GetLoopExpressionData("CoPiDetails",ref ISpace);

foreach(var gridChild in ISpace["CoPiDetails"].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 


if(

ISpace["RootCopi"].Value==ISpace["Name"].Value)
{
base.WriteDebugInfo(@"
if(

ISpace[""RootCopi""].Value==ISpace[""Name""].Value)");
ISpace["CountCopi"].Value=ISpace["CountCopi"].Value+1;
base.WriteDebugInfo(@"ISpace[""CountCopi""].Value=ISpace[""CountCopi""].Value+1;");
}

if(
ISpace["CountCopi"].Value==2)
{
base.WriteDebugInfo(@"
if(
ISpace[""CountCopi""].Value==2)");
ISpace["Message"].Value=@"Duplicate Name Found Select a Different Name.";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Duplicate Name Found Select a Different Name."";");
ISpace["Name"].Value=null;
base.WriteDebugInfo(@"ISpace[""Name""].Value=null;");
ISpace["UserName"].Value=null;
base.WriteDebugInfo(@"ISpace[""UserName""].Value=null;");
ISpace["Email"].Value=null;
base.WriteDebugInfo(@"ISpace[""Email""].Value=null;");
ISpace["CountCopi"].Value=0;
base.WriteDebugInfo(@"ISpace[""CountCopi""].Value=0;");
return;
base.WriteDebugInfo(@"return;");
}
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("CoPiDetails","A8711B81-85A3-41BC-8B9B-67F9DAAFFCD5",_objectFactory.GetGridRPP("CoPiDetails"),_elementBase.GetGridLoopQuery("A8711B81-85A3-41BC-8B9B-67F9DAAFFCD5","CoPiDetails",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""CoPiDetails"",ref ISpace);

foreach(var gridChild in ISpace[""CoPiDetails""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC [GetDepartmentWiseFaculty] '',4,'#Name','',''");

var querySourceCBF938DF31264575A0D309AC72307CDC =GetQueryExpressionDataSource("CBF938DF-3126-4575-A0D3-09AC72307CDC");
Dictionary<short,object> resultCBF938DF31264575A0D309AC72307CDC=iSpace.ExecuteQuery(querySourceCBF938DF31264575A0D309AC72307CDC,@"EXEC [GetDepartmentWiseFaculty] '',4,'" + ISpace["Name"].Value + @"','',''",false);

base.WriteDebugInfo(@"var querySourceCBF938DF31264575A0D309AC72307CDC =GetQueryExpressionDataSource(""CBF938DF-3126-4575-A0D3-09AC72307CDC"");Dictionary<short,object> resultCBF938DF31264575A0D309AC72307CDC=iSpace.ExecuteQuery(querySourceCBF938DF31264575A0D309AC72307CDC,@""EXEC [GetDepartmentWiseFaculty] '',4,'"" + ISpace[""Name""].Value + @""','',''"",false);");
base.WriteDebugInfo(@"");

if((resultCBF938DF31264575A0D309AC72307CDC!=null) && (resultCBF938DF31264575A0D309AC72307CDC.Count!=0))
{
if(resultCBF938DF31264575A0D309AC72307CDC.ContainsKey(0))
ISpace["UserName"].Value = resultCBF938DF31264575A0D309AC72307CDC[0];
if(resultCBF938DF31264575A0D309AC72307CDC.ContainsKey(4))
ISpace["Dept"].Value = resultCBF938DF31264575A0D309AC72307CDC[4];
if(resultCBF938DF31264575A0D309AC72307CDC.ContainsKey(3))
ISpace["EmployeeBasicInfo"].Value = resultCBF938DF31264575A0D309AC72307CDC[3];
if(resultCBF938DF31264575A0D309AC72307CDC.ContainsKey(1))
ISpace["Email"].Value = resultCBF938DF31264575A0D309AC72307CDC[1];
if(resultCBF938DF31264575A0D309AC72307CDC.ContainsKey(2))
ISpace["Role"].Value = resultCBF938DF31264575A0D309AC72307CDC[2];
}
else{
ISpace["UserName"].Value = null;ISpace["Dept"].Value = null;ISpace["EmployeeBasicInfo"].Value = null;ISpace["Email"].Value = null;ISpace["Role"].Value = null;
}
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mp_totalmonths (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MP_TotalMonths-OnChange");
if(1==2)
{
base.WriteDebugInfo(@"if(1==2)");
ISpace["MP_ManpowerTotalCost"].Value=ISpace["MP_HRAperMonth"].Value+ISpace["MP_RatePerMonth"].Value*ISpace["MP_TotalMonths"].Value;
base.WriteDebugInfo(@"ISpace[""MP_ManpowerTotalCost""].Value=ISpace[""MP_HRAperMonth""].Value+ISpace[""MP_RatePerMonth""].Value*ISpace[""MP_TotalMonths""].Value;");
object MP_ManpowerTotalCost=iSpace.Sum("[70051D3C-20CA-47D4-9917-B33DED7ACE9C]","MP_ManpowerTotalCost","",ISpace["gv_instanceid"].Value);
ISpace["ManpowerTotalCost"].Value=Convert.ChangeType(MP_ManpowerTotalCost, MP_ManpowerTotalCost.GetType());;
base.WriteDebugInfo(@"object MP_ManpowerTotalCost=iSpace.Sum(""[70051D3C-20CA-47D4-9917-B33DED7ACE9C]"",""MP_ManpowerTotalCost"","""",ISpace[""gv_instanceid""].Value);
ISpace[""ManpowerTotalCost""].Value=Convert.ChangeType(MP_ManpowerTotalCost, MP_ManpowerTotalCost.GetType());;");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC GetProjectManpowerCalculation 1,#MP_No,#MP_RatePerMonth,#MP_HRAperMonth,#MP_TotalMonths");

var querySource1711E384D9DC44A1B25CA5E3AE8384A6 =GetQueryExpressionDataSource("1711E384-D9DC-44A1-B25C-A5E3AE8384A6");
Dictionary<short,object> result1711E384D9DC44A1B25CA5E3AE8384A6=iSpace.ExecuteQuery(querySource1711E384D9DC44A1B25CA5E3AE8384A6,@"EXEC GetProjectManpowerCalculation 1," + ISpace["MP_No"].Value + @"," + ISpace["MP_RatePerMonth"].Value + @"," + ISpace["MP_HRAperMonth"].Value + @"," + ISpace["MP_TotalMonths"].Value + @"",false);

base.WriteDebugInfo(@"var querySource1711E384D9DC44A1B25CA5E3AE8384A6 =GetQueryExpressionDataSource(""1711E384-D9DC-44A1-B25C-A5E3AE8384A6"");Dictionary<short,object> result1711E384D9DC44A1B25CA5E3AE8384A6=iSpace.ExecuteQuery(querySource1711E384D9DC44A1B25CA5E3AE8384A6,@""EXEC GetProjectManpowerCalculation 1,"" + ISpace[""MP_No""].Value + @"","" + ISpace[""MP_RatePerMonth""].Value + @"","" + ISpace[""MP_HRAperMonth""].Value + @"","" + ISpace[""MP_TotalMonths""].Value + @"""",false);");
base.WriteDebugInfo(@"");

if((result1711E384D9DC44A1B25CA5E3AE8384A6!=null) && (result1711E384D9DC44A1B25CA5E3AE8384A6.Count!=0))
{
if(result1711E384D9DC44A1B25CA5E3AE8384A6.ContainsKey(0))
ISpace["MP_ManpowerTotalCost"].Value = result1711E384D9DC44A1B25CA5E3AE8384A6[0];
}
else{
ISpace["MP_ManpowerTotalCost"].Value = null;
}
base.WriteDebugInfo(@"#ManPowerDetails[rows]");
iSpace.GetLoopExpressionData("ManPowerDetails",ref ISpace);

foreach(var gridChild in ISpace["ManPowerDetails"].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 


object MP_ManpowerTotalCost=iSpace.Sum("[70051D3C-20CA-47D4-9917-B33DED7ACE9C]","MP_ManpowerTotalCost","",ISpace["gv_instanceid"].Value);
ISpace["ManpowerTotalCost"].Value=Convert.ChangeType(MP_ManpowerTotalCost, MP_ManpowerTotalCost.GetType());;
base.WriteDebugInfo(@"
object MP_ManpowerTotalCost=iSpace.Sum(""[70051D3C-20CA-47D4-9917-B33DED7ACE9C]"",""MP_ManpowerTotalCost"","""",ISpace[""gv_instanceid""].Value);
ISpace[""ManpowerTotalCost""].Value=Convert.ChangeType(MP_ManpowerTotalCost, MP_ManpowerTotalCost.GetType());;");
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("ManPowerDetails","70051D3C-20CA-47D4-9917-B33DED7ACE9C",_objectFactory.GetGridRPP("ManPowerDetails"),_elementBase.GetGridLoopQuery("70051D3C-20CA-47D4-9917-B33DED7ACE9C","ManPowerDetails",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""ManPowerDetails"",ref ISpace);

foreach(var gridChild in ISpace[""ManPowerDetails""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"#BudgetDetails[Rows]");
iSpace.GetLoopExpressionData("BudgetDetails",ref ISpace);

foreach(var gridChild in ISpace["BudgetDetails"].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 


if(
ISpace["Bid"].Value==7)
{
base.WriteDebugInfo(@"
if(
ISpace[""Bid""].Value==7)");
ISpace["ManPowerAmount"].Value=ISpace["BudgetAmount"].Value;
base.WriteDebugInfo(@"ISpace[""ManPowerAmount""].Value=ISpace[""BudgetAmount""].Value;");
}
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("BudgetDetails","C92F6C5D-F7CB-4E81-835C-3D655C7FCC52",_objectFactory.GetGridRPP("BudgetDetails"),_elementBase.GetGridLoopQuery("C92F6C5D-F7CB-4E81-835C-3D655C7FCC52","BudgetDetails",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""BudgetDetails"",ref ISpace);

foreach(var gridChild in ISpace[""BudgetDetails""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
if(ISpace["ManpowerTotalCost"].Value>ISpace["ManPowerAmount"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""ManpowerTotalCost""].Value>ISpace[""ManPowerAmount""].Value)");
ISpace["Message"].Value=@"ManPower Total Cost is greater than Manpower Budget";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""ManPower Total Cost is greater than Manpower Budget"";");
ISpace["MP_No"].Value=null;
base.WriteDebugInfo(@"ISpace[""MP_No""].Value=null;");
ISpace["MP_RatePerMonth"].Value=null;
base.WriteDebugInfo(@"ISpace[""MP_RatePerMonth""].Value=null;");
ISpace["MP_HRAPer"].Value=0;
base.WriteDebugInfo(@"ISpace[""MP_HRAPer""].Value=0;");
ISpace["MP_TotalPerMonth"].Value=0;
base.WriteDebugInfo(@"ISpace[""MP_TotalPerMonth""].Value=0;");
ISpace["MP_TotalMonths"].Value=null;
base.WriteDebugInfo(@"ISpace[""MP_TotalMonths""].Value=null;");
ISpace["MP_ManpowerTotalCost"].Value=0;
base.WriteDebugInfo(@"ISpace[""MP_ManpowerTotalCost""].Value=0;");
object MP_ManpowerTotalCost=iSpace.Sum("[]","MP_ManpowerTotalCost","",ISpace["gv_instanceid"].Value);
ISpace["ManpowerTotalCost"].Value=Convert.ChangeType(MP_ManpowerTotalCost, MP_ManpowerTotalCost.GetType());;
base.WriteDebugInfo(@"object MP_ManpowerTotalCost=iSpace.Sum(""[]"",""MP_ManpowerTotalCost"","""",ISpace[""gv_instanceid""].Value);
ISpace[""ManpowerTotalCost""].Value=Convert.ChangeType(MP_ManpowerTotalCost, MP_ManpowerTotalCost.GetType());;");
return;
base.WriteDebugInfo(@"return;");
}
}
ISpace["MP_HRAPercal"].Value=ISpace["MP_HRAPer"].Value/100.0;
base.WriteDebugInfo(@"ISpace[""MP_HRAPercal""].Value=ISpace[""MP_HRAPer""].Value/100.0;");
ISpace["MP_HRAperMonth"].Value=ISpace["MP_RatePerMonth"].Value*ISpace["MP_HRAPercal"].Value;
base.WriteDebugInfo(@"ISpace[""MP_HRAperMonth""].Value=ISpace[""MP_RatePerMonth""].Value*ISpace[""MP_HRAPercal""].Value;");
ISpace["MP_TotalPerMonth"].Value=ISpace["MP_RatePerMonth"].Value+ISpace["MP_HRAperMonth"].Value;
base.WriteDebugInfo(@"ISpace[""MP_TotalPerMonth""].Value=ISpace[""MP_RatePerMonth""].Value+ISpace[""MP_HRAperMonth""].Value;");
if(ISpace["MP_TotalMonths"].Value==0)
{
base.WriteDebugInfo(@"if(ISpace[""MP_TotalMonths""].Value==0)");
ISpace["MP_ManpowerTotalCost"].Value=null;
base.WriteDebugInfo(@"ISpace[""MP_ManpowerTotalCost""].Value=null;");
ISpace["ManpowerTotalCost"].Value=null;
base.WriteDebugInfo(@"ISpace[""ManpowerTotalCost""].Value=null;");
return;
base.WriteDebugInfo(@"return;");
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_back (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Back-OnClick");
if(ISpace["ActiveEdit"].Value==0)
{
base.WriteDebugInfo(@"if(ISpace[""ActiveEdit""].Value==0)");
base.WriteDebugInfo(@"Entering DomainDataMap for Budget Details Grid Domain");
var BudgetDetailsGridDomain_repoObj = new RepositoryMapper(DbTypes.SQLServer);


var ProjectBudgetDetailsBudgetDetailsGridDomaintableObj = new RepositoryTable("ProjectBudgetDetails");
  ProjectBudgetDetailsBudgetDetailsGridDomaintableObj.AppConnectionSettingsId  ="40BDEB14-07CC-4150-8A52-9B088A428E2D";ProjectBudgetDetailsBudgetDetailsGridDomaintableObj.ProofConnectionId = "C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0)";
var BudgetDetailsGridDomain_ProjectBudgetDetails_rows = GetElementClientData(ISpace["InstanceId"].Value,"C92F6C5D-F7CB-4E81-835C-3D655C7FCC52");

if(BudgetDetailsGridDomain_ProjectBudgetDetails_rows!=null && BudgetDetailsGridDomain_ProjectBudgetDetails_rows.Count>0){
var BudgetDetailsGridDomain_ProjectBudgetDetails_rowsObj = new List<RepositoryRow>();
foreach(var rows in BudgetDetailsGridDomain_ProjectBudgetDetails_rows){RepositoryRow repositoryRowObj = null;string elementData = null;RepositoryColumn repositoryColumnObj = null;if(rows !=null){ var ProjectBudgetDetails_colObj = new List<RepositoryColumn>();repositoryRowObj= new RepositoryRow();//var myByte = (byte)rowData.Value.RwSt;//repositoryRowObj.RowState=(RepositoryRowState)myByte;

if(rows.ContainsKey("A38311B1-68C6-462E-9DB6-FD90ABFF6E44"))     elementData = rows["A38311B1-68C6-462E-9DB6-FD90ABFF6E44"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"BudgetAmount",false,false,3);
if(repositoryColumnObj!=null)ProjectBudgetDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-BudgetAmount not found");}

if(rows.ContainsKey("F7FB513A-721E-4E82-89DD-F03DF3E8AB16"))     elementData = rows["F7FB513A-721E-4E82-89DD-F03DF3E8AB16"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"BudgetID",false,false,5);
if(repositoryColumnObj!=null)ProjectBudgetDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Bid not found");}

if(rows.ContainsKey("FD08EF20-802B-4672-8747-6D54C2D6D31E"))     elementData = rows["FD08EF20-802B-4672-8747-6D54C2D6D31E"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Year2",false,false,5);
if(repositoryColumnObj!=null)ProjectBudgetDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Year12 not found");}

if(rows.ContainsKey("49074D93-7C7F-401F-AD44-0BB2B5353FE3"))     elementData = rows["49074D93-7C7F-401F-AD44-0BB2B5353FE3"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ProjectDetailsID",false,false,9);
if(repositoryColumnObj!=null)ProjectBudgetDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-ID1 not found");}

elementData = CurrentDate().ToString() ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"UpdatedOn",false,false,8);
if(repositoryColumnObj!=null)ProjectBudgetDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-CurrentDate not found");}

if(rows.ContainsKey("67FD82A6-A670-4DD2-8574-AAD959805F77"))     elementData = rows["67FD82A6-A670-4DD2-8574-AAD959805F77"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Year7",false,false,5);
if(repositoryColumnObj!=null)ProjectBudgetDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Year17 not found");}

if(rows.ContainsKey("B5948E98-0ABA-493A-A2DB-DF169BE81734"))     elementData = rows["B5948E98-0ABA-493A-A2DB-DF169BE81734"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Year9",false,false,5);
if(repositoryColumnObj!=null)ProjectBudgetDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Year19 not found");}

if(rows.ContainsKey("153737E5-6626-4A69-8501-4AAD946A634A"))     elementData = rows["153737E5-6626-4A69-8501-4AAD946A634A"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"OverallAmount",false,false,3);
if(repositoryColumnObj!=null)ProjectBudgetDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-OverallBudgetTotal not found");}

if(rows.ContainsKey("6B169537-9858-4E64-9587-5454EDE7F799"))     elementData = rows["6B169537-9858-4E64-9587-5454EDE7F799"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Year4",false,false,5);
if(repositoryColumnObj!=null)ProjectBudgetDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Year14 not found");}

if(rows.ContainsKey("DDAC7A4B-1F58-4403-A731-A41BFE920BBB"))     elementData = rows["DDAC7A4B-1F58-4403-A731-A41BFE920BBB"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Year1",false,false,5);
if(repositoryColumnObj!=null)ProjectBudgetDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Year11 not found");}

elementData = ISpace["gv_UserId"].Value != null? Convert.ToString(ISpace["gv_UserId"].Value):null ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"UpdatedBy",false,false,6);
if(repositoryColumnObj!=null)ProjectBudgetDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-gv_UserId not found");}

if(rows.ContainsKey("B6B3B0F1-D9E6-442C-AD71-494FF4470030"))     elementData = rows["B6B3B0F1-D9E6-442C-AD71-494FF4470030"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Year3",false,false,5);
if(repositoryColumnObj!=null)ProjectBudgetDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Year13 not found");}

if(rows.ContainsKey("6EC8DDAB-B1F1-4D8C-9598-77E3827539D5"))     elementData = rows["6EC8DDAB-B1F1-4D8C-9598-77E3827539D5"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Year6",false,false,5);
if(repositoryColumnObj!=null)ProjectBudgetDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Year16 not found");}

if(rows.ContainsKey("E0DCC460-53C1-4953-90C3-C97266369DD1"))     elementData = rows["E0DCC460-53C1-4953-90C3-C97266369DD1"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Year11",false,false,5);
if(repositoryColumnObj!=null)ProjectBudgetDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Year21 not found");}

if(rows.ContainsKey("303EE107-01E7-49DF-94E6-F6461AC4CB48"))     elementData = rows["303EE107-01E7-49DF-94E6-F6461AC4CB48"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"BudgetDetailID",true,false,9);
if(repositoryColumnObj!=null)ProjectBudgetDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-ProjectBudgetDetailsid not found");}

if(rows.ContainsKey("7A91BE20-EB4E-4223-9FE5-5BE3A531F3FC"))     elementData = rows["7A91BE20-EB4E-4223-9FE5-5BE3A531F3FC"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Year10",false,false,5);
if(repositoryColumnObj!=null)ProjectBudgetDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Year20 not found");}

if(rows.ContainsKey("F85850E3-22D8-43A9-A14F-2D5283720AB0"))     elementData = rows["F85850E3-22D8-43A9-A14F-2D5283720AB0"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Comments",false,false,9);
if(repositoryColumnObj!=null)ProjectBudgetDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-commentss not found");}

if(rows.ContainsKey("85E319F5-14C8-44FA-9C41-0E3303FDCE8F"))     elementData = rows["85E319F5-14C8-44FA-9C41-0E3303FDCE8F"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Year12",false,false,5);
if(repositoryColumnObj!=null)ProjectBudgetDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Year22 not found");}

if(rows.ContainsKey("2E19ABDB-10E6-4785-8244-7863EA4FBCBC"))     elementData = rows["2E19ABDB-10E6-4785-8244-7863EA4FBCBC"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Year5",false,false,5);
if(repositoryColumnObj!=null)ProjectBudgetDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Year15 not found");}

if(rows.ContainsKey("B134B486-06FC-487E-BEA2-AE6F137D586C"))     elementData = rows["B134B486-06FC-487E-BEA2-AE6F137D586C"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Year8",false,false,5);
if(repositoryColumnObj!=null)ProjectBudgetDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Year18 not found");}

if(rows.ContainsKey("19DEC91D-3072-486C-947C-F5C3A8756745"))     elementData = rows["19DEC91D-3072-486C-947C-F5C3A8756745"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"RDOfficeComments",false,false,9);
if(repositoryColumnObj!=null)ProjectBudgetDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-RDComments not found");}
repositoryRowObj.Columns=ProjectBudgetDetails_colObj;
BudgetDetailsGridDomain_ProjectBudgetDetails_rowsObj.Add(repositoryRowObj);
}}

ProjectBudgetDetailsBudgetDetailsGridDomaintableObj.Rows=BudgetDetailsGridDomain_ProjectBudgetDetails_rowsObj;
var BudgetDetailsGridDomain_repoObj_status_ProjectBudgetDetails = BudgetDetailsGridDomain_repoObj.Execute(DomainOperationTypes.CreateOrUpdate,ref ProjectBudgetDetailsBudgetDetailsGridDomaintableObj);if(!BudgetDetailsGridDomain_repoObj_status_ProjectBudgetDetails) throw new Exception("Error in Execute Domain Data Map");}
base.WriteDebugInfo(@"Exiting DomainDataMap for Budget Details Grid Domain");
}
if(ISpace["ActiveEdit"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""ActiveEdit""].Value==1)");
base.WriteDebugInfo(@"Entering DomainDataMap for TempBudgetDetails");
var TempBudgetDetails_repoObj = new RepositoryMapper(DbTypes.SQLServer);


var TempProjectbudgetdetailsTempBudgetDetailstableObj = new RepositoryTable("TempProjectbudgetdetails");
  TempProjectbudgetdetailsTempBudgetDetailstableObj.AppConnectionSettingsId  ="CA34B07F-5D19-412F-A39F-3ADA64B5E0C0";TempProjectbudgetdetailsTempBudgetDetailstableObj.ProofConnectionId = "C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0)";
var TempBudgetDetails_TempProjectbudgetdetails_rows = GetElementClientData(ISpace["InstanceId"].Value,"C92F6C5D-F7CB-4E81-835C-3D655C7FCC52");

if(TempBudgetDetails_TempProjectbudgetdetails_rows!=null && TempBudgetDetails_TempProjectbudgetdetails_rows.Count>0){
var TempBudgetDetails_TempProjectbudgetdetails_rowsObj = new List<RepositoryRow>();
foreach(var rows in TempBudgetDetails_TempProjectbudgetdetails_rows){RepositoryRow repositoryRowObj = null;string elementData = null;RepositoryColumn repositoryColumnObj = null;if(rows !=null){ var TempProjectbudgetdetails_colObj = new List<RepositoryColumn>();repositoryRowObj= new RepositoryRow();//var myByte = (byte)rowData.Value.RwSt;//repositoryRowObj.RowState=(RepositoryRowState)myByte;

if(rows.ContainsKey("B6B3B0F1-D9E6-442C-AD71-494FF4470030"))     elementData = rows["B6B3B0F1-D9E6-442C-AD71-494FF4470030"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Year3",false,false,5);
if(repositoryColumnObj!=null)TempProjectbudgetdetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Year13 not found");}

if(rows.ContainsKey("303EE107-01E7-49DF-94E6-F6461AC4CB48"))     elementData = rows["303EE107-01E7-49DF-94E6-F6461AC4CB48"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"BudgetDetailID",true,false,9);
if(repositoryColumnObj!=null)TempProjectbudgetdetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-ProjectBudgetDetailsid not found");}

if(rows.ContainsKey("FD08EF20-802B-4672-8747-6D54C2D6D31E"))     elementData = rows["FD08EF20-802B-4672-8747-6D54C2D6D31E"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Year2",false,false,5);
if(repositoryColumnObj!=null)TempProjectbudgetdetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Year12 not found");}

if(rows.ContainsKey("6EC8DDAB-B1F1-4D8C-9598-77E3827539D5"))     elementData = rows["6EC8DDAB-B1F1-4D8C-9598-77E3827539D5"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Year6",false,false,5);
if(repositoryColumnObj!=null)TempProjectbudgetdetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Year16 not found");}

if(rows.ContainsKey("F7FB513A-721E-4E82-89DD-F03DF3E8AB16"))     elementData = rows["F7FB513A-721E-4E82-89DD-F03DF3E8AB16"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"BudgetID",false,false,5);
if(repositoryColumnObj!=null)TempProjectbudgetdetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Bid not found");}

if(rows.ContainsKey("A38311B1-68C6-462E-9DB6-FD90ABFF6E44"))     elementData = rows["A38311B1-68C6-462E-9DB6-FD90ABFF6E44"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"BudgetAmount",false,false,3);
if(repositoryColumnObj!=null)TempProjectbudgetdetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-BudgetAmount not found");}

if(rows.ContainsKey("E0DCC460-53C1-4953-90C3-C97266369DD1"))     elementData = rows["E0DCC460-53C1-4953-90C3-C97266369DD1"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Year11",false,false,5);
if(repositoryColumnObj!=null)TempProjectbudgetdetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Year21 not found");}

if(rows.ContainsKey("6B169537-9858-4E64-9587-5454EDE7F799"))     elementData = rows["6B169537-9858-4E64-9587-5454EDE7F799"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Year4",false,false,5);
if(repositoryColumnObj!=null)TempProjectbudgetdetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Year14 not found");}

if(rows.ContainsKey("153737E5-6626-4A69-8501-4AAD946A634A"))     elementData = rows["153737E5-6626-4A69-8501-4AAD946A634A"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"OverallAmount",false,false,3);
if(repositoryColumnObj!=null)TempProjectbudgetdetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-OverallBudgetTotal not found");}

if(rows.ContainsKey("19DEC91D-3072-486C-947C-F5C3A8756745"))     elementData = rows["19DEC91D-3072-486C-947C-F5C3A8756745"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"RDOfficeComments",false,false,9);
if(repositoryColumnObj!=null)TempProjectbudgetdetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-RDComments not found");}

if(rows.ContainsKey("85E319F5-14C8-44FA-9C41-0E3303FDCE8F"))     elementData = rows["85E319F5-14C8-44FA-9C41-0E3303FDCE8F"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Year12",false,false,5);
if(repositoryColumnObj!=null)TempProjectbudgetdetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Year22 not found");}

if(rows.ContainsKey("67FD82A6-A670-4DD2-8574-AAD959805F77"))     elementData = rows["67FD82A6-A670-4DD2-8574-AAD959805F77"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Year7",false,false,5);
if(repositoryColumnObj!=null)TempProjectbudgetdetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Year17 not found");}

if(rows.ContainsKey("2E19ABDB-10E6-4785-8244-7863EA4FBCBC"))     elementData = rows["2E19ABDB-10E6-4785-8244-7863EA4FBCBC"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Year5",false,false,5);
if(repositoryColumnObj!=null)TempProjectbudgetdetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Year15 not found");}

elementData = ISpace["gv_UserId"].Value != null? Convert.ToString(ISpace["gv_UserId"].Value):null ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"UpdatedBy",false,false,6);
if(repositoryColumnObj!=null)TempProjectbudgetdetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-gv_UserId not found");}

if(rows.ContainsKey("2833427C-A5F6-43D0-9A15-E33760BA7E46"))     elementData = rows["2833427C-A5F6-43D0-9A15-E33760BA7E46"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"TempInstanceid",false,false,9);
if(repositoryColumnObj!=null)TempProjectbudgetdetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-TempInstanceID not found");}

if(rows.ContainsKey("DDAC7A4B-1F58-4403-A731-A41BFE920BBB"))     elementData = rows["DDAC7A4B-1F58-4403-A731-A41BFE920BBB"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Year1",false,false,3);
if(repositoryColumnObj!=null)TempProjectbudgetdetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Year11 not found");}

if(rows.ContainsKey("F85850E3-22D8-43A9-A14F-2D5283720AB0"))     elementData = rows["F85850E3-22D8-43A9-A14F-2D5283720AB0"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Comments",false,false,9);
if(repositoryColumnObj!=null)TempProjectbudgetdetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-commentss not found");}

if(rows.ContainsKey("B134B486-06FC-487E-BEA2-AE6F137D586C"))     elementData = rows["B134B486-06FC-487E-BEA2-AE6F137D586C"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Year8",false,false,5);
if(repositoryColumnObj!=null)TempProjectbudgetdetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Year18 not found");}

elementData = CurrentDate().ToString() ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"UpdatedOn",false,false,8);
if(repositoryColumnObj!=null)TempProjectbudgetdetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-CurrentDate not found");}

if(rows.ContainsKey("B5948E98-0ABA-493A-A2DB-DF169BE81734"))     elementData = rows["B5948E98-0ABA-493A-A2DB-DF169BE81734"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Year9",false,false,5);
if(repositoryColumnObj!=null)TempProjectbudgetdetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Year19 not found");}

if(rows.ContainsKey("49074D93-7C7F-401F-AD44-0BB2B5353FE3"))     elementData = rows["49074D93-7C7F-401F-AD44-0BB2B5353FE3"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ProjectDetailsID",false,false,9);
if(repositoryColumnObj!=null)TempProjectbudgetdetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-ID1 not found");}

if(rows.ContainsKey("7A91BE20-EB4E-4223-9FE5-5BE3A531F3FC"))     elementData = rows["7A91BE20-EB4E-4223-9FE5-5BE3A531F3FC"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Year10",false,false,5);
if(repositoryColumnObj!=null)TempProjectbudgetdetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Year20 not found");}
repositoryRowObj.Columns=TempProjectbudgetdetails_colObj;
TempBudgetDetails_TempProjectbudgetdetails_rowsObj.Add(repositoryRowObj);
}}

TempProjectbudgetdetailsTempBudgetDetailstableObj.Rows=TempBudgetDetails_TempProjectbudgetdetails_rowsObj;
var TempBudgetDetails_repoObj_status_TempProjectbudgetdetails = TempBudgetDetails_repoObj.Execute(DomainOperationTypes.CreateOrUpdate,ref TempProjectbudgetdetailsTempBudgetDetailstableObj);if(!TempBudgetDetails_repoObj_status_TempProjectbudgetdetails) throw new Exception("Error in Execute Domain Data Map");}
base.WriteDebugInfo(@"Exiting DomainDataMap for TempBudgetDetails");
}
if(ISpace["ActiveEdit"].Value==0)
{
base.WriteDebugInfo(@"if(ISpace[""ActiveEdit""].Value==0)");

var querySource69D87FBD9BEB47BEB916F267A651A953 =GetQueryExpressionDataSource("69D87FBD-9BEB-47BE-B916-F267A651A953");

DataTable result69D87FBD9BEB47BEB916F267A651A953=iSpace.SetGridDataSource(querySource69D87FBD9BEB47BEB916F267A651A953, _objectFactory.GetGridRPP("BudgetDetails"),@"EXEC [GetProjectDetailCombo] 1,'" + ISpace["ID1"].Value + @"'");

iSpace.InsertGridBindDetails("BudgetDetails","11",querySource69D87FBD9BEB47BEB916F267A651A953,"EXEC [GetProjectDetailCombo] 1,'" + ISpace["ID1"].Value + @"'",_objectFactory.GetGridRPP("BudgetDetails"));

base.WriteDebugInfo(@"var querySource69D87FBD9BEB47BEB916F267A651A953 =GetQueryExpressionDataSource(""69D87FBD-9BEB-47BE-B916-F267A651A953"");DataTable result69D87FBD9BEB47BEB916F267A651A953=iSpace.SetGridDataSource(querySource69D87FBD9BEB47BEB916F267A651A953, _objectFactory.GetGridRPP(""BudgetDetails""),@""EXEC [GetProjectDetailCombo] 1,'"" + ISpace[""ID1""].Value + @""'"");iSpace.InsertGridBindDetails(""BudgetDetails"",""11"",querySource69D87FBD9BEB47BEB916F267A651A953,""EXEC [GetProjectDetailCombo] 1,'"" + ISpace[""ID1""].Value + @""'"",_objectFactory.GetGridRPP(""BudgetDetails""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> resultCF752EE8E74240ED941907B9622045EE=acdataIspaceD0B6EBB910A44D43A76EF39441A41EF6.GetQueryExpressionBindings("CF752EE8-E742-40ED-9419-07B9622045EE");
iSpace.SetGridData(result69D87FBD9BEB47BEB916F267A651A953,resultCF752EE8E74240ED941907B9622045EE,"BudgetDetails",ref ISpace);
iSpace.UpdateGridBindDetails("BudgetDetails",resultCF752EE8E74240ED941907B9622045EE);
}
if(ISpace["ActiveEdit"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""ActiveEdit""].Value==1)");

var querySource50B1C2C117D643DDAABC875561B59218 =GetQueryExpressionDataSource("50B1C2C1-17D6-43DD-AABC-875561B59218");

DataTable result50B1C2C117D643DDAABC875561B59218=iSpace.SetGridDataSource(querySource50B1C2C117D643DDAABC875561B59218, _objectFactory.GetGridRPP("BudgetDetails"),@"EXEC [GetProjectDetailCombo] 15,'" + ISpace["ID1"].Value + @"'");

iSpace.InsertGridBindDetails("BudgetDetails","11",querySource50B1C2C117D643DDAABC875561B59218,"EXEC [GetProjectDetailCombo] 15,'" + ISpace["ID1"].Value + @"'",_objectFactory.GetGridRPP("BudgetDetails"));

base.WriteDebugInfo(@"var querySource50B1C2C117D643DDAABC875561B59218 =GetQueryExpressionDataSource(""50B1C2C1-17D6-43DD-AABC-875561B59218"");DataTable result50B1C2C117D643DDAABC875561B59218=iSpace.SetGridDataSource(querySource50B1C2C117D643DDAABC875561B59218, _objectFactory.GetGridRPP(""BudgetDetails""),@""EXEC [GetProjectDetailCombo] 15,'"" + ISpace[""ID1""].Value + @""'"");iSpace.InsertGridBindDetails(""BudgetDetails"",""11"",querySource50B1C2C117D643DDAABC875561B59218,""EXEC [GetProjectDetailCombo] 15,'"" + ISpace[""ID1""].Value + @""'"",_objectFactory.GetGridRPP(""BudgetDetails""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> resultE0FCE3633C384ED1AEF447B229CAACA2=acdataIspaceD0B6EBB910A44D43A76EF39441A41EF6.GetQueryExpressionBindings("E0FCE363-3C38-4ED1-AEF4-47B229CAACA2");
iSpace.SetGridData(result50B1C2C117D643DDAABC875561B59218,resultE0FCE3633C384ED1AEF447B229CAACA2,"BudgetDetails",ref ISpace);
iSpace.UpdateGridBindDetails("BudgetDetails",resultE0FCE3633C384ED1AEF447B229CAACA2);
}
if(ISpace["FormVersionId"].Value=="EB102E80-C3DC-4EB9-8511-B1018E342530")
{
ISpace["UI_Tab"].Visible="false";
}if(ISpace["FormVersionId"].Value=="EB102E80-C3DC-4EB9-8511-B1018E342530")
{
ISpace["UI_FirstRow"].Visible="true";
}if(ISpace["FormVersionId"].Value=="EB102E80-C3DC-4EB9-8511-B1018E342530")
{
ISpace["UI_SecondRow"].Visible="false";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""EB102E80-C3DC-4EB9-8511-B1018E342530"")
{
ISpace[""UI_Tab""].Visible=""false"";
}if(ISpace[""FormVersionId""].Value==""EB102E80-C3DC-4EB9-8511-B1018E342530"")
{
ISpace[""UI_FirstRow""].Visible=""true"";
}if(ISpace[""FormVersionId""].Value==""EB102E80-C3DC-4EB9-8511-B1018E342530"")
{
ISpace[""UI_SecondRow""].Visible=""false"";
}");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_ui_copi (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"UI_CoPi-OnClick");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["IfExternalIns"].Value==true)
{
base.WriteDebugInfo(@"if(ISpace[""IfExternalIns""].Value==true)");
if(ISpace["FormVersionId"].Value=="EB102E80-C3DC-4EB9-8511-B1018E342530")
{
ISpace["UI_EIColumn"].Visible="true";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""EB102E80-C3DC-4EB9-8511-B1018E342530"")
{
ISpace[""UI_EIColumn""].Visible=""true"";
}");
ISpace["ExternalInstitute"].Man=true;
base.WriteDebugInfo(@"ISpace[""ExternalInstitute""].Man=true;");
}
if(ISpace["IfExternalIns"].Value==false)
{
base.WriteDebugInfo(@"if(ISpace[""IfExternalIns""].Value==false)");
if(ISpace["FormVersionId"].Value=="EB102E80-C3DC-4EB9-8511-B1018E342530")
{
ISpace["UI_EIColumn"].Visible="false";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""EB102E80-C3DC-4EB9-8511-B1018E342530"")
{
ISpace[""UI_EIColumn""].Visible=""false"";
}");
ISpace["ExternalInstitute"].Man=false;
base.WriteDebugInfo(@"ISpace[""ExternalInstitute""].Man=false;");
}
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_intamount (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"IntAmount-OnChange");
ISpace["ProjectBudget"].Value=ISpace["IntExpense"].Value*ISpace["IntAmount"].Value;
base.WriteDebugInfo(@"ISpace[""ProjectBudget""].Value=ISpace[""IntExpense""].Value*ISpace[""IntAmount""].Value;");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_next (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Next-OnClick");
ISpace["ProjectName"].Value=Trim(ISpace["ProjectName"].Value);
base.WriteDebugInfo(@"ISpace[""ProjectName""].Value=Trim(ISpace[""ProjectName""].Value);");
if(IsNullOrEmpty(ISpace["FinancialYear"].Value))
{
base.WriteDebugInfo(@"if(IsNullOrEmpty(ISpace[""FinancialYear""].Value))");
ISpace["Message"].Value=@"Please select Financial year";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please select Financial year"";");
return;
base.WriteDebugInfo(@"return;");
}
if(IsNullOrEmpty(ISpace["FundingAcencyName"].Value))
{
base.WriteDebugInfo(@"if(IsNullOrEmpty(ISpace[""FundingAcencyName""].Value))");
ISpace["Message"].Value=@"Please enter Funding Agency Name";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please enter Funding Agency Name"";");
return;
base.WriteDebugInfo(@"return;");
}
if(IsNullOrEmpty(ISpace["ProjectCategory"].Value))
{
base.WriteDebugInfo(@"if(IsNullOrEmpty(ISpace[""ProjectCategory""].Value))");
ISpace["Message"].Value=@"Please select Project Category";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please select Project Category"";");
return;
base.WriteDebugInfo(@"return;");
}
if(IsNullOrEmpty(ISpace["ProjectName"].Value))
{
base.WriteDebugInfo(@"if(IsNullOrEmpty(ISpace[""ProjectName""].Value))");
ISpace["Message"].Value=@"Please enter Project Name";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please enter Project Name"";");
return;
base.WriteDebugInfo(@"return;");
}
if(IsNullOrEmpty(ISpace["SanctionNumber"].Value))
{
base.WriteDebugInfo(@"if(IsNullOrEmpty(ISpace[""SanctionNumber""].Value))");
ISpace["Message"].Value=@"Please enter Sanction Number";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please enter Sanction Number"";");
return;
base.WriteDebugInfo(@"return;");
}
if((ISpace["SanctionDate"].Value == null))
{
base.WriteDebugInfo(@"if((ISpace[""SanctionDate""].Value == null))");
ISpace["Message"].Value=@"Please choose Sanction Date";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please choose Sanction Date"";");
return;
base.WriteDebugInfo(@"return;");
}
if(IsNullOrEmpty(ISpace["TypeOfProject"].Value))
{
base.WriteDebugInfo(@"if(IsNullOrEmpty(ISpace[""TypeOfProject""].Value))");
ISpace["Message"].Value=@"Please select the Type of Projects";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please select the Type of Projects"";");
return;
base.WriteDebugInfo(@"return;");
}
if((ISpace["ProjectBudget"].Value == null))
{
base.WriteDebugInfo(@"if((ISpace[""ProjectBudget""].Value == null))");
ISpace["Message"].Value=@"Please enter Project Budget";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please enter Project Budget"";");
return;
base.WriteDebugInfo(@"return;");
}
if(ISpace["TypeOfProject"].Value=="450")
{
base.WriteDebugInfo(@"if(ISpace[""TypeOfProject""].Value==""450"")");
if(IsNullOrEmpty(ISpace["Currency"].Value))
{
base.WriteDebugInfo(@"if(IsNullOrEmpty(ISpace[""Currency""].Value))");
ISpace["Message"].Value=@"Please select Currency type";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please select Currency type"";");
return;
base.WriteDebugInfo(@"return;");
}
if(ISpace["ProjectBudget"].Value==0)
{
base.WriteDebugInfo(@"if(ISpace[""ProjectBudget""].Value==0)");
ISpace["Message"].Value=@"Please enter project budget";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please enter project budget"";");
return;
base.WriteDebugInfo(@"return;");
}
if(1==2&&ISpace["IntExpense"].Value==0)
{
base.WriteDebugInfo(@"if(1==2&&ISpace[""IntExpense""].Value==0)");
ISpace["Message"].Value=@"Please enter Exchange Rate";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please enter Exchange Rate"";");
return;
base.WriteDebugInfo(@"return;");
}
if(1==2&&ISpace["IntAmount"].Value==0)
{
base.WriteDebugInfo(@"if(1==2&&ISpace[""IntAmount""].Value==0)");
ISpace["Message"].Value=@"Please enter Amount";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please enter Amount"";");
return;
base.WriteDebugInfo(@"return;");
}
}
if(ISpace["TypeOfProject"].Value=="449")
{
base.WriteDebugInfo(@"if(ISpace[""TypeOfProject""].Value==""449"")");
if(ISpace["ProjectBudget"].Value==0)
{
base.WriteDebugInfo(@"if(ISpace[""ProjectBudget""].Value==0)");
ISpace["Message"].Value=@"Please enter project budget";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please enter project budget"";");
return;
base.WriteDebugInfo(@"return;");
}
}
if(1==2&&IsNullOrEmpty(ISpace["FundReceiptMode"].Value))
{
base.WriteDebugInfo(@"if(1==2&&IsNullOrEmpty(ISpace[""FundReceiptMode""].Value))");
ISpace["Message"].Value=@"Please select Fund Receipt Mode";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please select Fund Receipt Mode"";");
return;
base.WriteDebugInfo(@"return;");
}
if(1==2&&ISpace["FundReceiptMode"].Value=="451")
{
base.WriteDebugInfo(@"if(1==2&&ISpace[""FundReceiptMode""].Value==""451"")");
if(IsNullOrEmpty(ISpace["SchemeType"].Value))
{
base.WriteDebugInfo(@"if(IsNullOrEmpty(ISpace[""SchemeType""].Value))");
ISpace["Message"].Value=@"Please select Scheme Type";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please select Scheme Type"";");
return;
base.WriteDebugInfo(@"return;");
}
}
if(IsNullOrEmpty(ISpace["Duration"].Value))
{
base.WriteDebugInfo(@"if(IsNullOrEmpty(ISpace[""Duration""].Value))");
ISpace["Message"].Value=@"Please Select Duration";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please Select Duration"";");
return;
base.WriteDebugInfo(@"return;");
}
if(IsNullOrEmpty(ISpace["MonthYear"].Value))
{
base.WriteDebugInfo(@"if(IsNullOrEmpty(ISpace[""MonthYear""].Value))");
ISpace["Message"].Value=@"Please select Month/Year";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please select Month/Year"";");
return;
base.WriteDebugInfo(@"return;");
}
if(IsNullOrEmpty(ISpace["Sector"].Value))
{
base.WriteDebugInfo(@"if(IsNullOrEmpty(ISpace[""Sector""].Value))");
ISpace["Message"].Value=@"Please fill the sector field.";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please fill the sector field."";");
return;
base.WriteDebugInfo(@"return;");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["MonthYear"].Value=="1")
{
base.WriteDebugInfo(@"if(ISpace[""MonthYear""].Value==""1"")");
ISpace["Duration"].Value=RegularExpression(ISpace["Duration"].Value,"^(?:[0-9]|[1-9][0-9]|1[0-8][0-9]|19[0-9])$","0");
base.WriteDebugInfo(@"ISpace[""Duration""].Value=RegularExpression(ISpace[""Duration""].Value,""^(?:[0-9]|[1-9][0-9]|1[0-8][0-9]|19[0-9])$"",""0"");");
if(ISpace["Duration"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""Duration""].Value=="""")");
ISpace["Message"].Value=@"Please enter a valid number of months.";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please enter a valid number of months."";");
return;
base.WriteDebugInfo(@"return;");
}
}
if(ISpace["MonthYear"].Value=="2")
{
base.WriteDebugInfo(@"if(ISpace[""MonthYear""].Value==""2"")");
ISpace["Duration"].Value=RegularExpression(ISpace["Duration"].Value,"^(?:0|0?[1-9]|10|11|12)$","0");
base.WriteDebugInfo(@"ISpace[""Duration""].Value=RegularExpression(ISpace[""Duration""].Value,""^(?:0|0?[1-9]|10|11|12)$"",""0"");");
if(ISpace["Duration"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""Duration""].Value=="""")");
ISpace["Message"].Value=@"Please enter a valid number of Year.";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please enter a valid number of Year."";");
return;
base.WriteDebugInfo(@"return;");
}
}
}
if(ISpace["ActiveEdit"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""ActiveEdit""].Value==1)");
ISpace["Reappropriation"].Visible="true";
base.WriteDebugInfo(@"ISpace[""Reappropriation""].Visible=""true"";");
ISpace["Year11"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""Year11""].Enbl=""false"";");
}
if(ISpace["FormVersionId"].Value=="EB102E80-C3DC-4EB9-8511-B1018E342530")
{
ISpace["UI_Tab"].Visible="true";
}if(ISpace["FormVersionId"].Value=="EB102E80-C3DC-4EB9-8511-B1018E342530")
{
ISpace["UI_SecondRow"].Visible="true";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""EB102E80-C3DC-4EB9-8511-B1018E342530"")
{
ISpace[""UI_Tab""].Visible=""true"";
}if(ISpace[""FormVersionId""].Value==""EB102E80-C3DC-4EB9-8511-B1018E342530"")
{
ISpace[""UI_SecondRow""].Visible=""true"";
}");
if(ISpace["FormVersionId"].Value=="EB102E80-C3DC-4EB9-8511-B1018E342530")
{
ISpace["UI_FirstRow"].Visible="false";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""EB102E80-C3DC-4EB9-8511-B1018E342530"")
{
ISpace[""UI_FirstRow""].Visible=""false"";
}");
if(ISpace["FormVersionId"].Value=="EB102E80-C3DC-4EB9-8511-B1018E342530")
{
ISpace["UI_DuplicatePanel"].Visible="true";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""EB102E80-C3DC-4EB9-8511-B1018E342530"")
{
ISpace[""UI_DuplicatePanel""].Visible=""true"";
}");
if(ISpace["FormVersionId"].Value=="EB102E80-C3DC-4EB9-8511-B1018E342530")
{
ISpace["UI_Income"].Visible="false";
}if(ISpace["FormVersionId"].Value=="EB102E80-C3DC-4EB9-8511-B1018E342530")
{
ISpace["UI_Expenditure"].Visible="false";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""EB102E80-C3DC-4EB9-8511-B1018E342530"")
{
ISpace[""UI_Income""].Visible=""false"";
}if(ISpace[""FormVersionId""].Value==""EB102E80-C3DC-4EB9-8511-B1018E342530"")
{
ISpace[""UI_Expenditure""].Visible=""false"";
}");
if(ISpace["FormVersionId"].Value=="EB102E80-C3DC-4EB9-8511-B1018E342530")
{
ISpace["UI_Row"].Visible="true";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""EB102E80-C3DC-4EB9-8511-B1018E342530"")
{
ISpace[""UI_Row""].Visible=""true"";
}");
ISpace["CoPiDetails"].Visible="true";
base.WriteDebugInfo(@"ISpace[""CoPiDetails""].Visible=""true"";");
if(ISpace["FormVersionId"].Value=="EB102E80-C3DC-4EB9-8511-B1018E342530")
{
ISpace["UI_EIColumn"].Visible="false";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""EB102E80-C3DC-4EB9-8511-B1018E342530"")
{
ISpace[""UI_EIColumn""].Visible=""false"";
}");
if(ISpace["ProjectRefNo"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""ProjectRefNo""].Value=="""")");
base.WriteDebugInfo(@"EXEC [GenerateTemproryProjectCode] '#EmpCode','#EmpDeptCode','#ID1','#ProjectCategory'");

var querySource20D9A82D1FC544DF93674FD5D55CF5CD =GetQueryExpressionDataSource("20D9A82D-1FC5-44DF-9367-4FD5D55CF5CD");
Dictionary<short,object> result20D9A82D1FC544DF93674FD5D55CF5CD=iSpace.ExecuteQuery(querySource20D9A82D1FC544DF93674FD5D55CF5CD,@"EXEC [GenerateTemproryProjectCode] '" + ISpace["EmpCode"].Value + @"','" + ISpace["EmpDeptCode"].Value + @"','" + ISpace["ID1"].Value + @"','" + ISpace["ProjectCategory"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource20D9A82D1FC544DF93674FD5D55CF5CD =GetQueryExpressionDataSource(""20D9A82D-1FC5-44DF-9367-4FD5D55CF5CD"");Dictionary<short,object> result20D9A82D1FC544DF93674FD5D55CF5CD=iSpace.ExecuteQuery(querySource20D9A82D1FC544DF93674FD5D55CF5CD,@""EXEC [GenerateTemproryProjectCode] '"" + ISpace[""EmpCode""].Value + @""','"" + ISpace[""EmpDeptCode""].Value + @""','"" + ISpace[""ID1""].Value + @""','"" + ISpace[""ProjectCategory""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result20D9A82D1FC544DF93674FD5D55CF5CD!=null) && (result20D9A82D1FC544DF93674FD5D55CF5CD.Count!=0))
{
if(result20D9A82D1FC544DF93674FD5D55CF5CD.ContainsKey(0))
ISpace["ProjectRefNo"].Value = result20D9A82D1FC544DF93674FD5D55CF5CD[0];
}
else{
ISpace["ProjectRefNo"].Value = null;
}
}
if(ISpace["ProjectStatus"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""ProjectStatus""].Value=="""")");
ISpace["ProjectStatus"].Value="6";
base.WriteDebugInfo(@"ISpace[""ProjectStatus""].Value=""6"";");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"Entering DomainDataMap for Project Creation main Domain");
var ProjectCreationmainDomain_repoObj = new RepositoryMapper(DbTypes.SQLServer);


var CreateProjectDetailsProjectCreationmainDomaintableObj = new RepositoryTable("CreateProjectDetails");
  CreateProjectDetailsProjectCreationmainDomaintableObj.AppConnectionSettingsId  ="40BDEB14-07CC-4150-8A52-9B088A428E2D";CreateProjectDetailsProjectCreationmainDomaintableObj.ProofConnectionId = "C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0)";
var ProjectCreationmainDomain_CreateProjectDetails_rows = GetElementClientData(ISpace["InstanceId"].Value,"A83D8B17-78DB-4B11-86C7-91E3F9A7C20E");

if(ProjectCreationmainDomain_CreateProjectDetails_rows!=null && ProjectCreationmainDomain_CreateProjectDetails_rows.Count>0){
var ProjectCreationmainDomain_CreateProjectDetails_rowsObj = new List<RepositoryRow>();
foreach(var rows in ProjectCreationmainDomain_CreateProjectDetails_rows){RepositoryRow repositoryRowObj = null;string elementData = null;RepositoryColumn repositoryColumnObj = null;if(rows !=null){ var CreateProjectDetails_colObj = new List<RepositoryColumn>();repositoryRowObj= new RepositoryRow();//var myByte = (byte)rowData.Value.RwSt;//repositoryRowObj.RowState=(RepositoryRowState)myByte;

if(rows.ContainsKey("B596DD9F-8B75-44EB-BB37-C2D6093E21E7"))     elementData = rows["B596DD9F-8B75-44EB-BB37-C2D6093E21E7"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"EmployeeBasicInfoId",false,false,9);
if(repositoryColumnObj!=null)CreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-EmpEmployeeBasicId not found");}

if(rows.ContainsKey("A0211921-0B97-43E9-BA6F-BC50F482EA7E"))     elementData = rows["A0211921-0B97-43E9-BA6F-BC50F482EA7E"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Sector",false,false,9);
if(repositoryColumnObj!=null)CreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Sector not found");}

if(rows.ContainsKey("603DB6A8-112F-4544-A47D-43751477076A"))     elementData = rows["603DB6A8-112F-4544-A47D-43751477076A"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"IsSubmitted",false,false,5);
if(repositoryColumnObj!=null)CreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-IsSubmit not found");}

if(rows.ContainsKey("02A5B4F7-1A0C-4581-81E9-AE79F5083293"))     elementData = rows["02A5B4F7-1A0C-4581-81E9-AE79F5083293"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Overhead",false,false,5);
if(repositoryColumnObj!=null)CreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Overheads not found");}

if(rows.ContainsKey("B705855C-3908-41FF-998E-EA6B24909F0F"))     elementData = rows["B705855C-3908-41FF-998E-EA6B24909F0F"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"IfManpower",false,false,0);
if(repositoryColumnObj!=null)CreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-ManPowerRequired not found");}

if(rows.ContainsKey("2D32F409-3FDD-44BB-BBA2-5862F0432078"))     elementData = rows["2D32F409-3FDD-44BB-BBA2-5862F0432078"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ProjectType",false,false,9);
if(repositoryColumnObj!=null)CreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-TypeOfProject not found");}

if(rows.ContainsKey("DF847FA7-3DC4-4124-A2E2-46A7B91F0776"))     elementData = rows["DF847FA7-3DC4-4124-A2E2-46A7B91F0776"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"SanctionedDate",false,false,8);
if(repositoryColumnObj!=null)CreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-SanctionDate not found");}

if(rows.ContainsKey("97AE1937-023A-4A40-807F-74C57599806C"))     elementData = rows["97AE1937-023A-4A40-807F-74C57599806C"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"NonRecurringAmount",false,false,3);
if(repositoryColumnObj!=null)CreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-NonRecurringAmount not found");}

if(rows.ContainsKey("3D79FD45-F4C9-4111-9D02-BA7B50CE754E"))     elementData = rows["3D79FD45-F4C9-4111-9D02-BA7B50CE754E"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ProjectproposalID",false,false,9);
if(repositoryColumnObj!=null)CreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-ProjectProposal not found");}

if(rows.ContainsKey("E6D44C17-A165-46AE-80FD-96EBC9629057"))     elementData = rows["E6D44C17-A165-46AE-80FD-96EBC9629057"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"IsExternalIns",false,false,0);
if(repositoryColumnObj!=null)CreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-IfExternalIns not found");}

if(rows.ContainsKey("7BD98942-3580-45F3-9030-7226534C37E1"))     elementData = rows["7BD98942-3580-45F3-9030-7226534C37E1"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Designation",false,false,9);
if(repositoryColumnObj!=null)CreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Designation not found");}

if(rows.ContainsKey("604D4AFD-8CB5-47F6-AAF4-CBED4D7E845D"))     elementData = rows["604D4AFD-8CB5-47F6-AAF4-CBED4D7E845D"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"FundingAgency",false,false,9);
if(repositoryColumnObj!=null)CreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-FundingAcencyName not found");}

if(rows.ContainsKey("7E6249C4-87FC-4119-93B4-404EB37B5D90"))     elementData = rows["7E6249C4-87FC-4119-93B4-404EB37B5D90"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"DepartmentID",false,false,9);
if(repositoryColumnObj!=null)CreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-EmpDepartment not found");}

if(rows.ContainsKey("BC6C053E-0BA2-4200-A0C5-C0EF25B21E2E"))     elementData = rows["BC6C053E-0BA2-4200-A0C5-C0EF25B21E2E"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"RecurringAmount",false,false,3);
if(repositoryColumnObj!=null)CreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-RecurringAmount not found");}

if(rows.ContainsKey("3F3D8917-5954-4C1D-AE68-83C060BB2F32"))     elementData = rows["3F3D8917-5954-4C1D-AE68-83C060BB2F32"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"IfEquipment",false,false,0);
if(repositoryColumnObj!=null)CreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-IFEquipment not found");}

if(rows.ContainsKey("E18A3F8F-76E5-42F2-ABFD-44826B509A29"))     elementData = rows["E18A3F8F-76E5-42F2-ABFD-44826B509A29"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ProjectStatus",false,false,9);
if(repositoryColumnObj!=null)CreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-ProjectStatus not found");}

if(rows.ContainsKey("CA004F50-713B-4AC6-A2AE-DBA4ECDBC578"))     elementData = rows["CA004F50-713B-4AC6-A2AE-DBA4ECDBC578"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ProjectName",false,false,9);
if(repositoryColumnObj!=null)CreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-ProjectName not found");}

if(rows.ContainsKey("CC0BFF91-E6F2-488C-85F2-E16AE98B8BAC"))     elementData = rows["CC0BFF91-E6F2-488C-85F2-E16AE98B8BAC"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"SchemeID",false,false,9);
if(repositoryColumnObj!=null)CreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-SchemeType not found");}

elementData = ISpace["gv_UserId"].Value != null? Convert.ToString(ISpace["gv_UserId"].Value):null ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"UpdatedBy",false,false,6);
if(repositoryColumnObj!=null)CreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-gv_UserId not found");}

if(rows.ContainsKey("0C386A8C-8A37-4559-8464-99855AE81313"))     elementData = rows["0C386A8C-8A37-4559-8464-99855AE81313"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ProjectRefNo",false,false,9);
if(repositoryColumnObj!=null)CreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-ProjectRefNo not found");}

if(rows.ContainsKey("BE1036BA-08CB-4EAC-BEF2-ECADE4084677"))     elementData = rows["BE1036BA-08CB-4EAC-BEF2-ECADE4084677"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Duration",false,false,9);
if(repositoryColumnObj!=null)CreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Duration not found");}

if(rows.ContainsKey("0A6B19A9-6384-4BF3-A9CB-C1A0C675262E"))     elementData = rows["0A6B19A9-6384-4BF3-A9CB-C1A0C675262E"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"SanctionedNumber",false,false,9);
if(repositoryColumnObj!=null)CreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-SanctionNumber not found");}

if(rows.ContainsKey("49074D93-7C7F-401F-AD44-0BB2B5353FE3"))     elementData = rows["49074D93-7C7F-401F-AD44-0BB2B5353FE3"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"InstanceId",true,false,9);
if(repositoryColumnObj!=null)CreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-ID1 not found");}

if(rows.ContainsKey("6D38109B-0A12-40CA-8D51-C0313B482B1F"))     elementData = rows["6D38109B-0A12-40CA-8D51-C0313B482B1F"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ProjectDetailsID",false,true,6);
if(repositoryColumnObj!=null)CreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-ProjectDetailsID not found");}

if(rows.ContainsKey("153737E5-6626-4A69-8501-4AAD946A634A"))     elementData = rows["153737E5-6626-4A69-8501-4AAD946A634A"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"BudgetTotalAmount",false,false,3);
if(repositoryColumnObj!=null)CreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-OverallBudgetTotal not found");}

if(rows.ContainsKey("CBBFAC58-1A83-448A-8F84-B58A0C1C7F6A"))     elementData = rows["CBBFAC58-1A83-448A-8F84-B58A0C1C7F6A"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"YearMonth",false,false,9);
if(repositoryColumnObj!=null)CreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MonthYear not found");}

elementData = CurrentDate().ToString() ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"UpdatedOn",false,false,8);
if(repositoryColumnObj!=null)CreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-CurrentDate not found");}

if(rows.ContainsKey("F63FA021-DA22-44C2-A63A-11A0E2BED913"))     elementData = rows["F63FA021-DA22-44C2-A63A-11A0E2BED913"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"FinancialYearID",false,false,9);
if(repositoryColumnObj!=null)CreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-FinancialYear not found");}

if(rows.ContainsKey("7E613FAC-8E27-4D91-99B7-3848167B6B99"))     elementData = rows["7E613FAC-8E27-4D91-99B7-3848167B6B99"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"FundReceiptMode",false,false,9);
if(repositoryColumnObj!=null)CreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-FundReceiptMode not found");}

if(rows.ContainsKey("6D31749B-2D20-4B17-9A41-596770A56EB3"))     elementData = rows["6D31749B-2D20-4B17-9A41-596770A56EB3"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"DocumentComments",false,false,9);
if(repositoryColumnObj!=null)CreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-DocumentComments not found");}

if(rows.ContainsKey("1CA31193-A9A8-476E-A3FF-F75133B5BDEC"))     elementData = rows["1CA31193-A9A8-476E-A3FF-F75133B5BDEC"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ToDate",false,false,8);
if(repositoryColumnObj!=null)CreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-EndDate not found");}

if(rows.ContainsKey("9FBC7606-B59A-4DF4-B8F4-DC997BA82B1E"))     elementData = rows["9FBC7606-B59A-4DF4-B8F4-DC997BA82B1E"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ProjectBudget",false,false,3);
if(repositoryColumnObj!=null)CreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-ProjectBudget not found");}

if(rows.ContainsKey("92864610-6CBD-4533-BB18-A07F02B8C329"))     elementData = rows["92864610-6CBD-4533-BB18-A07F02B8C329"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"FromDate",false,false,8);
if(repositoryColumnObj!=null)CreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-StartDate not found");}

if(rows.ContainsKey("40BFB2D7-C4A2-4DB5-8080-2DF9DD44B713"))     elementData = rows["40BFB2D7-C4A2-4DB5-8080-2DF9DD44B713"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"PrincipalInvestigator",false,false,9);
if(repositoryColumnObj!=null)CreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-PrincipleInvestigator not found");}

if(rows.ContainsKey("A417D0C0-3A5C-48E6-8692-DF7FC6E78987"))     elementData = rows["A417D0C0-3A5C-48E6-8692-DF7FC6E78987"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ProjectCategoryID",false,false,9);
if(repositoryColumnObj!=null)CreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-ProjectCategory not found");}
repositoryRowObj.Columns=CreateProjectDetails_colObj;
ProjectCreationmainDomain_CreateProjectDetails_rowsObj.Add(repositoryRowObj);
}}

CreateProjectDetailsProjectCreationmainDomaintableObj.Rows=ProjectCreationmainDomain_CreateProjectDetails_rowsObj;
var ProjectCreationmainDomain_repoObj_status_CreateProjectDetails = ProjectCreationmainDomain_repoObj.Execute(DomainOperationTypes.CreateOrUpdate,ref CreateProjectDetailsProjectCreationmainDomaintableObj);if(!ProjectCreationmainDomain_repoObj_status_CreateProjectDetails) throw new Exception("Error in Execute Domain Data Map");}
base.WriteDebugInfo(@"Exiting DomainDataMap for Project Creation main Domain");
base.WriteDebugInfo(@"Entering DomainDataMap for Currency table domain");
var Currencytabledomain_repoObj = new RepositoryMapper(DbTypes.SQLServer);


var CurrencyExchangeRateCurrencytabledomaintableObj = new RepositoryTable("CurrencyExchangeRate");
  CurrencyExchangeRateCurrencytabledomaintableObj.AppConnectionSettingsId  ="CA34B07F-5D19-412F-A39F-3ADA64B5E0C0";CurrencyExchangeRateCurrencytabledomaintableObj.ProofConnectionId = "C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0)";
var Currencytabledomain_CurrencyExchangeRate_rows = GetElementClientData(ISpace["InstanceId"].Value,"A83D8B17-78DB-4B11-86C7-91E3F9A7C20E");

if(Currencytabledomain_CurrencyExchangeRate_rows!=null && Currencytabledomain_CurrencyExchangeRate_rows.Count>0){
var Currencytabledomain_CurrencyExchangeRate_rowsObj = new List<RepositoryRow>();
foreach(var rows in Currencytabledomain_CurrencyExchangeRate_rows){RepositoryRow repositoryRowObj = null;string elementData = null;RepositoryColumn repositoryColumnObj = null;if(rows !=null){ var CurrencyExchangeRate_colObj = new List<RepositoryColumn>();repositoryRowObj= new RepositoryRow();//var myByte = (byte)rowData.Value.RwSt;//repositoryRowObj.RowState=(RepositoryRowState)myByte;

if(rows.ContainsKey("7FAEDF9A-E059-4E1C-A9F4-DB63BE02491F"))     elementData = rows["7FAEDF9A-E059-4E1C-A9F4-DB63BE02491F"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Currencytype",false,false,9);
if(repositoryColumnObj!=null)CurrencyExchangeRate_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Currency not found");}

if(rows.ContainsKey("49074D93-7C7F-401F-AD44-0BB2B5353FE3"))     elementData = rows["49074D93-7C7F-401F-AD44-0BB2B5353FE3"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ProjectDetailsId",true,false,9);
if(repositoryColumnObj!=null)CurrencyExchangeRate_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-ID1 not found");}

if(rows.ContainsKey("9FBC7606-B59A-4DF4-B8F4-DC997BA82B1E"))     elementData = rows["9FBC7606-B59A-4DF4-B8F4-DC997BA82B1E"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"TotalAmount",false,false,3);
if(repositoryColumnObj!=null)CurrencyExchangeRate_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-ProjectBudget not found");}

if(rows.ContainsKey("1738AC0A-46E5-4AF3-AFC8-D96A1823B592"))     elementData = rows["1738AC0A-46E5-4AF3-AFC8-D96A1823B592"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Amount",false,false,3);
if(repositoryColumnObj!=null)CurrencyExchangeRate_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-IntAmount not found");}

if(rows.ContainsKey("767F8CE7-FD77-486B-92C2-4F8F0CB717C7"))     elementData = rows["767F8CE7-FD77-486B-92C2-4F8F0CB717C7"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ExchangeRate",false,false,3);
if(repositoryColumnObj!=null)CurrencyExchangeRate_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-IntExpense not found");}
repositoryRowObj.Columns=CurrencyExchangeRate_colObj;
Currencytabledomain_CurrencyExchangeRate_rowsObj.Add(repositoryRowObj);
}}

CurrencyExchangeRateCurrencytabledomaintableObj.Rows=Currencytabledomain_CurrencyExchangeRate_rowsObj;
var Currencytabledomain_repoObj_status_CurrencyExchangeRate = Currencytabledomain_repoObj.Execute(DomainOperationTypes.CreateOrUpdate,ref CurrencyExchangeRateCurrencytabledomaintableObj);if(!Currencytabledomain_repoObj_status_CurrencyExchangeRate) throw new Exception("Error in Execute Domain Data Map");}
base.WriteDebugInfo(@"Exiting DomainDataMap for Currency table domain");
}
if(ISpace["TypeOfProject"].Value=="450")
{
base.WriteDebugInfo(@"if(ISpace[""TypeOfProject""].Value==""450"")");
base.WriteDebugInfo(@"Entering DomainDataMap for Currency table domain");
var Currencytabledomain_repoObj = new RepositoryMapper(DbTypes.SQLServer);


var CurrencyExchangeRateCurrencytabledomaintableObj = new RepositoryTable("CurrencyExchangeRate");
  CurrencyExchangeRateCurrencytabledomaintableObj.AppConnectionSettingsId  ="CA34B07F-5D19-412F-A39F-3ADA64B5E0C0";CurrencyExchangeRateCurrencytabledomaintableObj.ProofConnectionId = "C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0)";
var Currencytabledomain_CurrencyExchangeRate_rows = GetElementClientData(ISpace["InstanceId"].Value,"A83D8B17-78DB-4B11-86C7-91E3F9A7C20E");

if(Currencytabledomain_CurrencyExchangeRate_rows!=null && Currencytabledomain_CurrencyExchangeRate_rows.Count>0){
var Currencytabledomain_CurrencyExchangeRate_rowsObj = new List<RepositoryRow>();
foreach(var rows in Currencytabledomain_CurrencyExchangeRate_rows){RepositoryRow repositoryRowObj = null;string elementData = null;RepositoryColumn repositoryColumnObj = null;if(rows !=null){ var CurrencyExchangeRate_colObj = new List<RepositoryColumn>();repositoryRowObj= new RepositoryRow();//var myByte = (byte)rowData.Value.RwSt;//repositoryRowObj.RowState=(RepositoryRowState)myByte;

if(rows.ContainsKey("7FAEDF9A-E059-4E1C-A9F4-DB63BE02491F"))     elementData = rows["7FAEDF9A-E059-4E1C-A9F4-DB63BE02491F"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Currencytype",false,false,9);
if(repositoryColumnObj!=null)CurrencyExchangeRate_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Currency not found");}

if(rows.ContainsKey("49074D93-7C7F-401F-AD44-0BB2B5353FE3"))     elementData = rows["49074D93-7C7F-401F-AD44-0BB2B5353FE3"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ProjectDetailsId",true,false,9);
if(repositoryColumnObj!=null)CurrencyExchangeRate_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-ID1 not found");}

if(rows.ContainsKey("9FBC7606-B59A-4DF4-B8F4-DC997BA82B1E"))     elementData = rows["9FBC7606-B59A-4DF4-B8F4-DC997BA82B1E"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"TotalAmount",false,false,3);
if(repositoryColumnObj!=null)CurrencyExchangeRate_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-ProjectBudget not found");}

if(rows.ContainsKey("1738AC0A-46E5-4AF3-AFC8-D96A1823B592"))     elementData = rows["1738AC0A-46E5-4AF3-AFC8-D96A1823B592"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Amount",false,false,3);
if(repositoryColumnObj!=null)CurrencyExchangeRate_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-IntAmount not found");}

if(rows.ContainsKey("767F8CE7-FD77-486B-92C2-4F8F0CB717C7"))     elementData = rows["767F8CE7-FD77-486B-92C2-4F8F0CB717C7"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ExchangeRate",false,false,3);
if(repositoryColumnObj!=null)CurrencyExchangeRate_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-IntExpense not found");}
repositoryRowObj.Columns=CurrencyExchangeRate_colObj;
Currencytabledomain_CurrencyExchangeRate_rowsObj.Add(repositoryRowObj);
}}

CurrencyExchangeRateCurrencytabledomaintableObj.Rows=Currencytabledomain_CurrencyExchangeRate_rowsObj;
var Currencytabledomain_repoObj_status_CurrencyExchangeRate = Currencytabledomain_repoObj.Execute(DomainOperationTypes.CreateOrUpdate,ref CurrencyExchangeRateCurrencytabledomaintableObj);if(!Currencytabledomain_repoObj_status_CurrencyExchangeRate) throw new Exception("Error in Execute Domain Data Map");}
base.WriteDebugInfo(@"Exiting DomainDataMap for Currency table domain");
}
if(ISpace["ActiveEdit"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""ActiveEdit""].Value==1)");
ISpace["ProjectStatus"].Value="24";
base.WriteDebugInfo(@"ISpace[""ProjectStatus""].Value=""24"";");
}
if(ISpace["ActiveEdit"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""ActiveEdit""].Value==1)");
base.WriteDebugInfo(@"Entering DomainDataMap for TempCreatemainDomain");
var TempCreatemainDomain_repoObj = new RepositoryMapper(DbTypes.SQLServer);


var TempCreateProjectDetailsTempCreatemainDomaintableObj = new RepositoryTable("TempCreateProjectDetails");
  TempCreateProjectDetailsTempCreatemainDomaintableObj.AppConnectionSettingsId  ="CA34B07F-5D19-412F-A39F-3ADA64B5E0C0";TempCreateProjectDetailsTempCreatemainDomaintableObj.ProofConnectionId = "C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0)";
var TempCreatemainDomain_TempCreateProjectDetails_rows = GetElementClientData(ISpace["InstanceId"].Value,"A83D8B17-78DB-4B11-86C7-91E3F9A7C20E");

if(TempCreatemainDomain_TempCreateProjectDetails_rows!=null && TempCreatemainDomain_TempCreateProjectDetails_rows.Count>0){
var TempCreatemainDomain_TempCreateProjectDetails_rowsObj = new List<RepositoryRow>();
foreach(var rows in TempCreatemainDomain_TempCreateProjectDetails_rows){RepositoryRow repositoryRowObj = null;string elementData = null;RepositoryColumn repositoryColumnObj = null;if(rows !=null){ var TempCreateProjectDetails_colObj = new List<RepositoryColumn>();repositoryRowObj= new RepositoryRow();//var myByte = (byte)rowData.Value.RwSt;//repositoryRowObj.RowState=(RepositoryRowState)myByte;

if(rows.ContainsKey("153737E5-6626-4A69-8501-4AAD946A634A"))     elementData = rows["153737E5-6626-4A69-8501-4AAD946A634A"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"BudgetTotalAmount",false,false,3);
if(repositoryColumnObj!=null)TempCreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-OverallBudgetTotal not found");}

if(rows.ContainsKey("0A6B19A9-6384-4BF3-A9CB-C1A0C675262E"))     elementData = rows["0A6B19A9-6384-4BF3-A9CB-C1A0C675262E"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"SanctionedNumber",false,false,9);
if(repositoryColumnObj!=null)TempCreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-SanctionNumber not found");}

if(rows.ContainsKey("A417D0C0-3A5C-48E6-8692-DF7FC6E78987"))     elementData = rows["A417D0C0-3A5C-48E6-8692-DF7FC6E78987"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ProjectCategoryID",false,false,9);
if(repositoryColumnObj!=null)TempCreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-ProjectCategory not found");}

if(rows.ContainsKey("604D4AFD-8CB5-47F6-AAF4-CBED4D7E845D"))     elementData = rows["604D4AFD-8CB5-47F6-AAF4-CBED4D7E845D"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"FundingAgency",false,false,9);
if(repositoryColumnObj!=null)TempCreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-FundingAcencyName not found");}

if(rows.ContainsKey("7BD98942-3580-45F3-9030-7226534C37E1"))     elementData = rows["7BD98942-3580-45F3-9030-7226534C37E1"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Designation",false,false,9);
if(repositoryColumnObj!=null)TempCreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Designation not found");}

if(rows.ContainsKey("3F3D8917-5954-4C1D-AE68-83C060BB2F32"))     elementData = rows["3F3D8917-5954-4C1D-AE68-83C060BB2F32"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"IfEquipment",false,false,0);
if(repositoryColumnObj!=null)TempCreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-IFEquipment not found");}

if(rows.ContainsKey("6D31749B-2D20-4B17-9A41-596770A56EB3"))     elementData = rows["6D31749B-2D20-4B17-9A41-596770A56EB3"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"DocumentComments",false,false,9);
if(repositoryColumnObj!=null)TempCreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-DocumentComments not found");}

if(rows.ContainsKey("2833427C-A5F6-43D0-9A15-E33760BA7E46"))     elementData = rows["2833427C-A5F6-43D0-9A15-E33760BA7E46"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"TempInstanceid",true,false,9);
if(repositoryColumnObj!=null)TempCreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-TempInstanceID not found");}

if(rows.ContainsKey("E34D4CE7-E649-41FB-9D89-64C11CA65EF3"))     elementData = rows["E34D4CE7-E649-41FB-9D89-64C11CA65EF3"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ProjectCode",false,false,9);
if(repositoryColumnObj!=null)TempCreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-ProjectCode not found");}

if(rows.ContainsKey("40BFB2D7-C4A2-4DB5-8080-2DF9DD44B713"))     elementData = rows["40BFB2D7-C4A2-4DB5-8080-2DF9DD44B713"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"PrincipalInvestigator",false,false,9);
if(repositoryColumnObj!=null)TempCreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-PrincipleInvestigator not found");}

if(rows.ContainsKey("6D38109B-0A12-40CA-8D51-C0313B482B1F"))     elementData = rows["6D38109B-0A12-40CA-8D51-C0313B482B1F"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ProjectDetailsID",false,true,6);
if(repositoryColumnObj!=null)TempCreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-ProjectDetailsID not found");}

if(rows.ContainsKey("7E6249C4-87FC-4119-93B4-404EB37B5D90"))     elementData = rows["7E6249C4-87FC-4119-93B4-404EB37B5D90"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"DepartmentID",false,false,9);
if(repositoryColumnObj!=null)TempCreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-EmpDepartment not found");}

if(rows.ContainsKey("02A5B4F7-1A0C-4581-81E9-AE79F5083293"))     elementData = rows["02A5B4F7-1A0C-4581-81E9-AE79F5083293"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Overhead",false,false,5);
if(repositoryColumnObj!=null)TempCreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Overheads not found");}

if(rows.ContainsKey("DF847FA7-3DC4-4124-A2E2-46A7B91F0776"))     elementData = rows["DF847FA7-3DC4-4124-A2E2-46A7B91F0776"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"SanctionedDate",false,false,8);
if(repositoryColumnObj!=null)TempCreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-SanctionDate not found");}

if(rows.ContainsKey("F63FA021-DA22-44C2-A63A-11A0E2BED913"))     elementData = rows["F63FA021-DA22-44C2-A63A-11A0E2BED913"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"FinancialYearID",false,false,9);
if(repositoryColumnObj!=null)TempCreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-FinancialYear not found");}

if(rows.ContainsKey("603DB6A8-112F-4544-A47D-43751477076A"))     elementData = rows["603DB6A8-112F-4544-A47D-43751477076A"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"IsSubmitted",false,false,5);
if(repositoryColumnObj!=null)TempCreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-IsSubmit not found");}

if(rows.ContainsKey("49074D93-7C7F-401F-AD44-0BB2B5353FE3"))     elementData = rows["49074D93-7C7F-401F-AD44-0BB2B5353FE3"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"InstanceId",false,false,9);
if(repositoryColumnObj!=null)TempCreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-ID1 not found");}

if(rows.ContainsKey("E6D44C17-A165-46AE-80FD-96EBC9629057"))     elementData = rows["E6D44C17-A165-46AE-80FD-96EBC9629057"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"IsExternalIns",false,false,0);
if(repositoryColumnObj!=null)TempCreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-IfExternalIns not found");}

if(rows.ContainsKey("92864610-6CBD-4533-BB18-A07F02B8C329"))     elementData = rows["92864610-6CBD-4533-BB18-A07F02B8C329"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"FromDate",false,false,8);
if(repositoryColumnObj!=null)TempCreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-StartDate not found");}

if(rows.ContainsKey("7E613FAC-8E27-4D91-99B7-3848167B6B99"))     elementData = rows["7E613FAC-8E27-4D91-99B7-3848167B6B99"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"FundReceiptMode",false,false,9);
if(repositoryColumnObj!=null)TempCreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-FundReceiptMode not found");}

if(rows.ContainsKey("A0211921-0B97-43E9-BA6F-BC50F482EA7E"))     elementData = rows["A0211921-0B97-43E9-BA6F-BC50F482EA7E"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Sector",false,false,9);
if(repositoryColumnObj!=null)TempCreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Sector not found");}

if(rows.ContainsKey("CBBFAC58-1A83-448A-8F84-B58A0C1C7F6A"))     elementData = rows["CBBFAC58-1A83-448A-8F84-B58A0C1C7F6A"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"YearMonth",false,false,9);
if(repositoryColumnObj!=null)TempCreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MonthYear not found");}

if(rows.ContainsKey("9FBC7606-B59A-4DF4-B8F4-DC997BA82B1E"))     elementData = rows["9FBC7606-B59A-4DF4-B8F4-DC997BA82B1E"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ProjectBudget",false,false,3);
if(repositoryColumnObj!=null)TempCreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-ProjectBudget not found");}

if(rows.ContainsKey("BE1036BA-08CB-4EAC-BEF2-ECADE4084677"))     elementData = rows["BE1036BA-08CB-4EAC-BEF2-ECADE4084677"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Duration",false,false,9);
if(repositoryColumnObj!=null)TempCreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Duration not found");}

elementData = ISpace["gv_UserId"].Value != null? Convert.ToString(ISpace["gv_UserId"].Value):null ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"UpdatedBy",false,false,6);
if(repositoryColumnObj!=null)TempCreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-gv_UserId not found");}

elementData = CurrentDate().ToString() ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"UpdatedOn",false,false,8);
if(repositoryColumnObj!=null)TempCreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-CurrentDate not found");}

if(rows.ContainsKey("2D32F409-3FDD-44BB-BBA2-5862F0432078"))     elementData = rows["2D32F409-3FDD-44BB-BBA2-5862F0432078"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ProjectType",false,false,9);
if(repositoryColumnObj!=null)TempCreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-TypeOfProject not found");}

if(rows.ContainsKey("B596DD9F-8B75-44EB-BB37-C2D6093E21E7"))     elementData = rows["B596DD9F-8B75-44EB-BB37-C2D6093E21E7"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"EmployeeBasicInfoId",false,false,9);
if(repositoryColumnObj!=null)TempCreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-EmpEmployeeBasicId not found");}

if(rows.ContainsKey("3D79FD45-F4C9-4111-9D02-BA7B50CE754E"))     elementData = rows["3D79FD45-F4C9-4111-9D02-BA7B50CE754E"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ProjectproposalID",false,false,9);
if(repositoryColumnObj!=null)TempCreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-ProjectProposal not found");}

if(rows.ContainsKey("CC0BFF91-E6F2-488C-85F2-E16AE98B8BAC"))     elementData = rows["CC0BFF91-E6F2-488C-85F2-E16AE98B8BAC"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"SchemeID",false,false,9);
if(repositoryColumnObj!=null)TempCreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-SchemeType not found");}

if(rows.ContainsKey("BC6C053E-0BA2-4200-A0C5-C0EF25B21E2E"))     elementData = rows["BC6C053E-0BA2-4200-A0C5-C0EF25B21E2E"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"RecurringAmount",false,false,3);
if(repositoryColumnObj!=null)TempCreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-RecurringAmount not found");}

if(rows.ContainsKey("97AE1937-023A-4A40-807F-74C57599806C"))     elementData = rows["97AE1937-023A-4A40-807F-74C57599806C"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"NonRecurringAmount",false,false,3);
if(repositoryColumnObj!=null)TempCreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-NonRecurringAmount not found");}

if(rows.ContainsKey("CA004F50-713B-4AC6-A2AE-DBA4ECDBC578"))     elementData = rows["CA004F50-713B-4AC6-A2AE-DBA4ECDBC578"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ProjectName",false,false,9);
if(repositoryColumnObj!=null)TempCreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-ProjectName not found");}

if(rows.ContainsKey("0C386A8C-8A37-4559-8464-99855AE81313"))     elementData = rows["0C386A8C-8A37-4559-8464-99855AE81313"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ProjectRefNo",false,false,9);
if(repositoryColumnObj!=null)TempCreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-ProjectRefNo not found");}

if(rows.ContainsKey("B705855C-3908-41FF-998E-EA6B24909F0F"))     elementData = rows["B705855C-3908-41FF-998E-EA6B24909F0F"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"IfManpower",false,false,0);
if(repositoryColumnObj!=null)TempCreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-ManPowerRequired not found");}

if(rows.ContainsKey("1CA31193-A9A8-476E-A3FF-F75133B5BDEC"))     elementData = rows["1CA31193-A9A8-476E-A3FF-F75133B5BDEC"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ToDate",false,false,8);
if(repositoryColumnObj!=null)TempCreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-EndDate not found");}

if(rows.ContainsKey("E18A3F8F-76E5-42F2-ABFD-44826B509A29"))     elementData = rows["E18A3F8F-76E5-42F2-ABFD-44826B509A29"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ProjectStatus",false,false,9);
if(repositoryColumnObj!=null)TempCreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-ProjectStatus not found");}
repositoryRowObj.Columns=TempCreateProjectDetails_colObj;
TempCreatemainDomain_TempCreateProjectDetails_rowsObj.Add(repositoryRowObj);
}}

TempCreateProjectDetailsTempCreatemainDomaintableObj.Rows=TempCreatemainDomain_TempCreateProjectDetails_rowsObj;
var TempCreatemainDomain_repoObj_status_TempCreateProjectDetails = TempCreatemainDomain_repoObj.Execute(DomainOperationTypes.CreateOrUpdate,ref TempCreateProjectDetailsTempCreatemainDomaintableObj);if(!TempCreatemainDomain_repoObj_status_TempCreateProjectDetails) throw new Exception("Error in Execute Domain Data Map");}
base.WriteDebugInfo(@"Exiting DomainDataMap for TempCreatemainDomain");
}
if(ISpace["FormVersionId"].Value=="EB102E80-C3DC-4EB9-8511-B1018E342530")
{
ISpace["UI_FirstRow"].Visible="false";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""EB102E80-C3DC-4EB9-8511-B1018E342530"")
{
ISpace[""UI_FirstRow""].Visible=""false"";
}");
base.WriteDebugInfo(@"EXEC [GetDateDifferenceInYears] 9,'','','','#ID1'");

var querySourceB8862B256DA54AA6BA4AFA4D3BF7D939 =GetQueryExpressionDataSource("B8862B25-6DA5-4AA6-BA4A-FA4D3BF7D939");
Dictionary<short,object> resultB8862B256DA54AA6BA4AFA4D3BF7D939=iSpace.ExecuteQuery(querySourceB8862B256DA54AA6BA4AFA4D3BF7D939,@"EXEC [GetDateDifferenceInYears] 9,'','','','" + ISpace["ID1"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceB8862B256DA54AA6BA4AFA4D3BF7D939 =GetQueryExpressionDataSource(""B8862B25-6DA5-4AA6-BA4A-FA4D3BF7D939"");Dictionary<short,object> resultB8862B256DA54AA6BA4AFA4D3BF7D939=iSpace.ExecuteQuery(querySourceB8862B256DA54AA6BA4AFA4D3BF7D939,@""EXEC [GetDateDifferenceInYears] 9,'','','','"" + ISpace[""ID1""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultB8862B256DA54AA6BA4AFA4D3BF7D939!=null) && (resultB8862B256DA54AA6BA4AFA4D3BF7D939.Count!=0))
{
if(resultB8862B256DA54AA6BA4AFA4D3BF7D939.ContainsKey(13))
ISpace["StartDate1"].Value = resultB8862B256DA54AA6BA4AFA4D3BF7D939[13];
if(resultB8862B256DA54AA6BA4AFA4D3BF7D939.ContainsKey(14))
ISpace["EndDate1"].Value = resultB8862B256DA54AA6BA4AFA4D3BF7D939[14];
if(resultB8862B256DA54AA6BA4AFA4D3BF7D939.ContainsKey(9))
ISpace["ProjectBudget1"].Value = resultB8862B256DA54AA6BA4AFA4D3BF7D939[9];
if(resultB8862B256DA54AA6BA4AFA4D3BF7D939.ContainsKey(0))
ISpace["ProjectDetailsID"].Value = resultB8862B256DA54AA6BA4AFA4D3BF7D939[0];
if(resultB8862B256DA54AA6BA4AFA4D3BF7D939.ContainsKey(8))
ISpace["FundingAcencyName1"].Value = resultB8862B256DA54AA6BA4AFA4D3BF7D939[8];
if(resultB8862B256DA54AA6BA4AFA4D3BF7D939.ContainsKey(5))
ISpace["Dept"].Value = resultB8862B256DA54AA6BA4AFA4D3BF7D939[5];
if(resultB8862B256DA54AA6BA4AFA4D3BF7D939.ContainsKey(2))
ISpace["ProjectCategory1"].Value = resultB8862B256DA54AA6BA4AFA4D3BF7D939[2];
if(resultB8862B256DA54AA6BA4AFA4D3BF7D939.ContainsKey(6))
ISpace["ProjectName1"].Value = resultB8862B256DA54AA6BA4AFA4D3BF7D939[6];
if(resultB8862B256DA54AA6BA4AFA4D3BF7D939.ContainsKey(5))
ISpace["Department1"].Value = resultB8862B256DA54AA6BA4AFA4D3BF7D939[5];
if(resultB8862B256DA54AA6BA4AFA4D3BF7D939.ContainsKey(10))
ISpace["PrincipleInvestigator1"].Value = resultB8862B256DA54AA6BA4AFA4D3BF7D939[10];
if(resultB8862B256DA54AA6BA4AFA4D3BF7D939.ContainsKey(12))
ISpace["Duration1"].Value = resultB8862B256DA54AA6BA4AFA4D3BF7D939[12];
if(resultB8862B256DA54AA6BA4AFA4D3BF7D939.ContainsKey(4))
ISpace["DepartmentType1"].Value = resultB8862B256DA54AA6BA4AFA4D3BF7D939[4];
if(resultB8862B256DA54AA6BA4AFA4D3BF7D939.ContainsKey(3))
ISpace["FinancialYear1"].Value = resultB8862B256DA54AA6BA4AFA4D3BF7D939[3];
if(resultB8862B256DA54AA6BA4AFA4D3BF7D939.ContainsKey(7))
ISpace["Description1"].Value = resultB8862B256DA54AA6BA4AFA4D3BF7D939[7];
}
else{
ISpace["StartDate1"].Value = null;ISpace["EndDate1"].Value = null;ISpace["ProjectBudget1"].Value = null;ISpace["ProjectDetailsID"].Value = null;ISpace["FundingAcencyName1"].Value = null;ISpace["Dept"].Value = null;ISpace["ProjectCategory1"].Value = null;ISpace["ProjectName1"].Value = null;ISpace["Department1"].Value = null;ISpace["PrincipleInvestigator1"].Value = null;ISpace["Duration1"].Value = null;ISpace["DepartmentType1"].Value = null;ISpace["FinancialYear1"].Value = null;ISpace["Description1"].Value = null;
}
if(ISpace["FormVersionId"].Value=="EB102E80-C3DC-4EB9-8511-B1018E342530")
{
ISpace["UI_Fundrelease"].Visible="false";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""EB102E80-C3DC-4EB9-8511-B1018E342530"")
{
ISpace[""UI_Fundrelease""].Visible=""false"";
}");
ISpace["EndDate"].Enbl="false";ISpace["ProjectName1"].Enbl="false";ISpace["Department1"].Enbl="false";ISpace["PrincipleInvestigator1"].Enbl="false";ISpace["Duration1"].Enbl="false";ISpace["DepartmentType1"].Enbl="false";ISpace["FinancialYear1"].Enbl="false";ISpace["FundingAcencyName1"].Enbl="false";ISpace["ProjectCategory1"].Enbl="false";ISpace["StartDate1"].Enbl="false";ISpace["Add1"].Enbl="false";ISpace["Description1"].Enbl="false";ISpace["EndDate1"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""EndDate""].Enbl=""false"";ISpace[""ProjectName1""].Enbl=""false"";ISpace[""Department1""].Enbl=""false"";ISpace[""PrincipleInvestigator1""].Enbl=""false"";ISpace[""Duration1""].Enbl=""false"";ISpace[""DepartmentType1""].Enbl=""false"";ISpace[""FinancialYear1""].Enbl=""false"";ISpace[""FundingAcencyName1""].Enbl=""false"";ISpace[""ProjectCategory1""].Enbl=""false"";ISpace[""StartDate1""].Enbl=""false"";ISpace[""Add1""].Enbl=""false"";ISpace[""Description1""].Enbl=""false"";ISpace[""EndDate1""].Enbl=""false"";");
ISpace["Year15"].Visible="false";ISpace["Year17"].Visible="false";ISpace["Year14"].Visible="false";ISpace["Year16"].Visible="false";ISpace["Year20"].Visible="false";ISpace["Year22"].Visible="false";ISpace["Year18"].Visible="false";ISpace["Year19"].Visible="false";ISpace["Year13"].Visible="false";ISpace["Year21"].Visible="false";ISpace["Year12"].Visible="false";
base.WriteDebugInfo(@"ISpace[""Year15""].Visible=""false"";ISpace[""Year17""].Visible=""false"";ISpace[""Year14""].Visible=""false"";ISpace[""Year16""].Visible=""false"";ISpace[""Year20""].Visible=""false"";ISpace[""Year22""].Visible=""false"";ISpace[""Year18""].Visible=""false"";ISpace[""Year19""].Visible=""false"";ISpace[""Year13""].Visible=""false"";ISpace[""Year21""].Visible=""false"";ISpace[""Year12""].Visible=""false"";");
ISpace["ProjectBudget1"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""ProjectBudget1""].Enbl=""false"";");
ISpace["Designation"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""Designation""].Enbl=""false"";");
ISpace["Year15"].Visible="false";ISpace["Year17"].Visible="false";ISpace["Year14"].Visible="false";ISpace["Year16"].Visible="false";ISpace["Year20"].Visible="false";ISpace["Year22"].Visible="false";ISpace["Year18"].Visible="false";ISpace["Year19"].Visible="false";ISpace["Year13"].Visible="false";ISpace["Year21"].Visible="false";ISpace["Year12"].Visible="false";
base.WriteDebugInfo(@"ISpace[""Year15""].Visible=""false"";ISpace[""Year17""].Visible=""false"";ISpace[""Year14""].Visible=""false"";ISpace[""Year16""].Visible=""false"";ISpace[""Year20""].Visible=""false"";ISpace[""Year22""].Visible=""false"";ISpace[""Year18""].Visible=""false"";ISpace[""Year19""].Visible=""false"";ISpace[""Year13""].Visible=""false"";ISpace[""Year21""].Visible=""false"";ISpace[""Year12""].Visible=""false"";");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
if(ISpace["IfExternalIns"].Value==true)
{
base.WriteDebugInfo(@"if(ISpace[""IfExternalIns""].Value==true)");
if(ISpace["FormVersionId"].Value=="EB102E80-C3DC-4EB9-8511-B1018E342530")
{
ISpace["UI_EIColumn"].Visible="true";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""EB102E80-C3DC-4EB9-8511-B1018E342530"")
{
ISpace[""UI_EIColumn""].Visible=""true"";
}");
ISpace["ExternalInstitute"].Man=true;
base.WriteDebugInfo(@"ISpace[""ExternalInstitute""].Man=true;");
}
if(ISpace["IfExternalIns"].Value==false)
{
base.WriteDebugInfo(@"if(ISpace[""IfExternalIns""].Value==false)");
if(ISpace["FormVersionId"].Value=="EB102E80-C3DC-4EB9-8511-B1018E342530")
{
ISpace["UI_EIColumn"].Visible="false";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""EB102E80-C3DC-4EB9-8511-B1018E342530"")
{
ISpace[""UI_EIColumn""].Visible=""false"";
}");
ISpace["ExternalInstitute"].Man=false;
base.WriteDebugInfo(@"ISpace[""ExternalInstitute""].Man=false;");
}
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_nkliei_phonenumber (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"NKLIEI_PhoneNumber-OnChange");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["NKLIEI_PhoneNumber"].Value=RegularExpression( ISpace["NKLIEI_PhoneNumber"].Value,"^[0-9]+$","0");
base.WriteDebugInfo(@"ISpace[""NKLIEI_PhoneNumber""].Value=RegularExpression( ISpace[""NKLIEI_PhoneNumber""].Value,""^[0-9]+$"",""0"");");
if(ISpace["NKLIEI_PhoneNumber"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""NKLIEI_PhoneNumber""].Value=="""")");
ISpace["Message"].Value=@"Please enter valid phone number";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please enter valid phone number"";");
ISpace["NKLIEI_PhoneNumber"].Value=null;
base.WriteDebugInfo(@"ISpace[""NKLIEI_PhoneNumber""].Value=null;");
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
private void SubscribeElementEvents_typeofproject (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"TypeOfProject-OnChange");
if(ISpace["ProjectCategory"].Value=="1"||ISpace["TypeOfProject"].Value=="450")
{
base.WriteDebugInfo(@"if(ISpace[""ProjectCategory""].Value==""1""||ISpace[""TypeOfProject""].Value==""450"")");
ISpace["SchemeType"].Value="";
base.WriteDebugInfo(@"ISpace[""SchemeType""].Value="""";");
ISpace["FundReceiptMode"].Value="Others";
base.WriteDebugInfo(@"ISpace[""FundReceiptMode""].Value=""Others"";");
ISpace["FundReceiptMode"].Man=false;ISpace["FundReceiptMode"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""FundReceiptMode""].Man=false;ISpace[""FundReceiptMode""].Enbl=""false"";");
ISpace["SchemeType"].Man=false;ISpace["SchemeType"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""SchemeType""].Man=false;ISpace[""SchemeType""].Enbl=""false"";");
ISpace["Add1"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""Add1""].Enbl=""false"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["FundReceiptMode"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""FundReceiptMode""].Enbl=""true"";");
ISpace["FundReceiptMode"].Value="";
base.WriteDebugInfo(@"ISpace[""FundReceiptMode""].Value="""";");
ISpace["Add1"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""Add1""].Enbl=""true"";");
ISpace["SchemeType"].Man=true;ISpace["SchemeType"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""SchemeType""].Man=true;ISpace[""SchemeType""].Enbl=""true"";");
}
if(ISpace["TypeOfProject"].Value=="450")
{
base.WriteDebugInfo(@"if(ISpace[""TypeOfProject""].Value==""450"")");
ISpace["ProjectBudget"].Value=null;
base.WriteDebugInfo(@"ISpace[""ProjectBudget""].Value=null;");
ISpace["SchemeType"].Value=null;
base.WriteDebugInfo(@"ISpace[""SchemeType""].Value=null;");
ISpace["Currency"].Visible="true";ISpace["Currency"].Man=true;ISpace["ProjectBudget"].Man=true;
base.WriteDebugInfo(@"ISpace[""Currency""].Visible=""true"";ISpace[""Currency""].Man=true;ISpace[""ProjectBudget""].Man=true;");
}
if(ISpace["TypeOfProject"].Value=="449")
{
base.WriteDebugInfo(@"if(ISpace[""TypeOfProject""].Value==""449"")");
ISpace["FundReceiptMode"].Visible="true";ISpace["FundReceiptMode"].Enbl="true";ISpace["Currency"].Visible="false";ISpace["Currency"].Man=false;ISpace["SchemeType"].Visible="true";ISpace["SchemeType"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""FundReceiptMode""].Visible=""true"";ISpace[""FundReceiptMode""].Enbl=""true"";ISpace[""Currency""].Visible=""false"";ISpace[""Currency""].Man=false;ISpace[""SchemeType""].Visible=""true"";ISpace[""SchemeType""].Enbl=""true"";");
ISpace["Currency"].Value="";
base.WriteDebugInfo(@"ISpace[""Currency""].Value="""";");
ISpace["FundReceiptMode"].Man=true;
base.WriteDebugInfo(@"ISpace[""FundReceiptMode""].Man=true;");
ISpace["IntAmount"].Value=null;
base.WriteDebugInfo(@"ISpace[""IntAmount""].Value=null;");
ISpace["IntExpense"].Value=null;
base.WriteDebugInfo(@"ISpace[""IntExpense""].Value=null;");
ISpace["ProjectBudget"].Value=null;
base.WriteDebugInfo(@"ISpace[""ProjectBudget""].Value=null;");
ISpace["ProjectBudget"].Man=true;ISpace["ProjectBudget"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""ProjectBudget""].Man=true;ISpace[""ProjectBudget""].Enbl=""true"";");
}
base.WriteDebugInfo(@"EXEC [GetDateDifferenceInYears] 27,'','','','#ID1'");

var querySourceAEFACC4D5CE9417C8C4CFD22CB38EF75 =GetQueryExpressionDataSource("AEFACC4D-5CE9-417C-8C4C-FD22CB38EF75");
Dictionary<short,object> resultAEFACC4D5CE9417C8C4CFD22CB38EF75=iSpace.ExecuteQuery(querySourceAEFACC4D5CE9417C8C4CFD22CB38EF75,@"EXEC [GetDateDifferenceInYears] 27,'','','','" + ISpace["ID1"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceAEFACC4D5CE9417C8C4CFD22CB38EF75 =GetQueryExpressionDataSource(""AEFACC4D-5CE9-417C-8C4C-FD22CB38EF75"");Dictionary<short,object> resultAEFACC4D5CE9417C8C4CFD22CB38EF75=iSpace.ExecuteQuery(querySourceAEFACC4D5CE9417C8C4CFD22CB38EF75,@""EXEC [GetDateDifferenceInYears] 27,'','','','"" + ISpace[""ID1""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultAEFACC4D5CE9417C8C4CFD22CB38EF75!=null) && (resultAEFACC4D5CE9417C8C4CFD22CB38EF75.Count!=0))
{
if(resultAEFACC4D5CE9417C8C4CFD22CB38EF75.ContainsKey(0))
ISpace["Subject"].Value = resultAEFACC4D5CE9417C8C4CFD22CB38EF75[0];
}
else{
ISpace["Subject"].Value = null;
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_year15 (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Year15-OnChange");
ISpace["BudgetAmount"].Value= ISpace["Year11"].Value+ISpace["Year12"].Value+ISpace["Year13"].Value+ISpace["Year14"].Value+ISpace["Year15"].Value+ISpace["Year16"].Value+ISpace["Year17"].Value+ISpace["Year18"].Value+ISpace["Year19"].Value+ISpace["Year20"].Value+ISpace["Year21"].Value+ISpace["Year22"].Value;
base.WriteDebugInfo(@"ISpace[""BudgetAmount""].Value= ISpace[""Year11""].Value+ISpace[""Year12""].Value+ISpace[""Year13""].Value+ISpace[""Year14""].Value+ISpace[""Year15""].Value+ISpace[""Year16""].Value+ISpace[""Year17""].Value+ISpace[""Year18""].Value+ISpace[""Year19""].Value+ISpace[""Year20""].Value+ISpace[""Year21""].Value+ISpace[""Year22""].Value;");
ISpace["RecurringAmount"].Value=0;
base.WriteDebugInfo(@"ISpace[""RecurringAmount""].Value=0;");
ISpace["NonRecurringAmount"].Value=0;
base.WriteDebugInfo(@"ISpace[""NonRecurringAmount""].Value=0;");
object BudgetAmount=iSpace.Sum("[C92F6C5D-F7CB-4E81-835C-3D655C7FCC52]","BudgetAmount","",ISpace["gv_instanceid"].Value);
ISpace["OverallBudgetTotal"].Value=Convert.ChangeType(BudgetAmount, BudgetAmount.GetType());;
base.WriteDebugInfo(@"object BudgetAmount=iSpace.Sum(""[C92F6C5D-F7CB-4E81-835C-3D655C7FCC52]"",""BudgetAmount"","""",ISpace[""gv_instanceid""].Value);
ISpace[""OverallBudgetTotal""].Value=Convert.ChangeType(BudgetAmount, BudgetAmount.GetType());;");
if(1==2)
{
base.WriteDebugInfo(@"if(1==2)");
base.WriteDebugInfo(@"#BudgetDetails[Rows]");
iSpace.GetLoopExpressionData("BudgetDetails",ref ISpace);

foreach(var gridChild in ISpace["BudgetDetails"].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 


if(
ISpace["RecurringValidation"].Value==518)
{
base.WriteDebugInfo(@"
if(
ISpace[""RecurringValidation""].Value==518)");
object BudgetAmount=iSpace.Sum("[C92F6C5D-F7CB-4E81-835C-3D655C7FCC52]","BudgetAmount","",ISpace["gv_instanceid"].Value);
ISpace["RecurringAmount"].Value=Convert.ChangeType(BudgetAmount, BudgetAmount.GetType());;
base.WriteDebugInfo(@"object BudgetAmount=iSpace.Sum(""[C92F6C5D-F7CB-4E81-835C-3D655C7FCC52]"",""BudgetAmount"","""",ISpace[""gv_instanceid""].Value);
ISpace[""RecurringAmount""].Value=Convert.ChangeType(BudgetAmount, BudgetAmount.GetType());;");
}
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("BudgetDetails","C92F6C5D-F7CB-4E81-835C-3D655C7FCC52",_objectFactory.GetGridRPP("BudgetDetails"),_elementBase.GetGridLoopQuery("C92F6C5D-F7CB-4E81-835C-3D655C7FCC52","BudgetDetails",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""BudgetDetails"",ref ISpace);

foreach(var gridChild in ISpace[""BudgetDetails""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
}
base.WriteDebugInfo(@"#BudgetDetails[Rows]");
iSpace.GetLoopExpressionData("BudgetDetails",ref ISpace);

foreach(var gridChild in ISpace["BudgetDetails"].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 


if(
ISpace["RecurringValidation"].Value==519)
{
base.WriteDebugInfo(@"
if(
ISpace[""RecurringValidation""].Value==519)");
ISpace["NonRecurringAmount"].Value=ISpace["NonRecurringAmount"].Value+ISpace["BudgetAmount"].Value;
base.WriteDebugInfo(@"ISpace[""NonRecurringAmount""].Value=ISpace[""NonRecurringAmount""].Value+ISpace[""BudgetAmount""].Value;");
}

if(
ISpace["RecurringValidation"].Value==518)
{
base.WriteDebugInfo(@"
if(
ISpace[""RecurringValidation""].Value==518)");
ISpace["RecurringAmount"].Value=ISpace["RecurringAmount"].Value+ISpace["BudgetAmount"].Value;
base.WriteDebugInfo(@"ISpace[""RecurringAmount""].Value=ISpace[""RecurringAmount""].Value+ISpace[""BudgetAmount""].Value;");
}
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("BudgetDetails","C92F6C5D-F7CB-4E81-835C-3D655C7FCC52",_objectFactory.GetGridRPP("BudgetDetails"),_elementBase.GetGridLoopQuery("C92F6C5D-F7CB-4E81-835C-3D655C7FCC52","BudgetDetails",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""BudgetDetails"",ref ISpace);

foreach(var gridChild in ISpace[""BudgetDetails""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_eqequipmentquantity (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"EQEquipmentQuantity-OnChange");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["EQEquipmentTotalCost"].Value=ISpace["EQEquipmentRateinINR"].Value*ISpace["EQEquipmentQuantity"].Value;
base.WriteDebugInfo(@"ISpace[""EQEquipmentTotalCost""].Value=ISpace[""EQEquipmentRateinINR""].Value*ISpace[""EQEquipmentQuantity""].Value;");
object EQEquipmentTotalCost=iSpace.Sum("[71802A68-968A-4C2C-8AFE-32BA5B817B50]","EQEquipmentTotalCost","",ISpace["gv_instanceid"].Value);
ISpace["EquipmentTotalCost"].Value=Convert.ChangeType(EQEquipmentTotalCost, EQEquipmentTotalCost.GetType());;
base.WriteDebugInfo(@"object EQEquipmentTotalCost=iSpace.Sum(""[71802A68-968A-4C2C-8AFE-32BA5B817B50]"",""EQEquipmentTotalCost"","""",ISpace[""gv_instanceid""].Value);
ISpace[""EquipmentTotalCost""].Value=Convert.ChangeType(EQEquipmentTotalCost, EQEquipmentTotalCost.GetType());;");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"#BudgetDetails[Rows]");
iSpace.GetLoopExpressionData("BudgetDetails",ref ISpace);

foreach(var gridChild in ISpace["BudgetDetails"].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 


if(
ISpace["Bid"].Value==2)
{
base.WriteDebugInfo(@"
if(
ISpace[""Bid""].Value==2)");
ISpace["EquipmentAmount"].Value=ISpace["BudgetAmount"].Value;
base.WriteDebugInfo(@"ISpace[""EquipmentAmount""].Value=ISpace[""BudgetAmount""].Value;");
}
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("BudgetDetails","C92F6C5D-F7CB-4E81-835C-3D655C7FCC52",_objectFactory.GetGridRPP("BudgetDetails"),_elementBase.GetGridLoopQuery("C92F6C5D-F7CB-4E81-835C-3D655C7FCC52","BudgetDetails",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""BudgetDetails"",ref ISpace);

foreach(var gridChild in ISpace[""BudgetDetails""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
if(ISpace["EquipmentTotalCost"].Value>ISpace["EquipmentAmount"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""EquipmentTotalCost""].Value>ISpace[""EquipmentAmount""].Value)");
ISpace["Message"].Value=@"Equipment Total Cost is greater than Equipmet Budget";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Equipment Total Cost is greater than Equipmet Budget"";");
ISpace["EQEquipmentQuantity"].Value=null;
base.WriteDebugInfo(@"ISpace[""EQEquipmentQuantity""].Value=null;");
ISpace["EQEquipmentRateinINR"].Value=null;
base.WriteDebugInfo(@"ISpace[""EQEquipmentRateinINR""].Value=null;");
ISpace["EQEquipmentTotalCost"].Value=0;
base.WriteDebugInfo(@"ISpace[""EQEquipmentTotalCost""].Value=0;");
object EQEquipmentTotalCost=iSpace.Sum("[71802A68-968A-4C2C-8AFE-32BA5B817B50]","EQEquipmentTotalCost","",ISpace["gv_instanceid"].Value);
ISpace["EquipmentTotalCost"].Value=Convert.ChangeType(EQEquipmentTotalCost, EQEquipmentTotalCost.GetType());;
base.WriteDebugInfo(@"object EQEquipmentTotalCost=iSpace.Sum(""[71802A68-968A-4C2C-8AFE-32BA5B817B50]"",""EQEquipmentTotalCost"","""",ISpace[""gv_instanceid""].Value);
ISpace[""EquipmentTotalCost""].Value=Convert.ChangeType(EQEquipmentTotalCost, EQEquipmentTotalCost.GetType());;");
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
private void SubscribeElementEvents_fundreceiptadd (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"FundReceiptAdd-OnClick");
ISpace["UI_CD4"].ShowDialog=true;;
base.WriteDebugInfo(@"ISpace[""UI_CD4""].ShowDialog=true;;");
ISpace["FundReceiptName"].Value="";
base.WriteDebugInfo(@"ISpace[""FundReceiptName""].Value="""";");
ISpace["FundReceiptCode"].Value="";
base.WriteDebugInfo(@"ISpace[""FundReceiptCode""].Value="""";");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_fundsubmit (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"FundSubmit-OnClick");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"exec CheckDuplicateFundReceiptName 1,'#FundReceiptName','#FundReceiptCode'");

var querySource1C1F3E034BF747F49183671021C3E6E6 =GetQueryExpressionDataSource("1C1F3E03-4BF7-47F4-9183-671021C3E6E6");
Dictionary<short,object> result1C1F3E034BF747F49183671021C3E6E6=iSpace.ExecuteQuery(querySource1C1F3E034BF747F49183671021C3E6E6,@"execCheckDuplicateFundReceiptName 1,'" + ISpace["FundReceiptName"].Value + @"','" + ISpace["FundReceiptCode"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource1C1F3E034BF747F49183671021C3E6E6 =GetQueryExpressionDataSource(""1C1F3E03-4BF7-47F4-9183-671021C3E6E6"");Dictionary<short,object> result1C1F3E034BF747F49183671021C3E6E6=iSpace.ExecuteQuery(querySource1C1F3E034BF747F49183671021C3E6E6,@""execCheckDuplicateFundReceiptName 1,'"" + ISpace[""FundReceiptName""].Value + @""','"" + ISpace[""FundReceiptCode""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result1C1F3E034BF747F49183671021C3E6E6!=null) && (result1C1F3E034BF747F49183671021C3E6E6.Count!=0))
{
if(result1C1F3E034BF747F49183671021C3E6E6.ContainsKey(0))
ISpace["FundDupCheck"].Value = result1C1F3E034BF747F49183671021C3E6E6[0];
}
else{
ISpace["FundDupCheck"].Value = null;
}
}
if(ISpace["FundDupCheck"].Value=="1")
{
base.WriteDebugInfo(@"if(ISpace[""FundDupCheck""].Value==""1"")");
ISpace["Message"].Value=@"Fund Receipt Already Exist!";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Fund Receipt Already Exist!"";");
return;
base.WriteDebugInfo(@"return;");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["FundReceiptISActive"].Value=true;
base.WriteDebugInfo(@"ISpace[""FundReceiptISActive""].Value=true;");
base.WriteDebugInfo(@"Entering DomainDataMap for FundReceiptDomain");
var FundReceiptDomain_repoObj = new RepositoryMapper(DbTypes.SQLServer);


var FundReceiptMasterFundReceiptDomaintableObj = new RepositoryTable("FundReceiptMaster");
  FundReceiptMasterFundReceiptDomaintableObj.AppConnectionSettingsId  ="40BDEB14-07CC-4150-8A52-9B088A428E2D";FundReceiptMasterFundReceiptDomaintableObj.ProofConnectionId = "C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0)";
var FundReceiptDomain_FundReceiptMaster_rows = GetElementClientData(ISpace["InstanceId"].Value,"A83D8B17-78DB-4B11-86C7-91E3F9A7C20E");

if(FundReceiptDomain_FundReceiptMaster_rows!=null && FundReceiptDomain_FundReceiptMaster_rows.Count>0){
var FundReceiptDomain_FundReceiptMaster_rowsObj = new List<RepositoryRow>();
foreach(var rows in FundReceiptDomain_FundReceiptMaster_rows){RepositoryRow repositoryRowObj = null;string elementData = null;RepositoryColumn repositoryColumnObj = null;if(rows !=null){ var FundReceiptMaster_colObj = new List<RepositoryColumn>();repositoryRowObj= new RepositoryRow();//var myByte = (byte)rowData.Value.RwSt;//repositoryRowObj.RowState=(RepositoryRowState)myByte;

elementData = ISpace["gv_UserId"].Value != null? Convert.ToString(ISpace["gv_UserId"].Value):null ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"UpdateBy",false,false,6);
if(repositoryColumnObj!=null)FundReceiptMaster_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-gv_UserId not found");}

if(rows.ContainsKey("6BC3231D-27B1-4E71-9137-7E2E6235B3A3"))     elementData = rows["6BC3231D-27B1-4E71-9137-7E2E6235B3A3"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"IsActive",false,false,0);
if(repositoryColumnObj!=null)FundReceiptMaster_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-FundReceiptISActive not found");}

if(rows.ContainsKey("F4E63896-E39E-4C17-B20B-8E09B47B05F1"))     elementData = rows["F4E63896-E39E-4C17-B20B-8E09B47B05F1"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"FundReceiptName",false,false,9);
if(repositoryColumnObj!=null)FundReceiptMaster_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-FundReceiptName not found");}

elementData = CurrentDate().ToString() ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"UpdatedOn",false,false,8);
if(repositoryColumnObj!=null)FundReceiptMaster_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-CurrentDate not found");}

if(rows.ContainsKey("221D3C00-2FA4-41FA-8F2C-170C0CB703A0"))     elementData = rows["221D3C00-2FA4-41FA-8F2C-170C0CB703A0"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"FundReceiptID",true,true,5);
if(repositoryColumnObj!=null)FundReceiptMaster_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-FundReceiptID not found");}

if(rows.ContainsKey("A651D1CC-6B44-4224-BFA0-ED0F2459E27A"))     elementData = rows["A651D1CC-6B44-4224-BFA0-ED0F2459E27A"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"FundReceiptCode",false,false,9);
if(repositoryColumnObj!=null)FundReceiptMaster_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-FundReceiptCode not found");}
repositoryRowObj.Columns=FundReceiptMaster_colObj;
FundReceiptDomain_FundReceiptMaster_rowsObj.Add(repositoryRowObj);
}}

FundReceiptMasterFundReceiptDomaintableObj.Rows=FundReceiptDomain_FundReceiptMaster_rowsObj;
var FundReceiptDomain_repoObj_status_FundReceiptMaster = FundReceiptDomain_repoObj.Execute(DomainOperationTypes.CreateOrUpdate,ref FundReceiptMasterFundReceiptDomaintableObj);if(!FundReceiptDomain_repoObj_status_FundReceiptMaster) throw new Exception("Error in Execute Domain Data Map");}
base.WriteDebugInfo(@"Exiting DomainDataMap for FundReceiptDomain");
ISpace["UI_CD4"].HideDialog=true;;
base.WriteDebugInfo(@"ISpace[""UI_CD4""].HideDialog=true;;");
ISpace["FundReceiptMode"].rElemData=iSpace.Reload(ISpace["FundReceiptMode"].Value,@"EXEC GetDateDifferenceInYears 16,'','',''","40BDEB14-07CC-4150-8A52-9B088A428E2D");
base.WriteDebugInfo(@"ISpace[""FundReceiptMode""].rElemData=iSpace.Reload(ISpace[""FundReceiptMode""].Value,@""EXEC GetDateDifferenceInYears 16,'','',''"",""40BDEB14-07CC-4150-8A52-9B088A428E2D"");");
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mp_hraper (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MP_HRAPer-OnChange");
ISpace["MP_HRAPercal"].Value=ISpace["MP_HRAPer"].Value/100.0;
base.WriteDebugInfo(@"ISpace[""MP_HRAPercal""].Value=ISpace[""MP_HRAPer""].Value/100.0;");
ISpace["MP_HRAperMonth"].Value=ISpace["MP_RatePerMonth"].Value*ISpace["MP_HRAPercal"].Value;
base.WriteDebugInfo(@"ISpace[""MP_HRAperMonth""].Value=ISpace[""MP_RatePerMonth""].Value*ISpace[""MP_HRAPercal""].Value;");
ISpace["MP_TotalPerMonth"].Value=ISpace["MP_RatePerMonth"].Value+ISpace["MP_HRAperMonth"].Value;
base.WriteDebugInfo(@"ISpace[""MP_TotalPerMonth""].Value=ISpace[""MP_RatePerMonth""].Value+ISpace[""MP_HRAperMonth""].Value;");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_projectproposal (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"ProjectProposal-OnChange");
base.WriteDebugInfo(@"EXEC [GetProjectProposalDetailsLoad] 1,'#ProjectProposal'");

var querySourceE28E41A4DCE247A8BF8B175F80711881 =GetQueryExpressionDataSource("E28E41A4-DCE2-47A8-BF8B-175F80711881");
Dictionary<short,object> resultE28E41A4DCE247A8BF8B175F80711881=iSpace.ExecuteQuery(querySourceE28E41A4DCE247A8BF8B175F80711881,@"EXEC [GetProjectProposalDetailsLoad] 1,'" + ISpace["ProjectProposal"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceE28E41A4DCE247A8BF8B175F80711881 =GetQueryExpressionDataSource(""E28E41A4-DCE2-47A8-BF8B-175F80711881"");Dictionary<short,object> resultE28E41A4DCE247A8BF8B175F80711881=iSpace.ExecuteQuery(querySourceE28E41A4DCE247A8BF8B175F80711881,@""EXEC [GetProjectProposalDetailsLoad] 1,'"" + ISpace[""ProjectProposal""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultE28E41A4DCE247A8BF8B175F80711881!=null) && (resultE28E41A4DCE247A8BF8B175F80711881.Count!=0))
{
if(resultE28E41A4DCE247A8BF8B175F80711881.ContainsKey(13))
ISpace["TypeOfProject"].Value = resultE28E41A4DCE247A8BF8B175F80711881[13];
if(resultE28E41A4DCE247A8BF8B175F80711881.ContainsKey(6))
ISpace["FundingAcencyName"].Value = resultE28E41A4DCE247A8BF8B175F80711881[6];
if(resultE28E41A4DCE247A8BF8B175F80711881.ContainsKey(17))
ISpace["Currency"].Value = resultE28E41A4DCE247A8BF8B175F80711881[17];
if(resultE28E41A4DCE247A8BF8B175F80711881.ContainsKey(7))
ISpace["Sector"].Value = resultE28E41A4DCE247A8BF8B175F80711881[7];
if(resultE28E41A4DCE247A8BF8B175F80711881.ContainsKey(2))
ISpace["ProjectCategory"].Value = resultE28E41A4DCE247A8BF8B175F80711881[2];
if(resultE28E41A4DCE247A8BF8B175F80711881.ContainsKey(3))
ISpace["FinancialYear"].Value = resultE28E41A4DCE247A8BF8B175F80711881[3];
if(resultE28E41A4DCE247A8BF8B175F80711881.ContainsKey(21))
ISpace["IfExternalIns"].Value = resultE28E41A4DCE247A8BF8B175F80711881[21];
if(resultE28E41A4DCE247A8BF8B175F80711881.ContainsKey(9))
ISpace["EndorsementAmount"].Value = resultE28E41A4DCE247A8BF8B175F80711881[9];
if(resultE28E41A4DCE247A8BF8B175F80711881.ContainsKey(9))
ISpace["ProjectBudget"].Value = resultE28E41A4DCE247A8BF8B175F80711881[9];
if(resultE28E41A4DCE247A8BF8B175F80711881.ContainsKey(18))
ISpace["IntExpense"].Value = resultE28E41A4DCE247A8BF8B175F80711881[18];
if(resultE28E41A4DCE247A8BF8B175F80711881.ContainsKey(19))
ISpace["IntAmount"].Value = resultE28E41A4DCE247A8BF8B175F80711881[19];
if(resultE28E41A4DCE247A8BF8B175F80711881.ContainsKey(13))
ISpace["TypeofprojectKey"].Value = resultE28E41A4DCE247A8BF8B175F80711881[13];
if(resultE28E41A4DCE247A8BF8B175F80711881.ContainsKey(13))
ISpace["ProjectKey"].Value = resultE28E41A4DCE247A8BF8B175F80711881[13];
if(resultE28E41A4DCE247A8BF8B175F80711881.ContainsKey(8))
ISpace["ProjectName"].Value = resultE28E41A4DCE247A8BF8B175F80711881[8];
}
else{
ISpace["TypeOfProject"].Value = null;ISpace["FundingAcencyName"].Value = null;ISpace["Currency"].Value = null;ISpace["Sector"].Value = null;ISpace["ProjectCategory"].Value = null;ISpace["FinancialYear"].Value = null;ISpace["IfExternalIns"].Value = null;ISpace["EndorsementAmount"].Value = null;ISpace["ProjectBudget"].Value = null;ISpace["IntExpense"].Value = null;ISpace["IntAmount"].Value = null;ISpace["TypeofprojectKey"].Value = null;ISpace["ProjectKey"].Value = null;ISpace["ProjectName"].Value = null;
}
if(ISpace["TypeofprojectKey"].Value=="450")
{
base.WriteDebugInfo(@"if(ISpace[""TypeofprojectKey""].Value==""450"")");
ISpace["IntAmount"].Visible="true";ISpace["IntAmount"].Man=true;ISpace["IntExpense"].Visible="true";ISpace["IntExpense"].Man=true;ISpace["Currency"].Visible="true";ISpace["Currency"].Man=true;ISpace["ProjectBudget"].Man=false;ISpace["ProjectBudget"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""IntAmount""].Visible=""true"";ISpace[""IntAmount""].Man=true;ISpace[""IntExpense""].Visible=""true"";ISpace[""IntExpense""].Man=true;ISpace[""Currency""].Visible=""true"";ISpace[""Currency""].Man=true;ISpace[""ProjectBudget""].Man=false;ISpace[""ProjectBudget""].Enbl=""false"";");
}
if(ISpace["TypeOfProject"].Value=="449")
{
base.WriteDebugInfo(@"if(ISpace[""TypeOfProject""].Value==""449"")");
ISpace["IntAmount"].Visible="false";ISpace["IntAmount"].Man=false;ISpace["IntExpense"].Visible="false";ISpace["IntExpense"].Man=false;ISpace["Currency"].Visible="false";ISpace["Currency"].Man=false;ISpace["ProjectBudget"].Man=true;ISpace["ProjectBudget"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""IntAmount""].Visible=""false"";ISpace[""IntAmount""].Man=false;ISpace[""IntExpense""].Visible=""false"";ISpace[""IntExpense""].Man=false;ISpace[""Currency""].Visible=""false"";ISpace[""Currency""].Man=false;ISpace[""ProjectBudget""].Man=true;ISpace[""ProjectBudget""].Enbl=""true"";");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");

var querySource00EA9A50A5C24EDB97211F1969A17844 =GetQueryExpressionDataSource("00EA9A50-A5C2-4EDB-9721-1F1969A17844");

DataTable result00EA9A50A5C24EDB97211F1969A17844=iSpace.SetGridDataSource(querySource00EA9A50A5C24EDB97211F1969A17844, _objectFactory.GetGridRPP("CoPiDetails"),@"EXEC GetCoPiDetailsBasedOnProject 1,'" + ISpace["ProjectProposal"].Value + @"'");

iSpace.InsertGridBindDetails("CoPiDetails","11",querySource00EA9A50A5C24EDB97211F1969A17844,"EXEC GetCoPiDetailsBasedOnProject 1,'" + ISpace["ProjectProposal"].Value + @"'",_objectFactory.GetGridRPP("CoPiDetails"));

base.WriteDebugInfo(@"var querySource00EA9A50A5C24EDB97211F1969A17844 =GetQueryExpressionDataSource(""00EA9A50-A5C2-4EDB-9721-1F1969A17844"");DataTable result00EA9A50A5C24EDB97211F1969A17844=iSpace.SetGridDataSource(querySource00EA9A50A5C24EDB97211F1969A17844, _objectFactory.GetGridRPP(""CoPiDetails""),@""EXEC GetCoPiDetailsBasedOnProject 1,'"" + ISpace[""ProjectProposal""].Value + @""'"");iSpace.InsertGridBindDetails(""CoPiDetails"",""11"",querySource00EA9A50A5C24EDB97211F1969A17844,""EXEC GetCoPiDetailsBasedOnProject 1,'"" + ISpace[""ProjectProposal""].Value + @""'"",_objectFactory.GetGridRPP(""CoPiDetails""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result9C4BCE1F82824A65B694C716D683886B=acdataIspaceD0B6EBB910A44D43A76EF39441A41EF6.GetQueryExpressionBindings("9C4BCE1F-8282-4A65-B694-C716D683886B");
iSpace.SetGridData(result00EA9A50A5C24EDB97211F1969A17844,result9C4BCE1F82824A65B694C716D683886B,"CoPiDetails",ref ISpace);
iSpace.UpdateGridBindDetails("CoPiDetails",result9C4BCE1F82824A65B694C716D683886B);

var querySource0B66B0305C5445D69318D07B02259694 =GetQueryExpressionDataSource("0B66B030-5C54-45D6-9318-D07B02259694");

DataTable result0B66B0305C5445D69318D07B02259694=iSpace.SetGridDataSource(querySource0B66B0305C5445D69318D07B02259694, _objectFactory.GetGridRPP("ExternalInstitute"),@"EXEC GetCoPiDetailsBasedOnProject 2,'" + ISpace["ProjectProposal"].Value + @"'");

iSpace.InsertGridBindDetails("ExternalInstitute","11",querySource0B66B0305C5445D69318D07B02259694,"EXEC GetCoPiDetailsBasedOnProject 2,'" + ISpace["ProjectProposal"].Value + @"'",_objectFactory.GetGridRPP("ExternalInstitute"));

base.WriteDebugInfo(@"var querySource0B66B0305C5445D69318D07B02259694 =GetQueryExpressionDataSource(""0B66B030-5C54-45D6-9318-D07B02259694"");DataTable result0B66B0305C5445D69318D07B02259694=iSpace.SetGridDataSource(querySource0B66B0305C5445D69318D07B02259694, _objectFactory.GetGridRPP(""ExternalInstitute""),@""EXEC GetCoPiDetailsBasedOnProject 2,'"" + ISpace[""ProjectProposal""].Value + @""'"");iSpace.InsertGridBindDetails(""ExternalInstitute"",""11"",querySource0B66B0305C5445D69318D07B02259694,""EXEC GetCoPiDetailsBasedOnProject 2,'"" + ISpace[""ProjectProposal""].Value + @""'"",_objectFactory.GetGridRPP(""ExternalInstitute""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result9AF0475CF1294C9286122CB7DC8E22C5=acdataIspaceD0B6EBB910A44D43A76EF39441A41EF6.GetQueryExpressionBindings("9AF0475C-F129-4C92-8612-2CB7DC8E22C5");
iSpace.SetGridData(result0B66B0305C5445D69318D07B02259694,result9AF0475CF1294C9286122CB7DC8E22C5,"ExternalInstitute",ref ISpace);
iSpace.UpdateGridBindDetails("ExternalInstitute",result9AF0475CF1294C9286122CB7DC8E22C5);
}
ISpace["SchemeType"].rElemData=iSpace.Reload(ISpace["SchemeType"].Value,@"EXEC GetProjectDetailCombo 5,'" + ISpace["FundingAcencyName"].Value + @"'","40BDEB14-07CC-4150-8A52-9B088A428E2D");
base.WriteDebugInfo(@"ISpace[""SchemeType""].rElemData=iSpace.Reload(ISpace[""SchemeType""].Value,@""EXEC GetProjectDetailCombo 5,'"" + ISpace[""FundingAcencyName""].Value + @""'"",""40BDEB14-07CC-4150-8A52-9B088A428E2D"");");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_ifequipment (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"IFEquipment-OnChange");
if(ISpace["IFEquipment"].Value==true)
{
base.WriteDebugInfo(@"if(ISpace[""IFEquipment""].Value==true)");
ISpace["EquipmentDetails"].Visible="true";
base.WriteDebugInfo(@"ISpace[""EquipmentDetails""].Visible=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["EquipmentDetails"].Visible="false";
base.WriteDebugInfo(@"ISpace[""EquipmentDetails""].Visible=""false"";");
}
ISpace["FinancialYear"].Value="19";
base.WriteDebugInfo(@"ISpace[""FinancialYear""].Value=""19"";");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_ui_manpower (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"UI_ManPower-OnClick");
if(ISpace["ActiveEdit"].Value==0)
{
base.WriteDebugInfo(@"if(ISpace[""ActiveEdit""].Value==0)");
base.WriteDebugInfo(@"Entering DomainDataMap for Budget Details Grid Domain");
var BudgetDetailsGridDomain_repoObj = new RepositoryMapper(DbTypes.SQLServer);


var ProjectBudgetDetailsBudgetDetailsGridDomaintableObj = new RepositoryTable("ProjectBudgetDetails");
  ProjectBudgetDetailsBudgetDetailsGridDomaintableObj.AppConnectionSettingsId  ="40BDEB14-07CC-4150-8A52-9B088A428E2D";ProjectBudgetDetailsBudgetDetailsGridDomaintableObj.ProofConnectionId = "C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0)";
var BudgetDetailsGridDomain_ProjectBudgetDetails_rows = GetElementClientData(ISpace["InstanceId"].Value,"C92F6C5D-F7CB-4E81-835C-3D655C7FCC52");

if(BudgetDetailsGridDomain_ProjectBudgetDetails_rows!=null && BudgetDetailsGridDomain_ProjectBudgetDetails_rows.Count>0){
var BudgetDetailsGridDomain_ProjectBudgetDetails_rowsObj = new List<RepositoryRow>();
foreach(var rows in BudgetDetailsGridDomain_ProjectBudgetDetails_rows){RepositoryRow repositoryRowObj = null;string elementData = null;RepositoryColumn repositoryColumnObj = null;if(rows !=null){ var ProjectBudgetDetails_colObj = new List<RepositoryColumn>();repositoryRowObj= new RepositoryRow();//var myByte = (byte)rowData.Value.RwSt;//repositoryRowObj.RowState=(RepositoryRowState)myByte;

if(rows.ContainsKey("A38311B1-68C6-462E-9DB6-FD90ABFF6E44"))     elementData = rows["A38311B1-68C6-462E-9DB6-FD90ABFF6E44"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"BudgetAmount",false,false,3);
if(repositoryColumnObj!=null)ProjectBudgetDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-BudgetAmount not found");}

if(rows.ContainsKey("F7FB513A-721E-4E82-89DD-F03DF3E8AB16"))     elementData = rows["F7FB513A-721E-4E82-89DD-F03DF3E8AB16"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"BudgetID",false,false,5);
if(repositoryColumnObj!=null)ProjectBudgetDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Bid not found");}

if(rows.ContainsKey("FD08EF20-802B-4672-8747-6D54C2D6D31E"))     elementData = rows["FD08EF20-802B-4672-8747-6D54C2D6D31E"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Year2",false,false,5);
if(repositoryColumnObj!=null)ProjectBudgetDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Year12 not found");}

if(rows.ContainsKey("49074D93-7C7F-401F-AD44-0BB2B5353FE3"))     elementData = rows["49074D93-7C7F-401F-AD44-0BB2B5353FE3"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ProjectDetailsID",false,false,9);
if(repositoryColumnObj!=null)ProjectBudgetDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-ID1 not found");}

elementData = CurrentDate().ToString() ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"UpdatedOn",false,false,8);
if(repositoryColumnObj!=null)ProjectBudgetDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-CurrentDate not found");}

if(rows.ContainsKey("67FD82A6-A670-4DD2-8574-AAD959805F77"))     elementData = rows["67FD82A6-A670-4DD2-8574-AAD959805F77"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Year7",false,false,5);
if(repositoryColumnObj!=null)ProjectBudgetDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Year17 not found");}

if(rows.ContainsKey("B5948E98-0ABA-493A-A2DB-DF169BE81734"))     elementData = rows["B5948E98-0ABA-493A-A2DB-DF169BE81734"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Year9",false,false,5);
if(repositoryColumnObj!=null)ProjectBudgetDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Year19 not found");}

if(rows.ContainsKey("153737E5-6626-4A69-8501-4AAD946A634A"))     elementData = rows["153737E5-6626-4A69-8501-4AAD946A634A"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"OverallAmount",false,false,3);
if(repositoryColumnObj!=null)ProjectBudgetDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-OverallBudgetTotal not found");}

if(rows.ContainsKey("6B169537-9858-4E64-9587-5454EDE7F799"))     elementData = rows["6B169537-9858-4E64-9587-5454EDE7F799"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Year4",false,false,5);
if(repositoryColumnObj!=null)ProjectBudgetDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Year14 not found");}

if(rows.ContainsKey("DDAC7A4B-1F58-4403-A731-A41BFE920BBB"))     elementData = rows["DDAC7A4B-1F58-4403-A731-A41BFE920BBB"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Year1",false,false,5);
if(repositoryColumnObj!=null)ProjectBudgetDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Year11 not found");}

elementData = ISpace["gv_UserId"].Value != null? Convert.ToString(ISpace["gv_UserId"].Value):null ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"UpdatedBy",false,false,6);
if(repositoryColumnObj!=null)ProjectBudgetDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-gv_UserId not found");}

if(rows.ContainsKey("B6B3B0F1-D9E6-442C-AD71-494FF4470030"))     elementData = rows["B6B3B0F1-D9E6-442C-AD71-494FF4470030"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Year3",false,false,5);
if(repositoryColumnObj!=null)ProjectBudgetDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Year13 not found");}

if(rows.ContainsKey("6EC8DDAB-B1F1-4D8C-9598-77E3827539D5"))     elementData = rows["6EC8DDAB-B1F1-4D8C-9598-77E3827539D5"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Year6",false,false,5);
if(repositoryColumnObj!=null)ProjectBudgetDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Year16 not found");}

if(rows.ContainsKey("E0DCC460-53C1-4953-90C3-C97266369DD1"))     elementData = rows["E0DCC460-53C1-4953-90C3-C97266369DD1"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Year11",false,false,5);
if(repositoryColumnObj!=null)ProjectBudgetDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Year21 not found");}

if(rows.ContainsKey("303EE107-01E7-49DF-94E6-F6461AC4CB48"))     elementData = rows["303EE107-01E7-49DF-94E6-F6461AC4CB48"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"BudgetDetailID",true,false,9);
if(repositoryColumnObj!=null)ProjectBudgetDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-ProjectBudgetDetailsid not found");}

if(rows.ContainsKey("7A91BE20-EB4E-4223-9FE5-5BE3A531F3FC"))     elementData = rows["7A91BE20-EB4E-4223-9FE5-5BE3A531F3FC"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Year10",false,false,5);
if(repositoryColumnObj!=null)ProjectBudgetDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Year20 not found");}

if(rows.ContainsKey("F85850E3-22D8-43A9-A14F-2D5283720AB0"))     elementData = rows["F85850E3-22D8-43A9-A14F-2D5283720AB0"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Comments",false,false,9);
if(repositoryColumnObj!=null)ProjectBudgetDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-commentss not found");}

if(rows.ContainsKey("85E319F5-14C8-44FA-9C41-0E3303FDCE8F"))     elementData = rows["85E319F5-14C8-44FA-9C41-0E3303FDCE8F"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Year12",false,false,5);
if(repositoryColumnObj!=null)ProjectBudgetDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Year22 not found");}

if(rows.ContainsKey("2E19ABDB-10E6-4785-8244-7863EA4FBCBC"))     elementData = rows["2E19ABDB-10E6-4785-8244-7863EA4FBCBC"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Year5",false,false,5);
if(repositoryColumnObj!=null)ProjectBudgetDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Year15 not found");}

if(rows.ContainsKey("B134B486-06FC-487E-BEA2-AE6F137D586C"))     elementData = rows["B134B486-06FC-487E-BEA2-AE6F137D586C"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Year8",false,false,5);
if(repositoryColumnObj!=null)ProjectBudgetDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Year18 not found");}

if(rows.ContainsKey("19DEC91D-3072-486C-947C-F5C3A8756745"))     elementData = rows["19DEC91D-3072-486C-947C-F5C3A8756745"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"RDOfficeComments",false,false,9);
if(repositoryColumnObj!=null)ProjectBudgetDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-RDComments not found");}
repositoryRowObj.Columns=ProjectBudgetDetails_colObj;
BudgetDetailsGridDomain_ProjectBudgetDetails_rowsObj.Add(repositoryRowObj);
}}

ProjectBudgetDetailsBudgetDetailsGridDomaintableObj.Rows=BudgetDetailsGridDomain_ProjectBudgetDetails_rowsObj;
var BudgetDetailsGridDomain_repoObj_status_ProjectBudgetDetails = BudgetDetailsGridDomain_repoObj.Execute(DomainOperationTypes.CreateOrUpdate,ref ProjectBudgetDetailsBudgetDetailsGridDomaintableObj);if(!BudgetDetailsGridDomain_repoObj_status_ProjectBudgetDetails) throw new Exception("Error in Execute Domain Data Map");}
base.WriteDebugInfo(@"Exiting DomainDataMap for Budget Details Grid Domain");
}
if(ISpace["ActiveEdit"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""ActiveEdit""].Value==1)");
base.WriteDebugInfo(@"Entering DomainDataMap for TempBudgetDetails");
var TempBudgetDetails_repoObj = new RepositoryMapper(DbTypes.SQLServer);


var TempProjectbudgetdetailsTempBudgetDetailstableObj = new RepositoryTable("TempProjectbudgetdetails");
  TempProjectbudgetdetailsTempBudgetDetailstableObj.AppConnectionSettingsId  ="CA34B07F-5D19-412F-A39F-3ADA64B5E0C0";TempProjectbudgetdetailsTempBudgetDetailstableObj.ProofConnectionId = "C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0)";
var TempBudgetDetails_TempProjectbudgetdetails_rows = GetElementClientData(ISpace["InstanceId"].Value,"C92F6C5D-F7CB-4E81-835C-3D655C7FCC52");

if(TempBudgetDetails_TempProjectbudgetdetails_rows!=null && TempBudgetDetails_TempProjectbudgetdetails_rows.Count>0){
var TempBudgetDetails_TempProjectbudgetdetails_rowsObj = new List<RepositoryRow>();
foreach(var rows in TempBudgetDetails_TempProjectbudgetdetails_rows){RepositoryRow repositoryRowObj = null;string elementData = null;RepositoryColumn repositoryColumnObj = null;if(rows !=null){ var TempProjectbudgetdetails_colObj = new List<RepositoryColumn>();repositoryRowObj= new RepositoryRow();//var myByte = (byte)rowData.Value.RwSt;//repositoryRowObj.RowState=(RepositoryRowState)myByte;

if(rows.ContainsKey("B6B3B0F1-D9E6-442C-AD71-494FF4470030"))     elementData = rows["B6B3B0F1-D9E6-442C-AD71-494FF4470030"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Year3",false,false,5);
if(repositoryColumnObj!=null)TempProjectbudgetdetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Year13 not found");}

if(rows.ContainsKey("303EE107-01E7-49DF-94E6-F6461AC4CB48"))     elementData = rows["303EE107-01E7-49DF-94E6-F6461AC4CB48"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"BudgetDetailID",true,false,9);
if(repositoryColumnObj!=null)TempProjectbudgetdetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-ProjectBudgetDetailsid not found");}

if(rows.ContainsKey("FD08EF20-802B-4672-8747-6D54C2D6D31E"))     elementData = rows["FD08EF20-802B-4672-8747-6D54C2D6D31E"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Year2",false,false,5);
if(repositoryColumnObj!=null)TempProjectbudgetdetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Year12 not found");}

if(rows.ContainsKey("6EC8DDAB-B1F1-4D8C-9598-77E3827539D5"))     elementData = rows["6EC8DDAB-B1F1-4D8C-9598-77E3827539D5"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Year6",false,false,5);
if(repositoryColumnObj!=null)TempProjectbudgetdetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Year16 not found");}

if(rows.ContainsKey("F7FB513A-721E-4E82-89DD-F03DF3E8AB16"))     elementData = rows["F7FB513A-721E-4E82-89DD-F03DF3E8AB16"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"BudgetID",false,false,5);
if(repositoryColumnObj!=null)TempProjectbudgetdetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Bid not found");}

if(rows.ContainsKey("A38311B1-68C6-462E-9DB6-FD90ABFF6E44"))     elementData = rows["A38311B1-68C6-462E-9DB6-FD90ABFF6E44"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"BudgetAmount",false,false,3);
if(repositoryColumnObj!=null)TempProjectbudgetdetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-BudgetAmount not found");}

if(rows.ContainsKey("E0DCC460-53C1-4953-90C3-C97266369DD1"))     elementData = rows["E0DCC460-53C1-4953-90C3-C97266369DD1"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Year11",false,false,5);
if(repositoryColumnObj!=null)TempProjectbudgetdetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Year21 not found");}

if(rows.ContainsKey("6B169537-9858-4E64-9587-5454EDE7F799"))     elementData = rows["6B169537-9858-4E64-9587-5454EDE7F799"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Year4",false,false,5);
if(repositoryColumnObj!=null)TempProjectbudgetdetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Year14 not found");}

if(rows.ContainsKey("153737E5-6626-4A69-8501-4AAD946A634A"))     elementData = rows["153737E5-6626-4A69-8501-4AAD946A634A"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"OverallAmount",false,false,3);
if(repositoryColumnObj!=null)TempProjectbudgetdetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-OverallBudgetTotal not found");}

if(rows.ContainsKey("19DEC91D-3072-486C-947C-F5C3A8756745"))     elementData = rows["19DEC91D-3072-486C-947C-F5C3A8756745"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"RDOfficeComments",false,false,9);
if(repositoryColumnObj!=null)TempProjectbudgetdetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-RDComments not found");}

if(rows.ContainsKey("85E319F5-14C8-44FA-9C41-0E3303FDCE8F"))     elementData = rows["85E319F5-14C8-44FA-9C41-0E3303FDCE8F"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Year12",false,false,5);
if(repositoryColumnObj!=null)TempProjectbudgetdetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Year22 not found");}

if(rows.ContainsKey("67FD82A6-A670-4DD2-8574-AAD959805F77"))     elementData = rows["67FD82A6-A670-4DD2-8574-AAD959805F77"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Year7",false,false,5);
if(repositoryColumnObj!=null)TempProjectbudgetdetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Year17 not found");}

if(rows.ContainsKey("2E19ABDB-10E6-4785-8244-7863EA4FBCBC"))     elementData = rows["2E19ABDB-10E6-4785-8244-7863EA4FBCBC"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Year5",false,false,5);
if(repositoryColumnObj!=null)TempProjectbudgetdetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Year15 not found");}

elementData = ISpace["gv_UserId"].Value != null? Convert.ToString(ISpace["gv_UserId"].Value):null ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"UpdatedBy",false,false,6);
if(repositoryColumnObj!=null)TempProjectbudgetdetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-gv_UserId not found");}

if(rows.ContainsKey("2833427C-A5F6-43D0-9A15-E33760BA7E46"))     elementData = rows["2833427C-A5F6-43D0-9A15-E33760BA7E46"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"TempInstanceid",false,false,9);
if(repositoryColumnObj!=null)TempProjectbudgetdetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-TempInstanceID not found");}

if(rows.ContainsKey("DDAC7A4B-1F58-4403-A731-A41BFE920BBB"))     elementData = rows["DDAC7A4B-1F58-4403-A731-A41BFE920BBB"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Year1",false,false,3);
if(repositoryColumnObj!=null)TempProjectbudgetdetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Year11 not found");}

if(rows.ContainsKey("F85850E3-22D8-43A9-A14F-2D5283720AB0"))     elementData = rows["F85850E3-22D8-43A9-A14F-2D5283720AB0"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Comments",false,false,9);
if(repositoryColumnObj!=null)TempProjectbudgetdetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-commentss not found");}

if(rows.ContainsKey("B134B486-06FC-487E-BEA2-AE6F137D586C"))     elementData = rows["B134B486-06FC-487E-BEA2-AE6F137D586C"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Year8",false,false,5);
if(repositoryColumnObj!=null)TempProjectbudgetdetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Year18 not found");}

elementData = CurrentDate().ToString() ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"UpdatedOn",false,false,8);
if(repositoryColumnObj!=null)TempProjectbudgetdetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-CurrentDate not found");}

if(rows.ContainsKey("B5948E98-0ABA-493A-A2DB-DF169BE81734"))     elementData = rows["B5948E98-0ABA-493A-A2DB-DF169BE81734"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Year9",false,false,5);
if(repositoryColumnObj!=null)TempProjectbudgetdetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Year19 not found");}

if(rows.ContainsKey("49074D93-7C7F-401F-AD44-0BB2B5353FE3"))     elementData = rows["49074D93-7C7F-401F-AD44-0BB2B5353FE3"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ProjectDetailsID",false,false,9);
if(repositoryColumnObj!=null)TempProjectbudgetdetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-ID1 not found");}

if(rows.ContainsKey("7A91BE20-EB4E-4223-9FE5-5BE3A531F3FC"))     elementData = rows["7A91BE20-EB4E-4223-9FE5-5BE3A531F3FC"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Year10",false,false,5);
if(repositoryColumnObj!=null)TempProjectbudgetdetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Year20 not found");}
repositoryRowObj.Columns=TempProjectbudgetdetails_colObj;
TempBudgetDetails_TempProjectbudgetdetails_rowsObj.Add(repositoryRowObj);
}}

TempProjectbudgetdetailsTempBudgetDetailstableObj.Rows=TempBudgetDetails_TempProjectbudgetdetails_rowsObj;
var TempBudgetDetails_repoObj_status_TempProjectbudgetdetails = TempBudgetDetails_repoObj.Execute(DomainOperationTypes.CreateOrUpdate,ref TempProjectbudgetdetailsTempBudgetDetailstableObj);if(!TempBudgetDetails_repoObj_status_TempProjectbudgetdetails) throw new Exception("Error in Execute Domain Data Map");}
base.WriteDebugInfo(@"Exiting DomainDataMap for TempBudgetDetails");
}
if(ISpace["ActiveEdit"].Value==0)
{
base.WriteDebugInfo(@"if(ISpace[""ActiveEdit""].Value==0)");

var querySource69D87FBD9BEB47BEB916F267A651A953 =GetQueryExpressionDataSource("69D87FBD-9BEB-47BE-B916-F267A651A953");

DataTable result69D87FBD9BEB47BEB916F267A651A953=iSpace.SetGridDataSource(querySource69D87FBD9BEB47BEB916F267A651A953, _objectFactory.GetGridRPP("BudgetDetails"),@"EXEC [GetProjectDetailCombo] 1,'" + ISpace["ID1"].Value + @"'");

iSpace.InsertGridBindDetails("BudgetDetails","11",querySource69D87FBD9BEB47BEB916F267A651A953,"EXEC [GetProjectDetailCombo] 1,'" + ISpace["ID1"].Value + @"'",_objectFactory.GetGridRPP("BudgetDetails"));

base.WriteDebugInfo(@"var querySource69D87FBD9BEB47BEB916F267A651A953 =GetQueryExpressionDataSource(""69D87FBD-9BEB-47BE-B916-F267A651A953"");DataTable result69D87FBD9BEB47BEB916F267A651A953=iSpace.SetGridDataSource(querySource69D87FBD9BEB47BEB916F267A651A953, _objectFactory.GetGridRPP(""BudgetDetails""),@""EXEC [GetProjectDetailCombo] 1,'"" + ISpace[""ID1""].Value + @""'"");iSpace.InsertGridBindDetails(""BudgetDetails"",""11"",querySource69D87FBD9BEB47BEB916F267A651A953,""EXEC [GetProjectDetailCombo] 1,'"" + ISpace[""ID1""].Value + @""'"",_objectFactory.GetGridRPP(""BudgetDetails""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> resultCF752EE8E74240ED941907B9622045EE=acdataIspaceD0B6EBB910A44D43A76EF39441A41EF6.GetQueryExpressionBindings("CF752EE8-E742-40ED-9419-07B9622045EE");
iSpace.SetGridData(result69D87FBD9BEB47BEB916F267A651A953,resultCF752EE8E74240ED941907B9622045EE,"BudgetDetails",ref ISpace);
iSpace.UpdateGridBindDetails("BudgetDetails",resultCF752EE8E74240ED941907B9622045EE);
}
if(ISpace["ActiveEdit"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""ActiveEdit""].Value==1)");

var querySource50B1C2C117D643DDAABC875561B59218 =GetQueryExpressionDataSource("50B1C2C1-17D6-43DD-AABC-875561B59218");

DataTable result50B1C2C117D643DDAABC875561B59218=iSpace.SetGridDataSource(querySource50B1C2C117D643DDAABC875561B59218, _objectFactory.GetGridRPP("BudgetDetails"),@"EXEC [GetProjectDetailCombo] 15,'" + ISpace["ID1"].Value + @"'");

iSpace.InsertGridBindDetails("BudgetDetails","11",querySource50B1C2C117D643DDAABC875561B59218,"EXEC [GetProjectDetailCombo] 15,'" + ISpace["ID1"].Value + @"'",_objectFactory.GetGridRPP("BudgetDetails"));

base.WriteDebugInfo(@"var querySource50B1C2C117D643DDAABC875561B59218 =GetQueryExpressionDataSource(""50B1C2C1-17D6-43DD-AABC-875561B59218"");DataTable result50B1C2C117D643DDAABC875561B59218=iSpace.SetGridDataSource(querySource50B1C2C117D643DDAABC875561B59218, _objectFactory.GetGridRPP(""BudgetDetails""),@""EXEC [GetProjectDetailCombo] 15,'"" + ISpace[""ID1""].Value + @""'"");iSpace.InsertGridBindDetails(""BudgetDetails"",""11"",querySource50B1C2C117D643DDAABC875561B59218,""EXEC [GetProjectDetailCombo] 15,'"" + ISpace[""ID1""].Value + @""'"",_objectFactory.GetGridRPP(""BudgetDetails""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> resultE0FCE3633C384ED1AEF447B229CAACA2=acdataIspaceD0B6EBB910A44D43A76EF39441A41EF6.GetQueryExpressionBindings("E0FCE363-3C38-4ED1-AEF4-47B229CAACA2");
iSpace.SetGridData(result50B1C2C117D643DDAABC875561B59218,resultE0FCE3633C384ED1AEF447B229CAACA2,"BudgetDetails",ref ISpace);
iSpace.UpdateGridBindDetails("BudgetDetails",resultE0FCE3633C384ED1AEF447B229CAACA2);
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mp_hrapermonth (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MP_HRAperMonth-OnChange");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"#BudgetDetails[Rows]");
iSpace.GetLoopExpressionData("BudgetDetails",ref ISpace);

foreach(var gridChild in ISpace["BudgetDetails"].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 


if(
ISpace["Bid"].Value==7)
{
base.WriteDebugInfo(@"
if(
ISpace[""Bid""].Value==7)");
ISpace["ManPowerAmount"].Value=ISpace["BudgetAmount"].Value;
base.WriteDebugInfo(@"ISpace[""ManPowerAmount""].Value=ISpace[""BudgetAmount""].Value;");
}
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("BudgetDetails","C92F6C5D-F7CB-4E81-835C-3D655C7FCC52",_objectFactory.GetGridRPP("BudgetDetails"),_elementBase.GetGridLoopQuery("C92F6C5D-F7CB-4E81-835C-3D655C7FCC52","BudgetDetails",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""BudgetDetails"",ref ISpace);

foreach(var gridChild in ISpace[""BudgetDetails""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
if(ISpace["ManpowerTotalCost"].Value>ISpace["ManPowerAmount"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""ManpowerTotalCost""].Value>ISpace[""ManPowerAmount""].Value)");
ISpace["Message"].Value=@"ManPower Total Cost is greater than Manpower Budget";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""ManPower Total Cost is greater than Manpower Budget"";");
ISpace["MP_No"].Value=null;
base.WriteDebugInfo(@"ISpace[""MP_No""].Value=null;");
ISpace["MP_RatePerMonth"].Value=null;
base.WriteDebugInfo(@"ISpace[""MP_RatePerMonth""].Value=null;");
ISpace["MP_HRAPer"].Value=0;
base.WriteDebugInfo(@"ISpace[""MP_HRAPer""].Value=0;");
ISpace["MP_TotalPerMonth"].Value=0;
base.WriteDebugInfo(@"ISpace[""MP_TotalPerMonth""].Value=0;");
ISpace["MP_TotalMonths"].Value=null;
base.WriteDebugInfo(@"ISpace[""MP_TotalMonths""].Value=null;");
ISpace["MP_ManpowerTotalCost"].Value=0;
base.WriteDebugInfo(@"ISpace[""MP_ManpowerTotalCost""].Value=0;");
object MP_ManpowerTotalCost=iSpace.Sum("[]","MP_ManpowerTotalCost","",ISpace["gv_instanceid"].Value);
ISpace["ManpowerTotalCost"].Value=Convert.ChangeType(MP_ManpowerTotalCost, MP_ManpowerTotalCost.GetType());;
base.WriteDebugInfo(@"object MP_ManpowerTotalCost=iSpace.Sum(""[]"",""MP_ManpowerTotalCost"","""",ISpace[""gv_instanceid""].Value);
ISpace[""ManpowerTotalCost""].Value=Convert.ChangeType(MP_ManpowerTotalCost, MP_ManpowerTotalCost.GetType());;");
return;
base.WriteDebugInfo(@"return;");
}
}
ISpace["MP_HRAPercal"].Value=ISpace["MP_HRAPer"].Value/100.0;
base.WriteDebugInfo(@"ISpace[""MP_HRAPercal""].Value=ISpace[""MP_HRAPer""].Value/100.0;");
ISpace["MP_HRAperMonth"].Value=ISpace["MP_RatePerMonth"].Value*ISpace["MP_HRAPercal"].Value;
base.WriteDebugInfo(@"ISpace[""MP_HRAperMonth""].Value=ISpace[""MP_RatePerMonth""].Value*ISpace[""MP_HRAPercal""].Value;");
ISpace["MP_TotalPerMonth"].Value=ISpace["MP_RatePerMonth"].Value+ISpace["MP_HRAperMonth"].Value;
base.WriteDebugInfo(@"ISpace[""MP_TotalPerMonth""].Value=ISpace[""MP_RatePerMonth""].Value+ISpace[""MP_HRAperMonth""].Value;");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mp_ratepermonth (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MP_RatePerMonth-OnChange");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"#BudgetDetails[Rows]");
iSpace.GetLoopExpressionData("BudgetDetails",ref ISpace);

foreach(var gridChild in ISpace["BudgetDetails"].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 


if(
ISpace["Bid"].Value==7)
{
base.WriteDebugInfo(@"
if(
ISpace[""Bid""].Value==7)");
ISpace["ManPowerAmount"].Value=ISpace["BudgetAmount"].Value;
base.WriteDebugInfo(@"ISpace[""ManPowerAmount""].Value=ISpace[""BudgetAmount""].Value;");
}
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("BudgetDetails","C92F6C5D-F7CB-4E81-835C-3D655C7FCC52",_objectFactory.GetGridRPP("BudgetDetails"),_elementBase.GetGridLoopQuery("C92F6C5D-F7CB-4E81-835C-3D655C7FCC52","BudgetDetails",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""BudgetDetails"",ref ISpace);

foreach(var gridChild in ISpace[""BudgetDetails""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
if(ISpace["ManpowerTotalCost"].Value>ISpace["ManPowerAmount"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""ManpowerTotalCost""].Value>ISpace[""ManPowerAmount""].Value)");
ISpace["Message"].Value=@"ManPower Total Cost is greater than Manpower Budget";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""ManPower Total Cost is greater than Manpower Budget"";");
ISpace["MP_No"].Value=null;
base.WriteDebugInfo(@"ISpace[""MP_No""].Value=null;");
ISpace["MP_RatePerMonth"].Value=null;
base.WriteDebugInfo(@"ISpace[""MP_RatePerMonth""].Value=null;");
ISpace["MP_HRAPer"].Value=0;
base.WriteDebugInfo(@"ISpace[""MP_HRAPer""].Value=0;");
ISpace["MP_TotalPerMonth"].Value=0;
base.WriteDebugInfo(@"ISpace[""MP_TotalPerMonth""].Value=0;");
ISpace["MP_TotalMonths"].Value=null;
base.WriteDebugInfo(@"ISpace[""MP_TotalMonths""].Value=null;");
ISpace["MP_ManpowerTotalCost"].Value=0;
base.WriteDebugInfo(@"ISpace[""MP_ManpowerTotalCost""].Value=0;");
object MP_ManpowerTotalCost=iSpace.Sum("[]","MP_ManpowerTotalCost","",ISpace["gv_instanceid"].Value);
ISpace["ManpowerTotalCost"].Value=Convert.ChangeType(MP_ManpowerTotalCost, MP_ManpowerTotalCost.GetType());;
base.WriteDebugInfo(@"object MP_ManpowerTotalCost=iSpace.Sum(""[]"",""MP_ManpowerTotalCost"","""",ISpace[""gv_instanceid""].Value);
ISpace[""ManpowerTotalCost""].Value=Convert.ChangeType(MP_ManpowerTotalCost, MP_ManpowerTotalCost.GetType());;");
return;
base.WriteDebugInfo(@"return;");
}
}
ISpace["MP_HRAPercal"].Value=ISpace["MP_HRAPer"].Value/100.0;
base.WriteDebugInfo(@"ISpace[""MP_HRAPercal""].Value=ISpace[""MP_HRAPer""].Value/100.0;");
ISpace["MP_HRAperMonth"].Value=ISpace["MP_RatePerMonth"].Value*ISpace["MP_HRAPercal"].Value;
base.WriteDebugInfo(@"ISpace[""MP_HRAperMonth""].Value=ISpace[""MP_RatePerMonth""].Value*ISpace[""MP_HRAPercal""].Value;");
ISpace["MP_TotalPerMonth"].Value=ISpace["MP_RatePerMonth"].Value+ISpace["MP_HRAperMonth"].Value;
base.WriteDebugInfo(@"ISpace[""MP_TotalPerMonth""].Value=ISpace[""MP_RatePerMonth""].Value+ISpace[""MP_HRAperMonth""].Value;");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_eqequipmentrateininr (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"EQEquipmentRateinINR-OnChange");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["EQEquipmentTotalCost"].Value=ISpace["EQEquipmentRateinINR"].Value*ISpace["EQEquipmentQuantity"].Value;
base.WriteDebugInfo(@"ISpace[""EQEquipmentTotalCost""].Value=ISpace[""EQEquipmentRateinINR""].Value*ISpace[""EQEquipmentQuantity""].Value;");
object EQEquipmentTotalCost=iSpace.Sum("[71802A68-968A-4C2C-8AFE-32BA5B817B50]","EQEquipmentTotalCost","",ISpace["gv_instanceid"].Value);
ISpace["EquipmentTotalCost"].Value=Convert.ChangeType(EQEquipmentTotalCost, EQEquipmentTotalCost.GetType());;
base.WriteDebugInfo(@"object EQEquipmentTotalCost=iSpace.Sum(""[71802A68-968A-4C2C-8AFE-32BA5B817B50]"",""EQEquipmentTotalCost"","""",ISpace[""gv_instanceid""].Value);
ISpace[""EquipmentTotalCost""].Value=Convert.ChangeType(EQEquipmentTotalCost, EQEquipmentTotalCost.GetType());;");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"#BudgetDetails[Rows]");
iSpace.GetLoopExpressionData("BudgetDetails",ref ISpace);

foreach(var gridChild in ISpace["BudgetDetails"].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 


if(
ISpace["Bid"].Value==2)
{
base.WriteDebugInfo(@"
if(
ISpace[""Bid""].Value==2)");
ISpace["EquipmentAmount"].Value=ISpace["BudgetAmount"].Value;
base.WriteDebugInfo(@"ISpace[""EquipmentAmount""].Value=ISpace[""BudgetAmount""].Value;");
}
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("BudgetDetails","C92F6C5D-F7CB-4E81-835C-3D655C7FCC52",_objectFactory.GetGridRPP("BudgetDetails"),_elementBase.GetGridLoopQuery("C92F6C5D-F7CB-4E81-835C-3D655C7FCC52","BudgetDetails",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""BudgetDetails"",ref ISpace);

foreach(var gridChild in ISpace[""BudgetDetails""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
if(ISpace["EquipmentTotalCost"].Value>ISpace["EquipmentAmount"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""EquipmentTotalCost""].Value>ISpace[""EquipmentAmount""].Value)");
ISpace["Message"].Value=@"Equipment Total Cost is greater than Equipmet Budget";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Equipment Total Cost is greater than Equipmet Budget"";");
ISpace["EQEquipmentQuantity"].Value=null;
base.WriteDebugInfo(@"ISpace[""EQEquipmentQuantity""].Value=null;");
ISpace["EQEquipmentRateinINR"].Value=null;
base.WriteDebugInfo(@"ISpace[""EQEquipmentRateinINR""].Value=null;");
ISpace["EQEquipmentTotalCost"].Value=0;
base.WriteDebugInfo(@"ISpace[""EQEquipmentTotalCost""].Value=0;");
object EQEquipmentTotalCost=iSpace.Sum("[71802A68-968A-4C2C-8AFE-32BA5B817B50]","EQEquipmentTotalCost","",ISpace["gv_instanceid"].Value);
ISpace["EquipmentTotalCost"].Value=Convert.ChangeType(EQEquipmentTotalCost, EQEquipmentTotalCost.GetType());;
base.WriteDebugInfo(@"object EQEquipmentTotalCost=iSpace.Sum(""[71802A68-968A-4C2C-8AFE-32BA5B817B50]"",""EQEquipmentTotalCost"","""",ISpace[""gv_instanceid""].Value);
ISpace[""EquipmentTotalCost""].Value=Convert.ChangeType(EQEquipmentTotalCost, EQEquipmentTotalCost.GetType());;");
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
private void SubscribeElementEvents_budgetclose (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"BudgetClose-OnClick");
ISpace["UI_CD3"].HideDialog=true;;
base.WriteDebugInfo(@"ISpace[""UI_CD3""].HideDialog=true;;");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_bcancel (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"BCancel-OnClick");

ISpace["RedirectUrl"].RedirectType="R";
ISpace["RedirectUrl"].Value="?PkActMId=80BA7272-EBDB-40E4-8780-BBCFE9F7BF42&frmElementId=EC0A9909-7B20-47F6-BC2E-A127EFE2DF19&PkPrMId=2FC376A8-EF63-4E6A-BADA-9EC15ECC14A1&formVersionId=BF48F261-7346-4E90-B167-CAF0E476DD36&Ver=0.0000";
base.WriteDebugInfo(@"
ISpace[""RedirectUrl""].RedirectType=""R"";
ISpace[""RedirectUrl""].Value=""?PkActMId=80BA7272-EBDB-40E4-8780-BBCFE9F7BF42&frmElementId=EC0A9909-7B20-47F6-BC2E-A127EFE2DF19&PkPrMId=2FC376A8-EF63-4E6A-BADA-9EC15ECC14A1&formVersionId=BF48F261-7346-4E90-B167-CAF0E476DD36&Ver=0.0000"";");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_fundingacencyname (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"FundingAcencyName-OnChange");
ISpace["SchemeType"].rElemData=iSpace.Reload(ISpace["SchemeType"].Value,@"EXEC GetProjectDetailCombo 5,'" + ISpace["FundingAcencyName"].Value + @"'","40BDEB14-07CC-4150-8A52-9B088A428E2D");
base.WriteDebugInfo(@"ISpace[""SchemeType""].rElemData=iSpace.Reload(ISpace[""SchemeType""].Value,@""EXEC GetProjectDetailCombo 5,'"" + ISpace[""FundingAcencyName""].Value + @""'"",""40BDEB14-07CC-4150-8A52-9B088A428E2D"");");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_facultytype (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"FacultyType-OnChange");
ISpace["ExternalDepartment"].rElemData=iSpace.Reload(ISpace["ExternalDepartment"].Value,@"EXEC [GetDepartmentWiseFacultyCopi] '" + ISpace["Dept"].Value + @"',2,'" + ISpace["DummyInstance"].Value + @"','" + ISpace["facultytype"].Value + @"'","40BDEB14-07CC-4150-8A52-9B088A428E2D");
base.WriteDebugInfo(@"ISpace[""ExternalDepartment""].rElemData=iSpace.Reload(ISpace[""ExternalDepartment""].Value,@""EXEC [GetDepartmentWiseFacultyCopi] '"" + ISpace[""Dept""].Value + @""',2,'"" + ISpace[""DummyInstance""].Value + @""','"" + ISpace[""facultytype""].Value + @""'"",""40BDEB14-07CC-4150-8A52-9B088A428E2D"");");
ISpace["Name"].rElemData=iSpace.Reload(ISpace["Name"].Value,@"EXEC GetDepartmentWiseFacultyCopi '" + ISpace["ExternalDepartment"].Value + @"',3,'" + ISpace["DummyInstance"].Value + @"',''","40BDEB14-07CC-4150-8A52-9B088A428E2D");
base.WriteDebugInfo(@"ISpace[""Name""].rElemData=iSpace.Reload(ISpace[""Name""].Value,@""EXEC GetDepartmentWiseFacultyCopi '"" + ISpace[""ExternalDepartment""].Value + @""',3,'"" + ISpace[""DummyInstance""].Value + @""',''"",""40BDEB14-07CC-4150-8A52-9B088A428E2D"");");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_year17 (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Year17-OnChange");
ISpace["BudgetAmount"].Value= ISpace["Year11"].Value+ISpace["Year12"].Value+ISpace["Year13"].Value+ISpace["Year14"].Value+ISpace["Year15"].Value+ISpace["Year16"].Value+ISpace["Year17"].Value+ISpace["Year18"].Value+ISpace["Year19"].Value+ISpace["Year20"].Value+ISpace["Year21"].Value+ISpace["Year22"].Value;
base.WriteDebugInfo(@"ISpace[""BudgetAmount""].Value= ISpace[""Year11""].Value+ISpace[""Year12""].Value+ISpace[""Year13""].Value+ISpace[""Year14""].Value+ISpace[""Year15""].Value+ISpace[""Year16""].Value+ISpace[""Year17""].Value+ISpace[""Year18""].Value+ISpace[""Year19""].Value+ISpace[""Year20""].Value+ISpace[""Year21""].Value+ISpace[""Year22""].Value;");
ISpace["RecurringAmount"].Value=0;
base.WriteDebugInfo(@"ISpace[""RecurringAmount""].Value=0;");
ISpace["NonRecurringAmount"].Value=0;
base.WriteDebugInfo(@"ISpace[""NonRecurringAmount""].Value=0;");
object BudgetAmount=iSpace.Sum("[C92F6C5D-F7CB-4E81-835C-3D655C7FCC52]","BudgetAmount","",ISpace["gv_instanceid"].Value);
ISpace["OverallBudgetTotal"].Value=Convert.ChangeType(BudgetAmount, BudgetAmount.GetType());;
base.WriteDebugInfo(@"object BudgetAmount=iSpace.Sum(""[C92F6C5D-F7CB-4E81-835C-3D655C7FCC52]"",""BudgetAmount"","""",ISpace[""gv_instanceid""].Value);
ISpace[""OverallBudgetTotal""].Value=Convert.ChangeType(BudgetAmount, BudgetAmount.GetType());;");
if(1==2)
{
base.WriteDebugInfo(@"if(1==2)");
base.WriteDebugInfo(@"#BudgetDetails[Rows]");
iSpace.GetLoopExpressionData("BudgetDetails",ref ISpace);

foreach(var gridChild in ISpace["BudgetDetails"].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 


if(
ISpace["RecurringValidation"].Value==518)
{
base.WriteDebugInfo(@"
if(
ISpace[""RecurringValidation""].Value==518)");
object BudgetAmount=iSpace.Sum("[C92F6C5D-F7CB-4E81-835C-3D655C7FCC52]","BudgetAmount","",ISpace["gv_instanceid"].Value);
ISpace["RecurringAmount"].Value=Convert.ChangeType(BudgetAmount, BudgetAmount.GetType());;
base.WriteDebugInfo(@"object BudgetAmount=iSpace.Sum(""[C92F6C5D-F7CB-4E81-835C-3D655C7FCC52]"",""BudgetAmount"","""",ISpace[""gv_instanceid""].Value);
ISpace[""RecurringAmount""].Value=Convert.ChangeType(BudgetAmount, BudgetAmount.GetType());;");
}
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("BudgetDetails","C92F6C5D-F7CB-4E81-835C-3D655C7FCC52",_objectFactory.GetGridRPP("BudgetDetails"),_elementBase.GetGridLoopQuery("C92F6C5D-F7CB-4E81-835C-3D655C7FCC52","BudgetDetails",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""BudgetDetails"",ref ISpace);

foreach(var gridChild in ISpace[""BudgetDetails""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
}
base.WriteDebugInfo(@"#BudgetDetails[Rows]");
iSpace.GetLoopExpressionData("BudgetDetails",ref ISpace);

foreach(var gridChild in ISpace["BudgetDetails"].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 


if(
ISpace["RecurringValidation"].Value==519)
{
base.WriteDebugInfo(@"
if(
ISpace[""RecurringValidation""].Value==519)");
ISpace["NonRecurringAmount"].Value=ISpace["NonRecurringAmount"].Value+ISpace["BudgetAmount"].Value;
base.WriteDebugInfo(@"ISpace[""NonRecurringAmount""].Value=ISpace[""NonRecurringAmount""].Value+ISpace[""BudgetAmount""].Value;");
}

if(
ISpace["RecurringValidation"].Value==518)
{
base.WriteDebugInfo(@"
if(
ISpace[""RecurringValidation""].Value==518)");
ISpace["RecurringAmount"].Value=ISpace["RecurringAmount"].Value+ISpace["BudgetAmount"].Value;
base.WriteDebugInfo(@"ISpace[""RecurringAmount""].Value=ISpace[""RecurringAmount""].Value+ISpace[""BudgetAmount""].Value;");
}
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("BudgetDetails","C92F6C5D-F7CB-4E81-835C-3D655C7FCC52",_objectFactory.GetGridRPP("BudgetDetails"),_elementBase.GetGridLoopQuery("C92F6C5D-F7CB-4E81-835C-3D655C7FCC52","BudgetDetails",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""BudgetDetails"",ref ISpace);

foreach(var gridChild in ISpace[""BudgetDetails""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_year14 (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Year14-OnChange");
ISpace["BudgetAmount"].Value= ISpace["Year11"].Value+ISpace["Year12"].Value+ISpace["Year13"].Value+ISpace["Year14"].Value+ISpace["Year15"].Value+ISpace["Year16"].Value+ISpace["Year17"].Value+ISpace["Year18"].Value+ISpace["Year19"].Value+ISpace["Year20"].Value+ISpace["Year21"].Value+ISpace["Year22"].Value;
base.WriteDebugInfo(@"ISpace[""BudgetAmount""].Value= ISpace[""Year11""].Value+ISpace[""Year12""].Value+ISpace[""Year13""].Value+ISpace[""Year14""].Value+ISpace[""Year15""].Value+ISpace[""Year16""].Value+ISpace[""Year17""].Value+ISpace[""Year18""].Value+ISpace[""Year19""].Value+ISpace[""Year20""].Value+ISpace[""Year21""].Value+ISpace[""Year22""].Value;");
ISpace["RecurringAmount"].Value=0;
base.WriteDebugInfo(@"ISpace[""RecurringAmount""].Value=0;");
ISpace["NonRecurringAmount"].Value=0;
base.WriteDebugInfo(@"ISpace[""NonRecurringAmount""].Value=0;");
object BudgetAmount=iSpace.Sum("[C92F6C5D-F7CB-4E81-835C-3D655C7FCC52]","BudgetAmount","",ISpace["gv_instanceid"].Value);
ISpace["OverallBudgetTotal"].Value=Convert.ChangeType(BudgetAmount, BudgetAmount.GetType());;
base.WriteDebugInfo(@"object BudgetAmount=iSpace.Sum(""[C92F6C5D-F7CB-4E81-835C-3D655C7FCC52]"",""BudgetAmount"","""",ISpace[""gv_instanceid""].Value);
ISpace[""OverallBudgetTotal""].Value=Convert.ChangeType(BudgetAmount, BudgetAmount.GetType());;");
if(1==2)
{
base.WriteDebugInfo(@"if(1==2)");
base.WriteDebugInfo(@"#BudgetDetails[Rows]");
iSpace.GetLoopExpressionData("BudgetDetails",ref ISpace);

foreach(var gridChild in ISpace["BudgetDetails"].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 


if(
ISpace["RecurringValidation"].Value==518)
{
base.WriteDebugInfo(@"
if(
ISpace[""RecurringValidation""].Value==518)");
object BudgetAmount=iSpace.Sum("[C92F6C5D-F7CB-4E81-835C-3D655C7FCC52]","BudgetAmount","",ISpace["gv_instanceid"].Value);
ISpace["RecurringAmount"].Value=Convert.ChangeType(BudgetAmount, BudgetAmount.GetType());;
base.WriteDebugInfo(@"object BudgetAmount=iSpace.Sum(""[C92F6C5D-F7CB-4E81-835C-3D655C7FCC52]"",""BudgetAmount"","""",ISpace[""gv_instanceid""].Value);
ISpace[""RecurringAmount""].Value=Convert.ChangeType(BudgetAmount, BudgetAmount.GetType());;");
}
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("BudgetDetails","C92F6C5D-F7CB-4E81-835C-3D655C7FCC52",_objectFactory.GetGridRPP("BudgetDetails"),_elementBase.GetGridLoopQuery("C92F6C5D-F7CB-4E81-835C-3D655C7FCC52","BudgetDetails",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""BudgetDetails"",ref ISpace);

foreach(var gridChild in ISpace[""BudgetDetails""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
}
base.WriteDebugInfo(@"#BudgetDetails[Rows]");
iSpace.GetLoopExpressionData("BudgetDetails",ref ISpace);

foreach(var gridChild in ISpace["BudgetDetails"].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 


if(
ISpace["RecurringValidation"].Value==519)
{
base.WriteDebugInfo(@"
if(
ISpace[""RecurringValidation""].Value==519)");
ISpace["NonRecurringAmount"].Value=ISpace["NonRecurringAmount"].Value+ISpace["BudgetAmount"].Value;
base.WriteDebugInfo(@"ISpace[""NonRecurringAmount""].Value=ISpace[""NonRecurringAmount""].Value+ISpace[""BudgetAmount""].Value;");
}

if(
ISpace["RecurringValidation"].Value==518)
{
base.WriteDebugInfo(@"
if(
ISpace[""RecurringValidation""].Value==518)");
ISpace["RecurringAmount"].Value=ISpace["RecurringAmount"].Value+ISpace["BudgetAmount"].Value;
base.WriteDebugInfo(@"ISpace[""RecurringAmount""].Value=ISpace[""RecurringAmount""].Value+ISpace[""BudgetAmount""].Value;");
}
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("BudgetDetails","C92F6C5D-F7CB-4E81-835C-3D655C7FCC52",_objectFactory.GetGridRPP("BudgetDetails"),_elementBase.GetGridLoopQuery("C92F6C5D-F7CB-4E81-835C-3D655C7FCC52","BudgetDetails",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""BudgetDetails"",ref ISpace);

foreach(var gridChild in ISpace[""BudgetDetails""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_year16 (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Year16-OnChange");
ISpace["BudgetAmount"].Value= ISpace["Year11"].Value+ISpace["Year12"].Value+ISpace["Year13"].Value+ISpace["Year14"].Value+ISpace["Year15"].Value+ISpace["Year16"].Value+ISpace["Year17"].Value+ISpace["Year18"].Value+ISpace["Year19"].Value+ISpace["Year20"].Value+ISpace["Year21"].Value+ISpace["Year22"].Value;
base.WriteDebugInfo(@"ISpace[""BudgetAmount""].Value= ISpace[""Year11""].Value+ISpace[""Year12""].Value+ISpace[""Year13""].Value+ISpace[""Year14""].Value+ISpace[""Year15""].Value+ISpace[""Year16""].Value+ISpace[""Year17""].Value+ISpace[""Year18""].Value+ISpace[""Year19""].Value+ISpace[""Year20""].Value+ISpace[""Year21""].Value+ISpace[""Year22""].Value;");
ISpace["RecurringAmount"].Value=0;
base.WriteDebugInfo(@"ISpace[""RecurringAmount""].Value=0;");
ISpace["NonRecurringAmount"].Value=0;
base.WriteDebugInfo(@"ISpace[""NonRecurringAmount""].Value=0;");
object BudgetAmount=iSpace.Sum("[C92F6C5D-F7CB-4E81-835C-3D655C7FCC52]","BudgetAmount","",ISpace["gv_instanceid"].Value);
ISpace["OverallBudgetTotal"].Value=Convert.ChangeType(BudgetAmount, BudgetAmount.GetType());;
base.WriteDebugInfo(@"object BudgetAmount=iSpace.Sum(""[C92F6C5D-F7CB-4E81-835C-3D655C7FCC52]"",""BudgetAmount"","""",ISpace[""gv_instanceid""].Value);
ISpace[""OverallBudgetTotal""].Value=Convert.ChangeType(BudgetAmount, BudgetAmount.GetType());;");
if(1==2)
{
base.WriteDebugInfo(@"if(1==2)");
base.WriteDebugInfo(@"#BudgetDetails[Rows]");
iSpace.GetLoopExpressionData("BudgetDetails",ref ISpace);

foreach(var gridChild in ISpace["BudgetDetails"].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 


if(
ISpace["RecurringValidation"].Value==518)
{
base.WriteDebugInfo(@"
if(
ISpace[""RecurringValidation""].Value==518)");
object BudgetAmount=iSpace.Sum("[C92F6C5D-F7CB-4E81-835C-3D655C7FCC52]","BudgetAmount","",ISpace["gv_instanceid"].Value);
ISpace["RecurringAmount"].Value=Convert.ChangeType(BudgetAmount, BudgetAmount.GetType());;
base.WriteDebugInfo(@"object BudgetAmount=iSpace.Sum(""[C92F6C5D-F7CB-4E81-835C-3D655C7FCC52]"",""BudgetAmount"","""",ISpace[""gv_instanceid""].Value);
ISpace[""RecurringAmount""].Value=Convert.ChangeType(BudgetAmount, BudgetAmount.GetType());;");
}
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("BudgetDetails","C92F6C5D-F7CB-4E81-835C-3D655C7FCC52",_objectFactory.GetGridRPP("BudgetDetails"),_elementBase.GetGridLoopQuery("C92F6C5D-F7CB-4E81-835C-3D655C7FCC52","BudgetDetails",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""BudgetDetails"",ref ISpace);

foreach(var gridChild in ISpace[""BudgetDetails""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
}
base.WriteDebugInfo(@"#BudgetDetails[Rows]");
iSpace.GetLoopExpressionData("BudgetDetails",ref ISpace);

foreach(var gridChild in ISpace["BudgetDetails"].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 


if(
ISpace["RecurringValidation"].Value==519)
{
base.WriteDebugInfo(@"
if(
ISpace[""RecurringValidation""].Value==519)");
ISpace["NonRecurringAmount"].Value=ISpace["NonRecurringAmount"].Value+ISpace["BudgetAmount"].Value;
base.WriteDebugInfo(@"ISpace[""NonRecurringAmount""].Value=ISpace[""NonRecurringAmount""].Value+ISpace[""BudgetAmount""].Value;");
}

if(
ISpace["RecurringValidation"].Value==518)
{
base.WriteDebugInfo(@"
if(
ISpace[""RecurringValidation""].Value==518)");
ISpace["RecurringAmount"].Value=ISpace["RecurringAmount"].Value+ISpace["BudgetAmount"].Value;
base.WriteDebugInfo(@"ISpace[""RecurringAmount""].Value=ISpace[""RecurringAmount""].Value+ISpace[""BudgetAmount""].Value;");
}
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("BudgetDetails","C92F6C5D-F7CB-4E81-835C-3D655C7FCC52",_objectFactory.GetGridRPP("BudgetDetails"),_elementBase.GetGridLoopQuery("C92F6C5D-F7CB-4E81-835C-3D655C7FCC52","BudgetDetails",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""BudgetDetails"",ref ISpace);

foreach(var gridChild in ISpace[""BudgetDetails""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_budgetsubmit (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"BudgetSubmit-OnClick");
base.WriteDebugInfo(@"EXEC CheckDuplicateBudgetName '#BudgetName',1,'','','','','',''");

var querySourceB6ABAF2949FA4F278BADDC38EABC23C3 =GetQueryExpressionDataSource("B6ABAF29-49FA-4F27-8BAD-DC38EABC23C3");
Dictionary<short,object> resultB6ABAF2949FA4F278BADDC38EABC23C3=iSpace.ExecuteQuery(querySourceB6ABAF2949FA4F278BADDC38EABC23C3,@"EXEC CheckDuplicateBudgetName '" + ISpace["BudgetName"].Value + @"',1,'','','','','',''",false);

base.WriteDebugInfo(@"var querySourceB6ABAF2949FA4F278BADDC38EABC23C3 =GetQueryExpressionDataSource(""B6ABAF29-49FA-4F27-8BAD-DC38EABC23C3"");Dictionary<short,object> resultB6ABAF2949FA4F278BADDC38EABC23C3=iSpace.ExecuteQuery(querySourceB6ABAF2949FA4F278BADDC38EABC23C3,@""EXEC CheckDuplicateBudgetName '"" + ISpace[""BudgetName""].Value + @""',1,'','','','','',''"",false);");
base.WriteDebugInfo(@"");

if((resultB6ABAF2949FA4F278BADDC38EABC23C3!=null) && (resultB6ABAF2949FA4F278BADDC38EABC23C3.Count!=0))
{
if(resultB6ABAF2949FA4F278BADDC38EABC23C3.ContainsKey(0))
ISpace["BudgetDuplicate1"].Value = resultB6ABAF2949FA4F278BADDC38EABC23C3[0];
}
else{
ISpace["BudgetDuplicate1"].Value = null;
}
if(ISpace["BudgetDuplicate1"].Value=="1")
{
base.WriteDebugInfo(@"if(ISpace[""BudgetDuplicate1""].Value==""1"")");
ISpace["Message"].Value=@"Budget name Already exists";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Budget name Already exists"";");
return;
base.WriteDebugInfo(@"return;");
}
base.WriteDebugInfo(@"Entering DomainDataMap for Add Budget Details");
var AddBudgetDetails_repoObj = new RepositoryMapper(DbTypes.SQLServer);


var BudgetHeadAddBudgetDetailstableObj = new RepositoryTable("BudgetHead");
  BudgetHeadAddBudgetDetailstableObj.AppConnectionSettingsId  ="40BDEB14-07CC-4150-8A52-9B088A428E2D";BudgetHeadAddBudgetDetailstableObj.ProofConnectionId = "C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0)";
var AddBudgetDetails_BudgetHead_rows = GetElementClientData(ISpace["InstanceId"].Value,"A83D8B17-78DB-4B11-86C7-91E3F9A7C20E");

if(AddBudgetDetails_BudgetHead_rows!=null && AddBudgetDetails_BudgetHead_rows.Count>0){
var AddBudgetDetails_BudgetHead_rowsObj = new List<RepositoryRow>();
foreach(var rows in AddBudgetDetails_BudgetHead_rows){RepositoryRow repositoryRowObj = null;string elementData = null;RepositoryColumn repositoryColumnObj = null;if(rows !=null){ var BudgetHead_colObj = new List<RepositoryColumn>();repositoryRowObj= new RepositoryRow();//var myByte = (byte)rowData.Value.RwSt;//repositoryRowObj.RowState=(RepositoryRowState)myByte;

if(rows.ContainsKey("A7EA4A91-BC59-4434-ABA2-E73AF739B95B"))     elementData = rows["A7EA4A91-BC59-4434-ABA2-E73AF739B95B"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"BudgetDescription",false,false,9);
if(repositoryColumnObj!=null)BudgetHead_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-BudgetDescription not found");}

elementData = CurrentDate().ToString() ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"UpdatedOn",false,false,8);
if(repositoryColumnObj!=null)BudgetHead_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-CurrentDate not found");}

elementData = ISpace["gv_UserId"].Value != null? Convert.ToString(ISpace["gv_UserId"].Value):null ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"UpdatedBy",false,false,6);
if(repositoryColumnObj!=null)BudgetHead_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-gv_UserId not found");}

if(rows.ContainsKey("E4D6C799-B756-4742-AA83-0AE367EE63F4"))     elementData = rows["E4D6C799-B756-4742-AA83-0AE367EE63F4"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"BudgetName",false,false,9);
if(repositoryColumnObj!=null)BudgetHead_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-BudgetName not found");}

if(rows.ContainsKey("FD176984-9EF4-4738-9B84-E135FEA56914"))     elementData = rows["FD176984-9EF4-4738-9B84-E135FEA56914"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"BudgetID",true,true,5);
if(repositoryColumnObj!=null)BudgetHead_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-BudgetID not found");}
repositoryRowObj.Columns=BudgetHead_colObj;
AddBudgetDetails_BudgetHead_rowsObj.Add(repositoryRowObj);
}}

BudgetHeadAddBudgetDetailstableObj.Rows=AddBudgetDetails_BudgetHead_rowsObj;
var AddBudgetDetails_repoObj_status_BudgetHead = AddBudgetDetails_repoObj.Execute(DomainOperationTypes.CreateOrUpdate,ref BudgetHeadAddBudgetDetailstableObj);if(!AddBudgetDetails_repoObj_status_BudgetHead) throw new Exception("Error in Execute Domain Data Map");}
base.WriteDebugInfo(@"Exiting DomainDataMap for Add Budget Details");
ISpace["BudgetHead"].rElemData=iSpace.Reload(ISpace["BudgetHead"].Value,@"EXEC GetProjectDetailCombo 6","3A103712-5244-4427-B2B6-1C4E046FD337");
base.WriteDebugInfo(@"ISpace[""BudgetHead""].rElemData=iSpace.Reload(ISpace[""BudgetHead""].Value,@""EXEC GetProjectDetailCombo 6"",""3A103712-5244-4427-B2B6-1C4E046FD337"");");
ISpace["UI_CD3"].HideDialog=true;;
base.WriteDebugInfo(@"ISpace[""UI_CD3""].HideDialog=true;;");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_intexpense (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"IntExpense-OnChange");
ISpace["ProjectBudget"].Value=ISpace["IntExpense"].Value*ISpace["IntAmount"].Value;
base.WriteDebugInfo(@"ISpace[""ProjectBudget""].Value=ISpace[""IntExpense""].Value*ISpace[""IntAmount""].Value;");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_year20 (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Year20-OnChange");
ISpace["BudgetAmount"].Value= ISpace["Year11"].Value+ISpace["Year12"].Value+ISpace["Year13"].Value+ISpace["Year14"].Value+ISpace["Year15"].Value+ISpace["Year16"].Value+ISpace["Year17"].Value+ISpace["Year18"].Value+ISpace["Year19"].Value+ISpace["Year20"].Value+ISpace["Year21"].Value+ISpace["Year22"].Value;
base.WriteDebugInfo(@"ISpace[""BudgetAmount""].Value= ISpace[""Year11""].Value+ISpace[""Year12""].Value+ISpace[""Year13""].Value+ISpace[""Year14""].Value+ISpace[""Year15""].Value+ISpace[""Year16""].Value+ISpace[""Year17""].Value+ISpace[""Year18""].Value+ISpace[""Year19""].Value+ISpace[""Year20""].Value+ISpace[""Year21""].Value+ISpace[""Year22""].Value;");
ISpace["RecurringAmount"].Value=0;
base.WriteDebugInfo(@"ISpace[""RecurringAmount""].Value=0;");
ISpace["NonRecurringAmount"].Value=0;
base.WriteDebugInfo(@"ISpace[""NonRecurringAmount""].Value=0;");
object BudgetAmount=iSpace.Sum("[C92F6C5D-F7CB-4E81-835C-3D655C7FCC52]","BudgetAmount","",ISpace["gv_instanceid"].Value);
ISpace["OverallBudgetTotal"].Value=Convert.ChangeType(BudgetAmount, BudgetAmount.GetType());;
base.WriteDebugInfo(@"object BudgetAmount=iSpace.Sum(""[C92F6C5D-F7CB-4E81-835C-3D655C7FCC52]"",""BudgetAmount"","""",ISpace[""gv_instanceid""].Value);
ISpace[""OverallBudgetTotal""].Value=Convert.ChangeType(BudgetAmount, BudgetAmount.GetType());;");
if(1==2)
{
base.WriteDebugInfo(@"if(1==2)");
base.WriteDebugInfo(@"#BudgetDetails[Rows]");
iSpace.GetLoopExpressionData("BudgetDetails",ref ISpace);

foreach(var gridChild in ISpace["BudgetDetails"].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 


if(
ISpace["RecurringValidation"].Value==518)
{
base.WriteDebugInfo(@"
if(
ISpace[""RecurringValidation""].Value==518)");
object BudgetAmount=iSpace.Sum("[C92F6C5D-F7CB-4E81-835C-3D655C7FCC52]","BudgetAmount","",ISpace["gv_instanceid"].Value);
ISpace["RecurringAmount"].Value=Convert.ChangeType(BudgetAmount, BudgetAmount.GetType());;
base.WriteDebugInfo(@"object BudgetAmount=iSpace.Sum(""[C92F6C5D-F7CB-4E81-835C-3D655C7FCC52]"",""BudgetAmount"","""",ISpace[""gv_instanceid""].Value);
ISpace[""RecurringAmount""].Value=Convert.ChangeType(BudgetAmount, BudgetAmount.GetType());;");
}
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("BudgetDetails","C92F6C5D-F7CB-4E81-835C-3D655C7FCC52",_objectFactory.GetGridRPP("BudgetDetails"),_elementBase.GetGridLoopQuery("C92F6C5D-F7CB-4E81-835C-3D655C7FCC52","BudgetDetails",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""BudgetDetails"",ref ISpace);

foreach(var gridChild in ISpace[""BudgetDetails""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
}
base.WriteDebugInfo(@"#BudgetDetails[Rows]");
iSpace.GetLoopExpressionData("BudgetDetails",ref ISpace);

foreach(var gridChild in ISpace["BudgetDetails"].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 


if(
ISpace["RecurringValidation"].Value==519)
{
base.WriteDebugInfo(@"
if(
ISpace[""RecurringValidation""].Value==519)");
ISpace["NonRecurringAmount"].Value=ISpace["NonRecurringAmount"].Value+ISpace["BudgetAmount"].Value;
base.WriteDebugInfo(@"ISpace[""NonRecurringAmount""].Value=ISpace[""NonRecurringAmount""].Value+ISpace[""BudgetAmount""].Value;");
}

if(
ISpace["RecurringValidation"].Value==518)
{
base.WriteDebugInfo(@"
if(
ISpace[""RecurringValidation""].Value==518)");
ISpace["RecurringAmount"].Value=ISpace["RecurringAmount"].Value+ISpace["BudgetAmount"].Value;
base.WriteDebugInfo(@"ISpace[""RecurringAmount""].Value=ISpace[""RecurringAmount""].Value+ISpace[""BudgetAmount""].Value;");
}
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("BudgetDetails","C92F6C5D-F7CB-4E81-835C-3D655C7FCC52",_objectFactory.GetGridRPP("BudgetDetails"),_elementBase.GetGridLoopQuery("C92F6C5D-F7CB-4E81-835C-3D655C7FCC52","BudgetDetails",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""BudgetDetails"",ref ISpace);

foreach(var gridChild in ISpace[""BudgetDetails""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_fsubmit (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"FSubmit-OnClick");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC CheckDuplicateBudgetName '',2,'#FName','#FCode','','','',''");

var querySourceF580305D8B4F4B279DAC649134053E19 =GetQueryExpressionDataSource("F580305D-8B4F-4B27-9DAC-649134053E19");
Dictionary<short,object> resultF580305D8B4F4B279DAC649134053E19=iSpace.ExecuteQuery(querySourceF580305D8B4F4B279DAC649134053E19,@"EXEC CheckDuplicateBudgetName '',2,'" + ISpace["FName"].Value + @"','" + ISpace["FCode"].Value + @"','','','',''",false);

base.WriteDebugInfo(@"var querySourceF580305D8B4F4B279DAC649134053E19 =GetQueryExpressionDataSource(""F580305D-8B4F-4B27-9DAC-649134053E19"");Dictionary<short,object> resultF580305D8B4F4B279DAC649134053E19=iSpace.ExecuteQuery(querySourceF580305D8B4F4B279DAC649134053E19,@""EXEC CheckDuplicateBudgetName '',2,'"" + ISpace[""FName""].Value + @""','"" + ISpace[""FCode""].Value + @""','','','',''"",false);");
base.WriteDebugInfo(@"");

if((resultF580305D8B4F4B279DAC649134053E19!=null) && (resultF580305D8B4F4B279DAC649134053E19.Count!=0))
{
if(resultF580305D8B4F4B279DAC649134053E19.ContainsKey(0))
ISpace["AgencyDuplicate"].Value = resultF580305D8B4F4B279DAC649134053E19[0];
}
else{
ISpace["AgencyDuplicate"].Value = null;
}
}
if(ISpace["AgencyDuplicate"].Value=="1")
{
base.WriteDebugInfo(@"if(ISpace[""AgencyDuplicate""].Value==""1"")");
ISpace["Message"].Value=@"Funding Agency Already Exists";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Funding Agency Already Exists"";");
return;
base.WriteDebugInfo(@"return;");
}
ISpace["UI_CD2"].HideDialog=true;;
base.WriteDebugInfo(@"ISpace[""UI_CD2""].HideDialog=true;;");
if(ISpace["AgencyDuplicate"].Value=="0")
{
base.WriteDebugInfo(@"if(ISpace[""AgencyDuplicate""].Value==""0"")");
ISpace["FundingAcencyName"].rElemData=iSpace.Reload(ISpace["FundingAcencyName"].Value,@"EXEC GetDateDifferenceInYears 7,'','',''","40BDEB14-07CC-4150-8A52-9B088A428E2D");
base.WriteDebugInfo(@"ISpace[""FundingAcencyName""].rElemData=iSpace.Reload(ISpace[""FundingAcencyName""].Value,@""EXEC GetDateDifferenceInYears 7,'','',''"",""40BDEB14-07CC-4150-8A52-9B088A428E2D"");");
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_dclose (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"DClose-OnClick");
ISpace["UI_CD1"].HideDialog=true;;
base.WriteDebugInfo(@"ISpace[""UI_CD1""].HideDialog=true;;");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_dsubmit (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"DSubmit-OnClick");
ISpace["DName"].Value=Trim(ISpace["DName"].Value);
base.WriteDebugInfo(@"ISpace[""DName""].Value=Trim(ISpace[""DName""].Value);");
if(ISpace["DName"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""DName""].Value=="""")");
ISpace["Message"].Value=@"please enter scheme name.";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""please enter scheme name."";");
return;
base.WriteDebugInfo(@"return;");
}
if(ISpace["DCode"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""DCode""].Value=="""")");
ISpace["Message"].Value=@"please enter the scheme code.";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""please enter the scheme code."";");
return;
base.WriteDebugInfo(@"return;");
}
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"EXEC CheckDuplicateBudgetName '',4,'','','','','#DName','#DCode'");

var querySource30F76DA7F4A34FC4842DF0B7584B8DD2 =GetQueryExpressionDataSource("30F76DA7-F4A3-4FC4-842D-F0B7584B8DD2");
Dictionary<short,object> result30F76DA7F4A34FC4842DF0B7584B8DD2=iSpace.ExecuteQuery(querySource30F76DA7F4A34FC4842DF0B7584B8DD2,@"EXEC CheckDuplicateBudgetName '',4,'','','','','" + ISpace["DName"].Value + @"','" + ISpace["DCode"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource30F76DA7F4A34FC4842DF0B7584B8DD2 =GetQueryExpressionDataSource(""30F76DA7-F4A3-4FC4-842D-F0B7584B8DD2"");Dictionary<short,object> result30F76DA7F4A34FC4842DF0B7584B8DD2=iSpace.ExecuteQuery(querySource30F76DA7F4A34FC4842DF0B7584B8DD2,@""EXEC CheckDuplicateBudgetName '',4,'','','','','"" + ISpace[""DName""].Value + @""','"" + ISpace[""DCode""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result30F76DA7F4A34FC4842DF0B7584B8DD2!=null) && (result30F76DA7F4A34FC4842DF0B7584B8DD2.Count!=0))
{
if(result30F76DA7F4A34FC4842DF0B7584B8DD2.ContainsKey(0))
ISpace["SchemeDuplicate"].Value = result30F76DA7F4A34FC4842DF0B7584B8DD2[0];
}
else{
ISpace["SchemeDuplicate"].Value = null;
}
}
if(ISpace["SchemeDuplicate"].Value=="1")
{
base.WriteDebugInfo(@"if(ISpace[""SchemeDuplicate""].Value==""1"")");
ISpace["Message"].Value=@"Scheme name Already exists";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Scheme name Already exists"";");
return;
base.WriteDebugInfo(@"return;");
}
base.WriteDebugInfo(@"Entering DomainDataMap for Scheme Type");
var SchemeType_repoObj = new RepositoryMapper(DbTypes.SQLServer);


var BudgetSchemeDetailsSchemeTypetableObj = new RepositoryTable("BudgetSchemeDetails");
  BudgetSchemeDetailsSchemeTypetableObj.AppConnectionSettingsId  ="CA34B07F-5D19-412F-A39F-3ADA64B5E0C0";BudgetSchemeDetailsSchemeTypetableObj.ProofConnectionId = "C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0)";
var SchemeType_BudgetSchemeDetails_rows = GetElementClientData(ISpace["InstanceId"].Value,"A83D8B17-78DB-4B11-86C7-91E3F9A7C20E");

if(SchemeType_BudgetSchemeDetails_rows!=null && SchemeType_BudgetSchemeDetails_rows.Count>0){
var SchemeType_BudgetSchemeDetails_rowsObj = new List<RepositoryRow>();
foreach(var rows in SchemeType_BudgetSchemeDetails_rows){RepositoryRow repositoryRowObj = null;string elementData = null;RepositoryColumn repositoryColumnObj = null;if(rows !=null){ var BudgetSchemeDetails_colObj = new List<RepositoryColumn>();repositoryRowObj= new RepositoryRow();//var myByte = (byte)rowData.Value.RwSt;//repositoryRowObj.RowState=(RepositoryRowState)myByte;

elementData = CurrentDate().ToString() ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"UpdatedOn",false,false,8);
if(repositoryColumnObj!=null)BudgetSchemeDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-CurrentDate not found");}

if(rows.ContainsKey("3E424731-37A0-41D9-A6CD-8CD4A2641109"))     elementData = rows["3E424731-37A0-41D9-A6CD-8CD4A2641109"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"SchemeCode",false,false,9);
if(repositoryColumnObj!=null)BudgetSchemeDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-DCode not found");}

if(rows.ContainsKey("76214D1F-1965-4658-98E7-25FBBE4DF30A"))     elementData = rows["76214D1F-1965-4658-98E7-25FBBE4DF30A"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"SchemeName",false,false,9);
if(repositoryColumnObj!=null)BudgetSchemeDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-DName not found");}

elementData = ISpace["gv_UserId"].Value != null? Convert.ToString(ISpace["gv_UserId"].Value):null ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"UpdatedBy",false,false,6);
if(repositoryColumnObj!=null)BudgetSchemeDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-gv_UserId not found");}

if(rows.ContainsKey("6951EA17-C55F-40F4-BC4C-AE4CAC671680"))     elementData = rows["6951EA17-C55F-40F4-BC4C-AE4CAC671680"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"SchemeID",true,true,5);
if(repositoryColumnObj!=null)BudgetSchemeDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Aid not found");}
repositoryRowObj.Columns=BudgetSchemeDetails_colObj;
SchemeType_BudgetSchemeDetails_rowsObj.Add(repositoryRowObj);
}}

BudgetSchemeDetailsSchemeTypetableObj.Rows=SchemeType_BudgetSchemeDetails_rowsObj;
var SchemeType_repoObj_status_BudgetSchemeDetails = SchemeType_repoObj.Execute(DomainOperationTypes.CreateOrUpdate,ref BudgetSchemeDetailsSchemeTypetableObj);if(!SchemeType_repoObj_status_BudgetSchemeDetails) throw new Exception("Error in Execute Domain Data Map");}
base.WriteDebugInfo(@"Exiting DomainDataMap for Scheme Type");
ISpace["SchemeType"].rElemData=iSpace.Reload(ISpace["SchemeType"].Value,@"EXEC GetProjectDetailCombo 5,'" + ISpace["FundingAcencyName"].Value + @"'","40BDEB14-07CC-4150-8A52-9B088A428E2D");
base.WriteDebugInfo(@"ISpace[""SchemeType""].rElemData=iSpace.Reload(ISpace[""SchemeType""].Value,@""EXEC GetProjectDetailCombo 5,'"" + ISpace[""FundingAcencyName""].Value + @""'"",""40BDEB14-07CC-4150-8A52-9B088A428E2D"");");
ISpace["UI_CD1"].HideDialog=true;;
base.WriteDebugInfo(@"ISpace[""UI_CD1""].HideDialog=true;;");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_bsave (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"BSave-OnClick");
ISpace["Message"].Value=@"Saved Successfully";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Saved Successfully"";");
ISpace.ExecuteInstanceCommand("Save");
base.WriteDebugInfo(@"ISpace.ExecuteInstanceCommand(""Save"");");
base.WriteDebugInfo(@"exec UpdateProposalIsSubmit '#ProjectProposal'");

var querySource7AD869272FFA4555BA40DAA289C8646D =GetQueryExpressionDataSource("7AD86927-2FFA-4555-BA40-DAA289C8646D");
Dictionary<short,object> result7AD869272FFA4555BA40DAA289C8646D=iSpace.ExecuteQuery(querySource7AD869272FFA4555BA40DAA289C8646D,@"execUpdateProposalIsSubmit '" + ISpace["ProjectProposal"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource7AD869272FFA4555BA40DAA289C8646D =GetQueryExpressionDataSource(""7AD86927-2FFA-4555-BA40-DAA289C8646D"");Dictionary<short,object> result7AD869272FFA4555BA40DAA289C8646D=iSpace.ExecuteQuery(querySource7AD869272FFA4555BA40DAA289C8646D,@""execUpdateProposalIsSubmit '"" + ISpace[""ProjectProposal""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result7AD869272FFA4555BA40DAA289C8646D!=null) && (result7AD869272FFA4555BA40DAA289C8646D.Count!=0))
{
if(result7AD869272FFA4555BA40DAA289C8646D.ContainsKey(0))
ISpace["Subject"].Value = result7AD869272FFA4555BA40DAA289C8646D[0];
}
else{
ISpace["Subject"].Value = null;
}

ISpace["RedirectUrl"].RedirectType="R";
ISpace["RedirectUrl"].Value="?PkActMId=80BA7272-EBDB-40E4-8780-BBCFE9F7BF42&frmElementId=EC0A9909-7B20-47F6-BC2E-A127EFE2DF19&PkPrMId=2FC376A8-EF63-4E6A-BADA-9EC15ECC14A1&formVersionId=BF48F261-7346-4E90-B167-CAF0E476DD36&Ver=0.0000";
base.WriteDebugInfo(@"
ISpace[""RedirectUrl""].RedirectType=""R"";
ISpace[""RedirectUrl""].Value=""?PkActMId=80BA7272-EBDB-40E4-8780-BBCFE9F7BF42&frmElementId=EC0A9909-7B20-47F6-BC2E-A127EFE2DF19&PkPrMId=2FC376A8-EF63-4E6A-BADA-9EC15ECC14A1&formVersionId=BF48F261-7346-4E90-B167-CAF0E476DD36&Ver=0.0000"";");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_year22 (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Year22-OnChange");
ISpace["BudgetAmount"].Value= ISpace["Year11"].Value+ISpace["Year12"].Value+ISpace["Year13"].Value+ISpace["Year14"].Value+ISpace["Year15"].Value+ISpace["Year16"].Value+ISpace["Year17"].Value+ISpace["Year18"].Value+ISpace["Year19"].Value+ISpace["Year20"].Value+ISpace["Year21"].Value+ISpace["Year22"].Value;
base.WriteDebugInfo(@"ISpace[""BudgetAmount""].Value= ISpace[""Year11""].Value+ISpace[""Year12""].Value+ISpace[""Year13""].Value+ISpace[""Year14""].Value+ISpace[""Year15""].Value+ISpace[""Year16""].Value+ISpace[""Year17""].Value+ISpace[""Year18""].Value+ISpace[""Year19""].Value+ISpace[""Year20""].Value+ISpace[""Year21""].Value+ISpace[""Year22""].Value;");
ISpace["RecurringAmount"].Value=0;
base.WriteDebugInfo(@"ISpace[""RecurringAmount""].Value=0;");
ISpace["NonRecurringAmount"].Value=0;
base.WriteDebugInfo(@"ISpace[""NonRecurringAmount""].Value=0;");
object BudgetAmount=iSpace.Sum("[C92F6C5D-F7CB-4E81-835C-3D655C7FCC52]","BudgetAmount","",ISpace["gv_instanceid"].Value);
ISpace["OverallBudgetTotal"].Value=Convert.ChangeType(BudgetAmount, BudgetAmount.GetType());;
base.WriteDebugInfo(@"object BudgetAmount=iSpace.Sum(""[C92F6C5D-F7CB-4E81-835C-3D655C7FCC52]"",""BudgetAmount"","""",ISpace[""gv_instanceid""].Value);
ISpace[""OverallBudgetTotal""].Value=Convert.ChangeType(BudgetAmount, BudgetAmount.GetType());;");
if(1==2)
{
base.WriteDebugInfo(@"if(1==2)");
base.WriteDebugInfo(@"#BudgetDetails[Rows]");
iSpace.GetLoopExpressionData("BudgetDetails",ref ISpace);

foreach(var gridChild in ISpace["BudgetDetails"].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 


if(
ISpace["RecurringValidation"].Value==518)
{
base.WriteDebugInfo(@"
if(
ISpace[""RecurringValidation""].Value==518)");
object BudgetAmount=iSpace.Sum("[C92F6C5D-F7CB-4E81-835C-3D655C7FCC52]","BudgetAmount","",ISpace["gv_instanceid"].Value);
ISpace["RecurringAmount"].Value=Convert.ChangeType(BudgetAmount, BudgetAmount.GetType());;
base.WriteDebugInfo(@"object BudgetAmount=iSpace.Sum(""[C92F6C5D-F7CB-4E81-835C-3D655C7FCC52]"",""BudgetAmount"","""",ISpace[""gv_instanceid""].Value);
ISpace[""RecurringAmount""].Value=Convert.ChangeType(BudgetAmount, BudgetAmount.GetType());;");
}
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("BudgetDetails","C92F6C5D-F7CB-4E81-835C-3D655C7FCC52",_objectFactory.GetGridRPP("BudgetDetails"),_elementBase.GetGridLoopQuery("C92F6C5D-F7CB-4E81-835C-3D655C7FCC52","BudgetDetails",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""BudgetDetails"",ref ISpace);

foreach(var gridChild in ISpace[""BudgetDetails""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
}
base.WriteDebugInfo(@"#BudgetDetails[Rows]");
iSpace.GetLoopExpressionData("BudgetDetails",ref ISpace);

foreach(var gridChild in ISpace["BudgetDetails"].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 


if(
ISpace["RecurringValidation"].Value==519)
{
base.WriteDebugInfo(@"
if(
ISpace[""RecurringValidation""].Value==519)");
ISpace["NonRecurringAmount"].Value=ISpace["NonRecurringAmount"].Value+ISpace["BudgetAmount"].Value;
base.WriteDebugInfo(@"ISpace[""NonRecurringAmount""].Value=ISpace[""NonRecurringAmount""].Value+ISpace[""BudgetAmount""].Value;");
}

if(
ISpace["RecurringValidation"].Value==518)
{
base.WriteDebugInfo(@"
if(
ISpace[""RecurringValidation""].Value==518)");
ISpace["RecurringAmount"].Value=ISpace["RecurringAmount"].Value+ISpace["BudgetAmount"].Value;
base.WriteDebugInfo(@"ISpace[""RecurringAmount""].Value=ISpace[""RecurringAmount""].Value+ISpace[""BudgetAmount""].Value;");
}
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("BudgetDetails","C92F6C5D-F7CB-4E81-835C-3D655C7FCC52",_objectFactory.GetGridRPP("BudgetDetails"),_elementBase.GetGridLoopQuery("C92F6C5D-F7CB-4E81-835C-3D655C7FCC52","BudgetDetails",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""BudgetDetails"",ref ISpace);

foreach(var gridChild in ISpace[""BudgetDetails""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_ui_documents (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"UI_Documents-OnClick");
if(ISpace["ActiveEdit"].Value==0)
{
base.WriteDebugInfo(@"if(ISpace[""ActiveEdit""].Value==0)");
base.WriteDebugInfo(@"Entering DomainDataMap for Budget Details Grid Domain");
var BudgetDetailsGridDomain_repoObj = new RepositoryMapper(DbTypes.SQLServer);


var ProjectBudgetDetailsBudgetDetailsGridDomaintableObj = new RepositoryTable("ProjectBudgetDetails");
  ProjectBudgetDetailsBudgetDetailsGridDomaintableObj.AppConnectionSettingsId  ="40BDEB14-07CC-4150-8A52-9B088A428E2D";ProjectBudgetDetailsBudgetDetailsGridDomaintableObj.ProofConnectionId = "C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0)";
var BudgetDetailsGridDomain_ProjectBudgetDetails_rows = GetElementClientData(ISpace["InstanceId"].Value,"C92F6C5D-F7CB-4E81-835C-3D655C7FCC52");

if(BudgetDetailsGridDomain_ProjectBudgetDetails_rows!=null && BudgetDetailsGridDomain_ProjectBudgetDetails_rows.Count>0){
var BudgetDetailsGridDomain_ProjectBudgetDetails_rowsObj = new List<RepositoryRow>();
foreach(var rows in BudgetDetailsGridDomain_ProjectBudgetDetails_rows){RepositoryRow repositoryRowObj = null;string elementData = null;RepositoryColumn repositoryColumnObj = null;if(rows !=null){ var ProjectBudgetDetails_colObj = new List<RepositoryColumn>();repositoryRowObj= new RepositoryRow();//var myByte = (byte)rowData.Value.RwSt;//repositoryRowObj.RowState=(RepositoryRowState)myByte;

if(rows.ContainsKey("A38311B1-68C6-462E-9DB6-FD90ABFF6E44"))     elementData = rows["A38311B1-68C6-462E-9DB6-FD90ABFF6E44"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"BudgetAmount",false,false,3);
if(repositoryColumnObj!=null)ProjectBudgetDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-BudgetAmount not found");}

if(rows.ContainsKey("F7FB513A-721E-4E82-89DD-F03DF3E8AB16"))     elementData = rows["F7FB513A-721E-4E82-89DD-F03DF3E8AB16"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"BudgetID",false,false,5);
if(repositoryColumnObj!=null)ProjectBudgetDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Bid not found");}

if(rows.ContainsKey("FD08EF20-802B-4672-8747-6D54C2D6D31E"))     elementData = rows["FD08EF20-802B-4672-8747-6D54C2D6D31E"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Year2",false,false,5);
if(repositoryColumnObj!=null)ProjectBudgetDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Year12 not found");}

if(rows.ContainsKey("49074D93-7C7F-401F-AD44-0BB2B5353FE3"))     elementData = rows["49074D93-7C7F-401F-AD44-0BB2B5353FE3"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ProjectDetailsID",false,false,9);
if(repositoryColumnObj!=null)ProjectBudgetDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-ID1 not found");}

elementData = CurrentDate().ToString() ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"UpdatedOn",false,false,8);
if(repositoryColumnObj!=null)ProjectBudgetDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-CurrentDate not found");}

if(rows.ContainsKey("67FD82A6-A670-4DD2-8574-AAD959805F77"))     elementData = rows["67FD82A6-A670-4DD2-8574-AAD959805F77"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Year7",false,false,5);
if(repositoryColumnObj!=null)ProjectBudgetDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Year17 not found");}

if(rows.ContainsKey("B5948E98-0ABA-493A-A2DB-DF169BE81734"))     elementData = rows["B5948E98-0ABA-493A-A2DB-DF169BE81734"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Year9",false,false,5);
if(repositoryColumnObj!=null)ProjectBudgetDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Year19 not found");}

if(rows.ContainsKey("153737E5-6626-4A69-8501-4AAD946A634A"))     elementData = rows["153737E5-6626-4A69-8501-4AAD946A634A"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"OverallAmount",false,false,3);
if(repositoryColumnObj!=null)ProjectBudgetDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-OverallBudgetTotal not found");}

if(rows.ContainsKey("6B169537-9858-4E64-9587-5454EDE7F799"))     elementData = rows["6B169537-9858-4E64-9587-5454EDE7F799"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Year4",false,false,5);
if(repositoryColumnObj!=null)ProjectBudgetDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Year14 not found");}

if(rows.ContainsKey("DDAC7A4B-1F58-4403-A731-A41BFE920BBB"))     elementData = rows["DDAC7A4B-1F58-4403-A731-A41BFE920BBB"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Year1",false,false,5);
if(repositoryColumnObj!=null)ProjectBudgetDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Year11 not found");}

elementData = ISpace["gv_UserId"].Value != null? Convert.ToString(ISpace["gv_UserId"].Value):null ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"UpdatedBy",false,false,6);
if(repositoryColumnObj!=null)ProjectBudgetDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-gv_UserId not found");}

if(rows.ContainsKey("B6B3B0F1-D9E6-442C-AD71-494FF4470030"))     elementData = rows["B6B3B0F1-D9E6-442C-AD71-494FF4470030"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Year3",false,false,5);
if(repositoryColumnObj!=null)ProjectBudgetDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Year13 not found");}

if(rows.ContainsKey("6EC8DDAB-B1F1-4D8C-9598-77E3827539D5"))     elementData = rows["6EC8DDAB-B1F1-4D8C-9598-77E3827539D5"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Year6",false,false,5);
if(repositoryColumnObj!=null)ProjectBudgetDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Year16 not found");}

if(rows.ContainsKey("E0DCC460-53C1-4953-90C3-C97266369DD1"))     elementData = rows["E0DCC460-53C1-4953-90C3-C97266369DD1"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Year11",false,false,5);
if(repositoryColumnObj!=null)ProjectBudgetDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Year21 not found");}

if(rows.ContainsKey("303EE107-01E7-49DF-94E6-F6461AC4CB48"))     elementData = rows["303EE107-01E7-49DF-94E6-F6461AC4CB48"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"BudgetDetailID",true,false,9);
if(repositoryColumnObj!=null)ProjectBudgetDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-ProjectBudgetDetailsid not found");}

if(rows.ContainsKey("7A91BE20-EB4E-4223-9FE5-5BE3A531F3FC"))     elementData = rows["7A91BE20-EB4E-4223-9FE5-5BE3A531F3FC"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Year10",false,false,5);
if(repositoryColumnObj!=null)ProjectBudgetDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Year20 not found");}

if(rows.ContainsKey("F85850E3-22D8-43A9-A14F-2D5283720AB0"))     elementData = rows["F85850E3-22D8-43A9-A14F-2D5283720AB0"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Comments",false,false,9);
if(repositoryColumnObj!=null)ProjectBudgetDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-commentss not found");}

if(rows.ContainsKey("85E319F5-14C8-44FA-9C41-0E3303FDCE8F"))     elementData = rows["85E319F5-14C8-44FA-9C41-0E3303FDCE8F"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Year12",false,false,5);
if(repositoryColumnObj!=null)ProjectBudgetDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Year22 not found");}

if(rows.ContainsKey("2E19ABDB-10E6-4785-8244-7863EA4FBCBC"))     elementData = rows["2E19ABDB-10E6-4785-8244-7863EA4FBCBC"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Year5",false,false,5);
if(repositoryColumnObj!=null)ProjectBudgetDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Year15 not found");}

if(rows.ContainsKey("B134B486-06FC-487E-BEA2-AE6F137D586C"))     elementData = rows["B134B486-06FC-487E-BEA2-AE6F137D586C"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Year8",false,false,5);
if(repositoryColumnObj!=null)ProjectBudgetDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Year18 not found");}

if(rows.ContainsKey("19DEC91D-3072-486C-947C-F5C3A8756745"))     elementData = rows["19DEC91D-3072-486C-947C-F5C3A8756745"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"RDOfficeComments",false,false,9);
if(repositoryColumnObj!=null)ProjectBudgetDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-RDComments not found");}
repositoryRowObj.Columns=ProjectBudgetDetails_colObj;
BudgetDetailsGridDomain_ProjectBudgetDetails_rowsObj.Add(repositoryRowObj);
}}

ProjectBudgetDetailsBudgetDetailsGridDomaintableObj.Rows=BudgetDetailsGridDomain_ProjectBudgetDetails_rowsObj;
var BudgetDetailsGridDomain_repoObj_status_ProjectBudgetDetails = BudgetDetailsGridDomain_repoObj.Execute(DomainOperationTypes.CreateOrUpdate,ref ProjectBudgetDetailsBudgetDetailsGridDomaintableObj);if(!BudgetDetailsGridDomain_repoObj_status_ProjectBudgetDetails) throw new Exception("Error in Execute Domain Data Map");}
base.WriteDebugInfo(@"Exiting DomainDataMap for Budget Details Grid Domain");
}
if(ISpace["ActiveEdit"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""ActiveEdit""].Value==1)");
base.WriteDebugInfo(@"Entering DomainDataMap for TempBudgetDetails");
var TempBudgetDetails_repoObj = new RepositoryMapper(DbTypes.SQLServer);


var TempProjectbudgetdetailsTempBudgetDetailstableObj = new RepositoryTable("TempProjectbudgetdetails");
  TempProjectbudgetdetailsTempBudgetDetailstableObj.AppConnectionSettingsId  ="CA34B07F-5D19-412F-A39F-3ADA64B5E0C0";TempProjectbudgetdetailsTempBudgetDetailstableObj.ProofConnectionId = "C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0)";
var TempBudgetDetails_TempProjectbudgetdetails_rows = GetElementClientData(ISpace["InstanceId"].Value,"C92F6C5D-F7CB-4E81-835C-3D655C7FCC52");

if(TempBudgetDetails_TempProjectbudgetdetails_rows!=null && TempBudgetDetails_TempProjectbudgetdetails_rows.Count>0){
var TempBudgetDetails_TempProjectbudgetdetails_rowsObj = new List<RepositoryRow>();
foreach(var rows in TempBudgetDetails_TempProjectbudgetdetails_rows){RepositoryRow repositoryRowObj = null;string elementData = null;RepositoryColumn repositoryColumnObj = null;if(rows !=null){ var TempProjectbudgetdetails_colObj = new List<RepositoryColumn>();repositoryRowObj= new RepositoryRow();//var myByte = (byte)rowData.Value.RwSt;//repositoryRowObj.RowState=(RepositoryRowState)myByte;

if(rows.ContainsKey("B6B3B0F1-D9E6-442C-AD71-494FF4470030"))     elementData = rows["B6B3B0F1-D9E6-442C-AD71-494FF4470030"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Year3",false,false,5);
if(repositoryColumnObj!=null)TempProjectbudgetdetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Year13 not found");}

if(rows.ContainsKey("303EE107-01E7-49DF-94E6-F6461AC4CB48"))     elementData = rows["303EE107-01E7-49DF-94E6-F6461AC4CB48"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"BudgetDetailID",true,false,9);
if(repositoryColumnObj!=null)TempProjectbudgetdetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-ProjectBudgetDetailsid not found");}

if(rows.ContainsKey("FD08EF20-802B-4672-8747-6D54C2D6D31E"))     elementData = rows["FD08EF20-802B-4672-8747-6D54C2D6D31E"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Year2",false,false,5);
if(repositoryColumnObj!=null)TempProjectbudgetdetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Year12 not found");}

if(rows.ContainsKey("6EC8DDAB-B1F1-4D8C-9598-77E3827539D5"))     elementData = rows["6EC8DDAB-B1F1-4D8C-9598-77E3827539D5"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Year6",false,false,5);
if(repositoryColumnObj!=null)TempProjectbudgetdetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Year16 not found");}

if(rows.ContainsKey("F7FB513A-721E-4E82-89DD-F03DF3E8AB16"))     elementData = rows["F7FB513A-721E-4E82-89DD-F03DF3E8AB16"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"BudgetID",false,false,5);
if(repositoryColumnObj!=null)TempProjectbudgetdetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Bid not found");}

if(rows.ContainsKey("A38311B1-68C6-462E-9DB6-FD90ABFF6E44"))     elementData = rows["A38311B1-68C6-462E-9DB6-FD90ABFF6E44"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"BudgetAmount",false,false,3);
if(repositoryColumnObj!=null)TempProjectbudgetdetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-BudgetAmount not found");}

if(rows.ContainsKey("E0DCC460-53C1-4953-90C3-C97266369DD1"))     elementData = rows["E0DCC460-53C1-4953-90C3-C97266369DD1"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Year11",false,false,5);
if(repositoryColumnObj!=null)TempProjectbudgetdetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Year21 not found");}

if(rows.ContainsKey("6B169537-9858-4E64-9587-5454EDE7F799"))     elementData = rows["6B169537-9858-4E64-9587-5454EDE7F799"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Year4",false,false,5);
if(repositoryColumnObj!=null)TempProjectbudgetdetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Year14 not found");}

if(rows.ContainsKey("153737E5-6626-4A69-8501-4AAD946A634A"))     elementData = rows["153737E5-6626-4A69-8501-4AAD946A634A"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"OverallAmount",false,false,3);
if(repositoryColumnObj!=null)TempProjectbudgetdetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-OverallBudgetTotal not found");}

if(rows.ContainsKey("19DEC91D-3072-486C-947C-F5C3A8756745"))     elementData = rows["19DEC91D-3072-486C-947C-F5C3A8756745"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"RDOfficeComments",false,false,9);
if(repositoryColumnObj!=null)TempProjectbudgetdetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-RDComments not found");}

if(rows.ContainsKey("85E319F5-14C8-44FA-9C41-0E3303FDCE8F"))     elementData = rows["85E319F5-14C8-44FA-9C41-0E3303FDCE8F"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Year12",false,false,5);
if(repositoryColumnObj!=null)TempProjectbudgetdetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Year22 not found");}

if(rows.ContainsKey("67FD82A6-A670-4DD2-8574-AAD959805F77"))     elementData = rows["67FD82A6-A670-4DD2-8574-AAD959805F77"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Year7",false,false,5);
if(repositoryColumnObj!=null)TempProjectbudgetdetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Year17 not found");}

if(rows.ContainsKey("2E19ABDB-10E6-4785-8244-7863EA4FBCBC"))     elementData = rows["2E19ABDB-10E6-4785-8244-7863EA4FBCBC"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Year5",false,false,5);
if(repositoryColumnObj!=null)TempProjectbudgetdetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Year15 not found");}

elementData = ISpace["gv_UserId"].Value != null? Convert.ToString(ISpace["gv_UserId"].Value):null ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"UpdatedBy",false,false,6);
if(repositoryColumnObj!=null)TempProjectbudgetdetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-gv_UserId not found");}

if(rows.ContainsKey("2833427C-A5F6-43D0-9A15-E33760BA7E46"))     elementData = rows["2833427C-A5F6-43D0-9A15-E33760BA7E46"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"TempInstanceid",false,false,9);
if(repositoryColumnObj!=null)TempProjectbudgetdetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-TempInstanceID not found");}

if(rows.ContainsKey("DDAC7A4B-1F58-4403-A731-A41BFE920BBB"))     elementData = rows["DDAC7A4B-1F58-4403-A731-A41BFE920BBB"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Year1",false,false,3);
if(repositoryColumnObj!=null)TempProjectbudgetdetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Year11 not found");}

if(rows.ContainsKey("F85850E3-22D8-43A9-A14F-2D5283720AB0"))     elementData = rows["F85850E3-22D8-43A9-A14F-2D5283720AB0"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Comments",false,false,9);
if(repositoryColumnObj!=null)TempProjectbudgetdetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-commentss not found");}

if(rows.ContainsKey("B134B486-06FC-487E-BEA2-AE6F137D586C"))     elementData = rows["B134B486-06FC-487E-BEA2-AE6F137D586C"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Year8",false,false,5);
if(repositoryColumnObj!=null)TempProjectbudgetdetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Year18 not found");}

elementData = CurrentDate().ToString() ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"UpdatedOn",false,false,8);
if(repositoryColumnObj!=null)TempProjectbudgetdetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-CurrentDate not found");}

if(rows.ContainsKey("B5948E98-0ABA-493A-A2DB-DF169BE81734"))     elementData = rows["B5948E98-0ABA-493A-A2DB-DF169BE81734"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Year9",false,false,5);
if(repositoryColumnObj!=null)TempProjectbudgetdetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Year19 not found");}

if(rows.ContainsKey("49074D93-7C7F-401F-AD44-0BB2B5353FE3"))     elementData = rows["49074D93-7C7F-401F-AD44-0BB2B5353FE3"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ProjectDetailsID",false,false,9);
if(repositoryColumnObj!=null)TempProjectbudgetdetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-ID1 not found");}

if(rows.ContainsKey("7A91BE20-EB4E-4223-9FE5-5BE3A531F3FC"))     elementData = rows["7A91BE20-EB4E-4223-9FE5-5BE3A531F3FC"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Year10",false,false,5);
if(repositoryColumnObj!=null)TempProjectbudgetdetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Year20 not found");}
repositoryRowObj.Columns=TempProjectbudgetdetails_colObj;
TempBudgetDetails_TempProjectbudgetdetails_rowsObj.Add(repositoryRowObj);
}}

TempProjectbudgetdetailsTempBudgetDetailstableObj.Rows=TempBudgetDetails_TempProjectbudgetdetails_rowsObj;
var TempBudgetDetails_repoObj_status_TempProjectbudgetdetails = TempBudgetDetails_repoObj.Execute(DomainOperationTypes.CreateOrUpdate,ref TempProjectbudgetdetailsTempBudgetDetailstableObj);if(!TempBudgetDetails_repoObj_status_TempProjectbudgetdetails) throw new Exception("Error in Execute Domain Data Map");}
base.WriteDebugInfo(@"Exiting DomainDataMap for TempBudgetDetails");
}
if(ISpace["ActiveEdit"].Value==0)
{
base.WriteDebugInfo(@"if(ISpace[""ActiveEdit""].Value==0)");

var querySource69D87FBD9BEB47BEB916F267A651A953 =GetQueryExpressionDataSource("69D87FBD-9BEB-47BE-B916-F267A651A953");

DataTable result69D87FBD9BEB47BEB916F267A651A953=iSpace.SetGridDataSource(querySource69D87FBD9BEB47BEB916F267A651A953, _objectFactory.GetGridRPP("BudgetDetails"),@"EXEC [GetProjectDetailCombo] 1,'" + ISpace["ID1"].Value + @"'");

iSpace.InsertGridBindDetails("BudgetDetails","11",querySource69D87FBD9BEB47BEB916F267A651A953,"EXEC [GetProjectDetailCombo] 1,'" + ISpace["ID1"].Value + @"'",_objectFactory.GetGridRPP("BudgetDetails"));

base.WriteDebugInfo(@"var querySource69D87FBD9BEB47BEB916F267A651A953 =GetQueryExpressionDataSource(""69D87FBD-9BEB-47BE-B916-F267A651A953"");DataTable result69D87FBD9BEB47BEB916F267A651A953=iSpace.SetGridDataSource(querySource69D87FBD9BEB47BEB916F267A651A953, _objectFactory.GetGridRPP(""BudgetDetails""),@""EXEC [GetProjectDetailCombo] 1,'"" + ISpace[""ID1""].Value + @""'"");iSpace.InsertGridBindDetails(""BudgetDetails"",""11"",querySource69D87FBD9BEB47BEB916F267A651A953,""EXEC [GetProjectDetailCombo] 1,'"" + ISpace[""ID1""].Value + @""'"",_objectFactory.GetGridRPP(""BudgetDetails""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> resultCF752EE8E74240ED941907B9622045EE=acdataIspaceD0B6EBB910A44D43A76EF39441A41EF6.GetQueryExpressionBindings("CF752EE8-E742-40ED-9419-07B9622045EE");
iSpace.SetGridData(result69D87FBD9BEB47BEB916F267A651A953,resultCF752EE8E74240ED941907B9622045EE,"BudgetDetails",ref ISpace);
iSpace.UpdateGridBindDetails("BudgetDetails",resultCF752EE8E74240ED941907B9622045EE);
}
if(ISpace["ActiveEdit"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""ActiveEdit""].Value==1)");

var querySource50B1C2C117D643DDAABC875561B59218 =GetQueryExpressionDataSource("50B1C2C1-17D6-43DD-AABC-875561B59218");

DataTable result50B1C2C117D643DDAABC875561B59218=iSpace.SetGridDataSource(querySource50B1C2C117D643DDAABC875561B59218, _objectFactory.GetGridRPP("BudgetDetails"),@"EXEC [GetProjectDetailCombo] 15,'" + ISpace["ID1"].Value + @"'");

iSpace.InsertGridBindDetails("BudgetDetails","11",querySource50B1C2C117D643DDAABC875561B59218,"EXEC [GetProjectDetailCombo] 15,'" + ISpace["ID1"].Value + @"'",_objectFactory.GetGridRPP("BudgetDetails"));

base.WriteDebugInfo(@"var querySource50B1C2C117D643DDAABC875561B59218 =GetQueryExpressionDataSource(""50B1C2C1-17D6-43DD-AABC-875561B59218"");DataTable result50B1C2C117D643DDAABC875561B59218=iSpace.SetGridDataSource(querySource50B1C2C117D643DDAABC875561B59218, _objectFactory.GetGridRPP(""BudgetDetails""),@""EXEC [GetProjectDetailCombo] 15,'"" + ISpace[""ID1""].Value + @""'"");iSpace.InsertGridBindDetails(""BudgetDetails"",""11"",querySource50B1C2C117D643DDAABC875561B59218,""EXEC [GetProjectDetailCombo] 15,'"" + ISpace[""ID1""].Value + @""'"",_objectFactory.GetGridRPP(""BudgetDetails""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> resultE0FCE3633C384ED1AEF447B229CAACA2=acdataIspaceD0B6EBB910A44D43A76EF39441A41EF6.GetQueryExpressionBindings("E0FCE363-3C38-4ED1-AEF4-47B229CAACA2");
iSpace.SetGridData(result50B1C2C117D643DDAABC875561B59218,resultE0FCE3633C384ED1AEF447B229CAACA2,"BudgetDetails",ref ISpace);
iSpace.UpdateGridBindDetails("BudgetDetails",resultE0FCE3633C384ED1AEF447B229CAACA2);
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_startdate (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"StartDate-OnChange");
base.WriteDebugInfo(@"EXEC GetDateDifferenceInYears 1,'#StartDate','#Duration','#MonthYear'");

var querySource3158A08581EB4C06AB090EE7136CEFA1 =GetQueryExpressionDataSource("3158A085-81EB-4C06-AB09-0EE7136CEFA1");
Dictionary<short,object> result3158A08581EB4C06AB090EE7136CEFA1=iSpace.ExecuteQuery(querySource3158A08581EB4C06AB090EE7136CEFA1,@"EXEC GetDateDifferenceInYears 1,'" + ISpace["StartDate"].Value + @"','" + ISpace["Duration"].Value + @"','" + ISpace["MonthYear"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource3158A08581EB4C06AB090EE7136CEFA1 =GetQueryExpressionDataSource(""3158A085-81EB-4C06-AB09-0EE7136CEFA1"");Dictionary<short,object> result3158A08581EB4C06AB090EE7136CEFA1=iSpace.ExecuteQuery(querySource3158A08581EB4C06AB090EE7136CEFA1,@""EXEC GetDateDifferenceInYears 1,'"" + ISpace[""StartDate""].Value + @""','"" + ISpace[""Duration""].Value + @""','"" + ISpace[""MonthYear""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result3158A08581EB4C06AB090EE7136CEFA1!=null) && (result3158A08581EB4C06AB090EE7136CEFA1.Count!=0))
{
if(result3158A08581EB4C06AB090EE7136CEFA1.ContainsKey(0))
ISpace["EndDate"].Value = result3158A08581EB4C06AB090EE7136CEFA1[0];
}
else{
ISpace["EndDate"].Value = null;
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
ISpace["UI_CD"].ShowDialog=true;;
base.WriteDebugInfo(@"ISpace[""UI_CD""].ShowDialog=true;;");
ISpace["ACode"].Value="";
base.WriteDebugInfo(@"ISpace[""ACode""].Value="""";");
ISpace["AAName"].Value="";
base.WriteDebugInfo(@"ISpace[""AAName""].Value="""";");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_eqequipmenttotalcost (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"EQEquipmentTotalCost-OnChange");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["EQEquipmentTotalCost"].Value=ISpace["EQEquipmentRateinINR"].Value*ISpace["EQEquipmentQuantity"].Value;
base.WriteDebugInfo(@"ISpace[""EQEquipmentTotalCost""].Value=ISpace[""EQEquipmentRateinINR""].Value*ISpace[""EQEquipmentQuantity""].Value;");
object EQEquipmentTotalCost=iSpace.Sum("[71802A68-968A-4C2C-8AFE-32BA5B817B50]","EQEquipmentTotalCost","",ISpace["gv_instanceid"].Value);
ISpace["EquipmentTotalCost"].Value=Convert.ChangeType(EQEquipmentTotalCost, EQEquipmentTotalCost.GetType());;
base.WriteDebugInfo(@"object EQEquipmentTotalCost=iSpace.Sum(""[71802A68-968A-4C2C-8AFE-32BA5B817B50]"",""EQEquipmentTotalCost"","""",ISpace[""gv_instanceid""].Value);
ISpace[""EquipmentTotalCost""].Value=Convert.ChangeType(EQEquipmentTotalCost, EQEquipmentTotalCost.GetType());;");
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_asubmit (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"ASubmit-OnClick");
base.WriteDebugInfo(@"EXEC CheckDuplicateBudgetName '',3,'','','#AAName','#ACode','',''");

var querySource7A759801183A46158EDEEA8E8ADD66BD =GetQueryExpressionDataSource("7A759801-183A-4615-8EDE-EA8E8ADD66BD");
Dictionary<short,object> result7A759801183A46158EDEEA8E8ADD66BD=iSpace.ExecuteQuery(querySource7A759801183A46158EDEEA8E8ADD66BD,@"EXEC CheckDuplicateBudgetName '',3,'','','" + ISpace["AAName"].Value + @"','" + ISpace["ACode"].Value + @"','',''",false);

base.WriteDebugInfo(@"var querySource7A759801183A46158EDEEA8E8ADD66BD =GetQueryExpressionDataSource(""7A759801-183A-4615-8EDE-EA8E8ADD66BD"");Dictionary<short,object> result7A759801183A46158EDEEA8E8ADD66BD=iSpace.ExecuteQuery(querySource7A759801183A46158EDEEA8E8ADD66BD,@""EXEC CheckDuplicateBudgetName '',3,'','','"" + ISpace[""AAName""].Value + @""','"" + ISpace[""ACode""].Value + @""','',''"",false);");
base.WriteDebugInfo(@"");

if((result7A759801183A46158EDEEA8E8ADD66BD!=null) && (result7A759801183A46158EDEEA8E8ADD66BD.Count!=0))
{
if(result7A759801183A46158EDEEA8E8ADD66BD.ContainsKey(0))
ISpace["CategoryDuplicate"].Value = result7A759801183A46158EDEEA8E8ADD66BD[0];
}
else{
ISpace["CategoryDuplicate"].Value = null;
}
if(ISpace["CategoryDuplicate"].Value=="1")
{
base.WriteDebugInfo(@"if(ISpace[""CategoryDuplicate""].Value==""1"")");
ISpace["Message"].Value=@"Project Category Already Exist";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Project Category Already Exist"";");
return;
base.WriteDebugInfo(@"return;");
}
ISpace["ProjectCategory"].rElemData=iSpace.Reload(ISpace["ProjectCategory"].Value,@"EXEC GetDateDifferenceInYears 4,'','',''","40BDEB14-07CC-4150-8A52-9B088A428E2D");
base.WriteDebugInfo(@"ISpace[""ProjectCategory""].rElemData=iSpace.Reload(ISpace[""ProjectCategory""].Value,@""EXEC GetDateDifferenceInYears 4,'','',''"",""40BDEB14-07CC-4150-8A52-9B088A428E2D"");");
ISpace["UI_CD"].HideDialog=true;;
base.WriteDebugInfo(@"ISpace[""UI_CD""].HideDialog=true;;");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_endorsementamount (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"EndorsementAmount-OnChange");
ISpace["RecurringAmount"].Value=0;
base.WriteDebugInfo(@"ISpace[""RecurringAmount""].Value=0;");
ISpace["NonRecurringAmount"].Value=0;
base.WriteDebugInfo(@"ISpace[""NonRecurringAmount""].Value=0;");
object BudgetAmount=iSpace.Sum("[C92F6C5D-F7CB-4E81-835C-3D655C7FCC52]","BudgetAmount","",ISpace["gv_instanceid"].Value);
ISpace["OverallBudgetTotal"].Value=Convert.ChangeType(BudgetAmount, BudgetAmount.GetType());;
base.WriteDebugInfo(@"object BudgetAmount=iSpace.Sum(""[C92F6C5D-F7CB-4E81-835C-3D655C7FCC52]"",""BudgetAmount"","""",ISpace[""gv_instanceid""].Value);
ISpace[""OverallBudgetTotal""].Value=Convert.ChangeType(BudgetAmount, BudgetAmount.GetType());;");
if(1==2)
{
base.WriteDebugInfo(@"if(1==2)");
base.WriteDebugInfo(@"#BudgetDetails[Rows]");
iSpace.GetLoopExpressionData("BudgetDetails",ref ISpace);

foreach(var gridChild in ISpace["BudgetDetails"].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 


if(
ISpace["RecurringValidation"].Value==518)
{
base.WriteDebugInfo(@"
if(
ISpace[""RecurringValidation""].Value==518)");
object BudgetAmount=iSpace.Sum("[C92F6C5D-F7CB-4E81-835C-3D655C7FCC52]","BudgetAmount","",ISpace["gv_instanceid"].Value);
ISpace["RecurringAmount"].Value=Convert.ChangeType(BudgetAmount, BudgetAmount.GetType());;
base.WriteDebugInfo(@"object BudgetAmount=iSpace.Sum(""[C92F6C5D-F7CB-4E81-835C-3D655C7FCC52]"",""BudgetAmount"","""",ISpace[""gv_instanceid""].Value);
ISpace[""RecurringAmount""].Value=Convert.ChangeType(BudgetAmount, BudgetAmount.GetType());;");
}
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("BudgetDetails","C92F6C5D-F7CB-4E81-835C-3D655C7FCC52",_objectFactory.GetGridRPP("BudgetDetails"),_elementBase.GetGridLoopQuery("C92F6C5D-F7CB-4E81-835C-3D655C7FCC52","BudgetDetails",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""BudgetDetails"",ref ISpace);

foreach(var gridChild in ISpace[""BudgetDetails""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
}
base.WriteDebugInfo(@"#BudgetDetails[Rows]");
iSpace.GetLoopExpressionData("BudgetDetails",ref ISpace);

foreach(var gridChild in ISpace["BudgetDetails"].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 


if(
ISpace["RecurringValidation"].Value==519)
{
base.WriteDebugInfo(@"
if(
ISpace[""RecurringValidation""].Value==519)");
ISpace["NonRecurringAmount"].Value=ISpace["NonRecurringAmount"].Value+ISpace["BudgetAmount"].Value;
base.WriteDebugInfo(@"ISpace[""NonRecurringAmount""].Value=ISpace[""NonRecurringAmount""].Value+ISpace[""BudgetAmount""].Value;");
}

if(
ISpace["RecurringValidation"].Value==518)
{
base.WriteDebugInfo(@"
if(
ISpace[""RecurringValidation""].Value==518)");
ISpace["RecurringAmount"].Value=ISpace["RecurringAmount"].Value+ISpace["BudgetAmount"].Value;
base.WriteDebugInfo(@"ISpace[""RecurringAmount""].Value=ISpace[""RecurringAmount""].Value+ISpace[""BudgetAmount""].Value;");
}
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("BudgetDetails","C92F6C5D-F7CB-4E81-835C-3D655C7FCC52",_objectFactory.GetGridRPP("BudgetDetails"),_elementBase.GetGridLoopQuery("C92F6C5D-F7CB-4E81-835C-3D655C7FCC52","BudgetDetails",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""BudgetDetails"",ref ISpace);

foreach(var gridChild in ISpace[""BudgetDetails""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_fclose (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"FClose-OnClick");
ISpace["UI_CD2"].HideDialog=true;;
base.WriteDebugInfo(@"ISpace[""UI_CD2""].HideDialog=true;;");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_budgetadd (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"BudgetAdd-OnClick");
ISpace["UI_CD3"].ShowDialog=true;;
base.WriteDebugInfo(@"ISpace[""UI_CD3""].ShowDialog=true;;");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_fundclose (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"FundClose-OnClick");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["UI_CD4"].HideDialog=true;;
base.WriteDebugInfo(@"ISpace[""UI_CD4""].HideDialog=true;;");
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_budgethead (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"BudgetHead-OnChange");
ISpace["Bid"].Value=ISpace["BudgetHead"].Value;
base.WriteDebugInfo(@"ISpace[""Bid""].Value=ISpace[""BudgetHead""].Value;");
ISpace["BudgetDuplicate"].Value=ISpace["Bid"].Value;
base.WriteDebugInfo(@"ISpace[""BudgetDuplicate""].Value=ISpace[""Bid""].Value;");
base.WriteDebugInfo(@"EXEC [CheckDuplicateBudget] '#ID1','#BudgetDuplicate'");

var querySourceF53C40FA97A2447F96054E5BE7B63C82 =GetQueryExpressionDataSource("F53C40FA-97A2-447F-9605-4E5BE7B63C82");
Dictionary<short,object> resultF53C40FA97A2447F96054E5BE7B63C82=iSpace.ExecuteQuery(querySourceF53C40FA97A2447F96054E5BE7B63C82,@"EXEC [CheckDuplicateBudget] '" + ISpace["ID1"].Value + @"','" + ISpace["BudgetDuplicate"].Value + @"'",false);

base.WriteDebugInfo(@"var querySourceF53C40FA97A2447F96054E5BE7B63C82 =GetQueryExpressionDataSource(""F53C40FA-97A2-447F-9605-4E5BE7B63C82"");Dictionary<short,object> resultF53C40FA97A2447F96054E5BE7B63C82=iSpace.ExecuteQuery(querySourceF53C40FA97A2447F96054E5BE7B63C82,@""EXEC [CheckDuplicateBudget] '"" + ISpace[""ID1""].Value + @""','"" + ISpace[""BudgetDuplicate""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((resultF53C40FA97A2447F96054E5BE7B63C82!=null) && (resultF53C40FA97A2447F96054E5BE7B63C82.Count!=0))
{
if(resultF53C40FA97A2447F96054E5BE7B63C82.ContainsKey(0))
ISpace["DuplicateBudget"].Value = resultF53C40FA97A2447F96054E5BE7B63C82[0];
}
else{
ISpace["DuplicateBudget"].Value = null;
}
if(ISpace["DuplicateBudget"].Value=="1")
{
base.WriteDebugInfo(@"if(ISpace[""DuplicateBudget""].Value==""1"")");
ISpace["Message"].Value=@"Already Exist the Budget Head";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Already Exist the Budget Head"";");

var querySource8CCD9B52430B4335AB767F537BAD0538 =GetQueryExpressionDataSource("8CCD9B52-430B-4335-AB76-7F537BAD0538");

DataTable result8CCD9B52430B4335AB767F537BAD0538=iSpace.SetGridDataSource(querySource8CCD9B52430B4335AB767F537BAD0538, _objectFactory.GetGridRPP("BudgetDetails"),@"EXEC [GetProjectDetailCombo1] 1,'" + ISpace["ID1"].Value + @"'");

iSpace.InsertGridBindDetails("BudgetDetails","11",querySource8CCD9B52430B4335AB767F537BAD0538,"EXEC [GetProjectDetailCombo1] 1,'" + ISpace["ID1"].Value + @"'",_objectFactory.GetGridRPP("BudgetDetails"));

base.WriteDebugInfo(@"var querySource8CCD9B52430B4335AB767F537BAD0538 =GetQueryExpressionDataSource(""8CCD9B52-430B-4335-AB76-7F537BAD0538"");DataTable result8CCD9B52430B4335AB767F537BAD0538=iSpace.SetGridDataSource(querySource8CCD9B52430B4335AB767F537BAD0538, _objectFactory.GetGridRPP(""BudgetDetails""),@""EXEC [GetProjectDetailCombo1] 1,'"" + ISpace[""ID1""].Value + @""'"");iSpace.InsertGridBindDetails(""BudgetDetails"",""11"",querySource8CCD9B52430B4335AB767F537BAD0538,""EXEC [GetProjectDetailCombo1] 1,'"" + ISpace[""ID1""].Value + @""'"",_objectFactory.GetGridRPP(""BudgetDetails""));");
base.WriteDebugInfo(@"");


List<Triplet<string, short, short?>> result979C2DE5B54949E48CB49F063D649950=acdataIspaceD0B6EBB910A44D43A76EF39441A41EF6.GetQueryExpressionBindings("979C2DE5-B549-49E4-8CB4-9F063D649950");
iSpace.SetGridData(result8CCD9B52430B4335AB767F537BAD0538,result979C2DE5B54949E48CB49F063D649950,"BudgetDetails",ref ISpace);
iSpace.UpdateGridBindDetails("BudgetDetails",result979C2DE5B54949E48CB49F063D649950);
ISpace["OverallBudgetTotal"].Value=null;
base.WriteDebugInfo(@"ISpace[""OverallBudgetTotal""].Value=null;");
object BudgetAmount=iSpace.Sum("[C92F6C5D-F7CB-4E81-835C-3D655C7FCC52]","BudgetAmount","",ISpace["gv_instanceid"].Value);
ISpace["OverallBudgetTotal"].Value=Convert.ChangeType(BudgetAmount, BudgetAmount.GetType());;
base.WriteDebugInfo(@"object BudgetAmount=iSpace.Sum(""[C92F6C5D-F7CB-4E81-835C-3D655C7FCC52]"",""BudgetAmount"","""",ISpace[""gv_instanceid""].Value);
ISpace[""OverallBudgetTotal""].Value=Convert.ChangeType(BudgetAmount, BudgetAmount.GetType());;");
return;
base.WriteDebugInfo(@"return;");
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_ei_phonenumber (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"EI_PhoneNumber-OnChange");
ISpace["EI_PhoneNumber"].Value=RegularExpression(ISpace["EI_PhoneNumber"].Value,"^[0-9]+$","0");
base.WriteDebugInfo(@"ISpace[""EI_PhoneNumber""].Value=RegularExpression(ISpace[""EI_PhoneNumber""].Value,""^[0-9]+$"",""0"");");
if(ISpace["EI_PhoneNumber"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""EI_PhoneNumber""].Value=="""")");
ISpace["Message"].Value=@"Please enter a valid Phone number";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please enter a valid Phone number"";");
return;
base.WriteDebugInfo(@"return;");
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_year18 (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Year18-OnChange");
ISpace["BudgetAmount"].Value= ISpace["Year11"].Value+ISpace["Year12"].Value+ISpace["Year13"].Value+ISpace["Year14"].Value+ISpace["Year15"].Value+ISpace["Year16"].Value+ISpace["Year17"].Value+ISpace["Year18"].Value+ISpace["Year19"].Value+ISpace["Year20"].Value+ISpace["Year21"].Value+ISpace["Year22"].Value;
base.WriteDebugInfo(@"ISpace[""BudgetAmount""].Value= ISpace[""Year11""].Value+ISpace[""Year12""].Value+ISpace[""Year13""].Value+ISpace[""Year14""].Value+ISpace[""Year15""].Value+ISpace[""Year16""].Value+ISpace[""Year17""].Value+ISpace[""Year18""].Value+ISpace[""Year19""].Value+ISpace[""Year20""].Value+ISpace[""Year21""].Value+ISpace[""Year22""].Value;");
ISpace["RecurringAmount"].Value=0;
base.WriteDebugInfo(@"ISpace[""RecurringAmount""].Value=0;");
ISpace["NonRecurringAmount"].Value=0;
base.WriteDebugInfo(@"ISpace[""NonRecurringAmount""].Value=0;");
object BudgetAmount=iSpace.Sum("[C92F6C5D-F7CB-4E81-835C-3D655C7FCC52]","BudgetAmount","",ISpace["gv_instanceid"].Value);
ISpace["OverallBudgetTotal"].Value=Convert.ChangeType(BudgetAmount, BudgetAmount.GetType());;
base.WriteDebugInfo(@"object BudgetAmount=iSpace.Sum(""[C92F6C5D-F7CB-4E81-835C-3D655C7FCC52]"",""BudgetAmount"","""",ISpace[""gv_instanceid""].Value);
ISpace[""OverallBudgetTotal""].Value=Convert.ChangeType(BudgetAmount, BudgetAmount.GetType());;");
if(1==2)
{
base.WriteDebugInfo(@"if(1==2)");
base.WriteDebugInfo(@"#BudgetDetails[Rows]");
iSpace.GetLoopExpressionData("BudgetDetails",ref ISpace);

foreach(var gridChild in ISpace["BudgetDetails"].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 


if(
ISpace["RecurringValidation"].Value==518)
{
base.WriteDebugInfo(@"
if(
ISpace[""RecurringValidation""].Value==518)");
object BudgetAmount=iSpace.Sum("[C92F6C5D-F7CB-4E81-835C-3D655C7FCC52]","BudgetAmount","",ISpace["gv_instanceid"].Value);
ISpace["RecurringAmount"].Value=Convert.ChangeType(BudgetAmount, BudgetAmount.GetType());;
base.WriteDebugInfo(@"object BudgetAmount=iSpace.Sum(""[C92F6C5D-F7CB-4E81-835C-3D655C7FCC52]"",""BudgetAmount"","""",ISpace[""gv_instanceid""].Value);
ISpace[""RecurringAmount""].Value=Convert.ChangeType(BudgetAmount, BudgetAmount.GetType());;");
}
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("BudgetDetails","C92F6C5D-F7CB-4E81-835C-3D655C7FCC52",_objectFactory.GetGridRPP("BudgetDetails"),_elementBase.GetGridLoopQuery("C92F6C5D-F7CB-4E81-835C-3D655C7FCC52","BudgetDetails",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""BudgetDetails"",ref ISpace);

foreach(var gridChild in ISpace[""BudgetDetails""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
}
base.WriteDebugInfo(@"#BudgetDetails[Rows]");
iSpace.GetLoopExpressionData("BudgetDetails",ref ISpace);

foreach(var gridChild in ISpace["BudgetDetails"].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 


if(
ISpace["RecurringValidation"].Value==519)
{
base.WriteDebugInfo(@"
if(
ISpace[""RecurringValidation""].Value==519)");
ISpace["NonRecurringAmount"].Value=ISpace["NonRecurringAmount"].Value+ISpace["BudgetAmount"].Value;
base.WriteDebugInfo(@"ISpace[""NonRecurringAmount""].Value=ISpace[""NonRecurringAmount""].Value+ISpace[""BudgetAmount""].Value;");
}

if(
ISpace["RecurringValidation"].Value==518)
{
base.WriteDebugInfo(@"
if(
ISpace[""RecurringValidation""].Value==518)");
ISpace["RecurringAmount"].Value=ISpace["RecurringAmount"].Value+ISpace["BudgetAmount"].Value;
base.WriteDebugInfo(@"ISpace[""RecurringAmount""].Value=ISpace[""RecurringAmount""].Value+ISpace[""BudgetAmount""].Value;");
}
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("BudgetDetails","C92F6C5D-F7CB-4E81-835C-3D655C7FCC52",_objectFactory.GetGridRPP("BudgetDetails"),_elementBase.GetGridLoopQuery("C92F6C5D-F7CB-4E81-835C-3D655C7FCC52","BudgetDetails",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""BudgetDetails"",ref ISpace);

foreach(var gridChild in ISpace[""BudgetDetails""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_year19 (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Year19-OnChange");
ISpace["BudgetAmount"].Value= ISpace["Year11"].Value+ISpace["Year12"].Value+ISpace["Year13"].Value+ISpace["Year14"].Value+ISpace["Year15"].Value+ISpace["Year16"].Value+ISpace["Year17"].Value+ISpace["Year18"].Value+ISpace["Year19"].Value+ISpace["Year20"].Value+ISpace["Year21"].Value+ISpace["Year22"].Value;
base.WriteDebugInfo(@"ISpace[""BudgetAmount""].Value= ISpace[""Year11""].Value+ISpace[""Year12""].Value+ISpace[""Year13""].Value+ISpace[""Year14""].Value+ISpace[""Year15""].Value+ISpace[""Year16""].Value+ISpace[""Year17""].Value+ISpace[""Year18""].Value+ISpace[""Year19""].Value+ISpace[""Year20""].Value+ISpace[""Year21""].Value+ISpace[""Year22""].Value;");
ISpace["RecurringAmount"].Value=0;
base.WriteDebugInfo(@"ISpace[""RecurringAmount""].Value=0;");
ISpace["NonRecurringAmount"].Value=0;
base.WriteDebugInfo(@"ISpace[""NonRecurringAmount""].Value=0;");
object BudgetAmount=iSpace.Sum("[C92F6C5D-F7CB-4E81-835C-3D655C7FCC52]","BudgetAmount","",ISpace["gv_instanceid"].Value);
ISpace["OverallBudgetTotal"].Value=Convert.ChangeType(BudgetAmount, BudgetAmount.GetType());;
base.WriteDebugInfo(@"object BudgetAmount=iSpace.Sum(""[C92F6C5D-F7CB-4E81-835C-3D655C7FCC52]"",""BudgetAmount"","""",ISpace[""gv_instanceid""].Value);
ISpace[""OverallBudgetTotal""].Value=Convert.ChangeType(BudgetAmount, BudgetAmount.GetType());;");
if(1==2)
{
base.WriteDebugInfo(@"if(1==2)");
base.WriteDebugInfo(@"#BudgetDetails[Rows]");
iSpace.GetLoopExpressionData("BudgetDetails",ref ISpace);

foreach(var gridChild in ISpace["BudgetDetails"].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 


if(
ISpace["RecurringValidation"].Value==518)
{
base.WriteDebugInfo(@"
if(
ISpace[""RecurringValidation""].Value==518)");
object BudgetAmount=iSpace.Sum("[C92F6C5D-F7CB-4E81-835C-3D655C7FCC52]","BudgetAmount","",ISpace["gv_instanceid"].Value);
ISpace["RecurringAmount"].Value=Convert.ChangeType(BudgetAmount, BudgetAmount.GetType());;
base.WriteDebugInfo(@"object BudgetAmount=iSpace.Sum(""[C92F6C5D-F7CB-4E81-835C-3D655C7FCC52]"",""BudgetAmount"","""",ISpace[""gv_instanceid""].Value);
ISpace[""RecurringAmount""].Value=Convert.ChangeType(BudgetAmount, BudgetAmount.GetType());;");
}
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("BudgetDetails","C92F6C5D-F7CB-4E81-835C-3D655C7FCC52",_objectFactory.GetGridRPP("BudgetDetails"),_elementBase.GetGridLoopQuery("C92F6C5D-F7CB-4E81-835C-3D655C7FCC52","BudgetDetails",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""BudgetDetails"",ref ISpace);

foreach(var gridChild in ISpace[""BudgetDetails""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
}
base.WriteDebugInfo(@"#BudgetDetails[Rows]");
iSpace.GetLoopExpressionData("BudgetDetails",ref ISpace);

foreach(var gridChild in ISpace["BudgetDetails"].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 


if(
ISpace["RecurringValidation"].Value==519)
{
base.WriteDebugInfo(@"
if(
ISpace[""RecurringValidation""].Value==519)");
ISpace["NonRecurringAmount"].Value=ISpace["NonRecurringAmount"].Value+ISpace["BudgetAmount"].Value;
base.WriteDebugInfo(@"ISpace[""NonRecurringAmount""].Value=ISpace[""NonRecurringAmount""].Value+ISpace[""BudgetAmount""].Value;");
}

if(
ISpace["RecurringValidation"].Value==518)
{
base.WriteDebugInfo(@"
if(
ISpace[""RecurringValidation""].Value==518)");
ISpace["RecurringAmount"].Value=ISpace["RecurringAmount"].Value+ISpace["BudgetAmount"].Value;
base.WriteDebugInfo(@"ISpace[""RecurringAmount""].Value=ISpace[""RecurringAmount""].Value+ISpace[""BudgetAmount""].Value;");
}
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("BudgetDetails","C92F6C5D-F7CB-4E81-835C-3D655C7FCC52",_objectFactory.GetGridRPP("BudgetDetails"),_elementBase.GetGridLoopQuery("C92F6C5D-F7CB-4E81-835C-3D655C7FCC52","BudgetDetails",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""BudgetDetails"",ref ISpace);

foreach(var gridChild in ISpace[""BudgetDetails""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_aclose (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Aclose-OnClick");
ISpace["UI_CD"].HideDialog=true;;
base.WriteDebugInfo(@"ISpace[""UI_CD""].HideDialog=true;;");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_year13 (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Year13-OnChange");
ISpace["BudgetAmount"].Value= ISpace["Year11"].Value+ISpace["Year12"].Value+ISpace["Year13"].Value+ISpace["Year14"].Value+ISpace["Year15"].Value+ISpace["Year16"].Value+ISpace["Year17"].Value+ISpace["Year18"].Value+ISpace["Year19"].Value+ISpace["Year20"].Value+ISpace["Year21"].Value+ISpace["Year22"].Value;
base.WriteDebugInfo(@"ISpace[""BudgetAmount""].Value= ISpace[""Year11""].Value+ISpace[""Year12""].Value+ISpace[""Year13""].Value+ISpace[""Year14""].Value+ISpace[""Year15""].Value+ISpace[""Year16""].Value+ISpace[""Year17""].Value+ISpace[""Year18""].Value+ISpace[""Year19""].Value+ISpace[""Year20""].Value+ISpace[""Year21""].Value+ISpace[""Year22""].Value;");
ISpace["RecurringAmount"].Value=0;
base.WriteDebugInfo(@"ISpace[""RecurringAmount""].Value=0;");
ISpace["NonRecurringAmount"].Value=0;
base.WriteDebugInfo(@"ISpace[""NonRecurringAmount""].Value=0;");
object BudgetAmount=iSpace.Sum("[C92F6C5D-F7CB-4E81-835C-3D655C7FCC52]","BudgetAmount","",ISpace["gv_instanceid"].Value);
ISpace["OverallBudgetTotal"].Value=Convert.ChangeType(BudgetAmount, BudgetAmount.GetType());;
base.WriteDebugInfo(@"object BudgetAmount=iSpace.Sum(""[C92F6C5D-F7CB-4E81-835C-3D655C7FCC52]"",""BudgetAmount"","""",ISpace[""gv_instanceid""].Value);
ISpace[""OverallBudgetTotal""].Value=Convert.ChangeType(BudgetAmount, BudgetAmount.GetType());;");
if(1==2)
{
base.WriteDebugInfo(@"if(1==2)");
base.WriteDebugInfo(@"#BudgetDetails[Rows]");
iSpace.GetLoopExpressionData("BudgetDetails",ref ISpace);

foreach(var gridChild in ISpace["BudgetDetails"].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 


if(
ISpace["RecurringValidation"].Value==518)
{
base.WriteDebugInfo(@"
if(
ISpace[""RecurringValidation""].Value==518)");
object BudgetAmount=iSpace.Sum("[C92F6C5D-F7CB-4E81-835C-3D655C7FCC52]","BudgetAmount","",ISpace["gv_instanceid"].Value);
ISpace["RecurringAmount"].Value=Convert.ChangeType(BudgetAmount, BudgetAmount.GetType());;
base.WriteDebugInfo(@"object BudgetAmount=iSpace.Sum(""[C92F6C5D-F7CB-4E81-835C-3D655C7FCC52]"",""BudgetAmount"","""",ISpace[""gv_instanceid""].Value);
ISpace[""RecurringAmount""].Value=Convert.ChangeType(BudgetAmount, BudgetAmount.GetType());;");
}
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("BudgetDetails","C92F6C5D-F7CB-4E81-835C-3D655C7FCC52",_objectFactory.GetGridRPP("BudgetDetails"),_elementBase.GetGridLoopQuery("C92F6C5D-F7CB-4E81-835C-3D655C7FCC52","BudgetDetails",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""BudgetDetails"",ref ISpace);

foreach(var gridChild in ISpace[""BudgetDetails""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
}
base.WriteDebugInfo(@"#BudgetDetails[Rows]");
iSpace.GetLoopExpressionData("BudgetDetails",ref ISpace);

foreach(var gridChild in ISpace["BudgetDetails"].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 


if(
ISpace["RecurringValidation"].Value==519)
{
base.WriteDebugInfo(@"
if(
ISpace[""RecurringValidation""].Value==519)");
ISpace["NonRecurringAmount"].Value=ISpace["NonRecurringAmount"].Value+ISpace["BudgetAmount"].Value;
base.WriteDebugInfo(@"ISpace[""NonRecurringAmount""].Value=ISpace[""NonRecurringAmount""].Value+ISpace[""BudgetAmount""].Value;");
}

if(
ISpace["RecurringValidation"].Value==518)
{
base.WriteDebugInfo(@"
if(
ISpace[""RecurringValidation""].Value==518)");
ISpace["RecurringAmount"].Value=ISpace["RecurringAmount"].Value+ISpace["BudgetAmount"].Value;
base.WriteDebugInfo(@"ISpace[""RecurringAmount""].Value=ISpace[""RecurringAmount""].Value+ISpace[""BudgetAmount""].Value;");
}
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("BudgetDetails","C92F6C5D-F7CB-4E81-835C-3D655C7FCC52",_objectFactory.GetGridRPP("BudgetDetails"),_elementBase.GetGridLoopQuery("C92F6C5D-F7CB-4E81-835C-3D655C7FCC52","BudgetDetails",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""BudgetDetails"",ref ISpace);

foreach(var gridChild in ISpace[""BudgetDetails""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_manpowerrequired (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"ManPowerRequired-OnChange");
if(ISpace["ManPowerRequired"].Value==true)
{
base.WriteDebugInfo(@"if(ISpace[""ManPowerRequired""].Value==true)");
ISpace["ManPowerDetails"].Visible="true";
base.WriteDebugInfo(@"ISpace[""ManPowerDetails""].Visible=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["ManPowerDetails"].Visible="false";
base.WriteDebugInfo(@"ISpace[""ManPowerDetails""].Visible=""false"";");
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_duration (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Duration-OnChange");
base.WriteDebugInfo(@"EXEC GetDateDifferenceInYears 1,'#StartDate','#Duration','#MonthYear'");

var querySource3158A08581EB4C06AB090EE7136CEFA1 =GetQueryExpressionDataSource("3158A085-81EB-4C06-AB09-0EE7136CEFA1");
Dictionary<short,object> result3158A08581EB4C06AB090EE7136CEFA1=iSpace.ExecuteQuery(querySource3158A08581EB4C06AB090EE7136CEFA1,@"EXEC GetDateDifferenceInYears 1,'" + ISpace["StartDate"].Value + @"','" + ISpace["Duration"].Value + @"','" + ISpace["MonthYear"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource3158A08581EB4C06AB090EE7136CEFA1 =GetQueryExpressionDataSource(""3158A085-81EB-4C06-AB09-0EE7136CEFA1"");Dictionary<short,object> result3158A08581EB4C06AB090EE7136CEFA1=iSpace.ExecuteQuery(querySource3158A08581EB4C06AB090EE7136CEFA1,@""EXEC GetDateDifferenceInYears 1,'"" + ISpace[""StartDate""].Value + @""','"" + ISpace[""Duration""].Value + @""','"" + ISpace[""MonthYear""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result3158A08581EB4C06AB090EE7136CEFA1!=null) && (result3158A08581EB4C06AB090EE7136CEFA1.Count!=0))
{
if(result3158A08581EB4C06AB090EE7136CEFA1.ContainsKey(0))
ISpace["EndDate"].Value = result3158A08581EB4C06AB090EE7136CEFA1[0];
}
else{
ISpace["EndDate"].Value = null;
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_monthyear (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MonthYear-OnChange");
base.WriteDebugInfo(@"EXEC GetDateDifferenceInYears 1,'#StartDate','#Duration','#MonthYear'");

var querySource3158A08581EB4C06AB090EE7136CEFA1 =GetQueryExpressionDataSource("3158A085-81EB-4C06-AB09-0EE7136CEFA1");
Dictionary<short,object> result3158A08581EB4C06AB090EE7136CEFA1=iSpace.ExecuteQuery(querySource3158A08581EB4C06AB090EE7136CEFA1,@"EXEC GetDateDifferenceInYears 1,'" + ISpace["StartDate"].Value + @"','" + ISpace["Duration"].Value + @"','" + ISpace["MonthYear"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource3158A08581EB4C06AB090EE7136CEFA1 =GetQueryExpressionDataSource(""3158A085-81EB-4C06-AB09-0EE7136CEFA1"");Dictionary<short,object> result3158A08581EB4C06AB090EE7136CEFA1=iSpace.ExecuteQuery(querySource3158A08581EB4C06AB090EE7136CEFA1,@""EXEC GetDateDifferenceInYears 1,'"" + ISpace[""StartDate""].Value + @""','"" + ISpace[""Duration""].Value + @""','"" + ISpace[""MonthYear""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result3158A08581EB4C06AB090EE7136CEFA1!=null) && (result3158A08581EB4C06AB090EE7136CEFA1.Count!=0))
{
if(result3158A08581EB4C06AB090EE7136CEFA1.ContainsKey(0))
ISpace["EndDate"].Value = result3158A08581EB4C06AB090EE7136CEFA1[0];
}
else{
ISpace["EndDate"].Value = null;
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mainback (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MainBack-OnClick");

ISpace["RedirectUrl"].RedirectType="R";
ISpace["RedirectUrl"].Value="?PkActMId=80BA7272-EBDB-40E4-8780-BBCFE9F7BF42&frmElementId=EC0A9909-7B20-47F6-BC2E-A127EFE2DF19&PkPrMId=2FC376A8-EF63-4E6A-BADA-9EC15ECC14A1&formVersionId=BF48F261-7346-4E90-B167-CAF0E476DD36&Ver=0.0000";
base.WriteDebugInfo(@"
ISpace[""RedirectUrl""].RedirectType=""R"";
ISpace[""RedirectUrl""].Value=""?PkActMId=80BA7272-EBDB-40E4-8780-BBCFE9F7BF42&frmElementId=EC0A9909-7B20-47F6-BC2E-A127EFE2DF19&PkPrMId=2FC376A8-EF63-4E6A-BADA-9EC15ECC14A1&formVersionId=BF48F261-7346-4E90-B167-CAF0E476DD36&Ver=0.0000"";");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_frontback (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Frontback-OnClick");

ISpace["RedirectUrl"].RedirectType="R";
ISpace["RedirectUrl"].Value="?PkActMId=80BA7272-EBDB-40E4-8780-BBCFE9F7BF42&frmElementId=EC0A9909-7B20-47F6-BC2E-A127EFE2DF19&PkPrMId=2FC376A8-EF63-4E6A-BADA-9EC15ECC14A1&formVersionId=BF48F261-7346-4E90-B167-CAF0E476DD36&Ver=0.0000";
base.WriteDebugInfo(@"
ISpace[""RedirectUrl""].RedirectType=""R"";
ISpace[""RedirectUrl""].Value=""?PkActMId=80BA7272-EBDB-40E4-8780-BBCFE9F7BF42&frmElementId=EC0A9909-7B20-47F6-BC2E-A127EFE2DF19&PkPrMId=2FC376A8-EF63-4E6A-BADA-9EC15ECC14A1&formVersionId=BF48F261-7346-4E90-B167-CAF0E476DD36&Ver=0.0000"";");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_add2 (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Add2-OnClick");
ISpace["UI_CD2"].ShowDialog=true;;
base.WriteDebugInfo(@"ISpace[""UI_CD2""].ShowDialog=true;;");
ISpace["FName"].Value="";
base.WriteDebugInfo(@"ISpace[""FName""].Value="""";");
ISpace["FCode"].Value="";
base.WriteDebugInfo(@"ISpace[""FCode""].Value="""";");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_bsubmit (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"BSubmit-OnClick");
if(ISpace["OverallBudgetTotal"].Value>ISpace["ProjectBudget"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""OverallBudgetTotal""].Value>ISpace[""ProjectBudget""].Value)");
ISpace["Message"].Value=@"Total Amount Should be Equal to Project Budget";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Total Amount Should be Equal to Project Budget"";");
ISpace["Year11"].Value=null;
base.WriteDebugInfo(@"ISpace[""Year11""].Value=null;");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["BudgetAmount"].Value= ISpace["Year11"].Value+ISpace["Year12"].Value+ISpace["Year13"].Value+ISpace["Year14"].Value+ISpace["Year15"].Value+ISpace["Year16"].Value+ISpace["Year17"].Value+ISpace["Year18"].Value+ISpace["Year19"].Value+ISpace["Year20"].Value+ISpace["Year21"].Value+ISpace["Year22"].Value;
base.WriteDebugInfo(@"ISpace[""BudgetAmount""].Value= ISpace[""Year11""].Value+ISpace[""Year12""].Value+ISpace[""Year13""].Value+ISpace[""Year14""].Value+ISpace[""Year15""].Value+ISpace[""Year16""].Value+ISpace[""Year17""].Value+ISpace[""Year18""].Value+ISpace[""Year19""].Value+ISpace[""Year20""].Value+ISpace[""Year21""].Value+ISpace[""Year22""].Value;");
ISpace["NonRecurringAmount"].Value=0;
base.WriteDebugInfo(@"ISpace[""NonRecurringAmount""].Value=0;");
ISpace["RecurringAmount"].Value=0;
base.WriteDebugInfo(@"ISpace[""RecurringAmount""].Value=0;");
object BudgetAmount=iSpace.Sum("[C92F6C5D-F7CB-4E81-835C-3D655C7FCC52]","BudgetAmount","",ISpace["gv_instanceid"].Value);
ISpace["OverallBudgetTotal"].Value=Convert.ChangeType(BudgetAmount, BudgetAmount.GetType());;
base.WriteDebugInfo(@"object BudgetAmount=iSpace.Sum(""[C92F6C5D-F7CB-4E81-835C-3D655C7FCC52]"",""BudgetAmount"","""",ISpace[""gv_instanceid""].Value);
ISpace[""OverallBudgetTotal""].Value=Convert.ChangeType(BudgetAmount, BudgetAmount.GetType());;");
base.WriteDebugInfo(@"#BudgetDetails[Rows]");
iSpace.GetLoopExpressionData("BudgetDetails",ref ISpace);

foreach(var gridChild in ISpace["BudgetDetails"].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 


if(
ISpace["RecurringValidation"].Value==519)
{
base.WriteDebugInfo(@"
if(
ISpace[""RecurringValidation""].Value==519)");
ISpace["NonRecurringAmount"].Value=ISpace["NonRecurringAmount"].Value+ISpace["BudgetAmount"].Value;
base.WriteDebugInfo(@"ISpace[""NonRecurringAmount""].Value=ISpace[""NonRecurringAmount""].Value+ISpace[""BudgetAmount""].Value;");
}

if(
ISpace["RecurringValidation"].Value==518)
{
base.WriteDebugInfo(@"
if(
ISpace[""RecurringValidation""].Value==518)");
ISpace["RecurringAmount"].Value=ISpace["RecurringAmount"].Value+ISpace["BudgetAmount"].Value;
base.WriteDebugInfo(@"ISpace[""RecurringAmount""].Value=ISpace[""RecurringAmount""].Value+ISpace[""BudgetAmount""].Value;");
}
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("BudgetDetails","C92F6C5D-F7CB-4E81-835C-3D655C7FCC52",_objectFactory.GetGridRPP("BudgetDetails"),_elementBase.GetGridLoopQuery("C92F6C5D-F7CB-4E81-835C-3D655C7FCC52","BudgetDetails",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""BudgetDetails"",ref ISpace);

foreach(var gridChild in ISpace[""BudgetDetails""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
}
return;
base.WriteDebugInfo(@"return;");
}
ISpace["DocumentDetails"].Man=true;
base.WriteDebugInfo(@"ISpace[""DocumentDetails""].Man=true;");
if(ISpace["IFEquipment"].Value==true)
{
base.WriteDebugInfo(@"if(ISpace[""IFEquipment""].Value==true)");
object EQEquipmentQuantity=iSpace.Count("[71802A68-968A-4C2C-8AFE-32BA5B817B50]","EQEquipmentQuantity","",ISpace["gv_instanceid"].Value);
ISpace["EquipmentGridCount"].Value=Convert.ChangeType(EQEquipmentQuantity, EQEquipmentQuantity.GetType());;
base.WriteDebugInfo(@"object EQEquipmentQuantity=iSpace.Count(""[71802A68-968A-4C2C-8AFE-32BA5B817B50]"",""EQEquipmentQuantity"","""",ISpace[""gv_instanceid""].Value);
ISpace[""EquipmentGridCount""].Value=Convert.ChangeType(EQEquipmentQuantity, EQEquipmentQuantity.GetType());;");
if(ISpace["EquipmentGridCount"].Value>0)
{
base.WriteDebugInfo(@"if(ISpace[""EquipmentGridCount""].Value>0)");
base.WriteDebugInfo(@"#BudgetDetails[Rows]");
iSpace.GetLoopExpressionData("BudgetDetails",ref ISpace);

foreach(var gridChild in ISpace["BudgetDetails"].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 


if(
ISpace["Bid"].Value==2)
{
base.WriteDebugInfo(@"
if(
ISpace[""Bid""].Value==2)");
ISpace["EquipmentAmount"].Value=ISpace["TotalBudget"].Value;
base.WriteDebugInfo(@"ISpace[""EquipmentAmount""].Value=ISpace[""TotalBudget""].Value;");
}
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("BudgetDetails","C92F6C5D-F7CB-4E81-835C-3D655C7FCC52",_objectFactory.GetGridRPP("BudgetDetails"),_elementBase.GetGridLoopQuery("C92F6C5D-F7CB-4E81-835C-3D655C7FCC52","BudgetDetails",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""BudgetDetails"",ref ISpace);

foreach(var gridChild in ISpace[""BudgetDetails""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
if(ISpace["EquipmentTotalCost"].Value>ISpace["EquipmentAmount"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""EquipmentTotalCost""].Value>ISpace[""EquipmentAmount""].Value)");
ISpace["Message"].Value=@"Equipment Total Cost is greater than Equipmet Budget";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Equipment Total Cost is greater than Equipmet Budget"";");
return;
base.WriteDebugInfo(@"return;");
}
}
}
if(ISpace["ManPowerRequired"].Value==true)
{
base.WriteDebugInfo(@"if(ISpace[""ManPowerRequired""].Value==true)");
if(ISpace["ManpowerGridCount"].Value>0)
{
base.WriteDebugInfo(@"if(ISpace[""ManpowerGridCount""].Value>0)");
base.WriteDebugInfo(@"#BudgetDetails[Rows]");
iSpace.GetLoopExpressionData("BudgetDetails",ref ISpace);

foreach(var gridChild in ISpace["BudgetDetails"].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 


if(
ISpace["Bid"].Value==7)
{
base.WriteDebugInfo(@"
if(
ISpace[""Bid""].Value==7)");
ISpace["ManPowerAmount"].Value=ISpace["TotalBudget"].Value;
base.WriteDebugInfo(@"ISpace[""ManPowerAmount""].Value=ISpace[""TotalBudget""].Value;");
}
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("BudgetDetails","C92F6C5D-F7CB-4E81-835C-3D655C7FCC52",_objectFactory.GetGridRPP("BudgetDetails"),_elementBase.GetGridLoopQuery("C92F6C5D-F7CB-4E81-835C-3D655C7FCC52","BudgetDetails",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""BudgetDetails"",ref ISpace);

foreach(var gridChild in ISpace[""BudgetDetails""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
if(ISpace["ManpowerTotalCost"].Value>ISpace["ManPowerAmount"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""ManpowerTotalCost""].Value>ISpace[""ManPowerAmount""].Value)");
ISpace["Message"].Value=@"ManPower Total Cost is greater than Manpower Budget";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""ManPower Total Cost is greater than Manpower Budget"";");
return;
base.WriteDebugInfo(@"return;");
}
}
}
ISpace["JourneyDescription"].Value="Projected Creation submitted";
base.WriteDebugInfo(@"ISpace[""JourneyDescription""].Value=""Projected Creation submitted"";");
base.WriteDebugInfo(@"Entering DomainDataMap for Project Journey Details");
var ProjectJourneyDetails_repoObj = new RepositoryMapper(DbTypes.SQLServer);


var ProjectJourneyDetailsProjectJourneyDetailstableObj = new RepositoryTable("ProjectJourneyDetails");
  ProjectJourneyDetailsProjectJourneyDetailstableObj.AppConnectionSettingsId  ="40BDEB14-07CC-4150-8A52-9B088A428E2D";ProjectJourneyDetailsProjectJourneyDetailstableObj.ProofConnectionId = "C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0)";
var ProjectJourneyDetails_ProjectJourneyDetails_rows = GetElementClientData(ISpace["InstanceId"].Value,"A83D8B17-78DB-4B11-86C7-91E3F9A7C20E");

if(ProjectJourneyDetails_ProjectJourneyDetails_rows!=null && ProjectJourneyDetails_ProjectJourneyDetails_rows.Count>0){
var ProjectJourneyDetails_ProjectJourneyDetails_rowsObj = new List<RepositoryRow>();
foreach(var rows in ProjectJourneyDetails_ProjectJourneyDetails_rows){RepositoryRow repositoryRowObj = null;string elementData = null;RepositoryColumn repositoryColumnObj = null;if(rows !=null){ var ProjectJourneyDetails_colObj = new List<RepositoryColumn>();repositoryRowObj= new RepositoryRow();//var myByte = (byte)rowData.Value.RwSt;//repositoryRowObj.RowState=(RepositoryRowState)myByte;

elementData = CurrentDate().ToString() ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"UpdatedOn",false,false,8);
if(repositoryColumnObj!=null)ProjectJourneyDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-CurrentDate not found");}

if(rows.ContainsKey("49074D93-7C7F-401F-AD44-0BB2B5353FE3"))     elementData = rows["49074D93-7C7F-401F-AD44-0BB2B5353FE3"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ProjectDetailsID",false,false,9);
if(repositoryColumnObj!=null)ProjectJourneyDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-ID1 not found");}

if(rows.ContainsKey("43356C7F-4DDE-4F2A-8D55-57CDB47E2638"))     elementData = rows["43356C7F-4DDE-4F2A-8D55-57CDB47E2638"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Sino",true,true,5);
if(repositoryColumnObj!=null)ProjectJourneyDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-JourneyID not found");}

elementData = ISpace["gv_UserId"].Value != null? Convert.ToString(ISpace["gv_UserId"].Value):null ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"UpdatedBy",false,false,6);
if(repositoryColumnObj!=null)ProjectJourneyDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-gv_UserId not found");}

if(rows.ContainsKey("FA665425-5015-4C9D-9CA6-D06A798A7649"))     elementData = rows["FA665425-5015-4C9D-9CA6-D06A798A7649"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ProjectJourneyDescription",false,false,9);
if(repositoryColumnObj!=null)ProjectJourneyDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-JourneyDescription not found");}
repositoryRowObj.Columns=ProjectJourneyDetails_colObj;
ProjectJourneyDetails_ProjectJourneyDetails_rowsObj.Add(repositoryRowObj);
}}

ProjectJourneyDetailsProjectJourneyDetailstableObj.Rows=ProjectJourneyDetails_ProjectJourneyDetails_rowsObj;
var ProjectJourneyDetails_repoObj_status_ProjectJourneyDetails = ProjectJourneyDetails_repoObj.Execute(DomainOperationTypes.CreateOrUpdate,ref ProjectJourneyDetailsProjectJourneyDetailstableObj);if(!ProjectJourneyDetails_repoObj_status_ProjectJourneyDetails) throw new Exception("Error in Execute Domain Data Map");}
base.WriteDebugInfo(@"Exiting DomainDataMap for Project Journey Details");
base.WriteDebugInfo(@"exec UpdateProposalIsSubmit '#ProjectProposal'");

var querySource7AD869272FFA4555BA40DAA289C8646D =GetQueryExpressionDataSource("7AD86927-2FFA-4555-BA40-DAA289C8646D");
Dictionary<short,object> result7AD869272FFA4555BA40DAA289C8646D=iSpace.ExecuteQuery(querySource7AD869272FFA4555BA40DAA289C8646D,@"execUpdateProposalIsSubmit '" + ISpace["ProjectProposal"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource7AD869272FFA4555BA40DAA289C8646D =GetQueryExpressionDataSource(""7AD86927-2FFA-4555-BA40-DAA289C8646D"");Dictionary<short,object> result7AD869272FFA4555BA40DAA289C8646D=iSpace.ExecuteQuery(querySource7AD869272FFA4555BA40DAA289C8646D,@""execUpdateProposalIsSubmit '"" + ISpace[""ProjectProposal""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result7AD869272FFA4555BA40DAA289C8646D!=null) && (result7AD869272FFA4555BA40DAA289C8646D.Count!=0))
{
if(result7AD869272FFA4555BA40DAA289C8646D.ContainsKey(0))
ISpace["Subject"].Value = result7AD869272FFA4555BA40DAA289C8646D[0];
}
else{
ISpace["Subject"].Value = null;
}
if(ISpace["ActiveEdit"].Value==0)
{
base.WriteDebugInfo(@"if(ISpace[""ActiveEdit""].Value==0)");
ISpace["setflowdummyremarks"].Value="Projected Creation submitted";
base.WriteDebugInfo(@"ISpace[""setflowdummyremarks""].Value=""Projected Creation submitted"";");
ISpace["ProjectStatus"].Value="7";
base.WriteDebugInfo(@"ISpace[""ProjectStatus""].Value=""7"";");
base.WriteDebugInfo(@"Entering DomainDataMap for Project Creation main Domain");
var ProjectCreationmainDomain_repoObj = new RepositoryMapper(DbTypes.SQLServer);


var CreateProjectDetailsProjectCreationmainDomaintableObj = new RepositoryTable("CreateProjectDetails");
  CreateProjectDetailsProjectCreationmainDomaintableObj.AppConnectionSettingsId  ="40BDEB14-07CC-4150-8A52-9B088A428E2D";CreateProjectDetailsProjectCreationmainDomaintableObj.ProofConnectionId = "C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0)";
var ProjectCreationmainDomain_CreateProjectDetails_rows = GetElementClientData(ISpace["InstanceId"].Value,"A83D8B17-78DB-4B11-86C7-91E3F9A7C20E");

if(ProjectCreationmainDomain_CreateProjectDetails_rows!=null && ProjectCreationmainDomain_CreateProjectDetails_rows.Count>0){
var ProjectCreationmainDomain_CreateProjectDetails_rowsObj = new List<RepositoryRow>();
foreach(var rows in ProjectCreationmainDomain_CreateProjectDetails_rows){RepositoryRow repositoryRowObj = null;string elementData = null;RepositoryColumn repositoryColumnObj = null;if(rows !=null){ var CreateProjectDetails_colObj = new List<RepositoryColumn>();repositoryRowObj= new RepositoryRow();//var myByte = (byte)rowData.Value.RwSt;//repositoryRowObj.RowState=(RepositoryRowState)myByte;

if(rows.ContainsKey("B596DD9F-8B75-44EB-BB37-C2D6093E21E7"))     elementData = rows["B596DD9F-8B75-44EB-BB37-C2D6093E21E7"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"EmployeeBasicInfoId",false,false,9);
if(repositoryColumnObj!=null)CreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-EmpEmployeeBasicId not found");}

if(rows.ContainsKey("A0211921-0B97-43E9-BA6F-BC50F482EA7E"))     elementData = rows["A0211921-0B97-43E9-BA6F-BC50F482EA7E"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Sector",false,false,9);
if(repositoryColumnObj!=null)CreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Sector not found");}

if(rows.ContainsKey("603DB6A8-112F-4544-A47D-43751477076A"))     elementData = rows["603DB6A8-112F-4544-A47D-43751477076A"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"IsSubmitted",false,false,5);
if(repositoryColumnObj!=null)CreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-IsSubmit not found");}

if(rows.ContainsKey("02A5B4F7-1A0C-4581-81E9-AE79F5083293"))     elementData = rows["02A5B4F7-1A0C-4581-81E9-AE79F5083293"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Overhead",false,false,5);
if(repositoryColumnObj!=null)CreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Overheads not found");}

if(rows.ContainsKey("B705855C-3908-41FF-998E-EA6B24909F0F"))     elementData = rows["B705855C-3908-41FF-998E-EA6B24909F0F"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"IfManpower",false,false,0);
if(repositoryColumnObj!=null)CreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-ManPowerRequired not found");}

if(rows.ContainsKey("2D32F409-3FDD-44BB-BBA2-5862F0432078"))     elementData = rows["2D32F409-3FDD-44BB-BBA2-5862F0432078"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ProjectType",false,false,9);
if(repositoryColumnObj!=null)CreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-TypeOfProject not found");}

if(rows.ContainsKey("DF847FA7-3DC4-4124-A2E2-46A7B91F0776"))     elementData = rows["DF847FA7-3DC4-4124-A2E2-46A7B91F0776"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"SanctionedDate",false,false,8);
if(repositoryColumnObj!=null)CreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-SanctionDate not found");}

if(rows.ContainsKey("97AE1937-023A-4A40-807F-74C57599806C"))     elementData = rows["97AE1937-023A-4A40-807F-74C57599806C"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"NonRecurringAmount",false,false,3);
if(repositoryColumnObj!=null)CreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-NonRecurringAmount not found");}

if(rows.ContainsKey("3D79FD45-F4C9-4111-9D02-BA7B50CE754E"))     elementData = rows["3D79FD45-F4C9-4111-9D02-BA7B50CE754E"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ProjectproposalID",false,false,9);
if(repositoryColumnObj!=null)CreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-ProjectProposal not found");}

if(rows.ContainsKey("E6D44C17-A165-46AE-80FD-96EBC9629057"))     elementData = rows["E6D44C17-A165-46AE-80FD-96EBC9629057"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"IsExternalIns",false,false,0);
if(repositoryColumnObj!=null)CreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-IfExternalIns not found");}

if(rows.ContainsKey("7BD98942-3580-45F3-9030-7226534C37E1"))     elementData = rows["7BD98942-3580-45F3-9030-7226534C37E1"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Designation",false,false,9);
if(repositoryColumnObj!=null)CreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Designation not found");}

if(rows.ContainsKey("604D4AFD-8CB5-47F6-AAF4-CBED4D7E845D"))     elementData = rows["604D4AFD-8CB5-47F6-AAF4-CBED4D7E845D"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"FundingAgency",false,false,9);
if(repositoryColumnObj!=null)CreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-FundingAcencyName not found");}

if(rows.ContainsKey("7E6249C4-87FC-4119-93B4-404EB37B5D90"))     elementData = rows["7E6249C4-87FC-4119-93B4-404EB37B5D90"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"DepartmentID",false,false,9);
if(repositoryColumnObj!=null)CreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-EmpDepartment not found");}

if(rows.ContainsKey("BC6C053E-0BA2-4200-A0C5-C0EF25B21E2E"))     elementData = rows["BC6C053E-0BA2-4200-A0C5-C0EF25B21E2E"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"RecurringAmount",false,false,3);
if(repositoryColumnObj!=null)CreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-RecurringAmount not found");}

if(rows.ContainsKey("3F3D8917-5954-4C1D-AE68-83C060BB2F32"))     elementData = rows["3F3D8917-5954-4C1D-AE68-83C060BB2F32"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"IfEquipment",false,false,0);
if(repositoryColumnObj!=null)CreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-IFEquipment not found");}

if(rows.ContainsKey("E18A3F8F-76E5-42F2-ABFD-44826B509A29"))     elementData = rows["E18A3F8F-76E5-42F2-ABFD-44826B509A29"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ProjectStatus",false,false,9);
if(repositoryColumnObj!=null)CreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-ProjectStatus not found");}

if(rows.ContainsKey("CA004F50-713B-4AC6-A2AE-DBA4ECDBC578"))     elementData = rows["CA004F50-713B-4AC6-A2AE-DBA4ECDBC578"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ProjectName",false,false,9);
if(repositoryColumnObj!=null)CreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-ProjectName not found");}

if(rows.ContainsKey("CC0BFF91-E6F2-488C-85F2-E16AE98B8BAC"))     elementData = rows["CC0BFF91-E6F2-488C-85F2-E16AE98B8BAC"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"SchemeID",false,false,9);
if(repositoryColumnObj!=null)CreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-SchemeType not found");}

elementData = ISpace["gv_UserId"].Value != null? Convert.ToString(ISpace["gv_UserId"].Value):null ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"UpdatedBy",false,false,6);
if(repositoryColumnObj!=null)CreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-gv_UserId not found");}

if(rows.ContainsKey("0C386A8C-8A37-4559-8464-99855AE81313"))     elementData = rows["0C386A8C-8A37-4559-8464-99855AE81313"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ProjectRefNo",false,false,9);
if(repositoryColumnObj!=null)CreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-ProjectRefNo not found");}

if(rows.ContainsKey("BE1036BA-08CB-4EAC-BEF2-ECADE4084677"))     elementData = rows["BE1036BA-08CB-4EAC-BEF2-ECADE4084677"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Duration",false,false,9);
if(repositoryColumnObj!=null)CreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Duration not found");}

if(rows.ContainsKey("0A6B19A9-6384-4BF3-A9CB-C1A0C675262E"))     elementData = rows["0A6B19A9-6384-4BF3-A9CB-C1A0C675262E"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"SanctionedNumber",false,false,9);
if(repositoryColumnObj!=null)CreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-SanctionNumber not found");}

if(rows.ContainsKey("49074D93-7C7F-401F-AD44-0BB2B5353FE3"))     elementData = rows["49074D93-7C7F-401F-AD44-0BB2B5353FE3"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"InstanceId",true,false,9);
if(repositoryColumnObj!=null)CreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-ID1 not found");}

if(rows.ContainsKey("6D38109B-0A12-40CA-8D51-C0313B482B1F"))     elementData = rows["6D38109B-0A12-40CA-8D51-C0313B482B1F"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ProjectDetailsID",false,true,6);
if(repositoryColumnObj!=null)CreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-ProjectDetailsID not found");}

if(rows.ContainsKey("153737E5-6626-4A69-8501-4AAD946A634A"))     elementData = rows["153737E5-6626-4A69-8501-4AAD946A634A"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"BudgetTotalAmount",false,false,3);
if(repositoryColumnObj!=null)CreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-OverallBudgetTotal not found");}

if(rows.ContainsKey("CBBFAC58-1A83-448A-8F84-B58A0C1C7F6A"))     elementData = rows["CBBFAC58-1A83-448A-8F84-B58A0C1C7F6A"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"YearMonth",false,false,9);
if(repositoryColumnObj!=null)CreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MonthYear not found");}

elementData = CurrentDate().ToString() ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"UpdatedOn",false,false,8);
if(repositoryColumnObj!=null)CreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-CurrentDate not found");}

if(rows.ContainsKey("F63FA021-DA22-44C2-A63A-11A0E2BED913"))     elementData = rows["F63FA021-DA22-44C2-A63A-11A0E2BED913"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"FinancialYearID",false,false,9);
if(repositoryColumnObj!=null)CreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-FinancialYear not found");}

if(rows.ContainsKey("7E613FAC-8E27-4D91-99B7-3848167B6B99"))     elementData = rows["7E613FAC-8E27-4D91-99B7-3848167B6B99"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"FundReceiptMode",false,false,9);
if(repositoryColumnObj!=null)CreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-FundReceiptMode not found");}

if(rows.ContainsKey("6D31749B-2D20-4B17-9A41-596770A56EB3"))     elementData = rows["6D31749B-2D20-4B17-9A41-596770A56EB3"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"DocumentComments",false,false,9);
if(repositoryColumnObj!=null)CreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-DocumentComments not found");}

if(rows.ContainsKey("1CA31193-A9A8-476E-A3FF-F75133B5BDEC"))     elementData = rows["1CA31193-A9A8-476E-A3FF-F75133B5BDEC"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ToDate",false,false,8);
if(repositoryColumnObj!=null)CreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-EndDate not found");}

if(rows.ContainsKey("9FBC7606-B59A-4DF4-B8F4-DC997BA82B1E"))     elementData = rows["9FBC7606-B59A-4DF4-B8F4-DC997BA82B1E"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ProjectBudget",false,false,3);
if(repositoryColumnObj!=null)CreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-ProjectBudget not found");}

if(rows.ContainsKey("92864610-6CBD-4533-BB18-A07F02B8C329"))     elementData = rows["92864610-6CBD-4533-BB18-A07F02B8C329"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"FromDate",false,false,8);
if(repositoryColumnObj!=null)CreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-StartDate not found");}

if(rows.ContainsKey("40BFB2D7-C4A2-4DB5-8080-2DF9DD44B713"))     elementData = rows["40BFB2D7-C4A2-4DB5-8080-2DF9DD44B713"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"PrincipalInvestigator",false,false,9);
if(repositoryColumnObj!=null)CreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-PrincipleInvestigator not found");}

if(rows.ContainsKey("A417D0C0-3A5C-48E6-8692-DF7FC6E78987"))     elementData = rows["A417D0C0-3A5C-48E6-8692-DF7FC6E78987"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ProjectCategoryID",false,false,9);
if(repositoryColumnObj!=null)CreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-ProjectCategory not found");}
repositoryRowObj.Columns=CreateProjectDetails_colObj;
ProjectCreationmainDomain_CreateProjectDetails_rowsObj.Add(repositoryRowObj);
}}

CreateProjectDetailsProjectCreationmainDomaintableObj.Rows=ProjectCreationmainDomain_CreateProjectDetails_rowsObj;
var ProjectCreationmainDomain_repoObj_status_CreateProjectDetails = ProjectCreationmainDomain_repoObj.Execute(DomainOperationTypes.CreateOrUpdate,ref CreateProjectDetailsProjectCreationmainDomaintableObj);if(!ProjectCreationmainDomain_repoObj_status_CreateProjectDetails) throw new Exception("Error in Execute Domain Data Map");}
base.WriteDebugInfo(@"Exiting DomainDataMap for Project Creation main Domain");
ISpace["Message"].Value=@"Submitted Successfully";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Submitted Successfully"";");
base.WriteDebugInfo(@"Entering DomainDataMap for Externalinstitute domain");
var Externalinstitutedomain_repoObj = new RepositoryMapper(DbTypes.SQLServer);


var ProjectCoPiDetailsExternalinstitutedomaintableObj = new RepositoryTable("ProjectCoPiDetails");
  ProjectCoPiDetailsExternalinstitutedomaintableObj.AppConnectionSettingsId  ="CA34B07F-5D19-412F-A39F-3ADA64B5E0C0";ProjectCoPiDetailsExternalinstitutedomaintableObj.ProofConnectionId = "C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0)";
var Externalinstitutedomain_ProjectCoPiDetails_rows = GetElementClientData(ISpace["InstanceId"].Value,"1B307D9B-9E56-415F-8C11-BF109F7A2E30");

if(Externalinstitutedomain_ProjectCoPiDetails_rows!=null && Externalinstitutedomain_ProjectCoPiDetails_rows.Count>0){
var Externalinstitutedomain_ProjectCoPiDetails_rowsObj = new List<RepositoryRow>();
foreach(var rows in Externalinstitutedomain_ProjectCoPiDetails_rows){RepositoryRow repositoryRowObj = null;string elementData = null;RepositoryColumn repositoryColumnObj = null;if(rows !=null){ var ProjectCoPiDetails_colObj = new List<RepositoryColumn>();repositoryRowObj= new RepositoryRow();//var myByte = (byte)rowData.Value.RwSt;//repositoryRowObj.RowState=(RepositoryRowState)myByte;

elementData = CurrentDate().ToString() ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"UpdatedOn",false,false,8);
if(repositoryColumnObj!=null)ProjectCoPiDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-CurrentDate not found");}

if(rows.ContainsKey("412FD0BE-C201-4761-800A-90035D10B206"))     elementData = rows["412FD0BE-C201-4761-800A-90035D10B206"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"AdditionalID",true,false,9);
if(repositoryColumnObj!=null)ProjectCoPiDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-NKLICoPiID not found");}

if(rows.ContainsKey("9EFFC57F-DC0B-4105-8126-63A82EF5FEAD"))     elementData = rows["9EFFC57F-DC0B-4105-8126-63A82EF5FEAD"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ExternalFacultyName",false,false,9);
if(repositoryColumnObj!=null)ProjectCoPiDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-NKLIEI_FacultyName not found");}

if(rows.ContainsKey("44351294-12E1-46E5-8075-8D306069B1B1"))     elementData = rows["44351294-12E1-46E5-8075-8D306069B1B1"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ExternalInstituteName",false,false,9);
if(repositoryColumnObj!=null)ProjectCoPiDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-NKLIEI_Name not found");}

if(rows.ContainsKey("3D79FD45-F4C9-4111-9D02-BA7B50CE754E"))     elementData = rows["3D79FD45-F4C9-4111-9D02-BA7B50CE754E"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ProjectDetailsID",false,false,9);
if(repositoryColumnObj!=null)ProjectCoPiDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-ProjectProposal not found");}

elementData = ISpace["gv_UserId"].Value != null? Convert.ToString(ISpace["gv_UserId"].Value):null ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"UpdatedBy",false,false,6);
if(repositoryColumnObj!=null)ProjectCoPiDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-gv_UserId not found");}

if(rows.ContainsKey("23119290-DB96-4D22-A433-0E910C97A307"))     elementData = rows["23119290-DB96-4D22-A433-0E910C97A307"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ExternalContactNo",false,false,9);
if(repositoryColumnObj!=null)ProjectCoPiDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-NKLIEI_PhoneNumber not found");}

if(rows.ContainsKey("CDF029AB-6627-41A4-AB1D-82FAE8D835DA"))     elementData = rows["CDF029AB-6627-41A4-AB1D-82FAE8D835DA"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"AdditionalType",false,false,9);
if(repositoryColumnObj!=null)ProjectCoPiDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-NKLIEI_Facultytype not found");}

if(rows.ContainsKey("46465681-1951-4036-A5B9-285AFF86BCF2"))     elementData = rows["46465681-1951-4036-A5B9-285AFF86BCF2"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ExternalEmailId",false,false,9);
if(repositoryColumnObj!=null)ProjectCoPiDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-NKLIEI_Mail not found");}
repositoryRowObj.Columns=ProjectCoPiDetails_colObj;
Externalinstitutedomain_ProjectCoPiDetails_rowsObj.Add(repositoryRowObj);
}}

ProjectCoPiDetailsExternalinstitutedomaintableObj.Rows=Externalinstitutedomain_ProjectCoPiDetails_rowsObj;
var Externalinstitutedomain_repoObj_status_ProjectCoPiDetails = Externalinstitutedomain_repoObj.Execute(DomainOperationTypes.CreateOrUpdate,ref ProjectCoPiDetailsExternalinstitutedomaintableObj);if(!Externalinstitutedomain_repoObj_status_ProjectCoPiDetails) throw new Exception("Error in Execute Domain Data Map");}
base.WriteDebugInfo(@"Exiting DomainDataMap for Externalinstitute domain");
base.WriteDebugInfo(@"Entering DomainDataMap for NDocumentgrid");
var NDocumentgrid_repoObj = new RepositoryMapper(DbTypes.SQLServer);


var ProjectDocumentUploadNDocumentgridtableObj = new RepositoryTable("ProjectDocumentUpload");
  ProjectDocumentUploadNDocumentgridtableObj.AppConnectionSettingsId  ="40BDEB14-07CC-4150-8A52-9B088A428E2D";ProjectDocumentUploadNDocumentgridtableObj.ProofConnectionId = "C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0)";
var NDocumentgrid_ProjectDocumentUpload_rows = GetElementClientData(ISpace["InstanceId"].Value,"7CD25981-D914-448A-873A-2820C07FB607");

if(NDocumentgrid_ProjectDocumentUpload_rows!=null && NDocumentgrid_ProjectDocumentUpload_rows.Count>0){
var NDocumentgrid_ProjectDocumentUpload_rowsObj = new List<RepositoryRow>();
foreach(var rows in NDocumentgrid_ProjectDocumentUpload_rows){RepositoryRow repositoryRowObj = null;string elementData = null;RepositoryColumn repositoryColumnObj = null;if(rows !=null){ var ProjectDocumentUpload_colObj = new List<RepositoryColumn>();repositoryRowObj= new RepositoryRow();//var myByte = (byte)rowData.Value.RwSt;//repositoryRowObj.RowState=(RepositoryRowState)myByte;

if(rows.ContainsKey("49074D93-7C7F-401F-AD44-0BB2B5353FE3"))     elementData = rows["49074D93-7C7F-401F-AD44-0BB2B5353FE3"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ProjectDetailsID",false,false,9);
if(repositoryColumnObj!=null)ProjectDocumentUpload_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-ID1 not found");}

elementData = ISpace["gv_UserId"].Value != null? Convert.ToString(ISpace["gv_UserId"].Value):null ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"UpdatedBy",false,false,6);
if(repositoryColumnObj!=null)ProjectDocumentUpload_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-gv_UserId not found");}

if(rows.ContainsKey("8C599223-59DD-4DBF-827E-BA928EF6B588"))     elementData = rows["8C599223-59DD-4DBF-827E-BA928EF6B588"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"DocumentID",false,false,6);
if(repositoryColumnObj!=null)ProjectDocumentUpload_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-UploadDocument not found");}

elementData = CurrentDate().ToString() ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"UpdatedOn",false,false,8);
if(repositoryColumnObj!=null)ProjectDocumentUpload_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-CurrentDate not found");}

if(rows.ContainsKey("515EE642-6D69-4023-8C9E-6E212948B183"))     elementData = rows["515EE642-6D69-4023-8C9E-6E212948B183"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"DocUploadID",true,true,6);
if(repositoryColumnObj!=null)ProjectDocumentUpload_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Docid not found");}

if(rows.ContainsKey("35C9A0CA-D47F-4947-8940-8391930E3E53"))     elementData = rows["35C9A0CA-D47F-4947-8940-8391930E3E53"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"DocumentName",false,false,9);
if(repositoryColumnObj!=null)ProjectDocumentUpload_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Document not found");}
repositoryRowObj.Columns=ProjectDocumentUpload_colObj;
NDocumentgrid_ProjectDocumentUpload_rowsObj.Add(repositoryRowObj);
}}

ProjectDocumentUploadNDocumentgridtableObj.Rows=NDocumentgrid_ProjectDocumentUpload_rowsObj;
var NDocumentgrid_repoObj_status_ProjectDocumentUpload = NDocumentgrid_repoObj.Execute(DomainOperationTypes.CreateOrUpdate,ref ProjectDocumentUploadNDocumentgridtableObj);if(!NDocumentgrid_repoObj_status_ProjectDocumentUpload) throw new Exception("Error in Execute Domain Data Map");}
base.WriteDebugInfo(@"Exiting DomainDataMap for NDocumentgrid");
base.WriteDebugInfo(@"Entering DomainDataMap for Manpower Domain");
var ManpowerDomain_repoObj = new RepositoryMapper(DbTypes.SQLServer);


var ProjectManpowerDetailsManpowerDomaintableObj = new RepositoryTable("ProjectManpowerDetails");
  ProjectManpowerDetailsManpowerDomaintableObj.AppConnectionSettingsId  ="40BDEB14-07CC-4150-8A52-9B088A428E2D";ProjectManpowerDetailsManpowerDomaintableObj.ProofConnectionId = "C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0)";
var ManpowerDomain_ProjectManpowerDetails_rows = GetElementClientData(ISpace["InstanceId"].Value,"70051D3C-20CA-47D4-9917-B33DED7ACE9C");

if(ManpowerDomain_ProjectManpowerDetails_rows!=null && ManpowerDomain_ProjectManpowerDetails_rows.Count>0){
var ManpowerDomain_ProjectManpowerDetails_rowsObj = new List<RepositoryRow>();
foreach(var rows in ManpowerDomain_ProjectManpowerDetails_rows){RepositoryRow repositoryRowObj = null;string elementData = null;RepositoryColumn repositoryColumnObj = null;if(rows !=null){ var ProjectManpowerDetails_colObj = new List<RepositoryColumn>();repositoryRowObj= new RepositoryRow();//var myByte = (byte)rowData.Value.RwSt;//repositoryRowObj.RowState=(RepositoryRowState)myByte;

if(rows.ContainsKey("DC694302-6C03-4BB9-AD97-5EB11B4B9F95"))     elementData = rows["DC694302-6C03-4BB9-AD97-5EB11B4B9F95"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"No_OfManpowerPosition",false,false,5);
if(repositoryColumnObj!=null)ProjectManpowerDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MP_No not found");}

if(rows.ContainsKey("51D12800-D076-46D0-9373-62F2E5F34B86"))     elementData = rows["51D12800-D076-46D0-9373-62F2E5F34B86"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"RatePerMonth",false,false,3);
if(repositoryColumnObj!=null)ProjectManpowerDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MP_RatePerMonth not found");}

if(rows.ContainsKey("6805A522-7700-44B1-B216-C6FEE753013D"))     elementData = rows["6805A522-7700-44B1-B216-C6FEE753013D"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"TotalPerMonth",false,false,3);
if(repositoryColumnObj!=null)ProjectManpowerDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MP_TotalPerMonth not found");}

if(rows.ContainsKey("49074D93-7C7F-401F-AD44-0BB2B5353FE3"))     elementData = rows["49074D93-7C7F-401F-AD44-0BB2B5353FE3"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ProjectDetailsID",false,false,9);
if(repositoryColumnObj!=null)ProjectManpowerDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-ID1 not found");}

if(rows.ContainsKey("AC9BEF40-6E90-426D-9672-DD6A67F48C4D"))     elementData = rows["AC9BEF40-6E90-426D-9672-DD6A67F48C4D"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"TotalCost",false,false,3);
if(repositoryColumnObj!=null)ProjectManpowerDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MP_ManpowerTotalCost not found");}

if(rows.ContainsKey("3C6D7555-3F10-4B8F-B6C8-E16675D64C3A"))     elementData = rows["3C6D7555-3F10-4B8F-B6C8-E16675D64C3A"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"HRAPercentage",false,false,5);
if(repositoryColumnObj!=null)ProjectManpowerDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MP_HRAPer not found");}

if(rows.ContainsKey("4F277737-4419-4945-9E38-3B0C9CF00060"))     elementData = rows["4F277737-4419-4945-9E38-3B0C9CF00060"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"HRAPerMonth",false,false,3);
if(repositoryColumnObj!=null)ProjectManpowerDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MP_HRAperMonth not found");}

if(rows.ContainsKey("93C80FCC-F63A-43BB-A82E-9CC51988F8E3"))     elementData = rows["93C80FCC-F63A-43BB-A82E-9CC51988F8E3"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"SerialNo",false,false,5);
if(repositoryColumnObj!=null)ProjectManpowerDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MP_SerialNo not found");}

elementData = CurrentDate().ToString() ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"UpdatedOn",false,false,8);
if(repositoryColumnObj!=null)ProjectManpowerDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-CurrentDate not found");}

if(rows.ContainsKey("92D90C71-0FD3-4E4E-BCB7-FB3889E74B4E"))     elementData = rows["92D90C71-0FD3-4E4E-BCB7-FB3889E74B4E"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ManpowerPosition",false,false,9);
if(repositoryColumnObj!=null)ProjectManpowerDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MP_Position not found");}

if(rows.ContainsKey("0C36F587-12D4-4CFF-9A91-CE8BB9D6EB2B"))     elementData = rows["0C36F587-12D4-4CFF-9A91-CE8BB9D6EB2B"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"TotalMonths",false,false,5);
if(repositoryColumnObj!=null)ProjectManpowerDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MP_TotalMonths not found");}

if(rows.ContainsKey("98056C89-D8B0-4DF6-AB75-EA6DF31112C1"))     elementData = rows["98056C89-D8B0-4DF6-AB75-EA6DF31112C1"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"OverallTotalCost",false,false,3);
if(repositoryColumnObj!=null)ProjectManpowerDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-ManpowerTotalCost not found");}

if(rows.ContainsKey("141209BA-A3EF-4958-AB26-A55189864744"))     elementData = rows["141209BA-A3EF-4958-AB26-A55189864744"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ManpowerDetailsID",true,false,9);
if(repositoryColumnObj!=null)ProjectManpowerDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MP_ManpowerId not found");}

elementData = ISpace["gv_UserId"].Value != null? Convert.ToString(ISpace["gv_UserId"].Value):null ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"UpdatedBy",false,false,6);
if(repositoryColumnObj!=null)ProjectManpowerDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-gv_UserId not found");}

if(rows.ContainsKey("0E809663-E0EB-40D6-BC6D-B3328B2FBA9C"))     elementData = rows["0E809663-E0EB-40D6-BC6D-B3328B2FBA9C"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Duration",false,false,5);
if(repositoryColumnObj!=null)ProjectManpowerDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MP_Duration not found");}
repositoryRowObj.Columns=ProjectManpowerDetails_colObj;
ManpowerDomain_ProjectManpowerDetails_rowsObj.Add(repositoryRowObj);
}}

ProjectManpowerDetailsManpowerDomaintableObj.Rows=ManpowerDomain_ProjectManpowerDetails_rowsObj;
var ManpowerDomain_repoObj_status_ProjectManpowerDetails = ManpowerDomain_repoObj.Execute(DomainOperationTypes.CreateOrUpdate,ref ProjectManpowerDetailsManpowerDomaintableObj);if(!ManpowerDomain_repoObj_status_ProjectManpowerDetails) throw new Exception("Error in Execute Domain Data Map");}
base.WriteDebugInfo(@"Exiting DomainDataMap for Manpower Domain");
base.WriteDebugInfo(@"Entering DomainDataMap for EquipmentDetails");
var EquipmentDetails_repoObj = new RepositoryMapper(DbTypes.SQLServer);


var ProjectEquipmentDetailsEquipmentDetailstableObj = new RepositoryTable("ProjectEquipmentDetails");
  ProjectEquipmentDetailsEquipmentDetailstableObj.AppConnectionSettingsId  ="40BDEB14-07CC-4150-8A52-9B088A428E2D";ProjectEquipmentDetailsEquipmentDetailstableObj.ProofConnectionId = "C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0)";
var EquipmentDetails_ProjectEquipmentDetails_rows = GetElementClientData(ISpace["InstanceId"].Value,"71802A68-968A-4C2C-8AFE-32BA5B817B50");

if(EquipmentDetails_ProjectEquipmentDetails_rows!=null && EquipmentDetails_ProjectEquipmentDetails_rows.Count>0){
var EquipmentDetails_ProjectEquipmentDetails_rowsObj = new List<RepositoryRow>();
foreach(var rows in EquipmentDetails_ProjectEquipmentDetails_rows){RepositoryRow repositoryRowObj = null;string elementData = null;RepositoryColumn repositoryColumnObj = null;if(rows !=null){ var ProjectEquipmentDetails_colObj = new List<RepositoryColumn>();repositoryRowObj= new RepositoryRow();//var myByte = (byte)rowData.Value.RwSt;//repositoryRowObj.RowState=(RepositoryRowState)myByte;

elementData = CurrentDate().ToString() ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"UpdatedOn",false,false,8);
if(repositoryColumnObj!=null)ProjectEquipmentDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-CurrentDate not found");}

if(rows.ContainsKey("101E90DF-A60F-429C-8E7A-86CCE1E50194"))     elementData = rows["101E90DF-A60F-429C-8E7A-86CCE1E50194"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Description",false,false,9);
if(repositoryColumnObj!=null)ProjectEquipmentDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-EQEquipmentDescription not found");}

if(rows.ContainsKey("00E2AFFD-B7A4-4BF5-879A-DB22545CD8EF"))     elementData = rows["00E2AFFD-B7A4-4BF5-879A-DB22545CD8EF"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"OverallEquipmentCost",false,false,3);
if(repositoryColumnObj!=null)ProjectEquipmentDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-EquipmentTotalCost not found");}

elementData = ISpace["gv_UserId"].Value != null? Convert.ToString(ISpace["gv_UserId"].Value):null ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"UpdatedBy",false,false,6);
if(repositoryColumnObj!=null)ProjectEquipmentDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-gv_UserId not found");}

if(rows.ContainsKey("B1C1F822-50EC-4FDA-8722-F6D291C8DA37"))     elementData = rows["B1C1F822-50EC-4FDA-8722-F6D291C8DA37"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"SerialNo",false,false,5);
if(repositoryColumnObj!=null)ProjectEquipmentDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-EQSerialNo not found");}

if(rows.ContainsKey("33F8A526-3CED-43AF-8DD2-DB0F38EE5FFB"))     elementData = rows["33F8A526-3CED-43AF-8DD2-DB0F38EE5FFB"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Quantity",false,false,5);
if(repositoryColumnObj!=null)ProjectEquipmentDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-EQEquipmentQuantity not found");}

if(rows.ContainsKey("49074D93-7C7F-401F-AD44-0BB2B5353FE3"))     elementData = rows["49074D93-7C7F-401F-AD44-0BB2B5353FE3"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ProjectDetailsID",false,false,9);
if(repositoryColumnObj!=null)ProjectEquipmentDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-ID1 not found");}

if(rows.ContainsKey("A5CD7F95-5BC7-4BFD-ACE8-B3EE819D2CFA"))     elementData = rows["A5CD7F95-5BC7-4BFD-ACE8-B3EE819D2CFA"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"EquipmentBudget",false,false,3);
if(repositoryColumnObj!=null)ProjectEquipmentDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-EquipmentBudget not found");}

if(rows.ContainsKey("9838F710-E2A2-4A04-B036-C198F0B557C2"))     elementData = rows["9838F710-E2A2-4A04-B036-C198F0B557C2"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"TotalEquipmentCost",false,false,3);
if(repositoryColumnObj!=null)ProjectEquipmentDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-EQEquipmentTotalCost not found");}

if(rows.ContainsKey("8C7E298A-0A57-435D-8FEF-5F650F859202"))     elementData = rows["8C7E298A-0A57-435D-8FEF-5F650F859202"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"EquipmentID",true,false,9);
if(repositoryColumnObj!=null)ProjectEquipmentDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-EquipmentID not found");}

if(rows.ContainsKey("573E1E50-4673-4F27-8956-182C4829C647"))     elementData = rows["573E1E50-4673-4F27-8956-182C4829C647"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"RateinINR",false,false,3);
if(repositoryColumnObj!=null)ProjectEquipmentDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-EQEquipmentRateinINR not found");}

if(rows.ContainsKey("8646ADC3-A35F-4583-9AE4-CF26DAA56759"))     elementData = rows["8646ADC3-A35F-4583-9AE4-CF26DAA56759"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"EquipmentName",false,false,9);
if(repositoryColumnObj!=null)ProjectEquipmentDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-EquipmentName not found");}
repositoryRowObj.Columns=ProjectEquipmentDetails_colObj;
EquipmentDetails_ProjectEquipmentDetails_rowsObj.Add(repositoryRowObj);
}}

ProjectEquipmentDetailsEquipmentDetailstableObj.Rows=EquipmentDetails_ProjectEquipmentDetails_rowsObj;
var EquipmentDetails_repoObj_status_ProjectEquipmentDetails = EquipmentDetails_repoObj.Execute(DomainOperationTypes.CreateOrUpdate,ref ProjectEquipmentDetailsEquipmentDetailstableObj);if(!EquipmentDetails_repoObj_status_ProjectEquipmentDetails) throw new Exception("Error in Execute Domain Data Map");}
base.WriteDebugInfo(@"Exiting DomainDataMap for EquipmentDetails");
}
if(ISpace["ActiveEdit"].Value==0)
{
base.WriteDebugInfo(@"if(ISpace[""ActiveEdit""].Value==0)");
base.WriteDebugInfo(@"EXEC SetProjectCreationDetails '#ID1','@@gv_UserId','#setflowdummyremarks'");

var querySource1E299FD228324078A7C0CAD053381515 =GetQueryExpressionDataSource("1E299FD2-2832-4078-A7C0-CAD053381515");
Dictionary<short,object> result1E299FD228324078A7C0CAD053381515=iSpace.ExecuteQuery(querySource1E299FD228324078A7C0CAD053381515,@"EXEC SetProjectCreationDetails'" + ISpace["ID1"].Value + @"','" + ISpace["gv_userid"].Value + @"','" + ISpace["setflowdummyremarks"].Value + @"'",false);

base.WriteDebugInfo(@"var querySource1E299FD228324078A7C0CAD053381515 =GetQueryExpressionDataSource(""1E299FD2-2832-4078-A7C0-CAD053381515"");Dictionary<short,object> result1E299FD228324078A7C0CAD053381515=iSpace.ExecuteQuery(querySource1E299FD228324078A7C0CAD053381515,@""EXEC SetProjectCreationDetails'"" + ISpace[""ID1""].Value + @""','"" + ISpace[""gv_userid""].Value + @""','"" + ISpace[""setflowdummyremarks""].Value + @""'"",false);");
base.WriteDebugInfo(@"");

if((result1E299FD228324078A7C0CAD053381515!=null) && (result1E299FD228324078A7C0CAD053381515.Count!=0))
{
if(result1E299FD228324078A7C0CAD053381515.ContainsKey(0))
ISpace["Subject"].Value = result1E299FD228324078A7C0CAD053381515[0];
}
else{
ISpace["Subject"].Value = null;
}
}
if(1==2)
{
base.WriteDebugInfo(@"if(1==2)");
base.WriteDebugInfo(@"EXEC [SetProjectFlow] '#TempInstanceID',@@gv_UserId,'Updated Successfully'");

var querySource5AA6086D7B8E418ABF6AED65C96EC67F =GetQueryExpressionDataSource("5AA6086D-7B8E-418A-BF6A-ED65C96EC67F");
Dictionary<short,object> result5AA6086D7B8E418ABF6AED65C96EC67F=iSpace.ExecuteQuery(querySource5AA6086D7B8E418ABF6AED65C96EC67F,@"EXEC [SetProjectFlow] '" + ISpace["TempInstanceID"].Value + @"'," + ISpace["gv_userid"].Value + @",'Updated Successfully'",false);

base.WriteDebugInfo(@"var querySource5AA6086D7B8E418ABF6AED65C96EC67F =GetQueryExpressionDataSource(""5AA6086D-7B8E-418A-BF6A-ED65C96EC67F"");Dictionary<short,object> result5AA6086D7B8E418ABF6AED65C96EC67F=iSpace.ExecuteQuery(querySource5AA6086D7B8E418ABF6AED65C96EC67F,@""EXEC [SetProjectFlow] '"" + ISpace[""TempInstanceID""].Value + @""',"" + ISpace[""gv_userid""].Value + @"",'Updated Successfully'"",false);");
base.WriteDebugInfo(@"");

if((result5AA6086D7B8E418ABF6AED65C96EC67F!=null) && (result5AA6086D7B8E418ABF6AED65C96EC67F.Count!=0))
{
if(result5AA6086D7B8E418ABF6AED65C96EC67F.ContainsKey(0))
ISpace["Subject"].Value = result5AA6086D7B8E418ABF6AED65C96EC67F[0];
}
else{
ISpace["Subject"].Value = null;
}
}

ISpace["RedirectUrl"].RedirectType="R";
ISpace["RedirectUrl"].Value="?PkActMId=80BA7272-EBDB-40E4-8780-BBCFE9F7BF42&frmElementId=EC0A9909-7B20-47F6-BC2E-A127EFE2DF19&PkPrMId=2FC376A8-EF63-4E6A-BADA-9EC15ECC14A1&formVersionId=BF48F261-7346-4E90-B167-CAF0E476DD36&Ver=0.0000";
base.WriteDebugInfo(@"
ISpace[""RedirectUrl""].RedirectType=""R"";
ISpace[""RedirectUrl""].Value=""?PkActMId=80BA7272-EBDB-40E4-8780-BBCFE9F7BF42&frmElementId=EC0A9909-7B20-47F6-BC2E-A127EFE2DF19&PkPrMId=2FC376A8-EF63-4E6A-BADA-9EC15ECC14A1&formVersionId=BF48F261-7346-4E90-B167-CAF0E476DD36&Ver=0.0000"";");
if(ISpace["ActiveEdit"].Value==1)
{
base.WriteDebugInfo(@"if(ISpace[""ActiveEdit""].Value==1)");
base.WriteDebugInfo(@"Entering DomainDataMap for TempCreatemainDomain");
var TempCreatemainDomain_repoObj = new RepositoryMapper(DbTypes.SQLServer);


var TempCreateProjectDetailsTempCreatemainDomaintableObj = new RepositoryTable("TempCreateProjectDetails");
  TempCreateProjectDetailsTempCreatemainDomaintableObj.AppConnectionSettingsId  ="CA34B07F-5D19-412F-A39F-3ADA64B5E0C0";TempCreateProjectDetailsTempCreatemainDomaintableObj.ProofConnectionId = "C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0)";
var TempCreatemainDomain_TempCreateProjectDetails_rows = GetElementClientData(ISpace["InstanceId"].Value,"A83D8B17-78DB-4B11-86C7-91E3F9A7C20E");

if(TempCreatemainDomain_TempCreateProjectDetails_rows!=null && TempCreatemainDomain_TempCreateProjectDetails_rows.Count>0){
var TempCreatemainDomain_TempCreateProjectDetails_rowsObj = new List<RepositoryRow>();
foreach(var rows in TempCreatemainDomain_TempCreateProjectDetails_rows){RepositoryRow repositoryRowObj = null;string elementData = null;RepositoryColumn repositoryColumnObj = null;if(rows !=null){ var TempCreateProjectDetails_colObj = new List<RepositoryColumn>();repositoryRowObj= new RepositoryRow();//var myByte = (byte)rowData.Value.RwSt;//repositoryRowObj.RowState=(RepositoryRowState)myByte;

if(rows.ContainsKey("153737E5-6626-4A69-8501-4AAD946A634A"))     elementData = rows["153737E5-6626-4A69-8501-4AAD946A634A"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"BudgetTotalAmount",false,false,3);
if(repositoryColumnObj!=null)TempCreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-OverallBudgetTotal not found");}

if(rows.ContainsKey("0A6B19A9-6384-4BF3-A9CB-C1A0C675262E"))     elementData = rows["0A6B19A9-6384-4BF3-A9CB-C1A0C675262E"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"SanctionedNumber",false,false,9);
if(repositoryColumnObj!=null)TempCreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-SanctionNumber not found");}

if(rows.ContainsKey("A417D0C0-3A5C-48E6-8692-DF7FC6E78987"))     elementData = rows["A417D0C0-3A5C-48E6-8692-DF7FC6E78987"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ProjectCategoryID",false,false,9);
if(repositoryColumnObj!=null)TempCreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-ProjectCategory not found");}

if(rows.ContainsKey("604D4AFD-8CB5-47F6-AAF4-CBED4D7E845D"))     elementData = rows["604D4AFD-8CB5-47F6-AAF4-CBED4D7E845D"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"FundingAgency",false,false,9);
if(repositoryColumnObj!=null)TempCreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-FundingAcencyName not found");}

if(rows.ContainsKey("7BD98942-3580-45F3-9030-7226534C37E1"))     elementData = rows["7BD98942-3580-45F3-9030-7226534C37E1"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Designation",false,false,9);
if(repositoryColumnObj!=null)TempCreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Designation not found");}

if(rows.ContainsKey("3F3D8917-5954-4C1D-AE68-83C060BB2F32"))     elementData = rows["3F3D8917-5954-4C1D-AE68-83C060BB2F32"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"IfEquipment",false,false,0);
if(repositoryColumnObj!=null)TempCreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-IFEquipment not found");}

if(rows.ContainsKey("6D31749B-2D20-4B17-9A41-596770A56EB3"))     elementData = rows["6D31749B-2D20-4B17-9A41-596770A56EB3"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"DocumentComments",false,false,9);
if(repositoryColumnObj!=null)TempCreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-DocumentComments not found");}

if(rows.ContainsKey("2833427C-A5F6-43D0-9A15-E33760BA7E46"))     elementData = rows["2833427C-A5F6-43D0-9A15-E33760BA7E46"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"TempInstanceid",true,false,9);
if(repositoryColumnObj!=null)TempCreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-TempInstanceID not found");}

if(rows.ContainsKey("E34D4CE7-E649-41FB-9D89-64C11CA65EF3"))     elementData = rows["E34D4CE7-E649-41FB-9D89-64C11CA65EF3"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ProjectCode",false,false,9);
if(repositoryColumnObj!=null)TempCreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-ProjectCode not found");}

if(rows.ContainsKey("40BFB2D7-C4A2-4DB5-8080-2DF9DD44B713"))     elementData = rows["40BFB2D7-C4A2-4DB5-8080-2DF9DD44B713"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"PrincipalInvestigator",false,false,9);
if(repositoryColumnObj!=null)TempCreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-PrincipleInvestigator not found");}

if(rows.ContainsKey("6D38109B-0A12-40CA-8D51-C0313B482B1F"))     elementData = rows["6D38109B-0A12-40CA-8D51-C0313B482B1F"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ProjectDetailsID",false,true,6);
if(repositoryColumnObj!=null)TempCreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-ProjectDetailsID not found");}

if(rows.ContainsKey("7E6249C4-87FC-4119-93B4-404EB37B5D90"))     elementData = rows["7E6249C4-87FC-4119-93B4-404EB37B5D90"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"DepartmentID",false,false,9);
if(repositoryColumnObj!=null)TempCreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-EmpDepartment not found");}

if(rows.ContainsKey("02A5B4F7-1A0C-4581-81E9-AE79F5083293"))     elementData = rows["02A5B4F7-1A0C-4581-81E9-AE79F5083293"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Overhead",false,false,5);
if(repositoryColumnObj!=null)TempCreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Overheads not found");}

if(rows.ContainsKey("DF847FA7-3DC4-4124-A2E2-46A7B91F0776"))     elementData = rows["DF847FA7-3DC4-4124-A2E2-46A7B91F0776"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"SanctionedDate",false,false,8);
if(repositoryColumnObj!=null)TempCreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-SanctionDate not found");}

if(rows.ContainsKey("F63FA021-DA22-44C2-A63A-11A0E2BED913"))     elementData = rows["F63FA021-DA22-44C2-A63A-11A0E2BED913"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"FinancialYearID",false,false,9);
if(repositoryColumnObj!=null)TempCreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-FinancialYear not found");}

if(rows.ContainsKey("603DB6A8-112F-4544-A47D-43751477076A"))     elementData = rows["603DB6A8-112F-4544-A47D-43751477076A"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"IsSubmitted",false,false,5);
if(repositoryColumnObj!=null)TempCreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-IsSubmit not found");}

if(rows.ContainsKey("49074D93-7C7F-401F-AD44-0BB2B5353FE3"))     elementData = rows["49074D93-7C7F-401F-AD44-0BB2B5353FE3"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"InstanceId",false,false,9);
if(repositoryColumnObj!=null)TempCreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-ID1 not found");}

if(rows.ContainsKey("E6D44C17-A165-46AE-80FD-96EBC9629057"))     elementData = rows["E6D44C17-A165-46AE-80FD-96EBC9629057"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"IsExternalIns",false,false,0);
if(repositoryColumnObj!=null)TempCreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-IfExternalIns not found");}

if(rows.ContainsKey("92864610-6CBD-4533-BB18-A07F02B8C329"))     elementData = rows["92864610-6CBD-4533-BB18-A07F02B8C329"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"FromDate",false,false,8);
if(repositoryColumnObj!=null)TempCreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-StartDate not found");}

if(rows.ContainsKey("7E613FAC-8E27-4D91-99B7-3848167B6B99"))     elementData = rows["7E613FAC-8E27-4D91-99B7-3848167B6B99"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"FundReceiptMode",false,false,9);
if(repositoryColumnObj!=null)TempCreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-FundReceiptMode not found");}

if(rows.ContainsKey("A0211921-0B97-43E9-BA6F-BC50F482EA7E"))     elementData = rows["A0211921-0B97-43E9-BA6F-BC50F482EA7E"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Sector",false,false,9);
if(repositoryColumnObj!=null)TempCreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Sector not found");}

if(rows.ContainsKey("CBBFAC58-1A83-448A-8F84-B58A0C1C7F6A"))     elementData = rows["CBBFAC58-1A83-448A-8F84-B58A0C1C7F6A"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"YearMonth",false,false,9);
if(repositoryColumnObj!=null)TempCreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MonthYear not found");}

if(rows.ContainsKey("9FBC7606-B59A-4DF4-B8F4-DC997BA82B1E"))     elementData = rows["9FBC7606-B59A-4DF4-B8F4-DC997BA82B1E"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ProjectBudget",false,false,3);
if(repositoryColumnObj!=null)TempCreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-ProjectBudget not found");}

if(rows.ContainsKey("BE1036BA-08CB-4EAC-BEF2-ECADE4084677"))     elementData = rows["BE1036BA-08CB-4EAC-BEF2-ECADE4084677"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Duration",false,false,9);
if(repositoryColumnObj!=null)TempCreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Duration not found");}

elementData = ISpace["gv_UserId"].Value != null? Convert.ToString(ISpace["gv_UserId"].Value):null ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"UpdatedBy",false,false,6);
if(repositoryColumnObj!=null)TempCreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-gv_UserId not found");}

elementData = CurrentDate().ToString() ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"UpdatedOn",false,false,8);
if(repositoryColumnObj!=null)TempCreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-CurrentDate not found");}

if(rows.ContainsKey("2D32F409-3FDD-44BB-BBA2-5862F0432078"))     elementData = rows["2D32F409-3FDD-44BB-BBA2-5862F0432078"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ProjectType",false,false,9);
if(repositoryColumnObj!=null)TempCreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-TypeOfProject not found");}

if(rows.ContainsKey("B596DD9F-8B75-44EB-BB37-C2D6093E21E7"))     elementData = rows["B596DD9F-8B75-44EB-BB37-C2D6093E21E7"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"EmployeeBasicInfoId",false,false,9);
if(repositoryColumnObj!=null)TempCreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-EmpEmployeeBasicId not found");}

if(rows.ContainsKey("3D79FD45-F4C9-4111-9D02-BA7B50CE754E"))     elementData = rows["3D79FD45-F4C9-4111-9D02-BA7B50CE754E"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ProjectproposalID",false,false,9);
if(repositoryColumnObj!=null)TempCreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-ProjectProposal not found");}

if(rows.ContainsKey("CC0BFF91-E6F2-488C-85F2-E16AE98B8BAC"))     elementData = rows["CC0BFF91-E6F2-488C-85F2-E16AE98B8BAC"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"SchemeID",false,false,9);
if(repositoryColumnObj!=null)TempCreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-SchemeType not found");}

if(rows.ContainsKey("BC6C053E-0BA2-4200-A0C5-C0EF25B21E2E"))     elementData = rows["BC6C053E-0BA2-4200-A0C5-C0EF25B21E2E"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"RecurringAmount",false,false,3);
if(repositoryColumnObj!=null)TempCreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-RecurringAmount not found");}

if(rows.ContainsKey("97AE1937-023A-4A40-807F-74C57599806C"))     elementData = rows["97AE1937-023A-4A40-807F-74C57599806C"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"NonRecurringAmount",false,false,3);
if(repositoryColumnObj!=null)TempCreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-NonRecurringAmount not found");}

if(rows.ContainsKey("CA004F50-713B-4AC6-A2AE-DBA4ECDBC578"))     elementData = rows["CA004F50-713B-4AC6-A2AE-DBA4ECDBC578"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ProjectName",false,false,9);
if(repositoryColumnObj!=null)TempCreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-ProjectName not found");}

if(rows.ContainsKey("0C386A8C-8A37-4559-8464-99855AE81313"))     elementData = rows["0C386A8C-8A37-4559-8464-99855AE81313"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ProjectRefNo",false,false,9);
if(repositoryColumnObj!=null)TempCreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-ProjectRefNo not found");}

if(rows.ContainsKey("B705855C-3908-41FF-998E-EA6B24909F0F"))     elementData = rows["B705855C-3908-41FF-998E-EA6B24909F0F"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"IfManpower",false,false,0);
if(repositoryColumnObj!=null)TempCreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-ManPowerRequired not found");}

if(rows.ContainsKey("1CA31193-A9A8-476E-A3FF-F75133B5BDEC"))     elementData = rows["1CA31193-A9A8-476E-A3FF-F75133B5BDEC"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ToDate",false,false,8);
if(repositoryColumnObj!=null)TempCreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-EndDate not found");}

if(rows.ContainsKey("E18A3F8F-76E5-42F2-ABFD-44826B509A29"))     elementData = rows["E18A3F8F-76E5-42F2-ABFD-44826B509A29"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ProjectStatus",false,false,9);
if(repositoryColumnObj!=null)TempCreateProjectDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-ProjectStatus not found");}
repositoryRowObj.Columns=TempCreateProjectDetails_colObj;
TempCreatemainDomain_TempCreateProjectDetails_rowsObj.Add(repositoryRowObj);
}}

TempCreateProjectDetailsTempCreatemainDomaintableObj.Rows=TempCreatemainDomain_TempCreateProjectDetails_rowsObj;
var TempCreatemainDomain_repoObj_status_TempCreateProjectDetails = TempCreatemainDomain_repoObj.Execute(DomainOperationTypes.CreateOrUpdate,ref TempCreateProjectDetailsTempCreatemainDomaintableObj);if(!TempCreatemainDomain_repoObj_status_TempCreateProjectDetails) throw new Exception("Error in Execute Domain Data Map");}
base.WriteDebugInfo(@"Exiting DomainDataMap for TempCreatemainDomain");
base.WriteDebugInfo(@"Entering DomainDataMap for TempBudgetDetails");
var TempBudgetDetails_repoObj = new RepositoryMapper(DbTypes.SQLServer);


var TempProjectbudgetdetailsTempBudgetDetailstableObj = new RepositoryTable("TempProjectbudgetdetails");
  TempProjectbudgetdetailsTempBudgetDetailstableObj.AppConnectionSettingsId  ="CA34B07F-5D19-412F-A39F-3ADA64B5E0C0";TempProjectbudgetdetailsTempBudgetDetailstableObj.ProofConnectionId = "C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0)";
var TempBudgetDetails_TempProjectbudgetdetails_rows = GetElementClientData(ISpace["InstanceId"].Value,"C92F6C5D-F7CB-4E81-835C-3D655C7FCC52");

if(TempBudgetDetails_TempProjectbudgetdetails_rows!=null && TempBudgetDetails_TempProjectbudgetdetails_rows.Count>0){
var TempBudgetDetails_TempProjectbudgetdetails_rowsObj = new List<RepositoryRow>();
foreach(var rows in TempBudgetDetails_TempProjectbudgetdetails_rows){RepositoryRow repositoryRowObj = null;string elementData = null;RepositoryColumn repositoryColumnObj = null;if(rows !=null){ var TempProjectbudgetdetails_colObj = new List<RepositoryColumn>();repositoryRowObj= new RepositoryRow();//var myByte = (byte)rowData.Value.RwSt;//repositoryRowObj.RowState=(RepositoryRowState)myByte;

if(rows.ContainsKey("B6B3B0F1-D9E6-442C-AD71-494FF4470030"))     elementData = rows["B6B3B0F1-D9E6-442C-AD71-494FF4470030"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Year3",false,false,5);
if(repositoryColumnObj!=null)TempProjectbudgetdetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Year13 not found");}

if(rows.ContainsKey("303EE107-01E7-49DF-94E6-F6461AC4CB48"))     elementData = rows["303EE107-01E7-49DF-94E6-F6461AC4CB48"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"BudgetDetailID",true,false,9);
if(repositoryColumnObj!=null)TempProjectbudgetdetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-ProjectBudgetDetailsid not found");}

if(rows.ContainsKey("FD08EF20-802B-4672-8747-6D54C2D6D31E"))     elementData = rows["FD08EF20-802B-4672-8747-6D54C2D6D31E"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Year2",false,false,5);
if(repositoryColumnObj!=null)TempProjectbudgetdetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Year12 not found");}

if(rows.ContainsKey("6EC8DDAB-B1F1-4D8C-9598-77E3827539D5"))     elementData = rows["6EC8DDAB-B1F1-4D8C-9598-77E3827539D5"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Year6",false,false,5);
if(repositoryColumnObj!=null)TempProjectbudgetdetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Year16 not found");}

if(rows.ContainsKey("F7FB513A-721E-4E82-89DD-F03DF3E8AB16"))     elementData = rows["F7FB513A-721E-4E82-89DD-F03DF3E8AB16"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"BudgetID",false,false,5);
if(repositoryColumnObj!=null)TempProjectbudgetdetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Bid not found");}

if(rows.ContainsKey("A38311B1-68C6-462E-9DB6-FD90ABFF6E44"))     elementData = rows["A38311B1-68C6-462E-9DB6-FD90ABFF6E44"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"BudgetAmount",false,false,3);
if(repositoryColumnObj!=null)TempProjectbudgetdetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-BudgetAmount not found");}

if(rows.ContainsKey("E0DCC460-53C1-4953-90C3-C97266369DD1"))     elementData = rows["E0DCC460-53C1-4953-90C3-C97266369DD1"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Year11",false,false,5);
if(repositoryColumnObj!=null)TempProjectbudgetdetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Year21 not found");}

if(rows.ContainsKey("6B169537-9858-4E64-9587-5454EDE7F799"))     elementData = rows["6B169537-9858-4E64-9587-5454EDE7F799"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Year4",false,false,5);
if(repositoryColumnObj!=null)TempProjectbudgetdetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Year14 not found");}

if(rows.ContainsKey("153737E5-6626-4A69-8501-4AAD946A634A"))     elementData = rows["153737E5-6626-4A69-8501-4AAD946A634A"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"OverallAmount",false,false,3);
if(repositoryColumnObj!=null)TempProjectbudgetdetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-OverallBudgetTotal not found");}

if(rows.ContainsKey("19DEC91D-3072-486C-947C-F5C3A8756745"))     elementData = rows["19DEC91D-3072-486C-947C-F5C3A8756745"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"RDOfficeComments",false,false,9);
if(repositoryColumnObj!=null)TempProjectbudgetdetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-RDComments not found");}

if(rows.ContainsKey("85E319F5-14C8-44FA-9C41-0E3303FDCE8F"))     elementData = rows["85E319F5-14C8-44FA-9C41-0E3303FDCE8F"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Year12",false,false,5);
if(repositoryColumnObj!=null)TempProjectbudgetdetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Year22 not found");}

if(rows.ContainsKey("67FD82A6-A670-4DD2-8574-AAD959805F77"))     elementData = rows["67FD82A6-A670-4DD2-8574-AAD959805F77"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Year7",false,false,5);
if(repositoryColumnObj!=null)TempProjectbudgetdetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Year17 not found");}

if(rows.ContainsKey("2E19ABDB-10E6-4785-8244-7863EA4FBCBC"))     elementData = rows["2E19ABDB-10E6-4785-8244-7863EA4FBCBC"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Year5",false,false,5);
if(repositoryColumnObj!=null)TempProjectbudgetdetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Year15 not found");}

elementData = ISpace["gv_UserId"].Value != null? Convert.ToString(ISpace["gv_UserId"].Value):null ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"UpdatedBy",false,false,6);
if(repositoryColumnObj!=null)TempProjectbudgetdetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-gv_UserId not found");}

if(rows.ContainsKey("2833427C-A5F6-43D0-9A15-E33760BA7E46"))     elementData = rows["2833427C-A5F6-43D0-9A15-E33760BA7E46"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"TempInstanceid",false,false,9);
if(repositoryColumnObj!=null)TempProjectbudgetdetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-TempInstanceID not found");}

if(rows.ContainsKey("DDAC7A4B-1F58-4403-A731-A41BFE920BBB"))     elementData = rows["DDAC7A4B-1F58-4403-A731-A41BFE920BBB"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Year1",false,false,3);
if(repositoryColumnObj!=null)TempProjectbudgetdetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Year11 not found");}

if(rows.ContainsKey("F85850E3-22D8-43A9-A14F-2D5283720AB0"))     elementData = rows["F85850E3-22D8-43A9-A14F-2D5283720AB0"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Comments",false,false,9);
if(repositoryColumnObj!=null)TempProjectbudgetdetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-commentss not found");}

if(rows.ContainsKey("B134B486-06FC-487E-BEA2-AE6F137D586C"))     elementData = rows["B134B486-06FC-487E-BEA2-AE6F137D586C"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Year8",false,false,5);
if(repositoryColumnObj!=null)TempProjectbudgetdetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Year18 not found");}

elementData = CurrentDate().ToString() ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"UpdatedOn",false,false,8);
if(repositoryColumnObj!=null)TempProjectbudgetdetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-CurrentDate not found");}

if(rows.ContainsKey("B5948E98-0ABA-493A-A2DB-DF169BE81734"))     elementData = rows["B5948E98-0ABA-493A-A2DB-DF169BE81734"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Year9",false,false,5);
if(repositoryColumnObj!=null)TempProjectbudgetdetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Year19 not found");}

if(rows.ContainsKey("49074D93-7C7F-401F-AD44-0BB2B5353FE3"))     elementData = rows["49074D93-7C7F-401F-AD44-0BB2B5353FE3"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ProjectDetailsID",false,false,9);
if(repositoryColumnObj!=null)TempProjectbudgetdetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-ID1 not found");}

if(rows.ContainsKey("7A91BE20-EB4E-4223-9FE5-5BE3A531F3FC"))     elementData = rows["7A91BE20-EB4E-4223-9FE5-5BE3A531F3FC"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Year10",false,false,5);
if(repositoryColumnObj!=null)TempProjectbudgetdetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Year20 not found");}
repositoryRowObj.Columns=TempProjectbudgetdetails_colObj;
TempBudgetDetails_TempProjectbudgetdetails_rowsObj.Add(repositoryRowObj);
}}

TempProjectbudgetdetailsTempBudgetDetailstableObj.Rows=TempBudgetDetails_TempProjectbudgetdetails_rowsObj;
var TempBudgetDetails_repoObj_status_TempProjectbudgetdetails = TempBudgetDetails_repoObj.Execute(DomainOperationTypes.CreateOrUpdate,ref TempProjectbudgetdetailsTempBudgetDetailstableObj);if(!TempBudgetDetails_repoObj_status_TempProjectbudgetdetails) throw new Exception("Error in Execute Domain Data Map");}
base.WriteDebugInfo(@"Exiting DomainDataMap for TempBudgetDetails");
base.WriteDebugInfo(@"Entering DomainDataMap for TempEquipmentDetails");
var TempEquipmentDetails_repoObj = new RepositoryMapper(DbTypes.SQLServer);


var TempProjectEquipmentDetailsTempEquipmentDetailstableObj = new RepositoryTable("TempProjectEquipmentDetails");
  TempProjectEquipmentDetailsTempEquipmentDetailstableObj.AppConnectionSettingsId  ="CA34B07F-5D19-412F-A39F-3ADA64B5E0C0";TempProjectEquipmentDetailsTempEquipmentDetailstableObj.ProofConnectionId = "C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0)";
var TempEquipmentDetails_TempProjectEquipmentDetails_rows = GetElementClientData(ISpace["InstanceId"].Value,"71802A68-968A-4C2C-8AFE-32BA5B817B50");

if(TempEquipmentDetails_TempProjectEquipmentDetails_rows!=null && TempEquipmentDetails_TempProjectEquipmentDetails_rows.Count>0){
var TempEquipmentDetails_TempProjectEquipmentDetails_rowsObj = new List<RepositoryRow>();
foreach(var rows in TempEquipmentDetails_TempProjectEquipmentDetails_rows){RepositoryRow repositoryRowObj = null;string elementData = null;RepositoryColumn repositoryColumnObj = null;if(rows !=null){ var TempProjectEquipmentDetails_colObj = new List<RepositoryColumn>();repositoryRowObj= new RepositoryRow();//var myByte = (byte)rowData.Value.RwSt;//repositoryRowObj.RowState=(RepositoryRowState)myByte;

elementData = CurrentDate().ToString() ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"UpdatedOn",false,false,8);
if(repositoryColumnObj!=null)TempProjectEquipmentDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-CurrentDate not found");}

if(rows.ContainsKey("B1C1F822-50EC-4FDA-8722-F6D291C8DA37"))     elementData = rows["B1C1F822-50EC-4FDA-8722-F6D291C8DA37"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"SerialNo",false,false,5);
if(repositoryColumnObj!=null)TempProjectEquipmentDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-EQSerialNo not found");}

if(rows.ContainsKey("9838F710-E2A2-4A04-B036-C198F0B557C2"))     elementData = rows["9838F710-E2A2-4A04-B036-C198F0B557C2"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"TotalEquipmentCost",false,false,3);
if(repositoryColumnObj!=null)TempProjectEquipmentDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-EQEquipmentTotalCost not found");}

if(rows.ContainsKey("101E90DF-A60F-429C-8E7A-86CCE1E50194"))     elementData = rows["101E90DF-A60F-429C-8E7A-86CCE1E50194"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Description",false,false,9);
if(repositoryColumnObj!=null)TempProjectEquipmentDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-EQEquipmentDescription not found");}

if(rows.ContainsKey("8C7E298A-0A57-435D-8FEF-5F650F859202"))     elementData = rows["8C7E298A-0A57-435D-8FEF-5F650F859202"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"EquipmentID",true,false,9);
if(repositoryColumnObj!=null)TempProjectEquipmentDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-EquipmentID not found");}

if(rows.ContainsKey("2833427C-A5F6-43D0-9A15-E33760BA7E46"))     elementData = rows["2833427C-A5F6-43D0-9A15-E33760BA7E46"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"TempInstanceid",false,false,9);
if(repositoryColumnObj!=null)TempProjectEquipmentDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-TempInstanceID not found");}

elementData = ISpace["gv_UserId"].Value != null? Convert.ToString(ISpace["gv_UserId"].Value):null ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"UpdatedBy",false,false,6);
if(repositoryColumnObj!=null)TempProjectEquipmentDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-gv_UserId not found");}

if(rows.ContainsKey("33F8A526-3CED-43AF-8DD2-DB0F38EE5FFB"))     elementData = rows["33F8A526-3CED-43AF-8DD2-DB0F38EE5FFB"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Quantity",false,false,5);
if(repositoryColumnObj!=null)TempProjectEquipmentDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-EQEquipmentQuantity not found");}

if(rows.ContainsKey("8646ADC3-A35F-4583-9AE4-CF26DAA56759"))     elementData = rows["8646ADC3-A35F-4583-9AE4-CF26DAA56759"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"EquipmentName",false,false,9);
if(repositoryColumnObj!=null)TempProjectEquipmentDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-EquipmentName not found");}

if(rows.ContainsKey("A5CD7F95-5BC7-4BFD-ACE8-B3EE819D2CFA"))     elementData = rows["A5CD7F95-5BC7-4BFD-ACE8-B3EE819D2CFA"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"EquipmentBudget",false,false,3);
if(repositoryColumnObj!=null)TempProjectEquipmentDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-EquipmentBudget not found");}

if(rows.ContainsKey("49074D93-7C7F-401F-AD44-0BB2B5353FE3"))     elementData = rows["49074D93-7C7F-401F-AD44-0BB2B5353FE3"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ProjectDetailsID",false,false,9);
if(repositoryColumnObj!=null)TempProjectEquipmentDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-ID1 not found");}

if(rows.ContainsKey("00E2AFFD-B7A4-4BF5-879A-DB22545CD8EF"))     elementData = rows["00E2AFFD-B7A4-4BF5-879A-DB22545CD8EF"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"OverallEquipmentCost",false,false,3);
if(repositoryColumnObj!=null)TempProjectEquipmentDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-EquipmentTotalCost not found");}

if(rows.ContainsKey("573E1E50-4673-4F27-8956-182C4829C647"))     elementData = rows["573E1E50-4673-4F27-8956-182C4829C647"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"RateinINR",false,false,3);
if(repositoryColumnObj!=null)TempProjectEquipmentDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-EQEquipmentRateinINR not found");}
repositoryRowObj.Columns=TempProjectEquipmentDetails_colObj;
TempEquipmentDetails_TempProjectEquipmentDetails_rowsObj.Add(repositoryRowObj);
}}

TempProjectEquipmentDetailsTempEquipmentDetailstableObj.Rows=TempEquipmentDetails_TempProjectEquipmentDetails_rowsObj;
var TempEquipmentDetails_repoObj_status_TempProjectEquipmentDetails = TempEquipmentDetails_repoObj.Execute(DomainOperationTypes.CreateOrUpdate,ref TempProjectEquipmentDetailsTempEquipmentDetailstableObj);if(!TempEquipmentDetails_repoObj_status_TempProjectEquipmentDetails) throw new Exception("Error in Execute Domain Data Map");}
base.WriteDebugInfo(@"Exiting DomainDataMap for TempEquipmentDetails");
base.WriteDebugInfo(@"Entering DomainDataMap for TempManpowerDetails");
var TempManpowerDetails_repoObj = new RepositoryMapper(DbTypes.SQLServer);


var TempProjectManpowerDetailsTempManpowerDetailstableObj = new RepositoryTable("TempProjectManpowerDetails");
  TempProjectManpowerDetailsTempManpowerDetailstableObj.AppConnectionSettingsId  ="CA34B07F-5D19-412F-A39F-3ADA64B5E0C0";TempProjectManpowerDetailsTempManpowerDetailstableObj.ProofConnectionId = "C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0)";
var TempManpowerDetails_TempProjectManpowerDetails_rows = GetElementClientData(ISpace["InstanceId"].Value,"70051D3C-20CA-47D4-9917-B33DED7ACE9C");

if(TempManpowerDetails_TempProjectManpowerDetails_rows!=null && TempManpowerDetails_TempProjectManpowerDetails_rows.Count>0){
var TempManpowerDetails_TempProjectManpowerDetails_rowsObj = new List<RepositoryRow>();
foreach(var rows in TempManpowerDetails_TempProjectManpowerDetails_rows){RepositoryRow repositoryRowObj = null;string elementData = null;RepositoryColumn repositoryColumnObj = null;if(rows !=null){ var TempProjectManpowerDetails_colObj = new List<RepositoryColumn>();repositoryRowObj= new RepositoryRow();//var myByte = (byte)rowData.Value.RwSt;//repositoryRowObj.RowState=(RepositoryRowState)myByte;

if(rows.ContainsKey("98056C89-D8B0-4DF6-AB75-EA6DF31112C1"))     elementData = rows["98056C89-D8B0-4DF6-AB75-EA6DF31112C1"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"OverallTotalCost",false,false,3);
if(repositoryColumnObj!=null)TempProjectManpowerDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-ManpowerTotalCost not found");}

if(rows.ContainsKey("141209BA-A3EF-4958-AB26-A55189864744"))     elementData = rows["141209BA-A3EF-4958-AB26-A55189864744"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ManpowerDetailsID",true,false,9);
if(repositoryColumnObj!=null)TempProjectManpowerDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MP_ManpowerId not found");}

if(rows.ContainsKey("6805A522-7700-44B1-B216-C6FEE753013D"))     elementData = rows["6805A522-7700-44B1-B216-C6FEE753013D"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"TotalPerMonth",false,false,3);
if(repositoryColumnObj!=null)TempProjectManpowerDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MP_TotalPerMonth not found");}

if(rows.ContainsKey("AC9BEF40-6E90-426D-9672-DD6A67F48C4D"))     elementData = rows["AC9BEF40-6E90-426D-9672-DD6A67F48C4D"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"TotalCost",false,false,3);
if(repositoryColumnObj!=null)TempProjectManpowerDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MP_ManpowerTotalCost not found");}

if(rows.ContainsKey("49074D93-7C7F-401F-AD44-0BB2B5353FE3"))     elementData = rows["49074D93-7C7F-401F-AD44-0BB2B5353FE3"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ProjectDetailsID",false,false,9);
if(repositoryColumnObj!=null)TempProjectManpowerDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-ID1 not found");}

if(rows.ContainsKey("0C36F587-12D4-4CFF-9A91-CE8BB9D6EB2B"))     elementData = rows["0C36F587-12D4-4CFF-9A91-CE8BB9D6EB2B"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"TotalMonths",false,false,5);
if(repositoryColumnObj!=null)TempProjectManpowerDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MP_TotalMonths not found");}

if(rows.ContainsKey("3C6D7555-3F10-4B8F-B6C8-E16675D64C3A"))     elementData = rows["3C6D7555-3F10-4B8F-B6C8-E16675D64C3A"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"HRAPercentage",false,false,5);
if(repositoryColumnObj!=null)TempProjectManpowerDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MP_HRAPer not found");}

if(rows.ContainsKey("93C80FCC-F63A-43BB-A82E-9CC51988F8E3"))     elementData = rows["93C80FCC-F63A-43BB-A82E-9CC51988F8E3"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"SerialNo",false,false,5);
if(repositoryColumnObj!=null)TempProjectManpowerDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MP_SerialNo not found");}

if(rows.ContainsKey("92D90C71-0FD3-4E4E-BCB7-FB3889E74B4E"))     elementData = rows["92D90C71-0FD3-4E4E-BCB7-FB3889E74B4E"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ManpowerPosition",false,false,9);
if(repositoryColumnObj!=null)TempProjectManpowerDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MP_Position not found");}

elementData = CurrentDate().ToString() ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"UpdatedOn",false,false,8);
if(repositoryColumnObj!=null)TempProjectManpowerDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-CurrentDate not found");}

elementData = ISpace["gv_UserId"].Value != null? Convert.ToString(ISpace["gv_UserId"].Value):null ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"UpdatedBy",false,false,6);
if(repositoryColumnObj!=null)TempProjectManpowerDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-gv_UserId not found");}

if(rows.ContainsKey("51D12800-D076-46D0-9373-62F2E5F34B86"))     elementData = rows["51D12800-D076-46D0-9373-62F2E5F34B86"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"RatePerMonth",false,false,3);
if(repositoryColumnObj!=null)TempProjectManpowerDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MP_RatePerMonth not found");}

if(rows.ContainsKey("4F277737-4419-4945-9E38-3B0C9CF00060"))     elementData = rows["4F277737-4419-4945-9E38-3B0C9CF00060"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"HRAPerMonth",false,false,3);
if(repositoryColumnObj!=null)TempProjectManpowerDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MP_HRAperMonth not found");}

if(rows.ContainsKey("2833427C-A5F6-43D0-9A15-E33760BA7E46"))     elementData = rows["2833427C-A5F6-43D0-9A15-E33760BA7E46"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"TempInstanceid",false,false,9);
if(repositoryColumnObj!=null)TempProjectManpowerDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-TempInstanceID not found");}

if(rows.ContainsKey("0E809663-E0EB-40D6-BC6D-B3328B2FBA9C"))     elementData = rows["0E809663-E0EB-40D6-BC6D-B3328B2FBA9C"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"Duration",false,false,5);
if(repositoryColumnObj!=null)TempProjectManpowerDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MP_Duration not found");}

if(rows.ContainsKey("DC694302-6C03-4BB9-AD97-5EB11B4B9F95"))     elementData = rows["DC694302-6C03-4BB9-AD97-5EB11B4B9F95"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"No_OfManpowerPosition",false,false,5);
if(repositoryColumnObj!=null)TempProjectManpowerDetails_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-MP_No not found");}
repositoryRowObj.Columns=TempProjectManpowerDetails_colObj;
TempManpowerDetails_TempProjectManpowerDetails_rowsObj.Add(repositoryRowObj);
}}

TempProjectManpowerDetailsTempManpowerDetailstableObj.Rows=TempManpowerDetails_TempProjectManpowerDetails_rowsObj;
var TempManpowerDetails_repoObj_status_TempProjectManpowerDetails = TempManpowerDetails_repoObj.Execute(DomainOperationTypes.CreateOrUpdate,ref TempProjectManpowerDetailsTempManpowerDetailstableObj);if(!TempManpowerDetails_repoObj_status_TempProjectManpowerDetails) throw new Exception("Error in Execute Domain Data Map");}
base.WriteDebugInfo(@"Exiting DomainDataMap for TempManpowerDetails");
base.WriteDebugInfo(@"Entering DomainDataMap for TempDocumentUpload");
var TempDocumentUpload_repoObj = new RepositoryMapper(DbTypes.SQLServer);


var TempProjectDocumentUploadTempDocumentUploadtableObj = new RepositoryTable("TempProjectDocumentUpload");
  TempProjectDocumentUploadTempDocumentUploadtableObj.AppConnectionSettingsId  ="CA34B07F-5D19-412F-A39F-3ADA64B5E0C0";TempProjectDocumentUploadTempDocumentUploadtableObj.ProofConnectionId = "C3BEA3AF-C9B7-4DEA-AE35-EA1C626191C0)";
var TempDocumentUpload_TempProjectDocumentUpload_rows = GetElementClientData(ISpace["InstanceId"].Value,"7CD25981-D914-448A-873A-2820C07FB607");

if(TempDocumentUpload_TempProjectDocumentUpload_rows!=null && TempDocumentUpload_TempProjectDocumentUpload_rows.Count>0){
var TempDocumentUpload_TempProjectDocumentUpload_rowsObj = new List<RepositoryRow>();
foreach(var rows in TempDocumentUpload_TempProjectDocumentUpload_rows){RepositoryRow repositoryRowObj = null;string elementData = null;RepositoryColumn repositoryColumnObj = null;if(rows !=null){ var TempProjectDocumentUpload_colObj = new List<RepositoryColumn>();repositoryRowObj= new RepositoryRow();//var myByte = (byte)rowData.Value.RwSt;//repositoryRowObj.RowState=(RepositoryRowState)myByte;

if(rows.ContainsKey("8C599223-59DD-4DBF-827E-BA928EF6B588"))     elementData = rows["8C599223-59DD-4DBF-827E-BA928EF6B588"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"DocumentID",false,false,6);
if(repositoryColumnObj!=null)TempProjectDocumentUpload_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-UploadDocument not found");}

if(rows.ContainsKey("E76904DE-356E-4DBF-ABAF-A6AD46656A90"))     elementData = rows["E76904DE-356E-4DBF-ABAF-A6AD46656A90"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"DocUploadID",true,true,6);
if(repositoryColumnObj!=null)TempProjectDocumentUpload_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-TEMPDocid not found");}

if(rows.ContainsKey("49074D93-7C7F-401F-AD44-0BB2B5353FE3"))     elementData = rows["49074D93-7C7F-401F-AD44-0BB2B5353FE3"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"ProjectDetailsID",false,false,9);
if(repositoryColumnObj!=null)TempProjectDocumentUpload_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-ID1 not found");}

if(rows.ContainsKey("35C9A0CA-D47F-4947-8940-8391930E3E53"))     elementData = rows["35C9A0CA-D47F-4947-8940-8391930E3E53"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"DocumentName",false,false,9);
if(repositoryColumnObj!=null)TempProjectDocumentUpload_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-Document not found");}

elementData = CurrentDate().ToString() ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"UpdatedOn",false,false,8);
if(repositoryColumnObj!=null)TempProjectDocumentUpload_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-CurrentDate not found");}

elementData = ISpace["gv_UserId"].Value != null? Convert.ToString(ISpace["gv_UserId"].Value):null ;if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"UpdatedBy",false,false,6);
if(repositoryColumnObj!=null)TempProjectDocumentUpload_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-gv_UserId not found");}

if(rows.ContainsKey("2833427C-A5F6-43D0-9A15-E33760BA7E46"))     elementData = rows["2833427C-A5F6-43D0-9A15-E33760BA7E46"];if(elementData!=null){repositoryColumnObj=GetRepositoryColumnObject(elementData,"TempInstanceid",false,false,9);
if(repositoryColumnObj!=null)TempProjectDocumentUpload_colObj.Add(repositoryColumnObj);elementData = null;}
else{base.WriteDebugInfo(@"Element-TempInstanceID not found");}
repositoryRowObj.Columns=TempProjectDocumentUpload_colObj;
TempDocumentUpload_TempProjectDocumentUpload_rowsObj.Add(repositoryRowObj);
}}

TempProjectDocumentUploadTempDocumentUploadtableObj.Rows=TempDocumentUpload_TempProjectDocumentUpload_rowsObj;
var TempDocumentUpload_repoObj_status_TempProjectDocumentUpload = TempDocumentUpload_repoObj.Execute(DomainOperationTypes.CreateOrUpdate,ref TempProjectDocumentUploadTempDocumentUploadtableObj);if(!TempDocumentUpload_repoObj_status_TempProjectDocumentUpload) throw new Exception("Error in Execute Domain Data Map");}
base.WriteDebugInfo(@"Exiting DomainDataMap for TempDocumentUpload");
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_mp_no (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"MP_No-OnChange");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
base.WriteDebugInfo(@"#BudgetDetails[Rows]");
iSpace.GetLoopExpressionData("BudgetDetails",ref ISpace);

foreach(var gridChild in ISpace["BudgetDetails"].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 


if(
ISpace["Bid"].Value==7)
{
base.WriteDebugInfo(@"
if(
ISpace[""Bid""].Value==7)");
ISpace["ManPowerAmount"].Value=ISpace["BudgetAmount"].Value;
base.WriteDebugInfo(@"ISpace[""ManPowerAmount""].Value=ISpace[""BudgetAmount""].Value;");
}
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("BudgetDetails","C92F6C5D-F7CB-4E81-835C-3D655C7FCC52",_objectFactory.GetGridRPP("BudgetDetails"),_elementBase.GetGridLoopQuery("C92F6C5D-F7CB-4E81-835C-3D655C7FCC52","BudgetDetails",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""BudgetDetails"",ref ISpace);

foreach(var gridChild in ISpace[""BudgetDetails""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
if(ISpace["ManpowerTotalCost"].Value>ISpace["ManPowerAmount"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""ManpowerTotalCost""].Value>ISpace[""ManPowerAmount""].Value)");
ISpace["Message"].Value=@"ManPower Total Cost is greater than Manpower Budget";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""ManPower Total Cost is greater than Manpower Budget"";");
ISpace["MP_No"].Value=null;
base.WriteDebugInfo(@"ISpace[""MP_No""].Value=null;");
ISpace["MP_RatePerMonth"].Value=null;
base.WriteDebugInfo(@"ISpace[""MP_RatePerMonth""].Value=null;");
ISpace["MP_HRAPer"].Value=0;
base.WriteDebugInfo(@"ISpace[""MP_HRAPer""].Value=0;");
ISpace["MP_TotalPerMonth"].Value=0;
base.WriteDebugInfo(@"ISpace[""MP_TotalPerMonth""].Value=0;");
ISpace["MP_TotalMonths"].Value=null;
base.WriteDebugInfo(@"ISpace[""MP_TotalMonths""].Value=null;");
ISpace["MP_ManpowerTotalCost"].Value=0;
base.WriteDebugInfo(@"ISpace[""MP_ManpowerTotalCost""].Value=0;");
object MP_ManpowerTotalCost=iSpace.Sum("[]","MP_ManpowerTotalCost","",ISpace["gv_instanceid"].Value);
ISpace["ManpowerTotalCost"].Value=Convert.ChangeType(MP_ManpowerTotalCost, MP_ManpowerTotalCost.GetType());;
base.WriteDebugInfo(@"object MP_ManpowerTotalCost=iSpace.Sum(""[]"",""MP_ManpowerTotalCost"","""",ISpace[""gv_instanceid""].Value);
ISpace[""ManpowerTotalCost""].Value=Convert.ChangeType(MP_ManpowerTotalCost, MP_ManpowerTotalCost.GetType());;");
return;
base.WriteDebugInfo(@"return;");
}
}
ISpace["MP_HRAPercal"].Value=ISpace["MP_HRAPer"].Value/100.0;
base.WriteDebugInfo(@"ISpace[""MP_HRAPercal""].Value=ISpace[""MP_HRAPer""].Value/100.0;");
ISpace["MP_HRAperMonth"].Value=ISpace["MP_RatePerMonth"].Value*ISpace["MP_HRAPercal"].Value;
base.WriteDebugInfo(@"ISpace[""MP_HRAperMonth""].Value=ISpace[""MP_RatePerMonth""].Value*ISpace[""MP_HRAPercal""].Value;");
ISpace["MP_TotalPerMonth"].Value=ISpace["MP_RatePerMonth"].Value+ISpace["MP_HRAperMonth"].Value;
base.WriteDebugInfo(@"ISpace[""MP_TotalPerMonth""].Value=ISpace[""MP_RatePerMonth""].Value+ISpace[""MP_HRAperMonth""].Value;");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_year11 (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Year11-OnChange");
ISpace["BudgetAmount"].Value= ISpace["Year11"].Value+ISpace["Year12"].Value+ISpace["Year13"].Value+ISpace["Year14"].Value+ISpace["Year15"].Value+ISpace["Year16"].Value+ISpace["Year17"].Value+ISpace["Year18"].Value+ISpace["Year19"].Value+ISpace["Year20"].Value+ISpace["Year21"].Value+ISpace["Year22"].Value;
base.WriteDebugInfo(@"ISpace[""BudgetAmount""].Value= ISpace[""Year11""].Value+ISpace[""Year12""].Value+ISpace[""Year13""].Value+ISpace[""Year14""].Value+ISpace[""Year15""].Value+ISpace[""Year16""].Value+ISpace[""Year17""].Value+ISpace[""Year18""].Value+ISpace[""Year19""].Value+ISpace[""Year20""].Value+ISpace[""Year21""].Value+ISpace[""Year22""].Value;");
ISpace["RecurringAmount"].Value=0;
base.WriteDebugInfo(@"ISpace[""RecurringAmount""].Value=0;");
ISpace["NonRecurringAmount"].Value=0;
base.WriteDebugInfo(@"ISpace[""NonRecurringAmount""].Value=0;");
object BudgetAmount=iSpace.Sum("[C92F6C5D-F7CB-4E81-835C-3D655C7FCC52]","BudgetAmount","",ISpace["gv_instanceid"].Value);
ISpace["OverallBudgetTotal"].Value=Convert.ChangeType(BudgetAmount, BudgetAmount.GetType());;
base.WriteDebugInfo(@"object BudgetAmount=iSpace.Sum(""[C92F6C5D-F7CB-4E81-835C-3D655C7FCC52]"",""BudgetAmount"","""",ISpace[""gv_instanceid""].Value);
ISpace[""OverallBudgetTotal""].Value=Convert.ChangeType(BudgetAmount, BudgetAmount.GetType());;");
if(1==2)
{
base.WriteDebugInfo(@"if(1==2)");
base.WriteDebugInfo(@"#BudgetDetails[Rows]");
iSpace.GetLoopExpressionData("BudgetDetails",ref ISpace);

foreach(var gridChild in ISpace["BudgetDetails"].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 


if(
ISpace["RecurringValidation"].Value==518)
{
base.WriteDebugInfo(@"
if(
ISpace[""RecurringValidation""].Value==518)");
object BudgetAmount=iSpace.Sum("[C92F6C5D-F7CB-4E81-835C-3D655C7FCC52]","BudgetAmount","",ISpace["gv_instanceid"].Value);
ISpace["RecurringAmount"].Value=Convert.ChangeType(BudgetAmount, BudgetAmount.GetType());;
base.WriteDebugInfo(@"object BudgetAmount=iSpace.Sum(""[C92F6C5D-F7CB-4E81-835C-3D655C7FCC52]"",""BudgetAmount"","""",ISpace[""gv_instanceid""].Value);
ISpace[""RecurringAmount""].Value=Convert.ChangeType(BudgetAmount, BudgetAmount.GetType());;");
}
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("BudgetDetails","C92F6C5D-F7CB-4E81-835C-3D655C7FCC52",_objectFactory.GetGridRPP("BudgetDetails"),_elementBase.GetGridLoopQuery("C92F6C5D-F7CB-4E81-835C-3D655C7FCC52","BudgetDetails",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""BudgetDetails"",ref ISpace);

foreach(var gridChild in ISpace[""BudgetDetails""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
}
base.WriteDebugInfo(@"#BudgetDetails[Rows]");
iSpace.GetLoopExpressionData("BudgetDetails",ref ISpace);

foreach(var gridChild in ISpace["BudgetDetails"].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 


if(
ISpace["RecurringValidation"].Value==519)
{
base.WriteDebugInfo(@"
if(
ISpace[""RecurringValidation""].Value==519)");
ISpace["NonRecurringAmount"].Value=ISpace["NonRecurringAmount"].Value+ISpace["BudgetAmount"].Value;
base.WriteDebugInfo(@"ISpace[""NonRecurringAmount""].Value=ISpace[""NonRecurringAmount""].Value+ISpace[""BudgetAmount""].Value;");
}

if(
ISpace["RecurringValidation"].Value==518)
{
base.WriteDebugInfo(@"
if(
ISpace[""RecurringValidation""].Value==518)");
ISpace["RecurringAmount"].Value=ISpace["RecurringAmount"].Value+ISpace["BudgetAmount"].Value;
base.WriteDebugInfo(@"ISpace[""RecurringAmount""].Value=ISpace[""RecurringAmount""].Value+ISpace[""BudgetAmount""].Value;");
}
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("BudgetDetails","C92F6C5D-F7CB-4E81-835C-3D655C7FCC52",_objectFactory.GetGridRPP("BudgetDetails"),_elementBase.GetGridLoopQuery("C92F6C5D-F7CB-4E81-835C-3D655C7FCC52","BudgetDetails",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""BudgetDetails"",ref ISpace);

foreach(var gridChild in ISpace[""BudgetDetails""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
if(ISpace["OverallBudgetTotal"].Value>ISpace["ProjectBudget"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""OverallBudgetTotal""].Value>ISpace[""ProjectBudget""].Value)");
ISpace["Message"].Value=@"Total Amount Should be Equal to Project Budget";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Total Amount Should be Equal to Project Budget"";");
ISpace["Year11"].Value=null;
base.WriteDebugInfo(@"ISpace[""Year11""].Value=null;");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["BudgetAmount"].Value= ISpace["Year11"].Value+ISpace["Year12"].Value+ISpace["Year13"].Value+ISpace["Year14"].Value+ISpace["Year15"].Value+ISpace["Year16"].Value+ISpace["Year17"].Value+ISpace["Year18"].Value+ISpace["Year19"].Value+ISpace["Year20"].Value+ISpace["Year21"].Value+ISpace["Year22"].Value;
base.WriteDebugInfo(@"ISpace[""BudgetAmount""].Value= ISpace[""Year11""].Value+ISpace[""Year12""].Value+ISpace[""Year13""].Value+ISpace[""Year14""].Value+ISpace[""Year15""].Value+ISpace[""Year16""].Value+ISpace[""Year17""].Value+ISpace[""Year18""].Value+ISpace[""Year19""].Value+ISpace[""Year20""].Value+ISpace[""Year21""].Value+ISpace[""Year22""].Value;");
ISpace["NonRecurringAmount"].Value=0;
base.WriteDebugInfo(@"ISpace[""NonRecurringAmount""].Value=0;");
ISpace["RecurringAmount"].Value=0;
base.WriteDebugInfo(@"ISpace[""RecurringAmount""].Value=0;");
object BudgetAmount=iSpace.Sum("[C92F6C5D-F7CB-4E81-835C-3D655C7FCC52]","BudgetAmount","",ISpace["gv_instanceid"].Value);
ISpace["OverallBudgetTotal"].Value=Convert.ChangeType(BudgetAmount, BudgetAmount.GetType());;
base.WriteDebugInfo(@"object BudgetAmount=iSpace.Sum(""[C92F6C5D-F7CB-4E81-835C-3D655C7FCC52]"",""BudgetAmount"","""",ISpace[""gv_instanceid""].Value);
ISpace[""OverallBudgetTotal""].Value=Convert.ChangeType(BudgetAmount, BudgetAmount.GetType());;");
base.WriteDebugInfo(@"#BudgetDetails[Rows]");
iSpace.GetLoopExpressionData("BudgetDetails",ref ISpace);

foreach(var gridChild in ISpace["BudgetDetails"].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 


if(
ISpace["RecurringValidation"].Value==519)
{
base.WriteDebugInfo(@"
if(
ISpace[""RecurringValidation""].Value==519)");
ISpace["NonRecurringAmount"].Value=ISpace["NonRecurringAmount"].Value+ISpace["BudgetAmount"].Value;
base.WriteDebugInfo(@"ISpace[""NonRecurringAmount""].Value=ISpace[""NonRecurringAmount""].Value+ISpace[""BudgetAmount""].Value;");
}

if(
ISpace["RecurringValidation"].Value==518)
{
base.WriteDebugInfo(@"
if(
ISpace[""RecurringValidation""].Value==518)");
ISpace["RecurringAmount"].Value=ISpace["RecurringAmount"].Value+ISpace["BudgetAmount"].Value;
base.WriteDebugInfo(@"ISpace[""RecurringAmount""].Value=ISpace[""RecurringAmount""].Value+ISpace[""BudgetAmount""].Value;");
}
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("BudgetDetails","C92F6C5D-F7CB-4E81-835C-3D655C7FCC52",_objectFactory.GetGridRPP("BudgetDetails"),_elementBase.GetGridLoopQuery("C92F6C5D-F7CB-4E81-835C-3D655C7FCC52","BudgetDetails",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""BudgetDetails"",ref ISpace);

foreach(var gridChild in ISpace[""BudgetDetails""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
}
return;
base.WriteDebugInfo(@"return;");
}
ISpace["DocumentDetails"].Man=true;
base.WriteDebugInfo(@"ISpace[""DocumentDetails""].Man=true;");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_sanctiondate (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"SanctionDate-OnChange");
if(CurrentDate()<=ISpace["SanctionDate"].Value)
{
base.WriteDebugInfo(@"if(CurrentDate()<=ISpace[""SanctionDate""].Value)");
ISpace["SanctionDate"].Value=null;
base.WriteDebugInfo(@"ISpace[""SanctionDate""].Value=null;");
ISpace["Message"].Value=@"Please Enter The Date Less Than Current Date.";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Please Enter The Date Less Than Current Date."";");
return;
base.WriteDebugInfo(@"return;");
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_year21 (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Year21-OnChange");
ISpace["BudgetAmount"].Value= ISpace["Year11"].Value+ISpace["Year12"].Value+ISpace["Year13"].Value+ISpace["Year14"].Value+ISpace["Year15"].Value+ISpace["Year16"].Value+ISpace["Year17"].Value+ISpace["Year18"].Value+ISpace["Year19"].Value+ISpace["Year20"].Value+ISpace["Year21"].Value+ISpace["Year22"].Value;
base.WriteDebugInfo(@"ISpace[""BudgetAmount""].Value= ISpace[""Year11""].Value+ISpace[""Year12""].Value+ISpace[""Year13""].Value+ISpace[""Year14""].Value+ISpace[""Year15""].Value+ISpace[""Year16""].Value+ISpace[""Year17""].Value+ISpace[""Year18""].Value+ISpace[""Year19""].Value+ISpace[""Year20""].Value+ISpace[""Year21""].Value+ISpace[""Year22""].Value;");
ISpace["RecurringAmount"].Value=0;
base.WriteDebugInfo(@"ISpace[""RecurringAmount""].Value=0;");
ISpace["NonRecurringAmount"].Value=0;
base.WriteDebugInfo(@"ISpace[""NonRecurringAmount""].Value=0;");
object BudgetAmount=iSpace.Sum("[C92F6C5D-F7CB-4E81-835C-3D655C7FCC52]","BudgetAmount","",ISpace["gv_instanceid"].Value);
ISpace["OverallBudgetTotal"].Value=Convert.ChangeType(BudgetAmount, BudgetAmount.GetType());;
base.WriteDebugInfo(@"object BudgetAmount=iSpace.Sum(""[C92F6C5D-F7CB-4E81-835C-3D655C7FCC52]"",""BudgetAmount"","""",ISpace[""gv_instanceid""].Value);
ISpace[""OverallBudgetTotal""].Value=Convert.ChangeType(BudgetAmount, BudgetAmount.GetType());;");
if(1==2)
{
base.WriteDebugInfo(@"if(1==2)");
base.WriteDebugInfo(@"#BudgetDetails[Rows]");
iSpace.GetLoopExpressionData("BudgetDetails",ref ISpace);

foreach(var gridChild in ISpace["BudgetDetails"].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 


if(
ISpace["RecurringValidation"].Value==518)
{
base.WriteDebugInfo(@"
if(
ISpace[""RecurringValidation""].Value==518)");
object BudgetAmount=iSpace.Sum("[C92F6C5D-F7CB-4E81-835C-3D655C7FCC52]","BudgetAmount","",ISpace["gv_instanceid"].Value);
ISpace["RecurringAmount"].Value=Convert.ChangeType(BudgetAmount, BudgetAmount.GetType());;
base.WriteDebugInfo(@"object BudgetAmount=iSpace.Sum(""[C92F6C5D-F7CB-4E81-835C-3D655C7FCC52]"",""BudgetAmount"","""",ISpace[""gv_instanceid""].Value);
ISpace[""RecurringAmount""].Value=Convert.ChangeType(BudgetAmount, BudgetAmount.GetType());;");
}
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("BudgetDetails","C92F6C5D-F7CB-4E81-835C-3D655C7FCC52",_objectFactory.GetGridRPP("BudgetDetails"),_elementBase.GetGridLoopQuery("C92F6C5D-F7CB-4E81-835C-3D655C7FCC52","BudgetDetails",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""BudgetDetails"",ref ISpace);

foreach(var gridChild in ISpace[""BudgetDetails""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
}
base.WriteDebugInfo(@"#BudgetDetails[Rows]");
iSpace.GetLoopExpressionData("BudgetDetails",ref ISpace);

foreach(var gridChild in ISpace["BudgetDetails"].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 


if(
ISpace["RecurringValidation"].Value==519)
{
base.WriteDebugInfo(@"
if(
ISpace[""RecurringValidation""].Value==519)");
ISpace["NonRecurringAmount"].Value=ISpace["NonRecurringAmount"].Value+ISpace["BudgetAmount"].Value;
base.WriteDebugInfo(@"ISpace[""NonRecurringAmount""].Value=ISpace[""NonRecurringAmount""].Value+ISpace[""BudgetAmount""].Value;");
}

if(
ISpace["RecurringValidation"].Value==518)
{
base.WriteDebugInfo(@"
if(
ISpace[""RecurringValidation""].Value==518)");
ISpace["RecurringAmount"].Value=ISpace["RecurringAmount"].Value+ISpace["BudgetAmount"].Value;
base.WriteDebugInfo(@"ISpace[""RecurringAmount""].Value=ISpace[""RecurringAmount""].Value+ISpace[""BudgetAmount""].Value;");
}
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("BudgetDetails","C92F6C5D-F7CB-4E81-835C-3D655C7FCC52",_objectFactory.GetGridRPP("BudgetDetails"),_elementBase.GetGridLoopQuery("C92F6C5D-F7CB-4E81-835C-3D655C7FCC52","BudgetDetails",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""BudgetDetails"",ref ISpace);

foreach(var gridChild in ISpace[""BudgetDetails""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_add1 (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Add1-OnClick");
ISpace["UI_CD1"].ShowDialog=true;;
base.WriteDebugInfo(@"ISpace[""UI_CD1""].ShowDialog=true;;");
ISpace["DName"].Value="";
base.WriteDebugInfo(@"ISpace[""DName""].Value="""";");
ISpace["DCode"].Value="";
base.WriteDebugInfo(@"ISpace[""DCode""].Value="""";");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_ifexternalins (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"IfExternalIns-OnChange");
if(ISpace["IfExternalIns"].Value==true)
{
base.WriteDebugInfo(@"if(ISpace[""IfExternalIns""].Value==true)");
if(ISpace["FormVersionId"].Value=="EB102E80-C3DC-4EB9-8511-B1018E342530")
{
ISpace["UI_EIColumn"].Visible="true";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""EB102E80-C3DC-4EB9-8511-B1018E342530"")
{
ISpace[""UI_EIColumn""].Visible=""true"";
}");
ISpace["ExternalInstitute"].Man=true;
base.WriteDebugInfo(@"ISpace[""ExternalInstitute""].Man=true;");
}
if(ISpace["IfExternalIns"].Value==false)
{
base.WriteDebugInfo(@"if(ISpace[""IfExternalIns""].Value==false)");
if(ISpace["FormVersionId"].Value=="EB102E80-C3DC-4EB9-8511-B1018E342530")
{
ISpace["UI_EIColumn"].Visible="false";
}
base.WriteDebugInfo(@"if(ISpace[""FormVersionId""].Value==""EB102E80-C3DC-4EB9-8511-B1018E342530"")
{
ISpace[""UI_EIColumn""].Visible=""false"";
}");
ISpace["ExternalInstitute"].Man=false;
base.WriteDebugInfo(@"ISpace[""ExternalInstitute""].Man=false;");
}
object NKLIEI_FacultyName=iSpace.Count("[1B307D9B-9E56-415F-8C11-BF109F7A2E30]","NKLIEI_FacultyName","",ISpace["gv_instanceid"].Value);
ISpace["ExtCount"].Value=Convert.ChangeType(NKLIEI_FacultyName, NKLIEI_FacultyName.GetType());;
base.WriteDebugInfo(@"object NKLIEI_FacultyName=iSpace.Count(""[1B307D9B-9E56-415F-8C11-BF109F7A2E30]"",""NKLIEI_FacultyName"","""",ISpace[""gv_instanceid""].Value);
ISpace[""ExtCount""].Value=Convert.ChangeType(NKLIEI_FacultyName, NKLIEI_FacultyName.GetType());;");
if(ISpace["ExtCount"].Value==0)
{
base.WriteDebugInfo(@"if(ISpace[""ExtCount""].Value==0)");
ISpace["IfExternalIns"].Enbl="true";
base.WriteDebugInfo(@"ISpace[""IfExternalIns""].Enbl=""true"";");
}
else
{
base.WriteDebugInfo(@"else");
ISpace["IfExternalIns"].Enbl="false";
base.WriteDebugInfo(@"ISpace[""IfExternalIns""].Enbl=""false"";");
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_externaldepartment (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"ExternalDepartment-OnChange");
ISpace["Name"].rElemData=iSpace.Reload(ISpace["Name"].Value,@"EXEC GetDepartmentWiseFacultyCopi '" + ISpace["ExternalDepartment"].Value + @"',3,'" + ISpace["DummyInstance"].Value + @"',''","40BDEB14-07CC-4150-8A52-9B088A428E2D");
base.WriteDebugInfo(@"ISpace[""Name""].rElemData=iSpace.Reload(ISpace[""Name""].Value,@""EXEC GetDepartmentWiseFacultyCopi '"" + ISpace[""ExternalDepartment""].Value + @""',3,'"" + ISpace[""DummyInstance""].Value + @""',''"",""40BDEB14-07CC-4150-8A52-9B088A428E2D"");");
ISpace["UserName"].Value="";
base.WriteDebugInfo(@"ISpace[""UserName""].Value="""";");
ISpace["Role"].Value="";
base.WriteDebugInfo(@"ISpace[""Role""].Value="""";");
ISpace["Email"].Value="";
base.WriteDebugInfo(@"ISpace[""Email""].Value="""";");
if(ISpace["ExternalDepartment"].Value=="")
{
base.WriteDebugInfo(@"if(ISpace[""ExternalDepartment""].Value=="""")");
ISpace["Name"].Value="";
base.WriteDebugInfo(@"ISpace[""Name""].Value="""";");
}
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_reappropriation (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Reappropriation-OnChange");
ISpace["BudgetAmount"].Value= ISpace["Year11"].Value+ISpace["Year12"].Value+ISpace["Year13"].Value+ISpace["Year14"].Value+ISpace["Year15"].Value+ISpace["Year16"].Value+ISpace["Year17"].Value+ISpace["Year18"].Value+ISpace["Year19"].Value+ISpace["Year20"].Value+ISpace["Year21"].Value+ISpace["Year22"].Value;
base.WriteDebugInfo(@"ISpace[""BudgetAmount""].Value= ISpace[""Year11""].Value+ISpace[""Year12""].Value+ISpace[""Year13""].Value+ISpace[""Year14""].Value+ISpace[""Year15""].Value+ISpace[""Year16""].Value+ISpace[""Year17""].Value+ISpace[""Year18""].Value+ISpace[""Year19""].Value+ISpace[""Year20""].Value+ISpace[""Year21""].Value+ISpace[""Year22""].Value;");
ISpace["RecurringAmount"].Value=0;
base.WriteDebugInfo(@"ISpace[""RecurringAmount""].Value=0;");
ISpace["NonRecurringAmount"].Value=0;
base.WriteDebugInfo(@"ISpace[""NonRecurringAmount""].Value=0;");
object BudgetAmount=iSpace.Sum("[C92F6C5D-F7CB-4E81-835C-3D655C7FCC52]","BudgetAmount","",ISpace["gv_instanceid"].Value);
ISpace["OverallBudgetTotal"].Value=Convert.ChangeType(BudgetAmount, BudgetAmount.GetType());;
base.WriteDebugInfo(@"object BudgetAmount=iSpace.Sum(""[C92F6C5D-F7CB-4E81-835C-3D655C7FCC52]"",""BudgetAmount"","""",ISpace[""gv_instanceid""].Value);
ISpace[""OverallBudgetTotal""].Value=Convert.ChangeType(BudgetAmount, BudgetAmount.GetType());;");
if(1==2)
{
base.WriteDebugInfo(@"if(1==2)");
base.WriteDebugInfo(@"#BudgetDetails[Rows]");
iSpace.GetLoopExpressionData("BudgetDetails",ref ISpace);

foreach(var gridChild in ISpace["BudgetDetails"].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 


if(
ISpace["RecurringValidation"].Value==518)
{
base.WriteDebugInfo(@"
if(
ISpace[""RecurringValidation""].Value==518)");
object BudgetAmount=iSpace.Sum("[C92F6C5D-F7CB-4E81-835C-3D655C7FCC52]","BudgetAmount","",ISpace["gv_instanceid"].Value);
ISpace["RecurringAmount"].Value=Convert.ChangeType(BudgetAmount, BudgetAmount.GetType());;
base.WriteDebugInfo(@"object BudgetAmount=iSpace.Sum(""[C92F6C5D-F7CB-4E81-835C-3D655C7FCC52]"",""BudgetAmount"","""",ISpace[""gv_instanceid""].Value);
ISpace[""RecurringAmount""].Value=Convert.ChangeType(BudgetAmount, BudgetAmount.GetType());;");
}
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("BudgetDetails","C92F6C5D-F7CB-4E81-835C-3D655C7FCC52",_objectFactory.GetGridRPP("BudgetDetails"),_elementBase.GetGridLoopQuery("C92F6C5D-F7CB-4E81-835C-3D655C7FCC52","BudgetDetails",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""BudgetDetails"",ref ISpace);

foreach(var gridChild in ISpace[""BudgetDetails""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
}
base.WriteDebugInfo(@"#BudgetDetails[Rows]");
iSpace.GetLoopExpressionData("BudgetDetails",ref ISpace);

foreach(var gridChild in ISpace["BudgetDetails"].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 


if(
ISpace["RecurringValidation"].Value==519)
{
base.WriteDebugInfo(@"
if(
ISpace[""RecurringValidation""].Value==519)");
ISpace["NonRecurringAmount"].Value=ISpace["NonRecurringAmount"].Value+ISpace["BudgetAmount"].Value;
base.WriteDebugInfo(@"ISpace[""NonRecurringAmount""].Value=ISpace[""NonRecurringAmount""].Value+ISpace[""BudgetAmount""].Value;");
}

if(
ISpace["RecurringValidation"].Value==518)
{
base.WriteDebugInfo(@"
if(
ISpace[""RecurringValidation""].Value==518)");
ISpace["RecurringAmount"].Value=ISpace["RecurringAmount"].Value+ISpace["BudgetAmount"].Value;
base.WriteDebugInfo(@"ISpace[""RecurringAmount""].Value=ISpace[""RecurringAmount""].Value+ISpace[""BudgetAmount""].Value;");
}
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("BudgetDetails","C92F6C5D-F7CB-4E81-835C-3D655C7FCC52",_objectFactory.GetGridRPP("BudgetDetails"),_elementBase.GetGridLoopQuery("C92F6C5D-F7CB-4E81-835C-3D655C7FCC52","BudgetDetails",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""BudgetDetails"",ref ISpace);

foreach(var gridChild in ISpace[""BudgetDetails""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
if(ISpace["OverallBudgetTotal"].Value>ISpace["ProjectBudget"].Value)
{
base.WriteDebugInfo(@"if(ISpace[""OverallBudgetTotal""].Value>ISpace[""ProjectBudget""].Value)");
ISpace["Message"].Value=@"Total Amount Should be Equal to Project Budget";
base.WriteDebugInfo(@"ISpace[""Message""].Value=@""Total Amount Should be Equal to Project Budget"";");
ISpace["Year11"].Value=null;
base.WriteDebugInfo(@"ISpace[""Year11""].Value=null;");
if(1==1)
{
base.WriteDebugInfo(@"if(1==1)");
ISpace["BudgetAmount"].Value= ISpace["Year11"].Value+ISpace["Year12"].Value+ISpace["Year13"].Value+ISpace["Year14"].Value+ISpace["Year15"].Value+ISpace["Year16"].Value+ISpace["Year17"].Value+ISpace["Year18"].Value+ISpace["Year19"].Value+ISpace["Year20"].Value+ISpace["Year21"].Value+ISpace["Year22"].Value;
base.WriteDebugInfo(@"ISpace[""BudgetAmount""].Value= ISpace[""Year11""].Value+ISpace[""Year12""].Value+ISpace[""Year13""].Value+ISpace[""Year14""].Value+ISpace[""Year15""].Value+ISpace[""Year16""].Value+ISpace[""Year17""].Value+ISpace[""Year18""].Value+ISpace[""Year19""].Value+ISpace[""Year20""].Value+ISpace[""Year21""].Value+ISpace[""Year22""].Value;");
ISpace["NonRecurringAmount"].Value=0;
base.WriteDebugInfo(@"ISpace[""NonRecurringAmount""].Value=0;");
ISpace["RecurringAmount"].Value=0;
base.WriteDebugInfo(@"ISpace[""RecurringAmount""].Value=0;");
object BudgetAmount=iSpace.Sum("[C92F6C5D-F7CB-4E81-835C-3D655C7FCC52]","BudgetAmount","",ISpace["gv_instanceid"].Value);
ISpace["OverallBudgetTotal"].Value=Convert.ChangeType(BudgetAmount, BudgetAmount.GetType());;
base.WriteDebugInfo(@"object BudgetAmount=iSpace.Sum(""[C92F6C5D-F7CB-4E81-835C-3D655C7FCC52]"",""BudgetAmount"","""",ISpace[""gv_instanceid""].Value);
ISpace[""OverallBudgetTotal""].Value=Convert.ChangeType(BudgetAmount, BudgetAmount.GetType());;");
base.WriteDebugInfo(@"#BudgetDetails[Rows]");
iSpace.GetLoopExpressionData("BudgetDetails",ref ISpace);

foreach(var gridChild in ISpace["BudgetDetails"].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 


if(
ISpace["RecurringValidation"].Value==519)
{
base.WriteDebugInfo(@"
if(
ISpace[""RecurringValidation""].Value==519)");
ISpace["NonRecurringAmount"].Value=ISpace["NonRecurringAmount"].Value+ISpace["BudgetAmount"].Value;
base.WriteDebugInfo(@"ISpace[""NonRecurringAmount""].Value=ISpace[""NonRecurringAmount""].Value+ISpace[""BudgetAmount""].Value;");
}

if(
ISpace["RecurringValidation"].Value==518)
{
base.WriteDebugInfo(@"
if(
ISpace[""RecurringValidation""].Value==518)");
ISpace["RecurringAmount"].Value=ISpace["RecurringAmount"].Value+ISpace["BudgetAmount"].Value;
base.WriteDebugInfo(@"ISpace[""RecurringAmount""].Value=ISpace[""RecurringAmount""].Value+ISpace[""BudgetAmount""].Value;");
}
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("BudgetDetails","C92F6C5D-F7CB-4E81-835C-3D655C7FCC52",_objectFactory.GetGridRPP("BudgetDetails"),_elementBase.GetGridLoopQuery("C92F6C5D-F7CB-4E81-835C-3D655C7FCC52","BudgetDetails",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""BudgetDetails"",ref ISpace);

foreach(var gridChild in ISpace[""BudgetDetails""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
}
return;
base.WriteDebugInfo(@"return;");
}
ISpace["DocumentDetails"].Man=true;
base.WriteDebugInfo(@"ISpace[""DocumentDetails""].Man=true;");
}
catch(Exception ex)
{
base.WriteErrorInfo(@"Exception:",ex);
}
}
private void SubscribeElementEvents_year12 (ref Dictionary<string,ServiceElementData> ISpace)
{
IISpace iSpace = new ISpace();
try
{
base.WriteDebugInfo(@"Year12-OnChange");
ISpace["BudgetAmount"].Value= ISpace["Year11"].Value+ISpace["Year12"].Value+ISpace["Year13"].Value+ISpace["Year14"].Value+ISpace["Year15"].Value+ISpace["Year16"].Value+ISpace["Year17"].Value+ISpace["Year18"].Value+ISpace["Year19"].Value+ISpace["Year20"].Value+ISpace["Year21"].Value+ISpace["Year22"].Value;
base.WriteDebugInfo(@"ISpace[""BudgetAmount""].Value= ISpace[""Year11""].Value+ISpace[""Year12""].Value+ISpace[""Year13""].Value+ISpace[""Year14""].Value+ISpace[""Year15""].Value+ISpace[""Year16""].Value+ISpace[""Year17""].Value+ISpace[""Year18""].Value+ISpace[""Year19""].Value+ISpace[""Year20""].Value+ISpace[""Year21""].Value+ISpace[""Year22""].Value;");
ISpace["RecurringAmount"].Value=0;
base.WriteDebugInfo(@"ISpace[""RecurringAmount""].Value=0;");
ISpace["NonRecurringAmount"].Value=0;
base.WriteDebugInfo(@"ISpace[""NonRecurringAmount""].Value=0;");
object BudgetAmount=iSpace.Sum("[C92F6C5D-F7CB-4E81-835C-3D655C7FCC52]","BudgetAmount","",ISpace["gv_instanceid"].Value);
ISpace["OverallBudgetTotal"].Value=Convert.ChangeType(BudgetAmount, BudgetAmount.GetType());;
base.WriteDebugInfo(@"object BudgetAmount=iSpace.Sum(""[C92F6C5D-F7CB-4E81-835C-3D655C7FCC52]"",""BudgetAmount"","""",ISpace[""gv_instanceid""].Value);
ISpace[""OverallBudgetTotal""].Value=Convert.ChangeType(BudgetAmount, BudgetAmount.GetType());;");
if(1==2)
{
base.WriteDebugInfo(@"if(1==2)");
base.WriteDebugInfo(@"#BudgetDetails[Rows]");
iSpace.GetLoopExpressionData("BudgetDetails",ref ISpace);

foreach(var gridChild in ISpace["BudgetDetails"].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 


if(
ISpace["RecurringValidation"].Value==518)
{
base.WriteDebugInfo(@"
if(
ISpace[""RecurringValidation""].Value==518)");
object BudgetAmount=iSpace.Sum("[C92F6C5D-F7CB-4E81-835C-3D655C7FCC52]","BudgetAmount","",ISpace["gv_instanceid"].Value);
ISpace["RecurringAmount"].Value=Convert.ChangeType(BudgetAmount, BudgetAmount.GetType());;
base.WriteDebugInfo(@"object BudgetAmount=iSpace.Sum(""[C92F6C5D-F7CB-4E81-835C-3D655C7FCC52]"",""BudgetAmount"","""",ISpace[""gv_instanceid""].Value);
ISpace[""RecurringAmount""].Value=Convert.ChangeType(BudgetAmount, BudgetAmount.GetType());;");
}
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("BudgetDetails","C92F6C5D-F7CB-4E81-835C-3D655C7FCC52",_objectFactory.GetGridRPP("BudgetDetails"),_elementBase.GetGridLoopQuery("C92F6C5D-F7CB-4E81-835C-3D655C7FCC52","BudgetDetails",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""BudgetDetails"",ref ISpace);

foreach(var gridChild in ISpace[""BudgetDetails""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
}
base.WriteDebugInfo(@"#BudgetDetails[Rows]");
iSpace.GetLoopExpressionData("BudgetDetails",ref ISpace);

foreach(var gridChild in ISpace["BudgetDetails"].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 


if(
ISpace["RecurringValidation"].Value==519)
{
base.WriteDebugInfo(@"
if(
ISpace[""RecurringValidation""].Value==519)");
ISpace["NonRecurringAmount"].Value=ISpace["NonRecurringAmount"].Value+ISpace["BudgetAmount"].Value;
base.WriteDebugInfo(@"ISpace[""NonRecurringAmount""].Value=ISpace[""NonRecurringAmount""].Value+ISpace[""BudgetAmount""].Value;");
}

if(
ISpace["RecurringValidation"].Value==518)
{
base.WriteDebugInfo(@"
if(
ISpace[""RecurringValidation""].Value==518)");
ISpace["RecurringAmount"].Value=ISpace["RecurringAmount"].Value+ISpace["BudgetAmount"].Value;
base.WriteDebugInfo(@"ISpace[""RecurringAmount""].Value=ISpace[""RecurringAmount""].Value+ISpace[""BudgetAmount""].Value;");
}
}
if (_elementBase != null)  iSpace.SetLoopExpressionData("BudgetDetails","C92F6C5D-F7CB-4E81-835C-3D655C7FCC52",_objectFactory.GetGridRPP("BudgetDetails"),_elementBase.GetGridLoopQuery("C92F6C5D-F7CB-4E81-835C-3D655C7FCC52","BudgetDetails",ISpace), ref ISpace);
base.WriteDebugInfo(@"iSpace.GetLoopExpressionData(""BudgetDetails"",ref ISpace);

foreach(var gridChild in ISpace[""BudgetDetails""].Child)
{foreach(var gridrow in gridChild.Child)
 {  if (!ISpace.ContainsKey(gridrow.ElementName)) { var gridcolumn = new ServiceElementData();  gridcolumn.ElementName = gridrow.ElementName; gridcolumn.Value = gridrow.Value;  ISpace.Add(gridrow.ElementName, gridcolumn); } else ISpace[gridrow.ElementName].Value = gridrow.Value; } 
");
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
		if(elementName.ToLower().Equals("name"))
    {
    			SubscribeElementEvents_name(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mp_totalmonths"))
    {
    			SubscribeElementEvents_mp_totalmonths(ref dfsParam);
    }
		if(elementName.ToLower().Equals("intamount"))
    {
    			SubscribeElementEvents_intamount(ref dfsParam);
    }
		if(elementName.ToLower().Equals("nkliei_phonenumber"))
    {
    			SubscribeElementEvents_nkliei_phonenumber(ref dfsParam);
    }
		if(elementName.ToLower().Equals("typeofproject"))
    {
    			SubscribeElementEvents_typeofproject(ref dfsParam);
    }
		if(elementName.ToLower().Equals("year15"))
    {
    			SubscribeElementEvents_year15(ref dfsParam);
    }
		if(elementName.ToLower().Equals("eqequipmentquantity"))
    {
    			SubscribeElementEvents_eqequipmentquantity(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mp_hraper"))
    {
    			SubscribeElementEvents_mp_hraper(ref dfsParam);
    }
		if(elementName.ToLower().Equals("projectproposal"))
    {
    			SubscribeElementEvents_projectproposal(ref dfsParam);
    }
		if(elementName.ToLower().Equals("ifequipment"))
    {
    			SubscribeElementEvents_ifequipment(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mp_hrapermonth"))
    {
    			SubscribeElementEvents_mp_hrapermonth(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mp_ratepermonth"))
    {
    			SubscribeElementEvents_mp_ratepermonth(ref dfsParam);
    }
		if(elementName.ToLower().Equals("eqequipmentrateininr"))
    {
    			SubscribeElementEvents_eqequipmentrateininr(ref dfsParam);
    }
		if(elementName.ToLower().Equals("fundingacencyname"))
    {
    			SubscribeElementEvents_fundingacencyname(ref dfsParam);
    }
		if(elementName.ToLower().Equals("facultytype"))
    {
    			SubscribeElementEvents_facultytype(ref dfsParam);
    }
		if(elementName.ToLower().Equals("year17"))
    {
    			SubscribeElementEvents_year17(ref dfsParam);
    }
		if(elementName.ToLower().Equals("year14"))
    {
    			SubscribeElementEvents_year14(ref dfsParam);
    }
		if(elementName.ToLower().Equals("year16"))
    {
    			SubscribeElementEvents_year16(ref dfsParam);
    }
		if(elementName.ToLower().Equals("intexpense"))
    {
    			SubscribeElementEvents_intexpense(ref dfsParam);
    }
		if(elementName.ToLower().Equals("year20"))
    {
    			SubscribeElementEvents_year20(ref dfsParam);
    }
		if(elementName.ToLower().Equals("year22"))
    {
    			SubscribeElementEvents_year22(ref dfsParam);
    }
		if(elementName.ToLower().Equals("startdate"))
    {
    			SubscribeElementEvents_startdate(ref dfsParam);
    }
		if(elementName.ToLower().Equals("eqequipmenttotalcost"))
    {
    			SubscribeElementEvents_eqequipmenttotalcost(ref dfsParam);
    }
		if(elementName.ToLower().Equals("endorsementamount"))
    {
    			SubscribeElementEvents_endorsementamount(ref dfsParam);
    }
		if(elementName.ToLower().Equals("budgethead"))
    {
    			SubscribeElementEvents_budgethead(ref dfsParam);
    }
		if(elementName.ToLower().Equals("ei_phonenumber"))
    {
    			SubscribeElementEvents_ei_phonenumber(ref dfsParam);
    }
		if(elementName.ToLower().Equals("year18"))
    {
    			SubscribeElementEvents_year18(ref dfsParam);
    }
		if(elementName.ToLower().Equals("year19"))
    {
    			SubscribeElementEvents_year19(ref dfsParam);
    }
		if(elementName.ToLower().Equals("year13"))
    {
    			SubscribeElementEvents_year13(ref dfsParam);
    }
		if(elementName.ToLower().Equals("manpowerrequired"))
    {
    			SubscribeElementEvents_manpowerrequired(ref dfsParam);
    }
		if(elementName.ToLower().Equals("duration"))
    {
    			SubscribeElementEvents_duration(ref dfsParam);
    }
		if(elementName.ToLower().Equals("monthyear"))
    {
    			SubscribeElementEvents_monthyear(ref dfsParam);
    }
		if(elementName.ToLower().Equals("mp_no"))
    {
    			SubscribeElementEvents_mp_no(ref dfsParam);
    }
		if(elementName.ToLower().Equals("year11"))
    {
    			SubscribeElementEvents_year11(ref dfsParam);
    }
		if(elementName.ToLower().Equals("sanctiondate"))
    {
    			SubscribeElementEvents_sanctiondate(ref dfsParam);
    }
		if(elementName.ToLower().Equals("year21"))
    {
    			SubscribeElementEvents_year21(ref dfsParam);
    }
		if(elementName.ToLower().Equals("ifexternalins"))
    {
    			SubscribeElementEvents_ifexternalins(ref dfsParam);
    }
		if(elementName.ToLower().Equals("externaldepartment"))
    {
    			SubscribeElementEvents_externaldepartment(ref dfsParam);
    }
		if(elementName.ToLower().Equals("reappropriation"))
    {
    			SubscribeElementEvents_reappropriation(ref dfsParam);
    }
		if(elementName.ToLower().Equals("year12"))
    {
    			SubscribeElementEvents_year12(ref dfsParam);
    }
}
	if(methodName.ToLower().Equals("onclick"))
{
		if(elementName.ToLower().Equals("back"))
{
			SubscribeElementEvents_back(ref dfsParam);
}
		if(elementName.ToLower().Equals("next"))
{
			SubscribeElementEvents_next(ref dfsParam);
}
		if(elementName.ToLower().Equals("fundreceiptadd"))
{
			SubscribeElementEvents_fundreceiptadd(ref dfsParam);
}
		if(elementName.ToLower().Equals("fundsubmit"))
{
			SubscribeElementEvents_fundsubmit(ref dfsParam);
}
		if(elementName.ToLower().Equals("budgetclose"))
{
			SubscribeElementEvents_budgetclose(ref dfsParam);
}
		if(elementName.ToLower().Equals("bcancel"))
{
			SubscribeElementEvents_bcancel(ref dfsParam);
}
		if(elementName.ToLower().Equals("budgetsubmit"))
{
			SubscribeElementEvents_budgetsubmit(ref dfsParam);
}
		if(elementName.ToLower().Equals("fsubmit"))
{
			SubscribeElementEvents_fsubmit(ref dfsParam);
}
		if(elementName.ToLower().Equals("dclose"))
{
			SubscribeElementEvents_dclose(ref dfsParam);
}
		if(elementName.ToLower().Equals("dsubmit"))
{
			SubscribeElementEvents_dsubmit(ref dfsParam);
}
		if(elementName.ToLower().Equals("bsave"))
{
			SubscribeElementEvents_bsave(ref dfsParam);
}
		if(elementName.ToLower().Equals("add"))
{
			SubscribeElementEvents_add(ref dfsParam);
}
		if(elementName.ToLower().Equals("asubmit"))
{
			SubscribeElementEvents_asubmit(ref dfsParam);
}
		if(elementName.ToLower().Equals("fclose"))
{
			SubscribeElementEvents_fclose(ref dfsParam);
}
		if(elementName.ToLower().Equals("budgetadd"))
{
			SubscribeElementEvents_budgetadd(ref dfsParam);
}
		if(elementName.ToLower().Equals("fundclose"))
{
			SubscribeElementEvents_fundclose(ref dfsParam);
}
		if(elementName.ToLower().Equals("aclose"))
{
			SubscribeElementEvents_aclose(ref dfsParam);
}
		if(elementName.ToLower().Equals("mainback"))
{
			SubscribeElementEvents_mainback(ref dfsParam);
}
		if(elementName.ToLower().Equals("frontback"))
{
			SubscribeElementEvents_frontback(ref dfsParam);
}
		if(elementName.ToLower().Equals("add2"))
{
			SubscribeElementEvents_add2(ref dfsParam);
}
		if(elementName.ToLower().Equals("bsubmit"))
{
			SubscribeElementEvents_bsubmit(ref dfsParam);
}
		if(elementName.ToLower().Equals("add1"))
{
			SubscribeElementEvents_add1(ref dfsParam);
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


	public partial class AcDataISpaceD0B6EBB910A44D43A76EF39441A41EF6  : ExtensionActivityBase
	{		
		
		
		private Dictionary<string,  List<Triplet<string, short, short?>>> queryExpressionBindings = 
											new Dictionary<string,  List<Triplet<string, short, short?>>>
		{
							{"0A77E479-49AD-420E-94EF-65936C5187C7", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("NKLICoPiID",0,
														   -1),
								   new Triplet<string, short, short?>("NKLIEI_FacultyName",4,
														   -1),
								   new Triplet<string, short, short?>("NKLIEI_Facultytype",2,
														   -1),
								   new Triplet<string, short, short?>("NKLIEI_Mail",5,
														   -1),
								   new Triplet<string, short, short?>("NKLIEI_Name",3,
														   -1),
								   new Triplet<string, short, short?>("NKLIEI_PhoneNumber",6,
														   -1),
								   new Triplet<string, short, short?>("NKLIEI_ProjectdetailsID",1,
														   -1),
								}
			},
							{"1C8EBE3F-26E7-4988-A4B3-BF7ECE102252", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("RDID",0,
														   -1),
								   new Triplet<string, short, short?>("RDName",1,
														   -1),
								   new Triplet<string, short, short?>("RDUpload",2,
														   -1),
								}
			},
							{"2CBC92A2-065C-4EB9-B516-DD746385C81B", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("EQEquipmentDescription",5,
														   -1),
								   new Triplet<string, short, short?>("EQEquipmentQuantity",6,
														   -1),
								   new Triplet<string, short, short?>("EQEquipmentRateinINR",7,
														   -1),
								   new Triplet<string, short, short?>("EQEquipmentTotalCost",8,
														   -1),
								   new Triplet<string, short, short?>("EQSerialNo",4,
														   -1),
								   new Triplet<string, short, short?>("EquipmentID",0,
														   -1),
								   new Triplet<string, short, short?>("EquipmentName",2,
														   -1),
								}
			},
							{"55ECD9C7-45DE-4437-92D3-8AB6E8C8141D", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("DocumentDetails_Depth",0,
														   -1),
								}
			},
							{"58F56CDF-92BA-4AFC-A025-13E676182234", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("RDID",0,
														   -1),
								   new Triplet<string, short, short?>("RDName",1,
														   -1),
								   new Triplet<string, short, short?>("RDUpload",3,
														   -1),
								}
			},
							{"60083B68-496B-43CC-86D5-0B59F2B10067", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("CoPiID",6,
														   -1),
								   new Triplet<string, short, short?>("DummyInstance",7,
														   -1),
								   new Triplet<string, short, short?>("Email",3,
														   -1),
								   new Triplet<string, short, short?>("FacultyType",0,
														   -1),
								   new Triplet<string, short, short?>("Name",1,
														   -1),
								   new Triplet<string, short, short?>("Role",4,
														   -1),
								   new Triplet<string, short, short?>("UserName",2,
														   -1),
								}
			},
							{"979C2DE5-B549-49E4-8CB4-9F063D649950", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("Bid",0,
														   -1),
								   new Triplet<string, short, short?>("BudgetAmount",2,
														   -1),
								   new Triplet<string, short, short?>("BudgetHead",0,
														   -1),
								   new Triplet<string, short, short?>("ProjectBudgetDetailsid",3,
														   -1),
								}
			},
							{"9AF0475C-F129-4C92-8612-2CB7DC8E22C5", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("NKLICoPiID",0,
														   -1),
								   new Triplet<string, short, short?>("NKLIEI_FacultyName",4,
														   -1),
								   new Triplet<string, short, short?>("NKLIEI_Facultytype",2,
														   -1),
								   new Triplet<string, short, short?>("NKLIEI_Mail",5,
														   -1),
								   new Triplet<string, short, short?>("NKLIEI_Name",3,
														   -1),
								   new Triplet<string, short, short?>("NKLIEI_PhoneNumber",6,
														   -1),
								   new Triplet<string, short, short?>("NKLIEI_ProjectdetailsID",1,
														   -1),
								}
			},
							{"9C4BCE1F-8282-4A65-B694-C716D683886B", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("CoPiID",6,
														   -1),
								   new Triplet<string, short, short?>("DummyInstance",7,
														   -1),
								   new Triplet<string, short, short?>("Email",3,
														   -1),
								   new Triplet<string, short, short?>("FacultyType",0,
														   -1),
								   new Triplet<string, short, short?>("Name",1,
														   -1),
								   new Triplet<string, short, short?>("Role",4,
														   -1),
								   new Triplet<string, short, short?>("UserName",2,
														   -1),
								}
			},
							{"C77CBF47-D3B5-44EE-AF63-91DA2A0F89A5", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("MP_Comment",7,
														   -1),
								   new Triplet<string, short, short?>("MP_Duration",4,
														   -1),
								   new Triplet<string, short, short?>("MP_HRAPer",15,
														   -1),
								   new Triplet<string, short, short?>("MP_ManpowerId",0,
														   -1),
								   new Triplet<string, short, short?>("MP_ManpowerTotalCost",11,
														   -1),
								   new Triplet<string, short, short?>("MP_No",8,
														   -1),
								   new Triplet<string, short, short?>("MP_Position",2,
														   -1),
								   new Triplet<string, short, short?>("MP_ProjectId",1,
														   -1),
								   new Triplet<string, short, short?>("MP_RatePerMonth",9,
														   -1),
								   new Triplet<string, short, short?>("MP_SerialNo",8,
														   -1),
								   new Triplet<string, short, short?>("MP_TotalMonths",10,
														   -1),
								   new Triplet<string, short, short?>("MP_TotalPerMonth",14,
														   -1),
								}
			},
							{"CF752EE8-E742-40ED-9419-07B9622045EE", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("Bid",0,
														   -1),
								   new Triplet<string, short, short?>("BudgetAmount",2,
														   -1),
								   new Triplet<string, short, short?>("BudgetHead",1,
														   -1),
								   new Triplet<string, short, short?>("commentss",18,
														   -1),
								   new Triplet<string, short, short?>("ProjectBudgetDetailsid",3,
														   -1),
								   new Triplet<string, short, short?>("RecurringValidation",4,
														   -1),
								   new Triplet<string, short, short?>("TotalBudget",17,
														   -1),
								   new Triplet<string, short, short?>("Year11",5,
														   -1),
								   new Triplet<string, short, short?>("Year12",6,
														   -1),
								   new Triplet<string, short, short?>("Year13",7,
														   -1),
								   new Triplet<string, short, short?>("Year14",8,
														   -1),
								   new Triplet<string, short, short?>("Year15",9,
														   -1),
								   new Triplet<string, short, short?>("Year16",10,
														   -1),
								   new Triplet<string, short, short?>("Year17",11,
														   -1),
								   new Triplet<string, short, short?>("Year18",12,
														   -1),
								   new Triplet<string, short, short?>("Year19",13,
														   -1),
								   new Triplet<string, short, short?>("Year20",14,
														   -1),
								   new Triplet<string, short, short?>("Year21",15,
														   -1),
								   new Triplet<string, short, short?>("Year22",14,
														   -1),
								}
			},
							{"D9CC73AE-5CF3-45A7-9120-9864A85C89BE", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("Bid",0,
														   -1),
								   new Triplet<string, short, short?>("BudgetAmount",2,
														   -1),
								   new Triplet<string, short, short?>("BudgetHead",1,
														   -1),
								   new Triplet<string, short, short?>("commentss",18,
														   -1),
								   new Triplet<string, short, short?>("ProjectBudgetDetailsid",3,
														   -1),
								   new Triplet<string, short, short?>("RDComments",19,
														   -1),
								   new Triplet<string, short, short?>("RecurringValidation",4,
														   -1),
								   new Triplet<string, short, short?>("Year11",5,
														   -1),
								   new Triplet<string, short, short?>("Year12",6,
														   -1),
								   new Triplet<string, short, short?>("Year13",7,
														   -1),
								   new Triplet<string, short, short?>("Year14",8,
														   -1),
								   new Triplet<string, short, short?>("Year15",9,
														   -1),
								   new Triplet<string, short, short?>("Year16",10,
														   -1),
								   new Triplet<string, short, short?>("Year17",11,
														   -1),
								   new Triplet<string, short, short?>("Year18",12,
														   -1),
								   new Triplet<string, short, short?>("Year19",13,
														   -1),
								   new Triplet<string, short, short?>("Year20",14,
														   -1),
								   new Triplet<string, short, short?>("Year21",15,
														   -1),
								   new Triplet<string, short, short?>("Year22",16,
														   -1),
								}
			},
							{"E0FCE363-3C38-4ED1-AEF4-47B229CAACA2", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("Bid",0,
														   -1),
								   new Triplet<string, short, short?>("BudgetAmount",2,
														   -1),
								   new Triplet<string, short, short?>("BudgetHead",1,
														   -1),
								   new Triplet<string, short, short?>("commentss",18,
														   -1),
								   new Triplet<string, short, short?>("ProjectBudgetDetailsid",3,
														   -1),
								   new Triplet<string, short, short?>("RecurringValidation",4,
														   -1),
								   new Triplet<string, short, short?>("TotalBudget",17,
														   -1),
								   new Triplet<string, short, short?>("Year11",5,
														   -1),
								   new Triplet<string, short, short?>("Year12",6,
														   -1),
								   new Triplet<string, short, short?>("Year13",7,
														   -1),
								   new Triplet<string, short, short?>("Year14",8,
														   -1),
								   new Triplet<string, short, short?>("Year15",9,
														   -1),
								   new Triplet<string, short, short?>("Year16",10,
														   -1),
								   new Triplet<string, short, short?>("Year17",11,
														   -1),
								   new Triplet<string, short, short?>("Year18",12,
														   -1),
								   new Triplet<string, short, short?>("Year19",13,
														   -1),
								   new Triplet<string, short, short?>("Year20",14,
														   -1),
								   new Triplet<string, short, short?>("Year21",15,
														   -1),
								   new Triplet<string, short, short?>("Year22",14,
														   -1),
								}
			},
							{"E59048C6-2310-416E-983E-247A556B3045", 
				
				new List<Triplet<string, short, short?>> {

								   new Triplet<string, short, short?>("Docid",2,
														   -1),
								   new Triplet<string, short, short?>("Document",0,
														   -1),
								   new Triplet<string, short, short?>("UploadDocument",1,
														   -1),
								}
			},
					};	

	

		private Dictionary<string,string> formVersionList =new Dictionary<string,string> 
		{
							{"EB102E80-C3DC-4EB9-8511-B1018E342530", "Medium"},
					};	

		
		private Dictionary<string,string> formVersionLayoutList =new Dictionary<string,string> 
		{
							{"696B154A-AF83-405C-A8A5-E8C24C368DAF", ""},
							{"BD85B480-3681-4AAE-8B2E-8A58D65DF316", ""},
							{"EB102E80-C3DC-4EB9-8511-B1018E342530", ""},
							{"86E854AA-0EC1-4437-A088-B2FB3BDEE419", ""},
							{"50443C0F-4272-4F10-9947-2076FBC01DB1", ""},
							{"213BB6C3-E6C4-424D-B38B-E2E6B5C722D6", ""},
							{"532C82C2-6E19-42D4-8BAF-E677385C6B50", ""},
							{"7FE49062-0C1E-4E96-9A90-FB8036BE629D", ""},
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
		


