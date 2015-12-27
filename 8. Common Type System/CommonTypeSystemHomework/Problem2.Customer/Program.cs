namespace Problem2.Customer
{
    using System;

    static class Program
    {
        static void Main()
        {
            var payment1 = new Payment("Laptop", 1235.65m);
            var payment2 = new Payment("Samsung", 535.15m);
            var customer1 = new Customer("Konstantin", "Konstantinov", "Kirchev", "8203213465", "Petko Karavelov bl.76", 
                "+359 899 947 852", "konstantin1230@gmail.bg", CustomerType.Diamond, payment1, payment2);
            var customer2 = new Customer("Ivan", "Ivanov", "Petrov", "2302113465", "Solunska N38B",
                "+359 889 277 262", "ivan10@gmail.bg", CustomerType.Diamond, payment1, payment2);
            var payment3 = new Payment("Toshiba", 341.23m);

            customer2.Payments.Add(payment3);

            Console.WriteLine(customer1 != customer2);
            Console.WriteLine(customer1);
            Console.WriteLine(customer2);
            
        }
    }
}
