using System;

namespace _3.Divide_by_7_and_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time

            //example 1:

            Console.Write("1---Enter a number: ");
            int a = int.Parse(Console.ReadLine());
            bool result = true;

            if ((a % 5 == 0) && (a % 7 == 0))
            {
                Console.WriteLine(result + "\n");
            }
            else
            {
                result = false;
                Console.WriteLine(result + "\n");
            }



            //example 2:

            Console.Write("\n2---Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            bool isDivisible = (number % 5 == 0) && (number % 7 == 0);
            Console.WriteLine(isDivisible + "\n");



            //example 3:

            Console.Write("\n3---Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            bool check = (num % 7 == 0 && num % 5 == 0);

            if (check)
            {
                Console.WriteLine("Devisible by 7 and 5.\n");
            }
            else
            {
                Console.WriteLine("Not devisible by 7 and 5.\n");
            }



            //example 4:

            //Start:
            int Num = 0;
            while (true) //and it's always true = infinite loop
            {
                try // = if input is valid, (body execute)
                {
                    Console.Write("\n4---Enter a number(int): ");
                    Num = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception) // = else if input is invalid, (body execute), same as goto:...for restart input, if input is wrong.
                {
                    Console.WriteLine("Invalid input number!\n");
                    //goto Start;
                }
            }
            //if all is OK, give resul calculation!
            bool calculation = ((Num % 5 == 0) && (Num % 7 == 0));
            Console.WriteLine("Divisible by 7 and 5 without remainder: " + calculation + "\n");



            //example 5:

            Console.Write("\n5---Enter a number: ");
            int Number;

            while (!(int.TryParse(Console.ReadLine(), out Number))) //if u enter a number with reminder, it repeats until u enter an int...
            {
                Console.Write("Enter a number without reminder: ");
            }

            if ((Number % 5 == 0) && (Number % 7 == 0))
            {
                Console.WriteLine("The number can be divided by 7 and 5 without reminder.");
            }
            else
            {
                Console.WriteLine("The number can not be divided by 7 and 5 without reminder.");
            }
            


            //example 6:

            Console.Write("\n6---Enter Number: ");
            int numbToCheck = Int32.Parse(Console.ReadLine());

            Console.WriteLine(
                               ((numbToCheck % 5 == 0) && (numbToCheck % 7 == 0)) //both give True or False as answer of the calculation
                       + "\n");
        }
    }
}