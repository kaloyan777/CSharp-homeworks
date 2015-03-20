using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Declare_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare five variables choosing for each of them the most appropriate of the types
            //byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 
            //52130, -115, 4825932, 97, -10000. Choose a large enough type for each number to ensure it will fit in it. 
            //Try to compile the code. Submit the source code of your Visual Studio project as part of your homework submission.

            ushort variable1 = 52130;
            Console.WriteLine("Var 1 ushort = " + variable1);

            sbyte variable2 = -115;
            Console.WriteLine("Var 2 sbyte = " + variable2);

            int variable3 = 4825932;
            Console.WriteLine("Var 3 int = " + variable3);

            sbyte variable4 = 97;
            Console.WriteLine("Var 4 sbyte = " + variable4);

            short variable5 = -10000;
            Console.WriteLine("Var 5 short = " + variable5);
        }
    }
}
