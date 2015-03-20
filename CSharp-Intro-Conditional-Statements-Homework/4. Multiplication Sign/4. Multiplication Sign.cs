using System;

namespace _4.Multiplication_Sign
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it. 
            //Use a sequence of if operators. 

            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //int c = int.Parse(Console.ReadLine());

            //if (a*b*c == 0)
            //{
            //    Console.WriteLine("0");
            //}
            //else if (a*b*c < 0)
            //{
            //    Console.WriteLine("-");
            //}
            //else if (a*b*c > 0)
            //{
            //    Console.WriteLine("+");
            //}

            //example 1:

            double a = double.Parse(Console.ReadLine()),
                   b = double.Parse(Console.ReadLine()),
                   c = double.Parse(Console.ReadLine());

            if (a < 0 && b < 0 && c < 0)
            {
                Console.WriteLine("-"); //- * - * - = -
            }
            if (a > 0 && b > 0 && c > 0) //+ * + * + = + 
            {
                Console.WriteLine("+");
            }

            //...

            if (a > 0 && b > 0 && c < 0) //+ * + * - = -
            {
                Console.WriteLine("-");
            }
            if (a > 0 && b < 0 && c < 0) //+ * - * - = +
            {
                Console.WriteLine("+");
            }

            //...

            if (a < 0 && b > 0 && c > 0) //- * + * + = -
            {
                Console.WriteLine("-");
            }
            if (a < 0 && b > 0 && c < 0) //- * + * - = +
            {
                Console.WriteLine("+");
            }

            //...

            if (a < 0 && b < 0 && c > 0) //- * - * + = +
            {
                Console.WriteLine("+"); 
            }
            if (a > 0 && b < 0 && c > 0) //+ * - * + = -
            {
                Console.WriteLine("-");
            }

            //...

            if (a == 0 || b == 0 || c == 0) //n * 0 = 0
            {
                Console.WriteLine(0);
            }
        }
    }
}
