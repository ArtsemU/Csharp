using System;
using System.Collections.Generic;
using System.Text;

namespace Labyrinth
{
    class GameField
    {
        public int Rows = 10;
        public int Columns = 10;
        public string[,] field;
        Random random = new Random();

        public GameField()
        {
            field = new string[Rows, Columns];       
        }

        public void SetDefValue(string[,] mas)
        {
            int rows = mas.GetUpperBound(0) + 1;
            int columns = mas.Length / rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    mas[i, j] = "*";
                }
            }
        }
        public void DisplayField()
        {
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    Console.Write($"{field[i, j]}  ");
                }
                Console.WriteLine();
            }
        }
        public void SetBlocksOnField(List<(int, int)> blocks)
        {
            foreach (var block in blocks)
            {
                field[block.Item1, block.Item2] = "0";
            }
        }
        public void SetPassedWayOnField(List<(int, int)> passedWay)
        {
            foreach (var way in passedWay)
            {
                field[way.Item1, way.Item2] = "p";
            }
        }
        public (int, int) SetStartPosition()
        {
            int x0 = 0;
            int y0 = random.Next(0, Columns);
            field[x0, y0] = "S";
            return (x0, y0);
        }
        public (int, int) SetEndPosition()
        {
            int x1 = Rows - 1;
            int y1 = random.Next(0, Columns);
            field[x1, y1] = "F";
            return (x1, y1);
        }


    }
}
