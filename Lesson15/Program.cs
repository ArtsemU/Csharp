using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson15
{
    public enum Priority
    {
        HIGH,
        NORMAL
    }

    public class MyQueue<T>
    {
        private List<T> list = new List<T>();
        public void Enqueue(T item)
        {
            list.Add(item);
        }

        public T Dequeue()
        {
            if (typeof(T) == typeof(int))
            {
                var itemInt = list.Cast<int>().FirstOrDefault(i => i > 100);
                var index = list.Cast<int>().ToList().IndexOf(itemInt);
                var item = list[index];
                list.RemoveAt(index);
                return item;
            }
            else
            {
                var item = list[0];
                list.Remove(item);
                return item;
            }            

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyQueue<int> myQueue = new MyQueue<int>();

            myQueue.Enqueue(1);
            myQueue.Enqueue(2);
            myQueue.Enqueue(50);
            myQueue.Enqueue(100);
            myQueue.Enqueue(150);

            var x = myQueue.Dequeue();
            Console.WriteLine(x);

            x = myQueue.Dequeue();
            Console.WriteLine(x);

            x = myQueue.Dequeue();
            Console.WriteLine(x);
        }
    }
}
