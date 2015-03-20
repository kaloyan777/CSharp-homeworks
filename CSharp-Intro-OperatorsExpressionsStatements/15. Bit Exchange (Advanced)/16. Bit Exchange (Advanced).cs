using System;

namespace _15.Bit_Exchange__Advanced_
{
    class Program
    {
        static void Main(string[] args)
        {
            //example 1:

            //Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer. 
            //The first and the second sequence of bits may not overlap(застъпване, припокриване).

            Console.WriteLine("---EXAMPLE 1---");

            Console.Write("Enter the number: ");
            int n, p, q, k;

            n = int.Parse(Console.ReadLine());
            p = int.Parse(Console.ReadLine());
            q = int.Parse(Console.ReadLine());
            k = int.Parse(Console.ReadLine());

            if (Math.Max(p, q) + k - 1 > 31)
            {
                Console.WriteLine("out of range");
            }
            else if (Math.Min(p, q) + k - 1 >= Math.Max(p, q))
            {
                Console.WriteLine("overlapping");
            }
            else
            {
                for (int i = p; p < p + k - 1; p++)
                {
                    int mask = 7;

                    int qBits = (n & (mask << 3));
                    int pBits = (n & (mask << i));

                    n = n & ~(mask << p);
                    n = n & ~(mask << q);
                    n = n | (pBits << q);
                    n = n | (qBits << i);
                    q++;
                }
                Console.WriteLine(n);
            }


            //example 2:
            Console.WriteLine("\n---EXAMPLE 2---");

            //Напишете програма, която разменя битовете на позиции {p, p+1, …, p+k-1) с битовете на позиции 
            //{q, q+1, …, q+k-1} на дадено цяло положително число.

            int num = 30; //4isloto na koeto razmenq bitovete

            int p1 = 3; //1 poziciq
            int p2 = 24; //2 poziciq

            int helper = 1; //spomagatelno 4islo, za da proveri stoinostta na suotvetniq bit v num!
            int helperP = helper << p1; //izmenq poziciqta na 1viq pit na helper s p1 pozicii
            int helperP2 = helper << p2; //promenq poziciqta na 1viq bit na helper s p2 pozicii

            Console.Write("Enter number of iterations: ");
            int brIteracii = Int32.Parse(Console.ReadLine()); //vuvejda br iteracii v consolata, pokazva na kolko 2ki bita 6se razmenqt stoinostite

            //............................................................................................................................

            for (int i = 0; i < brIteracii; i++) //kara cikula da se izpulnqva 3 puti za vsi4kite usloviq na zada4ata
                                                 //promenlivata "i" vaji samo vutre v cikula, broq4 na cikula, suhranqva iteraciqta 
            {

                //Console.WriteLine("zadai poziciq na bit p1");
                //p1 = Int32.Parse(Console.ReadLine());

                //Console.WriteLine("zadai poziciq na bit p2");
                //p2 = Int32.Parse(Console.ReadLine());
                if (i != 0)
                {
                    p1++;
                    p2++;
                }

                helperP = helper << p1;
                helperP2 = helper << p2;

                //purvo pravi konstrukciq za 1to uslovie, posle cikul! za ostanalite slu4ai!
                if (((num & helperP) != 0) && ((num & helperP2) != 0)) //check if bits of 2 positions are equal, so 0 i 0 ili 1 i 1
                {
                    Console.WriteLine("bits are equal and no need to be switched");
                }
                else
                {
                    if ((num & helperP) != 0) //tva uslovie 6te se izpulni, ako suotvetniq bit e 1
                    {
                        Console.WriteLine("p1 bit is 1, p2 is 0");
                        num = num & (~(1 << p1)); //promenq stoinostta na bita na p1 ot 1 v 0 (~invertira - obru6ta ot 1 v 0 ili obratnoto)
                        num = num | (1 << p2); //promenq stoinostta na bita na p2 ot 0 v 1
                    }
                    else
                    {
                        Console.WriteLine("p1 bit is 0, p2 is 1");
                        num = num | (1 << p1); //promenq stoinstta na p1 ot 0 v 1
                        num = num & (~(1 << p2)); //promenq stoinostta na p2 ot 1 v 0

                    }
                }
            }
        }
    }
}