using System;

namespace _10.Bonus_Points
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Write a program that applies bonus scores to given scores in the range [1..9]. 
            //The program reads a digit as an input. If the digit is between 1 and 3, the program multiplies it by 10; 
            //if it is between 4 and 6, multiplies it by 100; if it is between 7 and 9, multiplies it by 1000. 
            //If it is zero or if the value is not a digit, the program must report an error.
            //Use a switch statement and at the end print the calculated new value in the console.

/////////...Example 1:

            Start: //return here from "goto;", so to start the program again, if any error was encountered.
            Console.Write("Enter any digit from 1 to 9: ");
            int digit; //this will be the number or digit that will be used to check and multiply
            bool isDigit = int.TryParse(Console.ReadLine(), out digit);

            if (isDigit) //if the number entered has been parsed succesfully as a number, not a text,
            {
                if ((digit < 1) && (digit > 9)) //but if the number is < than 1 and > 9, 
                {
                    Console.WriteLine("Error!"); //print error, because we need only from 1-9 to make the multiplyings 
                }

                switch (digit) //but if it's correct (1-9), 
                {
                    case 1: digit *= 10; Console.WriteLine(digit); //and if it is 1,2 or 3, multiply it by 10, and print the result.
                        break;
                    case 2: digit *= 10; Console.WriteLine(digit);
                        break;
                    case 3: digit *= 10; Console.WriteLine(digit);
                        break;
                    case 4: digit *= 100; Console.WriteLine(digit); //and if it is 4,5,6, multiply it by 100...
                        break;
                    case 5: digit *= 100; Console.WriteLine(digit);
                        break;
                    case 6: digit *= 100; Console.WriteLine(digit);
                        break;
                    case 7: digit *= 1000; Console.WriteLine(digit);
                        break;
                    case 8: digit *= 1000; Console.WriteLine(digit);
                        break;
                    case 9: digit *= 1000; Console.WriteLine(digit);
                        break;
                    default:
                        Console.Beep();
                        Console.WriteLine("- Error! Enter a digit from 1 to 9!");
                        goto Start;
                        //break; if you use "goto;", you don't need "break;".
                }
            }
            else
            {
                Console.Beep();
                Console.WriteLine("- Error! Enter a digit not a string text.");
                goto Start;
            }
        }
    }
}

///////////...Example 2:

            //string input = Console.ReadLine();
            //int number = 0;

            //if (!int.TryParse(input, out number)) //if x can't be Parsed into y as a number 
            //{
            //    Console.WriteLine("Error");
            //    return; //if without "return;", the false if result will print 2xError
            //}

            //switch (number) //for every y between 0 and 4, multiply by 10.
            //{
            //    case 1: //if 1, multiply by 10
            //    case 2: //if 2, multiply by 10...
            //    case 3:
            //        Console.WriteLine(number * 10); 
            //        break; //stop the program
            //    case 4: //if 4, multiply by 100...
            //    case 5:
            //    case 6:
            //        Console.WriteLine(number * 100); //print result
            //        break;
            //    case 7: //if 7,8,9...multiply by 1000.
            //    case 8:
            //    case 9:
            //        Console.WriteLine(number * 1000);
            //        break;
            //    default: Console.WriteLine("Error"); 
            //        break;
        //}
    //}
//}
           