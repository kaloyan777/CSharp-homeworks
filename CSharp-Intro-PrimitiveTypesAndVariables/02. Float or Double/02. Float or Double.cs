using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Float_or_Double
{
    class Program
    {
        static void Main(string[] args)
        {
            //Which of the following values can be assigned to a variable of type float and which to a variable of type double: 
            //34.567839023, 12.345, 8923.1234857, 3456.091? Write a program to assign the numbers in variables and print them to ensure
            //no precision is lost.


            double firstNum = 34.567839023d;
            float secondNum = 12.345f;
            double thirthNum = 8923.1234857d;
            float fourthNum = 3456.091f;

            Console.WriteLine("double: " + firstNum);
            Console.WriteLine("float: " + secondNum);
            Console.WriteLine("double: " + thirthNum);
            Console.WriteLine("float: " + fourthNum);
        }
    }
}
