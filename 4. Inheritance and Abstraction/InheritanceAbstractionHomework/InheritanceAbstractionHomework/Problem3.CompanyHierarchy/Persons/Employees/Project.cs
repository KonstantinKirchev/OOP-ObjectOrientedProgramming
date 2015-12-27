using System;
using Problem3.CompanyHierarchy.Enums;
using Problem3.CompanyHierarchy.Interfaces;

namespace Problem3.CompanyHierarchy.Persons.Employees
{
    public class Project : IProject
    {
        private string projectName;
        private DateTime projectStartDate;
        private string details;
        private State state;

        public Project(string projectName, DateTime projectSatrtDate, string details, State state = State.Open)
        {
            this.ProjectName = projectName;
            this.ProjectStartDate = projectSatrtDate;
            this.Details = details;
            this.State = state;
        }

        public string ProjectName
        {
            get { return this.projectName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Product name cannot be null or empty.");
                }

                this.projectName = value;
            }
        }

        public DateTime ProjectStartDate
        {
            get { return this.projectStartDate; }
            set
            {
                if (projectStartDate > DateTime.Now)
                {
                    throw new ArgumentOutOfRangeException("Project start date cannot be later than today.");
                }

                this.projectStartDate = value;
            }
        }

        public string Details
        {
            get { return this.details; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Details cannot be null or empty.");
                }

                this.details = value;
            }
        }

        public State State { get; set; }

        public State CloseProject()
        {
            return State.Closed;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} start on {2:yy-MMM-dd ddd}. It's {3}. Right now it is {4}"
                , GetType().Name, ProjectName, ProjectStartDate, Details, State);
        }
    }
}
