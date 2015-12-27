using Problem2.Bank.Customers;

namespace Problem2.Bank.Interfaces
{
    public interface IAccount
    {
        Customer Customer { get; }

        decimal Balance { get; }

        double InterestRate { get; }

        decimal CalculateInterest(int months);
    }
}
