using System;

namespace _7.Sort_3_Numbers_with_Nested_Ifs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that enters 3 real numbers and prints them sorted in descending order. 
            //Use nested if statements. Don’t use arrays and the built-in sorting functionality

            int a = int.Parse(Console.ReadLine()),
                b = int.Parse(Console.ReadLine()),
                c = int.Parse(Console.ReadLine());

            while (a == b && a == c) //(a == b && a == c && b == a && b == c && c == a && c == b)
            {
                Console.WriteLine("numbers are equal - {0},{1},{2}.", a, b, c);
                break;
            }

            while (!(a == b && a == c))
            {



                if (a > b && a > c && b > c)
                {
                    Console.WriteLine("{0},{1},{2}", a, b, c);
                }
                else if (a > b && a > c && c > b)
                {
                    Console.WriteLine("{0},{1},{2}", a, c, b);
                }



                else if (b > a && b > c && a > c)
                {
                    Console.WriteLine("{0},{1},{2}", b, a, c);
                }
                else if (b > a && b > c && c > a)
                {
                    Console.WriteLine("{0},{1},{2}", b, c, a);
                }



                else if (c > a && c > b && a > b)
                {
                    Console.WriteLine("{0},{1},{2}", c, a, b);
                }
                else if (c > b && c > a && b > a)
                {
                    Console.WriteLine("{0},{1},{2}", c, b, a);
                }



                else if (a == b)
                {
                    if (a > c)
                    {
                        Console.WriteLine("{0},{1},{2}", a, b, c);
                    }
                    else if (a < c)
                    {
                        Console.WriteLine("{0},{1},{2}", c, b, a);
                    }
                }
                else if (a == c)
                {
                    if (a > b)
                    {
                        Console.WriteLine("{0},{1},{2}", a, c, b);
                    }
                    else if (a < b)
                    {
                        Console.WriteLine("{0},{1},{2}", b, a, c);
                    }
                }
                    
                    
                
                else if (b == a)
                {
                    if (b > c)
                    {
                        Console.WriteLine("{0},{1},{2}", a, b, c);
                    }
                    else if (b < c)
                    {
                        Console.WriteLine("{0},{1},{2}", c, a, b);
                    }
                }
                else if (b == c)
                {
                    if (b > a)
                    {
                        Console.WriteLine("{0},{1},{2}", b, c, a);
                    }
                    else if (b < a)
                    {
                        Console.WriteLine("{0},{1},{2}", a, b, c);
                    }
                }
                    
                    
                    
                else if (c == a)
                {
                    if (c > b)
                    {
                        Console.WriteLine("{0},{1},{2}", a, c, b);
                    }
                    else if (c < b)
                    {
                        Console.WriteLine("{0},{1},{2}", b, a, c);
                    }
                }
                else if (c == b)
                {
                    if (c > a)
                    {
                        Console.WriteLine("{0},{1},{2}", b, c, a);
                    }
                    else if (c < a)
                    {
                        Console.WriteLine("{0},{1},{2}", a, b, c);
                    }
                }
                //
                //БААААААААААААААСИ логиките!
                //
                break;
            }
        }
    }
}