using System;

namespace _09.Isosceles_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode; //to read symbol.
            //Console.OutputEncoding = Encoding.UTF8;

            int rows = 3; // = 9 symbols.
            char copyRight = '©'; //using symbol.

            int cells = (rows * 2) - 1; //The number of cells that must be filled.
            int symbIncrement = 1; //To count the increment of symbols for every next row.

            for (int i = 0; i < rows; i++ )
            {                
                int blankCount = cells - symbIncrement; //Total Blank cells on row.
                int symbCount = cells - blankCount; //Total Symbol cells on row.

                string blankCells = new String(' ', blankCount / 2); //Divide by 2 the total ammount of blank cells, for the triangle to be centered.
                string fullCells = new String(copyRight, symbCount);

                Console.Write("{0}{1}", blankCells, fullCells);

                symbIncrement = symbIncrement + 2; //The count of the symbols used for every next row, increased by 2.
                Console.WriteLine(); //,or Console.WriteLine('\n');
            }
        }
    }
}

