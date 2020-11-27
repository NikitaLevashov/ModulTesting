using MainModelLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace MainModelLibraryTest
{
    [TestClass]
    public class FindSqrtTest
    {
        [TestMethod]
        public void FindSqrtValueTest()
        {
            //Arrange
            double input = 9;
            double expected = 3;

            //Act
            double actual = FindSqrt.GetSqrt(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
