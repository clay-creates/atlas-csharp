using System;
using System.Collections.Generic;

class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        List<int> result = new List<int>();

        try
        {
            for (int i = 0; i < listLength; i++)
            {
                if (i >= list1.Count || i >= list2.Count)
                {
                    throw new IndexOutOfRangeException("Out of range");
                }

                if (list2[i] == 0)
                {
                    throw new DivideByZeroException("Cannot divide by zero");
                }

                result.Add(list1[i] / list2[i]);
            }
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
        }

        return result;
    }
}
