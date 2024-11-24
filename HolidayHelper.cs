using System;
using System.Collections.Generic;

namespace DateTimeHelper
{
    public static class HolidayHelper
    {
        private static List<DateTime> publicHolidays = new List<DateTime>();

        // Check if a given date is a public holiday
        public static bool IsHoliday(DateTime date)
        {
            return publicHolidays.Contains(date.Date);
        }

        // Add a custom holiday
        public static void AddCustomHoliday(DateTime date, string holidayName)
        {
            publicHolidays.Add(date.Date);
            Console.WriteLine($"Added {holidayName} on {date.ToShortDateString()}");
        }

        // List public holidays for a given year
        public static List<DateTime> GetPublicHolidays(int year)
        {
            // Implement logic to fetch public holidays for the year.
            return new List<DateTime>();
        }
    }
}
