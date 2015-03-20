using System;

namespace _11.Bitwise_Extract_Bit_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer. The bits are counted from right to left, starting from bit #0. The result of the expression should be either 1 or 0.

            //example 1:
            Console.WriteLine("---EXAMPLE 1---");

            Console.Write("Enter an Integer to check if bit 3 (counting from 0) is 1 or 0: ");
            int number = int.Parse(Console.ReadLine());

            int i = 1;
            int numMask = i << 3;

            Console.WriteLine("The bit is: " + ((numMask & number) != 0 ? 1 : 0));



            //example 2:
            Console.WriteLine("\n---EXAMPLE 2---");

            //Напишете булев израз, който проверява дали битът на позиция p на цялото число v има стойност 1. 
            //Пример v=5, p=1 -> false. 

            int n = 35; //00100011 4isloto za koeto proverqme dali p bita e 1 
            int p = 6;  //poziciqta na bita 
            int I = 1;  //00000001 pomo6tno 4islo

            int mask = I << p; // Move the 1st bit left by p positions 

            // If I & mask are positive then the p-th bit of n is 1 
            //Console.WriteLine((n & mask) != 0 ? 1 : 0); //ako p bita v 4islo n e 1, togava 6te izpi6e 1 

            if ((n & mask) != 0) //proverqme dali p bita na n e 1, ako e 1, rezultata ot pobitovoto & e razli4no ot 0
            {
                Console.WriteLine("bit is 1");
            }
            else
            {
                Console.WriteLine("bit is 0");
            }



            //example 3:
            Console.WriteLine("\n---EXAMPLE 3---");

            Console.Write("Write an int number: ");
            number = int.Parse(Console.ReadLine());
            p = 3;
            mask = 1 << p;

            int numAndMask = number & mask;
            int bit = numAndMask >> p;
            Console.WriteLine("The {0} bit of number {1} is {2}", p, number, bit);


            
            //example 4:
            Console.WriteLine("\n---EXAMPLE 4---");

            int v = 5;
            p = 1;

            mask = 1 << p;
            bit = (v & mask) >> p;
            bool result = (bit == 1);

            Console.WriteLine(result);



            //example 5:
            Console.WriteLine("\n---EXAMPLE 5---");

            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());

            Console.Write("Enter position: ");
            int bitPosition = int.Parse(Console.ReadLine());

            mask = 1 << bitPosition;
            int numberAndMask = number & mask;
            bit = numberAndMask >> bitPosition;

            Console.WriteLine("v={0},p={1}->{2}", number, bitPosition, bit == 1);  



            //example 6:
            Console.WriteLine("\n---EXAMPLE 6---");

            Console.WriteLine("enter a number and a position: ");
            v = int.Parse(Console.ReadLine());
            p = int.Parse(Console.ReadLine());

            bool checkBit = (v >> p & 1) == 1;
            Console.WriteLine("is the {0} bit 1? - {1}",p, checkBit);



            //example 7:
            Console.WriteLine("\n---EXAMPLE 7---");

            Console.Write("Enter num: ");
            int num = int.Parse(Console.ReadLine());
            mask = 1;

            if ((mask << 3 & num) == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(1);
            }



            //example 8:
            Console.WriteLine("\n---EXAMPLE 8---");

            n = 35; // 00100011 
            p = 6;
            i = 1; // 00000001 

            mask = i << p; // Move the 1st bit left by p positions 

            // If i & mask are positive then the p-th bit of n is 1 
            Console.WriteLine((n & mask) != 0 ? 1 + "- true" : 0 + " - false");  
            //Comparing n & mask; ((If the result != 0, Then the 6-th bit = 1), (If = 0, Then the 6-th bit = 0)).
        }
    }
}
