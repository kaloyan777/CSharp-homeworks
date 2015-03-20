using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Null_Values_Arithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program that assigns null values to an integer and to a double variable. 
            //Try to print these variables at the console. Try to add some number or the null literal to these variables and print the result.

            //Two empty rows will be displayed
            int? nullInt = null;
            double? nullDouble = null;

            Console.WriteLine(nullInt);
            Console.WriteLine(nullDouble);

            //Adding Values
            nullInt = 3;
            nullDouble = 7;
            //If without adding values, Output: 0,0
            Console.WriteLine(nullInt.GetValueOrDefault());     //3
            Console.WriteLine(nullDouble.GetValueOrDefault()); //7
        }
    }
}