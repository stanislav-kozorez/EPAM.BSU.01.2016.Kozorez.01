using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logic;

namespace Logic.Tests
{
    [TestClass]
    public class Task1Tests
    {
        [TestMethod]
        public void Root_3thPowerRootFrom8_Returned2()
        {
            double expected = Math.Pow(8, 1/3.0);
            double actual = Task1.Root(8, 3);

            Assert.AreEqual(expected, actual, 0.0001);
        }

        [TestMethod]
        public void Root_HalfPowerRootFrom4_Returned16()
        {
            double expected = Math.Pow(4, 2);
            double actual = Task1.Root(4, 1/2.0);

            Assert.AreEqual(expected, actual, 0.0001);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Root_0PowerRootFrom10_ReturnedArgumentException()
        {
            Task1.Root(10, 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Root_NegativePowerRootFrom0_ReturnedArgumentException()
        {
            Task1.Root(0, -5);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Root_EvenMumberPowerRootFromMinus16_ReturnedArgumentException()
        {
            Task1.Root(-16, 2);
        }

        [TestMethod]
        public void Root_10PowerRootFrom0_Returned0()
        {
            Task1.Root(0, 10);
        }
    }
}
