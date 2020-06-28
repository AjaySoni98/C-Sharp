using System;
using System.Collections.Generic;

namespace GenericInterfaceDemo
{
    public class Flower : IComparable
    {
        public string name;
        public int age;

        public int CompareTo(object obj)
        {
            Flower f1 = (Flower)obj;
            return this.age.CompareTo(f1.age);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Flower> flist = new List<Flower>();
            flist.Add(new Flower { name = "F1", age = 20});
            flist.Add(new Flower { name = "F2", age = 10});
            flist.Add(new Flower { name = "F3", age = 30});
            flist.Add(new Flower { name = "F5", age = 5});
            flist.Add(new Flower { name = "F4", age = 50});

            flist.Sort();

            foreach(Flower f in flist)
            {
                System.Console.WriteLine("Name: " +f.name+" Age: "+f.age);
            }
        }
    }
}
