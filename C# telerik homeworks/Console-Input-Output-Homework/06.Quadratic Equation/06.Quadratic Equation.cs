using System;

namespace _06.Quadratic_Equation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Try A,C < B!
            Console.Write("A: ");
                int a = int.Parse(Console.ReadLine());
            Console.Write("B: ");
                int b = int.Parse(Console.ReadLine());
            Console.Write("C: ");
                int c = int.Parse(Console.ReadLine());

            double descriminant = 0d;
            double x = 0d;
            double x2 = 0d;

            descriminant = ((b * b) - (4 * a * c)); //mathematical formula for finding descriminant
            Console.WriteLine("Descriminant: " + descriminant);

            if (descriminant > 0)
            {
                x = (-b - Math.Sqrt(descriminant)) / 2 * a; //re6avane na 1 koren na uravnenieto (- b - korena na deskriminantata deleno na 2*a)
                x2 = (-b + Math.Sqrt(descriminant)) / 2 * a;
                Console.WriteLine("x is: " + x + "\nx2 is: " + x2 + "\nDescriminantata > 0.");
            }
            else if (descriminant == 0)
            {
                x = x2 = (-b) / 2 * a; //aKO e ravna n a 0, togava uravnenieto ima 2 ravni korena, formulata se preobrazuva - b / 2*a
                Console.WriteLine("x is: " + x + "x2 is: " + x2 + " Descriminatata = 0");
            }
            else if (descriminant < 0) //ako e < 0 , nq realni koreni!
            {
                Console.WriteLine("Уравнението няма реални корени!");
            }
        }
    }
}
