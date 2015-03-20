using System;
using System.Numerics;

namespace _04.Factoriel
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that calculates N!/K! for given N and K (1<K<N).
            //5! = 5 * 4 * 3 * 2 * 1 = 120;
            //6! = 6 * 5 * 4 * 3 * 2 * 1 = 720;

            Start: //When input is invalid, "else" sends back here to restart the program.
            Console.Write(">> Enter a number \"K > 1, < N\" for calculating factorial: "); //K!
                BigInteger K = BigInteger.Parse(Console.ReadLine());
            Console.Write(">> Enter a number \"N > K\" for calculating factorial: "); //N!
                BigInteger N = BigInteger.Parse(Console.ReadLine());
                Console.WriteLine(new String('-', 40));

                BigInteger factorialK = 1; //Is 1, because if 0, result will be 0, 
                BigInteger factorialN = 1; //because multiplying by 0 is 0!
         

                if ((K > 1) && (N > K)) //Check if (N! > K! > 1).
                {
                    for (BigInteger i = 1; i <= K; i++) //Calculating K!;
                    {
                        factorialK *= i;
                    }
                        System.Console.WriteLine("- Factoriel K: " + factorialK); //Print K!
                    //
                    for (BigInteger j = 1; j <= N ; j++) //Calculating N!;
                    {
                        factorialN *= j;
                    }
                        System.Console.WriteLine("- Factorial N: " + factorialN); //Print N!

                    BigInteger resultNK = (factorialN / factorialK); //Calculating result;
                    Console.WriteLine(new String('=', 40));
                    Console.Beep(); //Done.
                        System.Console.WriteLine("* Division of N!/K!: " + resultNK + " *" + '\n'); //Print result;
                }
                else
                {
                    Console.Write('\a'); //Error!
                    Console.WriteLine("Incorrect input!\n"); //Message.
                    goto Start; //Restarting program:
                }
        }
    }
}
