using System;

namespace _10.IsBit1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 35; // 00100011 
            int p = 6;
            int i = 1; // 00000001 
            int mask = i << p; // Move the 1st bit left by p positions 

            // If i & mask are positive then the p-th bit of n is 1 
            Console.WriteLine((n & mask) != 0 ? 1 + "- true" : 0 + " - false");  //Comparing n & mask; ((If the result != 0, Then the 6-th bit = 1), (If = 0, Then the 6-th bit = 0)).
        }
    }
}
