using System;

namespace _7.Point_in_a_Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write an expression that checks if given point (x,  y) is inside a circle K({0, 0}, 2)
            //Using Pitagor Theorem: ( ((x * x) + (y * y) <= (radius * radius) ) = point in the circle!

            //example 1:
            Console.WriteLine("---EXAMPLE 1---");

            Console.Write("write x: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("write y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            int point = (x * x) + (y * y);

            if (point <= (5 * 5)) //moje dr. cifri...
            {
                Console.WriteLine("Point O belongs into circle.");
            }
            else
            {
                Console.WriteLine("Point is out of cicles.");
            }



            //example 2:
            Console.WriteLine("\n---EXAMPLE 2---");

            int radius = 5;

                Console.Write("X coordinate:");
                int pointX = int.Parse(Console.ReadLine());
           
                Console.Write("Y coordinate:");
                int pointY = int.Parse(Console.ReadLine());

            bool isInCircle = (pointX * pointX) + (pointY * pointY) <= radius * radius;
            Console.WriteLine(isInCircle ? "Yes in circle." : "Nope, outside.");



            //example 3:
            Console.WriteLine("\n---EXAMPLE 3---");

            int Center = 0;
            int Radius = 5;

            int i = 0;
            double xX = 0; //type these two before the while loop, so to be able to use them outside the loop too.
            double yY = 0;

            while (i < 2) //2 time will cicle through the body
            {
                try
                {
                    switch (i) 
                    {
                        case 0: //when i = 0
                            Console.Write("X: ");
                            xX = double.Parse(Console.ReadLine());
                            i++; // i = 0 + 1;
                            break;

                        case 1: //when i == 1
                            Console.Write("Y: ");
                            yY = double.Parse(Console.ReadLine());
                            i++; // i = 1 + 1; = the end of while(i < 2)
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input for X and Y!");
                }
            }

            bool isWithin = (Math.Pow((xX - Center), 2) + Math.Pow((yY - Center), 2) <= Math.Pow(Radius, 2));
            Console.WriteLine("The point ({0},{1}) is within the circle ({2},{3}): {4}", xX, yY, Center, Radius, isWithin);



            //example 4:
            Console.WriteLine("\n---EXAMPLE 4---");

            double xPoint = -5.0;
            double yPoint = 0.0;

            if ((xPoint * xPoint) + (yPoint * yPoint) <= 5 * 5)  
            {
                Console.WriteLine("The point " + xPoint + "," + yPoint + " is in the circle.");
            }
            else
            {
                Console.WriteLine("Outside the circle.");
            }


            //example 5:
            Console.WriteLine("\n---EXAMPLE 5---");

            int xValue;
            int yValue;

            int centerX = 0;
            int centerY = 2;

            int radiusValue; 

            Console.Write("Write Point x: ");
            int.TryParse(Console.ReadLine(), out xValue);

            Console.Write("Write Point y: ");
            int.TryParse(Console.ReadLine(), out yValue);

            Console.Write("Write radius: ");
            int.TryParse(Console.ReadLine(), out radiusValue);

            bool inCircle = ((xValue - centerX) ^ 2 + (yValue - centerY) ^ 2) < (radiusValue ^ 2);

            if (inCircle)
            {
                Console.WriteLine("In the circle.");
            }
            else
            {
                Console.WriteLine("Not in the circle.");
            }



            //example 6:
            Console.WriteLine("\n---EXAMPLE 6---");

            Console.WriteLine("enter two values for X and Y: ");
            double X = double.Parse(Console.ReadLine());
            double Y = double.Parse(Console.ReadLine());

            int radiusOfCircle = 2;

            bool pointIsIn = (X * X + Y * Y) < radiusOfCircle * radiusOfCircle;
            Console.WriteLine(pointIsIn);
        }
    }
}