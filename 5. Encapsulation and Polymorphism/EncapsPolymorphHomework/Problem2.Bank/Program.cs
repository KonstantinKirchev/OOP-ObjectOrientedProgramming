using System;
using System.Collections.Generic;
using Problem2.Bank.Accounts;
using Problem2.Bank.Customers;

namespace Problem2.Bank
{
    class Program
    {
        static void Main()
        {
            var pesho = new Individual("Pesho", "8203212279");
            var company1 = new Company("Bulgar Gas", "BG3235GT");
            var kosta = new Individual("Konstantin", "9502205478");

            var accounts = new List<Account>()
            {
                new DepositAccount(pesho,21345m, 0.035),
                new LoanAccount(company1, 254876.45m, 0.023),
                new MortgageAccount(kosta, 23450m, 0.046)
            };

            foreach (var account in accounts)
            {
                if (account is DepositAccount)
                {
                    var depositAccount = (DepositAccount) account;
                    depositAccount.WithDraw(1000m);
                    depositAccount.Deposit(150m);
                }

                if (account is MortgageAccount)
                {
                    var mortgageAccount = account as MortgageAccount;
                    mortgageAccount.Deposit(2000m);
                }

                if (account is LoanAccount)
                {
                    var loanAccount = account as LoanAccount;
                    loanAccount.Deposit(3600m);
                }

                Console.WriteLine("Account balance is {0:F2} lv.", account.Balance);
                Console.WriteLine("The calculated interest is {0:F2} lv.", account.CalculateInterest(3));
            }
        }
    }
}
