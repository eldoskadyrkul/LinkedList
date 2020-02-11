using System;

namespace LinkedList
{
    public class Node
    {
        private object data;
        private Node next;

        public Node(object data, Node next)
        {
            this.data = data;
            this.next = next;
        }

        public object Data
        {
            get => data;
            set => data = value;
        }

        public Node Next
        {
            get => next;
            set => next = value;
        }
    }
}