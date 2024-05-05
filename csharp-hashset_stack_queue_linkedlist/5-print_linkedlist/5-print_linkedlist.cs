using System;
using System.Collections.Generic;

class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        if (size < 0)
        {
            return new LinkedList<int>();
        }

        LinkedList<int> list = new LinkedList<int>();

        for (int i = 0; i < size; i++)
        {
            list.AddLast(i);
        }

        Console.WriteLine("LinkedList:");
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
        return list;
    }
}
