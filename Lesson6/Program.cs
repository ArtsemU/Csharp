using System;
using System.Collections.Generic;

namespace Lesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> studentsQueue = new Queue<string>();
            Stack<string> studentsStack = new Stack<string>();
            string[] studensArray = new string[] { "Student One", "Student Two", "Student Three", "Student Four"};

            foreach (var student in studensArray)
            {
                studentsQueue.Enqueue(student);
                studentsStack.Push(student);
            }

            Console.WriteLine("Choose type of queue. 1 - Queue, 2 - Stack");
            int choosed = int.Parse(Console.ReadLine());

            if (choosed == 1)
            {
                Console.WriteLine($"Task from {studentsQueue.Peek()} received");
                Console.WriteLine($"{studentsQueue.Dequeue()} got a cup of coffee");
                Console.WriteLine($"Task from {studentsQueue.Peek()} received");
                Console.WriteLine($"{studentsQueue.Dequeue()} got a cup of coffee");
                Console.WriteLine($"Task from {studentsQueue.Peek()} received");
                Console.WriteLine($"{studentsQueue.Dequeue()} got a cup of coffee");
                Console.WriteLine($"Task from {studentsQueue.Peek()} received");
                Console.WriteLine($"{studentsQueue.Dequeue()} got a cup of coffee");
            }
            else if (choosed == 2)
            {
                Console.WriteLine($"Task from {studentsStack.Peek()} received");
                Console.WriteLine($"{studentsStack.Pop()} got a cup of coffee");
                Console.WriteLine($"Task from {studentsStack.Peek()} received");
                Console.WriteLine($"{studentsStack.Pop()} got a cup of coffee");
                Console.WriteLine($"Task from {studentsStack.Peek()} received");
                Console.WriteLine($"{studentsStack.Pop()} got a cup of coffee");
                Console.WriteLine($"Task from {studentsStack.Peek()} received");
                Console.WriteLine($"{studentsStack.Pop()} got a cup of coffee");

            }
            else
            {
                Console.WriteLine("Try again");
            }
           
        }
    }
}
