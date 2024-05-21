using System;

class MatrixMath
{
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        int row1 = matrix1.GetLength(0);
        int col1 = matrix1.GetLength(1);
        int row2 = matrix2.GetLength(0);
        int col2 = matrix2.GetLength(1);

        if (col1 != row2)
        {
            return new double[,] { { -1 } };
        }

        double[,] result = new double[row1, col2];

        for (int x = 0; x < row1; x++)
        {
            for (int y = 0; y < col2; y++)
            {
                for (int z = 0; z < col1; z++)
                {
                    result[x, y] += matrix1[x, z] * matrix2[z, y];
                }
            }
        }

        return result;
    }
}