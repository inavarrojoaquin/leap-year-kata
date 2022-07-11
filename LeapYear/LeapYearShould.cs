using NUnit.Framework;

namespace LeapYear
{
    public class LeapYearShould
    {
        private LeapYear leapYear;

        [SetUp]
        public void Setup()
        {
            leapYear = new LeapYear();
        }

        [TestCase(1996)]
        [TestCase(2012)]
        [TestCase(2020)]
        public void BeDivisibleByFour(int year)
        {
            Assert.IsTrue(leapYear.Execute(year));
        }

        [TestCase(1997)]
        [TestCase(1999)]
        [TestCase(2001)]
        public void NotBeDivisibleByFour(int year)
        {
            Assert.IsFalse(leapYear.Execute(year));
        }

        [TestCase(1600)]
        [TestCase(2000)]
        [TestCase(2400)]
        public void BeDivisibleByFourHundred(int year)
        {
            Assert.IsTrue(leapYear.Execute(year));
        }

        [TestCase(1800)]
        [TestCase(1900)]
        [TestCase(2100)]
        [TestCase(2200)]
        [TestCase(2300)]
        public void BeDivisibleByFourHundredByOneHundredButNotByFourHundred(int year)
        {
            Assert.IsFalse(leapYear.Execute(year));
        }
    }
}