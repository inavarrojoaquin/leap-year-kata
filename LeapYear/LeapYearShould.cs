using NUnit.Framework;

namespace LeapYear
{
    public class LeapYearShould
    {
        [TestCase(1996)]
        [TestCase(2012)]
        [TestCase(2020)]
        public void BeALeapYearIfDivisibleBy4(int input)
        {
            Assert.IsTrue(LeapYear(input).IsLeapYear());
        }

        [TestCase(1997)]
        [TestCase(1999)]
        [TestCase(2001)]
        public void NotBeALeapYearIfDivisibleBy4(int input)
        {
            Assert.IsFalse(LeapYear(input).IsLeapYear());
        }

        [TestCase(1600)]
        [TestCase(2000)]
        [TestCase(2400)]
        public void BeALeapYearIfDivisibleBy400(int input)
        {
            Assert.IsTrue(LeapYear(input).IsLeapYear());
        }

        [TestCase(1800)]
        [TestCase(1900)]
        [TestCase(2100)]
        [TestCase(2200)]
        [TestCase(2300)]
        public void NotBeALeapYearIfDivisibleBy4By100ButNotBy400(int input)
        {
            Assert.IsFalse(LeapYear(input).IsLeapYear());
        }

        private static Year LeapYear(int input)
        {
            return new Year(input);
        }
    }
}