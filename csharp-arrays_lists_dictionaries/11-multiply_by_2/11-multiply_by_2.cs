using System;
using System.Collections.Generic;

class Dictionary
{
    public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
    {
        Dictionary<string, int> multDict = new Dictionary<string, int>();

        foreach (KeyValuePair<string, int> pair in myDict)
        {
            multDict.Add(pair.Key, pair.Value * 2);
        }
        return multDict;
    }
}
