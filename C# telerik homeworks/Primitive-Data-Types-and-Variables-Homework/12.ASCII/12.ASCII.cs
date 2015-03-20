using System;

namespace _12.ASCII
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            for (int i = 0; i < 257; i++)
            {
                Console.WriteLine((char)i);
            }

            //int counter = 0;
            
            //for (counter = 0; counter < 255; counter++)
            //{
            //    char symbol = Convert.ToChar(counter);
            //    Console.WriteLine(symbol);
            //}
        }
    }
}
