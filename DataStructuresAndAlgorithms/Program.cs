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
            myll.AddHead(100);
            myll.AddHead(200);
            myll.AddHead(300);
            myll.AddTail(400);
            myll.AddTail(500);
            myll.Reverse();

            Console.WriteLine(myll.ToArray().ToString());
        }
    }
}
