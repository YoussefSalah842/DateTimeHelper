using System;

namespace DateTimeHelper
{
    public static class DateTimeExtensions
    {
        // Get the start of the day (midnight) for a given DateTime
        public static DateTime GetStartOfDay(this DateTime date)
        {
            return date.Date;
        }

        // Get the end of the day (11:59:59.999) for a given DateTime
        public static DateTime GetEndOfDay(this DateTime date)
        {
            return date.Date.AddDays(1).AddTicks(-1);
        }

        // Add business days to a DateTime (skipping weekends)
        public static DateTime AddBusinessDays(this DateTime date, int businessDays)
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
    }
}
