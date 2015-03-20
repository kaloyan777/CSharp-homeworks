using System;

namespace _07.The_Greatest_Of_5_Given
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that finds the greatest of given 5 variables.

            Console.WriteLine("First: ");
                int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Second: ");
                int secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Third: ");
                int thirdNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Fourth: ");
                int fourthNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Fifth: ");
                int fifthNumber = int.Parse(Console.ReadLine());

                int greatestNumber = firstNumber; //taking 1st number to start comparing


            if (greatestNumber < secondNumber) //if 1st < 2nd,
            {
                greatestNumber = secondNumber; //then the geatest (for the moment) is 2nd
            }
            if (greatestNumber < thirdNumber) //if the greatest (for the moment) is < 3rd
            {
                greatestNumber = thirdNumber; //then the greatest (now) is the 3rd...and so on for all the others!
            }
            if (greatestNumber < fourthNumber)
            {
                greatestNumber = fourthNumber;
            }
            if (greatestNumber < fifthNumber)
            {
                greatestNumber = fifthNumber;
            }
            Console.WriteLine("The greatest number is: {0}", greatestNumber); //when all 4 checks are done, print the greatest.

            //MUST NOT be nested IFs like shown down below! If using nested IFs, you must use many ELSEs, 
            //and the code will be enormous! Example is below this one:

            //if (greatestNumber < secondNumber)  
            //{
            //    greatestNumber = secondNumber; 

            //    if (greatestNumber < thirdNumber) 
            //    {
            //        greatestNumber = thirdNumber; 

            //        if (greatestNumber < fourthNumber)
            //        {
            //            greatestNumber = fourthNumber;

            //            if (greatestNumber < fifthNumber)
            //            {
            //                greatestNumber = fifthNumber;
            //            }
            //        }
            //    }
            //}
            //Console.WriteLine("The greatest number is: {0}", greatestNumber); 



            //...Example using nested IFs:

                    //int firstInt = int.Parse(Console.ReadLine());
            //        int secondInt = int.Parse(Console.ReadLine());
            //        int thirdInt = int.Parse(Console.ReadLine());
            //        int fourthInt = int.Parse(Console.ReadLine());
            //        int fifthInt = int.Parse(Console.ReadLine());
            //        int biggest = 0;
            //        if (firstInt > secondInt)
            //        {
            //            biggest = firstInt;
            //            if (biggest > thirdInt)
            //            {
            //                if (biggest > fourthInt)
            //                {
            //                    if (biggest > fifthInt)
            //                    {
            //                        Console.WriteLine(biggest);
            //                    }
            //                    else
            //                    {
            //                        Console.WriteLine(fifthInt);
            //                    }
            //                }
            //                else
            //                {
            //                    biggest = fourthInt;
            //                    if (biggest > fifthInt)
            //                    {
            //                        Console.WriteLine(biggest);
            //                    }
            //                    else
            //                    {
            //                        Console.WriteLine(fifthInt);
            //                    }
            //                }
            //            }
            //            else
            //            {
            //                biggest = thirdInt;
            //                if (biggest > fourthInt)
            //                {
            //                    if (biggest > fifthInt)
            //                    {
            //                        Console.WriteLine(biggest);
            //                    }
            //                    else
            //                    {
            //                        Console.WriteLine(fifthInt);
            //                    }
            //                }
            //                else
            //                {
            //                    biggest = fourthInt;
            //                    if (biggest>fifthInt)
            //                    {
            //                        Console.WriteLine(biggest);
            //                    }
            //                    else
            //                    {
            //                        Console.WriteLine(fifthInt);
            //                    }
            //                }
            //            }
            //        }
            //        else
            //        {
            //            biggest = secondInt;
            //            if (biggest > thirdInt)
            //            {
            //                if (biggest > fourthInt)
            //                {
            //                    if (biggest > fifthInt)
            //                    {
            //                        Console.WriteLine(biggest);
            //                    }
            //                    else
            //                    {
            //                        Console.WriteLine(fifthInt);
            //                    }
            //                }
            //                else
            //                {
            //                    biggest = fourthInt;
            //                    if (biggest > fifthInt)
            //                    {
            //                        Console.WriteLine(biggest);
            //                    }
            //                    else
            //                    {
            //                        Console.WriteLine(fifthInt);
            //                    }
            //                }
            //            }
            //            else
            //            {
            //                biggest = thirdInt;
            //                if (biggest > fourthInt)
            //                {
            //                    if (biggest > fifthInt)
            //                    {
            //                        Console.WriteLine(biggest);
            //                    }
            //                    else
            //                    {
            //                        Console.WriteLine(fifthInt);
            //                    }
            //                }
            //                else
            //                {
            //                    biggest = fourthInt;
            //                    if (biggest > fifthInt)
            //                    {
            //                        Console.WriteLine(biggest);
            //                    }
            //                    else
            //                    {
            //                        Console.WriteLine(fifthInt);
            //                    }
            //                }
            //            }
            //        }
            //    }
            //}
        }
    }
}
