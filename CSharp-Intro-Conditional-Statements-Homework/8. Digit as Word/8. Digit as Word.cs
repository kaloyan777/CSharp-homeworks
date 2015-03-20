using System;

namespace _8.Digit_as_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English). 
            //Print “not a digit” in case of invalid inut. Use a switch statement. 

            int digit = int.Parse(Console.ReadLine());

            switch (digit)
            {
                case 0: Console.WriteLine("Zero"); break;
                case 1: Console.WriteLine("One"); break;
                case 2: Console.WriteLine("Two"); break;
                case 3: Console.WriteLine("Three"); break;
                case 4: Console.WriteLine("Four"); break;
                case 5: Console.WriteLine("Five"); break;
                case 6: Console.WriteLine("Six"); break;
                case 7: Console.WriteLine("Seven"); break;
                case 8: Console.WriteLine("Eight"); break;
                case 9: Console.WriteLine("Nine"); break;

                default: Console.Write("not a digit"); break;
            }

            //example 2: 
            Console.WriteLine("\n---EXAMPLE 2---\n");

            for (int i = 0; i <= 9; i++)
            {
                switch (i)
                {
                    case 0: Console.WriteLine("sub zero"); 
                        break;
                    case 1: Console.WriteLine("чушки"); 
                        break;
                    case 2: Console.WriteLine("пушки"); 
                        break;
                    case 3: Console.WriteLine("душки"); 
                        break;
                    case 4: Console.WriteLine("картофи"); 
                        break;
                    case 5: Console.WriteLine("чаршафи"); 
                        break;
                    case 6: Console.WriteLine("дъвка"); 
                        break;
                    case 7: Console.WriteLine("кретеноид"); 
                        break;
                    case 8: Console.WriteLine("астероид"); 
                        break;
                    case 9: Console.WriteLine("ае си хойм!"); 
                        break;

                    default: Console.WriteLine("дай пет ле'а!");
                        break;
                }
            }
            Console.WriteLine("\nТова е празен ред, нищо че пише, че е празен и всъщност не е празен, той за това стои тук, че да е празен, разбираш ли?!\n");
        }
    }
}