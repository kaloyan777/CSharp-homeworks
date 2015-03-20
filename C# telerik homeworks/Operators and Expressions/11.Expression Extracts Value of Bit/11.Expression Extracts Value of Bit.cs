using System;

namespace _11.Expression_Extracts_Value_of_Bit
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 5;
            int b = 2;

            int mask = 1 << b;
            int iMask = i & mask;
            int bBit = iMask >> b;

            Console.WriteLine("i=" + i + "; b=" + b + " -> value=" + bBit + ".");
        }
    }
}
