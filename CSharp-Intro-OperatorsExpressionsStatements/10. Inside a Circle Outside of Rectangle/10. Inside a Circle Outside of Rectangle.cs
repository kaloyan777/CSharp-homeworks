using System;

namespace _10.Inside_a_Circle_Outside_of_Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2). 

            //example 1:
            Console.WriteLine("---EXAMPLE 1---");

            Console.WriteLine("enter values for X and Y: ");
            int x = int.Parse(Console.ReadLine()),
                y = int.Parse(Console.ReadLine());

            bool isInCir = ((Math.Pow(x - 1, 2) + Math.Pow(y - 1, 2)) <= 1.5 * 1.5),
                 isInRec = (x <= 5 && x >= -1) && (y >= -1 && y <= 1),

            check = isInCir && !isInRec; // !isInRec = is Not in the rectangle, as task requires.

            Console.WriteLine(check);

            //example 2:
            Console.WriteLine("\n---EXAMPLE 2---");

            Console.Write("write x: ");
            int X = Convert.ToInt32(Console.ReadLine());
            Console.Write("write y: ");
            int Y = Convert.ToInt32(Console.ReadLine());

            int point = (X * X) + (Y * Y);

            if ((point <= 5) && (X > -1) && (Y > 1) && (X < 5) && (Y < 5)) 
            {
                Console.WriteLine("Point O belongs into figures.");
            }

            else
            {
                Console.WriteLine("Point is into circle only.");
            }



            //example 3:
            Console.WriteLine("\n---EXAMPLE 3---");

            float xPoint = 0; //point 
            float yPoint = 2;

            float xK = 1; //circle K((1,1),1.5)
            float yK = 1;
            float rK = 1.5f;

            float rLeft = -1; //R(top=1, left=-1, width=6, height=2)
            float rTop = 1;
            float rWidth = 6;
            float rHeight = 2;

            bool inCircle = (Math.Pow(xPoint - xK, 2) + Math.Pow(yPoint - yK, 2) < Math.Pow(rK, 2));

            bool outRect = (   (xPoint < rLeft) 
                            || (xPoint > rLeft + rWidth)
                            || (yPoint > rTop) 
                            || (yPoint < rTop - rHeight));

            Console.WriteLine("Point is (In Circle & Out of Rectangle): " + (inCircle && outRect));



            //example 4:
            Console.WriteLine("\n---EXAMPLE 4---");


            x = 0;
            y = 0;

            int top = 1;
            int left = -1;

            int width = 6;
            int height = 2;

            int radius = 3;

            int xCenter = 1;
            int yCenter = 1;

            Console.WriteLine("Enter the coordinates of the point:");
  
            Console.Write("Enter x:");
            x = int.Parse(Console.ReadLine());
            
            Console.Write("Enter y:");
            y = int.Parse(Console.ReadLine());
                           
            bool isWithin = (Math.Pow((x - xCenter), 2) + Math.Pow((y - yCenter), 2) <= Math.Pow(radius, 2));
            bool isOutOfRec = (x < left) || (x > width + left) || (y < top - height) || (y > top);

            bool withinOut = (isWithin && isOutOfRec);

            Console.WriteLine("The point ({0},{1}) is within the circle K(({2},{3}),{4}): {5}",
                x, y, xCenter, yCenter, radius, isWithin);

            Console.WriteLine("The point ({0},{1}) is out of the rectangle (top {2}, left {3}, width {4}, height {5}): {6}",
                x, y, top, left, width, height, isOutOfRec);

            Console.WriteLine("The point ({0},{1}) is within the cirlce and out of the rectangle: {2}", x, y, withinOut);



            //example 5:
            Console.WriteLine("\n---EXAMPLE 5---");

            x = 0;
            y = 0;

            Console.Write("Point x: ");
            x = int.Parse(Console.ReadLine()); //x
            Console.Write("Point y: ");
            y = int.Parse(Console.ReadLine()); //y
         
            int centerX = 1;
            int centerY = 1;

            //int Radius = 3;

            int rectTop = 1;
            int rectLeft = -1;

            int rectWidth = 6;
            int rectHeight = 2;

            int rectXmax = rectLeft + rectWidth;
            int rectYmin = rectTop - rectHeight;
            

            bool inTheCircle = ((x - centerX) ^ 2 + (y - centerY) ^ 2) < (radius ^ 2);
            bool inTheRectangle = (rectXmax <= x) && (x >= rectLeft) && (rectTop <= y) && (y >= rectYmin);

            Console.WriteLine("Is the point is in the circle and out of the rectangle: {0}", (inCircle && !inTheRectangle)); //!inTheRectangle - false po uslovie
            


            //example 6:
            Console.WriteLine("\n---EXAMPLE 6---");

            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            int rad = 5;

            bool isInCircle = (x * x + y * y) < (rad * rad);
            bool isInRectangle = (x > -1 && x < 5) && (y > 1 && y < 5);

            Console.WriteLine(isInCircle && !isInRectangle);
        }
    }
}