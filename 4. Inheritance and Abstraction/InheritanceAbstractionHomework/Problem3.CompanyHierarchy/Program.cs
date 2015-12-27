using System;
using System.Collections.Generic;
using Problem3.CompanyHierarchy.Enums;
using Problem3.CompanyHierarchy.Persons;
using Problem3.CompanyHierarchy.Persons.Customers;
using Problem3.CompanyHierarchy.Persons.Employees;

namespace Problem3.CompanyHierarchy
{
    class Program
    {
        static void Main()
        {
            var manager = new Manager(3, "Ivan", "Ivanov", 5350.00m, Department.Sales);
            var vanq = new SalesEmployee(4, "Vanq", "Karlova", 3210.00m, Department.Sales);
            var katq = new SalesEmployee(5, "Katq", "Kircheva", 3180.00m, Department.Sales);
            var sale1 = new Sale("Phone", DateTime.Parse("2015-04-8"), 250.00m);
            var sale2 = new Sale("Laptop", DateTime.Parse("2015-04-9"), 1150.00m);

            vanq.Sales.Add(sale1);
            katq.Sales.Add(sale2);

            manager.Employees.Add(vanq);
            manager.Employees.Add(katq);

            var developer = new Developer(6, "Konstantin", "Kirchev", 6350.00m, Department.Production);
            var project1 = new Project("Revolution",DateTime.Parse("2015-03-21"), "the best project ever");
            var project2 = new Project("Online Market", DateTime.Parse("2015-06-12"), "very promissing project", State.Closed);

            developer.Projects.Add(project1);
            developer.Projects.Add(project2);

            var persons = new List<Person>
            {
                new Customer(1, "Pesho", "Peshev", 1200.00m),
                new Customer(2, "Gosho", "Goshev", 2100.00m),
                manager,
                vanq,
                katq,
                developer
            };

            foreach (var person in persons)
            {
                Console.WriteLine(person);
            }
        }
    }
}
