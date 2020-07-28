using System;
using System.Collections.Generic;
using System.Data;

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

            List<int> resultList;
            //QuikS(array);
            //resultList = SortingWithList(array, 0, array.Length);
            //Qs(array, 0, array.Length -1);
            Sorting(array, 0, array.Length - 1);
            PrintArray(array);

        }
        public static void Sorting(int[] arr, int first, int last)
        {
            int p = arr[(last - first) / 2 + first];
            int temp;
            int i = first, j = last;
            while (i <= j)
            {
                while (arr[i] < p && i <= last) ++i;
                while (arr[j] > p && j >= first) --j;
                if (i <= j)
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    ++i; --j;
                }
            }
            if (j > first) Sorting(arr, first, j);
            if (i < last) Sorting(arr, i, last);
        }


        static void Qs(int[] arr, int start, int lim)
        {
            int baseEl = (start + lim) / 2;
            int test = arr[baseEl];
            int i = start;
            int j = lim;
            int temp = 0;
            while (i <= j)
            {
                while (arr[i] < test && i <= last)
                {
                    i++;
                }
                while (arr[j] > test && j >= first)
                {
                    j--;
                }
                if (i <= j)
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                i++;
                j--;
                }
                if (j > 0)
                {
                    Qs(arr, 0, j);
                }
                //if (i < arr.Length-1)
                //{
                //    Qs(arr, );
                //}

            }

        static  List<int> SortingWithList(int[] arr, int start, int end)
        {
            List<int> leftList = new List<int>();
            List<int> rightList = new List<int>();
            int[] newArr = new int[arr.Length];
            int marker;
            int tempIndex = (end - start)/2 + start;
            Console.WriteLine($"Index: {tempIndex}, Value: {arr[tempIndex]}");
            //start = 0;
            //end = arr.Length;

            for (int i = start; i < end; i++)
            {
                if (arr[i] < arr[tempIndex])
                {
                    leftList.Add(arr[i]);
                }
                else
                    rightList.Add(arr[i]);
            }
            marker = leftList.Count;

            leftList.AddRange(rightList);
            return leftList;

        }

            Console.WriteLine($"i = {i}, j = {j}");
        }


        static public void QuikS(int[] array, int tempIndex)
        {
            tempIndex = array.Length / 2;
            int temp = 0;
            int p = array[tempIndex];

            Console.WriteLine($"Index: {tempIndex}, Value: {p}");
            int i = 0;
            int j = array.Length - 1;


            while (i < j)
            {
                if (array[i] > p && i < tempIndex)
                {
                    temp = array[i];
                    array[i] = p;
                    array[tempIndex] = temp;
                    tempIndex = i;
                }
                if (array[j] <= p && j > tempIndex)
                {
                    temp = array[j];
                    array[j] = p;
                    array[tempIndex] = temp;
                    tempIndex = j;
                }
                for (int v = 0; v < array.Length; v++)
                i++;
                j--;
            }
            Console.WriteLine($"Index: {tempIndex}, Value: {p}");
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

        public static void sorting(int[] arr, int first, int last)
        {
            int p = arr[(last - first) / 2 + first];
            int temp;
            int i = first, j = last;
            while (i <= j)
            {
                while (arr[i] < p && i <= last) ++i;
                while (arr[j] > p && j >= first) --j;
                if (i <= j)
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    ++i; --j;
                }
            }
            if (j > first) sorting(arr, first, j);
            if (i < last) sorting(arr, i, last);
        }
    }
}
