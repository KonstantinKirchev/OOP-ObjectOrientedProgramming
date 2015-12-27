using Problem2.Bank.Customers;
using Problem2.Bank.Interfaces;

namespace Problem2.Bank.Accounts
{
    public class DepositAccount : Account, IDeposit, IWithDraw
    {
        public DepositAccount(Customer customer, decimal balance, double interestRate) 
            : base(customer, balance, interestRate)
        {
        }

        public void Deposit(decimal money)
        {
            this.Balance += money;
        }

        public void WithDraw(decimal money)
        {
            if (this.Balance > money)
            {
                this.Balance -= money;
            }         
        }

        public override decimal CalculateInterest(int months)
        {
            if (Balance > 0 && Balance < 1000)
            {
                return 0;
            }
            return base.CalculateInterest(months);
        }
    }
}
