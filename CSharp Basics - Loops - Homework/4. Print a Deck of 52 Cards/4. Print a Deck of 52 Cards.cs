using System;

namespace _4.Print_a_Deck_of_52_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). 
            //The cards should be printed using the classical notation (like 5♠, A♥, 9♣ and K♦). 
            //The card faces should start from 2 to A. Print each card face in its four possible suits: clubs, diamonds, hearts and spades. 
            //Use 2 nested for-loops and a switch-case statement.

            //example 1:

            //            Напишете програма, която отпечатва всички възможни карти от стан-
            //дартно тесте карти без жокери (имаме 52 карти: 4 бои по 13 карти).

            //    Номерирайте картите от 2 до 14 (тези числа ще съответстват на картите от 2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K, A).
            //Номерирайте боите от 1 до 4 (1 – спатия, 2 – каро, 3 – купа, 4 – пика). 
            //  Сега вече можете да завъртите 2 вложени цикъла и да отпечатате всяка от картите.



            Console.WriteLine("---EXAMPLE 1---\n");

            string[] Colors = { "Spades", "Hearts", "Diamonds", "Clubs" };
            string[] Cards = { "J", "Q", "K", "A" };

            for (int i = 2; i <= 14; i++)
            {
                for (int a = 0; a < 4; a++) //6te pe4ata vseki edin ot 4te bukvi sre6tu indexite ot 11-14
                {
                    if (i < 11) //ot 2 do 10
                    {
                        Console.Write("{0, 2} {1} ", i, Colors[a]); // pe4atai sre6tu nomera po 1 ot 4te cvqta v color[] masiva
                    }
                    else //a tezi koito sa ot J-A,
                    {
                        Console.Write("{0, 2} {1} ", Cards[i - 11], Colors[a]); //im pe4atai bukvite ot cards[] masiva
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n---EXAMPLE 2---");

            //example 2:

            string color = null;

            for (int i = 1; i <= 4; i++) //pravi spisuk s faces
            {
                switch (i)
                {
                    case 1:
                        color = "Hearts";
                        break;
                    case 2:
                        color = "Clubs";
                        break;
                    case 3:
                        color = "Diamonds";
                        break;
                    case 4:
                        color = "Spades";
                        break;
                }

                Console.WriteLine();

                for (int j = 2; j <= 14; j++)
                {
                    switch (j)  //2, 3, 4, 5, 6, 7, 8, 9, 10
                    {
                        case 2:
                            Console.WriteLine("{0,2} {1}", j, color);
                            break;
                        case 3:
                            Console.WriteLine("{0,2} {1}", j, color);
                            break;
                        case 4:
                            Console.WriteLine("{0,2} {1}", j, color);
                            break;
                        case 5:
                            Console.WriteLine("{0,2} {1}", j, color);
                            break;
                        case 6:
                            Console.WriteLine("{0,2} {1}", j, color);
                            break;
                        case 7:
                            Console.WriteLine("{0,2} {1}", j, color);
                            break;
                        case 8:
                            Console.WriteLine("{0,2} {1}", j, color);
                            break;
                        case 9:
                            Console.WriteLine("{0,2} {1}", j, color);
                            break;
                        case 10:
                            Console.WriteLine("{0,2} {1}", j, color);
                            break;

                        //J, Q, K, A
                        case 11:
                            Console.WriteLine("{0,2} {1}", "J", color);
                            break;
                        case 12:
                            Console.WriteLine("{0,2} {1}", "Q", color);
                            break;
                        case 13:
                            Console.WriteLine("{0,2} {1}", "K", color);
                            break;
                        case 14:
                            Console.WriteLine("{0,2} {1}", "A", color);
                            break;

                        default: //nqma nujda ot default, za6toto nqma input ot user...
                            break;
                    }
                }
            }
        }
    }
}