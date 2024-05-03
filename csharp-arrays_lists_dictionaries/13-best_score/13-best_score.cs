using System;
using System.Collections.Generic;
using System.Linq;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        if (myList == null || myList.Count < 0)
        {
            return "None";
        }
        var bestScore = myList.OrderByDescending(pair => pair.Value).First().Key;
        return bestScore;
    }
}
