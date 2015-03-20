using System;

namespace _9.Sum_of_n_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. 
            //Note that you may need to use a for-loop. 

            Console.Write("Enter an int: ");
            int n = int.Parse(Console.ReadLine());
            //int numbers;
            int Sum = 0;

            for (int i = 1; i <= n; i++)
            {
                Sum += int.Parse(Console.ReadLine()); //u could try this too: Sum = Sum + numbers = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\nSum = " + Sum);
        }
    }
}
