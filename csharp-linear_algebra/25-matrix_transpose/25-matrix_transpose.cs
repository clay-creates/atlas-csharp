using System;

class MatrixMath
{
    public static double[,] Transpose(double[,] matrix)
    {
        int row = matrix.GetLength(0);
        int col = matrix.GetLength(1);

        double[,] result = new double[col, row];

        for (int x = 0; x < row; x++)
        {
            for (int y = 0; y < col; y++)
            {
                result[y, x] = matrix[x, y];
            }
        }
        return result;
    }
}