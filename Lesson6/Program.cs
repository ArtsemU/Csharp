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
                Console.WriteLine($"Task from {studentsQueue.Dequeue()} received");
                Console.WriteLine($"Task from {studentsQueue.Dequeue()} received");
                Console.WriteLine($"Task from {studentsQueue.Dequeue()} received");
                Console.WriteLine($"Task from {studentsQueue.Dequeue()} received");
            }
            else if (choosed == 2)
            {
                Console.WriteLine($"Task from {studentsStack.Pop()} received");
                Console.WriteLine($"Task from {studentsStack.Pop()} received");
                Console.WriteLine($"Task from {studentsStack.Pop()} received");
                Console.WriteLine($"Task from {studentsStack.Pop()} received");
            }
            else
            {
                Console.WriteLine("Try again");
            }
           
        }
    }
}
