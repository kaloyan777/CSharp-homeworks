using System;

namespace _01.Odd_or_Even_Int
{
    class Program
    {
        static void Main(string[] args)
        {
//////////..1..
            Console.Write("Enter another integer number: ");
            int numberToCheck = int.Parse(Console.ReadLine());
            Console.WriteLine((numberToCheck % 2 == 0) ? ("- The Int Number is Even" + '\n') : ("- The Int Number is Odd" + '\n'));
            
//////////..2..
            Console.Write("Enter some integer number: ");
            int numberInt = int.Parse(Console.ReadLine());

            if (numberInt % 2 == 0)
            {
                Console.WriteLine("- The Int Number is Even." + '\n');
            }
            else
            {
                Console.WriteLine("- The Int Number is Odd." + '\n');
            }
        }
    }
}
