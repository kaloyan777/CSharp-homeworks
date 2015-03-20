using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Difference_between_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that enters two dates in format dd.MM.yyyy and returns the number of days between them. 

            //EXAMPLE 1: http://www.dotnetperls.com/timespan //Time Span (превод) Период от Време/Времево Измерване           

            string dateNow = Console.ReadLine(), //17.03.2014
            dateNextWeek = Console.ReadLine();   //30.04.2014

            //convert from string to date
            DateTime date1 = DateTime.Parse(dateNow),
            date2 = DateTime.Parse(dateNextWeek);

            //TimeSpan 
            TimeSpan result = date2 - date1;
            Console.WriteLine(result);

            //44



            //EXAMPLE 2: http://www.dotnetperls.com/datetime-elapsed 

            //Initialize a date in the past.
            string pastDate = "03-03-2008";  //This is March 3, 2008.

            // 1. Parse the date and put in DateTime object.
            //    Convert the string to a Date.
            DateTime startDate = DateTime.Parse(pastDate);
            Console.WriteLine("Past Date: " + startDate);

            // 2. Get the current DateTime.
            DateTime now = DateTime.Now;
            Console.WriteLine("Date now: " + now);

            // 3. Get the TimeSpan of the difference.
            TimeSpan elapsed = now.Subtract(startDate);

            // 4. Get number of days ago.
            double daysAgo = elapsed.TotalDays;
            Console.WriteLine("{0} was {1} days ago", startDate, daysAgo.ToString("0"));

            /*
              Output:
             
              Past Date: 3.3.2008 г. 0:00:00
              Date now: 13.7.2014 г. 16:34:29
              3.3.2008 г. 0:00:00 was 2324 days ago
             
             */



            //EXAMPLE 3:

            //static void Main(string[] args)
            //{
            DateTime firstDate = DateTime.Parse(Console.ReadLine()),
                     secondDate = DateTime.Parse(Console.ReadLine());

            double resultOfDiff = DiffInDates(firstDate, secondDate);

            Console.WriteLine("Number of past days between the two dates: " + resultOfDiff);
        }

        private static double DiffInDates(DateTime first, DateTime second)
        {
            TimeSpan span = second - first;
            double result = span.TotalDays;

            return result;
        }
    }
}