using System;

namespace _07.Current_DateAndTime
{
    class Program
    {
        static void Main(string[] args)
        {
            //Version1
            Console.WriteLine(DateTime.Now);
            
            Console.WriteLine();

            //Version 2
            DateTime currentTime = DateTime.Now;
            Console.WriteLine("Current_DateAndTime: " + currentTime);
        }
    }
}
