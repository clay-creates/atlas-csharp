using System;
using System.Collections.Generic;

class List
{
    public static List<bool> DivisibleBy2(List<int> myList)
    {
        List<bool> results = new List<bool>(new bool[myList.Count]);

        for (int i = 0; i < myList.Count; i++)
        {
            results[i] = myList[i] % 2 == 0;
        }
        return results;
    }
}
