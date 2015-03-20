using System;

namespace _7.Sum_of_5_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.
            //Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            //Console.WriteLine(string.Join(", ", numbers));




            //example 1:

            Console.WriteLine("---EXAMPLE 1---");
            Console.WriteLine("[Enter 5 numbers (given in a single line, separated by a space)]");
            string[] userINput = Console.ReadLine().Split(); //Even if u enter more than 5 numbers, it will still calculate the sum of only 5, 
                                                             //because 5 Console.Readline-s are defined! Nice a? haha

            int A = Convert.ToInt32(userINput[0]); //for floating numbers...change the conversion: Convert.ToDouble...
            int B = Convert.ToInt32(userINput[1]);
            int C = Convert.ToInt32(userINput[2]);
            int D = Convert.ToInt32(userINput[3]);
            int E = Convert.ToInt32(userINput[4]);
           
            int SUM = A + B + C + D + E;
            Console.WriteLine("Sum = " + SUM);




            //example 2:

            Console.WriteLine("\n---EXAMPLE 2---");
            int sum = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Number {0} = ", i+1); //i+1 - so to show 1,2,3,4,5 not 0,1,2,3,4 on the console. 
                sum += int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Sum: " + sum);

                        //example 2 v2:

                        string numberText;
                        int theNumber = 0;

                        sum = 0;

                        for (int i = 1; i <= 5; i++)
                        {
                            Console.Write("number {0}: ", i);
                            numberText = Console.ReadLine();
                            while (Int32.TryParse(numberText, out theNumber))
                            {
                                sum += theNumber;
                                break;
                            }
                        }
                        Console.WriteLine(sum);




            //example 3:

            Console.WriteLine("\n---EXAMPLE 3---");
            string a; //will enter a string number, 
            int a1 = 0; //then Try to Parse it into an integer number.
            bool parseSuccess = false;

            while (parseSuccess != true)
            {
                Console.Write("a: ");
                a = Console.ReadLine();
                parseSuccess = Int32.TryParse(a, out a1); //the loop breaks, because now parseSuccess = true. 
                //And if it is not true, then will keep repeating, until parsing is successfull...
            }

            string b;
            int b1 = 0;
            bool parseSuccess2 = false;

            while (parseSuccess2 != true)
            {
                Console.Write("b: ");
                b = Console.ReadLine();
                parseSuccess2 = Int32.TryParse(b, out b1);
            }

            string c;
            int c1 = 0;
            bool parseSuccess3 = false;

            while (parseSuccess3 != true)
            {
                Console.Write("c: ");
                c = Console.ReadLine();
                parseSuccess3 = Int32.TryParse(c, out c1);
            }

            string d;
            int d1 = 0;
            bool parseSuccess4 = false;

            while (parseSuccess4 != true)
            {
                Console.Write("d: ");
                d = Console.ReadLine();
                parseSuccess4 = Int32.TryParse(d, out d1);
            }

            string e;
            int e1 = 0;
            bool parseSuccess5 = false;

            while (parseSuccess5 != true)
            {
                Console.Write("e: ");
                e = Console.ReadLine();
                parseSuccess5 = Int32.TryParse(e, out e1);
            }
            Console.WriteLine("Sum of a, b, c, d, e = " + (a1 + b1 + c1 + d1 + e1));
        }
    }
}