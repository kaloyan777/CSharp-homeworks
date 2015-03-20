using System;

namespace _05.If_The_Bit_3_Is_1_or_0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an Integer to check if bit 3 (counting from 0) is 1 or 0: ");
            int number = int.Parse(Console.ReadLine());

            int i = 1;
            int numMask = i << 3;

            Console.WriteLine("The bit is: " + ((numMask & number) != 0 ? 1 : 0));
        }
    }
}
