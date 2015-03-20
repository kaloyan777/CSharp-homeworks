using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.All_Variations_of_K_Elements
{
    class Program
    {
        //  Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N]. 
        //Example: N = 3, K = 2  {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}
        //  Напишете програма, която прочита цели числа N и K от конзолата и отпечатва всички вариации от К елемента на числата [1…N].
        //Пример: N = 3, K = 2  {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}
        //......................................................................................................

        static void VariationsGen(int[] array, int index, int N)  //tazi funkciq printira vsi4ki elementi v masiva
        {
            if (array.Length == index) //ako duljinata e = indexa
            {
                PrintVar(array); //printira vseki el. v masiva
            }
            else //ako ne e ravna na index 
            {
                for (int i = 1; i < N + 1; i++) //togava obhojdaiki elementite ot 1 do N
                {
                    array[index] = i; //na vseki element ot masiva kato stoinost mu podavame teku6tata poziciq i
                    VariationsGen(array, index + 1, N); //vikame su6tiqt metod v nego samiq (+1 vednaga vru6ta novata stoinost ot sbora index+1, a index++ vru6ta purvo starata stoinost na index i toga inkrementiraaaaaaaaaa)
                }
            }
        }
        //....................................................................................................
        static void PrintVar(int[] array) //deklaraciq na metod, Because zada4ate se razdelq na 3 podproblema (3 static-a) 
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
        }
        //...................................................................................................
        static void Main() //tozi motod izvikva drugite 2 
        {
            int N = 5;
            int K = 2;
            int[] vars = new int[K];
            VariationsGen(vars, 0, N); //izvikva metoda da se izpulni 
        }
        //..................................................................................................
    }
}