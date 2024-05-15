using NUnit.Framework;
using System;
using MyMath;

namespace MyMath.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        /// <summary>
        /// Testing division of matrix with positive integers
        /// </summary>
        [Test]
        public void DividePositive_ReturnCorrect()
        {
            int[,] matrix = new int[,] { { 4, 8 }, { 16, 32 } };
            int num = 2;
            int[,] expected = new int[,] { { 2, 4 }, { 8, 16 } };

            var result = matrix.Divide(matrix, num);

            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Testing division with division by zero
        /// </summary>
        [Test]
        public void DivideByZero_ReturnNull()
        {
            int[,] matrix = new int[,] { { 4, 8 }, { 16, 32 } };
            int num = 2;

            var result = matrix.Divide(matrix, num);

            Assert.IsNull(result);
        }

        /// <summary>
        /// Testing division of a null matrix
        /// </summary>
        [Test]
        public void NullMatrix_ReturnNull()
        {
            int num = 2;
            var result = matrix.Divide(null, num);

            Assert.IsNull(result)
        }

        /// <summary>
        /// Testing division of a non-numbered matrix
        /// </summary>
        [Test]
        public void NaN_Matrix_ReturnNull()
        {
            int[,] matrix = new int[,] { { "a", "b" }, { "c", "d" } };
            int num = 2;

            var result = matrix.Divide(matrix, num);

            Assert.IsNull(result);
        }
    }
}
