using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _10.Join_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
              Write a program that takes as input two lists of integers and joins them. 
              The result should hold all numbers from the first list, and all numbers from the second list, without repeating numbers, 
              and arranged in increasing order. The input and output lists are given as integers, 
              separated by a space, each list at a separate line.

            Input:                                              Output:
            20 40 10 10 30 80
            25 20 40 30 10                                      10 20 25 30 40 80
            
            */

            //The same princip as Task 9, but this time use .Sort(); to sort the numbers in increasing order.

            //input 1:

            /*
            List<int> numbers1 = new List<int>();
            List<int> numbers2 = new List<int>();

            for (int i = 0; i < numbers1.Count; i++)
            {
                numbers1[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < numbers2.Count; i++)
            {
                numbers2[i] = int.Parse(Console.ReadLine());
            }
            */

            //input 2:

            List<int> numbers1= new List<int> { 20, 40, 10, 10, 30, 80 },
                      numbers2 = new List<int> { 25, 20, 40, 30, 10 };

            RemoveEquals(numbers2, numbers1);
        }

        static void RemoveEquals(List<int> numbers1, List<int> numbers2)
        {
            int counter = 1;
            for (int i = 0; i < numbers1.Count; i++)
            {
                for (int j = 0; j < numbers2.Count; j++)
                {
                    if (numbers1[i] == numbers2[j])
                    {
                        numbers2.RemoveAt(j);
                        counter = 0;
                        //http://www.dotnetperls.com/list-remove
                        //http://www.dotnetperls.com/removeat
                    }
                }
            }

            if (counter == 1)
            {
                PrintNumbers(numbers1, numbers2);
                return;
            }
            RemoveEquals(numbers1, numbers2);
        }

        static void PrintNumbers(List<int> removeNumbers, List<int> numbers)
        {
            numbers.AddRange(removeNumbers); //http://www.dotnetperls.com/list-addrange
            numbers.Sort();                  //http://www.dotnetperls.com/sort

            foreach (var item in numbers)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();



            //example 2: http://www.dotnetperls.com/sortedset

            string[] firstLine = Console.ReadLine().Split(' '),
                     secondLine = Console.ReadLine().Split(' ');

            SortedSet<int> sortedNumbers = new SortedSet<int>();

            //fills "sortedNumbers" with elements of "firstLine"
            foreach (var number in firstLine)
            {
                sortedNumbers.Add(int.Parse(number));
            }

            //fills "sortedNumbers" with elements of "secondLine"
            foreach (var number in secondLine)
            {
                sortedNumbers.Add(int.Parse(number));
            }

            //prints out the "SortedSet" result contained in "sortedNumbers"
            foreach (var number in sortedNumbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
}