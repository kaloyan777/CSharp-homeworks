using System;

namespace _11.Number_as_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation. 

            //int opa = 129;

            //int a = opa / 100;
            //int b = opa % 100 / 10;
            //int c = opa % 100 % 10;

            //Console.WriteLine(a); //1
            //Console.WriteLine(b); //2
            //Console.WriteLine(c); //9


            Console.Write("Enter a number in the range of [0 - 999]: ");
            int number = int.Parse(Console.ReadLine());

            int lastDigit = number % 10;
            int middleDigit = 0;
            int firstDigit = 0;

            string lastDigitName = null;
            string middleDigitName = null;
            string firstDigitName = null;
            string numberName = null;

            if ((number == 0) || ((number >= 10) && (number < 20)))
            {
                switch (number)
                {
                    case 0: numberName = "zero"; break;
                    case 10: numberName = "ten"; break;
                    case 11: numberName = "eleven"; break;
                    case 12: numberName = "twelve"; break;
                    case 13: numberName = "thirteen"; break;
                    case 14: numberName = "fourteen"; break;
                    case 15: numberName = "fifteen"; break;
                    case 16: numberName = "sixteen"; break;
                    case 17: numberName = "seventeen"; break;
                    case 18: numberName = "eighteen"; break;
                    case 19: numberName = "nineteen"; break;
                }
                Console.WriteLine("Name is: " + numberName);
            }
            else if (number % 100 == 0) 
            { 
                switch (number / 100) 
                {
                    case 1: numberName = "one hundred"; break;
                    case 2: numberName = "two hundred"; break;
                    case 3: numberName = "three hundred"; break;
                    case 4: numberName = "four hundred"; break;
                    case 5: numberName = "five hundred"; break;
                    case 6: numberName = "six hundred"; break;
                    case 7: numberName = "seven hundred"; break;
                    case 8: numberName = "eight hundred"; break;
                    case 9: numberName = "nine hundred"; break;
                }
                Console.WriteLine("Name is: " + numberName);
            }
            else
            {
                switch (lastDigit) //number % 10
                {
                    case 1: lastDigitName = "one"; break;
                    case 2: lastDigitName = "two"; break;
                    case 3: lastDigitName = "three"; break;
                    case 4: lastDigitName = "four"; break;
                    case 5: lastDigitName = "five"; break;
                    case 6: lastDigitName = "six"; break;
                    case 7: lastDigitName = "seven"; break;
                    case 8: lastDigitName = "eight"; break;
                    case 9: lastDigitName = "nine"; break;
                    case 0: lastDigitName = ""; break;
                }

                if (number > 9)
                {
                    middleDigit = ((number % 100) - lastDigit) / 10;
                    switch (middleDigit)
                    {
                        case 2: middleDigitName = "twenty"; break;
                        case 3: middleDigitName = "thirty"; break;
                        case 4: middleDigitName = "forty"; break;
                        case 5: middleDigitName = "fifty"; break;
                        case 6: middleDigitName = "sixty"; break;
                        case 7: middleDigitName = "seventy"; break;
                        case 8: middleDigitName = "eighty"; break;
                        case 9: middleDigitName = "ninety"; break;
                        case 0: middleDigitName = "and"; break;
                    }
                }
                if (number > 99)
                {
                    if (middleDigit == 1)
                    {
                        middleDigitName = "and";
                        switch (lastDigit)
                        {
                            case 0: lastDigitName = "ten"; break;
                            case 1: lastDigitName = "eleven"; break;
                            case 2: lastDigitName = "twelve"; break;
                            case 3: lastDigitName = "thirteen"; break;
                            case 4: lastDigitName = "fourteen"; break;
                            case 5: lastDigitName = "fifteen"; break;
                            case 6: lastDigitName = "sixteen"; break;
                            case 7: lastDigitName = "seventeen"; break;
                            case 8: lastDigitName = "eightteen"; break;
                            case 9: lastDigitName = "nineteen"; break;
                        }
                    }
                    firstDigit = ((number % 1000) - ((middleDigit * 10) + lastDigit)) / 100;
                    switch (firstDigit)
                    {
                        case 1: firstDigitName = "one hundred"; break;
                        case 2: firstDigitName = "two hundred"; break;
                        case 3: firstDigitName = "three hundred"; break;
                        case 4: firstDigitName = "four hundred"; break;
                        case 5: firstDigitName = "five hundred"; break;
                        case 6: firstDigitName = "six hundred"; break;
                        case 7: firstDigitName = "seven hundred"; break;
                        case 8: firstDigitName = "eight hundred"; break;
                        case 9: firstDigitName = "nine hundred"; break;
                    }
                }
                Console.WriteLine("Name is: {0} {1} {2}", firstDigitName, middleDigitName, lastDigitName);
            }
        }
    }
}

     