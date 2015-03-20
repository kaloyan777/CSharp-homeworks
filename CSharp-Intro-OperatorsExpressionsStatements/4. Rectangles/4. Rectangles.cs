using System;
namespace _4.Rectangles
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write an expression that calculates rectangle’s perimeter and area by given width and height. 

            //example 1:
            Console.WriteLine("---EXAMPLE 1---");

            Console.Write("width: ");
                double width = double.Parse(Console.ReadLine());
            Console.Write("height: ");
                double height = double.Parse(Console.ReadLine());

                double rectangleArea = width * height;
                double rectanglePerimeter = 2 * (width + height);

            Console.WriteLine("area: " + rectangleArea);
            Console.WriteLine("perimeter: " + rectanglePerimeter);



            //example 2:
            Console.WriteLine("\n---EXAMPLE 2---");

            int Width;
            int Height;

            Console.Write("Write width: ");
            int.TryParse(Console.ReadLine(), out Width);

            Console.Write("Write height: ");
            int.TryParse(Console.ReadLine(), out Height);

            Console.WriteLine("The area of rectangle is: {0}", width * height);
            Console.WriteLine("The perimeter of rectangle is: {0}", 2 * (width + height));



            //example 3:
            Console.WriteLine("\n---EXAMPLE 3---");

            float widthR = 0;
            float heightR = 0;

            int i = 0;

            while (i < 2)
            {
                try
                {
                    switch (i)
                    {
                        case 0: //"i" starts from 0, so here "while" will execute for 1st time the try-switch case0.
                            Console.Write("Width: ");
                            widthR = float.Parse(Console.ReadLine());

                            if (widthR <= 0) //will check if the input it valid
                            {
                                throw new Exception();
                            }
                            i++; //here "i" will become 1, and by "break", will jump to the second case1:
                            break; //izliza ot cikula i otiva na 2riq case: 1.

                        case 1: //i = 1;
                            Console.Write("Height: ");
                            heightR = float.Parse(Console.ReadLine());

                            if (heightR <= 0) //will check if the input is valid
                            {
                                throw new Exception();
                            }
                            i++; //i = 2 (while(i < 2))
                            break;
                    }
                }
                catch (Exception) //restart program if input is invalid
                {
                    Console.WriteLine("Reenter input values!");
                }
            }
            Console.WriteLine("The area of a rectangle is: " + (widthR * heightR));
            Console.WriteLine("The perimeter of the rectangle is " + 2 * (widthR + heightR));



            //example 4:
            Console.WriteLine("\n---EXAMPLE 4---");

            double aH = 3;
            double bW= 4;

            Console.WriteLine("width: " + bW);
            Console.WriteLine("height: " + aH);

            Console.WriteLine("Area of rectaingle = {0:f2}", (aH * bW)); //:f2 - s to4nost do 2riq znak sled deseti4nata zapetaq
            Console.WriteLine("Perimeter or rectabgle = {0:f2}", (2 * (aH + bW)) + "\n");
        }
    }
}