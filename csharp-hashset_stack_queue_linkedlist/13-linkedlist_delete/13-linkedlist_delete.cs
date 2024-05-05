using System;
using System.Collections.Generic;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        LinkedListNode<int> nodeToDelete = myLList.First;
        for (int i = 0; i < index; i++)
        {
            nodeToDelete = nodeToDelete.Next;
        }

        myLList.Remove(nodeToDelete);
    }
}
