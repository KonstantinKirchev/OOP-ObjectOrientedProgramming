using Problem3.CompanyHierarchy.Enums;

namespace Problem3.CompanyHierarchy.Interfaces
{
    public interface IEmployee
    {
        decimal Salary { get; set; }
        Department Department { get; set; }
    }
}
