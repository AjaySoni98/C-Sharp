using System;

namespace C__Case_Study__Requirement_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product("101", "Laptop", 45000, 'E');
            System.Console.WriteLine(p.PrintProduct());
            System.Console.WriteLine(p.ReadProductDetails("101,Hand Sanitiser,125.00,A", "101,Mask,60.00,M"));
        }
    }
}
