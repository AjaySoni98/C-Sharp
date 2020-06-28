using System;
using System.Threading;

namespace ThreadingDemo
{
    class Program
    {
        public static void delayPrint(){
            System.Console.WriteLine("Function called.");
            int sleep = 5000; //5s
            System.Console.WriteLine($"Now waiting for { sleep }ms. i.e. 5s");
            Thread.Sleep(sleep);
            System.Console.WriteLine("Done");
        }

        static void Main(string[] args)
        {
            ThreadStart ts = new ThreadStart(delayPrint);
            Thread child = new Thread(ts);
            child.Start();
        }
    }
}
