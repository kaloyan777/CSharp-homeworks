using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads from the console a positive integer number N 
            //(N < 20) and outputs a matrix like the following: N = 3, N = 4.


            //...The Basic Code:

            //int n = int.Parse(Console.ReadLine());
            //if(n < 20)
            //{
                //for (int i = 1; i <= n; i++)
                //{
                //    for (int j = i; j < n + i; j++)
                //    {
                //        Console.Write("{0,2} ", j);
                //    }
                //    Console.WriteLine();
                //}
            //}


            //...Matrix 1:
            Start:
            Console.Write("N for Matrix1: ");
            int n = int.Parse(Console.ReadLine());

            if(n < 20)
            {
                Console.WriteLine(new String('=', 56));
                for (int rowN = 1; rowN <= n; rowN++)
                {
                    for (int colN = rowN; colN < (n + rowN); colN++)
                    {
                        Console.Write("{0,2} ", colN);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            else
	        {
                Console.WriteLine("N must be < 20!");
                goto Start;
	        }

            //...Matrix 2:
            Start2:
            Console.Write("N for Matrix2: ");
            int m = int.Parse(Console.ReadLine());

            if (m < 20)
            {
                Console.WriteLine(new String('=', 56));
                for (int rowM = 1; rowM <= m; rowM++)
                {
                    for (int colM = rowM; colM < (m + rowM); colM++)
                    {
                        Console.Write("{0,2} ", colM);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("M must be < 20!");
                goto Start2;
            }
        }
    }
}
