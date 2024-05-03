using System;

public class Array
{
    public static void Reverse(int[] array)
    {
        for (int i = array.Length - 1; i >= 0; i--)
        {
            Console.Write(string.Join(" ", array[i]));
        }
    }
}
