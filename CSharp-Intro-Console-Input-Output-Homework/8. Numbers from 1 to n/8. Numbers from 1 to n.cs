using System;

namespace _8.Numbers_from_1_to_n
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], 
            //each on a single line. Note that you may need to use a for-loop. 

            Console.Write("Enter an int: ");

            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }

            //example 2:
            Console.WriteLine("Choose start and end: ");

            int start = int.Parse(Console.ReadLine()); //Choose a number to start printing the numbers from it, 
            int end = int.Parse(Console.ReadLine());   //until it reaches this border.

            int counter = 0;
            while (counter != end)
            {
                counter++;
                Console.WriteLine(counter);
            }
        }
    }
}
