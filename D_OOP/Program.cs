using System;
using System.Collections.Generic;

namespace D_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack<int> ms = new MyStack<int>();
            ms.Push(1);
            ms.Push(2);
            ms.Push(7);

            Console.WriteLine(ms.Peek());
            ms.Pop();
            Console.WriteLine(ms.Peek());

            ms.Push(3);
            ms.Push(4);
            ms.Push(5);
            Console.WriteLine(ms.Peek());

        }
    }
}
