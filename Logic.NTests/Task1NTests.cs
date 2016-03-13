using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Logic;

namespace Logic.NTests
{
    [TestFixture]
    public class Task1NTests
    {
        [TestCase(0, 10, Result = 0)]
        [TestCase(10, 0, ExpectedException = typeof(ArgumentException))]
        [TestCase(0, -5, ExpectedException = typeof(ArgumentException))]
        [TestCase(-16, 2, ExpectedException = typeof(ArgumentException))]
        public double Root_ReturnsYthPowerRootFromX(double x, double y)
        {
            return Task1.Root(x, y);
        }

        [Test]
        public void Root_HalfPowerRootFrom4_Returned16()
        {
            double expected = Math.Pow(4, 2);
            double actual = Task1.Root(4, 1 / 2.0);

            Assert.AreEqual(expected, actual, 0.0001);
        }

        [Test]
        public void Root_3thPowerRootFrom8_Returned2()
        {
            double expected = Math.Pow(8, 1 / 3.0);
            double actual = Task1.Root(8, 3);

            Assert.AreEqual(expected, actual, 0.0001);
        }
    }
}
