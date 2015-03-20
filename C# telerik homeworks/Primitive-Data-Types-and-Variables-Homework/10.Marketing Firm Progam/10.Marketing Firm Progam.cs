using System;

namespace _10.Marketing_Firm_Progam
{
    class Program
    {
        static void Main(string[] args)
        {
            //"Beep" sound = Job well Done!
            //"Error" sound = Repeat Action!
            //6x"Beep" sound = "Summoning is Complete!" lol
          

//////////..NAMES
            Console.Write("Enter Person's 1st name: "); //Names can be strings and numbers.
            string firstName = Console.ReadLine();
            Console.Write("Enter Person's sec name: ");
            string secName = Console.ReadLine();
            Console.Write("Enter Person's sure name: ");
            string lastName = Console.ReadLine();

            Console.WriteLine("--------------------------------------------------------------------------");
            Console.Beep(); //beep

            
//////////..AGE
            Console.Write("Enter person's age (using numbers): "); //Age can't be a string.
            string age = Console.ReadLine();
            int ageInt = int.Parse(age);

            Console.WriteLine("--------------------------------------------------------------------------");
            Console.Beep();


//////////..GENDER
            Console.Write("Enter person's gender (m/f): "); //Gender can't be a number.
            string gender = Console.ReadLine();
            char genderChar = char.Parse(gender);

            Console.WriteLine("--------------------------------------------------------------------------");
            Console.Beep();


//////////..ID
            Console.Write("Enter person's IDnumber (10 digits max): "); //ID must be 10 digits.
            string ID = Console.ReadLine();
            int idNumber = int.Parse(ID);                               //ID can't be a string.
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.Beep();

            //An option to correct ID number, if it's not 10 digits.
            while (ID.Length != 10) 
            {
                Console.Write('\a');
                Console.Write("Please, enter min/max 10 digits: ");
                ID = Console.ReadLine();
                Console.WriteLine("--------------------------------------------------------------------------");
                Console.Beep();
            }


//////////..Unique Employee Number (UEN) 
            Console.Write("Enter person's Unique Employee Number: "); //UEN can't be a string.
            string UEN = Console.ReadLine();
            int uniqueEN = int.Parse(UEN);
            Console.WriteLine();
            Console.Beep();

            //An option to correct UEN, if it's not between the two values.
     Start: if (uniqueEN >= 27560000 & uniqueEN <= 27569999)  //"Start Again using "goto", if ERROR in value appears!" 
            {
                Console.Beep(); //Summoning is Complete!
                Console.Beep();
                Console.Beep();
                Console.Beep();
                Console.Beep();
                Console.Beep(5000, 200); 

                Console.WriteLine('\n' + "=========================>>Person's Data Info<<===========================" + '\n');
                Console.WriteLine("- NAME: " + firstName + " " + secName + " " + lastName);
                Console.WriteLine("- AGE: " + ageInt);
                Console.WriteLine("- GENDER: " + genderChar);
                Console.WriteLine("- ID: " + idNumber);
                Console.WriteLine("- UEN: " + uniqueEN + '\n');
            }
            else
            {
                Console.WriteLine('\a');
                Console.Write("Number must be between 27560000 and 27569999!: ");
                uniqueEN  = int.Parse(Console.ReadLine());
                Console.WriteLine();

                goto Start; //Returns to "Start", and repeats the cycle.
            }
        }
    }
}