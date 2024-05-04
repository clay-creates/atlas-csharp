using System;

class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        HashSet<int> set1 = new HashSet<int>();
        List<int> differences = new List<int>();
        foreach (int element in list2)
        {
            if (!set1.Contains(element))
            {
                differences.Add(element);
            }
        }
        foreach (int element in list1)
        {
            if (!set1.Contains(element))
            {
                differences.Add(element);
            }
        }
        for (int i = 0; i < differences.Count - 1; i++)
        {
            for (int j = 0; j < differences.Count - i - 1; j++)
            {
                if (differences[j] > differences[j + 1])
                {
                    int temp = differences[j];
                    differences[j] = differences[j + 1];
                    differences[j + 1] = temp;
                }
            }
        }
        return differences;
    }
}
