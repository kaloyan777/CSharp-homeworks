using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Remove_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write a program that takes as input two lists of names and removes from the first list all names given in the second list. 
             * The input and output lists are given as words, separated by a space, each list at a separate line. */
           

            //Create two lists/arrays, use "ReadLine()." + ".Split(...).", while moving/adding all the elements from the 1-st array to the List 
            //that holds the final result, make a check to determine which elements from the two arrays are the same, and to remove them
            //using ".Remove(...);". Then print the result.
            //http://www.dotnetperls.com/list-remove


            string[] listNames1 = Console.ReadLine().Split(' '), // Create the arrays, and give the ability to enter
                     listNames2 = Console.ReadLine().Split(' '); //the each element on the same row for each of the two arrays(using .Split(' ')).

            List<string> ListOfNames = new List<string>();       // Create List to hold the names(last result)

            for (int i = 0; i < listNames1.Length; i++)          // In the range of the length of array listNames1, 
            {
                ListOfNames.Add(listNames1[i]);                  //add every array element to the List,  

                for (int j = 0; j < listNames2.Length; j++)      //but if any of the elements in the 1st array is equal to any of the 2nd array, 
                {
                    if (listNames1[i] == listNames2[j])
                    {
                        ListOfNames.Remove(listNames1[i]);       //then remove from the List this one element.
                    }
                }
            }

            foreach (var name in ListOfNames)                    // And then, print the elements of the List(separated by spaces).
            {
                Console.Write(name + " ");
            }
            Console.WriteLine();
        }
    }
}