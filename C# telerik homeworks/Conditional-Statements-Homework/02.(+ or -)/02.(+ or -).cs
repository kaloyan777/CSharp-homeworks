using System;

namespace _02.___or___
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that shows the sign (+ or -) of the product of three real numbers without calculating it. 
            //Use a sequence of if statements.

            // -- Multitude of numbers (n > 0 < m), have positive product, if the count of negative numbers among them is even!
            // -- If some of these numbers is = 0, the result(product) is 0.

            // -- Zero is an even number. An even number is a number that 
            //is exactly divisible by 2. That means that when you divide by two the 
            //remainder is zero. And zero devided by 2, equals zero without reminder!

              //Try1: n1st,-n2nd,-n3rd; 
              //Try2: n1st,n2nd,-n3rd;
            Start:
            Console.Write("1st num: ");
                int number1st = int.Parse(Console.ReadLine());
            Console.Write("Sec num: ");
                int number2nd = int.Parse(Console.ReadLine());
            Console.Write("3rd num: ");
                int number3rd = int.Parse(Console.ReadLine());

            if((number1st == 0) || (number2nd == 0) || (number3rd == 0))
            {
                Console.WriteLine("Product is 0.");
            }
            else
	        {
                int counter = 0; //Using this, to count(by incrementing) all possible entered negative int32 numbers, if you know what I mean!

                if (number1st < 0) //Could be: if((number1st < 0) && (number2nd < 0) && (number3rd < 0)) {counter++;}...
                {
                    counter++; //if(true), then from 0, "counter" will be incremented and will be equal to 1; That means, there is already one negative number among the 3 numbers entered. So if "counter" encounters 2 negative numbers, the product of the multiplying will be positive, and if it's 1, then - negative.
                }
                if (number2nd < 0)
                {
                    counter++;
                }
                if (number3rd < 0)
                {
                    counter++;
                }
                    if (counter % 2 == 0) //If the COUNT NUMBER of the negative numbers among any of the numbers that could be entered IS EVEN(%2==0): 
                    {
                        Console.Beep();
                        Console.WriteLine("\nThe product of all three numbers is positive: \"+\"! \nA job well done! \n:D Ok, bye-bye then!\n");
                    }
                else
                {
                    Console.WriteLine('\a');
                    Console.WriteLine("Product is negative! Try again...\n");
                    goto Start;
                }
            }
        }
    }
}