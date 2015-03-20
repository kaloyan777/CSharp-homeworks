using System;

namespace _14.Exchange_Bits_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter integer number: ");
                int number = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter position of bit to exchange (p): ");
                int p = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the other bit to exchange (q): ");
                int q = Convert.ToInt32(Console.ReadLine());
            Console.Write("Repeat \"k\" times: ");
                int k = Convert.ToInt32(Console.ReadLine());

                Console.Write("Binary number: ");
                Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));

            int icrease = q - p;
            for (int i = 0; i < k; i++)
            {
                int maskp = 1 << p++;
                int maskq = 1 << q++;

                int maskPNew = number & maskp;
                int maskQNew = number & maskq;

                number = number & ~maskp;
                number = number & ~maskq;
                maskPNew = maskPNew << icrease;
                maskQNew = maskQNew >> icrease;
                number = maskPNew | number;
                number = maskQNew | number;
            }
            Console.Write("Binary number: ");
            Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
                Console.WriteLine("Number is: " + number);
        }
    }
}