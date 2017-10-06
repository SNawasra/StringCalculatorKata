using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringKataCalculator.Tests
{
    public class StringKataCalculatorTests
    {
        private StringKataCalculator _stringKataCalculator;
        public StringKataCalculatorTests()
        {
            _stringKataCalculator = new StringKataCalculator();
        }

        [Test]
        public void Add_ShouldReturnZero_WhenStringNumbersIsEmpty()
        {
            Assert.AreEqual(0, _stringKataCalculator.Add(""));
        }

        [Test]
        public void Add_ShouldReturnTheNumber_WhenStringNumbersContainsSingleNumber()
        {
            Assert.AreEqual(1, _stringKataCalculator.Add("1"));
        }

        [TestCase("1,2", 3)]
        [TestCase("1,2,3", 6)]
        [TestCase("1,2,3,4,5,6", 21)]
        [TestCase("1,2,3,4,5,6,9", 30)]
        public void Add_ShouldReturnTheSumOfNumbers_WhenNumberStringContainsMultipleNumbers(string numbers, int result)
        {
            Assert.AreEqual(result, _stringKataCalculator.Add(numbers));
        }

        [Test]
        public void Add_ShouldReturnsTheSumOfNumbers_WhenStringNumbersContainsNewLineDelimiter()
        {
            Assert.AreEqual(6, _stringKataCalculator.Add("1\n2,3"));
        }

        [Test]
        public void Add_ShouldReturnZero_WhenStringNumbersEqualsNewLineDelimiter()
        {
            Assert.AreEqual(0, _stringKataCalculator.Add("\n"));
        }
    }
}
