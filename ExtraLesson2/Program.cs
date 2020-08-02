using System;
using System.Collections.Generic;

namespace ExtraLesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            string testString = "Переставить (сортировать) слова в строке в порядке длины слова – от самых длинных до самых коротких.";

            string[] arrString = testString.Split(' ');

            List<(int, string)> testList = new List<(int, string)>();
            for (int i = 0; i < arrString.Length; i++)
            {
                testList.Add((arrString[i].Length, arrString[i]));
            }

            testList.Sort();
            foreach (var item in testList)
            {
                Console.WriteLine($"{item.Item1} - {item.Item2}");
            }
            Console.ReadLine();
        }
    }
}
