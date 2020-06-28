using System;
using System.Collections;

namespace ArrayListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var aryList = new ArrayList();
            aryList.Add("Japan");
            aryList.Add("Korea");
            aryList.Add("China");

            foreach(IEnumerable obj in aryList)
            {
                System.Console.WriteLine(obj);
            }

            System.Console.WriteLine();
            System.Console.WriteLine(aryList.Count);

            System.Console.WriteLine();
            System.Console.WriteLine("First element: {0}", aryList[0]);
            
            System.Console.WriteLine();
            aryList.Remove("China");
            aryList.RemoveAt(1);

            foreach(IEnumerable obj in aryList)
            {
                System.Console.WriteLine(obj);
            }

            System.Console.WriteLine();
            System.Console.WriteLine("Checking if China in aryList: {0}", aryList.Contains("China"));
        }
    }
}
