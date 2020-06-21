using System;
using DataStructuresAndAlgorithms;
using DataStructuresAndAlgorithms.Array;
using DataStructuresAndAlgorithms.LinkedList;

namespace DataStructuresAndAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            var myll = new MyLinkedList();
            myll.AddTail(10);
            myll.AddTail(20);
            myll.AddTail(30);
            myll.AddTail(40);
            myll.AddTail(50);


            Console.WriteLine(myll.KthNodeFromEnd(2));
            myll.Print();
        }
    }
}
