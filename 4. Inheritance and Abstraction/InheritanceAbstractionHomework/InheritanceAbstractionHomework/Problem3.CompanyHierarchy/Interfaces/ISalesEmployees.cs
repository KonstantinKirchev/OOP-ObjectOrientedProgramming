using System.Collections.Generic;
using Problem3.CompanyHierarchy.Persons.Employees;

namespace Problem3.CompanyHierarchy.Interfaces
{
    public interface ISalesEmployees
    {
        ICollection<Sale> Sales { get; set; }
    }
}
