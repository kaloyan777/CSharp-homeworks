using System;

namespace _02._1._._.N__not_divisible_by_3_and_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time.

                Console.Write("Enter n: "); //Ex. n = 21.
                int n = int.Parse(Console.ReadLine());

                for (int i = 1; i <= n; i++)
                {
                    if (!((i % 7 == 0) && (i % 3 == 0)))
                    {
                        Console.WriteLine(i);
                    }
                }

            //...If statement could be:

                //if ((i % 3 == 0) && (i % 7 == 0))
                //{
                    ////Empty = Do nothing.
                //}
                //else //= !((i % 3 == 0) && (i % 7 == 0))
                //{
                //    Console.WriteLine(i);
                //}
            }
        }
    }