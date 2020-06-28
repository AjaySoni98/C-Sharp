using System.Collections.Generic;

namespace Constructors
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;

        public Customer()
        {
            System.Console.WriteLine("---------- Initializing Orders to an empty List. ----------");
            System.Console.WriteLine();
            System.Console.WriteLine("We initialize this Orders list here because we want to automatically create a Order object to store customer orders when ever a new customer object is created.");
            System.Console.WriteLine();
            System.Console.WriteLine("But this creates problem when any other user defined constructors from below are called. To overcome see line 33.");
            System.Console.WriteLine();
            System.Console.WriteLine("What it does is calls the argument less constructor which initializes the list.");
            Orders = new List<Order>();
            System.Console.WriteLine();

            System.Console.WriteLine("---------- In user - defined constructor ----------");
            System.Console.Write("Enter Id: ");
            int id = System.Convert.ToInt32(System.Console.ReadLine());
            System.Console.Write("Enter Name: ");
            string name = System.Console.ReadLine();
            System.Console.WriteLine("--------------------");
            System.Console.WriteLine("Id: " + id);
            System.Console.WriteLine("Name: " + name);
            System.Console.WriteLine();
        }

        public Customer(int id)
            :this()
        {
            this.Id = id;
            System.Console.WriteLine("---------- In user - defined constructor w/ 1 argument (name) ----------");
            System.Console.WriteLine("Id: " + this.Id);
            System.Console.WriteLine();
        }
        
        public Customer(int id, string name)
        {
            this.Id = id;
            this.Name = name;
            System.Console.WriteLine("---------- In user - defined constructor w/ 2 argument (name, Id) ----------");
            System.Console.WriteLine("Name: " + this.Name);
            System.Console.WriteLine("Id: " + this.Id);
            System.Console.WriteLine();
            System.Console.WriteLine("Now see EfficientConstructors.cs for one more demo.");
        }
    }
}