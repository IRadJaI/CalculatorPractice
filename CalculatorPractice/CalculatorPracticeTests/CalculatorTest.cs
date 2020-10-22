using System;
using CalculatorPractice;
using NUnit.Framework;

//using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace CalculatorPracticeTests
{
    public class CalculatorTest
    {
        [Test]
        [TestCase("55","25",80)]
        [TestCase("55", "25", 85)]
        [TestCase("55", "", 80)]
        [TestCase("-100", "25", 80)]
        public void PlusTest(string a, string b, int expectedResult)
        {
            int result = Calculator.Plus(a, b);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
