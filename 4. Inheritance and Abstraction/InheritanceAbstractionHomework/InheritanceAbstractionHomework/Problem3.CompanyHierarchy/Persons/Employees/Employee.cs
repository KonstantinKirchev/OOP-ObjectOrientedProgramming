using System;
using Problem3.CompanyHierarchy.Enums;
using Problem3.CompanyHierarchy.Interfaces;

namespace Problem3.CompanyHierarchy.Persons.Employees
{
    public abstract class Employee : Person, IEmployee
    {
        private decimal salary;

        protected Employee(int id, string firstname, string lastname, decimal salary, Department depatment) 
            : base(id, firstname, lastname)
        {
            this.Salary = salary;
            this.Department = depatment;
        }

        public decimal Salary
        {
            get
            {
                return this.salary;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Salary cannot be negative.");
                }

                this.salary = value;
            }
        }

        public Department Department { get; set; }
    }
}
