﻿using System;

namespace _0_print_array
{
    public class Array
    {
        public static int[] CreatePrint(int size)
        {
            if (size < 0)
            {
                Console.WriteLine("Size cannot be negative");
                return null;
            }
            int[] array = new int[size];

            for (int i = 0; i < size; i++)
            {
                array[i] = i;
            }

            if (size == 0)
            {
                Console.Writeline();
            }
            else
            {
                Console.WriteLine(string.Join(", ", array));
            }
            return array;
        }
    }
}
