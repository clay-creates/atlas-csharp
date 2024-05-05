using System;
using System.Collections.Generic;

class LList
{
    public static int Length(LinkedList<int> myLList)
    {
        int lengthCount = 0;
        foreach (var item in myLList)
        {
            lengthCount++;
        }
        return lengthCount;
    }
}
