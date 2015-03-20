using System;

namespace _17.Calculate_GCD
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that calculates the greatest common divisor (GCD) of given two integers a and b. 
            //Use the Euclidean algorithm (find it in Internet). 

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int remain = 1;

            while (remain != 0)
            {
                remain = a % b;
                a = b;
                b = remain;
            }
            Console.WriteLine(Math.Abs(a));


            //ex 2:

            Console.Write("a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = int.Parse(Console.ReadLine());

            int c = 0;

            if (a == 0)
            {
                Console.WriteLine(b);
            }
            else if (b == 0)
            {
                Console.WriteLine(a);
            }
            else
            {
                while (b != 0)
                {
                    if (a > b)
                    {
                        c = b;
                        b = a % b;
                    }
                    else
                    {
                        c = a;
                        b = b % a;
                    }
                }
                Console.WriteLine(c);
            }
        }
    }
}

            //ex 3: sajta na knigata

            //    static int FindGreatestCommonDivisor(int a, int b)
            //{
            //    while (a != 0 && b != 0)
            //    {
            //        if (a > b)
            //            a %= b;
            //        else
            //            b %= a;
            //    }
            //    if (a == 0)
            //        return b;
            //    else
            //        return a;
            //}

            //static void Main(string[] args)
            //{
            //    int n = int.Parse(Console.ReadLine());
            //    int k = int.Parse(Console.ReadLine());
            //    int greatestCommonDivisor;
            //    greatestCommonDivisor = FindGreatestCommonDivisor(n, k); 
            //    Console.WriteLine(greatestCommonDivisor);
            //}

            //}
      