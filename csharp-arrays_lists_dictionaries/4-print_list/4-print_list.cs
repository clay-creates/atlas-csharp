﻿using System;
using System.Collections.Generic;

public class List
{
    public static List<int> CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }

        List<int> numbers = new List<int>();

        for (int i = 0; i < size; i++)
        {
            numbers.Add(i);
        }

        foreach (int number in numbers)
        {
            Console.Write(number);
            if (i >= size)
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine();

        return numbers;
    }
}
