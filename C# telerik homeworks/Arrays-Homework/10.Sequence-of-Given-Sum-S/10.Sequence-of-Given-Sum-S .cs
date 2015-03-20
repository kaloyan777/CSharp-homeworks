using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Sequence_of_Given_Sum_S
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Write a program that finds in given array of integers a sequence of given sum S (if present). 
            //  Example: {4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5}	
            //.......................................................................................................
            //  Да се напише програма, която намира последователност от числа в
            //масив, които имат сума равна на число, въведено от конзолата (ако има такава). 
            //  Пример: {4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5}.
            //  Задачата може да се реши с два вложени цикъла. Първият задава началната позиция за втория – от първия до последния елемент. 
            //  Вторият цикъл започва от позицията, зададена от първия цикъл и сумира последователно числата надясно едно по едно, 
            //докато сумата не надвиши S. 
            //  Ако сумата е равна на S, се запомня числото от първия цикъл (то е началото на поредицата) 
            //и числото от втория цикъл (то е краят на поредицата).
            //  Ако всички числа са положителни, съществува и много по-бърз алгоритъм. 
            //  Сумирате числата отляво надясно като започвате от нулевото. 
            //  В момента, в който текущата сума надвиши S, премахвате най-лявото число от редицата и го изваждате от текущата сума. 
            //  Ако тя пак е по-голяма от търсената, премахвате и следващото число отляво и т.н. докато текущата сума не стане по-малка от S. 
            //  След това продължавате с поредното число отдясно. Ако намерите търсената сума, я отпечатвате заедно с редицата, която я образува. 
            //  Така само с едно сканиране на елементите на масива и добавяне на числа от дясната страна към текущата редица и премахване на числа 
            //от лявата й страна (при нужда), решавате задачата.
            //.......................................................................................................

            int n; //broq elementi v masiva
            int S; //sumata ot sbora na posledovatelnite 4isla 
            int currentSum = 0; //teku6tata suma sluji za sravnenie s vuvedenata ot klaviaturata
            int firstIndex = 0; //purvoto 4islo ot redicata na posledovatelnite elementi koito pravat sumata
            int lastIndex = 0; //poslednoto ot posledovatelnite

            //........................................................................................................

            Console.Write("Number of array elements: ");
                string strN = Console.ReadLine();
            Console.Write("S = ");
                string strS = Console.ReadLine();

            //........................................................................................................
            if (!int.TryParse(strN, out n) || !int.TryParse(strS, out S)) //Input Check za da proveri dali vuvejdame 4islo
            {
                Console.WriteLine("Invalid numbers!");
            }
            else //I ako e 4islo, zapo4va izpulnenieto na koda...
            {
                int[] array = new int[n]; 
                for (int i = 0; i < n; i++)
                {
                    Console.Write("Enter array element: ");
                    array[i] = int.Parse(Console.ReadLine()); 
                }

                //......................................................................................................
                currentSum = array[0]; //Prisvoqva na nastoq6tata sum purviq element na masiva, za da zapo4ne proverkata 
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = i + 1; j < array.Length; j++) //Vzema teku6tiq el. ot gorniq cikul i dobavq edinica i tva stava teku6tata stoinost na vutre6niq cikul (kato dobavi6 edinica kum teku6tata stoinost na vun6niq, tazi promenliva se prevru6ta v teku6tata na vutre6niq cikul)
                    {
                        currentSum += array[j]; //Na teku6tata suma pribavq elementa, koito se namira na j poziciqta v masiva 

                        if (currentSum == S) //Ako teku6tata suma v momenta pridobila stoinostta na sledva6tite elementi j, ima stoinost = S (vuvedenata za kraen rezultat ot klaviaturata)
                        {
                            firstIndex = i + 1; //, togava purvata poziciq na posledovatelnostta priema teku6tata stoinost na poziciqta na vun6niq cikul + 1, +1za6toto - 
                            lastIndex = j; //Poslednata poziciq ot posledovateln0stta i priema teku6tata stoinost na vutre6niq cikul
                        }
                    }
                    currentSum = 0; //Iz4istva q ot stoinost,  za da moje da produlji da se polzva kato transfer za operaciite na cikula 
                }
                //.......................................................................................................
                if ((firstIndex > 0) && (lastIndex > 0)) //Ako purviq index e polojitelno 4islo i 2riq e, togava printira 
                {
                    Console.Write("The sequence with sum {0} is: ", S);
                    for (int i = firstIndex; i <= lastIndex; i++) //Razglejda vsi4ki elementi zapo4va6ti ot purviq index i svur6va6ti do posledniq index 
                    {
                        if (i == lastIndex) //Ako purviq index i posledniq suvpadat,
                        {
                            Console.WriteLine("{0}", array[i]); //teku6tiq element
                        }
                        else
                        {
                            Console.WriteLine("{0}, ", array[i]); //..za da gi razdelq sus zapetaika
                        }
                    }
                }
                else
                {
                    Console.WriteLine("There is no sequence with sum {0} in the array.", S);
                }
            }
        }
    }
}