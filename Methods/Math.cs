using System;

namespace Methods
{
    
    public class Math
    {
        public int n1;
        public int n2;

        public void Add()
        {
            System.Console.WriteLine("Addition: {0}", (this.n1+this.n2));
        }

        public void Subtract()
        {
            System.Console.WriteLine("Subtraction: {0}", (this.n1-this.n2));
        }

        public void SumOfNums(params int[] num)
        {
            int sum = 0;
            foreach(var number in num)
            {
                sum = sum + number;
            }
            //alternative
            //sum = num.Sum(x => x);
            System.Console.WriteLine("Sum: " + sum);
        }
    }
}