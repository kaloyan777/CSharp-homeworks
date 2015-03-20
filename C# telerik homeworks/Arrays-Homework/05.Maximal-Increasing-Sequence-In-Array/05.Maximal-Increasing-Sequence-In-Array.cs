using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Maximal_Increasing_Sequence_In_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Write a program that finds the maximal increasing sequence in an array. 
            //  Example:{3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.
            //...............................................................................................
            //  Напишете програма, която намира максималната подредица от нарастващи елементи в масив arr[n]. 
            //  Елементите може и да не са последователни. 
            //  Пример: {9, 6, 2, 7, 4, 7, 6, 5, 8, 4}  {2, 4, 6, 8}.
            //  http://msdn.microsoft.com/en-us/library/windows/apps/system.collections.arraylist(v=vs.85).aspx
            //  https://groups.google.com/forum/?fromgroups#!topic/telerikacademy/MgxTqMeyZak

            //  Задачата може да се реши с два вложени цикъла и допълнителен масив len[0..n-1]. Нека в стойността len[i] пазим дължината на
            //най-дългата нарастваща подредица, която започва някъде в масива(не е важно къде) и завършва с елемента arr[i]. 
            //  Тогава len[0]=1, alen[x] е максималната сума max(1 + len[prev]), където prev < x и arr[prev] < arr[x]. 

            //  Следвайки дефиницията len[0..n-1] може да се пресметне с два вложени цикъла по следния начин: 
            //  Първият цикъл обхожда масива последователно отляво надясно с водеща променлива x. 
            //  Вторият цикъл (който е вложен в първия) обхожда масива от началото до позиция x-1 и търси елемент prev с максимална стойност 
            //на len[prev], за който arr[prev] < arr[x].

            //  След приключване на търсенето len[x] се инициализира с 1 + най-голямата намерена стойност на len[prev] или с 1,
            //ако такава не е намерена.

            //  Описаният алгоритъм намира дължините на всички максимални нарастващи подредици, завършващи във всеки негов елемент. 
            //  Най-голямата от тези стойности е дължината на най-дългата нарастваща подредица. 
            //  Ако трябва да намерим самите елементи съставящи тази максимална нарастваща подредица, можем да започнем от елемента, 
            //в който тя завършва (нека той е на индекс x), да го отпечатаме и да търсим предходния елемент (prev).

            //  За него е в сила, че prev < x и len[x] = 1+len[prev]. 
            //  Така намирайки и отпечатвайки предходния елемент докато има такъв, можем да намерим елементите
            //съставящи най-дългата нарастваща подредица в обратен ред (от последния към първия).
            //.....................................................................................................

            int[] array = { 9, 6, 2, 7, 4, 7, 6, 5, 8, 4 };
            for (int i = 0; i < array.Length; i++) //Print the array's elements
            {
                Console.Write(array[i] + ", ");
            }
            Console.WriteLine('\n' + new String('=', 30));

            //.....................................................................................................

            List<int> maxList = new List<int>();

            for (int mask = 1; mask < (1 << array.Length); mask++)
            {
                List<int> list = new List<int>();
                for (int i = 0; i < array.Length; i++)
                {
                    if (((mask >> i) & 1) == 1)
                    {
                        if ((list.Count == 0) || ((list[list.Count - 1]) < (array[i])))
                            list.Add(array[i]);
                    }
                    if (list.Count > maxList.Count)
                    {
                        maxList = list;
                    }
                }
            }
            Console.Write("Maximal increasing sequence in an array: ");
            foreach (int element in maxList)
            {
                Console.Write(element + ", ");
            }
            Console.WriteLine('\n');
        }
    }
}