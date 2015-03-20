using System;

namespace _2.Print_Company_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            //A company has name, address, phone number, fax number, web site and manager. 
            //The manager has first name, last name, age and a phone number. 
            //Write a program that reads the information about a company and its manager and prints it back on the console.

            Console.WriteLine(">=== Company_Info ===<");

            Console.Write("Company Name: ");
                string companyName = Console.ReadLine();

            Console.Write("Company Address: ");
                string companyAddress = Console.ReadLine();

            Console.Write("Company PhoneNum: ");
                string companyPhoneNum = Console.ReadLine();

            Console.Write("Fax: ");
                string companyFaxNum = Console.ReadLine();

            Console.Write("WebSite: ");
                string companyWebSite = Console.ReadLine();

            //...............Manager:

            Console.WriteLine(">= Manager =<");

            Console.Write("First and Last Name: ");
                string managerFullName = Console.ReadLine();

            Console.Write("Age: ");
                string managerAge = Console.ReadLine();

            Console.Write("Phone Num: ");
                string managerPhoneNum = Console.ReadLine();

            //............Sum of Info:

                System.Console.WriteLine("\n>>> COMPANY INFORMATION <<<\n" + companyName + "\nAddress: " + companyAddress + "\nPhone: " + companyPhoneNum + "\nFax: " + companyFaxNum + "\nWeb: " + companyWebSite 
                    + "\nManager: " + managerFullName + " \nAge: " + managerAge + "\nPhone: " + managerPhoneNum);

        }
    }
}
