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

            account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
            Console.WriteLine(account.Balance);
            account.MakeDeposit(100, DateTime.Now, "Friend pay me back");
            Console.WriteLine(account.Balance);
        }
    }
}