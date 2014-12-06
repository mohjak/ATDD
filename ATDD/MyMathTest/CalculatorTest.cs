using System;
using MyMath;
using NUnit.Framework;

namespace MyMathTest
{
    [TestFixture]
    public class CalculatorTest
    {
        [Test]
        [TestCase(0, 1)]
        [TestCase(1, 1)]
        [TestCase(2, 2)]
        [TestCase(3, 6)]
        [TestCase(4, 24)]
        [TestCase(5, 120)]
        [TestCase(6, 720)]

        public void Should_Return_Factorial_Of_N(int number, long result)
        {
            var sut = new Calculator();
            Assert.AreEqual(result, sut.Fact(number));
        }

        [Test]
        public void Should_Throw_InvalidOperationException()
        {
            var sut = new Calculator();
            Assert.Throws<InvalidOperationException>(() => sut.Fact(-1), string.Format("Exception not thrown"));
        }
    }
}
