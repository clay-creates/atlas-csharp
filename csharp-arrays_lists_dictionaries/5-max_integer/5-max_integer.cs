using System;

public class List
{
    public static int MaxInteger(List<int> myList)
    {
        if (myList == null || myList == 0)
        {
            Console.WriteLine("List is empty");
            return -1;
        }

        int MaxInt = myList[0];

        foreach (int num in myList)
        {
            if (num > MaxInt)
            {
                MaxInt = num;
            }
        }
        return MaxInt;
    }
}
