using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Comparing_Two_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads two arrays from the console and compares them element by element.
            //  Да се напише програма, която чете два масива от конзолата и прове-рява дали са еднакви.
            //  Два масива са еднакви, когато имат еднаква дължина и стойностите проверите с for цикъл.
            //..............................................................................................................

            //...Example 1:
            Console.Write("N for length of Array1: ");
            int N = int.Parse(Console.ReadLine());
            int[] array = new int[N];

            Console.Write("M for length of Array2: ");
            int M = int.Parse(Console.ReadLine());
            int[] array2 = new int[M];

            if (M == N)
            {
                Console.WriteLine("- Both arrays have the same lenght!");
                Console.WriteLine(new String('-', 35));
                //...................................................
                Console.WriteLine("Enter elements of first array: ");
                for (int i = 0; i < N; i++) //Enter elements of array1
                {
                    array[i] = int.Parse(Console.ReadLine());
                }
                //...................................................
                Console.WriteLine("\nEnter elements of second array: ");
                for (int i = 0; i < M; i++) //Enter elements of array2
                {
                    array2[i] = int.Parse(Console.ReadLine());
                }
                //Check..............................................
                for (int i = 0; i < N; i++)
                {
                    if (array[i] != array2[i]) //If any of the elements of both arrays are not equal to each other, 
                    {
                        Console.WriteLine("False, some elements of both arrays are not equal!"); //than: (message)
                        Console.WriteLine(new String('=', 49));
                        break; //So stop the check any further.
                    }
                    else if (array[i] == array2[i])
                    {
                        Console.WriteLine("\nAll the elements of both arrays are equal!");
                        Console.WriteLine(new String('=', 42));
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("\nArrays are not equal by length!");
                Console.WriteLine(new String('=', 31));
            }
            //..............................................................................................................

            //...Example2:
            int arraySizeA = 0;   //Vzema(6te sadurja) razmera na 1 masiv ot ReadLine(); 
            int arraySizeB = 0;
            //.................
            int counter1Arr = 0; //Broq4 na 1viq masiv, 6te igrae rolqta na index, kakto pri for cikul
            int counter2Arr = 0;

            //..........Enter ArrSize I:
            Console.Write("Enter Array's Size \"A\": ");
            arraySizeA = int.Parse(Console.ReadLine()); //Zadava br. na elementite na 1viq masiv 
            int[] firstArr = new int[arraySizeA];       //Deklaraciq na 1viq masiv + definirame br. elementite mu

            //...While();
            while (counter1Arr < firstArr.Length) //ekvivalent na for cikul
            {
                firstArr[counter1Arr] = int.Parse(Console.ReadLine()); //...vuvejdai stoinost za teku6tiq el. na masiva! 
                counter1Arr++; //Inkrementaciq za dvijenie po duljinata na masiva
            }

            //..........Enter ArrSize II:
            Console.Write("\nEnter Array's Size \"B\": ");
            arraySizeB = int.Parse(Console.ReadLine()); 
            int[] secArr = new int[arraySizeB]; 

            //...While();
            while (counter2Arr < secArr.Length)
            {
                secArr[counter2Arr] = int.Parse(Console.ReadLine());
                counter2Arr++;
            }
            Console.WriteLine(new String('=', 40));

            //........................................IF(Size-Check)........................................:

            if (firstArr.Length == secArr.Length) //Proverq dali br. na el. na 1viq masiv e = na br. na el. na 2riq masiv
            {
                for (int i = 0; i < firstArr.Length; i++) //Ako broq na elementite na 2ta masiva sa ==, togava
                {
                    if (firstArr[i] != secArr[i]) //sravnqva vs. edin ot elementite na 2ta masiva, edin s drug, dali NE sa ravni 
                    {
                        Console.Write(">> By Index ");
                        Console.WriteLine("- " + i + " elements are not equal.\n"); //..V slu4ai, 4e suotvetnite v momenta na obhojdaneto na cikula elementi na 2ta masiva NE sa ravni, izkarva suob6tenie: poziciqta na suotvetniq element pri koito e vuzniknalo nesuotvetstvieto + teksta na suob6tenieto.
                    }
                    else
                    {
                        Console.Write(">> By Index ");
                        Console.WriteLine("- " + i + " elements are equal.\n");
                    }
                }
                Console.Write("\n- Both Arrays by Size(number of elements) are equal.\n");
                Console.WriteLine(new String('=', 40));
            }

            //...!Second Check = same code from IF(part):
            else //*...Ako ne sa ednakuv broi elementite na 2ta masiva:
            {
                for (int i = 0; i < firstArr.Length; i++) //Su6tiqt kod, kato pri IF-a, no v slu4ai, 4e br. elementi na 2ta masiva sa razli4ni
                {
                    if (firstArr[i] != secArr[i])
                    {
                        Console.Write(">> By Index ");
                        Console.WriteLine("- " + i + " elements are not equal.\n");
                    }
                    else
                    {
                        Console.Write(">> By Index ");
                        Console.WriteLine("- " + i + " elements are equal.\n");
                    }
                }
                Console.WriteLine("\n- Both Arrays are with different sizes.");
                Console.WriteLine(new String('=', 40));
            }
            //.............................................................................................
            //  Дава грешка при въведен по-голям първи масив от втори. Знам защо.
            //  Ако имате идея, как да го поправя, моля пишете в коментара 
            //  за оценяване на домашната работа. 
            //  Но не ми казвайте, че според условието на задачата, 
            //  не е нужно да се прави и тази проверка. Това е ясно!
            //  Благодаря!
            //.............................................................................................
        }
    }
}