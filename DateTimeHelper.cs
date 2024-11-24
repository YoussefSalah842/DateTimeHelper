using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace DateTimeHelper
{
    public static class DateHelper
    {
        // Format date to a specific string format
        public static string FormatDate(DateTime date, string format = "dd-MM-yyyy")
        {
            return date.ToString(format);
        }

        // Add or subtract days to a given date
        public static DateTime AddOrSubtractDays(DateTime date, int days)
        {
            return date.AddDays(days);
        }

        // Get the difference in days between two dates
        public static int GetDaysDifference(DateTime date1, DateTime date2)
        {
            return (date2 - date1).Days;
        }

        // Check if the given date string matches the format
        public static bool IsValidDate(string dateString, string format = "dd-MM-yyyy")
        {
            DateTime parsedDate;
            return DateTime.TryParseExact(dateString, format, null, DateTimeStyles.None, out parsedDate);
        }

        // Get the current date and time
        public static DateTime GetCurrentDateTime()
        {
            return DateTime.Now;
        }

        // Get the start and end date of the week for a given date (Monday to Sunday)
        public static (DateTime startOfWeek, DateTime endOfWeek) GetWeekRange(DateTime date)
        {
            var diff = date.DayOfWeek - DayOfWeek.Monday;
            if (diff < 0)
                diff += 7;

            var startOfWeek = date.AddDays(-diff).Date; // Monday
            var endOfWeek = startOfWeek.AddDays(6); // Sunday
            return (startOfWeek, endOfWeek);
        }

        // Add or subtract business days, skipping weekends
        public static DateTime AddBusinessDays(DateTime date, int businessDays)
        {
            int direction = businessDays > 0 ? 1 : -1;
            int daysAdded = 0;

            while (daysAdded != businessDays)
            {
                date = date.AddDays(direction);
                if (date.DayOfWeek != DayOfWeek.Saturday && date.DayOfWeek != DayOfWeek.Sunday)
                {
                    daysAdded++;
                }
            }

            return date;
        }

        // Validate if a date is within a specific range
        public static bool IsDateInRange(DateTime date, DateTime startDate, DateTime endDate)
        {
            return date >= startDate && date <= endDate;
        }

        // Convert DateTime to a specific time zone
        public static DateTime ConvertToTimeZone(DateTime dateTime, TimeZoneInfo timeZone)
        {
            return TimeZoneInfo.ConvertTime(dateTime, timeZone);
        }

        // Get the current date and time in a specific time zone
        public static DateTime GetCurrentDateTimeInTimeZone(TimeZoneInfo timeZone)
        {
            return TimeZoneInfo.ConvertTime(DateTime.Now, timeZone);
        }
    }
}
