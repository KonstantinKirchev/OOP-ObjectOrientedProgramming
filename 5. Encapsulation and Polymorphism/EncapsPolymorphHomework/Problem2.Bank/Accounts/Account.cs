using System;
using Problem2.Bank.Customers;
using Problem2.Bank.Interfaces;

namespace Problem2.Bank.Accounts
{
    public abstract class Account : IAccount
    {
        private Customer customer;
        private decimal balance;
        private double interestRate;

        protected Account(Customer customer, decimal balance, double interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public Customer Customer { get; }

        public decimal Balance
        {
            get { return this.balance; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("value", "Balance cannot be negative.");
                }

                this.balance = value;
            }
        }

        public double InterestRate
        {
            get { return this.interestRate; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("value", "Interest rate cannot be negative.");
                }

                this.interestRate = value;
            }
        }

        public virtual decimal CalculateInterest(int months)
        {
            return this.Balance * (decimal)(1 + InterestRate * months);
        }
    }
}
