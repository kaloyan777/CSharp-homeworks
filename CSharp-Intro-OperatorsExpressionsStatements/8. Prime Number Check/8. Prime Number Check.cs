using System;

namespace _8.Prime_Number_Check
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write an expression that checks if given positive integer number n (n ≤ 100) is prime (i.e. it is divisible without remainder only to itself and 1). 

            //Напишете програма, която проверява дали дадено число n (1 < n < 100) е просто 
            //(т.е. се дели без остатък само на себе си и на единица).

            //Използвайте цикъл и проверете числото за делимост на всички числа от 1 до корен квадратен от числото. 
            //В конкретната задача, тъй като ограничението е само до 100, можете предварително да намерите простите числа от 
            //1 до 100 и да направите проверки дали даденото число n e равно на някое от tqh.


            //example 1:
            Console.WriteLine("...example 1...");

            Console.Write("Enter int number to check if prime: ");
            int Number = int.Parse(Console.ReadLine());

            bool a = true;

            if ((Number <= 1) || (Number > 100))
            {
                Console.WriteLine("False number!");
            }
            else
            {
                for (int i = 2; i < Number; i++)
                {
                    if (Number % i == 0) //if number is EVEN, then it's not prime.
                    {
                        a = false;
                    }
                }
                Console.WriteLine(a);
            }




            //example 2:
            Console.WriteLine("\n...example 2...");

            int num;

            while (true)
            {
                try
                {
                    Console.Write("- Enter integer > 1 <= 100: ");
                    num = int.Parse(Console.ReadLine());

                    if ((num > 0) && (num <= 100)) //If input is correct, break the loop and continue along the rest of the code.
                    {
                        break;
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("- Input is not valid!");
                }
            }

            bool isPrime = true;

            for (int i = 2; i <= num / 2; i++) //всички числа от 1 до корен квадратен от числото
            {
                if (num % i == 0) //zna4i e 4etno, a ne prosto
                {
                    isPrime = false;
                    break; //prenasq False stoinostta v rezultata po-dolo
                }//else: isPrime ostava True;
            }
            Console.WriteLine((isPrime) ? "- The number is prime." : "- The number is not prime."); //if(true) ? "body" else : "body"



            //example 3:
            Console.WriteLine("\n...example 3...");

            Console.Write("Enter an int number > 1 <= 100: ");
            int number;

            while (!int.TryParse(Console.ReadLine(), out number) || number > 100) //if the number is not an int or bigger than 100,
            {
                Console.Write("Enter an int number > 1 <= 100: ");
            }

            int divider = 2;
            int maxDivider = (int)Math.Sqrt(number);

            bool prime = true;

            while (prime && (divider <= maxDivider))
            {
                if (number % divider == 0)
                {
                    prime = false; 
                }
                divider++; //this way divider checks all the numbers in the scope until it reaches the value of the maxDivider
            }
            Console.WriteLine("Prime?" + prime);
        }
    }
}
