using System;

namespace _07.Declare_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = "Hello";
            string world = "World";

            object helloWorld = (hello + " " + world);
            string typeCasting = (string)helloWorld;

            Console.WriteLine(typeCasting);
        }
    }
}
