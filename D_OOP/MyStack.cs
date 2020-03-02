using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace D_OOP
{
    public class MyStack<T> : IEnumerable<T>
    {
        private T[] _items;

        public int Count { get; private set; }

        public int Capacity
        {
            get {
                return _items.Length;
            }
        }
        public MyStack()
        {
            const int defaultCapacity = 4;
            _items = new T[defaultCapacity];
        }

        public MyStack(int capcity)
        {
            _items = new T[capcity];
        }

        public void Push(T item)
        {
            if (_items.Length == Count)
            {
                T[] lagerArray = new T[Count * 2];
                Array.Copy(_items, lagerArray, Count);

                _items = lagerArray;
            }
            _items[Count++] = item;
        }

        public void Pop()
        {
            if (Count == 0)
            {
                throw new InvalidProgramException();
            }
            _items[--Count] = default;
        }

        public T Peek()
        {
            if (Count == 0)
            {
                throw new InvalidProgramException();
            }
            return _items[Count - 1];
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
