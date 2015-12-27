using System.Collections.Generic;
using System.Linq;
using Problem3.CompanyHierarchy.Enums;
using Problem3.CompanyHierarchy.Interfaces;

namespace Problem3.CompanyHierarchy.Persons.Employees
{
    class Manager : Employee, IManager
    {
        private ICollection<Employee> employees;
         
        public Manager(int id, string firstname, string lastname, decimal salary, Department depatment) 
            : base(id, firstname, lastname, salary, depatment)
        {
            this.Employees = new HashSet<Employee>();
        }

        public ICollection<Employee> Employees { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} works in department {3}. His salary is {4:F2} lv. His employees are: {5}"
                , GetType().Name, Firstname, Lastname, Department, Salary, string.Join(", ", Employees.Select(e => e.Firstname)));
        }
    }
}
