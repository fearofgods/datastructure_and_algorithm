namespace LinkedList
{
    internal class MyNode
    {
        public int Data;
        public MyNode? PrevNode, NextNode;

        public MyNode(int data)
        {
            Data = data;
            PrevNode = null;
            NextNode = null;
        }
    }
}
