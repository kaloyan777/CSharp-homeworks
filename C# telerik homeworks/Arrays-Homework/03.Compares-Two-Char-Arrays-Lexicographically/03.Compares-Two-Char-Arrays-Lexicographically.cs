using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Compares_Two_Char_Arrays_Lexicographically
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Write a program that compares two char arrays lexicographically (letter by letter).
            //...............................................................................................................
            //  Да се напише програма, която сравнява два масива от тип char лексикографски (буква по буква) и проверява кой от 
            //двата е по-рано в лексикографската подредба.
            //  При лексикографската наредба символите се сравняват един по един
            //като се започва от най-левия. При несъвпадащи символи по-рано е
            //масивът, чийто текущ символ е по-рано в азбуката. При съвпадение
            //се продължава със следващия символ вдясно. Ако се стигне до края
            //на единия масив, по-краткият е лексикографски по-рано. Ако всички
            //съответни символи от двата масива съвпаднат, то масивите са
            //еднакви и никой от тях не е по-рано в лексикографската наредба.
            //...............................................................................................................

            char[] symbolsArr1 = { 'a', 'b', 'c' }; 
            char[] symbolsArr2 = { 'a', 'b', 'd' };

            //bool symb1IsEarlier = false;

            int elemEarlierSym1 = 0; //Broq na el. ot 1viq masiv, koito sa po-rano ot suotvetnite elementi ot 2riq masiv
            int elemEarlierSym2 = 0;

            //......Sravnqvame duljinite na dvata masiva, ako 1viq e po-dulug ot 2riq, togava toi e po-rano ot dr.
            //if (symbolsArr1.Length > symbolsArr2.Length)
            //{
            //    Console.WriteLine("Second Array is earlier than First.");
            //}
            //else if (symbolsArr1.Length < symbolsArr2.Length)
            //{
            //    Console.WriteLine("First Array is earlier than Second.");
            //}

            //......Proverqva, ako dvata masiva sa ravni(a v slu4aq sa), izvur6va sravnenieto na simvolite edin po edin
            for (int i = 0; i < symbolsArr1.Length; i++)
            {
                if (symbolsArr1[i] < symbolsArr2[i]) //Ako suotvetniuq el. na ediniq e po golqm ot na drugiq, togava elementa na 2riq masiv e po-rano ot el. na 2 mas.
                {
                    elemEarlierSym1++; //V slu4ai 4e el na 2riq sa po rano ot na 1viq togava inkrementirame promenlivata koqto sudurja br na el koito sa po rano ot na dr masiv
                }
                else if (symbolsArr1[i] > symbolsArr2[i]) //Su6toto za dr masiv
                {
                    elemEarlierSym2++;
                }
            }
            //......Br. na el. koito sa po-rano v 1viq masiv gi sravnqva s br. na el. koito sa po-rano v 2riq masiv
            //i koqto promenliva sudurja pove4e elementi, to suotvetniq masiv e po-rano ot dr. masiv
            if (elemEarlierSym1 < elemEarlierSym2)
            {
                Console.WriteLine("Second Array is earlier than First.");
            }
            else if (elemEarlierSym1 > elemEarlierSym2)
            {
                Console.WriteLine("First Array is earlier than Second.");
            }
            else
            {
                Console.WriteLine("Both Arrays are equal.");
            }
        }
    }
}