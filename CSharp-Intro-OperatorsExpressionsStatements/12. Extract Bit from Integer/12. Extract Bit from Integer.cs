using System;

namespace _12.Extract_Bit_from_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write an expression that extracts from given integer n the value of given bit at index p.

            //example 1: 
            Console.WriteLine("---EXAMPLE 1---");

            //Дадено е число n, стойност v (v = 0 или 1) и позиция p. Напишете поредица от операции, 
            // които да променят стойността на n, така че битът на позиция p да има стойност v. 
            // Пример n=35, p=5, v=0 -> n=3. Още един пример: n=35, p=2, v=1 -> n=39.

            //Можете да нулирате бита на позиция p в числото n по следния начин: n = n & (~(1 << p));
            //Можете да установите в единица бита на позиция p в числото n по следния начин: n = n | (1 << p);
            //Помислете как можете да комбинирате тези две упътвания.

            int n = 35; // 4isloto na koeto proverqva stoinostta na p bita
            int v = 1; // stoinostta za koqto 6te proverqva p bita
            int p = 2; // nomera/poziciqta na bita
            int i = 1; // spomagatelno 4islo

            int mask = i << p;

            if (v == 1) //v pokazva kakva stoinost dirim v p
            {
                if ((n & mask) != 0) // ako rezultata ot & nee 0, togava p bita e 1
                {
                    Console.WriteLine("bit is 1");
                }
                else
                {
                    Console.WriteLine("bit is 0");
                    n = n | (1 << p); // promenq stoinostta na p bita ot 0 v 1.
                }
            }
            else if (v == 0) //v slu4ai 4ee tursim v da e 0 
            {
                if ((n & mask) == 0) // ako rezultata ot & e = na 0 togava p bita e 0
                {
                    Console.WriteLine("is 0");
                }
                else
                {
                    Console.WriteLine("bit is not 0");
                    n = n & (~(1 << p)); // promenqme p bita ot 1 v 0.
                }
            }   



            //example 2:
            Console.WriteLine("\n---EXAMPLE 2---");

            int number = int.Parse(Console.ReadLine());
            p = int.Parse(Console.ReadLine());

            mask = 1;
            if ((mask << p & number) == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(1);
            }
        }
    }
}