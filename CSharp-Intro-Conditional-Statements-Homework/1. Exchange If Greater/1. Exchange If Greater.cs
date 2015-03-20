using System;

namespace _1.Exchange_If_Greater
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write an if-statement that takes two integer variables a and b and exchanges their values 
            //if the first one is greater than the second one. As a result print the values a and b, separated by a space

            Console.Write("a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("b: ");
            int b = int.Parse(Console.ReadLine());

            int c = 0; //temporary variable to take the value of "a"

            if (a > b) //if the first one is greater than the second one
            {
                Console.WriteLine("A before: {0}, B before: {1}", a, b);
                c = a;
                a = b;
                b = c;
                Console.WriteLine("A after: {0}, B after: {1}", a, b);
            }
            else
            {
                Console.WriteLine("A is smaller than B.");
            }
        }
    }
}