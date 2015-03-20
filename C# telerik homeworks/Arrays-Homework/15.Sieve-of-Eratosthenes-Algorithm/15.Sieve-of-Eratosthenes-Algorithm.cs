using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Sieve_of_Eratosthenes_Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Write a program that finds all prime numbers in the range [1...10 000 000]. Use the sieve of Eratosthenes algorithm
            //Напишете програма, която намира всички прости числа в диапазона [1…10 000 000].
            //Потърсете в Интернет информация за "Sieve of Erathostenes" (Решетото на Ератостен, учено в часовете по математика).
            //..................................................................................................

            int[] numbers = new int[10000000]; //Masiva sudurja6t si4ki poredni 4isla ot 0-10 000 000, v momenta vs 4isla v diapazaona sa int[] = 0li, posle v For() im se zadavat stoinosti 
            List<int> primeNumbers = new List<int>(); //Sudurja si4ki prosti 4isla v diapazona na numbers
            //..................................................................................................
            for (int a = 2; a < 10000000; a++)  //Zadava stoinost za vs 4isla v diapazona 
            {
                numbers[a] = a; //Prisvoqvame stoinostta na poziciqta kato stoinost na samiq element, nomer na poziciqta stava stoinost na elementa pr. el. na poziciq 5 ima stoinost 5 
            }
            //..................................................................................................
            int i = 2; //Teku6toto 4islo ot koeto zapo4va si4ko, 2 e za6toto metoda na Sieve of Erathostenes
            int j = 0; //Suzdavane na promenliva predi da bude polzvana v ciklite dolo, za da ne se pi6e navsqkade int, a samo "j". :P
            //..................................................................................................
            while (i < 10000000) //Razglejda vsqko 1 4islo v diapazona 
            {
                if (numbers[i] != -1) //*//Ako teku6toto 4islo ima stoinost - 1, togava otiva napravo na inkrementaciqta v kraq na while cikula
                {
                    j = i; //Teku6toto 4islo se prisvoqva na j, j e proizvodno na i, polu4ava se ot i, kato pri vs. iteraciq vuv FOR dobavqme i kum teku6tata stoinost na j  
                    primeNumbers.Add(i); //Pribavq teku6toto prosto 4islo kum spisuka s prosti 4isla 

                    for (; j < 10000000; j += i)  //Na vs elementi proizvodni na j , prisvoqva stoinost - 1,  za da budat propuskani pri po-natatu6na sre6ta v koda, zas6toto ve4e sa ustanoveni kato slojni 4isla   
                    {
                        numbers[j] = -1;
                    }
                }
                i++; //*//Inkrementira poredniq element v poredniq spisuk s 4isla 
            }
            //..................................................................................................
            foreach (int item in primeNumbers) //I te taka!
            {
                Console.Write(item + " , ");
            }
        }
    }
}