using System;

namespace _03.Rectangle_s_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            //Area = Length x Width
            double height = 12;
            double width = 22;

            Console.WriteLine("width: " + width);
            Console.WriteLine("height: " + height);

            Console.Write("Area of rectaingle = ");
            Console.WriteLine("{0:f2}", (height * width));
        }
    }
}
