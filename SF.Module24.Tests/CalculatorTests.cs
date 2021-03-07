using System;
using NUnit.Framework;

namespace SF.Module24.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        private readonly Calculator calc = new Calculator();

        [Test]
        public void AdditionalMustReturnCorrectValue()
        {
            Assert.AreEqual(calc.Additional(20, 24), 44);
            Assert.AreEqual(calc.Additional(-5, 1), -4);

            Assert.AreNotEqual(calc.Additional(10, 4), 10);

            Assert.DoesNotThrow(() => calc.Additional(int.MaxValue, 5));
        }

        [Test]
        public void SubtractionMustReturnCorrectValue()
        {
            Assert.AreEqual(calc.Subtraction(20, 24), -4);
            Assert.AreEqual(calc.Subtraction(5, 1), 4);

            Assert.AreNotEqual(calc.Subtraction(10, 4), 5);

            Assert.DoesNotThrow(() => calc.Subtraction(int.MinValue, 5));
        }

        [Test]
        public void MultiplicationMustReturnCorrectValue()
        {
            Assert.AreEqual(calc.Multiplication(100, 5), 500);
            Assert.AreEqual(calc.Multiplication(346545, 0), 0);

            Assert.AreNotEqual(calc.Multiplication(345, 2356), 12);

            Assert.DoesNotThrow(() => calc.Multiplication(int.MinValue, int.MaxValue));
        }

        [Test]
        public void DivisionMustReturnCorrectValue()
        {
            Assert.AreEqual(calc.Division(90, 3), 30);
            Assert.AreEqual(calc.Division(0, int.MaxValue), 0);
            Assert.AreEqual(calc.Division(6, 4), 1);

            Assert.AreNotEqual(calc.Division(int.MaxValue, int.MinValue), 1);

            Assert.Throws(typeof(DivideByZeroException), () => calc.Division(5, 0));
        }
    }
}
