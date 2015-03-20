using System;

namespace _2.Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that applies bonus score to given score in the range [1…9] by the following rules:
            //•	If the score is between 1 and 3, the program multiplies it by 10.
            //•	If the score is between 4 and 6, the program multiplies it by 100.
            //•	If the score is between 7 and 9, the program multiplies it by 1000.
            //•	If the score is 0 or more than 9, the program prints “invalid score”. 
            
            //it doesn't say less than 0, but i make the check anyway...разбииши? хаха : муухаха;

            //example 1:
            Console.WriteLine("---EXAMPLE 1---if/else if");

            int number = int.Parse(Console.ReadLine());

            if (number >= 1 && number <= 3)
            {
                Console.WriteLine(number *= 10);
                //Console.WriteLine("Score is {0}, bonus score is {1}.", number, number *= 10); //this is according to the task.
            }
            else if (number >= 4 && number <= 6)
            {
                Console.WriteLine(number *= 100);
            }
            else if (number >= 7 && number <= 9)
            {
                Console.WriteLine(number *= 1000);
            }
            else if (number <= 0 || number > 9)
            {
                Console.WriteLine("“invalid score”");
            }

            //example 2:
            Console.WriteLine("\n---EXAMPLE 2---switch/case");

            Start:
            string textNumber = Console.ReadLine();
            int intNumber;

            while(!int.TryParse(textNumber, out intNumber)) //check if input is a number or string and goto input again if input is a string.
            {
                Console.Write("Type in an integer number: ");
                goto Start;
            }

            switch (intNumber)
            {
                case 1:
                case 2:
                case 3: Console.WriteLine("Score is {0}, bonus score is {1}.", intNumber, intNumber *= 10);
                    break;

                case 4:
                case 6:
                case 5: Console.WriteLine("Score is {0}, bonus score is {1}.", intNumber, intNumber *= 100);
                    break;

                case 7:
                case 8:
                case 9: Console.WriteLine("Score is {0}, bonus score is {1}.", intNumber, intNumber *= 1000);
                    break;

                default: Console.WriteLine("“invalid score”");
                    break;
            }
            Console.WriteLine();
        }
    }
}