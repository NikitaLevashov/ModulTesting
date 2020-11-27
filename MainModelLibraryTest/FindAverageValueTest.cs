using MainModelLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace MainModelLibraryTest
{
    [TestClass]
    public static class FindAverageValueTest
    {
        [TestMethod]
        public static void GetAverageElements_Test()
        {
            //Arrange
            int[] array = { 2, 5, 3 };

            //Act
            double result = FindAverageValue.GetAverage(array);

            //Assert
            Assert.AreEqual(3.33, result, 0.01);

        }
    }
}
