using System;

class List
{
    public static int Sum(List<int> myList)
    {
        HashSet<int> uniqInt = new HashSet<int>();
        foreach (int number in myList)
        {
            uniqInt.Add(number);
        }
        int sum = 0;
        foreach (int number in uniqInt)
        {
            sum += number;
        }
        return sum;
    }
}
