using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJCalender
{
    /// <summary>
    /// arthor: Peyman Justin
    /// </summary>
    static class DateCalculations
    {
        /// <summary>
        /// Returns the number of days in a month sent to the function
        /// </summary>
        /// <param name="date">A date containing a month</param>
        /// <returns>number of days in a month</returns>
        static public int monthDayNumber(DateTime date)
        {
            switch (date.Month)
            {
                case 1: //January
                    return 31;
                case 2: // February
                    if (DateTime.IsLeapYear(date.Year))
                        return 29;
                    return 28;
                case 3:     //March
                    return 31;
                case 4:     //April
                    return 30;
                case 5:     //May
                    return 31;
                case 6:     //June
                    return 30;
                case 7:     //July
                    return 31;
                case 8:     //August
                    return 31;
                case 9:     //September
                    return 30;
                case 10:    //October
                    return 31;
                case 11:    //November
                    return 30;
                case 12:    //December
                    return 31;
            }
            return 0;
        }

        static public int monthValue(DateTime date)
        {
            switch (date.Month)
            {
                case 1: //January
                    return 11;
                case 2: // February
                    return 12;
                case 3:     //March
                    return 1;
                case 4:     //April
                    return 2;
                case 5:     //May
                    return 3;
                case 6:     //June
                    return 4;
                case 7:     //July
                    return 5;
                case 8:     //August
                    return 6;
                case 9:     //September
                    return 7;
                case 10:    //October
                    return 8;
                case 11:    //November
                    return 9;
                case 12:    //December
                    return 10;
            }
            return 0;
        }
        /// <summary>
        /// From: https://cs.uwaterloo.ca/~alopez-o/math-faq/node73.html
        /// Calculates the week day for the selected day 
        /// 0 = Sunday, ..., 6 = Saturday
        /// </summary>
        /// <param name="date"></param>
        /// <returns>The week day</returns>
        static public int dateOfWeek(DateTime date)
        {
            int century = date.Year / 100;
            int month = monthValue(date);
            int year = date.Year % 100;
            if (month > 10)
                ++year;
            return (int)(Math.Abs( 1 + Math.Floor(2.6*month-0.2) - 2*century + 
                year + Math.Floor(year / 4.0) + Math.Floor(century / 4.0)) % 7);
        }
    }
}
