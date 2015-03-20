using System;

namespace _4.Number_Comparer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that gets two numbers from the console and prints the greater of them. 
            //Try to implement this without if statements.

            //example 1:

            Console.WriteLine("Enter A and B: ");
            int a = int.Parse(Console.ReadLine()),
                b = int.Parse(Console.ReadLine());

            bool check = a >= b;
            Console.WriteLine("Is A >= B? - " + check); //True or False
           

            //example 2:

            Console.Write("\n---First num: ");
                int firstNum = int.Parse(Console.ReadLine());
            Console.Write("---Second num: ");
                int secondNum = int.Parse(Console.ReadLine());
                
                while (firstNum != secondNum) //while the numbers are NOT equal:
                {
                    Console.WriteLine("---Greater number is: " + Math.Max(firstNum, secondNum) + "\n");
                    break;
                }
                while (firstNum == secondNum) //while() + break; = if(), So if(number are equal):
                {
                    Console.WriteLine("---Numbers are equal.\n");
                    break;
                }

            //example 3:

                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                int temp = a >= b ? a : b; 
                Console.WriteLine("Bigger: " + temp + "\n");
        }
    }
}
