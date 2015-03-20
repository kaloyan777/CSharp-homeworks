using System;

namespace _11.Convert_a_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that converts a number in the range [0...999] to a text corresponding to its English pronunciation.
            //Examples:
            //0  "Zero"
            //273  "Two hundred seventy three"
            //400  "Four hundred"
            //501  "Five hundred and one"
            //711  "Seven hundred and eleven"

            // Използвайте вложени switch конструкции. Да се обърне специално
            //внимание на числата от 0 до 19 и на онези, в които единиците са 0.

            //            Console.WriteLine("Enter a number (0-999):");
            //            int x = int.Parse(Console.ReadLine());

            //            int ones = x % 10;
            //            int tens = (x / 10) % 10;
            //            int hundrets = x / 100;

            //            if(x>=0 && x<=999) 
            //            {
            //            switch (hundrets)
            //            {
            //                case 1:
            //                    Console.Write("Hundred ");
            //                    break;
            //                case 2:
            //                    Console.Write("Twohundred ");
            //                    break;
            //                case 3:
            //                    Console.Write("Threehundred ");
            //                    break;
            //                case 4:
            //                    Console.Write("Fourhundred ");
            //                    break;
            //                case 5:
            //                    Console.Write("Fivehundred ");
            //                    break;
            //                case 6:
            //                    Console.Write("Sixhundred ");
            //                    break;
            //                case 7:
            //                    Console.Write("Sevenhundred ");
            //                    break;
            //                case 8:
            //                    Console.Write("Eighthundred ");
            //                    break;
            //                case 9:
            //                    Console.Write("Ninehundred ");
            //                    break;
            //                case 0:
            //                    break;
            //            }

            //            if(ones == 0 && tens ==0)
            //                Console.WriteLine();
            //            if (ones == 0 && tens != 1 && tens!=0)
            //                Console.Write("and ");

            //            switch (tens)
            //            {
            //                case 1:
            //                    if (hundrets != 0 && (tens != 0 || ones > 0))
            //                        Console.Write("and ");
            //                    switch (ones)
            //                    {
            //                        case 1:
            //                            Console.WriteLine("Eleven ");
            //                            break;
            //                        case 2:
            //                            Console.WriteLine("Twelve ");
            //                            break;
            //                        case 3:
            //                            Console.WriteLine("Thirteen ");
            //                            break;
            //                        case 4:
            //                            Console.WriteLine("Fourteen ");
            //                            break;
            //                        case 5:
            //                            Console.WriteLine("Fifteen ");
            //                            break;
            //                        case 6:
            //                            Console.WriteLine("Sixteen ");
            //                            break;
            //                        case 7:
            //                            Console.WriteLine("Seventeen ");
            //                            break;
            //                        case 8:
            //                            Console.WriteLine("Eighteen ");
            //                            break;
            //                        case 9:
            //                            Console.WriteLine("Nineteen ");
            //                            break;
            //                        case 0:
            //                            Console.WriteLine("Ten ");
            //                            break;
            //                    }
            //                    break;
            //                case 2:
            //                    Console.Write("Twenty ");
            //                    break;
            //                case 3:
            //                    Console.Write("Thirdy ");
            //                    break;
            //                case 4:
            //                    Console.Write("Fourty ");
            //                    break;
            //                case 5:
            //                    Console.Write("Fifty ");
            //                    break;
            //                case 6:
            //                    Console.Write("Sixty ");
            //                    break;
            //                case 7:
            //                    Console.Write("Seventy ");
            //                    break;
            //                case 8:
            //                    Console.Write("Eighty ");
            //                    break;
            //                case 9:
            //                    Console.Write("Ninety ");
            //                    break;
            //                case 0:
            //                    break;
            //            }
            //            if (tens != 1)
            //            {
            //                if (tens != 0 || (hundrets != 0 && ones != 0))
            //                    if (ones > 0)
            //                    {
            //                        Console.Write("and ");
            //                    }

            //                switch (ones)
            //                {
            //                    case 1:
            //                        Console.WriteLine("One ");
            //                        break;
            //                    case 2:
            //                        Console.WriteLine("Two ");
            //                        break;
            //                    case 3:
            //                        Console.WriteLine("Three ");
            //                        break;
            //                    case 4:
            //                        Console.WriteLine("Four ");
            //                        break;
            //                    case 5:
            //                        Console.WriteLine("Five ");
            //                        break;
            //                    case 6:
            //                        Console.WriteLine("Six ");
            //                        break;
            //                    case 7:
            //                        Console.WriteLine("Seven ");
            //                        break;
            //                    case 8:
            //                        Console.WriteLine("Eight ");
            //                        break;
            //                    case 9:
            //                        Console.WriteLine("Nine ");
            //                        break;
            //                    case 0:
            //                        if (tens != 0)
            //                            Console.WriteLine();
            //                        break;
            //                }
            //            }
            //                if (ones == 0 && tens == 0 && hundrets == 0)
            //                {
            //                    Console.WriteLine("Zero");
            //                }
            //            }
            //        } 
            //    }
            //}
            ///////////////////////////////////////////////////
            //int param = 0;

            Console.WriteLine("Please enter a number:");
            int param = int.Parse(Console.In.ReadLine());

            if (param <= 999 && param >= 0)
            {
                int temp = param;
                switch (temp / 100)
                {
                    case 0:
                        break;
                    case 1:
                        Console.Write("Сто ");
                        break;
                    case 2:
                        Console.Write("Двеста ");
                        break;
                    case 3:
                        Console.Write("Триста ");
                        break;
                    case 4:
                        Console.Write("Четиристотин ");
                        break;
                    case 5:
                        Console.Write("Петстотин ");
                        break;
                    case 6:
                        Console.Write("Шестстотин ");
                        break;
                    case 7:
                        Console.Write("Седемстотин ");
                        break;
                    case 8:
                        Console.Write("Осемстотин ");
                        break;
                    case 9:
                        Console.Write("Деветстотин ");
                        break;

                    default: Console.WriteLine("Error report!"); break;
                }
                if (temp / 100 != 0 && temp % 100 != 0)
                {
                    Console.Write("и ");
                }
                switch (temp / 10 % 10)
                {
                    case 0:
                        break;
                    case 1:
                        {
                            switch (temp % 10)
                            {
                                case 0:
                                    Console.WriteLine("десет ");
                                    break;
                                case 1:
                                    Console.WriteLine("единадесет ");
                                    break;
                                case 2:
                                    Console.WriteLine("дванайсет ");
                                    break;
                                case 3:
                                    Console.WriteLine("тринайсет ");
                                    break;
                                case 4:
                                    Console.WriteLine("четиранайсет ");
                                    break;
                                case 5:
                                    Console.WriteLine("петнайсет ");
                                    break;
                                case 6:
                                    Console.WriteLine("шестнайсет ");
                                    break;
                                case 7:
                                    Console.WriteLine("седемнайсет ");
                                    break;
                                case 8:
                                    Console.WriteLine("осемнайсет ");
                                    break;
                                case 9:
                                    Console.WriteLine("деветнайсет ");
                                    break;

                                default: Console.WriteLine("Error report!"); break;
                            }
                        }
                        break;
                    case 2:
                        Console.Write("двайсет и ");
                        break;
                    case 3:
                        Console.Write("трийсет и ");
                        break;
                    case 4:
                        Console.Write("четирсет и ");
                        break;
                    case 5:
                        Console.Write("педесет и ");
                        break;
                    case 6:
                        Console.Write("шейсет и ");
                        break;
                    case 7:
                        Console.Write("седемдесет и ");
                        break;
                    case 8:
                        Console.Write("осемдесет и ");
                        break;
                    case 9:
                        Console.Write("деветдесет и ");
                        break;

                    default: Console.Write("Error report!"); break;
                }
                switch (temp % 10)
                {
                    case 0:
                        if (temp == 0)
                        {
                            Console.Write("нула");
                        }
                        Console.Write("\n ");
                        break;
                    case 1:
                        if (temp / 10 % 10 == 1) break;
                        Console.WriteLine("едно");
                        break;
                    case 2:
                        if (temp / 10 % 10 == 1) break;
                        Console.WriteLine("две");
                        break;
                    case 3:
                        if (temp / 10 % 10 == 1) break;
                        Console.WriteLine("три ");
                        break;
                    case 4:
                        if (temp / 10 % 10 == 1) break;
                        Console.WriteLine("четири");
                        break;
                    case 5:
                        if (temp / 10 % 10 == 1) break;
                        Console.WriteLine("пет");
                        break;
                    case 6:
                        if (temp / 10 % 10 == 1) break;
                        Console.WriteLine("шест");
                        break;
                    case 7:
                        if (temp / 10 % 10 == 1) break;
                        Console.WriteLine("седем ");
                        break;
                    case 8:
                        if (temp / 10 % 10 == 1) break;
                        Console.WriteLine("осем ");
                        break;
                    case 9:
                        if (temp / 10 % 10 == 1) break;
                        Console.WriteLine("девет ");
                        break;

                    default: Console.WriteLine("Error report!"); break;
                }
            }
            else
            {
                Console.WriteLine(" Out of range! ");
            }
        }
    }
}