using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Software.SuperCalculator;

namespace UnitTestProject1
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void Add()
        {
            Calculator calculator = new Calculator();
            int result = calculator.Add(2,2);
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void AddWithDiferentArguments()
        {
            Calculator calculator = new Calculator();
            int result = calculator.Add(2,5);
            Assert.AreEqual(7, result);
        }
    }
}
