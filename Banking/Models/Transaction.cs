using System;

namespace Banking.Models
{
    class Transaction
    {

        #region Properties
        public decimal Amount { get; private set; }
        public DateTime DateOfTrans { get; private set; }
        public TransactionType TransactionType { get; private set; }
        #endregion

        #region Constructors
        public Transaction(decimal amount, TransactionType type)
        {
            TransactionType = type;
            Amount = amount;
            DateOfTrans = DateTime.Today;
        }
        #endregion

        #region Methods
        public bool IsDeposit { get => TransactionType == TransactionType.Deposit; }
        public bool IsWithdraw { get => TransactionType == TransactionType.Withdraw; }
        #endregion
    }
}
