using System;

namespace Numeric_StringIndexers
{
    class Program
    {
        static void Main(string[] args)
        {
            var emp1 = new Employee();
            emp1[0] = 1000;
            emp1[1] = "Ajay";
            emp1[2] = 21;

            System.Console.WriteLine("Using numeric indexers.");
            for(int i=0;i<emp1.Length;i++)
            {
                System.Console.WriteLine(emp1[i]);
            }

            System.Console.WriteLine();

            var emp2 = new Employee();
            emp2["Id"] = 1001;
            emp2["Name"] = "Vijay";
            emp2["Age"] = 23;

            System.Console.WriteLine("Using string indexers.");
            System.Console.WriteLine(emp2["Id"]);
            System.Console.WriteLine(emp2["Name"]);
            System.Console.WriteLine(emp2["Age"]);
        }
    }
}
