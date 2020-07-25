using System;
using System.Collections.Generic;
using System.Text;

namespace Labyrinth
{
    class GameField
    {
        // Изначально был самым большим классом. Раскидал логику на 2
        // Главная цель клааса - отрисовка объектов
        // Матрица задается статической. По большому счету для тестирования и отладки
        public int Rows = 10;
        public int Columns = 10;
        public string[,] field;
        public (int, int) startPosition;
        public (int, int) endPosition;

        Random random = new Random();

        public GameField()
        {
            field = new string[Rows, Columns];       
        }
        // Логика такая: сперва создаем матрицу в конструкторе
        // Далее создаем дефолтовые объекты для отрисовки - '*'
        // Следующий шаг это создание Блоков (имеется ввиду блокирующие объекты)
        // Затем создаем отдлельно позицию начало - 'S'(Start) и выхода из лабиринта - 'F' (Finish)

        // Создание дефолтовых объектов (пустых строк)
        public void SetDefValue()
        {
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    field[i, j] = "*";
                }
            }
        }
        // Отрисовываем поле. Первый шаг это очистить консоль
        public void DisplayField()
        {
            Console.Clear();
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    Console.Write($"{field[i, j]}  ");
                }
                Console.WriteLine();
            }
        }
        // Нам надо видеть где мы находимся, Собственно этот метод 
        // устанавливает текущее значение в 'X'
        public void SetCurrentPosition((int, int) possition)
        {
            field[possition.Item1, possition.Item2] = "X";
        }
        // Собираем все в кучу при помощи этого метода
        // Сперва в поле прописываем значения Блоков
        // Затем, на случай совпадения координат, добавляем Вход и Выход
        public void SetStaticObjectsOnField(List<(int, int)> blocks)
        {
            foreach (var block in blocks)
            {
                field[block.Item1, block.Item2] = "0";
            }
            field[startPosition.Item1, startPosition.Item2] = "S";
            field[endPosition.Item1, endPosition.Item2] = "F";
        }
        // Изначально была задумка пройденный путь показывать отдельно
        // от текущего положения. Не реализованно, т.к. показывать весь
        // пусть как 'Х' смотрится не так уж и плохо, и 2я причина
        // тогда логично было бы запрещать ходить по пройденному пути
        // но в лабиринте это нормальное явление
        //public void SetPassedWayOnField(List<(int, int)> passedWay)
        //{
        //    foreach (var way in passedWay)
        //    {
        //        field[way.Item1, way.Item2] = "p";
        //    }
        //}
        // Генерируем точку Входа
        public void SetStartPosition()
        {
            startPosition = (0, random.Next(0, Columns-1));
        }
        // Генерируем точку выхода
        public void SetEndPosition()
        {          
            endPosition = (Rows - 1, random.Next(0, Columns-1));
        }


    }
}
