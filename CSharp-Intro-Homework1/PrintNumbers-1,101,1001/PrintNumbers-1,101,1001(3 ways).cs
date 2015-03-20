using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintNumbers_1_101_1001
{
    class Program
    {
        static void Main(string[] args)
        {
            //1:

            int one = 1;
            int zero = 0;

            string numberOne = Convert.ToString(one);
            string numberZero = Convert.ToString(zero);

            string number1 = numberOne;
            string number101 = numberOne + numberZero + numberOne;

            int number1001 = 100 * 10 + 1; 
           
            Console.WriteLine(number1 + ", " + number101 + ", " + number1001);

            //2:

            Console.Write(1);
            Console.Write(',');
            Console.Write(" " + 101);
            Console.Write(", " + "1001\n");

            //3:

            Console.Write(1);
            Console.Write(", " + 1);
            Console.Write(0);
            Console.Write(1);
            Console.Write(',' + " ");
            Console.Write(1);
            Console.Write(0);
            Console.Write(0);
            Console.WriteLine(1);
        }
    }
}