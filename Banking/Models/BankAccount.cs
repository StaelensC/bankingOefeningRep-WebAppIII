using System;
using System.Collections.Generic;

namespace Banking.Models
{
    public class BankAccount
    {
        #region Fields
        private string _accountNumber;
        private IList<Transaction> _transactions;
        #endregion

        #region Properties
        public string AccountNumber { get => _accountNumber; private set => _accountNumber = value; }
        public decimal Balance { get; set; }
        public int NumberOfTransactions => _transactions.Count;
        #endregion

        #region Constructors
        public BankAccount(string accountNumber)
        {
            AccountNumber = accountNumber;
            Balance = decimal.Zero;
            _transactions = new List<Transaction>();
        }
        #endregion

        #region Methods
        public void Deposit(decimal amount) {
            _transactions.Add(new Transaction(amount, TransactionType.Deposit));
            Balance += amount;
        }

        public virtual void Withdraw(decimal amount) {
            _transactions.Add(new Transaction(amount, TransactionType.Withdraw));
            Balance -= amount;
        }

        public IEnumerable<Transaction> GetTransactions(DateTime? from, DateTime? till) {
            IList<Transaction> transList = new List<Transaction>();
            foreach (Transaction t in _transactions)
                if (t.DateOfTrans >= from && t.DateOfTrans <= till)
                    transList.Add(t);
            return transList;
        }

        public override string ToString()
        {
            return $"{AccountNumber} - {Balance}";
        }

        public override bool Equals(object obj)
        {
            BankAccount account = obj as BankAccount;
            if (account == null) return false;
            return AccountNumber == account.AccountNumber;
        }

        public override int GetHashCode()
        {
            return AccountNumber?.GetHashCode() ?? 0;
        }

        #endregion

    }
}
