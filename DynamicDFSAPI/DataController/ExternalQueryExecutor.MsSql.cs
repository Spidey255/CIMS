
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

                
                                      case "7816392B-A9EF-486D-88F9-AC7C972D679B":
                    {
                     
                                     fInsertQuery=@"IF NOT EXISTS(SELECT 1 FROM [7816392B-A9EF-486D-88F9-AC7C972D679B] WHERE InstanceId='{0}' AND
							ProcessActivityMapId='{1}' AND FormId='{2}') BEGIN INSERT INTO [7816392B-A9EF-486D-88F9-AC7C972D679B](InstanceId,ProcessActivityMapId,MF_V1_SanctionedValue,F_ProjectDetailsId,MF_ActiveCount,MF_ProposalCount,MF_CompletedCount,MF_SanctionedCount,MF_ActiveAmount,MF_ProjectListActiveProjectspr_PageIndex,MF_ProjectListActiveProjectspr_TotalPages,MF_V1_ProjectDetailsID,MF_V1_ProjectTitle,MF_V1_ProjectNo,MF_V1_Department,MF_V1_PI,MF_V1_CoPI,MF_V1_ProjectType,MF_V1_Agency,MF_V1_StartDate,MF_V1_EndDate,MF_V1_Duration,MF_V1_FinancialYear,MF_Option,Subject,ExecutionStatus,ExecutionMessage,SetDestinationTo,SLATime,MF_ProjectListActiveProjectspr_GridRows,MF_ProjectListActiveProjectspr_RecordsRange,MF_CompletedAmount,MF_ProposalAmount,MF_SanctionedAmount,RedirectUrl,MF_URL)
							VALUES( {3}) END ELSE BEGIN UPDATE [7816392B-A9EF-486D-88F9-AC7C972D679B]SET {4}WHERE InstanceId='{0}'AND ProcessActivityMapId='{1}'AND FormId='{2}'END ";

                                     colList=@"InstanceId,ProcessActivityMapId,MF_V1_SanctionedValue,F_ProjectDetailsId,MF_ActiveCount,MF_ProposalCount,MF_CompletedCount,MF_SanctionedCount,MF_ActiveAmount,MF_ProjectListActiveProjectspr_PageIndex,MF_ProjectListActiveProjectspr_TotalPages,MF_V1_ProjectDetailsID,MF_V1_ProjectTitle,MF_V1_ProjectNo,MF_V1_Department,MF_V1_PI,MF_V1_CoPI,MF_V1_ProjectType,MF_V1_Agency,MF_V1_StartDate,MF_V1_EndDate,MF_V1_Duration,MF_V1_FinancialYear,MF_Option,Subject,ExecutionStatus,ExecutionMessage,SetDestinationTo,SLATime,MF_ProjectListActiveProjectspr_GridRows,MF_ProjectListActiveProjectspr_RecordsRange,MF_CompletedAmount,MF_ProposalAmount,MF_SanctionedAmount,RedirectUrl,MF_URL";
                                    
                     
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
                
                       
                      case "E0AC6667-6D92-49AA-8F4D-01F473F2E426":
                    {
                     
                                     fInsertQuery=@"IF NOT EXISTS(SELECT 1 FROM [E0AC6667-6D92-49AA-8F4D-01F473F2E426] WHERE InstanceId='{0}' AND
							ProcessActivityMapId='{1}' AND FormId='{2}') BEGIN INSERT INTO [E0AC6667-6D92-49AA-8F4D-01F473F2E426](InstanceId,ProcessActivityMapId,Subject,ExecutionStatus,ExecutionMessage,SetDestinationTo,SLATime,MF_d1_ProjectProposalID,MF_d1_ProjectRefNo,MF_d1_ProjectCategoryID,MF_d1_FinancialYearID,MF_d1_DepartmentID,MF_d1_Designation,MF_d1_ProjectName,MF_d1_ProjectType,MF_d1_FundingAgency,MF_d1_ProjectBudget,MF_d1_Remarks,MF_d1_PrincipalInvestigator,MF_d1_EmployeeBasicInfoId,MF_d1_ProjectStatus,MF_d1_SectorID,MF_d1_EndorsementFileType,MF_d1_ProposalCode,MF_d1_IsSubmitted,MF_d1_OverHead,MF_d1_IfExternalInstitute,MF_d1_UpdatedBy,MF_d1_UpdatedOn,AssignToRole,AssignToUser,IN_Priority,IN_InstanceName,IN_SLA,IN_Status,IN_Category,ExecuteCommand,RedirectUrl,Thumbnail,CancelRedirectUrl,KeyContext,DisplayContext,growid,MF_d1_Currency,M_DepartmentId,M_DesignationId,Dept,DummyInstance,FormId)
							VALUES( {3}) END ELSE BEGIN UPDATE [E0AC6667-6D92-49AA-8F4D-01F473F2E426]SET {4}WHERE InstanceId='{0}'AND ProcessActivityMapId='{1}'AND FormId='{2}'END ";

                                     colList=@"InstanceId,ProcessActivityMapId,Subject,ExecutionStatus,ExecutionMessage,SetDestinationTo,SLATime,MF_d1_ProjectProposalID,MF_d1_ProjectRefNo,MF_d1_ProjectCategoryID,MF_d1_FinancialYearID,MF_d1_DepartmentID,MF_d1_Designation,MF_d1_ProjectName,MF_d1_ProjectType,MF_d1_FundingAgency,MF_d1_ProjectBudget,MF_d1_Remarks,MF_d1_PrincipalInvestigator,MF_d1_EmployeeBasicInfoId,MF_d1_ProjectStatus,MF_d1_SectorID,MF_d1_EndorsementFileType,MF_d1_ProposalCode,MF_d1_IsSubmitted,MF_d1_OverHead,MF_d1_IfExternalInstitute,MF_d1_UpdatedBy,MF_d1_UpdatedOn,AssignToRole,AssignToUser,IN_Priority,IN_InstanceName,IN_SLA,IN_Status,IN_Category,ExecuteCommand,RedirectUrl,Thumbnail,CancelRedirectUrl,KeyContext,DisplayContext,growid,MF_d1_Currency,M_DepartmentId,M_DesignationId,Dept,DummyInstance,FormId";
                                    
                     
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
							ProcessActivityMapId='{1}' AND FormId='{2}') BEGIN INSERT INTO [DA3904EF-0E60-44D0-943E-2E97494B15C8](ProcessActivityMapId,FormId,ExecutionMessage,ExecutionStatus,Subject,SetDestinationTo,MF_ProjectDetailsId,SLATime,MF_ProjectNo,MF_UserName,InstanceId)
							VALUES( {3}) END ELSE BEGIN UPDATE [DA3904EF-0E60-44D0-943E-2E97494B15C8]SET {4}WHERE InstanceId='{0}'AND ProcessActivityMapId='{1}'AND FormId='{2}'END ";

                                     colList=@"ProcessActivityMapId,FormId,ExecutionMessage,ExecutionStatus,Subject,SetDestinationTo,MF_ProjectDetailsId,SLATime,MF_ProjectNo,MF_UserName,InstanceId";
                                    
                     
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
                
                       
                      case "781F63B4-048D-4578-AF08-83C4E8FC0483":
                    {
                     
                                     fInsertQuery=@"IF NOT EXISTS(SELECT 1 FROM [781F63B4-048D-4578-AF08-83C4E8FC0483] WHERE InstanceId='{0}' AND
							ProcessActivityMapId='{1}' AND FormId='{2}') BEGIN INSERT INTO [781F63B4-048D-4578-AF08-83C4E8FC0483](ProcessActivityMapId,FormId,MF_SameFundingAgency,MF_MultipleProjectsAllowed,MF_PackageProcessMapId,MF_InsertCount,ExecutionStatus,MF_DistributionId,ExecutionMessage,SetDestinationTo,MF_Description,Subject,RedirectUrl,MF_Fundname,SLATime,MF_OtherDistributionId,MF_FundTypeId,MF_MaxPercentageUsage,MF_MaxAmount,InstanceId)
							VALUES( {3}) END ELSE BEGIN UPDATE [781F63B4-048D-4578-AF08-83C4E8FC0483]SET {4}WHERE InstanceId='{0}'AND ProcessActivityMapId='{1}'AND FormId='{2}'END ";

                                     colList=@"ProcessActivityMapId,FormId,MF_SameFundingAgency,MF_MultipleProjectsAllowed,MF_PackageProcessMapId,MF_InsertCount,ExecutionStatus,MF_DistributionId,ExecutionMessage,SetDestinationTo,MF_Description,Subject,RedirectUrl,MF_Fundname,SLATime,MF_OtherDistributionId,MF_FundTypeId,MF_MaxPercentageUsage,MF_MaxAmount,InstanceId";
                                    
                     
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

                 
                                      case "BDF7896C-4676-4008-BC64-2C45896293B5":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_BDF7896C46764008BC642C45896293B5 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT){0}INSERT INTO [BDF7896C-4676-4008-BC64-2C45896293B5](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence FROM @TBL_BDF7896C46764008BC642C45896293B5 TDT
							LEFT JOIN [BDF7896C-4676-4008-BC64-2C45896293B5] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence";

                                     tempInsertQuery=@"INSERT INTO @TBL_BDF7896C46764008BC642C45896293B5(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)VALUES({0});";
                                     

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
                     
                                    case "D2D6E00A-B6B7-4968-BAAA-EF3D20F2BAC5":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_D2D6E00AB6B74968BAAAEF3D20F2BAC5 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_d3_DocumentName] NVARCHAR(800)	, [MG_d3_UpdatedOn] DATETIME	, [MG_d3_DocumentProposalID] NVARCHAR(100)	, [MG_d3_UploadDocument] BIGINT	, [MG_d3_ProposalDocumentID] NVARCHAR(100)	, [MG_d3_UpdatedBy] BIGINT	, [MG_d3_ProjectproposalID] NVARCHAR(50)	, [MG_d3_MandatoryCheck] INT){0}INSERT INTO [D2D6E00A-B6B7-4968-BAAA-EF3D20F2BAC5](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d3_DocumentName,MG_d3_UpdatedOn,MG_d3_DocumentProposalID,MG_d3_UploadDocument,MG_d3_ProposalDocumentID,MG_d3_UpdatedBy,MG_d3_ProjectproposalID,MG_d3_MandatoryCheck)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_d3_DocumentName,TDT.MG_d3_UpdatedOn,TDT.MG_d3_DocumentProposalID,TDT.MG_d3_UploadDocument,TDT.MG_d3_ProposalDocumentID,TDT.MG_d3_UpdatedBy,TDT.MG_d3_ProjectproposalID,TDT.MG_d3_MandatoryCheck FROM @TBL_D2D6E00AB6B74968BAAAEF3D20F2BAC5 TDT
							LEFT JOIN [D2D6E00A-B6B7-4968-BAAA-EF3D20F2BAC5] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d3_DocumentName,MG_d3_UpdatedOn,MG_d3_DocumentProposalID,MG_d3_UploadDocument,MG_d3_ProposalDocumentID,MG_d3_UpdatedBy,MG_d3_ProjectproposalID,MG_d3_MandatoryCheck";

                                     tempInsertQuery=@"INSERT INTO @TBL_D2D6E00AB6B74968BAAAEF3D20F2BAC5(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d3_DocumentName,MG_d3_UpdatedOn,MG_d3_DocumentProposalID,MG_d3_UploadDocument,MG_d3_ProposalDocumentID,MG_d3_UpdatedBy,MG_d3_ProjectproposalID,MG_d3_MandatoryCheck)VALUES({0});";
                                     

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
                     
                                    case "FC9B8D2E-9EE3-436F-AF08-A774AF04D678":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_FC9B8D2E9EE3436FAF08A774AF04D678 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_d2_ExternalInstituteName] VARCHAR(50)	, [MG_d2_UpdatedBy] BIGINT	, [MG_d2_ExternalFacultyName] VARCHAR(50)	, [MG_d2_ProjectDetailsID] NVARCHAR(100)	, [MG_d2_ExternalEmailId] VARCHAR(50)	, [MG_d2_AdditionalName] VARCHAR(50)	, [MG_d2_ExternalContactNo] VARCHAR(50)	, [MG_d2_Departmentid] NVARCHAR(100)	, [MG_d2_DesignationID] NVARCHAR(100)	, [MG_d2_AdditionalID] NVARCHAR(100)	, [MG_d2_UpdatedOn] DATETIME	, [MG_d2_ExternalDesignation] VARCHAR(50)	, [MG_d2_AdditionalType] INT	, [MG_d2_MemberType] BIGINT){0}INSERT INTO [FC9B8D2E-9EE3-436F-AF08-A774AF04D678](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d2_ExternalInstituteName,MG_d2_UpdatedBy,MG_d2_ExternalFacultyName,MG_d2_ProjectDetailsID,MG_d2_ExternalEmailId,MG_d2_AdditionalName,MG_d2_ExternalContactNo,MG_d2_Departmentid,MG_d2_DesignationID,MG_d2_AdditionalID,MG_d2_UpdatedOn,MG_d2_ExternalDesignation,MG_d2_AdditionalType,MG_d2_MemberType)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_d2_ExternalInstituteName,TDT.MG_d2_UpdatedBy,TDT.MG_d2_ExternalFacultyName,TDT.MG_d2_ProjectDetailsID,TDT.MG_d2_ExternalEmailId,TDT.MG_d2_AdditionalName,TDT.MG_d2_ExternalContactNo,TDT.MG_d2_Departmentid,TDT.MG_d2_DesignationID,TDT.MG_d2_AdditionalID,TDT.MG_d2_UpdatedOn,TDT.MG_d2_ExternalDesignation,TDT.MG_d2_AdditionalType,TDT.MG_d2_MemberType FROM @TBL_FC9B8D2E9EE3436FAF08A774AF04D678 TDT
							LEFT JOIN [FC9B8D2E-9EE3-436F-AF08-A774AF04D678] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d2_ExternalInstituteName,MG_d2_UpdatedBy,MG_d2_ExternalFacultyName,MG_d2_ProjectDetailsID,MG_d2_ExternalEmailId,MG_d2_AdditionalName,MG_d2_ExternalContactNo,MG_d2_Departmentid,MG_d2_DesignationID,MG_d2_AdditionalID,MG_d2_UpdatedOn,MG_d2_ExternalDesignation,MG_d2_AdditionalType,MG_d2_MemberType";

                                     tempInsertQuery=@"INSERT INTO @TBL_FC9B8D2E9EE3436FAF08A774AF04D678(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d2_ExternalInstituteName,MG_d2_UpdatedBy,MG_d2_ExternalFacultyName,MG_d2_ProjectDetailsID,MG_d2_ExternalEmailId,MG_d2_AdditionalName,MG_d2_ExternalContactNo,MG_d2_Departmentid,MG_d2_DesignationID,MG_d2_AdditionalID,MG_d2_UpdatedOn,MG_d2_ExternalDesignation,MG_d2_AdditionalType,MG_d2_MemberType)VALUES({0});";
                                     

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
                     
                                    case "A3BB2140-4053-4558-9363-3BA1B526BD0A":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_A3BB21404053455893633BA1B526BD0A AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_d4_UpdatedBy] BIGINT	, [MG_d4_DocumentId] NVARCHAR(50)	, [MG_d4_UpdatedOn] DATETIME	, [MG_d4_ProjectproposalID] NVARCHAR(50)	, [MG_d4_Document] BIGINT	, [MG_d4_DocumentName] NVARCHAR(50)	, [MG_d4_Categorymapid] NVARCHAR(50)){0}INSERT INTO [A3BB2140-4053-4558-9363-3BA1B526BD0A](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d4_UpdatedBy,MG_d4_DocumentId,MG_d4_UpdatedOn,MG_d4_ProjectproposalID,MG_d4_Document,MG_d4_DocumentName,MG_d4_Categorymapid)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_d4_UpdatedBy,TDT.MG_d4_DocumentId,TDT.MG_d4_UpdatedOn,TDT.MG_d4_ProjectproposalID,TDT.MG_d4_Document,TDT.MG_d4_DocumentName,TDT.MG_d4_Categorymapid FROM @TBL_A3BB21404053455893633BA1B526BD0A TDT
							LEFT JOIN [A3BB2140-4053-4558-9363-3BA1B526BD0A] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d4_UpdatedBy,MG_d4_DocumentId,MG_d4_UpdatedOn,MG_d4_ProjectproposalID,MG_d4_Document,MG_d4_DocumentName,MG_d4_Categorymapid";

                                     tempInsertQuery=@"INSERT INTO @TBL_A3BB21404053455893633BA1B526BD0A(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d4_UpdatedBy,MG_d4_DocumentId,MG_d4_UpdatedOn,MG_d4_ProjectproposalID,MG_d4_Document,MG_d4_DocumentName,MG_d4_Categorymapid)VALUES({0});";
                                     

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
		
		DECLARE  @TBL_9CC97541CC4E4D16A92F2FA4A6460E7B AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_BudgetName] VARCHAR(MAX)	, [MG_Balance] DECIMAL(18,2)	, [MG_ReceivedAmount] DECIMAL(18,2)	, [MG_Commitment] DECIMAL(18,2)	, [MG_Spent] DECIMAL(18,2)	, [MG_YetToReceive] DECIMAL(18,2)	, [MG_SanctionedAmount] DECIMAL(18,2)){0}INSERT INTO [9CC97541-CC4E-4D16-A92F-2FA4A6460E7B](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_BudgetName,MG_Balance,MG_ReceivedAmount,MG_Commitment,MG_Spent,MG_YetToReceive,MG_SanctionedAmount)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_BudgetName,TDT.MG_Balance,TDT.MG_ReceivedAmount,TDT.MG_Commitment,TDT.MG_Spent,TDT.MG_YetToReceive,TDT.MG_SanctionedAmount FROM @TBL_9CC97541CC4E4D16A92F2FA4A6460E7B TDT
							LEFT JOIN [9CC97541-CC4E-4D16-A92F-2FA4A6460E7B] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_BudgetName,MG_Balance,MG_ReceivedAmount,MG_Commitment,MG_Spent,MG_YetToReceive,MG_SanctionedAmount";

                                     tempInsertQuery=@"INSERT INTO @TBL_9CC97541CC4E4D16A92F2FA4A6460E7B(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_BudgetName,MG_Balance,MG_ReceivedAmount,MG_Commitment,MG_Spent,MG_YetToReceive,MG_SanctionedAmount)VALUES({0});";
                                     

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
                     
                                    case "4f5082a3-9a94-c0ae-f847-0dd75437412a":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_4f5082a39a94c0aef8470dd75437412a AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_ProjectOrOtherId] INT	, [MG_DistributionId] VARCHAR(MAX)	, [MG_FundType] VARCHAR(MAX)	, [MG_BudgetHeadId] VARCHAR(250)	, [MG_MaxPercentageUsage] DECIMAL(18,2)	, [MG_MaxAmount] DECIMAL(18,2)	, [MG_Description] VARCHAR(MAX)){0}INSERT INTO [4f5082a3-9a94-c0ae-f847-0dd75437412a](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_ProjectOrOtherId,MG_DistributionId,MG_FundType,MG_BudgetHeadId,MG_MaxPercentageUsage,MG_MaxAmount,MG_Description)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_ProjectOrOtherId,TDT.MG_DistributionId,TDT.MG_FundType,TDT.MG_BudgetHeadId,TDT.MG_MaxPercentageUsage,TDT.MG_MaxAmount,TDT.MG_Description FROM @TBL_4f5082a39a94c0aef8470dd75437412a TDT
							LEFT JOIN [4f5082a3-9a94-c0ae-f847-0dd75437412a] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_ProjectOrOtherId,MG_DistributionId,MG_FundType,MG_BudgetHeadId,MG_MaxPercentageUsage,MG_MaxAmount,MG_Description";

                                     tempInsertQuery=@"INSERT INTO @TBL_4f5082a39a94c0aef8470dd75437412a(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_ProjectOrOtherId,MG_DistributionId,MG_FundType,MG_BudgetHeadId,MG_MaxPercentageUsage,MG_MaxAmount,MG_Description)VALUES({0});";
                                     

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
                     
                                    case "281a2415-aef4-5ac1-c31b-4beaec59046b":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_281a2415aef45ac1c31b4beaec59046b AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [combo] VARCHAR(250)){0}INSERT INTO [281a2415-aef4-5ac1-c31b-4beaec59046b](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,combo)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.combo FROM @TBL_281a2415aef45ac1c31b4beaec59046b TDT
							LEFT JOIN [281a2415-aef4-5ac1-c31b-4beaec59046b] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,combo";

                                     tempInsertQuery=@"INSERT INTO @TBL_281a2415aef45ac1c31b4beaec59046b(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,combo)VALUES({0});";
                                     

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
                     
                                    case "04FCD160-1EC6-471F-97B0-1C6738875C87":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_04FCD1601EC6471F97B01C6738875C87 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_FundTypeName] VARCHAR(MAX)	, [MG_FundTypeId] INT){0}INSERT INTO [04FCD160-1EC6-471F-97B0-1C6738875C87](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_FundTypeName,MG_FundTypeId)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_FundTypeName,TDT.MG_FundTypeId FROM @TBL_04FCD1601EC6471F97B01C6738875C87 TDT
							LEFT JOIN [04FCD160-1EC6-471F-97B0-1C6738875C87] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_FundTypeName,MG_FundTypeId";

                                     tempInsertQuery=@"INSERT INTO @TBL_04FCD1601EC6471F97B01C6738875C87(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_FundTypeName,MG_FundTypeId)VALUES({0});";
                                     

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


                                         case "BDF7896C-4676-4008-BC64-2C45896293B5":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_BDF7896C46764008BC642C45896293B5 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT){0}INSERT INTO [BDF7896C-4676-4008-BC64-2C45896293B5](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence FROM @TBL_BDF7896C46764008BC642C45896293B5 TDT
							LEFT JOIN [BDF7896C-4676-4008-BC64-2C45896293B5] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence";

                            tempInsertQuery=@"INSERT INTO @TBL_BDF7896C46764008BC642C45896293B5(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)VALUES({0});";

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

                                              case "D2D6E00A-B6B7-4968-BAAA-EF3D20F2BAC5":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_D2D6E00AB6B74968BAAAEF3D20F2BAC5 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_d3_DocumentName] NVARCHAR(800)	, [MG_d3_UpdatedOn] DATETIME	, [MG_d3_DocumentProposalID] NVARCHAR(100)	, [MG_d3_UploadDocument] BIGINT	, [MG_d3_ProposalDocumentID] NVARCHAR(100)	, [MG_d3_UpdatedBy] BIGINT	, [MG_d3_ProjectproposalID] NVARCHAR(50)	, [MG_d3_MandatoryCheck] INT){0}INSERT INTO [D2D6E00A-B6B7-4968-BAAA-EF3D20F2BAC5](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d3_DocumentName,MG_d3_UpdatedOn,MG_d3_DocumentProposalID,MG_d3_UploadDocument,MG_d3_ProposalDocumentID,MG_d3_UpdatedBy,MG_d3_ProjectproposalID,MG_d3_MandatoryCheck)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_d3_DocumentName,TDT.MG_d3_UpdatedOn,TDT.MG_d3_DocumentProposalID,TDT.MG_d3_UploadDocument,TDT.MG_d3_ProposalDocumentID,TDT.MG_d3_UpdatedBy,TDT.MG_d3_ProjectproposalID,TDT.MG_d3_MandatoryCheck FROM @TBL_D2D6E00AB6B74968BAAAEF3D20F2BAC5 TDT
							LEFT JOIN [D2D6E00A-B6B7-4968-BAAA-EF3D20F2BAC5] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d3_DocumentName,MG_d3_UpdatedOn,MG_d3_DocumentProposalID,MG_d3_UploadDocument,MG_d3_ProposalDocumentID,MG_d3_UpdatedBy,MG_d3_ProjectproposalID,MG_d3_MandatoryCheck";

                            tempInsertQuery=@"INSERT INTO @TBL_D2D6E00AB6B74968BAAAEF3D20F2BAC5(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d3_DocumentName,MG_d3_UpdatedOn,MG_d3_DocumentProposalID,MG_d3_UploadDocument,MG_d3_ProposalDocumentID,MG_d3_UpdatedBy,MG_d3_ProjectproposalID,MG_d3_MandatoryCheck)VALUES({0});";

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

                                              case "FC9B8D2E-9EE3-436F-AF08-A774AF04D678":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_FC9B8D2E9EE3436FAF08A774AF04D678 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_d2_ExternalInstituteName] VARCHAR(50)	, [MG_d2_UpdatedBy] BIGINT	, [MG_d2_ExternalFacultyName] VARCHAR(50)	, [MG_d2_ProjectDetailsID] NVARCHAR(100)	, [MG_d2_ExternalEmailId] VARCHAR(50)	, [MG_d2_AdditionalName] VARCHAR(50)	, [MG_d2_ExternalContactNo] VARCHAR(50)	, [MG_d2_Departmentid] NVARCHAR(100)	, [MG_d2_DesignationID] NVARCHAR(100)	, [MG_d2_AdditionalID] NVARCHAR(100)	, [MG_d2_UpdatedOn] DATETIME	, [MG_d2_ExternalDesignation] VARCHAR(50)	, [MG_d2_AdditionalType] INT	, [MG_d2_MemberType] BIGINT){0}INSERT INTO [FC9B8D2E-9EE3-436F-AF08-A774AF04D678](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d2_ExternalInstituteName,MG_d2_UpdatedBy,MG_d2_ExternalFacultyName,MG_d2_ProjectDetailsID,MG_d2_ExternalEmailId,MG_d2_AdditionalName,MG_d2_ExternalContactNo,MG_d2_Departmentid,MG_d2_DesignationID,MG_d2_AdditionalID,MG_d2_UpdatedOn,MG_d2_ExternalDesignation,MG_d2_AdditionalType,MG_d2_MemberType)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_d2_ExternalInstituteName,TDT.MG_d2_UpdatedBy,TDT.MG_d2_ExternalFacultyName,TDT.MG_d2_ProjectDetailsID,TDT.MG_d2_ExternalEmailId,TDT.MG_d2_AdditionalName,TDT.MG_d2_ExternalContactNo,TDT.MG_d2_Departmentid,TDT.MG_d2_DesignationID,TDT.MG_d2_AdditionalID,TDT.MG_d2_UpdatedOn,TDT.MG_d2_ExternalDesignation,TDT.MG_d2_AdditionalType,TDT.MG_d2_MemberType FROM @TBL_FC9B8D2E9EE3436FAF08A774AF04D678 TDT
							LEFT JOIN [FC9B8D2E-9EE3-436F-AF08-A774AF04D678] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d2_ExternalInstituteName,MG_d2_UpdatedBy,MG_d2_ExternalFacultyName,MG_d2_ProjectDetailsID,MG_d2_ExternalEmailId,MG_d2_AdditionalName,MG_d2_ExternalContactNo,MG_d2_Departmentid,MG_d2_DesignationID,MG_d2_AdditionalID,MG_d2_UpdatedOn,MG_d2_ExternalDesignation,MG_d2_AdditionalType,MG_d2_MemberType";

                            tempInsertQuery=@"INSERT INTO @TBL_FC9B8D2E9EE3436FAF08A774AF04D678(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d2_ExternalInstituteName,MG_d2_UpdatedBy,MG_d2_ExternalFacultyName,MG_d2_ProjectDetailsID,MG_d2_ExternalEmailId,MG_d2_AdditionalName,MG_d2_ExternalContactNo,MG_d2_Departmentid,MG_d2_DesignationID,MG_d2_AdditionalID,MG_d2_UpdatedOn,MG_d2_ExternalDesignation,MG_d2_AdditionalType,MG_d2_MemberType)VALUES({0});";

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

                                              case "A3BB2140-4053-4558-9363-3BA1B526BD0A":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_A3BB21404053455893633BA1B526BD0A AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_d4_UpdatedBy] BIGINT	, [MG_d4_DocumentId] NVARCHAR(50)	, [MG_d4_UpdatedOn] DATETIME	, [MG_d4_ProjectproposalID] NVARCHAR(50)	, [MG_d4_Document] BIGINT	, [MG_d4_DocumentName] NVARCHAR(50)	, [MG_d4_Categorymapid] NVARCHAR(50)){0}INSERT INTO [A3BB2140-4053-4558-9363-3BA1B526BD0A](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d4_UpdatedBy,MG_d4_DocumentId,MG_d4_UpdatedOn,MG_d4_ProjectproposalID,MG_d4_Document,MG_d4_DocumentName,MG_d4_Categorymapid)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_d4_UpdatedBy,TDT.MG_d4_DocumentId,TDT.MG_d4_UpdatedOn,TDT.MG_d4_ProjectproposalID,TDT.MG_d4_Document,TDT.MG_d4_DocumentName,TDT.MG_d4_Categorymapid FROM @TBL_A3BB21404053455893633BA1B526BD0A TDT
							LEFT JOIN [A3BB2140-4053-4558-9363-3BA1B526BD0A] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d4_UpdatedBy,MG_d4_DocumentId,MG_d4_UpdatedOn,MG_d4_ProjectproposalID,MG_d4_Document,MG_d4_DocumentName,MG_d4_Categorymapid";

                            tempInsertQuery=@"INSERT INTO @TBL_A3BB21404053455893633BA1B526BD0A(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d4_UpdatedBy,MG_d4_DocumentId,MG_d4_UpdatedOn,MG_d4_ProjectproposalID,MG_d4_Document,MG_d4_DocumentName,MG_d4_Categorymapid)VALUES({0});";

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
		
		DECLARE  @TBL_9CC97541CC4E4D16A92F2FA4A6460E7B AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_BudgetName] VARCHAR(MAX)	, [MG_Balance] DECIMAL(18,2)	, [MG_ReceivedAmount] DECIMAL(18,2)	, [MG_Commitment] DECIMAL(18,2)	, [MG_Spent] DECIMAL(18,2)	, [MG_YetToReceive] DECIMAL(18,2)	, [MG_SanctionedAmount] DECIMAL(18,2)){0}INSERT INTO [9CC97541-CC4E-4D16-A92F-2FA4A6460E7B](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_BudgetName,MG_Balance,MG_ReceivedAmount,MG_Commitment,MG_Spent,MG_YetToReceive,MG_SanctionedAmount)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_BudgetName,TDT.MG_Balance,TDT.MG_ReceivedAmount,TDT.MG_Commitment,TDT.MG_Spent,TDT.MG_YetToReceive,TDT.MG_SanctionedAmount FROM @TBL_9CC97541CC4E4D16A92F2FA4A6460E7B TDT
							LEFT JOIN [9CC97541-CC4E-4D16-A92F-2FA4A6460E7B] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_BudgetName,MG_Balance,MG_ReceivedAmount,MG_Commitment,MG_Spent,MG_YetToReceive,MG_SanctionedAmount";

                            tempInsertQuery=@"INSERT INTO @TBL_9CC97541CC4E4D16A92F2FA4A6460E7B(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_BudgetName,MG_Balance,MG_ReceivedAmount,MG_Commitment,MG_Spent,MG_YetToReceive,MG_SanctionedAmount)VALUES({0});";

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

                                              case "4f5082a3-9a94-c0ae-f847-0dd75437412a":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_4f5082a39a94c0aef8470dd75437412a AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_ProjectOrOtherId] INT	, [MG_DistributionId] VARCHAR(MAX)	, [MG_FundType] VARCHAR(MAX)	, [MG_BudgetHeadId] VARCHAR(250)	, [MG_MaxPercentageUsage] DECIMAL(18,2)	, [MG_MaxAmount] DECIMAL(18,2)	, [MG_Description] VARCHAR(MAX)){0}INSERT INTO [4f5082a3-9a94-c0ae-f847-0dd75437412a](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_ProjectOrOtherId,MG_DistributionId,MG_FundType,MG_BudgetHeadId,MG_MaxPercentageUsage,MG_MaxAmount,MG_Description)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_ProjectOrOtherId,TDT.MG_DistributionId,TDT.MG_FundType,TDT.MG_BudgetHeadId,TDT.MG_MaxPercentageUsage,TDT.MG_MaxAmount,TDT.MG_Description FROM @TBL_4f5082a39a94c0aef8470dd75437412a TDT
							LEFT JOIN [4f5082a3-9a94-c0ae-f847-0dd75437412a] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_ProjectOrOtherId,MG_DistributionId,MG_FundType,MG_BudgetHeadId,MG_MaxPercentageUsage,MG_MaxAmount,MG_Description";

                            tempInsertQuery=@"INSERT INTO @TBL_4f5082a39a94c0aef8470dd75437412a(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_ProjectOrOtherId,MG_DistributionId,MG_FundType,MG_BudgetHeadId,MG_MaxPercentageUsage,MG_MaxAmount,MG_Description)VALUES({0});";

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

                                              case "281a2415-aef4-5ac1-c31b-4beaec59046b":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_281a2415aef45ac1c31b4beaec59046b AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [combo] VARCHAR(250)){0}INSERT INTO [281a2415-aef4-5ac1-c31b-4beaec59046b](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,combo)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.combo FROM @TBL_281a2415aef45ac1c31b4beaec59046b TDT
							LEFT JOIN [281a2415-aef4-5ac1-c31b-4beaec59046b] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,combo";

                            tempInsertQuery=@"INSERT INTO @TBL_281a2415aef45ac1c31b4beaec59046b(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,combo)VALUES({0});";

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

                                              case "04FCD160-1EC6-471F-97B0-1C6738875C87":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_04FCD1601EC6471F97B01C6738875C87 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_FundTypeName] VARCHAR(MAX)	, [MG_FundTypeId] INT){0}INSERT INTO [04FCD160-1EC6-471F-97B0-1C6738875C87](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_FundTypeName,MG_FundTypeId)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_FundTypeName,TDT.MG_FundTypeId FROM @TBL_04FCD1601EC6471F97B01C6738875C87 TDT
							LEFT JOIN [04FCD160-1EC6-471F-97B0-1C6738875C87] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_FundTypeName,MG_FundTypeId";

                            tempInsertQuery=@"INSERT INTO @TBL_04FCD1601EC6471F97B01C6738875C87(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_FundTypeName,MG_FundTypeId)VALUES({0});";

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