using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Count_of_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Write a program that reads a list of names and prints for each name how many times it appears in the list.
             The names should be listed in alphabetical order. Use the input and output format from the examples below
              
             Input                                      Output:
             Peter Steve Nakov Steve Alex Nakov         Alex -> 1
                                                        Nakov -> 2
                                                        Peter -> 1
                                                        Steve -> 2

             * 
             * не е мое репението.
             * 
            
             */

            string[] input = Console.ReadLine().Split(' ');
            Array.Sort(input);
            //foreach (var item in input)
            //{
            //    Console.WriteLine(item);
            //}

            var words = new HashSet<string>();
            for (int i = 0; i < input.Length; i++)
            {
                words.Add(input[i]);
            }

            int count = 0;
            foreach (string letter in words)
            {
                for (int j = 0; j < input.Length; j++)
                {
                    if (letter == input[j]) count++;
                }

                Console.WriteLine(letter + " -> " + count);
                count = 0;
            }
            Console.WriteLine();
        }
    }
}
