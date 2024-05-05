using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> node = myLList.First;

        if (node == null)
        {
            myLList.AddLast(n);
            return myLList.First;
        }

        while (node != null && node.Value < n)
        {
            node = node.Next;
        }

        if (node != null)
        {
            myLList.AddBefore(node, n);
        }
        else
        {
            myLList.AddLast(n);
        }
        return myLList.First;
    }
}
