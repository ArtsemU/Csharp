using System;
using System.Collections.Generic;

namespace Labyrinth
{
    class ObjectOnField
    {
        // Главная цель класса - генерация объектов
        // Список List<(int, int)> listCoordPassedWay; не реализован
        //List<(int, int)> listCoordPassedWay;
        (int, int) Coord { get; set; }
        List<(int, int)> listCoordBlocks;
        Random random = new Random();

        public ObjectOnField()
        {
            listCoordBlocks = new List<(int, int)>();
            //listCoordPassedWay = new List<(int, int)>();
        }
        // Генерируем рандомно препятствия лабиринта
        // Изначально класс ничего не знает про какое поле будет в игре
        public void SetRandomBlock(string[,] array)
        {
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;

            for (int i = 0; i < (rows + columns); i++)
            {
                listCoordBlocks.Add((random.Next(0, rows), random.Next(0, columns)));
            }
        }
        // Геттер
        public List<(int, int)> GetListBlocks()
        {
            return listCoordBlocks;
        }
        // Проверка возможности хода
        // Если вышли за пределы массива - то false
        // Попали на блок - false
        public bool IsPossibleStep(string[,] array, (int, int) possibleStep)
        {
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;
            if ((possibleStep.Item1 < 0 || possibleStep.Item1 >= rows || possibleStep.Item2 < 0 || possibleStep.Item2 >= rows) || listCoordBlocks.Contains(possibleStep))
            {
                return false;
            }
            else return true;
        }
    }
}
