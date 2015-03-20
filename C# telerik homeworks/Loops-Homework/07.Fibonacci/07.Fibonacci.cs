using System;

namespace _07.Fibonacci
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            //Write a program that reads a number N and calculates the sum of the first N members of the sequence of Fibonacci: 
            //0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …Each member of the Fibonacci sequence 
            //(except the first two) is a sum of the previous two members.

            Console.Write("Members of sequence count N = ");
            int n = int.Parse(Console.ReadLine());

            int firstMember = 0;
            int secondMember = 1;
            int sum = 1;

            Console.WriteLine("{0}\n{1}", firstMember, secondMember);    //Print first Two members
            for (int i = 1; i < n / 2; i++)
            {
                firstMember = firstMember + secondMember;
                secondMember = secondMember + firstMember;

                Console.WriteLine("{0}\n{1}", firstMember, secondMember); //Print the Next N-2 members
                
                sum = sum + firstMember + secondMember;
            }
            Console.WriteLine(new String ('=',40));
            Console.WriteLine("Sum of first " + n + " members is: "+ sum + '\n');
        }
    }
}