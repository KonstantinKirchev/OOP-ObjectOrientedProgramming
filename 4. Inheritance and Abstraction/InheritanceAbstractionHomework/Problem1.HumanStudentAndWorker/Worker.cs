using System;

namespace Problem1.HumanStudentAndWorker
{
    public class Worker : Human
    {
        private decimal weekSalary;
        private double workHoursPerDay;

        public Worker(string firstname, string lastname, decimal weekSalary, double workHoursPerDay) 
            : base(firstname, lastname)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary
        {
            get { return this.weekSalary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Week salary cannot be negative.");
                }

                this.weekSalary = value;
            }
        }

        public double WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Work hours per day cannot be negative.");
                }

                this.workHoursPerDay = value;
            }
        }

        public decimal MoneyPerHour()
        {
            var salaryPerHour = (WeekSalary / 5) / (decimal)WorkHoursPerDay;
            return salaryPerHour;
        }
    }
}
