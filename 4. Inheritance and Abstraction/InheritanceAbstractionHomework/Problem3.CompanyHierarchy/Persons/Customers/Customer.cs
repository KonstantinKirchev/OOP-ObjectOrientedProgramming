using System;
using Problem3.CompanyHierarchy.Interfaces;

namespace Problem3.CompanyHierarchy.Persons.Customers
{
    public class Customer : Person, ICustomer
    {
        private decimal netPurchaseAmount;

        public Customer(int id, string firstname, string lastname, decimal netPurchaseAmount) 
            : base(id, firstname, lastname)
        {
            this.NetPurchaseAmount = netPurchaseAmount;
        }

        public decimal NetPurchaseAmount
        {
            get { return this.netPurchaseAmount; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Net purchase amount cannot be negative.");
                }

                this.netPurchaseAmount = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} has {3:F2} lv.", GetType().Name, Firstname, Lastname, NetPurchaseAmount);
        }
    }
}
