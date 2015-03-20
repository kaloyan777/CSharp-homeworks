using System;

namespace _13.Binary_to_Decimal_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Using loops write a program that converts a binary integer number to its decimal form. The input is entered as string. 
            //    The output should be a variable of type long. Do not use the built-in .NET functionality. 

            //    И двете решения не са мои.

            Console.Write("Enter number to turn binary to its decimal: ");
            string binNumber = Console.ReadLine();
            long decNumber = 0;
            int power = 1;

            for (int i = binNumber.Length - 1; i >= 0; i--)
            {
                int num = binNumber[i] - 48;
                decNumber += num * power;
                power *= 2;
            }
            Console.WriteLine(decNumber);

            //ex 2 ot sajta na knigata

            string number;
            int dec = 0;
            number = Console.ReadLine();

            for (int i = number.Length - 1, j = 0; i >= 0; i--, j++)
            {
                if (number[i] == '1')
                {
                    dec = dec | (1 << j);
                }
            }
            Console.WriteLine(dec);
        }
    }
}