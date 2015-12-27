using Problem2.Bank.Customers;
using Problem2.Bank.Interfaces;

namespace Problem2.Bank.Accounts
{
    public class LoanAccount : Account, IDeposit
    {
        public LoanAccount(Customer customer, decimal balance, double interestRate) 
            : base(customer, balance, interestRate)
        {
        }

        public void Deposit(decimal money)
        {
            this.Balance += money;
        }

        public override decimal CalculateInterest(int months)
        {
            if ((months < 4 && (this.Customer is Individual)) || (months < 3 && (this.Customer is Company)))
            {
                return 0;
            }
            return base.CalculateInterest(months);
        }
    }
}
