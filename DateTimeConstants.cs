namespace DateTimeHelper
{
    public static class DateTimeConstants
    {
        public static readonly string ShortDateFormat = "MM/dd/yyyy";
        public static readonly string LongDateFormat = "dddd, MMMM dd, yyyy";
        public static readonly DateTime StartOfYear = new DateTime(DateTime.Now.Year, 1, 1);
        public static readonly DateTime EndOfYear = new DateTime(DateTime.Now.Year, 12, 31);
    }
}
