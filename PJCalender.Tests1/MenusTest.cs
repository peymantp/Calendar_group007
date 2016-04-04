// <copyright file="MenusTest.cs">Copyright ©  2016</copyright>
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using NUnit.Framework;
using NUnit.Common;
using NUnit.Extensions.Forms;
using PJCalender;
using System.Windows.Forms;

namespace PJCalender.Tests
{
    /// <summary>This class contains parameterized unit tests for Menus</summary>
    [PexClass(typeof(Menus))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestFixture]
    public partial class MenusTest 
    {
        private Menus m;

        [SetUp]
        public void Setup()
        {
            m = new Menus();
            m.Show();
        }

        [Test]
        public void TestLoginText()
        {
            ButtonTester loginButton = new ButtonTester("buttonLog", m);
            Assert.AreEqual("Login", loginButton.Text);

        }

        [Test]
        public void TestLoginForm()
        {
            ButtonTester loginButton = new ButtonTester("buttonLog", m);
            loginButton.Click();
            var ff = new FormFinder().Find("Menus");
            Assert.AreEqual(true, ff.Visible);
        }

        [TearDown]
        public void TearDown()
        {
            m = null;
        }
    }
}
