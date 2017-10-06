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

        [Test]
        public void Add_ShouldReturnTheSumOfNumbers_WhenNumberStringContainsTwoNumbers()
        {
            Assert.AreEqual(3, _stringKataCalculator.Add("1,2,3"));
        }
    }
}
