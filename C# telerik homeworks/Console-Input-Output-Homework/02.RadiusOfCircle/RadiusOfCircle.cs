using System;

    class RadiusOfCircle
    {
        static void Main()
        {

            Console.Write("Enter Radius Of Circle: ");
            double r = double.Parse(Console.ReadLine());

            double perimeter = 2 * Math.PI * r; 
            Console.WriteLine("Perimeter is: {0}",perimeter);

            double area = Math.PI * Math.Pow(r, 2);
            Console.WriteLine("Area is: {0}", area);

        }
    }

