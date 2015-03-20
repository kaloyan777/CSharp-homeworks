using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Comparing_Floats
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001. 
            //Note that we cannot directly compare two floating-point numbers a and b by a==b because of the nature of 
            //the floating-point arithmetic. Therefore, we assume two numbers are equal if they are more closely to each other than a 
            //fixed constant eps. Examples:



                        decimal A = 5.0002030m;
                        decimal B = 4.0000013423m;

                        decimal roundA = Math.Round(A, 6); //Math.Round zakruglq stojnostta na 4isloto do 6tata cifra sled zapetaqta...
                        decimal roundB = Math.Round(B, 6);

                        if (roundA == roundB)
                        {
                            Console.WriteLine("A & B are equal!");
                        }
                        else if (roundA > roundB)
                        {
                            Console.WriteLine("A is greater than B.");
                        }
                        else
                        {
                            Console.WriteLine("B is greater than A.");
                        }
                        Console.WriteLine();
                    

            //////////////////////////////////////////////////////////////////////////////////////////////////////////

            //Info on Example
            Console.WriteLine("A = 5.3; B = 6.01");
            Console.WriteLine("C = 5.00000001; D = 5.00000003" + '\n');

            //////////////////////////////Example 1//////////////////

            float a = 5.3f;
            float b = 6.01f;
            bool isAEqualToB = (Math.Abs(a - b) < 0.000001f);

            Console.WriteLine("Is A = B? - " + isAEqualToB);

            //////////////////////////////Example 2//////////////////

            float c = 5.00000001f;
            float d = 5.00000003f;
            bool isCEqualToD = (c == d);

            Console.WriteLine("Is C = D? - " + isCEqualToD);
        }
    }
}