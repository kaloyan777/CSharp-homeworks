using System;
class DivergingSequence
{
    //Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...

    static void Main()
    {
        for (int counter=2; counter<12; counter++)
        {
            double index = Math.Pow(-1, counter);
            Console.WriteLine(counter * index);
        }
    }
}