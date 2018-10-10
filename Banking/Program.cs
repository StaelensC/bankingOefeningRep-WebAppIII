using System;
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
            account.Withdraw(100M);
            Console.WriteLine($"Balance after withdraw 100 euros: {account.Balance}");
            Console.ReadKey();
        }
    }
}
