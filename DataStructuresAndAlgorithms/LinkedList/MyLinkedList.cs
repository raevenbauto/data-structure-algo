using System;

namespace DataStructuresAndAlgorithms.LinkedList
{
    public class MyLinkedList
    {
        private class Node
        {
            public Node(int value)
            {
                Value = value;
            }
            public int Value { get; set; }
            public Node Next { get; set; }
        }

        private Node Head { get; set; }
        private Node Tail { get; set; }
        private int Size { get; set; }

        //O(1)
        public MyLinkedList AddTail(int value)
        {
           var node = new Node(value);

           if (Tail == null)
               Head = Tail = node;

           else
           {
               Tail.Next = node;
               Tail = node; 
           }
           Size++;
           return this; 
        }

        //O(1)
        public MyLinkedList AddHead(int value)
        {
            var node = new Node(value);

            if (Head == null)
                Head = Tail = node;

            else
            {
                node.Next = Head;
                Head = node; 
            }
            Size++;
            return this; 
        }

        //O(N)
        public int IndexOf(int value)
        {
            var node = Head;
            var index = 0;

            while (node != null)
            {
                if (node.Value == value)
                    return index;

                node = node.Next;
                index++;
            }

            return -1;
        }

        //O(1)
        public void RemoveHead()
        {
            if (Head == null)
                throw new Exception("LinkedList is Empty");

            if (Head == Tail)
            {
                Head = Tail = null;
                Size--;
                return;
            }

            var newHead = Head.Next;
            Head.Next = null;
            Head = newHead;
            Size--;
        }

        //O(N)
        public void RemoveTail()
        {
            if (Head == null)
                throw new Exception("LinkedList is Empty");

            if (Head == Tail)
            {
                Head = Tail = null;
                Size--;
                return;
            }

            var preTail = Head; 

            while (preTail.Next != null)
            {
                if (preTail.Next == Tail)
                    break;

                preTail = preTail.Next; 
            }

            Tail = preTail;
            Tail.Next = null;
            Size--;
        }

        //O(1)
        public int Count()
        {
            return Size; 
        }

        //O(N)
        public int[] ToArray()
        {
            if (Size < 0)
                throw new Exception("LinkedList is empty.");

            var arr = new int[Size];
            var current = Head;
            var index = 0; 

            while (current != null)
            {
                arr[index] = current.Value;
                index++;
                current = current.Next; 
            }

            return arr;
        }

        public void Reverse()
        {
            this.AddTail(10000);
        }

        /*
         *  Implement the following.
         *  AddHead
         *  AddTail
         *  DeleteHead
         *  DeleteTail
         *  Contains
         *  IndexOf
         */
    }



}
