using System;

namespace _11.Exchange_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;

            int temporary = a; //5

            b = temporary; //5(a)
            a = b; //5(b)

            Console.WriteLine(a + b); //5+5 = 10
        }
    }
}
