using System.Collections.Generic;
using System.Linq;
using Problem3.CompanyHierarchy.Enums;
using Problem3.CompanyHierarchy.Interfaces;

namespace Problem3.CompanyHierarchy.Persons.Employees
{
    public class SalesEmployee : RegularEmployee, ISalesEmployees
    {
        private ICollection<Sale> sales;
         
        public SalesEmployee(int id, string firstname, string lastname, decimal salary, Department depatment) 
            : base(id, firstname, lastname, salary, depatment)
        {
            this.Sales = new HashSet<Sale>();
        }

        public ICollection<Sale> Sales { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} works in department {3}. Her salary is {4:F2} lv. Her sales are: {5}"
                , GetType().Name, Firstname, Lastname, Department, Salary, string.Join(", ", Sales.Select(s=>s.ProductName)));
        }
    }
}
