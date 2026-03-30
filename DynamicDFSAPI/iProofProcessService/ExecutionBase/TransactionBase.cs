using log4net;
using Microsoft.Practices.EnterpriseLibrary.Data;
using SRA.Proof.Helpers;
using SRA.Proof.Middleware;
using System.Collections.Generic;
using System.Data.Common;
using System.Transactions;
using System;

namespace CPS.Proof.DFSExtension
{
    public class TransactionBase:ITransactionBase
    {
        /// <summary>
        /// Represents a ILog object used for logging.
        /// </summary>
        private readonly ILog _sysLog;

        public TransactionBase()
        {
            _sysLog = LogManager.GetLogger(GetType());
        }



        /// <summary>
        /// Prepares committable transaction for the
        /// calling method execution
        /// Includes Opening connection, Creating one committable transaction per
        /// database connection and enlisting it
        /// </summary>
        /// <param name="dataBase"></param>
        /// <param name="connectionName">
        /// A <seealso cref="System.String"/> to create transaction
        /// </param>
        /// <param name="transactions"></param>
        /// <returns>
        /// </returns>
        public DbConnection PrepareTransactionConnection(
               Database dataBase, string connectionName,
                 ref TransactionObject transactions)
        {

            _sysLog.Debug("Entering PrepareTransactionConnection method");

            try
            {
                CommittableTransaction tr;

                //Get committable transaction and DBconnection if already created for the database
                //and this transaction scope
                //If not exists create it
                tr = GetTransactions(connectionName, ref transactions,
                    dataBase, out var conn);

                //current transaction is enlisted on the connection created
                //for the transaction scope and this will
                //be assigned to DBcommand object's connection property

                if (dataBase.DbProviderFactory.ToString().
                        Equals(TransactionConstants.MySqlProvider))
                {
                    //To be revisted: Mysql Transaction enlistment fails if
                    //the connection has been already enlisted 
                    //To find out the way if the connection is enlisted with
                    //the transaction already
                    EnlistTransaction(conn, tr);
                }

                else
                {
                    try
                    {

                        conn.EnlistTransaction(tr);
                    }
                    catch (Exception ex)
                    {
                        _sysLog.ErrorFormat("Error in enlisting {0}", ex);

                        return conn;
                    }
                }


                _sysLog.Debug("Exiting PrepareTransactionConnection method");

                return conn;
            }
            catch (Exception ex)
            {
                _sysLog.Error("Error in PrepareTransactionConnection", ex);

                return null;
            }
        }


        private DbConnection EnlistTransaction
           (DbConnection conn, CommittableTransaction tr)
        {
            try
            {
                conn.EnlistTransaction(tr);
                return conn;
            }
            catch
            {
                return conn;
            }
        }

        /// <summary>
        /// Creates a new instance of Committable
        /// transaction
        /// </summary>
        /// <param name="connectionName">
        /// A <seealso cref="System.String"/> to create transaction
        /// </param>
        /// <param name="_dicTransactions">
        /// A <seealso cref="System.String"/> Dictionary of trasactions
        /// </param>
        /// <returns>
        /// committable transaction <seealso cref="System.String"/>
        /// </returns>
        public TransactionObject CreateTransactionInstance()
        {
            TransactionObject transObject = new TransactionObject
            {
                Transactions =
                    new Dictionary<string, CommittableTransaction>(),


                Connections =
                    new List<Tuple<string, CommittableTransaction, DbConnection>>()

            };

            return transObject;
        }


        /// <summary>
        /// Commits all enlisted transactions
        /// </summary>      
        /// <param name="transaction">
        /// A <seealso cref="System.String"/> Dictionary of trasactions
        /// </param>
        /// <returns>
        /// true or false <seealso cref="System.Boolean"/>
        /// </returns>
        public void CommitTransaction
                    (TransactionObject transaction)
        {
            try
            {
              
                    foreach (var t in transaction.Transactions)
                    {


                        _sysLog.DebugFormat("Transaction status {0}",
                        t.Value.TransactionInformation.Status.ToString());

                        t.Value.BeginCommit(OnCommitted, null);

                        CloseConnection(t.Value, transaction);

                        RemoveTransaction(t.Value, transaction);


                    }
                

            }
            catch (Exception ex)
            {
                _sysLog.Error("Error in CommitTransaction", ex);

                throw ex;
            }

        }

        void OnCommitted(IAsyncResult asyncResult)
        {
            CommittableTransaction committableTransaction;
            committableTransaction = asyncResult as CommittableTransaction;

            try
            {

                if (committableTransaction.TransactionInformation.Status != TransactionStatus.Committed)
                {
                    using (committableTransaction)
                    {
                        committableTransaction.EndCommit(asyncResult);

                        committableTransaction.Dispose();
                    }
                }
                else if (committableTransaction.TransactionInformation.Status != TransactionStatus.Committed)
                {
                    _sysLog.ErrorFormat("Error in Transaction Status {0}", committableTransaction.TransactionInformation.Status);
                }
            }
            catch (TransactionException e)
            {
                _sysLog.ErrorFormat("Error in commit transaction {0}", e);
            }
        }

        /// <summary>
        /// Rollbacks all enlisted transaction
        /// </summary>
        /// <param name="transaction">
        /// A <seealso cref="System.String"/> Dictionary of trasactions
        /// </param>
        /// <returns>
        /// true or false <seealso cref="System.Boolean"/>
        /// </returns>
        public void RollBackTransaction
                    (TransactionObject transaction)
        {
            try
            {
               

                    foreach (var t in transaction.Transactions)
                    {
                        if (t.Value.TransactionInformation.Status != TransactionStatus.Committed)
                            t.Value.Rollback();

                        CloseConnection(t.Value, transaction);

                        RemoveTransaction(t.Value, transaction);

                    }
                

            }
            catch (Exception ex)
            {

                _sysLog.Error("Error in RollBackTransaction", ex);

                throw ex;

            }
        }

        #region privateMethods

        /// <summary>
        /// Creates a new transaction for the connection
        /// </summary>
        /// <param name="connectionName">
        /// A <seealso cref="System.String"/> to create transaction
        /// </param>
        /// <param name="dicTransactions">
        /// A <seealso cref="System.String"/> Dictionary of trasactions
        /// </param>
        /// <returns>
        /// committable transaction <seealso cref="System.String"/>
        /// </returns>
        private CommittableTransaction CreateTransactions(string connectionName,
            ref TransactionObject dicTransactions)
        {

            try
            {
                TransactionOptions transactionoption = new TransactionOptions();

                transactionoption.IsolationLevel =
                   System.Transactions.IsolationLevel.ReadUncommitted;


                // transactionoption.IsolationLevel =
                //   System.Transactions.IsolationLevel.ReadUncommitted;


                transactionoption.Timeout = new TimeSpan(0, 40, 0);


                CommittableTransaction transaction =
                                        new CommittableTransaction(transactionoption);

                dicTransactions.Transactions.Add(connectionName, transaction);

                return transaction;
            }
            catch (Exception ex)
            {
                _sysLog.Error("Error in CreateTransactions", ex);

                return null;
            }
        }

        /// <summary>
        /// Gets the transaction if exists for the connection
        /// </summary>
        /// <param name="connectionName">
        /// A <seealso cref="System.String"/> checks associated transaction
        /// </param>
        /// <param name="dicTransactions">
        /// A <seealso cref="System.String"/> to check for connection
        /// </param>
        /// <param name="dataBase"></param>
        /// <param name="conn"></param>
        /// <returns>
        /// committable transaction <seealso cref="System.String"/>
        /// </returns>
        private CommittableTransaction GetTransactions(string connectionName,
           ref TransactionObject dicTransactions, Database dataBase, out DbConnection conn)
        {
            conn = null;


            CommittableTransaction tr = dicTransactions.Transactions.ContainsKey
             (connectionName) ? dicTransactions.Transactions[connectionName]
                : CreateTransactions(connectionName, ref dicTransactions);

            bool isExists = false;


            if (dicTransactions.Transactions != null)
            {

                foreach (var tup in dicTransactions.Connections)
                {
                    if (tr != null)
                    {

                        if (tup.Item2.Equals(tr) && tup.Item1.Equals(connectionName))
                        {
                            conn = tup.Item3;

                            isExists = true;

                            break;

                        }
                    }
                }
            }

            if (!isExists || dicTransactions.Connections == null)
            {
                if (conn == null)
                {

                    _sysLog.DebugFormat("Begin Creating connection {0}", DateTime.Now.ToString());


                    conn = dataBase.CreateConnection();

                    conn.Open();
                    //conn.OpenAsync();


                    _sysLog.DebugFormat("End Creating connection {0}", DateTime.Now.ToString());

                }

                SetConnection(conn, connectionName, tr, dicTransactions);

            }

            return tr;
        }



        /// <summary>
        /// Close the  connection on the database
        /// </summary>
        /// <param name="tr">
        /// A <seealso cref="Dictionary<K, {V}>"/> Committable Transaction Object
        /// </param>      
        /// <returns>
        /// nothing <seealso cref="void"/>
        /// </returns>
        private void CloseConnection
            (CommittableTransaction tr, TransactionObject tupConnection)
        {
            if (tupConnection != null && tupConnection.Connections != null)
            {

                foreach (var tup in tupConnection.Connections)
                {
                    if (tup.Item2.Equals(tr))
                    {
                        var conn = tup.Item3;

                        if (conn != null)
                        {

                            conn.EnlistTransaction(null);

                            //conn.Close();
                            conn.Close();
                            // conn.Dispose();
                        }
                    }

                }
            }

        }

        /// <summary>
        /// Represents a method to Remove Transaction  
        /// once it gets completed 
        /// </summary>
        /// <param name="transaction">
        /// A <see cref="CommittableTransaction"/> holds the transaction identifier.
        /// </param>
        /// <param name="tupConnection"></param>
        /// <returns>
        /// Nothing
        /// </returns>
        private void RemoveTransaction(CommittableTransaction transaction, TransactionObject tupConnection)
        {
            if (tupConnection != null)
            {
                tupConnection.Connections.RemoveAll
                    (x => x.Item2.Equals(transaction));
            }

        }

        /// <summary>
        /// Represents a method to get Transaction scope Connection   
        /// </summary>
        /// <param name="connectionName">
        /// A <see cref="string"/> holds the connectionname identifier.
        /// </param>    
        /// <returns>
        /// DbConnection <seealso cref="System.Data.DbConnection"/>
        /// </returns>
        private void SetConnection(DbConnection conn,
            string connectionName, CommittableTransaction transaction, TransactionObject tupConnection)
        {

            tupConnection.Connections.Add(new Tuple
                <string, CommittableTransaction, DbConnection>
                (connectionName, transaction, conn));

        }

        public void Dispose()
        {

        }

        #endregion
    }
}
