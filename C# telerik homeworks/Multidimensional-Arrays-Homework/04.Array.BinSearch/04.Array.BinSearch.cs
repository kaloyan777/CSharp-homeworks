using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Array.BinSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Write a program, that reads from the console an array of N integers and an integer K, 
            //sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K. 

            //  If value is not found and value is less than one or more elements in array, 
            //a negative number which is the bitwise complement of the index of the first element that is larger than value. 
            //  If value is not found and value is greater than any of the elements in array, 
            //a negative number which is the bitwise complement of (the index of the last element plus 1).

            //Метода работи по следния начин:
            //1) връща стойност индекса на елемента "к" в масив "array"
            //2) ако върнатото число < 0 - не е намерeн елемент к
            //3) aкo върнатото число >= 0 - връща индекса на елемента
 
            //Това е моето решение с този метод.
            //http://pastebin.com/UKHGjm6p
            //Най-отдоло в кода съм разписал примерен тест.

 
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(array);
 
            int elemIndex = Array.BinarySearch(array, k);
            while (elemIndex < 0)
            {
                if (k < array[0])
                {
                    break;
                }
                k--;
                elemIndex = Array.BinarySearch(array, k);
                
            }
            if (elemIndex < 0)
            {
                Console.WriteLine("Element not found!");
            }
            else
            {
                Console.WriteLine("Element <= K found at index [{0}] = {1}",elemIndex,array[elemIndex]);
            }
        }
    }
}