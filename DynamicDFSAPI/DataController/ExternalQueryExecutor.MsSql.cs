
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

         private readonly string _proofConnectionName;
        
        #endregion

        #region Constuctor
        /// <summary>
        /// method to get ExtarnalQueryExecutorMsSql
        /// </summary>
        public ExternalQueryExecutorMsSql()
        {
            _sysLog = LogManager.GetLogger(GetType());

            _proofConnectionName = AppParams.GetAppSettings("ProofConnectionName");
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
            string query,out Dictionary<short, object> queryResults)
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
            out Dictionary<string,string> queryResult)
        {
            _sysLog.Debug("Entering GetComboDataSource");
                       
            queryResult = null;

            Status status = Status.Failure;

             Database db = null;

            string dbConnectionString = string.Empty;

            try
            {
                               
                var connectionId = comboSource.Item1;
              

                 if(string.IsNullOrEmpty(connectionId))
                {
                   
                    status = ExecuteComboQuery
                     ("", comboSource.Item2, out queryResult);

                    return status;
                }    

                 var connectionString = ConnectionById
                    (_proofConnectionName, connectionId);

                var query = System.Text.RegularExpressions.Regex.Replace(comboSource.Item2, "[^\x20-\x7F]+", " ");

                status = ExecuteComboQuery
                    (connectionString.Connection, query, out queryResult);                                

                return status;               

            }
            catch (Exception ex)
            {
                _sysLog.Error("Error in GetComboDataSource", ex);

                return Status.Failure;

            }
            finally
            {              

                _sysLog.Debug("Exiting GetComboDataSource");
            }
        }

          public Status ExecuteComboQuery(string connectionString,
            string query, out Dictionary<string, string> queryResults)
        {
            IDataReader reader = null;

            queryResults = null;

            Database db=null;

            string dbConnectionString=String.Empty;

            _sysLog.Debug("Entering ExecuteComboQuery.");

            _sysLog.DebugFormat("The QUERY RUNNING IS {0}", query);

            try
            {
                _sysLog.Debug("Entering ExecuteComboQuery");


                if (connectionString == "")
                {
                    db = GetProofInstance();
                }
                else
                {
                    dbConnectionString =
                        GetConnectionString(connectionString);

                    //Get Database instance from Enterprise library
                    db = new SqlDatabase(dbConnectionString);
                }

                if (db == null)
                {

                    return Status.Failure;
                }

                using (DbCommand command = db.GetSqlStringCommand(query))
                {
                    command.CommandTimeout = 10000;


                    using (reader = db.ExecuteReader(command))
                    {
                        if (reader != null)
                        { 
                            queryResults = new Dictionary<string, string>();

                            while (reader.Read())
                            {                                

                                var keyordinal = reader.GetOrdinal("key");

                                var valueordinal = reader.GetOrdinal("value");

                                string keyresult = string.Empty;

                                string valueresult = string.Empty;  

                                 if (!reader.IsDBNull(keyordinal))
                                    keyresult=reader.GetValue(keyordinal).ToString();

                                if (!reader.IsDBNull(valueordinal))
                                    valueresult = reader.GetValue(valueordinal).ToString();
                             
                                queryResults.Add(keyresult, valueresult);
                            }
                        }
                    }
                }

                return Status.Success;
            }
            catch (Exception ex)
            {
                _sysLog.Error("Error in ExecuteComboQuery", ex);

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


                _sysLog.Debug("Exiting ExecuteComboQuery");
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

                
                                      case "49A96C7C-D729-40AB-BA35-E48EC2181E2D":
                    {
                     
                                     fInsertQuery=@"IF NOT EXISTS(SELECT 1 FROM [49A96C7C-D729-40AB-BA35-E48EC2181E2D] WHERE InstanceId='{0}') BEGIN INSERT INTO [49A96C7C-D729-40AB-BA35-E48EC2181E2D](ProcessActivityMapId,FormId,SLATime,MF_ProjectRefNo,MF_Status,MF_PendingCount,MF_CompletedCount,Subject,ExecutionStatus,ExecutionMessage,SetDestinationTo,RedirectUrl,InstanceId)
							VALUES( {3}) END ELSE BEGIN UPDATE [49A96C7C-D729-40AB-BA35-E48EC2181E2D]SET {4}WHERE InstanceId='{0}'END ";

                                     colList=@"ProcessActivityMapId,FormId,SLATime,MF_ProjectRefNo,MF_Status,MF_PendingCount,MF_CompletedCount,Subject,ExecutionStatus,ExecutionMessage,SetDestinationTo,RedirectUrl,InstanceId";
                                    
                     
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
                
                       
                      case "7816392B-A9EF-486D-88F9-AC7C972D679B":
                    {
                     
                                     fInsertQuery=@"IF NOT EXISTS(SELECT 1 FROM [7816392B-A9EF-486D-88F9-AC7C972D679B] WHERE InstanceId='{0}') BEGIN INSERT INTO [7816392B-A9EF-486D-88F9-AC7C972D679B](InstanceId,ProcessActivityMapId,MF_V1_SanctionedValue,F_ProjectDetailsId,MF_ActiveCount,MF_ProposalCount,MF_CompletedCount,MF_SanctionedCount,MF_ActiveAmount,MF_ProjectListActiveProjectspr_PageIndex,MF_ProjectListActiveProjectspr_TotalPages,MF_V1_ProjectDetailsID,MF_V1_ProjectTitle,MF_V1_ProjectNo,MF_V1_Department,MF_V1_PI,MF_V1_CoPI,MF_V1_ProjectType,MF_V1_Agency,MF_V1_StartDate,MF_V1_EndDate,MF_V1_Duration,MF_V1_FinancialYear,MF_Option,Subject,ExecutionStatus,ExecutionMessage,SetDestinationTo,SLATime,MF_ProjectListActiveProjectspr_GridRows,MF_ProjectListActiveProjectspr_RecordsRange,MF_CompletedAmount,MF_ProposalAmount,MF_SanctionedAmount,RedirectUrl,MF_URL,FormId,MF_ProposalPendingCount,MF_ProposalPendingAmount,MF_ProjectPendingCount,MF_ProjectPendingAmount,M_ProcessName,M_Status,M_ProjectStatus,MF_ProposalId,MF_ProjectDetailsId)
							VALUES( {3}) END ELSE BEGIN UPDATE [7816392B-A9EF-486D-88F9-AC7C972D679B]SET {4}WHERE InstanceId='{0}'END ";

                                     colList=@"InstanceId,ProcessActivityMapId,MF_V1_SanctionedValue,F_ProjectDetailsId,MF_ActiveCount,MF_ProposalCount,MF_CompletedCount,MF_SanctionedCount,MF_ActiveAmount,MF_ProjectListActiveProjectspr_PageIndex,MF_ProjectListActiveProjectspr_TotalPages,MF_V1_ProjectDetailsID,MF_V1_ProjectTitle,MF_V1_ProjectNo,MF_V1_Department,MF_V1_PI,MF_V1_CoPI,MF_V1_ProjectType,MF_V1_Agency,MF_V1_StartDate,MF_V1_EndDate,MF_V1_Duration,MF_V1_FinancialYear,MF_Option,Subject,ExecutionStatus,ExecutionMessage,SetDestinationTo,SLATime,MF_ProjectListActiveProjectspr_GridRows,MF_ProjectListActiveProjectspr_RecordsRange,MF_CompletedAmount,MF_ProposalAmount,MF_SanctionedAmount,RedirectUrl,MF_URL,FormId,MF_ProposalPendingCount,MF_ProposalPendingAmount,MF_ProjectPendingCount,MF_ProjectPendingAmount,M_ProcessName,M_Status,M_ProjectStatus,MF_ProposalId,MF_ProjectDetailsId";
                                    
                     
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
                     
                                     fInsertQuery=@"IF NOT EXISTS(SELECT 1 FROM [DA3904EF-0E60-44D0-943E-2E97494B15C8] WHERE InstanceId='{0}') BEGIN INSERT INTO [DA3904EF-0E60-44D0-943E-2E97494B15C8](ProcessActivityMapId,FormId,ExecutionMessage,ExecutionStatus,Subject,SetDestinationTo,MF_ProjectDetailsId,SLATime,MF_ProjectNo,MF_UserName,InstanceId)
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
                
                       
                      case "CB38069E-44DE-463F-BAA6-6EA818E0CA3F":
                    {
                     
                                     fInsertQuery=@"IF NOT EXISTS(SELECT 1 FROM [CB38069E-44DE-463F-BAA6-6EA818E0CA3F] WHERE InstanceId='{0}') BEGIN INSERT INTO [CB38069E-44DE-463F-BAA6-6EA818E0CA3F](ProcessActivityMapId,FormId,SLATime,MF_ProjectRefNo,MF_Status,MF_PendingCount,MF_CompletedCount,Subject,ExecutionStatus,ExecutionMessage,SetDestinationTo,RedirectUrl,InstanceId,M_UserId)
							VALUES( {3}) END ELSE BEGIN UPDATE [CB38069E-44DE-463F-BAA6-6EA818E0CA3F]SET {4}WHERE InstanceId='{0}'END ";

                                     colList=@"ProcessActivityMapId,FormId,SLATime,MF_ProjectRefNo,MF_Status,MF_PendingCount,MF_CompletedCount,Subject,ExecutionStatus,ExecutionMessage,SetDestinationTo,RedirectUrl,InstanceId,M_UserId";
                                    
                     
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
                     
                                     fInsertQuery=@"IF NOT EXISTS(SELECT 1 FROM [E0AC6667-6D92-49AA-8F4D-01F473F2E426] WHERE InstanceId='{0}') BEGIN INSERT INTO [E0AC6667-6D92-49AA-8F4D-01F473F2E426](ProcessActivityMapId,FormId,Subject,ExecutionStatus,ExecutionMessage,SetDestinationTo,SLATime,MF_d1_ProjectProposalID,MF_d1_ProjectRefNo,MF_d1_ProjectCategoryID,MF_d1_FinancialYearID,MF_d1_DepartmentID,MF_d1_Designation,MF_d1_ProjectName,MF_d1_ProjectType,MF_d1_FundingAgency,MF_d1_ProjectBudget,MF_d1_Remarks,MF_d1_PrincipalInvestigator,MF_d1_EmployeeBasicInfoId,MF_d1_ProjectStatus,MF_d1_SectorID,MF_d1_EndorsementFileType,MF_d1_ProposalCode,MF_d1_IsSubmitted,MF_d1_OverHead,MF_d1_IfExternalInstitute,MF_d1_UpdatedBy,MF_d1_UpdatedOn,AssignToRole,AssignToUser,IN_Priority,IN_InstanceName,IN_SLA,IN_Status,IN_Category,ExecuteCommand,RedirectUrl,Thumbnail,CancelRedirectUrl,KeyContext,DisplayContext,growid,MF_d1_Currency,M_DepartmentId,M_DesignationId,Dept,DummyInstance,M_EMPCode,M_DeptCode,MF_d1_ProjectCategoryCode,M_MoveTo,InstanceId,M_FlowType,M_ParentRowId,MandatoryCheck,Comments)
							VALUES( {3}) END ELSE BEGIN UPDATE [E0AC6667-6D92-49AA-8F4D-01F473F2E426]SET {4}WHERE InstanceId='{0}'END ";

                                     colList=@"ProcessActivityMapId,FormId,Subject,ExecutionStatus,ExecutionMessage,SetDestinationTo,SLATime,MF_d1_ProjectProposalID,MF_d1_ProjectRefNo,MF_d1_ProjectCategoryID,MF_d1_FinancialYearID,MF_d1_DepartmentID,MF_d1_Designation,MF_d1_ProjectName,MF_d1_ProjectType,MF_d1_FundingAgency,MF_d1_ProjectBudget,MF_d1_Remarks,MF_d1_PrincipalInvestigator,MF_d1_EmployeeBasicInfoId,MF_d1_ProjectStatus,MF_d1_SectorID,MF_d1_EndorsementFileType,MF_d1_ProposalCode,MF_d1_IsSubmitted,MF_d1_OverHead,MF_d1_IfExternalInstitute,MF_d1_UpdatedBy,MF_d1_UpdatedOn,AssignToRole,AssignToUser,IN_Priority,IN_InstanceName,IN_SLA,IN_Status,IN_Category,ExecuteCommand,RedirectUrl,Thumbnail,CancelRedirectUrl,KeyContext,DisplayContext,growid,MF_d1_Currency,M_DepartmentId,M_DesignationId,Dept,DummyInstance,M_EMPCode,M_DeptCode,MF_d1_ProjectCategoryCode,M_MoveTo,InstanceId,M_FlowType,M_ParentRowId,MandatoryCheck,Comments";
                                    
                     
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
                
                       
                      case "A2D043F8-4C87-4C0C-BB8B-FB2C64B24C44":
                    {
                     
                                     fInsertQuery=@"IF NOT EXISTS(SELECT 1 FROM [A2D043F8-4C87-4C0C-BB8B-FB2C64B24C44] WHERE InstanceId='{0}') BEGIN INSERT INTO [A2D043F8-4C87-4C0C-BB8B-FB2C64B24C44](ProcessActivityMapId,FormId,SLATime,MF_ProjectRefNo,MF_Status,MF_PendingCount,MF_CompletedCount,Subject,ExecutionStatus,ExecutionMessage,SetDestinationTo,RedirectUrl,InstanceId)
							VALUES( {3}) END ELSE BEGIN UPDATE [A2D043F8-4C87-4C0C-BB8B-FB2C64B24C44]SET {4}WHERE InstanceId='{0}'END ";

                                     colList=@"ProcessActivityMapId,FormId,SLATime,MF_ProjectRefNo,MF_Status,MF_PendingCount,MF_CompletedCount,Subject,ExecutionStatus,ExecutionMessage,SetDestinationTo,RedirectUrl,InstanceId";
                                    
                     
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
                     
                                     fInsertQuery=@"IF NOT EXISTS(SELECT 1 FROM [781F63B4-048D-4578-AF08-83C4E8FC0483] WHERE InstanceId='{0}') BEGIN INSERT INTO [781F63B4-048D-4578-AF08-83C4E8FC0483](ProcessActivityMapId,FormId,MF_SameFundingAgency,MF_MultipleProjectsAllowed,MF_PackageProcessMapId,MF_InsertCount,ExecutionStatus,MF_DistributionId,ExecutionMessage,SetDestinationTo,MF_Description,Subject,RedirectUrl,MF_Fundname,SLATime,MF_OtherDistributionId,MF_FundTypeId,MF_MaxPercentageUsage,MF_MaxAmount,InstanceId)
							VALUES( {3}) END ELSE BEGIN UPDATE [781F63B4-048D-4578-AF08-83C4E8FC0483]SET {4}WHERE InstanceId='{0}'END ";

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
                
                       
                      case "7F2113FD-876A-41F4-BEAC-881CA7D38469":
                    {
                     
                                     fInsertQuery=@"IF NOT EXISTS(SELECT 1 FROM [7F2113FD-876A-41F4-BEAC-881CA7D38469] WHERE InstanceId='{0}') BEGIN INSERT INTO [7F2113FD-876A-41F4-BEAC-881CA7D38469](ProcessActivityMapId,FormId,MF_d10_Sector,MF_d10_ProjectDetailsID,MF_d10_InstanceId,MF_d10_ProjectCode,MF_d10_ProjectRefNo,MF_d10_EmployeeBasicInfoId,MF_d10_ActualDate,MF_d10_ActualEndDate,MF_d10_NonRecurringAmount,MF_d10_RecurringAmount,MF_d10_IfExtended,MF_d10_ExtendedDate,MF_d10_BudgetTotalAmount,MF_d10_Overhead,MF_d10_ExchangeRate,MF_d10_DocumentComments,MF_d19_OverallAmount,MF_d145_OverallTotalCost,Subject,ExecutionStatus,ExecutionMessage,SetDestinationTo,SLATime,AssignToRole,AssignToUser,IN_Priority,IN_InstanceName,IN_SLA,IN_Status,IN_Category,ExecuteCommand,RedirectUrl,Thumbnail,CancelRedirectUrl,KeyContext,DisplayContext,growid,MF_d10_FinancialYearID,MF_d10_ProjectName,MF_d10_Duration,MF_d10_IfManpower,MF_d10_IfEquipment,MF_d10_IsExternalIns,MF_d10_FundReceiptMode,MF_d10_PrincipalInvestigator,MF_d10_ProjectproposalID,MF_d10_SanctionedNumber,MF_d10_DepartmentID,MF_d10_SchemeID,MF_d10_FundingAgency,MF_d10_YearMonth,MF_d10_ProjectStatus,MF_d10_Designation,MF_d10_ProjectCategoryID,MF_d10_IsSubmitted,MF_d10_SanctionedDate,MF_d10_FromDate,MF_d10_ToDate,MF_d10_ProjectBudget,MF_d10_ProjectType,InstanceId,M_MoveTo,m_currency,m_typeofproject,MF_d10_RecurringValidation,MF_ManPowerTotal,MF_EquipmentTotal,MF_d10_EmployeeCode,MF_d10_EmpDeptCode,MF_Counter,Comments,M_FlowType,ErrId,ErrMsg)
							VALUES( {3}) END ELSE BEGIN UPDATE [7F2113FD-876A-41F4-BEAC-881CA7D38469]SET {4}WHERE InstanceId='{0}'END ";

                                     colList=@"ProcessActivityMapId,FormId,MF_d10_Sector,MF_d10_ProjectDetailsID,MF_d10_InstanceId,MF_d10_ProjectCode,MF_d10_ProjectRefNo,MF_d10_EmployeeBasicInfoId,MF_d10_ActualDate,MF_d10_ActualEndDate,MF_d10_NonRecurringAmount,MF_d10_RecurringAmount,MF_d10_IfExtended,MF_d10_ExtendedDate,MF_d10_BudgetTotalAmount,MF_d10_Overhead,MF_d10_ExchangeRate,MF_d10_DocumentComments,MF_d19_OverallAmount,MF_d145_OverallTotalCost,Subject,ExecutionStatus,ExecutionMessage,SetDestinationTo,SLATime,AssignToRole,AssignToUser,IN_Priority,IN_InstanceName,IN_SLA,IN_Status,IN_Category,ExecuteCommand,RedirectUrl,Thumbnail,CancelRedirectUrl,KeyContext,DisplayContext,growid,MF_d10_FinancialYearID,MF_d10_ProjectName,MF_d10_Duration,MF_d10_IfManpower,MF_d10_IfEquipment,MF_d10_IsExternalIns,MF_d10_FundReceiptMode,MF_d10_PrincipalInvestigator,MF_d10_ProjectproposalID,MF_d10_SanctionedNumber,MF_d10_DepartmentID,MF_d10_SchemeID,MF_d10_FundingAgency,MF_d10_YearMonth,MF_d10_ProjectStatus,MF_d10_Designation,MF_d10_ProjectCategoryID,MF_d10_IsSubmitted,MF_d10_SanctionedDate,MF_d10_FromDate,MF_d10_ToDate,MF_d10_ProjectBudget,MF_d10_ProjectType,InstanceId,M_MoveTo,m_currency,m_typeofproject,MF_d10_RecurringValidation,MF_ManPowerTotal,MF_EquipmentTotal,MF_d10_EmployeeCode,MF_d10_EmpDeptCode,MF_Counter,Comments,M_FlowType,ErrId,ErrMsg";
                                    
                     
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
                
                       
                      case "7580ABE2-1059-4AB0-AC76-04DE981561BA":
                    {
                     
                                     fInsertQuery=@"IF NOT EXISTS(SELECT 1 FROM [7580ABE2-1059-4AB0-AC76-04DE981561BA] WHERE InstanceId='{0}') BEGIN INSERT INTO [7580ABE2-1059-4AB0-AC76-04DE981561BA](ProcessActivityMapId,FormId,MF_d1_ReimbursementId,MF_d1_EmployeeBasicInfoId,MF_d1_TotalAmount,MF_d1_Initiatedon,MF_d1_InitatedBy,MF_d1_ApplicationStatus,MF_d1_ReimbursementType,MF_d1_Classification,MF_d1_SubClassification,MF_d1_UpdatedBy,MF_d1_UpdatedOn,Subject,ExecutionStatus,ExecutionMessage,SetDestinationTo,SLATime,AssignToRole,AssignToUser,IN_Priority,IN_InstanceName,IN_SLA,IN_Status,IN_Category,ExecuteCommand,RedirectUrl,Thumbnail,CancelRedirectUrl,KeyContext,DisplayContext,growid,InstanceId,UC_EmployeeId,UC_EmployeeName,UC_Designation,UC_Department,MF_ErrId,MF_DeleteRowId,MF_ErrMsg,UC_DOB,UC_PhoneNumber,UC_DOJ,UC_EmailId,UC_Name,UC_PayLevel,UC_Grade,UC_DOR,UC_EmployeeBasicInfoId,FWFM_FundDetailsId,FWFM_FundType,FWFM_ProjectNo,FWFM_BudgetHead,FWFM_Amount,PFMF_PackageProcessMapId,FWAB_ProjectNo,PFMF_UserId,PFM_ErrId,PFM_ErrMsg,PFM_FundDetailsId,WMF_InstanceId,WMF_IsInFlow,WMF_MoveTo,Comments,MF_BillTotal,MF_FundTotal,WF_FlowType,MF_RefNo)
							VALUES( {3}) END ELSE BEGIN UPDATE [7580ABE2-1059-4AB0-AC76-04DE981561BA]SET {4}WHERE InstanceId='{0}'END ";

                                     colList=@"ProcessActivityMapId,FormId,MF_d1_ReimbursementId,MF_d1_EmployeeBasicInfoId,MF_d1_TotalAmount,MF_d1_Initiatedon,MF_d1_InitatedBy,MF_d1_ApplicationStatus,MF_d1_ReimbursementType,MF_d1_Classification,MF_d1_SubClassification,MF_d1_UpdatedBy,MF_d1_UpdatedOn,Subject,ExecutionStatus,ExecutionMessage,SetDestinationTo,SLATime,AssignToRole,AssignToUser,IN_Priority,IN_InstanceName,IN_SLA,IN_Status,IN_Category,ExecuteCommand,RedirectUrl,Thumbnail,CancelRedirectUrl,KeyContext,DisplayContext,growid,InstanceId,UC_EmployeeId,UC_EmployeeName,UC_Designation,UC_Department,MF_ErrId,MF_DeleteRowId,MF_ErrMsg,UC_DOB,UC_PhoneNumber,UC_DOJ,UC_EmailId,UC_Name,UC_PayLevel,UC_Grade,UC_DOR,UC_EmployeeBasicInfoId,FWFM_FundDetailsId,FWFM_FundType,FWFM_ProjectNo,FWFM_BudgetHead,FWFM_Amount,PFMF_PackageProcessMapId,FWAB_ProjectNo,PFMF_UserId,PFM_ErrId,PFM_ErrMsg,PFM_FundDetailsId,WMF_InstanceId,WMF_IsInFlow,WMF_MoveTo,Comments,MF_BillTotal,MF_FundTotal,WF_FlowType,MF_RefNo";
                                    
                     
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
                
                       
                      case "744F780C-12D2-41D3-9084-6E903A527934":
                    {
                     
                                     fInsertQuery=@"IF NOT EXISTS(SELECT 1 FROM [744F780C-12D2-41D3-9084-6E903A527934] WHERE InstanceId='{0}') BEGIN INSERT INTO [744F780C-12D2-41D3-9084-6E903A527934](ProcessActivityMapId,FormId,FWFM_FundDetailsId,FWFM_FundType,FWFM_ProjectNo,FWFM_BudgetHead,FWFM_Amount,PFMF_PackageProcessMapId,FWAB_ProjectNo,PFMF_UserId,PFM_ErrId,PFM_ErrMsg,PFM_FundDetailsId,Subject,ExecutionStatus,ExecutionMessage,SetDestinationTo,SLATime,MF_d2_AdvanceFormId,MF_d2_EmployeeBasicInfoId,MF_d2_TotalAmount,MF_d2_Initiatedon,MF_d2_InitatedBy,MF_d2_ApplicationStatus,MF_d2_UpdatedBy,MF_d2_UpdatedOn,AssignToRole,AssignToUser,IN_Priority,IN_InstanceName,IN_SLA,IN_Status,IN_Category,ExecuteCommand,RedirectUrl,Thumbnail,CancelRedirectUrl,KeyContext,DisplayContext,growid,InstanceId,WMF_IsInFlow,WMF_MoveTo,Comments,WMF_InstanceId,UC_EmployeeId,UC_EmployeeName,UC_Designation,UC_Department,MF_FundTotal,TA_refNo,UC_DOB,UC_PhoneNumber,UC_DOJ,UC_EmailId,UC_Name,UC_Paylevel,UC_Grade,UC_DOR,UC_EmployeeBasicInfoId,MF_ErrId,MF_ErrMsg,MF_IsAdvance,WF_FlowType)
							VALUES( {3}) END ELSE BEGIN UPDATE [744F780C-12D2-41D3-9084-6E903A527934]SET {4}WHERE InstanceId='{0}'END ";

                                     colList=@"ProcessActivityMapId,FormId,FWFM_FundDetailsId,FWFM_FundType,FWFM_ProjectNo,FWFM_BudgetHead,FWFM_Amount,PFMF_PackageProcessMapId,FWAB_ProjectNo,PFMF_UserId,PFM_ErrId,PFM_ErrMsg,PFM_FundDetailsId,Subject,ExecutionStatus,ExecutionMessage,SetDestinationTo,SLATime,MF_d2_AdvanceFormId,MF_d2_EmployeeBasicInfoId,MF_d2_TotalAmount,MF_d2_Initiatedon,MF_d2_InitatedBy,MF_d2_ApplicationStatus,MF_d2_UpdatedBy,MF_d2_UpdatedOn,AssignToRole,AssignToUser,IN_Priority,IN_InstanceName,IN_SLA,IN_Status,IN_Category,ExecuteCommand,RedirectUrl,Thumbnail,CancelRedirectUrl,KeyContext,DisplayContext,growid,InstanceId,WMF_IsInFlow,WMF_MoveTo,Comments,WMF_InstanceId,UC_EmployeeId,UC_EmployeeName,UC_Designation,UC_Department,MF_FundTotal,TA_refNo,UC_DOB,UC_PhoneNumber,UC_DOJ,UC_EmailId,UC_Name,UC_Paylevel,UC_Grade,UC_DOR,UC_EmployeeBasicInfoId,MF_ErrId,MF_ErrMsg,MF_IsAdvance,WF_FlowType";
                                    
                     
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
                
                       
                      case "5D394C98-9AAB-4228-B011-FC8008C3247C":
                    {
                     
                                     fInsertQuery=@"IF NOT EXISTS(SELECT 1 FROM [5D394C98-9AAB-4228-B011-FC8008C3247C] WHERE InstanceId='{0}') BEGIN INSERT INTO [5D394C98-9AAB-4228-B011-FC8008C3247C](ProcessActivityMapId,FormId,WMF_IsInFlow,WMF_MoveTo,Comments,WMF_InstanceId,Subject,ExecutionStatus,ExecutionMessage,SetDestinationTo,SLATime,MF_d1_TravelAdvanceID,MF_d1_EmployeeBasicInfoId,MF_d1_ReferenceNo,MF_d1_JourneyPurpose,MF_d1_TravelType,MF_d1_TravelPlace,MF_d1_IsAdvanceRequired,MF_d1_PaymentRemittenceTo,MF_d1_BeneficiaryName,MF_d1_AccountNo,MF_d1_BankName,MF_d1_IFSCCode,MF_d1_BankDocument,MF_d1_TransactionNo,MF_d1_TransactionDate,MF_d1_TotalAmount,MF_d1_AdvanceAmount,MF_d1_TravelStatus,MF_d1_TSAmount,MF_d1_TSStatus,MF_d1_PITransactionNo,MF_d1_PITransactionDate,MF_d1_TSTransactionNo,MF_d1_TSTransactionDate,MF_d1_CreatedBy,MF_d1_CreatedOn,AssignToRole,AssignToUser,IN_Priority,IN_InstanceName,IN_SLA,IN_Status,IN_Category,ExecuteCommand,RedirectUrl,Thumbnail,CancelRedirectUrl,KeyContext,DisplayContext,growid,MF_TotaTravellExpense,MF_TotalOtherExpense,MF_EligibleAdavnce,FWFM_FundDetailsId,FWFM_FundType,FWFM_ProjectNo,FWFM_BudgetHead,FWFM_Amount,PFMF_PackageProcessMapId,FWAB_ProjectNo,PFMF_UserId,PFM_ErrId,PFM_ErrMsg,PFM_FundDetailsId,InstanceId,UC_EmailId,UC_PhoneNumber,UC_Paylevel,UC_Grade,UC_DOJ,UC_DOR,UC_DOB,UC_EmployeeBaicInfoId,UC_EmployeeId,UC_Name,UC_Designation,UC_Department,PF_FundTotal,WF_FlowType,MF_ErrId,MF_ErrMsg,MF_FundTotal,MF_IsApprovalrequired)
							VALUES( {3}) END ELSE BEGIN UPDATE [5D394C98-9AAB-4228-B011-FC8008C3247C]SET {4}WHERE InstanceId='{0}'END ";

                                     colList=@"ProcessActivityMapId,FormId,WMF_IsInFlow,WMF_MoveTo,Comments,WMF_InstanceId,Subject,ExecutionStatus,ExecutionMessage,SetDestinationTo,SLATime,MF_d1_TravelAdvanceID,MF_d1_EmployeeBasicInfoId,MF_d1_ReferenceNo,MF_d1_JourneyPurpose,MF_d1_TravelType,MF_d1_TravelPlace,MF_d1_IsAdvanceRequired,MF_d1_PaymentRemittenceTo,MF_d1_BeneficiaryName,MF_d1_AccountNo,MF_d1_BankName,MF_d1_IFSCCode,MF_d1_BankDocument,MF_d1_TransactionNo,MF_d1_TransactionDate,MF_d1_TotalAmount,MF_d1_AdvanceAmount,MF_d1_TravelStatus,MF_d1_TSAmount,MF_d1_TSStatus,MF_d1_PITransactionNo,MF_d1_PITransactionDate,MF_d1_TSTransactionNo,MF_d1_TSTransactionDate,MF_d1_CreatedBy,MF_d1_CreatedOn,AssignToRole,AssignToUser,IN_Priority,IN_InstanceName,IN_SLA,IN_Status,IN_Category,ExecuteCommand,RedirectUrl,Thumbnail,CancelRedirectUrl,KeyContext,DisplayContext,growid,MF_TotaTravellExpense,MF_TotalOtherExpense,MF_EligibleAdavnce,FWFM_FundDetailsId,FWFM_FundType,FWFM_ProjectNo,FWFM_BudgetHead,FWFM_Amount,PFMF_PackageProcessMapId,FWAB_ProjectNo,PFMF_UserId,PFM_ErrId,PFM_ErrMsg,PFM_FundDetailsId,InstanceId,UC_EmailId,UC_PhoneNumber,UC_Paylevel,UC_Grade,UC_DOJ,UC_DOR,UC_DOB,UC_EmployeeBaicInfoId,UC_EmployeeId,UC_Name,UC_Designation,UC_Department,PF_FundTotal,WF_FlowType,MF_ErrId,MF_ErrMsg,MF_FundTotal,MF_IsApprovalrequired";
                                    
                     
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
                     
                                     fInsertQuery=@"IF NOT EXISTS(SELECT 1 FROM [8A7A4CC4-0187-401F-BAF6-2AC1394A9245] WHERE InstanceId='{0}') BEGIN INSERT INTO [8A7A4CC4-0187-401F-BAF6-2AC1394A9245](ProcessActivityMapId,FormId,MF_P1_ReceiptAmount,Amounttest,Addflag,IN_Status,M_FieldMandatory,MF_ProjectDetailsID,M_RemarksMandatory,R_ReceiptAmountBalance,R_ReceiptAmountValidation,M_IsSourceStep,M_Amount,MF_P1_Duration,M_SaveDomainData,Editflag,M_IsflowReturned,M_IsCancelReject,MF_P1_UpdatedBy,SLATime,C_FC_SanctionedValue_15,M_BudgetErr,IN_Priority,M_Totalsum,MF_P1_YearMonth,IN_Category,M_RequestId,R_TotalSplitUpAmount,RedirectUrl,IN_InstanceName,MF_E1_EmployeeBasicInfoId,CancelRedirectUrl,SetDestinationTo,UC_EmployeeId,C_FC_SanctionNo_15,UC_Designation,Mailcount,FC_SanctionedValue,MF_P1_ReceiptsId,C_FC_AgencyCode_15,C_FC_ProjectName_15,M_ActivityName,UC_EmployeeBaicInfoId,M_NextStage,AssignToRole,M_Budgetid,ProjectCode,HODUSERID,MF_P1_TransferReferenceNumber,MF_P1_ProjectDetailsId,Subject,FC_AgencyCode,FRValues,M_R2_ReceiptSplitUpId,M_DestinationActivityId,M_BudgetErrMsg,growid,IN_SLA,FC_ProjectNo,MF_P1_ReceiptNo,FC_Category,UC_DOB,FC_EndDate,FC_SanctionedDate,M_PackageProcessMapId,FC_ProjectName,M_Currentlevel,M_Remarks,UC_Grade,FC_SanctionNo,ExecutionStatus,UC_EmailId,UC_PhoneNumber,M_SourceActivityMapId,MF_P1_Status,UC_DOR,UC_Name,MF_P1_TransferReferenceBranch,ExecutionMessage,AssignToUser,M_Status,FC_StartDate,ExecuteCommand,M_InstanceId,KeyContext,DisplayContext,UC_Department,UC_Paylevel,C_FC_Category_15,M_InitiatorUserMapId,M_MoveToValue,UC_DOJ,M_MoveTo,C_FC_ProjectNo_15,MF_P1_TransferReferenceBankId,MF_P1_TransferType,MF_P1_UpdatedOn,MF_P1_ActualEndDate,C_FC_SanctionedDate_15,C_FC_StartDate_15,MF_P1_ReceiptDate,MF_P1_TransferReferenceDate,MF_P1_ActualDate,C_FC_EndDate,Thumbnail,Comments,M_FlowType,ErrorId,InstanceId,MF_FundReceiptMode,MF_SchemeID)
							VALUES( {3}) END ELSE BEGIN UPDATE [8A7A4CC4-0187-401F-BAF6-2AC1394A9245]SET {4}WHERE InstanceId='{0}'END ";

                                     colList=@"ProcessActivityMapId,FormId,MF_P1_ReceiptAmount,Amounttest,Addflag,IN_Status,M_FieldMandatory,MF_ProjectDetailsID,M_RemarksMandatory,R_ReceiptAmountBalance,R_ReceiptAmountValidation,M_IsSourceStep,M_Amount,MF_P1_Duration,M_SaveDomainData,Editflag,M_IsflowReturned,M_IsCancelReject,MF_P1_UpdatedBy,SLATime,C_FC_SanctionedValue_15,M_BudgetErr,IN_Priority,M_Totalsum,MF_P1_YearMonth,IN_Category,M_RequestId,R_TotalSplitUpAmount,RedirectUrl,IN_InstanceName,MF_E1_EmployeeBasicInfoId,CancelRedirectUrl,SetDestinationTo,UC_EmployeeId,C_FC_SanctionNo_15,UC_Designation,Mailcount,FC_SanctionedValue,MF_P1_ReceiptsId,C_FC_AgencyCode_15,C_FC_ProjectName_15,M_ActivityName,UC_EmployeeBaicInfoId,M_NextStage,AssignToRole,M_Budgetid,ProjectCode,HODUSERID,MF_P1_TransferReferenceNumber,MF_P1_ProjectDetailsId,Subject,FC_AgencyCode,FRValues,M_R2_ReceiptSplitUpId,M_DestinationActivityId,M_BudgetErrMsg,growid,IN_SLA,FC_ProjectNo,MF_P1_ReceiptNo,FC_Category,UC_DOB,FC_EndDate,FC_SanctionedDate,M_PackageProcessMapId,FC_ProjectName,M_Currentlevel,M_Remarks,UC_Grade,FC_SanctionNo,ExecutionStatus,UC_EmailId,UC_PhoneNumber,M_SourceActivityMapId,MF_P1_Status,UC_DOR,UC_Name,MF_P1_TransferReferenceBranch,ExecutionMessage,AssignToUser,M_Status,FC_StartDate,ExecuteCommand,M_InstanceId,KeyContext,DisplayContext,UC_Department,UC_Paylevel,C_FC_Category_15,M_InitiatorUserMapId,M_MoveToValue,UC_DOJ,M_MoveTo,C_FC_ProjectNo_15,MF_P1_TransferReferenceBankId,MF_P1_TransferType,MF_P1_UpdatedOn,MF_P1_ActualEndDate,C_FC_SanctionedDate_15,C_FC_StartDate_15,MF_P1_ReceiptDate,MF_P1_TransferReferenceDate,MF_P1_ActualDate,C_FC_EndDate,Thumbnail,Comments,M_FlowType,ErrorId,InstanceId,MF_FundReceiptMode,MF_SchemeID";
                                    
                     
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
                
                       
                      case "8EC3FC2B-F5B6-4077-8C73-B83F5D859FC4":
                    {
                     
                                     fInsertQuery=@"IF NOT EXISTS(SELECT 1 FROM [8EC3FC2B-F5B6-4077-8C73-B83F5D859FC4] WHERE InstanceId='{0}') BEGIN INSERT INTO [8EC3FC2B-F5B6-4077-8C73-B83F5D859FC4](ProcessActivityMapId,FormId,AssignToRole,AssignToUser,IN_Priority,IN_InstanceName,IN_SLA,IN_Status,IN_Category,ExecuteCommand,RedirectUrl,Thumbnail,CancelRedirectUrl,KeyContext,DisplayContext,growid,MF_d1_AdvanceAmount,MF_d1_TravelStatus,MF_d1_TSAmount,MF_d1_TSStatus,MF_d1_PITransactionNo,MF_d1_PITransactionDate,MF_d1_TSTransactionNo,MF_d1_TSTransactionDate,MF_d1_CreatedBy,MF_d1_CreatedOn,Subject,ExecutionStatus,ExecutionMessage,SetDestinationTo,SLATime,MF_TotalRequested,MF_AdvanceCollected,MF_TransactionNo,MF_TransactionDate,R_ReferenceNo,FWFM_Amount,PFMF_PackageProcessMapId,FWAB_ProjectNo,PFMF_UserId,PFM_ErrId,PFM_ErrMsg,PFM_FundDetailsId,MF_d1_TravelAdvanceID,MF_d1_EmployeeBasicInfoId,MF_d1_ReferenceNo,MF_d1_JourneyPurpose,MF_d1_TravelType,MF_d1_TravelPlace,MF_d1_IsAdvanceRequired,MF_d1_PaymentRemittenceTo,MF_d1_BeneficiaryName,MF_d1_AccountNo,MF_d1_BankName,MF_d1_IFSCCode,MF_d1_BankDocument,MF_d1_TransactionNo,MF_d1_TransactionDate,MF_d1_TotalAmount,UC_EmployeeId,UC_Name,UC_Designation,UC_Department,MF_ActualTravelExpense,MF_ActualOtherExpense,MF_SettlementAmount,UC_EmailID,UC_PhoneNumber,UC_DOB,UC_DOJ,UC_DOR,UC_Paylevel,UC_Grade,FWFM_FundDetailsId,FWFM_FundType,FWFM_ProjectNo,FWFM_BudgetHead,WMF_IsInFlow,WMF_MoveTo,Comments,WMF_InstanceId,InstanceId,UC_EmployeeBaicInfoId,WF_FlowType,MF_ErrId,MF_ErrMsg)
							VALUES( {3}) END ELSE BEGIN UPDATE [8EC3FC2B-F5B6-4077-8C73-B83F5D859FC4]SET {4}WHERE InstanceId='{0}'END ";

                                     colList=@"ProcessActivityMapId,FormId,AssignToRole,AssignToUser,IN_Priority,IN_InstanceName,IN_SLA,IN_Status,IN_Category,ExecuteCommand,RedirectUrl,Thumbnail,CancelRedirectUrl,KeyContext,DisplayContext,growid,MF_d1_AdvanceAmount,MF_d1_TravelStatus,MF_d1_TSAmount,MF_d1_TSStatus,MF_d1_PITransactionNo,MF_d1_PITransactionDate,MF_d1_TSTransactionNo,MF_d1_TSTransactionDate,MF_d1_CreatedBy,MF_d1_CreatedOn,Subject,ExecutionStatus,ExecutionMessage,SetDestinationTo,SLATime,MF_TotalRequested,MF_AdvanceCollected,MF_TransactionNo,MF_TransactionDate,R_ReferenceNo,FWFM_Amount,PFMF_PackageProcessMapId,FWAB_ProjectNo,PFMF_UserId,PFM_ErrId,PFM_ErrMsg,PFM_FundDetailsId,MF_d1_TravelAdvanceID,MF_d1_EmployeeBasicInfoId,MF_d1_ReferenceNo,MF_d1_JourneyPurpose,MF_d1_TravelType,MF_d1_TravelPlace,MF_d1_IsAdvanceRequired,MF_d1_PaymentRemittenceTo,MF_d1_BeneficiaryName,MF_d1_AccountNo,MF_d1_BankName,MF_d1_IFSCCode,MF_d1_BankDocument,MF_d1_TransactionNo,MF_d1_TransactionDate,MF_d1_TotalAmount,UC_EmployeeId,UC_Name,UC_Designation,UC_Department,MF_ActualTravelExpense,MF_ActualOtherExpense,MF_SettlementAmount,UC_EmailID,UC_PhoneNumber,UC_DOB,UC_DOJ,UC_DOR,UC_Paylevel,UC_Grade,FWFM_FundDetailsId,FWFM_FundType,FWFM_ProjectNo,FWFM_BudgetHead,WMF_IsInFlow,WMF_MoveTo,Comments,WMF_InstanceId,InstanceId,UC_EmployeeBaicInfoId,WF_FlowType,MF_ErrId,MF_ErrMsg";
                                    
                     
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

                 
                                      case "98F402C4-A592-451F-B29E-2F28BE67530B":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_98F402C4A592451FB29E2F28BE67530B AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [RD_RefNo] VARCHAR(MAX)	, [RD_ReceiptDate] DATETIME	, [RD_ReceiptAmount] DECIMAL(18,2)	, [RD_RefId] VARCHAR(MAX)	, [RD_Status] VARCHAR(MAX)){0}INSERT INTO [98F402C4-A592-451F-B29E-2F28BE67530B](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,RD_RefNo,RD_ReceiptDate,RD_ReceiptAmount,RD_RefId,RD_Status)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.RD_RefNo,TDT.RD_ReceiptDate,TDT.RD_ReceiptAmount,TDT.RD_RefId,TDT.RD_Status FROM @TBL_98F402C4A592451FB29E2F28BE67530B TDT
							LEFT JOIN [98F402C4-A592-451F-B29E-2F28BE67530B] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,RD_RefNo=TDT.RD_RefNo,RD_ReceiptDate=TDT.RD_ReceiptDate,RD_ReceiptAmount=TDT.RD_ReceiptAmount,RD_RefId=TDT.RD_RefId,RD_Status=TDT.RD_Status FROM @TBL_98F402C4A592451FB29E2F28BE67530B TDT
							JOIN [98F402C4-A592-451F-B29E-2F28BE67530B] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,RD_RefNo,RD_ReceiptDate,RD_ReceiptAmount,RD_RefId,RD_Status";

                                     tempInsertQuery=@"INSERT INTO @TBL_98F402C4A592451FB29E2F28BE67530B(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,RD_RefNo,RD_ReceiptDate,RD_ReceiptAmount,RD_RefId,RD_Status)VALUES({0});";
                                     

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
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MG_d2_AdditionalID=TDT.MG_d2_AdditionalID,MG_d2_ProjectDetailsID=TDT.MG_d2_ProjectDetailsID,MG_d2_AdditionalType=TDT.MG_d2_AdditionalType,MG_d2_AdditionalName=TDT.MG_d2_AdditionalName,MG_d2_Departmentid=TDT.MG_d2_Departmentid,MG_d2_DesignationID=TDT.MG_d2_DesignationID,MG_d2_ExternalInstituteName=TDT.MG_d2_ExternalInstituteName,MG_d2_ExternalFacultyName=TDT.MG_d2_ExternalFacultyName,MG_d2_ExternalDesignation=TDT.MG_d2_ExternalDesignation,MG_d2_ExternalEmailId=TDT.MG_d2_ExternalEmailId,MG_d2_ExternalContactNo=TDT.MG_d2_ExternalContactNo,MG_d2_UpdatedBy=TDT.MG_d2_UpdatedBy,MG_d2_UpdatedOn=TDT.MG_d2_UpdatedOn,MG_d2_MemberType=TDT.MG_d2_MemberType,MG_EmployeeName=TDT.MG_EmployeeName,MG_EmployeeDepartment=TDT.MG_EmployeeDepartment,MG_AdditionalTypeValue=TDT.MG_AdditionalTypeValue,MG_MemberTypeValue=TDT.MG_MemberTypeValue FROM @TBL_FC9B8D2E9EE3436FAF08A774AF04D678 TDT
							JOIN [FC9B8D2E-9EE3-436F-AF08-A774AF04D678] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

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
                     
                                    case "BDF7896C-4676-4008-BC64-2C45896293B5":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_BDF7896C46764008BC642C45896293B5 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MGG_V1_ProjectDetailsID] VARCHAR(MAX)	, [MGG_V1_ProjectNo] VARCHAR(MAX)	, [MGG_V1_Department] VARCHAR(MAX)	, [MGG_V1_PI] VARCHAR(MAX)	, [MGG_V1_CoPI] VARCHAR(MAX)	, [MGG_V1_ProjectType] VARCHAR(MAX)	, [MGG_V1_Agency] VARCHAR(MAX)	, [MGG_V1_StartDate] DATETIME	, [MGG_V1_EndDate] DATETIME	, [MGG_V1_Duration] VARCHAR(MAX)	, [MGG_V1_FinancialYear] VARCHAR(MAX)	, [MGG_V1_SanctionedValue] DECIMAL(18,2)	, [MGG_V1_Type] VARCHAR(MAX)){0}INSERT INTO [BDF7896C-4676-4008-BC64-2C45896293B5](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MGG_V1_ProjectDetailsID,MGG_V1_ProjectNo,MGG_V1_Department,MGG_V1_PI,MGG_V1_CoPI,MGG_V1_ProjectType,MGG_V1_Agency,MGG_V1_StartDate,MGG_V1_EndDate,MGG_V1_Duration,MGG_V1_FinancialYear,MGG_V1_SanctionedValue,MGG_V1_Type)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MGG_V1_ProjectDetailsID,TDT.MGG_V1_ProjectNo,TDT.MGG_V1_Department,TDT.MGG_V1_PI,TDT.MGG_V1_CoPI,TDT.MGG_V1_ProjectType,TDT.MGG_V1_Agency,TDT.MGG_V1_StartDate,TDT.MGG_V1_EndDate,TDT.MGG_V1_Duration,TDT.MGG_V1_FinancialYear,TDT.MGG_V1_SanctionedValue,TDT.MGG_V1_Type FROM @TBL_BDF7896C46764008BC642C45896293B5 TDT
							LEFT JOIN [BDF7896C-4676-4008-BC64-2C45896293B5] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MGG_V1_ProjectDetailsID=TDT.MGG_V1_ProjectDetailsID,MGG_V1_ProjectNo=TDT.MGG_V1_ProjectNo,MGG_V1_Department=TDT.MGG_V1_Department,MGG_V1_PI=TDT.MGG_V1_PI,MGG_V1_CoPI=TDT.MGG_V1_CoPI,MGG_V1_ProjectType=TDT.MGG_V1_ProjectType,MGG_V1_Agency=TDT.MGG_V1_Agency,MGG_V1_StartDate=TDT.MGG_V1_StartDate,MGG_V1_EndDate=TDT.MGG_V1_EndDate,MGG_V1_Duration=TDT.MGG_V1_Duration,MGG_V1_FinancialYear=TDT.MGG_V1_FinancialYear,MGG_V1_SanctionedValue=TDT.MGG_V1_SanctionedValue,MGG_V1_Type=TDT.MGG_V1_Type FROM @TBL_BDF7896C46764008BC642C45896293B5 TDT
							JOIN [BDF7896C-4676-4008-BC64-2C45896293B5] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MGG_V1_ProjectDetailsID,MGG_V1_ProjectNo,MGG_V1_Department,MGG_V1_PI,MGG_V1_CoPI,MGG_V1_ProjectType,MGG_V1_Agency,MGG_V1_StartDate,MGG_V1_EndDate,MGG_V1_Duration,MGG_V1_FinancialYear,MGG_V1_SanctionedValue,MGG_V1_Type";

                                     tempInsertQuery=@"INSERT INTO @TBL_BDF7896C46764008BC642C45896293B5(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MGG_V1_ProjectDetailsID,MGG_V1_ProjectNo,MGG_V1_Department,MGG_V1_PI,MGG_V1_CoPI,MGG_V1_ProjectType,MGG_V1_Agency,MGG_V1_StartDate,MGG_V1_EndDate,MGG_V1_Duration,MGG_V1_FinancialYear,MGG_V1_SanctionedValue,MGG_V1_Type)VALUES({0});";
                                     

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
                     
                                    case "23d626be-34a2-1938-8ea1-8cb78d7f1be0":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_23d626be34a219388ea18cb78d7f1be0 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [PD_V1_ProjectDetailsID] VARCHAR(MAX)	, [PD_V1_ProjectNo] VARCHAR(MAX)	, [PD_V1_Department] VARCHAR(MAX)	, [PD_V1_PI] VARCHAR(MAX)	, [PD_V1_CoPI] VARCHAR(MAX)	, [PD_V1_ProjectType] VARCHAR(MAX)	, [PD_V1_Agency] VARCHAR(MAX)	, [PD_V1_FinancialYear] VARCHAR(MAX)	, [PD_V1_SanctionedValue] DECIMAL(18,2)	, [PD_V1_Type] VARCHAR(MAX)){0}INSERT INTO [23d626be-34a2-1938-8ea1-8cb78d7f1be0](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PD_V1_ProjectDetailsID,PD_V1_ProjectNo,PD_V1_Department,PD_V1_PI,PD_V1_CoPI,PD_V1_ProjectType,PD_V1_Agency,PD_V1_FinancialYear,PD_V1_SanctionedValue,PD_V1_Type)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.PD_V1_ProjectDetailsID,TDT.PD_V1_ProjectNo,TDT.PD_V1_Department,TDT.PD_V1_PI,TDT.PD_V1_CoPI,TDT.PD_V1_ProjectType,TDT.PD_V1_Agency,TDT.PD_V1_FinancialYear,TDT.PD_V1_SanctionedValue,TDT.PD_V1_Type FROM @TBL_23d626be34a219388ea18cb78d7f1be0 TDT
							LEFT JOIN [23d626be-34a2-1938-8ea1-8cb78d7f1be0] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,PD_V1_ProjectDetailsID=TDT.PD_V1_ProjectDetailsID,PD_V1_ProjectNo=TDT.PD_V1_ProjectNo,PD_V1_Department=TDT.PD_V1_Department,PD_V1_PI=TDT.PD_V1_PI,PD_V1_CoPI=TDT.PD_V1_CoPI,PD_V1_ProjectType=TDT.PD_V1_ProjectType,PD_V1_Agency=TDT.PD_V1_Agency,PD_V1_FinancialYear=TDT.PD_V1_FinancialYear,PD_V1_SanctionedValue=TDT.PD_V1_SanctionedValue,PD_V1_Type=TDT.PD_V1_Type FROM @TBL_23d626be34a219388ea18cb78d7f1be0 TDT
							JOIN [23d626be-34a2-1938-8ea1-8cb78d7f1be0] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PD_V1_ProjectDetailsID,PD_V1_ProjectNo,PD_V1_Department,PD_V1_PI,PD_V1_CoPI,PD_V1_ProjectType,PD_V1_Agency,PD_V1_FinancialYear,PD_V1_SanctionedValue,PD_V1_Type";

                                     tempInsertQuery=@"INSERT INTO @TBL_23d626be34a219388ea18cb78d7f1be0(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PD_V1_ProjectDetailsID,PD_V1_ProjectNo,PD_V1_Department,PD_V1_PI,PD_V1_CoPI,PD_V1_ProjectType,PD_V1_Agency,PD_V1_FinancialYear,PD_V1_SanctionedValue,PD_V1_Type)VALUES({0});";
                                     

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
                     
                                    case "0429d560-d100-3a28-bdfd-bd0143de5ba7":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_0429d560d1003a28bdfdbd0143de5ba7 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [PP_ProjectDetailsID] VARCHAR(MAX)	, [PP_ProjectNo] VARCHAR(MAX)	, [PP_Department] VARCHAR(MAX)	, [PP_PI] VARCHAR(MAX)	, [PP_CoPI] VARCHAR(MAX)	, [PP_ProjectType] VARCHAR(MAX)	, [PP_Agency] VARCHAR(MAX)	, [PP_FinancialYear] VARCHAR(MAX)	, [PP_SanctionedValue] DECIMAL(18,2)	, [PP_Type] VARCHAR(MAX)){0}INSERT INTO [0429d560-d100-3a28-bdfd-bd0143de5ba7](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PP_ProjectDetailsID,PP_ProjectNo,PP_Department,PP_PI,PP_CoPI,PP_ProjectType,PP_Agency,PP_FinancialYear,PP_SanctionedValue,PP_Type)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.PP_ProjectDetailsID,TDT.PP_ProjectNo,TDT.PP_Department,TDT.PP_PI,TDT.PP_CoPI,TDT.PP_ProjectType,TDT.PP_Agency,TDT.PP_FinancialYear,TDT.PP_SanctionedValue,TDT.PP_Type FROM @TBL_0429d560d1003a28bdfdbd0143de5ba7 TDT
							LEFT JOIN [0429d560-d100-3a28-bdfd-bd0143de5ba7] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,PP_ProjectDetailsID=TDT.PP_ProjectDetailsID,PP_ProjectNo=TDT.PP_ProjectNo,PP_Department=TDT.PP_Department,PP_PI=TDT.PP_PI,PP_CoPI=TDT.PP_CoPI,PP_ProjectType=TDT.PP_ProjectType,PP_Agency=TDT.PP_Agency,PP_FinancialYear=TDT.PP_FinancialYear,PP_SanctionedValue=TDT.PP_SanctionedValue,PP_Type=TDT.PP_Type FROM @TBL_0429d560d1003a28bdfdbd0143de5ba7 TDT
							JOIN [0429d560-d100-3a28-bdfd-bd0143de5ba7] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PP_ProjectDetailsID,PP_ProjectNo,PP_Department,PP_PI,PP_CoPI,PP_ProjectType,PP_Agency,PP_FinancialYear,PP_SanctionedValue,PP_Type";

                                     tempInsertQuery=@"INSERT INTO @TBL_0429d560d1003a28bdfdbd0143de5ba7(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PP_ProjectDetailsID,PP_ProjectNo,PP_Department,PP_PI,PP_CoPI,PP_ProjectType,PP_Agency,PP_FinancialYear,PP_SanctionedValue,PP_Type)VALUES({0});";
                                     

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
		
		DECLARE  @TBL_D2D6E00AB6B74968BAAAEF3D20F2BAC5 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_d3_DocumentName] VARCHAR(MAX)	, [MG_d3_UpdatedOn] DATETIME	, [MG_d3_DocumentProposalID] VARCHAR(MAX)	, [MG_d3_UploadDocument] VARCHAR(36)	, [MG_d3_ProposalDocumentID] VARCHAR(MAX)	, [MG_d3_UpdatedBy] INT	, [MG_d3_ProjectproposalID] VARCHAR(MAX)	, [MG_d3_MandatoryCheck] INT){0}INSERT INTO [D2D6E00A-B6B7-4968-BAAA-EF3D20F2BAC5](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d3_DocumentName,MG_d3_UpdatedOn,MG_d3_DocumentProposalID,MG_d3_UploadDocument,MG_d3_ProposalDocumentID,MG_d3_UpdatedBy,MG_d3_ProjectproposalID,MG_d3_MandatoryCheck)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_d3_DocumentName,TDT.MG_d3_UpdatedOn,TDT.MG_d3_DocumentProposalID,TDT.MG_d3_UploadDocument,TDT.MG_d3_ProposalDocumentID,TDT.MG_d3_UpdatedBy,TDT.MG_d3_ProjectproposalID,TDT.MG_d3_MandatoryCheck FROM @TBL_D2D6E00AB6B74968BAAAEF3D20F2BAC5 TDT
							LEFT JOIN [D2D6E00A-B6B7-4968-BAAA-EF3D20F2BAC5] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MG_d3_DocumentName=TDT.MG_d3_DocumentName,MG_d3_UpdatedOn=TDT.MG_d3_UpdatedOn,MG_d3_DocumentProposalID=TDT.MG_d3_DocumentProposalID,MG_d3_UploadDocument=TDT.MG_d3_UploadDocument,MG_d3_ProposalDocumentID=TDT.MG_d3_ProposalDocumentID,MG_d3_UpdatedBy=TDT.MG_d3_UpdatedBy,MG_d3_ProjectproposalID=TDT.MG_d3_ProjectproposalID,MG_d3_MandatoryCheck=TDT.MG_d3_MandatoryCheck FROM @TBL_D2D6E00AB6B74968BAAAEF3D20F2BAC5 TDT
							JOIN [D2D6E00A-B6B7-4968-BAAA-EF3D20F2BAC5] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

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
		
		DECLARE  @TBL_A3BB21404053455893633BA1B526BD0A AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_d4_UpdatedBy] INT	, [MG_d4_DocumentId] VARCHAR(MAX)	, [MG_d4_UpdatedOn] DATETIME	, [MG_d4_ProjectproposalID] VARCHAR(MAX)	, [MG_d4_Document] VARCHAR(36)	, [MG_d4_DocumentName] VARCHAR(MAX)	, [MG_d4_Categorymapid] VARCHAR(MAX)){0}INSERT INTO [A3BB2140-4053-4558-9363-3BA1B526BD0A](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d4_UpdatedBy,MG_d4_DocumentId,MG_d4_UpdatedOn,MG_d4_ProjectproposalID,MG_d4_Document,MG_d4_DocumentName,MG_d4_Categorymapid)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_d4_UpdatedBy,TDT.MG_d4_DocumentId,TDT.MG_d4_UpdatedOn,TDT.MG_d4_ProjectproposalID,TDT.MG_d4_Document,TDT.MG_d4_DocumentName,TDT.MG_d4_Categorymapid FROM @TBL_A3BB21404053455893633BA1B526BD0A TDT
							LEFT JOIN [A3BB2140-4053-4558-9363-3BA1B526BD0A] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MG_d4_UpdatedBy=TDT.MG_d4_UpdatedBy,MG_d4_DocumentId=TDT.MG_d4_DocumentId,MG_d4_UpdatedOn=TDT.MG_d4_UpdatedOn,MG_d4_ProjectproposalID=TDT.MG_d4_ProjectproposalID,MG_d4_Document=TDT.MG_d4_Document,MG_d4_DocumentName=TDT.MG_d4_DocumentName,MG_d4_Categorymapid=TDT.MG_d4_Categorymapid FROM @TBL_A3BB21404053455893633BA1B526BD0A TDT
							JOIN [A3BB2140-4053-4558-9363-3BA1B526BD0A] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

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
                     
                                    case "99ae5d17-b4b2-d238-11a3-a33c1b7f516b":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_99ae5d17b4b2d23811a3a33c1b7f516b AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [C_Stepfrom] VARCHAR(MAX)	, [C_StepTo] VARCHAR(MAX)	, [C_Comments] VARCHAR(MAX)	, [C_User] VARCHAR(MAX)	, [C_DateofComments] DATETIME){0}INSERT INTO [99ae5d17-b4b2-d238-11a3-a33c1b7f516b](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,C_Stepfrom,C_StepTo,C_Comments,C_User,C_DateofComments)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.C_Stepfrom,TDT.C_StepTo,TDT.C_Comments,TDT.C_User,TDT.C_DateofComments FROM @TBL_99ae5d17b4b2d23811a3a33c1b7f516b TDT
							LEFT JOIN [99ae5d17-b4b2-d238-11a3-a33c1b7f516b] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,C_Stepfrom=TDT.C_Stepfrom,C_StepTo=TDT.C_StepTo,C_Comments=TDT.C_Comments,C_User=TDT.C_User,C_DateofComments=TDT.C_DateofComments FROM @TBL_99ae5d17b4b2d23811a3a33c1b7f516b TDT
							JOIN [99ae5d17-b4b2-d238-11a3-a33c1b7f516b] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,C_Stepfrom,C_StepTo,C_Comments,C_User,C_DateofComments";

                                     tempInsertQuery=@"INSERT INTO @TBL_99ae5d17b4b2d23811a3a33c1b7f516b(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,C_Stepfrom,C_StepTo,C_Comments,C_User,C_DateofComments)VALUES({0});";
                                     

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
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,combo=TDT.combo FROM @TBL_281a2415aef45ac1c31b4beaec59046b TDT
							JOIN [281a2415-aef4-5ac1-c31b-4beaec59046b] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

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
                     
                                    case "9CC97541-CC4E-4D16-A92F-2FA4A6460E7B":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_9CC97541CC4E4D16A92F2FA4A6460E7B AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_BudgetName] VARCHAR(MAX)	, [MG_Balance] DECIMAL(18,2)	, [MG_ReceivedAmount] DECIMAL(18,2)	, [MG_Commitment] DECIMAL(18,2)	, [MG_Spent] DECIMAL(18,2)	, [MG_YetToReceive] DECIMAL(18,2)	, [MG_SanctionedAmount] DECIMAL(18,2)){0}INSERT INTO [9CC97541-CC4E-4D16-A92F-2FA4A6460E7B](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_BudgetName,MG_Balance,MG_ReceivedAmount,MG_Commitment,MG_Spent,MG_YetToReceive,MG_SanctionedAmount)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_BudgetName,TDT.MG_Balance,TDT.MG_ReceivedAmount,TDT.MG_Commitment,TDT.MG_Spent,TDT.MG_YetToReceive,TDT.MG_SanctionedAmount FROM @TBL_9CC97541CC4E4D16A92F2FA4A6460E7B TDT
							LEFT JOIN [9CC97541-CC4E-4D16-A92F-2FA4A6460E7B] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MG_BudgetName=TDT.MG_BudgetName,MG_Balance=TDT.MG_Balance,MG_ReceivedAmount=TDT.MG_ReceivedAmount,MG_Commitment=TDT.MG_Commitment,MG_Spent=TDT.MG_Spent,MG_YetToReceive=TDT.MG_YetToReceive,MG_SanctionedAmount=TDT.MG_SanctionedAmount FROM @TBL_9CC97541CC4E4D16A92F2FA4A6460E7B TDT
							JOIN [9CC97541-CC4E-4D16-A92F-2FA4A6460E7B] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

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
                     
                                    case "c4df7365-678c-f65a-2f9a-d05b5d20bab7":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_c4df7365678cf65a2f9ad05b5d20bab7 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [RD_RefNo] VARCHAR(MAX)	, [RD_ReceiptDate] DATETIME	, [RD_ReceiptAmount] DECIMAL(18,2)	, [RD_RefId] VARCHAR(MAX)	, [RD_Status] VARCHAR(MAX)){0}INSERT INTO [c4df7365-678c-f65a-2f9a-d05b5d20bab7](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,RD_RefNo,RD_ReceiptDate,RD_ReceiptAmount,RD_RefId,RD_Status)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.RD_RefNo,TDT.RD_ReceiptDate,TDT.RD_ReceiptAmount,TDT.RD_RefId,TDT.RD_Status FROM @TBL_c4df7365678cf65a2f9ad05b5d20bab7 TDT
							LEFT JOIN [c4df7365-678c-f65a-2f9a-d05b5d20bab7] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,RD_RefNo=TDT.RD_RefNo,RD_ReceiptDate=TDT.RD_ReceiptDate,RD_ReceiptAmount=TDT.RD_ReceiptAmount,RD_RefId=TDT.RD_RefId,RD_Status=TDT.RD_Status FROM @TBL_c4df7365678cf65a2f9ad05b5d20bab7 TDT
							JOIN [c4df7365-678c-f65a-2f9a-d05b5d20bab7] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,RD_RefNo,RD_ReceiptDate,RD_ReceiptAmount,RD_RefId,RD_Status";

                                     tempInsertQuery=@"INSERT INTO @TBL_c4df7365678cf65a2f9ad05b5d20bab7(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,RD_RefNo,RD_ReceiptDate,RD_ReceiptAmount,RD_RefId,RD_Status)VALUES({0});";
                                     

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
                     
                                    case "10AA6840-065A-4E6E-95CC-29609326A113":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_10AA6840065A4E6E95CC29609326A113 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [RD_RefNo] VARCHAR(MAX)	, [RD_ReceiptDate] DATETIME	, [RD_ReceiptAmount] DECIMAL(18,2)	, [RD_RefId] VARCHAR(MAX)	, [RD_Status] VARCHAR(MAX)){0}INSERT INTO [10AA6840-065A-4E6E-95CC-29609326A113](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,RD_RefNo,RD_ReceiptDate,RD_ReceiptAmount,RD_RefId,RD_Status)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.RD_RefNo,TDT.RD_ReceiptDate,TDT.RD_ReceiptAmount,TDT.RD_RefId,TDT.RD_Status FROM @TBL_10AA6840065A4E6E95CC29609326A113 TDT
							LEFT JOIN [10AA6840-065A-4E6E-95CC-29609326A113] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,RD_RefNo=TDT.RD_RefNo,RD_ReceiptDate=TDT.RD_ReceiptDate,RD_ReceiptAmount=TDT.RD_ReceiptAmount,RD_RefId=TDT.RD_RefId,RD_Status=TDT.RD_Status FROM @TBL_10AA6840065A4E6E95CC29609326A113 TDT
							JOIN [10AA6840-065A-4E6E-95CC-29609326A113] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,RD_RefNo,RD_ReceiptDate,RD_ReceiptAmount,RD_RefId,RD_Status";

                                     tempInsertQuery=@"INSERT INTO @TBL_10AA6840065A4E6E95CC29609326A113(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,RD_RefNo,RD_ReceiptDate,RD_ReceiptAmount,RD_RefId,RD_Status)VALUES({0});";
                                     

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
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MG_ProjectOrOtherId=TDT.MG_ProjectOrOtherId,MG_DistributionId=TDT.MG_DistributionId,MG_FundType=TDT.MG_FundType,MG_BudgetHeadId=TDT.MG_BudgetHeadId,MG_MaxPercentageUsage=TDT.MG_MaxPercentageUsage,MG_MaxAmount=TDT.MG_MaxAmount,MG_Description=TDT.MG_Description FROM @TBL_4f5082a39a94c0aef8470dd75437412a TDT
							JOIN [4f5082a3-9a94-c0ae-f847-0dd75437412a] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

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
                     
                                    case "04FCD160-1EC6-471F-97B0-1C6738875C87":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_04FCD1601EC6471F97B01C6738875C87 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_FundTypeName] VARCHAR(MAX)	, [MG_FundTypeId] INT){0}INSERT INTO [04FCD160-1EC6-471F-97B0-1C6738875C87](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_FundTypeName,MG_FundTypeId)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_FundTypeName,TDT.MG_FundTypeId FROM @TBL_04FCD1601EC6471F97B01C6738875C87 TDT
							LEFT JOIN [04FCD160-1EC6-471F-97B0-1C6738875C87] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MG_FundTypeName=TDT.MG_FundTypeName,MG_FundTypeId=TDT.MG_FundTypeId FROM @TBL_04FCD1601EC6471F97B01C6738875C87 TDT
							JOIN [04FCD160-1EC6-471F-97B0-1C6738875C87] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

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
                     
                                    case "B73036BB-FE7D-4B0D-998A-985294F8FC5B":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_B73036BBFE7D4B0D998A985294F8FC5B AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_d28_RecurringValidation] INT	, [MG_d28_Reappropriation] DECIMAL(18,2)	, [MG_d28_BudgetID] VARCHAR(MAX)	, [MG_d28_BudgetAmount] DECIMAL(18,2)	, [MG_d28_Comments] VARCHAR(MAX)	, [MG_d28_RDOfficeComments] VARCHAR(MAX)	, [MG_d28_Justiifcation] VARCHAR(MAX)	, [MG_d28_JustiifcationbyHoD] VARCHAR(MAX)	, [MG_d28_Year1] DECIMAL(18,2)	, [MG_d28_Year2] DECIMAL(18,2)	, [MG_d28_Year3] DECIMAL(18,2)	, [MG_d28_Year4] DECIMAL(18,2)	, [MG_d28_Year5] DECIMAL(18,2)	, [MG_d28_Year6] DECIMAL(18,2)	, [MG_d28_Year7] DECIMAL(18,2)	, [MG_d28_Year8] DECIMAL(18,2)	, [MG_d28_Year9] DECIMAL(18,2)	, [MG_d28_Year10] DECIMAL(18,2)	, [MG_d28_Year11] DECIMAL(18,2)	, [MG_d28_Year12] DECIMAL(18,2)	, [MG_d28_BudgetHead] VARCHAR(MAX)	, [MG_d28_BudgetDetailsId] VARCHAR(MAX)){0}INSERT INTO [B73036BB-FE7D-4B0D-998A-985294F8FC5B](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d28_RecurringValidation,MG_d28_Reappropriation,MG_d28_BudgetID,MG_d28_BudgetAmount,MG_d28_Comments,MG_d28_RDOfficeComments,MG_d28_Justiifcation,MG_d28_JustiifcationbyHoD,MG_d28_Year1,MG_d28_Year2,MG_d28_Year3,MG_d28_Year4,MG_d28_Year5,MG_d28_Year6,MG_d28_Year7,MG_d28_Year8,MG_d28_Year9,MG_d28_Year10,MG_d28_Year11,MG_d28_Year12,MG_d28_BudgetHead,MG_d28_BudgetDetailsId)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_d28_RecurringValidation,TDT.MG_d28_Reappropriation,TDT.MG_d28_BudgetID,TDT.MG_d28_BudgetAmount,TDT.MG_d28_Comments,TDT.MG_d28_RDOfficeComments,TDT.MG_d28_Justiifcation,TDT.MG_d28_JustiifcationbyHoD,TDT.MG_d28_Year1,TDT.MG_d28_Year2,TDT.MG_d28_Year3,TDT.MG_d28_Year4,TDT.MG_d28_Year5,TDT.MG_d28_Year6,TDT.MG_d28_Year7,TDT.MG_d28_Year8,TDT.MG_d28_Year9,TDT.MG_d28_Year10,TDT.MG_d28_Year11,TDT.MG_d28_Year12,TDT.MG_d28_BudgetHead,TDT.MG_d28_BudgetDetailsId FROM @TBL_B73036BBFE7D4B0D998A985294F8FC5B TDT
							LEFT JOIN [B73036BB-FE7D-4B0D-998A-985294F8FC5B] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MG_d28_RecurringValidation=TDT.MG_d28_RecurringValidation,MG_d28_Reappropriation=TDT.MG_d28_Reappropriation,MG_d28_BudgetID=TDT.MG_d28_BudgetID,MG_d28_BudgetAmount=TDT.MG_d28_BudgetAmount,MG_d28_Comments=TDT.MG_d28_Comments,MG_d28_RDOfficeComments=TDT.MG_d28_RDOfficeComments,MG_d28_Justiifcation=TDT.MG_d28_Justiifcation,MG_d28_JustiifcationbyHoD=TDT.MG_d28_JustiifcationbyHoD,MG_d28_Year1=TDT.MG_d28_Year1,MG_d28_Year2=TDT.MG_d28_Year2,MG_d28_Year3=TDT.MG_d28_Year3,MG_d28_Year4=TDT.MG_d28_Year4,MG_d28_Year5=TDT.MG_d28_Year5,MG_d28_Year6=TDT.MG_d28_Year6,MG_d28_Year7=TDT.MG_d28_Year7,MG_d28_Year8=TDT.MG_d28_Year8,MG_d28_Year9=TDT.MG_d28_Year9,MG_d28_Year10=TDT.MG_d28_Year10,MG_d28_Year11=TDT.MG_d28_Year11,MG_d28_Year12=TDT.MG_d28_Year12,MG_d28_BudgetHead=TDT.MG_d28_BudgetHead,MG_d28_BudgetDetailsId=TDT.MG_d28_BudgetDetailsId FROM @TBL_B73036BBFE7D4B0D998A985294F8FC5B TDT
							JOIN [B73036BB-FE7D-4B0D-998A-985294F8FC5B] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d28_RecurringValidation,MG_d28_Reappropriation,MG_d28_BudgetID,MG_d28_BudgetAmount,MG_d28_Comments,MG_d28_RDOfficeComments,MG_d28_Justiifcation,MG_d28_JustiifcationbyHoD,MG_d28_Year1,MG_d28_Year2,MG_d28_Year3,MG_d28_Year4,MG_d28_Year5,MG_d28_Year6,MG_d28_Year7,MG_d28_Year8,MG_d28_Year9,MG_d28_Year10,MG_d28_Year11,MG_d28_Year12,MG_d28_BudgetHead,MG_d28_BudgetDetailsId";

                                     tempInsertQuery=@"INSERT INTO @TBL_B73036BBFE7D4B0D998A985294F8FC5B(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d28_RecurringValidation,MG_d28_Reappropriation,MG_d28_BudgetID,MG_d28_BudgetAmount,MG_d28_Comments,MG_d28_RDOfficeComments,MG_d28_Justiifcation,MG_d28_JustiifcationbyHoD,MG_d28_Year1,MG_d28_Year2,MG_d28_Year3,MG_d28_Year4,MG_d28_Year5,MG_d28_Year6,MG_d28_Year7,MG_d28_Year8,MG_d28_Year9,MG_d28_Year10,MG_d28_Year11,MG_d28_Year12,MG_d28_BudgetHead,MG_d28_BudgetDetailsId)VALUES({0});";
                                     

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
		
		DECLARE  @TBL_59259E21AFE84DABA54374CC22FC79D5 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_d55_Departmentid] VARCHAR(MAX)	, [MG_d55_AdditionalType] VARCHAR(MAX)	, [MG_d55_AdditionalName] VARCHAR(MAX)	, [MG_d55_ExternalInstituteName] VARCHAR(MAX)	, [MG_d55_ExternalFacultyName] VARCHAR(MAX)	, [MG_d55_DesignationID] VARCHAR(MAX)	, [MG_d55_ExternalDesignation] VARCHAR(MAX)	, [MG_d55_ExternalEmailId] VARCHAR(MAX)	, [MG_d55_ExternalContactNo] VARCHAR(MAX)){0}INSERT INTO [59259E21-AFE8-4DAB-A543-74CC22FC79D5](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d55_Departmentid,MG_d55_AdditionalType,MG_d55_AdditionalName,MG_d55_ExternalInstituteName,MG_d55_ExternalFacultyName,MG_d55_DesignationID,MG_d55_ExternalDesignation,MG_d55_ExternalEmailId,MG_d55_ExternalContactNo)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_d55_Departmentid,TDT.MG_d55_AdditionalType,TDT.MG_d55_AdditionalName,TDT.MG_d55_ExternalInstituteName,TDT.MG_d55_ExternalFacultyName,TDT.MG_d55_DesignationID,TDT.MG_d55_ExternalDesignation,TDT.MG_d55_ExternalEmailId,TDT.MG_d55_ExternalContactNo FROM @TBL_59259E21AFE84DABA54374CC22FC79D5 TDT
							LEFT JOIN [59259E21-AFE8-4DAB-A543-74CC22FC79D5] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MG_d55_Departmentid=TDT.MG_d55_Departmentid,MG_d55_AdditionalType=TDT.MG_d55_AdditionalType,MG_d55_AdditionalName=TDT.MG_d55_AdditionalName,MG_d55_ExternalInstituteName=TDT.MG_d55_ExternalInstituteName,MG_d55_ExternalFacultyName=TDT.MG_d55_ExternalFacultyName,MG_d55_DesignationID=TDT.MG_d55_DesignationID,MG_d55_ExternalDesignation=TDT.MG_d55_ExternalDesignation,MG_d55_ExternalEmailId=TDT.MG_d55_ExternalEmailId,MG_d55_ExternalContactNo=TDT.MG_d55_ExternalContactNo FROM @TBL_59259E21AFE84DABA54374CC22FC79D5 TDT
							JOIN [59259E21-AFE8-4DAB-A543-74CC22FC79D5] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

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
		
		DECLARE  @TBL_6677BAB3659A4A9690675D365F60CB62 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_d82_DocumentName] VARCHAR(MAX)	, [MG_d82_DocumentID] VARCHAR(36)){0}INSERT INTO [6677BAB3-659A-4A96-9067-5D365F60CB62](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d82_DocumentName,MG_d82_DocumentID)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_d82_DocumentName,TDT.MG_d82_DocumentID FROM @TBL_6677BAB3659A4A9690675D365F60CB62 TDT
							LEFT JOIN [6677BAB3-659A-4A96-9067-5D365F60CB62] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MG_d82_DocumentName=TDT.MG_d82_DocumentName,MG_d82_DocumentID=TDT.MG_d82_DocumentID FROM @TBL_6677BAB3659A4A9690675D365F60CB62 TDT
							JOIN [6677BAB3-659A-4A96-9067-5D365F60CB62] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

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
		
		DECLARE  @TBL_08F73C4A3B9443278859B98388D1C9CD AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_d109_SerialNo] INT	, [MG_d109_EquipmentName] VARCHAR(MAX)	, [MG_d109_Description] VARCHAR(MAX)	, [MG_d109_Quantity] INT	, [MG_d109_RateinINR] DECIMAL(18,2)	, [MG_d109_TotalEquipmentcost] DECIMAL(18,2)	, [MG_d109_EquipmentBudget] INT	, [MG_d109_OverallEquipmentcost] DECIMAL(18,2)){0}INSERT INTO [08F73C4A-3B94-4327-8859-B98388D1C9CD](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d109_SerialNo,MG_d109_EquipmentName,MG_d109_Description,MG_d109_Quantity,MG_d109_RateinINR,MG_d109_TotalEquipmentcost,MG_d109_EquipmentBudget,MG_d109_OverallEquipmentcost)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_d109_SerialNo,TDT.MG_d109_EquipmentName,TDT.MG_d109_Description,TDT.MG_d109_Quantity,TDT.MG_d109_RateinINR,TDT.MG_d109_TotalEquipmentcost,TDT.MG_d109_EquipmentBudget,TDT.MG_d109_OverallEquipmentcost FROM @TBL_08F73C4A3B9443278859B98388D1C9CD TDT
							LEFT JOIN [08F73C4A-3B94-4327-8859-B98388D1C9CD] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MG_d109_SerialNo=TDT.MG_d109_SerialNo,MG_d109_EquipmentName=TDT.MG_d109_EquipmentName,MG_d109_Description=TDT.MG_d109_Description,MG_d109_Quantity=TDT.MG_d109_Quantity,MG_d109_RateinINR=TDT.MG_d109_RateinINR,MG_d109_TotalEquipmentcost=TDT.MG_d109_TotalEquipmentcost,MG_d109_EquipmentBudget=TDT.MG_d109_EquipmentBudget,MG_d109_OverallEquipmentcost=TDT.MG_d109_OverallEquipmentcost FROM @TBL_08F73C4A3B9443278859B98388D1C9CD TDT
							JOIN [08F73C4A-3B94-4327-8859-B98388D1C9CD] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d109_SerialNo,MG_d109_EquipmentName,MG_d109_Description,MG_d109_Quantity,MG_d109_RateinINR,MG_d109_TotalEquipmentcost,MG_d109_EquipmentBudget,MG_d109_OverallEquipmentcost";

                                     tempInsertQuery=@"INSERT INTO @TBL_08F73C4A3B9443278859B98388D1C9CD(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d109_SerialNo,MG_d109_EquipmentName,MG_d109_Description,MG_d109_Quantity,MG_d109_RateinINR,MG_d109_TotalEquipmentcost,MG_d109_EquipmentBudget,MG_d109_OverallEquipmentcost)VALUES({0});";
                                     

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
		
		DECLARE  @TBL_25683F52E21A4CE391967BCFA640A94B AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_d154_Duration] INT	, [MG_d154_SerialNo] INT	, [MG_d154_Comments] VARCHAR(MAX)	, [MG_d154_ManpowerPosition] VARCHAR(250)	, [MG_d154_No_OfManpowerPosition] DECIMAL(18,2)	, [MG_d154_RatePerMonth] DECIMAL(18,2)	, [MG_d154_HRAPercentage] DECIMAL(18,2)	, [MG_d154_HRAPerMonth] DECIMAL(18,2)	, [MG_d154_TotalPerMonth] DECIMAL(18,2)	, [MG_d154_TotalMonths] INT	, [MG_d154_TotalCost] DECIMAL(18,2)){0}INSERT INTO [25683F52-E21A-4CE3-9196-7BCFA640A94B](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d154_Duration,MG_d154_SerialNo,MG_d154_Comments,MG_d154_ManpowerPosition,MG_d154_No_OfManpowerPosition,MG_d154_RatePerMonth,MG_d154_HRAPercentage,MG_d154_HRAPerMonth,MG_d154_TotalPerMonth,MG_d154_TotalMonths,MG_d154_TotalCost)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_d154_Duration,TDT.MG_d154_SerialNo,TDT.MG_d154_Comments,TDT.MG_d154_ManpowerPosition,TDT.MG_d154_No_OfManpowerPosition,TDT.MG_d154_RatePerMonth,TDT.MG_d154_HRAPercentage,TDT.MG_d154_HRAPerMonth,TDT.MG_d154_TotalPerMonth,TDT.MG_d154_TotalMonths,TDT.MG_d154_TotalCost FROM @TBL_25683F52E21A4CE391967BCFA640A94B TDT
							LEFT JOIN [25683F52-E21A-4CE3-9196-7BCFA640A94B] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MG_d154_Duration=TDT.MG_d154_Duration,MG_d154_SerialNo=TDT.MG_d154_SerialNo,MG_d154_Comments=TDT.MG_d154_Comments,MG_d154_ManpowerPosition=TDT.MG_d154_ManpowerPosition,MG_d154_No_OfManpowerPosition=TDT.MG_d154_No_OfManpowerPosition,MG_d154_RatePerMonth=TDT.MG_d154_RatePerMonth,MG_d154_HRAPercentage=TDT.MG_d154_HRAPercentage,MG_d154_HRAPerMonth=TDT.MG_d154_HRAPerMonth,MG_d154_TotalPerMonth=TDT.MG_d154_TotalPerMonth,MG_d154_TotalMonths=TDT.MG_d154_TotalMonths,MG_d154_TotalCost=TDT.MG_d154_TotalCost FROM @TBL_25683F52E21A4CE391967BCFA640A94B TDT
							JOIN [25683F52-E21A-4CE3-9196-7BCFA640A94B] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

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
                     
                                    case "f1825943-98b5-f54f-0225-0081ef436f94":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_f182594398b5f54f02250081ef436f94 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [C_Stepfrom] VARCHAR(MAX)	, [C_StepTo] VARCHAR(MAX)	, [C_Comments] VARCHAR(MAX)	, [C_User] VARCHAR(MAX)	, [C_DateofComments] DATETIME){0}INSERT INTO [f1825943-98b5-f54f-0225-0081ef436f94](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,C_Stepfrom,C_StepTo,C_Comments,C_User,C_DateofComments)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.C_Stepfrom,TDT.C_StepTo,TDT.C_Comments,TDT.C_User,TDT.C_DateofComments FROM @TBL_f182594398b5f54f02250081ef436f94 TDT
							LEFT JOIN [f1825943-98b5-f54f-0225-0081ef436f94] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,C_Stepfrom=TDT.C_Stepfrom,C_StepTo=TDT.C_StepTo,C_Comments=TDT.C_Comments,C_User=TDT.C_User,C_DateofComments=TDT.C_DateofComments FROM @TBL_f182594398b5f54f02250081ef436f94 TDT
							JOIN [f1825943-98b5-f54f-0225-0081ef436f94] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,C_Stepfrom,C_StepTo,C_Comments,C_User,C_DateofComments";

                                     tempInsertQuery=@"INSERT INTO @TBL_f182594398b5f54f02250081ef436f94(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,C_Stepfrom,C_StepTo,C_Comments,C_User,C_DateofComments)VALUES({0});";
                                     

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
                     
                                    case "98357E55-B276-4E6E-9A45-2588BF6CE0E4":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_98357E55B2764E6E9A452588BF6CE0E4 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_d2_ReimbursementDetailsId] VARCHAR(MAX)	, [MG_d2_ReimbursementId] VARCHAR(MAX)	, [MG_d2_BillNo] VARCHAR(MAX)	, [MG_d2_BillDate] DATETIME	, [MG_d2_BillDocument] INT	, [MG_d2_ItemDescription] VARCHAR(MAX)	, [MG_d2_Amount] DECIMAL(18,2)){0}INSERT INTO [98357E55-B276-4E6E-9A45-2588BF6CE0E4](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d2_ReimbursementDetailsId,MG_d2_ReimbursementId,MG_d2_BillNo,MG_d2_BillDate,MG_d2_BillDocument,MG_d2_ItemDescription,MG_d2_Amount)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_d2_ReimbursementDetailsId,TDT.MG_d2_ReimbursementId,TDT.MG_d2_BillNo,TDT.MG_d2_BillDate,TDT.MG_d2_BillDocument,TDT.MG_d2_ItemDescription,TDT.MG_d2_Amount FROM @TBL_98357E55B2764E6E9A452588BF6CE0E4 TDT
							LEFT JOIN [98357E55-B276-4E6E-9A45-2588BF6CE0E4] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MG_d2_ReimbursementDetailsId=TDT.MG_d2_ReimbursementDetailsId,MG_d2_ReimbursementId=TDT.MG_d2_ReimbursementId,MG_d2_BillNo=TDT.MG_d2_BillNo,MG_d2_BillDate=TDT.MG_d2_BillDate,MG_d2_BillDocument=TDT.MG_d2_BillDocument,MG_d2_ItemDescription=TDT.MG_d2_ItemDescription,MG_d2_Amount=TDT.MG_d2_Amount FROM @TBL_98357E55B2764E6E9A452588BF6CE0E4 TDT
							JOIN [98357E55-B276-4E6E-9A45-2588BF6CE0E4] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d2_ReimbursementDetailsId,MG_d2_ReimbursementId,MG_d2_BillNo,MG_d2_BillDate,MG_d2_BillDocument,MG_d2_ItemDescription,MG_d2_Amount";

                                     tempInsertQuery=@"INSERT INTO @TBL_98357E55B2764E6E9A452588BF6CE0E4(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d2_ReimbursementDetailsId,MG_d2_ReimbursementId,MG_d2_BillNo,MG_d2_BillDate,MG_d2_BillDocument,MG_d2_ItemDescription,MG_d2_Amount)VALUES({0});";
                                     

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
                     
                                    case "825B4680-DEA2-4E2E-861A-965DE912D14B":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_825B4680DEA24E2E861A965DE912D14B AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [PFA_FundType] VARCHAR(MAX)	, [PFA_FundTypeValue] VARCHAR(MAX)	, [PFA_ProjectNo] VARCHAR(MAX)	, [PFA_ProjectNoValue] VARCHAR(MAX)	, [PFA_BudgetHead] VARCHAR(MAX)	, [PFA_BudgetHeadValue] VARCHAR(MAX)	, [PFA_Amount] DECIMAL(18,2)	, [PFA_FundDetailsId] VARCHAR(MAX)){0}INSERT INTO [825B4680-DEA2-4E2E-861A-965DE912D14B](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PFA_FundType,PFA_FundTypeValue,PFA_ProjectNo,PFA_ProjectNoValue,PFA_BudgetHead,PFA_BudgetHeadValue,PFA_Amount,PFA_FundDetailsId)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.PFA_FundType,TDT.PFA_FundTypeValue,TDT.PFA_ProjectNo,TDT.PFA_ProjectNoValue,TDT.PFA_BudgetHead,TDT.PFA_BudgetHeadValue,TDT.PFA_Amount,TDT.PFA_FundDetailsId FROM @TBL_825B4680DEA24E2E861A965DE912D14B TDT
							LEFT JOIN [825B4680-DEA2-4E2E-861A-965DE912D14B] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,PFA_FundType=TDT.PFA_FundType,PFA_FundTypeValue=TDT.PFA_FundTypeValue,PFA_ProjectNo=TDT.PFA_ProjectNo,PFA_ProjectNoValue=TDT.PFA_ProjectNoValue,PFA_BudgetHead=TDT.PFA_BudgetHead,PFA_BudgetHeadValue=TDT.PFA_BudgetHeadValue,PFA_Amount=TDT.PFA_Amount,PFA_FundDetailsId=TDT.PFA_FundDetailsId FROM @TBL_825B4680DEA24E2E861A965DE912D14B TDT
							JOIN [825B4680-DEA2-4E2E-861A-965DE912D14B] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PFA_FundType,PFA_FundTypeValue,PFA_ProjectNo,PFA_ProjectNoValue,PFA_BudgetHead,PFA_BudgetHeadValue,PFA_Amount,PFA_FundDetailsId";

                                     tempInsertQuery=@"INSERT INTO @TBL_825B4680DEA24E2E861A965DE912D14B(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PFA_FundType,PFA_FundTypeValue,PFA_ProjectNo,PFA_ProjectNoValue,PFA_BudgetHead,PFA_BudgetHeadValue,PFA_Amount,PFA_FundDetailsId)VALUES({0});";
                                     

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
                     
                                    case "6B7A35BC-59EB-4CFB-8FBF-ADB3E8BC39C6":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_6B7A35BC59EB4CFB8FBFADB3E8BC39C6 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [PAB_BudgetName] VARCHAR(MAX)	, [PAB_SanctionedAmount] DECIMAL(18,2)	, [PAB_YetToRecieve] DECIMAL(18,2)	, [PAB_RecievedAmount] DECIMAL(18,2)	, [PAB_Commitment] DECIMAL(18,2)	, [PAB_Spent] DECIMAL(18,2)	, [PAB_Balance] DECIMAL(18,2)){0}INSERT INTO [6B7A35BC-59EB-4CFB-8FBF-ADB3E8BC39C6](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PAB_BudgetName,PAB_SanctionedAmount,PAB_YetToRecieve,PAB_RecievedAmount,PAB_Commitment,PAB_Spent,PAB_Balance)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.PAB_BudgetName,TDT.PAB_SanctionedAmount,TDT.PAB_YetToRecieve,TDT.PAB_RecievedAmount,TDT.PAB_Commitment,TDT.PAB_Spent,TDT.PAB_Balance FROM @TBL_6B7A35BC59EB4CFB8FBFADB3E8BC39C6 TDT
							LEFT JOIN [6B7A35BC-59EB-4CFB-8FBF-ADB3E8BC39C6] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,PAB_BudgetName=TDT.PAB_BudgetName,PAB_SanctionedAmount=TDT.PAB_SanctionedAmount,PAB_YetToRecieve=TDT.PAB_YetToRecieve,PAB_RecievedAmount=TDT.PAB_RecievedAmount,PAB_Commitment=TDT.PAB_Commitment,PAB_Spent=TDT.PAB_Spent,PAB_Balance=TDT.PAB_Balance FROM @TBL_6B7A35BC59EB4CFB8FBFADB3E8BC39C6 TDT
							JOIN [6B7A35BC-59EB-4CFB-8FBF-ADB3E8BC39C6] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PAB_BudgetName,PAB_SanctionedAmount,PAB_YetToRecieve,PAB_RecievedAmount,PAB_Commitment,PAB_Spent,PAB_Balance";

                                     tempInsertQuery=@"INSERT INTO @TBL_6B7A35BC59EB4CFB8FBFADB3E8BC39C6(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PAB_BudgetName,PAB_SanctionedAmount,PAB_YetToRecieve,PAB_RecievedAmount,PAB_Commitment,PAB_Spent,PAB_Balance)VALUES({0});";
                                     

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
                     
                                    case "95D6FCFD-4B36-4E23-B424-43AB84B1680B":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_95D6FCFD4B364E23B42443AB84B1680B AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [PADD_DocumentName] VARCHAR(MAX)	, [PADD_Document] VARCHAR(MAX)){0}INSERT INTO [95D6FCFD-4B36-4E23-B424-43AB84B1680B](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PADD_DocumentName,PADD_Document)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.PADD_DocumentName,TDT.PADD_Document FROM @TBL_95D6FCFD4B364E23B42443AB84B1680B TDT
							LEFT JOIN [95D6FCFD-4B36-4E23-B424-43AB84B1680B] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,PADD_DocumentName=TDT.PADD_DocumentName,PADD_Document=TDT.PADD_Document FROM @TBL_95D6FCFD4B364E23B42443AB84B1680B TDT
							JOIN [95D6FCFD-4B36-4E23-B424-43AB84B1680B] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PADD_DocumentName,PADD_Document";

                                     tempInsertQuery=@"INSERT INTO @TBL_95D6FCFD4B364E23B42443AB84B1680B(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PADD_DocumentName,PADD_Document)VALUES({0});";
                                     

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
                     
                                    case "8F47B89A-AF4A-4A73-BE87-44CF1EBCC456":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_8F47B89AAF4A4A73BE8744CF1EBCC456 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [WMC_StepFrom] VARCHAR(MAX)	, [WMC_StepTo] VARCHAR(MAX)	, [WMC_Comments] VARCHAR(MAX)	, [WMC_User] VARCHAR(MAX)	, [WMC_DateofComments] DATETIME){0}INSERT INTO [8F47B89A-AF4A-4A73-BE87-44CF1EBCC456](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,WMC_StepFrom,WMC_StepTo,WMC_Comments,WMC_User,WMC_DateofComments)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.WMC_StepFrom,TDT.WMC_StepTo,TDT.WMC_Comments,TDT.WMC_User,TDT.WMC_DateofComments FROM @TBL_8F47B89AAF4A4A73BE8744CF1EBCC456 TDT
							LEFT JOIN [8F47B89A-AF4A-4A73-BE87-44CF1EBCC456] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,WMC_StepFrom=TDT.WMC_StepFrom,WMC_StepTo=TDT.WMC_StepTo,WMC_Comments=TDT.WMC_Comments,WMC_User=TDT.WMC_User,WMC_DateofComments=TDT.WMC_DateofComments FROM @TBL_8F47B89AAF4A4A73BE8744CF1EBCC456 TDT
							JOIN [8F47B89A-AF4A-4A73-BE87-44CF1EBCC456] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,WMC_StepFrom,WMC_StepTo,WMC_Comments,WMC_User,WMC_DateofComments";

                                     tempInsertQuery=@"INSERT INTO @TBL_8F47B89AAF4A4A73BE8744CF1EBCC456(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,WMC_StepFrom,WMC_StepTo,WMC_Comments,WMC_User,WMC_DateofComments)VALUES({0});";
                                     

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
                     
                                    case "1478D76F-6E75-4C46-A32B-BB50FE153540":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_1478D76F6E754C46A32BBB50FE153540 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [WMC_StepFrom] VARCHAR(MAX)	, [WMC_StepTo] VARCHAR(MAX)	, [WMC_Comments] VARCHAR(MAX)	, [WMC_User] VARCHAR(MAX)	, [WMC_DateofComments] DATETIME){0}INSERT INTO [1478D76F-6E75-4C46-A32B-BB50FE153540](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,WMC_StepFrom,WMC_StepTo,WMC_Comments,WMC_User,WMC_DateofComments)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.WMC_StepFrom,TDT.WMC_StepTo,TDT.WMC_Comments,TDT.WMC_User,TDT.WMC_DateofComments FROM @TBL_1478D76F6E754C46A32BBB50FE153540 TDT
							LEFT JOIN [1478D76F-6E75-4C46-A32B-BB50FE153540] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,WMC_StepFrom=TDT.WMC_StepFrom,WMC_StepTo=TDT.WMC_StepTo,WMC_Comments=TDT.WMC_Comments,WMC_User=TDT.WMC_User,WMC_DateofComments=TDT.WMC_DateofComments FROM @TBL_1478D76F6E754C46A32BBB50FE153540 TDT
							JOIN [1478D76F-6E75-4C46-A32B-BB50FE153540] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,WMC_StepFrom,WMC_StepTo,WMC_Comments,WMC_User,WMC_DateofComments";

                                     tempInsertQuery=@"INSERT INTO @TBL_1478D76F6E754C46A32BBB50FE153540(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,WMC_StepFrom,WMC_StepTo,WMC_Comments,WMC_User,WMC_DateofComments)VALUES({0});";
                                     

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
                     
                                    case "36296F3B-23C7-4F14-BC64-C4E49DB8C854":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_36296F3B23C74F14BC64C4E49DB8C854 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [PADD_DocumentName] VARCHAR(MAX)	, [PADD_Document] VARCHAR(MAX)){0}INSERT INTO [36296F3B-23C7-4F14-BC64-C4E49DB8C854](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PADD_DocumentName,PADD_Document)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.PADD_DocumentName,TDT.PADD_Document FROM @TBL_36296F3B23C74F14BC64C4E49DB8C854 TDT
							LEFT JOIN [36296F3B-23C7-4F14-BC64-C4E49DB8C854] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,PADD_DocumentName=TDT.PADD_DocumentName,PADD_Document=TDT.PADD_Document FROM @TBL_36296F3B23C74F14BC64C4E49DB8C854 TDT
							JOIN [36296F3B-23C7-4F14-BC64-C4E49DB8C854] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PADD_DocumentName,PADD_Document";

                                     tempInsertQuery=@"INSERT INTO @TBL_36296F3B23C74F14BC64C4E49DB8C854(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PADD_DocumentName,PADD_Document)VALUES({0});";
                                     

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
                     
                                    case "0337B98B-59FA-46DC-87A0-89AA288D41AC":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_0337B98B59FA46DC87A089AA288D41AC AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_d1_RequestDetailsId] VARCHAR(MAX)	, [MG_d1_AdvanceFormId] VARCHAR(MAX)	, [MG_d1_ExpenseDetails] VARCHAR(MAX)	, [MG_d1_ItemDescription] VARCHAR(MAX)	, [MG_d1_Amount] DECIMAL(18,2)){0}INSERT INTO [0337B98B-59FA-46DC-87A0-89AA288D41AC](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d1_RequestDetailsId,MG_d1_AdvanceFormId,MG_d1_ExpenseDetails,MG_d1_ItemDescription,MG_d1_Amount)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_d1_RequestDetailsId,TDT.MG_d1_AdvanceFormId,TDT.MG_d1_ExpenseDetails,TDT.MG_d1_ItemDescription,TDT.MG_d1_Amount FROM @TBL_0337B98B59FA46DC87A089AA288D41AC TDT
							LEFT JOIN [0337B98B-59FA-46DC-87A0-89AA288D41AC] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MG_d1_RequestDetailsId=TDT.MG_d1_RequestDetailsId,MG_d1_AdvanceFormId=TDT.MG_d1_AdvanceFormId,MG_d1_ExpenseDetails=TDT.MG_d1_ExpenseDetails,MG_d1_ItemDescription=TDT.MG_d1_ItemDescription,MG_d1_Amount=TDT.MG_d1_Amount FROM @TBL_0337B98B59FA46DC87A089AA288D41AC TDT
							JOIN [0337B98B-59FA-46DC-87A0-89AA288D41AC] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d1_RequestDetailsId,MG_d1_AdvanceFormId,MG_d1_ExpenseDetails,MG_d1_ItemDescription,MG_d1_Amount";

                                     tempInsertQuery=@"INSERT INTO @TBL_0337B98B59FA46DC87A089AA288D41AC(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d1_RequestDetailsId,MG_d1_AdvanceFormId,MG_d1_ExpenseDetails,MG_d1_ItemDescription,MG_d1_Amount)VALUES({0});";
                                     

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
                     
                                    case "331FE6C6-9B84-4AE8-9DD4-AD780298EEAE":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_331FE6C69B844AE89DD4AD780298EEAE AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [PFA_FundType] VARCHAR(MAX)	, [PFA_FundTypeValue] VARCHAR(MAX)	, [PFA_ProjectNo] VARCHAR(MAX)	, [PFA_ProjectNoValue] VARCHAR(MAX)	, [PFA_BudgetHead] VARCHAR(MAX)	, [PFA_BudgetHeadValue] VARCHAR(MAX)	, [PFA_Amount] DECIMAL(18,2)	, [PFA_FundDetailsId] VARCHAR(MAX)){0}INSERT INTO [331FE6C6-9B84-4AE8-9DD4-AD780298EEAE](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PFA_FundType,PFA_FundTypeValue,PFA_ProjectNo,PFA_ProjectNoValue,PFA_BudgetHead,PFA_BudgetHeadValue,PFA_Amount,PFA_FundDetailsId)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.PFA_FundType,TDT.PFA_FundTypeValue,TDT.PFA_ProjectNo,TDT.PFA_ProjectNoValue,TDT.PFA_BudgetHead,TDT.PFA_BudgetHeadValue,TDT.PFA_Amount,TDT.PFA_FundDetailsId FROM @TBL_331FE6C69B844AE89DD4AD780298EEAE TDT
							LEFT JOIN [331FE6C6-9B84-4AE8-9DD4-AD780298EEAE] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,PFA_FundType=TDT.PFA_FundType,PFA_FundTypeValue=TDT.PFA_FundTypeValue,PFA_ProjectNo=TDT.PFA_ProjectNo,PFA_ProjectNoValue=TDT.PFA_ProjectNoValue,PFA_BudgetHead=TDT.PFA_BudgetHead,PFA_BudgetHeadValue=TDT.PFA_BudgetHeadValue,PFA_Amount=TDT.PFA_Amount,PFA_FundDetailsId=TDT.PFA_FundDetailsId FROM @TBL_331FE6C69B844AE89DD4AD780298EEAE TDT
							JOIN [331FE6C6-9B84-4AE8-9DD4-AD780298EEAE] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PFA_FundType,PFA_FundTypeValue,PFA_ProjectNo,PFA_ProjectNoValue,PFA_BudgetHead,PFA_BudgetHeadValue,PFA_Amount,PFA_FundDetailsId";

                                     tempInsertQuery=@"INSERT INTO @TBL_331FE6C69B844AE89DD4AD780298EEAE(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PFA_FundType,PFA_FundTypeValue,PFA_ProjectNo,PFA_ProjectNoValue,PFA_BudgetHead,PFA_BudgetHeadValue,PFA_Amount,PFA_FundDetailsId)VALUES({0});";
                                     

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
                     
                                    case "F02A7F6F-1659-4623-8B7E-1C2330D6485E":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_F02A7F6F165946238B7E1C2330D6485E AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [PAB_BudgetName] VARCHAR(MAX)	, [PAB_SanctionedAmount] DECIMAL(18,2)	, [PAB_YetToRecieve] DECIMAL(18,2)	, [PAB_RecievedAmount] DECIMAL(18,2)	, [PAB_Commitment] DECIMAL(18,2)	, [PAB_Spent] DECIMAL(18,2)	, [PAB_Balance] DECIMAL(18,2)){0}INSERT INTO [F02A7F6F-1659-4623-8B7E-1C2330D6485E](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PAB_BudgetName,PAB_SanctionedAmount,PAB_YetToRecieve,PAB_RecievedAmount,PAB_Commitment,PAB_Spent,PAB_Balance)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.PAB_BudgetName,TDT.PAB_SanctionedAmount,TDT.PAB_YetToRecieve,TDT.PAB_RecievedAmount,TDT.PAB_Commitment,TDT.PAB_Spent,TDT.PAB_Balance FROM @TBL_F02A7F6F165946238B7E1C2330D6485E TDT
							LEFT JOIN [F02A7F6F-1659-4623-8B7E-1C2330D6485E] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,PAB_BudgetName=TDT.PAB_BudgetName,PAB_SanctionedAmount=TDT.PAB_SanctionedAmount,PAB_YetToRecieve=TDT.PAB_YetToRecieve,PAB_RecievedAmount=TDT.PAB_RecievedAmount,PAB_Commitment=TDT.PAB_Commitment,PAB_Spent=TDT.PAB_Spent,PAB_Balance=TDT.PAB_Balance FROM @TBL_F02A7F6F165946238B7E1C2330D6485E TDT
							JOIN [F02A7F6F-1659-4623-8B7E-1C2330D6485E] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PAB_BudgetName,PAB_SanctionedAmount,PAB_YetToRecieve,PAB_RecievedAmount,PAB_Commitment,PAB_Spent,PAB_Balance";

                                     tempInsertQuery=@"INSERT INTO @TBL_F02A7F6F165946238B7E1C2330D6485E(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PAB_BudgetName,PAB_SanctionedAmount,PAB_YetToRecieve,PAB_RecievedAmount,PAB_Commitment,PAB_Spent,PAB_Balance)VALUES({0});";
                                     

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
		
		DECLARE  @TBL_9A0E40951BE844D497FB822ADA862E58 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [A_BudgetID] INT	, [A_OverallSantionedAmount] DECIMAL(18,2)	, [MG_AvailableAmount] DECIMAL(18,2)	, [A_BudgetClaimedAmount] DECIMAL(18,2)	, [A_BudgetName] VARCHAR(MAX)){0}INSERT INTO [9A0E4095-1BE8-44D4-97FB-822ADA862E58](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,A_BudgetID,A_OverallSantionedAmount,MG_AvailableAmount,A_BudgetClaimedAmount,A_BudgetName)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.A_BudgetID,TDT.A_OverallSantionedAmount,TDT.MG_AvailableAmount,TDT.A_BudgetClaimedAmount,TDT.A_BudgetName FROM @TBL_9A0E40951BE844D497FB822ADA862E58 TDT
							LEFT JOIN [9A0E4095-1BE8-44D4-97FB-822ADA862E58] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,A_BudgetID=TDT.A_BudgetID,A_OverallSantionedAmount=TDT.A_OverallSantionedAmount,MG_AvailableAmount=TDT.MG_AvailableAmount,A_BudgetClaimedAmount=TDT.A_BudgetClaimedAmount,A_BudgetName=TDT.A_BudgetName FROM @TBL_9A0E40951BE844D497FB822ADA862E58 TDT
							JOIN [9A0E4095-1BE8-44D4-97FB-822ADA862E58] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,A_BudgetID,A_OverallSantionedAmount,MG_AvailableAmount,A_BudgetClaimedAmount,A_BudgetName";

                                     tempInsertQuery=@"INSERT INTO @TBL_9A0E40951BE844D497FB822ADA862E58(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,A_BudgetID,A_OverallSantionedAmount,MG_AvailableAmount,A_BudgetClaimedAmount,A_BudgetName)VALUES({0});";
                                     

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
		
		DECLARE  @TBL_C2287754790E4853A5A764772676D00E AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [M_DocumentDetailsId] VARCHAR(MAX)	, [M_DocumentName] VARCHAR(MAX)	, [M_UploadDcoument] VARCHAR(36)){0}INSERT INTO [C2287754-790E-4853-A5A7-64772676D00E](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,M_DocumentDetailsId,M_DocumentName,M_UploadDcoument)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.M_DocumentDetailsId,TDT.M_DocumentName,TDT.M_UploadDcoument FROM @TBL_C2287754790E4853A5A764772676D00E TDT
							LEFT JOIN [C2287754-790E-4853-A5A7-64772676D00E] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,M_DocumentDetailsId=TDT.M_DocumentDetailsId,M_DocumentName=TDT.M_DocumentName,M_UploadDcoument=TDT.M_UploadDcoument FROM @TBL_C2287754790E4853A5A764772676D00E TDT
							JOIN [C2287754-790E-4853-A5A7-64772676D00E] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,M_DocumentDetailsId,M_DocumentName,M_UploadDcoument";

                                     tempInsertQuery=@"INSERT INTO @TBL_C2287754790E4853A5A764772676D00E(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,M_DocumentDetailsId,M_DocumentName,M_UploadDcoument)VALUES({0});";
                                     

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
		
		DECLARE  @TBL_8B4BCD219BD34278AA2C99F30B18BC32 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [UserName] VARCHAR(MAX)	, [ActivityName] VARCHAR(MAX)	, [Remarks] VARCHAR(MAX)	, [RemarksId] VARCHAR(MAX)	, [DateOfRemarks] DATETIME){0}INSERT INTO [8B4BCD21-9BD3-4278-AA2C-99F30B18BC32](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,UserName,ActivityName,Remarks,RemarksId,DateOfRemarks)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.UserName,TDT.ActivityName,TDT.Remarks,TDT.RemarksId,TDT.DateOfRemarks FROM @TBL_8B4BCD219BD34278AA2C99F30B18BC32 TDT
							LEFT JOIN [8B4BCD21-9BD3-4278-AA2C-99F30B18BC32] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,UserName=TDT.UserName,ActivityName=TDT.ActivityName,Remarks=TDT.Remarks,RemarksId=TDT.RemarksId,DateOfRemarks=TDT.DateOfRemarks FROM @TBL_8B4BCD219BD34278AA2C99F30B18BC32 TDT
							JOIN [8B4BCD21-9BD3-4278-AA2C-99F30B18BC32] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,UserName,ActivityName,Remarks,RemarksId,DateOfRemarks";

                                     tempInsertQuery=@"INSERT INTO @TBL_8B4BCD219BD34278AA2C99F30B18BC32(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,UserName,ActivityName,Remarks,RemarksId,DateOfRemarks)VALUES({0});";
                                     

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
                     
                                    case "97c72782-b716-b2cd-caba-bef246e1dab6":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_97c72782b716b2cdcababef246e1dab6 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [C_Stepfrom] VARCHAR(MAX)	, [C_StepTo] VARCHAR(MAX)	, [C_Comments] VARCHAR(MAX)	, [C_User] VARCHAR(MAX)	, [C_DateofComments] DATETIME){0}INSERT INTO [97c72782-b716-b2cd-caba-bef246e1dab6](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,C_Stepfrom,C_StepTo,C_Comments,C_User,C_DateofComments)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.C_Stepfrom,TDT.C_StepTo,TDT.C_Comments,TDT.C_User,TDT.C_DateofComments FROM @TBL_97c72782b716b2cdcababef246e1dab6 TDT
							LEFT JOIN [97c72782-b716-b2cd-caba-bef246e1dab6] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,C_Stepfrom=TDT.C_Stepfrom,C_StepTo=TDT.C_StepTo,C_Comments=TDT.C_Comments,C_User=TDT.C_User,C_DateofComments=TDT.C_DateofComments FROM @TBL_97c72782b716b2cdcababef246e1dab6 TDT
							JOIN [97c72782-b716-b2cd-caba-bef246e1dab6] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,C_Stepfrom,C_StepTo,C_Comments,C_User,C_DateofComments";

                                     tempInsertQuery=@"INSERT INTO @TBL_97c72782b716b2cdcababef246e1dab6(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,C_Stepfrom,C_StepTo,C_Comments,C_User,C_DateofComments)VALUES({0});";
                                     

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
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MG_R2_ReceiptsId=TDT.MG_R2_ReceiptsId,MG_R2_ReceiptSplitUpId=TDT.MG_R2_ReceiptSplitUpId,MG_R2_UpdatedBy=TDT.MG_R2_UpdatedBy,MG_R2_Amount=TDT.MG_R2_Amount,MG_R2_BudgetId=TDT.MG_R2_BudgetId,MG_R2_UpdatedOn=TDT.MG_R2_UpdatedOn FROM @TBL_249EF4459B494EF9804546BD1E6FF8ED TDT
							JOIN [249EF445-9B49-4EF9-8045-46BD1E6FF8ED] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

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
                     
                                    case "f4c435ef-658d-ea4b-3047-12782c9508ca":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_f4c435ef658dea4b304712782c9508ca AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [TD_ModeofJourney] VARCHAR(MAX)	, [TD_Departure] VARCHAR(MAX)	, [TD_DepartureDate] DATETIME	, [TD_Arrival] VARCHAR(MAX)	, [TD_ArrivalDate] DATETIME	, [TD_JourneyClass] VARCHAR(MAX)	, [TD_RoadKms] DECIMAL(18,2)	, [TD_Amount] DECIMAL(18,2)){0}INSERT INTO [f4c435ef-658d-ea4b-3047-12782c9508ca](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,TD_ModeofJourney,TD_Departure,TD_DepartureDate,TD_Arrival,TD_ArrivalDate,TD_JourneyClass,TD_RoadKms,TD_Amount)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.TD_ModeofJourney,TDT.TD_Departure,TDT.TD_DepartureDate,TDT.TD_Arrival,TDT.TD_ArrivalDate,TDT.TD_JourneyClass,TDT.TD_RoadKms,TDT.TD_Amount FROM @TBL_f4c435ef658dea4b304712782c9508ca TDT
							LEFT JOIN [f4c435ef-658d-ea4b-3047-12782c9508ca] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,TD_ModeofJourney=TDT.TD_ModeofJourney,TD_Departure=TDT.TD_Departure,TD_DepartureDate=TDT.TD_DepartureDate,TD_Arrival=TDT.TD_Arrival,TD_ArrivalDate=TDT.TD_ArrivalDate,TD_JourneyClass=TDT.TD_JourneyClass,TD_RoadKms=TDT.TD_RoadKms,TD_Amount=TDT.TD_Amount FROM @TBL_f4c435ef658dea4b304712782c9508ca TDT
							JOIN [f4c435ef-658d-ea4b-3047-12782c9508ca] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,TD_ModeofJourney,TD_Departure,TD_DepartureDate,TD_Arrival,TD_ArrivalDate,TD_JourneyClass,TD_RoadKms,TD_Amount";

                                     tempInsertQuery=@"INSERT INTO @TBL_f4c435ef658dea4b304712782c9508ca(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,TD_ModeofJourney,TD_Departure,TD_DepartureDate,TD_Arrival,TD_ArrivalDate,TD_JourneyClass,TD_RoadKms,TD_Amount)VALUES({0});";
                                     

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
                     
                                    case "5cd6b407-a9ef-5a80-b97f-443d95733731":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_5cd6b407a9ef5a80b97f443d95733731 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [ED_ExpentitureType] VARCHAR(MAX)	, [ED_FromDate] DATETIME	, [ED_ToDate] DATETIME	, [ED_Amount] DECIMAL(18,2)){0}INSERT INTO [5cd6b407-a9ef-5a80-b97f-443d95733731](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,ED_ExpentitureType,ED_FromDate,ED_ToDate,ED_Amount)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.ED_ExpentitureType,TDT.ED_FromDate,TDT.ED_ToDate,TDT.ED_Amount FROM @TBL_5cd6b407a9ef5a80b97f443d95733731 TDT
							LEFT JOIN [5cd6b407-a9ef-5a80-b97f-443d95733731] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,ED_ExpentitureType=TDT.ED_ExpentitureType,ED_FromDate=TDT.ED_FromDate,ED_ToDate=TDT.ED_ToDate,ED_Amount=TDT.ED_Amount FROM @TBL_5cd6b407a9ef5a80b97f443d95733731 TDT
							JOIN [5cd6b407-a9ef-5a80-b97f-443d95733731] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,ED_ExpentitureType,ED_FromDate,ED_ToDate,ED_Amount";

                                     tempInsertQuery=@"INSERT INTO @TBL_5cd6b407a9ef5a80b97f443d95733731(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,ED_ExpentitureType,ED_FromDate,ED_ToDate,ED_Amount)VALUES({0});";
                                     

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
                     
                                    case "c018d17a-c198-7da2-f9a8-6701c434c1c3":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_c018d17ac1987da2f9a86701c434c1c3 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [FD_Description] VARCHAR(MAX)	, [FD_FundType] VARCHAR(MAX)	, [FD_Amount] DECIMAL(18,2)){0}INSERT INTO [c018d17a-c198-7da2-f9a8-6701c434c1c3](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,FD_Description,FD_FundType,FD_Amount)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.FD_Description,TDT.FD_FundType,TDT.FD_Amount FROM @TBL_c018d17ac1987da2f9a86701c434c1c3 TDT
							LEFT JOIN [c018d17a-c198-7da2-f9a8-6701c434c1c3] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,FD_Description=TDT.FD_Description,FD_FundType=TDT.FD_FundType,FD_Amount=TDT.FD_Amount FROM @TBL_c018d17ac1987da2f9a86701c434c1c3 TDT
							JOIN [c018d17a-c198-7da2-f9a8-6701c434c1c3] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,FD_Description,FD_FundType,FD_Amount";

                                     tempInsertQuery=@"INSERT INTO @TBL_c018d17ac1987da2f9a86701c434c1c3(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,FD_Description,FD_FundType,FD_Amount)VALUES({0});";
                                     

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
                     
                                    case "CDCED39A-D76C-4204-9A70-C637DD092E54":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_CDCED39AD76C42049A70C637DD092E54 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_d2_TADetailsID] VARCHAR(MAX)	, [MG_d2_TravelAdvanceID] VARCHAR(MAX)	, [MG_d2_Departure] VARCHAR(MAX)	, [MG_d2_DepartureDate] DATETIME	, [MG_d2_DepartureTime] VARCHAR(MAX)	, [MG_d2_Arrival] VARCHAR(MAX)	, [MG_d2_ArrivalDate] DATETIME	, [MG_d2_ArrivalTime] VARCHAR(MAX)	, [MG_d2_ModeofJourney] VARCHAR(250)	, [MG_d2_JourneyClass] VARCHAR(250)	, [MG_d2_Road] INT	, [MG_d2_PNRNo] VARCHAR(MAX)	, [MG_d2_Amount] DECIMAL(18,2)	, [MG_d2_IsTravelRequest] INT	, [MG_d2_UpdatedBy] INT	, [MG_d2_UpdatedOn] DATETIME){0}INSERT INTO [CDCED39A-D76C-4204-9A70-C637DD092E54](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d2_TADetailsID,MG_d2_TravelAdvanceID,MG_d2_Departure,MG_d2_DepartureDate,MG_d2_DepartureTime,MG_d2_Arrival,MG_d2_ArrivalDate,MG_d2_ArrivalTime,MG_d2_ModeofJourney,MG_d2_JourneyClass,MG_d2_Road,MG_d2_PNRNo,MG_d2_Amount,MG_d2_IsTravelRequest,MG_d2_UpdatedBy,MG_d2_UpdatedOn)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_d2_TADetailsID,TDT.MG_d2_TravelAdvanceID,TDT.MG_d2_Departure,TDT.MG_d2_DepartureDate,TDT.MG_d2_DepartureTime,TDT.MG_d2_Arrival,TDT.MG_d2_ArrivalDate,TDT.MG_d2_ArrivalTime,TDT.MG_d2_ModeofJourney,TDT.MG_d2_JourneyClass,TDT.MG_d2_Road,TDT.MG_d2_PNRNo,TDT.MG_d2_Amount,TDT.MG_d2_IsTravelRequest,TDT.MG_d2_UpdatedBy,TDT.MG_d2_UpdatedOn FROM @TBL_CDCED39AD76C42049A70C637DD092E54 TDT
							LEFT JOIN [CDCED39A-D76C-4204-9A70-C637DD092E54] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MG_d2_TADetailsID=TDT.MG_d2_TADetailsID,MG_d2_TravelAdvanceID=TDT.MG_d2_TravelAdvanceID,MG_d2_Departure=TDT.MG_d2_Departure,MG_d2_DepartureDate=TDT.MG_d2_DepartureDate,MG_d2_DepartureTime=TDT.MG_d2_DepartureTime,MG_d2_Arrival=TDT.MG_d2_Arrival,MG_d2_ArrivalDate=TDT.MG_d2_ArrivalDate,MG_d2_ArrivalTime=TDT.MG_d2_ArrivalTime,MG_d2_ModeofJourney=TDT.MG_d2_ModeofJourney,MG_d2_JourneyClass=TDT.MG_d2_JourneyClass,MG_d2_Road=TDT.MG_d2_Road,MG_d2_PNRNo=TDT.MG_d2_PNRNo,MG_d2_Amount=TDT.MG_d2_Amount,MG_d2_IsTravelRequest=TDT.MG_d2_IsTravelRequest,MG_d2_UpdatedBy=TDT.MG_d2_UpdatedBy,MG_d2_UpdatedOn=TDT.MG_d2_UpdatedOn FROM @TBL_CDCED39AD76C42049A70C637DD092E54 TDT
							JOIN [CDCED39A-D76C-4204-9A70-C637DD092E54] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d2_TADetailsID,MG_d2_TravelAdvanceID,MG_d2_Departure,MG_d2_DepartureDate,MG_d2_DepartureTime,MG_d2_Arrival,MG_d2_ArrivalDate,MG_d2_ArrivalTime,MG_d2_ModeofJourney,MG_d2_JourneyClass,MG_d2_Road,MG_d2_PNRNo,MG_d2_Amount,MG_d2_IsTravelRequest,MG_d2_UpdatedBy,MG_d2_UpdatedOn";

                                     tempInsertQuery=@"INSERT INTO @TBL_CDCED39AD76C42049A70C637DD092E54(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d2_TADetailsID,MG_d2_TravelAdvanceID,MG_d2_Departure,MG_d2_DepartureDate,MG_d2_DepartureTime,MG_d2_Arrival,MG_d2_ArrivalDate,MG_d2_ArrivalTime,MG_d2_ModeofJourney,MG_d2_JourneyClass,MG_d2_Road,MG_d2_PNRNo,MG_d2_Amount,MG_d2_IsTravelRequest,MG_d2_UpdatedBy,MG_d2_UpdatedOn)VALUES({0});";
                                     

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
                     
                                    case "7DC7A3E8-9FDF-4C75-9F83-FEC89BA524E4":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_7DC7A3E89FDF4C759F83FEC89BA524E4 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_d3_ExpenditureTypeID] VARCHAR(MAX)	, [MG_d3_TravelAdvanceID] VARCHAR(MAX)	, [MG_d3_FromDate] DATETIME	, [MG_d3_ToDate] DATETIME	, [MG_d3_Amount] DECIMAL(18,2)	, [MG_d3_UpdatedBy] INT	, [MG_d3_UpdatedOn] DATETIME	, [MG_d3_ExpenditureType] VARCHAR(250)	, [MG_d3_OtherExpenditureType] VARCHAR(MAX)	, [MG_d3_IsTravelRequest] INT){0}INSERT INTO [7DC7A3E8-9FDF-4C75-9F83-FEC89BA524E4](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d3_ExpenditureTypeID,MG_d3_TravelAdvanceID,MG_d3_FromDate,MG_d3_ToDate,MG_d3_Amount,MG_d3_UpdatedBy,MG_d3_UpdatedOn,MG_d3_ExpenditureType,MG_d3_OtherExpenditureType,MG_d3_IsTravelRequest)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_d3_ExpenditureTypeID,TDT.MG_d3_TravelAdvanceID,TDT.MG_d3_FromDate,TDT.MG_d3_ToDate,TDT.MG_d3_Amount,TDT.MG_d3_UpdatedBy,TDT.MG_d3_UpdatedOn,TDT.MG_d3_ExpenditureType,TDT.MG_d3_OtherExpenditureType,TDT.MG_d3_IsTravelRequest FROM @TBL_7DC7A3E89FDF4C759F83FEC89BA524E4 TDT
							LEFT JOIN [7DC7A3E8-9FDF-4C75-9F83-FEC89BA524E4] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MG_d3_ExpenditureTypeID=TDT.MG_d3_ExpenditureTypeID,MG_d3_TravelAdvanceID=TDT.MG_d3_TravelAdvanceID,MG_d3_FromDate=TDT.MG_d3_FromDate,MG_d3_ToDate=TDT.MG_d3_ToDate,MG_d3_Amount=TDT.MG_d3_Amount,MG_d3_UpdatedBy=TDT.MG_d3_UpdatedBy,MG_d3_UpdatedOn=TDT.MG_d3_UpdatedOn,MG_d3_ExpenditureType=TDT.MG_d3_ExpenditureType,MG_d3_OtherExpenditureType=TDT.MG_d3_OtherExpenditureType,MG_d3_IsTravelRequest=TDT.MG_d3_IsTravelRequest FROM @TBL_7DC7A3E89FDF4C759F83FEC89BA524E4 TDT
							JOIN [7DC7A3E8-9FDF-4C75-9F83-FEC89BA524E4] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d3_ExpenditureTypeID,MG_d3_TravelAdvanceID,MG_d3_FromDate,MG_d3_ToDate,MG_d3_Amount,MG_d3_UpdatedBy,MG_d3_UpdatedOn,MG_d3_ExpenditureType,MG_d3_OtherExpenditureType,MG_d3_IsTravelRequest";

                                     tempInsertQuery=@"INSERT INTO @TBL_7DC7A3E89FDF4C759F83FEC89BA524E4(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d3_ExpenditureTypeID,MG_d3_TravelAdvanceID,MG_d3_FromDate,MG_d3_ToDate,MG_d3_Amount,MG_d3_UpdatedBy,MG_d3_UpdatedOn,MG_d3_ExpenditureType,MG_d3_OtherExpenditureType,MG_d3_IsTravelRequest)VALUES({0});";
                                     

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
                     
                                    case "57484F68-026D-4FF5-A5E1-E4E0BDDD76E0":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_57484F68026D4FF5A5E1E4E0BDDD76E0 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [PFA_FundType] VARCHAR(MAX)	, [PFA_FundTypeValue] VARCHAR(MAX)	, [PFA_ProjectNo] VARCHAR(MAX)	, [PFA_ProjectNoValue] VARCHAR(MAX)	, [PFA_BudgetHead] VARCHAR(MAX)	, [PFA_BudgetHeadValue] VARCHAR(MAX)	, [PFA_Amount] DECIMAL(18,2)	, [PFA_FundDetailsId] VARCHAR(MAX)){0}INSERT INTO [57484F68-026D-4FF5-A5E1-E4E0BDDD76E0](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PFA_FundType,PFA_FundTypeValue,PFA_ProjectNo,PFA_ProjectNoValue,PFA_BudgetHead,PFA_BudgetHeadValue,PFA_Amount,PFA_FundDetailsId)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.PFA_FundType,TDT.PFA_FundTypeValue,TDT.PFA_ProjectNo,TDT.PFA_ProjectNoValue,TDT.PFA_BudgetHead,TDT.PFA_BudgetHeadValue,TDT.PFA_Amount,TDT.PFA_FundDetailsId FROM @TBL_57484F68026D4FF5A5E1E4E0BDDD76E0 TDT
							LEFT JOIN [57484F68-026D-4FF5-A5E1-E4E0BDDD76E0] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,PFA_FundType=TDT.PFA_FundType,PFA_FundTypeValue=TDT.PFA_FundTypeValue,PFA_ProjectNo=TDT.PFA_ProjectNo,PFA_ProjectNoValue=TDT.PFA_ProjectNoValue,PFA_BudgetHead=TDT.PFA_BudgetHead,PFA_BudgetHeadValue=TDT.PFA_BudgetHeadValue,PFA_Amount=TDT.PFA_Amount,PFA_FundDetailsId=TDT.PFA_FundDetailsId FROM @TBL_57484F68026D4FF5A5E1E4E0BDDD76E0 TDT
							JOIN [57484F68-026D-4FF5-A5E1-E4E0BDDD76E0] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PFA_FundType,PFA_FundTypeValue,PFA_ProjectNo,PFA_ProjectNoValue,PFA_BudgetHead,PFA_BudgetHeadValue,PFA_Amount,PFA_FundDetailsId";

                                     tempInsertQuery=@"INSERT INTO @TBL_57484F68026D4FF5A5E1E4E0BDDD76E0(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PFA_FundType,PFA_FundTypeValue,PFA_ProjectNo,PFA_ProjectNoValue,PFA_BudgetHead,PFA_BudgetHeadValue,PFA_Amount,PFA_FundDetailsId)VALUES({0});";
                                     

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
                     
                                    case "4435EA72-034D-4A84-8791-1F4DC99EADC1":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_4435EA72034D4A8487911F4DC99EADC1 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [PAB_BudgetName] VARCHAR(MAX)	, [PAB_SanctionedAmount] DECIMAL(18,2)	, [PAB_YetToRecieve] DECIMAL(18,2)	, [PAB_RecievedAmount] DECIMAL(18,2)	, [PAB_Commitment] DECIMAL(18,2)	, [PAB_Spent] DECIMAL(18,2)	, [PAB_Balance] DECIMAL(18,2)){0}INSERT INTO [4435EA72-034D-4A84-8791-1F4DC99EADC1](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PAB_BudgetName,PAB_SanctionedAmount,PAB_YetToRecieve,PAB_RecievedAmount,PAB_Commitment,PAB_Spent,PAB_Balance)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.PAB_BudgetName,TDT.PAB_SanctionedAmount,TDT.PAB_YetToRecieve,TDT.PAB_RecievedAmount,TDT.PAB_Commitment,TDT.PAB_Spent,TDT.PAB_Balance FROM @TBL_4435EA72034D4A8487911F4DC99EADC1 TDT
							LEFT JOIN [4435EA72-034D-4A84-8791-1F4DC99EADC1] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,PAB_BudgetName=TDT.PAB_BudgetName,PAB_SanctionedAmount=TDT.PAB_SanctionedAmount,PAB_YetToRecieve=TDT.PAB_YetToRecieve,PAB_RecievedAmount=TDT.PAB_RecievedAmount,PAB_Commitment=TDT.PAB_Commitment,PAB_Spent=TDT.PAB_Spent,PAB_Balance=TDT.PAB_Balance FROM @TBL_4435EA72034D4A8487911F4DC99EADC1 TDT
							JOIN [4435EA72-034D-4A84-8791-1F4DC99EADC1] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PAB_BudgetName,PAB_SanctionedAmount,PAB_YetToRecieve,PAB_RecievedAmount,PAB_Commitment,PAB_Spent,PAB_Balance";

                                     tempInsertQuery=@"INSERT INTO @TBL_4435EA72034D4A8487911F4DC99EADC1(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PAB_BudgetName,PAB_SanctionedAmount,PAB_YetToRecieve,PAB_RecievedAmount,PAB_Commitment,PAB_Spent,PAB_Balance)VALUES({0});";
                                     

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
                     
                                    case "4BBC0C1F-5883-4AAD-A2A7-BF4551B3555E":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_4BBC0C1F58834AADA2A7BF4551B3555E AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [PADD_DocumentName] VARCHAR(MAX)	, [PADD_Document] VARCHAR(MAX)){0}INSERT INTO [4BBC0C1F-5883-4AAD-A2A7-BF4551B3555E](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PADD_DocumentName,PADD_Document)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.PADD_DocumentName,TDT.PADD_Document FROM @TBL_4BBC0C1F58834AADA2A7BF4551B3555E TDT
							LEFT JOIN [4BBC0C1F-5883-4AAD-A2A7-BF4551B3555E] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,PADD_DocumentName=TDT.PADD_DocumentName,PADD_Document=TDT.PADD_Document FROM @TBL_4BBC0C1F58834AADA2A7BF4551B3555E TDT
							JOIN [4BBC0C1F-5883-4AAD-A2A7-BF4551B3555E] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PADD_DocumentName,PADD_Document";

                                     tempInsertQuery=@"INSERT INTO @TBL_4BBC0C1F58834AADA2A7BF4551B3555E(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PADD_DocumentName,PADD_Document)VALUES({0});";
                                     

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
                     
                                    case "EF8F97B1-41F1-43F5-91EF-FE1E3EBBE2AC":
                    {
                     
                                     gInsertQuery=@"
		
		DECLARE  @TBL_EF8F97B141F143F591EFFE1E3EBBE2AC AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [WMC_StepFrom] VARCHAR(MAX)	, [WMC_StepTo] VARCHAR(MAX)	, [WMC_Comments] VARCHAR(MAX)	, [WMC_User] VARCHAR(MAX)	, [WMC_DateofComments] DATETIME){0}INSERT INTO [EF8F97B1-41F1-43F5-91EF-FE1E3EBBE2AC](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,WMC_StepFrom,WMC_StepTo,WMC_Comments,WMC_User,WMC_DateofComments)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.WMC_StepFrom,TDT.WMC_StepTo,TDT.WMC_Comments,TDT.WMC_User,TDT.WMC_DateofComments FROM @TBL_EF8F97B141F143F591EFFE1E3EBBE2AC TDT
							LEFT JOIN [EF8F97B1-41F1-43F5-91EF-FE1E3EBBE2AC] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,WMC_StepFrom=TDT.WMC_StepFrom,WMC_StepTo=TDT.WMC_StepTo,WMC_Comments=TDT.WMC_Comments,WMC_User=TDT.WMC_User,WMC_DateofComments=TDT.WMC_DateofComments FROM @TBL_EF8F97B141F143F591EFFE1E3EBBE2AC TDT
							JOIN [EF8F97B1-41F1-43F5-91EF-FE1E3EBBE2AC] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                                     colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,WMC_StepFrom,WMC_StepTo,WMC_Comments,WMC_User,WMC_DateofComments";

                                     tempInsertQuery=@"INSERT INTO @TBL_EF8F97B141F143F591EFFE1E3EBBE2AC(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,WMC_StepFrom,WMC_StepTo,WMC_Comments,WMC_User,WMC_DateofComments)VALUES({0});";
                                     

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

       public bool GetGridLoopData(string query, out DataTable queryResult)
        {
            _sysLog.Debug("Entering HasRows");

            queryResult = null;

            IDataReader dataReader = null;
           
            try
            {
                
                var database =  GetDatabaseInstance();

                using(var command=database.GetSqlStringCommand(query))
                {

                    dataReader = database.ExecuteReader(command);

                    if(dataReader != null)
                    {
                        queryResult = ToDataTable(dataReader);
                    }


                    if (queryResult.Rows.Count > 0)
                        return true;
                    else
                        return false;

                }
            }
            catch (Exception ex)
            {
                _sysLog.Error("Error in HasRows", ex);

                return false;
            }
            finally
            {
                _sysLog.Debug("Exiting HasRows");
            }
        }


        private DataTable ToDataTable(IDataReader reader)
        {
            var table = new DataTable();

            for (int i = 0; i < reader.FieldCount; i++)
            {
                table.Columns.Add(
                    reader.GetName(i),
                    reader.GetFieldType(i));
            }

            while (reader.Read())
            {
                var values = new object[reader.FieldCount];
                reader.GetValues(values);
                table.Rows.Add(values);
            }

            return table;
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


                                         case "98F402C4-A592-451F-B29E-2F28BE67530B":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_98F402C4A592451FB29E2F28BE67530B AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [RD_RefNo] VARCHAR(MAX)	, [RD_ReceiptDate] DATETIME	, [RD_ReceiptAmount] DECIMAL(18,2)	, [RD_RefId] VARCHAR(MAX)	, [RD_Status] VARCHAR(MAX)){0}INSERT INTO [98F402C4-A592-451F-B29E-2F28BE67530B](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,RD_RefNo,RD_ReceiptDate,RD_ReceiptAmount,RD_RefId,RD_Status)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.RD_RefNo,TDT.RD_ReceiptDate,TDT.RD_ReceiptAmount,TDT.RD_RefId,TDT.RD_Status FROM @TBL_98F402C4A592451FB29E2F28BE67530B TDT
							LEFT JOIN [98F402C4-A592-451F-B29E-2F28BE67530B] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,RD_RefNo=TDT.RD_RefNo,RD_ReceiptDate=TDT.RD_ReceiptDate,RD_ReceiptAmount=TDT.RD_ReceiptAmount,RD_RefId=TDT.RD_RefId,RD_Status=TDT.RD_Status FROM @TBL_98F402C4A592451FB29E2F28BE67530B TDT
							JOIN [98F402C4-A592-451F-B29E-2F28BE67530B] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,RD_RefNo,RD_ReceiptDate,RD_ReceiptAmount,RD_RefId,RD_Status";

                            tempInsertQuery=@"INSERT INTO @TBL_98F402C4A592451FB29E2F28BE67530B(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,RD_RefNo,RD_ReceiptDate,RD_ReceiptAmount,RD_RefId,RD_Status)VALUES({0});";

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

                                              case "BDF7896C-4676-4008-BC64-2C45896293B5":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_BDF7896C46764008BC642C45896293B5 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MGG_V1_ProjectDetailsID] VARCHAR(MAX)	, [MGG_V1_ProjectNo] VARCHAR(MAX)	, [MGG_V1_Department] VARCHAR(MAX)	, [MGG_V1_PI] VARCHAR(MAX)	, [MGG_V1_CoPI] VARCHAR(MAX)	, [MGG_V1_ProjectType] VARCHAR(MAX)	, [MGG_V1_Agency] VARCHAR(MAX)	, [MGG_V1_StartDate] DATETIME	, [MGG_V1_EndDate] DATETIME	, [MGG_V1_Duration] VARCHAR(MAX)	, [MGG_V1_FinancialYear] VARCHAR(MAX)	, [MGG_V1_SanctionedValue] DECIMAL(18,2)	, [MGG_V1_Type] VARCHAR(MAX)){0}INSERT INTO [BDF7896C-4676-4008-BC64-2C45896293B5](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MGG_V1_ProjectDetailsID,MGG_V1_ProjectNo,MGG_V1_Department,MGG_V1_PI,MGG_V1_CoPI,MGG_V1_ProjectType,MGG_V1_Agency,MGG_V1_StartDate,MGG_V1_EndDate,MGG_V1_Duration,MGG_V1_FinancialYear,MGG_V1_SanctionedValue,MGG_V1_Type)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MGG_V1_ProjectDetailsID,TDT.MGG_V1_ProjectNo,TDT.MGG_V1_Department,TDT.MGG_V1_PI,TDT.MGG_V1_CoPI,TDT.MGG_V1_ProjectType,TDT.MGG_V1_Agency,TDT.MGG_V1_StartDate,TDT.MGG_V1_EndDate,TDT.MGG_V1_Duration,TDT.MGG_V1_FinancialYear,TDT.MGG_V1_SanctionedValue,TDT.MGG_V1_Type FROM @TBL_BDF7896C46764008BC642C45896293B5 TDT
							LEFT JOIN [BDF7896C-4676-4008-BC64-2C45896293B5] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MGG_V1_ProjectDetailsID=TDT.MGG_V1_ProjectDetailsID,MGG_V1_ProjectNo=TDT.MGG_V1_ProjectNo,MGG_V1_Department=TDT.MGG_V1_Department,MGG_V1_PI=TDT.MGG_V1_PI,MGG_V1_CoPI=TDT.MGG_V1_CoPI,MGG_V1_ProjectType=TDT.MGG_V1_ProjectType,MGG_V1_Agency=TDT.MGG_V1_Agency,MGG_V1_StartDate=TDT.MGG_V1_StartDate,MGG_V1_EndDate=TDT.MGG_V1_EndDate,MGG_V1_Duration=TDT.MGG_V1_Duration,MGG_V1_FinancialYear=TDT.MGG_V1_FinancialYear,MGG_V1_SanctionedValue=TDT.MGG_V1_SanctionedValue,MGG_V1_Type=TDT.MGG_V1_Type FROM @TBL_BDF7896C46764008BC642C45896293B5 TDT
							JOIN [BDF7896C-4676-4008-BC64-2C45896293B5] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MGG_V1_ProjectDetailsID,MGG_V1_ProjectNo,MGG_V1_Department,MGG_V1_PI,MGG_V1_CoPI,MGG_V1_ProjectType,MGG_V1_Agency,MGG_V1_StartDate,MGG_V1_EndDate,MGG_V1_Duration,MGG_V1_FinancialYear,MGG_V1_SanctionedValue,MGG_V1_Type";

                            tempInsertQuery=@"INSERT INTO @TBL_BDF7896C46764008BC642C45896293B5(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MGG_V1_ProjectDetailsID,MGG_V1_ProjectNo,MGG_V1_Department,MGG_V1_PI,MGG_V1_CoPI,MGG_V1_ProjectType,MGG_V1_Agency,MGG_V1_StartDate,MGG_V1_EndDate,MGG_V1_Duration,MGG_V1_FinancialYear,MGG_V1_SanctionedValue,MGG_V1_Type)VALUES({0});";

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

                                              case "23d626be-34a2-1938-8ea1-8cb78d7f1be0":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_23d626be34a219388ea18cb78d7f1be0 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [PD_V1_ProjectDetailsID] VARCHAR(MAX)	, [PD_V1_ProjectNo] VARCHAR(MAX)	, [PD_V1_Department] VARCHAR(MAX)	, [PD_V1_PI] VARCHAR(MAX)	, [PD_V1_CoPI] VARCHAR(MAX)	, [PD_V1_ProjectType] VARCHAR(MAX)	, [PD_V1_Agency] VARCHAR(MAX)	, [PD_V1_FinancialYear] VARCHAR(MAX)	, [PD_V1_SanctionedValue] DECIMAL(18,2)	, [PD_V1_Type] VARCHAR(MAX)){0}INSERT INTO [23d626be-34a2-1938-8ea1-8cb78d7f1be0](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PD_V1_ProjectDetailsID,PD_V1_ProjectNo,PD_V1_Department,PD_V1_PI,PD_V1_CoPI,PD_V1_ProjectType,PD_V1_Agency,PD_V1_FinancialYear,PD_V1_SanctionedValue,PD_V1_Type)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.PD_V1_ProjectDetailsID,TDT.PD_V1_ProjectNo,TDT.PD_V1_Department,TDT.PD_V1_PI,TDT.PD_V1_CoPI,TDT.PD_V1_ProjectType,TDT.PD_V1_Agency,TDT.PD_V1_FinancialYear,TDT.PD_V1_SanctionedValue,TDT.PD_V1_Type FROM @TBL_23d626be34a219388ea18cb78d7f1be0 TDT
							LEFT JOIN [23d626be-34a2-1938-8ea1-8cb78d7f1be0] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,PD_V1_ProjectDetailsID=TDT.PD_V1_ProjectDetailsID,PD_V1_ProjectNo=TDT.PD_V1_ProjectNo,PD_V1_Department=TDT.PD_V1_Department,PD_V1_PI=TDT.PD_V1_PI,PD_V1_CoPI=TDT.PD_V1_CoPI,PD_V1_ProjectType=TDT.PD_V1_ProjectType,PD_V1_Agency=TDT.PD_V1_Agency,PD_V1_FinancialYear=TDT.PD_V1_FinancialYear,PD_V1_SanctionedValue=TDT.PD_V1_SanctionedValue,PD_V1_Type=TDT.PD_V1_Type FROM @TBL_23d626be34a219388ea18cb78d7f1be0 TDT
							JOIN [23d626be-34a2-1938-8ea1-8cb78d7f1be0] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PD_V1_ProjectDetailsID,PD_V1_ProjectNo,PD_V1_Department,PD_V1_PI,PD_V1_CoPI,PD_V1_ProjectType,PD_V1_Agency,PD_V1_FinancialYear,PD_V1_SanctionedValue,PD_V1_Type";

                            tempInsertQuery=@"INSERT INTO @TBL_23d626be34a219388ea18cb78d7f1be0(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PD_V1_ProjectDetailsID,PD_V1_ProjectNo,PD_V1_Department,PD_V1_PI,PD_V1_CoPI,PD_V1_ProjectType,PD_V1_Agency,PD_V1_FinancialYear,PD_V1_SanctionedValue,PD_V1_Type)VALUES({0});";

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

                                              case "0429d560-d100-3a28-bdfd-bd0143de5ba7":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_0429d560d1003a28bdfdbd0143de5ba7 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [PP_ProjectDetailsID] VARCHAR(MAX)	, [PP_ProjectNo] VARCHAR(MAX)	, [PP_Department] VARCHAR(MAX)	, [PP_PI] VARCHAR(MAX)	, [PP_CoPI] VARCHAR(MAX)	, [PP_ProjectType] VARCHAR(MAX)	, [PP_Agency] VARCHAR(MAX)	, [PP_FinancialYear] VARCHAR(MAX)	, [PP_SanctionedValue] DECIMAL(18,2)	, [PP_Type] VARCHAR(MAX)){0}INSERT INTO [0429d560-d100-3a28-bdfd-bd0143de5ba7](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PP_ProjectDetailsID,PP_ProjectNo,PP_Department,PP_PI,PP_CoPI,PP_ProjectType,PP_Agency,PP_FinancialYear,PP_SanctionedValue,PP_Type)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.PP_ProjectDetailsID,TDT.PP_ProjectNo,TDT.PP_Department,TDT.PP_PI,TDT.PP_CoPI,TDT.PP_ProjectType,TDT.PP_Agency,TDT.PP_FinancialYear,TDT.PP_SanctionedValue,TDT.PP_Type FROM @TBL_0429d560d1003a28bdfdbd0143de5ba7 TDT
							LEFT JOIN [0429d560-d100-3a28-bdfd-bd0143de5ba7] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,PP_ProjectDetailsID=TDT.PP_ProjectDetailsID,PP_ProjectNo=TDT.PP_ProjectNo,PP_Department=TDT.PP_Department,PP_PI=TDT.PP_PI,PP_CoPI=TDT.PP_CoPI,PP_ProjectType=TDT.PP_ProjectType,PP_Agency=TDT.PP_Agency,PP_FinancialYear=TDT.PP_FinancialYear,PP_SanctionedValue=TDT.PP_SanctionedValue,PP_Type=TDT.PP_Type FROM @TBL_0429d560d1003a28bdfdbd0143de5ba7 TDT
							JOIN [0429d560-d100-3a28-bdfd-bd0143de5ba7] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PP_ProjectDetailsID,PP_ProjectNo,PP_Department,PP_PI,PP_CoPI,PP_ProjectType,PP_Agency,PP_FinancialYear,PP_SanctionedValue,PP_Type";

                            tempInsertQuery=@"INSERT INTO @TBL_0429d560d1003a28bdfdbd0143de5ba7(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PP_ProjectDetailsID,PP_ProjectNo,PP_Department,PP_PI,PP_CoPI,PP_ProjectType,PP_Agency,PP_FinancialYear,PP_SanctionedValue,PP_Type)VALUES({0});";

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
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MG_d2_AdditionalID=TDT.MG_d2_AdditionalID,MG_d2_ProjectDetailsID=TDT.MG_d2_ProjectDetailsID,MG_d2_AdditionalType=TDT.MG_d2_AdditionalType,MG_d2_AdditionalName=TDT.MG_d2_AdditionalName,MG_d2_Departmentid=TDT.MG_d2_Departmentid,MG_d2_DesignationID=TDT.MG_d2_DesignationID,MG_d2_ExternalInstituteName=TDT.MG_d2_ExternalInstituteName,MG_d2_ExternalFacultyName=TDT.MG_d2_ExternalFacultyName,MG_d2_ExternalDesignation=TDT.MG_d2_ExternalDesignation,MG_d2_ExternalEmailId=TDT.MG_d2_ExternalEmailId,MG_d2_ExternalContactNo=TDT.MG_d2_ExternalContactNo,MG_d2_UpdatedBy=TDT.MG_d2_UpdatedBy,MG_d2_UpdatedOn=TDT.MG_d2_UpdatedOn,MG_d2_MemberType=TDT.MG_d2_MemberType,MG_EmployeeName=TDT.MG_EmployeeName,MG_EmployeeDepartment=TDT.MG_EmployeeDepartment,MG_AdditionalTypeValue=TDT.MG_AdditionalTypeValue,MG_MemberTypeValue=TDT.MG_MemberTypeValue FROM @TBL_FC9B8D2E9EE3436FAF08A774AF04D678 TDT
							JOIN [FC9B8D2E-9EE3-436F-AF08-A774AF04D678] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

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

                                              case "99ae5d17-b4b2-d238-11a3-a33c1b7f516b":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_99ae5d17b4b2d23811a3a33c1b7f516b AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [C_Stepfrom] VARCHAR(MAX)	, [C_StepTo] VARCHAR(MAX)	, [C_Comments] VARCHAR(MAX)	, [C_User] VARCHAR(MAX)	, [C_DateofComments] DATETIME){0}INSERT INTO [99ae5d17-b4b2-d238-11a3-a33c1b7f516b](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,C_Stepfrom,C_StepTo,C_Comments,C_User,C_DateofComments)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.C_Stepfrom,TDT.C_StepTo,TDT.C_Comments,TDT.C_User,TDT.C_DateofComments FROM @TBL_99ae5d17b4b2d23811a3a33c1b7f516b TDT
							LEFT JOIN [99ae5d17-b4b2-d238-11a3-a33c1b7f516b] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,C_Stepfrom=TDT.C_Stepfrom,C_StepTo=TDT.C_StepTo,C_Comments=TDT.C_Comments,C_User=TDT.C_User,C_DateofComments=TDT.C_DateofComments FROM @TBL_99ae5d17b4b2d23811a3a33c1b7f516b TDT
							JOIN [99ae5d17-b4b2-d238-11a3-a33c1b7f516b] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,C_Stepfrom,C_StepTo,C_Comments,C_User,C_DateofComments";

                            tempInsertQuery=@"INSERT INTO @TBL_99ae5d17b4b2d23811a3a33c1b7f516b(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,C_Stepfrom,C_StepTo,C_Comments,C_User,C_DateofComments)VALUES({0});";

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
		
		DECLARE  @TBL_D2D6E00AB6B74968BAAAEF3D20F2BAC5 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_d3_DocumentName] VARCHAR(MAX)	, [MG_d3_UpdatedOn] DATETIME	, [MG_d3_DocumentProposalID] VARCHAR(MAX)	, [MG_d3_UploadDocument] VARCHAR(36)	, [MG_d3_ProposalDocumentID] VARCHAR(MAX)	, [MG_d3_UpdatedBy] INT	, [MG_d3_ProjectproposalID] VARCHAR(MAX)	, [MG_d3_MandatoryCheck] INT){0}INSERT INTO [D2D6E00A-B6B7-4968-BAAA-EF3D20F2BAC5](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d3_DocumentName,MG_d3_UpdatedOn,MG_d3_DocumentProposalID,MG_d3_UploadDocument,MG_d3_ProposalDocumentID,MG_d3_UpdatedBy,MG_d3_ProjectproposalID,MG_d3_MandatoryCheck)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_d3_DocumentName,TDT.MG_d3_UpdatedOn,TDT.MG_d3_DocumentProposalID,TDT.MG_d3_UploadDocument,TDT.MG_d3_ProposalDocumentID,TDT.MG_d3_UpdatedBy,TDT.MG_d3_ProjectproposalID,TDT.MG_d3_MandatoryCheck FROM @TBL_D2D6E00AB6B74968BAAAEF3D20F2BAC5 TDT
							LEFT JOIN [D2D6E00A-B6B7-4968-BAAA-EF3D20F2BAC5] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MG_d3_DocumentName=TDT.MG_d3_DocumentName,MG_d3_UpdatedOn=TDT.MG_d3_UpdatedOn,MG_d3_DocumentProposalID=TDT.MG_d3_DocumentProposalID,MG_d3_UploadDocument=TDT.MG_d3_UploadDocument,MG_d3_ProposalDocumentID=TDT.MG_d3_ProposalDocumentID,MG_d3_UpdatedBy=TDT.MG_d3_UpdatedBy,MG_d3_ProjectproposalID=TDT.MG_d3_ProjectproposalID,MG_d3_MandatoryCheck=TDT.MG_d3_MandatoryCheck FROM @TBL_D2D6E00AB6B74968BAAAEF3D20F2BAC5 TDT
							JOIN [D2D6E00A-B6B7-4968-BAAA-EF3D20F2BAC5] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

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
		
		DECLARE  @TBL_A3BB21404053455893633BA1B526BD0A AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_d4_UpdatedBy] INT	, [MG_d4_DocumentId] VARCHAR(MAX)	, [MG_d4_UpdatedOn] DATETIME	, [MG_d4_ProjectproposalID] VARCHAR(MAX)	, [MG_d4_Document] VARCHAR(36)	, [MG_d4_DocumentName] VARCHAR(MAX)	, [MG_d4_Categorymapid] VARCHAR(MAX)){0}INSERT INTO [A3BB2140-4053-4558-9363-3BA1B526BD0A](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d4_UpdatedBy,MG_d4_DocumentId,MG_d4_UpdatedOn,MG_d4_ProjectproposalID,MG_d4_Document,MG_d4_DocumentName,MG_d4_Categorymapid)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_d4_UpdatedBy,TDT.MG_d4_DocumentId,TDT.MG_d4_UpdatedOn,TDT.MG_d4_ProjectproposalID,TDT.MG_d4_Document,TDT.MG_d4_DocumentName,TDT.MG_d4_Categorymapid FROM @TBL_A3BB21404053455893633BA1B526BD0A TDT
							LEFT JOIN [A3BB2140-4053-4558-9363-3BA1B526BD0A] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MG_d4_UpdatedBy=TDT.MG_d4_UpdatedBy,MG_d4_DocumentId=TDT.MG_d4_DocumentId,MG_d4_UpdatedOn=TDT.MG_d4_UpdatedOn,MG_d4_ProjectproposalID=TDT.MG_d4_ProjectproposalID,MG_d4_Document=TDT.MG_d4_Document,MG_d4_DocumentName=TDT.MG_d4_DocumentName,MG_d4_Categorymapid=TDT.MG_d4_Categorymapid FROM @TBL_A3BB21404053455893633BA1B526BD0A TDT
							JOIN [A3BB2140-4053-4558-9363-3BA1B526BD0A] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

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
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MG_BudgetName=TDT.MG_BudgetName,MG_Balance=TDT.MG_Balance,MG_ReceivedAmount=TDT.MG_ReceivedAmount,MG_Commitment=TDT.MG_Commitment,MG_Spent=TDT.MG_Spent,MG_YetToReceive=TDT.MG_YetToReceive,MG_SanctionedAmount=TDT.MG_SanctionedAmount FROM @TBL_9CC97541CC4E4D16A92F2FA4A6460E7B TDT
							JOIN [9CC97541-CC4E-4D16-A92F-2FA4A6460E7B] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

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
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MG_ProjectOrOtherId=TDT.MG_ProjectOrOtherId,MG_DistributionId=TDT.MG_DistributionId,MG_FundType=TDT.MG_FundType,MG_BudgetHeadId=TDT.MG_BudgetHeadId,MG_MaxPercentageUsage=TDT.MG_MaxPercentageUsage,MG_MaxAmount=TDT.MG_MaxAmount,MG_Description=TDT.MG_Description FROM @TBL_4f5082a39a94c0aef8470dd75437412a TDT
							JOIN [4f5082a3-9a94-c0ae-f847-0dd75437412a] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

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
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,combo=TDT.combo FROM @TBL_281a2415aef45ac1c31b4beaec59046b TDT
							JOIN [281a2415-aef4-5ac1-c31b-4beaec59046b] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

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
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MG_FundTypeName=TDT.MG_FundTypeName,MG_FundTypeId=TDT.MG_FundTypeId FROM @TBL_04FCD1601EC6471F97B01C6738875C87 TDT
							JOIN [04FCD160-1EC6-471F-97B0-1C6738875C87] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

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

                                              case "B73036BB-FE7D-4B0D-998A-985294F8FC5B":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_B73036BBFE7D4B0D998A985294F8FC5B AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_d28_RecurringValidation] INT	, [MG_d28_Reappropriation] DECIMAL(18,2)	, [MG_d28_BudgetID] VARCHAR(MAX)	, [MG_d28_BudgetAmount] DECIMAL(18,2)	, [MG_d28_Comments] VARCHAR(MAX)	, [MG_d28_RDOfficeComments] VARCHAR(MAX)	, [MG_d28_Justiifcation] VARCHAR(MAX)	, [MG_d28_JustiifcationbyHoD] VARCHAR(MAX)	, [MG_d28_Year1] DECIMAL(18,2)	, [MG_d28_Year2] DECIMAL(18,2)	, [MG_d28_Year3] DECIMAL(18,2)	, [MG_d28_Year4] DECIMAL(18,2)	, [MG_d28_Year5] DECIMAL(18,2)	, [MG_d28_Year6] DECIMAL(18,2)	, [MG_d28_Year7] DECIMAL(18,2)	, [MG_d28_Year8] DECIMAL(18,2)	, [MG_d28_Year9] DECIMAL(18,2)	, [MG_d28_Year10] DECIMAL(18,2)	, [MG_d28_Year11] DECIMAL(18,2)	, [MG_d28_Year12] DECIMAL(18,2)	, [MG_d28_BudgetHead] VARCHAR(MAX)	, [MG_d28_BudgetDetailsId] VARCHAR(MAX)){0}INSERT INTO [B73036BB-FE7D-4B0D-998A-985294F8FC5B](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d28_RecurringValidation,MG_d28_Reappropriation,MG_d28_BudgetID,MG_d28_BudgetAmount,MG_d28_Comments,MG_d28_RDOfficeComments,MG_d28_Justiifcation,MG_d28_JustiifcationbyHoD,MG_d28_Year1,MG_d28_Year2,MG_d28_Year3,MG_d28_Year4,MG_d28_Year5,MG_d28_Year6,MG_d28_Year7,MG_d28_Year8,MG_d28_Year9,MG_d28_Year10,MG_d28_Year11,MG_d28_Year12,MG_d28_BudgetHead,MG_d28_BudgetDetailsId)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_d28_RecurringValidation,TDT.MG_d28_Reappropriation,TDT.MG_d28_BudgetID,TDT.MG_d28_BudgetAmount,TDT.MG_d28_Comments,TDT.MG_d28_RDOfficeComments,TDT.MG_d28_Justiifcation,TDT.MG_d28_JustiifcationbyHoD,TDT.MG_d28_Year1,TDT.MG_d28_Year2,TDT.MG_d28_Year3,TDT.MG_d28_Year4,TDT.MG_d28_Year5,TDT.MG_d28_Year6,TDT.MG_d28_Year7,TDT.MG_d28_Year8,TDT.MG_d28_Year9,TDT.MG_d28_Year10,TDT.MG_d28_Year11,TDT.MG_d28_Year12,TDT.MG_d28_BudgetHead,TDT.MG_d28_BudgetDetailsId FROM @TBL_B73036BBFE7D4B0D998A985294F8FC5B TDT
							LEFT JOIN [B73036BB-FE7D-4B0D-998A-985294F8FC5B] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MG_d28_RecurringValidation=TDT.MG_d28_RecurringValidation,MG_d28_Reappropriation=TDT.MG_d28_Reappropriation,MG_d28_BudgetID=TDT.MG_d28_BudgetID,MG_d28_BudgetAmount=TDT.MG_d28_BudgetAmount,MG_d28_Comments=TDT.MG_d28_Comments,MG_d28_RDOfficeComments=TDT.MG_d28_RDOfficeComments,MG_d28_Justiifcation=TDT.MG_d28_Justiifcation,MG_d28_JustiifcationbyHoD=TDT.MG_d28_JustiifcationbyHoD,MG_d28_Year1=TDT.MG_d28_Year1,MG_d28_Year2=TDT.MG_d28_Year2,MG_d28_Year3=TDT.MG_d28_Year3,MG_d28_Year4=TDT.MG_d28_Year4,MG_d28_Year5=TDT.MG_d28_Year5,MG_d28_Year6=TDT.MG_d28_Year6,MG_d28_Year7=TDT.MG_d28_Year7,MG_d28_Year8=TDT.MG_d28_Year8,MG_d28_Year9=TDT.MG_d28_Year9,MG_d28_Year10=TDT.MG_d28_Year10,MG_d28_Year11=TDT.MG_d28_Year11,MG_d28_Year12=TDT.MG_d28_Year12,MG_d28_BudgetHead=TDT.MG_d28_BudgetHead,MG_d28_BudgetDetailsId=TDT.MG_d28_BudgetDetailsId FROM @TBL_B73036BBFE7D4B0D998A985294F8FC5B TDT
							JOIN [B73036BB-FE7D-4B0D-998A-985294F8FC5B] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d28_RecurringValidation,MG_d28_Reappropriation,MG_d28_BudgetID,MG_d28_BudgetAmount,MG_d28_Comments,MG_d28_RDOfficeComments,MG_d28_Justiifcation,MG_d28_JustiifcationbyHoD,MG_d28_Year1,MG_d28_Year2,MG_d28_Year3,MG_d28_Year4,MG_d28_Year5,MG_d28_Year6,MG_d28_Year7,MG_d28_Year8,MG_d28_Year9,MG_d28_Year10,MG_d28_Year11,MG_d28_Year12,MG_d28_BudgetHead,MG_d28_BudgetDetailsId";

                            tempInsertQuery=@"INSERT INTO @TBL_B73036BBFE7D4B0D998A985294F8FC5B(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d28_RecurringValidation,MG_d28_Reappropriation,MG_d28_BudgetID,MG_d28_BudgetAmount,MG_d28_Comments,MG_d28_RDOfficeComments,MG_d28_Justiifcation,MG_d28_JustiifcationbyHoD,MG_d28_Year1,MG_d28_Year2,MG_d28_Year3,MG_d28_Year4,MG_d28_Year5,MG_d28_Year6,MG_d28_Year7,MG_d28_Year8,MG_d28_Year9,MG_d28_Year10,MG_d28_Year11,MG_d28_Year12,MG_d28_BudgetHead,MG_d28_BudgetDetailsId)VALUES({0});";

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
		
		DECLARE  @TBL_59259E21AFE84DABA54374CC22FC79D5 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_d55_Departmentid] VARCHAR(MAX)	, [MG_d55_AdditionalType] VARCHAR(MAX)	, [MG_d55_AdditionalName] VARCHAR(MAX)	, [MG_d55_ExternalInstituteName] VARCHAR(MAX)	, [MG_d55_ExternalFacultyName] VARCHAR(MAX)	, [MG_d55_DesignationID] VARCHAR(MAX)	, [MG_d55_ExternalDesignation] VARCHAR(MAX)	, [MG_d55_ExternalEmailId] VARCHAR(MAX)	, [MG_d55_ExternalContactNo] VARCHAR(MAX)){0}INSERT INTO [59259E21-AFE8-4DAB-A543-74CC22FC79D5](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d55_Departmentid,MG_d55_AdditionalType,MG_d55_AdditionalName,MG_d55_ExternalInstituteName,MG_d55_ExternalFacultyName,MG_d55_DesignationID,MG_d55_ExternalDesignation,MG_d55_ExternalEmailId,MG_d55_ExternalContactNo)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_d55_Departmentid,TDT.MG_d55_AdditionalType,TDT.MG_d55_AdditionalName,TDT.MG_d55_ExternalInstituteName,TDT.MG_d55_ExternalFacultyName,TDT.MG_d55_DesignationID,TDT.MG_d55_ExternalDesignation,TDT.MG_d55_ExternalEmailId,TDT.MG_d55_ExternalContactNo FROM @TBL_59259E21AFE84DABA54374CC22FC79D5 TDT
							LEFT JOIN [59259E21-AFE8-4DAB-A543-74CC22FC79D5] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MG_d55_Departmentid=TDT.MG_d55_Departmentid,MG_d55_AdditionalType=TDT.MG_d55_AdditionalType,MG_d55_AdditionalName=TDT.MG_d55_AdditionalName,MG_d55_ExternalInstituteName=TDT.MG_d55_ExternalInstituteName,MG_d55_ExternalFacultyName=TDT.MG_d55_ExternalFacultyName,MG_d55_DesignationID=TDT.MG_d55_DesignationID,MG_d55_ExternalDesignation=TDT.MG_d55_ExternalDesignation,MG_d55_ExternalEmailId=TDT.MG_d55_ExternalEmailId,MG_d55_ExternalContactNo=TDT.MG_d55_ExternalContactNo FROM @TBL_59259E21AFE84DABA54374CC22FC79D5 TDT
							JOIN [59259E21-AFE8-4DAB-A543-74CC22FC79D5] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

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
		
		DECLARE  @TBL_6677BAB3659A4A9690675D365F60CB62 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_d82_DocumentName] VARCHAR(MAX)	, [MG_d82_DocumentID] VARCHAR(36)){0}INSERT INTO [6677BAB3-659A-4A96-9067-5D365F60CB62](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d82_DocumentName,MG_d82_DocumentID)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_d82_DocumentName,TDT.MG_d82_DocumentID FROM @TBL_6677BAB3659A4A9690675D365F60CB62 TDT
							LEFT JOIN [6677BAB3-659A-4A96-9067-5D365F60CB62] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MG_d82_DocumentName=TDT.MG_d82_DocumentName,MG_d82_DocumentID=TDT.MG_d82_DocumentID FROM @TBL_6677BAB3659A4A9690675D365F60CB62 TDT
							JOIN [6677BAB3-659A-4A96-9067-5D365F60CB62] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

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
		
		DECLARE  @TBL_08F73C4A3B9443278859B98388D1C9CD AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_d109_SerialNo] INT	, [MG_d109_EquipmentName] VARCHAR(MAX)	, [MG_d109_Description] VARCHAR(MAX)	, [MG_d109_Quantity] INT	, [MG_d109_RateinINR] DECIMAL(18,2)	, [MG_d109_TotalEquipmentcost] DECIMAL(18,2)	, [MG_d109_EquipmentBudget] INT	, [MG_d109_OverallEquipmentcost] DECIMAL(18,2)){0}INSERT INTO [08F73C4A-3B94-4327-8859-B98388D1C9CD](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d109_SerialNo,MG_d109_EquipmentName,MG_d109_Description,MG_d109_Quantity,MG_d109_RateinINR,MG_d109_TotalEquipmentcost,MG_d109_EquipmentBudget,MG_d109_OverallEquipmentcost)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_d109_SerialNo,TDT.MG_d109_EquipmentName,TDT.MG_d109_Description,TDT.MG_d109_Quantity,TDT.MG_d109_RateinINR,TDT.MG_d109_TotalEquipmentcost,TDT.MG_d109_EquipmentBudget,TDT.MG_d109_OverallEquipmentcost FROM @TBL_08F73C4A3B9443278859B98388D1C9CD TDT
							LEFT JOIN [08F73C4A-3B94-4327-8859-B98388D1C9CD] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MG_d109_SerialNo=TDT.MG_d109_SerialNo,MG_d109_EquipmentName=TDT.MG_d109_EquipmentName,MG_d109_Description=TDT.MG_d109_Description,MG_d109_Quantity=TDT.MG_d109_Quantity,MG_d109_RateinINR=TDT.MG_d109_RateinINR,MG_d109_TotalEquipmentcost=TDT.MG_d109_TotalEquipmentcost,MG_d109_EquipmentBudget=TDT.MG_d109_EquipmentBudget,MG_d109_OverallEquipmentcost=TDT.MG_d109_OverallEquipmentcost FROM @TBL_08F73C4A3B9443278859B98388D1C9CD TDT
							JOIN [08F73C4A-3B94-4327-8859-B98388D1C9CD] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d109_SerialNo,MG_d109_EquipmentName,MG_d109_Description,MG_d109_Quantity,MG_d109_RateinINR,MG_d109_TotalEquipmentcost,MG_d109_EquipmentBudget,MG_d109_OverallEquipmentcost";

                            tempInsertQuery=@"INSERT INTO @TBL_08F73C4A3B9443278859B98388D1C9CD(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d109_SerialNo,MG_d109_EquipmentName,MG_d109_Description,MG_d109_Quantity,MG_d109_RateinINR,MG_d109_TotalEquipmentcost,MG_d109_EquipmentBudget,MG_d109_OverallEquipmentcost)VALUES({0});";

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
		
		DECLARE  @TBL_25683F52E21A4CE391967BCFA640A94B AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_d154_Duration] INT	, [MG_d154_SerialNo] INT	, [MG_d154_Comments] VARCHAR(MAX)	, [MG_d154_ManpowerPosition] VARCHAR(250)	, [MG_d154_No_OfManpowerPosition] DECIMAL(18,2)	, [MG_d154_RatePerMonth] DECIMAL(18,2)	, [MG_d154_HRAPercentage] DECIMAL(18,2)	, [MG_d154_HRAPerMonth] DECIMAL(18,2)	, [MG_d154_TotalPerMonth] DECIMAL(18,2)	, [MG_d154_TotalMonths] INT	, [MG_d154_TotalCost] DECIMAL(18,2)){0}INSERT INTO [25683F52-E21A-4CE3-9196-7BCFA640A94B](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d154_Duration,MG_d154_SerialNo,MG_d154_Comments,MG_d154_ManpowerPosition,MG_d154_No_OfManpowerPosition,MG_d154_RatePerMonth,MG_d154_HRAPercentage,MG_d154_HRAPerMonth,MG_d154_TotalPerMonth,MG_d154_TotalMonths,MG_d154_TotalCost)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_d154_Duration,TDT.MG_d154_SerialNo,TDT.MG_d154_Comments,TDT.MG_d154_ManpowerPosition,TDT.MG_d154_No_OfManpowerPosition,TDT.MG_d154_RatePerMonth,TDT.MG_d154_HRAPercentage,TDT.MG_d154_HRAPerMonth,TDT.MG_d154_TotalPerMonth,TDT.MG_d154_TotalMonths,TDT.MG_d154_TotalCost FROM @TBL_25683F52E21A4CE391967BCFA640A94B TDT
							LEFT JOIN [25683F52-E21A-4CE3-9196-7BCFA640A94B] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MG_d154_Duration=TDT.MG_d154_Duration,MG_d154_SerialNo=TDT.MG_d154_SerialNo,MG_d154_Comments=TDT.MG_d154_Comments,MG_d154_ManpowerPosition=TDT.MG_d154_ManpowerPosition,MG_d154_No_OfManpowerPosition=TDT.MG_d154_No_OfManpowerPosition,MG_d154_RatePerMonth=TDT.MG_d154_RatePerMonth,MG_d154_HRAPercentage=TDT.MG_d154_HRAPercentage,MG_d154_HRAPerMonth=TDT.MG_d154_HRAPerMonth,MG_d154_TotalPerMonth=TDT.MG_d154_TotalPerMonth,MG_d154_TotalMonths=TDT.MG_d154_TotalMonths,MG_d154_TotalCost=TDT.MG_d154_TotalCost FROM @TBL_25683F52E21A4CE391967BCFA640A94B TDT
							JOIN [25683F52-E21A-4CE3-9196-7BCFA640A94B] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

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

                                              case "f1825943-98b5-f54f-0225-0081ef436f94":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_f182594398b5f54f02250081ef436f94 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [C_Stepfrom] VARCHAR(MAX)	, [C_StepTo] VARCHAR(MAX)	, [C_Comments] VARCHAR(MAX)	, [C_User] VARCHAR(MAX)	, [C_DateofComments] DATETIME){0}INSERT INTO [f1825943-98b5-f54f-0225-0081ef436f94](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,C_Stepfrom,C_StepTo,C_Comments,C_User,C_DateofComments)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.C_Stepfrom,TDT.C_StepTo,TDT.C_Comments,TDT.C_User,TDT.C_DateofComments FROM @TBL_f182594398b5f54f02250081ef436f94 TDT
							LEFT JOIN [f1825943-98b5-f54f-0225-0081ef436f94] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,C_Stepfrom=TDT.C_Stepfrom,C_StepTo=TDT.C_StepTo,C_Comments=TDT.C_Comments,C_User=TDT.C_User,C_DateofComments=TDT.C_DateofComments FROM @TBL_f182594398b5f54f02250081ef436f94 TDT
							JOIN [f1825943-98b5-f54f-0225-0081ef436f94] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,C_Stepfrom,C_StepTo,C_Comments,C_User,C_DateofComments";

                            tempInsertQuery=@"INSERT INTO @TBL_f182594398b5f54f02250081ef436f94(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,C_Stepfrom,C_StepTo,C_Comments,C_User,C_DateofComments)VALUES({0});";

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

                                              case "98357E55-B276-4E6E-9A45-2588BF6CE0E4":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_98357E55B2764E6E9A452588BF6CE0E4 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_d2_ReimbursementDetailsId] VARCHAR(MAX)	, [MG_d2_ReimbursementId] VARCHAR(MAX)	, [MG_d2_BillNo] VARCHAR(MAX)	, [MG_d2_BillDate] DATETIME	, [MG_d2_BillDocument] INT	, [MG_d2_ItemDescription] VARCHAR(MAX)	, [MG_d2_Amount] DECIMAL(18,2)){0}INSERT INTO [98357E55-B276-4E6E-9A45-2588BF6CE0E4](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d2_ReimbursementDetailsId,MG_d2_ReimbursementId,MG_d2_BillNo,MG_d2_BillDate,MG_d2_BillDocument,MG_d2_ItemDescription,MG_d2_Amount)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_d2_ReimbursementDetailsId,TDT.MG_d2_ReimbursementId,TDT.MG_d2_BillNo,TDT.MG_d2_BillDate,TDT.MG_d2_BillDocument,TDT.MG_d2_ItemDescription,TDT.MG_d2_Amount FROM @TBL_98357E55B2764E6E9A452588BF6CE0E4 TDT
							LEFT JOIN [98357E55-B276-4E6E-9A45-2588BF6CE0E4] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MG_d2_ReimbursementDetailsId=TDT.MG_d2_ReimbursementDetailsId,MG_d2_ReimbursementId=TDT.MG_d2_ReimbursementId,MG_d2_BillNo=TDT.MG_d2_BillNo,MG_d2_BillDate=TDT.MG_d2_BillDate,MG_d2_BillDocument=TDT.MG_d2_BillDocument,MG_d2_ItemDescription=TDT.MG_d2_ItemDescription,MG_d2_Amount=TDT.MG_d2_Amount FROM @TBL_98357E55B2764E6E9A452588BF6CE0E4 TDT
							JOIN [98357E55-B276-4E6E-9A45-2588BF6CE0E4] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d2_ReimbursementDetailsId,MG_d2_ReimbursementId,MG_d2_BillNo,MG_d2_BillDate,MG_d2_BillDocument,MG_d2_ItemDescription,MG_d2_Amount";

                            tempInsertQuery=@"INSERT INTO @TBL_98357E55B2764E6E9A452588BF6CE0E4(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d2_ReimbursementDetailsId,MG_d2_ReimbursementId,MG_d2_BillNo,MG_d2_BillDate,MG_d2_BillDocument,MG_d2_ItemDescription,MG_d2_Amount)VALUES({0});";

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

                                              case "825B4680-DEA2-4E2E-861A-965DE912D14B":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_825B4680DEA24E2E861A965DE912D14B AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [PFA_FundType] VARCHAR(MAX)	, [PFA_FundTypeValue] VARCHAR(MAX)	, [PFA_ProjectNo] VARCHAR(MAX)	, [PFA_ProjectNoValue] VARCHAR(MAX)	, [PFA_BudgetHead] VARCHAR(MAX)	, [PFA_BudgetHeadValue] VARCHAR(MAX)	, [PFA_Amount] DECIMAL(18,2)	, [PFA_FundDetailsId] VARCHAR(MAX)){0}INSERT INTO [825B4680-DEA2-4E2E-861A-965DE912D14B](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PFA_FundType,PFA_FundTypeValue,PFA_ProjectNo,PFA_ProjectNoValue,PFA_BudgetHead,PFA_BudgetHeadValue,PFA_Amount,PFA_FundDetailsId)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.PFA_FundType,TDT.PFA_FundTypeValue,TDT.PFA_ProjectNo,TDT.PFA_ProjectNoValue,TDT.PFA_BudgetHead,TDT.PFA_BudgetHeadValue,TDT.PFA_Amount,TDT.PFA_FundDetailsId FROM @TBL_825B4680DEA24E2E861A965DE912D14B TDT
							LEFT JOIN [825B4680-DEA2-4E2E-861A-965DE912D14B] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,PFA_FundType=TDT.PFA_FundType,PFA_FundTypeValue=TDT.PFA_FundTypeValue,PFA_ProjectNo=TDT.PFA_ProjectNo,PFA_ProjectNoValue=TDT.PFA_ProjectNoValue,PFA_BudgetHead=TDT.PFA_BudgetHead,PFA_BudgetHeadValue=TDT.PFA_BudgetHeadValue,PFA_Amount=TDT.PFA_Amount,PFA_FundDetailsId=TDT.PFA_FundDetailsId FROM @TBL_825B4680DEA24E2E861A965DE912D14B TDT
							JOIN [825B4680-DEA2-4E2E-861A-965DE912D14B] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PFA_FundType,PFA_FundTypeValue,PFA_ProjectNo,PFA_ProjectNoValue,PFA_BudgetHead,PFA_BudgetHeadValue,PFA_Amount,PFA_FundDetailsId";

                            tempInsertQuery=@"INSERT INTO @TBL_825B4680DEA24E2E861A965DE912D14B(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PFA_FundType,PFA_FundTypeValue,PFA_ProjectNo,PFA_ProjectNoValue,PFA_BudgetHead,PFA_BudgetHeadValue,PFA_Amount,PFA_FundDetailsId)VALUES({0});";

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

                                              case "6B7A35BC-59EB-4CFB-8FBF-ADB3E8BC39C6":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_6B7A35BC59EB4CFB8FBFADB3E8BC39C6 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [PAB_BudgetName] VARCHAR(MAX)	, [PAB_SanctionedAmount] DECIMAL(18,2)	, [PAB_YetToRecieve] DECIMAL(18,2)	, [PAB_RecievedAmount] DECIMAL(18,2)	, [PAB_Commitment] DECIMAL(18,2)	, [PAB_Spent] DECIMAL(18,2)	, [PAB_Balance] DECIMAL(18,2)){0}INSERT INTO [6B7A35BC-59EB-4CFB-8FBF-ADB3E8BC39C6](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PAB_BudgetName,PAB_SanctionedAmount,PAB_YetToRecieve,PAB_RecievedAmount,PAB_Commitment,PAB_Spent,PAB_Balance)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.PAB_BudgetName,TDT.PAB_SanctionedAmount,TDT.PAB_YetToRecieve,TDT.PAB_RecievedAmount,TDT.PAB_Commitment,TDT.PAB_Spent,TDT.PAB_Balance FROM @TBL_6B7A35BC59EB4CFB8FBFADB3E8BC39C6 TDT
							LEFT JOIN [6B7A35BC-59EB-4CFB-8FBF-ADB3E8BC39C6] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,PAB_BudgetName=TDT.PAB_BudgetName,PAB_SanctionedAmount=TDT.PAB_SanctionedAmount,PAB_YetToRecieve=TDT.PAB_YetToRecieve,PAB_RecievedAmount=TDT.PAB_RecievedAmount,PAB_Commitment=TDT.PAB_Commitment,PAB_Spent=TDT.PAB_Spent,PAB_Balance=TDT.PAB_Balance FROM @TBL_6B7A35BC59EB4CFB8FBFADB3E8BC39C6 TDT
							JOIN [6B7A35BC-59EB-4CFB-8FBF-ADB3E8BC39C6] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PAB_BudgetName,PAB_SanctionedAmount,PAB_YetToRecieve,PAB_RecievedAmount,PAB_Commitment,PAB_Spent,PAB_Balance";

                            tempInsertQuery=@"INSERT INTO @TBL_6B7A35BC59EB4CFB8FBFADB3E8BC39C6(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PAB_BudgetName,PAB_SanctionedAmount,PAB_YetToRecieve,PAB_RecievedAmount,PAB_Commitment,PAB_Spent,PAB_Balance)VALUES({0});";

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

                                              case "95D6FCFD-4B36-4E23-B424-43AB84B1680B":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_95D6FCFD4B364E23B42443AB84B1680B AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [PADD_DocumentName] VARCHAR(MAX)	, [PADD_Document] VARCHAR(MAX)){0}INSERT INTO [95D6FCFD-4B36-4E23-B424-43AB84B1680B](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PADD_DocumentName,PADD_Document)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.PADD_DocumentName,TDT.PADD_Document FROM @TBL_95D6FCFD4B364E23B42443AB84B1680B TDT
							LEFT JOIN [95D6FCFD-4B36-4E23-B424-43AB84B1680B] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,PADD_DocumentName=TDT.PADD_DocumentName,PADD_Document=TDT.PADD_Document FROM @TBL_95D6FCFD4B364E23B42443AB84B1680B TDT
							JOIN [95D6FCFD-4B36-4E23-B424-43AB84B1680B] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PADD_DocumentName,PADD_Document";

                            tempInsertQuery=@"INSERT INTO @TBL_95D6FCFD4B364E23B42443AB84B1680B(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PADD_DocumentName,PADD_Document)VALUES({0});";

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

                                              case "8F47B89A-AF4A-4A73-BE87-44CF1EBCC456":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_8F47B89AAF4A4A73BE8744CF1EBCC456 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [WMC_StepFrom] VARCHAR(MAX)	, [WMC_StepTo] VARCHAR(MAX)	, [WMC_Comments] VARCHAR(MAX)	, [WMC_User] VARCHAR(MAX)	, [WMC_DateofComments] DATETIME){0}INSERT INTO [8F47B89A-AF4A-4A73-BE87-44CF1EBCC456](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,WMC_StepFrom,WMC_StepTo,WMC_Comments,WMC_User,WMC_DateofComments)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.WMC_StepFrom,TDT.WMC_StepTo,TDT.WMC_Comments,TDT.WMC_User,TDT.WMC_DateofComments FROM @TBL_8F47B89AAF4A4A73BE8744CF1EBCC456 TDT
							LEFT JOIN [8F47B89A-AF4A-4A73-BE87-44CF1EBCC456] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,WMC_StepFrom=TDT.WMC_StepFrom,WMC_StepTo=TDT.WMC_StepTo,WMC_Comments=TDT.WMC_Comments,WMC_User=TDT.WMC_User,WMC_DateofComments=TDT.WMC_DateofComments FROM @TBL_8F47B89AAF4A4A73BE8744CF1EBCC456 TDT
							JOIN [8F47B89A-AF4A-4A73-BE87-44CF1EBCC456] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,WMC_StepFrom,WMC_StepTo,WMC_Comments,WMC_User,WMC_DateofComments";

                            tempInsertQuery=@"INSERT INTO @TBL_8F47B89AAF4A4A73BE8744CF1EBCC456(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,WMC_StepFrom,WMC_StepTo,WMC_Comments,WMC_User,WMC_DateofComments)VALUES({0});";

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

                                              case "1478D76F-6E75-4C46-A32B-BB50FE153540":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_1478D76F6E754C46A32BBB50FE153540 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [WMC_StepFrom] VARCHAR(MAX)	, [WMC_StepTo] VARCHAR(MAX)	, [WMC_Comments] VARCHAR(MAX)	, [WMC_User] VARCHAR(MAX)	, [WMC_DateofComments] DATETIME){0}INSERT INTO [1478D76F-6E75-4C46-A32B-BB50FE153540](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,WMC_StepFrom,WMC_StepTo,WMC_Comments,WMC_User,WMC_DateofComments)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.WMC_StepFrom,TDT.WMC_StepTo,TDT.WMC_Comments,TDT.WMC_User,TDT.WMC_DateofComments FROM @TBL_1478D76F6E754C46A32BBB50FE153540 TDT
							LEFT JOIN [1478D76F-6E75-4C46-A32B-BB50FE153540] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,WMC_StepFrom=TDT.WMC_StepFrom,WMC_StepTo=TDT.WMC_StepTo,WMC_Comments=TDT.WMC_Comments,WMC_User=TDT.WMC_User,WMC_DateofComments=TDT.WMC_DateofComments FROM @TBL_1478D76F6E754C46A32BBB50FE153540 TDT
							JOIN [1478D76F-6E75-4C46-A32B-BB50FE153540] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,WMC_StepFrom,WMC_StepTo,WMC_Comments,WMC_User,WMC_DateofComments";

                            tempInsertQuery=@"INSERT INTO @TBL_1478D76F6E754C46A32BBB50FE153540(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,WMC_StepFrom,WMC_StepTo,WMC_Comments,WMC_User,WMC_DateofComments)VALUES({0});";

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

                                              case "36296F3B-23C7-4F14-BC64-C4E49DB8C854":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_36296F3B23C74F14BC64C4E49DB8C854 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [PADD_DocumentName] VARCHAR(MAX)	, [PADD_Document] VARCHAR(MAX)){0}INSERT INTO [36296F3B-23C7-4F14-BC64-C4E49DB8C854](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PADD_DocumentName,PADD_Document)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.PADD_DocumentName,TDT.PADD_Document FROM @TBL_36296F3B23C74F14BC64C4E49DB8C854 TDT
							LEFT JOIN [36296F3B-23C7-4F14-BC64-C4E49DB8C854] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,PADD_DocumentName=TDT.PADD_DocumentName,PADD_Document=TDT.PADD_Document FROM @TBL_36296F3B23C74F14BC64C4E49DB8C854 TDT
							JOIN [36296F3B-23C7-4F14-BC64-C4E49DB8C854] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PADD_DocumentName,PADD_Document";

                            tempInsertQuery=@"INSERT INTO @TBL_36296F3B23C74F14BC64C4E49DB8C854(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PADD_DocumentName,PADD_Document)VALUES({0});";

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

                                              case "0337B98B-59FA-46DC-87A0-89AA288D41AC":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_0337B98B59FA46DC87A089AA288D41AC AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_d1_RequestDetailsId] VARCHAR(MAX)	, [MG_d1_AdvanceFormId] VARCHAR(MAX)	, [MG_d1_ExpenseDetails] VARCHAR(MAX)	, [MG_d1_ItemDescription] VARCHAR(MAX)	, [MG_d1_Amount] DECIMAL(18,2)){0}INSERT INTO [0337B98B-59FA-46DC-87A0-89AA288D41AC](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d1_RequestDetailsId,MG_d1_AdvanceFormId,MG_d1_ExpenseDetails,MG_d1_ItemDescription,MG_d1_Amount)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_d1_RequestDetailsId,TDT.MG_d1_AdvanceFormId,TDT.MG_d1_ExpenseDetails,TDT.MG_d1_ItemDescription,TDT.MG_d1_Amount FROM @TBL_0337B98B59FA46DC87A089AA288D41AC TDT
							LEFT JOIN [0337B98B-59FA-46DC-87A0-89AA288D41AC] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MG_d1_RequestDetailsId=TDT.MG_d1_RequestDetailsId,MG_d1_AdvanceFormId=TDT.MG_d1_AdvanceFormId,MG_d1_ExpenseDetails=TDT.MG_d1_ExpenseDetails,MG_d1_ItemDescription=TDT.MG_d1_ItemDescription,MG_d1_Amount=TDT.MG_d1_Amount FROM @TBL_0337B98B59FA46DC87A089AA288D41AC TDT
							JOIN [0337B98B-59FA-46DC-87A0-89AA288D41AC] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d1_RequestDetailsId,MG_d1_AdvanceFormId,MG_d1_ExpenseDetails,MG_d1_ItemDescription,MG_d1_Amount";

                            tempInsertQuery=@"INSERT INTO @TBL_0337B98B59FA46DC87A089AA288D41AC(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d1_RequestDetailsId,MG_d1_AdvanceFormId,MG_d1_ExpenseDetails,MG_d1_ItemDescription,MG_d1_Amount)VALUES({0});";

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

                                              case "331FE6C6-9B84-4AE8-9DD4-AD780298EEAE":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_331FE6C69B844AE89DD4AD780298EEAE AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [PFA_FundType] VARCHAR(MAX)	, [PFA_FundTypeValue] VARCHAR(MAX)	, [PFA_ProjectNo] VARCHAR(MAX)	, [PFA_ProjectNoValue] VARCHAR(MAX)	, [PFA_BudgetHead] VARCHAR(MAX)	, [PFA_BudgetHeadValue] VARCHAR(MAX)	, [PFA_Amount] DECIMAL(18,2)	, [PFA_FundDetailsId] VARCHAR(MAX)){0}INSERT INTO [331FE6C6-9B84-4AE8-9DD4-AD780298EEAE](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PFA_FundType,PFA_FundTypeValue,PFA_ProjectNo,PFA_ProjectNoValue,PFA_BudgetHead,PFA_BudgetHeadValue,PFA_Amount,PFA_FundDetailsId)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.PFA_FundType,TDT.PFA_FundTypeValue,TDT.PFA_ProjectNo,TDT.PFA_ProjectNoValue,TDT.PFA_BudgetHead,TDT.PFA_BudgetHeadValue,TDT.PFA_Amount,TDT.PFA_FundDetailsId FROM @TBL_331FE6C69B844AE89DD4AD780298EEAE TDT
							LEFT JOIN [331FE6C6-9B84-4AE8-9DD4-AD780298EEAE] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,PFA_FundType=TDT.PFA_FundType,PFA_FundTypeValue=TDT.PFA_FundTypeValue,PFA_ProjectNo=TDT.PFA_ProjectNo,PFA_ProjectNoValue=TDT.PFA_ProjectNoValue,PFA_BudgetHead=TDT.PFA_BudgetHead,PFA_BudgetHeadValue=TDT.PFA_BudgetHeadValue,PFA_Amount=TDT.PFA_Amount,PFA_FundDetailsId=TDT.PFA_FundDetailsId FROM @TBL_331FE6C69B844AE89DD4AD780298EEAE TDT
							JOIN [331FE6C6-9B84-4AE8-9DD4-AD780298EEAE] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PFA_FundType,PFA_FundTypeValue,PFA_ProjectNo,PFA_ProjectNoValue,PFA_BudgetHead,PFA_BudgetHeadValue,PFA_Amount,PFA_FundDetailsId";

                            tempInsertQuery=@"INSERT INTO @TBL_331FE6C69B844AE89DD4AD780298EEAE(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PFA_FundType,PFA_FundTypeValue,PFA_ProjectNo,PFA_ProjectNoValue,PFA_BudgetHead,PFA_BudgetHeadValue,PFA_Amount,PFA_FundDetailsId)VALUES({0});";

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

                                              case "F02A7F6F-1659-4623-8B7E-1C2330D6485E":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_F02A7F6F165946238B7E1C2330D6485E AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [PAB_BudgetName] VARCHAR(MAX)	, [PAB_SanctionedAmount] DECIMAL(18,2)	, [PAB_YetToRecieve] DECIMAL(18,2)	, [PAB_RecievedAmount] DECIMAL(18,2)	, [PAB_Commitment] DECIMAL(18,2)	, [PAB_Spent] DECIMAL(18,2)	, [PAB_Balance] DECIMAL(18,2)){0}INSERT INTO [F02A7F6F-1659-4623-8B7E-1C2330D6485E](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PAB_BudgetName,PAB_SanctionedAmount,PAB_YetToRecieve,PAB_RecievedAmount,PAB_Commitment,PAB_Spent,PAB_Balance)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.PAB_BudgetName,TDT.PAB_SanctionedAmount,TDT.PAB_YetToRecieve,TDT.PAB_RecievedAmount,TDT.PAB_Commitment,TDT.PAB_Spent,TDT.PAB_Balance FROM @TBL_F02A7F6F165946238B7E1C2330D6485E TDT
							LEFT JOIN [F02A7F6F-1659-4623-8B7E-1C2330D6485E] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,PAB_BudgetName=TDT.PAB_BudgetName,PAB_SanctionedAmount=TDT.PAB_SanctionedAmount,PAB_YetToRecieve=TDT.PAB_YetToRecieve,PAB_RecievedAmount=TDT.PAB_RecievedAmount,PAB_Commitment=TDT.PAB_Commitment,PAB_Spent=TDT.PAB_Spent,PAB_Balance=TDT.PAB_Balance FROM @TBL_F02A7F6F165946238B7E1C2330D6485E TDT
							JOIN [F02A7F6F-1659-4623-8B7E-1C2330D6485E] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PAB_BudgetName,PAB_SanctionedAmount,PAB_YetToRecieve,PAB_RecievedAmount,PAB_Commitment,PAB_Spent,PAB_Balance";

                            tempInsertQuery=@"INSERT INTO @TBL_F02A7F6F165946238B7E1C2330D6485E(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PAB_BudgetName,PAB_SanctionedAmount,PAB_YetToRecieve,PAB_RecievedAmount,PAB_Commitment,PAB_Spent,PAB_Balance)VALUES({0});";

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
		
		DECLARE  @TBL_9A0E40951BE844D497FB822ADA862E58 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [A_BudgetID] INT	, [A_OverallSantionedAmount] DECIMAL(18,2)	, [MG_AvailableAmount] DECIMAL(18,2)	, [A_BudgetClaimedAmount] DECIMAL(18,2)	, [A_BudgetName] VARCHAR(MAX)){0}INSERT INTO [9A0E4095-1BE8-44D4-97FB-822ADA862E58](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,A_BudgetID,A_OverallSantionedAmount,MG_AvailableAmount,A_BudgetClaimedAmount,A_BudgetName)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.A_BudgetID,TDT.A_OverallSantionedAmount,TDT.MG_AvailableAmount,TDT.A_BudgetClaimedAmount,TDT.A_BudgetName FROM @TBL_9A0E40951BE844D497FB822ADA862E58 TDT
							LEFT JOIN [9A0E4095-1BE8-44D4-97FB-822ADA862E58] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,A_BudgetID=TDT.A_BudgetID,A_OverallSantionedAmount=TDT.A_OverallSantionedAmount,MG_AvailableAmount=TDT.MG_AvailableAmount,A_BudgetClaimedAmount=TDT.A_BudgetClaimedAmount,A_BudgetName=TDT.A_BudgetName FROM @TBL_9A0E40951BE844D497FB822ADA862E58 TDT
							JOIN [9A0E4095-1BE8-44D4-97FB-822ADA862E58] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,A_BudgetID,A_OverallSantionedAmount,MG_AvailableAmount,A_BudgetClaimedAmount,A_BudgetName";

                            tempInsertQuery=@"INSERT INTO @TBL_9A0E40951BE844D497FB822ADA862E58(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,A_BudgetID,A_OverallSantionedAmount,MG_AvailableAmount,A_BudgetClaimedAmount,A_BudgetName)VALUES({0});";

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
		
		DECLARE  @TBL_C2287754790E4853A5A764772676D00E AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [M_DocumentDetailsId] VARCHAR(MAX)	, [M_DocumentName] VARCHAR(MAX)	, [M_UploadDcoument] VARCHAR(36)){0}INSERT INTO [C2287754-790E-4853-A5A7-64772676D00E](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,M_DocumentDetailsId,M_DocumentName,M_UploadDcoument)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.M_DocumentDetailsId,TDT.M_DocumentName,TDT.M_UploadDcoument FROM @TBL_C2287754790E4853A5A764772676D00E TDT
							LEFT JOIN [C2287754-790E-4853-A5A7-64772676D00E] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,M_DocumentDetailsId=TDT.M_DocumentDetailsId,M_DocumentName=TDT.M_DocumentName,M_UploadDcoument=TDT.M_UploadDcoument FROM @TBL_C2287754790E4853A5A764772676D00E TDT
							JOIN [C2287754-790E-4853-A5A7-64772676D00E] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,M_DocumentDetailsId,M_DocumentName,M_UploadDcoument";

                            tempInsertQuery=@"INSERT INTO @TBL_C2287754790E4853A5A764772676D00E(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,M_DocumentDetailsId,M_DocumentName,M_UploadDcoument)VALUES({0});";

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
		
		DECLARE  @TBL_8B4BCD219BD34278AA2C99F30B18BC32 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [UserName] VARCHAR(MAX)	, [ActivityName] VARCHAR(MAX)	, [Remarks] VARCHAR(MAX)	, [RemarksId] VARCHAR(MAX)	, [DateOfRemarks] DATETIME){0}INSERT INTO [8B4BCD21-9BD3-4278-AA2C-99F30B18BC32](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,UserName,ActivityName,Remarks,RemarksId,DateOfRemarks)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.UserName,TDT.ActivityName,TDT.Remarks,TDT.RemarksId,TDT.DateOfRemarks FROM @TBL_8B4BCD219BD34278AA2C99F30B18BC32 TDT
							LEFT JOIN [8B4BCD21-9BD3-4278-AA2C-99F30B18BC32] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,UserName=TDT.UserName,ActivityName=TDT.ActivityName,Remarks=TDT.Remarks,RemarksId=TDT.RemarksId,DateOfRemarks=TDT.DateOfRemarks FROM @TBL_8B4BCD219BD34278AA2C99F30B18BC32 TDT
							JOIN [8B4BCD21-9BD3-4278-AA2C-99F30B18BC32] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,UserName,ActivityName,Remarks,RemarksId,DateOfRemarks";

                            tempInsertQuery=@"INSERT INTO @TBL_8B4BCD219BD34278AA2C99F30B18BC32(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,UserName,ActivityName,Remarks,RemarksId,DateOfRemarks)VALUES({0});";

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

                                              case "97c72782-b716-b2cd-caba-bef246e1dab6":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_97c72782b716b2cdcababef246e1dab6 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [C_Stepfrom] VARCHAR(MAX)	, [C_StepTo] VARCHAR(MAX)	, [C_Comments] VARCHAR(MAX)	, [C_User] VARCHAR(MAX)	, [C_DateofComments] DATETIME){0}INSERT INTO [97c72782-b716-b2cd-caba-bef246e1dab6](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,C_Stepfrom,C_StepTo,C_Comments,C_User,C_DateofComments)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.C_Stepfrom,TDT.C_StepTo,TDT.C_Comments,TDT.C_User,TDT.C_DateofComments FROM @TBL_97c72782b716b2cdcababef246e1dab6 TDT
							LEFT JOIN [97c72782-b716-b2cd-caba-bef246e1dab6] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,C_Stepfrom=TDT.C_Stepfrom,C_StepTo=TDT.C_StepTo,C_Comments=TDT.C_Comments,C_User=TDT.C_User,C_DateofComments=TDT.C_DateofComments FROM @TBL_97c72782b716b2cdcababef246e1dab6 TDT
							JOIN [97c72782-b716-b2cd-caba-bef246e1dab6] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,C_Stepfrom,C_StepTo,C_Comments,C_User,C_DateofComments";

                            tempInsertQuery=@"INSERT INTO @TBL_97c72782b716b2cdcababef246e1dab6(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,C_Stepfrom,C_StepTo,C_Comments,C_User,C_DateofComments)VALUES({0});";

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
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MG_R2_ReceiptsId=TDT.MG_R2_ReceiptsId,MG_R2_ReceiptSplitUpId=TDT.MG_R2_ReceiptSplitUpId,MG_R2_UpdatedBy=TDT.MG_R2_UpdatedBy,MG_R2_Amount=TDT.MG_R2_Amount,MG_R2_BudgetId=TDT.MG_R2_BudgetId,MG_R2_UpdatedOn=TDT.MG_R2_UpdatedOn FROM @TBL_249EF4459B494EF9804546BD1E6FF8ED TDT
							JOIN [249EF445-9B49-4EF9-8045-46BD1E6FF8ED] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

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

                                              case "f4c435ef-658d-ea4b-3047-12782c9508ca":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_f4c435ef658dea4b304712782c9508ca AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [TD_ModeofJourney] VARCHAR(MAX)	, [TD_Departure] VARCHAR(MAX)	, [TD_DepartureDate] DATETIME	, [TD_Arrival] VARCHAR(MAX)	, [TD_ArrivalDate] DATETIME	, [TD_JourneyClass] VARCHAR(MAX)	, [TD_RoadKms] DECIMAL(18,2)	, [TD_Amount] DECIMAL(18,2)){0}INSERT INTO [f4c435ef-658d-ea4b-3047-12782c9508ca](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,TD_ModeofJourney,TD_Departure,TD_DepartureDate,TD_Arrival,TD_ArrivalDate,TD_JourneyClass,TD_RoadKms,TD_Amount)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.TD_ModeofJourney,TDT.TD_Departure,TDT.TD_DepartureDate,TDT.TD_Arrival,TDT.TD_ArrivalDate,TDT.TD_JourneyClass,TDT.TD_RoadKms,TDT.TD_Amount FROM @TBL_f4c435ef658dea4b304712782c9508ca TDT
							LEFT JOIN [f4c435ef-658d-ea4b-3047-12782c9508ca] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,TD_ModeofJourney=TDT.TD_ModeofJourney,TD_Departure=TDT.TD_Departure,TD_DepartureDate=TDT.TD_DepartureDate,TD_Arrival=TDT.TD_Arrival,TD_ArrivalDate=TDT.TD_ArrivalDate,TD_JourneyClass=TDT.TD_JourneyClass,TD_RoadKms=TDT.TD_RoadKms,TD_Amount=TDT.TD_Amount FROM @TBL_f4c435ef658dea4b304712782c9508ca TDT
							JOIN [f4c435ef-658d-ea4b-3047-12782c9508ca] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,TD_ModeofJourney,TD_Departure,TD_DepartureDate,TD_Arrival,TD_ArrivalDate,TD_JourneyClass,TD_RoadKms,TD_Amount";

                            tempInsertQuery=@"INSERT INTO @TBL_f4c435ef658dea4b304712782c9508ca(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,TD_ModeofJourney,TD_Departure,TD_DepartureDate,TD_Arrival,TD_ArrivalDate,TD_JourneyClass,TD_RoadKms,TD_Amount)VALUES({0});";

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

                                              case "5cd6b407-a9ef-5a80-b97f-443d95733731":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_5cd6b407a9ef5a80b97f443d95733731 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [ED_ExpentitureType] VARCHAR(MAX)	, [ED_FromDate] DATETIME	, [ED_ToDate] DATETIME	, [ED_Amount] DECIMAL(18,2)){0}INSERT INTO [5cd6b407-a9ef-5a80-b97f-443d95733731](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,ED_ExpentitureType,ED_FromDate,ED_ToDate,ED_Amount)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.ED_ExpentitureType,TDT.ED_FromDate,TDT.ED_ToDate,TDT.ED_Amount FROM @TBL_5cd6b407a9ef5a80b97f443d95733731 TDT
							LEFT JOIN [5cd6b407-a9ef-5a80-b97f-443d95733731] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,ED_ExpentitureType=TDT.ED_ExpentitureType,ED_FromDate=TDT.ED_FromDate,ED_ToDate=TDT.ED_ToDate,ED_Amount=TDT.ED_Amount FROM @TBL_5cd6b407a9ef5a80b97f443d95733731 TDT
							JOIN [5cd6b407-a9ef-5a80-b97f-443d95733731] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,ED_ExpentitureType,ED_FromDate,ED_ToDate,ED_Amount";

                            tempInsertQuery=@"INSERT INTO @TBL_5cd6b407a9ef5a80b97f443d95733731(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,ED_ExpentitureType,ED_FromDate,ED_ToDate,ED_Amount)VALUES({0});";

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

                                              case "c018d17a-c198-7da2-f9a8-6701c434c1c3":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_c018d17ac1987da2f9a86701c434c1c3 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [FD_Description] VARCHAR(MAX)	, [FD_FundType] VARCHAR(MAX)	, [FD_Amount] DECIMAL(18,2)){0}INSERT INTO [c018d17a-c198-7da2-f9a8-6701c434c1c3](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,FD_Description,FD_FundType,FD_Amount)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.FD_Description,TDT.FD_FundType,TDT.FD_Amount FROM @TBL_c018d17ac1987da2f9a86701c434c1c3 TDT
							LEFT JOIN [c018d17a-c198-7da2-f9a8-6701c434c1c3] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,FD_Description=TDT.FD_Description,FD_FundType=TDT.FD_FundType,FD_Amount=TDT.FD_Amount FROM @TBL_c018d17ac1987da2f9a86701c434c1c3 TDT
							JOIN [c018d17a-c198-7da2-f9a8-6701c434c1c3] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,FD_Description,FD_FundType,FD_Amount";

                            tempInsertQuery=@"INSERT INTO @TBL_c018d17ac1987da2f9a86701c434c1c3(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,FD_Description,FD_FundType,FD_Amount)VALUES({0});";

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

                                              case "CDCED39A-D76C-4204-9A70-C637DD092E54":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_CDCED39AD76C42049A70C637DD092E54 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_d2_TADetailsID] VARCHAR(MAX)	, [MG_d2_TravelAdvanceID] VARCHAR(MAX)	, [MG_d2_Departure] VARCHAR(MAX)	, [MG_d2_DepartureDate] DATETIME	, [MG_d2_DepartureTime] VARCHAR(MAX)	, [MG_d2_Arrival] VARCHAR(MAX)	, [MG_d2_ArrivalDate] DATETIME	, [MG_d2_ArrivalTime] VARCHAR(MAX)	, [MG_d2_ModeofJourney] VARCHAR(250)	, [MG_d2_JourneyClass] VARCHAR(250)	, [MG_d2_Road] INT	, [MG_d2_PNRNo] VARCHAR(MAX)	, [MG_d2_Amount] DECIMAL(18,2)	, [MG_d2_IsTravelRequest] INT	, [MG_d2_UpdatedBy] INT	, [MG_d2_UpdatedOn] DATETIME){0}INSERT INTO [CDCED39A-D76C-4204-9A70-C637DD092E54](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d2_TADetailsID,MG_d2_TravelAdvanceID,MG_d2_Departure,MG_d2_DepartureDate,MG_d2_DepartureTime,MG_d2_Arrival,MG_d2_ArrivalDate,MG_d2_ArrivalTime,MG_d2_ModeofJourney,MG_d2_JourneyClass,MG_d2_Road,MG_d2_PNRNo,MG_d2_Amount,MG_d2_IsTravelRequest,MG_d2_UpdatedBy,MG_d2_UpdatedOn)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_d2_TADetailsID,TDT.MG_d2_TravelAdvanceID,TDT.MG_d2_Departure,TDT.MG_d2_DepartureDate,TDT.MG_d2_DepartureTime,TDT.MG_d2_Arrival,TDT.MG_d2_ArrivalDate,TDT.MG_d2_ArrivalTime,TDT.MG_d2_ModeofJourney,TDT.MG_d2_JourneyClass,TDT.MG_d2_Road,TDT.MG_d2_PNRNo,TDT.MG_d2_Amount,TDT.MG_d2_IsTravelRequest,TDT.MG_d2_UpdatedBy,TDT.MG_d2_UpdatedOn FROM @TBL_CDCED39AD76C42049A70C637DD092E54 TDT
							LEFT JOIN [CDCED39A-D76C-4204-9A70-C637DD092E54] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MG_d2_TADetailsID=TDT.MG_d2_TADetailsID,MG_d2_TravelAdvanceID=TDT.MG_d2_TravelAdvanceID,MG_d2_Departure=TDT.MG_d2_Departure,MG_d2_DepartureDate=TDT.MG_d2_DepartureDate,MG_d2_DepartureTime=TDT.MG_d2_DepartureTime,MG_d2_Arrival=TDT.MG_d2_Arrival,MG_d2_ArrivalDate=TDT.MG_d2_ArrivalDate,MG_d2_ArrivalTime=TDT.MG_d2_ArrivalTime,MG_d2_ModeofJourney=TDT.MG_d2_ModeofJourney,MG_d2_JourneyClass=TDT.MG_d2_JourneyClass,MG_d2_Road=TDT.MG_d2_Road,MG_d2_PNRNo=TDT.MG_d2_PNRNo,MG_d2_Amount=TDT.MG_d2_Amount,MG_d2_IsTravelRequest=TDT.MG_d2_IsTravelRequest,MG_d2_UpdatedBy=TDT.MG_d2_UpdatedBy,MG_d2_UpdatedOn=TDT.MG_d2_UpdatedOn FROM @TBL_CDCED39AD76C42049A70C637DD092E54 TDT
							JOIN [CDCED39A-D76C-4204-9A70-C637DD092E54] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d2_TADetailsID,MG_d2_TravelAdvanceID,MG_d2_Departure,MG_d2_DepartureDate,MG_d2_DepartureTime,MG_d2_Arrival,MG_d2_ArrivalDate,MG_d2_ArrivalTime,MG_d2_ModeofJourney,MG_d2_JourneyClass,MG_d2_Road,MG_d2_PNRNo,MG_d2_Amount,MG_d2_IsTravelRequest,MG_d2_UpdatedBy,MG_d2_UpdatedOn";

                            tempInsertQuery=@"INSERT INTO @TBL_CDCED39AD76C42049A70C637DD092E54(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d2_TADetailsID,MG_d2_TravelAdvanceID,MG_d2_Departure,MG_d2_DepartureDate,MG_d2_DepartureTime,MG_d2_Arrival,MG_d2_ArrivalDate,MG_d2_ArrivalTime,MG_d2_ModeofJourney,MG_d2_JourneyClass,MG_d2_Road,MG_d2_PNRNo,MG_d2_Amount,MG_d2_IsTravelRequest,MG_d2_UpdatedBy,MG_d2_UpdatedOn)VALUES({0});";

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

                                              case "7DC7A3E8-9FDF-4C75-9F83-FEC89BA524E4":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_7DC7A3E89FDF4C759F83FEC89BA524E4 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [MG_d3_ExpenditureTypeID] VARCHAR(MAX)	, [MG_d3_TravelAdvanceID] VARCHAR(MAX)	, [MG_d3_FromDate] DATETIME	, [MG_d3_ToDate] DATETIME	, [MG_d3_Amount] DECIMAL(18,2)	, [MG_d3_UpdatedBy] INT	, [MG_d3_UpdatedOn] DATETIME	, [MG_d3_ExpenditureType] VARCHAR(250)	, [MG_d3_OtherExpenditureType] VARCHAR(MAX)	, [MG_d3_IsTravelRequest] INT){0}INSERT INTO [7DC7A3E8-9FDF-4C75-9F83-FEC89BA524E4](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d3_ExpenditureTypeID,MG_d3_TravelAdvanceID,MG_d3_FromDate,MG_d3_ToDate,MG_d3_Amount,MG_d3_UpdatedBy,MG_d3_UpdatedOn,MG_d3_ExpenditureType,MG_d3_OtherExpenditureType,MG_d3_IsTravelRequest)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.MG_d3_ExpenditureTypeID,TDT.MG_d3_TravelAdvanceID,TDT.MG_d3_FromDate,TDT.MG_d3_ToDate,TDT.MG_d3_Amount,TDT.MG_d3_UpdatedBy,TDT.MG_d3_UpdatedOn,TDT.MG_d3_ExpenditureType,TDT.MG_d3_OtherExpenditureType,TDT.MG_d3_IsTravelRequest FROM @TBL_7DC7A3E89FDF4C759F83FEC89BA524E4 TDT
							LEFT JOIN [7DC7A3E8-9FDF-4C75-9F83-FEC89BA524E4] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,MG_d3_ExpenditureTypeID=TDT.MG_d3_ExpenditureTypeID,MG_d3_TravelAdvanceID=TDT.MG_d3_TravelAdvanceID,MG_d3_FromDate=TDT.MG_d3_FromDate,MG_d3_ToDate=TDT.MG_d3_ToDate,MG_d3_Amount=TDT.MG_d3_Amount,MG_d3_UpdatedBy=TDT.MG_d3_UpdatedBy,MG_d3_UpdatedOn=TDT.MG_d3_UpdatedOn,MG_d3_ExpenditureType=TDT.MG_d3_ExpenditureType,MG_d3_OtherExpenditureType=TDT.MG_d3_OtherExpenditureType,MG_d3_IsTravelRequest=TDT.MG_d3_IsTravelRequest FROM @TBL_7DC7A3E89FDF4C759F83FEC89BA524E4 TDT
							JOIN [7DC7A3E8-9FDF-4C75-9F83-FEC89BA524E4] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d3_ExpenditureTypeID,MG_d3_TravelAdvanceID,MG_d3_FromDate,MG_d3_ToDate,MG_d3_Amount,MG_d3_UpdatedBy,MG_d3_UpdatedOn,MG_d3_ExpenditureType,MG_d3_OtherExpenditureType,MG_d3_IsTravelRequest";

                            tempInsertQuery=@"INSERT INTO @TBL_7DC7A3E89FDF4C759F83FEC89BA524E4(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,MG_d3_ExpenditureTypeID,MG_d3_TravelAdvanceID,MG_d3_FromDate,MG_d3_ToDate,MG_d3_Amount,MG_d3_UpdatedBy,MG_d3_UpdatedOn,MG_d3_ExpenditureType,MG_d3_OtherExpenditureType,MG_d3_IsTravelRequest)VALUES({0});";

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

                                              case "57484F68-026D-4FF5-A5E1-E4E0BDDD76E0":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_57484F68026D4FF5A5E1E4E0BDDD76E0 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [PFA_FundType] VARCHAR(MAX)	, [PFA_FundTypeValue] VARCHAR(MAX)	, [PFA_ProjectNo] VARCHAR(MAX)	, [PFA_ProjectNoValue] VARCHAR(MAX)	, [PFA_BudgetHead] VARCHAR(MAX)	, [PFA_BudgetHeadValue] VARCHAR(MAX)	, [PFA_Amount] DECIMAL(18,2)	, [PFA_FundDetailsId] VARCHAR(MAX)){0}INSERT INTO [57484F68-026D-4FF5-A5E1-E4E0BDDD76E0](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PFA_FundType,PFA_FundTypeValue,PFA_ProjectNo,PFA_ProjectNoValue,PFA_BudgetHead,PFA_BudgetHeadValue,PFA_Amount,PFA_FundDetailsId)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.PFA_FundType,TDT.PFA_FundTypeValue,TDT.PFA_ProjectNo,TDT.PFA_ProjectNoValue,TDT.PFA_BudgetHead,TDT.PFA_BudgetHeadValue,TDT.PFA_Amount,TDT.PFA_FundDetailsId FROM @TBL_57484F68026D4FF5A5E1E4E0BDDD76E0 TDT
							LEFT JOIN [57484F68-026D-4FF5-A5E1-E4E0BDDD76E0] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,PFA_FundType=TDT.PFA_FundType,PFA_FundTypeValue=TDT.PFA_FundTypeValue,PFA_ProjectNo=TDT.PFA_ProjectNo,PFA_ProjectNoValue=TDT.PFA_ProjectNoValue,PFA_BudgetHead=TDT.PFA_BudgetHead,PFA_BudgetHeadValue=TDT.PFA_BudgetHeadValue,PFA_Amount=TDT.PFA_Amount,PFA_FundDetailsId=TDT.PFA_FundDetailsId FROM @TBL_57484F68026D4FF5A5E1E4E0BDDD76E0 TDT
							JOIN [57484F68-026D-4FF5-A5E1-E4E0BDDD76E0] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PFA_FundType,PFA_FundTypeValue,PFA_ProjectNo,PFA_ProjectNoValue,PFA_BudgetHead,PFA_BudgetHeadValue,PFA_Amount,PFA_FundDetailsId";

                            tempInsertQuery=@"INSERT INTO @TBL_57484F68026D4FF5A5E1E4E0BDDD76E0(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PFA_FundType,PFA_FundTypeValue,PFA_ProjectNo,PFA_ProjectNoValue,PFA_BudgetHead,PFA_BudgetHeadValue,PFA_Amount,PFA_FundDetailsId)VALUES({0});";

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

                                              case "4435EA72-034D-4A84-8791-1F4DC99EADC1":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_4435EA72034D4A8487911F4DC99EADC1 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [PAB_BudgetName] VARCHAR(MAX)	, [PAB_SanctionedAmount] DECIMAL(18,2)	, [PAB_YetToRecieve] DECIMAL(18,2)	, [PAB_RecievedAmount] DECIMAL(18,2)	, [PAB_Commitment] DECIMAL(18,2)	, [PAB_Spent] DECIMAL(18,2)	, [PAB_Balance] DECIMAL(18,2)){0}INSERT INTO [4435EA72-034D-4A84-8791-1F4DC99EADC1](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PAB_BudgetName,PAB_SanctionedAmount,PAB_YetToRecieve,PAB_RecievedAmount,PAB_Commitment,PAB_Spent,PAB_Balance)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.PAB_BudgetName,TDT.PAB_SanctionedAmount,TDT.PAB_YetToRecieve,TDT.PAB_RecievedAmount,TDT.PAB_Commitment,TDT.PAB_Spent,TDT.PAB_Balance FROM @TBL_4435EA72034D4A8487911F4DC99EADC1 TDT
							LEFT JOIN [4435EA72-034D-4A84-8791-1F4DC99EADC1] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,PAB_BudgetName=TDT.PAB_BudgetName,PAB_SanctionedAmount=TDT.PAB_SanctionedAmount,PAB_YetToRecieve=TDT.PAB_YetToRecieve,PAB_RecievedAmount=TDT.PAB_RecievedAmount,PAB_Commitment=TDT.PAB_Commitment,PAB_Spent=TDT.PAB_Spent,PAB_Balance=TDT.PAB_Balance FROM @TBL_4435EA72034D4A8487911F4DC99EADC1 TDT
							JOIN [4435EA72-034D-4A84-8791-1F4DC99EADC1] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PAB_BudgetName,PAB_SanctionedAmount,PAB_YetToRecieve,PAB_RecievedAmount,PAB_Commitment,PAB_Spent,PAB_Balance";

                            tempInsertQuery=@"INSERT INTO @TBL_4435EA72034D4A8487911F4DC99EADC1(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PAB_BudgetName,PAB_SanctionedAmount,PAB_YetToRecieve,PAB_RecievedAmount,PAB_Commitment,PAB_Spent,PAB_Balance)VALUES({0});";

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

                                              case "4BBC0C1F-5883-4AAD-A2A7-BF4551B3555E":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_4BBC0C1F58834AADA2A7BF4551B3555E AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [PADD_DocumentName] VARCHAR(MAX)	, [PADD_Document] VARCHAR(MAX)){0}INSERT INTO [4BBC0C1F-5883-4AAD-A2A7-BF4551B3555E](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PADD_DocumentName,PADD_Document)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.PADD_DocumentName,TDT.PADD_Document FROM @TBL_4BBC0C1F58834AADA2A7BF4551B3555E TDT
							LEFT JOIN [4BBC0C1F-5883-4AAD-A2A7-BF4551B3555E] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,PADD_DocumentName=TDT.PADD_DocumentName,PADD_Document=TDT.PADD_Document FROM @TBL_4BBC0C1F58834AADA2A7BF4551B3555E TDT
							JOIN [4BBC0C1F-5883-4AAD-A2A7-BF4551B3555E] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PADD_DocumentName,PADD_Document";

                            tempInsertQuery=@"INSERT INTO @TBL_4BBC0C1F58834AADA2A7BF4551B3555E(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,PADD_DocumentName,PADD_Document)VALUES({0});";

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

                                              case "EF8F97B1-41F1-43F5-91EF-FE1E3EBBE2AC":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_EF8F97B141F143F591EFFE1E3EBBE2AC AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [WMC_StepFrom] VARCHAR(MAX)	, [WMC_StepTo] VARCHAR(MAX)	, [WMC_Comments] VARCHAR(MAX)	, [WMC_User] VARCHAR(MAX)	, [WMC_DateofComments] DATETIME){0}INSERT INTO [EF8F97B1-41F1-43F5-91EF-FE1E3EBBE2AC](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,WMC_StepFrom,WMC_StepTo,WMC_Comments,WMC_User,WMC_DateofComments)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.WMC_StepFrom,TDT.WMC_StepTo,TDT.WMC_Comments,TDT.WMC_User,TDT.WMC_DateofComments FROM @TBL_EF8F97B141F143F591EFFE1E3EBBE2AC TDT
							LEFT JOIN [EF8F97B1-41F1-43F5-91EF-FE1E3EBBE2AC] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,WMC_StepFrom=TDT.WMC_StepFrom,WMC_StepTo=TDT.WMC_StepTo,WMC_Comments=TDT.WMC_Comments,WMC_User=TDT.WMC_User,WMC_DateofComments=TDT.WMC_DateofComments FROM @TBL_EF8F97B141F143F591EFFE1E3EBBE2AC TDT
							JOIN [EF8F97B1-41F1-43F5-91EF-FE1E3EBBE2AC] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,WMC_StepFrom,WMC_StepTo,WMC_Comments,WMC_User,WMC_DateofComments";

                            tempInsertQuery=@"INSERT INTO @TBL_EF8F97B141F143F591EFFE1E3EBBE2AC(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,WMC_StepFrom,WMC_StepTo,WMC_Comments,WMC_User,WMC_DateofComments)VALUES({0});";

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

                                              case "c4df7365-678c-f65a-2f9a-d05b5d20bab7":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_c4df7365678cf65a2f9ad05b5d20bab7 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [RD_RefNo] VARCHAR(MAX)	, [RD_ReceiptDate] DATETIME	, [RD_ReceiptAmount] DECIMAL(18,2)	, [RD_RefId] VARCHAR(MAX)	, [RD_Status] VARCHAR(MAX)){0}INSERT INTO [c4df7365-678c-f65a-2f9a-d05b5d20bab7](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,RD_RefNo,RD_ReceiptDate,RD_ReceiptAmount,RD_RefId,RD_Status)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.RD_RefNo,TDT.RD_ReceiptDate,TDT.RD_ReceiptAmount,TDT.RD_RefId,TDT.RD_Status FROM @TBL_c4df7365678cf65a2f9ad05b5d20bab7 TDT
							LEFT JOIN [c4df7365-678c-f65a-2f9a-d05b5d20bab7] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,RD_RefNo=TDT.RD_RefNo,RD_ReceiptDate=TDT.RD_ReceiptDate,RD_ReceiptAmount=TDT.RD_ReceiptAmount,RD_RefId=TDT.RD_RefId,RD_Status=TDT.RD_Status FROM @TBL_c4df7365678cf65a2f9ad05b5d20bab7 TDT
							JOIN [c4df7365-678c-f65a-2f9a-d05b5d20bab7] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,RD_RefNo,RD_ReceiptDate,RD_ReceiptAmount,RD_RefId,RD_Status";

                            tempInsertQuery=@"INSERT INTO @TBL_c4df7365678cf65a2f9ad05b5d20bab7(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,RD_RefNo,RD_ReceiptDate,RD_ReceiptAmount,RD_RefId,RD_Status)VALUES({0});";

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

                                              case "10AA6840-065A-4E6E-95CC-29609326A113":
                    {
                     
                            gInsertQuery=@"
		
		DECLARE  @TBL_10AA6840065A4E6E95CC29609326A113 AS TABLE(	  [InstanceId] VARCHAR(36)	, [ProcessActivityMapId] VARCHAR(36)	, [GridId] VARCHAR(36)	, [RowId] VARCHAR(36)	, [Sequence] INT	, [RD_RefNo] VARCHAR(MAX)	, [RD_ReceiptDate] DATETIME	, [RD_ReceiptAmount] DECIMAL(18,2)	, [RD_RefId] VARCHAR(MAX)	, [RD_Status] VARCHAR(MAX)){0}INSERT INTO [10AA6840-065A-4E6E-95CC-29609326A113](InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,RD_RefNo,RD_ReceiptDate,RD_ReceiptAmount,RD_RefId,RD_Status)
							SELECT TDT.InstanceId,TDT.ProcessActivityMapId,TDT.GridId,TDT.RowId,TDT.Sequence,TDT.RD_RefNo,TDT.RD_ReceiptDate,TDT.RD_ReceiptAmount,TDT.RD_RefId,TDT.RD_Status FROM @TBL_10AA6840065A4E6E95CC29609326A113 TDT
							LEFT JOIN [10AA6840-065A-4E6E-95CC-29609326A113] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId  WHERE DT.RowId IS NULL;UPDATE  DT SET ProcessActivityMapId=TDT.ProcessActivityMapId,Sequence=TDT.Sequence,RD_RefNo=TDT.RD_RefNo,RD_ReceiptDate=TDT.RD_ReceiptDate,RD_ReceiptAmount=TDT.RD_ReceiptAmount,RD_RefId=TDT.RD_RefId,RD_Status=TDT.RD_Status FROM @TBL_10AA6840065A4E6E95CC29609326A113 TDT
							JOIN [10AA6840-065A-4E6E-95CC-29609326A113] DT  WITH(NOLOCK)
							ON	TDT.RowId=DT.RowId AND TDT.InstanceId=DT.InstanceId ";

                            colList=@"InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,RD_RefNo,RD_ReceiptDate,RD_ReceiptAmount,RD_RefId,RD_Status";

                            tempInsertQuery=@"INSERT INTO @TBL_10AA6840065A4E6E95CC29609326A113(InstanceId,ProcessActivityMapId,GridId,RowId,Sequence,RD_RefNo,RD_ReceiptDate,RD_ReceiptAmount,RD_RefId,RD_Status)VALUES({0});";

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

                     if (aggregateValue == null)
                        aggregateValue = 0;
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