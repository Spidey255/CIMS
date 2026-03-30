using System;
namespace CPS.Proof.DFSExtension
{
 public enum ElementAttributeType
    {
         /// <summary>
        /// Represents the default automatic attribute type, which
        /// performs no action on the data elements.
        /// </summary>
        None = 0,

        /// <summary>
        /// Represents the attribute, to set the fore 
        /// color for the data element.
        /// </summary>
        ForeColor = 1,

        /// <summary>
        /// Represents the attribute, to set the back 
        /// color for the data element.
        /// </summary>
        BackColor = 2,

        /// <summary>
        /// Represents the attribute, to set the border 
        /// color for the data element.
        /// </summary>
        BorderColor = 3,

        /// <summary>
        /// Represents the attribute, to set the visibility 
        /// for the data element.
        /// </summary>
        Visible = 4,

        /// <summary>
        /// Represents the attribute, to enable the data element.
        /// </summary>
        Enable = 5,

        /// <summary>
        /// Represents the attribute, that specifies the value expression.
        /// </summary>
        Value = 6,

        /// <summary>
        /// Represents an enum item for SelectedRowId
        /// </summary>
        SelectedRowId = 7,

        /// <summary>
        /// Represents an enum item for Display format.
        /// </summary>
        DisplayFormat = 8,

        /// <summary>
        /// Represents an enum item for Mandatory
        /// </summary>
        Mandatory = 9,

        /// <summary>
        /// Represents an enum item for show dialog
        /// </summary>
        ShowDialog = 10,

        /// <summary>
        /// Represents an enum item for hide dialog
        /// </summary>
        HideDialog = 11,
		
        /// <summary>
        /// Represents an enum item for CSS
        /// </summary>
        CSS = 12,

        /// <summary>
        /// Represents an enum item for show modal
        /// </summary>
        ShowModal=13,


        /// <summary>
        /// Represents an enum item for Pattern
        /// </summary>
        Pattern = 14,


        /// <summary>
        /// Represents an enum item for Pattern
        /// </summary>
        DataKey = 15,
    }

    public enum ViewportTypes : short
    {
        /// <summary>
        /// Enum that represents the FormVersionStyles Mobile object
        /// </summary>
        Mobile = 1,

        /// <summary>
        /// Enum that represents the FormVersionStyles Tab object
        /// </summary>
        Tab = 2,

        /// <summary>
        /// Enum that represents the FormVersionStyles Medium object
        /// </summary>
        Medium = 3,

        /// <summary>
        /// Enum that represents the FormVersionStyles Large object
        /// </summary>
        Large = 4
    }
     /// <summary>
    /// Represents the enum that holds the different
    /// types of a process.
    /// </summary>
    [Serializable]
    public enum ProcessType : byte
    {
        /// <summary>
        /// Represents the none processes.
        /// </summary>
        None = 0,

        /// <summary>
        /// Represents the rule based processes.
        /// </summary>
        RuleBased = 1,

        /// <summary>
        /// Represents the case based processes.
        /// </summary>
        CaseBased = 2,

        /// <summary>
        /// Represents the RSpace processes.
        /// </summary>
        RSpace = 4,

        /// <summary>
        /// Represents the atom UI processes.
        /// </summary>
        AtomUI = 5,

        /// <summary>
        /// Represents the MetaModel processes.
        /// </summary>
        MetaModel = 6,

        /// <summary>
        /// Represents the atom funcional processes.
        /// </summary>
        AtomFunctional = 7,

        /// <summary>
        /// Represents the MasterDetail.
        /// </summary>
        MasterDetail = 8,

        /// <summary>
        /// Represents the API.
        /// </summary>
        API = 9,

        /// <summary>
        /// Represents the ExeorService.
        /// </summary>
        ExeorService = 10,

        /// <summary>
        /// Represents the ReportsorDashboard.
        /// </summary>
        ReportsorDashboard = 11,

        /// <summary>
        /// Represents the Widget.
        /// </summary>
        Widget = 12,

        /// <summary>
        /// Represents the Composite.
        /// </summary>
        Composite = 13

    }

    /// <summary>
    /// Represents an enum for Data Type
    /// </summary>
    public enum DataTypes
    {
        Boolean = 0,
        Byte = 1,
        Character = 13,
        Decimal = 3,
        Double = 4,
        Integer = 5,
        Long = 6,
        Short = 7,
        DateTime = 8,
        String = 9,
        Others = 10,
        ComplexOnetoOne = 11,
        ComplexOnetoMany = 12,
        StringArray = 2,


    }

    public enum FormInstanceCommand
    {
        None = 0,
        AddInstance = 1,
        LoadInstance = 2,
        SubmitInstance = 3,
        AfterSubmitInstance = 4,
        LoadComboDataSource = 5,
        AddGridRow = 6,
        UpdateGridRow = 7,
        DeleteGridRow = 8,
        LoadComplexElement = 9,
        OnChange = 10,
        OnFocus = 11,
        LoadGridDataSource = 12,
        CancelInstance = 13,
        SaveInstance = 14,
        ApplyUi = 15,
        OnClick = 16,
        //CruiseProcessor = 17,
        CommandCruiseProcessor = 17,
        AddSplitInstance = 18,
        MergeSplitInstance = 19,
        LoadChartDataSource = 20,
        BeforeRowAdding = 21,
        AfterRowAdding = 22,
        BeforeRowDeleting = 23,
        AfterRowDeleting = 24,
        AddChildGridRow = 25,
        MoveUp = 26,
        MoveDown = 27,
        Indent = 28,
        Outdent = 29,
        SearchGrid = 30,
        RefreshGrid = 31,
        Paging = 32,
        LoadGroup = 33,
        LoadComboGroupDataSource = 34,
        OnLookupSelected = 35,
        LookupPaging = 36,
        SearchLookup = 37,
        RefreshLookup = 38,
        AddRemoteInstance = 39,
        GetComplexElement = 40,
        SaveRemoteInstance = 41,
        LoadSplitInstance = 42,
        SaveClientData = 43,
        LoadUIContainer = 44,
        SaveAndExit = 45,
        AfterSaveAndExit = 46,
        OnBeforeSave = 47,
        OnAfterSave = 48,
        OnCancel = 49,
        OnSave = 50,
        SystemSaveClientData = 51,
        GetNewInstance = 52,
        AddSubProcessInstance = 53,
        LoadClientData = 54,
        AddChainProcessInstance = 55,
        AddNewInstance = 56,
        DeleteInstance = 57,
        UpdateInstance = 58,
        SetInstanceState = 59,
        AddMultiInstance = 60,
        ReverseSaveClientData = 61,
        ReverseSubmitInstance = 62,
        SplitInstance = 63,
        OnDestinationTo = 64,
        OnAddInstance = 65,
        GetAtomInstance = 66,
        SetAtomInstance = 67,
        ExecuteAtomInstance = 68,
        SaveGridData = 69,
        ViewInstance = 70,
        ViewComplexElement = 71,
        OnRowSelected = 72,
        OnClose = 73,
        CopyRow = 74,
        InsertAt = 75,
        SystemPaging = 76,
        DownloadWordMerge = 77,
        AddAtomInstance = 78,
        LoadAtomInstance = 79,
        SaveSplitFormData = 80,
        ExecuteAPI = 81,
        OnDelete = 82,
        OnSLAFailed = 83,
        SLALoadInstance = 84,
        SLASaveInstance = 85,
        OnIntrim = 86,
        ExecuteBehaviour = 87,
        OnGridLoad = 88,
        SaveGrid = 89,
        OnGridSave = 90,
        PrintAllPDF = 91,
        PrintAllExcel = 92,
        OnGridCancel = 93,
        LoadDataInstance = 94,
        AddCompositeInstance = 95
    }

     /// <summary>
    /// Represents the different status of instances
    /// </summary>
    public enum InstanceCodes : byte
    {    
        None=0,
        Added=1,
        Locked=2,
        Processed=3,
        Unlocked=4,
        Suspended=5,
        Completed=6,
        Aborted=7,
        Held=8,
        Saved=9,
        Splitted=10,
        SplitAdded=11,
        Wait=12,
        Merged=13,
        FreePool=14,
        RollBacked=15,
        FastForwarded=16,
        SystemSave = 17,
        UnderEdit=18,
        Assigned=51,
        Accepted = 52,
        Rejected=53,

    }

    public enum InstanceOperationType : byte
    {
        Added = 1,
        Locked = 2,
        Processed = 3,
        UnLocked = 4,
        Suspended = 5,
        Completed = 6,
        Aborted = 7,
        Held = 8,
        Saved = 9,
        Splitted = 10,
        SplitAdded = 11,
        Wait = 12,
        Merged = 13,
        FreePool = 14,
        RollBacked = 15,
        FastForwarded = 16,
        SystemSave = 17,
        Assigned = 51,
        Accepted = 52,
        Rejected = 53,
        Chaining = 54,
        SubProcessWait = 55
    }

    public enum StateType : byte
    {
        Valid = 1,
        Invalid = 2,
        Error = 3
    }
    public enum FormStatus :byte
    {
       
        /// <summary>
        /// Success
        /// </summary>
        Success = 0,

        /// <summary>
        /// Failure 
        /// </summary>
        Failure,

        /// <summary>
        /// Duplicate data found - 8 steps uses this.
        /// </summary>
        Duplicate,

        /// <summary>
        /// Lock Process/Lock Process instance
        /// </summary>
        LockError,

        /// <summary>
        /// Load Process Instance. If a connection to 
        /// an external database (when a query is executed) fails
        /// this error is returned.
        /// </summary>
        ExternalConnectionError,

        /// <summary>
        /// While executing an external database call like a Trigger
        /// query, if lets say, the tables do not exist, an External
        /// SQL error is returned.
        /// </summary>
        ExternalSQLError,

        /// <summary>
        /// Used for optimistic concurrency implementation of grids
        /// in 8 steps.
        /// </summary>
        ConcurrencyViolation,

        /// <summary>
        /// Used to indicate to the user interface that no 
        /// instance is available for processing.
        /// </summary>
        NoInstanceFound,

        /// <summary>
        /// Used to indicate the user that there are 
        /// instances available for the process.
        /// </summary>
        InstanceFound,

        /// <summary>
        /// Used to indicate to the user that the login
        /// to Document management server failed.
        /// </summary>
        DMSLoginFailed,

        /// <summary>
        /// Used to indicate to the user that all the
        /// rules failed to execute for the activity.
        /// </summary>
        RuleExecutionFailed,

        /// <summary>
        /// Used to indicate to the user that the given limit
        /// for adding an instance has exceeded.
        /// </summary>
        InstanceLimitExceeded,

        /// <summary>
        /// Used to indicate to the user that the given limit
        /// for creating a new process has exceeded.
        /// </summary>
        ProcessLimitExceeded,

        /// <summary>
        /// Used to indicate to the user that the given limit
        /// for creating a new version of the process has exceeded.
        /// </summary>
        VersionLimitExceeded,

        /// <summary>
        /// Used to indicate to the user that the given package
        /// is under going an offline publish.
        /// </summary>
        PackagePublishInProgress = 32,

        /// <summary>
        /// Represents the status that indicates the user limit 
        /// exceeded for named/concurrent users license.
        /// </summary>
        UserLimitExceeded = 34,

        /// <summary>
        /// Represents the status that indicates an evaluation 
        /// license has expired.
        /// </summary>
        EvaluationExpired,

        /// <summary>
        /// Represent the status that indicates the feature is
        /// disabled by license or feature upper limit exceeded.
        /// </summary>
        FeatureDisabled,

        /// <summary>
        /// Represent the status the indicates the Activity not accessible.
        /// </summary>
        ActivityNotAccessible,

        /// <summary>
        /// Represents the status that indicates the validation failure 
        /// for instance data.
        /// </summary>
        ValidationFailed,

        /// <summary>
        /// Represent the status the indicates the whether processid 
        /// selected or not.
        /// </summary>
        NoneProcessId,

        /// <summary>
        /// Represents the status the indicate process is not
        /// defined to package.
        /// </summary>
        ProcessNotDefined,

        /// <summary>
        /// Represents the status indicate select process deleted
        /// successfully
        /// </summary>
        SucessDelete,

        /// <summary>
        /// Represents the status indicate select process deleted
        /// failure
        /// </summary>
        FailureDelete,

        /// <summary>
        /// Represents the status indicate Package is locked.
        /// </summary>
        PackageLocked,

        /// <summary>
        /// Represents the status indicate Package is not well
        /// defined.
        /// </summary>
        PackageNotWellDefined,

        /// <summary>
        /// Represents the status indicate user does not have
        /// right to access.
        /// </summary>
        RightAccessDenied,

        /// <summary>
        /// Indicates that instance is already accepted.
        /// </summary>
        InstanceAlreadyAccepted,

        /// <summary>
        /// Indicates that no data found to process the request
        /// </summary>
        NoDataFound,

        /// <summary>
        /// Indicates Domain data map associated with some
        /// Expressions. So domain data cannot be deleted.
        /// </summary>
        DomainDataMapAssociated,

        /// <summary>
        /// Indicates Prerequisite Required to perform 
        /// the copyProcess operation
        /// </summary>
        PrerequisiteRequired,

        /// <summary>
        /// Indicates the same user already Locked the instance 
        /// </summary>
        InstanceAlreadyLocked,

        /// <summary>
        /// Indicates the same user already Locked the instance 
        /// </summary>
        InstanceAlreadySubmitted,

        /// <summary>
        /// Indicates the Source and Destination process do match
        /// with references during import and merge process
        /// </summary>
        ProcessMismatch,

        /// <summary>
        /// Indicates the Status of process
        /// </summary>
        ProcessLocked,

        /// <summary>
        /// Indicates the Status of Invalid datatype
        /// </summary>
        InvalidDataType = 55,

        /// <summary>
        /// Indicates the Status of Invalid control type
        /// </summary>
        InvalidControlType = 56,

        /// <summary>
        /// Indicates the Status of Invalid name
        /// </summary>
        InvalidName = 57,

        /// <summary>
        /// Indicates the Email not configured for existing user
        /// </summary>
        MailIdNotFound = 58,

        /// <summary>
        /// Indicates newly created 
        /// </summary>
        NewlyCreated = 59,

        /// <summary>
        /// Indicates the Status of the Invalid ElementName
        /// </summary>
        InvalidElementName = 60,

        /// <summary>
        /// Indicates Process-Prerequisite Required to perform 
        /// the Import/Copy operation
        /// </summary>
        ProcessPrerequisiteRequired = 61,

        /// <summary>
        /// Indicates  Activity-Prerequisite Required to perform 
        /// the Import/Copy operation
        /// </summary>
        ActivityPrerequisiteRequired = 62,

        /// <summary>
        /// Indicates  DataElements-Prerequisite Required to perform 
        /// the Import/Copy operation
        /// </summary>
        DataElementsPrerequisiteRequired = 63,

        /// <summary>
        /// Indicates  Rule-Prerequisite Required to perform 
        /// the Import/Copy operation
        /// </summary>
        RulePrerequisiteRequired = 64,

        /// <summary>
        /// Indicates  Duplicate Process Name Warning in 
        /// the Import/Copy operation
        /// </summary>
        DuplicateProcessNameFound = 65,

        /// <summary>
        /// Indicates  Activity Selection Required to perform
        /// the Import operation for Caption Definer
        /// </summary>
        MetaModelPrerequisite = 66,

        /// <summary>
        /// Indicates  Duplicate Local Number or EmailId Warning in
        /// the Import operation for OrganizationUnit
        /// </summary>
        DuplicateLocalNumberorEmailFound = 67,

        /// <summary>
        /// Indicates  Activity not saved
        /// </summary>
        ActivityNotSaved = 68,

        /// <summary>
        /// Indicates  Forking that is mapped with 
        /// the DFS
        /// </summary>
        ForkingCannotBeDeleted = 69,


        /// <summary>
        /// Indicates xml Product Version is 
        /// not allowed to Import process
        /// </summary>
        ProductVersionNotAllowed = 70,
        InvalidFormat = 71,

        /// <summary>
        /// Indicates  TenantDuplication   
        /// </summary>
        TenantCodeDuplicate = 74,

        /// <summary>
        /// Indicates  TenantName Duplication
        /// </summary>
        TenantNameDuplicate = 75,

        /// <summary>
        /// Indicates  Template Reference Failed
        /// </summary>
        TemplateReferenceFailed = 76,

        /// <summary>
        /// Indicates License Failed
        /// </summary>
        LicenseFailed = 77,

        /// <summary>
        /// Indicates  Template Update
        /// </summary>
        update = 78,

        /// <summary>
        /// Indicates  Data already present
        /// </summary>
        DataPresent = 79,

        /// <summary>
        /// Indicates Data already not present
        /// </summary>
        DataNotExists = 80,

        /// <summary>
        /// Indicates the Status to delete primary key
        /// </summary>
        deleteprimarykey = 81,

        /// <summary>
        /// Indicates the Status that 
        /// operation failed in remote machine.
        /// </summary>
        RemoteMachineFailed = 82,

        /// <summary>
        /// Indicates the Status that 
        /// it is aaociated with task
        /// </summary>
        CannotdeleteImportrequirements = 83,

        FileSizeExceeded = 84,

        InvalidFileType = 85


    }


    /// <summary>
    /// Represents an enum that specifies the reason for a process instance 
    /// to get suspended.
    /// </summary>
    public enum FormSuspendedReason : byte
    {
       
        /// <summary>
        /// Specifies that the reason for instance suspension is 
        /// failure of a rule expression.
        /// </summary>
        RuleExecutionFailed,

        /// <summary>
        /// Specifies that the reason for instance suspension is 
        /// failure of saving the data associated with an instance.
        /// </summary>
        InstanceDataSaveFailed,

        /// <summary>
        /// Specifies that the reason for instance suspension is 
        /// failure of saving the documents associated with an instance.
        /// </summary>
        InstanceDocumentsSaveFailed,

      
        /// <summary>
        /// Specifies that the reason for instance suspension is 
        /// failure in loading the data associated with an instance.
        /// </summary>
        InstanceDataLoadFailed,

        /// <summary>
        /// Specifies that the reason for instance suspension is 
        /// failure in loading the documents associated with an instance.
        /// </summary>
        InstanceDocumentsLoadFailed,

        /// <summary>
        /// Specifies that the reason for instance suspension is 
        /// not known.
        /// </summary>
        Unknown,

        /// <summary>
        /// Specifies that a connection to an external database 
        /// (when a query is executed) fails this error is returned.
        /// </summary>
        ExternalConnectionError,

        /// <summary>
        /// While executing an external database call like a Trigger
        /// query, if lets say, the tables do not exist, an External
        /// SQL error is returned.
        /// </summary>
        ExternalSQLError,

       
        /// <summary>
        /// Represents an enum to indicate meta publishing is failed.
        /// </summary>
        MetaDataPublishingFailed,

        /// <summary>
        /// Represents an enum to indicate illegal user input.
        /// </summary>
        IllegalUserInput,
    }

     public enum ValidationFlag : byte
    {
        Valid = 1,
        Invalid = 2,
        Error = 3
    }
}