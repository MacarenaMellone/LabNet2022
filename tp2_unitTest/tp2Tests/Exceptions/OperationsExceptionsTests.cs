using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using tp2.Exceptions;


namespace tp2.Exceptions.Tests
{
    [TestClass()]
    public class OperationsExceptionsTests
    {
        [TestMethod()]
        public void OperacionExceptionTest()
        {

            var calc = OperacionException(50, 6, true);
            var result = calc

            Assert.AreEqual(1, result);
        }

        [TestMethod()]
        [ExpectedException(typeof(DivideByZeroException))]
        public void ComparationTest_MontoMenor()
        {
            var comparation = new OperacionException();


        }
    }
}