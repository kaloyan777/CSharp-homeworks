using System;


namespace _01.Examines_Two_Integers
{
    class Examines_Two_Integers
    {
        static void Main(string[] args)
        {
            //Write an if statement that examines two integer variables and exchanges their values if the first one is greater 
            //than the second one.

            Console.Write("Int 1st: ");
                int firstInt = int.Parse(Console.ReadLine());
            Console.Write("Int 2nd: ");
                int secondInt = int.Parse(Console.ReadLine());

            //Using temporary, to contain and modify the value of the two integers, so to exchange their values, разбий'ши?
            int temporary = 0;  

                if (firstInt > secondInt)
                {
                    temporary = secondInt; //...Абе, игра на думи, кво'а ти кажа поече! ;P
                    secondInt = firstInt;
                    firstInt = temporary;
                }
                Console.WriteLine("- First int = {0}, Second int = {1}",firstInt, secondInt);
        }
    }
}
