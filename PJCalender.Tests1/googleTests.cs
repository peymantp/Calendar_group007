using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using PJCalender;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// arthor: Peyman Justin
/// </summary>
namespace PJCalender.Tests
{
    [TestFixture()]
    public class googleTests
    {
        /// <summary>
        /// Test/Scenario:
        ///     User tries to create event without login in
        ///     
        /// Expected Result
        ///     Exception in thrown
        /// </summary>
        [Test()]
        [ExpectedException(typeof(System.IO.DirectoryNotFoundException))]
        public void createEventNUllExceptionTest()
        {
            try {
                google.createEvent("a", "b", "c", new DateTime(1, 1, 1), new DateTime(2, 2, 2), new string[] { "a", "b" });
            } catch(Exception e)
            {
                NUnit.Framework.Assert.Pass(e.ToString());
            }
        }
        /// <summary>
        /// Test/Scenario:
        ///     reading local events
        ///     
        /// Expected Result
        /// 
        /// </summary>
        [Test()]
        public void readEventLocalNullPeram()
        {
            try {
                google.readEventLocal(null);
            }
            catch (System.NullReferenceException ex)
            {
                NUnit.Framework.Assert.Pass(ex.ToString());
            }
        }
    }
}