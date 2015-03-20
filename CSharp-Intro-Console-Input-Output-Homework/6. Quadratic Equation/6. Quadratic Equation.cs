using System;

namespace _6.Quadratic_Equation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads the coefficients a, b and c of a quadratic equation 
            //ax2 + bx + c = 0 and solves it (prints its real roots). 

            Console.WriteLine("---EXAMPLE 1---");

            Console.Write("a :");
            float a = float.Parse(Console.ReadLine());

            Console.Write("b :");
            float b = float.Parse(Console.ReadLine());

            Console.Write("c :");
            float c = float.Parse(Console.ReadLine());

            //Calculating the discriminant of the square root
            float discriminant = (b * b) - 4 * a * c;
            float x1, x2;

            if (discriminant < 0)
            {
                Console.WriteLine("- Discriminant is smaller than zero, so there are no real roots.");
            }
            else
            {
                //if there is only one solution, x1 and x2 will be the same
                float discriminantRoot = (float)Math.Sqrt(discriminant);
                x1 = (-b + discriminantRoot) / (2 * a);
                x2 = (-b - discriminantRoot) / (2 * a);

                Console.WriteLine(x1 == x2 ? "- There is only one real root: {0}" : "- There are two real roots: {0} and {1}.", x1, x2);
            }



            //example 2:

            //Try A,C < B!
            Console.WriteLine("\n---EXAMPLE 2---");

            Console.Write("A: ");
                a = int.Parse(Console.ReadLine());
            Console.Write("B: ");
                b = int.Parse(Console.ReadLine());
            Console.Write("C: ");
                c = int.Parse(Console.ReadLine());

            discriminant = 0;
            x1 = 0;
            x2 = 0;

            Console.WriteLine("Descriminant: " + (discriminant = ((b * b) - (4 * a * c)))); //mathematical formula for finding discriminant

            if (discriminant > 0)
            {
                x1 = (float)(-b - Math.Sqrt(discriminant)) / 2 * a; //re6avane na 1 koren na uravnenieto (- b - korena na diskriminantata deleno na 2*a)
                x2 = (float)(-b + Math.Sqrt(discriminant)) / 2 * a;

                Console.WriteLine("X is: " + x1 + "\nX2 is: " + x2 
                              + "\nDiscriminant > 0 = " + "[" + discriminant + "].");
            }
            else if (discriminant == 0)
            {
                x1 = x2 = (-b) / 2 * a; //aKO e ravna n a 0, togava uravnenieto ima 2 ravni korena, formulata se preobrazuva - b / 2*a
                Console.WriteLine("X is: " + x1 + "\nX2 is: " + x2 + "\nDiscriminat: 0");
            }
            else if (discriminant < 0) //ako e < 0 , nq realni koreni!
            {
                Console.WriteLine("Уравнението няма реални корени!");
            }



            //example 3:
            Console.WriteLine("\n---EXAMPLE 3---");

            Console.Write("enter a : ");
                double A = double.Parse(Console.ReadLine());

            Console.Write("enter b : ");
                double B = double.Parse(Console.ReadLine());

            Console.Write("enter c : ");
                double C = double.Parse(Console.ReadLine());

                double D = (B * B) - 4 * (A * C); //the formula

            if (D >= 0)
            {
                double X1;
                double X2;

                Console.WriteLine("X1: {0:0.0000}", X1 = ((-B) + Math.Sqrt(D)) / (2 * A));
                Console.WriteLine("X2: {0:0.0000}", X2 = ((-B) - (Math.Sqrt(D))) / (2 * A));
            }
            else
            {
                Console.WriteLine("Discr. is under 0. No roots.");
            }
        }
    }
}