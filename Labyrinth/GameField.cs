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
        public (int, int) startPosition;
        public (int, int) endPosition;
        //List<(int, int)> PassedWay;

        Random random = new Random();

        public GameField()
        {
            field = new string[Rows, Columns];
            //PassedWay = new List<(int, int)>();
        }

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

        public void SetCurrentPosition((int, int) possition)
        {

            field[possition.Item1, possition.Item2] = "X";
        }

        public void SetStaticObjectsOnField(List<(int, int)> blocks)
        {
            foreach (var block in blocks)
            {
                field[block.Item1, block.Item2] = "0";
            }

            field[startPosition.Item1, startPosition.Item2] = "S";
            field[endPosition.Item1, endPosition.Item2] = "F";
        }

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
