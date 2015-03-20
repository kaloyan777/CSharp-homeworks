using System;

namespace _10.Odd_and_Even_Product
{
    class Program
    {
        static void Main(string[] args)
        {
            //You are given n integers (given in a single line, separated by a space). 
            //Write a program that checks whether the product of the odd elements is equal to the product of the even elements. 
            //Elements are counted from 1 to n, so the first element is odd, the second is even, etc

            Console.Write("Size of loop to check its numbers: ");
            int n = int.Parse(Console.ReadLine());

            int productOfEvens = 1;
            int productOfOdds = 1;

            int a = 0; //Moje i bez tezi promenlivi, reshih da gi deklariram, za da ulesnq(nagledno) razbiraneto na operaciqta
            int b = 0; //po otsqvane na evens i odds. 

            for (int i = 1; i <= n; i++) //Ot vsi4kite 4isla v diapazona ot 1 do "n",
            {
                if (i % 2 == 0) //proveri koi ot vsi4kite 4isla se delqt na 0 bez ostatuk
                {
                    a = i;
                    Console.WriteLine("Even: " + a);
                    productOfEvens *= a;
                }
                else if (i % 2 != 0) //i koi se delqt na 0 s ostatuk.
                {
                    b = i;
                    Console.WriteLine("Odd: " + b);
                    productOfOdds *= b;
                }
            }

            if (productOfEvens == productOfOdds) 
            {
                Console.WriteLine("\nProduct of Evens: {0} = Product of Odds: {1}.", productOfEvens, productOfOdds);
            }
            else
            {
                if (productOfEvens > productOfOdds)
                {
                    Console.WriteLine("\nProduct of Evens: {0} > Product of Odds: {1}.", productOfEvens, productOfOdds);
                }
                else if (productOfEvens < productOfOdds)
                {
                    Console.WriteLine("\nProduct of evens: {0} < product of odds: {1}.", productOfEvens, productOfOdds);
                }
            }
        }
    }
}