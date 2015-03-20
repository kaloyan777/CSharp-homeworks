using System;

namespace _6.Calculate_N__divided_by_K_
{
    class Program
    {
        static void Main(string[] args)
        {
        //Write a program that calculates n! / k! for given n and k (1 < k < n < 100). Use only one loop.

            //Напишете програма, която пресмята N!/K! за дадени N и K (1<K<N).
        //Умножете числата от K+1 до N.
        //Факториел е функция на естествено число n (n∈ℕ0), равна на произведението на първите n естествени числа. Например:

            //5! = 5*4*3*2*1 = 120
        //10! = 10*9*8*7*...*2*1 = 3628800
        //0! се брои за 1, 0! = 1

            StartFromN:

            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());

            if (n < 100)
            {
            StartFromK:

                Console.Write("K = ");
                int k = int.Parse(Console.ReadLine());

                if (k > 1 && k < n)
                {
                    int factorial = 1;
                    for (int i = k + 1; i <= n; i++)
                    {
                        factorial = i * factorial;
                    }
                    Console.WriteLine("\nResult: " + factorial + "\n");
                }
                else
                {
                    Console.WriteLine("Invalid Input K!");
                    goto StartFromK;
                }
            }
            else
            {
                Console.WriteLine("Invalid N!");
                goto StartFromN;
            }
        }
    }
}