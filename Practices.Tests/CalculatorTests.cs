using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void AdditionalMustReturnCorrectValue()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Additional(10, 5) == 15);
        }
        [Test]
        public void SubstractionMustCorerectValue()
        {
            var calculator = new Calculator();
            Assert.True(calculator.Subtraction(10, 5) == 5);
        }
        [Test]
        public void MultiplicationReturnCorrectValue()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Miltiplication(10, 5) == 50);
        }
        [Test]
        public void DivisionMustReturnCorrectValue()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Division(10, 5) == 2);
        }
        [Test]
        public void DivisionMustThrowException()
        {
            var calculator = new Calculator();
            Assert.Throws<DivideByZeroException>(() => calculator.Division(10, 5));
        }
    }
}
