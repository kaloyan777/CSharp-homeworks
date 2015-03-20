using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.All_The_Combinations_of_K_Distinct__Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Write a program that reads two numbers N and K and generates all the combinations of K distinct elements from the set [1..N]. 
            //Example:N = 5, K = 2  {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}
            //  Напишете програма, която прочита цяло число N от конзолата и отпечатва всички комбинации от К елемента на числата [1…N].
            //Пример: N = 5, K = 2  {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 1}, {2, 3}, {2, 4}, {2, 5}, {3, 1}, {3, 4}, {3, 5}, {4, 5}
            //.........................................................................................................

            Console.WriteLine("Enter the number of elements:");
                long numberOfElements = long.Parse(Console.ReadLine()); //N
            Console.WriteLine("Enter K:");
                long K = long.Parse(Console.ReadLine()); //K
                long[] elements = new long[numberOfElements]; //masiv broq na N
            //........................................................................................................

            for (int i = 0; i < elements.Length; i++)
            {
                Console.WriteLine("Enter element № {0}", i + 1); //slaga v masiva elements vuvedenite danni ot cnsole-ta
                elements[i] = long.Parse(Console.ReadLine());
            }
            //........................................................................................................

            int maxSubsets = (int)Math.Pow(2, numberOfElements); //broi permutacii za 4isloto N 
            int lenCounter = 0; //suzdava se za da se polzva kato inkrementator, sudurja broq elementi na permutaciqta
            string subset = ""; //permutaciq 
            //........................................................................................................

            for (int i = 1; i < maxSubsets; i++) //inkrementira permutaciite vsi4kite 
            {
                subset = ""; //permutaciq 
                for (int j = 0; j <= numberOfElements; j++) //gorniq FOR vzema vseki element v diapazona ot 1 do max subsets, 2riq for obhojda vsi4ki elementi na N, kato
                {
                    int mask = 1 << j; //pobitovo izmestvane na 1 bit nalqvo s j pozicii, za da 
                    int nAndMask = i & mask; //pobitovo saberem i & mask, ako i na j poziciqta si ima 1, togava nAndMask su6to 6te e 1
                    int bit = nAndMask >> j; //izmestva desniq bit s j pozicii
                    //..........................................................
                    if (bit == 1) //ako rezultata ot gornoto izmestvane e 1 
                    {
                        subset = subset + " " + elements[j]; //togava kum permutaciqta pribavqme teku6tata stoinost na permutaciqta i element na a poziciq J 
                        lenCounter++; //uveli4avame broqta na permunatciq a s 1 
                    }
                }
                //..................................................................................................
                if (lenCounter == K) //proverqvame, ako broq4a na permutaciqta = K
                {
                    Console.WriteLine(subset); //togava printira subset
                }
                lenCounter = 0; //zanulqvame len counter za da moje da se polzva pak 
            }
            //.....................................................................................................
        }
    }
}