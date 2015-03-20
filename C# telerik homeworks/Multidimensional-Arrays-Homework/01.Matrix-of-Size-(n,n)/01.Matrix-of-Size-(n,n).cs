using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Matrix_of_Size__n_n_
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)
            //  Напишете програма, която обхожда матрица (NxN).
            //  Помислете за подходящи начини за итерация върху масивите с два вложени цикъла.
            //  Разпишете обхождането на лист и помислете как да го реализирате с цикли и изчисления на индексите.
            //.....................................................................................................................

            int[,] matrix = new int[4, 4];
            int elementValue = 0;   //  Sadurja stoinostta na vseki 1 ot elementite v matrix.
            int row = 3;            //  Na4alnata stoinost na reda po4va ot 3, za6toto 1cata e v nai-dolniq lqv ugul, 
                                    //a matrixata e s 4 reda i 3 e posledniq red (4tiq).
            int column = 0;         //  Na4alna stoinost na kolonata 0.
            int startRowPosition = 3;       //  Sudurja stoinostta na teku6tiq red, koi e teku6tiq red.
            int startColumnPosition = 2;    //  Teku6tata kolona. 

            //.....................................................................................................................

            while (elementValue < 17)               //  Dokato stoinostta na kletkite v matrix sa pod 17, v smisul - 16 kletki samo imat stoinost:
            {
                //.............................................
                while ((row < 4) && (column < 4))       //  Togava, dokato to4nata stoinost na teku6tiq red i na kolonata sa po-malki ot 4, 
                {
                    if ((row == 3) || (column == 3))    //i proverqva za konkretna stoinost (3), ako kolonata ili reda imat stoinost 3, togava 
                    {
                        matrix[row, column] = elementValue++; //na matrix na suotveten red i kolona pribavq sledva6tata stoinost na el. value.
                        break;                                //    Izliza ot while-a, 6ot e dostignalo do krai na reda ili na kolonata. 
                    }
                    else
                    {
                        matrix[row, column] = elementValue++; //    Ako stoinostite na teku6tiq red i kolona sa po-malki ot 4 i razli4ni ot 3, 
                                                              //togava inkrementira stoinostta na el. value i q pribavq kum elementa ot matrixata 
                                                              //s suotvetnite stoinosti na row i colomn.
                        row++;                                //    Inkrementira stoinostite na dvete za da vidi dali e dostignal psoledniq red na matrix, 
                                                              //dali row e < 4 i razl. ot 3 i su6toto za kolonata , za6toto ako sa 3, otiva v if-a.
                        column++;
                    }
                }
                //.............................................
                if (row == 3 && column < 3)                   //    Proverqva poslednite stoinosti na row i na column, ako row = 3 , a column < 3, togava 
                {
                    row = startRowPosition--;                 //    Dekrementira stava 2 = ka4va s 1 red nagore.  
                    column = 0;                               //T.e. tova sa 1-vite kletki v matrix 1-vite pozicij, koito sa 0levi. 
                }
                else if (row == 3 && column == 3)             //    Ako stoinostta na row = 3 i column = 3 (tva ozna4ava, 4e so4at elementa, koito se namira na diagonal)
                {
                    row = 0;                                  //V takuf slu4ai teku6tiq red polu4ava stoinost 0, a stoinosta na kolonata - 1. 
                    column = 1;
                }
                else if (row < 3 && column == 3)              //    Ako poziciite na 2te so4at kum element nad osnovniq diagonal,  
                {
                    row = 0;                                  //togava tezi dvete pridobivat tezi stoinosti. 
                    column = startColumnPosition++;
                }
            }
            //.........................................................................................................
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(matrix[i, 0] + "," + matrix[i, 1] + "," + matrix[i, 2] + "," + matrix[i, 3]); //Print
            }
        }
    }
}