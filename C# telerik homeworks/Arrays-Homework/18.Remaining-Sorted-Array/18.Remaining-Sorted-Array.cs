using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Remaining_Sorted_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //  * Write a program that reads an array of integers and removes from it a minimal number of elements in such way 
            //that the remaining array is sorted in increasing order. Print the remaining sorted array. 
            //Example: {6, 1, 4, 3, 0, 3, 6, 4, 5}  {1, 3, 3, 4, 5}
            //..........................................................................................

            int[] array = new int[12] 
            { 2, 1, 7, 1, 14, 3, -3, 6, 0, 12, 3, 34 }; //1, 1, 3, 6, 12, 34
            List<int> remainingArray = new List<int>();

            int bestLength = 0;
            int maxSubset = (int)Math.Pow(2, 12) - 1;

            //..........................................................................................
            for (int i = 1; i <= maxSubset; i++)
            {
                bool isSorted = true;
                List<int> currentSequence = new List<int>();
                currentSequence.Clear();
                for (int j = 0; j <= 12; j++)
                {
                    int mask = 1 << j;
                    int nAndMask = mask & i;
                    if (nAndMask > 0)
                    {
                        currentSequence.Add(array[j]);
                    }
                }
                //.........................................................
                int[] sortedArray = currentSequence.ToArray();  //sorting array
                Array.Sort(sortedArray);
                //.........................................................
                for (int n = 0; n < currentSequence.Count; n++) //compare arrays - sorted with unsorted
                {

                    if (sortedArray[n] != currentSequence[n]) //if the arrays are different the combination isn't sorted
                    {
                        isSorted = false;
                    }
                }
                //............................................................................................
                //if the combination(current array) is sorted and the length of it is bigger than the last one
                //fill the result into a list 
                if (isSorted && currentSequence.Count > bestLength)
                {
                    bestLength = currentSequence.Count;
                    if (currentSequence.Count > 1)
                    {
                        remainingArray.Clear();
                        for (int y = 0; y < currentSequence.Count; y++)
                        {
                            remainingArray.Add(currentSequence[y]);
                        }
                    }
                }

            }
            //..............................................................................................
            foreach (var item in remainingArray)
            {
                Console.Write(item + " ");
            }
        }
    }
}