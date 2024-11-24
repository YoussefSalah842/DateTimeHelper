using System;

namespace DateTimeHelper
{
    public static class DateValidation
    {
        // Validate if a date string matches a specific format
        public static bool IsValidDateFormat(string dateString, string format)
        {
            DateTime parsedDate;
            return DateTime.TryParseExact(dateString, format, null, System.Globalization.DateTimeStyles.None, out parsedDate);
        }

        // Check if a date is within a specific range
        public static bool IsDateWithinRange(DateTime date, DateTime minDate, DateTime maxDate)
        {
            return date >= minDate && date <= maxDate;
        }
    }
}
