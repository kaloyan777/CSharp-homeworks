using System;

namespace _5.Third_Digit_is_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write an expression that checks for given integer if its third digit from right-to-left is 7

            //example 1:
            Console.WriteLine("---EXAMPLE 1---");

            int a = 1703;
            int b = a / 100; //pri delene na 100, polu4avame 17.03, no poneje b e int, toi ne moje da suhrani stoinost s plava6ta zapetaq i suhranqva do 17!!
            int c = b % 10;  //delim 17 na 10, rezultata e 1 s ostatuk 7, c pridobiva stoinost na ostatuka, ne na celiq rezultat!! 

            Console.WriteLine("The number to check is: " + a);
            if (c == 7) //proverka dali rezultata = 7
            {
                Console.WriteLine("Third digit from right to left is 7.");
            }
            else
            {
                Console.WriteLine("Third digit from right to lefft is not 7.");
            }



            //example 2:
            Console.WriteLine("\n---EXAMPLE 2---");

            Console.Write("Enter int number(3 digits): ");
            int numberToCheck = int.Parse(Console.ReadLine());

            bool thirdDigitSeven;

            int temporaryCalculation = numberToCheck / 100;

            if (temporaryCalculation % 10 == 7) //proverka s true i false;
            {
                thirdDigitSeven = true;
            }
            else
            {
                thirdDigitSeven = false;
            }
            Console.WriteLine(thirdDigitSeven);



            //example 3:
            Console.WriteLine("\n---EXAMPLE 3---");

            Console.Write("Enter an integer number: ");
            numberToCheck = int.Parse(Console.ReadLine());

            try
            {
                if (Math.Abs(numberToCheck) < 100) //Math.Abs(gives the absolute value of the number)
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Enter a 3 digited integer.");
            }

            for (int i = 0; i < 2; i++) 
            {
                numberToCheck = numberToCheck / 10;
            }

            int reminder = Math.Abs(numberToCheck % 10); //reminder durji ostatuka ot delenieto na 10
            bool resultIfSeven = (reminder == 7); //ako ostatuka e 7, isSeven = true;

            Console.WriteLine("The third digit from right to left is 7, right? \n- " + resultIfSeven);



            //example 4:
            Console.WriteLine("\n---EXAMPLE 4---");

            int N = 1732;
            if (N % 1000 <= 799 && N % 1000 >= 700)
            {
                Console.WriteLine("The third digit of the given integer is 7.");
            }
            else
            {
                Console.WriteLine("The third digit of the given integer is not a 7.");
            }



            //example 5:
            Console.WriteLine("\n---EXAMPLE 5---");

            Console.Write("Write number to check: ");
            long number; 
                long.TryParse(Console.ReadLine(), out number);

            //Now the third digit becomes last.
            number = (long)number / 100;

            // if the (number - 2 )  now can be divided by 5 and can not be divided by 10, this number ends with 7
            if (((number - 2) % 10 != 0) && ((number - 2) % 5 == 0))
            {
                Console.WriteLine("The third digit is 7.");
            }
            else
            {
                Console.WriteLine("The third digit is not 7.");
            }



            //example 6:
            Console.WriteLine("\n---EXAMPLE 6---");

            Console.Write("Enter 3 digited number: ");
            int numberForCheck = int.Parse(Console.ReadLine());

            int seven = 7;

            //(- numberForCheck) - because the number could be negative
            bool isWantedThirdDigit = 
                (
                    ((+ numberForCheck / 100) % 10 == seven)
                      || 
                    ((- numberForCheck / 100) % 10 == seven)
                ); 
            Console.WriteLine(isWantedThirdDigit + "\n");           



            //example 7:
            Console.WriteLine("\n---EXAMPLE 7---");

            int Num = 12703;
            Console.WriteLine(Num);

            bool isSeven = ((Num / 100) % 10) == 7; //True
            Console.WriteLine(isSeven);
        }
    }
}