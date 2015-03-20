using System;

namespace _04.Assign_Int_in_Hexadecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            int turnOne = 254;
            Console.WriteLine("{0:X}",  turnOne);

            //

            int turnTwo = 0xFE;
            Console.WriteLine(turnTwo);
        }
    }
}
