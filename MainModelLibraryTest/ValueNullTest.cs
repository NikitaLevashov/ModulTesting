using MainModelLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace MainModelLibraryTest
{
   
    [TestClass]
    class ValueNullTest
    {
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void Find_NullValue_ExcpectedException()
        {
            string s = null;

            string actual = ValueNull.MethodFindNull(s);
        }

    }
}
