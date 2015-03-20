using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.The_Most_Frequent_Number_In_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Write a program that finds the most frequent number in an array. 
            //  Example: {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)
            //...............................................................................................
            //  Напишете програма, която намира най-често срещания елемент в масив. 
            //  Пример: {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (среща се 5 пъти).
            //  Тази задача може да се решите по много начини. 
            //  Един от тях е следният: взимате първото число и проверявате колко пъти се повтаря в масива, 
            //като пазите този брой в променлива. След всяко прочитане на еднакво число го заменяте с int.MinValue. 
            //  След това взимате следващото и отново правите същото действие. Неговия брой срещания сравнявате с числото, 
            //което сте запазили в променливата и ако то е по-голямо, го присвоявате на променливата. 
            //  Както се досещате, ако намерите число равно на int.MinValue преминавате към следващото.
            //  Друг начин да решим задачата е да сортираме числата в нарастващ ред и тогава, 
            //еднаквите числа ще бъдат разположени, като съседни. 
            //  Така задачата се свежда до намиране на най-дългата редица от съседни числа
            //...............................................................................................

            int n; //Br. elementi v masiva 
            int currentTimes = 0; //Br. povtoreniq na teku6tiq el. 
            int maxTimes = currentTimes; //Nai-golemiq br. povtoreniq 
            int mostFrequent = int.MinValue; //Stoinostta na el. koqto se povtarq nai-mn puti

            //.............................................................................................
            Console.Write("Number of array elemets: ");
            string strN = Console.ReadLine();

            //.............................................................................................
            if (!int.TryParse(strN, out n)) //Proverqva dali stringa Ne e 4islo
            {
                Console.WriteLine("Invalid number!");
            }
            else //...Ako e 4islo:
            {
                int[] array = new int[n]; //Prisvoqva vuvedenoto 4islo kato razmer na masiva 
                for (int i = 0; i < n; i++) //Vuvejda stoinost za vseki el. na masiva 
                {
                    Console.Write("Enter array element: ");
                    array[i] = int.Parse(Console.ReadLine());
                }

                //..................................................................................
                int totalMostFrequent = array[0]; //Prisvoqva se purviq el. na masiva na totalmostfr 

                //..................................................................................
                for (int i = 0; i < array.Length; i++)
                {
                    for (int p = i; p < array.Length; p++)  //Vzema teku6tiq element na gorniq cikul i zapo4va da iterira ot nego na dqsno 
                    {
                        if (array[i] == array[p])    //Sravnqva teku6tiq el. na vun6niq cikul s teku6tiq el. na vutre6niq cikul 
                        {
                            currentTimes++;          //Inktrementira teku6tiq br. povtoreniq na teku6tiq el.
                            mostFrequent = array[p]; //Prisvoqva teku6tiq el. na vutre6niq cikul 
                        }
                    }

                    //...............................................................................
                    if (currentTimes > maxTimes)            //Ako tekut6iq br. povtoreniq e po-golqm ot maximalniq,
                    {
                        maxTimes = currentTimes;            //togava prisvoqva teku6tiq na max
                        totalMostFrequent = mostFrequent;   //i elementa s nai-golqm br. povtr. na total most fr. 
                    }
                    currentTimes = 0; //Pri startirane tursene br. povtoreniq na teku6tiq el. nulira broq4a, 
                                      //6ot pri sqka iteraciq razglejda otdelen el. v masiva i za nego proverqva 
                                      //kolko puti se povtarq stoinostta mu v sledva6tite el.
                }
                //...................................................................................
                Console.WriteLine("{0} Appears the most. Exactly {1} times.", totalMostFrequent, maxTimes);
            }

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //..................................EXAPLE 2:
            //int[] arr = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
            //int temporary = 0; //Tazi promenliva se polzva za da i se prisvoqva stoinostta na teku6tiq element ot duduka, koito se razglejda v momenta 
            //int counter; //Ot sintakti4na gledna to4ka se suzdava promenliva counter, za da su6testvuva, kato definiran predvaritelno za da se polzva navsqkade iz koda hahaha

            ////.............................................................................................................
            //for (int i = 1; i < arr.Length; i++) //Cikula obru6ta vnimanie na seki edin element ot masiva, na koito maika mu i ba6ta mu ne sa mu obru6tali vnimanie kato maluk hahahahaha 
            //{
            //    counter = i; //Counter zema stoinostta na indexa na teku6tiq element koito e i, and prestavlqva indexa na sqko eno 4islo ot masiva (index e nomera na sqko 4islo ot masiva ne6to kato adresa mu, razbira6 li?)
            //    while (counter > 0 && arr[counter] < arr[counter - 1]) //Proverqva dali teku6tiq el. e < ot predhodniq
            //    {
            //        temporary = arr[counter];         //Na vremennata promenliva koqto polzva za transfer na elementite na masiva prisvoqva stoinostta na teku6tiq el.
            //        arr[counter] = arr[counter - 1];  //Na teku6tiq el. prisvoqva na predhodniq, koito se namira ot lqvo mu 
            //        arr[counter - 1] = temporary;    //Na predhodniq el. prisvoqva stoinostta na teku6tiq (4iqto stoinost suhranqva vremenno v temporary)

            //        counter--;  //Promenq poziciqta/adresa na teku6toto 4islo v masiva...otiva s ena poziciq v lqvo //cqlata taq 6a6kaniq se pravi za da si nameri teku6tiq el. pravilnoto mqsto v masivaaaaaaaaaakjadgsfjklasbdf
            //    }
            //}// // // DO TYK ZADA4ATA IZPISVA CHISLATA OT MASIVA V NARASTVA6T RED, KATO VS. EDNAKVI CHISLA SA SUSEDNI 

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //..................................EXAMPLE 3:
            int[] arr = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9 };

            int sequence = 0; //broi povtoreniq na razglejdanoto 4islo 
            int maxSeq = 0;   //broi povtoreniq na maximalno povtarq6toto se 4islo // KOLKO puti se povtarq
            int maxSeqDigit = arr[0]; //4isloto koeto se povtarq nai-mn //KOE 4islo se povtarq, obozna4ava se s 0 za6toto v ezika tova e purvata poziciq kato adres 0,1,2,3... kato pozicii = 1,2,3,4...tva ve4e sme go govorili, nq obesnqm poe4e!

            for (int i = 1; i < arr.Length; i++) //obhojda cqlata duljina na masiva turseki gornite duduci, i = 1, 1 pre'stavlqva poziciqta na elementa v masiva, obozna4ava se 1 za da moje da se sravnqva s elemeta ot lqvo mu 
            {
                if (arr[i] == arr[i - 1]) //sravnqvame teku6tiq s predhodniq dali sa ravni
                {
                    sequence++; //inkrementirame stoinostta na poredicata, za da otbeleji, 4e 4isloto se povtarq o6te vednuj, 6ot ne mu stiga samo 1 put!
                    if (sequence > maxSeq) //ako broq4a na taq posledovatelnost e > ot maximalnata dosega, 
                    {
                        maxSeq = sequence; //togava prisvoqvame stoinostta na broq4a - na tazi na maximalnata posledovatelnost; sequence se dviji, obhojda cqlata duljina na masiva i maxseq e suob6tenieto, koeto kazva do momenta koq e maximalno dulgata, i sq sus tova prisvoqvane updatevame stoinostta na obhojda6tata...kato za da se osu6testvqva sravnenieto sus sqka sledva6ta stoinost na masiva trqva da se sravnqva sus maximalnata, za tova na maxseq prisvoqvame stoinostta na seq! zEmi toq komentar v tvoq gOlem inventar!
                        maxSeqDigit = arr[i]; //teku6toto 4islo arr[i] go prisvoqvame na stoinostta na 4isloto koeto nai-mn puti se povtarq v masiva maxseqdig, za6toto uslovieto na if-a                    
                    }
                }
                else //if (arr[i] != arr[i - 1]) ako teku6tiq el. ne e raven na predhodniq, 
                {
                    sequence = 1; //togava broq povtoreniq na teku6tiq el. e samo 1, poneje, ako bqha ravni, 6tqha da sa 2, razbira6 li?  
                }
            }

            Console.Write("\nIn array (4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9): ");
            Console.WriteLine("number " + maxSeqDigit + " appears " + maxSeq +" times first!");
        }
    }
}