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
            myll.AddTail(400);
            myll.AddTail(500);
            myll.AddTail(600);
            myll.AddTail(700);
            myll.AddTail(800);
            myll.AddTail(900);
            myll.Print();
            myll.Reverse();
            myll.Print();

            Console.WriteLine(myll.ToArray().ToString());
        }
    }
}
