using System;

class ANacci
{
    static void Main()
    {
        char firstElement = char.Parse(Console.ReadLine());
        char secondElement = char.Parse(Console.ReadLine());

        int lines = int.Parse(Console.ReadLine());

        int element1 = (int)firstElement - 64;
        int element2 = (int)secondElement - 64;

        int sum = element1 + element2;

        while (sum > 26)
        {
            sum %= 26;
        }

        if (lines == 1)
        {
            Console.WriteLine(firstElement);
        }
        else if (lines == 2)
        {
            Console.WriteLine(firstElement);
            Console.WriteLine("{0}{1}", secondElement, (char)(sum + 64));
        }
        else
        {
            Console.WriteLine(firstElement);
            Console.WriteLine("{0}{1}", secondElement, (char)(sum + 64));

            element1 = element2;
            element2 = sum;

            for (int i = 1; i <= lines - 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    sum = element1 + element2;
                    while (sum > 26)
                    {
                        sum %= 26;
                    }

                    element1 = element2;
                    element2 = sum;
                    Console.Write((char)(sum + 64));

                    if (j == 0)
                    {
                        Console.Write(new string(' ', i));
                    }
                }
                Console.WriteLine();
            }
        }
    }
}