using NUnit.Framework;
using System.Collections.Generic;
using MyMath;

namespace MyMath.Tests
{
    public class Tests
    {

        private List<int> testList;

        [SetUp]
        public void SetUp()
        {
            testList = new List<int>();
        }

        /// <summary>
        /// Tests output when passed an empty list
        /// </summary>
        [Test]
        public void EmptyList_ReturnZero()
        {
            Assert.AreEqual(0, Operations.Max(testList));
        }

        /// <summary>
        /// Test with only one int in list
        /// </summary>
        [Test]
        public void SingleIntList()
        {
            testList.Add(5);
            Assert.AreEqual(5, Operations.Max(testList));
        }

        /// <summary>
        /// Test with max at end of list
        /// </summary>
        [Test]
        public void MaxEnd()
        {
            testList.AddRange(new int[] { 1, 2, 3, 4 });
            Assert.AreEqual(4, Operations.Max(testList));
        }

        /// <summary>
        /// Test with max at beginning of list
        /// </summary>
        [Test]
        public void MaxStart()
        {
            testList.AddRange(new int[] { 4, 3, 2, 1 });
            Assert.AreEqual(4, Operations.Max(testList));
        }

        /// <summary>
        /// Test with max in middle of list
        /// </summary>
        [Test]
        public void MaxMid()
        {
            testList.AddRange(new int[] { 1, 2, 5, 3, 4 });
            Assert.AreEqual(5, Operations.Max(testList));
        }

        /// <summary>
        /// Test with negative number in list
        /// </summary>
        [Test]
        public void withNegative()
        {
            testList.AddRange(new int[] { 1, 2, 3, 4, -5 });
            Assert.AreEqual(4, Operations.Max(testList));
        }
    }
}