using System;

/// <summary>
/// A custom generic queue
/// </summary>
/// <typeparam name="T"></typeparam>
public class Queue<T>
{
    /// <summary>
    /// The head node of our queue
    /// </summary>
    private Node head;
    /// <summary>
    /// The tail node of our queue
    /// </summary>
    private Node tail;
    /// <summary>
    /// A node in our queue
    /// </summary>

    private class Node
    {
        public T Value;
        public Node Next;
        public Node(T value)
        {
            Value = value;
            Next = null;
        }
    }

    /// <summary>
    /// Checks the type of the items in queue
    /// </summary>
    /// <returns>Returns the type of our T items</returns>
    public Type CheckType()
    {
        return typeof(T);
    }

    /// <summary>
    /// Initialized a new instance of our Queue
    /// </summary>
    public Queue()
    {
        head = null;
        tail = null;
    }

    /// <summary>
    /// Add item to end of queue
    /// </summary>
    /// <param name="item"></param>
    public void Enqueue(T item)
    {
        Node NewNode = new Node(item);
        if (tail == null)
        {
            head = NewNode;
            tail = NewNode;
        }
        else
        {
            tail.Next = NewNode;
            tail = NewNode;
        }
    }

    /// <summary>
    /// Returns and removes the head item of the queue
    /// </summary>
    /// <returns></returns>
    public T Dequeue()
    {
        if (head == null)
        {
            throw new InvalidOperationException("The queue is empty");
        }
        T value = head.Value;
        head = head.Next;
        if (head == null)
        {
            tail = null;
        }
        return value;
    }

    /// <summary>
    /// Show head item
    /// </summary>
    /// <returns></returns>
    public T Peek()
    {
        return head.Value;
    }

    /// <summary>
    /// Checks if the queue is empty or not
    /// </summary>
    /// <returns></returns>
    public bool IsEmpty()
    {
        return head == null;
    }
}
