using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeAfter10Years
{
    class AgeAfter10Years
    {
        static void Main(string[] args)
        {
            Console.Write("ur age: ");
            int age = int.Parse(Console.ReadLine());

            if (age <= 0)
            {
                Console.WriteLine("So, u are either dead, or new born?! :O \nWhisch means, after 10 years, you will be either rotten, or 10 years old!");
            }
            else
            {
                int ageAfter = age + 10;
                Console.WriteLine("Ur age after 10 years: " + ageAfter);
            }
        }
    }
}
