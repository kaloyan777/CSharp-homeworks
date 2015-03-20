using System;

namespace _05.The_Greater_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("First num: ");
                int firstNum = int.Parse(Console.ReadLine());
            Console.Write("Second num: ");
                int secondNum = int.Parse(Console.ReadLine());
                
                
                    Console.WriteLine("Greater number is: " + Math.Max(firstNum, secondNum));
               sole.WriteLine("\nTry again, numbers must not be equal, first < second!"); //else
        }
    }
}
