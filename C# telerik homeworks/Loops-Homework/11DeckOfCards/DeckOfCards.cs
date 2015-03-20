using System;


class Program
{
    static void Main()
    {
        //Write a program that prints all possible cards from a standard deck of 52 cards (without jokers). The cards should be printed with their English names. Use nested for loops and switch-case.

        string cardTitle;
        string cardReference;
        for (int cSuit = 1; cSuit <= 4; cSuit++)
        {
            switch (cSuit)
            {
                case 1: cardReference = "♣";
                    break;
                case 2: cardReference = "♦";
                    break;
                case 3: cardReference = "♥";
                    break;
                case 4: cardReference = "♠";
                    break;
                default: cardReference = "Card Reference";
                    break;
            }

            for (int cards = 2; cards <= 14; cards++)
            {
                switch (cards)
                {
                    case 2: cardTitle = "2";
                        break;
                    case 3: cardTitle = "3";
                        break;
                    case 4: cardTitle = "4";
                        break;
                    case 5: cardTitle = "5";
                        break;
                    case 6: cardTitle = "6";
                        break;
                    case 7: cardTitle = "7";
                        break;
                    case 8: cardTitle = "8";
                        break;
                    case 9: cardTitle = "9";
                        break;
                    case 10: cardTitle = "10";
                        break;
                    case 11: cardTitle = "J";
                        break;
                    case 12: cardTitle = "Q";
                        break;
                    case 13: cardTitle = "K";
                        break;
                    case 14: cardTitle = "A";
                        break;
                    default: cardTitle = "Card Title";
                        break;
                }
                Console.Write(cardTitle + cardReference);
            }
            Console.WriteLine("\n");
        }
    }
}
