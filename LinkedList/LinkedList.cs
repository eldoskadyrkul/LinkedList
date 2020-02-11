using System;

namespace LinkedList
{
    public class LinkedList
    {
        /*
         * Private fields
         * 1. Node gear - Is a reference to the first node in the list
         * 2. Int count - The current size of the list
         */
        private Node gear;
        private int count = 0;

        /*
         * Constructor
         * LinkedList() - Initializes the private fields
         */
        public LinkedList()
        {
            gear = null;
            count = 0;
        }

        
        public bool Empty
        {
            get { return count == 0; }
        }

        public int Count
        {
            get => count;
        }
        
        // Indexer
        public object this[int index]
        {
            get { return this.Get(index); }
        }
        
        /*
         * Methods
         */
        // Add an item to the list at specified index
        public object Add(int index, object o)
        {
            if (index < 0)
                throw new ArgumentOutOfRangeException("Index:" + index);

            if (index > count)
                index = count;

            Node current = this.gear;

            if (this.Empty || index == 0)
            {
                gear = new Node(o, gear);
            }
            else
            {
                for (int i = 0; i < index - 1; i++)
                {
                    current = current.Next;
                }
                
                current.Next = new Node(o, current.Next);
            }

            count++;

            return o;
        }
        
        // Add an item to the END of the list
        public object Add(object o)
        {
            return Add(count, o);
        }
        
        // Remove the item in the list at the specified index
        public object Delete(int index)
        {
            if (index < 0)
            {
                throw new ArgumentOutOfRangeException("Index: " + index);
            }

            if (this.Empty)
            {
                return null;
            }

            if (index >= count)
                index = count - 1;

            Node current = gear;
            object result = null;

            if (index == 0)
            {
                result = current.Data;
                gear = current.Next;
            }
            else
            {
                for (int i = 0; i < index - i; i++)
                {
                    current = current.Next;
                }

                result = current.Next.Data;

                current.Next = current.Next.Next;
            }

            count--;

            return result;
        }
        
        // Clear the list
        public void Clear()
        {
            gear = null;
        }
        
        // Gets the index of the item in the list, if not in the list return -1
        public int IndexOf(object o)
        {
            Node current = gear;

            for (int i = 0; i < count; i++)
            {
                if (current.Data.Equals(o))
                {
                    return i;
                }

                current = current.Next;
            }

            return -1;
        }
        
        // TRUE / FALSE if the list contains the object
        public bool Contains(object o)
        {
            return IndexOf(o) >= 0;
        }
        
        // Gets items at the specified index
        public object Get(int index)
        {
            if (index < 0)
                throw new ArgumentOutOfRangeException("Index " + index);

            if (Empty)
                return null;

            if (index >= count)
            {
                index = count - 1;
                throw new ArgumentOutOfRangeException("Index: " + index);
            }

            Node current = gear;

            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }

            return current.Data;
        }
    }
}