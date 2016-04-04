// <copyright file="MenusTest.cs">Copyright ©  2016</copyright>
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using PJCalender;

namespace PJCalender.Tests
{
    /// <summary>This class contains parameterized unit tests for Menus</summary>
    [PexClass(typeof(Menus))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class MenusTest
    {
        [TestMethod]
        public void RunProgram()
        {
            
        }
    }
}
