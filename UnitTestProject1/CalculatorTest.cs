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
            _calculator = new Calculator(-10, 100);
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

        [TestMethod]
        public void SubstractReturningNegative()
        {
            int result = _calculator.Substract(3, 5);
            Assert.AreEqual(-2, result);
        }

        [TestMethod]
        public void SubstractSettingLimitValues()
        {
            Calculator calculator = new Calculator(-100, 100);
            int result = calculator.Substract(5,10);
            Assert.AreEqual(-5, result);
        }

        [TestMethod]
        public void SubstractExcedingLowerLimit()
        {
            Calculator calculator = new Calculator(-100, 100);
            try
            {
                int result = calculator.Substract(10, 150);
                Assert.Fail("Exception_is_not_being_thrown_when_" + "exceeding_lower_limit");
            }
            catch (OverflowException)
            {
                // Ok, the SUT works as expected
            }
        }
    }
}
