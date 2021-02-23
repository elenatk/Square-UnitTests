using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Square
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(1, Calculator.Square(1));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(4, Calculator.Square(2));
        }

        [TestMethod]
        public void TestMethod25()
        {
            Assert.AreEqual(625, Calculator.Square(25));
        }

        [TestMethod]
        public void TestMethod0()
        {
            Assert.AreEqual(0, Calculator.Square(0));
        }

        [TestMethod]
        public void TestMethodMinus1()
        {
            Assert.AreEqual(1, Calculator.Square(-1));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestMethodmaxValue()
        {
             Calculator.Square(int.MaxValue);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestMethodminValue()
        {
            Calculator.Square(int.MinValue);
        }
    }
}
