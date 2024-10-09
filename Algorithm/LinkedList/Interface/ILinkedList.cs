namespace LinkedList.Interface;
public interface ILinkedList<T>
{
    public void AddFirst(T value);
    public void AddLast(T value);
    public T? RemoveFirst();
    public T? RemoveLast();
    public T? PeakFirst();
    public T? PeakLast();
    public void Clear();
    public bool Remove(T value);
    public bool Contains(T value);
    public void Traverse();
    public void RemoveAt(int index);
    public int IndexOf(T? value);
    public void Reverse();
}
