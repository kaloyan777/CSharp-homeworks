﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Overload_Matrix_Class
{
    //  * Write a class Matrix, to holds a matrix of integers. Overload the operators for adding, 
    //subtracting and multiplying of matrices, indexer for accessing the matrix content and ToString().

    //1. Създавам клас данни, които съдържат колко реда и колони има матрицата, както и get методи за тях.

    //2.Създавам indexer за класа (как става това е описано тук http://msdn.microsoft.com/en-us/library/aa288465(v=vs.71).aspx)

    //3. Оверлоадвам операторите с помощта на линка, предостажен от jassonpet. В общи линии за различните операции само се променя един символ. Във всеки оверлоаднат оператор проверявам дали матриците са с еднаква дължина - ако не са се хвърля Exception.

    //4. Написвам и ToString() метода използвайки StringBuilder.

    //5. Пълня 2 матрици с някакви данни и ги показвам на екрана. Извършвам всяка от операциите и след нея показвам резултата.

    class OperatorOverloading
    {

        public class Matrix
        {
            private int rows;
            private int cols;
            private int[,] matrix;

            public Matrix(int x, int y)
            {
                rows = x;
                cols = y;
                matrix = new int[rows, cols];
            }

            public int this[int x, int y]
            {
                get
                {
                    return matrix[x, y];
                }
                set
                {
                    matrix[x, y] = value;
                }
            }

            public int getRows()
            {
                return rows;
            }

            public int getCols()
            {
                return cols;
            }

            public static Matrix operator +(Matrix first, Matrix second)
            {
                if (first.getRows() != second.getRows() || first.getCols() != second.getCols())
                {
                    throw new Exception("Matrices must have the same dimensions!");
                }

                Matrix result = new Matrix(first.getRows(), first.getCols());

                for (int i = 0; i < first.matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < second.matrix.GetLength(1); j++)
                    {
                        result[i, j] = first[i, j] + second[i, j];
                    }
                }
                return result;
            }

            public static Matrix operator -(Matrix first, Matrix second)
            {
                if (first.getRows() != second.getRows() || first.getCols() != second.getCols())
                {
                    throw new Exception("Matrices must have the same dimensions!");
                }

                Matrix result = new Matrix(first.getRows(), first.getCols());

                for (int i = 0; i < first.matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < second.matrix.GetLength(1); j++)
                    {
                        result[i, j] = first[i, j] - second[i, j];
                    }
                }
                return result;
            }

            public static Matrix operator *(Matrix first, Matrix second)
            {
                if (first.getRows() != second.getRows() || first.getCols() != second.getCols())
                {
                    throw new Exception("Matrices must have the same dimensions!");
                }

                Matrix result = new Matrix(first.getRows(), first.getCols());

                for (int i = 0; i < first.matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < second.matrix.GetLength(1); j++)
                    {
                        result[i, j] = first[i, j] * second[i, j];
                    }
                }
                return result;
            }

            public override string ToString()
            {
                StringBuilder matrixToString = new StringBuilder();

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        matrixToString.Append(String.Format("{0} ", matrix[i, j]));
                    }
                    matrixToString.Append("\n");
                }

                return matrixToString.ToString();
            }

        }

        static void Main(string[] args)
        {
            Matrix a = new Matrix(4, 4);
            Matrix b = new Matrix(4, 4);
            Matrix result;

            //tests - entering some random-ish data
            int counter = 1;
            for (int i = 0; i < a.getCols(); i++)
            {
                for (int j = 0; j < a.getRows(); j++)
                {
                    a[i, j] = counter;
                    b[i, j] = j + counter;
                    counter++;
                }
            }

            //printing the test matrices
            Console.WriteLine(a);
            Console.WriteLine(b);

            result = a + b;
            Console.WriteLine("Addition:");
            Console.WriteLine(result);

            result = a - b;
            Console.WriteLine("Subtraction:");
            Console.WriteLine(result);

            result = a * b;
            Console.WriteLine("Multiplication:");
            Console.WriteLine(result);
        }
    }
}