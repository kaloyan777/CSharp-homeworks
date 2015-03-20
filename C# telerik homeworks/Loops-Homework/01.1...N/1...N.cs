using System;

namespace _01._1._._.N
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that prints all the numbers from 1 to N.

//............Basic:

            int n = int.Parse(Console.ReadLine()); //Ex. n = 10.
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }

//..........Example 1:

            //Console.Write("Enter n: ");
            //int n = int.Parse(Console.ReadLine()); //Ex. n = 10.
            //int number = 1;

            //for (int i = 1; i <= n; i++)
            //{
            //    Console.WriteLine(number++); //if here "number" is not incremented, the result will be 10 times "1".    
            //}

//..........Example 2:

            //Console.Write("Enter n: ");
            //int n = int.Parse(Console.ReadLine()); //Ex. n = 10.
            //int number = 1; //if number++; is outside Console.WL, then "int number = 0;"!

            //while (number <= n) //if "int number = 0;", "(number < n)"!
            //{
            //    //number++; //if "int number = 0;", "number++;" here!
            //    Console.WriteLine(number++); //if "int number = 0;", "Console.WL(number);"!
            //}

//..........Example 3:

            //Console.Write("Enter n: ");
            //    int n = int.Parse(Console.ReadLine()); //Ex. n = 10.
            //    int number = 1;

            //do
            //{
            //    Console.WriteLine(number++);
            //} while (number <= n);
        }
    }
}
