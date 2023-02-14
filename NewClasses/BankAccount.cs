using System;
using System.Collections.Generic;
using NewClasses;
namespace NewClasses { 

public class BankAccount
{
    private static int accountNumberSeed = 123456789;
    private List<Transactions> allTransactions = new List<Transactions>();
    public string Number { get; }
    public string Owner { get; set; }
    public decimal Balance { get; }

    public void MakeDeposit(decimal amount, DateTime date, string note)
    {
    }

    public void MakeWithdrawal(decimal amount, DateTime date, string note)
    {
    }

    public BankAccount(string name, decimal initialBalance)
    {
        Owner = name;
        Balance = initialBalance;
        this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;

    }
}
}