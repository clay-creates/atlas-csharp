using System;
using System.Collections.Generic;
class LList
{
    public static int Sum(LinkedList<int> myLList)
    {
        int listSum = 0;
        foreach (int value in myLList)
        {
            listSum += value;
        }
        return listSum;
    }
}
