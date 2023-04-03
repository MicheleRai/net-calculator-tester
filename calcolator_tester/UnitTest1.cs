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
            Assert.That(Calculator.Add(a, b), Is.EqualTo(c));
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
            Assert.That(Calculator.Subtract(a, b), Is.EqualTo(c));
        }

        [Test]
        [TestCase(10, 2, 5)]
        [TestCase(-10, 2, -5)]
        [TestCase(10, -2, -5)]
        [TestCase(-10, -2, 5)]
        public void Divide(float a, float b, float c)
        {
            Assert.That(Calculator.Divide(a, b), Is.EqualTo(c));
        }

        [Test]
        [TestCase(10, 5, 20)]
        [TestCase(10, -5, -50)]
        [TestCase(-10, 5, -50)]
        [TestCase(-10, -5, 50)]
        [TestCase(10, 0, 0)]
        [TestCase(0, 10, 0)]
        [TestCase(0, 0, 0)]
        public void Multiply(float a, float b, float c)
        {
            Assert.That(Calculator.Multiply(a, b), Is.EqualTo(c));
        }
    }
}