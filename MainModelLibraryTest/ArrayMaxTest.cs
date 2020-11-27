using MainModelLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MainModelLibraryTest
{
    [TestClass]
    public class ArrayMaxTest
    {
        [TestMethod]
        public void FindMax_PozitiveElements_Test()
        {
            //Arrange

            int[] array = { 4, 23, 3, 11, 8 };

            //Act

            int result = ArrayMax.FindMax(array);

            //Assert

            Assert.AreEqual(23, result);


        }

        [TestMethod]
        public void FindMax_NegativeElements_Test()
        {
            //Arrange

            int[] array = { -12, -45, -9, -20, -32 };

            //Act

            int result = ArrayMax.FindMax(array);

            //Assert

            Assert.AreEqual(-9, result);


        }
    }
}
