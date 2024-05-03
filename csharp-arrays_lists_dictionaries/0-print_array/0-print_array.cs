using System;

public class Array
{
    public static int[] CreatePrint(int size)
    {
        int[] array = null;

        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }

        if (size == 0)
        {
            Console.WriteLine();
        }
        else
        {
            array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = i;
                // Console.Write(array[i]);
            }
            Console.WriteLine(string.Join(" ", array));
        }
        return array;
    }
}
