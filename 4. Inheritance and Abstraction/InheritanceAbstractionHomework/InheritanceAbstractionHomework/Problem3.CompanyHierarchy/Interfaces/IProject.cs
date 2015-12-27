using System;
using Problem3.CompanyHierarchy.Enums;

namespace Problem3.CompanyHierarchy.Interfaces
{
    public interface IProject
    {
        string ProjectName { get; set; }

        DateTime ProjectStartDate { get; set; }

        string Details { get; set; }

        State State { get; set; }

        State CloseProject();
    }
}
