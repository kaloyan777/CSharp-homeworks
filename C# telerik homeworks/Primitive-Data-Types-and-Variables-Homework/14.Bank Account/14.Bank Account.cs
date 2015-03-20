using System;

namespace _14.Bank_Account
{
    class Program
    {
        static void Main(string[] args)
        {
//////////..NAMES
            Console.Write("name: ");
            string firstName = Console.ReadLine();
            Console.Write("middle name: ");
            string middleName = Console.ReadLine();
            Console.Write("sure name: ");
            string lastName = Console.ReadLine();

            string holderName = firstName + " " + middleName + " " + lastName;
            Console.WriteLine(" - Holder Name: " + holderName);

            Console.WriteLine(); 

//////////..Balance Money
            Console.Write("Available amount: ");
            int balanceMoney = int.Parse(Console.ReadLine());

            Console.WriteLine();
            
//////////..Bank Name
            Console.Write("Bank Name: ");
            string bankName = Console.ReadLine();

            Console.WriteLine(); 

//////////..IBAN Code
            Console.Write("IBAN Code: ");
            string IBAN = Convert.ToString(Console.ReadLine());

            Console.WriteLine();

//////////..BIC
            Console.Write("BIC: ");
            string BIC = Convert.ToString(Console.ReadLine());

            Console.WriteLine();

//////////..Credit Card 1,2,3
            Console.WriteLine("Enter \"Card One\" Type and Number: "); //American Express 1234 123456 12345
                string cardOne = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter \"Card Two\" Type and Number: "); //Capital One 0000 1234 4321 1234 
                string cardTwo = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter \"Card Three\" Type and Number: "); //Chase Freedom 0, 123456
                string cardThree = Convert.ToString(Console.ReadLine());

            Console.Write(" - Card Names & Numbers: " + '\n' + cardOne + '\n' + cardTwo + '\n' + cardThree + '\n');
        }
    }
}
