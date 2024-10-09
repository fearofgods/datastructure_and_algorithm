using LinkedList.SinglyLinkedList;

namespace LinkedList;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        TestSinglyLinkedList();
    }

    static void TestSinglyLinkedList()
    {
        SinglyLinkedList<int> singlyLinkedList = new SinglyLinkedList<int>();
        singlyLinkedList.AddFirst(1);
        singlyLinkedList.AddFirst(2);
        singlyLinkedList.AddFirst(3);
        singlyLinkedList.AddFirst(4);
        singlyLinkedList.AddFirst(5);

        //singlyLinkedList.RemoveAt(2);
        //singlyLinkedList.RemoveAt(3);


        Console.WriteLine("Count::"+singlyLinkedList.Count);
        singlyLinkedList.Reverse();
        singlyLinkedList.Traverse();
    }


}
