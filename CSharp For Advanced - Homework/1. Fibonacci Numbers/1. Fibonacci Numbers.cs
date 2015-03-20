using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _1.Fibonacci_Numbers
{
    class Program
    {   
        //Define a method Fib(n) that calculates the nth Fibonacci number

        static void Main(string[] args) // Main = input + output
        {
            int n = int.Parse(Console.ReadLine()); //1. ---> Create input <---

            BigInteger result = Fib(n);            //5. ---> Pass the value of the method that return has to "result"  <---
            Console.WriteLine(result);             //6. ---> Print it on the console <---
        }

        //2. ---> Create method for calculation of what is needed <---
        private static BigInteger Fib(int n) //Параметър "int n", който се ползва за горната граница на цикъла "for", 
        {                                    //където се извършва изчислението.

            //3. ---> Create some variables to work with during calculation <---
            BigInteger first = 0; 
            BigInteger second = 1;
            BigInteger sum = 0;

            for (int i = 0; i < n; i++) //do the calculation
            {
                sum = first + second;
                first = second;
                second = sum;
            }

            //4. ---> Сега вече самият метод Fib(n) има стойност, get the value of the method <---
            return sum; 

            //"return sum" е крайният резултат от цялата шашкъния на метода "BigInteger Fib(n)", 
            //този резултат се извиква горе в Main метода, 
            //придава стойността си на "result" и се отпечатва на Console-ата.
        }
    }
}