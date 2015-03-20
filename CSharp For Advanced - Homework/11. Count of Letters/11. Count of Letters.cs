using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _11.Count_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Write a program that reads a list of letters and prints for each letter how many times it appears in the list. 
             The letters should be listed in alphabetical order. Use the input and output format from the examples below. 
                
             Input: h d h a a a s d f d a d j d s h a a
             
             Output: 
               a -> 6
               d -> 5
               f -> 1
               h -> 3
               j -> 1
               s -> 2
             * 
             * Не е мое репението.
             * 
 
            */
    
            string[] array = new string[] { "h", "d", "h", "a", "a", "a", "s", "d", "f", "d", "a", "d", "j", "d", "s", "h", "a", "a" };

            Array.Sort(array);
            //foreach (var item in array)
            //{
            //    Console.WriteLine(item);
            //}

            //http://www.dotnetperls.com/hashset
            var alphabet = new HashSet<string>();

            for (int i = 0; i < array.Length; i++)
            {
                alphabet.Add(array[i]);
            }

            int count = 0;
            foreach (string letter in alphabet)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (letter == array[j]) 
                    { 
                        count++; 
                    }
                }
                Console.WriteLine(letter + " -> " + count);
                count = 0;
            }
        }
    }
}



