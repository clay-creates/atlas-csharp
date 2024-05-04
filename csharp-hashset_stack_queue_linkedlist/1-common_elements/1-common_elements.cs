using System;
using System.Collections.Generic;

class List
{
    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        HashSet<int> set1 = new HashSet<int>(list1);
        List<int> commons = new List<int>();
        foreach (int element in list2)
        {
            if (set1.Contains(element))
            {
                commons.Add(element);
            }
        }
        for (int i = 0; i < commons.Count - 1; i++)
        {
            for (int j = 0; j < commons.Count - i - 1; j++)
            {
                if (commons[j] > commons[j + 1])
                {
                    int temp = commons[j];
                    commons[j] = commons[j + 1];
                    commons[j + 1] = temp;
                }
            }
        }
        return commons;
    }
}
