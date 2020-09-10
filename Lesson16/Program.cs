using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Fibonachi");
            Fibonachi(15);
            Console.WriteLine();

            Console.WriteLine("2. Преобразовать его в другое число, цифры которого будут следовать в обратном порядке");
            NumberRevers(112233);
            Console.WriteLine();

            Console.WriteLine("3. Заменить все положительные элементы массива на противоположные по знаку, а все отрицательные  на 0");
            int[] arr3 = new[] { -3, 0, -2, 4, -6, 1 };
            ChangeNumbers(arr3);
            Console.WriteLine();

            Console.WriteLine("4. Вывести элементы числового массива, которые больше, чем элементы, стоящие перед ними");
            int[] arr4 = new[] { 3, 9, 8, 4, 5, 1 };
            PrintNumberMoreThatPrevious(arr4);
            Console.WriteLine();

            Console.WriteLine("5. Записать в массив арифметическую и геометрическую прогрессию");
            // a0 + (n - 1)*b
            ArithmeticProgression(10, 1, 1);
            // b1*q^n
            GeometricProgression(10, 1, 2);

            Console.ReadLine();
        }
        public static void Fibonachi(int n)
        {
            List<int> list = new List<int>();
            list.Add(0);
            list.Add(1);

            for (int i = 2; i < n; i++)
            {
                list.Add(list[i-1] + list[i-2]);
            }

            foreach (var item in list)
            {
                Console.Write($"{item} ");
            }
        }

        public static List<int> ArithmeticProgression(int n, int a0, int b)
        {
            List<int> Arith = new List<int>();
            Console.WriteLine("ArithmeticProgression");
            Arith.Add(0);
            for (int i = 1; i <= n; i++)
            {
                Arith.Add(a0 + (i - 1) * b);
                Console.WriteLine(Arith[i]);
            }
            return Arith;
        }

        public static List<double> GeometricProgression(int n, double b1, double q)
        {
            List<double> Geom = new List<double>();
            Console.WriteLine("GeometricProgression");
            Geom.Add(1);
            for (int i = 1; i <= n; i++)
            {
                Geom.Add(b1 * Math.Pow(q, i - 1));
                Console.WriteLine(Geom[i]);
            }
            return Geom;
        }

        public static void PrintNumberMoreThatPrevious(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] < arr[i + 1])
                {
                    Console.WriteLine(arr[i + 1]);
                }
            }
        }

        public static void ChangeNumbers(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    arr[i] *= -1;
                }
                else
                    arr[i] = 0;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
        }

        public static void NumberRevers(int num)
        {
            string str = num.ToString();
            string res = "";

            for (int i = str.Length-1; i >=0; i--)
            {
                res += str[i];
            }

            int result = Int32.Parse(res);
            Console.WriteLine(result);
        }
    }
}
