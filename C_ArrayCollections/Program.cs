using System;
using System.Collections.Generic;
using System.Linq;

namespace C_ArrayCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            dict.Add('I', 1);
            dict.Add('V', 5);
            dict.Add('X', 10);

            string str = "XVIII";
            int result = 0;
            int count = 1;
           
            for (int i = 0; i < str.Length; i++)
            {
                if (i + 1 < str.Length)
                {
                  //  Console.WriteLine(dict[str[i]]);
                  //  Console.WriteLine(dict[str[i + 1]]);
                  //  Console.WriteLine($"Count is {count}");
                  //  count++;
                    result = result + dict[str[i]];
                   // Console.WriteLine($"Res is {result}");
                }
                else if (i == str.Length-1) {
                  //  Console.WriteLine(2);
                    result = result + dict[str[i]];
                }
            }
            Console.WriteLine(result);


        }
        static void arrayType() {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int index = Array.BinarySearch(numbers, 7);
            Console.WriteLine(index);

            int[] copy = new int[10];
            Array.Copy(numbers, copy, numbers.Length);

            int[] anotherCopy = new int[10];
            copy.CopyTo(anotherCopy, 0);

            Array.Reverse(copy);

            Array.Sort(copy);
            Array.Clear(copy, 0, copy.Length);
            foreach (int n in copy)
            {
                Console.Write($"{n} ");
            }

            int[] arr = { 1, 2, 3 };

            Array arr2 = new int[5];

            Array arr3 = Array.CreateInstance(typeof(int), 5);
            arr3.SetValue(20, 0);
            Console.WriteLine(arr3.GetValue(0));
        }
        static void listType()
        {
            var intList = new List<int>() { 1, 4, 7, 12, 9 };
            intList.Add(7);

            int[] intArray = { 1, 2, 3 };

            intList.AddRange(intArray);
            intList.AddRange(intList);

            foreach (int i in intList)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();

            intList.Remove(1);
            intList.RemoveAt(0);
            intList.Reverse();
            bool contains = intList.Contains(6);

            int lenght = intList.Count();
            Console.WriteLine(lenght);


            foreach (int i in intList)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();

            int min = intList.Min();
            int max = intList.Max();

            Console.WriteLine($"Max: {max}, min: {min}");
        }
        static void dictType() {
            var people = new Dictionary<int, string>();
            people.Add(1, "John");
            people.Add(2, "Bob");
            people.Add(3, "Alice");

            Console.WriteLine(people[1]);

            Console.WriteLine("Itereiting over keys");
            Dictionary<int, string>.KeyCollection keys = people.Keys;
            foreach (int item in keys)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine("Itereiting over values");
            var values = people.Values;
            foreach (string item in values)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine("Common solution");
            foreach (var item in people.Keys)
            {
                Console.WriteLine($"{item}:{people[item]}");
            }
            Console.WriteLine();

            Console.WriteLine("Common solution #2");
            foreach (KeyValuePair<int, string> pair in people) // var pair in people
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
            Console.WriteLine();

            Console.WriteLine(people.Count);

            bool containsKey = people.ContainsKey(2);
            bool containsVal = people.ContainsValue("Mike");

            people.Remove(2);

            if (people.TryAdd(3, "TestName"))
            {
                Console.WriteLine("success");
            }
            else
                Console.WriteLine("Fail");

            if (people.TryGetValue(2, out string val))
            {
                Console.WriteLine($"Key : 2, val : {val}");
            }
            else
                Console.WriteLine("Fail!");

            people.Clear();
            Console.WriteLine($"Result lenght is - {people.Count}");
        }
        static void stackQueue() {
            Console.WriteLine("\tStack");
            var stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(4);
            stack.Push(5);
            stack.Push(7);
            Console.WriteLine($"Shoud be 7 - {stack.Peek()}");

            stack.Pop();
            Console.WriteLine($"Shoud be 5 - {stack.Peek()}");

            foreach (int i in stack)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            Console.WriteLine("\tQueue");
            var queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(4);
            queue.Enqueue(6);
            queue.Enqueue(9);
            queue.Enqueue(10);

            Console.WriteLine($"Shoud be 1 - {queue.Peek()}");
            queue.Dequeue();
            Console.WriteLine($"Shoud be 2 - {queue.Peek()}");

            foreach (int i in queue)
            {
                Console.WriteLine(i);
            }
        }
    }
}
