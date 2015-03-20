using System;

namespace _04.Two_Positive_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            Again:
            Console.Write("First positive int > 0: ");
                int firstNum = int.Parse(Console.ReadLine());
            Console.Write("Second positive int > First int: ");
                int lastNum = int.Parse(Console.ReadLine());

                int counter = 0;
            if ((firstNum > 0) && (lastNum > firstNum))
            {
                for (int i = firstNum; i <= lastNum; i++)
                {
                    if (i % 5 == 0)
                    {
                        counter++;
                    }
                }
                Console.WriteLine(counter);
            }
            else
            {
                Console.WriteLine("Incorrect int, try again \"First int\" > 0 < \"Second int\"!: " + '\n');
                goto Again;
            }
        }
    }
}
