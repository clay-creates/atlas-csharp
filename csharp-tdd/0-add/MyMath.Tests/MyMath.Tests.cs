using NUnit.Framework;
using System;
using MyMath;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            int a = 1;
            int b = 2;
        }

        [Test]
        public void AddTwoPositive()
        {
            Assert.AreEqual(3, Operations.Add(1, 2), "The sum of 1 and 2 should be 3");
        }

        [Test]
        public void AddTwoNegative()
        {
            Assert.AreEqual(-3, Operations.Add(-1, -2), "The sum of -1 and -2 should be -3");
        }

        [Test]
        public void AddTwoZero()
        {
            Assert.AreEqual(0, Operations.Add(0, 0), "The sum of 0 and 0 should be 0");
        }

        [Test]
        public void AddOnePositive_OneNegative()
        {
            Assert.AreEqual(-1, Operations.Add(1, -2), "The sum of 1 and -2 should be -1");
        }
    }
}