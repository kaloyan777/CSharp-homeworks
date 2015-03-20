using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Print_the_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Console.OutputEncoding = Encoding.Unicode;

            for (int i = 0; i < 257; i++)
            {
                Console.WriteLine((char)i);
            }

            //example 2:

            int counter = 0;

            for (counter = 0; counter < 255; counter++)
            {
                char symbol = Convert.ToChar(counter);
                Console.WriteLine(symbol);
            }
        }
    }
}