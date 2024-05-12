using LinkedList.Interface;

namespace LinkedList.DoublelyLinkedList;
public class DoublelyLinkedList<T> : ILinkedList<T>
{
    public int Count { get; private set; }
    public Node<T>? Head { get; private set; }
    public Node<T>? Tail { get; private set; }

    public DoublelyLinkedList()
    {
        Count = 0;
        Head = null;
        Tail = null;
    }

    public bool IsEmpty => Count == 0;

    public void AddFirst(T value)
    {
        if (IsEmpty)
        {
            Head = Tail = new Node<T>(value);
        }
        else
        {
            Node<T> newNode = new Node<T>(value);
            newNode.Next = Head;
            Head!.Previous = newNode;
            Head = newNode;
        }
        Count++;
    }

    public void AddLast(T value)
    {
        throw new NotImplementedException();
    }

    public void Clear()
    {
        throw new NotImplementedException();
    }

    public bool Contains(T value)
    {
        throw new NotImplementedException();
    }

    public int IndexOf(T? value)
    {
        throw new NotImplementedException();
    }

    public T? PeakFirst()
    {
        throw new NotImplementedException();
    }

    public T? PeakLast()
    {
        throw new NotImplementedException();
    }

    public bool Remove(T value)
    {
        throw new NotImplementedException();
    }

    public void RemoveAt(int index)
    {
        throw new NotImplementedException();
    }

    public T? RemoveFirst()
    {
        throw new NotImplementedException();
    }

    public T? RemoveLast()
    {
        throw new NotImplementedException();
    }

    public void Traverse()
    {
        throw new NotImplementedException();
    }
}
