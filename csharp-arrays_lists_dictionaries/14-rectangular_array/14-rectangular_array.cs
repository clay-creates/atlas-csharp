﻿using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[,] array = new int[5, 5];

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = 0;
            }
        }

        array[2, 2] = 1;

        for (int i = 0; array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
