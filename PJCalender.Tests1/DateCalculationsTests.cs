using NUnit.Framework;
using PJCalender;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJCalender.Tests
{
    /// <summary>
    /// test class for DataCalculations.cs
    /// </summary>
    [TestFixture()]
    public class DateCalculationsTests
    {
        /// <summary>
        /// Test/Scenario:
        ///     Input a dateTime object 
        ///     Format yyyy MM dd
        ///     
        /// Expected Result
        ///     returns the number of days in a month given a year and month
        /// </summary>
        [Test]
        public void monthDayNumberTest()
        {
            DateTime leapyearFeb = new DateTime(2016, 02, 01);
            DateTime Jan = new DateTime(2017, 01, 01);
            DateTime Feb = new DateTime(2017, 02, 01);
            DateTime Mar = new DateTime(2017, 03, 01);
            DateTime Apr = new DateTime(2017, 04, 01);
            DateTime May = new DateTime(2017, 05, 01);
            DateTime Jun = new DateTime(2017, 06, 01);
            DateTime July = new DateTime(2017, 07, 01);
            DateTime Aug = new DateTime(2017, 08, 01);
            DateTime Sept = new DateTime(2017, 09, 01);
            DateTime Oct = new DateTime(2017, 10, 01);
            DateTime Nov = new DateTime(2017, 11, 01);
            DateTime Dec = new DateTime(2017, 12, 01);

            Assert.AreEqual(29, PJCalender.DateCalculations.monthDayNumber(leapyearFeb));
            Assert.AreEqual(31, PJCalender.DateCalculations.monthDayNumber(Jan));
            Assert.AreEqual(28, PJCalender.DateCalculations.monthDayNumber(Feb));
            Assert.AreEqual(31, PJCalender.DateCalculations.monthDayNumber(Mar));
            Assert.AreEqual(30, PJCalender.DateCalculations.monthDayNumber(Apr));
            Assert.AreEqual(31, PJCalender.DateCalculations.monthDayNumber(May));
            Assert.AreEqual(30, PJCalender.DateCalculations.monthDayNumber(Jun));
            Assert.AreEqual(31, PJCalender.DateCalculations.monthDayNumber(July));
            Assert.AreEqual(31, PJCalender.DateCalculations.monthDayNumber(Aug));
            Assert.AreEqual(30, PJCalender.DateCalculations.monthDayNumber(Sept));
            Assert.AreEqual(31, PJCalender.DateCalculations.monthDayNumber(Oct));
            Assert.AreEqual(30, PJCalender.DateCalculations.monthDayNumber(Nov));
            Assert.AreEqual(31, PJCalender.DateCalculations.monthDayNumber(Dec));
        }
        /// <summary>
        /// Test/Scenario:
        ///     retuens given value based on DAteTime value
        ///     
        /// Expected Result
        ///     month value
        /// </summary>
        [Test()]
        public void monthValueTest()
        {
            DateTime leapyearFeb = new DateTime(2016, 02, 01);
            DateTime Jan = new DateTime(2017, 01, 01);
            DateTime Feb = new DateTime(2017, 02, 01);
            DateTime Mar = new DateTime(2017, 03, 01);
            DateTime Apr = new DateTime(2017, 04, 01);
            DateTime May = new DateTime(2017, 05, 01);
            DateTime Jun = new DateTime(2017, 06, 01);
            DateTime July = new DateTime(2017, 07, 01);
            DateTime Aug = new DateTime(2017, 08, 01);
            DateTime Sept = new DateTime(2017, 09, 01);
            DateTime Oct = new DateTime(2017, 10, 01);
            DateTime Nov = new DateTime(2017, 11, 01);
            DateTime Dec = new DateTime(2017, 12, 01);

            Assert.AreEqual(12, PJCalender.DateCalculations.monthValue(leapyearFeb));
            Assert.AreEqual(11, PJCalender.DateCalculations.monthValue(Jan));
            Assert.AreEqual(12, PJCalender.DateCalculations.monthValue(Feb));
            Assert.AreEqual(1, PJCalender.DateCalculations.monthValue(Mar));
            Assert.AreEqual(2, PJCalender.DateCalculations.monthValue(Apr));
            Assert.AreEqual(3, PJCalender.DateCalculations.monthValue(May));
            Assert.AreEqual(4, PJCalender.DateCalculations.monthValue(Jun));
            Assert.AreEqual(5, PJCalender.DateCalculations.monthValue(July));
            Assert.AreEqual(6, PJCalender.DateCalculations.monthValue(Aug));
            Assert.AreEqual(7, PJCalender.DateCalculations.monthValue(Sept));
            Assert.AreEqual(8, PJCalender.DateCalculations.monthValue(Oct));
            Assert.AreEqual(9, PJCalender.DateCalculations.monthValue(Nov));
            Assert.AreEqual(10, PJCalender.DateCalculations.monthValue(Dec));
        }
    }
}