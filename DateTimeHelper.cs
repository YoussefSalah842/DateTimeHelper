using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DateTimeHelper
{
    public static class DateHelper
    {
        
        public static string FormatDate(DateTime date, string format = "dd-MM-yyyy")
        {
            return date.ToString(format);
        }

        
        public static DateTime AddDays(DateTime date, int days)
        {
            return date.AddDays(days);
        }

        
        public static DateTime SubtractDays(DateTime date, int days)
        {
            return date.AddDays(-days);
        }

        
        public static int GetDaysDifference(DateTime date1, DateTime date2)
        {
            return (date2 - date1).Days;
        }

        
        public static bool IsValidDate(string dateString, string format = "dd-MM-yyyy")
        {
            DateTime parsedDate;
            return DateTime.TryParseExact(dateString, format, null, System.Globalization.DateTimeStyles.None, out parsedDate);
        }

        
        public static DateTime GetCurrentDateTime()
        {
            return DateTime.Now;
        }
    }
}