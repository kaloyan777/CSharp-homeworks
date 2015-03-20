using System;

namespace _08.Trapezoid_s_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 4, b = 6, h = 10;
            int area = (a + (b - a) / 2) * h;

            Console.WriteLine("Trapezoid's side a = 4, side b = 6, h = 10." + '\n');
            Console.WriteLine("Area of Trapezoid = " + area);
        }
    }
}
