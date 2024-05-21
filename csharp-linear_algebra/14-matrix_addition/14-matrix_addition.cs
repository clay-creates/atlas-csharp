using System;

class MatrixMath
{
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        if ((matrix1.GetLength(0) == matrix2.GetLength(0)) && (matrix1.GetLength(1) == matrix2.GetLength(1)))
        {
            int rows = matrix1.GetLength(0);
            int cols = matrix1.GetLength(1);

            double[,] result = new double[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }

            return result;
        }
        else
        {
            double[,] errorMatrix = new double[1, 1] { { -1 } };
            return errorMatrix;
        }
    }
}