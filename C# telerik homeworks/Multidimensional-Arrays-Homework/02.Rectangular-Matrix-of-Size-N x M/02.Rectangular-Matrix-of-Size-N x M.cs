using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Rectangular_Matrix_of_Size_N_x_M
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 
            //that has maximal sum of its elements.............................................................

            Console.Write("N: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("======");

            int[,] matrix = DoMatrixA(n);

            PrintMatrix(matrix);
            Console.WriteLine();
            matrix = DoMatrixB(n);
            PrintMatrix(matrix);
        }

        private static int[,] DoMatrixA(int dim)
        {
            int[,] matrix = new int[dim, dim];
            matrix[0, 0] = dim * dim;
            matrix[dim - 1, dim - 1] = 1;

            int counter = 1;
            for (int col = 1; col < dim; col++)
            {
                matrix[0, col] = matrix[0, col - 1] - counter;
                counter++;
            }

            for (int index = dim - 1; index > 0; index--)
            {
                int row = 0;
                int col = index;
                while (InRange(dim, row + 1, col - 1))
                {
                    matrix[row + 1, col - 1] = matrix[row, col] - 1;
                    row = row + 1;
                    col = col - 1;
                }
            }

            int previous = matrix[dim - 1, 0];
            for (int index = 1; index < dim - 1; index++)
            {
                int row = index;
                int col = dim - 1;
                matrix[row, col] = previous - 1;
                while (InRange(dim, row + 1, col - 1))
                {
                    matrix[row + 1, col - 1] = matrix[row, col] - 1;
                    previous = matrix[row + 1, col - 1];
                    row = row + 1;
                    col = col - 1;
                }
            }

            return matrix;
        }

        private static int[,] DoMatrixB(int dim)
        {
            int[,] matrix = new int[dim, dim];
            matrix[dim - 1, 0] = 1;
            int counter = 1;
            for (int row = dim - 2; row >= 0; row--)
            {
                matrix[row, 0] = matrix[row + 1, 0] + counter;
                int newRow = row;
                for (int diagonal = 1; diagonal <= counter; diagonal++)
                {
                    matrix[newRow + 1, diagonal] = matrix[newRow, diagonal - 1] + 1;
                    newRow++;
                }
                counter++;
            }

            matrix[0, dim - 1] = dim * dim;
            int diagonalLength = 2;
            int posX = 1;
            int posY = dim - 1;
            int prevX = 0;
            int prevY = dim - 1;

            for (int i = 1; i < counter - 1; i++)
            {
                for (int j = 1; j <= diagonalLength; j++)
                {
                    matrix[posX, posY] = matrix[prevX, prevY] - 1;
                    prevX = posX;
                    prevY = posY;
                    posX--;
                    posY--;
                }
                diagonalLength++;
                posX = i + 1;
                posY = dim - 1;
            }

            return matrix;
        }

        private static bool InRange(int dim, int row, int col)
        {
            bool rowInRange = row >= 0 && row < dim;
            bool colInRange = col >= 0 && col < dim;
            return rowInRange && colInRange;
        }

        private static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0, 4}", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}