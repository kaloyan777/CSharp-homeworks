using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Primes_in_Given_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            
            Write a method that calculates all prime numbers in given range and returns them as list of integers.

            static List<int> FindPrimesInRange(startNum, endNum)
            {
                …
            }
            
            Write a method to print a list of integers. 
            Write a program that enters two int numbers(each at a separate line) and prints all primes in their range, separated by a comma.
            
            ...Две е единственото просто(Prime) число, което е четно(Even)!
             
            if (n % 2 == 0 && n != 2) //    Ако числото е четно и не е рвано на 2, 
            {
                n != Prime;           //тогава то не е просто = От всичките четни числа, само две е просто.
            }
             
             */


            //Method "Main" will hold input + output.

            Console.Write("n = ");
            int start = int.Parse(Console.ReadLine());

            Console.Write("m = ");
            int end = int.Parse(Console.ReadLine());

            //Outpt:
            FindPrimesInRange(start, end); //   The result of the calculations of method "FindPrimesInRange(startNum, endNum)".
        }

        static void FindPrimesInRange(int startNum, int endNum)
        {
            List<int> numbers = new List<int>(); // The List will hold the numbers which are Prime
            int counter = 0;



            //  Some checks for valid/invalid input:

            if (startNum < 2)       //  Поправка на долната граница на диапазона, 
            {
                startNum = 2;       //понеже, ако за "startNum" бъде зададена стойност по-малка от 1-вото prime число, което е 2, 
                                    //ще получим грешен резултат(започвайки от числа които не са прости).
            }

            if (startNum > endNum)  //Ако start > end, въобще не съществува такъв списък от числа. 
            //Но ако start = end, тогава има валиден резултат = същото число(start), освен ако е четно(различно от 2).
            {
                Console.Write("Empty list!");
            }



            //(else) = The Solution:

            else // = else if(n >= m)
            {
                for (int i = startNum; i <= endNum; i++) //В диапазона от долната до горната граница(start/end), прави следното:
                {
                    if (startNum == endNum)             // Тази проверка е в случай, че input за start и end са еднакви и не са prime, 
                    {                                   //иначе ще изкарва само празен ред, без никакъв резултат при output...

                        if (i % 2 == 0 && i != 2)       // Вслучай, че въведеш число което е четно, 
                                                        //но по-голямо от 2(защото единственото prime число, което е четно е 2):
                        {
                            Console.Write("Empty list! \n(Start = End = Even numbers)");
                        }

                    }

                    for (int j = 1; j <= i; j++) // Установяване на делителите на числото. Виж(*) в края на решението...
                    {
                        if (i % j == 0)          // Ако всяко едно число се дели на 1 и на себе си без остатък,
                        {
                            counter++;           //отчети, че има такова като бройка(увеличавайки стойността на counter с 1)!
                        }
                        if (counter > 2)         // Ако делителите са повече от 2,
                        {
                            break;               //излез от цикъла "for".
                        }
                    }

                    if (counter <= 2)   //  Но ако броя на делителите е 1 или 2, 
                    {
                        numbers.Add(i); //тогава добави в списъка на "List numbers" това/тези число/а(деллител).
                    }

                    counter = 0;        //  Нулирване counter, за да може де бъде преизползван наново, 
                                        //понеже е нужна стойност = 0 за следващата проверка за изчисление за prime число...
                }
            }                                           //..........End of else..........//

            //Print the sequence
            foreach (var item in numbers)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}

/*                                                                     (*)
 
 
    for (int i = startNum; i <= endNum; i++)
    {
       for (int j = 1; j <= i; j++)  
       {
           if (i % j == 0)
       }
    }
  
 * Задавайки долна граница j = 1 и горна j <= i, обвързваме итерацията на втория цикъл с тази на първия,
 * по този начин if условието в долния цикъл ще провери за всеки един елемент(i) от горния цикъл, 
 * дали елемента се дели на 1(j = 1) и на себе си(j = i) едновременно.
  
 * Иначе казано, долният цикъл създава поредица от числа, които са равни на всичките числа от поредицата числа на горния цикъл,
 * но започва своята поредица от 1 като първо число(вместо първото на горния цикъл), 
 * след това всяко следващо число е равно вече на всяко едно следващо от тези на първия цикъл.
  
 * После дели всяко число от горния цикъл с всяко от тези на долния, така дели всяко число от горния на 1(j = 1) и на себе си(j <= i).
 
 * Може да се представи и така(без долния цикъл): 
 * 
                                             ...След предварителни там няк'ви си проерки за начало на редицата,
                                                for (int i = startNum; i <= endNum; i++) за всяко едно от числата в диапазона,
                                                {
                                                   if (i % i == 0 && i % 1 == 0)         ако се дели на себе си и на 1 без остатък, 
                                                   { 
                                                      тогава числото е Prime; 
                                                   }
                                                }
  
 */