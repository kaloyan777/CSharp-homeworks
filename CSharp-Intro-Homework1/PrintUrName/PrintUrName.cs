using System;

namespace PrintUrName
{
    class PrintUrName
    {
        static void Main(string[] args)
        {
            Console.Write("Type in your first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Type in your middle name: ");
            string middleName = Console.ReadLine();
            Console.Write("Type in your last name: ");
            string lastName = Console.ReadLine();

            string space = " ";

            Console.WriteLine("Your full name is: " + firstName + space + middleName + space + lastName);
        }
    }
}
