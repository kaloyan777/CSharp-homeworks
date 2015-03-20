using System;

class PrintASCIITable
{
    static void Main()
    {
        for (ushort i = 0; i < 256; i++)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write(i + " -> " + (char)i + '\t');
            if (i % 4 == 3) Console.WriteLine();
        }
    }
}

