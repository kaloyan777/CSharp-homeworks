using System;

namespace _02.Fire
{
    class Program
    {
        static void Main(string[] args)
        {
            //FIRE:
            System.Console.WriteLine(">>-----------FIRE-----------<<");
            System.Console.Write("Enter N for Fire params: ");
            int N = int.Parse(Console.ReadLine());
            System.Console.Write(new String('-', 30) + "\n");

            //Fire top:
            for (int i = 1; i <= (N / 2); i++)
            {
                    Console.Write(new String('.', (N / 2) - i) + '#'
                                + new String('.', (i - 1) * 2) + '#');
                Console.WriteLine(new String('.', (N / 2) - i));
            }

            //Fire bottom:
            for (int i = 1; i <= (N / 4); i++)
            {
                    Console.Write(new String('.', (i - 1)) + '#'
                                + new String('.', ((N / 2) - i) * 2) + '#');
                Console.WriteLine(new String('.', (i - 1)));
            }

            //Line between Fire and Torch:
            Console.WriteLine(new String('-', N));

            //Torch:
            for (int i = 1; i <= (N / 2); i++)
            {
                    Console.Write(new String('.',  (i - 1)             ));
                    Console.Write(new String('\\', (N / 2) - (i - 1)   ));
                    Console.Write(new String('/',  (N / 2) - (i - 1)   ));
                Console.WriteLine(new String('.',  (i - 1)             ));
            }
            System.Console.WriteLine(new String('=', 30)+ "\n");
        }
    }
}