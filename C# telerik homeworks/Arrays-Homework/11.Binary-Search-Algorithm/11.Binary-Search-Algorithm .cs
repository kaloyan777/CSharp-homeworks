using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Binary_Search_Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Write a program that finds the index of given element in a sorted array of integers, using the binary search algorithm.
            //  Да се реализира двоично търсене (binary search) в сортиран целочислен масив.
            //  Потърсете в Интернет информация за алгоритъма "binary search". 
            //  Какво трябва да е изпълнено, за да използваме този алгоритъм?
            //......................................................................................................

            int number = int.Parse(Console.ReadLine());
            int[] sortedArray = new int[8] { 1, 10, 100, 200, 300, 400, 500, 600 };
            //........................................................................

            int left = 0;
            int right = sortedArray.Length - 1;
            int result = -1;
            //....................................

            while (left <= right)
            {
                int middle = (left + right) / 2;
                if (sortedArray[middle] == number)
                {
                    result = middle;
                    break;
                }
                else if (sortedArray[middle] > number)
                {
                    right = middle - 1;
                }
                else
                {
                    left = middle + 1;
                }
            }
            //.........................................................................

            if (result > -1 && result < 8)
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Index not found.");
            }
        }
    }
}