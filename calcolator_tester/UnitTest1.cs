using Calculator;
using NUnit.Framework;

namespace calcolator_tester
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        [TestCase(10, 5, 15)]
        [TestCase(-10, -5, -15)]
        [TestCase(-10, 5, -5)]
        [TestCase(10, -5, 5)]
        [TestCase(0, 5, 5)]
        [TestCase(0, 0, 0)]
        public void Add(float a, float b, float c)
        {
            Assert.That(Calc.Add(a, b), Is.EqualTo(c));
        }

        [Test]
        [TestCase(10, 5, 5)]
        [TestCase(-10, -5, -5)]
        [TestCase(-10, 5, -15)]
        [TestCase(10, -5, 15)]
        [TestCase(0, 5, -5)]
        [TestCase(0, 0, 0)]
        public void Subtract(float a, float b, float c)
        {
            Assert.That(Calc.Subtract(a, b), Is.EqualTo(c));
        }

        [Test]
        [TestCase(10, 2, 5)]
        [TestCase(-10, 2, -5)]
        [TestCase(10, -2, -5)]
        [TestCase(-10, -2, 5)]
        public void Divide(float a, float b, float c)
        {
            Assert.That(Calc.Divide(a, b), Is.EqualTo(c));
        }

        [Test]
        [TestCase(0)]
        [TestCase(10)]
        [TestCase(-10)]
        public void DivideByZero(float a)
        {
            if (a == 0)
            {
                Assert.That(Calc.Divide(a, 0), Is.EqualTo(float.NaN));
            }
            else if (a > 0)
            {
                Assert.That(Calc.Divide(a, 0), Is.EqualTo(float.PositiveInfinity));

            }
            else
            {
                Assert.That(Calc.Divide(a, 0), Is.EqualTo(float.NegativeInfinity));

            }
        }

        [Test]
        [TestCase(10, 5, 50)]
        [TestCase(10, -5, -50)]
        [TestCase(-10, 5, -50)]
        [TestCase(-10, -5, 50)]
        [TestCase(10, 0, 0)]
        [TestCase(0, 10, 0)]
        [TestCase(0, 0, 0)]
        public void Multiply(float a, float b, float c)
        {
            Assert.That(Calc.Multiply(a, b), Is.EqualTo(c));
        }
    }
}