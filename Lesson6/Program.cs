using System;
using System.Collections.Generic;
using System.Linq;

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
                Console.WriteLine($"Task {student} is received");
                //studentsStack.Push(student);
            }

            Console.WriteLine("Choose type of queue. 1 - Queue, 2 - Stack");
            int choosed = int.Parse(Console.ReadLine());

            if (choosed == 1)
            {
                var b = studentsQueue.Contains("Student Two");
                Console.WriteLine(b);
                foreach (var item in studentsQueue)
                {
                    Console.WriteLine(item);
                }

                Console.WriteLine($"{studentsQueue.Dequeue()} got a cup of coffee");

                Console.WriteLine($"{studentsQueue.Dequeue()} got a cup of coffee");

                Console.WriteLine($"{studentsQueue.Dequeue()} got a cup of coffee");

                Console.WriteLine($"{studentsQueue.Dequeue()} got a cup of coffee");
            }
            //else if (choosed == 2)
            //{
            //    Console.WriteLine($"Task from {studentsStack.Peek()} received");
            //    Console.WriteLine($"{studentsStack.Pop()} got a cup of coffee");
            //    Console.WriteLine($"Task from {studentsStack.Peek()} received");
            //    Console.WriteLine($"{studentsStack.Pop()} got a cup of coffee");
            //    Console.WriteLine($"Task from {studentsStack.Peek()} received");
            //    Console.WriteLine($"{studentsStack.Pop()} got a cup of coffee");
            //    Console.WriteLine($"Task from {studentsStack.Peek()} received");
            //    Console.WriteLine($"{studentsStack.Pop()} got a cup of coffee");

            //}
            else
            {
                Console.WriteLine("Try again");
            }

            // 
            string str = "Use for loop to access list as shown below:";
            string[] strSplitted = str.Split(" ");
            Console.WriteLine(strSplitted.Length);

            Dictionary<int, int> dictString = new Dictionary<int, int>();
            for (int i = 0; i < strSplitted.Length; i++)
            {
                dictString.Add(i, strSplitted[i].Length);

            }
            foreach (var x in dictString.OrderBy(x => x.Value))
            {
                //Console.WriteLine("{0} - {1}", x.Key, x.Value);
                Console.WriteLine(strSplitted[x.Key]);

            }

            string strPolindrome = "asd dsa";
            string sss = "";
            for (int i = strPolindrome.Length-1; i <= 0; i--)
            {
                if (strPolindrome[i] == ' ')
                {
                    continue;
                }
                sss+=strPolindrome[i];
            }
            Console.WriteLine(sss);

        }
    }
}
