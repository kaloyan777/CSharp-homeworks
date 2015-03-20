using System;

namespace _06.Point_In_or_Out
{
    class Program
    {
        static void Main(string[] args)
        {
//////////..1
            Console.Write("write x ");
                int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("write y ");
                int y = Convert.ToInt32(Console.ReadLine());

            int radius = 5;
            int point = (x * x) + (y * y);

            if (point <= (radius * radius))
            {
                Console.WriteLine("Point belongs into circle." + '\n');
            }
            else
            {
                Console.WriteLine("Point is out of cicle." + '\n');
            }

//////////..2
            Console.Write("write x ");
            int xX = Convert.ToInt32(Console.ReadLine());
            Console.Write("write y ");
            int yY = Convert.ToInt32(Console.ReadLine());

            bool result = ((xX * xX) + (yY * yY)) <= 25;
            Console.WriteLine("The point is inside(true), or outside(false) the circle: " + result + '\n');
        }
    }
}
