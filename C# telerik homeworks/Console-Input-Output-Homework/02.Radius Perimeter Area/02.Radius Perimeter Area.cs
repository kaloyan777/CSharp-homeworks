using System;

namespace _02.Radius_Perimeter_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter circle Radius: ");
                int circleRadius = int.Parse(Console.ReadLine()); 

            int pi = (int)Math.PI;

            int circlePerimeter = 2 * pi * circleRadius;  
            int circleArea = pi * circleRadius * circleRadius;

            Console.WriteLine("-Perimeter of Circle = " + circlePerimeter + "\n-Area of Circle = " + circleArea);  
        }
    }
}
