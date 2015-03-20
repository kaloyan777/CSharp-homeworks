using System;
using System.Numerics;

namespace _04.Tribonacci
{
    class Tribonacci
    {
        static void Main(string[] args)
        {
            //Tribonacci and showing the Nth chosen element of the sequence:

            Console.WriteLine("Enter 3 numbers: ");
            BigInteger first = BigInteger.Parse(Console.ReadLine());
            BigInteger second = BigInteger.Parse(Console.ReadLine());
            BigInteger third = BigInteger.Parse(Console.ReadLine());

            BigInteger result = 0; //0, because there will be summing, not multiplying(1)!

            Console.Write("The Nth element: ");
            BigInteger n = BigInteger.Parse(Console.ReadLine()); //N is the Nth(count) element from the tribonacci sequence, not the value of it!

            if(n == 1)//If any of the 3 input nums are equal to the position that is required to be shown(n), 
            {         //then just print the same value.
                Console.WriteLine(first);
            }
            else if(n == 2)
            {
	            Console.WriteLine(second);
            }
            else if(n == 3)
            {
	            Console.WriteLine(third);
            }
            else //In "else" is the actual solve of the problem.
            {
	            for(int i = 3; i < n; i++) //3, because we already have the first 3 members!
	            {
		            result = first+second+third;
		            first = second; second = third;
		            third = result;
	            }
	            Console.WriteLine("Result: " + result);
            }
        }
    }
}