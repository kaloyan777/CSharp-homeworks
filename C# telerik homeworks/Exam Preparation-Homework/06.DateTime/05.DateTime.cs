using System;

class Program
{
    static void Main()
    {
        //Next day, the Date will be, using "dateNow = dateNow.AddDays(1);":
        Console.WriteLine("- Enter present Date: ");

        Console.Write("* Day: ");
        int day = int.Parse(Console.ReadLine());
        Console.Write("* Month: ");
        int month = int.Parse(Console.ReadLine());
        Console.Write("* Year: ");
        int year = int.Parse(Console.ReadLine() + "\n");

        
        DateTime dateNow = new DateTime(year, month, day);
        dateNow = dateNow.AddDays(1);

        Console.WriteLine("- Tomorrow will be: " 
            + dateNow.Day + "." + dateNow.Month + "." + dateNow.Year + "\n");
    }
}
