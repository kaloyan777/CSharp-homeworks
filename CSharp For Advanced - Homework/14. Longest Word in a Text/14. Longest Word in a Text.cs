using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Longest_Word_in_a_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write a program to find the longest word in a text. */

            string[] text = new string[] { "Welcome ", "to ", "the ", "Software ", "University", "." };
            string longestWord = string.Empty; //using = null; - incorrect

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i].Length > longestWord.Length)
                {
                    longestWord = text[i];
                }
            }
            Console.WriteLine(longestWord);
        }
    }
}