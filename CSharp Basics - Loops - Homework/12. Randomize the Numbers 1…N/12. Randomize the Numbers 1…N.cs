using System;

namespace _12.Randomize_the_Numbers_1_N
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order. 

            int rowsOfNumbers = int.Parse(Console.ReadLine());

            int min = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());
            Random random = new Random();

            for (int i = 1; i <= rowsOfNumbers; i++)
            {
                Console.WriteLine("Random Num: " + random.Next(min, max));
            }

            //ex 2 ot sajta na knigata

            int n = int.Parse(Console.ReadLine());
            bool[] printed = new bool[n + 1];
            Random randNumber = new Random();
            int numberToPrint;
            for (int i = 1; i <= n; i++)
            {
                numberToPrint = randNumber.Next(1, n + 1);
                if (!printed[numberToPrint])
                {
                    Console.WriteLine(numberToPrint);
                    printed[numberToPrint] = true;
                    continue;
                }
                i--;

            }
        }
    }
}