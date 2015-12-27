using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem1.HumanStudentAndWorker
{
    class Program
    {
        static void Main()
        {
            var students = new List<Student>()
            {
                new Student("Pesho", "Peshev", "gdf7678742"),
                new Student("Gosho", "Goshev", "ad56547gdf"),
                new Student("Anna", "Topolska", "gh5547dgh4"),
                new Student("Konstantin", "Kirchev", "dg54fga365"),
                new Student("Dido", "Didov", "4354543gfd"),
                new Student("Rali", "Ray", "133fd64g6n"),
                new Student("Misho", "Mishev", "fd3fd46665"),
                new Student("Stoqn", "Stoev", "bfjhgk3451"),
                new Student("Ivan", "Ivanov", "hgf54hf867"),
                new Student("Georgi", "Georgiev", "7hfg5436jh")
            };

            var sortedStudents = students.OrderBy(s => s.FacultyNumber);

            foreach (var student in sortedStudents)
            {
                Console.WriteLine(student.FacultyNumber);
            }

            Console.WriteLine();

            var workers = new List<Worker>()
            {
                new Worker("Pesho", "Peshev", 1250.50m, 8.5),
                new Worker("Gosho", "Zlatistiq", 1120.50m, 8),
                new Worker("Magi", "Zelqzkova", 1040m, 7.5),
                new Worker("Todor", "Popov", 950.90m, 8.7),
                new Worker("Mark", "Tven", 1000m, 9.5),
                new Worker("Todor", "Jivkov", 1350.50m, 10.5),
                new Worker("Bate", "Boiko", 1400.55m, 9.1),
                new Worker("Nadeto", "Mihailova", 1210.10m, 7.4),
                new Worker("Don", "Didon", 1290.20m, 9.8),
                new Worker("Krisko", "Kristalniq", 1450.30m, 10.1),

            };

            var sortedWorkers = workers.OrderByDescending(w => w.MoneyPerHour());

            foreach (var worker in sortedWorkers)
            {
                Console.WriteLine("{0:F2}", worker.MoneyPerHour());
            }

            Console.WriteLine();

            var humans = new List<Human>()
            {
                new Student("Pesho", "Peshev", "gdf7678742"),
                new Student("Gosho", "Goshev", "ad56547gdf"),
                new Student("Anna", "Topolska", "gh5547dgh4"),
                new Student("Konstantin", "Kirchev", "dg54fga365"),
                new Student("Dido", "Didov", "4354543gfd"),
                new Student("Rali", "Ray", "133fd64g6n"),
                new Student("Misho", "Mishev", "fd3fd46665"),
                new Student("Stoqn", "Stoev", "bfjhgk3451"),
                new Student("Ivan", "Ivanov", "hgf54hf867"),
                new Student("Georgi", "Georgiev", "7hfg5436jh"),
                new Worker("Pesho", "Peshev", 1250.50m, 8.5),
                new Worker("Gosho", "Zlatistiq", 1120.50m, 8),
                new Worker("Magi", "Zelqzkova", 1040m, 7.5),
                new Worker("Todor", "Popov", 950.90m, 8.7),
                new Worker("Mark", "Tven", 1000m, 9.5),
                new Worker("Todor", "Jivkov", 1350.50m, 10.5),
                new Worker("Bate", "Boiko", 1400.55m, 9.1),
                new Worker("Nadeto", "Mihailova", 1210.10m, 7.4),
                new Worker("Don", "Didon", 1290.20m, 9.8),
                new Worker("Krisko", "Kristalniq", 1450.30m, 10.1)
            };

            var sortedHumans = humans.OrderBy(h => h.Firstname).ThenBy(h => h.Lastname);

            foreach (var human in sortedHumans)
            {
                Console.WriteLine("{0} {1}", human.Firstname, human.Lastname);
            }
        }
    }
}
