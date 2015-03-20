using System;

namespace _10.Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence 
            //(at a single line, separated by spaces) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …. 
            //Note that you may need to learn how to use loops. 

            //example 1:

            //Напишете програма, която отпечатва на конзолата първите 100 числа от редицата на Фибоначи: 
            //0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, ...
            //Повече за редицата на Фибоначи можете да намерите в Wikipedia на адрес: http://en.wikipedia.org/wiki/Fibonacci_sequence. 
            //За решение на задачата използвайте 2 временни променливи, в които да пазите последните 2 пресметнати стойности и с цикъл пресмятайте 
            //останалите (всяко следващо число в редицата е сума от последните две).

            Console.WriteLine("---EXAMPLE 1---");

            int previous = 0; //previous element
            int current = 1; //current element
            int temporary = 0; //Temporary preserves the value of current element to be able to pass it to previous element.

            Console.WriteLine(previous);
            Console.WriteLine(current);


            for (int i = 0; i <= 20; i++)
            {
                Console.WriteLine(previous + current);
                temporary = current;

                current += previous;
                previous = temporary;
            }

            //example 2:

            Console.WriteLine("\n---EXAMPLE 2---some kind of solution");

            Console.Write("Enter 40 for example: ");
            int n = int.Parse(Console.ReadLine());
            string myString = null;

            for (int a = 0, b = 1; b < n; a += b, b += a)
            {
                myString = " " + a + " " + b + " ";
                myString = myString.TrimStart(); //removes empty spaces in the beginning of the string sequence, разбийши?
                Console.Write(myString);
            }
            Console.WriteLine();
        }
    }
}