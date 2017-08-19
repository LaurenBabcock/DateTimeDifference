//Name: Lauren Babcock
//Date: August 19, 2017
//Purpose: Calcuate the difference in time between two dates entered by the user. Show the difference
//         in time in days, hours, and minutes.

using System;
namespace differenceBetweenDates
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date1, date2;
            int result;

            //Prompt the user to enter two dates
            Console.WriteLine("Please enter the first date in numeric format: ");
            date1 = GetDate();
            Console.WriteLine("Date is: " + date1.ToString());

            Console.WriteLine("Please enter the second date in numeric format: ");
            date2 = GetDate();
            Console.WriteLine("Date is: " + date2.ToString());

            //Compare the two dates to see which is later, and calculate the difference in time
            result = DateTime.Compare(date1, date2);
            if (result < 0)
            {
                //Date1 is earlier than date2
                TimeSpan timeDifference = date2 - date1;
                Console.WriteLine("Difference in days: " + timeDifference.Days);
                Console.WriteLine("Difference in hours: " + (timeDifference.Days * 24));
                Console.WriteLine("Difference in minutes: " + (timeDifference.Minutes * 1440));
            }
            else if (result == 0)
            {
                //Dates are the same
                Console.WriteLine("You have entered the same dates. There is no time difference.");
            }
            else
            {
                //Date1 is later than date2
                TimeSpan timeDifference = date1 - date2;
                Console.WriteLine("Difference in days: " + timeDifference.Days);
                Console.WriteLine("Difference in hours: " + (timeDifference.Days * 24));
                Console.WriteLine("Difference in minutes: " + (timeDifference.Days * 1440));
            }

            Console.ReadLine();
        }

        static DateTime GetDate()
        {
            int year, month, day;
            bool isValid = true;
            DateTime aDate;

            //Get the year
            Console.Write("Year: ");
            year = Convert.ToInt32(Console.ReadLine());

            //Get the month & check to make sure that it is valid
            do
            {
                Console.Write("Month: ");
                month = Convert.ToInt32(Console.ReadLine());
                if (month > 12 || month < 1)
                {
                    isValid = false;
                    Console.WriteLine("Sorry, that is not a valid month (must be a number 1-12). Try again");
                }
                else
                {
                    isValid = true;
                }
            } while (isValid == false);

            //Get the day & check to make sure that it is valid
            do
            {
                Console.Write("Day: ");
                day = Convert.ToInt32(Console.ReadLine());
                if ((day > 31 || day < 1) && (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12))
                {
                    isValid = false;
                    Console.WriteLine("Sorry, that is not a valid day (must be a number 1-31 with the month you have selected). Try again");
                }
                else if ((day > 30 || day < 1) && (month == 4 || month == 6 || month == 9 || month == 11))
                {
                    isValid = false;
                    Console.WriteLine("Sorry, that is not a valid day (must be a number 1-30 with the month you have selected). Try again");
                }
                else if ((day > 28 || day < 1) && (month == 2))
                {
                    isValid = false;
                    Console.WriteLine("Sorry, that is not a valid day (must be a number 1-28 with the month you have selected). Try again");
                }
                else
                {
                    isValid = true;
                }
            } while (isValid == false);

            aDate = new DateTime(year, month, day);
            
            return aDate;
        }
    }
}
