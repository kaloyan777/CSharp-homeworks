using System;
using System.Globalization;

namespace _10.Beer_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            //A beer time is after 1:00 PM and before 3:00 AM.
            //Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12], 
            //a minute in range [00…59] and AM / PM designator) and prints “beer time” or “non-beer time” 
            //according to the definition above or “invalid time” if the time cannot be parsed.
            //Note that you may need to learn how to parse dates and times

            TryAgain:
            Hours:
            Console.Write("Hour: ");
            int hour = int.Parse(Console.ReadLine());

            if (hour >= 1 && hour <= 12)
            {
                if (hour >= 1 && hour <= 3)
                {
                    Minutes:
                    Console.Write("Minutes: ");
                    int minutes = int.Parse(Console.ReadLine());

                    if (minutes >= 0 && minutes <= 59)
                    {
                        Designator:
                        Console.Write("AM/PM: ");
                        string designator = Console.ReadLine();
                        designator = designator.ToUpper();

                        if (designator == "PM" || designator == "AM")
                        {
                            string hourMinutesDesignator = Convert.ToString(hour) + ":" + Convert.ToString(minutes);

                            DateTime beerTime = DateTime.Parse(hourMinutesDesignator);
                            Console.WriteLine("Beer Time = " + beerTime + " " + designator);
                        }
                        else
                        {
                            Console.WriteLine("invalid designator");
                            goto Designator;
                        }
                    }
                    else
                    {
                        Console.WriteLine("invalid minutes");
                        goto Minutes;
                    }
                }
                else
                {
                    Console.WriteLine("non-beer time");
                    goto TryAgain;
                }
            }
            else
            {
                Console.WriteLine("invalid hours");
                goto Hours;
            }




            //example 2:
            Console.WriteLine("\n---EXAMPLE 2---\n");

            TryHours:
            Console.Write("Hour: ");
            int hours = int.Parse(Console.ReadLine());

            switch (hours) // = if hours are from 1 - 3: 
            {
                case 1:
                case 2:
                case 3:

                    TryMinutes:
                    Console.Write("Minutes: ");
                    int minute = int.Parse(Console.ReadLine());
                    switch (minute) //then check if minutes are correct.
	                {
                        case 0:
                        case 1:
                        case 2:
                        case 3:
                        case 4:
                        case 5:
                        case 6:
                        case 7:
                        case 8:
                        case 9:
                        case 10:
                        case 11:
                        case 12:
                        case 13:
                        case 14:
                        case 15:
                        case 16:
                        case 17:
                        case 18:
                        case 19:
                        case 20:
                        case 21:
                        case 22:
                        case 23:
                        case 24:
                        case 25:
                        case 26:
                        case 27:
                        case 28:
                        case 29:
                        case 30:
                        case 31:
                        case 32:
                        case 33:
                        case 34:
                        case 35:
                        case 36:
                        case 37:
                        case 38:
                        case 39:
                        case 40:
                        case 41:
                        case 42:
                        case 43:
                        case 44:
                        case 45:
                        case 46:
                        case 47:
                        case 48:
                        case 49:
                        case 50:
                        case 51:
                        case 52:
                        case 53:
                        case 54:
                        case 55:
                        case 56:
                        case 57:
                        case 58:
                        case 59:

                            TryAMorPM:
                            Console.Write("PM/AM: ");
                            string amORpm = Convert.ToString(Console.ReadLine());
                            amORpm = amORpm.ToUpper();
                            switch (amORpm) // = if minutes are correct, then check if designator is correct
                            {
                                case "AM":
                                case "PM": 

                                    string hourMinutesAMorPM = Convert.ToString(hours) + ":" + Convert.ToString(minute);
                                    DateTime timeForBeer = DateTime.Parse(hourMinutesAMorPM);
                                    Console.WriteLine("Beer Time = " + timeForBeer + " " + amORpm);
                                    break;

                                default: goto TryAMorPM; //if designator is not correct, goto TryAMorPM:
                            }

                            break;
                        default: goto TryMinutes;  
	                }

                    break;

                case 4: //hours...
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                case 11:
                case 12: Console.WriteLine("Not beer time."); break;

                default: goto TryHours; //if hours is incorrect(1 < hours > 12), goto TryHours.
            }





            Console.WriteLine();
            //..............................Parsing DateTime.....................................:

            //SOME EXAMPLE 1:

            //string dateString = "Mon 16 Jun 8:30 AM 2008"; 
            //string format = "ddd dd MMM h:mm tt yyyy";

            //DateTime dateTime = DateTime.ParseExact(dateString, format,
            //    CultureInfo.InvariantCulture);
            //Console.WriteLine(dateTime);



            //SOME EXAMPLE 2:

            //string date = "2000-02-02";
            //DateTime time = DateTime.Parse(date);
            //Console.WriteLine(time);



            //SOME EXAMPLE 3:

            //string[] dateStrings = {"2008-05-01T07:34:42-5:00", 
            //                  "2008-05-01 7:34:42Z", 
            //                  "Thu, 01 May 2008 07:34:42 GMT"};
            //foreach (string dateString in dateStrings)
            //{
            //    DateTime convertedDate = DateTime.Parse(dateString);
            //    Console.WriteLine("Converted {0} to {1} time {2}",
            //                      dateString,
            //                      convertedDate.Kind.ToString(),
            //                      convertedDate);
            //}                              



            //SOME EXAMPLE 4:

            //string dateString = "16/02/2008 12:15:12";
            //DateTime dateValue;
            //try
            //{
            //    dateValue = DateTime.Parse(dateString);
            //    Console.WriteLine("'{0}' converted to {1}.", dateString, dateValue);
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Unable to convert '{0}'.", dateString);
            //}



            //SOME EXAMPLE 5:

            //// Define cultures to be used to parse dates.
            //CultureInfo[] cultures = {CultureInfo.CreateSpecificCulture("en-US"), 
            //                          CultureInfo.CreateSpecificCulture("fr-FR"), 
            //                          CultureInfo.CreateSpecificCulture("de-DE")};

            //// Define string representations of a date to be parsed. 
            //string[] dateStrings = {"01/10/2009 7:34 PM", "10.01.2009 19:34", "10-1-2009 19:34" };
            //DateTime dateValue;

            //// Parse dates using each culture. 
            //foreach (CultureInfo culture in cultures)
            //{
            //    Console.WriteLine("Attempted conversions using {0} culture.", culture.Name);
            //    foreach (string dateString in dateStrings)
            //    {
            //        try
            //        {
            //            dateValue = DateTime.Parse(dateString, culture);
            //            Console.WriteLine("   Converted '{0}' to {1}.", dateString, dateValue.ToString("f", culture));
            //        }
            //        catch (FormatException)
            //        {
            //            Console.WriteLine("   Unable to convert '{0}' for culture {1}.", dateString, culture.Name);
            //        }
            //    }
            //    Console.WriteLine();
            //}

            //// The example displays the following output to the console: 
            ////       Attempted conversions using en-US culture. 
            ////          Converted '01/10/2009 7:34 PM' to Saturday, January 10, 2009 7:34 PM. 
            ////          Converted '10.01.2009 19:34' to Thursday, October 01, 2009 7:34 PM. 
            ////          Converted '10-1-2009 19:34' to Thursday, October 01, 2009 7:34 PM. 
            ////        
            ////       Attempted conversions using fr-FR culture. 
            ////          Converted '01/10/2009 7:34 PM' to jeudi 1 octobre 2009 19:34. 
            ////          Converted '10.01.2009 19:34' to samedi 10 janvier 2009 19:34. 
            ////          Converted '10-1-2009 19:34' to samedi 10 janvier 2009 19:34. 
            ////        
            ////       Attempted conversions using de-DE culture. 
            ////          Converted '01/10/2009 7:34 PM' to Donnerstag, 1. Oktober 2009 19:34. 
            ////          Converted '10.01.2009 19:34' to Samstag, 10. Januar 2009 19:34. 
            ////          Converted '10-1-2009 19:34' to Samstag, 10. Januar 2009 19:34.



            //SOME EXAMPLE 6:

            //CultureInfo MyCultureInfo = new CultureInfo("de-DE");
            //string MyString = "12 Juni 2008";
            //DateTime MyDateTime = DateTime.Parse(MyString, MyCultureInfo);
            //Console.WriteLine(MyDateTime);

            //// The example displays the following output: 
            ////       6/12/2008 12:00:00 AM



            //SOME EXAMPLE 7:

            //Console.Write("Enter time: ");
            //DateTime dt = DateTime.Parse(Console.ReadLine());
            //Console.WriteLine(dt.ToString("hh:mm tt"));
        }
    }
}