﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Quotes_in_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare two string variables and assign them with following value:
            //The "use" of quotations causes difficulties.
            //Do the above in two different ways: with and without using quoted strings. 
            //Print the variables to ensure that their value was correctly defined.

            string noQuotes = "The \"use\" of quatations causes difficulties!";
            string usingQuotes = @"The ""use"" of quatations causes difficulties!";

            Console.WriteLine(noQuotes + "\n" + usingQuotes);
        }
    }
}
