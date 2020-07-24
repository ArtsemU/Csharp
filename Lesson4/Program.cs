using System;

namespace Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a integer number:");
            

            string[,] mas = {     { "*", "*", "*" }, 
                                  { "*", "*", "*" }, 
                                  { "*", "*", "*" } };

            int rows = mas.GetUpperBound(0) + 1;
            int columns = mas.Length / rows;
            mas[0, 0] = "0";
            // или так
            // int columns = mas.GetUpperBound(1) + 1;

            for (int i = 0; i < rows; i++)
            {                
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{mas[i, j]} \t");
                }
                Console.WriteLine();
            }
            // ------
            while (true)
            {
                
                mas[0, 0] = "*";
                mas[0, 1] = "0";
                Console.ReadKey();
                Console.Clear();
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        Console.Write($"{mas[i, j]} \t");
                    }
                    Console.WriteLine();
                }
                break;
            }
            Console.ReadKey();

        }
        public static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
        }
    }
}
