using System;

namespace MockQuestion
{
    public abstract class Employee
    {
        protected string name;
        protected double salary;

        public Employee(string name, double salary)
        {
            this.name=name;
            this.salary=salary;
        }

        public void Print()
        {
            System.Console.WriteLine("Name: " + this.name);
            System.Console.WriteLine("Salary: " + this.salary);
        }
    }

    public class Programmer: Employee, IIncremental
    {
        public string domain;
        public Programmer(string name, double salary, string domain)
            :base(name, salary)
        {
            this.domain=domain;
        }

        public double Increment()
        {
            return this.salary = (this.salary+(this.salary*0.1));
        }
    }

    public class Manager: Employee, IIncremental
    {
        public string teamId;
        public Manager(string name, double salary, string teamId)
            :base(name, salary)
        {
            this.teamId=teamId;
        }

        public double Increment()
        {
            return this.salary = (this.salary+(this.salary*0.5));
        }
    }

    interface IIncremental
    {
        double Increment();
    }

    class Program
    {
        static void Main(string[] args)
        {
            Programmer p1 = new Programmer("Ajay", 30000, "JAVA");
            Manager m1 = new Manager("Vijay", 50000, "JA01");
            double sP1 = p1.Increment();
            double sM1 = m1.Increment();
            p1.Print();
            m1.Print();
        }
    }
}