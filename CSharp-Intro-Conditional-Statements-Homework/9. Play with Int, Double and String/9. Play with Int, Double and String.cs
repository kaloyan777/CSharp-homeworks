using System;

namespace _9.Play_with_Int__Double_and_String
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that, depending on the user’s choice, inputs an int, double or string variable. 
            //If the variable is int or double, the program increases it by one. 
            //If the variable is a string, the program appends "*" at the end.
            //Print the result at the console. Use switch statement.

            Start:
            Console.WriteLine("Enter correct choice of input\n1 = int\n2 = double\n3 = string");
            Console.Write("Your Choise: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1: Console.Write("Pls enter an int: "); 
                    int num = int.Parse(Console.ReadLine());
                    Console.WriteLine("Modified: " + (num + 1));
                    break;

                case 2: Console.Write("Pls enter a double: ");
                    double Num = double.Parse(Console.ReadLine());
                    Console.WriteLine("Modified: " + (Num + 1));
                    break;

                case 3: Console.Write("Pls enter a string: ");
                    string text = Console.ReadLine();
                    Console.WriteLine("Modified : " + text + "*");
                    break;

                default: goto Start;
            }

            //example 2:
            Console.WriteLine("\n---EXAMPLE 2---");

            Start1:
            int input = int.Parse(Console.ReadLine());

            if (input == 1)
            {
                Console.Write("Int: ");
                int inputAsInt = int.Parse(Console.ReadLine());
                Console.WriteLine(inputAsInt + 1);
            }
            if (input == 2)
            {
                Console.Write("Double: ");
                double inputAsDouble = double.Parse(Console.ReadLine());
                Console.WriteLine(inputAsDouble + 1);
            }
            if (input == 3)
            {
                Console.Write("String: ");
                string inputAsString = Convert.ToString(Console.ReadLine());
                Console.WriteLine(inputAsString + "*");
            }
            if (input != 1 && input != 2 && input != 3)
            {
                Console.Write("Error, invalid input, try again: ");
                goto Start1;
            }
        }
    }
}