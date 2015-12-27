using System;

namespace Problem1.HumanStudentAndWorker
{
    public class Student : Human, IComparable<Student>
    {
        private string facultyNumber; 

        public Student(string firstname, string lastname, string facultyNumber) 
            : base(firstname, lastname)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber
        {
            get { return this.facultyNumber; }
            set
            {
                if (value.Length < 5 || value.Length > 10)
                {
                    throw new ArgumentOutOfRangeException("The faculty number should be [5..10] characters long.");
                }

                this.facultyNumber = value;
            }
        }

        public int CompareTo(Student other)
        {
            return FacultyNumber.CompareTo(other.FacultyNumber);
        }
    }
}
