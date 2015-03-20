using System;

namespace _1.Sum_of_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads 3 real numbers from the console and prints their sum.

            Console.Write("1---Enter a: ");
            int f = int.Parse(Console.ReadLine());
            Console.Write("    Enter b: ");
            int j = int.Parse(Console.ReadLine());
            Console.Write("    Enter c: ");
            int h = int.Parse(Console.ReadLine());

            int sumABC = f + j + h;

            Console.WriteLine("Sum of a,b,c: " + sumABC);
            Console.WriteLine("SUM of a,b,c = " + (f + j + h));

            //...example 2:

            Console.WriteLine("\n2---Enter three floating numbers: ");
            float A = float.Parse(Console.ReadLine());
            decimal B = decimal.Parse(Console.ReadLine());
            sbyte C = sbyte.Parse(Console.ReadLine());

            float result = A + (float)B + (float)C; //using float cast
            Console.WriteLine("result: " + result);
            Console.WriteLine("absolute value result: " + Math.Abs(result) + "\n"); //Math.Abs gives absolute value, means if number is negative, it turns it to positive.

            //example 3:

            string numberText;
            int theNumber = 0;

            int sum = 0;

            for (int i = 1; i <= 3; i++)
            {
                Console.Write("\n3---Number {0}: ", i);
                numberText = Console.ReadLine();
                while (Int32.TryParse(numberText, out theNumber))
                {
                    sum += theNumber;
                    break;
                }
            }
            Console.WriteLine(sum);

            //example 4:

            string a; //vupreki 4e vuvejdam string, pri tryparse se obru6ta v 4islo
            int a1 = 0; //promenlivata koqto se parsva ot vuvedenoto v consolata 
            bool parseSuccess = false; //promenlivata na koqto se prusvoqva rezultata ot pasrvaneto za true ili false

            while (parseSuccess != true) //tqloto na cikula 6te se izpulnqva dokato stopinostta na parse success e false ((parseSuccess != true) ekvivalentno na (parseSuccess == false))
            {
                Console.Write("\n4---Enter int a: ");
                a = Console.ReadLine(); //zema vuvedeniq string ot klaviaturata
                parseSuccess = Int32.TryParse(a, out a1); //pri uspe6no parsvane na vuvedeniq string, funkciqta tryparse vru6ta true ili false, koeto se prisvoqva na promenlivata parse succes
            }


            string b;
            int b1 = 0;
            bool parseSuccess2 = false;

            while (parseSuccess2 != true)
            {
                Console.Write("Enter int b: ");
                b = Console.ReadLine();
                parseSuccess2 = Int32.TryParse(b, out b1);
            }


            string c;
            int c1 = 0;
            bool parseSuccess3 = false;

            while (parseSuccess3 != true)
            {
                Console.Write("Enter int c: ");
                c = Console.ReadLine();
                parseSuccess3 = Int32.TryParse(c, out c1);
            }
            Console.WriteLine("Sum: " + (a1 + b1 + c1));
        }
    }
}
