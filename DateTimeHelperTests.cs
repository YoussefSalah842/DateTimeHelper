using System;
using NUnit.Framework;

namespace DateTimeHelper.Tests
{
    public class DateHelperTests
    {
        [Test]
        public void TestAddBusinessDays()
        {
            DateTime startDate = new DateTime(2024, 11, 24); // Sunday
            DateTime expectedDate = new DateTime(2024, 12, 05); // 10 business days later

            DateTime result = DateHelper.AddBusinessDays(startDate, 10);
            Assert.AreEqual(expectedDate, result);
        }

        [Test]
        public void TestGetStartOfDay()
        {
            DateTime testDate = new DateTime(2024, 11, 24, 14, 30, 00);
            DateTime expectedStart = new DateTime(2024, 11, 24, 00, 00, 00);

            DateTime result = testDate.GetStartOfDay();
            Assert.AreEqual(expectedStart, result);
        }
    }
}
