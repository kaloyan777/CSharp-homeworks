using System;

namespace _12.Zero_Subset
{
    class Program
    {
        static void Main(string[] args)
        {
            //We are given 5 integer numbers. Write a program that finds all subsets of these numbers whose sum is 0. 
            //Assume that repeating the same subset several times is not a problem.

            //Hint: you may check for zero each of the 32 subsets with 32 if statements.

            //Дадени са пет цели числа. Напишете програма, която намира онези подмножества от тях, които имат сума 0. Примери:
            //- Ако са дадени числата {3, -2, 1, 1, 8}, сумата на -2, 1 и 1 е 0.
            //- Ако са дадени числата {3, 1, -7, 35, 22}, няма подмножества със сума 0.
            //            Използвайте вложени if конструкции или последователност от
            //сравнения, за да проверите сумите на всичките 15 подмножества на
            //дадените числа (без празното).



            int[] numbers = new int[5];
            int counter = 0;



            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }



            if ((numbers[0] + numbers[1]) == 0) 
            { 
                Console.WriteLine("{0} {1} is 0", numbers[0], numbers[1]); counter = 1; 
            }
            if ((numbers[0] + numbers[2]) == 0) 
            {
                Console.WriteLine("{0} {1} is 0", numbers[0], numbers[2]); counter = 1; 
            }
            if ((numbers[0] + numbers[3]) == 0) 
            {
                Console.WriteLine("{0} {1} is 0", numbers[0], numbers[3]); counter = 1; 
            }
            if ((numbers[0] + numbers[4]) == 0) 
            { 
                Console.WriteLine("{0} {1} is 0", numbers[0], numbers[4]); counter = 1; 
            }
            if ((numbers[1] + numbers[2]) == 0) 
            {
                Console.WriteLine("{0} {1} is 0", numbers[1], numbers[2]); counter = 1; 
            }
            if ((numbers[1] + numbers[3]) == 0) 
            { 
                Console.WriteLine("{0} {1} is 0", numbers[1], numbers[3]); counter = 1; 
            }
            if ((numbers[1] + numbers[4]) == 0) 
            {
                Console.WriteLine("{0} {1} is 0", numbers[1], numbers[4]); counter = 1; 
            }
            if ((numbers[2] + numbers[3]) == 0) 
            {
                Console.WriteLine("{0} {1} is 0", numbers[2], numbers[3]); counter = 1; 
            }
            if ((numbers[2] + numbers[4]) == 0) 
            {
                Console.WriteLine("{0} {1} is 0", numbers[2], numbers[4]); counter = 1; 
            }
            if ((numbers[3] + numbers[4]) == 0) 
            {
                Console.WriteLine("{0} {1} is 0", numbers[3], numbers[4]); counter = 1; 
            }



            if ((numbers[0] + numbers[1] + numbers[2]) == 0) 
            {
                Console.WriteLine("{0} {1} {2} is 0", numbers[0], numbers[1], numbers[2]); counter = 1; 
            }
            if ((numbers[0] + numbers[1] + numbers[3]) == 0) 
            {
                Console.WriteLine("{0} {1} {2} is 0", numbers[0], numbers[1], numbers[3]); counter = 1; 
            }
            if ((numbers[0] + numbers[1] + numbers[4]) == 0) 
            {
                Console.WriteLine("{0} {1} {2} is 0", numbers[0], numbers[1], numbers[4]); counter = 1; 
            }
            if ((numbers[0] + numbers[2] + numbers[3]) == 0) 
            {
                Console.WriteLine("{0} {1} {2} is 0", numbers[0], numbers[2], numbers[3]); counter = 1; 
            }
            if ((numbers[0] + numbers[2] + numbers[4]) == 0) 
            {
                Console.WriteLine("{0} {1} {2} is 0", numbers[0], numbers[2], numbers[4]); counter = 1; 
            }
            if ((numbers[0] + numbers[3] + numbers[4]) == 0) 
            {
                Console.WriteLine("{0} {1} {2} is 0", numbers[0], numbers[3], numbers[4]); counter = 1; 
            }
            if ((numbers[1] + numbers[2] + numbers[3]) == 0) 
            {
                Console.WriteLine("{0} {1} {2} is 0", numbers[1], numbers[2], numbers[3]); counter = 1; 
            }
            if ((numbers[1] + numbers[2] + numbers[4]) == 0) 
            {
                Console.WriteLine("{0} {1} {2} is 0", numbers[1], numbers[2], numbers[4]); counter = 1; 
            }
            if ((numbers[1] + numbers[3] + numbers[4]) == 0) 
            {
                Console.WriteLine("{0} {1} {2} is 0", numbers[1], numbers[3], numbers[4]); counter = 1; 
            }
            if ((numbers[2] + numbers[3] + numbers[4]) == 0) 
            {
                Console.WriteLine("{0} {1} {2} is 0", numbers[2], numbers[3], numbers[4]); counter = 1; 
            }



            if ((numbers[0] + numbers[1] + numbers[2] + numbers[3]) == 0) 
            { 
                Console.WriteLine("{0} {1} {2} {3} is 0", numbers[0], numbers[1], numbers[2], numbers[3]); counter = 1; 
            }
            if ((numbers[0] + numbers[1] + numbers[2] + numbers[4]) == 0) 
            {
                Console.WriteLine("{0} {1} {2} {3} is 0", numbers[0], numbers[1], numbers[2], numbers[4]); counter = 1; 
            }
            if ((numbers[0] + numbers[2] + numbers[3] + numbers[4]) == 0) 
            {
                Console.WriteLine("{0} {1} {2} {3} is 0", numbers[0], numbers[2], numbers[3], numbers[4]); counter = 1; 
            }
            if ((numbers[1] + numbers[2] + numbers[3] + numbers[4]) == 0) 
            {
                Console.WriteLine("{0} {1} {2} {3} is 0", numbers[1], numbers[2], numbers[3], numbers[4]); counter = 1; 
            }



            if ((numbers[0] + numbers[1] + numbers[2] + numbers[3] + numbers[4]) == 0) 
            { Console.WriteLine("{0} {1} {2} {3} {4} is 0", numbers[0], numbers[1], numbers[2], numbers[3], numbers[4]); counter = 1; }



            if (counter == 0) 
            {
                Console.WriteLine("No subset with sum of 0 found."); 
            }
        }
    }
}