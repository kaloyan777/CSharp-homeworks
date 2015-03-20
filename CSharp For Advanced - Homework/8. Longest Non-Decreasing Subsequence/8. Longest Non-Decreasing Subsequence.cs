using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Longest_Non_Decreasing_Subsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write a program that reads a sequence of integers and finds in it the longest non-decreasing subsequence. 
            In other words, you should remove a minimal number of numbers from the starting sequence, so that the resulting 
            sequence is non-decreasing. In case of several longest non-decreasing sequences, print the leftmost of them. 
            The input and output should consist of a single line, holding integer numbers separated by a space.*/

            /* Input: 1	                                     Output: 1
               7 3 5 8 -1 6 7	                             3 5 6 7
               1 1 1 2 2 2	                                 1 1 1
               1 1 1 3 3 3 2 2 2 2                           2 2 2 2
               11 12 13 3 14 4 15 5 6 7 8 7 16 9 8	         3 4 5 6 7 8 9
            
              
            
             Описание на входа:
             На първия ред се въвежда броя на елементите n – цяло число в интервала [1,2500].
             Ня следващите n реда се въвеждат числата от масива, които са цели числа в интервала 
             [-2 147 483 648, 2 147 483 647].
             Описание на изхода
             На единствени ред на изхода да се отпечатат числата от масива, след като от него са премахнати минимален брой числа, 
             така че да е сортиран в нарастващ ред. Ако съществуват няколко варианта, да се отпечата отговора с максимално леви елементи.
             Анализ на задачата
             В масива arrayInt, запазваме дадената редица от числа. Създаваме втори масив sequanceLength (с дължина равна на първия), 
             в който пазим дължината на най-дългата редица, която може да има край, съвпадащ със съответния елемент от arrayInt. 
             Съответно за всеки елемент, търсим елемент в ляво от него, който е по-малък и е край на максимално дълга редица. 
             Максималната дължина на редица свършваща в текущия елемент е равна на намерената в ляво дължина, 
             която отговаря на условието увеличена с 1. Създаваме и трети масив previousInd, в който за всеки елемент пазим индекса на предходния
             елемент, при образуване на редицата. Претърсването отляво надясно,ни гарантира отговор съдържащ най-левите възможни елементи. 
             С променливите maxCount и bestEndInd(индекса на последния елемент, с който свършва търсената редица) лесно проследяваме 
             елементите от които е образувана растящата ни редица (но в обратен ред).

             * 
             * Не е мое решението.
             * 
            */

            //read data
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            //find longest rising sequence
            int[] sequenceLength = new int[n];
            int[] previousInd = new int[n];

            int bestEndInd = 0;
            int maxCount = 0;

            for (int i = 0; i < array.Length; i++)
            {
                int maxBefore = 0;
                for (int j = 0; j < i; j++)
                {
                    if (array[j] < array[i] && sequenceLength[j] > maxBefore)
                    {
                        maxBefore = sequenceLength[j];
                        previousInd[i] = j;
                    }
                }
                sequenceLength[i] = maxBefore + 1;
                if (sequenceLength[i] > maxCount)
                {
                    maxCount++;
                    bestEndInd = i;
                }
            }

            //print
            int arrayIntInd = bestEndInd;
            int[] bestSequence = new int[maxCount];

            for (int i = 0; i < maxCount; i++)
            {
                bestSequence[i] = array[arrayIntInd];
                arrayIntInd = previousInd[arrayIntInd];
            }
            for (int i = 0; i < maxCount; i++)
            {
                Console.Write(bestSequence[maxCount - i - 1]);
                if (i < maxCount - 1)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}