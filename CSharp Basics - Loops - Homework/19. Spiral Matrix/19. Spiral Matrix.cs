using System;

namespace _19.Spiral_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a 
            //matrix holding the numbers from 1 to n*n in the form of square spiral like in the examples below. 


            int matrixDim = int.Parse(Console.ReadLine());

            int[,] arr = new int[matrixDim, matrixDim]; //matrixa s razmer N na N(n*n) = viso4ina = duljina.

            int count = 1; //polzva se za uveli4avane na stoinostta na promenlivite, koito sa adresi na elementite ot matrixa-ta.

            int i = 0, j = 0, k = 0, m = 0, n = 0; //definirat se tyk, za da mogat da se polzvat i izvun usloviqta na for-ciklite

            for (i = 0; i < matrixDim; i++)
            {
                //1: na dqsno
                for (j = i; j < matrixDim - i; j++) //tyk iteraciite 6te sa = na iteraciite ot glavniq for
                {
                    //Console.WriteLine("\n dqsno---count: " + count);
                    arr[i, j] = count++; //iteraciqta na count tyk, 6te pridava za celiq purvi red stoinost +1 na vseki sledva6t element..1,2,3,4,5...
                    //Console.WriteLine("*dqsno - " + (arr[i, j]));
                }
                j--;

                //2: na dolo
                for (k = i; k < matrixDim - i - 1; k++)
                {
                    //Console.WriteLine("\n dolo---count: " + count);
                    arr[k + 1, j] = count++;
                    //Console.WriteLine("*dolo - " + (arr[k + 1, j]));
                }

                //3: na lqvo
                for (m = k; m > i; m--)
                {
                    //Console.WriteLine("\n lqvo---count: " + count);
                    arr[k, m - 1] = count++;
                    //Console.WriteLine("*lqvo - " + (arr[k, m - 1]));
                }

                //4: na gore
                for (n = k; n > i + 1; n--)
                {
                    //Console.WriteLine("\n gore---count: " + count);
                    arr[n - 1, m] = count++;
                    //Console.WriteLine("*gore - " + (arr[n - 1, m]));
                }
            }

            //Print the matrix:
            for (int p = 0; p < matrixDim; p++)
            {
                for (int l = 0; l < matrixDim; l++)
                {
                    Console.Write("{0,4}", arr[p, l]);
                }
                Console.WriteLine();
            }
        }
    }
}

            //Решение е от сайта на ел-книга Intro To Programming.

            //Напишете програма която по зададено положително число N изписва на конзолата числата от 1 до N*N нарадени във формата на спирала. 
            //За да се формира добре изглеждаща таблице, след всички числа освен след най-десните на всеки ред 
            //трябва да бъде добавен символът за табулация: "\t"

            //Описание на входа
            //На първият и единствен ред от входа е зададен размерът на квадратната матрица N.
            //N е положително число в интервал: 1...100 включително

            //Описание на изхода
            //На конзолата трябва да се изведе масив от числа наредени в спирала. 
            //След всички числа освен най-десните трябва да бъде добавен символът за табулация: "\t"

            //Анализ на задачата
            //Генерира се двумерна матрица с размер N на N, както и две помощни променливи start = 0 и end = N. 
            //Използвайки тези променливи обхождаме подред и добавяме стойности към елементите от „периферията“ на масива. 
            //След това увеличаваме стайността на start с 1 и намаляваме тази на end с 1. 
            //По този начин при следващото обхождане  ще се се мине през периферните елементи които са с едно поле „по-навътре“ към центъра на матрицата. 
            //Повтаряме тези стъпки докато не изпечатаме последният елемент – центърът на матрицата при start – end = 1.


            //            int size = int.Parse(Console.ReadLine());

            //            int[,] spiralArray = new int[size, size];

            //            int start = 0;
            //            int end = size;
            //            int k = 1;

            //            while (end - start >= 1)
            //            {
            //                for (int p = start; p < end; p++)
            //                {
            //                    spiralArray[start, p] = k;
            //                    ++k;
            //                }
            //                for (int q = start + 1; q < end; q++)
            //                {
            //                    spiralArray[q, end - 1] = k;
            //                    ++k;
            //                }
            //                for (int r = end - 2; r >= start; r--)
            //                {
            //                    spiralArray[end - 1, r] = k;
            //                    ++k;
            //                }
            //                for (int s = end - 2; s >= start + 1; s--)
            //                {
            //                    spiralArray[s, start] = k;
            //                    ++k;
            //                }
            //                start = start + 1;
            //                end = end - 1;
            //            }

            //            for (int i = 0; i < size; i++)
            //            {
            //                for (int j = 0; j < size; j++)
            //                {
            //                    if (j == size - 1)
            //                    {
            //                        Console.Write(spiralArray[i, j]);
            //                    }
            //                    else
            //                    {
            //                        Console.Write(spiralArray[i, j] + "\t");
            //                    }
            //                }
            //                Console.WriteLine();
            //            }
            //        }
            //    }
            //}


          