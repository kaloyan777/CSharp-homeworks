using System;

namespace _07.If_Int_Is_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter int number to check if prime: ");
            int number = int.Parse(Console.ReadLine());

            bool a = true;

            if ((number <= 1) || (number > 100))
            {
                Console.WriteLine("False number!");
            }
            else
            {
                for (int i = 2; i < number; i++)
                {
                    if (number % i == 0) //if number is EVEN, then it's not prime.
                    {
                        Console.WriteLine("- The number n={0} is not prime!", number);
                        a = false;
                        break;
                    }
                    if (a == true)
                    {
                        Console.WriteLine("- The number n={0} is prime!", number);
                    }
                }
            }
        }
    }
}
 