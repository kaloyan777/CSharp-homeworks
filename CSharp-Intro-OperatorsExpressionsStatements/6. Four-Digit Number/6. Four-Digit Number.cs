using System;

namespace _6.Four_Digit_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:

            //•	Calculates the sum of the digits (in our example 2+0+1+1 = 4).
            //•	Prints on the console the number in reversed order: dcba (in our example 1102).
            //•	Puts the last digit in the first position: dabc (in our example 1201).
            //•	Exchanges the second and the third digits: acbd (in our example 2101).

            //The number has always exactly 4 digits and cannot start with 0. Examples:
            //  (n)   (sum of digits)     (reversed)	    (last digit in front)	    (second and third digits exchanged(to the right))
            //  2011	  4	                 1102	            1201                                  2101



            //example 1:
            Console.WriteLine("---EXAMPLE 1---");

            int aa = 2011;

            int bb = aa % 10;
            int cc = bb % 10;
            int dd = cc % 10;
            int e = dd % 10;

            Console.WriteLine("The number is: " + aa);
            int sum = bb + cc + dd + e;
            Console.WriteLine("sum of digits is: " + sum); //4



            //example 2:
            Console.WriteLine("\n---Example 2---");

            int a = 2;
            int b = 0;
            int c = 1;
            int d = 1;

            Console.WriteLine("sum of digits is 2+0+1+1 = " + (a + b + c + d));
            Console.WriteLine("backwords digits read is - " + d + c + b + a); //ако е bez () = string!!!
            Console.WriteLine("last digit goes in front - " + d + a + b + c);
            Console.WriteLine("2nd digit goes 3rd, 3rd one goes 2nd - " + a + c + b + d + "\n");



            //example 3:
            Console.WriteLine("\n---EXAMPLE 3---");

            Console.Write("enter 4 digited number: ");
            int abcd = int.Parse(Console.ReadLine());

            int A = abcd / 1000;
            int B = abcd / 100 % 10;
            int C = abcd / 10 % 10;
            int D = abcd % 10;

            Console.WriteLine("digit sum - " + (A + B + C + D));
            Console.WriteLine("digits backwards:    {0}{1}{2}{3}", D, C, B, A);
            Console.WriteLine("last digit in front: {0}{1}{2}{3}", D, A, B, C);
            Console.WriteLine("1st, 3rd, sec, 4th:  {0}{1}{2}{3}", A, C, B, D);
        }
    }
}