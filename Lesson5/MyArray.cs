using System;
using System.Collections.Generic;

namespace Lesson5
{
    class MyArray
    {
        Random random = new Random();
        public int Rows { get; set; }
        public int Columns { get; set; }
        public int[,] Array { get; set; }

        public MyArray(int rows, int column)
        {
            Rows = rows;
            Columns = column;

        }

        public void PrintArray(int[,] array)
        {
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        public void SetValuesForArray(int[,] array)
        {
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = random.Next(-10, 10);
                }
            }
        }

        public void FindMaxAndChangeValues(int[,] array)
        {
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;
            for (int i = 0; i < rows; i++)
            {
                int maxVal = array[i, 0];
                int maxIndexVal = 0;
                for (int j = 0; j < columns; j++)
                {
                    if (array[i, j] > maxVal)
                    {
                        maxVal = array[i, j];
                        maxIndexVal = j;
                    }
                }

                for (int z = maxIndexVal + 1; z < columns; z++)
                {
                    array[i, z] = 0;
                }
            }
        }

        public void FindMaxAndUseTyple(int[,] array)
        {
            Tuple<int, int> coord;


            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;
            for (int i = 0; i < rows; i++)
            {
                int maxVal = array[i, 0];
                int maxIndexVal = 0;
                for (int j = 0; j < columns; j++)
                {
                    if (array[i, j] > maxVal)
                    {
                        maxVal = array[i, j];
                        maxIndexVal = j;
                    }
                }

                for (int z = maxIndexVal + 1; z < columns; z++)
                {
                    array[i, z] = 0;
                }
            }
        }

       
    }
}
