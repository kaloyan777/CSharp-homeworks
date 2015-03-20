using System;

class Fibonacci
{
    static void Main()
    {
        for (int a = 0, b = 1; b < 1000000000; a += b, b += a)
        {
            Console.Write(" , " + a + "," + b);
        }
    }
}