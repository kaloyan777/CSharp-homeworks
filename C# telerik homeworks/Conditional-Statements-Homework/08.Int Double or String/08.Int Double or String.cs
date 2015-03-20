using System;

namespace _08.Int_Double_or_String
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that, depending on the user's choice inputs int, double or string variable. 
            //If the variable is integer or double, increases it with 1. If the variable is string, appends "*" at its end. 
            //The program must show the value of that variable as a console output. Use switch statement.
            
            Start:
                Console.Write("Enter one of the following numbers to choose the type of data, you want to use. \n\"int\", \"double\", \"string\": ");
                    string entry = Convert.ToString(Console.ReadLine()); //int entry = int.Parse(Console.ReadLine()); //if you use this version of entry, cases must be numbers: ex.1 for int, 2 for double, 3 for string...

                switch (entry)
                {
                    case "int":
                        Console.Write("Enter an integer: ");
                        int intNumber = int.Parse(Console.ReadLine());
                        Console.WriteLine("New int number is: " + (intNumber + 1));
                        break;
                    case "double":
                        Console.Write("Enter a double number: ");
                        double doubleNumber = double.Parse(Console.ReadLine());
                        Console.WriteLine("New double number is: " + (doubleNumber + 1.00));
                        break;
                    case "string":
                        Console.Write("Enter a string: ");
                        string userString = (Console.ReadLine());
                        Console.WriteLine("New string is: " + (userString + "*"));
                        break;
                    default:
                        Console.WriteLine("Enter a valid entry!");
                        goto Start;
                        break;
                }
        }
    }
}