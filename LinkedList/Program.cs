namespace LinkedList
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            MyLinkedList myLinkedList = new MyLinkedList();
            myLinkedList.AddToHead(1);
            myLinkedList.AddToTail(2);

            myLinkedList.AddToTail(3);
            myLinkedList.AddToTail(4);
            myLinkedList.AddToTail(5);
            myLinkedList.RemoveFromHead();
            myLinkedList.RemoveAll();

            myLinkedList.Traverse();
            Console.WriteLine("List Size::"+myLinkedList.GetSize());
        }
    }
}
