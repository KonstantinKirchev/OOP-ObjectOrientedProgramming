using Problem2.Bank.Customers;
using Problem2.Bank.Interfaces;

namespace Problem2.Bank.Accounts
{
    public class MortgageAccount : Account, IDeposit
    {
        public MortgageAccount(Customer customer, decimal balance, double interestRate) 
            : base(customer, balance, interestRate)
        {
        }

        public void Deposit(decimal money)
        {
            this.Balance += money;
        }

        public override decimal CalculateInterest(int months)
        {
            if (months < 13 && (this.Customer is Company))
            {
                return base.CalculateInterest(months) / 2;
            }
            else if (months < 7 && (this.Customer is Individual))
            {
                return 0;
            }
            return base.CalculateInterest(months);
        }
    }
}
