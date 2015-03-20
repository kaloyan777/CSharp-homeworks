using System;

namespace _04.Is_Third_Digit_7
{
    class Program
    {
        static void Main(string[] args)
        {
//////////..1..
            int number = 12703;
            bool isSeven = ((number / 100) % 10) == 7; //True
            Console.WriteLine(isSeven);

//////////..2..
            int a = 1703;
            int b = a / 100; //When dividing by 100, the result is 17.03, but because "b" is int, it can not contain a value with floating point, so it shows 17!!
            int c = b % 10;  //"c" assignes value of "b", but not to the whole result! Dividing 17 by 10, the result is 1 with reminder 7. 

            if (c == 7)
            {   
                Console.WriteLine("Third digit from right to left is 7.");
            }
            else
            {
                Console.WriteLine("3rd digit is not 7.");
            }
        }
    }
}
