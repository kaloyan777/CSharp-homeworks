using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.All_Permutations
{
    class Program
    {
        static void Main(string[] args)
        {
            //  * Write a program that reads a number N and generates and prints all the permutations of the numbers [1 … N]. Example:
            //n = 3  {1, 2, 3}, {1, 3, 2}, {2, 1, 3}, {2, 3, 1}, {3, 1, 2}, {3, 2, 1}
            //..................................................................................

            Console.Write("Enter N: ");
            int size = int.Parse(Console.ReadLine());
            int[] array = new int[size];
            bool[] used = new bool[array.Length];
            Permuatations(array, used, 0);
        }
        //..................................................................................

        static void PrintCurrentPermutation(int[] array)
        {
            Console.WriteLine(String.Join(" ", array));
        }
        //......................................................................................

        static void Permuatations(int[] array, bool[] used, int index)
        {
            if (index == array.Length)
            {
                PrintCurrentPermutation(array);
                return;
            }
            //.........................................................
            for (int i = 0; i < array.Length; i++)
            {
                if (used[i])
                {
                    continue;
                }
                array[index] = i + 1;
                used[i] = true;
                Permuatations(array, used, index + 1);
                used[i] = false;

            }
        }
    }
}