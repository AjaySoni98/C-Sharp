using System;

namespace c_
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 12;
            int num2 = 18;
            float pi = 3.14f;
            float sum = num1 + num2 + pi;
            char oneLetter = 'A';
            string firstName = "Ajay";
            bool doIExist = true;

            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("An alphabet: " + oneLetter);
            Console.WriteLine("Name: " + firstName);
            Console.WriteLine("Do I Exist: " + doIExist);

            System.Console.WriteLine();
            System.Console.WriteLine("---------- Determining type of variables ----------");
            System.Console.WriteLine();

            var num3 = 15;
            var lastName = "Soni";

            System.Console.WriteLine("Type of num3 found using 'var.GetType()' is: " + num3.GetType());
            System.Console.WriteLine("type of lastName found using 'var.GetType()' is: " + lastName.GetType());

            System.Console.WriteLine();
            System.Console.WriteLine("---------- Conversion (Casting) ----------");
            System.Console.WriteLine();

            string num4 = "10";
            float num5 = 22.53f;

            int num4Converted = Convert.ToInt32(num4);
            int num4Parsed = int.Parse(num4);
            var num5Converted = (int)num5;

            System.Console.WriteLine("Converted number represented as string to integer using 'Convert.ToInt32()': " + num4Converted);
            System.Console.WriteLine("Converted number represented as string to integer using 'int.Parse()': " + num4Parsed);
            System.Console.WriteLine("Converted number 22.53 (float) to int using casting '(int) num5': " + num5Converted);
            System.Console.WriteLine("If explicit casting using '(int) num1' etc doesn't work use implicit conversion 'Convert.ToInt(num1)' etc");

            System.Console.WriteLine();
            System.Console.WriteLine("---------- Handling Exceptions ----------");
            System.Console.WriteLine();

            System.Console.WriteLine("Now 'Convert.ToByte()' only works for numbers between 0 to 255. Hence if a number in 0>number>255 is tried to be converted into byte it will throw exception. We will handle this exception.");
            System.Console.WriteLine();

            try
            {
                var number = "1234";
                byte numberByte = Convert.ToByte(number);
            }
            catch (System.Exception)
            {
                System.Console.WriteLine("The value you're trying to convert to byte is either less than 0 or greater than 255.");
            }

            System.Console.WriteLine();
            System.Console.WriteLine("---------- Taking Input -----------");
            System.Console.WriteLine();
            Console.Write("Enter your Country name: ");
            var country = System.Console.ReadLine();
            System.Console.WriteLine("Country: {0}", country);
        }
    }
}