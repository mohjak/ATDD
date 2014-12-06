using FakeItEasy;
using MyMath;
using NUnit.Framework;

namespace MyMathTest
{
    [TestFixture]
    public class CalculatorMocking
    {
        [Test]
        public void To_Understand_Mocking()
        {
            var calc = A.Fake<ICalculator>();
            var nothing = A.Fake<INothing>();

            A.CallTo(() => calc.Fact(5) ).Returns(120);
            A.CallTo(() => nothing.AyShey(5)).Returns("nothing");
            Assert.AreEqual(120, calc.Fact(5));
            Assert.AreEqual("nothing",nothing.AyShey(5));
        }

        public interface INothing
        {
            string AyShey(int x);
        }
    }
}
