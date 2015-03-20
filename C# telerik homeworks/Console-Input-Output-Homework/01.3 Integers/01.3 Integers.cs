using System;

namespace _01._3_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number \"a\": ");
                int a = int.Parse(Console.ReadLine());
            Console.Write("Enter number \"b\": ");
                int b = int.Parse(Console.ReadLine());
            Console.Write("Enter number \"c\": ");
                int c = int.Parse(Console.ReadLine());

                int sumABC = a + b + c;
                Console.WriteLine();
                Console.WriteLine("Sum of a,b,c: " + sumABC);
        }
    }
}
