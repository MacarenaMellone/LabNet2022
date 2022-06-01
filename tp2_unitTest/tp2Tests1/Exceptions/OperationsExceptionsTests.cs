using Microsoft.VisualStudio.TestTools.UnitTesting;
using tp2.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp2.Exceptions.Tests
{
    [TestClass()]
    public class OperationsExceptionsTests
    {
        [TestMethod()]
        public void OperacionExceptionTest()
        {
            int valor1 = 50;
            int valor2 = 5;

            OperationsExceptions.OperacionException(valor1, valor2, true);

            Assert.IsTrue(true);
        }
        [TestMethod()]
        [ExpectedException(typeof(DivideByZeroException))]
        public void OperacionExceptionTest_DivideByZeroException()
        {
            int valor1 = 50;
            int valor2 = 0;

            OperationsExceptions.OperacionException(valor1, valor2, true);

        }

        [TestMethod()]
        public void ComparationTest()
        {
            int valor1 = 50;
            int valor2 = 25;

            OperationsExceptions.OperacionException(valor1, valor2, false);

            Assert.IsTrue(true);
        }
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void OperationsExceptions_ArgumentException()
        {
            int valor1 = 3;
            int valor2 = 25;

            OperationsExceptions.OperacionException(valor1, valor2, false);

        }
    }
}