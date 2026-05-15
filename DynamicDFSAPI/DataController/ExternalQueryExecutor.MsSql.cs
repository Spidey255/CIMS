
using System;
using log4net;
using System.Data;
using System.Data.Common;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using SRA.Proof.Common;
using SRA.Proof.Middleware;
using Newtonsoft.Json.Linq;
// ReSharper disable once CheckNamespace
namespace CPS.Proof.DFSExtension
{
    internal  class ExternalQueryExecutorMsSql : MsSQLControllerBase, IExternalQueryController
    {
        #region Private Variables
        /// <summary>
        /// A <see cref="log4net.ILog"/> is used to write the log.
        /// </summary>
        private readonly ILog _sysLog;

        
        #endregion

        #region Constuctor
        /// <summary>
        /// method to get ExtarnalQueryExecutorMsSql
        /// </summary>
        public ExternalQueryExecutorMsSql()
        {
            _sysLog = LogManager.GetLogger(GetType());
        }
        #endregion

         /// <summary>
        /// Represents a member field which holds the app settings.
        /// </summary>
        private ConnectionString _connStrings;

        /// <summary>
      /// Represents a method to Excute the Query.
      /// </summary>
      /// <param name="connectionstring">
      /// A <see cref="string"/> hold the Connection String.
      /// </param>
      /// <param name="query">
      /// A <see cref="string"/> hold the query.
      /// </param>
      /// <param name="queryResult">
      /// A <see cref="Dicitionary{S,O}"/> hold the Result of the Query.
      /// </param>
      /// <returns>Execution Status</returns>
        public Status ExecuteQuery(string connectionString,
            string query,
                      out Dictionary<short, object> queryResults)
      {
          IDataReader reader = null;          

          queryResults = null;

          _sysLog.Debug("Entering ExecuteQuery.");

          _sysLog.DebugFormat("The QUERY RUNNING IS {0}", query);

          try
          {
                _sysLog.Debug("Entering ExecuteQuery");

               
                var dbConnectionString = 
                    GetConnectionString(connectionString);


                //Get Database instance from Enterprise library
                Database db = new SqlDatabase(dbConnectionString);

                if (db == null)
                {
                  
                    return Status.Failure;
                }

                
                using (DbCommand command = db.GetSqlStringCommand(query))
                {
                    command.CommandTimeout = 10000;

                   
                        using (reader = db.ExecuteReader(command))
                        {
                            //Get first row from result query.
                            //Only one row could be allowed to set result values to target
                            //elements.
                            if (reader.Read())
                            {
                                queryResults = new Dictionary<short, object>();

                                for (short index = 0;
                                    index < reader.FieldCount;
                                    index++)
                                    //Add column index and result value.
                                    queryResults.Add(index, reader[index]);
                            }

                        }
                    
                }



              return Status.Success;
          }
          catch (Exception ex)
          {
              _sysLog.Error("Error in ExecuteQuery", ex);

              return Status.Failure;
          }
          finally
          {

              if (reader != null)
              {
                  if (!reader.IsClosed)
                      reader.Close();
                    reader.Dispose();
              }

            
                _sysLog.Debug("Exiting ExecuteQuery");
            }
      }

    
         /// <summary>
        /// Represents a helper method to retrieve the 
        /// database instance.
        /// </summary>
        /// <returns>
        /// The <see cref="Database"/>instance.
        /// </returns>
        private string GetProofConnectionString
            ( string ProofConnectionId)
        {

           
            try
            {

               
                var connectionString =
                    base.GetConnectionStringById(
                        AppParams.GetAppSettings("RepConnectionName"), ProofConnectionId);


                return connectionString;


            }
            catch(Exception ex)
            {
                _sysLog.Error("Error in GetProofConnectionString", ex);

                return null;
            }


        }

       /// <summary>
        /// Represents the method that is used to get
        /// the grid data source based on the given 
        /// query and connection string.
        /// </summary>
        /// <param name="connectionstring">
        /// A <see cref="string"/> hold the Connection String.
        /// </param>
        /// <param name="query">
        /// A <see cref="string"/> hold the query.
        /// </param>
        /// <param name="queryResult">
        /// A <see cref="DataTable"/> hold the Result of the Query.
        /// </param>
        /// <returns>Execution Status</returns>
        public Status GetGridDataSource(ConnectionString connectionstring,
          string query, out DataTable queryResult)
        {
            queryResult = null;                   
                        

            try
            {
                _sysLog.Debug("Entering GetGridDataSource");

                _sysLog.DebugFormat("THE QUERY GOING TO RUN IS  {0}", query);


                var dbConnectionString =
                    GetConnectionString(connectionstring.Connection);


                //Get Database instance from Enterprise library
                Database db = new SqlDatabase(dbConnectionString);

                if (db == null)
                {

                    return Status.Failure;
                }

              
                if (string.IsNullOrWhiteSpace(query))
                    return Status.Failure;

                if (db == null)
                {
                    _sysLog.Error("Exiting ExecuteQuery");
                    return Status.Failure;
                }

                
                _sysLog.DebugFormat("THE QUERY GOING TO RUN IS  {0}", query);

                using (var command = db.GetSqlStringCommand(query))
                {

                    command.CommandTimeout = 10000;

                    var queryDataset = db.ExecuteDataSet(command);

                   
                    //If the data set is not null and if it having tables
                    //then setting the resulting table of index 0 to 
                    //query results data table.
                    if (queryDataset.Tables.Count == 1)
                        queryResult = queryDataset.Tables[0];
                }

                return Status.Success;
                      
            }
            catch (Exception exp)
            {
                _sysLog.Debug("Exiting GetGridDataSource on Exception", exp);

                return Status.Failure;
            }
           
        }


        /// <summary>
        /// Represents a helper method to retrieve the 
        /// database instance.
        /// </summary>
        /// <returns>
        /// The <see cref="Database"/>instance.
        /// </returns>
        private string GetConnectionString(string connectionString)
        {
                     

            var splitedString = connectionString.Split(';');

            var providerName = splitedString[0].Substring
                (splitedString[0].LastIndexOf("=", StringComparison.Ordinal) + 1);

            var connectionStrings = connectionString.Substring
                (connectionString.IndexOf(";", StringComparison.Ordinal) + 1);


            return connectionStrings;
        }

           public ConnectionString ConnectionById
            (string ProofconnectionId, string AppConnectionId)
        {

           
           
                GetSystemConnectionSettings(GetProofConnectionString( ProofconnectionId),
                    AppConnectionId, out _connStrings);


                return _connStrings;
            
        }

         /// <summary>
        /// Represents the method that retrieves the System
        /// Application Settings Details.
        /// </summary>
        /// <param name="connectionStrings">
        /// A <see cref="System.Collections.Generic.Dictionary{TKey,TValue}"/> 
        /// that contains the application status id and its name.
        /// </param>
        /// <returns>
        /// A <see cref="System.Boolean"/> that holds the execution flag.
        /// </returns>
        public bool GetSystemConnectionSettings
            (string contextConnectionString, string connectionId,
                out ConnectionString connectionStrings)
        {

            connectionStrings = null;

            IDataReader reader = null;

            ICryptoManager crypt = null;

            try
            {
                //Entry log.
                _sysLog.Debug("Entering GetSystemAppSettings.");

                _sysLog.DebugFormat("GetSystemConnectionSettingsSql connectionstring {0}is", contextConnectionString);

                var database = CreateSQLDatabase(contextConnectionString);

                _sysLog.Debug("Exiting  CreateDBFromEncodedCS.");

                
                using (var command = database.GetStoredProcCommand
                    ("GetSysConnectionSettings"))
                {
                    command.CommandTimeout = 10000;
                    

                    database.AddInParameter(command, AppConnectionStringsConstants.ConnId, DbType.String,
                          connectionId);

                    reader = database.ExecuteReader(command);
                }

                var connIdIndex = reader.GetOrdinal(AppConnectionStringsConstants.ConnId);

                var connNameIndex = reader.GetOrdinal(AppConnectionStringsConstants.ConnName);

                var connStringIndex = reader.GetOrdinal(AppConnectionStringsConstants.ConnString);

                var methodIndex = reader.GetOrdinal(AppConnectionStringsConstants.MethodName);

                var hostIndex = reader.GetOrdinal(AppConnectionStringsConstants.HostName);

                var portIndex = reader.GetOrdinal(AppConnectionStringsConstants.Port);

                var tempIndex = reader.GetOrdinal(AppConnectionStringsConstants.Template);

                var connectionType = reader.GetOrdinal(AppConnectionStringsConstants.ConnectionType);

                var requestType = reader.GetOrdinal(AppConnectionStringsConstants.RequestType);

                var nameSpace = reader.GetOrdinal(AppConnectionStringsConstants.NameSpace);

                var contentType = reader.GetOrdinal(AppConnectionStringsConstants.ContentTypeConstant);

                var requireAuthentication = reader.GetOrdinal(AppConnectionStringsConstants.RequireAuthentication);

                var hasRequestBody = reader.GetOrdinal(AppConnectionStringsConstants.HasRequestBody);

                var usrNameIndex = reader.GetOrdinal(AppConnectionStringsConstants.UserName);

                var pswdIndex = reader.GetOrdinal(AppConnectionStringsConstants.Password);

                var tlsIndex = reader.GetOrdinal(AppConnectionStringsConstants.TLS);

                var autoconnectIndex = reader.GetOrdinal(AppConnectionStringsConstants.AutoConnect);

                var successCodesIndex = reader.GetOrdinal(AppConnectionStringsConstants.SuccessCodes);

                var errCodesIndex = reader.GetOrdinal(AppConnectionStringsConstants.ErrorCodes);

                var idleTimeIndex = reader.GetOrdinal(AppConnectionStringsConstants.IdleTimeout);

                var retriesIndex = reader.GetOrdinal(AppConnectionStringsConstants.Retries);

                var retryIntervalIndex = reader.GetOrdinal(AppConnectionStringsConstants.RetryInterval);

                var isAsyncIndex = reader.GetOrdinal(AppConnectionStringsConstants.IsAsync);

               crypt = ObjectManager.Acquire<ICryptoManager>();

                while (reader.Read())
                {
                    int dbType = reader.GetByte(connectionType);

                    var connString = new ConnectionString();

                    connString.ConnectionId = reader.GetString(connIdIndex);
                    connString.Connection = (dbType != 0 && dbType != 1 && dbType != 2)
                                                            ? reader.GetString(connStringIndex) :
                                                            crypt.Decrypt(reader.GetString(connStringIndex));
                    connString.Name = reader.GetString(connNameIndex);
                    connString.Template = reader.IsDBNull(tempIndex) ? null :
                                                        reader.GetString(tempIndex);
                    connString.HostName = reader.IsDBNull(hostIndex) ? null :
                                                        reader.GetString(hostIndex);
                    connString.Port = reader.IsDBNull(portIndex) ? 0 :
                                                        reader.GetInt32(portIndex);
                    connString.DbType = (DbTypes)dbType;
                    connString.ConnectionType = (ConnectionTypes)dbType;
                    connString.MethodName = reader.IsDBNull(methodIndex) ?
                                                        null : reader.GetString(methodIndex);
                    connString.RequestType = reader.IsDBNull(requestType)
                                                        ? RequestType.Get :
                                                        (RequestType)reader.GetByte(requestType);


                    connString.NameSpace = reader.IsDBNull(nameSpace) ? null :
                                                    reader.GetString(nameSpace);

                    connString.ContentType = reader.IsDBNull(contentType) ?
                        ContentType.XML : (ContentType)reader.GetByte(contentType);

                    connString.RequireAuthentication = reader.IsDBNull(requireAuthentication) ?
                        false : reader.GetBoolean(requireAuthentication);

                    connString.HasRequestBody = reader.IsDBNull(hasRequestBody) ?
                        false : reader.GetBoolean(hasRequestBody);

                    connString.UserName = reader.IsDBNull(usrNameIndex) ? null :
                        crypt.Decrypt(reader.GetString(usrNameIndex));

                    connString.Password = reader.IsDBNull(pswdIndex) ? null :
                        crypt.Decrypt(reader.GetString(pswdIndex));

                    connString.IdleTimeouts = reader.IsDBNull(idleTimeIndex) ? 30 :
                        reader.GetInt32(idleTimeIndex);

                    connString.AutoReConnect = reader.IsDBNull(autoconnectIndex) ? false
                        : reader.GetBoolean(autoconnectIndex);

                    connString.TransportLayeredService = reader.IsDBNull(tlsIndex) ? false
                         : reader.GetBoolean(tlsIndex);

                    connString.SuccessCodes = reader.IsDBNull(successCodesIndex) ? null
                         : reader.GetString(successCodesIndex);

                    connString.ErrorCodes = reader.IsDBNull(errCodesIndex) ? null
                         : reader.GetString(errCodesIndex);

                    connString.Retries = reader.IsDBNull(retriesIndex) ? 0
                         : Convert.ToInt32(reader.GetByte(retriesIndex));

                    connString.RetryInterval = reader.IsDBNull(retryIntervalIndex) ? 0
                         : Convert.ToDouble(reader.GetDecimal(retryIntervalIndex));

                    connString.IsAsync = reader.IsDBNull(isAsyncIndex) ? false
                         : reader.GetBoolean(isAsyncIndex);


                    connectionStrings = connString;
                }

                //Exit log.
                _sysLog.Debug("Exiting GetSystemAppSettings.");


                return true;
            }
            catch (Exception e)
            {
                //Error log.
                _sysLog.Error("ERROR in GetSystemAppSettings.", e);

                return false;
            }
            finally
            {
                if (reader != null)
                {
                    if (!reader.IsClosed)
                        reader.Close();

                    reader.Dispose();
                }

                if (crypt != null)
                    ObjectManager.Release(crypt);
            }
        }


        public Status GetElementClientData(string instanceId, string widgetId, out string ClientData)
        {
            _sysLog.Debug("Entering GetElementClientData");

            IDataReader reader = null;

            ClientData = null;

            try
            {

                Database database = GetDatabaseInstance();

                using (DbCommand command =
                    database.GetStoredProcCommand("GetFormInstanceData"))
                {
                    command.CommandTimeout = 10000;

                    database.AddInParameter(command, "FormInstanceId", DbType.String, instanceId);


                    database.AddInParameter(command, "ComplexElementId", DbType.String, widgetId);


                    reader = database.ExecuteReader(command);

                    if (reader != null)
                    {
                        while (reader.Read())
                        {

                            ClientData = reader.GetString(0);
                        }
                    }


                    return Status.Success;
                }
            }
            catch (Exception ex)
            {
                _sysLog.Error("Error in GetFormInstanceData", ex);

                return Status.Failure;
            }
            finally
            {
                if (reader != null)
                {
                    if (!reader.IsClosed)
                        reader.Close();
                    reader.Dispose();
                }

                _sysLog.Debug("Exiting GetFormInstanceData");
            }
        }


         public Status GetComboDataSource(SlotToken token, Tuple<string,string> comboSource,
            out DataTable queryResult)
        {
            _sysLog.Debug("Entering GetComboDataSource");

            IDataReader reader = null;

            ICryptoManager cryptoManager = null;

            queryResult = null;

            try
            {
                Database database = GetDatabaseInstance(token);

                cryptoManager = ObjectManager.Acquire<ICryptoManager>();

                 string connectionString=DecryptConnectionstring(comboSource.Item1);

                string query = comboSource.Item2;               

                if (string.IsNullOrEmpty(connectionString))
                    return Status.Failure;

                var splitconnectionString = connectionString.Split(new[] { ';' }, 2);

                var status = ExecuteComboQuery(splitconnectionString[1], query, out queryResult);

                return status;                


            }
            catch (Exception ex)
            {
                _sysLog.Error("Error in GetComboDataSource", ex);

                return Status.Failure;

            }
            finally
            {

                ObjectManager.Release<ICryptoManager>(cryptoManager);


                if (reader != null)
                {
                    if (!reader.IsClosed)
                        reader.Close();
                    reader.Dispose();
                }


                _sysLog.Debug("Exiting GetComboDataSource");
            }
        }

        private string DecryptConnectionstring(string connectionString)
        {
            ICryptoManager cryptoManager = null;

            try
            {
                cryptoManager = ObjectManager.Acquire<ICryptoManager>();

                return cryptoManager.Decrypt(connectionString);

            }
            catch
            {
                if (cryptoManager != null)
                {
                    ObjectManager.Release<ICryptoManager>(cryptoManager);
                }

                return null;
            }
        }


        public Status ExecuteComboQuery(string connectionString,
          string query,
                    out DataTable queryResults)
        {
            IDataReader reader = null;

            queryResults = null;

            _sysLog.Debug("Entering ExecuteQuery.");

            _sysLog.DebugFormat("The QUERY RUNNING IS {0}", query);

            try
            {
                _sysLog.Debug("Entering ExecuteQuery");

                //Get Database instance from Enterprise library
                Database db = new SqlDatabase(connectionString);

                if (db == null)
                {

                    return Status.Failure;
                }


                using (DbCommand command = db.GetSqlStringCommand(query))
                {
                    command.CommandTimeout = 10000;


                    using (reader = db.ExecuteReader(command))
                    {
                        //var queryDataset = db.ExecuteDataSet(command);

                        queryResults = new DataTable();

                        queryResults.Load(reader);

                    }
                }

                return Status.Success;
            }
            catch (Exception ex)
            {
                _sysLog.Error("Error in ExecuteQuery", ex);

                return Status.Failure;
            }
            finally
            {

                if (reader != null)
                {
                    if (!reader.IsClosed)
                        reader.Close();
                    reader.Dispose();
                }


                _sysLog.Debug("Exiting ExecuteQuery");
            }
        }


         /// <summary>
        /// Represents a method to Excute the Query.
        /// </summary>
        /// <param name="connectionstring">
        /// A <see cref="string"/> hold the Connection String.
        /// </param>
        /// <param name="query">
        /// A <see cref="string"/> hold the query.
        /// </param>
        /// <param name="queryResult">
        /// A <see cref="Dicitionary{S,O}"/> hold the Result of the Query.
        /// </param>
        /// <returns>Execution Status</returns>
        public Status ExecuteQuery(string connectionString,
            string query,
                      out DataTable queryResults)
        {
            IDataReader reader = null;

            queryResults = null;

            _sysLog.Debug("Entering ExecuteQuery.");

            _sysLog.DebugFormat("The QUERY RUNNING IS {0}", query);

            try
            {
                _sysLog.Debug("Entering ExecuteQuery");


                var dbConnectionString =
                    GetConnectionString(connectionString);


                //Get Database instance from Enterprise library
                Database db = new SqlDatabase(dbConnectionString);

                if (db == null)
                {

                    return Status.Failure;
                }


                using (DbCommand command = db.GetSqlStringCommand(query))
                {
                    command.CommandTimeout = 10000;


                    using (reader = db.ExecuteReader(command))
                    {
                        var queryDataset = db.ExecuteDataSet(command);


                        //If the data set is not null and if it having tables
                        //then setting the resulting table of index 0 to 
                        //query results data table.
                        if (queryDataset.Tables.Count == 1)
                            queryResults = queryDataset.Tables[0];

                    }

                }



                return Status.Success;
            }
            catch (Exception ex)
            {
                _sysLog.Error("Error in ExecuteQuery", ex);

                return Status.Failure;
            }
            finally
            {

                if (reader != null)
                {
                    if (!reader.IsClosed)
                        reader.Close();
                    reader.Dispose();
                }


                _sysLog.Debug("Exiting ExecuteQuery");
            }
        }

         public Status GetFormInstanceData(SlotToken token,
              Context context, out DataTable queryResult)
        {
            _sysLog.Debug("Entering GetFormInstanceData");

            queryResult = null;

          
            try
            {

                Database database = GetDatabaseInstance(token);


                string getSPName = string.Empty;

                getSPName = "GetFormData" + context.WidgetId.Replace("-", "");


                using (DbCommand command =
                    database.GetStoredProcCommand
                        (getSPName))
                {
                    command.CommandTimeout = 10000;

                    database.AddInParameter(command, "InstanceId", DbType.String, context.FormInstanceId);

                    database.AddInParameter(command, "ProcessActivityMapId", DbType.String, context.ProcessActivityMapId);

                    database.AddInParameter(command, "FormId", DbType.String, context.WidgetId);                  

                    var queryDataset = database.ExecuteDataSet(command);

                    //If the data set is not null and if it having tables
                    //then setting the resulting table of index 0 to 
                    //query results data table.
                    if (queryDataset.Tables.Count > 0)
                        queryResult = queryDataset.Tables[0];
                                      
                    return Status.Success;
                }
            }
            catch (Exception ex)
            {
                _sysLog.Error("Error in GetFormInstanceData", ex);

                return Status.Failure;
            }
            finally
            {
                _sysLog.Debug("Exiting GetFormInstanceData");
            }
        }


         public Status SaveFormInstanceData(SlotToken token,  string insertQuery)
        {
            _sysLog.Debug("Entering SaveFormData");

           
            try
            {

                Database database = GetDatabaseInstance(token);

                          
              
                using (DbCommand command = 
                    database.GetSqlStringCommand
                        (insertQuery))
                {
                    command.CommandTimeout = 10000;

                    database.ExecuteNonQuery(command);
                   


                    return Status.Success;
                }
            }
            catch(Exception ex)
            {
                _sysLog.Error("Error in SaveFormData", ex);

                return Status.Failure;
            }
            finally
            {
                _sysLog.Debug("Exiting SaveFormData");
            }
        }


          public Status SaveForkedInstanceData(SlotToken token, string insertQuery,string parentinstanceid,string processactivitymapid)
        {
            _sysLog.Debug("Entering SaveForkedInstanceData");


            try
            {

                Database database = GetDatabaseInstance(token);             

                using (DbCommand command =
                    database.GetSqlStringCommand
                        (insertQuery))
                {
                    command.CommandTimeout = 10000;
                    database.AddInParameter(command, "parentinstanceid", DbType.String,
                        parentinstanceid);

                    database.AddInParameter(command, "processactivitymapid", DbType.String,
                      processactivitymapid);

                    database.ExecuteNonQuery(command);

                    return Status.Success;
                }
            }
            catch (Exception ex)
            {
                _sysLog.Error("Error in SaveForkedInstanceData", ex);

                return Status.Failure;
            }
            finally
            {
                _sysLog.Debug("Exiting SaveForkedInstanceData");
            }
        }


         private string InsertFormData(string instanceId, string packageProcessMapId, string processActivityMapId,
          string formId, long usermapid, string formJsonData)
        {
            _sysLog.Debug("Entering  InsertFormData");

            try
            {


                string colValues = string.Empty;

                string UpdatecolValues = string.Empty;

                string[] splitcols = null;

                string colList = string.Empty;

                string fInsertQuery = string.Empty;            

                switch(formId)
                {

                
                                      case "781F63B4-048D-4578-AF08-83C4E8FC0483":
                    {
                     
                                     fInsertQuery=@"IF NOT EXISTS(SELECT 1 FROM [781F63B4-048D-4578-AF08-83C4E8FC0483] WHERE InstanceId='{0}' AND
							ProcessActivityMapId='{1}' AND FormId='{2}') BEGIN INSERT INTO [781F63B4-048D-4578-AF08-83C4E8FC0483](InstanceId,ProcessActivityMapId,FormId,ExecutionStatus,MF_DistributionId,ExecutionMessage,SetDestinationTo,MF_Description,Subject,RedirectUrl,MF_Fundname,SLATime,MF_OtherDistributionId,MF_FundTypeId,MF_MaxPercentageUsage,MF_MaxAmount,MF_SameFundingAgency,MF_MultipleProjectsAllowed,MF_PackageProcessMapId)
							VALUES( {3}) END ELSE BEGIN UPDATE [781F63B4-048D-4578-AF08-83C4E8FC0483]SET {4}WHERE InstanceId='{0}'AND ProcessActivityMapId='{1}'AND FormId='{2}'END ";

                                     colList=@"InstanceId,ProcessActivityMapId,FormId,ExecutionStatus,MF_DistributionId,ExecutionMessage,SetDestinationTo,MF_Description,Subject,RedirectUrl,MF_Fundname,SLATime,MF_OtherDistributionId,MF_FundTypeId,MF_MaxPercentageUsage,MF_MaxAmount,MF_SameFundingAgency,MF_MultipleProjectsAllowed,MF_PackageProcessMapId";
                                    
                     
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

                                            default:
                                                if (childObject["Value"] != null)
                                                {
                                                    colValues += childObject["Value"].ToString() + ",";
                                                    UpdatecolValues += fcol + "=" + childObject["Value"].ToString() + ",";
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
                            UpdatecolValues = UpdatecolValues.Remove(colValues.Length - 1);

                            fInsertQuery =  string.Format(fInsertQuery,instanceId,processActivityMapId,formId, colValues,UpdatecolValues);

                            colValues = string.Empty;

                            break;
                        }
                
                       
                      case "DA3904EF-0E60-44D0-943E-2E97494B15C8":
                    {
                     
                                     fInsertQuery=@"IF NOT EXISTS(SELECT 1 FROM [DA3904EF-0E60-44D0-943E-2E97494B15C8] WHERE InstanceId='{0}' AND
							ProcessActivityMapId='{1}' AND FormId='{2}') BEGIN INSERT INTO [DA3904EF-0E60-44D0-943E-2E97494B15C8](InstanceId,ProcessActivityMapId,FormId,ExecutionMessage,ExecutionStatus,Subject,SetDestinationTo,MF_ProjectDetailsId,SLATime,MF_ProjectNo)
							VALUES( {3}) END ELSE BEGIN UPDATE [DA3904EF-0E60-44D0-943E-2E97494B15C8]SET {4}WHERE InstanceId='{0}'AND ProcessActivityMapId='{1}'AND FormId='{2}'END ";

                                     colList=@"InstanceId,ProcessActivityMapId,FormId,ExecutionMessage,ExecutionStatus,Subject,SetDestinationTo,MF_ProjectDetailsId,SLATime,MF_ProjectNo";
                                    
                     
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

                                            default:
                                                if (childObject["Value"] != null)
                                                {
                                                    colValues += childObject["Value"].ToString() + ",";
                                                    UpdatecolValues += fcol + "=" + childObject["Value"].ToString() + ",";
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
                            UpdatecolValues = UpdatecolValues.Remove(colValues.Length - 1);

                            fInsertQuery =  string.Format(fInsertQuery,instanceId,processActivityMapId,formId, colValues,UpdatecolValues);

                            colValues = string.Empty;

                            break;
                        }
                
                       
                      case "22A823DE-0760-4F0D-A347-1C1315A2967E":
                    {
                     
                                     fInsertQuery=@"IF NOT EXISTS(SELECT 1 FROM [22A823DE-0760-4F0D-A347-1C1315A2967E] WHERE InstanceId='{0}' AND
							ProcessActivityMapId='{1}' AND FormId='{2}') BEGIN INSERT INTO [22A823DE-0760-4F0D-A347-1C1315A2967E](ProcessActivityMapId,FormId,M_BudgetErrMsg,MF_T1_BankName,MF_T1_BankBranch,C_FC_SanctionedValue_33,M_SourceActivityMapId,IN_SLA,AssignToRole,M_TravelPlace,UC_Designation,UC_Name,MF_E1_EmployeeBasicInfoId,M_InitiatorUserMapId,growid,C_FC_AgencyCode_33,M_InstanceId,M_PackageProcessMapId,M_Remarks,UC_Department,IN_InstanceName,UC_DOR,M_ActualTransactionNo,UC_DOJ,ExecuteCommand,UC_EmailId,FC_ProjectNo,FC_Category,M_Status,CancelRedirectUrl,UC_DOB,MF_TransactionNo,MF_InstanceId,M_DestinationActivityId,M_MoveToValue,FC_AgencyCode,FC_EndDate,Subject,C_FC_SanctionNo_33,FC_StartDate,AssignToUser,MF_PackageProcessMapId,FC_ProjectName,UC_EmployeeId,MF_FundDetailsId,SetDestinationTo,UC_EmployeeBaicInfoId,M_NextStage,MF_T1_AccountNo,MF_T1_TravellingPerson,KeyContext,M_SourceHeader,DisplayContext,UC_Grade,M_MiscDetails,FC_SanctionedDate,MF_T1_JourneyPurpose,RedirectUrl,MF_TravelStatus,MF_T1_ProjectNo,ExecutionMessage,FC_SanctionedValue,MF_T1_TravelAdvanceID,UC_Paylevel,MF_SaveBudgetAmount,C_FC_BudgetHeadAmount,AdvanceAmount,MF_T1_AvailableBudget,T_ExpenditureTotal,IN_Category,M_IsTravelRequest,MF_Amount,M_FieldMandatory,M_IsFlowReturned,M_RemarksMandatory,MF_T1_AdvanceAmount,M_IsSourceStep,M_IsCancelReject,M_BudgetErr,T_AdvanceDrawn,SLATime,M_T1_AdvanceAmount,C_FC_ReceiptAmountinBudgetHead,T_TravelAdvanceTotal,M_SaveDomainData,IN_Priority,IN_Status,MF_CountDoc,M_OverAll_Total,MF_GrdFundCount,M_IsCommitment,M_RequestId,OverAll_Total,M_SumOfFund,MF_T1_TravelType,C_FC_ProjectNo_33,R_ReferenceNo,MF_BudgetHead,A,MF_T1_BudgetHead,M_MoveTo,MF_FundType,MF_ProjectNo,Travel_Type,C_FC_SanctionedDate_33,M_RandDTransactionDate,C_FC_StartDate_33,M_ActualTransactionDate,MF_TransactionDate,C_FC_EndDate_33,MF_T1_BankDocument,Thumbnail,MF_T1_BeneficiaryName,FC_SanctionNo,C_FC_ProjectName_33,C_FC_Category_33,MF_T1_ReferenceNo,MF_SaveBudgetName,MF_T1_Destination,UC_PhoneNumber,ExecutionStatus,M_TravelInstanceId,M_RandDTransactionNo,M_ActivityName,InstanceId)
							VALUES( {3}) END ELSE BEGIN UPDATE [22A823DE-0760-4F0D-A347-1C1315A2967E]SET {4}WHERE InstanceId='{0}'AND ProcessActivityMapId='{1}'AND FormId='{2}'END ";

                                     colList=@"ProcessActivityMapId,FormId,M_BudgetErrMsg,MF_T1_BankName,MF_T1_BankBranch,C_FC_SanctionedValue_33,M_SourceActivityMapId,IN_SLA,AssignToRole,M_TravelPlace,UC_Designation,UC_Name,MF_E1_EmployeeBasicInfoId,M_InitiatorUserMapId,growid,C_FC_AgencyCode_33,M_InstanceId,M_PackageProcessMapId,M_Remarks,UC_Department,IN_InstanceName,UC_DOR,M_ActualTransactionNo,UC_DOJ,ExecuteCommand,UC_EmailId,FC_ProjectNo,FC_Category,M_Status,CancelRedirectUrl,UC_DOB,MF_TransactionNo,MF_InstanceId,M_DestinationActivityId,M_MoveToValue,FC_AgencyCode,FC_EndDate,Subject,C_FC_SanctionNo_33,FC_StartDate,AssignToUser,MF_PackageProcessMapId,FC_ProjectName,UC_EmployeeId,MF_FundDetailsId,SetDestinationTo,UC_EmployeeBaicInfoId,M_NextStage,MF_T1_AccountNo,MF_T1_TravellingPerson,KeyContext,M_SourceHeader,DisplayContext,UC_Grade,M_MiscDetails,FC_SanctionedDate,MF_T1_JourneyPurpose,RedirectUrl,MF_TravelStatus,MF_T1_ProjectNo,ExecutionMessage,FC_SanctionedValue,MF_T1_TravelAdvanceID,UC_Paylevel,MF_SaveBudgetAmount,C_FC_BudgetHeadAmount,AdvanceAmount,MF_T1_AvailableBudget,T_ExpenditureTotal,IN_Category,M_IsTravelRequest,MF_Amount,M_FieldMandatory,M_IsFlowReturned,M_RemarksMandatory,MF_T1_AdvanceAmount,M_IsSourceStep,M_IsCancelReject,M_BudgetErr,T_AdvanceDrawn,SLATime,M_T1_AdvanceAmount,C_FC_ReceiptAmountinBudgetHead,T_TravelAdvanceTotal,M_SaveDomainData,IN_Priority,IN_Status,MF_CountDoc,M_OverAll_Total,MF_GrdFundCount,M_IsCommitment,M_RequestId,OverAll_Total,M_SumOfFund,MF_T1_TravelType,C_FC_ProjectNo_33,R_ReferenceNo,MF_BudgetHead,A,MF_T1_BudgetHead,M_MoveTo,MF_FundType,MF_ProjectNo,Travel_Type,C_FC_SanctionedDate_33,M_RandDTransactionDate,C_FC_StartDate_33,M_ActualTransactionDate,MF_TransactionDate,C_FC_EndDate_33,MF_T1_BankDocument,Thumbnail,MF_T1_BeneficiaryName,FC_SanctionNo,C_FC_ProjectName_33,C_FC_Category_33,MF_T1_ReferenceNo,MF_SaveBudgetName,MF_T1_Destination,UC_PhoneNumber,ExecutionStatus,M_TravelInstanceId,M_RandDTransactionNo,M_ActivityName,InstanceId";
                                    
                     
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

                                            default:
                                                if (childObject["Value"] != null)
                                                {
                                                    colValues += childObject["Value"].ToString() + ",";
                                                    UpdatecolValues += fcol + "=" + childObject["Value"].ToString() + ",";
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
                            UpdatecolValues = UpdatecolValues.Remove(colValues.Length - 1);

                            fInsertQuery =  string.Format(fInsertQuery,instanceId,processActivityMapId,formId, colValues,UpdatecolValues);

                            colValues = string.Empty;

                            break;
                        }
                
                       
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

                                            default:
                                                if (childObject["Value"] != null)
                                                {
                                                    colValues += childObject["Value"].ToString() + ",";
                                                    UpdatecolValues += fcol + "=" + childObject["Value"].ToString() + ",";
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
                            UpdatecolValues = UpdatecolValues.Remove(colValues.Length - 1);

                            fInsertQuery =  string.Format(fInsertQuery,instanceId,processActivityMapId,formId, colValues,UpdatecolValues);

                            colValues = string.Empty;

                            break;
                        }
                
                       
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

                                            default:
                                                if (childObject["Value"] != null)
                                                {
                                                    colValues += childObject["Value"].ToString() + ",";
                                                    UpdatecolValues += fcol + "=" + childObject["Value"].ToString() + ",";
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
                            UpdatecolValues = UpdatecolValues.Remove(colValues.Length - 1);

                            fInsertQuery =  string.Format(fInsertQuery,instanceId,processActivityMapId,formId, colValues,UpdatecolValues);

                            colValues = string.Empty;

                            break;
                        }
                
                       
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

                                            default:
                                                if (childObject["Value"] != null)
                                                {
                                                    colValues += childObject["Value"].ToString() + ",";
                                                    UpdatecolValues += fcol + "=" + childObject["Value"].ToString() + ",";
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
                            UpdatecolValues = UpdatecolValues.Remove(colValues.Length - 1);

                            fInsertQuery =  string.Format(fInsertQuery,instanceId,processActivityMapId,formId, colValues,UpdatecolValues);

                            colValues = string.Empty;

                            break;
                        }
                
                       
                      case "6B463D69-64AB-468E-B2E3-DB12E6B90014":
                    {
                     
                                     fInsertQuery=@"IF NOT EXISTS(SELECT 1 FROM [6B463D69-64AB-468E-B2E3-DB12E6B90014] WHERE InstanceId='{0}' AND
							ProcessActivityMapId='{1}' AND FormId='{2}') BEGIN INSERT INTO [6B463D69-64AB-468E-B2E3-DB12E6B90014](ProcessActivityMapId,FormId,M_MoveTo,MF_ProjectNo,MF_P1_Initiatedon,MF_P1_UpdatedOn,Thumbnail,MF_P1_ReimbursementId,UC_EmailId,DisplayContext,ExecuteCommand,UC_Department,IN_SLA,CancelRedirectUrl,MF_P1_Remarks,RedirectUrl,M_NextStage,AssignToRole,KeyContext,UC_EmployeeId,UC_Paylevel,M_ErrMsg,MF_P1_ApplicationStatus,M_Status,growid,M_MoveToValue,M_DestinationActivityId,SetDestinationTo,Subject,M_InstanceId,ExecutionStatus,M_PackageProcessMapId,MF_P1_InitatedBy,UC_Grade,UC_DOJ,M_ReferenceNo,MF_P1_UpdatedBy,M_SourceActivityMapId,UC_EmployeeBaicInfoId,M_InitiatorUserMapId,UC_Designation,UC_PhoneNumber,M_Advanceformid,AssignToUser,MF_P1_EmployeeBasicInfoId,UC_Name,ExecutionMessage,MF_E1_EmployeeBasicInfoId,UC_DOB,IN_InstanceName,UC_DOR,M_IsSourceStep,Test,M_IsflowReturned,IN_Category,M_UpdateCount,SLATime,IN_Priority,MF_P1_TotalAmount,M_RemarksMandatory,M_FieldMandatory,M_ErrId,IN_Status,M_SaveDomainData,M_RequestId,M_IsCancelReject,Declaration,InstanceId)
							VALUES( {3}) END ELSE BEGIN UPDATE [6B463D69-64AB-468E-B2E3-DB12E6B90014]SET {4}WHERE InstanceId='{0}'AND ProcessActivityMapId='{1}'AND FormId='{2}'END ";

                                     colList=@"ProcessActivityMapId,FormId,M_MoveTo,MF_ProjectNo,MF_P1_Initiatedon,MF_P1_UpdatedOn,Thumbnail,MF_P1_ReimbursementId,UC_EmailId,DisplayContext,ExecuteCommand,UC_Department,IN_SLA,CancelRedirectUrl,MF_P1_Remarks,RedirectUrl,M_NextStage,AssignToRole,KeyContext,UC_EmployeeId,UC_Paylevel,M_ErrMsg,MF_P1_ApplicationStatus,M_Status,growid,M_MoveToValue,M_DestinationActivityId,SetDestinationTo,Subject,M_InstanceId,ExecutionStatus,M_PackageProcessMapId,MF_P1_InitatedBy,UC_Grade,UC_DOJ,M_ReferenceNo,MF_P1_UpdatedBy,M_SourceActivityMapId,UC_EmployeeBaicInfoId,M_InitiatorUserMapId,UC_Designation,UC_PhoneNumber,M_Advanceformid,AssignToUser,MF_P1_EmployeeBasicInfoId,UC_Name,ExecutionMessage,MF_E1_EmployeeBasicInfoId,UC_DOB,IN_InstanceName,UC_DOR,M_IsSourceStep,Test,M_IsflowReturned,IN_Category,M_UpdateCount,SLATime,IN_Priority,MF_P1_TotalAmount,M_RemarksMandatory,M_FieldMandatory,M_ErrId,IN_Status,M_SaveDomainData,M_RequestId,M_IsCancelReject,Declaration,InstanceId";
                                    
                     
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

                                            default:
                                                if (childObject["Value"] != null)
                                                {
                                                    colValues += childObject["Value"].ToString() + ",";
                                                    UpdatecolValues += fcol + "=" + childObject["Value"].ToString() + ",";
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
                            UpdatecolValues = UpdatecolValues.Remove(colValues.Length - 1);

                            fInsertQuery =  string.Format(fInsertQuery,instanceId,processActivityMapId,formId, colValues,UpdatecolValues);

                            colValues = string.Empty;

                            break;
                        }
                
                       
                               

                 }
                return fInsertQuery;

            }
            catch (Exception ex)
            {
                _sysLog.Error("Error in  InsertFormData", ex);

                return null;
            }
            _sysLog.Debug("Exiting InsertFormData");
        }



       private string InsertGridData(string instanceId,string packageProcessMapId,string processActivityMapId,
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

                 
                                      case "04FCD160-1EC6-471F-97B0-1C6738875C87":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_04FCD1601EC6471F97B01C6738875C87 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT){0}INSERT INTO [04FCD160-1EC6-471F-97B0-1C6738875C87](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence FROM @TBL_04FCD1601EC6471F97B01C6738875C87 TDT
							LEFT JOIN [04FCD160-1EC6-471F-97B0-1C6738875C87] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence";

                                     tempInsertQuery=@"INSERT INTO @TBL_04FCD1601EC6471F97B01C6738875C87(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)VALUES({0});";
                                     

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
                     
                                    case "DD0086FF-AEF5-45C9-A3B5-6CFE3A7C352F":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_DD0086FFAEF545C9A3B56CFE3A7C352F AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT){0}INSERT INTO [DD0086FF-AEF5-45C9-A3B5-6CFE3A7C352F](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence FROM @TBL_DD0086FFAEF545C9A3B56CFE3A7C352F TDT
							LEFT JOIN [DD0086FF-AEF5-45C9-A3B5-6CFE3A7C352F] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence";

                                     tempInsertQuery=@"INSERT INTO @TBL_DD0086FFAEF545C9A3B56CFE3A7C352F(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)VALUES({0});";
                                     

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
                     
                                    case "9CC97541-CC4E-4D16-A92F-2FA4A6460E7B":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_9CC97541CC4E4D16A92F2FA4A6460E7B AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT){0}INSERT INTO [9CC97541-CC4E-4D16-A92F-2FA4A6460E7B](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence FROM @TBL_9CC97541CC4E4D16A92F2FA4A6460E7B TDT
							LEFT JOIN [9CC97541-CC4E-4D16-A92F-2FA4A6460E7B] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence";

                                     tempInsertQuery=@"INSERT INTO @TBL_9CC97541CC4E4D16A92F2FA4A6460E7B(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)VALUES({0});";
                                     

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
		
		DECLARE  @TBL_249EF4459B494EF9804546BD1E6FF8ED AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_R2_ReceiptsId] VARCHAR(MAX)	, [MG_R2_ReceiptSplitUpId] VARCHAR(MAX)	, [MG_R2_UpdatedBy] INT	, [MG_R2_Amount] DECIMAL(18,2)	, [MG_R2_BudgetId] VARCHAR(250)	, [MG_R2_UpdatedOn] DATETIME){0}INSERT INTO [249EF445-9B49-4EF9-8045-46BD1E6FF8ED](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_R2_ReceiptsId,MG_R2_ReceiptSplitUpId,MG_R2_UpdatedBy,MG_R2_Amount,MG_R2_BudgetId,MG_R2_UpdatedOn)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_R2_ReceiptsId,TDT.MG_R2_ReceiptSplitUpId,TDT.MG_R2_UpdatedBy,TDT.MG_R2_Amount,TDT.MG_R2_BudgetId,TDT.MG_R2_UpdatedOn FROM @TBL_249EF4459B494EF9804546BD1E6FF8ED TDT
							LEFT JOIN [249EF445-9B49-4EF9-8045-46BD1E6FF8ED] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_R2_ReceiptsId,MG_R2_ReceiptSplitUpId,MG_R2_UpdatedBy,MG_R2_Amount,MG_R2_BudgetId,MG_R2_UpdatedOn";

                                     tempInsertQuery=@"INSERT INTO @TBL_249EF4459B494EF9804546BD1E6FF8ED(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_R2_ReceiptsId,MG_R2_ReceiptSplitUpId,MG_R2_UpdatedBy,MG_R2_Amount,MG_R2_BudgetId,MG_R2_UpdatedOn)VALUES({0});";
                                     

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
                     
                                    case "AD9C54EC-27A0-4C21-9923-063084E3B588":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_AD9C54EC27A04C219923063084E3B588 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT){0}INSERT INTO [AD9C54EC-27A0-4C21-9923-063084E3B588](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence FROM @TBL_AD9C54EC27A04C219923063084E3B588 TDT
							LEFT JOIN [AD9C54EC-27A0-4C21-9923-063084E3B588] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence";

                                     tempInsertQuery=@"INSERT INTO @TBL_AD9C54EC27A04C219923063084E3B588(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)VALUES({0});";
                                     

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
		
		DECLARE  @TBL_B5EF84C883A94B1C94310489F9EC063B AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT){0}INSERT INTO [B5EF84C8-83A9-4B1C-9431-0489F9EC063B](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence FROM @TBL_B5EF84C883A94B1C94310489F9EC063B TDT
							LEFT JOIN [B5EF84C8-83A9-4B1C-9431-0489F9EC063B] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence";

                                     tempInsertQuery=@"INSERT INTO @TBL_B5EF84C883A94B1C94310489F9EC063B(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)VALUES({0});";
                                     

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
		
		DECLARE  @TBL_FA412DDD7AD949AFB8D72B7E1620D8FC AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT){0}INSERT INTO [FA412DDD-7AD9-49AF-B8D7-2B7E1620D8FC](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence FROM @TBL_FA412DDD7AD949AFB8D72B7E1620D8FC TDT
							LEFT JOIN [FA412DDD-7AD9-49AF-B8D7-2B7E1620D8FC] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence";

                                     tempInsertQuery=@"INSERT INTO @TBL_FA412DDD7AD949AFB8D72B7E1620D8FC(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)VALUES({0});";
                                     

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
		
		DECLARE  @TBL_A694A330AAD54856853CD6AD1573AF0B AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT){0}INSERT INTO [A694A330-AAD5-4856-853C-D6AD1573AF0B](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence FROM @TBL_A694A330AAD54856853CD6AD1573AF0B TDT
							LEFT JOIN [A694A330-AAD5-4856-853C-D6AD1573AF0B] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence";

                                     tempInsertQuery=@"INSERT INTO @TBL_A694A330AAD54856853CD6AD1573AF0B(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)VALUES({0});";
                                     

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
		
		DECLARE  @TBL_8259E1B02F904FE98BE4875AEB9D5F40 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT){0}INSERT INTO [8259E1B0-2F90-4FE9-8BE4-875AEB9D5F40](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence FROM @TBL_8259E1B02F904FE98BE4875AEB9D5F40 TDT
							LEFT JOIN [8259E1B0-2F90-4FE9-8BE4-875AEB9D5F40] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence";

                                     tempInsertQuery=@"INSERT INTO @TBL_8259E1B02F904FE98BE4875AEB9D5F40(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)VALUES({0});";
                                     

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
		
		DECLARE  @TBL_C9F458E5830A413EBD1F94F72A4AFB50 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT){0}INSERT INTO [C9F458E5-830A-413E-BD1F-94F72A4AFB50](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence FROM @TBL_C9F458E5830A413EBD1F94F72A4AFB50 TDT
							LEFT JOIN [C9F458E5-830A-413E-BD1F-94F72A4AFB50] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence";

                                     tempInsertQuery=@"INSERT INTO @TBL_C9F458E5830A413EBD1F94F72A4AFB50(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)VALUES({0});";
                                     

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
		
		DECLARE  @TBL_0BFAF73B02D44680B1C9625AAFB02DB5 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT){0}INSERT INTO [0BFAF73B-02D4-4680-B1C9-625AAFB02DB5](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence FROM @TBL_0BFAF73B02D44680B1C9625AAFB02DB5 TDT
							LEFT JOIN [0BFAF73B-02D4-4680-B1C9-625AAFB02DB5] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence";

                                     tempInsertQuery=@"INSERT INTO @TBL_0BFAF73B02D44680B1C9625AAFB02DB5(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)VALUES({0});";
                                     

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
		
		DECLARE  @TBL_1234ab8abdd089302afdae17d0438c29 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT){0}INSERT INTO [1234ab8a-bdd0-8930-2afd-ae17d0438c29](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence FROM @TBL_1234ab8abdd089302afdae17d0438c29 TDT
							LEFT JOIN [1234ab8a-bdd0-8930-2afd-ae17d0438c29] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence";

                                     tempInsertQuery=@"INSERT INTO @TBL_1234ab8abdd089302afdae17d0438c29(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)VALUES({0});";
                                     

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
		
		DECLARE  @TBL_2624976A0052420C8D20F5C9444C7A48 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT){0}INSERT INTO [2624976A-0052-420C-8D20-F5C9444C7A48](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence FROM @TBL_2624976A0052420C8D20F5C9444C7A48 TDT
							LEFT JOIN [2624976A-0052-420C-8D20-F5C9444C7A48] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence";

                                     tempInsertQuery=@"INSERT INTO @TBL_2624976A0052420C8D20F5C9444C7A48(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)VALUES({0});";
                                     

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
		
		DECLARE  @TBL_7D2812B73A494DA79E48082B26C3333C AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT){0}INSERT INTO [7D2812B7-3A49-4DA7-9E48-082B26C3333C](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence FROM @TBL_7D2812B73A494DA79E48082B26C3333C TDT
							LEFT JOIN [7D2812B7-3A49-4DA7-9E48-082B26C3333C] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence";

                                     tempInsertQuery=@"INSERT INTO @TBL_7D2812B73A494DA79E48082B26C3333C(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)VALUES({0});";
                                     

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
		
		DECLARE  @TBL_9F49372F025542ECAB0531E6C4F9F2EA AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT){0}INSERT INTO [9F49372F-0255-42EC-AB05-31E6C4F9F2EA](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence FROM @TBL_9F49372F025542ECAB0531E6C4F9F2EA TDT
							LEFT JOIN [9F49372F-0255-42EC-AB05-31E6C4F9F2EA] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence";

                                     tempInsertQuery=@"INSERT INTO @TBL_9F49372F025542ECAB0531E6C4F9F2EA(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)VALUES({0});";
                                     

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
                     
                                    case "BD17B4AF-1152-47EA-9EEB-DDA244A8B9F9":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_BD17B4AF115247EA9EEBDDA244A8B9F9 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT){0}INSERT INTO [BD17B4AF-1152-47EA-9EEB-DDA244A8B9F9](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence FROM @TBL_BD17B4AF115247EA9EEBDDA244A8B9F9 TDT
							LEFT JOIN [BD17B4AF-1152-47EA-9EEB-DDA244A8B9F9] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence";

                                     tempInsertQuery=@"INSERT INTO @TBL_BD17B4AF115247EA9EEBDDA244A8B9F9(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)VALUES({0});";
                                     

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
		
		DECLARE  @TBL_e98f57848a4e9d276b7a42c76b854469 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT){0}INSERT INTO [e98f5784-8a4e-9d27-6b7a-42c76b854469](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence FROM @TBL_e98f57848a4e9d276b7a42c76b854469 TDT
							LEFT JOIN [e98f5784-8a4e-9d27-6b7a-42c76b854469] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence";

                                     tempInsertQuery=@"INSERT INTO @TBL_e98f57848a4e9d276b7a42c76b854469(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)VALUES({0});";
                                     

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
		
		DECLARE  @TBL_ee7fd670c5c969f4ccc380f0e8883f29 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT){0}INSERT INTO [ee7fd670-c5c9-69f4-ccc3-80f0e8883f29](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence FROM @TBL_ee7fd670c5c969f4ccc380f0e8883f29 TDT
							LEFT JOIN [ee7fd670-c5c9-69f4-ccc3-80f0e8883f29] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence";

                                     tempInsertQuery=@"INSERT INTO @TBL_ee7fd670c5c969f4ccc380f0e8883f29(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)VALUES({0});";
                                     

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
		
		DECLARE  @TBL_F9CBD66E80AF4A49805E978379D06B55 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT){0}INSERT INTO [F9CBD66E-80AF-4A49-805E-978379D06B55](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence FROM @TBL_F9CBD66E80AF4A49805E978379D06B55 TDT
							LEFT JOIN [F9CBD66E-80AF-4A49-805E-978379D06B55] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence";

                                     tempInsertQuery=@"INSERT INTO @TBL_F9CBD66E80AF4A49805E978379D06B55(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)VALUES({0});";
                                     

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
                     
                                    case "00D69CC2-E6EC-4412-B2A9-14E57A96FB5C":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_00D69CC2E6EC4412B2A914E57A96FB5C AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_P3_ProjectDetailsId] VARCHAR(250)	, [MG_P3_FundTypeId] VARCHAR(250)	, [MG_P3_BudgetHeadId] VARCHAR(250)	, [MG_P3_Amount] DECIMAL(18,2)	, [MG_P3_Employeebasicinfoid] VARCHAR(MAX)	, [MG_P3_ReimbursementId] VARCHAR(MAX)	, [MG_P3_Packageprocessmapid] VARCHAR(MAX)	, [MG_P3_Advanceformid] VARCHAR(MAX)	, [MG_P3_FundDetailsId] VARCHAR(MAX)){0}INSERT INTO [00D69CC2-E6EC-4412-B2A9-14E57A96FB5C](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_P3_ProjectDetailsId,MG_P3_FundTypeId,MG_P3_BudgetHeadId,MG_P3_Amount,MG_P3_Employeebasicinfoid,MG_P3_ReimbursementId,MG_P3_Packageprocessmapid,MG_P3_Advanceformid,MG_P3_FundDetailsId)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_P3_ProjectDetailsId,TDT.MG_P3_FundTypeId,TDT.MG_P3_BudgetHeadId,TDT.MG_P3_Amount,TDT.MG_P3_Employeebasicinfoid,TDT.MG_P3_ReimbursementId,TDT.MG_P3_Packageprocessmapid,TDT.MG_P3_Advanceformid,TDT.MG_P3_FundDetailsId FROM @TBL_00D69CC2E6EC4412B2A914E57A96FB5C TDT
							LEFT JOIN [00D69CC2-E6EC-4412-B2A9-14E57A96FB5C] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_P3_ProjectDetailsId,MG_P3_FundTypeId,MG_P3_BudgetHeadId,MG_P3_Amount,MG_P3_Employeebasicinfoid,MG_P3_ReimbursementId,MG_P3_Packageprocessmapid,MG_P3_Advanceformid,MG_P3_FundDetailsId";

                                     tempInsertQuery=@"INSERT INTO @TBL_00D69CC2E6EC4412B2A914E57A96FB5C(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_P3_ProjectDetailsId,MG_P3_FundTypeId,MG_P3_BudgetHeadId,MG_P3_Amount,MG_P3_Employeebasicinfoid,MG_P3_ReimbursementId,MG_P3_Packageprocessmapid,MG_P3_Advanceformid,MG_P3_FundDetailsId)VALUES({0});";
                                     

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
                     
                                    case "744177F0-C5DD-4666-BE31-646818F67196":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_744177F0C5DD4666BE31646818F67196 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [M_UploadDcoument] VARBINARY(MAX)	, [M_DocumentDetailsId] VARCHAR(MAX)	, [M_DocumentName] VARCHAR(MAX)){0}INSERT INTO [744177F0-C5DD-4666-BE31-646818F67196](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,M_UploadDcoument,M_DocumentDetailsId,M_DocumentName)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.M_UploadDcoument,TDT.M_DocumentDetailsId,TDT.M_DocumentName FROM @TBL_744177F0C5DD4666BE31646818F67196 TDT
							LEFT JOIN [744177F0-C5DD-4666-BE31-646818F67196] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,M_UploadDcoument,M_DocumentDetailsId,M_DocumentName";

                                     tempInsertQuery=@"INSERT INTO @TBL_744177F0C5DD4666BE31646818F67196(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,M_UploadDcoument,M_DocumentDetailsId,M_DocumentName)VALUES({0});";
                                     

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
                     
                                    case "1064BC8E-93B2-409C-BD15-01E2EBC35B41":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_1064BC8E93B2409CBD1501E2EBC35B41 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_ReceivedAmount] DECIMAL(18,2)	, [MG_Commitment] DECIMAL(18,2)	, [MG_Balance] DECIMAL(18,2)	, [MG_Spent] DECIMAL(18,2)	, [MG_SanctionedAmount] DECIMAL(18,2)	, [MG_YetToReceive] DECIMAL(18,2)	, [MG_BudgetName] VARCHAR(MAX)){0}INSERT INTO [1064BC8E-93B2-409C-BD15-01E2EBC35B41](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_ReceivedAmount,MG_Commitment,MG_Balance,MG_Spent,MG_SanctionedAmount,MG_YetToReceive,MG_BudgetName)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_ReceivedAmount,TDT.MG_Commitment,TDT.MG_Balance,TDT.MG_Spent,TDT.MG_SanctionedAmount,TDT.MG_YetToReceive,TDT.MG_BudgetName FROM @TBL_1064BC8E93B2409CBD1501E2EBC35B41 TDT
							LEFT JOIN [1064BC8E-93B2-409C-BD15-01E2EBC35B41] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_ReceivedAmount,MG_Commitment,MG_Balance,MG_Spent,MG_SanctionedAmount,MG_YetToReceive,MG_BudgetName";

                                     tempInsertQuery=@"INSERT INTO @TBL_1064BC8E93B2409CBD1501E2EBC35B41(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_ReceivedAmount,MG_Commitment,MG_Balance,MG_Spent,MG_SanctionedAmount,MG_YetToReceive,MG_BudgetName)VALUES({0});";
                                     

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
                     
                                    case "D74F91B1-1C1A-47A6-BF5F-B731EB2F53FB":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_D74F91B11C1A47A6BF5FB731EB2F53FB AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_P2_BillDate] DATETIME	, [MG_P2_Amount] DECIMAL(18,2)	, [MG_P2_BillDocument] INT	, [MG_P2_BillNo] VARCHAR(MAX)	, [MG_P2_ReimbursementDetailsId] VARCHAR(MAX)	, [MG_P2_ReimbursementId] VARCHAR(MAX)	, [MG_P2_ItemDescription] VARCHAR(MAX)){0}INSERT INTO [D74F91B1-1C1A-47A6-BF5F-B731EB2F53FB](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_P2_BillDate,MG_P2_Amount,MG_P2_BillDocument,MG_P2_BillNo,MG_P2_ReimbursementDetailsId,MG_P2_ReimbursementId,MG_P2_ItemDescription)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_P2_BillDate,TDT.MG_P2_Amount,TDT.MG_P2_BillDocument,TDT.MG_P2_BillNo,TDT.MG_P2_ReimbursementDetailsId,TDT.MG_P2_ReimbursementId,TDT.MG_P2_ItemDescription FROM @TBL_D74F91B11C1A47A6BF5FB731EB2F53FB TDT
							LEFT JOIN [D74F91B1-1C1A-47A6-BF5F-B731EB2F53FB] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_P2_BillDate,MG_P2_Amount,MG_P2_BillDocument,MG_P2_BillNo,MG_P2_ReimbursementDetailsId,MG_P2_ReimbursementId,MG_P2_ItemDescription";

                                     tempInsertQuery=@"INSERT INTO @TBL_D74F91B11C1A47A6BF5FB731EB2F53FB(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_P2_BillDate,MG_P2_Amount,MG_P2_BillDocument,MG_P2_BillNo,MG_P2_ReimbursementDetailsId,MG_P2_ReimbursementId,MG_P2_ItemDescription)VALUES({0});";
                                     

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
                     
                                    case "1356A8F2-1947-4667-987D-2EA211B288A3":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_1356A8F219474667987D2EA211B288A3 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MGA_Amount] DECIMAL(18,2)	, [MGA_AdvanceFormId] VARCHAR(MAX)	, [MGA_DetailsofExpenses] VARCHAR(MAX)	, [MGA_RequestDetailsId] VARCHAR(MAX)	, [MGA_Description] VARCHAR(MAX)){0}INSERT INTO [1356A8F2-1947-4667-987D-2EA211B288A3](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MGA_Amount,MGA_AdvanceFormId,MGA_DetailsofExpenses,MGA_RequestDetailsId,MGA_Description)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MGA_Amount,TDT.MGA_AdvanceFormId,TDT.MGA_DetailsofExpenses,TDT.MGA_RequestDetailsId,TDT.MGA_Description FROM @TBL_1356A8F219474667987D2EA211B288A3 TDT
							LEFT JOIN [1356A8F2-1947-4667-987D-2EA211B288A3] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MGA_Amount,MGA_AdvanceFormId,MGA_DetailsofExpenses,MGA_RequestDetailsId,MGA_Description";

                                     tempInsertQuery=@"INSERT INTO @TBL_1356A8F219474667987D2EA211B288A3(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MGA_Amount,MGA_AdvanceFormId,MGA_DetailsofExpenses,MGA_RequestDetailsId,MGA_Description)VALUES({0});";
                                     

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
                     
                                    case "A65EED98-D95D-45DF-9765-1BDBF01908AD":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_A65EED98D95D45DF97651BDBF01908AD AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [DateOfRemarks] DATETIME	, [RemarksId] VARCHAR(MAX)	, [Remarks] VARCHAR(MAX)	, [ActivityName] VARCHAR(MAX)	, [UserName] VARCHAR(MAX)){0}INSERT INTO [A65EED98-D95D-45DF-9765-1BDBF01908AD](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,DateOfRemarks,RemarksId,Remarks,ActivityName,UserName)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.DateOfRemarks,TDT.RemarksId,TDT.Remarks,TDT.ActivityName,TDT.UserName FROM @TBL_A65EED98D95D45DF97651BDBF01908AD TDT
							LEFT JOIN [A65EED98-D95D-45DF-9765-1BDBF01908AD] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,DateOfRemarks,RemarksId,Remarks,ActivityName,UserName";

                                     tempInsertQuery=@"INSERT INTO @TBL_A65EED98D95D45DF97651BDBF01908AD(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,DateOfRemarks,RemarksId,Remarks,ActivityName,UserName)VALUES({0});";
                                     

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



      public Status GetGridInstanceData(SlotToken token,  
            Context context,out DataTable queryResult,out DataTable pagination)
      {
         _sysLog.Debug("Entering GetGridInstanceData");

         queryResult=null;

         pagination=null;
           
            try
            {

                Database database = GetDatabaseInstance(token);

                
                string getSPName = "GetGridData" + context.WidgetId.Replace("-", "");

                using (DbCommand command = 
                    database.GetStoredProcCommand
                        (getSPName))
                {
                    command.CommandTimeout = 10000;

                     command.CommandTimeout = 10000;

                    database.AddInParameter(command, "InstanceId", DbType.String, context.FormInstanceId);

                    database.AddInParameter(command, "ProcessActivityMapId", DbType.String, context.ProcessActivityMapId);

                    database.AddInParameter(command, "GridId", DbType.String, context.WidgetId);

                    database.AddInParameter(command, "PageDirection", DbType.Int16, context.PageDirection);

                    database.AddInParameter(command, "CurrentRowIndex", DbType.Int64, context.CurrentRowIndex);

                    database.AddInParameter(command, "PageSize", DbType.Int32, context.PageSize);

                    database.AddInParameter(command, "SearchFilter", DbType.String, context.SearchFilter);

                    var queryDataset = database.ExecuteDataSet(command);
                                       
                    //If the data set is not null and if it having tables
                    //then setting the resulting table of index 0 to 
                    //query results data table.
                     if (queryDataset.Tables.Count>0)
                        queryResult = queryDataset.Tables[0];

                    if (queryDataset.Tables.Count > 1)
                    {
                       
                        pagination = queryDataset.Tables[1];
                    }

                    return Status.Success;
                }
            }
            catch(Exception ex)
            {
                _sysLog.Error("Error in GetGridInstanceData", ex);

                return Status.Failure;
            }
            finally
            {
                _sysLog.Debug("Exiting GetGridInstanceData");
            }      
      }

      
     /*  public Status UpdateGridLoopData(string gridId,string gridName,int gridRPP, 
                 Dictionary<string,ServiceElementData> gridData)
        {
            _sysLog.Debug("Entering UpdateGridLoopData");

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


                                         case "04FCD160-1EC6-471F-97B0-1C6738875C87":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_04FCD1601EC6471F97B01C6738875C87 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT){0}INSERT INTO [04FCD160-1EC6-471F-97B0-1C6738875C87](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence FROM @TBL_04FCD1601EC6471F97B01C6738875C87 TDT
							LEFT JOIN [04FCD160-1EC6-471F-97B0-1C6738875C87] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence";

                            tempInsertQuery=@"INSERT INTO @TBL_04FCD1601EC6471F97B01C6738875C87(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)VALUES({0});";

                            splitcols = colList.Split(',');

                            if (splitcols.Length <= 0)
                                return Status.Failure;

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

                                              case "DD0086FF-AEF5-45C9-A3B5-6CFE3A7C352F":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_DD0086FFAEF545C9A3B56CFE3A7C352F AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT){0}INSERT INTO [DD0086FF-AEF5-45C9-A3B5-6CFE3A7C352F](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence FROM @TBL_DD0086FFAEF545C9A3B56CFE3A7C352F TDT
							LEFT JOIN [DD0086FF-AEF5-45C9-A3B5-6CFE3A7C352F] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence";

                            tempInsertQuery=@"INSERT INTO @TBL_DD0086FFAEF545C9A3B56CFE3A7C352F(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)VALUES({0});";

                            splitcols = colList.Split(',');

                            if (splitcols.Length <= 0)
                                return Status.Failure;

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

                                              case "9CC97541-CC4E-4D16-A92F-2FA4A6460E7B":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_9CC97541CC4E4D16A92F2FA4A6460E7B AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT){0}INSERT INTO [9CC97541-CC4E-4D16-A92F-2FA4A6460E7B](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence FROM @TBL_9CC97541CC4E4D16A92F2FA4A6460E7B TDT
							LEFT JOIN [9CC97541-CC4E-4D16-A92F-2FA4A6460E7B] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence";

                            tempInsertQuery=@"INSERT INTO @TBL_9CC97541CC4E4D16A92F2FA4A6460E7B(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)VALUES({0});";

                            splitcols = colList.Split(',');

                            if (splitcols.Length <= 0)
                                return Status.Failure;

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
                                return Status.Failure;

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
                                return Status.Failure;

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
                                return Status.Failure;

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
		
		DECLARE  @TBL_249EF4459B494EF9804546BD1E6FF8ED AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_R2_ReceiptsId] VARCHAR(MAX)	, [MG_R2_ReceiptSplitUpId] VARCHAR(MAX)	, [MG_R2_UpdatedBy] INT	, [MG_R2_Amount] DECIMAL(18,2)	, [MG_R2_BudgetId] VARCHAR(250)	, [MG_R2_UpdatedOn] DATETIME){0}INSERT INTO [249EF445-9B49-4EF9-8045-46BD1E6FF8ED](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_R2_ReceiptsId,MG_R2_ReceiptSplitUpId,MG_R2_UpdatedBy,MG_R2_Amount,MG_R2_BudgetId,MG_R2_UpdatedOn)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_R2_ReceiptsId,TDT.MG_R2_ReceiptSplitUpId,TDT.MG_R2_UpdatedBy,TDT.MG_R2_Amount,TDT.MG_R2_BudgetId,TDT.MG_R2_UpdatedOn FROM @TBL_249EF4459B494EF9804546BD1E6FF8ED TDT
							LEFT JOIN [249EF445-9B49-4EF9-8045-46BD1E6FF8ED] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_R2_ReceiptsId,MG_R2_ReceiptSplitUpId,MG_R2_UpdatedBy,MG_R2_Amount,MG_R2_BudgetId,MG_R2_UpdatedOn";

                            tempInsertQuery=@"INSERT INTO @TBL_249EF4459B494EF9804546BD1E6FF8ED(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_R2_ReceiptsId,MG_R2_ReceiptSplitUpId,MG_R2_UpdatedBy,MG_R2_Amount,MG_R2_BudgetId,MG_R2_UpdatedOn)VALUES({0});";

                            splitcols = colList.Split(',');

                            if (splitcols.Length <= 0)
                                return Status.Failure;

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

                                              case "AD9C54EC-27A0-4C21-9923-063084E3B588":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_AD9C54EC27A04C219923063084E3B588 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT){0}INSERT INTO [AD9C54EC-27A0-4C21-9923-063084E3B588](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence FROM @TBL_AD9C54EC27A04C219923063084E3B588 TDT
							LEFT JOIN [AD9C54EC-27A0-4C21-9923-063084E3B588] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence";

                            tempInsertQuery=@"INSERT INTO @TBL_AD9C54EC27A04C219923063084E3B588(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)VALUES({0});";

                            splitcols = colList.Split(',');

                            if (splitcols.Length <= 0)
                                return Status.Failure;

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
		
		DECLARE  @TBL_B5EF84C883A94B1C94310489F9EC063B AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT){0}INSERT INTO [B5EF84C8-83A9-4B1C-9431-0489F9EC063B](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence FROM @TBL_B5EF84C883A94B1C94310489F9EC063B TDT
							LEFT JOIN [B5EF84C8-83A9-4B1C-9431-0489F9EC063B] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence";

                            tempInsertQuery=@"INSERT INTO @TBL_B5EF84C883A94B1C94310489F9EC063B(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)VALUES({0});";

                            splitcols = colList.Split(',');

                            if (splitcols.Length <= 0)
                                return Status.Failure;

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
                                return Status.Failure;

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
                                return Status.Failure;

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
		
		DECLARE  @TBL_FA412DDD7AD949AFB8D72B7E1620D8FC AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT){0}INSERT INTO [FA412DDD-7AD9-49AF-B8D7-2B7E1620D8FC](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence FROM @TBL_FA412DDD7AD949AFB8D72B7E1620D8FC TDT
							LEFT JOIN [FA412DDD-7AD9-49AF-B8D7-2B7E1620D8FC] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence";

                            tempInsertQuery=@"INSERT INTO @TBL_FA412DDD7AD949AFB8D72B7E1620D8FC(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)VALUES({0});";

                            splitcols = colList.Split(',');

                            if (splitcols.Length <= 0)
                                return Status.Failure;

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
                                return Status.Failure;

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
                                return Status.Failure;

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
		
		DECLARE  @TBL_A694A330AAD54856853CD6AD1573AF0B AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT){0}INSERT INTO [A694A330-AAD5-4856-853C-D6AD1573AF0B](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence FROM @TBL_A694A330AAD54856853CD6AD1573AF0B TDT
							LEFT JOIN [A694A330-AAD5-4856-853C-D6AD1573AF0B] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence";

                            tempInsertQuery=@"INSERT INTO @TBL_A694A330AAD54856853CD6AD1573AF0B(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)VALUES({0});";

                            splitcols = colList.Split(',');

                            if (splitcols.Length <= 0)
                                return Status.Failure;

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
                                return Status.Failure;

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
		
		DECLARE  @TBL_8259E1B02F904FE98BE4875AEB9D5F40 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT){0}INSERT INTO [8259E1B0-2F90-4FE9-8BE4-875AEB9D5F40](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence FROM @TBL_8259E1B02F904FE98BE4875AEB9D5F40 TDT
							LEFT JOIN [8259E1B0-2F90-4FE9-8BE4-875AEB9D5F40] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence";

                            tempInsertQuery=@"INSERT INTO @TBL_8259E1B02F904FE98BE4875AEB9D5F40(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)VALUES({0});";

                            splitcols = colList.Split(',');

                            if (splitcols.Length <= 0)
                                return Status.Failure;

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
		
		DECLARE  @TBL_C9F458E5830A413EBD1F94F72A4AFB50 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT){0}INSERT INTO [C9F458E5-830A-413E-BD1F-94F72A4AFB50](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence FROM @TBL_C9F458E5830A413EBD1F94F72A4AFB50 TDT
							LEFT JOIN [C9F458E5-830A-413E-BD1F-94F72A4AFB50] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence";

                            tempInsertQuery=@"INSERT INTO @TBL_C9F458E5830A413EBD1F94F72A4AFB50(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)VALUES({0});";

                            splitcols = colList.Split(',');

                            if (splitcols.Length <= 0)
                                return Status.Failure;

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
		
		DECLARE  @TBL_0BFAF73B02D44680B1C9625AAFB02DB5 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT){0}INSERT INTO [0BFAF73B-02D4-4680-B1C9-625AAFB02DB5](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence FROM @TBL_0BFAF73B02D44680B1C9625AAFB02DB5 TDT
							LEFT JOIN [0BFAF73B-02D4-4680-B1C9-625AAFB02DB5] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence";

                            tempInsertQuery=@"INSERT INTO @TBL_0BFAF73B02D44680B1C9625AAFB02DB5(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)VALUES({0});";

                            splitcols = colList.Split(',');

                            if (splitcols.Length <= 0)
                                return Status.Failure;

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
		
		DECLARE  @TBL_1234ab8abdd089302afdae17d0438c29 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT){0}INSERT INTO [1234ab8a-bdd0-8930-2afd-ae17d0438c29](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence FROM @TBL_1234ab8abdd089302afdae17d0438c29 TDT
							LEFT JOIN [1234ab8a-bdd0-8930-2afd-ae17d0438c29] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence";

                            tempInsertQuery=@"INSERT INTO @TBL_1234ab8abdd089302afdae17d0438c29(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)VALUES({0});";

                            splitcols = colList.Split(',');

                            if (splitcols.Length <= 0)
                                return Status.Failure;

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
		
		DECLARE  @TBL_2624976A0052420C8D20F5C9444C7A48 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT){0}INSERT INTO [2624976A-0052-420C-8D20-F5C9444C7A48](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence FROM @TBL_2624976A0052420C8D20F5C9444C7A48 TDT
							LEFT JOIN [2624976A-0052-420C-8D20-F5C9444C7A48] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence";

                            tempInsertQuery=@"INSERT INTO @TBL_2624976A0052420C8D20F5C9444C7A48(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)VALUES({0});";

                            splitcols = colList.Split(',');

                            if (splitcols.Length <= 0)
                                return Status.Failure;

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
		
		DECLARE  @TBL_7D2812B73A494DA79E48082B26C3333C AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT){0}INSERT INTO [7D2812B7-3A49-4DA7-9E48-082B26C3333C](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence FROM @TBL_7D2812B73A494DA79E48082B26C3333C TDT
							LEFT JOIN [7D2812B7-3A49-4DA7-9E48-082B26C3333C] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence";

                            tempInsertQuery=@"INSERT INTO @TBL_7D2812B73A494DA79E48082B26C3333C(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)VALUES({0});";

                            splitcols = colList.Split(',');

                            if (splitcols.Length <= 0)
                                return Status.Failure;

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
		
		DECLARE  @TBL_9F49372F025542ECAB0531E6C4F9F2EA AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT){0}INSERT INTO [9F49372F-0255-42EC-AB05-31E6C4F9F2EA](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence FROM @TBL_9F49372F025542ECAB0531E6C4F9F2EA TDT
							LEFT JOIN [9F49372F-0255-42EC-AB05-31E6C4F9F2EA] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence";

                            tempInsertQuery=@"INSERT INTO @TBL_9F49372F025542ECAB0531E6C4F9F2EA(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)VALUES({0});";

                            splitcols = colList.Split(',');

                            if (splitcols.Length <= 0)
                                return Status.Failure;

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

                                              case "BD17B4AF-1152-47EA-9EEB-DDA244A8B9F9":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_BD17B4AF115247EA9EEBDDA244A8B9F9 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT){0}INSERT INTO [BD17B4AF-1152-47EA-9EEB-DDA244A8B9F9](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence FROM @TBL_BD17B4AF115247EA9EEBDDA244A8B9F9 TDT
							LEFT JOIN [BD17B4AF-1152-47EA-9EEB-DDA244A8B9F9] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence";

                            tempInsertQuery=@"INSERT INTO @TBL_BD17B4AF115247EA9EEBDDA244A8B9F9(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)VALUES({0});";

                            splitcols = colList.Split(',');

                            if (splitcols.Length <= 0)
                                return Status.Failure;

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
		
		DECLARE  @TBL_e98f57848a4e9d276b7a42c76b854469 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT){0}INSERT INTO [e98f5784-8a4e-9d27-6b7a-42c76b854469](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence FROM @TBL_e98f57848a4e9d276b7a42c76b854469 TDT
							LEFT JOIN [e98f5784-8a4e-9d27-6b7a-42c76b854469] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence";

                            tempInsertQuery=@"INSERT INTO @TBL_e98f57848a4e9d276b7a42c76b854469(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)VALUES({0});";

                            splitcols = colList.Split(',');

                            if (splitcols.Length <= 0)
                                return Status.Failure;

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
		
		DECLARE  @TBL_ee7fd670c5c969f4ccc380f0e8883f29 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT){0}INSERT INTO [ee7fd670-c5c9-69f4-ccc3-80f0e8883f29](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence FROM @TBL_ee7fd670c5c969f4ccc380f0e8883f29 TDT
							LEFT JOIN [ee7fd670-c5c9-69f4-ccc3-80f0e8883f29] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence";

                            tempInsertQuery=@"INSERT INTO @TBL_ee7fd670c5c969f4ccc380f0e8883f29(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)VALUES({0});";

                            splitcols = colList.Split(',');

                            if (splitcols.Length <= 0)
                                return Status.Failure;

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
		
		DECLARE  @TBL_F9CBD66E80AF4A49805E978379D06B55 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT){0}INSERT INTO [F9CBD66E-80AF-4A49-805E-978379D06B55](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence FROM @TBL_F9CBD66E80AF4A49805E978379D06B55 TDT
							LEFT JOIN [F9CBD66E-80AF-4A49-805E-978379D06B55] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence";

                            tempInsertQuery=@"INSERT INTO @TBL_F9CBD66E80AF4A49805E978379D06B55(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)VALUES({0});";

                            splitcols = colList.Split(',');

                            if (splitcols.Length <= 0)
                                return Status.Failure;

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

                                              case "00D69CC2-E6EC-4412-B2A9-14E57A96FB5C":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_00D69CC2E6EC4412B2A914E57A96FB5C AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_P3_ProjectDetailsId] VARCHAR(250)	, [MG_P3_FundTypeId] VARCHAR(250)	, [MG_P3_BudgetHeadId] VARCHAR(250)	, [MG_P3_Amount] DECIMAL(18,2)	, [MG_P3_Employeebasicinfoid] VARCHAR(MAX)	, [MG_P3_ReimbursementId] VARCHAR(MAX)	, [MG_P3_Packageprocessmapid] VARCHAR(MAX)	, [MG_P3_Advanceformid] VARCHAR(MAX)	, [MG_P3_FundDetailsId] VARCHAR(MAX)){0}INSERT INTO [00D69CC2-E6EC-4412-B2A9-14E57A96FB5C](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_P3_ProjectDetailsId,MG_P3_FundTypeId,MG_P3_BudgetHeadId,MG_P3_Amount,MG_P3_Employeebasicinfoid,MG_P3_ReimbursementId,MG_P3_Packageprocessmapid,MG_P3_Advanceformid,MG_P3_FundDetailsId)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_P3_ProjectDetailsId,TDT.MG_P3_FundTypeId,TDT.MG_P3_BudgetHeadId,TDT.MG_P3_Amount,TDT.MG_P3_Employeebasicinfoid,TDT.MG_P3_ReimbursementId,TDT.MG_P3_Packageprocessmapid,TDT.MG_P3_Advanceformid,TDT.MG_P3_FundDetailsId FROM @TBL_00D69CC2E6EC4412B2A914E57A96FB5C TDT
							LEFT JOIN [00D69CC2-E6EC-4412-B2A9-14E57A96FB5C] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_P3_ProjectDetailsId,MG_P3_FundTypeId,MG_P3_BudgetHeadId,MG_P3_Amount,MG_P3_Employeebasicinfoid,MG_P3_ReimbursementId,MG_P3_Packageprocessmapid,MG_P3_Advanceformid,MG_P3_FundDetailsId";

                            tempInsertQuery=@"INSERT INTO @TBL_00D69CC2E6EC4412B2A914E57A96FB5C(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_P3_ProjectDetailsId,MG_P3_FundTypeId,MG_P3_BudgetHeadId,MG_P3_Amount,MG_P3_Employeebasicinfoid,MG_P3_ReimbursementId,MG_P3_Packageprocessmapid,MG_P3_Advanceformid,MG_P3_FundDetailsId)VALUES({0});";

                            splitcols = colList.Split(',');

                            if (splitcols.Length <= 0)
                                return Status.Failure;

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

                                              case "744177F0-C5DD-4666-BE31-646818F67196":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_744177F0C5DD4666BE31646818F67196 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [M_UploadDcoument] VARBINARY(MAX)	, [M_DocumentDetailsId] VARCHAR(MAX)	, [M_DocumentName] VARCHAR(MAX)){0}INSERT INTO [744177F0-C5DD-4666-BE31-646818F67196](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,M_UploadDcoument,M_DocumentDetailsId,M_DocumentName)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.M_UploadDcoument,TDT.M_DocumentDetailsId,TDT.M_DocumentName FROM @TBL_744177F0C5DD4666BE31646818F67196 TDT
							LEFT JOIN [744177F0-C5DD-4666-BE31-646818F67196] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,M_UploadDcoument,M_DocumentDetailsId,M_DocumentName";

                            tempInsertQuery=@"INSERT INTO @TBL_744177F0C5DD4666BE31646818F67196(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,M_UploadDcoument,M_DocumentDetailsId,M_DocumentName)VALUES({0});";

                            splitcols = colList.Split(',');

                            if (splitcols.Length <= 0)
                                return Status.Failure;

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

                                              case "1064BC8E-93B2-409C-BD15-01E2EBC35B41":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_1064BC8E93B2409CBD1501E2EBC35B41 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_ReceivedAmount] DECIMAL(18,2)	, [MG_Commitment] DECIMAL(18,2)	, [MG_Balance] DECIMAL(18,2)	, [MG_Spent] DECIMAL(18,2)	, [MG_SanctionedAmount] DECIMAL(18,2)	, [MG_YetToReceive] DECIMAL(18,2)	, [MG_BudgetName] VARCHAR(MAX)){0}INSERT INTO [1064BC8E-93B2-409C-BD15-01E2EBC35B41](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_ReceivedAmount,MG_Commitment,MG_Balance,MG_Spent,MG_SanctionedAmount,MG_YetToReceive,MG_BudgetName)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_ReceivedAmount,TDT.MG_Commitment,TDT.MG_Balance,TDT.MG_Spent,TDT.MG_SanctionedAmount,TDT.MG_YetToReceive,TDT.MG_BudgetName FROM @TBL_1064BC8E93B2409CBD1501E2EBC35B41 TDT
							LEFT JOIN [1064BC8E-93B2-409C-BD15-01E2EBC35B41] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_ReceivedAmount,MG_Commitment,MG_Balance,MG_Spent,MG_SanctionedAmount,MG_YetToReceive,MG_BudgetName";

                            tempInsertQuery=@"INSERT INTO @TBL_1064BC8E93B2409CBD1501E2EBC35B41(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_ReceivedAmount,MG_Commitment,MG_Balance,MG_Spent,MG_SanctionedAmount,MG_YetToReceive,MG_BudgetName)VALUES({0});";

                            splitcols = colList.Split(',');

                            if (splitcols.Length <= 0)
                                return Status.Failure;

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

                                              case "D74F91B1-1C1A-47A6-BF5F-B731EB2F53FB":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_D74F91B11C1A47A6BF5FB731EB2F53FB AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_P2_BillDate] DATETIME	, [MG_P2_Amount] DECIMAL(18,2)	, [MG_P2_BillDocument] INT	, [MG_P2_BillNo] VARCHAR(MAX)	, [MG_P2_ReimbursementDetailsId] VARCHAR(MAX)	, [MG_P2_ReimbursementId] VARCHAR(MAX)	, [MG_P2_ItemDescription] VARCHAR(MAX)){0}INSERT INTO [D74F91B1-1C1A-47A6-BF5F-B731EB2F53FB](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_P2_BillDate,MG_P2_Amount,MG_P2_BillDocument,MG_P2_BillNo,MG_P2_ReimbursementDetailsId,MG_P2_ReimbursementId,MG_P2_ItemDescription)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_P2_BillDate,TDT.MG_P2_Amount,TDT.MG_P2_BillDocument,TDT.MG_P2_BillNo,TDT.MG_P2_ReimbursementDetailsId,TDT.MG_P2_ReimbursementId,TDT.MG_P2_ItemDescription FROM @TBL_D74F91B11C1A47A6BF5FB731EB2F53FB TDT
							LEFT JOIN [D74F91B1-1C1A-47A6-BF5F-B731EB2F53FB] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_P2_BillDate,MG_P2_Amount,MG_P2_BillDocument,MG_P2_BillNo,MG_P2_ReimbursementDetailsId,MG_P2_ReimbursementId,MG_P2_ItemDescription";

                            tempInsertQuery=@"INSERT INTO @TBL_D74F91B11C1A47A6BF5FB731EB2F53FB(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_P2_BillDate,MG_P2_Amount,MG_P2_BillDocument,MG_P2_BillNo,MG_P2_ReimbursementDetailsId,MG_P2_ReimbursementId,MG_P2_ItemDescription)VALUES({0});";

                            splitcols = colList.Split(',');

                            if (splitcols.Length <= 0)
                                return Status.Failure;

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

                                              case "1356A8F2-1947-4667-987D-2EA211B288A3":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_1356A8F219474667987D2EA211B288A3 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MGA_Amount] DECIMAL(18,2)	, [MGA_AdvanceFormId] VARCHAR(MAX)	, [MGA_DetailsofExpenses] VARCHAR(MAX)	, [MGA_RequestDetailsId] VARCHAR(MAX)	, [MGA_Description] VARCHAR(MAX)){0}INSERT INTO [1356A8F2-1947-4667-987D-2EA211B288A3](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MGA_Amount,MGA_AdvanceFormId,MGA_DetailsofExpenses,MGA_RequestDetailsId,MGA_Description)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MGA_Amount,TDT.MGA_AdvanceFormId,TDT.MGA_DetailsofExpenses,TDT.MGA_RequestDetailsId,TDT.MGA_Description FROM @TBL_1356A8F219474667987D2EA211B288A3 TDT
							LEFT JOIN [1356A8F2-1947-4667-987D-2EA211B288A3] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MGA_Amount,MGA_AdvanceFormId,MGA_DetailsofExpenses,MGA_RequestDetailsId,MGA_Description";

                            tempInsertQuery=@"INSERT INTO @TBL_1356A8F219474667987D2EA211B288A3(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MGA_Amount,MGA_AdvanceFormId,MGA_DetailsofExpenses,MGA_RequestDetailsId,MGA_Description)VALUES({0});";

                            splitcols = colList.Split(',');

                            if (splitcols.Length <= 0)
                                return Status.Failure;

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

                                              case "A65EED98-D95D-45DF-9765-1BDBF01908AD":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_A65EED98D95D45DF97651BDBF01908AD AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [DateOfRemarks] DATETIME	, [RemarksId] VARCHAR(MAX)	, [Remarks] VARCHAR(MAX)	, [ActivityName] VARCHAR(MAX)	, [UserName] VARCHAR(MAX)){0}INSERT INTO [A65EED98-D95D-45DF-9765-1BDBF01908AD](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,DateOfRemarks,RemarksId,Remarks,ActivityName,UserName)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.DateOfRemarks,TDT.RemarksId,TDT.Remarks,TDT.ActivityName,TDT.UserName FROM @TBL_A65EED98D95D45DF97651BDBF01908AD TDT
							LEFT JOIN [A65EED98-D95D-45DF-9765-1BDBF01908AD] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,DateOfRemarks,RemarksId,Remarks,ActivityName,UserName";

                            tempInsertQuery=@"INSERT INTO @TBL_A65EED98D95D45DF97651BDBF01908AD(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,DateOfRemarks,RemarksId,Remarks,ActivityName,UserName)VALUES({0});";

                            splitcols = colList.Split(',');

                            if (splitcols.Length <= 0)
                                return Status.Failure;

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

                var database = GetDatabaseInstance();

                using (DbCommand command =
                                   database.GetSqlStringCommand
                                       (bulkInsertQuery))
                {
                    command.CommandTimeout = 10000;

                    database.ExecuteNonQuery(command);

                }               

                return Status.Success;

            }
            catch (Exception ex)
            {
                _sysLog.Error("Error in  UpdateGridLoopData", ex);

                return Status.Failure;
            }
           
        }
        */


         public Status UpdateGridLoopData(string bulkInsertQuery)
        {
            _sysLog.Debug("Entering UpdateGridLoopData");

            try
            {

                var database = GetDatabaseInstance();

                using (DbCommand command =
                                   database.GetSqlStringCommand
                                       (bulkInsertQuery))
                {
                    command.CommandTimeout = 10000;

                    database.ExecuteNonQuery(command);

                }               

                return Status.Success;

            }
            catch (Exception ex)
            {
                _sysLog.Error("Error in  UpdateGridLoopData", ex);

                return Status.Failure;
            }
           
        }

        public Status DeleteGridInstanceData(Context context)
        {
            _sysLog.Debug("Entering DeleteGridInstanceData");

            var instanceId = context.FormInstanceId;

            var processActivityMapId = context.ProcessActivityMapId;


            try
            {
                Database database = GetDatabaseInstance();


                string getSPName = "DeleteGridData" + context.WidgetId.Replace("-", "");

                using (DbCommand command =
                    database.GetStoredProcCommand
                        (getSPName))
                {
                    command.CommandTimeout = 10000;

                    database.AddInParameter(command, "InstanceId", DbType.String, instanceId);

                    database.AddInParameter(command, "ProcessActivityMapId", DbType.String, processActivityMapId);

                    database.AddInParameter(command, "GridId", DbType.String, context.WidgetId);

                    database.AddInParameter(command, "RowIds", DbType.String, context.SelectedRowIds);

                    database.ExecuteNonQuery(command);


                    return Status.Success;
                }
            }
            catch (Exception ex)
            {

                _sysLog.Error("Error in DeleteGridInstanceData", ex);

                return Status.Failure;
            }
        }

        public Status AggregateGridData(string tableName, string gridColumnName, 
                string aggregatorType, string filter,string instanceId, out object aggregateValue)
        {
             _sysLog.Debug("Entering AggregateGridData");

            aggregateValue = null;

            var sqlQuery = @"SELECT {0} FROM {1} WHERE InstanceId='{3}' AND 1=1 {2}";

            try
            {
                var db = GetProofInstance();

                if (string.IsNullOrEmpty(filter))
                    filter = string.Empty;

                string aggfunction = string.Empty;

                switch (aggregatorType.ToLower())
                {
                    case "sum":

                        aggfunction = string.Concat("SUM(", gridColumnName, ")");                        

                        sqlQuery = string.Format(sqlQuery, aggfunction,tableName,filter,instanceId);

                        break;

                    case "average":
                        aggfunction = string.Concat("AVG(", gridColumnName, ")");

                        sqlQuery = string.Format(sqlQuery, aggfunction, tableName, filter);

                        break;

                    case "count":
                        aggfunction = string.Concat("COUNT(", gridColumnName, ")");

                        sqlQuery = string.Format(sqlQuery, aggfunction, tableName, filter);

                        break;
                    case "min":
                        aggfunction = string.Concat("MIN(", gridColumnName, ")");

                        sqlQuery = string.Format(sqlQuery, aggfunction, tableName, filter);

                        break;
                    case "max":
                        aggfunction = string.Concat("MAX(", gridColumnName, ")");

                        sqlQuery = string.Format(sqlQuery, aggfunction, tableName, filter);

                        break;
                    case "stDev":
                        aggfunction = string.Concat("STDEV(", gridColumnName, ")");

                        sqlQuery = string.Format(sqlQuery, aggfunction, tableName, filter);

                        break;



                }               

                using(var command= db.GetSqlStringCommand(sqlQuery))
                {
                    aggregateValue=db.ExecuteScalar(command);
                }

                return Status.Success;

            }
            catch(Exception ex)
            {
                _sysLog.Error("Error in AggregateGridData");

                return Status.Failure;
            }
            finally
            {

                _sysLog.Debug("Exting AggregateGridData");
            }
        }
       
        public Status FilterResponseByRBAC(string packageProcessMapId, string processActivityMapId,
            long roleMapId, ref Dictionary<string, ServiceElementData> ISpace)
        {
            _sysLog.Debug("Entering DeleteGridInstanceData");

           DataTable  outdata = null;
            IDataReader reader = null;
            try
            {  
                Database database = GetDatabaseInstance();

                return Status.Success;

            }

            catch (Exception ex)
            {
                return Status.Failure;
            }
        }



        public Status FilterResponseByRBAC(
     string packageProcessMapId,
     string processActivityMapId,
     long roleMapId,
     ref Dictionary<string, ServiceElementData> ISpace,
     out DataSet resultData)
        {
            _sysLog.Debug("Entering FilterResponseByRBAC");

            resultData = new DataSet();
            IDataReader reader= null;   

            try
            {
                var db = GetInnovaceNoCodeInstance();

                using (var cmd = db.GetStoredProcCommand("GetRbackActions"))
                {
                    db.AddInParameter(cmd, "@FormId", DbType.String, packageProcessMapId);
                    db.AddInParameter(cmd, "@Rolemapid", DbType.Int64, roleMapId);
                    db.AddInParameter(cmd, "@ViewId", DbType.String, processActivityMapId);
                     
                    using (  reader = db.ExecuteReader(cmd))
                    {
                        resultData.Load(reader, LoadOption.OverwriteChanges,
                            "InvisibleElementIds",
                            "MandatoryElementIds",
                            "DisableElementIds");
                    } 

                }

                return Status.Success;
            }
            catch (Exception ex)
            {
                _sysLog.Error("Error in FilterResponseByRBAC", ex);
                return Status.Failure;
            }
            finally
            {
                if (reader != null && !reader.IsClosed)
                    reader.Close();
            }
        }

        protected Database GetInnovaceNoCodeInstance()
        {
            var innovaceConnection = AppParams.GetAppValue("NoCodeConnection");

            return new SqlDatabase
                (AppParams.GetValue(innovaceConnection));

        }
    }
}