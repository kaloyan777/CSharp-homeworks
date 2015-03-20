using System;

namespace _15.Hexadecimal_to_Decimal_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            //Using loops write a program that converts a hexadecimal integer number to its decimal form. 
            //The input is entered as string. The output should be a variable of type long. Do not use the built-in .NET functionality. 

            //И двете решения не са мои.

            string hexNumber = Console.ReadLine();
            long decNumber = 0;
            long power = 1;
            for (int i = hexNumber.Length - 1; i >= 0; i--)
            {
                int num;
                switch (hexNumber[i])
                {
                    case 'A': num = 10; break;
                    case 'B': num = 11; break;
                    case 'C': num = 12; break;
                    case 'D': num = 13; break;
                    case 'E': num = 14; break;
                    case 'F': num = 15; break;
                    default: num = (int)hexNumber[i] - 48; break;
                }
                decNumber += num * power;
                power *= 16;
            }
            Console.WriteLine(decNumber);


            //ex 2 ot sajta na knigata

            string hex = Console.ReadLine();
            int counter = 0;
            double dec = 0;
            double digit = 0;
            for (int i = hex.Length - 1; i >= 0; i--)
            {
                if (hex[i] > '0' + 9)
                {
                    digit = hex[i] - 55;
                }
                else
                {
                    digit = hex[i] - 48;
                }
                dec += digit * Math.Pow(16, counter);
                counter++;
            }
            Console.WriteLine(dec);

        }
    }
}