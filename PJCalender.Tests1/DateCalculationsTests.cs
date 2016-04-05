using NUnit.Framework;
using PJCalender;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJCalender.Tests
{
    [TestFixture()]
    public class DateCalculationsTests
    {
        [Test()]
        public void monthDayNumberTest()
        {
            DateTime leapyearFeb = new DateTime(2016, 02, 01);
            DateTime Jan = new DateTime(2017, 02, 01);
            DateTime Feb = new DateTime(2017, 02, 01);
            DateTime Mar = new DateTime(2017, 02, 01);
            DateTime Apr = new DateTime(2017, 02, 01);
            DateTime May = new DateTime(2017, 02, 01);
            DateTime Jun = new DateTime(2017, 02, 01);
            DateTime July = new DateTime(2017, 02, 01);
            DateTime Aug = new DateTime(2017, 02, 01);
            DateTime Sept = new DateTime(2017, 02, 01);
            DateTime Oct = new DateTime(2017, 02, 01);
            DateTime Nov = new DateTime(2017, 02, 01);
            DateTime Dec = new DateTime(2017, 02, 01);
            int i = PJCalender.DateCalculations.monthDayNumber(leapyearFeb);
            Assert.AreEqual(29, i);
        }

        [Test()]
        public void monthDayNumberTest1()
        {
            throw new NotImplementedException();
        }

        [Test()]
        public void monthValueTest()
        {
            throw new NotImplementedException();
        }
    }
}