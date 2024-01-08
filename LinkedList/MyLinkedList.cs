namespace LinkedList
{
    internal class MyLinkedList
    {
        private MyNode? Head;
        private int Size = 0;

        public void AddToHead(int data)
        {
            MyNode newNode = new MyNode(data);
            if (Head == null)
            {
                Head = newNode;
                Size++;
                return;
            }

            newNode.NextNode = Head;
            Head.PrevNode = newNode;
            Head = newNode;
            Size++;
        }

        public void AddToTail(int data)
        {
            MyNode newNode = new MyNode(data);
            if (Head == null)
            {
                Head = newNode;
                Size++;
                return;
            }
            MyNode? temp = Head;
            while (temp?.NextNode != null) temp = temp.NextNode;
            newNode.PrevNode = temp;
            temp.NextNode = newNode;
            Size++;
        }

        public void RemoveFromHead()
        {
            MyNode? temp = Head;
            if (Size == 1)
            {
                Head = null;
                Size--;
                return;
            }

            temp!.NextNode!.PrevNode = null;
            Head = temp.NextNode;
            Size--;
            return;
        }

        public void Traverse()
        {
            MyNode? temp = Head;
            while(temp != null)
            {
                Console.Write($"{temp.Data}\t");
                temp = temp.NextNode;
            }
            Console.WriteLine();
        }

        public int GetSize()
        {
            return Size;
        }
    }
}
