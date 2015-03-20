using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Subset__of_K_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            //  * Write a program that reads three integer numbers N, K and S and an array of N elements from the console. 
            //  Find in the array a subset of K elements that have sum S or indicate about its absence.
            //............................................................................................................

            Console.Write("Enter wanted sum: ");
                int wantedSum = int.Parse(Console.ReadLine());
            Console.Write("Enter wanted size of the subset: ");
                int subsetsSize = int.Parse(Console.ReadLine());
            Console.Write("Enter array length: ");
                int arrayLength = int.Parse(Console.ReadLine());
            int[] array = new int[arrayLength];
            //.......................................................................................

            for (int i = 0; i < arrayLength; i++)
            {
                Console.Write("Element[{0}] = ", i);
                array[i] = int.Parse(Console.ReadLine());
            }
            //.......................................................................................
            int[] subset = new int[0];  //Search of all possible combinations of K elements in the array
            int maxSubset = (int)Math.Pow(2, arrayLength) - 1;

            //.......................................................................................
            for (int i = 1; i <= maxSubset; i++)
            {
                string iToBin = Convert.ToString(i, 2); //Find the numbers with K ones (1) in it to make all combinations with K numbers
                int counter = 0;
                for (int index = 0; index < iToBin.Length; index++)
                {
                    if (iToBin[index] == '1')
                    {
                        counter++;
                    }
                }
                //...................................................................................
                if (counter == subsetsSize)
                {
                    int sum = 0;
                    List<int> currentSubset = new List<int>(); //Keeping the current subset
                    currentSubset.Clear();

                    //...............................................................................
                    for (int j = 0; j <= arrayLength; j++)
                    {
                        int mask = 1 << j;
                        int nAndMask = mask & i;
                        if (nAndMask > 0)
                        {
                            sum += array[j];
                            currentSubset.Add(array[j]);
                        }
                    }
                    //...............................................................................
                    if (sum == wantedSum)
                    {
                        subset = (int[])currentSubset.ToArray().Clone(); //If there are few different subsets with equal wantedSum, we will take the last found
                    }
                }
            }
            //.......................................................................................
            Console.WriteLine("The subset with the wanted sum " + wantedSum + ": ");
            foreach (var item in subset)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}