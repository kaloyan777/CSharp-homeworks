using System;
using System.Numerics;

namespace _05.Factorial_multiply_NK
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).

                   Console.BackgroundColor = ConsoleColor.Blue; //Intro message in blue background.
                   Console.WriteLine("This program calculates N!*K! / [K-N]! for given N and K [1<N<K].\n"); //Intro
                   Console.ResetColor(); //Bring back original colors.

                Start: //When input is invalid, "else" sends back here to restart the program.

            //...Input values.
            System.Console.Write("- Number N: ");
                BigInteger N = BigInteger.Parse(Console.ReadLine()); 
            System.Console.Write("- Number K: ");
                BigInteger K = BigInteger.Parse(Console.ReadLine());
                   Console.WriteLine(new String('-', 50));

                BigInteger factorialK = 1;
                BigInteger factorialN = 1;


            if ((K > N) && (N > 1)) //Check if input is valid.
            {

           //...Calculating N!,K!
                for (int j = 1; j <= N; j++)  
                {
                    factorialN *= j;
                }
                System.Console.WriteLine(">> N!: " + factorialN); 
                //
                for (int i = 1; i <= K; i++) 
                {
                    factorialK *= i;
                }
                System.Console.WriteLine(">> K!: " + factorialK); 


           //...Calculating (N!*K!)
                BigInteger resultNmultiplyK = (factorialN * factorialK);
                System.Console.WriteLine("\n>> N!*K! = " + resultNmultiplyK); 
                

           //...Calculating (K-N)
                BigInteger resultKminusN = (K - N);
                System.Console.WriteLine(">> [K-N] = " + resultKminusN);


           //...Calculating (K-N)!
                BigInteger factorialKminusN = 1;
                for (int i = 1; i <= resultKminusN; i++)
                {
                    factorialKminusN *= i;
                }
                System.Console.Write("\n");
                       Console.BackgroundColor = ConsoleColor.DarkGreen;
                System.Console.Write("Factorial! of [K-N]");
                       Console.ResetColor();
                System.Console.WriteLine(" = " + factorialKminusN);


           //...Calculating N!*K!/[K-N]!
                       Console.WriteLine(new String('=', 50));
                       Console.BackgroundColor = ConsoleColor.DarkGreen;
                System.Console.Write("Calculation of N!*K!/[K-N]!"); 
                       Console.ResetColor();
                System.Console.WriteLine(" = " + resultNmultiplyK / factorialKminusN);
                       Console.Beep(); //Done!
            }
            else
            {
                       Console.WriteLine('\a'); //Error sound.
                       Console.BackgroundColor = ConsoleColor.Red; //Error message in red background.
                System.Console.WriteLine("Invalid Input! Try again.\n");
                       Console.ResetColor(); //Bring back original colors.
                goto Start; //restart program:
            }
        }
    }
}