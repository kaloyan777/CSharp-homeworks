using System;

namespace _1.Numbers_from_1_to_N
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n, 
            //on a single line, separated by a space

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();



            //example 2:

            int counter = 1;
            while (counter <= n)
            {
                Console.Write(counter + " ");
                counter++;
            }
            Console.WriteLine();



            //exaple 3:

            //Start:
            //Console.Write("Start point: ");
            //int counter = int.Parse(Console.ReadLine());

            counter = 1;
            if (counter == n - n + 1)
            {
                do
                {
                    Console.Write(counter + " ");
                    counter++;
                }
                while (counter <= n);
            }

            //else
            //{
                //Console.WriteLine("Invalid start point!");
                //goto Start;
            //}
            Console.WriteLine();



            //example 4:

            int[] numbers = new int[n];
            while (numbers.Length == n) //moje i bez while, prosto si igraq s ciklite..dokolkoto moga 
            {
                for (int i = 0; i <= numbers.Length - 1; i++)
                {
                    numbers[i] = i + 1;   
                }
                break;
            }

            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
}