using System;

namespace _11.Numbers_in_Interval_Dividable_by_Given_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads two positive integer numbers and prints 
            //how many numbers p exist between them such that the reminder of the division by 5 is 0.

            Console.Write("Beginning: ");
                int n = int.Parse(Console.ReadLine());
            Console.Write("End: ");
                int N = int.Parse(Console.ReadLine());

                int counter = 0;

            for (int i = n; i <= N; i++)
            {
                if (i % 5 == 0)
                {
                    counter++;
                }
            }
            Console.WriteLine("\n{0} numbers, such that\nthe reminder of the division\nby 5 is 0 are there between {1} and {2}.\n"
                , counter, n, N);

        }
    }
}
