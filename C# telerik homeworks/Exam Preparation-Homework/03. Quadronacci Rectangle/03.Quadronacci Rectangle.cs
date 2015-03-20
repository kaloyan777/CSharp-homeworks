using System;

namespace _03.Quadronacci_Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            //Quadronacci-Rectangle:

            long first = int.Parse(Console.ReadLine());
            long second = int.Parse(Console.ReadLine());
            long third = int.Parse(Console.ReadLine());
            long fourth = int.Parse(Console.ReadLine());

            int Rows = int.Parse(Console.ReadLine());
            int Cols = int.Parse(Console.ReadLine());
            long result = 0;
            int currentCols = 0;

            if (Cols == 4) //If cols = 4, this is the same row, so just print it.
            {
                Console.WriteLine(first + " " + second + " " + third + " " + fourth);
            }
            else
            {
                Console.Write(first + " " + second + " " + third + " " + fourth + " ");
            }
            for (int row = 0; row < Rows; row++)
            {
                if (row == 0)
                {
                    currentCols = 4;
                }

                for (int col = currentCols; col < Cols; col++)
                {
                    result = first + second + third + fourth;
                    first = second; second = third;
                    third = fourth; fourth = result;
                   
                    if (col + 1 == Cols)
                    {
                        Console.Write(result);
                    }
                    else
                    {
                        Console.Write(result + " ");
                    }
                }
            }
        }
    }
} 