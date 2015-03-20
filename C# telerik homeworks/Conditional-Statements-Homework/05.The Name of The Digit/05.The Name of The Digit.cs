using System;

namespace _05.The_Name_of_The_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
        //Write program that asks for a digit and depending on the input shows the name of that digit (in English) 
        //using a switch statement

       //...Example 1:
        Start: 
            Console.Write("Enter a digit: ");
            int digit = int.Parse(Console.ReadLine());

            switch (digit)
            {
                case 1: Console.WriteLine("one"); break;
                case 2: Console.WriteLine("two"); break;
                case 3: Console.WriteLine("three"); break;
                case 4: Console.WriteLine("four"); break;
                case 5: Console.WriteLine("five"); break;
                case 6: Console.WriteLine("six"); break;
                case 7: Console.WriteLine("seven"); break;
                case 8: Console.WriteLine("eight"); break;
                case 9: Console.WriteLine("nine"); break;
                default:
                    Console.Beep(); //error sound
                    Console.WriteLine("Шае, нещо се бъркаш! Тря да е цифра(1 знак), не число!");
                    goto Start; //try again
                //break; при употребата на goto; след default:...; ,break; е ненужен.
            }

       //...Example 2:

            Console.WriteLine(new String('-', 40) + '\n');
            Console.WriteLine("Second  Example  Of  The  Code.");
       Start2:
            Console.Write("Enter 1 digit: ");
            int digitTwo;
                bool check = int.TryParse(Console.ReadLine(), out digitTwo); //checks if une input is string or a number.

            if (check) // = if(true), because "check" is boolean, so if = true, then "swith (digitTwo)" will be executed!
            {
                switch (digitTwo)
                {
                    case 1: Console.WriteLine("one"); 
                        break;
                    case 2: Console.WriteLine("two"); 
                        break;
                    case 3: Console.WriteLine("three"); 
                        break;
                    case 4: Console.WriteLine("four"); 
                        break;
                    case 5: Console.WriteLine("five"); 
                        break;
                    case 6: Console.WriteLine("six"); 
                        break;
                    case 7: Console.WriteLine("seven"); 
                        break;
                    case 8: Console.WriteLine("eight"); 
                        break;
                    case 9: Console.WriteLine("nine"); 
                        break;
                    default:
                        Console.Beep(); //beep sound
                        Console.WriteLine("Шае, нещо се бъркаш! Тря да е цифра(1 знак), не число!"); 
                        //break;
                        goto Start2; //try again.
                }
            }
            else
            {
                Console.WriteLine('\a'); //error signal :P, if you know what I'm talking about!
                Console.Write("Error! Incorrect input! Try again. - "); 
                goto Start2; //try again.
            }
        }
    }
}