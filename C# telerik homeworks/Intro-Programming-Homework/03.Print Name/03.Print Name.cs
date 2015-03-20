using System;

namespace _03.Print_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            //Version 1
            Console.Write("Brao ");
            Console.Write("Moito ");
            Console.WriteLine("M'che!" + "\n");

            //Version 2
            string firstName = "Brao ";
            string secName = "Moito ";
            string thirdName = "M'che!";

            Console.WriteLine("My full Name: " + firstName + secName + thirdName);
        }
    }
}
