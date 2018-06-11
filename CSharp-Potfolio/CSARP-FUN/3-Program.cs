using System;
namespace Classes {

    class Program {
        static void Main (string[] args) {
            var customer = new Customer;
            customer.Id = 1;
            customer.Name = "Kara";
            Console.WriteLine(customer.Id);
        Console.WriteLine(customer.Name);
            Console.ReadKey ();
        }
    }
}