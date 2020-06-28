using System;

namespace Classes
{
    public class Person
    {
        public string Name;

        public void Introduce(string to){
            Console.WriteLine("Hi {0}, I am {1}.", to, Name);
        }

        public static Person Parse(string str)
        {
            var person = new Person();
            person.Name = str;
            return person;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------- First Method ----------");
            var person = new Person();
            person.Name = "Ajay";
            person.Introduce("Vijay");
            Console.WriteLine();

            Console.WriteLine("---------- Second Method ----------");
            var p = Person.Parse("Ajay");
            p.Introduce("Bhavana");
        }
    }
}
