using System;

namespace _18.Trailing_Zeroes_in_N_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that calculates with how many zeroes the factorial of a given number n has at its end. 
            //Your program should work well for very big numbers, e.g. n=100000. 

            //Пресмятането на факториел от числото директно е много времеемка задача. 
            //Вместо това ще използваме любопитното свойство на факториелът, което гласи, 
            //че броят на крайните нули е равен на сборът от броя на пътите, които входното число може да се 
            //раздели на степените на 5(5,25,125...), при които да се получи остатък по-голям или равен на 1.


            int number = int.Parse(Console.ReadLine());

            int zeroes = 0;
            int divisor;

            for (int i = 5; i <= number; i += 5)
            {
                divisor = i;
                while (divisor % 5 == 0)
                {
                    divisor /= 5;
                    zeroes++;
                }
            }
            Console.WriteLine("Zeroes count: " + zeroes);

            //ex 

            number = int.Parse(Console.ReadLine());
            zeroes = 0;
            divisor = 5;

            while (number / divisor >= 1)
            {
                zeroes += (number / divisor);
                divisor *= 5;
            }
            Console.WriteLine("Zeroes count: " + zeroes);

        }
    }
}