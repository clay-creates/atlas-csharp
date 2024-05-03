using System;
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

        Console.WriteLine("List of integers:");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();

        return numbers;
    }
}
