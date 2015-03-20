using System;

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that prints all possible cards from a standard deck of 52 cards (without jokers). 
            //The cards should be printed with their English names. Use nested for loops and switch-case.

            //Номерирайте картите от 2 до 14 (тези числа ще съответстват на картите от 2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K, A).
            //Номерирайте боите от 1 до 4 (1 – спатия, 2 – каро, 3 – купа, 4 – пика). 
            //Сега вече можете да завъртите 2 вложени цикъла и да отпечатате всяка от картите.

            //...Example 1:

            Console.WriteLine("- All cards from a standard deck of 52 cards.\n (Without Jokers)\n");
            string[] color = { "Spades", "Hearts", "Diamonds", "Clubs" };
            string[] cards = { "J", "Q", "K", "A" };

            for (int i = 2; i <= 14; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (i < 11)
                    {
                        Console.Write("{0, 3} {1, -1} ", i, color[j]);
                    }
                    else
                    {
                        Console.Write("{0, 3} {1, -1} ", cards[i - 11], color[j]);
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}

            //...Example 2:

//            string color = null;

//            for (int i = 1; i <= 4; i++)
//            {
//                switch (i)
//                {
//                    case 1:
//                        color = "Hearts";
//                        break;
//                    case 2:
//                        color = "Clubs";
//                        break;
//                    case 3:
//                        color = "Diamonds";
//                        break;
//                    case 4:
//                        color = "Spades";
//                        break;
//                }
//                Console.WriteLine();

//                for (int j = 2; j <= 14; j++)
//                {
//                    //A, K, Q, J, 10, 9, 8, 7, 6, 5, 4, 3, 2.
//                    switch (j)
//                    {
//                        case 2:
//                            Console.WriteLine("{0,2} {1}", j, color);
//                            break;
//                        case 3:
//                            Console.WriteLine("{0,2} {1}", j, color);
//                            break;
//                        case 4:
//                            Console.WriteLine("{0,2} {1}", j, color);
//                            break;
//                        case 5:
//                            Console.WriteLine("{0,2} {1}", j, color);
//                            break;
//                        case 6:
//                            Console.WriteLine("{0,2} {1}", j, color);
//                            break;
//                        case 7:
//                            Console.WriteLine("{0,2} {1}", j, color);
//                            break;
//                        case 8:
//                            Console.WriteLine("{0,2} {1}", j, color);
//                            break;
//                        case 9:
//                            Console.WriteLine("{0,2} {1}", j, color);
//                            break;
//                        case 10:
//                            Console.WriteLine("{0} {1}", j, color);
//                            break;
//                        case 11:
//                            Console.WriteLine("{0,2} {1}", "J", color);
//                            break;
//                        case 12:
//                            Console.WriteLine("{0,2} {1}", "Q", color);
//                            break;
//                        case 13:
//                            Console.WriteLine("{0,2} {1}", "K", color);
//                            break;
//                        case 14:
//                            Console.WriteLine("{0,2} {1}", "A", color);
//                            break;
//                    }
//                }
//            }
//        }
//    }
//}