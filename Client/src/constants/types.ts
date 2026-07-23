// Innovace Intech Solution Pvt Ltd
export type TDevice = "xs" | "sm" | "md" | "lg";

export interface IList {
  key: string;
  value: string;
}


export interface UIElement {
  VersionName: string;
  Id: number;
  WidgetId?: string;
  ShowCaption: boolean;
  Fontbold?: boolean;
  FontItalic?: boolean;
  FontOverline?: boolean;
  FontStrikeout?: boolean;
  FontUnderline?: boolean;
  Depth: number;
  IsBadge?: boolean;
  ElementId: string;
  UIElementid: string;
  Sequence: number;
  ElementName: string;
  ControlType: string;
  uielementtypeid?: number;
  Wrap: number;
  EnableDFS?: boolean;
  ClearFix: boolean;
  OnDemandLoad: boolean;
  IsLastStep?: boolean;
  EnableValidation?: boolean;
  Buttons?: boolean;
  Legend?: boolean;
  NavigationNumbers?: boolean;
  ControlId: number;
  Searchable?: boolean;
  Bindable?: boolean;
  Action?: string;
  IsSaveWidget: number;
  BindingDetail: string;
  EDT?: number | null;
  DCaption?: string;
  Css?: string;
  MaxValue?: number;
  CurrValue?: number;
  ParentElementId?: string;
  HeaderTemplate?: string;
  MergeRow?: string;
  DHelpText?: string;
  DToolTip?: string;
  IsMultiline?: boolean;
  RenderType?: number;
  ElementControlProperty?: TElementControlProperty[];
  HeadingType?: string;
  UCaption?: string;
  ColumnCss?: string;
  DisplayName?: string;
  TabIndex?: number;
  Content?: string;
  RowsPerPage?: number;
  Toolbars?: string;
  GM?: string;
  ProcessName?: string;
  BorderStyle?: number;
  Width?: number;
  DocumentSettings?:string;
  Visible?: string | boolean;
  
  TabHeaders?: ITabHeader[];
  ActiveTab?: boolean;
  InlineGridData?: UIElement[];

  [key: string]: any;
}

export interface IDocumentSettings {
  Size: number;
  AllowedTypes: string;
}

interface ITabHeader {
  ElementName: string;
  ActiveTab?: boolean;
  uielementid: string;
  uniqueKey: string;  // Add this property
}


export type TElementControlProperty =
  | {
      Mandatory: boolean;
      Span: boolean;
    }
  | {
      Enable: boolean;
      Span: boolean;
    }
  | {
      Visible: boolean;
      Span: boolean;
    };

export interface IExecuteFormLoad {
  executionResult: IExecutionResult[];
}

export interface IExecutionResult {
  controlId?: string;
  controlValue?: IControlValue;
  isGrid: boolean;
  gridValues?: GridValues;
}

interface ITokenDetail {
  displayName: string;
  roleNames: string;
}

export interface IOnActionResponse {
  executionResult?: IExecutionResult[];
  ExecutionResult?: IExecutionResult[];
  Message?: string | null;
  Token?: string;
  TokenDetail?: ITokenDetail;
  [key: string]: unknown;
}

export interface IControlValue {
  id: string;
  vis: string | null;
  value: string | null;
  dVl: string | null;
  man: boolean;
}

export interface GridValues {
  gridControlId: string;
  gridRowId: string;
  gridParentRowId: string | null;
  gridColumn: IGridColumn[];
  rowCount: number;
}

export interface IGridColumn {
  columnControlId: string;
  columnControlValue: IColumnControlValue;
}

export interface IColumnControlValue {
  id: string;
  vis: string | null;
  value: string;
  dVl: string | null;
  man: string | null;
}

export interface IGridRowData {
  rowId: string;
  sequence: number;
  [key: string]: string | number | boolean | null | undefined;
}

export interface IActionParams {
  ElementName: string;
  Value: string;
  EDT:number;
}

export interface IBindingData {
  Endpoint: string;
  HttpVerb: string;
  Port: string;
  Params: string;
  Action?: "OnChange" | "OnLoad" | "OnClick";
}

export interface IFormLoadResponse {
  ElementId: string;
  Value: string;
}

export interface IOnChangeResponse {
  Rows: Row[];
  ExecutionMessage: string | null;
}

export interface Row {
  [key: string]: string;
}

export type TValue = string | boolean | number;

export interface IGlobalStateValues {
  value: TValue;
  required?: boolean;
  type?: string;
  ElementName?: string;
  EDT?: number | null | undefined;
  Value?: any;
  isVisible?:any;
  visible?:any;
  Visible?:any;
  ShowDialog?: boolean;
  HideDialog?: boolean;
  ShowModal?: boolean;
  rElemData?: any;
  Css?: string;
  Enbl?:any;

}

export interface IDocumentValue {
  key: string;
  value: string;
}

export type IUrlFileResponse = IDocumentValue[];

export interface IDeleteDocumentFormData {
  slotId: string;
  documentTypeId: string;
  documentId: string;
  documentNo: string;
}

export interface IGetDocumentIdFormData {
  slotToken: string;
  documentNumber: string;
  versionNo: number;
}

export interface IInlineMultiFile {
  base64Data: string;
  fileName: string;
  fileType: string;
  documentId: string;
  documentNo: string;
}

export interface IAppResponse {
  Rows: ServiceElementData[] | null;
  Message: any;
  FormData: null;
  ExecutionMessage: null;
  EedirectURL: null;
  NavigationType: null;
  TotalRecords: number | null;
              RecordsFrom: number | null;
              RecordsTo: number | null;

}

export interface ServiceElementData {
  ElementId: string; // Controls Identifier
  ElementName: string; // Control Name
  Value: any; // Control Value (Dynamic)
  ShowDialog?: boolean; // True or False. Shows Dialog when set to True
  HideDialog?: boolean; // True or False. Hides Dialog when set to True
  ShowModal?: boolean; // True or False. Opens Modal when set to True
  Ect?: string; // Contains Element's Control type
  EDT?: number | null; // Contains Element's Data type
  Seq?: number; // Contains Sequence especially significant in Grid rows
  Chk?: boolean; // Checked Status of Check box
  Visible?: string | boolean; // Shows or Hides the control
  BaCol?: string; // Holds Back color in Hex
  FCol?: string; // Holds Fore color in Hex
  BrCl?: string; // Holds Border color in Hex
  DCss?: string; // Holds CSS value set in Control property
  Css?: string; // Holds CSS of element set in Smart UI
  Dvl?: Record<string, string>; // Holds DocumentId and Document Name
  RwId?: string; // Row Identifier
  Rwstate?: number; // Row state of Grid (Inserted, Updated, Deleted)
  PeId?: string; // Parent Element Id
  Child?: ServiceElementData[]; // Holds List of Nested elements. Applicable with Grid rows
  PUrl?: string; // Place Holder URL
  Enbl?: string; // Holds True or False. Enables or Disables element
  Man?: boolean; // Show Mandatory symbol against the element
  RedirectType?: typeof RedirectType[keyof typeof RedirectType]; // Holds Internal or External (1 or 2)
  ComboSelectedValue?: string; // Selected Key of Combo box
  RType?: number; // Render type of Control (byte -> number in TS)
  PageCount?: number;
  RecordsFrom?: number;
  RecordsTo?: number;
  TotalRecords?: number;
  Temp?: boolean; // True or False. Indicates if the row is temporary
  [key: string]: any;
}

export interface IDropdownValues {
  key: string;
  value: string;
}

export interface IInlineMultiFile {
  base64Data: string;
  fileName: string;
  fileType: string;
  documentId: string;
  documentNo: string;
}

export interface IPageStateValue {
  ProcessName: string
  PackageProcessMapId: string
  FormVersionId: string
  ProcessActivityMapId: string
}

export const RedirectType = {
  INTERNAL_REDIRECT: "R",
  EXTERNAL_REDIRECT: "RE",
} as const;