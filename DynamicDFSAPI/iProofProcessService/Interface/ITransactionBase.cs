
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using SRA.Proof.Helpers;

namespace CPS.Proof.DFSExtension
{
    public interface ITransactionBase
    {
        /// <summary>
        /// Creates a new instance of Committable
        /// transaction
        /// </summary>
        /// <param name="connectionName">
        /// A <seealso cref="string"/> to create transaction
        /// </param>
        /// <param name="_dicTransactions">
        /// A <seealso cref="string"/> Dictionary of trasactions
        /// </param>
        /// <returns>
        /// committable transaction <seealso cref="string"/>
        /// </returns>
        TransactionObject CreateTransactionInstance();

        /// <summary>
        /// Commits all enlisted transactions
        /// </summary>      
        /// <param name="transaction">
        /// A <seealso cref="string"/> Dictionary of trasactions
        /// </param>
        /// <returns>
        /// true or false <seealso cref="System.Boolean"/>
        /// </returns>
        void CommitTransaction(TransactionObject transaction);

        /// <summary>
        /// Rollbacks all enlisted transaction
        /// </summary>
        /// <param name="transaction">
        /// A <seealso cref="string"/> Dictionary of trasactions
        /// </param>
        /// <returns>
        /// true or false <seealso cref="System.Boolean"/>
        /// </returns>
        void RollBackTransaction(TransactionObject transaction);

        /// <summary>
        /// Prepares committable transaction for the
        /// calling method execution
        /// Includes Opening connection, Creating one committable transaction per
        /// database connection and enlisting it
        /// </summary>
        /// <param name="connectionName">
        /// A <seealso cref="string"/> to create transaction
        /// </param>
        /// <param name="_dicTransactions">
        /// A <seealso cref="string"/> Dictionary of trasactions
        /// </param>
        /// <returns>
        /// committable transaction <seealso cref="string"/>
        /// </returns>
        DbConnection PrepareTransactionConnection(
               Database dataBase, string connectionName,
                 ref TransactionObject dicTransactions);

    }
}
