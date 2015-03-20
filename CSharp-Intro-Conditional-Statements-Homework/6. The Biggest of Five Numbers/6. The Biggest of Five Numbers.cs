using System;

namespace _6.The_Biggest_of_Five_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that finds the biggest of five numbers by using only five if statements. 

            int a = int.Parse(Console.ReadLine()),
                b = int.Parse(Console.ReadLine()),
                c = int.Parse(Console.ReadLine()),
                d = int.Parse(Console.ReadLine()),
                e = int.Parse(Console.ReadLine());

            bool check = (a == b && a == c && a == d && a == e);

            while (check)
            {
                Console.WriteLine("numbers are equal");
                break;
            }

            while (!check)
            {
                Console.Write("biggest number is: ");
                if (a >= b && a >= c && a >= d && a >= e) //1. if a...
                {
                    Console.WriteLine(a);
                }
                if (b >= a && b >= c && b >= d && b >= e) //2. if b...
                {
                    Console.WriteLine(b);
                }
                if (c >= a && c >= b && c >= d && c >= e) //3. if c...
                {
                    Console.WriteLine(c);
                }
                if (d >= a && d >= b && d >= c && d >= e) //4. if d...
                {
                    Console.WriteLine(d);
                }
                if (e >= a && e >= c && e >= d && e >= b) //5. if e...
                {
                    Console.WriteLine(e);
                }
                break;
            }


        }
    }
}