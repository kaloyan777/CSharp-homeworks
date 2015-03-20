using System;

namespace _14._1._._.N_numbers_arranged_as_a_Spiral
{
    class Program
    {
        static void Main(string[] args)
        {
        //* Write a program that reads a positive integer number N (N < 20) from console and outputs in the console the numbers 1 ... N numbers arranged as a spiral.
        //Example for N = 4

            Console.Write(" - Enter number to create dimensions of The Matrix: ");
            int matrixN = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int[ , ] arr = new int[matrixN, matrixN];

                int count = 1;

                int i = 0;
                int j = 0; 

                int a = 0;
                int b = 0;
                int c = 0;

            for (i = 0; i < matrixN; i++)
            {
                //...........................Right
                for (j = i; j < (matrixN - i); j++) 
                {
                    arr[i, j] = count++;
                }
                j--;
                //................................Down
                for (a = i; a < (matrixN - i - 1); a++)
                {
                    arr[(a + 1), j] = count++;
                }
                //................................Left
                for (b = a; b > i; b--)
                {
                    arr[a, (b - 1)] = count++;
                }
                //..................................Up
                for (c = a; c > (i + 1); c--)
                {
                    arr[(c - 1), b] = count++;
                }
            }

            //......................................Matrix
            for (int I = 0; I < matrixN; I++)
            {
                for (int J = 0; J < matrixN; J++)
                {
                    Console.Write("{0,4}", arr[I, J]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}