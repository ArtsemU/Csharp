using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            #region main code
            //Random random = new Random();


            //string[] accountings = new string[] { "Petr", "Ivan", "Anna"};
            //string[] developers = new string[] { "Igor", "Alesha"};
            //string[][] persons = new string[][] { accountings, developers };

            //int[] array1 = new int[8];

            //for (int i = 0; i < array1.Length; i++)
            //{
            //    array1[i] = random.Next(-10, 10);
            //}
            //PrintArray(array1);

            //int minVal = 0;
            //int minIndexVal = 0;
            //for (int i = 0; i < array1.Length; i++)
            //{
            //    if (array1[i] < 0)
            //    {
            //        minVal = array1[i];
            //        minIndexVal = i;
            //    }
            //}
            //Console.WriteLine($"Last negative number is {minVal}, with Index {minIndexVal}");

            // 2
            //int[,] array2 = new int[3, 8];
            //Console.WriteLine(array2.Length);

            //int rows = array2.GetUpperBound(0) + 1;
            //int columns = array2.Length / rows;

            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < columns; j++)
            //    {
            //        array2[i, j] = random.Next(-10, 10);
            //    }
            //    Console.WriteLine();
            //}
            //PrintArray(array2);
            //Console.WriteLine();

            // Find max value


            //for (int i = 0; i < rows; i++)
            //{
            //    int maxVal = array2[i, 0];
            //    int maxIndexVal = 0;
            //    for (int j = 0; j < columns; j++)
            //    {
            //        if (array2[i, j] > maxVal)
            //        {
            //            maxVal = array2[i, j];
            //            maxIndexVal = j;
            //        }
            //    }

            //    for (int z = maxIndexVal + 1; z < columns; z++)
            //    {
            //        array2[i, z] = 0;
            //    }
            //}
            //PrintArray(array2);
            #endregion
            DateTime dateTime = new DateTime();
            MyArray myArray = new MyArray(20000, 20000);
            int[,] arr = new int[myArray.Rows, myArray.Columns];
            int[,] arrTwo = new int[myArray.Rows, myArray.Columns];
            myArray.SetValuesForArray(arrTwo);

            //Console.Clear();
            myArray.SetValuesForArray(arr);
            var arrCopy = arr.Clone();
           // myArray.PrintArray(arr);
            //Console.ReadKey();
           // Console.Clear();
            var timeOne1 = DateTime.Now;
            myArray.FindMaxAndChangeValues(arr);
           // myArray.PrintArray(arr);
            var timeOne2 = DateTime.Now;
            Console.WriteLine($"Time execution {timeOne2 - timeOne1}");

            Tuple<int, int> coord;

            List<(int, int)> myList = new List<(int, int)>();

            var time1 = DateTime.Now;
            int rows = arrTwo.GetUpperBound(0) + 1;
            int columns = arrTwo.Length / rows;
            
            for (int i = 0; i < rows; i++)
            {
                int maxVal = arrTwo[i, 0];
                int maxIndexVal = 0;
                for (int j = 0; j < columns; j++)
                {
                    if (arr[i, j] > maxVal)
                    {
                        maxVal = arrTwo[i, j];
                        maxIndexVal = j;
                    }
                }

                for (int z = maxIndexVal + 1; z < columns; z++)
                {
                    myList.Add((i, z));
                }                
            }

            
            foreach (var item in myList)
            {
                arrTwo[item.Item1, item.Item2] = 0;               
            }
            var time2 = DateTime.Now;
           // myArray.PrintArray(arrTwo);
            Console.WriteLine($"Time execution {time2 - time1}");
        }
        #region static class
        //public static void PrintArray(int[] array)
        //{
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        Console.Write($"{array[i]} ");
        //    }
        //    Console.WriteLine();
        //}
        //public static void PrintArray(int[,] array)
        //{
        //    int rows = array.GetUpperBound(0) + 1;
        //    int columns = array.Length / rows;

        //    for (int i = 0; i < rows; i++)
        //    {
        //        for (int j = 0; j < columns; j++)
        //        {
        //            Console.Write($"{array[i, j]} ");
        //        }
        //        Console.WriteLine();
        //    }
        //}
        #endregion
    }
}
