using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Longest_Area_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Write a program to find the longest area of equal elements in array of strings. 
             
             first read an integer n and n strings (each at a separate line), 
             then find and print the longest sequence of equal elements (first its length, then its elements). 
             If multiple sequences have the same maximal length, print the leftmost of them. 
              
             
           1.   За решението е нужно число за размер на масива, масив с такъв размер = числото.
           2.   Цикъл обхождащ всичките индекси по дължината на масива, който да пълни елемените на масива със стойности ч/з console.readline.

           3.   Втори for итериращ по вече зададените стойности на елементите на масива.
           4.   Временна променлива брояч, отчитащ колко пъти се повтаря даден елемент в масива(ще се намира във втория for цикъл, 
           стойността му ще е 1 по default, този брояч представлява съществуването за който проверяваме дали ВТОРИ път се повтаря, 
           той вече съществува веднъж(counter = 1)).
                Ще се рестартира обратно към default-ната си стойност(= 1) при всяко следващо итериране на цикъла в който се намира,
           ако не се рестартира, излиза че отброява пъти повтарящи се еднакви елементи въобще в целия масив, 
           а не конкретно за елемента, който се повтаря най-мн. пъти само той в целия масив. 

           Incorrect: 
            
           int counter = 1;
           for (int i = 0; i < array.Length; i++)
           {
               if (array[i] == array[i] + 1)
               {
                   counter++;
                   mostFrequentElement = array[i];
               }
             

           5.   Променлива брояч на която се присвоява стойността на временния брояч, за краен резултат от повторенията на елемента
           (неговата default-на първоначална стойност е 1, на същия принцип като temporary counter-a).
           6.   Променлива от типа на елемента за който проверяваме колко пъти се повтаря в масива,  
           на която ще присвоим стойността на същия този елемент, а не само колко пъти се повтаря.
           7.   Накрая резултат = бр. повторения и елемента който се повтаря толкова на бр. пъти.

           * Забележка(Ученика наруша'а десцеплината ф час по десцеплина! Незабавно да се препрограмира менталният софтвеър!):
             Първият for тръгва от първия си index(първа позиция) i = 0, 
           а втория for от първия си index = втория index на първия for(j = i + 1(втория индекс на 1-вия for)), 
           това се прави за да се проверяват два по два елементите на двата масива на времето на една итерация.
            
             Една кутийка на проверка включва един чифт елементи от масивa, "i"(от 1-вия for) 
           представлява левия елемент от двата елемента в кутийката предходен на десния, който е "j"(от втория for), 
           и така до края на дължината на масива. 
               
             * 
             * 
             
            Само кода, без коментари:
             
             * 
             * 
             * 
             int n = int.Parse(Console.ReadLine());
            string[] array = new string[n];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToString(Console.ReadLine());
            }

            string mostFrequentElement = null;
            int maxCount = 1;

            for (int i = 0; i < array.Length - 1; i++)
            {
                int counter = 1;

                for (int j = i + 1; j < array.Length; j++) 
                {
                    if (array[i] == array[j])
                    {
                        counter++;
                    }
                }
                if (counter > maxCount)
                {
                    maxCount = counter;
                    mostFrequentElement = array[i];
                }
            }
            Console.WriteLine("count: " + maxCount);
            Console.WriteLine("element: " + mostFrequentElement);
             
             */


            //Кода коментиран:

            Console.Write("Enter array length: ");
            int arrayLength = int.Parse(Console.ReadLine());
            string[] array = new string[arrayLength];

            for (int i = 0; i < arrayLength; i++)
            {
                Console.Write("Element[{0}] = ", i);
                array[i] = Convert.ToString(Console.ReadLine());
            }

            //mostFrequent(string-a X), maxCounter(string-a, който се повтаря толкова на бр. пъти)

            int maxCounter = 1; //Колко пъти съществува в масива числото.
            //В началото то съществува веднъж  със сигурност, защото е въведено при input-a.

            string mostFrequent = null; //Отчита обекта, който се повтаря най-мн. пъти.

            for (int i = 0; i < arrayLength - 1; i++)
            {
                int counter = 1; //При вс. следващо обхождане на цикъла, counter да се поднови с default-ната си стойност.

                for (int j = i + 1; j < arrayLength; j++)
                /*
                int j = i + 1; 
                
                Неговата стойност да e = на стойността на i(според итерирането на горния "for") + 1! 
                Така се проверяват двата index-a i, j дали са еднакви, като на j се добавя 1, за да бъде като позиция(а не като стойност)
                един index след i. Ако имаме елементите 2,3,4 в масива: i(1)=2, j(1) ще е равно на 3(i(1) + една позиция = i(2) = j(1)),
                после с if() проверяваме дали двата са равни...

                ...Всичко това се прави, за да се получи следната проверка като итерация:
                 - започни да циклиш по елементите на масива, започваки от 0-левия index(първият), като го сравняваш е
                този след него(i + 1), за да провериш, дали са еднакви като стойност(array[i] == array[j])!

                От тук(array[i] == array[j]) виждаме, че "i", "j" са елементи на един и същи масив "array", 
                а не се извършва проверка за равенство на елементите при два различни масива или итерации на цикли, както при много други задачи...
                 */
                {
                    if (array[i] == array[j]) //Ако някой от елементите(i/j) на масива(array) обходен от двата цикъла са равни,
                    {
                        counter++; //увеличи стойоността на "counter", за да отчете бройка повторения на елементи!
                    }
                }

                if (counter > maxCounter) //Ако бройката отчетена до момента e > от стойността на променливата,
                //която би трябвало да съдържа макс. бр. повторени елементи,
                {
                    maxCounter = counter; //нека тя да отдаде стойността си на тази променлива, 
                    //за да съхранява (maxCounter) максималното повторение.

                    mostFrequent = array[i]; //Индекса инициализиращ началото от последователността на повт. се елементи
                    //с най-голяма повт.мост от другите поварящи се = index-a на масива, защото array[i] е началото
                    //на последователността от eл. с най-голяма посл. до момента
                    //(тази стойност трябва да принадлежи на mostFrequent).
                }
            }

            //.....................................вече извън горния(главния) "for"(проверката).........................................:

            //Целият проблем(решението на задачата) трябва да се сведе до това заключение:
            if (maxCounter > 1) //Ако макс. повтаряне на еднакви елементи е > 1 път,  
            {
                //Console.WriteLine("Most frequent number = " + mostFrequent); //тогава изпиши елемента, който се повт. най-мн. 
                Console.WriteLine("Count = {0} times", maxCounter);    //и колко пъти се повт.
                for (int i = 0; i < maxCounter; i++)
                {
                    Console.WriteLine(mostFrequent);
                }
            }
            else
            {
                Console.WriteLine("All elements are different");
            }
        }
    }
}


                                                //Решения на колеги от форума на softuni.bg:

//1...........................................................................................................................

/*static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] array = new string[n];

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Array [{0}] =  ", i);
            array[i] = Console.ReadLine();
        }

        //Add variables for the final result
        int maxSequence = 0;
        string value = null;

        //The outer loop is rotated only once and for every index count, 
        //the inner loop is comparing every element with the next one 
        //(again and again till the end of array's length)

        for (int i = 0; i < array.Length; i++)
        {
            //The countSequence variable counts the lenght of equal elements, until a new element appears
            int countSequence = 0;

            //The inner one starts from the same position, like the outer loop
            for (int j = i; j < array.Length; j++)
            {
                if (array[i] == array[j])
                {
                    countSequence++;

                    //Check if this sequence is bigger than the maximum sequence and
                    //if true (first time, it's always true, because maxSequence = 0;)
                    //rewrites the old ones with the new counter values 
                    //(counter and the current sequence element)

                    if (maxSequence < countSequence)
                    {
                        maxSequence = countSequence;
                        value = array[i];
                    }
                }
                else
                {
                    break; //break and starts again from the next index of the outer loop.
                }
            }
        }

        Console.WriteLine("\nThe element of maximal sequence is \"{0}\", repeated {1} times", value, maxSequence);
    }
}

//2.........................................................................................................................
  
 static void Main(string[] args)
        {
            Console.WriteLine("Please enter n of n elements: ");
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            string[] array = new string[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Element {0} = ", i);
                array[i] = Console.ReadLine();
            }
            int lenghtCount = 0;
            int counter = 0;
            int temp = 0;
            int count = 0;
            int len = 0;
            List<string> equal = new List<string>();
            
            for (int k = 0; k < array.Length; k++)
            {
                for (int j = 1 + k; j < array.Length; j++)
                {
                    if (array[k] == array[j])
                    {
                        if (array.Length == equal.Count + 1 && counter == 0)
                        {
                            temp++;
                            equal.Add(array[k]);
                            Console.WriteLine(temp);
                            foreach (var item in equal)
                            {
                                Console.WriteLine(item);
                            }
                            return;
                        }
                        else if (temp == k && j == array.Length - 1)
                        {
                            equal.RemoveRange(0, count + 1);
                            counter = equal.Count;
                            Console.WriteLine(temp);
                            foreach (var item in equal)
                            {
                                Console.WriteLine(item);
                            }
                            return;
                        }
                        equal.Add(array[k]);
                        temp++;
                        lenghtCount++;
                        counter++;
                        len = count;
                        count = counter;
                        
                    }
                    else if (temp > 0)
                    {
                        equal.Add(array[k]);
                        temp = 0;
                        k = j;
                        continue;
                    }
                    
                }
                counter = 0;
            }
            if (lenghtCount == 0)
            {
                counter = 1;
                Console.WriteLine(counter);
                var lenghts = from element in array
                          orderby element.Length
                          select element;
            Console.WriteLine(lenghts.Last());
            return;
            }
            else if (temp == equal.Count)
            {
                equal.Add(array[temp]);
                counter = equal.Count;
            }
            else if (len > temp)
            {
                equal.Reverse();
                equal.RemoveRange(0, temp);
                counter = equal.Count;
            }
            else if (temp > len)
            {
                equal.RemoveRange(0,len);
                counter = equal.Count;
            }
            else if (len == temp)
            {
                equal.Reverse();
                equal.RemoveRange(0, temp);
                counter = equal.Count;
            }
            Console.WriteLine(counter);
            foreach (var item in equal)
            {
                Console.WriteLine(item);
            }
        }
    }
}*/