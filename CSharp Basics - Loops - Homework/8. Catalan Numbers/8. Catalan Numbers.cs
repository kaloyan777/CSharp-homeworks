using System;
using System.Numerics;

namespace _8.Catalan_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program to calculate the nth Catalan number by given n (1 < n < 100).

            Console.Write("N = ");
            int number = int.Parse(Console.ReadLine());

            int factorial = 1;
            int result = 1;

            for (int i = 1; i <= number * 2; i++)
            {
                if (i <= number)
                {
                    factorial *= i;
                }
                if (i >= number + 2)
                {
                    result *= i;
                }
            }
            Console.WriteLine("The Nth number ot Catalan's is: {0}", result / factorial);



            //ex 2:
            Console.WriteLine("\n---EXAMPLE 2---\n");

            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());

            int num = 2 * n;
            int denom = n;

            int denomResult = 1;
            int numResult = 1;
            result = 0;

            for (int i = 0; i < n - 1; i++)
            {
                numResult *= num;
                num--;
                denomResult *= denom;
                denom--;
            }
            result = numResult / denomResult;
            Console.WriteLine("Nth num of Cat: " + result);



            //ex 3
            //...ot sajta na knigata:

            Console.WriteLine("---EXAMPLE 3---");
            n = int.Parse(Console.ReadLine());

            double C;

            BigInteger n2Factoriаl = 1;
            BigInteger nFactoriаl = 1;
            BigInteger n1Factoriаl = 1;

            for (int i = 1; i <= 2 * n; i++)
            {
                n2Factoriаl *= i;
            }
            for (int i = 1; i <= n; i++)
            {
                nFactoriаl *= i;
            }
            n1Factoriаl = nFactoriаl * (n + 1);

            C = (double)n2Factoriаl / ((double)n1Factoriаl * (double)nFactoriаl);
            Console.WriteLine(C);

        }
    }
}