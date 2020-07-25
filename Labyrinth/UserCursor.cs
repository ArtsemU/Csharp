using System;
using System.Collections.Generic;
using System.Text;

namespace Labyrinth
{
    class UserCursor
    {
        (int, int) currentPosition { get; set; }

        public UserCursor()
        {

        }
        public (int, int) GetCurrentPosition()
        {
            return currentPosition;        
        }
        public (int, int) LeftStep((int, int) currentPosition)
        {
            return (currentPosition.Item1, currentPosition.Item2 - 1);
        }
        public (int, int) RightStep((int, int) currentPosition)
        {
            return (currentPosition.Item1, currentPosition.Item2 + 1);
        }
        public (int, int) UpStep((int, int) currentPosition)
        {
            return (currentPosition.Item1 - 1, currentPosition.Item2);
        }
        public (int, int) DownStep((int, int) currentPosition)
        {
            return (currentPosition.Item1+1, currentPosition.Item2);
        }
    }
}
