using System;

namespace DateTimeHelper
{
    public static class TimeZoneHelper
    {
        // Get the current time in a specific time zone
        public static DateTime GetCurrentTimeZoneTime(string timeZoneId)
        {
            TimeZoneInfo timeZone = TimeZoneInfo.FindSystemTimeZoneById(timeZoneId);
            return TimeZoneInfo.ConvertTime(DateTime.UtcNow, timeZone);
        }

        // List all available time zones
        public static string[] ListAllTimeZones()
        {
            return TimeZoneInfo.GetSystemTimeZones().Select(tz => tz.Id).ToArray();
        }
    }
}
