using System;
using System.Reflection.Metadata;

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

        //O(N)
        public void Reverse()
        {
            //H                   T
            //1 <== 2 <== 3 => 4 => 5
            //                 p    c    
            //                      n
            //T                          H
            //1 <==  2 <==  3 <==  4 <== 5

            var previous = new Node(Head.Value);
            var current = Head.Next;
            Tail = previous;

            while (current != null)
            {
                var next = current.Next;
                current.Next = previous;
                previous = current;
                current = next;
            }

            Head = previous; 
        }

        public void Print()
        {
            var output = "";
            var current = Head;

            while (current != null)
            {
                output += current.Value + "=>";
                current = current.Next;
            }

            Console.WriteLine(output);
        }

        public int KthNodeFromEnd(int value)
        {
            //n=2
            //1 => 2 => 3 => 4 => 5
            //LEADER
            //                    *    
            //FOLLOWER
            //          *

            var leader = Head;
            var follower = Head;

            for (var i = 0; i < value; i++)
            {
                if (leader == null)
                    return -1;

                leader = leader.Next;
            }

            while (leader != null)
            {
                leader = leader.Next;
                follower = follower.Next;
            }

            return follower.Value; 


            /*
             * If the length of the List is known.
               var curr = Head;
                var length = Size; 

                while (curr != null)
                {
                    if (length == value)
                        return curr.Value;

                    curr = curr.Next; 
                    length--; 
                }

                return -1; 
             */


        }


    }



}
