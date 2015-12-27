using Problem3.CompanyHierarchy.Enums;

namespace Problem3.CompanyHierarchy.Persons.Employees
{
    public abstract class RegularEmployee : Employee
    {
        protected RegularEmployee(int id, string firstname, string lastname, decimal salary, Department depatment) 
            : base(id, firstname, lastname, salary, depatment)
        {
        }
    }
}
