using System;
using System.Collections.Generic;

class List
{
    public static int SafePrint(List<int> myList, int n)
    {
        int printed = 0;
        try
        {
            for (int i = 0; i < Math.Min(n, myList.Count); i++)
            {
                Console.WriteLine(myList[i]);
                printed++;
            }
        }
        catch (IndexOutOfRangeException)
        {
            return 0;
        }
        return printed;
    }
}
