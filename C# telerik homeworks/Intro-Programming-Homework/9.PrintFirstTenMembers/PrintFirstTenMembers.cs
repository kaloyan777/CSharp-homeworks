using System;

class PrintFirstTenMembers
{
    static void Main()
    {
        string description = "Write a program that prints the first 10 members of the sequence: 2,-3,4,-5,6,-7,...";

        Console.WriteLine("Description: {0}\n", description);

        for (int counter = 2; counter < 12; counter++)
        {
            if (counter % 2 == 0)
            {
                Console.Write(counter + ", ");
            }
            else
            {
                Console.Write(-counter + ", ");
            }
        }
        Console.WriteLine();
    }
}