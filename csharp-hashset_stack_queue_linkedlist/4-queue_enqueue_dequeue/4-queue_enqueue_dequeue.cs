﻿using System;
using System.Collections.Generic;
using System.Linq;

public class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {

        Console.WriteLine($"Number of items: {aQueue.Count}");

        if (aQueue.Any())
        {
            Console.WriteLine($"First item: {aQueue.Peek()}");
        }
        else
        {
            Console.WriteLine("Queue is empty");
        }

        aQueue.Enqueue(newItem);

        bool containsSearch = aQueue.Contains(search);
        Console.WriteLine($"Queue contains \"{search}\": {containsSearch}");

        if (containsSearch)
        {
            int searchIndex = aQueue.ToList().IndexOf(search);

            for (int i = 0; i <= searchIndex; i++)
            {
                aQueue.Dequeue();
            }
        }

        return aQueue;
    }
}
