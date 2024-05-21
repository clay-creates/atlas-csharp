using System;

class MatrixMath
{
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        if (matrix.GetCount(0) == 2 || matrix.GetCount(0) == 3)
        {
            double[,] result = new double[];
            for (int i = 0; i < matrix.Length; i++)
            {
                result += matrix[i] * scalar;
            }
        }
        else
        {
            return new double[-1, -1];
        }
    }
}
