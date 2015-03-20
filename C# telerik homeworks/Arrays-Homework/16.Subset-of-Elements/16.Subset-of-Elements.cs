using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Subset_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            //  * We are given an array of integers and a number S. 
            //  Write a program to find if there exists a subset of the elements of the array that has a sum S. Example:
            //arr={2, 1, 2, 4, 3, 5, 2, 6}, S=14  yes (1+2+5+6)
            //...............................................................................................

            Console.Write("Enter wanted sum: ");
                int wantedSum = int.Parse(Console.ReadLine());
            Console.Write("Enter array length: ");
                int arrayLength = int.Parse(Console.ReadLine());
                int[] array = new int[arrayLength];
            //.........................................................

            for (int i = 0; i < arrayLength; i++)
            {
                Console.Write("Element[{0}] = ", i);
                array[i] = int.Parse(Console.ReadLine());
            }
            //.........................................................

            List<List<int>> subsets = new List<List<int>>();

            int maxSubset = (int)Math.Pow(2, arrayLength) - 1;
            for (int i = 1; i <= maxSubset; i++)
            {
                int lookingSum = 0;
                List<int> currentSubset = new List<int>();
                currentSubset.Clear();
                //...................................
                for (int j = 0; j <= arrayLength; j++)
                {
                    int mask = 1 << j;
                    int nAndMask = mask & i;
                    if (nAndMask > 0)
                    {
                        lookingSum += array[j];
                        currentSubset.Add(array[j]);
                    }
                }
                if (lookingSum == wantedSum)
                {
                    subsets.Add(currentSubset);
                }
            }

            //...............................................................................
            Console.WriteLine("The subsets with sum {0} are the following:", wantedSum);
            foreach (var list in subsets)
            {
                foreach (var number in list)
                {
                    Console.Write(number + " ");
                }
                Console.WriteLine();
            }
        }
    }
}