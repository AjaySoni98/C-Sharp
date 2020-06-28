using System;

namespace MultiDim_JaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Multi dimensional Array.");

            string[,] studentDetails = new string[5,2];

            System.Console.WriteLine("Gathering details");
            System.Console.WriteLine();
            for(int i=0;i<5;i++){
                for(int j=0;j<2;j++){
                    System.Console.Write("Enter Name: ");
                    studentDetails[i,j] = Console.ReadLine();
                }
            }

            System.Console.WriteLine();
            System.Console.WriteLine("Printing.");
            System.Console.WriteLine();
            for(int i=0;i<5;i++){
                for(int j=0;j<2;j++){
                    System.Console.Write(studentDetails[i,j] + " ");
                }
                System.Console.WriteLine();
            }

            System.Console.WriteLine();
            System.Console.WriteLine("Jagged Array");

            int[][] marks = new int[3][]; //this indicates this jagged array can have atmost 3 rows and atleast 0 columns.
            System.Console.WriteLine();
            System.Console.WriteLine("In above created jagged array we can have different number of columns for each row.");
            System.Console.WriteLine();

            for(int i=0;i<3;i++)
            {
                Console.Write("Enter number of columns for this row {0}: ", i);
                var cols = int.Parse(Console.ReadLine());
                marks[i] = new int[cols];
                for(int j=0;j<cols;j++)
                {
                    Console.Write("Enter Marks or RegNo if first entry for row: ");
                    marks[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            System.Console.WriteLine();
            System.Console.WriteLine("Printing");
            System.Console.WriteLine();

            foreach(int[] row in marks)
            {
                foreach(int val in row){
                    System.Console.Write(val + " ");
                }
                System.Console.WriteLine();
            }
        }
    }
}
