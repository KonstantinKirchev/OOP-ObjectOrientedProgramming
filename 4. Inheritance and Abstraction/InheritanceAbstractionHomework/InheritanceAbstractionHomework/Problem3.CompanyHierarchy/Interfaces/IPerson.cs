using System;

namespace Problem3.CompanyHierarchy.Interfaces
{
    public interface IPerson
    {
        int Id { get; set; }

        string Firstname { get; set; }

        string Lastname { get; set; }
    }
}
