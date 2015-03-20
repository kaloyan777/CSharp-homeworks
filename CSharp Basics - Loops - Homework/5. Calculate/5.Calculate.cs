using System;

namespace _5.Calculate
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/xn. 
            //Use only one loop. Print the result with 5 digits after the decimal point.

            Console.Write("n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("x: ");
            int x = int.Parse(Console.ReadLine());

            float sum = 1; //sum e 1, za6toto v uslovieto e poso4eno 1 +...predi formulite da zapo4nat da se prepovtarqt.
            float factorial = 1;

            int originalX = x;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("\n========{0} cycle:", i);

                Console.WriteLine("fact: " + (factorial *= i));
                Console.WriteLine("sum: " + (sum += factorial / x));
                Console.WriteLine("next x: " + (x *= originalX));
            }
            Console.WriteLine("\nS = {0 :F5}{1}", sum, "\n");
        }
    }
}