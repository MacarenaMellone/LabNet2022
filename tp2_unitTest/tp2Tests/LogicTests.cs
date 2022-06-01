using Microsoft.VisualStudio.TestTools.UnitTesting;
using tp2;
using System;
using tp2.Exceptions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp2.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void ComparationTest()
        {
            int valor1 = 50;
            int valor2 = 25;

            Assert.IsTrue(valor1 >= valor2);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]      
        public void ComparationTest_MontoMenor()
        {
            var comparation = new Logic();  


        }
    }
}