using System;
using System.Collections.Generic;
using System.Text;

namespace Banking.Models
{
    public class SavingsAccount: BankAccount
    {
        #region Fields
        protected const decimal WithdrawCost = 0.25M;
        public decimal InterestRate { get; private set; } 
        #endregion

        #region Constructors
        public SavingsAccount(string bankAccountNumber, decimal interestRate) : base(bankAccountNumber)
        {
            InterestRate = interestRate;
        }
        #endregion

        #region Methods
        public void AddInterest()
        {
            Deposit(Balance * InterestRate);
        }

        public override void Withdraw(decimal amount)
        {
            base.Withdraw(amount);
            base.Withdraw(WithdrawCost);
        }

        #endregion
    }
}
