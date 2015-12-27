using System.Collections.Generic;
using Problem3.CompanyHierarchy.Enums;
using Problem3.CompanyHierarchy.Interfaces;

namespace Problem3.CompanyHierarchy.Persons.Employees
{
    public class Developer : RegularEmployee, IDeveloper
    {
        private ICollection<Project> projects;
         
        public Developer(int id, string firstname, string lastname, decimal salary, Department depatment) 
            : base(id, firstname, lastname, salary, depatment)
        {
            this.Projects = new HashSet<Project>();
        }

        public ICollection<Project> Projects { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} works in department {3}. His salary is {4:F2} lv. His projects are: {5}"
                , GetType().Name, Firstname, Lastname, Department, Salary, string.Join(", ",Projects));
        }
    }
}
