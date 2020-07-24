using System;

namespace Lesson5HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            
            Console.WriteLine("Определить значение и номер последнего отрицательного элемента одномерного массива размером [8] элементов.");
            int[] array = new int[8];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-10, 10);
            }
            foreach (var item in array)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            int negativeVal = array[0];
            int negativeIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    negativeVal  = array[i];
                    negativeIndex = i;
                }
            }
            Console.WriteLine($"Last negative number in array is {negativeVal}, with index {negativeIndex}");
            Console.WriteLine("Please! Press anykey");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("В двумерном массиве в каждой строке все элементы, расположенные после максимального, заменить на 0.");
            int[,] arrayTwo = new int[8, 8];

            int rows = arrayTwo.GetUpperBound(0) + 1;
            int columns = arrayTwo.Length / rows;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    arrayTwo[i, j] = random.Next(-10, 10);
                }
            }
            Console.WriteLine("Array before changing");
            PrintArray(arrayTwo);
            for (int i = 0; i < rows; i++)
            {
                int maxVal = arrayTwo[i, 0];
                int maxIndexVal = 0;
                for (int j = 0; j < columns; j++)
                {
                    if (arrayTwo[i, j] > maxVal)
                    {
                        maxVal = arrayTwo[i, j];
                        maxIndexVal = j;
                    }
                }

                for (int z = maxIndexVal + 1; z < columns; z++)
                {
                    arrayTwo[i, z] = 0;
                }
            }
            Console.WriteLine("Array after changing");
            PrintArray(arrayTwo);
            Console.WriteLine("Please! Press anykey");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Переделать 2ое задание с использованием массива массивов.");
            int[] lenghtsArray = new int[] { 8, 10, 6, 9, 3};
            int[][] arrayThree = new int[5][];
            
            for (int i = 0; i < lenghtsArray.Length; i++)
            {
                arrayThree[i] = new int[lenghtsArray[i]];
                for (int j = 0; j < arrayThree[i].Length; j++)
                {
                    arrayThree[i][j] = random.Next(-10, 10);
                }               
            }
            Console.WriteLine("Array before changing");
            PrintArray(arrayThree);
            for (int i = 0; i < arrayThree.Length; i++)
            {
                int maxVal = arrayTwo[i, 0];
                int maxIndexVal = 0;
                for (int j = 0; j < arrayThree[i].Length; j++)
                {
                    if (arrayThree[i][j] > maxVal)
                    {
                        maxVal = arrayThree[i][j];
                        maxIndexVal = j;
                    }
                }
                for (int k = maxIndexVal + 1; k < arrayThree[i].Length; k++)
                {
                    arrayThree[i][k] = 0;
                }
            }
            Console.WriteLine("Array after changing");
            PrintArray(arrayThree);
            Console.WriteLine("Please! Press anykey");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Подсчитать количество гласных в строке");
            string lowels = "eyuioa";
            string testString = "We the People of the United States, in Order to form a more perfect Union...";
            int count = 0;
            for (int i = 0; i < testString.Length; i++)
            {
                if (lowels.Contains(testString[i]))
                {
                    count++;
                }
            }
            Console.WriteLine(testString);
            Console.WriteLine($"Test string cointein {count} lowel letters");
            Console.WriteLine("Please! Press anykey");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Заменить в строке все маленькие «а» на большие «А»");
            string testString2 = "Visual Studio lets you code, compile, run, debug, profile, and publish your applications from an integrated development environment for Windows or Mac.";
            string newString = "";
            for (int i = 0; i < testString2.Length; i++)
            {
                if (testString2[i] == 'a')
                {
                    newString += "A";
                }
                else
                {
                    newString += testString2[i];
                }
            }
            Console.WriteLine(testString2);
            Console.WriteLine(newString);
        }
        public static void PrintArray(int[,] array)
        {
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{array[i, j]}\t");
                }
                Console.WriteLine();
            }
        }

        public static void PrintArray(int[][] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write($"{array[i][j]}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
