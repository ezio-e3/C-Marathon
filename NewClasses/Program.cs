using System;

namespace NewClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Yawenam Ahadzie", 40000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");
            var account2 = new BankAccount("Edinam Ahadzie", 800000);
            Console.WriteLine($"Account {account2.Number} was created for {account2.Owner} with {account2.Balance} initial balance.");

            account.MakeWithdrawal(700, DateTime.Now, "Rent payment");
            Console.WriteLine(account.Balance);
            account.MakeDeposit(1100, DateTime.Now, "Friend pay me back");
            Console.WriteLine(account.Balance);

            // Test that the initial balances must be positive.
            BankAccount invalidAccount;
            try
            {
                invalidAccount = new BankAccount("invalid", 55);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Exception caught creating account with negative balance");
                Console.WriteLine(e.ToString());
                return;
            }
            var history = account.GetAccountHistory();
            Console.WriteLine(history);
        }
    }
}