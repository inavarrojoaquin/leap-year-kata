using System;

namespace LeapYear
{
    public class Year
    {
        private int year;

        public Year(int year)
        {
            this.year = year;
        }

        public bool IsLeapYear()
        {
            return DivisibleBy(4) && !(DivisibleBy(100) && NotDivisibleBy(400));
        }

        private bool NotDivisibleBy(int number)
        {
            return year % number != 0;
        }

        private bool DivisibleBy(int number)
        {
            return year % number == 0;
        }
    }
}
