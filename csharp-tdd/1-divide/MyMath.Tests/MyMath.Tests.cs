using NUnit.Framework;
using System;
using MyMath;

namespace MyMath.Tests
{
    public class Tests
    {
        private int[,] matrix;
        public int successCount = 0;
        /// <summary>
        /// Testing division of matrix with positive integers
        /// </summary>
        [Test]
        public void DividePositive_ReturnCorrect()
        {
            matrix = new int[,] { { 4, 8 }, { 16, 32 } };
            int num = 2;
            int[,] expected = new int[,] { { 2, 4 }, { 8, 16 } };

            var result = Matrix.Divide(matrix, num);

            Assert.AreEqual(expected, result);
            successCount++;
        }

        /// <summary>
        /// Testing division with division by zero
        /// </summary>
        [Test]
        public void DivideByZero_ReturnNull()
        {
            matrix = new int[,] { { 4, 8 }, { 16, 32 } };
            int num = 2;

            var result = Matrix.Divide(matrix, num);

            Assert.IsNull(result);
            successCount++;
        }

        /// <summary>
        /// Testing division of a null matrix
        /// </summary>
        [Test]
        public void NullMatrix_ReturnNull()
        {
            int num = 2;
            var result = Matrix.Divide(null, num);

            Assert.IsNull(result);
            successCount++;
        }

        /// <summary>
        /// Testing division of a non-numbered matrix
        /// </summary>
        [Test]
        public void NaN_Matrix_ReturnNull()
        {
            matrix = new int[,] { { 0, 0 }, { 0, 0 } };
            int num = 2;

            var result = Matrix.Divide(matrix, num);

            Assert.IsNull(result);
            successCount++;
        }

        [Test]
        public void TestsSuccessful()
        {
            if successCount == 4
            {
                Console.WriteLine("Test Run Successful.");
            }
        }
    }
}
