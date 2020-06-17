using System;
using System.Linq;

namespace DataStructuresAndAlgorithms.Array
{
    public class MyArray
    {
        private int[] items;
        private int length;

        public MyArray(int length)
        {
            items = new int[length];
        }

        public void Print()
        {
            for (int i = 0; i < length; i++)
                Console.WriteLine(items[i]);
        }

        public void Insert(int value)
        {
            if (items.Count() == length)
            {
                var newArr = new int[length * 2];

                for (int i = 0; i < length; i++)
                    newArr[i] = items[i];

                items = newArr; 
            }

            items[length] = value;
            length++;
        }

        public void RemoveAt(int index)
        {
            if (index == 0|| index >= length)
                throw new ArgumentException();

            for (int i = 0; i < index; i++)
                items[index] = items[index + 1];

            length--; 
        }

        public int IndexOf(int value)
        {
            for (int i = 0; i < length; i++)
            {
                if (value == items[i])
                    return i;
            }

            return -1; 
        }
    }
}
