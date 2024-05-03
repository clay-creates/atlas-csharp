using System;
using System.Collections.Generic;

class Dictionary
{
    public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
    {
        foreach (KeyValuePair<string, int> pair in myDict)
        {
            string key = pair.Key;
            myDict[key] = myDict[key] * 2;
        }
        return myDict;
    }
}
