using System;

namespace _5.The_Biggest_of_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that finds the biggest of three numbers.

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            Console.Write("Biggest num is: ");
            if (a >= b && a >= c)
            {
                Console.WriteLine(a);
            }
            else if (b >= a && b >= c)
            {
                Console.WriteLine(b);
            }
            else if (c >= a && c >= b)
            {
                Console.WriteLine(c);
            }
            if (a == b && a == c)
            {
                Console.WriteLine("numbers are equal");
            }
        }
    }
}