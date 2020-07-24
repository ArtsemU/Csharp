using System;
using System.Collections.Generic;
using System.Text;

namespace Labyrinth
{
    class Logic
    {
        int limitSteps = 10;
        GameField GameField { get; set; }
        ObjectOnField ObjOnField { get; set; }
        (int, int) currentPosition;

        public Logic()
        {
            GameField = new GameField();
            ObjOnField = new ObjectOnField();
        }                
    }
}
