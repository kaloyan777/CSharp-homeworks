using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.K_Elements_That_Have_Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
        //  Write a program that reads two integer numbers N and K and an array of N elements from the console. 
        //  Find in the array those K elements that have maximal sum.
        //.....................................................................................................
        //  Да се напише програма, която чете от конзолата две цели числа N и K (K<N), и масив от N елемента. 
        //  Да се намерят тези K поредни елемента, които имат максимална сума.
        //  Можете да проверите коя от поредица от K числа има най-голяма сума, 
        //като проверите сумите на всички такива поредици. 
        //  Първата такава поредица започва от индекс 0 и завършва в индекс K-1 и нека тя има сума S. 
        //  Тогава втората редица от K елемента започва от индекс 1 и завършва в индекс K, 
        //като нейната сума може да се получи като от S се извади нулевия елемент и се добави K-ти елемент. 
        //  По същия начин може да се продължи до достигане на края на редицата.
        //..................................................................................................................

            Start:

            int sum = 0;
            int bestSum = sum;
            int tempIndex = 0;
            int endIndexOfMax = 0;

            //................................................................

            Console.Write("> How many elements of the array? N = ");
            int N = int.Parse(Console.ReadLine());
            Console.Write("> How many elements to search in the array? K = ");
            int K = int.Parse(Console.ReadLine());
            Console.WriteLine(new String('=', 40));

            //................................................................

            if (N > K)                                  //Check so to prevent out of range error
            {
                int[] array = new int[N];              //Creating the Array
                for (int i = 0; i < array.Length; i++) //Get all array values
                {
                    Console.Write("- Enter array element: "); //Enter elements
                    array[i] = int.Parse(Console.ReadLine());
                }

                //................................................................................

                for (int j = 0; j < (N - K + 1); j++)
                {
                    for (int p = j; p < (K + j); p++)
                    {
                        sum += array[p];
                        tempIndex = p;
                    }
                    if (sum > bestSum)
                    {
                        bestSum = sum;
                        endIndexOfMax = tempIndex;
                    }
                    sum = 0;
                }

                //.............................................................................

                Console.WriteLine(new String('=', 40));
                Console.WriteLine(">> The maximal sum of {0} sequent elements is: {1}", K, bestSum);
                Console.Write("-- The Sequent Elements: ");

                for (int i = (endIndexOfMax - K + 1); i <= endIndexOfMax; i++)
                {
                    if (i == endIndexOfMax) //Check, so to prevent printing of comma after the last element.
                    {
                        Console.Write("{0}", array[i]);
                    }
                    else
                    {
                        Console.Write("{0}, ", array[i]);
                    }
                }
                Console.WriteLine("\n" + new String('=', 40));
            }
            else
            {
                Console.Beep(); //Restarting program, if the Input is Invalid.
                Console.WriteLine("\n*** Invalid numbers! Type in N > K! ***\n");
                Console.WriteLine(new String('=', 40));
                goto Start;
            }
        }
    }
}