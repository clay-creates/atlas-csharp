using System;
using System.Collections.Generic;
using System.Linq;

class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        var sortedKeys = myDict.Keys.OrderBy(sortedKeys => sortedKeys).ToList();
        foreach (var key in sortedKeys)
        {
            Console.WriteLine($"{key}: {myDict[key]}");
        }
    }
}
