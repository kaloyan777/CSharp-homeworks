using System;

namespace _1.Odd_or_Even_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write an expression that checks if given integer is odd or even

            //example 1:

            Console.Write("1---Enter a number(could be float): ");
            float numberToCheck = float.Parse(Console.ReadLine());

            float result = 0; //float, so to give an exact result of calculation

            if (numberToCheck % 2 == 0)
            {
                Console.WriteLine(numberToCheck + " is even." + '\n'); 
                result = numberToCheck / 2;
                Console.WriteLine("Result = " + result);
            }
            else if(numberToCheck % 2 != 0)
            {
                Console.WriteLine(numberToCheck + " is odd."); 
                result = numberToCheck / 2;
                Console.WriteLine("Result is = " + result + '\n');
            }



            //example 2:

            Console.Write("2---Enter another number(int): ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine((number % 2 == 0) ? ("The number is even.\n") : ("The number is odd.\n")); //= ((if this is true), (then...) : (or else...));



            //example 3:

            Console.Write("3---Enter number: ");
            float num = float.Parse(Console.ReadLine());

            bool isEven = true;

            if (num % 2 == 0)
            {
                Console.WriteLine(isEven + "\n");
            }
            else
            {
                isEven = false;
                Console.WriteLine(isEven + "\n");
            }



            //example 4:

            Console.Write("4---Enter an integer number: ");
            int Number;

            //checks if u've entered an integer, if not, it repeats until u enter a whole number without reminder
            while (!(int.TryParse(Console.ReadLine(), out Number))) 
            {
                Console.Write("Enter an integer number: ");
            }
            //check if even or not
            if (Number % 2 == 0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
            Console.WriteLine();
        }
    }
}