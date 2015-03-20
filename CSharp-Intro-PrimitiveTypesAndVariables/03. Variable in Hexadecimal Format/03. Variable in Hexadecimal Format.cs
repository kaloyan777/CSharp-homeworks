using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Variable_in_Hexadecimal_Format
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare an integer variable and assign it with the value 254 in hexadecimal format (0x##). 
            //Use Windows Calculator to find its hexadecimal representation. Print the variable and ensure that the result is “254”.

            int turnOne = 254;
            Console.WriteLine("{0:X}", turnOne);

            //

            int turnTwo = 0xFE;
            Console.WriteLine(turnTwo);
        }
    }
}
