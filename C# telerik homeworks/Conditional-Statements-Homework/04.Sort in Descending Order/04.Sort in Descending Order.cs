using System;

namespace _04.Sort_in_Descending_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sort 3 real values in descending order using nested if statements.

            //Example 1:
            Console.Write('\a');
            Console.WriteLine("<<First example of solving the task>>"); //works with any int values

            Console.Write("enter first number: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("enter second number: ");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.Write("enter third number: ");
            int thirdNumber = int.Parse(Console.ReadLine());
   
            Console.Beep();

            if ((firstNumber == secondNumber && secondNumber == thirdNumber))
            {
                Console.WriteLine("The numbers are equal. The end!");
            }
            else
            {
                if (firstNumber > secondNumber) //1
                {
                    if (firstNumber > thirdNumber)
                    {
                        if (secondNumber > thirdNumber)
                        {
                            Console.WriteLine("The numbers in descending order: {0}, {1}, {2}", firstNumber, secondNumber, thirdNumber);
                        }
                        else
                        {
                            Console.WriteLine("The numbers in descending order: {0}, {1}, {2}", firstNumber, thirdNumber, secondNumber);
                        }
                    }
                    else
                    {
                        Console.WriteLine("The numbers in descending order: {0}, {1}, {2}", thirdNumber, firstNumber, secondNumber);
                    }
                }
                else
                {
                    if (secondNumber > thirdNumber) //2
                    {
                        if (firstNumber > thirdNumber)
                        {
                            Console.WriteLine("The numbers in descending order: {0}, {1}, {2}", secondNumber, firstNumber, thirdNumber);
                        }
                        else
                        {
                            Console.WriteLine("The numbers in descending order: {0}, {1}, {2}", secondNumber, thirdNumber, firstNumber);
                        }
                    }
                    else
                    {
                        Console.WriteLine("The numbers in descending ordere: {0}, {1}, {2}", thirdNumber, secondNumber, firstNumber);
                    }

                    //CHECK which are equal
                }
                if ((secondNumber != thirdNumber) && (secondNumber == firstNumber))
                {
                    Console.WriteLine("But, the first and the second numbers are equal.");
                }
                if ((firstNumber == thirdNumber && secondNumber != firstNumber))
                {
                    Console.WriteLine("But, the first and the third numbers are equal.");
                }
                if ((secondNumber == thirdNumber && secondNumber != firstNumber))
                {
                    Console.WriteLine("But, the second and the third numbers are equal.");
                }
            }

            
            //Example 2:
            Console.WriteLine("\n<<Second example of solving the task>>");
            int first = 3; //works correctly with these values
            int second = 2;
            int third = 1;

            if ((first == second && second == third))
            {
                Console.WriteLine("The numbers are equal.");
            }
            else
            {
                if ((first > second) && (second > third) || (third > second) && (first > third))
                {
                    Console.WriteLine(first); //the biggest 3

                    if (second > third)
                    {
                        Console.WriteLine(second); //the middle 2
                    }
                    else if (second < third)
                    {
                        Console.WriteLine(third); //the middle second check
                    }
                    if (third < second)
                    {
                        Console.WriteLine(third); //the smallest
                    }
                    else
                    {
                        Console.WriteLine("Vitamin C is good for your body!");
                    }
                }
                //}
                //else if ((second > first && (first > third) || (third > first) && (second > third))
                //{
                //    Console.WriteLine(second); //the biggest
                //    if (first > third)
                //    {
                //        Console.WriteLine(third);
                //    }
                //    else
                //    {
                //        Console.WriteLine(first); //the smallest
                //    }
                //}
                //else if((third > first) && (first > second) || (first < second) && (third > second))
                //{
                //    Console.WriteLine(third); //the biggest
                //    if (second > first)
                //    {
                //        Console.WriteLine(first); //the smallest
                //    }
                //    else
                //    {
                //        Console.WriteLine(second); //the smallest
                //    }
                //}


                
            }
        }
    }
}