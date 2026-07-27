
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

            try
            {
                               
                var connectionId = comboSource.Item1;
              
                var connectionString = ConnectionById
                    (_proofConnectionName, connectionId);

                if (connectionString == null)
                {
                    _sysLog.Error("Connection String is null or empty");

                    return Status.Failure;
                }

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

            _sysLog.Debug("Entering ExecuteComboQuery.");

            _sysLog.DebugFormat("The QUERY RUNNING IS {0}", query);

            try
            {
                _sysLog.Debug("Entering ExecuteComboQuery");


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