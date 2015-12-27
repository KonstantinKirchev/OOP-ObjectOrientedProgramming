using System.Collections.Generic;
using Problem3.CompanyHierarchy.Persons.Employees;

namespace Problem3.CompanyHierarchy.Interfaces
{
    public interface IDeveloper
    {
        ICollection<Project> Projects { get; set; }
    }
}
