using CCMEngine;
using NUnit.Framework;
using System;

namespace CCMTests.MetricTests
{
    [TestFixture]
    public class AggregateComplexityShould
    {
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        [TestCase(5)]
        [TestCase(6)]
        [TestCase(7)]
        [TestCase(8)]
        [TestCase(9)]
        public void Be0WhenCyclomaticComplexityIs0To9(int cyclomaticComplexity)
        {
            const int expected = 0;

            ccMetric metric = new ccMetric(null, null, cyclomaticComplexity);

            Assert.AreEqual(expected, metric.AggregateComplexity);
        }

        [TestCase(10)]
        [TestCase(11)]
        [TestCase(12)]
        [TestCase(13)]
        [TestCase(14)]
        [TestCase(15)]
        [TestCase(16)]
        [TestCase(17)]
        [TestCase(18)]
        [TestCase(19)]
        public void Be1WhenCyclomaticComplexityIs10To19(int cyclomaticComplexity)
        {
            const int expected = 1;

            ccMetric metric = new ccMetric(null, null, cyclomaticComplexity);

            Assert.AreEqual(expected, metric.AggregateComplexity);
        }

        [Test]
        public void Be4WhenCyclomaticComplexityIs42()
        {
            const int expected = 4;
            const int cyclomaticComplexity = 42;

            ccMetric metric = new ccMetric(null, null, cyclomaticComplexity);

            Assert.AreEqual(expected, metric.AggregateComplexity);
        }

        [TestCase(-1)]
        [TestCase(-2)]
        [TestCase(-10)]
        public void ThrowWhenCyclomaticComplexityIsNegative(int cyclomaticComplexity)
        {
            ccMetric metric = new ccMetric(null, null, cyclomaticComplexity);

            void AggregateCall() { int aggregateComplexity = metric.AggregateComplexity; }

            Assert.Throws<ArgumentOutOfRangeException>(AggregateCall);
        }
    }
}
