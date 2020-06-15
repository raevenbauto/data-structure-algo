using System;
using DataStructuresAndAlgorithms.Array;
namespace DataStructuresAndAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            MyArray numbers = new MyArray(1);
            numbers.Insert(10);
            numbers.Insert(20);
            numbers.Insert(30);
            numbers.Print();
        }
    }
}
