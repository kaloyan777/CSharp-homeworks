using System;

namespace _08.Using_Quoted_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string usingQuotes = @"The ""use"" of quotations causes difficulties.";
            Console.WriteLine("usingQuotes: " + usingQuotes + '\n');

            string noQuotes = "The \"use\" of quotations causes difficulties."; 
            Console.WriteLine("noQuotes: " + noQuotes + '\n');
        }
    }
}
