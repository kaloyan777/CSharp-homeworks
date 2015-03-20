using System;

namespace _13.Exchange_Bits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type in an integer to modify it's bits: ");
            uint number = uint.Parse(Console.ReadLine()); //If int, try 1234567890.
            //int number = 54;

            Console.Write("Binary representation of number: ");
            Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
            Console.WriteLine("The number is: " + number);

            uint maskLeft = number << 21; //Moving 3,4,5 bits on 24,25,26's places.
            Console.Write("The binary repr. of number after 3,4,5 bits moved to 24,25,26's place: " + '\n');
            Console.WriteLine(Convert.ToString(maskLeft, 2).PadLeft(32, '0'));
            Console.WriteLine("The number is: " + maskLeft);

            uint maskRight = number >> 21; //Moving 24,25,26 bits on 3,4,5's places.
            Console.Write("The binary repr. of number after bits 24,25,26 moved to 3,4,5's place: " + '\n');
            Console.WriteLine(Convert.ToString(maskRight, 2).PadLeft(32, '0'));
            Console.WriteLine("The number is: " + maskRight);
        }
    }
}
