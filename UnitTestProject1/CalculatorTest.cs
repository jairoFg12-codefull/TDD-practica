using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Software.SuperCalculator;

namespace UnitTestProject1
{
    [TestClass]
    public class CalculatorTest
    {
        private Calculator _calculator;

        [TestInitialize]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        [TestMethod]
        public void Add()
        {
            int result = _calculator.Add(2,2);
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void AddWithDiferentArguments()
        {
            int result = _calculator.Add(2,5);
            Assert.AreEqual(7, result);
        }

        [TestMethod]
        public void Substract()
        {
            int result = _calculator.Substract(5, 3);
            Assert.AreEqual(2, result);
        }
    }
}
