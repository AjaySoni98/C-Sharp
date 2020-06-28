using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = new Math();
            sum.n1 = 17;
            sum.n2 = 94;
            sum.Add();

            var sub = new Math();
            sub.n1 = 26;
            sub.n2 = 12;
            sub.Subtract();

            var alSum = new Math();
            alSum.SumOfNums(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
        }
    }
}
