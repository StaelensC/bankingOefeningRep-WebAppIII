namespace Banking.Models
{
    public class BankAccount
    {
        #region Fields
        private string _accountNumber;
        #endregion

        #region Properties
        public string AccountNumber { get => _accountNumber; private set => _accountNumber = value; }
        public decimal Balance { get; set; }
        #endregion

        #region Constructors
        public BankAccount(string accountNumber)
        {
            AccountNumber = accountNumber;
            Balance = decimal.Zero;
        }
        #endregion

        #region Methods
        public void Deposit(decimal amount) {
            Balance += amount;
        }
        public virtual void Withdraw(decimal amount) {
            Balance -= amount;
        }
        #endregion

    }
}
