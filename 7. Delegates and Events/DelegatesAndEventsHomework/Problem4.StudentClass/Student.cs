namespace Problem4.StudentClass
{
    using System.Reflection;

    public delegate void OnPropertyChangeEventHandler(Student sender, PropertyChangedEventArgs args);

    public class Student
    {
        public event OnPropertyChangeEventHandler PropertyChanged;

        private string name;

        private int age;

        public Student(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (this.PropertyChanged != null)
                {
                    this.PropertyChanged(this,
                        new PropertyChangedEventArgs(this.name, value, "Name"));
                }

                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (this.PropertyChanged != null)
                {
                    this.PropertyChanged(this,
                        new PropertyChangedEventArgs(this.age.ToString(), value.ToString(), "Age"));
                }

                this.age = value;
            }
        }
    }
}
