using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Array_20Ints_Index_Multiplied_by_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5. 
            //  Print the obtained array on the console.
            //.................................................................................................................
            //  Да се напише програма, която създава масив с 20 елемента от целочислен тип 
            //и инициализира всеки от елементите със стойност равна на индекса на елемента умножен по 5. 
            //  Елементите на масива да се изведат на конзолата. Използвайте масив int[] и for цикъл.
            //.................................................................................................................
            //* int[] numbers; // declare numbers as an int array of any size 
            //* promenlivata numbers e ot tip massive, tova se razbira po kvadratnite skobi sled int-a
            //* numbers = new int[10];  // numbers is a 10-element array //int pokazva tipa na elementite koito sadurja masiva.
            //..................................................................................................................

            int[] numbers = new int[20]; // Definira kolko elementa da sadurja masiva ...20
            for (int i = 0; i < 20; i++) //...If (int i = 0; i < numbers.lenght; i++) = dinami4no izpulnenie na cikula...
                                         // Vzima razmera na masiva (br. na elementite mu) i cikula pravi tolkova iteracii, 
                                         //za6toto ako e i < 20, togava 6te se izpulnqva samo 20 puti, 
                                         //a moje da sa zadadeni 50 pri deklaraciqta na masiva.
            {
                numbers[i] = i * 5;      // Vzima teku6tiq element i mu prisvoqva stoinost indeksa na elementa umnojena po 5.
                Console.WriteLine("- Obtained Array element: " + numbers[i]);
            }
        }
    }
}