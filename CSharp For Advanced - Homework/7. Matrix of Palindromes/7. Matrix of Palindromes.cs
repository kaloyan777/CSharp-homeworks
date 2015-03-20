using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Matrix_of_Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write a program to generate the following matrix of palindromes of 3 letters with r rows and c columns:

            3 6	
            aaa aba aca	ada aea afa
            bbb bcb bdb	beb bfb bgb
            ccc cdc cec	cfc cgc chc
            */

            int rowSize = int.Parse(Console.ReadLine()),     //number of rows and columns
                colSize = int.Parse(Console.ReadLine());

            string[,] matrix = new string[rowSize, colSize]; //set sizes

            for (int i = 0; i < rowSize; i++)          //for every row,
            {
                for (int j = 0; j < colSize; j++)      //do this for every column
                {
                    matrix[i, j] = "" + (char)('a' + i) + (char)('a' + j + i) + (char)('a' + i); //set values
                }
            }

            //print
            for (int a = 0; a < rowSize; a++)
            {
                for (int b = 0; b < colSize; b++)
                {
                    Console.Write(matrix[a, b] + " ");
                }
                Console.WriteLine();
            }

            //.......................................Explained shotly :P...........................................//

            /*
            Console.WriteLine((char)('a' + 0)); // = a
            Console.WriteLine((char)('a' + 1)); // = b
            Console.WriteLine((char)('a' + 2)); // = c
            Console.WriteLine((char)('a' + 3)); // = d...
            */
        }
    }
}