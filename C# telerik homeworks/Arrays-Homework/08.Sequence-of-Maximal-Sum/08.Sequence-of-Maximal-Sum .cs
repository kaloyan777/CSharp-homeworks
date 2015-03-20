using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Sequence_of_Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Write a program that finds the sequence of maximal sum in given array. 
            //  Example: {2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  {2, -1, 6, 4}
            //  Can you do it with only one loop (with single scan through the elements of the array)?
            //....................................................................................................
            //  Напишете програма, която намира последователност от числа, чиито сума е максимална. 
            //  Пример: {2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  11
            //  Тази задача има два начина, по които може да се реши. Един от тях е с пълно изчерпване, т.е. 
            //с два цикъла проверяваме всяка възможна сума. 
            //  Втория е масива да се обходи само с 1 цикъл, като на всяко завъртане на цикъла проверяваме дали
            //текущата сума е по-голяма от вече намерената максимална сума. 
            //  Задачата може да се реши и с техниката "Динамично оптимиране". Потърсете повече за нея в Интернет.
            //....................................................................................................

            Console.WriteLine("* A Program that finds the sequence of maximal sum in given array. *\n");
                int[] arr = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 }; //def. masiv
            Console.WriteLine("- The Array: int[] arr = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };"); //Po-lesen na4in za izpisvane na masiv, LOL!

            //....................................................................................................
            int currentSum = 0; //Teku6tata suma sudurja sumata na porednite elemnti, 4iqto stoinost prisvoqvame na bestsum v slu4ai,
                                //4e e po-golqma ot momentnata stoitnost na best sum, a bestsum e maximalnata suma  
            int bestSum = 0;    //Sadurja nai-visokata suma na subiraneto na elementite do momenta 
            int indexOfNextElemnts = 0; //Promenlivata sluji za indexirane na sledva6tite elementi sprqmo teku6tiq 

            //....................................................................................................
            for (int i = 0; i < arr.Length; i++) 
            {
                indexOfNextElemnts = i + 1; //Prisvoqva kum indexa na sledva6tiq element = vtoriq element ot tezi na masiva(i - 1 = predhodniq element, i + 1 = sledva6tiq element nadqsno ot teku6tiq(i))
                currentSum = arr[i];        //Prisvoqva stoinostta na teku6tiq element na currentsum
                //................................................................................................
                while (indexOfNextElemnts < arr.Length) //While usloviqta sa boolevi, za tova tyk se zadava true praviloto pri masivi, 
                                                        //4e indexa na sledva6tiq element trqva da e po-maluk ot ob6tiq broi 
                                                        //na elementite v masiva(ako length na masiva e 5 elementa, indexa 
                                                        //ne moje da e 5, 6ot otbroqvaneto po4va vinagi ot 0, sledovatelno 6te e 4) 
                {
                    currentSum += arr[indexOfNextElemnts]; //Uveli4a stoinostta na current sum sus stoinostta na index of next el.
                    indexOfNextElemnts++; //Uveli4a broq4a s 1, za da sviji po masiva.............................

                    if (currentSum > bestSum) //Ako sumata v current sum e > ot best sum, 
                    {
                        bestSum = currentSum; //togava prisvoqva sumata ot current na best........................
                    }
                }
                //Nulira nastoq6tata suma kogato po4ne da sumira ot teku6tiq element kum sledva6tite mu pr. 5-6-8-9...
                currentSum = 0;
            }
            //....................................................................................................
            System.Console.WriteLine("- Best sum of elements: " + bestSum + "\n"); //Best sum predstavlqva otgovorqa na zada4ata.
            Console.WriteLine(new String('=', 31));
        }
    }
}