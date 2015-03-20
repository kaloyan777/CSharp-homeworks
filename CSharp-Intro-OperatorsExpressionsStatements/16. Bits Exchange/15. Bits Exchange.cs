using System;

namespace _16.Bits_Exchange
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

            //example 1:
            Console.WriteLine("---EXAMPLE 1---");

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



            //example 2:
            Console.WriteLine("\n---EXAMPLE 2---");

            Console.Write("Enter the number: ");
            int n = int.Parse(Console.ReadLine());

            int mask = 7;
            int firstBits = (n & (mask << 3)) >> 3;
            int secondBits = (n & (mask << 24)) >> 24;

            n = n & ~(mask << 3);
            n = n & ~(mask << 24) >> 24;
            n = n | (firstBits << 24);
            n = n | (secondBits << 3);

            Console.WriteLine(n);
        }
    }
}