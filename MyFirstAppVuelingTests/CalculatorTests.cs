using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
namespace MyFirstAppVueling.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void AddTest()
        {
            Calculator calculator = new Calculator();
            IsTrue(calculator.Add(2, 3) == 5);
            //Assert.Fail();
        }

        [TestMethod()]
        public void SubtractTest()
        {
            Calculator calculator = new Calculator();
            IsTrue(calculator.Subtract(4, 2) == 2);
            //Assert.Fail();
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            Calculator calculator = new Calculator();
            IsTrue(calculator.Multiply(4, 2) == 8);
            //Assert.Fail();
        }

        [TestMethod()]
        public void DivideTest()
        {
            Calculator calculator = new Calculator();
            IsTrue(calculator.Subtract(4, 2) == 2);
            //Assert.Fail();
        }
    }
}