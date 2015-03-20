using System;

namespace _9.Matrix_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix like in the examples below.
            //Use two nested loops

            Console.WriteLine("n = ");
            int n = int.Parse(Console.ReadLine());

            for (int h = 0; h < n; h++)
            {
                for (int i = 1; i <= n; i++)
                {
                    Console.Write("{0}  ", i + h); //{0, -2}
                }
                Console.WriteLine();
            }
        }
    }
}
