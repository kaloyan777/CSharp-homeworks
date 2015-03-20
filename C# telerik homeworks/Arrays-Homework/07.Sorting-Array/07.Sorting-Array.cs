using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sorting_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Sorting an array means to arrange its elements in increasing order. Write a program to sort an array. 
            //  Use the "selection sort" algorithm: Find the smallest element, move it at the first position, 
            //find the smallest from the rest, move it at the second position, etc.
            //.....................................................................................................
            //  Сортиране на масив означава да подредим елементите му в нарастващ (намаляващ) ред. 
            //  Напишете програма, която сортира масив. Да се използва алгоритъма "Selection sort".
            //  Потърсете в Интернет информация за алгоритъма "Selection sort" и неговите реализации. 
            //  Накратко идеята е да се намери най-малкият елемент, после да се сложи на първа позиция, 
            //след това да се намери втория най-малък и да се сложи на втора позиция и т.н., 
            //докато целият масив се подреди в нарастващ ред.
            //.................................................................................................................

            int[] array = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
            int minKeyElement = 0;
            int tempElement = int.MinValue;

            //...........................................................
            for (int j = 0; j < array.Length - 1; j++)
            {
                minKeyElement = j;
                for (int p = j + 1; p < array.Length; p++)
                {
                    if (array[p] < array[minKeyElement])
                    {
                        minKeyElement = p;
                    }
                }

                tempElement = array[minKeyElement];
                array[minKeyElement] = array[j];
                array[j] = tempElement;
            }
            //...Sorted array............................................
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}