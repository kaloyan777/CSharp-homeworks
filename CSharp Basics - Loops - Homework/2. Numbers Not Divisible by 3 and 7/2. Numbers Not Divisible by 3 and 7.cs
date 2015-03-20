using System;

namespace _2.Numbers_Not_Divisible_by_3_and_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n not divisible by 3 and 7,
            //on a single line, separated by a space.

            //example 1:

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                //1:
                        if (i % 3 != 0 && i % 7 != 0)
                        {
                            Console.WriteLine(i);
                        }
                        else
                        {
                            //Console.WriteLine("Divisible by 3 and 7: " + i);
                        }

                //1 = 2................................................................

                //2:
                        //if (i % 3 == 0 && i % 7 == 0)
                        //{
                            ////Console.WriteLine("Divisible by 3 and 7: " + i);
                        //}
                        //else
                        //{
                        //    Console.WriteLine(i);
                        //}
            }



            //example 2:

            int counter = 1;
            while (counter <= n)
            {
                if (counter % 3 != 0 && counter % 7 != 0)
                {
                    Console.WriteLine(counter);
                }
                counter++;
            }
        }
    }
}

