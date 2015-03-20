using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Maximal_Sequence_Of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Write a program that finds the maximal sequence of equal elements in an array.
            //  Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1}  {2, 2, 2}.
          //.............................................................................................
            //  Напишете програма, която намира максимална редица от последователни еднакви елементи в масив. 
            //  Пример: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1}  {2, 2, 2}.
            //  Сканирайте масива отляво надясно. Всеки път, когато текущото число
            //е различно от предходното, от него започва нова подредица, а всеки
            //път, когато текущото число съвпада с предходното, то е продължение
            //на текущата подредица. Следователно, ако пазите в две променливи
            //start и len съответно индекса на началото на текущата подредица от
            //еднакви елементи (в началото той е 0) и дължината на текущата
            //подредица (в началото той е 1), можете да намерите всички
            //подредици от еднакви елементи и техните дължини. От тях лесно
            //може да се избере най-дългата и да се запомня в две допълнителни
            //променливи – bestStart и bestLen.
          ////.............................................................................................................

          //  Console.Write("Enter sequence of numbers at the same row: ");
          //  string inputArrayOne = Console.ReadLine();

          ////...........................................opredelqne masiva

          //  char[] delimiter = new char[] { ',', ' ' };
          //  string[] inputOne = inputArrayOne.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);
          //  int[] arr = new int[inputOne.Length];

          ////...........................................pomo6tni promenlivi

          //  int counter = 0;
          //  int maxSequence = 0;
          //  int index = 0;

          ////......................................zadavane stojnosti na el. na masiva

          //  for (int i = 0; i < inputOne.Length; i++)
          //  {
          //      arr[i] = int.Parse(inputOne[i]);
          //  }

          ////......................................

          //  for (int i = 0; i < arr.Length; i++)
          //  {
          //      counter = 0;
          //      int j = i;

          //      while (arr[i] == arr[j])
          //      {
          //          counter++;
          //          j++;

          //          if (j >= arr.Length)
          //          {
          //              break;
          //          }
          //      }

          //      if (counter > maxSequence)
          //      {
          //          maxSequence = counter;
          //          index = i;
          //      }
          //  }

          ////...................................................

          //  for (int i = index; i <= index + maxSequence - 1; i++)
          //  {
          //      if (i != index + maxSequence - 1)
          //      {
          //          Console.Write(arr[i] + ", ");
          //      }
          //      else
          //      {
          //          Console.WriteLine(arr[i]);
          //      }
          //  }

          ////.............................................................................................................

            int[] array = { 3, 2, 3, 3, 4, 10, 11, 2, 7, 8, 9 }; 
            int size = array.Length; //Prisvoqva goleminata na masiva na promenliva
            int startPosition = 0;        //Na4alna poziciq na teku6tata posledovatelnost ot stoinosti 
            int lengthSeq = 1;       //(counter) Duljina na teku6tata posledovatelnost ot stoinosti

            //...............................................................................

            int positionOfMaxSeq = 0; //Na4alna poziciq na maximalnata posledovatelnost do sq
            int lenghtMaxSeq = 0;     //Duljina na maximalnata poziciq do sega

            //...............................................................................

            for (int i = 1; i < size; i++)    
            {
                if (array[i - 1] == array[i]) //Ako predhodniq element =  teku6tiq el. togaa:
                {
                    lengthSeq++;              //Uveli4ava duljinata na teku6tata posledovatelnost s 1(= ve4e imame ustanovena posledovatelnost ot ednakvi elementi),
                    if (lenghtMaxSeq == 1)    //ako duljinata na teku6tata posledovatelnost = 1,
                    {
                        startPosition = i - 1;     //na4alnata poziciq prisvoqva stoinostta na teku6tiq index minus 1(predhodniq index)
                    }
                    else //...ili, ako:
                    {
                        if (lenghtMaxSeq < lengthSeq)    //Duljinata na maximalnata posledovatelnost do sq e po-malka ot dulj. na teku6tata posledovatlenost,
                        {
                            lenghtMaxSeq = lengthSeq;    //to prisvoqva dulj. na teku6tata v promenlivata na max. posled.
                            positionOfMaxSeq = startPosition; //prisvoqva na4alnata poziciq na teku6tata posledovatelnost v promenlivata za na4alnata poziciq na max. posledovatelnost 
                        }
                        lengthSeq = 1; //Zadava stoinost za duljina na teku6tata posledovatelnost na edinica
                        startPosition = i;  //Zadava stoinost za na4alna poziciq na teku6tata posledovatelnost na i (stoinost na index (nomera na suotvetniq element v masiva) na teku6tiq element na masiva)
                    }
                }
            }
            Console.WriteLine("Lenght Of Max Seq: " + lenghtMaxSeq + " at Position Of Max Seq: " + positionOfMaxSeq);
        }
    }
}