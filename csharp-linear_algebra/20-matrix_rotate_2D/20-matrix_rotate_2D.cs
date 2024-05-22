using System;

class MatrixMath
{
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {

        if (matrix.GetLength(1) > 2)
        {
            return new double[,] { { -1 } };
        }

        double cos = Math.Cos(angle);
        double sin = Math.Sin(angle);

        double[,] result = new double[2, 2];

        for (int x = 0; x < 2; x++)
        {
            for (int y = 0; y < 2; y++)
            {
                result[x, y] = matrix[x, 0] * cos - matrix[y, 1] * sin;
            }
        }

        return result;
    }
}
