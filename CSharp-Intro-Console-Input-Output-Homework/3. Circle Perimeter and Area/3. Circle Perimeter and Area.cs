using System;

namespace _3.Circle_Perimeter_and_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.
            //String.Format("{0:0.00}", 123.4567);      // "123.46"

            //! - check out: http://www.csharp-examples.net/examples/ - format strings etc...

            Console.Write("- 1.Enter Radius Of Circle: ");
            float r = float.Parse(Console.ReadLine());

            float perimeter = (float)(2 * Math.PI * r);
            Console.WriteLine("Perimeter is: {0}", perimeter);

            float area = (float)(Math.PI * Math.Pow(r, 2));
            Console.WriteLine("Area is: {0}", area);

            //example 2:

            Console.Write("\n- 2.Enter Radius Of Circle again: ");
            r = float.Parse(Console.ReadLine());

            Console.WriteLine("S = " + String.Format("{0:0.00}", (Math.PI) * r * r));
            Console.WriteLine("P = " + String.Format("{0:0.00}", 2 * (Math.PI) * r));
        }
    }
}
