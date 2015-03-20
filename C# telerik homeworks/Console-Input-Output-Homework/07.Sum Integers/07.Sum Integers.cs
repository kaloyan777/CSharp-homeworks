using System;

namespace _07.Sum_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string a ;
            int a1 = 0; 
            bool parseSuccess = false;

            while (parseSuccess != true) 
            {
                Console.Write("enter num a: ");
                a = Console.ReadLine(); 
               parseSuccess = Int32.TryParse(a, out a1); 
            }

            string b ; 
            int b1 = 0; 
            bool parseSuccess2 = false; 
            
            while (parseSuccess2 != true) 
            {
                Console.Write("enter num b: ");
                b = Console.ReadLine();
                parseSuccess2 = Int32.TryParse(b, out b1);
            }

            string c ; 
            int c1 = 0; 
            bool parseSuccess3 = false; 

            while (parseSuccess3 != true) 
            {
                Console.Write("enter num c: ");
                c = Console.ReadLine();
                parseSuccess3 = Int32.TryParse(c, out c1);
            }

            string d ;
            int d1 = 0; 
            bool parseSuccess4 = false; 

            while (parseSuccess4 != true) 
            {
                Console.Write("enter num d: ");
                d = Console.ReadLine();
                parseSuccess4 = Int32.TryParse(d, out d1);
            }

            string e ; 
            int e1 = 0; 
            bool parseSuccess5 = false;

            while (parseSuccess5 != true)
            {
                Console.Write("enter num e: ");
                e = Console.ReadLine();
                parseSuccess5 = Int32.TryParse(e, out e1);
            }
            Console.WriteLine("Sum is: " + (a1 + b1 + c1 + d1 + e1));
        }
    }
}
