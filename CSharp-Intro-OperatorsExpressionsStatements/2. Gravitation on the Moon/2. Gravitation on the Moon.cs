using System;

namespace _2.Gravitation_on_the_Moon
{
    class Program
    {
        static void Main(string[] args)
        {
            //The gravitational field of the Moon is approximately 17% of that on the Earth. Write a program that calculates the weight of a man on the moon by a given weight on the Earth. 

            //example 1:

            Console.Write("Your weight: ");
            double X = double.Parse(Console.ReadLine());

            double moonGravitation = X * 0.17;
            Console.WriteLine("Your moon weight: " + moonGravitation + "\n");

            //example 2:

            Console.Write("Body weight on Earth: ");
            int number = Convert.ToInt32(Console.ReadLine()); //ili s Int32.Parse
            Console.WriteLine("Body weight on moon = " + (number * 0.17) + '\n');
        }
    }
}
