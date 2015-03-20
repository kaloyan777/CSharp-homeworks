using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Counting_a_Word_in_a_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write a program that counts how many times a given word occurs in given text. 
             * The first line in the input holds the word. The second line of the input holds the text. 
             * The output should be a single integer number – the number of word occurrences. 
             * Matching should be case-insensitive. Note that not all matching substrings are words and should be counted. 
             * A word is a sequence of letters separated by punctuation or start / end of text. 
             
             * Input:                                                                   Output:
             * hi                                                                       3    
               Hidden networks say “Hi” only to Hitachi devices. Hi, said Matuhi. HI!

            */


            string[] text = new string[] { "Thank", "You", "very", "much", "!", "How", "are", "You", "?" };

            int counter = 1;
            string mostFrequent = null;
            string wantedWord = Console.ReadLine(); //You

            for (int i = 0; i < text.Length; i++)
            {
                for (int j = i + 1; j < text.Length; j++)
                {
                    if (text[i] == text[j])
                    {
                        counter++;
                        mostFrequent = text[i];
                    }
                }
            }
            if (mostFrequent == wantedWord)
            {
                Console.WriteLine("{0} repeates {1} times.", mostFrequent, counter);
            }
            else
            {
                Console.WriteLine("The word doesn't exists in the text!");
            }

            
             //The most repeated letter in a text.
             
            /*string text = Console.ReadLine();

            string[] textIntoArray = text.Select(c => c.ToString()).ToArray(); //turns string into array

            string mostRepLetter = null;
            for (int i = 0; i < textIntoArray.Length; i++)
            {
                for (int j = i + 1; j < textIntoArray.Length; j++)
                {
                    if (textIntoArray[i] == textIntoArray[j])
                    {
                        mostRepLetter = textIntoArray[i];
                    }
                }
            }
            Console.WriteLine(mostRepLetter);
            */


        }
    }
}