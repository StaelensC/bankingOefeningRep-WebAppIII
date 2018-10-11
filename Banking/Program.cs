using System;
using System.Linq;
using Banking.Models;

namespace Banking
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount("123-123123-12");
            Console.WriteLine($"AccountNumber:{account.AccountNumber}");
            Console.WriteLine($"Balance:{account.Balance}");
            account.Deposit(200M);
            Console.WriteLine($"Balance after deposit of 200 euro: {account.Balance}");
            Console.WriteLine($"Number of transactions after deposit of 200 euros: {account.NumberOfTransactions}");
            account.Withdraw(100M);
            Console.WriteLine($"Balance after withdraw 100 euros: {account.Balance}");
            Console.WriteLine($"Number of transactions after withdraw of 100 euro: {account.NumberOfTransactions}");
            int aantal = (account.GetTransactions(DateTime.Today.AddDays(-2), DateTime.Today)).Count();
            Console.WriteLine($"Aantal transacties: {aantal}");

            SavingsAccount saving = new SavingsAccount("123-456789-03", 0.01M);
            Console.WriteLine($"SavingsAccount: {saving}");
            saving.Deposit(200M);
            saving.Withdraw(100M);
            saving.AddInterest();
            Console.WriteLine($"Balance savingsaccount: {saving.Balance}");

            Console.ReadKey();
        }
    }
}
