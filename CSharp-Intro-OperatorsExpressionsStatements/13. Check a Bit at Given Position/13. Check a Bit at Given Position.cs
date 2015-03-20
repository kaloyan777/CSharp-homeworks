using System;

namespace _13.Check_a_Bit_at_Given_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a Boolean expression that returns if the bit at position p 
            //(counting from 0, starting from the right) in given integer number n has value of 1.

            //example 1:
            Console.WriteLine("---EXAMPLE 1---");

            //Write an expression that extracts from a given integer i the value of a given bit number b. Example: i=5; b=2  value=1
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Enter position: ");
            int bitNumber = int.Parse(Console.ReadLine());

            int mask = 1 << bitNumber;
            int numberAndMask = number & mask;
            int bit = numberAndMask >> bitNumber;

            Console.WriteLine("i = {0}, b = {1}, value -> {2}", number, bitNumber, bit);  



            //example 2:
            Console.WriteLine("\n---EXAMPLE 2---");

            int i = 5;
            int b = 2;

            mask = 1 << b;
            bit = (i & mask) >> b;

            Console.WriteLine(bit);



            //example 3:
            Console.WriteLine("\n---EXAMPLE 3---");

            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            bool isItOne = (n & (1 << p)) > 0;
            Console.WriteLine(isItOne); //true/false

            //Console.WriteLine((n & (1 << p)) > 0 ? true: false);
        }
    }
}
