using System;
using System.Collections.Generic;
using System.Text;
using NewClasses;
namespace NewClasses {

    public class BankAccount
    {
        private static int accountNumberSeed = 123456789;
        private List<Transactions> allTransactions = new List<Transactions>();
        public string Number { get; }
        public string Owner { get; set; }
        private decimal _balance;
        public decimal Balance {
            get
            {
                decimal _balance = 0;
                foreach (var item in allTransactions)
                {
                    _balance += item.Amount;
                }
                return _balance;
            }
            set {
                _balance = value;
            }
        }
            

    public void MakeDeposit(decimal amount, DateTime date, string note)
    {
            if (amount <= 0) {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
            }
            var deposit = new Transactions(amount, date, note);
            allTransactions.Add(deposit);
    }

    public void MakeWithdrawal(decimal amount, DateTime date, string note)
    {
            if (amount <= 0) {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
            }
            if (Balance - amount < 0) {
                throw new InvalidOperationException("Not sufficient funds for the withdrawal");
            }
            var withdrawal = new Transactions(-amount, date, note);
            allTransactions.Add(withdrawal);
    }

        public String GetAccountHistory() {
            var report = new StringBuilder();
            decimal balance = 0;
            report.AppendLine("Date\t\tAmount\tBalance\tNote");
            foreach (var item in allTransactions) {
                balance += item.Amount;
                report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t{balance}\t{item.Notes}");
                
            }
            return report.ToString();
        }

    public BankAccount(string name, decimal initialBalance)
    {
        Owner = name;
        Balance = initialBalance;
        this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;
            MakeDeposit(initialBalance, DateTime.Now, "Initial Balance");
    }
}
}