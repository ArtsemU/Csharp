using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace ExtraLessons1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.WriteLine("Массивы -  реализовать сортировку Quicksort");

            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 30);
            }
            PrintArray(array);
            Console.WriteLine("Меняем местами 0й и последний индекс");
            int tmp = 0;
            QuikS(array);

            PrintArray(array);





        }

        static public void QuikS(int[] array)
        {
            int tmp = 0;
            int average = array.Length / 2;
            int p = array[average];
            Console.WriteLine(p);
            int i = 0;
            int j = array.Length - 1;
            while (i < j)
            {
                if (array[i] > p)
                {
                    tmp = array[average];
                    array[average] = array[i];
                    array[i] = tmp;
                    average = i;
                }
                if (array[j] <= p)
                {
                    tmp = array[average];
                    array[average] = array[j];
                    array[j] = tmp;
                    average = j;
                }
                i++;
                j--;
            }
        }

        static void QuickSorting(int[] array)
        {
            List<int> leftArr = new List<int>();
            List<int> rightArr = new List<int>();
            PrintArray(array);

            int a = array[array.Length / 2];
            int indexLeft = 5;

            for (int i = 0; i < array.Length; i++)
            {

                if (array[i] <= a)
                {
                    leftArr.Add(array[i]);
                }
                else
                    rightArr.Add(array[i]);
            }
            if (leftArr.Count > 2)
            {
                QuickSorting(leftArr.ToArray());
            }
            if (rightArr.Count > 2)
            {
                QuickSorting(rightArr.ToArray());
            }
        }

        static void PrintArray(int[] mass)
        {
            for (int i = 0; i < mass.Length; i++)
            {
                Console.Write(mass[i] + "  ");
            }
            Console.WriteLine();
        }
        static void PrintArray(List<int> mass)
        {
            for (int i = 0; i < mass.Count; i++)
            {
                Console.Write(mass[i] + "  ");
            }
            Console.WriteLine();
        }
    }
}
