using System;

namespace _9.Trapezoids
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write an expression that calculates trapezoid's area by given sides a and b and height h.

            //example 1:
            Console.WriteLine("---EXAMPLE 1---");

            int a = 4, b = 6, h = 10;
            int area = (a + (b - a) / 2) * h;

            Console.WriteLine("Trapezoid's side a = {0}, side b = {1}, h = {2}.", a, b, h);
            Console.WriteLine("Area of Trapezoid = " + area);



            //example 2:
            Console.WriteLine("\n---EXAMPLE 2---");

            int i = 0;

            float a = 0;
            float b = 0;
            float h = 0;

            while (i < 3) // = do the loop 3 times
            {
                try //check if the input is correct
                {
                    switch (i) //check if "i" is still < 3, and if so, 
                    {
                        case 0: //here "i" = 0 < 3
                            Console.Write("Enter A: ");
                            a = float.Parse(Console.ReadLine());

                            if (a <= 0) //check if the length of the side is valid(x > 0)
                            {
                                throw new Exception();
                            }
                            i++; //here "i" = 0 + 1, and so on forth...until i < 3.
                            break;

                        case 1: //i = 1 < 3
                            Console.Write("Enter B: ");
                            b = float.Parse(Console.ReadLine());

                            if (b <= 0)
                            {
                                throw new Exception();
                            }
                            i++;
                            break;

                        case 2: //i = 2 < 3
                            Console.WriteLine("Enter H: ");
                            h = float.Parse(Console.ReadLine());

                            if (h <= 0)
                            {
                                throw new Exception();
                            }
                            i++;
                            break;
                    }
                }
                catch (Exception) //if input is not correct, restart until done right...
                {
                    Console.WriteLine("Invalid value.");
                }
            }
            float s = ((a + b) * h) / 2; //by formula
            Console.WriteLine("The figure area is: " + s);



            //example 3:
            Console.WriteLine("\n---EXAMPLE 3---");

            double a = 4;
            double b = 6;
            double h = 5;

            double trapezoidArea = ((a + b) / 2) * h;
            Console.WriteLine(trapezoidArea);



            //example 4:
            Console.WriteLine("\n---EXAMPLE 4---");

            Console.Write("a: ");
            int a;
            int.TryParse(Console.ReadLine(), out a); //playing with use of TryParse...

            Console.Write("b: ");
            int b;
            int.TryParse(Console.ReadLine(), out b);

            Console.Write("h: ");
            int h;
            int.TryParse(Console.ReadLine(), out h);

            Console.WriteLine("The area is: " + ((a + b) / 2) * h);
        }
    }
}