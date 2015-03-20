using System;
using System.Numerics;

namespace _06.Calculates_the_sum_S
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that, for a given two integer numbers N and X, calculates the sumS = 1 + 1!/X + 2!/X^2 + … + N!/X^N.

            Console.Write("Enter N: ");
            double n = int.Parse(Console.ReadLine());
            Console.Write("Enter X: ");
            double x = int.Parse(Console.ReadLine());
            Console.WriteLine(new String('-', 50));

            double factorialOne = 1;
            for (int i = 1; i <= 1; i++) //1!
            {
                factorialOne *= i;
            }
            double firstValue = (factorialOne / x); //(1!/X)
            Console.WriteLine("- 1st Value of the equation [1!/X]: " + firstValue);


            double factorialTwo = 1;
            for (int j = 1; j <= 2; j++) //2!
            {
                factorialTwo *= j;
            }
            double Xx = Math.Pow(x, x);
            double secondValue = (factorialTwo / Xx); //(2!/X*X)
            Console.WriteLine("- 2nd value of the equation [2!/X*X]: " + secondValue);


            double factorialN = 1;
            for (int a = 1; a <= n; a++)
            {
                factorialN *= a;
            }
            double Xn = Math.Pow(x, n);
            double thirdValue = (factorialN / Xn); //(N!/X^N)
            Console.WriteLine("- 3rd value of the equation [N!/X^N]: " + thirdValue);

            Console.WriteLine(new String('=', 50));
            double sum = (1 + firstValue + secondValue + thirdValue); //S = 1 + 1!/X + 2!/X^2 + … + N!/X^N.
            Console.WriteLine("Sum S = 1 + 1!/X + 2!/X^2 + N!/X^N: " + sum + '\n');
        }
    }
}
