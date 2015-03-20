using System;

namespace _02.Divided__without_remainder__by_7_and_5
{
    class Program
    {
        static void Main(string[] args)
        {
//////////..1..Boolean Expression
            Console.Write("Enter Number: ");

            int numbToCheck = Int32.Parse(Console.ReadLine());
            Console.WriteLine((numbToCheck % 5 ==0) && (numbToCheck % 7 == 0));

//////////..2..
            Console.Write("Enter Number: ");
            int a = int.Parse(Console.ReadLine()); 

            if (a % 5 == 0 && a % 7 == 0) //ako a se deli bez ostatuk na 5 i na 7..togava console.write
            {
                Console.WriteLine("The Number is dividable (without reminder) by 5 and 7!");
            }
            else
            {
                Console.WriteLine("The Number is not dividable (without reminder) by 5 and 7!");
            }
        }
    }
}
