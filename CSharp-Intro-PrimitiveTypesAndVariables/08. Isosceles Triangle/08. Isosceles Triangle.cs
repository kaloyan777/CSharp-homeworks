using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Isosceles_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:

                //   ©
                //  © ©
                // ©   ©
                //© © © ©

            //Note that the © symbol may be displayed incorrectly at the console so you may need to change the console 
            //character encoding to UTF-8 and assign a Unicode-friendly font in the console. Note also, that under old versions of
            //Windows the © symbol may still be displayed incorrectly, regardless of how much effort you put to fix it.



            Console.OutputEncoding = Encoding.Unicode; //to read symbol.
            //Console.OutputEncoding = Encoding.UTF8;

            int n = int.Parse(Console.ReadLine());
            char C = '©';

            for (int i = 1; i <= n; i++)
            {
                string spaces = new string(' ', n - i);
                string symbol = new string(C, i * 2 - 1);

                Console.WriteLine(spaces + symbol);
            }
        }
    }
}
