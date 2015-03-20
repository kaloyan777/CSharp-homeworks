using System;

namespace _3.Min__Max__Sum_Average_N_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads from the console a sequence of n integer numbers and returns the minimal, 
            //the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point). 
            //The input starts by the number n (alone in a line) followed by n lines, each holding an integer number. 

            //example 1:

            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            float average = 0;

            int minN = int.MaxValue;
            int maxN = int.MinValue;

            int number = 0;

            for (int i = 0; i < n; i++)
            {
                number = int.Parse(Console.ReadLine());
                sum += number;

                if (number > maxN)
                {
                    maxN = number;
                }
                if (number < minN)
                {
                    minN = number;
                }
            }
            average = (float)sum / n;
            Console.WriteLine("\nmin: " + minN);
            Console.WriteLine("max: " + maxN);
            Console.WriteLine("average: {0:F2}", average);
            Console.WriteLine("sum: " + sum + "\n\n---Example 2---\n");



            //example 2:

            Console.Write("How many numbers of sequence = ");
            int members = int.Parse(Console.ReadLine());

            int biggest = 0;
            int smallest = 0;

            sum = 0;
            average = 0;

            for (int i = 1; i <= members; i++)
            {
                Console.Write("Number{0} = ", i);
                number = int.Parse(Console.ReadLine());

                sum += number;

                if (i == 0)
                {
                    biggest = smallest = number;
                }
                else if (biggest < number)
                {
                    biggest = number;
                }
                else if (smallest > number)
                {
                    smallest = number;
                }
            }

            average = (float)sum / members;
            Console.WriteLine("\nBiggest = {0}, Smallest = {1}", biggest, smallest + "\nSum = " + sum);
            Console.WriteLine("Average = {0:F2} {1}", average, "\n");
        }
    }
}