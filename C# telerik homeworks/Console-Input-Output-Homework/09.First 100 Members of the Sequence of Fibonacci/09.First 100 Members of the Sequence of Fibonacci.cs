using System;

namespace _09.First_100_Members_of_the_Sequence_of_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int previous = 0; //previous element
            int current = 1; //current element
            int temporary = 0; //Temporary preserves the value of current element to be able to pass it to previous element.

            Console.WriteLine(previous);
            Console.WriteLine(current);

            for (int i = 0; i <= 100; i++) 
            {
                Console.WriteLine(previous + current); 
                temporary = current; 

                current += previous;
                previous = temporary; 
            }
        }
    }
}