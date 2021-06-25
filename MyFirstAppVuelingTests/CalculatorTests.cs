using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyFirstAppVueling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstAppVueling.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void AddTest()
        {
            Calculator calculator = new Calculator();
            Assert.IsTrue(calculator.Add(2, 3) == 5);
            //Assert.Fail();
        }

        [TestMethod()]
        public void SubtractTest()
        {
            Calculator calculator = new Calculator();
            Assert.IsTrue(calculator.Subtract(4, 2) == 2);
            //Assert.Fail();
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            Calculator calculator = new Calculator();
            Assert.IsTrue(calculator.Multiply(4, 2) == 8);
            //Assert.Fail();
        }

        [TestMethod()]
        public void DivideTest()
        {
            Calculator calculator = new Calculator();
            Assert.IsTrue(calculator.Subtract(4, 2) == 2);
            //Assert.Fail();
        }
    }
}