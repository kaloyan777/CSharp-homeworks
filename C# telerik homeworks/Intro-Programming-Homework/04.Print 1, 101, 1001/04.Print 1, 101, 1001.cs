using System;

namespace _04.Print_1__101__1001
{
    class Program
    {
        static void Main(string[] args)
        {
            int one = 1;
            byte hundredOne = 101;
            decimal oneOOone = 1001;

            //Version 1
            Console.WriteLine("Printing numbers 1, 101, 1001:" + "\n" + one + "\n" + hundredOne + "\n" + oneOOone);

            //Version 2
            Console.WriteLine(1);
            Console.WriteLine(101);
            Console.WriteLine(1001);
        }
    }
}
