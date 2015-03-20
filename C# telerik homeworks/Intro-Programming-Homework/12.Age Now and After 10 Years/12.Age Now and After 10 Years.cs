using System;

namespace _12.Age_Now_and_After_10_Years
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How young are you now?");
            int ageNow = int.Parse(Console.ReadLine());

            if(ageNow <= 0 || ageNow >= 200) //проверка за реална възраст
            {
                Console.WriteLine("That's Impossible! :O");
            }
            else
            {
            Console.WriteLine("Your age is: " + ageNow);
            Console.WriteLine("After 10 years You will be " + (ageNow + 10) + " years old!"); //(ageNow + 10) ползват се скоби, за да се получи мат. пресмятане, а не сливане на string променливи.
            }
            Console.WriteLine();
        }
    }
}
