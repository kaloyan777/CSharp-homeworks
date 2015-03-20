using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _2.Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a Boolean method IsPrime(n) that check whether a given integer number n is prime
            //просто число се нарича всяко естествено число, по-голямо от 1, което има точно два естествени делителя — 1 и самото себе си.
            //Две е единственото просто число, което е четно.

            BigInteger n = BigInteger.Parse(Console.ReadLine()); // Числото за проверка

            bool IsPrime = true;                                 // Помощна променлива с която се отчита дали числото е Prime или не(True/False),
                                                                 //приемаме, че по default е True.

            Console.WriteLine(PrimeNumber(n, IsPrime));          // Дава релултата от изчисленията в метода "PrimeNumber" с параметри "int n,
                                                                 //bool IsPrime".
        }

        static bool PrimeNumber(BigInteger n, bool IsPrime)
        {
            int counter = 0; // "Counter" ще служи за отчитане броя на естествените делители на вс. число в диапазона от 2 до числото, 
                             //за което проверяваме дали е просто, като ще се ползва оператор "++" за инкрементация на стойността му.

            if (n > 1)       // = if(n >= 2) = 2 включително, защото: "Две е единственото просто число, което е четно."
            {
                for (int i = 1; i <= n; i++) // Движи по вс. числа от 1 до числото за което проверява дали е Prime,
                {
                    if (n % i == 0)          //намери бр. на естествените делители на n измежду тази редица,
                    {
                        counter++;           //ако намери естествен делител, да увеличи стойността на counter с 1.
                    }
                }

                if (counter > 2)            //Ако намерените ест. делители са повече от два, 
                {
                    IsPrime = false;        //тогава числото не е Prime(защото простите числа имат само два делителя).
                    return IsPrime;         //  Установи резултата с return и го прати в Console.WriteLine(), 
                                            //при извикване на "PrimeNumber"(името на този метод с резултат за Prime).
                }
                else
                {
                    IsPrime = true;
                    return IsPrime;
                }
            }
            else // = else if(n < 1 || n == 1) = if(n < 2)
            {
                IsPrime = false;
                return IsPrime;
            }
        }
    }
}