using System;
class quadraticEquation
{
    static void Main()
    {
        Console.WriteLine("Please enter a : ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter b : ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter c : ");
        double c = double.Parse(Console.ReadLine());
        double d = (b * b) - 4 * (a * c);
        if (d >= 0)
        {
            double x1 = ((-b) + Math.Sqrt(d)) / (2 * a);
            double x2 = ((-b) - (Math.Sqrt(d))) / (2 * a);
            Console.WriteLine("{0:0.0000}", x1);
            Console.WriteLine("{0:0.0000}", x2);
        }
        else
        {
            Console.WriteLine("Determinant is under 0.");
        }
    }
}
