﻿using System;

class VectorMath
{
    public static double Magnitude(double[] vector)
    {
        if (vector.Length != 2 && vector.Length != 3)
        {
            return -1;
        }

        double sum = 0;
        for (int i = 0; i < vector.Length; i++)
        {
            sum += Math.Pow(vector[i], 2);
        }

        return Math.Round(Math.Sqrt(sum), 2);
    }
}
