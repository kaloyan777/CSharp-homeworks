using System;
using System.Numerics;

namespace _7.Calculate_N__divided_by__K_._N_K___
{
    class Program
    {
        static void Main(string[] args)
        {
            //In combinatorics, the number of ways to choose k different members out of a group of n different elements 
            //(also known as the number of combinations) is calculated by the following formula.

            //For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards. 
            //Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). 
            //Try to use only two loops.

            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            int factorialN = 1;
            int factorialK = 1;

            int count = 1;

            if (1 < k && k < n && n < 100)
            {
                for (int i = n - k + 1; i <= n; i++)
                {
                    factorialN *= i;
                    if (count <= k)
                    {
                        factorialK *= count;
                        count++;
                    }
                }
                Console.WriteLine("n! / (k! * (n-k)!) = " + factorialN / factorialK);
            }
            else
            {
                Console.WriteLine("Invalid Input!");
            }
        }
    }
}