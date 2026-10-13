#region Header
// --------------------------------------------------------------------------------------
// <copyright file="ISpace.cs" company="Cognitive Platform Solutions Pvt Ltd">
// Reproduction or transmission, in whole or in part, in any form or 
// by any means including electronic or mechanical or otherwise, is 
// prohibited without written permission from Cognitive Platform Solutions Pvt Ltd.
// </copyright>
// ---------------------------------------------------------------------------------------
#endregion


using System.IO;
using System.Xml;
using System.Web;
using System.Xml.Linq;
using System.Resources;
using System.Threading;     
using System.Transactions;


namespace CPS.Proof.DFSExtension
{
    using System;
    using log4net;
    using System.Collections.Generic;
    using System.Linq;  
    using System.Data; 
    using System.Threading.Tasks;
    using SRA.Proof.Common;
    using System.Text.RegularExpressions;
    using System.Runtime.Serialization.Formatters.Binary;
    using System.Configuration;
    using Newtonsoft.Json;    
    using System.Globalization;
    using Newtonsoft.Json.Linq;
    using SRA.Proof.Helpers;
    using SRA.Proof.Middleware;
    using Chilkat;

    // ReSharper disable once InconsistentNaming
    public class ISpace : CPS.Proof.DFSExtension.IISpace
    {

        /// <summary>
        /// Member variable for Log instance
        /// </summary>
        private readonly ILog _log;       

         private int _gridPageCount;

        private int _gridtotalRows;

        public ISpace()
        {
            _log = LogManager.GetLogger(GetType());
        }

        /// <summary>
        /// Represents the method that gets the attribute type based on 
        /// given property.
        /// </summary>
        /// <param name="property">
        /// A <see cref="string"/> that holds property string.
        /// </param>
        /// <returns>
        /// Returns ElementAttributeType
        /// </returns>
        private ElementAttributeType GetAttributeType(string property)
        {
            ElementAttributeType attributeType = ElementAttributeType.None;

            switch (property.ToLower())
            {
                case "backcolor":
                    attributeType = ElementAttributeType.BackColor;
                    break;

                case "forecolor":
                    attributeType = ElementAttributeType.ForeColor;
                    break;

                case "bordercolor":
                    attributeType = ElementAttributeType.BorderColor;
                    break;

                case "enable":
                    attributeType = ElementAttributeType.Enable;
                    break;

                case "visible":
                    attributeType = ElementAttributeType.Visible;
                    break;

                case "mandatory":
                    attributeType = ElementAttributeType.Mandatory;
                    break;

                case "css":
                    attributeType = ElementAttributeType.CSS;
                    break;

                case "dcss":
                    attributeType = ElementAttributeType.CSS;
                    break;

                case "displayformat":
                    attributeType = ElementAttributeType.DisplayFormat;
                    break;

                case "showdialog":
                    attributeType = ElementAttributeType.ShowDialog;
                    break;

                case "hidedialog":
                    attributeType = ElementAttributeType.HideDialog;
                    break;

                case "showmodal":
                    attributeType = ElementAttributeType.ShowModal;
                    break;

            }

            return attributeType;
        }

         /// <summary>
        /// Represents a method the sets property and value to control.
        /// </summary>
        /// <param name="elementName">
        /// A <see cref="string"/> that represents element name.
        /// </param>
        /// <param name="property">
        /// A <see cref="string"/> that represents property name.
        /// </param>
        /// <param name="controlValue">
        /// A <see cref="string"/> that represents the property value.
        /// </param>
        /// <param name="iSpace">
        /// A <see cref="Dictionary{String,Object}"/> that represents the Dictionary of ServiceElementData
        /// </param>
        public void SetControlProperty(string elementName,
         string property, object controlValue,ref Dictionary<string,ServiceElementData> iSpace)
        {
            _log.Debug("Entering SetControlProperty");
            if (property.ToLower() == "backcolor" || property.ToLower() == "forecolor" || property.ToLower() == "bordercolor")
            {
                controlValue = string.Concat("#", controlValue);                
            }
            ElementAttributeType attributeType = ElementAttributeType.None;
            try
            {
                _log.DebugFormat("Data for SetControlProperty -{0},{1},{2}",
                    elementName, property, controlValue);

                if (string.IsNullOrEmpty(property))
                {
                    _log.ErrorFormat("Attribute property is null for {0}", elementName);

                    return;
                }

                if (controlValue == null)
                {
                    _log.ErrorFormat("Value is null for {0}", elementName);

                    return;
                }

                if (string.IsNullOrEmpty(elementName))
                {
                    _log.Error("Element Name is null");

                    return;
                }

                attributeType = GetAttributeType(property);

               
                var control = iSpace[elementName];

                if (control == null)
                {
                    _log.ErrorFormat("Element not found {0}", elementName);

                    return;
                }

                switch (attributeType)
                {
                    case ElementAttributeType.ForeColor:
                        iSpace[elementName].FCol = controlValue.ToString();
                        break;
                    case ElementAttributeType.BackColor:
                        iSpace[elementName].BaCol = controlValue.ToString();
                        break;
                    case ElementAttributeType.BorderColor:
                        iSpace[elementName].BrCl = controlValue.ToString();
                        break;
                    case ElementAttributeType.Enable:
                        iSpace[elementName].Enbl = controlValue.ToString();
                        break;
                    case ElementAttributeType.Visible:
                        iSpace[elementName].Visible = controlValue.ToString();
                        break;
                    case ElementAttributeType.Mandatory:
                        iSpace[elementName].Man = Convert.ToBoolean(controlValue);
                        break;
                    case ElementAttributeType.CSS:
                        iSpace[elementName].DCss = controlValue.ToString();
                        break;
                    //case ElementAttributeType.Pattern:
                    //    control.pa = controlValue.ToString();
                    //    break;
                    case ElementAttributeType.ShowDialog:
                        iSpace[elementName].ShowDialog = Convert.ToBoolean(controlValue);
                        break;
                    case ElementAttributeType.ShowModal:
                        iSpace[elementName].ShowModal = Convert.ToBoolean(controlValue);
                        break;
                    //case ElementAttributeType.HideDialog:
                    //    control.HideDialog = Convert.ToBoolean(controlValue);
                    //    break;
                    //case ElementAttributeType.DataKey:
                    //    control.DataKey = controlValue.ToString();
                    //    break;
                    //case ElementAttributeType.DisplayFormat:
                    //    control.DisplayFormat = controlValue.ToString();
                    //    break;
                    default:
                        break;
                }

            }
            catch (Exception ex)
            {
                _log.Error("Error in SetControlProperty", ex);
            }
            finally
            {
                _log.Debug("Exiting SetControlProperty");
            }

        }

        /// <summary>
        /// Represents a method the sets property and value to UI control.
        /// </summary>
        /// <param name="elementName">
        /// A <see cref="string"/> that represents element name.
        /// </param>
        /// <param name="property">
        /// A <see cref="string"/> that represents property name.
        /// </param>
        /// <param name="value">
        /// A <see cref="string"/> that represents the property value.
        /// </param>
        /// <param name="ISpace">
        /// A <see cref="Dictionary{String, Object}"/> that represents ISpace object.
        /// </param>  
        public void SetUIControlProperty(string elementName,
            string property, object value,ref Dictionary<string,ServiceElementData> ISpace)
        {
            try
            {
                _log.Debug("Entering SetUIControlProperty");

                SetControlProperty(elementName, property, value,ref ISpace);

            }
            catch (Exception ex)
            {
                _log.Error("Error in SetUIControlProperty", ex);
            }
            finally
            {
                _log.Debug("Exiting SetUIControlProperty");
            }
        }


        #region Grid functions

        public object Sum(string gridTable,string gridcolumn, string filter,string instanceId)
        {
            IExternalQueryController externalQueryController = null;

            try
            {
                externalQueryController = ObjectManager.Acquire<IExternalQueryController>();

                object aggValue=null;

                externalQueryController.AggregateGridData
                (gridTable,gridcolumn,"Sum", filter,instanceId,out aggValue);

                return aggValue;
            }
            catch (Exception ex)
            {
                return null;
            }
             finally
            {
                if (externalQueryController != null)
                {
                    ObjectManager.Release(externalQueryController);
                }
            }
        }

        public object Count(string gridTable, string gridcolumn, string filter, string instanceId)
        {
            IExternalQueryController externalQueryController = null;

            try
            {
                externalQueryController = ObjectManager.Acquire<IExternalQueryController>();

                object aggValue = null;

                externalQueryController.AggregateGridData
                (gridTable, gridcolumn, "Count", filter, instanceId, out aggValue);

                return aggValue;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (externalQueryController != null)
                {
                    ObjectManager.Release(externalQueryController);
                }
            }
        }

        public object AVG(string gridTable, string gridcolumn, string filter, string instanceId)
        {
            IExternalQueryController externalQueryController = null;

            try
            {
                externalQueryController = ObjectManager.Acquire<IExternalQueryController>();

                object aggValue = null;

                externalQueryController.AggregateGridData
                (gridTable, gridcolumn, "AVG", filter, instanceId, out aggValue);

                return aggValue;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (externalQueryController != null)
                {
                    ObjectManager.Release(externalQueryController);
                }
            }
        }

       
        #endregion


        public DataTable SetGridDataSource(Dictionary<string,string> querySourceDetails,int gridRowsPerPage, string query)
        {
           

            string connectionId = string.Empty;

            IExternalQueryController externalQueryController = null;

            //Getting the grid data source
            DataTable queryResults = null;

            _gridPageCount = gridRowsPerPage;

            try
            {

                connectionId = querySourceDetails.Select
                            (item => item.Value).FirstOrDefault();


                string proofConnectionId = querySourceDetails.Select
                     (item => item.Key).FirstOrDefault();

                var connectionString = GetAppConnectionString
                    (proofConnectionId, connectionId);


                if (connectionString == null)
                {
                    _log.Error("Connection String is null or empty");

                    _log.Error("Exiting ExecuteHttpRequest");

                    return null;
                }

                externalQueryController =

                   ObjectManager.Acquire<IExternalQueryController>();

                query = System.Text.RegularExpressions.Regex.Replace(query, "[^\x20-\x7F]+", " ");

                externalQueryController.GetGridDataSource
                    (connectionString, query, out queryResults);

                if(queryResults==null)
                    return queryResults;

                 _gridtotalRows= queryResults.Rows.Count;   

                 return queryResults;                          


            }
            catch (Exception ex)
            {
                _log.Error("Error in GetGridDataSource",ex);

                return null;
            }
            finally
            {
                if (externalQueryController != null)
                {
                    ObjectManager.Release<IExternalQueryController>(externalQueryController);
                }

            }
        }


        public Dictionary<short, object> ExecuteQuery
              (Dictionary<string,string> querySourceDetails, string query, bool? isLookup)
        {


            string connectionId = string.Empty;

            IExternalQueryController externalQueryController = null;

            Dictionary<short, object> queryResults = null;

            try
            {               

                connectionId = querySourceDetails.Select
                            (item => item.Value).FirstOrDefault();


                string proofConnectionId = querySourceDetails.Select
                     (item => item.Key).FirstOrDefault();

                var connectionString = GetAppConnectionString
                    (proofConnectionId, connectionId);


                if (connectionString == null)
                {
                    _log.Error("Connection String is null or empty");
                                        
                    return null;
                }

                externalQueryController =

                   ObjectManager.Acquire<IExternalQueryController>();

                query = System.Text.RegularExpressions.Regex.Replace(query, "[^\x20-\x7F]+", " ");

                externalQueryController.ExecuteQuery
                    (connectionString.Connection, query, out queryResults);


                return queryResults;

            }
            catch (Exception ex)
            {
                _log.Error("Error in ExecuteQuery",ex);

                return null;
            }
            finally
            {
                if (externalQueryController != null)
                {
                    ObjectManager.Release<IExternalQueryController>(externalQueryController);
                }

            }
        }

        //Retrives Application Connectionstring By ConnectionId
        //from Redis Cache
        private ConnectionString GetAppConnectionString
            (string proofConnectionId, string appConnectionId)
        {
            IExternalQueryController appConnectionStrings = null;

            try
            {


                appConnectionStrings = ObjectManager.Acquire<IExternalQueryController>();

                if (appConnectionStrings == null)
                {

                    return null;
                }

                return appConnectionStrings.ConnectionById
                    (proofConnectionId, appConnectionId);
            }
            catch
            {
                return null;
            }
            finally
            {
                if (appConnectionStrings != null)
                    ObjectManager.Release<IExternalQueryController>(appConnectionStrings);
            }
        }

         /// <summary>
        /// Represents the method that set the grid data to 
        /// the respective columns.
        /// </summary>
        /// <param name="queryresult">
        /// A <see cref="DataTable"/> that represents the quary expression id.
        /// </param>
        /// <param name="bindings">
        /// A list of triplets. Each triplet contains:
        /// - a <see cref="string"/> FirstValue,
        /// - a <see cref="short"/> Second Value,
        /// - a nullable <see cref="short"/> Third Value
        /// </param>
        /// <param name="elementId">
        /// A <see cref="string"/> that represents ElementId.
        /// </param>
        /// <param name="ISpace">
        /// A <see cref="Dictionary{String, Object}"/> that represents ISpace object.
        /// </param>
        /// <returns>
        /// Nothing
        /// </returns>
        public void SetGridData(DataTable queryresult,
                   List<Triplet<string, short, short?>> bindings, string elementName, 
                   ref Dictionary<string, ServiceElementData> ISpace)
        {
            _log.Debug("Entering SetGridData");

            try
            {

                ServiceElementData serviceElementData = null;

                if(ISpace.ContainsKey(elementName))
                {
                    serviceElementData = ISpace[elementName];
                }
                else

                    serviceElementData=new ServiceElementData { ElementName = elementName  };

                serviceElementData.Child = new List<ServiceElementData>();

                short rowsequence = 1;

                if (queryresult != null)
                foreach (DataRow row in queryresult.Rows)
                {

                    var rowItem = new ServiceElementData();

                    rowItem.Child = new List<ServiceElementData>();

                     if (row.Table.Columns.Contains("RowId") &&
                                    row["RowId"] != DBNull.Value &&
                                        !string.IsNullOrWhiteSpace(row["RowId"].ToString()))
                        {
                            rowItem.RwId = row["RowId"].ToString();
                           
                        }
                        else
                        {
                            rowItem.RwId = Guid.NewGuid().ToString();
                           
                        }

                    var indexer = bindings.GetEnumerator();

                    while (indexer.MoveNext())
                    {                     

                        var gridcolumn = new ServiceElementData();

                        gridcolumn.ElementName = indexer.Current.FirstValue;

                        gridcolumn.Value = row[indexer.Current.SecondValue];

                        rowItem.Child.Add(gridcolumn);                        

                    }

                    rowItem.SEQ = rowsequence;

                    serviceElementData.Child.Add(rowItem);

                    rowsequence++;
                }

                if (ISpace == null)
                    ISpace = new Dictionary<string, ServiceElementData>();

                if (ISpace.ContainsKey(elementName))
                {
                    ISpace[elementName] = serviceElementData;
                }
                else
                {
                    ISpace.Add(elementName, serviceElementData);
                }

                ISpace[elementName].PageCount = _gridPageCount;

                ISpace[elementName].TotalRecords = _gridtotalRows;

            }
            catch (Exception ex)
            {
                _log.Error("Error in  SetGridData",ex);
            }
        }

         public bool GetGridTableRows(string gridName,string gridQuery, 
            ref Dictionary<string, ServiceElementData> ISpace)
        {
            IExternalQueryController externalQueryController = null;

            DataTable queryResults = null;

            _log.Debug("Entering GetGridTableRows Method");

            try
            {

                externalQueryController=ObjectManager.Acquire<IExternalQueryController>();

                var hasRows = externalQueryController.GetGridLoopData
                    (gridQuery, out queryResults);

                if (hasRows)
                {

                    SetLoopGridDataSource(gridName,
                                queryResults, ref  ISpace);
                }

                return hasRows;
            }
            catch (Exception ex)
            {
                _log.Error("Error in GetGridTableRows Method", ex);

                return false;
            }
            finally
            {
                if (externalQueryController != null)
                    ObjectManager.Release<IExternalQueryController>(externalQueryController);

                _log.Debug("Exiting GetGridTableRows Method");
            }
        }

         private bool SetLoopGridDataSource(string gridName,
            DataTable queryresult, ref Dictionary<string, ServiceElementData> ISpace)
        {


            try
            {

                ServiceElementData serviceElementData = null;

                if (ISpace.ContainsKey(gridName))
                {
                    serviceElementData = ISpace[gridName];
                }
                else

                    serviceElementData = new ServiceElementData { ElementName = gridName };

                serviceElementData.Child = new List<ServiceElementData>();

                short rowsequence = 1;

                if (queryresult != null)
                    foreach (DataRow row in queryresult.Rows)
                    {

                        var rowItem = new ServiceElementData();

                        rowItem.Child = new List<ServiceElementData>();

                        if (row.Table.Columns.Contains("RowId") &&
                                    row["RowId"] != DBNull.Value &&
                                        !string.IsNullOrWhiteSpace(row["RowId"].ToString()))
                            rowItem.RwId = row["RowId"].ToString();
                        else
                            rowItem.RwId = Guid.NewGuid().ToString();                                                                

                            

                        foreach (DataColumn column in row.Table.Columns)
                        {

                            var gridcolumn = new ServiceElementData();

                            gridcolumn.ElementName = column.ColumnName as string;

                            gridcolumn.Value=row[column];

                            rowItem.Child.Add(gridcolumn);
                        }

                      

                        rowItem.SEQ = rowsequence;

                        serviceElementData.Child.Add(rowItem);

                        rowsequence++;
                    }

                if (ISpace == null)
                    ISpace = new Dictionary<string, ServiceElementData>();

                if (ISpace.ContainsKey(gridName))
                {
                    ISpace[gridName] = serviceElementData;
                }
                else
                {
                    ISpace.Add(gridName, serviceElementData);
                }

                return true;
            }
            catch (Exception ex)
            {
                _log.Error("Error in  SetLoopGridDataSource", ex);
                
                return false;

            }
        }


        public void GetLoopExpressionData(string gridName, ref Dictionary<string, ServiceElementData> ISpace)
        {
            _log.Debug("Entering GetLoopExpressionData");

            
            try
            {

                var grdBindingDetails = GetGridBindDetails(gridName);

                DataTable loopResultTestGrid = SetGridDataSource(grdBindingDetails.QuerySourceDetails,
                    -1, grdBindingDetails.GridQuery);

                SetGridData(loopResultTestGrid, grdBindingDetails.QueryExpressionBinding, gridName, ref ISpace);
             
            }
            catch (Exception ex)
            {
                _log.Error("Error in  GetLoopExpressionData", ex);
            }
            
        }

         /// <summary>
        /// Represents the method that set the grid data to 
        /// the respective columns.
        /// </summary>
        /// <param name="queryresult">
        /// A <see cref="DataTable"/> that represents the quary expression id.
        /// </param>
        /// <param name="bindings">
        /// A list of triplets. Each triplet contains:
        /// - a <see cref="string"/> FirstValue,
        /// - a <see cref="short"/> Second Value,
        /// - a nullable <see cref="short"/> Third Value
        /// </param>
        /// <param name="gridName">
        /// A <see cref="string"/> that represents gridName.
        /// </param>
        /// <param name="ISpace">
        /// A <see cref="Dictionary{String, Object}"/> that represents ISpace object.
        /// </param>
        /// <returns>
        /// Nothing
        /// </returns>
        public void SetLoopExpressionData(string gridName,string gridId,int gridRPP,string bulkInsertQuery,
            ref Dictionary<string, ServiceElementData> ISpace)
        {
            _log.Debug("Entering SetLoopExpressionData");

            IExternalQueryController externalQueryController = null;

            try
            {                            

                externalQueryController = 
                    ObjectManager.Acquire<IExternalQueryController>();              

                externalQueryController.UpdateGridLoopData(bulkInsertQuery);
                               
                if (ISpace[gridName].Child != null)
                {

                    if (ISpace[gridName].Child.Count > gridRPP)
                    {
                        ISpace[gridName].Child.RemoveRange(gridRPP,
                                ISpace[gridName].Child.Count - gridRPP);
                    }
                }

               
            }
            catch (Exception ex)
            {
                _log.Error("Error in  SetLoopExpressionData", ex);
            }
            finally
            {
                ObjectManager.Release<IExternalQueryController>(externalQueryController);
            }
        }

        
        public List<Dictionary<string,object>> Reload
                (string rElementName,string elementQuery,string connectionId)
        {
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            
            
            IExternalQueryController externalQueryController = null;

            DataTable queryResults = null;

            try
            {
                var proofConnectionId = AppParams.GetAppValue("ProofConnectionName");

                var connectionString = GetAppConnectionString
                   (proofConnectionId, connectionId);

                externalQueryController =

                   ObjectManager.Acquire<IExternalQueryController>();
                elementQuery = System.Text.RegularExpressions.Regex.Replace(elementQuery, "[^\x20-\x7F]+", " ");

                var status=externalQueryController.ExecuteQuery
                    (connectionString.Connection, elementQuery, out queryResults);

                if (status == Status.Success)
                {
                    foreach (DataRow dr in queryResults.Rows)
                    {
                        Dictionary<string, object>  keyValuePairs = new Dictionary<string, object>();

                        foreach (DataColumn col in queryResults.Columns)
                        {
                            if(keyValuePairs.ContainsKey(col.ColumnName))
                                keyValuePairs[col.ColumnName] = dr[0].ToString();
                            else
                                keyValuePairs.Add(col.ColumnName, dr[col]);
                        }

                        rows.Add(keyValuePairs);
                    }

                   return rows;
                }

                return rows;
            }
            catch
            {
                return null;
            }
        }

         public void InsertGridBindDetails(string gridName, string gridId,
            Dictionary<string, string> querySourceDetails, string gridQuery,int gridRPP)
        {
            
            _log.Debug("Entering InsertGridBindDetails Method");

            try
            {
                GridBindDetails gridBindDetails = new GridBindDetails();

                gridBindDetails.GridName = gridName;

                gridBindDetails.GridQuery = gridQuery;  

                gridBindDetails.QuerySourceDetails = querySourceDetails;

                gridBindDetails.GridRPP = gridRPP;

                if(IISpace.lstGridBindDetails != null)               
                    IISpace.lstGridBindDetails.RemoveAll(obj=>obj.GridName==gridName);  
                else
                    IISpace.lstGridBindDetails = new List<GridBindDetails>();                

                IISpace.lstGridBindDetails.Add(gridBindDetails);
                
                _log.Debug("Exiting InsertGridBindDetails Method");
                
            }
            catch (Exception ex)
            {
                _log.Error("Error in InsertGridBindDetails Method", ex);

                
            }
        }

         public void UpdateGridBindDetails(string gridName,
                        List<Triplet<string, short, short?>> queryExpressionBinding)
        {

            _log.Debug("Entering UpdateGridBindDetails Method");

            try
            {

                foreach(var gridBinding in IISpace.lstGridBindDetails)
                {
                    if(gridBinding.GridName==gridName)
                    {
                        gridBinding.QueryExpressionBinding = queryExpressionBinding;
                    }
                }               

                _log.Debug("Exiting UpdateGridBindDetails Method");

            }
            catch (Exception ex)
            {
                _log.Error("Error in UpdateGridBindDetails Method", ex);

            }

        }


        private GridBindDetails GetGridBindDetails(string gridName)
        {
            _log.Debug("Entering GetGridBindDetails Method");

            GridBindDetails gridBindDetails = null;

            try
            {

                foreach(var gridBindItem in IISpace.lstGridBindDetails)
                {
                    if(gridBindItem.GridName == gridName)
                    {
                        gridBindDetails = new GridBindDetails();

                        gridBindDetails.GridName = gridName;

                        gridBindDetails.GridQuery = gridBindItem.GridQuery;

                        gridBindDetails.QuerySourceDetails = gridBindItem.QuerySourceDetails;

                        gridBindDetails.QueryExpressionBinding = gridBindItem.QueryExpressionBinding;

                        gridBindDetails.GridRPP=gridBindItem.GridRPP;

                        gridBindDetails.GridId=gridBindItem.GridId;
                    }
                }

                               

                _log.Debug("Exiting GetGridBindDetails Method");

                return gridBindDetails;
            }
            catch (Exception ex)
            {
                _log.Error("Error in GetGridBindDetails Method", ex);

                return null;
            }
        }

        public void Redirectpermanent(ref Dictionary<string, ServiceElementData> ISpace, string url)
        {
            if (!ISpace.ContainsKey("RedirectUrl"))
                ISpace.Add("RedirectUrl", new ServiceElementData { Value = string.Empty });

            ISpace["RedirectUrl"].RedirectType = "RP";

            ISpace["RedirectUrl"].Value = url;
        }

        public void RedirectNewWindow(ref Dictionary<string, ServiceElementData> ISpace, string url)
        {
            if (!ISpace.ContainsKey("RedirectUrl"))
                ISpace.Add("RedirectUrl", new ServiceElementData { Value = string.Empty });

            ISpace["RedirectUrl"].RedirectType = "RNW";

            ISpace["RedirectUrl"].Value = url;
        }

        public void RedirectExternal(ref Dictionary<string, ServiceElementData> ISpace, string url)
        {
            if (!ISpace.ContainsKey("RedirectUrl"))
                ISpace.Add("RedirectUrl", new ServiceElementData { Value = string.Empty });

            ISpace["RedirectUrl"].RedirectType = "RE";

            ISpace["RedirectUrl"].Value = url;
        }

        public void Redirect(ref Dictionary<string, ServiceElementData> ISpace, string url)
        {
            if (!ISpace.ContainsKey("RedirectUrl"))
                ISpace.Add("RedirectUrl", new ServiceElementData { Value = string.Empty });

            ISpace["RedirectUrl"].RedirectType = "R";

            ISpace["RedirectUrl"].Value = url;
        }

         public Status AddNewInstance(string forkId, 
            string parentInstanceId,string processactivitymapid,string slotId,ForkedProcess forkedProcess)
        {
            _log.Debug("Entering AddNewInstance");

            FormSuspendedReason outErrMsg = FormSuspendedReason.Unknown;

            //Assign default value for explicit transaction 
            ITransactionBase transactionBase = null;

            ICommon common = null;

            try
            {
                PageContext pageContext = new PageContext();

                pageContext.SlotId = slotId;

                pageContext.GenerateInstanceName = true;

                pageContext.InstanceCommand = FormInstanceCommand.AddInstance;

                //Get Transaction Object from ObjectManager
                transactionBase = ObjectManager.Acquire<ITransactionBase>();

                //Create transaction instance of type TransactionObject
                pageContext.TransactionObject = transactionBase.CreateTransactionInstance();

                var InstanceContext = new FormInstanceInfo
                {
                    InsCmd = "AddInstance",

                    PPM = forkedProcess.FrkPrcId,

                    //FV = forkedProcess.FrmFVId,

                    PamId = forkedProcess.FrkActMapId,

                    MFId = forkedProcess.MFId,

                    ElmId = forkedProcess.MFId,

                    IDesc = "From System",

                    InsId=forkedProcess.NewInstanceId,

                    PInsId=parentInstanceId
                };

                pageContext.InstanceContext = InstanceContext;

                common = ObjectManager.Acquire<Common>();

                var token = common.Authorize(slotId,null);

                common.CallRemoteAPI(token, null, ref pageContext);


                //Assign the Generated InstanceId
               var newinstanceid = pageContext.InstanceContext.InsId;

                if (pageContext.Status == FormStatus.Failure)
                {
                    outErrMsg = pageContext.SuspendedReason;

                    return Status.Failure;
                }

                InserttoMappedElements(token, 
                    forkedProcess.InsertQuery, parentInstanceId,processactivitymapid);

                return Status.Success;
            }
            catch (Exception ex)
            {
                _log.Error("Error in AddNewInstance");

                return Status.Failure;
            }
            finally
            {
                if (transactionBase != null)
                    ObjectManager.Release<ITransactionBase>(transactionBase);

                if (common != null)
                    ObjectManager.Release<ICommon>(common);
                _log.Debug("Exiting AddNewInstance");
            }
        }


         public int GetGridColumnIndex(List<ServiceElementData> gridrow,string gridColumnName)
        {
            return gridrow.FindIndex(c => c.ElementName == gridColumnName);
        }

        private Status InserttoMappedElements(SlotToken token, 
            string insertQuery,string instanceId,string processactivitymapid)
        {
            IExternalQueryController externalQueryController = null;

            _log.Debug("Entering InserttoMappedElements");

            try
            {
                externalQueryController = ObjectManager.Acquire<IExternalQueryController>();

                externalQueryController.SaveForkedInstanceData
                    (token,insertQuery, instanceId, processactivitymapid);

                return Status.Success;
            }
            catch (Exception ex)
            {
                _log.Error("Error in InserttoMappedElements", ex);

                return Status.Failure;
            }
            finally
            {
                _log.Debug("Exiting InserttoMappedElements");

                if(externalQueryController != null)
                {
                    ObjectManager.Release(externalQueryController);
                }
            }
        }

        #region RESTAPI

        /// <summary>
        /// Represents the method that is used to execute the http 
        /// request.
        /// </summary>
        /// <param name="expressionId"></param>
        /// <param name="requestFields"></param>
        /// <returns></returns>
        public bool ExecuteHttpRequest(Dictionary<string,string> querySourceDetails,  string expressionId,
            ref List<RequestFieldElements> requestFields,out string responseString)
        {
            _log.Debug("Entering ExecuteHttpRequest");

            responseString = string.Empty;

            try
            {
               

                    if (string.IsNullOrWhiteSpace(expressionId))
                        return false;

                  
                    string connectionId = querySourceDetails.Select
                        (item => item.Value).FirstOrDefault();

                    string proofConnectionId = querySourceDetails.Select
                         (item => item.Key).FirstOrDefault();

                    var connectionString = GetAppConnectionString
                        (proofConnectionId, connectionId);


                    if (connectionString == null)
                    {
                        _log.Error("Connection String is null or empty");

                        _log.Error("Exiting ExecuteHttpRequest");

                        return false;
                    }

                  
                        var requestObject = new HttpRequest();

                        requestObject.RequestFields = requestFields;

                        requestObject.Template = connectionString.Template;

                        requestObject.Domain = connectionString.HostName;

                        requestObject.Port = connectionString.Port;

                        requestObject.CharSet = (connectionString.ConnectionType == ConnectionTypes.WebServices ||
                        connectionString.ConnectionType == ConnectionTypes.WCF) ? "utf-8" : "";

                        requestObject.ContentType = connectionString.ContentType;

                        requestObject.RequestPath = connectionString.Connection;

                        if (connectionString.ConnectionType == ConnectionTypes.WebServices)

                            requestObject.SoapAction = string.Format("{0}#{1}", connectionString.NameSpace, connectionString.MethodName);

                        else if (connectionString.ConnectionType == ConnectionTypes.REST)

                            requestObject.SoapAction = connectionString.MethodName;

                        requestObject.ConnectionType = connectionString.ConnectionType;

                        requestObject.RequestType = connectionString.RequestType;

                        requestObject.RequireAuthentication = connectionString.RequireAuthentication;

                        requestObject.HasRequestBody = connectionString.HasRequestBody;

                        requestObject.UserName = connectionString.UserName;

                        requestObject.Password = connectionString.Password;

                        requestObject.TransportLayeredService = connectionString.TransportLayeredService;

                        requestObject.AutoReconnect = connectionString.AutoReConnect;

                        requestObject.IdleTimeOutMs = connectionString.IdleTimeouts;

                        requestObject.ErrorCodes = connectionString.ErrorCodes;

                        requestObject.SuccessCodes = connectionString.SuccessCodes;

                        requestObject.IsAsync = connectionString.IsAsync;

                        requestObject.Retries = connectionString.Retries;

                        requestObject.RetryInterval = connectionString.RetryInterval;

                      
                        HttpResponse responseObj;

                        var status = ExecuteRestRequest(requestObject, out responseObj);

                        if (status ==false|| responseObj == null)
                            return false;

                        if (string.IsNullOrWhiteSpace(responseObj.ResponseString))
                            return false;

                        responseString= responseObj.ResponseString;

                      
                    return true;
                
            }
            catch (Exception ex)
            {
                _log.Error("Error in ExecuteHttpRequest", ex);

                return false;
            }
            finally
            {
                _log.Error("Exiting ExecuteHttpRequest");
            }
        }

        /// <summary>
        /// Represents a method to execute query and to get
        /// result set.
        /// </summary>
        /// <param name="queryPath">
        /// A <see cref="string"/> representing
        /// the expression id.
        /// </param>
        /// <param name="queryExpressionId">
        /// A <see cref="string"/> representing the 
        /// parsed query string.
        /// </param>
        /// <param name="bindingType"></param>
        /// <returns></returns>
        public object GetBindingElementValue(string queryValue,string queryPath,
            string queryExpressionId,
            byte? bindingType)
        {
            try
            {
                _log.Debug("Entering GetBindingElementValue");

               

                    if (string.IsNullOrWhiteSpace(queryValue) || string.IsNullOrEmpty(queryValue) ||
                        string.IsNullOrWhiteSpace(queryPath) || bindingType == null)
                        return null;
                                      

                        var value = string.Empty;

                        switch ((ResponseTypes)bindingType)
                        {
                            case ResponseTypes.XmlBT:
                                value = GetXmlValue(queryValue, queryPath);
                                break;

                            case ResponseTypes.JsonBT:
                                value = GetJsonValue(queryValue, queryPath);
                                break;
                        }

                        return value;                   
                

                _log.Debug("Exiting GetBindingElementValue");

            }
            catch (Exception exp)
            {
                _log.ErrorFormat("Error in GetBindingElementValue, {0}", exp);

                return null;
            }

            return null;
        }

        /// <summary>
        /// Represents a method to convert a string to 
        /// Encrypted data.
        /// </summary>
        public string Encrypt(string originalString)
        {
            var cryptoManager
                = ObjectManager.Acquire<ICryptoManager>();

            try
            {
                return cryptoManager.Encrypt(originalString);
            }
            finally
            {
                if (cryptoManager != null)
                    ObjectManager.Release(cryptoManager);
            }
        }

        public string Decrypt(string originalString)
        {
            var cryptoManager
                = ObjectManager.Acquire<ICryptoManager>();

            try
            {
                return cryptoManager.Decrypt(originalString);
            }
            finally
            {
                if (cryptoManager != null)
                    ObjectManager.Release(cryptoManager);
            }
        }

        /// <summary>
        /// Represents the method that converts GetJsonValue.
        /// </summary>
        /// <param name="jsonString">
        /// A <see cref="string"/> that holds complex element details.
        /// <param name="jsonPath">
        /// A <see cref="string"/> that holds complex element details.
        /// </param>
        /// <returns>
        /// Returns Json object as string.
        /// </returns>
        private string GetJsonValue(string jsonString, string jsonPath)
        {
            if (string.IsNullOrWhiteSpace(jsonPath) ||
                string.IsNullOrWhiteSpace(jsonString))
            {
                _log.ErrorFormat("jsonString is null and jsonPath is - {0}", jsonPath);
                return null;
            }

            // string[] splitstring = jsonPath.Split("/");

            string result = string.Empty;
         
            var jsonResp = new JsonObject();

            jsonResp.Load(jsonString);

            jsonResp.EmitCompact = false;

            var value = jsonResp.StringOf(jsonPath); //outParams.CustId

            if (value == null)
            {
                _log.ErrorFormat("jsonPath - {0} returned null", jsonPath);

                _log.ErrorFormat("jsonString Response : {0}", jsonString);

                return null;
            }

            return value;
            // }

        }

        /// <summary>
        /// Represents the method that converts GetXmlValue.
        /// </summary>
        /// <param name="xml">
        /// A <see cref="string"/> that holds complex element details.
        /// <param name="xPath">
        /// A <see cref="string"/> that holds complex element details.
        /// </param>
        /// <returns>
        /// Returns xml object as string.
        /// </returns>
        private string GetXmlValue(string xml, string xPath)
        {
            if (string.IsNullOrWhiteSpace(xPath) ||
                string.IsNullOrWhiteSpace(xml))
            {
                _log.ErrorFormat("Xml is null and xPath is - {0}", xPath);
                return null;
            }

            var xmldoc = new XmlDocument();

            xml = xml.Replace("xmlns=\"http://tempuri.org/\"", "");

            xmldoc.LoadXml(xml);

            xmldoc = RemoveXmlns(xmldoc);

            var nsmgr = new XmlNamespaceManager(xmldoc.NameTable);
            nsmgr.AddNamespace("soap", "http://schemas.xmlsoap.org/soap/envelope/");

            var selectSingleNode = xmldoc.SelectSingleNode(xPath, nsmgr);

            if (selectSingleNode == null)
            {
                _log.ErrorFormat("xPath - {0} returned null", xPath);

                _log.ErrorFormat("XML Response : {0}", xmldoc.InnerXml);

                return null;
            }

            string value = selectSingleNode.InnerText;

            return value;
        }

        /// <summary>
        /// Represents a method to execute an Http Request
        /// </summary>
        public bool ExecuteRestRequest(HttpRequest request,
            out HttpResponse response)
        {
            response = null;

            IRestExecutor executor = null;

            try
            {
                _log.Debug("Entering ExecuteRestRequest");

                executor = ObjectManager.Acquire<IRestExecutor>();

                string responseMessage = null;

                var status = Status.Failure;

                //status = CallRest(request, out responseMessage);

                status=executor.ExecuteRest(request,out responseMessage);


                if (status==Status.Failure)
                    return false;

                response = new HttpResponse { ResponseString = responseMessage };

                return true;
            }
            finally
            {
                _log.Error("Exiting in ExecuteRestRequest ");

                if (executor != null)
                    ObjectManager.Release<IRestExecutor>(executor);
            }


        }

        /// <summary>
        /// Represents the method that converts RemoveXmlns
        /// </summary>
        /// <param name="doc">
        /// A <see cref="XmlDocument"/> that holds complex element details.  
        /// </param>
        /// <returns>   
        /// </returns>
        private XmlDocument RemoveXmlns(XmlDocument doc)
        {
            XDocument d;

            using (var nodeReader = new XmlNodeReader(doc))
                d = XDocument.Load(nodeReader);

            d.Root.Descendants().Attributes().Where(x => x.IsNamespaceDeclaration).Remove();

            foreach (var elem in d.Descendants())
                elem.Name = elem.Name.LocalName;

            var xmlDocument = new XmlDocument();

            using (var xmlReader = d.CreateReader())
                xmlDocument.Load(xmlReader);

            return xmlDocument;
        }


        #endregion

    }
}
