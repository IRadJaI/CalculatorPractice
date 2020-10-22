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
        [TestCase("55", "0", 55)]
        [TestCase("55", "", 80)]
        [TestCase("-100", "25", -75)]
        public void PlusTest(string a, string b, int expectedResult)
        {
            if (string.IsNullOrEmpty(b))
            {
                Assert.Throws(typeof(FormatException), () => Calculator.Plus(a, b), "Входная строка имела неверный формат.");
            }
            else
            {
                int result = Calculator.Plus(a, b);
                Assert.AreEqual(expectedResult, result);
            }
        }
    }
}
