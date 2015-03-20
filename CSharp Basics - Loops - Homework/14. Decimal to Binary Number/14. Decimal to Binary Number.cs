using System;

namespace _14.Decimal_to_Binary_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            //Using loops write a program that converts an integer number to its binary representation. 
            //The input is entered as long. The output should be a variable of type string. Do not use the built-in .NET functionality.

            //Решението не е мое.

            long decNumber = long.Parse(Console.ReadLine());
            string binNumber = "";
            while (decNumber != 0)
            {
                int remain = (int)decNumber % 2;
                decNumber /= 2;
                binNumber = remain + binNumber;
            }
            Console.WriteLine(binNumber);

        }
    }
}