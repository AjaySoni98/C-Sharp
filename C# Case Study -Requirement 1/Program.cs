using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace C__Case_Study__Requirement_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p=new Product("Laptop",45000.00, 'E');
            System.Console.WriteLine(p.getProductDetails());
        }
    }
}
