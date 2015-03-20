using System;

namespace _10.Catalan_N
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program to calculate the Nth Catalan number by given N.

            //...Example 1:

            System.Console.Write("- N: ");
                double n = double.Parse(Console.ReadLine());

                double nFactorial = n;
                double nPlusOne = n + 1;
                double nMultiplyTwo = n * 2;

                double nResult = 1;
                double nPlusOneResult = 1;
                double nMultiplyTwoResult = 1;

            for (int i = 1; i <= nFactorial; i++)
            {
                nResult *= i;
            }

            for (int i = 1; i <= nPlusOne; i++)
            {
                nPlusOneResult *= i;
            }

            for (int i = 1; i <= nMultiplyTwo; i++)
            {
                nMultiplyTwoResult *= i;
            }
                double resul = (nMultiplyTwoResult / (nPlusOneResult * nResult));
                Console.Beep();
            System.Console.WriteLine("- Catalan Result for given N: " + resul);
                Console.WriteLine(new String('=', 40));


           //...Example 2:

                //System.Console.Write("- N: ");
                //    int n = int.Parse(Console.ReadLine());
                //    int num = (2 * n);
                //    int denom = n;

                //    int denomResult = 1;
                //    int numResult = 1;
                //    int result = 0;

                //for (int i = 0; i < (n - 1); i++)
                //{
                //    numResult *= num;
                //    num--;
                //    denomResult *= denom;
                //    denom--;
                //}
                //result = (numResult / denomResult);
                //System.Console.WriteLine("- Result: " + result);
        }
    }
}