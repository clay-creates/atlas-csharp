using System;

class MatrixMath
{
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {

        if (matrix == null || matrix.GetLength(0) != matrix.GetLength(1))
        {
            return new double[1, 1] { { -1 } };
        }

        int n = matrix.GetLength(0);

        double[,] result = new double[n, n];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                double newX = matrix[i, j] * Math.Cos(angle) - matrix[j, i] * Math.Sin(angle);
                double newY = matrix[i, j] * Math.Sin(angle) + matrix[j, i] * Math.Cos(angle);

                result[i, j] = newX;
            }
        }
        return result;
    }
}
