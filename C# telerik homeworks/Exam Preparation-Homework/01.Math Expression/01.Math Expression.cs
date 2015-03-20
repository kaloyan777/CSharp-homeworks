using System;
using System.Threading;
using System.Globalization;

namespace _01.Math_Expression
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.WriteLine(">>Calculating formula<<");
            //...Input:
            Console.Write(" - N: ");
                decimal N = decimal.Parse(Console.ReadLine());
            Console.Write(" - M: ");
                decimal M = decimal.Parse(Console.ReadLine());
            Console.Write(" - P: ");
                decimal P = decimal.Parse(Console.ReadLine());
            
            //...Calculating solution:
                decimal Result = 

                ((N * N + (1 / (M * P)) + 1337)  /  (N - 128.523123123M * P)  +  (decimal)Math.Sin((int)M % 180));

            //...Output:
            System.Console.WriteLine(" > Result: {0:0.000000}\n", Result);
        }
    }
}