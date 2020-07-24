using System;
using System.Collections.Generic;

namespace Labyrinth
{
    class ObjectOnField
    {
        public int x;
        public int y;
        (int, int) Coord { get; set; }
        List<(int, int)> listCoordBlocks;
        List<(int, int)> listCoordPassedWay;
        Random random = new Random();

        public ObjectOnField()
        {
            listCoordBlocks = new List<(int, int)>();
            listCoordPassedWay = new List<(int, int)>();
        }

        public void SetRandomBlock(string[,] array)
        {
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;

            for (int i = 0; i < (rows + columns); i++)
            {
                listCoordBlocks.Add((random.Next(0, rows), random.Next(0, columns)));
            }
        }
        public List<(int, int)> GetListBlocks()
        {
            return listCoordBlocks;
        }

        public bool IsPossibleStep(string[,] array, (int, int) possibleStep)
        {
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;
            if ((possibleStep.Item1 < 0 || possibleStep.Item1 > rows || possibleStep.Item2 < 0 || possibleStep.Item2 > rows) && !listCoordBlocks.Contains(possibleStep))
            {
                return true;
            }
            else return false;
        }


    }
}
