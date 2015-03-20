using System;

namespace HelloCSharp
{
    class HelloCSharp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HelloCSharp");
            //
            Console.Write("Hello");
            Console.WriteLine(" CSharp");
            //
            string hello = "hello";
            string csharp = "csharp";
            string space = " ";
            //
            Console.WriteLine(hello + " " + csharp);
            Console.WriteLine(hello + space + csharp);
            //
            char h = 'h', e = 'e', l = 'l', o = 'o';
            Console.WriteLine("{0}{1}{2}{3}{4}", h , e , l , l , o + "\ncsharp");
            //
            Console.Write(@"Type in ""hello csharp"": ");
            startCS:
            string helloCS = Convert.ToString(Console.ReadLine());
            if (helloCS == "hello csharp")
            {
                Console.WriteLine("Well Done!");
            }
            else
            {
                Console.Write("Try again: ");
                goto startCS;
            }
        }
    }
}
