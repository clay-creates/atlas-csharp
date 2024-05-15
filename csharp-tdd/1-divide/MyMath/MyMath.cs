using System;

/// <summary>
/// Sets up MyMath space
/// </summary>
namespace MyMath
{
    /// <summary>
    /// Sets up Matrix class 
    /// </summary>
    public class Matrix
    {
        /// <summary>
        /// Divides a matix of ints by the number passed
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="num"></param>
        /// <returns></returns>
        public static int[,] Divide(int[,] matrix, int num)
        {
            if (matrix == null)
            {
                return null;
            }

            if (num == 0)
            {
                Console.WriteLine("Num cannot be 0");
                return null;
            }

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int[,] result = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    try
                    {
                        result[i, j] = matrix[i, j] / num;
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("Cannot divide by zero")
                        return null;
                    }
                }
            }
            return result;
        }
    }
}