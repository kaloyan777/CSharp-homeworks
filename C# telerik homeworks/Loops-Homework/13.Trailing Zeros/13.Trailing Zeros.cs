using System;
using System.Numerics;

namespace _13.Trailing_Zeros
{
    class Program
    {
        static void Main(string[] args)
        {
    ////        * Write a program that calculates for given N how many trailing zeros present at the end of the number N!. Examples:
    ////N = 10  N! = 3628800  2
    ////N = 20  N! = 2432902008176640000  4
    ////Does your program work for N = 50 000?
    ////Hint: The trailing zeros in N! are equal to the number of its prime divisors of value 5. Think why!
        //    Броят на нулите в края на n! зависи от това, колко пъти числото 10 е делител на факториела. 
        //    Понеже произведението 1*2*3…*n има повече на брой делители 2, отколкото 5, а 10 = 2 * 5, то броят нули в n! е точно толкова, 
        //    колкото са множителите със стойност 5 в произведението 1*2*3….*n. Понеже всяко пето число се дели на 5,
        //  а всяко 25-то число се дели на 5 двукратно и т.н., то броя нули в n! е сумата: n/5 + n/25 + n/125 + …


//..........Example 1: (Само това решение е мое!)
 
            Start:
            Console.Write(" - N: ");
                BigInteger n = BigInteger.Parse(Console.ReadLine());
                BigInteger factorialN = 1;
                BigInteger count = 0;

            if (n > 0)
            {
                for (int i = 1; i <= n; i++)
                {
                    factorialN *= i;
                }
                Console.WriteLine(">> N!: " + factorialN);

                for (int j = 0; j < factorialN; j++)
                {
                    if ((factorialN % 10) == 0)
                    {
                        count = count + 1;
                        factorialN /= 10;
                    }
                }
                Console.WriteLine(" * Count of trailing zeros of N!: " + count + '\n');
                Console.WriteLine(new String ('=', 50));
            }
            else
            {
                Console.WriteLine(">> Invalid Input!");
                goto Start;
            }


//..........Example 2:

            Console.Write(" - N: ");
            int N = int.Parse(Console.ReadLine());

            int trailingZeros = 0;
            int powersOfFive = 5;

            while (N / powersOfFive >= 1)
            {
                trailingZeros += N / powersOfFive;
                powersOfFive *= 5;
            }
            Console.WriteLine(" * Trailing zeros of N!: " + trailingZeros + '\n');
            Console.WriteLine(new String('=', 50));
        
//..........Example 3: 

            Console.Write(" - N: ");
            int nNumber = int.Parse(Console.ReadLine());

            int countZero = 0;
            int square = 1;
            int divisor = 5;
            int rezult = 0;

            bool zeroRezult = true;
           
            while (zeroRezult)
            {
                square *= divisor;
                rezult = (nNumber / square);
                countZero += rezult;

                if (rezult == 0)
                {
                    zeroRezult = false;
                }
            }
            Console.WriteLine(" * Trailing zeros: " + countZero + '\n');
            Console.WriteLine(new String('=', 50));
        }
    }
}