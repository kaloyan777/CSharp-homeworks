using System;

namespace _03.Company_Software
{
    class Program
    {
        static void Main(string[] args)
        {
            //name, address, phone number, fax number, web site and manager. 
            //The manager has first name, last name, age and a phone number. 

            Console.Write("Enter FullName: ");
                string fullName = Convert.ToString(Console.ReadLine());
            Console.Write("Enter Address: ");
                string address = Convert.ToString(Console.ReadLine());
            Console.Write("Enter Phone Number & Fax: ");
                string phoneNum = Convert.ToString(Console.ReadLine());
            Console.Write("Enter Web address: ");
                string webAddress = Convert.ToString(Console.ReadLine());

                                       Console.ForegroundColor = ConsoleColor.Cyan;

            Console.Write("Enter Manager's First Name: ");
                string managerFirstName = Convert.ToString(Console.ReadLine());
            Console.Write("Enter Manager's Last Name: ");
                string managerLastName = Convert.ToString(Console.ReadLine());
            Console.Write("Enter Manager's Age: ");
                string managerAge = Convert.ToString(Console.ReadLine());
            Console.Write("Enter Manager's phone Number: ");
                string managerPhoneNum = Convert.ToString(Console.ReadLine());

                                       Console.ForegroundColor = ConsoleColor.White;
                                       Console.WriteLine(new String('-', 40));
                                       Console.WriteLine("\n>>  F I R M   D A T A:" + '\n');
 
            Console.WriteLine("- Company's Name: " + fullName + "\n- Company's address: " + address + "\n- Company's phone and Fax: " 
            + phoneNum + "\n- Company's web: " + webAddress + "\n> Manager: "+ managerFirstName + managerLastName + 
            "\n> Manager age: " + managerAge + "\n> Manager's phone Number: " + managerPhoneNum + '\n');
        }
    }
}
