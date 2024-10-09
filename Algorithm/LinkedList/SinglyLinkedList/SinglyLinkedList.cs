using LinkedList.Interface;

namespace LinkedList.SinglyLinkedList;
public class SinglyLinkedList<T> : ILinkedList<T>
{
    public int Count { get; private set; }
    public Node<T>? Head { get; private set; }
    public Node<T>? Tail { get; private set; }

    public SinglyLinkedList()
    {
        Count = 0;
        Head = null;
        Tail = null;
    }

    public bool IsEmpty => Count == 0;

    // Big O(1)
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
            Head = newNode;
        }
        Count++;
    }

    // Big O(1)
    public void AddLast(T value)
    {
        if (IsEmpty)
        {
            Head = Tail = new Node<T>(value);
        }
        else
        {
            Node<T> newNode = new Node<T>(value);
            Tail!.Next = newNode;
            Tail = newNode;
        }
        Count++;
    }

    public T? RemoveFirst()
    {
        if (IsEmpty) throw new Exception("List is empty");

        T? data = Head!.Value;
        Head = Head.Next;
        Count--;
        if (IsEmpty) Tail = null;

        return data;
    }

    public T? RemoveLast()
    {
        if (IsEmpty) throw new Exception("List is empty");

        T? data = Tail!.Value;
        Node<T>? current = Head;
        while (current != null && current.Next != Tail)
        {
            current = current.Next!;
        }
        Tail = current;
        Tail!.Next = null;
        Count--;
        if (IsEmpty) Head = null;

        return data;
    }

    public T? PeakFirst()
    {
        if (IsEmpty) throw new Exception("List is empty");

        T? data = Head!.Value;
        return data;
    }

    public T? PeakLast()
    {
        if (IsEmpty) throw new Exception("List is empty");

        T? data = Tail!.Value;
        return data;
    }

    public void Clear()
    {
        Node<T> currentNode = Head!;
        while (currentNode != null)
        {
            Node<T> nextNode = currentNode.Next!;
            currentNode.Next = null;
            currentNode.Value = default(T);
            currentNode = nextNode;
        }
        Head = Tail = null;
        Count = 0;
    }

    private void RemoveNode(Node<T> node)
    {
        if (node.Next == null) RemoveLast();

        Node<T>? current = Head;
        while (current != null)
        {
            if (current == node)
            {
                node.Next = null;
                node.Value = default(T);
            }

            current = current.Next!;
        }
        Count--;
    }

    public bool Remove(T value)
    {
        if (IsEmpty) throw new Exception("List is empty");

        Node<T>? current = Head!;

        if (value == null)
        {
            while (current != null)
            {
                if (current.Value == null)
                {
                    RemoveNode(current);
                    return true;
                }

                current = current.Next;
            }
        }
        else
        {
            while (current != null)
            {
                if (current.Value!.Equals(value))
                {
                    RemoveNode(current);
                    return true;
                }

                current = current.Next;
            }
        }

        return false;
    }

    public void Traverse()
    {
        Node<T>? current = Head;
        while (current != null)
        {
            Console.WriteLine(current.Value);
            current = current.Next;
        }
    }

    public void RemoveAt(int index)
    {
        if (index < 0 || index >= Count) throw new IndexOutOfRangeException();

        if (index == 0)
        {
            if (Head != null)
            {
                Head = Head.Next;
                if (Head == null)
                {
                    Tail = null;
                }
            }
        }
        else
        {
            int currentIdx = 0;
            Node<T>? current = Head;
            Node<T>? previous = null;

            // Traverse to the node at the specified index
            while (current != null && currentIdx < index)
            {
                previous = current;
                current = current.Next;
                currentIdx++;
            }

            if (current != null)
            {
                // Remove the node by updating pointers
                if (previous != null)
                {
                    previous.Next = current.Next;
                    if (current.Next == null)
                        Tail = previous; // Update Tail if removing the last node
                }

                // Update Count
                Count--;
            }
        }
    }

    public int IndexOf(T? value)
    {
        int index = 0;

        Node<T> currentNode = Head;
        if (value == null)
        {
            while (currentNode != null)
            {
                if (currentNode.Value == null)
                {
                    return index;
                }
                currentNode = currentNode.Next;
                index++;
            }
        }
        else
        {
            while (currentNode != null)
            {
                if (currentNode.Value!.Equals(value))
                {
                    return index;
                }
                currentNode = currentNode.Next!;
                index++;
            }
        }

        return -1;
    }

    public bool Contains(T value)
    {
        return IndexOf(value) != -1;
    }

    public void Reverse()
    {
        if (IsEmpty) throw new Exception("List is empty! Nothing to reverse!");

        if (Head == null)
        {
            return;
        }
        Node<T>? current = Head;
        Node<T>? previous = null;
        Node<T>? next = null;

        //5->4->3->2->1
        //next=2, current=1, previous=null
        //current.next=previous=null, previous=current=1, current=next=2

        //1->2->3->4->5
        Tail = current;
        while (current != null)
        {
            next = current.Next;
            current.Next = previous;
            previous = current;
            current = next;
        }

        Head = previous;
    }

    public void Sort()
    {

    }
}
