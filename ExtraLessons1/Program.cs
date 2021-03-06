﻿using System;

namespace ExtraLessons1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            // Создаем массив
            int[] arr = new int[150];
            for (int k = 0; k < arr.Length; k++)
            {
                arr[k] = random.Next(0, 50);
            }
            //// Выводим в консоли созданный ранее массив
            foreach (var item in arr)
            {
                Console.Write(item + "  ");
            }
            Console.WriteLine();

            Console.ReadLine();
            int[] arrTest1 = new int[5] { 8, 3, 1, 7, 6 };
            TestSorting(arr, 0, arr.Length - 1);

            // Выводим то что получилось
            foreach (var item in arr)
            {
                Console.Write(item + "  ");
            }
            Console.ReadLine();

        }

        static void TestSorting(int[] arr, int startIndex, int endIndex)
        {
            // вот тут начнется методо!
            // последний элемент и есть наш опорный
            int pivot = arr[endIndex];
            int i = startIndex;
            int j = startIndex;
            Console.WriteLine($"Pivot: {pivot}, startIndex: {startIndex}, endIndex: {endIndex}");
            while (i < endIndex)
            {                
                if (arr[i] < pivot)
                {
                    // swop
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    j++;
                }               
                i++;
            }
            int temp2 = arr[endIndex];
            arr[endIndex] = arr[j];
            arr[j] = temp2;
            // рекурсия
            if (j - startIndex >= 2)
            {
                TestSorting(arr, startIndex, j - 1);
            }
            if (endIndex - j > 1)
            {
                TestSorting(arr, j, endIndex);
            }
        }

        static void TestSortingOne(int[] arr, int startIndex, int endIndex)
        {
            // вот тут начнется методо!
            // последний элемент и есть наш опорный
            int pivot = arr[endIndex];
            int i = startIndex;
            int j = startIndex;

            while (i < endIndex)
            {
                if (arr[i] >= pivot)
                {
                    i++;
                    continue;
                }
                else if (arr[i] < pivot)
                {
                    // swop
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    j++;
                }
                i++;
            }

            int temp2 = arr[endIndex];
            arr[endIndex] = arr[j];
            arr[j] = temp2;
            // рекурсия
            if (j - startIndex > 1)
            {
                TestSorting(arr, startIndex, j - 1);
            }
            if (endIndex - j > 1)
            {
                TestSorting(arr, j, endIndex);
            }
        }
    }
}
