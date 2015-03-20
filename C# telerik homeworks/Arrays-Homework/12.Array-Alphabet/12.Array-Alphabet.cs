using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Array_Alphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Write a program that creates an array containing all letters from the alphabet (A-Z). 
            //  Read a word from the console and print the index of each of its letters in the array.
            //.......................................................................................

            char[] alphabet = new char[26]
           {
            'A', 'B', 'C', 'D', 'E', 'F',
            'G', 'H', 'I', 'J', 'K', 'L',
            'M', 'N', 'O', 'P', 'Q', 'R',
            'S', 'T', 'U', 'V', 'W', 'X',
            'Y', 'Z'
            };

            //............................................
            Console.Write("- Type any letter from the alphabet, or a whole word, or a sentence, or a text, or a poem, or a nuclear bomb: ");
            string word = Console.ReadLine();
            //............................................
            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    string toLowerLetter = alphabet[j].ToString().ToLower();
                    if ((word[i] == alphabet[j]) || (word[i].ToString() == toLowerLetter))
                    {
                        int number = j + 1;
                        Console.WriteLine(number);
                    }
                }
            }
            //......
        }
    }
}