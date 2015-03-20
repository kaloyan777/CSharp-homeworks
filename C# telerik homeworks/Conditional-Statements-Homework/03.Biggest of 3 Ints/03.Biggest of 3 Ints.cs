using System;

namespace _03.Biggest_of_3_Ints
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that finds the biggest of three integers using nested if statements.

            Console.WriteLine("Enter 3 integers: ");
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            if ((first == second) && (second == third))
            {
                Console.Write('\a');
                Console.WriteLine("Numbers are equal, duuude!");
            }
            else
            {
                if ((first >= second) && (first >= third)) //Using >= , not > , so to make the logic more unique, otherwise Console.Write wouldn't show, if there are 2 equal numbers among the three.
                {
                    Console.WriteLine("The biggest number is: " + first);
                }
                else
                {
                    if ((second >= first) && (second >= third))
                    {
                        Console.WriteLine("The biggest number is: " + second);
                    }
                    else if ((third >= first) && (third >= second))
                    {
                        Console.WriteLine("The biggest number is: " + third);
                    }
                }
            }
        }
    }
}