using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----- Demonstrating Contuructors and method Overloading (Same method name but different arguments -----)");
            Console.WriteLine();
            
            var customer1 = new Customer();
            var customer2 = new Customer(1001);
            var customer3 = new Customer(1002, "Vijay");

            var effcustomer1 = new EfficientConstructors();
            var effcustomer2 = new EfficientConstructors("Ajay");
            var effcustomer3 = new EfficientConstructors("Vijay", 20);
        }
    }
}
