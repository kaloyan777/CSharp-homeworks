using System;

namespace _11.Random_Numbers_in_Given_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that enters 3 integers n, min and max (min ≤ max) and prints n random numbers in the range [min...max].          

            Random random = new Random();

            Start:
            Console.Write("sizeN: ");
            int sizeN = int.Parse(Console.ReadLine());
            int[] arrayN = new int[sizeN];

            Console.Write("min: ");
            int min = int.Parse(Console.ReadLine());

            Console.Write("max: ");
            int max = int.Parse(Console.ReadLine());

            if (min <= max)
            {
                if (max < sizeN)
                {
                    for (int i = min; i <= max; i++)
                    {
                        arrayN[i] = i; 
                    }
                    random = new Random();

                    int temp = 0;

                    int firstElement = 0;
                    int secondElement = 0;

                    for (int a = min; a <= max; a++)
                    {
                        firstElement = random.Next(min, max);
                        secondElement = random.Next(min, max);

                        temp = arrayN[firstElement];

                        arrayN[firstElement] = arrayN[secondElement];
                        arrayN[secondElement] = temp;

                        Console.WriteLine("=============================================================");

                        for (int b = min; b <= max; b++)
                        {
                            Console.WriteLine("Random number: " + arrayN[b]);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("incalid input ...max < sizeN!");
                    goto Start;
                }
            }
            else
            {
                Console.WriteLine("incalid input! ...min <= max");
                goto Start;
            }
        }
    }
}