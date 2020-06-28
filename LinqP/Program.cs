using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqP
{
    class Program
    {
        public class People{
            public string name;
            public int exp;
            public string job;

            public People(string name, int exp, string job){
                this.name = name;
                this.exp = exp;
                this.job = job;
            }
        }
        static void Main(string[] args)
        {
            System.Console.WriteLine("Linq queries return Enumerables.");
            System.Console.WriteLine();

            List<People> peopleList = new List<People>();
            peopleList.Add(new People("Ajay", 10, "Teacher"));
            peopleList.Add(new People("Ajay", 7, "Athlete"));
            peopleList.Add(new People("Mitesh", 5, "Mechanic"));
            peopleList.Add(new People("Raj", 4, "Scientist"));
            peopleList.Add(new People("Vijay", 11, "Astronaut"));
            peopleList.Add(new People("Reena", 7, "Doctor"));
            peopleList.Add(new People("Bhavya", 2, "Engineer"));
            peopleList.Add(new People("Adith", 6, "Engineer"));
            peopleList.Add(new People("Smith", 7, "Mechanic"));
            peopleList.Add(new People("Ankur", 6, "Doctor"));

            System.Console.WriteLine("Printing whole list.");
            foreach(People x in peopleList){
                Console.WriteLine(x.name+" "+Convert.ToString(x.exp)+" "+x.job);
            }
            System.Console.WriteLine();

            System.Console.WriteLine("-------------------------SORTING SHIT WITH LINQ-------------------------");
            System.Console.WriteLine();

            System.Console.WriteLine("Sorting list w.r.t. the name.");
            System.Console.WriteLine();
            peopleList = peopleList.OrderBy(x => x.name).ToList();
            System.Console.WriteLine("Printing whole list.");
            foreach(People x in peopleList){
                Console.WriteLine(x.name+" "+Convert.ToString(x.exp)+" "+x.job);
            }
            System.Console.WriteLine();

            System.Console.WriteLine("Sorting list w.r.t. the name and exp.");
            System.Console.WriteLine();
            peopleList = peopleList.OrderBy(x => x.name).ThenBy(x => x.exp).ToList();
            System.Console.WriteLine("Printing whole list.");
            foreach(People x in peopleList){
                Console.WriteLine(x.name+" "+Convert.ToString(x.exp)+" "+x.job);
            }
            System.Console.WriteLine();

            System.Console.WriteLine("-------------------------FILTERING SHIT WITH LINQ-------------------------");
            System.Console.WriteLine();

            System.Console.WriteLine("Filtering upon condition of exp is atleast 5.");
            System.Console.WriteLine();
            peopleList = peopleList.Where(x => x.exp >= 5).ToList();
            foreach(People x in peopleList){
                Console.WriteLine(x.name+" "+Convert.ToString(x.exp)+" "+x.job);
            }
            System.Console.WriteLine();

            System.Console.WriteLine("Filtering upon condition of exp is atleast 5 and job is either Mechanic, Doctor or Engineer.");
            System.Console.WriteLine();
            peopleList = peopleList.Where(x => x.exp >= 5 && (x.job == "Mechanic" | x.job == "Engineer" | x.job == "Doctor")).ToList();
            foreach(People x in peopleList){
                Console.WriteLine(x.name+" "+Convert.ToString(x.exp)+" "+x.job);
            }
            System.Console.WriteLine();

            System.Console.WriteLine("Sorting and filtering using 'from' etc linq keywords");
            System.Console.WriteLine();
            string[] emails = new string[6] {"ajay@gmail.com", "bhavana@hotmail.com", "vijay@gmail.com", "raj03@gmail.com", "reena@yahoo.com", "bhavya223444@hotmail.com"};

            var filteredEmails = from email in emails
            where email.Contains("@gmail.com")
            orderby email descending
            select email;
            foreach(string email in filteredEmails){
                System.Console.Write(email+" ");
            }
            System.Console.WriteLine();

            System.Console.WriteLine("-------------------------CALCULATING/ OPERATING SHIT WITH LINQ-------------------------");
            System.Console.WriteLine();

            System.Console.WriteLine("Sum of exp of all.");
            int totalExp = peopleList.Sum(x => x.exp);
            System.Console.WriteLine(totalExp);
            System.Console.WriteLine();

            System.Console.WriteLine("Sum of exp of all of those with job of Doctor or Engineer");
            totalExp = peopleList.Where(x => x.job == "Doctor" | x.job == "Engineer").Sum(x => x.exp);
            System.Console.WriteLine(totalExp);
            System.Console.WriteLine();
        }
    }
}
