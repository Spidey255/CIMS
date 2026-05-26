
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

        public Status GetFormInstanceData(SlotToken token, string formInstanceId,string processActivityMapId,
             string formId,out DataTable queryResult)
        {
            _sysLog.Debug("Entering GetFormInstanceData");

            queryResult = null;

          
            try
            {

                Database database = GetDatabaseInstance(token);


                string getSPName = string.Empty;

                getSPName = "GetFormData" + formId.Replace("-", "");


                using (DbCommand command =
                    database.GetStoredProcCommand
                        (getSPName))
                {
                    command.CommandTimeout = 10000;

                    database.AddInParameter(command, "InstanceId", DbType.String, formInstanceId);

                    database.AddInParameter(command, "ProcessActivityMapId", DbType.String, processActivityMapId);

                    database.AddInParameter(command, "FormId", DbType.String, formId);                  

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
							VALUES( {3}) END ELSE BEGIN UPDATE [7816392B-A9EF-486D-88F9-AC7C972D679B]SET {4}WHERE InstanceId='{0}'END ";

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
                
                       
                      case "DA3904EF-0E60-44D0-943E-2E97494B15C8":
                    {
                     
                                     fInsertQuery=@"IF NOT EXISTS(SELECT 1 FROM [DA3904EF-0E60-44D0-943E-2E97494B15C8] WHERE InstanceId='{0}' AND
							ProcessActivityMapId='{1}' AND FormId='{2}') BEGIN INSERT INTO [DA3904EF-0E60-44D0-943E-2E97494B15C8](ProcessActivityMapId,FormId,ExecutionMessage,ExecutionStatus,Subject,SetDestinationTo,MF_ProjectDetailsId,SLATime,MF_ProjectNo,MF_UserName,InstanceId)
							VALUES( {3}) END ELSE BEGIN UPDATE [DA3904EF-0E60-44D0-943E-2E97494B15C8]SET {4}WHERE InstanceId='{0}'END ";

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
                
                       
                      case "E0AC6667-6D92-49AA-8F4D-01F473F2E426":
                    {
                     
                                     fInsertQuery=@"IF NOT EXISTS(SELECT 1 FROM [E0AC6667-6D92-49AA-8F4D-01F473F2E426] WHERE InstanceId='{0}' AND
							ProcessActivityMapId='{1}' AND FormId='{2}') BEGIN INSERT INTO [E0AC6667-6D92-49AA-8F4D-01F473F2E426](ProcessActivityMapId,FormId,Subject,ExecutionStatus,ExecutionMessage,SetDestinationTo,SLATime,MF_d1_ProjectProposalID,MF_d1_ProjectRefNo,MF_d1_ProjectCategoryID,MF_d1_FinancialYearID,MF_d1_DepartmentID,MF_d1_Designation,MF_d1_ProjectName,MF_d1_ProjectType,MF_d1_FundingAgency,MF_d1_ProjectBudget,MF_d1_Remarks,MF_d1_PrincipalInvestigator,MF_d1_EmployeeBasicInfoId,MF_d1_ProjectStatus,MF_d1_SectorID,MF_d1_EndorsementFileType,MF_d1_ProposalCode,MF_d1_IsSubmitted,MF_d1_OverHead,MF_d1_IfExternalInstitute,MF_d1_UpdatedBy,MF_d1_UpdatedOn,AssignToRole,AssignToUser,IN_Priority,IN_InstanceName,IN_SLA,IN_Status,IN_Category,ExecuteCommand,RedirectUrl,Thumbnail,CancelRedirectUrl,KeyContext,DisplayContext,growid,MF_d1_Currency,M_DepartmentId,M_DesignationId,Dept,DummyInstance,M_EMPCode,M_DeptCode,MF_d1_ProjectCategoryCode,M_MoveTo,InstanceId)
							VALUES( {3}) END ELSE BEGIN UPDATE [E0AC6667-6D92-49AA-8F4D-01F473F2E426]SET {4}WHERE InstanceId='{0}'END ";

                                     colList=@"ProcessActivityMapId,FormId,Subject,ExecutionStatus,ExecutionMessage,SetDestinationTo,SLATime,MF_d1_ProjectProposalID,MF_d1_ProjectRefNo,MF_d1_ProjectCategoryID,MF_d1_FinancialYearID,MF_d1_DepartmentID,MF_d1_Designation,MF_d1_ProjectName,MF_d1_ProjectType,MF_d1_FundingAgency,MF_d1_ProjectBudget,MF_d1_Remarks,MF_d1_PrincipalInvestigator,MF_d1_EmployeeBasicInfoId,MF_d1_ProjectStatus,MF_d1_SectorID,MF_d1_EndorsementFileType,MF_d1_ProposalCode,MF_d1_IsSubmitted,MF_d1_OverHead,MF_d1_IfExternalInstitute,MF_d1_UpdatedBy,MF_d1_UpdatedOn,AssignToRole,AssignToUser,IN_Priority,IN_InstanceName,IN_SLA,IN_Status,IN_Category,ExecuteCommand,RedirectUrl,Thumbnail,CancelRedirectUrl,KeyContext,DisplayContext,growid,MF_d1_Currency,M_DepartmentId,M_DesignationId,Dept,DummyInstance,M_EMPCode,M_DeptCode,MF_d1_ProjectCategoryCode,M_MoveTo,InstanceId";
                                    
                     
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
                
                       
                      case "30511266-0219-45B2-9647-28B8A4C85D86":
                    {
                     
                                     fInsertQuery=@"IF NOT EXISTS(SELECT 1 FROM [30511266-0219-45B2-9647-28B8A4C85D86] WHERE InstanceId='{0}' AND
							ProcessActivityMapId='{1}' AND FormId='{2}') BEGIN INSERT INTO [30511266-0219-45B2-9647-28B8A4C85D86](ProcessActivityMapId,FormId,MF_ProjectCommitments_GridRows,MF_ProjectCommitments_RecordsRange,MF_ProjectCommitments_PageIndex,MF_ProjectCommitments_TotalPages,MF_V1_ExpenseID,MF_V1_BudgetHead,MF_V1_ProjectDetailsID,MF_V1_PackageProcessMapID,MF_V1_ExpenseDate,MF_V1_AmountSpent,MF_V1_ExpenseDescription,MF_Option,MF_ReceiptsView_GridRows,MF_ReceiptsView_RecordsRange,MF_ReceiptsView_PageIndex,MF_ReceiptsView_TotalPages,MF_P1_ReceiptsId,MF_P1_ProjectDetailsId,MF_P1_ReceiptAmount,MF_P1_ReceiptDate,MF_P1_TransferType,MF_P1_TransferReferenceNumber,MF_P1_TransferReferenceDate,MF_P1_TransferReferenceBankId,MF_P1_TransferReferenceBranch,MF_P1_ReceiptNo,F_ReceiptNo,MF_Budgetdetails_GridRows,MF_Budgetdetails_RecordsRange,MF_Budgetdetails_PageIndex,MF_Budgetdetails_TotalPages,MF_V1_BudgetHeadID,MF_V1_SanctionedAmount,MF_V1_ReceivedAmount,MF_V1_YettoReceive,MF_V1_Spent,MF_V1_Committment,MF_V1_Balance,F_BudgetHeadId,Subject,ExecutionStatus,ExecutionMessage,SetDestinationTo,SLATime,RefId,F_ProjectDetailsId,MF_PI,MF_COPI,FC_StartDate,FC_EndDate,FC_ProjectNo,FC_ProjectName,FC_AgencyCode,FC_Category,FC_SanctionNo,FC_SanctionedDate,FC_SanctionedValue,InstanceId)
							VALUES( {3}) END ELSE BEGIN UPDATE [30511266-0219-45B2-9647-28B8A4C85D86]SET {4}WHERE InstanceId='{0}'END ";

                                     colList=@"ProcessActivityMapId,FormId,MF_ProjectCommitments_GridRows,MF_ProjectCommitments_RecordsRange,MF_ProjectCommitments_PageIndex,MF_ProjectCommitments_TotalPages,MF_V1_ExpenseID,MF_V1_BudgetHead,MF_V1_ProjectDetailsID,MF_V1_PackageProcessMapID,MF_V1_ExpenseDate,MF_V1_AmountSpent,MF_V1_ExpenseDescription,MF_Option,MF_ReceiptsView_GridRows,MF_ReceiptsView_RecordsRange,MF_ReceiptsView_PageIndex,MF_ReceiptsView_TotalPages,MF_P1_ReceiptsId,MF_P1_ProjectDetailsId,MF_P1_ReceiptAmount,MF_P1_ReceiptDate,MF_P1_TransferType,MF_P1_TransferReferenceNumber,MF_P1_TransferReferenceDate,MF_P1_TransferReferenceBankId,MF_P1_TransferReferenceBranch,MF_P1_ReceiptNo,F_ReceiptNo,MF_Budgetdetails_GridRows,MF_Budgetdetails_RecordsRange,MF_Budgetdetails_PageIndex,MF_Budgetdetails_TotalPages,MF_V1_BudgetHeadID,MF_V1_SanctionedAmount,MF_V1_ReceivedAmount,MF_V1_YettoReceive,MF_V1_Spent,MF_V1_Committment,MF_V1_Balance,F_BudgetHeadId,Subject,ExecutionStatus,ExecutionMessage,SetDestinationTo,SLATime,RefId,F_ProjectDetailsId,MF_PI,MF_COPI,FC_StartDate,FC_EndDate,FC_ProjectNo,FC_ProjectName,FC_AgencyCode,FC_Category,FC_SanctionNo,FC_SanctionedDate,FC_SanctionedValue,InstanceId";
                                    
                     
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
                
                       
                      case "7F2113FD-876A-41F4-BEAC-881CA7D38469":
                    {
                     
                                     fInsertQuery=@"IF NOT EXISTS(SELECT 1 FROM [7F2113FD-876A-41F4-BEAC-881CA7D38469] WHERE InstanceId='{0}' AND
							ProcessActivityMapId='{1}' AND FormId='{2}') BEGIN INSERT INTO [7F2113FD-876A-41F4-BEAC-881CA7D38469](ProcessActivityMapId,FormId,MF_d10_Sector,MF_d10_ProjectDetailsID,MF_d10_InstanceId,MF_d10_ProjectCode,MF_d10_ProjectRefNo,MF_d10_EmployeeBasicInfoId,MF_d10_ActualDate,MF_d10_ActualEndDate,MF_d10_NonRecurringAmount,MF_d10_RecurringAmount,MF_d10_IfExtended,MF_d10_ExtendedDate,MF_d10_BudgetTotalAmount,MF_d10_Overhead,MF_d10_ExchangeRate,MF_d10_DocumentComments,MF_d19_OverallAmount,MF_d145_OverallTotalCost,Subject,ExecutionStatus,ExecutionMessage,SetDestinationTo,SLATime,AssignToRole,AssignToUser,IN_Priority,IN_InstanceName,IN_SLA,IN_Status,IN_Category,ExecuteCommand,RedirectUrl,Thumbnail,CancelRedirectUrl,KeyContext,DisplayContext,growid,MF_d10_FinancialYearID,MF_d10_ProjectName,MF_d10_Duration,MF_d10_IfManpower,MF_d10_IfEquipment,MF_d10_IsExternalIns,MF_d10_FundReceiptMode,MF_d10_PrincipalInvestigator,MF_d10_ProjectproposalID,MF_d10_SanctionedNumber,MF_d10_DepartmentID,MF_d10_SchemeID,MF_d10_FundingAgency,MF_d10_YearMonth,MF_d10_ProjectStatus,MF_d10_Designation,MF_d10_ProjectCategoryID,MF_d10_IsSubmitted,MF_d10_SanctionedDate,MF_d10_FromDate,MF_d10_ToDate,MF_d10_ProjectBudget,MF_d10_ProjectType,InstanceId)
							VALUES( {3}) END ELSE BEGIN UPDATE [7F2113FD-876A-41F4-BEAC-881CA7D38469]SET {4}WHERE InstanceId='{0}'END ";

                                     colList=@"ProcessActivityMapId,FormId,MF_d10_Sector,MF_d10_ProjectDetailsID,MF_d10_InstanceId,MF_d10_ProjectCode,MF_d10_ProjectRefNo,MF_d10_EmployeeBasicInfoId,MF_d10_ActualDate,MF_d10_ActualEndDate,MF_d10_NonRecurringAmount,MF_d10_RecurringAmount,MF_d10_IfExtended,MF_d10_ExtendedDate,MF_d10_BudgetTotalAmount,MF_d10_Overhead,MF_d10_ExchangeRate,MF_d10_DocumentComments,MF_d19_OverallAmount,MF_d145_OverallTotalCost,Subject,ExecutionStatus,ExecutionMessage,SetDestinationTo,SLATime,AssignToRole,AssignToUser,IN_Priority,IN_InstanceName,IN_SLA,IN_Status,IN_Category,ExecuteCommand,RedirectUrl,Thumbnail,CancelRedirectUrl,KeyContext,DisplayContext,growid,MF_d10_FinancialYearID,MF_d10_ProjectName,MF_d10_Duration,MF_d10_IfManpower,MF_d10_IfEquipment,MF_d10_IsExternalIns,MF_d10_FundReceiptMode,MF_d10_PrincipalInvestigator,MF_d10_ProjectproposalID,MF_d10_SanctionedNumber,MF_d10_DepartmentID,MF_d10_SchemeID,MF_d10_FundingAgency,MF_d10_YearMonth,MF_d10_ProjectStatus,MF_d10_Designation,MF_d10_ProjectCategoryID,MF_d10_IsSubmitted,MF_d10_SanctionedDate,MF_d10_FromDate,MF_d10_ToDate,MF_d10_ProjectBudget,MF_d10_ProjectType,InstanceId";
                                    
                     
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
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence FROM @TBL_BDF7896C46764008BC642C45896293B5 TDT
							JOIN [BDF7896C-4676-4008-BC64-2C45896293B5] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId";

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
                     
                                    case "FC9B8D2E-9EE3-436F-AF08-A774AF04D678":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_FC9B8D2E9EE3436FAF08A774AF04D678 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_d2_AdditionalID] VARCHAR(MAX)	, [MG_d2_ProjectDetailsID] VARCHAR(MAX)	, [MG_d2_AdditionalType] VARCHAR(MAX)	, [MG_d2_AdditionalName] VARCHAR(MAX)	, [MG_d2_Departmentid] VARCHAR(MAX)	, [MG_d2_DesignationID] VARCHAR(MAX)	, [MG_d2_ExternalInstituteName] VARCHAR(MAX)	, [MG_d2_ExternalFacultyName] VARCHAR(MAX)	, [MG_d2_ExternalDesignation] VARCHAR(MAX)	, [MG_d2_ExternalEmailId] VARCHAR(MAX)	, [MG_d2_ExternalContactNo] VARCHAR(MAX)	, [MG_d2_UpdatedBy] INT	, [MG_d2_UpdatedOn] DATETIME	, [MG_d2_MemberType] VARCHAR(MAX)	, [MG_EmployeeName] VARCHAR(MAX)	, [MG_EmployeeDepartment] VARCHAR(MAX)	, [MG_AdditionalTypeValue] VARCHAR(MAX)	, [MG_MemberTypeValue] VARCHAR(MAX)){0}INSERT INTO [FC9B8D2E-9EE3-436F-AF08-A774AF04D678](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d2_AdditionalID,MG_d2_ProjectDetailsID,MG_d2_AdditionalType,MG_d2_AdditionalName,MG_d2_Departmentid,MG_d2_DesignationID,MG_d2_ExternalInstituteName,MG_d2_ExternalFacultyName,MG_d2_ExternalDesignation,MG_d2_ExternalEmailId,MG_d2_ExternalContactNo,MG_d2_UpdatedBy,MG_d2_UpdatedOn,MG_d2_MemberType,MG_EmployeeName,MG_EmployeeDepartment,MG_AdditionalTypeValue,MG_MemberTypeValue)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_d2_AdditionalID,TDT.MG_d2_ProjectDetailsID,TDT.MG_d2_AdditionalType,TDT.MG_d2_AdditionalName,TDT.MG_d2_Departmentid,TDT.MG_d2_DesignationID,TDT.MG_d2_ExternalInstituteName,TDT.MG_d2_ExternalFacultyName,TDT.MG_d2_ExternalDesignation,TDT.MG_d2_ExternalEmailId,TDT.MG_d2_ExternalContactNo,TDT.MG_d2_UpdatedBy,TDT.MG_d2_UpdatedOn,TDT.MG_d2_MemberType,TDT.MG_EmployeeName,TDT.MG_EmployeeDepartment,TDT.MG_AdditionalTypeValue,TDT.MG_MemberTypeValue FROM @TBL_FC9B8D2E9EE3436FAF08A774AF04D678 TDT
							LEFT JOIN [FC9B8D2E-9EE3-436F-AF08-A774AF04D678] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MG_d2_AdditionalID=TDT.MG_d2_AdditionalID,MG_d2_ProjectDetailsID=TDT.MG_d2_ProjectDetailsID,MG_d2_AdditionalType=TDT.MG_d2_AdditionalType,MG_d2_AdditionalName=TDT.MG_d2_AdditionalName,MG_d2_Departmentid=TDT.MG_d2_Departmentid,MG_d2_DesignationID=TDT.MG_d2_DesignationID,MG_d2_ExternalInstituteName=TDT.MG_d2_ExternalInstituteName,MG_d2_ExternalFacultyName=TDT.MG_d2_ExternalFacultyName,MG_d2_ExternalDesignation=TDT.MG_d2_ExternalDesignation,MG_d2_ExternalEmailId=TDT.MG_d2_ExternalEmailId,MG_d2_ExternalContactNo=TDT.MG_d2_ExternalContactNo,MG_d2_UpdatedBy=TDT.MG_d2_UpdatedBy,MG_d2_UpdatedOn=TDT.MG_d2_UpdatedOn,MG_d2_MemberType=TDT.MG_d2_MemberType,MG_EmployeeName=TDT.MG_EmployeeName,MG_EmployeeDepartment=TDT.MG_EmployeeDepartment,MG_AdditionalTypeValue=TDT.MG_AdditionalTypeValue,MG_MemberTypeValue=TDT.MG_MemberTypeValue FROM @TBL_FC9B8D2E9EE3436FAF08A774AF04D678 TDT
							JOIN [FC9B8D2E-9EE3-436F-AF08-A774AF04D678] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d2_AdditionalID,MG_d2_ProjectDetailsID,MG_d2_AdditionalType,MG_d2_AdditionalName,MG_d2_Departmentid,MG_d2_DesignationID,MG_d2_ExternalInstituteName,MG_d2_ExternalFacultyName,MG_d2_ExternalDesignation,MG_d2_ExternalEmailId,MG_d2_ExternalContactNo,MG_d2_UpdatedBy,MG_d2_UpdatedOn,MG_d2_MemberType,MG_EmployeeName,MG_EmployeeDepartment,MG_AdditionalTypeValue,MG_MemberTypeValue";

                                     tempInsertQuery=@"INSERT INTO @TBL_FC9B8D2E9EE3436FAF08A774AF04D678(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d2_AdditionalID,MG_d2_ProjectDetailsID,MG_d2_AdditionalType,MG_d2_AdditionalName,MG_d2_Departmentid,MG_d2_DesignationID,MG_d2_ExternalInstituteName,MG_d2_ExternalFacultyName,MG_d2_ExternalDesignation,MG_d2_ExternalEmailId,MG_d2_ExternalContactNo,MG_d2_UpdatedBy,MG_d2_UpdatedOn,MG_d2_MemberType,MG_EmployeeName,MG_EmployeeDepartment,MG_AdditionalTypeValue,MG_MemberTypeValue)VALUES({0});";
                                     

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
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MG_BudgetName=TDT.MG_BudgetName,MG_Balance=TDT.MG_Balance,MG_ReceivedAmount=TDT.MG_ReceivedAmount,MG_Commitment=TDT.MG_Commitment,MG_Spent=TDT.MG_Spent,MG_YetToReceive=TDT.MG_YetToReceive,MG_SanctionedAmount=TDT.MG_SanctionedAmount FROM @TBL_9CC97541CC4E4D16A92F2FA4A6460E7B TDT
							JOIN [9CC97541-CC4E-4D16-A92F-2FA4A6460E7B] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId";

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
                     
                                    case "D2D6E00A-B6B7-4968-BAAA-EF3D20F2BAC5":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_D2D6E00AB6B74968BAAAEF3D20F2BAC5 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_d3_DocumentName] NVARCHAR(800)	, [MG_d3_UpdatedOn] DATETIME	, [MG_d3_DocumentProposalID] NVARCHAR(100)	, [MG_d3_UploadDocument] BIGINT	, [MG_d3_ProposalDocumentID] NVARCHAR(100)	, [MG_d3_UpdatedBy] BIGINT	, [MG_d3_ProjectproposalID] NVARCHAR(50)	, [MG_d3_MandatoryCheck] INT){0}INSERT INTO [D2D6E00A-B6B7-4968-BAAA-EF3D20F2BAC5](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d3_DocumentName,MG_d3_UpdatedOn,MG_d3_DocumentProposalID,MG_d3_UploadDocument,MG_d3_ProposalDocumentID,MG_d3_UpdatedBy,MG_d3_ProjectproposalID,MG_d3_MandatoryCheck)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_d3_DocumentName,TDT.MG_d3_UpdatedOn,TDT.MG_d3_DocumentProposalID,TDT.MG_d3_UploadDocument,TDT.MG_d3_ProposalDocumentID,TDT.MG_d3_UpdatedBy,TDT.MG_d3_ProjectproposalID,TDT.MG_d3_MandatoryCheck FROM @TBL_D2D6E00AB6B74968BAAAEF3D20F2BAC5 TDT
							LEFT JOIN [D2D6E00A-B6B7-4968-BAAA-EF3D20F2BAC5] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MG_d3_DocumentName=TDT.MG_d3_DocumentName,MG_d3_UpdatedOn=TDT.MG_d3_UpdatedOn,MG_d3_DocumentProposalID=TDT.MG_d3_DocumentProposalID,MG_d3_UploadDocument=TDT.MG_d3_UploadDocument,MG_d3_ProposalDocumentID=TDT.MG_d3_ProposalDocumentID,MG_d3_UpdatedBy=TDT.MG_d3_UpdatedBy,MG_d3_ProjectproposalID=TDT.MG_d3_ProjectproposalID,MG_d3_MandatoryCheck=TDT.MG_d3_MandatoryCheck FROM @TBL_D2D6E00AB6B74968BAAAEF3D20F2BAC5 TDT
							JOIN [D2D6E00A-B6B7-4968-BAAA-EF3D20F2BAC5] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId";

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
                     
                                    case "A3BB2140-4053-4558-9363-3BA1B526BD0A":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_A3BB21404053455893633BA1B526BD0A AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_d4_UpdatedBy] BIGINT	, [MG_d4_DocumentId] NVARCHAR(50)	, [MG_d4_UpdatedOn] DATETIME	, [MG_d4_ProjectproposalID] NVARCHAR(50)	, [MG_d4_Document] BIGINT	, [MG_d4_DocumentName] NVARCHAR(50)	, [MG_d4_Categorymapid] NVARCHAR(50)){0}INSERT INTO [A3BB2140-4053-4558-9363-3BA1B526BD0A](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d4_UpdatedBy,MG_d4_DocumentId,MG_d4_UpdatedOn,MG_d4_ProjectproposalID,MG_d4_Document,MG_d4_DocumentName,MG_d4_Categorymapid)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_d4_UpdatedBy,TDT.MG_d4_DocumentId,TDT.MG_d4_UpdatedOn,TDT.MG_d4_ProjectproposalID,TDT.MG_d4_Document,TDT.MG_d4_DocumentName,TDT.MG_d4_Categorymapid FROM @TBL_A3BB21404053455893633BA1B526BD0A TDT
							LEFT JOIN [A3BB2140-4053-4558-9363-3BA1B526BD0A] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MG_d4_UpdatedBy=TDT.MG_d4_UpdatedBy,MG_d4_DocumentId=TDT.MG_d4_DocumentId,MG_d4_UpdatedOn=TDT.MG_d4_UpdatedOn,MG_d4_ProjectproposalID=TDT.MG_d4_ProjectproposalID,MG_d4_Document=TDT.MG_d4_Document,MG_d4_DocumentName=TDT.MG_d4_DocumentName,MG_d4_Categorymapid=TDT.MG_d4_Categorymapid FROM @TBL_A3BB21404053455893633BA1B526BD0A TDT
							JOIN [A3BB2140-4053-4558-9363-3BA1B526BD0A] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId";

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
                     
                                    case "D56A52C8-2D23-4F88-A6D2-148D57FAD218":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_D56A52C82D234F88A6D2148D57FAD218 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT){0}INSERT INTO [D56A52C8-2D23-4F88-A6D2-148D57FAD218](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence FROM @TBL_D56A52C82D234F88A6D2148D57FAD218 TDT
							LEFT JOIN [D56A52C8-2D23-4F88-A6D2-148D57FAD218] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence FROM @TBL_D56A52C82D234F88A6D2148D57FAD218 TDT
							JOIN [D56A52C8-2D23-4F88-A6D2-148D57FAD218] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence";

                                     tempInsertQuery=@"INSERT INTO @TBL_D56A52C82D234F88A6D2148D57FAD218(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)VALUES({0});";
                                     

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
                     
                                    case "D8F430EF-D0A1-4887-B0CC-DB94A0BF0D93":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_D8F430EFD0A14887B0CCDB94A0BF0D93 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MGG_V1_ExpenseID] VARCHAR(MAX)	, [MGG_V1_PackageProcessMapID] VARCHAR(MAX)	, [MGG_V1_ExpenseDate] DATETIME	, [MGG_V1_AmountSpent] DECIMAL(18,2)	, [MGG_V1_ExpenseDescription] VARCHAR(MAX)){0}INSERT INTO [D8F430EF-D0A1-4887-B0CC-DB94A0BF0D93](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MGG_V1_ExpenseID,MGG_V1_PackageProcessMapID,MGG_V1_ExpenseDate,MGG_V1_AmountSpent,MGG_V1_ExpenseDescription)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MGG_V1_ExpenseID,TDT.MGG_V1_PackageProcessMapID,TDT.MGG_V1_ExpenseDate,TDT.MGG_V1_AmountSpent,TDT.MGG_V1_ExpenseDescription FROM @TBL_D8F430EFD0A14887B0CCDB94A0BF0D93 TDT
							LEFT JOIN [D8F430EF-D0A1-4887-B0CC-DB94A0BF0D93] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MGG_V1_ExpenseID=TDT.MGG_V1_ExpenseID,MGG_V1_PackageProcessMapID=TDT.MGG_V1_PackageProcessMapID,MGG_V1_ExpenseDate=TDT.MGG_V1_ExpenseDate,MGG_V1_AmountSpent=TDT.MGG_V1_AmountSpent,MGG_V1_ExpenseDescription=TDT.MGG_V1_ExpenseDescription FROM @TBL_D8F430EFD0A14887B0CCDB94A0BF0D93 TDT
							JOIN [D8F430EF-D0A1-4887-B0CC-DB94A0BF0D93] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MGG_V1_ExpenseID,MGG_V1_PackageProcessMapID,MGG_V1_ExpenseDate,MGG_V1_AmountSpent,MGG_V1_ExpenseDescription";

                                     tempInsertQuery=@"INSERT INTO @TBL_D8F430EFD0A14887B0CCDB94A0BF0D93(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MGG_V1_ExpenseID,MGG_V1_PackageProcessMapID,MGG_V1_ExpenseDate,MGG_V1_AmountSpent,MGG_V1_ExpenseDescription)VALUES({0});";
                                     

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
                     
                                    case "D20793F2-23FB-4CCE-AB6D-5D14FE42B1B2":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_D20793F223FB4CCEAB6D5D14FE42B1B2 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MGG_V1_BudgetHeadID] VARCHAR(MAX)	, [MGG_V1_ProjectDetailsID] VARCHAR(MAX)	, [MGG_V1_BudgetHead] VARCHAR(MAX)	, [MGG_V1_SanctionedAmount] DECIMAL(18,2)	, [MGG_V1_ReceivedAmount] DECIMAL(18,2)	, [MGG_V1_YettoReceive] DECIMAL(18,2)	, [MGG_V1_Spent] DECIMAL(18,2)	, [MGG_V1_Committment] DECIMAL(18,2)	, [MGG_V1_Balance] DECIMAL(18,2)){0}INSERT INTO [D20793F2-23FB-4CCE-AB6D-5D14FE42B1B2](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MGG_V1_BudgetHeadID,MGG_V1_ProjectDetailsID,MGG_V1_BudgetHead,MGG_V1_SanctionedAmount,MGG_V1_ReceivedAmount,MGG_V1_YettoReceive,MGG_V1_Spent,MGG_V1_Committment,MGG_V1_Balance)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MGG_V1_BudgetHeadID,TDT.MGG_V1_ProjectDetailsID,TDT.MGG_V1_BudgetHead,TDT.MGG_V1_SanctionedAmount,TDT.MGG_V1_ReceivedAmount,TDT.MGG_V1_YettoReceive,TDT.MGG_V1_Spent,TDT.MGG_V1_Committment,TDT.MGG_V1_Balance FROM @TBL_D20793F223FB4CCEAB6D5D14FE42B1B2 TDT
							LEFT JOIN [D20793F2-23FB-4CCE-AB6D-5D14FE42B1B2] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MGG_V1_BudgetHeadID=TDT.MGG_V1_BudgetHeadID,MGG_V1_ProjectDetailsID=TDT.MGG_V1_ProjectDetailsID,MGG_V1_BudgetHead=TDT.MGG_V1_BudgetHead,MGG_V1_SanctionedAmount=TDT.MGG_V1_SanctionedAmount,MGG_V1_ReceivedAmount=TDT.MGG_V1_ReceivedAmount,MGG_V1_YettoReceive=TDT.MGG_V1_YettoReceive,MGG_V1_Spent=TDT.MGG_V1_Spent,MGG_V1_Committment=TDT.MGG_V1_Committment,MGG_V1_Balance=TDT.MGG_V1_Balance FROM @TBL_D20793F223FB4CCEAB6D5D14FE42B1B2 TDT
							JOIN [D20793F2-23FB-4CCE-AB6D-5D14FE42B1B2] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MGG_V1_BudgetHeadID,MGG_V1_ProjectDetailsID,MGG_V1_BudgetHead,MGG_V1_SanctionedAmount,MGG_V1_ReceivedAmount,MGG_V1_YettoReceive,MGG_V1_Spent,MGG_V1_Committment,MGG_V1_Balance";

                                     tempInsertQuery=@"INSERT INTO @TBL_D20793F223FB4CCEAB6D5D14FE42B1B2(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MGG_V1_BudgetHeadID,MGG_V1_ProjectDetailsID,MGG_V1_BudgetHead,MGG_V1_SanctionedAmount,MGG_V1_ReceivedAmount,MGG_V1_YettoReceive,MGG_V1_Spent,MGG_V1_Committment,MGG_V1_Balance)VALUES({0});";
                                     

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
                     
                                    case "C5B61F31-1A40-4640-939A-14D8636A8493":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_C5B61F311A404640939A14D8636A8493 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MGG_P1_ReceiptsId] VARCHAR(MAX)	, [MGG_P1_ProjectDetailsId] VARCHAR(MAX)	, [MGG_P1_ReceiptAmount] DECIMAL(18,2)	, [MGG_P1_ReceiptDate] DATETIME	, [MGG_P1_TransferType] VARCHAR(MAX)	, [MGG_P1_TransferReferenceNumber] VARCHAR(MAX)	, [MGG_P1_TransferReferenceDate] DATETIME	, [MGG_P1_TransferReferenceBankId] VARCHAR(MAX)	, [MGG_P1_TransferReferenceBranch] VARCHAR(MAX)	, [MGG_P1_ReceiptNo] VARCHAR(MAX)){0}INSERT INTO [C5B61F31-1A40-4640-939A-14D8636A8493](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MGG_P1_ReceiptsId,MGG_P1_ProjectDetailsId,MGG_P1_ReceiptAmount,MGG_P1_ReceiptDate,MGG_P1_TransferType,MGG_P1_TransferReferenceNumber,MGG_P1_TransferReferenceDate,MGG_P1_TransferReferenceBankId,MGG_P1_TransferReferenceBranch,MGG_P1_ReceiptNo)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MGG_P1_ReceiptsId,TDT.MGG_P1_ProjectDetailsId,TDT.MGG_P1_ReceiptAmount,TDT.MGG_P1_ReceiptDate,TDT.MGG_P1_TransferType,TDT.MGG_P1_TransferReferenceNumber,TDT.MGG_P1_TransferReferenceDate,TDT.MGG_P1_TransferReferenceBankId,TDT.MGG_P1_TransferReferenceBranch,TDT.MGG_P1_ReceiptNo FROM @TBL_C5B61F311A404640939A14D8636A8493 TDT
							LEFT JOIN [C5B61F31-1A40-4640-939A-14D8636A8493] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MGG_P1_ReceiptsId=TDT.MGG_P1_ReceiptsId,MGG_P1_ProjectDetailsId=TDT.MGG_P1_ProjectDetailsId,MGG_P1_ReceiptAmount=TDT.MGG_P1_ReceiptAmount,MGG_P1_ReceiptDate=TDT.MGG_P1_ReceiptDate,MGG_P1_TransferType=TDT.MGG_P1_TransferType,MGG_P1_TransferReferenceNumber=TDT.MGG_P1_TransferReferenceNumber,MGG_P1_TransferReferenceDate=TDT.MGG_P1_TransferReferenceDate,MGG_P1_TransferReferenceBankId=TDT.MGG_P1_TransferReferenceBankId,MGG_P1_TransferReferenceBranch=TDT.MGG_P1_TransferReferenceBranch,MGG_P1_ReceiptNo=TDT.MGG_P1_ReceiptNo FROM @TBL_C5B61F311A404640939A14D8636A8493 TDT
							JOIN [C5B61F31-1A40-4640-939A-14D8636A8493] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MGG_P1_ReceiptsId,MGG_P1_ProjectDetailsId,MGG_P1_ReceiptAmount,MGG_P1_ReceiptDate,MGG_P1_TransferType,MGG_P1_TransferReferenceNumber,MGG_P1_TransferReferenceDate,MGG_P1_TransferReferenceBankId,MGG_P1_TransferReferenceBranch,MGG_P1_ReceiptNo";

                                     tempInsertQuery=@"INSERT INTO @TBL_C5B61F311A404640939A14D8636A8493(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MGG_P1_ReceiptsId,MGG_P1_ProjectDetailsId,MGG_P1_ReceiptAmount,MGG_P1_ReceiptDate,MGG_P1_TransferType,MGG_P1_TransferReferenceNumber,MGG_P1_TransferReferenceDate,MGG_P1_TransferReferenceBankId,MGG_P1_TransferReferenceBranch,MGG_P1_ReceiptNo)VALUES({0});";
                                     

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
                     
                                    case "B73036BB-FE7D-4B0D-998A-985294F8FC5B":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_B73036BBFE7D4B0D998A985294F8FC5B AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_d28_Reappropriation] DECIMAL(18,2)	, [MG_d28_BudgetID] VARCHAR(MAX)	, [MG_d28_BudgetAmount] DECIMAL(18,2)	, [MG_d28_Comments] VARCHAR(MAX)	, [MG_d28_RDOfficeComments] VARCHAR(MAX)	, [MG_d28_Justiifcation] VARCHAR(MAX)	, [MG_d28_JustiifcationbyHoD] VARCHAR(MAX)	, [MG_d28_Year1] DECIMAL(18,2)	, [MG_d28_Year2] DECIMAL(18,2)	, [MG_d28_Year3] DECIMAL(18,2)	, [MG_d28_Year4] DECIMAL(18,2)	, [MG_d28_Year5] DECIMAL(18,2)	, [MG_d28_Year6] DECIMAL(18,2)	, [MG_d28_Year7] DECIMAL(18,2)	, [MG_d28_Year8] DECIMAL(18,2)	, [MG_d28_Year9] DECIMAL(18,2)	, [MG_d28_Year10] DECIMAL(18,2)	, [MG_d28_Year11] DECIMAL(18,2)	, [MG_d28_Year12] DECIMAL(18,2)){0}INSERT INTO [B73036BB-FE7D-4B0D-998A-985294F8FC5B](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d28_Reappropriation,MG_d28_BudgetID,MG_d28_BudgetAmount,MG_d28_Comments,MG_d28_RDOfficeComments,MG_d28_Justiifcation,MG_d28_JustiifcationbyHoD,MG_d28_Year1,MG_d28_Year2,MG_d28_Year3,MG_d28_Year4,MG_d28_Year5,MG_d28_Year6,MG_d28_Year7,MG_d28_Year8,MG_d28_Year9,MG_d28_Year10,MG_d28_Year11,MG_d28_Year12)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_d28_Reappropriation,TDT.MG_d28_BudgetID,TDT.MG_d28_BudgetAmount,TDT.MG_d28_Comments,TDT.MG_d28_RDOfficeComments,TDT.MG_d28_Justiifcation,TDT.MG_d28_JustiifcationbyHoD,TDT.MG_d28_Year1,TDT.MG_d28_Year2,TDT.MG_d28_Year3,TDT.MG_d28_Year4,TDT.MG_d28_Year5,TDT.MG_d28_Year6,TDT.MG_d28_Year7,TDT.MG_d28_Year8,TDT.MG_d28_Year9,TDT.MG_d28_Year10,TDT.MG_d28_Year11,TDT.MG_d28_Year12 FROM @TBL_B73036BBFE7D4B0D998A985294F8FC5B TDT
							LEFT JOIN [B73036BB-FE7D-4B0D-998A-985294F8FC5B] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MG_d28_Reappropriation=TDT.MG_d28_Reappropriation,MG_d28_BudgetID=TDT.MG_d28_BudgetID,MG_d28_BudgetAmount=TDT.MG_d28_BudgetAmount,MG_d28_Comments=TDT.MG_d28_Comments,MG_d28_RDOfficeComments=TDT.MG_d28_RDOfficeComments,MG_d28_Justiifcation=TDT.MG_d28_Justiifcation,MG_d28_JustiifcationbyHoD=TDT.MG_d28_JustiifcationbyHoD,MG_d28_Year1=TDT.MG_d28_Year1,MG_d28_Year2=TDT.MG_d28_Year2,MG_d28_Year3=TDT.MG_d28_Year3,MG_d28_Year4=TDT.MG_d28_Year4,MG_d28_Year5=TDT.MG_d28_Year5,MG_d28_Year6=TDT.MG_d28_Year6,MG_d28_Year7=TDT.MG_d28_Year7,MG_d28_Year8=TDT.MG_d28_Year8,MG_d28_Year9=TDT.MG_d28_Year9,MG_d28_Year10=TDT.MG_d28_Year10,MG_d28_Year11=TDT.MG_d28_Year11,MG_d28_Year12=TDT.MG_d28_Year12 FROM @TBL_B73036BBFE7D4B0D998A985294F8FC5B TDT
							JOIN [B73036BB-FE7D-4B0D-998A-985294F8FC5B] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d28_Reappropriation,MG_d28_BudgetID,MG_d28_BudgetAmount,MG_d28_Comments,MG_d28_RDOfficeComments,MG_d28_Justiifcation,MG_d28_JustiifcationbyHoD,MG_d28_Year1,MG_d28_Year2,MG_d28_Year3,MG_d28_Year4,MG_d28_Year5,MG_d28_Year6,MG_d28_Year7,MG_d28_Year8,MG_d28_Year9,MG_d28_Year10,MG_d28_Year11,MG_d28_Year12";

                                     tempInsertQuery=@"INSERT INTO @TBL_B73036BBFE7D4B0D998A985294F8FC5B(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d28_Reappropriation,MG_d28_BudgetID,MG_d28_BudgetAmount,MG_d28_Comments,MG_d28_RDOfficeComments,MG_d28_Justiifcation,MG_d28_JustiifcationbyHoD,MG_d28_Year1,MG_d28_Year2,MG_d28_Year3,MG_d28_Year4,MG_d28_Year5,MG_d28_Year6,MG_d28_Year7,MG_d28_Year8,MG_d28_Year9,MG_d28_Year10,MG_d28_Year11,MG_d28_Year12)VALUES({0});";
                                     

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
                     
                                    case "59259E21-AFE8-4DAB-A543-74CC22FC79D5":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_59259E21AFE84DABA54374CC22FC79D5 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_d55_Departmentid] VARCHAR(MAX)	, [MG_d55_AdditionalType] INT	, [MG_d55_AdditionalName] VARCHAR(MAX)	, [MG_d55_ExternalInstituteName] VARCHAR(MAX)	, [MG_d55_ExternalFacultyName] VARCHAR(MAX)	, [MG_d55_DesignationID] VARCHAR(MAX)	, [MG_d55_ExternalDesignation] VARCHAR(MAX)	, [MG_d55_ExternalEmailId] VARCHAR(MAX)	, [MG_d55_ExternalContactNo] VARCHAR(MAX)){0}INSERT INTO [59259E21-AFE8-4DAB-A543-74CC22FC79D5](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d55_Departmentid,MG_d55_AdditionalType,MG_d55_AdditionalName,MG_d55_ExternalInstituteName,MG_d55_ExternalFacultyName,MG_d55_DesignationID,MG_d55_ExternalDesignation,MG_d55_ExternalEmailId,MG_d55_ExternalContactNo)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_d55_Departmentid,TDT.MG_d55_AdditionalType,TDT.MG_d55_AdditionalName,TDT.MG_d55_ExternalInstituteName,TDT.MG_d55_ExternalFacultyName,TDT.MG_d55_DesignationID,TDT.MG_d55_ExternalDesignation,TDT.MG_d55_ExternalEmailId,TDT.MG_d55_ExternalContactNo FROM @TBL_59259E21AFE84DABA54374CC22FC79D5 TDT
							LEFT JOIN [59259E21-AFE8-4DAB-A543-74CC22FC79D5] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MG_d55_Departmentid=TDT.MG_d55_Departmentid,MG_d55_AdditionalType=TDT.MG_d55_AdditionalType,MG_d55_AdditionalName=TDT.MG_d55_AdditionalName,MG_d55_ExternalInstituteName=TDT.MG_d55_ExternalInstituteName,MG_d55_ExternalFacultyName=TDT.MG_d55_ExternalFacultyName,MG_d55_DesignationID=TDT.MG_d55_DesignationID,MG_d55_ExternalDesignation=TDT.MG_d55_ExternalDesignation,MG_d55_ExternalEmailId=TDT.MG_d55_ExternalEmailId,MG_d55_ExternalContactNo=TDT.MG_d55_ExternalContactNo FROM @TBL_59259E21AFE84DABA54374CC22FC79D5 TDT
							JOIN [59259E21-AFE8-4DAB-A543-74CC22FC79D5] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d55_Departmentid,MG_d55_AdditionalType,MG_d55_AdditionalName,MG_d55_ExternalInstituteName,MG_d55_ExternalFacultyName,MG_d55_DesignationID,MG_d55_ExternalDesignation,MG_d55_ExternalEmailId,MG_d55_ExternalContactNo";

                                     tempInsertQuery=@"INSERT INTO @TBL_59259E21AFE84DABA54374CC22FC79D5(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d55_Departmentid,MG_d55_AdditionalType,MG_d55_AdditionalName,MG_d55_ExternalInstituteName,MG_d55_ExternalFacultyName,MG_d55_DesignationID,MG_d55_ExternalDesignation,MG_d55_ExternalEmailId,MG_d55_ExternalContactNo)VALUES({0});";
                                     

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
                     
                                    case "6677BAB3-659A-4A96-9067-5D365F60CB62":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_6677BAB3659A4A9690675D365F60CB62 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_d82_DocumentName] VARCHAR(MAX)	, [MG_d82_DocumentID] INT){0}INSERT INTO [6677BAB3-659A-4A96-9067-5D365F60CB62](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d82_DocumentName,MG_d82_DocumentID)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_d82_DocumentName,TDT.MG_d82_DocumentID FROM @TBL_6677BAB3659A4A9690675D365F60CB62 TDT
							LEFT JOIN [6677BAB3-659A-4A96-9067-5D365F60CB62] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MG_d82_DocumentName=TDT.MG_d82_DocumentName,MG_d82_DocumentID=TDT.MG_d82_DocumentID FROM @TBL_6677BAB3659A4A9690675D365F60CB62 TDT
							JOIN [6677BAB3-659A-4A96-9067-5D365F60CB62] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d82_DocumentName,MG_d82_DocumentID";

                                     tempInsertQuery=@"INSERT INTO @TBL_6677BAB3659A4A9690675D365F60CB62(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d82_DocumentName,MG_d82_DocumentID)VALUES({0});";
                                     

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
                     
                                    case "08F73C4A-3B94-4327-8859-B98388D1C9CD":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_08F73C4A3B9443278859B98388D1C9CD AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_d109_SerialNo] INT	, [MG_d109_EquipmentName] VARCHAR(MAX)	, [MG_d109_Description] VARCHAR(MAX)	, [MG_d109_Quantity] INT	, [MG_d109_RateinINR] DECIMAL(18,2)	, [MG_d109_TotalEquipmentcost] DECIMAL(18,2)	, [MG_d109_EquipmentBudget] INT	, [MG_d109_IsActive] BIT	, [MG_d109_OverallEquipmentcost] DECIMAL(18,2)){0}INSERT INTO [08F73C4A-3B94-4327-8859-B98388D1C9CD](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d109_SerialNo,MG_d109_EquipmentName,MG_d109_Description,MG_d109_Quantity,MG_d109_RateinINR,MG_d109_TotalEquipmentcost,MG_d109_EquipmentBudget,MG_d109_IsActive,MG_d109_OverallEquipmentcost)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_d109_SerialNo,TDT.MG_d109_EquipmentName,TDT.MG_d109_Description,TDT.MG_d109_Quantity,TDT.MG_d109_RateinINR,TDT.MG_d109_TotalEquipmentcost,TDT.MG_d109_EquipmentBudget,TDT.MG_d109_IsActive,TDT.MG_d109_OverallEquipmentcost FROM @TBL_08F73C4A3B9443278859B98388D1C9CD TDT
							LEFT JOIN [08F73C4A-3B94-4327-8859-B98388D1C9CD] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MG_d109_SerialNo=TDT.MG_d109_SerialNo,MG_d109_EquipmentName=TDT.MG_d109_EquipmentName,MG_d109_Description=TDT.MG_d109_Description,MG_d109_Quantity=TDT.MG_d109_Quantity,MG_d109_RateinINR=TDT.MG_d109_RateinINR,MG_d109_TotalEquipmentcost=TDT.MG_d109_TotalEquipmentcost,MG_d109_EquipmentBudget=TDT.MG_d109_EquipmentBudget,MG_d109_IsActive=TDT.MG_d109_IsActive,MG_d109_OverallEquipmentcost=TDT.MG_d109_OverallEquipmentcost FROM @TBL_08F73C4A3B9443278859B98388D1C9CD TDT
							JOIN [08F73C4A-3B94-4327-8859-B98388D1C9CD] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d109_SerialNo,MG_d109_EquipmentName,MG_d109_Description,MG_d109_Quantity,MG_d109_RateinINR,MG_d109_TotalEquipmentcost,MG_d109_EquipmentBudget,MG_d109_IsActive,MG_d109_OverallEquipmentcost";

                                     tempInsertQuery=@"INSERT INTO @TBL_08F73C4A3B9443278859B98388D1C9CD(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d109_SerialNo,MG_d109_EquipmentName,MG_d109_Description,MG_d109_Quantity,MG_d109_RateinINR,MG_d109_TotalEquipmentcost,MG_d109_EquipmentBudget,MG_d109_IsActive,MG_d109_OverallEquipmentcost)VALUES({0});";
                                     

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
                     
                                    case "25683F52-E21A-4CE3-9196-7BCFA640A94B":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_25683F52E21A4CE391967BCFA640A94B AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_d154_Duration] INT	, [MG_d154_SerialNo] INT	, [MG_d154_Comments] VARCHAR(MAX)	, [MG_d154_ManpowerPosition] INT	, [MG_d154_No_OfManpowerPosition] DECIMAL(18,2)	, [MG_d154_RatePerMonth] DECIMAL(18,2)	, [MG_d154_HRAPercentage] DECIMAL(18,2)	, [MG_d154_HRAPerMonth] DECIMAL(18,2)	, [MG_d154_TotalPerMonth] DECIMAL(18,2)	, [MG_d154_TotalMonths] INT	, [MG_d154_TotalCost] DECIMAL(18,2)){0}INSERT INTO [25683F52-E21A-4CE3-9196-7BCFA640A94B](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d154_Duration,MG_d154_SerialNo,MG_d154_Comments,MG_d154_ManpowerPosition,MG_d154_No_OfManpowerPosition,MG_d154_RatePerMonth,MG_d154_HRAPercentage,MG_d154_HRAPerMonth,MG_d154_TotalPerMonth,MG_d154_TotalMonths,MG_d154_TotalCost)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_d154_Duration,TDT.MG_d154_SerialNo,TDT.MG_d154_Comments,TDT.MG_d154_ManpowerPosition,TDT.MG_d154_No_OfManpowerPosition,TDT.MG_d154_RatePerMonth,TDT.MG_d154_HRAPercentage,TDT.MG_d154_HRAPerMonth,TDT.MG_d154_TotalPerMonth,TDT.MG_d154_TotalMonths,TDT.MG_d154_TotalCost FROM @TBL_25683F52E21A4CE391967BCFA640A94B TDT
							LEFT JOIN [25683F52-E21A-4CE3-9196-7BCFA640A94B] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MG_d154_Duration=TDT.MG_d154_Duration,MG_d154_SerialNo=TDT.MG_d154_SerialNo,MG_d154_Comments=TDT.MG_d154_Comments,MG_d154_ManpowerPosition=TDT.MG_d154_ManpowerPosition,MG_d154_No_OfManpowerPosition=TDT.MG_d154_No_OfManpowerPosition,MG_d154_RatePerMonth=TDT.MG_d154_RatePerMonth,MG_d154_HRAPercentage=TDT.MG_d154_HRAPercentage,MG_d154_HRAPerMonth=TDT.MG_d154_HRAPerMonth,MG_d154_TotalPerMonth=TDT.MG_d154_TotalPerMonth,MG_d154_TotalMonths=TDT.MG_d154_TotalMonths,MG_d154_TotalCost=TDT.MG_d154_TotalCost FROM @TBL_25683F52E21A4CE391967BCFA640A94B TDT
							JOIN [25683F52-E21A-4CE3-9196-7BCFA640A94B] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d154_Duration,MG_d154_SerialNo,MG_d154_Comments,MG_d154_ManpowerPosition,MG_d154_No_OfManpowerPosition,MG_d154_RatePerMonth,MG_d154_HRAPercentage,MG_d154_HRAPerMonth,MG_d154_TotalPerMonth,MG_d154_TotalMonths,MG_d154_TotalCost";

                                     tempInsertQuery=@"INSERT INTO @TBL_25683F52E21A4CE391967BCFA640A94B(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d154_Duration,MG_d154_SerialNo,MG_d154_Comments,MG_d154_ManpowerPosition,MG_d154_No_OfManpowerPosition,MG_d154_RatePerMonth,MG_d154_HRAPercentage,MG_d154_HRAPerMonth,MG_d154_TotalPerMonth,MG_d154_TotalMonths,MG_d154_TotalCost)VALUES({0});";
                                     

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
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence FROM @TBL_BDF7896C46764008BC642C45896293B5 TDT
							JOIN [BDF7896C-4676-4008-BC64-2C45896293B5] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId";

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

                                              case "FC9B8D2E-9EE3-436F-AF08-A774AF04D678":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_FC9B8D2E9EE3436FAF08A774AF04D678 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_d2_AdditionalID] VARCHAR(MAX)	, [MG_d2_ProjectDetailsID] VARCHAR(MAX)	, [MG_d2_AdditionalType] VARCHAR(MAX)	, [MG_d2_AdditionalName] VARCHAR(MAX)	, [MG_d2_Departmentid] VARCHAR(MAX)	, [MG_d2_DesignationID] VARCHAR(MAX)	, [MG_d2_ExternalInstituteName] VARCHAR(MAX)	, [MG_d2_ExternalFacultyName] VARCHAR(MAX)	, [MG_d2_ExternalDesignation] VARCHAR(MAX)	, [MG_d2_ExternalEmailId] VARCHAR(MAX)	, [MG_d2_ExternalContactNo] VARCHAR(MAX)	, [MG_d2_UpdatedBy] INT	, [MG_d2_UpdatedOn] DATETIME	, [MG_d2_MemberType] VARCHAR(MAX)	, [MG_EmployeeName] VARCHAR(MAX)	, [MG_EmployeeDepartment] VARCHAR(MAX)	, [MG_AdditionalTypeValue] VARCHAR(MAX)	, [MG_MemberTypeValue] VARCHAR(MAX)){0}INSERT INTO [FC9B8D2E-9EE3-436F-AF08-A774AF04D678](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d2_AdditionalID,MG_d2_ProjectDetailsID,MG_d2_AdditionalType,MG_d2_AdditionalName,MG_d2_Departmentid,MG_d2_DesignationID,MG_d2_ExternalInstituteName,MG_d2_ExternalFacultyName,MG_d2_ExternalDesignation,MG_d2_ExternalEmailId,MG_d2_ExternalContactNo,MG_d2_UpdatedBy,MG_d2_UpdatedOn,MG_d2_MemberType,MG_EmployeeName,MG_EmployeeDepartment,MG_AdditionalTypeValue,MG_MemberTypeValue)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_d2_AdditionalID,TDT.MG_d2_ProjectDetailsID,TDT.MG_d2_AdditionalType,TDT.MG_d2_AdditionalName,TDT.MG_d2_Departmentid,TDT.MG_d2_DesignationID,TDT.MG_d2_ExternalInstituteName,TDT.MG_d2_ExternalFacultyName,TDT.MG_d2_ExternalDesignation,TDT.MG_d2_ExternalEmailId,TDT.MG_d2_ExternalContactNo,TDT.MG_d2_UpdatedBy,TDT.MG_d2_UpdatedOn,TDT.MG_d2_MemberType,TDT.MG_EmployeeName,TDT.MG_EmployeeDepartment,TDT.MG_AdditionalTypeValue,TDT.MG_MemberTypeValue FROM @TBL_FC9B8D2E9EE3436FAF08A774AF04D678 TDT
							LEFT JOIN [FC9B8D2E-9EE3-436F-AF08-A774AF04D678] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MG_d2_AdditionalID=TDT.MG_d2_AdditionalID,MG_d2_ProjectDetailsID=TDT.MG_d2_ProjectDetailsID,MG_d2_AdditionalType=TDT.MG_d2_AdditionalType,MG_d2_AdditionalName=TDT.MG_d2_AdditionalName,MG_d2_Departmentid=TDT.MG_d2_Departmentid,MG_d2_DesignationID=TDT.MG_d2_DesignationID,MG_d2_ExternalInstituteName=TDT.MG_d2_ExternalInstituteName,MG_d2_ExternalFacultyName=TDT.MG_d2_ExternalFacultyName,MG_d2_ExternalDesignation=TDT.MG_d2_ExternalDesignation,MG_d2_ExternalEmailId=TDT.MG_d2_ExternalEmailId,MG_d2_ExternalContactNo=TDT.MG_d2_ExternalContactNo,MG_d2_UpdatedBy=TDT.MG_d2_UpdatedBy,MG_d2_UpdatedOn=TDT.MG_d2_UpdatedOn,MG_d2_MemberType=TDT.MG_d2_MemberType,MG_EmployeeName=TDT.MG_EmployeeName,MG_EmployeeDepartment=TDT.MG_EmployeeDepartment,MG_AdditionalTypeValue=TDT.MG_AdditionalTypeValue,MG_MemberTypeValue=TDT.MG_MemberTypeValue FROM @TBL_FC9B8D2E9EE3436FAF08A774AF04D678 TDT
							JOIN [FC9B8D2E-9EE3-436F-AF08-A774AF04D678] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d2_AdditionalID,MG_d2_ProjectDetailsID,MG_d2_AdditionalType,MG_d2_AdditionalName,MG_d2_Departmentid,MG_d2_DesignationID,MG_d2_ExternalInstituteName,MG_d2_ExternalFacultyName,MG_d2_ExternalDesignation,MG_d2_ExternalEmailId,MG_d2_ExternalContactNo,MG_d2_UpdatedBy,MG_d2_UpdatedOn,MG_d2_MemberType,MG_EmployeeName,MG_EmployeeDepartment,MG_AdditionalTypeValue,MG_MemberTypeValue";

                            tempInsertQuery=@"INSERT INTO @TBL_FC9B8D2E9EE3436FAF08A774AF04D678(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d2_AdditionalID,MG_d2_ProjectDetailsID,MG_d2_AdditionalType,MG_d2_AdditionalName,MG_d2_Departmentid,MG_d2_DesignationID,MG_d2_ExternalInstituteName,MG_d2_ExternalFacultyName,MG_d2_ExternalDesignation,MG_d2_ExternalEmailId,MG_d2_ExternalContactNo,MG_d2_UpdatedBy,MG_d2_UpdatedOn,MG_d2_MemberType,MG_EmployeeName,MG_EmployeeDepartment,MG_AdditionalTypeValue,MG_MemberTypeValue)VALUES({0});";

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
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MG_BudgetName=TDT.MG_BudgetName,MG_Balance=TDT.MG_Balance,MG_ReceivedAmount=TDT.MG_ReceivedAmount,MG_Commitment=TDT.MG_Commitment,MG_Spent=TDT.MG_Spent,MG_YetToReceive=TDT.MG_YetToReceive,MG_SanctionedAmount=TDT.MG_SanctionedAmount FROM @TBL_9CC97541CC4E4D16A92F2FA4A6460E7B TDT
							JOIN [9CC97541-CC4E-4D16-A92F-2FA4A6460E7B] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId";

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

                                              case "D2D6E00A-B6B7-4968-BAAA-EF3D20F2BAC5":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_D2D6E00AB6B74968BAAAEF3D20F2BAC5 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_d3_DocumentName] NVARCHAR(800)	, [MG_d3_UpdatedOn] DATETIME	, [MG_d3_DocumentProposalID] NVARCHAR(100)	, [MG_d3_UploadDocument] BIGINT	, [MG_d3_ProposalDocumentID] NVARCHAR(100)	, [MG_d3_UpdatedBy] BIGINT	, [MG_d3_ProjectproposalID] NVARCHAR(50)	, [MG_d3_MandatoryCheck] INT){0}INSERT INTO [D2D6E00A-B6B7-4968-BAAA-EF3D20F2BAC5](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d3_DocumentName,MG_d3_UpdatedOn,MG_d3_DocumentProposalID,MG_d3_UploadDocument,MG_d3_ProposalDocumentID,MG_d3_UpdatedBy,MG_d3_ProjectproposalID,MG_d3_MandatoryCheck)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_d3_DocumentName,TDT.MG_d3_UpdatedOn,TDT.MG_d3_DocumentProposalID,TDT.MG_d3_UploadDocument,TDT.MG_d3_ProposalDocumentID,TDT.MG_d3_UpdatedBy,TDT.MG_d3_ProjectproposalID,TDT.MG_d3_MandatoryCheck FROM @TBL_D2D6E00AB6B74968BAAAEF3D20F2BAC5 TDT
							LEFT JOIN [D2D6E00A-B6B7-4968-BAAA-EF3D20F2BAC5] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MG_d3_DocumentName=TDT.MG_d3_DocumentName,MG_d3_UpdatedOn=TDT.MG_d3_UpdatedOn,MG_d3_DocumentProposalID=TDT.MG_d3_DocumentProposalID,MG_d3_UploadDocument=TDT.MG_d3_UploadDocument,MG_d3_ProposalDocumentID=TDT.MG_d3_ProposalDocumentID,MG_d3_UpdatedBy=TDT.MG_d3_UpdatedBy,MG_d3_ProjectproposalID=TDT.MG_d3_ProjectproposalID,MG_d3_MandatoryCheck=TDT.MG_d3_MandatoryCheck FROM @TBL_D2D6E00AB6B74968BAAAEF3D20F2BAC5 TDT
							JOIN [D2D6E00A-B6B7-4968-BAAA-EF3D20F2BAC5] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId";

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

                                              case "A3BB2140-4053-4558-9363-3BA1B526BD0A":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_A3BB21404053455893633BA1B526BD0A AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_d4_UpdatedBy] BIGINT	, [MG_d4_DocumentId] NVARCHAR(50)	, [MG_d4_UpdatedOn] DATETIME	, [MG_d4_ProjectproposalID] NVARCHAR(50)	, [MG_d4_Document] BIGINT	, [MG_d4_DocumentName] NVARCHAR(50)	, [MG_d4_Categorymapid] NVARCHAR(50)){0}INSERT INTO [A3BB2140-4053-4558-9363-3BA1B526BD0A](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d4_UpdatedBy,MG_d4_DocumentId,MG_d4_UpdatedOn,MG_d4_ProjectproposalID,MG_d4_Document,MG_d4_DocumentName,MG_d4_Categorymapid)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_d4_UpdatedBy,TDT.MG_d4_DocumentId,TDT.MG_d4_UpdatedOn,TDT.MG_d4_ProjectproposalID,TDT.MG_d4_Document,TDT.MG_d4_DocumentName,TDT.MG_d4_Categorymapid FROM @TBL_A3BB21404053455893633BA1B526BD0A TDT
							LEFT JOIN [A3BB2140-4053-4558-9363-3BA1B526BD0A] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MG_d4_UpdatedBy=TDT.MG_d4_UpdatedBy,MG_d4_DocumentId=TDT.MG_d4_DocumentId,MG_d4_UpdatedOn=TDT.MG_d4_UpdatedOn,MG_d4_ProjectproposalID=TDT.MG_d4_ProjectproposalID,MG_d4_Document=TDT.MG_d4_Document,MG_d4_DocumentName=TDT.MG_d4_DocumentName,MG_d4_Categorymapid=TDT.MG_d4_Categorymapid FROM @TBL_A3BB21404053455893633BA1B526BD0A TDT
							JOIN [A3BB2140-4053-4558-9363-3BA1B526BD0A] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId";

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

                                              case "D56A52C8-2D23-4F88-A6D2-148D57FAD218":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_D56A52C82D234F88A6D2148D57FAD218 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT){0}INSERT INTO [D56A52C8-2D23-4F88-A6D2-148D57FAD218](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence FROM @TBL_D56A52C82D234F88A6D2148D57FAD218 TDT
							LEFT JOIN [D56A52C8-2D23-4F88-A6D2-148D57FAD218] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence FROM @TBL_D56A52C82D234F88A6D2148D57FAD218 TDT
							JOIN [D56A52C8-2D23-4F88-A6D2-148D57FAD218] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence";

                            tempInsertQuery=@"INSERT INTO @TBL_D56A52C82D234F88A6D2148D57FAD218(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence)VALUES({0});";

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

                                              case "D8F430EF-D0A1-4887-B0CC-DB94A0BF0D93":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_D8F430EFD0A14887B0CCDB94A0BF0D93 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MGG_V1_ExpenseID] VARCHAR(MAX)	, [MGG_V1_PackageProcessMapID] VARCHAR(MAX)	, [MGG_V1_ExpenseDate] DATETIME	, [MGG_V1_AmountSpent] DECIMAL(18,2)	, [MGG_V1_ExpenseDescription] VARCHAR(MAX)){0}INSERT INTO [D8F430EF-D0A1-4887-B0CC-DB94A0BF0D93](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MGG_V1_ExpenseID,MGG_V1_PackageProcessMapID,MGG_V1_ExpenseDate,MGG_V1_AmountSpent,MGG_V1_ExpenseDescription)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MGG_V1_ExpenseID,TDT.MGG_V1_PackageProcessMapID,TDT.MGG_V1_ExpenseDate,TDT.MGG_V1_AmountSpent,TDT.MGG_V1_ExpenseDescription FROM @TBL_D8F430EFD0A14887B0CCDB94A0BF0D93 TDT
							LEFT JOIN [D8F430EF-D0A1-4887-B0CC-DB94A0BF0D93] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MGG_V1_ExpenseID=TDT.MGG_V1_ExpenseID,MGG_V1_PackageProcessMapID=TDT.MGG_V1_PackageProcessMapID,MGG_V1_ExpenseDate=TDT.MGG_V1_ExpenseDate,MGG_V1_AmountSpent=TDT.MGG_V1_AmountSpent,MGG_V1_ExpenseDescription=TDT.MGG_V1_ExpenseDescription FROM @TBL_D8F430EFD0A14887B0CCDB94A0BF0D93 TDT
							JOIN [D8F430EF-D0A1-4887-B0CC-DB94A0BF0D93] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MGG_V1_ExpenseID,MGG_V1_PackageProcessMapID,MGG_V1_ExpenseDate,MGG_V1_AmountSpent,MGG_V1_ExpenseDescription";

                            tempInsertQuery=@"INSERT INTO @TBL_D8F430EFD0A14887B0CCDB94A0BF0D93(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MGG_V1_ExpenseID,MGG_V1_PackageProcessMapID,MGG_V1_ExpenseDate,MGG_V1_AmountSpent,MGG_V1_ExpenseDescription)VALUES({0});";

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

                                              case "D20793F2-23FB-4CCE-AB6D-5D14FE42B1B2":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_D20793F223FB4CCEAB6D5D14FE42B1B2 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MGG_V1_BudgetHeadID] VARCHAR(MAX)	, [MGG_V1_ProjectDetailsID] VARCHAR(MAX)	, [MGG_V1_BudgetHead] VARCHAR(MAX)	, [MGG_V1_SanctionedAmount] DECIMAL(18,2)	, [MGG_V1_ReceivedAmount] DECIMAL(18,2)	, [MGG_V1_YettoReceive] DECIMAL(18,2)	, [MGG_V1_Spent] DECIMAL(18,2)	, [MGG_V1_Committment] DECIMAL(18,2)	, [MGG_V1_Balance] DECIMAL(18,2)){0}INSERT INTO [D20793F2-23FB-4CCE-AB6D-5D14FE42B1B2](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MGG_V1_BudgetHeadID,MGG_V1_ProjectDetailsID,MGG_V1_BudgetHead,MGG_V1_SanctionedAmount,MGG_V1_ReceivedAmount,MGG_V1_YettoReceive,MGG_V1_Spent,MGG_V1_Committment,MGG_V1_Balance)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MGG_V1_BudgetHeadID,TDT.MGG_V1_ProjectDetailsID,TDT.MGG_V1_BudgetHead,TDT.MGG_V1_SanctionedAmount,TDT.MGG_V1_ReceivedAmount,TDT.MGG_V1_YettoReceive,TDT.MGG_V1_Spent,TDT.MGG_V1_Committment,TDT.MGG_V1_Balance FROM @TBL_D20793F223FB4CCEAB6D5D14FE42B1B2 TDT
							LEFT JOIN [D20793F2-23FB-4CCE-AB6D-5D14FE42B1B2] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MGG_V1_BudgetHeadID=TDT.MGG_V1_BudgetHeadID,MGG_V1_ProjectDetailsID=TDT.MGG_V1_ProjectDetailsID,MGG_V1_BudgetHead=TDT.MGG_V1_BudgetHead,MGG_V1_SanctionedAmount=TDT.MGG_V1_SanctionedAmount,MGG_V1_ReceivedAmount=TDT.MGG_V1_ReceivedAmount,MGG_V1_YettoReceive=TDT.MGG_V1_YettoReceive,MGG_V1_Spent=TDT.MGG_V1_Spent,MGG_V1_Committment=TDT.MGG_V1_Committment,MGG_V1_Balance=TDT.MGG_V1_Balance FROM @TBL_D20793F223FB4CCEAB6D5D14FE42B1B2 TDT
							JOIN [D20793F2-23FB-4CCE-AB6D-5D14FE42B1B2] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MGG_V1_BudgetHeadID,MGG_V1_ProjectDetailsID,MGG_V1_BudgetHead,MGG_V1_SanctionedAmount,MGG_V1_ReceivedAmount,MGG_V1_YettoReceive,MGG_V1_Spent,MGG_V1_Committment,MGG_V1_Balance";

                            tempInsertQuery=@"INSERT INTO @TBL_D20793F223FB4CCEAB6D5D14FE42B1B2(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MGG_V1_BudgetHeadID,MGG_V1_ProjectDetailsID,MGG_V1_BudgetHead,MGG_V1_SanctionedAmount,MGG_V1_ReceivedAmount,MGG_V1_YettoReceive,MGG_V1_Spent,MGG_V1_Committment,MGG_V1_Balance)VALUES({0});";

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

                                              case "C5B61F31-1A40-4640-939A-14D8636A8493":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_C5B61F311A404640939A14D8636A8493 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MGG_P1_ReceiptsId] VARCHAR(MAX)	, [MGG_P1_ProjectDetailsId] VARCHAR(MAX)	, [MGG_P1_ReceiptAmount] DECIMAL(18,2)	, [MGG_P1_ReceiptDate] DATETIME	, [MGG_P1_TransferType] VARCHAR(MAX)	, [MGG_P1_TransferReferenceNumber] VARCHAR(MAX)	, [MGG_P1_TransferReferenceDate] DATETIME	, [MGG_P1_TransferReferenceBankId] VARCHAR(MAX)	, [MGG_P1_TransferReferenceBranch] VARCHAR(MAX)	, [MGG_P1_ReceiptNo] VARCHAR(MAX)){0}INSERT INTO [C5B61F31-1A40-4640-939A-14D8636A8493](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MGG_P1_ReceiptsId,MGG_P1_ProjectDetailsId,MGG_P1_ReceiptAmount,MGG_P1_ReceiptDate,MGG_P1_TransferType,MGG_P1_TransferReferenceNumber,MGG_P1_TransferReferenceDate,MGG_P1_TransferReferenceBankId,MGG_P1_TransferReferenceBranch,MGG_P1_ReceiptNo)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MGG_P1_ReceiptsId,TDT.MGG_P1_ProjectDetailsId,TDT.MGG_P1_ReceiptAmount,TDT.MGG_P1_ReceiptDate,TDT.MGG_P1_TransferType,TDT.MGG_P1_TransferReferenceNumber,TDT.MGG_P1_TransferReferenceDate,TDT.MGG_P1_TransferReferenceBankId,TDT.MGG_P1_TransferReferenceBranch,TDT.MGG_P1_ReceiptNo FROM @TBL_C5B61F311A404640939A14D8636A8493 TDT
							LEFT JOIN [C5B61F31-1A40-4640-939A-14D8636A8493] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MGG_P1_ReceiptsId=TDT.MGG_P1_ReceiptsId,MGG_P1_ProjectDetailsId=TDT.MGG_P1_ProjectDetailsId,MGG_P1_ReceiptAmount=TDT.MGG_P1_ReceiptAmount,MGG_P1_ReceiptDate=TDT.MGG_P1_ReceiptDate,MGG_P1_TransferType=TDT.MGG_P1_TransferType,MGG_P1_TransferReferenceNumber=TDT.MGG_P1_TransferReferenceNumber,MGG_P1_TransferReferenceDate=TDT.MGG_P1_TransferReferenceDate,MGG_P1_TransferReferenceBankId=TDT.MGG_P1_TransferReferenceBankId,MGG_P1_TransferReferenceBranch=TDT.MGG_P1_TransferReferenceBranch,MGG_P1_ReceiptNo=TDT.MGG_P1_ReceiptNo FROM @TBL_C5B61F311A404640939A14D8636A8493 TDT
							JOIN [C5B61F31-1A40-4640-939A-14D8636A8493] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MGG_P1_ReceiptsId,MGG_P1_ProjectDetailsId,MGG_P1_ReceiptAmount,MGG_P1_ReceiptDate,MGG_P1_TransferType,MGG_P1_TransferReferenceNumber,MGG_P1_TransferReferenceDate,MGG_P1_TransferReferenceBankId,MGG_P1_TransferReferenceBranch,MGG_P1_ReceiptNo";

                            tempInsertQuery=@"INSERT INTO @TBL_C5B61F311A404640939A14D8636A8493(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MGG_P1_ReceiptsId,MGG_P1_ProjectDetailsId,MGG_P1_ReceiptAmount,MGG_P1_ReceiptDate,MGG_P1_TransferType,MGG_P1_TransferReferenceNumber,MGG_P1_TransferReferenceDate,MGG_P1_TransferReferenceBankId,MGG_P1_TransferReferenceBranch,MGG_P1_ReceiptNo)VALUES({0});";

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

                                              case "B73036BB-FE7D-4B0D-998A-985294F8FC5B":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_B73036BBFE7D4B0D998A985294F8FC5B AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_d28_Reappropriation] DECIMAL(18,2)	, [MG_d28_BudgetID] VARCHAR(MAX)	, [MG_d28_BudgetAmount] DECIMAL(18,2)	, [MG_d28_Comments] VARCHAR(MAX)	, [MG_d28_RDOfficeComments] VARCHAR(MAX)	, [MG_d28_Justiifcation] VARCHAR(MAX)	, [MG_d28_JustiifcationbyHoD] VARCHAR(MAX)	, [MG_d28_Year1] DECIMAL(18,2)	, [MG_d28_Year2] DECIMAL(18,2)	, [MG_d28_Year3] DECIMAL(18,2)	, [MG_d28_Year4] DECIMAL(18,2)	, [MG_d28_Year5] DECIMAL(18,2)	, [MG_d28_Year6] DECIMAL(18,2)	, [MG_d28_Year7] DECIMAL(18,2)	, [MG_d28_Year8] DECIMAL(18,2)	, [MG_d28_Year9] DECIMAL(18,2)	, [MG_d28_Year10] DECIMAL(18,2)	, [MG_d28_Year11] DECIMAL(18,2)	, [MG_d28_Year12] DECIMAL(18,2)){0}INSERT INTO [B73036BB-FE7D-4B0D-998A-985294F8FC5B](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d28_Reappropriation,MG_d28_BudgetID,MG_d28_BudgetAmount,MG_d28_Comments,MG_d28_RDOfficeComments,MG_d28_Justiifcation,MG_d28_JustiifcationbyHoD,MG_d28_Year1,MG_d28_Year2,MG_d28_Year3,MG_d28_Year4,MG_d28_Year5,MG_d28_Year6,MG_d28_Year7,MG_d28_Year8,MG_d28_Year9,MG_d28_Year10,MG_d28_Year11,MG_d28_Year12)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_d28_Reappropriation,TDT.MG_d28_BudgetID,TDT.MG_d28_BudgetAmount,TDT.MG_d28_Comments,TDT.MG_d28_RDOfficeComments,TDT.MG_d28_Justiifcation,TDT.MG_d28_JustiifcationbyHoD,TDT.MG_d28_Year1,TDT.MG_d28_Year2,TDT.MG_d28_Year3,TDT.MG_d28_Year4,TDT.MG_d28_Year5,TDT.MG_d28_Year6,TDT.MG_d28_Year7,TDT.MG_d28_Year8,TDT.MG_d28_Year9,TDT.MG_d28_Year10,TDT.MG_d28_Year11,TDT.MG_d28_Year12 FROM @TBL_B73036BBFE7D4B0D998A985294F8FC5B TDT
							LEFT JOIN [B73036BB-FE7D-4B0D-998A-985294F8FC5B] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MG_d28_Reappropriation=TDT.MG_d28_Reappropriation,MG_d28_BudgetID=TDT.MG_d28_BudgetID,MG_d28_BudgetAmount=TDT.MG_d28_BudgetAmount,MG_d28_Comments=TDT.MG_d28_Comments,MG_d28_RDOfficeComments=TDT.MG_d28_RDOfficeComments,MG_d28_Justiifcation=TDT.MG_d28_Justiifcation,MG_d28_JustiifcationbyHoD=TDT.MG_d28_JustiifcationbyHoD,MG_d28_Year1=TDT.MG_d28_Year1,MG_d28_Year2=TDT.MG_d28_Year2,MG_d28_Year3=TDT.MG_d28_Year3,MG_d28_Year4=TDT.MG_d28_Year4,MG_d28_Year5=TDT.MG_d28_Year5,MG_d28_Year6=TDT.MG_d28_Year6,MG_d28_Year7=TDT.MG_d28_Year7,MG_d28_Year8=TDT.MG_d28_Year8,MG_d28_Year9=TDT.MG_d28_Year9,MG_d28_Year10=TDT.MG_d28_Year10,MG_d28_Year11=TDT.MG_d28_Year11,MG_d28_Year12=TDT.MG_d28_Year12 FROM @TBL_B73036BBFE7D4B0D998A985294F8FC5B TDT
							JOIN [B73036BB-FE7D-4B0D-998A-985294F8FC5B] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d28_Reappropriation,MG_d28_BudgetID,MG_d28_BudgetAmount,MG_d28_Comments,MG_d28_RDOfficeComments,MG_d28_Justiifcation,MG_d28_JustiifcationbyHoD,MG_d28_Year1,MG_d28_Year2,MG_d28_Year3,MG_d28_Year4,MG_d28_Year5,MG_d28_Year6,MG_d28_Year7,MG_d28_Year8,MG_d28_Year9,MG_d28_Year10,MG_d28_Year11,MG_d28_Year12";

                            tempInsertQuery=@"INSERT INTO @TBL_B73036BBFE7D4B0D998A985294F8FC5B(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d28_Reappropriation,MG_d28_BudgetID,MG_d28_BudgetAmount,MG_d28_Comments,MG_d28_RDOfficeComments,MG_d28_Justiifcation,MG_d28_JustiifcationbyHoD,MG_d28_Year1,MG_d28_Year2,MG_d28_Year3,MG_d28_Year4,MG_d28_Year5,MG_d28_Year6,MG_d28_Year7,MG_d28_Year8,MG_d28_Year9,MG_d28_Year10,MG_d28_Year11,MG_d28_Year12)VALUES({0});";

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

                                              case "59259E21-AFE8-4DAB-A543-74CC22FC79D5":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_59259E21AFE84DABA54374CC22FC79D5 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_d55_Departmentid] VARCHAR(MAX)	, [MG_d55_AdditionalType] INT	, [MG_d55_AdditionalName] VARCHAR(MAX)	, [MG_d55_ExternalInstituteName] VARCHAR(MAX)	, [MG_d55_ExternalFacultyName] VARCHAR(MAX)	, [MG_d55_DesignationID] VARCHAR(MAX)	, [MG_d55_ExternalDesignation] VARCHAR(MAX)	, [MG_d55_ExternalEmailId] VARCHAR(MAX)	, [MG_d55_ExternalContactNo] VARCHAR(MAX)){0}INSERT INTO [59259E21-AFE8-4DAB-A543-74CC22FC79D5](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d55_Departmentid,MG_d55_AdditionalType,MG_d55_AdditionalName,MG_d55_ExternalInstituteName,MG_d55_ExternalFacultyName,MG_d55_DesignationID,MG_d55_ExternalDesignation,MG_d55_ExternalEmailId,MG_d55_ExternalContactNo)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_d55_Departmentid,TDT.MG_d55_AdditionalType,TDT.MG_d55_AdditionalName,TDT.MG_d55_ExternalInstituteName,TDT.MG_d55_ExternalFacultyName,TDT.MG_d55_DesignationID,TDT.MG_d55_ExternalDesignation,TDT.MG_d55_ExternalEmailId,TDT.MG_d55_ExternalContactNo FROM @TBL_59259E21AFE84DABA54374CC22FC79D5 TDT
							LEFT JOIN [59259E21-AFE8-4DAB-A543-74CC22FC79D5] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MG_d55_Departmentid=TDT.MG_d55_Departmentid,MG_d55_AdditionalType=TDT.MG_d55_AdditionalType,MG_d55_AdditionalName=TDT.MG_d55_AdditionalName,MG_d55_ExternalInstituteName=TDT.MG_d55_ExternalInstituteName,MG_d55_ExternalFacultyName=TDT.MG_d55_ExternalFacultyName,MG_d55_DesignationID=TDT.MG_d55_DesignationID,MG_d55_ExternalDesignation=TDT.MG_d55_ExternalDesignation,MG_d55_ExternalEmailId=TDT.MG_d55_ExternalEmailId,MG_d55_ExternalContactNo=TDT.MG_d55_ExternalContactNo FROM @TBL_59259E21AFE84DABA54374CC22FC79D5 TDT
							JOIN [59259E21-AFE8-4DAB-A543-74CC22FC79D5] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d55_Departmentid,MG_d55_AdditionalType,MG_d55_AdditionalName,MG_d55_ExternalInstituteName,MG_d55_ExternalFacultyName,MG_d55_DesignationID,MG_d55_ExternalDesignation,MG_d55_ExternalEmailId,MG_d55_ExternalContactNo";

                            tempInsertQuery=@"INSERT INTO @TBL_59259E21AFE84DABA54374CC22FC79D5(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d55_Departmentid,MG_d55_AdditionalType,MG_d55_AdditionalName,MG_d55_ExternalInstituteName,MG_d55_ExternalFacultyName,MG_d55_DesignationID,MG_d55_ExternalDesignation,MG_d55_ExternalEmailId,MG_d55_ExternalContactNo)VALUES({0});";

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

                                              case "6677BAB3-659A-4A96-9067-5D365F60CB62":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_6677BAB3659A4A9690675D365F60CB62 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_d82_DocumentName] VARCHAR(MAX)	, [MG_d82_DocumentID] INT){0}INSERT INTO [6677BAB3-659A-4A96-9067-5D365F60CB62](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d82_DocumentName,MG_d82_DocumentID)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_d82_DocumentName,TDT.MG_d82_DocumentID FROM @TBL_6677BAB3659A4A9690675D365F60CB62 TDT
							LEFT JOIN [6677BAB3-659A-4A96-9067-5D365F60CB62] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MG_d82_DocumentName=TDT.MG_d82_DocumentName,MG_d82_DocumentID=TDT.MG_d82_DocumentID FROM @TBL_6677BAB3659A4A9690675D365F60CB62 TDT
							JOIN [6677BAB3-659A-4A96-9067-5D365F60CB62] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d82_DocumentName,MG_d82_DocumentID";

                            tempInsertQuery=@"INSERT INTO @TBL_6677BAB3659A4A9690675D365F60CB62(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d82_DocumentName,MG_d82_DocumentID)VALUES({0});";

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

                                              case "08F73C4A-3B94-4327-8859-B98388D1C9CD":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_08F73C4A3B9443278859B98388D1C9CD AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_d109_SerialNo] INT	, [MG_d109_EquipmentName] VARCHAR(MAX)	, [MG_d109_Description] VARCHAR(MAX)	, [MG_d109_Quantity] INT	, [MG_d109_RateinINR] DECIMAL(18,2)	, [MG_d109_TotalEquipmentcost] DECIMAL(18,2)	, [MG_d109_EquipmentBudget] INT	, [MG_d109_IsActive] BIT	, [MG_d109_OverallEquipmentcost] DECIMAL(18,2)){0}INSERT INTO [08F73C4A-3B94-4327-8859-B98388D1C9CD](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d109_SerialNo,MG_d109_EquipmentName,MG_d109_Description,MG_d109_Quantity,MG_d109_RateinINR,MG_d109_TotalEquipmentcost,MG_d109_EquipmentBudget,MG_d109_IsActive,MG_d109_OverallEquipmentcost)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_d109_SerialNo,TDT.MG_d109_EquipmentName,TDT.MG_d109_Description,TDT.MG_d109_Quantity,TDT.MG_d109_RateinINR,TDT.MG_d109_TotalEquipmentcost,TDT.MG_d109_EquipmentBudget,TDT.MG_d109_IsActive,TDT.MG_d109_OverallEquipmentcost FROM @TBL_08F73C4A3B9443278859B98388D1C9CD TDT
							LEFT JOIN [08F73C4A-3B94-4327-8859-B98388D1C9CD] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MG_d109_SerialNo=TDT.MG_d109_SerialNo,MG_d109_EquipmentName=TDT.MG_d109_EquipmentName,MG_d109_Description=TDT.MG_d109_Description,MG_d109_Quantity=TDT.MG_d109_Quantity,MG_d109_RateinINR=TDT.MG_d109_RateinINR,MG_d109_TotalEquipmentcost=TDT.MG_d109_TotalEquipmentcost,MG_d109_EquipmentBudget=TDT.MG_d109_EquipmentBudget,MG_d109_IsActive=TDT.MG_d109_IsActive,MG_d109_OverallEquipmentcost=TDT.MG_d109_OverallEquipmentcost FROM @TBL_08F73C4A3B9443278859B98388D1C9CD TDT
							JOIN [08F73C4A-3B94-4327-8859-B98388D1C9CD] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d109_SerialNo,MG_d109_EquipmentName,MG_d109_Description,MG_d109_Quantity,MG_d109_RateinINR,MG_d109_TotalEquipmentcost,MG_d109_EquipmentBudget,MG_d109_IsActive,MG_d109_OverallEquipmentcost";

                            tempInsertQuery=@"INSERT INTO @TBL_08F73C4A3B9443278859B98388D1C9CD(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d109_SerialNo,MG_d109_EquipmentName,MG_d109_Description,MG_d109_Quantity,MG_d109_RateinINR,MG_d109_TotalEquipmentcost,MG_d109_EquipmentBudget,MG_d109_IsActive,MG_d109_OverallEquipmentcost)VALUES({0});";

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

                                              case "25683F52-E21A-4CE3-9196-7BCFA640A94B":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_25683F52E21A4CE391967BCFA640A94B AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_d154_Duration] INT	, [MG_d154_SerialNo] INT	, [MG_d154_Comments] VARCHAR(MAX)	, [MG_d154_ManpowerPosition] INT	, [MG_d154_No_OfManpowerPosition] DECIMAL(18,2)	, [MG_d154_RatePerMonth] DECIMAL(18,2)	, [MG_d154_HRAPercentage] DECIMAL(18,2)	, [MG_d154_HRAPerMonth] DECIMAL(18,2)	, [MG_d154_TotalPerMonth] DECIMAL(18,2)	, [MG_d154_TotalMonths] INT	, [MG_d154_TotalCost] DECIMAL(18,2)){0}INSERT INTO [25683F52-E21A-4CE3-9196-7BCFA640A94B](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d154_Duration,MG_d154_SerialNo,MG_d154_Comments,MG_d154_ManpowerPosition,MG_d154_No_OfManpowerPosition,MG_d154_RatePerMonth,MG_d154_HRAPercentage,MG_d154_HRAPerMonth,MG_d154_TotalPerMonth,MG_d154_TotalMonths,MG_d154_TotalCost)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_d154_Duration,TDT.MG_d154_SerialNo,TDT.MG_d154_Comments,TDT.MG_d154_ManpowerPosition,TDT.MG_d154_No_OfManpowerPosition,TDT.MG_d154_RatePerMonth,TDT.MG_d154_HRAPercentage,TDT.MG_d154_HRAPerMonth,TDT.MG_d154_TotalPerMonth,TDT.MG_d154_TotalMonths,TDT.MG_d154_TotalCost FROM @TBL_25683F52E21A4CE391967BCFA640A94B TDT
							LEFT JOIN [25683F52-E21A-4CE3-9196-7BCFA640A94B] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MG_d154_Duration=TDT.MG_d154_Duration,MG_d154_SerialNo=TDT.MG_d154_SerialNo,MG_d154_Comments=TDT.MG_d154_Comments,MG_d154_ManpowerPosition=TDT.MG_d154_ManpowerPosition,MG_d154_No_OfManpowerPosition=TDT.MG_d154_No_OfManpowerPosition,MG_d154_RatePerMonth=TDT.MG_d154_RatePerMonth,MG_d154_HRAPercentage=TDT.MG_d154_HRAPercentage,MG_d154_HRAPerMonth=TDT.MG_d154_HRAPerMonth,MG_d154_TotalPerMonth=TDT.MG_d154_TotalPerMonth,MG_d154_TotalMonths=TDT.MG_d154_TotalMonths,MG_d154_TotalCost=TDT.MG_d154_TotalCost FROM @TBL_25683F52E21A4CE391967BCFA640A94B TDT
							JOIN [25683F52-E21A-4CE3-9196-7BCFA640A94B] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d154_Duration,MG_d154_SerialNo,MG_d154_Comments,MG_d154_ManpowerPosition,MG_d154_No_OfManpowerPosition,MG_d154_RatePerMonth,MG_d154_HRAPercentage,MG_d154_HRAPerMonth,MG_d154_TotalPerMonth,MG_d154_TotalMonths,MG_d154_TotalCost";

                            tempInsertQuery=@"INSERT INTO @TBL_25683F52E21A4CE391967BCFA640A94B(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d154_Duration,MG_d154_SerialNo,MG_d154_Comments,MG_d154_ManpowerPosition,MG_d154_No_OfManpowerPosition,MG_d154_RatePerMonth,MG_d154_HRAPercentage,MG_d154_HRAPerMonth,MG_d154_TotalPerMonth,MG_d154_TotalMonths,MG_d154_TotalCost)VALUES({0});";

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