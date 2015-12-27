using System;

namespace Problem2.Bank.Customers
{
    public class Individual : Customer
    {
        private string uniqueIdNumber;

        public Individual(string name, string uniqueIdNumber) 
            : base(name)
        {
            this.UniqueIdNumber = uniqueIdNumber;
        }

        public string UniqueIdNumber
        {
            get
            {
                return this.uniqueIdNumber;
            }
            set
            {
                if (value.Length != 10)
                {
                    throw new ArgumentException("Id number should be exactly 10 characters long.");
                }

                this.uniqueIdNumber = value;
            }
        }
    }
}
