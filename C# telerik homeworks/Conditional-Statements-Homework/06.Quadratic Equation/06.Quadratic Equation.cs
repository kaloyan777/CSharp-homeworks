using System;

namespace _06.Quadratic_Equation
{
    class Program
    {
        static void Main(string[] args)
        {
        //Write a program that enters the coefficients a, b and c of a quadratic equation a*x2 + b*x + c = 0.
        //and calculates and prints its real roots. Note that quadratic equations may have 0, 1 or 2 real roots.

            Console.WriteLine("enter a: ");
                int a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter b: ");
                int b = int.Parse(Console.ReadLine());
            Console.WriteLine("enter c: ");
                int c = int.Parse(Console.ReadLine());

                double descriminanta = 0d;

                double x = 0d;
                double x2 = 0d;

                descriminanta = ((b * b) - (4 * a * c)); //iz4islqvane na deskriminantata po formula ot matematikata

                if (descriminanta > 0)
                {
                    x = (-b - Math.Sqrt(descriminanta)) / 2 * a; //re6avane na 1 koren na uravnenieto (- b - korena na deskriminantata deleno na 2*a)
                    x2 = (-b + Math.Sqrt(descriminanta)) / 2 * a;
                    Console.WriteLine("x is: " + x + "x2 is: " + x2 + " Descriminantata > 0.");
                }
                else if (descriminanta == 0)
                {
                    x = x2 = (-b) / 2 * a; //aKO e ravna n a 0, togava uravnenieto ima 2 ravni korena, formulata se preobrazuva - b / 2*a
                    Console.WriteLine("x is: " + x + " x2 is: " + x2 + " Descriminatata = 0.");
                }
                else if (descriminanta < 0) //ako e < 0 , nq realni koreni
                {
                    Console.WriteLine("Уравнението няма реални корени!");
                }
        }
    }
}
