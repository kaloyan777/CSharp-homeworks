﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Unicode_Character
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare a character variable and assign it with the symbol that has Unicode code 42 (decimal) using the '\u00XX' syntax, 
            //and then print it. Hint: first, use the Windows Calculator to find the hexadecimal representation of 42. 
            //The output should be “*”.

            char a = (char)42;
            char b = '\u0001';
            char c = '\u0002';
            char d = '\u0003';

            Console.WriteLine(a + " " + b + " " + c + " " + d); //xaxaxaxa :P
        }
    }
}
