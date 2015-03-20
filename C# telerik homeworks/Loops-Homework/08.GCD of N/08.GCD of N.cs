using System;

namespace _08.GCD_of_N
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that calculates the greatest common divisor (GCD) of given two numbers. 
            //Use the Euclidean algorithm (find it in Internet).

            Console.WriteLine("Finding the Greatest Common Divisor [GCD]."); 
            Console.WriteLine(new String('-', 50));
            
            //Input
            Console.Write("A = ");
                int a = int.Parse(Console.ReadLine());
            Console.Write("B = ");
                int b = int.Parse(Console.ReadLine());

                int c = 0;

            if (a == 0)
            {
                Console.WriteLine("Desision: " + b);
            }
            else if (b == 0)
            {
                Console.WriteLine("Desision: " + a);
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
                    Console.WriteLine(new String('=', 30));
                System.Console.WriteLine("GCD: " + c + '\n');
                    Console.Beep();
            }
        }
    }
}