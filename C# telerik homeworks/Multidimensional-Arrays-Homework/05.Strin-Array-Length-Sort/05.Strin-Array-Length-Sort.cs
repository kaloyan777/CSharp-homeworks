using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Strin_Array_Length_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            //  You are given an array of strings. 
            //  Write a method that sorts the array by the length of its elements (the number of characters composing them).

            Console.Write("Enter array size: ");
            int size = int.Parse(Console.ReadLine());

            string[] strings = new string[size];
            int[] lengths = new int[size];

            for (int i = 0; i < size; i++)
            {
                strings[i] = Console.ReadLine();
                lengths[i] = strings[i].Length;
            }

            Array.Sort(lengths, strings);

            for (int i = 0; i < size; i++)
            {
                Console.Write(strings[i] + " ");
            }
            Console.WriteLine();
        }
    }
}